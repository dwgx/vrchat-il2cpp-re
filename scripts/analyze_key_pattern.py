"""Analyze the decrypt key from known plaintext-ciphertext pairs."""
import struct

# The code at 0xA88247 checks: cmp eax, 0x2d6d7973
# 0x2d6d7973 in little-endian = bytes 73 79 6D 2D = "sym-"
val = 0x2d6d7973
magic_bytes = struct.pack("<I", val)
print(f"Magic check: 0x{val:08X} = '{magic_bytes.decode('ascii')}'")
print()

# First 4 bytes of encrypted global-metadata.dat
# (from our earlier scan: starts with 0xC1C21EF0 = bytes F0 1E C2 C1)
enc_first4 = bytes([0xF0, 0x1E, 0xC2, 0xC1])

# Hypothesis 1: plaintext starts with "sym-" (0x73, 0x79, 0x6D, 0x2D)
plain_sym = b"sym-"
key1 = bytes([e ^ p for e, p in zip(enc_first4, plain_sym)])
print(f"If plaintext = 'sym-':")
print(f"  enc:   {enc_first4.hex()}")
print(f"  plain: {plain_sym.hex()}")
print(f"  key:   {key1.hex()} = {list(key1)}")
print()

# Hypothesis 2: plaintext starts with standard il2cpp magic 0xFAB11BAF
plain_fab = struct.pack("<I", 0xFAB11BAF)
key2 = bytes([e ^ p for e, p in zip(enc_first4, plain_fab)])
print(f"If plaintext = 0xFAB11BAF:")
print(f"  enc:   {enc_first4.hex()}")
print(f"  plain: {plain_fab.hex()}")
print(f"  key:   {key2.hex()} = {list(key2)}")
print()

# Check for simple patterns in both keys
for name, key in [("sym-", key1), ("0xFAB11BAF", key2)]:
    print(f"Pattern analysis for '{name}' key {list(key)}:")
    # Check (i + base) & 0xFF
    for base in range(256):
        match = True
        for i in range(4):
            if key[i] != (i + base) & 0xFF:
                match = False
                break
        if match:
            print(f"  MATCH: key[i] = (i + 0x{base:02X}) & 0xFF")
            break
    else:
        # Check (base - i) & 0xFF
        for base in range(256):
            match = True
            for i in range(4):
                if key[i] != (base - i) & 0xFF:
                    match = False
                    break
            if match:
                print(f"  MATCH: key[i] = (0x{base:02X} - i) & 0xFF")
                break
        else:
            # Check (i * mult + base) & 0xFF
            found = False
            for mult in range(1, 256):
                for base in range(256):
                    match = True
                    for i in range(4):
                        if key[i] != (i * mult + base) & 0xFF:
                            match = False
                            break
                    if match:
                        print(f"  MATCH: key[i] = (i * 0x{mult:02X} + 0x{base:02X}) & 0xFF")
                        found = True
                        break
                if found:
                    break
            if not found:
                print(f"  No simple linear pattern found")
                print(f"  Diffs: {[(key[i+1] - key[i]) & 0xFF for i in range(3)]}")
    print()

# The 0x2d6d7973 magic is NOT il2cpp standard. It's likely a Beebyte custom magic.
# This means after decryption, the header format is completely custom too.
# The code at 0xA8825B checks: test eax, eax (checking psrldq xmm1,8 result = offset+8)
# which is likely checking "number of sections" field after the magic.

# Let's also check: what if the entire header uses a FIXED XOR key (not position-based)?
print("=== Fixed-key hypothesis ===")
# If key is repeated 4-byte block:
for key_val in range(256):
    test = bytes([enc_first4[i] ^ key_val for i in range(4)])
    if test == plain_sym:
        print(f"Single-byte XOR key: 0x{key_val:02X}")
        break
    if test == plain_fab:
        print(f"Single-byte XOR key: 0x{key_val:02X} (for FAB11BAF)")
        break
else:
    print("Not a single-byte XOR")
