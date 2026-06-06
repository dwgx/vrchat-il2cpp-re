#!/usr/bin/env python3
"""Analyze remaining unnamed hash methods to design naming strategy."""
import json
import re
import sys
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")

BASE = Path(__file__).resolve().parent.parent
dump_data = json.loads((BASE / "output/deobfuscated_dump.json").read_text(encoding="utf-8"))
cv = json.loads((BASE / "output/cross_version_method_names.json").read_text(encoding="utf-8"))

HASH_RE = re.compile(r"^m_[0-9A-F]{3}$")

all_classes = []
for ns, classes in dump_data.get("namespaces", {}).items():
    for cls in classes:
        cls["_ns"] = ns
        all_classes.append(cls)

hash_methods = []
classes_with_hash = {}
named_siblings = defaultdict(list)
has_pointers = 0
shared_pointers = defaultdict(list)  # RVA -> list of (class, method)

for cls in all_classes:
    cname = cls.get("name", "")
    methods = cls.get("methods", [])
    pointers = cls.get("method_pointers", {})
    h_count = 0
    n_siblings = []
    for mname in methods:
        if not isinstance(mname, str):
            continue
        key = f"{cname}::{mname}"
        if HASH_RE.match(mname) and key not in cv:
            h_count += 1
            rva = pointers.get(mname, "")
            hash_methods.append({
                "class": cname,
                "method": mname,
                "key": key,
                "rva": rva,
                "ns": cls.get("_ns", ""),
                "parent": cls.get("parent", ""),
            })
            if rva:
                shared_pointers[rva].append((cname, mname))
        elif not HASH_RE.match(mname) and mname not in (".ctor", ".cctor"):
            n_siblings.append(mname)
    if h_count > 0:
        classes_with_hash[cname] = h_count
        if n_siblings:
            named_siblings[cname] = n_siblings
    if pointers:
        has_pointers += 1

print(f"Total hash methods remaining: {len(hash_methods):,}")
print(f"Classes with hash methods: {len(classes_with_hash):,}")
print(f"Avg hash/class: {len(hash_methods)/max(len(classes_with_hash),1):.1f}")
print()

# Distribution by hash count per class
dist = Counter()
for c, n in classes_with_hash.items():
    if n == 1: dist["1"] += 1
    elif n <= 3: dist["2-3"] += 1
    elif n <= 10: dist["4-10"] += 1
    elif n <= 30: dist["11-30"] += 1
    else: dist["31+"] += 1

print("Classes by hash method count:")
for k in ["1", "2-3", "4-10", "11-30", "31+"]:
    print(f"  {k}: {dist.get(k, 0)}")

# Named siblings analysis
with_siblings = sum(1 for c in classes_with_hash if c in named_siblings)
without_siblings = len(classes_with_hash) - with_siblings
print(f"\nClasses with named siblings: {with_siblings} ({with_siblings*100/len(classes_with_hash):.0f}%)")
print(f"Classes with NO named siblings: {without_siblings} ({without_siblings*100/len(classes_with_hash):.0f}%)")

hash_with_sibs = sum(classes_with_hash[c] for c in classes_with_hash if c in named_siblings)
hash_without_sibs = len(hash_methods) - hash_with_sibs
print(f"Hash methods with named siblings: {hash_with_sibs:,} ({hash_with_sibs*100/len(hash_methods):.0f}%)")
print(f"Hash methods without named siblings: {hash_without_sibs:,} ({hash_without_sibs*100/len(hash_methods):.0f}%)")

# RVA sharing (same pointer = same underlying function)
shared_rva_groups = {rva: entries for rva, entries in shared_pointers.items()
                     if len(entries) > 1 and rva}
shared_method_count = sum(len(e) for e in shared_rva_groups.values())
unique_rvas = len(set(m["rva"] for m in hash_methods if m["rva"]))
print(f"\nMethods with RVA: {sum(1 for m in hash_methods if m['rva']):,}")
print(f"Unique RVAs: {unique_rvas:,}")
print(f"Shared RVA groups (>1 method): {len(shared_rva_groups):,} groups, {shared_method_count:,} methods")

# RVA sharing with NAMED methods (key insight: if hash method shares RVA with known method)
named_by_rva = {}
for cls in all_classes:
    cname = cls.get("name", "")
    pointers = cls.get("method_pointers", {})
    for mname, rva in pointers.items():
        if not HASH_RE.match(mname) and mname not in (".ctor", ".cctor") and rva:
            named_by_rva[rva] = mname

nameable_by_rva = 0
for m in hash_methods:
    if m["rva"] and m["rva"] in named_by_rva:
        nameable_by_rva += 1
print(f"Hash methods with same RVA as a named method: {nameable_by_rva:,}")

# Parent class distribution
parent_dist = Counter(m["parent"] for m in hash_methods if m["parent"])
print(f"\nMethods with parent class info: {sum(1 for m in hash_methods if m['parent']):,}")
print("Top parent classes:")
for p, c in parent_dist.most_common(10):
    print(f"  {p}: {c:,}")

# Namespace distribution
ns_dist = Counter(m["ns"] for m in hash_methods)
print("\nTop namespaces:")
for ns, c in ns_dist.most_common(15):
    display = ns if ns else "(global)"
    print(f"  {display}: {c:,}")

# Strategy summary
print("\n" + "="*60)
print("NAMING STRATEGY OPPORTUNITIES")
print("="*60)
print(f"\n1. RVA-based naming: {nameable_by_rva:,} methods share RVA with known methods")
print(f"2. Sibling context: {hash_with_sibs:,} methods have named siblings in same class")
print(f"3. Structural only: {hash_without_sibs:,} methods with NO sibling context")
print(f"4. RVA dedup: {shared_method_count:,} methods in shared-RVA groups")
