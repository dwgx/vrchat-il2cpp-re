#!/usr/bin/env python3
"""Apply LLM field-name predictions into deobfuscated_dump.json."""

from __future__ import annotations

import argparse
import json
import sys
from pathlib import Path
from typing import Any

sys.stdout.reconfigure(encoding="utf-8")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_DUMP = BASE_DIR / "output" / "deobfuscated_dump.json"
DEFAULT_PREDICTIONS = BASE_DIR / "data" / "llm_field_predictions.json"


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dump", default=str(DEFAULT_DUMP))
    parser.add_argument("--predictions", default=str(DEFAULT_PREDICTIONS))
    return parser.parse_args()


def load_json(path: Path) -> Any:
    with path.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def atomic_write_json(path: Path, data: Any) -> None:
    tmp_path = path.with_suffix(path.suffix + ".tmp")
    with tmp_path.open("w", encoding="utf-8") as handle:
        json.dump(data, handle, indent=2, ensure_ascii=False)
    tmp_path.replace(path)


def field_name_of(field: Any) -> str:
    if isinstance(field, dict):
        return str(field.get("name", "") or "")
    return str(field or "")


def main() -> int:
    args = parse_args()
    dump_path = Path(args.dump)
    predictions_path = Path(args.predictions)
    dump = load_json(dump_path)
    predictions: dict[str, dict[str, str | None]] = load_json(predictions_path)

    fields_renamed = 0
    classes_touched = 0

    for classes in dump.get("namespaces", {}).values():
        for cls in classes:
            class_name = str(cls.get("name", "") or "")
            class_predictions = predictions.get(class_name)
            if not class_predictions:
                continue

            touched_here = False
            fields = cls.get("fields") or []
            for index, field in enumerate(fields):
                obf_name = field_name_of(field)
                predicted_name = class_predictions.get(obf_name)
                if not predicted_name or predicted_name == obf_name:
                    continue

                if isinstance(field, dict):
                    updated = dict(field)
                else:
                    updated = {"name": obf_name}
                if updated.get("_orig_obf"):
                    continue
                updated["_orig_obf"] = obf_name
                updated["name"] = predicted_name
                fields[index] = updated
                fields_renamed += 1
                touched_here = True

            if touched_here:
                classes_touched += 1

    atomic_write_json(dump_path, dump)
    print(f"Fields renamed: {fields_renamed:,}")
    print(f"Classes touched: {classes_touched:,}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
