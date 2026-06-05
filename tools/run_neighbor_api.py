#!/usr/bin/env python3
"""Run neighbor-context batches through an OpenAI-compatible chat API."""
from __future__ import annotations

import argparse
import atexit
import concurrent.futures
import json
import os
import re
import sys
import time
import urllib.error
import urllib.request
from pathlib import Path


sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output" / "llm_batches_neighbor"
LOCK_PATH = BATCH_DIR / "run_neighbor_api.lock"

API_URL = os.environ.get(
    "OPENAI_API_BASE",
    os.environ.get("NEIGHBOR_API_URL", ""),
)
if API_URL and not API_URL.endswith("/chat/completions"):
    API_URL = API_URL.rstrip("/") + "/v1/chat/completions"
API_KEY = os.environ.get("OPENAI_API_KEY", os.environ.get("NEIGHBOR_API_KEY", ""))
MODEL = os.environ.get("NEIGHBOR_MODEL", "gpt-5.5")
RETRY_CODES = {429, 500, 502, 503, 504}


def acquire_lock() -> int:
    BATCH_DIR.mkdir(parents=True, exist_ok=True)
    flags = os.O_CREAT | os.O_EXCL | os.O_WRONLY
    try:
        fd = os.open(LOCK_PATH, flags)
    except FileExistsError as exc:
        detail = LOCK_PATH.read_text(encoding="utf-8", errors="replace") if LOCK_PATH.exists() else ""
        raise SystemExit(f"Another run appears active: {LOCK_PATH}\n{detail}") from exc
    os.write(fd, f"pid={os.getpid()}\nstarted={time.strftime('%Y-%m-%d %H:%M:%S')}\n".encode("utf-8"))

    def cleanup() -> None:
        try:
            os.close(fd)
        except OSError:
            pass
        try:
            LOCK_PATH.unlink()
        except FileNotFoundError:
            pass

    atexit.register(cleanup)
    return fd


def load_json(path: Path) -> object:
    return json.loads(path.read_text(encoding="utf-8"))


def write_json(path: Path, data: object) -> None:
    path.write_text(json.dumps(data, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")


def extract_json_object(text: str) -> dict[str, str]:
    text = text.strip()
    fenced = re.search(r"```(?:json)?\s*(\{.*?\})\s*```", text, re.DOTALL)
    if fenced:
        text = fenced.group(1)
    start = text.find("{")
    end = text.rfind("}")
    if start < 0 or end < start:
        return {}
    try:
        data = json.loads(text[start : end + 1])
    except json.JSONDecodeError:
        return {}
    if not isinstance(data, dict):
        return {}
    return {str(key): str(value) for key, value in data.items() if isinstance(value, str)}


def batch_suffix(batch_file: Path) -> str:
    return batch_file.stem.rsplit("_", 1)[-1]


def build_prompt(batch: dict) -> str:
    named_list = ", ".join(batch.get("named_methods", []))
    hash_list = ", ".join(batch.get("hash_methods", []))
    name = batch.get("class", "")
    parent = batch.get("parent", "")
    return (
        f"Given VRChat class {name} (parent: {parent}) with these known methods: "
        f"{named_list}, predict names for: {hash_list}. Return JSON: "
        "{\"m_XXX\": \"PredictedName\"}. Only confident predictions. PascalCase."
    )


def call_api(prompt: str) -> str:
    body = json.dumps(
        {
            "model": MODEL,
            "messages": [{"role": "user", "content": prompt}],
            "temperature": 0.2,
            "max_tokens": 4096,
        }
    ).encode("utf-8")
    headers = {
        "Content-Type": "application/json",
        "Authorization": f"Bearer {API_KEY}",
    }

    for attempt in range(8):
        request = urllib.request.Request(API_URL, data=body, headers=headers, method="POST")
        try:
            with urllib.request.urlopen(request, timeout=240) as response:
                payload = json.loads(response.read().decode("utf-8"))
            return payload["choices"][0]["message"]["content"]
        except urllib.error.HTTPError as exc:
            detail = exc.read().decode("utf-8", errors="replace")[:1000]
            if exc.code in RETRY_CODES and attempt < 7:
                time.sleep(min(120, 10 * (2**attempt)))
                continue
            raise RuntimeError(f"HTTP {exc.code}: {detail}") from exc
        except Exception:
            if attempt < 7:
                time.sleep(min(120, 10 * (2**attempt)))
                continue
            raise

    raise RuntimeError("max retries exceeded")


def run_one(batch_file: Path) -> tuple[str, int, str]:
    suffix = batch_suffix(batch_file)
    pred_file = BATCH_DIR / f"pred_{suffix}.json"
    raw_file = BATCH_DIR / f"pred_{suffix}.json.raw.txt"
    error_file = BATCH_DIR / f"pred_{suffix}.json.error.txt"

    if pred_file.exists():
        try:
            existing = load_json(pred_file)
            if isinstance(existing, dict):
                return batch_file.name, len(existing), "skipped"
        except Exception:
            pass

    batch = load_json(batch_file)
    if not isinstance(batch, dict):
        raise RuntimeError(f"Invalid batch file: {batch_file}")

    response = call_api(build_prompt(batch))
    raw_file.write_text(response, encoding="utf-8")
    predictions = extract_json_object(response)
    write_json(pred_file, predictions)
    if error_file.exists():
        error_file.unlink()
    return batch_file.name, len(predictions), "done"


def main() -> None:
    parser = argparse.ArgumentParser()
    parser.add_argument("--concurrent", type=int, default=3)
    args = parser.parse_args()

    if not API_KEY:
        raise SystemExit("OPENAI_API_KEY not set. Export it before running.")
    if not API_URL:
        raise SystemExit("OPENAI_API_BASE not set. Export it before running.")

    acquire_lock()

    batches = sorted(BATCH_DIR.glob("batch_*.json"))
    if not batches:
        raise SystemExit("No batches found. Run tools/build_neighbor_batches.py first.")

    pending = []
    skipped = 0
    for batch in batches:
        pred = BATCH_DIR / f"pred_{batch_suffix(batch)}.json"
        if pred.exists():
            skipped += 1
        else:
            pending.append(batch)

    print(
        f"Running {len(pending)} pending / {len(batches)} total batches "
        f"with {args.concurrent} workers; {skipped} already have pred files."
    )
    total_predictions = 0
    completed = 0
    errors = 0

    with concurrent.futures.ThreadPoolExecutor(max_workers=args.concurrent) as pool:
        futures = {pool.submit(run_one, batch): batch for batch in pending}
        for future in concurrent.futures.as_completed(futures):
            completed += 1
            batch = futures[future]
            try:
                name, count, status = future.result()
                total_predictions += count
                print(f"[{completed}/{len(pending)}] {name} -> {count} predictions ({status})", flush=True)
            except Exception as exc:
                errors += 1
                suffix = batch_suffix(batch)
                error_file = BATCH_DIR / f"pred_{suffix}.json.error.txt"
                error_file.write_text(str(exc), encoding="utf-8")
                print(f"[{completed}/{len(pending)}] {batch.name} -> ERROR: {exc}", flush=True)

    print(f"Done. New predictions written: {total_predictions}. Errors: {errors}")
    if errors:
        raise SystemExit(1)


if __name__ == "__main__":
    main()
