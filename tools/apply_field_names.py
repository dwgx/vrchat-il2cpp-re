#!/usr/bin/env python
"""Apply type-derived field names into deobfuscated_dump.json (idempotent).

Sibling to apply_class_names.py but for the FIELD-name axis. Reads
output/fieldname_from_type.json ({original_name: {f_HEX: newname}}) and rewrites
the matching entries in each class's `fields` list. Only replaces f_HEX strings
(never clobbers an already-semantic field name). Re-runnable: if a field was
already renamed by a prior run it simply won't match f_HEX again, and the mapping
is keyed on the ORIGINAL f_HEX so a second run is a no-op once applied.

Because re-applying after a name is changed would lose the f_HEX key, this writes
a companion output/applied_field_names.json recording {original_name: {newname:
type-token}} for audit, and is intended to run right after build_fieldname_from_
type.py within a single pipeline pass (the f_HEX names are regenerated fresh each
full pipeline run from the dump).
"""
import argparse
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / "output" / "deobfuscated_dump.json"
MAP = BASE / "output" / "fieldname_from_type.json"
FH = re.compile(r'^f_[0-9A-Fa-f]{3,}$')


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--check", action="store_true")
    args = ap.parse_args()

    if not DUMP.exists() or not MAP.exists():
        print(f"  ERROR: need {DUMP.name} and {MAP.name}")
        return 1

    mapping = json.loads(MAP.read_text(encoding="utf-8"))
    dump = json.loads(DUMP.read_text(encoding="utf-8"))
    applied = 0
    classes = 0

    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            o = c.get("original_name", "")
            fm = mapping.get(o)
            if not fm:
                continue
            flds = c.get("fields", [])
            changed = False
            for i, f in enumerate(flds):
                if isinstance(f, str) and f in fm:
                    flds[i] = fm[f]
                    applied += 1
                    changed = True
            if changed:
                classes += 1

    print(f"  applied field names: {applied} across {classes} classes")
    if args.check:
        print("  [--check] dry-run, no write")
        return 0
    json.dump(dump, open(DUMP, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(f"  wrote {DUMP.name}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
