#!/usr/bin/env python3
"""
Real-name lift via Beebyte-decrypted IL2CPP TypeDefinition tokens.

Pipeline (works on the decrypted metadata file from `decrypt_metadata.py`):
  1. Walk every TypeDefinition entry in S3-relative metadata. Each entry is
     0x58 bytes; row N has token 0x02000000 | N at offset +0x54. Name and
     namespace pool indices live at offsets 0 and 4. The string pool starts
     at file offset 0x023A6B0.
  2. For every runtime Il2CppClass (from precise_dump.json) read the token
     at struct offset +0x11C. Look the row up in the TypeDef table, pull
     the (namespace, name) strings, and emit a lift if the name is a real
     PascalCase identifier (not a Beebyte obfuscated string).
  3. Write a name_mapping-shaped JSON the deobfuscation pipeline can fold
     into name_mapping.json's `classes` field via additional_names.json.

Output:
  output/typedef_token_lifts.json  - {obf_class_name: real_name, ...}
  output/typedef_token_log.md      - trace of lifts (first 1000 rows)
"""
from __future__ import annotations

import json
import re
import struct
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(BASE / 'tools'))
from extract_precise_dump import DumpReader  # noqa: E402

DEC_PATH = BASE / 'data' / 'metadata_decrypted.dat'
DUMP_PATH = BASE / 'dumps' / 'VRChat_31360_20260503_212736_full.dmp'
PRECISE = BASE / 'data' / 'precise_dump.json'
OUT_LIFTS = BASE / 'output' / 'typedef_token_lifts.json'
OUT_LOG = BASE / 'output' / 'typedef_token_log.md'

STRING_POOL_OFF = 0x023A6B0
STRING_POOL_SIZE = 0x0075AE88
TYPEDEF_TABLE_BASE = 0x1F80034   # token 0x02000001 = '<Module>'
TYPEDEF_STRIDE = 0x58
TYPEDEF_NAME_OFF = 0x00
TYPEDEF_NS_OFF = 0x04
TYPEDEF_TOKEN_OFF = 0x54

CLASS_TOKEN_OFF = 0x11C  # runtime Il2CppClass struct

OBF_CHARS = set('ÌÍÎÏ')
IDENT_RE = re.compile(r'^[A-Za-z_<][A-Za-z0-9_<>`+,]*$')


def get_pool_str(dec: bytes, idx: int) -> str | None:
    if not (0 <= idx < STRING_POOL_SIZE):
        return None
    off = STRING_POOL_OFF + idx
    end = dec.find(b'\x00', off, off + 200)
    if end <= off:
        return None
    try:
        return dec[off:end].decode('latin1', errors='replace')
    except Exception:
        return None


def is_real_name(s: str | None) -> bool:
    if not s or len(s) > 100:
        return False
    if any(c in OBF_CHARS for c in s):
        return False
    return bool(IDENT_RE.match(s))


def main() -> None:
    print(f'[+] reading {DEC_PATH}')
    dec = DEC_PATH.read_bytes()

    print(f'[+] opening dump {DUMP_PATH.name}')
    dr = DumpReader(str(DUMP_PATH))

    print(f'[+] loading {PRECISE.name}')
    precise = json.loads(PRECISE.read_text(encoding='utf-8'))

    # Build TypeDef row -> (ns, name) lookup
    print('[+] building TypeDef table lookup ...')
    typedef_by_row: dict[int, tuple[str | None, str | None]] = {}
    typedef_by_token: dict[int, tuple[str | None, str | None]] = {}
    real_count = 0

    # Tokens reset to 0x02000001 at each assembly boundary, so we accumulate
    # every (token -> [(ns, name)]) seen. Lookup-by-token then yields multiple
    # candidates when several assemblies share a row index. We disambiguate
    # later via the runtime class's image pointer (or namespace match).
    addr = TYPEDEF_TABLE_BASE
    consec_invalid = 0
    rows_parsed = 0
    typedef_candidates: dict[int, list[tuple[str | None, str | None, int]]] = {}
    while addr + TYPEDEF_STRIDE <= len(dec):
        token = struct.unpack_from('<I', dec, addr + TYPEDEF_TOKEN_OFF)[0]
        if (token >> 24) != 0x02:
            consec_invalid += 1
            if consec_invalid > 32:
                break
            addr += TYPEDEF_STRIDE
            continue
        consec_invalid = 0
        ni = struct.unpack_from('<i', dec, addr + TYPEDEF_NAME_OFF)[0]
        nsi = struct.unpack_from('<i', dec, addr + TYPEDEF_NS_OFF)[0]
        n = get_pool_str(dec, ni) if ni >= 0 else None
        ns = get_pool_str(dec, nsi) if nsi >= 0 else None
        typedef_candidates.setdefault(token, []).append((ns, n, addr))
        if is_real_name(n):
            real_count += 1
        rows_parsed += 1
        addr += TYPEDEF_STRIDE

    typedef_by_token = typedef_candidates  # rename for downstream use
    print(f'    parsed {rows_parsed} TypeDef rows; {len(typedef_by_token)} distinct tokens')
    print(f'    real-name rows: {real_count}')

    # Walk runtime classes; read token at +0x11C and try to lift
    print('[+] linking runtime classes via token ...')
    lifts: dict[str, str] = {}     # obf_class_name -> real_name
    class_log: list[str] = []
    examined = 0
    matched = 0
    no_token = 0
    out_of_range = 0
    real_lift = 0
    fqdn_lift: dict[str, str] = {}

    for ns_classes in precise['namespaces'].values():
        for cls in ns_classes:
            obf_name = cls['name']
            va_str = cls.get('va')
            if not va_str:
                continue
            try:
                va = int(va_str, 16)
            except (ValueError, TypeError):
                continue
            token = dr.ru32(va + CLASS_TOKEN_OFF)
            if token is None or token == 0:
                no_token += 1
                continue
            if (token >> 24) != 0x02:
                no_token += 1
                continue
            candidates = typedef_by_token.get(token, [])
            if not candidates:
                out_of_range += 1
                continue
            # Pick first real-name candidate; if multiple, prefer one whose
            # namespace is non-None (Beebyte often leaves ns intact even when
            # name is obfuscated).
            real_name = None
            ns = None
            for cand_ns, cand_name, _ in candidates:
                if is_real_name(cand_name):
                    real_name = cand_name
                    ns = cand_ns
                    break
            if real_name is None:
                # Fall back to the first candidate even if obf, just to log
                ns, real_name, _ = candidates[0]
            examined += 1
            if not is_real_name(real_name):
                continue
            if real_name == obf_name:
                continue
            matched += 1
            if not (any(c in OBF_CHARS for c in obf_name) or
                    re.match(r'^(AsyncStateMachine|VRCNetworkBehaviour|Delegate|'
                             r'LifecycleComponent|EmptyStruct|EmptyType|'
                             r'UpdateComponent|FBase|BaseClass|ComplexComponent|'
                             r'MajorSystem|Class_|Type_|NestedType_|GenericArg_|'
                             r'BackingField|PointerEnter|Static|UIk__|k__BackingField)',
                             obf_name)):
                # already has a real-looking name; still record FQDN for confirmation
                fqdn_lift[obf_name] = f'{ns}.{real_name}' if ns else real_name
                continue
            real_lift += 1
            lifts[obf_name] = real_name
            if len(class_log) < 1000:
                class_log.append(f'- `{obf_name}` (token 0x{token:08X}) -> **{real_name}** (ns={ns})')

    print(f'    runtime classes examined : {examined}')
    print(f'    real-name lifts (renames): {real_lift}')
    print(f'    confirmation matches     : {len(fqdn_lift)}')
    print(f'    no usable token          : {no_token}')
    print(f'    token row out of range   : {out_of_range}')

    OUT_LIFTS.parent.mkdir(parents=True, exist_ok=True)
    OUT_LIFTS.write_text(
        json.dumps(
            {
                'lifts': lifts,
                'fqdn_lift_confirmations': fqdn_lift,
                'lift_count': len(lifts),
                'examined': examined,
                'no_token': no_token,
                'out_of_range': out_of_range,
            },
            indent=2,
            ensure_ascii=False,
        ),
        encoding='utf-8',
    )

    OUT_LOG.write_text(
        '\n'.join([
            '# TypeDef Token Lift Trace', '',
            f'lifts: {len(lifts)}',
            f'examined: {examined}',
            f'fqdn confirmations: {len(fqdn_lift)}',
            '', '## First 1000 lifts',
        ] + class_log),
        encoding='utf-8',
    )

    print(f'    -> {OUT_LIFTS}')
    print(f'    -> {OUT_LOG}')


if __name__ == '__main__':
    main()
