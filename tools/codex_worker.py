#!/usr/bin/env python3
"""Codex worker: process batches one at a time via codex exec.

Supports two modes:
  --mode mega    (default) process codex_mega_batches/ (pseudocode-based)
  --mode sibling           process sibling_batches/ (context-based)

Usage:
  python codex_worker.py --mode sibling --start 0 --end 120 --worker 0
  python codex_worker.py --mode sibling --start 120 --end 240 --worker 1
  python codex_worker.py --mode sibling --start 240 --end 359 --worker 2
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
CODEX_CMD = os.environ.get("CODEX_CMD", r"C:\Users\dwgx1\AppData\Roaming\npm\codex.cmd")

MODE_CONFIG = {
    "mega": {
        "batch_dir": BASE / "output" / "codex_mega_batches",
        "prompt_prefix": "mega",
        "keys_prefix": "mega",
        "pred_prefix": "pred",
        "timeout": 900,
    },
    "sibling": {
        "batch_dir": BASE / "output" / "sibling_batches",
        "prompt_prefix": "batch",
        "keys_prefix": "batch",
        "keys_suffix": "_keys",
        "pred_dir": BASE / "output" / "sibling_preds",
        "pred_prefix": "pred",
        "timeout": 300,
    },
}


def build_prompt(mode: str, batch_num: int, cfg: dict) -> str:
    batch_dir_rel = cfg["batch_dir"].relative_to(BASE)
    prompt_file = f"{cfg['prompt_prefix']}_{batch_num:04d}.txt"
    keys_file = f"{cfg['keys_prefix']}_{batch_num:04d}{cfg.get('keys_suffix', '')}.json"

    if mode == "mega":
        return f"""Read the file {batch_dir_rel}/{prompt_file} — it contains pseudocode for obfuscated VRChat IL2CPP methods.
Read {batch_dir_rel}/{keys_file} for the valid output keys.

Analyze each method's Hex-Rays pseudocode and determine a descriptive C# PascalCase name.

CRITICAL RULES:
- Return ONLY a JSON object: {{"Class::m_XXX": "DescriptiveName"}}
- Evidence-based only: name must be justified by pseudocode content (strings, API calls, patterns)
- Skip uncertain methods — empty {{}} is better than wrong names
- FORBIDDEN generic names: Update, Init, Process, Handle, Execute, Start, Run, Setup, DoWork, Method, Func, Action, Unknown, GetValue, SetValue, GetData, SetData, Helper, Manager, Controller
- FORBIDDEN unless PROVEN by pseudocode: Awake, OnEnable, OnDisable, OnDestroy, ToString, Equals, GetHashCode, MoveNext, Dispose
- Look for: string literals, VRChat/Photon/Udon class refs, field access patterns, delegate calls
- Keys must match exactly from the _keys.json file

Write the JSON result to {batch_dir_rel}/pred_{batch_num:04d}.json"""

    else:  # sibling
        pred_dir_rel = cfg["pred_dir"].relative_to(BASE)
        return f"""Read the file {batch_dir_rel}/{prompt_file} carefully. It contains full instructions and C# class data for VRChat IL2CPP reverse engineering.
Read {batch_dir_rel}/{keys_file} for the valid output keys.

Follow the instructions in the file exactly. You MUST predict a name for EVERY method — no SKIP, no empty entries.
Use pattern completion, class context, C# conventions, and VRChat domain knowledge.
Output keys must match the _keys.json file.

Write the JSON result to {pred_dir_rel}/pred_{batch_num:04d}.json

Write the JSON result to {pred_dir_rel}/pred_{batch_num:04d}.json"""


def process_batch(batch_num: int, mode: str, cfg: dict) -> bool:
    pred_dir = cfg.get("pred_dir", cfg["batch_dir"])
    pred_path = pred_dir / f"pred_{batch_num:04d}.json"

    if pred_path.exists():
        try:
            data = json.loads(pred_path.read_text(encoding="utf-8"))
            if data and len(data) > 0:
                return True
        except Exception:
            pred_path.unlink(missing_ok=True)

    prompt_file = cfg["batch_dir"] / f"{cfg['prompt_prefix']}_{batch_num:04d}.txt"
    keys_suffix = cfg.get("keys_suffix", "")
    keys_file = cfg["batch_dir"] / f"{cfg['keys_prefix']}_{batch_num:04d}{keys_suffix}.json"

    if not prompt_file.exists() or not keys_file.exists():
        print(f"  [{batch_num:04d}] SKIP - missing files", flush=True)
        return False

    keys_data = json.loads(keys_file.read_text(encoding="utf-8"))
    if isinstance(keys_data, list):
        keys = set(keys_data)
    elif isinstance(keys_data, dict):
        keys = set(keys_data.keys())
    else:
        keys = set()

    codex_prompt = build_prompt(mode, batch_num, cfg)

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
            timeout=cfg["timeout"],
        )

        if pred_path.exists():
            try:
                raw = pred_path.read_bytes()
                if raw[:3] == b'\xef\xbb\xbf':
                    raw = raw[3:]
                data = json.loads(raw.decode("utf-8"))
                if isinstance(data, dict):
                    valid = {k: v for k, v in data.items()
                             if k in keys and isinstance(v, str) and len(v) > 1
                             }
                    if valid != data:
                        tmp = pred_path.with_suffix(".tmp")
                        tmp.write_text(json.dumps(valid, indent=2, ensure_ascii=False), encoding="utf-8")
                        tmp.replace(pred_path)
                    print(f"  [{batch_num:04d}] OK {len(valid)} predictions (file)", flush=True)
                    return len(valid) > 0
            except Exception:
                pass

        if result.returncode != 0:
            print(f"  [{batch_num:04d}] ERROR exit={result.returncode}", flush=True)
            if result.stderr:
                for line in result.stderr.strip().split("\n")[-3:]:
                    print(f"    stderr: {line}", flush=True)
            return False

        stdout = result.stdout.strip()
        if not stdout:
            print(f"  [{batch_num:04d}] ERROR empty output", flush=True)
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
            print(f"  [{batch_num:04d}] ERROR no JSON", flush=True)
            return False

        predictions = json.loads(json_text[start:end + 1])
        if not isinstance(predictions, dict):
            print(f"  [{batch_num:04d}] ERROR not a dict", flush=True)
            return False

        valid = {k: v for k, v in predictions.items()
                 if k in keys and isinstance(v, str) and len(v) > 1
                 }

        pred_dir.mkdir(parents=True, exist_ok=True)
        tmp = pred_path.with_suffix(".tmp")
        tmp.write_text(json.dumps(valid, indent=2, ensure_ascii=False), encoding="utf-8")
        tmp.replace(pred_path)

        print(f"  [{batch_num:04d}] OK {len(valid)} predictions (stdout)", flush=True)
        return True

    except subprocess.TimeoutExpired:
        if pred_path.exists():
            try:
                raw = pred_path.read_bytes()
                if raw[:3] == b'\xef\xbb\xbf':
                    raw = raw[3:]
                data = json.loads(raw.decode("utf-8"))
                if isinstance(data, dict) and len(data) > 0:
                    valid = {k: v for k, v in data.items()
                             if k in keys and isinstance(v, str) and len(v) > 1
                             }
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
    parser.add_argument("--mode", choices=["mega", "sibling"], default="mega")
    parser.add_argument("--start", type=int, required=True)
    parser.add_argument("--end", type=int, required=True)
    parser.add_argument("--worker", type=int, default=0)
    args = parser.parse_args()

    cfg = MODE_CONFIG[args.mode]
    if "pred_dir" in cfg:
        cfg["pred_dir"].mkdir(parents=True, exist_ok=True)

    total = args.end - args.start
    success = 0
    failed = 0

    print(f"Worker {args.worker} [{args.mode}]: batches {args.start:04d}-{args.end - 1:04d} ({total} batches)", flush=True)

    for i in range(args.start, args.end):
        if process_batch(i, args.mode, cfg):
            success += 1
        else:
            failed += 1

        if (success + failed) % 10 == 0:
            print(f"  Worker {args.worker} progress: {success + failed}/{total}, {success} ok, {failed} fail", flush=True)

    print(f"Worker {args.worker} DONE: {success}/{total} ok, {failed} fail", flush=True)


if __name__ == "__main__":
    main()
