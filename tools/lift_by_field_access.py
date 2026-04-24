#!/usr/bin/env python3
"""Predict semantic names for strong-class hash methods from field-access patterns."""

from __future__ import annotations

import argparse
import hashlib
import json
import re
import sys
from collections import Counter, defaultdict
from dataclasses import dataclass
from pathlib import Path

import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import X86_GRP_JUMP, X86_INS_CALL, X86_INS_JMP, X86_OP_IMM, X86_OP_MEM, X86_OP_REG


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


ROOT = Path(__file__).resolve().parent.parent
DEFAULT_DLL = ROOT / "ida_new" / "GameAssembly.dll"
DEFAULT_PRECISE = ROOT / "data" / "precise_dump.json"
DEFAULT_DEOBF = ROOT / "output" / "deobfuscated_dump.json"
DEFAULT_FIELD_TYPES = ROOT / "output" / "field_types.json"
DEFAULT_OUTPUT = ROOT / "output" / "field_based_names.json"

HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$", re.I)
HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$", re.I)
WEAK_CLASS_RE = re.compile(
    r"^(BaseClass|Type|Static|Major|Service|Struct|Mono|DataOnly|Unknown|Record|NestedType|"
    r"EmptyType|EmptyStruct|AsyncStateMachine|Enumerator|Delegate|LifecycleComponent|"
    r"UpdateComponent|ComplexComponent|AnimatedTextureBase|NetworkItem|NetworkSyncable|"
    r"VRCUiManagerSibling|VRC_Main|VRC_Secondary|VRCUi|MajorSystem|TransformGame|UIRect|"
    r"GameObjectHandler|PointerEnter|VRCInit|InitializeVRSDK)\w*_[0-9A-F]+$",
    re.I,
)
OBFUSCATED_TEXT_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
BACKING_FIELD_RE = re.compile(r"^<(.+)>k__BackingField$")
GENERIC_FIELD_RE = re.compile(r"^(?:f|field)_[0-9A-F]{2,}$", re.I)
TERM_MNEMONICS = {"ret", "retf", "int3", "ud2"}
SKIP_MNEMONICS = {"nop"}
STACK_MNEMONICS = {"push", "pop"}
ARITH_MNEMONICS = {"sub", "add"}
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
TRIVIAL_CALLEES = {
    ".ctor",
    ".cctor",
    "Equals",
    "Finalize",
    "GetHashCode",
    "GetType",
    "MemberwiseClone",
    "ToString",
    "Dispose",
}
START_SHIFTS = [0, -1, -2, -3, -4, -5, -6, -7, -8, 1, 2, 3, 4, 5, 6, 7, 8]
RETURN_REG_FAMILIES = {"rax", "xmm0"}
ARG1_REG_FAMILIES = {"rdx", "xmm1"}


@dataclass(slots=True)
class FieldInfo:
    name: str
    field_type: str
    offset: int
    owner: str


@dataclass(slots=True)
class MethodRecord:
    namespace: str
    class_name: str
    raw_method_name: str
    hash_name: str
    va: int


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dll", default=str(DEFAULT_DLL))
    parser.add_argument("--precise", default=str(DEFAULT_PRECISE))
    parser.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    parser.add_argument("--field-types", default=str(DEFAULT_FIELD_TYPES))
    parser.add_argument("--output", default=str(DEFAULT_OUTPUT))
    parser.add_argument("--scan-bytes", type=int, default=32)
    parser.add_argument("--sample-count", type=int, default=20)
    return parser.parse_args()


def load_json(path: str | Path):
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def save_json(path: str | Path, data) -> None:
    out = Path(path)
    out.parent.mkdir(parents=True, exist_ok=True)
    with out.open("w", encoding="utf-8") as handle:
        json.dump(data, handle, indent=2, ensure_ascii=False, sort_keys=True)


def stable_hash(name: str, length: int = 3) -> str:
    return hashlib.sha256(name.encode("utf-8")).hexdigest()[:length].upper()


def parse_va(value) -> int | None:
    if not value:
        return None
    try:
        parsed = int(str(value), 16)
    except ValueError:
        return None
    return parsed if parsed else None


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
                f"method count mismatch at class {index}: "
                f"{raw_cls.get('name')!r} ({len(raw_methods)}) != {deobf_cls.get('name')!r} ({len(deobf_methods)})"
            )
        yield raw_ns, raw_cls, deobf_cls


def is_compiler_generated(name: str) -> bool:
    return "<" in name or ">" in name or name.startswith("$") or name.startswith("__StaticArrayInitTypeSize")


def is_strong_class(name: str) -> bool:
    return (
        bool(name)
        and not WEAK_CLASS_RE.fullmatch(name)
        and not HEX_SUFFIX_RE.search(name)
        and not is_compiler_generated(name)
        and not OBFUSCATED_TEXT_RE.search(name)
    )


def method_va(raw_cls: dict, deobf_cls: dict, method_index: int) -> int | None:
    raw_name = (raw_cls.get("methods") or [])[method_index]
    deobf_name = (deobf_cls.get("methods") or [])[method_index]
    for mapping, key in (
        (deobf_cls.get("method_pointers") or {}, deobf_name),
        (raw_cls.get("method_pointers") or {}, raw_name),
        (deobf_cls.get("method_pointers") or {}, raw_name),
        (raw_cls.get("method_pointers") or {}, deobf_name),
    ):
        va = parse_va(mapping.get(key))
        if va:
            return va
    return None


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


def build_field_map_from_precise(precise_dump: dict) -> dict[tuple[str, str], dict[int, FieldInfo]]:
    fields_by_key: dict[tuple[str, str], dict[int, FieldInfo]] = {}
    for namespace, cls in flatten_classes(precise_dump):
        fields = cls.get("fields") or []
        offsets = cls.get("field_offsets") or []
        if not fields or not offsets or len(fields) != len(offsets):
            continue
        field_map: dict[int, FieldInfo] = {}
        for field_name, offset in zip(fields, offsets):
            try:
                parsed_offset = int(offset)
            except (TypeError, ValueError):
                continue
            field_map[parsed_offset] = FieldInfo(
                name=str(field_name or ""),
                field_type="",
                offset=parsed_offset,
                owner=f"{namespace}.{cls.get('name')}" if namespace else str(cls.get("name") or ""),
            )
        if field_map:
            fields_by_key[(namespace, str(cls.get("name") or ""))] = field_map
    return fields_by_key


def build_field_map_from_field_types(field_types_path: str | Path) -> dict[tuple[str, str], dict[int, FieldInfo]]:
    data = load_json(field_types_path)
    result: dict[tuple[str, str], dict[int, FieldInfo]] = {}
    for full_name, cls in (data.get("classes") or {}).items():
        namespace = str(cls.get("namespace") or "")
        name = str(cls.get("name") or "")
        if not name:
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
                owner=str(full_name),
            )
        if field_map:
            key = (namespace, name)
            previous = result.get(key)
            if previous is None or len(field_map) > len(previous):
                result[key] = field_map
    return result


def build_class_lookup(
    deobf_dump: dict,
    fields_by_key: dict[tuple[str, str], dict[int, FieldInfo]],
):
    by_key: dict[tuple[str, str], dict] = {}
    by_name: defaultdict[str, list[dict]] = defaultdict(list)
    for namespace, cls in flatten_classes(deobf_dump):
        entry = {
            "namespace": namespace,
            "name": str(cls.get("name") or ""),
            "parent": str(cls.get("parent") or ""),
            "fields": fields_by_key.get((namespace, str(cls.get("name") or "")), {}),
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
    return "".join(part[0].upper() + part[1:] if part else "" for part in split_words(text))


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


def disassemble_window(pe: PEImage, dis: Cs, start_va: int, scan_bytes: int):
    code = pe.read_va(start_va, scan_bytes)
    if not code:
        return []
    insns = []
    for insn in dis.disasm(code, start_va):
        insns.append(insn)
        if insn.mnemonic in TERM_MNEMONICS:
            break
        if insn.group(X86_GRP_JUMP):
            break
        consumed = (insn.address + insn.size) - start_va
        if consumed >= scan_bytes:
            break
    return insns


def op_mem_disp_from_this(insn, operand) -> int | None:
    if operand.type != X86_OP_MEM:
        return None
    mem = operand.mem
    if mem.base == 0 or normalize_reg_name(insn.reg_name(mem.base)) != "rcx":
        return None
    if mem.index != 0:
        return None
    return int(mem.disp)


def try_match_getter(insns):
    if not insns or insns[-1].mnemonic not in TERM_MNEMONICS:
        return None
    core = meaningful_instructions(insns[:-1])
    if len(core) != 1:
        return None
    insn = core[0]
    if insn.mnemonic not in {"mov", "movzx", "movsx", "movsxd", "lea", "movss", "movsd"}:
        return None
    ops = getattr(insn, "operands", [])
    if len(ops) != 2 or ops[0].type != X86_OP_REG:
        return None
    offset = op_mem_disp_from_this(insn, ops[1])
    if offset is None:
        return None
    dest = normalize_reg_name(insn.reg_name(ops[0].reg))
    if dest not in RETURN_REG_FAMILIES:
        return None
    pattern = "bool_getter" if insn.mnemonic == "movzx" else "getter"
    return pattern, offset


def try_match_setter(insns):
    if not insns or insns[-1].mnemonic not in TERM_MNEMONICS:
        return None
    core = meaningful_instructions(insns[:-1])
    if len(core) != 1:
        return None
    insn = core[0]
    if insn.mnemonic not in {"mov", "movss", "movsd"}:
        return None
    ops = getattr(insn, "operands", [])
    if len(ops) != 2 or ops[1].type != X86_OP_REG:
        return None
    offset = op_mem_disp_from_this(insn, ops[0])
    if offset is None:
        return None
    src = normalize_reg_name(insn.reg_name(ops[1].reg))
    if src not in ARG1_REG_FAMILIES:
        return None
    return "setter", offset


def try_match_increment(insns):
    if not insns or insns[-1].mnemonic not in TERM_MNEMONICS:
        return None
    core = meaningful_instructions(insns[:-1])
    if len(core) != 1:
        return None
    insn = core[0]
    ops = getattr(insn, "operands", [])
    if insn.mnemonic in {"inc", "dec"} and len(ops) == 1:
        offset = op_mem_disp_from_this(insn, ops[0])
        if offset is not None:
            pattern = "increment" if insn.mnemonic == "inc" else "decrement"
            return pattern, offset
    if insn.mnemonic in {"add", "sub"} and len(ops) == 2:
        offset = op_mem_disp_from_this(insn, ops[0])
        if offset is None or ops[1].type != X86_OP_IMM or int(ops[1].imm) != 1:
            return None
        pattern = "increment" if insn.mnemonic == "add" else "decrement"
        return pattern, offset
    return None


def normalize_callee_name(name: str) -> str | None:
    if not name or name in TRIVIAL_CALLEES or HASH_METHOD_RE.fullmatch(name):
        return None
    if is_compiler_generated(name) or OBFUSCATED_TEXT_RE.search(name):
        return None
    if name.startswith(("get_", "set_")):
        head, tail = name.split("_", 1)
        tail = pascalize(tail)
        return f"{head}_{tail}" if tail else None
    return re.sub(r"[^A-Za-z0-9_]+", "", name)


def try_match_field_call(insns, va_to_method_name: dict[int, str]):
    if not insns:
        return None
    core = meaningful_instructions(insns)
    if len(core) < 2 or len(core) > 4:
        return None

    direct_call = None
    for index, insn in enumerate(core):
        if insn.id in {X86_INS_CALL, X86_INS_JMP}:
            ops = getattr(insn, "operands", [])
            if len(ops) == 1 and ops[0].type == X86_OP_IMM:
                direct_call = (index, int(ops[0].imm))
                break
    if direct_call is None:
        return None

    call_index, target = direct_call
    callee = normalize_callee_name(va_to_method_name.get(target, ""))
    if not callee:
        return None

    loads: list[int] = []
    for insn in core[:call_index]:
        ops = getattr(insn, "operands", [])
        if len(ops) < 2:
            continue
        if ops[0].type != X86_OP_REG:
            continue
        offset = op_mem_disp_from_this(insn, ops[1])
        if offset is not None and insn.mnemonic in {"mov", "movzx", "movsx", "movsxd", "lea", "movss", "movsd"}:
            loads.append(offset)
    unique_loads = sorted(set(loads))
    if len(unique_loads) != 1:
        return None
    return "field_call", unique_loads[0], callee


def infer_pattern(insns, va_to_method_name: dict[int, str]):
    match = try_match_getter(insns)
    if match is not None:
        pattern, offset = match
        return pattern, offset, None
    match = try_match_setter(insns)
    if match is not None:
        pattern, offset = match
        return pattern, offset, None
    match = try_match_increment(insns)
    if match is not None:
        pattern, offset = match
        return pattern, offset, None
    match = try_match_field_call(insns, va_to_method_name)
    if match is not None:
        pattern, offset, callee = match
        return pattern, offset, callee
    return None, None, None


def choose_candidate(pe: PEImage, dis: Cs, va: int, scan_bytes: int, va_to_method_name: dict[int, str]):
    best = None
    fallback_insns = disassemble_window(pe, dis, va, scan_bytes)
    for shift in START_SHIFTS:
        start_va = va + shift
        insns = disassemble_window(pe, dis, start_va, scan_bytes)
        if not insns:
            continue
        pattern, offset, callee = infer_pattern(insns, va_to_method_name)
        if pattern is None:
            continue
        end_va = insns[-1].address + insns[-1].size
        if not (start_va <= va <= end_va):
            continue
        score = (abs(shift), 0 if shift <= 0 else 1, len(insns))
        preview = [f"0x{insn.address:X}: {insn.mnemonic} {insn.op_str}".rstrip() for insn in insns]
        if best is None or score < best[0]:
            best = (score, pattern, offset, callee, preview)
    if best is not None:
        _, pattern, offset, callee, preview = best
        return pattern, offset, callee, preview
    fallback_preview = [f"0x{insn.address:X}: {insn.mnemonic} {insn.op_str}".rstrip() for insn in fallback_insns]
    return None, None, None, fallback_preview


def clean_field_name(field: FieldInfo | None) -> tuple[str | None, bool]:
    if field is None:
        return None, False
    name = field.name
    match = BACKING_FIELD_RE.fullmatch(name)
    if match:
        name = match.group(1)
    name = re.sub(r"^(?:m_|_+)", "", name)
    name = re.sub(r"^k_", "", name)
    name = name.strip("_")
    if not name or OBFUSCATED_TEXT_RE.search(name):
        return None, False
    if GENERIC_FIELD_RE.fullmatch(name):
        return None, False
    stem = pascalize(name)
    if not stem:
        return None, False
    if field.field_type.lower() == "bool" and not stem.startswith(BOOL_PREFIXES):
        stem = f"Is{stem}"
    return stem, True


def compose_prediction(pattern: str, field_stem: str, callee: str | None) -> str | None:
    if pattern in {"getter", "bool_getter"}:
        return f"get_{field_stem}"
    if pattern == "setter":
        return f"set_{field_stem}"
    if pattern == "increment":
        return f"Increment_{field_stem}"
    if pattern == "decrement":
        return f"Decrement_{field_stem}"
    if pattern == "field_call" and callee:
        if callee.startswith("get_"):
            suffix = pascalize(callee.split("_", 1)[1])
            return f"get_{field_stem}{suffix}" if suffix else None
        if callee.startswith("set_"):
            suffix = pascalize(callee.split("_", 1)[1])
            return f"set_{field_stem}{suffix}" if suffix else None
        return f"{callee}_{field_stem}"
    return None


def main() -> int:
    args = parse_args()
    precise_dump = load_json(args.precise)
    deobf_dump = load_json(args.deobf)

    fields_by_key = build_field_map_from_precise(precise_dump)
    field_source = "precise_dump"
    if not fields_by_key:
        fields_by_key = build_field_map_from_field_types(args.field_types)
        field_source = "field_types"

    class_by_key, classes_by_name = build_class_lookup(deobf_dump, fields_by_key)

    pe = PEImage(Path(args.dll))
    runtime_base = pe.infer_runtime_base(precise_dump)

    dis = Cs(CS_ARCH_X86, CS_MODE_64)
    dis.detail = True

    strong_methods: list[MethodRecord] = []
    va_to_method_name: dict[int, str] = {}
    total_hash_methods = 0
    strong_classes = set()

    for namespace, raw_cls, deobf_cls in pair_classes(precise_dump, deobf_dump):
        class_name = str(deobf_cls.get("name") or "")
        methods = deobf_cls.get("methods") or []
        total_hash_methods += sum(1 for method_name in methods if HASH_METHOD_RE.fullmatch(str(method_name or "")))

        if not is_strong_class(class_name):
            continue

        strong_classes.add((namespace, class_name))

        for index, method_name in enumerate(methods):
            method_name = str(method_name or "")
            va = method_va(raw_cls, deobf_cls, index)
            if va and not HASH_METHOD_RE.fullmatch(method_name) and method_name not in TRIVIAL_CALLEES:
                va_to_method_name[va] = method_name
            if not HASH_METHOD_RE.fullmatch(method_name):
                continue
            raw_method_name = str((raw_cls.get("methods") or [])[index] or "")
            hash_name = f"m_{stable_hash(raw_method_name, 3)}"
            if hash_name != method_name or not va:
                continue
            strong_methods.append(
                MethodRecord(
                    namespace=namespace,
                    class_name=class_name,
                    raw_method_name=raw_method_name,
                    hash_name=hash_name,
                    va=va,
                )
            )

    predictions: dict[str, str] = {}
    pattern_breakdown: Counter[str] = Counter()
    samples: list[dict[str, str]] = []
    matched_fields = 0
    classes_missing_field_map = 0
    seen_missing_class: set[tuple[str, str]] = set()
    raw_pattern_hits = 0

    for record in strong_methods:
        class_entry = class_by_key.get((record.namespace, record.class_name))
        if not class_entry:
            continue
        if not class_entry.get("fields") and (record.namespace, record.class_name) not in seen_missing_class:
            seen_missing_class.add((record.namespace, record.class_name))
            classes_missing_field_map += 1

        pattern, offset, callee, preview = choose_candidate(pe, dis, record.va, args.scan_bytes, va_to_method_name)
        if pattern is None or offset is None:
            continue
        raw_pattern_hits += 1

        field = resolve_field(class_entry, offset, class_by_key, classes_by_name)
        field_stem, usable_field = clean_field_name(field)
        if not usable_field or not field_stem:
            continue

        predicted_name = compose_prediction(pattern, field_stem, callee)
        if not predicted_name:
            continue

        key = f"{record.class_name}::{record.hash_name}"
        predictions[key] = predicted_name
        pattern_breakdown[pattern] += 1
        matched_fields += 1

        if len(samples) < args.sample_count:
            samples.append(
                {
                    "key": key,
                    "predicted_name": predicted_name,
                    "pattern": pattern,
                    "field": field.name if field else "",
                    "offset": f"0x{offset:X}",
                    "callee": callee or "",
                    "va": f"0x{record.va:X}",
                    "preview": " | ".join(preview[:6]),
                }
            )

    save_json(args.output, predictions)

    strong_classes_with_hashes = {(record.namespace, record.class_name) for record in strong_methods}
    classes_with_field_maps = sum(
        1
        for class_key in strong_classes_with_hashes
        if (class_by_key.get(class_key) or {}).get("fields")
    )

    print("Report")
    print(f"  GameAssembly.dll: {args.dll}")
    print(f"  Runtime image base: 0x{runtime_base:X}")
    print(f"  Field source: {field_source}")
    print(f"  Strong classes scanned: {len(strong_classes):,}")
    print(f"  Strong classes with hash methods: {len(strong_classes_with_hashes):,}")
    print(f"  Strong hash methods scanned: {len(strong_methods):,}")
    print(f"  Total hash methods in dump: {total_hash_methods:,}")
    print(f"  Strong classes with field maps: {classes_with_field_maps:,}")
    print(f"  Strong classes missing field maps: {classes_missing_field_map:,}")
    print(f"  Raw field-pattern hits: {raw_pattern_hits:,}")
    print(f"  Predictions written: {len(predictions):,}")
    print("  Pattern breakdown:")
    for pattern, count in sorted(pattern_breakdown.items()):
        print(f"    {pattern}: {count}")
    print("  Samples:")
    for sample in samples:
        callee_part = f" callee={sample['callee']}" if sample["callee"] else ""
        print(
            f"    {sample['key']} -> {sample['predicted_name']} "
            f"[{sample['pattern']} field={sample['field']} offset={sample['offset']}{callee_part}]"
        )
        print(f"      {sample['preview']}")
    print(f"Wrote {args.output}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
