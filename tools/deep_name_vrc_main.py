#!/usr/bin/env python3
from __future__ import annotations

import argparse
import json
import re
import struct
import sys
from bisect import bisect_right
from collections import Counter, defaultdict
from dataclasses import dataclass
from pathlib import Path

import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import (
    X86_INS_CALL,
    X86_INS_LEA,
    X86_INS_MOV,
    X86_OP_IMM,
    X86_OP_MEM,
    X86_OP_REG,
    X86_REG_R8,
    X86_REG_R8D,
    X86_REG_R8W,
    X86_REG_R8B,
    X86_REG_R9,
    X86_REG_R9D,
    X86_REG_R9W,
    X86_REG_R9B,
    X86_REG_R10,
    X86_REG_R10D,
    X86_REG_R10W,
    X86_REG_R10B,
    X86_REG_R11,
    X86_REG_R11D,
    X86_REG_R11W,
    X86_REG_R11B,
    X86_REG_R12,
    X86_REG_R12D,
    X86_REG_R12W,
    X86_REG_R12B,
    X86_REG_R13,
    X86_REG_R13D,
    X86_REG_R13W,
    X86_REG_R13B,
    X86_REG_R14,
    X86_REG_R14D,
    X86_REG_R14W,
    X86_REG_R14B,
    X86_REG_R15,
    X86_REG_R15D,
    X86_REG_R15W,
    X86_REG_R15B,
    X86_REG_RAX,
    X86_REG_EAX,
    X86_REG_AX,
    X86_REG_AH,
    X86_REG_AL,
    X86_REG_RBX,
    X86_REG_EBX,
    X86_REG_BX,
    X86_REG_BH,
    X86_REG_BL,
    X86_REG_RCX,
    X86_REG_ECX,
    X86_REG_CX,
    X86_REG_CH,
    X86_REG_CL,
    X86_REG_RDX,
    X86_REG_EDX,
    X86_REG_DX,
    X86_REG_DH,
    X86_REG_DL,
    X86_REG_RSI,
    X86_REG_ESI,
    X86_REG_SI,
    X86_REG_SIL,
    X86_REG_RDI,
    X86_REG_EDI,
    X86_REG_DI,
    X86_REG_DIL,
    X86_REG_RBP,
    X86_REG_EBP,
    X86_REG_BP,
    X86_REG_BPL,
    X86_REG_RSP,
    X86_REG_ESP,
    X86_REG_SP,
    X86_REG_SPL,
    X86_REG_RIP,
)

sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")

ROOT = Path(__file__).resolve().parent.parent
HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
HEX_TAIL_RE = re.compile(r"_[0-9A-F]{3,4}$", re.I)
WORD_RE = re.compile(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+")

LIFECYCLE_NAMES = {
    "Awake",
    "Start",
    "OnEnable",
    "OnDisable",
    "OnDestroy",
    "Update",
    "LateUpdate",
    "FixedUpdate",
    "OnTriggerEnter",
    "OnTriggerExit",
    "OnTriggerStay",
    "OnCollisionEnter",
    "OnCollisionExit",
    "OnCollisionStay",
    "OnApplicationQuit",
}
GENERIC_WRAPPER_NAMES = {
    "CancelInvoke",
    "CompareBaseObjects",
    "Destroy",
    "DestroyImmediate",
    "DontDestroyOnLoad",
    "Equals",
    "FindFirstObjectByType",
    "FindObjectOfType",
    "FindObjectsByType",
    "GetCachedPtr",
    "GetHashCode",
    "GetInstanceID",
    "Instantiate",
    "Invoke",
    "InvokeRepeating",
    "IsInvoking",
    "IsNativeObjectAlive",
    "MoveNext",
    "Reset",
    "RestoreInstance",
    "StartCoroutine",
    "StartCoroutine_Auto",
    "StopAllCoroutines",
    "StopCoroutine",
    "ToString",
}
LOW_VALUE_PREFIXES = (
    "GetBackingFieldFromProperty",
    "GetConditionalPropertyAtOffset",
    "GetPropertyValueAtOffset",
    "GetPropertyValueAt",
    "GetTransform_",
    "GetGameObject_",
    "GetDeltaTime_",
    "DoInternal_",
    "DoInverseTransformPoint_Injected",
    "Access",
)
EXACT_PRIOR_FILES = (
    ("new_internal_body_propagation", ROOT / "output" / "new_internal_body_propagation.json", 1.15),
    ("va_propagation_v3_names", ROOT / "output" / "va_propagation_v3_names.json", 1.05),
    ("method_body_hash_lifts_v2", ROOT / "output" / "method_body_hash_lifts_v2.json", 1.0),
    ("cross_version_method_names", ROOT / "output" / "cross_version_method_names.json", 0.95),
)
FUZZY_PRIOR_FILES = (
    ("cross_version_body_fuzzy", ROOT / "output" / "cross_version_body_fuzzy.json", 0.55),
)
STRING_KEYWORDS = {
    "lifecycle": (
        "awake",
        "start",
        "update",
        "lateupdate",
        "fixedupdate",
        "ondestroy",
        "onenable",
        "ondisable",
        "tick",
        "frame",
    ),
    "network": (
        "rpc",
        "network",
        "photon",
        "send",
        "receive",
        "request",
        "response",
        "http",
        "cookie",
        "auth",
        "serialize",
        "deserialize",
        "sync",
        "room",
        "connection",
        "endpoint",
        "udon",
    ),
    "player": (
        "player",
        "avatar",
        "user",
        "pickup",
        "hand",
        "localplayer",
        "master",
        "moderation",
        "voice",
    ),
    "ui": (
        "ui",
        "menu",
        "button",
        "panel",
        "layout",
        "text",
        "image",
        "tooltip",
        "scroll",
        "canvas",
        "element",
        "view",
        "label",
        "screen",
    ),
}
THIS_REGS = {
    X86_REG_RCX,
    X86_REG_ECX,
    X86_REG_CX,
    X86_REG_CH,
    X86_REG_CL,
}
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
}


@dataclass(slots=True)
class MethodEntry:
    index: int
    raw_class_name: str
    raw_method_name: str
    semantic_class_name: str
    semantic_method_name: str
    namespace: str
    va: int | None
    key: str


class PEImage:
    def __init__(self, path: Path):
        self.path = path
        self.data = path.read_bytes()
        self.pe = pefile.PE(str(path), fast_load=True)
        self.pref_base = self.pe.OPTIONAL_HEADER.ImageBase
        self.runtime_base = 0
        self.sections = []
        self.exec_sections = []
        self.ro_sections = []
        for sec in self.pe.sections:
            mapped = min(sec.SizeOfRawData, max(0, len(self.data) - sec.PointerToRawData))
            if mapped <= 0:
                continue
            info = {
                "name": sec.Name.decode("ascii", errors="ignore").rstrip("\0"),
                "start": sec.VirtualAddress,
                "end": sec.VirtualAddress + mapped,
                "raw": sec.PointerToRawData,
                "mapped": mapped,
                "exec": bool(sec.Characteristics & 0x20000000),
                "ro": bool(sec.Characteristics & 0x40000000)
                and not bool(sec.Characteristics & 0x20000000)
                and not bool(sec.Characteristics & 0x80000000),
            }
            self.sections.append(info)
            if info["exec"]:
                self.exec_sections.append(info)
            if info["ro"]:
                self.ro_sections.append(info)

    def infer_runtime_base(self, dump: dict) -> int:
        vas = []
        for cls_list in dump.get("namespaces", {}).values():
            if not isinstance(cls_list, list):
                continue
            for cls in cls_list:
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
            hits = sum(
                1
                for va in vas
                if any(sec["start"] <= va - base < sec["end"] for sec in self.exec_sections)
            )
            if hits > best_hits:
                best_hits = hits
                best_base = base
        self.runtime_base = best_base
        return best_base

    def section_for_va(self, va: int):
        rva = va - self.runtime_base
        for sec in self.sections:
            if sec["start"] <= rva < sec["end"]:
                return sec
        return None

    def is_exec(self, va: int) -> bool:
        sec = self.section_for_va(va)
        return bool(sec and sec["exec"])

    def is_ro(self, va: int) -> bool:
        sec = self.section_for_va(va)
        return bool(sec and sec["ro"])

    def read_va(self, va: int, size: int) -> bytes:
        sec = self.section_for_va(va)
        if not sec:
            return b""
        rva = va - self.runtime_base
        offset = sec["raw"] + (rva - sec["start"])
        end = min(len(self.data), sec["raw"] + sec["mapped"], offset + size)
        return self.data[offset:end] if end > offset else b""

    def read_qword(self, va: int) -> int | None:
        raw = self.read_va(va, 8)
        if len(raw) != 8:
            return None
        return struct.unpack("<Q", raw)[0]


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description="Deep VRC_Main method naming for current VRChat build.")
    parser.add_argument("--dll", default=str(ROOT / "ida_new" / "GameAssembly.dll"))
    parser.add_argument("--precise", default=str(ROOT / "data" / "precise_dump.json"))
    parser.add_argument("--deobf", default=str(ROOT / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--name-map", default=str(ROOT / "output" / "name_mapping.json"))
    parser.add_argument("--old-precise", default=str(ROOT / "data" / "precise_dump_OLD_20260408.json"))
    parser.add_argument("--output", default=str(ROOT / "output" / "vrc_main_deep_names.json"))
    parser.add_argument("--report", default=str(ROOT / "output" / "vrc_main_deep_report.json"))
    parser.add_argument("--scan-bytes", type=int, default=2048)
    parser.add_argument("--max-insns", type=int, default=420)
    return parser.parse_args()


def load_json(path: str | Path, default=None):
    p = Path(path)
    if not p.exists():
        return {} if default is None else default
    with p.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def parse_va(value) -> int | None:
    try:
        return int(str(value), 16) if value else None
    except ValueError:
        return None


def flatten_classes(dump: dict):
    for ns, classes in dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            yield ns, cls


def pair_classes(raw_dump: dict, deobf_dump: dict):
    raw_items = list(flatten_classes(raw_dump))
    deobf_items = list(flatten_classes(deobf_dump))
    if len(raw_items) != len(deobf_items):
        raise ValueError(f"class count mismatch: {len(raw_items)} != {len(deobf_items)}")
    for idx, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(zip(raw_items, deobf_items)):
        if raw_ns != deobf_ns:
            raise ValueError(f"namespace mismatch at class {idx}: {raw_ns!r} != {deobf_ns!r}")
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods):
            raise ValueError(
                f"method count mismatch at class {idx}: {raw_cls.get('name')} / {deobf_cls.get('name')}"
            )
        yield raw_ns, raw_cls, deobf_cls


def split_words(text: str) -> list[str]:
    return WORD_RE.findall(text.replace("_", ""))


def pascalize(words: list[str]) -> str:
    parts = []
    for word in words:
        if not word:
            continue
        if word.isupper() and len(word) <= 4:
            parts.append(word.title())
        else:
            parts.append(word[0].upper() + word[1:])
    return "".join(parts)


def is_printable_ascii(text: str) -> bool:
    return len(text) >= 4 and any(ch.isalpha() for ch in text) and all(
        ch.isprintable() or ch in "\r\n\t" for ch in text
    )


def scan_ro_strings(pe: PEImage):
    exact = {}
    spans = []
    for sec in pe.ro_sections:
        data = pe.data[sec["raw"] : sec["raw"] + sec["mapped"]]
        base_va = pe.runtime_base + sec["start"]
        i = 0
        while i < len(data):
            end = data.find(b"\0", i)
            if end > i:
                raw = data[i:end]
                if len(raw) >= 4:
                    try:
                        text = raw.decode("utf-8")
                    except UnicodeDecodeError:
                        text = None
                    if text and is_printable_ascii(text):
                        va = base_va + i
                        exact.setdefault(va, text)
                        spans.append((va, va + len(raw) + 1, text))
                        i = end + 1
                        continue
            if i + 8 < len(data):
                end16 = data.find(b"\0\0", i, min(len(data), i + 256))
                if end16 > i and (end16 - i) % 2 == 0:
                    raw16 = data[i:end16]
                    try:
                        text16 = raw16.decode("utf-16le")
                    except UnicodeDecodeError:
                        text16 = None
                    if text16 and is_printable_ascii(text16):
                        va = base_va + i
                        exact.setdefault(va, text16)
                        spans.append((va, va + len(raw16) + 2, text16))
                        i = end16 + 2
                        continue
            i += 1
    spans.sort(key=lambda item: item[0])
    starts = [item[0] for item in spans]
    return exact, spans, starts


def resolve_string(
    target_va: int,
    exact_strings: dict[int, str],
    string_spans: list[tuple[int, int, str]],
    string_starts: list[int],
) -> str | None:
    if target_va in exact_strings:
        return exact_strings[target_va]
    pos = bisect_right(string_starts, target_va) - 1
    if pos >= 0:
        start, end, text = string_spans[pos]
        if start <= target_va < end and target_va - start <= 24:
            return text
    return None


def normalize_reg(reg_id: int) -> str | None:
    return REGISTER_ALIASES.get(reg_id)


def parse_accessor_name(name: str) -> tuple[str | None, str | None]:
    if name.startswith("get_") and len(name) > 4:
        return "getter", pascalize(split_words(name[4:]))
    if name.startswith("set_") and len(name) > 4:
        return "setter", pascalize(split_words(name[4:]))
    if name.startswith("Is") and len(name) > 2:
        return "predicate", name[2:]
    if name.startswith("Has") and len(name) > 3:
        return "predicate", name[3:]
    return None, None


def clean_prior_name(name: str) -> str | None:
    if not name:
        return None
    base = name.split("::")[-1].split(".")[-1]
    if base in {"Reset", "MoveNext"} and "IEnumerator" in name:
        base = "Reset"
    base = HEX_TAIL_RE.sub("", base)
    if base.startswith("get_") and len(base) > 4:
        return base
    if base.startswith("set_") and len(base) > 4:
        return base
    if base.startswith("SystemCollectionsIEnumerator"):
        return "Reset"
    if base.startswith("System.Collections.IEnumerator.Reset"):
        return "Reset"
    if base.startswith("op_"):
        return None
    if base.startswith("DoThrow"):
        return None
    for prefix in (
        "Compute",
        "Configure",
        "Initialize",
        "Process",
        "Handle",
        "Apply",
        "Get",
        "Set",
        "Update",
        "Refresh",
        "Reset",
        "Register",
        "Assign",
        "Sync",
        "Start",
        "Stop",
        "Find",
        "Create",
        "Destroy",
        "Release",
        "Authenticate",
        "Compare",
        "Validate",
    ):
        tail = base[len(prefix) : len(prefix) + 2]
        if base.startswith(prefix) and len(base) > len(prefix) + 1 and len(tail) == 2 and tail.islower():
            base = prefix + base[len(prefix)].upper() + base[len(prefix) + 1 :]
            break
    if any(base.startswith(prefix) for prefix in LOW_VALUE_PREFIXES):
        return None
    if not re.fullmatch(r"[A-Za-z_][A-Za-z0-9_]*", base):
        return None
    return base


def candidate_quality(name: str) -> float:
    score = 1.0
    if name in GENERIC_WRAPPER_NAMES:
        score -= 0.1
    if name in LIFECYCLE_NAMES:
        score += 0.15
    if name.startswith(("get_", "set_")):
        score += 0.05
    if any(name.startswith(prefix) for prefix in LOW_VALUE_PREFIXES):
        score -= 0.6
    if re.search(r"(Offset|Property|BackingField|Transform|GameObject|Quaternion|DeltaTime)$", name):
        score -= 0.35
    return score


def detect_shape(insns) -> str:
    text = " | ".join(f"{insn.mnemonic} {insn.op_str}".strip() for insn in insns[:8])
    if re.search(r"\bmov [er]ax, (?:byte ptr |word ptr |dword ptr |qword ptr )?\[rcx \+ ", text) and "ret" in text:
        return "getter"
    if re.search(r"\bmov (?:byte ptr |word ptr |dword ptr |qword ptr )?\[rcx \+ .+], [er]dx\b", text) and "ret" in text:
        return "setter"
    if re.search(r"\b(?:cmp|test) (?:byte ptr |word ptr |dword ptr |qword ptr )?\[rcx \+ ", text) and re.search(
        r"\bset[a-z]{1,2}\b", text
    ):
        return "predicate"
    if "call " in text and "ret" in text and not re.search(r"\bj[a-z]{1,3}\b", text):
        return "wrapper"
    return "method"


class MethodAnalyzer:
    def __init__(
        self,
        pe: PEImage,
        va_to_method: dict[int, str],
        exact_strings: dict[int, str],
        string_spans: list[tuple[int, int, str]],
        string_starts: list[int],
        scan_bytes: int,
        max_insns: int,
    ):
        self.pe = pe
        self.va_to_method = va_to_method
        self.exact_strings = exact_strings
        self.string_spans = string_spans
        self.string_starts = string_starts
        self.scan_bytes = scan_bytes
        self.max_insns = max_insns
        self.cs = Cs(CS_ARCH_X86, CS_MODE_64)
        self.cs.detail = True
        self.cache = {}

    def analyze(self, va: int | None) -> dict:
        if not va:
            return {
                "body_bytes_hex": "",
                "strings": [],
                "callees": [],
                "field_offsets": [],
                "field_matches": [],
                "shape": "unknown",
                "insn_count": 0,
            }
        if va in self.cache:
            return self.cache[va]
        code = self.pe.read_va(va, self.scan_bytes)
        if not code or not self.pe.is_exec(va):
            result = {
                "body_bytes_hex": "",
                "strings": [],
                "callees": [],
                "field_offsets": [],
                "field_matches": [],
                "shape": "unknown",
                "insn_count": 0,
            }
            self.cache[va] = result
            return result

        strings = []
        string_seen = set()
        callees = []
        callee_seen = set()
        field_offsets = []
        field_matches = []
        offset_seen = set()
        insns = []
        this_regs = {"rcx"}

        for idx, insn in enumerate(self.cs.disasm(code, va, count=self.max_insns)):
            insns.append(insn)
            ops = getattr(insn, "operands", [])

            if insn.id == X86_INS_MOV and len(ops) >= 2 and ops[0].type == X86_OP_REG and ops[1].type == X86_OP_REG:
                dst = normalize_reg(ops[0].reg)
                src = normalize_reg(ops[1].reg)
                if dst:
                    if src in this_regs:
                        this_regs.add(dst)
                    elif dst in this_regs:
                        this_regs.discard(dst)

            if insn.id == X86_INS_LEA and len(ops) >= 2 and ops[1].type == X86_OP_MEM and ops[1].mem.base == X86_REG_RIP:
                target = insn.address + insn.size + ops[1].mem.disp
                text = resolve_string(target, self.exact_strings, self.string_spans, self.string_starts)
                if text and text not in string_seen:
                    string_seen.add(text)
                    strings.append(text)

            if insn.id == X86_INS_MOV and len(ops) >= 2:
                src = ops[1]
                if src.type == X86_OP_MEM and src.mem.base == X86_REG_RIP:
                    target = insn.address + insn.size + src.mem.disp
                    qword = self.pe.read_qword(target)
                    if qword:
                        text = resolve_string(qword, self.exact_strings, self.string_spans, self.string_starts)
                        if text and text not in string_seen:
                            string_seen.add(text)
                            strings.append(text)
                elif src.type == X86_OP_IMM and self.pe.is_ro(src.imm):
                    text = resolve_string(src.imm, self.exact_strings, self.string_spans, self.string_starts)
                    if text and text not in string_seen:
                        string_seen.add(text)
                        strings.append(text)

            if insn.id == X86_INS_CALL and ops and ops[0].type == X86_OP_IMM:
                target = ops[0].imm
                resolved = self.va_to_method.get(target)
                if resolved and resolved not in callee_seen:
                    callee_seen.add(resolved)
                    callees.append({"va": f"0x{target:X}", "name": resolved})

            for op in ops:
                if op.type != X86_OP_MEM:
                    continue
                base = normalize_reg(op.mem.base) if op.mem.base else None
                if base in this_regs and 0 <= op.mem.disp < 0x4000 and op.mem.disp not in offset_seen:
                    offset_seen.add(op.mem.disp)
                    field_offsets.append(op.mem.disp)
                    field_matches.append({"offset": op.mem.disp, "field": None})

            if idx >= 6 and insn.mnemonic in {"ret", "retf", "int3", "ud2"}:
                break

        result = {
            "body_bytes_hex": code.hex(),
            "strings": strings,
            "callees": callees,
            "field_offsets": field_offsets,
            "field_matches": field_matches,
            "shape": detect_shape(insns),
            "insn_count": len(insns),
        }
        self.cache[va] = result
        return result


def build_method_lists(raw_dump: dict, deobf_dump: dict, name_map: dict):
    classes = name_map.get("classes", {})
    methods = name_map.get("methods", {})
    raw_vrc_main = next(raw for raw, semantic in classes.items() if semantic == "VRC_Main")
    target_raw_keys = {
        raw_key
        for raw_key, semantic_name in methods.items()
        if raw_key.startswith(f"{raw_vrc_main}::") and HASH_RE.fullmatch(str(semantic_name))
    }
    all_methods = []
    vrc_main_methods = []
    seen_target_raw_keys = set()
    raw_vrc_main_cls = None
    deobf_vrc_main_cls = None

    for ns, raw_cls, deobf_cls in pair_classes(raw_dump, deobf_dump):
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        raw_mp = raw_cls.get("method_pointers") or {}
        deobf_mp = deobf_cls.get("method_pointers") or {}
        for idx, (raw_name, semantic_name) in enumerate(zip(raw_methods, deobf_methods)):
            va = parse_va(raw_mp.get(raw_name)) or parse_va(deobf_mp.get(semantic_name))
            entry = MethodEntry(
                index=idx,
                raw_class_name=raw_cls.get("name", ""),
                raw_method_name=raw_name,
                semantic_class_name=deobf_cls.get("name", ""),
                semantic_method_name=semantic_name,
                namespace=ns,
                va=va,
                key=f"{deobf_cls.get('name', '')}::{semantic_name}",
            )
            all_methods.append(entry)
            if raw_cls.get("name") == raw_vrc_main:
                raw_vrc_main_cls = raw_cls
                deobf_vrc_main_cls = deobf_cls
                target_raw_key = f"{raw_vrc_main}::{raw_name}"
                if target_raw_key in target_raw_keys and target_raw_key not in seen_target_raw_keys:
                    seen_target_raw_keys.add(target_raw_key)
                    vrc_main_methods.append(entry)

    if raw_vrc_main_cls is None or deobf_vrc_main_cls is None:
        raise RuntimeError("Failed to resolve VRC_Main class pair.")
    return (
        raw_vrc_main,
        target_raw_keys,
        raw_vrc_main_cls,
        deobf_vrc_main_cls,
        all_methods,
        vrc_main_methods,
        len(seen_target_raw_keys),
    )


def build_va_to_method_map(all_methods: list[MethodEntry]) -> dict[int, str]:
    result = {}
    for entry in all_methods:
        if not entry.va:
            continue
        if entry.semantic_method_name and not HASH_RE.fullmatch(entry.semantic_method_name):
            result[entry.va] = f"{entry.semantic_class_name}::{entry.semantic_method_name}"
    return result


def build_accessor_map(
    analyzer: MethodAnalyzer,
    deobf_vrc_main_cls: dict,
    raw_vrc_main_cls: dict,
) -> tuple[dict[int, str], dict[int, list[str]]]:
    matches = defaultdict(list)
    raw_methods = raw_vrc_main_cls.get("methods") or []
    semantic_methods = deobf_vrc_main_cls.get("methods") or []
    raw_mp = raw_vrc_main_cls.get("method_pointers") or {}

    for raw_name, semantic_name in zip(raw_methods, semantic_methods):
        if HASH_RE.fullmatch(str(semantic_name)):
            continue
        shape, stem = parse_accessor_name(str(semantic_name))
        if not shape or not stem:
            continue
        va = parse_va(raw_mp.get(raw_name))
        ctx = analyzer.analyze(va)
        if ctx["shape"] not in {"getter", "setter", "predicate"}:
            continue
        if len(ctx["field_offsets"]) != 1:
            continue
        matches[ctx["field_offsets"][0]].append(stem)

    accessor_map = {}
    accessor_sources = {}
    for offset, stems in matches.items():
        counter = Counter(stems)
        stem, count = counter.most_common(1)[0]
        if count >= 1 and (len(counter) == 1 or count >= 2):
            accessor_map[offset] = stem
            accessor_sources[offset] = sorted(counter)
    return accessor_map, accessor_sources


def load_prior_names() -> dict[str, list[tuple[str, str, float]]]:
    prior_map = defaultdict(list)
    for source, path, weight in EXACT_PRIOR_FILES + FUZZY_PRIOR_FILES:
        data = load_json(path, {})
        for key, value in data.items():
            if not isinstance(key, str) or not key.startswith("VRC_Main::"):
                continue
            cleaned = clean_prior_name(str(value))
            if cleaned:
                prior_map[key].append((source, cleaned, weight))
    return prior_map


def score_categories(strings: list[str], callee_names: list[str], priors: list[str]) -> dict[str, float]:
    haystack = " ".join(strings + callee_names + priors).lower()
    scores = {}
    for category, words in STRING_KEYWORDS.items():
        score = 0.0
        for word in words:
            if word in haystack:
                score += 1.0
        scores[category] = score
    return scores


def choose_prediction(
    entry: MethodEntry,
    ctx: dict,
    prior_evidence: list[tuple[str, str, float]],
    accessor_map: dict[int, str],
    named_fields: list[str],
) -> tuple[str | None, float, str, str, list[str]]:
    key = f"VRC_Main::{entry.semantic_method_name}"
    shape = ctx["shape"]
    field_offsets = ctx["field_offsets"]
    strings = ctx["strings"]
    callee_names = [item["name"] for item in ctx["callees"]]
    prior_names = [name for _, name, _ in prior_evidence]
    categories = score_categories(strings, callee_names, prior_names)

    candidates = []

    for source, name, weight in prior_evidence:
        score = weight * candidate_quality(name)
        reason = f"prior:{source}"
        if name in LIFECYCLE_NAMES:
            score += 0.3
        if categories["network"] and any(token in name.lower() for token in ("network", "rpc", "auth", "sync", "request", "connection", "cookie")):
            score += 0.25
        if categories["player"] and "player" in name.lower():
            score += 0.2
        if categories["ui"] and any(token in name.lower() for token in ("ui", "menu", "panel", "text", "image", "layout", "scroll", "label", "view")):
            score += 0.2
        if categories["lifecycle"] and any(token in name.lower() for token in ("update", "start", "awake", "destroy", "enable", "disable", "trigger")):
            score += 0.2
        candidates.append((name, score, "prior", reason))

    if shape in {"getter", "setter", "predicate"} and len(field_offsets) == 1 and field_offsets[0] in accessor_map:
        stem = accessor_map[field_offsets[0]]
        if shape == "getter":
            name = f"get_{stem}"
        elif shape == "setter":
            name = f"set_{stem}"
        else:
            name = stem if stem.startswith(("Is", "Has", "Can", "Should")) else f"Is{stem}"
        score = 1.15 + (0.15 if name in prior_names else 0.0)
        candidates.append((name, score, "accessor", f"accessor:0x{field_offsets[0]:X}"))

    if shape == "wrapper" and len(callee_names) == 1:
        callee = callee_names[0].split("::", 1)[1]
        cleaned = clean_prior_name(callee)
        if cleaned:
            score = 0.9 * candidate_quality(cleaned)
            candidates.append((cleaned, score, "wrapper", f"wrapper:{callee_names[0]}"))

    if shape == "wrapper" and len(callee_names) > 1:
        short_names = [clean_prior_name(name.split("::", 1)[1]) for name in callee_names]
        short_names = [name for name in short_names if name]
        counter = Counter(short_names)
        if counter:
            name, count = counter.most_common(1)[0]
            if count >= 2:
                score = 0.82 * candidate_quality(name)
                candidates.append((name, score, "callgraph", f"callgraph:{count}"))

    if not candidates and prior_names:
        counter = Counter(prior_names)
        name, count = counter.most_common(1)[0]
        if count >= 2:
            candidates.append((name, 0.82 * candidate_quality(name), "prior_consensus", f"prior_consensus:{count}"))

    if not candidates:
        return None, 0.0, "ambiguous", "", []

    grouped = defaultdict(list)
    for name, score, category, reason in candidates:
        grouped[name].append((score, category, reason))

    best_name = None
    best_score = -999.0
    best_category = "ambiguous"
    best_reason = ""
    evidence_lines = []
    for name, rows in grouped.items():
        total = sum(score for score, _, _ in rows)
        max_category, max_reason = max(((category, reason, score) for score, category, reason in rows), key=lambda x: x[2])[:2]
        if name in GENERIC_WRAPPER_NAMES and not rows:
            total -= 0.1
        if total > best_score:
            best_name = name
            best_score = total
            best_category = max_category
            best_reason = max_reason
            evidence_lines = [reason for _, _, reason in rows]

    if not best_name:
        return None, 0.0, "ambiguous", "", []

    floor = 0.88
    if best_category == "accessor":
        floor = 1.0
    elif best_name in LIFECYCLE_NAMES:
        floor = 0.95
    elif best_name in GENERIC_WRAPPER_NAMES:
        floor = 0.9

    if best_score < floor:
        return None, best_score, best_category, best_reason, evidence_lines

    if best_name.startswith(("get_", "set_")):
        stem = best_name[4:]
        if stem and stem not in named_fields and any(best_name.endswith(x) for x in ("Transform", "GameObject", "Property", "Offset")):
            return None, best_score, best_category, best_reason, evidence_lines

    return best_name, best_score, best_category, best_reason, evidence_lines


def main() -> int:
    args = parse_args()

    precise_dump = load_json(args.precise, {})
    deobf_dump = load_json(args.deobf, {})
    name_map = load_json(args.name_map, {})
    _old_precise = load_json(args.old_precise, {})

    (
        raw_vrc_main,
        target_raw_keys,
        raw_vrc_main_cls,
        deobf_vrc_main_cls,
        all_methods,
        target_methods,
        seen_target_count,
    ) = build_method_lists(
        precise_dump, deobf_dump, name_map
    )

    pe = PEImage(Path(args.dll))
    pe.infer_runtime_base(precise_dump)
    exact_strings, string_spans, string_starts = scan_ro_strings(pe)
    va_to_method = build_va_to_method_map(all_methods)
    analyzer = MethodAnalyzer(pe, va_to_method, exact_strings, string_spans, string_starts, args.scan_bytes, args.max_insns)
    accessor_map, accessor_sources = build_accessor_map(analyzer, deobf_vrc_main_cls, raw_vrc_main_cls)
    prior_map = load_prior_names()

    named_fields = list(deobf_vrc_main_cls.get("fields") or [])
    prediction_map = {}
    prediction_meta = {}
    analysis_rows = []
    category_counts = Counter()
    type_counts = Counter()

    for entry in target_methods:
        key = f"VRC_Main::{entry.semantic_method_name}"
        ctx = analyzer.analyze(entry.va)
        for match in ctx["field_matches"]:
            offset = match["offset"]
            if offset in accessor_map:
                match["field"] = accessor_map[offset]
        prior_evidence = prior_map.get(key, [])
        predicted_name, confidence, heuristic_category, heuristic_reason, evidence_lines = choose_prediction(
            entry,
            ctx,
            prior_evidence,
            accessor_map,
            named_fields,
        )

        category_scores = score_categories(
            ctx["strings"],
            [item["name"] for item in ctx["callees"]],
            [name for _, name, _ in prior_evidence],
        )
        if category_scores:
            method_type = max(category_scores.items(), key=lambda item: item[1])[0]
            if category_scores[method_type] <= 0:
                method_type = "uncategorized"
        else:
            method_type = "uncategorized"
        if ctx["shape"] in {"getter", "setter", "predicate"}:
            method_type = "accessor"

        if predicted_name:
            existing = prediction_meta.get(key)
            if existing is None or confidence > existing["confidence"]:
                prediction_map[key] = predicted_name
                prediction_meta[key] = {
                    "predicted_name": predicted_name,
                    "confidence": confidence,
                    "heuristic_category": heuristic_category,
                    "method_type": method_type,
                }

        analysis_rows.append(
            {
                "key": key,
                "va": f"0x{entry.va:X}" if entry.va else None,
                "predicted_name": predicted_name,
                "confidence": round(confidence, 3),
                "heuristic_category": heuristic_category,
                "heuristic_reason": heuristic_reason,
                "evidence": evidence_lines,
                "method_type": method_type,
                "shape": ctx["shape"],
                "strings": ctx["strings"],
                "callees": ctx["callees"],
                "field_matches": ctx["field_matches"],
                "prior_names": [{"source": source, "name": name, "weight": weight} for source, name, weight in prior_evidence],
            }
        )

    category_counts = Counter(meta["heuristic_category"] for meta in prediction_meta.values())
    type_counts = Counter(meta["method_type"] for meta in prediction_meta.values())
    unique_hash_keys = len({entry.key for entry in target_methods})

    report = {
        "summary": {
            "raw_class_name": raw_vrc_main,
            "target_methods_raw_unique": len(target_raw_keys),
            "target_methods_seen_in_dump": seen_target_count,
            "target_method_entries_analyzed": len(target_methods),
            "target_unique_hash_keys": unique_hash_keys,
            "predictions_count": len(prediction_map),
            "prediction_breakdown": dict(sorted(category_counts.items())),
            "method_type_breakdown": dict(sorted(type_counts.items())),
            "accessor_offsets_inferred": {f"0x{offset:X}": stem for offset, stem in sorted(accessor_map.items())},
            "accessor_sources": {f"0x{offset:X}": stems for offset, stems in sorted(accessor_sources.items())},
        },
        "predictions": prediction_map,
        "analysis": analysis_rows,
    }

    output_path = Path(args.output)
    report_path = Path(args.report)
    output_path.parent.mkdir(parents=True, exist_ok=True)
    report_path.parent.mkdir(parents=True, exist_ok=True)
    with output_path.open("w", encoding="utf-8") as handle:
        json.dump(dict(sorted(prediction_map.items())), handle, indent=2, ensure_ascii=False)
    with report_path.open("w", encoding="utf-8") as handle:
        json.dump(report, handle, indent=2, ensure_ascii=False)

    print(f"VRC_Main raw hash targets from name_mapping: {len(target_raw_keys)}")
    print(f"VRC_Main target entries analyzed: {len(target_methods)}")
    print(f"VRC_Main unique semantic hash keys: {unique_hash_keys}")
    print(f"Predictions written: {len(prediction_map)}")
    print("Prediction breakdown:")
    for key, value in sorted(category_counts.items()):
        print(f"  {key}: {value}")
    print("Method type breakdown:")
    for key, value in sorted(type_counts.items()):
        print(f"  {key}: {value}")

    top_samples = [
        row
        for row in analysis_rows
        if row["predicted_name"]
    ]
    top_samples.sort(
        key=lambda row: (
            -row["confidence"],
            0 if row["heuristic_category"] == "accessor" else 1,
            row["key"],
        )
    )
    print("Top samples:")
    for row in top_samples[:20]:
        print(f"  {row['key']} -> {row['predicted_name']} [{row['heuristic_category']} {row['confidence']}]")

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
