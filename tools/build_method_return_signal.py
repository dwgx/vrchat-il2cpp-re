#!/usr/bin/env python
"""Method-return-type naming signal for weak (fallback-named) classes.

Complements build_field_type_signal.py. The Unity 6 extractor
(extract_reverse_unity6.py, typed by default) now resolves MethodInfo.return_type
(MI_RETTYPE=0x18) to a readable name via the same handle->name map that resolves
field types. A class's method return types are an independent structural signal:
a class whose methods return ApiProp / SpawnType / PropKind is a prop system
class even when every field is a bare GameObject.

This tool mines that signal for weak classes that the field-type pass could NOT
name (output/field_type_class_names.json), so the two passes don't overlap. Per
class: collect discriminative (non-primitive, non-obfuscated, resolvable) return
types, weight by global rarity (idf over the return-type corpus), score = sum of
the top-N type idfs. Emits ranked candidates for a naming pass.

Usage:
  python tools/build_method_return_signal.py
  -> output/method_return_signal.json
"""
import argparse
import json
import math
import sys
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE = Path(__file__).resolve().parent.parent
DEFAULT_TYPED = BASE / "data" / "precise_dump_unity6_typed.json"
DEFAULT_DEOBF = BASE / "output" / "deobfuscated_dump.json"
DEFAULT_FTNAMES = BASE / "output" / "field_type_class_names.json"
DEFAULT_OUT = BASE / "output" / "method_return_signal.json"

_BEEBYTE = set("ÌÍÎÏ")
_PRIM = {
    "Single", "Int32", "Boolean", "UInt32", "Byte", "Int64", "Double", "String",
    "Char", "Object", "UInt64", "Int16", "UInt16", "SByte", "IntPtr", "UIntPtr",
    "Void",
}
# Low-signal plumbing types that say little about a class's domain.
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
    return t.split(".")[-1]


def is_weak(c: dict) -> bool:
    src = c.get("semantic_source", "(none)")
    if src in ("(none)", "structural"):
        return True
    return any(ch in _BEEBYTE for ch in c.get("name", ""))


def main() -> int:
    ap = argparse.ArgumentParser(
        description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--typed", default=str(DEFAULT_TYPED))
    ap.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    ap.add_argument("--ft-names", default=str(DEFAULT_FTNAMES))
    ap.add_argument("--out", default=str(DEFAULT_OUT))
    ap.add_argument("--top-types", type=int, default=5)
    args = ap.parse_args()

    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))
    # obf_name -> {method: return_type}
    mret = {}
    for classes in typed["namespaces"].values():
        for c in classes:
            rt = c.get("method_return_types")
            if rt:
                mret[c["name"]] = rt
    print(f"[typed] {len(mret)} classes with resolved method return types")

    # idf over the return-type corpus.
    df = Counter()
    for rt in mret.values():
        df.update({t for t in rt.values() if is_clean_type(t)})
    N = max(len(mret), 1)
    idf = {t: math.log(N / c) for t, c in df.items()}

    deobf = json.loads(Path(args.deobf).read_text(encoding="utf-8"))
    weak_obf = {c.get("original_name") for cl in deobf["namespaces"].values()
                for c in cl if is_weak(c)}
    cur_name = {c.get("original_name"): c.get("name")
                for cl in deobf["namespaces"].values() for c in cl}

    # exclude classes already named by the field-type pass (no overlap)
    ft_named = set(json.loads(Path(args.ft_names).read_text(encoding="utf-8"))) \
        if Path(args.ft_names).exists() else set()

    signals = []
    for obf, rt in mret.items():
        if obf not in weak_obf or obf in ft_named:
            continue
        clean = [(m, t) for m, t in rt.items() if is_clean_type(t)]
        if not clean:
            continue
        clean.sort(key=lambda mt: idf.get(mt[1], 0.0), reverse=True)
        top = clean[:args.top_types]
        score = sum(idf.get(t, 0.0) for _, t in top)
        signals.append({
            "obf_name": obf,
            "current_name": cur_name.get(obf, ""),
            "score": round(score, 3),
            "distinct_types": len({t for _, t in clean}),
            "signal_returns": [{"method": m, "type": t} for m, t in top],
        })

    signals.sort(key=lambda r: r["score"], reverse=True)
    out = {
        "summary": {
            "classes_with_return_types": len(mret),
            "weak_unnamed_with_signal": len(signals),
            "idf_corpus_size": N,
            "note": "method return types are an independent signal from field "
                    "types; this set excludes field-type-named classes.",
        },
        "signals": signals,
    }
    Path(args.out).write_text(json.dumps(out, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] weak_unnamed_with_signal={len(signals)} -> {args.out}")
    print("\nTop 12 method-return-type signals:")
    for r in signals[:12]:
        ts = ", ".join(short(s["type"]) for s in r["signal_returns"])
        print(f"  {r['score']:6.2f}  {r['current_name'][:30]:30}  [{ts}]")
    return 0


if __name__ == "__main__":
    sys.exit(main())
