#!/usr/bin/env python3
"""Spawn VRChat via Frida (which keeps the process alive past early-exit check),
then detach to let it run normally. Poll memory. Once Unity IL2CPP is loaded
(GameAssembly.dll present, memory > 1.5GB), hand off to field_types extractor.
"""
import frida, sys, time, subprocess, os
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

VRCHAT_EXE = r'D:\WorkSpace\VRChat\VRChat.exe'
VRCHAT_CWD = r'D:\WorkSpace\VRChat'

BASE_DIR = Path(__file__).resolve().parent.parent
TOOLS = Path(__file__).resolve().parent


def get_mem(pid):
    r = subprocess.run(
        ['powershell', '-NoProfile', '-Command',
         f'$p=Get-Process -Id {pid} -ErrorAction SilentlyContinue; if ($p) {{ $p.WorkingSet64 }} else {{ 0 }}'],
        capture_output=True, text=True, timeout=10
    )
    try: return int((r.stdout or '0').strip() or '0')
    except: return 0


def main():
    print(f'[keep] spawn {VRCHAT_EXE} --no-vr', flush=True)
    pid = frida.spawn([VRCHAT_EXE, '--no-vr'], cwd=VRCHAT_CWD)
    print(f'[keep] pid={pid}', flush=True)

    # Attach and hold session to prevent early-exit behavior
    session = frida.attach(pid)
    # Tiny keepalive script — no hooks
    sc = session.create_script("send({ok:true});")
    sc.load()
    frida.resume(pid)
    print('[keep] resumed', flush=True)

    # Poll. DO NOT detach — keep session alive. Watch memory.
    start = time.time()
    last = 0
    stable = 0
    while True:
        time.sleep(5)
        mem = get_mem(pid)
        el = time.time() - start
        if mem == 0:
            print(f'[keep] DIED at t={el:.1f}s', flush=True)
            return 2
        print(f'  t={el:5.1f}s  mem={mem/1e9:5.2f}GB', flush=True)
        if mem > 1_500_000_000:
            if abs(mem - last) < 100_000_000:
                stable += 1
            else:
                stable = 0
            if stable >= 2:
                print(f'[keep] stable load at t={el:.1f}s mem={mem/1e9:.2f}GB', flush=True)
                break
        last = mem
        if el > 240:
            print(f'[keep] TIMEOUT t={el:.0f}s mem={mem/1e9:.2f}GB  (bailing anyway)', flush=True)
            break

    # Run extract_field_types_v2.py — it will do its own frida.attach, which works
    # since we're not holding exclusive access.
    extract = TOOLS / 'extract_field_types_v2.py'
    print(f'[keep] running {extract}', flush=True)
    r = subprocess.run([sys.executable, str(extract)], cwd=str(BASE_DIR))
    print(f'[keep] extract exit={r.returncode}', flush=True)

    try: session.detach()
    except: pass
    return r.returncode


if __name__ == '__main__':
    sys.exit(main())
