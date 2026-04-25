#!/usr/bin/env python3
"""
Patch EOSSDK-Win64-Shipping.dll to fake anti-cheat availability.
Makes EOS_Platform_GetAntiCheatClientInterface return non-null.
Makes EOS_AntiCheatClient_BeginSession return EOS_Success (0).

This prevents VRChat from entering "offline testing mode" when launched
without the EAC bootstrapper.

Usage:
  python tools/patch_eossdk.py            # apply patches
  python tools/patch_eossdk.py --restore  # restore backup
  python tools/patch_eossdk.py --check    # check status
"""
import sys
import os
import struct
import shutil
import argparse

sys.stdout.reconfigure(encoding='utf-8')

# EOSSDK location (Steam dir)
STEAM_DIR = r"D:\Steam\steamapps\common\VRChat"
EOS_DLL = os.path.join(STEAM_DIR, "VRChat_Data", "Plugins", "x86_64", "EOSSDK-Win64-Shipping.dll")
EOS_BAK = EOS_DLL + ".bak"


def parse_pe_exports(data: bytes) -> dict:
    """Parse PE exports and return {name: file_offset}."""
    pe_off = struct.unpack_from('<I', data, 0x3C)[0]
    opt_off = pe_off + 0x18
    magic = struct.unpack_from('<H', data, opt_off)[0]
    assert magic == 0x20B, "Not PE32+"

    export_rva = struct.unpack_from('<I', data, opt_off + 112)[0]
    num_sections = struct.unpack_from('<H', data, pe_off + 6)[0]
    opt_size = struct.unpack_from('<H', data, pe_off + 20)[0]
    sec_start = pe_off + 0x18 + opt_size

    sections = []
    for i in range(num_sections):
        off = sec_start + i * 40
        va = struct.unpack_from('<I', data, off + 12)[0]
        vsz = struct.unpack_from('<I', data, off + 8)[0]
        ro = struct.unpack_from('<I', data, off + 20)[0]
        sections.append((va, vsz, ro))

    def rva2fo(rva):
        for va, vsz, ro in sections:
            if va <= rva < va + vsz:
                return rva - va + ro
        return None

    ed_fo = rva2fo(export_rva)
    num_names = struct.unpack_from('<I', data, ed_fo + 24)[0]
    names_rva = struct.unpack_from('<I', data, ed_fo + 32)[0]
    ords_rva = struct.unpack_from('<I', data, ed_fo + 36)[0]
    funcs_rva = struct.unpack_from('<I', data, ed_fo + 28)[0]

    exports = {}
    for i in range(num_names):
        nrva = struct.unpack_from('<I', data, rva2fo(names_rva) + i * 4)[0]
        name = data[rva2fo(nrva):rva2fo(nrva) + 120].split(b'\x00')[0].decode()
        ordinal = struct.unpack_from('<H', data, rva2fo(ords_rva) + i * 2)[0]
        frva = struct.unpack_from('<I', data, rva2fo(funcs_rva) + ordinal * 4)[0]
        ffo = rva2fo(frva)
        if ffo is not None:
            exports[name] = (frva, ffo)
    return exports


# Patches: (export_name, original_bytes, patched_bytes, description)
# GetAntiCheatClientInterface: return 1 instead of checking platform
#   Original: 48 83 ec 38 48 85 c9 75 2e
#   Patched:  48 31 c0 48 ff c0 c3 90 90 (xor rax,rax; inc rax; ret; nop; nop)
#
# BeginSession: return 0 (EOS_Success)
#   Need to find its bytes first

PATCHES = {}


def find_patches(data: bytes, exports: dict):
    """Dynamically find patches based on export addresses."""
    patches = []

    # 1. GetAntiCheatClientInterface → return 1
    name = 'EOS_Platform_GetAntiCheatClientInterface'
    if name in exports:
        rva, foff = exports[name]
        orig = data[foff:foff + 9]
        expected = b'\x48\x83\xec\x38\x48\x85\xc9\x75\x2e'
        if orig == expected:
            # xor rax,rax; inc rax; ret; nop*4
            patched = b'\x48\x31\xc0\x48\xff\xc0\xc3\x90\x90'
            patches.append((name, foff, orig, patched, "return 1 (non-null)"))
        elif orig[:3] == b'\x48\x31\xc0':
            patches.append((name, foff, None, None, "already patched"))
        else:
            print(f"  [!] {name}: unexpected bytes at 0x{foff:X}: {orig.hex()}")

    # 2. BeginSession → return 0 (EOS_Success)
    name = 'EOS_AntiCheatClient_BeginSession'
    if name in exports:
        rva, foff = exports[name]
        orig = data[foff:foff + 8]
        # Original first bytes vary, but we replace with: xor eax,eax; ret; nop*5
        patched = b'\x31\xc0\xc3\x90\x90\x90\x90\x90'
        if orig[:3] == b'\x31\xc0\xc3':
            patches.append((name, foff, None, None, "already patched"))
        else:
            patches.append((name, foff, orig, patched, "return EOS_Success"))

    # 3. EndSession → return 0
    name = 'EOS_AntiCheatClient_EndSession'
    if name in exports:
        rva, foff = exports[name]
        orig = data[foff:foff + 8]
        patched = b'\x31\xc0\xc3\x90\x90\x90\x90\x90'
        if orig[:3] == b'\x31\xc0\xc3':
            patches.append((name, foff, None, None, "already patched"))
        else:
            patches.append((name, foff, orig, patched, "return EOS_Success"))

    # 4. PollStatus → return 0
    name = 'EOS_AntiCheatClient_PollStatus'
    if name in exports:
        rva, foff = exports[name]
        orig = data[foff:foff + 8]
        patched = b'\x31\xc0\xc3\x90\x90\x90\x90\x90'
        if orig[:3] == b'\x31\xc0\xc3':
            patches.append((name, foff, None, None, "already patched"))
        else:
            patches.append((name, foff, orig, patched, "return EOS_Success"))

    return patches


def main():
    parser = argparse.ArgumentParser(description="Patch EOSSDK anti-cheat")
    parser.add_argument('--restore', action='store_true')
    parser.add_argument('--check', action='store_true')
    # Also allow patching workspace copy
    parser.add_argument('--workspace', action='store_true',
                        help='Patch workspace copy instead of Steam')
    args = parser.parse_args()

    dll_path = EOS_DLL
    if args.workspace:
        dll_path = os.path.join(
            os.path.dirname(os.path.dirname(os.path.dirname(
                os.path.dirname(os.path.abspath(__file__))))),
            "VRChat_Data", "Plugins", "x86_64", "EOSSDK-Win64-Shipping.dll")
    bak_path = dll_path + ".bak"

    print("=" * 60)
    print("  EOSSDK Anti-Cheat Patcher")
    print("=" * 60)
    print(f"  DLL: {dll_path}")

    if not os.path.exists(dll_path):
        print(f"[!] File not found: {dll_path}")
        return

    print(f"  Size: {os.path.getsize(dll_path) / 1024:.0f} KB")

    if args.restore:
        if os.path.exists(bak_path):
            shutil.copy2(bak_path, dll_path)
            print("[✓] Restored from backup")
        else:
            print("[!] No backup found")
        return

    with open(dll_path, 'rb') as f:
        data = f.read()

    exports = parse_pe_exports(data)
    patches = find_patches(data, exports)

    if args.check:
        print("\nPatch Status:")
        for name, foff, orig, patched, desc in patches:
            sym = "✓" if patched is None else "○"
            print(f"  [{sym}] {name}: {desc}")
        return

    # Create backup
    if not os.path.exists(bak_path):
        shutil.copy2(dll_path, bak_path)
        print(f"[*] Backed up: {bak_path}")

    data = bytearray(data)
    total = 0

    for name, foff, orig, patched, desc in patches:
        if patched is None:
            print(f"  [·] {name}: {desc}")
            continue
        data[foff:foff + len(patched)] = patched
        print(f"  [✓] {name}: {desc} at 0x{foff:X}")
        total += 1

    if total > 0:
        with open(dll_path, 'wb') as f:
            f.write(data)
        print(f"\n[✓] {total} patches applied to EOSSDK")
    else:
        print("\n[*] No patches needed")

    print("=" * 60)


if __name__ == '__main__':
    main()
