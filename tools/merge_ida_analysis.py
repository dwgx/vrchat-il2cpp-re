#!/usr/bin/env python3
"""
Merge IDA static analysis results into deobfuscated_dump.json.

Reads: output/ida_component_analysis.json
Updates: output/deobfuscated_dump.json, output/unified_vocabulary.json, output/name_mapping.json
Then: regenerates output/src/ tree

Handles duplicate suggested names by appending the original hash suffix.
Only merges high/medium confidence. Skips already runtime-identified CCs.

Usage:
  python tools/merge_ida_analysis.py
  python tools/merge_ida_analysis.py --dry-run
  python tools/merge_ida_analysis.py --min-confidence high   # only high
"""

import json, sys, re, argparse
from pathlib import Path
from collections import Counter

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
IDA_ANALYSIS = BASE_DIR / 'output' / 'ida_component_analysis.json'
RUNTIME_NAMES = BASE_DIR / 'output' / 'runtime_component_names.json'
DEOBF_DUMP = BASE_DIR / 'output' / 'deobfuscated_dump.json'
VOCAB_PATH = BASE_DIR / 'output' / 'unified_vocabulary.json'
NAME_MAP = BASE_DIR / 'output' / 'name_mapping.json'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')
CC_SUFFIX_RE = re.compile(r'_([0-9A-Fa-f]{4})$')

CONFIDENCE_ORDER = {'high': 0, 'medium': 1, 'low': 2}


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


def deduplicate_names(identifications):
    """Make suggested names unique by appending hash suffix for duplicates."""
    name_counts = Counter(i['suggested_name'] for i in identifications if i.get('suggested_name'))

    result = []
    seen = {}  # name -> count used

    for ident in identifications:
        suggested = ident.get('suggested_name')
        cc_name = ident['name']

        if not suggested or suggested == 'None':
            # No suggestion — keep original CC name
            result.append((cc_name, None))
            continue

        suffix_match = CC_SUFFIX_RE.search(cc_name)
        suffix = suffix_match.group(1) if suffix_match else cc_name[-4:]

        if name_counts[suggested] > 1:
            # Duplicate — append category + suffix
            category = ident.get('category', 'unknown')
            new_name = f"{suggested}_{suffix}"
            result.append((cc_name, new_name))
        else:
            result.append((cc_name, suggested))

    return result


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--dry-run', action='store_true')
    parser.add_argument('--min-confidence', default='medium',
                       choices=['high', 'medium', 'low'],
                       help='Minimum confidence to merge (default: medium)')
    args = parser.parse_args()

    min_conf = CONFIDENCE_ORDER[args.min_confidence]

    print("=" * 60)
    print("  Merge IDA Static Analysis Results")
    print("=" * 60)

    # Load IDA analysis
    ida = load_json(IDA_ANALYSIS)
    all_idents = ida['identifications']
    print(f"\nIDA identifications: {len(all_idents)}")

    # Load runtime identifications to avoid overwriting
    runtime_identified = set()
    if RUNTIME_NAMES.exists():
        rt = load_json(RUNTIME_NAMES)
        for entry in rt.get('identifications', []):
            if entry.get('confidence') == 'high':
                runtime_identified.add(entry.get('deobf_name', ''))
        print(f"Runtime-identified (skip): {len(runtime_identified)}")

    # Filter by confidence and skip runtime-identified
    filtered = []
    skipped_conf = 0
    skipped_runtime = 0
    for ident in all_idents:
        conf = ident.get('confidence', 'none')
        if conf not in CONFIDENCE_ORDER or CONFIDENCE_ORDER[conf] > min_conf:
            skipped_conf += 1
            continue
        if ident['name'] in runtime_identified:
            skipped_runtime += 1
            continue
        filtered.append(ident)

    print(f"After filtering: {len(filtered)} (skipped {skipped_conf} low-conf, {skipped_runtime} runtime-identified)")

    # Deduplicate names
    renames = deduplicate_names(filtered)
    actual_renames = [(old, new) for old, new in renames if new is not None]
    print(f"\nRenames to apply: {len(actual_renames)}")

    # Build lookup: CC name -> new name
    cc_to_new = {old: new for old, new in actual_renames}

    # Show planned renames
    for old, new in sorted(actual_renames, key=lambda x: x[0]):
        conf = next((i['confidence'] for i in filtered if i['name'] == old), '?')
        cat = next((i['category'] for i in filtered if i['name'] == old), '?')
        print(f"  {old:45s} -> {new:35s} [{conf}/{cat}]")

    # Load and update deobfuscated dump
    print(f"\nUpdating {DEOBF_DUMP.name}...")
    dump = load_json(DEOBF_DUMP)

    renamed = 0
    for ns, types in dump['namespaces'].items():
        for t in types:
            old_name = t.get('name', '')
            if old_name in cc_to_new:
                new_name = cc_to_new[old_name]
                t['name'] = new_name
                t['ida_source'] = old_name
                renamed += 1
            # Also update parent references
            parent = t.get('parent', '')
            if parent in cc_to_new:
                t['parent'] = cc_to_new[parent]

    print(f"  Renamed {renamed} classes in dump")

    # Update name_mapping.json
    print(f"\nUpdating {NAME_MAP.name}...")
    name_map = load_json(NAME_MAP) if NAME_MAP.exists() else {}
    classes_map = name_map.get('classes', {})
    reverse_map = name_map.get('reverse_classes', {})

    map_additions = 0
    for old_cc, new_name in actual_renames:
        # Find original obfuscated name from reverse_classes
        orig_obf = reverse_map.get(old_cc, '')
        if orig_obf:
            classes_map[orig_obf] = new_name
            reverse_map[new_name] = orig_obf
            # Remove old CC entry
            if old_cc in reverse_map:
                del reverse_map[old_cc]
            map_additions += 1

    name_map['classes'] = classes_map
    name_map['reverse_classes'] = reverse_map
    print(f"  Updated {map_additions} entries")

    # Update vocabulary
    print(f"\nUpdating {VOCAB_PATH.name}...")
    vocab = load_json(VOCAB_PATH)
    existing_names = set(vocab.get('unified_names', []))
    new_names = []
    for _, new_name in actual_renames:
        if new_name not in existing_names:
            new_names.append(new_name)
            existing_names.add(new_name)
    vocab['unified_names'] = sorted(existing_names)
    vocab['total_unified_names'] = len(existing_names)
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
            lines = result.stdout.strip().split('\n')
            for line in lines[-5:]:
                print(f"  {line}")
        else:
            print(f"  WARNING: source tree generation failed:")
            print(result.stderr[-500:] if result.stderr else "no stderr")

    print(f"\n{'=' * 60}")
    print(f"  Done! {renamed} classes renamed, {len(new_names)} vocab added")
    print(f"{'=' * 60}")


if __name__ == '__main__':
    main()
