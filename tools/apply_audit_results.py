#!/usr/bin/env python3
"""Apply audit results (remove/fix) to cross_version_method_names.json."""
import sys
sys.stdout.reconfigure(encoding='utf-8')

import json
import glob
import os
import shutil
from datetime import datetime

CROSS_VERSION = 'output/cross_version_method_names.json'
AUDIT_DIR = 'output/audit_batches'

def main():
    with open(CROSS_VERSION, encoding='utf-8-sig') as f:
        cv = json.load(f)
    original_count = len(cv)
    print(f'cross_version loaded: {original_count} entries')

    audit_files = sorted(glob.glob(os.path.join(AUDIT_DIR, 'audit_*.json')))
    print(f'Audit files found: {len(audit_files)}')

    total_removed = 0
    total_fixed = 0
    not_found_remove = 0
    not_found_fix = 0

    for af in audit_files:
        with open(af, encoding='utf-8-sig') as f:
            data = json.load(f)

        for key in data.get('remove', []):
            if key in cv:
                del cv[key]
                total_removed += 1
            else:
                not_found_remove += 1

        for key, new_name in data.get('fix', {}).items():
            if key in cv:
                cv[key] = new_name
                total_fixed += 1
            else:
                not_found_fix += 1

    print(f'\nResults:')
    print(f'  Removed: {total_removed} (not found: {not_found_remove})')
    print(f'  Fixed:   {total_fixed} (not found: {not_found_fix})')
    print(f'  Final:   {len(cv)} entries (was {original_count}, delta {len(cv) - original_count})')

    ts = datetime.now().strftime('%Y%m%d_%H%M%S')
    backup = f'{CROSS_VERSION}.pre_audit_backup_{ts}.json'
    shutil.copy2(CROSS_VERSION, backup)
    print(f'  Backup:  {backup}')

    tmp = CROSS_VERSION + '.tmp'
    with open(tmp, 'w', encoding='utf-8') as f:
        json.dump(cv, f, ensure_ascii=False, indent=2)
    try:
        os.replace(tmp, CROSS_VERSION)
    except PermissionError:
        os.remove(CROSS_VERSION)
        os.rename(tmp, CROSS_VERSION)
    print(f'  Written: {CROSS_VERSION}')

if __name__ == '__main__':
    main()
