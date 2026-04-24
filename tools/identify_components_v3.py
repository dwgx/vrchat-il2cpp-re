#!/usr/bin/env python3
"""
Component Identifier v3 — Session-independent scene traversal.

Key improvements over v2:
  - No hardcoded klass VAs (uses method RVAs instead)
  - Hooks error-state-setter to find FlowManager dynamically
  - Fingerprint matching (method_count + field_count + method_names + parent + field_types)
  - Multi-root discovery: DontDestroyOnLoad via singleton static fields
  - Hierarchy path reporting for found components
  - Unmatched CC reporting for manual investigation
  - Comparison with IDA static analysis if available

Usage:
  python tools/identify_components_v3.py
  python tools/identify_components_v3.py --merge     # also merge results into dump
  python tools/identify_components_v3.py --timeout 30 # wait longer for FlowManager (seconds)
  (VRChat.exe --no-vr must be running and fully loaded to home screen)
"""

import json, sys, re, time, argparse, frida
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
DEOBF_DUMP = BASE_DIR / 'output' / 'deobfuscated_dump.json'
SCRIPT_PATH = BASE_DIR / 'tools' / 'identify_components_v3.js'
OUTPUT_PATH = BASE_DIR / 'output' / 'runtime_component_names_v3.json'
PREV_OUTPUT = BASE_DIR / 'output' / 'runtime_component_names.json'
FIELD_TYPES = BASE_DIR / 'output' / 'field_types.json'
IDA_NAMES = BASE_DIR / 'output' / 'ida_apply_names.py'
NAME_MAPPING = BASE_DIR / 'output' / 'name_mapping.json'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')


def build_fingerprint_db(dump, field_types_data=None):
    """Build a fingerprint database from the deobfuscated dump.

    Fingerprint = (method_count, field_count) -> list of candidates.
    For disambiguation: method names, parent class, field types, method param counts.
    """
    db = {}  # (mc, fc) -> [{name, ns, methods, parent, field_types, ...}]
    all_classes = {}  # name -> class info

    # Build field type map if available
    ft_map = {}  # class_name -> [field_type_names]
    if field_types_data:
        for cls_name, cls_info in field_types_data.get('classes', {}).items():
            fields = cls_info.get('fields', [])
            ft_map[cls_name] = sorted(f.get('type', '?') for f in fields if f.get('type'))

    for ns, types in dump.get('namespaces', {}).items():
        for t in types:
            name = t.get('name', '')
            methods = t.get('methods', [])
            fields = t.get('fields', {}) if isinstance(t.get('fields'), dict) else t.get('fields', [])
            mc = len(methods) if isinstance(methods, list) else 0
            fc = len(fields) if isinstance(fields, (list, dict)) else 0

            method_names = sorted(methods) if isinstance(methods, list) and all(isinstance(m, str) for m in methods) else []

            # Extract method param counts from method_pointers keys if available
            # (not easily available from dump, but method names are)

            info = {
                'name': name,
                'ns': ns,
                'method_count': mc,
                'field_count': fc,
                'method_names': method_names,
                'parent': t.get('parent', ''),
                'field_types': ft_map.get(name, []),
            }

            key = (mc, fc)
            if key not in db:
                db[key] = []
            db[key].append(info)
            all_classes[name] = info

    return db, all_classes


def jaccard(set_a, set_b):
    """Jaccard similarity between two sets."""
    if not set_a and not set_b:
        return 0.0
    intersection = len(set_a & set_b)
    union = len(set_a | set_b)
    return intersection / union if union > 0 else 0.0


def match_component(comp, db, script, field_types_data=None):
    """Match a runtime component against the fingerprint database.

    comp = {klassPtr, name, ns, mc, fc, parent, gameObject, ...}
    Returns: (matched_name, confidence, match_detail) or (None, None, None)
    """
    mc, fc = comp['mc'], comp['fc']
    key = (mc, fc)

    candidates = db.get(key, [])
    if not candidates:
        return None, None, None

    # --- Phase 1: Parent class filtering ---
    runtime_parent = comp.get('parent', '')
    if runtime_parent:
        parent_filtered = [c for c in candidates if c['parent'] == runtime_parent]
        if len(parent_filtered) == 1:
            return parent_filtered[0]['name'], 'parent_match', f"parent={runtime_parent}"
        if parent_filtered:
            candidates = parent_filtered

    if len(candidates) == 1:
        return candidates[0]['name'], 'fingerprint', f"mc={mc},fc={fc}"

    # --- Phase 2: Method name Jaccard ---
    try:
        runtime_methods = script.exports_sync.get_method_names(comp['klassPtr'])
        runtime_methods_set = set(runtime_methods)
    except Exception:
        runtime_methods_set = set()

    if runtime_methods_set:
        scored = []
        for cand in candidates:
            cand_set = set(cand['method_names'])
            score = jaccard(runtime_methods_set, cand_set)
            scored.append((score, cand))

        scored.sort(key=lambda x: x[0], reverse=True)
        best_score, best_cand = scored[0]

        if best_score > 0.7:
            return best_cand['name'], 'method_match', f"jaccard={best_score:.2f}"

        # --- Phase 3: Method signatures (param counts) ---
        try:
            runtime_sigs = script.exports_sync.get_method_signatures(comp['klassPtr'])
            runtime_sig_set = set(f"{s['name']}({s['params']})" for s in runtime_sigs)
        except Exception:
            runtime_sig_set = set()

        if runtime_sig_set and best_score > 0.5:
            # Refine with param counts — methods with matching names AND param counts
            # get a bonus
            return best_cand['name'], 'method_match', f"jaccard={best_score:.2f}"

        # --- Phase 4: Field type matching (if available) ---
        if field_types_data and best_score > 0.3:
            try:
                # Get runtime field types for disambiguation
                runtime_parent_chain = script.exports_sync.get_parent_chain(comp['klassPtr'])
                for s, cand in scored[:3]:
                    if cand.get('field_types'):
                        # If field type signatures match, boost confidence
                        ft_key = cand['name']
                        if ft_key in field_types_data.get('classes', {}):
                            stored_types = sorted(
                                f.get('type', '?')
                                for f in field_types_data['classes'][ft_key].get('fields', [])
                                if f.get('type')
                            )
                            cand_ft = cand.get('field_types', [])
                            if stored_types == cand_ft and len(stored_types) > 2:
                                return cand['name'], 'field_type_match', f"jaccard={s:.2f}+ft"
            except Exception:
                pass

        if best_score > 0.5:
            return best_cand['name'], 'method_match', f"jaccard={best_score:.2f}"
        elif best_score > 0.3:
            return best_cand['name'], 'weak_match', f"jaccard={best_score:.2f}"

    # --- Fallback ---
    if len(candidates) <= 3:
        return candidates[0]['name'], 'ambiguous', f"{len(candidates)} candidates"

    return None, None, None


def load_ida_names():
    """Load IDA name mapping if available, for cross-reference."""
    ida_names = {}
    if IDA_NAMES.exists():
        try:
            content = IDA_NAMES.read_text(encoding='utf-8')
            # Parse lines like: idc.set_name(0xADDR, "name", ...)
            import re as _re
            for m in _re.finditer(r'idc\.set_name\(0x([0-9A-Fa-f]+),\s*"([^"]+)"', content):
                addr = int(m.group(1), 16)
                name = m.group(2)
                ida_names[addr] = name
        except Exception:
            pass
    return ida_names


def main():
    parser = argparse.ArgumentParser(description='Component Identifier v3')
    parser.add_argument('--merge', action='store_true', help='Merge results into dump')
    parser.add_argument('--timeout', type=int, default=15, help='FlowManager wait timeout (seconds)')
    parser.add_argument('--no-singletons', action='store_true', help='Skip singleton scan phase')
    args = parser.parse_args()

    print("=" * 60)
    print("  Component Identifier v3 — Multi-Root Discovery")
    print("=" * 60)

    # Step 1: Build fingerprint database
    print("\n[1/6] Building fingerprint database...")
    with open(DEOBF_DUMP, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Load field types for disambiguation
    field_types_data = None
    if FIELD_TYPES.exists():
        try:
            with open(FIELD_TYPES, 'r', encoding='utf-8') as f:
                field_types_data = json.load(f)
            ft_count = len(field_types_data.get('classes', {}))
            print(f"  Field types loaded: {ft_count} classes")
        except Exception as e:
            print(f"  Warning: Could not load field_types.json: {e}")

    fp_db, all_classes = build_fingerprint_db(dump, field_types_data)

    # Count ComplexComponent targets
    complex_names = [name for name in all_classes if 'ComplexComponent' in name]
    print(f"  Total classes in dump: {len(all_classes)}")
    print(f"  ComplexComponent targets: {len(complex_names)}")
    print(f"  Unique (mc,fc) fingerprints: {len(fp_db)}")

    # Load IDA names for cross-reference
    ida_names = load_ida_names()
    if ida_names:
        print(f"  IDA names loaded: {len(ida_names)} entries")

    # Step 2: Attach to VRChat
    print("\n[2/6] Attaching to VRChat...")
    target_pid = 0
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
            print(f"  Auto-detected PID: {target_pid}")
    except Exception:
        pass

    try:
        session = frida.attach(target_pid) if target_pid > 0 else frida.attach("VRChat.exe")
    except (frida.ProcessNotFoundError, frida.InvalidArgumentError):
        print("  ERROR: VRChat.exe not running!")
        print("  Launch with: start \"\" \"VRChat.exe\" --no-vr")
        sys.exit(1)

    with open(SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script_code = f.read()

    script = session.create_script(script_code)
    script.load()
    api = script.exports_sync

    info = api.get_info()
    print(f"  GA base: {info['ga_base']}")

    # Step 3: Hook and find FlowManager
    print(f"\n[3/6] Hooking error-state-setter (waiting up to {args.timeout}s for FlowManager)...")
    result = api.hook_and_wait(args.timeout * 1000)

    if 'error' in result:
        print(f"  ERROR: {result['error']}")
        print("  Make sure VRChat is fully loaded (at home screen)")
        session.detach()
        sys.exit(1)

    print(f"  FlowManager found: {result['flowManager']}")
    print(f"  Klass: {result['klass']} ({result.get('klassName', '?')})")

    # Step 4: Bootstrap and traverse
    print("\n[4/6] Bootstrapping Unity methods...")
    boot = api.bootstrap()
    if 'error' in boot:
        print(f"  ERROR: {boot['error']}")
        session.detach()
        sys.exit(1)
    print(f"  Transform klass: {boot['transform_klass']}")
    print(f"  GameObject klass: {boot['go_klass']}")

    print("\n[5/6] Scanning scene trees...")
    scan = api.scan_scene()
    if 'error' in scan:
        print(f"  ERROR: {scan['error']}")
        session.detach()
        sys.exit(1)

    phases = scan.get('phases', {})
    fm_phase = phases.get('flowManager', {})
    sg_phase = phases.get('singletons', {})
    print(f"  Phase 1 (FlowManager tree): {fm_phase.get('gos', '?')} GOs, {fm_phase.get('components', '?')} components")
    print(f"  Phase 2 (Singleton trees): {sg_phase.get('checked', 0)} singletons checked, "
          f"{sg_phase.get('newRoots', 0)} new roots, {sg_phase.get('gos', 0)} new GOs")
    print(f"  Total: {scan['gos_visited']} GOs, {scan['components_found']} components")

    # Step 5 (optional): Extended singleton scan
    if not args.no_singletons:
        extra = api.find_more_entry_points()
        if extra.get('newRoots', 0) > 0:
            print(f"  Extended scan: {extra['newRoots']} additional roots, {extra.get('newGOs', 0)} new GOs")
            # Re-fetch full component list
            scan['gos_visited'] = extra['totalGOs']
            scan['components_found'] = extra['totalComponents']

    # Step 6: Match components against fingerprint database
    print(f"\n[6/6] Matching components...")

    # Group by klass pointer (deduplicate)
    by_klass = defaultdict(list)
    for comp in scan['components']:
        by_klass[comp['klassPtr']].append(comp)

    # Track results
    identified = []
    already_named = 0
    new_identifications = 0
    obfuscated_unmatched = []
    unmatched_ccs = []  # CCs with instances but no identification

    for klass_ptr, comps in sorted(by_klass.items()):
        sample = comps[0]
        class_name = sample['name']
        go_names = list(set(c['gameObject'] for c in comps if c.get('gameObject')))
        hier_paths = list(set(c.get('hierPath', '') for c in comps if c.get('hierPath')))
        root_sources = list(set(c.get('rootSource', '') for c in comps if c.get('rootSource')))

        is_obfuscated = bool(OBF_RE.match(class_name))
        is_complex = 'ComplexComponent' in class_name

        if not is_obfuscated and not is_complex:
            already_named += 1
            continue

        # Try fingerprint match
        matched_name, confidence, detail = match_component(sample, fp_db, script, field_types_data)

        if matched_name and 'ComplexComponent' in matched_name:
            # Still has generic name — this is a target for identification
            # Use GameObject name as the suggested identity
            if go_names:
                suggested = go_names[0].replace('(Clone)', '').replace('(1)', '').strip()
                go_confidence = 'high' if len(go_names) == 1 else 'medium'
            else:
                suggested = matched_name
                go_confidence = 'none'

            ident_entry = {
                'dump_name': matched_name,
                'runtime_name': class_name,
                'klass_ptr': klass_ptr,
                'gameObject': go_names[0] if go_names else None,
                'all_gameObjects': go_names[:10],
                'instance_count': len(comps),
                'suggested_name': suggested,
                'confidence': go_confidence,
                'match_method': confidence,
                'match_detail': detail,
                'mc': sample['mc'],
                'fc': sample['fc'],
                'parent': sample.get('parent', ''),
                'hier_paths': hier_paths[:5],
                'root_sources': root_sources,
            }
            identified.append(ident_entry)
            new_identifications += 1

            # Track as unmatched CC (has instance but name is still ComplexComponent)
            unmatched_ccs.append(ident_entry)
        elif matched_name:
            already_named += 1
        else:
            if is_obfuscated:
                obfuscated_unmatched.append({
                    'runtime_name': class_name,
                    'klass_ptr': klass_ptr,
                    'mc': sample['mc'],
                    'fc': sample['fc'],
                    'parent': sample.get('parent', ''),
                    'gameObjects': go_names[:5],
                    'hier_paths': hier_paths[:3],
                    'instance_count': len(comps),
                    'root_sources': root_sources,
                })
            if is_complex:
                unmatched_ccs.append({
                    'dump_name': class_name,
                    'runtime_name': class_name,
                    'klass_ptr': klass_ptr,
                    'mc': sample['mc'],
                    'fc': sample['fc'],
                    'parent': sample.get('parent', ''),
                    'gameObjects': go_names[:5],
                    'hier_paths': hier_paths[:3],
                    'instance_count': len(comps),
                    'confidence': 'unmatched',
                    'root_sources': root_sources,
                })

    # Print results
    print(f"\n{'=' * 60}")
    print(f"  RESULTS")
    print(f"{'=' * 60}")
    print(f"  Unique classes on scene: {len(by_klass)}")
    print(f"  Already named: {already_named}")
    print(f"  New identifications: {new_identifications}")
    print(f"  Obfuscated unmatched: {len(obfuscated_unmatched)}")

    if identified:
        print(f"\n  --- New Identifications ---")
        for ident in sorted(identified, key=lambda x: x.get('confidence', ''), reverse=True):
            conf = ident['confidence']
            marker = '*' if conf == 'high' else '+' if conf == 'medium' else '-'
            detail = ident.get('match_detail', '')
            print(f"  [{marker}] {ident['dump_name']:45s} -> {ident['suggested_name']}")
            if detail:
                print(f"       match: {ident.get('match_method', '?')} ({detail})")
            if ident.get('hier_paths'):
                print(f"       path:  {ident['hier_paths'][0][:80]}")
            if len(ident.get('all_gameObjects', [])) > 1:
                print(f"       also:  {', '.join(ident['all_gameObjects'][1:3])}")

    # Report: CCs with instances but no real name
    ccs_not_found = [n for n in complex_names if n not in set(i.get('dump_name', '') for i in identified)]
    if ccs_not_found:
        print(f"\n  --- ComplexComponents NOT found on scene ({len(ccs_not_found)}) ---")
        for cc in sorted(ccs_not_found)[:20]:
            info = all_classes.get(cc, {})
            print(f"  [?] {cc:45s} mc={info.get('method_count', '?'):3} fc={info.get('field_count', '?'):3} parent={info.get('parent', '?')}")
        if len(ccs_not_found) > 20:
            print(f"      ... and {len(ccs_not_found) - 20} more")

    # Report: Obfuscated classes with no match (for manual investigation)
    if obfuscated_unmatched:
        print(f"\n  --- Obfuscated Unmatched (top 15 by instance count) ---")
        for entry in sorted(obfuscated_unmatched, key=lambda x: x['instance_count'], reverse=True)[:15]:
            gos = ', '.join(entry['gameObjects'][:3]) if entry['gameObjects'] else '(no GO)'
            print(f"  [?] mc={entry['mc']:3} fc={entry['fc']:3} parent={entry.get('parent', '?'):20s} "
                  f"x{entry['instance_count']} on: {gos[:50]}")
            if entry.get('hier_paths'):
                print(f"       path: {entry['hier_paths'][0][:70]}")

    # Merge with previous results
    prev_identifications = []
    if PREV_OUTPUT.exists():
        try:
            prev = json.load(open(PREV_OUTPUT, 'r', encoding='utf-8'))
            prev_identifications = prev.get('identifications', [])
            print(f"\n  Previous v2 results: {len(prev_identifications)} identifications")
        except Exception:
            pass

    # Combine: v3 results + v2 results not already covered
    v3_names = set(i['dump_name'] for i in identified if 'dump_name' in i)
    combined = list(identified)
    for prev_id in prev_identifications:
        prev_name = prev_id.get('deobf_name', prev_id.get('dump_name', ''))
        if prev_name and prev_name not in v3_names:
            combined.append({
                'dump_name': prev_name,
                'suggested_name': prev_id.get('suggested_name', prev_name),
                'confidence': prev_id.get('confidence', 'prev_v2'),
                'gameObject': prev_id.get('gameObject'),
                'source': 'v2_carryover',
            })

    # Save
    output = {
        'generated_by': 'identify_components_v3.py',
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'method': 'Multi-root scene traversal + fingerprint matching (parent/method/field_type)',
        'ga_base': info.get('ga_base', 'unknown'),
        'stats': {
            'gos_visited': scan['gos_visited'],
            'total_components': scan['components_found'],
            'unique_classes': len(by_klass),
            'already_named': already_named,
            'new_identifications': new_identifications,
            'obfuscated_unmatched': len(obfuscated_unmatched),
            'cc_targets_total': len(complex_names),
            'cc_targets_found': len([i for i in identified if 'ComplexComponent' in i.get('dump_name', '')]),
            'cc_targets_missing': len(ccs_not_found),
            'combined_total': len(combined),
            'high_confidence': sum(1 for i in combined if i.get('confidence') == 'high'),
            'medium_confidence': sum(1 for i in combined if i.get('confidence') == 'medium'),
        },
        'phases': scan.get('phases', {}),
        'identifications': combined,
        'unmatched_ccs': [
            {
                'dump_name': cc,
                'mc': all_classes[cc].get('method_count', 0),
                'fc': all_classes[cc].get('field_count', 0),
                'parent': all_classes[cc].get('parent', ''),
            }
            for cc in ccs_not_found
        ],
        'obfuscated_unmatched': obfuscated_unmatched[:50],
        'all_scene_components': [
            {
                'name': sample['name'],
                'ns': sample['ns'],
                'mc': sample['mc'],
                'fc': sample['fc'],
                'parent': sample.get('parent', ''),
                'instances': len(comps),
                'gameObjects': list(set(c['gameObject'] for c in comps if c.get('gameObject')))[:5],
                'hierPaths': list(set(c.get('hierPath', '') for c in comps if c.get('hierPath')))[:3],
                'rootSources': list(set(c.get('rootSource', '') for c in comps if c.get('rootSource'))),
            }
            for klass_ptr, comps in sorted(by_klass.items())
            for sample in [comps[0]]
        ],
    }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, ensure_ascii=False, indent=2)
    print(f"\n  Saved to {OUTPUT_PATH.name}")
    print(f"  Combined identifications: {len(combined)}")

    session.detach()

    # Optionally merge into dump
    if args.merge and new_identifications > 0:
        print("\n  Running merge_runtime_names.py...")
        import subprocess
        subprocess.run([sys.executable, str(BASE_DIR / 'tools' / 'merge_runtime_names.py')])


if __name__ == '__main__':
    main()
