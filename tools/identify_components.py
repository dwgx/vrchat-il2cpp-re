#!/usr/bin/env python3
"""
Identify ComplexComponent MonoBehaviours by probing runtime instances.
Uses Frida to attach to VRChat and read Il2CppClass structures.

Strategy:
  1. Load deobfuscated_dump.json to get ComplexComponent class VAs
  2. Attach to VRChat via Frida
  3. For each class: probe static fields for instances, read GameObject names
  4. Output: mapping of ComplexComponent -> likely real name based on GameObject

Usage:
  python tools/identify_components.py
  (VRChat.exe --no-vr must be running)
"""

import json, sys, os, time, frida
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
DEOBF_DUMP = BASE_DIR / 'output' / 'deobfuscated_dump.json'
SCRIPT_PATH = BASE_DIR / 'tools' / 'identify_components.js'
OUTPUT_PATH = BASE_DIR / 'output' / 'component_identifications.json'

def main():
    print("=" * 60)
    print("  ComplexComponent Runtime Identifier")
    print("=" * 60)

    # Load class VAs
    print("Loading deobfuscated dump...")
    with open(DEOBF_DUMP, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    complex_classes = []
    for ns, types in dump['namespaces'].items():
        for t in types:
            name = t.get('name', '')
            if 'ComplexComponent' in name:
                va = t.get('va', '')
                if va:
                    complex_classes.append({
                        'deobf_name': name,
                        'va': va,
                        'ns': ns,
                        'method_count': len(t.get('methods', [])),
                        'field_count': len(t.get('fields', [])),
                    })

    print(f"  Found {len(complex_classes)} ComplexComponent classes")

    # Connect to VRChat
    print("Connecting to VRChat.exe...")
    try:
        session = frida.attach("VRChat.exe")
    except frida.ProcessNotFoundError:
        print("ERROR: VRChat.exe not running!")
        sys.exit(1)

    print("Loading identification script...")
    with open(SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script_code = f.read()
    script = session.create_script(script_code)
    script.load()

    # Probe classes in batches
    print("\nProbing classes for runtime instances...")
    batch_size = 50
    all_results = []

    for i in range(0, len(complex_classes), batch_size):
        batch = complex_classes[i:i+batch_size]
        vas = [c['va'] for c in batch]

        try:
            results = script.exports_sync.probe_classes(vas)
            for j, r in enumerate(results):
                r['deobf_name'] = batch[j]['deobf_name']
                r['method_count'] = batch[j]['method_count']
                r['field_count'] = batch[j]['field_count']
                all_results.append(r)

                if r.get('instances', 0) > 0:
                    print(f"  {batch[j]['deobf_name']}: {r['instances']} instances found!")
        except Exception as e:
            print(f"  Batch {i//batch_size} error: {e}")

        if (i + batch_size) % 100 == 0:
            print(f"  Progress: {min(i+batch_size, len(complex_classes))}/{len(complex_classes)}")

    # Also try vtable analysis for classes without instances
    print("\nAnalyzing vtables for method signatures...")
    for r in all_results:
        if r.get('instances', 0) == 0 and not r.get('error'):
            try:
                vtable_info = script.exports_sync.analyze_vtable(r['va'])
                r['vtable_methods'] = vtable_info.get('methods', [])
            except:
                pass

    # Save results
    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(all_results, f, indent=2, ensure_ascii=False)
    print(f"\nResults saved to {OUTPUT_PATH}")

    # Summary
    with_instances = sum(1 for r in all_results if r.get('instances', 0) > 0)
    with_vtable = sum(1 for r in all_results if r.get('vtable_methods'))
    errors = sum(1 for r in all_results if r.get('error'))
    print(f"\n--- Summary ---")
    print(f"  Total classes: {len(all_results)}")
    print(f"  With instances: {with_instances}")
    print(f"  With vtable info: {with_vtable}")
    print(f"  Errors: {errors}")

    session.detach()

if __name__ == '__main__':
    main()
