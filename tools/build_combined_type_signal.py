#!/usr/bin/env python
"""Unified tri-signal naming miner: field + return + param types combined.

The Unity 6 extractor now resolves three orthogonal Il2CppType signals per class
from a single dump: field declared types (FI_TYPE), method return types
(MI_RETTYPE=0x18), and method parameter types (MI_PARAMS=0x28 / MI_PCOUNT=0x4A).
The three single-signal passes (build_field_type_signal /
build_method_return_signal / build_method_param_signal) each name a class only
when THAT signal alone is discriminative. But a class can be unnameable from any
one signal yet clearly typed from their UNION — e.g. fields give Transform,
returns give nothing, params give Canvas + RectTransform: together "UI layout".

This miner unions all three type sets per weak, still-unnamed class (disjoint
from all three prior passes), idf-weights over the combined corpus, and emits
ranked multi-type candidates (union >= 2 distinct clean types).

Usage:
  python tools/build_combined_type_signal.py
  -> output/combined_type_signal.json
"""
import argparse
import json
import math
import sys
from collections import Counter
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from type_signal_common import clean_type_tokens, short  # noqa: E402

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE = Path(__file__).resolve().parent.parent
DEFAULT_TYPED = BASE / "data" / "precise_dump_unity6_typed.json"
DEFAULT_DEOBF = BASE / "output" / "deobfuscated_dump.json"
DEFAULT_OUT = BASE / "output" / "combined_type_signal.json"
PRIOR_NAMES = [
    BASE / "output" / "field_type_class_names.json",
    BASE / "output" / "method_return_class_names.json",
    BASE / "output" / "method_param_class_names.json",
]

_BEEBYTE = set("ÌÍÎÏ")
_PRIM = {
    "Single", "Int32", "Boolean", "UInt32", "Byte", "Int64", "Double", "String",
    "Char", "Object", "UInt64", "Int16", "UInt16", "SByte", "IntPtr", "UIntPtr",
    "Void",
}
_NOISE = {
    "Action", "Func", "Task", "ValueTask", "IEnumerator", "IEnumerable",
    "CancellationToken", "CancellationTokenSource", "Type", "Exception",
}


def is_clean_type(t: str) -> bool:
    if not t or t.startswith("<"):
        return False
    if any(c in _BEEBYTE for c in t):
        return False
    last = t.split(".")[-1].split("`")[0]
    return last not in _PRIM and last not in _NOISE


def short(t: str) -> str:
    return t.split(".")[-1].split("`")[0]


def is_weak(c: dict) -> bool:
    src = c.get("semantic_source", "(none)")
    if src in ("(none)", "structural"):
        return True
    return any(ch in _BEEBYTE for ch in c.get("name", ""))


def class_types(c: dict) -> dict:
    """Return {clean_short_type: source_tag} unioned across field/return/param.

    Uses clean_type_tokens so generic instances contribute their INNER argument
    types (List<ApiWorldInstance> -> ApiWorldInstance), not just the outer shell.
    First-seen source wins for a given type.
    """
    out = {}
    for t in c.get("field_types", {}).values():
        for s in clean_type_tokens(t):
            out.setdefault(s, "field")
    for t in c.get("method_return_types", {}).values():
        for s in clean_type_tokens(t):
            out.setdefault(s, "return")
    for plist in c.get("method_param_types", {}).values():
        for t in plist:
            for s in clean_type_tokens(t):
                out.setdefault(s, "param")
    return out


def main() -> int:
    ap = argparse.ArgumentParser(
        description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--typed", default=str(DEFAULT_TYPED))
    ap.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    ap.add_argument("--out", default=str(DEFAULT_OUT))
    ap.add_argument("--top-types", type=int, default=6)
    ap.add_argument("--min-distinct", type=int, default=2)
    args = ap.parse_args()

    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))
    deobf = json.loads(Path(args.deobf).read_text(encoding="utf-8"))
    weak_obf = {c.get("original_name") for cl in deobf["namespaces"].values()
                for c in cl if is_weak(c)}
    cur_name = {c.get("original_name"): c.get("name")
                for cl in deobf["namespaces"].values() for c in cl}

    already = set()
    for p in PRIOR_NAMES:
        if p.exists():
            already |= set(json.loads(p.read_text(encoding="utf-8")))

    # idf over the combined per-class distinct-type corpus.
    df = Counter()
    per_class = {}
    for cl in typed["namespaces"].values():
        for c in cl:
            ct = class_types(c)
            per_class[c["name"]] = (c, ct)
            df.update(ct.keys())
    N = max(len(per_class), 1)
    idf = {t: math.log(N / c) for t, c in df.items()}

    signals = []
    for obf, (c, ct) in per_class.items():
        if obf not in weak_obf or obf in already:
            continue
        if len(ct) < args.min_distinct:
            continue
        ranked = sorted(ct.items(), key=lambda kv: idf.get(kv[0], 0.0),
                        reverse=True)[:args.top_types]
        score = sum(idf.get(t, 0.0) for t, _ in ranked)
        signals.append({
            "obf_name": obf,
            "current_name": cur_name.get(obf, ""),
            "namespace": c.get("namespace", ""),
            "score": round(score, 3),
            "distinct_types": len(ct),
            "signal_types": [{"type": t, "source": s} for t, s in ranked],
            "methods": c.get("methods", [])[:8],
        })

    signals.sort(key=lambda r: r["score"], reverse=True)
    out = {
        "summary": {
            "classes_scanned": len(per_class),
            "weak_unnamed_with_union_signal": len(signals),
            "idf_corpus_size": N,
            "note": "union of field + method-return + method-param Il2CppType "
                    "signals; disjoint from all three single-signal passes.",
        },
        "signals": signals,
    }
    Path(args.out).write_text(json.dumps(out, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] weak_unnamed_with_union_signal={len(signals)} -> {args.out}")
    print("\nTop 12 combined-type signals:")
    for r in signals[:12]:
        ts = ", ".join(f"{short(s['type'])}({s['source'][0]})"
                       for s in r["signal_types"])
        print(f"  {r['score']:6.2f} [{r['distinct_types']}]  "
              f"{r['current_name'][:24]:24}  [{ts}]")
    return 0


if __name__ == "__main__":
    sys.exit(main())
