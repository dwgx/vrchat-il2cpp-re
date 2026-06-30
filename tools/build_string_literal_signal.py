#!/usr/bin/env python
"""Method-body string-literal miner (the strongest naming signal).

Disassembles method bodies DIRECTLY out of the jun29 memory dump (not the
on-disk jun05 .i64, whose build mismatches the dump) using capstone + the
method_pointers (VAs) the extractor already records. A C# string literal load is
`lea reg, [rip+disp]` -> a slot whose qword points at an Il2CppString object on
the heap (object header[+0x00] == System.String klass VA; +0x10 int32 length;
+0x14 UTF-16 chars). Both the slot and *slot can be the string object. lea
targets in a string-less method are RGCTX/metadata objects, filtered out by the
String-klass header check.

Emits output/string_signal_raw.json: per still-unnamed obfuscated class, the set
of >=2 discriminative literals its first 16 methods load, minus a NOISE set of
argument-null-check names. Feed to subagents for naming -> string_literal_class_
names.json (tag string_literal_disasm in apply_class_names.py).

Result 2026-06-29: 1,483 classes with signal -> 79 new distinct source types,
semantic_pct 54.7%->59.1%, source_types 59.4%->60.4%. See
RE_EXTRACT_STRUCTURAL_SIGNALS.md item 10.

Usage:
  python tools/build_string_literal_signal.py --dump dumps/<jun29>.dmp
"""
import argparse
import json
import struct
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from extract_reverse_unity6 import DumpReader, detect_heap_band, CL_NAME, CL_SELFREF  # noqa: E402

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent

_BEEBYTE = set("ÌÍÎÏ")
NOISE = {
    "index", "obj", "source", "value", "key", "item", "array", "buffer",
    "selector", "capacity", "count", "length", "input", "other", "format",
    "name", "arg", "action", "comparer", "collection", "match", "predicate",
    "culture", "provider", "destination", "destinationArray", "sourceArray",
    "startIndex", "newSize", "args", "list", "type", "field", "method", "result",
    "data", "text", "str", "output", "offset", "size", "width", "height", "min",
    "max", "step", "mode", "state", "target", "element", "node", "entry", "range",
    "number",
}
PRIOR = [
    "field_type_class_names.json", "method_return_class_names.json",
    "method_param_class_names.json", "combined_type_class_names.json",
    "interface_class_names.json", "string_literal_class_names.json",
]


def find_string_klass(dr, mm, lo, hi):
    import numpy as np
    needle = b"String\x00"
    cand = []
    for vs, sz, fo in dr.va_map:
        i = mm.find(needle, fo, fo + sz)
        while i != -1:
            if not (65 <= mm[i - 1] <= 90 or 97 <= mm[i - 1] <= 122
                    or mm[i - 1] == 95):
                cand.append(vs + (i - fo))
            i = mm.find(needle, i + 1, fo + sz)
    for vs, sz, fo in [(v, s, f) for v, s, f in dr.va_map
                       if s >= 0x1000 and lo <= v < hi]:
        arr = np.frombuffer(mm, dtype=np.uint64, count=(sz - 8) // 8, offset=fo)
        for tva in cand:
            for h in np.where(arr == tva)[0]:
                k = vs + int(h) * 8 - CL_NAME
                if (lo <= k < hi and dr.rstr_ptr(k + CL_NAME) == "String"
                        and dr.ru64(k + CL_SELFREF) == k):
                    return k
    return None


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--dump", required=True)
    ap.add_argument("--typed", default=str(BASE / "data" / "precise_dump_unity6_typed.json"))
    ap.add_argument("--out", default=str(BASE / "output" / "string_signal_raw.json"))
    ap.add_argument("--max-methods", type=int, default=16)
    ap.add_argument("--max-bytes", type=int, default=1100)
    args = ap.parse_args()

    import capstone
    dr = DumpReader(args.dump)
    mm = dr.mm
    lo, hi = detect_heap_band(dr)
    sk = find_string_klass(dr, mm, lo, hi)
    if not sk:
        print("[fatal] System.String klass not found")
        return 1
    print(f"[ok] System.String klass @0x{sk:X}")

    md = capstone.Cs(capstone.CS_ARCH_X86, capstone.CS_MODE_64)
    md.detail = True
    RIP = capstone.x86.X86_REG_RIP
    MEM = capstone.x86.X86_OP_MEM

    def read_str(off):
        ln = struct.unpack_from("<i", mm, off + 0x10)[0]
        if not (1 <= ln <= 300):
            return None
        try:
            return mm[off + 0x14:off + 0x14 + ln * 2].decode("utf-16-le")
        except Exception:
            return None

    def str_at_va(va):
        fo = dr.v2f(va)
        if fo is None or struct.unpack_from("<Q", mm, fo)[0] != sk:
            return None
        return read_str(fo)

    def method_strings(va):
        fo = dr.v2f(va)
        if fo is None:
            return []
        out = []
        try:
            for ins in md.disasm(mm[fo:fo + args.max_bytes], va):
                if ins.mnemonic == "lea":
                    for op in ins.operands:
                        if op.type == MEM and op.mem.base == RIP:
                            slot = ins.address + ins.size + op.mem.disp
                            p1 = dr.ru64(slot) if dr.v2f(slot) is not None else None
                            for cand in (slot, p1):
                                if cand:
                                    s = str_at_va(cand)
                                    if s:
                                        out.append(s)
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

    typed = json.loads(Path(args.typed).read_text(encoding="utf-8"))
    res = []
    scanned = 0
    for cl in typed["namespaces"].values():
        for c in cl:
            nm = c["name"]
            if not any(ch in _BEEBYTE for ch in nm):
                continue
            if c.get("original_name") in used:
                continue
            mp = c.get("method_pointers", {})
            if not mp:
                continue
            scanned += 1
            bag, seen = [], set()
            for _mn, va in list(mp.items())[:args.max_methods]:
                for s in method_strings(int(va, 16)):
                    if (s in NOISE or len(s) < 3 or len(s) > 60
                            or not any(ch.isalpha() for ch in s)
                            or any(ch in _BEEBYTE for ch in s)):
                        continue
                    if s not in seen:
                        seen.add(s)
                        bag.append(s)
            if len(bag) >= 2:
                res.append({"obf": c.get("original_name"), "cur": nm,
                            "ns": c.get("namespace", ""), "strings": bag[:14]})
    res.sort(key=lambda r: -len(r["strings"]))
    Path(args.out).write_text(json.dumps(res, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    print(f"[done] scanned {scanned} obfuscated classes, "
          f"{len(res)} with >=2 literals -> {args.out}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
