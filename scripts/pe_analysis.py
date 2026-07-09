"""PE structure analysis of VRChat GameAssembly.dll"""
import pefile
import os
import time
from datetime import datetime

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"

print(f"=== PE Analysis: GameAssembly.dll ===")
print(f"File size: {os.path.getsize(DLL_PATH):,} bytes ({os.path.getsize(DLL_PATH) / (1024*1024):.2f} MB)")
print()

pe = pefile.PE(DLL_PATH, fast_load=False)

# 1. PE Headers
print("=" * 70)
print("1. PE HEADERS")
print("=" * 70)
machine_types = {0x14c: "i386 (x86)", 0x8664: "AMD64 (x64)", 0x1c0: "ARM", 0xaa64: "ARM64"}
machine = pe.FILE_HEADER.Machine
print(f"  Machine type:      0x{machine:04X} ({machine_types.get(machine, 'Unknown')})")
ts = pe.FILE_HEADER.TimeDateStamp
print(f"  TimeDateStamp:     0x{ts:08X} ({datetime.utcfromtimestamp(ts).strftime('%Y-%m-%d %H:%M:%S UTC')})")
print(f"  Number of sections: {pe.FILE_HEADER.NumberOfSections}")
print(f"  Characteristics:   0x{pe.FILE_HEADER.Characteristics:04X}")
chars = []
if pe.FILE_HEADER.Characteristics & 0x0002: chars.append("EXECUTABLE_IMAGE")
if pe.FILE_HEADER.Characteristics & 0x0020: chars.append("LARGE_ADDRESS_AWARE")
if pe.FILE_HEADER.Characteristics & 0x0100: chars.append("32BIT_MACHINE")
if pe.FILE_HEADER.Characteristics & 0x2000: chars.append("DLL")
print(f"                     [{', '.join(chars)}]")
print(f"  Optional Header Magic: 0x{pe.OPTIONAL_HEADER.Magic:04X} ({'PE32+' if pe.OPTIONAL_HEADER.Magic == 0x20b else 'PE32'})")
print(f"  ImageBase:         0x{pe.OPTIONAL_HEADER.ImageBase:016X}")
print(f"  EntryPoint RVA:    0x{pe.OPTIONAL_HEADER.AddressOfEntryPoint:08X}")
print(f"  SizeOfImage:       0x{pe.OPTIONAL_HEADER.SizeOfImage:08X} ({pe.OPTIONAL_HEADER.SizeOfImage:,} bytes)")
print(f"  SectionAlignment:  0x{pe.OPTIONAL_HEADER.SectionAlignment:X}")
print(f"  FileAlignment:     0x{pe.OPTIONAL_HEADER.FileAlignment:X}")
print(f"  DllCharacteristics: 0x{pe.OPTIONAL_HEADER.DllCharacteristics:04X}")
dll_chars = []
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x0020: dll_chars.append("HIGH_ENTROPY_VA")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x0040: dll_chars.append("DYNAMIC_BASE (ASLR)")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x0100: dll_chars.append("NX_COMPAT (DEP)")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x0400: dll_chars.append("NO_SEH")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x0800: dll_chars.append("NO_BIND")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x2000: dll_chars.append("WDM_DRIVER")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x4000: dll_chars.append("GUARD_CF")
if pe.OPTIONAL_HEADER.DllCharacteristics & 0x8000: dll_chars.append("TERMINAL_SERVER_AWARE")
print(f"                     [{', '.join(dll_chars)}]")
print()

# 2. Sections
print("=" * 70)
print("2. SECTIONS")
print("=" * 70)
print(f"  {'Name':<10} {'VirtAddr':<12} {'VirtSize':<12} {'RawSize':<12} {'RawOffset':<12} {'Flags'}")
print(f"  {'-'*10} {'-'*12} {'-'*12} {'-'*12} {'-'*12} {'-'*30}")
for section in pe.sections:
    name = section.Name.decode('utf-8', errors='replace').rstrip('\x00')
    va = section.VirtualAddress
    vs = section.Misc_VirtualSize
    rs = section.SizeOfRawData
    ro = section.PointerToRawData
    ch = section.Characteristics
    flags = []
    if ch & 0x00000020: flags.append("CODE")
    if ch & 0x00000040: flags.append("INIT_DATA")
    if ch & 0x00000080: flags.append("UNINIT_DATA")
    if ch & 0x20000000: flags.append("EXEC")
    if ch & 0x40000000: flags.append("READ")
    if ch & 0x80000000: flags.append("WRITE")
    flag_str = "|".join(flags)
    print(f"  {name:<10} 0x{va:08X}  0x{vs:08X}  0x{rs:08X}  0x{ro:08X}  0x{ch:08X} [{flag_str}]")
print()

# 3. Exports
print("=" * 70)
print("3. EXPORTS")
print("=" * 70)
if hasattr(pe, 'DIRECTORY_ENTRY_EXPORT'):
    exports = pe.DIRECTORY_ENTRY_EXPORT.symbols
    print(f"  Total exports: {len(exports)}")
    print(f"  DLL Name: {pe.DIRECTORY_ENTRY_EXPORT.name.decode() if pe.DIRECTORY_ENTRY_EXPORT.name else 'N/A'}")
    print(f"  First 50 export names:")
    count = 0
    for exp in exports:
        if count >= 50:
            break
        name = exp.name.decode() if exp.name else f"(ordinal {exp.ordinal})"
        print(f"    [{exp.ordinal:5d}] 0x{exp.address:08X} {name}")
        count += 1
    if len(exports) > 50:
        print(f"    ... and {len(exports) - 50} more exports")
else:
    print("  No export directory found.")
print()

# 4. Imports
print("=" * 70)
print("4. IMPORTS")
print("=" * 70)
if hasattr(pe, 'DIRECTORY_ENTRY_IMPORT'):
    total_imports = 0
    print(f"  {'DLL Name':<40} {'Functions Imported'}")
    print(f"  {'-'*40} {'-'*20}")
    for entry in pe.DIRECTORY_ENTRY_IMPORT:
        dll_name = entry.dll.decode() if entry.dll else "Unknown"
        func_count = len(entry.imports)
        total_imports += func_count
        print(f"  {dll_name:<40} {func_count}")
    print(f"\n  Total imported DLLs: {len(pe.DIRECTORY_ENTRY_IMPORT)}")
    print(f"  Total imported functions: {total_imports}")
else:
    print("  No import directory found.")
print()

# 5. Overlay check
print("=" * 70)
print("5. OVERLAY DATA CHECK")
print("=" * 70)
file_size = os.path.getsize(DLL_PATH)
last_section = pe.sections[-1]
last_section_end = last_section.PointerToRawData + last_section.SizeOfRawData
overlay_size = file_size - last_section_end
if overlay_size > 0:
    print(f"  OVERLAY DETECTED!")
    print(f"  Last section ends at: 0x{last_section_end:X} ({last_section_end:,} bytes)")
    print(f"  File size:            0x{file_size:X} ({file_size:,} bytes)")
    print(f"  Overlay size:         0x{overlay_size:X} ({overlay_size:,} bytes, {overlay_size/(1024*1024):.2f} MB)")
else:
    print(f"  No overlay data. Last section ends at file boundary.")
    print(f"  Last section end: 0x{last_section_end:X}, File size: 0x{file_size:X}")
print()

# 6. Anomalies
print("=" * 70)
print("6. ANOMALY CHECK")
print("=" * 70)
anomalies = []

# Check for writable+executable sections
for section in pe.sections:
    name = section.Name.decode('utf-8', errors='replace').rstrip('\x00')
    ch = section.Characteristics
    if (ch & 0x20000000) and (ch & 0x80000000):  # EXEC + WRITE
        anomalies.append(f"  [!] Section '{name}' is WRITABLE + EXECUTABLE (RWX) - potential self-modifying code")
    if section.SizeOfRawData == 0 and section.Misc_VirtualSize > 0:
        anomalies.append(f"  [i] Section '{name}' has zero raw size but non-zero virtual size (BSS-like)")
    if section.Misc_VirtualSize > section.SizeOfRawData * 10 and section.SizeOfRawData > 0:
        anomalies.append(f"  [i] Section '{name}' virtual size >> raw size (ratio: {section.Misc_VirtualSize/section.SizeOfRawData:.1f}x)")

# Check for unusual section names
standard_names = {'.text', '.rdata', '.data', '.pdata', '.rsrc', '.reloc', '.bss', '.idata', '.edata', '.tls', '.gfids', '.00cfg'}
for section in pe.sections:
    name = section.Name.decode('utf-8', errors='replace').rstrip('\x00')
    if name not in standard_names and not name.startswith('.'):
        anomalies.append(f"  [i] Non-standard section name: '{name}'")

# Check timestamp sanity
if ts == 0:
    anomalies.append("  [i] TimeDateStamp is zero (stripped/reproducible build)")
elif ts > time.time():
    anomalies.append("  [!] TimeDateStamp is in the future")
elif ts < 946684800:  # Before 2000
    anomalies.append("  [i] TimeDateStamp is before year 2000 - possibly fake or deterministic")

# Check for TLS callbacks
if hasattr(pe, 'DIRECTORY_ENTRY_TLS'):
    anomalies.append("  [i] TLS directory present (may contain TLS callbacks)")

# Check for debug directory
if hasattr(pe, 'DIRECTORY_ENTRY_DEBUG'):
    anomalies.append(f"  [i] Debug directory present ({len(pe.DIRECTORY_ENTRY_DEBUG)} entries)")
    for dbg in pe.DIRECTORY_ENTRY_DEBUG:
        if hasattr(dbg, 'entry') and hasattr(dbg.entry, 'PdbFileName'):
            pdb = dbg.entry.PdbFileName.decode('utf-8', errors='replace').rstrip('\x00')
            anomalies.append(f"       PDB: {pdb}")

# Large export count for a game DLL
if hasattr(pe, 'DIRECTORY_ENTRY_EXPORT') and len(pe.DIRECTORY_ENTRY_EXPORT.symbols) > 1000:
    anomalies.append(f"  [i] Very large export table ({len(pe.DIRECTORY_ENTRY_EXPORT.symbols)} exports) - typical for IL2CPP")

if anomalies:
    for a in anomalies:
        print(a)
else:
    print("  No anomalies detected.")
print()
print("=== Analysis Complete ===")
