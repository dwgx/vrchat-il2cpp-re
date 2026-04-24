#!/usr/bin/env python3
"""Lift cross-version method names with extended body-hash fuzzy rules."""

import argparse
import hashlib
import json
import math
import os
import re
import struct
import sys
import time
from collections import Counter, defaultdict

from capstone import CS_ARCH_X86, CS_GRP_JUMP, CS_MODE_64, Cs
from capstone.x86 import X86_INS_CALL, X86_INS_JMP, X86_OP_IMM, X86_OP_MEM, X86_REG_RIP

sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")

HASH_METHOD_RE = re.compile(r"^m_[0-9A-Fa-f]+$")
OBF_CHAR_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
ANON_CLASS_RE = re.compile(r"AnonymousType|DisplayClass|<.*>")
TRIVIAL_METHOD_NAMES = {
    ".ctor",
    ".cctor",
    "ToString",
    "Equals",
    "GetHashCode",
    "Invoke",
    "MoveNext",
    "Dispose",
    "Finalize",
    "Main",
}
DEFAULT_PREFIX_WINDOWS = (128, 192, 256)
DEFAULT_SUFFIX_WINDOWS = (64, 32)
HAMMING_WINDOW = 64
HAMMING_SEGMENT = 8
PREFIX_SUFFIX_WINDOW = 32


def parse_args():
    parser = argparse.ArgumentParser(
        description="Lift semantic method names by fuzzy matching canonicalized x64 bodies."
    )
    parser.add_argument("--old-dll", default="D:/WorkSpace/VRChat/GameAssembly.dll")
    parser.add_argument(
        "--new-dll",
        default="D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools/ida_new/GameAssembly.dll",
    )
    parser.add_argument("--old-precise", default="data/precise_dump_OLD_20260408.json")
    parser.add_argument("--new-precise", default="data/precise_dump.json")
    parser.add_argument(
        "--old-deobf", default="output/v_old_20260408_regen/deobfuscated_dump.json"
    )
    parser.add_argument("--new-deobf", default="output/deobfuscated_dump.json")
    parser.add_argument("--new-name-map", default="output/name_mapping.json")
    parser.add_argument(
        "--existing-cross-version",
        default="output/cross_version_method_names.json",
    )
    parser.add_argument("--output", default="output/cross_version_body_fuzzy.json")
    parser.add_argument(
        "--prefix-windows",
        default=",".join(str(window) for window in DEFAULT_PREFIX_WINDOWS),
        help="Comma-separated exact prefix windows.",
    )
    parser.add_argument(
        "--suffix-windows",
        default=",".join(str(window) for window in DEFAULT_SUFFIX_WINDOWS),
        help="Comma-separated exact suffix windows.",
    )
    parser.add_argument(
        "--hamming-threshold",
        type=float,
        default=0.08,
        help="Maximum differing-byte ratio for the 64-byte prefix fuzzy rule.",
    )
    return parser.parse_args()


def parse_windows(value):
    windows = []
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
    return tuple(dict.fromkeys(windows))


def load_json(path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path):
    parent = os.path.dirname(path)
    if parent:
        os.makedirs(parent, exist_ok=True)


def flatten_classes(dump):
    return [(namespace, cls) for namespace, classes in dump.get("namespaces", {}).items() for cls in classes]


def paired_classes(raw_dump, deobf_dump, label):
    raw_items = flatten_classes(raw_dump)
    deobf_items = flatten_classes(deobf_dump)
    if len(raw_items) != len(deobf_items):
        raise ValueError(f"{label}: class count mismatch {len(raw_items)} != {len(deobf_items)}")
    for index, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(zip(raw_items, deobf_items)):
        if raw_ns != deobf_ns:
            raise ValueError(
                f"{label}: namespace mismatch at class index {index}: {raw_ns!r} != {deobf_ns!r}"
            )
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods):
            raise ValueError(
                f"{label}: method count mismatch at class index {index}: "
                f"{len(raw_methods)} != {len(deobf_methods)}"
            )
        yield raw_ns, raw_cls, deobf_cls


def is_hash_method(name):
    return bool(name) and bool(HASH_METHOD_RE.fullmatch(name))


def is_skippable_class_name(name):
    return bool(name) and bool(ANON_CLASS_RE.search(name))


def is_nontrivial_semantic_method(class_name, method_name):
    if not method_name:
        return False
    if is_skippable_class_name(class_name):
        return False
    if method_name in TRIVIAL_METHOD_NAMES:
        return False
    if method_name.startswith("op_"):
        return False
    if method_name.startswith("<"):
        return False
    if is_hash_method(method_name):
        return False
    if OBF_CHAR_RE.search(method_name):
        return False
    return True


def parse_va(value):
    if not value:
        return None
    try:
        va = int(str(value), 16)
    except ValueError:
        return None
    return va if va else None


def resolve_method_va(raw_cls, deobf_cls, index):
    raw_methods = raw_cls.get("methods") or []
    deobf_methods = deobf_cls.get("methods") or []
    raw_name = raw_methods[index]
    deobf_name = deobf_methods[index]
    raw_map = raw_cls.get("method_pointers") or {}
    deobf_map = deobf_cls.get("method_pointers") or {}
    for mapping, name in (
        (deobf_map, deobf_name),
        (raw_map, raw_name),
        (deobf_map, raw_name),
        (raw_map, deobf_name),
    ):
        if name in mapping:
            va = parse_va(mapping[name])
            if va:
                return va
    return None


def iter_method_pointer_values(dump):
    for _, cls in flatten_classes(dump):
        for value in (cls.get("method_pointers") or {}).values():
            va = parse_va(value)
            if va:
                yield va


def parse_pe_image(path):
    with open(path, "rb") as handle:
        data = handle.read()
    if len(data) < 0x40:
        raise ValueError(f"{path}: file too small for DOS header")
    e_lfanew = struct.unpack_from("<I", data, 0x3C)[0]
    if data[e_lfanew : e_lfanew + 4] != b"PE\0\0":
        raise ValueError(f"{path}: missing PE signature")
    file_header_offset = e_lfanew + 4
    (_, section_count, _, _, _, optional_size, _) = struct.unpack_from(
        "<HHIIIHH", data, file_header_offset
    )
    optional_offset = file_header_offset + 20
    magic = struct.unpack_from("<H", data, optional_offset)[0]
    if magic != 0x20B:
        raise ValueError(f"{path}: expected PE32+ (PE64), got 0x{magic:04X}")
    section_offset = optional_offset + optional_size
    sections = []
    for index in range(section_count):
        offset = section_offset + (index * 40)
        name = data[offset : offset + 8].split(b"\0", 1)[0].decode("ascii", errors="ignore")
        virtual_size, virtual_address, raw_size, raw_offset, _, _, _, _, chars = (
            struct.unpack_from("<IIIIIIHHI", data, offset + 8)
        )
        if not (chars & 0x20000000):
            continue
        mapped = min(raw_size, max(0, len(data) - raw_offset))
        if mapped <= 0:
            continue
        sections.append(
            {
                "name": name,
                "virtual_address": virtual_address,
                "raw_offset": raw_offset,
                "mapped_size": mapped,
                "end_rva": virtual_address + mapped,
                "virtual_size": virtual_size,
            }
        )
    if not sections:
        raise ValueError(f"{path}: no executable sections found")
    return {
        "path": path,
        "data": data,
        "preferred_image_base": struct.unpack_from("<Q", data, optional_offset + 24)[0],
        "runtime_image_base": 0,
        "sections": sections,
    }


def infer_runtime_image_base(pe, dump):
    vas = list(iter_method_pointer_values(dump))
    if not vas:
        return pe["preferred_image_base"]
    low = (
        (max(vas) - max(section["end_rva"] for section in pe["sections"])) // 0x10000
    ) * 0x10000
    high = (
        (min(vas) - min(section["virtual_address"] for section in pe["sections"])) // 0x10000
    ) * 0x10000
    best_hits = -1
    best_base = pe["preferred_image_base"]
    for base in range(low, high + 1, 0x10000):
        hits = 0
        for va in vas:
            rva = va - base
            for section in pe["sections"]:
                if section["virtual_address"] <= rva < section["end_rva"]:
                    hits += 1
                    break
        if hits > best_hits:
            best_hits = hits
            best_base = base
    return best_base


def build_method_bounds(pe, dump):
    section_vas = defaultdict(set)
    for va in iter_method_pointer_values(dump):
        section = find_section_by_va(pe, va)
        if section is None:
            continue
        section_vas[section["name"]].add(va)

    next_va_by_va = {}
    for section in pe["sections"]:
        vas = sorted(section_vas.get(section["name"], ()))
        for index, va in enumerate(vas):
            next_va = vas[index + 1] if index + 1 < len(vas) else None
            next_va_by_va[va] = next_va
    return next_va_by_va


def find_section_by_va(pe, va):
    rva = va - pe["runtime_image_base"]
    for section in pe["sections"]:
        if section["virtual_address"] <= rva < section["end_rva"]:
            return section
    return None


def read_method_chunk(pe, va, next_va_by_va):
    section = find_section_by_va(pe, va)
    if section is None:
        return b""
    rva = va - pe["runtime_image_base"]
    offset = section["raw_offset"] + (rva - section["virtual_address"])
    next_va = next_va_by_va.get(va)
    if next_va is not None:
        end_rva = min(section["end_rva"], next_va - pe["runtime_image_base"])
    else:
        end_rva = section["end_rva"]
    end_offset = section["raw_offset"] + (end_rva - section["virtual_address"])
    end_offset = min(end_offset, section["raw_offset"] + section["mapped_size"], len(pe["data"]))
    if end_offset <= offset:
        return b""
    return pe["data"][offset:end_offset]


def build_disassembler():
    disasm = Cs(CS_ARCH_X86, CS_MODE_64)
    disasm.detail = True
    return disasm


def should_zero_rel32(insn):
    if getattr(insn, "imm_size", 0) != 4:
        return False
    if getattr(insn, "imm_offset", 0) <= 0:
        return False
    operands = getattr(insn, "operands", [])
    if len(operands) != 1 or operands[0].type != X86_OP_IMM:
        return False
    if insn.id == X86_INS_CALL:
        return True
    if insn.id == X86_INS_JMP:
        return True
    return insn.group(CS_GRP_JUMP)


def has_rip_relative_disp32(insn):
    if getattr(insn, "disp_size", 0) != 4:
        return False
    if getattr(insn, "disp_offset", 0) <= 0:
        return False
    for operand in getattr(insn, "operands", []):
        if operand.type == X86_OP_MEM and operand.mem.base == X86_REG_RIP:
            return True
    return False


def canonicalize_instruction(insn):
    normalized = bytearray(insn.bytes)
    if should_zero_rel32(insn):
        start = insn.imm_offset
        normalized[start : start + insn.imm_size] = b"\0" * insn.imm_size
    if has_rip_relative_disp32(insn):
        start = insn.disp_offset
        normalized[start : start + insn.disp_size] = b"\0" * insn.disp_size
    return bytes(normalized)


def is_padding_instruction(insn):
    return insn.mnemonic in {"nop", "int3"}


def canonicalize_method(pe, va, disasm, next_va_by_va):
    chunk = read_method_chunk(pe, va, next_va_by_va)
    if not chunk:
        return None
    chunk = chunk.rstrip(b"\x00\x90\xCC")
    if not chunk:
        return None

    instructions = []
    for insn in disasm.disasm(chunk, va):
        instructions.append((canonicalize_instruction(insn), is_padding_instruction(insn)))
    if not instructions:
        return None

    while instructions and instructions[-1][1]:
        instructions.pop()
    if not instructions:
        return None
    return b"".join(bytes_part for bytes_part, _ in instructions)


def digest_bytes(value):
    return hashlib.sha1(value).digest()[:16]


def classify_digest_map(counter_map):
    distinct = len(counter_map)
    unique_name = 0
    unresolved = 0
    for counts in counter_map.values():
        if len(counts) == 1:
            unique_name += 1
        else:
            unresolved += 1
    return {"distinct": distinct, "unique_name": unique_name, "unresolved": unresolved}


def build_old_semantic_methods(raw_dump, deobf_dump):
    method_count = 0
    conflict_count = 0
    va_to_names = defaultdict(set)
    for _, raw_cls, deobf_cls in paired_classes(raw_dump, deobf_dump, "old"):
        class_name = deobf_cls.get("name", "")
        for index, method_name in enumerate(deobf_cls.get("methods") or []):
            if not is_nontrivial_semantic_method(class_name, method_name):
                continue
            va = resolve_method_va(raw_cls, deobf_cls, index)
            if not va:
                continue
            method_count += 1
            va_to_names[va].add(method_name)
    entries = []
    for va, names in va_to_names.items():
        if len(names) == 1:
            entries.append((va, next(iter(names))))
        else:
            conflict_count += 1
    return method_count, entries, conflict_count


def has_nonhash_name_mapping(name_map_methods, raw_cls_name, deobf_cls_name, raw_method_name, deobf_method_name):
    keys = (
        f"{deobf_cls_name}::{raw_method_name}",
        f"{raw_cls_name}::{raw_method_name}",
        f"{deobf_cls_name}::{deobf_method_name}",
        f"{raw_cls_name}::{deobf_method_name}",
    )
    for key in keys:
        mapped = name_map_methods.get(key)
        if mapped and not is_hash_method(mapped):
            return True
    return False


def build_new_hash_targets(raw_dump, deobf_dump, existing_keys, name_map_methods):
    targets = []
    skipped_existing = 0
    skipped_named = 0
    skipped_anonymous = 0
    for _, raw_cls, deobf_cls in paired_classes(raw_dump, deobf_dump, "new"):
        raw_cls_name = raw_cls.get("name", "")
        class_name = deobf_cls.get("name", "")
        if is_skippable_class_name(class_name):
            skipped_anonymous += sum(
                1 for method_name in (deobf_cls.get("methods") or []) if is_hash_method(method_name)
            )
            continue
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        for index, method_name in enumerate(deobf_methods):
            if not is_hash_method(method_name):
                continue
            key = f"{class_name}::{method_name}"
            if key in existing_keys:
                skipped_existing += 1
                continue
            raw_method_name = raw_methods[index]
            if has_nonhash_name_mapping(
                name_map_methods,
                raw_cls_name,
                class_name,
                raw_method_name,
                method_name,
            ):
                skipped_named += 1
                continue
            va = resolve_method_va(raw_cls, deobf_cls, index)
            if va:
                targets.append({"key": key, "va": va})
    return targets, {
        "skipped_existing": skipped_existing,
        "skipped_nonhash_name_map": skipped_named,
        "skipped_anonymous_class": skipped_anonymous,
    }


def build_old_indexes(entries, pe, disasm, next_va_by_va, prefix_windows, suffix_windows):
    prefix_maps = {window: defaultdict(Counter) for window in prefix_windows}
    suffix_maps = {window: defaultdict(Counter) for window in suffix_windows}
    prefix_suffix_map = defaultdict(Counter)
    hamming_index = defaultdict(list)
    hamming_prefixes = []
    hamming_names = []
    stats = {"processed": 0, "failed": 0}

    for va, name in entries:
        normalized = canonicalize_method(pe, va, disasm, next_va_by_va)
        if not normalized:
            stats["failed"] += 1
            continue
        size = len(normalized)
        for window in prefix_windows:
            if size >= window:
                prefix_maps[window][digest_bytes(normalized[:window])][name] += 1
        for window in suffix_windows:
            if size >= window:
                suffix_maps[window][digest_bytes(normalized[-window:])][name] += 1
        if size >= PREFIX_SUFFIX_WINDOW * 2:
            pair = (
                digest_bytes(normalized[:PREFIX_SUFFIX_WINDOW]),
                digest_bytes(normalized[-PREFIX_SUFFIX_WINDOW:]),
            )
            prefix_suffix_map[pair][name] += 1
        if size >= HAMMING_WINDOW:
            prefix = normalized[:HAMMING_WINDOW]
            old_id = len(hamming_prefixes)
            hamming_prefixes.append(prefix)
            hamming_names.append(name)
            for band_index in range(HAMMING_WINDOW // HAMMING_SEGMENT):
                start = band_index * HAMMING_SEGMENT
                end = start + HAMMING_SEGMENT
                hamming_index[(band_index, prefix[start:end])].append(old_id)
        stats["processed"] += 1

    return {
        "prefix_maps": prefix_maps,
        "suffix_maps": suffix_maps,
        "prefix_suffix_map": prefix_suffix_map,
        "hamming_index": hamming_index,
        "hamming_prefixes": hamming_prefixes,
        "hamming_names": hamming_names,
        "stats": stats,
    }


def unique_name_from_counts(counts):
    if not counts or len(counts) != 1:
        return None
    return next(iter(counts))


def differing_bytes(left, right):
    return sum(1 for a, b in zip(left, right) if a != b)


def match_target(
    normalized,
    old_indexes,
    prefix_windows,
    suffix_windows,
    max_hamming_differences,
):
    size = len(normalized)

    for window in prefix_windows:
        if size < window:
            continue
        counts = old_indexes["prefix_maps"][window].get(digest_bytes(normalized[:window]))
        name = unique_name_from_counts(counts)
        if name:
            return name, f"prefix_{window}"

    if size >= PREFIX_SUFFIX_WINDOW * 2:
        pair = (
            digest_bytes(normalized[:PREFIX_SUFFIX_WINDOW]),
            digest_bytes(normalized[-PREFIX_SUFFIX_WINDOW:]),
        )
        name = unique_name_from_counts(old_indexes["prefix_suffix_map"].get(pair))
        if name:
            return name, f"prefix{PREFIX_SUFFIX_WINDOW}_suffix{PREFIX_SUFFIX_WINDOW}"

    for window in suffix_windows:
        if size < window:
            continue
        counts = old_indexes["suffix_maps"][window].get(digest_bytes(normalized[-window:]))
        name = unique_name_from_counts(counts)
        if name:
            return name, f"suffix_{window}"

    if size >= HAMMING_WINDOW:
        prefix = normalized[:HAMMING_WINDOW]
        candidate_band_hits = defaultdict(int)
        for band_index in range(HAMMING_WINDOW // HAMMING_SEGMENT):
            start = band_index * HAMMING_SEGMENT
            end = start + HAMMING_SEGMENT
            for old_id in old_indexes["hamming_index"].get((band_index, prefix[start:end]), ()):
                candidate_band_hits[old_id] += 1

        names = Counter()
        for old_id, shared_bands in candidate_band_hits.items():
            if shared_bands < 3:
                continue
            diff = differing_bytes(prefix, old_indexes["hamming_prefixes"][old_id])
            if diff <= max_hamming_differences:
                names[old_indexes["hamming_names"][old_id]] += 1
        name = unique_name_from_counts(names)
        if name:
            return name, f"hamming_{HAMMING_WINDOW}_{max_hamming_differences}bytes"

    return None, None


def build_rule_priority(prefix_windows, suffix_windows, max_hamming_differences):
    ordered_rules = []
    ordered_rules.extend(f"prefix_{window}" for window in prefix_windows)
    ordered_rules.append(f"prefix{PREFIX_SUFFIX_WINDOW}_suffix{PREFIX_SUFFIX_WINDOW}")
    ordered_rules.extend(f"suffix_{window}" for window in suffix_windows)
    ordered_rules.append(f"hamming_{HAMMING_WINDOW}_{max_hamming_differences}bytes")
    return {rule: index for index, rule in enumerate(ordered_rules)}


def main():
    started = time.perf_counter()
    args = parse_args()
    prefix_windows = parse_windows(args.prefix_windows)
    suffix_windows = parse_windows(args.suffix_windows)
    max_hamming_differences = int(math.floor(HAMMING_WINDOW * args.hamming_threshold))

    old_precise = load_json(args.old_precise)
    new_precise = load_json(args.new_precise)
    old_deobf = load_json(args.old_deobf)
    new_deobf = load_json(args.new_deobf)
    new_name_map = load_json(args.new_name_map)
    existing_cross_version = load_json(args.existing_cross_version)

    old_pe = parse_pe_image(args.old_dll)
    new_pe = parse_pe_image(args.new_dll)
    old_pe["runtime_image_base"] = infer_runtime_image_base(old_pe, old_deobf)
    new_pe["runtime_image_base"] = infer_runtime_image_base(new_pe, new_deobf)

    old_next_va_by_va = build_method_bounds(old_pe, old_deobf)
    new_next_va_by_va = build_method_bounds(new_pe, new_deobf)

    old_method_count, old_entries, conflicting_old_vas = build_old_semantic_methods(
        old_precise, old_deobf
    )
    new_targets, target_stats = build_new_hash_targets(
        new_precise,
        new_deobf,
        set(existing_cross_version),
        (new_name_map.get("methods") or {}),
    )

    disasm = build_disassembler()
    old_indexes = build_old_indexes(
        old_entries,
        old_pe,
        disasm,
        old_next_va_by_va,
        prefix_windows,
        suffix_windows,
    )

    rule_priority = build_rule_priority(prefix_windows, suffix_windows, max_hamming_differences)
    provisional = defaultdict(list)
    failed_new_disassembly = 0

    for target in new_targets:
        normalized = canonicalize_method(new_pe, target["va"], disasm, new_next_va_by_va)
        if not normalized:
            failed_new_disassembly += 1
            continue
        name, rule = match_target(
            normalized,
            old_indexes,
            prefix_windows,
            suffix_windows,
            max_hamming_differences,
        )
        if not name:
            continue
        provisional[target["key"]].append((name, rule))

    matches = {}
    match_rules = {}
    breakdown = Counter()
    key_conflicts = 0

    for key, candidates in provisional.items():
        names = {name for name, _ in candidates}
        if len(names) != 1:
            key_conflicts += 1
            continue
        name = next(iter(names))
        best_rule = min((rule for _, rule in candidates), key=lambda rule: rule_priority.get(rule, 9999))
        matches[key] = name
        match_rules[key] = best_rule
        breakdown[best_rule] += 1

    ordered = dict(sorted(matches.items()))
    ordered_keys = sorted(matches)
    ensure_parent_dir(args.output)
    with open(args.output, "w", encoding="utf-8") as handle:
        json.dump(ordered, handle, indent=2, ensure_ascii=False)
    with open(args.output, "r", encoding="utf-8") as handle:
        json.load(handle)

    elapsed = time.perf_counter() - started
    prefix_stats = {str(window): classify_digest_map(old_indexes["prefix_maps"][window]) for window in prefix_windows}
    suffix_stats = {str(window): classify_digest_map(old_indexes["suffix_maps"][window]) for window in suffix_windows}

    print(f"OLD runtime image base: 0x{old_pe['runtime_image_base']:X}")
    print(f"NEW runtime image base: 0x{new_pe['runtime_image_base']:X}")
    print(f"OLD non-trivial semantic methods with valid VA: {old_method_count}")
    print(f"OLD semantic entries after VA conflict collapse: {len(old_entries)}")
    print(f"OLD conflicting semantic VAs skipped: {conflicting_old_vas}")
    print(f"NEW hash targets considered: {len(new_targets)}")
    print(
        "NEW targets skipped: "
        f"existing-cross-version={target_stats['skipped_existing']}, "
        f"named-in-name-map={target_stats['skipped_nonhash_name_map']}, "
        f"anonymous-class={target_stats['skipped_anonymous_class']}"
    )
    print(
        "Disassembly stats: "
        f"OLD processed={old_indexes['stats']['processed']} failed={old_indexes['stats']['failed']}, "
        f"NEW failed={failed_new_disassembly}"
    )
    print(f"Conflicting duplicate output keys skipped: {key_conflicts}")
    print(f"Prefix hash stats: {json.dumps(prefix_stats, ensure_ascii=False)}")
    print(f"Suffix hash stats: {json.dumps(suffix_stats, ensure_ascii=False)}")
    print(f"New fuzzy matches written: {len(ordered)}")
    print("Breakdown by rule:")
    for rule, count in sorted(breakdown.items(), key=lambda item: (-item[1], item[0])):
        print(f"  {rule}: {count}")
    print("Top 20 samples:")
    for key in ordered_keys[:20]:
        name = matches[key]
        rule = match_rules[key]
        print(f"  {rule}: {key} -> {name}")
    print(f"Elapsed seconds: {elapsed:.2f}")


if __name__ == "__main__":
    main()
