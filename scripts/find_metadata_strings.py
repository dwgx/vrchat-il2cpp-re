"""Search for metadata-related strings and imports in GameAssembly.dll."""
import mmap, struct

GA = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
f = open(GA, 'rb')
mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

patterns = [
    b"global-metadata.dat",
    b"global-metadata",
    b"GlobalMetadata",
    b"metadata.dat",
    b"il2cpp_data",
    b"FAB11BAF",
    b"\xaf\x1b\xb1\xfa",  # magic bytes literal
]

print("=== ASCII string search ===")
for pat in patterns:
    pos = mm.find(pat)
    count = 0
    while pos != -1 and count < 3:
        ctx = mm[max(0,pos-4):pos+len(pat)+8]
        print(f"  [{pat!r}] at file offset 0x{pos:X}")
        print(f"    hex: {ctx.hex()}")
        count += 1
        pos = mm.find(pat, pos + 1)
    if count == 0:
        print(f"  [{pat!r}] NOT FOUND")

# UTF-16LE search
print("\n=== UTF-16LE string search ===")
for s in ["global-metadata.dat", "GlobalMetadata", "Metadata"]:
    pat16 = s.encode('utf-16-le')
    pos = mm.find(pat16)
    if pos != -1:
        print(f"  [{s}] at offset 0x{pos:X}")
    else:
        print(f"  [{s}] NOT FOUND")

# Import strings
print("\n=== Import function strings ===")
for imp in [b"MapViewOfFile", b"CreateFileW\x00", b"CreateFileMappingW"]:
    pos = mm.find(imp)
    if pos != -1:
        print(f"  [{imp.rstrip(b'\\x00').decode()}] at offset 0x{pos:X}")

# Look for the XOR pattern: sub with constant 0x34 (52)
# In .text section (offset 0x400, size 0xB41400)
print("\n=== XOR decrypt pattern (sub ?, 0x34) in .text ===")
text_data = mm[0x400:0x400 + 0xB41400]
sub34_patterns = [
    (b"\x83\xe8\x34", "sub eax, 0x34"),
    (b"\x83\xe9\x34", "sub ecx, 0x34"),
    (b"\x83\xea\x34", "sub edx, 0x34"),
    (b"\x83\xeb\x34", "sub ebx, 0x34"),
    (b"\x80\xf1\x34", "xor cl, 0x34"),
    (b"\x34\x34", "xor al, 0x34"),
]

for pat, desc in sub34_patterns:
    positions = []
    pos = 0
    while len(positions) < 20:
        pos = text_data.find(pat, pos)
        if pos == -1:
            break
        positions.append(pos)
        pos += 1
    if positions:
        print(f"  {desc}: {len(positions)} hits")
        # Show first 3 with context
        for p in positions[:3]:
            rva = 0x1000 + p
            print(f"    RVA 0x{rva:X}: {text_data[p:p+16].hex()}")

mm.close()
f.close()
