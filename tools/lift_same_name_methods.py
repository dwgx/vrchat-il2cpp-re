#!/usr/bin/env python3
"""Lift hash-named methods between same-name classes in old/new deobf dumps."""

import argparse
import json
import os
import re
import sys
from collections import Counter, defaultdict


sys.stdout.reconfigure(encoding="utf-8")


HASH_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$")
OBF_CHAR_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")


def parse_args():
    parser = argparse.ArgumentParser(
        description="Aggressively lift method names between same-name classes."
    )
    parser.add_argument(
        "--old",
        default="output/v_old_20260408_regen/deobfuscated_dump.json",
        help="Old deobfuscated dump path.",
    )
    parser.add_argument(
        "--new",
        default="output/deobfuscated_dump.json",
        help="New deobfuscated dump path.",
    )
    parser.add_argument(
        "--output",
        default="output/same_name_method_lifts.json",
        help="Flat JSON output path.",
    )
    return parser.parse_args()


def load_json(path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path):
    parent = os.path.dirname(path)
    if parent:
        os.makedirs(parent, exist_ok=True)


def iter_classes(dump):
    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            yield namespace, cls


def build_class_index(dump):
    index = defaultdict(list)
    for namespace, cls in iter_classes(dump):
        index[(namespace, cls.get("name", ""))].append(cls)
    return index


def get_methods(cls):
    methods = cls.get("methods", [])
    return methods if isinstance(methods, list) else []


def is_hash_method(name):
    return bool(name) and bool(HASH_METHOD_RE.fullmatch(name))


def is_obfuscated(name):
    return bool(name) and bool(OBF_CHAR_RE.search(name))


def is_compiler_generated(name):
    return bool(name) and name.startswith("<")


def is_eligible_old_name(name):
    if not name or name in {".ctor", ".cctor"}:
        return False
    if is_compiler_generated(name):
        return False
    if is_hash_method(name):
        return False
    if is_obfuscated(name):
        return False
    return True


def is_semantic_new_name(name):
    if not name:
        return False
    if is_hash_method(name) or is_obfuscated(name):
        return False
    return True


def size_mismatch(new_count, old_count):
    larger = max(new_count, old_count)
    if larger == 0:
        return False
    return abs(new_count - old_count) > (larger * 0.20)


def main():
    args = parse_args()
    old_dump = load_json(args.old)
    new_dump = load_json(args.new)
    old_index = build_class_index(old_dump)

    lifts = {}
    lift_counts = Counter()
    matched_name = 0
    skipped_name_mismatch = 0
    skipped_size_mismatch = 0

    for namespace, new_cls in iter_classes(new_dump):
        key = (namespace, new_cls.get("name", ""))
        old_matches = old_index.get(key, [])
        if len(old_matches) != 1:
            skipped_name_mismatch += 1
            continue

        matched_name += 1
        old_cls = old_matches[0]
        new_methods = get_methods(new_cls)
        old_methods = get_methods(old_cls)

        if size_mismatch(len(new_methods), len(old_methods)):
            skipped_size_mismatch += 1
            continue

        used_names = {name for name in new_methods if is_semantic_new_name(name)}
        class_name = new_cls.get("name", "")

        for index, new_name in enumerate(new_methods):
            if not is_hash_method(new_name):
                continue
            if index >= len(old_methods):
                continue

            old_name = old_methods[index]
            if not is_eligible_old_name(old_name):
                continue
            if old_name in used_names:
                continue

            lifts[f"{class_name}::{new_name}"] = old_name
            used_names.add(old_name)
            lift_counts[class_name] += 1

    ensure_parent_dir(args.output)
    with open(args.output, "w", encoding="utf-8") as handle:
        json.dump(dict(sorted(lifts.items())), handle, indent=2, ensure_ascii=False)

    print(f"Classes processed (matched name): {matched_name}")
    print(
        f"Classes skipped (name mismatch or ambiguous): {skipped_name_mismatch}, "
        f"size mismatch: {skipped_size_mismatch}"
    )
    print(f"Total method lifts: {len(lifts)}")
    print("Top 10 classes by lift count:")
    for class_name, count in lift_counts.most_common(10):
        print(f"{class_name}: {count}")


if __name__ == "__main__":
    main()
