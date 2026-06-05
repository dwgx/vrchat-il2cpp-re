#!/usr/bin/env python3
"""Neighbor-context LLM naming pass for well-contextualized hash methods.

Artifacts:
  output/neighbor_context_batches/neighbor_batch_NNN.json
  output/neighbor_context_batches/neighbor_pred_NNN.json
  output/neighbor_context_manifest.json
  output/neighbor_context_merge_report.json

Usage:
  python tools/neighbor_context_method_naming.py build --target-classes 500 --batch-size 5
  python tools/neighbor_context_method_naming.py run --concurrent 4
  python tools/neighbor_context_method_naming.py merge
  python tools/neighbor_context_method_naming.py stats
"""
from __future__ import annotations

import argparse
import concurrent.futures
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
BATCH_DIR = OUTPUT / "neighbor_context_batches"
MANIFEST_PATH = OUTPUT / "neighbor_context_manifest.json"
MERGE_REPORT_PATH = OUTPUT / "neighbor_context_merge_report.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
PASCAL_RE = re.compile(r"^[A-Z][A-Za-z0-9]{3,59}$")
ACCESSOR_RE = re.compile(r"^(get|set)_[A-Z][A-Za-z0-9]{2,59}$")
BATCH_RE = re.compile(r"^neighbor_batch_(\d{3})\.json$")
PRED_RE = re.compile(r"^neighbor_pred_(\d{3})\.json$")

SYSTEM_PROMPT = """You are a VRChat IL2CPP reverse engineer. Predict semantic C# method names for hash methods.

Rules:
- Return ONLY a JSON object: {"ClassName::m_ABC":"PredictedName", ...}
- Use PascalCase method names or get_/set_ accessors only.
- Infer from class name, parent, namespace, known sibling methods, and fields.
- Only predict when the neighbor context strongly supports the name. Skip uncertain methods.
- Do not use generic lifecycle or placeholder names such as Awake, Start, Update, Initialize, Process, Handle, Unknown.
- Do not append hashes, confidence labels, explanations, or markdown."""

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
    "Internal_CloneSingle",
    "Internal_CloneSingleWithParent",
    "Internal_InstantiateSingle",
    "Internal_InstantiateSingleWithParent",
    "IsInvoking",
    "CancelInvoke",
    "Invoke",
    "InvokeRepeating",
    "StartCoroutine",
    "StopCoroutine",
    "StopAllCoroutines",
    "Internal_CancelInvokeAll",
    "Internal_IsInvokingAll",
    "StartCoroutineManaged",
    "StartCoroutineManaged2",
    "StopCoroutineManaged",
}

GENERIC_BAD_NAMES = {
    "Awake",
    "Start",
    "Update",
    "LateUpdate",
    "FixedUpdate",
    "OnEnable",
    "OnDisable",
    "OnDestroy",
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
    "Action",
    "Unknown",
    "GetValue",
    "SetValue",
    "GetData",
    "SetData",
    "ProcessData",
    "UpdateState",
    "HandleEvent",
    "InitializeState",
    "GetResult",
    "SetResult",
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
    "Class",
    "Static",
    "Type",
    "Value",
    "Data",
    "State",
}


def load_json(path: Path) -> object:
    return json.loads(path.read_text(encoding="utf-8"))


def write_json(path: Path, data: object) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(data, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


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


def cleaned_named_methods(methods: list[str]) -> list[str]:
    seen = set()
    named = []
    for method in methods:
        if not isinstance(method, str) or HASH_RE.match(method):
            continue
        cleaned = clean_method_name(method)
        if not cleaned or HASH_RE.match(cleaned) or cleaned in seen:
            continue
        seen.add(cleaned)
        named.append(cleaned)
    return named


def useful_field_text(field: object) -> str:
    if isinstance(field, dict):
        name = str(field.get("name", "")).strip()
        typ = str(field.get("type", "")).strip()
        field = f"{typ} {name}".strip() if name else ""
    field = str(field).strip()
    if not field or len(field) <= 2:
        return ""
    if re.fullmatch(r"(?:f_)?[0-9A-Fa-f]{2,}", field):
        return ""
    if "\\n" in field or not re.search(r"[A-Za-z]", field):
        return ""
    return field


def is_semantic_class_name(name: str) -> bool:
    if not name or "<>" in name or "AsyncStateMachine_" in name:
        return False
    base = re.sub(r"_[0-9A-F]{3,4}$", "", name)
    if len(base) < 4 or re.fullmatch(r"[A-Z](?:_\d+)?", base):
        return False
    for prefix in CLASS_PATTERN_PREFIXES:
        if base.startswith(prefix):
            return False
    tokens = set(split_tokens(base))
    if tokens & SEMANTIC_HINTS:
        return True
    return bool(
        re.search(
            r"(Manager|Controller|Provider|Service|Serializer|Converter|Adapter|Resolver|Factory|Cache|Pool|View|Page|Model|Config|Settings|Module|Collection|Dictionary|List|Reader|Writer|Handler|Request|Response|Context|Options|Attribute|Exception|Stream|Client|Server|Store|Builder|Parser|Formatter|Command|Operation|Behaviour|Behavior)$",
            base,
        )
    )


def batch_files() -> list[Path]:
    if not BATCH_DIR.exists():
        return []
    return [path for path in sorted(BATCH_DIR.glob("neighbor_batch_*.json")) if BATCH_RE.match(path.name)]


def prediction_files() -> list[Path]:
    if not BATCH_DIR.exists():
        return []
    return [path for path in sorted(BATCH_DIR.glob("neighbor_pred_*.json")) if PRED_RE.match(path.name)]


def build_batches(args: argparse.Namespace) -> None:
    deobf_path = OUTPUT / "deobfuscated_dump.json"
    dump = load_json(deobf_path)

    targets = []
    total_candidates = 0
    for namespace, classes in dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            class_name = cls.get("name", "")
            if not is_semantic_class_name(class_name):
                continue

            methods = [m for m in cls.get("methods", []) if isinstance(m, str)]
            if len(methods) < args.min_methods:
                continue
            all_named = cleaned_named_methods(methods)
            named = useful_known_methods(all_named)
            hash_methods = []
            seen_hashes = set()
            for method in methods:
                if not HASH_RE.match(method):
                    continue
                if method in seen_hashes:
                    continue
                seen_hashes.add(method)
                hash_methods.append(method)

            if len(all_named) < args.min_named or len(hash_methods) < args.min_hash:
                continue
            if len(named) < args.min_named:
                seen_named = set(named)
                for method in all_named:
                    if method not in seen_named:
                        named.append(method)
                        seen_named.add(method)
                    if len(named) >= args.min_named:
                        break

            fields = []
            for field in cls.get("fields", []):
                rendered = useful_field_text(field)
                if rendered:
                    fields.append(rendered)

            total_candidates += 1
            class_tokens = normalized_tokens(class_name)
            known_tokens = set()
            for method in named:
                known_tokens |= normalized_tokens(method)
            field_tokens = set()
            for field in fields:
                field_tokens |= normalized_tokens(field)
            signal_score = len(named) * 10 + len(hash_methods) * 2 + len(class_tokens) + len(field_tokens) * 2

            targets.append(
                {
                    "class": class_name,
                    "parent": cls.get("parent", ""),
                    "namespace": namespace,
                    "known_methods": named[: args.max_known_methods_per_class],
                    "fields": fields[: args.max_fields_per_class],
                    "hash_methods": hash_methods[: args.max_hash_methods_per_class],
                    "remaining_hash_methods": len(hash_methods),
                    "total_methods": len(methods),
                    "signal_score": signal_score,
                }
            )

    targets.sort(
        key=lambda item: (
            -item["signal_score"],
            -len(item["known_methods"]),
            -len(item["hash_methods"]),
            item["namespace"],
            item["class"],
        )
    )
    selected = targets[: args.target_classes]

    BATCH_DIR.mkdir(parents=True, exist_ok=True)
    for old in batch_files():
        old.unlink()
    if args.clear_predictions:
        for old in prediction_files():
            old.unlink()
        for old in BATCH_DIR.glob("neighbor_pred_*.raw.txt"):
            old.unlink()

    manifest_batches = []
    for batch_id, start in enumerate(range(0, len(selected), args.batch_size)):
        chunk = selected[start : start + args.batch_size]
        path = BATCH_DIR / f"neighbor_batch_{batch_id:03d}.json"
        write_json(path, chunk)
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
        "source": str(deobf_path.relative_to(BASE)),
        "candidate_classes": total_candidates,
        "selected_classes": len(selected),
        "selected_hash_methods": sum(len(item["hash_methods"]) for item in selected),
        "batch_size": args.batch_size,
        "min_methods": args.min_methods,
        "min_named": args.min_named,
        "min_hash": args.min_hash,
        "target_classes": args.target_classes,
        "batches": manifest_batches,
    }
    write_json(MANIFEST_PATH, manifest)

    print(f"candidate classes     : {total_candidates}")
    print(f"selected classes      : {len(selected)}")
    print(f"selected hash methods : {manifest['selected_hash_methods']}")
    print(f"batches               : {len(manifest_batches)}")
    print(f"manifest              : {MANIFEST_PATH}")


def build_prompt(batch: list[dict]) -> str:
    lines = []
    for ctx in batch:
        lines.append(f"\nClass: {ctx['class']} (parent: {ctx.get('parent', '')})")
        lines.append(f"Namespace: {ctx.get('namespace', '')}")
        lines.append(f"Known methods: {', '.join(ctx.get('known_methods', [])[:18])}")
        if ctx.get("fields"):
            lines.append(f"Fields: {', '.join(ctx.get('fields', [])[:12])}")
        else:
            lines.append("Fields: ")
        lines.append(f"Unknown methods to predict: {', '.join(ctx.get('hash_methods', []))}")
    lines.append('\nReturn JSON: {"ClassName::m_HASH":"predictedName", ...}. Only predict if confident.')
    return "\n".join(lines)


def call_api(prompt: str, args: argparse.Namespace) -> str:
    api_key = os.environ.get("OPENAI_API_KEY", "")
    if not api_key:
        raise RuntimeError("OPENAI_API_KEY is not set")
    api_base = os.environ.get("API_BASE", args.api_base).rstrip("/")
    model = os.environ.get("LLM_MODEL", args.model)
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
    headers = {"Content-Type": "application/json", "Authorization": f"Bearer {api_key}"}
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
    batch_id = BATCH_RE.match(batch_path.name).group(1)  # type: ignore[union-attr]
    pred_path = BATCH_DIR / f"neighbor_pred_{batch_id}.json"
    raw_path = BATCH_DIR / f"neighbor_pred_{batch_id}.raw.txt"
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
    files = batch_files()
    if args.start is not None:
        files = [p for p in files if int(BATCH_RE.match(p.name).group(1)) >= args.start]  # type: ignore[union-attr]
    if args.end is not None:
        files = [p for p in files if int(BATCH_RE.match(p.name).group(1)) <= args.end]  # type: ignore[union-attr]
    if not files:
        print("No neighbor-context batch files found")
        return

    print(f"running neighbor-context batches: {len(files)}")
    print(f"model: {os.environ.get('LLM_MODEL', args.model)}")
    print(f"api base: {os.environ.get('API_BASE', args.api_base)}")
    print(f"concurrent workers: {args.concurrent}")

    total = 0
    ok = cached = errors = 0
    t0 = time.time()
    with concurrent.futures.ThreadPoolExecutor(max_workers=args.concurrent) as pool:
        futures = {pool.submit(run_one_batch, path, args): path for path in files}
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
            print(f"[{index}/{len(files)}] neighbor_{batch_id}: {status} ({count}) elapsed={elapsed:.1f}s")

    print(f"predictions: {total}")
    print(f"ok={ok} cached={cached} errors={errors}")


def target_context_index() -> dict[str, dict]:
    index = {}
    for path in batch_files():
        data = load_json(path)
        if not isinstance(data, list):
            continue
        for item in data:
            if not isinstance(item, dict):
                continue
            cls = item.get("class", "")
            context_tokens = normalized_tokens(cls) | normalized_tokens(item.get("parent", ""))
            known_names = set(item.get("known_methods", []))
            for method in item.get("known_methods", []):
                context_tokens |= normalized_tokens(method)
            for field in item.get("fields", []):
                context_tokens |= normalized_tokens(field)
            for method in item.get("hash_methods", []):
                if HASH_RE.match(method):
                    index[f"{cls}::{method}"] = {
                        "class": cls,
                        "tokens": context_tokens,
                        "known_names": known_names,
                    }
    return index


def valid_prediction_name(key: str, name: object, context_index: dict[str, dict], rejected: Counter) -> str:
    if key not in context_index:
        rejected["not_in_neighbor_targets"] += 1
        return ""
    if not isinstance(name, str):
        rejected["non_string_name"] += 1
        return ""
    normalized = clean_method_name(name)
    if HASH_RE.match(normalized):
        rejected["still_hash"] += 1
        return ""
    if normalized in GENERIC_BAD_NAMES:
        rejected["generic_name"] += 1
        return ""
    if normalized in context_index[key]["known_names"]:
        rejected["duplicates_known_sibling"] += 1
        return ""
    if not (PASCAL_RE.match(normalized) or ACCESSOR_RE.match(normalized)):
        rejected["bad_format_or_too_short"] += 1
        return ""
    if re.search(r"(?:[0-9A-F]{6,}|_[0-9A-F]{3,}|_m_[0-9A-F]{3})$", normalized):
        rejected["hash_suffix"] += 1
        return ""
    if re.search(r"[a-z]\d+[A-Za-z]", normalized) and not re.search(r"(2D|3D|IPv[46]|To\d+|V\d+)", normalized):
        rejected["embedded_digits"] += 1
        return ""

    parts = normalized_tokens(normalized)
    if not parts:
        rejected["no_meaningful_tokens"] += 1
        return ""
    overlap = parts & context_index[key]["tokens"]
    if not overlap:
        rejected["no_context_overlap"] += 1
        return ""
    return normalized


def merge_predictions(args: argparse.Namespace) -> None:
    cv_path = OUTPUT / "cross_version_method_names.json"
    cross_version = load_json(cv_path) if cv_path.exists() else {}
    before = len(cross_version)
    context_index = target_context_index()
    raw_prediction_values: dict[str, list[object]] = defaultdict(list)
    rejected = Counter()

    for path in prediction_files():
        data = load_json(path)
        if not isinstance(data, dict):
            continue
        for key, name in data.items():
            raw_prediction_values[key].append(name)

    raw_predictions = {}
    for key, values in raw_prediction_values.items():
        normalized_values = {clean_method_name(value) if isinstance(value, str) else value for value in values}
        if len(normalized_values) > 1:
            rejected["conflicting_duplicate_prediction"] += 1
            continue
        raw_predictions[key] = values[-1]

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
        backup = OUTPUT / f"cross_version_method_names.pre_neighbor_context_merge_{datetime.now().strftime('%Y%m%d_%H%M%S')}.json"
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
    for path in prediction_files():
        data = load_json(path)
        if isinstance(data, dict):
            predictions.update(data)
    cv = load_json(OUTPUT / "cross_version_method_names.json") if (OUTPUT / "cross_version_method_names.json").exists() else {}
    target_count = 0
    for path in batch_files():
        data = load_json(path)
        if isinstance(data, list):
            target_count += sum(len(item.get("hash_methods", [])) for item in data if isinstance(item, dict))
    print(f"neighbor batches        : {len(batch_files())}")
    print(f"target classes          : {manifest.get('selected_classes', 'unknown')}")
    print(f"target methods          : {target_count}")
    print(f"raw neighbor preds      : {len(predictions)}")
    print(f"cross-version entries   : {len(cv)}")
    if MERGE_REPORT_PATH.exists():
        report = load_json(MERGE_REPORT_PATH)
        print(f"last merge kept         : {report.get('filtered_candidates')}")
        print(f"last merge added        : {report.get('new_entries')}")


def main() -> None:
    parser = argparse.ArgumentParser()
    sub = parser.add_subparsers(dest="command", required=True)

    build = sub.add_parser("build")
    build.add_argument("--target-classes", type=int, default=500)
    build.add_argument("--batch-size", type=int, default=5)
    build.add_argument("--min-methods", type=int, default=5)
    build.add_argument("--min-named", type=int, default=3)
    build.add_argument("--min-hash", type=int, default=1)
    build.add_argument("--max-known-methods-per-class", type=int, default=22)
    build.add_argument("--max-hash-methods-per-class", type=int, default=12)
    build.add_argument("--max-fields-per-class", type=int, default=14)
    build.add_argument("--clear-predictions", action="store_true")
    build.set_defaults(func=build_batches)

    run = sub.add_parser("run")
    run.add_argument("--start", type=int)
    run.add_argument("--end", type=int)
    run.add_argument("--concurrent", type=int, default=4)
    run.add_argument("--force", action="store_true")
    run.add_argument("--api-base", default=os.environ.get("OPENAI_API_BASE", ""))
    run.add_argument("--model", default="gpt-5.5")
    run.add_argument("--temperature", type=float, default=0.1)
    run.add_argument("--max-tokens", type=int, default=8192)
    run.add_argument("--timeout", type=int, default=180)
    run.add_argument("--retries", type=int, default=3)
    run.add_argument("--retry-delay", type=float, default=8.0)
    run.set_defaults(func=run_batches)

    merge = sub.add_parser("merge")
    merge.add_argument("--dry-run", action="store_true")
    merge.add_argument("--max-same-name-per-class", type=int, default=1)
    merge.add_argument("--max-global-same-name", type=int, default=10)
    merge.set_defaults(func=merge_predictions)

    stats_cmd = sub.add_parser("stats")
    stats_cmd.set_defaults(func=stats)

    args = parser.parse_args()
    args.func(args)


if __name__ == "__main__":
    main()
