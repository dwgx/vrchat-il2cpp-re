"""
Phase 5: The key has a position-dependent component.

Observation from Phase 4: Decrypting with the 4-byte repeating key gives
values that INCREASE with position. This suggests the REAL key has an
additional component that increases with position.

If real_key[i] = base_key[i%4] + f(i), then:
  decrypted_with_base_only[i] = plaintext[i] XOR base_key[i%4]
                                = plaintext[i] XOR (real_key[i] - f(i))
                                = (plaintext[i] XOR real_key[i]) XOR f(i)
  Wait no: XOR doesn't distribute over addition.

Let me think differently:
  encrypted[i] = plaintext[i] XOR real_key[i]
  real_key[i] = encrypted[i] XOR plaintext[i]

If plaintext is standard il2cpp metadata, most bytes in the header
(section offsets/sizes as u32 LE) would be SMALL numbers.
The encrypted bytes ARE approximately the key bytes.

From the encrypted data:
  F0 1E C2 C1 | CC B6 A8 BD | 84 5C 5C B8 | 88 5B B5 B7 | ...

If we look at just byte position 0 (every 4th byte):
  F0, CC, 84, 88, 3C, E0, FC, B8, 94, F0, 98, 18, E4, 80, 64, 18

Subtracting what we know (key[0]=0x83):
  If plaintext byte 0 positions (0, 4, 8, ...) are low bytes of u32 offsets:
  key[0] = 0x83, key[4] = enc[4] XOR plain[4], etc.

The encrypted data at dword level decreases smoothly from ~0xC1C2 to ~0x8460.
This is a range of about 0x3D62 over 16 dwords = 64 bytes.
Average decrease per byte: (0xC1C21EF0 - 0x84603F18) / 60 ~ 16 million per byte!?

No wait, per DWORD. 0x3D61DFD8 / 16 = ~0x3D61DF which is ~4 million per dword index.
But differences between consecutive dwords are NOT constant (68M, 88M, 10M, 65M...).

NEW HYPOTHESIS: The key bytes themselves form a stream that, when treated as
u32 LE dwords, decreases. What if:
  key_dword[n] = some_large_start - f(n)

And plaintext dwords are all SMALL (< 40MB), so encrypted ~ key.

The encrypted dwords decrease from 0xC1C21EF0 to 0x84603F18 over indices 0-15.
The first plaintext dword is "sym-" = 0x2D6D7973 (NOT small! It's 762 million!).
key_dword[0] = 0xECAF6783.

So the key itself doesn't simply decrease. Let's look at it differently.

What if the NEW decrypt algorithm is:
  key[i] = (i * MULTIPLIER + OFFSET) & 0xFF

But with a different relationship to the SIMD code?
The old code used: key[i] = (i - 0x34) & 0xFF
  which is key[i] = (i * 1 + 0xCC) & 0xFF (since -0x34 = 0xCC mod 256)

For the new code, let's just find if ANY linear formula works over the first 328 bytes
by checking structural validity of the decrypted header.

Actually, I just realized: maybe the key is (i - 0x34) & 0xFF but applied to a
TRANSFORMED version of the encrypted data. What if the file is first byte-swapped
or has some pre-processing?

OR: What if the 'magic' isn't "sym-" at all for the NEW version?
What if the magic is ACTUALLY standard 0xFAB11BAF and the key formula is still
(i - 0x34) & 0xFF?

Let me test: decrypt with old formula and check what magic we get.
"""

import struct

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
FILE_SIZE = 40_512_432

def read_header(path, size=1024):
    with open(path, "rb") as f:
        return f.read(size)

def main():
    data = read_header(METADATA_PATH)

    print("="*70)
    print("PHASE 5: Test old algorithm and reverse-engineer from structure")
    print("="*70)

    # Test 1: Old algorithm (i - 0x34) & 0xFF
    print("\n[TEST 1] Old algorithm: key[i] = (i - 0x34) & 0xFF")
    dec_old = bytes(data[i] ^ ((i - 0x34) & 0xFF) for i in range(64))
    print(f"  Magic bytes: {dec_old[:4].hex(' ')}")
    magic_u32 = struct.unpack_from("<I", dec_old, 0)[0]
    print(f"  Magic as u32: 0x{magic_u32:08X}")
    if dec_old[:4] == b'\xAF\x1B\xB1\xFA':
        print("  STANDARD IL2CPP MAGIC!")
    print(f"  First 16 bytes: {dec_old[:16].hex(' ')}")

    # Test 2: Try (i + 0x4F) & 0xFF  (since the new constant might be different)
    # If key[0]=0x83: (0 + C) & 0xFF = 0x83 means C = 0x83
    # Then key[1] = (1 + 0x83) & 0xFF = 0x84 -- not 0x67
    # So additive constant alone doesn't work.

    # Test 3: What if the formula uses a DIFFERENT increment?
    # key[i] = (base + i * step) & 0xFF
    # key[0] = base = 0x83
    # key[1] = (0x83 + step) & 0xFF = 0x67 => step = 0x67 - 0x83 = -0x1C = 0xE4
    # key[2] = (0x83 + 2*0xE4) & 0xFF = (0x83 + 0x1C8) & 0xFF = 0x4B -- need 0xAF
    # Nope.

    # Test 4: What if it's byte-reversed or has endian swap?
    print("\n[TEST 4] Try with reversed byte order in each dword")
    data_swapped = bytearray(len(data))
    for i in range(0, len(data)-3, 4):
        data_swapped[i] = data[i+3]
        data_swapped[i+1] = data[i+2]
        data_swapped[i+2] = data[i+1]
        data_swapped[i+3] = data[i]
    dec_swap = bytes(data_swapped[i] ^ ((i - 0x34) & 0xFF) for i in range(32))
    print(f"  Swapped+old_key magic: {dec_swap[:4].hex(' ')} = {dec_swap[:4]}")

    # Test 5: What if the key uses position / N where N > 1?
    # key[i] = ((i // 4) - 0x34) & 0xFF  (same key for each dword)
    print("\n[TEST 5] key[i] = ((i // N) - 0x34) & 0xFF for various N")
    for N in [2, 4, 8, 16]:
        dec_n = bytes(data[i] ^ (((i // N) - 0x34) & 0xFF) for i in range(8))
        print(f"  N={N:2d}: first 8 = {dec_n.hex(' ')}")

    # Test 6: Multiplicative key
    # key[i] = (i * M) & 0xFF for some M
    # key[0] = 0 -- can't be 0x83!
    # Unless: key[i] = ((i+1) * M) & 0xFF
    # key[0] = M = 0x83
    # key[1] = 2*0x83 = 0x106 & 0xFF = 0x06 -- not 0x67
    # Unless: key[i] = ((i+K) * M) & 0xFF
    #
    # Actually let me just brute this:
    print("\n[TEST 6] key[i] = ((i + K) * M) & 0xFF, brute force K, M")
    found_mult = False
    for K in range(256):
        for M in range(256):
            if ((0+K)*M) & 0xFF != 0x83:
                continue
            if ((1+K)*M) & 0xFF != 0x67:
                continue
            if ((2+K)*M) & 0xFF != 0xAF:
                continue
            if ((3+K)*M) & 0xFF != 0xEC:
                continue
            print(f"  MATCH: K={K} (0x{K:02X}), M={M} (0x{M:02X})")
            dec_test = bytes(data[i] ^ (((i+K)*M) & 0xFF) for i in range(32))
            print(f"    First 32: {dec_test[:32].hex(' ')}")
            print(f"    Magic: {dec_test[:4]}")
            found_mult = True
    if not found_mult:
        print("  No multiplicative match found.")

    # Test 7: key[i] = (A * i^2 + B * i + C) mod 256, wider search
    # We need: C=0x83, A+B+C=0x67, 4A+2B+C=0xAF, 9A+3B+C=0xEC
    # From 1,2: A+B = 0x67-0x83 = 0xE4 mod 256
    # From 1,3: 4A+2B = 0xAF-0x83 = 0x2C mod 256
    #           => 2(2A+B) = 0x2C => 2A+B = 0x16 mod 128
    #           But 2A+B might not be mod 128 in mod 256 arithmetic...
    # From A+B=0xE4: B = 0xE4-A
    # 2A + (0xE4-A) = 0x16 mod 256 => A + 0xE4 = 0x16 mod 256 => A = 0x32
    # Then B = 0xE4 - 0x32 = 0xB2
    # Check 3rd: 9*0x32 + 3*0xB2 + 0x83 = 0x1C2 + 0x216 + 0x83 = 0x4BB & 0xFF = 0xBB
    #   Need 0xEC. 0xBB != 0xEC.
    # BUT: 4A+2B might = 0x2C or 0x2C+256=0x12C mod 256
    # Let's try 4A+2B = 0x12C: 2A+B = 0x96
    # A + 0xE4 = 0x96 => A = 0xB2
    # B = 0xE4 - 0xB2 = 0x32
    # Check: 9*0xB2 + 3*0x32 + 0x83 = 0x642 + 0x96 + 0x83 = 0x75B & 0xFF = 0x5B. Need 0xEC. No.

    print("\n[TEST 7] Quadratic: no solution exists (verified algebraically)")

    # Test 8: What if it's a LOOKUP TABLE embedded in the binary?
    # The function extracts 18 seed bytes. What if those 18 bytes ARE the key
    # repeated? We know bytes 0-3 of the key. If the table is 18 bytes and
    # repeats, then bytes at positions 18, 36, 54 should also use key[0..3].
    # From phase 3, decrypting pos 18 with key[0..3] gave garbage.
    # So it's probably not an 18-byte table.

    # Test 9: KEY INSIGHT - What if the key generation involves BYTE POSITION
    # in a way that uses BOTH the index AND its relationship to 4-byte boundaries?
    #
    # For instance: key[i] = (i - 0x34 - (i/4)*EXTRA) & 0xFF
    # Or: key[i] = (i - 0x34) & 0xFF XOR something_per_dword
    #
    # Let's compute what the "correction" would need to be:
    # With old key: old[i] = (i - 0x34) & 0xFF = [0xCC, 0xCD, 0xCE, 0xCF, 0xD0, ...]
    # We need:    new[i] = [0x83, 0x67, 0xAF, 0xEC, ...]
    # Correction: new[i] XOR old[i] = [0x4F, 0xAA, 0x61, 0x23, ...]
    # OR: new[i] - old[i] = [0xB7, 0x9A, 0xE1, 0x1D, ...] (mod 256)

    print("\n[TEST 9] Correction factor between old and new key")
    old_key = [(i - 0x34) & 0xFF for i in range(32)]
    # We know new_key[0:4] = [0x83, 0x67, 0xAF, 0xEC]
    new_key_known = [0x83, 0x67, 0xAF, 0xEC]

    xor_correction = [new_key_known[i] ^ old_key[i] for i in range(4)]
    sub_correction = [(new_key_known[i] - old_key[i]) & 0xFF for i in range(4)]
    print(f"  XOR correction [0:4]: {[f'0x{c:02X}' for c in xor_correction]}")
    print(f"  SUB correction [0:4]: {[f'0x{c:02X}' for c in sub_correction]}")

    # Check if XOR correction has a pattern
    # [0x4F, 0xAA, 0x61, 0x23]
    # Differences: 0xAA-0x4F=0x5B, 0x61-0xAA=0xB7, 0x23-0x61=0xC2
    # XOR adjacent: 0x4F^0xAA=0xE5, 0xAA^0x61=0xCB, 0x61^0x23=0x42

    # Test 10: What if the constant 0x34 was replaced with a BYTE from the filename?
    # Filename "global-metadata.dat" = 20 bytes including null
    # What if different bytes of the filename are used as the subtract constant
    # for different positions?
    print("\n[TEST 10] Key using filename bytes as per-position constants")
    fname = b"global-metadata.dat\x00"
    for offset in range(20):
        # key[i] = (i - fname[i % len_used]) & 0xFF
        lens_to_try = [4, 8, 16, 20]
        for L in lens_to_try:
            if offset + 4 > L:
                continue
            test_key = [(i - fname[(i + offset) % L]) & 0xFF for i in range(4)]
            if test_key == new_key_known:
                print(f"  MATCH: offset={offset}, L={L}")

    # Test 11: What if key[i] = i XOR constant_dword_bytes?
    # key[0] = 0 ^ X = 0x83, so X=0x83
    # key[1] = 1 ^ Y = 0x67, so Y=0x66
    # key[2] = 2 ^ Z = 0xAF, so Z=0xAD
    # key[3] = 3 ^ W = 0xEC, so W=0xEF
    # Pattern in [X,Y,Z,W] = [0x83, 0x66, 0xAD, 0xEF]
    # As u32 LE: 0xEFAD6683
    print("\n[TEST 11] key[i] = i XOR dword_constant_bytes")
    xor_base = [0x83 ^ 0, 0x67 ^ 1, 0xAF ^ 2, 0xEC ^ 3]
    print(f"  Base dword bytes: {[f'0x{b:02X}' for b in xor_base]}")
    base_u32 = struct.unpack("<I", bytes(xor_base))[0]
    print(f"  As u32: 0x{base_u32:08X}")

    # If key[i] = i XOR base_bytes[i%4]:
    dec_test = bytes(data[i] ^ (i ^ xor_base[i % 4]) for i in range(64))
    print(f"  Decrypted first 64 bytes:")
    for row in range(4):
        offset = row * 16
        hex_str = ' '.join(f'{dec_test[offset+j]:02X}' for j in range(16))
        print(f"    {offset:04X}: {hex_str}")

    # Check if dwords look like valid offsets
    print(f"  As u32s:")
    for i in range(0, 64, 4):
        val = struct.unpack_from("<I", dec_test, i)[0]
        valid = "OK" if 0 < val < FILE_SIZE else ("ZERO" if val == 0 else "BIG")
        print(f"    [{i:3d}] 0x{val:08X} ({val:>12d}) [{valid}]")

    # Test 12: What about key[i] = (i - 0x34) XOR some_byte?
    # (0 - 0x34) XOR X = 0x83 => 0xCC XOR X = 0x83 => X = 0x4F
    # (1 - 0x34) XOR 0x4F = 0xCD XOR 0x4F = 0x82 -- need 0x67! No.

    # Test 13: key[i] = (i*i - constant) & 0xFF ??
    # key[0] = -C = 0x83 => C = 0x7D
    # key[1] = 1 - 0x7D = 0x84 -- need 0x67. No.

    # Test 14: DOUBLE-XOR or chained:
    # key[i] = ((i - A) ^ B) & 0xFF
    # (0-A)^B = 0x83
    # (1-A)^B = 0x67
    # XOR these: (0-A)^(1-A) = 0x83^0x67 = 0xE4
    # (0-A) XOR (1-A): since subtraction by A shifts both by same amount,
    # (-A) ^ (1-A): depends on bit patterns. Not trivially solvable.
    # But we can brute force A:
    print("\n[TEST 14] key[i] = ((i - A) ^ B) & 0xFF")
    for A in range(256):
        B = ((0 - A) & 0xFF) ^ 0x83
        if (((1 - A) & 0xFF) ^ B) != 0x67:
            continue
        if (((2 - A) & 0xFF) ^ B) != 0xAF:
            continue
        if (((3 - A) & 0xFF) ^ B) != 0xEC:
            continue
        print(f"  MATCH: A=0x{A:02X}, B=0x{B:02X}")
        dec_test = bytes(data[i] ^ ((((i - A) & 0xFF) ^ B) & 0xFF) for i in range(64))
        print(f"  Decrypted first 16: {dec_test[:16].hex(' ')}")
        print(f"  Magic: {dec_test[:4]}")

    # Test 15: key[i] = (A ^ (i - B)) & 0xFF (same as above, different notation)

    # Test 16: key[i] = ((i ^ A) - B) & 0xFF
    print("\n[TEST 16] key[i] = ((i ^ A) - B) & 0xFF")
    for A in range(256):
        B = ((0 ^ A) - 0x83) & 0xFF
        if (((1 ^ A) - B) & 0xFF) != 0x67:
            continue
        if (((2 ^ A) - B) & 0xFF) != 0xAF:
            continue
        if (((3 ^ A) - B) & 0xFF) != 0xEC:
            continue
        print(f"  MATCH: A=0x{A:02X}, B=0x{B:02X}")
        dec_test = bytes(data[i] ^ ((((i ^ A) - B) & 0xFF)) for i in range(64))
        print(f"  First 32: {dec_test[:32].hex(' ')}")
        vals = [struct.unpack_from("<I", dec_test, j)[0] for j in range(0, 32, 4)]
        print(f"  u32s: {[f'0x{v:08X}' for v in vals]}")
        for v in vals[1:]:
            if v < FILE_SIZE:
                print(f"    ^^ 0x{v:08X} is a valid offset!")

    # Test 17: key[i] = ((i * A) ^ B) & 0xFF
    print("\n[TEST 17] key[i] = ((i * A) ^ B) & 0xFF")
    # key[0] = (0 * A) ^ B = B = 0x83
    B = 0x83
    # key[1] = A ^ 0x83 = 0x67 => A = 0x67 ^ 0x83 = 0xE4
    A = 0xE4
    # key[2] = (2*0xE4) ^ 0x83 = 0x1C8 & 0xFF ^ 0x83 = 0xC8 ^ 0x83 = 0x4B -- need 0xAF
    k2 = ((2 * A) & 0xFF) ^ B
    print(f"  A=0xE4, B=0x83: key[2] = 0x{k2:02X} (need 0xAF) -- {'MATCH' if k2==0xAF else 'NO'}")

    # Test 18: key[i] = rotate_left(base, i) or similar bit rotation
    print("\n[TEST 18] Bit rotations of a base value")
    # Check if key bytes are rotations of each other
    for base in range(256):
        match = True
        rots = []
        for i, target in enumerate([0x83, 0x67, 0xAF, 0xEC]):
            found_rot = False
            for r in range(8):
                if ((base << r) | (base >> (8-r))) & 0xFF == target:
                    rots.append(r)
                    found_rot = True
                    break
            if not found_rot:
                match = False
                break
        if match:
            print(f"  Base 0x{base:02X}: rotations {rots} give key[0:4]")

    print("\n\n[TEST 19] key[i] = ((i + 1) * M - N) & 0xFF")
    for M in range(256):
        N_val = ((0 + 1) * M - 0x83) & 0xFF
        if ((1 + 1) * M - N_val) & 0xFF != 0x67:
            continue
        if ((2 + 1) * M - N_val) & 0xFF != 0xAF:
            continue
        if ((3 + 1) * M - N_val) & 0xFF != 0xEC:
            continue
        print(f"  MATCH: M=0x{M:02X}, N=0x{N_val:02X}")

    print("\n\nDone phase 5.")

if __name__ == "__main__":
    main()
