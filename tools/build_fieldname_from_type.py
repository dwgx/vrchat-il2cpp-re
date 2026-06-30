#!/usr/bin/env python
"""Type-derived field naming (the FIELD-name axis, distinct from class naming).

All prior signals (items 6-13) name CLASSES. This names FIELDS. 32,543 fields are
f_HEX (their Beebyte original names are unrecoverable), counted as non-semantic in
coverage. But a field's TYPE is recoverable from the typed dump, and a field's name
usually mirrors its type (a field of type GameObject -> _gameObject, ApiAvatar ->
_apiAvatar). So derive field names from field types.

ALIGNMENT (verified 204/205): deobfuscated_dump.json stores fields as bare-string
names (f_HEX for obfuscated ones); precise_dump_unity6_typed.json stores the same
class's fields IN THE SAME ORDER with their original obfuscated names + types. So
position-align the f_HEX list to the typed class's obfuscated-named fields and read
the type. Obfuscated type names are themselves resolved through our class-name map
(an obf type that we've since named -> _thatName).

QUALITY FILTER: only meaningful types. Drops BCL primitives (no info), generic
params, async/plumbing machinery (_awaiter/_methodBuilder/_nullable/_action/_func),
and names still carrying obfuscation residue (Sibling/Impl/BackingFie/BaseClassN/
hex tails). Keeps concrete domain + meaningful Unity types.

Result 2026-06-29: 3,549 high-quality field names across 1,118 classes
(_gameObject, _transform, _button, _color, _sprite, _material, _networkManager,
_apiAvatar, ...). See RE_EXTRACT_STRUCTURAL_SIGNALS.md item 14.

Usage:
  python tools/build_fieldname_from_type.py        # writes output/fieldname_from_type.json
"""
import argparse
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
_BEEBYTE = set("ÌÍÎÏ")
FH = re.compile(r'^f_[0-9A-Fa-f]{3,}$')
JUNK = re.compile(r'(Sibling|Impl|BackingFie|BaseClass\d|_[0-9A-F]{2,}\d*$|genericparam)')
LOWVAL = {"_awaiter", "_asyncUniTaskMethodBuilder", "_asyncUniTaskVoidMethodBuilder",
          "_asyncVoidMethodBuilder", "_taskAwaiter", "_nullable", "_action",
          "_func", "_delegate", "_iList"}
PRIM = {"Int32", "Single", "Boolean", "String", "Byte", "Int64", "UInt32",
        "Double", "Object", "Char", "UInt64", "Int16", "UInt16", "SByte",
        "IntPtr", "Decimal", "Void"}


def clean(s):
    return s and not any(ch in _BEEBYTE for ch in s)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--deobf", default=str(BASE / "output" / "deobfuscated_dump.json"))
    ap.add_argument("--typed", default=str(BASE / "data" / "precise_dump_unity6_typed.json"))
    ap.add_argument("--out", default=str(BASE / "output" / "fieldname_from_type.json"))
    args = ap.parse_args()

    deobf = json.loads(Path(args.deobf).read_text(encoding="utf-8"))
    obf2name = {}
    for cl in deobf["namespaces"].values():
        for c in cl:
            o, n = c.get("original_name"), c.get("name", "")
            if o and clean(n):
                obf2name[o] = n

    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))
    tmap = {}
    for cl in typed["namespaces"].values():
        for c in cl:
            ft = c.get("field_types", {})
            if isinstance(ft, dict) and ft:
                tmap[c["name"]] = ft

    def derive(t):
        if not t:
            return None
        core = re.sub(r'<.*>', '', t).strip().split('.')[-1].rstrip('[]')
        if "genericparam" in core or not core:
            return None
        if any(ch in _BEEBYTE for ch in core):
            m = re.match(r'^([ÌÍÎÏ]+)', t)
            if m and m.group(1) in obf2name:
                core = obf2name[m.group(1)]
            else:
                return None
        if core in PRIM or not core[0].isalpha():
            return None
        return "_" + core[0].lower() + core[1:]

    result = {}
    named = 0
    for cl in deobf["namespaces"].values():
        for c in cl:
            o = c.get("original_name")
            flds = c.get("fields", [])
            fhx = [f for f in flds if isinstance(f, str) and FH.match(f)]
            if not fhx or o not in tmap:
                continue
            obf_fields = [(fn, t) for fn, t in tmap[o].items()
                          if any(ch in _BEEBYTE for ch in fn)]
            if len(obf_fields) != len(fhx):  # can't align safely
                continue
            usednames = {f for f in flds if isinstance(f, str) and not FH.match(f)}
            cm = {}
            for fhex, (_ofn, t) in zip(fhx, obf_fields):
                nn = derive(t)
                if not nn or JUNK.search(nn) or re.sub(r'\d+$', '', nn) in LOWVAL:
                    continue
                base, i = nn, 2
                while nn in usednames:
                    nn = f"{base}{i}"
                    i += 1
                usednames.add(nn)
                cm[fhex] = nn
            if cm:
                result[o] = cm
                named += len(cm)
    Path(args.out).write_text(json.dumps(result, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] {named} high-quality type-derived field names across "
          f"{len(result)} classes -> {args.out}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
