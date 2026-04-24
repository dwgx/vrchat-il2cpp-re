#!/usr/bin/env python3
"""Propagate semantic deobfuscated names across methods sharing the same VA."""
import json
import re
import sys
import time
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE_DIR = Path(__file__).resolve().parent.parent
OBF_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]{3,}$")


def name_quality(name: str) -> int:
    if name.startswith("."):
        return 0
    if name.count(".") >= 2:
        return 1
    if "." in name:
        return 2
    if name.startswith("add_") or name.startswith("remove_"):
        return 3
    if name.startswith("get_") or name.startswith("set_"):
        return 4
    return 5


def clean_name(name: str) -> str:
    if "." in name and ">" not in name:
        return name.rsplit(".", 1)[-1]
    if ">" in name:
        m = re.search(r"\.(\w+)$", name)
        if m:
            return m.group(1)
    return name


def is_semantic(name: str) -> bool:
    return bool(name) and not name.startswith("m_") and not OBF_RE.match(name)


def is_bad_source(name: str) -> bool:
    return name.startswith(".") or ("<" in name and (">b__" in name or ">d__" in name))


def iter_aligned_methods(precise_cls: dict, deobf_cls: dict):
    precise_methods = precise_cls.get("methods", [])
    deobf_methods = deobf_cls.get("methods", [])
    mp_items = list(precise_cls.get("method_pointers", {}).items())
    mp_idx = 0
    for i, precise_name in enumerate(precise_methods):
        if i >= len(deobf_methods) or mp_idx >= len(mp_items):
            break
        ptr_name, va = mp_items[mp_idx]
        if precise_name != ptr_name:
            continue
        mp_idx += 1
        if va:
            yield precise_name, deobf_methods[i], va


def pick_best(counter: Counter) -> str | None:
    best_name = None
    best_rank = None
    for name, freq in counter.items():
        cleaned = clean_name(name)
        rank = (name_quality(cleaned), freq, -len(cleaned), cleaned)
        if best_rank is None or rank > best_rank:
            best_rank = rank
            best_name = cleaned
    return best_name


def main() -> None:
    t0 = time.time()
    precise_path = BASE_DIR / "data" / "precise_dump.json"
    deobf_path = BASE_DIR / "output" / "deobfuscated_dump.json"
    out_path = BASE_DIR / "output" / "va_propagation_v3_names.json"

    print("Loading dumps...")
    with precise_path.open("r", encoding="utf-8") as f:
        precise = json.load(f)
    with deobf_path.open("r", encoding="utf-8") as f:
        deobf = json.load(f)
    print(f"  Loaded in {time.time() - t0:.1f}s")

    print("Building VA candidate index from deobfuscated names...")
    va_to_candidates = defaultdict(Counter)
    va_total_methods = Counter()
    va_target_counts = Counter()
    targets = []
    aligned = 0

    for ns, precise_classes in precise["namespaces"].items():
        deobf_classes = deobf["namespaces"].get(ns, [])
        for precise_cls, deobf_cls in zip(precise_classes, deobf_classes):
            class_name = deobf_cls["name"]
            for precise_name, deobf_name, va in iter_aligned_methods(precise_cls, deobf_cls):
                aligned += 1
                va_total_methods[va] += 1
                if deobf_name.startswith("m_"):
                    va_target_counts[va] += 1
                    targets.append((class_name, deobf_name, va))
                elif is_semantic(deobf_name) and not is_bad_source(deobf_name):
                    va_to_candidates[va][deobf_name] += 1

    shared_vas = sum(1 for va in va_to_candidates if va_target_counts[va])

    print("Propagating into remaining hash-named methods...")
    result = {}
    class_lifts = Counter()
    stats = {
        "shared_vas": shared_vas,
        "semantic_candidates": sum(sum(c.values()) for c in va_to_candidates.values()),
        "lifts_emitted": 0,
        "conflicts": 0,
        "no_source": 0,
        "too_common": 0,
        "aligned_methods": aligned,
    }

    for class_name, method_name, va in targets:
        counter = va_to_candidates.get(va)
        if not counter:
            stats["no_source"] += 1
            continue
        if va_total_methods[va] > 500:
            stats["too_common"] += 1
            continue
        best_name = pick_best(counter)
        if not best_name or is_bad_source(best_name):
            continue
        key = f"{class_name}::{method_name}"
        if key in result and result[key] != best_name:
            stats["conflicts"] += 1
            if name_quality(best_name) > name_quality(result[key]):
                result[key] = best_name
            continue
        if key not in result:
            result[key] = best_name
            class_lifts[class_name] += 1
            stats["lifts_emitted"] += 1

    with out_path.open("w", encoding="utf-8") as f:
        json.dump(result, f, indent=1, ensure_ascii=False)

    elapsed = time.time() - t0
    print("\n=== VA Propagation v3 Results ===")
    print(f"  Shared VAs:            {stats['shared_vas']:,}")
    print(f"  Semantic candidates:   {stats['semantic_candidates']:,}")
    print(f"  Lifts emitted:         {stats['lifts_emitted']:,}")
    print(f"  Conflicts:             {stats['conflicts']:,}")
    print(f"  No source:             {stats['no_source']:,}")
    print(f"  Too common:            {stats['too_common']:,} (>500 semantic sources)")
    print(f"  Aligned methods:       {stats['aligned_methods']:,}")
    print(f"  Output: {out_path}")
    print(f"  Time: {elapsed:.1f}s")

    print("\nTop 10 classes by lift count:")
    for class_name, count in class_lifts.most_common(10):
        print(f"  {count:5d}  {class_name}")


if __name__ == "__main__":
    main()
