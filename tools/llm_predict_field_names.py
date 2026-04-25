#!/usr/bin/env python3
"""Predict semantic names for obfuscated VRChat field names via chat completions."""

from __future__ import annotations

import argparse
import concurrent.futures
import json
import math
import os
import re
import sys
import threading
import time
from pathlib import Path
from typing import Any

import urllib.error
import urllib.request

sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")

BASE_DIR = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE_DIR / "output" / "deobfuscated_dump.json"
OUTPUT_PATH = BASE_DIR / "data" / "llm_field_predictions.json"

CLASS_OBF_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]{3,}$")
FIELD_NAME_RE = CLASS_OBF_RE
VALID_NAME_RE = re.compile(r"^[a-zA-Z_][a-zA-Z0-9_]{0,63}$")

SYSTEM_PROMPT = (
    "You are reverse-engineering VRChat. Given a class and its method names plus "
    "its fields (with .NET types), suggest a semantic C# field name (camelCase or "
    "PascalCase per typical VRChat style) for each obf placeholder. Reply ONLY "
    'with JSON: {"obf_string": "semanticName", ...}. Use null if you cannot guess. '
    "No prose."
)


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dump", default=str(DUMP_PATH))
    parser.add_argument("--output", default=str(OUTPUT_PATH))
    parser.add_argument("--workers", type=int, default=8)
    parser.add_argument("--chunk-size", type=int, default=30)
    parser.add_argument("--progress-every", type=int, default=100)
    parser.add_argument("--max-tokens", type=int, default=800)
    parser.add_argument("--max-minutes", type=float, default=60.0)
    parser.add_argument("--request-timeout", type=int, default=180)
    parser.add_argument("--temperature", type=float, default=0.2)
    parser.add_argument("--input-cost-per-1m", type=float, default=1.25)
    parser.add_argument("--output-cost-per-1m", type=float, default=10.0)
    return parser.parse_args()


def load_env_file(path: Path) -> None:
    if not path.exists():
        return
    for raw_line in path.read_text(encoding="utf-8").splitlines():
        line = raw_line.strip()
        if not line or line.startswith("#") or "=" not in line:
            continue
        key, value = line.split("=", 1)
        key = key.strip()
        value = value.strip().strip("'\"")
        os.environ.setdefault(key, value)


def load_json(path: Path, default: Any) -> Any:
    if not path.exists():
        return default
    with path.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def atomic_write_json(path: Path, data: Any) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    tmp_path = path.with_suffix(path.suffix + ".tmp")
    with tmp_path.open("w", encoding="utf-8") as handle:
        json.dump(data, handle, indent=2, ensure_ascii=False, sort_keys=True)
    tmp_path.replace(path)


def field_name_of(field: Any) -> str:
    if isinstance(field, dict):
        return str(field.get("name", "") or "")
    return str(field or "")


def field_type_of(field: Any) -> str:
    if isinstance(field, dict):
        value = str(field.get("type", "") or "")
        return value or "object"
    return "object"


def is_obfuscated_name(name: str) -> bool:
    return bool(name) and bool(FIELD_NAME_RE.fullmatch(name))


def estimate_tokens(text: str) -> int:
    return max(1, math.ceil(len(text) / 4))


def compact_methods(methods: list[str], max_count: int = 40, max_chars: int = 700) -> str:
    chosen: list[str] = []
    total_chars = 0
    for method in methods:
        if not isinstance(method, str):
            continue
        part = method.strip()
        if not part:
            continue
        projected = total_chars + len(part) + (2 if chosen else 0)
        if len(chosen) >= max_count or projected > max_chars:
            break
        chosen.append(part)
        total_chars = projected
    return ", ".join(chosen) if chosen else "(none)"


def build_prompt(cls: dict[str, Any], chunk: list[dict[str, Any]]) -> str:
    lines = [
        f"class {cls.get('name', '?')} (parent {cls.get('parent', 'object') or 'object'})",
        f"methods: {compact_methods(cls.get('methods') or [])}",
        "fields:",
    ]
    for field in chunk:
        lines.append(f"  {field['name']} : {field['type']}")
    return "\n".join(lines)


def choose_chunk(
    cls: dict[str, Any],
    pending_fields: list[dict[str, Any]],
    start: int,
    chunk_size: int,
    max_prompt_tokens: int = 1800,
) -> tuple[list[dict[str, Any]], int]:
    end = min(len(pending_fields), start + chunk_size)
    while end > start + 1:
        chunk = pending_fields[start:end]
        prompt = build_prompt(cls, chunk)
        if estimate_tokens(SYSTEM_PROMPT) + estimate_tokens(prompt) <= max_prompt_tokens:
            return chunk, end
        end -= 1
    return pending_fields[start : start + 1], start + 1


def extract_json_object(text: str) -> dict[str, Any]:
    stripped = text.strip()
    if stripped.startswith("```"):
        stripped = stripped.strip("`")
        stripped = stripped.replace("json", "", 1).strip()
    start = stripped.find("{")
    end = stripped.rfind("}")
    if start < 0 or end <= start:
        raise ValueError("response did not contain a JSON object")
    payload = stripped[start : end + 1]
    parsed = json.loads(payload)
    if not isinstance(parsed, dict):
        raise ValueError("response JSON was not an object")
    return parsed


def call_api(
    api_key: str,
    api_base: str,
    model: str,
    prompt: str,
    max_tokens: int,
    temperature: float,
    timeout: int,
) -> str:
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
            "temperature": temperature,
            "max_tokens": max_tokens,
        }
    ).encode("utf-8")
    request = urllib.request.Request(
        f"{api_base.rstrip('/')}/v1/chat/completions",
        data=body,
        headers=headers,
        method="POST",
    )
    last_error = "unknown error"
    for attempt in range(3):
        try:
            with urllib.request.urlopen(request, timeout=timeout) as response:
                payload = json.loads(response.read().decode("utf-8"))
                return payload["choices"][0]["message"]["content"]
        except urllib.error.HTTPError as exc:
            detail = exc.read().decode("utf-8", errors="replace")[:400]
            last_error = f"HTTP {exc.code}: {detail}"
            if exc.code in (429, 503) and attempt < 2:
                time.sleep(5 * (attempt + 1))
                continue
            raise RuntimeError(last_error) from exc
        except Exception as exc:  # noqa: BLE001
            last_error = str(exc)
            if attempt < 2:
                time.sleep(2 * (attempt + 1))
                continue
            raise RuntimeError(last_error) from exc
    raise RuntimeError(last_error)


def build_tasks(dump: dict[str, Any], existing: dict[str, dict[str, str | None]]) -> list[dict[str, Any]]:
    tasks: list[dict[str, Any]] = []
    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            class_name = str(cls.get("name", "") or "")
            if not class_name or is_obfuscated_name(class_name):
                continue
            pending_fields: list[dict[str, Any]] = []
            predicted_here = existing.get(class_name, {})
            for field in cls.get("fields") or []:
                name = field_name_of(field)
                if not is_obfuscated_name(name):
                    continue
                if name in predicted_here:
                    continue
                pending_fields.append({"name": name, "type": field_type_of(field)})
            if pending_fields:
                tasks.append(
                    {
                        "namespace": namespace,
                        "class_name": class_name,
                        "class": cls,
                        "pending_fields": pending_fields,
                    }
                )
    return tasks


def process_class(
    task: dict[str, Any],
    api_key: str,
    api_base: str,
    model: str,
    chunk_size: int,
    max_tokens: int,
    temperature: float,
    request_timeout: int,
) -> dict[str, Any]:
    cls = task["class"]
    pending_fields: list[dict[str, Any]] = task["pending_fields"]
    predictions: dict[str, str | None] = {}
    api_calls = 0
    prompt_tokens = 0
    response_tokens = 0

    index = 0
    while index < len(pending_fields):
        chunk, next_index = choose_chunk(cls, pending_fields, index, chunk_size)
        prompt = build_prompt(cls, chunk)
        prompt_tokens += estimate_tokens(SYSTEM_PROMPT) + estimate_tokens(prompt)
        response = call_api(
            api_key=api_key,
            api_base=api_base,
            model=model,
            prompt=prompt,
            max_tokens=max_tokens,
            temperature=temperature,
            timeout=request_timeout,
        )
        api_calls += 1
        response_tokens += estimate_tokens(response)
        raw_predictions = extract_json_object(response)

        chunk_names = {entry["name"] for entry in chunk}
        for obf_name in chunk_names:
            value = raw_predictions.get(obf_name)
            if value is None:
                predictions[obf_name] = None
                continue
            if not isinstance(value, str):
                predictions[obf_name] = None
                continue
            candidate = value.strip()
            if not VALID_NAME_RE.fullmatch(candidate):
                predictions[obf_name] = None
                continue
            predictions[obf_name] = candidate
        index = next_index

    return {
        "class_name": task["class_name"],
        "prediction_count": sum(1 for value in predictions.values() if value),
        "field_count": len(pending_fields),
        "predictions": predictions,
        "api_calls": api_calls,
        "prompt_tokens_est": prompt_tokens,
        "response_tokens_est": response_tokens,
    }


def main() -> int:
    args = parse_args()
    load_env_file(BASE_DIR / ".env")

    api_key = os.environ.get("OPENAI_API_KEY", "").strip()
    api_base = os.environ.get("API_BASE", "https://api.shqbb.com").strip()
    model = os.environ.get("LLM_MODEL", "gpt-5.5").strip()
    if not api_key:
        print("ERROR: OPENAI_API_KEY not set", file=sys.stderr)
        return 1

    dump_path = Path(args.dump)
    output_path = Path(args.output)
    dump = load_json(dump_path, {})
    existing = load_json(output_path, {})
    atomic_write_json(output_path, existing)

    started_at = time.time()
    deadline = started_at + max(1.0, args.max_minutes * 60.0)

    tasks = build_tasks(dump, existing)
    total_classes = len(tasks)
    total_fields = sum(len(task["pending_fields"]) for task in tasks)
    print(f"Classes queued: {total_classes:,}")
    print(f"Fields queued:  {total_fields:,}")
    print(f"Workers:        {args.workers}")
    print(f"Model:          {model}")

    save_lock = threading.Lock()
    processed_classes = 0
    predicted_fields = 0
    failed_classes = 0
    api_calls = 0
    prompt_tokens_est = 0
    response_tokens_est = 0
    timed_out = False
    quota_exhausted = False

    def merge_and_save(result: dict[str, Any]) -> None:
        class_name = result["class_name"]
        target = existing.setdefault(class_name, {})
        target.update(result["predictions"])
        atomic_write_json(output_path, existing)

    task_iter = iter(tasks)
    pending: dict[concurrent.futures.Future, dict[str, Any]] = {}

    with concurrent.futures.ThreadPoolExecutor(max_workers=args.workers) as executor:
        while len(pending) < args.workers:
            try:
                task = next(task_iter)
            except StopIteration:
                break
            future = executor.submit(
                process_class,
                task,
                api_key,
                api_base,
                model,
                args.chunk_size,
                args.max_tokens,
                args.temperature,
                args.request_timeout,
            )
            pending[future] = task

        while pending:
            done, _ = concurrent.futures.wait(
                pending,
                timeout=1.0,
                return_when=concurrent.futures.FIRST_COMPLETED,
            )
            if not done:
                if time.time() >= deadline:
                    timed_out = True
                    break
                continue

            for future in done:
                task = pending.pop(future)
                processed_classes += 1
                try:
                    result = future.result()
                except Exception as exc:  # noqa: BLE001
                    failed_classes += 1
                    message = str(exc)
                    print(
                        f"[error] {task['class_name']}: {message}",
                        file=sys.stderr,
                    )
                    if "insufficient_user_quota" in message or "额度不足" in message:
                        quota_exhausted = True
                else:
                    predicted_fields += result["prediction_count"]
                    api_calls += result["api_calls"]
                    prompt_tokens_est += result["prompt_tokens_est"]
                    response_tokens_est += result["response_tokens_est"]
                    with save_lock:
                        merge_and_save(result)

                if processed_classes % args.progress_every == 0:
                    elapsed = time.time() - started_at
                    print(
                        f"Processed {processed_classes:,}/{total_classes:,} classes | "
                        f"predicted {predicted_fields:,} fields | failed {failed_classes:,} | "
                        f"calls {api_calls:,} | elapsed {elapsed / 60.0:.1f}m"
                    )

                if quota_exhausted:
                    continue

                if time.time() >= deadline:
                    timed_out = True
                    continue

                try:
                    next_task = next(task_iter)
                except StopIteration:
                    continue
                next_future = executor.submit(
                    process_class,
                    next_task,
                    api_key,
                    api_base,
                    model,
                    args.chunk_size,
                    args.max_tokens,
                    args.temperature,
                    args.request_timeout,
                )
                pending[next_future] = next_task

        if timed_out or quota_exhausted:
            if timed_out:
                print("Time budget reached; waiting for in-flight requests to finish...", file=sys.stderr)
            if quota_exhausted:
                print("API quota exhausted; waiting for in-flight requests to finish...", file=sys.stderr)
            for future, task in list(pending.items()):
                processed_classes += 1
                try:
                    result = future.result()
                except Exception as exc:  # noqa: BLE001
                    failed_classes += 1
                    print(f"[error] {task['class_name']}: {exc}", file=sys.stderr)
                else:
                    predicted_fields += result["prediction_count"]
                    api_calls += result["api_calls"]
                    prompt_tokens_est += result["prompt_tokens_est"]
                    response_tokens_est += result["response_tokens_est"]
                    with save_lock:
                        merge_and_save(result)
                pending.pop(future, None)

    elapsed = time.time() - started_at
    input_cost = (prompt_tokens_est / 1_000_000.0) * args.input_cost_per_1m
    output_cost = (response_tokens_est / 1_000_000.0) * args.output_cost_per_1m
    print()
    print(f"Classes processed: {processed_classes:,}")
    print(f"Fields predicted:  {predicted_fields:,}")
    print(f"Classes failed:    {failed_classes:,}")
    print(f"Total API calls:   {api_calls:,}")
    print(f"Elapsed time:      {elapsed:.1f}s")
    print(f"Cost estimate:     ${input_cost + output_cost:.2f}")
    if timed_out:
        print("Exit reason:       time budget reached")
    if quota_exhausted:
        print("Exit reason:       API quota exhausted")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
