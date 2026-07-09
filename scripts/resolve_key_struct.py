"""
Resolve the key-material structure that the metadata decryptor (0xAC6B80) reads.
The function starts with:
  0xAC6B8B: movsxd rax, dword ptr [rip - 0xac6b56]   <- loads an index/selector
  0xAC6B92: lea    rbx, [rip - 0xac6b99]              <- base pointer
  0xAC6B99: mov    ecx, [rax + rbx + 0xb8]
  0xAC6BA0: cmp    [rcx + rbx + 0xc], 2
Then reads many bytes via movzx [rcx/rdx/r13 + rbx + small_off].

Goal: resolve the actual RIP-relative targets in the binary and dump the referenced
data so we can see the key seed bytes.
"""
import mmap, struct
from capstone import Cs, CS_ARCH_X86, CS_MODE_64, CS_OP_MEM

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)
image_base = 0x180000000

pe_off = struct.unpack_from('<I', mm, 0x3C)[0]
num_sections = struct.unpack_from('<H', mm, pe_off + 6)[0]
opt_hdr_size = struct.unpack_from('<H', mm, pe_off + 20)[0]
sections_off = pe_off + 24 + opt_hdr_size
secs = []
for i in range(num_sections):
    so = sections_off + i * 40
    name = mm[so:so+8].rstrip(b'\x00').decode('ascii','replace')
    vsize = struct.unpack_from('<I', mm, so + 8)[0]
    va = struct.unpack_from('<I', mm, so + 12)[0]
    rsize = struct.unpack_from('<I', mm, so + 16)[0]
    roff = struct.unpack_from('<I', mm, so + 20)[0]
    secs.append((name, va, vsize, rsize, roff))

def rva_to_file(rva):
    for name, va, vsize, rsize, roff in secs:
        if va <= rva < va + vsize and (rva - va) < rsize:
            return roff + (rva - va)
    return None

def sec_of(rva):
    for name, va, vsize, rsize, roff in secs:
        if va <= rva < va + vsize:
            return name
    return "?"

cs = Cs(CS_ARCH_X86, CS_MODE_64)
cs.detail = True

# Disassemble 0xAC6B80 fully, resolve every RIP-relative memory reference
rva = 0xAC6B80
fo = rva_to_file(rva)
data = mm[fo:fo+400]

print("=== 0xAC6B80 decrypt-key reader: RIP-relative targets ===\n")
rip_targets = []
for ins in cs.disasm(data, image_base + rva):
    r = ins.address - image_base
    # find rip-relative operand
    for op in ins.operands:
        if op.type == CS_OP_MEM and op.mem.base == 0 and op.mem.index == 0:
            # possible absolute; skip
            pass
    # simpler: capstone puts rip target computation in op_str; detect 'rip'
    if 'rip' in ins.op_str:
        # target = next_insn_addr + disp ; capstone gives disp in operand
        for op in ins.operands:
            if op.type == CS_OP_MEM and cs.reg_name(op.mem.base) == 'rip':
                disp = op.mem.disp
                target_rva = (r + ins.size) + disp
                tsec = sec_of(target_rva)
                rip_targets.append((r, ins.mnemonic, ins.op_str, target_rva, tsec))
                print(f"  0x{r:X}: {ins.mnemonic} {ins.op_str}")
                print(f"       -> target RVA 0x{target_rva:X} in [{tsec}]")
    if ins.mnemonic == 'ret' or (ins.mnemonic == 'jmp' and 'rip' not in ins.op_str and r > rva+0x100):
        break

# Dump the primary struct target (first rip target that lands in .data/.rdata)
print("\n=== Dumping referenced data regions ===")
seen = set()
for r, mn, ops, trva, tsec in rip_targets:
    if trva in seen: continue
    seen.add(trva)
    if tsec in ('.data', '.rdata', 'il2cpp'):
        tfo = rva_to_file(trva)
        if tfo:
            blob = mm[tfo:tfo+64]
            print(f"\n  [{tsec}] RVA 0x{trva:X} (from {mn} @ 0x{r:X}):")
            print(f"    {blob[:32].hex()}")
            print(f"    {blob[32:64].hex()}")
            # interpret as dwords
            dwords = struct.unpack_from('<8I', blob, 0)
            print(f"    dwords: {['0x%X'%d for d in dwords]}")

mm.close()
f.close()
