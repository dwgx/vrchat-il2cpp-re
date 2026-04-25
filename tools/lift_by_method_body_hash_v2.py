#!/usr/bin/env python3
"""Lift semantic method names by canonicalizing x64 method bodies before hashing."""

import argparse
import hashlib
import json
import os
import re
import struct
import sys
from collections import Counter, defaultdict

from capstone import CS_ARCH_X86, CS_GRP_JUMP, CS_MODE_64, Cs
from capstone.x86 import X86_INS_CALL, X86_INS_JMP, X86_OP_IMM, X86_OP_MEM, X86_REG_RIP

sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")

HASH_METHOD_RE = re.compile(r"^m_[0-9A-Fa-f]+$")
OBF_CHAR_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
SAMPLE_CLASSES = ("VRCPlayer", "NetworkManager", "VRCUiManager", "VRC_Secondary")
DEFAULT_WINDOWS = (16, 24, 32, 48, 64, 96)


def parse_args():
    parser = argparse.ArgumentParser(
        description="Match old/new GameAssembly method bodies with x64 canonical hashing."
    )
    parser.add_argument("--old-dll", default="D:/WorkSpace/VRChat/GameAssembly.dll")
    parser.add_argument("--new-dll", default="D:/Steam/steamapps/common/VRChat/GameAssembly.dll")
    parser.add_argument("--old-precise", default="data/precise_dump_OLD_20260408.json")
    parser.add_argument("--new-precise", default="data/precise_dump.json")
    parser.add_argument(
        "--old-deobf", default="output/v_old_20260408_regen/deobfuscated_dump.json"
    )
    parser.add_argument("--new-deobf", default="output/deobfuscated_dump.json")
    parser.add_argument("--output", default="output/method_body_hash_lifts_v2.json")
    parser.add_argument(
        "--windows",
        default=",".join(str(window) for window in DEFAULT_WINDOWS),
        help="Comma-separated canonical byte windows used for progressive matching.",
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
        raise ValueError("At least one canonical window size is required")
    return tuple(sorted(dict.fromkeys(windows)))


def load_json(path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path):
    parent = os.path.dirname(path)
    if parent:
        os.makedirs(parent, exist_ok=True)


def flatten_classes(dump):
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]


def paired_classes(raw_dump, deobf_dump, label):
    raw_items = flatten_classes(raw_dump)
    deobf_items = flatten_classes(deobf_dump)
    if len(raw_items) != len(deobf_items):
        raise ValueError(f"{label}: class count mismatch {len(raw_items)} != {len(deobf_items)}")
    for index, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(
        zip(raw_items, deobf_items)
    ):
        if raw_ns != deobf_ns:
            raise ValueError(
                f"{label}: namespace mismatch at class index {index}: "
                f"{raw_ns!r} != {deobf_ns!r}"
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


def is_semantic_method(name):
    return (
        bool(name)
        and name not in {".ctor", ".cctor"}
        and not name.startswith("<")
        and not is_hash_method(name)
        and not OBF_CHAR_RE.search(name)
    )


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
    raw_mp = raw_cls.get("method_pointers") or {}
    deobf_mp = deobf_cls.get("method_pointers") or {}
    for mapping, name in (
        (deobf_mp, deobf_name),
        (raw_mp, raw_name),
        (deobf_mp, raw_name),
        (raw_mp, deobf_name),
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


def read_code_window(pe, va, size):
    rva = va - pe["runtime_image_base"]
    for section in pe["sections"]:
        if not (section["virtual_address"] <= rva < section["end_rva"]):
            continue
        offset = section["raw_offset"] + (rva - section["virtual_address"])
        end = min(
            len(pe["data"]),
            section["raw_offset"] + section["mapped_size"],
            offset + size,
        )
        return pe["data"][offset:end] if end > offset else b""
    return b""


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


def canonical_digest(pe, va, disasm, max_bytes):
    chunk = read_code_window(pe, va, max_bytes)
    if not chunk:
        return None, 0, 0
    normalized = bytearray()
    used_bytes = 0
    instruction_count = 0
    for insn in disasm.disasm(chunk, va):
        if used_bytes + insn.size > max_bytes:
            break
        normalized.extend(canonicalize_instruction(insn))
        used_bytes += insn.size
        instruction_count += 1
        if used_bytes >= max_bytes:
            break
    if not instruction_count:
        return None, 0, 0
    digest = hashlib.sha1(normalized).digest()[:16]
    return digest, instruction_count, used_bytes


def build_old_semantic_methods(raw_dump, deobf_dump):
    method_count = 0
    conflict_count = 0
    va_to_names = defaultdict(set)
    for _, raw_cls, deobf_cls in paired_classes(raw_dump, deobf_dump, "old"):
        for index, name in enumerate(deobf_cls.get("methods") or []):
            if not is_semantic_method(name):
                continue
            va = resolve_method_va(raw_cls, deobf_cls, index)
            if not va:
                continue
            method_count += 1
            va_to_names[va].add(name)
    entries = []
    for va, names in va_to_names.items():
        if len(names) == 1:
            entries.append((va, next(iter(names))))
        else:
            conflict_count += 1
    return method_count, entries, conflict_count


def build_new_hash_targets(raw_dump, deobf_dump):
    targets = []
    for _, raw_cls, deobf_cls in paired_classes(raw_dump, deobf_dump, "new"):
        class_name = deobf_cls.get("name", "")
        for index, name in enumerate(deobf_cls.get("methods") or []):
            if not is_hash_method(name):
                continue
            va = resolve_method_va(raw_cls, deobf_cls, index)
            if va:
                targets.append(
                    {
                        "key": f"{class_name}::{name}",
                        "class_name": class_name,
                        "va": va,
                    }
                )
    return targets


def build_old_hash_maps(entries, pe, disasm, windows):
    hash_maps = {window: defaultdict(Counter) for window in windows}
    stats = {"disassembled": 0, "failed": 0}
    for va, name in entries:
        first_digest = None
        for window in windows:
            digest, _, _ = canonical_digest(pe, va, disasm, window)
            if digest is None:
                continue
            first_digest = digest if first_digest is None else first_digest
            hash_maps[window][digest][name] += 1
        if first_digest is None:
            stats["failed"] += 1
            continue
        stats["disassembled"] += 1
    return hash_maps, stats


def classify_old_hashes(hash_to_names):
    distinct = len(hash_to_names)
    unique_name = 0
    collisions_resolved = 0
    collisions_unresolved = 0
    for counts in hash_to_names.values():
        total_methods = sum(counts.values())
        if len(counts) == 1:
            unique_name += 1
            if total_methods > 1:
                collisions_resolved += 1
        else:
            collisions_unresolved += 1
    return {
        "distinct": distinct,
        "unique_name": unique_name,
        "collisions_resolved": collisions_resolved,
        "collisions_unresolved": collisions_unresolved,
    }


def sample_lifts(lifts):
    samples = []
    seen = set()
    for class_name in SAMPLE_CLASSES:
        prefix = class_name + "::"
        matches = sorted(key for key in lifts if key.startswith(prefix))
        if not matches:
            continue
        key = matches[0]
        samples.append((key, lifts[key]))
        seen.add(key)
        if len(samples) >= 10:
            return samples
    for class_name in SAMPLE_CLASSES:
        prefix = class_name + "::"
        for key in sorted(key for key in lifts if key.startswith(prefix)):
            if key in seen:
                continue
            samples.append((key, lifts[key]))
            seen.add(key)
            if len(samples) >= 10:
                return samples
    for key in sorted(lifts):
        if key in seen:
            continue
        samples.append((key, lifts[key]))
        if len(samples) >= 10:
            break
    return samples


def main():
    args = parse_args()
    windows = parse_windows(args.windows)
    old_precise = load_json(args.old_precise)
    new_precise = load_json(args.new_precise)
    old_deobf = load_json(args.old_deobf)
    new_deobf = load_json(args.new_deobf)
    old_pe = parse_pe_image(args.old_dll)
    new_pe = parse_pe_image(args.new_dll)
    old_pe["runtime_image_base"] = infer_runtime_image_base(old_pe, old_deobf)
    new_pe["runtime_image_base"] = infer_runtime_image_base(new_pe, new_deobf)

    old_method_count, old_entries, conflicting_old_vas = build_old_semantic_methods(
        old_precise, old_deobf
    )
    new_targets = build_new_hash_targets(new_precise, new_deobf)

    disasm = build_disassembler()
    old_hash_maps, old_disasm_stats = build_old_hash_maps(old_entries, old_pe, disasm, windows)
    old_hash_stats = classify_old_hashes(old_hash_maps[windows[0]])

    lifts = {}
    direct_matches = 0
    collisions_resolved = 0
    unresolved_collisions = 0
    no_old_bucket = 0
    output_key_conflicts = 0
    new_disassembled = 0
    new_failed_disassembly = 0

    for target in new_targets:
        first_digest, _, _ = canonical_digest(new_pe, target["va"], disasm, windows[0])
        if first_digest is None:
            new_failed_disassembly += 1
            continue
        new_disassembled += 1
        matched_name = None
        seen_collision = False
        seen_bucket = False
        classified_miss = False
        for index, window in enumerate(windows):
            digest, _, _ = canonical_digest(new_pe, target["va"], disasm, window)
            if digest is None:
                break
            counts = old_hash_maps[window].get(digest)
            if not counts:
                if not seen_bucket:
                    no_old_bucket += 1
                elif seen_collision:
                    unresolved_collisions += 1
                classified_miss = True
                break
            seen_bucket = True
            if len(counts) == 1:
                matched_name = next(iter(counts))
                if index == 0:
                    direct_matches += 1
                else:
                    collisions_resolved += 1
                break
            seen_collision = True
        if matched_name is None:
            if seen_collision and not classified_miss:
                unresolved_collisions += 1
            continue
        existing = lifts.get(target["key"])
        if existing is not None and existing != matched_name:
            output_key_conflicts += 1
            continue
        lifts[target["key"]] = matched_name

    ordered = dict(sorted(lifts.items()))
    ensure_parent_dir(args.output)
    with open(args.output, "w", encoding="utf-8") as handle:
        json.dump(ordered, handle, indent=2, ensure_ascii=False)
    with open(args.output, "r", encoding="utf-8") as handle:
        json.load(handle)

    print(f"OLD methods with semantic name + valid VA: {old_method_count}")
    print(f"NEW hash methods with valid VA: {len(new_targets)}")
    print(
        f"Methods successfully disassembled: "
        f"OLD {old_disasm_stats['disassembled']} / {len(old_entries)}, "
        f"NEW {new_disassembled} / {len(new_targets)}"
    )
    print(f"OLD runtime image base: 0x{old_pe['runtime_image_base']:X}")
    print(f"NEW runtime image base: 0x{new_pe['runtime_image_base']:X}")
    print(
        f"Unique OLD canonical hashes: {old_hash_stats['distinct']} "
        f"(smallest window {windows[0]} bytes)"
    )
    print(f"OLD canonical hashes with unique semantic name: {old_hash_stats['unique_name']}")
    print(f"Direct matches: {direct_matches}")
    print(
        "Collisions resolved / unresolved: "
        f"{collisions_resolved} / {unresolved_collisions}"
    )
    print(f"Final lifts written: {len(ordered)}")
    print(f"Unmatched with no OLD canonical hash: {no_old_bucket}")
    if conflicting_old_vas:
        print(f"Skipped OLD VAs with conflicting semantic names: {conflicting_old_vas}")
    if old_disasm_stats["failed"] or new_failed_disassembly:
        print(
            f"Failed disassembly OLD / NEW: "
            f"{old_disasm_stats['failed']} / {new_failed_disassembly}"
        )
    if output_key_conflicts:
        print(f"Skipped conflicting output keys: {output_key_conflicts}")
    print("Sample lifts:")
    samples = sample_lifts(ordered)
    if samples:
        for key, value in samples:
            print(f"  {key} -> {value}")
    else:
        print("  (no sample lifts found for target classes)")

    if len(ordered) < 5000:
        print(
            "WARNING: lift count below 5000. Investigate canonicalization coverage, "
            "PE base inference, and input dump pairing."
        )


if __name__ == "__main__":
    main()
