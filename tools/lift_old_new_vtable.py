#!/usr/bin/env python3
"""Propagate NEW hash-method names from OLD semantic vtable slots."""

from __future__ import annotations

import argparse
import json
import os
import re
import sys
from collections import Counter, defaultdict
from dataclasses import dataclass
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


HASH_METHOD_RE = re.compile(r"^m_[0-9A-Fa-f]+$")
OBF_NAME_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
NUMERIC_WEAK_RE = re.compile(
    r"^(Type|Struct|Mono|Service|Major|Static|DataOnly|Unknown|Record)\d+"
)
BASE_CLASS_RE = re.compile(r"^BaseClass\d+")
HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4,}$")
CLASS_START_RE = re.compile(r"^\s*(?:public\s+)?class\s+([^\s:{]+)(?:\s*:\s*([^{]+))?\s*$")
METHOD_LINE_RE = re.compile(
    r"^\s*(?P<ret>.+?)\s+(?P<name>[^\s(]+)\((?P<params>.*)\)\s*;\s*(?://\s*(?P<va>0x[0-9A-Fa-f]+))?\s*$"
)

WEAK_CLASS_PREFIXES = (
    "AsyncStateMachine",
    "Enumerator",
    "StringEnumerator",
    "LifecycleComponent",
    "EmptyType",
    "EmptyStruct",
    "UpdateComponent",
    "ComplexComponent",
    "Delegate",
    "FBase",
    "AnimatedTextureBase",
    "NetworkReadyHandler",
    "MajorSystem",
    "VRC_Secondary",
    "VRCUiManagerSibling",
    "TransformGameObjectSystem",
    "UdonOperationResponse",
    "ComplexComponentSibling",
    "BaseSibling",
    "SiblingSibling",
    "Class",
    "Type",
    "NestedType",
    "GenericArg",
)

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


@dataclass(frozen=True, slots=True)
class MethodSig:
    ret_type: str
    params: tuple[str, ...]


@dataclass(frozen=True, slots=True)
class MatchRecord:
    namespace: str
    class_name: str
    key: str
    new_hash: str
    old_name: str
    slot: int
    new_sig: MethodSig
    old_sig: MethodSig
    class_match_mode: str


def parse_args() -> argparse.Namespace:
    base = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--old-raw", default=str(base / "data" / "precise_dump_OLD_20260408.json"))
    parser.add_argument(
        "--old-deobf",
        default=str(base / "output" / "v_old_20260408_regen" / "deobfuscated_dump.json"),
    )
    parser.add_argument(
        "--old-deobf-cs",
        default=str(base / "output" / "v_old_20260408_regen" / "deobfuscated_dump.cs"),
    )
    parser.add_argument(
        "--old-name-map",
        default=str(base / "output" / "v_old_20260408_regen" / "name_mapping.json"),
    )
    parser.add_argument("--new-precise", default=str(base / "data" / "precise_dump.json"))
    parser.add_argument("--new-deobf", default=str(base / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--new-deobf-cs", default=str(base / "output" / "deobfuscated_dump.cs"))
    parser.add_argument("--new-name-map", default=str(base / "output" / "name_mapping.json"))
    parser.add_argument(
        "--output",
        default=str(base / "output" / "old_new_vtable_names.json"),
    )
    parser.add_argument("--sample-count", type=int, default=20)
    return parser.parse_args()


def load_json(path: str | Path):
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path: str | Path) -> None:
    parent = Path(path).parent
    if str(parent):
        os.makedirs(parent, exist_ok=True)


def flatten_classes(dump: dict) -> list[tuple[str, dict]]:
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]


def normalize_type(text: str) -> str:
    cleaned = " ".join(text.strip().split())
    return TYPE_ALIASES.get(cleaned, cleaned)


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


def parse_param_types(param_text: str) -> tuple[str, ...]:
    if not param_text.strip():
        return ()
    params: list[str] = []
    for raw_param in split_top_level(param_text):
        text = " ".join(raw_param.split())
        if not text:
            continue
        if text == "...":
            params.append(text)
            continue
        pieces = text.split(" ")
        if len(pieces) > 1 and pieces[-1] not in {"ref", "out", "in", "params", "this"}:
            text = " ".join(pieces[:-1])
        params.append(normalize_type(text))
    return tuple(params)


def default_sig() -> MethodSig:
    return MethodSig("Void", ())


def parse_deobf_cs_classes(path: str | Path) -> list[tuple[str, list[MethodSig]]]:
    classes: list[tuple[str, list[MethodSig]]] = []
    pending_name: str | None = None
    current_name: str | None = None
    current_methods: list[MethodSig] | None = None
    brace_depth = 0
    with Path(path).open("r", encoding="utf-8", errors="ignore") as handle:
        for line in handle:
            stripped = line.rstrip("\r\n")
            if current_name is None:
                if pending_name is None:
                    match = CLASS_START_RE.match(stripped)
                    if match:
                        pending_name = match.group(1)
                        brace_depth = stripped.count("{") - stripped.count("}")
                        if "{" in stripped:
                            current_name = pending_name
                            current_methods = []
                            pending_name = None
                            if brace_depth <= 0:
                                classes.append((current_name, current_methods))
                                current_name = None
                                current_methods = None
                                brace_depth = 0
                    continue

                brace_depth += stripped.count("{") - stripped.count("}")
                if "{" in stripped:
                    current_name = pending_name
                    current_methods = []
                    pending_name = None
                    if brace_depth <= 0:
                        classes.append((current_name, current_methods))
                        current_name = None
                        current_methods = None
                        brace_depth = 0
                continue

            method_match = METHOD_LINE_RE.match(stripped)
            if method_match and current_methods is not None:
                current_methods.append(
                    MethodSig(
                        normalize_type(method_match.group("ret")),
                        parse_param_types(method_match.group("params")),
                    )
                )
            brace_depth += stripped.count("{") - stripped.count("}")
            if brace_depth <= 0:
                classes.append((current_name, current_methods or []))
                current_name = None
                current_methods = None
                brace_depth = 0
    return classes


def align_signature_lists(
    flat_classes: list[tuple[str, dict]],
    cs_classes: list[tuple[str, list[MethodSig]]],
) -> list[list[MethodSig]]:
    defaults = [[default_sig() for _ in (cls.get("methods") or [])] for _, cls in flat_classes]
    if not cs_classes:
        return defaults

    if len(flat_classes) == len(cs_classes):
        ordered_matches = sum(
            1
            for (_, cls), (cs_name, _) in zip(flat_classes, cs_classes)
            if cls.get("name") == cs_name
        )
        if ordered_matches >= int(len(flat_classes) * 0.90):
            aligned: list[list[MethodSig]] = []
            for (_, cls), (_, sigs) in zip(flat_classes, cs_classes):
                method_count = len(cls.get("methods") or [])
                fixed = list(sigs[:method_count])
                if len(fixed) < method_count:
                    fixed.extend(default_sig() for _ in range(method_count - len(fixed)))
                aligned.append(fixed)
            return aligned

    by_name: dict[str, list[list[MethodSig]]] = defaultdict(list)
    for cs_name, sigs in cs_classes:
        by_name[cs_name].append(sigs)

    aligned: list[list[MethodSig]] = []
    for _, cls in flat_classes:
        method_count = len(cls.get("methods") or [])
        sig_lists = by_name.get(cls.get("name", ""))
        if sig_lists:
            sigs = list(sig_lists.pop(0)[:method_count])
            if len(sigs) < method_count:
                sigs.extend(default_sig() for _ in range(method_count - len(sigs)))
            aligned.append(sigs)
        else:
            aligned.append([default_sig() for _ in range(method_count)])
    return aligned


def remap_member(class_name: str, raw_class_name: str, raw_member_name: str, mapping: dict[str, str]) -> str:
    for key in (
        f"{class_name}::{raw_member_name}",
        f"{raw_class_name}::{raw_member_name}",
    ):
        mapped = mapping.get(key)
        if mapped:
            return mapped
    return raw_member_name


def build_effective_dump(raw_dump: dict, name_map: dict) -> dict:
    class_map = name_map.get("classes", {})
    method_map = name_map.get("methods", {})
    field_map = name_map.get("fields", {})

    effective = {"summary": raw_dump.get("summary", {}), "namespaces": {}}
    for namespace, cls in flatten_classes(raw_dump):
        raw_name = cls.get("name", "")
        class_name = class_map.get(raw_name, raw_name)
        raw_parent = cls.get("parent", "")
        parent_name = class_map.get(raw_parent, raw_parent)
        raw_methods = list(cls.get("methods") or [])
        raw_fields = list(cls.get("fields") or [])

        effective["namespaces"].setdefault(namespace, []).append(
            {
                "name": class_name,
                "namespace": namespace,
                "parent": parent_name,
                "methods": [
                    remap_member(class_name, raw_name, method_name, method_map)
                    for method_name in raw_methods
                ],
                "fields": [
                    remap_member(class_name, raw_name, field_name, field_map)
                    for field_name in raw_fields
                ],
                "method_pointers": cls.get("method_pointers") or {},
                "va": cls.get("va", ""),
                "original_name": raw_name,
            }
        )
    return effective


def load_old_semantic_dump(args: argparse.Namespace) -> dict:
    old_deobf = Path(args.old_deobf)
    if old_deobf.exists():
        return load_json(old_deobf)
    old_raw = load_json(args.old_raw)
    old_name_map = load_json(args.old_name_map)
    return build_effective_dump(old_raw, old_name_map)


def is_hash_method(name: str | None) -> bool:
    return isinstance(name, str) and bool(HASH_METHOD_RE.fullmatch(name))


def is_semantic_method(name: str | None) -> bool:
    return (
        isinstance(name, str)
        and name != ""
        and name not in {".ctor", ".cctor"}
        and not name.startswith("<")
        and not is_hash_method(name)
        and not OBF_NAME_RE.search(name)
    )


def is_strong_semantic_class(name: str | None) -> bool:
    if not isinstance(name, str) or not name:
        return False
    if name.startswith("<") or ">" in name:
        return False
    if OBF_NAME_RE.search(name):
        return False
    if NUMERIC_WEAK_RE.match(name):
        return False
    if BASE_CLASS_RE.match(name):
        return False
    if HEX_SUFFIX_RE.search(name):
        return False
    return not any(name.startswith(prefix) for prefix in WEAK_CLASS_PREFIXES)


def signature_matches(new_sig: MethodSig, old_sig: MethodSig) -> bool:
    return new_sig.ret_type == old_sig.ret_type and len(new_sig.params) == len(old_sig.params)


def choose_old_class(
    old_by_ns_name: dict[tuple[str, str], list[int]],
    old_by_name: dict[str, list[int]],
    old_flat: list[tuple[str, dict]],
    new_namespace: str,
    semantic_name: str,
    new_method_count: int,
) -> tuple[int | None, str]:
    exact = old_by_ns_name.get((new_namespace, semantic_name), [])
    if len(exact) == 1:
        return exact[0], "exact_ns_name"
    if len(exact) > 1:
        exact_count = [idx for idx in exact if len(old_flat[idx][1].get("methods") or []) == new_method_count]
        if len(exact_count) == 1:
            return exact_count[0], "exact_ns_name_count"
        return None, "ambiguous_exact"

    by_name = old_by_name.get(semantic_name, [])
    if len(by_name) == 1:
        return by_name[0], "name_only"
    if len(by_name) > 1:
        by_count = [idx for idx in by_name if len(old_flat[idx][1].get("methods") or []) == new_method_count]
        if len(by_count) == 1:
            return by_count[0], "name_only_count"
        return None, "ambiguous_name"

    return None, "missing"


def main() -> int:
    args = parse_args()

    new_raw = load_json(args.new_precise)
    new_deobf = load_json(args.new_deobf)
    new_name_map = load_json(args.new_name_map)
    old_deobf = load_old_semantic_dump(args)

    new_flat_raw = flatten_classes(new_raw)
    new_flat_deobf = flatten_classes(new_deobf)
    old_flat = flatten_classes(old_deobf)
    if len(new_flat_raw) != len(new_flat_deobf):
        raise ValueError(
            f"NEW class count mismatch: {len(new_flat_raw)} != {len(new_flat_deobf)}"
        )

    for index, ((raw_ns, raw_cls), (cur_ns, cur_cls)) in enumerate(zip(new_flat_raw, new_flat_deobf)):
        if raw_ns != cur_ns:
            raise ValueError(f"NEW namespace mismatch at class {index}: {raw_ns!r} != {cur_ns!r}")
        raw_methods = raw_cls.get("methods") or []
        cur_methods = cur_cls.get("methods") or []
        if len(raw_methods) != len(cur_methods):
            raise ValueError(
                f"NEW method count mismatch at class {index}: {len(raw_methods)} != {len(cur_methods)}"
            )

    new_sig_lists = align_signature_lists(
        new_flat_deobf,
        parse_deobf_cs_classes(args.new_deobf_cs),
    )
    old_sig_lists = align_signature_lists(
        old_flat,
        parse_deobf_cs_classes(args.old_deobf_cs),
    )

    old_by_ns_name: dict[tuple[str, str], list[int]] = defaultdict(list)
    old_by_name: dict[str, list[int]] = defaultdict(list)
    for index, (namespace, cls) in enumerate(old_flat):
        name = cls.get("name", "")
        old_by_ns_name[(namespace, name)].append(index)
        old_by_name[name].append(index)

    class_map = new_name_map.get("classes", {})
    results: dict[str, str] = {}
    samples: list[MatchRecord] = []
    class_match_modes: Counter[str] = Counter()
    skip_reasons: Counter[str] = Counter()
    conflicts = 0
    matched_classes = 0

    for new_index, ((namespace, raw_cls), (_, new_cls)) in enumerate(zip(new_flat_raw, new_flat_deobf)):
        mapped_name = class_map.get(raw_cls.get("name", ""))
        semantic_name = mapped_name if is_strong_semantic_class(mapped_name) else new_cls.get("name", "")
        if not is_strong_semantic_class(semantic_name):
            skip_reasons["weak_or_unmapped_class"] += 1
            continue

        old_index, match_mode = choose_old_class(
            old_by_ns_name,
            old_by_name,
            old_flat,
            namespace,
            semantic_name,
            len(new_cls.get("methods") or []),
        )
        if old_index is None:
            skip_reasons[match_mode] += 1
            continue

        matched_classes += 1
        class_match_modes[match_mode] += 1

        old_cls = old_flat[old_index][1]
        new_methods = list(new_cls.get("methods") or [])
        old_methods = list(old_cls.get("methods") or [])
        new_sigs = new_sig_lists[new_index]
        old_sigs = old_sig_lists[old_index]
        limit = min(len(new_methods), len(old_methods))
        if len(new_methods) != len(old_methods):
            skip_reasons["class_method_count_changed"] += 1

        for slot in range(limit):
            new_name = new_methods[slot]
            old_name = old_methods[slot]
            if not is_hash_method(new_name):
                continue
            if not is_semantic_method(old_name):
                continue
            if not signature_matches(new_sigs[slot], old_sigs[slot]):
                continue

            key = f"{semantic_name}::{new_name}"
            existing = results.get(key)
            if existing and existing != old_name:
                conflicts += 1
                continue

            results[key] = old_name
            if len(samples) < args.sample_count:
                samples.append(
                    MatchRecord(
                        namespace=namespace,
                        class_name=semantic_name,
                        key=key,
                        new_hash=new_name,
                        old_name=old_name,
                        slot=slot,
                        new_sig=new_sigs[slot],
                        old_sig=old_sigs[slot],
                        class_match_mode=match_mode,
                    )
                )

    ensure_parent_dir(args.output)
    with Path(args.output).open("w", encoding="utf-8") as handle:
        json.dump(dict(sorted(results.items())), handle, ensure_ascii=False, indent=2)

    print(f"Matched classes: {matched_classes}")
    print(f"Propagations: {len(results)}")
    print(f"Conflicts skipped: {conflicts}")
    if class_match_modes:
        joined = ", ".join(f"{mode}={count}" for mode, count in sorted(class_match_modes.items()))
        print(f"Class match modes: {joined}")
    if skip_reasons:
        joined = ", ".join(f"{reason}={count}" for reason, count in sorted(skip_reasons.items()))
        print(f"Skipped classes: {joined}")
    print("Samples:")
    for sample in samples:
        print(
            f"  {sample.key} -> {sample.old_name} | ns={sample.namespace or '<global>'} "
            f"| slot={sample.slot} | sig={sample.new_sig.ret_type}/{len(sample.new_sig.params)} "
            f"| class_match={sample.class_match_mode}"
        )

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
