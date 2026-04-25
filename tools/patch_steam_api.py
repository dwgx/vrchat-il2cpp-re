#!/usr/bin/env python3
"""
Patch steam_api64.dll to fake successful Steam initialization.
Creates a backup (.bak) before patching. Use --restore to undo.

Patches:
1. SteamAPI_Init → return true (mov al,1; ret)
2. SteamAPI_InitSafe → return true (mov al,1; ret)
3. SteamAPI_RestartAppIfNecessary → return false (xor eax,eax; ret)

Usage:
  python tools/patch_steam_api.py            # apply patches
  python tools/patch_steam_api.py --restore  # restore backup
  python tools/patch_steam_api.py --check    # check patch status
"""
import sys
import os
import shutil
import argparse

sys.stdout.reconfigure(encoding='utf-8')

STEAM_DLL = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(
    os.path.dirname(os.path.abspath(__file__))))),
    "VRChat_Data", "Plugins", "x86_64", "steam_api64.dll")
STEAM_BAK = STEAM_DLL + ".bak"

# Patches: (file_offset, original_bytes, patched_bytes, description)
PATCHES = [
    # SteamAPI_Init at file offset 0x6C10
    # Original: 33 c9 e9 89 f2 ff ff (xor ecx,ecx; jmp internal_init)
    # Patched: b0 01 c3 90 90 90 90 (mov al,1; ret; nops)
    (0x6C10, b'\x33\xc9\xe9\x89\xf2\xff\xff',
     b'\xb0\x01\xc3\x90\x90\x90\x90', "SteamAPI_Init → true"),

    # SteamAPI_InitSafe at file offset 0x6C30
    # Original: 48 83 ec 28 33 c9 e8 65 f2 ff ff (sub rsp,28; xor ecx,ecx; call)
    # Patched: b0 01 c3 90 90 90 90 90 90 90 90 (mov al,1; ret; nops)
    (0x6C30, b'\x48\x83\xec\x28\x33\xc9\xe8\x65\xf2\xff\xff',
     b'\xb0\x01\xc3\x90\x90\x90\x90\x90\x90\x90\x90', "SteamAPI_InitSafe → true"),

    # SteamAPI_RestartAppIfNecessary at file offset 0x6FB0
    # Original: 48 89 5c 24 20 55 56 57 (mov [rsp+20],rbx; push rbp; push rsi; push rdi)
    # Patched: 31 c0 c3 90 90 90 90 90 (xor eax,eax; ret; nops)
    (0x6FB0, b'\x48\x89\x5c\x24\x20\x55\x56\x57',
     b'\x31\xc0\xc3\x90\x90\x90\x90\x90', "SteamAPI_RestartAppIfNecessary → false"),
]


def main():
    parser = argparse.ArgumentParser(description="Patch steam_api64.dll")
    parser.add_argument('--restore', action='store_true', help='Restore backup')
    parser.add_argument('--check', action='store_true', help='Check patch status')
    args = parser.parse_args()

    print("=" * 60)
    print("  steam_api64.dll Patcher")
    print("=" * 60)
    print(f"  DLL: {STEAM_DLL}")

    if not os.path.exists(STEAM_DLL):
        print(f"[!] File not found: {STEAM_DLL}")
        return

    print(f"  Size: {os.path.getsize(STEAM_DLL) / 1024:.1f} KB")

    if args.restore:
        if os.path.exists(STEAM_BAK):
            shutil.copy2(STEAM_BAK, STEAM_DLL)
            print("[✓] Restored from backup")
        else:
            print("[!] No backup found")
        return

    with open(STEAM_DLL, 'rb') as f:
        data = f.read()

    if args.check:
        print("\nPatch Status:")
        for foff, orig, patched, desc in PATCHES:
            actual = bytes(data[foff:foff + len(orig)])
            if actual == patched[:len(orig)]:
                print(f"  [✓] {desc} at 0x{foff:X} — PATCHED")
            elif actual == orig:
                print(f"  [○] {desc} at 0x{foff:X} — original")
            else:
                print(f"  [?] {desc} at 0x{foff:X} — unknown: {actual.hex()}")
        return

    # Create backup
    if not os.path.exists(STEAM_BAK):
        print(f"\n[*] Creating backup: {STEAM_BAK}")
        shutil.copy2(STEAM_DLL, STEAM_BAK)
    else:
        print(f"[*] Backup exists: {STEAM_BAK}")

    data = bytearray(data)
    total = 0

    for foff, orig, patched, desc in PATCHES:
        actual = bytes(data[foff:foff + len(orig)])
        if actual == orig:
            data[foff:foff + len(patched)] = patched
            print(f"  [✓] {desc} at 0x{foff:X}")
            total += 1
        elif actual == patched[:len(orig)]:
            print(f"  [·] {desc} already patched")
        else:
            print(f"  [!] {desc}: unexpected bytes at 0x{foff:X}: {actual.hex()}")

    if total > 0:
        with open(STEAM_DLL, 'wb') as f:
            f.write(data)
        print(f"\n[✓] {total} patches applied to steam_api64.dll")
    else:
        print("\n[*] No patches needed")

    print("=" * 60)


if __name__ == '__main__':
    main()
