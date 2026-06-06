#!/usr/bin/env python3
"""Build sibling-context batches for LLM naming of remaining hash methods.

For each class with unnamed hash methods AND named siblings, build a prompt
containing the class context (class name, parent, namespace, named methods,
field names) and ask the LLM to predict names for the hash methods.

Unlike mega-batches (which had IDA pseudocode), these rely purely on
structural context: what other methods exist in the same class.
"""
import json
import re
import sys
from collections import defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
DUMP_PATH = BASE / "output" / "deobfuscated_dump.json"
CV_PATH = BASE / "output" / "cross_version_method_names.json"
BATCH_DIR = BASE / "output" / "sibling_batches"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
METHODS_PER_BATCH = 120
MAX_BATCHES = 400


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
        return None, []

    lines = []
    lines.append(f"// Class: {cname}")
    if ns:
        lines.append(f"// Namespace: {ns}")
    if parent and parent not in (".ctor", ""):
        lines.append(f"// Parent: {parent}")
    if fields:
        field_strs = []
        for f in fields[:20]:
            if isinstance(f, str):
                field_strs.append(f)
            elif isinstance(f, dict):
                field_strs.append(f.get("name", str(f)))
        if field_strs:
            lines.append(f"// Fields: {', '.join(field_strs)}")
    if named_methods:
        lines.append(f"// Known methods: {', '.join(named_methods[:30])}")
    lines.append(f"// Hash methods to name:")
    for m, rva in hash_methods:
        rva_info = f" (RVA: {rva})" if rva else ""
        lines.append(f"//   {cname}::{m}{rva_info}")
    lines.append("")

    return "\n".join(lines), [(f"{cname}::{m}", rva) for m, rva in hash_methods]


def main():
    dump = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))

    all_entries = []

    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            cname = cls.get("name", "")
            methods = cls.get("methods", [])

            # Check: does this class have named siblings?
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

            if has_hash and has_named:
                ctx, hashes = build_class_context(cls, cv, ns)
                if ctx and hashes:
                    all_entries.append((ctx, hashes))

    # Sort by number of hash methods (prioritize classes with fewer — easier to infer)
    all_entries.sort(key=lambda x: len(x[1]))

    total_methods = sum(len(h) for _, h in all_entries)
    print(f"Classes with sibling context: {len(all_entries):,}")
    print(f"Total hash methods targetable: {total_methods:,}")

    # Build batches
    BATCH_DIR.mkdir(exist_ok=True)
    batches = []
    current_batch = []
    current_methods = 0

    for ctx, hashes in all_entries:
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
    print(f"Batches: {len(batches)}")
    print(f"Methods in batches: {covered:,}")
    print(f"Remaining (over limit): {total_methods - covered:,}")

    # Write batch files
    system_prompt = """You are analyzing deobfuscated C# classes from VRChat's IL2CPP binary.
Each class below has some methods with known names and some with hash names (m_XXX format).
Based on the class context (name, parent, fields, known methods), predict the most likely
original name for each hash method.

Rules:
- Use standard C# naming: PascalCase for methods, get_/set_ prefix for properties
- Base predictions on class purpose and sibling method names
- If a class has Add/Remove/Clear, hash methods might be Contains, Count, IndexOf, etc.
- If a class has get_X, hash methods might be set_X or other properties
- Only predict names you're confident about. Output "SKIP" for uncertain ones.
- Do NOT use generic names like "Method1", "DoWork", "Process", "Handle"

Output format (JSON object, keys are "ClassName::m_XXX", values are predicted names):
{"ClassName::m_A1F": "get_Position", "ClassName::m_B2C": "SKIP"}
"""

    for i, batch in enumerate(batches):
        prompt_lines = [system_prompt, "=" * 60, ""]
        method_keys = []
        for ctx, hashes in batch:
            prompt_lines.append(ctx)
            method_keys.extend([k for k, _ in hashes])

        prompt_lines.append("=" * 60)
        prompt_lines.append(f"\nPredict names for {len(method_keys)} hash methods above.")
        prompt_lines.append("Output a single JSON object with your predictions.")

        batch_file = BATCH_DIR / f"batch_{i:04d}.txt"
        batch_file.write_text("\n".join(prompt_lines), encoding="utf-8")

        meta_file = BATCH_DIR / f"batch_{i:04d}_keys.json"
        meta_file.write_text(json.dumps(method_keys, indent=2), encoding="utf-8")

    print(f"\nBatch files written to: {BATCH_DIR}")
    print(f"Each batch: ~{METHODS_PER_BATCH} methods")
    print(f"Use with Codex CLI or OpenAI API for naming")


if __name__ == "__main__":
    main()
