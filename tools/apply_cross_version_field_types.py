#!/usr/bin/env python3
"""Fill remaining field types by cross-version class mapping."""

from __future__ import annotations

import argparse
import json
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_CLASS_MAP = BASE_DIR / "data" / "class_map_old_to_new.json"
FALLBACK_CLASS_MAP = BASE_DIR / "output" / "class_map_old_to_new.json"
DEFAULT_FIELD_TYPES_NEW = BASE_DIR / "field_types_NEW.json"
DEFAULT_PRECISE_NEW = BASE_DIR / "precise_dump_NEW.json"
DEFAULT_DEOBF = BASE_DIR / "output" / "deobfuscated_dump.json"


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Apply cross-version field types into deobfuscated_dump.json."
    )
    parser.add_argument("--class-map", default=str(DEFAULT_CLASS_MAP))
    parser.add_argument("--field-types-new", default=str(DEFAULT_FIELD_TYPES_NEW))
    parser.add_argument("--precise-new", default=str(DEFAULT_PRECISE_NEW))
    parser.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    return parser.parse_args()


def load_json(path: Path) -> dict:
    with path.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def resolve_class_map_path(raw_path: str) -> Path:
    requested = Path(raw_path)
    if requested.exists():
        return requested
    if requested == DEFAULT_CLASS_MAP and FALLBACK_CLASS_MAP.exists():
        return FALLBACK_CLASS_MAP
    return requested


def parse_va(value: object) -> int | None:
    if not value:
        return None
    try:
        va = int(str(value), 16)
    except ValueError:
        return None
    return va if va > 0 else None


def fmt_va(va: int) -> str:
    return f"0x{va:X}"


def build_precise_new_index(data: dict) -> dict[str, str]:
    out: dict[str, str] = {}
    for namespace, classes in data.get("namespaces", {}).items():
        for cls in classes:
            va = parse_va(cls.get("va"))
            name = cls.get("name", "") or ""
            if not va or not name:
                continue
            fullname = f"{namespace}.{name}" if namespace else name
            out.setdefault(fullname, fmt_va(va))
    return out


def build_field_types_by_va(field_types: dict, precise_new_index: dict[str, str]) -> dict[str, dict]:
    by_va: dict[str, dict] = {}
    for key, cls in (field_types.get("classes") or {}).items():
        va = parse_va(cls.get("va"))
        if not va:
            namespace = cls.get("namespace", "") or ""
            name = cls.get("name", "") or key or ""
            fullname = f"{namespace}.{name}" if namespace else name
            va_text = precise_new_index.get(fullname)
            va = parse_va(va_text)
        if not va:
            continue
        by_va.setdefault(fmt_va(va), cls)
    return by_va


def is_real_type(type_name: object) -> bool:
    if not isinstance(type_name, str):
        return False
    if not type_name or type_name in {"?", "object", "..."}:
        return False
    if type_name.startswith("err:") or type_name.startswith("type_0x"):
        return False
    return True


def is_patchable_field(field: object) -> bool:
    if isinstance(field, str):
        return True
    if isinstance(field, dict):
        return not is_real_type(field.get("type"))
    return False


def count_untyped_fields(dump: dict) -> tuple[int, int, list[str]]:
    leftover = 0
    classes_with_leftover = 0
    samples: list[str] = []
    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            has_leftover = False
            for field in cls.get("fields") or []:
                if is_patchable_field(field):
                    leftover += 1
                    has_leftover = True
            if has_leftover:
                classes_with_leftover += 1
                if len(samples) < 3:
                    name = cls.get("name", "") or ""
                    fullname = f"{namespace}.{name}" if namespace else name
                    samples.append(fullname)
    return leftover, classes_with_leftover, samples


def count_coverage(dump: dict) -> tuple[int, int]:
    typed = 0
    total = 0
    for classes in dump.get("namespaces", {}).values():
        for cls in classes:
            for field in cls.get("fields") or []:
                total += 1
                if isinstance(field, dict) and is_real_type(field.get("type")):
                    typed += 1
    return typed, total


def patch_dump(
    dump: dict,
    class_map: dict,
    field_types_by_va: dict[str, dict],
) -> dict[str, object]:
    stats = {
        "classes_examined": 0,
        "classes_patched": 0,
        "fields_newly_typed": 0,
        "classes_missing_map": 0,
        "classes_missing_new_fields": 0,
        "field_count_mismatch": 0,
    }

    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            fields = cls.get("fields") or []
            if not fields or not any(is_patchable_field(field) for field in fields):
                continue

            stats["classes_examined"] += 1
            old_va = fmt_va(parse_va(cls.get("va")) or 0) if parse_va(cls.get("va")) else ""
            mapping = class_map.get(old_va)
            if not mapping:
                stats["classes_missing_map"] += 1
                continue

            new_va = mapping.get("new_va")
            if not isinstance(new_va, str):
                stats["classes_missing_map"] += 1
                continue

            ft_cls = field_types_by_va.get(new_va)
            ft_fields = (ft_cls or {}).get("fields") or []
            if not ft_fields:
                stats["classes_missing_new_fields"] += 1
                continue
            if len(fields) != len(ft_fields):
                stats["field_count_mismatch"] += 1

            patched_here = 0
            limit = min(len(fields), len(ft_fields))
            for idx in range(limit):
                target_field = fields[idx]
                source_field = ft_fields[idx]
                source_type = source_field.get("t", source_field.get("type"))
                if not is_patchable_field(target_field) or not is_real_type(source_type):
                    continue

                source_name = source_field.get("n", source_field.get("name", "field"))
                source_offset = source_field.get("o", source_field.get("offset", 0))

                if isinstance(target_field, str):
                    fields[idx] = {
                        "name": target_field or source_name,
                        "type": source_type,
                        "offset": source_offset,
                    }
                else:
                    updated = dict(target_field)
                    if not updated.get("name"):
                        updated["name"] = source_name
                    updated["type"] = source_type
                    if not updated.get("offset"):
                        updated["offset"] = source_offset
                    fields[idx] = updated
                patched_here += 1

            if patched_here:
                stats["classes_patched"] += 1
                stats["fields_newly_typed"] += patched_here

    leftover, leftover_classes, leftover_samples = count_untyped_fields(dump)
    typed, total = count_coverage(dump)
    stats["leftover_untyped"] = leftover
    stats["leftover_classes"] = leftover_classes
    stats["leftover_samples"] = leftover_samples
    stats["typed_fields"] = typed
    stats["total_fields"] = total
    return stats


def main() -> int:
    args = parse_args()

    class_map_path = resolve_class_map_path(args.class_map)
    class_map = load_json(class_map_path)
    field_types_new = load_json(Path(args.field_types_new))
    precise_new = load_json(Path(args.precise_new))
    deobf = load_json(Path(args.deobf))

    precise_new_index = build_precise_new_index(precise_new)
    field_types_by_va = build_field_types_by_va(field_types_new, precise_new_index)

    print(f"[+] Class map: {class_map_path}")
    print(f"[+] Class map entries: {len(class_map):,}")
    print(f"[+] Apr 25 field-type classes indexed by VA: {len(field_types_by_va):,}")

    stats = patch_dump(deobf, class_map, field_types_by_va)

    with Path(args.deobf).open("w", encoding="utf-8") as handle:
        json.dump(deobf, handle, indent=2, ensure_ascii=False)

    print(f"[+] Wrote {args.deobf}")
    print(f"    classes patched: {stats['classes_patched']:,}")
    print(f"    fields newly typed: {stats['fields_newly_typed']:,}")
    print(f"    leftover untyped: {stats['leftover_untyped']:,}")
    print(
        f"    typed fields: {stats['typed_fields']:,}/{stats['total_fields']:,} "
        f"({(stats['typed_fields'] / stats['total_fields'] * 100.0) if stats['total_fields'] else 0.0:.2f}%)"
    )
    if stats["leftover_samples"]:
        print("    sample leftover classes:")
        for name in stats["leftover_samples"]:
            print(f"      - {name}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
