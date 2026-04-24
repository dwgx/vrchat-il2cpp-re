#!/usr/bin/env python3
"""
Merge runtime-identified component names into deobfuscated_dump.json
and unified_vocabulary.json.

Reads: output/runtime_component_names.json
Updates: output/deobfuscated_dump.json, output/unified_vocabulary.json, output/name_mapping.json
Then: regenerates output/src/ tree

Usage:
  python tools/merge_runtime_names.py
  python tools/merge_runtime_names.py --dry-run
"""

import json, sys, re, argparse
from pathlib import Path
from datetime import datetime

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
RUNTIME_NAMES = BASE_DIR / 'output' / 'runtime_component_names.json'
DEOBF_DUMP = BASE_DIR / 'output' / 'deobfuscated_dump.json'
VOCAB_PATH = BASE_DIR / 'output' / 'unified_vocabulary.json'
NAME_MAP = BASE_DIR / 'output' / 'name_mapping.json'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')


def load_json(path):
    with open(path, 'r', encoding='utf-8') as f:
        return json.load(f)


def save_json(path, data, dry_run=False):
    if dry_run:
        print(f"  [DRY-RUN] Would write {path.name}")
        return
    with open(path, 'w', encoding='utf-8') as f:
        json.dump(data, f, ensure_ascii=False, indent=2)
    print(f"  Wrote {path.name}")


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--dry-run', action='store_true')
    args = parser.parse_args()

    print("=" * 60)
    print("  Merge Runtime-Identified Component Names")
    print("=" * 60)

    # Load runtime identifications
    rt = load_json(RUNTIME_NAMES)
    idents = rt['identifications']

    # Build VA -> suggested_name mapping (high confidence only for rename)
    va_to_name = {}
    deobf_to_name = {}
    for entry in idents:
        if entry.get('confidence') == 'high':
            va = entry['va'].upper()
            if not va.startswith('0X'):
                va = '0x' + va
            va_to_name[va.upper()] = entry['suggested_name']
            deobf_to_name[entry['deobf_name']] = entry['suggested_name']

    print(f"\nHigh-confidence renames: {len(va_to_name)}")
    for old, new in sorted(deobf_to_name.items()):
        print(f"  {old} -> {new}")

    # Load and update deobfuscated dump
    print(f"\nUpdating {DEOBF_DUMP.name}...")
    dump = load_json(DEOBF_DUMP)

    renamed = 0
    for ns, types in dump['namespaces'].items():
        for t in types:
            old_name = t.get('name', '')
            va = t.get('va', '')
            if not va:
                continue
            va_upper = va.upper()
            if not va_upper.startswith('0X'):
                va_upper = '0X' + va_upper

            if va_upper in {k.upper(): k for k in va_to_name}:
                # Find the matching key case-insensitively
                for k, v in va_to_name.items():
                    if k.upper() == va_upper:
                        new_name = v
                        break
                if old_name != new_name:
                    t['name'] = new_name
                    if 'runtime_source' not in t:
                        t['runtime_source'] = f"GameObject:{new_name}"
                    renamed += 1

    print(f"  Renamed {renamed} classes in dump")

    # Update name_mapping.json
    print(f"\nUpdating {NAME_MAP.name}...")
    name_map = load_json(NAME_MAP) if NAME_MAP.exists() else {}
    map_additions = 0
    for entry in idents:
        if entry.get('confidence') == 'high':
            # Find the original obfuscated name from the dump
            va = entry['va']
            for ns, types in dump['namespaces'].items():
                for t in types:
                    if t.get('va', '').upper() == va.upper():
                        orig = t.get('original_name', '')
                        if orig and OBF_RE.match(orig):
                            name_map[orig] = entry['suggested_name']
                            map_additions += 1
    print(f"  Added {map_additions} entries to name mapping")

    # Update vocabulary
    print(f"\nUpdating {VOCAB_PATH.name}...")
    vocab = load_json(VOCAB_PATH)
    existing_names = set(vocab.get('unified_names', []))
    new_names = []
    for name in va_to_name.values():
        if name not in existing_names:
            new_names.append(name)
            existing_names.add(name)
    vocab['unified_names'] = sorted(existing_names)
    vocab['total_unified_names'] = len(existing_names)

    if 'runtime_identified_components' not in vocab.get('sources_loaded', []):
        vocab.setdefault('sources_loaded', []).append('runtime_identified_components')

    print(f"  Added {len(new_names)} new vocabulary entries")

    # Save all
    print(f"\nSaving...")
    save_json(DEOBF_DUMP, dump, args.dry_run)
    save_json(NAME_MAP, name_map, args.dry_run)
    save_json(VOCAB_PATH, vocab, args.dry_run)

    # Regenerate source tree
    if not args.dry_run:
        print(f"\nRegenerating source tree...")
        import subprocess
        result = subprocess.run(
            [sys.executable, str(BASE_DIR / 'tools' / 'generate_source_tree.py')],
            capture_output=True, text=True, encoding='utf-8'
        )
        if result.returncode == 0:
            # Extract last few lines of output
            lines = result.stdout.strip().split('\n')
            for line in lines[-5:]:
                print(f"  {line}")
        else:
            print(f"  WARNING: source tree generation failed:")
            print(result.stderr[-500:] if result.stderr else "no stderr")

    print(f"\n{'=' * 60}")
    print(f"  Done! {renamed} classes renamed, {len(new_names)} vocab entries added")
    print(f"{'=' * 60}")


if __name__ == '__main__':
    main()
