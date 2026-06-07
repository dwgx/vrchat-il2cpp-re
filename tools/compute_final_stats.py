#!/usr/bin/env python3
"""Compute canonical coverage statistics from the deobfuscated dump.

Single source of truth for all coverage numbers reported in README,
WORKFLOW, dashboard, and coverage reports. Run after the pipeline.
"""
import sys
sys.stdout.reconfigure(encoding='utf-8')

import json
import re
from pathlib import Path

BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / 'output' / 'deobfuscated_dump.json'
CV = BASE / 'output' / 'cross_version_method_names.json'
OUT = BASE / 'output' / 'coverage_stats.json'

OBF_RE = re.compile(r'^[ÌÍÎÏ]{3,}$')
HASH_RE = re.compile(r'^m_[0-9A-Fa-f]{3,}$')
FHASH_RE = re.compile(r'^f_[0-9A-Fa-f]{3,}$')

# Weak/fallback class-name detection — mirrors run_full_pipeline._is_weak_name
# so coverage numbers stay consistent with the pipeline coverage report.
WEAK_PREFIXES = (
    'Obf_', 'Type', 'Struct', 'Mono', 'Service', 'Major', 'Static',
    'DataOnly', 'EmptyType', 'EmptyStruct', 'EmptyClass', 'Record',
    'Unknown', 'LargeClass', 'Class_',
)
WEAK_RE = re.compile(r'^(Type|Struct|Mono|Service|Major|Static)\d+[mf]')


def is_weak_name(name: str) -> bool:
    if WEAK_RE.match(name):
        return True
    return name.startswith(WEAK_PREFIXES)


def main():
    with open(DUMP, encoding='utf-8-sig') as f:
        data = json.load(f)

    total_classes = 0
    obf_classes = 0       # classes that were originally obfuscated
    semantic_classes = 0  # obf classes with a meaningful name
    fallback_classes = 0  # obf classes with only a structural/hash name

    total_methods = 0
    semantic_methods = 0
    hash_methods = 0
    obf_methods = 0

    total_fields = 0
    semantic_fields = 0
    hash_fields = 0

    for ns, classes in data.get('namespaces', {}).items():
        for cls in classes:
            total_classes += 1
            orig = cls.get('original_name')
            name = cls.get('name', '')
            if orig:  # was obfuscated
                obf_classes += 1
                if is_weak_name(name):
                    fallback_classes += 1
                else:
                    semantic_classes += 1

            for m in cls.get('methods', []):
                if not isinstance(m, str):
                    continue
                total_methods += 1
                if OBF_RE.match(m):
                    obf_methods += 1
                elif HASH_RE.match(m):
                    hash_methods += 1
                else:
                    semantic_methods += 1

            for fld in cls.get('fields', []):
                fname = fld.get('name', '') if isinstance(fld, dict) else fld
                if not isinstance(fname, str):
                    continue
                total_fields += 1
                if OBF_RE.match(fname) or FHASH_RE.match(fname):
                    hash_fields += 1
                else:
                    semantic_fields += 1

    cv_count = 0
    if CV.exists():
        with open(CV, encoding='utf-8-sig') as f:
            cv_count = len(json.load(f))

    stats = {
        'build': '2026-06-05',
        'classes': {
            'total': total_classes,
            'obfuscated': obf_classes,
            'semantic': semantic_classes,
            'fallback': fallback_classes,
            'semantic_pct': round(100 * semantic_classes / obf_classes, 1) if obf_classes else 0,
        },
        'methods': {
            'total': total_methods,
            'semantic': semantic_methods,
            'hash_fallback': hash_methods,
            'obfuscated': obf_methods,
            'semantic_pct': round(100 * semantic_methods / total_methods, 1) if total_methods else 0,
        },
        'fields': {
            'total': total_fields,
            'semantic': semantic_fields,
            'hash_fallback': hash_fields,
            'semantic_pct': round(100 * semantic_fields / total_fields, 1) if total_fields else 0,
        },
        'cross_version_entries': cv_count,
    }

    with open(OUT, 'w', encoding='utf-8') as f:
        json.dump(stats, f, ensure_ascii=False, indent=2)

    print(json.dumps(stats, ensure_ascii=False, indent=2))
    print(f'\nWritten: {OUT}')


if __name__ == '__main__':
    main()
