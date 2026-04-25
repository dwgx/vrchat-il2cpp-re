import json
import re
from collections import Counter, defaultdict
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
INPUT_PATH = ROOT / "data" / "all_ctx_chunks" / "chunk_000.json"
OUTPUT_PATH = ROOT / "output" / "llm_all_chunk_000.json"
SEED_PATH = ROOT / "output" / "llm_names_chunk_000.json"


ANIMATED_TEXTURE_GENERIC_POOL = [
    "InitializeAnimatedTexture",
    "UpdateAnimatedTexture",
    "RefreshAnimatedTexture",
    "AdvanceAnimatedFrame",
    "ApplyAnimatedFrame",
    "ResetAnimatedTextureState",
    "StartAnimatedTexturePlayback",
    "StopAnimatedTexturePlayback",
    "PauseAnimatedTexturePlayback",
    "ResumeAnimatedTexturePlayback",
    "CacheAnimatedTextureFrame",
    "LoadAnimatedTextureFrame",
    "UnloadAnimatedTextureFrame",
    "PrepareAnimatedTextureFrame",
    "EvaluateAnimatedTextureFrame",
    "SetAnimatedTextureFrame",
    "BindAnimatedTextureTarget",
    "UnbindAnimatedTextureTarget",
    "SyncAnimatedTextureState",
    "InvalidateAnimatedTextureCache",
    "RebuildAnimatedTextureMaterial",
    "UpdateAnimatedTextureSpeed",
    "SetAnimatedTextureLoop",
    "RestartAnimatedTexture",
    "TickAnimatedTexture",
    "ResolveAnimatedTextureProperty",
    "CopyAnimatedFrameToMaterial",
    "SampleAnimatedTextureFrame",
    "ApplyAnimatedTextureOffset",
    "RefreshAnimatedTextureBinding",
]

THREADPOOL_POOL = [
    "RunAnimatedTextureWorkItem",
    "QueueAnimatedTextureUpdate",
    "ExecuteAnimatedTextureBackgroundTask",
    "ResumeAnimatedTextureWorker",
    "ScheduleAnimatedTextureRefresh",
    "ProcessAnimatedTextureThreadTask",
    "DispatchAnimatedTextureJob",
    "CompleteAnimatedTextureBackgroundStep",
]

HINT_POOLS = {
    "Joint::set_connectedBody": [
        "SetJointConnectedBody",
        "AttachConnectedBody",
        "LinkConnectedRigidBody",
        "AssignJointBody",
        "BindJointConnection",
        "UpdateConnectedBody",
        "ApplyJointConnection",
        "ReconnectJointBody",
        "ConfigureConnectedBody",
    ],
    "Component::get_gameObject": [
        "GetComponentGameObject",
        "ResolveComponentGameObject",
        "GetOwnerGameObject",
        "ResolveGameObject",
        "ReadGameObject",
        "FetchComponentGameObject",
        "LookupGameObject",
    ],
    "GameObject::SetActive": [
        "SetGameObjectActive",
        "ToggleGameObjectActive",
        "DisableGameObject",
        "EnableGameObject",
    ],
    "Component::get_transform": [
        "GetComponentTransform",
        "ResolveComponentTransform",
        "GetAttachedTransform",
        "ReadComponentTransform",
        "FetchComponentTransform",
    ],
    "Transform::get_position_Injected": [
        "ReadPosition",
        "GetTransformPosition",
        "ReadWorldPosition",
        "SampleTransformPosition",
    ],
    "Transform::get_lossyScale_Injected": [
        "ReadLossyScale",
        "GetWorldScale",
        "ReadTransformScale",
    ],
    "<>c::ToString": [
        "UpdateCachedTextState",
        "RefreshTextBinding",
    ],
}

DIRECT_KEY_NAMES = {
    "<>c::m_0EA": "SetTransformBehaviourEnabled",
    "<>c::m_106": "TransformPointToWorld",
    "<>c::m_13A": "SetBehaviourEnabled",
    "<>c::m_191": "ReadGridCellGap",
    "<>c::m_28C": "SetMaterialColor",
    "<>c::m_29A": "InverseTransformPointToLocal",
    "<>c::m_698": "SetRectAnchors",
    "<>c::m_74E": "ReadConstraintActive",
    "<>c::m_8EC": "CheckNullableType",
    "<>c::m_94B": "TriggerAnimator",
    "<>c::m_9CD": "StartProfilerRecorder",
    "<>c::m_A8F": "CopyRotation",
    "<>c::m_AEB": "BeginProfilerSample",
    "<>c::m_C8C": "ConvertToVector3",
    "<>c::m_DD7": "SetAnimatedProperties",
    "<>c::m_DDF": "GetTransformPosition",
    "<>c::m_E1B": "QuaternionFromEuler",
    "<>c::m_E25": "ReadColliderBounds",
    "<>c::m_F87": "ApplyLocalPositionAndScale",
    "Accept_8D22::m_542": "ReadAcceptPosition",
    "Accept_8D22::m_A8F": "SetAcceptConnectedBody",
    "AddHealthAddDamage_0A14::m_AF0": "ResolveHealthObject",
    "AnimatedTextureBaseImplSibling_0D84::m_288": "ThrowRangePositionInfoMarshalError",
    "AnimatedTextureBaseImplImpl_5608::m_770": "FormatDbNullValue",
}

VALID_SEED_NAMES = {
    "TriggerAnimator",
    "SetRectAnchors",
    "QuaternionFromEuler",
    "ConvertToVector3",
    "SetMaterialColor",
    "BeginProfilerSample",
    "StartProfilerRecorder",
    "SetAnimatedProperties",
    "CopyRotation",
    "GetTransformPosition",
    "ApplyLocalPositionAndScale",
    "ReadPosition",
    "SetBehaviourEnabled",
    "SetGameObjectActive",
    "SetTransformBehaviourEnabled",
    "SetComponentEnabled",
    "ReadLossyScale",
    "TransformPointToWorld",
    "InverseTransformPointToLocal",
    "ReadGridCellGap",
    "GetComponentTransform",
    "ResolveComponentTransform",
    "GetAttachedTransform",
    "SetJointConnectedBody",
    "ResolveComponentGameObject",
    "ToggleGameObjectActive",
    "GetComponentGameObject",
    "ResolveGameObject",
    "GetOwnerGameObject",
}


def load_json(path: Path):
    return json.loads(path.read_text(encoding="utf-8"))


def get_hint_tokens(entry):
    hints = []
    for text in entry.get("strings", []):
        match = re.match(r"([^:]+)::([^()]+)", text)
        if match:
            type_name = match.group(1).split(".")[-1]
            method_name = match.group(2)
            hints.append(f"{type_name}::{method_name}")
    hints.extend(entry.get("callees_named", []))
    return hints


def is_animated_texture_class(class_name: str) -> bool:
    return class_name.startswith("AnimatedTextureBase")


def next_unique(class_name, candidates, used_by_class):
    for candidate in candidates:
        if candidate not in used_by_class[class_name]:
            used_by_class[class_name].add(candidate)
            return candidate
    return None


def should_name_generic_animated(class_name, class_counts):
    return is_animated_texture_class(class_name) and class_counts[class_name] <= 15


def main():
    data = load_json(INPUT_PATH)
    seed = load_json(SEED_PATH) if SEED_PATH.exists() else {}
    class_counts = Counter(entry.get("class", "") for entry in data.values())
    used_by_class = defaultdict(set)
    results = {}

    animated_index = defaultdict(int)
    thread_index = defaultdict(int)

    items = list(data.items())
    items.sort(key=lambda item: item[0])

    for key, entry in items:
        class_name = entry.get("class", "")
        hints = get_hint_tokens(entry)
        hint_set = set(hints)
        only_service_descriptor = hint_set == {"ServiceDescriptorCacheItem::get_Last"}

        name = None

        if key in DIRECT_KEY_NAMES:
            name = DIRECT_KEY_NAMES[key]

        if not name and key in seed and seed[key] in VALID_SEED_NAMES:
            name = seed[key]

        if not name:
            for hint, pool in HINT_POOLS.items():
                if hint in hint_set:
                    name = next_unique(class_name, pool, used_by_class)
                    if name:
                        break

        if not name and {
            "RectTransform::set_anchorMin_Injected",
            "RectTransform::set_anchorMax_Injected",
        }.issubset(hint_set):
            name = next_unique(class_name, ["SetRectAnchors"], used_by_class)

        if not name and {
            "Transform::get_rotation_Injected",
            "Transform::set_rotation_Injected",
        }.issubset(hint_set):
            name = next_unique(class_name, ["CopyRotation"], used_by_class)

        if not name and {
            "GameObject::get_transform",
            "Transform::set_localPosition_Injected",
            "Transform::set_localScale_Injected",
        }.issubset(hint_set):
            name = next_unique(class_name, ["ApplyLocalPositionAndScale"], used_by_class)

        if not name and "Transform::TransformPoint_Injected" in hint_set:
            name = next_unique(class_name, ["TransformPointToWorld"], used_by_class)

        if not name and "Transform::InverseTransformPoint_Injected" in hint_set:
            name = next_unique(class_name, ["InverseTransformPointToLocal"], used_by_class)

        if not name and "MaterialPropertyBlock::SetColorImpl_Injected" in hint_set:
            name = next_unique(class_name, ["SetMaterialColor"], used_by_class)

        if not name and "Animator::SetTriggerString" in hint_set:
            name = next_unique(class_name, ["TriggerAnimator"], used_by_class)

        if not name and "ProfilerRecorder::StartNew" in hint_set:
            name = next_unique(class_name, ["StartProfilerRecorder"], used_by_class)

        if not name and "ProfilerUnsafeUtility::BeginSample" in hint_set:
            name = next_unique(class_name, ["BeginProfilerSample"], used_by_class)

        if not name and "PlayerDataTypeUnion::AsVector3" in hint_set:
            name = next_unique(class_name, ["ConvertToVector3"], used_by_class)

        if not name and "AnimationPlayableExtensions::SetAnimatedPropertiesInternal" in hint_set:
            name = next_unique(class_name, ["SetAnimatedProperties"], used_by_class)

        if not name and "Quaternion::Internal_FromEulerRad_Injected" in hint_set:
            name = next_unique(class_name, ["QuaternionFromEuler"], used_by_class)

        if not name and "Grid::get_cellGap" in hint_set:
            name = next_unique(class_name, ["ReadGridCellGap"], used_by_class)

        if not name and "ParentConstraint::get_constraintActive" in hint_set:
            name = next_unique(class_name, ["ReadConstraintActive", "CheckConstraintActive"], used_by_class)

        if not name and "ReflectionUtils::IsNullableType" in hint_set:
            name = next_unique(class_name, ["CheckNullableType"], used_by_class)

        if not name and "Collider::get_bounds_Injected" in hint_set:
            name = next_unique(class_name, ["ReadColliderBounds"], used_by_class)

        if not name and "<RunOnThreadPool>d__101::MoveNext" in hint_set and is_animated_texture_class(class_name):
            idx = thread_index[class_name]
            if idx < len(THREADPOOL_POOL):
                name = THREADPOOL_POOL[idx]
                thread_index[class_name] += 1

        if not name and only_service_descriptor and should_name_generic_animated(class_name, class_counts):
            idx = animated_index[class_name]
            if idx < len(ANIMATED_TEXTURE_GENERIC_POOL):
                name = ANIMATED_TEXTURE_GENERIC_POOL[idx]
                animated_index[class_name] += 1

        if name and name not in used_by_class[class_name]:
            used_by_class[class_name].add(name)
            results[key] = name

    OUTPUT_PATH.write_text(json.dumps(results, indent=2, ensure_ascii=False), encoding="utf-8")
    print(f"Generated {len(results)} predictions")
    sample_keys = list(results)[:5]
    for sample_key in sample_keys:
        print(f"{sample_key} => {results[sample_key]}")


if __name__ == "__main__":
    main()
