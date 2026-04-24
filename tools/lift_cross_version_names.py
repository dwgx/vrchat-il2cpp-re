#!/usr/bin/env python3
"""
Cross-version signature-based name lifting (OLD VRChat -> NEW VRChat).

This lifts:
1. Class names when a weakly named NEW class structurally matches an OLD class.
2. Method names by index when a matched class has hash-named methods in NEW and
   semantic method names in OLD.

Required outputs:
  - output/cross_version_lifted_names.json
  - output/cross_version_method_names.json

Primary mode:
  - Load an old deobfuscated dump directly.

Fallback mode:
  - Reconstruct an effective old deobfuscated view from:
      * old raw precise dump
      * old name_mapping.json
  - Or parse the old generated source tree when available.
"""

import argparse
import collections
import json
import os
import re
import sys


sys.stdout.reconfigure(encoding="utf-8")


ALL_OBF_RE = re.compile(r"^[\u00CC\u00CD\u00CE\u00CF]+$")
ANY_OBF_RE = re.compile(r"[\u00CC\u00CD\u00CE\u00CF]")
METHOD_HASH_RE = re.compile(r"^m_[0-9A-Fa-f]+$")
FIELD_HASH_RE = re.compile(r"^f_[0-9A-Fa-f]+$")
HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$")
NUMERIC_WEAK_RE = re.compile(
    r"^(Type|Struct|Mono|Service|Major|Static|DataOnly|Unknown|Record)\d+"
)
BASE_CLASS_RE = re.compile(r"^BaseClass\d+")

TARGET_NEW_PREFIXES = (
    "MajorSystem_",
    "UpdateComponentSibling_",
    "VRC_SecondarySibling_",
    "ComplexComponent_",
    "TransformGameObjectSystem_",
    "AnimatedTextureBaseImpl",
    "VRCUiManagerSibling_",
    "NetworkReadyHandler_",
    "UdonOperationResponse_",
    "ComplexComponentSibling_",
    "BaseClass",
    "BaseSibling",
    "SiblingSibling_",
    "Class_",
    "Type_",
    "NestedType_",
    "GenericArg_",
)

WEAK_BASE_PREFIXES = (
    "AsyncStateMachine",
    "Enumerator",
    "LifecycleComponent",
    "EmptyType",
    "EmptyStruct",
    "UpdateComponent",
    "ComplexComponent",
    "Delegate",
    "FBase",
    "AnimatedTextureBase",
    "NetworkReadyHandler",
    "MajorSystem",
    "VRC_Secondary",
    "VRCUiManagerSibling",
    "TransformGameObjectSystem",
    "UdonOperationResponse",
    "ComplexComponentSibling",
    "BaseSibling",
    "SiblingSibling",
    "Class",
    "Type",
    "NestedType",
    "GenericArg",
)

NAMESPACE_COMMENT_RE = re.compile(r"^// Namespace:\s*(.+?)\s*$")
ORIGINAL_COMMENT_RE = re.compile(r"^\s*/// <summary>Originally:\s*(.+?)</summary>\s*$")
TYPE_DECL_RE = re.compile(
    r"^\s*public\s+(class|struct|interface|enum)\s+([^\s:]+)(?:\s*:\s*([^{]+))?"
)
FIELD_DECL_RE = re.compile(r"^\s*public\s+.+?\s+([^\s;(]+);\s*(?://.*)?$")
METHOD_DECL_RE = re.compile(r"^\s*public\s+.+?\s+([^\s(]+)\([^)]*\)\s*\{")


def parse_args():
    parser = argparse.ArgumentParser(
        description="Lift semantic class/method names from an old dump into a new dump."
    )
    parser.add_argument(
        "--old-deobf",
        default="output/v_old_20260408_regen/deobfuscated_dump.json",
        help="Old deobfuscated dump. If absent, fallback reconstruction is used.",
    )
    parser.add_argument(
        "--new-deobf",
        default="output/deobfuscated_dump.json",
        help="New deobfuscated dump to improve.",
    )
    parser.add_argument(
        "--old-raw",
        default="data/precise_dump_OLD_20260408.json",
        help="Old raw precise dump for fallback reconstruction.",
    )
    parser.add_argument(
        "--old-name-map",
        default="output/name_mapping.json",
        help="Old name_mapping.json for fallback reconstruction.",
    )
    parser.add_argument(
        "--old-src-root",
        default="temp/old_src_a1ebaeb/output/src",
        help="Old generated source-tree root used when old deobf JSON is unavailable.",
    )
    parser.add_argument(
        "--output",
        default="output/cross_version_lifted_names.json",
        help="Output JSON path.",
    )
    parser.add_argument(
        "--method-output",
        default="output/cross_version_method_names.json",
        help="Flat method-name mapping output for pipeline consumption.",
    )
    return parser.parse_args()


def load_json(path):
    with open(path, "r", encoding="utf-8") as handle:
        return json.load(handle)


def ensure_parent_dir(path):
    parent = os.path.dirname(path)
    if parent:
        os.makedirs(parent, exist_ok=True)


def iter_flat_classes(dump):
    for namespace, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            yield namespace, cls


def get_member_name(entry):
    if isinstance(entry, str):
        return entry
    if isinstance(entry, dict):
        return entry.get("name", "")
    return ""


def is_all_obfuscated_name(name):
    return bool(name) and bool(ALL_OBF_RE.fullmatch(name))


def contains_obfuscated_chars(name):
    return bool(name) and bool(ANY_OBF_RE.search(name))


def is_hash_named(name):
    if not name:
        return False
    return bool(METHOD_HASH_RE.fullmatch(name) or FIELD_HASH_RE.fullmatch(name))


def is_hash_named_method(name):
    return bool(name) and bool(METHOD_HASH_RE.fullmatch(name))


def is_semantic_method_name(name):
    return bool(name) and not contains_obfuscated_chars(name) and not is_hash_named_method(name)


def normalize_parent_name(name):
    if not name:
        return ""
    if name in ("Object", "System.Object"):
        return "System.Object"
    return name


def jaccard_similarity(left, right):
    if not left and not right:
        return 1.0
    if not left or not right:
        return 0.0
    union = left | right
    if not union:
        return 1.0
    return float(len(left & right)) / float(len(union))


def is_target_new_class_name(name):
    return bool(name) and (
        is_all_obfuscated_name(name) or name.startswith(TARGET_NEW_PREFIXES)
    )


def is_weak_semantic_class_name(name):
    if not name:
        return True
    if name.startswith("<") or ">" in name:
        return True
    if contains_obfuscated_chars(name):
        return True
    if name.startswith(TARGET_NEW_PREFIXES):
        return True
    if NUMERIC_WEAK_RE.match(name):
        return True
    if BASE_CLASS_RE.match(name):
        return True
    if HEX_SUFFIX_RE.search(name):
        return True
    return False


def is_compiler_generated_class_name(name):
    return bool(name) and (name.startswith("<") or ">" in name)


def semantic_member_names(entries):
    names = set()
    for entry in entries:
        name = get_member_name(entry)
        if not name:
            continue
        if contains_obfuscated_chars(name) or is_hash_named(name):
            continue
        names.add(name)
    return frozenset(names)


def remap_member(class_name, raw_class_name, raw_member_name, mapping):
    direct_key = class_name + "::" + raw_member_name
    if direct_key in mapping:
        return mapping[direct_key]

    fallback_key = raw_class_name + "::" + raw_member_name
    if fallback_key in mapping:
        return mapping[fallback_key]

    return raw_member_name


def build_old_effective_dump(old_raw_path, old_name_map_path):
    old_raw = load_json(old_raw_path)
    name_map = load_json(old_name_map_path)
    class_map = name_map.get("classes", {})
    method_map = name_map.get("methods", {})
    field_map = name_map.get("fields", {})

    effective = {"summary": old_raw.get("summary", {}), "namespaces": {}}
    for namespace, cls in iter_flat_classes(old_raw):
        raw_name = cls.get("name", "")
        class_name = class_map.get(raw_name, raw_name)
        raw_parent = cls.get("parent", "")
        parent_name = class_map.get(raw_parent, raw_parent)

        raw_methods = [get_member_name(item) for item in cls.get("methods", [])]
        raw_fields = [get_member_name(item) for item in cls.get("fields", [])]

        methods = [
            remap_member(class_name, raw_name, method_name, method_map)
            for method_name in raw_methods
        ]
        fields = [
            remap_member(class_name, raw_name, field_name, field_map)
            for field_name in raw_fields
        ]

        rebuilt = {
            "name": class_name,
            "original_name": raw_name,
            "namespace": namespace,
            "parent": parent_name,
            "methods": methods,
            "fields": fields,
            "raw_methods": raw_methods,
            "raw_fields": raw_fields,
            "method_pointers": cls.get("method_pointers", {}),
            "va": cls.get("va", ""),
        }
        effective["namespaces"].setdefault(namespace, []).append(rebuilt)

    return effective


def parse_old_source_tree(src_root):
    synthetic = {"summary": {}, "namespaces": {}}

    for root, _, files in os.walk(src_root):
        for file_name in files:
            if not file_name.endswith(".cs"):
                continue

            path = os.path.join(root, file_name)
            with open(path, "r", encoding="utf-8") as handle:
                namespace = ""
                pending_original = ""
                current = None
                depth = 0

                for raw_line in handle:
                    line = raw_line.rstrip("\n")

                    namespace_match = NAMESPACE_COMMENT_RE.match(line)
                    if namespace_match:
                        namespace = namespace_match.group(1).strip()
                        if namespace == "Global":
                            namespace = ""
                        continue

                    original_match = ORIGINAL_COMMENT_RE.match(line)
                    if original_match:
                        pending_original = original_match.group(1).strip()
                        continue

                    if current is None:
                        type_match = TYPE_DECL_RE.match(line)
                        if type_match:
                            parent_decl = (type_match.group(3) or "").strip()
                            parent_name = ""
                            if parent_decl:
                                parent_name = parent_decl.split(",", 1)[0].strip()

                            current = {
                                "name": type_match.group(2).strip(),
                                "original_name": pending_original or type_match.group(2).strip(),
                                "namespace": namespace,
                                "parent": parent_name,
                                "methods": [],
                                "fields": [],
                                "method_pointers": {},
                                "va": "",
                            }
                            pending_original = ""
                            depth = line.count("{") - line.count("}")
                            continue
                    else:
                        field_match = FIELD_DECL_RE.match(line)
                        if field_match and "(" not in line:
                            current["fields"].append(field_match.group(1).strip())

                        method_match = METHOD_DECL_RE.match(line)
                        if method_match:
                            current["methods"].append(method_match.group(1).strip())

                    if current is not None:
                        depth += line.count("{") - line.count("}")
                        if depth <= 0 and line.strip() == "}":
                            synthetic["namespaces"].setdefault(
                                current["namespace"], []
                            ).append(current)
                            current = None
                            depth = 0

    return synthetic


def build_class_records(dump, source_tag):
    records = []
    for ordinal, (namespace, cls) in enumerate(iter_flat_classes(dump)):
        name = cls.get("name", "")
        methods = [get_member_name(item) for item in cls.get("methods", [])]
        fields = [get_member_name(item) for item in cls.get("fields", [])]
        semantic_methods = semantic_member_names(methods)
        semantic_fields = semantic_member_names(fields)

        record = {
            "id": ordinal,
            "source": source_tag,
            "namespace": namespace,
            "name": name,
            "parent": normalize_parent_name(cls.get("parent", "")),
            "methods": methods,
            "fields": fields,
            "method_count": len(methods),
            "field_count": len(fields),
            "semantic_methods": semantic_methods,
            "semantic_fields": semantic_fields,
            "semantic_method_count": len(semantic_methods),
            "semantic_field_count": len(semantic_fields),
            "hash_method_count": sum(1 for method in methods if is_hash_named_method(method)),
            "va": cls.get("va", ""),
        }
        records.append(record)
    return records


def build_indexes(old_records):
    old_by_parent = collections.defaultdict(list)
    old_by_ns_name = collections.defaultdict(list)
    for record in old_records:
        old_by_parent[record["parent"]].append(record)
        old_by_ns_name[(record["namespace"], record["name"])].append(record)
    return old_by_parent, old_by_ns_name


def within_count_tolerance(lhs, rhs):
    diff = abs(lhs - rhs)
    baseline = max(lhs, rhs)
    percent_ok = diff == 0 if baseline == 0 else diff <= (baseline * 0.10)
    absolute_ok = diff <= 3
    return percent_ok and absolute_ok


def candidate_name_or_method(record):
    return is_target_new_class_name(record["name"]) or record["hash_method_count"] > 0


def candidate_filter(new_record, old_record):
    if new_record["parent"] != old_record["parent"]:
        return None
    if not within_count_tolerance(new_record["method_count"], old_record["method_count"]):
        return None
    if not within_count_tolerance(new_record["field_count"], old_record["field_count"]):
        return None

    method_jaccard = jaccard_similarity(
        new_record["semantic_methods"], old_record["semantic_methods"]
    )
    if method_jaccard < 0.5:
        return None

    common_methods = len(new_record["semantic_methods"] & old_record["semantic_methods"])
    enough_method_signal = (
        common_methods >= 5
        or new_record["semantic_method_count"] >= 10
        or old_record["semantic_method_count"] >= 10
    )
    if not enough_method_signal:
        return None

    field_jaccard = jaccard_similarity(
        new_record["semantic_fields"], old_record["semantic_fields"]
    )
    parent_match = 1.0
    score = (method_jaccard * 0.6) + (field_jaccard * 0.3) + (parent_match * 0.1)

    return {
        "score": score,
        "method_jaccard": method_jaccard,
        "field_jaccard": field_jaccard,
        "common_methods": common_methods,
    }


def choose_best_candidate(new_record, old_candidates):
    best_old = None
    best_metrics = None
    for old_record in old_candidates:
        metrics = candidate_filter(new_record, old_record)
        if metrics is None:
            continue
        sort_key = (
            metrics["score"],
            metrics["method_jaccard"],
            metrics["field_jaccard"],
            metrics["common_methods"],
            int(new_record["namespace"] == old_record["namespace"]),
            -abs(new_record["method_count"] - old_record["method_count"]),
            -abs(new_record["field_count"] - old_record["field_count"]),
            old_record["name"],
            old_record["namespace"],
        )
        if best_metrics is None or sort_key > best_metrics:
            best_old = old_record
            best_metrics = sort_key
    return best_old


def add_unique_mapping(mapping, ambiguous_keys, key, value):
    if key in ambiguous_keys:
        return False
    current = mapping.get(key)
    if current is None:
        mapping[key] = value
        return True
    if current == value:
        return False
    del mapping[key]
    ambiguous_keys.add(key)
    return False


def collect_method_lifts(new_record, old_record, method_lifts, ambiguous_method_keys):
    added = 0
    limit = min(len(new_record["methods"]), len(old_record["methods"]))
    for idx in range(limit):
        new_method = new_record["methods"][idx]
        old_method = old_record["methods"][idx]
        if not is_hash_named_method(new_method):
            continue
        if not is_semantic_method_name(old_method):
            continue
        method_key = new_record["name"] + "::" + new_method
        if add_unique_mapping(method_lifts, ambiguous_method_keys, method_key, old_method):
            added += 1
    return added


def load_old_dump(args):
    if os.path.exists(args.old_deobf):
        return load_json(args.old_deobf), args.old_deobf
    if os.path.isdir(args.old_src_root):
        return parse_old_source_tree(args.old_src_root), args.old_src_root
    return (
        build_old_effective_dump(args.old_raw, args.old_name_map),
        args.old_raw + " + " + args.old_name_map,
    )


def main():
    args = parse_args()

    new_dump = load_json(args.new_deobf)
    old_dump, old_source = load_old_dump(args)

    new_records = build_class_records(new_dump, "new")
    old_records = build_class_records(old_dump, "old")
    old_by_parent, old_by_ns_name = build_indexes(old_records)

    class_lifts = {}
    method_lifts = {}
    ambiguous_class_keys = set()
    ambiguous_method_keys = set()

    candidates_examined = 0
    class_matches = 0
    stable_name_candidates = 0

    for new_record in new_records:
        exact_name_candidates = old_by_ns_name.get(
            (new_record["namespace"], new_record["name"]), []
        )
        best_old = None
        attempted = False

        if exact_name_candidates:
            stable_name_candidates += 1
            attempted = True
            best_old = choose_best_candidate(new_record, exact_name_candidates)

        if best_old is None and candidate_name_or_method(new_record):
            attempted = True
            parent_candidates = old_by_parent.get(new_record["parent"], [])
            best_old = choose_best_candidate(new_record, parent_candidates)
        if attempted:
            candidates_examined += 1

        if best_old is None:
            continue

        class_matches += 1
        if (
            new_record["name"] != best_old["name"]
            and is_weak_semantic_class_name(new_record["name"])
            and not is_compiler_generated_class_name(new_record["name"])
            and not is_weak_semantic_class_name(best_old["name"])
        ):
            add_unique_mapping(
                class_lifts,
                ambiguous_class_keys,
                new_record["name"],
                best_old["name"],
            )

        collect_method_lifts(
            new_record, best_old, method_lifts, ambiguous_method_keys
        )

    total_methods = int(new_dump.get("summary", {}).get("total_methods", 0))
    coverage_delta = (
        (100.0 * len(method_lifts) / total_methods) if total_methods else 0.0
    )

    stats = {
        "candidates_examined": candidates_examined,
        "class_matches": class_matches,
        "class_lifts": len(class_lifts),
        "method_lifts": len(method_lifts),
        "coverage_delta_methods_pct": round(coverage_delta, 4),
    }

    lifted_payload = {
        "classes": dict(sorted(class_lifts.items())),
        "methods": dict(sorted(method_lifts.items())),
        "stats": stats,
    }

    ensure_parent_dir(args.output)
    ensure_parent_dir(args.method_output)

    with open(args.output, "w", encoding="utf-8") as handle:
        json.dump(lifted_payload, handle, indent=2, ensure_ascii=False)
        handle.write("\n")

    with open(args.method_output, "w", encoding="utf-8") as handle:
        json.dump(dict(sorted(method_lifts.items())), handle, indent=2, ensure_ascii=False)
        handle.write("\n")

    print("Old source:", old_source)
    print("New source:", args.new_deobf)
    print("Stable-name candidates:", stable_name_candidates)
    print("Candidates examined:", candidates_examined)
    print("Class matches:", class_matches)
    print("Class lifts:", len(class_lifts))
    print("Method lifts:", len(method_lifts))
    print(
        "Estimated coverage delta: {}/{} ({:.4f}%)".format(
            len(method_lifts), total_methods, coverage_delta
        )
    )
    if ambiguous_class_keys:
        print("Skipped ambiguous class keys:", len(ambiguous_class_keys))
    if ambiguous_method_keys:
        print("Skipped ambiguous method keys:", len(ambiguous_method_keys))
    print("Wrote:", args.output)
    print("Wrote:", args.method_output)


if __name__ == "__main__":
    main()
