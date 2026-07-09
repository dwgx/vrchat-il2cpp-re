"""
Phase 8: Fresh structural analysis.

The IDA pseudocode is from an OLD binary version.
The current GameAssembly.dll has NO matching constants.
We need to find the key purely from the encrypted metadata.

Key facts:
1. Encrypted first 4 bytes XOR with [83 67 AF EC] give "sym-"
2. File size = 40,512,432 bytes
3. The file IS il2cpp metadata (VRChat custom format with "sym-" magic)

Strategy: Use known structure of il2cpp metadata to derive more key bytes.
For il2cpp metadata, the LAST section's (offset + size) = file_size.
This gives us a constraint on the bytes near the END of the header.

Also: il2cpp metadata typically has the string table as one of the first
sections. String data starts with lots of ASCII null-terminated strings.
If we can find where strings start, we can verify a key by checking for ASCII.

Let's read bytes at offset 272 (typical header end) and check if decrypted
data looks like ASCII strings for various key hypotheses.

ALSO: Let me try a completely different assumption about the magic.
What if "sym-" is NOT bytes 0-3 of the plaintext but rather the plaintext
uses STANDARD il2cpp magic (0xFAB11BAF) and the KEY starts differently?
"""

import struct
import os

METADATA_PATH = r"D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat"
FILE_SIZE = 40_512_432

def read_at(path, offset, size):
    with open(path, "rb") as f:
        f.seek(offset)
        return f.read(size)

def main():
    # Read first 1024 bytes
    header_data = read_at(METADATA_PATH, 0, 1024)

    print("="*70)
    print("PHASE 8: Complete structural analysis")
    print("="*70)

    # HYPOTHESIS A: The header is only encrypted for the first N bytes,
    # and the rest is plaintext. Check if bytes after some offset look
    # like valid il2cpp data (ASCII strings, small integers, etc.)

    print("\n[A] Checking if data becomes 'plaintext-like' after some offset:")
    for start in [256, 272, 320, 328, 512, 1024]:
        if start >= len(header_data):
            chunk = read_at(METADATA_PATH, start, 64)
        else:
            chunk = header_data[start:start+64]
        ascii_count = sum(1 for b in chunk if 32 <= b < 127 or b == 0)
        null_count = chunk.count(0)
        print(f"  Offset {start:4d}: ascii={ascii_count}/64, nulls={null_count}/64, first16={chunk[:16].hex(' ')}")

    # HYPOTHESIS B: Only the first 4 bytes are XORed with a known magic,
    # and the rest uses a DIFFERENT encryption. Maybe a block cipher?
    # Check entropy of blocks:
    print("\n[B] Entropy analysis of 64-byte blocks:")
    for blk in range(0, 1024, 64):
        chunk = header_data[blk:blk+64]
        unique = len(set(chunk))
        byte_range = max(chunk) - min(chunk)
        print(f"  [{blk:4d}-{blk+63:4d}]: unique={unique:3d}/64, range={byte_range:3d}, min=0x{min(chunk):02X}, max=0x{max(chunk):02X}")

    # HYPOTHESIS C: The encryption is a STREAM CIPHER (like RC4 or ChaCha)
    # initialized with a key from the binary. In that case, the key stream
    # would look pseudo-random and we can't easily derive it without the seed.
    # BUT: RC4 output with a known plaintext prefix gives us the first N bytes
    # of the key stream, which we could use to identify the cipher.

    # Known key stream bytes 0-3: [0x83, 0x67, 0xAF, 0xEC]
    # If this were RC4, these would be the first output bytes.
    # RC4 key stream depends on the key. Without the key, we can't extend it.
    # But we can check if the known key stream bytes match any common RC4 keys.

    # HYPOTHESIS D: The XOR is with a REPEATING KEY but longer than 4 bytes.
    # Let's find the period by looking at autocorrelation of encrypted data.
    print("\n[D] Autocorrelation analysis (looking for key period):")
    # For a repeating key of period N: encrypted[i] XOR encrypted[i+N]
    # = plaintext[i] XOR plaintext[i+N]
    # If plaintext has structure (e.g., many zeros in section sizes),
    # the XOR at the right period will show more zeros or patterns.

    # Check periods 4 through 64:
    for period in [4, 8, 12, 16, 18, 20, 24, 32, 48, 64, 128, 256, 328]:
        if period >= 512:
            continue
        # XOR bytes i with bytes i+period for i in [0..511-period]
        xored = bytes(header_data[i] ^ header_data[i + period] for i in range(min(512, 1024 - period)))
        zeros = xored.count(0)
        low_vals = sum(1 for b in xored if b < 16)
        print(f"  Period {period:3d}: zeros={zeros:3d}/{len(xored)}, low_vals(<16)={low_vals:3d}")

    # HYPOTHESIS E: The metadata has a different structure than standard il2cpp.
    # VRChat might use a custom header format after "sym-".
    # Let's check the IL2CPP source for metadata format with "sym-" magic.
    # Actually "sym-" backwards is "-mys" and as u32 LE is 0x2D6D7973.
    # This doesn't match any known standard.

    # HYPOTHESIS F: What if the file is encrypted with a PAGE-BASED scheme?
    # i.e., each 4096-byte page uses a different key?
    # Or: key[i] = f(i / page_size, i % page_size)

    # HYPOTHESIS G: The decrypt function from the pseudocode runs on
    # 328 bytes of the header. After decryption, the header contains
    # offsets/sizes for sections. The SECTIONS themselves are then
    # separately decrypted with: section_data[j] ^= constant + j - 35
    # (where constant is a byte from the decrypted header).
    # This means we only need to crack the 328-byte HEADER key.

    # The header has 328 bytes. Our key is 328 bytes long.
    # With 4 bytes known, we need 324 more.
    # We need at least ONE structural constraint to make progress.

    # STRONGEST CONSTRAINT: bytes 4-7 should be a VERSION number < 100.
    # This means bytes 5, 6, 7 of plaintext are 0x00.
    # So: key[5] = enc[5], key[6] = enc[6], key[7] = enc[7]
    # key[5] = 0xB6, key[6] = 0xA8, key[7] = 0xBD

    # We now know key[0..7] = [0x83, 0x67, 0xAF, 0xEC, ?, 0xB6, 0xA8, 0xBD]
    # where ? = enc[4] XOR version

    # For the header structure (version determines number of sections):
    # v24: 19 pairs + magic + version = 160 bytes
    # v27: 27 pairs + magic + version = 224 bytes
    # v29: 33 pairs + magic + version = 272 bytes
    # v31: 35 pairs + magic + version = 288 bytes

    # Actually VRChat's custom "sym-" format might not follow standard section layout.
    # It might be completely custom.

    # CRUCIAL NEW APPROACH: Check at what offset the file transitions from
    # "encrypted" to "plaintext" (or differently-encrypted).
    # Standard il2cpp metadata has string data starting after the header.
    # Strings are plaintext ASCII. If we find an offset where data becomes ASCII,
    # that tells us where the header encryption ends.

    print("\n\n[G] Scanning file for transition to ASCII (string data):")
    # Read at various offsets and check for ASCII density
    test_offsets = [256, 272, 288, 320, 328, 352, 384, 400, 448, 512, 768, 1024,
                    2048, 4096, 8192, 16384]
    for off in test_offsets:
        chunk = read_at(METADATA_PATH, off, 128)
        ascii_count = sum(1 for b in chunk if 32 <= b < 127)
        null_count = chunk.count(0)
        # Also check for null-terminated ASCII pattern
        has_nullterm = False
        for j in range(len(chunk) - 1):
            if chunk[j] >= 32 and chunk[j] < 127 and chunk[j+1] == 0:
                has_nullterm = True
                break
        marker = " <-- possible strings" if (ascii_count > 80 or (null_count > 20 and ascii_count > 40)) else ""
        print(f"  Offset 0x{off:06X} ({off:6d}): ascii={ascii_count:3d}/128, nulls={null_count:3d}{marker}")

    # Let's also read at larger offsets
    print("\n  Larger offsets:")
    for off in [32768, 65536, 131072, 262144, 524288, 1048576, 2097152]:
        chunk = read_at(METADATA_PATH, off, 128)
        ascii_count = sum(1 for b in chunk if 32 <= b < 127)
        null_count = chunk.count(0)
        printable = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk[:64])
        marker = " <-- strings!" if ascii_count > 80 else ""
        print(f"  Offset 0x{off:07X} ({off:8d}): ascii={ascii_count:3d}/128, nulls={null_count:3d}{marker}")
        if ascii_count > 80:
            print(f"    Preview: {printable[:64]}")

    # MOST IMPORTANT: read small offsets at fine granularity
    print("\n  Fine-grained scan near expected header end (256-400):")
    for off in range(256, 401, 8):
        chunk = read_at(METADATA_PATH, off, 32)
        ascii_count = sum(1 for b in chunk if 32 <= b < 127)
        null_count = chunk.count(0)
        print(f"  0x{off:04X}: ascii={ascii_count:2d}/32, nulls={null_count:2d}, data={chunk[:16].hex(' ')}")

    print("\n\nDone phase 8.")

if __name__ == "__main__":
    main()
