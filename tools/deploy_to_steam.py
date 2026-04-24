#!/usr/bin/env python3
"""
One-click deploy: patch everything and deploy to the Steam VRChat directory.
1. Deploy launch_bypass.exe → launch.exe (skip EAC)
2. Apply binary patches to GameAssembly.dll (6 offline-mode patches)
All with backups. Use --restore to undo everything.

Usage:
  python tools/deploy_to_steam.py            # deploy + patch
  python tools/deploy_to_steam.py --restore  # restore all originals
  python tools/deploy_to_steam.py --check    # check status
"""
import sys
import os
import shutil
import argparse

sys.stdout.reconfigure(encoding='utf-8')

TOOLS_DIR = os.path.dirname(os.path.abspath(__file__))
STEAM_DIR = r"D:\Steam\steamapps\common\VRChat"
BYPASS_EXE = os.path.join(TOOLS_DIR, "launch_bypass.exe")

# Import the GA patcher functions
sys.path.insert(0, TOOLS_DIR)
from patch_ga_binary import (
    DELTA, find_pattern,
    patch_location_isoffline, patch_api_isoffline,
    patch_connect_error_state, patch_offline_error_call,
    patch_join_branch, patch_join_offline_check,
    patch_secondary_offline_check, patch_fake_eac_flag,
    patch_enterworld_nullref, patch_gohome_photon_check,
    check_patches
)


def deploy_launch(steam_dir: str, restore: bool = False) -> bool:
    launch = os.path.join(steam_dir, "launch.exe")
    launch_orig = os.path.join(steam_dir, "launch_original.exe")

    if restore:
        if os.path.exists(launch_orig):
            shutil.copy2(launch_orig, launch)
            print("[✓] launch.exe restored from backup")
            return True
        else:
            print("[!] No launch backup found")
            return False

    if not os.path.exists(BYPASS_EXE):
        print(f"[!] {BYPASS_EXE} not found — compile it first")
        return False

    if not os.path.exists(launch_orig) and os.path.exists(launch):
        shutil.copy2(launch, launch_orig)
        print(f"[*] Backed up launch.exe ({os.path.getsize(launch_orig)//1024} KB)")

    shutil.copy2(BYPASS_EXE, launch)
    print(f"[✓] launch_bypass.exe deployed ({os.path.getsize(launch)//1024} KB)")
    return True


def patch_ga(steam_dir: str, restore: bool = False, check_only: bool = False) -> bool:
    ga_path = os.path.join(steam_dir, "GameAssembly.dll")
    ga_bak = ga_path + ".bak"

    if not os.path.exists(ga_path):
        print(f"[!] {ga_path} not found")
        return False

    if restore:
        if os.path.exists(ga_bak):
            shutil.copy2(ga_bak, ga_path)
            print("[✓] GameAssembly.dll restored from backup")
            return True
        else:
            print("[!] No GA backup found")
            return False

    with open(ga_path, 'rb') as f:
        data = f.read()

    if check_only:
        status = check_patches(data)
        for name, (state, offset) in sorted(status.items()):
            sym = "✓" if state == "patched" else "○"
            print(f"  [{sym}] {name}: {state} at 0x{offset:X}")
        return True

    # Create backup
    if not os.path.exists(ga_bak):
        shutil.copy2(ga_path, ga_bak)
        print(f"[*] Backed up GameAssembly.dll ({os.path.getsize(ga_bak)/1024/1024:.0f} MB)")

    data = bytearray(data)
    total = 0
    total += patch_location_isoffline(data)
    total += patch_api_isoffline(data)
    total += patch_connect_error_state(data)
    # Patches 5-6 now INCLUDED — needed to suppress offline error generator
    # (previously skipped for Steam, but Patch 9 changes the flow to need them)
    total += patch_offline_error_call(data)
    total += patch_join_branch(data)
    total += patch_join_offline_check(data)
    total += patch_secondary_offline_check(data)
    total += patch_fake_eac_flag(data)
    total += patch_enterworld_nullref(data)
    # Patch 11 disabled for now — using Frida v4 retrigger instead
    # total += patch_gohome_photon_check(data)

    if total > 0:
        with open(ga_path, 'wb') as f:
            f.write(data)
        print(f"[✓] {total} patches applied to GameAssembly.dll")
    else:
        print("[*] GameAssembly.dll already patched or no changes needed")
    return True


def main():
    parser = argparse.ArgumentParser(description="Deploy patches to Steam VRChat")
    parser.add_argument('--restore', action='store_true')
    parser.add_argument('--check', action='store_true')
    args = parser.parse_args()

    print("=" * 60)
    print("  Steam VRChat Full Deploy")
    print("=" * 60)
    print(f"  Steam dir: {STEAM_DIR}")
    print(f"  Action: {'restore' if args.restore else 'check' if args.check else 'deploy'}")
    print()

    if not os.path.isdir(STEAM_DIR):
        print(f"[!] Steam directory not found: {STEAM_DIR}")
        return

    if args.check:
        print("[Launch]")
        launch = os.path.join(STEAM_DIR, "launch.exe")
        launch_orig = os.path.join(STEAM_DIR, "launch_original.exe")
        if os.path.exists(launch_orig):
            sz = os.path.getsize(launch)
            print(f"  launch.exe: {sz} bytes ({'bypass' if sz < 10000 else 'original'})")
        else:
            print("  launch.exe: original (no backup)")
        print("\n[GameAssembly.dll]")
        patch_ga(STEAM_DIR, check_only=True)
        print("=" * 60)
        return

    if args.restore:
        print("[1] Restoring launch.exe...")
        deploy_launch(STEAM_DIR, restore=True)
        print("\n[2] Restoring GameAssembly.dll...")
        patch_ga(STEAM_DIR, restore=True)
    else:
        print("[1] Deploying bypass launcher...")
        deploy_launch(STEAM_DIR)
        print("\n[2] Patching GameAssembly.dll...")
        patch_ga(STEAM_DIR)
        print()
        print("  ✅ Ready! Launch VRChat from Steam.")
        print("  Steam provides API context, EAC is bypassed.")
        print("  Frida can attach after VRChat starts.")

    print("=" * 60)


if __name__ == '__main__':
    main()
