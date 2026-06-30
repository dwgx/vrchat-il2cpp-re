#!/usr/bin/env python
"""Method-body call-target miner (behavioral naming signal).

Sibling to build_string_literal_signal.py. Where strings capture literal content,
CALL TARGETS capture BEHAVIOR: a weak class's methods `call rel32 <VA>`; if that
VA is the unique entry point of a NAMED method we know which API the class drives
(Microphone.Start + AudioSource.set_loop -> microphone capture; DOTween.Sequence
-> tween animation; Animator.GetBoneTransform -> humanoid binding; VertexHelper.
AddTriangle -> UI mesh gen). Complements strings because many behavior-heavy
classes carry no string literals at all.

KEY PITFALL (learned 2026-06-29): 15,103 method VAs are SHARED across multiple
methods (IL2CPP trampolines / shared il2cpp_codegen_object_new ctors, e.g. one VA
labelled PipeStreamImpersonationWorker..ctor is reused by 78 methods). Mapping a
shared VA back to one class.method is wrong and floods every result with the same
bogus call. FIX: only map VAs that belong to exactly ONE method (unique-VA map).

Drops BCL/common-Unity targets so only DOMAIN calls drive a name, requires >=3
distinct domain calls. Emits output/calltarget_signal_raw.json keyed by the
obfuscated class name (== original_name in deobfuscated_dump.json). Feed to
subagents -> calltarget_class_names.json (tag call_target_disasm).

Result 2026-06-29: 1,897 classes with signal -> 50 new distinct source types,
semantic_pct 59.1%->60.2%, source_types 60.4%->60.9%. See
RE_EXTRACT_STRUCTURAL_SIGNALS.md item 11.

Usage:
  python tools/build_calltarget_signal.py --dump dumps/<jun29>.dmp
"""
import argparse
import json
import sys
from collections import Counter
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from extract_reverse_unity6 import DumpReader, detect_heap_band  # noqa: E402

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
_BEEBYTE = set("ÌÍÎÏ")
# BCL / ubiquitous-Unity owners: too common to discriminate a class's role.
BCL = {
    "String", "Dictionary", "List", "Object", "Type", "Array", "Enum", "Math",
    "Convert", "StringBuilder", "Int32", "Single", "Boolean", "Char", "Double",
    "Buffer", "Marshal", "Encoding", "DateTime", "TimeSpan", "Guid", "Nullable",
    "Comparer", "EqualityComparer", "Span", "Memory", "ReadOnlySpan", "Delegate",
    "Number", "ValueType", "Environment", "HashSet", "Queue", "Stack",
    "IEnumerator", "Enumerable",
}
PRIOR = [
    "field_type_class_names.json", "method_return_class_names.json",
    "method_param_class_names.json", "combined_type_class_names.json",
    "interface_class_names.json", "string_literal_class_names.json",
    "calltarget_class_names.json",
]


def is_domain(cn):
    if any(c in _BEEBYTE for c in cn) or cn.endswith("[]") or "`" in cn:
        return False
    return cn not in BCL


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--dump", required=True)
    ap.add_argument("--typed", default=str(BASE / "data" / "precise_dump_unity6_typed.json"))
    ap.add_argument("--out", default=str(BASE / "output" / "calltarget_signal_raw.json"))
    ap.add_argument("--max-methods", type=int, default=14)
    ap.add_argument("--max-bytes", type=int, default=1500)
    ap.add_argument("--min-calls", type=int, default=3)
    args = ap.parse_args()

    import capstone
    dr = DumpReader(args.dump)
    mm = dr.mm
    detect_heap_band(dr)  # warm va_map / sanity
    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))

    # Build unique-VA -> (class, method) map. Shared VAs are dropped.
    va_count = Counter()
    va2m = {}
    for cl in typed["namespaces"].values():
        for c in cl:
            cn = c["name"]
            for mn, va in c.get("method_pointers", {}).items():
                iv = int(va, 16)
                va_count[iv] += 1
                va2m[iv] = (cn, mn)
    va2m = {v: m for v, m in va2m.items() if va_count[v] == 1}
    print(f"[ok] unique-VA map: {len(va2m)} (dropped {sum(1 for v in va_count.values() if v > 1)} shared)")

    md = capstone.Cs(capstone.CS_ARCH_X86, capstone.CS_MODE_64)
    md.detail = True

    def call_targets(va):
        fo = dr.v2f(va)
        if fo is None:
            return []
        out = []
        try:
            for ins in md.disasm(mm[fo:fo + args.max_bytes], va):
                if ins.mnemonic == "call" and ins.op_str.startswith("0x"):
                    m = va2m.get(int(ins.op_str, 16))
                    if m:
                        out.append(f"{m[0]}.{m[1]}")
                elif ins.mnemonic == "ret":
                    break
        except Exception:
            pass
        return out

    used = set()
    for fn in PRIOR:
        p = BASE / "output" / fn
        if p.exists():
            used |= set(json.loads(p.read_text(encoding="utf-8")))

    res = []
    scanned = 0
    for cl in typed["namespaces"].values():
        for c in cl:
            nm = c["name"]
            if not any(ch in _BEEBYTE for ch in nm):
                continue
            if nm in used:
                continue
            mp = c.get("method_pointers", {})
            if not mp:
                continue
            scanned += 1
            dom, seen = [], set()
            for _mn, va in list(mp.items())[:args.max_methods]:
                for key in call_targets(int(va, 16)):
                    if is_domain(key.rsplit(".", 1)[0]) and key not in seen:
                        seen.add(key)
                        dom.append(key)
            if len(dom) >= args.min_calls:
                res.append({"obf": nm, "cur": nm, "ns": c.get("namespace", ""),
                            "calls": dom[:16]})
    res.sort(key=lambda r: -len(r["calls"]))
    Path(args.out).write_text(json.dumps(res, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] scanned {scanned} obfuscated classes, "
          f"{len(res)} with >={args.min_calls} domain calls -> {args.out}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
