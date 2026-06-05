#!/usr/bin/env python3
"""Build a focused Hex-Rays target list for high-value VRChat classes."""

import argparse
import json
import re
from pathlib import Path


HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")
DEFAULT_CLASS_KEYWORDS = (
    "NetworkManager",
    "VRCPlayer",
    "PlayerNet",
    "VRCFlowManager",
    "VRCFlowNetworkManager",
    "PhotonHandler",
    "PlayerManager",
    "RoomManager",
    "ModerationManager",
    "VRCAvatarManager",
    "VRCNetworkBehaviour",
    "VRC_Main",
    "VRC_Secondary",
)
RUNTIME_BASE_MASK = ~0xFFFFFF
IDA_BASE = 0x180000000


def parse_args():
    root = Path(__file__).resolve().parent.parent
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--precise", default=str(root / "data" / "precise_dump.json"))
    parser.add_argument("--names", default=str(root / "output" / "name_mapping.json"))
    parser.add_argument("--out-json", default=str(root / "data" / "hexrays_high_value_targets.json"))
    parser.add_argument("--out-list", default=str(root / "data" / "hexrays_high_value_targets.txt"))
    parser.add_argument("--limit", type=int, default=1200)
    parser.add_argument("--keyword", action="append", default=[])
    return parser.parse_args()


def main():
    args = parse_args()
    precise = json.load(open(args.precise, "r", encoding="utf-8"))
    names = json.load(open(args.names, "r", encoding="utf-8"))
    class_map = names.get("classes", {})
    method_map = names.get("methods", {})
    keywords = tuple(args.keyword) if args.keyword else DEFAULT_CLASS_KEYWORDS

    raw_rows = []
    for namespace, classes in precise.get("namespaces", {}).items():
        if not isinstance(classes, list):
            continue
        for cls in classes:
            class_obf = cls.get("name", "")
            class_name = class_map.get(class_obf, class_obf)
            if not any(keyword in class_name for keyword in keywords):
                continue
            method_ptrs = cls.get("method_pointers") or {}
            known_count = 0
            for method_obf in cls.get("methods") or []:
                if not isinstance(method_obf, str):
                    continue
                mapped = method_map.get(f"{class_obf}::{method_obf}", "")
                if mapped and not HASH_RE.match(mapped):
                    known_count += 1
            for method_obf in cls.get("methods") or []:
                if not isinstance(method_obf, str):
                    continue
                mapped = method_map.get(f"{class_obf}::{method_obf}", "")
                if not (isinstance(mapped, str) and HASH_RE.match(mapped)):
                    continue
                runtime_va_text = method_ptrs.get(method_obf)
                if not runtime_va_text:
                    continue
                runtime_va = int(str(runtime_va_text), 16)
                runtime_base = runtime_va & RUNTIME_BASE_MASK
                ida_ea = IDA_BASE + (runtime_va - runtime_base)
                raw_rows.append({
                    "ea": "0x%X" % ida_ea,
                    "runtime_va": "0x%X" % runtime_va,
                    "class": class_name,
                    "class_obf": class_obf,
                    "method": mapped,
                    "method_obf": method_obf,
                    "namespace": namespace,
                    "known_method_count": known_count,
                })

    seen = set()
    rows = []
    for row in sorted(raw_rows, key=lambda item: (
        -item["known_method_count"],
        item["class"],
        item["method"],
        item["ea"],
    )):
        key = row["ea"]
        if key in seen:
            continue
        seen.add(key)
        rows.append(row)
        if args.limit and len(rows) >= args.limit:
            break

    out_json = Path(args.out_json)
    out_list = Path(args.out_list)
    out_json.parent.mkdir(parents=True, exist_ok=True)
    out_json.write_text(json.dumps(rows, indent=2, ensure_ascii=False), encoding="utf-8")
    out_list.write_text(
        "# high-value hash method EAs for Hex-Rays export\n" +
        "\n".join(row["ea"] for row in rows) +
        "\n",
        encoding="utf-8",
    )

    classes = {row["class"] for row in rows}
    print("targets: %d" % len(rows))
    print("classes: %d" % len(classes))
    print("json: %s" % out_json)
    print("list: %s" % out_list)


if __name__ == "__main__":
    main()
