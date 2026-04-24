#!/usr/bin/env python3
"""Signal all Event handles in a target process from outside.

Background: MelonLoader's VERSION.dll bootstrap deadlocks waiting on an
unnamed Event that its own signaler thread never reaches. Fixing it
in-process via Frida Wait hooks fails because the wait enters kernel
before hooks install. Solution: from another process, enumerate all
handles owned by VRChat, duplicate each to ourselves, and SetEvent on
the Event-typed ones. Signaling unblocks the wait and bootstrap
completes.

Usage: python unblock_ml.py <pid> [--iterations N] [--interval SEC]
"""
import ctypes, ctypes.wintypes as wt, sys, time, os

sys.stdout.reconfigure(encoding='utf-8')

k32 = ctypes.windll.kernel32
ntdll = ctypes.windll.ntdll

PROCESS_DUP_HANDLE = 0x0040
DUPLICATE_SAME_ACCESS = 0x00000002

# NtQuerySystemInformation
ntdll.NtQuerySystemInformation.restype = ctypes.c_ulong
ntdll.NtQuerySystemInformation.argtypes = [ctypes.c_int, ctypes.c_void_p, ctypes.c_ulong, ctypes.POINTER(ctypes.c_ulong)]

# NtDuplicateObject
ntdll.NtDuplicateObject.restype = ctypes.c_ulong
ntdll.NtDuplicateObject.argtypes = [
    wt.HANDLE, wt.HANDLE, wt.HANDLE, ctypes.POINTER(wt.HANDLE),
    wt.DWORD, wt.ULONG, wt.ULONG
]

# NtQueryObject (for type name)
ntdll.NtQueryObject.restype = ctypes.c_ulong
ntdll.NtQueryObject.argtypes = [wt.HANDLE, ctypes.c_int, ctypes.c_void_p, ctypes.c_ulong, ctypes.POINTER(ctypes.c_ulong)]

# SetEvent
k32.SetEvent.restype = wt.BOOL
k32.SetEvent.argtypes = [wt.HANDLE]

SystemExtendedHandleInformation = 0x40
ObjectTypeInformation = 2


class SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX(ctypes.Structure):
    _fields_ = [
        ('Object', ctypes.c_void_p),
        ('UniqueProcessId', ctypes.c_size_t),
        ('HandleValue', ctypes.c_size_t),
        ('GrantedAccess', ctypes.c_ulong),
        ('CreatorBackTraceIndex', ctypes.c_ushort),
        ('ObjectTypeIndex', ctypes.c_ushort),
        ('HandleAttributes', ctypes.c_ulong),
        ('Reserved', ctypes.c_ulong),
    ]


def query_all_handles():
    """Return list of (pid, handle_value, type_index, access)."""
    buf_size = 0x400000  # 4MB starting
    while True:
        buf = ctypes.create_string_buffer(buf_size)
        ret_len = ctypes.c_ulong(0)
        status = ntdll.NtQuerySystemInformation(
            SystemExtendedHandleInformation,
            ctypes.cast(buf, ctypes.c_void_p),
            buf_size, ctypes.byref(ret_len)
        )
        if status == 0:
            break
        # STATUS_INFO_LENGTH_MISMATCH = 0xC0000004
        if status == 0xC0000004:
            buf_size *= 2
            if buf_size > 64 * 1024 * 1024:
                raise RuntimeError('buffer too large')
            continue
        raise OSError(f'NtQuerySystemInformation status=0x{status:x}')

    # First QWORD = count, then padding, then array
    count = ctypes.cast(buf, ctypes.POINTER(ctypes.c_size_t))[0]
    entry_off = ctypes.sizeof(ctypes.c_size_t) * 2  # count + reserved
    entry_size = ctypes.sizeof(SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX)
    entries = []
    raw = buf.raw
    for i in range(count):
        off = entry_off + i * entry_size
        e = SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX.from_buffer_copy(raw[off:off + entry_size])
        entries.append(e)
    return entries


def get_type_name(h):
    buf = ctypes.create_string_buffer(0x400)
    ret_len = ctypes.c_ulong(0)
    st = ntdll.NtQueryObject(h, ObjectTypeInformation, buf, 0x400, ctypes.byref(ret_len))
    if st != 0:
        return None
    # POBJECT_TYPE_INFORMATION starts with UNICODE_STRING TypeName {USHORT Length, USHORT MaxLen, PWSTR Buffer}
    length = int.from_bytes(buf.raw[0:2], 'little')
    # skip 8 bytes (Length, MaxLen, padding), then pointer
    name_ptr = int.from_bytes(buf.raw[8:16], 'little')
    if length == 0 or name_ptr == 0:
        return None
    try:
        return ctypes.wstring_at(name_ptr, length // 2)
    except:
        return None


def signal_pass(target_pid, target_proc_handle, self_handle):
    entries = query_all_handles()
    own_entries = [e for e in entries if e.UniqueProcessId == target_pid]

    events_signaled = 0
    tried = 0
    type_cache = {}  # type_index -> name

    for e in own_entries:
        tried += 1
        # Cheap pre-filter: dup only if we haven't identified this type_index or it's Event
        known = type_cache.get(e.ObjectTypeIndex)
        if known and known != 'Event':
            continue

        dup = wt.HANDLE()
        status = ntdll.NtDuplicateObject(
            target_proc_handle,
            wt.HANDLE(e.HandleValue),
            self_handle,
            ctypes.byref(dup),
            0, 0, DUPLICATE_SAME_ACCESS
        )
        if status != 0 or not dup.value:
            continue
        try:
            type_name = get_type_name(dup)
            if type_name:
                type_cache[e.ObjectTypeIndex] = type_name
                if type_name == 'Event':
                    k32.SetEvent(dup)
                    events_signaled += 1
        finally:
            k32.CloseHandle(dup)

    return tried, events_signaled, type_cache


def main():
    if len(sys.argv) < 2:
        print('usage: unblock_ml.py <pid> [--iterations N] [--interval SEC]')
        sys.exit(2)
    pid = int(sys.argv[1])
    iterations = 30
    interval = 1.0
    if '--iterations' in sys.argv:
        iterations = int(sys.argv[sys.argv.index('--iterations') + 1])
    if '--interval' in sys.argv:
        interval = float(sys.argv[sys.argv.index('--interval') + 1])

    target = k32.OpenProcess(PROCESS_DUP_HANDLE, False, pid)
    if not target:
        err = ctypes.GetLastError()
        print(f'OpenProcess failed: err={err}')
        sys.exit(3)

    self_h = k32.GetCurrentProcess()
    print(f'[unblock] target pid={pid} handle=0x{target:x}', flush=True)

    for i in range(iterations):
        try:
            tried, sig, types = signal_pass(pid, target, self_h)
            print(f'[unblock] pass {i+1}/{iterations}: handles={tried} events_signaled={sig}', flush=True)
        except Exception as ex:
            print(f'[unblock] pass {i+1} error: {ex}', flush=True)
        time.sleep(interval)

    k32.CloseHandle(target)


if __name__ == '__main__':
    main()
