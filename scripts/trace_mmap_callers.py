"""
Found: MapViewOfFile caller at RVA 0xAC7B50 (the file-mapping utility function).
Now trace who CALLS 0xAC7B50 — that's the metadata loader which does:
  1. Call file-mapping function (0xAC7B50)
  2. Get pointer to mapped data
  3. XOR decrypt the header
  4. Parse section offsets
  5. XOR decrypt each section

We need to find callers of 0xAC7B50, then disassemble their bodies looking for XOR loops.
"""
import mmap, struct
from capstone import Cs, CS_ARCH_X86, CS_MODE_64

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

pe_off = struct.unpack_from('<I', mm, 0x3C)[0]
image_base = struct.unpack_from('<Q', mm, pe_off + 24 + 24)[0]

# .text section
text_va = 0x1000
text_raw_off = 0x400
text_raw_size = 0xB41400
text_data = mm[text_raw_off:text_raw_off + text_raw_size]

# Target: find CALL instructions to RVA 0xAC7B50
# In x64, near CALL is E8 + signed 32-bit displacement
# target = (caller_rva + 5) + disp32
target_rva = 0xAC7B50
print(f"=== Finding callers of file-mapping function (RVA 0x{target_rva:X}) ===\n")

callers = []
for pos in range(len(text_data) - 5):
    if text_data[pos] == 0xE8:  # CALL rel32
        disp = struct.unpack_from('<i', text_data, pos + 1)[0]
        call_rva = text_va + pos
        dest = call_rva + 5 + disp
        if dest == target_rva:
            callers.append(call_rva)

print(f"Found {len(callers)} direct callers of 0x{target_rva:X}:")
for c in callers:
    print(f"  RVA 0x{c:X}")

# For each caller, find the function start and disassemble
cs = Cs(CS_ARCH_X86, CS_MODE_64)

for caller_rva in callers[:5]:
    # Find function start
    pos = caller_rva - text_va
    func_start = caller_rva
    for back in range(pos - 1, max(0, pos - 1024), -1):
        if text_data[back] == 0xCC and (back == 0 or text_data[back-1] == 0xCC):
            func_start = text_va + back + 1
            break

    # Disassemble the whole function (up to 2KB or next int3 run)
    func_offset = func_start - text_va
    func_end = min(func_offset + 4096, len(text_data))
    # Find actual end (3+ consecutive CC)
    for j in range(func_offset + 16, func_end):
        if text_data[j] == 0xCC and text_data[j+1] == 0xCC and text_data[j+2] == 0xCC:
            func_end = j
            break

    func_size = func_end - func_offset
    func_data = text_data[func_offset:func_end]

    print(f"\n{'='*70}")
    print(f"Caller function at RVA 0x{func_start:X} (size ~{func_size} bytes)")
    print(f"{'='*70}")

    # Check if this function contains XOR patterns
    has_xor_loop = False
    xor_locations = []

    for insn in cs.disasm(func_data, image_base + func_start):
        if insn.mnemonic == 'xor' and 'ptr' in insn.op_str:
            xor_locations.append(insn.address - image_base)
            has_xor_loop = True

    if has_xor_loop:
        print(f"  *** CONTAINS XOR MEMORY OPERATIONS at RVAs: {['0x%X' % x for x in xor_locations]}")

    # Print first 60 instructions
    count = 0
    for insn in cs.disasm(func_data, image_base + func_start):
        flag = " <<<" if (insn.mnemonic == 'xor' and 'ptr' in insn.op_str) else ""
        flag2 = " <<<CALL_MMAP" if (insn.mnemonic == 'call' and hex(target_rva) in insn.op_str) else ""
        if insn.mnemonic == 'call':
            # Check if it's calling our target
            if insn.op_str.startswith('0x'):
                try:
                    dest = int(insn.op_str, 16) - image_base
                    if dest == target_rva:
                        flag2 = " <<<CALL_MMAP"
                except:
                    pass
        print(f"  {insn.address - image_base:08X}: {insn.mnemonic:8s} {insn.op_str}{flag}{flag2}")
        count += 1
        if count >= 80:
            print("  ... (truncated)")
            break

mm.close()
f.close()
