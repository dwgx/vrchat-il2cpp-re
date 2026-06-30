#!/usr/bin/env python
"""Apply per-method call-target behavioral names into deobfuscated_dump.json.

Reads output/method_calltarget_names.json keyed {obf_class_name: {obf_method_name:
Invoke_Api}}. The build keys methods by their typed-dump obfuscated names (ÌÍÎ...),
but deobf stores methods as m_HEX strings, so we POSITION-ALIGN (verified 27/28 in
item 15): the typed class's method_pointers order matches the deobf class's methods
order. Map obf method name -> its index in the typed method list -> rename the deobf
methods[index] if it is still m_HEX.

Only replaces m_HEX entries (never clobbers an already-semantic method name).
Idempotent within a pipeline pass.
"""
import argparse
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / "output" / "deobfuscated_dump.json"
TYPED = BASE / "data" / "precise_dump_unity6_typed.json"
MAP = BASE / "output" / "method_calltarget_names.json"
MH = re.compile(r'^m_[0-9A-Fa-f]{3,}$')


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--check", action="store_true")
    args = ap.parse_args()
    if not (DUMP.exists() and TYPED.exists() and MAP.exists()):
        print("  ERROR: need deobfuscated_dump.json, typed dump, and map")
        return 1

    mapping = json.loads(MAP.read_text(encoding="utf-8"))
    typed = json.loads(TYPED.read_text(encoding="utf-8"))
    # obf_class -> ordered list of method names (typed)
    torder = {}
    for cl in typed["namespaces"].values():
        for c in cl:
            torder[c["name"]] = list(c.get("method_pointers", {}).keys())

    dump = json.loads(DUMP.read_text(encoding="utf-8"))
    applied = 0
    classes = 0
    skipped_align = 0
    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            o = c.get("original_name", "")
            mm = mapping.get(o)
            if not mm or o not in torder:
                continue
            order = torder[o]
            methods = c.get("methods", [])
            if len(methods) != len(order):
                skipped_align += 1
                continue
            # obf method name -> index
            idx = {nm: i for i, nm in enumerate(order)}
            changed = False
            used = {m for m in methods if isinstance(m, str)}
            for obf_m, newname in mm.items():
                i = idx.get(obf_m)
                if i is None:
                    continue
                if isinstance(methods[i], str) and MH.match(methods[i]):
                    nn, k = newname, 2
                    while nn in used:
                        nn = f"{newname}_{k}"
                        k += 1
                    used.add(nn)
                    methods[i] = nn
                    applied += 1
                    changed = True
            if changed:
                classes += 1

    print(f"  applied behavioral method names: {applied} across {classes} classes")
    if skipped_align:
        print(f"  skipped (method count mismatch): {skipped_align}")
    if args.check:
        print("  [--check] dry-run, no write")
        return 0
    json.dump(dump, open(DUMP, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(f"  wrote {DUMP.name}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
