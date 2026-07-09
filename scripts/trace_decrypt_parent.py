"""
Found metadata mmap at RVA 0xAEF640. Now trace UP to find who calls it,
and also look at what happens AFTER the mmap call returns (the decrypt logic).
The decrypt is likely in a parent function that:
1. Calls 0xAEF640 to get the mapped buffer
2. Then XOR-decrypts the buffer

Also search deeper: the function at 0xAEF640 might itself call a decrypt
sub-function after the mmap. Let me get the full disassembly.
"""
import mmap, struct
from capstone import Cs, CS_ARCH_X86, CS_MODE_64

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

pe_off = struct.unpack_from('<I', mm, 0x3C)[0]
image_base = struct.unpack_from('<Q', mm, pe_off + 24 + 24)[0]

text_va = 0x1000
text_raw_off = 0x400
text_raw_size = 0xB41400
text_data = mm[text_raw_off:text_raw_off + text_raw_size]

cs = Cs(CS_ARCH_X86, CS_MODE_64)

# Step 1: Find callers of 0xAEF640
target_rva = 0xAEF640
print(f"=== Callers of metadata-loader (RVA 0x{target_rva:X}) ===\n")

callers = []
for pos in range(len(text_data) - 5):
    if text_data[pos] == 0xE8:
        disp = struct.unpack_from('<i', text_data, pos + 1)[0]
        call_rva = text_va + pos
        dest = call_rva + 5 + disp
        if dest == target_rva:
            callers.append(call_rva)

print(f"Found {len(callers)} callers:")
for c in callers:
    print(f"  RVA 0x{c:X}")

# Step 2: For each caller, get its function and look for XOR decrypt
for caller_rva in callers[:3]:
    pos = caller_rva - text_va
    func_start = caller_rva
    for back in range(pos - 1, max(0, pos - 2048), -1):
        if text_data[back] == 0xCC and (back == 0 or text_data[back-1] == 0xCC):
            func_start = text_va + back + 1
            break

    func_offset = func_start - text_va
    func_end = min(func_offset + 8192, len(text_data))
    for j in range(func_offset + 16, func_end):
        if text_data[j] == 0xCC and text_data[j+1] == 0xCC and text_data[j+2] == 0xCC:
            func_end = j
            break

    func_size = func_end - func_offset
    func_data = text_data[func_offset:func_end]

    print(f"\n{'='*70}")
    print(f"Parent function at RVA 0x{func_start:X} (size ~{func_size} bytes)")
    print(f"{'='*70}")

    # Look for interesting patterns
    interesting = []
    for insn in cs.disasm(func_data, image_base + func_start):
        rva = insn.address - image_base
        if insn.mnemonic == 'xor' and 'ptr' in insn.op_str:
            interesting.append((rva, f"XOR MEM: {insn.mnemonic} {insn.op_str}"))
        elif insn.mnemonic in ('sub', 'add') and '0x34' in insn.op_str:
            interesting.append((rva, f"CONST 0x34: {insn.mnemonic} {insn.op_str}"))
        elif insn.mnemonic in ('sub', 'add') and '0x23' in insn.op_str:
            interesting.append((rva, f"CONST 0x23(35): {insn.mnemonic} {insn.op_str}"))
        elif 'and' == insn.mnemonic and '0xff' in insn.op_str:
            interesting.append((rva, f"AND 0xFF: {insn.mnemonic} {insn.op_str}"))

    if interesting:
        print(f"  *** INTERESTING PATTERNS FOUND:")
        for rva, desc in interesting:
            print(f"      0x{rva:X}: {desc}")

    # Print full disassembly
    count = 0
    for insn in cs.disasm(func_data, image_base + func_start):
        rva = insn.address - image_base
        flag = ""
        if insn.mnemonic == 'xor' and 'ptr' in insn.op_str:
            flag = " <<< XOR MEM"
        elif insn.mnemonic == 'call':
            if insn.op_str.startswith('0x'):
                try:
                    dest = int(insn.op_str, 16) - image_base
                    if dest == target_rva:
                        flag = " <<< CALL metadata_loader"
                    elif dest == 0xAC7B50:
                        flag = " <<< CALL mmap"
                except:
                    pass
        print(f"  {rva:08X}: {insn.mnemonic:8s} {insn.op_str}{flag}")
        count += 1
        if count >= 120:
            print("  ... (truncated, function too large)")
            break

# Step 3: Also check what 0xAEF640 calls internally (sub-functions)
print(f"\n{'='*70}")
print(f"Sub-functions called BY 0xAEF640:")
print(f"{'='*70}")
func_offset = 0xAEF640 - text_va
func_data = text_data[func_offset:func_offset + 700]
subcalls = set()
for insn in cs.disasm(func_data, image_base + 0xAEF640):
    if insn.mnemonic == 'call' and insn.op_str.startswith('0x'):
        try:
            dest = int(insn.op_str, 16) - image_base
            if text_va <= dest < text_va + text_raw_size:
                subcalls.add(dest)
        except:
            pass
for sc in sorted(subcalls):
    print(f"  -> 0x{sc:X}")

mm.close()
f.close()
