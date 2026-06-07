#!/usr/bin/env python3
"""Build audit batches for Codex to review sibling-context naming quality.

For each sibling pred file, combine the original class context with the
predicted names so a reviewer can judge whether the predictions make sense.

Output: output/audit_batches/batch_XXXX.json + audit_XXXX_keys.json
"""
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
SIBLING_BATCH_DIR = BASE / "output" / "sibling_batches"
SIBLING_PRED_DIR = BASE / "output" / "sibling_preds"
NEIGHBOR_BATCH_DIR = BASE / "output" / "llm_batches_neighbor"
CV_PATH = BASE / "output" / "cross_version_method_names.json"
AUDIT_DIR = BASE / "output" / "audit_batches"
DUMP_PATH = BASE / "output" / "deobfuscated_dump.json"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
CLASSES_PER_BATCH = 30


def load_class_index(dump):
    """Build class_name -> {methods, fields, parent, namespace} index."""
    index = {}
    for ns, classes in dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for c in classes:
            name = c.get("name", "")
            if not name:
                continue
            methods = c.get("methods", [])
            method_names = []
            for m in methods:
                if isinstance(m, str):
                    method_names.append(m)
                elif isinstance(m, dict):
                    method_names.append(m.get("name", ""))
            fields = c.get("fields", [])
            field_names = []
            for f in fields:
                if isinstance(f, str):
                    field_names.append(f)
                elif isinstance(f, dict):
                    field_names.append(f.get("name", ""))
            index[name] = {
                "namespace": ns,
                "parent": c.get("parent", c.get("parent_name", "")),
                "methods": method_names,
                "fields": field_names,
            }
    return index


def main():
    print("[+] Loading cross_version_method_names.json...")
    cv = json.loads(CV_PATH.read_text(encoding="utf-8"))
    print(f"    {len(cv)} entries")

    print("[+] Loading deobfuscated_dump.json...")
    dump = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    class_index = load_class_index(dump)
    print(f"    {len(class_index)} classes indexed")

    # Collect all sibling-context predictions grouped by class
    print("[+] Collecting sibling predictions...")
    class_preds = {}
    for pred_file in sorted(SIBLING_PRED_DIR.glob("pred_*.json")):
        try:
            preds = json.loads(pred_file.read_text(encoding="utf-8"))
        except Exception:
            continue
        if not isinstance(preds, dict):
            continue
        for key, name in preds.items():
            if "::" not in key:
                continue
            cls, method = key.split("::", 1)
            if cls not in class_preds:
                class_preds[cls] = {}
            class_preds[cls][method] = name

    # Also collect neighbor predictions
    for pred_file in sorted(NEIGHBOR_BATCH_DIR.glob("pred_*.json")):
        try:
            preds = json.loads(pred_file.read_text(encoding="utf-8"))
        except Exception:
            continue
        if not isinstance(preds, dict):
            continue
        # neighbor preds use bare hash keys (m_XXX), need to find the class
        batch_num = pred_file.stem.replace("pred_", "")
        batch_file = NEIGHBOR_BATCH_DIR / f"batch_{batch_num}.json"
        if not batch_file.exists():
            continue
        try:
            batch = json.loads(batch_file.read_text(encoding="utf-8"))
            cls_name = batch.get("class", "")
        except Exception:
            continue
        if not cls_name:
            continue
        for method, name in preds.items():
            if cls_name not in class_preds:
                class_preds[cls_name] = {}
            class_preds[cls_name][method] = name

    print(f"    {len(class_preds)} classes with predictions")
    total_preds = sum(len(v) for v in class_preds.values())
    print(f"    {total_preds} total predictions to audit")

    # Build audit entries
    audit_entries = []
    for cls_name, preds in sorted(class_preds.items()):
        if len(preds) == 0:
            continue
        info = class_index.get(cls_name, {})
        named_methods = [m for m in info.get("methods", []) if not HASH_RE.match(m)]
        hash_methods = [m for m in info.get("methods", []) if HASH_RE.match(m)]

        entry = {
            "class": cls_name,
            "namespace": info.get("namespace", ""),
            "parent": info.get("parent", ""),
            "named_methods": named_methods[:25],
            "fields": info.get("fields", [])[:15],
            "predictions_to_review": preds,
        }
        audit_entries.append(entry)

    audit_entries.sort(key=lambda e: -len(e["predictions_to_review"]))

    # Write batches
    AUDIT_DIR.mkdir(parents=True, exist_ok=True)
    for old in AUDIT_DIR.glob("batch_*.json"):
        old.unlink()
    for old in AUDIT_DIR.glob("audit_*.json"):
        old.unlink()

    batch_id = 0
    i = 0
    while i < len(audit_entries):
        chunk = audit_entries[i:i + CLASSES_PER_BATCH]
        batch_path = AUDIT_DIR / f"batch_{batch_id:04d}.json"
        batch_path.write_text(
            json.dumps(chunk, indent=1, ensure_ascii=False),
            encoding="utf-8",
        )
        batch_id += 1
        i += CLASSES_PER_BATCH

    print(f"\n[+] Created {batch_id} audit batches in {AUDIT_DIR}")
    print(f"    {len(audit_entries)} classes, {total_preds} predictions")
    print(f"    ~{CLASSES_PER_BATCH} classes per batch")


if __name__ == "__main__":
    main()
