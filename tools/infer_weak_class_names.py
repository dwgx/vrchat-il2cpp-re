#!/usr/bin/env python3
from __future__ import annotations

import argparse
import json
import os
import re
import sys
from collections import Counter, defaultdict
from dataclasses import dataclass, field
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")


ROOT = Path(__file__).resolve().parent.parent

WEAK_RE = re.compile(
    r"^(BaseClass|Type|Static|Major|Service|Struct|Mono|DataOnly|Unknown|Record|NestedType|"
    r"EmptyType|EmptyStruct|AsyncStateMachine|Enumerator|Delegate|LifecycleComponent|"
    r"UpdateComponent|ComplexComponent|AnimatedTextureBase|NetworkItem|NetworkSyncable|"
    r"VRCUiManagerSibling|VRC_Main|VRC_Secondary|VRCUi|MajorSystem|TransformGame|UIRect|"
    r"GameObjectHandler|PointerEnter|VRCInit|InitializeVRSDK)\w*_[0-9A-F]+$",
    re.I,
)
HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4,}$", re.I)
HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3,4}$", re.I)
OBF_METHOD_RE = re.compile(r"^[\u00CC-\u00CF]+$")
TOKEN_RE = re.compile(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+")

METHOD_BOILERPLATE = {
    ".ctor",
    ".cctor",
    "Finalize",
    "ToString",
    "GetHashCode",
    "Equals",
    "GetType",
    "MemberwiseClone",
    "Dispose",
    "MoveNext",
    "Reset",
    "Current",
    "get_Current",
    "set_Current",
    "IsInvoking",
    "CancelInvoke",
    "Invoke",
    "InvokeRepeating",
    "StartCoroutine",
    "StartCoroutine_Auto",
    "StopCoroutine",
    "StopAllCoroutines",
    "get_useGUILayout",
    "set_useGUILayout",
    "print",
    "Internal_CancelInvokeAll",
    "Internal_IsInvokingAll",
    "InvokeDelayed",
    "IsObjectMonoBehaviour",
    "StartCoroutineManaged",
    "StartCoroutineManaged2",
    "StopCoroutineManaged",
    "StopCoroutineFromEnumeratorManaged",
    "GetScriptClassName",
    "OnCancellationTokenCreated",
    "get_destroyCancellationToken",
    "RaiseCancellation",
}

LOW_VALUE_PREFIXES = (
    "System.",
    "op_",
    "add_",
    "remove_",
)

TOKEN_STOPWORDS = {
    "a",
    "an",
    "and",
    "apply",
    "async",
    "auto",
    "awake",
    "base",
    "behaviour",
    "behavior",
    "bind",
    "build",
    "cache",
    "call",
    "callback",
    "cancel",
    "check",
    "class",
    "clear",
    "collect",
    "compare",
    "component",
    "compute",
    "configure",
    "contains",
    "copy",
    "create",
    "current",
    "data",
    "decode",
    "default",
    "delayed",
    "destroy",
    "disable",
    "disposed",
    "dispose",
    "do",
    "enable",
    "encode",
    "enter",
    "equal",
    "equals",
    "event",
    "exit",
    "fetch",
    "find",
    "first",
    "fixed",
    "for",
    "from",
    "game",
    "generic",
    "get",
    "handle",
    "hash",
    "id",
    "impl",
    "info",
    "initialize",
    "instance",
    "internal",
    "invoke",
    "is",
    "item",
    "last",
    "late",
    "link",
    "load",
    "logic",
    "managed",
    "map",
    "method",
    "mono",
    "name",
    "native",
    "next",
    "null",
    "object",
    "offsets",
    "on",
    "or",
    "out",
    "parent",
    "parse",
    "path",
    "pause",
    "pointer",
    "print",
    "process",
    "query",
    "quit",
    "raise",
    "read",
    "refresh",
    "remove",
    "reset",
    "resolve",
    "return",
    "run",
    "save",
    "select",
    "service",
    "set",
    "sibling",
    "snap",
    "start",
    "state",
    "static",
    "stay",
    "step",
    "stop",
    "sync",
    "system",
    "task",
    "text",
    "thread",
    "to",
    "token",
    "transform",
    "type",
    "ui",
    "unity",
    "update",
    "use",
    "valid",
    "value",
    "values",
    "void",
    "write",
}


@dataclass
class ClassAggregate:
    name: str
    namespaces: set[str] = field(default_factory=set)
    parents: Counter[str] = field(default_factory=Counter)
    representative_methods: list[str] = field(default_factory=list)
    representative_total: int = 0
    representative_named_count: int = 0
    semantic_methods: Counter[str] = field(default_factory=Counter)
    informative_methods: Counter[str] = field(default_factory=Counter)
    strings: Counter[str] = field(default_factory=Counter)
    callees: Counter[str] = field(default_factory=Counter)

    @property
    def parent(self) -> str:
        if not self.parents:
            return ""
        return self.parents.most_common(1)[0][0]

    @property
    def named_ratio(self) -> float:
        if not self.representative_total:
            return 0.0
        return self.representative_named_count / self.representative_total


@dataclass
class Proposal:
    old_name: str
    new_name: str
    confidence: float
    rule: str
    evidence: str
    methods_sample: list[str]
    strings_sample: list[str]
    emitted: bool = False
    skipped_reason: str = ""


@dataclass
class Features:
    cls: ClassAggregate
    family: str
    method_set: set[str]
    informative_set: set[str]
    lower_methods: set[str]
    lower_informative: set[str]
    strings: list[str]
    callees: list[str]
    context_text: str
    sibling_text: str
    method_text: str
    family_text: str


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description="Infer semantic names for weak hash-suffixed classes.")
    parser.add_argument("--mapping", default=str(ROOT / "output" / "name_mapping.json"))
    parser.add_argument("--deobf", default=str(ROOT / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--precise", default=str(ROOT / "data" / "precise_dump.json"))
    parser.add_argument("--contexts", default=str(ROOT / "data" / "hash_method_contexts.json"))
    parser.add_argument("--output", default=str(ROOT / "output" / "weak_class_renames.json"))
    parser.add_argument("--sample-count", type=int, default=20)
    parser.add_argument("--min-methods", type=int, default=5)
    parser.add_argument("--min-named-ratio", type=float, default=0.50)
    parser.add_argument("--min-confidence", type=float, default=0.60)
    return parser.parse_args()


def load_json(path: str | Path):
    with Path(path).open("r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path: str | Path) -> None:
    parent = Path(path).parent
    if str(parent):
        os.makedirs(parent, exist_ok=True)


def flatten_classes(dump: dict) -> list[tuple[str, dict]]:
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]


def strip_hex_suffix(name: str) -> str:
    return HEX_SUFFIX_RE.sub("", name)


def is_weak_class_name(name: str) -> bool:
    return bool(name) and bool(WEAK_RE.fullmatch(name))


def is_semantic_method_name(name: str | None) -> bool:
    return (
        isinstance(name, str)
        and name != ""
        and not HASH_METHOD_RE.fullmatch(name)
        and not OBF_METHOD_RE.fullmatch(name)
    )


def is_informative_method_name(name: str | None) -> bool:
    return bool(name) and is_semantic_method_name(name) and name not in METHOD_BOILERPLATE and not name.startswith(LOW_VALUE_PREFIXES)


def tokenize(text: str) -> list[str]:
    out: list[str] = []
    for piece in re.split(r"[^A-Za-z0-9]+", text):
        for token in TOKEN_RE.findall(piece):
            low = token.lower()
            if low.isdigit() or len(low) < 2 or low in TOKEN_STOPWORDS:
                continue
            out.append(token)
    return out


def pick_methods_sample(methods: set[str], limit: int = 8) -> list[str]:
    def key(item: str) -> tuple[int, int, str]:
        return (-len(tokenize(item)), -len(item), item)

    return sorted(methods, key=key)[:limit]


def pick_strings_sample(counter: Counter[str], limit: int = 6) -> list[str]:
    return [text for text, _ in counter.most_common(limit)]


def build_aggregates(deobf: dict, precise: dict, contexts: dict) -> dict[str, ClassAggregate]:
    deobf_items = flatten_classes(deobf)
    precise_items = flatten_classes(precise)
    paired = zip(deobf_items, precise_items)
    aggregates: dict[str, ClassAggregate] = {}

    for (dns, dcls), (_, pcls) in paired:
        name = str(dcls.get("name") or "")
        if not is_weak_class_name(name):
            continue
        agg = aggregates.setdefault(name, ClassAggregate(name=name))
        agg.namespaces.add(dns)
        for parent in (dcls.get("parent"), pcls.get("parent")):
            if parent:
                agg.parents[str(parent)] += 1

        methods = [str(item) for item in (dcls.get("methods") or []) if isinstance(item, str)]
        named_methods = [method for method in methods if is_semantic_method_name(method)]
        record_key = (len(named_methods) / max(1, len(methods)), len(named_methods), len(methods))
        current_key = (
            agg.representative_named_count / max(1, agg.representative_total),
            agg.representative_named_count,
            agg.representative_total,
        )
        if record_key > current_key:
            agg.representative_methods = methods
            agg.representative_total = len(methods)
            agg.representative_named_count = len(named_methods)

        for method in named_methods:
            agg.semantic_methods[method] += 1
            if is_informative_method_name(method):
                agg.informative_methods[method] += 1

    for key, payload in contexts.items():
        if "::" not in key:
            continue
        class_name, _ = key.split("::", 1)
        agg = aggregates.get(class_name)
        if not agg:
            continue
        for text in payload.get("strings") or []:
            if isinstance(text, str) and text:
                agg.strings[text] += 1
        for text in payload.get("callees_named") or []:
            if isinstance(text, str) and text:
                agg.callees[text] += 1

    return aggregates


def build_family_maps(aggregates: dict[str, ClassAggregate]) -> tuple[dict[str, list[str]], dict[str, Counter[str]], dict[str, Counter[str]]]:
    family_members: dict[str, list[str]] = defaultdict(list)
    family_methods: dict[str, Counter[str]] = defaultdict(Counter)
    family_contexts: dict[str, Counter[str]] = defaultdict(Counter)

    for name, agg in aggregates.items():
        family = strip_hex_suffix(name)
        family_members[family].append(name)
        family_methods[family].update(agg.informative_methods)
        family_contexts[family].update(agg.strings)
        family_contexts[family].update(agg.callees)

    return family_members, family_methods, family_contexts


def build_features(
    agg: ClassAggregate,
    family_methods: Counter[str],
    family_contexts: Counter[str],
) -> Features:
    method_set = set(agg.semantic_methods)
    informative_set = set(agg.informative_methods)
    strings = list(agg.strings.elements())
    callees = list(agg.callees.elements())

    sibling_methods = family_methods.copy()
    sibling_contexts = family_contexts.copy()
    sibling_methods.subtract(agg.informative_methods)
    sibling_contexts.subtract(agg.strings)
    sibling_contexts.subtract(agg.callees)

    sibling_methods = Counter({key: value for key, value in sibling_methods.items() if value > 0})
    sibling_contexts = Counter({key: value for key, value in sibling_contexts.items() if value > 0})

    method_text = "\n".join(sorted(informative_set))
    context_text = "\n".join([*strings, *callees])
    sibling_text = "\n".join([*sibling_methods.elements(), *sibling_contexts.elements()])

    return Features(
        cls=agg,
        family=strip_hex_suffix(agg.name),
        method_set=method_set,
        informative_set=informative_set,
        lower_methods={value.lower() for value in method_set},
        lower_informative={value.lower() for value in informative_set},
        strings=strings,
        callees=callees,
        context_text=context_text.lower(),
        sibling_text=sibling_text.lower(),
        method_text=method_text.lower(),
        family_text=strip_hex_suffix(agg.name).lower(),
    )


def has_method(features: Features, needle: str) -> bool:
    needle = needle.lower()
    return needle in features.lower_methods or needle in features.lower_informative


def method_contains(features: Features, needle: str) -> bool:
    needle = needle.lower()
    return any(needle in value for value in features.lower_methods)


def count_method_contains(features: Features, needle: str) -> int:
    needle = needle.lower()
    return sum(1 for value in features.lower_methods if needle in value)


def context_contains(features: Features, needle: str) -> bool:
    needle = needle.lower()
    return needle in features.context_text


def sibling_contains(features: Features, needle: str) -> bool:
    needle = needle.lower()
    return needle in features.sibling_text


def choose_name(options: list[str], existing_names: set[str]) -> str | None:
    for option in options:
        if option not in existing_names:
            return option
    return None


def adjust_confidence(base: float, features: Features, keywords: list[str], component_bonus: bool = False) -> float:
    score = base
    support = sum(
        1
        for keyword in keywords
        if method_contains(features, keyword) or context_contains(features, keyword) or sibling_contains(features, keyword)
    )
    if support >= max(2, len(keywords) // 2):
        score += 0.04
    if support >= max(3, len(keywords) - 1):
        score += 0.03
    if len(features.informative_set) >= 8:
        score += 0.02
    if component_bonus and "monobehaviour" in features.cls.parent.lower():
        score += 0.03
    return min(score, 0.99)


def make_proposal(
    features: Features,
    existing_names: set[str],
    options: list[str],
    confidence: float,
    rule: str,
    evidence: str,
) -> Proposal | None:
    new_name = choose_name(options, existing_names)
    if not new_name:
        return None
    return Proposal(
        old_name=features.cls.name,
        new_name=new_name,
        confidence=confidence,
        rule=rule,
        evidence=evidence,
        methods_sample=pick_methods_sample(features.informative_set),
        strings_sample=pick_strings_sample(features.cls.strings),
    )


def rule_rect_transform_dimension_change(features: Features, existing_names: set[str]) -> Proposal | None:
    if not (
        has_method(features, "OnRectTransformDimensionsChange")
        or (
            "recttransform" in features.family_text
            and ("dimensions" in features.family_text or method_contains(features, "dimension"))
        )
    ):
        return None
    if not (
        has_method(features, "OnBeforeTransformParentChanged")
        or has_method(features, "OnTransformParentChanged")
        or has_method(features, "GetLastRectTransformDimensions")
    ):
        return None
    confidence = adjust_confidence(
        0.88,
        features,
        ["recttransform", "dimension", "canvas", "parentchanged"],
        component_bonus=True,
    )
    return make_proposal(
        features,
        existing_names,
        ["RectTransformDimensionsChangeHandler", "RectTransformDimensionObserver"],
        confidence,
        "rect_transform_dimensions",
        "RectTransform dimension callbacks plus transform-parent change hooks.",
    )


def rule_connected_body(features: Features, existing_names: set[str]) -> Proposal | None:
    if count_method_contains(features, "connectedbody") < 3 and not context_contains(features, "set_connectedbody"):
        return None
    if not any(method_contains(features, needle) for needle in ("linkconnectedbody", "configureconnectedbody", "updateconnectedbody", "bindconnectedbody")):
        return None
    confidence = adjust_confidence(
        0.83,
        features,
        ["connectedbody", "joint", "rigidbody"],
        component_bonus=False,
    )
    return make_proposal(
        features,
        existing_names,
        ["ConnectedBodyBinder", "ConnectedBodyController", "ConnectedBodyLinker"],
        confidence,
        "connected_body",
        "Multiple ConnectedBody lifecycle methods with Joint/Rigidbody context.",
    )


def rule_parent_constraint_offset_sync(features: Features, existing_names: set[str]) -> Proposal | None:
    explicit_offset_update = method_contains(features, "updateparentconstraintoffset") or method_contains(features, "updateconstraintoffset")
    translation_offset_context = context_contains(features, "parentconstraint::set_translationoffsets") or context_contains(
        features, "parentconstraint::get_translationoffsets"
    )
    if not (explicit_offset_update or translation_offset_context):
        return None
    if not any(
        method_contains(features, needle)
        for needle in ("synctransform", "createfromtorotation", "alignposition", "setrotation", "setposition")
    ):
        return None
    confidence = adjust_confidence(
        0.82,
        features,
        ["parentconstraint", "rotation", "position", "offset", "transform"],
        component_bonus=True,
    )
    return make_proposal(
        features,
        existing_names,
        ["ParentConstraintOffsetSyncComponent", "ParentConstraintAlignmentComponent"],
        confidence,
        "parent_constraint_offsets",
        "ParentConstraint offset updates with transform position/rotation alignment methods.",
    )


def rule_animator_goal_transform_sync(features: Features, existing_names: set[str]) -> Proposal | None:
    if not method_contains(features, "syncanimatorgoalrotation"):
        return None
    if not any(
        method_contains(features, needle)
        for needle in ("invertrotationtarget", "readtransformrotation", "setrotationcurrent", "synctransform", "syncposefromrotationcurrent")
    ):
        return None
    if not (context_contains(features, "animator::setgoalrotation") or context_contains(features, "animator::setgoalposition")):
        return None
    confidence = adjust_confidence(
        0.87,
        features,
        ["animator", "goal", "rotation", "position", "quaternion"],
        component_bonus=True,
    )
    return make_proposal(
        features,
        existing_names,
        ["AnimatorGoalTransformSyncComponent", "AnimatorGoalRotationSyncComponent", "TransformRotationSyncComponent"],
        confidence,
        "animator_goal_transform_sync",
        "Animator goal rotation sync with transform rotation/position reads and writes.",
    )


def rule_audio_source_controller(features: Features, existing_names: set[str]) -> Proposal | None:
    if not any(
        method_contains(features, needle)
        for needle in ("stopaudio", "setaudioclippreservingvolume", "configureaudiosource", "getaudiopitch")
    ):
        return None
    if not context_contains(features, "audiosource::"):
        return None
    confidence = adjust_confidence(
        0.81,
        features,
        ["audiosource", "audio", "clip", "volume", "pitch"],
        component_bonus=False,
    )
    return make_proposal(
        features,
        existing_names,
        ["AudioSourceController", "AudioSourceComponentController"],
        confidence,
        "audio_source",
        "AudioSource clip/volume/pitch methods backed by AudioSource API references.",
    )


def rule_async_operation_monitor(features: Features, existing_names: set[str]) -> Proposal | None:
    if count_method_contains(features, "checkasyncoperationcomplete") < 2 and not context_contains(features, "asyncoperation::get_isdone"):
        return None
    confidence = adjust_confidence(
        0.79,
        features,
        ["asyncoperation", "isdone", "complete"],
        component_bonus=True,
    )
    return make_proposal(
        features,
        existing_names,
        ["AsyncOperationMonitorComponent", "AsyncOperationWatcherComponent"],
        confidence,
        "async_operation",
        "Repeated async-operation completion checks with AsyncOperation isDone context.",
    )


def rule_humanoid_transform_path_syncable(features: Features, existing_names: set[str]) -> Proposal | None:
    required = [
        "bindsynctransformpath",
        "cachesynctransformpath",
        "findrelativetransform",
    ]
    if not all(method_contains(features, needle) for needle in required):
        return None
    if not any(method_contains(features, needle) for needle in ("updatehumanoidsyncpose", "updatebipedik", "processnetworkdatasynchronization")):
        return None
    if not any(has_method(features, needle) for needle in ("Encode", "Decode", "NeedsSync")):
        return None
    confidence = adjust_confidence(
        0.77,
        features,
        ["humanoid", "biped", "transform", "network", "sync"],
        component_bonus=False,
    )
    return make_proposal(
        features,
        existing_names,
        ["HumanoidTransformPathSyncable", "HumanoidTransformSyncable", "BipedIkTransformSyncable"],
        confidence,
        "humanoid_transform_path_syncable",
        "Network encode/decode flow plus humanoid transform-path binding and refresh methods.",
    )


def rule_shader_property_id_cache(features: Features, existing_names: set[str]) -> Proposal | None:
    shader_id_methods = count_method_contains(features, "shaderpropertyid")
    if shader_id_methods < 4 and not context_contains(features, "shader::propertytoid"):
        return None
    confidence = adjust_confidence(
        0.84,
        features,
        ["shader", "property", "id"],
        component_bonus=False,
    )
    return make_proposal(
        features,
        existing_names,
        ["ShaderPropertyIdCache", "ShaderPropertyIdMap"],
        confidence,
        "shader_property_id",
        "Cluster of ShaderPropertyId compute/fetch/cache/resolve methods with Shader.PropertyToID context.",
    )


def rule_particle_service_controller(features: Features, existing_names: set[str]) -> Proposal | None:
    if not (
        method_contains(features, "initializeparticleserviceparticles")
        or count_method_contains(features, "configureparticle") >= 2
    ):
        return None
    if not context_contains(features, "particlesystem/"):
        return None
    confidence = adjust_confidence(
        0.76,
        features,
        ["particle", "emissionmodule", "shapemodule", "renderer"],
        component_bonus=False,
    )
    return make_proposal(
        features,
        existing_names,
        ["ParticleServiceController", "ParticleConfigurationController"],
        confidence,
        "particle_service",
        "Particle initialization/configuration methods with ParticleSystem module API refs.",
    )


def rule_service_descriptor_cache_accessor(features: Features, existing_names: set[str]) -> Proposal | None:
    service_descriptor_hits = count_method_contains(features, "servicedescriptor")
    cacheitem_hits = features.context_text.count("servicedescriptorcacheitem::get_last")
    if service_descriptor_hits < 5 and not (service_descriptor_hits >= 3 and cacheitem_hits >= 3):
        return None
    confidence = adjust_confidence(
        0.81,
        features,
        ["servicedescriptor", "cache", "last"],
        component_bonus=False,
    )
    return make_proposal(
        features,
        existing_names,
        ["ServiceDescriptorCacheAccessor", "LastServiceDescriptorAccessor"],
        confidence,
        "service_descriptor_cache",
        "Repeated last-service-descriptor accessor methods with ServiceDescriptorCacheItem::get_Last callee context.",
    )


def rule_transform_rotation_sync(features: Features, existing_names: set[str]) -> Proposal | None:
    if not method_contains(features, "synctransform"):
        return None
    rotation_hits = sum(
        1
        for needle in ("readtransformrotation", "copyrotation", "setrotation", "invertrotation", "rotationcurrent")
        if method_contains(features, needle)
    )
    if rotation_hits < 2:
        return None
    if not (context_contains(features, "transform::get_rotation") or context_contains(features, "transform::set_rotation")):
        return None
    confidence = adjust_confidence(
        0.68,
        features,
        ["transform", "rotation", "quaternion"],
        component_bonus=True,
    )
    return make_proposal(
        features,
        existing_names,
        ["TransformRotationSyncComponent"],
        confidence,
        "transform_rotation_sync",
        "Transform sync methods dominated by rotation read/write operations.",
    )


RULES = [
    rule_rect_transform_dimension_change,
    rule_connected_body,
    rule_animator_goal_transform_sync,
    rule_parent_constraint_offset_sync,
    rule_audio_source_controller,
    rule_async_operation_monitor,
    rule_humanoid_transform_path_syncable,
    rule_shader_property_id_cache,
    rule_particle_service_controller,
    rule_service_descriptor_cache_accessor,
    rule_transform_rotation_sync,
]


def infer_proposals(
    aggregates: dict[str, ClassAggregate],
    family_methods: dict[str, Counter[str]],
    family_contexts: dict[str, Counter[str]],
    existing_names: set[str],
    min_methods: int,
    min_named_ratio: float,
    min_confidence: float,
) -> tuple[list[Proposal], dict[str, str], int]:
    eligible_count = 0
    candidates: list[Proposal] = []

    for name, agg in sorted(aggregates.items()):
        if name.startswith("AnimatedTextureBase"):
            continue
        if agg.representative_total < min_methods:
            continue
        if agg.representative_named_count < min_methods:
            continue
        if agg.named_ratio < min_named_ratio:
            continue
        eligible_count += 1
        features = build_features(agg, family_methods[strip_hex_suffix(name)], family_contexts[strip_hex_suffix(name)])
        for rule in RULES:
            proposal = rule(features, existing_names)
            if proposal:
                candidates.append(proposal)
                break

    candidates.sort(key=lambda item: (-item.confidence, item.old_name, item.new_name))
    used_old_names: set[str] = set()
    used_new_names: set[str] = set()
    rename_map: dict[str, str] = {}
    name_collision_winners: dict[str, Proposal] = {}

    for proposal in candidates:
        if proposal.confidence < min_confidence:
            proposal.skipped_reason = "low_confidence"
            continue
        winner = name_collision_winners.get(proposal.new_name)
        if winner is None:
            name_collision_winners[proposal.new_name] = proposal
            continue
        proposal.skipped_reason = f"name_collision:{winner.old_name}"

    for proposal in candidates:
        winner = name_collision_winners.get(proposal.new_name)
        if winner is not proposal:
            continue
        if proposal.old_name in used_old_names:
            proposal.skipped_reason = "duplicate_old_name"
            continue
        if proposal.new_name in used_new_names or proposal.new_name in existing_names:
            proposal.skipped_reason = "duplicate_new_name"
            continue
        proposal.emitted = True
        used_old_names.add(proposal.old_name)
        used_new_names.add(proposal.new_name)
        rename_map[proposal.old_name] = proposal.new_name

    return candidates, rename_map, eligible_count


def print_report(candidates: list[Proposal], rename_map: dict[str, str], eligible_count: int, sample_count: int) -> None:
    print(f"Eligible weak classes: {eligible_count}")
    print(f"Candidates with rule matches: {len(candidates)}")
    print(f"Renames proposed: {len(rename_map)}")
    print()
    print(f"Top {sample_count} candidates:")
    for proposal in candidates[:sample_count]:
        status = "emit" if proposal.emitted else f"skip:{proposal.skipped_reason or 'filtered'}"
        methods = ", ".join(proposal.methods_sample[:5])
        strings = "; ".join(proposal.strings_sample[:3])
        print(
            f"{proposal.confidence:.2f} {status} {proposal.old_name} -> {proposal.new_name} "
            f"[{proposal.rule}]"
        )
        print(f"  evidence: {proposal.evidence}")
        if methods:
            print(f"  methods: {methods}")
        if strings:
            print(f"  strings: {strings}")


def main() -> int:
    args = parse_args()
    mapping = load_json(args.mapping)
    deobf = load_json(args.deobf)
    precise = load_json(args.precise)
    contexts = load_json(args.contexts)

    existing_names = set(str(value) for value in mapping.get("classes", {}).values() if isinstance(value, str))

    aggregates = build_aggregates(deobf, precise, contexts)
    family_members, family_methods, family_contexts = build_family_maps(aggregates)
    _ = family_members

    candidates, rename_map, eligible_count = infer_proposals(
        aggregates=aggregates,
        family_methods=family_methods,
        family_contexts=family_contexts,
        existing_names=existing_names,
        min_methods=args.min_methods,
        min_named_ratio=args.min_named_ratio,
        min_confidence=args.min_confidence,
    )

    ensure_parent_dir(args.output)
    with Path(args.output).open("w", encoding="utf-8") as handle:
        json.dump(dict(sorted(rename_map.items())), handle, indent=2, ensure_ascii=False)
        handle.write("\n")

    print_report(candidates, rename_map, eligible_count, args.sample_count)
    print()
    print(f"Wrote {len(rename_map)} renames to {args.output}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
