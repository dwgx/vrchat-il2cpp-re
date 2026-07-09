"""
Phase 4: Decode the ACTUAL decrypt algorithm from the pseudocode.

The decrypt loop in sub_180A7E880 processes the metadata header (328 bytes = 0x148).
It uses SIMD operations with constants:
  xmmword_18B6788F0 = [0,0,0,0,0,0,0,0, 1,0,0,0,0,0,0,0]  (i.e., qword pair [0, 1])
  xmmword_18B678A70 = [FF,00,00,00,00,00,00,00, FF,00,00,00,00,00,00,00] (mask low byte of each qword)
  xmmword_18B678BC0 = [34,34,34,34,...] (constant 0x34 in all 16 bytes)
  xmmword_18B679930 = [4B,4B,4B,4B,...] (constant 0x4B in all 16 bytes)

The decrypt loop (simplified):
  v12 = -4 - v4  (v4 = base of allocated buffer)
  v13 starts at (v4 + 4), iterating as u16 pointer, 4 elements per iteration
  position = (v13_addr + v12) = relative offset from base

  For each position p (byte offset from start of buffer):
    1. unpacklo_epi64(p, p) -> [p, p] as two qwords
    2. add_epi64([p,p], [0, 1]) -> [p, p+1]
    3. and_ps([p, p+1], [0xFF, 0xFF]) -> [p & 0xFF, (p+1) & 0xFF]
    4. packus_epi16 x3 -> packs down to bytes
    5. sub_epi8(packed, 0x34) -> (val - 0x34)
    6. xor with original data

Wait - let me re-read more carefully. The pointer v13 is u16*, and the loop
processes 4 u16 values per iteration (8 bytes). The position is the BYTE OFFSET.

Actually looking again: v13 is a u16 pointer (unsigned __int16 *).
v12 = -4 - v4. Position = (u64)v13 + v12 = address of v13 - 4 - v4 = offset from (v4+4)-4 = v4.
So position is the byte offset from the start of the buffer.

The key computation for each 2-byte position p:
  1. Make qword pair [p, p]
  2. Add [0, 1] -> [p, p+1]
  3. AND with [0xFF, 0xFF] -> [p & 0xFF, (p+1) & 0xFF]
  4. packus_epi16 twice, then once more -> collapses to single bytes
  5. sub_epi8(result, 0x34) -> subtract 0x34 from each byte
  6. XOR with the encrypted u16 at that position

So the key for byte at offset p is: ((p & 0xFF) - 0x34) & 0xFF

BUT WAIT: The xmmword_18B679930 (0x4B) is used EARLIER to generate the FILENAME,
not the decrypt key. Let me separate the two uses.

The filename generation at the top of sub_180A7E880:
  si128 = load(xmmword_18B679930)  // [0x4B x 16]
  v60[0] = cvtsi128_si32(xor(sub_epi8(cvtsi32_si128(0x03020100), si128), cvtsi32_si128(0xDAD8DAD2)))
  etc.

That's generating the filename "global-metadata.dat" by:
  byte[i] = ((i - 0x4B) & 0xFF) ^ constant_byte[i]

The ACTUAL DECRYPTION is the loop with v14..v27, using:
  xmmword_18B6788F0 = [0, 1] (add to position)
  xmmword_18B678A70 = [0xFF, 0xFF] (mask)
  xmmword_18B678BC0 = [0x34 x 16] (subtract constant)

KEY FORMULA: key[i] = (i - 0x34) & 0xFF

But we KNOW this doesn't produce [0x83, 0x67, 0xAF, 0xEC] for bytes 0-3!
  (0 - 0x34) & 0xFF = 0xCC  (not 0x83!)
  (1 - 0x34) & 0xFF = 0xCD  (not 0x67!)

THEREFORE: either the positions start at a non-zero offset, OR
the function processes a COPY of the data starting at some offset.

Looking at the code: v13 starts at (v4 + 4) -- that's offset 4 of the buffer.
v12 = -4 - v4. So position for v13 = (v4+4) + (-4-v4) = 0.
First iteration: position 0, 2, 4, 6 (since v13 is u16*, += 4 means +8 bytes)

Hmm, but the loop condition is: (v13 + v12) < 0x148 (= 328)
And v13 starts at v4+4 with v12 = -4-v4, so initial position = 0.
Loop processes positions 0 to 327 (0x147), covering 328 bytes.

So key[0] = (0 - 0x34) & 0xFF = 0xCC != 0x83!

UNLESS: the 328-byte buffer is not the START of the metadata file!
The code copies 328 bytes from the raw file data, THEN decrypts.
The copy is: memcpy(v4, qword_18C8F4E18, 328)
where qword_18C8F4E18 is the file mapping pointer.

So the decrypt IS applied to bytes 0-327 of the file, with key[i] = (i - 0x34) & 0xFF.
Since this doesn't match our known key bytes, the algorithm must have changed.

Let me look at what key WOULD produce [0x83, 0x67, 0xAF, 0xEC]:
  key[0] = 0x83 -> if formula is (offset - C): offset-C = 0x83, if offset=0: C = -0x83 = 0x7D (mod 256)
  key[1] = 0x67 -> 1 - C = 0x67 mod 256: C = 1 - 0x67 = -0x66 = 0x9A ... different!

So it's NOT (i - constant). It must be something else entirely.

Let me re-examine: maybe the new build uses a DIFFERENT decrypt function.
The constants 0x4B and 0x34 might be from an OLDER version analyzed previously.
The current build may use different constants or a different algorithm entirely.

Let me just directly test various algorithms against the known file.
"""

import struct

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
KNOWN_KEY = [0x83, 0x67, 0xAF, 0xEC]
FILE_SIZE = 40_512_432

def read_header(path, size=1024):
    with open(path, "rb") as f:
        return f.read(size)

def main():
    data = read_header(METADATA_PATH)

    print("="*70)
    print("PHASE 4: Decode from pseudocode + verify against actual file")
    print("="*70)

    # First, let's compute what the OLD algorithm (i - 0x34) & 0xFF gives:
    print("\nOLD ALGORITHM: key[i] = (i - 0x34) & 0xFF")
    old_key = [(i - 0x34) & 0xFF for i in range(4)]
    print(f"  key[0..3] = {[f'0x{k:02X}' for k in old_key]}")
    print(f"  Expected:   {[f'0x{k:02X}' for k in KNOWN_KEY]}")
    print(f"  MISMATCH - algorithm has changed")

    # Let's compute filename from the pseudocode to verify we understand the SIMD ops
    print("\n\nFILENAME DERIVATION (to verify SIMD understanding):")
    # si128 = [0x4B x 16]
    # v60[0] = cvtsi32( xor( sub_epi8(0x03020100, 0x4B4B4B4B), 0xDAD8DAD2 ) )
    # sub_epi8: byte-wise subtraction
    # 0x03020100 bytes: [0x00, 0x01, 0x02, 0x03]
    # sub 0x4B:         [0x00-0x4B, 0x01-0x4B, 0x02-0x4B, 0x03-0x4B] mod 256
    #                 = [0xB5, 0xB6, 0xB7, 0xB8]
    # XOR with 0xDAD8DAD2 bytes: [0xD2, 0xDA, 0xD8, 0xDA]
    # Result: [0xB5^0xD2, 0xB6^0xDA, 0xB7^0xD8, 0xB8^0xDA]
    #       = [0x67,      0x6C,      0x6F,      0x62]
    #       = ['g',       'l',       'o',       'b']

    constants = [0xDAD8DAD2, 0xD196D6D8, 0xA4DECAD8, 0xEAA2B6A0, 0xC8B3A7A1]
    filename_bytes = []
    for ci, const in enumerate(constants):
        base_i = ci * 4
        const_bytes = struct.pack("<I", const)
        for j in range(4):
            pos = base_i + j
            sub_val = (pos - 0x4B) & 0xFF
            xor_val = sub_val ^ const_bytes[j]
            filename_bytes.append(xor_val)

    filename = bytes(filename_bytes)
    print(f"  Decoded filename: {filename}")
    print(f"  As string: '{filename.decode('ascii', errors='replace')}'")

    # Good! That gives us "global-metadata.dat" confirming our SIMD interpretation.

    # Now let's carefully trace the DECRYPT loop.
    # The key question: in the NEW build, what constant is used instead of 0x34?
    #
    # We can REVERSE it: if key[0] = (0 - C) & 0xFF = 0x83, then C = -0x83 = 0x7D
    # But key[1] = (1 - C) & 0xFF should be 0x84 (with C=0x7D), not 0x67!
    #
    # So the formula is NOT (i - C) for any single constant C.
    # The differences in key bytes: 0x83, 0x67, 0xAF, 0xEC
    # Diffs: 0x67-0x83 = -28 = 0xE4
    #         0xAF-0x67 = 72 = 0x48
    #         0xEC-0xAF = 61 = 0x3D
    # These are NOT constant, so it's not a linear formula.

    # WAIT - let me re-read the decrypt loop more carefully.
    # The position variable isn't just 'i'. Let me trace through:
    #
    # v13 is unsigned __int16 * starting at v4+4
    # v12 = -4 - v4
    # First iteration:
    #   v13 = v4+4 (pointing to byte offset 4 of buffer)
    #   position for first element = (unsigned __int64)v13 + v12 = v4+4 + (-4-v4) = 0
    #   But wait - it processes *(v13-2) first! That's at v4+4-4 = v4+0 = offset 0.
    #
    # So for *(v13-2) at byte offset 0:
    #   p = (u64)(v13-2) + v12 = (v4+4-4) + (-4-v4) = -4 = 0xFFFF...FFFC
    #   p & 0xFF = 0xFC
    #   key_byte = (0xFC - 0x34) & 0xFF = 0xC8  -- not 0x83!
    #
    # Hmm wait, let me re-read. The actual expression is:
    #   _mm_unpacklo_epi64((__m128i)((unsigned __int64)v13 + v12), ...)
    # The position is computed as (address of v13) + v12.
    # v13 starts at v4+4, v12 = -4-v4
    # So position = (v4+4) + (-4-v4) = 0 for the initial v13.
    #
    # But the code uses *(v13-2) for the FIRST write:
    #   For the value at *(v13-2), position argument to the key computation is:
    #   the same v13 + v12 = 0 (first iteration).
    #
    # Hmm, I see: the position used for key generation is based on the POINTER v13,
    # not on where it writes. Each iteration v13 advances by 4 (u16 units = 8 bytes),
    # and processes offsets *(v13-2), *(v13-1), *v13, *(v13+1).
    #
    # Let me trace one iteration:
    #   position_base = (u64)v13 + v12 = relative byte offset of v13 from buffer start
    #   For v13 = v4+4: position_base = 0
    #   Key for *(v13-2): uses position_base directly
    #     But the SIMD adds [0, 1]: [pos, pos+1]
    #     AND 0xFF: [pos & 0xFF, (pos+1) & 0xFF]
    #     Pack to bytes... then subtract 0x34
    #     XOR with the 2 bytes at *(v13-2) = bytes 0,1 of buffer
    #
    #   So key for bytes 0,1: pos=0 -> [(0-0x34)&0xFF, (1-0x34)&0xFF] = [0xCC, 0xCD]
    #
    # That gives 0xCC, 0xCD which is the OLD algorithm. But we KNOW the actual
    # key for bytes 0,1 is [0x83, 0x67]. This confirms the current binary uses
    # DIFFERENT constants or a different code path.

    # The pseudocode I have must be from an OLDER version of the binary.
    # Let me instead focus on DERIVING the key empirically.

    print("\n\n" + "="*70)
    print("EMPIRICAL KEY DERIVATION")
    print("="*70)
    print("\nSince the pseudocode is from an older version, let's derive the key")
    print("purely from the encrypted file + known structure.\n")

    # Strategy: il2cpp metadata v29 header is exactly 272 bytes (0x110):
    # 4 (magic) + 4 (version) + 33 * 8 (section offset+size pairs) = 272
    # All section offsets must be > 272 and < file_size
    # All section sizes must be > 0 and < file_size
    # Consecutive sections are PACKED: offset[n+1] = offset[n] + size[n]
    #
    # If we assume version=29:
    # plaintext[4:8] = [29, 0, 0, 0] = [0x1D, 0x00, 0x00, 0x00]
    # key[4:8] = enc[4:8] XOR [0x1D, 0x00, 0x00, 0x00] = [0xCC^0x1D, 0xB6, 0xA8, 0xBD]
    #          = [0xD1, 0xB6, 0xA8, 0xBD]

    # With version=29, what's the ACTUAL il2cpp v29 section layout?
    # Unity's il2cpp metadata v29 header (from source):
    # After magic+version, the pairs are:
    # stringLiteral, stringLiteralData, string, events, properties, methods,
    # parameterDefaultValues, fieldDefaultValues, fieldAndParameterDefaultValueData,
    # fieldMarshaledSizes, parameters, fields, genericParameters,
    # genericParameterConstraints, genericContainers, nestedTypes, interfaces,
    # vtableMethods, interfaceOffsets, typeDefinitions, images, assemblies,
    # fieldRefs, referencedAssemblies, attributeInfo (dataOffset), attributeInfo (dataSize/types),
    # unresolvedVirtualCallParameterTypes, unresolvedVirtualCallParameterRanges,
    # windowsRuntimeTypeNames, windowsRuntimeStrings, exportedTypes,
    # ... depends on exact version

    # The KEY constraint: if sections are packed,
    # offset[0] = header_size (probably 272 for v29)
    # Then we can derive many key bytes if we know the first section offset.

    # For a 40MB metadata file with v29, the first section offset is likely
    # between 256 and 512. Let's try 272 (0x110) which is the standard.

    # But first: we have key[0:4] and key[4:8] (assuming version=29).
    # Let's see if there's a pattern by trying all possible first-section-offsets
    # and checking if the resulting key bytes follow a formula.

    # key[0:8] = [0x83, 0x67, 0xAF, 0xEC, 0xD1, 0xB6, 0xA8, 0xBD]

    # Try: what if the magic is NOT "sym-" but "\xAF\x1B\xB1\xFA" (standard il2cpp)?
    print("\nWait - what if the magic is standard il2cpp 0xFAB11BAF?")
    standard_magic = struct.pack("<I", 0xFAB11BAF)
    alt_key_0_3 = [data[i] ^ standard_magic[i] for i in range(4)]
    print(f"  If magic=0xFAB11BAF: key[0:4] = {[f'0x{k:02X}' for k in alt_key_0_3]}")
    # Check if this matches old formula (i - 0x34):
    old_expected = [(i - 0x34) & 0xFF for i in range(4)]
    print(f"  Old formula (i-0x34): {[f'0x{k:02X}' for k in old_expected]}")
    if alt_key_0_3 == old_expected:
        print("  *** MATCH! The magic might be standard 0xFAB11BAF with old key! ***")
    else:
        print("  No match with old formula.")

    # What about magic = "sym\x00" or other variants?
    # Let's be more creative. What if the file starts with a CUSTOM header
    # where the magic is something else?

    # Actually, let me reconsider. The user stated:
    # "Expected plaintext first 4 bytes: 73 79 6D 2D (= "sym-" = 0x2D6D7973 LE)"
    # This is stated as a KNOWN FACT. So "sym-" is correct.

    # Given that the pseudocode shows (i - 0x34) for the OLD version,
    # and we need to find the NEW key, let's hypothesize:
    # new_key[i] = (i - NEW_CONST) & 0xFF ... but this doesn't work (proven above)
    # new_key[i] = (A*i + B) & 0xFF ... linear doesn't work (no solution found in phase 1)
    # new_key[i] = (i*i*A + i*B + C) ... quadratic doesn't work

    # What if the key involves the FILE SIZE or a hash?
    # Or what if it's not byte-position-based at all, but uses a PRNG seeded
    # from the header structure itself?

    # Let me check: what if the key is derived from the 20-byte "v60" buffer
    # (the filename bytes) in a different way?

    # Actually, I just realized: the pseudocode shows v60 is the FILENAME
    # "global-metadata.dat" (20 bytes). This is passed to sub_1809E7EE0 which
    # OPENS the file. The file content is then decrypted.

    # The decrypt uses the buffer at v4 (qword_18C8F4E38), 328 bytes from the file.
    #
    # Wait - 328 bytes is the HEADER ONLY. The rest of the file sections are
    # decrypted separately with DIFFERENT XOR patterns:
    #   section_data[j] ^= *(_BYTE *)(v39 + 76) + j - 35
    #   This means: section_data[j] ^= (section_size_byte + j - 35) & 0xFF
    #
    # So the header decrypt is SEPARATE from section decrypts!
    # The header uses the SIMD loop with (position - 0x34).
    # The sections each use (constant + j - 35) where constant is a byte from the header.
    #
    # BUT AGAIN: the header decrypt formula (i-0x34) doesn't match our known key.
    # So the binary MUST have been updated with new constants.

    # FINAL STRATEGY: Since we can't access the NEW binary's code directly,
    # let's try to find the key empirically using structural constraints.

    # We'll try the 4-byte repeating key and check if it gives VALID metadata
    # when we account for VRChat's CUSTOM metadata format.

    # VRChat uses "sym-" magic instead of standard 0xFAB11BAF.
    # Their metadata format might be ENTIRELY different from standard il2cpp!
    # Maybe after "sym-" there's no version field at all.

    print("\n\n" + "="*70)
    print("TESTING: 4-byte key with custom VRChat metadata interpretation")
    print("="*70)

    # Decrypt with 4-byte repeating key
    key4 = KNOWN_KEY
    dec = bytes(data[i] ^ key4[i % 4] for i in range(256))

    print("\nDecrypted first 256 bytes (4-byte repeating key):")
    for row in range(16):
        offset = row * 16
        hex_str = ' '.join(f'{dec[offset+i]:02X}' for i in range(16))
        asc = ''.join(chr(dec[offset+i]) if 32 <= dec[offset+i] < 127 else '.' for i in range(16))
        print(f"  {offset:04X}: {hex_str}  {asc}")

    # Look for patterns
    print("\n\nAs LE u32 values:")
    for i in range(0, 64, 4):
        val = struct.unpack_from("<I", dec, i)[0]
        print(f"  [{i:3d}] 0x{val:08X} = {val:>12d}")

    # Check if any values could be offsets into a 40MB file
    print("\n\nValues that could be valid offsets (< file_size):")
    for i in range(0, 256, 4):
        val = struct.unpack_from("<I", dec, i)[0]
        if val < FILE_SIZE and val > 0:
            print(f"  [{i:3d}] 0x{val:08X} = {val}")

    print("\n\nDone phase 4.")

if __name__ == "__main__":
    main()
