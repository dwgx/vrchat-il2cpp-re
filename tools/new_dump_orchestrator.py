#!/usr/bin/env python3
"""Wait for Steam-launched VRChat to fully load, dump memory, then
re-run the offline extraction pipeline.

Flow:
  1. Poll for VRChat.exe process; wait until memory >= 2GB (IL2CPP
     fully loaded).
  2. Run procdump64 -ma to produce a full minidump at a fresh path.
  3. Update extract_precise_dump.py's DUMP_PATH to the new file, or
     pass via env var / symlink, so the pipeline picks it up.
  4. Re-run extract_precise_dump, extract_field_types_from_dump, then
     merge_field_types, then generate_source_tree.
  5. Print coverage summary.

Assumes procdump64 at tools/procdump/procdump64.exe (downloaded).
Output minidump: tools/VRChat_<pid>_<timestamp>_full.dmp
"""
import os, sys, time, subprocess, json, re
from pathlib import Path
from datetime import datetime

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
TOOLS = Path(__file__).resolve().parent
PROCDUMP = TOOLS / 'procdump' / 'procdump64.exe'
MEM_THRESHOLD = 2_000_000_000
STABLE_WINDOW = 20  # seconds of stable >threshold memory before dumping


def get_vrchat():
    r = subprocess.run(
        ['powershell', '-NoProfile', '-Command',
         '$p=Get-Process VRChat -ErrorAction SilentlyContinue; if ($p) { "$($p.Id) $($p.WorkingSet64)" } else { "" }'],
        capture_output=True, text=True, timeout=10
    )
    line = (r.stdout or '').strip()
    if not line: return None, 0
    parts = line.split()
    return int(parts[0]), int(parts[1])


def wait_for_loaded(max_wait=1800):
    print(f'[orch] waiting for VRChat (memory >= {MEM_THRESHOLD/1e9:.1f}GB)', flush=True)
    start = time.time()
    stable_since = None
    last_pid = None
    while time.time() - start < max_wait:
        pid, mem = get_vrchat()
        el = time.time() - start
        if pid is None:
            print(f'  t={el:5.0f}s  not running', flush=True)
            stable_since = None
        else:
            if pid != last_pid:
                print(f'  -> VRChat PID={pid}', flush=True)
                last_pid = pid
            print(f'  t={el:5.0f}s  mem={mem/1e9:5.2f}GB', flush=True)
            if mem >= MEM_THRESHOLD:
                if stable_since is None:
                    stable_since = time.time()
                elif time.time() - stable_since >= STABLE_WINDOW:
                    return pid, mem
            else:
                stable_since = None
        time.sleep(10)
    return None, 0


def run_procdump(pid):
    ts = datetime.now().strftime('%Y%m%d_%H%M%S')
    out_file = TOOLS / f'VRChat_{pid}_{ts}_full.dmp'
    print(f'[orch] procdump -ma VRChat -> {out_file.name}', flush=True)
    # -r: reflection dump (clones process first, EAC sees access on clone)
    # -ma: full memory
    r = subprocess.run(
        [str(PROCDUMP), '-accepteula', '-r', '-ma', str(pid), str(out_file)],
        capture_output=True, text=True, timeout=600
    )
    print(r.stdout[-1500:] if r.stdout else '(no stdout)', flush=True)
    if r.returncode != 0:
        print(f'[orch] procdump stderr: {r.stderr[:500]}', flush=True)
    # procdump might append _<n>.dmp variants; find the actual file
    candidates = sorted(TOOLS.glob(f'VRChat_{pid}_{ts}*.dmp'), key=lambda p: p.stat().st_mtime, reverse=True)
    if not candidates:
        return None
    final = candidates[0]
    print(f'[orch] dump -> {final} ({final.stat().st_size/1e9:.2f}GB)', flush=True)
    return final


def run_extract(dump_path):
    # extract_precise_dump.py + extract_field_types_from_dump.py
    env = os.environ.copy()
    # extract_precise_dump reads DUMP_PATH constant; patch via env if supported,
    # otherwise point a symlink-equivalent copy. We'll edit precise temporarily.

    precise = TOOLS / 'extract_precise_dump.py'
    field = TOOLS / 'extract_field_types_from_dump.py'

    # extract_precise_dump has DUMP_PATH hardcoded; invoke with positional arg
    # (its argparse supports --dump).
    print(f'[orch] extract_precise_dump {dump_path.name}', flush=True)
    r1 = subprocess.run(
        [sys.executable, str(precise), str(dump_path)],
        cwd=str(BASE_DIR)
    )
    if r1.returncode != 0:
        print(f'[orch] precise failed ({r1.returncode})', flush=True)
        return False

    print(f'[orch] extract_field_types_from_dump --dump {dump_path.name}', flush=True)
    r2 = subprocess.run(
        [sys.executable, str(field), '--dump', str(dump_path)],
        cwd=str(BASE_DIR)
    )
    if r2.returncode != 0:
        print(f'[orch] field_types failed ({r2.returncode})', flush=True)
        return False

    return True


def run_merge_and_tree():
    print('[orch] run_full_pipeline --stage 3', flush=True)
    subprocess.run([sys.executable, str(TOOLS / 'run_full_pipeline.py'), '--stage', '3'],
                   cwd=str(BASE_DIR))
    print('[orch] merge_field_types', flush=True)
    subprocess.run([sys.executable, str(TOOLS / 'merge_field_types.py')],
                   cwd=str(BASE_DIR))
    print('[orch] generate_source_tree', flush=True)
    subprocess.run([sys.executable, str(TOOLS / 'generate_source_tree.py')],
                   cwd=str(BASE_DIR))


def coverage():
    with open(BASE_DIR / 'output' / 'deobfuscated_dump.json', encoding='utf-8') as f:
        d = json.load(f)
    typed = untyped = string_only = total = 0
    for ns, cs in d['namespaces'].items():
        for c in cs:
            for f in c.get('fields') or []:
                total += 1
                if isinstance(f, dict):
                    t = f.get('type', '')
                    if t and t != 'object':
                        typed += 1
                    else:
                        untyped += 1
                else:
                    string_only += 1
    print(f'[orch] total={total:,}  typed={typed:,} ({100*typed/total:.2f}%)  '
          f'untyped={untyped:,}  string_only={string_only:,}', flush=True)


def main():
    if not PROCDUMP.exists():
        print(f'[orch] missing {PROCDUMP}', flush=True)
        sys.exit(2)

    pid, mem = wait_for_loaded()
    if pid is None:
        print('[orch] VRChat did not load within deadline', flush=True)
        sys.exit(3)
    print(f'[orch] VRChat loaded: PID={pid} mem={mem/1e9:.2f}GB', flush=True)

    dump = run_procdump(pid)
    if dump is None or dump.stat().st_size < 500_000_000:
        print('[orch] procdump failed or dump too small (EAC blocked?)', flush=True)
        sys.exit(4)

    ok = run_extract(dump)
    if not ok:
        print('[orch] extract pipeline failed', flush=True)
        sys.exit(5)

    run_merge_and_tree()
    coverage()


if __name__ == '__main__':
    main()
