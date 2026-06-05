#!/usr/bin/env python3
"""Persistent API runner daemon - auto-restarts on crash, merges periodically."""
import json
import os
import subprocess
import sys
import time
from datetime import datetime
from pathlib import Path

BASE = Path(__file__).resolve().parent.parent
LOG = BASE / "persistent_runner.log"

def log(msg):
    ts = datetime.now().strftime("%H:%M:%S")
    line = f"[{ts}] {msg}"
    print(line, flush=True)
    with open(LOG, "a", encoding="utf-8") as f:
        f.write(line + "\n")

def count_preds(batch_dir):
    good = empty = total_p = 0
    for f in os.listdir(batch_dir):
        if not f.startswith("pred_") or not f.endswith(".json"):
            continue
        try:
            with open(os.path.join(batch_dir, f), encoding="utf-8") as fh:
                data = json.load(fh)
            if data and len(data) > 0:
                good += 1
                total_p += len(data)
            else:
                empty += 1
        except Exception:
            empty += 1
    return good, empty, total_p

def clean_empty(batch_dir):
    removed = 0
    for f in os.listdir(batch_dir):
        if not f.startswith("pred_") or not f.endswith(".json"):
            continue
        path = os.path.join(batch_dir, f)
        try:
            with open(path, encoding="utf-8") as fh:
                data = json.load(fh)
            if not data or len(data) == 0:
                os.remove(path)
                removed += 1
        except Exception:
            os.remove(path)
            removed += 1
    for f in os.listdir(batch_dir):
        if f.endswith(".raw.txt"):
            os.remove(os.path.join(batch_dir, f))
    return removed

def run_neighbor():
    batch_dir = str(BASE / "output" / "llm_batches_neighbor")
    script = str(BASE / "tools" / "run_neighbor_api.py")
    total_batches = len([f for f in os.listdir(batch_dir) if f.startswith("batch_") and f.endswith(".json")])

    max_restarts = 50
    for restart in range(max_restarts):
        removed = clean_empty(batch_dir)
        good, empty, preds = count_preds(batch_dir)
        remaining = total_batches - good - empty

        log(f"Run {restart+1}: {good} good preds, {preds} predictions, cleaned {removed} empty, ~{remaining} remaining")

        if good >= total_batches * 0.95:
            log(f"95%+ coverage reached ({good}/{total_batches}). Done.")
            break

        try:
            result = subprocess.run(
                [sys.executable, script, "--concurrent", "3"],
                cwd=str(BASE),
                timeout=1800,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
            )
            log(f"Process exited with code {result.returncode}")
            if result.stdout:
                lines = result.stdout.strip().split("\n")
                for line in lines[-5:]:
                    log(f"  stdout: {line}")
        except subprocess.TimeoutExpired:
            log("Timeout after 30min, restarting...")
        except Exception as e:
            log(f"Error: {e}")

        time.sleep(5)

    good, empty, preds = count_preds(batch_dir)
    log(f"Final: {good} good, {empty} empty, {preds} predictions")

def run_deep_retry():
    """Retry deep-class batches that returned empty."""
    batch_dir = str(BASE / "output" / "llm_batches_deep_class")
    script = str(BASE / "tools" / "run_deep_class_api.py")

    removed = clean_empty(batch_dir)
    good, empty, preds = count_preds(batch_dir)
    log(f"Deep retry: cleaned {removed} empty, {good} good, {preds} predictions")

    for restart in range(5):
        removed = clean_empty(batch_dir)
        if removed == 0:
            log("No empty preds to retry. Deep done.")
            break
        log(f"Deep retry {restart+1}: cleaned {removed}, retrying...")
        try:
            subprocess.run(
                [sys.executable, script, "--workers", "2"],
                cwd=str(BASE),
                timeout=600,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
            )
        except Exception as e:
            log(f"Deep error: {e}")
        time.sleep(3)

    good, empty, preds = count_preds(batch_dir)
    log(f"Deep final: {good} good, {empty} empty, {preds} predictions")

if __name__ == "__main__":
    mode = sys.argv[1] if len(sys.argv) > 1 else "neighbor"
    log(f"=== Persistent runner started, mode={mode} ===")
    if mode == "deep":
        run_deep_retry()
    else:
        run_neighbor()
    log("=== Runner finished ===")
