#!/usr/bin/env python3
"""Merge hexrays round 2 predictions into cross_version_method_names.json."""
import json
import re
import shutil
import sys
from collections import Counter
from datetime import datetime
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output" / "llm_batches_hexrays_r2"
CV_PATH = BASE / "output" / "cross_version_method_names.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
VALID_RE = re.compile(r"^[A-Za-z_][A-Za-z0-9_]{2,79}$")
PROP_RE = re.compile(r"^[gs]et_[A-Z][A-Za-z0-9]{2,79}$")

GENERIC = {
    "action", "callback", "call", "check", "data", "dowork", "event",
    "execute", "func", "function", "get", "getvalue", "handle", "helper",
    "info", "init", "initialize", "invoke", "main", "method", "process",
    "run", "set", "setvalue", "setup", "start", "test", "unknown",
    "update", "utility", "wrapper", "awake", "ondestroy", "onenable",
    "ondisable", "lateupdate", "fixedupdate", "reset",
    "gethashcode", "tostring", "equals", "movenext", "dispose",
}
BAD_PREFIXES = ("sub_", "loc_", "unk_", "nullsub_", "HandleUnknown", "ProcessUnknown")


def is_valid_key(key):
    if "::" not in key:
        return False
    cls, method = key.rsplit("::", 1)
    return bool(cls) and bool(HASH_RE.match(method))


def is_valid_name(name):
    if not isinstance(name, str):
        return False
    name = name.strip()
    if not VALID_RE.match(name):
        return False
    if HASH_RE.match(name):
        return False
    if name.lower() in GENERIC:
        return False
    if name.startswith(BAD_PREFIXES):
        return False
    if len(name) < 4:
        return False
    if not (name[0].isupper() or PROP_RE.match(name)):
        return False
    return True


def main():
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))
    pred_files = sorted(BATCH_DIR.glob("pred_*.json"))
    if not pred_files:
        print("No predictions found.")
        return

    kept = {}
    rejected = Counter()
    total = 0

    for pf in pred_files:
        try:
            data = json.loads(pf.read_text(encoding="utf-8"))
        except Exception:
            rejected["unreadable"] += 1
            continue
        if not isinstance(data, dict):
            continue
        for key, name in data.items():
            total += 1
            if not is_valid_key(key):
                rejected["bad_key"] += 1
            elif not is_valid_name(name):
                rejected["invalid_name"] += 1
            elif key in cv:
                rejected["already_exists"] += 1
            else:
                kept[key] = name.strip()

    freq = Counter(kept.values())
    too_freq = {n for n, c in freq.items() if c > 15}
    if too_freq:
        before = len(kept)
        kept = {k: v for k, v in kept.items() if v not in too_freq}
        rejected["too_frequent"] += before - len(kept)

    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup = CV_PATH.with_name(f"{CV_PATH.stem}.pre_hexrays_r2_{timestamp}{CV_PATH.suffix}")
    shutil.copy2(CV_PATH, backup)

    added = 0
    for key in sorted(kept):
        cv[key] = kept[key]
        added += 1

    tmp = CV_PATH.with_suffix(".tmp")
    tmp.write_text(json.dumps(cv, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    tmp.replace(CV_PATH)

    print(f"Prediction files: {len(pred_files)}")
    print(f"Total predictions: {total}")
    print(f"Valid after filter: {len(kept)}")
    print(f"Added: {added}")
    print(f"Backup: {backup}")
    for reason, count in rejected.most_common():
        print(f"  {reason}: {count}")


if __name__ == "__main__":
    main()
