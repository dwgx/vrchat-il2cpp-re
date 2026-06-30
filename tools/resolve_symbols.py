#!/usr/bin/env python
"""!!! DO NOT USE FOR NAMING — OUTPUT IS UNRELIABLE (see spec item 27) !!!

The rebase this relies on (IDA_BASE + (rva & ~0xFFFFFF)) is BROKEN: the ~0xFFFFFF
mask keeps only 24 bits (16MB) but the code segment spans 220MB, so ~9% of EAs
collide to the same symbol. Worse, IL2CPP method_pointers are RUNTIME VAs with no
linear mapping to disk PE file VAs at all (verified: 9/80 match against Ghidra's
ground-truth FUN_ addresses). Names this produced (e.g. PhysBoneGrab::get_Bone)
were coincidental aliasing, not real resolution. Kept only as a record of the
dead end. A correct resolver must parse the PE's il2cpp metadata sections
(CodeRegistration -> methodPointers as FILE RVAs), like Il2CppDumper does.

Resolve Ghidra FUN_<ea> / DAT_/UNK_ references in pseudocode to real IL2CPP
symbols, using a global file-VA -> (class, method) map built from the typed
dump's method_pointers (ASLR runtime VAs rebased via the project's canonical
IDA_BASE + (rva & ~0xFFFFFF) formula, see build_mass_hexrays_targets.py).

This is the signal that makes decompiled pseudocode nameable: a method body full
of FUN_18059d520(...) is opaque, but rewritten to PhysBoneGrab_get_Bone(...) it
reveals what the method DOES (item 25: methods are action entities).

Exposed for reuse by the per-class naming agents.
"""
import json
import re
from functools import lru_cache
from pathlib import Path

BASE = Path(__file__).resolve().parent.parent
_RUNTIME_BASE_MASK = ~0xFFFFFF
_IDA_BASE = 0x180000000
_BEE = set("ÌÍÎÏ")


def _rva_to_ea(rva: int) -> int:
    return _IDA_BASE + (rva - (rva & _RUNTIME_BASE_MASK))


def _is_obf(s: str) -> bool:
    return any(c in _BEE for c in (s or ""))


@lru_cache(maxsize=1)
def _ea_to_symbol() -> dict:
    """file-EA -> 'Class.method' for every method we have a pointer for."""
    td = json.load(open(BASE / "data" / "precise_dump_unity6_typed.json",
                        encoding="utf-8"))
    out = {}
    for cls in td["namespaces"].values():
        for c in cls:
            cn = c["name"]
            for m, ptr in c.get("method_pointers", {}).items():
                try:
                    rva = int(ptr, 16)
                except (ValueError, TypeError):
                    continue
                if rva:
                    out[_rva_to_ea(rva)] = (cn, m)
    return out


_FUN = re.compile(r"\bFUN_([0-9a-fA-F]{6,})\b")


def annotate(pseudocode: str) -> str:
    """Rewrite FUN_<ea> tokens to readable Class_method when the EA resolves to a
    non-obfuscated symbol; leave unresolved / obfuscated callees as-is."""
    table = _ea_to_symbol()

    def repl(mobj):
        ea = int(mobj.group(1), 16)
        sym = table.get(ea)
        if not sym:
            return mobj.group(0)
        cn, mn = sym
        if _is_obf(cn) or _is_obf(mn):
            return mobj.group(0)
        clean = re.sub(r"[^A-Za-z0-9]", "_", f"{cn}_{mn}")
        return clean

    return _FUN.sub(repl, pseudocode)


def resolved_callees(pseudocode: str) -> list:
    """List of distinct non-obfuscated 'Class.method' callees in the body —
    the concrete naming evidence an agent should reason from."""
    table = _ea_to_symbol()
    seen, out = set(), []
    for h in _FUN.findall(pseudocode):
        sym = table.get(int(h, 16))
        if not sym:
            continue
        cn, mn = sym
        if _is_obf(cn) or _is_obf(mn):
            continue
        key = f"{cn}.{mn}"
        if key not in seen:
            seen.add(key)
            out.append(key)
    return out


if __name__ == "__main__":
    import sys
    src = json.load(open(sys.argv[1], encoding="utf-8"))
    tab = _ea_to_symbol()
    print(f"global EA->symbol map: {len(tab)} entries")
    tot = res = 0
    for rec in src:
        if not rec.get("ok"):
            continue
        c = resolved_callees(rec["pseudocode"])
        tot += 1
        if c:
            res += 1
    print(f"{res}/{tot} methods have >=1 resolved named callee "
          f"({100 * res // max(tot, 1)}%)")
