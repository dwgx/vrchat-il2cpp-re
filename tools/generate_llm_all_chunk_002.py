import json
import re
from collections import defaultdict
from pathlib import Path


INPUT_PATH = Path("data/all_ctx_chunks/chunk_002.json")
OUTPUT_PATH = Path("output/llm_all_chunk_002.json")


LOW_SIGNAL_STRING_ONLY = {
    "UnityEngine.Component::get_gameObject()",
    "UnityEngine.Component::get_transform()",
    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Joint::set_connectedBody(UnityEngine.Rigidbody)",
}


SYNONYMS = {
    "SetConnectedBody": [
        "SetConnectedBody",
        "AssignConnectedBody",
        "LinkConnectedBody",
        "AttachConnectedBody",
        "BindConnectedBody",
        "UpdateConnectedBody",
        "ConfigureConnectedBody",
        "ApplyConnectedBody",
        "ResetConnectedBody",
        "SyncConnectedBody",
    ],
    "GetRotation": [
        "GetRotation",
        "ReadRotation",
        "FetchRotation",
    ],
    "SetRotation": [
        "SetRotation",
        "ApplyRotation",
        "UpdateRotation",
    ],
    "GetPosition": [
        "GetPosition",
        "ReadPosition",
        "FetchPosition",
    ],
    "SetPosition": [
        "SetPosition",
        "ApplyPosition",
        "UpdatePosition",
    ],
    "TryGetValue": [
        "TryGetValue",
        "TryLookupValue",
        "TryResolveValue",
        "TryFindValue",
    ],
    "RunOnThreadPool": [
        "RunOnThreadPool",
        "ContinueOnThreadPool",
        "QueueThreadPoolWork",
    ],
    "CancelInvoke": [
        "CancelInvoke",
        "StopInvoke",
        "CancelScheduledInvoke",
    ],
}


def normalize_class_name(class_name: str) -> str:
    class_name = re.sub(r"_[0-9A-F]{4}$", "", class_name)
    class_name = class_name.replace("Sibling", "")
    class_name = class_name.replace("Impl", "")
    class_name = re.sub(r"[^A-Za-z0-9]", "", class_name)
    return class_name


def parse_api_name(symbol: str) -> str:
    if "::" in symbol:
        method = symbol.split("::", 1)[1].split("(", 1)[0]
    else:
        method = symbol.split(".")[-1]
    method = re.sub(r"_Injected$", "", method)
    method = re.sub(r"^(get_|set_)", "", method)
    parts = re.split(r"[^A-Za-z0-9]+", method)
    return "".join(p[:1].upper() + p[1:] for p in parts if p)


def count_meaningful_strings(strings: list[str]) -> int:
    return sum(1 for s in strings if s and not re.fullmatch(r"[\u00CC-\u00CF]+", s))


def name_from_strings(entry: dict) -> str | None:
    strings = entry.get("strings", [])
    if not strings:
        return None

    sset = set(strings)

    if "UnityEngine.PlayerPrefs::Save()" in sset:
        return "SavePlayerPreferences"

    if any("TextureSheetAnimationModule::get_spriteCount" in s for s in strings):
        return "GetTextureSheetSpriteCount"

    if any("TextureSheetAnimationModule::get_startFrame" in s for s in strings):
        return "GetTextureSheetStartFrame"

    if any("TextureSheetAnimationModule::set_cycleCount" in s for s in strings):
        return "ConfigureTextureSheetAnimation"

    if "UnityEngine.Renderer::GetSharedMaterial()" in sset and "UnityEngine.Renderer::SetMaterial(UnityEngine.Material)" in sset:
        return "ReplaceRendererMaterial"

    if (
        "UnityEngine.Renderer::get_localBounds_Injected(UnityEngine.Bounds&)" in sset
        and "UnityEngine.Renderer::set_localBounds_Injected(UnityEngine.Bounds&)" in sset
    ):
        return "UpdateRendererLocalBounds"

    if "UnityEngine.Animator::get_isHuman()" in sset:
        return "IsHumanAvatar"

    if "UnityEngine.Texture2D::SetPixelImpl_Injected(System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Color&)" in sset:
        return "SetTexturePixel"

    if "UnityEngine.XR.XRInputSubsystem::TryRecenter()" in sset:
        return "TryRecenterTracking"

    if "UnityEngine.MeshFilter::set_mesh(UnityEngine.Mesh)" in sset:
        return "SetMesh"

    if "UnityEngine.AsyncOperation::set_allowSceneActivation(System.Boolean)" in sset:
        return "SetSceneActivationAllowed"

    if "UnityEngine.Transform::FindRelativeTransformWithPath(UnityEngine.Transform,System.String,System.Boolean)" in sset:
        if "UnityEngine.Component::get_transform()" in sset:
            return "FindRelativeTransform"
        return "ResolveRelativeTransformPath"

    if "UnityEngine.Transform::InverseTransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset:
        return "InverseTransformPoint"

    if "UnityEngine.Transform::TransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset:
        return "TransformPoint"

    if "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        return "CreateRotationFromEuler"

    if "UnityEngine.Quaternion::FromToRotation_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        if "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset:
            return "AlignPositionFromToRotation"
        return "CreateFromToRotation"

    if "UnityEngine.GameObject::SetActive(System.Boolean)" in sset:
        return "SetGameObjectActive"

    if "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)" in sset:
        return "SetLocalScale"

    if "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset and "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset:
        return "SyncPosition"

    if "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset and "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset:
        return "SyncRotation"

    if "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset:
        return "SetPosition"

    if "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset:
        return "SetRotation"

    if "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset and "UnityEngine.Component::get_transform()" in sset:
        return "GetTransformPosition"

    if "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset:
        return "GetPosition"

    if "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset:
        return "GetRotation"

    if "UnityEngine.Joint::set_connectedBody(UnityEngine.Rigidbody)" in sset:
        return "SetConnectedBody"

    if "UnityEngine.Component::get_gameObject()" in sset and "UnityEngine.GameObject::get_activeSelf()" in sset:
        return "CheckGameObjectActive"

    if "UnityEngine.Component::get_transform()" in sset:
        return "GetTransform"

    if "UnityEngine.Component::get_gameObject()" in sset:
        return "GetGameObject"

    # Plain literal string fallbacks for richer non-API cases.
    literals = [s for s in strings if "::" not in s and re.search(r"[A-Za-z]", s)]
    literal_joined = " ".join(literals)
    if "AVProVideo" in literal_joined and "EndOpenSourceFromBuffer" in literal_joined:
        return "EndOpenSourceFromBuffer"
    if "AVProVideo" in literal_joined and "GetTextureFormat" in literal_joined:
        return "GetVideoTextureFormat"
    if "CanPlay" in literal_joined and "GetTexturePointer" in literal_joined:
        return "CanPlayFromTexturePointer"

    return None


def name_from_callees(entry: dict) -> str | None:
    callees = entry.get("callees_named", [])
    if not callees:
        return None

    cset = set(callees)
    first = callees[0]

    if "<RunOnThreadPool>d__101::MoveNext" in cset:
        return "RunOnThreadPool"
    if "Dictionary`2::TryGetValue" in cset:
        return "TryGetValue"
    if "Dictionary`2::System.Collections.IDictionary.Add" in cset:
        return "AddToDictionary"
    if any("CancelInvoke" in c for c in callees):
        return "CancelInvoke"
    if any("InvokeRepeating" in c for c in callees):
        return "InvokeRepeating"
    if any("IsInvoking" in c for c in callees):
        return "IsInvoking"
    if "AnimatedTextureBaseImpl_DD66::Initialize" in cset or any(c.endswith("::Initialize") for c in callees):
        class_hint = normalize_class_name(entry.get("class", ""))
        if class_hint:
            return f"Initialize{class_hint}"
        return "Initialize"
    if any("ParentConstraint::get_constraintActive" in c for c in callees) and any("ParentConstraint::set_translationOffsets" in c for c in callees):
        return "UpdateParentConstraintOffsets"
    if any("TryRecenter" in c for c in callees):
        return "TryRecenterTracking"
    if any("OnDestroy" in c for c in callees):
        return "OnDestroy"
    if any("get_name" in c for c in callees):
        return "GetName"
    if any("set_name" in c for c in callees):
        return "SetName"
    if any("CompareBaseObjects" in c for c in callees):
        return "CompareBaseObjects"
    if any("MoveNext" in c for c in callees):
        return "MoveNext"
    if any("GetHashCode" in c for c in callees):
        return "GetHashCode"
    if any("Equals" in c for c in callees):
        return "Equals"
    if any("ToChar" in c for c in callees):
        return "ToChar"
    if any("::.cctor" in c for c in callees):
        return "InitializeType"
    if any("get_twoFactorAuthMethods" in c for c in callees):
        return "GetTwoFactorAuthMethods"
    if any("get_currentScale" in c for c in callees) and any("CalculateInitialOffset" in c for c in callees):
        return "CalculateInitialOffset"
    if any("MixEmptyState" in c for c in callees):
        return "MixEmptyHashState"
    if any("Update" in c for c in callees):
        return "Update"

    if first == "ServiceDescriptorCacheItem::get_Last":
        return None
    if first == "DBNull::ToString":
        return None

    return None


def is_high_confidence(entry: dict, base_name: str) -> bool:
    strings = entry.get("strings", [])
    callees = entry.get("callees_named", [])

    if strings:
        if len(strings) == 1 and strings[0] in LOW_SIGNAL_STRING_ONLY:
            return base_name in {"SetConnectedBody", "GetPosition", "GetRotation", "SetPosition", "SetRotation"}
        return True

    if not callees:
        return False

    if base_name in {
        "RunOnThreadPool",
        "TryGetValue",
        "AddToDictionary",
        "CancelInvoke",
        "InvokeRepeating",
        "IsInvoking",
        "UpdateParentConstraintOffsets",
        "GetTwoFactorAuthMethods",
        "InitializeType",
        "CalculateInitialOffset",
        "OnDestroy",
        "SetName",
        "GetName",
    }:
        return True

    return False


def uniquify_name(class_name: str, base_name: str, class_used: dict[str, set[str]], class_counts: dict[tuple[str, str], int]) -> str:
    used = class_used[class_name]
    if base_name not in used:
        used.add(base_name)
        return base_name

    variants = SYNONYMS.get(base_name, [])
    for variant in variants:
        if variant not in used:
            used.add(variant)
            return variant

    idx = class_counts[(class_name, base_name)] + 1
    class_counts[(class_name, base_name)] = idx

    suffixes = ["Primary", "Secondary", "Fallback", "Cached", "Internal", "Fast", "Safe", "Deferred", "Current", "Active"]
    if idx <= len(suffixes):
        candidate = f"{base_name}{suffixes[idx - 1]}"
    else:
        candidate = f"{base_name}Variant{idx}"

    while candidate in used:
        idx += 1
        class_counts[(class_name, base_name)] = idx
        candidate = f"{base_name}Variant{idx}"

    used.add(candidate)
    return candidate


def main() -> None:
    data = json.loads(INPUT_PATH.read_text(encoding="utf-8"))
    results: dict[str, str] = {}
    class_used: dict[str, set[str]] = defaultdict(set)
    class_counts: dict[tuple[str, str], int] = defaultdict(int)

    for key, entry in data.items():
        base_name = name_from_strings(entry)
        if base_name is None:
            base_name = name_from_callees(entry)
        if base_name is None:
            continue
        if not is_high_confidence(entry, base_name):
            continue

        final_name = uniquify_name(entry.get("class", ""), base_name, class_used, class_counts)
        results[key] = final_name

    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT_PATH.write_text(json.dumps(results, indent=2, ensure_ascii=False), encoding="utf-8")

    print(f"predictions={len(results)}")
    for key in list(results)[:5]:
        print(f"{key} -> {results[key]}")


if __name__ == "__main__":
    main()
