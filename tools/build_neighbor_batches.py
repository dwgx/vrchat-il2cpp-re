#!/usr/bin/env python3
"""Build neighbor-context method naming batches.

Reads output/deobfuscated_dump.json and emits one-class batches under
output/llm_batches_neighbor/. Each batch contains up to 10 hash methods from a
single class plus all named sibling methods for context.
"""
from __future__ import annotations

import json
import re
import sys
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
OUTPUT = BASE / "output"
DUMP_PATH = OUTPUT / "deobfuscated_dump.json"
BATCH_DIR = OUTPUT / "llm_batches_neighbor"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")


def is_hash_method(name: object) -> bool:
    return isinstance(name, str) and bool(HASH_RE.match(name))


def method_name(method: object) -> str:
    if isinstance(method, str):
        return method
    if isinstance(method, dict):
        name = method.get("name")
        return name if isinstance(name, str) else ""
    return ""


def chunked(items: list[str], size: int) -> list[list[str]]:
    return [items[i : i + size] for i in range(0, len(items), size)]


def main() -> None:
    if not DUMP_PATH.exists():
        raise SystemExit(f"Missing dump: {DUMP_PATH}")

    BATCH_DIR.mkdir(parents=True, exist_ok=True)
    for stale in BATCH_DIR.glob("batch_*.json"):
        stale.unlink()

    dump = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    namespaces = dump.get("namespaces", {})
    if not isinstance(namespaces, dict):
        raise SystemExit("Invalid dump: expected top-level namespaces object")

    batch_index = 0
    total_classes = 0
    total_hash_methods = 0

    for namespace, classes in sorted(namespaces.items(), key=lambda item: item[0]):
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            class_name = cls.get("name", "")
            if not isinstance(class_name, str) or not class_name:
                continue

            methods = [method_name(method) for method in cls.get("methods", [])]
            methods = [name for name in methods if name]
            hash_methods = [name for name in methods if is_hash_method(name)]
            named_methods = [name for name in methods if not is_hash_method(name)]
            if not hash_methods or len(named_methods) < 3:
                continue

            total_classes += 1
            total_hash_methods += len(hash_methods)
            for group in chunked(hash_methods, 10):
                batch = {
                    "namespace": namespace,
                    "class": class_name,
                    "parent": cls.get("parent", ""),
                    "named_methods": named_methods,
                    "hash_methods": group,
                }
                path = BATCH_DIR / f"batch_{batch_index:04d}.json"
                path.write_text(
                    json.dumps(batch, indent=2, ensure_ascii=False) + "\n",
                    encoding="utf-8",
                )
                batch_index += 1

    print(f"Classes with neighbor context: {total_classes}")
    print(f"Hash methods batched: {total_hash_methods}")
    print(f"Total batches created: {batch_index}")
    print(f"Output directory: {BATCH_DIR}")


if __name__ == "__main__":
    main()
