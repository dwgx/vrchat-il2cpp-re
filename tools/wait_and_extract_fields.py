#!/usr/bin/env python3
"""Wait for VRChat to finish loading, then run extract_field_types_v2.

Polls VRChat memory until it crosses threshold (~1.5GB = IL2CPP loaded),
then attaches Frida and extracts field types.
"""
import subprocess, sys, time, os
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
TOOLS = Path(__file__).resolve().parent
MEM_THRESHOLD = 1_800_000_000
POLL_INTERVAL = 10
MAX_WAIT = 600


def get_vrchat_memory():
    r = subprocess.run(
        ['powershell', '-NoProfile', '-Command',
         '$p=Get-Process VRChat -ErrorAction SilentlyContinue; if ($p) { $p.WorkingSet64 } else { 0 }'],
        capture_output=True, text=True, timeout=10
    )
    try:
        return int(r.stdout.strip() or '0')
    except ValueError:
        return 0


def main():
    print(f'[waiter] Polling VRChat memory (threshold={MEM_THRESHOLD/1e9:.1f}GB)', flush=True)
    start = time.time()
    stable_count = 0
    last_mem = 0
    while True:
        mem = get_vrchat_memory()
        elapsed = time.time() - start
        print(f'[waiter] t={elapsed:6.1f}s  mem={mem/1e9:5.2f}GB', flush=True)
        if mem == 0:
            print('[waiter] VRChat not running — abort', flush=True)
            sys.exit(2)
        if mem >= MEM_THRESHOLD:
            if abs(mem - last_mem) < 50_000_000:
                stable_count += 1
            else:
                stable_count = 0
            if stable_count >= 2:
                print(f'[waiter] stable load reached after {elapsed:.1f}s', flush=True)
                break
        last_mem = mem
        if elapsed > MAX_WAIT:
            print(f'[waiter] MAX_WAIT exceeded but continuing at {mem/1e9:.2f}GB', flush=True)
            break
        time.sleep(POLL_INTERVAL)

    print('[waiter] giving 15s cushion for JIT/metadata init', flush=True)
    time.sleep(15)

    script = TOOLS / 'extract_field_types_v2.py'
    print(f'[waiter] exec: {script}', flush=True)
    r = subprocess.run(['python', str(script)], cwd=str(BASE_DIR))
    print(f'[waiter] exit={r.returncode}', flush=True)
    sys.exit(r.returncode)


if __name__ == '__main__':
    main()
