#!/usr/bin/env python3
"""
Launch VRChat with Frida timing fix.

Starts VRChat via the bypass launcher, waits for it to initialize,
attaches Frida with the timing fix script, and monitors the output.

The timing fix hooks the join coroutine to block until Photon connects,
solving the race condition where VRChat tries to join a world before
the network layer is ready.

Usage:
  python tools/frida_launch_test.py              # launch + attach + monitor
  python tools/frida_launch_test.py --attach-only  # attach to running VRChat
  python tools/frida_launch_test.py --timeout 120   # custom timeout (seconds)
"""
import sys
import os
import time
import subprocess
import signal
import argparse
import threading

sys.stdout.reconfigure(encoding='utf-8')

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
WORKSPACE = os.path.dirname(SCRIPT_DIR)
STEAM_DIR = r"D:\Steam\steamapps\common\VRChat"
LAUNCH_EXE = os.path.join(STEAM_DIR, "launch.exe")
FRIDA_SCRIPT = os.path.join(SCRIPT_DIR, "frida_timing_fix.js")
LOG_DIR = os.path.join(os.environ["LOCALAPPDATA"] + "Low", "VRChat", "VRChat")


def find_latest_log():
    """Find the most recent VRChat output log."""
    logs = []
    for f in os.listdir(LOG_DIR):
        if f.startswith("output_log_") and f.endswith(".txt"):
            logs.append(os.path.join(LOG_DIR, f))
    if not logs:
        return None
    return max(logs, key=os.path.getmtime)


def tail_log(log_path, stop_event, keywords=None):
    """Tail a log file, printing lines matching keywords."""
    if keywords is None:
        keywords = [
            "Destination", "Failed to join", "Error World",
            "OnConnected", "Entering Room", "Successfully joined",
            "Going to", "set connect error",
            "EnterWorld", "NullRef", "Error invoking",
        ]

    try:
        with open(log_path, 'r', encoding='utf-8', errors='replace') as f:
            # Seek to end
            f.seek(0, 2)
            while not stop_event.is_set():
                line = f.readline()
                if not line:
                    time.sleep(0.2)
                    continue
                line = line.rstrip()
                if any(kw.lower() in line.lower() for kw in keywords):
                    print(f"[LOG] {line}")
    except Exception as e:
        print(f"[LOG TAIL ERROR] {e}")


def wait_for_process(name, timeout=30):
    """Wait for a process to appear."""
    import ctypes
    from ctypes import wintypes

    print(f"Waiting for {name} to start...")
    start = time.time()
    while time.time() - start < timeout:
        result = subprocess.run(
            ["tasklist", "/FI", f"IMAGENAME eq {name}", "/FO", "CSV", "/NH"],
            capture_output=True, text=True
        )
        if name.lower() in result.stdout.lower():
            # Extract PID
            for line in result.stdout.strip().split('\n'):
                parts = line.strip('"').split('","')
                if len(parts) >= 2 and name.lower() in parts[0].lower():
                    return int(parts[1])
        time.sleep(0.5)
    return None


def main():
    parser = argparse.ArgumentParser(description="Launch VRChat with Frida timing fix")
    parser.add_argument('--attach-only', action='store_true',
                        help='Attach to already-running VRChat')
    parser.add_argument('--spawn', action='store_true',
                        help='Use Frida spawn mode (inject before any code runs)')
    parser.add_argument('--timeout', type=int, default=180,
                        help='Monitoring timeout in seconds (default: 180)')
    args = parser.parse_args()

    try:
        import frida
    except ImportError:
        print("[!] frida package not found. Install with: pip install frida frida-tools")
        sys.exit(1)

    # Read the Frida script
    with open(FRIDA_SCRIPT, 'r', encoding='utf-8') as f:
        script_code = f.read()

    print("=" * 60)
    print("  VRChat Frida Timing Fix Test v2")
    print("=" * 60)

    pid = None
    session = None

    if args.spawn:
        # Spawn mode: Frida launches VRChat and injects before any code runs
        # Kill existing VRChat first
        subprocess.run(["taskkill", "/F", "/IM", "VRChat.exe"],
                        capture_output=True)
        time.sleep(2)

        VRCHAT_EXE = os.path.join(STEAM_DIR, "VRChat.exe")
        print(f"\n[*] Spawning VRChat via Frida (spawn mode)...")
        print(f"    Executable: {VRCHAT_EXE}")

        try:
            pid = frida.spawn([VRCHAT_EXE, "--no-vr"], cwd=STEAM_DIR)
            print(f"[OK] VRChat spawned (PID {pid}), suspended")
            session = frida.attach(pid)
            print("[OK] Frida attached (process still suspended)")
        except Exception as e:
            print(f"[!] Frida spawn failed: {e}")
            print("    Falling back to launch+attach mode...")
            args.spawn = False

    if not args.spawn and not args.attach_only and session is None:
        # Normal launch+attach mode
        subprocess.run(["taskkill", "/F", "/IM", "VRChat.exe"],
                        capture_output=True)
        time.sleep(2)

        print(f"\n[*] Launching VRChat via {LAUNCH_EXE}")
        subprocess.Popen([LAUNCH_EXE], cwd=STEAM_DIR)

        pid = wait_for_process("VRChat.exe", timeout=30)
        if pid is None:
            print("[!] VRChat did not start within 30 seconds")
            sys.exit(1)
        print(f"[OK] VRChat started (PID {pid})")

        # Wait just enough for GameAssembly.dll to load (~1.5s)
        # Must attach BEFORE "set connect error state" fires (~5s after launch)
        print("[*] Waiting 1.5s for GameAssembly.dll to load...")
        time.sleep(1.5)

    if not args.spawn and args.attach_only and session is None:
        pid = wait_for_process("VRChat.exe", timeout=5)
        if pid is None:
            print("[!] VRChat not found running")
            sys.exit(1)
        print(f"[OK] Found VRChat (PID {pid})")

    if session is None:
        print(f"\n[*] Attaching Frida to PID {pid}...")
        try:
            session = frida.attach(pid)
        except Exception as e:
            print(f"[!] Frida attach failed: {e}")
            sys.exit(1)

    print("[OK] Frida attached")

    # Create and load script
    def on_message(message, data):
        if message['type'] == 'send':
            print(f"[FRIDA] {message['payload']}")
        elif message['type'] == 'error':
            print(f"[FRIDA ERROR] {message.get('description', message)}")
        else:
            print(f"[FRIDA] {message}")

    script = session.create_script(script_code)
    script.on('message', on_message)
    script.load()
    print("[OK] Timing fix script loaded")

    # If spawn mode, resume the process now (hooks are in place)
    if args.spawn:
        print("[*] Resuming VRChat process (hooks installed before any code ran)...")
        frida.resume(pid)
        print("[OK] VRChat resumed\n")
    else:
        print()

    # Start log tailing
    stop_event = threading.Event()
    time.sleep(1)
    latest_log = find_latest_log()
    if latest_log:
        print(f"[*] Tailing log: {os.path.basename(latest_log)}")
        log_thread = threading.Thread(target=tail_log, args=(latest_log, stop_event))
        log_thread.daemon = True
        log_thread.start()
    else:
        print("[!] No log file found")

    # Monitor
    print(f"\n[*] Monitoring for {args.timeout}s... (Ctrl+C to stop)")
    print("=" * 60)

    try:
        start = time.time()
        while time.time() - start < args.timeout:
            time.sleep(1)
            # Check if VRChat is still running
            result = subprocess.run(
                ["tasklist", "/FI", "IMAGENAME eq VRChat.exe", "/FO", "CSV", "/NH"],
                capture_output=True, text=True
            )
            if "vrchat" not in result.stdout.lower():
                print("\n[!] VRChat process exited")
                break
    except KeyboardInterrupt:
        print("\n[*] Interrupted by user")

    stop_event.set()
    print("\n[*] Cleaning up...")
    try:
        script.unload()
        session.detach()
    except:
        pass

    # Print final log analysis
    print("\n" + "=" * 60)
    print("  Final Log Analysis")
    print("=" * 60)
    latest_log = find_latest_log()
    if latest_log:
        with open(latest_log, 'r', encoding='utf-8', errors='replace') as f:
            lines = f.readlines()

        keywords_found = {}
        for line in lines:
            line = line.strip()
            for kw in ["OnConnectedToMaster", "Successfully joined room",
                        "Failed to join", "Going to Error World",
                        "Entering Room", "Destination requested",
                        "Destination set", "EnterWorld"]:
                if kw in line:
                    if kw not in keywords_found:
                        keywords_found[kw] = []
                    keywords_found[kw].append(line[:80])

        for kw, lines in keywords_found.items():
            print(f"\n  {kw} ({len(lines)} occurrences):")
            for l in lines[:3]:
                print(f"    {l}")

    print("\n" + "=" * 60)


if __name__ == '__main__':
    main()
