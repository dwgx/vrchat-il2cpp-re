#!/usr/bin/env python3
"""
Lift Apr 18 semantic names onto Apr 25 obfuscated identifiers.

Inputs:
  - data/apr18_baseline/precise_dump.json
  - data/apr18_baseline/deobfuscated_dump.json
  - precise_dump_NEW.json
  - data/class_map_old_to_new.json

Outputs:
  - data/apr25_lifted_vocab.json
  - data/apr25_lifted_vocab_summary.csv
"""

import csv
import hashlib
import json
import re
import time
from pathlib import Path


OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

BASE_DIR = Path(__file__).resolve().parent.parent
APR18_PRECISE_PATH = BASE_DIR / 'data' / 'apr18_baseline' / 'precise_dump.json'
APR18_DEOBF_PATH = BASE_DIR / 'data' / 'apr18_baseline' / 'deobfuscated_dump.json'
APR25_PRECISE_PATH = BASE_DIR / 'precise_dump_NEW.json'
CLASS_MAP_PATH = BASE_DIR / 'data' / 'class_map_old_to_new.json'
OUTPUT_JSON_PATH = BASE_DIR / 'data' / 'apr25_lifted_vocab.json'
OUTPUT_CSV_PATH = BASE_DIR / 'data' / 'apr25_lifted_vocab_summary.csv'


def is_obf(name: str) -> bool:
    return bool(name and isinstance(name, str) and OBF_RE.match(name))


def stable_hash(name: str, length: int = 3) -> str:
    return hashlib.sha256(name.encode('utf-8')).hexdigest()[:length].upper()


def load_dump_by_va(path: Path) -> dict[str, dict]:
    with open(path, 'r', encoding='utf-8') as f:
        data = json.load(f)

    classes_by_va: dict[str, dict] = {}
    for ns, classes in data.get('namespaces', {}).items():
        for cls in classes:
            va = cls.get('va')
            if va:
                classes_by_va[va] = cls
    return classes_by_va


def field_name(field) -> str:
    if isinstance(field, dict):
        return field.get('name', '')
    if isinstance(field, str):
        return field
    return ''


def emit_flat(target: dict, key: str, value: str, conflicts: list[dict], category: str):
    if not key or not value:
        return False
    existing = target.get(key)
    if existing is None:
        target[key] = value
        return True
    if existing == value:
        return False
    conflicts.append({
        'category': category,
        'key': key,
        'existing': existing,
        'ignored': value,
    })
    return False


def emit_context(target: dict, key: str, value: str, conflicts: list[dict], category: str):
    existing = target.get(key)
    if existing is None:
        target[key] = value
        return True
    if existing == value:
        return False
    conflicts.append({
        'category': category,
        'key': key,
        'existing': existing,
        'ignored': value,
    })
    return False


def build_lifted_vocab():
    apr18_precise = load_dump_by_va(APR18_PRECISE_PATH)
    apr18_deobf = load_dump_by_va(APR18_DEOBF_PATH)
    apr25_precise = load_dump_by_va(APR25_PRECISE_PATH)

    with open(CLASS_MAP_PATH, 'r', encoding='utf-8') as f:
        class_map = json.load(f)

    flat_class_names: dict[str, str] = {}
    flat_method_names: dict[str, str] = {}
    flat_field_names: dict[str, str] = {}
    class_name_map: dict[str, str] = {}
    method_name_map: dict[str, str] = {}
    field_name_map: dict[str, str] = {}
    cross_version_method_names: dict[str, str] = {}
    signature_to_name: dict[str, str] = {}
    conflicts: list[dict] = []
    rows: list[dict] = []

    stats = {
        'mapped_class_pairs': 0,
        'missing_old_precise': 0,
        'missing_old_deobf': 0,
        'missing_new_precise': 0,
        'class_name_emits': 0,
        'method_name_emits': 0,
        'field_name_emits': 0,
        'method_cross_version_emits': 0,
        'method_pairs_considered': 0,
        'field_pairs_considered': 0,
        'method_length_mismatches': 0,
        'field_length_mismatches': 0,
        'flat_conflicts': 0,
        'context_conflicts': 0,
    }

    for old_va, mapping in class_map.items():
        new_va = mapping.get('new_va')
        old_precise_cls = apr18_precise.get(old_va)
        old_deobf_cls = apr18_deobf.get(old_va)
        new_precise_cls = apr25_precise.get(new_va)

        if old_precise_cls is None:
            stats['missing_old_precise'] += 1
            continue
        if old_deobf_cls is None:
            stats['missing_old_deobf'] += 1
            continue
        if new_precise_cls is None:
            stats['missing_new_precise'] += 1
            continue

        stats['mapped_class_pairs'] += 1

        old_semantic_class = old_deobf_cls.get('name', '')
        new_obf_class = new_precise_cls.get('name', '')

        if len(old_deobf_cls.get('methods', [])) != len(new_precise_cls.get('methods', [])):
            stats['method_length_mismatches'] += 1
        if len(old_deobf_cls.get('fields', [])) != len(new_precise_cls.get('fields', [])):
            stats['field_length_mismatches'] += 1

        if is_obf(new_obf_class) and not is_obf(old_semantic_class):
            if emit_context(class_name_map, new_obf_class, old_semantic_class, conflicts, 'class_context'):
                stats['class_name_emits'] += 1
            emit_flat(flat_class_names, new_obf_class, old_semantic_class, conflicts, 'class_flat')
            signature_to_name[new_obf_class] = old_semantic_class
            rows.append({
                'category': 'class',
                'old_va': old_va,
                'new_va': new_va,
                'new_class_obf': new_obf_class,
                'key': new_obf_class,
                'semantic_class': old_semantic_class,
                'semantic_name': old_semantic_class,
            })

        old_methods = old_deobf_cls.get('methods', [])
        new_methods = new_precise_cls.get('methods', [])
        method_count = min(len(old_methods), len(new_methods))
        stats['method_pairs_considered'] += method_count
        for idx in range(method_count):
            old_semantic_method = old_methods[idx]
            new_obf_method = new_methods[idx]
            if not isinstance(old_semantic_method, str) or not isinstance(new_obf_method, str):
                continue
            if not is_obf(new_obf_method) or is_obf(old_semantic_method):
                continue

            context_key = f'{new_obf_class}::{new_obf_method}'
            if emit_context(method_name_map, context_key, old_semantic_method, conflicts, 'method_context'):
                stats['method_name_emits'] += 1
            emit_flat(flat_method_names, new_obf_method, old_semantic_method, conflicts, 'method_flat')

            if not is_obf(old_semantic_class):
                cv_key = f'{old_semantic_class}::m_{stable_hash(new_obf_method, 3)}'
                if emit_context(cross_version_method_names, cv_key, old_semantic_method, conflicts, 'method_cross_version'):
                    stats['method_cross_version_emits'] += 1
                signature_to_name[cv_key] = old_semantic_method

            rows.append({
                'category': 'method',
                'old_va': old_va,
                'new_va': new_va,
                'new_class_obf': new_obf_class,
                'key': context_key,
                'semantic_class': old_semantic_class,
                'semantic_name': old_semantic_method,
            })

        old_fields = old_deobf_cls.get('fields', [])
        new_fields = new_precise_cls.get('fields', [])
        field_count = min(len(old_fields), len(new_fields))
        stats['field_pairs_considered'] += field_count
        for idx in range(field_count):
            old_semantic_field = field_name(old_fields[idx])
            new_obf_field = field_name(new_fields[idx])
            if not old_semantic_field or not new_obf_field:
                continue
            if not is_obf(new_obf_field) or is_obf(old_semantic_field):
                continue

            context_key = f'{new_obf_class}::{new_obf_field}'
            if emit_context(field_name_map, context_key, old_semantic_field, conflicts, 'field_context'):
                stats['field_name_emits'] += 1
            emit_flat(flat_field_names, new_obf_field, old_semantic_field, conflicts, 'field_flat')
            signature_to_name[context_key] = old_semantic_field

            rows.append({
                'category': 'field',
                'old_va': old_va,
                'new_va': new_va,
                'new_class_obf': new_obf_class,
                'key': context_key,
                'semantic_class': old_semantic_class,
                'semantic_name': old_semantic_field,
            })

    stats['flat_conflicts'] = sum(1 for c in conflicts if c['category'].endswith('_flat'))
    stats['context_conflicts'] = len(conflicts) - stats['flat_conflicts']

    output = {
        'generated_by': 'tools/lift_apr18_to_apr25_vocab.py',
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'inputs': {
            'apr18_precise_dump': str(APR18_PRECISE_PATH.relative_to(BASE_DIR)),
            'apr18_deobfuscated_dump': str(APR18_DEOBF_PATH.relative_to(BASE_DIR)),
            'apr25_precise_dump': str(APR25_PRECISE_PATH.relative_to(BASE_DIR)),
            'class_map_old_to_new': str(CLASS_MAP_PATH.relative_to(BASE_DIR)),
        },
        'stats': stats,
        'class_names': flat_class_names,
        'method_names': flat_method_names,
        'field_names': flat_field_names,
        'class_name_map': class_name_map,
        'method_name_map': method_name_map,
        'field_name_map': field_name_map,
        'cross_version_method_names': cross_version_method_names,
        'signature_to_name': signature_to_name,
        'conflicts': conflicts[:5000],
        'conflict_count': len(conflicts),
    }

    return output, rows, stats, conflicts


def main():
    print('Loading Apr 18 / Apr 25 dumps ...')
    output, rows, stats, conflicts = build_lifted_vocab()

    OUTPUT_JSON_PATH.parent.mkdir(parents=True, exist_ok=True)
    with open(OUTPUT_JSON_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, indent=2, ensure_ascii=False, sort_keys=True)

    with open(OUTPUT_CSV_PATH, 'w', encoding='utf-8', newline='') as f:
        writer = csv.DictWriter(
            f,
            fieldnames=['category', 'old_va', 'new_va', 'new_class_obf', 'key', 'semantic_class', 'semantic_name'],
        )
        writer.writeheader()
        writer.writerows(rows)

    print(f'Mapped class pairs:          {stats["mapped_class_pairs"]:,}')
    print(f'Lifted classes:             {stats["class_name_emits"]:,}')
    print(f'Lifted methods:             {stats["method_name_emits"]:,}')
    print(f'Lifted fields:              {stats["field_name_emits"]:,}')
    print(f'Cross-version method keys:  {stats["method_cross_version_emits"]:,}')
    print(f'Conflicts recorded:         {len(conflicts):,}')
    print(f'Wrote {OUTPUT_JSON_PATH}')
    print(f'Wrote {OUTPUT_CSV_PATH}')


if __name__ == '__main__':
    main()
