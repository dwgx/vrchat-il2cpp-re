#!/usr/bin/env python3
"""Codex worker: process mega-batches one at a time via codex exec.

Each batch is processed by telling Codex to read the file directly,
rather than piping 130KB+ prompts via stdin.
"""
import argparse
import json
import os
import subprocess
import sys
import time
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
MEGA_DIR = BASE / "output" / "codex_mega_batches"
CODEX_CMD = os.environ.get("CODEX_CMD", r"C:\Users\dwgx1\AppData\Roaming\npm\codex.cmd")


def process_batch(batch_num: int) -> bool:
    """Process a single mega-batch via codex exec. Returns True on success."""
    pred_path = MEGA_DIR / f"pred_{batch_num:04d}.json"
    if pred_path.exists():
        try:
            data = json.loads(pred_path.read_text(encoding="utf-8"))
            if data and len(data) > 0:
                return True
        except Exception:
            pred_path.unlink(missing_ok=True)

    prompt_path = MEGA_DIR / f"mega_{batch_num:04d}.txt"
    keys_path = MEGA_DIR / f"mega_{batch_num:04d}_keys.json"

    if not prompt_path.exists() or not keys_path.exists():
        print(f"  [{batch_num:04d}] SKIP - missing files", flush=True)
        return False

    keys = json.loads(keys_path.read_text(encoding="utf-8"))

    # Short prompt - codex reads the file itself
    codex_prompt = f"""Read the file output/codex_mega_batches/mega_{batch_num:04d}.txt — it contains pseudocode for obfuscated VRChat IL2CPP methods.
Read output/codex_mega_batches/mega_{batch_num:04d}_keys.json for the valid output keys.

Analyze each method's Hex-Rays pseudocode and determine a descriptive C# PascalCase name.

CRITICAL RULES:
- Return ONLY a JSON object: {{"Class::m_XXX": "DescriptiveName"}}
- Evidence-based only: name must be justified by pseudocode content (strings, API calls, patterns)
- Skip uncertain methods — empty {{}} is better than wrong names
- FORBIDDEN generic names: Update, Init, Process, Handle, Execute, Start, Run, Setup, DoWork, Method, Func, Action, Unknown, GetValue, SetValue, GetData, SetData, Helper, Manager, Controller
- FORBIDDEN unless PROVEN by pseudocode: Awake, OnEnable, OnDisable, OnDestroy, ToString, Equals, GetHashCode, MoveNext, Dispose
- Look for: string literals, VRChat/Photon/Udon class refs, field access patterns, delegate calls
- Keys must match exactly from the _keys.json file

Write the JSON result to output/codex_mega_batches/pred_{batch_num:04d}.json"""

    try:
        result = subprocess.run(
            [
                CODEX_CMD, "exec",
                "--skip-git-repo-check",
                "--dangerously-bypass-approvals-and-sandbox",
                "-C", str(BASE),
                "--config", 'model_reasoning_effort="high"',
            ],
            input=codex_prompt,
            capture_output=True,
            text=True,
            encoding="utf-8",
            errors="replace",
            timeout=900,
        )

        # Check if codex wrote the file directly (preferred path)
        if pred_path.exists():
            try:
                data = json.loads(pred_path.read_text(encoding="utf-8"))
                if isinstance(data, dict):
                    valid = {k: v for k, v in data.items() if k in keys and isinstance(v, str) and len(v) > 1}
                    if valid != data:
                        tmp = pred_path.with_suffix(".tmp")
                        tmp.write_text(json.dumps(valid, indent=2, ensure_ascii=False), encoding="utf-8")
                        tmp.replace(pred_path)
                    print(f"  [{batch_num:04d}] OK {len(valid)} predictions (file written by codex)", flush=True)
                    return len(valid) > 0
            except Exception:
                pass

        if result.returncode != 0:
            print(f"  [{batch_num:04d}] ERROR exit={result.returncode}", flush=True)
            if result.stderr:
                for line in result.stderr.strip().split("\n")[-3:]:
                    print(f"    stderr: {line}", flush=True)
            return False

        # Fallback: parse from stdout
        stdout = result.stdout.strip()
        if not stdout:
            print(f"  [{batch_num:04d}] ERROR empty output, no file written", flush=True)
            return False

        json_text = stdout
        if "```json" in json_text:
            json_text = json_text.split("```json", 1)[1]
            json_text = json_text.split("```", 1)[0]
        elif "```" in json_text:
            json_text = json_text.split("```", 1)[1]
            json_text = json_text.split("```", 1)[0]

        json_text = json_text.strip()
        start = json_text.find("{")
        end = json_text.rfind("}")
        if start == -1 or end == -1:
            print(f"  [{batch_num:04d}] ERROR no JSON in output", flush=True)
            return False

        json_text = json_text[start:end + 1]
        predictions = json.loads(json_text)

        if not isinstance(predictions, dict):
            print(f"  [{batch_num:04d}] ERROR not a dict", flush=True)
            return False

        valid = {k: v for k, v in predictions.items() if k in keys and isinstance(v, str) and len(v) > 1}

        tmp = pred_path.with_suffix(".tmp")
        tmp.write_text(json.dumps(valid, indent=2, ensure_ascii=False), encoding="utf-8")
        tmp.replace(pred_path)

        print(f"  [{batch_num:04d}] OK {len(valid)} predictions (from stdout)", flush=True)
        return True

    except subprocess.TimeoutExpired:
        # Codex may have written the file before subprocess timed out
        if pred_path.exists():
            try:
                data = json.loads(pred_path.read_text(encoding="utf-8"))
                if isinstance(data, dict) and len(data) > 0:
                    valid = {k: v for k, v in data.items() if k in keys and isinstance(v, str) and len(v) > 1}
                    if valid != data:
                        tmp = pred_path.with_suffix(".tmp")
                        tmp.write_text(json.dumps(valid, indent=2, ensure_ascii=False), encoding="utf-8")
                        tmp.replace(pred_path)
                    print(f"  [{batch_num:04d}] OK {len(valid)} predictions (timeout but file exists)", flush=True)
                    return len(valid) > 0
            except Exception:
                pass
        print(f"  [{batch_num:04d}] TIMEOUT", flush=True)
        return False
    except json.JSONDecodeError as e:
        print(f"  [{batch_num:04d}] JSON parse error: {e}", flush=True)
        return False
    except Exception as e:
        print(f"  [{batch_num:04d}] ERROR: {e}", flush=True)
        return False


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--start", type=int, required=True)
    parser.add_argument("--end", type=int, required=True)
    parser.add_argument("--worker", type=int, default=0)
    args = parser.parse_args()

    total = args.end - args.start
    success = 0
    failed = 0

    print(f"Worker {args.worker}: batches {args.start:04d}-{args.end - 1:04d} ({total} batches)", flush=True)

    for i in range(args.start, args.end):
        if process_batch(i):
            success += 1
        else:
            failed += 1

        if (success + failed) % 10 == 0:
            print(f"  Worker {args.worker} progress: {success + failed}/{total} done, {success} ok, {failed} failed", flush=True)

    print(f"Worker {args.worker} DONE: {success}/{total} succeeded, {failed} failed", flush=True)


if __name__ == "__main__":
    main()
