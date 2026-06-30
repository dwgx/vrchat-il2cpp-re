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

sys.path.insert(0, str(Path(__file__).resolve().parent))
from name_quality import is_weak_name  # canonical criterion, shared with pipeline

BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / 'output' / 'deobfuscated_dump.json'
CV = BASE / 'output' / 'cross_version_method_names.json'
OUT = BASE / 'output' / 'coverage_stats.json'

OBF_RE = re.compile(r'^[ÌÍÎÏ]{3,}$')
HASH_RE = re.compile(r'^m_[0-9A-Fa-f]{3,}$')
FHASH_RE = re.compile(r'^f_[0-9A-Fa-f]{3,}$')

# Weak/fallback class-name detection now lives in name_quality.is_weak_name
# (imported above) so the pipeline and this report can never disagree.



def main():
    with open(DUMP, encoding='utf-8-sig') as f:
        data = json.load(f)

    # Build identifier comes from the dump itself, never hardcoded.
    _summary = data.get('summary', data.get('metadata', {}))
    build_id = _summary.get('build', 'unknown')

    total_classes = 0
    obf_classes = 0       # classes that were originally obfuscated
    semantic_classes = 0  # obf classes with a meaningful name
    fallback_classes = 0  # obf classes with only a structural/hash name

    # Source-type-level (generic-dedup) tracking. IL2CPP emits one Il2CppClass
    # per generic instantiation (Foo<int>, Foo<string>, ...) but they share one
    # source TypeDefinition, hence one obfuscated original_name. Counting each
    # instance inflates the denominator; dedup by original_name to count
    # distinct source types. Proven: see memory vrchat-beebyte-generic-dedup
    # (4^23 name space => random collision prob 4.8e-7; observed groups share
    # identical obfuscated field-name sets => same source definition).
    src_named = {}  # original_name -> bool list (is this instance meaningfully named)

    total_methods = 0
    semantic_methods = 0
    behavioral_methods = 0
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
                weak = is_weak_name(name)
                if weak:
                    fallback_classes += 1
                else:
                    semantic_classes += 1
                src_named.setdefault(orig, []).append(not weak)

            for m in cls.get('methods', []):
                if not isinstance(m, str):
                    continue
                total_methods += 1
                if OBF_RE.match(m):
                    obf_methods += 1
                elif HASH_RE.match(m):
                    hash_methods += 1
                elif m.startswith('Invoke_'):
                    # item 16/18: behavioral annotation (method DRIVES this API),
                    # 99% accurate as a descriptor but NOT a recovered original
                    # name (~1-2% name-correlation, item 18). Counted semantic for
                    # readability but tracked separately so coverage never claims
                    # these as true-name recovery.
                    behavioral_methods += 1
                    semantic_methods += 1
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

    # Collapse generic instances to source types. A source type counts as named
    # if a majority of its instances carry a meaningful name (they are codegen'd
    # consistently, so this is virtually always unanimous).
    src_total = len(src_named)
    src_semantic = sum(1 for flags in src_named.values()
                       if sum(flags) > len(flags) / 2)
    generic_instances = obf_classes - src_total  # duplicate instantiations folded away

    stats = {
        'build': build_id,
        'classes': {
            'total': total_classes,
            'obfuscated': obf_classes,
            'semantic': semantic_classes,
            'fallback': fallback_classes,
            'semantic_pct': round(100 * semantic_classes / obf_classes, 1) if obf_classes else 0,
            # Source-type-level (generic-dedup) — the honest "distinct classes"
            # number. Headline semantic_pct stays instance-level for continuity.
            'source_types': src_total,
            'source_types_semantic': src_semantic,
            'source_types_semantic_pct': round(100 * src_semantic / src_total, 1) if src_total else 0,
            'generic_instances_folded': generic_instances,
        },
        'methods': {
            'total': total_methods,
            'semantic': semantic_methods,
            'behavioral_annotations': behavioral_methods,
            'true_name_semantic': semantic_methods - behavioral_methods,
            'hash_fallback': hash_methods,
            'obfuscated': obf_methods,
            'semantic_pct': round(100 * semantic_methods / total_methods, 1) if total_methods else 0,
            'true_name_pct': round(100 * (semantic_methods - behavioral_methods) / total_methods, 1) if total_methods else 0,
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
