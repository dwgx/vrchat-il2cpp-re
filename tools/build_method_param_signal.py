#!/usr/bin/env python
"""Method-parameter-type naming signal for weak (fallback-named) classes.

Third structural-signal miner, after build_field_type_signal.py and
build_method_return_signal.py. The Unity 6 extractor now emits
`method_param_types` per class: MethodInfo.parameters (MI_PARAMS=0x28, count at
MI_PCOUNT=0x4A) resolved via the same handle->name map. Constructor / setter /
handler parameter types expose a class's *inputs* and dependencies, often more
sharply than return types (e.g. a .ctor taking VRCAvatarDescriptor + ApiWorld
names an avatar-world binder even with generic fields and void methods).

This mines parameter types for weak classes that NEITHER the field-type pass
(field_type_class_names.json) NOR the return-type pass
(method_return_class_names.json) could name, so all three passes stay disjoint.
Per class: collect discriminative (non-primitive, non-obfuscated, resolvable)
parameter types across all methods, weight by global rarity (idf over the
param-type corpus), score = sum of the top-N type idfs.

Usage:
  python tools/build_method_param_signal.py
  -> output/method_param_signal.json
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
DEFAULT_MRNAMES = BASE / "output" / "method_return_class_names.json"
DEFAULT_OUT = BASE / "output" / "method_param_signal.json"

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
    return t.split(".")[-1]


def is_weak(c: dict) -> bool:
    src = c.get("semantic_source", "(none)")
    if src in ("(none)", "structural"):
        return True
    return any(ch in _BEEBYTE for ch in c.get("name", ""))


def load_names(path: Path) -> set:
    if path.exists():
        return set(json.loads(path.read_text(encoding="utf-8")))
    return set()


def main() -> int:
    ap = argparse.ArgumentParser(
        description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--typed", default=str(DEFAULT_TYPED))
    ap.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    ap.add_argument("--ft-names", default=str(DEFAULT_FTNAMES))
    ap.add_argument("--mr-names", default=str(DEFAULT_MRNAMES))
    ap.add_argument("--out", default=str(DEFAULT_OUT))
    ap.add_argument("--top-types", type=int, default=5)
    args = ap.parse_args()

    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))
    # obf_name -> {method: [param_type, ...]}
    mpar = {}
    for classes in typed["namespaces"].values():
        for c in classes:
            pt = c.get("method_param_types")
            if pt:
                mpar[c["name"]] = pt
    print(f"[typed] {len(mpar)} classes with resolved method param types")

    # idf over the param-type corpus (per-class distinct clean types).
    df = Counter()
    for pt in mpar.values():
        seen = set()
        for plist in pt.values():
            seen.update(p for p in plist if is_clean_type(p))
        df.update(seen)
    N = max(len(mpar), 1)
    idf = {t: math.log(N / c) for t, c in df.items()}

    deobf = json.loads(Path(args.deobf).read_text(encoding="utf-8"))
    weak_obf = {c.get("original_name") for cl in deobf["namespaces"].values()
                for c in cl if is_weak(c)}
    cur_name = {c.get("original_name"): c.get("name")
                for cl in deobf["namespaces"].values() for c in cl}

    already = load_names(Path(args.ft_names)) | load_names(Path(args.mr_names))

    signals = []
    for obf, pt in mpar.items():
        if obf not in weak_obf or obf in already:
            continue
        # flatten to (method, param_type) for clean types, dedup per method+type
        pairs = []
        for m, plist in pt.items():
            for p in plist:
                if is_clean_type(p):
                    pairs.append((m, p))
        if not pairs:
            continue
        # rank by idf; keep the top-N DISTINCT types (one representative method
        # each) so the signal shows variety, not the same type repeated.
        pairs.sort(key=lambda mp: idf.get(mp[1], 0.0), reverse=True)
        seen_t = set()
        top = []
        for m, t in pairs:
            if t in seen_t:
                continue
            seen_t.add(t)
            top.append((m, t))
            if len(top) >= args.top_types:
                break
        score = sum(idf.get(t, 0.0) for _, t in top)
        signals.append({
            "obf_name": obf,
            "current_name": cur_name.get(obf, ""),
            "score": round(score, 3),
            "distinct_types": len({t for _, t in pairs}),
            "signal_params": [{"method": m, "type": t} for m, t in top],
        })

    signals.sort(key=lambda r: r["score"], reverse=True)
    out = {
        "summary": {
            "classes_with_param_types": len(mpar),
            "weak_unnamed_with_signal": len(signals),
            "idf_corpus_size": N,
            "note": "method parameter types; excludes classes already named by "
                    "the field-type and method-return passes (disjoint).",
        },
        "signals": signals,
    }
    Path(args.out).write_text(json.dumps(out, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] weak_unnamed_with_signal={len(signals)} -> {args.out}")
    print("\nTop 12 method-param-type signals:")
    for r in signals[:12]:
        ts = ", ".join(short(s["type"]) for s in r["signal_params"])
        print(f"  {r['score']:6.2f}  {r['current_name'][:30]:30}  [{ts}]")
    return 0


if __name__ == "__main__":
    sys.exit(main())
