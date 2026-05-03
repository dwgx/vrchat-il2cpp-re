#!/usr/bin/env python3
"""
Lift real class / method / field names by mining error and log strings that the
compiler kept in GameAssembly.dll's .rdata. The mining step has already run
(extract_string_refs_may02.py) and emitted:

  data/method_string_refs_may02.json  - class_name -> [strings]
  data/all_method_strings_may02.json  - method_va_hex -> [strings]

This script extracts plausible names from those strings using high-confidence
patterns only (no LLM guessing), filters them against the existing
deobfuscated dump, and writes a name-mapping update consumable by the
pipeline:

  output/static_string_lifts.json    - direct class/method/field renames
  output/static_string_log.md        - human-readable trace per renamed class
"""
from __future__ import annotations

import json
import re
import sys
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / 'data' / 'precise_dump.json'
NAME_MAP = BASE / 'output' / 'name_mapping.json'
DEOBF = BASE / 'output' / 'deobfuscated_dump.json'
STR_REFS = BASE / 'data' / 'method_string_refs_may02.json'
METHOD_STR = BASE / 'data' / 'all_method_strings_may02.json'
OUT_LIFTS = BASE / 'output' / 'static_string_lifts.json'
OUT_LOG = BASE / 'output' / 'static_string_log.md'

OBF_CLASS_RE = re.compile(r'^[ÌÍÎÏ]+$')
HASH_METHOD_RE = re.compile(r'^m_[0-9A-F]{3}$', re.I)
HASH_FIELD_RE = re.compile(r'^f_[0-9A-F]+$', re.I)

# Strong-signal name reveals
TYPE_OF_RE = re.compile(r"type\s+(?:'|\")([A-Za-z][A-Za-z0-9_.+`]+)(?:'|\")", re.I)
FIELD_NAMED_RE = re.compile(r"field\s+(?:'|\")([A-Za-z_][A-Za-z0-9_]+)(?:'|\")", re.I)
METHOD_DOT_RE = re.compile(r'\b([A-Z][A-Za-z0-9_]*?)\.([A-Z][A-Za-z0-9_]+)\b')
QUALIFIED_TYPE_RE = re.compile(r'\b([A-Z][A-Za-z0-9_]+(?:\.[A-Z][A-Za-z0-9_+]+){1,4})\b')
EXTERN_API_RE = re.compile(r'^(EOS|ovr|mp_|SteamAPI|Reg[A-Z]|kernel32|ntdll)\w+', re.I)
PASCAL_TOKEN_RE = re.compile(r'^[A-Z][A-Za-z0-9_]{2,80}$')

# Names we should NEVER lift to: too generic
NOISE_NAMES = frozenset({
    'String', 'Object', 'Int32', 'Int64', 'UInt32', 'UInt64', 'Boolean', 'Single',
    'Double', 'Byte', 'SByte', 'Char', 'Decimal', 'DateTime', 'Guid',
    'List', 'Array', 'Dictionary', 'HashSet', 'Queue', 'Stack',
    'Type', 'Method', 'Field', 'Property', 'Event',
    'Exception', 'ArgumentException', 'InvalidOperationException',
    'ArgumentNullException', 'NotImplementedException', 'NotSupportedException',
    'IDisposable', 'IEnumerable', 'IEnumerator', 'ICloneable', 'IComparable',
    'Component', 'GameObject', 'Transform', 'MonoBehaviour', 'ScriptableObject',
    'Vector2', 'Vector3', 'Vector4', 'Quaternion', 'Color', 'Rect',
    'Task', 'CancellationToken', 'IntPtr', 'UIntPtr',
    'Activity', 'Attachment', 'ContentBlock', 'ContentList', 'Data',
    'Buffer', 'Stream', 'Reader', 'Writer',
})


def is_pattern_class(name: str) -> bool:
    """Match the structural pattern names the pipeline emits as fallbacks."""
    return bool(re.match(
        r'^(AsyncStateMachine|VRCNetworkBehaviour|Delegate|LifecycleComponent|'
        r'EmptyStruct|EmptyType|UpdateComponent|FBase|BaseClass|'
        r'ComplexComponent|MajorSystem|Class_|Type_|NestedType_|GenericArg_|'
        r'BackingField|PointerEnter|Static|UIk__|k__BackingField)',
        name,
    ))


def pull_names_from_string(s: str) -> tuple[set[str], set[str], set[str]]:
    """Return (type_candidates, method_candidates, field_candidates)."""
    types: set[str] = set()
    methods: set[str] = set()
    fields: set[str] = set()

    for match in TYPE_OF_RE.finditer(s):
        candidate = match.group(1)
        if '.' in candidate:
            short = candidate.split('.')[-1]
        else:
            short = candidate
        if short and short not in NOISE_NAMES and PASCAL_TOKEN_RE.match(short):
            types.add(short)

    for match in FIELD_NAMED_RE.finditer(s):
        f = match.group(1)
        if f and len(f) >= 3:
            fields.add(f)

    for match in METHOD_DOT_RE.finditer(s):
        cls, mth = match.group(1), match.group(2)
        if cls in NOISE_NAMES or mth in NOISE_NAMES:
            continue
        if PASCAL_TOKEN_RE.match(mth):
            methods.add(mth)
        if cls not in NOISE_NAMES and PASCAL_TOKEN_RE.match(cls):
            types.add(cls)

    for match in QUALIFIED_TYPE_RE.finditer(s):
        full = match.group(1)
        short = full.split('.')[-1]
        if short and short not in NOISE_NAMES and PASCAL_TOKEN_RE.match(short):
            # Only accept when at least one segment is a recognizable namespace
            # (UnityEngine./System./VRC./Photon. etc.) -- otherwise we get
            # `BurstDirectCallInitializer.Foo` style wrappers as class names.
            head = full.split('.')[0]
            if head in {'UnityEngine', 'System', 'VRC', 'VRChat', 'Photon',
                        'Cysharp', 'BestHTTP', 'Cinemachine', 'Newtonsoft', 'OdinSerializer'}:
                types.add(short)

    return types, methods, fields


def main() -> None:
    print(f'[+] Loading {STR_REFS.name}...')
    class_strings = json.loads(STR_REFS.read_text(encoding='utf-8'))
    print(f'    {len(class_strings)} classes with string refs')

    print(f'[+] Loading {NAME_MAP.name}...')
    name_map = json.loads(NAME_MAP.read_text(encoding='utf-8'))
    classes_obf_to_sem = name_map.get('classes', {})
    methods_obf_to_sem = name_map.get('methods', {})
    fields_obf_to_sem = name_map.get('fields', {})

    print(f'[+] Loading {DEOBF.name}...')
    deobf = json.loads(DEOBF.read_text(encoding='utf-8'))

    # Build a set of every existing semantic class name in the dump so we
    # don't propose collisions.
    existing_classes: set[str] = set()
    for ns_classes in deobf['namespaces'].values():
        for cls in ns_classes:
            existing_classes.add(cls['name'])

    # Build obf -> sem class map (for matching back to dumps): the precise
    # dump uses the obfuscated name as `name`, the deobf dump replaced it
    # with the semantic. We need to match by VA so the lift is unambiguous.
    deobf_by_va: dict[str, dict] = {}
    for ns_classes in deobf['namespaces'].values():
        for cls in ns_classes:
            va = cls.get('va')
            if va:
                deobf_by_va[va] = cls

    print(f'[+] Loading {DUMP.name}...')
    precise = json.loads(DUMP.read_text(encoding='utf-8'))
    precise_by_obf_name: dict[str, dict] = {}
    for ns_classes in precise['namespaces'].values():
        for cls in ns_classes:
            precise_by_obf_name[cls['name']] = cls

    # Collect candidate names per class
    print('[+] Mining strings ...')
    class_lifts: dict[str, str] = {}
    method_lifts: dict[str, str] = {}
    field_lifts: dict[str, str] = {}
    log_lines: list[str] = []
    skipped_collisions = 0

    for obf_name, strings in class_strings.items():
        cls = precise_by_obf_name.get(obf_name)
        if cls is None:
            continue
        sem_name = classes_obf_to_sem.get(obf_name, obf_name)
        # Only target classes that are still hash/pattern-fallback in the deobf
        if not (OBF_CLASS_RE.match(sem_name) or is_pattern_class(sem_name)):
            continue

        type_cands: Counter = Counter()
        method_cands: Counter = Counter()
        field_cands: Counter = Counter()
        for s in strings:
            t, m, f = pull_names_from_string(s)
            type_cands.update(t)
            method_cands.update(m)
            field_cands.update(f)

        # Class lift: pick the unique highest-vote candidate that doesn't
        # collide with an existing semantic class.
        if type_cands:
            top = type_cands.most_common(3)
            best_name, best_votes = top[0]
            second_votes = top[1][1] if len(top) > 1 else 0
            if (
                best_votes >= 2
                and best_votes >= 2 * max(second_votes, 1)
                and best_name not in existing_classes
                and best_name != sem_name
                and best_name not in NOISE_NAMES
            ):
                class_lifts[obf_name] = best_name
                existing_classes.add(best_name)
                log_lines.append(
                    f'- `{obf_name}` -> **{best_name}** '
                    f'(votes={best_votes}, runner-up={second_votes})  via strings: '
                    f'{", ".join(repr(s)[:60] for s in strings[:2])}'
                )
            elif best_votes >= 2:
                skipped_collisions += 1

    OUT_LIFTS.parent.mkdir(parents=True, exist_ok=True)
    OUT_LIFTS.write_text(
        json.dumps(
            {
                'classes': class_lifts,
                'methods': method_lifts,
                'fields': field_lifts,
                'source': 'static_string_refs_may02',
                'class_lift_count': len(class_lifts),
                'collisions_skipped': skipped_collisions,
            },
            indent=2,
            ensure_ascii=False,
        ),
        encoding='utf-8',
    )

    OUT_LOG.write_text(
        '\n'.join(['# Static String Lift Trace', '',
                    f'classes lifted: {len(class_lifts)}',
                    f'collisions skipped: {skipped_collisions}',
                    ''] + log_lines[:1000]),
        encoding='utf-8',
    )

    print(f'[+] class lifts: {len(class_lifts)}')
    print(f'    collisions skipped: {skipped_collisions}')
    print(f'    -> {OUT_LIFTS}')
    print(f'    -> {OUT_LOG}')


if __name__ == '__main__':
    main()
