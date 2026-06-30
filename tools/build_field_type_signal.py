#!/usr/bin/env python3
"""Build a field-type naming signal for weak (fallback-named) obfuscated classes.

The Unity 6 extractor (extract_reverse_unity6.py --typed-fields) resolves field
types via the FieldInfo Il2CppType pointer (FI+0x10) and the klass byval_arg
handle map (klass+0x20). This tool turns those resolved types into a ranked
naming signal:

  * join the typed dump to deobfuscated_dump.json by obfuscated class name
    (VAs differ across dump sessions; the obfuscated name is the stable key);
  * for each class, keep only DISCRIMINATIVE field types (drop primitives,
    still-obfuscated type names, and structural tags like <genericinst>);
  * weight each type by global rarity (idf = log(N / df)) so that a type like
    UnityEngine.WebCamTexture (appears in ~1 class) outweighs GameObject (~733);
  * score each weak class by the sum of its top discriminative-type idf weights
    and emit the ranked signal.

Output is additive evidence for the naming pipeline, NOT a final rename — it
says "this class is built around these domain types", which a downstream namer
(LLM or heuristic) turns into a label. Strong (already-named) classes are kept
separately as a cross-validation anchor.
"""

from __future__ import annotations

import argparse
import json
import math
import sys
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_TYPED = BASE_DIR / "data" / "precise_dump_unity6_typed.json"
DEFAULT_DEOBF = BASE_DIR / "output" / "deobfuscated_dump.json"
DEFAULT_OUT = BASE_DIR / "output" / "field_type_signal.json"

# System/primitive type names that carry little naming signal on their own.
PRIMITIVES = {
    "Single", "Int32", "Boolean", "UInt32", "Byte", "Int64", "Double", "String",
    "Char", "Object", "UInt64", "Int16", "UInt16", "SByte", "IntPtr", "UIntPtr",
    "Void",
}
# Generic plumbing types that are common enough to be near-noise as a signal.
LOW_SIGNAL = {
    "System.Action", "System.Threading.CancellationToken", "System.Type",
    "Awaiter",
    "Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder",
    "Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder",
}
_BEEBYTE = set("ÌÍÎÏ")


def is_clean_type(t: str) -> bool:
    """A resolved type name usable as a naming signal: not a structural tag,
    not a primitive, not still-obfuscated."""
    if not t or t.startswith("<"):
        return False
    if any(ch in _BEEBYTE for ch in t):
        return False
    return t.split(".")[-1] not in PRIMITIVES


def is_obfuscated(name: str) -> bool:
    return any(ch in _BEEBYTE for ch in name)


def is_weak(entry: dict) -> bool:
    """Weak = no semantic provenance, or the current name is still a fallback /
    obfuscated placeholder. These are the classes that still need naming."""
    src = entry.get("semantic_source", "(none)")
    if src in ("(none)", "structural"):
        return True
    return is_obfuscated(entry.get("name", ""))


def load_typed_field_types(path: Path) -> dict[str, dict]:
    data = json.loads(path.read_text(encoding="utf-8"))
    out = {}
    for classes in data["namespaces"].values():
        for c in classes:
            ft = c.get("field_types")
            if ft:
                out[c["name"]] = ft  # keyed by obfuscated class name
    return out


def main() -> int:
    ap = argparse.ArgumentParser(description=__doc__,
                                 formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--typed", default=str(DEFAULT_TYPED))
    ap.add_argument("--deobf", default=str(DEFAULT_DEOBF))
    ap.add_argument("--out", default=str(DEFAULT_OUT))
    ap.add_argument("--top-types", type=int, default=5,
                    help="max discriminative types to keep per class signal")
    args = ap.parse_args()

    typed_ft = load_typed_field_types(Path(args.typed))
    print(f"[typed] {len(typed_ft)} classes with resolved field types")

    deobf = json.loads(Path(args.deobf).read_text(encoding="utf-8"))

    # Global document frequency of each clean discriminative type across all
    # classes that have field types (idf corpus = the typed dump).
    df = Counter()
    for ft in typed_ft.values():
        seen = {t for t in ft.values() if is_clean_type(t)}
        df.update(seen)
    N = max(len(typed_ft), 1)
    idf = {t: math.log(N / c) for t, c in df.items()}

    weak_signals = []
    strong_anchors = []
    joined = 0
    for classes in deobf["namespaces"].values():
        for c in classes:
            orig = c.get("original_name")
            ft = typed_ft.get(orig)
            if not ft:
                continue
            joined += 1
            # Rank this class's discriminative types by idf (rarer = stronger),
            # excluding low-signal plumbing types.
            scored = []
            for field_name, tname in ft.items():
                if not is_clean_type(tname) or tname in LOW_SIGNAL:
                    continue
                scored.append((idf.get(tname, 0.0), field_name, tname))
            scored.sort(reverse=True)
            top = scored[: args.top_types]
            if not top:
                continue
            score = round(sum(w for w, _, _ in top), 3)
            rec = {
                "obf_name": orig,
                "current_name": c.get("name"),
                "namespace": c.get("namespace", ""),
                "semantic_source": c.get("semantic_source", "(none)"),
                "score": score,
                "signal_types": [
                    {"field": fn, "type": tn, "idf": round(w, 3)}
                    for w, fn, tn in top
                ],
            }
            if is_weak(c):
                weak_signals.append(rec)
            else:
                strong_anchors.append(rec)

    weak_signals.sort(key=lambda r: r["score"], reverse=True)
    strong_anchors.sort(key=lambda r: r["score"], reverse=True)

    out = {
        "summary": {
            "joined_classes": joined,
            "weak_with_signal": len(weak_signals),
            "strong_with_signal": len(strong_anchors),
            "idf_corpus_size": N,
            "distinct_discriminative_types": len(df),
            "typed_source": Path(args.typed).name,
            "note": "weak_signals = naming candidates; strong_anchors = "
                    "cross-validation set (already named, used to sanity-check "
                    "that field-type signals agree with established names).",
        },
        "weak_signals": weak_signals,
        "strong_anchors": strong_anchors,
    }
    Path(args.out).write_text(json.dumps(out, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] joined={joined} weak_with_signal={len(weak_signals)} "
          f"strong_anchors={len(strong_anchors)} -> {args.out}")
    print("\nTop 12 weak-class field-type signals (highest rarity-weighted score):")
    for r in weak_signals[:12]:
        types = ", ".join(s["type"].split(".")[-1] for s in r["signal_types"])
        print(f"  {r['score']:6.2f}  {r['current_name'][:32]:32}  [{types}]")
    return 0


if __name__ == "__main__":
    sys.exit(main())
