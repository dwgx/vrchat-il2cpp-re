#!/usr/bin/env python
"""Collect the 12 naming-agent slice results, gate every proposed name through
name_quality.is_weak_name (宁缺毋滥: reject anything structural/weak), and emit a
name-source file keyed by the class's ORIGINAL (obfuscated) name so
apply_class_names.py can merge it idempotently.

A proposal survives only if:
  - proposed_name is not null/empty
  - it passes is_weak_name == False (real domain name, not BaseClass/Type/hex)
  - the obf class actually exists in the deob dump with an original_name

Output: output/decompile_class_names.json  ->  {original_name: semantic_name}
(add this path to apply_class_names.py SOURCES).
"""
import json
import re
import sys
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(BASE / "tools"))
from name_quality import is_weak_name

RESULTS = BASE / "output" / "p2_research" / "naming_results"
DEOB = BASE / "output" / "deobfuscated_dump.json"
OUT = BASE / "output" / "decompile_class_names.json"

# valid PascalCase domain identifier (no hex tails, not pure generic)
VALID = re.compile(r"^[A-Z][A-Za-z0-9]{2,}$")


def main():
    # STABLE obf_class -> original_name map (item 40): keyed off method EAs, which
    # never change, so the gate stays idempotent even after apply_class_names has
    # already renamed classes in the dump. Using the dump's mutable `name` field
    # broke re-runs (renamed classes became unfindable -> spurious no_orig).
    obf_map_path = BASE / "output" / "p2_research" / "obfclass_to_original.json"
    cur_to_orig = json.load(open(obf_map_path, encoding="utf-8"))

    # classes that have clean (collision-free) callee signal — only names backed
    # by clean signal are trustworthy (item 35: shared generic thunks create
    # false callees). Built from naming_batches_clean.json. We additionally
    # require >=1 DISTINCTIVE callee (item 37): even collision-free callees can be
    # generic accessors (UnityObjectWrapper, RegexCache::GetCachedPtr, ThrowHelper)
    # that appear across many unrelated classes and carry no domain signal.
    clean_path = BASE / "output" / "p2_research" / "naming_batches_clean.json"
    clean_v2 = BASE / "output" / "p2_research" / "naming_batches_v2.json"
    clean_signal = set()
    distinctive_signal = set()
    batches = []
    for p in (clean_path, clean_v2):
        if p.exists():
            batches.extend(json.load(open(p, encoding="utf-8")))
    if batches:
        freq = Counter()
        for b in batches:
            for c in set(b.get("all_callees", [])):
                freq[c] += 1

        def is_distinctive(callee):
            if "ThrowHelper" in callee or "GetCachedPtr" in callee:
                return False
            if "UnityObjectWrapper" in callee or "::Memcpy" in callee:
                return False
            return freq[callee] < 8

        for b in batches:
            if b.get("all_callees"):
                clean_signal.add(b["obf_class"])
                if any(is_distinctive(c) for c in b["all_callees"]):
                    distinctive_signal.add(b["obf_class"])
    print(f"classes with clean signal: {len(clean_signal)}, "
          f"with distinctive signal: {len(distinctive_signal)}")

    accepted = {}
    stats = {"total": 0, "null": 0, "weak_rejected": 0, "no_orig": 0,
             "bad_format": 0, "no_clean_signal": 0, "accepted": 0, "dup": 0}
    for f in sorted(RESULTS.glob("*slice_*.json")):
        try:
            rows = json.load(open(f, encoding="utf-8"))
        except Exception as ex:
            print(f"[skip] {f.name}: {ex}")
            continue
        for r in rows:
            stats["total"] += 1
            name = (r.get("proposed_name") or "").strip()
            obf = r.get("obf_class")
            if not name or name.lower() == "null":
                stats["null"] += 1
                continue
            if not VALID.match(name):
                stats["bad_format"] += 1
                continue
            if is_weak_name(name):
                stats["weak_rejected"] += 1
                continue
            # require DISTINCTIVE clean callee signal: a name backed only by
            # collision-tainted or generic-accessor callees is untrustworthy
            if obf not in distinctive_signal:
                stats["no_clean_signal"] += 1
                continue
            orig = cur_to_orig.get(obf)
            if not orig:
                stats["no_orig"] += 1
                continue
            if orig in accepted and accepted[orig] != name:
                stats["dup"] += 1
                continue
            accepted[orig] = name
            stats["accepted"] += 1

    # disambiguate duplicate names across distinct original classes: identical
    # class names break uniqueness, so suffix collisions _2, _3, ... (first
    # occurrence keeps the bare name). Sorted by orig for deterministic output.
    seen = {}
    disambiguated = {}
    dup_suffixed = 0
    for orig in sorted(accepted):
        name = accepted[orig]
        n = seen.get(name, 0) + 1
        seen[name] = n
        if n == 1:
            disambiguated[orig] = name
        else:
            disambiguated[orig] = f"{name}_{n}"
            dup_suffixed += 1
    accepted = disambiguated
    stats["dup_suffixed"] = dup_suffixed

    json.dump(accepted, open(OUT, "w", encoding="utf-8"),
              ensure_ascii=False, indent=2)
    print("gate stats:", json.dumps(stats, ensure_ascii=False))
    print(f"wrote {len(accepted)} gated names -> {OUT}")


if __name__ == "__main__":
    main()
