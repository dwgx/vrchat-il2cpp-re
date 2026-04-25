#!/usr/bin/env python3
"""
Full scene-traversal component identifier (v2).

Dynamic class resolution — no hardcoded heap VAs.

Strategy:
  1. Attach to VRChat via Frida
  2. Validate Unity class VAs from dump at runtime (handles ASLR shift)
  3. Discover scene roots via static field scan + GC heap scan
  4. Traverse full scene hierarchy, enumerate all components
  5. Match against ComplexComponent class VAs
  6. Save results + optional auto-merge into dump

Usage:
  python tools/identify_components_v2.py
  python tools/identify_components_v2.py --merge   # also merge names into dump
  (VRChat.exe --no-vr must be running)
"""

import json, sys, re, time, argparse, frida
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
PRECISE_DUMP = BASE_DIR / 'data' / 'precise_dump.json'
DEOBF_DUMP = BASE_DIR / 'output' / 'deobfuscated_dump.json'
SCRIPT_PATH = BASE_DIR / 'tools' / 'identify_components_v2.js'
PREV_RESULTS = BASE_DIR / 'output' / 'runtime_component_names.json'
PREV_V1 = BASE_DIR / 'output' / 'component_identifications.json'
OUTPUT_PATH = BASE_DIR / 'output' / 'runtime_component_names.json'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

# Unity classes needed for method resolution (name, namespace, dump_key)
UNITY_CLASSES = [
    ('Component', 'UnityEngine'),
    ('Object', 'UnityEngine'),
    ('Transform', 'UnityEngine'),
    ('GameObject', 'UnityEngine'),
]


def load_class_vas_from_dump():
    """Load class VAs from precise_dump.json as candidate addresses."""
    dump_path = PRECISE_DUMP if PRECISE_DUMP.exists() else DEOBF_DUMP
    print(f"  Loading class VAs from {dump_path.name}...")
    with open(dump_path, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Build lookup: (name, namespace) -> VA
    class_vas = {}
    for ns, types in dump.get('namespaces', {}).items():
        for t in types:
            name = t.get('name', '')
            va = t.get('va', '')
            if name and va:
                class_vas[(name, ns)] = va
    return class_vas, dump


def load_complex_components(dump):
    """Find all ComplexComponent classes to identify."""
    # Try deobfuscated dump first (has renamed names)
    if DEOBF_DUMP.exists():
        with open(DEOBF_DUMP, 'r', encoding='utf-8') as f:
            deobf = json.load(f)
    else:
        deobf = dump

    complex_classes = []
    for ns, types in deobf.get('namespaces', {}).items():
        for t in types:
            name = t.get('name', '')
            va = t.get('va', '')
            if 'ComplexComponent' in name and va:
                complex_classes.append({
                    'deobf_name': name,
                    'va': va,
                    'ns': ns,
                    'method_count': len(t.get('methods', [])),
                    'field_count': len(t.get('fields', []) if isinstance(t.get('fields'), list) else t.get('fields', {}).keys()),
                })
    return complex_classes


def load_previous_identifications():
    """Load previously identified names for comparison."""
    prev = {}
    if PREV_RESULTS.exists():
        with open(PREV_RESULTS, 'r', encoding='utf-8') as f:
            data = json.load(f)
        for ident in data.get('identifications', []):
            va = ident.get('va', '').upper()
            if va:
                prev[va] = ident
    return prev


def load_v1_instances():
    """Load instance pointers from v1 results (may be stale)."""
    instances = []
    if PREV_V1.exists():
        with open(PREV_V1, 'r', encoding='utf-8') as f:
            v1 = json.load(f)
        for entry in v1:
            if entry.get('instances', 0) > 0:
                for d in entry.get('details', []):
                    if d.get('ptr'):
                        instances.append(d['ptr'])
    return instances


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--merge', action='store_true', help='Also merge into dump after identification')
    args = parser.parse_args()

    print("=" * 60)
    print("  Component Identifier v2 — Dynamic Scene Traversal")
    print("=" * 60)

    # Step 0: Load data
    class_vas, dump = load_class_vas_from_dump()
    complex_classes = load_complex_components(dump)
    prev_idents = load_previous_identifications()
    v1_instances = load_v1_instances()

    all_class_vas = [c['va'] for c in complex_classes]
    print(f"  {len(complex_classes)} ComplexComponent classes to identify")
    print(f"  {len(prev_idents)} previously identified")
    print(f"  {len(v1_instances)} v1 instance pointers (may be stale)")

    # Step 1: Attach to VRChat
    print("\nAttaching to VRChat...")
    try:
        session = frida.attach("VRChat.exe")
    except frida.ProcessNotFoundError:
        print("ERROR: VRChat.exe not running. Start with: VRChat.exe --no-vr")
        sys.exit(1)

    with open(SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script_code = f.read()

    script = session.create_script(script_code)
    script.load()
    api = script.exports_sync

    # Step 2: Dynamically resolve Unity classes
    print("\nResolving Unity classes...")
    resolved = {}
    for name, ns in UNITY_CLASSES:
        candidate_va = class_vas.get((name, ns))
        if not candidate_va:
            print(f"  WARNING: {ns}.{name} not found in dump")
            continue

        result = api.find_class(candidate_va, name, ns)
        if 'error' in result:
            print(f"  FAILED: {ns}.{name} — {result['error']}")
        else:
            resolved[name] = result['va']
            marker = '✓' if result['va'] == candidate_va else '~'
            print(f"  {marker} {ns}.{name}: {result['va']}")

    required = ['Component', 'Object', 'Transform', 'GameObject']
    missing = [n for n in required if n not in resolved]
    if missing:
        print(f"\nERROR: Cannot resolve classes: {', '.join(missing)}. Aborting.")
        session.detach()
        sys.exit(1)

    # Step 3: Init ALL methods from class metadata (no live instances needed)
    print("\nInitializing methods from class metadata...")
    init_result = api.init_all(
        resolved['Component'], resolved['Object'],
        resolved['Transform'], resolved['GameObject']
    )
    if 'error' in init_result:
        print(f"  ERROR: {init_result['error']}")
        session.detach()
        sys.exit(1)
    for name, addr in init_result['methods'].items():
        print(f"  {name}: {addr}")

    # Step 5+6: Targeted heap scan — find instances of each ComplexComponent class
    print(f"\nScanning heap for {len(all_class_vas)} ComplexComponent classes (batched)...")
    all_matches = []
    batch_size = 10  # process 10 classes per RPC call to avoid timeout
    for batch_start in range(0, len(all_class_vas), batch_size):
        batch_end = min(batch_start + batch_size, len(all_class_vas))
        print(f"  Batch {batch_start}-{batch_end}/{len(all_class_vas)}...", end=' ', flush=True)
        try:
            batch_result = api.scan_targeted_heap(all_class_vas, batch_start, batch_size)
            matches = batch_result.get('matches', [])
            all_matches.extend(matches)
            print(f"{len(matches)} instances found")
        except Exception as e:
            print(f"ERROR: {e}")
            break

    scan_result = {
        'total_matches': len(all_matches),
        'total_gos_visited': len(set(m.get('gameObject', '') for m in all_matches)),
        'matches': all_matches
    }

    print(f"  GameObjects visited: {scan_result['total_gos_visited']}")
    print(f"  ComplexComponent matches: {scan_result['total_matches']}")

    # Step 7: Deduplicate and organize
    by_klass = {}
    for m in scan_result.get('matches', []):
        va = m['klassVA']
        if va not in by_klass:
            by_klass[va] = []
        by_klass[va].append(m)

    # Map runtime klass VAs to deobfuscated names
    # Note: dump VAs may differ from runtime VAs due to ASLR
    # Build both-direction lookup
    va_to_info = {}
    for c in complex_classes:
        va_to_info[c['va']] = c
        va_to_info[c['va'].upper()] = c
        va_to_info[c['va'].lower()] = c

    identifications = []
    for va, matches in sorted(by_klass.items()):
        info = va_to_info.get(va, va_to_info.get(va.upper(), {}))
        go_names = list(set(m['gameObject'] for m in matches if m.get('gameObject')))
        orig_class = matches[0].get('className', '?') if matches else '?'

        if len(go_names) == 1:
            suggested = go_names[0].replace('(Clone)', '').strip()
            confidence = 'high'
        elif len(go_names) > 1:
            suggested = go_names[0].replace('(Clone)', '').strip()
            confidence = 'medium'
        else:
            suggested = info.get('deobf_name', '?')
            confidence = 'low'

        identifications.append({
            'deobf_name': info.get('deobf_name', orig_class),
            'va': va,
            'gameObject': go_names[0] if go_names else None,
            'all_gameObjects': go_names,
            'instance_count': len(matches),
            'suggested_name': suggested,
            'confidence': confidence,
            'instance_ptrs': [m.get('instancePtr') for m in matches if m.get('instancePtr')][:5],
        })

    # Step 8: Compare with previous results
    new_count = 0
    updated_count = 0
    for ident in identifications:
        va_key = ident['va'].upper()
        if va_key in prev_idents:
            old = prev_idents[va_key]
            if ident['suggested_name'] != old.get('suggested_name'):
                updated_count += 1
        else:
            new_count += 1

    # Print results
    print(f"\n{'=' * 60}")
    print(f"  Results: {len(identifications)} components identified")
    print(f"  New: {new_count} | Updated: {updated_count} | Previously known: {len(prev_idents)}")
    print(f"{'=' * 60}")

    for ident in sorted(identifications, key=lambda x: ('a' if x['confidence'] == 'high' else 'b' if x['confidence'] == 'medium' else 'c')):
        conf = ident['confidence']
        marker = '*' if conf == 'high' else '+' if conf == 'medium' else 'o'
        is_new = ident['va'].upper() not in prev_idents
        new_tag = ' [NEW]' if is_new else ''
        print(f"  {marker} {ident['deobf_name']:45s} -> {ident['suggested_name']}{new_tag}")
        if len(ident.get('all_gameObjects', [])) > 1:
            print(f"    (also on: {', '.join(ident['all_gameObjects'][1:])})")

    remaining = len(complex_classes) - len(identifications) - len(prev_idents) + len(set(i['va'].upper() for i in identifications) & set(prev_idents.keys()))
    print(f"\n  Still unidentified: ~{remaining} / {len(complex_classes)}")

    # Save results
    output = {
        'generated_by': 'identify_components_v2.py',
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'method': 'Dynamic class resolution + scene traversal + static/heap scan',
        'stats': {
            'gos_visited': scan_result.get('total_gos_visited', 0),
            'total_matches': scan_result.get('total_matches', 0),
            'unique_classes': len(identifications),
            'high_confidence': sum(1 for i in identifications if i['confidence'] == 'high'),
            'medium_confidence': sum(1 for i in identifications if i['confidence'] == 'medium'),
            'new_discoveries': new_count,
        },
        'identifications': identifications,
    }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, ensure_ascii=False, indent=2)
    print(f"\nSaved to {OUTPUT_PATH.name}")

    session.detach()

    if args.merge:
        print("\nRunning merge_runtime_names.py...")
        import subprocess
        subprocess.run([sys.executable, str(BASE_DIR / 'tools' / 'merge_runtime_names.py')])


if __name__ == '__main__':
    main()
