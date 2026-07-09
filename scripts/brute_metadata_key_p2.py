"""
Brute-force metadata encryption key - Phase 2.
The 4-byte repeating key [0x83, 0x67, 0xAF, 0xEC] decrypts the magic
but gives garbage for subsequent fields. The key is NOT simply repeating.

New strategies:
- Assume il2cpp metadata header structure after magic
- Use known structure to derive more key bytes
- Then find the generation algorithm
"""

import struct
import sys

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
KNOWN_KEY = [0x83, 0x67, 0xAF, 0xEC]
EXPECTED_MAGIC = b"sym-"
FILE_SIZE = 40_512_432

def read_header(path, size=1024):
    with open(path, "rb") as f:
        return f.read(size)

def main():
    data = read_header(METADATA_PATH)
    print(f"Encrypted first 32 bytes: {data[:32].hex(' ')}")
    print(f"File size: {FILE_SIZE} bytes (0x{FILE_SIZE:X})")
    print()

    # =========================================================================
    # IL2CPP METADATA HEADER STRUCTURE (standard, version 24+):
    # Offset  Size  Field
    # 0       4     magic (0xFAB11BAF standard, or "sym-" for VRChat custom)
    # 4       4     version (24, 27, 29, etc.)
    # 8       4     stringLiteralOffset
    # 12      4     stringLiteralSize (was stringLiteralCount in older)
    # 16      4     stringLiteralDataOffset
    # 20      4     stringLiteralDataSize (was stringLiteralDataCount)
    # 24      4     stringOffset
    # 28      4     stringSize (was stringCount)
    # ...
    # Total header: version-dependent but usually ~260-272 bytes of offset/size pairs
    # =========================================================================

    # Likely versions for Unity 2022/6: 29, 31
    # Let's try both and derive key bytes
    print("="*70)
    print("STRATEGY: Assume known header values, derive key bytes")
    print("="*70)

    # For each candidate version, compute what key bytes 4-7 would need to be
    for version in [24, 27, 29, 31]:
        expected_4_7 = struct.pack("<I", version)
        key_4_7 = [data[4+i] ^ expected_4_7[i] for i in range(4)]
        print(f"\n  If version={version}: key[4..7] = {[f'0x{k:02X}' for k in key_4_7]}")

    # Now, for the offset/size pairs after version:
    # stringLiteralOffset should be > header_size (say > 256) and < file_size
    # stringLiteralSize should be < file_size
    # Offsets should be aligned (often to 4 bytes)

    print("\n\n" + "="*70)
    print("STRATEGY: Assume version=29, derive full key from structure constraints")
    print("="*70)

    # Standard il2cpp v29 has these sections (offset, size pairs starting at byte 8):
    # The first offset is usually close to the header end (around 0x108 = 264 bytes)
    # For a 40MB file, offsets are in range [256, 40512432]

    # Let's try version 29 and see if assuming the first section offset
    # is around 264-512 gives us consistent key bytes

    for version in [24, 27, 29, 31]:
        ver_bytes = struct.pack("<I", version)
        key_4_7 = [data[4+i] ^ ver_bytes[i] for i in range(4)]

        # Now check: do key bytes follow any pattern with KNOWN_KEY?
        full_key_8 = KNOWN_KEY + key_4_7
        print(f"\n  Version {version}: key[0..7] = {[f'0x{k:02X}' for k in full_key_8]}")

        # Check differences
        diffs = [(full_key_8[i+1] - full_key_8[i]) & 0xFF for i in range(7)]
        print(f"    Deltas: {[f'0x{d:02X}' for d in diffs]}")

        # Check XOR pattern
        xors = [full_key_8[i] ^ full_key_8[i+1] for i in range(7)]
        print(f"    XORs:   {[f'0x{x:02X}' for x in xors]}")

    # =========================================================================
    # NEW IDEA: What if the key depends on position non-linearly?
    # The decrypt function at 0xA88252 uses SIMD (psrldq, movd, etc.)
    # suggesting it processes 16 bytes at a time.
    # Maybe key is: key[i] = base_key[i % 16] or key[i] = f(i, seed_table)
    #
    # Let's try: if version=29 is correct, we know key[0..7].
    # Then try version=29 and first_offset around standard values to get key[8..15]
    # =========================================================================

    print("\n\n" + "="*70)
    print("STRATEGY: Derive 16-byte key block assuming version=29")
    print("="*70)

    version = 29
    ver_bytes = struct.pack("<I", version)
    key_so_far = list(KNOWN_KEY) + [data[4+i] ^ ver_bytes[i] for i in range(4)]
    print(f"  key[0..7] (assuming v29): {[f'0x{k:02X}' for k in key_so_far]}")

    # Standard metadata v29: header is 0x110 (272) bytes
    # First section offset = header_size = 272 = 0x110
    # But VRChat may have custom header size. Try a few.

    # Actually, let's look at what offsets are common for stringLiteralOffset
    # For 40MB file, first offset is typically between 0x100 and 0x200
    # stringLiteralSize can be anything but is typically a large chunk

    # Instead of guessing, let's try to find the key pattern from key[0..7]
    # key[0..7] with version=29:
    key_v29 = key_so_far[:]
    print(f"\n  Analyzing key[0..7] with v29:")
    print(f"    Values: {key_v29}")
    print(f"    As pairs: ({key_v29[0]:02X},{key_v29[1]:02X}), ({key_v29[2]:02X},{key_v29[3]:02X}), ({key_v29[4]:02X},{key_v29[5]:02X}), ({key_v29[6]:02X},{key_v29[7]:02X})")

    # Check if it could be two interleaved sequences
    evens = [key_v29[i] for i in range(0, 8, 2)]
    odds = [key_v29[i] for i in range(1, 8, 2)]
    print(f"    Evens: {[f'0x{e:02X}' for e in evens]}")
    print(f"    Odds:  {[f'0x{o:02X}' for o in odds]}")
    even_diffs = [(evens[i+1] - evens[i]) & 0xFF for i in range(len(evens)-1)]
    odd_diffs = [(odds[i+1] - odds[i]) & 0xFF for i in range(len(odds)-1)]
    print(f"    Even diffs: {[f'0x{d:02X}' for d in even_diffs]}")
    print(f"    Odd diffs:  {[f'0x{d:02X}' for d in odd_diffs]}")

    # =========================================================================
    # CRITICAL TEST: What if the key is generated from the file size or a constant?
    # old algorithm: key[i] = (i - 0x34) & 0xFF
    # new might be: key[i] = (i * K - 0x34) & 0xFF or similar
    # =========================================================================

    print("\n\n" + "="*70)
    print("STRATEGY: Extensive brute of key[i] = (a*i^2 + b*i + c) mod 256")
    print("  with all (a,b) searching over wider space")
    print("="*70)

    # With version=29, we have 8 known key bytes. Let's use all 8 to constrain.
    # key = [0x83, 0x67, 0xAF, 0xEC, k4, k5, k6, k7]
    # where k4..k7 come from version=29 assumption

    # Actually, let me try version=29 and also common header sizes to get bytes 8-11
    # Standard v29 header: stringLiteralOffset at offset 8
    # This offset should equal the header size (first data comes right after header)
    # v29 header = 4 + 4 + 13*8 = 112? No...
    # Actually v29: magic(4) + version(4) + 33 section pairs * 8 = 4+4+264 = 272 = 0x110
    # Wait, let me count properly for metadata v29:
    # It has pairs: stringLiteral, stringLiteralData, string, events, properties,
    # methods, parameterDefaultValues, fieldDefaultValues, fieldAndParameterDefaultValueData,
    # fieldMarshaledSizes, parameters, fields, genericParameters, genericParameterConstraints,
    # genericContainers, nestedTypes, interfaces, vtableMethods, interfaceOffsets,
    # typeDefinitions, images, assemblies, metadataUsageLists, metadataUsagePairs,
    # fieldRefs, referencedAssemblies, attributeInfo, attributeTypes,
    # unresolvedVirtualCallParameterTypes, unresolvedVirtualCallParameterRanges,
    # windowsRuntimeTypeNames, windowsRuntimeStrings, exportedTypes
    # That's about 33 pairs = 264 bytes + 8 = 272 total header

    header_size_candidates = [0x110, 0x108, 0x100, 0x118, 0x120]

    for hs in header_size_candidates:
        # stringLiteralOffset = hs
        expected_8_11 = struct.pack("<I", hs)
        key_8_11 = [data[8+i] ^ expected_8_11[i] for i in range(4)]
        full_12 = key_so_far + key_8_11
        print(f"\n  header_size=0x{hs:X}: key[8..11] = {[f'0x{k:02X}' for k in key_8_11]}")
        print(f"    full key[0..11] = {[f'0x{k:02X}' for k in full_12]}")

        # Check for arithmetic progression or pattern
        diffs = [(full_12[i+1] - full_12[i]) & 0xFF for i in range(11)]
        print(f"    Deltas: {[f'0x{d:02X}' for d in diffs]}")

        # Check if delta of deltas is constant (quadratic)
        dd = [(diffs[i+1] - diffs[i]) & 0xFF for i in range(10)]
        print(f"    Delta-deltas: {[f'0x{d:02X}' for d in dd]}")

    # =========================================================================
    # NEW APPROACH: What if only first 4 bytes (magic) are encrypted differently?
    # Or what if the entire file uses a different XOR scheme?
    # Let's look at raw encrypted data patterns
    # =========================================================================

    print("\n\n" + "="*70)
    print("RAW DATA ANALYSIS")
    print("="*70)

    # Check if encrypted data has repeating patterns
    print("\n  Encrypted data in 4-byte groups (LE u32):")
    for i in range(0, 64, 4):
        val = struct.unpack_from("<I", data, i)[0]
        print(f"    [{i:3d}] 0x{val:08X} ({val:>12d})  bytes: {data[i:i+4].hex(' ')}")

    # Check for 16-byte period in encrypted data
    print("\n  XOR of 16-byte offset blocks with first block:")
    block0 = data[:16]
    for blk in range(1, 4):
        xored = bytes(data[blk*16+i] ^ block0[i] for i in range(16))
        print(f"    Block {blk} XOR Block 0: {xored.hex(' ')}")

    # =========================================================================
    # What if the decryption uses the FILE SIZE as part of the key?
    # key[i] = (some_func(i, file_size)) & 0xFF
    # =========================================================================
    print("\n\n" + "="*70)
    print("FILE-SIZE-BASED KEY ATTEMPTS")
    print("="*70)

    fs = FILE_SIZE
    print(f"  File size = {fs} = 0x{fs:08X}")
    fs_bytes = struct.pack("<I", fs)
    print(f"  File size bytes (LE): {[f'0x{b:02X}' for b in fs_bytes]}")

    # Try key[i] = (i + fs_byte[i%4]) & 0xFF
    # Try key[i] = (fs_byte[i%4] - i) & 0xFF
    # Try key[i] = fs_byte[i%4] ^ i

    for desc, kf in [
        ("fs_bytes[i%4] + i", lambda i: (fs_bytes[i%4] + i) & 0xFF),
        ("fs_bytes[i%4] - i", lambda i: (fs_bytes[i%4] - i) & 0xFF),
        ("fs_bytes[i%4] ^ i", lambda i: fs_bytes[i%4] ^ i),
        ("(fs >> (8*(i%4))) + i", lambda i: ((fs >> (8*(i%4))) & 0xFF) + i),
    ]:
        k0_3 = [kf(i) for i in range(4)]
        if k0_3 == KNOWN_KEY:
            print(f"  MATCH: {desc}")
            dec = bytes(data[i] ^ kf(i) for i in range(32))
            print(f"    Decrypted: {dec[:32].hex(' ')}")

    # =========================================================================
    # PURE DERIVATION: We know key[0..3]. Let's just try to figure out what
    # generates 0x83, 0x67, 0xAF, 0xEC as a sequence.
    # 0x83 = 131, 0x67 = 103, 0xAF = 175, 0xEC = 236
    # Diffs: -28, +72, +61  (or 228, 72, 61 unsigned)
    # These don't form an obvious pattern.
    #
    # But wait - what if the key bytes are from a lookup table in the binary?
    # The function at 0xA88252 extracts ~18 seed bytes from a structure.
    # Those 18 bytes could BE the key (repeated or combined somehow).
    # =========================================================================

    print("\n\n" + "="*70)
    print("KEY BYTE ANALYSIS")
    print("="*70)
    print(f"  key[0] = 0x83 = 131 = 0b10000011")
    print(f"  key[1] = 0x67 = 103 = 0b01100111")
    print(f"  key[2] = 0xAF = 175 = 0b10101111")
    print(f"  key[3] = 0xEC = 236 = 0b11101100")
    print(f"  Sum = {0x83+0x67+0xAF+0xEC} = 0x{(0x83+0x67+0xAF+0xEC):X}")
    print(f"  XOR all = 0x{0x83^0x67^0xAF^0xEC:02X}")

    # Reverse each byte
    rev = [int(f'{b:08b}'[::-1], 2) for b in KNOWN_KEY]
    print(f"  Bit-reversed: {[f'0x{r:02X}' for r in rev]}")

    # NOT each
    notk = [(~b) & 0xFF for b in KNOWN_KEY]
    print(f"  NOT: {[f'0x{n:02X}' for n in notk]}")

    # ROL/ROR
    for rot in range(1, 8):
        rotated = [((b << rot) | (b >> (8-rot))) & 0xFF for b in KNOWN_KEY]
        print(f"  ROL {rot}: {[f'0x{r:02X}' for r in rotated]}")

    # =========================================================================
    # CRITICAL: Test what happens if we XOR encrypted[4..7] with common version values
    # AND check if the resulting "key" bytes relate to position
    # =========================================================================
    print("\n\n" + "="*70)
    print("TRYING ALL PLAUSIBLE VERSIONS & CHECKING KEY GENERATION PATTERN")
    print("="*70)

    enc = data  # encrypted bytes

    for version in range(20, 35):
        ver_bytes = struct.pack("<I", version)
        k = list(KNOWN_KEY) + [enc[4+i] ^ ver_bytes[i] for i in range(4)]

        # Check: is there a simple formula key[i] = f(i) that produces these 8 values?
        # Try: key[i] = (A * i + B) mod 256
        # From k[0]=B=0x83, k[1]=A+B=0x67 => A=0x67-0x83=0xE4
        # Check: k[2] should = 2*0xE4+0x83 = 0x1C8+0x83=0x24B => 0x4B. Actual=0xAF. No.

        # Try: key[i] = table[i] where table is derived from some seed
        # Not useful without more info

        # Try: key[i] = (seed - i * step) mod 256
        # k[0]=seed=0x83, k[1]=seed-step => step=0x83-0x67=0x1C
        # k[2] should = 0x83-2*0x1C = 0x83-0x38 = 0x4B. Actual=0xAF. No.

        # Try: key[i] = seed ^ (i * mult)
        # k[0] = seed^0 = seed = 0x83
        # k[1] = 0x83 ^ mult = 0x67 => mult = 0xE4
        # k[2] = 0x83 ^ (2*0xE4 & 0xFF) = 0x83 ^ 0xC8 = 0x4B. Actual=0xAF. No.

        # Print just for reference
        if version in [24, 27, 29, 31]:
            print(f"  v{version}: key[0..7] = {[f'{x:02X}' for x in k]}")

    # =========================================================================
    # INSIGHT: maybe the key is NOT algorithmic but is a fixed table stored in
    # the binary. The function extracts 18 bytes. If the key table is 18 bytes,
    # it repeats every 18 bytes. Let's test with known first 4 bytes and try
    # to determine if 18-byte repetition produces valid structure.
    # =========================================================================
    print("\n\n" + "="*70)
    print("TESTING 18-BYTE KEY TABLE HYPOTHESIS")
    print("="*70)

    # If key repeats every 18 bytes and we know bytes 0-3:
    # Encrypted positions 18, 36, 54... should decrypt with same key[0..3]
    # Let's check if those positions produce ASCII or structure

    # Decrypt positions 18..21 with key[0..3]
    for base in [18, 36, 54, 72]:
        dec_chunk = bytes(enc[base+i] ^ KNOWN_KEY[i] for i in range(4))
        val = struct.unpack_from("<I", dec_chunk, 0)[0]
        print(f"  Pos {base:3d} decrypted with key[0..3]: {dec_chunk.hex(' ')} = 0x{val:08X} ({val})")

    # =========================================================================
    # ANOTHER APPROACH: Standard il2cpp metadata has very predictable patterns
    # at certain offsets. For example, version 29 has header ~272 bytes, then
    # string data which typically starts with lots of null-terminated ASCII.
    # The section offsets/sizes form pairs where consecutive offsets satisfy:
    #   next_offset = prev_offset + prev_size (sections are packed)
    #
    # This means: if offset_n + size_n = offset_{n+1}
    # We can use this constraint to derive more key bytes!
    #
    # For now, let's try decrypting more of the header assuming the VERSION
    # field tells us the correct interpretation.
    #
    # LAST RESORT: brute-force a short key table.
    # If the key is 4, 8, 12, or 16 bytes, try all possibilities for the
    # unknown bytes that produce a valid metadata header structure.
    # =========================================================================

    print("\n\n" + "="*70)
    print("BRUTE-FORCE 8-BYTE KEY (known 4 + brute 4)")
    print("="*70)
    print("  Testing key[4..7] values that give version < 35...")

    # key[4] ^ enc[4] = version_byte_0, must be < 35 for version < 35
    # key[5] ^ enc[5] = version_byte_1, must be 0 for version < 256
    # key[6] ^ enc[6] = version_byte_2, must be 0
    # key[7] ^ enc[7] = version_byte_3, must be 0

    # So: key[5] = enc[5], key[6] = enc[6], key[7] = enc[7]
    # And key[4] = enc[4] ^ version

    k5 = enc[5] ^ 0x00  # = enc[5]
    k6 = enc[6] ^ 0x00  # = enc[6]
    k7 = enc[7] ^ 0x00  # = enc[7]
    print(f"  For version < 256: key[5]=0x{k5:02X}, key[6]=0x{k6:02X}, key[7]=0x{k7:02X}")

    for version in range(20, 35):
        k4 = enc[4] ^ version
        key8 = KNOWN_KEY + [k4, k5, k6, k7]

        # Now decrypt bytes 8-15 with this 8-byte repeating key
        dec_8_15 = bytes(enc[8+i] ^ key8[(8+i) % 8] for i in range(8))
        offset0 = struct.unpack_from("<I", dec_8_15, 0)[0]
        size0 = struct.unpack_from("<I", dec_8_15, 4)[0]

        # Check plausibility: first section offset should be 200-400, size < file_size
        if 100 < offset0 < 2000 and 0 < size0 < FILE_SIZE:
            print(f"\n  *** CANDIDATE v{version}: key8={[f'0x{k:02X}' for k in key8]}")
            print(f"      First section: offset=0x{offset0:X} ({offset0}), size={size0}")

            # Decrypt more with 8-byte repeating key
            dec32 = bytes(enc[i] ^ key8[i % 8] for i in range(64))
            print(f"      Decrypted 64 bytes:")
            for row in range(4):
                chunk = dec32[row*16:(row+1)*16]
                hex_str = ' '.join(f'{b:02X}' for b in chunk)
                print(f"        {row*16:04X}: {hex_str}")

            # Check section pairs
            print(f"      Section table:")
            for s in range(min(7, (64-8)//8)):
                off_s = struct.unpack_from("<I", dec32, 8 + s*8)[0]
                sz_s = struct.unpack_from("<I", dec32, 12 + s*8)[0]
                valid = "OK" if (0 < off_s < FILE_SIZE and sz_s < FILE_SIZE) else "BAD"
                print(f"        Section {s}: offset=0x{off_s:08X}, size=0x{sz_s:08X} ({sz_s:>10d}) [{valid}]")

    print("\n\nDone phase 2.")

if __name__ == "__main__":
    main()
