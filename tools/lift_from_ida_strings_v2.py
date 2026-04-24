#!/usr/bin/env python3
"""Aggressively lift NEW hash-method names from IDA string references.

Outputs:
  output/ida_strings_v2_names.json

Report:
  Prints target coverage, emitted predictions, confidence/category counts, and samples.
"""

from __future__ import annotations

import argparse
import bisect
import collections
import hashlib
import json
import math
import re
import sys
from dataclasses import dataclass
from pathlib import Path
from urllib.parse import urlparse

import pefile


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


ROOT = Path(__file__).resolve().parent.parent
DEFAULT_PRECISE = ROOT / "data" / "precise_dump.json"
DEFAULT_NAME_MAP = ROOT / "output" / "name_mapping.json"
DEFAULT_IDA = ROOT / "output" / "v_new_ida" / "ida_analysis.json"
DEFAULT_DLL = ROOT / "ida_new" / "GameAssembly.dll"
DEFAULT_OUTPUT = ROOT / "output" / "ida_strings_v2_names.json"

IDA_BASE = 0x180000000
MAX_FUNC_DISTANCE = 0x200

HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$", re.I)
API_RE = re.compile(r"([A-Za-z0-9_.+/`<>-]+)::([A-Za-z0-9_]+)\(")
ACCESSOR_RE = re.compile(r"^(get|set)_([A-Za-z][A-Za-z0-9_]*)$")
EXCEPTION_RE = re.compile(r"\b([A-Za-z]+Exception)\b")
ARG_NULL_PARAM_RE = re.compile(
    r'ArgumentNullException\((?:"|\')?([A-Za-z_][A-Za-z0-9_]*)',
    re.I,
)
ENUM_RE = re.compile(r"\b([A-Z][A-Za-z0-9]+)\.([A-Z][A-Za-z0-9]+)\b")
URL_RE = re.compile(r"https?://[^\s\"']+")
API_PATH_RE = re.compile(r"\bapi/[A-Za-z0-9/_-]+\b", re.I)
DEBUG_LABEL_RE = re.compile(r"\b([A-Za-z][A-Za-z0-9]{2,48})=")
PASCAL_LITERAL_RE = re.compile(r"^[A-Z][A-Za-z0-9_]{3,80}$")
CAMEL_PARAM_RE = re.compile(r"^[a-z][A-Za-z0-9_]{2,40}$")
HUMAN_TEXT_RE = re.compile(r"[A-Za-z]{3,}")
VALID_PREDICTION_RE = re.compile(
    r"^(?:[A-Z][A-Za-z0-9_]{1,80}|(?:get|set)_[A-Za-z][A-Za-z0-9_]{1,80})$"
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
        "name",
    }
)

GENERIC_METHOD_NAMES = frozenset(
    {
        "Initialize",
        "Update",
        "LateUpdate",
        "FixedUpdate",
        "Awake",
        "Start",
        "OnEnable",
        "OnDisable",
        "OnDestroy",
        "GetInstanceID",
        "IsInvoking",
        "CancelInvoke",
        "CompareBaseObjects",
        "GetCachedPtr",
        "StartCoroutine",
        "StartCoroutine_Auto",
        "InvokeRepeating",
        "RaiseCancellation",
        "StopCoroutine",
        "StopAllCoroutines",
        "GetHashCodeOfPtr",
        "InternalGetHashCode",
        "DefaultEquals",
        "Print",
        "Destroy",
        "DestroyImmediate",
        "Instantiate",
        "Op_Implicit",
        "Op_Equality",
    }
)

NOISY_PARAM_WORDS = frozenset(
    {
        "obj",
        "this",
        "value",
        "arg",
        "args",
        "index",
        "count",
        "array",
        "list",
        "item",
        "node",
        "lockTaken",
    }
)

UI_ACTION_WORDS = {
    "connect": "Connect",
    "disconnect": "Disconnect",
    "login": "Login",
    "logout": "Logout",
    "join": "Join",
    "leave": "Leave",
    "save": "Save",
    "load": "Load",
    "play": "Play",
    "pause": "Pause",
    "resume": "Resume",
    "retry": "Retry",
    "refresh": "Refresh",
    "accept": "Accept",
    "cancel": "Cancel",
    "open": "Open",
    "close": "Close",
    "show": "Show",
    "hide": "Hide",
    "toggle": "Toggle",
    "start": "Start",
    "stop": "Stop",
    "create": "Create",
    "delete": "Delete",
}


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
class Candidate:
    name: str
    score: float
    category: str
    evidence: str


@dataclass(slots=True)
class ResolvedPrediction:
    name: str
    confidence: float
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
    parser.add_argument("--min-confidence", type=float, default=0.50)
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


def split_identifier(text: str) -> list[str]:
    text = text.replace("::", "_")
    text = re.sub(r"([a-z0-9])([A-Z])", r"\1_\2", text)
    parts = re.split(r"[_\W]+", text)
    return [part for part in parts if part]


def pascalize_words(words: list[str]) -> str:
    return "".join(word[:1].upper() + word[1:] for word in words if word)


def looks_human_text(text: str) -> bool:
    if len(text) < 5 or len(text) > 120:
        return False
    if "::" in text:
        return False
    if any(ord(ch) < 32 for ch in text):
        return False
    return bool(HUMAN_TEXT_RE.search(text))


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
            if record.strings:
                stats["hash_records_with_strings"] += 1
        else:
            stats["semantic_records_mapped"] += 1
            if record.strings:
                stats["semantic_records_with_strings"] += 1

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
    return selected, dict(stats)


def extract_signal(strings: list[str]) -> dict:
    features: set[str] = set()
    accessor_counts: collections.Counter[str] = collections.Counter()
    exact_api_counts: collections.Counter[str] = collections.Counter()
    method_counts: collections.Counter[str] = collections.Counter()
    type_counts: collections.Counter[str] = collections.Counter()
    exception_counts: collections.Counter[str] = collections.Counter()
    standalone_literals: collections.Counter[str] = collections.Counter()
    param_literals: collections.Counter[str] = collections.Counter()
    enum_refs: collections.Counter[str] = collections.Counter()
    endpoint_tokens: collections.Counter[str] = collections.Counter()
    debug_labels: collections.Counter[str] = collections.Counter()
    ui_actions: collections.Counter[str] = collections.Counter()
    collection_types: collections.Counter[str] = collections.Counter()
    raw_texts: list[str] = []
    non_accessor_apis = 0

    has_rpc = False
    has_wait_for_seconds = False
    has_dynamic_invoke = False
    has_button = False
    has_set_active = False
    has_debug_log = False

    for raw in strings:
        if not isinstance(raw, str):
            continue
        text = raw.strip()
        if not text:
            continue
        raw_texts.append(text)

        if (
            "RPC" in text
            or "Photon" in text
            or "OnPhotonSerializeView" in text
            or "RaiseEvent" in text
            or "SerializeView" in text
        ):
            has_rpc = True
            features.add("pattern:rpc")

        if "WaitForSeconds" in text:
            has_wait_for_seconds = True
            features.add("pattern:coroutine")

        if "DynamicInvoke" in text:
            has_dynamic_invoke = True
            features.add("pattern:dynamic_invoke")

        if "UnityEngine.UI.Button" in text:
            has_button = True
            features.add("pattern:button")

        if "Debug.Log" in text or "UnityEngine.Debug::Log" in text:
            has_debug_log = True
            features.add("pattern:debug_log")

        if "GameObject::SetActive" in text:
            has_set_active = True
            features.add("pattern:set_active")

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
            type_counts[type_short] += 1

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

            if "System.Collections.Generic.List" in type_full:
                features.add("pattern:list")
                generic_match = re.search(r"List`1<([^>]+)>", type_full)
                if generic_match:
                    leaf = generic_match.group(1).rsplit(".", 1)[-1]
                    collection_types[leaf] += 1

        for match in EXCEPTION_RE.finditer(text):
            exc = match.group(1)
            exception_counts[exc] += 1
            features.add(f"exc:{exc}")

        for match in ARG_NULL_PARAM_RE.finditer(text):
            param = match.group(1)
            param_literals[param] += 1
            features.add(f"param:{param}")

        if CAMEL_PARAM_RE.fullmatch(text):
            param_literals[text] += 1
            features.add(f"param:{text}")

        if PASCAL_LITERAL_RE.fullmatch(text):
            standalone_literals[text] += 1
            features.add(f"lit:{text}")

        for match in ENUM_RE.finditer(text):
            enum_name, value_name = match.groups()
            key = f"{enum_name}:{value_name}"
            enum_refs[key] += 1
            features.add(f"enum:{enum_name}")

        for match in URL_RE.finditer(text):
            endpoint = endpoint_to_name(match.group(0))
            if endpoint:
                endpoint_tokens[endpoint] += 1
                features.add(f"url:{endpoint}")

        for match in API_PATH_RE.finditer(text):
            endpoint = endpoint_to_name(match.group(0))
            if endpoint:
                endpoint_tokens[endpoint] += 1
                features.add(f"url:{endpoint}")

        for match in DEBUG_LABEL_RE.finditer(text):
            label = camelize(match.group(1))
            if label:
                debug_labels[label] += 1
                features.add(f"debug:{label}")

        ui_action = ui_text_to_name(text)
        if ui_action:
            ui_actions[ui_action] += 1
            features.add(f"ui:{ui_action}")

    return {
        "features": features,
        "accessor_counts": accessor_counts,
        "exact_api_counts": exact_api_counts,
        "method_counts": method_counts,
        "type_counts": type_counts,
        "exception_counts": exception_counts,
        "standalone_literals": standalone_literals,
        "param_literals": param_literals,
        "enum_refs": enum_refs,
        "endpoint_tokens": endpoint_tokens,
        "debug_labels": debug_labels,
        "ui_actions": ui_actions,
        "collection_types": collection_types,
        "raw_texts": raw_texts,
        "non_accessor_apis": non_accessor_apis,
        "has_rpc": has_rpc,
        "has_wait_for_seconds": has_wait_for_seconds,
        "has_dynamic_invoke": has_dynamic_invoke,
        "has_button": has_button,
        "has_set_active": has_set_active,
        "has_debug_log": has_debug_log,
    }


def endpoint_to_name(url_or_path: str) -> str | None:
    if not url_or_path:
        return None
    text = url_or_path.strip()
    if text.startswith("http://") or text.startswith("https://"):
        parsed = urlparse(text)
        path = parsed.path or ""
    else:
        path = text
    pieces = [
        piece
        for piece in re.split(r"[/._-]+", path)
        if piece and piece.lower() not in {"api", "v1", "v2", "v3", "web", "json"}
    ]
    pieces = [piece for piece in pieces if not piece.isdigit()]
    if not pieces:
        return None
    return pascalize_words([piece[:1].upper() + piece[1:] for piece in pieces[-2:]])


def ui_text_to_name(text: str) -> str | None:
    if not looks_human_text(text):
        return None
    lowered = text.lower()
    words = re.findall(r"[a-z]+", lowered)
    if not words:
        return None
    action = None
    for word in words:
        if word in UI_ACTION_WORDS:
            action = UI_ACTION_WORDS[word]
            break
    if not action:
        return None
    if "click" in words or "button" in words:
        return f"On{action}Click"
    return action


def name_specificity(name: str, name_freq: collections.Counter[str]) -> float:
    score = 0.55
    if name in GENERIC_METHOD_NAMES:
        score -= 0.22
    if name.startswith(("On", "get_", "set_")) and len(name) <= 14:
        score -= 0.08
    freq = name_freq.get(name, 0)
    if freq:
        score -= min(0.28, math.log10(freq + 1) * 0.12)
    if "_" in name and not name.startswith(("get_", "set_")):
        score += 0.05
    if len(name) >= 14:
        score += 0.07
    if any(
        token in name.lower()
        for token in (
            "transform",
            "connect",
            "playback",
            "status",
            "mouse",
            "node",
            "gameobject",
            "texture",
            "language",
            "network",
            "player",
            "state",
            "audio",
            "buffer",
            "delegate",
            "invoke",
            "track",
            "resolve",
            "config",
            "parent",
        )
    ):
        score += 0.08
    return max(0.05, min(0.95, score))


def choose_assoc(feature: str, counts: collections.Counter[str], scope: str) -> Assoc | None:
    if not counts:
        return None
    name, count = counts.most_common(1)[0]
    total = sum(counts.values())
    name = sanitize_prediction(name)
    if not name:
        return None
    if scope == "global":
        if count < 2 or (float(count) / float(total)) < 0.82:
            return None
    else:
        if count < 2 or (float(count) / float(total)) < 0.74:
            return None
    return Assoc(name=name, count=count, total=total)


def build_feature_maps(training_records: list[MethodRecord]) -> tuple[dict[str, Assoc], dict[str, dict[str, Assoc]]]:
    global_counts: dict[str, collections.Counter[str]] = collections.defaultdict(collections.Counter)
    class_counts: dict[str, dict[str, collections.Counter[str]]] = collections.defaultdict(
        lambda: collections.defaultdict(collections.Counter)
    )

    for record in training_records:
        signal = extract_signal(record.strings)
        name = sanitize_prediction(record.mapped_name)
        if not name:
            continue
        for feature in signal["features"]:
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


def build_function_hints(all_records: list[MethodRecord]) -> tuple[dict[str, collections.Counter[str]], collections.Counter[str]]:
    by_func: dict[str, collections.Counter[str]] = collections.defaultdict(collections.Counter)
    name_freq: collections.Counter[str] = collections.Counter()

    for record in all_records:
        if not record.strings:
            continue
        if HASH_METHOD_RE.fullmatch(record.mapped_name):
            continue
        name = sanitize_prediction(record.mapped_name)
        if not name:
            continue
        by_func[record.func_key][name] += 1
        name_freq[name] += 1

    return by_func, name_freq


def add_candidate(pool: list[Candidate], name: str | None, score: float, category: str, evidence: str) -> None:
    cleaned = sanitize_prediction(name)
    if not cleaned:
        return
    pool.append(Candidate(cleaned, max(0.01, min(0.99, score)), category, evidence))


def predict_from_same_function(
    record: MethodRecord,
    func_hints: dict[str, collections.Counter[str]],
    name_freq: collections.Counter[str],
) -> list[Candidate]:
    counts = func_hints.get(record.func_key)
    if not counts:
        return []
    ranked = counts.most_common(2)
    best_name, best_count = ranked[0]
    second_count = ranked[1][1] if len(ranked) > 1 else 0
    total = sum(counts.values())
    ratio = float(best_count) / float(total)
    margin = best_count - second_count
    specificity = name_specificity(best_name, name_freq)
    score = 0.16 + ratio * 0.34 + min(margin, 4) * 0.05 + specificity * 0.30
    if best_count >= 2:
        score += 0.08
    evidence = f"same_func {best_name} ({best_count}/{total})"
    return [Candidate(best_name, score, "same_func", evidence)]


def predict_from_direct_rules(
    record: MethodRecord,
    signal: dict,
    name_freq: collections.Counter[str],
) -> list[Candidate]:
    candidates: list[Candidate] = []
    ida_name = meaningful_ida_name(record.ida_name)
    if ida_name:
        add_candidate(candidates, ida_name, 0.98, "ida_name", record.ida_name or "")

    apis = signal["exact_api_counts"]
    accessors = signal["accessor_counts"]
    exceptions = signal["exception_counts"]
    methods = signal["method_counts"]

    if "UnityEngine.AudioSource::Play" in apis:
        add_candidate(candidates, "PlayAudio", 0.86, "audio_rule", "UnityEngine.AudioSource::Play")
    if "UnityEngine.AudioSource::PlayOneShot" in apis:
        add_candidate(candidates, "PlayOneShotAudio", 0.90, "audio_rule", "UnityEngine.AudioSource::PlayOneShot")
    if "UnityEngine.AudioSource::Stop" in apis:
        add_candidate(candidates, "StopAudio", 0.86, "audio_rule", "UnityEngine.AudioSource::Stop")

    if signal["has_rpc"]:
        if any(name in apis for name in ("PhotonNetwork::RaiseEvent", "PhotonView::RPC")):
            add_candidate(candidates, "SendRpc", 0.84, "rpc_rule", "Photon RPC")
        elif any("Deserialize" in method or "Receive" in method for method in methods):
            add_candidate(candidates, "ReceiveRpc", 0.80, "rpc_rule", "Deserialize/Receive + RPC")
        else:
            add_candidate(candidates, "HandleRpc", 0.72, "rpc_rule", "RPC markers")

    if "UnityEngine.GameObject::SetActive" in apis:
        base_name = "SetGameObjectActive"
        if signal["has_button"] and signal["ui_actions"]:
            ui_name = signal["ui_actions"].most_common(1)[0][0]
            add_candidate(candidates, ui_name, 0.76, "ui_rule", "Button + SetActive + UI text")
        add_candidate(candidates, base_name, 0.74, "activation_rule", "UnityEngine.GameObject::SetActive")
        if any(name in apis for name in ("UnityEngine.GameObject::get_activeSelf", "UnityEngine.GameObject::get_activeInHierarchy")):
            add_candidate(candidates, "ToggleActive", 0.61, "ui_rule", "SetActive + activeSelf/activeInHierarchy")
    if "UnityEngine.Behaviour::set_enabled" in apis:
        add_candidate(candidates, "set_enabled", 0.76, "activation_rule", "UnityEngine.Behaviour::set_enabled")

    has_set_position = any(name in methods for name in ("set_position", "SetPositionAndRotation"))
    has_set_rotation = any(name in methods for name in ("set_rotation", "SetPositionAndRotation"))
    has_set_local_position = any(name in methods for name in ("set_localPosition", "SetLocalPositionAndRotation"))
    has_set_local_rotation = any(name in methods for name in ("set_localRotation", "SetLocalPositionAndRotation"))
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
        add_candidate(candidates, "ApplyLocalTransform", 0.84, "transform_rule", "set_localPosition + set_localRotation")
    if has_set_position and has_set_rotation:
        add_candidate(candidates, "ApplyTransform", 0.84, "transform_rule", "set_position + set_rotation")
    if has_transform_gets and (has_set_position or has_set_rotation or has_set_local_position or has_set_local_rotation):
        add_candidate(candidates, "SyncTransform", 0.76, "transform_rule", "transform get/set mix")

    if accessors:
        accessor_name, accessor_count = accessors.most_common(1)[0]
        _, prop = accessor_name.split("_", 1)
        score = 0.56
        if accessor_count >= 2:
            score += 0.12
        if prop not in GENERIC_PROPS:
            score += 0.08
        if signal["non_accessor_apis"] == 0:
            score += 0.08
        add_candidate(candidates, accessor_name, score, "property_rule", accessor_name)

    if signal["has_dynamic_invoke"]:
        add_candidate(candidates, "Invoke", 0.73, "invoke_rule", "DynamicInvoke")
        add_candidate(candidates, "Dispatch", 0.66, "invoke_rule", "DynamicInvoke")

    if signal["has_wait_for_seconds"]:
        add_candidate(candidates, "RunCoroutine", 0.64, "coroutine_rule", "WaitForSeconds")
        if signal["ui_actions"]:
            ui_name = signal["ui_actions"].most_common(1)[0][0]
            add_candidate(candidates, f"{ui_name}Coroutine", 0.68, "coroutine_rule", f"WaitForSeconds + {ui_name}")

    if "Add" in methods and signal["collection_types"]:
        element = signal["collection_types"].most_common(1)[0][0]
        add_candidate(candidates, f"Add{camelize(element)}", 0.70, "collection_rule", f"List + Add<{element}>")
        add_candidate(candidates, "AddItem", 0.62, "collection_rule", "List + Add")
    if "Clear" in methods:
        add_candidate(candidates, "ClearItems", 0.66, "collection_rule", "List + Clear")
    if "Remove" in methods:
        add_candidate(candidates, "RemoveItem", 0.66, "collection_rule", "List + Remove")

    if "SetParent" in methods:
        add_candidate(candidates, "SetParent", 0.77, "method_mining", "Transform::SetParent")
        if "GetParent" in methods or "get_parent" in methods:
            add_candidate(candidates, "Reparent", 0.69, "method_mining", "SetParent + GetParent")

    for literal_name, count in signal["standalone_literals"].most_common(6):
        if literal_name in {"System", "UnityEngine"}:
            continue
        add_candidate(candidates, literal_name, 0.90 if count >= 1 else 0.82, "literal_method", literal_name)

    for label, count in signal["debug_labels"].most_common(4):
        if signal["has_debug_log"]:
            add_candidate(candidates, f"Log{label}", 0.70 + min(count, 3) * 0.04, "debug_rule", f"Debug.Log {label}=")
        add_candidate(candidates, f"Update{label}", 0.57 + min(count, 3) * 0.03, "debug_rule", f"{label}=")

    for endpoint, count in signal["endpoint_tokens"].most_common(3):
        add_candidate(candidates, endpoint, 0.68 + min(count, 2) * 0.05, "endpoint_rule", endpoint)
        add_candidate(candidates, f"Call{endpoint}", 0.60 + min(count, 2) * 0.03, "endpoint_rule", endpoint)

    for enum_ref, count in signal["enum_refs"].most_common(3):
        enum_name, _ = enum_ref.split(":", 1)
        prop = camelize(enum_name)
        add_candidate(candidates, f"Get{prop}", 0.64 + min(count, 2) * 0.03, "enum_rule", enum_ref)
        add_candidate(candidates, f"Set{prop}", 0.61 + min(count, 2) * 0.03, "enum_rule", enum_ref)

    if exceptions:
        if "ArgumentNullException" in exceptions:
            best_param = None
            for param, _ in signal["param_literals"].most_common():
                if param in NOISY_PARAM_WORDS:
                    continue
                best_param = param
                break
            if best_param:
                pretty = camelize(best_param)
                add_candidate(candidates, f"Validate{pretty}", 0.72, "exception_rule", f"ArgumentNullException({best_param})")
            add_candidate(candidates, "ValidateArguments", 0.62, "exception_rule", "ArgumentNullException")
            add_candidate(candidates, "CheckNullArgument", 0.60, "exception_rule", "ArgumentNullException")
        if "IndexOutOfRangeException" in exceptions:
            add_candidate(candidates, "ValidateIndex", 0.70, "exception_rule", "IndexOutOfRangeException")
            add_candidate(candidates, "GetItemAtIndex", 0.57, "exception_rule", "IndexOutOfRangeException")

    for action_name, count in signal["ui_actions"].most_common(3):
        score = 0.66 + min(count, 2) * 0.04
        add_candidate(candidates, action_name, score, "ui_rule", action_name)
        if action_name.startswith("On"):
            add_candidate(candidates, action_name, score + 0.03, "ui_rule", action_name)

    for exact_api, count in apis.most_common(8):
        type_full, raw_method = exact_api.split("::", 1)
        method_name = clean_api_member(raw_method)
        accessor = ACCESSOR_RE.match(method_name)
        if accessor:
            continue
        direct_name = sanitize_prediction(method_name)
        if not direct_name:
            continue
        score = 0.44 + min(count, 3) * 0.04
        if direct_name not in GENERIC_METHOD_NAMES:
            score += 0.09
        score += (name_specificity(direct_name, name_freq) - 0.50) * 0.20
        if type_full.endswith("Transform") and method_name == "SetParent":
            score += 0.08
        add_candidate(candidates, direct_name, score, "method_mining", exact_api)

    return candidates


def predict_from_feature_maps(
    record: MethodRecord,
    signal: dict,
    global_assoc: dict[str, Assoc],
    class_assoc: dict[str, dict[str, Assoc]],
    name_freq: collections.Counter[str],
) -> list[Candidate]:
    candidates: list[Candidate] = []

    for feature in signal["features"]:
        assoc = class_assoc.get(record.semantic_class, {}).get(feature)
        if assoc:
            score = 0.50 + min(assoc.count, 4) * 0.05 + assoc.ratio * 0.18
            score += (name_specificity(assoc.name, name_freq) - 0.50) * 0.10
            add_candidate(
                candidates,
                assoc.name,
                score,
                "class_feature",
                f"class {feature} ({assoc.count}/{assoc.total})",
            )

        assoc = global_assoc.get(feature)
        if assoc:
            score = 0.44 + min(assoc.count, 5) * 0.03 + assoc.ratio * 0.14
            score += (name_specificity(assoc.name, name_freq) - 0.50) * 0.08
            add_candidate(
                candidates,
                assoc.name,
                score,
                "global_feature",
                f"global {feature} ({assoc.count}/{assoc.total})",
            )

    return candidates


def resolve_candidates(candidates: list[Candidate]) -> ResolvedPrediction | None:
    if not candidates:
        return None

    grouped: dict[str, list[Candidate]] = collections.defaultdict(list)
    for candidate in candidates:
        grouped[candidate.name].append(candidate)

    scored: list[tuple[str, float, list[Candidate]]] = []
    for name, rows in grouped.items():
        combined = 1.0
        for row in rows:
            combined *= 1.0 - row.score
        confidence = 1.0 - combined
        scored.append((name, confidence, rows))

    scored.sort(key=lambda item: (-item[1], item[0]))
    best_name, best_confidence, best_rows = scored[0]
    second_confidence = scored[1][1] if len(scored) > 1 else 0.0

    adjusted = best_confidence - second_confidence * 0.35
    adjusted = max(0.0, min(0.99, adjusted))
    if adjusted <= 0.0:
        return None

    best_rows_sorted = sorted(best_rows, key=lambda row: (-row.score, row.category, row.evidence))
    primary_category = best_rows_sorted[0].category
    evidence = [row.evidence for row in best_rows_sorted[:4]]
    return ResolvedPrediction(
        name=best_name,
        confidence=adjusted,
        category=primary_category,
        evidence=evidence,
    )


def emit_predictions(
    target_records: list[MethodRecord],
    func_hints: dict[str, collections.Counter[str]],
    name_freq: collections.Counter[str],
    global_assoc: dict[str, Assoc],
    class_assoc: dict[str, dict[str, Assoc]],
    min_confidence: float,
) -> tuple[dict[str, str], list[tuple[str, ResolvedPrediction]], dict[str, int]]:
    predictions: dict[str, str] = {}
    annotated: list[tuple[str, ResolvedPrediction]] = []
    stats = collections.Counter()

    for record in sorted(target_records, key=lambda row: (row.semantic_class, row.output_key, row.func_key)):
        stats["candidates_considered"] += 1
        signal = extract_signal(record.strings)
        candidate_pool: list[Candidate] = []
        candidate_pool.extend(predict_from_same_function(record, func_hints, name_freq))
        candidate_pool.extend(predict_from_direct_rules(record, signal, name_freq))
        candidate_pool.extend(
            predict_from_feature_maps(
                record=record,
                signal=signal,
                global_assoc=global_assoc,
                class_assoc=class_assoc,
                name_freq=name_freq,
            )
        )

        prediction = resolve_candidates(candidate_pool)
        if prediction is None:
            stats["no_prediction"] += 1
            continue
        if prediction.confidence < min_confidence:
            stats["below_confidence"] += 1
            continue

        predictions[record.output_key] = prediction.name
        annotated.append((record.output_key, prediction))
        stats["predictions_emitted"] += 1
        stats[f"category:{prediction.category}"] += 1
        if prediction.confidence >= 0.80:
            stats["confidence_ge_0.80"] += 1
        elif prediction.confidence >= 0.65:
            stats["confidence_ge_0.65"] += 1
        else:
            stats["confidence_ge_0.50"] += 1

    return predictions, annotated, dict(stats)


def print_report(
    runtime_base: int,
    collect_stats: dict[str, int],
    select_stats: dict[str, int],
    training_records: list[MethodRecord],
    target_records: list[MethodRecord],
    predictions: dict[str, str],
    annotated: list[tuple[str, ResolvedPrediction]],
    emit_stats: dict[str, int],
) -> None:
    print(f"Runtime image base: 0x{runtime_base:X}")
    print("Coverage:")
    print(f"  name_mapping methods: {collect_stats.get('methods_in_map', 0):,}")
    print(f"  mapped to IDA functions: {collect_stats.get('records_mapped', 0):,}")
    print(f"  hash records with strings: {collect_stats.get('hash_records_with_strings', 0):,}")
    print(f"  semantic records with strings: {collect_stats.get('semantic_records_with_strings', 0):,}")
    print(f"  tied-best functions skipped for training: {select_stats.get('tied_best_function', 0):,}")
    print(f"  training records: {len(training_records):,}")
    print(f"  target candidates considered: {len(target_records):,}")

    print("Results:")
    print(f"  predictions emitted: {len(predictions):,}")
    print(f"  below confidence threshold: {emit_stats.get('below_confidence', 0):,}")
    print(f"  no prediction: {emit_stats.get('no_prediction', 0):,}")
    print(f"  confidence >= 0.80: {emit_stats.get('confidence_ge_0.80', 0):,}")
    print(f"  confidence >= 0.65: {emit_stats.get('confidence_ge_0.65', 0):,}")
    print(f"  confidence >= 0.50: {emit_stats.get('confidence_ge_0.50', 0):,}")
    print("By category:")
    for key, value in sorted(
        ((key[9:], value) for key, value in emit_stats.items() if key.startswith("category:")),
        key=lambda item: (-item[1], item[0]),
    ):
        print(f"  {key}: {value:,}")

    print("Samples:")
    for output_key, prediction in annotated[:20]:
        evidence = prediction.evidence[0] if prediction.evidence else ""
        print(f"  {output_key} -> {prediction.name} ({prediction.confidence:.2f}) [{prediction.category}] {evidence}")


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
        record
        for record in selected_records
        if not HASH_METHOD_RE.fullmatch(record.mapped_name) and record.strings
    ]
    target_records = [
        record
        for record in all_records
        if HASH_METHOD_RE.fullmatch(record.mapped_name) and record.strings
    ]

    global_assoc, class_assoc = build_feature_maps(training_records)
    func_hints, name_freq = build_function_hints(all_records)

    predictions, annotated, emit_stats = emit_predictions(
        target_records=target_records,
        func_hints=func_hints,
        name_freq=name_freq,
        global_assoc=global_assoc,
        class_assoc=class_assoc,
        min_confidence=args.min_confidence,
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
