#!/usr/bin/env python3
"""Prepare fallback Codex-style batches and merge local method predictions.

This bridges the two existing batch formats:
- build_llm_method_batches.py emits output/llm_batches/batch_NNN.json with
  hash_keys in "Class::m_XXX" form.
- codex_name_batch.py and local predictors consume output/codex_batch_NNN.json
  with readable_methods, fields, and hash_methods per class.
"""
from __future__ import annotations

import json
import re
import subprocess
import sys
from collections import Counter
from pathlib import Path


BASE = Path(__file__).resolve().parent.parent
OUTPUT = BASE / "output"
LLM_BATCHES = OUTPUT / "llm_batches"
HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
NAME_RE = re.compile(r"^[A-Z][A-Za-z0-9]{2,49}$")
ACCESSOR_RE = re.compile(r"^(get|set)_[A-Z][A-Za-z0-9]{2,49}$")

BAD_NAMES = {
    "Update",
    "Start",
    "Awake",
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
    "Unknown",
}


def load_json(path: Path) -> object:
    return json.loads(path.read_text(encoding="utf-8"))


def build_field_index() -> dict[str, list[str]]:
    dump = load_json(OUTPUT / "deobfuscated_dump.json")
    result: dict[str, list[str]] = {}
    for classes in dump.get("namespaces", {}).values():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            fields = []
            for field in cls.get("fields", []):
                if isinstance(field, dict):
                    name = field.get("name", "")
                    typ = field.get("type", "")
                    if name:
                        fields.append(f"{typ} {name}".strip())
                elif isinstance(field, str):
                    fields.append(field)
            result[cls.get("name", "")] = fields[:20]
    return result


def convert_batches() -> tuple[int, int]:
    field_index = build_field_index()
    batch_files = sorted(LLM_BATCHES.glob("batch_*.json"))
    for old in OUTPUT.glob("codex_batch_*.json"):
        if old.name != "codex_batch_final.json":
            old.unlink()
    for old in OUTPUT.glob("codex_pred_*.json"):
        old.unlink()

    total_methods = 0
    for index, path in enumerate(batch_files):
        records = []
        for item in load_json(path):
            class_name = item["class"]
            hash_methods = []
            for key in item.get("hash_keys", []):
                if not isinstance(key, str) or "::" not in key:
                    continue
                _, method = key.rsplit("::", 1)
                if HASH_RE.match(method):
                    hash_methods.append(method)
            if not hash_methods:
                continue
            total_methods += len(hash_methods)
            records.append(
                {
                    "class": class_name,
                    "parent": item.get("parent", ""),
                    "readable_methods": item.get("known_methods", []),
                    "fields": field_index.get(class_name, []),
                    "hash_methods": hash_methods,
                }
            )
        (OUTPUT / f"codex_batch_{index:03d}.json").write_text(
            json.dumps(records, indent=2, ensure_ascii=False) + "\n",
            encoding="utf-8",
        )
    return len(batch_files), total_methods


def run_local_predictor(batch_count: int) -> None:
    # predict_codex_semantic_batches.py has stronger source-consensus logic than
    # generate_codex_preds_local.py, but its checked-in range is stale.
    script = (
        "import tools.predict_codex_semantic_batches as p\n"
        "exact, hashes = p.load_sources()\n"
        "total = 0\n"
        f"for i in range({batch_count}):\n"
        "    total += p.predict_batch(i, exact, hashes)\n"
        f"print(f'Done: {{total}} total predictions across {batch_count} batches')\n"
    )
    subprocess.run([sys.executable, "-c", script], cwd=BASE, check=True)


def is_valid_name(name: str) -> bool:
    if not isinstance(name, str) or name in BAD_NAMES:
        return False
    if HASH_RE.match(name):
        return False
    if not (NAME_RE.match(name) or ACCESSOR_RE.match(name)):
        return False
    if len(name) < 4 or len(name) > 50:
        return False
    return True


def merge_predictions() -> tuple[int, int, Counter]:
    cv_path = OUTPUT / "cross_version_method_names.json"
    cv = load_json(cv_path)
    before = len(cv)
    candidates: dict[str, str] = {}
    rejected: Counter[str] = Counter()

    for path in sorted(OUTPUT.glob("codex_pred_*.json")):
        data = load_json(path)
        if not isinstance(data, dict):
            continue
        for key, name in data.items():
            if key in cv:
                rejected["already_mapped"] += 1
                continue
            if not isinstance(key, str) or "::" not in key or not HASH_RE.match(key.rsplit("::", 1)[1]):
                rejected["bad_key"] += 1
                continue
            if not is_valid_name(name):
                rejected["bad_name"] += 1
                continue
            candidates[key] = name

    per_class: dict[str, Counter[str]] = {}
    for key, name in candidates.items():
        cls = key.split("::", 1)[0]
        per_class.setdefault(cls, Counter())[name] += 1
    duplicate_names = {
        (cls, name)
        for cls, names in per_class.items()
        for name, count in names.items()
        if count > 3
    }
    if duplicate_names:
        candidates = {
            key: name
            for key, name in candidates.items()
            if (key.split("::", 1)[0], name) not in duplicate_names
        }

    frequent = {name for name, count in Counter(candidates.values()).items() if count > 10}
    if frequent:
        candidates = {key: name for key, name in candidates.items() if name not in frequent}

    cv.update(dict(sorted(candidates.items())))
    cv_path.write_text(json.dumps(cv, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    return len(candidates), len(cv) - before, rejected


def main() -> None:
    batches, methods = convert_batches()
    print(f"Converted {batches} batches with {methods} hash methods")
    run_local_predictor(batches)
    raw_predictions = sum(len(load_json(path)) for path in OUTPUT.glob("codex_pred_*.json"))
    kept, added, rejected = merge_predictions()
    print(f"Raw predictions: {raw_predictions}")
    print(f"Filtered predictions kept: {kept}")
    print(f"New cross-version entries: {added}")
    for reason, count in rejected.most_common():
        print(f"  rejected {reason}: {count}")


if __name__ == "__main__":
    main()
