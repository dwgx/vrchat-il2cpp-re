#!/usr/bin/env python
"""Interface-implementation signal miner.

The Unity 6 extractor now records each class's implemented interfaces (see
extract_interfaces in extract_reverse_unity6.py, klass+CL_INTERFACES=0xB0). A
class's interfaces are a strong role signal that is ORTHOGONAL to its field /
return / param types: a weak class implementing IPointerClickHandler +
IPointerEnterHandler + IPointerExitHandler is clearly a UI pointer-event target
regardless of what types its fields hold.

This miner scores weak, still-unnamed classes (disjoint from every prior type
pass) by their clean DOMAIN interfaces, dropping the plumbing interfaces that
the obfuscator attaches to every generic collection / async state machine /
iterator (IList`1, ICollection`1, IEnumerator`1, IAsyncStateMachine,
IStructuralComparable, IEquatable`1, ...). idf-weights over the interface corpus
so common interfaces (IEventSystemHandler appears on every UI widget) contribute
less than rare, specific ones.

Usage:
  python tools/build_interface_signal.py
  -> output/interface_signal.json
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
DEFAULT_OUT = BASE / "output" / "interface_signal.json"
PRIOR_NAMES = [
    BASE / "output" / "field_type_class_names.json",
    BASE / "output" / "method_return_class_names.json",
    BASE / "output" / "method_param_class_names.json",
    BASE / "output" / "combined_type_class_names.json",
]

_BEEBYTE = set("ÌÍÎÏ")
# Plumbing interfaces the obfuscator attaches to collections / async / iterators.
# These carry no class-specific domain meaning and must not drive a name.
_PLUMBING = {
    "IDisposable", "IEnumerable", "IEnumerator", "ICollection", "IList",
    "IReadOnlyList", "IReadOnlyCollection", "IDictionary", "IReadOnlyDictionary",
    "ISet", "IComparable", "IEquatable", "IComparer", "IEqualityComparer",
    "IFormattable", "IConvertible", "ICloneable", "ISerializable",
    "IStructuralComparable", "IStructuralEquatable", "IAsyncStateMachine",
    "IAsyncResult", "IObservable", "IObserver", "IEnumerable`1", "IEnumerator`1",
    "ICollection`1", "IList`1", "IReadOnlyList`1", "IReadOnlyCollection`1",
    "IDictionary`2", "IReadOnlyDictionary`2", "ISet`1", "IComparable`1",
    "IEquatable`1", "IComparer`1", "IEqualityComparer`1", "IObservable`1",
    "IObserver`1", "ISealedAllowReference",
}


def short(t: str) -> str:
    return t.split(".")[-1]


def is_clean_iface(name: str) -> bool:
    if not name or any(c in _BEEBYTE for c in name):
        return False
    s = short(name)
    if s in _PLUMBING:
        return False
    # keep only real interface-shaped names: I + UpperCamel, length > 3
    return len(s) > 3 and s[0] == "I" and s[1:2].isupper()


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
    ap.add_argument("--out", default=str(DEFAULT_OUT))
    ap.add_argument("--min-ifaces", type=int, default=1)
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

    # idf over clean domain interfaces.
    df = Counter()
    per_class = {}
    for cl in typed["namespaces"].values():
        for c in cl:
            ifs = sorted({short(i) for i in c.get("interfaces", [])
                          if is_clean_iface(i)})
            per_class[c["name"]] = (c, ifs)
            df.update(ifs)
    N = max(len(per_class), 1)
    idf = {t: math.log(N / c) for t, c in df.items()}

    signals = []
    for obf, (c, ifs) in per_class.items():
        if obf not in weak_obf or obf in already:
            continue
        if len(ifs) < args.min_ifaces:
            continue
        ranked = sorted(ifs, key=lambda t: idf.get(t, 0.0), reverse=True)
        score = sum(idf.get(t, 0.0) for t in ifs)
        signals.append({
            "obf_name": obf,
            "current_name": cur_name.get(obf, ""),
            "namespace": c.get("namespace", ""),
            "score": round(score, 3),
            "n_ifaces": len(ifs),
            "interfaces": ranked,
            "methods": c.get("methods", [])[:8],
        })

    signals.sort(key=lambda r: r["score"], reverse=True)
    out = {
        "summary": {
            "classes_scanned": len(per_class),
            "weak_unnamed_with_iface_signal": len(signals),
            "idf_corpus_size": N,
            "note": "clean domain interfaces only (plumbing collection/async/"
                    "iterator interfaces dropped); disjoint from all type passes.",
        },
        "signals": signals,
    }
    Path(args.out).write_text(json.dumps(out, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] weak_unnamed_with_iface_signal={len(signals)} -> {args.out}")
    print("\nTop 14 interface signals:")
    for r in signals[:14]:
        print(f"  {r['score']:6.2f} [{r['n_ifaces']}]  "
              f"{r['current_name'][:22]:22}  [{', '.join(r['interfaces'][:5])}]")
    return 0


if __name__ == "__main__":
    sys.exit(main())
