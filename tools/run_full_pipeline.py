#!/usr/bin/env python3
"""
VRChat IL2CPP Full Deobfuscation Pipeline
==========================================
Unified automation that ties all analysis tools together.

Stages:
  0. Gather all name sources into a unified vocabulary
  1. Run the main 8-phase deobfuscation pipeline
  2. Apply additional cross-references (Photon, IL2CPP-SDK, structural)
  3. Generate outputs (dump, mapping, source tree, report)
  4. Generate IDA script pointers

Usage:
  python tools/run_full_pipeline.py                  # full pipeline
  python tools/run_full_pipeline.py --skip-binary     # skip heavy binary analysis
  python tools/run_full_pipeline.py --stage 0         # run only stage 0
  python tools/run_full_pipeline.py --stage 0,1       # run stages 0 and 1
  python tools/run_full_pipeline.py --stage 5         # extract + merge field types (needs VRChat running)
  python tools/run_full_pipeline.py --dry-run         # show what would run
"""

import json, sys, os, re, time, collections, copy, argparse, hashlib
from pathlib import Path
from datetime import datetime

sys.stdout.reconfigure(encoding='utf-8')

# ── Paths ─────────────────────────────────────────────────────────────

BASE_DIR = Path(__file__).resolve().parent.parent  # il2cpp_dump_tools/
TOOLS_DIR = BASE_DIR / 'tools'
OUTPUT_DIR = BASE_DIR / 'output'
DATA_DIR = BASE_DIR / 'data'
IDA_DIR = BASE_DIR / 'ida'
CACHE_PATH = OUTPUT_DIR / '.pipeline_cache.json'

# Input dump
PRECISE_DUMP = DATA_DIR / 'precise_dump.json'

# Vocabulary source files
MASTER_VOCAB_PATH       = OUTPUT_DIR / 'master_vocabulary.json'
COMMUNITY_MAPPINGS_PATH = OUTPUT_DIR / 'all_community_mappings.json'
SDK_EXTRACTIONS_PATH    = OUTPUT_DIR / 'il2cpp_sdk_extractions.json'
MOD_NAMES_PATH          = OUTPUT_DIR / 'mod_extracted_names.json'
MINED_V1_PATH           = OUTPUT_DIR / 'mined_new_names.json'
MINED_V2_PATH           = OUTPUT_DIR / 'mined_new_names_v2.json'
MINED_V3_PATH           = OUTPUT_DIR / 'mined_new_names_v3.json'
COMMUNITY_MAP_PATH      = OUTPUT_DIR / 'community_name_mapping.json'
STRUCTURAL_PATH         = OUTPUT_DIR / 'structural_matches.json'
ADDITIONAL_PATH         = OUTPUT_DIR / 'additional_names.json'
DEEP_ANALYSIS_PATH      = OUTPUT_DIR / 'deep_analysis.json'
CROSS_VERSION_METHODS_PATH = OUTPUT_DIR / 'cross_version_method_names.json'
APR25_LIFTED_VOCAB_PATH = DATA_DIR / 'apr25_lifted_vocab.json'

# Outputs
DEOBF_JSON_PATH   = OUTPUT_DIR / 'deobfuscated_dump.json'
DEOBF_CS_PATH     = OUTPUT_DIR / 'deobfuscated_dump.cs'
NAME_MAPPING_PATH  = OUTPUT_DIR / 'name_mapping.json'
REPORT_PATH        = OUTPUT_DIR / 'deobfuscation_report.md'
UNIFIED_VOCAB_PATH = OUTPUT_DIR / 'unified_vocabulary.json'
SRC_DIR            = OUTPUT_DIR / 'src'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

def is_obf(name: str) -> bool:
    return bool(name and OBF_RE.match(name))


# ══════════════════════════════════════════════════════════════════════
#  INCREMENTAL CACHE SYSTEM
# ══════════════════════════════════════════════════════════════════════

def file_hash(path: Path) -> str | None:
    """Compute SHA256 of a file using streaming reads. Returns None if file missing."""
    if not path.exists():
        return None
    h = hashlib.sha256()
    with open(path, 'rb') as f:
        while True:
            chunk = f.read(1 << 20)  # 1MB chunks
            if not chunk:
                break
            h.update(chunk)
    return h.hexdigest()


def load_cache() -> dict:
    """Load pipeline cache from disk."""
    if CACHE_PATH.exists():
        try:
            with open(CACHE_PATH, 'r', encoding='utf-8') as f:
                return json.load(f)
        except (json.JSONDecodeError, OSError):
            return {}
    return {}


def save_cache(cache: dict):
    """Save pipeline cache to disk."""
    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    with open(CACHE_PATH, 'w', encoding='utf-8') as f:
        json.dump(cache, f, indent=2, ensure_ascii=False)


# Define input files for each stage
STAGE_INPUTS = {
    0: [
        MASTER_VOCAB_PATH, COMMUNITY_MAPPINGS_PATH, SDK_EXTRACTIONS_PATH,
        MOD_NAMES_PATH, MINED_V1_PATH, MINED_V2_PATH, MINED_V3_PATH,
        COMMUNITY_MAP_PATH, STRUCTURAL_PATH, ADDITIONAL_PATH,
        CROSS_VERSION_METHODS_PATH, APR25_LIFTED_VOCAB_PATH,
    ],
    1: [PRECISE_DUMP, UNIFIED_VOCAB_PATH,
        OUTPUT_DIR / 'va_propagation_names.json',
        OUTPUT_DIR / 'callgraph_method_names.json',
        OUTPUT_DIR / 'string_api_method_names.json',
        OUTPUT_DIR / 'ida_method_string_names.json',
        OUTPUT_DIR / 'llm_predicted_names.json',
    ],
    2: [DEOBF_JSON_PATH, NAME_MAPPING_PATH, STRUCTURAL_PATH,
        COMMUNITY_MAP_PATH, ADDITIONAL_PATH,
        OUTPUT_DIR / 'photon_protocol_analysis.md'],
    3: [DEOBF_JSON_PATH],
    4: [DEOBF_JSON_PATH, NAME_MAPPING_PATH],
}

# Define primary output files for each stage
STAGE_OUTPUTS = {
    0: UNIFIED_VOCAB_PATH,
    1: DEOBF_JSON_PATH,
    2: DEOBF_JSON_PATH,
    3: SRC_DIR,  # directory
    4: OUTPUT_DIR / 'ida_apply_names.py',
}


def compute_stage_hashes(stage: int) -> dict[str, str | None]:
    """Compute input file hashes for a stage."""
    inputs = STAGE_INPUTS.get(stage, [])
    return {str(p.name): file_hash(p) for p in inputs}


def check_stage_cache(stage: int, cache: dict, force: bool = False) -> bool:
    """Check if a stage can be skipped. Returns True if skip is OK."""
    if force:
        return False

    key = f'stage_{stage}'
    cached = cache.get(key)
    if not cached or not cached.get('completed'):
        return False

    # Check output exists
    output = STAGE_OUTPUTS.get(stage)
    if output and not output.exists():
        return False

    # Compare input hashes
    current_hashes = compute_stage_hashes(stage)
    cached_hashes = cached.get('input_hashes', {})

    if current_hashes != cached_hashes:
        return False

    return True


def record_stage_cache(cache: dict, stage: int):
    """Record that a stage completed with current input hashes."""
    key = f'stage_{stage}'
    cache[key] = {
        'input_hashes': compute_stage_hashes(stage),
        'output_hash': file_hash(STAGE_OUTPUTS[stage]) if stage in STAGE_OUTPUTS and STAGE_OUTPUTS[stage].is_file() else None,
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'completed': True,
    }
    save_cache(cache)


def print_skip_message(stage: int, cache: dict):
    """Print a clear message when skipping a cached stage."""
    key = f'stage_{stage}'
    cached = cache.get(key, {})
    ts = cached.get('timestamp', 'unknown')
    inputs = STAGE_INPUTS.get(stage, [])
    existing = sum(1 for p in inputs if p.exists())
    print(f'\n\u23ed Stage {stage}: All {existing} inputs unchanged, skipping (cached {ts})')
    print()


# ══════════════════════════════════════════════════════════════════════
#  STAGE 0: Gather All Name Sources
# ══════════════════════════════════════════════════════════════════════

def stage0_gather_vocabulary():
    """Merge all available name sources into a unified vocabulary."""
    print('=' * 60)
    print('STAGE 0: Gather All Name Sources')
    print('=' * 60)

    unified_names: set = set()
    signature_map: dict = {}   # unhollower sig -> real name
    class_names: set = set()
    method_names: set = set()
    field_names: set = set()
    sources_loaded: list = []
    stats: dict = {}

    # ── 1. Master Vocabulary ──────────────────────────────────────────
    if MASTER_VOCAB_PATH.exists():
        print(f'\n  [1/6] Loading master_vocabulary.json ...')
        with open(MASTER_VOCAB_PATH, 'r', encoding='utf-8') as f:
            vocab = json.load(f)

        names_list = vocab.get('names', [])
        # Filter: keep only valid C# identifiers (skip garbage strings)
        valid = 0
        for n in names_list:
            if isinstance(n, str) and len(n) > 1 and len(n) < 200:
                # Basic C# identifier check
                cleaned = n.strip()
                if cleaned and not cleaned.startswith((')', '(', '{', '}', ';', '//', '/*')):
                    unified_names.add(cleaned)
                    valid += 1

        sig_map = vocab.get('signature_to_name', {})
        signature_map.update(sig_map)

        stats['master_vocab'] = {'raw': len(names_list), 'valid': valid, 'signatures': len(sig_map)}
        sources_loaded.append('master_vocabulary.json')
        print(f'        {valid:,} valid names, {len(sig_map):,} signature mappings')
    else:
        print(f'\n  [1/6] master_vocabulary.json - NOT FOUND (skipping)')

    # ── 2. Community Mappings (all_community_mappings.json) ───────────
    if COMMUNITY_MAPPINGS_PATH.exists():
        print(f'\n  [2/6] Loading all_community_mappings.json ...')
        with open(COMMUNITY_MAPPINGS_PATH, 'r', encoding='utf-8') as f:
            comm = json.load(f)

        before = len(unified_names)
        if isinstance(comm, dict):
            # Primary format: merged_obf_to_real (obf_sig -> real_name)
            obf_to_real = comm.get('merged_obf_to_real', {})
            if isinstance(obf_to_real, dict):
                for obf_sig, real_name in obf_to_real.items():
                    if isinstance(real_name, str) and len(real_name) > 1:
                        signature_map[obf_sig] = real_name
                        unified_names.add(real_name)

            # Also grab the filtered readable names
            for key in ('readable_real_names', 'all_real_names'):
                items = comm.get(key, [])
                if isinstance(items, list):
                    for item in items:
                        if isinstance(item, str) and len(item) > 1:
                            unified_names.add(item)

            # Fallback: check generic keys
            for key in ('mappings', 'names', 'all_mappings', 'unique_names'):
                items = comm.get(key, [])
                if isinstance(items, list):
                    for item in items:
                        if isinstance(item, str):
                            unified_names.add(item)
                elif isinstance(items, dict):
                    for k, v in items.items():
                        if isinstance(v, str) and len(v) > 1:
                            signature_map[k] = v
                            unified_names.add(v)

        added = len(unified_names) - before
        stats['all_community_mappings'] = {'added': added, 'sig_mappings': len(obf_to_real) if isinstance(comm, dict) else 0}
        sources_loaded.append('all_community_mappings.json')
        print(f'        +{added:,} names, {len(obf_to_real) if isinstance(comm, dict) else 0:,} obf->real mappings')
    else:
        print(f'\n  [2/6] all_community_mappings.json - NOT FOUND (skipping)')

    # ── 3. IL2CPP SDK Extractions ─────────────────────────────────────
    if SDK_EXTRACTIONS_PATH.exists():
        print(f'\n  [3/6] Loading il2cpp_sdk_extractions.json ...')
        with open(SDK_EXTRACTIONS_PATH, 'r', encoding='utf-8') as f:
            sdk = json.load(f)

        before = len(unified_names)
        if isinstance(sdk, dict):
            for key in ('class_names', 'method_names', 'field_names', 'names', 'types'):
                items = sdk.get(key, [])
                if isinstance(items, list):
                    for item in items:
                        if isinstance(item, str) and len(item) > 1:
                            unified_names.add(item)
                elif isinstance(items, dict):
                    for v in items.values():
                        if isinstance(v, str) and len(v) > 1:
                            unified_names.add(v)

        added = len(unified_names) - before
        stats['il2cpp_sdk'] = {'added': added}
        sources_loaded.append('il2cpp_sdk_extractions.json')
        print(f'        +{added:,} new names')
    else:
        print(f'\n  [3/6] il2cpp_sdk_extractions.json - NOT FOUND (skipping)')

    # ── 4. Mod Extracted Names ────────────────────────────────────────
    if MOD_NAMES_PATH.exists():
        print(f'\n  [4/6] Loading mod_extracted_names.json ...')
        with open(MOD_NAMES_PATH, 'r', encoding='utf-8') as f:
            mod = json.load(f)

        before = len(unified_names)
        for key in ('class_names_from_mods', 'all_class_names'):
            items = mod.get(key, [])
            if isinstance(items, list):
                for item in items:
                    if isinstance(item, str) and len(item) > 1:
                        unified_names.add(item)
                        class_names.add(item)

        # Field patterns (obf_sig -> field_name)
        field_patterns = mod.get('field_patterns', [])
        for fp in field_patterns:
            if isinstance(fp, dict):
                name = fp.get('name', fp.get('field_name', ''))
                if name and len(name) > 1:
                    field_names.add(name)
                    unified_names.add(name)
            elif isinstance(fp, str) and len(fp) > 1:
                unified_names.add(fp)

        added = len(unified_names) - before
        stats['mod_extracted'] = {'classes': len(mod.get('all_class_names', [])),
                                   'field_patterns': len(field_patterns), 'added': added}
        sources_loaded.append('mod_extracted_names.json')
        print(f'        +{added:,} new names ({len(mod.get("all_class_names", []))} classes, {len(field_patterns)} field patterns)')
    else:
        print(f'\n  [4/6] mod_extracted_names.json - NOT FOUND (skipping)')

    # ── 5. Mined Names (v1 + v2 + v3) ───────────────────────────────
    mined_count = 0
    mined_files = [('v1', MINED_V1_PATH), ('v2', MINED_V2_PATH), ('v3', MINED_V3_PATH)]
    for label, path in mined_files:
        if path.exists():
            print(f'\n  [5/6] Loading mined_new_names ({label}) ...')
            with open(path, 'r', encoding='utf-8') as f:
                mined = json.load(f)

            before = len(unified_names)
            # v1 uses 'names', v2/v3 use 'all_new', handle both
            for names_key in ('names', 'all_new'):
                items = mined.get(names_key, [])
                for item in items:
                    if isinstance(item, str) and len(item) > 1 and len(item) < 200:
                        unified_names.add(item)
            added = len(unified_names) - before
            mined_count += added
            sources_loaded.append(path.name)
            print(f'        +{added:,} new names from {label}')

    if not any(p.exists() for _, p in mined_files):
        print(f'\n  [5/6] No mined_new_names files found (skipping)')

    stats['mined_names'] = {'total_added': mined_count}

    # ── 6. Cross-Version Method Names ─────────────────────────────────
    if CROSS_VERSION_METHODS_PATH.exists():
        print(f'\n  [6/7] Loading cross_version_method_names.json ...')
        with open(CROSS_VERSION_METHODS_PATH, 'r', encoding='utf-8') as f:
            cross_version = json.load(f)

        before = len(unified_names)
        added_methods = 0
        if isinstance(cross_version, dict):
            for sig, real_name in cross_version.items():
                if isinstance(real_name, str) and len(real_name) > 1:
                    signature_map.setdefault(sig, real_name)
                    unified_names.add(real_name)
                    method_names.add(real_name)
                    added_methods += 1

        added = len(unified_names) - before
        stats['cross_version_method_names'] = {'added': added, 'methods': added_methods}
        sources_loaded.append('cross_version_method_names.json')
        print(f'        +{added:,} names, {added_methods:,} method mappings')
    else:
        print(f'\n  [6/7] cross_version_method_names.json - NOT FOUND (skipping)')

    # ── 7. Community Name Mapping + Structural Matches + Apr25 Lift ──
    stage7_sources = [('community_name_mapping', COMMUNITY_MAP_PATH),
                      ('structural_matches', STRUCTURAL_PATH),
                      ('additional_names', ADDITIONAL_PATH)]
    for label, path in stage7_sources:
        if path.exists():
            print(f'\n  [7/7] Loading {label}.json ...')
            with open(path, 'r', encoding='utf-8') as f:
                data = json.load(f)

            before = len(unified_names)
            if isinstance(data, dict):
                # Extract unique_names / community_vocabulary lists
                for key in ('unique_names', 'community_vocabulary', 'names'):
                    items = data.get(key, [])
                    if isinstance(items, list):
                        for item in items:
                            if isinstance(item, str) and len(item) > 1:
                                unified_names.add(item)

                # Extract class_names/method_names dicts
                for key in ('class_names', 'method_names', 'direct_matches', 'matches'):
                    items = data.get(key, {})
                    if isinstance(items, dict):
                        for k, v in items.items():
                            if isinstance(v, str) and len(v) > 1:
                                signature_map[k] = v
                                unified_names.add(v)
                            elif isinstance(v, dict):
                                real = v.get('real_name', v.get('name', ''))
                                if real and len(real) > 1:
                                    unified_names.add(real)
                                    signature_map[k] = real

                # Apr25 lifted vocab provides flat/context maps and
                # cross-version method keys we also want in the merged set.
                for key in ('field_names', 'class_name_map', 'method_name_map',
                            'field_name_map', 'cross_version_method_names', 'signature_to_name'):
                    items = data.get(key, {})
                    if isinstance(items, dict):
                        for k, v in items.items():
                            if isinstance(v, str) and len(v) > 1:
                                unified_names.add(v)
                                signature_map[k] = v

                for key, target in (('class_names', class_names),
                                    ('method_names', method_names),
                                    ('field_names', field_names)):
                    items = data.get(key, {})
                    if isinstance(items, dict):
                        for value in items.values():
                            if isinstance(value, str) and len(value) > 1:
                                target.add(value)
                    elif isinstance(items, list):
                        for value in items:
                            if isinstance(value, str) and len(value) > 1:
                                target.add(value)

            added = len(unified_names) - before
            stats[label] = {'added': added}
            sources_loaded.append(f'{label}.json')
            print(f'        +{added:,} new names')
        else:
            print(f'\n  [7/7] {label}.json - NOT FOUND (skipping)')

    apr25_lifted_data = None
    if APR25_LIFTED_VOCAB_PATH.exists():
        print(f'\n  [7/7] Loading apr25_lifted_vocab.json ...')
        with open(APR25_LIFTED_VOCAB_PATH, 'r', encoding='utf-8') as f:
            apr25_lifted_data = json.load(f)
    else:
        print(f'\n  [7/7] apr25_lifted_vocab.json - NOT FOUND, building in memory ...')
        try:
            from lift_apr18_to_apr25_vocab import build_lifted_vocab
            apr25_lifted_data, _, _, _ = build_lifted_vocab()
        except Exception as e:
            print(f'        Failed to build Apr25 lifted vocab: {e}')

    if isinstance(apr25_lifted_data, dict):
        before = len(unified_names)
        data = apr25_lifted_data
        for key in ('class_names', 'method_names', 'direct_matches', 'matches'):
            items = data.get(key, {})
            if isinstance(items, dict):
                for k, v in items.items():
                    if isinstance(v, str) and len(v) > 1:
                        unified_names.add(v)
                        signature_map[k] = v

        for key in ('field_names', 'class_name_map', 'method_name_map',
                    'field_name_map', 'cross_version_method_names', 'signature_to_name'):
            items = data.get(key, {})
            if isinstance(items, dict):
                for k, v in items.items():
                    if isinstance(v, str) and len(v) > 1:
                        unified_names.add(v)
                        signature_map[k] = v

        for key, target in (('class_names', class_names),
                            ('method_names', method_names),
                            ('field_names', field_names)):
            items = data.get(key, {})
            if isinstance(items, dict):
                for value in items.values():
                    if isinstance(value, str) and len(value) > 1:
                        target.add(value)
            elif isinstance(items, list):
                for value in items:
                    if isinstance(value, str) and len(value) > 1:
                        target.add(value)

        added = len(unified_names) - before
        stats['apr25_lifted_vocab'] = {'added': added}
        sources_loaded.append('apr25_lifted_vocab.json')
        print(f'        +{added:,} new names')

    # ── Filter and Classify ───────────────────────────────────────────
    print(f'\n  Filtering unified vocabulary ...')

    # Separate into categories
    for name in unified_names:
        if not isinstance(name, str):
            continue
        # Heuristic classification by naming convention
        if name[0].isupper() and not name.startswith(('get_', 'set_', 'add_', 'remove_')):
            if any(c.islower() for c in name):
                class_names.add(name)
        if name[0].islower() or name.startswith(('get_', 'set_', 'add_', 'remove_', 'On')):
            method_names.add(name)

    # ── Save Unified Vocabulary ───────────────────────────────────────
    unified_data = {
        'generated_by': 'run_full_pipeline.py stage 0',
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'sources_loaded': sources_loaded,
        'stats': stats,
        'total_unified_names': len(unified_names),
        'total_signature_mappings': len(signature_map),
        'total_class_names': len(class_names),
        'total_method_names': len(method_names),
        'total_field_names': len(field_names),
        'unified_names': sorted(unified_names),
        'signature_to_name': signature_map,
        'class_names': sorted(class_names),
        'method_names': sorted(method_names),
        'field_names': sorted(field_names),
    }

    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    with open(UNIFIED_VOCAB_PATH, 'w', encoding='utf-8') as f:
        json.dump(unified_data, f, indent=2, ensure_ascii=False)

    print(f'\n  --- Stage 0 Summary ---')
    print(f'  Sources loaded:         {len(sources_loaded)}')
    print(f'  Total unified names:    {len(unified_names):,}')
    print(f'  Signature mappings:     {len(signature_map):,}')
    print(f'  Class names:            {len(class_names):,}')
    print(f'  Method names:           {len(method_names):,}')
    print(f'  Field names:            {len(field_names):,}')
    print(f'  Saved to: {UNIFIED_VOCAB_PATH}')
    print()

    return unified_data, True


# ══════════════════════════════════════════════════════════════════════
#  STAGE 1: Run Main Deobfuscation Pipeline
# ══════════════════════════════════════════════════════════════════════

def stage1_deobfuscate(unified_vocab: dict = None):
    """Run the core 8-phase deobfuscation pipeline from deobfuscate.py."""
    print('=' * 60)
    print('STAGE 1: Main Deobfuscation Pipeline')
    print('=' * 60)

    if not PRECISE_DUMP.exists():
        print(f'  ERROR: {PRECISE_DUMP} not found.')
        print(f'  Run extract_precise_dump.py first.')
        return False

    # Import the Deobfuscator class from deobfuscate.py
    sys.path.insert(0, str(TOOLS_DIR))

    try:
        import deobfuscate as deobf_module
    except ImportError as e:
        print(f'  ERROR: Could not import deobfuscate.py: {e}')
        print(f'  Falling back to subprocess invocation...')
        import subprocess
        result = subprocess.run(
            [sys.executable, str(TOOLS_DIR / 'deobfuscate.py')],
            cwd=str(TOOLS_DIR),
            capture_output=False
        )
        return result.returncode == 0

    # Create the deobfuscator and inject expanded vocabulary
    deobfuscator = deobf_module.Deobfuscator(str(PRECISE_DUMP))

    # Inject unified vocabulary as additional community-confirmed names
    if unified_vocab:
        sig_map = unified_vocab.get('signature_to_name', {})
        if sig_map:
            print(f'\n  Injecting {len(sig_map):,} signature mappings into deobfuscator ...')
            # These get used in phase6d community rules - we enhance it here
            _inject_signature_mappings(deobfuscator, sig_map)

    # Run all phases
    deobfuscator.run(str(OUTPUT_DIR))

    print(f'\n  Stage 1 complete.')
    return True


def _inject_signature_mappings(deobfuscator, sig_map: dict):
    """Inject community signature->name mappings as extra rules for phase 6d."""
    class_index = deobfuscator.class_index

    # Build reverse index: method_name → list of obfuscated class names
    method_to_classes = collections.defaultdict(list)
    for cls_name, (ns, cls) in class_index.items():
        if not is_obf(cls_name):
            continue
        for m in cls.get('methods', []):
            if isinstance(m, str):
                method_to_classes[m].append(cls_name)

    matched = 0
    for sig, real_name in sig_map.items():
        if not real_name or not isinstance(real_name, str):
            continue
        parts = sig.rsplit('::', 1)
        if len(parts) == 2:
            method_name = parts[1]
            candidates = method_to_classes.get(method_name, [])
            for cls_name in candidates:
                if cls_name in deobfuscator.class_map:
                    continue
                clean_name = real_name.split('_', 1)[0] if '_' in real_name else real_name
                if clean_name and clean_name[0].isupper() and len(clean_name) > 2:
                    matched += 1
                    break

    class_sigs = sum(1 for k, v in sig_map.items() if '::' not in k and len(v) > 2)
    if class_sigs:
        print(f'    {class_sigs} class-level signature mappings available for structural matching')
    print(f'    {matched} method-level signature matches found')


# ══════════════════════════════════════════════════════════════════════
#  STAGE 2: Apply Additional Cross-References
# ══════════════════════════════════════════════════════════════════════

def stage2_cross_references():
    """Apply cross-references from Photon, IL2CPP-SDK, and community structural matches."""
    print('=' * 60)
    print('STAGE 2: Additional Cross-References')
    print('=' * 60)

    if not DEOBF_JSON_PATH.exists():
        print(f'  ERROR: {DEOBF_JSON_PATH} not found. Run stage 1 first.')
        return False

    print(f'\n  Loading deobfuscated dump ...')
    with open(DEOBF_JSON_PATH, 'r', encoding='utf-8') as f:
        deobf_data = json.load(f)

    # Load existing name mapping
    mapping = {}
    if NAME_MAPPING_PATH.exists():
        with open(NAME_MAPPING_PATH, 'r', encoding='utf-8') as f:
            mapping = json.load(f)

    class_map = mapping.get('classes', {})
    reverse_map = mapping.get('reverse_classes', {})
    updates = 0

    # Build O(1) lookup indices once — eliminates O(n²) in all sub-functions
    orig_index = {}   # original_name -> cls dict
    name_index = {}   # current cls['name'] -> cls dict
    for ns, classes in deobf_data.get('namespaces', {}).items():
        for cls in classes:
            orig = cls.get('original_name', '')
            if orig:
                orig_index[orig] = cls
            name_index[cls['name']] = cls
    print(f'  Built class index: {len(orig_index)} renamed, {len(name_index)} total')

    # ── 2a. Photon Protocol Names ─────────────────────────────────────
    photon_path = OUTPUT_DIR / 'photon_protocol_analysis.md'
    if photon_path.exists():
        print(f'\n  [2a] Applying Photon protocol cross-references ...')
        updates += _apply_photon_xrefs(deobf_data, class_map, photon_path, orig_index)
    else:
        print(f'\n  [2a] photon_protocol_analysis.md - NOT FOUND (skipping)')

    # ── 2b. Structural Match Overrides ────────────────────────────────
    if STRUCTURAL_PATH.exists():
        print(f'\n  [2b] Applying structural match overrides ...')
        updates += _apply_structural_matches(deobf_data, class_map, orig_index)
    else:
        print(f'\n  [2b] structural_matches.json - NOT FOUND (skipping)')

    # ── 2c. Community Name Mapping ────────────────────────────────────
    if COMMUNITY_MAP_PATH.exists():
        print(f'\n  [2c] Applying community name mappings ...')
        updates += _apply_community_mappings(deobf_data, class_map, orig_index, name_index)
    else:
        print(f'\n  [2c] community_name_mapping.json - NOT FOUND (skipping)')

    # ── 2d. Additional Names from Source Analysis ─────────────────────
    if ADDITIONAL_PATH.exists():
        print(f'\n  [2d] Applying additional source-analysis names ...')
        updates += _apply_additional_names(deobf_data, class_map, orig_index)
    else:
        print(f'\n  [2d] additional_names.json - NOT FOUND (skipping)')

    # ── Save Updated Outputs ──────────────────────────────────────────
    if updates > 0:
        print(f'\n  Saving {updates} cross-reference updates ...')

        with open(DEOBF_JSON_PATH, 'w', encoding='utf-8') as f:
            json.dump(deobf_data, f, indent=2, ensure_ascii=False)

        # Update name mapping
        mapping['classes'] = class_map
        mapping['reverse_classes'] = {v: k for k, v in class_map.items()}
        with open(NAME_MAPPING_PATH, 'w', encoding='utf-8') as f:
            json.dump(mapping, f, indent=2, ensure_ascii=False)

        print(f'    Updated: {DEOBF_JSON_PATH.name}, {NAME_MAPPING_PATH.name}')
    else:
        print(f'\n  No new cross-reference updates to apply.')

    print(f'\n  --- Stage 2 Summary ---')
    print(f'  Cross-reference updates: {updates}')
    print()
    return True


def _apply_photon_xrefs(deobf_data: dict, class_map: dict, photon_path: Path, orig_index: dict) -> int:
    """Extract Photon-related names from protocol analysis and apply them."""
    updates = 0

    with open(photon_path, 'r', encoding='utf-8') as f:
        content = f.read()

    photon_classes = set()
    for m in re.finditer(r'`(\w+(?:Handler|Manager|Controller|Serializer|Event|RPC)\w*)`', content):
        photon_classes.add(m.group(1))

    photon_methods = set()
    for m in re.finditer(r'`(On\w+|Send\w+|Receive\w+|Handle\w+|Process\w+)`', content):
        photon_methods.add(m.group(1))

    photon_indicators = frozenset({
        'OnPhotonSerializeView', 'OnJoinedRoom', 'OnLeftRoom',
        'OnPlayerEnteredRoom', 'OnPlayerLeftRoom',
        'OnMasterClientSwitched', 'OnConnectedToMaster',
        'OnCreatedRoom', 'OnRoomListUpdate',
    })

    for original, cls in orig_index.items():
        name = cls['name']
        if not _is_weak_name(name):
            continue
        methods = set(m for m in cls.get('methods', []) if isinstance(m, str))
        overlap = methods.intersection(photon_indicators)
        if not overlap:
            continue
        if len(overlap) >= 3:
            new_name = f'PhotonNetworkHandler_{hashlib.sha256(original.encode()).hexdigest()[:4].upper()}'
        elif 'OnPhotonSerializeView' in overlap:
            new_name = f'PhotonSerializable_{hashlib.sha256(original.encode()).hexdigest()[:4].upper()}'
        else:
            new_name = f'PhotonCallback_{hashlib.sha256(original.encode()).hexdigest()[:4].upper()}'
        cls['name'] = new_name
        class_map[original] = new_name
        updates += 1

    print(f'    Photon protocol: {updates} classes updated')
    print(f'    Found {len(photon_classes)} Photon class references, {len(photon_methods)} method references in analysis')
    return updates


def _apply_structural_matches(deobf_data: dict, class_map: dict, orig_index: dict) -> int:
    """Apply high-confidence structural matches from structural_matcher.py."""
    updates = 0

    with open(STRUCTURAL_PATH, 'r', encoding='utf-8') as f:
        structural = json.load(f)

    matches = structural.get('matches', {})
    for obf_name, match_info in matches.items():
        if isinstance(match_info, dict):
            real_name = match_info.get('real_name', match_info.get('name', ''))
            confidence = match_info.get('confidence', 0)
        elif isinstance(match_info, str):
            real_name = match_info
            confidence = 70
        else:
            continue

        if not real_name or confidence < 70:
            continue

        cls = orig_index.get(obf_name)
        if cls and _is_weak_name(cls['name']):
            cls['name'] = real_name
            class_map[obf_name] = real_name
            updates += 1

    print(f'    Structural matches: {updates} classes updated')
    return updates


def _apply_community_mappings(deobf_data: dict, class_map: dict, orig_index: dict, name_index: dict) -> int:
    """Apply community deobfuscation map matches."""
    updates = 0

    with open(COMMUNITY_MAP_PATH, 'r', encoding='utf-8') as f:
        comm = json.load(f)

    direct = comm.get('direct_matches', {})
    for obf_sig, real_name in direct.items():
        if not real_name or not isinstance(real_name, str):
            continue

        cls = orig_index.get(obf_sig) or name_index.get(obf_sig)
        if cls and _is_weak_name(cls['name']):
            original = cls.get('original_name', '') or obf_sig
            cls['name'] = real_name
            class_map[original] = real_name
            updates += 1

    print(f'    Community mappings: {updates} classes updated')
    return updates


def _apply_additional_names(deobf_data: dict, class_map: dict, orig_index: dict) -> int:
    """Apply names discovered from source code analysis."""
    updates = 0

    with open(ADDITIONAL_PATH, 'r', encoding='utf-8') as f:
        additional = json.load(f)

    type_rules = additional.get('type_rules', {})
    if not isinstance(type_rules, dict):
        print(f'    Additional names: 0 classes updated')
        return 0

    # Build method-set index for O(1) subset checks
    candidates = []
    for original, cls in orig_index.items():
        if not _is_weak_name(cls['name']):
            continue
        methods = frozenset(m for m in cls.get('methods', []) if isinstance(m, str))
        candidates.append((original, cls, methods))

    for rule_name, rule_info in type_rules.items():
        if not isinstance(rule_info, dict):
            continue
        target_methods = rule_info.get('methods', [])
        target_real_name = rule_info.get('name', rule_name)
        if not target_methods:
            continue
        target_set = set(target_methods)
        for original, cls, methods in candidates:
            if target_set.issubset(methods):
                cls['name'] = target_real_name
                class_map[original] = target_real_name
                updates += 1
                break

    print(f'    Additional names: {updates} classes updated')
    return updates


def _is_weak_name(name: str) -> bool:
    """Check if a deobfuscated name is a weak/fallback name that should be overridden."""
    weak_prefixes = (
        'Obf_', 'Type', 'Struct', 'Mono', 'Service', 'Major', 'Static',
        'DataOnly', 'EmptyType', 'EmptyStruct', 'EmptyClass', 'Record',
        'Unknown', 'LargeClass', 'Class_',
    )
    # Also check for purely structural names like "Type42m5f_ABCD"
    if re.match(r'^(Type|Struct|Mono|Service|Major|Static)\d+[mf]', name):
        return True
    return name.startswith(weak_prefixes)


# ══════════════════════════════════════════════════════════════════════
#  STAGE 3: Generate Outputs
# ══════════════════════════════════════════════════════════════════════

PREV_DUMP_HASH_PATH = OUTPUT_DIR / '.prev_deobf_hash.json'


def stage3_generate_outputs():
    """Regenerate source tree and coverage report from deobfuscated dump.
    Supports delta regeneration: only rewrites .cs files whose class data changed."""
    print('=' * 60)
    print('STAGE 3: Generate Outputs')
    print('=' * 60)

    if not DEOBF_JSON_PATH.exists():
        print(f'  ERROR: {DEOBF_JSON_PATH} not found. Run stages 1-2 first.')
        return False

    # ── 3a. Delta Source Tree ─────────────────────────────────────────
    print(f'\n  [3a] Regenerating source tree (delta mode) ...')
    try:
        _delta_source_tree()
    except Exception as e:
        print(f'    ERROR generating source tree: {e}')
        print(f'    Falling back to full regeneration ...')
        try:
            sys.path.insert(0, str(TOOLS_DIR))
            import generate_source_tree as gen_src
            gen_src.INPUT_PATH = DEOBF_JSON_PATH
            gen_src.OUTPUT_DIR = SRC_DIR
            gen_src.main()
            print(f'    Source tree generated at: {SRC_DIR}')
        except Exception as e2:
            print(f'    ERROR: {e2}')
            print(f'    You can run it manually: python tools/generate_source_tree.py')

    # ── 3b. Generate Coverage Report ──────────────────────────────────
    print(f'\n  [3b] Generating coverage report ...')
    _generate_coverage_report()

    print(f'\n  Stage 3 complete.')
    return True


def _delta_source_tree():
    """Delta source tree: only regenerate .cs files for classes that changed."""
    sys.path.insert(0, str(TOOLS_DIR))
    import generate_source_tree as gen_src

    gen_src.INPUT_PATH = DEOBF_JSON_PATH
    gen_src.OUTPUT_DIR = SRC_DIR

    # Load current dump
    with open(DEOBF_JSON_PATH, 'r', encoding='utf-8') as f:
        data = json.load(f)

    # Build per-class fingerprint from key structural fields (fast path)
    current_fingerprints = {}
    for ns, classes in data.get('namespaces', {}).items():
        for cls in classes:
            key = f'{ns}::{cls["name"]}'
            methods = cls.get('methods', [])
            fields = cls.get('fields', [])
            fp_parts = [cls['name'], cls.get('parent', ''), str(len(methods)), str(len(fields))]
            fp_parts.extend(methods[:10])
            fp_parts.extend(str(f) for f in fields[:5])
            fp_str = '|'.join(fp_parts)
            current_fingerprints[key] = hashlib.md5(fp_str.encode('utf-8')).hexdigest()

    # Load previous fingerprints
    prev_fingerprints = {}
    if PREV_DUMP_HASH_PATH.exists():
        try:
            with open(PREV_DUMP_HASH_PATH, 'r', encoding='utf-8') as f:
                prev_data = json.load(f)
                prev_fingerprints = prev_data.get('class_fingerprints', {})
        except (json.JSONDecodeError, OSError):
            pass

    # If no previous data or src/ doesn't exist, do full regeneration
    if not prev_fingerprints or not SRC_DIR.exists():
        print(f'    No previous fingerprints or src/ missing, full regeneration ...')
        gen_src.main()
        # Save fingerprints for next run
        _save_class_fingerprints(current_fingerprints)
        return

    # Compute delta
    changed_classes = set()
    new_classes = set()
    removed_classes = set()

    for key, fp in current_fingerprints.items():
        if key not in prev_fingerprints:
            new_classes.add(key)
        elif prev_fingerprints[key] != fp:
            changed_classes.add(key)

    for key in prev_fingerprints:
        if key not in current_fingerprints:
            removed_classes.add(key)

    total = len(current_fingerprints)
    unchanged = total - len(changed_classes) - len(new_classes)

    if not changed_classes and not new_classes and not removed_classes:
        print(f'    All {total} classes unchanged, source tree up to date.')
        _save_class_fingerprints(current_fingerprints)
        return

    print(f'    Delta: {len(changed_classes)} changed, {len(new_classes)} new, {len(removed_classes)} removed, {unchanged} unchanged')

    # For delta, we need to know which .cs files contain affected classes.
    # Since generate_source_tree groups by domain, it's simplest to:
    # 1. Collect affected class names
    # 2. Re-classify them to find which domain/file they land in
    # 3. Regenerate just those files

    affected_keys = changed_classes | new_classes
    affected_domains = set()

    # We need to re-classify to determine which domain files to regenerate
    import collections as _coll
    domain_classes_all = _coll.defaultdict(list)
    for ns, classes in data['namespaces'].items():
        for cls in classes:
            key = f'{ns}::{cls["name"]}'
            if cls.get('original_name'):
                domain = gen_src.classify_renamed_class(cls)
            else:
                domain = gen_src.classify_existing_namespace(ns)
            domain_classes_all[domain].append(cls)
            if key in affected_keys:
                affected_domains.add(domain)

    # For removed classes, mark all existing domains as needing regen
    # (removed classes no longer exist in data, so we can't classify them —
    # but since we regen the full domain file, the class simply disappears)
    if removed_classes:
        # Use prev fingerprints to find which domains were affected
        # The domain_classes_all already has the current state; removed classes
        # won't be in it. Just mark all domains for a cleanup pass.
        for key in removed_classes:
            ns_part = key.split('::', 1)[0] if '::' in key else ''
            if ns_part:
                for domain in domain_classes_all:
                    if ns_part in domain:
                        affected_domains.add(domain)
                        break

    # Regenerate affected domain files
    MAX_PER_FILE = 100
    regen_count = 0
    for domain in sorted(affected_domains):
        classes = domain_classes_all.get(domain, [])
        domain_path = domain.replace('.', '/')
        domain_dir = SRC_DIR / domain_path

        # Remove existing files in this domain dir
        if domain_dir.exists():
            for f in domain_dir.glob('*.cs'):
                f.unlink()

        if not classes:
            # Domain is now empty, clean up directory
            if domain_dir.exists():
                try:
                    domain_dir.rmdir()
                except OSError:
                    pass
            continue

        if len(classes) <= MAX_PER_FILE:
            filename = domain.rsplit('.', 1)[-1] + '.cs'
            filepath = domain_dir / filename
            gen_src.write_cs_file(filepath, domain, classes)
            regen_count += 1
        else:
            sub_groups = _coll.defaultdict(list)
            for cls in classes:
                first = cls['name'][0].upper()
                if not first.isalpha():
                    first = '_Special'
                sub_groups[first].append(cls)

            for group_key, group_classes in sorted(sub_groups.items()):
                if len(group_classes) > MAX_PER_FILE:
                    for i in range(0, len(group_classes), MAX_PER_FILE):
                        chunk = group_classes[i:i + MAX_PER_FILE]
                        suffix = f'_{i // MAX_PER_FILE + 1}' if i > 0 else ''
                        filename = f'{group_key}{suffix}.cs'
                        filepath = domain_dir / filename
                        gen_src.write_cs_file(filepath, domain, chunk)
                        regen_count += 1
                else:
                    filename = f'{group_key}.cs'
                    filepath = domain_dir / filename
                    gen_src.write_cs_file(filepath, domain, group_classes)
                    regen_count += 1

    # Clean up empty directories
    if removed_classes:
        for d in sorted(SRC_DIR.rglob('*'), reverse=True):
            if d.is_dir() and not any(d.iterdir()):
                try:
                    d.rmdir()
                except OSError:
                    pass

    total_files = len(list(SRC_DIR.rglob('*.cs'))) if SRC_DIR.exists() else 0
    print(f'    Regenerated {regen_count} domain files ({len(affected_domains)} domains affected)')
    print(f'    Total source files: {total_files} ({unchanged} classes unchanged)')

    # Save fingerprints for next run
    _save_class_fingerprints(current_fingerprints)


def _save_class_fingerprints(fingerprints: dict):
    """Save class fingerprints for delta comparison on next run."""
    data = {
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'total_classes': len(fingerprints),
        'class_fingerprints': fingerprints,
    }
    with open(PREV_DUMP_HASH_PATH, 'w', encoding='utf-8') as f:
        json.dump(data, f, ensure_ascii=False)


def _generate_coverage_report():
    """Generate a detailed coverage report showing deobfuscation quality."""
    with open(DEOBF_JSON_PATH, 'r', encoding='utf-8') as f:
        data = json.load(f)

    total_classes = 0
    renamed_classes = 0
    semantic_classes = 0
    fallback_classes = 0
    total_methods = 0
    renamed_methods = 0
    total_fields = 0
    renamed_fields = 0
    domain_counts = collections.Counter()

    for ns, classes in data.get('namespaces', {}).items():
        for cls in classes:
            total_classes += 1
            original = cls.get('original_name', '')
            name = cls['name']

            if original:  # was renamed
                renamed_classes += 1
                if _is_weak_name(name):
                    fallback_classes += 1
                else:
                    semantic_classes += 1

            methods = cls.get('methods', [])
            total_methods += len(methods)
            for m in methods:
                if isinstance(m, str) and m.startswith(('m_', 'f_')):
                    renamed_methods += 1

            fields = cls.get('fields', [])
            total_fields += len(fields)
            for f in fields:
                if isinstance(f, str) and f.startswith('f_'):
                    renamed_fields += 1
                elif isinstance(f, dict) and f.get('original_name'):
                    renamed_fields += 1

    pct_semantic = (100.0 * semantic_classes / renamed_classes) if renamed_classes > 0 else 0
    pct_total = (100.0 * renamed_classes / total_classes) if total_classes > 0 else 0

    report_path = OUTPUT_DIR / 'pipeline_coverage_report.md'
    lines = [
        '# VRChat IL2CPP Pipeline Coverage Report',
        f'Generated: {time.strftime("%Y-%m-%d %H:%M:%S")}',
        '',
        '## Overall Coverage',
        '',
        '| Metric | Count | Percentage |',
        '|--------|-------|------------|',
        f'| Total classes | {total_classes:,} | - |',
        f'| Renamed (obfuscated) | {renamed_classes:,} | {pct_total:.1f}% of total |',
        f'| Semantic names | {semantic_classes:,} | {pct_semantic:.1f}% of renamed |',
        f'| Fallback names | {fallback_classes:,} | {100-pct_semantic:.1f}% of renamed |',
        f'| Total methods | {total_methods:,} | - |',
        f'| Renamed methods | {renamed_methods:,} | - |',
        f'| Total fields | {total_fields:,} | - |',
        f'| Renamed fields | {renamed_fields:,} | - |',
        '',
        '## Quality Metrics',
        '',
        f'- **Semantic naming rate**: {pct_semantic:.1f}%',
        f'- Classes with meaningful names that reveal purpose: {semantic_classes:,}',
        f'- Classes with only structural/hash names: {fallback_classes:,}',
        '',
        '## Output Files',
        '',
        f'- `{DEOBF_JSON_PATH.name}` - Full deobfuscated dump (JSON)',
        f'- `{DEOBF_CS_PATH.name}` - C# stub file',
        f'- `{NAME_MAPPING_PATH.name}` - Name mapping (obf -> deobf)',
        f'- `src/` - Source tree ({SRC_DIR})',
        '',
    ]

    with open(report_path, 'w', encoding='utf-8') as f:
        f.write('\n'.join(lines))

    print(f'\n  --- Coverage Summary ---')
    print(f'  Total classes:     {total_classes:,}')
    print(f'  Renamed:           {renamed_classes:,} ({pct_total:.1f}%)')
    print(f'  Semantic names:    {semantic_classes:,} ({pct_semantic:.1f}%)')
    print(f'  Fallback names:    {fallback_classes:,}')
    print(f'  Report saved to:   {report_path}')


# ══════════════════════════════════════════════════════════════════════
#  STAGE 4: IDA Script Pointers
# ══════════════════════════════════════════════════════════════════════

def stage4_ida_scripts():
    """Generate / point to IDA scripts for applying deobfuscation in IDA Pro."""
    print('=' * 60)
    print('STAGE 4: IDA Script Generation')
    print('=' * 60)

    # Check for existing IDA database
    ida_db = IDA_DIR / 'ga_analysis.i64'
    if ida_db.exists():
        size_mb = ida_db.stat().st_size / 1024 / 1024
        print(f'\n  IDA database found: {ida_db} ({size_mb:.0f} MB)')
    else:
        print(f'\n  No IDA database found at {ida_db}')

    # Check for IDA extract script
    ida_script = TOOLS_DIR / 'ida_extract.py'
    if ida_script.exists():
        print(f'  IDA extract script: {ida_script}')
    else:
        print(f'  WARNING: ida_extract.py not found in tools/')

    # Generate an IDA rename script from the name mapping
    if NAME_MAPPING_PATH.exists():
        print(f'\n  Generating IDA rename script from name mapping ...')
        _generate_ida_rename_script()
    else:
        print(f'\n  No name_mapping.json found, skipping IDA script generation.')

    # Print usage instructions
    print(f'\n  --- IDA Usage ---')
    print(f'  1. Headless analysis (already done if ida/ has .i64):')
    print(f'     idat64.exe -A -S"tools/ida_extract.py" GameAssembly.dll')
    print(f'')
    print(f'  2. Apply rename script in IDA:')
    ida_rename = OUTPUT_DIR / 'ida_apply_names.py'
    if ida_rename.exists():
        print(f'     File -> Script File -> {ida_rename}')
    else:
        print(f'     (script will be at {ida_rename} after generation)')
    print(f'')
    print(f'  3. Monitor IDA progress:')
    print(f'     python tools/wait_ida.py')
    print()
    return True


def _generate_ida_rename_script():
    """Generate an IDAPython script that renames functions based on our name mapping."""
    with open(NAME_MAPPING_PATH, 'r', encoding='utf-8') as f:
        mapping = json.load(f)

    # We need method_pointers to map method names to RVA addresses
    # Load from deobfuscated dump
    rva_to_name = {}
    if DEOBF_JSON_PATH.exists():
        with open(DEOBF_JSON_PATH, 'r', encoding='utf-8') as f:
            deobf = json.load(f)

        for ns, classes in deobf.get('namespaces', {}).items():
            for cls in classes:
                class_name = cls['name']
                ptrs = cls.get('method_pointers', {})
                for method_name, ptr_str in ptrs.items():
                    if ptr_str and isinstance(ptr_str, str):
                        try:
                            rva = int(ptr_str, 16) if ptr_str.startswith('0x') else int(ptr_str)
                            full_name = f'{class_name}::{method_name}'
                            # IDA has a 512 char limit for names
                            if len(full_name) < 500:
                                rva_to_name[rva] = full_name
                        except (ValueError, TypeError):
                            pass

    if not rva_to_name:
        print(f'    No RVA -> name mappings found, skipping.')
        return

    ida_script_path = OUTPUT_DIR / 'ida_apply_names.py'
    lines = [
        '"""',
        'IDAPython script to apply VRChat deobfuscated names.',
        f'Generated by run_full_pipeline.py on {time.strftime("%Y-%m-%d %H:%M:%S")}',
        f'Total rename entries: {len(rva_to_name)}',
        '',
        'Usage: In IDA, File -> Script File -> select this file',
        '"""',
        '',
        'import idc',
        'import idaapi',
        '',
        'print("[*] Applying VRChat deobfuscated names...")',
        '',
        f'DLL_BASE = idaapi.get_imagebase()',
        '',
        '# RVA -> deobfuscated name',
        'RENAMES = {',
    ]

    for rva, name in sorted(rva_to_name.items()):
        # Sanitize for IDA: replace :: with __ and remove invalid chars
        ida_name = name.replace('::', '__').replace('<', '_').replace('>', '_')
        ida_name = re.sub(r'[^A-Za-z0-9_]', '_', ida_name)
        lines.append(f'    0x{rva:X}: "{ida_name}",')

    lines.extend([
        '}',
        '',
        'renamed = 0',
        'for rva, name in RENAMES.items():',
        '    ea = DLL_BASE + rva',
        '    if idc.set_name(ea, name, idc.SN_NOWARN | idc.SN_FORCE):',
        '        renamed += 1',
        '',
        f'print(f"[*] Renamed {{renamed}}/{len(rva_to_name)} functions")',
        'print("[*] Done!")',
    ])

    with open(ida_script_path, 'w', encoding='utf-8') as f:
        f.write('\n'.join(lines))

    print(f'    Generated: {ida_script_path}')
    print(f'    Contains {len(rva_to_name):,} function renames')


# ══════════════════════════════════════════════════════════════════════
#  STAGE 5: Extract + Merge Field Types (requires VRChat running)
# ══════════════════════════════════════════════════════════════════════

FIELD_TYPES_PATH = OUTPUT_DIR / 'field_types.json'

def stage5_field_types():
    """Extract runtime field types via Frida and merge into deobfuscated dump."""
    import subprocess

    print('=' * 60)
    print('STAGE 5: Field Type Extraction + Merge')
    print('=' * 60)

    # Step 1: Extract field types (requires VRChat.exe running)
    print('\n  [5a] Extracting field types via Frida ...')
    extract_script = TOOLS_DIR / 'extract_field_types_v2.py'
    if not extract_script.exists():
        print('    ERROR: extract_field_types_v2.py not found')
        return False

    result = subprocess.run(
        [sys.executable, str(extract_script)],
        capture_output=True, text=True, encoding='utf-8', errors='replace',
        cwd=str(BASE_DIR)
    )
    if result.returncode != 0:
        print('    ERROR: Field type extraction failed:')
        # Show last few lines of stderr
        for line in (result.stderr or result.stdout or '').strip().split('\n')[-5:]:
            print('      ' + line)
        return False

    # Show extraction summary
    for line in (result.stdout or '').strip().split('\n')[-5:]:
        print('    ' + line)

    # Step 2: Merge field types into deobfuscated dump
    print('\n  [5b] Merging field types into deobfuscated dump ...')
    merge_script = TOOLS_DIR / 'merge_field_types.py'
    if not merge_script.exists():
        print('    ERROR: merge_field_types.py not found')
        return False

    result = subprocess.run(
        [sys.executable, str(merge_script)],
        capture_output=True, text=True, encoding='utf-8', errors='replace',
        cwd=str(BASE_DIR)
    )
    if result.returncode != 0:
        print('    ERROR: Merge failed:')
        for line in (result.stderr or result.stdout or '').strip().split('\n')[-5:]:
            print('      ' + line)
        return False

    for line in (result.stdout or '').strip().split('\n')[-8:]:
        print('    ' + line)

    # Step 3: Regenerate source tree with new types
    print('\n  [5c] Regenerating source tree ...')
    gen_script = TOOLS_DIR / 'generate_source_tree.py'
    if gen_script.exists():
        result = subprocess.run(
            [sys.executable, str(gen_script)],
            capture_output=True, text=True, encoding='utf-8', errors='replace',
            cwd=str(BASE_DIR)
        )
        if result.returncode == 0:
            # Count output files
            src_dir = OUTPUT_DIR / 'src'
            if src_dir.exists():
                cs_files = list(src_dir.rglob('*.cs'))
                print(f'    Source tree: {len(cs_files)} C# files')
        else:
            print('    WARNING: Source tree generation had issues')

    print()
    return True


# ══════════════════════════════════════════════════════════════════════
#  MAIN
# ══════════════════════════════════════════════════════════════════════

def main():
    parser = argparse.ArgumentParser(
        description='VRChat IL2CPP Full Deobfuscation Pipeline',
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  python tools/run_full_pipeline.py                  # full pipeline (all stages)
  python tools/run_full_pipeline.py --skip-binary     # skip heavy binary analysis
  python tools/run_full_pipeline.py --stage 0         # only merge vocabularies
  python tools/run_full_pipeline.py --stage 0,1       # merge + deobfuscate
  python tools/run_full_pipeline.py --stage 3         # regenerate source tree only
  python tools/run_full_pipeline.py --dry-run         # show what would run
  python tools/run_full_pipeline.py --force            # ignore cache, re-run everything
  python tools/run_full_pipeline.py --check            # show which stages would run vs skip

Stages:
  0 - Gather all name sources into unified vocabulary
  1 - Run main 8-phase deobfuscation pipeline
  2 - Apply additional cross-references (Photon, structural, community)
  3 - Generate outputs (source tree, coverage report)
  4 - Generate IDA scripts
  5 - Extract + merge field types (requires VRChat.exe --no-vr running)
        """
    )
    parser.add_argument('--stage', type=str, default=None,
                        help='Comma-separated stage numbers to run (e.g., 0,1,3)')
    parser.add_argument('--skip-binary', action='store_true',
                        help='Skip binary analysis stages (faster)')
    parser.add_argument('--dry-run', action='store_true',
                        help='Show what would be run without executing')
    parser.add_argument('--force', action='store_true',
                        help='Bypass incremental cache, re-run all requested stages')
    parser.add_argument('--check', action='store_true',
                        help='Show which stages would run vs skip (no execution)')

    args = parser.parse_args()

    # Determine which stages to run
    if args.stage is not None:
        stages = set(int(s.strip()) for s in args.stage.split(','))
    else:
        stages = {0, 1, 2, 3, 4}  # stage 5 requires VRChat running, opt-in only

    cache = load_cache()
    start_time = time.time()

    print()
    print('=' * 60)
    print('  VRChat IL2CPP Full Deobfuscation Pipeline')
    print('=' * 60)
    print(f'  Base directory:  {BASE_DIR}')
    print(f'  Stages to run:   {sorted(stages)}')
    print(f'  Skip binary:     {args.skip_binary}')
    print(f'  Force (no cache): {args.force}')
    print()

    # Check prerequisites
    if not BASE_DIR.exists():
        print(f'ERROR: Base directory not found: {BASE_DIR}')
        sys.exit(1)

    stage_labels = {
        0: 'Gather all name sources into unified vocabulary',
        1: 'Run main 8-phase deobfuscation pipeline',
        2: 'Apply additional cross-references',
        3: 'Generate outputs (source tree, coverage report)',
        4: 'Generate IDA scripts',
        5: 'Extract + merge field types (requires VRChat running)',
    }

    # ── --check mode: show what would run vs skip ─────────────────────
    if args.check:
        print('CACHE CHECK - showing which stages would run:')
        for s in sorted(stages):
            can_skip = check_stage_cache(s, cache, force=args.force)
            cached_info = cache.get(f'stage_{s}', {})
            ts = cached_info.get('timestamp', '')
            if can_skip:
                inputs = STAGE_INPUTS.get(s, [])
                existing = sum(1 for p in inputs if p.exists())
                print(f'  Stage {s}: \u23ed SKIP ({existing} inputs unchanged, cached {ts})')
            else:
                reason = ''
                if not cached_info.get('completed'):
                    reason = ' (no cache)'
                elif args.force:
                    reason = ' (--force)'
                else:
                    reason = ' (inputs changed)'
                print(f'  Stage {s}: \u25b6 RUN{reason} - {stage_labels.get(s, "Unknown")}')
        sys.exit(0)

    if args.dry_run:
        print('DRY RUN - showing planned stages:')
        for s in sorted(stages):
            skip = ''
            if s == 1 and not PRECISE_DUMP.exists():
                skip = ' [WOULD SKIP: no precise_dump.json]'
            can_skip = check_stage_cache(s, cache, force=args.force)
            if can_skip:
                skip = ' [WOULD SKIP: cached]'
            print(f'  Stage {s}: {stage_labels.get(s, "Unknown")}{skip}')
        sys.exit(0)

    results = {}
    skipped = {}
    unified_vocab = None

    # ── Stage 0 ───────────────────────────────────────────────────────
    if 0 in stages:
        if check_stage_cache(0, cache, force=args.force):
            print_skip_message(0, cache)
            skipped[0] = True
            # Load existing unified vocab for stage 1
            if UNIFIED_VOCAB_PATH.exists():
                with open(UNIFIED_VOCAB_PATH, 'r', encoding='utf-8') as f:
                    unified_vocab = json.load(f)
        else:
            unified_vocab, ok = stage0_gather_vocabulary()
            results[0] = ok
            if ok:
                record_stage_cache(cache, 0)

    # ── Stage 1 ───────────────────────────────────────────────────────
    if 1 in stages:
        if check_stage_cache(1, cache, force=args.force):
            print_skip_message(1, cache)
            skipped[1] = True
        else:
            results[1] = stage1_deobfuscate(unified_vocab)
            if results[1]:
                record_stage_cache(cache, 1)

    # ── Stage 2 ───────────────────────────────────────────────────────
    if 2 in stages:
        if check_stage_cache(2, cache, force=args.force):
            print_skip_message(2, cache)
            skipped[2] = True
        else:
            results[2] = stage2_cross_references()
            if results[2]:
                record_stage_cache(cache, 2)

    # ── Stage 3 ───────────────────────────────────────────────────────
    if 3 in stages:
        if check_stage_cache(3, cache, force=args.force):
            print_skip_message(3, cache)
            skipped[3] = True
        else:
            results[3] = stage3_generate_outputs()
            if results[3]:
                record_stage_cache(cache, 3)

    # ── Stage 4 ───────────────────────────────────────────────────────
    if 4 in stages:
        if check_stage_cache(4, cache, force=args.force):
            print_skip_message(4, cache)
            skipped[4] = True
        else:
            results[4] = stage4_ida_scripts()
            if results[4]:
                record_stage_cache(cache, 4)

    # ── Stage 5 (opt-in) ─────────────────────────────────────────────
    if 5 in stages:
        results[5] = stage5_field_types()

    # ── Final Summary ─────────────────────────────────────────────────
    elapsed = time.time() - start_time
    print()
    print('=' * 60)
    print('  PIPELINE COMPLETE')
    print('=' * 60)
    print(f'  Time elapsed:  {elapsed:.1f}s')
    print(f'  Stages run:    {len(results)}, skipped: {len(skipped)}')
    for s in sorted(set(list(results.keys()) + list(skipped.keys()))):
        if s in skipped:
            print(f'    Stage {s}: SKIPPED (cached)')
        elif s in results:
            status = 'OK' if results[s] else 'FAILED'
            print(f'    Stage {s}: {status}')
    print()

    # Show key output files
    print('  Key output files:')
    for path in [UNIFIED_VOCAB_PATH, DEOBF_JSON_PATH, DEOBF_CS_PATH,
                 NAME_MAPPING_PATH, OUTPUT_DIR / 'pipeline_coverage_report.md',
                 OUTPUT_DIR / 'ida_apply_names.py']:
        if path.exists():
            size = path.stat().st_size
            if size > 1024 * 1024:
                print(f'    {path.name:40s} {size/1024/1024:.1f} MB')
            else:
                print(f'    {path.name:40s} {size/1024:.1f} KB')
    print()


if __name__ == '__main__':
    main()
