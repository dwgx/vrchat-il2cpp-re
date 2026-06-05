#!/usr/bin/env python3
"""Persistent runner for hexrays round 2 API batches."""
import json
import os
import subprocess
import sys
import time
from datetime import datetime
from pathlib import Path

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output" / "llm_batches_hexrays_r2"
LOG = BASE / "hexrays_r2_runner.log"


def log(msg):
    ts = datetime.now().strftime("%H:%M:%S")
    line = f"[{ts}] {msg}"
    print(line, flush=True)
    with open(LOG, "a", encoding="utf-8") as f:
        f.write(line + "\n")


def count_preds():
    good = empty = total_p = 0
    for f in os.listdir(BATCH_DIR):
        if not f.startswith("pred_") or not f.endswith(".json"):
            continue
        path = os.path.join(BATCH_DIR, f)
        try:
            with open(path, encoding="utf-8") as fh:
                data = json.load(fh)
            if data and len(data) > 0:
                good += 1
                total_p += len(data)
            else:
                empty += 1
        except Exception:
            empty += 1
    return good, empty, total_p


def clean_empty():
    removed = 0
    for f in os.listdir(BATCH_DIR):
        if not f.startswith("pred_") or not f.endswith(".json"):
            continue
        path = os.path.join(BATCH_DIR, f)
        try:
            with open(path, encoding="utf-8") as fh:
                data = json.load(fh)
            if not data or len(data) == 0:
                os.remove(path)
                removed += 1
        except Exception:
            os.remove(path)
            removed += 1
    lock = BATCH_DIR / "runner.lock"
    if lock.exists():
        try:
            lock.unlink()
        except Exception:
            pass
    return removed


def main():
    total_batches = len([f for f in os.listdir(BATCH_DIR) if f.startswith("batch_") and f.endswith(".json")])
    script = str(BASE / "tools" / "run_hexrays_r2_api.py")
    max_restarts = 30

    for restart in range(max_restarts):
        removed = clean_empty()
        good, empty, preds = count_preds()
        remaining = total_batches - good

        log(f"Run {restart + 1}: {good} good preds ({preds} predictions), cleaned {removed}, ~{remaining} remaining")

        if good >= total_batches * 0.95:
            log(f"95%+ done ({good}/{total_batches}). Stopping.")
            break

        try:
            result = subprocess.run(
                [sys.executable, script, "--concurrent", "3"],
                cwd=str(BASE),
                timeout=3600,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
                env={**os.environ},
            )
            log(f"Exit code {result.returncode}")
            if result.stdout:
                for line in result.stdout.strip().split("\n")[-5:]:
                    log(f"  {line}")
        except subprocess.TimeoutExpired:
            log("Timeout after 60min, restarting...")
        except Exception as e:
            log(f"Error: {e}")

        time.sleep(5)

    good, empty, preds = count_preds()
    log(f"Final: {good} good, {empty} empty, {preds} predictions")


if __name__ == "__main__":
    log("=== Hexrays R2 persistent runner started ===")
    main()
    log("=== Runner finished ===")
