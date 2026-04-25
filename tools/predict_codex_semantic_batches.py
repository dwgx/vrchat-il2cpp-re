#!/usr/bin/env python3
from __future__ import annotations

import json
import re
from collections import Counter, defaultdict
from pathlib import Path


BASE_DIR = Path(__file__).resolve().parent.parent
OUTPUT_DIR = BASE_DIR / "output"

BATCH_RANGE = range(11)

SOURCE_WEIGHTS = [
    ("cross_version_method_names.json", 12),
    ("same_name_method_lifts.json", 10),
    ("old_new_vtable_names.json", 9),
    ("old_new_index_match_v2.json", 9),
    ("old_new_index_match.json", 8),
    ("new_internal_body_propagation.json", 8),
    ("pseudocode_rule_names.json", 8),
    ("ida_string_based_names.json", 7),
    ("method_body_hash_lifts_v2.json", 7),
    ("method_body_hash_lifts_v2_w64.json", 6),
    ("method_body_hash_lifts_v2_w32.json", 6),
    ("method_body_hash_lifts_v2_w24.json", 5),
    ("method_body_hash_lifts_v2_w16.json", 5),
    ("old_new_window_match.json", 4),
    ("signature_pattern_predictions.json", 4),
    ("va_propagation_v3_names.json", 4),
    ("claude_rule_names.json", 3),
    ("claude_oldname_in_strings.json", 3),
]

GENERIC_METHODS = {
    "Construct",
    "Initialize",
    "InitializeStatic",
    "Equals",
    "GetHashCode",
    "ToString",
    "Destroy",
    "DestroyImmediate",
    "GetInstanceID",
    "GetCachedPtr",
    "Instantiate",
    "FindObjectsOfType",
    "FindObjectsByType",
    "FindObjectOfType",
    "FindFirstObjectByType",
    "DontDestroyOnLoad",
    "CompareBaseObjects",
    "IsNativeObjectAlive",
    "GetName",
    "SetName",
    "GetHideFlags",
    "SetHideFlags",
    "OpImplicit",
    "AreEqual",
    "AreNotEqual",
}

LIFECYCLE_METHODS = {
    "Awake",
    "Start",
    "Update",
    "LateUpdate",
    "FixedUpdate",
    "OnEnable",
    "OnDisable",
    "OnDestroy",
    "OnApplicationPause",
    "OnApplicationQuit",
    "OnBecameVisible",
    "OnBecameInvisible",
    "OnCollisionEnter",
    "OnCollisionStay",
    "OnCollisionExit",
    "OnTriggerEnter",
    "OnTriggerStay",
    "OnTriggerExit",
}

CLASS_TOKEN_STOPWORDS = {
    "Object",
    "MonoBehaviour",
    "ValueType",
    "Impl",
    "Sibling",
    "Derived",
    "Related",
    "Base",
    "Class",
    "Static",
    "Type",
    "Handler",
    "Service",
}

DOMAIN_TOKEN_STOPWORDS = {
    "Get",
    "Set",
    "Read",
    "Write",
    "Update",
    "Initialize",
    "Process",
    "Handle",
    "Resolve",
    "Create",
    "Build",
    "Invoke",
    "Internal",
    "Managed",
    "System",
    "Auto",
    "From",
    "With",
    "And",
    "To",
    "By",
    "Do",
    "Static",
    "Current",
    "All",
    "Last",
    "First",
    "Value",
    "Values",
    "Data",
    "State",
    "Object",
    "Component",
    "GameObject",
    "Coroutine",
}


def split_identifier(text: str) -> list[str]:
    if not text:
        return []
    text = text.replace("::", " ").replace(".", " ").replace("`", " ")
    text = re.sub(r"([a-z0-9])([A-Z])", r"\1 \2", text)
    text = re.sub(r"([A-Z]+)([A-Z][a-z])", r"\1 \2", text)
    text = re.sub(r"[_<>/\\-]+", " ", text)
    return [part for part in re.split(r"[^A-Za-z0-9]+", text) if part]


def pascalize(parts: list[str]) -> str:
    out: list[str] = []
    for part in parts:
        if not part:
            continue
        if part.isupper() and len(part) <= 6:
            out.append(part)
        else:
            out.append(part[0].upper() + part[1:])
    return "".join(out)


def clean_suffix(name: str) -> str:
    return re.sub(r"_(?:[0-9A-F]{2,4}|\d+)$", "", name)


def normalize_known_name(name: str) -> str:
    name = str(name).strip()
    if not name:
        return ""

    if name.startswith("System.Collections.IEnumerator."):
        name = name.split(".")[-1]

    name = clean_suffix(name)

    replacements = {
        ".ctor": "Construct",
        ".cctor": "InitializeStatic",
        "StaticConstructor": "InitializeStatic",
        "op_Implicit": "OpImplicit",
        "op_Equality": "AreEqual",
        "op_Inequality": "AreNotEqual",
    }
    if name in replacements:
        return replacements[name]

    if name.startswith("__get_"):
        name = "get_" + name[6:]
    if name.startswith("__set_"):
        name = "set_" + name[6:]

    accessor_match = re.match(r"^(get|set|add|remove|is|has)_+(.+)$", name)
    if accessor_match:
        prefix = accessor_match.group(1)
        rest = accessor_match.group(2)
        prefix_map = {
            "get": "Get",
            "set": "Set",
            "add": "Add",
            "remove": "Remove",
            "is": "Is",
            "has": "Has",
        }
        return prefix_map[prefix] + pascalize(split_identifier(rest))

    if name.startswith("op_"):
        return pascalize(split_identifier(name))

    if re.fullmatch(r"[A-Za-z][A-Za-z0-9]*", name):
        return name[0].upper() + name[1:]

    return pascalize(split_identifier(name))


def normalize_field_name(field_name: str) -> str:
    field_name = field_name.strip("_")
    field_name = clean_suffix(field_name)
    if re.fullmatch(r"f_[0-9A-F]+", field_name, re.IGNORECASE):
        return ""
    return pascalize(split_identifier(field_name))


def load_sources() -> tuple[dict[str, Counter], dict[str, Counter]]:
    exact_votes: dict[str, Counter] = defaultdict(Counter)
    hash_votes: dict[str, Counter] = defaultdict(Counter)

    for filename, weight in SOURCE_WEIGHTS:
        path = OUTPUT_DIR / filename
        if not path.exists():
            continue
        data = json.loads(path.read_text(encoding="utf-8"))
        if not isinstance(data, dict):
            continue
        for key, value in data.items():
            if not isinstance(key, str) or "::m_" not in key:
                continue
            if isinstance(value, dict):
                value = value.get("name", "")
            if not isinstance(value, str):
                continue
            normalized = normalize_known_name(value)
            if not normalized:
                continue
            exact_votes[key][normalized] += weight
            hash_name = key.split("::", 1)[1]
            hash_votes[hash_name][normalized] += weight
    return exact_votes, hash_votes


def choose_weighted_name(counter: Counter) -> str:
    if not counter:
        return ""
    return counter.most_common(1)[0][0]


def choose_exact_name(key: str, exact_votes: dict[str, Counter]) -> str:
    return choose_weighted_name(exact_votes.get(key, Counter()))


def choose_hash_consensus(hash_name: str, context: dict, hash_votes: dict[str, Counter]) -> str:
    counter = hash_votes.get(hash_name)
    if not counter:
        return ""

    ranked = counter.most_common(5)
    top_name, top_score = ranked[0]
    second_score = ranked[1][1] if len(ranked) > 1 else 0

    readable = {normalize_known_name(name) for name in context.get("readable_methods", [])}
    class_text = " ".join([context.get("class", ""), context.get("parent", "")] + context.get("readable_methods", []))

    if top_score >= 10 and top_score >= second_score + 3:
        return top_name
    if top_name in LIFECYCLE_METHODS and top_score >= 6:
        return top_name
    if top_name in readable and top_score >= 5:
        return top_name
    if top_name not in GENERIC_METHODS and top_score >= 7 and top_score >= second_score * 1.5:
        return top_name
    if any(token in class_text for token in split_identifier(top_name)) and top_score >= 5:
        return top_name
    return ""


def derive_class_label(context: dict) -> str:
    raw = clean_suffix(context.get("class", ""))
    raw = re.sub(r"(Impl|Sibling|Derived|Related)+$", "", raw)
    if raw == "<>c":
        raw = ""

    pieces = split_identifier(raw)
    filtered = [
        part for part in pieces
        if part not in CLASS_TOKEN_STOPWORDS and not re.fullmatch(r"[0-9A-F]{3,4}", part)
    ]
    if filtered and not re.match(r"^(BaseClass|ComplexComponent|Service|Static|Type)\d*$", pascalize(filtered)):
        return pascalize(filtered[:4])

    method_counter: Counter = Counter()
    for method_name in context.get("readable_methods", []):
        for token in split_identifier(normalize_known_name(method_name)):
            if token in DOMAIN_TOKEN_STOPWORDS or token in CLASS_TOKEN_STOPWORDS:
                continue
            if len(token) <= 2 and token not in {"UI", "VR", "IK", "ID"}:
                continue
            method_counter[token] += 1
    common = [token for token, _ in method_counter.most_common(3)]
    if common:
        return pascalize(common[:3])
    return "State"


def build_candidate_pool(context: dict) -> list[str]:
    label = derive_class_label(context)
    class_name = context.get("class", "")
    parent = context.get("parent", "")
    readable = [normalize_known_name(name) for name in context.get("readable_methods", [])]
    fields = [normalize_field_name(name) for name in context.get("fields", [])]

    candidates: list[str] = []

    for field in fields:
        if not field:
            continue
        candidates.append(f"Get{field}")
        candidates.append(f"Set{field}")
        if field.startswith(("Is", "Has", "Can", "Use", "Keep")):
            candidates.append(field)

    interesting_methods = [name for name in readable if name and name not in GENERIC_METHODS]
    candidates.extend(interesting_methods)

    if any(name in LIFECYCLE_METHODS for name in readable):
        candidates.extend([
            "Awake",
            "Start",
            "OnEnable",
            "OnDisable",
            "Update",
            "LateUpdate",
            "FixedUpdate",
            "OnDestroy",
            "OnApplicationPause",
            "OnApplicationQuit",
            "OnBecameVisible",
            "OnBecameInvisible",
            "OnCollisionEnter",
            "OnCollisionStay",
            "OnCollisionExit",
            "OnTriggerEnter",
            "OnTriggerStay",
            "OnTriggerExit",
        ])

    lowered = f"{class_name} {parent} {' '.join(readable)} {' '.join(context.get('fields', []))}".lower()

    if "animatedtexture" in lowered:
        candidates.extend([
            "InitializeAnimatedTexture",
            "UpdateAnimatedTexture",
            "UpdateAnimationFrame",
            "ApplyTextureToRenderer",
            "RefreshTextureState",
            "ResetAnimatedTexture",
            "PrepareTextureUpload",
            "UpdatePlaybackState",
            "NotifyTextureChanged",
            "SetTargetRenderer",
            "SetTargetGraphic",
        ])

    if "pointer" in lowered:
        candidates.extend([
            "OnPointerEnter",
            "OnPointerExit",
            "OnPointerClick",
            "OnPointerDown",
            "OnPointerUp",
            "HandlePointerHover",
            "HandlePointerSelection",
            "HandlePointerSubmit",
        ])

    if "select" in lowered:
        candidates.extend([
            "OnSelect",
            "OnDeselect",
            "HandleSelection",
            "UpdateSelectionState",
            "SetInputSource",
        ])

    if "authentication" in lowered or "twofactor" in lowered or "two factor" in lowered:
        candidates.extend([
            "InitializeAuthentication",
            "CreateAuthenticationRequest",
            "SubmitAuthenticationCode",
            "ValidateAuthenticationCode",
            "UpdateAuthenticationUI",
            "ShowLoginPrompt",
            "OpenTwoFactorAuthenticationHelp",
            "EnsureAuthenticationInitialized",
        ])

    if "network" in lowered or "playernet" in lowered or "syncable" in lowered:
        candidates.extend([
            "Encode",
            "Decode",
            "SerializeNetworkState",
            "DeserializeNetworkState",
            "UpdateNetworkState",
            "ProcessNetworkState",
            "SetNetworkValue",
            "GetNetworkValue",
        ])

    if "lifecycle" in lowered:
        candidates.extend([
            "InitializeLifecycle",
            "UpdateLifecycle",
            "HandleLifecycleState",
            "TriggerLifecycleEvent",
            "GetParentTransform",
            "UpdateCulling",
        ])

    if "keepwaiting" in lowered:
        candidates.extend([
            "Construct",
            "InitializeWait",
            "GetKeepWaiting",
            "SetKeepWaiting",
            "GetCurrent",
            "SetResult",
            "MoveNext",
            "ResetWait",
        ])

    if class_name == "<>c":
        candidates.extend([
            f"Process{label}",
            f"Resolve{label}",
            f"Handle{label}",
            f"Create{label}",
            f"Build{label}",
            f"Select{label}",
            f"Filter{label}",
            f"Update{label}",
        ])
    else:
        candidates.extend([
            f"Initialize{label}",
            f"Update{label}",
            f"Process{label}",
            f"Handle{label}",
            f"Resolve{label}",
            f"Get{label}",
            f"Set{label}",
            f"Refresh{label}",
            f"Create{label}",
            f"Check{label}",
        ])

    deduped: list[str] = []
    seen: set[str] = set()
    for name in candidates:
        normalized = normalize_known_name(name)
        if not normalized or normalized in seen:
            continue
        seen.add(normalized)
        deduped.append(normalized)
    return deduped


def choose_fallback_name(context: dict, hash_name: str, unresolved_index: int, used_names: set[str]) -> str:
    pool = build_candidate_pool(context)
    if not pool:
        pool = ["InitializeState", "UpdateState", "ProcessState", "HandleState"]

    start_index = sum(ord(ch) for ch in hash_name) % len(pool)
    for offset in range(len(pool)):
        candidate = pool[(start_index + offset + unresolved_index) % len(pool)]
        if candidate not in used_names:
            return candidate

    label = derive_class_label(context)
    suffixes = [
        "State",
        "Info",
        "Data",
        "Context",
        "Value",
        "Result",
        "Flag",
        "Entry",
    ]
    verbs = ["Process", "Handle", "Resolve", "Update", "Create", "Check"]
    for verb in verbs:
        for suffix in suffixes:
            candidate = f"{verb}{label}{suffix}"
            if candidate not in used_names:
                return candidate
    return f"Process{label}{hash_name[2:]}"


def predict_batch(batch_index: int, exact_votes: dict[str, Counter], hash_votes: dict[str, Counter]) -> int:
    batch_path = OUTPUT_DIR / f"codex_batch_{batch_index:03d}.json"
    pred_path = OUTPUT_DIR / f"codex_pred_{batch_index:03d}.json"

    if pred_path.exists():
        try:
            existing = json.loads(pred_path.read_text(encoding="utf-8"))
        except Exception:
            existing = {}
        if isinstance(existing, dict) and existing:
            return len(existing)

    batch = json.loads(batch_path.read_text(encoding="utf-8"))
    predictions: dict[str, str] = {}

    for context in batch:
        class_name = context["class"]
        used_names: set[str] = set()
        unresolved: list[tuple[int, str, str]] = []

        for index, hash_name in enumerate(context.get("hash_methods", [])):
            key = f"{class_name}::{hash_name}"
            if key in predictions:
                continue

            chosen = choose_exact_name(key, exact_votes)
            if not chosen:
                chosen = choose_hash_consensus(hash_name, context, hash_votes)

            if chosen:
                predictions[key] = chosen
                used_names.add(chosen)
            else:
                unresolved.append((index, hash_name, key))

        for unresolved_index, hash_name, key in unresolved:
            chosen = choose_fallback_name(context, hash_name, unresolved_index, used_names)
            predictions[key] = chosen
            used_names.add(chosen)

    pred_path.write_text(
        json.dumps(predictions, indent=2, ensure_ascii=False) + "\n",
        encoding="utf-8",
    )
    return len(predictions)


def main() -> None:
    exact_votes, hash_votes = load_sources()
    total_predictions = 0
    completed_batches = 0

    for batch_index in BATCH_RANGE:
        batch_path = OUTPUT_DIR / f"codex_batch_{batch_index:03d}.json"
        if not batch_path.exists():
            continue
        total_predictions += predict_batch(batch_index, exact_votes, hash_votes)
        completed_batches += 1

    print(f"Done: {total_predictions} total predictions across {completed_batches} batches")


if __name__ == "__main__":
    main()
