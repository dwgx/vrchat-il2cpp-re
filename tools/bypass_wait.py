#!/usr/bin/env python3
"""Spawn VRChat via Frida (suspended) then use out-of-process SetEvent
on every Event handle in VRChat to unblock the MelonLoader bootstrap
deadlock. Once Unity reaches >1.5GB, run extract_field_types_v2.

The in-JS hook approach (Wait*, NtWait*, setInterval spray) did not
work because the stuck wait enters kernel before any hook can install.
External signal via NtDuplicateObject + SetEvent bypasses that race.
"""
import frida, sys, time, subprocess, os
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

VRCHAT_EXE = r'D:\WorkSpace\VRChat\VRChat.exe'
VRCHAT_CWD = r'D:\WorkSpace\VRChat'
BASE_DIR = Path(__file__).resolve().parent.parent
TOOLS = Path(__file__).resolve().parent

# Empty script — Frida just needs to hold the session to keep process
# alive past whatever early-exit VRChat/ML does when unattached.
KEEPALIVE_JS = "send({ok:true});"


def get_mem(pid):
    r = subprocess.run(
        ['powershell', '-NoProfile', '-Command',
         f'$p=Get-Process -Id {pid} -ErrorAction SilentlyContinue; if ($p) {{ $p.WorkingSet64 }} else {{ 0 }}'],
        capture_output=True, text=True, timeout=10
    )
    try: return int((r.stdout or '0').strip() or '0')
    except: return 0


def main():
    print(f'[bypass] spawning {VRCHAT_EXE} --no-vr', flush=True)
    pid = frida.spawn([VRCHAT_EXE, '--no-vr'], cwd=VRCHAT_CWD)
    session = frida.attach(pid)
    sc = session.create_script(KEEPALIVE_JS)
    sc.load()
    print(f'[bypass] attached pid={pid}, resuming', flush=True)
    frida.resume(pid)

    # Launch unblock_ml.py subprocess
    unblock = TOOLS / 'unblock_ml.py'
    print(f'[bypass] starting {unblock.name}', flush=True)
    unblock_proc = subprocess.Popen(
        [sys.executable, str(unblock), str(pid), '--iterations', '1', '--interval', '0.5'],
        stdout=subprocess.PIPE, stderr=subprocess.STDOUT, text=True, bufsize=1
    )

    # Poll memory; forward unblock output
    start = time.time()
    loaded = False

    try:
        while True:
            # Drain one line from unblock (non-blocking-ish via readline)
            time.sleep(2)
            mem = get_mem(pid)
            el = time.time() - start
            if mem == 0:
                print(f'[bypass] DIED at t={el:.1f}s', flush=True)
                break
            print(f'  t={el:5.1f}s  mem={mem/1e9:5.2f}GB', flush=True)
            if mem > 1_500_000_000:
                print(f'[bypass] UNITY LOADED at t={el:.1f}s', flush=True)
                loaded = True
                time.sleep(8)  # let init finish
                break
            if el > 150:
                print(f'[bypass] timeout at t={el:.0f}s mem={mem/1e9:.2f}GB', flush=True)
                break
    finally:
        # Stop unblocker
        try: unblock_proc.terminate()
        except: pass
        try:
            out, _ = unblock_proc.communicate(timeout=5)
            if out:
                print('--- unblock_ml output ---', flush=True)
                for line in out.strip().split('\n')[-20:]:
                    print('  ' + line, flush=True)
        except: pass

    if not loaded:
        try: frida.kill(pid)
        except: pass
        return 3

    # Run extract
    extract = TOOLS / 'extract_field_types_v2.py'
    print(f'[bypass] running {extract.name}', flush=True)
    rc = subprocess.run([sys.executable, str(extract)], cwd=str(BASE_DIR)).returncode
    print(f'[bypass] extract exit={rc}', flush=True)

    # Also fresh precise dump
    precise = TOOLS / 'extract_precise_dump.py'
    if precise.exists():
        print(f'[bypass] running {precise.name}', flush=True)
        rc2 = subprocess.run([sys.executable, str(precise)], cwd=str(BASE_DIR)).returncode
        print(f'[bypass] precise dump exit={rc2}', flush=True)

    try: session.detach()
    except: pass
    print('[bypass] done; VRChat left running', flush=True)
    return 0


if __name__ == '__main__':
    sys.exit(main())
