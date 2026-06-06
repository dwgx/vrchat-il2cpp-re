#!/usr/bin/env python3
"""Build sibling-context batches for LLM naming of remaining hash methods.

For each class with unnamed hash methods AND named siblings, build a prompt
containing the class context (class name, parent, namespace, named methods,
field names) and ask the LLM to predict names for the hash methods.

Unlike mega-batches (which had IDA pseudocode), these rely purely on
structural context: what other methods exist in the same class.

v2: improved sorting (context richness score), VRChat domain hints,
    skip compiler-generated classes with no real context.
"""
import json
import re
import shutil
import sys
from collections import defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE / "output" / "deobfuscated_dump.json"
CV_PATH = BASE / "output" / "cross_version_method_names.json"
BATCH_DIR = BASE / "output" / "sibling_batches"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
METHODS_PER_BATCH = 100
MAX_BATCHES = 500

# Methods that give zero naming signal
USELESS_SIBLINGS = {
    "Initialize", "GetHashCode", "Equals", "MoveNext", "Dispose",
    "SetStateMachine", "get_Current", "Reset", ".ctor", ".cctor",
    "Finalize", "MemberwiseClone", "GetType", "ToString",
}


def context_score(named_methods, fields, parent, ns):
    """Score how useful a class's context is for naming. Higher = more informative."""
    score = 0
    useful = [m for m in named_methods if m not in USELESS_SIBLINGS]
    score += len(useful) * 3
    score += len(fields) * 2
    if ns:
        score += 2
    if parent and parent not in ("", ".ctor"):
        score += 2
    for m in useful:
        if any(kw in m.lower() for kw in ("avatar", "player", "network", "world",
               "udon", "photon", "sync", "event", "ui", "audio", "input",
               "camera", "shader", "anim", "physic", "collid")):
            score += 5
    return score


def build_class_context(cls, cv, ns):
    """Build context string for a class."""
    cname = cls.get("name", "")
    parent = cls.get("parent", "")
    methods = cls.get("methods", [])
    fields = cls.get("fields", [])
    pointers = cls.get("method_pointers", {})

    named_methods = []
    hash_methods = []

    for m in methods:
        if not isinstance(m, str):
            continue
        key = f"{cname}::{m}"
        if HASH_RE.match(m) and key not in cv:
            rva = pointers.get(m, "")
            hash_methods.append((m, rva))
        elif not m.startswith((".ctor", ".cctor")):
            resolved = cv.get(key, m)
            named_methods.append(resolved)

    if not hash_methods:
        return None, [], 0

    useful_siblings = [m for m in named_methods if m not in USELESS_SIBLINGS]
    if not useful_siblings and not fields and not ns:
        return None, [], 0

    score = context_score(named_methods, fields, parent, ns)

    lines = []
    lines.append(f"// Class: {cname}")
    if ns:
        lines.append(f"// Namespace: {ns}")
    if parent and parent not in (".ctor", ""):
        lines.append(f"// Parent: {parent}")
    if fields:
        field_strs = []
        for f in fields[:25]:
            if isinstance(f, str):
                field_strs.append(f)
            elif isinstance(f, dict):
                field_strs.append(f.get("name", str(f)))
        if field_strs:
            lines.append(f"// Fields: {', '.join(field_strs)}")
    if named_methods:
        lines.append(f"// Known methods ({len(named_methods)}): {', '.join(named_methods[:40])}")
    lines.append(f"// Unnamed methods ({len(hash_methods)}):")
    for m, rva in hash_methods:
        lines.append(f"//   {cname}::{m}")
    lines.append("")

    return "\n".join(lines), [(f"{cname}::{m}", rva) for m, rva in hash_methods], score


SYSTEM_PROMPT = """You are a C# reverse engineer naming obfuscated methods in VRChat's IL2CPP binary.

Each class below has known method names and unnamed hash methods (m_XXX). Predict names for the hash methods based on the class context. You MUST predict a name for every method — do NOT output "SKIP".

## How to predict
1. **Pattern completion**: If a class has `get_X`, a hash method is likely `set_X`. If it has `Add`, expect `Remove`, `Contains`, `Clear`, `get_Count`.
2. **Class purpose**: A class named `AudioManager` with `PlaySound` likely has `StopSound`, `SetVolume`, `get_IsPlaying`.
3. **C# interface methods**: Classes with `MoveNext`+`get_Current` implement IEnumerator — hash methods are `Reset`, `Dispose`, `System.Collections.IEnumerator.get_Current`.
4. **Unity lifecycle**: MonoBehaviour classes need `Awake`, `Start`, `Update`, `OnEnable`, `OnDisable`, `OnDestroy`, `OnApplicationQuit`.
5. **Property pairs**: For every `get_X` there is usually a `set_X` and vice versa.
6. **Event patterns**: `add_EventName` / `remove_EventName` pairs.
7. **VRChat domain**: Photon networking (OnJoinedRoom, OnPlayerJoined), Avatar (SetParameter, GetBlendshape), UI (Show, Hide, SetText), Udon (SendCustomEvent).
8. **Delegate/callback**: Methods near event/delegate fields are often handlers: `OnXChanged`, `HandleY`.
9. **Count-based**: If a class has N hash methods and N matches a known interface method count, map them all.

## Naming rules
- PascalCase for methods: `GetPlayerName`
- Property accessors: `get_PropertyName` / `set_PropertyName`
- Explicit interface: `System.Collections.IEnumerable.GetEnumerator`
- FORBIDDEN: `Method1`, `Unknown`, `DoSomething`, `HandleIt`, or any name that conveys zero meaning

## Output
JSON object mapping every hash method to a predicted name. Predict ALL methods — no SKIP.
```json
{"PlayerAvatar::m_A1F": "GetBlendshapeWeight", "PlayerAvatar::m_B2C": "set_IsVisible"}
```
"""


def main():
    dump = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))

    all_entries = []
    skipped_no_context = 0

    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            cname = cls.get("name", "")
            methods = cls.get("methods", [])

            has_named = False
            has_hash = False
            for m in methods:
                if not isinstance(m, str):
                    continue
                key = f"{cname}::{m}"
                if HASH_RE.match(m) and key not in cv:
                    has_hash = True
                elif not m.startswith((".ctor", ".cctor")):
                    has_named = True

            if not has_hash:
                continue

            ctx, hashes, score = build_class_context(cls, cv, ns)
            if ctx and hashes:
                all_entries.append((ctx, hashes, score))
            else:
                skipped_no_context += 1

    # Sort by context score DESCENDING — richest context first = highest quality predictions
    all_entries.sort(key=lambda x: x[2], reverse=True)

    total_methods = sum(len(h) for _, h, _ in all_entries)
    print(f"Classes with useful context: {len(all_entries):,}")
    print(f"Skipped (no useful context): {skipped_no_context:,}")
    print(f"Total hash methods targetable: {total_methods:,}")
    print(f"Top-5 context scores: {[s for _, _, s in all_entries[:5]]}")
    print(f"Bottom-5 context scores: {[s for _, _, s in all_entries[-5:]]}")

    # Clean old batches
    if BATCH_DIR.exists():
        for f in BATCH_DIR.glob("batch_*"):
            f.unlink()
        for f in BATCH_DIR.glob("pred_*"):
            f.unlink()
    BATCH_DIR.mkdir(exist_ok=True)

    # Build batches
    batches = []
    current_batch = []
    current_methods = 0

    for ctx, hashes, score in all_entries:
        current_batch.append((ctx, hashes))
        current_methods += len(hashes)
        if current_methods >= METHODS_PER_BATCH:
            batches.append(current_batch)
            current_batch = []
            current_methods = 0
            if len(batches) >= MAX_BATCHES:
                break

    if current_batch and len(batches) < MAX_BATCHES:
        batches.append(current_batch)

    covered = sum(sum(len(h) for _, h in b) for b in batches)
    remainder = total_methods - covered
    print(f"\nBatches: {len(batches)}")
    print(f"Methods in batches: {covered:,}")
    if remainder > 0:
        print(f"Over limit (not batched): {remainder:,}")

    # Write batch files
    for i, batch in enumerate(batches):
        prompt_lines = [SYSTEM_PROMPT, "=" * 60, ""]
        method_keys = []
        for ctx, hashes in batch:
            prompt_lines.append(ctx)
            method_keys.extend([k for k, _ in hashes])

        prompt_lines.append("=" * 60)
        prompt_lines.append(f"\nPredict names for the {len(method_keys)} unnamed methods above.")
        prompt_lines.append("Output a single JSON object. Use SKIP for any method you cannot confidently name.")

        batch_file = BATCH_DIR / f"batch_{i:04d}.txt"
        batch_file.write_text("\n".join(prompt_lines), encoding="utf-8")

        meta_file = BATCH_DIR / f"batch_{i:04d}_keys.json"
        meta_file.write_text(json.dumps(method_keys, indent=2), encoding="utf-8")

    print(f"\nBatch files written to: {BATCH_DIR}")
    print(f"Methods per batch: ~{METHODS_PER_BATCH}")


if __name__ == "__main__":
    main()
