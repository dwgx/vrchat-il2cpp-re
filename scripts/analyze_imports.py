"""Analyze imports of GameAssembly.dll using pefile."""
import pefile
import json
from collections import defaultdict

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"

# Categories of interest
CRYPTO_PREFIXES = ('BCrypt', 'Crypt', 'NCrypt', 'Ssl', 'Tls')
NETWORK_PREFIXES = ('WSA', 'connect', 'send', 'recv', 'bind', 'listen',
                    'accept', 'select', 'shutdown', 'closesocket',
                    'getaddrinfo', 'gethostby', 'inet_', 'hton', 'ntoh')
ANTIDEBUG_NAMES = {
    'IsDebuggerPresent', 'CheckRemoteDebuggerPresent',
    'NtQueryInformationProcess', 'NtQuerySystemInformation',
    'OutputDebugStringA', 'OutputDebugStringW',
    'QueryPerformanceCounter', 'GetTickCount', 'GetTickCount64',
    'NtSetInformationThread', 'NtClose',
    'CloseHandle',  # with invalid handle = anti-debug trick
}
FILE_IO_NAMES = {
    'CreateFileA', 'CreateFileW', 'CreateFile2',
    'ReadFile', 'ReadFileEx', 'WriteFile',
    'MapViewOfFile', 'MapViewOfFileEx', 'CreateFileMappingA',
    'CreateFileMappingW', 'UnmapViewOfFile',
    'GetFileSize', 'GetFileSizeEx', 'SetFilePointer', 'SetFilePointerEx',
    'FindFirstFileW', 'FindNextFileW', 'GetFileAttributesW',
    'NtCreateFile', 'NtReadFile', 'NtWriteFile', 'NtCreateSection',
    'NtMapViewOfSection',
}
INTERESTING_DLLS = {
    'kernel32.dll', 'kernelbase.dll', 'ntdll.dll',
    'ws2_32.dll', 'wsock32.dll', 'wininet.dll', 'winhttp.dll',
    'bcrypt.dll', 'ncrypt.dll', 'crypt32.dll', 'advapi32.dll',
    'user32.dll', 'secur32.dll', 'sspicli.dll',
}

print(f"Loading: {DLL_PATH}")
pe = pefile.PE(DLL_PATH, fast_load=False)
pe.parse_data_directories(
    directories=[pefile.DIRECTORY_ENTRY['IMAGE_DIRECTORY_ENTRY_IMPORT']]
)

if not hasattr(pe, 'DIRECTORY_ENTRY_IMPORT'):
    print("ERROR: No import directory found!")
    exit(1)

# Collect all imports
all_imports = {}  # dll_name -> list of function names
for entry in pe.DIRECTORY_ENTRY_IMPORT:
    dll_name = entry.dll.decode('utf-8', errors='replace').lower()
    funcs = []
    for imp in entry.imports:
        if imp.name:
            funcs.append(imp.name.decode('utf-8', errors='replace'))
        else:
            funcs.append(f"ordinal_{imp.ordinal}")
    all_imports[dll_name] = funcs

# === SECTION 1: Summary of all imported DLLs ===
print("\n" + "=" * 70)
print("SECTION 1: ALL IMPORTED DLLs (sorted by import count)")
print("=" * 70)
sorted_dlls = sorted(all_imports.items(), key=lambda x: -len(x[1]))
total_funcs = sum(len(v) for v in all_imports.values())
print(f"\nTotal DLLs: {len(all_imports)}")
print(f"Total imported functions: {total_funcs}\n")
print(f"{'DLL Name':<40} {'Count':>6}")
print("-" * 48)
for dll_name, funcs in sorted_dlls:
    marker = " ***" if dll_name in INTERESTING_DLLS else ""
    print(f"{dll_name:<40} {len(funcs):>6}{marker}")

# === SECTION 2: Interesting DLL details ===
print("\n" + "=" * 70)
print("SECTION 2: INTERESTING DLL IMPORTS (full function lists)")
print("=" * 70)
for dll_name in sorted(INTERESTING_DLLS):
    if dll_name in all_imports:
        funcs = sorted(all_imports[dll_name])
        print(f"\n--- {dll_name} ({len(funcs)} functions) ---")
        for f in funcs:
            print(f"  {f}")

# === SECTION 3: Crypto imports ===
print("\n" + "=" * 70)
print("SECTION 3: CRYPTO-RELATED IMPORTS")
print("=" * 70)
crypto_found = defaultdict(list)
for dll_name, funcs in all_imports.items():
    for f in funcs:
        if any(f.startswith(p) for p in CRYPTO_PREFIXES):
            crypto_found[dll_name].append(f)
if crypto_found:
    for dll_name, funcs in sorted(crypto_found.items()):
        print(f"\n  [{dll_name}]")
        for f in sorted(funcs):
            print(f"    {f}")
else:
    print("\n  (none found)")

# === SECTION 4: Network imports ===
print("\n" + "=" * 70)
print("SECTION 4: NETWORK-RELATED IMPORTS")
print("=" * 70)
network_found = defaultdict(list)
for dll_name, funcs in all_imports.items():
    for f in funcs:
        f_lower = f.lower()
        if any(f_lower.startswith(p.lower()) for p in NETWORK_PREFIXES):
            network_found[dll_name].append(f)
if network_found:
    for dll_name, funcs in sorted(network_found.items()):
        print(f"\n  [{dll_name}]")
        for f in sorted(funcs):
            print(f"    {f}")
else:
    print("\n  (none found)")

# === SECTION 5: Anti-debug imports ===
print("\n" + "=" * 70)
print("SECTION 5: ANTI-DEBUG IMPORTS")
print("=" * 70)
antidebug_found = defaultdict(list)
for dll_name, funcs in all_imports.items():
    for f in funcs:
        if f in ANTIDEBUG_NAMES:
            antidebug_found[dll_name].append(f)
if antidebug_found:
    for dll_name, funcs in sorted(antidebug_found.items()):
        print(f"\n  [{dll_name}]")
        for f in sorted(funcs):
            print(f"    {f}")
else:
    print("\n  (none found)")

# === SECTION 6: File I/O imports ===
print("\n" + "=" * 70)
print("SECTION 6: FILE I/O IMPORTS (metadata loading candidates)")
print("=" * 70)
fileio_found = defaultdict(list)
for dll_name, funcs in all_imports.items():
    for f in funcs:
        if f in FILE_IO_NAMES:
            fileio_found[dll_name].append(f)
if fileio_found:
    for dll_name, funcs in sorted(fileio_found.items()):
        print(f"\n  [{dll_name}]")
        for f in sorted(funcs):
            print(f"    {f}")
else:
    print("\n  (none found)")

# === SECTION 7: Notable patterns ===
print("\n" + "=" * 70)
print("SECTION 7: NOTABLE PATTERNS & OBSERVATIONS")
print("=" * 70)

# Check for VirtualAlloc/Protect (code gen / JIT / unpacking)
jit_funcs = []
for dll_name, funcs in all_imports.items():
    for f in funcs:
        if f in ('VirtualAlloc', 'VirtualAllocEx', 'VirtualProtect',
                 'VirtualProtectEx', 'VirtualFree', 'FlushInstructionCache',
                 'NtAllocateVirtualMemory', 'NtProtectVirtualMemory'):
            jit_funcs.append((dll_name, f))
if jit_funcs:
    print("\n  [Memory manipulation (JIT/unpacking)]")
    for dll, f in sorted(jit_funcs):
        print(f"    {dll}: {f}")

# Check for thread/process manipulation
thread_funcs = []
for dll_name, funcs in all_imports.items():
    for f in funcs:
        if f in ('CreateThread', 'CreateRemoteThread', 'ResumeThread',
                 'SuspendThread', 'TerminateThread', 'GetThreadContext',
                 'SetThreadContext', 'NtCreateThreadEx',
                 'CreateProcessW', 'CreateProcessA',
                 'GetCurrentProcess', 'GetCurrentThread',
                 'OpenProcess', 'OpenThread'):
            thread_funcs.append((dll_name, f))
if thread_funcs:
    print("\n  [Thread/Process manipulation]")
    for dll, f in sorted(thread_funcs):
        print(f"    {dll}: {f}")

# Check for exception handling
exception_funcs = []
for dll_name, funcs in all_imports.items():
    for f in funcs:
        if 'Exception' in f or 'Unhandled' in f or f in (
            'RaiseException', 'SetUnhandledExceptionFilter',
            'AddVectoredExceptionHandler', 'RemoveVectoredExceptionHandler',
            'RtlAddFunctionTable', 'RtlDeleteFunctionTable',
            'RtlLookupFunctionEntry', 'RtlVirtualUnwind'):
            exception_funcs.append((dll_name, f))
if exception_funcs:
    print("\n  [Exception handling (IL2CPP runtime)]")
    for dll, f in sorted(exception_funcs):
        print(f"    {dll}: {f}")

pe.close()
print("\n\nDone.")
