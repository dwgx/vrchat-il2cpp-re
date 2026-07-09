"""Verify the avatar-geometry accessor RVAs reported by the research agents.
Disassemble each claimed RVA and check it looks like a real IL2CPP method prologue
(MSVC save + sub rsp + static-init guard cmp byte[rip+d],0 / jne)."""
import mmap, struct
from capstone import Cs, CS_ARCH_X86, CS_MODE_64

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

pe_off = struct.unpack_from('<I', mm, 0x3C)[0]
num_sections = struct.unpack_from('<H', mm, pe_off + 6)[0]
opt_hdr_size = struct.unpack_from('<H', mm, pe_off + 20)[0]
sections_off = pe_off + 24 + opt_hdr_size
image_base = struct.unpack_from('<Q', mm, pe_off + 24 + 24)[0]

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
        if va <= rva < va + vsize:
            if (rva - va) < rsize:
                return roff + (rva - va)
    return None

def sec_of(rva):
    for name, va, vsize, rsize, roff in secs:
        if va <= rva < va + vsize:
            return name
    return "?"

cs = Cs(CS_ARCH_X86, CS_MODE_64)

TARGETS = [
    ("SkinnedMeshRenderer.get_sharedMesh", 0x7BB2D90),
    ("SkinnedMeshRenderer.get_bones",      0x7BB2C40),
    ("SkinnedMeshRenderer.BakeMesh",       0x7BB3200),
    ("Mesh.get_vertices",                  0x7BBAB70),
    ("Mesh.get_triangles",                 0x7BBE380),
    ("Mesh.get_boneWeights",               0x7BC0F90),
    ("Mesh.get_bindposes",                 0x7BB8A60),
    ("Renderer.get_sharedMaterials",       0x7B94C10),
    ("AssetBundle.LoadAsset_Internal",     0x7B2F150),
    ("AssetBundle.LoadAllAssetsAsync",     0x7B2F7D0),
    ("AssetBundle.GetAllAssetNames",       0x7B2FA60),
    ("MeshPerfScanner.AnalyzeSMR",         0xA769160),
]

print(f"ImageBase 0x{image_base:X}")
print(f"{'name':<38} {'RVA':>10} {'sec':<8} verdict")
print("-"*90)
for name, rva in TARGETS:
    fo = rva_to_file(rva)
    sec = sec_of(rva)
    if fo is None:
        print(f"{name:<38} 0x{rva:08X} {sec:<8} NO FILE MAPPING (out of raw / bad rva)")
        continue
    data = mm[fo:fo+24]
    # Decode a few instructions
    insns = list(cs.disasm(data, image_base + rva))
    # Heuristic: real method = starts with mov [rsp+..],reg OR sub rsp OR push, and within
    # first ~6 insns has a `cmp byte ptr [rip+...], 0` (static init guard) OR is a thin getter
    has_guard = False
    mnems = []
    for ins in insns[:8]:
        mnems.append(ins.mnemonic)
        if ins.mnemonic == 'cmp' and 'byte ptr [rip' in ins.op_str and ins.op_str.rstrip().endswith(', 0'):
            has_guard = True
    prologue_ok = insns and insns[0].mnemonic in ('mov','sub','push','lea','xor','movzx','cmp','test')
    verdict = "OK-guard" if has_guard else ("OK-prologue" if prologue_ok else "SUSPECT")
    first = f"{insns[0].mnemonic} {insns[0].op_str}" if insns else "??"
    print(f"{name:<38} 0x{rva:08X} {sec:<8} {verdict:<12} | {data[:8].hex()} | {first}")

mm.close()
f.close()
