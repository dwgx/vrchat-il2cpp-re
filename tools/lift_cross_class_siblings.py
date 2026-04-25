#!/usr/bin/env python3
"""Lift semantic method names across structurally similar sibling/impl classes."""

from __future__ import annotations

import argparse
import bisect
import json
import os
import re
import sys
from collections import Counter, defaultdict
from dataclasses import dataclass
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$")
OBF_NAME_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]+$")
HEX_SUFFIX_RE = re.compile(r"_(?:[0-9A-F]{4,})$")
CLASS_START_RE = re.compile(r"^\s*(?:public\s+)?class\s+([^\s:{]+)(?:\s*:\s*([^{]+))?\s*$")
METHOD_LINE_RE = re.compile(
    r"^\s*(?P<ret>.+?)\s+(?P<name>[^\s(]+)\((?P<params>.*)\)\s*;\s*(?://\s*(?P<va>0x[0-9A-Fa-f]+))?\s*$"
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

BOILERPLATE_NAMES = frozenset(
    {
        ".ctor",
        ".cctor",
        "Finalize",
        "ToString",
        "GetHashCode",
        "Equals",
        "GetType",
        "MemberwiseClone",
        "Dispose",
        "DisposeAsync",
        "MoveNext",
        "Reset",
        "Current",
        "get_Current",
        "set_Current",
        "GetEnumerator",
        "System.Collections.IEnumerator.Reset",
        "System.IDisposable.Dispose",
        "Invoke",
        "BeginInvoke",
        "EndInvoke",
    }
)

RULE_PRECEDENCE = {
    "prefix_sibling": 3,
    "prefix_impl": 2,
    "same_parent_similar": 1,
}


@dataclass(frozen=True, slots=True)
class MethodSig:
    ret_type: str
    params: tuple[str, ...]

    @property
    def key(self) -> tuple[str, tuple[str, ...]]:
        return (self.ret_type, self.params)


@dataclass(slots=True)
class ClassRecord:
    index: int
    namespace: str
    semantic_name: str
    raw_name: str
    parent: str
    methods: list[str]
    raw_methods: list[str]
    signatures: list[MethodSig]
    resolved_names: list[str | None]
    liftable_count: int

    @property
    def method_count(self) -> int:
        return len(self.methods)


@dataclass(frozen=True, slots=True)
class Proposal:
    weak_key: str
    propagated_name: str
    rule: str
    strong_class: str
    weak_class: str
    method_index: int


def parse_args() -> argparse.Namespace:
    base = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--precise", default=str(base / "data" / "precise_dump.json"))
    parser.add_argument("--deobf-json", default=str(base / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--deobf-cs", default=str(base / "output" / "deobfuscated_dump.cs"))
    parser.add_argument("--mapping", default=str(base / "output" / "name_mapping.json"))
    parser.add_argument(
        "--output",
        default=str(base / "output" / "cross_class_propagation.json"),
    )
    parser.add_argument(
        "--parent-tolerance",
        type=float,
        default=0.10,
        help="Method-count tolerance for same-parent candidate pairs.",
    )
    parser.add_argument(
        "--max-parent-candidates",
        type=int,
        default=4,
        help="Maximum same-parent strong candidates to keep per weak class.",
    )
    parser.add_argument(
        "--prefix-min-anchors",
        type=int,
        default=0,
        help="Minimum exact semantic slot anchors required for prefix sibling/impl pairs.",
    )
    parser.add_argument(
        "--parent-min-anchors",
        type=int,
        default=5,
        help="Minimum exact semantic slot anchors required for same-parent pairs.",
    )
    parser.add_argument(
        "--anchor-distance",
        type=int,
        default=12,
        help="Only propagate slots within this distance of an exact semantic anchor slot.",
    )
    parser.add_argument(
        "--sample-count",
        type=int,
        default=20,
        help="How many propagated mappings to print as a sample.",
    )
    parser.add_argument(
        "--top-pairs",
        type=int,
        default=20,
        help="How many strong->weak pair counts to print.",
    )
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


def is_hash_method(name: str | None) -> bool:
    return isinstance(name, str) and bool(HASH_METHOD_RE.fullmatch(name))


def is_obfuscated_name(name: str | None) -> bool:
    return isinstance(name, str) and bool(OBF_NAME_RE.fullmatch(name))


def is_semantic_name(name: str | None) -> bool:
    return (
        isinstance(name, str)
        and name != ""
        and not is_hash_method(name)
        and not is_obfuscated_name(name)
    )


def is_boilerplate(name: str | None) -> bool:
    return bool(name) and (
        name in BOILERPLATE_NAMES
        or name.startswith("<")
        or name.startswith("op_")
        or name.startswith("add_")
        or name.startswith("remove_")
    )


def is_liftable_name(name: str | None) -> bool:
    return is_semantic_name(name) and not is_boilerplate(name)


def normalized_family_base(name: str) -> str:
    base = HEX_SUFFIX_RE.sub("", name)
    for marker in ("Sibling", "Impl"):
        pos = base.find(marker)
        if pos > 0:
            base = base[:pos]
            break
    return base.rstrip("_")


def is_weak_class_name(name: str) -> bool:
    return (
        "Sibling" in name
        or "Impl" in name
        or bool(HEX_SUFFIX_RE.search(name))
    )


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

            brace_depth += stripped.count("{")
            method_match = METHOD_LINE_RE.match(stripped)
            if method_match and current_methods is not None:
                current_methods.append(
                    MethodSig(
                        normalize_type(method_match.group("ret")),
                        parse_param_types(method_match.group("params")),
                    )
                )
            brace_depth -= stripped.count("}")
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

    aligned = []
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


def resolve_semantic_name(
    method_map: dict[str, str],
    semantic_class: str,
    raw_class: str,
    raw_method: str,
    current_name: str,
) -> str | None:
    if is_semantic_name(current_name):
        return current_name
    for key in (
        f"{semantic_class}::{raw_method}",
        f"{raw_class}::{raw_method}",
    ):
        mapped = method_map.get(key)
        if is_semantic_name(mapped):
            return mapped
    return None


def build_class_records(
    raw_dump: dict,
    deobf_dump: dict,
    method_map: dict[str, str],
    signature_lists: list[list[MethodSig]],
) -> list[ClassRecord]:
    raw_classes = flatten_classes(raw_dump)
    deobf_classes = flatten_classes(deobf_dump)
    if len(raw_classes) != len(deobf_classes):
        raise ValueError(f"class count mismatch: {len(raw_classes)} != {len(deobf_classes)}")

    records: list[ClassRecord] = []
    for index, (((raw_ns, raw_cls), (cur_ns, cur_cls)), sigs) in enumerate(
        zip(zip(raw_classes, deobf_classes), signature_lists)
    ):
        if raw_ns != cur_ns:
            raise ValueError(
                f"namespace mismatch at class index {index}: {raw_ns!r} != {cur_ns!r}"
            )

        raw_methods = list(raw_cls.get("methods") or [])
        cur_methods = list(cur_cls.get("methods") or [])
        if len(raw_methods) != len(cur_methods):
            raise ValueError(
                f"method count mismatch at class index {index}: "
                f"{len(raw_methods)} != {len(cur_methods)}"
            )

        resolved_names = [
            resolve_semantic_name(
                method_map,
                cur_cls.get("name", ""),
                raw_cls.get("name", ""),
                raw_method,
                cur_name,
            )
            for raw_method, cur_name in zip(raw_methods, cur_methods)
        ]

        liftable_count = sum(1 for name in resolved_names if is_liftable_name(name))
        records.append(
            ClassRecord(
                index=index,
                namespace=cur_ns,
                semantic_name=cur_cls.get("name", ""),
                raw_name=raw_cls.get("name", ""),
                parent=cur_cls.get("parent", "") or "",
                methods=cur_methods,
                raw_methods=raw_methods,
                signatures=sigs,
                resolved_names=resolved_names,
                liftable_count=liftable_count,
            )
        )
    return records


def add_pair(
    pair_rules: dict[tuple[int, int], set[str]],
    strong: ClassRecord,
    weak: ClassRecord,
    rule: str,
) -> None:
    if strong.index == weak.index:
        return
    if strong.liftable_count <= weak.liftable_count:
        return
    pair_rules[(strong.index, weak.index)].add(rule)


def build_candidate_pairs(
    classes: list[ClassRecord],
    parent_tolerance: float,
    max_parent_candidates: int,
) -> dict[tuple[int, int], set[str]]:
    pair_rules: dict[tuple[int, int], set[str]] = defaultdict(set)
    by_ns_name: dict[tuple[str, str], ClassRecord] = {}
    for cls in classes:
        by_ns_name[(cls.namespace, cls.semantic_name)] = cls

    for weak in classes:
        for marker, rule in (("Sibling", "prefix_sibling"), ("Impl", "prefix_impl")):
            pos = weak.semantic_name.find(marker)
            if pos <= 0:
                continue
            base = weak.semantic_name[:pos]
            strong = by_ns_name.get((weak.namespace, base))
            if strong and weak.semantic_name.startswith(base + marker):
                add_pair(pair_rules, strong, weak, rule)

    parent_groups: dict[tuple[str, str], list[ClassRecord]] = defaultdict(list)
    for cls in classes:
        if cls.parent:
            parent_groups[(cls.namespace, cls.parent)].append(cls)

    for members in parent_groups.values():
        if len(members) < 2:
            continue
        members = sorted(members, key=lambda item: (item.method_count, item.semantic_name))
        counts = [item.method_count for item in members]
        for weak in members:
            weak_base = normalized_family_base(weak.semantic_name)
            if not weak_base or not is_weak_class_name(weak.semantic_name):
                continue
            low = bisect.bisect_left(counts, weak.method_count * (1.0 - parent_tolerance))
            high = bisect.bisect_right(counts, weak.method_count * (1.0 + parent_tolerance))
            candidates: list[ClassRecord] = []
            for idx in range(low, high):
                strong = members[idx]
                if strong.index == weak.index:
                    continue
                if strong.liftable_count <= weak.liftable_count:
                    continue
                if strong.semantic_name == weak.semantic_name:
                    continue
                if strong.semantic_name.startswith("<") or weak.semantic_name.startswith("<"):
                    continue
                if normalized_family_base(strong.semantic_name) != weak_base:
                    continue
                candidates.append(strong)
            if not candidates:
                continue
            candidates.sort(
                key=lambda item: (
                    -item.liftable_count,
                    abs(item.method_count - weak.method_count),
                    item.semantic_name,
                )
            )
            for strong in candidates[:max_parent_candidates]:
                add_pair(pair_rules, strong, weak, "same_parent_similar")

    return pair_rules


def build_proposals(
    classes: list[ClassRecord],
    pair_rules: dict[tuple[int, int], set[str]],
    prefix_min_anchors: int,
    parent_min_anchors: int,
    anchor_distance: int,
) -> tuple[dict[str, list[Proposal]], Counter, dict[tuple[int, int], int], Counter]:
    by_index = {cls.index: cls for cls in classes}
    proposals: dict[str, list[Proposal]] = defaultdict(list)
    rule_proposal_counts: Counter = Counter()
    pair_proposal_counts: dict[tuple[int, int], int] = {}
    eligible_pair_counts: Counter = Counter()

    for (strong_index, weak_index), rules in pair_rules.items():
        strong = by_index[strong_index]
        weak = by_index[weak_index]
        anchor_indices = [
            method_index
            for method_index in range(min(strong.method_count, weak.method_count))
            if strong.methods[method_index] == weak.methods[method_index]
            and is_liftable_name(strong.methods[method_index])
        ]
        if anchor_indices:
            anchor_indices.sort()

        usable_rules = []
        for rule in sorted(rules):
            min_anchors = (
                prefix_min_anchors
                if rule in {"prefix_sibling", "prefix_impl"}
                else parent_min_anchors
            )
            if len(anchor_indices) >= min_anchors:
                usable_rules.append(rule)
                eligible_pair_counts[rule] += 1
        if not usable_rules:
            pair_proposal_counts[(strong_index, weak_index)] = 0
            continue

        pair_count = 0
        for method_index in range(min(strong.method_count, weak.method_count)):
            weak_name = weak.methods[method_index]
            if not is_hash_method(weak_name):
                continue
            if is_semantic_name(weak.resolved_names[method_index]):
                continue

            propagated_name = strong.resolved_names[method_index]
            if not is_liftable_name(propagated_name):
                continue

            if strong.signatures[method_index].key != weak.signatures[method_index].key:
                continue

            weak_key = f"{weak.semantic_name}::{weak_name}"
            added = False
            for rule in usable_rules:
                if rule == "same_parent_similar":
                    if anchor_indices:
                        anchor_pos = bisect.bisect_left(anchor_indices, method_index)
                        distances = []
                        if anchor_pos < len(anchor_indices):
                            distances.append(abs(anchor_indices[anchor_pos] - method_index))
                        if anchor_pos > 0:
                            distances.append(abs(anchor_indices[anchor_pos - 1] - method_index))
                        if not distances or min(distances) > anchor_distance:
                            continue
                    else:
                        continue
                proposals[weak_key].append(
                    Proposal(
                        weak_key=weak_key,
                        propagated_name=propagated_name,
                        rule=rule,
                        strong_class=strong.semantic_name,
                        weak_class=weak.semantic_name,
                        method_index=method_index,
                    )
                )
                rule_proposal_counts[rule] += 1
                added = True
            if added:
                pair_count += 1
        pair_proposal_counts[(strong_index, weak_index)] = pair_count

    return proposals, rule_proposal_counts, pair_proposal_counts, eligible_pair_counts


def resolve_proposals(
    proposals: dict[str, list[Proposal]],
) -> tuple[dict[str, str], dict[str, list[Proposal]], int]:
    resolved: dict[str, str] = {}
    accepted_details: dict[str, list[Proposal]] = {}
    conflict_count = 0

    for weak_key, slot_proposals in proposals.items():
        top_precedence = max(RULE_PRECEDENCE[item.rule] for item in slot_proposals)
        filtered = [
            item
            for item in slot_proposals
            if RULE_PRECEDENCE[item.rule] == top_precedence
        ]
        names = {item.propagated_name for item in filtered}
        if len(names) != 1:
            conflict_count += 1
            continue
        resolved_name = next(iter(names))
        resolved[weak_key] = resolved_name
        accepted_details[weak_key] = filtered

    return dict(sorted(resolved.items())), accepted_details, conflict_count


def main() -> None:
    args = parse_args()
    raw_dump = load_json(args.precise)
    deobf_dump = load_json(args.deobf_json)
    name_mapping = load_json(args.mapping)
    method_map = name_mapping.get("methods", {}) if isinstance(name_mapping, dict) else {}

    flat_deobf = flatten_classes(deobf_dump)
    cs_classes = parse_deobf_cs_classes(args.deobf_cs)
    signature_lists = align_signature_lists(flat_deobf, cs_classes)
    classes = build_class_records(raw_dump, deobf_dump, method_map, signature_lists)

    pair_rules = build_candidate_pairs(
        classes,
        parent_tolerance=args.parent_tolerance,
        max_parent_candidates=args.max_parent_candidates,
    )
    proposals, rule_proposal_counts, pair_proposal_counts, eligible_pair_counts = build_proposals(
        classes,
        pair_rules,
        prefix_min_anchors=args.prefix_min_anchors,
        parent_min_anchors=args.parent_min_anchors,
        anchor_distance=args.anchor_distance,
    )
    resolved, accepted_details, conflict_count = resolve_proposals(proposals)

    ensure_parent_dir(args.output)
    with Path(args.output).open("w", encoding="utf-8") as handle:
        json.dump(resolved, handle, indent=2, ensure_ascii=False)

    by_index = {cls.index: cls for cls in classes}
    pair_rule_counts = Counter()
    for rules in pair_rules.values():
        for rule in rules:
            pair_rule_counts[rule] += 1

    accepted_pair_counts: Counter = Counter()
    for accepted in accepted_details.values():
        for proposal in accepted:
            accepted_pair_counts[(proposal.strong_class, proposal.weak_class)] += 1

    top_pairs = sorted(
        accepted_pair_counts.items(),
        key=lambda item: (-item[1], item[0][0], item[0][1]),
    )[: args.top_pairs]

    samples = []
    for weak_key, propagated_name in resolved.items():
        first = sorted(
            accepted_details[weak_key],
            key=lambda item: (-RULE_PRECEDENCE[item.rule], item.strong_class, item.method_index),
        )[0]
        samples.append(
            (
                accepted_pair_counts[(first.strong_class, first.weak_class)],
                first.rule,
                first.strong_class,
                weak_key,
                propagated_name,
            )
        )
    samples.sort(key=lambda item: (-item[0], -RULE_PRECEDENCE[item[1]], item[3]))
    samples = samples[: args.sample_count]

    print(f"Candidate pair counts:")
    for rule_name in ("prefix_sibling", "prefix_impl", "same_parent_similar"):
        print(f"  {rule_name}: {pair_rule_counts[rule_name]}")
    print(f"  unique_total: {len(pair_rules)}")
    print("Anchor-qualified pair counts:")
    for rule_name in ("prefix_sibling", "prefix_impl", "same_parent_similar"):
        print(f"  {rule_name}: {eligible_pair_counts[rule_name]}")
    print(f"Proposal count before conflict resolution: {sum(rule_proposal_counts.values())}")
    print(f"Conflicting weak slots skipped: {conflict_count}")
    print(f"Propagation count written: {len(resolved)}")
    print()

    print(f"Top {min(args.top_pairs, len(top_pairs))} pairs by accepted propagations:")
    for (strong_name, weak_name), count in top_pairs:
        print(f"  {strong_name} -> {weak_name}: {count} accepted")
    if not top_pairs:
        print("  (none)")
    print()

    print(f"Sample top {min(args.sample_count, len(samples))}:")
    for pair_count, rule_name, strong_name, weak_key, propagated_name in samples:
        print(
            f"  [{pair_count}] {rule_name} | {strong_name} -> {weak_key} = {propagated_name}"
        )
    if not samples:
        print("  (none)")


if __name__ == "__main__":
    main()
