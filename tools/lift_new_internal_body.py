#!/usr/bin/env python3
"""Propagate NEW internal semantic method names across identical canonical x64 bodies."""

from __future__ import annotations

import argparse
import hashlib
import json
import os
import re
import struct
import sys
from collections import Counter, defaultdict
from pathlib import Path

from capstone import CS_ARCH_X86, CS_GRP_JUMP, CS_MODE_64, Cs
from capstone.x86 import X86_INS_CALL, X86_INS_JMP, X86_OP_IMM, X86_OP_MEM, X86_REG_RIP


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


ROOT = Path(__file__).resolve().parent.parent
DEFAULT_DLL = ROOT / "ida_new" / "GameAssembly.dll"
DEFAULT_PRECISE = ROOT / "data" / "precise_dump.json"
DEFAULT_DEOBF = ROOT / "output" / "deobfuscated_dump.json"
DEFAULT_NAME_MAP = ROOT / "output" / "name_mapping.json"
DEFAULT_OUTPUT = ROOT / "output" / "new_internal_body_propagation.json"

HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$", re.I)
OBF_CHAR_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$", re.I)
WEAK_CLASS_RE = re.compile(
    r"^(BaseClass|Type|Static|Major|Service|Struct|Mono|DataOnly|Unknown|Record|NestedType|"
    r"EmptyType|EmptyStruct|AsyncStateMachine|Enumerator|Delegate|LifecycleComponent|"
    r"UpdateComponent|ComplexComponent|AnimatedTextureBase|NetworkItem|NetworkSyncable|"
    r"VRCUiManagerSibling|VRC_Main|VRC_Secondary|VRCUi|MajorSystem|TransformGame|UIRect|"
    r"GameObjectHandler|PointerEnter|VRCInit|InitializeVRSDK)\w*_[0-9A-F]+$",
    re.I,
)

TRIVIAL_SEMANTIC_NAMES = {
    ".ctor",
    ".cctor",
    "ToString",
    "Equals",
    "GetHashCode",
    "Dispose",
    "Finalize",
    "Invoke",
    "BeginInvoke",
    "EndInvoke",
    "MoveNext",
    "GetInstanceID",
    "CompareBaseObjects",
    "IsNativeObjectAlive",
    "StartCoroutine_Auto",
    "HasValue",
    "GetValueOrDefault",
    "get_name",
    "set_name",
    "get_hideFlags",
    "set_hideFlags",
}


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Propagate semantic names across NEW-version canonical method-body hash clusters."
    )
    parser.add_argument("--dll", default=str(DEFAULT_DLL))
    parser.add_argument("--precise", default=str(DEFAULT_PRECISE))
    parser.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    parser.add_argument("--name-map", default=str(DEFAULT_NAME_MAP))
    parser.add_argument("--output", default=str(DEFAULT_OUTPUT))
    parser.add_argument(
        "--windows",
        default="32,64",
        help="Comma-separated normalized-byte windows to hash.",
    )
    parser.add_argument(
        "--read-bytes",
        type=int,
        default=128,
        help="Bytes read from the mapped VA before disassembly/canonicalization.",
    )
    parser.add_argument(
        "--sample-count",
        type=int,
        default=10,
        help="How many sample propagated entries to print.",
    )
    return parser.parse_args()


def parse_windows(value: str) -> tuple[int, ...]:
    windows: list[int] = []
    for piece in str(value).split(","):
        piece = piece.strip()
        if not piece:
            continue
        size = int(piece)
        if size <= 0:
            raise ValueError(f"Window sizes must be positive, got {size}")
        windows.append(size)
    if not windows:
        raise ValueError("At least one window size is required")
    return tuple(sorted(dict.fromkeys(windows)))


def load_json(path: str | Path) -> dict:
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path: str | Path) -> None:
    parent = Path(path).parent
    if str(parent):
        parent.mkdir(parents=True, exist_ok=True)


def stable_hash(name: str, length: int = 3) -> str:
    # Match the repo's current deobfuscate.py implementation.
    return hashlib.sha256(name.encode("utf-8")).hexdigest()[:length].upper()


def flat_classes(dump: dict):
    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            yield namespace, cls


def pair_classes(raw_dump: dict, deobf_dump: dict):
    raw_items = list(flat_classes(raw_dump))
    deobf_items = list(flat_classes(deobf_dump))
    if len(raw_items) != len(deobf_items):
        raise ValueError(f"class count mismatch: {len(raw_items)} != {len(deobf_items)}")
    for index, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(zip(raw_items, deobf_items)):
        if raw_ns != deobf_ns:
            raise ValueError(
                f"namespace mismatch at class index {index}: {raw_ns!r} != {deobf_ns!r}"
            )
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods):
            raise ValueError(
                f"method count mismatch at class index {index}: "
                f"{raw_cls.get('name')!r} ({len(raw_methods)}) != "
                f"{deobf_cls.get('name')!r} ({len(deobf_methods)})"
            )
        yield raw_ns, raw_cls, deobf_cls


def parse_va(value) -> int | None:
    if not value:
        return None
    try:
        parsed = int(str(value), 16)
    except ValueError:
        return None
    return parsed if parsed else None


def iter_method_pointer_values(dump: dict):
    for _, cls in flat_classes(dump):
        for value in (cls.get("method_pointers") or {}).values():
            va = parse_va(value)
            if va:
                yield va


def build_disassembler() -> Cs:
    disasm = Cs(CS_ARCH_X86, CS_MODE_64)
    disasm.detail = True
    return disasm


def is_hash_method(name: str) -> bool:
    return bool(name) and bool(HASH_METHOD_RE.fullmatch(name))


def is_compiler_generated(name: str) -> bool:
    return bool(name) and (
        "<" in name
        or ">" in name
        or name.startswith("$")
        or name.startswith("__StaticArrayInitTypeSize")
    )


def is_strong_class(name: str) -> bool:
    if not name:
        return False
    if OBF_CHAR_RE.search(name):
        return False
    if is_compiler_generated(name):
        return False
    if HEX_SUFFIX_RE.search(name):
        return False
    if WEAK_CLASS_RE.fullmatch(name):
        return False
    return True


def is_simple_target_class_name(name: str) -> bool:
    return bool(name) and "`" not in name and "::" not in name


def is_non_trivial_semantic_name(name: str) -> bool:
    if not name:
        return False
    if OBF_CHAR_RE.search(name):
        return False
    if is_hash_method(name):
        return False
    if is_compiler_generated(name):
        return False
    if name in TRIVIAL_SEMANTIC_NAMES:
        return False
    if name.startswith("op_"):
        return False
    return True


def resolve_method_va(raw_cls: dict, deobf_cls: dict, method_index: int) -> int | None:
    raw_methods = raw_cls.get("methods") or []
    deobf_methods = deobf_cls.get("methods") or []
    raw_name = raw_methods[method_index]
    deobf_name = deobf_methods[method_index]
    raw_ptrs = raw_cls.get("method_pointers") or {}
    deobf_ptrs = deobf_cls.get("method_pointers") or {}
    for mapping, key in (
        (raw_ptrs, raw_name),
        (deobf_ptrs, deobf_name),
        (raw_ptrs, deobf_name),
        (deobf_ptrs, raw_name),
    ):
        if key in mapping:
            va = parse_va(mapping[key])
            if va:
                return va
    return None


def parse_pe64(path: str | Path) -> dict:
    data = Path(path).read_bytes()
    if len(data) < 0x40:
        raise ValueError(f"{path}: file too small for DOS header")
    e_lfanew = struct.unpack_from("<I", data, 0x3C)[0]
    if data[e_lfanew : e_lfanew + 4] != b"PE\0\0":
        raise ValueError(f"{path}: missing PE signature")

    file_header_offset = e_lfanew + 4
    machine, section_count, _, _, _, optional_size, _ = struct.unpack_from(
        "<HHIIIHH", data, file_header_offset
    )
    if machine != 0x8664:
        raise ValueError(f"{path}: expected PE64 x64 machine 0x8664, got 0x{machine:04X}")

    optional_offset = file_header_offset + 20
    magic = struct.unpack_from("<H", data, optional_offset)[0]
    if magic != 0x20B:
        raise ValueError(f"{path}: expected PE32+ optional header, got 0x{magic:04X}")

    image_base = struct.unpack_from("<Q", data, optional_offset + 24)[0]
    section_offset = optional_offset + optional_size
    sections = []
    exec_sections = []

    for index in range(section_count):
        offset = section_offset + index * 40
        name = data[offset : offset + 8].split(b"\0", 1)[0].decode("ascii", errors="ignore")
        virtual_size, virtual_address, raw_size, raw_offset, _, _, _, _, characteristics = (
            struct.unpack_from("<IIIIIIHHI", data, offset + 8)
        )
        mapped_size = min(raw_size, max(0, len(data) - raw_offset))
        if mapped_size <= 0:
            continue
        entry = {
            "name": name,
            "virtual_address": virtual_address,
            "virtual_size": virtual_size,
            "raw_offset": raw_offset,
            "mapped_size": mapped_size,
            "mapped_end_rva": virtual_address + mapped_size,
            "characteristics": characteristics,
        }
        sections.append(entry)
        if characteristics & 0x20000000:
            exec_sections.append(entry)

    if not exec_sections:
        raise ValueError(f"{path}: no executable sections found")

    return {
        "path": str(path),
        "data": data,
        "preferred_image_base": image_base,
        "runtime_image_base": 0,
        "sections": sections,
        "exec_sections": exec_sections,
    }


def infer_runtime_base(pe: dict, dump: dict) -> int:
    vas = list(iter_method_pointer_values(dump))
    if not vas:
        pe["runtime_image_base"] = pe["preferred_image_base"]
        return pe["runtime_image_base"]

    low = (
        (max(vas) - max(section["mapped_end_rva"] for section in pe["exec_sections"])) // 0x10000
    ) * 0x10000
    high = (
        (min(vas) - min(section["virtual_address"] for section in pe["exec_sections"])) // 0x10000
    ) * 0x10000

    best_base = pe["preferred_image_base"]
    best_hits = -1
    for base in range(low, high + 1, 0x10000):
        hits = 0
        for va in vas:
            rva = va - base
            for section in pe["exec_sections"]:
                if section["virtual_address"] <= rva < section["mapped_end_rva"]:
                    hits += 1
                    break
        if hits > best_hits:
            best_hits = hits
            best_base = base

    pe["runtime_image_base"] = best_base
    return best_base


def va_to_file_offset(pe: dict, va: int) -> int | None:
    rva = va - pe["runtime_image_base"]
    for section in pe["sections"]:
        if section["virtual_address"] <= rva < section["mapped_end_rva"]:
            return section["raw_offset"] + (rva - section["virtual_address"])
    return None


def read_code_bytes(pe: dict, va: int, size: int) -> bytes:
    file_offset = va_to_file_offset(pe, va)
    if file_offset is None:
        return b""
    end = min(len(pe["data"]), file_offset + size)
    return pe["data"][file_offset:end] if end > file_offset else b""


def should_zero_rel32(insn) -> bool:
    if getattr(insn, "imm_size", 0) != 4:
        return False
    if getattr(insn, "imm_offset", 0) <= 0:
        return False
    operands = getattr(insn, "operands", [])
    if len(operands) != 1 or operands[0].type != X86_OP_IMM:
        return False
    if insn.id in {X86_INS_CALL, X86_INS_JMP}:
        return True
    return insn.group(CS_GRP_JUMP)


def has_rip_relative_disp32(insn) -> bool:
    if getattr(insn, "disp_size", 0) != 4:
        return False
    if getattr(insn, "disp_offset", 0) <= 0:
        return False
    for operand in getattr(insn, "operands", []):
        if operand.type == X86_OP_MEM and operand.mem.base == X86_REG_RIP:
            return True
    return False


def canonicalize_instruction(insn) -> bytes:
    normalized = bytearray(insn.bytes)
    if should_zero_rel32(insn):
        start = insn.imm_offset
        normalized[start : start + insn.imm_size] = b"\0" * insn.imm_size
    if has_rip_relative_disp32(insn):
        start = insn.disp_offset
        normalized[start : start + insn.disp_size] = b"\0" * insn.disp_size
    return bytes(normalized)


def canonical_windows(pe: dict, va: int, disasm: Cs, read_bytes: int, windows: tuple[int, ...]) -> dict[int, str]:
    chunk = read_code_bytes(pe, va, read_bytes)
    if not chunk:
        return {}

    normalized = bytearray()
    digests: dict[int, str] = {}

    for insn in disasm.disasm(chunk, va):
        normalized.extend(canonicalize_instruction(insn))
        for window in windows:
            if window not in digests and len(normalized) >= window:
                digests[window] = hashlib.sha256(normalized[:window]).hexdigest()

    if not normalized:
        return {}

    for window in windows:
        if window not in digests:
            digests[window] = hashlib.sha256(normalized).hexdigest()

    return digests


def build_method_records(
    raw_dump: dict,
    deobf_dump: dict,
    name_map: dict,
) -> list[dict]:
    method_name_map = name_map.get("methods") or {}
    records: list[dict] = []
    for namespace, raw_cls, deobf_cls in pair_classes(raw_dump, deobf_dump):
        raw_class_name = raw_cls.get("name", "")
        semantic_class_name = deobf_cls.get("name", "")
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []

        for index, raw_method_name in enumerate(raw_methods):
            va = resolve_method_va(raw_cls, deobf_cls, index)
            if not va:
                continue

            map_key = f"{raw_class_name}::{raw_method_name}"
            current_name = method_name_map.get(map_key, deobf_methods[index])
            hash_name = f"m_{stable_hash(raw_method_name, 3)}"

            records.append(
                {
                    "namespace": namespace,
                    "raw_class_name": raw_class_name,
                    "semantic_class_name": semantic_class_name,
                    "raw_method_name": raw_method_name,
                    "current_name": current_name,
                    "deobf_name": deobf_methods[index],
                    "hash_name": hash_name,
                    "va": va,
                }
            )
    return records


def cluster_records(
    records: list[dict],
    pe: dict,
    disasm: Cs,
    windows: tuple[int, ...],
    read_bytes: int,
):
    clusters: dict[tuple[int, str], list[dict]] = defaultdict(list)
    stats = Counter()
    for record in records:
        digests = canonical_windows(pe, record["va"], disasm, read_bytes, windows)
        if not digests:
            stats["hash_failures"] += 1
            continue
        stats["hashed_methods"] += 1
        for window, digest in digests.items():
            clusters[(window, digest)].append(record)
            stats[f"window_{window}"] += 1
    return clusters, stats


def choose_unique_semantic(records: list[dict]) -> str | None:
    semantic_names = {
        record["current_name"]
        for record in records
        if is_non_trivial_semantic_name(record["current_name"])
    }
    if len(semantic_names) != 1:
        return None
    return next(iter(semantic_names))


def build_propagation(clusters: dict[tuple[int, str], list[dict]]) -> tuple[dict[str, str], dict]:
    propagated: dict[str, str] = {}
    cluster_counts = Counter()
    source_clusters = 0
    ambiguous_clusters = 0
    source_name_counts = Counter()
    samples: list[dict] = []

    for (window, digest), members in clusters.items():
        if len(members) < 2:
            continue
        cluster_counts[window] += 1
        semantic_name = choose_unique_semantic(members)
        if semantic_name is None:
            semantic_candidates = {
                member["current_name"]
                for member in members
                if is_non_trivial_semantic_name(member["current_name"])
            }
            if len(semantic_candidates) > 1:
                ambiguous_clusters += 1
            continue

        targets_in_cluster = 0
        for member in members:
            if not is_hash_method(member["current_name"]):
                continue
            if not is_strong_class(member["semantic_class_name"]):
                continue
            if not is_simple_target_class_name(member["semantic_class_name"]):
                continue
            target_key = f"{member['semantic_class_name']}::{member['hash_name']}"
            if not HASH_METHOD_RE.fullmatch(member["hash_name"]):
                continue
            existing = propagated.get(target_key)
            if existing is None:
                propagated[target_key] = semantic_name
                source_name_counts[semantic_name] += 1
                targets_in_cluster += 1
                if len(samples) < 100:
                    samples.append(
                        {
                            "key": target_key,
                            "name": semantic_name,
                            "window": window,
                            "cluster_size": len(members),
                            "digest": digest[:12],
                        }
                    )
            elif existing != semantic_name:
                del propagated[target_key]

        if targets_in_cluster:
            source_clusters += 1

    return propagated, {
        "cluster_counts": dict(cluster_counts),
        "repeated_cluster_total": sum(cluster_counts.values()),
        "source_clusters": source_clusters,
        "ambiguous_clusters": ambiguous_clusters,
        "source_name_counts": source_name_counts,
        "samples": samples,
    }


def main() -> int:
    args = parse_args()
    windows = parse_windows(args.windows)

    raw_dump = load_json(args.precise)
    deobf_dump = load_json(args.deobf)
    name_map = load_json(args.name_map)

    pe = parse_pe64(args.dll)
    infer_runtime_base(pe, raw_dump)
    disasm = build_disassembler()

    records = build_method_records(raw_dump, deobf_dump, name_map)
    clusters, hash_stats = cluster_records(records, pe, disasm, windows, args.read_bytes)
    propagated, propagation_stats = build_propagation(clusters)

    ensure_parent_dir(args.output)
    with Path(args.output).open("w", encoding="utf-8") as handle:
        json.dump(dict(sorted(propagated.items())), handle, indent=2, ensure_ascii=False)

    sample_items = sorted(
        propagation_stats["samples"],
        key=lambda item: (-item["cluster_size"], item["window"], item["key"]),
    )[: max(0, args.sample_count)]

    print(f"Runtime image base: 0x{pe['runtime_image_base']:X}")
    print(f"Methods considered: {len(records)}")
    print(f"Methods hashed: {hash_stats['hashed_methods']}")
    print(f"Hash failures: {hash_stats['hash_failures']}")
    print(f"Clusters>=2: {propagation_stats['repeated_cluster_total']}")
    for window in windows:
        print(f"  Window {window}: {propagation_stats['cluster_counts'].get(window, 0)}")
    print(f"Ambiguous semantic clusters: {propagation_stats['ambiguous_clusters']}")
    print(f"Source clusters with propagation: {propagation_stats['source_clusters']}")
    print(f"Propagations: {len(propagated)}")
    print("Top semantic names:")
    for name, count in propagation_stats["source_name_counts"].most_common(10):
        print(f"  {name}: {count}")
    print(f"Output: {args.output}")
    print("Sample propagated entries:")
    for item in sample_items:
        print(
            f"  [{item['window']}] {item['key']} -> {item['name']} "
            f"(cluster={item['cluster_size']}, hash={item['digest']})"
        )

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
