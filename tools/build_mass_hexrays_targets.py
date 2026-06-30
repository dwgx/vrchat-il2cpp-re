#!/usr/bin/env python3
"""Build a broad Hex-Rays target list for still-hashed methods."""

import argparse
import json
import re
import sys
from collections import defaultdict
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from name_quality import is_weak_name  # single source of truth


HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
RUNTIME_BASE_MASK = ~0xFFFFFF
IDA_BASE = 0x180000000
COMPILER_GENERATED = {"<>c", "<>c__DisplayClass"}


def parse_args() -> argparse.Namespace:
    root = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dump", default=str(root / "output" / "deobfuscated_dump.json"))
    parser.add_argument("--high-value", default=str(root / "output" / "v_new_ida" / "hexrays_high_value.json"))
    parser.add_argument("--out-list", default=str(root / "data" / "hexrays_mass_targets.txt"))
    parser.add_argument("--out-json", default=str(root / "data" / "hexrays_mass_targets.json"))
    parser.add_argument("--include-weak", action="store_true")
    parser.add_argument("--include-compiler-generated", action="store_true")
    parser.add_argument("--limit", type=int, default=0)
    return parser.parse_args()


def _removed_local_is_weak_name():
    # The local bare-prefix duplicate was deleted; build_mass uses the canonical
    # is_weak_name imported from name_quality (which correctly keeps real names
    # like MonoBehaviour/ServiceProvider out of the weak set).
    pass


def is_compiler_generated(name: str) -> bool:
    return name in COMPILER_GENERATED or name.startswith("<>")


def runtime_to_ida_ea(runtime_va_text: str) -> str | None:
    try:
        runtime_va = int(str(runtime_va_text), 16)
    except Exception:
        return None
    if runtime_va == 0:
        return None
    runtime_base = runtime_va & RUNTIME_BASE_MASK
    ida_ea = IDA_BASE + (runtime_va - runtime_base)
    return "0x%X" % ida_ea


def load_done_eas(path: Path) -> set[str]:
    done: set[str] = set()
    if not path.exists():
        return done
    try:
        data = json.load(open(path, "r", encoding="utf-8"))
    except Exception:
        return done
    if not isinstance(data, dict):
        return done
    for ea, info in data.items():
        if isinstance(info, dict) and info.get("pseudocode"):
            done.add(str(ea).upper().replace("X", "x"))
            if info.get("ea"):
                done.add(str(info["ea"]).upper().replace("X", "x"))
    return done


def main() -> None:
    args = parse_args()
    dump_path = Path(args.dump)
    high_value_path = Path(args.high_value)
    out_list = Path(args.out_list)
    out_json = Path(args.out_json)

    dump = json.load(open(dump_path, "r", encoding="utf-8"))
    done_eas = load_done_eas(high_value_path)

    rows = []
    skipped = defaultdict(int)
    for namespace, classes in dump.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            class_name = cls.get("name", "")
            if not args.include_compiler_generated and is_compiler_generated(class_name):
                skipped["compiler_generated_class"] += 1
                continue
            if not args.include_weak and is_weak_name(class_name):
                skipped["weak_class"] += 1
                continue

            method_ptrs = cls.get("method_pointers") or {}
            if not isinstance(method_ptrs, dict):
                continue
            methods = cls.get("methods") or []
            fields = cls.get("fields") or []
            named_method_count = sum(
                1 for method in methods
                if isinstance(method, str) and method and not HASH_RE.match(method)
            )
            for method in methods:
                if not (isinstance(method, str) and HASH_RE.match(method)):
                    continue
                runtime_va = method_ptrs.get(method)
                ea = runtime_to_ida_ea(runtime_va)
                if not ea:
                    skipped["missing_pointer"] += 1
                    continue
                if ea in done_eas:
                    skipped["already_high_value"] += 1
                    continue
                rows.append({
                    "ea": ea,
                    "runtime_va": "0x%X" % int(str(runtime_va), 16),
                    "class": class_name,
                    "class_obf": cls.get("original_name", ""),
                    "method": method,
                    "method_obf": method,
                    "namespace": namespace,
                    "parent": cls.get("parent", ""),
                    "known_method_count": named_method_count,
                    "field_count": len(fields) if isinstance(fields, list) else 0,
                })

    rows.sort(key=lambda item: (
        -item["known_method_count"],
        item["namespace"],
        item["class"],
        item["method"],
        item["ea"],
    ))

    unique_rows = []
    seen_eas = set()
    aliases_by_ea = defaultdict(int)
    for row in rows:
        aliases_by_ea[row["ea"]] += 1
        if row["ea"] in seen_eas:
            continue
        seen_eas.add(row["ea"])
        unique_rows.append(row)
        if args.limit and len(unique_rows) >= args.limit:
            break

    out_json.parent.mkdir(parents=True, exist_ok=True)
    out_json.write_text(json.dumps(unique_rows, indent=2, ensure_ascii=False), encoding="utf-8")
    out_list.write_text(
        "# mass hash method EAs for Hex-Rays export\n"
        + "\n".join(row["ea"] for row in unique_rows)
        + "\n",
        encoding="utf-8",
    )

    duplicate_aliases = sum(count - 1 for count in aliases_by_ea.values() if count > 1)
    print("candidate method rows: %d" % len(rows))
    print("unique target EAs: %d" % len(unique_rows))
    print("duplicate EA aliases skipped: %d" % duplicate_aliases)
    for key in sorted(skipped):
        print("skipped %-24s %d" % (key + ":", skipped[key]))
    print("json: %s" % out_json)
    print("list: %s" % out_list)


if __name__ == "__main__":
    main()
