"""
Brute-force metadata encryption key for VRChat global-metadata.dat.

Known:
  Encrypted[0..3] = F0 1E C2 C1
  Plaintext[0..3] = 73 79 6D 2D ("sym-" = 0x2D6D7973 LE)
  XOR key[0..3]   = 0x83, 0x67, 0xAF, 0xEC

Strategy: try multiple key-generation algorithms, decrypt first 32 bytes,
check plausibility of the result.
"""

import struct
import sys

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
KNOWN_KEY = [0x83, 0x67, 0xAF, 0xEC]
EXPECTED_MAGIC = b"sym-"  # first 4 bytes after decryption

def read_header(path, size=1024):
    with open(path, "rb") as f:
        return f.read(size)

def decrypt(data, key_func, length=32):
    return bytes(data[i] ^ (key_func(i) & 0xFF) for i in range(length))

def is_plausible(decrypted):
    """Check if decrypted header looks like valid il2cpp metadata."""
    if decrypted[:4] != EXPECTED_MAGIC:
        return False
    # Bytes 4-7: could be version or flags (small integer)
    val_4_7 = struct.unpack_from("<I", decrypted, 4)[0]
    # Bytes 8-11: section count or version
    val_8_11 = struct.unpack_from("<I", decrypted, 8)[0]
    # At least one should be a reasonable small value
    return (val_4_7 < 1000 or val_8_11 < 1000)

def print_decrypted(label, decrypted):
    print(f"\n{'='*60}")
    print(f"  {label}")
    print(f"{'='*60}")
    print(f"  Hex: {decrypted[:32].hex(' ')}")
    print(f"  ASCII: {repr(decrypted[:32])}")
    vals = struct.unpack_from("<8I", decrypted, 0)
    print(f"  As LE u32s: {[f'0x{v:08X}' for v in vals]}")
    print(f"  As LE u32s (dec): {list(vals)}")
    v4 = struct.unpack_from("<I", decrypted, 4)[0]
    v8 = struct.unpack_from("<I", decrypted, 8)[0]
    v12 = struct.unpack_from("<I", decrypted, 12)[0]
    print(f"  [4:8]={v4} [8:12]={v8} [12:16]={v12}")

def main():
    print("Reading first 1024 bytes of metadata file...")
    data = read_header(METADATA_PATH)
    print(f"  Read {len(data)} bytes")
    print(f"  First 16 bytes (encrypted): {data[:16].hex(' ')}")
    print(f"  Known key[0..3]: {[hex(k) for k in KNOWN_KEY]}")

    # Verify known key bytes
    for i in range(4):
        assert (data[i] ^ KNOWN_KEY[i]) == EXPECTED_MAGIC[i], f"Key mismatch at byte {i}"
    print("  Key[0..3] verified against magic.")

    results = []

    # ===== Strategy 1: Repeating 4-byte key =====
    print("\n\n[1] REPEATING 4-BYTE KEY: [0x83, 0x67, 0xAF, 0xEC] cycled")
    dec = decrypt(data, lambda i: KNOWN_KEY[i % 4], 32)
    print_decrypted("key[i] = KNOWN[i % 4]", dec)
    if dec[:4] == EXPECTED_MAGIC:
        results.append(("4-byte repeat", dec))

    # ===== Strategy 2: Linear congruential key[i] = (A*i + B) % 256 =====
    print("\n\n[2] LINEAR: key[i] = (A*i + B) % 256")
    print("  Searching A=0..255, B=0..255 for match on key[0..3]...")
    linear_hits = []
    for A in range(256):
        for B in range(256):
            if ((0 * A + B) & 0xFF) != 0x83:
                continue
            if ((1 * A + B) & 0xFF) != 0x67:
                continue
            if ((2 * A + B) & 0xFF) != 0xAF:
                continue
            if ((3 * A + B) & 0xFF) != 0xEC:
                continue
            linear_hits.append((A, B))

    print(f"  Found {len(linear_hits)} linear matches")
    for A, B in linear_hits:
        dec = decrypt(data, lambda i, a=A, b=B: (a * i + b) & 0xFF, 32)
        print_decrypted(f"A={A} (0x{A:02X}), B={B} (0x{B:02X})", dec)
        if is_plausible(dec):
            results.append((f"linear A=0x{A:02X} B=0x{B:02X}", dec))

    # ===== Strategy 3: Repeating N-byte key (N=8,16,32) =====
    print("\n\n[3] REPEATING N-BYTE KEY (derive additional bytes from XOR)")
    for N in [8, 16, 32]:
        # Build key: first 4 bytes known, rest derived from encrypted data
        # assuming various plaintext patterns after magic
        pass  # We'll check results from strategy 1 first

    # ===== Strategy 4: key[i] = (i ^ C) for some constant =====
    print("\n\n[4] XOR-BASED: key[i] = (i ^ C) & 0xFF")
    # key[0] = 0^C = C = 0x83, key[1] = 1^0x83 = 0x82 != 0x67. Skip.
    print("  key[0]=0^C=0x83 => C=0x83, but key[1]=1^0x83=0x82 != 0x67. No match.")

    # ===== Strategy 5: LFSR / recurrence key[i+1] = f(key[i]) =====
    print("\n\n[5] RECURRENCE: key[i+1] = (key[i] * M + C) % 256")
    print("  Given key[0]=0x83, key[1]=0x67: find M,C where 0x83*M+C=0x67 mod 256")
    print("  Also 0x67*M+C=0xAF mod 256 and 0xAF*M+C=0xEC mod 256")
    lfsr_hits = []
    for M in range(256):
        # From key[0]->key[1]: 0x83*M + C = 0x67 mod 256 => C = (0x67 - 0x83*M) mod 256
        C = (0x67 - 0x83 * M) & 0xFF
        # Verify key[1]->key[2]: 0x67*M + C should = 0xAF
        if (0x67 * M + C) & 0xFF != 0xAF:
            continue
        # Verify key[2]->key[3]: 0xAF*M + C should = 0xEC
        if (0xAF * M + C) & 0xFF != 0xEC:
            continue
        lfsr_hits.append((M, C))

    print(f"  Found {len(lfsr_hits)} recurrence matches")
    for M, C in lfsr_hits:
        def make_key_func(m, c):
            cache = [0x83]
            def kf(i):
                while len(cache) <= i:
                    cache.append((cache[-1] * m + c) & 0xFF)
                return cache[i]
            return kf
        kf = make_key_func(M, C)
        dec = decrypt(data, kf, 32)
        print_decrypted(f"Recurrence M={M} (0x{M:02X}), C={C} (0x{C:02X})", dec)
        if is_plausible(dec):
            results.append((f"recurrence M=0x{M:02X} C=0x{C:02X}", dec))

    # ===== Strategy 6: Polynomial key[i] = (A*i^2 + B*i + C) % 256 =====
    print("\n\n[6] QUADRATIC: key[i] = (A*i^2 + B*i + C) % 256")
    # C = key[0] = 0x83
    # A + B + C = key[1] = 0x67 => A + B = 0x67 - 0x83 = -0x1C = 0xE4 mod 256
    # 4A + 2B + C = key[2] = 0xAF => 4A + 2B = 0xAF - 0x83 = 0x2C
    # 9A + 3B + C = key[3] = 0xEC => 9A + 3B = 0xEC - 0x83 = 0x69
    # From eq2: 4A + 2B = 0x2C => 2A + B = 0x16 mod 128... tricky in mod 256
    # Let's just brute force A, B
    quad_hits = []
    C_val = 0x83
    for A in range(256):
        B_val = (0xE4 - A) & 0xFF  # from key[1]
        if (4*A + 2*B_val + C_val) & 0xFF != 0xAF:
            continue
        if (9*A + 3*B_val + C_val) & 0xFF != 0xEC:
            continue
        quad_hits.append((A, B_val))

    print(f"  Found {len(quad_hits)} quadratic matches")
    for A, B in quad_hits:
        dec = decrypt(data, lambda i, a=A, b=B, c=C_val: (a*i*i + b*i + c) & 0xFF, 32)
        print_decrypted(f"Quadratic A=0x{A:02X}, B=0x{B:02X}, C=0x{C_val:02X}", dec)
        if is_plausible(dec):
            results.append((f"quadratic A=0x{A:02X} B=0x{B:02X} C=0x{C_val:02X}", dec))

    # ===== Strategy 7: key from subtraction pattern (old algorithm variant) =====
    print("\n\n[7] AFFINE VARIANTS: key[i] = (i*A + B) ^ C")
    # key[0] = B^C = 0x83
    # key[1] = (A+B)^C = 0x67
    # key[0]^key[1] = A = 0x83^0x67 = 0xE4
    A_xor = 0x83 ^ 0x67  # = 0xE4
    # key[1]^key[2] = A = 0x67^0xAF = 0xC8 ... not equal to 0xE4
    print(f"  key[0]^key[1] = 0x{A_xor:02X}, key[1]^key[2] = 0x{0x67^0xAF:02X} -- not constant. Skip.")

    # ===== Strategy 8: Try decrypting with key as first 4 bytes, check il2cpp metadata structure =====
    print("\n\n[8] ANALYSIS OF 4-BYTE REPEAT RESULT")
    dec = decrypt(data, lambda i: KNOWN_KEY[i % 4], min(64, len(data)))
    # Standard il2cpp global-metadata.dat header (unencrypted):
    # offset 0: magic "sym-" (or AF1BB1FA for unity)  -- wait, let me check
    # Actually standard magic is AF 1B B1 FA for il2cpp
    # But VRChat uses custom "sym-" magic
    print(f"  Decrypted magic: {dec[:4]} = {dec[:4].hex(' ')}")
    print(f"  Version (bytes 4-7 LE): {struct.unpack_from('<I', dec, 4)[0]}")
    print(f"  Bytes 4-7 as signed: {struct.unpack_from('<i', dec, 4)[0]}")

    # Check if it's standard il2cpp metadata header format:
    # u32 magic, u32 version, then pairs of (offset, count) for each section
    version = struct.unpack_from('<I', dec, 4)[0]
    if version < 100:
        print(f"  ** Version {version} looks valid! Standard il2cpp versions are 16-29+")
        # Try reading section offsets
        print("  Section table (offset, size) pairs:")
        for s in range(min(6, (len(dec)-8)//8)):
            off, sz = struct.unpack_from("<II", dec, 8 + s*8)
            print(f"    Section {s}: offset=0x{off:08X} ({off}), size={sz}")

    # ===== Strategy 9: Full 1024-byte analysis with 4-byte repeat =====
    print("\n\n[9] EXTENDED DECRYPTION (1024 bytes) WITH 4-BYTE REPEAT")
    dec_full = decrypt(data, lambda i: KNOWN_KEY[i % 4], 1024)
    # Look for patterns that confirm or deny this is the right key
    # Check for null bytes, ASCII regions, reasonable offsets
    null_count = dec_full.count(0)
    ascii_count = sum(1 for b in dec_full if 32 <= b < 127)
    print(f"  Null bytes: {null_count}/1024")
    print(f"  ASCII bytes: {ascii_count}/1024")
    print(f"  First 64 bytes hex:")
    for row in range(4):
        chunk = dec_full[row*16:(row+1)*16]
        hex_str = ' '.join(f'{b:02X}' for b in chunk)
        asc = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
        print(f"    {row*16:04X}: {hex_str}  {asc}")

    # ===== Summary =====
    print("\n\n" + "="*60)
    print("  SUMMARY OF PLAUSIBLE RESULTS")
    print("="*60)
    if results:
        for label, dec in results:
            print(f"\n  [{label}]")
            print(f"    Magic: {dec[:4]}")
            v = struct.unpack_from('<I', dec, 4)[0]
            print(f"    Version/field[4:8]: {v} (0x{v:08X})")
            v2 = struct.unpack_from('<I', dec, 8)[0]
            print(f"    Field[8:12]: {v2} (0x{v2:08X})")
    else:
        print("  No fully plausible results found.")
        print("  The 4-byte repeating key is the strongest candidate.")
        print("  Review strategy [8] output for structural analysis.")

    # ===== Extra: check if VRChat uses a position-dependent key with known seed =====
    print("\n\n[EXTRA] Checking known VRChat decrypt patterns...")
    # Pattern from ida/decrypt_constants.json if it exists
    # key[i] = seed_table[i % table_len] ^ (i >> shift)
    # With 4-byte table [0x83, 0x67, 0xAF, 0xEC] and XOR with i>>N
    for shift in range(0, 9):
        dec_test = decrypt(data, lambda i, s=shift: KNOWN_KEY[i % 4] ^ (i >> s), 8)
        if dec_test[:4] == EXPECTED_MAGIC:
            v = struct.unpack_from('<I', dec_test, 4)[0]
            if v < 10000:
                print(f"  HIT: key[i] = table[i%4] ^ (i >> {shift}), version={v}")
                dec_ext = decrypt(data, lambda i, s=shift: KNOWN_KEY[i % 4] ^ (i >> s), 32)
                print_decrypted(f"table XOR (i>>{shift})", dec_ext)
                results.append((f"table_xor_shift_{shift}", dec_ext))

    print("\n\nDone.")

if __name__ == "__main__":
    main()
