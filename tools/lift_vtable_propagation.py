#!/usr/bin/env python3
"""Propagate semantic names across inherited IL2CPP vtable slots."""

from __future__ import annotations

import argparse
import json
import re
import sys
from collections import Counter, defaultdict, deque
from dataclasses import dataclass
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")


HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
NAMESPACE_RE = re.compile(r"^\s*namespace\s+([^\s{]+)\s*$")
CLASS_RE = re.compile(r"^\s*(?:public\s+)?class\s+([^\s:{]+)(?:\s*:\s*([^{]+))?\s*$")
METHOD_RE = re.compile(
    r"^\s*(?P<ret>.+?)\s+(?P<name>[^\s(]+)\((?P<params>.*)\)\s*;\s*(?://\s*(?P<va>0x[0-9A-Fa-f]+))?\s*$"
)
INTERFACE_HINT_RE = re.compile(r"(^|[.<])I[A-Z]")

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


@dataclass(slots=True, frozen=True)
class MethodSignature:
    return_type: str
    param_types: tuple[str, ...]

    def display(self) -> str:
        return f"{self.return_type}({', '.join(self.param_types)})"


@dataclass(slots=True)
class ParsedCsClass:
    namespace: str
    name: str
    parent_parts: list[str]
    method_names: list[str]
    signatures: list[MethodSignature]


@dataclass(slots=True)
class ClassRecord:
    class_id: int
    namespace: str
    raw_name: str
    semantic_name: str
    raw_parent: str
    semantic_parent_decl: str
    interfaces: list[str]
    raw_methods: list[str]
    effective_names: list[str]
    signatures: list[MethodSignature]


@dataclass(slots=True)
class PropagationEvent:
    key: str
    value: str
    depth: int
    source_kind: str
    target_class: str
    target_namespace: str
    parent_class: str | None
    slot: int
    signature: str
    target_hash: str


def parse_args() -> argparse.Namespace:
    base = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "--precise",
        default=str(base / "data" / "precise_dump.json"),
        help="Path to precise_dump.json",
    )
    parser.add_argument(
        "--mapping",
        default=str(base / "output" / "name_mapping.json"),
        help="Path to name_mapping.json",
    )
    parser.add_argument(
        "--deobf-cs",
        default=str(base / "output" / "deobfuscated_dump.cs"),
        help="Path to the deobfuscated C# dump used for signatures",
    )
    parser.add_argument(
        "--output",
        default=str(base / "output" / "vtable_propagation.json"),
        help="Flat JSON output path",
    )
    return parser.parse_args()


def load_json(path: str | Path) -> dict:
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def split_top_level(text: str, delimiter: str = ",") -> list[str]:
    if not text:
        return []
    out: list[str] = []
    current: list[str] = []
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
            piece = "".join(current).strip()
            if piece:
                out.append(piece)
            current.clear()
            continue
        current.append(ch)
    tail = "".join(current).strip()
    if tail:
        out.append(tail)
    return out


def normalize_type(text: str) -> str:
    text = " ".join(text.strip().split())
    return TYPE_ALIASES.get(text, text)


def parse_param_types(param_text: str) -> tuple[str, ...]:
    if not param_text.strip():
        return ()
    result: list[str] = []
    for raw_param in split_top_level(param_text):
        text = " ".join(raw_param.split())
        if not text:
            continue
        if text == "...":
            result.append(text)
            continue
        pieces = text.split(" ")
        if len(pieces) > 1 and pieces[-1] not in {"ref", "out", "in", "params", "this"}:
            text = " ".join(pieces[:-1])
        result.append(normalize_type(text))
    return tuple(result)


def parse_deobfuscated_cs(path: str | Path) -> list[ParsedCsClass]:
    classes: list[ParsedCsClass] = []
    stack: list[tuple[str, str | None]] = []
    pending_namespace: str | None = None
    pending_class: tuple[str, str, list[str]] | None = None
    current: ParsedCsClass | None = None

    with Path(path).open("r", encoding="utf-8", errors="ignore") as handle:
        for line in handle:
            stripped = line.rstrip("\r\n")
            compact = stripped.strip()

            if current is None:
                ns_match = NAMESPACE_RE.match(compact)
                if ns_match:
                    pending_namespace = ns_match.group(1)
                else:
                    class_match = CLASS_RE.match(compact)
                    if class_match:
                        namespace = ".".join(
                            value for kind, value in stack if kind == "namespace" and value
                        )
                        parent_parts = split_top_level((class_match.group(2) or "").strip())
                        pending_class = (namespace, class_match.group(1), parent_parts)
            else:
                method_match = METHOD_RE.match(stripped)
                if method_match:
                    current.method_names.append(method_match.group("name").strip())
                    current.signatures.append(
                        MethodSignature(
                            return_type=normalize_type(method_match.group("ret")),
                            param_types=parse_param_types(method_match.group("params")),
                        )
                    )

            for ch in stripped:
                if ch == "{":
                    if pending_namespace is not None:
                        stack.append(("namespace", pending_namespace))
                        pending_namespace = None
                    elif pending_class is not None:
                        namespace, name, parent_parts = pending_class
                        current = ParsedCsClass(
                            namespace=namespace,
                            name=name,
                            parent_parts=parent_parts,
                            method_names=[],
                            signatures=[],
                        )
                        stack.append(("class", name))
                        pending_class = None
                    else:
                        stack.append(("other", None))
                elif ch == "}":
                    if not stack:
                        continue
                    kind, _ = stack.pop()
                    if kind == "class":
                        if current is None:
                            raise ValueError("class parser stack underflow")
                        classes.append(current)
                        current = None
    return classes


def is_hash_name(name: str) -> bool:
    return bool(name) and bool(HASH_RE.fullmatch(name))


def is_semantic_source(name: str) -> bool:
    if not name or is_hash_name(name):
        return False
    if name.startswith("."):
        return False
    if "<" in name:
        return False
    return True


def is_interface_like_name(name: str) -> bool:
    return bool(name) and bool(INTERFACE_HINT_RE.search(name))


def iter_precise_classes(precise_dump: dict):
    for namespace, classes in precise_dump.get("namespaces", {}).items():
        for cls in classes:
            yield namespace, cls


def build_records(
    precise_dump: dict,
    name_mapping: dict,
    parsed_cs_classes: list[ParsedCsClass],
) -> tuple[list[ClassRecord], Counter[str]]:
    class_map = name_mapping.get("classes", {})
    method_map = name_mapping.get("methods", {})

    cs_occurrences: dict[tuple[str, str], list[ParsedCsClass]] = defaultdict(list)
    for cls in parsed_cs_classes:
        cs_occurrences[(cls.namespace, cls.name)].append(cls)

    occurrence_index: Counter[tuple[str, str]] = Counter()
    records: list[ClassRecord] = []
    validation = Counter()

    for namespace, precise_cls in iter_precise_classes(precise_dump):
        raw_name = precise_cls.get("name", "")
        semantic_name = class_map.get(raw_name, raw_name)
        raw_methods = list(precise_cls.get("methods") or [])
        effective_names = [
            method_map.get(f"{raw_name}::{method_name}", method_name)
            for method_name in raw_methods
        ]

        occ_key = (namespace, semantic_name)
        occ_index = occurrence_index[occ_key]
        try:
            parsed_cls = cs_occurrences[occ_key][occ_index]
        except IndexError as exc:
            raise ValueError(
                f"Missing parsed C# class occurrence for {namespace}::{semantic_name} #{occ_index}"
            ) from exc
        occurrence_index[occ_key] += 1

        if len(parsed_cls.method_names) != len(raw_methods):
            raise ValueError(
                f"Method count mismatch for {namespace}::{semantic_name}: "
                f"{len(raw_methods)} precise vs {len(parsed_cls.method_names)} C#"
            )

        if parsed_cls.method_names == effective_names:
            validation["method_name_matches"] += 1
        else:
            validation["method_name_mismatches"] += 1

        parent_decl = parsed_cls.parent_parts[0] if parsed_cls.parent_parts else ""
        interface_parts = parsed_cls.parent_parts[1:] if len(parsed_cls.parent_parts) > 1 else []
        interfaces = list(precise_cls.get("interfaces") or interface_parts or [])

        records.append(
            ClassRecord(
                class_id=len(records),
                namespace=namespace,
                raw_name=raw_name,
                semantic_name=semantic_name,
                raw_parent=precise_cls.get("parent", "") or "",
                semantic_parent_decl=parent_decl,
                interfaces=interfaces,
                raw_methods=raw_methods,
                effective_names=effective_names,
                signatures=list(parsed_cls.signatures),
            )
        )

    return records, validation


def resolve_parent(
    record: ClassRecord,
    records: list[ClassRecord],
    by_raw_name: dict[str, list[int]],
    by_ns_raw_name: dict[tuple[str, str], list[int]],
) -> tuple[int | None, str]:
    if not record.raw_parent:
        return None, "no_parent"

    all_candidates = [
        class_id
        for class_id in by_raw_name.get(record.raw_parent, [])
        if class_id != record.class_id
    ]
    if not all_candidates:
        return None, "missing"

    same_ns = [
        class_id
        for class_id in by_ns_raw_name.get((record.namespace, record.raw_parent), [])
        if class_id != record.class_id
    ]
    if len(same_ns) == 1:
        candidate = records[same_ns[0]]
        if not record.semantic_parent_decl or candidate.semantic_name == record.semantic_parent_decl:
            return same_ns[0], "same_namespace"

    if record.semantic_parent_decl:
        same_ns_sem = [
            class_id
            for class_id in same_ns
            if records[class_id].semantic_name == record.semantic_parent_decl
        ]
        if len(same_ns_sem) == 1:
            return same_ns_sem[0], "same_namespace_semantic"

        semantic_candidates = [
            class_id
            for class_id in all_candidates
            if records[class_id].semantic_name == record.semantic_parent_decl
        ]
        if len(semantic_candidates) == 1:
            return semantic_candidates[0], "semantic_parent_decl"
        if semantic_candidates:
            return None, "ambiguous_semantic_parent_decl"

    if len(all_candidates) == 1:
        return all_candidates[0], "global_unique"
    return None, "ambiguous"


def compute_depths(
    records: list[ClassRecord],
    parent_of: dict[int, int],
) -> tuple[dict[int, int], Counter[str]]:
    children: dict[int, list[int]] = defaultdict(list)
    for child_id, parent_id in parent_of.items():
        children[parent_id].append(child_id)

    roots = [record.class_id for record in records if record.class_id not in parent_of]
    depth: dict[int, int] = {root_id: 0 for root_id in roots}
    queue = deque(roots)
    while queue:
        current = queue.popleft()
        for child_id in children.get(current, []):
            if child_id in depth:
                continue
            depth[child_id] = depth[current] + 1
            queue.append(child_id)

    stats = Counter()
    if len(depth) != len(records):
        for record in records:
            if record.class_id not in depth:
                depth[record.class_id] = 0
                stats["cycle_or_unreachable"] += 1
    return depth, stats


def build_interface_signature_index(records: list[ClassRecord]) -> dict[MethodSignature, Counter[str]]:
    signature_to_names: dict[MethodSignature, Counter[str]] = defaultdict(Counter)
    for record in records:
        class_interface_like = is_interface_like_name(record.semantic_name)
        listed_interfaces = any(is_interface_like_name(name) for name in record.interfaces)
        for name, signature in zip(record.effective_names, record.signatures):
            if not is_semantic_source(name):
                continue
            explicit_interface = "." in name and is_interface_like_name(name.rsplit(".", 1)[0])
            if class_interface_like or listed_interfaces or explicit_interface:
                signature_to_names[signature][name] += 1
    return signature_to_names


def propagate(records: list[ClassRecord], parent_of: dict[int, int], depth: dict[int, int]):
    events: list[PropagationEvent] = []
    event_values: dict[str, set[str]] = defaultdict(set)
    event_depths: dict[str, int] = {}
    stats = Counter()

    ordered_records = sorted(records, key=lambda record: (depth[record.class_id], record.class_id))

    for record in ordered_records:
        parent_id = parent_of.get(record.class_id)
        if parent_id is None:
            continue
        parent = records[parent_id]
        slot_count = min(len(record.effective_names), len(parent.effective_names), len(record.signatures), len(parent.signatures))
        for slot in range(slot_count):
            target_name = record.effective_names[slot]
            source_name = parent.effective_names[slot]
            if not is_hash_name(target_name):
                continue
            if not is_semantic_source(source_name):
                continue
            if record.signatures[slot] != parent.signatures[slot]:
                stats["parent_signature_mismatch"] += 1
                continue

            record.effective_names[slot] = source_name
            key = f"{record.semantic_name}::{target_name}"
            event_values[key].add(source_name)
            event_depths.setdefault(key, depth[record.class_id])
            events.append(
                PropagationEvent(
                    key=key,
                    value=source_name,
                    depth=depth[record.class_id],
                    source_kind="parent",
                    target_class=record.semantic_name,
                    target_namespace=record.namespace,
                    parent_class=parent.semantic_name,
                    slot=slot,
                    signature=record.signatures[slot].display(),
                    target_hash=target_name,
                )
            )
            stats["parent_events"] += 1

    interface_index = build_interface_signature_index(records)
    stats["interface_signature_keys"] = len(interface_index)

    for record in ordered_records:
        for slot, (name, signature) in enumerate(zip(record.effective_names, record.signatures)):
            if not is_hash_name(name):
                continue
            candidates = interface_index.get(signature)
            if not candidates or len(candidates) != 1:
                continue
            propagated_name = next(iter(candidates))
            if not is_semantic_source(propagated_name):
                continue

            record.effective_names[slot] = propagated_name
            key = f"{record.semantic_name}::{name}"
            event_values[key].add(propagated_name)
            event_depths.setdefault(key, depth[record.class_id])
            events.append(
                PropagationEvent(
                    key=key,
                    value=propagated_name,
                    depth=depth[record.class_id],
                    source_kind="interface",
                    target_class=record.semantic_name,
                    target_namespace=record.namespace,
                    parent_class=None,
                    slot=slot,
                    signature=signature.display(),
                    target_hash=name,
                )
            )
            stats["interface_events"] += 1

    conflicts = {key: values for key, values in event_values.items() if len(values) > 1}
    output = {
        key: next(iter(values))
        for key, values in sorted(event_values.items())
        if len(values) == 1
    }

    stats["conflicting_keys"] = len(conflicts)
    stats["emitted_keys"] = len(output)
    stats["total_events"] = len(events)

    depth_counts = Counter()
    emitted_kind_counts = Counter()
    sample_events: list[PropagationEvent] = []
    seen_sample_keys: set[str] = set()
    for event in events:
        if event.key not in output:
            continue
        if output[event.key] != event.value:
            continue
        depth_counts[event.depth] += 1
        emitted_kind_counts[event.source_kind] += 1
        if event.key not in seen_sample_keys and len(sample_events) < 20:
            sample_events.append(event)
            seen_sample_keys.add(event.key)

    return output, conflicts, stats, depth_counts, emitted_kind_counts, sample_events


def ensure_parent_dir(path: str | Path) -> None:
    parent = Path(path).parent
    if parent:
        parent.mkdir(parents=True, exist_ok=True)


def print_report(
    records: list[ClassRecord],
    validation: Counter[str],
    parent_reasons: Counter[str],
    unresolved_parents: Counter[str],
    depth: dict[int, int],
    depth_stats: Counter[str],
    stats: Counter[str],
    depth_counts: Counter[int],
    emitted_kind_counts: Counter[str],
    sample_events: list[PropagationEvent],
) -> None:
    hierarchy_distribution = Counter(depth.values())

    print("=== VTable Propagation Report ===")
    print(f"Classes loaded: {len(records):,}")
    print(f"Method-name alignment checks passed: {validation.get('method_name_matches', 0):,}")
    if validation.get("method_name_mismatches"):
        print(f"Method-name alignment mismatches: {validation['method_name_mismatches']:,}")

    print("\nParent resolution:")
    for reason, count in sorted(parent_reasons.items()):
        print(f"  {reason}: {count:,}")
    for reason, count in sorted(unresolved_parents.items()):
        print(f"  unresolved_{reason}: {count:,}")

    print("\nHierarchy depth distribution:")
    for level in sorted(hierarchy_distribution):
        print(f"  depth {level:2d}: {hierarchy_distribution[level]:,}")
    if depth_stats.get("cycle_or_unreachable"):
        print(f"  cycle_or_unreachable: {depth_stats['cycle_or_unreachable']:,}")

    print("\nPropagation by depth:")
    for level in sorted(depth_counts):
        print(f"  depth {level:2d}: {depth_counts[level]:,}")

    print("\nPropagation summary:")
    print(f"  parent_events: {stats.get('parent_events', 0):,}")
    print(f"  interface_events: {stats.get('interface_events', 0):,}")
    print(f"  interface_signature_keys: {stats.get('interface_signature_keys', 0):,}")
    print(f"  emitted_parent_keys: {emitted_kind_counts.get('parent', 0):,}")
    print(f"  emitted_interface_keys: {emitted_kind_counts.get('interface', 0):,}")
    print(f"  conflicting_keys_skipped: {stats.get('conflicting_keys', 0):,}")
    print(f"  total_events: {stats.get('total_events', 0):,}")
    print(f"  emitted_keys: {stats.get('emitted_keys', 0):,}")

    print("\n20 samples:")
    for event in sample_events:
        parent_text = event.parent_class or "interface"
        print(
            f"  depth {event.depth:2d} [{event.source_kind}] "
            f"{event.key} -> {event.value} "
            f"(source={parent_text}, slot={event.slot}, sig={event.signature})"
        )


def main() -> None:
    args = parse_args()

    precise_dump = load_json(args.precise)
    name_mapping = load_json(args.mapping)
    parsed_cs_classes = parse_deobfuscated_cs(args.deobf_cs)

    records, validation = build_records(precise_dump, name_mapping, parsed_cs_classes)

    by_raw_name: dict[str, list[int]] = defaultdict(list)
    by_ns_raw_name: dict[tuple[str, str], list[int]] = defaultdict(list)
    for record in records:
        by_raw_name[record.raw_name].append(record.class_id)
        by_ns_raw_name[(record.namespace, record.raw_name)].append(record.class_id)

    parent_of: dict[int, int] = {}
    parent_reasons = Counter()
    unresolved_parents = Counter()
    for record in records:
        parent_id, reason = resolve_parent(record, records, by_raw_name, by_ns_raw_name)
        if parent_id is None:
            if reason != "no_parent":
                unresolved_parents[reason] += 1
            continue
        parent_of[record.class_id] = parent_id
        parent_reasons[reason] += 1

    depth, depth_stats = compute_depths(records, parent_of)
    output, conflicts, stats, depth_counts, emitted_kind_counts, sample_events = propagate(
        records,
        parent_of,
        depth,
    )

    ensure_parent_dir(args.output)
    with Path(args.output).open("w", encoding="utf-8") as handle:
        json.dump(output, handle, indent=2, ensure_ascii=False, sort_keys=True)

    print_report(
        records=records,
        validation=validation,
        parent_reasons=parent_reasons,
        unresolved_parents=unresolved_parents,
        depth=depth,
        depth_stats=depth_stats,
        stats=stats,
        depth_counts=depth_counts,
        emitted_kind_counts=emitted_kind_counts,
        sample_events=sample_events,
    )
    print(f"\nOutput: {Path(args.output).resolve()}")
    if conflicts:
        print(f"Skipped {len(conflicts):,} conflicting keys.")


if __name__ == "__main__":
    main()
