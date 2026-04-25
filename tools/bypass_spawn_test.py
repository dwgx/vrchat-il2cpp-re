#!/usr/bin/env python3
"""Test whether CREATE_SUSPENDED + immediate resume alone bypasses
VRChat's self-kill — no Frida, no injection.

Hypothesis: VRChat's anti-debug or parent check sees something during
creation that breaks in "normal spawn" but not "suspended then resumed".
"""
import ctypes
import ctypes.wintypes as wt
import sys
import time

sys.stdout.reconfigure(encoding='utf-8')

VRCHAT_EXE = r'D:\WorkSpace\VRChat\VRChat.exe'
VRCHAT_CWD = r'D:\WorkSpace\VRChat'
CMDLINE = f'"{VRCHAT_EXE}" --no-vr'

CREATE_SUSPENDED = 0x00000004
CREATE_NEW_CONSOLE = 0x00000010
CREATE_UNICODE_ENVIRONMENT = 0x00000400


class STARTUPINFOW(ctypes.Structure):
    _fields_ = [
        ('cb', wt.DWORD),
        ('lpReserved', wt.LPWSTR),
        ('lpDesktop', wt.LPWSTR),
        ('lpTitle', wt.LPWSTR),
        ('dwX', wt.DWORD),
        ('dwY', wt.DWORD),
        ('dwXSize', wt.DWORD),
        ('dwYSize', wt.DWORD),
        ('dwXCountChars', wt.DWORD),
        ('dwYCountChars', wt.DWORD),
        ('dwFillAttribute', wt.DWORD),
        ('dwFlags', wt.DWORD),
        ('wShowWindow', wt.WORD),
        ('cbReserved2', wt.WORD),
        ('lpReserved2', ctypes.c_void_p),
        ('hStdInput', wt.HANDLE),
        ('hStdOutput', wt.HANDLE),
        ('hStdError', wt.HANDLE),
    ]


class PROCESS_INFORMATION(ctypes.Structure):
    _fields_ = [
        ('hProcess', wt.HANDLE),
        ('hThread', wt.HANDLE),
        ('dwProcessId', wt.DWORD),
        ('dwThreadId', wt.DWORD),
    ]


def main():
    k32 = ctypes.windll.kernel32
    si = STARTUPINFOW()
    si.cb = ctypes.sizeof(si)
    pi = PROCESS_INFORMATION()

    cmd_buf = ctypes.create_unicode_buffer(CMDLINE)
    ok = k32.CreateProcessW(
        None,
        cmd_buf,
        None, None, False,
        CREATE_SUSPENDED,
        None,
        VRCHAT_CWD,
        ctypes.byref(si), ctypes.byref(pi)
    )
    if not ok:
        print(f'[!] CreateProcessW failed: err={ctypes.GetLastError()}')
        return 1

    print(f'[ok] spawned suspended pid={pi.dwProcessId}')
    time.sleep(0.5)

    # Resume main thread
    r = k32.ResumeThread(pi.hThread)
    print(f'[ok] ResumeThread returned prev_count={r}')

    # Watch for 30s: did it stay alive + reach Unity init?
    import psutil
    try:
        proc = psutil.Process(pi.dwProcessId)
    except psutil.NoSuchProcess:
        print('[!] process died immediately after resume')
        return 2

    start = time.time()
    last_mem = 0
    while time.time() - start < 60:
        time.sleep(2)
        try:
            mem = proc.memory_info().rss
        except psutil.NoSuchProcess:
            print(f'[!] process DIED at t={time.time()-start:.1f}s (last mem={last_mem/1e9:.2f}GB)')
            return 3
        delta = mem - last_mem
        if abs(delta) > 20_000_000:
            print(f'  t={time.time()-start:5.1f}s  mem={mem/1e9:5.2f}GB  ({"+" if delta>0 else ""}{delta/1e6:.0f}MB)')
        last_mem = mem
        if mem > 1_500_000_000:
            print(f'[ok] Unity loaded! t={time.time()-start:.1f}s  mem={mem/1e9:.2f}GB')
            return 0

    print(f'[!] still alive but not loading — final mem={last_mem/1e9:.2f}GB at t=60s')
    return 4


if __name__ == '__main__':
    sys.exit(main())
