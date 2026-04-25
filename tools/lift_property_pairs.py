#!/usr/bin/env python3
"""Identify high-confidence getter/setter hash-method pairs by native field offset."""

from __future__ import annotations

import argparse
import json
import re
import struct
import sys
from collections import defaultdict
from dataclasses import dataclass
from pathlib import Path

import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import X86_GRP_JUMP, X86_OP_MEM, X86_OP_REG, X86_REG_RIP


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


ROOT = Path(__file__).resolve().parent.parent
HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$")
STRONG_CLASS_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$")
BACKING_FIELD_RE = re.compile(r"^<(.+)>k__BackingField$")
GENERIC_FIELD_RE = re.compile(r"^(?:f|field)_[0-9A-F]{2,}$", re.I)
BOOL_PREFIXES = (
    "Is",
    "Has",
    "Can",
    "Should",
    "Was",
    "Will",
    "Use",
    "Allow",
    "Enable",
    "Enabled",
    "Disable",
    "Disabled",
    "Visible",
    "Active",
    "Ready",
    "Valid",
    "Dirty",
    "Loaded",
    "Playing",
    "Running",
    "Focused",
    "Expanded",
    "Selected",
    "Checked",
)
TERM_MNEMONICS = {"ret", "retf", "int3", "ud2"}
SKIP_MNEMONICS = {"nop"}
STACK_MNEMONICS = {"push", "pop"}
ARITH_MNEMONICS = {"sub", "add"}
RETURN_REG_FAMILIES = {"rax", "xmm0"}
ARG1_REG_FAMILIES = {"rdx", "xmm1"}
START_SHIFTS = [0, -1, -2, -3, -4, -5, -6, -7, -8, 1, 2, 3, 4, 5, 6, 7, 8]


@dataclass(slots=True)
class FieldInfo:
    name: str
    field_type: str
    offset: int
    owner: str


@dataclass(slots=True)
class Candidate:
    kind: str
    offset: int
    method_key: str
    class_key: str
    class_name: str
    namespace: str
    method_name: str
    va: int
    instructions: list[str]
    field: FieldInfo | None


class PEImage:
    def __init__(self, path: Path):
        self.path = path
        self.data = path.read_bytes()
        self.pe = pefile.PE(str(path), fast_load=True)
        self.pref_base = self.pe.OPTIONAL_HEADER.ImageBase
        self.runtime_base = 0
        self.exec_sections: list[dict[str, int]] = []
        for sec in self.pe.sections:
            mapped = min(sec.SizeOfRawData, max(0, len(self.data) - sec.PointerToRawData))
            if mapped <= 0:
                continue
            if not (sec.Characteristics & 0x20000000):
                continue
            self.exec_sections.append(
                {
                    "start": sec.VirtualAddress,
                    "end": sec.VirtualAddress + mapped,
                    "raw": sec.PointerToRawData,
                    "mapped": mapped,
                }
            )

    def infer_runtime_base(self, dump: dict) -> int:
        vas = []
        for _, cls in flatten_classes(dump):
            for value in (cls.get("method_pointers") or {}).values():
                va = parse_va(value)
                if va:
                    vas.append(va)
        if not vas:
            self.runtime_base = self.pref_base
            return self.runtime_base

        lo = ((max(vas) - max(sec["end"] for sec in self.exec_sections)) // 0x10000) * 0x10000
        hi = ((min(vas) - min(sec["start"] for sec in self.exec_sections)) // 0x10000) * 0x10000
        best_base = self.pref_base
        best_hits = -1
        for base in range(lo, hi + 1, 0x10000):
            hits = 0
            for va in vas:
                rva = va - base
                if any(sec["start"] <= rva < sec["end"] for sec in self.exec_sections):
                    hits += 1
            if hits > best_hits:
                best_base = base
                best_hits = hits
        self.runtime_base = best_base
        return best_base

    def read_va(self, va: int, size: int) -> bytes:
        rva = va - self.runtime_base
        for sec in self.exec_sections:
            if sec["start"] <= rva < sec["end"]:
                offset = sec["raw"] + (rva - sec["start"])
                end = min(len(self.data), sec["raw"] + sec["mapped"], offset + size)
                if end > offset:
                    return self.data[offset:end]
                return b""
        return b""


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dll", default=str(ROOT / "ida_new" / "GameAssembly.dll"))
    parser.add_argument("--precise", default=str(ROOT / "data" / "precise_dump.json"))
    parser.add_argument("--deobf", default=str(ROOT / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--field-types", default=str(ROOT / "output" / "field_types.json"))
    parser.add_argument("--output", default=str(ROOT / "output" / "property_pairs.json"))
    parser.add_argument("--scan-bytes", type=int, default=96)
    parser.add_argument("--max-insns", type=int, default=8)
    return parser.parse_args()


def load_json(path: str | Path):
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def save_json(path: str | Path, data) -> None:
    path = Path(path)
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("w", encoding="utf-8") as handle:
        json.dump(data, handle, indent=2, ensure_ascii=False)


def flatten_classes(dump: dict):
    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            yield namespace, cls


def pair_classes(raw_dump: dict, deobf_dump: dict):
    raw_items = list(flatten_classes(raw_dump))
    deobf_items = list(flatten_classes(deobf_dump))
    if len(raw_items) != len(deobf_items):
        raise ValueError(f"class count mismatch: {len(raw_items)} != {len(deobf_items)}")

    for index, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(zip(raw_items, deobf_items)):
        if raw_ns != deobf_ns:
            raise ValueError(f"namespace mismatch at class {index}: {raw_ns!r} != {deobf_ns!r}")
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods):
            raise ValueError(
                f"method count mismatch at class {index}: {len(raw_methods)} != {len(deobf_methods)}"
            )
        yield raw_ns, raw_cls, deobf_cls


def parse_va(value) -> int | None:
    if not value:
        return None
    try:
        return int(str(value), 16)
    except ValueError:
        return None


def is_strong_class(name: str) -> bool:
    return (
        bool(name)
        and not STRONG_CLASS_SUFFIX_RE.search(name)
        and "<" not in name
        and ">" not in name
        and not name.startswith("$")
        and not name.startswith("__StaticArrayInitTypeSize")
    )


def normalize_reg_name(reg_name: str) -> str:
    reg_name = reg_name.lower()
    if reg_name.startswith("xmm"):
        return reg_name
    families = {
        "rax": {"rax", "eax", "ax", "al", "ah"},
        "rbx": {"rbx", "ebx", "bx", "bl", "bh"},
        "rcx": {"rcx", "ecx", "cx", "cl", "ch"},
        "rdx": {"rdx", "edx", "dx", "dl", "dh"},
        "r8": {"r8", "r8d", "r8w", "r8b"},
        "r9": {"r9", "r9d", "r9w", "r9b"},
        "r10": {"r10", "r10d", "r10w", "r10b"},
        "r11": {"r11", "r11d", "r11w", "r11b"},
        "r12": {"r12", "r12d", "r12w", "r12b"},
        "r13": {"r13", "r13d", "r13w", "r13b"},
        "r14": {"r14", "r14d", "r14w", "r14b"},
        "r15": {"r15", "r15d", "r15w", "r15b"},
        "rsi": {"rsi", "esi", "si", "sil"},
        "rdi": {"rdi", "edi", "di", "dil"},
        "rbp": {"rbp", "ebp", "bp", "bpl"},
        "rsp": {"rsp", "esp", "sp", "spl"},
    }
    for base, aliases in families.items():
        if reg_name in aliases:
            return base
    return reg_name


def load_field_types(path: str | Path):
    data = load_json(path)
    by_va: dict[str, dict[int, FieldInfo]] = {}
    for full_name, cls in (data.get("classes") or {}).items():
        va = cls.get("va")
        if not va:
            continue
        field_map: dict[int, FieldInfo] = {}
        for field in cls.get("fields") or []:
            try:
                offset = int(field.get("offset"))
            except (TypeError, ValueError):
                continue
            field_map[offset] = FieldInfo(
                name=str(field.get("name") or ""),
                field_type=str(field.get("type") or ""),
                offset=offset,
                owner=full_name,
            )
        by_va[str(va)] = field_map
    return by_va


def build_class_lookup(deobf_dump: dict, fields_by_va: dict[str, dict[int, FieldInfo]]):
    by_key: dict[tuple[str, str], dict] = {}
    by_name: defaultdict[str, list[dict]] = defaultdict(list)
    for namespace, cls in flatten_classes(deobf_dump):
        entry = {
            "namespace": namespace,
            "name": cls.get("name", ""),
            "parent": cls.get("parent", ""),
            "va": str(cls.get("va") or ""),
            "fields": fields_by_va.get(str(cls.get("va") or ""), {}),
        }
        by_key[(namespace, entry["name"])] = entry
        by_name[entry["name"]].append(entry)
    return by_key, by_name


def resolve_parent(class_entry: dict, by_key: dict, by_name: dict[str, list[dict]]) -> dict | None:
    parent_name = class_entry.get("parent") or ""
    if not parent_name:
        return None
    same_ns = by_key.get((class_entry["namespace"], parent_name))
    if same_ns:
        return same_ns
    matches = by_name.get(parent_name, [])
    if len(matches) == 1:
        return matches[0]
    return None


def resolve_field(class_entry: dict, offset: int, by_key: dict, by_name: dict[str, list[dict]]) -> FieldInfo | None:
    current = class_entry
    seen: set[tuple[str, str]] = set()
    while current:
        key = (current["namespace"], current["name"])
        if key in seen:
            break
        seen.add(key)
        field = (current.get("fields") or {}).get(offset)
        if field:
            return field
        current = resolve_parent(current, by_key, by_name)
    return None


def split_words(text: str) -> list[str]:
    return re.findall(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+", text)


def pascalize(text: str) -> str:
    parts = split_words(text)
    return "".join(part[0].upper() + part[1:] if part else "" for part in parts)


def clean_field_name(name: str, field_type: str, offset: int) -> str:
    match = BACKING_FIELD_RE.fullmatch(name)
    if match:
        name = match.group(1)

    name = re.sub(r"^(?:m_|_+)", "", name)
    name = re.sub(r"^k_", "", name)
    name = name.strip("_")

    if not name or GENERIC_FIELD_RE.fullmatch(name):
        stem = f"Field_{offset:X}"
    else:
        stem = pascalize(name) or f"Field_{offset:X}"

    if field_type.lower() == "bool" and not stem.startswith(BOOL_PREFIXES):
        stem = f"Is{stem}"
    return stem


def disassemble_method(pe: PEImage, dis: Cs, va: int, scan_bytes: int, max_insns: int):
    code = pe.read_va(va, scan_bytes)
    if not code:
        return []
    instructions = []
    for insn in dis.disasm(code, va, count=max_insns):
        instructions.append(insn)
        if insn.mnemonic in TERM_MNEMONICS:
            break
        if insn.group(X86_GRP_JUMP):
            break
    return instructions


def is_stack_adjust(insn) -> bool:
    if insn.mnemonic not in ARITH_MNEMONICS:
        return False
    ops = getattr(insn, "operands", [])
    return (
        len(ops) == 2
        and ops[0].type == X86_OP_REG
        and insn.reg_name(ops[0].reg).lower() in {"rsp", "esp"}
    )


def meaningful_instructions(insns):
    out = []
    for insn in insns:
        if insn.mnemonic in SKIP_MNEMONICS:
            continue
        if insn.mnemonic in STACK_MNEMONICS or is_stack_adjust(insn):
            continue
        out.append(insn)
    return out


def try_match_getter(insns):
    if not insns or insns[-1].mnemonic not in TERM_MNEMONICS:
        return None
    core = meaningful_instructions(insns[:-1])
    if len(core) != 1:
        return None
    insn = core[0]
    if not insn.mnemonic.startswith("mov") and insn.mnemonic != "lea":
        return None
    ops = getattr(insn, "operands", [])
    if len(ops) != 2 or ops[0].type != X86_OP_REG or ops[1].type != X86_OP_MEM:
        return None
    dest = normalize_reg_name(insn.reg_name(ops[0].reg))
    src = ops[1].mem
    if dest not in RETURN_REG_FAMILIES:
        return None
    if src.base == 0 or normalize_reg_name(insn.reg_name(src.base)) != "rcx":
        return None
    if src.index != 0:
        return None
    return int(src.disp)


def try_match_setter(insns):
    if not insns or insns[-1].mnemonic not in TERM_MNEMONICS:
        return None
    core = meaningful_instructions(insns[:-1])
    if len(core) != 1:
        return None
    insn = core[0]
    if not insn.mnemonic.startswith("mov"):
        return None
    ops = getattr(insn, "operands", [])
    if len(ops) != 2 or ops[0].type != X86_OP_MEM or ops[1].type != X86_OP_REG:
        return None
    dest = ops[0].mem
    src = normalize_reg_name(insn.reg_name(ops[1].reg))
    if src not in ARG1_REG_FAMILIES:
        return None
    if dest.base == 0 or normalize_reg_name(insn.reg_name(dest.base)) != "rcx":
        return None
    if dest.index != 0:
        return None
    return int(dest.disp)


def infer_candidate(insns):
    offset = try_match_getter(insns)
    if offset is not None:
        return "get", offset
    offset = try_match_setter(insns)
    if offset is not None:
        return "set", offset
    return None, None


def find_candidate_around_pointer(pe: PEImage, dis: Cs, va: int, scan_bytes: int, max_insns: int):
    best = None
    for shift in START_SHIFTS:
        start_va = va + shift
        insns = disassemble_method(pe, dis, start_va, scan_bytes, max_insns)
        if not insns:
            continue
        kind, offset = infer_candidate(insns)
        if kind is None:
            continue
        end_va = insns[-1].address + insns[-1].size
        if not (start_va <= va <= end_va):
            continue
        score = (abs(shift), 0 if shift <= 0 else 1, len(insns))
        if best is None or score < best[0]:
            best = (score, kind, offset, insns)
    if best is None:
        return None, None, []
    _, kind, offset, insns = best
    return kind, offset, insns


def method_va(raw_cls: dict, deobf_cls: dict, index: int) -> int | None:
    raw_method = (raw_cls.get("methods") or [])[index]
    deobf_method = (deobf_cls.get("methods") or [])[index]
    for mapping, key in (
        (deobf_cls.get("method_pointers") or {}, deobf_method),
        (raw_cls.get("method_pointers") or {}, raw_method),
        (deobf_cls.get("method_pointers") or {}, raw_method),
        (raw_cls.get("method_pointers") or {}, deobf_method),
    ):
        va = parse_va(mapping.get(key))
        if va:
            return va
    return None


def main() -> int:
    args = parse_args()
    raw_dump = load_json(args.precise)
    deobf_dump = load_json(args.deobf)
    fields_by_va = load_field_types(args.field_types)
    class_by_key, classes_by_name = build_class_lookup(deobf_dump, fields_by_va)

    pe = PEImage(Path(args.dll))
    pe.infer_runtime_base(raw_dump)

    dis = Cs(CS_ARCH_X86, CS_MODE_64)
    dis.detail = True

    getters_by_class_offset: defaultdict[tuple[str, str], list[Candidate]] = defaultdict(list)
    setters_by_class_offset: defaultdict[tuple[str, str], list[Candidate]] = defaultdict(list)
    strong_hash_methods = 0

    for namespace, raw_cls, deobf_cls in pair_classes(raw_dump, deobf_dump):
        class_name = str(deobf_cls.get("name") or "")
        if not is_strong_class(class_name):
            continue

        class_entry = class_by_key.get((namespace, class_name))
        if not class_entry:
            continue

        methods = deobf_cls.get("methods") or []
        for index, method_name in enumerate(methods):
            if not HASH_METHOD_RE.fullmatch(str(method_name or "")):
                continue
            strong_hash_methods += 1
            va = method_va(raw_cls, deobf_cls, index)
            if not va:
                continue

            kind, offset, insns = find_candidate_around_pointer(pe, dis, va, args.scan_bytes, args.max_insns)
            if kind is None:
                continue

            field = resolve_field(class_entry, offset, class_by_key, classes_by_name)
            candidate = Candidate(
                kind=kind,
                offset=offset,
                method_key=f"{class_name}::{method_name}",
                class_key=f"{namespace}::{class_name}",
                class_name=class_name,
                namespace=namespace,
                method_name=method_name,
                va=va,
                instructions=[f"{insn.mnemonic} {insn.op_str}".rstrip() for insn in insns],
                field=field,
            )
            bucket_key = (candidate.class_key, str(offset))
            if kind == "get":
                getters_by_class_offset[bucket_key].append(candidate)
            else:
                setters_by_class_offset[bucket_key].append(candidate)

    output_map: dict[str, str] = {}
    sample_pairs: list[dict[str, str]] = []
    matched_getters = 0
    matched_setters = 0

    all_keys = sorted(set(getters_by_class_offset) | set(setters_by_class_offset))
    for bucket_key in all_keys:
        getters = getters_by_class_offset.get(bucket_key, [])
        setters = setters_by_class_offset.get(bucket_key, [])
        if len(getters) != 1 or len(setters) != 1:
            continue

        getter = getters[0]
        setter = setters[0]
        field = getter.field or setter.field
        property_name = clean_field_name(field.name if field else "", field.field_type if field else "", getter.offset)

        get_name = f"get_{property_name}"
        set_name = f"set_{property_name}"
        output_map[getter.method_key] = get_name
        output_map[setter.method_key] = set_name
        matched_getters += 1
        matched_setters += 1

        if len(sample_pairs) < 20:
            sample_pairs.append(
                {
                    "class": getter.class_name,
                    "offset": f"0x{getter.offset:X}",
                    "field": field.name if field else f"Field_{getter.offset:X}",
                    "getter": f"{getter.method_key} -> {get_name}",
                    "setter": f"{setter.method_key} -> {set_name}",
                }
            )

    save_json(args.output, dict(sorted(output_map.items())))

    total_getters = sum(len(items) for items in getters_by_class_offset.values())
    total_setters = sum(len(items) for items in setters_by_class_offset.values())
    unpaired_getters = total_getters - matched_getters
    unpaired_setters = total_setters - matched_setters

    print(f"Strong-class hash methods scanned: {strong_hash_methods}")
    print(f"Getter candidates: {total_getters}")
    print(f"Setter candidates: {total_setters}")
    print(f"Matched property pairs: {matched_getters}")
    print(f"Unpaired getters: {unpaired_getters}")
    print(f"Unpaired setters: {unpaired_setters}")
    print("Samples:")
    for sample in sample_pairs:
        print(
            f"  {sample['class']} {sample['offset']} {sample['field']}: "
            f"{sample['getter']} | {sample['setter']}"
        )

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
