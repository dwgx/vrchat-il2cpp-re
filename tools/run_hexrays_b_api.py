#!/usr/bin/env python3
"""Run Path B Hex-Rays batches through an OpenAI-compatible chat API."""
import concurrent.futures
import json
import os
import re
import subprocess
import sys
import time
import urllib.error
import urllib.request
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output/llm_batches_hexrays_b"
PROMPT_TOOL = BASE / "tools/hexrays_b_prompt.py"

API_KEY = os.environ.get("OPENAI_API_KEY", "")
API_BASE = os.environ.get("API_BASE", "https://api.shqbb.com").rstrip("/")
MODEL = os.environ.get("LLM_MODEL", "gpt-5.5")


def extract_json(text: str) -> dict:
    match = re.search(r"```(?:json)?\s*(\{.*?\})\s*```", text, re.DOTALL)
    if match:
        text = match.group(1)
    start = text.find("{")
    end = text.rfind("}")
    if start < 0 or end <= start:
        return {}
    try:
        data = json.loads(text[start:end + 1])
    except json.JSONDecodeError:
        return {}
    return data if isinstance(data, dict) else {}


def make_prompt(batch_file: Path) -> str:
    result = subprocess.run(
        [sys.executable, str(PROMPT_TOOL), str(batch_file)],
        cwd=str(BASE),
        capture_output=True,
        text=True,
        encoding="utf-8",
        errors="replace",
        check=True,
    )
    return result.stdout


def call_api(prompt: str) -> str:
    headers = {
        "Content-Type": "application/json",
        "Authorization": f"Bearer {API_KEY}",
    }
    body = json.dumps({
        "model": MODEL,
        "messages": [{"role": "user", "content": prompt}],
        "temperature": 0.2,
        "max_tokens": 4096,
    }).encode("utf-8")
    req = urllib.request.Request(
        f"{API_BASE}/v1/chat/completions",
        data=body,
        headers=headers,
        method="POST",
    )
    for attempt in range(4):
        try:
            with urllib.request.urlopen(req, timeout=240) as response:
                data = json.loads(response.read().decode("utf-8"))
                return data["choices"][0]["message"]["content"]
        except urllib.error.HTTPError as exc:
            detail = exc.read().decode("utf-8", errors="replace")[:300]
            if exc.code in (429, 500, 502, 503, 504) and attempt < 3:
                time.sleep(20 * (attempt + 1))
                continue
            return f"ERROR:{exc.code}:{detail}"
        except Exception as exc:
            if attempt < 3:
                time.sleep(10 * (attempt + 1))
                continue
            return f"ERROR:{exc}"
    return "ERROR:max_retries"


def run_one(batch_file: Path) -> tuple[str, int]:
    suffix = batch_file.stem.split("_")[-1]
    pred_file = BATCH_DIR / f"pred_{suffix}.json"
    if pred_file.exists():
        try:
            existing = json.load(open(pred_file, "r", encoding="utf-8"))
            if isinstance(existing, dict):
                return batch_file.name, len(existing)
        except Exception:
            pass

    prompt = make_prompt(batch_file)
    response = call_api(prompt)
    if response.startswith("ERROR:"):
        (BATCH_DIR / f"pred_{suffix}.json.raw.txt").write_text(response, encoding="utf-8")
        return batch_file.name, 0

    predictions = extract_json(response)
    if predictions == {} and response.strip() == "{}":
        with open(pred_file, "w", encoding="utf-8") as handle:
            json.dump({}, handle, indent=1, ensure_ascii=False)
        raw_path = BATCH_DIR / f"pred_{suffix}.json.raw.txt"
        if raw_path.exists():
            raw_path.unlink()
        return batch_file.name, 0
    if not predictions:
        (BATCH_DIR / f"pred_{suffix}.json.raw.txt").write_text(response, encoding="utf-8")
        return batch_file.name, 0

    with open(pred_file, "w", encoding="utf-8") as handle:
        json.dump(predictions, handle, indent=1, ensure_ascii=False)
    raw_path = BATCH_DIR / f"pred_{suffix}.json.raw.txt"
    if raw_path.exists():
        raw_path.unlink()
    return batch_file.name, len(predictions)


def main() -> None:
    if not API_KEY:
        print("ERROR: OPENAI_API_KEY not set")
        sys.exit(1)

    concurrent_n = 3
    if "--concurrent" in sys.argv:
        idx = sys.argv.index("--concurrent")
        if idx + 1 < len(sys.argv):
            concurrent_n = int(sys.argv[idx + 1])

    batches = sorted(BATCH_DIR.glob("batch_*.json"))
    if not batches:
        print("No batches. Run build_hexrays_b_batches.py first.")
        return

    print(f"Running {len(batches)} batches via API model {MODEL} with {concurrent_n} workers")
    total = 0
    with concurrent.futures.ThreadPoolExecutor(max_workers=concurrent_n) as pool:
        futures = {pool.submit(run_one, batch): batch for batch in batches}
        done = 0
        for future in concurrent.futures.as_completed(futures):
            done += 1
            name, count = future.result()
            total += count
            print(f"[{done}/{len(batches)}] {name} -> {count} predictions")
    print(f"Done. Total predictions: {total}")


if __name__ == "__main__":
    main()
