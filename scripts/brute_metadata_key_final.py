"""
FINAL Phase: Decrypt the metadata header.

CONFIRMED FINDINGS:
1. Header is 328 bytes (offset 0-327), encrypted with unknown per-byte key
2. Section data starts at offset 328, encrypted with: data[j] ^= (j + C) & 0xFF
   where C = 0x7B and j is byte offset from file position 328
3. Key bytes 0-3 = [0x83, 0x67, 0xAF, 0xEC] (from "sym-" magic)
4. Decrypted section data starting at offset 328+8=336 (with C=0x7B, j starting at 8)
   shows a string literal index table

From the pseudocode: the section decrypt constant comes from the DECRYPTED HEADER.
Specifically: data[j] ^= *(BYTE*)(header + 296) + j - 35
where the section starts at the file offset specified by the header.

IMPORTANT REALIZATION: The section encryption formula uses j as offset from the
SECTION START, not from the file start. And the "constant" is a byte from the
decrypted header.

The key is: section_data[j] ^= (header_byte + j - 35) & 0xFF
= (j + (header_byte - 35)) & 0xFF
= (j + C) & 0xFF where C = header_byte - 35

If section 1 starts at file offset 328 and C=0x7B:
  header_byte = C + 35 = 0x7B + 0x23 = 0x9E

But which header offset contains this byte? From pseudocode: offset 296 of decrypted header.
So: decrypted_header[296] = 0x9E
And: key[296] = encrypted[296] XOR 0x9E

Actually wait - let me re-check. The pattern from offset 336 works perfectly
(8 null bytes then data). Let me reconsider whether the section ACTUALLY
starts at offset 328 or 336.

From the pseudocode:
  v28 = *(int*)(header + 296);  // section size
  dest = alloc(v28);
  memcpy(dest, file_data + *(u32*)(header + 172) + 36, *(int*)(header + 296));
  // Then decrypt:
  for (j = 0; j < size; j++) dest[j] ^= *(BYTE*)(header + 296) + j - 35;

So the section STARTS at file_offset = *(u32*)(header+172) + 36
And the KEY is: data[j] ^= (low_byte_of(*(u32*)(header+296)) + j - 35) & 0xFF

The "+36" offset is interesting - let me check if 336 = some_header_field + 36.
If the field at header+172 stores value 300 (=0x12C), then 300+36=336.

This means the first section starts at file offset 336!
And the decrypted section data at offset 0 is [00 00 00 00 00 00 00 00 01...]
which is indeed the string literal table.

OK but I realize: this approach won't easily give us the FULL header key.
It only gives us constraints on specific header bytes.

Let me try a DIFFERENT APPROACH to get the header key:
The pseudocode shows the header decrypt is a KNOWN algorithm that only uses
position and constants. Since the constants in the CURRENT binary are different,
and we can't find them by searching... maybe I should look for the decrypt
function itself in the binary.

Actually - let me take an even simpler approach. Since we know the SECTION
encryption works, and we know the section data, we can VALIDATE any proposed
header decryption by checking if the resulting section offsets and sizes are
consistent with what we observe in the encrypted file.

Let me just try: what if the HEADER encryption uses THE SAME formula as the
section encryption? i.e., header[j] ^= (j + C_header) & 0xFF for some C_header?
"""

import struct

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
FILE_SIZE = 40_512_432

def read_at(path, offset, size):
    with open(path, "rb") as f:
        f.seek(offset)
        return f.read(size)

def main():
    data = read_at(METADATA_PATH, 0, 4096)

    print("="*70)
    print("FINAL: Try header decrypt with same formula as section decrypt")
    print("="*70)

    # Section formula: data[j] ^= (j + C) & 0xFF
    # If header uses same formula: header[i] ^= (i + C_h) & 0xFF
    # We know: plaintext[0:4] = "sym-" = [0x73, 0x79, 0x6D, 0x2D]
    # encrypted[0:4] = [0xF0, 0x1E, 0xC2, 0xC1]
    # key[i] = encrypted[i] XOR plaintext[i]
    # key[0] = 0x83 = (0 + C_h) & 0xFF => C_h = 0x83
    # key[1] = (1 + C_h) & 0xFF = 0x84 -- but we need 0x67! DOESN'T WORK.

    # So header uses a DIFFERENT formula than sections. Confirmed.

    # What if header key is: key[i] = (C_h - i) & 0xFF (DECREASING)?
    # key[0] = C_h = 0x83
    # key[1] = (0x83 - 1) = 0x82 -- need 0x67. NOPE.

    # What about: key[i] = (C_h - i*step) & 0xFF?
    # key[0] = C_h = 0x83
    # key[1] = 0x83 - step = 0x67 => step = 0x1C
    # key[2] = 0x83 - 2*0x1C = 0x83 - 0x38 = 0x4B -- need 0xAF. NOPE.

    # OK the header key is genuinely complex. Let me try a COMPLETELY different approach.
    # What if the encrypted header bytes 4-327 can be decoded by recognizing that:
    # - The header contains section (offset, size) pairs
    # - Section offsets increase monotonically
    # - Sizes are positive
    # - offset[n+1] = offset[n] + size[n] (PACKED sections)
    # - The LAST section ends at file_size = 40,512,432

    # From the section decrypt analysis:
    # - First section data starts at file offset 336
    # - Section 1 is "stringLiteral" (pairs of length+offset u32s)

    # BUT WAIT: there's a HUGE clue I missed. The autocorrelation at period 4
    # showed 191/512 LOW VALUES. That's 37% of bytes having XOR < 16 with the
    # byte 4 positions away. For random data this would be ~6% (16/256).
    # This strongly suggests a 4-byte KEY STRUCTURE in the header.

    # Let me look at enc[i] XOR enc[i+4] for the header bytes:
    print("\n[AUTOCORR] enc[i] XOR enc[i+4] for first 328 bytes:")
    xor_4 = [data[i] ^ data[i+4] for i in range(324)]
    # Count how many are < 16
    low = sum(1 for x in xor_4 if x < 16)
    print(f"  Low values (<16): {low}/324 = {low/324*100:.1f}%")
    print(f"  Zero values: {xor_4.count(0)}/324")

    # The 37% low values with period 4 means: for most positions,
    # plaintext[i] XOR plaintext[i+4] < 16 OR key[i] XOR key[i+4] < 16.
    #
    # In a metadata header with (offset, size) pairs as u32 LE:
    # consecutive pairs differ. NOT expected to be low.
    # So it must be the KEY that has nearby values when sampled at period 4.
    #
    # If key is: key[i] = f(i) where f varies slowly, then
    # key[i] XOR key[i+4] would be small if f changes slowly over 4 bytes.
    #
    # FOR EXAMPLE: key[i] = (base + i * small_step) & 0xFF with step~1-3
    # Then key[i] XOR key[i+4] = (base+i*step) XOR (base+(i+4)*step)
    # = complicated XOR. For step=1: values close together XOR to small number
    # if they don't cross a bit boundary (e.g., 0x83 XOR 0x87 = 0x04).

    # ACTUALLY: let me reconsider. The high autocorrelation at period 4 for the
    # WHOLE first 512 bytes (including section data) makes perfect sense because:
    # - Section data is (length u32, offset u32) pairs
    # - Many lengths are small (< 16), so bytes 0,4,8,12,... of the section
    #   data are small values
    # - These are XORed with a sequential key (j + 0x7B) & 0xFF
    # - The XOR of two values 4 apart in a sequential key differs by 4
    # - But the section data at those positions is ALSO small...
    # This is getting complicated. Let me focus differently.

    # DEFINITIVE APPROACH: Decode the SECTION data completely to understand
    # the metadata structure, then work backwards to the header.

    # The section at offset 328 (with decrypt j+0x7B from byte 328) gives us
    # a string literal index table. Each entry is (u32 length, u32 data_offset).
    # From phase 9 output:
    #   First 8 bytes: garbage [8F 99 01 07 A7 50 57 F7] - this is NOT section data
    #   From byte 8 onward: clean table data

    # WAIT - I just realized something. The "garbage" 8 bytes at offset 328-335
    # might be the HEADER continuing beyond 328 bytes!
    # The old pseudocode says 328 (0x148) but maybe the current version has
    # a slightly different header size.

    # Let's try: what if the header is 336 bytes (not 328)?
    # Then section decryption starts at j=0 from file offset 336.
    # With C=0x83: section_key[j] = (j + 0x83) & 0xFF
    # This perfectly explains why offset 336 starts with [83, 84, 85...]
    # when plaintext is [00, 00, 00...]!

    # So: HEADER = 336 bytes. Section 1 starts at offset 336.
    # Header key is 336 bytes long. We know key[0..3] = [83, 67, AF, EC].

    # For the section: constant = header_byte - 35
    # C = 0x83, so header_byte = 0x83 + 0x23 = 0xA6

    # The "header_byte" is read from a SPECIFIC OFFSET in the decrypted header.
    # From pseudocode: offset 296 for section 1.
    # decrypted_header[296] = 0xA6
    # encrypted_header[296] = data[296]
    # header_key[296] = data[296] XOR 0xA6

    enc_296 = data[296]
    key_296 = enc_296 ^ 0xA6
    print(f"\n  encrypted[296] = 0x{enc_296:02X}")
    print(f"  decrypted[296] should be 0xA6")
    print(f"  header_key[296] = 0x{key_296:02X}")

    # Hmm wait. From pseudocode the section decrypt was:
    #   for (j=0; j < size; j++) data[j] ^= *(BYTE*)(header + 296) + j - 35
    # *(BYTE*)(header + 296) reads ONE BYTE at header offset 296.
    # header+296 is part of a u32 field (probably a size field).
    # As a 32-bit size stored at offset 296-299, the low byte is at offset 296.

    # *(int*)(header + 296) is the SECTION SIZE (used for allocation).
    # So the decrypt constant is the LOW BYTE of the section size!
    # section_size & 0xFF + j - 35

    # The section at file offset 336 is the stringLiteral section.
    # Its entries are (u32 length, u32 offset) pairs.
    # From the decrypted data, let me count how many entries there are.

    section_1_data = read_at(METADATA_PATH, 336, 8192)
    dec_section_1 = bytes(section_1_data[j] ^ ((j + 0x83) & 0xFF) for j in range(len(section_1_data)))

    # Count pairs until we hit implausible values
    print("\n\n  StringLiteral section (offset, length pairs):")
    pair_count = 0
    for idx in range(0, 8192, 8):
        length = struct.unpack_from("<I", dec_section_1, idx)[0]
        offset = struct.unpack_from("<I", dec_section_1, idx + 4)[0]
        if length > 100000 or offset > 10000000:
            # Likely hit section boundary
            print(f"\n  Section boundary detected at section-relative offset {idx} (file offset {336+idx})")
            print(f"  Last valid entry: pair #{pair_count}")
            break
        pair_count += 1
        if pair_count <= 10 or pair_count % 100 == 0:
            print(f"    [{pair_count:5d}] length={length:5d}, offset={offset:8d}")

    # The section SIZE = pair_count * 8 bytes
    section_1_size = pair_count * 8
    print(f"\n  Estimated section 1 size: {section_1_size} bytes")
    print(f"  Section 1 size low byte: 0x{section_1_size & 0xFF:02X}")

    # If the pseudocode says the constant comes from the LOW BYTE of the size at header+296:
    # Then: section_size & 0xFF = C + 35 = 0x83 + 35 = 0xA6 = 166
    # section_size mod 256 = 166
    # section_size = N * 256 + 166 for some N
    # If section has ~1000 entries * 8 bytes = ~8000, that's 8000 mod 256 = 64. Doesn't match 166.
    # Hmm.

    # Wait - let me re-check. From the pseudocode for section 1 (first one loaded):
    # v28 = *(int*)(v4 + 296);  // this is the SIZE to allocate
    # sub_180AD4B60(v29, file + *(u32*)(header+172) + 36, *(int*)(header+296));  // memcpy
    # for (i=0; i<size; i++) data[i] ^= *(BYTE*)(v30 + 296) + i - 35;
    #
    # *(BYTE*)(v30 + 296) reads BYTE at offset 296 from the base of the 328-byte structure.
    # In the DECRYPTED header, byte at position 296 is part of a u32 field.
    # Let's figure out which u32 field byte 296 falls in.
    #
    # Header layout (from pseudocode field accesses):
    # header+0: (first u32, likely magic-related)
    # header+172: offset into file for section 1 data
    # header+296: size of section 1 data
    # header+168: size of section 2
    # header+76: size of section 3
    # header+232: size of section 4
    # etc.
    #
    # *(BYTE*)(header + 296) is the LOWEST BYTE of the u32 at offset 296 (LE).
    # This byte = section_1_size & 0xFF.
    #
    # From our analysis: decrypt constant = (section_1_size & 0xFF) + j - 35
    # At j=0 the key is: (section_1_size & 0xFF) - 35
    # For offset 336 data to start with key 0x83:
    #   (section_1_size & 0xFF) - 35 = 0x83
    #   section_1_size & 0xFF = 0x83 + 0x23 = 0xA6 = 166

    # So section_1_size mod 256 = 166.
    # If we have ~1000 entries of 8 bytes = 8000: 8000 mod 256 = 64. Doesn't match.
    # If we have ~897 entries: 897*8 = 7176, 7176 mod 256 = 8. No.
    # Need size where size mod 256 = 166. Smallest examples: 166, 422, 678, ...

    # Wait - the "size" field might not be the number of entries * 8.
    # It's the RAW BYTE SIZE of the section data as stored.
    # Let me just scan for the section boundary more carefully.

    # Read larger chunk
    bigger = read_at(METADATA_PATH, 336, 1024*1024)  # 1MB
    dec_bigger = bytes(bigger[j] ^ ((j + 0x83) & 0xFF) for j in range(len(bigger)))

    # Find where valid string literal pairs end
    last_valid_offset = 0
    for idx in range(0, len(dec_bigger) - 8, 8):
        length = struct.unpack_from("<I", dec_bigger, idx)[0]
        data_offset = struct.unpack_from("<I", dec_bigger, idx + 4)[0]
        if length < 100000 and data_offset < 50000000:
            last_valid_offset = idx + 8
            pair_count = (idx + 8) // 8
        else:
            break

    print(f"\n  FINAL section 1 size: {last_valid_offset} bytes ({pair_count} entries)")
    print(f"  Section 1 size mod 256 = {last_valid_offset % 256}")
    print(f"  Low byte = 0x{last_valid_offset & 0xFF:02X}")

    # Check if low byte matches our expected 0xA6
    if (last_valid_offset & 0xFF) == 0xA6:
        print(f"  *** MATCHES expected 0xA6! ***")
    else:
        print(f"  Does NOT match 0xA6 (got 0x{last_valid_offset & 0xFF:02X})")
        # Try nearby sizes
        for delta in range(-100, 100):
            test_size = last_valid_offset + delta
            if (test_size & 0xFF) == 0xA6 and test_size > 0:
                print(f"  Nearby match at size={test_size} (delta={delta})")
                break

    print("\n\nDone final phase.")

if __name__ == "__main__":
    main()
