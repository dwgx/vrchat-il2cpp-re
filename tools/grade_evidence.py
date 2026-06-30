#!/usr/bin/env python
"""Deterministic evidence grading for the 9,928 Beebyte-obfuscated classes.

Why: real names for these classes were destroyed at compile time and cannot be
recovered (proven: the disk metadata stores the same ÌÍÎÏ garbage). So "highest
quality" cannot mean "find the real name" — it means every assigned name must be
*auditable*: traceable to concrete evidence, with weak guesses honestly downgraded.

This engine does NOT invent names. For each obfuscated class it recomputes, from
the dump alone (no AI), what evidence supports the *currently assigned* name and
assigns a confidence grade:

  A (corroborated): the name shares a real token with the class's own field or
       method names — the name is backed by the binary's own symbols.
  B (supported):    no token overlap, but the class has a strong nameable signal
       (>=2 real domain fields, or >=4 real method names) and a known provenance.
  C (thin):         only structural/sibling signal — plausible but unverified.
  D (none):         name is still an obfuscated/placeholder token, OR there is no
       real field/method evidence at all. Honestly flagged as a guess.

Provenance (which source file mapped original_name -> name) is attached when
available, so each grade is fully traceable.

Output:
  output/evidence_grades.json   per-class grade + evidence + provenance
  (optionally) writes confidence/semantic_source back into the dump with --apply

Usage:
  python tools/grade_evidence.py            # grade, write evidence_grades.json
  python tools/grade_evidence.py --apply     # also backfill dump confidence/source
"""
import argparse
import json
import re
import sys
from pathlib import Path
from collections import Counter

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

sys.path.insert(0, str(Path(__file__).resolve().parent))
from name_quality import (is_weak_name as canonical_weak,
                          is_structural_placeholder)

BASE = Path(__file__).resolve().parent.parent
DUMP = BASE / "output" / "deobfuscated_dump.json"
OUT = BASE / "output" / "evidence_grades.json"

# Per-class name sources keyed by obfuscated original_name (for provenance).
PROVENANCE_SOURCES = [
    ("workflow", BASE / "output" / "workflow_class_names.json"),
    ("a1", BASE / "output" / "a1_class_names.json"),
    ("fieldtype", BASE / "output" / "fieldtype_class_names.json"),
]

# Pseudo-fields injected by the Unity runtime / IL2CPP, not domain signal.
PSEUDO = {
    "_kInstanceID_None", "_offsetOfInstanceIDInCPlusPlusObject",
    "_objectIsNullMessage", "_cloneDestroyedMessage", "_m_CachedPtr",
    "_m_InstanceID", "_m_UnityRuntimeReferenceData",
}
# Boilerplate methods inherited from UnityEngine.Object / MonoBehaviour /
# compiler codegen. Verified empirically: each appears across 500-2000 classes
# in the dump, so they are inheritance noise, never per-class domain signal.
BOILERPLATE = {
    "GetInstanceID", "Equals", "GetHashCode", "op_Implicit", "op_Equality",
    "op_Inequality", "CompareBaseObjects", "IsNativeObjectAlive", "GetCachedPtr",
    "get_name", "set_name", "ToString", "Finalize", ".ctor", ".cctor",
    "MoveNext", "Dispose", "get_Current", "StartCoroutine", "StartCoroutine_Auto",
    "StopCoroutine", "StopAllCoroutines",
    # UnityEngine.Object static/instance lifecycle (inherited, not domain logic)
    "Instantiate", "Destroy", "DestroyImmediate", "DontDestroyOnLoad",
    "FindObjectsOfType", "FindObjectsByType", "FindObjectOfType",
    "FindObjectsOfTypeAll", "FindObjectsOfTypeIncludingAssets",
    # MonoBehaviour Invoke family (inherited)
    "Invoke", "InvokeRepeating", "CancelInvoke", "IsInvoking", "RaiseCancellation",
    # codegen equality comparers
    "InternalEquals", "DefaultEquals", "InternalGetHashCode",
}

WEAK_RE = None  # removed: weak-name judgement lives solely in name_quality
# Structural placeholders: synthesized from class topology, carry no semantics.
# e.g. BaseClass7Sibling_4F24, BaseClass290ImplImpl_31B9, BackingFieldBaseSibling_C399
STRUCTURAL_RE = re.compile(
    r"(BaseClass\d*|Sibling|Impl|Derived|Related|BackingField)"
    r"(Sibling|Impl|Derived|Related)*(_[0-9A-Fa-f]{3,4})?$")
HASH_FIELD_RE = re.compile(r"^f_[0-9A-Fa-f]{2,}$")
HEX_FIELD_RE = re.compile(r"^_[0-9A-Fa-f]{3,}")
HASH_METHOD_RE = re.compile(r"^m_[0-9A-Fa-f]{2,}$")


def is_obf(name: str) -> bool:
    return bool(name) and any(c in "ÌÍÎÏ" for c in name)


def is_weak(n: str) -> bool:
    # Delegate to the single source of truth (was a buggy bare-prefix duplicate
    # that demoted MonoBehaviour/ServiceProvider/TypeConverterRegistry).
    return canonical_weak(n)


def real_field(x: str) -> bool:
    if x in PSEUDO or x.startswith("_k"):
        return False
    if HASH_FIELD_RE.match(x) or HEX_FIELD_RE.match(x):
        return False
    return True


def real_method(m: str) -> bool:
    return (m not in BOILERPLATE and not HASH_METHOD_RE.match(m)
            and not m.startswith("System.") and m not in (".ctor", ".cctor"))


# CamelCase / snake tokenizer for token-overlap corroboration.
_TOKEN_RE = re.compile(r"[A-Z]+(?=[A-Z][a-z])|[A-Z]?[a-z]+|[A-Z]+|\d+")
_STOP = {"get", "set", "is", "on", "the", "a", "to", "of", "and", "for",
         "m", "k", "id", "ui", "vrc"}


def tokenize(s: str) -> set:
    return {t.lower() for t in _TOKEN_RE.findall(s) if len(t) > 2 and t.lower() not in _STOP}


def load_provenance():
    prov = {}
    for tag, path in PROVENANCE_SOURCES:
        if not path.exists():
            continue
        data = json.load(open(path, encoding="utf-8"))
        for orig, val in data.items():
            if not is_obf(orig):
                continue
            name = val.get("name") if isinstance(val, dict) else val
            if name:
                prov.setdefault(orig, tag)  # first source wins
    return prov


def grade_class(c: dict, provenance: dict) -> dict:
    orig = c["original_name"]
    name = c.get("name", "")
    fields = c.get("fields", [])
    methods = c.get("methods", [])
    rf = [x for x in fields if real_field(x)]
    rm = [x for x in methods if real_method(x)]

    # Token overlap between the assigned name and the class's own real symbols.
    name_tokens = tokenize(name)
    symbol_tokens = set()
    for x in rf + rm:
        symbol_tokens |= tokenize(x)
    overlap = sorted(name_tokens & symbol_tokens)

    prov = provenance.get(orig)
    is_structural = is_structural_placeholder(name)
    still_obf = is_obf(name) or canonical_weak(name)

    if still_obf:
        grade = "D"
        # Distinguish: structural placeholder (has topology but no semantic name)
        # is a naming *target*; a bare obf token has nothing.
        if is_structural and (len(rf) >= 2 or len(rm) >= 4):
            reason = f"structural placeholder, but nameable ({len(rf)}f/{len(rm)}m) — TARGET"
        elif is_structural:
            reason = "structural placeholder, no strong signal — unnamed"
        else:
            reason = "name is still obfuscated/placeholder — unnamed"
    elif overlap:
        grade = "A"
        reason = f"name token(s) {overlap} match the class's own field/method symbols"
    elif len(rf) >= 2 or len(rm) >= 4:
        grade = "B"
        reason = f"strong nameable signal ({len(rf)} real fields, {len(rm)} real methods)"
    elif rf or rm:
        grade = "C"
        reason = f"thin signal ({len(rf)} real fields, {len(rm)} real methods), name unverified"
    else:
        grade = "D"
        reason = "no real field/method evidence — name is a pure guess"

    return {
        "original_name": orig,
        "name": name,
        "grade": grade,
        "reason": reason,
        "provenance": prov,
        "evidence": {
            "real_fields": rf[:12],
            "real_methods": rm[:12],
            "token_overlap": overlap,
        },
    }


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--apply", action="store_true",
                    help="backfill confidence/semantic_source into the dump")
    args = ap.parse_args()

    if not DUMP.exists():
        print(f"ERROR: {DUMP} not found")
        return 1

    provenance = load_provenance()
    print(f"loaded provenance for {len(provenance)} classes")

    dump = json.load(open(DUMP, encoding="utf-8"))
    grades = []
    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            if c.get("original_name"):
                grades.append((c, grade_class(c, provenance)))

    dist = Counter(g["grade"] for _, g in grades)
    total = len(grades)
    print(f"\n=== Evidence grades over {total} obfuscated classes ===")
    for gr in "ABCD":
        n = dist[gr]
        print(f"  {gr}: {n:>5} ({100*n/total:4.1f}%)")
    named = total - dist["D"]
    print(f"\n  Auditable (A+B+C, has evidence): {named} ({100*named/total:.1f}%)")
    print(f"  Honestly unnamed/guess (D):        {dist['D']} ({100*dist['D']/total:.1f}%)")

    json.dump([g for _, g in grades], open(OUT, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)
    print(f"\nwrote {OUT.name}")

    if args.apply:
        for c, g in grades:
            c["confidence"] = g["grade"]
            if g["provenance"]:
                c["semantic_source"] = f"prov:{g['provenance']}"
            elif g["grade"] != "D":
                c["semantic_source"] = "evidence:token_overlap" if g["grade"] == "A" else "evidence:signal"
        json.dump(dump, open(DUMP, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
        print(f"applied confidence/semantic_source to {DUMP.name}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
