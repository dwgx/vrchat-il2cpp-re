#!/usr/bin/env python3
"""Check Codex worker progress."""
import json
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

MEGA_DIR = Path(__file__).resolve().parent.parent / "output" / "codex_mega_batches"

total_batches = len(list(MEGA_DIR.glob("mega_*_keys.json")))
pred_files = list(MEGA_DIR.glob("pred_*.json"))

good = 0
empty = 0
total_preds = 0

for pf in sorted(pred_files):
    try:
        data = json.loads(pf.read_text(encoding="utf-8"))
        if data and len(data) > 0:
            good += 1
            total_preds += len(data)
        else:
            empty += 1
    except Exception:
        empty += 1

print(f"Mega-batches: {total_batches}")
print(f"Completed:    {good} ({good*100/total_batches:.1f}%)")
print(f"Empty/bad:    {empty}")
print(f"Remaining:    {total_batches - good - empty}")
print(f"Predictions:  {total_preds}")
print()

# Check worker logs
for i in range(1, 5):
    log = MEGA_DIR / f"worker{i}.log"
    if log.exists():
        lines = log.read_text(encoding="utf-8", errors="replace").strip().split("\n")
        last = lines[-1] if lines else "(empty)"
        print(f"Worker {i}: {last}")
    else:
        print(f"Worker {i}: no log")
