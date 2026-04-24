import json
import re
from collections import defaultdict
from pathlib import Path


INPUT_PATH = Path("data/all_ctx_chunks/chunk_008.json")
OUTPUT_PATH = Path("output/llm_all_chunk_008.json")


LOW_SIGNAL_STRING_ONLY = {
    "UnityEngine.Component::get_transform()",
    "UnityEngine.Component::get_gameObject()",
    "UnityEngine.GameObject::get_transform()",
    "UnityEngine.Transform::GetParent()",
    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_localRotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)",
    "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)",
    "UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&)",
    "UnityEngine.Time::get_deltaTime()",
    "UnityEngine.Physics::get_simulationMode()",
}


SYNONYMS = {
    "RunOnThreadPool": [
        "QueueThreadPoolWork",
        "ContinueOnThreadPool",
        "DispatchThreadPoolWork",
        "ScheduleThreadPoolWork",
        "ExecuteOnThreadPool",
        "StartThreadPoolTask",
        "EnqueueThreadPoolWork",
        "BeginThreadPoolWork",
        "ProcessThreadPoolWork",
    ],
    "GetShaderPropertyId": [
        "CacheShaderPropertyId",
        "ResolveShaderPropertyId",
        "ReadShaderPropertyId",
        "LookupShaderPropertyId",
        "ComputeShaderPropertyId",
        "MapShaderPropertyId",
        "FetchShaderPropertyId",
        "StoreShaderPropertyId",
        "BuildShaderPropertyId",
    ],
    "SetGameObjectActive": [
        "UpdateGameObjectActive",
        "ApplyGameObjectActive",
        "ToggleGameObjectActive",
        "SetObjectActive",
        "RefreshGameObjectActive",
    ],
    "TryGetValue": [
        "TryResolveValue",
        "TryLookupValue",
        "TryFindValue",
        "TryFetchValue",
    ],
    "AddToDictionary": [
        "InsertDictionaryValue",
        "StoreDictionaryValue",
        "RegisterDictionaryValue",
    ],
    "IsAnimatorInitialized": [
        "CheckAnimatorInitialized",
        "EnsureAnimatorInitialized",
    ],
    "SetAnimatorInteger": [
        "ApplyAnimatorInteger",
        "UpdateAnimatorInteger",
    ],
    "ApplyAnimatorGoalPose": [
        "SyncAnimatorGoalPose",
        "SetAvatarGoalPose",
        "ApplyAvatarGoalPose",
        "UpdateAnimatorGoalPose",
    ],
    "ApplyAnimatorGoalRotation": [
        "SyncAnimatorGoalRotation",
        "SetAvatarGoalRotation",
        "UpdateAnimatorGoalRotation",
    ],
    "SyncTransformPose": [
        "ApplyTransformPose",
        "UpdateTransformPose",
        "CopyTransformPose",
        "SetTransformPose",
    ],
    "SyncRotation": [
        "ApplyRotation",
        "UpdateRotation",
        "CopyRotation",
        "SetRotation",
    ],
    "SyncPosition": [
        "ApplyPosition",
        "UpdatePosition",
        "CopyPosition",
        "SetPosition",
    ],
    "SyncLocalRotation": [
        "ApplyLocalRotation",
        "UpdateLocalRotation",
        "SetLocalRotation",
    ],
    "SyncLocalPosition": [
        "ApplyLocalPosition",
        "UpdateLocalPosition",
        "SetLocalPosition",
    ],
    "GetRealtimeSinceStartup": [
        "ReadRealtimeSinceStartup",
        "CaptureRealtimeSinceStartup",
    ],
    "IsAsyncOperationDone": [
        "CheckAsyncOperationDone",
        "IsLoadOperationDone",
        "HasAsyncOperationCompleted",
    ],
    "SetRedirectLimit": [
        "ConfigureRedirectLimit",
        "ApplyRedirectLimit",
    ],
    "ApplySharedTextMaterial": [
        "SetSharedTextMaterial",
        "UpdateSharedTextMaterial",
        "RefreshSharedTextMaterial",
    ],
    "ApplyTextMaterial": [
        "SetTextMaterial",
        "UpdateTextMaterial",
        "RefreshTextMaterial",
    ],
    "IsBehaviourActiveAndEnabled": [
        "CheckBehaviourActiveAndEnabled",
    ],
    "MoveNextAsyncState": [
        "AdvanceAsyncStateMachine",
        "ContinueAsyncState",
    ],
}


def normalize_class_name(class_name: str) -> str:
    class_name = re.sub(r"_[0-9A-F]{4}$", "", class_name)
    class_name = class_name.replace("Sibling", "")
    class_name = class_name.replace("Impl", "")
    return re.sub(r"[^A-Za-z0-9]", "", class_name)


def is_networkish(class_name: str) -> bool:
    return any(token in class_name for token in ("Network", "ReadyHandler", "MajorSystem"))


def name_from_strings(entry: dict) -> str | None:
    class_name = entry.get("class", "")
    strings = entry.get("strings", [])
    if not strings:
        return None

    sset = set(strings)

    if "UnityEngine.Shader::PropertyToID(System.String)" in sset:
        return "GetShaderPropertyId"

    if "UnityEngine.GameObject::SetActive(System.Boolean)" in sset:
        return "SetGameObjectActive"

    if "UnityEngine.AsyncOperation::get_isDone()" in sset:
        return "IsAsyncOperationDone"

    if "UnityEngine.Networking.UnityWebRequest::SetRedirectLimitFromScripting(System.Int32)" in sset:
        return "SetRedirectLimit"

    if "UnityEngine.Time::get_realtimeSinceStartup()" in sset:
        return "GetRealtimeSinceStartup"

    if "UnityEngine.Joint::set_connectedBody(UnityEngine.Rigidbody)" in sset:
        return "SetConnectedBody"

    if "UnityEngine.Behaviour::set_enabled(System.Boolean)" in sset:
        return "SetBehaviourEnabled"

    if "UnityEngine.Behaviour::get_isActiveAndEnabled()" in sset:
        return "IsBehaviourActiveAndEnabled"

    if "UnityEngine.Application::OpenURL(System.String)" in sset:
        return "OpenUrl"

    if "UnityEngine.Rendering.SortingGroup::set_sortingOrder(System.Int32)" in sset:
        return "SetSortingOrder"

    if "UnityEngine.Animator::get_isInitialized()" in sset:
        return "IsAnimatorInitialized"

    if "UnityEngine.Animator::SetIntegerString(System.String,System.Int32)" in sset:
        return "SetAnimatorInteger"

    if "UnityEngine.Animator::GetIntegerString(System.String)" in sset:
        return "GetAnimatorInteger"

    if "UnityEngine.Resources::UnloadUnusedAssets()" in sset:
        return "UnloadUnusedAssets"

    if "UnityEngine.Random::Range(System.Single,System.Single)" in sset:
        return "GetRandomRange"

    if "UnityEngine.Sprite::get_texture()" in sset:
        return "GetSpriteTexture"

    if "UnityEngine.Transform::SetPositionAndRotation_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        return "SetPositionAndRotation"

    if "UnityEngine.Physics::get_simulationMode()" in sset:
        return "GetPhysicsSimulationMode"

    if "UnityEngine.Transform::TransformDirection_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset:
        return "TransformDirection"

    if "UnityEngine.Transform::TransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset:
        if "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset:
            return "SyncTransformPoint"
        return "TransformPoint"

    if "UnityEngine.Transform::InverseTransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)" in sset:
        return "InverseTransformPoint"

    if "UnityEngine.Transform::FindRelativeTransformWithPath(UnityEngine.Transform,System.String,System.Boolean)" in sset:
        if "UnityEngine.Animator::get_isHuman()" in sset:
            if "UnityEngine.Transform::set_localRotation_Injected(UnityEngine.Quaternion&)" in sset:
                return "ApplyHumanBoneLocalPose"
            if "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset:
                return "ApplyHumanBonePose"
            return "ResolveHumanBoneTransform"
        return "FindRelativeTransform"

    if "UnityEngine.Animator::get_isHuman()" in sset and "UnityEngine.Animator::get_runtimeAnimatorController()" in sset:
        return "HasHumanAnimatorController"

    if (
        "UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)" in sset
        and "UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)" in sset
    ):
        return "ApplyAnimatorGoalPose"

    if "UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)" in sset:
        return "ApplyAnimatorGoalRotation"

    if (
        "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset
        and "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "SyncTransformPose"

    if (
        "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset
        and "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "SyncPoseFromRotation"

    if (
        "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset
    ):
        return "SyncPosition"

    if (
        "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset
        and "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "SyncRotation"

    if (
        "UnityEngine.Transform::get_localPosition_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)" in sset
    ):
        return "SyncLocalPosition"

    if (
        "UnityEngine.Transform::get_localRotation_Injected(UnityEngine.Quaternion&)" in sset
        and "UnityEngine.Transform::set_localRotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "SyncLocalRotation"

    if (
        "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)" in sset
        and "UnityEngine.Transform::set_localRotation_Injected(UnityEngine.Quaternion&)" in sset
    ):
        return "ApplyLocalPose"

    if "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)" in sset:
        return "SetLocalPosition"

    if "UnityEngine.Transform::set_localRotation_Injected(UnityEngine.Quaternion&)" in sset:
        return "SetLocalRotation"

    if "UnityEngine.Transform::set_position_Injected(UnityEngine.Vector3&)" in sset:
        return "SetPosition"

    if "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset:
        return "SetRotation"

    if "UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)" in sset:
        if "UnityEngine.Transform::SetLocalPositionAndRotation_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
            return "AttachTransformAndSetLocalPose"
        if "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset:
            return "AttachTransformAndSyncPosition"
        return "SetTransformParent"

    if "UnityEngine.Transform::GetParent()" in sset:
        if "UnityEngine.Transform::get_localPosition_Injected(UnityEngine.Vector3&)" in sset:
            return "CaptureParentLocalPose"
        return "GetParentTransform"

    if "UnityEngine.Quaternion::AngleAxis_Injected(System.Single,UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        return "ApplyAngleAxisRotation"

    if "UnityEngine.Quaternion::Lerp_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)" in sset:
        return "LerpLocalRotation"

    if "UnityEngine.Quaternion::Slerp_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&,System.Single,UnityEngine.Quaternion&)" in sset:
        if "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)" in sset:
            return "SlerpTransformRotation"
        return "SlerpRotation"

    if "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)" in sset:
        if "UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&)" in sset:
            return "CreateInverseEulerRotation"
        return "CreateEulerRotation"

    if "UnityEngine.Quaternion::Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion&,UnityEngine.Vector3&,System.Single&)" in sset:
        return "ExtractAxisAngle"

    if "UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&)" in sset:
        if "UnityEngine.Transform::get_localRotation_Injected(UnityEngine.Quaternion&)" in sset and "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset:
            return "ResolveRelativeRotation"
        return "InvertRotation"

    if "UnityEngine.Rigidbody::set_velocity_Injected(UnityEngine.Vector3&)" in sset:
        return "SetRigidbodyVelocity"

    if "UnityEngine.Rigidbody::set_angularVelocity_Injected(UnityEngine.Vector3&)" in sset:
        return "SetAngularVelocity"

    if "UnityEngine.ParticleSystem/MainModule::set_loop_Injected(UnityEngine.ParticleSystem/MainModule&,System.Boolean)" in sset:
        if "UnityEngine.ParticleSystem/TextureSheetAnimationModule::set_enabled_Injected(UnityEngine.ParticleSystem/TextureSheetAnimationModule&,System.Boolean)" in sset:
            return "ConfigureParticleLooping"
        return "SetParticleLoop"

    if "UnityEngine.RectTransform::set_anchoredPosition_Injected(UnityEngine.Vector2&)" in sset:
        return "UpdateAnchoredPosition"

    if "UnityEngine.Collider::get_material()" in sset and "UnityEngine.PhysicMaterial::set_bounciness(System.Single)" in sset:
        return "SyncColliderBounceMaterial"

    if "Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSample(System.IntPtr)" in sset:
        return "BeginProfilerSample"

    if "UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal(UnityEngine.Playables.PlayableHandle&,System.Int32)" in sset:
        return "GetAnimatorLayerName"

    # Low-signal single API lookups stay skipped to keep coverage conservative.
    if len(strings) == 1 and strings[0] in LOW_SIGNAL_STRING_ONLY:
        return None

    if is_networkish(class_name):
        if "UnityEngine.Component::get_transform()" in sset and "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)" in sset:
            return "ReadTransformPosition"
        if "UnityEngine.Component::get_transform()" in sset and "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)" in sset:
            return "ReadTransformRotation"

    return None


def name_from_callees(entry: dict) -> str | None:
    callees = entry.get("callees_named", [])
    if not callees:
        return None

    cset = set(callees)

    if cset == {"ServiceDescriptorCacheItem::get_Last"}:
        return None

    if "<RunOnThreadPool>d__101::MoveNext" in cset:
        return "RunOnThreadPool"

    if "Dictionary`2::TryGetValue" in cset:
        return "TryGetValue"

    if "Dictionary`2::System.Collections.IDictionary.Add" in cset:
        return "AddToDictionary"

    if "TMP_SubMeshUI::set_sharedMaterial" in cset:
        return "ApplySharedTextMaterial"

    if "TMP_SubMesh::set_material" in cset:
        return "ApplyTextMaterial"

    if "ParentConstraint::RemoveSource" in cset:
        return "RemoveParentConstraintSource"

    if "CVRInput::GetInputSourceHandle" in cset:
        return "GetInputSourceHandle"

    if "AnimationPlayableExtensions::SetAnimatedPropertiesInternal" in cset:
        return "ApplyAnimatedProperties"

    if "AsyncStateMachine_B3D6::MoveNext" in cset:
        return "MoveNextAsyncState"

    if "UpdateComponent_BA7C::Invoke" in cset:
        return "InvokeUpdateComponent"

    if "TMP_SpriteAsset::UpgradeSpriteAsset" in cset:
        return "UpgradeSpriteAsset"

    if "ProfilerRecorder::StartNew" in cset:
        return "StartProfilerRecorder"

    if "DateTime::System.IConvertible.ToSingle" in cset:
        return "ConvertToSingle"

    if "LifecycleComponent_D91C::Initialize" in cset and "LifecycleComponent_D91C::StartCoroutine" in cset:
        return "InitializeAndStartLifecycle"

    if "AssetCache::Instantiate" in cset:
        return "InstantiateCachedAsset"

    if "LifecycleComponent_F091::.ctor" in cset:
        return "ConstructLifecycleComponent"

    if "LifecycleComponent_F10B::OnDestroy" in cset:
        return "OnDestroy"

    if "Enumerator_689F::CompareBaseObjects" in cset or "VRCData::CompareBaseObjects" in cset:
        return "CompareBaseObjects"

    if "Service23m_03CE::Destroy" in cset:
        return "DestroyServiceObject"

    if "AnimationCurve::GetKey" in cset:
        return "GetAnimationCurveKey"

    if "Quaternion::op_Inequality" in cset:
        return "CompareQuaternion"

    if "Animator::SetBoolString" in cset:
        return "SetAnimatorBool"

    if "AsyncStateMachine_6212::GetHashCode" in cset:
        return "GetHashCode"

    if "AsyncStateMachine_7D53::Equals" in cset or "AsyncStateMachine_6C8B::Equals" in cset:
        return "Equals"

    if "MajorSystem_13C5::print" in cset:
        return "PrintValue"

    return None


def is_high_confidence(entry: dict, base_name: str) -> bool:
    strings = entry.get("strings", [])
    callees = entry.get("callees_named", [])

    if base_name in {"Equals", "GetHashCode", "ConvertToSingle"}:
        return False

    if strings:
        if len(strings) == 1 and strings[0] in LOW_SIGNAL_STRING_ONLY:
            return False
        return True

    return bool(callees and base_name)


def uniquify_name(class_name: str, base_name: str, class_used: dict[str, set[str]], class_counts: dict[tuple[str, str], int]) -> str:
    used = class_used[class_name]
    if base_name not in used:
        used.add(base_name)
        return base_name

    for variant in SYNONYMS.get(base_name, []):
        if variant not in used:
            used.add(variant)
            return variant

    idx = class_counts[(class_name, base_name)] + 1
    class_counts[(class_name, base_name)] = idx
    suffixes = [
        "Current",
        "Target",
        "Cached",
        "Immediate",
        "Internal",
        "Deferred",
        "Primary",
        "Secondary",
        "Fallback",
        "State",
        "Value",
        "Handle",
    ]
    candidate = f"{base_name}{suffixes[idx - 1]}" if idx <= len(suffixes) else f"{base_name}Variant{idx}"
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
        if base_name is None or not is_high_confidence(entry, base_name):
            continue
        results[key] = uniquify_name(entry.get("class", ""), base_name, class_used, class_counts)

    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT_PATH.write_text(json.dumps(results, indent=2, ensure_ascii=False), encoding="utf-8")

    print(f"predictions={len(results)}")
    for key in list(results)[:3]:
        print(f"{key} -> {results[key]}")


if __name__ == "__main__":
    main()
