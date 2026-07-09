"""
Phase 9: BREAKTHROUGH - exploit the pattern at offset 328+

At offset 0x148 (328), the encrypted data transitions to a near-sequential
pattern: 83 84 85 86 87 88 89 8a 8a 8c 8d 8e 8f 90 91 92 ...

This is the SECTION DATA being encrypted with a simple (i-35+const) formula
as seen in the pseudocode! After the 328-byte header, each section is
independently encrypted with: data[j] ^= (constant + j - 35) & 0xFF

The near-sequential pattern suggests the underlying data is mostly ZEROS or
very low values. For metadata section data starting with null-terminated strings,
the beginning is often a null byte (the empty string "").

If the section data starts with zeros, then encrypted[i] = key_byte = (constant + i - 35) & 0xFF

So at offset 328: if plaintext is 0, then encrypted[0] = (constant + 0 - 35) & 0xFF
  encrypted at 328 = 0x83. So: (constant - 35) & 0xFF = 0x83
  constant - 0x23 = 0x83 => constant = 0xA6

But wait - the "constant" in the section decrypt is a BYTE read from the decrypted header.
It's: *(BYTE*)(header + some_offset) which is a size or offset byte.

Actually let me re-read the section decrypt patterns from pseudocode:
  Section 1: data[j] ^= *(BYTE*)(header + 296) + j - 35
  Section 2: data[j] ^= *(BYTE*)(header + 168) + j - 35
  Section 3: data[j] ^= j - *(BYTE*)(header + 76) + 35
  Section 4: data[j] ^= *(BYTE*)(header + 232) + j - 35
  Section 5: data[j] ^= *(BYTE*)(header + 132) + j - 35
  Section 6: data[j] ^= j - *(BYTE*)(header + 252) + 35
  Section 7: data[j] ^= j - *(BYTE*)(header + 308) + 35

Two patterns:
  Type A: data[j] ^= (constant + j - 35) & 0xFF = (j + constant - 35) & 0xFF
  Type B: data[j] ^= (j - constant + 35) & 0xFF = (j - constant + 35) & 0xFF

For Type A: if plaintext[j]=0, encrypted[j] = (j + C - 35) & 0xFF
  At j=0: encrypted = (C - 35) & 0xFF
  At j=1: encrypted = (C - 34) & 0xFF = (C - 35 + 1) & 0xFF
  So we'd see sequential bytes starting from (C-35)

For Type B: if plaintext[j]=0, encrypted[j] = (j - C + 35) & 0xFF
  At j=0: encrypted = (35 - C) & 0xFF
  At j=1: encrypted = (36 - C) & 0xFF
  Also sequential!

Looking at the data at offset 328:
  83 84 85 86 87 88 89 8a 8a 8c 8d 8e 8f 90 91 92 97 94 95 96 96 98 99 9a ...

This is mostly sequential with some glitches. The glitches occur at positions
where the plaintext is NOT zero (some ASCII characters in the string section).

This confirms: the SECTION encryption is as described, and the first section
data starts right after the 328-byte header.

NOW: The key insight is that the 256-byte autocorrelation spike means
something repeats every 256 bytes. In the section encryption:
  key[j] = (j + C) & 0xFF (where C = constant - 35)
This has period 256! So the encrypted section data will show period-256
patterns in autocorrelation. This CONFIRMS the section decrypt formula.

CRITICAL: We can now DERIVE the plaintext of the first section by
subtracting the sequential pattern from the encrypted data at offset 328.
encrypted[328 + j] = plaintext_section[j] XOR ((j + C) & 0xFF)
where C makes encrypted[328] = 0x83 when plaintext[0] is determined.

Actually wait - there might be a null byte at position 0 of the string section
(empty string ""). If so:
  0x83 = (0 + C) & 0xFF => C = 0x83
  Then key[j] = (j + 0x83) & 0xFF

Let me verify: if first byte is null, encrypted[328+j] = (j + 0x83) & 0xFF
  j=0: 0x83 (actual: 0x83) CHECK
  j=1: 0x84 (actual: 0x84) CHECK
  j=2: 0x85 (actual: 0x85) CHECK
  j=3: 0x86 (actual: 0x86) CHECK
  j=4: 0x87 (actual: 0x87) CHECK
  j=5: 0x88 (actual: 0x88) CHECK
  j=6: 0x89 (actual: 0x89) CHECK
  j=7: 0x8A (actual: 0x8a) CHECK

IT MATCHES PERFECTLY! The section starts with null bytes (empty string).

But then at j=8 we have 0x8A instead of expected 0x8B.
  Actual 0x8A, expected if null: 0x8B. Diff = 1.
  So plaintext[8] = 0x8A XOR 0x8B = 0x01.
  Hmm, or maybe: plaintext[8] = actual XOR key = 0x8A XOR (8 + 0x83) = 0x8A XOR 0x8B = 0x01.

Wait, let me recheck. j=7: expected 0x8A (7+0x83=0x8A), actual=0x8A. MATCH.
j=8: expected 0x8B (8+0x83=0x8B), actual=0x8A. plaintext[8] = 0x8A ^ 0x8B = 0x01. Hmm.

But looking more carefully at the printout:
0x0148: f4 e5 7c 79 d8 d0 d6 75 83 84 85 86 87 88 89 8a
0x0150: 83 84 85 86 87 88 89 8a 8a 8c 8d 8e 8f 90 91 92

Offset 0x148 = 328. The first 8 bytes at 328 are: f4 e5 7c 79 d8 d0 d6 75
Then at 336 (328+8): 83 84 85 86 87 88 89 8a

So the sequential pattern starts at offset 336, NOT 328!
The first 8 bytes of the section (328-335) are something else (maybe a section header?).

OR: the section doesn't start at 328. Maybe the header is LARGER than 328.

Let me re-examine. From the pseudocode: the header decrypt loop runs for 0x148 (328) bytes.
But maybe there's additional unencrypted/differently-encrypted data between
the header and the first section.

Actually, looking at it: offset 328+8=336 is where the pattern starts.
So the first section data starts at offset 336? Or the section starts at 328
but has an 8-byte sub-header?

Let me decode the string section with the key (j + 0x83) starting from offset 336.
"""

import struct

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
FILE_SIZE = 40_512_432

def read_at(path, offset, size):
    with open(path, "rb") as f:
        f.seek(offset)
        return f.read(size)

def main():
    # Read the region around offset 328
    data = read_at(METADATA_PATH, 0, 2048)

    print("="*70)
    print("PHASE 9: Decode section data with detected key pattern")
    print("="*70)

    # The sequential pattern starts at offset 336 (0x150) with value 0x83
    # Actually let me re-examine byte by byte around 328:
    print("\nByte-by-byte at offset 328:")
    section_start = 328
    for j in range(32):
        actual = data[section_start + j]
        expected_type_a = (j + 0x83) & 0xFF  # if C = 0x83 and section starts at 328
        # But wait - re-read:
        # At offset 0x148 (328): f4 e5 7c 79 d8 d0 d6 75
        # At offset 0x150 (336): 83 84 85 86 87 88 89 8a
        # The sequential pattern with base 0x83 starts at offset 336, which is j=8 from 328.
        # So: encrypted[328+j] with key (j + C) should match.
        # At j=8: enc=0x83, key should be (8+C)&0xFF. If plaintext=0: 0x83 = 8+C => C=0x7B
        # At j=9: enc=0x84, key = 9+0x7B = 0x84. MATCH!
        expected_c7b = (j + 0x7B) & 0xFF
        plain_c7b = actual ^ expected_c7b
        print(f"  j={j:2d} off={section_start+j:4d}(0x{section_start+j:03X}): "
              f"enc=0x{actual:02X}, key(C=0x7B)=0x{expected_c7b:02X}, plain=0x{plain_c7b:02X} ({chr(plain_c7b) if 32<=plain_c7b<127 else '.'})")

    # Decode more of the section
    print("\n\nDecoded section data (assuming C=0x7B, starting at offset 328):")
    decoded_section = bytes(data[328 + j] ^ ((j + 0x7B) & 0xFF) for j in range(512))

    # Print as hex + ASCII
    for row in range(32):
        offset = row * 16
        chunk = decoded_section[offset:offset+16]
        hex_str = ' '.join(f'{b:02X}' for b in chunk)
        asc = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
        print(f"  {offset:04X}: {hex_str}  {asc}")

    # Now let's try C=0x83 starting from EXACTLY offset 336 (the pattern start)
    print("\n\nAlternative: Decode from offset 336 with C=0x83:")
    decoded_from_336 = bytes(data[336 + j] ^ ((j + 0x83) & 0xFF) for j in range(512))
    for row in range(16):
        offset = row * 16
        chunk = decoded_from_336[offset:offset+16]
        hex_str = ' '.join(f'{b:02X}' for b in chunk)
        asc = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
        print(f"  {offset:04X}: {hex_str}  {asc}")

    # From the pseudocode, the section constant comes from the header.
    # The formula is: data[j] ^= *(BYTE*)(header + OFFSET) + j - 35
    # = (header_byte + j - 35) & 0xFF
    # = (j + (header_byte - 35)) & 0xFF
    # So C = header_byte - 35 = header_byte - 0x23

    # If C = 0x7B, then header_byte = 0x7B + 0x23 = 0x9E
    # If C = 0x83, then header_byte = 0x83 + 0x23 = 0xA6

    # NOW FOR THE HEADER: if we can determine the correct section start offset
    # and the header byte value, we can derive a constraint on the HEADER key.

    # From pseudocode: first section's decrypt constant comes from header offset 296.
    # data[j] ^= *(BYTE*)(header + 296) + j - 35

    # Actually wait - the pseudocode shows the SECTIONS are loaded from:
    # sub_180AD4B60(dest, src + header_field + const_offset, header_field_size)
    # where the source is the file mapping at qword_18C8F4E18.

    # Let me focus on CONFIRMING the section key and working backwards.
    # The decoded data with C=0x7B shows:
    # First bytes: 0x7F, 0x83, 0x77, 0x79 at offset 0-3 from section start.
    # Not obviously meaningful.

    # With C=0x83 from offset 336: first bytes are 00 00 00 00 00 00 00 00 00 00...
    # That's MUCH better! Null bytes = empty strings at the start of string section!

    # Actually wait - looking at the output more carefully:
    # Let me check if starting at 336 with C=0x83 gives proper null-terminated strings

    # After the initial nulls, we should see ASCII strings
    # First non-null byte indicates start of first real string
    print("\n\nFirst non-null content in decoded section from 336:")
    first_strings = []
    i = 0
    while i < len(decoded_from_336):
        if decoded_from_336[i] != 0:
            # Find end of string
            end = decoded_from_336.find(b'\x00', i)
            if end == -1:
                end = len(decoded_from_336)
            s = decoded_from_336[i:end]
            try:
                text = s.decode('utf-8')
                first_strings.append((i, text))
            except:
                first_strings.append((i, f"<binary: {s[:20].hex()}>"))
            i = end + 1
        else:
            i += 1

    print(f"  Found {len(first_strings)} strings in first 512 bytes:")
    for offset, text in first_strings[:20]:
        print(f"    [{offset:3d}] '{text}'")

    # NOW: Let's use the section encryption to work BACKWARDS to derive
    # the header content, specifically the byte at header offset 296
    # (which determines the section 1 encryption constant).

    # If the first section is indeed at file offset 336, and the section key
    # constant C = header_byte - 35, and we've determined C=0x83,
    # then header_byte at offset 296 in the DECRYPTED header = 0x83 + 0x23 = 0xA6.

    # This means: decrypted_header[296] = 0xA6
    # And: encrypted_header[296] = data[296] = ?
    print(f"\n\nHeader byte derivation:")
    print(f"  Section starts at file offset 336")
    print(f"  Section key C = 0x83 (derived from pattern match)")
    print(f"  header_byte = C + 35 = 0x83 + 0x23 = 0xA6")
    print(f"  encrypted[296] = 0x{data[296]:02X}")
    header_key_296 = data[296] ^ 0xA6
    print(f"  key[296] = encrypted[296] XOR plaintext[296] = 0x{data[296]:02X} XOR 0xA6 = 0x{header_key_296:02X}")

    # THIS IS ANOTHER KEY BYTE! key[296] = some value.
    # We now know key[0..3] and key[296].

    # Let me also check: what if the section starts at 328 (not 336)?
    # Then the first 8 bytes [f4, e5, 7c, 79, d8, d0, d6, 75] would be encrypted section data.
    # With C=0x7B: plaintext[0..7] = [f4^7B, e5^7C, 7c^7D, 79^7E, d8^7F, d0^80, d6^81, 75^82]
    #                                = [0x8F, 0x99, 0x01, 0x07, 0x57, 0x50, 0x57, 0xF7]
    # Not obviously meaningful.

    # With C=0x83 starting at 328: plaintext[0..7] = [f4^83, e5^84, 7c^85, 79^86, d8^87, d0^88, d6^89, 75^8A]
    #                                              = [0x77, 0x61, 0xF9, 0xFF, 0x5F, 0x58, 0x5F, 0xFF]
    # Hmm, 0x77='w', 0x61='a', then garbage. Not clean strings.

    # Let's try: what if the section format starts with a small header?
    # In standard il2cpp metadata, sections don't have sub-headers.
    # The string section immediately starts with null-terminated strings.
    # The FIRST entry is always an empty string (just a null byte).

    # BUT: if the section at offset 328 starts with empty string (null byte),
    # and section is encrypted with key (j + C): encrypted[328] = (0 + C) ^ 0 = C
    # We see encrypted[328] = 0xF4. So C = 0xF4... but then pattern wouldn't match at 336.

    # CONCLUSION: Section starts at offset 336, with C=0x83.
    # The 8 bytes at 328-335 might be part of the HEADER (making header = 336 bytes??)
    # OR they might be something else entirely.

    # Actually: 328 bytes was the header decrypt range. Maybe the actual data
    # structure has changed and the header is now 336 bytes.

    # Let's verify by checking more section boundaries. If sections are packed,
    # we should be able to find where the next section starts by looking for
    # a discontinuity in the pattern.

    print("\n\nSearching for section boundary (pattern break) after initial strings:")
    # Read more data
    big_data = read_at(METADATA_PATH, 336, 8192)
    # Decrypt with C=0x83
    dec_big = bytes(big_data[j] ^ ((j + 0x83) & 0xFF) for j in range(len(big_data)))

    # Look for where the pattern breaks (non-ASCII, non-null in a string section)
    # Actually let's look at how many bytes decode as valid UTF-8 strings
    # vs garbage
    print("  Checking decoded quality in 256-byte blocks:")
    for blk in range(0, 8192, 256):
        chunk = dec_big[blk:blk+256]
        ascii_count = sum(1 for b in chunk if 32 <= b < 127 or b == 0)
        null_count = chunk.count(0)
        print(f"    Block {blk:5d}-{blk+255:5d}: ascii+null={ascii_count:3d}/256, nulls={null_count:3d}")

    print("\n\nDone phase 9.")

if __name__ == "__main__":
    main()
