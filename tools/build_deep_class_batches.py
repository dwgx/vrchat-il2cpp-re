#!/usr/bin/env python3
"""Build deep per-class LLM batches for hash-heavy classes."""
import json
import re
import sys
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
DEOBF_PATH = BASE / "output/deobfuscated_dump.json"
HEXRAYS_PATH = BASE / "output/v_new_ida/hexrays_mass_export.json"
OUT_DIR = BASE / "output/llm_batches_deep_class"

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
TOP_CLASSES = 100
MAX_PSEUDO_PER_BATCH = 25


def load_json(path: Path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def unique_ordered(values):
    seen = set()
    out = []
    for value in values:
        if value not in seen:
            seen.add(value)
            out.append(value)
    return out


def normalize_pseudocode_entries(entries):
    """Collapse duplicate class/method exports into one pseudocode string per m_XXX."""
    by_method = defaultdict(list)
    for entry in entries:
        pseudo = entry.get("pseudocode")
        method = entry.get("method")
        if not method or not pseudo:
            continue
        by_method[method].append(entry)

    out = []
    for method in sorted(by_method):
        variants = by_method[method]
        if len(variants) == 1:
            pseudocode = variants[0]["pseudocode"]
        else:
            chunks = []
            for idx, variant in enumerate(variants, 1):
                ea = variant.get("ea", "")
                chunks.append(f"// Variant {idx}; ea={ea}\n{variant['pseudocode']}")
            pseudocode = "\n\n".join(chunks)
        out.append({"name": method, "pseudocode": pseudocode})
    return out


def main() -> None:
    deobf = load_json(DEOBF_PATH)
    hexrays = load_json(HEXRAYS_PATH)

    hx_by_class_method = defaultdict(list)
    for info in hexrays.values():
        if not isinstance(info, dict):
            continue
        cls = info.get("class")
        method = info.get("method")
        if cls and HASH_RE.match(method or ""):
            hx_by_class_method[(cls, method)].append(info)

    class_rows = []
    for namespace, classes in deobf.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            if not isinstance(cls, dict):
                continue
            methods = [m for m in cls.get("methods", []) if isinstance(m, str)]
            hash_methods_raw = [m for m in methods if HASH_RE.match(m)]
            if not hash_methods_raw:
                continue
            hash_methods = unique_ordered(hash_methods_raw)
            named_methods = unique_ordered(m for m in methods if not HASH_RE.match(m))
            class_rows.append({
                "namespace": namespace,
                "class": cls.get("name", ""),
                "parent": cls.get("parent", ""),
                "named_methods": named_methods,
                "hash_methods": hash_methods,
                "raw_hash_count": len(hash_methods_raw),
                "unique_hash_count": len(hash_methods),
            })

    class_rows.sort(key=lambda r: (r["raw_hash_count"], r["unique_hash_count"], r["class"]), reverse=True)
    top_rows = class_rows[:TOP_CLASSES]

    OUT_DIR.mkdir(parents=True, exist_ok=True)
    for pattern in ("batch_*.json", "pred_*.json.raw.txt"):
        for path in OUT_DIR.glob(pattern):
            path.unlink()
    # Preserve predictions so reruns can skip existing batch numbers only if the
    # user intentionally keeps them. Remove them here because batch contents are rebuilt.
    for path in OUT_DIR.glob("pred_*.json"):
        path.unlink()

    manifest = []
    batch_index = 0
    total_pseudo = 0
    total_no_pseudo = 0

    for row_index, row in enumerate(top_rows, 1):
        pseudo_entries = []
        no_pseudo = []
        for method in row["hash_methods"]:
            entries = hx_by_class_method.get((row["class"], method), [])
            with_pseudo = [entry for entry in entries if entry.get("pseudocode")]
            if with_pseudo:
                pseudo_entries.extend(normalize_pseudocode_entries(with_pseudo))
            else:
                no_pseudo.append(method)

        pseudo_entries.sort(key=lambda e: e["name"])
        no_pseudo = sorted(unique_ordered(no_pseudo))
        total_pseudo += len(pseudo_entries)
        total_no_pseudo += len(no_pseudo)

        chunks = [
            pseudo_entries[i:i + MAX_PSEUDO_PER_BATCH]
            for i in range(0, len(pseudo_entries), MAX_PSEUDO_PER_BATCH)
        ]
        if not chunks:
            chunks = [[]]

        for sub_index, chunk in enumerate(chunks):
            batch = {
                "class": row["class"],
                "parent": row["parent"],
                "named_methods": row["named_methods"],
                "hash_methods_with_pseudo": chunk,
                "hash_methods_no_pseudo": no_pseudo if sub_index == 0 else [],
            }
            batch_path = OUT_DIR / f"batch_{batch_index:04d}.json"
            with open(batch_path, "w", encoding="utf-8") as handle:
                json.dump(batch, handle, indent=1, ensure_ascii=False)
            manifest.append({
                "batch": batch_path.name,
                "class": row["class"],
                "rank": row_index,
                "sub_batch": sub_index + 1,
                "sub_batch_count": len(chunks),
                "raw_hash_count": row["raw_hash_count"],
                "unique_hash_count": row["unique_hash_count"],
                "pseudo_count": len(chunk),
                "no_pseudo_count": len(no_pseudo) if sub_index == 0 else 0,
            })
            batch_index += 1

    with open(OUT_DIR / "manifest.json", "w", encoding="utf-8") as handle:
        json.dump(manifest, handle, indent=1, ensure_ascii=False)

    print(f"Top classes: {len(top_rows)}")
    print(f"Batches written: {batch_index}")
    print(f"Hash methods with pseudocode: {total_pseudo}")
    print(f"Hash methods without pseudocode: {total_no_pseudo}")
    print(f"Output: {OUT_DIR}")
    if manifest:
        print("Largest classes:")
        for item in manifest[:10]:
            if item["sub_batch"] == 1:
                print(
                    f"  rank {item['rank']:3d}: {item['class']} "
                    f"raw={item['raw_hash_count']} unique={item['unique_hash_count']} "
                    f"sub_batches={item['sub_batch_count']}"
                )


if __name__ == "__main__":
    main()
