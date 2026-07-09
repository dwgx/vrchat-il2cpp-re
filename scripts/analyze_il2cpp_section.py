"""
Analyze the il2cpp section entry and the obfuscated export names.
"""
import sys, random
try:
    import pefile
except ImportError:
    pass
try:
    from capstone import *
except ImportError:
    pass

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
pe = pefile.PE(DLL_PATH, fast_load=False)

base = pe.OPTIONAL_HEADER.ImageBase
md = Cs(CS_ARCH_X86, CS_MODE_64)
md.detail = True

# Disassemble the start of the il2cpp section
print("=== IL2CPP SECTION START (first 200 bytes) ===")
il2cpp_sec = None
for s in pe.sections:
    if b'il2cpp' in s.Name:
        il2cpp_sec = s
        break

data = il2cpp_sec.get_data()[:200]
va = base + il2cpp_sec.VirtualAddress
for insn in md.disasm(data, va):
    print(f"  0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")

# Check how many obfuscated exports point to the same RVA (aliased)
print("\n=== ALIASED EXPORTS (same RVA) ===")
from collections import Counter
rva_counter = Counter()
rva_to_names = {}
for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
    if exp.name:
        name = exp.name.decode('utf-8', errors='replace')
        rva_counter[exp.address] += 1
        rva_to_names.setdefault(exp.address, []).append(name)

aliases = {rva: names for rva, names in rva_to_names.items() if len(names) > 1}
print(f"  RVAs with multiple export names: {len(aliases)}")
for rva, names in sorted(aliases.items(), key=lambda x: -len(x[1]))[:10]:
    print(f"    RVA=0x{rva:08X} ({len(names)} names): {', '.join(names[:5])}...")

# Count exports that look like random strings (obfuscated) vs. readable
readable = []
obfuscated = []
for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
    if exp.name:
        name = exp.name.decode('utf-8', errors='replace')
        # Heuristic: readable exports have underscores/camelCase with meaning
        if name.startswith('il2cpp') or name in ('Flush','ReadEvents','ReadZStream','WriteZStream',
            'CreateZStream','CloseZStream','CreateNLSocket','CloseNLSocket',
            'DllCanUnloadNow','DllGetActivationFactory'):
            readable.append(name)
        else:
            obfuscated.append(name)

print(f"\n=== EXPORT NAME CLASSIFICATION ===")
print(f"  Readable/known: {len(readable)}")
for n in sorted(readable):
    print(f"    {n}")
print(f"  Obfuscated (random-looking): {len(obfuscated)}")

# Disassemble a few of the obfuscated exports to see what they do
print("\n=== SAMPLE OBFUSCATED EXPORT DISASSEMBLY ===")
random.seed(99)
samples = random.sample(obfuscated, min(5, len(obfuscated)))
for name in samples:
    rva = find_export_rva(pe, name)
    if rva:
        data = pe.get_data(rva, 80)
        va = base + rva
        print(f"\n  {name} (VA=0x{va:016X}):")
        for insn in md.disasm(data, va):
            print(f"    0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")

def find_export_rva(pe, name):
    for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
        if exp.name and exp.name.decode('utf-8', errors='replace') == name:
            return exp.address
    return None

# Actually call
print("\n=== SAMPLE OBFUSCATED EXPORT DISASSEMBLY (corrected) ===")
for name in samples:
    rva = find_export_rva(pe, name)
    if rva:
        try:
            data = pe.get_data(rva, 80)
            va = base + rva
            print(f"\n  {name} (VA=0x{va:016X}):")
            for insn in md.disasm(data, va):
                print(f"    0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")
        except Exception as e:
            print(f"  Error reading {name}: {e}")
