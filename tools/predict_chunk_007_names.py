#!/usr/bin/env python3
from __future__ import annotations

import json
import re
from collections import defaultdict
from pathlib import Path


ROOT = Path(__file__).resolve().parent.parent
INPUT = ROOT / "data" / "all_ctx_chunks" / "chunk_007.json"
OUTPUT = ROOT / "output" / "llm_all_chunk_007.json"

HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4,}$", re.I)
WORD_RE = re.compile(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+")

LOW_SIGNAL_ONLY = {
    "UnityEngine.Component::get_gameObject()",
    "UnityEngine.Component::get_transform()",
    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)",
}

NAME_FAMILIES = {
    "GetLastServiceDescriptor": [
        "GetLastServiceDescriptor",
        "FetchLastServiceDescriptor",
        "ResolveLastServiceDescriptor",
        "ReadLastServiceDescriptor",
        "AccessLastServiceDescriptor",
    ],
    "RunOnThreadPool": [
        "RunOnThreadPool",
        "QueueThreadPoolWork",
        "ContinueOnThreadPool",
        "DispatchThreadPoolWork",
    ],
    "SetGameObjectActive": [
        "SetGameObjectActive",
        "EnableGameObject",
        "ToggleGameObjectActive",
        "ActivateGameObject",
    ],
    "SyncTransform": [
        "SyncTransform",
        "ApplyTransform",
        "UpdateTransformPose",
    ],
    "ApplyTransform": [
        "ApplyTransform",
        "SyncTransformPose",
        "UpdateTransformPose",
    ],
    "SetPosition": [
        "SetPosition",
        "ApplyPosition",
        "UpdatePosition",
        "SyncPosition",
    ],
    "GetPosition": [
        "GetPosition",
        "ReadPosition",
        "FetchPosition",
        "SamplePosition",
    ],
    "SetRotation": [
        "SetRotation",
        "ApplyRotation",
        "UpdateRotation",
        "SyncRotation",
    ],
    "GetRotation": [
        "GetRotation",
        "ReadRotation",
        "FetchRotation",
        "SampleRotation",
    ],
    "SetConnectedBody": [
        "SetConnectedBody",
        "AssignConnectedBody",
        "BindConnectedBody",
        "LinkConnectedBody",
    ],
    "FindRelativeTransform": [
        "FindRelativeTransform",
        "ResolveRelativeTransform",
        "LocateRelativeTransform",
    ],
    "InverseTransformPoint": [
        "InverseTransformPoint",
        "ConvertWorldPointToLocal",
        "TransformPointToLocal",
    ],
    "TransformPoint": [
        "TransformPoint",
        "ConvertLocalPointToWorld",
        "ApplyTransformPoint",
    ],
    "SetLocalPosition": [
        "SetLocalPosition",
        "ApplyLocalPosition",
        "UpdateLocalPosition",
    ],
    "SetLocalScale": [
        "SetLocalScale",
        "ApplyLocalScale",
        "UpdateLocalScale",
    ],
    "InterpolateRotation": [
        "InterpolateRotation",
        "SmoothRotation",
        "BlendRotation",
    ],
    "CheckHumanAvatar": [
        "CheckHumanAvatar",
        "ValidateHumanAvatar",
    ],
    "GetBlendShapeCount": [
        "GetBlendShapeCount",
        "ReadBlendShapeCount",
    ],
    "SetRectTransformSize": [
        "SetRectTransformSize",
        "ApplyRectTransformSize",
        "UpdateRectTransformSize",
    ],
    "GetTransform": [
        "GetTransform",
        "ResolveTransform",
        "FetchTransform",
    ],
    "GetGameObject": [
        "GetGameObject",
        "ResolveGameObject",
        "FetchGameObject",
    ],
}


def split_words(text: str) -> list[str]:
    return WORD_RE.findall(text or "")


def class_base(class_name: str) -> str:
    base = HEX_SUFFIX_RE.sub("", class_name)
    return "".join(split_words(base))


def choose_family_name(base_name: str, class_name: str, used_names: set[str]) -> str | None:
    for candidate in NAME_FAMILIES.get(base_name, [base_name]):
        if candidate not in used_names:
            return candidate

    # Final class-scoped fallback if the family is exhausted.
    suffix = class_base(class_name)
    if suffix:
        candidate = f"{base_name}{suffix}"
        if candidate not in used_names:
            return candidate
    return None


def has(entry: dict, needle: str) -> bool:
    return needle in entry.get("strings", [])


def has_any(entry: dict, needle: str) -> bool:
    return any(needle in s for s in entry.get("strings", []))


def callee_has(entry: dict, needle: str) -> bool:
    return any(needle in c for c in entry.get("callees_named", []))


def is_low_signal(entry: dict) -> bool:
    strings = entry.get("strings", [])
    return bool(strings) and set(strings).issubset(LOW_SIGNAL_ONLY)


def predict_base_name(entry: dict) -> str | None:
    strings = entry.get("strings", [])

    if callee_has(entry, "ServiceDescriptorCacheItem::get_Last"):
        return "GetLastServiceDescriptor"

    if callee_has(entry, "<RunOnThreadPool>d__101::MoveNext"):
        return "RunOnThreadPool"

    if has(entry, "UnityEngine.GameObject::SetActive(System.Boolean)") and has(entry, "UnityEngine.Component::get_gameObject()"):
        return "SetGameObjectActive"

    if all(
        has(entry, s)
        for s in [
            "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)",
            "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)",
            "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)",
            "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)",
        ]
    ):
        return "SyncTransform"

    if has(entry, "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)") and has(entry, "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)"):
        return "ApplyTransform"

    if has_any(entry, "UnityEngine.Quaternion::Slerp_Injected"):
        if has(entry, "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)") or has(entry, "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)"):
            return "InterpolateRotation"

    if has(entry, "UnityEngine.Joint::set_connectedBody(UnityEngine.Rigidbody)"):
        return "SetConnectedBody"

    if has_any(entry, "UnityEngine.Transform::FindRelativeTransformWithPath"):
        return "FindRelativeTransform"

    if has_any(entry, "UnityEngine.Transform::InverseTransformPoint_Injected"):
        return "InverseTransformPoint"

    if has_any(entry, "UnityEngine.Transform::TransformPoint_Injected") and not has_any(entry, "InverseTransformPoint"):
        return "TransformPoint"

    if has_any(entry, "UnityEngine.RectTransform::set_sizeDelta_Injected"):
        return "SetRectTransformSize"

    if has_any(entry, "UnityEngine.Animator::get_isHuman()"):
        return "CheckHumanAvatar"

    if has_any(entry, "UnityEngine.Mesh::get_blendShapeCount()"):
        return "GetBlendShapeCount"

    if has(entry, "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)"):
        return "SetLocalPosition"

    if has(entry, "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)"):
        return "SetLocalScale"

    if has(entry, "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)"):
        return "SetPosition"

    if has(entry, "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)"):
        return "SetRotation"

    if has(entry, "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)") and not is_low_signal(entry):
        return "GetPosition"

    if has(entry, "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)") and not is_low_signal(entry):
        return "GetRotation"

    if has(entry, "UnityEngine.Component::get_transform()") and not is_low_signal(entry):
        return "GetTransform"

    if has(entry, "UnityEngine.Component::get_gameObject()") and not is_low_signal(entry):
        return "GetGameObject"

    return None


def main() -> None:
    data = json.loads(INPUT.read_text(encoding="utf-8"))
    results: dict[str, str] = {}
    used_by_class: dict[str, set[str]] = defaultdict(set)

    for key, entry in sorted(data.items()):
        class_name = entry.get("class", "")
        base_name = predict_base_name(entry)
        if not base_name:
            continue

        chosen = choose_family_name(base_name, class_name, used_by_class[class_name])
        if not chosen:
            continue

        results[key] = chosen
        used_by_class[class_name].add(chosen)

    OUTPUT.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT.write_text(json.dumps(results, indent=2, ensure_ascii=False), encoding="utf-8")

    print(f"count={len(results)}")
    for key in sorted(results)[:5]:
        print(f"{key} -> {results[key]}")


if __name__ == "__main__":
    main()
