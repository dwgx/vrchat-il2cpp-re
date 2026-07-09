"""
Phase 6: Deep analysis of the SIMD decrypt loop.

Re-reading the pseudocode for the header decrypt loop in sub_180A7E880:

  v10 = _mm_load_si128(&xmmword_18B678BC0);  // [0x34 x 16]
  v13 = (u16*)(v4 + 4);  // v4 = copy of metadata header (328 bytes)
  v12 = -4 - v4;         // offset calculation base

  do {
    // For position at *(v13-2) (2 bytes):
    pos = (u64)v13 + v12;  // = byte offset relative to v4 start
    v14 = unpacklo_epi64(pos, pos);     // [pos, pos]
    v14 = add_epi64(v14, [0, 1]);       // [pos, pos+1]
    v14 = and_ps(v14, [0xFF, 0xFF]);    // [pos & 0xFF, (pos+1) & 0xFF]
    v15 = packus_epi16(v14, v14);       // pack to bytes
    v16 = packus_epi16(v15, v15);       // pack again
    // At this point v16 has the low bytes in positions 0,1

    *(v13-2) = cvtsi128_si32(
        xor_ps(
            sub_epi8(packus_epi16(v16, v16), cvtsi32_si128(v10)),  // subtract 0x34
            cvtsi32_si128(*(v13-2))  // XOR with encrypted data
        )
    );

    // Same for *(v13-1) with pos+2
    // Same for *v13 with pos+4
    // Same for *(v13+1) with pos+6

    v13 += 4;  // advance by 4 u16 = 8 bytes
  } while ((u64)v13 + v12 < 0x148);  // 328

Wait - I made an error! Let me re-trace the positions.

v13 starts at (v4 + 4), treated as u16*.
v12 = -4 - v4 (as i64).

Position for the first operation (*(v13-2)):
  The POSITION argument is: (u64)v13 + v12 = (v4+4) + (-4-v4) = 0

But wait - the code FIRST processes *(v13-2) with position from v13:
  position_for_v13_minus_2 = (u64)(v13) + v12

Hmm no. Looking at the code again:
  v14 = _mm_add_epi64(
    _mm_unpacklo_epi64((__m128i)((unsigned __int64)v13 + v12), ...),
    v8  // [0, 1]
  );

The position is (u64)v13 + v12 at this point.
v13 starts at v4+4, so first position = 0.
Then after add [0,1]: [0, 1]
After AND 0xFF: [0, 1]
Pack: bytes [0, 1, 0, 1, ...] (packed from words)
Sub 0x34: [0-0x34, 1-0x34, ...] = [0xCC, 0xCD, ...]
XOR with *(v13-2): XOR with bytes at offset 0,1 of buffer.

Then NEXT operation uses "(u64)v13 - 2 - v4" for position:
  = (v4+4) - 2 - v4 = 2
  After add [0,1]: [2, 3]
  After AND, pack, sub 0x34: [0xCE, 0xCF]
  XOR with *(v13-1) = bytes at offset 2,3.

Then "(u64)v13 - v4" for position:
  = (v4+4) - v4 = 4
  After add [0,1]: [4, 5]
  key bytes: [0xD0, 0xD1]
  XOR with *v13 = bytes at offset 4,5.

Then "(u64)v13 + 2 - v4" = 6
  key bytes: [0xD2, 0xD3]
  XOR with *(v13+1) = bytes at offset 6,7.

Then v13 += 4 (u16 units = 8 bytes).
New v13 = v4+12.
New position for first op: (v4+12) + (-4-v4) = 8.

So it processes byte pairs: (0,1), (2,3), (4,5), (6,7), (8,9), ...
With keys: [(0-0x34,1-0x34), (2-0x34,3-0x34), ...]
= [0xCC,0xCD,0xCE,0xCF,0xD0,0xD1,...]

This confirms: OLD formula = (i - 0x34) & 0xFF = (i + 0xCC) & 0xFF.

Since this DOESN'T match our known key [0x83, 0x67, 0xAF, 0xEC],
the current binary MUST use DIFFERENT CONSTANTS.

From the IDA analysis: xmmword_18B678BC0 = [0x34 x 16] and the ADD is [0, 1].
If the new binary changed these:
- If subtract_constant changed to X: key[i] = (i - X) & 0xFF
  For key[0]=0x83: X = -0x83 & 0xFF = 0x7D. Then key[1] = (1-0x7D)&0xFF = 0x84. NOPE!

- If the ADD constant changed from [0,1] to [A,B]:
  key[2i] = (i + A - 0x34) & 0xFF
  key[2i+1] = (i + B - 0x34) & 0xFF

  key[0] = (0 + A - 0x34) & 0xFF = 0x83 => A = 0x83 + 0x34 = 0xB7
  key[1] = (0 + B - 0x34) & 0xFF = 0x67 => B = 0x67 + 0x34 = 0x9B
  key[2] = (1 + 0xB7 - 0x34) & 0xFF = (1 + 0x83) & 0xFF = 0x84. Need 0xAF. NOPE!

- What if BOTH changed? subtract=X, add=[A,B]:
  key[2i] = (i + A - X) & 0xFF
  key[2i+1] = (i + B - X) & 0xFF

  key[0] = (A - X) & 0xFF = 0x83
  key[1] = (B - X) & 0xFF = 0x67
  key[2] = (1 + A - X) & 0xFF = 0x84. Need 0xAF. STILL NOPE!

The STRUCTURE of the algorithm (linear in i with step 1 per 2 bytes) cannot
produce the sequence [0x83, 0x67, 0xAF, 0xEC] regardless of constants!

CONCLUSION: The decrypt function in the current binary is FUNDAMENTALLY DIFFERENT
from the old one. It's not just changed constants - it's a different algorithm.

Given the SIMD approach with 18 seed bytes, most likely the new algorithm uses
a precomputed key table. Let me approach this differently: figure out what the
actual plaintext SHOULD look like for a VRChat metadata file, and derive the
full key from that.
"""

import struct
import sys

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
FILE_SIZE = 40_512_432

def read_header(path, size=1024):
    with open(path, "rb") as f:
        return f.read(size)

def main():
    data = read_header(METADATA_PATH)

    print("="*70)
    print("PHASE 6: Structural approach - derive key from known plaintext")
    print("="*70)

    # APPROACH: VRChat's custom metadata starts with "sym-" magic.
    # The rest of the header likely follows standard il2cpp format.
    # Standard il2cpp metadata v29 header after magic+version:
    #   33 pairs of (offset u32, size u32) = 264 bytes
    #   Total header = 4 + 4 + 264 = 272 bytes
    #
    # Key structural constraint: sections are PACKED.
    # offset[0] = 272 (header size)
    # size[0] = offset[1] - offset[0]
    # offset[1] = offset[0] + size[0]
    # etc.
    #
    # Also: sum of all sizes + 272 = file_size (40,512,432)
    # So: last_offset + last_size = 40,512,432
    #
    # For version 29, there are 33 section pairs.
    # We need to find key[0..271] to decrypt the full header.
    # We know key[0..3] = [0x83, 0x67, 0xAF, 0xEC].

    # CRITICAL INSIGHT: If we guess the VERSION correctly, we know plaintext[4..7].
    # Then if we guess the FIRST SECTION OFFSET correctly, we know plaintext[8..11].
    # From there, each size[n] = offset[n+1] - offset[n], giving us more constraints.

    # But there's a SIMPLER approach: just try to find the KEY PERIOD.
    # If the key repeats every N bytes, we can find N by looking at the structure.

    # Let's check: the decrypted values with 4-byte key show increasing pattern.
    # What if we SUBTRACT a linear ramp? i.e., the real key = base_4_key + position_term?

    # plaintext[i] = encrypted[i] XOR key[i]
    # If key[i] = base[i%4] XOR extra[i]:
    #   plaintext[i] = encrypted[i] XOR base[i%4] XOR extra[i]
    # "decrypted_with_base" = encrypted[i] XOR base[i%4] = plaintext[i] XOR extra[i]

    # So: extra[i] = decrypted_with_base[i] XOR plaintext[i]
    # If plaintext[i] is known (or constrained), we can find extra[i].

    # For a standard header, version=29 means:
    # plaintext = b"sym-" + struct.pack("<I", 29) + section_table
    # section_table[0] (offset[0]) = 272 = 0x00000110
    # section_table[1] (size[0]) = some size < file_size

    # The decrypted_with_base values at positions 4-7:
    base_key = [0x83, 0x67, 0xAF, 0xEC]
    dec_base = bytes(data[i] ^ base_key[i % 4] for i in range(272))

    print("\nDecrypted_with_base[4:12] (should be version XOR extra if theory correct):")
    print(f"  Bytes 4-11: {dec_base[4:12].hex(' ')}")
    print(f"  As u32s: 0x{struct.unpack_from('<I', dec_base, 4)[0]:08X}, 0x{struct.unpack_from('<I', dec_base, 8)[0]:08X}")

    # If version=29 (0x1D000000 LE bytes = 1D 00 00 00):
    # extra[4:8] = dec_base[4:8] XOR [0x1D, 0x00, 0x00, 0x00]
    #            = [0x4F^0x1D, 0xD1^0x00, 0x07^0x00, 0x51^0x00]
    #            = [0x52, 0xD1, 0x07, 0x51]

    # If offset[0] = 272 = 0x110 (bytes: 10 01 00 00):
    # extra[8:12] = dec_base[8:12] XOR [0x10, 0x01, 0x00, 0x00]
    #            = [0x07^0x10, 0x3B^0x01, 0xF3^0x00, 0x54^0x00]
    #            = [0x17, 0x3A, 0xF3, 0x54]

    # extra[0:4] = 0 (since base key IS the full key for bytes 0-3)
    # extra[4:12] = [0x52, 0xD1, 0x07, 0x51, 0x17, 0x3A, 0xF3, 0x54]
    # Hmm, no obvious pattern.

    # Let me try a COMPLETELY different angle:
    # What if the key is simply the BYTE POSITION divided by some factor,
    # combined with a per-4-byte constant?

    # Actually, let me look at the ENCRYPTED DWORDS as a sequence more carefully.
    # They decrease from 0xC1C21EF0 to 0x84603F18 over 16 entries (64 bytes).
    # If we model key_dword[n] as decreasing and plaintext_dword[n] as small:
    #   encrypted_dword[n] = key_dword[n] XOR small_value
    # The XOR of a large number with a small number mostly preserves the large number.
    # The DIFFERENCES between encrypted dwords would then reflect differences in key dwords.

    # Let's look at those encrypted dword differences again:
    enc_dw = [struct.unpack_from("<I", data, i)[0] for i in range(0, 256, 4)]

    # Now here's the real question: could the key be generated by a 32-bit counter
    # that DECREASES by a fixed amount per dword, but where the initial value and
    # step are unknown?

    # The dword differences are: 68M, 88M, 10M, 65M, 103M, 35M, 124M, 41M...
    # NOT constant. So simple linear counter at dword level doesn't work.

    # WHAT IF: the plaintext dwords are NOT small for all positions?
    # In standard il2cpp metadata, the section table contains OFFSETS that can be
    # up to 40MB. These are NOT small values! An offset like 20MB = 0x01312D00
    # would flip many bits when XORed with the key.

    # This means we CANNOT simply assume "key ~ encrypted" for all positions.
    # The approach needs to be more careful.

    # APPROACH: Assume il2cpp v29 structure and use PACKING constraint.
    # If sections are packed: offset[n] = 272 + sum(size[0..n-1])
    # And all offsets fit in file_size.

    # For 33 sections in a 40MB file, average section ~ 1.2MB.
    # Typical distribution: some sections very large (strings, methods, typeDefinitions)
    # and some very small.

    # Let me try a DIFFERENT version hypothesis. What if it's version 24?
    # v24 has fewer sections (about 19 pairs = 152 bytes + 8 = 160 bytes header).

    # Actually, let me check if we already have metadata version info somewhere.
    # The file could also use a non-standard header structure unique to VRChat.

    # PRAGMATIC APPROACH: Let's just try ALL possible key[4] values (0-255).
    # For each, assume it's the correct key and decrypt dword[1].
    # Then filter for plausible metadata versions.

    print("\n" + "="*70)
    print("ALL POSSIBLE VERSIONS (key[4] = enc[4] XOR version_byte_0):")
    print("="*70)

    # We only care about version_byte_0 since higher bytes of version should be 0.
    # So key[5]=enc[5], key[6]=enc[6], key[7]=enc[7] if version < 256.
    # enc[4..7] = [0xCC, 0xB6, 0xA8, 0xBD]
    # For version < 256: plaintext[5..7] = [0, 0, 0]
    # key[5..7] = [0xB6, 0xA8, 0xBD]

    # This gives us key[0..7] = [0x83, 0x67, 0xAF, 0xEC, enc[4]^ver, 0xB6, 0xA8, 0xBD]

    # Now: if the key has some structure, key[4..7] should relate to key[0..3].
    # key[0..3] = [0x83, 0x67, 0xAF, 0xEC]
    # key[5..7] = [0xB6, 0xA8, 0xBD]

    # Check: is there a constant difference between key[n] and key[n+4]?
    # key[5]-key[1] = 0xB6-0x67 = 0x4F
    # key[6]-key[2] = 0xA8-0xAF = -0x07 = 0xF9
    # key[7]-key[3] = 0xBD-0xEC = -0x2F = 0xD1
    # Not constant.

    # What about key[4]? If we had a pattern, we'd expect:
    # key[4]-key[0] = X => key[4] = 0x83 + X
    # Same X for all: key[5]-key[1] = 0x4F, so X=0x4F?
    # Then key[4] = 0x83 + 0x4F = 0xD2
    # Version = enc[4] ^ key[4] = 0xCC ^ 0xD2 = 0x1E = 30

    # Version 30!!! That's plausible for Unity 2022/6!
    print(f"\n  If key[n+4] = key[n] + 0x4F (additive shift):")
    print(f"    key[4] = 0x83 + 0x4F = 0xD2")
    print(f"    key[5] = 0x67 + 0x4F = 0xB6 (actual: 0xB6) MATCH!")
    print(f"    key[6] = 0xAF + 0x4F = 0xFE (actual: 0xA8) NO MATCH")

    # key[5] matches but key[6] doesn't. Try per-lane:
    # lane analysis:
    # key[5] - key[1] = 0xB6 - 0x67 = 0x4F
    # key[6] - key[2] = 0xA8 - 0xAF = 0xF9 (mod 256)
    # key[7] - key[3] = 0xBD - 0xEC = 0xD1 (mod 256)

    # Different deltas per lane. What if each lane has ITS OWN step?
    # Lane 0 (bytes 0,4,8,...): step01 = key[4] - key[0]
    # Lane 1 (bytes 1,5,9,...): step = key[5] - key[1] = 0x4F
    # Lane 2 (bytes 2,6,10,...): step = key[6] - key[2] = 0xF9
    # Lane 3 (bytes 3,7,11,...): step = key[7] - key[3] = 0xD1

    # If this pattern holds, key[n] = key[n%4] + (n//4) * step[n%4]
    # We know step[1]=0x4F, step[2]=0xF9, step[3]=0xD1.
    # We need to find step[0] (which determines the version).

    # For each candidate step[0], version = enc[4] XOR (key[0] + step[0])
    print(f"\n  Per-lane step hypothesis:")
    print(f"    step[1] = 0x4F (known from key[5]-key[1])")
    print(f"    step[2] = 0xF9 (known from key[6]-key[2])")
    print(f"    step[3] = 0xD1 (known from key[7]-key[3])")
    print(f"    step[0] = ? (determines version)")

    # Try versions:
    for version in range(20, 35):
        k4 = data[4] ^ version
        step0 = (k4 - 0x83) & 0xFF
        print(f"\n  version={version}: key[4]=0x{k4:02X}, step[0]=0x{step0:02X}")

        # Build full key using per-lane steps
        steps = [step0, 0x4F, 0xF9, 0xD1]
        full_key = [(base_key[i%4] + (i//4) * steps[i%4]) & 0xFF for i in range(272)]

        # Decrypt
        dec = bytes(data[i] ^ full_key[i] for i in range(min(272, len(data))))

        # Check plausibility
        magic = dec[:4]
        ver = struct.unpack_from("<I", dec, 4)[0]

        if magic != b"sym-":
            continue

        if ver != version:
            print(f"    Magic OK but version mismatch: got {ver}")
            continue

        # Check first few section offsets
        print(f"    Magic: {magic}, Version: {ver}")

        valid_sections = 0
        for s in range(min(10, (len(dec)-8)//8)):
            off = struct.unpack_from("<I", dec, 8 + s*8)[0]
            sz = struct.unpack_from("<I", dec, 12 + s*8)[0]
            valid = (0 < off < FILE_SIZE and sz < FILE_SIZE)
            if valid:
                valid_sections += 1
            if s < 5:
                v_str = "OK" if valid else "BAD"
                print(f"      Section {s}: offset=0x{off:08X} ({off:>10d}), size={sz:>10d} [{v_str}]")

        print(f"    Valid sections: {valid_sections}/10")

        # Check packing constraint: offset[1] should = offset[0] + size[0]
        if valid_sections >= 2:
            off0 = struct.unpack_from("<I", dec, 8)[0]
            sz0 = struct.unpack_from("<I", dec, 12)[0]
            off1 = struct.unpack_from("<I", dec, 16)[0]
            if off0 + sz0 == off1:
                print(f"    *** PACKING CONSTRAINT SATISFIED: off0+sz0 = off1 ***")
            else:
                print(f"    Packing check: off0({off0})+sz0({sz0})={off0+sz0} vs off1({off1}) -- {'MATCH' if off0+sz0==off1 else 'MISMATCH'}")

    # Also try: what if the steps are NEGATIVE (key decreases per lane)?
    print("\n\n" + "="*70)
    print("ALTERNATIVE: Steps might be different values")
    print("="*70)

    # What if step[0] follows a pattern with step[1..3]?
    # step[1]=0x4F, step[2]=0xF9, step[3]=0xD1
    # As signed: +79, -7, -47
    # Differences: -86, -40
    # Not obvious.

    # What if the steps themselves have a formula?
    # step[n] = A*n + B ?
    # step[1] = A+B = 0x4F
    # step[2] = 2A+B = 0xF9
    # A = 0xF9-0x4F = 0xAA
    # B = 0x4F - 0xAA = 0xA5
    # step[3] = 3*0xAA + 0xA5 = 0x1FE + 0xA5 = 0x2A3 & 0xFF = 0xA3 -- actual 0xD1. No.

    # step[0] = 0*0xAA + 0xA5 = 0xA5. Let's try it anyway.
    step0_guess = 0xA5
    k4_guess = (0x83 + step0_guess) & 0xFF
    ver_guess = data[4] ^ k4_guess
    print(f"  If step[0]=0xA5: key[4]=0x{k4_guess:02X}, version={ver_guess}")

    # Actually let me just try ALL step[0] values and find which gives best structure
    print("\n\n" + "="*70)
    print("EXHAUSTIVE SEARCH over step[0]")
    print("="*70)

    best = []
    for step0 in range(256):
        steps = [step0, 0x4F, 0xF9, 0xD1]
        full_key = [(base_key[i%4] + (i//4) * steps[i%4]) & 0xFF for i in range(272)]
        dec = bytes(data[i] ^ full_key[i] for i in range(272))

        if dec[:4] != b"sym-":
            continue

        ver = struct.unpack_from("<I", dec, 4)[0]
        if ver > 100 or ver == 0:
            continue

        # Count valid section entries
        valid = 0
        packed = 0
        for s in range(33):
            off = struct.unpack_from("<I", dec, 8 + s*8)[0]
            sz = struct.unpack_from("<I", dec, 12 + s*8)[0]
            if 0 < off < FILE_SIZE and 0 < sz < FILE_SIZE:
                valid += 1
            if s > 0:
                prev_off = struct.unpack_from("<I", dec, 8 + (s-1)*8)[0]
                prev_sz = struct.unpack_from("<I", dec, 12 + (s-1)*8)[0]
                if prev_off + prev_sz == off:
                    packed += 1

        best.append((valid + packed*5, step0, ver, valid, packed))

    best.sort(reverse=True)
    print(f"\nTop 10 results:")
    for score, s0, ver, valid, packed in best[:10]:
        print(f"  step[0]=0x{s0:02X}, version={ver:2d}, valid_sections={valid:2d}/33, packed={packed:2d}/32, score={score}")

        if score > 50:  # Very promising
            steps = [s0, 0x4F, 0xF9, 0xD1]
            full_key = [(base_key[i%4] + (i//4) * steps[i%4]) & 0xFF for i in range(272)]
            dec = bytes(data[i] ^ full_key[i] for i in range(272))
            print(f"    First 5 sections:")
            for sect in range(5):
                off = struct.unpack_from("<I", dec, 8 + sect*8)[0]
                sz = struct.unpack_from("<I", dec, 12 + sect*8)[0]
                print(f"      Section {sect}: off=0x{off:08X}, size={sz}")

    print("\n\nDone phase 6.")

if __name__ == "__main__":
    main()
