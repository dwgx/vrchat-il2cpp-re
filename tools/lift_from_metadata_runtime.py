#!/usr/bin/env python3
"""
Recover real class names by linking runtime Il2CppClass structures to the
original-name strings that survive in the in-memory plaintext copy of
global-metadata.dat.

Faster strategy (vs. a 4 GB mmap regex sweep):
  1. Pull every PascalCase identifier out of the metadata file -> name set
     of expected real names (~9.5k).
  2. For every known Il2CppClass VA in precise_dump.json, walk its 0x180-
     byte struct one qword at a time. Any qword that is a valid heap
     pointer is dereferenced to a NUL-terminated ASCII string; if the
     resulting string is in the name set, record the (class_VA, real_name)
     pair.
  3. The OFF_NAME=0x50 slot returns the obfuscated name, so we record any
     OTHER slot that resolves to a name-set entry -- those are the
     parent/typeDef/owner pointers Beebyte forgot (or chose) to scrub.

Outputs:
  output/metadata_runtime_lifts.json
  output/metadata_runtime_log.md
"""
from __future__ import annotations

import json
import re
import sys
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(BASE / 'tools'))
from extract_precise_dump import DumpReader  # noqa: E402

DUMP_PATH = BASE / 'dumps' / 'VRChat_31360_20260503_212736_full.dmp'
GMD_PATH = Path(r'D:/Steam/steamapps/common/VRChat/VRChat_Data/il2cpp_data/Metadata/global-metadata.dat')
PRECISE = BASE / 'data' / 'precise_dump.json'
OUT_LIFTS = BASE / 'output' / 'metadata_runtime_lifts.json'
OUT_LOG = BASE / 'output' / 'metadata_runtime_log.md'

NAME_RE = re.compile(rb'[A-Za-z_][A-Za-z0-9_]{3,99}\x00')
IDENT_RE = re.compile(r'^[A-Za-z_][A-Za-z0-9_]*$')

CLASS_STRUCT_BYTES = 0x180
NAME_OFF = 0x50  # the obfuscated slot we skip

OBF_RE = re.compile(r'^[ÌÍÎÏ]+$')
PATTERN_RE = re.compile(
    r'^(AsyncStateMachine|VRCNetworkBehaviour|Delegate|LifecycleComponent|'
    r'EmptyStruct|EmptyType|UpdateComponent|FBase|BaseClass|ComplexComponent|'
    r'MajorSystem|Class_|Type_|NestedType_|GenericArg_|BackingField|'
    r'PointerEnter|Static|UIk__|k__BackingField)'
)


def main() -> None:
    print(f'[+] extracting names from {GMD_PATH.name} ...', flush=True)
    gmd = GMD_PATH.read_bytes()
    raw_names: set[str] = set()
    for m in NAME_RE.finditer(gmd):
        s = m.group()[:-1].decode('latin1', errors='replace')
        if not IDENT_RE.match(s):
            continue
        if len(s) < 4 or len(s) > 80:
            continue
        if s.isupper():
            continue  # SHOUT_CASE constants are not class names
        raw_names.add(s)
    print(f'    {len(raw_names):,} candidate names', flush=True)

    print(f'[+] opening dump {DUMP_PATH.name} ...', flush=True)
    dr = DumpReader(str(DUMP_PATH))
    print(f'    {len(dr.va_map)} VA ranges', flush=True)

    print(f'[+] loading {PRECISE.name} ...', flush=True)
    precise = json.loads(PRECISE.read_text(encoding='utf-8'))
    classes_total = sum(len(cs) for cs in precise['namespaces'].values())
    print(f'    {classes_total:,} runtime classes', flush=True)

    print('[+] scanning class structs for real-name pointers ...', flush=True)
    class_lifts: list[dict] = []
    examined = 0
    confirmed_already_named = 0
    candidates_per_class: list[int] = []
    progress = 0

    HEAP_LO = 0x10000000
    HEAP_HI = 0xFFFFFFFFFFFF
    name_off_idx = NAME_OFF // 8

    for ns, ns_classes in precise['namespaces'].items():
        for cls in ns_classes:
            progress += 1
            if progress % 5000 == 0:
                print(f'    scanned {progress}/{classes_total}, lifted {len(class_lifts)}', flush=True)

            obf_name = cls['name']
            va_str = cls.get('va')
            if not va_str:
                continue
            try:
                va = int(va_str, 16)
            except (ValueError, TypeError):
                continue

            qwords: list[int] = []
            for off in range(0, CLASS_STRUCT_BYTES, 8):
                v = dr.ru64(va + off)
                qwords.append(v if v is not None else 0)

            candidates: set[str] = set()
            for i, q in enumerate(qwords):
                if i == name_off_idx:
                    continue
                if not (HEAP_LO <= q < HEAP_HI):
                    continue
                if not dr.ok(q):
                    continue
                s = dr.rstr(q, 100)
                if s and s in raw_names:
                    candidates.add(s)

            if not candidates:
                continue

            already_real = not (OBF_RE.match(obf_name) or PATTERN_RE.match(obf_name))
            if already_real:
                if obf_name in candidates:
                    confirmed_already_named += 1
                continue

            examined += 1
            candidates_per_class.append(len(candidates))

            ranked = sorted(
                candidates,
                key=lambda n: (
                    -(2 if n.startswith(('VRC', 'EOS', 'Photon', 'Asset', 'Loading')) else 1) * len(n),
                    n.lower() in {'color', 'string', 'object', 'value', 'data', 'item'},
                ),
            )
            best = ranked[0]

            class_lifts.append({
                'va': va_str,
                'namespace': ns,
                'obf': obf_name,
                'real': best,
                'all_candidates': sorted(candidates)[:8],
            })

    print(f'[+] done. {len(class_lifts)} lifts / {examined} examined / '
          f'{confirmed_already_named} already-named confirmations', flush=True)

    # Distribution of candidate counts
    if candidates_per_class:
        c = Counter(candidates_per_class)
        print('    candidates-per-class distribution:')
        for k in sorted(c):
            print(f'        {k:>3}: {c[k]:>5}')

    OUT_LIFTS.parent.mkdir(parents=True, exist_ok=True)
    OUT_LIFTS.write_text(
        json.dumps(
            {
                'lifts': class_lifts,
                'count': len(class_lifts),
                'examined': examined,
                'already_named_confirmed': confirmed_already_named,
            },
            indent=2,
            ensure_ascii=False,
        ),
        encoding='utf-8',
    )

    OUT_LOG.write_text(
        '\n'.join(
            ['# Metadata-runtime Lift Trace', '',
             f'classes lifted: {len(class_lifts)}',
             f'examined: {examined}',
             f'already-named confirmations: {confirmed_already_named}',
             '', '## Sample (first 200)']
            + [f'- `{x["obf"][:30]}` (va {x["va"]}) -> **{x["real"]}**  candidates={x["all_candidates"]}'
               for x in class_lifts[:200]]
        ),
        encoding='utf-8',
    )

    print(f'    -> {OUT_LIFTS}')


if __name__ == '__main__':
    main()
