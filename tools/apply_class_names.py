#!/usr/bin/env python
"""Re-apply field-signature class names onto the deobfuscated dump.

Why this exists: the workflow/A1 class names (output/workflow_class_names.json
and output/a1_class_names.json) are NOT part of run_full_pipeline's stages.
They were hand-patched into output/deobfuscated_dump.json, so a pipeline rerun
(stage 1/2 regenerates the dump) silently drops all of them. This script makes
that application reproducible and idempotent: run it after the pipeline and the
names come back, keyed by original (obfuscated) name.

Idempotent: running twice produces the same dump. Safe to re-run any time.

Usage:
  python tools/apply_class_names.py            # apply, print coverage delta
  python tools/apply_class_names.py --check     # dry-run: report only, no write
"""
import argparse
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / "output" / "deobfuscated_dump.json"
SOURCES = [
    ("workflow", BASE / "output" / "workflow_class_names.json"),
    ("a1", BASE / "output" / "a1_class_names.json"),
    ("synth", BASE / "output" / "synthesized_names.json"),
    ("callgraph", BASE / "output" / "callgraph_class_names.json"),
    ("field_type", BASE / "output" / "field_type_class_names.json"),
    ("method_return", BASE / "output" / "method_return_class_names.json"),
    ("method_param", BASE / "output" / "method_param_class_names.json"),
    ("combined_type", BASE / "output" / "combined_type_class_names.json"),
    ("interface", BASE / "output" / "interface_class_names.json"),
    ("string_literal", BASE / "output" / "string_literal_class_names.json"),
    ("call_target", BASE / "output" / "calltarget_class_names.json"),
    ("field_compose", BASE / "output" / "fieldcompose_class_names.json"),
    ("decompile_callee", BASE / "output" / "decompile_class_names.json"),
]

# semantic_source tag per source. Field-signature sources share one tag for
# continuity; callgraph names are behaviour-inferred and get a distinct, honest
# tag so they're never mistaken for recovered field-signature names.
SRC_TAG = {
    "workflow": "field_signature_workflow",
    "a1": "field_signature_a1",
    "synth": "field_signature_synth",
    "callgraph": "callgraph_inferred",
    "field_type": "field_type_signature",
    "method_return": "method_return_type_signature",
    "method_param": "method_param_type_signature",
    "combined_type": "combined_type_signature",
    "interface": "interface_signature",
    "string_literal": "string_literal_disasm",
    "call_target": "call_target_disasm",
    "field_compose": "field_composition",
    "decompile_callee": "decompile_callee_inference",
}

# Canonical weak/placeholder criterion, shared with the pipeline and stats tool
# so all four call sites can never drift (the drift that inflated coverage once).
sys.path.insert(0, str(Path(__file__).resolve().parent))
from name_quality import is_weak_name as is_weak


def is_weak_placeholder(n: str) -> bool:
    return is_weak(n)


def is_obf(name: str) -> bool:
    """Beebyte-obfuscated names use U+00CC..U+00CF."""
    return bool(name) and any(c in "ÌÍÎÏ" for c in name)


def load_sources():
    """Merge all name sources into one original_name -> (semantic_name, src) map.
    Later sources (a1) override earlier (workflow) on conflict; a1 is the more
    recent, higher-signal pass."""
    merged = {}
    for src_tag, path in SOURCES:
        if not path.exists():
            print(f"  WARN: source missing: {path.name}")
            continue
        data = json.load(open(path, encoding="utf-8"))
        kept = 0
        for orig, val in data.items():
            # value is either a bare name string or a {"name": ...} record
            name = val.get("name") if isinstance(val, dict) else val
            if not name or is_weak(name):
                continue  # never apply weak/placeholder names
            merged[orig] = (name, SRC_TAG[src_tag])
            kept += 1
        print(f"  source {path.name}: {kept} valid names")
    return merged


def main():
    ap = argparse.ArgumentParser(description="Re-apply field-signature class names (idempotent)")
    ap.add_argument("--check", action="store_true", help="dry-run, report only")
    args = ap.parse_args()

    if not DUMP.exists():
        print(f"  ERROR: {DUMP} not found. Run the pipeline first.")
        return 1

    name_map = load_sources()
    print(f"  merged: {len(name_map)} unique original->name mappings")

    dump = json.load(open(DUMP, encoding="utf-8"))
    applied = 0
    skipped_clean = 0  # already had a non-obf name (don't clobber pipeline names)
    not_found = set(name_map.keys())

    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            orig = c.get("original_name", "")
            if orig in name_map:
                not_found.discard(orig)
                new_name, src = name_map[orig]
                cur = c.get("name", "")
                # Only apply where the current name is still obfuscated/weak.
                # If the pipeline already gave it a good name, keep that.
                if is_obf(cur) or is_weak(cur) or c.get("semantic_source", "").startswith(("field_signature", "callgraph")):
                    if cur != new_name or c.get("semantic_source") != src:
                        c["name"] = new_name
                        c["semantic_source"] = src
                        applied += 1
                else:
                    skipped_clean += 1

    print(f"  applied/refreshed: {applied}")
    print(f"  skipped (pipeline already named): {skipped_clean}")
    if not_found:
        print(f"  source names not matched in dump: {len(not_found)} "
              f"(classes may not exist in this dump build)")

    if args.check:
        print("  [--check] dry-run, no write")
        return 0

    json.dump(dump, open(DUMP, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(f"  wrote {DUMP.name}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
