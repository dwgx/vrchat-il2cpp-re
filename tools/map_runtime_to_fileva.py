#!/usr/bin/env python
"""Map build-matched runtime method symbols to disk file VAs (Track D breakthrough,
spec item 28). The relationship is a single global constant per dump:

    file_va = runtime_va - (module_base - 0x180000000)

where module_base is GameAssembly.dll's load base in that dump's process. We read
it straight from the minidump's ModuleListStream (no fitting). Verified: 89.4% of
mapped pointers land on real .pdata function starts (20x signal-to-noise), bytes
are clean x64 prologues, and the fitted offset equals the minidump module base.

Output: a flat {file_ea_hex: "Class::method"} table + a Ghidra-ready script.json
({ScriptMethod:[{Address, Name}]}) for the il2cpp Ghidra renamer.

MUST be build-matched: jun13 DLL <-> precise_dump_jun13.json <-> jun13 dump base.
"""
import json
import struct
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
IMAGE_BASE = 0x180000000
_BEE = set("ÌÍÎÏ")


def _is_obf(s: str) -> bool:
    return any(c in _BEE for c in (s or ""))


def pe_sections(dll: bytes):
    """Returns (image_base, {name: (va, vsz, rawoff, rawsz)}). Section header
    layout: name[8], then VirtualSize, VirtualAddress, SizeOfRawData,
    PointerToRawData as four little-endian uint32 at offset +8."""
    e = struct.unpack_from("<I", dll, 0x3C)[0]
    coff = e + 4
    opt = coff + 20
    image_base = struct.unpack_from("<Q", dll, opt + 24)[0]
    nsec = struct.unpack_from("<H", dll, coff + 2)[0]
    secoff = opt + struct.unpack_from("<H", dll, coff + 16)[0]
    secs = {}
    for i in range(nsec):
        so = secoff + i * 40
        name = dll[so:so + 8].rstrip(b"\x00").decode("latin1")
        vsz, va, rawsz, rawoff = struct.unpack_from("<IIII", dll, so + 8)
        secs[name] = (va, vsz, rawoff, rawsz)
    return image_base, secs


def pdata_starts(dll: bytes, image_base: int, secs) -> set:
    """RUNTIME_FUNCTION start RVAs -> file VAs (ground-truth function starts).
    Each RUNTIME_FUNCTION is 12 bytes; first uint32 is the function start RVA."""
    va, vsz, rawoff, rawsz = secs[".pdata"]
    starts = set()
    for i in range(vsz // 12):
        s = struct.unpack_from("<I", dll, rawoff + i * 12)[0]
        if s:
            starts.add(image_base + s)
    return starts


def minidump_module_base(dmp_path: Path, name_substr="GameAssembly") -> int:
    with open(dmp_path, "rb") as f:
        md = f.read(50_000_000)
    assert md[:4] == b"MDMP", "not a minidump"
    nstr, diroff = struct.unpack_from("<II", md, 8)
    for i in range(nstr):
        st, sz, rva = struct.unpack_from("<III", md, diroff + i * 12)
        if st == 4:  # ModuleListStream
            n = struct.unpack_from("<I", md, rva)[0]
            for j in range(n):
                mo = rva + 4 + j * 108
                base = struct.unpack_from("<Q", md, mo)[0]
                nrva = struct.unpack_from("<I", md, mo + 0x30)[0]
                slen = struct.unpack_from("<I", md, nrva)[0]
                nm = md[nrva + 4:nrva + 4 + slen].decode("utf-16le", "replace")
                if name_substr in nm:
                    return base
    raise RuntimeError("GameAssembly module not found in minidump")


def main():
    dll_path = BASE / "dumps" / "GameAssembly_jun13.dll"
    dump_path = BASE / "data" / "precise_dump_jun13.json"
    dmp_path = BASE / "dumps" / "VRChat_40752_20260621_102014_full.dmp"

    dll = dll_path.read_bytes()
    image_base, secs = pe_sections(dll)
    starts = pdata_starts(dll, image_base, secs)
    module_base = minidump_module_base(dmp_path)
    off = module_base - IMAGE_BASE
    print(f"module_base=0x{module_base:X}  OFF=0x{off:X}  "
          f".pdata starts={len(starts)}")

    dump = json.load(open(dump_path, encoding="utf-8"))
    table = {}        # file_ea -> "Class::method"
    obf_skipped = 0
    for ns, cls in dump["namespaces"].items():
        for c in cls:
            cn = c["name"]
            for m, p in c.get("method_pointers", {}).items():
                try:
                    rva = int(p, 16)
                except (ValueError, TypeError):
                    continue
                if not rva:
                    continue
                # skip fully obfuscated class+method (nothing useful to inject)
                if _is_obf(cn) and _is_obf(m):
                    obf_skipped += 1
                    continue
                table[rva - off] = f"{cn}::{m}"

    on_pdata = sum(1 for k in table if k in starts)
    print(f"symbols mapped (distinct file_ea): {len(table)}  "
          f"on .pdata start: {on_pdata} ({100*on_pdata//max(len(table),1)}%)  "
          f"obf-skipped: {obf_skipped}")

    out_dir = BASE / "output" / "p2_research"
    # flat table
    flat = {hex(k): v for k, v in sorted(table.items())}
    json.dump(flat, open(out_dir / "jun13_file_va_symbols.json", "w",
                         encoding="utf-8"), ensure_ascii=False, indent=0)
    # Ghidra script.json shape (Address relative to image base)
    script = {"ScriptMethod": [
        {"Address": k - image_base, "Name": v}
        for k, v in sorted(table.items())]}
    json.dump(script, open(out_dir / "jun13_script.json", "w",
                           encoding="utf-8"), ensure_ascii=False)
    print(f"wrote jun13_file_va_symbols.json ({len(flat)}) + jun13_script.json")


if __name__ == "__main__":
    main()
