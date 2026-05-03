#!/usr/bin/env python3
"""
Reverse-engineer the Il2CppClass layout from a VRChat minidump.

Primary strategy:
1. Find all mapped occurrences of a small set of known class-name strings.
2. Scan for pointers to those string VAs.
3. Derive candidate struct bases from candidate OFF_NAME values.
4. Require two self-references in the first 0xC0 bytes.
5. Probe method/field/count offsets against confirmed known classes.

The script keeps the original nearby-window pass requested by the task, then
falls back to a broader heap ref scan when the nearby pass is too weak.
"""

from __future__ import annotations

import argparse
import json
import mmap
import os
import re
import struct
import sys
import time
from bisect import bisect_right
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_DUMP_PATH = BASE_DIR / "tools" / "VRChat_139620_20260418_180023_full.dmp"
DEFAULT_OUTPUT_PATH = BASE_DIR / "data" / "reverse_struct_report.json"

TARGET_CLASS_NAMES = (
    "MonoBehaviour",
    "GameObject",
    "Transform",
    "Component",
    "NetworkManager",
    "VRCPlayer",
    "Keyboard",
    "Canvas",
    "Il2CppObject",
)

HEAP_VA_START = 0x30000000
HEAP_VA_END = 0x3E000000
NEARBY_WINDOW = 0x4000
SELF_REF_LIMIT = 0xC0
CLASS_SCAN_FOOTPRINT = 0x140

NAME_OFFSET_RANGE = range(0x00, 0x91, 0x08)
SELF_REF_RANGE = range(0x00, SELF_REF_LIMIT, 0x08)
IMAGE_OFFSET_RANGE = range(0x00, 0x91, 0x08)
PARENT_OFFSET_RANGE = range(0x80, 0x181, 0x08)
METHOD_PTR_RANGE = range(0x40, 0x181, 0x08)
FIELD_PTR_RANGE = range(0x80, 0x201, 0x08)
COUNT_RANGE = range(0x100, 0x201, 0x02)
METHOD_NAME_OFFSETS = (0x10, 0x18, 0x20, 0x28, 0x30, 0x38, 0x40, 0x48, 0x50)
FIELD_LAYOUTS = (
    {"FI_STRIDE": 0x18, "FI_NAME": 0x00, "label": "compact_v0"},
    {"FI_STRIDE": 0x18, "FI_NAME": 0x08, "label": "compact_v1"},
    {"FI_STRIDE": 0x18, "FI_NAME": 0x10, "label": "compact_v2"},
    {"FI_STRIDE": 0x20, "FI_NAME": 0x00, "label": "v20_n0"},
    {"FI_STRIDE": 0x20, "FI_NAME": 0x08, "label": "v20_n8"},
    {"FI_STRIDE": 0x20, "FI_NAME": 0x10, "label": "beebyte_v2"},
    {"FI_STRIDE": 0x20, "FI_NAME": 0x18, "label": "v20_n18"},
    {"FI_STRIDE": 0x28, "FI_NAME": 0x10, "label": "v28_n10"},
    {"FI_STRIDE": 0x28, "FI_NAME": 0x18, "label": "v28_n18"},
    {"FI_STRIDE": 0x28, "FI_NAME": 0x20, "label": "v28_n20"},
    {"FI_STRIDE": 0x30, "FI_NAME": 0x00, "label": "v30_n0"},
    {"FI_STRIDE": 0x30, "FI_NAME": 0x08, "label": "v30_n8"},
    {"FI_STRIDE": 0x30, "FI_NAME": 0x10, "label": "vrc_2026"},
    {"FI_STRIDE": 0x30, "FI_NAME": 0x18, "label": "v30_n18"},
    {"FI_STRIDE": 0x30, "FI_NAME": 0x20, "label": "legacy"},
    {"FI_STRIDE": 0x30, "FI_NAME": 0x28, "label": "v30_n28"},
    {"FI_STRIDE": 0x38, "FI_NAME": 0x10, "label": "v38_n10"},
    {"FI_STRIDE": 0x38, "FI_NAME": 0x20, "label": "v38_n20"},
    {"FI_STRIDE": 0x40, "FI_NAME": 0x10, "label": "v40_n10"},
    {"FI_STRIDE": 0x40, "FI_NAME": 0x20, "label": "v40_n20"},
)

CLASS_NAME_RE = re.compile(r"^[A-Za-z_][A-Za-z0-9_`+]*$")
METHOD_NAME_RE = re.compile(r"^[A-Za-z0-9_.$:<>,`+/-]+$")
FIELD_NAME_RE = re.compile(r"^[A-Za-z_][A-Za-z0-9_<>]*$")


def hexv(value: int | None) -> str | None:
    return None if value is None else f"0x{value:X}"


def is_ascii_printable(text: str) -> bool:
    return bool(text) and all(32 <= ord(ch) < 127 for ch in text)


def looks_like_class_name(text: str | None) -> bool:
    if not text or not is_ascii_printable(text):
        return False
    if len(text) < 2 or len(text) > 128:
        return False
    if text in TARGET_CLASS_NAMES:
        return True
    return bool(CLASS_NAME_RE.fullmatch(text))


def looks_like_namespace(text: str | None) -> bool:
    if text is None:
        return False
    if text == "":
        return True
    if not is_ascii_printable(text):
        return False
    return all(ch.isalnum() or ch in "._+" for ch in text)


def looks_like_method_name(text: str | None) -> bool:
    if not text or not is_ascii_printable(text):
        return False
    if len(text) > 160:
        return False
    if text in (".ctor", ".cctor"):
        return True
    if not METHOD_NAME_RE.fullmatch(text):
        return False
    return any(ch.isalpha() for ch in text)


def looks_like_field_name(text: str | None) -> bool:
    if not text or not is_ascii_printable(text):
        return False
    if len(text) > 120:
        return False
    return bool(FIELD_NAME_RE.fullmatch(text))


def looks_like_image_struct(dr: "DumpReader", ptr: int | None) -> bool:
    if not dr.ok(ptr):
        return False
    image_name_ptr = dr.ru64(ptr + 0x08)
    image_file_ptr = dr.ru64(ptr + 0x18)
    image_name = dr.rstr(image_name_ptr, 128) if dr.ok(image_name_ptr) else None
    image_file = dr.rstr(image_file_ptr, 128) if dr.ok(image_file_ptr) else None
    return bool(
        image_name
        and image_file
        and image_file.endswith(".dll")
        and is_ascii_printable(image_name)
        and is_ascii_printable(image_file)
    )


class DumpReader:
    def __init__(self, path: Path):
        self.path = Path(path)
        self.file = self.path.open("rb")
        self.mm = mmap.mmap(self.file.fileno(), 0, access=mmap.ACCESS_READ)
        self.mm_view = memoryview(self.mm)
        self.va_map: list[tuple[int, int, int]] = []
        self.va_starts: list[int] = []
        self.file_map: list[tuple[int, int, int]] = []
        self.file_starts: list[int] = []
        self._parse_mdmp()

    def close(self) -> None:
        self.mm_view.release()
        self.mm.close()
        self.file.close()

    def _parse_mdmp(self) -> None:
        mm = self.mm
        if mm[:4] != b"MDMP":
            raise ValueError("not a minidump")

        stream_count = struct.unpack_from("<I", mm, 8)[0]
        stream_dir = struct.unpack_from("<I", mm, 12)[0]
        memory64_rva = None

        for index in range(stream_count):
            entry_off = stream_dir + index * 12
            if struct.unpack_from("<I", mm, entry_off)[0] == 9:
                memory64_rva = struct.unpack_from("<I", mm, entry_off + 8)[0]
                break

        if memory64_rva is None:
            raise ValueError("Memory64List stream not found")

        range_count = struct.unpack_from("<Q", mm, memory64_rva)[0]
        file_cursor = struct.unpack_from("<Q", mm, memory64_rva + 8)[0]

        for index in range(min(range_count, 50000)):
            entry_off = memory64_rva + 16 + index * 16
            va_start = struct.unpack_from("<Q", mm, entry_off)[0]
            size = struct.unpack_from("<Q", mm, entry_off + 8)[0]
            self.va_map.append((va_start, size, file_cursor))
            self.file_map.append((file_cursor, va_start, size))
            file_cursor += size

        self.va_map.sort()
        self.file_map.sort()
        self.va_starts = [start for start, _, _ in self.va_map]
        self.file_starts = [start for start, _, _ in self.file_map]

    def v2f(self, va: int) -> int | None:
        idx = bisect_right(self.va_starts, va) - 1
        if idx < 0:
            return None
        start, size, file_off = self.va_map[idx]
        if start <= va < start + size:
            return file_off + (va - start)
        return None

    def f2v(self, file_off: int) -> int | None:
        idx = bisect_right(self.file_starts, file_off) - 1
        if idx < 0:
            return None
        start, va_start, size = self.file_map[idx]
        if start <= file_off < start + size:
            return va_start + (file_off - start)
        return None

    def ok(self, va: int | None) -> bool:
        return va is not None and 0 < va < 0x7FFFFFFFFFFF and self.v2f(va) is not None

    def ru64(self, va: int) -> int | None:
        file_off = self.v2f(va)
        if file_off is None:
            return None
        return struct.unpack_from("<Q", self.mm, file_off)[0]

    def ru16(self, va: int) -> int | None:
        file_off = self.v2f(va)
        if file_off is None:
            return None
        return struct.unpack_from("<H", self.mm, file_off)[0]

    def rstr(self, va: int, max_len: int = 128) -> str | None:
        file_off = self.v2f(va)
        if file_off is None:
            return None
        end = self.mm.find(b"\x00", file_off, file_off + max_len)
        if end < 0:
            return None
        raw = self.mm[file_off:end]
        try:
            return raw.decode("utf-8")
        except UnicodeDecodeError:
            return None

    def rstr_ptr(self, va: int, max_len: int = 128) -> str | None:
        ptr = self.ru64(va)
        if not self.ok(ptr):
            return None
        return self.rstr(ptr, max_len=max_len)

    def iter_ranges(self, start_va: int, end_va: int):
        for range_start, size, file_off in self.va_map:
            range_end = range_start + size
            if range_end <= start_va:
                continue
            if range_start >= end_va:
                break
            chunk_start = max(range_start, start_va)
            chunk_end = min(range_end, end_va)
            if chunk_start >= chunk_end:
                continue
            chunk_file_off = file_off + (chunk_start - range_start)
            yield chunk_start, chunk_end, chunk_file_off


def scan_target_strings(dr: DumpReader) -> tuple[list[dict[str, object]], dict[int, str]]:
    hits: list[dict[str, object]] = []
    va_to_name: dict[int, str] = {}

    for name in TARGET_CLASS_NAMES:
        needle = name.encode("ascii") + b"\x00"
        file_off = -1
        while True:
            file_off = dr.mm.find(needle, file_off + 1)
            if file_off < 0:
                break
            va = dr.f2v(file_off)
            if va is None:
                continue
            entry = {
                "name": name,
                "file_offset": hexv(file_off),
                "va": hexv(va),
            }
            hits.append(entry)
            va_to_name[va] = name

    return hits, va_to_name


def scan_qword_refs_in_ranges(
    dr: DumpReader,
    start_va: int,
    end_va: int,
    target_vas: dict[int, str],
) -> list[dict[str, object]]:
    hits: list[dict[str, object]] = []

    for range_start, range_end, file_off in dr.iter_ranges(start_va, end_va):
        aligned_start = (range_start + 7) & ~7
        rel = aligned_start - range_start
        byte_count = ((range_end - aligned_start) // 8) * 8
        if byte_count <= 0:
            continue

        qwords = dr.mm_view[file_off + rel:file_off + rel + byte_count].cast("Q")
        for index, value in enumerate(qwords):
            target_name = target_vas.get(value)
            if target_name is None:
                continue
            ptr_addr = aligned_start + index * 8
            hits.append(
                {
                    "pointer_addr": ptr_addr,
                    "pointer_addr_hex": hexv(ptr_addr),
                    "string_va": value,
                    "string_va_hex": hexv(value),
                    "name": target_name,
                }
            )

    return hits


def scan_nearby_pointer_refs(
    dr: DumpReader,
    string_hits: list[dict[str, object]],
    target_vas: dict[int, str],
) -> list[dict[str, object]]:
    hits: list[dict[str, object]] = []
    seen: set[tuple[int, int]] = set()

    for entry in string_hits:
        string_va = int(str(entry["va"]), 16)
        name = str(entry["name"])
        start_va = max(0, string_va - NEARBY_WINDOW)
        end_va = string_va + NEARBY_WINDOW
        for range_start, range_end, file_off in dr.iter_ranges(start_va, end_va):
            aligned_start = (range_start + 7) & ~7
            rel = aligned_start - range_start
            byte_count = ((range_end - aligned_start) // 8) * 8
            if byte_count <= 0:
                continue
            qwords = dr.mm_view[file_off + rel:file_off + rel + byte_count].cast("Q")
            for index, value in enumerate(qwords):
                if value != string_va:
                    continue
                ptr_addr = aligned_start + index * 8
                key = (ptr_addr, string_va)
                if key in seen:
                    continue
                seen.add(key)
                hits.append(
                    {
                        "pointer_addr": ptr_addr,
                        "pointer_addr_hex": hexv(ptr_addr),
                        "string_va": string_va,
                        "string_va_hex": hexv(string_va),
                        "name": name,
                    }
                )

    return hits


def build_layout_histogram(
    dr: DumpReader,
    pointer_hits: list[dict[str, object]],
) -> list[dict[str, object]]:
    stats: dict[tuple[int, int, int], dict[str, object]] = {}

    for hit in pointer_hits:
        ptr_addr = int(hit["pointer_addr"])
        name = str(hit["name"])
        string_va = int(hit["string_va"])

        for off_name in NAME_OFFSET_RANGE:
            base = ptr_addr - off_name
            self_offsets = []
            for self_off in SELF_REF_RANGE:
                if dr.ru64(base + self_off) == base:
                    self_offsets.append(self_off)

            if len(self_offsets) < 2:
                continue

            for index in range(len(self_offsets)):
                for other_index in range(index + 1, len(self_offsets)):
                    off_elem = self_offsets[index]
                    off_cast = self_offsets[other_index]
                    key = (off_name, off_elem, off_cast)
                    bucket = stats.setdefault(
                        key,
                        {
                            "off_name": off_name,
                            "off_elem": off_elem,
                            "off_cast": off_cast,
                            "hit_count": 0,
                            "names": set(),
                            "string_vas": set(),
                            "bases": set(),
                            "samples": [],
                        },
                    )
                    bucket["hit_count"] += 1
                    bucket["names"].add(name)
                    bucket["string_vas"].add(string_va)
                    bucket["bases"].add(base)
                    if len(bucket["samples"]) < 8:
                        bucket["samples"].append(
                            {
                                "name": name,
                                "base": hexv(base),
                                "pointer_addr": hexv(ptr_addr),
                                "string_va": hexv(string_va),
                            }
                        )

    ranked: list[dict[str, object]] = []
    for bucket in stats.values():
        names = sorted(bucket["names"])
        item = {
            "off_name": bucket["off_name"],
            "off_elem": bucket["off_elem"],
            "off_cast": bucket["off_cast"],
            "hit_count": bucket["hit_count"],
            "name_diversity": len(names),
            "distinct_string_vas": len(bucket["string_vas"]),
            "distinct_bases": len(bucket["bases"]),
            "names": names,
            "samples": bucket["samples"],
        }
        ranked.append(item)

    ranked.sort(
        key=lambda item: (
            int(item["name_diversity"]),
            int(item["distinct_bases"]),
            int(item["hit_count"]),
            -int(item["off_name"]),
        ),
        reverse=True,
    )
    return ranked


def scan_candidate_classes(
    dr: DumpReader,
    off_name: int,
    off_ns: int,
    off_elem: int,
    off_cast: int,
) -> list[dict[str, object]]:
    candidates: list[dict[str, object]] = []

    for range_start, range_end, file_off in dr.iter_ranges(HEAP_VA_START, HEAP_VA_END):
        last_va = range_end - CLASS_SCAN_FOOTPRINT
        if last_va < range_start:
            continue

        va = (range_start + 7) & ~7
        while va <= last_va:
            base_off = file_off + (va - range_start)
            if struct.unpack_from("<Q", dr.mm, base_off + off_elem)[0] != va:
                va += 8
                continue
            if struct.unpack_from("<Q", dr.mm, base_off + off_cast)[0] != va:
                va += 8
                continue

            name_ptr = struct.unpack_from("<Q", dr.mm, base_off + off_name)[0]
            if not dr.ok(name_ptr):
                va += 8
                continue
            name = dr.rstr(name_ptr, 128)
            if not looks_like_class_name(name):
                va += 8
                continue

            namespace = ""
            ns_ptr = struct.unpack_from("<Q", dr.mm, base_off + off_ns)[0]
            if dr.ok(ns_ptr):
                namespace = dr.rstr(ns_ptr, 128) or ""
                if not looks_like_namespace(namespace):
                    namespace = ""

            candidates.append(
                {
                    "va": va,
                    "va_hex": hexv(va),
                    "name": name,
                    "namespace": namespace,
                }
            )
            va += 8

    return candidates


def probe_image_offset(dr: DumpReader, class_bases: list[int]) -> int | None:
    best_score = (-1, -1)
    best_offset = None
    for offset in IMAGE_OFFSET_RANGE:
        hits = 0
        dll_hits = 0
        for base in class_bases:
            ptr = dr.ru64(base + offset)
            if not dr.ok(ptr):
                continue
            if looks_like_image_struct(dr, ptr):
                hits += 1
                dll_hits += 1
        score = (dll_hits, hits)
        if score > best_score:
            best_score = score
            best_offset = offset
    return best_offset


def probe_parent_offset(
    dr: DumpReader,
    class_bases: list[int],
    known_base_by_name: dict[str, int],
) -> int | None:
    base_set = set(class_bases)
    best_score = (-1, -1)
    best_offset = None

    for offset in PARENT_OFFSET_RANGE:
        resolved = 0
        named = 0
        for base in class_bases:
            ptr = dr.ru64(base + offset)
            if ptr not in base_set:
                continue
            if ptr == base:
                continue
            resolved += 1
            if looks_like_class_name(dr.rstr_ptr(ptr + 0x10)):
                named += 1
        score = (named, resolved)
        if score > best_score:
            best_score = score
            best_offset = offset

    return best_offset


def probe_method_layout(
    dr: DumpReader,
    class_bases: list[int],
) -> dict[str, int]:
    best: dict[str, int] | None = None
    best_score = (-1, -1, -10**9, -1)

    for off_methods in METHOD_PTR_RANGE:
        for mi_name in METHOD_NAME_OFFSETS:
            observed_counts: dict[int, int] = {}
            sample_names: list[str] = []

            for base in class_bases:
                methods_ptr = dr.ru64(base + off_methods)
                if not dr.ok(methods_ptr):
                    continue

                observed = 0
                for index in range(256):
                    method_info = dr.ru64(methods_ptr + index * 8)
                    if not dr.ok(method_info):
                        break
                    name = dr.rstr_ptr(method_info + mi_name, 128)
                    if not looks_like_method_name(name):
                        break
                    observed += 1
                    if len(sample_names) < 8:
                        sample_names.append(name)

                if observed >= 6:
                    observed_counts[base] = observed

            if len(observed_counts) < 3:
                continue

            for off_mcnt in COUNT_RANGE:
                exact_matches = 0
                near_matches = 0
                total_observed = 0
                total_abs_delta = 0

                for base, observed in observed_counts.items():
                    method_count = dr.ru16(base + off_mcnt)
                    if method_count is None or not method_count or method_count > 1024:
                        continue
                    delta = abs(method_count - observed)
                    total_observed += observed
                    total_abs_delta += delta
                    if delta == 0:
                        exact_matches += 1
                    if delta <= 2:
                        near_matches += 1

                score = (exact_matches, near_matches, -total_abs_delta, total_observed)
                if score > best_score:
                    best_score = score
                    best = {
                        "OFF_METHODS": off_methods,
                        "OFF_MCNT": off_mcnt,
                        "MI_POINTER": 0x00,
                        "MI_NAME": mi_name,
                        "score_exact_matches": exact_matches,
                        "score_near_matches": near_matches,
                        "score_total_abs_delta": total_abs_delta,
                    }

    if best is None:
        raise RuntimeError("method layout probe failed")
    return best


def probe_field_layout(
    dr: DumpReader,
    class_bases: list[int],
) -> dict[str, int]:
    best: dict[str, int] | None = None
    best_score = (-1, -1, -10**9, -1)

    for off_fields in FIELD_PTR_RANGE:
        for field_layout in FIELD_LAYOUTS:
            stride = int(field_layout["FI_STRIDE"])
            name_off = int(field_layout["FI_NAME"])
            observed_counts: dict[int, int] = {}

            for base in class_bases:
                fields_ptr = dr.ru64(base + off_fields)
                if not dr.ok(fields_ptr):
                    continue

                observed = 0
                for index in range(256):
                    name = dr.rstr_ptr(fields_ptr + index * stride + name_off, 128)
                    if not looks_like_field_name(name):
                        break
                    observed += 1

                if observed >= 2:
                    observed_counts[base] = observed

            if len(observed_counts) < 3:
                continue

            for off_fcnt in COUNT_RANGE:
                exact_matches = 0
                near_matches = 0
                total_observed = 0
                total_abs_delta = 0

                for base, observed in observed_counts.items():
                    field_count = dr.ru16(base + off_fcnt)
                    if field_count is None or not field_count or field_count > 512:
                        continue
                    delta = abs(field_count - observed)
                    total_observed += observed
                    total_abs_delta += delta
                    if delta == 0:
                        exact_matches += 1
                    if delta <= 1:
                        near_matches += 1

                score = (exact_matches, near_matches, -total_abs_delta, total_observed)
                if score > best_score:
                    best_score = score
                    best = {
                        "OFF_FIELDS": off_fields,
                        "OFF_FCNT": off_fcnt,
                        "FI_STRIDE": stride,
                        "FI_NAME": name_off,
                        "score_exact_matches": exact_matches,
                        "score_near_matches": near_matches,
                        "score_total_abs_delta": total_abs_delta,
                    }

    if best is None:
        raise RuntimeError("field layout probe failed")
    return best


def collect_known_class_evidence(
    dr: DumpReader,
    candidate_classes: list[dict[str, object]],
    offsets: dict[str, int],
) -> list[dict[str, object]]:
    first_by_name: dict[str, dict[str, object]] = {}
    for entry in candidate_classes:
        name = str(entry["name"])
        if name in TARGET_CLASS_NAMES and name not in first_by_name:
            first_by_name[name] = entry

    evidence: list[dict[str, object]] = []
    for name in TARGET_CLASS_NAMES:
        entry = first_by_name.get(name)
        if entry is None:
            continue
        base = int(entry["va"])

        parent_name = None
        parent_ptr = dr.ru64(base + offsets["OFF_PARENT"])
        if dr.ok(parent_ptr):
            parent_name = dr.rstr_ptr(parent_ptr + offsets["OFF_NAME"], 128)

        method_count = dr.ru16(base + offsets["OFF_MCNT"]) or 0
        methods_ptr = dr.ru64(base + offsets["OFF_METHODS"])
        sample_methods: list[str] = []
        if dr.ok(methods_ptr):
            for index in range(min(method_count, 10)):
                method_info = dr.ru64(methods_ptr + index * 8)
                if not dr.ok(method_info):
                    break
                method_name = dr.rstr_ptr(method_info + offsets["MI_NAME"], 128)
                if not looks_like_method_name(method_name):
                    break
                sample_methods.append(method_name)

        field_count = dr.ru16(base + offsets["OFF_FCNT"]) or 0
        fields_ptr = dr.ru64(base + offsets["OFF_FIELDS"])
        sample_fields: list[str] = []
        if dr.ok(fields_ptr):
            for index in range(min(field_count, 10)):
                field_name = dr.rstr_ptr(
                    fields_ptr + index * offsets["FI_STRIDE"] + offsets["FI_NAME"],
                    128,
                )
                if not looks_like_field_name(field_name):
                    break
                sample_fields.append(field_name)

        confirmed = bool(sample_methods[:3]) and (
            field_count == 0 or bool(sample_fields[: min(field_count, 2)])
        )
        evidence.append(
            {
                "name": name,
                "base": hexv(base),
                "namespace": entry["namespace"],
                "parent": parent_name,
                "method_count": method_count,
                "field_count": field_count,
                "sample_methods": sample_methods[:5],
                "sample_fields": sample_fields[:5],
                "confirmed": confirmed,
            }
        )

    return evidence


def build_report(
    dump_path: Path,
    string_hits: list[dict[str, object]],
    nearby_pointer_hits: list[dict[str, object]],
    heap_pointer_hits: list[dict[str, object]],
    chosen_histogram: list[dict[str, object]],
    chosen_layout: dict[str, int],
    candidate_classes: list[dict[str, object]],
    known_evidence: list[dict[str, object]],
    timings: dict[str, float],
) -> dict[str, object]:
    confirmed = [item for item in known_evidence if item["confirmed"]]
    return {
        "dump_path": os.fspath(dump_path),
        "generated": time.strftime("%Y-%m-%d %H:%M:%S"),
        "string_scan": {
            "target_names": list(TARGET_CLASS_NAMES),
            "mapped_hits": len(string_hits),
            "hits_by_name": {
                name: sum(1 for item in string_hits if item["name"] == name)
                for name in TARGET_CLASS_NAMES
            },
            "sample_hits": string_hits[:24],
        },
        "pointer_ref_scan": {
            "nearby_window": hexv(NEARBY_WINDOW),
            "nearby_pointer_hits": len(nearby_pointer_hits),
            "heap_pointer_hits": len(heap_pointer_hits),
            "notes": [
                "Nearby ±0x4000 pointer search was attempted first for each string VA.",
                "Heap-wide known-string pointer scan was used because the nearby pass did not produce enough signal.",
            ],
        },
        "layout_histogram_top": [
            {
                "off_name": hexv(int(item["off_name"])),
                "off_elem": hexv(int(item["off_elem"])),
                "off_cast": hexv(int(item["off_cast"])),
                "hit_count": item["hit_count"],
                "name_diversity": item["name_diversity"],
                "distinct_bases": item["distinct_bases"],
                "names": item["names"],
                "samples": item["samples"],
            }
            for item in chosen_histogram[:12]
        ],
        "final_offsets": {key: hexv(value) for key, value in chosen_layout.items()},
        "candidate_class_count": len(candidate_classes),
        "known_class_evidence": known_evidence,
        "known_classes_confirmed": len(confirmed),
        "confirmed_names": [item["name"] for item in confirmed],
        "timings_seconds": {key: round(value, 3) for key, value in timings.items()},
    }


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "--dump",
        default=str(DEFAULT_DUMP_PATH),
        help=f"Path to the VRChat minidump (default: {DEFAULT_DUMP_PATH})",
    )
    parser.add_argument(
        "--output",
        default=str(DEFAULT_OUTPUT_PATH),
        help=f"Path to the output JSON report (default: {DEFAULT_OUTPUT_PATH})",
    )
    args = parser.parse_args()

    dump_path = Path(args.dump)
    output_path = Path(args.output)
    output_path.parent.mkdir(parents=True, exist_ok=True)

    timings: dict[str, float] = {}
    t0 = time.time()
    dr = DumpReader(dump_path)
    timings["open_dump"] = time.time() - t0

    try:
        print(f"[+] Loading strings from {dump_path}")
        t1 = time.time()
        string_hits, target_vas = scan_target_strings(dr)
        timings["scan_strings"] = time.time() - t1
        print(f"    mapped known-string hits: {len(string_hits)}")

        print("[+] Nearby pointer scan (±0x4000 around each hit)")
        t1 = time.time()
        nearby_pointer_hits = scan_nearby_pointer_refs(dr, string_hits, target_vas)
        nearby_hist = build_layout_histogram(dr, nearby_pointer_hits)
        timings["scan_nearby_refs"] = time.time() - t1
        print(f"    nearby pointer hits: {len(nearby_pointer_hits)}")
        if nearby_hist:
            best_nearby = nearby_hist[0]
            print(
                "    best nearby triple:",
                f"name={hexv(int(best_nearby['off_name']))}",
                f"elem={hexv(int(best_nearby['off_elem']))}",
                f"cast={hexv(int(best_nearby['off_cast']))}",
                f"names={best_nearby['name_diversity']}",
            )
        else:
            print("    nearby pass did not yield a usable triple")

        print("[+] Heap-wide pointer scan for known string VAs")
        t1 = time.time()
        heap_pointer_hits = scan_qword_refs_in_ranges(dr, HEAP_VA_START, HEAP_VA_END, target_vas)
        heap_hist = build_layout_histogram(dr, heap_pointer_hits)
        timings["scan_heap_refs"] = time.time() - t1
        print(f"    heap pointer hits: {len(heap_pointer_hits)}")

        if not heap_hist:
            raise RuntimeError("no layout candidates found from heap pointer scan")

        best_layout = heap_hist[0]
        off_name = int(best_layout["off_name"])
        off_elem = int(best_layout["off_elem"])
        off_cast = int(best_layout["off_cast"])
        print(
            "[+] Selected Il2CppClass triple:",
            f"OFF_NAME={hexv(off_name)}",
            f"OFF_ELEM={hexv(off_elem)}",
            f"OFF_CAST={hexv(off_cast)}",
            f"name_diversity={best_layout['name_diversity']}",
        )

        print("[+] Scanning heap for class candidates with inferred triple")
        t1 = time.time()
        candidate_classes = scan_candidate_classes(
            dr,
            off_name=off_name,
            off_ns=0x18,
            off_elem=off_elem,
            off_cast=off_cast,
        )
        timings["scan_candidate_classes"] = time.time() - t1
        print(f"    candidate classes: {len(candidate_classes)}")

        candidate_bases = [int(item["va"]) for item in candidate_classes]
        first_known: dict[str, int] = {}
        for item in candidate_classes:
            name = str(item["name"])
            if name in TARGET_CLASS_NAMES and name not in first_known:
                first_known[name] = int(item["va"])
        known_bases = [first_known[name] for name in TARGET_CLASS_NAMES if name in first_known]
        print(f"    known class bases found: {len(known_bases)}")

        image_offset = probe_image_offset(dr, known_bases)
        parent_offset = probe_parent_offset(dr, known_bases, first_known)
        try:
            method_layout = probe_method_layout(dr, known_bases)
        except RuntimeError as exc:
            print(f"[!] {exc}; emitting partial report")
            method_layout = {"OFF_METHODS": 0x00, "OFF_MCNT": 0x00,
                              "MI_POINTER": 0x00, "MI_NAME": 0x00,
                              "score_exact_matches": 0, "score_near_matches": 0,
                              "score_total_abs_delta": 0}
        try:
            field_layout = probe_field_layout(dr, known_bases)
        except RuntimeError as exc:
            print(f"[!] {exc}; emitting partial report")
            field_layout = {"OFF_FIELDS": 0x00, "OFF_FCNT": 0x00,
                             "FI_STRIDE": 0x30, "FI_NAME": 0x10,
                             "score_exact_matches": 0, "score_near_matches": 0,
                             "score_total_abs_delta": 0}

        final_offsets = {
            "OFF_IMAGE": image_offset if image_offset is not None else 0x00,
            "OFF_NS": 0x18,
            "OFF_ELEM": off_elem,
            "OFF_CAST": off_cast,
            "OFF_NAME": off_name,
            "OFF_METHODS": int(method_layout["OFF_METHODS"]),
            "OFF_FIELDS": int(field_layout["OFF_FIELDS"]),
            "OFF_PARENT": parent_offset if parent_offset is not None else 0xA0,
            "OFF_NATIVE": 0xD0,
            "OFF_MCNT": int(method_layout["OFF_MCNT"]),
            "OFF_FCNT": int(field_layout["OFF_FCNT"]),
            "MI_POINTER": int(method_layout["MI_POINTER"]),
            "MI_NAME": int(method_layout["MI_NAME"]),
            "FI_STRIDE": int(field_layout["FI_STRIDE"]),
            "FI_NAME": int(field_layout["FI_NAME"]),
        }

        known_evidence = collect_known_class_evidence(dr, candidate_classes, final_offsets)
        confirmed_count = sum(1 for item in known_evidence if item["confirmed"])

        report = build_report(
            dump_path=dump_path,
            string_hits=string_hits,
            nearby_pointer_hits=nearby_pointer_hits,
            heap_pointer_hits=heap_pointer_hits,
            chosen_histogram=heap_hist,
            chosen_layout=final_offsets,
            candidate_classes=candidate_classes,
            known_evidence=known_evidence,
            timings=timings,
        )
        with output_path.open("w", encoding="utf-8") as fh:
            json.dump(report, fh, indent=2, ensure_ascii=False)
            fh.write("\n")

        print("[+] Wrote report:", output_path)
        print(
            "[+] Known classes confirmed:",
            f"{confirmed_count}/{len(TARGET_CLASS_NAMES)}",
        )
        print(
            "[+] Final offsets:",
            " ".join(f"{key}={hexv(value)}" for key, value in final_offsets.items()),
        )
        return 0
    finally:
        dr.close()


if __name__ == "__main__":
    raise SystemExit(main())
