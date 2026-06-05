#!/usr/bin/env python3
"""Run hexrays round 2 batches through LLM API."""
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
BATCH_DIR = BASE / "output" / "llm_batches_hexrays_r2"
LOCK_PATH = BATCH_DIR / "runner.lock"

API_URL = os.environ.get("OPENAI_API_BASE", "")
if API_URL and not API_URL.endswith("/chat/completions"):
    API_URL = API_URL.rstrip("/") + "/v1/chat/completions"
API_KEY = os.environ.get("OPENAI_API_KEY", "")
MODEL = os.environ.get("OPENAI_MODEL", "gpt-5.5")


def acquire_lock():
    BATCH_DIR.mkdir(parents=True, exist_ok=True)
    flags = os.O_CREAT | os.O_EXCL | os.O_WRONLY
    try:
        fd = os.open(LOCK_PATH, flags)
    except FileExistsError as exc:
        detail = LOCK_PATH.read_text(encoding="utf-8", errors="replace") if LOCK_PATH.exists() else ""
        raise SystemExit(f"Another run active: {LOCK_PATH}\n{detail}") from exc
    os.write(fd, f"pid={os.getpid()}\nstarted={time.strftime('%Y-%m-%d %H:%M:%S')}\n".encode())

    def cleanup():
        try:
            os.close(fd)
        except OSError:
            pass
        try:
            LOCK_PATH.unlink()
        except FileNotFoundError:
            pass

    atexit.register(cleanup)


def build_prompt(batch):
    cls = batch["class"]
    parent = batch.get("parent", "")
    ns = batch.get("namespace", "")
    named = batch.get("named_methods", [])

    lines = [
        "Name these obfuscated IL2CPP methods from VRChat using the Hex-Rays pseudocode.",
        "Return a single JSON object: {\"Class::m_XXX\": \"PascalCaseName\"}.",
        "Only include confident predictions. Omit uncertain ones.",
        "",
        f"Class: {cls} (namespace: {ns}, parent: {parent})",
        f"Known methods: {', '.join(named[:20]) if named else 'none'}",
        "",
    ]

    for target in batch["targets"]:
        lines.append(f"===== {target['key']} =====")
        lines.append(target["pseudocode"][:4000])
        lines.append("")

    return "\n".join(lines)


def call_api(prompt):
    body = json.dumps({
        "model": MODEL,
        "messages": [{"role": "user", "content": prompt}],
        "temperature": 0.15,
        "max_tokens": 4096,
    }).encode()
    headers = {
        "Content-Type": "application/json",
        "Authorization": f"Bearer {API_KEY}",
    }

    for attempt in range(6):
        req = urllib.request.Request(API_URL, data=body, headers=headers, method="POST")
        try:
            with urllib.request.urlopen(req, timeout=300) as resp:
                payload = json.loads(resp.read().decode())
            return payload["choices"][0]["message"]["content"]
        except urllib.error.HTTPError as exc:
            if exc.code in (429, 500, 502, 503, 504) and attempt < 5:
                time.sleep(min(120, 10 * (2 ** attempt)))
                continue
            raise
        except Exception:
            if attempt < 5:
                time.sleep(min(120, 10 * (2 ** attempt)))
                continue
            raise
    raise RuntimeError("max retries")


def extract_json(text):
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
    return {k: v for k, v in data.items() if isinstance(v, str)} if isinstance(data, dict) else {}


def run_one(batch_file):
    suffix = batch_file.stem.split("_")[-1]
    pred_file = BATCH_DIR / f"pred_{suffix}.json"

    if pred_file.exists():
        try:
            existing = json.loads(pred_file.read_text(encoding="utf-8"))
            if isinstance(existing, dict) and existing:
                return batch_file.name, len(existing), "skipped"
        except Exception:
            pass

    batch = json.loads(batch_file.read_text(encoding="utf-8"))
    allowed_keys = {t["key"] for t in batch["targets"]}

    response = call_api(build_prompt(batch))
    preds = extract_json(response)
    preds = {k: v for k, v in preds.items() if k in allowed_keys}

    with open(pred_file, "w", encoding="utf-8") as f:
        json.dump(preds, f, indent=1, ensure_ascii=False)

    return batch_file.name, len(preds), "ok"


def main():
    if not API_KEY:
        raise SystemExit("OPENAI_API_KEY not set.")
    if not API_URL:
        raise SystemExit("OPENAI_API_BASE not set.")

    import argparse
    parser = argparse.ArgumentParser()
    parser.add_argument("--concurrent", type=int, default=3)
    args = parser.parse_args()

    acquire_lock()

    batches = sorted(BATCH_DIR.glob("batch_*.json"))
    if not batches:
        raise SystemExit("No batches. Run build_hexrays_round2_batches.py first.")

    pending = [b for b in batches if not (BATCH_DIR / f"pred_{b.stem.split('_')[-1]}.json").exists()]
    print(f"Running {len(pending)}/{len(batches)} batches with {args.concurrent} workers")

    total = errors = 0
    started = time.time()

    with concurrent.futures.ThreadPoolExecutor(max_workers=args.concurrent) as pool:
        futures = {pool.submit(run_one, b): b for b in pending}
        for done, future in enumerate(concurrent.futures.as_completed(futures), 1):
            batch = futures[future]
            try:
                name, count, status = future.result()
                total += count
                elapsed = time.time() - started
                print(f"[{done}/{len(pending)}] {name} -> {count} ({status}); {elapsed:.0f}s", flush=True)
            except Exception as exc:
                errors += 1
                suffix = batch.stem.split("_")[-1]
                (BATCH_DIR / f"pred_{suffix}.json.error.txt").write_text(str(exc), encoding="utf-8")
                print(f"[{done}/{len(pending)}] {batch.name} -> ERROR: {exc}", flush=True)

    print(f"Done. Predictions: {total}, Errors: {errors}")
    if errors:
        raise SystemExit(1)


if __name__ == "__main__":
    main()
