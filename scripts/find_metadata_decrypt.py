"""Locate the metadata decrypt function in the current GameAssembly.dll build."""
import mmap, struct, sys
from capstone import Cs, CS_ARCH_X86, CS_MODE_64

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
META = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"

f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

# PE parsing
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

print("Sections:")
for name, va, vsize, raw_size, raw_off in sections:
    print(f"  {name:8s} VA=0x{va:08X} rawOff=0x{raw_off:08X} rawSize=0x{raw_size:08X}")

def rva_to_file(rva):
    for name, va, vsize, raw_size, raw_off in sections:
        if va <= rva < va + vsize:
            return raw_off + (rva - va)
    return None

# Strategy 1: Look for the string "global-metadata.dat" in .rdata
print("\n=== Strategy 1: Find 'global-metadata.dat' string ===")
needle = b"global-metadata.dat\x00"
pos = mm.find(needle)
results = []
while pos != -1:
    # Calculate RVA
    for name, va, vsize, raw_size, raw_off in sections:
        if raw_off <= pos < raw_off + raw_size:
            string_rva = va + (pos - raw_off)
            results.append((pos, string_rva))
            print(f"  Found at file offset 0x{pos:X}, RVA 0x{string_rva:X}")
            break
    pos = mm.find(needle, pos + 1)

if not results:
    # Try UTF-16
    needle16 = "global-metadata.dat".encode('utf-16-le')
    pos = mm.find(needle16)
    if pos != -1:
        print(f"  Found UTF-16 at file offset 0x{pos:X}")

# Strategy 2: Find LEA instructions that reference the string RVA
# In x64, LEA reg, [rip + disp32] is: 48 8D ?? ?? ?? ?? ??
# The pattern is: REX.W + 8D + ModR/M(00,reg,101) + disp32
print("\n=== Strategy 2: Find xrefs to metadata string ===")
cs = Cs(CS_ARCH_X86, CS_MODE_64)
cs.detail = True

text_section = None
for name, va, vsize, raw_size, raw_off in sections:
    if name == '.text':
        text_section = (va, vsize, raw_size, raw_off)
        break

xref_functions = []
for file_pos, string_rva in results:
    # Search .text section for LEA [rip+disp] that targets this string_rva
    tva, tvsize, traw_size, traw_off = text_section
    # Scan for the pattern
    target_rva = string_rva
    scan_data = mm[traw_off:traw_off + traw_size]

    found_count = 0
    for i in range(len(scan_data) - 7):
        # Check for LEA with RIP-relative addressing
        # 48 8D 0D/05/15/1D/25/2D/35/3D xx xx xx xx
        if scan_data[i] in (0x48, 0x4C) and scan_data[i+1] == 0x8D:
            modrm = scan_data[i+2]
            if (modrm & 0xC7) == 0x05:  # mod=00, rm=101 (RIP-relative)
                disp = struct.unpack_from('<i', scan_data, i+3)[0]
                # RIP-relative: target = RVA_of_next_insn + disp
                insn_rva = tva + i
                next_insn_rva = insn_rva + 7
                ref_rva = next_insn_rva + disp
                if ref_rva == target_rva:
                    func_start = None
                    # Walk backwards to find function start (sub rsp or push rbp)
                    for back in range(i, max(i-256, 0), -1):
                        # Check for int3 padding (function boundary)
                        if scan_data[back] == 0xCC and (back == 0 or scan_data[back-1] == 0xCC):
                            func_start = tva + back + 1
                            break
                    print(f"  LEA xref at RVA 0x{insn_rva:X} (func ~0x{func_start:X})" if func_start else f"  LEA xref at RVA 0x{insn_rva:X}")
                    xref_functions.append((insn_rva, func_start))
                    found_count += 1
                    if found_count >= 10:
                        break
    print(f"  Total xrefs found: {found_count}")

# Strategy 3: Check old RVA
print("\n=== Strategy 3: Check old decrypt RVA 0xA7E880 ===")
old_rva = 0xA7E880
file_off = rva_to_file(old_rva)
if file_off:
    data = mm[file_off:file_off+64]
    print(f"  File offset: 0x{file_off:X}")
    print(f"  First 16 bytes: {data[:16].hex()}")
    # Disassemble first few instructions
    for insn in cs.disasm(data, image_base + old_rva):
        print(f"    0x{insn.address:X}: {insn.mnemonic} {insn.op_str}")
        if insn.mnemonic == 'ret':
            break

# Strategy 4: Search for the XOR pattern characteristic of the decrypt
# The old key was: key[i] = (i - 0x34) & 0xFF
# This means sub + and 0xFF pattern in the code
# Look for: sub reg, 0x34 followed by and reg, 0xFF or movzx
print("\n=== Strategy 4: Pattern scan for XOR decrypt loop ===")
# Pattern: The decrypt likely has:
# - A loop counter
# - XOR byte [mem], reg  or  XOR reg, [mem]
# - sub/add with 0x34 (52 decimal)
# Search .text for 'sub ecx/edx/eax, 0x34' near 'xor' instructions
# sub eax, 0x34 = 83 E8 34 or 2D 34 00 00 00
# sub ecx, 0x34 = 83 E9 34
# sub edx, 0x34 = 83 EA 34
patterns_found = []
for pattern in [b'\x83\xe8\x34', b'\x83\xe9\x34', b'\x83\xea\x34',
                b'\x83\xeb\x34', b'\x83\xec\x34', b'\x83\xed\x34']:
    pos = 0
    while True:
        pos = scan_data.find(pattern, pos)
        if pos == -1:
            break
        # Check if there's a XOR within +-20 bytes
        nearby = scan_data[max(0,pos-20):pos+40]
        has_xor = any(nearby[j] in (0x30, 0x31, 0x32, 0x33, 0x34, 0x35)
                      for j in range(len(nearby)))
        if has_xor:
            rva = tva + pos
            patterns_found.append(rva)
        pos += 1

print(f"  Found {len(patterns_found)} 'sub reg, 0x34' near XOR instructions")
if patterns_found[:5]:
    for rva in patterns_found[:5]:
        fo = rva_to_file(rva)
        data = mm[fo:fo+48]
        print(f"\n  RVA 0x{rva:X}:")
        for insn in cs.disasm(data, image_base + rva):
            print(f"    0x{insn.address:X}: {insn.mnemonic} {insn.op_str}")

mm.close()
f.close()
