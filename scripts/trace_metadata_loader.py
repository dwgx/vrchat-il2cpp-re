"""
Trace metadata decrypt by finding callers of CreateFileMappingW/MapViewOfFile.
The metadata loader does: CreateFileW -> GetFileSizeEx -> CreateFileMappingW -> MapViewOfFile
Then applies XOR decryption to the mapped buffer.

Strategy: Find the IAT entry for MapViewOfFile, then scan .text for CALL [rip+disp]
that targets that IAT slot. Those callers are the file-mapping functions.
"""
import mmap, struct, sys
from capstone import Cs, CS_ARCH_X86, CS_MODE_64

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

# PE basics
pe_off = struct.unpack_from('<I', mm, 0x3C)[0]
num_sections = struct.unpack_from('<H', mm, pe_off + 6)[0]
opt_hdr_size = struct.unpack_from('<H', mm, pe_off + 20)[0]
sections_off = pe_off + 24 + opt_hdr_size
image_base = struct.unpack_from('<Q', mm, pe_off + 24 + 24)[0]

sections = []
for i in range(num_sections):
    so = sections_off + i * 40
    name = mm[so:so+8].rstrip(b'\x00').decode('ascii', errors='replace')
    vsize = struct.unpack_from('<I', mm, so + 8)[0]
    va = struct.unpack_from('<I', mm, so + 12)[0]
    raw_size = struct.unpack_from('<I', mm, so + 16)[0]
    raw_off = struct.unpack_from('<I', mm, so + 20)[0]
    sections.append((name, va, vsize, raw_size, raw_off))

def rva_to_file(rva):
    for name, va, vsize, raw_size, raw_off in sections:
        if va <= rva < va + vsize:
            return raw_off + (rva - va)
    return None

# Parse import directory to find IAT entries for target functions
import_dir_rva = struct.unpack_from('<I', mm, pe_off + 24 + 120)[0]  # import table RVA
import_dir_size = struct.unpack_from('<I', mm, pe_off + 24 + 124)[0]

print(f"Import Directory RVA: 0x{import_dir_rva:X}")

# Parse import descriptors to find KERNEL32.dll entries
# Each descriptor is 20 bytes: OriginalFirstThunk(4), TimeDateStamp(4), ForwarderChain(4), Name(4), FirstThunk(4)
target_funcs = {"MapViewOfFile": None, "CreateFileMappingW": None, "CreateFileW": None}
found_iat = {}

desc_off = rva_to_file(import_dir_rva)
while True:
    oft_rva = struct.unpack_from('<I', mm, desc_off)[0]
    name_rva = struct.unpack_from('<I', mm, desc_off + 12)[0]
    ft_rva = struct.unpack_from('<I', mm, desc_off + 16)[0]
    if oft_rva == 0 and name_rva == 0:
        break

    # Read DLL name
    name_off = rva_to_file(name_rva)
    dll_name = b""
    for j in range(64):
        c = mm[name_off + j]
        if c == 0:
            break
        dll_name += bytes([c])
    dll_name = dll_name.decode('ascii', errors='replace')

    if 'KERNEL32' in dll_name.upper():
        # Walk the ILT/IAT together
        ilt_off = rva_to_file(oft_rva)
        iat_rva_base = ft_rva
        idx = 0
        while True:
            hint_rva = struct.unpack_from('<Q', mm, ilt_off + idx * 8)[0]
            if hint_rva == 0:
                break
            if not (hint_rva & 0x8000000000000000):  # not ordinal
                hint_off = rva_to_file(hint_rva & 0x7FFFFFFF)
                if hint_off:
                    func_name = b""
                    for j in range(64):
                        c = mm[hint_off + 2 + j]
                        if c == 0:
                            break
                        func_name += bytes([c])
                    func_name = func_name.decode('ascii', errors='replace')
                    if func_name in target_funcs:
                        iat_entry_rva = iat_rva_base + idx * 8
                        target_funcs[func_name] = iat_entry_rva
                        print(f"  {func_name}: IAT entry at RVA 0x{iat_entry_rva:X}")
            idx += 1
    desc_off += 20

# Now find CALL [rip+disp] that reference these IAT entries in .text
print("\n=== Finding callers of MapViewOfFile/CreateFileMappingW ===")
text_va = 0x1000
text_raw_off = 0x400
text_raw_size = 0xB41400
text_data = mm[text_raw_off:text_raw_off + text_raw_size]

cs = Cs(CS_ARCH_X86, CS_MODE_64)

for func_name, iat_rva in target_funcs.items():
    if iat_rva is None:
        continue
    print(f"\n  {func_name} (IAT RVA 0x{iat_rva:X}):")
    callers = []
    # Pattern: FF 15 xx xx xx xx (call [rip+disp32])
    pos = 0
    while len(callers) < 20:
        pos = text_data.find(b'\xFF\x15', pos)
        if pos == -1:
            break
        disp = struct.unpack_from('<i', text_data, pos + 2)[0]
        # call [rip+disp] target = (text_va + pos + 6) + disp
        call_rva = text_va + pos
        target = call_rva + 6 + disp
        if target == iat_rva:
            callers.append(call_rva)
        pos += 1

    print(f"    {len(callers)} callers found")
    for caller_rva in callers[:5]:
        # Find function start by scanning backwards for int3 padding
        start_search = caller_rva - text_va
        func_start_rva = caller_rva
        for back in range(start_search, max(0, start_search - 512), -1):
            if text_data[back] == 0xCC:
                func_start_rva = text_va + back + 1
                break

        func_size = min(256, text_raw_size - (func_start_rva - text_va))
        func_data = text_data[func_start_rva - text_va:func_start_rva - text_va + func_size]

        print(f"\n    Caller at RVA 0x{caller_rva:X} (function starts ~0x{func_start_rva:X}):")
        count = 0
        for insn in cs.disasm(func_data, image_base + func_start_rva):
            print(f"      {insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")
            count += 1
            if count >= 30 or insn.mnemonic == 'ret':
                break

mm.close()
f.close()
