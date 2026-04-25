#!/usr/bin/env python3
"""
Extract field TYPE information from running VRChat using Frida.
Uses the corrected struct offsets discovered through runtime probing:
  - Real FieldInfo at Il2CppClass+0xA0 (not +0x88 which is PropertyInfo)
  - Real field_count at Il2CppClass+0x124 (not +0x122 which is property_count)
  - FieldInfo stride = 0x20: token+offset(+0x00) | Il2CppType*(+0x08) | name(+0x10) | parent(+0x18)
  - String table base = 0x66dde040

Usage: python tools/extract_field_types_v2.py
(VRChat must be running — launch VRChat.exe directly, not via Steam)
"""

import json, sys, frida, time
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE_DIR / 'data' / 'precise_dump.json'
OUTPUT_PATH = BASE_DIR / 'output' / 'field_types.json'
SCRIPT_PATH = Path(__file__).resolve().parent / 'extract_field_types_v2.js'

BATCH_SIZE = 500


def main():
    print('=' * 60)
    print('  VRChat Field Type Extractor v2')
    print('=' * 60)

    # Load class VAs
    print('Loading precise_dump.json...')
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    class_vas = []
    for ns, classes in dump['namespaces'].items():
        for cls in classes:
            va = cls.get('va', '')
            if va and va.startswith('0x'):
                class_vas.append(va)

    print(f'  Classes with VAs: {len(class_vas)}')

    # Connect to VRChat
    print('Connecting to VRChat.exe...')
    try:
        session = frida.attach('VRChat.exe')
    except frida.ProcessNotFoundError:
        print('ERROR: VRChat.exe not running!')
        print('  Launch VRChat.exe directly (not via Steam)')
        sys.exit(1)

    print('Loading extraction script...')
    with open(SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script_code = f.read()
    script = session.create_script(script_code)
    script.load()

    # Extract in batches
    all_results = []
    total = len(class_vas)
    errors = 0
    fields_total = 0
    t0 = time.time()

    print(f'Extracting field types for {total} classes...')
    for i in range(0, total, BATCH_SIZE):
        batch = class_vas[i:i + BATCH_SIZE]
        try:
            results = script.exports_sync.extract_batch(batch)
            all_results.extend(results)
            for r in results:
                fields_total += len(r.get('fields', []))
        except Exception as e:
            errors += 1
            print(f'  Batch error at {i}: {e}')
            if errors > 20:
                print('Too many errors, stopping.')
                break

        done = min(i + BATCH_SIZE, total)
        elapsed = time.time() - t0
        rate = done / elapsed if elapsed > 0 else 0
        if done % 2000 < BATCH_SIZE or done == total:
            print(f'  {done:>6}/{total} classes | {fields_total:>6} fields | '
                  f'{rate:.0f} cls/s | {errors} errors')

    elapsed = time.time() - t0
    print(f'\nDone in {elapsed:.1f}s: {len(all_results)} classes, {fields_total} fields')

    # Build output
    output = {
        'summary': {
            'total_classes': len(all_results),
            'classes_with_fields': sum(1 for r in all_results if r.get('fields')),
            'total_fields': fields_total,
            'errors': errors,
            'extraction_time': f'{elapsed:.1f}s',
            'struct_offsets': {
                'fields_ptr': 'Il2CppClass+0xA0',
                'field_count': 'Il2CppClass+0x124',
                'field_stride': '0x20',
                'field_type_ptr': 'FieldInfo+0x08',
                'field_name_ptr': 'FieldInfo+0x10',
                'string_table_base': '0x66dde040'
            }
        },
        'classes': {}
    }

    for r in all_results:
        if r.get('error'):
            continue
        key = f"{r['ns']}.{r['name']}" if r['ns'] else r['name']
        output['classes'][key] = {
            'va': r['va'],
            'namespace': r.get('ns', ''),
            'name': r['name'],
            'fields': [
                {
                    'name': f['n'],
                    'type': f['t'],
                    'offset': f['o']
                }
                for f in r.get('fields', [])
            ]
        }

    # Save
    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, indent=1, ensure_ascii=False)

    fsize = OUTPUT_PATH.stat().st_size / 1024 / 1024
    print(f'Saved to: {OUTPUT_PATH} ({fsize:.1f} MB)')

    # Print some stats
    type_counts = {}
    for cls_data in output['classes'].values():
        for field in cls_data['fields']:
            t = field['type']
            type_counts[t] = type_counts.get(t, 0) + 1

    print(f'\nTop 15 field types:')
    for t, c in sorted(type_counts.items(), key=lambda x: -x[1])[:15]:
        print(f'  {c:>5}x {t}')

    session.detach()


if __name__ == '__main__':
    main()
