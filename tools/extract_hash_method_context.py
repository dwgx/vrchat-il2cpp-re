#!/usr/bin/env python3
"""Extract native context for hash-named IL2CPP methods from GameAssembly.dll."""
from __future__ import annotations

import argparse
import bisect
import json
import re
import struct
import sys
from collections import Counter, defaultdict
from dataclasses import dataclass
from pathlib import Path
from typing import Iterable

import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import (
    X86_GRP_JUMP,
    X86_INS_ADD,
    X86_INS_CALL,
    X86_INS_JMP,
    X86_INS_LEA,
    X86_INS_MOV,
    X86_INS_POP,
    X86_INS_PUSH,
    X86_INS_SUB,
    X86_INS_XOR,
    X86_OP_IMM,
    X86_OP_MEM,
    X86_OP_REG,
    X86_REG_AH,
    X86_REG_AL,
    X86_REG_AX,
    X86_REG_BH,
    X86_REG_BL,
    X86_REG_BP,
    X86_REG_BPL,
    X86_REG_BX,
    X86_REG_CH,
    X86_REG_CL,
    X86_REG_CX,
    X86_REG_DH,
    X86_REG_DI,
    X86_REG_DIL,
    X86_REG_DL,
    X86_REG_DX,
    X86_REG_EAX,
    X86_REG_EBP,
    X86_REG_EBX,
    X86_REG_ECX,
    X86_REG_EDI,
    X86_REG_EDX,
    X86_REG_EIP,
    X86_REG_ESI,
    X86_REG_ESP,
    X86_REG_IP,
    X86_REG_R8,
    X86_REG_R8B,
    X86_REG_R8D,
    X86_REG_R8W,
    X86_REG_R9,
    X86_REG_R9B,
    X86_REG_R9D,
    X86_REG_R9W,
    X86_REG_R10,
    X86_REG_R10B,
    X86_REG_R10D,
    X86_REG_R10W,
    X86_REG_R11,
    X86_REG_R11B,
    X86_REG_R11D,
    X86_REG_R11W,
    X86_REG_R12,
    X86_REG_R12B,
    X86_REG_R12D,
    X86_REG_R12W,
    X86_REG_R13,
    X86_REG_R13B,
    X86_REG_R13D,
    X86_REG_R13W,
    X86_REG_R14,
    X86_REG_R14B,
    X86_REG_R14D,
    X86_REG_R14W,
    X86_REG_R15,
    X86_REG_R15B,
    X86_REG_R15D,
    X86_REG_R15W,
    X86_REG_RAX,
    X86_REG_RBP,
    X86_REG_RBX,
    X86_REG_RCX,
    X86_REG_RDI,
    X86_REG_RDX,
    X86_REG_RIP,
    X86_REG_RSI,
    X86_REG_RSP,
    X86_REG_SI,
    X86_REG_SIL,
    X86_REG_SP,
    X86_REG_SPL,
)

sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")

HASH_RE = re.compile(r"^m_[0-9A-Fa-f]{3}$")
OBF_METHOD_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]{3,}$")
CLASS_START_RE = re.compile(r"^\s*(?:public\s+)?class\s+([^\s:{]+)(?:\s*:\s*([^{]+))?\s*$")
METHOD_LINE_RE = re.compile(
    r"^\s*(?P<ret>.+?)\s+(?P<name>[^\s(]+)\((?P<params>.*)\)\s*;\s*(?://\s*(?P<va>0x[0-9A-Fa-f]+))?\s*$"
)
PRINTABLE_MIN_LEN = 4
DEFAULT_SCAN_BYTES = 1536
DEFAULT_MAX_INSNS = 400
DEFAULT_TARGET_SLOP = 24

ARG_REGS = ("rcx", "rdx", "r8", "r9")
PREVIEW_TERM_MNEMONICS = {"ret", "retf", "int3", "ud2"}
BLOCK_TERM_MNEMONICS = PREVIEW_TERM_MNEMONICS | {"jmp"}

REGISTER_ALIASES = {
    X86_REG_RAX: "rax",
    X86_REG_EAX: "rax",
    X86_REG_AX: "rax",
    X86_REG_AH: "rax",
    X86_REG_AL: "rax",
    X86_REG_RBX: "rbx",
    X86_REG_EBX: "rbx",
    X86_REG_BX: "rbx",
    X86_REG_BH: "rbx",
    X86_REG_BL: "rbx",
    X86_REG_RCX: "rcx",
    X86_REG_ECX: "rcx",
    X86_REG_CX: "rcx",
    X86_REG_CH: "rcx",
    X86_REG_CL: "rcx",
    X86_REG_RDX: "rdx",
    X86_REG_EDX: "rdx",
    X86_REG_DX: "rdx",
    X86_REG_DH: "rdx",
    X86_REG_DL: "rdx",
    X86_REG_RSI: "rsi",
    X86_REG_ESI: "rsi",
    X86_REG_SI: "rsi",
    X86_REG_SIL: "rsi",
    X86_REG_RDI: "rdi",
    X86_REG_EDI: "rdi",
    X86_REG_DI: "rdi",
    X86_REG_DIL: "rdi",
    X86_REG_RBP: "rbp",
    X86_REG_EBP: "rbp",
    X86_REG_BP: "rbp",
    X86_REG_BPL: "rbp",
    X86_REG_RSP: "rsp",
    X86_REG_ESP: "rsp",
    X86_REG_SP: "rsp",
    X86_REG_SPL: "rsp",
    X86_REG_R8: "r8",
    X86_REG_R8D: "r8",
    X86_REG_R8W: "r8",
    X86_REG_R8B: "r8",
    X86_REG_R9: "r9",
    X86_REG_R9D: "r9",
    X86_REG_R9W: "r9",
    X86_REG_R9B: "r9",
    X86_REG_R10: "r10",
    X86_REG_R10D: "r10",
    X86_REG_R10W: "r10",
    X86_REG_R10B: "r10",
    X86_REG_R11: "r11",
    X86_REG_R11D: "r11",
    X86_REG_R11W: "r11",
    X86_REG_R11B: "r11",
    X86_REG_R12: "r12",
    X86_REG_R12D: "r12",
    X86_REG_R12W: "r12",
    X86_REG_R12B: "r12",
    X86_REG_R13: "r13",
    X86_REG_R13D: "r13",
    X86_REG_R13W: "r13",
    X86_REG_R13B: "r13",
    X86_REG_R14: "r14",
    X86_REG_R14D: "r14",
    X86_REG_R14W: "r14",
    X86_REG_R14B: "r14",
    X86_REG_R15: "r15",
    X86_REG_R15D: "r15",
    X86_REG_R15W: "r15",
    X86_REG_R15B: "r15",
    X86_REG_RIP: "rip",
    X86_REG_EIP: "rip",
    X86_REG_IP: "rip",
}

TYPE_ALIASES = {
    "void": "Void",
    "bool": "Boolean",
    "byte": "Byte",
    "sbyte": "SByte",
    "short": "Int16",
    "ushort": "UInt16",
    "int": "Int32",
    "uint": "UInt32",
    "long": "Int64",
    "ulong": "UInt64",
    "float": "Single",
    "double": "Double",
    "char": "Char",
    "string": "String",
    "object": "Object",
}


@dataclass(slots=True)
class MethodSig:
    method_name: str
    ret_type: str
    params: list[str]
    signature: str


@dataclass(slots=True)
class MethodRecord:
    namespace: str
    class_name: str
    raw_class_name: str
    method_name: str
    raw_method_name: str
    key: str
    va: int | None
    method_index: int
    sig: MethodSig


@dataclass(slots=True)
class ValueRef:
    kind: str
    va: int | None = None
    text: str | None = None
    target_va: int | None = None


def parse_args() -> argparse.Namespace:
    base = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dll", default=str(base / "ida_new" / "GameAssembly.dll"))
    parser.add_argument("--precise", default=str(base / "data" / "precise_dump.json"))
    parser.add_argument("--deobf-json", default=str(base / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--deobf-cs", default=str(base / "output" / "deobfuscated_dump.cs"))
    parser.add_argument("--output", default=str(base / "data" / "hash_method_contexts.json"))
    parser.add_argument("--chunk-prefix", default=str(base / "data" / "hash_ctx_chunk_"))
    parser.add_argument("--chunk-size", type=int, default=500)
    parser.add_argument("--scan-bytes", type=int, default=DEFAULT_SCAN_BYTES)
    parser.add_argument("--max-insns", type=int, default=DEFAULT_MAX_INSNS)
    parser.add_argument("--target-slop", type=int, default=DEFAULT_TARGET_SLOP)
    return parser.parse_args()


def load_json(path: str | Path):
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def flatten_classes(dump: dict) -> list[tuple[str, dict]]:
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]


def parse_va(value) -> int | None:
    if not value:
        return None
    try:
        va = int(str(value), 16)
    except ValueError:
        return None
    return va or None


def normalize_type(text: str) -> str:
    text = " ".join(text.strip().split())
    return TYPE_ALIASES.get(text, text)


def split_top_level(text: str, delimiter: str = ",") -> list[str]:
    if not text:
        return []
    out: list[str] = []
    cur: list[str] = []
    depth_angle = 0
    depth_round = 0
    depth_square = 0
    for ch in text:
        if ch == "<":
            depth_angle += 1
        elif ch == ">":
            depth_angle = max(0, depth_angle - 1)
        elif ch == "(":
            depth_round += 1
        elif ch == ")":
            depth_round = max(0, depth_round - 1)
        elif ch == "[":
            depth_square += 1
        elif ch == "]":
            depth_square = max(0, depth_square - 1)
        if ch == delimiter and not depth_angle and not depth_round and not depth_square:
            piece = "".join(cur).strip()
            if piece:
                out.append(piece)
            cur.clear()
            continue
        cur.append(ch)
    tail = "".join(cur).strip()
    if tail:
        out.append(tail)
    return out


def parse_param_types(param_text: str) -> list[str]:
    if not param_text.strip():
        return []
    params: list[str] = []
    for raw_param in split_top_level(param_text):
        text = " ".join(raw_param.split())
        if not text:
            continue
        if text == "...":
            params.append(text)
            continue
        pieces = text.split(" ")
        if len(pieces) > 1:
            if pieces[-1] not in {"ref", "out", "in", "params", "this"}:
                text = " ".join(pieces[:-1])
        params.append(normalize_type(text))
    return params


def default_sig(method_name: str) -> MethodSig:
    ret = "Void"
    params: list[str] = []
    return MethodSig(method_name, ret, params, f"{ret} {method_name}()")


def parse_deobf_cs_signatures(path: str | Path) -> list[tuple[str, list[MethodSig]]]:
    classes: list[tuple[str, list[MethodSig]]] = []
    current_name: str | None = None
    current_methods: list[MethodSig] | None = None
    brace_depth = 0
    with Path(path).open("r", encoding="utf-8", errors="ignore") as handle:
        for line in handle:
            stripped = line.rstrip("\r\n")
            if current_name is None:
                match = CLASS_START_RE.match(stripped)
                if match:
                    current_name = match.group(1)
                    current_methods = []
                    brace_depth = stripped.count("{") - stripped.count("}")
                    continue
                continue
            brace_depth += stripped.count("{")
            method_match = METHOD_LINE_RE.match(stripped)
            if method_match and current_methods is not None:
                ret_type = normalize_type(method_match.group("ret"))
                method_name = method_match.group("name").strip()
                param_types = parse_param_types(method_match.group("params"))
                sig = MethodSig(method_name, ret_type, param_types, f"{ret_type} {method_name}({', '.join(param_types)})")
                current_methods.append(sig)
            brace_depth -= stripped.count("}")
            if brace_depth <= 0:
                classes.append((current_name, current_methods or []))
                current_name = None
                current_methods = None
                brace_depth = 0
    return classes


def build_signature_lookup(cs_sigs: list[tuple[str, list[MethodSig]]]) -> dict[tuple[str, str], list[MethodSig]]:
    lookup: dict[tuple[str, str], list[MethodSig]] = defaultdict(list)
    for class_name, methods in cs_sigs:
        for sig in methods:
            lookup[(class_name, sig.method_name)].append(sig)
    return lookup


def build_method_records(raw_dump: dict, current_dump: dict, cs_sig_lookup: dict[tuple[str, str], list[MethodSig]]) -> list[MethodRecord]:
    raw_classes = flatten_classes(raw_dump)
    current_classes = flatten_classes(current_dump)
    if len(raw_classes) != len(current_classes):
        raise ValueError(f"class count mismatch: {len(raw_classes)} != {len(current_classes)}")

    records: list[MethodRecord] = []
    for idx, ((raw_ns, raw_cls), (cur_ns, cur_cls)) in enumerate(zip(raw_classes, current_classes)):
        if raw_ns != cur_ns:
            raise ValueError(f"namespace mismatch at class {idx}: {raw_ns!r} != {cur_ns!r}")
        cur_methods = cur_cls.get("methods") or []
        raw_methods = raw_cls.get("methods") or []
        if len(cur_methods) != len(raw_methods):
            raise ValueError(f"method count mismatch at class {idx}: {len(raw_methods)} != {len(cur_methods)}")
        cur_ptrs = cur_cls.get("method_pointers") or {}
        raw_ptrs = raw_cls.get("method_pointers") or {}
        for method_index, (raw_method_name, cur_method_name) in enumerate(zip(raw_methods, cur_methods)):
            va = None
            for mapping, name in (
                (cur_ptrs, cur_method_name),
                (raw_ptrs, raw_method_name),
                (cur_ptrs, raw_method_name),
                (raw_ptrs, cur_method_name),
            ):
                va = parse_va(mapping.get(name))
                if va:
                    break
            sigs = cs_sig_lookup.get((cur_cls["name"], cur_method_name)) or []
            sig = sigs.pop(0) if sigs else default_sig(cur_method_name)
            records.append(
                MethodRecord(
                    namespace=cur_ns,
                    class_name=cur_cls["name"],
                    raw_class_name=raw_cls["name"],
                    method_name=cur_method_name,
                    raw_method_name=raw_method_name,
                    key=f"{cur_cls['name']}::{cur_method_name}",
                    va=va,
                    method_index=method_index,
                    sig=sig,
                )
            )
    return records


class PEImage:
    def __init__(self, path: str | Path):
        self.path = Path(path)
        self.data = self.path.read_bytes()
        self.pe = pefile.PE(str(self.path), fast_load=True)
        self.preferred_base = self.pe.OPTIONAL_HEADER.ImageBase
        self.runtime_base = 0
        self.sections: list[dict] = []
        self.exec_sections: list[dict] = []
        self.ro_sections: list[dict] = []
        self.rdata_names = {".rdata", ".data.rel.ro", ".idata"}
        for sec in self.pe.sections:
            mapped = min(sec.SizeOfRawData, max(0, len(self.data) - sec.PointerToRawData))
            if mapped <= 0:
                continue
            name = sec.Name.decode("ascii", errors="ignore").rstrip("\0")
            info = {
                "name": name,
                "start": sec.VirtualAddress,
                "end": sec.VirtualAddress + mapped,
                "raw": sec.PointerToRawData,
                "mapped": mapped,
                "chars": sec.Characteristics,
            }
            self.sections.append(info)
            if sec.Characteristics & 0x20000000:
                self.exec_sections.append(info)
            if name in self.rdata_names or (
                sec.Characteristics & 0x40000000 and not sec.Characteristics & 0x80000000 and not sec.Characteristics & 0x20000000
            ):
                self.ro_sections.append(info)
        if not self.exec_sections:
            raise ValueError("no executable sections found")

    def infer_runtime_base(self, method_vas: Iterable[int]) -> int:
        vas = sorted({va for va in method_vas if va})
        if not vas:
            self.runtime_base = self.preferred_base
            return self.runtime_base
        low = ((max(vas) - max(sec["end"] for sec in self.exec_sections)) // 0x10000) * 0x10000
        high = ((min(vas) - min(sec["start"] for sec in self.exec_sections)) // 0x10000) * 0x10000
        best_base = self.preferred_base
        best_hits = -1
        for base in range(low, high + 1, 0x10000):
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

    def section_for_va(self, va: int) -> dict | None:
        rva = va - self.runtime_base
        for sec in self.sections:
            if sec["start"] <= rva < sec["end"]:
                return sec
        return None

    def is_exec(self, va: int) -> bool:
        sec = self.section_for_va(va)
        return bool(sec and sec in self.exec_sections)

    def is_ro(self, va: int) -> bool:
        sec = self.section_for_va(va)
        return bool(sec and sec in self.ro_sections)

    def read_va(self, va: int, size: int) -> bytes:
        sec = self.section_for_va(va)
        if not sec:
            return b""
        rva = va - self.runtime_base
        offset = sec["raw"] + (rva - sec["start"])
        end = min(len(self.data), sec["raw"] + sec["mapped"], offset + size)
        return self.data[offset:end] if end > offset else b""

    def read_qword(self, va: int) -> int | None:
        data = self.read_va(va, 8)
        return struct.unpack("<Q", data)[0] if len(data) == 8 else None


def printable_text(text: str) -> bool:
    return (
        len(text) >= PRINTABLE_MIN_LEN
        and any(ch.isalpha() for ch in text)
        and all(ch.isprintable() or ch in "\r\n\t" for ch in text)
    )


def scan_strings(pe: PEImage):
    exact: dict[int, str] = {}
    spans: list[tuple[int, int, str]] = []
    counts = Counter()
    for sec in pe.ro_sections:
        data = pe.data[sec["raw"] : sec["raw"] + sec["mapped"]]
        base_va = pe.runtime_base + sec["start"]
        i = 0
        while i < len(data):
            zero = data.find(b"\0", i)
            if zero > i:
                raw = data[i:zero]
                if len(raw) >= PRINTABLE_MIN_LEN:
                    try:
                        text = raw.decode("utf-8")
                    except UnicodeDecodeError:
                        text = None
                    if text and printable_text(text):
                        va = base_va + i
                        exact.setdefault(va, text)
                        spans.append((va, va + len(raw) + 1, text))
                        counts["utf8"] += 1
                        i = zero + 1
                        continue
            if i + 8 <= len(data) and data[i + 1] == 0:
                chars: list[str] = []
                j = i
                while j + 1 < len(data):
                    code = data[j] | (data[j + 1] << 8)
                    if code == 0:
                        break
                    ch = chr(code)
                    if code < 32 or (ch not in "\r\n\t" and not ch.isprintable()):
                        chars = []
                        break
                    chars.append(ch)
                    j += 2
                if len(chars) >= PRINTABLE_MIN_LEN and j + 1 < len(data) and data[j] == 0 and data[j + 1] == 0:
                    text = "".join(chars)
                    if printable_text(text):
                        va = base_va + i
                        exact.setdefault(va, text)
                        spans.append((va, va + (len(chars) + 1) * 2, text))
                        counts["utf16"] += 1
                        i = j + 2
                        continue
            if i + 24 <= len(data):
                length = struct.unpack_from("<I", data, i + 16)[0]
                end = i + 20 + length * 2
                if 4 <= length <= 200 and end + 1 < len(data) and data[end : end + 2] == b"\0\0":
                    try:
                        text = data[i + 20 : end].decode("utf-16-le")
                    except UnicodeDecodeError:
                        text = None
                    if text and printable_text(text):
                        obj_va = base_va + i
                        exact.setdefault(obj_va, text)
                        exact.setdefault(obj_va + 20, text)
                        spans.append((obj_va, obj_va + 22 + length * 2, text))
                        counts["il2cpp_utf16"] += 1
            i += 1
    spans.sort(key=lambda row: row[0])
    starts = [row[0] for row in spans]
    return exact, spans, starts, counts


def resolve_string(va: int, exact: dict[int, str], spans: list[tuple[int, int, str]], starts: list[int]) -> str | None:
    if va in exact:
        return exact[va]
    idx = bisect.bisect_right(starts, va) - 1
    if idx >= 0:
        start, end, text = spans[idx]
        if start <= va < end and va - start <= 32:
            return text
    return None


def build_disassembler() -> Cs:
    dis = Cs(CS_ARCH_X86, CS_MODE_64)
    dis.detail = True
    return dis


def normalize_reg(reg_id: int) -> str | None:
    return REGISTER_ALIASES.get(reg_id)


class MethodResolver:
    def __init__(self, records: list[MethodRecord], target_slop: int):
        self.records = records
        self.target_slop = target_slop
        self.va_to_methods: dict[int, list[MethodRecord]] = defaultdict(list)
        self.known_vas: list[int] = []
        for record in records:
            if record.va:
                self.va_to_methods[record.va].append(record)
        self.known_vas = sorted(self.va_to_methods)
        self.next_va: dict[int, int | None] = {}
        for idx, va in enumerate(self.known_vas):
            self.next_va[va] = self.known_vas[idx + 1] if idx + 1 < len(self.known_vas) else None

    def resolve_known_method_va(self, target_va: int) -> int | None:
        if target_va in self.va_to_methods:
            return target_va
        pos = bisect.bisect_left(self.known_vas, target_va)
        candidates: list[tuple[int, int]] = []
        for cand_pos in (pos - 1, pos, pos + 1):
            if 0 <= cand_pos < len(self.known_vas):
                candidate = self.known_vas[cand_pos]
                delta = abs(candidate - target_va)
                if delta <= self.target_slop:
                    candidates.append((delta, candidate))
        if not candidates:
            return None
        candidates.sort()
        if len(candidates) > 1 and candidates[0][0] == candidates[1][0]:
            return None
        return candidates[0][1]

    def code_window_size(self, va: int, max_scan_bytes: int) -> int:
        nxt = self.next_va.get(va)
        if not nxt or nxt <= va:
            return max_scan_bytes
        return max(16, min(max_scan_bytes, nxt - va))


def is_useful_name(name: str) -> bool:
    if not name:
        return False
    if OBF_METHOD_RE.fullmatch(name):
        return False
    return True


def canonicalize_string(text: str, limit: int = 80) -> str:
    text = text.replace("\r", "\\r").replace("\n", "\\n").replace("\t", "\\t")
    return text[: limit - 3] + "..." if len(text) > limit else text


def value_from_address(
    pe: PEImage,
    resolver: MethodResolver,
    exact_strings: dict[int, str],
    string_spans: list[tuple[int, int, str]],
    string_starts: list[int],
    va: int | None,
) -> ValueRef | None:
    if not va:
        return None
    text = resolve_string(va, exact_strings, string_spans, string_starts)
    if text:
        return ValueRef("string", va=va, text=text)
    ptr = pe.read_qword(va)
    if ptr:
        text = resolve_string(ptr, exact_strings, string_spans, string_starts)
        if text:
            return ValueRef("string", va=ptr, text=text)
        known = resolver.resolve_known_method_va(ptr)
        if known:
            return ValueRef("method", va=ptr, target_va=known)
    known = resolver.resolve_known_method_va(va)
    if known:
        return ValueRef("method", va=va, target_va=known)
    return ValueRef("ptr", va=va)


def evaluate_operand(
    insn,
    operand,
    reg_state: dict[str, ValueRef],
    pe: PEImage,
    resolver: MethodResolver,
    exact_strings: dict[int, str],
    string_spans: list[tuple[int, int, str]],
    string_starts: list[int],
) -> ValueRef | None:
    if operand.type == X86_OP_REG:
        return reg_state.get(normalize_reg(operand.reg) or "")
    if operand.type == X86_OP_IMM:
        return value_from_address(pe, resolver, exact_strings, string_spans, string_starts, operand.imm)
    if operand.type != X86_OP_MEM:
        return None
    base = normalize_reg(operand.mem.base)
    index = normalize_reg(operand.mem.index)
    if base == "rip":
        addr = insn.address + insn.size + operand.mem.disp
        return value_from_address(pe, resolver, exact_strings, string_spans, string_starts, addr)
    if index:
        return None
    if base and base in reg_state:
        base_val = reg_state[base]
        disp = operand.mem.disp
        if base_val.kind == "string" and base_val.va is not None:
            return value_from_address(pe, resolver, exact_strings, string_spans, string_starts, base_val.va + disp)
        if base_val.kind == "method" and disp == 0:
            return base_val
        if base_val.va is not None:
            return value_from_address(pe, resolver, exact_strings, string_spans, string_starts, base_val.va + disp)
    return None


def update_arithmetic_reg(
    reg_state: dict[str, ValueRef],
    dest_reg: str | None,
    insn_id: int,
    immediate: int,
    pe: PEImage,
    resolver: MethodResolver,
    exact_strings: dict[int, str],
    string_spans: list[tuple[int, int, str]],
    string_starts: list[int],
) -> None:
    if not dest_reg or dest_reg not in reg_state:
        return
    current = reg_state[dest_reg]
    if current.va is None:
        reg_state.pop(dest_reg, None)
        return
    delta = immediate if insn_id == X86_INS_ADD else -immediate
    candidate_va = current.va + delta
    updated = value_from_address(pe, resolver, exact_strings, string_spans, string_starts, candidate_va)
    if updated:
        reg_state[dest_reg] = updated
    else:
        reg_state.pop(dest_reg, None)


def follow_exec_target(pe: PEImage, resolver: MethodResolver, dis: Cs, target_va: int | None, depth: int = 0) -> int | None:
    if not target_va or depth > 2:
        return None
    known = resolver.resolve_known_method_va(target_va)
    if known:
        return known
    if not pe.is_exec(target_va):
        return None
    code = pe.read_va(target_va, 32)
    if not code:
        return None
    regs: dict[str, ValueRef] = {}
    for idx, insn in enumerate(dis.disasm(code, target_va)):
        ops = getattr(insn, "operands", [])
        if insn.id == X86_INS_MOV and len(ops) >= 2 and ops[0].type == X86_OP_REG:
            dest = normalize_reg(ops[0].reg)
            if ops[1].type == X86_OP_IMM:
                regs[dest or ""] = ValueRef("ptr", va=ops[1].imm)
            elif ops[1].type == X86_OP_REG:
                src = normalize_reg(ops[1].reg)
                if dest and src and src in regs:
                    regs[dest] = regs[src]
        if insn.id in {X86_INS_JMP, X86_INS_CALL}:
            if ops:
                if ops[0].type == X86_OP_IMM:
                    return follow_exec_target(pe, resolver, dis, ops[0].imm, depth + 1)
                if ops[0].type == X86_OP_REG:
                    reg = normalize_reg(ops[0].reg)
                    val = regs.get(reg or "")
                    if val and val.va is not None:
                        return follow_exec_target(pe, resolver, dis, val.va, depth + 1)
                if ops[0].type == X86_OP_MEM and normalize_reg(ops[0].mem.base) == "rip":
                    slot = insn.address + insn.size + ops[0].mem.disp
                    ptr = pe.read_qword(slot)
                    if ptr:
                        return follow_exec_target(pe, resolver, dis, ptr, depth + 1)
            return None
        if idx >= 2:
            break
    return None


def collect_preview(
    pe: PEImage,
    dis: Cs,
    method: MethodRecord,
    preview_bytes: int,
    exact_strings: dict[int, str],
    string_spans: list[tuple[int, int, str]],
    string_starts: list[int],
    resolver: MethodResolver,
) -> str:
    if not method.va:
        return ""
    code = pe.read_va(method.va, preview_bytes)
    if not code:
        return ""
    lines: list[str] = []
    used = 0
    for insn in dis.disasm(code, method.va):
        used += insn.size
        op = insn.op_str
        comment = ""
        ops = getattr(insn, "operands", [])
        if insn.id in {X86_INS_CALL, X86_INS_JMP} and ops:
            if ops[0].type == X86_OP_IMM:
                known = resolver.resolve_known_method_va(ops[0].imm)
                if known:
                    targets = resolver.va_to_methods.get(known) or []
                    if targets:
                        op = targets[0].key
            elif ops[0].type == X86_OP_MEM and normalize_reg(ops[0].mem.base) == "rip":
                slot = insn.address + insn.size + ops[0].mem.disp
                ptr = pe.read_qword(slot)
                known = follow_exec_target(pe, resolver, dis, ptr)
                if known:
                    targets = resolver.va_to_methods.get(known) or []
                    if targets:
                        op = f"[rip+0x{ops[0].mem.disp:X}] -> {targets[0].key}"
        elif insn.id in {X86_INS_LEA, X86_INS_MOV} and len(ops) >= 2:
            src = ops[1]
            if src.type == X86_OP_MEM and normalize_reg(src.mem.base) == "rip":
                addr = insn.address + insn.size + src.mem.disp
                text = resolve_string(addr, exact_strings, string_spans, string_starts)
                if not text:
                    ptr = pe.read_qword(addr)
                    if ptr:
                        text = resolve_string(ptr, exact_strings, string_spans, string_starts)
                if text:
                    comment = f' ; "{canonicalize_string(text, 48)}"'
        lines.append(f"{insn.mnemonic} {op}".rstrip() + comment)
        if used >= preview_bytes or insn.mnemonic in PREVIEW_TERM_MNEMONICS:
            break
    return "\n".join(lines)


def analyze_method_context(
    pe: PEImage,
    dis: Cs,
    method: MethodRecord,
    resolver: MethodResolver,
    exact_strings: dict[int, str],
    string_spans: list[tuple[int, int, str]],
    string_starts: list[int],
    scan_bytes: int,
    max_insns: int,
) -> tuple[list[str], list[int]]:
    if not method.va:
        return [], []
    window = resolver.code_window_size(method.va, scan_bytes)
    code = pe.read_va(method.va, window)
    if not code:
        return [], []
    strings: set[str] = set()
    callees: set[int] = set()
    visited_blocks: set[int] = set()
    visited_instrs: set[int] = set()
    pending_states: list[tuple[int, dict[str, ValueRef]]] = [(method.va, {})]
    while pending_states and len(visited_instrs) < max_insns:
        block_va, reg_state = pending_states.pop()
        if block_va in visited_blocks or block_va < method.va or block_va >= method.va + window:
            continue
        visited_blocks.add(block_va)
        block_code = pe.read_va(block_va, method.va + window - block_va)
        if not block_code:
            continue
        for insn in dis.disasm(block_code, block_va):
            if insn.address in visited_instrs:
                break
            visited_instrs.add(insn.address)
            ops = getattr(insn, "operands", [])
            _, writes = insn.regs_access()
            for reg_id in writes:
                reg_name = normalize_reg(reg_id)
                if reg_name:
                    reg_state.pop(reg_name, None)
            if insn.id in {X86_INS_MOV, X86_INS_LEA} and len(ops) >= 2 and ops[0].type == X86_OP_REG:
                dest_reg = normalize_reg(ops[0].reg)
                value = evaluate_operand(insn, ops[1], reg_state, pe, resolver, exact_strings, string_spans, string_starts)
                if dest_reg and value:
                    reg_state[dest_reg] = value
                    if value.kind == "string" and value.text:
                        strings.add(value.text)
            elif insn.id in {X86_INS_ADD, X86_INS_SUB} and len(ops) >= 2 and ops[0].type == X86_OP_REG and ops[1].type == X86_OP_IMM:
                update_arithmetic_reg(
                    reg_state,
                    normalize_reg(ops[0].reg),
                    insn.id,
                    ops[1].imm,
                    pe,
                    resolver,
                    exact_strings,
                    string_spans,
                    string_starts,
                )
            elif insn.id == X86_INS_XOR and len(ops) >= 2 and ops[0].type == X86_OP_REG and ops[1].type == X86_OP_REG:
                left = normalize_reg(ops[0].reg)
                right = normalize_reg(ops[1].reg)
                if left and left == right:
                    reg_state.pop(left, None)
            elif insn.id == X86_INS_POP and len(ops) >= 1 and ops[0].type == X86_OP_REG:
                reg_state.pop(normalize_reg(ops[0].reg) or "", None)
            elif insn.id == X86_INS_PUSH and ops:
                value = evaluate_operand(insn, ops[0], reg_state, pe, resolver, exact_strings, string_spans, string_starts)
                if value and value.kind == "string" and value.text:
                    strings.add(value.text)

            if insn.id == X86_INS_CALL:
                for reg in ARG_REGS:
                    val = reg_state.get(reg)
                    if val and val.kind == "string" and val.text:
                        strings.add(val.text)
                target_va = None
                if ops:
                    op0 = ops[0]
                    if op0.type == X86_OP_IMM:
                        target_va = resolver.resolve_known_method_va(op0.imm)
                    elif op0.type == X86_OP_REG:
                        val = reg_state.get(normalize_reg(op0.reg) or "")
                        if val and val.va is not None:
                            target_va = follow_exec_target(pe, resolver, dis, val.target_va or val.va)
                    elif op0.type == X86_OP_MEM and normalize_reg(op0.mem.base) == "rip":
                        slot = insn.address + insn.size + op0.mem.disp
                        ptr = pe.read_qword(slot)
                        if ptr:
                            target_va = follow_exec_target(pe, resolver, dis, ptr)
                if target_va:
                    callees.add(target_va)

            branch_target = None
            if ops and ops[0].type == X86_OP_IMM and (
                insn.id in {X86_INS_JMP, X86_INS_CALL} or insn.group(X86_GRP_JUMP)
            ):
                branch_target = ops[0].imm
            if branch_target and method.va <= branch_target < method.va + window:
                pending_states.append((branch_target, dict(reg_state)))
            if insn.mnemonic in PREVIEW_TERM_MNEMONICS:
                break
            if insn.id == X86_INS_JMP:
                break
            if len(visited_instrs) >= max_insns:
                break
    return sorted(strings), sorted(callees)


def build_reverse_callgraph(
    pe: PEImage,
    dis: Cs,
    resolver: MethodResolver,
    scan_bytes: int,
    max_insns: int,
) -> dict[int, set[int]]:
    reverse: dict[int, set[int]] = defaultdict(set)
    total = len(resolver.known_vas)
    for index, caller_va in enumerate(resolver.known_vas, start=1):
        method_stub = resolver.va_to_methods[caller_va][0]
        _, callees = analyze_method_context(
            pe,
            dis,
            method_stub,
            resolver,
            {},
            [],
            [],
            min(scan_bytes, resolver.code_window_size(caller_va, scan_bytes)),
            max_insns,
        )
        for callee_va in callees:
            reverse[callee_va].add(caller_va)
        if index % 10000 == 0:
            print(f"  Callgraph scan: {index:,}/{total:,}")
    return reverse


def classify_callees(methods: Iterable[MethodRecord]) -> tuple[list[str], list[str]]:
    named: set[str] = set()
    hashed: set[str] = set()
    for method in methods:
        if HASH_RE.fullmatch(method.method_name):
            hashed.add(method.key)
        elif is_useful_name(method.method_name):
            named.add(method.key)
    return sorted(named), sorted(hashed)


def collect_callers(caller_methods: Iterable[MethodRecord]) -> list[str]:
    callers = {method.key for method in caller_methods if is_useful_name(method.method_name)}
    return sorted(callers)


def chunk_output_path(prefix: str | Path, index: int) -> Path:
    return Path(f"{prefix}{index:03d}.json")


def write_chunk(path: Path, data: dict[str, dict]) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(data, indent=2, ensure_ascii=False), encoding="utf-8")


def cleanup_old_chunks(prefix: str | Path) -> None:
    prefix_path = Path(prefix)
    parent = prefix_path.parent
    stem = prefix_path.name
    for existing in parent.glob(f"{stem}[0-9][0-9][0-9].json"):
        existing.unlink()


def main() -> int:
    args = parse_args()

    print("Loading dumps...")
    precise_dump = load_json(args.precise)
    current_dump = load_json(args.deobf_json)
    cs_signatures = parse_deobf_cs_signatures(args.deobf_cs)
    cs_sig_lookup = build_signature_lookup(cs_signatures)
    records = build_method_records(precise_dump, current_dump, cs_sig_lookup)
    resolver = MethodResolver(records, args.target_slop)

    hash_targets = [record for record in records if record.va and HASH_RE.fullmatch(record.method_name)]
    print(f"  Methods with VA: {sum(1 for record in records if record.va):,}")
    print(f"  Hash targets: {len(hash_targets):,}")

    print("Loading PE...")
    pe = PEImage(args.dll)
    runtime_base = pe.infer_runtime_base(record.va for record in records if record.va)
    print(f"  Runtime image base: 0x{runtime_base:X}")

    print("Scanning string tables...")
    exact_strings, string_spans, string_starts, string_counts = scan_strings(pe)
    print(f"  Strings indexed: {len(exact_strings):,} {dict(string_counts)}")

    dis = build_disassembler()

    print("Building reverse callgraph...")
    reverse_callgraph = build_reverse_callgraph(pe, dis, resolver, args.scan_bytes, args.max_insns)
    print(f"  Reverse edges: {sum(len(v) for v in reverse_callgraph.values()):,}")

    output_path = Path(args.output)
    output_path.parent.mkdir(parents=True, exist_ok=True)
    cleanup_old_chunks(args.chunk_prefix)

    print("Extracting hash method contexts...")
    all_contexts: dict[str, dict] = {}
    current_chunk: dict[str, dict] = {}
    chunk_paths: list[Path] = []
    string_total = 0
    callee_total = 0
    sample_key: str | None = None

    for idx, record in enumerate(hash_targets, start=1):
        strings, callee_vas = analyze_method_context(
            pe,
            dis,
            record,
            resolver,
            exact_strings,
            string_spans,
            string_starts,
            args.scan_bytes,
            args.max_insns,
        )
        callee_methods = []
        for callee_va in callee_vas:
            callee_methods.extend(resolver.va_to_methods.get(callee_va, []))
        callees_named, callees_hash = classify_callees(callee_methods)

        caller_methods = []
        for caller_va in sorted(reverse_callgraph.get(record.va or 0, ())):
            caller_methods.extend(resolver.va_to_methods.get(caller_va, []))
        callers = collect_callers(caller_methods)

        context = {
            "class": record.class_name,
            "obf": record.raw_method_name,
            "signature": record.sig.signature,
            "ret_type": record.sig.ret_type,
            "params": record.sig.params,
            "strings": strings,
            "callees_named": callees_named,
            "callees_hash": callees_hash,
            "callers": callers,
            "body_preview": collect_preview(
                pe,
                dis,
                record,
                128,
                exact_strings,
                string_spans,
                string_starts,
                resolver,
            ),
        }

        all_contexts[record.key] = context
        current_chunk[record.key] = context
        string_total += len(strings)
        callee_total += len(callees_named) + len(callees_hash)
        if sample_key is None and (strings or callees_named or callees_hash or callers):
            sample_key = record.key

        if len(current_chunk) >= args.chunk_size:
            chunk_path = chunk_output_path(args.chunk_prefix, len(chunk_paths))
            write_chunk(chunk_path, current_chunk)
            chunk_paths.append(chunk_path)
            current_chunk = {}

        if idx % 500 == 0:
            print(f"  Context scan: {idx:,}/{len(hash_targets):,}")

    if current_chunk:
        chunk_path = chunk_output_path(args.chunk_prefix, len(chunk_paths))
        write_chunk(chunk_path, current_chunk)
        chunk_paths.append(chunk_path)

    output_path.write_text(json.dumps(all_contexts, indent=2, ensure_ascii=False), encoding="utf-8")

    avg_strings = string_total / max(len(hash_targets), 1)
    avg_callees = callee_total / max(len(hash_targets), 1)

    print("\nReport")
    print(f"  Total hash methods processed: {len(hash_targets):,}")
    print(f"  Average strings/method: {avg_strings:.2f}")
    print(f"  Average callees/method: {avg_callees:.2f}")
    print(f"  Total chunks: {len(chunk_paths):,}")
    print(f"  All-in-one file: {output_path} ({output_path.stat().st_size / (1024 * 1024):.2f} MiB)")
    print("  Chunk sizes:")
    for chunk_path in chunk_paths[:10]:
        print(f"    {chunk_path.name}: {chunk_path.stat().st_size / 1024:.1f} KiB")
    if len(chunk_paths) > 10:
        print(f"    ... {len(chunk_paths) - 10} more chunks")
    if sample_key:
        print("\nSample")
        print(json.dumps({sample_key: all_contexts[sample_key]}, indent=2, ensure_ascii=False))
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
