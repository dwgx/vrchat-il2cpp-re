#!/usr/bin/env python3
"""RVA cascade: propagate names within hash-only RVA groups.

After sibling-context LLM naming adds new names, run this to propagate
those names to all hash methods sharing the same RVA.

Same function pointer = same function. If we name m_A1F as "GetPosition"
in one class, every other class with m_XXX at the same RVA gets "GetPosition".
"""
import json
import re
import shutil
import sys
from collections import Counter, defaultdict
from datetime import datetime
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE / "output" / "deobfuscated_dump.json"
CV_PATH = BASE / "output" / "cross_version_method_names.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")


def main():
    dump = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))
    original_count = len(cv)

    # Build RVA -> list of (key, is_named, name)
    rva_groups = defaultdict(list)

    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            cname = cls.get("name", "")
            pointers = cls.get("method_pointers", {})
            methods = cls.get("methods", [])

            for mname in methods:
                if not isinstance(mname, str):
                    continue
                rva = pointers.get(mname, "")
                if not rva:
                    continue
                key = f"{cname}::{mname}"
                if HASH_RE.match(mname):
                    if key in cv:
                        rva_groups[rva].append((key, True, cv[key]))
                    else:
                        rva_groups[rva].append((key, False, None))

    # Find groups where SOME are named (from cv) and SOME are not
    cascade_candidates = 0
    added = 0
    class_name_used = defaultdict(set)

    # Pre-populate class_name_used from cv
    for key, name in cv.items():
        cls = key.rsplit("::", 1)[0]
        class_name_used[cls].add(name)

    for rva, entries in rva_groups.items():
        named = [(k, n) for k, is_n, n in entries if is_n]
        unnamed = [k for k, is_n, n in entries if not is_n]

        if not named or not unnamed:
            continue

        # Pick consensus name
        name_counts = Counter(n for _, n in named)
        best_name, _ = name_counts.most_common(1)[0]

        cascade_candidates += len(unnamed)

        for key in unnamed:
            cls = key.rsplit("::", 1)[0]
            if best_name in class_name_used[cls]:
                continue
            cv[key] = best_name
            class_name_used[cls].add(best_name)
            added += 1

    print(f"Cascade candidates: {cascade_candidates:,}")
    print(f"Added (deduped per-class): {added:,}")
    print(f"Total cross_version: {len(cv):,} (was {original_count:,})")

    if added == 0:
        print("Nothing to cascade. Run after adding new names from sibling-context.")
        return

    # Save
    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup = CV_PATH.with_name(f"{CV_PATH.stem}.pre_cascade_{timestamp}{CV_PATH.suffix}")
    shutil.copy2(CV_PATH, backup)
    tmp = CV_PATH.with_suffix(".tmp")
    with open(tmp, "w", encoding="utf-8") as f:
        json.dump(cv, f, indent=2, ensure_ascii=False)
    tmp.replace(CV_PATH)
    print(f"Backup: {backup.name}")

    name_counts = Counter(
        cv[k] for rva, entries in rva_groups.items()
        for k, is_n, n in entries
        if not is_n and k in cv
    )
    print(f"\nTop cascaded names:")
    for name, count in name_counts.most_common(15):
        print(f"  {name}: {count}")


if __name__ == "__main__":
    main()
