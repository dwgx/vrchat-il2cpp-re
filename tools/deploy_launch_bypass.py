#!/usr/bin/env python3
"""
Deploy launch_bypass.exe to the Steam VRChat directory.
Backs up original launch.exe → launch_original.exe, then copies bypass version.
Use --restore to undo.

This lets Steam provide Steam API context (overlay, SteamAppId, IPC pipes)
while skipping EAC, so Frida and patched DLLs work.

Usage:
  python tools/deploy_launch_bypass.py                    # deploy to workspace
  python tools/deploy_launch_bypass.py --steam             # deploy to Steam dir
  python tools/deploy_launch_bypass.py --restore           # restore original
  python tools/deploy_launch_bypass.py --restore --steam   # restore Steam dir
"""
import sys
import os
import shutil
import argparse

sys.stdout.reconfigure(encoding='utf-8')

TOOLS_DIR = os.path.dirname(os.path.abspath(__file__))
BYPASS_EXE = os.path.join(TOOLS_DIR, "launch_bypass.exe")

# Two possible VRChat directories
WORKSPACE_DIR = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(
    os.path.dirname(os.path.abspath(__file__))))))
STEAM_DIR = r"D:\Steam\steamapps\common\VRChat"


def deploy(target_dir: str, restore: bool = False):
    launch = os.path.join(target_dir, "launch.exe")
    launch_orig = os.path.join(target_dir, "launch_original.exe")

    if not os.path.exists(target_dir):
        print(f"[!] Directory not found: {target_dir}")
        return False

    if restore:
        if os.path.exists(launch_orig):
            shutil.copy2(launch_orig, launch)
            print(f"[✓] Restored original launch.exe in {target_dir}")
            return True
        else:
            print(f"[!] No backup found: {launch_orig}")
            return False

    if not os.path.exists(BYPASS_EXE):
        print(f"[!] Bypass exe not found: {BYPASS_EXE}")
        print("    Compile first: csc /out:launch_bypass.exe /target:winexe launch_bypass.cs")
        return False

    # Backup original
    if not os.path.exists(launch_orig) and os.path.exists(launch):
        shutil.copy2(launch, launch_orig)
        orig_size = os.path.getsize(launch_orig)
        print(f"[*] Backed up original launch.exe ({orig_size/1024:.1f} KB) → launch_original.exe")

    # Deploy bypass
    shutil.copy2(BYPASS_EXE, launch)
    new_size = os.path.getsize(launch)
    print(f"[✓] Deployed launch_bypass.exe ({new_size/1024:.1f} KB) → {launch}")
    print(f"    VRChat.exe will be started directly (no EAC)")
    return True


def main():
    parser = argparse.ArgumentParser(description="Deploy EAC bypass launcher")
    parser.add_argument('--steam', action='store_true', help='Deploy to Steam directory')
    parser.add_argument('--restore', action='store_true', help='Restore original launch.exe')
    args = parser.parse_args()

    target = STEAM_DIR if args.steam else WORKSPACE_DIR

    print("=" * 60)
    print("  Launch Bypass Deployer")
    print("=" * 60)
    print(f"  Target: {target}")
    print(f"  Action: {'restore' if args.restore else 'deploy'}")
    print()

    deploy(target, args.restore)
    print("=" * 60)


if __name__ == '__main__':
    main()
