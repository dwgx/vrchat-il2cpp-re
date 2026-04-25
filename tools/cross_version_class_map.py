#!/usr/bin/env python3
"""Cross-map classes between dump sessions by method body hashes."""

from __future__ import annotations

import argparse
import hashlib
import json
import sys
import time
from bisect import bisect_right
from collections import defaultdict
from pathlib import Path

from extract_precise_dump import DumpReader

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_DUMP_OLD = BASE_DIR / "tools" / "VRChat_139620_20260418_180023_full.dmp"
DEFAULT_DUMP_NEW = BASE_DIR / "tools" / "VRChat_kernel_full.dmp"
DEFAULT_PRECISE_OLD = BASE_DIR / "data" / "precise_dump.json"
DEFAULT_PRECISE_NEW = BASE_DIR / "precise_dump_NEW.json"
DEFAULT_OUTPUT = BASE_DIR / "data" / "class_map_old_to_new.json"
FALLBACK_OUTPUT = BASE_DIR / "output" / "class_map_old_to_new.json"


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Cross-map classes between dump sessions using method body hashes."
    )
    parser.add_argument("--dump-old", default=str(DEFAULT_DUMP_OLD))
    parser.add_argument("--dump-new", default=str(DEFAULT_DUMP_NEW))
    parser.add_argument("--precise-old", default=str(DEFAULT_PRECISE_OLD))
    parser.add_argument("--precise-new", default=str(DEFAULT_PRECISE_NEW))
    parser.add_argument("--output", default=str(DEFAULT_OUTPUT))
    parser.add_argument("--window", type=int, default=128, help="Bytes to hash per method body.")
    parser.add_argument("--min-score", type=float, default=0.7)
    parser.add_argument("--min-shared", type=int, default=3)
    return parser.parse_args()


def load_json(path: Path) -> dict:
    with path.open("r", encoding="utf-8") as handle:
        return json.load(handle)


def parse_va(value: object) -> int | None:
    if not value:
        return None
    try:
        va = int(str(value), 16)
    except ValueError:
        return None
    return va if va > 0 else None


def fmt_va(va: int) -> str:
    return f"0x{va:X}"


def flatten_classes(data: dict) -> list[dict[str, object]]:
    items: list[dict[str, object]] = []
    for namespace, classes in data.get("namespaces", {}).items():
        for cls in classes:
            name = cls.get("name", "") or ""
            va = parse_va(cls.get("va"))
            if not va:
                continue
            fullname = f"{namespace}.{name}" if namespace else name
            items.append(
                {
                    "namespace": namespace or "",
                    "name": name,
                    "fullname": fullname,
                    "va": va,
                    "va_hex": fmt_va(va),
                    "method_pointers": cls.get("method_pointers") or {},
                }
            )
    return items


def read_va_bytes(dr: DumpReader, va: int, size: int) -> bytes:
    idx = bisect_right(dr.va_starts, va) - 1
    if idx < 0:
        return b""

    remaining = size
    current_va = va
    chunks: list[bytes] = []
    while remaining > 0 and idx < len(dr.va_map):
        start, seg_size, file_off = dr.va_map[idx]
        if not (start <= current_va < start + seg_size):
            break
        take = min(remaining, (start + seg_size) - current_va)
        seg_off = file_off + (current_va - start)
        chunks.append(dr.mm[seg_off : seg_off + take])
        remaining -= take
        current_va += take
        idx += 1
        if remaining <= 0:
            break
        if idx >= len(dr.va_map) or dr.va_map[idx][0] != current_va:
            break
    return b"".join(chunks)


def build_class_hashes(
    label: str,
    dr: DumpReader,
    classes: list[dict[str, object]],
    window: int,
) -> tuple[list[dict[str, object]], dict[str, int]]:
    method_hash_cache: dict[int, str | None] = {}
    stats = {
        "classes": len(classes),
        "classes_with_hashes": 0,
        "unique_methods_hashed": 0,
        "method_ptrs_seen": 0,
        "method_ptrs_hashed": 0,
        "method_ptrs_skipped": 0,
    }

    out: list[dict[str, object]] = []
    started = time.time()
    for index, cls in enumerate(classes, start=1):
        hashes: set[str] = set()
        method_ptrs = cls["method_pointers"]
        if isinstance(method_ptrs, dict):
            for value in method_ptrs.values():
                method_va = parse_va(value)
                if not method_va:
                    continue
                stats["method_ptrs_seen"] += 1
                if method_va not in method_hash_cache:
                    blob = read_va_bytes(dr, method_va, window)
                    if not blob or not any(blob):
                        method_hash_cache[method_va] = None
                        stats["method_ptrs_skipped"] += 1
                    else:
                        method_hash_cache[method_va] = hashlib.sha1(blob).digest()[:16].hex()
                        stats["method_ptrs_hashed"] += 1
                method_hash = method_hash_cache[method_va]
                if method_hash:
                    hashes.add(method_hash)

        record = dict(cls)
        record["hashes"] = hashes
        record["method_count"] = len(hashes)
        out.append(record)
        if hashes:
            stats["classes_with_hashes"] += 1

        if index % 5000 == 0 or index == len(classes):
            elapsed = time.time() - started
            print(
                f"[{label}] {index:,}/{len(classes):,} classes, "
                f"{stats['method_ptrs_hashed']:,} unique method bodies hashed "
                f"({elapsed:.1f}s)"
            )

    stats["unique_methods_hashed"] = sum(1 for value in method_hash_cache.values() if value)
    return out, stats


def build_inverted_index(classes: list[dict[str, object]]) -> tuple[dict[str, list[int]], list[int]]:
    inverted: dict[str, list[int]] = defaultdict(list)
    sizes: list[int] = []
    for idx, cls in enumerate(classes):
        hashes = cls["hashes"]
        sizes.append(len(hashes))
        for digest in hashes:
            inverted[digest].append(idx)
    return inverted, sizes


def map_classes(
    old_classes: list[dict[str, object]],
    new_classes: list[dict[str, object]],
    new_inverted: dict[str, list[int]],
    new_sizes: list[int],
    min_score: float,
    min_shared: int,
) -> tuple[dict[str, dict[str, object]], dict[str, object]]:
    result: dict[str, dict[str, object]] = {}
    mapped_scores: list[float] = []
    unmapped_names: list[str] = []

    started = time.time()
    for index, old_cls in enumerate(old_classes, start=1):
        old_hashes = old_cls["hashes"]
        old_size = len(old_hashes)
        if old_size == 0:
            if len(unmapped_names) < 12:
                unmapped_names.append(str(old_cls["fullname"]))
            continue

        candidate_shared: dict[int, int] = defaultdict(int)
        for digest in old_hashes:
            for new_idx in new_inverted.get(digest, ()):
                candidate_shared[new_idx] += 1

        best_idx: int | None = None
        best_shared = 0
        best_score = 0.0

        for new_idx, shared in candidate_shared.items():
            if shared < min_shared:
                continue
            new_size = new_sizes[new_idx]
            union = old_size + new_size - shared
            if union <= 0:
                continue
            score = shared / union
            if score > best_score or (score == best_score and shared > best_shared):
                best_idx = new_idx
                best_shared = shared
                best_score = score

        if best_idx is not None and best_score >= min_score:
            new_cls = new_classes[best_idx]
            result[str(old_cls["va_hex"])] = {
                "new_va": str(new_cls["va_hex"]),
                "score": round(best_score, 6),
                "shared": best_shared,
                "old_methods": old_size,
                "new_methods": new_sizes[best_idx],
            }
            mapped_scores.append(best_score)
        elif len(unmapped_names) < 12:
            unmapped_names.append(str(old_cls["fullname"]))

        if index % 5000 == 0 or index == len(old_classes):
            elapsed = time.time() - started
            print(f"[map] {index:,}/{len(old_classes):,} old classes scored ({elapsed:.1f}s)")

    stats = {
        "total_old_classes": len(old_classes),
        "mapped": len(result),
        "unmapped": len(old_classes) - len(result),
        "avg_jaccard": (sum(mapped_scores) / len(mapped_scores)) if mapped_scores else 0.0,
        "unmapped_samples": unmapped_names[:8],
    }
    return result, stats


def main() -> int:
    args = parse_args()

    dump_old = Path(args.dump_old)
    dump_new = Path(args.dump_new)
    precise_old = Path(args.precise_old)
    precise_new = Path(args.precise_new)
    output = Path(args.output)
    output.parent.mkdir(parents=True, exist_ok=True)

    print("[+] Loading precise dumps...")
    old_classes = flatten_classes(load_json(precise_old))
    new_classes = flatten_classes(load_json(precise_new))
    print(f"    old classes: {len(old_classes):,}")
    print(f"    new classes: {len(new_classes):,}")

    print("[+] Opening dumps...")
    dr_old = DumpReader(str(dump_old))
    dr_new = DumpReader(str(dump_new))

    print(f"[+] Building old-class method hashes ({args.window} bytes)...")
    old_hashed, old_stats = build_class_hashes("old", dr_old, old_classes, args.window)

    print(f"[+] Building new-class method hashes ({args.window} bytes)...")
    new_hashed, new_stats = build_class_hashes("new", dr_new, new_classes, args.window)

    print("[+] Building inverted index...")
    new_inverted, new_sizes = build_inverted_index(new_hashed)
    print(f"    unique hashes in new dump: {len(new_inverted):,}")

    print(
        f"[+] Scoring class matches (threshold={args.min_score:.2f}, "
        f"min_shared={args.min_shared})..."
    )
    class_map, stats = map_classes(
        old_hashed,
        new_hashed,
        new_inverted,
        new_sizes,
        args.min_score,
        args.min_shared,
    )

    written_to = output
    try:
        with output.open("w", encoding="utf-8") as handle:
            json.dump(class_map, handle, indent=2, ensure_ascii=False, sort_keys=True)
    except PermissionError:
        written_to = FALLBACK_OUTPUT
        written_to.parent.mkdir(parents=True, exist_ok=True)
        with written_to.open("w", encoding="utf-8") as handle:
            json.dump(class_map, handle, indent=2, ensure_ascii=False, sort_keys=True)
        print(f"[!] Could not write {output}; wrote fallback {written_to} instead.")

    print(f"[+] Wrote {written_to}")
    print(
        f"    old classes: {stats['total_old_classes']:,}, "
        f"mapped: {stats['mapped']:,}, unmapped: {stats['unmapped']:,}"
    )
    print(f"    avg Jaccard: {stats['avg_jaccard']:.4f}")
    if stats["unmapped_samples"]:
        print("    sample unmapped:")
        for name in stats["unmapped_samples"][:5]:
            print(f"      - {name}")

    print("[+] Hashing summary:")
    print(
        f"    old hashed classes: {old_stats['classes_with_hashes']:,}/{old_stats['classes']:,}, "
        f"unique method bodies: {old_stats['unique_methods_hashed']:,}"
    )
    print(
        f"    new hashed classes: {new_stats['classes_with_hashes']:,}/{new_stats['classes']:,}, "
        f"unique method bodies: {new_stats['unique_methods_hashed']:,}"
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
