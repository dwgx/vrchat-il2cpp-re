#!/usr/bin/env python3
"""
Lift IL2CPP method names that are clearly P/Invoke wrappers.

A method body that contains exactly one .rdata string matching a known
external-API prefix (ovr_*, EOS_*, Discord_*, SteamAPI_*, GC_*, Reg*W,
LoadLibrary*, etc.) is overwhelmingly likely the C# wrapper for that
function. The wrapper's semantic name is the API symbol with the prefix
stripped, in PascalCase.

Inputs:
  data/all_method_strings_may02.json   - method_va_hex -> [strings]
  data/precise_dump.json               - obf class/method names + VAs
  output/name_mapping.json             - existing semantic map (avoid overrides)

Output:
  output/pinvoke_lifts.json            - {class_name::obf_method: real_name}
  output/pinvoke_log.md                - human-readable trace
"""
from __future__ import annotations

import json
import re
import sys
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent
METHOD_STR = BASE / 'data' / 'all_method_strings_may02.json'
PRECISE = BASE / 'data' / 'precise_dump.json'
NAME_MAP = BASE / 'output' / 'name_mapping.json'
OUT_LIFTS = BASE / 'output' / 'pinvoke_lifts.json'
OUT_LOG = BASE / 'output' / 'pinvoke_log.md'

# Each tuple is (regex pattern, prefix-strip rule, family label)
EXTERN_PATTERNS: list[tuple[re.Pattern, str, str]] = [
    (re.compile(r'^ovr_([A-Z][A-Za-z0-9_]+)$'), 'ovr_', 'Oculus'),
    (re.compile(r'^ovrAvatar2_([A-Za-z0-9_]+)$'), 'ovrAvatar2_', 'OculusAvatar2'),
    (re.compile(r'^EOS_([A-Z][A-Za-z0-9_]+)$'), 'EOS_', 'EpicOnlineServices'),
    (re.compile(r'^Discord_([A-Z][A-Za-z0-9_]+)$'), 'Discord_', 'Discord'),
    (re.compile(r'^SteamAPI_([A-Z][A-Za-z0-9_]+)$'), 'SteamAPI_', 'Steam'),
    (re.compile(r'^GC_([A-Z][A-Z0-9_]+)$'), 'GC_', 'BoehmGC'),
    (re.compile(r'^(Reg[A-Z][A-Za-z]+W?)$'), '', 'WinRegistry'),
    (re.compile(r'^(LoadLibrary[AW]?|GetProcAddress|FreeLibrary)$'), '', 'WinDynLink'),
    (re.compile(r'^(crypto_[a-z_0-9]+)$'), 'crypto_', 'libsodium'),
    (re.compile(r'^(sqlite3_[a-z0-9_]+)$'), 'sqlite3_', 'SQLite'),
    (re.compile(r'^(GLFW[A-Z][A-Za-z0-9_]+)$'), 'GLFW', 'GLFW'),
    (re.compile(r'^(XInput[A-Z][A-Za-z0-9_]+)$'), 'XInput', 'XInput'),
    (re.compile(r'^(IL2CPP_[A-Z_]+)$'), 'IL2CPP_', 'IL2CPP'),
]

VALID_NAME_RE = re.compile(r'^[A-Z][A-Za-z0-9_]{1,80}$')


def to_pascal(s: str) -> str:
    """snake_case_or_camelCase -> PascalCase. Keeps existing PascalCase intact."""
    if not s:
        return s
    # snake_case -> split on _
    parts = s.split('_')
    out = []
    for p in parts:
        if not p:
            continue
        if p[0].isupper():
            out.append(p)
        else:
            out.append(p[0].upper() + p[1:])
    return ''.join(out)


def match_external(s: str) -> tuple[str, str] | None:
    """Returns (PascalCase_name, family_label) or None."""
    for pattern, prefix, family in EXTERN_PATTERNS:
        m = pattern.match(s)
        if m:
            symbol = m.group(1)
            return to_pascal(symbol), family
    return None


def main() -> None:
    print(f'[+] Loading {METHOD_STR.name}...')
    method_strings = json.loads(METHOD_STR.read_text(encoding='utf-8'))
    print(f'[+] Loading {PRECISE.name}...')
    precise = json.loads(PRECISE.read_text(encoding='utf-8'))
    print(f'[+] Loading {NAME_MAP.name}...')
    name_map = json.loads(NAME_MAP.read_text(encoding='utf-8'))
    methods_obf_to_sem = name_map.get('methods', {})

    # Build VA -> (class_obf, method_obf, namespace) lookup
    va_to_info: dict[str, tuple[str, str, str]] = {}
    for ns, ns_classes in precise['namespaces'].items():
        for cls in ns_classes:
            cls_name = cls['name']
            for m_name, m_va in cls.get('method_pointers', {}).items():
                va_to_info[m_va] = (cls_name, m_name, ns)

    print('[+] Scanning P/Invoke candidates ...')
    lifts: dict[str, str] = {}
    family_counter: Counter = Counter()
    log_lines: list[str] = []
    multi_extern = 0
    no_match = 0
    name_collisions: list[tuple[str, str, str]] = []

    for va, strings in method_strings.items():
        extern_matches: list[tuple[str, str]] = []
        for s in strings:
            m = match_external(s)
            if m:
                extern_matches.append(m)

        if not extern_matches:
            no_match += 1
            continue

        # Strong signal: only ONE extern API matched (so the method is its
        # wrapper, not a router that calls many).
        if len(extern_matches) > 1:
            multi_extern += 1
            continue

        api_name, family = extern_matches[0]
        if not VALID_NAME_RE.match(api_name):
            continue

        info = va_to_info.get(va)
        if not info:
            continue
        cls_obf, mth_obf, ns = info

        # Skip methods that already have a non-hash semantic name
        sem_key = f'{cls_obf}::{mth_obf}'
        existing = methods_obf_to_sem.get(sem_key, '')
        if existing and not re.match(r'^m_[0-9A-F]{3}$', existing, re.I):
            # Already named -- keep original
            continue

        lifts[sem_key] = api_name
        family_counter[family] += 1
        log_lines.append(
            f'- `{cls_obf[:25]}::{mth_obf}` -> **{api_name}**  ({family}) @ {va}'
        )

    OUT_LIFTS.parent.mkdir(parents=True, exist_ok=True)
    OUT_LIFTS.write_text(
        json.dumps(
            {
                'methods': lifts,
                'count': len(lifts),
                'by_family': dict(family_counter),
                'multi_extern_skipped': multi_extern,
                'no_extern_match': no_match,
                'source': 'static_string_pinvoke_match',
            },
            indent=2,
            ensure_ascii=False,
        ),
        encoding='utf-8',
    )

    OUT_LOG.write_text(
        '\n'.join(['# P/Invoke Wrapper Lifts',
                    '',
                    f'methods lifted: {len(lifts)}',
                    f'multi-extern (router-style, skipped): {multi_extern}',
                    'by family:'] +
                   [f'- {k}: {v}' for k, v in family_counter.most_common()] +
                   ['', '## Trace', ''] +
                   log_lines[:2000]),
        encoding='utf-8',
    )

    print(f'[+] lifted {len(lifts)} P/Invoke methods')
    for k, v in family_counter.most_common():
        print(f'    {v:>4} {k}')
    print(f'    -> {OUT_LIFTS}')


if __name__ == '__main__':
    main()
