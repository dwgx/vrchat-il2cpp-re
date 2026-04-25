#!/usr/bin/env python3
"""Lift semantic method names by hashing executable code windows across DLL versions."""

import argparse
import hashlib
import json
import os
import re
import struct
import sys
from collections import defaultdict

sys.stdout.reconfigure(encoding="utf-8")

HASH_METHOD_RE = re.compile(r"^m_[0-9A-Fa-f]+$")
OBF_CHAR_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
WINDOWS = (256, 512, 1024, 2048)
SAMPLE_CLASSES = ("VRCPlayer", "NetworkManager", "VRCUiManager")


def parse_args():
    p = argparse.ArgumentParser(
        description="Match old/new GameAssembly method bodies and lift semantic names."
    )
    p.add_argument("--old-dll", default="D:/WorkSpace/VRChat/GameAssembly.dll")
    p.add_argument("--new-dll", default="D:/Steam/steamapps/common/VRChat/GameAssembly.dll")
    p.add_argument("--old-precise", default="data/precise_dump_OLD_20260408.json")
    p.add_argument("--new-precise", default="data/precise_dump.json")
    p.add_argument(
        "--old-deobf", default="output/v_old_20260408_regen/deobfuscated_dump.json"
    )
    p.add_argument("--new-deobf", default="output/deobfuscated_dump.json")
    p.add_argument("--output", default="output/method_body_hash_lifts.json")
    return p.parse_args()


def load_json(path):
    with open(path, "r", encoding="utf-8") as f:
        return json.load(f)


def ensure_parent_dir(path):
    parent = os.path.dirname(path)
    if parent:
        os.makedirs(parent, exist_ok=True)


def flatten_classes(dump):
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]


def paired_classes(raw_dump, deobf_dump, label):
    raw_items, deobf_items = flatten_classes(raw_dump), flatten_classes(deobf_dump)
    if len(raw_items) != len(deobf_items):
        raise ValueError(
            f"{label}: class count mismatch {len(raw_items)} != {len(deobf_items)}"
        )
    for i, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(
        zip(raw_items, deobf_items)
    ):
        if raw_ns != deobf_ns:
            raise ValueError(
                f"{label}: namespace mismatch at class index {i}: "
                f"{raw_ns!r} != {deobf_ns!r}"
            )
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods):
            raise ValueError(
                f"{label}: method count mismatch at class index {i}: "
                f"{len(raw_methods)} != {len(deobf_methods)}"
            )
        yield raw_ns, raw_cls, deobf_cls


def is_hash_method(name):
    return bool(name) and bool(HASH_METHOD_RE.fullmatch(name))


def is_semantic_method(name):
    return bool(name) and name not in {".ctor", ".cctor"} and not name.startswith("<") and not is_hash_method(name) and not OBF_CHAR_RE.search(name)


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
    raw_name, deobf_name = raw_methods[index], deobf_methods[index]
    raw_mp, deobf_mp = raw_cls.get("method_pointers") or {}, deobf_cls.get("method_pointers") or {}
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
    with open(path, "rb") as f:
        data = f.read()
    if len(data) < 0x40:
        raise ValueError(f"{path}: file too small for DOS header")
    e_lfanew = struct.unpack_from("<I", data, 0x3C)[0]
    if data[e_lfanew : e_lfanew + 4] != b"PE\0\0":
        raise ValueError(f"{path}: missing PE signature")
    fh_off = e_lfanew + 4
    (_, section_count, _, _, _, opt_size, _) = struct.unpack_from("<HHIIIHH", data, fh_off)
    opt_off = fh_off + 20
    magic = struct.unpack_from("<H", data, opt_off)[0]
    if magic != 0x20B:
        raise ValueError(f"{path}: expected PE32+ (PE64), got 0x{magic:04X}")
    sec_off = opt_off + opt_size
    sections = []
    for i in range(section_count):
        off = sec_off + (i * 40)
        name = data[off : off + 8].split(b"\0", 1)[0].decode("ascii", errors="ignore")
        vs, va, rs, ro, _, _, _, _, chars = struct.unpack_from("<IIIIIIHHI", data, off + 8)
        if not (chars & 0x20000000):
            continue
        mapped = min(rs, max(0, len(data) - ro))
        if mapped > 0:
            sections.append(
                {
                    "name": name,
                    "virtual_address": va,
                    "raw_offset": ro,
                    "mapped_size": mapped,
                    "end_rva": va + mapped,
                }
            )
    if not sections:
        raise ValueError(f"{path}: no executable sections found")
    return {
        "path": path,
        "data": data,
        "preferred_image_base": struct.unpack_from("<Q", data, opt_off + 24)[0],
        "runtime_image_base": 0,
        "sections": sections,
    }


def infer_runtime_image_base(pe, dump):
    vas = list(iter_method_pointer_values(dump))
    if not vas:
        return pe["preferred_image_base"]
    lo = (
        (max(vas) - max(section["end_rva"] for section in pe["sections"])) // 0x10000
    ) * 0x10000
    hi = (
        (min(vas) - min(section["virtual_address"] for section in pe["sections"])) // 0x10000
    ) * 0x10000
    best_hits, best_base = -1, pe["preferred_image_base"]
    for base in range(lo, hi + 1, 0x10000):
        hits = 0
        for va in vas:
            rva = va - base
            for section in pe["sections"]:
                if section["virtual_address"] <= rva < section["end_rva"]:
                    hits += 1
                    break
        if hits > best_hits:
            best_hits, best_base = hits, base
    return best_base


def read_code_window(pe, va, size):
    rva = va - pe["runtime_image_base"]
    for section in pe["sections"]:
        if not (section["virtual_address"] <= rva < section["end_rva"]):
            continue
        off = section["raw_offset"] + (rva - section["virtual_address"])
        end = min(
            len(pe["data"]),
            section["raw_offset"] + section["mapped_size"],
            off + size,
        )
        return pe["data"][off:end] if end > off else b""
    return b""


def digest_window(pe, va, size):
    chunk = read_code_window(pe, va, size)
    return hashlib.sha1(chunk).digest()[:16] if chunk else None


def build_old_semantic_methods(raw_dump, deobf_dump):
    method_count, conflict_count = 0, 0
    va_to_names = defaultdict(set)
    for _, raw_cls, deobf_cls in paired_classes(raw_dump, deobf_dump, "old"):
        for i, name in enumerate(deobf_cls.get("methods") or []):
            if not is_semantic_method(name):
                continue
            va = resolve_method_va(raw_cls, deobf_cls, i)
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
        for i, name in enumerate(deobf_cls.get("methods") or []):
            if not is_hash_method(name):
                continue
            va = resolve_method_va(raw_cls, deobf_cls, i)
            if va:
                targets.append({"key": f"{class_name}::{name}", "class_name": class_name, "va": va})
    return targets


def build_hash_maps(old_entries, pe):
    maps = {window: defaultdict(list) for window in WINDOWS}
    for va, name in old_entries:
        for window in WINDOWS:
            digest = digest_window(pe, va, window)
            if digest is not None:
                maps[window][digest].append((va, name))
    return maps


def sample_lifts(lifts):
    out = []
    for class_name in SAMPLE_CLASSES:
        prefix = class_name + "::"
        for key in sorted(k for k in lifts if k.startswith(prefix)):
            out.append((key, lifts[key]))
            if len(out) >= 10:
                return out
    return out


def main():
    args = parse_args()
    old_precise, new_precise = load_json(args.old_precise), load_json(args.new_precise)
    old_deobf, new_deobf = load_json(args.old_deobf), load_json(args.new_deobf)
    old_pe, new_pe = parse_pe_image(args.old_dll), parse_pe_image(args.new_dll)
    old_pe["runtime_image_base"] = infer_runtime_image_base(old_pe, old_deobf)
    new_pe["runtime_image_base"] = infer_runtime_image_base(new_pe, new_deobf)
    old_method_count, old_entries, conflicting_old_vas = build_old_semantic_methods(
        old_precise, old_deobf
    )
    new_targets = build_new_hash_targets(new_precise, new_deobf)
    old_hash_maps = build_hash_maps(old_entries, old_pe)
    lifts, direct_hits, ambiguous_hits, failed, output_key_conflicts = {}, 0, 0, 0, 0

    for target in new_targets:
        matched_name, direct = None, False
        digest = digest_window(new_pe, target["va"], WINDOWS[0])
        candidates = old_hash_maps[WINDOWS[0]].get(digest, []) if digest else []
        if len(candidates) == 1:
            matched_name, direct = candidates[0][1], True
        elif len(candidates) > 1:
            for window in WINDOWS[1:]:
                digest = digest_window(new_pe, target["va"], window)
                if digest is None:
                    continue
                candidates = old_hash_maps[window].get(digest, [])
                if len(candidates) == 1:
                    matched_name = candidates[0][1]
                    break
        if matched_name is None:
            failed += 1
            continue
        existing = lifts.get(target["key"])
        if existing is not None and existing != matched_name:
            output_key_conflicts += 1
            continue
        lifts[target["key"]] = matched_name
        direct_hits += 1 if direct else 0
        ambiguous_hits += 0 if direct else 1

    ensure_parent_dir(args.output)
    ordered = dict(sorted(lifts.items()))
    with open(args.output, "w", encoding="utf-8") as f:
        json.dump(ordered, f, indent=2, ensure_ascii=False)
    with open(args.output, "r", encoding="utf-8") as f:
        json.load(f)

    unique_old = sum(1 for values in old_hash_maps[WINDOWS[0]].values() if len(values) == 1)
    print(f"OLD methods with semantic name + valid VA: {old_method_count}")
    print(f"NEW hash methods with valid VA: {len(new_targets)}")
    print(f"OLD runtime image base: 0x{old_pe['runtime_image_base']:X}")
    print(f"NEW runtime image base: 0x{new_pe['runtime_image_base']:X}")
    print(f"Unique OLD hash signatures: {unique_old}")
    print(f"Direct hits (unique OLD match): {direct_hits}")
    print(f"Ambiguous (needed larger window): {ambiguous_hits}")
    print(f"Failed to disambiguate: {failed}")
    print(f"Final lifts written: {len(ordered)}")
    if conflicting_old_vas:
        print(f"Skipped OLD VAs with conflicting semantic names: {conflicting_old_vas}")
    if output_key_conflicts:
        print(f"Skipped conflicting output keys: {output_key_conflicts}")
    print("Sample lifts:")
    samples = sample_lifts(ordered)
    if samples:
        for key, value in samples:
            print(f"  {key} -> {value}")
    else:
        print("  (no sample lifts found for target classes)")


if __name__ == "__main__":
    main()
