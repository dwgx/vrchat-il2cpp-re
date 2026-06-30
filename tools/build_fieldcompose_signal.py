#!/usr/bin/env python
"""Field-composition miner (data-holder naming signal).

Third method-body-era signal, but reads STRUCTURE not code: for a weak class whose
field NAMES are obfuscated, the field TYPES often still reference clean domain
types/namespaces (Mediapipe.ImageFrame, Transmtn.Notifications.Notification,
VRC.Core.ApiWorld, ...). The composition of domain field-types reveals what the
class HOLDS -> a data-holder name. Catches plain structs/classes that strings and
call-targets miss (data carriers have no string literals and few direct calls).

Tokenizes each field type, keeps clean domain tokens, drops BCL primitives and
async/generic plumbing (UniTask/Cysharp.Threading/Func/Action/Dictionary/...),
requires >=2 distinct DOMAIN tokens. Emits output/fieldcompose_signal_raw.json
keyed by obfuscated class name. Feed to subagents -> fieldcompose_class_names.json
(tag field_composition).

Result 2026-06-29: 218 weak classes with field-type tokens -> 71 after dropping
plumbing-only -> 55 named = 55 NEW distinct source types. semantic_pct 60.2%->
60.7%, source_types 60.9%->61.6% (+0.7, BETTER per-name than call-target because
these are distinct structs with no generic-instance inflation). See
RE_EXTRACT_STRUCTURAL_SIGNALS.md item 12.

Usage:
  python tools/build_fieldcompose_signal.py
(reads data/precise_dump_unity6_typed.json + output/deobfuscated_dump.json; no dump
needed - this signal is pure metadata, unlike the disasm miners.)
"""
import argparse
import json
import re
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from name_quality import is_weak_name  # noqa: E402

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
_BEEBYTE = set("ÌÍÎÏ")
# BCL primitives + namespace noise: stripped from the token stream.
PRIM = {"Int32", "Single", "Boolean", "String", "Object", "Byte", "Int64",
        "UInt32", "List", "Nullable", "Double", "System", "Collections",
        "Generic", "UnityEngine"}
# async / generic plumbing: present but never discriminative of a data role.
PLUMB = {"Cysharp", "Threading", "Tasks", "UniTask", "UniTaskVoid",
         "UniTaskCompletionSource", "Func", "Action", "Dictionary",
         "IEnumerable", "ValueTuple", "ZLinq", "ValueEnumerable", "Linq",
         "Index", "genericinst", "genericparam", "Task", "Type", "Nullable",
         "IEnumerator", "List", "Tuple"}
PRIOR = ["field_type_class_names.json", "method_return_class_names.json",
         "method_param_class_names.json", "combined_type_class_names.json",
         "interface_class_names.json", "string_literal_class_names.json",
         "calltarget_class_names.json", "fieldcompose_class_names.json"]


def clean(s):
    return s and not any(ch in _BEEBYTE for ch in s)


def domain_tokens(typestr):
    toks = []
    for p in re.findall(r'[A-Za-z_][A-Za-z0-9_]+', typestr or ""):
        if clean(p) and p not in PRIM:
            toks.append(p)
    return toks


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--typed", default=str(BASE / "data" / "precise_dump_unity6_typed.json"))
    ap.add_argument("--deobf", default=str(BASE / "output" / "deobfuscated_dump.json"))
    ap.add_argument("--out", default=str(BASE / "output" / "fieldcompose_signal_raw.json"))
    ap.add_argument("--min-domain", type=int, default=2)
    args = ap.parse_args()

    deobf = json.loads(Path(args.deobf).read_text(encoding="utf-8"))
    weak, seen = set(), set()
    for cl in deobf["namespaces"].values():
        for c in cl:
            o = c.get("original_name")
            if o and o not in seen:
                seen.add(o)
                if is_weak_name(c.get("name", "")):
                    weak.add(o)

    used = set()
    for fn in PRIOR:
        p = BASE / "output" / fn
        if p.exists():
            used |= set(json.loads(p.read_text(encoding="utf-8")))

    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))
    res, checked = [], set()
    for cl in typed["namespaces"].values():
        for c in cl:
            nm = c["name"]
            if nm in checked or nm not in weak or nm in used:
                continue
            checked.add(nm)
            ft = c.get("field_types", {})
            if not isinstance(ft, dict) or not ft:
                continue
            toks, s2 = [], set()
            for _fn, t in ft.items():
                for tok in domain_tokens(t):
                    if (tok not in s2 and len(tok) >= 4 and tok not in PRIM):
                        s2.add(tok)
                        toks.append(tok)
            domain = [t for t in toks if t not in PLUMB]
            if len(domain) >= args.min_domain:
                res.append({"obf": nm, "ns": c.get("namespace", ""),
                            "domain": domain[:10], "types": toks[:12]})
    res.sort(key=lambda r: -len(r["domain"]))
    Path(args.out).write_text(json.dumps(res, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] {len(res)} weak classes with >={args.min_domain} domain "
          f"field-type tokens -> {args.out}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
