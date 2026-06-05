#!/usr/bin/env python3
"""Build LLM batches for hash methods with pseudocode that weren't covered in round 1."""
import json
import os
import re
import sys
from collections import defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
DEOBF_PATH = BASE / "output" / "deobfuscated_dump.json"
HEXRAYS_PATH = BASE / "output" / "v_new_ida" / "hexrays_mass_export.json"
CV_PATH = BASE / "output" / "cross_version_method_names.json"
OUT_DIR = BASE / "output" / "llm_batches_hexrays_r2"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
BATCH_SIZE = 8


def load_json(path):
    with open(path, "r", encoding="utf-8") as f:
        return json.load(f)


def main():
    deobf = load_json(DEOBF_PATH)
    hexrays = load_json(HEXRAYS_PATH)
    cv = load_json(CV_PATH)

    already_named = set(cv.keys())

    hx_by_key = {}
    for info in hexrays.values():
        if not isinstance(info, dict):
            continue
        cls = info.get("class", "")
        method = info.get("method", "")
        pseudo = info.get("pseudocode", "")
        if cls and HASH_RE.match(method) and pseudo:
            key = f"{cls}::{method}"
            if key not in already_named:
                hx_by_key[key] = {
                    "class": cls,
                    "method": method,
                    "pseudocode": pseudo,
                    "namespace": info.get("namespace", ""),
                    "parent": info.get("parent", ""),
                }

    class_named_methods = defaultdict(list)
    for ns, classes in deobf.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            name = cls.get("name", "")
            for m in cls.get("methods", []):
                mn = m if isinstance(m, str) else ""
                if mn and not HASH_RE.match(mn):
                    class_named_methods[name].append(mn)

    by_class = defaultdict(list)
    for key, info in hx_by_key.items():
        by_class[info["class"]].append(info)

    OUT_DIR.mkdir(parents=True, exist_ok=True)
    for old in OUT_DIR.glob("batch_*.json"):
        old.unlink()

    batch_idx = 0
    total_methods = 0

    for cls_name in sorted(by_class.keys()):
        items = by_class[cls_name]
        named = class_named_methods.get(cls_name, [])[:30]

        for i in range(0, len(items), BATCH_SIZE):
            chunk = items[i : i + BATCH_SIZE]
            batch = {
                "class": cls_name,
                "parent": chunk[0].get("parent", ""),
                "namespace": chunk[0].get("namespace", ""),
                "named_methods": named,
                "targets": [
                    {
                        "key": f"{it['class']}::{it['method']}",
                        "method": it["method"],
                        "pseudocode": it["pseudocode"],
                    }
                    for it in chunk
                ],
            }
            path = OUT_DIR / f"batch_{batch_idx:04d}.json"
            with open(path, "w", encoding="utf-8") as f:
                json.dump(batch, f, indent=1, ensure_ascii=False)
            batch_idx += 1
            total_methods += len(chunk)

    print(f"Unique hash methods with unused pseudocode: {len(hx_by_key)}")
    print(f"Classes covered: {len(by_class)}")
    print(f"Batches written: {batch_idx}")
    print(f"Methods in batches: {total_methods}")
    print(f"Output: {OUT_DIR}")


if __name__ == "__main__":
    main()
