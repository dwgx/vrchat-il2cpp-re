#!/usr/bin/env python3
"""
deep_probe.py — Deep system analysis via Frida method hooking

Probes VRChat internal systems by hooking methods from the deobfuscated dump.
Computes RVAs from dump method_pointers, installs Interceptor.attach at runtime.

Modes:
  room      — Room lifecycle: RoomManager, Photon handlers, auth events
  udon      — Udon VM: heap/stack ops, event dispatch, VM factory
  network   — Serialization: FlatBuffer encode/decode, quantization, recovery
  impostor  — Impostor system: avatar LOD, billboard lifecycle
  all       — Everything (may be noisy)

Usage:
  python tools/deep_probe.py --mode room
  python tools/deep_probe.py --mode udon --duration 120
  python tools/deep_probe.py --mode all --quiet
  python tools/deep_probe.py --mode network --duration 0   # until Ctrl+C
  (VRChat.exe --no-vr must be running)
"""

import json, sys, time, argparse, frida
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE_DIR / 'output' / 'deobfuscated_dump.json'
JS_PATH = Path(__file__).resolve().parent / 'deep_probe.js'
OUTPUT_DIR = BASE_DIR / 'output'

# ---- Probe target definitions ----
# (class_name, namespace_filter, method_list_or_None, read_arg_count)
# method_list=None → hook ALL methods with pointers (use carefully)

PROBE_TARGETS = {
    'room': [
        ('RoomManager', '', ['OnPlayerJoined', 'OnPlayerLeft', 'OnDestroy', 'Start', 'Awake'], 2),
        ('PhotonRoomHandler_01D0', '', ['OnCreatedRoom', 'OnJoinedRoom', 'OnLeftRoom'], 2),
        ('PhotonRoomHandler_E1A7', '', ['OnCreatedRoom', 'OnCustomAuthenticationFailed'], 2),
        ('PhotonRoomHandler_252B', '', ['OnLeftRoom'], 2),
        ('PhotonConnectionHandler_34AB', '', ['OnDisable', 'OnEnable'], 1),
        ('PhotonConnectionHandler_C364', '', ['OnConnectedToMaster', 'OnCustomAuthenticationResponse', 'OnCustomAuthenticationFailed'], 2),
        ('PhotonConnectionHandler_92CA', '', None, 1),
    ],
    'udon': [
        ('UdonBehaviour', 'VRC.Udon', [
            'SendCustomEvent', 'SendCustomNetworkEvent', 'get_HasError',
            'get_SyncMethod', 'RunProgram', 'RunEvent', 'InitializeUdonContent',
            'OnPreSerialization', 'OnPostSerialization', 'OnDeserialization',
        ], 3),
        ('AbstractUdonBehaviour', 'VRC.SDK3.Components', [
            'SendCustomEvent', 'SendCustomNetworkEvent',
            'GetProgramVariable', 'SetProgramVariable',
        ], 3),
        ('UdonHeap', 'VRC.Udon.Common', [
            'CheckHeapBounds', 'SetHeapVariable', 'GetHeapVariable',
            'CopyHeapVariable', 'InitializeHeapVariable',
        ], 3),
        ('UdonVMFactory', 'VRC.Udon.VM', ['ConstructUdonVM'], 1),
    ],
    'network': [
        ('FlatBufferSerializerCodec', 'VRC.Core.Networking', [
            'Encode8', 'Decode8', 'Encode32', 'Decode32',
            'DecodePlayer8', 'EncodePlayer8',
        ], 3),
        ('QuantizedSerialization', 'VRC.Core.Networking', [
            'Serialize', 'Deserialize',
        ], 3),
        ('SerializationRecoveryHandler', 'VRC.Networking', None, 2),
        ('PersistenceObjectStateManager', 'VRC.Core.Networking.Codec.StateManagement', [
            'WriteInstance', 'ReadInstance', 'WritePlayer', 'ReadPlayer',
        ], 3),
        ('AbstractObjectStateManager', 'VRC.Core.Networking.Codec.StateManagement', [
            'FlattenPlayerViewId',
        ], 2),
        ('FlatBufferNetworkSerializer', '', ['Decode', 'Awake', 'OnDestroy'], 2),
    ],
    'impostor': [
        ('Impostor', 'VRC.Impostors', None, 2),
        ('ImpostorAvatar', 'VRC.Impostors', ['Awake', 'Start', 'OnEnable', 'OnDisable'], 2),
    ],
}


def load_dump():
    """Load deobfuscated dump and extract GA base."""
    print(f"  Loading {DUMP_PATH.name}...")
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    ga_base_str = dump['summary'].get('ga_base', '0')
    ga_base = int(ga_base_str, 16) if ga_base_str != '0' else 0

    # Fallback: compute from known method pointer
    if ga_base == 0:
        for ns, classes in dump['namespaces'].items():
            for cls in classes:
                if cls['name'] == 'Component' and 'get_transform' in cls.get('method_pointers', {}):
                    # Known RVA for get_transform in recent builds
                    ptr = int(cls['method_pointers']['get_transform'], 16)
                    # Heuristic: base is aligned to 0x10000
                    ga_base = ptr & ~0xFFFF
                    print(f"  Computed GA base from Component.get_transform: 0x{ga_base:X}")
                    break

    return dump, ga_base


def find_target_methods(dump, ga_base, targets):
    """Resolve method RVAs for target classes from the dump."""
    hooks = []

    for class_pattern, ns_filter, method_list, read_args in targets:
        found = False
        for ns, classes in dump['namespaces'].items():
            if ns_filter and ns_filter not in ns:
                continue

            for cls in classes:
                name = cls['name']
                if class_pattern.endswith('*'):
                    if not name.startswith(class_pattern[:-1]):
                        continue
                elif name != class_pattern:
                    continue

                mp = cls.get('method_pointers', {})
                if not mp:
                    continue

                # Which methods to hook
                if method_list is None:
                    target_methods = list(mp.keys())
                else:
                    target_methods = [m for m in method_list if m in mp]

                for method_name in target_methods:
                    ptr_str = mp[method_name]
                    try:
                        ptr_val = int(ptr_str, 16)
                        rva = ptr_val - ga_base
                        if 0 < rva < 0x20000000:
                            hooks.append({
                                'className': name,
                                'methodName': method_name,
                                'rva': rva,
                                'readArgs': read_args,
                                'namespace': ns,
                            })
                    except (ValueError, TypeError):
                        pass

                hooked_count = len([m for m in target_methods if m in mp])
                total_methods = len(cls.get('methods', []))
                if hooked_count > 0:
                    found = True
                    print(f"    {ns + '.' if ns else ''}{name}: {hooked_count}/{total_methods} methods")

        if not found and not class_pattern.endswith('*'):
            print(f"    WARNING: {class_pattern} not found or no method pointers")

    return hooks


def main():
    parser = argparse.ArgumentParser(description='Deep VRChat system analysis via Frida')
    parser.add_argument('--mode', choices=['room', 'udon', 'network', 'impostor', 'all'],
                        default='all', help='Analysis mode (default: all)')
    parser.add_argument('--duration', type=int, default=60,
                        help='Monitoring duration in seconds (0 = until Ctrl+C)')
    parser.add_argument('--quiet', action='store_true',
                        help='Only show periodic summaries, not individual events')
    parser.add_argument('--max-hooks', type=int, default=300,
                        help='Safety limit on max hooks to install')
    parser.add_argument('--pid', type=int, default=0,
                        help='VRChat PID (auto-detect if not specified)')
    args = parser.parse_args()

    print("=" * 60)
    print(f"  VRChat Deep Probe — Mode: {args.mode}")
    print("=" * 60)

    # 1. Load dump
    print("\n[1/4] Loading dump data...")
    dump, ga_base = load_dump()
    print(f"  GA base from dump: 0x{ga_base:X}")

    # 2. Resolve targets
    print("\n[2/4] Resolving method targets...")
    modes = list(PROBE_TARGETS.keys()) if args.mode == 'all' else [args.mode]

    all_hooks = []
    for mode in modes:
        print(f"\n  === {mode.upper()} ===")
        hooks = find_target_methods(dump, ga_base, PROBE_TARGETS[mode])
        all_hooks.extend(hooks)

    # Deduplicate by RVA
    seen_rvas = set()
    unique_hooks = []
    for h in all_hooks:
        if h['rva'] not in seen_rvas:
            seen_rvas.add(h['rva'])
            unique_hooks.append(h)
    all_hooks = unique_hooks

    if len(all_hooks) > args.max_hooks:
        print(f"\n  WARNING: {len(all_hooks)} hooks > limit ({args.max_hooks}), trimming")
        all_hooks = all_hooks[:args.max_hooks]

    print(f"\n  Total unique hooks: {len(all_hooks)}")

    # 3. Attach Frida
    print("\n[3/4] Attaching to VRChat...")
    target_pid = args.pid
    if target_pid == 0:
        # Auto-detect: find VRChat.exe PID with largest memory (main process)
        try:
            import subprocess
            result = subprocess.run(
                ['tasklist', '/FI', 'IMAGENAME eq VRChat.exe', '/NH'],
                capture_output=True, text=True, timeout=5
            )
            pids = []
            for line in result.stdout.strip().split('\n'):
                parts = line.split()
                if len(parts) >= 5 and 'VRChat' in parts[0]:
                    pid = int(parts[1])
                    mem_str = parts[4].replace(',', '').replace('.', '')
                    try:
                        mem = int(mem_str)
                    except ValueError:
                        mem = 0
                    pids.append((pid, mem))
            if pids:
                pids.sort(key=lambda x: -x[1])
                target_pid = pids[0][0]
                print(f"  Auto-detected PID: {target_pid} (from {len(pids)} processes)")
        except Exception as e:
            print(f"  Auto-detect failed: {e}")

    try:
        if target_pid > 0:
            session = frida.attach(target_pid)
        else:
            session = frida.attach("VRChat.exe")
    except (frida.ProcessNotFoundError, frida.InvalidArgumentError) as e:
        print(f"  ERROR: Cannot attach to VRChat: {e}")
        print("  Start with: start \"\" \"VRChat.exe\" --no-vr")
        sys.exit(1)

    js_code = JS_PATH.read_text(encoding='utf-8')
    script = session.create_script(js_code)

    # Event handler
    event_counts = defaultdict(int)
    last_summary = [time.time()]
    total_events = [0]

    def on_message(msg, data):
        if msg['type'] != 'send':
            return
        payload = msg['payload']

        # Error messages
        if payload.get('type') == 'error':
            print(f"  HOOK ERROR: {payload.get('hook')} — {payload.get('error')}")
            return

        hook = payload.get('hook', '?')
        event_counts[hook] += 1
        total_events[0] += 1

        if not args.quiet:
            t = payload.get('t', 0)
            count = payload.get('count', 0)

            # Format args
            arg_parts = []
            if 'args' in payload and payload['args']:
                for k, v in payload['args'].items():
                    if isinstance(v, dict):
                        if v.get('type') == 'string':
                            arg_parts.append(f'{k}="{v["value"]}"')
                        elif v.get('type') == 'object':
                            arg_parts.append(f'{k}=<{v["value"]}>')
                        elif v.get('type') == 'null':
                            pass
                        else:
                            val = str(v.get('value', ''))
                            if len(val) > 20:
                                val = val[:20] + '...'
                            arg_parts.append(f'{k}={val}')
                    elif v is not None:
                        arg_parts.append(f'{k}={v}')
            arg_str = ' | ' + ', '.join(arg_parts) if arg_parts else ''

            print(f"  [{t/1000:7.1f}s] #{count:<5d} {hook}{arg_str}")

        # Periodic summary every 15s
        now = time.time()
        if now - last_summary[0] > 15:
            top3 = sorted(event_counts.items(), key=lambda x: -x[1])[:3]
            top_str = ', '.join(f'{k.split(".")[-1]}:{v}' for k, v in top3)
            print(f"\n  --- {total_events[0]} total events | top: {top_str} ---\n")
            last_summary[0] = now

    script.on('message', on_message)
    script.load()
    api = script.exports_sync

    info = api.get_info()
    live_base = int(info['ga_base'], 16)
    print(f"  Live GA base: {info['ga_base']}, size: {info['ga_size']:,}")

    if live_base != ga_base:
        print(f"  NOTE: Base differs (dump=0x{ga_base:X}, live=0x{live_base:X}) — RVAs still valid")

    # 4. Install hooks
    print(f"\n[4/4] Installing {len(all_hooks)} hooks...")
    installed = api.install_hooks(all_hooks)
    print(f"  Installed: {installed}/{len(all_hooks)}")

    if installed == 0:
        print("  ERROR: No hooks installed! Check if dump matches current GA version.")
        session.detach()
        sys.exit(1)

    # Monitor
    dur_str = f"{args.duration}s" if args.duration > 0 else "Ctrl+C to stop"
    print(f"\n{'=' * 60}")
    print(f"  MONITORING ({dur_str})")
    print(f"{'=' * 60}\n")

    try:
        if args.duration > 0:
            time.sleep(args.duration)
        else:
            while True:
                time.sleep(1)
    except KeyboardInterrupt:
        print("\n\n  Stopped by user")

    # Final report
    stats = api.get_stats()
    timeline = api.get_timeline(200)

    session.detach()

    uptime = max(stats['uptime_ms'] / 1000, 0.1)
    print(f"\n{'=' * 60}")
    print(f"  PROBE RESULTS — {uptime:.1f}s")
    print(f"{'=' * 60}")
    print(f"  Total events logged: {stats['total_events']}")

    sorted_counts = sorted(stats['call_counts'].items(), key=lambda x: -x[1])
    active = [(n, c) for n, c in sorted_counts if c > 0]
    silent = [(n, c) for n, c in sorted_counts if c == 0]

    if active:
        print(f"\n  Active methods ({len(active)}):")
        for name, count in active:
            rate = count / uptime
            bar = '#' * min(int(rate), 50)
            print(f"    {name:55s} {count:7d} ({rate:6.1f}/s) {bar}")

    if silent:
        print(f"\n  Silent methods ({len(silent)}) — never called during monitoring:")
        for name, _ in silent[:20]:
            print(f"    {name}")
        if len(silent) > 20:
            print(f"    ... and {len(silent) - 20} more")

    # Categorize by system
    print(f"\n  Events by system:")
    by_system = defaultdict(int)
    for name, count in active:
        cls = name.split('.')[0]
        if 'Room' in cls or 'Photon' in cls:
            by_system['room'] += count
        elif 'Udon' in cls:
            by_system['udon'] += count
        elif 'Serializ' in cls or 'Network' in cls or 'FlatBuffer' in cls or 'Quantized' in cls:
            by_system['network'] += count
        elif 'Impostor' in cls:
            by_system['impostor'] += count
        else:
            by_system['other'] += count
    for sys_name, count in sorted(by_system.items(), key=lambda x: -x[1]):
        print(f"    {sys_name:15s}: {count:7d}")

    # Save report
    report = {
        'mode': args.mode,
        'duration_s': uptime,
        'total_events': stats['total_events'],
        'hooks_installed': installed,
        'hooks_requested': len(all_hooks),
        'call_counts': dict(stats['call_counts']),
        'timeline_sample': timeline,
        'ga_base_dump': f'0x{ga_base:X}',
        'ga_base_live': info['ga_base'],
        'generated': time.strftime('%Y-%m-%d %H:%M:%S'),
    }

    ts = time.strftime('%H%M%S')
    report_path = OUTPUT_DIR / f'deep_probe_{args.mode}_{ts}.json'
    with open(report_path, 'w', encoding='utf-8') as f:
        json.dump(report, f, indent=2, ensure_ascii=False)
    print(f"\n  Report: {report_path}")
    print(f"{'=' * 60}")


if __name__ == '__main__':
    main()
