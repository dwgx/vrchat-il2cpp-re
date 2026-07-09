import sys, random
import pefile
from capstone import *

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
pe = pefile.PE(DLL_PATH, fast_load=False)
base = pe.OPTIONAL_HEADER.ImageBase
md = Cs(CS_ARCH_X86, CS_MODE_64)
md.detail = True

def find_export_rva(pe, name):
    for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
        if exp.name and exp.name.decode('utf-8', errors='replace') == name:
            return exp.address
    return None

# Sample some obfuscated exports
obfuscated = []
for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
    if exp.name:
        n = exp.name.decode('utf-8', errors='replace')
        if not n.startswith('il2cpp') and n not in ('Flush','ReadEvents','ReadZStream','WriteZStream',
            'CreateZStream','CloseZStream','CreateNLSocket','CloseNLSocket',
            'DllCanUnloadNow','DllGetActivationFactory'):
            obfuscated.append(n)

random.seed(99)
samples = random.sample(obfuscated, 8)

print("=== OBFUSCATED EXPORT DISASSEMBLY SAMPLES ===")
for name in samples:
    rva = find_export_rva(pe, name)
    if rva:
        try:
            data = pe.get_data(rva, 100)
            va = base + rva
            print(f"\n  {name} (VA=0x{va:016X}, RVA=0x{rva:08X}):")
            for insn in md.disasm(data, va):
                print(f"    0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")
        except Exception as e:
            print(f"  Error: {e}")

# Also check: what does 0x3FC0 look like (8 aliases point here)
print("\n\n=== RVA 0x3FC0 (8 aliases) ===")
rva = 0x3FC0
data = pe.get_data(rva, 100)
va = base + rva
for insn in md.disasm(data, va):
    print(f"  0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")

# And 0x77ED0 (6 aliases)
print("\n=== RVA 0x77ED0 (6 aliases) ===")
rva = 0x77ED0
data = pe.get_data(rva, 100)
va = base + rva
for insn in md.disasm(data, va):
    print(f"  0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")
