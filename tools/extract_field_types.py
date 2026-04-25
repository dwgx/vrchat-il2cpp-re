#!/usr/bin/env python3
"""
Extract field TYPE information from running VRChat using Frida.
Connects to the offline VRChat process and reads Il2CppClass field type data.

Usage: python extract_field_types.py
(VRChat must be running in offline mode)
"""

import json, sys, frida, time
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).parent
DUMP_PATH = BASE_DIR / 'il2cpp_full_dump' / 'precise_dump.json'
OUTPUT_PATH = BASE_DIR / 'il2cpp_full_dump' / 'field_types.json'
SCRIPT_PATH = BASE_DIR / 'extract_field_types.js'

BATCH_SIZE = 200


def main():
    print('Loading precise_dump.json...')
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Collect all class VAs
    class_vas = []
    for ns, classes in dump['namespaces'].items():
        for cls in classes:
            va = cls.get('va', '')
            if va and va.startswith('0x'):
                class_vas.append(va)

    print(f'Classes with VAs: {len(class_vas)}')

    # Connect to VRChat
    print('Connecting to VRChat...')
    try:
        session = frida.attach('VRChat.exe')
    except frida.ProcessNotFoundError:
        print('ERROR: VRChat.exe not running. Start it in offline mode first:')
        print('  Just run VRChat.exe directly (not through Steam)')
        sys.exit(1)

    print('Loading Frida script...')
    with open(SCRIPT_PATH, 'r') as f:
        script_code = f.read()
    script = session.create_script(script_code)
    script.load()

    # Extract field types in batches
    all_results = []
    total = len(class_vas)
    errors = 0

    print(f'Extracting field types for {total} classes...')
    for i in range(0, total, BATCH_SIZE):
        batch = class_vas[i:i+BATCH_SIZE]
        try:
            results = script.exports_sync.extract_field_types(batch)
            all_results.extend(results)
        except Exception as e:
            errors += 1
            if errors > 10:
                print(f'Too many errors, stopping. Last: {e}')
                break

        if (i // BATCH_SIZE) % 10 == 0:
            print(f'  {i}/{total} processed, {len(all_results)} with data, {errors} errors')

    print(f'\nDone: {len(all_results)} classes with field type data')

    # Save
    output = {
        'total_classes': len(all_results),
        'classes': {}
    }
    for r in all_results:
        output['classes'][r['class_name']] = {
            'va': r['va'],
            'fields': r['fields']
        }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, indent=2, ensure_ascii=False)

    print(f'Saved to {OUTPUT_PATH}')

    session.detach()


if __name__ == '__main__':
    main()
