"""
Quick follow-up: examine the il2cpp section and non-il2cpp exports.
"""
import sys
try:
    import pefile
except ImportError:
    import subprocess
    subprocess.check_call([sys.executable, "-m", "pip", "install", "pefile", "-q"])
    import pefile

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"

pe = pefile.PE(DLL_PATH, fast_load=False)

print("=== ALL EXPORTS (251 total) ===")
print()
exports_by_name = []
for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
    if exp.name:
        name = exp.name.decode('utf-8', errors='replace')
        exports_by_name.append((name, exp.address))

exports_by_name.sort()
for name, rva in exports_by_name:
    section = "?"
    for s in pe.sections:
        sname = s.Name.decode('utf-8', errors='replace').rstrip('\x00')
        if s.VirtualAddress <= rva < s.VirtualAddress + s.Misc_VirtualSize:
            section = sname
            break
    print(f"  {name:55s} RVA=0x{rva:08X}  [{section}]")

print(f"\n=== SECTION BREAKDOWN ===")
from collections import Counter
section_counts = Counter()
for name, rva in exports_by_name:
    for s in pe.sections:
        sname = s.Name.decode('utf-8', errors='replace').rstrip('\x00')
        if s.VirtualAddress <= rva < s.VirtualAddress + s.Misc_VirtualSize:
            section_counts[sname] += 1
            break

for sec, count in section_counts.most_common():
    print(f"  {sec}: {count} exports")

print(f"\n=== il2cpp SECTION INFO ===")
for s in pe.sections:
    sname = s.Name.decode('utf-8', errors='replace').rstrip('\x00')
    if sname == 'il2cpp':
        print(f"  VA:   0x{s.VirtualAddress:08X}")
        print(f"  Size: 0x{s.SizeOfRawData:08X} ({s.SizeOfRawData / (1024*1024):.1f} MB)")
        print(f"  Virtual Size: 0x{s.Misc_VirtualSize:08X} ({s.Misc_VirtualSize / (1024*1024):.1f} MB)")
        print(f"  Flags: 0x{s.Characteristics:08X}")
        flags = []
        if s.Characteristics & 0x20000000: flags.append("EXEC")
        if s.Characteristics & 0x40000000: flags.append("READ")
        if s.Characteristics & 0x80000000: flags.append("WRITE")
        if s.Characteristics & 0x00000020: flags.append("CODE")
        print(f"  Flags decoded: {', '.join(flags)}")
        data = s.get_data()[:64]
        print(f"  First 64 bytes (hex): {data.hex()}")
        break
