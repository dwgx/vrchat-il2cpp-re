#!/usr/bin/env python3
"""Build caller-propagated method names directly from GameAssembly.dll."""
from __future__ import annotations
import argparse, bisect, json, re, struct, sys
from collections import Counter, defaultdict
from pathlib import Path
import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import X86_INS_CALL

sys.stdout.reconfigure(encoding="utf-8"); sys.stderr.reconfigure(encoding="utf-8")
HASH_RE = re.compile(r"^m_[0-9A-Fa-f]+$"); OBF_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
WORD_RE = re.compile(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+")
CORE_SAMPLE_CLASSES = ("VRC_Main", "NetworkManager", "VRCPlayer", "VRC_Secondary", "VRCUiManager")
LIFECYCLE_NAMES = {"Awake": "InitializeOnAwake", "Start": "InitializeOnStart", "OnEnable": "EnableInternal", "OnDisable": "DisableInternal", "OnDestroy": "DestroyInternal", "Update": "UpdateInternal", "LateUpdate": "LateUpdateInternal", "FixedUpdate": "FixedUpdateInternal"}
VERB_SET = {"Add", "Apply", "Attach", "Build", "Check", "Clear", "Close", "Compute", "Connect", "Create", "Decode", "Deserialize", "Destroy", "Detach", "Disable", "Disconnect", "Enable", "Encode", "Fetch", "Find", "Generate", "Get", "Handle", "Has", "Initialize", "Insert", "Is", "Join", "Leave", "Load", "Open", "Parse", "Prepare", "Process", "Read", "Refresh", "Register", "Remove", "Render", "Reset", "Resolve", "Save", "Send", "Serialize", "Set", "Shutdown", "Start", "Stop", "Sync", "Trigger", "Try", "Unload", "Unregister", "Update", "Upload", "Validate", "Write"}
IGNORED_CALLER_NAMES = {".ctor", ".cctor", "Finalize", "Equals", "GetHashCode", "ToString", "CancelInvoke", "CompareBaseObjects", "Destroy", "DestroyImmediate", "GetCachedPtr", "GetHashCodeOfPtr", "Invoke", "InvokeRepeating", "GetInstanceID", "Instantiate", "Internal_InstantiateSingle_Injected", "IsNativeObjectAlive", "IsInvoking", "RestoreInstance", "StartCoroutine", "StartCoroutine_Auto", "StopCoroutine", "StopAllCoroutines", "MoveNext", "get_Current", "print", "Internal_CancelInvokeAll", "RaiseCancellation", "get_destroyCancellationToken", "get_useGUILayout", "set_useGUILayout", "get_name", "set_name", "op_Implicit"}
GENERIC_CANDIDATE_BASES = {"CompareBaseObjects", "Destroy", "Equals", "GetCachedPtr", "GetHashCode", "Instantiate", "IsNativeObjectAlive", "OpImplicit", "ToString"}
GENERIC_CANDIDATE_FRAGMENTS = {"CachedPtr", "CompareBaseObjects", "GetHashCode", "Instantiate", "NativeObjectAlive", "OpImplicit", "ToString"}


def parse_args() -> argparse.Namespace:
    base = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dll", default="D:/Steam/steamapps/common/VRChat/GameAssembly.dll")
    parser.add_argument("--precise", default=str(base / "data" / "precise_dump.json"))
    parser.add_argument("--deobf", default=str(base / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--output", default=str(base / "output" / "callgraph_method_names_native.json"))
    parser.add_argument("--scan-bytes", type=int, default=2048); parser.add_argument("--max-insns", type=int, default=256)
    parser.add_argument("--max-iterations", type=int, default=6); parser.add_argument("--target-slop", type=int, default=32)
    return parser.parse_args()


def load_json(path: str | Path) -> dict:
    with Path(path).open("r", encoding="utf-8") as handle: return json.load(handle)


def flatten_classes(dump: dict) -> list[tuple[str, dict]]:
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]


def pair_classes(raw_dump: dict, deobf_dump: dict):
    raw_items = flatten_classes(raw_dump)
    deobf_items = flatten_classes(deobf_dump)
    if len(raw_items) != len(deobf_items): raise ValueError(f"class count mismatch: {len(raw_items)} != {len(deobf_items)}")
    for index, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(zip(raw_items, deobf_items)):
        if raw_ns != deobf_ns: raise ValueError(f"namespace mismatch at class {index}: {raw_ns!r} != {deobf_ns!r}")
        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods): raise ValueError(f"method count mismatch at class {index}: {len(raw_methods)} != {len(deobf_methods)}")
        yield raw_cls, deobf_cls


def parse_va(value) -> int | None:
    if not value: return None
    try: va = int(str(value), 16)
    except ValueError: return None
    return va or None


def resolve_method_va(raw_cls: dict, deobf_cls: dict, index: int) -> int | None:
    raw_methods = raw_cls.get("methods") or []
    deobf_methods = deobf_cls.get("methods") or []
    raw_name = raw_methods[index]
    deobf_name = deobf_methods[index]
    raw_mp = raw_cls.get("method_pointers") or {}
    deobf_mp = deobf_cls.get("method_pointers") or {}
    for mapping, name in ((deobf_mp, deobf_name), (raw_mp, raw_name), (deobf_mp, raw_name), (raw_mp, deobf_name)):
        va = parse_va(mapping.get(name))
        if va: return va
    return None


def is_hash_method(name: str) -> bool:
    return bool(name) and bool(HASH_RE.fullmatch(name))


def is_semantic_method(name: str) -> bool:
    return bool(name) and not is_hash_method(name) and not OBF_RE.search(name) and not name.startswith("<") and name not in {".ctor", ".cctor"}


def is_useful_caller_name(name: str) -> bool:
    return is_semantic_method(name) and name not in IGNORED_CALLER_NAMES


def split_words(text: str) -> list[str]:
    return WORD_RE.findall(text.replace("_", ""))


def pascal(parts: list[str] | tuple[str, ...]) -> str:
    words = []
    for part in parts: words.extend(split_words(part))
    return "".join(word[:1].upper() + word[1:] for word in words if word)


def sanitize_identifier(name: str) -> str:
    name = re.sub(r"[^0-9A-Za-z_]", "_", name)
    name = re.sub(r"_+", "_", name).strip("_")
    if not name: return ""
    if name[0].isdigit(): name = "_" + name
    return name


def common_word_prefix(values: list[str]) -> str:
    sequences = [split_words(value) for value in values if value]
    if not sequences: return ""
    prefix = []
    for group in zip(*sequences):
        if len(set(group)) != 1: break
        prefix.append(group[0])
    return "".join(prefix)


def normalize_exact(name: str) -> str:
    if name.startswith("get_") and len(name) > 4:
        return f"get_{pascal([name[4:]])}"
    if name.startswith("set_") and len(name) > 4:
        return f"set_{pascal([name[4:]])}"
    return pascal([name]) or sanitize_identifier(name)


def parse_caller_shape(name: str) -> tuple[str, str]:
    if name.startswith("get_") and len(name) > 4: return "get", pascal([name[4:]])
    if name.startswith("set_") and len(name) > 4: return "set", pascal([name[4:]])
    if name in LIFECYCLE_NAMES: return name, ""
    words = split_words(name)
    if not words: return "", ""
    first = words[0]
    if first in VERB_SET: return first, "".join(words[1:])
    if name.startswith("On") and len(words) >= 2: return "On", "".join(words[1:])
    return "", ""


def candidate_ok(name: str) -> bool:
    if not (bool(name) and 3 <= len(name) <= 64 and not is_hash_method(name)): return False
    base = name
    for suffix in ("Internal", "Helper"):
        if base.endswith(suffix) and len(base) > len(suffix):
            base = base[: -len(suffix)]
            break
    if base.startswith("get_"):
        base = "Get" + pascal([base[4:]])
    elif base.startswith("set_"):
        base = "Set" + pascal([base[4:]])
    if base in GENERIC_CANDIDATE_BASES: return False
    return not any(fragment in base for fragment in GENERIC_CANDIDATE_FRAGMENTS)


def rank_semantic_name(name: str, inferred: bool) -> tuple[int, int, int, str]:
    return (1 if inferred else 0, 1 if name in IGNORED_CALLER_NAMES else 0, len(name), name)


class PEImage:
    def __init__(self, path: str | Path):
        self.path = Path(path)
        self.data = self.path.read_bytes()
        self.pe = pefile.PE(str(self.path), fast_load=True)
        self.preferred_base = self.pe.OPTIONAL_HEADER.ImageBase
        self.runtime_base = 0
        self.sections = []
        self.exec_sections = []
        for sec in self.pe.sections:
            mapped = min(sec.SizeOfRawData, max(0, len(self.data) - sec.PointerToRawData))
            if mapped <= 0:
                continue
            info = {
                "start": sec.VirtualAddress,
                "end": sec.VirtualAddress + mapped,
                "raw": sec.PointerToRawData,
                "mapped": mapped,
                "exec": bool(sec.Characteristics & 0x20000000),
            }
            self.sections.append(info)
            if info["exec"]:
                self.exec_sections.append(info)
        if not self.exec_sections:
            raise ValueError("no executable sections found")

    def infer_runtime_base(self, dump: dict) -> int:
        vas = []
        for _, cls in flatten_classes(dump):
            for value in (cls.get("method_pointers") or {}).values():
                va = parse_va(value)
                if va:
                    vas.append(va)
        if not vas:
            self.runtime_base = self.preferred_base
            return self.runtime_base
        low = ((max(vas) - max(sec["end"] for sec in self.exec_sections)) // 0x10000) * 0x10000
        high = (
            (min(vas) - min(sec["start"] for sec in self.exec_sections)) // 0x10000
        ) * 0x10000
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

    def section_for_va(self, va: int):
        rva = va - self.runtime_base
        for sec in self.sections:
            if sec["start"] <= rva < sec["end"]:
                return sec
        return None

    def is_exec(self, va: int) -> bool:
        sec = self.section_for_va(va)
        return bool(sec and sec["exec"])

    def read_va(self, va: int, size: int) -> bytes:
        sec = self.section_for_va(va)
        if not sec:
            return b""
        rva = va - self.runtime_base
        offset = sec["raw"] + (rva - sec["start"])
        end = min(len(self.data), sec["raw"] + sec["mapped"], offset + size)
        return self.data[offset:end] if end > offset else b""


def build_disassembler() -> Cs:
    return Cs(CS_ARCH_X86, CS_MODE_64)


def collect_methods(precise_dump: dict, deobf_dump: dict):
    methods = []
    va_to_methods = defaultdict(list)
    class_existing_names = defaultdict(set)
    for raw_cls, deobf_cls in pair_classes(precise_dump, deobf_dump):
        class_name = deobf_cls["name"]
        methods_list = deobf_cls.get("methods") or []
        for name in methods_list:
            if is_semantic_method(name):
                class_existing_names[class_name].add(name)
        for index, method_name in enumerate(methods_list):
            va = resolve_method_va(raw_cls, deobf_cls, index)
            if not va:
                continue
            info = {
                "key": f"{class_name}::{method_name}",
                "class_name": class_name,
                "method_name": method_name,
                "va": va,
                "is_hash": is_hash_method(method_name),
            }
            methods.append(info)
            va_to_methods[va].append(info)
    return methods, va_to_methods, class_existing_names


def build_callgraph(
    pe: PEImage,
    method_vas: list[int],
    scan_bytes: int,
    max_insns: int,
    target_slop: int,
):
    cs = build_disassembler()
    callee_to_callers = defaultdict(list)
    total_edges = 0
    unique_edges = set()
    scanned = 0
    known_vas = set(method_vas)

    def resolve_target(target_va: int) -> int | None:
        if target_va in known_vas:
            return target_va
        pos = bisect.bisect_left(method_vas, target_va)
        candidates = []
        for cand_pos in (pos - 1, pos, pos + 1):
            if 0 <= cand_pos < len(method_vas):
                candidate = method_vas[cand_pos]
                delta = abs(target_va - candidate)
                if delta <= target_slop:
                    candidates.append((delta, candidate))
        if not candidates:
            return None
        candidates.sort()
        if len(candidates) > 1 and candidates[0][0] == candidates[1][0]:
            return None
        return candidates[0][1]

    for index, caller_va in enumerate(method_vas, start=1):
        if not pe.is_exec(caller_va):
            continue
        code = pe.read_va(caller_va, scan_bytes)
        if not code:
            continue
        scanned += 1
        for insn_index, insn in enumerate(cs.disasm(code, caller_va)):
            if (
                insn.id == X86_INS_CALL
                and len(insn.bytes) == 5
                and insn.bytes[0] == 0xE8
            ):
                rel = struct.unpack_from("<i", insn.bytes, 1)[0]
                target_va = resolve_target(insn.address + 5 + rel)
                if target_va is not None:
                    callee_to_callers[target_va].append(caller_va)
                    total_edges += 1
                    unique_edges.add((caller_va, target_va))
            if insn.mnemonic in {"ret", "retf", "int3", "ud2"}:
                break
            if insn_index + 1 >= max_insns:
                break
        if index % 50000 == 0:
            print(f"  Disassembled {index:,}/{len(method_vas):,} VAs...")
    return callee_to_callers, total_edges, len(unique_edges), scanned


def choose_va_semantic_name(
    infos: list[dict], semantic_state: dict[str, str], inferred_keys: set[str]
) -> str | None:
    candidates = []
    for info in infos:
        if info["key"] not in semantic_state:
            continue
        name = semantic_state[info["key"]]
        if not is_useful_caller_name(name):
            continue
        candidates.append((rank_semantic_name(name, info["key"] in inferred_keys), name))
    if not candidates:
        return None
    candidates.sort(key=lambda item: item[0])
    return candidates[0][1]


def derive_candidate(caller_names: list[str]) -> tuple[str | None, tuple[int, float, int]]:
    total = len(caller_names)
    exact_counts = Counter(caller_names)
    top_exact, top_exact_count = exact_counts.most_common(1)[0]
    top_exact_ratio = top_exact_count / total

    if top_exact in LIFECYCLE_NAMES and total >= 2 and top_exact_ratio >= 0.6:
        return LIFECYCLE_NAMES[top_exact], (total, top_exact_ratio, len(exact_counts))

    if top_exact.startswith("get_") and total >= 2 and top_exact_ratio >= 0.5:
        prop = pascal([top_exact[4:]])
        if prop:
            return f"get_{prop}Internal", (total, top_exact_ratio, len(exact_counts))

    if top_exact.startswith("set_") and total >= 2 and top_exact_ratio >= 0.5:
        prop = pascal([top_exact[4:]])
        if prop:
            return f"set_{prop}Internal", (total, top_exact_ratio, len(exact_counts))

    shapes = []
    for name in caller_names:
        verb, subject = parse_caller_shape(name)
        if verb:
            shapes.append((verb, subject))
    if shapes:
        verb_counts = Counter(verb for verb, _ in shapes)
        top_verb, top_verb_count = verb_counts.most_common(1)[0]
        top_verb_ratio = top_verb_count / total
        top_subjects = [subject for verb, subject in shapes if verb == top_verb and subject]
        common_subject = common_word_prefix(top_subjects)
        top_subject = Counter(top_subjects).most_common(1)[0][0] if top_subjects else ""

        if top_verb in {"get", "set"} and total >= 2 and top_verb_ratio >= 0.5:
            prop = common_subject or top_subject
            if prop:
                return f"{top_verb}_{prop}Internal", (
                    total,
                    top_verb_ratio,
                    len(verb_counts),
                )

        if top_verb in {"Update", "LateUpdate", "FixedUpdate"} and total >= 2 and top_verb_ratio >= 0.5:
            return f"{top_verb}Internal", (total, top_verb_ratio, len(verb_counts))

        if top_verb in {"Awake", "Start", "OnEnable", "OnDisable", "OnDestroy"} and total >= 2 and top_verb_ratio >= 0.5:
            mapped = LIFECYCLE_NAMES.get(top_verb)
            if mapped:
                return mapped, (total, top_verb_ratio, len(verb_counts))

        if total >= 3 and top_verb_ratio >= 0.7:
            if top_verb == "Initialize":
                return "InitializeInternal", (total, top_verb_ratio, len(verb_counts))
            if top_verb in {"Enable", "Disable", "Connect", "Disconnect", "Refresh"}:
                return f"{top_verb}Internal", (total, top_verb_ratio, len(verb_counts))
            if common_subject:
                return f"{top_verb}{common_subject}", (total, top_verb_ratio, len(verb_counts))
            return f"{top_verb}Helper", (total, top_verb_ratio, len(verb_counts))

    if total >= 2 and top_exact_ratio >= 0.75:
        base = normalize_exact(top_exact)
        if base:
            return f"{base}Helper", (total, top_exact_ratio, len(exact_counts))

    return None, (total, top_exact_ratio, len(exact_counts))


def emit_names(
    hash_methods: list[dict],
    va_to_methods: dict[int, list[dict]],
    callee_to_callers: dict[int, list[int]],
    class_existing_names: dict[str, set[str]],
    max_iterations: int,
):
    semantic_state = {}
    for infos in va_to_methods.values():
        for info in infos:
            if is_useful_caller_name(info["method_name"]):
                semantic_state[info["key"]] = info["method_name"]

    emitted = {}
    inferred_keys = set()
    iterations = 0

    while iterations < max_iterations:
        proposals = []
        for info in hash_methods:
            if info["key"] in emitted:
                continue
            caller_names = []
            for caller_va in sorted(set(callee_to_callers.get(info["va"], []))):
                caller_name = choose_va_semantic_name(
                    va_to_methods[caller_va], semantic_state, inferred_keys
                )
                if caller_name:
                    caller_names.append(caller_name)
            if not caller_names:
                continue
            candidate, score = derive_candidate(caller_names)
            candidate = sanitize_identifier(candidate or "")
            if not candidate_ok(candidate):
                continue
            proposals.append(
                {
                    "info": info,
                    "candidate": candidate,
                    "score": score,
                    "callers": caller_names,
                }
            )

        if not proposals:
            break

        proposals.sort(
            key=lambda row: (
                -row["score"][0],
                -row["score"][1],
                row["score"][2],
                row["info"]["key"],
            )
        )

        new_names = 0
        for row in proposals:
            info = row["info"]
            candidate = row["candidate"]
            if info["key"] in emitted:
                continue
            existing = class_existing_names[info["class_name"]]
            if candidate in existing:
                continue
            emitted[info["key"]] = candidate
            semantic_state[info["key"]] = candidate
            inferred_keys.add(info["key"])
            existing.add(candidate)
            new_names += 1

        if not new_names:
            break
        iterations += 1
        print(f"  Snowball iteration {iterations}: +{new_names:,} names")

    semantic_caller_methods = 0
    for info in hash_methods:
        if info["key"] in emitted:
            semantic_caller_methods += 1
            continue
        for caller_va in sorted(set(callee_to_callers.get(info["va"], []))):
            if choose_va_semantic_name(va_to_methods[caller_va], semantic_state, inferred_keys):
                semantic_caller_methods += 1
                break

    return emitted, iterations, semantic_caller_methods, semantic_state, inferred_keys


def print_samples(
    emitted: dict[str, str],
    hash_methods: list[dict],
    callee_to_callers: dict[int, list[int]],
    va_to_methods: dict[int, list[dict]],
    semantic_state: dict[str, str],
    inferred_keys: set[str],
):
    methods_by_key = {info["key"]: info for info in hash_methods}
    rows = []
    for key, name in emitted.items():
        info = methods_by_key.get(key)
        if not info or info["class_name"] not in CORE_SAMPLE_CLASSES:
            continue
        caller_names = []
        for caller_va in sorted(set(callee_to_callers.get(info["va"], []))):
            caller_name = choose_va_semantic_name(
                va_to_methods[caller_va], semantic_state, inferred_keys
            )
            if caller_name:
                caller_names.append(caller_name)
        rows.append(
            (
                info["class_name"],
                len(caller_names),
                key,
                name,
                ", ".join(Counter(caller_names).keys())[:100],
            )
        )
    rows.sort(key=lambda row: (CORE_SAMPLE_CLASSES.index(row[0]), -row[1], row[2]))
    print("\nSamples")
    if not rows:
        print("  No emitted samples in requested core classes.")
        return
    for class_name, count, key, name, callers in rows[:10]:
        print(f"  {key} -> {name} | semantic callers={count} | {callers}")


def main() -> int:
    args = parse_args()
    print("Loading dumps...")
    precise_dump = load_json(args.precise)
    deobf_dump = load_json(args.deobf)

    print("Indexing methods...")
    methods, va_to_methods, class_existing_names = collect_methods(precise_dump, deobf_dump)
    hash_methods = [info for info in methods if info["is_hash"]]
    unique_vas = sorted(va_to_methods)
    print(
        f"  Methods with VA: {len(methods):,} | unique VAs: {len(unique_vas):,} | "
        f"hash methods: {len(hash_methods):,}"
    )

    print("Loading PE...")
    pe = PEImage(args.dll)
    runtime_base = pe.infer_runtime_base(precise_dump)
    print(f"  Runtime image base: 0x{runtime_base:X}")

    print("Disassembling and building call graph...")
    callee_to_callers, total_edges, unique_edges, scanned = build_callgraph(
        pe,
        unique_vas,
        args.scan_bytes,
        args.max_insns,
        args.target_slop,
    )
    print(
        f"  Scanned executable methods: {scanned:,} | total call edges: {total_edges:,} "
        f"| unique caller->callee pairs: {unique_edges:,}"
    )

    print("Propagating names from semantic callers...")
    emitted, iterations, semantic_caller_methods, semantic_state, inferred_keys = emit_names(
        hash_methods,
        va_to_methods,
        callee_to_callers,
        class_existing_names,
        args.max_iterations,
    )

    output_path = Path(args.output)
    output_path.parent.mkdir(parents=True, exist_ok=True)
    output_path.write_text(
        json.dumps(dict(sorted(emitted.items())), indent=2, ensure_ascii=False),
        encoding="utf-8",
    )

    print("\nReport")
    print(f"  Total call edges discovered: {total_edges:,}")
    print(f"  Methods with at least one semantic caller: {semantic_caller_methods:,}")
    print(f"  Names emitted: {len(emitted):,}")
    print(f"  Snowball iterations: {iterations}")
    print(f"\nWrote {output_path}")
    print_samples(
        emitted,
        hash_methods,
        callee_to_callers,
        va_to_methods,
        semantic_state,
        inferred_keys,
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
