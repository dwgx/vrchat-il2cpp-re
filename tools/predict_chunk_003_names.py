#!/usr/bin/env python3
from __future__ import annotations

import json
import re
from collections import Counter, defaultdict
from pathlib import Path


ROOT = Path(__file__).resolve().parent.parent
INPUT = ROOT / "data" / "all_ctx_chunks" / "chunk_003.json"
OUTPUT = ROOT / "output" / "llm_all_chunk_003.json"

HEX_METHOD_RE = re.compile(r"^m_[0-9A-F]+$", re.I)
HEX_CLASS_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$", re.I)
API_RE = re.compile(r"([A-Za-z0-9_.+/]+)::([A-Za-z0-9_]+)\(")
WORD_RE = re.compile(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+")

STOP_WORDS = {
    "a", "an", "and", "are", "as", "at", "be", "bool", "by", "for", "from",
    "if", "in", "into", "it", "new", "not", "null", "of", "on", "or", "out",
    "the", "this", "to", "true", "false", "type", "types", "unityengine", "system",
    "value", "values", "internal", "managed", "lock", "taken", "must", "cannot", "have",
    "delegate", "instance", "method", "error", "errors", "exception", "failed", "invalid",
    "service", "descriptor", "cache", "item", "base", "class", "impl", "sibling",
}

GENERIC_BAD = {
    "Handle", "Process", "Update", "Execute", "Run", "Manage", "Apply", "Check",
    "HandleEvent", "ProcessData", "UpdateState", "HandleMessage",
}

TYPE_DOMAIN_HINTS = {
    "Transform": "Transform",
    "Quaternion": "Rotation",
    "Vector3": "Position",
    "Animator": "Avatar",
    "AudioSource": "Audio",
    "NetworkManager": "Network",
    "Joint": "Joint",
    "ParentConstraint": "Constraint",
    "Input": "Mouse",
    "Time": "Timer",
    "WebCamTexture": "Webcam",
    "Shader": "Shader",
    "Screen": "Screen",
    "GameObject": "GameObject",
    "Component": "Component",
    "NavMeshBuildSource": "NavMeshSource",
}

METHOD_HINTS = {
    "InverseTransformPoint": ("Convert", "LocalPoint"),
    "FromToRotation": ("Align", "Rotation"),
    "get_position": ("Get", "Position"),
    "set_position": ("Set", "Position"),
    "get_rotation": ("Get", "Rotation"),
    "set_rotation": ("Set", "Rotation"),
    "set_localRotation": ("Set", "LocalRotation"),
    "set_localPosition": ("Set", "LocalPosition"),
    "set_localScale": ("Set", "LocalScale"),
    "SetPositionAndRotation": ("Sync", "Transform"),
    "Internal_FromEulerRad": ("Apply", "EulerRotation"),
    "get_deltaTime": ("Update", "Timer"),
    "get_time": ("Record", "Timestamp"),
    "GetMouseButton": ("Track", "MouseHold"),
    "GetMouseButtonDown": ("Begin", "MousePress"),
    "GetMouseButtonUp": ("Complete", "MouseRelease"),
    "get_mousePosition": ("Read", "MousePosition"),
    "get_gameObject": ("Resolve", "GameObject"),
    "set_connectedBody": ("Assign", "ConnectedBody"),
    "PropertyToID": ("Cache", "ShaderPropertyId"),
    "Stop": ("Stop", "Webcam"),
    "get_Last": ("Get", "LastServiceDescriptor"),
    "get_constraintActive": ("Check", "ConstraintActive"),
    "set_translationOffsets": ("Set", "TranslationOffsets"),
    "get_width": ("Read", "ScreenWidth"),
    "get_isHuman": ("Check", "AvatarHuman"),
    "Play": ("Play", "Audio"),
    "SetActive": ("Set", "ActiveState"),
    "get_transform": ("Get", "Transform"),
    "get_localPosition": ("Get", "LocalPosition"),
    "set_enabled": ("Set", "Enabled"),
    "get_enabled": ("Get", "Enabled"),
    "Inverse": ("Invert", "Rotation"),
    "Slerp": ("Interpolate", "Rotation"),
    "SetBlendShapeWeight": ("Set", "BlendShapeWeight"),
    "set_alpha": ("Set", "Alpha"),
    "GetSiblingIndex": ("Get", "SiblingIndex"),
    "ReleaseTemporary": ("Release", "TemporaryRenderTexture"),
    "DrawWireSphere": ("Draw", "WireSphere"),
    "get_stereoTargetEye": ("Read", "StereoTargetEye"),
    "GetDeviceCharacteristics": ("Read", "DeviceCharacteristics"),
    "GetDeviceIdAtXRNode": ("Resolve", "XrNodeDevice"),
    "GetDeviceSerialNumber": ("Read", "DeviceSerialNumber"),
    "HalfToFloat": ("Convert", "HalfToFloat"),
}

CLASS_VERB_HINTS = {
    "Ui": "Update",
    "Manager": "Update",
    "Animator": "Update",
    "Audio": "Play",
    "Network": "Sync",
    "Camera": "Update",
}

ALTERNATE_FAMILIES = {
    "AssignConnectedBody": ["AssignConnectedBody", "LinkConnectedBody", "BindConnectedBody", "ResetConnectedBody"],
    "ResolveGameObject": ["ResolveGameObject", "GetAttachedGameObject", "FetchGameObject", "AccessGameObject"],
    "GetTransform": ["GetTransform", "ResolveTransform", "FetchTransform", "ReadTransform"],
    "ReadWorldPosition": ["ReadWorldPosition", "GetTargetPosition", "FetchWorldPosition", "SampleWorldPosition"],
    "SetGameObjectActive": ["SetGameObjectActive", "EnableGameObject", "ToggleGameObjectActive", "ActivateGameObject"],
    "SetActiveState": ["SetActiveState", "EnableObject", "ToggleActiveState", "ActivateObject"],
    "SetLocalPosition": ["SetLocalPosition", "ApplyLocalPosition", "UpdateLocalPosition", "SyncLocalPosition"],
    "ApplyLocalPose": ["ApplyLocalPose", "SyncLocalPose", "UpdateLocalPose", "SetLocalTransform"],
    "UpdateDeltaTimer": ["UpdateDeltaTimer", "TickDeltaTimer", "AdvanceDeltaTimer", "RefreshDeltaTimer"],
    "SetLocalScale": ["SetLocalScale", "ApplyLocalScale", "UpdateLocalScale", "ScaleTransform"],
    "InvertRotation": ["InvertRotation", "ComputeInverseRotation", "ResolveInverseRotation", "GetInverseRotation"],
    "SetEnabled": ["SetEnabled", "EnableComponent", "ToggleComponentEnabled", "ApplyEnabledState"],
    "StopWebcam": ["StopWebcam", "DisableWebcam", "ShutdownWebcam", "EndWebcamCapture"],
    "GetLastServiceDescriptor": ["GetLastServiceDescriptor", "FetchLastServiceDescriptor", "ResolveLastServiceDescriptor", "ReadLastServiceDescriptor"],
}


def split_words(text: str) -> list[str]:
    return WORD_RE.findall(text or "")


def pascalize(parts: list[str]) -> str:
    out: list[str] = []
    for part in parts:
        for word in split_words(part):
            low = word.lower()
            if not word or low in STOP_WORDS:
                continue
            if word.isupper() and len(word) <= 4:
                out.append(word.title())
            else:
                out.append(word[0].upper() + word[1:])
    return "".join(out)


def normalize_name(name: str | None) -> str | None:
    if not name:
        return None
    name = re.sub(r"[^A-Za-z0-9]+", " ", name)
    name = pascalize(name.split())
    if not name or name in GENERIC_BAD or len(name) < 6:
        return None
    return name


def class_strength(class_name: str) -> str:
    if HEX_CLASS_SUFFIX_RE.search(class_name):
        return "weak"
    return "strong"


def class_tokens(class_name: str) -> list[str]:
    base = HEX_CLASS_SUFFIX_RE.sub("", class_name)
    return [t for t in split_words(base) if t.lower() not in STOP_WORDS]


def extract_apis(strings: list[str]) -> list[tuple[str, str]]:
    apis: list[tuple[str, str]] = []
    for s in strings:
        m = API_RE.search(s)
        if not m:
            continue
        raw_type, raw_method = m.groups()
        type_name = raw_type.split(".")[-1]
        method = raw_method.replace("_Injected", "")
        apis.append((type_name, method))
    return apis


def extract_free_tokens(strings: list[str], callees: list[str], class_name: str) -> Counter:
    counter: Counter = Counter()
    for source in [*strings, *callees, class_name]:
        for token in re.findall(r"[A-Za-z][A-Za-z0-9_]{2,}", source or ""):
            low = token.lower()
            if low in STOP_WORDS or HEX_METHOD_RE.fullmatch(token):
                continue
            counter[pascalize([token])] += 1
    return counter


def infer_from_apis(entry: dict) -> list[tuple[str, float, str]]:
    strings = entry.get("strings", [])
    apis = extract_apis(strings)
    if not apis:
        return []

    type_counts = Counter()
    method_counts = Counter()
    for type_name, method in apis:
        type_counts[type_name] += 1
        method_counts[method] += 1

    results: list[tuple[str, float, str]] = []
    dominant_type = type_counts.most_common(1)[0][0]
    dominant_method = method_counts.most_common(1)[0][0]

    if dominant_method in METHOD_HINTS:
        verb, noun = METHOD_HINTS[dominant_method]
        domain = TYPE_DOMAIN_HINTS.get(dominant_type, "")
        if dominant_method in {"Stop", "Play"}:
            candidate = normalize_name(f"{verb}{noun}")
        elif noun.endswith(domain) or noun.startswith(domain) or noun == domain or not domain:
            candidate = normalize_name(f"{verb}{noun}")
        else:
            candidate = normalize_name(f"{verb}{domain}{noun}")
        if candidate:
            score = 0.90 if len(apis) >= 2 else 0.82
            results.append((candidate, score, "api_hint"))

    # Single-API fallback to widen coverage on weak classes.
    if len(apis) == 1 and dominant_method in METHOD_HINTS:
        verb, noun = METHOD_HINTS[dominant_method]
        candidate = normalize_name(f"{verb}{noun}")
        if candidate:
            results.append((candidate, 0.80, "api_single"))

    methods = set(method_counts)
    if {"get_position", "set_position"} & methods and {"get_rotation", "set_rotation"} & methods:
        results.append(("SyncTransform", 0.94, "transform_sync"))
    if "SetPositionAndRotation" in methods:
        results.append(("SyncPositionAndRotation", 0.93, "transform_combo"))
    if "Internal_FromEulerRad" in methods and "set_localRotation" in methods:
        results.append(("ApplyLocalEulerRotation", 0.93, "euler_rotation"))
    if "set_localPosition" in methods and "set_localRotation" in methods:
        results.append(("ApplyLocalPose", 0.91, "local_pose"))
    if "GetMouseButton" in methods and "GetMouseButtonDown" in methods:
        results.append(("TrackMouseDrag", 0.88, "mouse_drag"))
    if "GetMouseButtonUp" in methods and "get_mousePosition" in methods:
        results.append(("HandleMouseRelease", 0.86, "mouse_release"))
    if "get_deltaTime" in methods and any("byte ptr [rdi +" in (entry.get("body_preview") or "") for _ in [0]):
        results.append(("UpdateCountdown", 0.72, "delta_time"))
    if "get_time" in methods and "GetMouseButton" in methods:
        results.append(("TrackMousePressTiming", 0.84, "mouse_time"))
    if "PropertyToID" in methods:
        results.append(("CacheShaderPropertyIds", 0.92, "shader_ids"))
    if "set_connectedBody" in methods:
        results.append(("AssignConnectedBody", 0.90, "joint_body"))
    if "get_gameObject" in methods:
        results.append(("ResolveGameObject", 0.84, "gameobject"))
    if "get_position" in methods:
        results.append(("ReadWorldPosition", 0.82, "world_position"))
    if "get_transform" in methods:
        results.append(("GetTransform", 0.82, "transform_ref"))
    if "SetActive" in methods and "get_gameObject" in methods:
        results.append(("SetGameObjectActive", 0.90, "gameobject_active"))
    elif "SetActive" in methods:
        results.append(("SetActiveState", 0.84, "active_state"))
    if "set_localPosition" in methods and "set_localRotation" not in methods:
        results.append(("SetLocalPosition", 0.82, "local_position"))
    if "get_deltaTime" in methods and "get_transform" in methods:
        results.append(("UpdateTrackedTransform", 0.80, "tracked_transform"))
    elif "get_deltaTime" in methods:
        results.append(("UpdateDeltaTimer", 0.78, "delta_time_generic"))
    if "set_localScale" in methods:
        results.append(("SetLocalScale", 0.82, "local_scale"))
    if "Inverse" in methods:
        results.append(("InvertRotation", 0.80, "inverse_rotation"))
    if "set_enabled" in methods:
        results.append(("SetEnabled", 0.83, "set_enabled"))
    if "get_enabled" in methods and "get_gameObject" in methods:
        results.append(("CheckGameObjectEnabled", 0.82, "enabled_state"))
    if "Stop" in methods and dominant_type == "WebCamTexture":
        results.append(("StopWebcam", 0.90, "webcam_stop"))
    if "get_Last" in methods:
        results.append(("GetLastServiceDescriptor", 0.88, "get_last"))

    return results


def infer_from_callees(entry: dict) -> list[tuple[str, float, str]]:
    callees = entry.get("callees_named", [])
    if not callees:
        return []

    results: list[tuple[str, float, str]] = []
    joined = " | ".join(callees)
    if "ParentConstraint::get_constraintActive" in joined and "ParentConstraint::set_translationOffsets" in joined:
        results.append(("UpdateConstraintOffsets", 0.92, "constraint_offsets"))
    if "ServiceDescriptorCacheItem::get_Last" in joined:
        results.append(("GetLastServiceDescriptor", 0.88, "service_descriptor"))
    if "Quaternion::FromToRotation_Injected" in joined:
        results.append(("AlignRotation", 0.76, "callee_rotation"))
    return results


def infer_from_text(entry: dict) -> list[tuple[str, float, str]]:
    strings = entry.get("strings", [])
    if not strings:
        return []

    text = " | ".join(strings)
    results: list[tuple[str, float, str]] = []
    if "lockTaken must be false" in text:
        results.append(("ValidateLockState", 0.90, "lock_validation"))
    if "Delegate to an instance method cannot have null 'this'." in text:
        results.append(("ValidateDelegateTarget", 0.91, "delegate_validation"))
    return results


def infer_from_class_and_tokens(entry: dict) -> list[tuple[str, float, str]]:
    class_name = entry.get("class", "")
    strength = class_strength(class_name)
    token_counts = extract_free_tokens(entry.get("strings", []), entry.get("callees_named", []), class_name)
    if not token_counts:
        return []

    top = [token for token, _ in token_counts.most_common(3) if token and token not in {"UnityEngine", "System"}]
    if not top:
        return []

    class_words = class_tokens(class_name)
    verb = None
    for word in class_words:
        if word in CLASS_VERB_HINTS:
            verb = CLASS_VERB_HINTS[word]
            break
    if not verb:
        verb = "Update" if strength == "strong" else "Handle"

    candidate = normalize_name(verb + "".join(top[:2]))
    if not candidate:
        return []
    score = 0.70 if strength == "strong" else 0.60
    return [(candidate, score, "class_tokens")]


def score_entry(entry: dict) -> list[tuple[str, float, str]]:
    candidates = []
    candidates.extend(infer_from_apis(entry))
    candidates.extend(infer_from_callees(entry))
    candidates.extend(infer_from_text(entry))
    candidates.extend(infer_from_class_and_tokens(entry))

    merged: dict[str, tuple[float, str]] = {}
    for name, score, reason in candidates:
        name = normalize_name(name)
        if not name:
            continue
        existing = merged.get(name)
        if not existing or score > existing[0]:
            merged[name] = (score, reason)
    return sorted(((name, score, reason) for name, (score, reason) in merged.items()), key=lambda x: (-x[1], x[0]))


def pick_prediction(entry: dict, used_in_class: set[str]) -> tuple[str | None, float, str]:
    strength = class_strength(entry.get("class", ""))
    threshold = 0.72 if strength == "strong" else 0.76

    for name, score, reason in score_entry(entry):
        if score < threshold:
            continue
        if name not in used_in_class:
            return name, score, reason
        for alt in ALTERNATE_FAMILIES.get(name, []):
            alt = normalize_name(alt)
            if alt and alt not in used_in_class:
                return alt, score - 0.01, f"{reason}_alt"
    return None, 0.0, ""


def main() -> int:
    data = json.loads(INPUT.read_text(encoding="utf-8"))
    grouped: dict[str, list[tuple[str, dict]]] = defaultdict(list)
    for key, entry in data.items():
        grouped[entry.get("class", "")].append((key, entry))

    predictions: dict[str, str] = {}
    meta: list[tuple[str, str, float, str]] = []

    for class_name in sorted(grouped):
        used: set[str] = set()
        items = grouped[class_name]
        for key, entry in items:
            name, score, reason = pick_prediction(entry, used)
            if not name:
                continue
            predictions[key] = name
            used.add(name)
            meta.append((key, name, score, reason))

    OUTPUT.write_text(json.dumps(dict(sorted(predictions.items())), indent=2, ensure_ascii=False), encoding="utf-8")

    meta.sort(key=lambda row: (-row[2], row[0]))
    print(f"Predicted {len(predictions)} names")
    for key, name, score, reason in meta[:5]:
        print(f"{key} -> {name} [{score:.2f} via {reason}]")
    print(f"Wrote {OUTPUT}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
