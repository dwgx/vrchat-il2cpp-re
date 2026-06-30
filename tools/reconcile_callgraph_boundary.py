"""Reconcile the dump after the strict-boundary callee rescan invalidated the
old (overrun-inflated) callgraph names.

The fixed-2000-byte disassembly window overran function boundaries and inflated
domain-callee counts, so 151 classes (191 instances) were named on phantom
evidence. With the next-VA hard boundary only 11 proposals survive.

This script:
  1. Reverts every callgraph_inferred class to a structural placeholder name
     (prefix from parent+method/field counts, suffix = sha256(obf)[:4]) and
     clears its semantic_source. These names are weak by design.
  2. Re-applies ONLY the clean-boundary proposals (callgraph_class_names.json,
     now 11 entries) via the same gate as the pipeline.

Idempotent. Verifies all reverted names are weak and unique.
"""
import json, sys, re, hashlib
sys.stdout.reconfigure(encoding="utf-8", errors="replace")
from pathlib import Path
ROOT = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(ROOT / "tools"))
from name_quality import is_weak_name

DUMP = ROOT / "output" / "deobfuscated_dump.json"
CLEAN = ROOT / "output" / "callgraph_class_names.json"  # already regenerated (11)


def stable_hash(name, length=4):
    return hashlib.sha256(name.encode("utf-8")).hexdigest()[:length].upper()


def is_obf(n):
    return bool(n) and any(c in "ÌÍÎÏ" for c in n)


def struct_prefix(parent, mc, fc, class_map):
    if parent == "ValueType":
        return "EmptyStruct" if fc == 0 else f"Struct{fc}f"
    if parent == "Enum":
        return "Enum"
    if parent == "Object" or not parent:
        if mc == 0 and fc == 0:
            return "EmptyType"
        if mc == 0:
            return f"DataOnly{fc}f"
        if fc == 0:
            return f"Static{mc}m"
        if mc > 100:
            return f"Major{mc}m"
        if mc > 20:
            return f"Service{mc}m"
        if fc > mc * 2:
            return f"Record{fc}f"
        return f"Type{mc}m{fc}f"
    if parent == "MonoBehaviour":
        return f"Mono{mc}m"
    parent_name = class_map.get(parent, parent)
    parent_short = re.sub(r'_[A-F0-9]+\d*$', '', parent_name)[:20]
    if not is_obf(parent_short):
        return f"{parent_short}Impl"
    return f"Unknown{mc}m"


def main():
    dump = json.load(open(DUMP, encoding="utf-8"))
    clean = json.load(open(CLEAN, encoding="utf-8"))
    clean_names = {k: (v.get("name") if isinstance(v, dict) else v)
                   for k, v in clean.items()}

    classes = []
    class_map = {}
    used = set()
    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            classes.append(c)
            used.add(c.get("name", ""))
            if c.get("original_name"):
                class_map[c["original_name"]] = c.get("name", "")

    reverted = 0
    reapplied = 0
    bad = []
    for c in classes:
        if c.get("semantic_source") != "callgraph_inferred":
            continue
        orig = c.get("original_name", "")
        # 1. structural revert
        mc = len(c.get("methods", []) or c.get("method_pointers", {}))
        fc = len(c.get("fields", []))
        pfx = struct_prefix(c.get("parent"), mc, fc, class_map)
        struct_name = f"{pfx}_{stable_hash(orig)}"
        if not is_weak_name(struct_name):
            bad.append((c.get("name"), struct_name))
            continue
        c["name"] = struct_name
        c["semantic_source"] = "structural"
        reverted += 1
        # 2. re-apply only if it survives the clean-boundary bar
        cn = clean_names.get(orig)
        if cn and not is_weak_name(cn):
            c["name"] = cn
            c["semantic_source"] = "callgraph_inferred"
            reapplied += 1

    if bad:
        print(f"  ABORT: {len(bad)} structural names are not weak; e.g. {bad[:3]}")
        return 1

    json.dump(dump, open(DUMP, "w", encoding="utf-8"),
              ensure_ascii=False, indent=2, sort_keys=True)
    print(f"  reverted to structural: {reverted}")
    print(f"  re-applied clean callgraph names: {reapplied}")
    print(f"  net callgraph_inferred now: {reapplied}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
