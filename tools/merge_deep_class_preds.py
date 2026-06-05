#!/usr/bin/env python3
"""Merge deep class API predictions into cross_version_method_names.json."""
import json
import re
import shutil
import sys
from collections import Counter, defaultdict
from datetime import datetime
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output/llm_batches_deep_class"
CV_PATH = BASE / "output/cross_version_method_names.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
VALID_RE = re.compile(r"^[A-Za-z_][A-Za-z0-9_]{2,79}$")
PROP_RE = re.compile(r"^[gs]et_[A-Z][A-Za-z0-9]{2,79}$")

GENERIC = {
    "action", "callback", "call", "check", "data", "dowork", "event",
    "execute", "func", "function", "get", "getvalue", "handle", "helper",
    "info", "init", "initialize", "invoke", "main", "method", "process",
    "run", "set", "setvalue", "setup", "start", "test", "unknown",
    "update", "utility", "wrapper",
}
GENERIC_PREFIXES = (
    "HandleUnknown",
    "ProcessUnknown",
    "ExecuteUnknown",
    "DoUnknown",
    "Unknown",
)
BAD_PREFIXES = ("sub_", "loc_", "unk_", "nullsub_")


def load_json(path: Path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def normalize_name(name: str) -> str:
    return name.strip()


def is_valid_key(key: str) -> bool:
    if not isinstance(key, str) or "::" not in key:
        return False
    cls, method = key.rsplit("::", 1)
    return bool(cls) and bool(HASH_RE.match(method))


def is_valid_name(name: str) -> tuple[bool, str]:
    if not isinstance(name, str):
        return False, "not_string"
    name = normalize_name(name)
    if not VALID_RE.match(name):
        return False, "bad_format"
    if HASH_RE.match(name):
        return False, "still_hash"
    low = name.lower()
    if low in GENERIC:
        return False, "generic"
    if low.startswith(BAD_PREFIXES):
        return False, "ida_name"
    if name.startswith(GENERIC_PREFIXES):
        return False, "unknown_generic"
    if len(name) < 4 or len(name) > 80:
        return False, "bad_length"
    if not (name[0].isupper() or PROP_RE.match(name)):
        return False, "not_csharp_style"
    if re.search(r"m_[0-9A-Fa-f]{3}", name):
        return False, "contains_hash"
    if re.search(r"(Method|Function|Callback|Handler)$", name) and len(name) <= 12:
        return False, "generic_suffix"
    return True, "ok"


def main() -> None:
    cv = load_json(CV_PATH)
    if not isinstance(cv, dict):
        raise TypeError(f"{CV_PATH} is not a JSON object")

    pred_files = sorted(BATCH_DIR.glob("pred_*.json"))
    if not pred_files:
        print("No predictions. Run tools/run_deep_class_api.py first.")
        return

    emitted = 0
    kept = {}
    rejected = Counter()
    rejected_samples = defaultdict(list)

    for pred_file in pred_files:
        try:
            data = load_json(pred_file)
        except Exception as exc:
            rejected["unreadable_file"] += 1
            if len(rejected_samples["unreadable_file"]) < 5:
                rejected_samples["unreadable_file"].append(f"{pred_file.name}: {exc}")
            continue
        if not isinstance(data, dict):
            rejected["non_object_file"] += 1
            continue
        for key, value in data.items():
            emitted += 1
            if not is_valid_key(key):
                rejected["bad_key"] += 1
                continue
            name = normalize_name(value) if isinstance(value, str) else value
            valid, reason = is_valid_name(name)
            if not valid:
                rejected[reason] += 1
                if len(rejected_samples[reason]) < 5:
                    rejected_samples[reason].append(f"{key!r} -> {value!r}")
                continue
            kept[key] = name

    per_class = defaultdict(Counter)
    for key, name in kept.items():
        cls = key.rsplit("::", 1)[0]
        per_class[cls][name] += 1

    duplicate_keys = set()
    for cls, counts in per_class.items():
        for name, count in counts.items():
            if count > 3:
                duplicate_keys.update(k for k, v in kept.items() if k.startswith(f"{cls}::") and v == name)
    for key in duplicate_keys:
        kept.pop(key, None)
    if duplicate_keys:
        rejected["per_class_duplicate"] += len(duplicate_keys)

    freq = Counter(kept.values())
    too_frequent = {name for name, count in freq.items() if count > 20}
    if too_frequent:
        before = len(kept)
        kept = {key: name for key, name in kept.items() if name not in too_frequent}
        rejected["global_duplicate"] += before - len(kept)

    added = 0
    skipped_existing = 0
    for key, name in sorted(kept.items()):
        if key in cv:
            skipped_existing += 1
            continue
        cv[key] = name
        added += 1

    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup_path = CV_PATH.with_name(f"{CV_PATH.stem}.pre_deep_class_{timestamp}{CV_PATH.suffix}")
    shutil.copy2(CV_PATH, backup_path)
    tmp_path = CV_PATH.with_suffix(".tmp")
    with open(tmp_path, "w", encoding="utf-8") as handle:
        json.dump(cv, handle, indent=2, ensure_ascii=False)
    tmp_path.replace(CV_PATH)

    report = {
        "prediction_files": len(pred_files),
        "emitted": emitted,
        "valid_after_filter": len(kept),
        "added": added,
        "skipped_existing": skipped_existing,
        "rejected": dict(rejected),
        "backup": str(backup_path),
    }
    with open(BATCH_DIR / "merge_report.json", "w", encoding="utf-8") as handle:
        json.dump(report, handle, indent=1, ensure_ascii=False)

    print(f"Prediction files: {len(pred_files)}")
    print(f"Predictions emitted: {emitted}")
    print(f"Valid after filters: {len(kept)}")
    print(f"Added to cross_version: {added}")
    print(f"Skipped existing keys: {skipped_existing}")
    print(f"Backup: {backup_path}")
    if rejected:
        print("Rejected:")
        for reason, count in rejected.most_common():
            print(f"  {reason}: {count}")
    if rejected_samples:
        print("Rejection samples:")
        for reason, samples in list(rejected_samples.items())[:8]:
            print(f"  {reason}:")
            for sample in samples:
                print(f"    {sample}")


if __name__ == "__main__":
    main()
