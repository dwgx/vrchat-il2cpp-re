#!/usr/bin/env python3
"""
Lift semantic names from an older deobfuscated IL2CPP dump to a newer
deobfuscated dump using only JSON dump structure.

The dumps are expected to have this shape:
  {"namespaces": {"Namespace": [{"name": "...", "original_name": "...", ...}]}}

No binary dump, VA, or body hash data is required. Matching is based on stable
namespace, parent, count, field, and method-name signals.
"""

from __future__ import annotations

import argparse
import collections
import hashlib
import json
import math
import re
import sys
import time
from dataclasses import dataclass, field
from pathlib import Path
from typing import Any


sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_OLD_DUMP = BASE_DIR / "output" / "deobfuscated_dump_old_build.json"
DEFAULT_NEW_DUMP = BASE_DIR / "output" / "deobfuscated_dump.json"
DEFAULT_OLD_NAME_MAP = BASE_DIR / "output" / "name_mapping_old_build.json"
DEFAULT_EXISTING_VOCAB = BASE_DIR / "data" / "apr25_lifted_vocab.json"
DEFAULT_EXISTING_METHODS = BASE_DIR / "output" / "cross_version_method_names.json"
DEFAULT_OUTPUT = BASE_DIR / "data" / "jun05_lifted_vocab.json"

OBF_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]{3,}$")
ANY_OBF_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
METHOD_HASH_RE = re.compile(r"^m_[0-9A-Fa-f]{3,}$")
FIELD_HASH_RE = re.compile(r"^f_[0-9A-Fa-f]{3,}$")
HEX_SUFFIX_RE = re.compile(r"_[0-9A-Fa-f]{4,}$")
STATIC_FALLBACK_RE = re.compile(r"^Static\d+m_[0-9A-Fa-f]{4,}$")
NUMERIC_FALLBACK_RE = re.compile(
    r"^(?:Type|Struct|Mono|Service|Major|DataOnly|Unknown|Record)\d+(?:m)?_[0-9A-Fa-f]{4,}$"
)

FALLBACK_PREFIXES = (
    "EmptyType_",
    "EmptyStruct_",
    "Class_",
    "Type_",
    "NestedType_",
    "GenericArg_",
    "AsyncStateMachine_",
    "Enumerator_",
    "Delegate_",
    "BaseClass",
    "BaseSibling",
    "SiblingSibling_",
    "LifecycleComponent_",
    "ComplexComponent_",
    "ComplexComponentSibling_",
    "UpdateComponent_",
    "FBase",
    "Unknown",
)

WEAK_NEW_PREFIXES = FALLBACK_PREFIXES + (
    "Static",
    "Mono",
    "MajorSystem_",
    "VRC_SecondarySibling_",
    "VRCUiManagerSibling_",
    "TransformGameObjectSystem_",
    "UdonOperationResponse_",
    "NetworkReadyHandler_",
    "AnimatedTextureBase",
    "CameraBeginInvokeEndInvoke_",
    "PlayerMoveNext_",
    "PointerEnterRelated_",
    "SetLayoutHorizontalSetLayoutVertical_",
    "ctorDerivedSibling_",
    "Derived",
    "NetworkItemSibling",
    "VRCNetworkBehaviourSibling",
)

COMMON_METHODS = frozenset(
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
        "System.IDisposable.Dispose",
        "CompareTo",
        "Compare",
        "Clone",
        "Reset",
        "System.Collections.IEnumerator.Reset",
        "System.Collections.IEnumerator.get_Current",
        "System.Collections.Generic.IEnumerator<System.Object>.get_Current",
        "System.Collections.Generic.IEnumerator<System.Object>.Current",
    }
)

PARENT_EQUIV = {
    "Object": "System.Object",
    "System.Object": "System.Object",
    "ValueType": "System.ValueType",
    "System.ValueType": "System.ValueType",
}


@dataclass(slots=True)
class ClassRecord:
    ordinal: int
    namespace: str
    name: str
    original_name: str
    parent: str
    methods: list[str]
    fields: list[str]
    va: str
    fullname: str
    method_count: int
    field_count: int
    stable_methods: frozenset[str]
    distinctive_methods: frozenset[str]
    stable_fields: frozenset[str]
    name_sig: str
    distinctive_sig: str
    parent_norm: str
    parent_family: str
    parent_chain: tuple[str, ...] = field(default_factory=tuple)


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Lift old semantic names to a new deobfuscated dump without binary dumps."
    )
    parser.add_argument("--old-dump", default=str(DEFAULT_OLD_DUMP))
    parser.add_argument("--new-dump", default=str(DEFAULT_NEW_DUMP))
    parser.add_argument("--old-name-map", default=str(DEFAULT_OLD_NAME_MAP))
    parser.add_argument("--existing-vocab", default=str(DEFAULT_EXISTING_VOCAB))
    parser.add_argument("--existing-methods", default=str(DEFAULT_EXISTING_METHODS))
    parser.add_argument("--output", default=str(DEFAULT_OUTPUT))
    parser.add_argument("--min-confidence", type=float, default=0.70)
    parser.add_argument(
        "--method-min-confidence",
        type=float,
        default=0.50,
        help="Minimum class-pair confidence for method lifts. Class-name lifts still use --min-confidence.",
    )
    parser.add_argument(
        "--include-weak-old",
        action="store_true",
        help="Also try old generated/fallback class names. Default keeps only semantic-looking old names.",
    )
    parser.add_argument(
        "--max-candidates",
        type=int,
        default=2500,
        help="Safety cap per old class after indexed candidate collection.",
    )
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Run matching and print stats without writing the output file.",
    )
    return parser.parse_args()


def load_json(path: Path, optional: bool = False) -> Any:
    if optional and not path.exists():
        return {}
    started = time.time()
    with path.open("r", encoding="utf-8") as handle:
        data = json.load(handle)
    print(f"Loaded {rel(path)} ({path.stat().st_size:,} bytes) in {time.time() - started:.1f}s")
    return data


def rel(path: Path) -> str:
    try:
        return str(path.relative_to(BASE_DIR))
    except ValueError:
        return str(path)


def member_name(entry: Any) -> str:
    if isinstance(entry, str):
        return entry
    if isinstance(entry, dict):
        value = entry.get("name")
        return value if isinstance(value, str) else ""
    return ""


def is_obf(name: str) -> bool:
    return bool(name and OBF_RE.fullmatch(name))


def contains_obf(name: str) -> bool:
    return bool(name and ANY_OBF_RE.search(name))


def is_hash_method(name: str) -> bool:
    return bool(name and METHOD_HASH_RE.fullmatch(name))


def is_hash_field(name: str) -> bool:
    return bool(name and FIELD_HASH_RE.fullmatch(name))


def is_semantic_method(name: str) -> bool:
    if not name or contains_obf(name) or is_hash_method(name):
        return False
    return True


def is_semantic_field(name: str) -> bool:
    if not name or contains_obf(name) or is_hash_field(name):
        return False
    return True


def looks_fallback_class_name(name: str) -> bool:
    if not name:
        return True
    if name.startswith("<") or ">" in name:
        return True
    if STATIC_FALLBACK_RE.fullmatch(name):
        return True
    if NUMERIC_FALLBACK_RE.fullmatch(name):
        return True
    if HEX_SUFFIX_RE.search(name):
        return True
    if name.startswith(FALLBACK_PREFIXES):
        return True
    return False


def is_semantic_class_name(name: str, include_weak_old: bool = False) -> bool:
    if not name or is_obf(name) or contains_obf(name):
        return False
    if include_weak_old:
        return not (name.startswith("<") or ">" in name)
    return not looks_fallback_class_name(name)


def is_readable_class_name(name: str) -> bool:
    return bool(name and not is_obf(name) and not contains_obf(name))


def is_old_lift_source(record: ClassRecord) -> bool:
    return bool(record.methods and is_readable_class_name(record.name))


def is_new_lift_target(record: ClassRecord) -> bool:
    if is_obf(record.name):
        return True
    if record.original_name:
        return True
    if looks_fallback_class_name(record.name):
        return True
    if record.name.startswith(WEAK_NEW_PREFIXES):
        return True
    if HEX_SUFFIX_RE.search(record.name):
        return True
    return False


def normalize_parent(name: str) -> str:
    if not name:
        return ""
    if is_obf(name):
        return "<obf>"
    return PARENT_EQUIV.get(name, name)


def parent_family(name: str) -> str:
    norm = normalize_parent(name)
    if not norm:
        return ""
    if norm == "<obf>":
        return "<obf>"
    if norm in ("System.Object", "System.ValueType", "MonoBehaviour", "MulticastDelegate"):
        return norm
    if looks_fallback_class_name(norm):
        return re.sub(r"_[0-9A-Fa-f]{4,}$", "", norm)
    return norm


def stable_method_names(methods: list[str]) -> frozenset[str]:
    return frozenset(m for m in methods if is_semantic_method(m))


def distinctive_method_names(methods: list[str]) -> frozenset[str]:
    return frozenset(m for m in methods if is_semantic_method(m) and m not in COMMON_METHODS)


def stable_field_names(fields: list[str]) -> frozenset[str]:
    return frozenset(f for f in fields if is_semantic_field(f))


def fingerprint(names: frozenset[str]) -> str:
    if not names:
        return ""
    joined = "\x1f".join(sorted(names))
    return hashlib.sha1(joined.encode("utf-8")).hexdigest()


def flatten_dump(dump: dict[str, Any]) -> list[ClassRecord]:
    records: list[ClassRecord] = []
    ordinal = 0
    for namespace, classes in dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            name = str(cls.get("name") or "")
            original_name = str(cls.get("original_name") or "")
            parent = str(cls.get("parent") or "")
            methods = [member_name(item) for item in cls.get("methods", [])]
            fields = [member_name(item) for item in cls.get("fields", [])]
            stable_methods = stable_method_names(methods)
            distinctive_methods = distinctive_method_names(methods)
            stable_fields = stable_field_names(fields)
            fullname = f"{namespace}.{name}" if namespace else name
            records.append(
                ClassRecord(
                    ordinal=ordinal,
                    namespace=str(namespace or ""),
                    name=name,
                    original_name=original_name,
                    parent=parent,
                    methods=methods,
                    fields=fields,
                    va=str(cls.get("va") or ""),
                    fullname=fullname,
                    method_count=len(methods),
                    field_count=len(fields),
                    stable_methods=stable_methods,
                    distinctive_methods=distinctive_methods,
                    stable_fields=stable_fields,
                    name_sig=fingerprint(stable_methods),
                    distinctive_sig=fingerprint(distinctive_methods),
                    parent_norm=normalize_parent(parent),
                    parent_family=parent_family(parent),
                )
            )
            ordinal += 1
    attach_parent_chains(records)
    return records


def attach_parent_chains(records: list[ClassRecord]) -> None:
    by_name: dict[str, ClassRecord] = {}
    by_original: dict[str, ClassRecord] = {}
    for record in records:
        by_name.setdefault(record.name, record)
        if record.original_name:
            by_original.setdefault(record.original_name, record)

    for record in records:
        chain: list[str] = []
        seen: set[str] = set()
        parent = record.parent
        for _ in range(4):
            if not parent or parent in seen:
                break
            seen.add(parent)
            chain.append(parent_family(parent))
            parent_record = by_name.get(parent) or by_original.get(parent)
            if parent_record is None:
                break
            parent = parent_record.parent
        record.parent_chain = tuple(item for item in chain if item)


def build_new_indexes(records: list[ClassRecord]) -> dict[str, Any]:
    indexes: dict[str, Any] = {
        "by_ns_sig": collections.defaultdict(list),
        "by_sig": collections.defaultdict(list),
        "by_ns_distinctive_sig": collections.defaultdict(list),
        "by_distinctive_sig": collections.defaultdict(list),
        "by_ns_count": collections.defaultdict(list),
        "by_parent": collections.defaultdict(list),
        "by_fullname": collections.defaultdict(list),
        "by_ns_name": collections.defaultdict(list),
        "targets": [],
    }

    targets = [record for record in records if is_new_lift_target(record)]
    indexes["targets"] = targets
    for record in targets:
        indexes["by_fullname"][record.fullname].append(record)
        indexes["by_ns_name"][(record.namespace, record.name)].append(record)
        if record.name_sig:
            indexes["by_ns_sig"][(record.namespace, record.name_sig)].append(record)
            indexes["by_sig"][record.name_sig].append(record)
        if record.distinctive_sig:
            indexes["by_ns_distinctive_sig"][(record.namespace, record.distinctive_sig)].append(record)
            indexes["by_distinctive_sig"][record.distinctive_sig].append(record)
        indexes["by_ns_count"][(record.namespace, count_bucket(record.method_count))].append(record)
        if record.parent_family:
            indexes["by_parent"][(record.namespace, record.parent_family)].append(record)
            indexes["by_parent"][("", record.parent_family)].append(record)

    target_ordinals = {record.ordinal for record in targets}
    for record in records:
        if record.ordinal not in target_ordinals:
            indexes["by_fullname"][record.fullname].append(record)
            indexes["by_ns_name"][(record.namespace, record.name)].append(record)
    return indexes


def count_bucket(count: int) -> int:
    if count < 10:
        return count
    return int(count // 5)


def count_similarity(left: int, right: int) -> float:
    high = max(left, right)
    if high == 0:
        return 1.0
    return max(0.0, 1.0 - (abs(left - right) / high))


def jaccard(left: frozenset[str], right: frozenset[str]) -> float:
    if not left and not right:
        return 1.0
    if not left or not right:
        return 0.0
    union = left | right
    return len(left & right) / len(union) if union else 1.0


def overlap_ratio(left: frozenset[str], right: frozenset[str]) -> float:
    if not left and not right:
        return 1.0
    smaller = min(len(left), len(right))
    if smaller == 0:
        return 0.0
    return len(left & right) / smaller


def collect_candidates(old: ClassRecord, indexes: dict[str, Any], max_candidates: int) -> list[ClassRecord]:
    candidates: dict[int, ClassRecord] = {}

    def add_many(items: list[ClassRecord]) -> None:
        for item in items:
            candidates[item.ordinal] = item

    add_many(indexes["by_fullname"].get(old.fullname, []))
    add_many(indexes["by_ns_name"].get((old.namespace, old.name), []))

    if old.distinctive_sig:
        add_many(indexes["by_ns_distinctive_sig"].get((old.namespace, old.distinctive_sig), []))
        if len(old.distinctive_methods) >= 3:
            add_many(indexes["by_distinctive_sig"].get(old.distinctive_sig, []))

    if old.name_sig:
        add_many(indexes["by_ns_sig"].get((old.namespace, old.name_sig), []))
        if len(old.stable_methods) >= 4:
            add_many(indexes["by_sig"].get(old.name_sig, []))

    bucket = count_bucket(old.method_count)
    for nearby in range(bucket - 1, bucket + 2):
        add_many(indexes["by_ns_count"].get((old.namespace, nearby), []))

    if old.parent_family:
        add_many(indexes["by_parent"].get((old.namespace, old.parent_family), []))

    if len(candidates) > max_candidates:
        # Prefer same namespace, close counts, and method overlap before scoring.
        ranked = sorted(
            candidates.values(),
            key=lambda new: (
                int(new.namespace == old.namespace),
                count_similarity(old.method_count, new.method_count),
                count_similarity(old.field_count, new.field_count),
                overlap_ratio(old.distinctive_methods, new.distinctive_methods),
                overlap_ratio(old.stable_methods, new.stable_methods),
            ),
            reverse=True,
        )
        return ranked[:max_candidates]

    return list(candidates.values())


def score_match(old: ClassRecord, new: ClassRecord) -> tuple[float, list[str], dict[str, float]]:
    signals: list[str] = []
    metrics: dict[str, float] = {}

    exact_name_score = 1.0 if old.namespace == new.namespace and old.name == new.name else 0.0
    if exact_name_score:
        signals.append("exact_fullname")
    metrics["exact_name"] = exact_name_score

    namespace_score = 1.0 if old.namespace == new.namespace else 0.0
    if namespace_score:
        signals.append("namespace")
    metrics["namespace"] = namespace_score

    method_jaccard = jaccard(old.stable_methods, new.stable_methods)
    method_overlap = overlap_ratio(old.stable_methods, new.stable_methods)
    distinctive_jaccard = jaccard(old.distinctive_methods, new.distinctive_methods)
    distinctive_overlap = overlap_ratio(old.distinctive_methods, new.distinctive_methods)
    metrics["method_jaccard"] = method_jaccard
    metrics["method_overlap"] = method_overlap
    metrics["distinctive_jaccard"] = distinctive_jaccard
    metrics["distinctive_overlap"] = distinctive_overlap

    if old.name_sig and old.name_sig == new.name_sig:
        signals.append("name_sig_exact")
    if old.distinctive_sig and old.distinctive_sig == new.distinctive_sig:
        signals.append("distinctive_name_sig_exact")
    if len(old.stable_methods & new.stable_methods) > 0:
        signals.append(f"method_overlap:{len(old.stable_methods & new.stable_methods)}")
    if len(old.distinctive_methods & new.distinctive_methods) > 0:
        signals.append(f"distinctive_method_overlap:{len(old.distinctive_methods & new.distinctive_methods)}")

    parent_exact = 1.0 if old.parent_norm and old.parent_norm == new.parent_norm else 0.0
    parent_family_score = 1.0 if old.parent_family and old.parent_family == new.parent_family else 0.0
    parent_score = max(parent_exact, parent_family_score * 0.65)
    if parent_exact:
        signals.append("parent_exact")
    elif parent_family_score:
        signals.append("parent_family")
    metrics["parent"] = parent_score

    old_chain = frozenset(old.parent_chain)
    new_chain = frozenset(new.parent_chain)
    chain_score = jaccard(old_chain, new_chain) if old_chain or new_chain else 0.0
    if chain_score >= 0.5:
        signals.append("parent_chain")
    metrics["parent_chain"] = chain_score

    method_count_score = count_similarity(old.method_count, new.method_count)
    field_count_score = count_similarity(old.field_count, new.field_count)
    if new.field_count == 0 and old.field_count > 0:
        # The current new deobfuscated dump has many weak classes with method
        # lists but no field lists. Treat missing new fields as unknown, not as
        # hard negative evidence.
        field_count_score = 0.65
    count_score = (method_count_score * 0.70) + (field_count_score * 0.30)
    metrics["method_count"] = method_count_score
    metrics["field_count"] = field_count_score
    if method_count_score >= 0.90:
        signals.append("method_count_close")
    if field_count_score >= 0.90:
        signals.append("field_count_close")

    field_jaccard = jaccard(old.stable_fields, new.stable_fields)
    field_overlap = overlap_ratio(old.stable_fields, new.stable_fields)
    metrics["field_jaccard"] = field_jaccard
    metrics["field_overlap"] = field_overlap
    if len(old.stable_fields & new.stable_fields) > 0:
        signals.append(f"field_overlap:{len(old.stable_fields & new.stable_fields)}")

    exact_sig_bonus = 0.0
    if old.distinctive_sig and old.distinctive_sig == new.distinctive_sig:
        exact_sig_bonus = 0.22 if len(old.distinctive_methods) >= 3 else 0.12
    elif old.name_sig and old.name_sig == new.name_sig:
        exact_sig_bonus = 0.18 if len(old.stable_methods) >= 4 else 0.08

    method_score = max(method_overlap * 0.75, method_jaccard, distinctive_overlap * 0.90)
    field_score = max(field_overlap * 0.65, field_jaccard)
    subset_bonus = 0.0
    if (
        namespace_score
        and len(new.stable_methods) >= 5
        and method_overlap >= 0.80
        and method_count_score >= 0.90
    ):
        subset_bonus = 0.18
        if len(new.distinctive_methods) >= 4 and distinctive_overlap >= 0.75:
            subset_bonus += 0.06

    exact_name_bonus = 0.0
    if exact_name_score:
        exact_name_bonus = 0.45
        if method_count_score >= 0.75:
            exact_name_bonus += 0.10
        if old.parent_norm and old.parent_norm == new.parent_norm:
            exact_name_bonus += 0.08

    score = (
        (0.14 * namespace_score)
        + (0.31 * method_score)
        + (0.14 * parent_score)
        + (0.08 * chain_score)
        + (0.16 * count_score)
        + (0.07 * field_score)
        + exact_sig_bonus
        + subset_bonus
        + exact_name_bonus
    )

    # Sparse signatures are common in IL2CPP dumps; require more corroboration.
    shared_methods = len(old.stable_methods & new.stable_methods)
    shared_distinctive = len(old.distinctive_methods & new.distinctive_methods)
    if shared_methods < 2 and old.method_count > 3 and new.method_count > 3:
        score *= 0.80
    if shared_distinctive == 0 and shared_methods < 4:
        score *= 0.90
    if old.namespace != new.namespace and shared_distinctive < 3:
        score *= 0.80
    if old.method_count > 20 and method_count_score < 0.70:
        score *= 0.85

    return min(1.0, round(score, 6)), signals, metrics


def choose_best_match(
    old: ClassRecord,
    candidates: list[ClassRecord],
    min_confidence: float,
) -> tuple[ClassRecord | None, float, list[str], dict[str, float], bool]:
    best: tuple[ClassRecord, float, list[str], dict[str, float]] | None = None
    second_score = 0.0

    for new in candidates:
        score, signals, metrics = score_match(old, new)
        if best is None or score > best[1]:
            if best is not None:
                second_score = best[1]
            best = (new, score, signals, metrics)
        elif score > second_score:
            second_score = score

    if best is None:
        return None, 0.0, [], {}, False

    new, score, signals, metrics = best
    ambiguous = second_score >= min_confidence and (score - second_score) < 0.05
    if score < min_confidence or ambiguous:
        return None, score, signals, metrics, ambiguous
    return new, score, signals, metrics, False


def member_class_key(record: ClassRecord) -> str:
    return record.name


def class_map_key(record: ClassRecord) -> str:
    return record.original_name if is_obf(record.original_name) else record.name


def add_mapping(target: dict[str, str], conflicts: list[dict[str, str]], category: str, key: str, value: str) -> bool:
    if not key or not value or contains_obf(value):
        return False
    existing = target.get(key)
    if existing is None:
        target[key] = value
        return True
    if existing == value:
        return False
    conflicts.append({"category": category, "key": key, "existing": existing, "ignored": value})
    return False


def nearest_stable(methods: list[str], index: int, direction: int, max_distance: int = 6) -> str:
    current = index + direction
    distance = 0
    while 0 <= current < len(methods) and distance < max_distance:
        name = methods[current]
        if is_semantic_method(name) and not is_hash_method(name):
            return name
        current += direction
        distance += 1
    return ""


def method_neighbor_key(methods: list[str], index: int) -> tuple[str, str]:
    return (
        nearest_stable(methods, index, -1),
        nearest_stable(methods, index, 1),
    )


def build_old_neighbor_index(old: ClassRecord) -> dict[tuple[str, str], list[tuple[int, str]]]:
    out: dict[tuple[str, str], list[tuple[int, str]]] = collections.defaultdict(list)
    for index, name in enumerate(old.methods):
        if is_semantic_method(name):
            out[method_neighbor_key(old.methods, index)].append((index, name))
    return out


def lift_methods(
    old: ClassRecord,
    new: ClassRecord,
    confidence: float,
    method_min_confidence: float,
    method_map: dict[str, str],
    cross_version_methods: dict[str, str],
    conflicts: list[dict[str, str]],
) -> tuple[int, collections.Counter[str]]:
    added = 0
    stats: collections.Counter[str] = collections.Counter()
    class_key = member_class_key(new)
    old_neighbors = build_old_neighbor_index(old)
    same_or_close_count = abs(len(old.methods) - len(new.methods)) <= max(2, math.ceil(max(len(old.methods), len(new.methods)) * 0.10))
    exact_class_name = old.namespace == new.namespace and old.name == new.name

    for index, new_method in enumerate(new.methods):
        if not is_hash_method(new_method):
            continue

        lifted_name = ""
        source = ""
        if index < len(old.methods) and is_semantic_method(old.methods[index]) and same_or_close_count:
            old_key = method_neighbor_key(old.methods, index)
            new_key = method_neighbor_key(new.methods, index)
            if (
                confidence >= 0.78
                or (confidence >= method_min_confidence and exact_class_name)
                or old_key == new_key
                or not any(old_key + new_key)
            ):
                lifted_name = old.methods[index]
                source = "position"

        if not lifted_name:
            new_key = method_neighbor_key(new.methods, index)
            choices = old_neighbors.get(new_key, [])
            semantic_choices = [(old_index, name) for old_index, name in choices if is_semantic_method(name)]
            if len(semantic_choices) == 1:
                lifted_name = semantic_choices[0][1]
                source = "neighbors"

        if not lifted_name:
            continue

        key = f"{class_key}::{new_method}"
        if add_mapping(method_map, conflicts, "method", key, lifted_name):
            added += 1
            stats[source] += 1

        cv_key = f"{class_key}::{new_method}"
        add_mapping(cross_version_methods, conflicts, "cross_version_method", cv_key, lifted_name)

    return added, stats


def lift_fields(
    old: ClassRecord,
    new: ClassRecord,
    confidence: float,
    field_map: dict[str, str],
    conflicts: list[dict[str, str]],
) -> tuple[int, collections.Counter[str]]:
    added = 0
    stats: collections.Counter[str] = collections.Counter()
    if confidence < 0.82 and len(old.fields) != len(new.fields):
        return added, stats

    class_key = member_class_key(new)
    limit = min(len(old.fields), len(new.fields))
    for index in range(limit):
        new_field = new.fields[index]
        old_field = old.fields[index]
        if not is_hash_field(new_field) or not is_semantic_field(old_field):
            continue
        key = f"{class_key}::{new_field}"
        if add_mapping(field_map, conflicts, "field", key, old_field):
            added += 1
            stats["position"] += 1

    return added, stats


def main() -> int:
    args = parse_args()
    old_dump_path = Path(args.old_dump)
    new_dump_path = Path(args.new_dump)
    output_path = Path(args.output)

    old_dump = load_json(old_dump_path)
    new_dump = load_json(new_dump_path)
    old_name_map = load_json(Path(args.old_name_map), optional=True)
    existing_vocab = load_json(Path(args.existing_vocab), optional=True)
    existing_methods = load_json(Path(args.existing_methods), optional=True)

    print("Flattening dumps...")
    old_records = flatten_dump(old_dump)
    new_records = flatten_dump(new_dump)
    print(f"Old classes: {len(old_records):,}")
    print(f"New classes: {len(new_records):,}")

    old_semantic = [record for record in old_records if is_old_lift_source(record)]
    new_targets = [record for record in new_records if is_new_lift_target(record)]
    print(f"Old semantic source classes: {len(old_semantic):,}")
    print(f"New weak/obfuscated target classes: {len(new_targets):,}")

    print("Building new-class indexes...")
    indexes = build_new_indexes(new_records)

    class_name_map: dict[str, str] = dict(existing_vocab.get("class_name_map", {})) if isinstance(existing_vocab, dict) else {}
    method_name_map: dict[str, str] = dict(existing_vocab.get("method_name_map", {})) if isinstance(existing_vocab, dict) else {}
    field_name_map: dict[str, str] = dict(existing_vocab.get("field_name_map", {})) if isinstance(existing_vocab, dict) else {}
    cross_version_method_names: dict[str, str] = (
        dict(existing_vocab.get("cross_version_method_names", {})) if isinstance(existing_vocab, dict) else {}
    )
    if isinstance(existing_methods, dict):
        for key, value in existing_methods.items():
            add_mapping(cross_version_method_names, [], "existing_cross_version_method", key, value)
    conflicts: list[dict[str, str]] = []
    match_details: list[dict[str, Any]] = []

    stats: dict[str, Any] = {
        "old_classes": len(old_records),
        "new_classes": len(new_records),
        "old_semantic_source_classes": len(old_semantic),
        "new_target_classes": len(new_targets),
        "matched_classes": 0,
        "class_name_lifts": 0,
        "method_name_lifts": 0,
        "field_name_lifts": 0,
        "method_lift_sources": {},
        "field_lift_sources": {},
        "unmatched_old_semantic": 0,
        "ambiguous_matches": 0,
        "candidates_examined": 0,
        "conflicts": 0,
        "existing_vocab_classes": len(existing_vocab.get("class_name_map", {})) if isinstance(existing_vocab, dict) else 0,
        "existing_vocab_methods": len(existing_vocab.get("method_name_map", {})) if isinstance(existing_vocab, dict) else 0,
        "existing_vocab_fields": len(existing_vocab.get("field_name_map", {})) if isinstance(existing_vocab, dict) else 0,
        "existing_cross_version_methods": len(existing_methods) if isinstance(existing_methods, dict) else 0,
        "old_name_map_classes": len(old_name_map.get("classes", {})) if isinstance(old_name_map, dict) else 0,
        "old_name_map_methods": len(old_name_map.get("methods", {})) if isinstance(old_name_map, dict) else 0,
        "old_name_map_fields": len(old_name_map.get("fields", {})) if isinstance(old_name_map, dict) else 0,
        "min_confidence": args.min_confidence,
        "method_min_confidence": args.method_min_confidence,
        "include_weak_old": bool(args.include_weak_old),
    }

    method_source_counter: collections.Counter[str] = collections.Counter()
    field_source_counter: collections.Counter[str] = collections.Counter()
    started = time.time()

    for index, old in enumerate(old_semantic, start=1):
        candidates = collect_candidates(old, indexes, args.max_candidates)
        stats["candidates_examined"] += len(candidates)
        new, confidence, signals, metrics, ambiguous = choose_best_match(old, candidates, args.method_min_confidence)

        class_confident = new is not None and confidence >= args.min_confidence
        method_confident = new is not None and confidence >= args.method_min_confidence

        if ambiguous and not method_confident:
            stats["ambiguous_matches"] += 1
        if new is None:
            stats["unmatched_old_semantic"] += 1
        else:
            stats["matched_classes"] += 1
            key = class_map_key(new)
            if class_confident and is_new_lift_target(new) and key and old.name != new.name:
                if add_mapping(class_name_map, conflicts, "class", key, old.name):
                    stats["class_name_lifts"] += 1

            if method_confident:
                method_added, method_sources = lift_methods(
                    old,
                    new,
                    confidence,
                    args.method_min_confidence,
                    method_name_map,
                    cross_version_method_names,
                    conflicts,
                )
            else:
                method_added, method_sources = 0, collections.Counter()
            field_added, field_sources = lift_fields(old, new, confidence, field_name_map, conflicts)
            stats["method_name_lifts"] += method_added
            stats["field_name_lifts"] += field_added
            method_source_counter.update(method_sources)
            field_source_counter.update(field_sources)

            match_details.append(
                {
                    "old": old.fullname,
                    "old_name": old.name,
                    "old_obf": old.original_name,
                    "new": new.fullname,
                    "new_name": new.name,
                    "new_obf": class_map_key(new),
                    "confidence": confidence,
                    "signals": signals,
                    "metrics": {k: round(v, 4) for k, v in metrics.items()},
                    "method_count_old": old.method_count,
                    "method_count_new": new.method_count,
                    "field_count_old": old.field_count,
                    "field_count_new": new.field_count,
                    "methods_lifted": method_added,
                    "fields_lifted": field_added,
                }
            )

        if index % 250 == 0 or index == len(old_semantic):
            elapsed = time.time() - started
            print(
                f"Matched {index:,}/{len(old_semantic):,} old classes; "
                f"{stats['matched_classes']:,} accepted, "
                f"{stats['unmatched_old_semantic']:,} unmatched, "
                f"{elapsed:.1f}s"
            )

    stats["method_lift_sources"] = dict(sorted(method_source_counter.items()))
    stats["field_lift_sources"] = dict(sorted(field_source_counter.items()))
    stats["conflicts"] = len(conflicts)

    output = {
        "generated_by": "tools/lift_old_to_new_vocab.py",
        "timestamp": time.strftime("%Y-%m-%d %H:%M:%S"),
        "inputs": {
            "old_dump": rel(old_dump_path),
            "new_dump": rel(new_dump_path),
            "old_name_map": rel(Path(args.old_name_map)),
            "existing_vocab": rel(Path(args.existing_vocab)),
            "existing_methods": rel(Path(args.existing_methods)),
        },
        "class_name_map": dict(sorted(class_name_map.items())),
        "method_name_map": dict(sorted(method_name_map.items())),
        "field_name_map": dict(sorted(field_name_map.items())),
        "cross_version_method_names": dict(sorted(cross_version_method_names.items())),
        "stats": stats,
        "match_details": sorted(match_details, key=lambda item: (-item["confidence"], item["old"])),
        "conflicts": conflicts[:5000],
        "conflict_count": len(conflicts),
    }

    if not args.dry_run:
        output_path.parent.mkdir(parents=True, exist_ok=True)
        with output_path.open("w", encoding="utf-8") as handle:
            json.dump(output, handle, indent=2, ensure_ascii=False, sort_keys=False)
            handle.write("\n")
        print(f"Wrote {rel(output_path)}")
    else:
        print("Dry run requested; output file was not written.")

    print("\nSummary")
    print(f"  Class matches: {stats['matched_classes']:,}/{len(old_semantic):,}")
    print(f"  Class lifts: {stats['class_name_lifts']:,}")
    print(f"  Method lifts: {stats['method_name_lifts']:,}")
    print(f"  Field lifts: {stats['field_name_lifts']:,}")
    print(f"  Ambiguous matches skipped: {stats['ambiguous_matches']:,}")
    print(f"  Conflicts: {len(conflicts):,}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
