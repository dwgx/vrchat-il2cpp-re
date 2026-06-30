#!/usr/bin/env python
"""Per-method call-target naming (the METHOD behavioral axis).

Item 15 found that type-derivation is UNSAFE for methods (can't tell a getter from
a factory). The safe signal is BEHAVIOR: disassemble each m_HEX method's body, find
the dominant DISTINCTIVE domain API it calls, and name the method for that behavior
(a method that calls Microphone.GetMicrophoneDeviceIDFromName -> "Invoke_GetMicro
phoneDeviceIDFromName"). This is the item-11 call-target technique applied PER
METHOD instead of aggregated per class. Verifiable (the call is really in the body),
not a type guess.

NAMING CONVENTION: prefix "Invoke_" so the derived name can never be confused with
the actual API it calls (we are NOT claiming the method IS get_sizeDelta; we are
saying it DRIVES that API). Dedup within a class with numeric suffixes.

FILTERS: only obfuscated (ÌÍÎÏ) methods; resolve calls via UNIQUE-VA map (shared
IL2CPP trampoline VAs dropped, as in item 11); exclude BCL owners, logging/builder
noise (VRCLogger/ZLogger/AppendLiteral/get_GlobalLogger), and GENERIC Unity
accessors (SetActive/get_transform/...) that are too common to be distinctive.
Require the dominant distinctive API to appear >=2x and be >=5 chars.

Result 2026-06-29: 1,769 strong behavioral candidates. NOTE: VAs resolve against
VRChat_6456_20260629 (NOT 32984 - the typed dump's method_pointers match 6456).
See RE_EXTRACT_STRUCTURAL_SIGNALS.md item 16.

Usage:
  python tools/build_method_calltarget_signal.py --dump dumps/VRChat_6456_20260629_163108_full.dmp
  -> output/method_calltarget_names.json  {original_class_name: {m_HEX: Invoke_Api}}
"""
import argparse
import json
import re
import sys
from collections import Counter
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from extract_reverse_unity6 import DumpReader, detect_heap_band  # noqa: E402

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
_BEEBYTE = set("ÌÍÎÏ")
BCL_OWNER = {"Object", "String", "Type", "Enum", "Array", "Math", "Convert",
             "Debug", "Console", "List", "Dictionary", "Component", "Encoding",
             "StringBuilder", "Func", "Action", "Nullable", "Buffer", "Marshal",
             "Interlocked", "Monitor", "Volatile", "Comparer", "EqualityComparer",
             "Enumerable", "Activator"}
NOISE_OWNER = {"VRCLogger", "Logger", "ZLoggerInterpolatedStringHandler", "ILogger"}
NOISE_M = {"AppendLiteral", "AppendFormatted", "get_GlobalLogger", ".ctor",
           "ToString", "get_Item", "set_Item", "Append", "AppendLine"}
GENERIC_API = {"SetActive", "get_transform", "get_gameObject", "get_enabled",
               "set_enabled", "get_sizeDelta", "set_sizeDelta", "SetParent",
               "get_Count", "Add", "Remove", "Contains", "get_Value",
               "set_Value", "Invoke", "get_Key"}
MH = re.compile(r'^m_[0-9A-Fa-f]{3,}$')


def clean(s):
    return s and not any(ch in _BEEBYTE for ch in s)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--dump", required=True)
    ap.add_argument("--typed", default=str(BASE / "data" / "precise_dump_unity6_typed.json"))
    ap.add_argument("--out", default=str(BASE / "output" / "method_calltarget_names.json"))
    ap.add_argument("--max-bytes", type=int, default=1400)
    args = ap.parse_args()

    import capstone
    dr = DumpReader(args.dump)
    mm = dr.mm
    detect_heap_band(dr)
    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))

    vc = Counter()
    va2m = {}
    for cl in typed["namespaces"].values():
        for c in cl:
            for mn, va in c.get("method_pointers", {}).items():
                iv = int(va, 16)
                vc[iv] += 1
                va2m[iv] = (c["name"], mn)
    va2m = {v: m for v, m in va2m.items() if vc[v] == 1}
    print(f"[ok] unique-VA map: {len(va2m)}")

    md = capstone.Cs(capstone.CS_ARCH_X86, capstone.CS_MODE_64)
    md.detail = True

    def domain_call(s):
        cls, _, m = s.partition(".")
        if any(c in _BEEBYTE for c in s) or "`" in s:
            return None
        if cls in BCL_OWNER or cls in NOISE_OWNER or m in NOISE_M:
            return None
        return m

    def targets(va):
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

    def mkname(api):
        a = api.replace("get_", "").replace("set_", "")
        if not a or not a[0].isalpha():
            return None
        return "Invoke_" + a[0].upper() + a[1:]

    result = {}
    named = 0
    for cl in typed["namespaces"].values():
        for c in cl:
            cm = {}
            used = set()
            for mn, va in c.get("method_pointers", {}).items():
                if not any(ch in _BEEBYTE for ch in mn):
                    continue
                tg = [x for x in (domain_call(t) for t in targets(int(va, 16))) if x]
                if len(tg) < 3:
                    continue
                cnt = Counter(tg)
                cand = [(a, n) for a, n in cnt.most_common()
                        if a not in GENERIC_API and n >= 2 and len(a) >= 5]
                if not cand:
                    continue
                nm = mkname(cand[0][0])
                if not nm or not clean(nm):
                    continue
                base, i = nm, 2
                while nm in used:
                    nm = f"{base}_{i}"
                    i += 1
                used.add(nm)
                cm[mn] = nm
                named += 1
            if cm:
                result[c["name"]] = cm
    Path(args.out).write_text(json.dumps(result, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] {named} behavioral method names across {len(result)} classes "
          f"-> {args.out}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
