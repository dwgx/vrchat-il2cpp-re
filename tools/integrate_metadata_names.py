#!/usr/bin/env python3
"""Collect metadata names not already used as deobfuscated method names."""

from __future__ import annotations

import json
import time
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
METADATA_NAMES_PATH = ROOT / "data" / "metadata_real_names.json"
DEOBFUSCATED_DUMP_PATH = ROOT / "output" / "deobfuscated_dump.json"
ADDITIONS_PATH = ROOT / "data" / "metadata_vocab_additions.json"


def load_json(path: Path) -> Any:
    with path.open("r", encoding="utf-8") as f:
        return json.load(f)


def method_name_from_record(record: Any) -> str | None:
    if isinstance(record, str):
        return record

    if isinstance(record, dict):
        for key in ("name", "real_name", "deobfuscated_name", "method_name"):
            value = record.get(key)
            if isinstance(value, str):
                return value

    return None


def extract_used_method_names(dump: Any) -> set[str]:
    used: set[str] = set()

    namespaces = dump.get("namespaces", {}) if isinstance(dump, dict) else {}
    if isinstance(namespaces, dict):
        class_groups = namespaces.values()
    elif isinstance(namespaces, list):
        class_groups = [namespaces]
    else:
        class_groups = []

    for classes in class_groups:
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            methods = cls.get("methods", [])
            if not isinstance(methods, list):
                continue
            for method in methods:
                name = method_name_from_record(method)
                if name:
                    used.add(name)

    return used


def normalized_metadata_names(raw_names: Any) -> list[str]:
    if not isinstance(raw_names, list):
        raise TypeError(f"{METADATA_NAMES_PATH} must contain a JSON list")

    names = {
        name.strip()
        for name in raw_names
        if isinstance(name, str) and name.strip()
    }
    return sorted(names)


def main() -> int:
    metadata_names = normalized_metadata_names(load_json(METADATA_NAMES_PATH))
    deobfuscated_dump = load_json(DEOBFUSCATED_DUMP_PATH)
    used_method_names = extract_used_method_names(deobfuscated_dump)

    additions = [
        name for name in metadata_names
        if name not in used_method_names
    ]

    output = {
        "generated_by": "tools/integrate_metadata_names.py",
        "timestamp": time.strftime("%Y-%m-%d %H:%M:%S"),
        "source": str(METADATA_NAMES_PATH.relative_to(ROOT)).replace("\\", "/"),
        "total_metadata_names": len(metadata_names),
        "used_method_names_in_deobfuscated_dump": len(used_method_names),
        "metadata_names_already_used_as_methods": len(metadata_names) - len(additions),
        "metadata_names_added": len(additions),
        "unified_names": additions,
        "method_names": additions,
    }

    with ADDITIONS_PATH.open("w", encoding="utf-8") as f:
        json.dump(output, f, indent=2, ensure_ascii=False)
        f.write("\n")

    print(f"metadata names loaded: {len(metadata_names)}")
    print(f"used method names in deobfuscated_dump: {len(used_method_names)}")
    print(f"metadata names already used as methods: {len(metadata_names) - len(additions)}")
    print(f"metadata names integrated: {len(additions)}")
    print(f"saved to: {ADDITIONS_PATH}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
