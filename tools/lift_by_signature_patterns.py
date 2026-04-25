#!/usr/bin/env python3
"""Predict semantic names for hash methods using structural signature patterns."""

from __future__ import annotations

import argparse
import json
import os
import re
import sys
from collections import Counter, defaultdict


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$")
OBF_NAME_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]+$")
STRONG_CLASS_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$")

LIFECYCLE_ORDER = [
    "Awake",
    "OnEnable",
    "Start",
    "FixedUpdate",
    "Update",
    "LateUpdate",
    "OnDisable",
    "OnDestroy",
]

MONO_BASES = {
    "MonoBehaviour",
    "Behaviour",
    "Component",
    "UIBehaviour",
    "Selectable",
    "Graphic",
    "MaskableGraphic",
    "BaseMeshEffect",
}

BASE_PARENT_SKIP = {"Object", "MonoBehaviour", "Behaviour", "Component"}

ACCESSOR_PROP_BLACKLIST = {
    "name",
    "hideFlags",
    "gameObject",
    "transform",
    "enabled",
    "isActiveAndEnabled",
    "useGUILayout",
    "destroyCancellationToken",
}


def parse_args():
    parser = argparse.ArgumentParser(
        description="Predict semantic method names from strong structural patterns."
    )
    parser.add_argument("--precise", default="data/precise_dump.json")
    parser.add_argument("--mapping", default="output/name_mapping.json")
    parser.add_argument("--deobf", default="output/deobfuscated_dump.json")
    parser.add_argument(
        "--output",
        default="output/signature_pattern_predictions.json",
    )
    parser.add_argument(
        "--min-confidence",
        type=float,
        default=0.6,
        help="Only emit predictions at or above this confidence threshold.",
    )
    return parser.parse_args()


def load_json(path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path):
    parent = os.path.dirname(path)
    if parent:
        os.makedirs(parent, exist_ok=True)


def flatten_classes(dump):
    return [
        (namespace, cls)
        for namespace, classes in dump.get("namespaces", {}).items()
        for cls in classes
    ]


def pair_classes(raw_dump, deobf_dump):
    raw_items = flatten_classes(raw_dump)
    deobf_items = flatten_classes(deobf_dump)
    if len(raw_items) != len(deobf_items):
        raise ValueError(
            f"class count mismatch: {len(raw_items)} != {len(deobf_items)}"
        )

    for index, ((raw_ns, raw_cls), (deobf_ns, deobf_cls)) in enumerate(
        zip(raw_items, deobf_items)
    ):
        if raw_ns != deobf_ns:
            raise ValueError(
                f"namespace mismatch at class index {index}: {raw_ns!r} != {deobf_ns!r}"
            )

        raw_methods = raw_cls.get("methods") or []
        deobf_methods = deobf_cls.get("methods") or []
        if len(raw_methods) != len(deobf_methods):
            raise ValueError(
                f"method count mismatch at class index {index}: "
                f"{len(raw_methods)} != {len(deobf_methods)}"
            )

        yield raw_ns, raw_cls, deobf_cls


def is_hash_method(name):
    return isinstance(name, str) and bool(HASH_METHOD_RE.fullmatch(name))


def is_obfuscated_name(name):
    return isinstance(name, str) and bool(OBF_NAME_RE.fullmatch(name))


def is_semantic_name(name):
    return (
        isinstance(name, str)
        and name not in {"", ".ctor", ".cctor"}
        and not is_hash_method(name)
        and not is_obfuscated_name(name)
    )


def is_strong_class_name(name):
    return isinstance(name, str) and not STRONG_CLASS_SUFFIX_RE.search(name)


class ClassResolver:
    def __init__(self, deobf_dump):
        self.by_name = defaultdict(list)
        for namespace, cls in flatten_classes(deobf_dump):
            self.by_name[cls.get("name", "")].append((namespace, cls))
        self._mono_cache = {}

    def resolve_parent(self, namespace, cls):
        parent_name = cls.get("parent", "")
        if not parent_name:
            return None

        same_namespace = [
            item for item in self.by_name.get(parent_name, []) if item[0] == namespace
        ]
        if len(same_namespace) == 1:
            return same_namespace[0]

        all_matches = self.by_name.get(parent_name, [])
        if len(all_matches) == 1:
            return all_matches[0]

        return None

    def is_mono_descendant(self, namespace, cls):
        key = (namespace, cls.get("name", ""))
        cached = self._mono_cache.get(key)
        if cached is not None:
            return cached

        seen = set()
        current = (namespace, cls)
        while current:
            current_ns, current_cls = current
            parent_name = current_cls.get("parent", "")
            if parent_name in MONO_BASES:
                self._mono_cache[key] = True
                return True
            if not parent_name or parent_name in seen:
                self._mono_cache[key] = False
                return False
            seen.add(parent_name)
            current = self.resolve_parent(current_ns, current_cls)

        self._mono_cache[key] = False
        return False


def mapping_value(name_mapping, raw_class_name, semantic_class_name, raw_method_name):
    methods = name_mapping.get("methods", {})
    for key in (
        f"{raw_class_name}::{raw_method_name}",
        f"{semantic_class_name}::{raw_method_name}",
    ):
        if key in methods:
            return methods[key]
    return None


def add_candidate(candidates, name, confidence, rule, reason):
    if confidence < 0.6:
        return
    candidates.append(
        {
            "name": name,
            "confidence": confidence,
            "rule": rule,
            "reason": reason,
        }
    )


def rule_mono_lifecycle_between_known(candidates, named_methods, is_mono, prev_method, next_method):
    if not is_mono:
        return
    if prev_method not in LIFECYCLE_ORDER or next_method not in LIFECYCLE_ORDER:
        return

    prev_index = LIFECYCLE_ORDER.index(prev_method)
    next_index = LIFECYCLE_ORDER.index(next_method)
    if next_index - prev_index != 2:
        return

    predicted = LIFECYCLE_ORDER[prev_index + 1]
    if predicted in named_methods:
        return

    add_candidate(
        candidates,
        predicted,
        0.96,
        "mono_lifecycle_between_known",
        f"{prev_method} ... {next_method} gap on MonoBehaviour descendant",
    )


def rule_mono_lifecycle_adjacent_unique(
    candidates, named_methods, is_mono, prev_method, next_method
):
    if not is_mono:
        return

    options = []

    if prev_method == "Awake" and "Start" not in named_methods:
        options.append("Start")
    if prev_method == "Start" and "Update" not in named_methods:
        options.append("Update")
    if prev_method == "Update" and "LateUpdate" not in named_methods:
        options.append("LateUpdate")
    if prev_method == "OnEnable" and "OnDisable" not in named_methods:
        options.append("OnDisable")
    if prev_method == "OnDisable" and "OnDestroy" not in named_methods:
        options.append("OnDestroy")

    if next_method == "Start" and "Awake" not in named_methods:
        options.append("Awake")
    if next_method == "Update" and "Start" not in named_methods:
        options.append("Start")
    if next_method == "LateUpdate" and "Update" not in named_methods:
        options.append("Update")
    if next_method == "OnDisable" and "OnEnable" not in named_methods:
        options.append("OnEnable")
    if next_method == "OnDestroy" and "OnDisable" not in named_methods:
        options.append("OnDisable")

    unique = sorted(set(options))
    if len(unique) != 1:
        return

    predicted = unique[0]
    add_candidate(
        candidates,
        predicted,
        0.64,
        "mono_lifecycle_adjacent_unique",
        f"adjacent to {prev_method or '?'} / {next_method or '?'} on MonoBehaviour descendant",
    )


def rule_accessor_adjacent_pair(
    candidates, named_methods, fields, hash_count, prev_method, next_method
):
    if hash_count > 10:
        return

    props = []
    for near in (prev_method, next_method):
        if not isinstance(near, str):
            continue
        if near.startswith("get_"):
            prop = near[4:]
            predicted = f"set_{prop}"
        elif near.startswith("set_"):
            prop = near[4:]
            predicted = f"get_{prop}"
        else:
            continue

        if prop in ACCESSOR_PROP_BLACKLIST:
            continue
        if predicted in named_methods:
            continue
        props.append((prop, predicted, near))

    unique = {}
    for prop, predicted, near in props:
        unique[predicted] = (prop, near)
    if len(unique) != 1:
        return

    predicted, (prop, near) = next(iter(unique.items()))
    field_match = prop in fields or f"_{prop}" in fields
    confidence = 0.76 if field_match else 0.72
    add_candidate(
        candidates,
        predicted,
        confidence,
        "accessor_adjacent_pair",
        f"missing accessor pair beside {near} in low-hash class",
    )


def rule_parent_vtable_slot(
    candidates,
    resolver,
    namespace,
    cls,
    method_index,
    named_methods,
    prev_method,
    next_method,
):
    parent_item = resolver.resolve_parent(namespace, cls)
    if not parent_item:
        return

    parent_name = parent_item[1].get("name", "")
    if parent_name in BASE_PARENT_SKIP:
        return

    parent_methods = parent_item[1].get("methods") or []
    if method_index >= len(parent_methods):
        return

    predicted = parent_methods[method_index]
    if not is_semantic_name(predicted):
        return
    if predicted in named_methods:
        return

    anchor = False
    if method_index > 0 and method_index - 1 < len(parent_methods):
        parent_prev = parent_methods[method_index - 1]
        if (
            prev_method == parent_prev
            and is_semantic_name(prev_method)
            and is_semantic_name(parent_prev)
        ):
            anchor = True
    if method_index + 1 < len(parent_methods):
        parent_next = parent_methods[method_index + 1]
        if (
            next_method == parent_next
            and is_semantic_name(next_method)
            and is_semantic_name(parent_next)
        ):
            anchor = True

    confidence = 0.88 if anchor else 0.80
    anchor_suffix = " with adjacent slot anchor" if anchor else ""
    add_candidate(
        candidates,
        predicted,
        confidence,
        "parent_vtable_slot",
        f"matches direct parent slot {parent_name}::{predicted}{anchor_suffix}",
    )


def choose_prediction(candidates, min_confidence):
    if not candidates:
        return None

    grouped = {}
    for candidate in candidates:
        bucket = grouped.setdefault(
            candidate["name"],
            {
                "name": candidate["name"],
                "confidence": candidate["confidence"],
                "rules": [candidate["rule"]],
                "reasons": [candidate["reason"]],
                "primary_rule": candidate["rule"],
                "primary_reason": candidate["reason"],
            },
        )
        if candidate["confidence"] > bucket["confidence"]:
            bucket["confidence"] = candidate["confidence"]
            bucket["primary_rule"] = candidate["rule"]
            bucket["primary_reason"] = candidate["reason"]
        elif candidate["confidence"] == bucket["confidence"]:
            if candidate["rule"] < bucket["primary_rule"]:
                bucket["primary_rule"] = candidate["rule"]
                bucket["primary_reason"] = candidate["reason"]
        if candidate["rule"] not in bucket["rules"]:
            bucket["rules"].append(candidate["rule"])
        if candidate["reason"] not in bucket["reasons"]:
            bucket["reasons"].append(candidate["reason"])

    merged = []
    for bucket in grouped.values():
        if len(bucket["rules"]) > 1:
            bucket["confidence"] = min(
                0.98, round(bucket["confidence"] + (0.03 * (len(bucket["rules"]) - 1)), 2)
            )
        else:
            bucket["confidence"] = round(bucket["confidence"], 2)
        merged.append(bucket)

    merged.sort(key=lambda item: (-item["confidence"], item["name"]))
    best = merged[0]
    if best["confidence"] < min_confidence:
        return None
    if len(merged) > 1 and (best["confidence"] - merged[1]["confidence"]) < 0.08:
        return None

    reason = best["primary_reason"]
    if len(best["rules"]) > 1:
        extras = [rule for rule in best["rules"] if rule != best["primary_rule"]]
        reason = f"{reason}; corroborated by {', '.join(sorted(extras))}"

    return {
        "name": best["name"],
        "confidence": best["confidence"],
        "reason": reason,
        "rule": best["primary_rule"],
    }


def main():
    args = parse_args()
    raw_dump = load_json(args.precise)
    name_mapping = load_json(args.mapping)
    deobf_dump = load_json(args.deobf)

    resolver = ClassResolver(deobf_dump)
    predictions = {}
    rule_counts = Counter()
    confidence_counts = Counter()
    samples = []

    skipped_non_strong = 0
    skipped_named_in_mapping = 0
    examined_hash_methods = 0

    for namespace, raw_cls, deobf_cls in pair_classes(raw_dump, deobf_dump):
        semantic_class_name = deobf_cls.get("name", "")
        raw_class_name = raw_cls.get("name", "")
        if not is_strong_class_name(semantic_class_name):
            skipped_non_strong += sum(
                1 for name in deobf_cls.get("methods", []) if is_hash_method(name)
            )
            continue

        methods = deobf_cls.get("methods") or []
        raw_methods = raw_cls.get("methods") or []
        named_methods = {name for name in methods if isinstance(name, str)}
        fields = set(deobf_cls.get("fields") or [])
        hash_count = sum(1 for method_name in methods if is_hash_method(method_name))
        is_mono = resolver.is_mono_descendant(namespace, deobf_cls)

        for method_index, method_name in enumerate(methods):
            if not is_hash_method(method_name):
                continue

            examined_hash_methods += 1
            raw_method_name = raw_methods[method_index]
            mapped_name = mapping_value(
                name_mapping,
                raw_class_name,
                semantic_class_name,
                raw_method_name,
            )
            if mapped_name and is_semantic_name(mapped_name):
                skipped_named_in_mapping += 1
                continue

            prev_method = methods[method_index - 1] if method_index > 0 else None
            next_method = methods[method_index + 1] if method_index + 1 < len(methods) else None

            candidates = []
            rule_mono_lifecycle_between_known(
                candidates,
                named_methods,
                is_mono,
                prev_method,
                next_method,
            )
            rule_mono_lifecycle_adjacent_unique(
                candidates,
                named_methods,
                is_mono,
                prev_method,
                next_method,
            )
            rule_accessor_adjacent_pair(
                candidates,
                named_methods,
                fields,
                hash_count,
                prev_method,
                next_method,
            )
            rule_parent_vtable_slot(
                candidates,
                resolver,
                namespace,
                deobf_cls,
                method_index,
                named_methods,
                prev_method,
                next_method,
            )

            prediction = choose_prediction(candidates, args.min_confidence)
            if not prediction:
                continue

            key = f"{semantic_class_name}::{method_name}"
            predictions[key] = {
                "name": prediction["name"],
                "confidence": prediction["confidence"],
                "reason": prediction["reason"],
            }
            rule_counts[prediction["rule"]] += 1
            confidence_counts[prediction["confidence"]] += 1
            samples.append(
                (
                    prediction["confidence"],
                    prediction["rule"],
                    key,
                    prediction["name"],
                    prediction["reason"],
                )
            )

    ensure_parent_dir(args.output)
    with open(args.output, "w", encoding="utf-8") as handle:
        json.dump(dict(sorted(predictions.items())), handle, indent=2, ensure_ascii=False)

    print(f"Examined hash methods (strong classes): {examined_hash_methods}")
    print(f"Skipped non-strong-class hash methods: {skipped_non_strong}")
    print(f"Skipped already semantic in name_mapping: {skipped_named_in_mapping}")
    print(f"Predictions written: {len(predictions)}")
    print()
    print("Predictions by rule:")
    for rule_name, count in rule_counts.most_common():
        print(f"  {rule_name}: {count}")
    print()
    print("Confidence distribution:")
    for confidence, count in sorted(confidence_counts.items(), reverse=True):
        print(f"  {confidence:.2f}: {count}")
    print()
    print("Top 10 samples:")
    for confidence, rule_name, key, name, reason in sorted(
        samples,
        key=lambda item: (-item[0], item[2]),
    )[:10]:
        print(f"  [{confidence:.2f}] {rule_name} | {key} -> {name}")
        print(f"    {reason}")


if __name__ == "__main__":
    main()
