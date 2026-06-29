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
]

# Mirror compute_final_stats.is_weak_name so we never re-introduce a weak name.
WEAK_PREFIXES = ("Obf_", "Type", "Struct", "Mono", "Service", "Major", "Static",
                 "DataOnly", "EmptyType", "EmptyStruct", "EmptyClass", "Record",
                 "Unknown", "LargeClass", "Class_")
WEAK_RE = re.compile(r"^(Type|Struct|Mono|Service|Major|Static)\d+[mf]")


def is_weak(n: str) -> bool:
    return bool(WEAK_RE.match(n)) or n.startswith(WEAK_PREFIXES)


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
        for orig, name in data.items():
            if not name or is_weak(name):
                continue  # never apply weak/placeholder names
            merged[orig] = (name, f"field_signature_{src_tag}")
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
                if is_obf(cur) or is_weak(cur) or c.get("semantic_source", "").startswith("field_signature"):
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
