#!/usr/bin/env python3
"""
Merge scene traversal identifications into deobfuscated_dump.json.
Only renames classes that are still named ComplexComponent* (doesn't override previous renames).

Usage:
  python tools/merge_scene_results.py
  python tools/merge_scene_results.py --dry-run
"""
import json, sys, re, argparse
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE_DIR = Path(__file__).resolve().parent.parent
SCENE_RESULTS = BASE_DIR / 'output' / 'scene_traversal_results.json'
DEOBF_DUMP = BASE_DIR / 'output' / 'deobfuscated_dump.json'
VOCAB_PATH = BASE_DIR / 'output' / 'unified_vocabulary.json'
NAME_MAP = BASE_DIR / 'output' / 'name_mapping.json'
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--dry-run', action='store_true')
    args = parser.parse_args()

    print("=" * 60)
    print("  Merge Scene Traversal Results")
    print("=" * 60)

    with open(SCENE_RESULTS, 'r', encoding='utf-8') as f:
        scene = json.load(f)

    idents = scene['identifications']

    # Only take high/medium confidence, skip low
    candidates = [i for i in idents if i['confidence'] in ('high', 'medium')]
    print(f"Candidates: {len(candidates)} (high/medium confidence)")

    # Load dump
    with open(DEOBF_DUMP, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Build VA -> type index
    va_to_type = {}
    for ns, types in dump['namespaces'].items():
        for t in types:
            va = t.get('va', '').upper()
            if va:
                va_to_type[va] = t

    # Only rename classes still named ComplexComponent* / fallback names
    renamed = 0
    skipped = 0
    renames = []
    for cand in candidates:
        va = cand['va'].upper()
        typ = va_to_type.get(va)
        if not typ:
            continue

        current = typ.get('name', '')
        suggested = cand['suggested_name']

        # Skip if already has a good name (not ComplexComponent*)
        if 'ComplexComponent' not in current and not OBF_RE.match(current):
            skipped += 1
            continue

        # Apply rename
        old_name = current
        typ['name'] = suggested
        typ['runtime_source'] = f"SceneTraversal:{','.join(cand['gameObjects'][:3])}"
        renamed += 1
        renames.append((old_name, suggested, cand['confidence']))

    print(f"\nRenames: {renamed}, Skipped (already named): {skipped}")
    for old, new, conf in sorted(renames, key=lambda x: x[1]):
        print(f"  [{conf:6s}] {old:45s} -> {new}")

    # Update name_mapping
    with open(NAME_MAP, 'r', encoding='utf-8') as f:
        name_map = json.load(f)

    map_adds = 0
    for cand in candidates:
        va = cand['va'].upper()
        typ = va_to_type.get(va)
        if not typ:
            continue
        orig = typ.get('original_name', '')
        if orig and OBF_RE.match(orig) and cand['suggested_name'] == typ.get('name'):
            if orig not in name_map:
                name_map[orig] = cand['suggested_name']
                map_adds += 1

    print(f"Name mapping additions: {map_adds}")

    # Update vocabulary
    with open(VOCAB_PATH, 'r', encoding='utf-8') as f:
        vocab = json.load(f)
    existing = set(vocab.get('unified_names', []))
    new_vocab = 0
    for cand in candidates:
        name = cand['suggested_name']
        if name not in existing:
            existing.add(name)
            new_vocab += 1
    vocab['unified_names'] = sorted(existing)
    vocab['total_unified_names'] = len(existing)
    print(f"New vocabulary entries: {new_vocab}")

    # Save
    if not args.dry_run:
        with open(DEOBF_DUMP, 'w', encoding='utf-8') as f:
            json.dump(dump, f, ensure_ascii=False, indent=2)
        print(f"  Wrote deobfuscated_dump.json")

        with open(NAME_MAP, 'w', encoding='utf-8') as f:
            json.dump(name_map, f, ensure_ascii=False, indent=2)
        print(f"  Wrote name_mapping.json")

        with open(VOCAB_PATH, 'w', encoding='utf-8') as f:
            json.dump(vocab, f, ensure_ascii=False, indent=2)
        print(f"  Wrote unified_vocabulary.json")

        # Regenerate source tree
        print("\nRegenerating source tree...")
        import subprocess
        result = subprocess.run(
            [sys.executable, str(BASE_DIR / 'tools' / 'generate_source_tree.py')],
            capture_output=True, text=True, encoding='utf-8'
        )
        if result.returncode == 0:
            for line in result.stdout.strip().split('\n')[-5:]:
                print(f"  {line}")
        else:
            print(f"  ERROR: {result.stderr[-300:]}")
    else:
        print("\n[DRY-RUN] No files written")

    print(f"\n{'=' * 60}")
    print(f"  Done! {renamed} classes renamed, {new_vocab} vocab entries, {map_adds} mappings")
    print(f"{'=' * 60}")


if __name__ == '__main__':
    main()
