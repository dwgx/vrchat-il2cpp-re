#!/usr/bin/env python3
"""Run deep class batches through an OpenAI-compatible chat API."""
import concurrent.futures
import json
import os
import re
import sys
import time
import urllib.error
import urllib.request
import atexit
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output/llm_batches_deep_class"
LOCK_PATH = BATCH_DIR / "run_deep_class_api.lock"

API_URL = os.environ.get(
    "DEEP_CLASS_API_URL",
    "https://REDACTED_API_HOST/v1/chat/completions",
)
API_KEY = os.environ.get("DEEP_CLASS_API_KEY", "REDACTED_API_KEY")
MODEL = os.environ.get("DEEP_CLASS_MODEL", "gpt-5.5")
TEMPERATURE = float(os.environ.get("DEEP_CLASS_TEMPERATURE", "0.15"))
MAX_TOKENS = int(os.environ.get("DEEP_CLASS_MAX_TOKENS", "8192"))
DEFAULT_WORKERS = 2
MAX_RETRIES = 5

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")


def load_json(path: Path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def extract_json(text: str) -> dict:
    match = re.search(r"```(?:json)?\s*(\{.*?\})\s*```", text, re.DOTALL)
    if match:
        text = match.group(1)
    start = text.find("{")
    end = text.rfind("}")
    if start < 0 or end <= start:
        return {}
    try:
        parsed = json.loads(text[start:end + 1])
    except json.JSONDecodeError:
        return {}
    return parsed if isinstance(parsed, dict) else {}


def target_keys(batch: dict) -> list[str]:
    cls = batch["class"]
    keys = []
    for item in batch.get("hash_methods_with_pseudo", []):
        name = item.get("name", "")
        if HASH_RE.match(name):
            keys.append(f"{cls}::{name}")
    for name in batch.get("hash_methods_no_pseudo", []):
        if HASH_RE.match(name):
            keys.append(f"{cls}::{name}")
    return list(dict.fromkeys(keys))


def build_prompt(batch: dict) -> str:
    cls = batch["class"]
    parent = batch.get("parent") or ""
    named = batch.get("named_methods") or []
    with_pseudo = batch.get("hash_methods_with_pseudo") or []
    no_pseudo = batch.get("hash_methods_no_pseudo") or []

    lines = [
        "You are naming obfuscated IL2CPP methods from a VRChat reverse engineering project.",
        "Use the full class context and Hex-Rays pseudocode to infer concise, specific C# method names.",
        "Return only a single JSON object mapping \"Class::m_XXX\" to \"PascalCaseName\".",
        "Do not include markdown, comments, explanations, confidence scores, or nested objects.",
        "Prefer domain-specific names over generic verbs. Reject uncertainty by omitting that key.",
        "Valid names are C#-style identifiers, usually PascalCase. Property accessors may use get_Name or set_Name.",
        "",
        f"Class: {cls}",
        f"Parent: {parent}",
        "",
        "Existing named methods in this class:",
        json.dumps(named, ensure_ascii=False, indent=1),
        "",
        "Methods without pseudocode, name only if class context makes the role clear:",
        json.dumps(no_pseudo, ensure_ascii=False, indent=1),
        "",
        "Target methods with pseudocode:",
    ]

    for item in with_pseudo:
        method = item.get("name", "")
        pseudo = item.get("pseudocode", "")
        lines.extend([
            "",
            f"===== {cls}::{method} =====",
            pseudo,
        ])

    lines.extend([
        "",
        "Output JSON keys must be selected from this exact list:",
        json.dumps(target_keys(batch), ensure_ascii=False, indent=1),
    ])
    return "\n".join(lines)


def call_api(prompt: str) -> str:
    headers = {
        "Content-Type": "application/json",
        "Authorization": f"Bearer {API_KEY}",
    }
    body = json.dumps({
        "model": MODEL,
        "messages": [{"role": "user", "content": prompt}],
        "temperature": TEMPERATURE,
        "max_tokens": MAX_TOKENS,
    }).encode("utf-8")

    last_error = ""
    for attempt in range(MAX_RETRIES):
        request = urllib.request.Request(API_URL, data=body, headers=headers, method="POST")
        try:
            with urllib.request.urlopen(request, timeout=600) as response:
                payload = json.loads(response.read().decode("utf-8"))
                return payload["choices"][0]["message"]["content"]
        except urllib.error.HTTPError as exc:
            detail = exc.read().decode("utf-8", errors="replace")[:1000]
            last_error = f"HTTP {exc.code}: {detail}"
            if exc.code not in (408, 409, 429, 500, 502, 503, 504):
                break
        except Exception as exc:
            last_error = repr(exc)
        if attempt < MAX_RETRIES - 1:
            time.sleep(min(120, 12 * (attempt + 1)))
    return f"ERROR:{last_error}"


def existing_valid(path: Path) -> int | None:
    if not path.exists():
        return None
    try:
        data = load_json(path)
    except Exception:
        return None
    return len(data) if isinstance(data, dict) else None


def run_one(batch_file: Path) -> tuple[str, int, str]:
    suffix = batch_file.stem.split("_")[-1]
    pred_file = BATCH_DIR / f"pred_{suffix}.json"
    raw_file = BATCH_DIR / f"pred_{suffix}.json.raw.txt"

    existing_count = existing_valid(pred_file)
    if existing_count is not None:
        return batch_file.name, existing_count, "skipped"

    batch = load_json(batch_file)
    prompt = build_prompt(batch)
    response = call_api(prompt)
    if response.startswith("ERROR:"):
        raw_file.write_text(response, encoding="utf-8")
        return batch_file.name, 0, "error"

    predictions = extract_json(response)
    allowed = set(target_keys(batch))
    predictions = {
        key: value
        for key, value in predictions.items()
        if key in allowed and isinstance(value, str)
    }

    if not predictions and response.strip() != "{}":
        raw_file.write_text(response, encoding="utf-8")
        return batch_file.name, 0, "invalid_json"

    with open(pred_file, "w", encoding="utf-8") as handle:
        json.dump(predictions, handle, indent=1, ensure_ascii=False)
    if raw_file.exists():
        raw_file.unlink()
    return batch_file.name, len(predictions), "ok"


def main() -> None:
    BATCH_DIR.mkdir(parents=True, exist_ok=True)
    pid = os.getpid()
    if LOCK_PATH.exists():
        try:
            existing_pid = int(LOCK_PATH.read_text(encoding="utf-8").strip())
        except Exception:
            existing_pid = 0
        if existing_pid and existing_pid != pid:
            if os.name == "nt":
                try:
                    import ctypes

                    handle = ctypes.windll.kernel32.OpenProcess(0x1000, False, existing_pid)
                    if handle:
                        ctypes.windll.kernel32.CloseHandle(handle)
                        print(f"Another deep class API runner is active: pid={existing_pid}")
                        return
                except Exception:
                    pass
            else:
                try:
                    os.kill(existing_pid, 0)
                    print(f"Another deep class API runner is active: pid={existing_pid}")
                    return
                except OSError:
                    pass
    LOCK_PATH.write_text(str(pid), encoding="utf-8")

    def cleanup_lock() -> None:
        try:
            if LOCK_PATH.exists() and LOCK_PATH.read_text(encoding="utf-8").strip() == str(pid):
                LOCK_PATH.unlink()
        except Exception:
            pass

    atexit.register(cleanup_lock)

    workers = DEFAULT_WORKERS
    if "--workers" in sys.argv:
        idx = sys.argv.index("--workers")
        if idx + 1 < len(sys.argv):
            workers = int(sys.argv[idx + 1])

    batches = sorted(BATCH_DIR.glob("batch_*.json"))
    if not batches:
        print("No batches. Run tools/build_deep_class_batches.py first.")
        return

    print(f"Running {len(batches)} deep class batches with {workers} workers; model={MODEL}")
    total = 0
    statuses = {}
    started = time.time()
    with concurrent.futures.ThreadPoolExecutor(max_workers=workers) as pool:
        futures = {pool.submit(run_one, batch): batch for batch in batches}
        for done, future in enumerate(concurrent.futures.as_completed(futures), 1):
            name, count, status = future.result()
            total += count
            statuses[status] = statuses.get(status, 0) + 1
            elapsed = time.time() - started
            print(
                f"[{done}/{len(batches)}] {name} -> {count} predictions "
                f"({status}); elapsed={elapsed:.1f}s",
                flush=True,
            )

    print(f"Done. Total predictions: {total}")
    print("Statuses:", json.dumps(statuses, sort_keys=True))


if __name__ == "__main__":
    main()
