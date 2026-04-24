#!/usr/bin/env python3
"""
VRChat IL2CPP Quick Update
===========================
Fast vocabulary merge + source tree regeneration.
Skips heavy binary analysis and full deobfuscation pipeline.

Use this when you have new name sources (mods, community maps, mined names)
and want to quickly update the vocabulary and source tree without re-running
the full multi-hour pipeline.

Usage:
  python tools/quick_update.py                    # merge vocab + regen source tree
  python tools/quick_update.py --vocab-only       # only merge vocabularies
  python tools/quick_update.py --tree-only        # only regenerate source tree
  python tools/quick_update.py --apply-xrefs      # also apply cross-references
  python tools/quick_update.py --stats            # show stats without modifying
"""

import json, sys, os, re, time, collections, argparse, hashlib
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

# ── Paths ─────────────────────────────────────────────────────────────

BASE_DIR = Path(__file__).resolve().parent.parent  # il2cpp_dump_tools/
TOOLS_DIR = BASE_DIR / 'tools'
OUTPUT_DIR = BASE_DIR / 'output'
CACHE_PATH = OUTPUT_DIR / '.pipeline_cache.json'

MASTER_VOCAB       = OUTPUT_DIR / 'master_vocabulary.json'
UNIFIED_VOCAB      = OUTPUT_DIR / 'unified_vocabulary.json'
MINED_V1           = OUTPUT_DIR / 'mined_new_names.json'
MINED_V2           = OUTPUT_DIR / 'mined_new_names_v2.json'
MINED_V3           = OUTPUT_DIR / 'mined_new_names_v3.json'
MOD_NAMES          = OUTPUT_DIR / 'mod_extracted_names.json'
COMMUNITY_MAP      = OUTPUT_DIR / 'community_name_mapping.json'
STRUCTURAL         = OUTPUT_DIR / 'structural_matches.json'
ADDITIONAL         = OUTPUT_DIR / 'additional_names.json'
ALL_COMMUNITY      = OUTPUT_DIR / 'all_community_mappings.json'
SDK_EXTRACTIONS    = OUTPUT_DIR / 'il2cpp_sdk_extractions.json'
DEOBF_JSON         = OUTPUT_DIR / 'deobfuscated_dump.json'
NAME_MAPPING       = OUTPUT_DIR / 'name_mapping.json'
SRC_DIR            = OUTPUT_DIR / 'src'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

# ── Cache Helpers ─────────────────────────────────────────────────────

VOCAB_SOURCES = [
    MASTER_VOCAB, MINED_V1, MINED_V2, MINED_V3, MOD_NAMES,
    COMMUNITY_MAP, STRUCTURAL, ADDITIONAL, ALL_COMMUNITY, SDK_EXTRACTIONS,
]


def file_hash(path: Path) -> str | None:
    """Compute SHA256 of a file using streaming reads. Returns None if missing."""
    if not path.exists():
        return None
    h = hashlib.sha256()
    with open(path, 'rb') as f:
        while True:
            chunk = f.read(1 << 20)
            if not chunk:
                break
            h.update(chunk)
    return h.hexdigest()


def load_cache() -> dict:
    if CACHE_PATH.exists():
        try:
            with open(CACHE_PATH, 'r', encoding='utf-8') as f:
                return json.load(f)
        except (json.JSONDecodeError, OSError):
            return {}
    return {}


def save_cache(cache: dict):
    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    with open(CACHE_PATH, 'w', encoding='utf-8') as f:
        json.dump(cache, f, indent=2, ensure_ascii=False)


def check_vocab_cache(cache: dict, force: bool = False) -> bool:
    """Check if vocab merge can be skipped. Returns True if skip OK."""
    if force:
        return False
    cached = cache.get('quick_vocab')
    if not cached or not cached.get('completed'):
        return False
    if not UNIFIED_VOCAB.exists():
        return False
    current = {str(p.name): file_hash(p) for p in VOCAB_SOURCES}
    return current == cached.get('input_hashes', {})


def record_vocab_cache(cache: dict):
    """Record that vocab merge completed with current input hashes."""
    cache['quick_vocab'] = {
        'input_hashes': {str(p.name): file_hash(p) for p in VOCAB_SOURCES},
        'output_hash': file_hash(UNIFIED_VOCAB),
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'completed': True,
    }
    # Also update stage_0 in the shared cache so run_full_pipeline sees it
    cache['stage_0'] = {
        'input_hashes': {str(p.name): file_hash(p) for p in VOCAB_SOURCES},
        'output_hash': file_hash(UNIFIED_VOCAB),
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'completed': True,
    }
    save_cache(cache)


def load_json(path: Path) -> dict | list | None:
    """Load JSON file, return None if missing."""
    if not path.exists():
        return None
    try:
        with open(path, 'r', encoding='utf-8') as f:
            return json.load(f)
    except Exception as e:
        print(f'  WARNING: Failed to load {path.name}: {e}')
        return None


def quick_vocab_merge():
    """Fast merge of all name sources into unified vocabulary."""
    print('=' * 50)
    print('Quick Vocabulary Merge')
    print('=' * 50)

    all_names: set = set()
    sig_map: dict = {}
    sources: list = []
    source_counts: dict = {}

    # ── Load each source ──────────────────────────────────────────────

    # 1. Master vocabulary
    data = load_json(MASTER_VOCAB)
    if data:
        names = data.get('names', [])
        valid = sum(1 for n in names if isinstance(n, str) and 1 < len(n) < 200)
        for n in names:
            if isinstance(n, str) and 1 < len(n) < 200:
                all_names.add(n)
        sigs = data.get('signature_to_name', {})
        sig_map.update(sigs)
        sources.append('master_vocabulary')
        source_counts['master_vocabulary'] = valid
        print(f'  master_vocabulary:       {valid:>7,} names, {len(sigs):>5,} sigs')

    # 2-4. Mined names (v1, v2, v3)
    for label, path, display in [('mined_v1', MINED_V1, 'mined_new_names'),
                                  ('mined_v2', MINED_V2, 'mined_new_names_v2'),
                                  ('mined_v3', MINED_V3, 'mined_new_names_v3')]:
        data = load_json(path)
        if data:
            # v1 uses 'names', v2/v3 use 'all_new'
            items = data.get('names', []) + data.get('all_new', [])
            before = len(all_names)
            for n in items:
                if isinstance(n, str) and 1 < len(n) < 200:
                    all_names.add(n)
            added = len(all_names) - before
            sources.append(label)
            source_counts[label] = added
            print(f'  {display+":":<27s}{added:>7,} new')

    # 4. Mod extracted names
    data = load_json(MOD_NAMES)
    if data:
        before = len(all_names)
        for key in ('class_names_from_mods', 'all_class_names'):
            for n in data.get(key, []):
                if isinstance(n, str) and len(n) > 1:
                    all_names.add(n)
        for fp in data.get('field_patterns', []):
            if isinstance(fp, dict):
                name = fp.get('name', fp.get('field_name', ''))
                if name and len(name) > 1:
                    all_names.add(name)
            elif isinstance(fp, str) and len(fp) > 1:
                all_names.add(fp)
        added = len(all_names) - before
        sources.append('mod_extracted')
        source_counts['mod_extracted'] = added
        print(f'  mod_extracted_names:     {added:>7,} new')

    # 5. Community name mapping
    data = load_json(COMMUNITY_MAP)
    if data:
        before = len(all_names)
        for key in ('unique_names', 'names'):
            for n in data.get(key, []):
                if isinstance(n, str) and len(n) > 1:
                    all_names.add(n)
        direct = data.get('direct_matches', {})
        if isinstance(direct, dict):
            for k, v in direct.items():
                if isinstance(v, str) and len(v) > 1:
                    sig_map[k] = v
                    all_names.add(v)
        added = len(all_names) - before
        sources.append('community_map')
        source_counts['community_map'] = added
        print(f'  community_name_mapping:  {added:>7,} new')

    # 6. Structural matches
    data = load_json(STRUCTURAL)
    if data:
        before = len(all_names)
        for n in data.get('community_vocabulary', []):
            if isinstance(n, str) and len(n) > 1:
                all_names.add(n)
        matches = data.get('matches', {})
        if isinstance(matches, dict):
            for k, v in matches.items():
                if isinstance(v, dict):
                    name = v.get('real_name', v.get('name', ''))
                    if name and len(name) > 1:
                        all_names.add(name)
                        sig_map[k] = name
                elif isinstance(v, str) and len(v) > 1:
                    all_names.add(v)
                    sig_map[k] = v
        added = len(all_names) - before
        sources.append('structural')
        source_counts['structural'] = added
        print(f'  structural_matches:      {added:>7,} new')

    # 7. Additional names
    data = load_json(ADDITIONAL)
    if data:
        before = len(all_names)
        for key in ('class_names', 'method_names'):
            items = data.get(key, {})
            if isinstance(items, dict):
                for v in items.values():
                    if isinstance(v, str) and len(v) > 1:
                        all_names.add(v)
        added = len(all_names) - before
        sources.append('additional')
        source_counts['additional'] = added
        print(f'  additional_names:        {added:>7,} new')

    # 8. All community mappings (if exists)
    data = load_json(ALL_COMMUNITY)
    if data:
        before = len(all_names)
        if isinstance(data, dict):
            # Primary format: merged_obf_to_real dict
            obf_to_real = data.get('merged_obf_to_real', {})
            if isinstance(obf_to_real, dict):
                for obf_sig, real_name in obf_to_real.items():
                    if isinstance(real_name, str) and len(real_name) > 1:
                        sig_map[obf_sig] = real_name
                        all_names.add(real_name)
            # Also grab readable real names list
            for key in ('readable_real_names', 'all_real_names'):
                for n in data.get(key, []):
                    if isinstance(n, str) and len(n) > 1:
                        all_names.add(n)
            # Fallback generic keys
            for key in ('mappings', 'names', 'unique_names', 'all_mappings'):
                items = data.get(key, [])
                if isinstance(items, list):
                    for n in items:
                        if isinstance(n, str) and len(n) > 1:
                            all_names.add(n)
                elif isinstance(items, dict):
                    for k, v in items.items():
                        if isinstance(v, str) and len(v) > 1:
                            sig_map[k] = v
                            all_names.add(v)
        added = len(all_names) - before
        sources.append('all_community')
        source_counts['all_community'] = added
        print(f'  all_community_mappings:  {added:>7,} new')

    # 9. SDK extractions (if exists)
    data = load_json(SDK_EXTRACTIONS)
    if data:
        before = len(all_names)
        if isinstance(data, dict):
            for key in ('class_names', 'method_names', 'field_names', 'names', 'types'):
                items = data.get(key, [])
                if isinstance(items, list):
                    for n in items:
                        if isinstance(n, str) and len(n) > 1:
                            all_names.add(n)
                elif isinstance(items, dict):
                    for v in items.values():
                        if isinstance(v, str) and len(v) > 1:
                            all_names.add(v)
        added = len(all_names) - before
        sources.append('sdk_extractions')
        source_counts['sdk_extractions'] = added
        print(f'  il2cpp_sdk_extractions:  {added:>7,} new')

    # ── Save ──────────────────────────────────────────────────────────
    print(f'\n  Total unified: {len(all_names):,} names, {len(sig_map):,} signature mappings')

    # Compare with previous if exists
    prev = load_json(UNIFIED_VOCAB)
    if prev:
        prev_count = prev.get('total_unified_names', 0)
        delta = len(all_names) - prev_count
        print(f'  Delta from previous: {delta:+,}')

    unified = {
        'generated_by': 'quick_update.py',
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'sources': sources,
        'source_counts': source_counts,
        'total_unified_names': len(all_names),
        'total_signature_mappings': len(sig_map),
        'unified_names': sorted(all_names),
        'signature_to_name': sig_map,
    }

    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    with open(UNIFIED_VOCAB, 'w', encoding='utf-8') as f:
        json.dump(unified, f, indent=2, ensure_ascii=False)

    print(f'  Saved: {UNIFIED_VOCAB}')
    return unified


def quick_source_tree():
    """Regenerate source tree from existing deobfuscated dump."""
    print()
    print('=' * 50)
    print('Quick Source Tree Regeneration')
    print('=' * 50)

    if not DEOBF_JSON.exists():
        print(f'  ERROR: {DEOBF_JSON} not found.')
        print(f'  Run the full pipeline first: python tools/run_full_pipeline.py')
        return False

    try:
        sys.path.insert(0, str(TOOLS_DIR))
        import generate_source_tree as gen_src

        gen_src.INPUT_PATH = DEOBF_JSON
        gen_src.OUTPUT_DIR = SRC_DIR
        gen_src.main()
        print(f'  Source tree regenerated at: {SRC_DIR}')
        return True
    except Exception as e:
        print(f'  ERROR: {e}')
        print(f'  Try running directly: python tools/generate_source_tree.py')
        return False


def quick_apply_xrefs():
    """Fast pass applying cross-references to existing deobfuscated dump."""
    print()
    print('=' * 50)
    print('Quick Cross-Reference Application')
    print('=' * 50)

    if not DEOBF_JSON.exists():
        print(f'  ERROR: {DEOBF_JSON} not found.')
        return False

    print(f'  Loading deobfuscated dump ...')
    with open(DEOBF_JSON, 'r', encoding='utf-8') as f:
        deobf = json.load(f)

    mapping_data = load_json(NAME_MAPPING) or {'classes': {}, 'methods': {}, 'fields': {}}
    class_map = mapping_data.get('classes', {})
    updates = 0

    # Apply structural matches with high confidence
    struct_data = load_json(STRUCTURAL)
    if struct_data:
        matches = struct_data.get('matches', {})
        for obf_name, match_info in matches.items():
            real_name = match_info.get('real_name', '') if isinstance(match_info, dict) else str(match_info)
            confidence = match_info.get('confidence', 70) if isinstance(match_info, dict) else 70
            if not real_name or confidence < 75:
                continue
            for ns, classes in deobf.get('namespaces', {}).items():
                for cls in classes:
                    if cls.get('original_name', '') == obf_name:
                        current = cls['name']
                        if _is_weak(current) and real_name != current:
                            cls['name'] = real_name
                            class_map[obf_name] = real_name
                            updates += 1
                        break

    # Apply community direct matches
    comm_data = load_json(COMMUNITY_MAP)
    if comm_data:
        direct = comm_data.get('direct_matches', {})
        for obf_sig, real_name in direct.items():
            if not real_name or not isinstance(real_name, str):
                continue
            for ns, classes in deobf.get('namespaces', {}).items():
                for cls in classes:
                    orig = cls.get('original_name', '')
                    if orig == obf_sig and _is_weak(cls['name']):
                        cls['name'] = real_name
                        class_map[orig] = real_name
                        updates += 1
                        break

    if updates > 0:
        print(f'  Applied {updates} cross-reference updates')
        with open(DEOBF_JSON, 'w', encoding='utf-8') as f:
            json.dump(deobf, f, indent=2, ensure_ascii=False)
        mapping_data['classes'] = class_map
        mapping_data['reverse_classes'] = {v: k for k, v in class_map.items()}
        with open(NAME_MAPPING, 'w', encoding='utf-8') as f:
            json.dump(mapping_data, f, indent=2, ensure_ascii=False)
        print(f'  Updated: {DEOBF_JSON.name}, {NAME_MAPPING.name}')
    else:
        print(f'  No new updates to apply.')

    return True


def show_stats():
    """Show current pipeline statistics without modifying anything."""
    print('=' * 50)
    print('Pipeline Statistics')
    print('=' * 50)

    print(f'\n  Base: {BASE_DIR}')
    print()

    # Check all data files
    files = [
        ('Input Dump',    BASE_DIR / 'data' / 'precise_dump.json'),
        ('Deobf Dump',    DEOBF_JSON),
        ('Name Mapping',  NAME_MAPPING),
        ('Master Vocab',  MASTER_VOCAB),
        ('Unified Vocab', UNIFIED_VOCAB),
        ('Mined v1',      MINED_V1),
        ('Mined v2',      MINED_V2),
        ('Mod Names',     MOD_NAMES),
        ('Community Map', COMMUNITY_MAP),
        ('Structural',    STRUCTURAL),
        ('Additional',    ADDITIONAL),
        ('Deep Analysis', OUTPUT_DIR / 'deep_analysis.json'),
    ]

    print(f'  {"File":<25s} {"Status":<10s} {"Size":<12s}')
    print(f'  {"-"*25} {"-"*10} {"-"*12}')
    for label, path in files:
        if path.exists():
            size = path.stat().st_size
            if size > 1024 * 1024:
                size_str = f'{size/1024/1024:.1f} MB'
            else:
                size_str = f'{size/1024:.1f} KB'
            print(f'  {label:<25s} {"OK":<10s} {size_str:<12s}')
        else:
            print(f'  {label:<25s} {"MISSING":<10s}')

    # Deobfuscation stats
    if DEOBF_JSON.exists():
        print()
        with open(DEOBF_JSON, 'r', encoding='utf-8') as f:
            data = json.load(f)

        total = 0
        renamed = 0
        semantic = 0
        for ns, classes in data.get('namespaces', {}).items():
            for cls in classes:
                total += 1
                if cls.get('original_name'):
                    renamed += 1
                    if not _is_weak(cls['name']):
                        semantic += 1

        print(f'  Deobfuscation Coverage:')
        print(f'    Total classes:   {total:,}')
        print(f'    Renamed:         {renamed:,}')
        print(f'    Semantic names:  {semantic:,}')
        if renamed > 0:
            print(f'    Semantic rate:   {100*semantic/renamed:.1f}%')

    # Vocabulary stats
    if UNIFIED_VOCAB.exists():
        print()
        with open(UNIFIED_VOCAB, 'r', encoding='utf-8') as f:
            unified = json.load(f)
        print(f'  Unified Vocabulary:')
        print(f'    Total names:     {unified.get("total_unified_names", 0):,}')
        print(f'    Sig mappings:    {unified.get("total_signature_mappings", 0):,}')
        print(f'    Sources:         {", ".join(unified.get("sources", []))}')
        print(f'    Last updated:    {unified.get("timestamp", "unknown")}')

    # Source tree stats
    if SRC_DIR.exists():
        cs_files = list(SRC_DIR.rglob('*.cs'))
        print(f'\n  Source Tree:')
        print(f'    .cs files:       {len(cs_files)}')
        print(f'    Location:        {SRC_DIR}')

    print()


def _is_weak(name: str) -> bool:
    """Check if a name is a weak/fallback deobfuscation name."""
    if re.match(r'^(Type|Struct|Mono|Service|Major|Static|DataOnly|Unknown|Record|EmptyType|EmptyStruct)\d+', name):
        return True
    return name.startswith(('Obf_', 'Class_', 'EmptyClass_', 'LargeClass_'))


def main():
    parser = argparse.ArgumentParser(
        description='VRChat IL2CPP Quick Update - Fast vocab merge + source tree regen',
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Quick update is for iterating fast on name sources without re-running
the full pipeline. It merges all vocabularies and regenerates the
source tree from the existing deobfuscated dump.

For a full re-deobfuscation, use: python tools/run_full_pipeline.py
        """
    )
    parser.add_argument('--vocab-only', action='store_true',
                        help='Only merge vocabularies, skip source tree')
    parser.add_argument('--tree-only', action='store_true',
                        help='Only regenerate source tree, skip vocab merge')
    parser.add_argument('--apply-xrefs', action='store_true',
                        help='Also apply cross-references to deobfuscated dump')
    parser.add_argument('--stats', action='store_true',
                        help='Show statistics without modifying anything')
    parser.add_argument('--force', action='store_true',
                        help='Bypass incremental cache, re-run even if inputs unchanged')
    parser.add_argument('--check', action='store_true',
                        help='Show whether vocab merge would run or skip (no execution)')

    args = parser.parse_args()

    start = time.time()
    cache = load_cache()

    if args.stats:
        show_stats()
        return

    if args.check:
        can_skip = check_vocab_cache(cache, force=args.force)
        if can_skip:
            cached_info = cache.get('quick_vocab', {})
            ts = cached_info.get('timestamp', 'unknown')
            existing = sum(1 for p in VOCAB_SOURCES if p.exists())
            print(f'\u23ed Vocab merge: All {existing} inputs unchanged, would skip (cached {ts})')
        else:
            print(f'\u25b6 Vocab merge: Would run (inputs changed or no cache)')
        if not args.tree_only and not args.vocab_only:
            print(f'\u25b6 Source tree: Would always run (depends on deobfuscated_dump.json)')
        return

    if args.tree_only:
        quick_source_tree()
    elif args.vocab_only:
        if check_vocab_cache(cache, force=args.force):
            cached_info = cache.get('quick_vocab', {})
            ts = cached_info.get('timestamp', 'unknown')
            existing = sum(1 for p in VOCAB_SOURCES if p.exists())
            print(f'\n\u23ed Vocab merge: All {existing} inputs unchanged, skipping (cached {ts})')
        else:
            quick_vocab_merge()
            record_vocab_cache(cache)
    else:
        # Default: merge vocab + regen tree
        if check_vocab_cache(cache, force=args.force):
            cached_info = cache.get('quick_vocab', {})
            ts = cached_info.get('timestamp', 'unknown')
            existing = sum(1 for p in VOCAB_SOURCES if p.exists())
            print(f'\n\u23ed Vocab merge: All {existing} inputs unchanged, skipping (cached {ts})')
        else:
            quick_vocab_merge()
            record_vocab_cache(cache)

        if args.apply_xrefs:
            quick_apply_xrefs()

        quick_source_tree()

    elapsed = time.time() - start
    print(f'Done in {elapsed:.1f}s')


if __name__ == '__main__':
    main()
