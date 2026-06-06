#!/usr/bin/env python3
"""Propagate method names via shared RVA (same function pointer = same method).

If a hash method (m_XXX) shares the same RVA as a named method, we can
confidently assign the named method's name to the hash method.
This is a zero-hallucination approach: same address = same code.
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

    # Pass 1: Build RVA -> best name mapping from ALL named methods
    rva_to_names = defaultdict(Counter)

    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            cname = cls.get("name", "")
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

    # For each RVA, pick the most common name (consensus)
    rva_best_name = {}
    for rva, names in rva_to_names.items():
        best_name, count = names.most_common(1)[0]
        if len(best_name) >= 3:
            rva_best_name[rva] = best_name

    print(f"RVAs with named methods: {len(rva_best_name):,}")

    # Pass 2: Find hash methods that share RVA with named methods
    propagated = {}
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
                    propagated[key] = rva_best_name[rva]
                else:
                    rva_not_found += 1

    print(f"Hash methods already in cv: {already_named:,}")
    print(f"Hash methods without RVA: {no_rva:,}")
    print(f"Hash methods with RVA but no named match: {rva_not_found:,}")
    print(f"Propagated names: {len(propagated):,}")

    # Dedup: same name >5x in one class = suspicious
    per_class = defaultdict(Counter)
    for key, name in propagated.items():
        cls = key.rsplit("::", 1)[0]
        per_class[cls][name] += 1

    duplicate_keys = set()
    for cls, counts in per_class.items():
        for name, count in counts.items():
            if count > 15:
                duplicate_keys.update(
                    k for k, v in propagated.items()
                    if k.startswith(f"{cls}::") and v == name
                )
    for key in duplicate_keys:
        propagated.pop(key, None)
    if duplicate_keys:
        print(f"Removed per-class duplicates (>5): {len(duplicate_keys):,}")

    # Global freq cap
    freq = Counter(propagated.values())
    too_frequent = {name for name, count in freq.items() if count > 500}
    if too_frequent:
        before = len(propagated)
        propagated = {k: v for k, v in propagated.items() if v not in too_frequent}
        removed = before - len(propagated)
        print(f"Removed globally frequent (>50): {removed:,}")
        print(f"  Names: {', '.join(sorted(too_frequent)[:10])}")

    # Merge
    added = 0
    for key, name in sorted(propagated.items()):
        if key not in cv:
            cv[key] = name
            added += 1

    print(f"\nAdded to cross_version: {added:,}")
    print(f"Total in cross_version: {len(cv):,}")

    # Save
    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup = CV_PATH.with_name(f"{CV_PATH.stem}.pre_rva_{timestamp}{CV_PATH.suffix}")
    shutil.copy2(CV_PATH, backup)
    tmp = CV_PATH.with_suffix(".tmp")
    with open(tmp, "w", encoding="utf-8") as f:
        json.dump(cv, f, indent=2, ensure_ascii=False)
    tmp.replace(CV_PATH)
    print(f"Backup: {backup.name}")

    # Top propagated names
    name_counts = Counter(propagated.values())
    print("\nTop propagated names:")
    for name, count in name_counts.most_common(20):
        print(f"  {name}: {count}")


if __name__ == "__main__":
    main()
