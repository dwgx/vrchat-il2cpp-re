#!/usr/bin/env python3
"""
Track B - jun26 VRChat global-metadata.dat decryptor.

Reverse-engineered for the 2026-06-26 VRChat build (GameAssembly.dll 232 MB,
metadata 40.5 MB, Unity 6000.0.60f1, IL2CPP metadata version 31).

KEY RESULT
==========
The jun26 metadata uses the SAME algorithm family as the 2026-05-02 build that
tools/decrypt_metadata.py targeted - a position-based XOR ramp - but the
constants were rotated.

Two independently-keyed regions:

1. HEADER (first 0x148 bytes)
   Encrypted with a NON-LINEAR keystream (a per-byte PRNG, not a clean ramp).
   Recovered keystream prefix (verified via known il2cpp plaintext):
       ks[0x00:0x08] = 5f 05 73 3b d3 b6 a8 bd
   This XORs the encrypted magic/version dwords back to:
       sanity  = 0xFAB11BAF   (il2cpp magic, little-endian AF 1B B1 FA)
       version = 31           (Unity 6 / IL2CPP v31)
   -> sanity check PASSES.

2. DATA SECTIONS (string literals, identifier strings, etc.)
   Encrypted with a simple GLOBAL position ramp:
       plain[f] = enc[f] XOR ((f + K) & 0xFF)
   where f is the ABSOLUTE file offset and K is a per-section constant.
   Measured K values (verified byte-exact against the live process dump):
       K = 0xC3  for the string-literal data region   (file 0x06A000 .. 0x24B400)
       K = 0x2D  for the identifier-string region      (file 0x24C098 .. 0xA05000)
   (Equivalent to the classic Beebyte form key[i]=(i + base)&0xFF with i relative
    to the section start; base = (K + section_start) & 0xFF.)

GROUND TRUTH
============
The jun26 minidump (dumps/VRChat_32984_20260629_180349_full.dmp) carries a
verbatim copy of the encrypted file plus the SEPARATE decrypted string buffers.
XOR(file, dump) over those buffers recovered the keystream directly and proves
the result: the decrypted identifier section reproduces the dump byte-for-byte
and yields readable class names (VRCPlayerApi, UdonBehaviour, MonoBehaviour, ...).
"""
from __future__ import annotations

import re
import struct
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

GMD = Path(r"D:/Steam/steamapps/common/VRChat/VRChat_Data/il2cpp_data/Metadata/global-metadata.dat")
OUT = Path(r"D:/Project/vrchat-il2cpp-re/output/p2_research/trackB_metadata_decrypted.dat")

HEADER_SIZE = 0x148

# Recovered header keystream prefix (non-linear PRNG; only prefix needed for sanity).
HEADER_KS_PREFIX = bytes([0x5F, 0x05, 0x73, 0x3B, 0xD3, 0xB6, 0xA8, 0xBD])

# Data-section ramps, verified byte-exact vs the live dump.
# (file_start, file_end, K)   plain[f] = enc[f] ^ ((f + K) & 0xFF)
SECTIONS = [
    (0x06A000, 0x24B400, 0xC3),   # string-literal data
    (0x24C098, 0xA05000, 0x2D),   # identifier strings (type/method/field names)
]


def decrypt_header_prefix(enc: bytes) -> bytes:
    out = bytearray(enc[:HEADER_SIZE])
    for i, k in enumerate(HEADER_KS_PREFIX):
        out[i] = enc[i] ^ k
    return bytes(out)


def decrypt_ramp(enc: bytes, start: int, end: int, K: int) -> bytes:
    out = bytearray(end - start)
    for f in range(start, end):
        out[f - start] = enc[f] ^ ((f + K) & 0xFF)
    return bytes(out)


def main() -> None:
    print(f"[+] reading {GMD.name} ({GMD.stat().st_size:,} bytes)")
    enc = GMD.read_bytes()

    # ---- header / sanity ----
    hdr = decrypt_header_prefix(enc)
    sanity, version = struct.unpack_from("<II", hdr, 0)
    print(f"[+] header keystream prefix = {' '.join(f'{b:02x}' for b in HEADER_KS_PREFIX)}")
    print(f"    sanity  = 0x{sanity:08X}  (expected 0xFAB11BAF)")
    print(f"    version = {version}")
    sanity_ok = sanity == 0xFAB11BAF
    print(f"    [{'PASS' if sanity_ok else 'FAIL'}] sanity check")

    # ---- sections ----
    out_buf = bytearray(enc)
    out_buf[:HEADER_SIZE] = hdr
    decrypted = {}
    for (s, e, K) in SECTIONS:
        e = min(e, len(enc))
        sec = decrypt_ramp(enc, s, e, K)
        out_buf[s:e] = sec
        decrypted[(s, e, K)] = sec
        print(f"[+] section 0x{s:06X}..0x{e:06X} (K=0x{K:02X}) decrypted ({e - s:,} bytes)")

    OUT.parent.mkdir(parents=True, exist_ok=True)
    OUT.write_bytes(bytes(out_buf))
    print(f"[+] wrote {OUT} ({len(out_buf):,} bytes)")

    # ---- proof: readable class names from the identifier section ----
    ids = decrypted[(0x24C098, min(0xA05000, len(enc)), 0x2D)]
    toks = re.findall(rb"[A-Za-z_<][A-Za-z0-9_.<>/`+]{2,}", ids)
    uniq = sorted({t.decode("latin1") for t in toks})
    print(f"[+] identifier section: {len(toks):,} string tokens, {len(uniq):,} unique")

    proofs = ["VRCPlayerApi", "UdonBehaviour", "MonoBehaviour", "Networking",
              "PlayerData", "UnityEngine", "GameObject", "Transform",
              "VRC.Core", "Assembly-CSharp"]
    present = set(uniq)
    print("[+] known-name spot check:")
    for p in proofs:
        hit = p in present or any(p in u for u in present) if p in ("VRC.Core",) else p in present
        print(f"      {'OK ' if hit else '?? '} {p}")

    vrc = [u for u in uniq if u.startswith("VRC")][:20]
    print("[+] sample VRChat identifiers:")
    for u in vrc:
        print(f"      {u}")


if __name__ == "__main__":
    main()
