#!/usr/bin/env python3
"""
analyze_global_async.py — Static analysis of Global namespace compiler-generated types

Categorizes 7,000+ classes in the Global namespace:
  - Async state machines (MoveNext + SetStateMachine)
  - Iterators (MoveNext + get_Current)
  - Lambda containers (<>c)
  - Display classes (<>c__DisplayClass — captured locals)
  - Obfuscated (Beebyte ÌÍÎÏ names)
  - Regular named classes

Traces parent VRChat systems by parsing generated class names and method references.

Usage:
  python tools/analyze_global_async.py                     # full analysis
  python tools/analyze_global_async.py --filter network    # filter by system
  python tools/analyze_global_async.py --type async        # only async state machines
  python tools/analyze_global_async.py --top 50            # top 50 complex classes
  python tools/analyze_global_async.py --export-hooks      # export hookable RVAs
"""

import json, sys, re, argparse
from pathlib import Path
from collections import defaultdict, Counter

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE_DIR / 'output' / 'deobfuscated_dump.json'
OUTPUT_PATH = BASE_DIR / 'output' / 'global_async_analysis.json'

# ---- Classification patterns ----

RE_ASYNC_SM = re.compile(r'<(.+?)>d__(\d+)')
RE_LOCAL_FUNC = re.compile(r'<<(.+?)>g__(.+?)\|(\d+)_(\d+)>d')
RE_ITERATOR = re.compile(r'<(.+?)>c__Iterator(\d*)')
RE_DISPLAY = re.compile(r'<>c__DisplayClass(\d+)_(\d+)')
RE_LAMBDA = re.compile(r'^<>c$')
RE_OBFUSCATED = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')
RE_OBFUSCATED_METHOD = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

# System classification keywords
SYSTEM_KEYWORDS = {
    'network':       ['Network', 'Photon', 'RPC', 'Sync', 'Send', 'Recv', 'Socket',
                      'Connection', 'Packet', 'Channel', 'Peer', 'OpCode'],
    'auth':          ['Auth', 'Login', 'Token', 'Session', 'Cookie', 'Credential',
                      'OAuth', 'Password', '2FA'],
    'avatar':        ['Avatar', 'Impostor', 'LOD', 'Bone', 'Mesh', 'Renderer',
                      'Skin', 'Animator', 'Gesture', 'Expression', 'Muscle'],
    'world':         ['World', 'Room', 'Scene', 'Instance', 'Join', 'Leave',
                      'Spawn', 'Portal'],
    'udon':          ['Udon', 'Program', 'VM', 'Script', 'Sandbox', 'Heap'],
    'ui':            ['UI', 'Canvas', 'Button', 'Menu', 'Panel', 'Screen',
                      'Popup', 'Dialog', 'Toggle', 'Slider', 'Scroll'],
    'download':      ['Download', 'Upload', 'Asset', 'Bundle', 'Cache', 'Content',
                      'Http', 'Request', 'Response', 'Web', 'URL'],
    'social':        ['Friend', 'Invite', 'Notification', 'Message', 'Chat',
                      'Status', 'Moderation', 'Block', 'Mute'],
    'audio':         ['Audio', 'Voice', 'Sound', 'Mic', 'Speaker', 'VOIP',
                      'Spatializer', 'Lip'],
    'video':         ['Video', 'Stream', 'Player', 'AVPro', 'YouTube'],
    'security':      ['Security', 'EAC', 'AntiCheat', 'Integrity', 'Hash',
                      'Verify', 'Signature', 'Whitelist', 'Blacklist'],
    'economy':       ['Economy', 'Store', 'Purchase', 'Product', 'Transaction',
                      'Credit', 'Listing', 'Tilia'],
    'tracking':      ['Tracking', 'IK', 'Controller', 'HMD', 'Haptic', 'Input',
                      'SteamVR', 'OpenXR', 'Oculus'],
    'serialization': ['Serialize', 'Deserialize', 'FlatBuffer', 'Quantize',
                      'Encode', 'Decode', 'Marshal', 'Binary'],
    'api':           ['Api', 'REST', 'Endpoint', 'Pipeline', 'ApiModel',
                      'ApiContainer'],
    'image':         ['Image', 'Texture', 'Photo', 'Camera', 'Screenshot',
                      'Thumbnail', 'Picture'],
}


def classify_system(name, methods):
    """Classify which VRChat system a class belongs to based on name + methods."""
    scores = defaultdict(int)
    text = name + ' ' + ' '.join(methods)

    for system, keywords in SYSTEM_KEYWORDS.items():
        for kw in keywords:
            if kw.lower() in text.lower():
                scores[system] += 2 if kw.lower() in name.lower() else 1

    return max(scores, key=scores.get) if scores else 'unknown'


def analyze_class(cls):
    """Analyze and categorize a single class."""
    name = cls['name']
    methods = cls.get('methods', [])
    fields = cls.get('fields', [])
    parent = cls.get('parent', '')
    mp = cls.get('method_pointers', {})

    named = [m for m in methods if not RE_OBFUSCATED_METHOD.match(m)]
    obfuscated = [m for m in methods if RE_OBFUSCATED_METHOD.match(m)]

    info = {
        'name': name,
        'parent': parent,
        'method_count': len(methods),
        'field_count': len(fields),
        'named_methods': named,
        'obfuscated_method_count': len(obfuscated),
        'has_pointers': len(mp) > 0,
        'pointer_count': len(mp),
    }

    # Type classification
    has_move_next = 'MoveNext' in methods
    has_set_sm = 'SetStateMachine' in methods
    has_get_current = 'get_Current' in methods

    if has_move_next and has_set_sm:
        info['type'] = 'async_state_machine'
        m = RE_LOCAL_FUNC.search(name)
        if m:
            info['origin_method'] = m.group(1)
            info['local_func'] = m.group(2)
        else:
            m = RE_ASYNC_SM.search(name)
            if m:
                info['origin_method'] = m.group(1)
    elif has_move_next and has_get_current:
        info['type'] = 'iterator'
        m = RE_ASYNC_SM.search(name) or RE_ITERATOR.search(name)
        if m:
            info['origin_method'] = m.group(1)
    elif RE_LAMBDA.match(name):
        info['type'] = 'lambda_container'
    elif RE_DISPLAY.match(name):
        info['type'] = 'display_class'
    elif RE_OBFUSCATED.match(name):
        info['type'] = 'obfuscated'
    else:
        info['type'] = 'regular'

    info['system'] = classify_system(name, named)
    return info


def export_hookable_rvas(analyzed, dump, ga_base):
    """Export interesting methods as hookable RVAs for deep_probe."""
    hooks = []
    global_classes = {c['name']: c for c in dump['namespaces'].get('', [])}

    # Focus on async state machines with MoveNext — that's where the real logic lives
    for info in analyzed:
        if info['type'] != 'async_state_machine':
            continue
        if info['system'] == 'unknown':
            continue

        cls = global_classes.get(info['name'])
        if not cls:
            continue
        mp = cls.get('method_pointers', {})
        if 'MoveNext' not in mp:
            continue

        try:
            ptr = int(mp['MoveNext'], 16)
            rva = ptr - ga_base
            if 0 < rva < 0x20000000:
                hooks.append({
                    'className': info['name'][:60],
                    'methodName': 'MoveNext',
                    'rva': rva,
                    'system': info['system'],
                    'origin': info.get('origin_method', ''),
                })
        except (ValueError, TypeError):
            pass

    return hooks


def main():
    parser = argparse.ArgumentParser(description='Analyze Global namespace state machines')
    parser.add_argument('--filter', type=str, help='Filter by system keyword')
    parser.add_argument('--top', type=int, default=30, help='Show top N complex classes')
    parser.add_argument('--type', choices=['async', 'iterator', 'lambda', 'display', 'obfuscated', 'regular'],
                        help='Filter by class type')
    parser.add_argument('--export-hooks', action='store_true',
                        help='Export hookable MoveNext RVAs for deep_probe')
    args = parser.parse_args()

    print("=" * 60)
    print("  Global Namespace State Machine Analyzer")
    print("=" * 60)

    # Load
    print("\n[1/3] Loading dump...")
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    ga_base = int(dump['summary'].get('ga_base', '0'), 16)

    global_classes = dump['namespaces'].get('', [])
    print(f"  Global namespace: {len(global_classes)} classes")

    # Analyze
    print("[2/3] Analyzing...")
    analyzed = [analyze_class(cls) for cls in global_classes]

    # Stats
    type_counts = Counter(c['type'] for c in analyzed)
    system_counts = Counter(c['system'] for c in analyzed)
    total_methods = sum(c['method_count'] for c in analyzed)
    total_obfuscated = sum(c['obfuscated_method_count'] for c in analyzed)

    print(f"\n  === Type Distribution ({len(analyzed)} classes, {total_methods} methods) ===")
    for t, count in type_counts.most_common():
        pct = count / len(analyzed) * 100
        print(f"    {t:25s}: {count:5d} ({pct:4.1f}%)")

    print(f"\n  === System Classification ===")
    for s, count in system_counts.most_common(20):
        pct = count / len(analyzed) * 100
        print(f"    {s:25s}: {count:5d} ({pct:4.1f}%)")

    print(f"\n  Obfuscation: {total_obfuscated}/{total_methods} methods still obfuscated "
          f"({total_obfuscated/max(total_methods,1)*100:.1f}%)")

    # Apply filters
    results = analyzed
    if args.filter:
        kw = args.filter.lower()
        results = [c for c in results if
                   c['system'] == args.filter or
                   kw in c['name'].lower() or
                   any(kw in m.lower() for m in c.get('named_methods', []))]
        print(f"\n  Filtered by '{args.filter}': {len(results)} classes")

    type_map = {
        'async': 'async_state_machine', 'iterator': 'iterator',
        'lambda': 'lambda_container', 'display': 'display_class',
        'obfuscated': 'obfuscated', 'regular': 'regular',
    }
    if args.type:
        results = [c for c in results if c['type'] == type_map.get(args.type, args.type)]
        print(f"  Filtered by type '{args.type}': {len(results)} classes")

    # Top complex classes
    print(f"\n  === Top {args.top} Complex Classes ===")
    top = sorted(results, key=lambda c: c['method_count'], reverse=True)[:args.top]
    for i, c in enumerate(top):
        named = c['named_methods'][:5]
        named_str = ', '.join(named) if named else '(all obfuscated)'
        origin = c.get('origin_method', '')
        origin_str = f' <- {origin}' if origin else ''
        print(f"  {i+1:3d}. [{c['type'][:8]:8s}] {c['name'][:55]:55s} "
              f"{c['method_count']:3d}m {c['field_count']:3d}f "
              f"[{c['system']}]{origin_str}")
        if named and c['method_count'] > 3:
            print(f"       methods: {named_str}")

    # Async by system
    print(f"\n  === Async State Machines by System ===")
    async_by_system = defaultdict(list)
    for c in analyzed:
        if c['type'] == 'async_state_machine':
            async_by_system[c['system']].append(c)

    for system in sorted(async_by_system.keys(), key=lambda s: -len(async_by_system[s])):
        classes = async_by_system[system]
        print(f"\n  {system} ({len(classes)} state machines):")
        for c in sorted(classes, key=lambda x: -x['method_count'])[:8]:
            origin = c.get('origin_method', c['name'][:50])
            local = c.get('local_func', '')
            extra = f' -> {local}' if local else ''
            ptrs = f' [{c["pointer_count"]}p]' if c['has_pointers'] else ''
            print(f"    - {origin}{extra} ({c['method_count']}m{ptrs})")

    # Interesting obfuscated classes (high method count, has pointers)
    print(f"\n  === Top Obfuscated Classes (potential high-value targets) ===")
    obf = [c for c in analyzed if c['type'] == 'obfuscated' and c['has_pointers']]
    obf_top = sorted(obf, key=lambda c: c['method_count'], reverse=True)[:15]
    for c in obf_top:
        named = c['named_methods'][:3]
        named_str = ', '.join(named) if named else ''
        print(f"    {c['name'][:30]:30s} {c['method_count']:3d}m {c['field_count']:3d}f "
              f"parent={c['parent'][:20]:20s} {named_str}")

    # Export hooks
    if args.export_hooks:
        hooks = export_hookable_rvas(analyzed, dump, ga_base)
        hooks_path = BASE_DIR / 'output' / 'global_async_hooks.json'
        with open(hooks_path, 'w', encoding='utf-8') as f:
            json.dump(hooks, f, indent=2, ensure_ascii=False)
        print(f"\n  Exported {len(hooks)} hookable MoveNext RVAs to {hooks_path}")
        print(f"  Use with: deep_probe.py (add as custom hooks)")

    # Save report
    print(f"\n[3/3] Saving report...")
    report = {
        'summary': {
            'total_global_classes': len(global_classes),
            'total_methods': total_methods,
            'total_obfuscated_methods': total_obfuscated,
            'type_distribution': dict(type_counts),
            'system_distribution': dict(system_counts),
            'generated': __import__('time').strftime('%Y-%m-%d %H:%M:%S'),
        },
        'async_by_system': {
            s: [{
                'name': c['name'],
                'origin': c.get('origin_method', ''),
                'local_func': c.get('local_func', ''),
                'methods': c['method_count'],
                'fields': c['field_count'],
            } for c in cs]
            for s, cs in async_by_system.items()
        },
        'top_obfuscated': [{
            'name': c['name'],
            'methods': c['method_count'],
            'fields': c['field_count'],
            'parent': c['parent'],
            'named_methods': c['named_methods'][:10],
        } for c in obf_top],
    }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(report, f, indent=2, ensure_ascii=False)
    print(f"  Saved to {OUTPUT_PATH}")

    print(f"\n{'=' * 60}")
    print(f"  ANALYSIS COMPLETE")
    print(f"{'=' * 60}")


if __name__ == '__main__':
    main()
