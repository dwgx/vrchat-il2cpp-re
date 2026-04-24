#!/usr/bin/env python3
"""
Verify and recover Beebyte-modified Il2CppClass offsets from a VRChat minidump.

The script mirrors the minidump VA-to-file parsing approach used by
extract_precise_dump.py, then:

1. Scans the managed heap for candidate Il2CppClass structs using the current
   self-reference offsets.
2. Validates the current layout against a set of known class probes.
3. If the current layout underperforms, brute-forces candidate OFF_NAME values.
4. Probes method/field pointer and count offsets via table consistency.
5. Writes a machine-readable report to data/struct_layout_verification.json.
"""

from __future__ import annotations

import argparse
import json
import mmap
import re
import struct
import sys
import time
from bisect import bisect_right
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_DUMP_PATH = Path(r"D:\WorkSpace\VRChat\VRChat_Data\VRChat_NEW_full.dmp")
OUTPUT_PATH = BASE_DIR / "data" / "struct_layout_verification.json"

HEAP_VA_START = 0x30000000
HEAP_VA_END = 0x3E000000
CLASS_SCAN_WINDOW = 0x200

KNOWN_CLASS_NAMES = (
    "Keyboard",
    "SteamVR_Actions",
    "GameObject",
    "NetworkManager",
    "MonoBehaviour",
    "Transform",
    "Component",
)

CURRENT = {
    "OFF_IMAGE": 0x00,
    "OFF_NS": 0x18,
    "OFF_ELEM": 0x40,
    "OFF_CAST": 0x48,
    "OFF_NAME": 0x58,
    "OFF_METHODS": 0x78,
    "OFF_FIELDS": 0x88,
    "OFF_PARENT": 0xA8,
    "OFF_NATIVE": 0xD0,
    "OFF_MCNT": 0x100,
    "OFF_FCNT": 0x122,
    "MI_POINTER": 0x00,
    "MI_NAME": 0x18,
    "FI_STRIDE": 0x30,
    "FI_NAME": 0x20,
}

FIELD_LAYOUTS = (
    {"label": "legacy", "FI_STRIDE": 0x30, "FI_NAME": 0x20},
    {"label": "beebyte_v2", "FI_STRIDE": 0x20, "FI_NAME": 0x10},
)

METHOD_PTR_RANGE = range(0x40, 0x181, 8)
FIELD_PTR_RANGE = range(0x40, 0x181, 8)
COUNT_RANGE = range(0xE0, 0x141, 2)
NAME_RANGE = range(0x00, 0x201, 8)

CLASS_NAME_RE = re.compile(r"^[A-Z][A-Za-z0-9_`+]*$")
METHOD_NAME_RE = re.compile(r"^[A-Za-z0-9_.$:<>,`+/-]+$")


def hex32(value: int | None) -> str | None:
    return None if value is None else f"0x{value:X}"


def align_up(value: int, align: int) -> int:
    mask = align - 1
    return (value + mask) & ~mask


def is_ascii_printable(text: str) -> bool:
    return bool(text) and all(32 <= ord(ch) < 127 for ch in text)


def looks_like_class_name(text: str) -> bool:
    if not text or not is_ascii_printable(text):
        return False
    if len(text) < 2 or len(text) > 96:
        return False
    if text in KNOWN_CLASS_NAMES:
        return True
    return bool(CLASS_NAME_RE.fullmatch(text))


def looks_like_method_name(text: str) -> bool:
    if not text or not is_ascii_printable(text):
        return False
    if len(text) > 160:
        return False
    if text == ".ctor" or text == ".cctor":
        return True
    if not METHOD_NAME_RE.fullmatch(text):
        return False
    return any(ch.isalpha() for ch in text)


def looks_like_namespace(text: str) -> bool:
    if not text:
        return True
    if not is_ascii_printable(text):
        return False
    return all(ch.isalnum() or ch in "._+" for ch in text)


class DumpReader:
    def __init__(self, path: Path):
        self.path = Path(path)
        self.file = self.path.open("rb")
        self.mm = mmap.mmap(self.file.fileno(), 0, access=mmap.ACCESS_READ)
        self.va_map: list[tuple[int, int, int]] = []
        self.va_starts: list[int] = []
        self._parse_mdmp()

    def close(self) -> None:
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
            stream_type = struct.unpack_from("<I", mm, entry_off)[0]
            if stream_type == 9:
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
            file_cursor += size

        self.va_map.sort()
        self.va_starts = [start for start, _, _ in self.va_map]

    def v2f(self, va: int) -> int | None:
        idx = bisect_right(self.va_starts, va) - 1
        if idx < 0:
            return None
        start, size, file_off = self.va_map[idx]
        if start <= va < start + size:
            return file_off + (va - start)
        return None

    def ok(self, va: int | None) -> bool:
        return (
            va is not None
            and 0 < va < 0x7FFFFFFFFFFF
            and self.v2f(va) is not None
        )

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


def scan_class_candidates(
    dr: DumpReader,
    off_elem: int,
    off_cast: int,
    off_name: int,
    off_ns: int,
) -> list[dict[str, object]]:
    mm = dr.mm
    candidates: list[dict[str, object]] = []
    required = max(CLASS_SCAN_WINDOW, off_elem + 8, off_cast + 8, off_name + 8, off_ns + 8)

    for range_start, range_end, file_off in dr.iter_ranges(HEAP_VA_START, HEAP_VA_END):
        last_start = range_end - required
        if last_start < range_start:
            continue

        va = align_up(range_start, 8)
        while va <= last_start:
            rel = va - range_start
            base_off = file_off + rel

            elem = struct.unpack_from("<Q", mm, base_off + off_elem)[0]
            if elem != va:
                va += 8
                continue

            cast = struct.unpack_from("<Q", mm, base_off + off_cast)[0]
            if cast != va:
                va += 8
                continue

            name_ptr = struct.unpack_from("<Q", mm, base_off + off_name)[0]
            if not dr.ok(name_ptr):
                va += 8
                continue

            name = dr.rstr(name_ptr, 128)
            if not looks_like_class_name(name or ""):
                va += 8
                continue

            namespace = ""
            ns_ptr = struct.unpack_from("<Q", mm, base_off + off_ns)[0]
            if dr.ok(ns_ptr):
                namespace = dr.rstr(ns_ptr, 128) or ""
                if not looks_like_namespace(namespace):
                    namespace = ""

            candidates.append(
                {
                    "va": va,
                    "name": name,
                    "namespace": namespace,
                }
            )
            va += 8

    return candidates


def find_known_hits(candidates: list[dict[str, object]]) -> list[dict[str, object]]:
    first_by_name: dict[str, dict[str, object]] = {}
    for entry in candidates:
        name = str(entry["name"])
        if name in KNOWN_CLASS_NAMES and name not in first_by_name:
            first_by_name[name] = entry
    ordered = []
    for name in KNOWN_CLASS_NAMES:
        if name in first_by_name:
            ordered.append(first_by_name[name])
    return ordered


def brute_force_name_offsets(dr: DumpReader, base_vas: list[int]) -> list[dict[str, object]]:
    results: list[dict[str, object]] = []
    if not base_vas:
        return results

    for offset in NAME_RANGE:
        class_like = 0
        known_hits: set[str] = set()
        samples: list[str] = []

        for va in base_vas:
            name_ptr = dr.ru64(va + offset)
            if not dr.ok(name_ptr):
                continue
            name = dr.rstr(name_ptr, 128)
            if not looks_like_class_name(name or ""):
                continue

            class_like += 1
            if name in KNOWN_CLASS_NAMES:
                known_hits.add(name)
            if len(samples) < 5 and name not in samples:
                samples.append(name)

        results.append(
            {
                "offset": offset,
                "class_like_count": class_like,
                "known_hits": sorted(known_hits),
                "sample_names": samples,
            }
        )

    results.sort(
        key=lambda item: (
            len(item["known_hits"]),
            item["class_like_count"],
            -item["offset"],
        ),
        reverse=True,
    )
    return results[:5]


def select_probe_classes(
    dr: DumpReader,
    base_vas: list[int],
    off_name: int,
    off_ns: int,
    limit: int,
) -> list[dict[str, object]]:
    known_entries: list[dict[str, object]] = []
    generic_entries: list[dict[str, object]] = []

    for va in base_vas:
        name_ptr = dr.ru64(va + off_name)
        if not dr.ok(name_ptr):
            continue
        name = dr.rstr(name_ptr, 128)
        if not looks_like_class_name(name or ""):
            continue

        namespace = dr.rstr_ptr(va + off_ns, 128) or ""
        if not looks_like_namespace(namespace):
            namespace = ""

        entry = {"va": va, "name": name, "namespace": namespace}
        if name in KNOWN_CLASS_NAMES:
            known_entries.append(entry)
        else:
            generic_entries.append(entry)

    selected: list[dict[str, object]] = []
    seen_vas: set[int] = set()

    for entry in known_entries:
        va = int(entry["va"])
        if va not in seen_vas:
            selected.append(entry)
            seen_vas.add(va)
        if len(selected) >= limit:
            return selected

    if generic_entries and len(selected) < limit:
        stride = max(1, len(generic_entries) // max(1, limit - len(selected)))
        for index in range(0, len(generic_entries), stride):
            entry = generic_entries[index]
            va = int(entry["va"])
            if va in seen_vas:
                continue
            selected.append(entry)
            seen_vas.add(va)
            if len(selected) >= limit:
                break

    return selected


def rank_count_offsets(
    dr: DumpReader,
    classes: list[dict[str, object]],
    offset_range,
    max_reasonable: int,
    current_offset: int,
) -> list[int]:
    scored = []
    for offset in offset_range:
        nonzero_reasonable = 0
        total_reasonable = 0
        for entry in classes:
            count = dr.ru16(int(entry["va"]) + offset)
            if count is None:
                continue
            if 0 <= count <= max_reasonable:
                total_reasonable += 1
            if 1 <= count <= max_reasonable:
                nonzero_reasonable += 1
        scored.append((nonzero_reasonable, total_reasonable, offset))

    scored.sort(reverse=True)
    top = [offset for _, _, offset in scored[:10]]
    if current_offset not in top:
        top.append(current_offset)
    return top


def rank_pointer_offsets(
    dr: DumpReader,
    classes: list[dict[str, object]],
    offset_range,
    current_offset: int,
) -> list[int]:
    scored = []
    for offset in offset_range:
        valid_ptrs = 0
        for entry in classes:
            ptr = dr.ru64(int(entry["va"]) + offset)
            if dr.ok(ptr):
                valid_ptrs += 1
        scored.append((valid_ptrs, offset))

    scored.sort(reverse=True)
    top = [offset for _, offset in scored[:12]]
    if current_offset not in top:
        top.append(current_offset)
    return top


def evaluate_method_combo(
    dr: DumpReader,
    classes: list[dict[str, object]],
    off_methods: int,
    off_mcnt: int,
) -> dict[str, object]:
    tested = 0
    valid_classes = 0
    valid_entries = 0
    samples: list[str] = []

    for entry in classes:
        base = int(entry["va"])
        count = dr.ru16(base + off_mcnt)
        if count is None or count <= 0 or count > 512:
            continue

        table = dr.ru64(base + off_methods)
        if not dr.ok(table):
            continue

        tested += 1
        to_check = min(count, 4)
        hit_count = 0

        for index in range(to_check):
            method_info = dr.ru64(table + index * 8)
            if not dr.ok(method_info):
                break
            name = dr.rstr_ptr(method_info + CURRENT["MI_NAME"], 160)
            if not looks_like_method_name(name or ""):
                break
            hit_count += 1
            if len(samples) < 8 and name not in samples:
                samples.append(name)

        if hit_count:
            valid_entries += hit_count
        if hit_count >= min(2, to_check):
            valid_classes += 1

    score = valid_classes * 10 + valid_entries
    return {
        "offsets": {
            "OFF_METHODS": off_methods,
            "OFF_MCNT": off_mcnt,
        },
        "score": score,
        "tested_classes": tested,
        "valid_classes": valid_classes,
        "valid_entries": valid_entries,
        "sample_method_names": samples,
    }


def probe_method_offsets(dr: DumpReader, classes: list[dict[str, object]]) -> dict[str, object]:
    if not classes:
        return {
            "current": evaluate_method_combo(dr, [], CURRENT["OFF_METHODS"], CURRENT["OFF_MCNT"]),
            "best": None,
            "top_candidates": [],
        }

    method_offsets = rank_pointer_offsets(dr, classes, METHOD_PTR_RANGE, CURRENT["OFF_METHODS"])
    count_offsets = rank_count_offsets(dr, classes, COUNT_RANGE, 512, CURRENT["OFF_MCNT"])

    results = []
    for off_methods in method_offsets:
        for off_mcnt in count_offsets:
            results.append(evaluate_method_combo(dr, classes, off_methods, off_mcnt))

    results.sort(
        key=lambda item: (
            item["score"],
            item["valid_classes"],
            item["valid_entries"],
        ),
        reverse=True,
    )

    current = evaluate_method_combo(dr, classes, CURRENT["OFF_METHODS"], CURRENT["OFF_MCNT"])
    best = results[0] if results else None
    return {
        "current": current,
        "best": best,
        "top_candidates": results[:5],
    }


def evaluate_field_combo(
    dr: DumpReader,
    classes: list[dict[str, object]],
    off_fields: int,
    off_fcnt: int,
) -> dict[str, object]:
    tested = 0
    valid_classes = 0
    valid_entries = 0
    layout_scores: Counter[str] = Counter()
    samples: list[str] = []

    for entry in classes:
        base = int(entry["va"])
        count = dr.ru16(base + off_fcnt)
        if count is None or count <= 0 or count > 512:
            continue

        table = dr.ru64(base + off_fields)
        if not dr.ok(table):
            continue

        tested += 1
        best_layout = None
        best_hits = 0

        for layout in FIELD_LAYOUTS:
            stride = layout["FI_STRIDE"]
            name_off = layout["FI_NAME"]
            to_check = min(count, 4)
            hits = 0

            for index in range(to_check):
                field_name_ptr = dr.ru64(table + index * stride + name_off)
                if not dr.ok(field_name_ptr):
                    break
                field_name = dr.rstr(field_name_ptr, 128)
                if not looks_like_method_name(field_name or ""):
                    break
                hits += 1
                if len(samples) < 8 and field_name not in samples:
                    samples.append(field_name)

            if hits > best_hits:
                best_hits = hits
                best_layout = layout

        if best_hits:
            valid_entries += best_hits
        if best_hits >= min(2, count, 4):
            valid_classes += 1
        if best_layout is not None:
            layout_scores[best_layout["label"]] += best_hits

    best_layout_label = None
    if layout_scores:
        best_layout_label = layout_scores.most_common(1)[0][0]
    best_layout = next(
        (layout for layout in FIELD_LAYOUTS if layout["label"] == best_layout_label),
        None,
    )

    score = valid_classes * 10 + valid_entries
    return {
        "offsets": {
            "OFF_FIELDS": off_fields,
            "OFF_FCNT": off_fcnt,
        },
        "score": score,
        "tested_classes": tested,
        "valid_classes": valid_classes,
        "valid_entries": valid_entries,
        "sample_field_names": samples,
        "best_field_layout": best_layout,
        "field_layout_scores": dict(layout_scores),
    }


def probe_field_offsets(dr: DumpReader, classes: list[dict[str, object]]) -> dict[str, object]:
    if not classes:
        return {
            "current": evaluate_field_combo(dr, [], CURRENT["OFF_FIELDS"], CURRENT["OFF_FCNT"]),
            "best": None,
            "top_candidates": [],
        }

    field_offsets = rank_pointer_offsets(dr, classes, FIELD_PTR_RANGE, CURRENT["OFF_FIELDS"])
    count_offsets = rank_count_offsets(dr, classes, COUNT_RANGE, 512, CURRENT["OFF_FCNT"])

    results = []
    for off_fields in field_offsets:
        for off_fcnt in count_offsets:
            results.append(evaluate_field_combo(dr, classes, off_fields, off_fcnt))

    results.sort(
        key=lambda item: (
            item["score"],
            item["valid_classes"],
            item["valid_entries"],
        ),
        reverse=True,
    )

    current = evaluate_field_combo(dr, classes, CURRENT["OFF_FIELDS"], CURRENT["OFF_FCNT"])
    best = results[0] if results else None
    return {
        "current": current,
        "best": best,
        "top_candidates": results[:5],
    }


def build_notes(
    candidate_count: int,
    known_hits: list[dict[str, object]],
    name_candidates: list[dict[str, object]],
    method_probe: dict[str, object],
    field_probe: dict[str, object],
    probe_limit: int,
) -> list[str]:
    notes = [
        f"Heap scan used current self-reference offsets OFF_ELEM={hex32(CURRENT['OFF_ELEM'])} and OFF_CAST={hex32(CURRENT['OFF_CAST'])}.",
        f"Current layout candidate scan found {candidate_count} class-like structs and {len(known_hits)} known class probes.",
        f"Method and field offset probing used up to {probe_limit} class candidates with valid names at the selected OFF_NAME.",
        "Method-count and field-count offsets were searched on 2-byte boundaries to catch 0x122/0x124-style layout drift.",
    ]

    if candidate_count == 0:
        notes.append(
            "No class candidates were found with the current self-reference pair; if OFF_ELEM/OFF_CAST moved, OFF_NAME brute-force evidence will also be limited."
        )

    if name_candidates:
        top = name_candidates[0]
        notes.append(
            "Top OFF_NAME candidate was "
            f"{hex32(top['offset'])} with {top['class_like_count']} class-like names and "
            f"{len(top['known_hits'])} known class hits."
        )

    if method_probe.get("best"):
        best = method_probe["best"]
        notes.append(
            "Best method probe was "
            f"OFF_METHODS={hex32(best['offsets']['OFF_METHODS'])}, "
            f"OFF_MCNT={hex32(best['offsets']['OFF_MCNT'])} "
            f"(score={best['score']}, valid_classes={best['valid_classes']})."
        )

    if field_probe.get("best"):
        best = field_probe["best"]
        layout = best.get("best_field_layout") or {}
        notes.append(
            "Best field probe was "
            f"OFF_FIELDS={hex32(best['offsets']['OFF_FIELDS'])}, "
            f"OFF_FCNT={hex32(best['offsets']['OFF_FCNT'])}, "
            f"layout={layout.get('label', 'unknown')} "
            f"(score={best['score']}, valid_classes={best['valid_classes']})."
        )

    return notes


def parse_args():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "dump_path",
        nargs="?",
        default=str(DEFAULT_DUMP_PATH),
        help=f"Path to the VRChat minidump (default: {DEFAULT_DUMP_PATH})",
    )
    parser.add_argument(
        "--probe-limit",
        type=int,
        default=256,
        help="Maximum class candidates to use when probing method/field offsets.",
    )
    parser.add_argument(
        "--output",
        default=str(OUTPUT_PATH),
        help=f"Output report path (default: {OUTPUT_PATH})",
    )
    return parser.parse_args()


def main() -> int:
    args = parse_args()
    dump_path = Path(args.dump_path)
    output_path = Path(args.output)

    if not dump_path.exists():
        print(f"[-] Dump file not found: {dump_path}")
        return 1

    print("[+] Opening dump...")
    started = time.time()
    dr = DumpReader(dump_path)
    print(f"    Loaded {len(dr.va_map)} VA ranges from {dump_path}")

    try:
        print("[+] Scanning heap with current offsets...")
        t0 = time.time()
        current_candidates = scan_class_candidates(
            dr,
            off_elem=CURRENT["OFF_ELEM"],
            off_cast=CURRENT["OFF_CAST"],
            off_name=CURRENT["OFF_NAME"],
            off_ns=CURRENT["OFF_NS"],
        )
        scan_elapsed = time.time() - t0
        current_base_vas = [int(item["va"]) for item in current_candidates]
        known_hits = find_known_hits(current_candidates)

        print(
            f"    Found {len(current_candidates)} candidate classes in {scan_elapsed:.1f}s; "
            f"known probes: {len(known_hits)}/{len(KNOWN_CLASS_NAMES)}"
        )

        selected_name_offset = CURRENT["OFF_NAME"]
        name_candidates: list[dict[str, object]] = []

        if len(known_hits) < 5:
            print("[+] Current OFF_NAME under threshold; brute-forcing OFF_NAME candidates...")
            t0 = time.time()
            name_candidates = brute_force_name_offsets(dr, current_base_vas)
            brute_elapsed = time.time() - t0
            if name_candidates:
                selected_name_offset = int(name_candidates[0]["offset"])
                top = name_candidates[0]
                print(
                    "    Best OFF_NAME candidate "
                    f"{hex32(selected_name_offset)} "
                    f"({top['class_like_count']} class-like, {len(top['known_hits'])} known hits) "
                    f"in {brute_elapsed:.1f}s"
                )
            else:
                print("    No alternative OFF_NAME candidates produced usable evidence.")
        else:
            print("[+] Current OFF_NAME found enough known classes; skipping brute-force fallback.")

        probe_classes = select_probe_classes(
            dr,
            current_base_vas,
            off_name=selected_name_offset,
            off_ns=CURRENT["OFF_NS"],
            limit=max(1, args.probe_limit),
        )

        print(
            f"[+] Probing method offsets on {len(probe_classes)} named class candidates..."
        )
        method_probe = probe_method_offsets(dr, probe_classes)
        if method_probe.get("best"):
            best = method_probe["best"]
            print(
                "    Best method combo: "
                f"OFF_METHODS={hex32(best['offsets']['OFF_METHODS'])}, "
                f"OFF_MCNT={hex32(best['offsets']['OFF_MCNT'])}, "
                f"score={best['score']}"
            )

        print(
            f"[+] Probing field offsets on {len(probe_classes)} named class candidates..."
        )
        field_probe = probe_field_offsets(dr, probe_classes)
        if field_probe.get("best"):
            best = field_probe["best"]
            layout = best.get("best_field_layout") or {}
            print(
                "    Best field combo: "
                f"OFF_FIELDS={hex32(best['offsets']['OFF_FIELDS'])}, "
                f"OFF_FCNT={hex32(best['offsets']['OFF_FCNT'])}, "
                f"layout={layout.get('label', 'unknown')}, "
                f"score={best['score']}"
            )

        current_method = method_probe["current"]
        current_field = field_probe["current"]
        current_offsets_valid = (
            len(known_hits) >= 5
            and current_method["valid_classes"] >= 3
            and current_field["valid_classes"] >= 3
        )

        suggested_offsets: dict[str, str] = {}
        if not current_offsets_valid:
            if name_candidates:
                top_name = name_candidates[0]
                if int(top_name["offset"]) != CURRENT["OFF_NAME"]:
                    suggested_offsets["OFF_NAME"] = hex32(int(top_name["offset"]))

            best_method = method_probe.get("best")
            if best_method:
                if best_method["offsets"]["OFF_METHODS"] != CURRENT["OFF_METHODS"]:
                    suggested_offsets["OFF_METHODS"] = hex32(best_method["offsets"]["OFF_METHODS"])
                if best_method["offsets"]["OFF_MCNT"] != CURRENT["OFF_MCNT"]:
                    suggested_offsets["OFF_MCNT"] = hex32(best_method["offsets"]["OFF_MCNT"])

            best_field = field_probe.get("best")
            if best_field:
                if best_field["offsets"]["OFF_FIELDS"] != CURRENT["OFF_FIELDS"]:
                    suggested_offsets["OFF_FIELDS"] = hex32(best_field["offsets"]["OFF_FIELDS"])
                if best_field["offsets"]["OFF_FCNT"] != CURRENT["OFF_FCNT"]:
                    suggested_offsets["OFF_FCNT"] = hex32(best_field["offsets"]["OFF_FCNT"])
                best_layout = best_field.get("best_field_layout") or {}
                if best_layout:
                    suggested_offsets["FI_STRIDE"] = hex32(best_layout["FI_STRIDE"])
                    suggested_offsets["FI_NAME"] = hex32(best_layout["FI_NAME"])

        notes = build_notes(
            candidate_count=len(current_candidates),
            known_hits=known_hits,
            name_candidates=name_candidates,
            method_probe=method_probe,
            field_probe=field_probe,
            probe_limit=len(probe_classes),
        )

        result = {
            "current_offsets_valid": current_offsets_valid,
            "known_classes_found": [
                {
                    "name": str(entry["name"]),
                    "namespace": str(entry["namespace"]),
                    "va": hex32(int(entry["va"])),
                }
                for entry in known_hits
            ],
            "suggested_offsets": suggested_offsets,
            "notes": notes,
            "probe_results": {
                "dump_path": str(dump_path),
                "scan_range": {
                    "start": hex32(HEAP_VA_START),
                    "end": hex32(HEAP_VA_END),
                },
                "current_offsets": {key: hex32(value) for key, value in CURRENT.items()},
                "current_candidate_count": len(current_candidates),
                "selected_name_offset": hex32(selected_name_offset),
                "name_offset_candidates": [
                    {
                        "offset": hex32(int(item["offset"])),
                        "class_like_count": int(item["class_like_count"]),
                        "known_hits": item["known_hits"],
                        "sample_names": item["sample_names"],
                    }
                    for item in name_candidates
                ],
                "method_probe": method_probe,
                "field_probe": field_probe,
                "probe_class_count": len(probe_classes),
                "generated": time.strftime("%Y-%m-%d %H:%M:%S"),
            },
        }

        output_path.parent.mkdir(parents=True, exist_ok=True)
        with output_path.open("w", encoding="utf-8") as fh:
            json.dump(result, fh, indent=2, ensure_ascii=False)

        total_elapsed = time.time() - started
        print("\n[+] Summary")
        print(f"    Current offsets valid: {current_offsets_valid}")
        print(
            f"    Known class probes found: {len(known_hits)}/{len(KNOWN_CLASS_NAMES)}"
        )
        if suggested_offsets:
            print("    Suggested offsets:")
            for key, value in suggested_offsets.items():
                print(f"      {key} = {value}")
        else:
            print("    Suggested offsets: none")
        print(f"    Report: {output_path}")
        print(f"    Total time: {total_elapsed:.1f}s")
        return 0
    finally:
        dr.close()


if __name__ == "__main__":
    raise SystemExit(main())
