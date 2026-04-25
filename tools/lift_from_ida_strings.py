#!/usr/bin/env python3
"""Lift NEW hash-method names from IDA string references.

Outputs:
  output/ida_string_based_names.json

Report:
  Prints target coverage, emitted predictions, category counts, and 20 samples.
"""

from __future__ import annotations

import argparse
import bisect
import collections
import hashlib
import json
import re
import sys
from dataclasses import dataclass
from pathlib import Path

import pefile


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


ROOT = Path(__file__).resolve().parent.parent
DEFAULT_PRECISE = ROOT / "data" / "precise_dump.json"
DEFAULT_NAME_MAP = ROOT / "output" / "name_mapping.json"
DEFAULT_IDA = ROOT / "output" / "v_new_ida" / "ida_analysis.json"
DEFAULT_DLL = ROOT / "ida_new" / "GameAssembly.dll"
DEFAULT_OUTPUT = ROOT / "output" / "ida_string_based_names.json"

IDA_BASE = 0x180000000
MAX_FUNC_DISTANCE = 0x200

HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$", re.I)
API_RE = re.compile(r"([A-Za-z0-9_.+/]+)::([A-Za-z0-9_]+)\(")
ACCESSOR_RE = re.compile(r"^(get|set)_([A-Za-z][A-Za-z0-9_]*)$")
EXCEPTION_RE = re.compile(r"\b([A-Za-z]+Exception)\b")
PASCAL_LITERAL_RE = re.compile(r"^[A-Z][A-Za-z0-9_]{3,63}$")
VALID_PREDICTION_RE = re.compile(
    r"^(?:[A-Z][A-Za-z0-9_]{1,63}|(?:get|set)_[A-Za-z][A-Za-z0-9_]{1,63})$"
)

TRIVIAL_NAMES = frozenset(
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
        "Invoke",
        "BeginInvoke",
        "EndInvoke",
        "MoveNext",
        "Reset",
        "Current",
        "get_Current",
        "set_Current",
    }
)

GENERIC_PROPS = frozenset(
    {
        "gameObject",
        "transform",
        "enabled",
        "position",
        "rotation",
        "localPosition",
        "localRotation",
        "localScale",
        "deltaTime",
        "fixedDeltaTime",
        "time",
        "unscaledTime",
        "realtimeSinceStartup",
        "width",
        "height",
    }
)

TRANSFORM_PROPS = frozenset(
    {
        "position",
        "rotation",
        "localPosition",
        "localRotation",
        "localScale",
        "lossyScale",
    }
)


@dataclass(slots=True)
class MethodRecord:
    semantic_class: str
    class_obf: str
    method_obf: str
    mapped_name: str
    runtime_va: int
    ida_va: int
    func_key: str
    func_start: int
    distance: int
    strings: list[str]
    calls: list[str]
    ida_name: str | None

    @property
    def output_key(self) -> str:
        return f"{self.semantic_class}::m_{stable_hash(self.method_obf, 3)}"


@dataclass(slots=True)
class Assoc:
    name: str
    count: int
    total: int

    @property
    def ratio(self) -> float:
        return float(self.count) / float(self.total)


@dataclass(slots=True)
class Prediction:
    name: str
    category: str
    evidence: list[str]


class PEImage:
    def __init__(self, path: Path):
        self.path = path
        self.data = path.read_bytes()
        self.pe = pefile.PE(str(path), fast_load=True)
        self.pref_base = self.pe.OPTIONAL_HEADER.ImageBase
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
                }
            )
        self.runtime_base = 0

    def infer_runtime_base(self, precise_dump: dict) -> int:
        vas: list[int] = []
        for _, classes in precise_dump.get("namespaces", {}).items():
            if not isinstance(classes, list):
                continue
            for cls in classes:
                for value in (cls.get("method_pointers") or {}).values():
                    va = parse_va(value)
                    if va:
                        vas.append(va)
        if not vas:
            self.runtime_base = self.pref_base
            return self.runtime_base

        lo = (
            (max(vas) - max(section["end"] for section in self.exec_sections)) // 0x10000
        ) * 0x10000
        hi = (
            (min(vas) - min(section["start"] for section in self.exec_sections)) // 0x10000
        ) * 0x10000

        best_base = self.pref_base
        best_hits = -1
        for base in range(lo, hi + 1, 0x10000):
            hits = 0
            for va in vas:
                rva = va - base
                if any(section["start"] <= rva < section["end"] for section in self.exec_sections):
                    hits += 1
            if hits > best_hits:
                best_base = base
                best_hits = hits

        self.runtime_base = best_base
        return self.runtime_base


class IDAFunctionLookup:
    def __init__(self, ida_functions: dict[str, dict]):
        items = sorted((int(key, 16), key) for key in ida_functions.keys())
        self.starts = [item[0] for item in items]
        self.keys = [item[1] for item in items]
        self.ida_functions = ida_functions

    def find_containing(self, ida_va: int, max_distance: int) -> tuple[str | None, dict | None, int | None]:
        idx = bisect.bisect_right(self.starts, ida_va) - 1
        if idx < 0:
            return None, None, None
        func_start = self.starts[idx]
        distance = ida_va - func_start
        if distance < 0 or distance > max_distance:
            return None, None, None
        key = self.keys[idx]
        return key, self.ida_functions[key], distance


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--precise", default=str(DEFAULT_PRECISE))
    parser.add_argument("--name-map", default=str(DEFAULT_NAME_MAP))
    parser.add_argument("--ida", default=str(DEFAULT_IDA))
    parser.add_argument("--dll", default=str(DEFAULT_DLL))
    parser.add_argument("--output", default=str(DEFAULT_OUTPUT))
    parser.add_argument("--max-func-distance", type=int, default=MAX_FUNC_DISTANCE)
    return parser.parse_args()


def load_json(path: str | Path) -> dict:
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def save_json(path: str | Path, data: dict) -> None:
    path = Path(path)
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("w", encoding="utf-8") as handle:
        json.dump(data, handle, indent=2, ensure_ascii=False, sort_keys=True)


def parse_va(value) -> int | None:
    if not value:
        return None
    try:
        return int(str(value), 16)
    except ValueError:
        return None


def stable_hash(name: str, length: int = 3) -> str:
    return hashlib.sha256(name.encode("utf-8")).hexdigest()[:length].upper()


def build_pointer_map(precise_dump: dict) -> dict[tuple[str, str], int]:
    pointer_map: dict[tuple[str, str], int] = {}
    for _, classes in precise_dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            class_name = str(cls.get("name") or "")
            for method_name, va_str in (cls.get("method_pointers") or {}).items():
                va = parse_va(va_str)
                if va:
                    pointer_map[(class_name, str(method_name))] = va
    return pointer_map


def clean_api_member(method_name: str) -> str:
    method_name = method_name.strip()
    if method_name.endswith("_Injected"):
        method_name = method_name[: -len("_Injected")]
    return method_name


def normalize_accessor_name(action: str, prop: str) -> str:
    prop = prop.strip("_")
    prop = prop.replace("__", "_")
    return f"{action}_{prop}" if prop else ""


def camelize(text: str) -> str:
    parts = re.split(r"[_\W]+", text)
    return "".join(part[:1].upper() + part[1:] for part in parts if part)


def is_prediction_name(name: str | None) -> bool:
    if not name or not isinstance(name, str):
        return False
    if HASH_METHOD_RE.fullmatch(name):
        return False
    if name in TRIVIAL_NAMES:
        return False
    return bool(VALID_PREDICTION_RE.fullmatch(name))


def sanitize_prediction(name: str | None) -> str | None:
    if not name:
        return None
    name = name.strip().replace("::", "_")
    name = re.sub(r"_Injected$", "", name)
    if name.startswith(("get_", "set_")):
        action, prop = name.split("_", 1)
        name = normalize_accessor_name(action, prop)
    elif name and name[0].islower():
        name = name[:1].upper() + name[1:]
    if not is_prediction_name(name):
        return None
    return name


def meaningful_ida_name(name: str | None) -> str | None:
    if not name:
        return None
    if name.startswith("sub_") or name.startswith("?") or "@@" in name:
        return None
    if "_" in name and not name.startswith(("get_", "set_")):
        return None
    return sanitize_prediction(name)


def collect_records(
    precise_dump: dict,
    name_map: dict,
    ida_functions: dict[str, dict],
    runtime_base: int,
    max_func_distance: int,
) -> tuple[list[MethodRecord], dict[str, int]]:
    pointer_map = build_pointer_map(precise_dump)
    class_map = name_map.get("classes", {}) or {}
    method_map = name_map.get("methods", {}) or {}
    lookup = IDAFunctionLookup(ida_functions)

    stats = collections.Counter()
    records: list[MethodRecord] = []

    for full_key, mapped_name in method_map.items():
        if not isinstance(mapped_name, str):
            continue
        stats["methods_in_map"] += 1
        if "::" not in full_key:
            stats["bad_method_key"] += 1
            continue
        class_obf, method_obf = full_key.split("::", 1)
        semantic_class = class_map.get(class_obf)
        if not semantic_class:
            stats["missing_semantic_class"] += 1
            continue

        runtime_va = pointer_map.get((class_obf, method_obf))
        if not runtime_va:
            stats["missing_runtime_va"] += 1
            continue

        ida_va = runtime_va - runtime_base + IDA_BASE
        func_key, func_data, distance = lookup.find_containing(ida_va, max_func_distance)
        if not func_key or not func_data or distance is None:
            stats["missing_ida_match"] += 1
            continue

        record = MethodRecord(
            semantic_class=semantic_class,
            class_obf=class_obf,
            method_obf=method_obf,
            mapped_name=mapped_name,
            runtime_va=runtime_va,
            ida_va=ida_va,
            func_key=func_key,
            func_start=int(func_key, 16),
            distance=distance,
            strings=list(func_data.get("strings") or []),
            calls=list(func_data.get("calls") or []),
            ida_name=func_data.get("ida_name"),
        )
        records.append(record)
        stats["records_mapped"] += 1
        if HASH_METHOD_RE.fullmatch(mapped_name):
            stats["hash_records_mapped"] += 1
        else:
            stats["semantic_records_mapped"] += 1

    return records, dict(stats)


def select_unique_best_records(records: list[MethodRecord]) -> tuple[list[MethodRecord], dict[str, int]]:
    grouped: dict[str, list[MethodRecord]] = collections.defaultdict(list)
    stats = collections.Counter()
    for record in records:
        grouped[record.func_key].append(record)

    selected: list[MethodRecord] = []
    for func_key, rows in grouped.items():
        rows.sort(
            key=lambda record: (
                record.distance,
                record.semantic_class,
                record.mapped_name,
                record.class_obf,
                record.method_obf,
            )
        )
        if len(rows) > 1 and rows[0].distance == rows[1].distance:
            stats["tied_best_function"] += 1
            continue
        chosen = rows[0]
        stats["functions_considered"] += 1
        if len(rows) == 1:
            stats["unique_function_owner"] += 1
        else:
            stats["shared_function_owner"] += 1
        if chosen.strings:
            selected.append(chosen)
            stats["selected_with_strings"] += 1
        else:
            stats["selected_without_strings"] += 1
        if HASH_METHOD_RE.fullmatch(chosen.mapped_name):
            stats["hash_selected"] += 1
        else:
            stats["semantic_selected"] += 1
    return selected, dict(stats)


def extract_signal(strings: list[str]) -> dict:
    features: set[str] = set()
    accessor_counts: collections.Counter[str] = collections.Counter()
    exact_api_counts: collections.Counter[str] = collections.Counter()
    method_counts: collections.Counter[str] = collections.Counter()
    transform_counts: collections.Counter[str] = collections.Counter()
    exception_counts: collections.Counter[str] = collections.Counter()
    literal_counts: collections.Counter[str] = collections.Counter()
    non_accessor_apis = 0
    has_rpc = False

    for raw in strings:
        if not isinstance(raw, str):
            continue
        text = raw.strip()
        if not text:
            continue

        if (
            "RPC" in text
            or "Photon" in text
            or "OnPhotonSerializeView" in text
            or "RaiseEvent" in text
            or "SerializeView" in text
        ):
            has_rpc = True
            features.add("pattern:rpc")

        for match in API_RE.finditer(text):
            type_full, method_name = match.groups()
            type_short = type_full.rsplit(".", 1)[-1]
            clean_method = clean_api_member(method_name)
            exact_api = f"{type_full}::{clean_method}"
            type_api = f"{type_short}::{clean_method}"

            features.add(f"api:{exact_api}")
            features.add(f"type_api:{type_api}")
            exact_api_counts[exact_api] += 1
            method_counts[clean_method] += 1

            accessor = ACCESSOR_RE.match(clean_method)
            if accessor:
                action, prop = accessor.groups()
                normalized = normalize_accessor_name(action, prop)
                if normalized:
                    accessor_counts[normalized] += 1
                    features.add(f"accessor:{normalized}")
                    features.add(f"prop:{action}:{prop}")
            else:
                non_accessor_apis += 1
                features.add(f"method:{clean_method}")

            if "Transform" in type_full or type_short == "Transform":
                transform_counts[clean_method] += 1
                features.add("pattern:transform")

        for match in EXCEPTION_RE.finditer(text):
            exc = match.group(1)
            exception_counts[exc] += 1
            features.add(f"exc:{exc}")

        if len(text) >= 4 and PASCAL_LITERAL_RE.fullmatch(text):
            literal_counts[text] += 1
            features.add(f"lit:{text}")

    return {
        "features": features,
        "accessor_counts": accessor_counts,
        "exact_api_counts": exact_api_counts,
        "method_counts": method_counts,
        "transform_counts": transform_counts,
        "exception_counts": exception_counts,
        "literal_counts": literal_counts,
        "non_accessor_apis": non_accessor_apis,
        "has_rpc": has_rpc,
    }


def is_specific_feature(feature: str) -> bool:
    if feature.startswith("api:"):
        return True
    if feature.startswith("exc:") or feature.startswith("lit:"):
        return True
    if feature.startswith("prop:"):
        prop = feature.rsplit(":", 1)[-1]
        return prop not in GENERIC_PROPS
    return False


def choose_assoc(feature: str, counts: collections.Counter[str], scope: str) -> Assoc | None:
    if not counts:
        return None
    name, count = counts.most_common(1)[0]
    total = sum(counts.values())
    name = sanitize_prediction(name)
    if not name:
        return None
    if scope == "global":
        if count < 3 or (float(count) / float(total)) < 0.80:
            return None
    else:
        if count < 2 or (float(count) / float(total)) < 0.75:
            return None
    return Assoc(name=name, count=count, total=total)


def build_feature_maps(training_records: list[MethodRecord]) -> tuple[dict[str, Assoc], dict[str, dict[str, Assoc]]]:
    global_counts: dict[str, collections.Counter[str]] = collections.defaultdict(collections.Counter)
    class_counts: dict[str, dict[str, collections.Counter[str]]] = collections.defaultdict(
        lambda: collections.defaultdict(collections.Counter)
    )

    for record in training_records:
        signal = extract_signal(record.strings)
        features = signal["features"]
        name = sanitize_prediction(record.mapped_name)
        if not name:
            continue
        for feature in features:
            global_counts[feature][name] += 1
            class_counts[record.semantic_class][feature][name] += 1

    global_assoc: dict[str, Assoc] = {}
    for feature, counts in global_counts.items():
        assoc = choose_assoc(feature, counts, scope="global")
        if assoc:
            global_assoc[feature] = assoc

    class_assoc: dict[str, dict[str, Assoc]] = {}
    for semantic_class, features in class_counts.items():
        by_feature: dict[str, Assoc] = {}
        for feature, counts in features.items():
            assoc = choose_assoc(feature, counts, scope="class")
            if assoc:
                by_feature[feature] = assoc
        if by_feature:
            class_assoc[semantic_class] = by_feature

    return global_assoc, class_assoc


def predict_from_rule(record: MethodRecord, signal: dict) -> Prediction | None:
    ida_name = meaningful_ida_name(record.ida_name)
    if ida_name:
        return Prediction(name=ida_name, category="ida_name", evidence=[record.ida_name or ""])

    apis = signal["exact_api_counts"]
    accessors = signal["accessor_counts"]
    transform_methods = signal["transform_counts"]
    exceptions = signal["exception_counts"]

    if "UnityEngine.AudioSource::Play" in apis:
        return Prediction("PlayAudio", "audio_rule", ["UnityEngine.AudioSource::Play"])
    if "UnityEngine.AudioSource::PlayOneShot" in apis:
        return Prediction("PlayOneShotAudio", "audio_rule", ["UnityEngine.AudioSource::PlayOneShot"])
    if "UnityEngine.AudioSource::Stop" in apis:
        return Prediction("StopAudio", "audio_rule", ["UnityEngine.AudioSource::Stop"])

    if signal["has_rpc"]:
        if any(name in apis for name in ("PhotonNetwork::RaiseEvent", "PhotonView::RPC")):
            return Prediction("SendRpc", "rpc_rule", sorted(apis)[:4])
        if any("Deserialize" in method or "Receive" in method for method in signal["method_counts"]):
            return Prediction("ReceiveRpc", "rpc_rule", sorted(apis)[:4])
        return Prediction("HandleRpc", "rpc_rule", sorted(apis)[:4])

    if "UnityEngine.GameObject::SetActive" in apis:
        return Prediction("SetGameObjectActive", "activation_rule", ["UnityEngine.GameObject::SetActive"])
    if "UnityEngine.Behaviour::set_enabled" in apis:
        return Prediction("set_enabled", "activation_rule", ["UnityEngine.Behaviour::set_enabled"])

    has_set_position = any(name in transform_methods for name in ("set_position", "SetPositionAndRotation"))
    has_set_rotation = any(name in transform_methods for name in ("set_rotation", "SetPositionAndRotation"))
    has_set_local_position = any(
        name in transform_methods for name in ("set_localPosition", "SetLocalPositionAndRotation")
    )
    has_set_local_rotation = any(
        name in transform_methods for name in ("set_localRotation", "SetLocalPositionAndRotation")
    )
    has_transform_gets = any(
        accessor in accessors
        for accessor in (
            "get_position",
            "get_rotation",
            "get_localPosition",
            "get_localRotation",
            "get_localScale",
        )
    )
    if has_set_local_position and has_set_local_rotation:
        return Prediction(
            "ApplyLocalTransform",
            "transform_rule",
            sorted(transform_methods)[:6],
        )
    if has_set_position and has_set_rotation:
        return Prediction(
            "ApplyTransform",
            "transform_rule",
            sorted(transform_methods)[:6],
        )
    if has_transform_gets and transform_methods and (
        has_set_position or has_set_rotation or has_set_local_position or has_set_local_rotation
    ):
        return Prediction(
            "SyncTransform",
            "transform_rule",
            sorted(transform_methods)[:6],
        )

    if accessors:
        accessor_name, accessor_count = accessors.most_common(1)[0]
        action, prop = accessor_name.split("_", 1)
        if accessor_count >= 2:
            return Prediction(accessor_name, "property_rule", [accessor_name])
        if signal["non_accessor_apis"] == 0 and prop not in GENERIC_PROPS:
            return Prediction(accessor_name, "property_rule", [accessor_name])
        if signal["non_accessor_apis"] <= 1 and len(apis) == 1:
            return Prediction(accessor_name, "property_rule", [accessor_name])

    if exceptions:
        if accessors:
            accessor_name = accessors.most_common(1)[0][0]
            _, prop = accessor_name.split("_", 1)
            return Prediction(
                f"Validate{camelize(prop)}",
                "exception_rule",
                sorted(exceptions)[:3],
            )
        return Prediction("ValidateArguments", "exception_rule", sorted(exceptions)[:3])

    return None


def predict_from_feature_maps(
    record: MethodRecord,
    signal: dict,
    global_assoc: dict[str, Assoc],
    class_assoc: dict[str, dict[str, Assoc]],
) -> Prediction | None:
    scores: collections.Counter[str] = collections.Counter()
    evidence: dict[str, list[str]] = collections.defaultdict(list)
    source_weights: dict[str, float] = collections.defaultdict(float)

    for feature in signal["features"]:
        assoc = class_assoc.get(record.semantic_class, {}).get(feature)
        if assoc:
            weight = 6.0 + min(assoc.count, 4) + assoc.ratio * 2.0
            scores[assoc.name] += weight
            source_weights[f"class:{assoc.name}"] += weight
            evidence[assoc.name].append(
                f"class {feature} ({assoc.count}/{assoc.total}) -> {assoc.name}"
            )

        assoc = global_assoc.get(feature)
        if assoc:
            weight = 3.0 + min(assoc.count, 6) * 0.5 + assoc.ratio
            scores[assoc.name] += weight
            source_weights[f"global:{assoc.name}"] += weight
            evidence[assoc.name].append(
                f"global {feature} ({assoc.count}/{assoc.total}) -> {assoc.name}"
            )

    if not scores:
        return None

    ranked = scores.most_common(2)
    best_name, best_score = ranked[0]
    second_score = ranked[1][1] if len(ranked) > 1 else 0.0
    if best_score < 6.0 or best_score < second_score + 2.5:
        return None

    category = "feature_rule"
    if source_weights.get(f"class:{best_name}", 0.0) >= source_weights.get(f"global:{best_name}", 0.0):
        category = "class_feature"
    elif source_weights.get(f"global:{best_name}", 0.0) > 0.0:
        category = "global_feature"

    return Prediction(best_name, category, evidence[best_name][:5])


def emit_predictions(
    target_records: list[MethodRecord],
    global_assoc: dict[str, Assoc],
    class_assoc: dict[str, dict[str, Assoc]],
) -> tuple[dict[str, str], list[tuple[str, Prediction]], dict[str, int]]:
    predictions: dict[str, str] = {}
    annotated: list[tuple[str, Prediction]] = []
    stats = collections.Counter()

    for record in sorted(target_records, key=lambda row: (row.semantic_class, row.output_key)):
        stats["candidates_considered"] += 1
        signal = extract_signal(record.strings)

        prediction = predict_from_rule(record, signal)
        if prediction is None:
            prediction = predict_from_feature_maps(record, signal, global_assoc, class_assoc)
        if prediction is None:
            stats["no_prediction"] += 1
            continue

        cleaned = sanitize_prediction(prediction.name)
        if not cleaned:
            stats["invalid_prediction"] += 1
            continue

        output_key = record.output_key
        predictions[output_key] = cleaned
        annotated.append((output_key, Prediction(cleaned, prediction.category, prediction.evidence)))
        stats["predictions_emitted"] += 1
        stats[f"category:{prediction.category}"] += 1

    return predictions, annotated, dict(stats)


def print_report(
    runtime_base: int,
    collect_stats: dict[str, int],
    select_stats: dict[str, int],
    training_records: list[MethodRecord],
    target_records: list[MethodRecord],
    predictions: dict[str, str],
    annotated: list[tuple[str, Prediction]],
    emit_stats: dict[str, int],
) -> None:
    print(f"Runtime image base: 0x{runtime_base:X}")
    print("Coverage:")
    print(f"  name_mapping methods: {collect_stats.get('methods_in_map', 0):,}")
    print(f"  mapped to IDA functions: {collect_stats.get('records_mapped', 0):,}")
    print(f"  tied-best functions skipped: {select_stats.get('tied_best_function', 0):,}")
    print(f"  unique-best selected with strings: {select_stats.get('selected_with_strings', 0):,}")
    print(f"  training records: {len(training_records):,}")
    print(f"  target candidates considered: {len(target_records):,}")

    print("Results:")
    print(f"  predictions emitted: {len(predictions):,}")
    print(f"  no prediction: {emit_stats.get('no_prediction', 0):,}")
    print("By category:")
    for key, value in sorted(
        ((key[9:], value) for key, value in emit_stats.items() if key.startswith("category:")),
        key=lambda item: (-item[1], item[0]),
    ):
        print(f"  {key}: {value:,}")

    print("Samples:")
    for output_key, prediction in annotated[:20]:
        evidence = prediction.evidence[0] if prediction.evidence else ""
        print(f"  {output_key} -> {prediction.name} [{prediction.category}] {evidence}")


def main() -> int:
    args = parse_args()

    precise_dump = load_json(args.precise)
    name_map = load_json(args.name_map)
    ida_json = load_json(args.ida)
    ida_functions = ida_json.get("functions", {}) or {}
    if not ida_functions:
        print("No IDA functions found.", file=sys.stderr)
        return 1

    pe = PEImage(Path(args.dll))
    runtime_base = pe.infer_runtime_base(precise_dump)

    all_records, collect_stats = collect_records(
        precise_dump=precise_dump,
        name_map=name_map,
        ida_functions=ida_functions,
        runtime_base=runtime_base,
        max_func_distance=args.max_func_distance,
    )
    selected_records, select_stats = select_unique_best_records(all_records)

    training_records = [
        record for record in selected_records if not HASH_METHOD_RE.fullmatch(record.mapped_name)
    ]
    target_records = [
        record for record in selected_records if HASH_METHOD_RE.fullmatch(record.mapped_name)
    ]

    global_assoc, class_assoc = build_feature_maps(training_records)
    predictions, annotated, emit_stats = emit_predictions(
        target_records=target_records,
        global_assoc=global_assoc,
        class_assoc=class_assoc,
    )

    save_json(args.output, predictions)
    print_report(
        runtime_base=runtime_base,
        collect_stats=collect_stats,
        select_stats=select_stats,
        training_records=training_records,
        target_records=target_records,
        predictions=predictions,
        annotated=annotated,
        emit_stats=emit_stats,
    )
    print(f"Saved: {args.output}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
