#!/usr/bin/env python
"""
bridge.py - Launch IL2CPP bridge for VRChat.

Attaches Frida to VRChat and loads bridge.js, which installs a trampoline
in GameAssembly.dll's data section to bypass the return address check.

Usage:
  python bridge.py              # Auto-find VRChat
  python bridge.py --pid 12345  # Attach to specific PID
  python bridge.py --spawn      # Spawn VRChat.exe

Prerequisites:
  pip install frida frida-tools
"""

import frida
import sys
import os
import json
import argparse
import subprocess
import time

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
BRIDGE_JS = os.path.join(SCRIPT_DIR, "bridge.js")
REAL_FUNCS = os.path.join(SCRIPT_DIR, "il2cpp_full_dump", "real_functions.json")


def find_vrchat_pid():
    try:
        out = subprocess.check_output(
            ["tasklist", "/FI", "IMAGENAME eq VRChat.exe", "/FO", "CSV", "/NH"],
            text=True, errors="replace",
        )
        for line in out.strip().split("\n"):
            parts = line.strip().strip('"').split('","')
            if len(parts) >= 2 and "VRChat" in parts[0]:
                return int(parts[1].strip('"'))
    except Exception:
        pass
    return None


def on_message(message, data):
    if message["type"] == "send":
        payload = message["payload"]
        if isinstance(payload, dict):
            mtype = payload.get("type", "")
            msg = payload.get("msg", "")
            if mtype == "error":
                print(f"  [!] {msg}")
            elif mtype == "result":
                ok = payload.get("success", False)
                mark = "OK" if ok else "FAIL"
                print(f"  [{mark}] {msg}")
            elif mtype == "probe":
                print(f"  [probe] {payload.get('name','?')}: {payload.get('result','?')}")
            else:
                print(f"  [*] {msg}")
        else:
            print(f"  [msg] {payload}")
    elif message["type"] == "error":
        print(f"  [ERR] {message.get('description', message)}")


def interactive_mode(script):
    """Simple REPL to call exports through the bridge."""
    print("\n--- IL2CPP Bridge Interactive Mode ---")
    print("Commands:")
    print("  call <export_name> [arg1] [arg2] ...  - Call an export")
    print("  exports                                - List all exports")
    print("  apis                                   - List known API mappings")
    print("  addr <name>                            - Get export address")
    print("  quit                                   - Exit")
    print()

    while True:
        try:
            line = input("bridge> ").strip()
        except (EOFError, KeyboardInterrupt):
            break

        if not line:
            continue

        parts = line.split()
        cmd = parts[0].lower()

        try:
            if cmd == "quit" or cmd == "exit":
                break
            elif cmd == "exports":
                exports = script.exports_sync.list_exports()
                print(f"  {len(exports)} exports:")
                for e in sorted(exports)[:20]:
                    print(f"    {e}")
                if len(exports) > 20:
                    print(f"    ... and {len(exports) - 20} more")
            elif cmd == "apis":
                apis = script.exports_sync.list_apis()
                print(f"  {len(apis)} known APIs:")
                for a in sorted(apis):
                    addr = script.exports_sync.get_export_addr(a)
                    print(f"    {a}: {addr}")
            elif cmd == "addr" and len(parts) >= 2:
                addr = script.exports_sync.get_export_addr(parts[1])
                print(f"  {parts[1]}: {addr}")
            elif cmd == "call" and len(parts) >= 2:
                name = parts[1]
                args = [parts[i] if i < len(parts) else "0" for i in range(2, 6)]
                result = script.exports_sync.call(name, *args)
                print(f"  Result: {result}")
            else:
                print(f"  Unknown command: {cmd}")
        except Exception as e:
            print(f"  Error: {e}")


def main():
    parser = argparse.ArgumentParser(description="VRChat IL2CPP Bridge")
    parser.add_argument("--pid", type=int, help="VRChat PID")
    parser.add_argument("--spawn", action="store_true", help="Spawn VRChat.exe")
    parser.add_argument("--no-interactive", action="store_true", help="Exit after init")
    args = parser.parse_args()

    # Load bridge script
    with open(BRIDGE_JS, "r") as f:
        js_code = f.read()

    pid = args.pid
    session = None

    if args.spawn:
        # Look for VRChat.exe
        vrchat_path = os.path.join(os.path.dirname(SCRIPT_DIR), "VRChat.exe")
        if not os.path.exists(vrchat_path):
            # Try common locations
            for p in [
                r"C:\Program Files (x86)\Steam\steamapps\common\VRChat\VRChat.exe",
                os.path.expandvars(r"%LOCALAPPDATA%\VRChat\VRChat.exe"),
            ]:
                if os.path.exists(p):
                    vrchat_path = p
                    break
        print(f"[+] Spawning: {vrchat_path}")
        device = frida.get_local_device()
        pid = device.spawn([vrchat_path])
        session = device.attach(pid)
        # Don't resume yet - let bridge install first
    else:
        if not pid:
            print("[+] Looking for VRChat.exe...")
            pid = find_vrchat_pid()
            if not pid:
                print("[-] VRChat.exe not found. Start it first or use --pid.")
                sys.exit(1)

        print(f"[+] Attaching to PID {pid}...")
        session = frida.attach(pid)

    print(f"[+] Loading bridge.js...")
    script = session.create_script(js_code)
    script.on("message", on_message)
    script.load()

    if args.spawn:
        print("[+] Resuming process...")
        frida.get_local_device().resume(pid)
        time.sleep(3)  # Wait for initialization

    if not args.no_interactive:
        interactive_mode(script)

    print("[+] Detaching...")
    session.detach()


if __name__ == "__main__":
    main()
