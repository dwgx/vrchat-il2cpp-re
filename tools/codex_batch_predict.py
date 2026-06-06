#!/usr/bin/env python3
"""Prepare mega-batches for Codex processing.

Instead of calling an external API per batch, this merges many small batches
into large prompt files that Codex can process in one call.
Each mega-batch targets ~100 methods with their pseudocode.
"""
import json
import os
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
BATCH_DIR = BASE / "output" / "llm_batches_hexrays_r2"
MEGA_DIR = BASE / "output" / "codex_mega_batches"
CV_PATH = BASE / "output" / "cross_version_method_names.json"

METHODS_PER_MEGA = 80
MAX_PSEUDO_CHARS = 2000


def main():
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))
    already_named = set(cv.keys())

    batches = sorted(BATCH_DIR.glob("batch_*.json"))

    # Collect all unprocessed targets
    all_targets = []
    for bf in batches:
        batch = json.loads(bf.read_text(encoding="utf-8"))
        cls = batch["class"]
        named = batch.get("named_methods", [])[:15]
        parent = batch.get("parent", "")

        for t in batch["targets"]:
            key = t["key"]
            if key in already_named:
                continue
            # check if already predicted
            suffix = bf.stem.split("_")[-1]
            pred_file = BATCH_DIR / f"pred_{suffix}.json"
            if pred_file.exists():
                try:
                    existing = json.loads(pred_file.read_text(encoding="utf-8"))
                    if key in existing:
                        continue
                except Exception:
                    pass

            all_targets.append({
                "key": key,
                "class": cls,
                "parent": parent,
                "method": t["method"],
                "pseudocode": t["pseudocode"][:MAX_PSEUDO_CHARS],
                "named_methods": named,
            })

    print(f"Total unprocessed targets: {len(all_targets)}")

    MEGA_DIR.mkdir(parents=True, exist_ok=True)
    for old in MEGA_DIR.glob("mega_*.txt"):
        old.unlink()
    for old in MEGA_DIR.glob("mega_*.json"):
        old.unlink()

    mega_idx = 0
    for i in range(0, len(all_targets), METHODS_PER_MEGA):
        chunk = all_targets[i:i + METHODS_PER_MEGA]

        # Build prompt
        lines = [
            "Name these obfuscated IL2CPP methods from VRChat using the Hex-Rays pseudocode below.",
            "Return ONLY a JSON object mapping \"Class::m_XXX\" to \"PascalCaseName\".",
            "Rules: PascalCase, C# style, specific names (not generic like Update/Init/Process).",
            "Only include confident predictions. Omit uncertain ones.",
            "",
        ]

        keys_list = []
        for t in chunk:
            lines.append(f"===== {t['key']} =====")
            lines.append(f"Class: {t['class']} (parent: {t['parent']})")
            if t['named_methods']:
                lines.append(f"Known siblings: {', '.join(t['named_methods'][:10])}")
            lines.append(t['pseudocode'])
            lines.append("")
            keys_list.append(t['key'])

        lines.append("Valid output keys (use exactly these):")
        lines.append(json.dumps(keys_list))

        prompt_text = "\n".join(lines)

        # Save prompt file
        prompt_path = MEGA_DIR / f"mega_{mega_idx:04d}.txt"
        prompt_path.write_text(prompt_text, encoding="utf-8")

        # Save keys manifest
        manifest_path = MEGA_DIR / f"mega_{mega_idx:04d}_keys.json"
        manifest_path.write_text(json.dumps(keys_list, indent=1), encoding="utf-8")

        mega_idx += 1

    print(f"Mega-batches created: {mega_idx}")
    print(f"Methods per mega-batch: ~{METHODS_PER_MEGA}")
    print(f"Output: {MEGA_DIR}")
    print(f"")
    print(f"To process with Codex:")
    print(f"  codex exec --skip-git-repo-check --full-auto \\")
    print(f'    "Read output/codex_mega_batches/mega_0000.txt and follow its instructions. Return ONLY the JSON object."')


if __name__ == "__main__":
    main()
