#!/usr/bin/env python
"""
take_new_dump.py - Take a fresh VRChat memory dump.

Usage:
  1. Launch VRChat (directly, not via EAC: VRChat.exe --no-vr or similar)
  2. Play for a while (join worlds, open menus) to initialize more types
  3. Run: python take_new_dump.py

Uses Windows comsvcs.dll MiniDumpWriteDump (available on all Windows).
Alternatively uses procdump if available.
"""

import ctypes
import ctypes.wintypes
import os
import sys
import time
import subprocess

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

OUTPUT_DIR = os.path.dirname(os.path.abspath(__file__))


def find_vrchat_pid():
    """Find VRChat.exe PID using tasklist."""
    try:
        out = subprocess.check_output(
            ["tasklist", "/FI", "IMAGENAME eq VRChat.exe", "/FO", "CSV", "/NH"],
            text=True, errors="replace"
        )
        for line in out.strip().split("\n"):
            parts = line.strip().strip('"').split('","')
            if len(parts) >= 2 and "VRChat" in parts[0]:
                return int(parts[1].strip('"'))
    except Exception:
        pass

    # Fallback: wmic
    try:
        out = subprocess.check_output(
            ["wmic", "process", "where", "name='VRChat.exe'", "get", "ProcessId"],
            text=True, errors="replace"
        )
        for line in out.strip().split("\n"):
            line = line.strip()
            if line.isdigit():
                return int(line)
    except Exception:
        pass

    return None


def dump_with_comsvcs(pid, output_path):
    """Use comsvcs.dll MiniDumpWriteDump (no external tools needed)."""
    # rundll32 comsvcs.dll, MiniDump <pid> <path> full
    cmd = f'rundll32.exe comsvcs.dll, MiniDump {pid} {output_path} full'
    print(f"[+] Running: {cmd}")
    result = subprocess.run(cmd, shell=True, capture_output=True, text=True, timeout=300)
    if result.returncode != 0:
        print(f"[-] comsvcs failed: {result.stderr}")
        return False
    return os.path.exists(output_path)


def dump_with_procdump(pid, output_path):
    """Use procdump if available."""
    try:
        subprocess.run(["procdump", "-?"], capture_output=True, timeout=5)
    except FileNotFoundError:
        return False

    cmd = ["procdump", "-ma", str(pid), output_path]
    print(f"[+] Running: {' '.join(cmd)}")
    result = subprocess.run(cmd, capture_output=True, text=True, timeout=300)
    return os.path.exists(output_path)


def dump_with_ctypes(pid, output_path):
    """Use ctypes MiniDumpWriteDump directly."""
    PROCESS_ALL_ACCESS = 0x1F0FFF
    MiniDumpWithFullMemory = 0x00000002

    kernel32 = ctypes.windll.kernel32
    dbghelp = ctypes.windll.dbghelp

    hProcess = kernel32.OpenProcess(PROCESS_ALL_ACCESS, False, pid)
    if not hProcess:
        print(f"[-] OpenProcess failed (error {kernel32.GetLastError()}). Run as admin?")
        return False

    try:
        hFile = kernel32.CreateFileW(
            output_path, 0x40000000, 0, None, 2, 0x80, None
        )
        if hFile == -1:
            print(f"[-] CreateFile failed (error {kernel32.GetLastError()})")
            return False

        try:
            ok = dbghelp.MiniDumpWriteDump(
                hProcess, pid, hFile, MiniDumpWithFullMemory,
                None, None, None
            )
            if not ok:
                print(f"[-] MiniDumpWriteDump failed (error {kernel32.GetLastError()})")
                return False
            return True
        finally:
            kernel32.CloseHandle(hFile)
    finally:
        kernel32.CloseHandle(hProcess)


def main():
    print("[+] Looking for VRChat.exe...")
    pid = find_vrchat_pid()
    if not pid:
        print("[-] VRChat.exe not found. Make sure it's running.")
        print("    Launch it directly (not via Steam/EAC) for Frida access.")
        sys.exit(1)

    print(f"[+] Found VRChat.exe (PID {pid})")

    timestamp = time.strftime("%Y%m%d_%H%M%S")
    output_path = os.path.join(OUTPUT_DIR, f"VRChat_{pid}_{timestamp}_full.dmp")

    print(f"[+] Output: {output_path}")
    print(f"[+] Taking full memory dump (this may take 1-2 minutes)...")
    t0 = time.time()

    # Try methods in order
    success = False

    # Method 1: ctypes (most reliable, needs admin)
    print("[+] Trying ctypes MiniDumpWriteDump...")
    success = dump_with_ctypes(pid, output_path)

    if not success:
        # Method 2: procdump
        print("[+] Trying procdump...")
        success = dump_with_procdump(pid, output_path)

    if not success:
        # Method 3: comsvcs.dll
        print("[+] Trying comsvcs.dll...")
        success = dump_with_comsvcs(pid, output_path)

    if success and os.path.exists(output_path):
        size = os.path.getsize(output_path)
        elapsed = time.time() - t0
        print(f"\n[+] Dump complete!")
        print(f"    File: {output_path}")
        print(f"    Size: {size / 1024 / 1024 / 1024:.1f}GB")
        print(f"    Time: {elapsed:.0f}s")
        print(f"\n[+] Next: run extract_precise_dump.py with DUMP_PATH updated")
    else:
        print("\n[-] All dump methods failed.")
        print("    Try running as Administrator.")
        print("    Or install procdump: https://learn.microsoft.com/en-us/sysinternals/downloads/procdump")
        sys.exit(1)


if __name__ == "__main__":
    main()
