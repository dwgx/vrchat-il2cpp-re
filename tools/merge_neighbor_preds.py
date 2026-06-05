#!/usr/bin/env python3
"""Merge neighbor-context API predictions into cross_version_method_names.json."""
from __future__ import annotations

import json
import re
import shutil
import sys
from collections import Counter
from datetime import datetime
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
OUTPUT = BASE / "output"
BATCH_DIR = OUTPUT / "llm_batches_neighbor"
CROSS_VERSION = OUTPUT / "cross_version_method_names.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
PASCAL_RE = re.compile(r"^[A-Z][A-Za-z0-9]{2,59}$")
ACCESSOR_RE = re.compile(r"^(get|set)_[A-Z][A-Za-z0-9]{2,59}$")
PRED_RE = re.compile(r"^pred_(\d{4})\.json$")

GENERIC_NAMES = {
    "Awake",
    "Start",
    "Update",
    "LateUpdate",
    "FixedUpdate",
    "OnEnable",
    "OnDisable",
    "OnDestroy",
    "Initialize",
    "Init",
    "Setup",
    "Process",
    "Execute",
    "Run",
    "Handle",
    "DoWork",
    "Method",
    "Func",
    "Action",
    "Unknown",
    "GetValue",
    "SetValue",
    "GetData",
    "SetData",
    "ProcessData",
    "UpdateState",
    "HandleEvent",
    "InitializeState",
    "GetResult",
    "SetResult",
}


def load_json(path: Path) -> object:
    return json.loads(path.read_text(encoding="utf-8"))


def write_json(path: Path, data: object) -> None:
    path.write_text(json.dumps(data, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


def valid_name(name: object) -> bool:
    if not isinstance(name, str):
        return False
    if name in GENERIC_NAMES:
        return False
    if HASH_RE.match(name):
        return False
    if not (PASCAL_RE.match(name) or ACCESSOR_RE.match(name)):
        return False
    return 3 <= len(name) <= 60


def batch_for_pred(pred_file: Path) -> Path | None:
    match = PRED_RE.match(pred_file.name)
    if not match:
        return None
    path = BATCH_DIR / f"batch_{match.group(1)}.json"
    return path if path.exists() else None


def main() -> None:
    if not CROSS_VERSION.exists():
        raise SystemExit(f"Missing cross-version map: {CROSS_VERSION}")

    cross_version = load_json(CROSS_VERSION)
    if not isinstance(cross_version, dict):
        raise SystemExit("cross_version_method_names.json must be a JSON object")

    total_predictions = 0
    filtered = 0
    merged_candidates: dict[str, str] = {}
    rejected: Counter[str] = Counter()

    for pred_file in sorted(BATCH_DIR.glob("pred_*.json")):
        batch_file = batch_for_pred(pred_file)
        if batch_file is None:
            rejected["missing_batch"] += 1
            continue
        batch = load_json(batch_file)
        preds = load_json(pred_file)
        if not isinstance(batch, dict) or not isinstance(preds, dict):
            rejected["bad_file_shape"] += 1
            continue

        class_name = batch.get("class", "")
        hash_methods = set(batch.get("hash_methods", []))
        if not isinstance(class_name, str) or not class_name:
            rejected["missing_class"] += len(preds)
            continue

        for method, name in preds.items():
            total_predictions += 1
            if not isinstance(method, str) or not HASH_RE.match(method):
                filtered += 1
                rejected["bad_method_key"] += 1
                continue
            if method not in hash_methods:
                filtered += 1
                rejected["method_not_in_batch"] += 1
                continue
            if not valid_name(name):
                filtered += 1
                rejected["generic_or_invalid_name"] += 1
                continue
            key = f"{class_name}::{method}"
            if key in cross_version:
                filtered += 1
                rejected["already_exists"] += 1
                continue
            merged_candidates[key] = name

    per_class: dict[str, Counter[str]] = {}
    for key, name in merged_candidates.items():
        cls = key.split("::", 1)[0]
        per_class.setdefault(cls, Counter())[name] += 1
    class_duplicates = {
        (cls, name)
        for cls, counts in per_class.items()
        for name, count in counts.items()
        if count > 3
    }
    if class_duplicates:
        before = len(merged_candidates)
        merged_candidates = {
            key: name
            for key, name in merged_candidates.items()
            if (key.split("::", 1)[0], name) not in class_duplicates
        }
        removed = before - len(merged_candidates)
        filtered += removed
        rejected["per_class_duplicate_name"] += removed

    frequent_names = {
        name for name, count in Counter(merged_candidates.values()).items() if count > 10
    }
    if frequent_names:
        before = len(merged_candidates)
        merged_candidates = {
            key: name for key, name in merged_candidates.items() if name not in frequent_names
        }
        removed = before - len(merged_candidates)
        filtered += removed
        rejected["too_frequent_name"] += removed

    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    backup = CROSS_VERSION.with_suffix(f".neighbor_backup_{timestamp}.json")
    shutil.copy2(CROSS_VERSION, backup)

    before_count = len(cross_version)
    cross_version.update(dict(sorted(merged_candidates.items())))
    write_json(CROSS_VERSION, cross_version)
    merged = len(cross_version) - before_count

    print(f"Total predictions: {total_predictions}")
    print(f"Filtered: {filtered}")
    print(f"Merged: {merged}")
    print(f"Backup: {backup}")
    for reason, count in rejected.most_common():
        print(f"  {reason}: {count}")


if __name__ == "__main__":
    main()
