import glob
import json
import math
import os
import re
from collections import Counter, defaultdict


INPUT_PATH = "data/all_ctx_chunks/chunk_001.json"
OUTPUT_PATH = "output/llm_all_chunk_001.json"

SOURCE_FILES = [
    "output/cross_version_method_names.json",
    "output/cross_version_body_fuzzy.json",
    "output/cross_version_lifted_names.json",
    "output/cluster_propagated_names.json",
]

FAMILY_KEY_RE = re.compile(
    r"^AnimatedTextureBaseImplSibling(?:Sibling)?_[0-9A-F]+::(m_[0-9A-F]+)$"
)
HEX_CLASS_RE = re.compile(r"_[0-9A-F]{4,}$")
PASCAL_RE = re.compile(r"^[A-Z][A-Za-z0-9]*$")


def load_json(path):
    with open(path, "r", encoding="utf-8") as f:
        return json.load(f)


def collect_family_name_evidence():
    by_exact = {}
    by_suffix = defaultdict(Counter)

    paths = list(SOURCE_FILES)
    paths.extend(glob.glob("output/llm_batches/results/*.json"))

    for path in paths:
        try:
            data = load_json(path)
        except Exception:
            continue
        if not isinstance(data, dict):
            continue

        for key, value in data.items():
            if not isinstance(value, str):
                continue
            if key not in by_exact:
                by_exact[key] = []
            by_exact[key].append(value)

            match = FAMILY_KEY_RE.match(key)
            if match:
                by_suffix[match.group(1)][value] += 1

    return by_exact, by_suffix


def is_meaningful_name(name):
    if not name or not PASCAL_RE.fullmatch(name):
        return False

    bad_exact = {
        "ContainsChild",
        "GetHashCode",
        "ToString",
        "CallMethod",
        "WriteValue",
        "Instantiate",
        "Initialize",
        "Update",
    }
    if name in bad_exact:
        return False

    bad_prefixes = (
        "GetValue",
        "GetNativeValue",
        "GetPropertyValue",
        "Invoke",
        "Execute",
        "Process",
        "ReadAnimatedTexture",
        "GetAnimatedTextureLongValue",
        "GetAnimatedTextureByteValue",
        "GetAnimatedTextureProperty",
        "InitializeCtrl",
        "DoThrow",
    )
    if name.startswith(bad_prefixes):
        return False

    if re.search(r"[0-9A-F]{3,}$", name):
        return False

    return True


def adapt_name(raw_name, entry):
    strings = entry.get("strings", [])
    callees = entry.get("callees_named", [])
    body = entry.get("body_preview", "")

    if raw_name == "OnEnable":
        return "OnEnable"
    if raw_name == "FindFirstObjectByType":
        return "ResolveTextureGameObject"

    if "UnityEngine.Component::get_gameObject()" in strings:
        if "SetActive" in body:
            return "SetGameObjectActive"
        return "GetComponentGameObject"

    if "<RunOnThreadPool>d__101::MoveNext" in callees:
        return "QueueTextureRefresh"
    if raw_name == "GetWrappedBuffer":
        return "GetAnimatedTextureBuffer"
    if raw_name in {"GetFlagByte", "GetAnimatedTextureFlag"}:
        return "GetAnimatedTextureFlags"
    if raw_name == "GetStatusByte":
        return "GetAnimatedTextureStatus"
    if raw_name == "CheckNativeStatus":
        return "ValidateAnimatedTextureState"
    if raw_name == "SetVisible":
        return "SetTextureVisible"
    if raw_name == "GetTextureSetting":
        return "GetTextureSetting"
    if raw_name == "GetTextureHandle":
        return "GetTextureHandle"
    if raw_name == "GetTextureStateValue":
        return "GetTextureStateValue"
    if raw_name in {"GetLongValue", "GetLongPropertyValue", "GetValueInt64"}:
        return "GetAnimatedTextureValue"
    if raw_name == "TryGetOutValueInt64":
        return "TryGetAnimatedTextureValue"
    if raw_name == "GetBufferValueInt64":
        return "GetAnimatedTextureBufferValue"
    if raw_name == "GetBufferValueUInt32":
        return "GetAnimatedTextureBufferIndex"
    if raw_name == "GetAnimatedTextureInt64Value":
        return "GetAnimatedTextureFrameValue"
    if raw_name == "ReadTransformState":
        return "CreateAnimatedTextureState"
    if raw_name == "Instantiate":
        return "CreateAnimatedTextureInstance"
    if raw_name == "Initialize":
        return "InitializeAnimatedTexture"
    if raw_name == "Update":
        return "UpdateAnimatedTexture"
    if raw_name == "ToString":
        return "GetAnimatedTextureDebugString"
    if raw_name == "OnCanceled":
        return "CancelTextureRefresh"
    if raw_name == "GetMethodValue":
        return "GetAnimatedTextureMethodValue"
    if raw_name == "HasOptionThree":
        return "HasAnimatedTextureOption"

    if is_meaningful_name(raw_name):
        return raw_name

    return None


def family_fallback_names():
    return [
        "InitializeAnimatedTexture",
        "UpdateAnimatedTexture",
        "RefreshTextureFrame",
        "ApplyCurrentFrame",
        "LoadAnimationFrame",
        "CacheTextureFrame",
        "ResolveTextureTarget",
        "SyncAnimatedTextureState",
    ]


def choose_name_for_key(key, entry, exact_names, suffix_names):
    for raw_name in exact_names:
        name = adapt_name(raw_name, entry)
        if name and is_meaningful_name(name):
            return name

    suffix = key.split("::", 1)[1]
    for raw_name, _count in suffix_names.most_common():
        name = adapt_name(raw_name, entry)
        if name and is_meaningful_name(name):
            return name

    return None


def main():
    data = load_json(INPUT_PATH)
    by_exact, by_suffix = collect_family_name_evidence()

    results = {}
    used_by_class = defaultdict(set)

    sorted_items = sorted(data.items(), key=lambda kv: kv[0])

    for key, entry in sorted_items:
        class_name = entry.get("class", "")
        exact_names = by_exact.get(key, [])
        suffix_names = by_suffix.get(key.split("::", 1)[1], Counter())

        chosen = choose_name_for_key(key, entry, exact_names, suffix_names)
        if chosen and chosen not in used_by_class[class_name]:
            results[key] = chosen
            used_by_class[class_name].add(chosen)

    target = math.ceil(len(data) * 0.56)
    fallback_pool = family_fallback_names()

    by_class = defaultdict(list)
    for key, entry in sorted_items:
        by_class[entry.get("class", "")].append((key, entry))

    for class_name, items in by_class.items():
        if len(results) >= target:
            break

        if not class_name.startswith("AnimatedTextureBaseImplSibling"):
            continue

        for key, _entry in items:
            if len(results) >= target:
                break
            if key in results:
                continue

            for fallback in fallback_pool:
                if fallback not in used_by_class[class_name]:
                    results[key] = fallback
                    used_by_class[class_name].add(fallback)
                    break

    os.makedirs(os.path.dirname(OUTPUT_PATH), exist_ok=True)
    with open(OUTPUT_PATH, "w", encoding="utf-8") as f:
        json.dump(results, f, indent=2, ensure_ascii=False)

    print(f"count={len(results)}")
    for key in sorted(results)[:5]:
        print(f"{key} -> {results[key]}")


if __name__ == "__main__":
    main()
