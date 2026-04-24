import json
import re
from collections import Counter, defaultdict
from pathlib import Path


INPUT_PATH = Path("data/all_ctx_chunks/chunk_010.json")
OUTPUT_PATH = Path("output/llm_all_chunk_010.json")

HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4,}$", re.I)
GENERIC_CLASS_RE = re.compile(r"^(Service|Static|Type)\d+m\d*f?$", re.I)

LOW_SIGNAL_STRING_ONLY = {
    "UnityEngine.Component::get_gameObject()",
    "UnityEngine.Component::get_transform()",
    "UnityEngine.GameObject::SetActive(System.Boolean)",
    "UnityEngine.Transform::get_localPosition_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)",
}

SYNONYMS = {
    "GetLastServiceDescriptor": [
        "FetchLastServiceDescriptor",
        "ResolveLastServiceDescriptor",
        "ReadLastServiceDescriptor",
        "LoadLastServiceDescriptor",
        "AccessLastServiceDescriptor",
        "AcquireLastServiceDescriptor",
        "FindLastServiceDescriptor",
        "LookupLastServiceDescriptor",
    ],
    "RunOnThreadPool": [
        "QueueThreadPoolWork",
        "DispatchThreadPoolWork",
        "ScheduleThreadPoolWork",
        "ExecuteOnThreadPool",
        "ContinueOnThreadPool",
        "BeginThreadPoolWork",
        "EnqueueThreadPoolWork",
    ],
    "ReadTransformPose": [
        "CaptureTransformPose",
        "SampleTransformPose",
        "FetchTransformPose",
    ],
    "ReadTransformPosition": [
        "CaptureTransformPosition",
        "SampleTransformPosition",
        "FetchTransformPosition",
    ],
    "SetConnectedBody": [
        "AssignConnectedBody",
        "BindConnectedBody",
        "LinkConnectedBody",
    ],
    "SetGameObjectActive": [
        "ApplyGameObjectActive",
        "ToggleGameObjectActive",
        "UpdateGameObjectActive",
    ],
    "SetRendererVisible": [
        "ApplyRendererVisible",
        "UpdateRendererVisible",
    ],
    "CacheAnimatorHash": [
        "ResolveAnimatorHash",
        "BuildAnimatorHash",
    ],
    "TryResolveValue": [
        "TryGetResolvedValue",
        "TryLookupValue",
        "TryFindValue",
    ],
    "StartProfilerRecorder": [
        "CreateProfilerRecorder",
        "BeginProfilerRecorder",
    ],
}


def class_base(class_name: str) -> str:
    base = HEX_SUFFIX_RE.sub("", class_name or "")
    base = base.replace("Sibling", "").replace("Impl", "")
    return re.sub(r"[^A-Za-z0-9]", "", base)


def is_generic_class(class_name: str) -> bool:
    return bool(re.match(r"^(Service|Static|Type)\d+m\d*f?(?:_[0-9A-F]{4,})?$", class_name or "", re.I))


def has(entry: dict, s: str) -> bool:
    return s in entry.get("strings", [])


def callee_has(entry: dict, s: str) -> bool:
    return s in entry.get("callees_named", [])


def predict_name(entry: dict) -> str | None:
    sset = set(entry.get("strings", []))
    cset = set(entry.get("callees_named", []))

    if "UnityEngine.MaterialPropertyBlock::SetFloatImpl(System.Int32,System.Single)" in sset:
        return "SetMaterialFloat"

    if (
        "UnityEngine.Behaviour::set_enabled(System.Boolean)" in sset
        and "UnityEngine.GameObject::SetActive(System.Boolean)" in sset
    ):
        return "SetGameObjectActive"

    if "UnityEngine.Animator::StringToHash(System.String)" in sset:
        return "CacheAnimatorHash"

    if (
        "UnityEngine.Quaternion::Slerp_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)" in sset
        and "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "SlerpTransformRotation"

    if "UnityEngine.Quaternion::AngleAxis_Injected(System.Single,UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        if "ParentConstraint::set_translationOffsets" in cset:
            return "ApplyConstraintAngleOffset"
        return "CreateAngleAxisRotation"

    if "UnityEngine.Renderer::set_enabled(System.Boolean)" in sset:
        return "SetRendererVisible"

    if (
        "UnityEngine.Component::get_gameObject()" in sset
        and "UnityEngine.GameObject::SetActive(System.Boolean)" in sset
    ):
        return "SetGameObjectActive"

    if "UnityEngine.Transform::SetLocalPositionAndRotation_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        return "ApplyLocalPose"

    if "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)" in sset:
        if "UnityEngine.RectTransform::set_anchoredPosition_Injected(UnityEngine.Vector2&)" in sset:
            return "ApplyAnchoredLayout"
        return "ApplyLocalScale"

    if "UnityEngine.Behaviour::get_isActiveAndEnabled()" in sset:
        return "IsBehaviourActive"

    if (
        "UnityEngine.Gradient::get_colorKeys()" in sset
        and "UnityEngine.SpriteRenderer::set_color_Injected(UnityEngine.Color&)" in sset
    ):
        return "ApplyGradientSpriteColor"

    if (
        "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "ReadTransformPose"

    if "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset:
        return "ReadTransformPosition"

    if (
        "UnityEngine.Transform::InverseTransformVector_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::TransformVector_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset
    ):
        return "ConvertTransformVector"

    if (
        "UnityEngine.Component::get_transform()" in sset
        and "UnityEngine.Transform::InverseTransformDirection_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset
    ):
        return "InverseTransformDirection"

    if "UnityEngine.Time::get_fixedDeltaTime()" in sset:
        return "ApplyFixedDeltaStep"

    if (
        "UnityEngine.Transform::get_localPosition_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)" in sset
    ):
        return "SyncLocalPosition"

    if (
        "UnityEngine.Component::get_transform()" in sset
        and "UnityEngine.Transform::SetAsLastSibling()" in sset
    ):
        return "MoveToLastSibling"

    if "Cannot marshal field 'curpos' of type 'RangePositionInfo': Reference type field marshaling is not supported." in sset:
        return "ThrowCurposMarshalError"

    if "Type could not be marshaled because the length of an embedded array instance does not match the declared length in the layout." in sset:
        return "ThrowEmbeddedArrayMarshalError"

    if "UnityEngine.Joint::set_connectedBody(UnityEngine.Rigidbody)" in sset:
        return "SetConnectedBody"

    if callee_has(entry, "<RunOnThreadPool>d__101::MoveNext"):
        return "RunOnThreadPool"

    if callee_has(entry, "Dictionary`2::TryGetValue"):
        return "TryResolveValue"

    if callee_has(entry, "Service42m_DE2F::GetInstanceID"):
        return "GetInstanceId"

    if (
        callee_has(entry, "CVRSystem::GetPropErrorNameFromEnum")
        and callee_has(entry, "_GetOverlayFlag::BeginInvoke")
    ):
        return "BeginOverlayFlagQuery"

    if callee_has(entry, "<>c::<CreateOrFetchAsyncInternal>b__175_6"):
        return "CreateOrFetchAsync"

    if callee_has(entry, "Type16m6f_FA53::get_name"):
        return "GetTypeName"

    if (
        callee_has(entry, "LifecycleComponent_D91C::CancelInvoke")
        and "UnityEngine.Component::get_gameObject()" in sset
    ):
        return "CancelGameObjectInvoke"

    if callee_has(entry, "Static9m_624B::GetCachedPtr"):
        return "GetCachedPointer"

    if callee_has(entry, "ProfilerRecorder::StartNew"):
        return "StartProfilerRecorder"

    if callee_has(entry, "OVRSpace::ToString"):
        return "FormatOvrSpace"

    if cset == {"ServiceDescriptorCacheItem::get_Last"}:
        return "GetLastServiceDescriptor"

    return None


def is_high_confidence(entry: dict, base_name: str, get_last_class_counts: Counter[str]) -> bool:
    strings = entry.get("strings", [])
    cset = set(entry.get("callees_named", []))

    if base_name == "GetLastServiceDescriptor":
        return get_last_class_counts[entry.get("class", "")] <= 5

    if base_name == "RunOnThreadPool":
        return True

    if strings:
        if len(strings) == 1 and strings[0] in LOW_SIGNAL_STRING_ONLY:
            return False
        return True

    return bool(cset)


def uniquify_name(class_name: str, base_name: str, used: dict[str, set[str]], counts: dict[tuple[str, str], int]) -> str:
    class_used = used[class_name]
    if base_name not in class_used:
        class_used.add(base_name)
        return base_name

    for variant in SYNONYMS.get(base_name, []):
        if variant not in class_used:
            class_used.add(variant)
            return variant

    stem = class_base(class_name)
    if stem and not is_generic_class(class_name):
        candidate = f"{base_name}{stem}"
        if candidate not in class_used:
            class_used.add(candidate)
            return candidate

    idx = counts[(class_name, base_name)] + 1
    counts[(class_name, base_name)] = idx
    suffixes = [
        "Current",
        "Cached",
        "Primary",
        "Secondary",
        "Internal",
        "Deferred",
        "Fallback",
        "State",
    ]
    candidate = f"{base_name}{suffixes[idx - 1]}" if idx <= len(suffixes) else f"{base_name}Variant{idx}"
    while candidate in class_used:
        idx += 1
        counts[(class_name, base_name)] = idx
        candidate = f"{base_name}Variant{idx}"
    class_used.add(candidate)
    return candidate


def main() -> None:
    data = json.loads(INPUT_PATH.read_text(encoding="utf-8"))
    get_last_class_counts: Counter[str] = Counter(
        entry.get("class", "")
        for entry in data.values()
        if set(entry.get("callees_named", [])) == {"ServiceDescriptorCacheItem::get_Last"}
    )

    results: dict[str, str] = {}
    used: dict[str, set[str]] = defaultdict(set)
    counts: dict[tuple[str, str], int] = defaultdict(int)

    for key, entry in data.items():
        base_name = predict_name(entry)
        if not base_name:
            continue
        if not is_high_confidence(entry, base_name, get_last_class_counts):
            continue
        results[key] = uniquify_name(entry.get("class", ""), base_name, used, counts)

    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT_PATH.write_text(json.dumps(results, indent=2, ensure_ascii=False), encoding="utf-8")

    print(f"predictions={len(results)}")
    for key in list(results)[:3]:
        print(f"{key} -> {results[key]}")


if __name__ == "__main__":
    main()
