#!/usr/bin/env python3
"""API worker for sibling-context batch naming.

Processes sibling_batches/batch_XXXX.txt files through OpenAI-compatible API.
Smaller prompts than mega-batches, so API is more efficient than Codex CLI.

Usage:
  python sibling_api_worker.py [worker_id] [total_workers]
  python sibling_api_worker.py 0 3   # Worker 0 of 3
  python sibling_api_worker.py       # Single worker, all batches

Env vars: OPENAI_API_KEY, OPENAI_API_BASE (from .env)
"""
import json
import os
import re
import sys
import time
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

try:
    from dotenv import load_dotenv
    load_dotenv(Path(__file__).resolve().parent.parent / ".env")
except ImportError:
    pass

try:
    import httpx
except ImportError:
    print("pip install httpx")
    sys.exit(1)

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output" / "sibling_batches"
PRED_DIR = BASE / "output" / "sibling_preds"

API_BASE = os.environ.get("OPENAI_API_BASE", "").rstrip("/")
API_KEY = os.environ.get("OPENAI_API_KEY", "")
MODEL = os.environ.get("SIBLING_MODEL", "gpt-4o-mini")

TIMEOUT = 120
MAX_RETRIES = 3


def call_api(prompt: str) -> str:
    headers = {
        "Authorization": f"Bearer {API_KEY}",
        "Content-Type": "application/json",
    }
    body = {
        "model": MODEL,
        "messages": [{"role": "user", "content": prompt}],
        "temperature": 0.1,
        "max_tokens": 4096,
    }
    url = f"{API_BASE}/chat/completions"

    for attempt in range(MAX_RETRIES):
        try:
            r = httpx.post(url, json=body, headers=headers, timeout=TIMEOUT)
            r.raise_for_status()
            data = r.json()
            return data["choices"][0]["message"]["content"]
        except Exception as e:
            print(f"  API error (attempt {attempt+1}): {e}")
            if attempt < MAX_RETRIES - 1:
                time.sleep(2 ** attempt)
    return ""


def extract_json(text: str) -> dict:
    """Extract JSON object from LLM response."""
    # Try direct parse
    text = text.strip()
    if text.startswith("```"):
        lines = text.split("\n")
        start = 1
        end = len(lines) - 1
        for i, l in enumerate(lines):
            if l.strip().startswith("```") and i > 0:
                end = i
                break
        text = "\n".join(lines[start:end])

    try:
        return json.loads(text)
    except json.JSONDecodeError:
        pass

    # Find JSON block
    match = re.search(r'\{[^{}]*(?:\{[^{}]*\}[^{}]*)*\}', text, re.DOTALL)
    if match:
        try:
            return json.loads(match.group())
        except json.JSONDecodeError:
            pass

    return {}


def process_batch(batch_id: int) -> dict:
    batch_file = BATCH_DIR / f"batch_{batch_id:04d}.txt"
    pred_file = PRED_DIR / f"pred_{batch_id:04d}.json"
    keys_file = BATCH_DIR / f"batch_{batch_id:04d}_keys.json"

    if pred_file.exists():
        return json.loads(pred_file.read_text(encoding="utf-8"))

    if not batch_file.exists():
        return {}

    prompt = batch_file.read_text(encoding="utf-8")
    keys = json.loads(keys_file.read_text(encoding="utf-8"))

    print(f"  Batch {batch_id:04d}: {len(keys)} methods...", end=" ", flush=True)
    response = call_api(prompt)

    if not response:
        print("FAILED")
        return {}

    preds = extract_json(response)

    # Filter: only keep keys that were asked about, skip "SKIP" values
    valid = {}
    for key in keys:
        if key in preds and preds[key] not in ("SKIP", "skip", "", None):
            name = preds[key].strip()
            if len(name) >= 2 and not name.startswith("m_"):
                valid[key] = name

    print(f"OK ({len(valid)}/{len(keys)} predicted)")

    # Save
    pred_file.write_text(json.dumps(valid, indent=2, ensure_ascii=False), encoding="utf-8")
    return valid


def main():
    if not API_KEY or not API_BASE:
        print("Set OPENAI_API_KEY and OPENAI_API_BASE env vars (or .env file)")
        sys.exit(1)

    PRED_DIR.mkdir(exist_ok=True)

    # Find all batches
    batch_files = sorted(BATCH_DIR.glob("batch_*.txt"))
    batch_ids = [int(f.stem.split("_")[1]) for f in batch_files]

    if not batch_ids:
        print("No batch files found. Run sibling_context_batches.py first.")
        sys.exit(1)

    # Worker partitioning
    worker_id = int(sys.argv[1]) if len(sys.argv) > 1 else 0
    total_workers = int(sys.argv[2]) if len(sys.argv) > 2 else 1
    my_batches = [b for b in batch_ids if b % total_workers == worker_id]

    # Skip already done
    todo = [b for b in my_batches if not (PRED_DIR / f"pred_{b:04d}.json").exists()]

    print(f"Worker {worker_id}/{total_workers}: {len(my_batches)} batches, {len(todo)} remaining")
    print(f"Model: {MODEL}")
    print(f"API: {API_BASE}")

    total_preds = 0
    for i, batch_id in enumerate(todo):
        print(f"[{i+1}/{len(todo)}]", end=" ")
        preds = process_batch(batch_id)
        total_preds += len(preds)

        if (i + 1) % 10 == 0:
            print(f"  --- Progress: {i+1}/{len(todo)}, total predictions: {total_preds}")

    print(f"\nDone. Total predictions: {total_preds}")
    print(f"Pred files: {PRED_DIR}")


if __name__ == "__main__":
    main()
