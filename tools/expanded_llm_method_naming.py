#!/usr/bin/env python3
"""Expanded LLM method naming pass for lower-context hash methods.

Artifacts:
  output/codex_batch_expanded_NNN.json
  output/codex_pred_expanded_NNN.json
  output/codex_batch_expanded_manifest.json
  output/codex_pred_expanded_merge_report.json

Usage:
  python tools/expanded_llm_method_naming.py build --target-classes 650 --target-methods 6500
  python tools/expanded_llm_method_naming.py run --concurrent 4
  python tools/expanded_llm_method_naming.py merge
  python tools/expanded_llm_method_naming.py stats
"""
from __future__ import annotations

import argparse
import concurrent.futures
import hashlib
import json
import os
import re
import sys
import time
import urllib.error
import urllib.request
from collections import Counter, defaultdict
from datetime import datetime
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
OUTPUT = BASE / "output"
DATA = BASE / "data"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
INITIAL_BATCH_RE = re.compile(r"^codex_batch_(\d{3})\.json$")
PASCAL_RE = re.compile(r"^[A-Z][A-Za-z0-9]{2,49}$")
ACCESSOR_RE = re.compile(r"^(get|set)_[A-Z][A-Za-z0-9]{2,49}$")

BATCH_GLOB = "codex_batch_expanded_*.json"
PRED_GLOB = "codex_pred_expanded_*.json"
MANIFEST_PATH = OUTPUT / "codex_batch_expanded_manifest.json"
MERGE_REPORT_PATH = OUTPUT / "codex_pred_expanded_merge_report.json"
EXPANDED_BATCH_RE = re.compile(r"^codex_batch_expanded_(\d{3})\.json$")
EXPANDED_PRED_RE = re.compile(r"^codex_pred_expanded_(\d{3})\.json$")

UNITY_BOILERPLATE = {
    ".ctor",
    ".cctor",
    "GetInstanceID",
    "Equals",
    "GetHashCode",
    "op_Implicit",
    "op_Equality",
    "op_Inequality",
    "CompareBaseObjects",
    "IsNativeObjectAlive",
    "GetCachedPtr",
    "get_name",
    "set_name",
    "Instantiate",
    "ToString",
    "Destroy",
    "DestroyImmediate",
    "FindObjectsOfType",
    "FindObjectsByType",
    "DontDestroyOnLoad",
    "get_hideFlags",
    "set_hideFlags",
    "FindObjectOfType",
    "FindFirstObjectByType",
    "CheckNullArgument",
    "GetOffsetOfInstanceIDInCPlusPlusObject",
    "Internal_CloneSingle",
    "Internal_CloneSingleWithParent",
    "Internal_InstantiateSingle",
    "Internal_InstantiateSingleWithParent",
    "GetName",
    "SetName",
    "get_destroyCancellationToken",
    "RaiseCancellation",
    "IsInvoking",
    "CancelInvoke",
    "Invoke",
    "InvokeRepeating",
    "StartCoroutine",
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
    "OnCancellationTokenCreated",
}

GENERIC_BAD_NAMES = {
    "Update",
    "Start",
    "Awake",
    "OnEnable",
    "OnDisable",
    "OnDestroy",
    "LateUpdate",
    "FixedUpdate",
    "Initialize",
    "Init",
    "Setup",
    "Process",
    "Execute",
    "Run",
    "Handle",
    "DoWork",
    "Method",
    "Func",
    "Unknown",
    "GetValue",
    "SetValue",
    "GetData",
    "SetData",
    "ProcessData",
    "UpdateState",
    "HandleEvent",
    "InitializeState",
}

CLASS_PATTERN_PREFIXES = {
    "Static",
    "Unknown",
    "EmptyType",
    "EmptyStruct",
    "BaseClass",
    "DataOnly",
    "Delegate",
    "Enumerator",
    "AsyncStateMachine",
    "LifecycleComponent",
    "UpdateComponent",
    "ComplexComponent",
    "FBase",
}

SEMANTIC_HINTS = {
    "VRC",
    "VRChat",
    "Player",
    "Avatar",
    "Network",
    "Photon",
    "Udon",
    "UI",
    "Input",
    "Camera",
    "Transform",
    "Animation",
    "Audio",
    "Video",
    "World",
    "Room",
    "Portal",
    "Friends",
    "Invite",
    "Moderation",
    "Notification",
    "Menu",
    "Page",
    "Text",
    "Image",
    "Button",
    "Toggle",
    "Slider",
    "Dropdown",
    "Json",
    "Http",
    "Web",
    "Request",
    "Response",
    "Steam",
    "Oculus",
    "Discord",
    "Analytics",
    "Cache",
    "Asset",
    "Bundle",
    "Pipeline",
    "Quest",
    "Desktop",
    "IK",
    "Tracking",
    "Locomotion",
}

CONTEXT_STOPWORDS = {
    "Get",
    "Set",
    "Add",
    "Remove",
    "On",
    "Is",
    "Has",
    "Can",
    "Try",
    "Read",
    "Write",
    "Update",
    "Initialize",
    "Process",
    "Handle",
    "Create",
    "Build",
    "Resolve",
    "Apply",
    "Refresh",
    "Validate",
    "Load",
    "Save",
    "Clear",
    "Reset",
    "Open",
    "Close",
    "Start",
    "Stop",
    "Begin",
    "End",
    "Internal",
    "Managed",
    "Object",
    "Component",
    "Handler",
    "Manager",
    "Service",
    "Base",
    "Impl",
    "Sibling",
    "Related",
    "Class",
    "Static",
    "Type",
    "Value",
    "Data",
    "State",
}

SYSTEM_PROMPT = """You are a VRChat IL2CPP reverse engineer. Predict semantic C# method names for hash methods.

Rules:
- Return ONLY a JSON object: {"ClassName::m_ABC":"PredictedName", ...}
- Use PascalCase method names or get_/set_ accessors only.
- Infer from class name, parent, known sibling methods, and fields.
- Return names only when supported by context; prefer fewer high-confidence names over filling every hash.
- Do not use generic lifecycle or placeholder names such as Awake, Start, Update, Initialize, Process, Handle, Unknown.
- Do not include explanations or markdown."""


def load_json(path: Path) -> object:
    return json.loads(path.read_text(encoding="utf-8"))


def write_json(path: Path, data: object) -> None:
    path.write_text(json.dumps(data, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


def sh(text: str, length: int = 3) -> str:
    return hashlib.sha256(text.encode("utf-8")).hexdigest()[:length].upper()


def split_tokens(text: str) -> list[str]:
    if not isinstance(text, str):
        return []
    text = re.sub(r"`\d+", "", text)
    text = re.sub(r"([a-z0-9])([A-Z])", r"\1 \2", text)
    text = re.sub(r"([A-Z]+)([A-Z][a-z])", r"\1 \2", text)
    text = re.sub(r"[^A-Za-z0-9]+", " ", text)
    return [part for part in text.split() if part]


def normalized_tokens(text: str) -> set[str]:
    tokens = set()
    for token in split_tokens(text):
        if len(token) < 3:
            continue
        if re.fullmatch(r"[0-9A-Fa-f]{3,}", token):
            continue
        titled = token[:1].upper() + token[1:]
        if titled not in CONTEXT_STOPWORDS:
            tokens.add(titled)
    return tokens


def clean_method_name(name: str) -> str:
    name = str(name).strip()
    return re.sub(r"_(?:[0-9A-F]{3,12}|\d+)$", "", name)


def useful_known_methods(methods: list[str]) -> list[str]:
    seen = set()
    useful = []
    for method in methods:
        if not isinstance(method, str):
            continue
        cleaned = clean_method_name(method)
        if not cleaned or cleaned in UNITY_BOILERPLATE or cleaned in GENERIC_BAD_NAMES:
            continue
        if HASH_RE.match(cleaned):
            continue
        if cleaned in seen:
            continue
        seen.add(cleaned)
        useful.append(cleaned)
    return useful


def expanded_batch_files() -> list[Path]:
    return [path for path in sorted(OUTPUT.glob(BATCH_GLOB)) if EXPANDED_BATCH_RE.match(path.name)]


def expanded_prediction_files() -> list[Path]:
    return [path for path in sorted(OUTPUT.glob(PRED_GLOB)) if EXPANDED_PRED_RE.match(path.name)]


def useful_field_text(field: str) -> str:
    field = str(field).strip()
    if not field:
        return ""
    if re.fullmatch(r"[0-9A-Fa-f]{2,}", field):
        return ""
    if re.fullmatch(r"f_[0-9A-Fa-f]{2,}", field):
        return ""
    if len(field) <= 2:
        return ""
    if "\\n" in field:
        return ""
    if not re.search(r"[A-Za-z]", field):
        return ""
    return field


def is_semantic_class_name(name: str) -> bool:
    if not name or "<>" in name or "AsyncStateMachine_" in name:
        return False
    base = re.sub(r"_[0-9A-F]{3,4}$", "", name)
    if len(base) < 4:
        return False
    for prefix in CLASS_PATTERN_PREFIXES:
        if base.startswith(prefix):
            return False
    tokens = set(split_tokens(base))
    if tokens & SEMANTIC_HINTS:
        return True
    if re.search(r"(Manager|Controller|Provider|Service|Serializer|Converter|Adapter|Resolver|Factory|Cache|Pool|View|Page|Model|Config|Settings|Module)$", base):
        return True
    return False


def covered_initial_classes() -> set[str]:
    covered = set()
    for path in sorted(OUTPUT.glob("codex_batch_*.json")):
        match = INITIAL_BATCH_RE.match(path.name)
        if not match:
            continue
        data = load_json(path)
        if isinstance(data, list):
            for item in data:
                if isinstance(item, dict) and isinstance(item.get("class"), str):
                    covered.add(item["class"])
    return covered


def build_field_index() -> dict[str, list[str]]:
    field_index: dict[str, list[str]] = defaultdict(list)
    deobf_path = OUTPUT / "deobfuscated_dump.json"
    if not deobf_path.exists():
        return {}
    data = load_json(deobf_path)
    for classes in data.get("namespaces", {}).values():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            class_name = cls.get("name", "")
            if not class_name:
                continue
            fields = []
            for field in cls.get("fields", []):
                if isinstance(field, dict):
                    name = field.get("name", "")
                    typ = field.get("type", "")
                    if name:
                        rendered = useful_field_text(f"{typ} {name}".strip())
                        if rendered:
                            fields.append(rendered)
                elif isinstance(field, str):
                    rendered = useful_field_text(field)
                    if rendered:
                        fields.append(rendered)
            if fields and not field_index[class_name]:
                field_index[class_name] = fields[:20]
    return dict(field_index)


def build_batches(args: argparse.Namespace) -> None:
    name_mapping = load_json(OUTPUT / "name_mapping.json")
    precise_dump = load_json(DATA / "precise_dump.json")
    cross_version = load_json(OUTPUT / "cross_version_method_names.json")
    field_index = build_field_index()
    methods_map = name_mapping["methods"]
    classes_map = name_mapping["classes"]
    covered = covered_initial_classes()

    targets = []
    total_candidate_classes = 0
    for namespace, classes in precise_dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            cls_obf = cls.get("name", "")
            cls_sem = classes_map.get(cls_obf, cls_obf)
            if not isinstance(cls_sem, str) or not cls_sem:
                continue
            if cls_sem in covered:
                continue
            if "<>" in cls_sem or "AsyncStateMachine_" in cls_sem:
                continue

            methods = cls.get("methods", [])
            if not isinstance(methods, list) or not methods:
                continue

            known = []
            hash_keys = []
            seen_hash_keys = set()
            for method in methods:
                if not isinstance(method, str):
                    continue
                key = f"{cls_obf}::{method}"
                current = methods_map.get(key, "")
                cv_key = f"{cls_sem}::m_{sh(method, 3)}"
                if isinstance(current, str) and HASH_RE.match(current) and cv_key not in cross_version and cv_key not in seen_hash_keys:
                    hash_keys.append(cv_key)
                    seen_hash_keys.add(cv_key)
                elif isinstance(current, str) and current and not HASH_RE.match(current):
                    known.append(current)

            useful_known = useful_known_methods(known)
            semantic_class = is_semantic_class_name(cls_sem)
            fields = field_index.get(cls_sem, [])

            if not hash_keys:
                continue
            if len(useful_known) < args.min_known and not semantic_class:
                continue
            if len(hash_keys) < args.min_hash:
                continue

            total_candidate_classes += 1
            class_tokens = normalized_tokens(cls_sem)
            known_tokens = set()
            for method in useful_known[:20]:
                known_tokens |= normalized_tokens(method)
            field_tokens = set()
            for field in fields[:12]:
                field_tokens |= normalized_tokens(field)

            signal_score = (
                len(useful_known) * 10
                + len(hash_keys) * 2
                + (6 if semantic_class else 0)
                + len(field_tokens) * 2
                + len(class_tokens)
            )

            max_methods = args.max_hash_methods_per_class
            targets.append(
                {
                    "class": cls_sem,
                    "parent": classes_map.get(cls.get("parent", ""), cls.get("parent", "")),
                    "namespace": namespace,
                    "readable_methods": useful_known[: args.max_known_methods_per_class],
                    "fields": fields[: args.max_fields_per_class],
                    "hash_methods": [key.rsplit("::", 1)[1] for key in hash_keys[:max_methods]],
                    "hash_keys": hash_keys[:max_methods],
                    "remaining_hash_methods": len(hash_keys),
                    "semantic_class_name": semantic_class,
                    "signal_score": signal_score,
                }
            )

    targets.sort(
        key=lambda item: (
            -int(bool(item["readable_methods"])),
            -item["signal_score"],
            -len(item["readable_methods"]),
            -int(item["semantic_class_name"]),
            -len(item["hash_methods"]),
            item["class"],
        )
    )

    selected = []
    selected_methods = 0
    for item in targets:
        if len(selected) >= args.target_classes and selected_methods >= args.target_methods:
            break
        selected.append(item)
        selected_methods += len(item["hash_methods"])

    for old in expanded_batch_files():
        old.unlink()
    if args.clear_predictions:
        for old in expanded_prediction_files():
            old.unlink()

    manifest_batches = []
    for batch_id, start in enumerate(range(0, len(selected), args.batch_size)):
        chunk = selected[start : start + args.batch_size]
        path = OUTPUT / f"codex_batch_expanded_{batch_id:03d}.json"
        write_json(
            path,
            [
                {
                    "class": item["class"],
                    "parent": item["parent"],
                    "namespace": item["namespace"],
                    "readable_methods": item["readable_methods"],
                    "fields": item["fields"],
                    "hash_methods": item["hash_methods"],
                }
                for item in chunk
            ],
        )
        manifest_batches.append(
            {
                "batch_id": batch_id,
                "file": path.name,
                "class_count": len(chunk),
                "hash_methods": sum(len(item["hash_methods"]) for item in chunk),
            }
        )

    manifest = {
        "generated_at": datetime.now().isoformat(timespec="seconds"),
        "covered_initial_classes": len(covered),
        "candidate_classes": total_candidate_classes,
        "selected_classes": len(selected),
        "selected_hash_methods": selected_methods,
        "batch_size": args.batch_size,
        "min_known": args.min_known,
        "min_hash": args.min_hash,
        "target_classes": args.target_classes,
        "target_methods": args.target_methods,
        "batches": manifest_batches,
    }
    write_json(MANIFEST_PATH, manifest)

    print(f"covered initial classes : {len(covered)}")
    print(f"candidate classes       : {total_candidate_classes}")
    print(f"selected classes        : {len(selected)}")
    print(f"selected hash methods   : {selected_methods}")
    print(f"batches                 : {len(manifest_batches)}")
    print(f"manifest                : {MANIFEST_PATH}")


def build_prompt(batch: list[dict]) -> str:
    lines = []
    for ctx in batch:
        lines.append(f"\nClass: {ctx['class']} (namespace: {ctx.get('namespace', '')}, parent: {ctx.get('parent', '')})")
        if ctx.get("readable_methods"):
            lines.append(f"  Known sibling methods: {', '.join(ctx['readable_methods'][:16])}")
        if ctx.get("fields"):
            lines.append(f"  Fields: {', '.join(ctx['fields'][:12])}")
        lines.append(f"  Name only methods you can infer: {', '.join(ctx.get('hash_methods', []))}")
    return "\n".join(lines)


def call_api(prompt: str, args: argparse.Namespace) -> str:
    api_key = os.environ.get("OPENAI_API_KEY", "")
    if not api_key:
        raise RuntimeError("OPENAI_API_KEY is not set")
    api_base = os.environ.get("API_BASE", args.api_base).rstrip("/")
    model = os.environ.get("LLM_MODEL", args.model)
    headers = {
        "Content-Type": "application/json",
        "Authorization": f"Bearer {api_key}",
    }
    body = json.dumps(
        {
            "model": model,
            "messages": [
                {"role": "system", "content": SYSTEM_PROMPT},
                {"role": "user", "content": prompt},
            ],
            "temperature": args.temperature,
            "max_tokens": args.max_tokens,
        }
    ).encode("utf-8")
    req = urllib.request.Request(f"{api_base}/v1/chat/completions", data=body, headers=headers, method="POST")
    for attempt in range(args.retries + 1):
        try:
            with urllib.request.urlopen(req, timeout=args.timeout) as response:
                data = json.loads(response.read().decode("utf-8"))
                return data["choices"][0]["message"]["content"]
        except urllib.error.HTTPError as exc:
            err_body = exc.read().decode("utf-8", errors="replace")[:500]
            if exc.code in (408, 409, 429, 500, 502, 503, 504) and attempt < args.retries:
                time.sleep(args.retry_delay * (attempt + 1))
                continue
            return f"ERROR:{exc.code}:{err_body}"
        except Exception as exc:
            if attempt < args.retries:
                time.sleep(args.retry_delay * (attempt + 1))
                continue
            return f"ERROR:{exc}"
    return "ERROR:max_retries"


def extract_json_object(text: str) -> dict:
    text = text.strip()
    if text.startswith("{"):
        try:
            data = json.loads(text)
            return data if isinstance(data, dict) else {}
        except json.JSONDecodeError:
            pass
    start = text.find("{")
    end = text.rfind("}")
    if start >= 0 and end > start:
        try:
            data = json.loads(text[start : end + 1])
            return data if isinstance(data, dict) else {}
        except json.JSONDecodeError:
            return {}
    return {}


def run_one_batch(batch_path: Path, args: argparse.Namespace) -> tuple[str, int, str]:
    batch_id = batch_path.stem.rsplit("_", 1)[1]
    pred_path = OUTPUT / f"codex_pred_expanded_{batch_id}.json"
    raw_path = OUTPUT / f"codex_pred_expanded_{batch_id}.raw.txt"
    if pred_path.exists() and not args.force:
        existing = load_json(pred_path)
        if isinstance(existing, dict) and existing:
            return batch_id, len(existing), "cached"

    batch = load_json(batch_path)
    prompt = build_prompt(batch)
    response = call_api(prompt, args)
    if response.startswith("ERROR:"):
        raw_path.write_text(response, encoding="utf-8")
        return batch_id, 0, response[:120]

    predictions = extract_json_object(response)
    if not predictions:
        raw_path.write_text(response, encoding="utf-8")
        write_json(pred_path, {})
        return batch_id, 0, "parse_error"

    write_json(pred_path, predictions)
    raw_path.unlink(missing_ok=True)
    return batch_id, len(predictions), "ok"


def run_batches(args: argparse.Namespace) -> None:
    batch_files = expanded_batch_files()
    if args.start is not None:
        batch_files = [p for p in batch_files if int(p.stem.rsplit("_", 1)[1]) >= args.start]
    if args.end is not None:
        batch_files = [p for p in batch_files if int(p.stem.rsplit("_", 1)[1]) <= args.end]
    if not batch_files:
        print("No expanded batch files found")
        return

    print(f"running expanded batches: {len(batch_files)}")
    print(f"model: {os.environ.get('LLM_MODEL', args.model)}")
    print(f"api base: {os.environ.get('API_BASE', args.api_base)}")
    print(f"concurrent workers: {args.concurrent}")

    total = 0
    ok = cached = errors = 0
    t0 = time.time()
    with concurrent.futures.ThreadPoolExecutor(max_workers=args.concurrent) as pool:
        futures = {pool.submit(run_one_batch, path, args): path for path in batch_files}
        for index, future in enumerate(concurrent.futures.as_completed(futures), 1):
            batch_id, count, status = future.result()
            total += count
            if status == "ok":
                ok += 1
            elif status == "cached":
                cached += 1
            else:
                errors += 1
            elapsed = time.time() - t0
            print(f"[{index}/{len(batch_files)}] expanded_{batch_id}: {status} ({count}) elapsed={elapsed:.1f}s")

    print(f"predictions: {total}")
    print(f"ok={ok} cached={cached} errors={errors}")


def target_context_index() -> dict[str, dict]:
    index = {}
    for path in expanded_batch_files():
        data = load_json(path)
        if not isinstance(data, list):
            continue
        for item in data:
            if not isinstance(item, dict):
                continue
            cls = item.get("class", "")
            context_tokens = normalized_tokens(cls) | normalized_tokens(item.get("parent", ""))
            for method in item.get("readable_methods", []):
                context_tokens |= normalized_tokens(method)
            for field in item.get("fields", []):
                context_tokens |= normalized_tokens(field)
            for method in item.get("hash_methods", []):
                if HASH_RE.match(method):
                    index[f"{cls}::{method}"] = {
                        "class": cls,
                        "tokens": context_tokens,
                        "semantic_class": is_semantic_class_name(cls),
                    }
    return index


def valid_prediction_name(key: str, name: object, context_index: dict[str, dict], rejected: Counter) -> str:
    if key not in context_index:
        rejected["not_in_expanded_targets"] += 1
        return ""
    if not isinstance(name, str):
        rejected["non_string_name"] += 1
        return ""
    normalized = name.strip()
    if HASH_RE.match(normalized):
        rejected["still_hash"] += 1
        return ""
    if normalized in GENERIC_BAD_NAMES:
        rejected["generic_name"] += 1
        return ""
    if not (PASCAL_RE.match(normalized) or ACCESSOR_RE.match(normalized)):
        rejected["bad_format"] += 1
        return ""
    if re.search(r"(?:[0-9A-F]{6,}|_[0-9A-F]{3,}|_m_[0-9A-F]{3})$", normalized):
        rejected["hash_suffix"] += 1
        return ""
    if re.search(r"[a-z]\d+[A-Za-z]", normalized) and not re.search(r"(2D|3D|IPv[46]|To\d+|V\d+)", normalized):
        rejected["embedded_digits"] += 1
        return ""
    parts = normalized_tokens(normalized)
    ctx = context_index[key]
    overlap = parts & ctx["tokens"]
    if not overlap and not ctx["semantic_class"]:
        rejected["no_context_overlap"] += 1
        return ""
    if len(parts) == 0:
        rejected["no_meaningful_tokens"] += 1
        return ""
    return normalized


def merge_predictions(args: argparse.Namespace) -> None:
    cv_path = OUTPUT / "cross_version_method_names.json"
    cross_version = load_json(cv_path)
    before = len(cross_version)
    context_index = target_context_index()
    raw_predictions = {}
    rejected = Counter()

    for path in expanded_prediction_files():
        data = load_json(path)
        if not isinstance(data, dict):
            continue
        for key, name in data.items():
            raw_predictions[key] = name

    candidates = {}
    for key, name in raw_predictions.items():
        if key in cross_version:
            rejected["already_mapped"] += 1
            continue
        if not isinstance(key, str) or "::" not in key or not HASH_RE.match(key.rsplit("::", 1)[1]):
            rejected["bad_key"] += 1
            continue
        normalized = valid_prediction_name(key, name, context_index, rejected)
        if normalized:
            candidates[key] = normalized

    per_class_names: dict[str, Counter] = defaultdict(Counter)
    for key, name in candidates.items():
        per_class_names[key.split("::", 1)[0]][name] += 1
    duplicate_class_names = {
        (cls, name)
        for cls, names in per_class_names.items()
        for name, count in names.items()
        if count > args.max_same_name_per_class
    }
    if duplicate_class_names:
        before_dupes = len(candidates)
        candidates = {
            key: name
            for key, name in candidates.items()
            if (key.split("::", 1)[0], name) not in duplicate_class_names
        }
        rejected["per_class_duplicate"] += before_dupes - len(candidates)

    frequent_names = {name for name, count in Counter(candidates.values()).items() if count > args.max_global_same_name}
    if frequent_names:
        before_freq = len(candidates)
        candidates = {key: name for key, name in candidates.items() if name not in frequent_names}
        rejected["globally_frequent_name"] += before_freq - len(candidates)

    if args.dry_run:
        added = 0
    else:
        backup = OUTPUT / f"cross_version_method_names.pre_expanded_merge_{datetime.now().strftime('%Y%m%d_%H%M%S')}.json"
        write_json(backup, cross_version)
        cross_version.update(dict(sorted(candidates.items())))
        write_json(cv_path, cross_version)
        added = len(cross_version) - before

    report = {
        "generated_at": datetime.now().isoformat(timespec="seconds"),
        "dry_run": args.dry_run,
        "raw_predictions": len(raw_predictions),
        "filtered_candidates": len(candidates),
        "cross_version_before": before,
        "cross_version_after": before + added,
        "new_entries": added,
        "rejected": dict(rejected.most_common()),
        "sample": dict(list(sorted(candidates.items()))[:25]),
    }
    write_json(MERGE_REPORT_PATH, report)

    print(f"raw predictions       : {len(raw_predictions)}")
    print(f"filtered candidates   : {len(candidates)}")
    print(f"new cross-version rows: {added}")
    for reason, count in rejected.most_common():
        print(f"  rejected {reason}: {count}")
    print(f"report                : {MERGE_REPORT_PATH}")


def stats(_: argparse.Namespace) -> None:
    manifest = load_json(MANIFEST_PATH) if MANIFEST_PATH.exists() else {}
    predictions = {}
    for path in expanded_prediction_files():
        data = load_json(path)
        if isinstance(data, dict):
            predictions.update(data)
    cv = load_json(OUTPUT / "cross_version_method_names.json")
    target_count = 0
    for path in expanded_batch_files():
        data = load_json(path)
        if isinstance(data, list):
            target_count += sum(len(item.get("hash_methods", [])) for item in data if isinstance(item, dict))
    print(f"expanded batches       : {len(expanded_batch_files())}")
    print(f"expanded target classes: {manifest.get('selected_classes', 'unknown')}")
    print(f"expanded target methods: {target_count}")
    print(f"raw expanded preds     : {len(predictions)}")
    print(f"cross-version entries  : {len(cv)}")
    if MERGE_REPORT_PATH.exists():
        report = load_json(MERGE_REPORT_PATH)
        print(f"last merge kept        : {report.get('filtered_candidates')}")
        print(f"last merge added       : {report.get('new_entries')}")


def main() -> None:
    parser = argparse.ArgumentParser()
    sub = parser.add_subparsers(dest="command", required=True)

    build = sub.add_parser("build")
    build.add_argument("--target-classes", type=int, default=650)
    build.add_argument("--target-methods", type=int, default=6500)
    build.add_argument("--batch-size", type=int, default=10)
    build.add_argument("--min-known", type=int, default=1)
    build.add_argument("--min-hash", type=int, default=1)
    build.add_argument("--max-known-methods-per-class", type=int, default=18)
    build.add_argument("--max-hash-methods-per-class", type=int, default=12)
    build.add_argument("--max-fields-per-class", type=int, default=12)
    build.add_argument("--clear-predictions", action="store_true")
    build.set_defaults(func=build_batches)

    run = sub.add_parser("run")
    run.add_argument("--start", type=int)
    run.add_argument("--end", type=int)
    run.add_argument("--concurrent", type=int, default=4)
    run.add_argument("--force", action="store_true")
    run.add_argument("--api-base", default=os.environ.get("OPENAI_API_BASE", ""))
    run.add_argument("--model", default="gpt-5.5")
    run.add_argument("--temperature", type=float, default=0.15)
    run.add_argument("--max-tokens", type=int, default=8192)
    run.add_argument("--timeout", type=int, default=180)
    run.add_argument("--retries", type=int, default=3)
    run.add_argument("--retry-delay", type=float, default=8.0)
    run.set_defaults(func=run_batches)

    merge = sub.add_parser("merge")
    merge.add_argument("--dry-run", action="store_true")
    merge.add_argument("--max-same-name-per-class", type=int, default=2)
    merge.add_argument("--max-global-same-name", type=int, default=12)
    merge.set_defaults(func=merge_predictions)

    stats_cmd = sub.add_parser("stats")
    stats_cmd.set_defaults(func=stats)

    args = parser.parse_args()
    args.func(args)


if __name__ == "__main__":
    main()
