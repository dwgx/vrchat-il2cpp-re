#!/usr/bin/env python3
"""Generate heuristic codex_pred_XXX.json files for codex batches.

This is a local fallback for environments where `codex exec` cannot run.
It predicts semantic PascalCase names for `m_XXX` methods using only the
class name, parent, readable methods, and fields from each batch.
"""

from __future__ import annotations

import json
import re
from collections import Counter
from pathlib import Path


BASE_DIR = Path(__file__).resolve().parent.parent
OUTPUT_DIR = BASE_DIR / "output"

BOILERPLATE_METHODS = {
    ".ctor",
    ".cctor",
    "GetInstanceId",
    "Equals",
    "GetHashCode",
    "ToString",
    "OpImplicit",
    "CompareBaseObjects",
    "IsNativeObjectAlive",
    "GetCachedPtr",
    "StartCoroutine",
    "StartCoroutine_Auto",
    "StartCoroutineManaged",
    "StartCoroutineManaged2",
    "StopCoroutine",
    "StopCoroutineManaged",
    "StopCoroutineFromEnumeratorManaged",
    "StopAllCoroutines",
    "CancelInvoke",
    "Invoke",
    "InvokeRepeating",
    "InvokeDelayed",
    "IsInvoking",
    "Internal_CancelInvokeAll",
    "Internal_IsInvokingAll",
    "RaiseCancellation",
    "print",
    "Deconstruct",
    "Dispose",
    "Cleanup",
    "CompareTo",
    "MoveNext",
    "Short",
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
    "GetScriptClassName",
}

GENERIC_TOKENS = {
    "Base",
    "Class",
    "Impl",
    "Sibling",
    "Siblin",
    "Related",
    "Derived",
    "Static",
    "Service",
    "Type",
    "Struct",
    "Object",
    "Value",
    "Mono",
    "Behaviour",
}

VERB_PREFIXES = [
    "TryRead",
    "TryGet",
    "TryLookup",
    "Initialize",
    "Configure",
    "Register",
    "Unregister",
    "Serialize",
    "Deserialize",
    "Refresh",
    "Resolve",
    "Process",
    "Capture",
    "Compare",
    "Compute",
    "Calculate",
    "Format",
    "Prepare",
    "Validate",
    "Assign",
    "Attach",
    "Detach",
    "Create",
    "Update",
    "Handle",
    "Execute",
    "Enable",
    "Disable",
    "Notify",
    "Return",
    "Remove",
    "Invoke",
    "Select",
    "Fetch",
    "Access",
    "Queue",
    "Build",
    "Apply",
    "Check",
    "Store",
    "Launch",
    "Open",
    "Close",
    "Begin",
    "Finish",
    "Start",
    "Stop",
    "Read",
    "Write",
    "Flush",
    "Cache",
    "Clear",
    "Reset",
    "Mark",
    "Parse",
    "Load",
    "Save",
    "Bind",
    "Sync",
    "Poll",
    "Pack",
    "Unpack",
    "Get",
    "Set",
    "Has",
    "On",
]

TITLE_MAP = {
    "ui": "Ui",
    "vrc": "Vrc",
    "av": "Av",
    "fps": "Fps",
    "ik": "Ik",
    "id": "Id",
    "url": "Url",
    "http": "Http",
    "photon": "Photon",
    "udon": "Udon",
    "api": "Api",
}


def split_camel(text: str) -> list[str]:
    return re.findall(r"[A-Z]+(?=[A-Z][a-z]|[0-9]|$)|[A-Z]?[a-z]+|[0-9]+", text)


def clean_identifier(raw: str) -> str:
    raw = raw.strip()
    raw = raw.replace("`1", "")
    raw = raw.split("::")[-1]
    raw = raw.split(".")[-1]
    raw = re.sub(r"_[0-9A-F]{3,4}$", "", raw)
    raw = re.sub(r"_[0-9A-F]{3}$", "", raw)
    raw = re.sub(r"_\d+$", "", raw)
    raw = raw.replace("__", "_")
    raw = re.sub(r"^(Get|Set|Update|Initialize|Process|Handle|Refresh|Resolve|Compute|Calculate|Apply|Cache|Build|Read|Write|Load|Save|Check|Validate|Create|Start|Stop|On)([a-z])", lambda m: m.group(1) + m.group(2).upper(), raw)
    if raw.startswith("get_"):
        raw = "Get" + to_pascal(raw[4:])
    elif raw.startswith("set_"):
        raw = "Set" + to_pascal(raw[4:])
    else:
        raw = to_pascal(raw)
    return raw


def to_pascal(raw: str) -> str:
    parts = []
    for piece in re.split(r"[^A-Za-z0-9]+", raw):
        if not piece:
            continue
        for token in split_camel(piece):
            if not token:
                continue
            lowered = token.lower()
            parts.append(TITLE_MAP.get(lowered, token[:1].upper() + token[1:]))
    return "".join(parts)


def split_verb_noun(name: str) -> tuple[str, str]:
    for prefix in VERB_PREFIXES:
        if name.startswith(prefix) and len(name) > len(prefix):
            return prefix, name[len(prefix) :]
    return "", name


def is_pascal(name: str) -> bool:
    return bool(re.fullmatch(r"[A-Z][A-Za-z0-9]*", name))


def dedupe_preserve(items: list[str]) -> list[str]:
    seen = set()
    result = []
    for item in items:
        if not item or item in seen:
            continue
        seen.add(item)
        result.append(item)
    return result


def title_tokens(text: str) -> list[str]:
    text = clean_identifier(text)
    return [tok for tok in split_camel(text) if tok and tok not in GENERIC_TOKENS]


def phrase_from_class(name: str) -> list[str]:
    base = re.sub(r"_[0-9A-F]{3,4}$", "", name)
    tokens = [tok for tok in split_camel(base) if tok and tok not in GENERIC_TOKENS]
    phrases = []
    if tokens:
        joined = "".join(tokens)
        phrases.append(joined)
    if len(tokens) >= 2:
        for size in range(len(tokens), 1, -1):
            phrases.append("".join(tokens[:size]))
    return dedupe_preserve(phrases)


def phrase_from_field(name: str) -> str:
    if name.startswith("f_"):
        return ""
    name = name.lstrip("_")
    if not name:
        return ""
    return to_pascal(name)


def domain_for_class(class_name: str, parent: str, readable: list[str]) -> str:
    joined = " ".join([class_name, parent, *readable]).lower()
    if "animatedtexture" in joined or "texture" in joined:
        return "animated_texture"
    if any(token in joined for token in ["pointer", "drag", "scroll", "recttransform", "layout", "tabcontent", "uirect", "uiobservable", "uishow", "pointerdown"]):
        return "ui_pointer"
    if any(token in joined for token in ["localization", "purchase", "moviecapture", "avatarproxy", "eyelid", "eyeandhead", "poseav3"]):
        return "specific_ui_or_player"
    if any(token in joined for token in ["network", "photon", "player", "avatar", "pose", "vrc", "proxy", "connection"]):
        return "network_player"
    if "lifecycle" in joined or "servicedescriptor" in joined:
        return "lifecycle"
    if "updatecomponent" in joined:
        return "update_component"
    if parent == "ValueType" or class_name.startswith("Struct") or class_name == "Range":
        return "value_type"
    if parent == "MonoBehaviour" or "complexcomponent" in joined or "baseclass9" in joined:
        return "mono_component"
    if parent == "Object":
        return "object_manager"
    return "generic"


def transform_from_method(name: str) -> list[str]:
    name = clean_identifier(name)
    if not name or name in BOILERPLATE_METHODS:
        return []

    verb, noun = split_verb_noun(name)
    if noun and (len(noun) < 3 or noun in {"To", "Ptr", "Url", "Api"} or "ToString" in noun):
        return []
    variants = []
    if noun:
        if verb == "Get":
            variants += [f"Set{noun}", f"Update{noun}", f"Resolve{noun}", f"Refresh{noun}"]
        elif verb == "Set":
            variants += [f"Get{noun}", f"Apply{noun}", f"Update{noun}", f"Reset{noun}"]
        elif verb == "Initialize":
            variants += [f"Refresh{noun}", f"Update{noun}", f"Validate{noun}", f"Build{noun}"]
        elif verb == "Update":
            variants += [f"Refresh{noun}", f"Process{noun}", f"Apply{noun}", f"Sync{noun}"]
        elif verb == "Process":
            variants += [f"Update{noun}", f"Handle{noun}", f"Finalize{noun}", f"Validate{noun}"]
        elif verb == "Handle":
            variants += [f"Process{noun}", f"Execute{noun}", f"Update{noun}", f"Reset{noun}"]
        elif verb == "On":
            variants += [f"Handle{noun}", f"Process{noun}", f"Notify{noun}", f"Reset{noun}"]
        elif verb == "TryGet":
            variants += [f"Resolve{noun}", f"Get{noun}", f"Update{noun}", f"Cache{noun}"]
        elif verb == "TryRead":
            variants += [f"Read{noun}", f"Resolve{noun}", f"Load{noun}", f"Cache{noun}"]
        elif verb == "Create":
            variants += [f"Initialize{noun}", f"Build{noun}", f"Refresh{noun}", f"Configure{noun}"]
        elif verb == "Read":
            variants += [f"Write{noun}", f"Resolve{noun}", f"Cache{noun}", f"Load{noun}"]
        elif verb == "Write":
            variants += [f"Read{noun}", f"Flush{noun}", f"Update{noun}", f"Store{noun}"]
        elif verb == "Register":
            variants += [f"Unregister{noun}", f"Refresh{noun}", f"Handle{noun}", f"Update{noun}"]
        elif verb == "Enable":
            variants += [f"Disable{noun}", f"Update{noun}", f"Refresh{noun}", f"Handle{noun}"]
        elif verb == "Disable":
            variants += [f"Enable{noun}", f"Reset{noun}", f"Refresh{noun}", f"Handle{noun}"]
        elif verb == "Start":
            variants += [f"Stop{noun}", f"Update{noun}", f"Initialize{noun}", f"Process{noun}"]
        elif verb == "Stop":
            variants += [f"Start{noun}", f"Reset{noun}", f"Cleanup{noun}", f"Handle{noun}"]
        else:
            variants += [f"Update{noun}", f"Process{noun}", f"Handle{noun}", f"Resolve{noun}"]

    if noun:
        variants += [f"Initialize{noun}", f"Validate{noun}", f"Cache{noun}", f"Build{noun}"]
    return dedupe_preserve([v for v in variants if is_pascal(v)])


def context_phrases(class_name: str, parent: str, readable: list[str], fields: list[str]) -> list[str]:
    counts: Counter[str] = Counter()

    for phrase in phrase_from_class(class_name):
        counts[phrase] += 6
    for phrase in phrase_from_class(parent):
        counts[phrase] += 3

    for method in readable:
        normalized = clean_identifier(method)
        if not normalized or normalized in BOILERPLATE_METHODS:
            continue
        verb, noun = split_verb_noun(normalized)
        if noun:
            counts[noun] += 4
            for tok in split_camel(noun):
                if tok not in GENERIC_TOKENS:
                    counts[tok] += 1
        elif verb:
            counts[verb] += 1

    for field in fields:
        phrase = phrase_from_field(field)
        if phrase:
            counts[phrase] += 3
            for tok in split_camel(phrase):
                if tok not in GENERIC_TOKENS:
                    counts[tok] += 1

    phrases = [name for name, _ in counts.most_common() if name and name not in GENERIC_TOKENS]
    return dedupe_preserve(phrases)


def add_candidates(target: list[str], used: set[str], items: list[str]) -> None:
    for item in items:
        if not item or not is_pascal(item) or item in used:
            continue
        used.add(item)
        target.append(item)


def build_domain_candidates(domain: str, phrases: list[str], class_name: str) -> list[str]:
    primary = phrases[:8]
    first = primary[0] if primary else "Component"
    second = primary[1] if len(primary) > 1 else "State"
    candidates: list[str] = []
    used: set[str] = set()

    def combos(verbs: list[str], nouns: list[str]) -> None:
        for verb in verbs:
            for noun in nouns:
                add_candidates(candidates, used, [f"{verb}{noun}"])
                if noun != second:
                    add_candidates(candidates, used, [f"{verb}{noun}{second}"])

    if domain == "animated_texture":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Texture", "Frame", "Animation", "Playback", "Material", "Render", "Handle", "Metadata", "Provider", "Sheet", "Binding"])]
            + ["AnimatedTexture", "TextureProvider", "FrameContext", "FrameMetadata", "PlaybackState", "RenderTarget", "MaterialBinding", "AnimationHandle", "TextureSheet", "TextureProperty"]
        )
        combos(
            ["Initialize", "Resolve", "Process", "Update", "Refresh", "Create", "Attach", "Detach", "Validate", "Handle", "Load", "Build", "Mark", "Check"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "InitializeAnimatedTexture",
                "UpdateAnimatedTexture",
                "RefreshAnimatedTexture",
                "ResolveTextureProvider",
                "ResolveFrameContext",
                "ResolveFrameMetadata",
                "ProcessAnimatedFrame",
                "ProcessDynamicTexture",
                "InitializeRenderTarget",
                "UpdateRenderTarget",
                "CreateTrackedHandle",
                "MarkHandleTracked",
                "CreateTextureSheetBinding",
                "EnumerateTextureSheetSprites",
                "CheckTextureProperty",
                "HandleRenderCallback",
                "CaptureTextureState",
                "CopyTextureUvRect",
                "FormatTextureTypeName",
                "ThrowUnsupportedTextureFormat",
            ],
        )
    elif domain == "ui_pointer":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Pointer", "Hover", "Drag", "Layout", "RectTransform", "Tab", "Scroll", "Observable", "Content", "PreCull"])]
            + ["PointerHover", "PointerDrag", "RectTransform", "LayoutState", "TabContent", "ObservableList", "ScrollState", "PreCullState"]
        )
        combos(
            ["Handle", "Update", "Refresh", "Initialize", "Resolve", "Cache", "Load", "Create", "Apply", "Invoke", "Process"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "OnPointerEnter",
                "OnPointerExit",
                "HandlePointerDown",
                "HandleBeginDrag",
                "HandleEndDrag",
                "UpdatePointerHover",
                "RefreshPointerHover",
                "CreateExitOperation",
                "StopPointerHoverRoutine",
                "LoadBeginDragContext",
                "InvokeBeginDragCallback",
                "InitializeStaticRectTransformEvents",
                "UpdateRectTransformDimensions",
                "HandleBeforeTransformParentChanged",
                "CacheLastTabContent",
                "ResolveLastTabContent",
                "FetchLastTabContent",
                "ShowTabContent",
            ],
        )
    elif domain == "network_player":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Network", "Player", "Avatar", "Pose", "Photon", "Connection", "Transform", "Serializer", "Room", "Proxy", "Capture"])]
            + ["NetworkState", "PlayerState", "AvatarState", "PhotonConnection", "NetworkTransform", "PlayerAvatar", "MovieCapture", "ProxySettings", "LocalizationContext"]
        )
        combos(
            ["Initialize", "Update", "Refresh", "Resolve", "Process", "Handle", "Serialize", "Apply", "Validate", "Queue", "Poll", "Set", "Sync", "Prepare", "Execute"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "InitializeNetworkSerialization",
                "SerializeNetworkTransformDelta",
                "ApplyNetworkTransformDelta",
                "ResolvePlayerAvatar",
                "SetPlayerAnimator",
                "UpdatePlayerVisibility",
                "CleanupPlayerDisconnect",
                "QueuePhotonConnectionTask",
                "PollPhotonConnection",
                "RefreshPhotonConnection",
                "UpdatePhotonConnectionState",
                "PrepareMovieCapture",
                "ExecuteMovieCapture",
                "InitializeEyeTracking",
                "UpdateEyeTracking",
                "UpdateHeadTracking",
                "ApplyAvatarProxySettings",
                "RefreshLocalizationContext",
            ],
        )
    elif domain == "lifecycle":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Lifecycle", "ServiceDescriptor", "Transform", "ConnectedBody", "State", "Stage", "Message"])]
            + ["LifecycleState", "ServiceDescriptor", "TransformState", "ConnectedBody", "LifecycleStage", "LifecycleMessage"]
        )
        combos(
            ["Initialize", "Update", "Process", "Resolve", "Fetch", "Read", "Write", "Select", "Access", "Enable", "Set", "Clear", "Apply", "Assign", "Create", "Configure"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "ResolveLastServiceDescriptor",
                "FetchLastServiceDescriptor",
                "ReadLastServiceDescriptor",
                "WriteServiceDescriptorValue",
                "SelectLastServiceDescriptor",
                "AccessLastServiceDescriptor",
                "ProcessInternalStateUpdate",
                "CreateEnabledTransformState",
                "ApplyLocalTransform",
                "AssignConnectedBody",
                "SetConnectedBody",
                "SetPosition",
                "SetRotation",
            ],
        )
    elif domain == "update_component":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Update", "Transform", "Component", "Rotation", "Position", "State"])]
            + ["ComponentUpdate", "TransformState", "ComponentState", "RotationOffset", "BufferedTime"]
        )
        combos(
            ["Initialize", "Read", "Apply", "Update", "Refresh", "Process", "Sync", "Resolve", "Handle", "Cache"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "ReadComponentUpdatePosition",
                "ApplyComponentUpdatePosition",
                "ApplyComponentUpdateRotationOffset",
                "SyncTransform",
                "ApplyTransform",
                "ReadTransformState",
                "RefreshComponentState",
            ],
        )
    elif domain == "mono_component":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Component", "Collision", "Trigger", "Visibility", "Application", "Coroutine", "State", "Font", "ConnectedBody"])]
            + ["ComponentState", "TriggerState", "CollisionState", "VisibilityState", "ApplicationState", "CoroutineState", "ConnectedBody", "FontAsset"]
        )
        combos(
            ["Initialize", "Update", "Refresh", "Process", "Handle", "Validate", "Reset", "Sync", "Apply", "Configure", "Bind", "Assign", "Create"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "HandleApplicationPause",
                "HandleApplicationQuit",
                "HandleCollisionState",
                "HandleTriggerState",
                "HandleVisibilityState",
                "UpdateFontAsset",
                "BindConnectedBody",
                "ConfigureConnectedBody",
                "AssignConnectedBody",
                "ApplyCameraBlendMode",
                "InitializeComponentState",
            ],
        )
    elif domain == "object_manager":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Manager", "Localization", "Culture", "Value", "Settings", "Proxy", "Limiter", "Control", "Data"])]
            + ["ManagerState", "LocalizationContext", "CurrentCulture", "LocalizedValue", "ProxySettings", "ControlData"]
        )
        combos(
            ["Initialize", "StaticInitialize", "Register", "Unregister", "Resolve", "Get", "Set", "Update", "Refresh", "Process", "Apply", "Load", "Save", "Create"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "RegisterLocalizationContext",
                "ResolveCurrentCulture",
                "GetLocalizedValueInternal",
                "CreateLocalizedInstance",
                "ApplyProxySettings",
                "UpdateProxyDelay",
                "RegisterProxyEvents",
                "ResolveSettingsPointer",
                "LimitEyelidRotation",
                "InitializeControlData",
            ],
        )
    elif domain == "value_type":
        nouns = dedupe_preserve(
            [n for n in primary if any(k in n for k in ["Range", "Value", "Data", "Hash", "Wrap", "Month", "Singleton"])]
            + ["RangeValue", "StructValue", "ControlValue", "HashValue"]
        )
        combos(
            ["Initialize", "Validate", "Pack", "Unpack", "Serialize", "Deserialize", "Compute", "Format", "Parse", "Evaluate", "Compare", "Normalize"],
            nouns,
        )
        add_candidates(
            candidates,
            used,
            [
                "EvaluateRangeValue",
                "PackStructValue",
                "UnpackStructValue",
                "ComputeStructHash",
                "FormatStructValue",
            ],
        )
    else:
        nouns = dedupe_preserve(primary + [first, second, "ComponentState", "ServiceState", "RuntimeState"])
        combos(
            ["Initialize", "Update", "Refresh", "Process", "Handle", "Resolve", "Apply", "Configure", "Validate", "Build", "Cache", "Reset"],
            nouns,
        )

    class_phrases = phrase_from_class(class_name)
    if class_phrases:
        add_candidates(
            candidates,
            used,
            [f"Initialize{class_phrases[0]}", f"Update{class_phrases[0]}", f"Process{class_phrases[0]}", f"Handle{class_phrases[0]}"],
        )

    return candidates


def build_candidates(class_name: str, parent: str, readable: list[str], fields: list[str]) -> list[str]:
    phrases = context_phrases(class_name, parent, readable, fields)
    candidates: list[str] = []
    used: set[str] = set()

    special_exact: dict[str, list[str]] = {
        "EyeAndHeadAnimator": [
            "InitializeEyeTracking",
            "UpdateEyeTracking",
            "UpdateHeadTracking",
            "UpdateLookTargetState",
            "HandleTriggerLookTarget",
            "HandleCollisionLookTarget",
            "CleanupEyeTracking",
        ],
        "LocalizationManager": [
            "InitializeLocalizationManager",
            "ResolveLocalizedValue",
            "RefreshLocalizationContext",
        ],
        "PoseAV3Update": [
            "InitializePoseProfile",
            "UpdateAv3Pose",
            "FinalizePoseProfilingSample",
        ],
        "VRCUdonMovieCapture": [
            "InitializeMovieCapture",
            "FinalizeMovieCapture",
            "ExecuteMovieCapture",
        ],
        "AvatarProxySettings": [
            "ApplyProxySettings",
            "RegisterProxyEvents",
            "UpdateProxyDelay",
        ],
    }
    add_candidates(candidates, used, special_exact.get(class_name, []))

    for field in fields:
        phrase = phrase_from_field(field)
        if not phrase:
            continue
        add_candidates(
            candidates,
            used,
            [
                f"Get{phrase}",
                f"Set{phrase}",
                f"Update{phrase}",
                f"Reset{phrase}",
            ],
        )

    add_candidates(candidates, used, build_domain_candidates(domain_for_class(class_name, parent, readable), phrases, class_name))

    for method in readable:
        add_candidates(candidates, used, transform_from_method(method))

    primary = phrases[0] if phrases else "Component"
    secondary = phrases[1] if len(phrases) > 1 else "State"
    fallback_verbs = [
        "Initialize",
        "Update",
        "Refresh",
        "Process",
        "Handle",
        "Resolve",
        "Apply",
        "Configure",
        "Validate",
        "Build",
        "Cache",
        "Reset",
        "Sync",
        "Register",
        "Load",
        "Save",
    ]
    for verb in fallback_verbs:
        add_candidates(
            candidates,
            used,
            [
                f"{verb}{primary}",
                f"{verb}{primary}{secondary}",
            ],
        )

    return candidates


def assign_names(class_name: str, parent: str, readable: list[str], fields: list[str], hashes: list[str], cache: dict[str, dict[str, str]]) -> dict[str, str]:
    class_map = cache.setdefault(class_name, {})
    unique_hashes = []
    seen = set()
    for value in hashes:
        if value not in seen:
            seen.add(value)
            unique_hashes.append(value)

    candidates = build_candidates(class_name, parent, readable, fields)
    used_names = set(class_map.values())
    candidate_index = 0

    primary = context_phrases(class_name, parent, readable, fields)
    fallback_subject = primary[0] if primary else "Component"

    for hash_name in unique_hashes:
        if hash_name in class_map:
            continue

        while candidate_index < len(candidates) and candidates[candidate_index] in used_names:
            candidate_index += 1

        if candidate_index < len(candidates):
            name = candidates[candidate_index]
            candidate_index += 1
        else:
            name = f"Process{fallback_subject}{len(class_map) + 1}"
            while name in used_names:
                name = f"Process{fallback_subject}{len(class_map) + 2}"

        used_names.add(name)
        class_map[hash_name] = name

    return class_map


def process_batch(batch_number: int, cache: dict[str, dict[str, str]]) -> int:
    batch_path = OUTPUT_DIR / f"codex_batch_{batch_number:03d}.json"
    pred_path = OUTPUT_DIR / f"codex_pred_{batch_number:03d}.json"

    if pred_path.exists() and pred_path.stat().st_size > 0:
        try:
            existing = json.loads(pred_path.read_text(encoding="utf-8"))
            if isinstance(existing, dict) and existing:
                return len(existing)
        except json.JSONDecodeError:
            pass

    data = json.loads(batch_path.read_text(encoding="utf-8"))
    results: dict[str, str] = {}

    for item in data:
        class_map = assign_names(
            item["class"],
            item.get("parent", ""),
            item.get("readable_methods", []),
            item.get("fields", []),
            item.get("hash_methods", []),
            cache,
        )
        for hash_name in dict.fromkeys(item.get("hash_methods", [])):
            results[f"{item['class']}::{hash_name}"] = class_map[hash_name]

    pred_path.write_text(json.dumps(results, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    return len(results)


def main() -> None:
    total_predictions = 0
    completed_batches = 0
    cache: dict[str, dict[str, str]] = {}

    for batch_number in range(31, 42):
        count = process_batch(batch_number, cache)
        total_predictions += count
        completed_batches += 1

    print(f"Done: {total_predictions} total predictions across {completed_batches} batches")


if __name__ == "__main__":
    main()
