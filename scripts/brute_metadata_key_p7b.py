"""
Phase 7b: Search GameAssembly.dll for key-related data.
"""
import struct
import os

BINARY_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
FILE_SIZE = 40_512_432
KEY_0_3 = bytes([0x83, 0x67, 0xAF, 0xEC])

def search_binary(path, pattern, max_hits=50):
    """Search binary for a byte pattern, return file offsets."""
    hits = []
    CHUNK = 8 * 1024 * 1024
    overlap = len(pattern) - 1
    with open(path, "rb") as f:
        offset = 0
        prev = b""
        while True:
            chunk = f.read(CHUNK)
            if not chunk:
                break
            buf = prev + chunk
            pos = 0
            while pos < len(buf) - overlap:
                idx = buf.find(pattern, pos)
                if idx == -1:
                    break
                real_offset = offset - len(prev) + idx
                hits.append(real_offset)
                if len(hits) >= max_hits:
                    return hits
                pos = idx + 1
            prev = chunk[-overlap:] if overlap > 0 else b""
            offset += len(chunk)
    return hits

def read_at(path, offset, size=64):
    with open(path, "rb") as f:
        f.seek(offset)
        return f.read(size)

def main():
    print("="*70)
    print("PHASE 7b: Search GameAssembly.dll")
    print("="*70)

    binary_size = os.path.getsize(BINARY_PATH)
    print(f"Binary: {BINARY_PATH}")
    print(f"Size: {binary_size:,} bytes (0x{binary_size:X})")

    # 1. Search for key bytes [83 67 AF EC]
    print(f"\n[1] Searching for 83 67 AF EC...")
    hits = search_binary(BINARY_PATH, KEY_0_3)
    print(f"    Found {len(hits)} hits")
    for i, h in enumerate(hits[:20]):
        ctx = read_at(BINARY_PATH, max(0, h-8), 40)
        pre = ctx[:min(8,h)].hex(' ')
        key_part = ctx[min(8,h):min(8,h)+4].hex(' ')
        post = ctx[min(8,h)+4:].hex(' ')
        print(f"    [{i:2d}] 0x{h:08X}: {pre} [{key_part}] {post}")

    # 2. Search for 34 34 34 34 34 34 34 34 34 34 34 34 34 34 34 34 (xmm constant)
    print(f"\n[2] Searching for 0x34 x 16 (decrypt subtract constant)...")
    hits_34 = search_binary(BINARY_PATH, bytes([0x34]*16))
    print(f"    Found {len(hits_34)} hits")
    for i, h in enumerate(hits_34[:10]):
        ctx = read_at(BINARY_PATH, h, 32)
        print(f"    [{i:2d}] 0x{h:08X}: {ctx.hex(' ')}")

    # 3. Search for 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B 4B
    print(f"\n[3] Searching for 0x4B x 16 (filename subtract constant)...")
    hits_4b = search_binary(BINARY_PATH, bytes([0x4B]*16))
    print(f"    Found {len(hits_4b)} hits")
    for i, h in enumerate(hits_4b[:10]):
        ctx = read_at(BINARY_PATH, h, 32)
        print(f"    [{i:2d}] 0x{h:08X}: {ctx.hex(' ')}")

    # 4. Search for the filename XOR constants (all 5 of them concatenated or near each other)
    # 0xDAD8DAD2 = D2 DA D8 DA (LE)
    print(f"\n[4] Searching for filename XOR constant D2 DA D8 DA...")
    hits_fn = search_binary(BINARY_PATH, bytes([0xD2, 0xDA, 0xD8, 0xDA]))
    print(f"    Found {len(hits_fn)} hits")
    for i, h in enumerate(hits_fn[:10]):
        ctx = read_at(BINARY_PATH, h - 4, 48)
        print(f"    [{i:2d}] 0x{h:08X}: {ctx.hex(' ')}")
        # Check if the next constants follow nearby
        # 0xD196D6D8 = D8 D6 96 D1, 0xA4DECAD8 = D8 CA DE A4, 0xEAA2B6A0 = A0 B6 A2 EA
        next_bytes = read_at(BINARY_PATH, h + 4, 16)
        if next_bytes[:4] == bytes([0xD8, 0xD6, 0x96, 0xD1]):
            print(f"         *** NEXT CONSTANT MATCHES! Full filename XOR table found!")

    # 5. Look near the 0x34 constant locations for other nearby constants
    # that could be the NEW decrypt constant
    if hits_34:
        print(f"\n[5] Examining region around 0x34 constant at 0x{hits_34[0]:08X}...")
        # Read large context around first hit
        for h in hits_34[:3]:
            ctx = read_at(BINARY_PATH, max(0, h - 128), 384)
            print(f"    Context around 0x{h:08X} (-128 to +256):")
            for row in range(24):
                offset = row * 16
                addr = h - 128 + offset
                hex_str = ' '.join(f'{ctx[offset+j]:02X}' for j in range(16))
                print(f"      0x{addr:08X}: {hex_str}")

    # 6. Also search for the specific SIMD constant [00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00]
    print(f"\n[6] Searching for SIMD add constant [0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0]...")
    simd_add = bytes([0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0])
    hits_simd = search_binary(BINARY_PATH, simd_add, 30)
    print(f"    Found {len(hits_simd)} hits")
    # Check which ones are near the 0x34 or 0x4B constants
    for h in hits_simd[:10]:
        near_34 = any(abs(h - h34) < 4096 for h34 in hits_34)
        near_4b = any(abs(h - h4b) < 4096 for h4b in hits_4b)
        marker = ""
        if near_34:
            marker += " [near 0x34]"
        if near_4b:
            marker += " [near 0x4B]"
        print(f"    0x{h:08X}{marker}")

    # 7. Now look for what might be the NEW subtract constant.
    # If the old was 0x34 (repeated 16x), the new might be any other byte repeated 16x.
    # The new key[0] = (0 - NEW_CONST) & 0xFF should help us identify candidates.
    # But we proved the formula (i - const) can't produce our key sequence.
    # So maybe the constant region has been REPLACED by a non-repeating table.

    # Look at what's near the 0x4B constant (which is used for filename)
    # to find other data tables
    if hits_4b:
        print(f"\n[7] Examining 4KB region around 0x4B constant at 0x{hits_4b[0]:08X}...")
        base = max(0, hits_4b[0] - 256)
        ctx = read_at(BINARY_PATH, base, 1024)
        # Look for any 16-byte aligned patterns that could be XMM constants
        print(f"    16-byte aligned entries:")
        for row in range(64):
            offset = row * 16
            addr = base + offset
            chunk = ctx[offset:offset+16]
            # Flag interesting patterns (all same byte, or matching our key)
            unique_bytes = len(set(chunk))
            if unique_bytes == 1:
                print(f"    * 0x{addr:08X}: {chunk.hex(' ')}  (all 0x{chunk[0]:02X})")
            elif chunk[:4] == KEY_0_3:
                print(f"    * 0x{addr:08X}: {chunk.hex(' ')}  (STARTS WITH KEY!)")

    print("\n\nDone phase 7b.")

if __name__ == "__main__":
    main()
