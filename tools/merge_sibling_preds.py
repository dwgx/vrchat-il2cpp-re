#!/usr/bin/env python3
"""Merge sibling-context predictions into cross_version_method_names.json.

Similar to merge_codex_preds.py but for sibling_preds/ output.
Applies quality filters then merges into cross_version.
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
PRED_DIR = BASE / "output" / "sibling_preds"
CV_PATH = BASE / "output" / "cross_version_method_names.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")

GENERIC_BLACKLIST = {
    "method", "function", "func", "dowork", "process", "handle", "execute",
    "run", "call", "invoke", "action", "callback", "helper", "utility",
    "wrapper", "manager", "controller", "unknown", "test", "temp",
    "method1", "method2", "method3", "mymethod", "foo", "bar",
}

CSHARP_BOILERPLATE = {
    "equals", "tostring", "gethashcode", "movenext", "dispose",
    "setstatemachine", "getcurrent", "reset", "clone", "compareto",
    "gettype", "finalize", "memberwiseclone",
}


def main():
    if not PRED_DIR.exists():
        print("No sibling_preds/ directory. Run sibling_api_worker.py first.")
        sys.exit(1)

    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))
    original_count = len(cv)

    # Load all predictions
    pred_files = sorted(PRED_DIR.glob("pred_*.json"))
    print(f"Pred files: {len(pred_files)}")

    all_preds = {}
    for pf in pred_files:
        try:
            preds = json.loads(pf.read_text(encoding="utf-8"))
            all_preds.update(preds)
        except (json.JSONDecodeError, UnicodeDecodeError) as e:
            print(f"  Error reading {pf.name}: {e}")

    print(f"Raw predictions: {len(all_preds):,}")

    # Filter
    filtered = {}
    blocked_generic = 0
    blocked_boilerplate = 0
    blocked_existing = 0
    blocked_invalid = 0

    for key, name in all_preds.items():
        if not isinstance(name, str) or len(name) < 2:
            blocked_invalid += 1
            continue
        if key in cv:
            blocked_existing += 1
            continue
        name_lower = name.lower().replace("_", "")
        if name_lower in GENERIC_BLACKLIST:
            blocked_generic += 1
            continue
        if name_lower in CSHARP_BOILERPLATE:
            blocked_boilerplate += 1
            continue
        # Name must be valid C# identifier-ish
        if not re.match(r'^[a-zA-Z_][a-zA-Z0-9_.]*$', name):
            if not name.startswith(("get_", "set_", "op_", "System.", "add_", "remove_")):
                blocked_invalid += 1
                continue
        filtered[key] = name

    print(f"Blocked - generic: {blocked_generic}")
    print(f"Blocked - boilerplate: {blocked_boilerplate}")
    print(f"Blocked - existing: {blocked_existing}")
    print(f"Blocked - invalid: {blocked_invalid}")
    print(f"After filter: {len(filtered):,}")

    # Per-class dedup: max 2 of same name per class
    per_class = defaultdict(Counter)
    for key, name in filtered.items():
        cls = key.rsplit("::", 1)[0]
        per_class[cls][name] += 1

    dup_keys = set()
    for cls, counts in per_class.items():
        for name, count in counts.items():
            if count > 2:
                matches = [k for k, v in filtered.items()
                           if k.startswith(f"{cls}::") and v == name]
                dup_keys.update(matches[2:])  # keep first 2

    for key in dup_keys:
        filtered.pop(key, None)
    if dup_keys:
        print(f"Per-class dedup (>2): {len(dup_keys):,}")

    # Global frequency cap
    freq = Counter(filtered.values())
    too_frequent = {n for n, c in freq.items() if c > 50}
    if too_frequent:
        before = len(filtered)
        filtered = {k: v for k, v in filtered.items() if v not in too_frequent}
        print(f"Global freq cap (>50): {before - len(filtered):,}")
        print(f"  Names: {', '.join(sorted(too_frequent)[:10])}")

    # Merge
    added = 0
    for key, name in sorted(filtered.items()):
        if key not in cv:
            cv[key] = name
            added += 1

    print(f"\nAdded: {added:,}")
    print(f"Total cross_version: {len(cv):,} (was {original_count:,})")

    if added == 0:
        print("Nothing to merge.")
        return

    # Save
    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup = CV_PATH.with_name(f"{CV_PATH.stem}.pre_sibling_{timestamp}{CV_PATH.suffix}")
    shutil.copy2(CV_PATH, backup)
    tmp = CV_PATH.with_suffix(".tmp")
    with open(tmp, "w", encoding="utf-8") as f:
        json.dump(cv, f, indent=2, ensure_ascii=False)
    tmp.replace(CV_PATH)
    print(f"Backup: {backup.name}")

    name_counts = Counter(filtered.values())
    print(f"\nTop predicted names:")
    for name, count in name_counts.most_common(20):
        print(f"  {name}: {count}")


if __name__ == "__main__":
    main()
