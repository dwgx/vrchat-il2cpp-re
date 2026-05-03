#!/usr/bin/env python3
"""
Beebyte VRChat 2026-05-02 metadata decryptor.

Algorithm reverse-engineered from sub_180A7E880 in GameAssembly.dll:

1. Header (first 0x148 bytes) is encrypted with a position-based keystream:
   key[i] = (i - 0x34) & 0xFF
   plain[i] = enc[i] XOR key[i]

2. After the header is decrypted, the loader reads byte-sized fields out of
   it (offsets 0x4C, 0x68, 0x80, 0xA8, 0x98, 0x128, 0x12C, 0x134) plus the
   matching dword "section size" right next to each one. The eight metadata
   sections are then memcpy'd from `file_base + dword_field + adjust` and
   XOR-decoded with one of two simple keystreams:

   key[i] = (size_byte + i - 35) & 0xFF        # 5 sections
   key[i] = (i - size_byte + 35) & 0xFF        # 3 sections

   Where `size_byte` is `(uint8)header[size_field_offset]` (low byte of the
   32-bit size dword; not the full size).

Sections (offset_field, +adj, size_field, sign):
    (172,  +36, 296, +)   #  type definitions buffer
    (  0,  -52, 168, +)   #  string literals
    (180,  +24,  76, -)   #  ...
    (152,  +60, 232, +)
    (  8,  +60, 132, +)
    (104,  -32, 252, -)
    (300,  +56, 308, -)

This reproduces the in-memory state the runtime would build at il2cpp_init.
"""
from __future__ import annotations

import struct
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

GMD = Path(r'D:/Steam/steamapps/common/VRChat/VRChat_Data/il2cpp_data/Metadata/global-metadata.dat')
OUT = Path(r'D:/Project/vrchat-il2cpp-re/data/metadata_decrypted.dat')

HEADER_SIZE = 0x148

SECTIONS = [
    # (offset_field, src_adjust, size_field, sign_minus)
    (172,  +36, 296, False),
    (  0,  -52, 168, False),
    (180,  +24,  76, True),
    (152,  +60, 232, False),
    (  8,  +60, 132, False),
    (104,  -32, 252, True),
    (300,  +56, 308, True),
]


def decrypt_header(data: bytes) -> bytes:
    out = bytearray(HEADER_SIZE)
    for i in range(HEADER_SIZE):
        out[i] = data[i] ^ ((i - 0x34) & 0xFF)
    return bytes(out)


def decrypt_section(file_data: bytes, header: bytes,
                    off_field: int, adj: int,
                    size_field: int, sign_minus: bool) -> tuple[bytes, int, int]:
    src_off = struct.unpack_from('<I', header, off_field)[0] + adj
    size = struct.unpack_from('<I', header, size_field)[0]
    size_byte = header[size_field]  # low byte of the size dword
    src = file_data[src_off:src_off + size]
    out = bytearray(size)
    if sign_minus:
        for i in range(size):
            out[i] = src[i] ^ ((i - size_byte + 35) & 0xFF)
    else:
        for i in range(size):
            out[i] = src[i] ^ ((size_byte + i - 35) & 0xFF)
    return bytes(out), src_off, size


def main() -> None:
    print(f'[+] reading {GMD.name} ({GMD.stat().st_size:,} bytes)')
    enc = GMD.read_bytes()

    print('[+] decrypting header (0x148 bytes) with key[i] = (i - 0x34) & 0xFF')
    header = decrypt_header(enc)

    sanity, version = struct.unpack_from('<II', header, 0)
    print(f'    sanity = 0x{sanity:08X}  (expected 0xFAB11BAF)')
    print(f'    version = {version}')

    if sanity != 0xFAB11BAF:
        print('[!] sanity mismatch -- header decrypt is wrong')
        # Still dump first dwords for inspection
        print('    decoded header dwords +0..+0x40:')
        for i in range(0, 0x40, 4):
            d = struct.unpack_from('<I', header, i)[0]
            print(f'      +0x{i:03X}: 0x{d:08X} ({d})')

    # Always also dump all section size + offset fields for investigation
    print('    inferred section fields:')
    for off in range(0, HEADER_SIZE, 4):
        d = struct.unpack_from('<I', header, off)[0]
        if 0 < d < 0x023C0000:  # plausible file offset
            print(f'      +0x{off:03X}: 0x{d:08X} (offset)')

    out_buf = bytearray(enc)  # start with encrypted, overwrite header + sections
    out_buf[:HEADER_SIZE] = header

    # Decrypt all 7 sections
    for (off_f, adj, size_f, sm) in SECTIONS:
        try:
            section, src_off, size = decrypt_section(enc, header, off_f, adj, size_f, sm)
            print(f'  section off_f={off_f:>3} adj={adj:+3} size_f={size_f:>3} sign={"-" if sm else "+"}: '
                  f'src=0x{src_off:08X} size=0x{size:X}')
            # Splice decrypted section back at its source location
            if size > 0 and src_off + size <= len(enc):
                out_buf[src_off:src_off + size] = section
        except Exception as e:
            print(f'  section off_f={off_f}: error {e}')

    OUT.parent.mkdir(parents=True, exist_ok=True)
    OUT.write_bytes(bytes(out_buf))
    print(f'[+] wrote {OUT}')


if __name__ == '__main__':
    main()
