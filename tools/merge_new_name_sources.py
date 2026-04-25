#!/usr/bin/env python3
"""
Merge all NEW name sources into cross_version_method_names.json.

Sources (all optional — merged if present):
- output/new_internal_body_propagation.json       (Codex A: self body hash)
- output/cross_version_body_fuzzy.json            (Codex B: fuzzy old->new)
- output/signature_pattern_predictions.json       (Codex D: Unity builtin patterns)
- output/v_new_ida/ida_method_string_names.json   (IDA NEW extract if done)
- output/v_new_ida/callgraph_method_names.json    (IDA NEW extract if done)
- output/llm_strong_class_names.json              (earlier codex heuristic)
- output/ida_method_string_names_native.json      (native pefile+capstone)
- output/callgraph_method_names_native.json       (native E8 callgraph)

All keys must be 'SemanticClass::m_XXX' format.
For native files with 'ClassObf::MethodObf' format, we convert via name_mapping.
"""

import json
import re
import sys
import hashlib
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE = Path(__file__).resolve().parent.parent

HASH_METHOD_RE = re.compile(r'^m_[0-9A-F]{3}$')
TRIVIAL_NAMES = frozenset({
    '.ctor', '.cctor', 'Finalize', 'ToString', 'GetHashCode', 'Equals',
    'GetType', 'MemberwiseClone', 'Dispose',
    'Invoke', 'BeginInvoke', 'EndInvoke',
    'MoveNext', 'Reset', 'Current',
    'get_Current', 'get_IsCompleted',
})


def stable_hash(name: str, length: int = 3) -> str:
    return hashlib.sha256(name.encode('utf-8')).hexdigest()[:length].upper()


def is_valid_key(key: str) -> bool:
    parts = key.split('::')
    if len(parts) != 2:
        return False
    cls, method = parts
    if not cls or not method.startswith('m_'):
        return False
    if not HASH_METHOD_RE.match(method):
        return False
    return True


def is_trivial(name: str) -> bool:
    return not name or name in TRIVIAL_NAMES or name.startswith('op_') or HASH_METHOD_RE.match(name)


def load_if_exists(p: Path) -> dict:
    if not p.exists():
        return {}
    try:
        with open(p, 'r', encoding='utf-8') as f:
            d = json.load(f)
        if not isinstance(d, dict):
            return {}
        return d
    except Exception as e:
        print(f'  [!] failed to load {p.name}: {e}')
        return {}


def normalize_entries(raw: dict, source: str) -> dict:
    """Normalize to {SemanticClass::m_XXX: name}. Drop invalid keys."""
    out = {}
    for k, v in raw.items():
        # Handle nested dict (signature pattern format)
        if isinstance(v, dict):
            name = v.get('name') or v.get('predicted')
        elif isinstance(v, str):
            name = v
        else:
            continue
        if not isinstance(name, str) or is_trivial(name):
            continue
        if not is_valid_key(k):
            # Try to convert obf-keyed entries (ClassObf::MethodObf)
            # Need name_mapping.json for reverse
            continue
        out[k] = name
    print(f'  [{source}] {len(raw)} raw -> {len(out)} valid')
    return out


def convert_obf_keyed(raw: dict, class_map: dict, source: str) -> dict:
    """Convert ClassObf::MethodObf -> SemanticClass::m_XXX."""
    out = {}
    skipped_no_class = 0
    skipped_trivial = 0
    for k, v in raw.items():
        if not isinstance(v, str) or is_trivial(v):
            skipped_trivial += 1
            continue
        parts = k.split('::', 1)
        if len(parts) != 2:
            continue
        cls_obf, m_obf = parts
        semantic = class_map.get(cls_obf)
        if not semantic:
            skipped_no_class += 1
            continue
        h = stable_hash(m_obf, 3)
        new_key = f'{semantic}::m_{h}'
        out[new_key] = v
    print(f'  [{source}] {len(raw)} -> {len(out)} converted '
          f'(skipped {skipped_no_class} no-class, {skipped_trivial} trivial)')
    return out


def main():
    out_path = BASE / 'output' / 'cross_version_method_names.json'
    existing = load_if_exists(out_path)
    print(f'Existing cross_version entries: {len(existing)}')

    nm_path = BASE / 'output' / 'name_mapping.json'
    nm = load_if_exists(nm_path)
    class_map = nm.get('classes', {}) if isinstance(nm, dict) else {}
    print(f'name_mapping classes: {len(class_map)}')

    stats = {'existing': len(existing)}
    added_total = 0

    sources_direct = [
        ('new_internal_body_propagation', 'output/new_internal_body_propagation.json'),
        ('cross_version_body_fuzzy',       'output/cross_version_body_fuzzy.json'),
        ('signature_pattern_predictions',  'output/signature_pattern_predictions.json'),
        ('cross_class_propagation',        'output/cross_class_propagation.json'),
        ('vtable_propagation',             'output/vtable_propagation.json'),
        ('property_pairs',                 'output/property_pairs.json'),
        ('vrc_main_deep_names',            'output/vrc_main_deep_names.json'),
        ('llm_names_chunk_000',            'output/llm_names_chunk_000.json'),
        ('llm_names_chunk_001',            'output/llm_names_chunk_001.json'),
        ('llm_all_chunk_000',              'output/llm_all_chunk_000.json'),
        ('llm_all_chunk_001',              'output/llm_all_chunk_001.json'),
        ('llm_all_chunk_002',              'output/llm_all_chunk_002.json'),
        ('llm_all_chunk_003',              'output/llm_all_chunk_003.json'),
        ('llm_all_chunk_004',              'output/llm_all_chunk_004.json'),
        ('llm_all_chunk_005',              'output/llm_all_chunk_005.json'),
        ('llm_all_chunk_006',              'output/llm_all_chunk_006.json'),
        ('llm_all_chunk_007',              'output/llm_all_chunk_007.json'),
        ('llm_all_chunk_008',              'output/llm_all_chunk_008.json'),
        ('llm_all_chunk_009',              'output/llm_all_chunk_009.json'),
        ('llm_all_chunk_010',              'output/llm_all_chunk_010.json'),
        ('llm_all_chunk_011',              'output/llm_all_chunk_011.json'),
        ('llm_all_chunk_012',              'output/llm_all_chunk_012.json'),
        ('llm_all_chunk_013',              'output/llm_all_chunk_013.json'),
        ('llm_all_chunk_014',              'output/llm_all_chunk_014.json'),
        ('llm_round2_chunk_000',           'output/llm_round2_chunk_000.json'),
        ('llm_round2_chunk_001',           'output/llm_round2_chunk_001.json'),
        ('llm_round2_chunk_002',           'output/llm_round2_chunk_002.json'),
        ('llm_round2_chunk_003',           'output/llm_round2_chunk_003.json'),
        ('llm_round2_chunk_004',           'output/llm_round2_chunk_004.json'),
        ('llm_round2_chunk_005',           'output/llm_round2_chunk_005.json'),
        ('llm_round2_chunk_006',           'output/llm_round2_chunk_006.json'),
        ('llm_round3_chunk_000',           'output/llm_round3_chunk_000.json'),
        ('llm_round3_chunk_001',           'output/llm_round3_chunk_001.json'),
        ('llm_round3_chunk_002',           'output/llm_round3_chunk_002.json'),
        ('llm_round3_chunk_003',           'output/llm_round3_chunk_003.json'),
        ('llm_round3_chunk_004',           'output/llm_round3_chunk_004.json'),
        ('llm_round3_chunk_005',           'output/llm_round3_chunk_005.json'),
        ('llm_round3_chunk_006',           'output/llm_round3_chunk_006.json'),
        ('llm_round3_chunk_007',           'output/llm_round3_chunk_007.json'),
        ('ida_strings_v2_names',           'output/ida_strings_v2_names.json'),
        ('field_based_names',              'output/field_based_names.json'),
        ('weak_class_renames_methods',     'output/weak_class_renames.json'),
        ('claude_index_propagation',       'output/claude_index_propagation.json'),
        ('claude_rule_names',              'output/claude_rule_names.json'),
        ('claude_string_id_names',         'output/claude_string_id_names.json'),
        ('old_new_index_match',            'output/old_new_index_match.json'),
        ('old_new_index_match_v2',         'output/old_new_index_match_v2.json'),
        ('old_new_vtable_names',           'output/old_new_vtable_names.json'),
        ('old_new_bigram_match',           'output/old_new_bigram_match.json'),
        ('old_new_window_match',           'output/old_new_window_match.json'),
        ('gemini_names_round2_000',        'output/gemini_names_round2_000.json'),
        ('vrc_main_position_match',        'output/vrc_main_position_match.json'),
        ('llm_final_chunk_000',            'output/llm_final_chunk_000.json'),
        ('llm_final_chunk_001',            'output/llm_final_chunk_001.json'),
        ('llm_final_chunk_002',            'output/llm_final_chunk_002.json'),
        ('llm_final_chunk_003',            'output/llm_final_chunk_003.json'),
        ('llm_final_chunk_004',            'output/llm_final_chunk_004.json'),
        ('llm_final_chunk_005',            'output/llm_final_chunk_005.json'),
        ('llm_final_chunk_006',            'output/llm_final_chunk_006.json'),
        ('llm_final_chunk_007',            'output/llm_final_chunk_007.json'),
        ('claude_manual_names',            'output/claude_manual_names.json'),
        ('claude_oldname_in_strings',      'output/claude_oldname_in_strings.json'),
        ('gemini_hexrays_000',             'output/gemini_hexrays_000.json'),
        ('gemini_hexrays_001',             'output/gemini_hexrays_001.json'),
        ('codex_hexrays_002',              'output/codex_hexrays_002.json'),
        ('codex_hexrays_003',              'output/codex_hexrays_003.json'),
        ('claude_hexrays_names',           'output/claude_hexrays_names.json'),
        ('llm_body_chunk_000',             'output/llm_body_chunk_000.json'),
        ('llm_body_chunk_001',             'output/llm_body_chunk_001.json'),
        ('llm_body_chunk_002',             'output/llm_body_chunk_002.json'),
        ('llm_body_chunk_003',             'output/llm_body_chunk_003.json'),
        ('llm_body_chunk_004',             'output/llm_body_chunk_004.json'),
        ('llm_body_chunk_005',             'output/llm_body_chunk_005.json'),
        ('llm_body_chunk_006',             'output/llm_body_chunk_006.json'),
        ('llm_body_chunk_007',             'output/llm_body_chunk_007.json'),
        ('llm_body_chunk_008',             'output/llm_body_chunk_008.json'),
    ] + [(f'llm_weak_body_{i:03d}', f'output/llm_weak_body_{i:03d}.json') for i in range(76)] \
      + [(f'llm_repass_{i:03d}',    f'output/llm_repass_{i:03d}.json') for i in range(14)] \
      + [(f'llm_final2_{i:03d}',    f'output/llm_final2_{i:03d}.json') for i in range(10)] + [
        ('llm_classctx_000',               'output/llm_classctx_000.json'),
        ('llm_classctx_001',               'output/llm_classctx_001.json'),
        ('llm_classctx_002',               'output/llm_classctx_002.json'),
        ('ida_new_string_names',           'output/v_new_ida/ida_method_string_names.json'),
        ('ida_new_callgraph_names',        'output/v_new_ida/callgraph_method_names.json'),
        ('llm_strong_class_names',         'output/llm_strong_class_names.json'),
        ('ida_method_string_names_native', 'output/ida_method_string_names_native.json'),
        ('callgraph_method_names_native',  'output/callgraph_method_names_native.json'),
        ('ida_string_based_names',         'output/ida_string_based_names.json'),
    ]
    sources_obf = []

    for label, rel in sources_direct:
        p = BASE / rel
        raw = load_if_exists(p)
        if not raw:
            print(f'  [{label}] missing or empty')
            continue
        normalized = normalize_entries(raw, label)
        added = 0
        for k, v in normalized.items():
            if k not in existing:
                existing[k] = v
                added += 1
        print(f'  [{label}] added {added} new entries')
        stats[label] = {'raw': len(raw), 'valid': len(normalized), 'added': added}
        added_total += added

    for label, rel in sources_obf:
        p = BASE / rel
        raw = load_if_exists(p)
        if not raw:
            print(f'  [{label}] missing or empty')
            continue
        converted = convert_obf_keyed(raw, class_map, label)
        added = 0
        for k, v in converted.items():
            if k not in existing:
                existing[k] = v
                added += 1
        print(f'  [{label}] added {added} new entries')
        stats[label] = {'raw': len(raw), 'valid': len(converted), 'added': added}
        added_total += added

    print(f'\nTotal added: {added_total}')
    print(f'Final entries: {len(existing)}')

    if added_total > 0:
        with open(out_path, 'w', encoding='utf-8') as f:
            json.dump(existing, f, indent=2, ensure_ascii=False, sort_keys=True)
        print(f'Saved to {out_path}')
    else:
        print('No changes — not writing.')

    with open(BASE / 'output' / 'merge_stats.json', 'w', encoding='utf-8') as f:
        json.dump(stats, f, indent=2)


if __name__ == '__main__':
    main()
