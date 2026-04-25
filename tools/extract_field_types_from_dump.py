#!/usr/bin/env python3
"""
Offline IL2CPP field extractor for a Windows minidump.

Reads class VAs from data/precise_dump.json, walks the live Il2CppClass data
inside the minidump, resolves field names/types/offsets, and writes
output/field_types.json in the same structure the runtime extractor used.

This dump's field table layout is dump-verified as:
  Il2CppClass + 0x98  -> FieldInfo*
  Il2CppClass + 0x124 -> uint16 field_count
  FieldInfo stride    -> 0x20
  FieldInfo + 0x00    -> char* name
  FieldInfo + 0x08    -> Il2CppClass* owner
  FieldInfo + 0x10    -> Il2CppType*
  FieldInfo + 0x18    -> packed token/offset

The originally documented +0xA0 path in this repo resolves to the parent class
in this dump and does not produce valid field rows.
"""

from __future__ import annotations

import argparse
import json
import struct
import sys
import time
from bisect import bisect_right
from pathlib import Path

from extract_precise_dump import DumpReader

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_DUMP = BASE_DIR / "tools" / "process_dump.dmp"
DEFAULT_PRECISE = BASE_DIR / "data" / "precise_dump.json"
DEFAULT_OUT = BASE_DIR / "output" / "field_types.json"
DEFAULT_STRING_BASE = 0x66DDE040

FIELD_TABLE_OFF = 0x98
FIELD_COUNT_OFF = 0x124
FIELD_STRIDE = 0x20
FIELD_NAME_OFF = 0x00
FIELD_TYPE_OFF = 0x10
FIELD_PACKED_OFF = 0x18

CLASS_META_PTR_OFFSETS = (0x20, 0x30, 0x68)
TYPE_DEPTH_LIMIT = 5
MAX_FIELD_COUNT = 4096

PRIMITIVES = {
    0x01: "void",
    0x02: "bool",
    0x03: "char",
    0x04: "sbyte",
    0x05: "byte",
    0x06: "short",
    0x07: "ushort",
    0x08: "int",
    0x09: "uint",
    0x0A: "long",
    0x0B: "ulong",
    0x0C: "float",
    0x0D: "double",
    0x0E: "string",
    0x16: "TypedByRef",
    0x18: "UIntPtr",
    0x1C: "object",
}


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description="Extract IL2CPP field types from a minidump")
    parser.add_argument("--dump", default=str(DEFAULT_DUMP))
    parser.add_argument("--precise", default=str(DEFAULT_PRECISE))
    parser.add_argument("--out", default=str(DEFAULT_OUT))
    parser.add_argument("--string-base", default=hex(DEFAULT_STRING_BASE))
    return parser.parse_args()


def patch_reader_v2f(dr: DumpReader) -> None:
    dr.va_map.sort()
    starts = [start for start, _, _ in dr.va_map]

    def fast_v2f(va: int) -> int | None:
        idx = bisect_right(starts, va) - 1
        if idx < 0:
            return None
        start, size, file_off = dr.va_map[idx]
        if start <= va < start + size:
            return file_off + (va - start)
        return None

    dr.v2f = fast_v2f  # type: ignore[method-assign]


def load_precise_classes(path: Path) -> list[dict[str, object]]:
    with path.open("r", encoding="utf-8") as f:
        data = json.load(f)

    classes: list[dict[str, object]] = []
    for ns, ns_classes in data["namespaces"].items():
        for cls in ns_classes:
            va_text = cls.get("va")
            if not isinstance(va_text, str) or not va_text.startswith("0x"):
                continue
            classes.append(
                {
                    "namespace": ns or "",
                    "name": cls.get("name", "") or "",
                    "va": int(va_text, 16),
                }
            )
    return classes


def is_reasonable_text(text: str | None) -> bool:
    return bool(text) and len(text) <= 300 and text.isprintable()


def read_cstr(dr: DumpReader, va: int | None, max_len: int = 256) -> str | None:
    if not va or not dr.ok(va):
        return None
    return dr.rstr(va, max_len)


def read_u8(dr: DumpReader, va: int) -> int | None:
    file_off = dr.v2f(va)
    if file_off is None:
        return None
    return dr.mm[file_off]


def build_metadata_maps(
    dr: DumpReader, classes: list[dict[str, object]]
) -> tuple[dict[int, str], dict[int, tuple[str, str]], dict[int, tuple[str, str]]]:
    by_meta_ptr: dict[int, str] = {}
    by_meta_parts: dict[int, tuple[str, str]] = {}
    by_class_va: dict[int, tuple[str, str]] = {}

    for cls in classes:
        va = int(cls["va"])
        ns = str(cls["namespace"])
        name = str(cls["name"])
        full = f"{ns}.{name}" if ns else name
        by_class_va[va] = (ns, name)

        for off in CLASS_META_PTR_OFFSETS:
            meta_ptr = dr.ru64(va + off)
            if not meta_ptr or not dr.ok(meta_ptr):
                continue
            by_meta_ptr.setdefault(meta_ptr, full)
            by_meta_parts.setdefault(meta_ptr, (ns, name))

    return by_meta_ptr, by_meta_parts, by_class_va


def probe_string_base(
    dr: DumpReader,
    by_meta_parts: dict[int, tuple[str, str]],
    default_base: int,
) -> tuple[int, str]:
    samples = list(by_meta_parts.items())[:64]

    def score(base: int) -> int:
        score_value = 0
        for meta_ptr, (ns, name) in samples:
            name_idx = dr.ru32(meta_ptr)
            ns_idx = dr.ru32(meta_ptr + 4)
            if name_idx is None or ns_idx is None:
                continue
            guess_name = read_cstr(dr, base + name_idx, 128)
            guess_ns = read_cstr(dr, base + ns_idx, 128) or ""
            if guess_name == name:
                score_value += 2
            elif is_reasonable_text(guess_name):
                score_value += 1
            if guess_ns == ns:
                score_value += 2
            elif not ns and guess_ns == "":
                score_value += 1
        return score_value

    default_score = score(default_base)
    if default_score > 0:
        return default_base, f"default 0x{default_base:X} (score={default_score})"

    meta_ptrs = list(by_meta_parts)
    if not meta_ptrs:
        return default_base, f"default 0x{default_base:X} (no metadata samples)"

    region_start = min(meta_ptrs) & ~0xFFF
    search_start = max(0, region_start - 0x00800000)
    search_end = region_start + 0x00800000

    best_base = default_base
    best_score = default_score
    for candidate in range(search_start, search_end, 0x1000):
        candidate_score = score(candidate)
        if candidate_score > best_score:
            best_score = candidate_score
            best_base = candidate

    if best_score > 0:
        return best_base, f"scanned 0x{search_start:X}-0x{search_end:X}, selected 0x{best_base:X} (score={best_score})"

    return default_base, f"fallback 0x{default_base:X} (metadata-pointer map used; string-table probe found no exact hits)"


class TypeResolver:
    def __init__(
        self,
        dr: DumpReader,
        string_base: int,
        meta_name_by_ptr: dict[int, str],
        meta_parts_by_ptr: dict[int, tuple[str, str]],
        class_parts_by_va: dict[int, tuple[str, str]],
    ):
        self.dr = dr
        self.string_base = string_base
        self.meta_name_by_ptr = meta_name_by_ptr
        self.meta_parts_by_ptr = meta_parts_by_ptr
        self.class_parts_by_va = class_parts_by_va
        self.type_cache: dict[int, str] = {}
        self.meta_cache: dict[int, str] = {}

    def resolve(self, type_ptr: int | None, depth: int = 0) -> str:
        if depth > TYPE_DEPTH_LIMIT:
            return "..."
        if not type_ptr or not self.dr.ok(type_ptr):
            return "?"
        cached = self.type_cache.get(type_ptr)
        if cached is not None:
            return cached

        packed32 = self.dr.ru32(type_ptr + 8)
        data = self.dr.ru64(type_ptr)
        if packed32 is None:
            return "?"
        type_enum = (packed32 >> 16) & 0xFF

        if type_enum in PRIMITIVES:
            result = PRIMITIVES[type_enum]
        elif type_enum in (0x11, 0x12):
            result = self.resolve_class_or_valuetype(data)
        elif type_enum == 0x15:
            result = self.resolve_generic_inst(data, depth + 1)
        elif type_enum == 0x1D:
            result = self.resolve(data, depth + 1) + "[]"
        elif type_enum == 0x14:
            result = self.resolve_array(data, depth + 1)
        elif type_enum == 0x10:
            result = self.resolve(data, depth + 1) + "&" if self.looks_like_type_ptr(data) else "ByRef"
        elif type_enum == 0x0F:
            result = self.resolve(data, depth + 1) + "*" if self.looks_like_type_ptr(data) else "IntPtr"
        elif type_enum == 0x13:
            result = self.resolve_generic_param(data, "T")
        elif type_enum == 0x1E:
            result = self.resolve_generic_param(data, "TM")
        else:
            result = f"type_0x{type_enum:X}"

        self.type_cache[type_ptr] = result
        return result

    def looks_like_type_ptr(self, ptr: int | None) -> bool:
        if not ptr or not self.dr.ok(ptr) or self.dr.v2f(ptr + 8) is None:
            return False
        packed32 = self.dr.ru32(ptr + 8)
        if packed32 is None:
            return False
        type_enum = (packed32 >> 16) & 0xFF
        return 0 < type_enum <= 0x1E

    def resolve_class_or_valuetype(self, data: int | None) -> str:
        if not data:
            return "?"
        cached = self.meta_cache.get(data)
        if cached is not None:
            return cached

        result = self.meta_name_by_ptr.get(data)
        if result is None and data in self.class_parts_by_va:
            ns, name = self.class_parts_by_va[data]
            result = f"{ns}.{name}" if ns else name
        if result is None:
            result = self.resolve_via_string_table(data)
        if result is None:
            result = f"0x{data:X}"

        self.meta_cache[data] = result
        return result

    def resolve_via_string_table(self, meta_ptr: int) -> str | None:
        name_idx = self.dr.ru32(meta_ptr)
        ns_idx = self.dr.ru32(meta_ptr + 4)
        if name_idx is None or ns_idx is None:
            return None
        name = read_cstr(self.dr, self.string_base + name_idx, 128)
        ns = read_cstr(self.dr, self.string_base + ns_idx, 128) or ""
        if not is_reasonable_text(name):
            return None
        if ns and not is_reasonable_text(ns):
            ns = ""
        return f"{ns}.{name}" if ns else name

    def resolve_generic_inst(self, generic_class_ptr: int | None, depth: int) -> str:
        if not generic_class_ptr or not self.dr.ok(generic_class_ptr):
            return "?<...>"

        generic_def_type = self.dr.ru64(generic_class_ptr)
        base_name = self.resolve(generic_def_type, depth)

        class_inst = self.dr.ru64(generic_class_ptr + 8)
        if not class_inst or not self.dr.ok(class_inst):
            return base_name + "<...>"

        argc = self.dr.ru32(class_inst)
        argv = self.dr.ru64(class_inst + 8)
        if argc is None or argc <= 0 or argc > 16 or not argv or not self.dr.ok(argv):
            return base_name + "<...>"

        args = []
        for idx in range(argc):
            arg_type = self.dr.ru64(argv + idx * 8)
            args.append(self.resolve(arg_type, depth))
        return f"{base_name}<{','.join(args)}>"

    def resolve_array(self, array_type_ptr: int | None, depth: int) -> str:
        if not array_type_ptr or not self.dr.ok(array_type_ptr):
            return "?[]"
        elem_type = self.dr.ru64(array_type_ptr)
        rank = read_u8(self.dr, array_type_ptr + 8)
        elem_name = self.resolve(elem_type, depth)
        if rank is None or rank <= 1:
            return elem_name + "[]"
        return elem_name + "[" + "," * (rank - 1) + "]"

    def resolve_generic_param(self, data: int | None, prefix: str) -> str:
        if not data:
            return prefix

        for off in (0x1C, 0x2C, 0x0, 0x10):
            value = self.dr.ru32(data + off)
            if value is not None and 0 <= value <= 16:
                if prefix == "TM":
                    return "TM" + str(value) if value else "TResult"
                names = ["T", "U", "V", "W", "T4", "T5", "T6", "T7"]
                return names[value] if value < len(names) else f"T{value}"

        if prefix == "TM":
            return "TM"
        return "T"


def extract_fields_for_class(
    dr: DumpReader,
    resolver: TypeResolver,
    cls: dict[str, object],
) -> tuple[list[dict[str, object]] | None, str | None]:
    va = int(cls["va"])
    field_count = dr.ru16(va + FIELD_COUNT_OFF)
    if field_count is None or field_count < 0 or field_count > MAX_FIELD_COUNT:
        return None, "bad_field_count"
    if field_count == 0:
        return [], None

    field_table = dr.ru64(va + FIELD_TABLE_OFF)
    if not field_table or not dr.ok(field_table):
        return None, "bad_field_table"

    fields: list[dict[str, object]] = []
    valid_names = 0

    for index in range(field_count):
        entry = field_table + index * FIELD_STRIDE
        name_ptr = dr.ru64(entry + FIELD_NAME_OFF)
        type_ptr = dr.ru64(entry + FIELD_TYPE_OFF)
        packed = dr.ru64(entry + FIELD_PACKED_OFF) or 0

        name = read_cstr(dr, name_ptr, 256)
        if is_reasonable_text(name):
            valid_names += 1
        else:
            name = f"field_{index}"

        type_name = resolver.resolve(type_ptr)
        offset = packed & 0xFFFF
        fields.append({"n": name, "t": type_name, "o": offset})

    if valid_names == 0:
        return None, "no_valid_field_names"
    return fields, None


def main() -> int:
    args = parse_args()
    dump_path = Path(args.dump)
    precise_path = Path(args.precise)
    out_path = Path(args.out)
    string_base = int(str(args.string_base), 16)

    print("=" * 60)
    print("  Offline Field Type Extractor")
    print("=" * 60)
    print(f"Dump:    {dump_path}")
    print(f"Precise: {precise_path}")
    print(f"Out:     {out_path}")

    t0 = time.time()
    classes = load_precise_classes(precise_path)
    print(f"Loaded {len(classes):,} classes with VAs from precise_dump.json")

    dr = DumpReader(str(dump_path))
    patch_reader_v2f(dr)

    meta_name_by_ptr, meta_parts_by_ptr, class_parts_by_va = build_metadata_maps(dr, classes)
    probed_string_base, probe_note = probe_string_base(dr, meta_parts_by_ptr, string_base)
    resolver = TypeResolver(dr, probed_string_base, meta_name_by_ptr, meta_parts_by_ptr, class_parts_by_va)

    print(f"Metadata pointer map: {len(meta_name_by_ptr):,}")
    print(f"String table probe: {probe_note}")

    output = {
        "summary": {
            "classes": 0,
            "fields": 0,
            "source": "dmp",
        },
        "classes": {},
    }

    processed = 0
    skipped = 0
    duplicate_keys = 0
    skip_reasons: dict[str, int] = {}
    samples: list[tuple[str, list[dict[str, object]]]] = []

    for idx, cls in enumerate(classes, 1):
        ns = str(cls["namespace"])
        name = str(cls["name"])
        va = int(cls["va"])
        key = f"{ns}.{name}" if ns else name

        fields, skip_reason = extract_fields_for_class(dr, resolver, cls)
        if fields is None:
            skipped += 1
            skip_reasons[skip_reason or "unknown"] = skip_reasons.get(skip_reason or "unknown", 0) + 1
            continue

        if key in output["classes"]:
            duplicate_keys += 1
            # Disambiguate by appending va so we don't lose data on
            # fullname collisions (e.g. multiple <>c__DisplayClass).
            key = f"{key}@0x{va:X}"

        output["classes"][key] = {
            "va": f"0x{va:X}",
            "namespace": ns,
            "name": name,
            "fields": fields,
        }
        processed += 1
        output["summary"]["fields"] += len(fields)
        if fields and len(samples) < 3:
            samples.append((key, fields[:5]))

        if idx % 2000 == 0 or idx == len(classes):
            elapsed = time.time() - t0
            rate = idx / elapsed if elapsed > 0 else 0.0
            print(
                f"  {idx:>6}/{len(classes)} classes | "
                f"processed {processed:>6} | skipped {skipped:>5} | "
                f"fields {output['summary']['fields']:>7} | {rate:.0f} cls/s"
            )

    output["summary"]["classes"] = len(output["classes"])

    out_path.parent.mkdir(parents=True, exist_ok=True)
    with out_path.open("w", encoding="utf-8") as f:
        json.dump(output, f, indent=1, ensure_ascii=False)

    elapsed = time.time() - t0
    size_mb = out_path.stat().st_size / (1024 * 1024)

    print()
    print(f"Done in {elapsed:.1f}s")
    print(f"Classes processed: {processed:,}")
    print(f"Classes skipped:   {skipped:,}")
    print(f"Duplicate keys:    {duplicate_keys:,}")
    print(f"Fields extracted:  {output['summary']['fields']:,}")
    print(f"Output size:       {size_mb:.2f} MB")
    print(f"String base used:  0x{probed_string_base:X}")
    if skip_reasons:
        top_reasons = ", ".join(f"{k}={v}" for k, v in sorted(skip_reasons.items(), key=lambda item: (-item[1], item[0]))[:5])
        print(f"Skip reasons:      {top_reasons}")

    if samples:
        print()
        print("Sample classes:")
        for key, sample_fields in samples:
            preview = ", ".join(f"{field['n']}:{field['t']}@0x{int(field['o']):X}" for field in sample_fields[:3])
            print(f"  {key}: {preview}")

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
