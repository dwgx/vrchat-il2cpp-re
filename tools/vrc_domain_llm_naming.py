#!/usr/bin/env python3
"""VRChat-domain-specific LLM naming pass for high-value hash methods.

Artifacts:
  output/vrc_domain_llm/batch_NNN.json
  output/vrc_domain_llm/pred_NNN.json
  output/vrc_domain_llm/manifest.json
  output/vrc_domain_llm/merge_report.json

Usage:
  python tools/vrc_domain_llm_naming.py build --keyword-limit 80
  python tools/vrc_domain_llm_naming.py run --concurrent 3
  python tools/vrc_domain_llm_naming.py merge
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
from typing import Any


sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
OUTPUT = BASE / "output"
OUT = OUTPUT / "vrc_domain_llm"
DEOBF_DUMP = OUTPUT / "deobfuscated_dump.json"
LLM_NAMES = OUTPUT / "llm_predicted_names.json"

HASH_RE = re.compile(r"^m_[0-9A-Fa-f]{3,}$")
PASCAL_RE = re.compile(r"^[A-Z][A-Za-z0-9]{2,59}$")
ACCESSOR_RE = re.compile(r"^(get|set)_[A-Za-z][A-Za-z0-9]{2,59}$")
KEYWORD_RE = re.compile(r"Avatar|World|Room|Player|Network|Photon|Udon", re.I)
PRIORITY_RE = re.compile(
    r"^(?:VRCPlayer|NetworkManager|VRCFlowManager|PlayerNet)(?:$|_)"
    r"|^(?:VRCPlayer|NetworkManager|VRCFlowManager|PlayerNet)Sibling",
    re.I,
)

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
}

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
    "StartCoroutineManaged",
    "StartCoroutineManaged2",
    "StopCoroutineManaged",
}

SYSTEM_PROMPT = """You are a VRChat IL2CPP reverse engineer doing method-name recovery.

VRChat is a social VR platform. Classes handle avatars, worlds, rooms/instances, players, networking with Photon, UI, player movement, IK/tracking, anti-cheat/EAC, Udon scripting, voice chat, moderation, economy, and content loading.

Predict semantic C# method names for hash methods (m_XXX) based on class context and VRChat domain knowledge.

Rules:
- Return ONLY a JSON object: {"ClassName::m_ABC":"PredictedName", ...}
- Use PascalCase names or get_/set_ property accessors.
- Prefer VRChat-domain names over generic verbs when the context supports it.
- Infer from namespace, class name, parent, ALL known sibling methods, fields, and the set of hash methods.
- Do not fill every method. Return only names that are reasonably supported.
- Avoid generic placeholders/lifecycle names: Awake, Start, Update, Initialize, Process, Handle, Execute, Unknown.
- Do not include explanations or markdown fences."""


def load_json(path: Path) -> Any:
    return json.loads(path.read_text(encoding="utf-8"))


def write_json(path: Path, data: Any) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(data, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


def clean_method_name(name: str) -> str:
    return re.sub(r"_(?:[0-9A-F]{6,12}|\d+)$", "", str(name).strip())


def useful_known_methods(methods: list[Any]) -> list[str]:
    seen: set[str] = set()
    useful: list[str] = []
    for method in methods:
        if not isinstance(method, str):
            continue
        cleaned = clean_method_name(method)
        if not cleaned or HASH_RE.match(cleaned):
            continue
        if cleaned in UNITY_BOILERPLATE:
            continue
        if cleaned in seen:
            continue
        seen.add(cleaned)
        useful.append(cleaned)
    return useful


def render_field(field: Any) -> str:
    if isinstance(field, dict):
        name = str(field.get("name", "")).strip()
        typ = str(field.get("type", "")).strip()
        text = f"{typ} {name}".strip()
    else:
        text = str(field).strip()
    if not text or re.fullmatch(r"f_[0-9A-Fa-f]{2,}", text):
        return ""
    return text


def class_score(item: dict[str, Any]) -> int:
    name = item["class"]
    namespace = item["namespace"]
    hash_count = len(item["hash_methods"])
    known_count = len(item["known_methods"])
    score = hash_count * 4 + known_count * 2
    if namespace.startswith("VRC"):
        score += 5_000
    if PRIORITY_RE.search(name):
        score += 20_000
    if KEYWORD_RE.search(name):
        score += 2_000
    return score


def build_targets(args: argparse.Namespace) -> list[dict[str, Any]]:
    dump = load_json(DEOBF_DUMP)
    targets: list[dict[str, Any]] = []
    vrc_count = vrc_hash = 0
    priority_count = priority_hash = 0
    keyword_candidates: list[dict[str, Any]] = []

    for namespace, classes in dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            methods = cls.get("methods", [])
            if not isinstance(methods, list):
                continue
            hash_methods = []
            seen_hashes: set[str] = set()
            for method in methods:
                if isinstance(method, str) and HASH_RE.match(method) and method not in seen_hashes:
                    hash_methods.append(method)
                    seen_hashes.add(method)
            if not hash_methods:
                continue

            class_name = str(cls.get("name", ""))
            known_methods = useful_known_methods(methods)
            fields = [text for text in (render_field(f) for f in cls.get("fields", [])) if text]
            item = {
                "namespace": namespace,
                "class": class_name,
                "parent": cls.get("parent", ""),
                "known_methods": known_methods,
                "fields": fields,
                "hash_methods": hash_methods,
                "all_method_count": len(methods),
            }

            is_vrc_namespace = namespace.startswith("VRC")
            is_priority = bool(PRIORITY_RE.search(class_name))
            is_keyword = bool(KEYWORD_RE.search(class_name))

            if is_vrc_namespace:
                vrc_count += 1
                vrc_hash += len(hash_methods)
                targets.append(item)
            elif args.include_global_priority and is_priority:
                priority_count += 1
                priority_hash += len(hash_methods)
                targets.append(item)
            elif args.keyword_limit and is_keyword:
                keyword_candidates.append(item)

    existing_keys = {(item["namespace"], item["class"]) for item in targets}
    keyword_candidates.sort(key=class_score, reverse=True)
    keyword_added = 0
    keyword_hash = 0
    for item in keyword_candidates:
        key = (item["namespace"], item["class"])
        if key in existing_keys:
            continue
        if keyword_added >= args.keyword_limit:
            break
        targets.append(item)
        existing_keys.add(key)
        keyword_added += 1
        keyword_hash += len(item["hash_methods"])

    targets.sort(key=class_score, reverse=True)
    if args.max_classes:
        targets = targets[: args.max_classes]

    print(f"VRC.* classes with hash methods     : {vrc_count}")
    print(f"VRC.* hash methods                  : {vrc_hash}")
    print(f"global priority classes included    : {priority_count}")
    print(f"global priority hash methods        : {priority_hash}")
    print(f"keyword classes included            : {keyword_added}")
    print(f"keyword hash methods included       : {keyword_hash}")
    print(f"selected classes                    : {len(targets)}")
    print(f"selected hash methods               : {sum(len(t['hash_methods']) for t in targets)}")
    return targets


def split_large_targets(targets: list[dict[str, Any]], max_hashes: int) -> list[dict[str, Any]]:
    if max_hashes <= 0:
        return targets
    split_targets: list[dict[str, Any]] = []
    for item in targets:
        hashes = item["hash_methods"]
        if len(hashes) <= max_hashes:
            split_targets.append(item)
            continue
        for start in range(0, len(hashes), max_hashes):
            chunk = dict(item)
            chunk["hash_methods"] = hashes[start : start + max_hashes]
            chunk["chunk_index"] = start // max_hashes
            chunk["chunk_count"] = (len(hashes) + max_hashes - 1) // max_hashes
            split_targets.append(chunk)
    return split_targets


def build_batches(args: argparse.Namespace) -> None:
    original_targets = build_targets(args)
    targets = split_large_targets(original_targets, args.max_hash_per_class_chunk)
    for old in OUT.glob("batch_*.json"):
        old.unlink()
    if args.clear_predictions:
        for old in OUT.glob("pred_*.json"):
            old.unlink()
        for old in OUT.glob("pred_*.raw.txt"):
            old.unlink()

    manifest_batches = []
    for batch_id, start in enumerate(range(0, len(targets), args.batch_size)):
        chunk = targets[start : start + args.batch_size]
        path = OUT / f"batch_{batch_id:03d}.json"
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
        "batch_size": args.batch_size,
        "selected_classes": len(original_targets),
        "selected_prompt_items": len(targets),
        "selected_hash_methods": sum(len(t["hash_methods"]) for t in targets),
        "batches": manifest_batches,
        "top_classes": [
            {
                "namespace": item["namespace"],
                "class": item["class"],
                "hash_methods": len(item["hash_methods"]),
                "known_methods": len(item["known_methods"]),
            }
            for item in targets[:50]
        ],
    }
    write_json(OUT / "manifest.json", manifest)
    print(f"batches                            : {len(manifest_batches)}")
    print(f"manifest                           : {OUT / 'manifest.json'}")


def build_prompt(batch: list[dict[str, Any]]) -> str:
    lines = [
        "Name only the m_XXX methods you can infer. Keep keys exactly as ClassName::m_XXX.",
    ]
    for ctx in batch:
        lines.append("")
        lines.append(f"Namespace: {ctx.get('namespace', '')}")
        lines.append(f"Class: {ctx['class']}")
        lines.append(f"Parent: {ctx.get('parent', '')}")
        lines.append(f"All known methods ({len(ctx.get('known_methods', []))}):")
        if ctx.get("known_methods"):
            lines.append(", ".join(ctx["known_methods"]))
        else:
            lines.append("(none)")
        lines.append(f"Fields ({len(ctx.get('fields', []))}):")
        if ctx.get("fields"):
            lines.append(", ".join(ctx["fields"]))
        else:
            lines.append("(none)")
        lines.append(f"Hash methods to name ({len(ctx.get('hash_methods', []))}):")
        lines.append(", ".join(ctx.get("hash_methods", [])))
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
    req = urllib.request.Request(
        f"{api_base}/v1/chat/completions",
        data=body,
        headers={"Content-Type": "application/json", "Authorization": f"Bearer {api_key}"},
        method="POST",
    )
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


def extract_json_object(text: str) -> dict[str, Any]:
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


def batch_files() -> list[Path]:
    return sorted(OUT.glob("batch_*.json"))


def prediction_files() -> list[Path]:
    return sorted(OUT.glob("pred_*.json"))


def run_one(path: Path, args: argparse.Namespace) -> tuple[str, int, str]:
    batch_id = path.stem.rsplit("_", 1)[1]
    pred_path = OUT / f"pred_{batch_id}.json"
    raw_path = OUT / f"pred_{batch_id}.raw.txt"
    if pred_path.exists() and not args.force:
        existing = load_json(pred_path)
        if isinstance(existing, dict) and existing:
            return batch_id, len(existing), "cached"

    batch = load_json(path)
    prompt = build_prompt(batch)
    response = call_api(prompt, args)
    if response.startswith("ERROR:"):
        raw_path.write_text(response, encoding="utf-8")
        return batch_id, 0, response[:120]

    predictions = extract_json_object(response)
    write_json(pred_path, predictions)
    if predictions:
        raw_path.unlink(missing_ok=True)
        return batch_id, len(predictions), "ok"
    raw_path.write_text(response, encoding="utf-8")
    return batch_id, 0, "parse_error"


def run_batches(args: argparse.Namespace) -> None:
    files = batch_files()
    if args.start is not None:
        files = [p for p in files if int(p.stem.rsplit("_", 1)[1]) >= args.start]
    if args.end is not None:
        files = [p for p in files if int(p.stem.rsplit("_", 1)[1]) <= args.end]
    if not files:
        print("No VRC domain batch files found")
        return

    print(f"running VRC domain batches: {len(files)}")
    print(f"model: {os.environ.get('LLM_MODEL', args.model)}")
    print(f"api base: {os.environ.get('API_BASE', args.api_base)}")
    print(f"concurrent workers: {args.concurrent}")
    total = ok = cached = errors = 0
    t0 = time.time()
    with concurrent.futures.ThreadPoolExecutor(max_workers=args.concurrent) as pool:
        futures = {pool.submit(run_one, path, args): path for path in files}
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
            print(f"[{index}/{len(files)}] batch_{batch_id}: {status} ({count}) elapsed={elapsed:.1f}s")
    print(f"predictions: {total}")
    print(f"ok={ok} cached={cached} errors={errors}")


def target_index() -> dict[str, dict[str, Any]]:
    index: dict[str, dict[str, Any]] = {}
    for path in batch_files():
        batch = load_json(path)
        if not isinstance(batch, list):
            continue
        for item in batch:
            if not isinstance(item, dict):
                continue
            class_name = item.get("class", "")
            namespace = item.get("namespace", "")
            for method in item.get("hash_methods", []):
                if isinstance(class_name, str) and isinstance(method, str) and HASH_RE.match(method):
                    index[f"{class_name}::{method}"] = {
                        "class": class_name,
                        "namespace": namespace,
                        "is_vrc_namespace": str(namespace).startswith("VRC"),
                        "is_priority": bool(PRIORITY_RE.search(class_name)),
                        "is_keyword": bool(KEYWORD_RE.search(class_name)),
                    }
    return index


def valid_prediction(key: str, name: Any, index: dict[str, dict[str, Any]], rejected: Counter) -> str:
    if key not in index:
        rejected["not_targeted"] += 1
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
    return normalized


def merge_predictions(args: argparse.Namespace) -> None:
    existing = load_json(LLM_NAMES) if LLM_NAMES.exists() else {}
    before = len(existing)
    index = target_index()
    raw_predictions: dict[str, Any] = {}
    rejected: Counter = Counter()
    for path in prediction_files():
        data = load_json(path)
        if isinstance(data, dict):
            raw_predictions.update(data)

    candidates: dict[str, str] = {}
    for key, name in raw_predictions.items():
        if key in existing and not args.override_existing:
            rejected["already_mapped"] += 1
            continue
        if not isinstance(key, str) or "::" not in key or not HASH_RE.match(key.rsplit("::", 1)[1]):
            rejected["bad_key"] += 1
            continue
        normalized = valid_prediction(key, name, index, rejected)
        if normalized:
            candidates[key] = normalized

    per_class: dict[str, Counter] = defaultdict(Counter)
    for key, name in candidates.items():
        per_class[key.split("::", 1)[0]][name] += 1
    duplicate_pairs = {
        (class_name, name)
        for class_name, names in per_class.items()
        for name, count in names.items()
        if count > args.max_same_name_per_class
    }
    if duplicate_pairs:
        before_dupes = len(candidates)
        candidates = {
            key: name
            for key, name in candidates.items()
            if (key.split("::", 1)[0], name) not in duplicate_pairs
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
        backup = OUTPUT / f"llm_predicted_names.pre_vrc_domain_{datetime.now().strftime('%Y%m%d_%H%M%S')}.json"
        write_json(backup, existing)
        existing.update(dict(sorted(candidates.items())))
        write_json(LLM_NAMES, existing)
        added = len(existing) - before

    report = {
        "generated_at": datetime.now().isoformat(timespec="seconds"),
        "dry_run": args.dry_run,
        "raw_predictions": len(raw_predictions),
        "target_keys": len(index),
        "filtered_candidates": len(candidates),
        "llm_predicted_before": before,
        "llm_predicted_after": before + added,
        "new_entries": added,
        "rejected": dict(rejected.most_common()),
        "sample": dict(list(sorted(candidates.items()))[:40]),
    }
    write_json(OUT / "merge_report.json", report)
    print(f"raw predictions       : {len(raw_predictions)}")
    print(f"target keys           : {len(index)}")
    print(f"filtered candidates   : {len(candidates)}")
    print(f"new llm rows          : {added}")
    for reason, count in rejected.most_common():
        print(f"  rejected {reason}: {count}")
    print(f"report                : {OUT / 'merge_report.json'}")


def stats(_: argparse.Namespace) -> None:
    manifest = load_json(OUT / "manifest.json") if (OUT / "manifest.json").exists() else {}
    predictions = {}
    for path in prediction_files():
        data = load_json(path)
        if isinstance(data, dict):
            predictions.update(data)
    report = load_json(OUT / "merge_report.json") if (OUT / "merge_report.json").exists() else {}
    print(f"selected classes      : {manifest.get('selected_classes', 0)}")
    print(f"selected hash methods : {manifest.get('selected_hash_methods', 0)}")
    print(f"raw predictions       : {len(predictions)}")
    print(f"merged new entries    : {report.get('new_entries', 0)}")


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser()
    sub = parser.add_subparsers(dest="cmd", required=True)

    build = sub.add_parser("build")
    build.add_argument("--batch-size", type=int, default=3)
    build.add_argument("--keyword-limit", type=int, default=80)
    build.add_argument("--max-classes", type=int, default=0)
    build.add_argument("--max-hash-per-class-chunk", type=int, default=40)
    build.add_argument("--include-global-priority", action="store_true", default=True)
    build.add_argument("--clear-predictions", action="store_true")
    build.set_defaults(func=build_batches)

    run = sub.add_parser("run")
    run.add_argument("--api-base", default="https://REDACTED_API_HOST")
    run.add_argument("--model", default="gpt-5.5")
    run.add_argument("--temperature", type=float, default=0.25)
    run.add_argument("--max-tokens", type=int, default=4096)
    run.add_argument("--timeout", type=int, default=180)
    run.add_argument("--retries", type=int, default=2)
    run.add_argument("--retry-delay", type=float, default=8.0)
    run.add_argument("--concurrent", type=int, default=3)
    run.add_argument("--start", type=int)
    run.add_argument("--end", type=int)
    run.add_argument("--force", action="store_true")
    run.set_defaults(func=run_batches)

    merge = sub.add_parser("merge")
    merge.add_argument("--dry-run", action="store_true")
    merge.add_argument("--override-existing", action="store_true")
    merge.add_argument("--max-same-name-per-class", type=int, default=3)
    merge.add_argument("--max-global-same-name", type=int, default=20)
    merge.set_defaults(func=merge_predictions)

    stats_cmd = sub.add_parser("stats")
    stats_cmd.set_defaults(func=stats)
    return parser.parse_args()


def main() -> None:
    args = parse_args()
    args.func(args)


if __name__ == "__main__":
    main()
