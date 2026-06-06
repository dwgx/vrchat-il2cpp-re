#!/usr/bin/env python3
"""RVA propagation v2: allow globally-common names, max 1 per class.

v1 filtered out names appearing >500 globally (GetHashCode, get_Count, etc).
But these ARE correct — same RVA = same function. The filter was too aggressive.

v2 strategy: allow ANY name from RVA match, but enforce:
  - max 1 instance of each name per class (prevents flooding)
  - skip names already in cross_version for that class
  - skip .ctor/.cctor/generic single-word names
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

SKIP_NAMES = {
    ".ctor", ".cctor", "Finalize", "MemberwiseClone", "GetType",
}

GENERIC_NAMES = {
    "action", "callback", "call", "check", "data", "dowork", "event",
    "execute", "func", "function", "get", "getvalue", "handle", "helper",
    "info", "init", "initialize", "invoke", "main", "method", "process",
    "run", "set", "setvalue", "setup", "start", "test", "unknown",
    "update", "utility", "wrapper", "manager", "controller",
}


def main():
    dump = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))
    original_count = len(cv)

    # Pass 1: Build RVA -> best name mapping
    rva_to_names = defaultdict(Counter)
    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            pointers = cls.get("method_pointers", {})
            for mname, rva in pointers.items():
                if not rva or not isinstance(mname, str):
                    continue
                if HASH_RE.match(mname):
                    continue
                if mname in SKIP_NAMES:
                    continue
                if mname.lower() in GENERIC_NAMES:
                    continue
                rva_to_names[rva][mname] += 1

    rva_best_name = {}
    for rva, names in rva_to_names.items():
        best_name, count = names.most_common(1)[0]
        if len(best_name) >= 2:
            rva_best_name[rva] = best_name

    print(f"RVAs with named methods: {len(rva_best_name):,}")

    # Pass 2: collect all candidates (no global freq filter this time)
    candidates = {}
    already_named = 0
    no_rva = 0
    rva_not_found = 0

    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            cname = cls.get("name", "")
            pointers = cls.get("method_pointers", {})
            methods = cls.get("methods", [])

            for mname in methods:
                if not isinstance(mname, str):
                    continue
                if not HASH_RE.match(mname):
                    continue
                key = f"{cname}::{mname}"
                if key in cv:
                    already_named += 1
                    continue
                rva = pointers.get(mname, "")
                if not rva:
                    no_rva += 1
                    continue
                if rva in rva_best_name:
                    candidates[key] = rva_best_name[rva]
                else:
                    rva_not_found += 1

    print(f"Already in cv: {already_named:,}")
    print(f"Without RVA: {no_rva:,}")
    print(f"RVA no match: {rva_not_found:,}")
    print(f"Raw candidates: {len(candidates):,}")

    # Per-class dedup: max 1 instance of each name per class
    class_name_used = defaultdict(set)
    # First record what's already in cv
    for key, name in cv.items():
        cls = key.rsplit("::", 1)[0]
        class_name_used[cls].add(name)

    accepted = {}
    dup_removed = 0
    for key, name in sorted(candidates.items()):
        cls = key.rsplit("::", 1)[0]
        if name in class_name_used[cls]:
            dup_removed += 1
            continue
        class_name_used[cls].add(name)
        accepted[key] = name

    print(f"Per-class dedup removed: {dup_removed:,}")
    print(f"Accepted: {len(accepted):,}")

    # Merge
    for key, name in accepted.items():
        cv[key] = name

    print(f"\nAdded: {len(accepted):,}")
    print(f"Total cross_version: {len(cv):,} (was {original_count:,})")

    # Save with backup
    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup = CV_PATH.with_name(f"{CV_PATH.stem}.pre_rvav2_{timestamp}{CV_PATH.suffix}")
    shutil.copy2(CV_PATH, backup)
    tmp = CV_PATH.with_suffix(".tmp")
    with open(tmp, "w", encoding="utf-8") as f:
        json.dump(cv, f, indent=2, ensure_ascii=False)
    tmp.replace(CV_PATH)
    print(f"Backup: {backup.name}")

    # Stats
    name_counts = Counter(accepted.values())
    print(f"\nTop accepted names:")
    for name, count in name_counts.most_common(30):
        print(f"  {name}: {count}")


if __name__ == "__main__":
    main()
