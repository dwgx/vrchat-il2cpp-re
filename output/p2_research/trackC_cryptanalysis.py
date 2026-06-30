#!/usr/bin/env python3
# Track C: pure cryptanalysis of jun26 global-metadata.dat encryption.
# No binary RE. Read-only on the metadata file.
import sys, math, collections
import numpy as np

PATH = r"D:/Steam/steamapps/common/VRChat/VRChat_Data/il2cpp_data/Metadata/global-metadata.dat"
MAGIC = bytes.fromhex("af1bb1fa")  # 0xFAB11BAF little-endian

def load():
    with open(PATH, "rb") as f:
        return f.read()

def shannon_entropy(buf):
    if not buf:
        return 0.0
    c = collections.Counter(buf)
    n = len(buf)
    h = 0.0
    for v in c.values():
        p = v / n
        h -= p * math.log2(p)
    return h

def cmd_basic(data):
    print("=== BASIC ===")
    print("size", len(data), "=", hex(len(data)))
    print("first 64 enc:", data[:64].hex(" "))
    # recover header keystream from magic + zero version high bytes
    # pt[0:4]=magic, pt[5:8]=0 (version is small int)
    ks = bytearray(8)
    pt0 = MAGIC + bytes([0,0,0,0])  # we don't know pt[4] yet
    for i in range(4):
        ks[i] = data[i] ^ MAGIC[i]
    for i in range(5,8):
        ks[i] = data[i] ^ 0
    print("recovered ks[0:4]:", ks[:4].hex(" "))
    print("recovered ks[5:8]:", bytes(ks[5:8]).hex(" "))
    # version candidates
    for v in (24,27,29,31):
        ks4 = data[4] ^ v
        print(f"  if version={v}: ks[4]={ks4:#04x}")

def cmd_entropy(data, block=4096):
    print("=== ENTROPY (block=%d) ===" % block)
    n = len(data)
    nb = n // block
    ents = []
    for b in range(nb):
        ents.append(shannon_entropy(data[b*block:(b+1)*block]))
    ents = np.array(ents)
    print("blocks", nb, "mean", round(ents.mean(),4), "min", round(ents.min(),4), "max", round(ents.max(),4))
    # report low-entropy regions (likely plaintext / padding / structured)
    low = np.where(ents < 6.0)[0]
    print("low-entropy (<6.0) blocks count:", len(low))
    if len(low):
        # group contiguous
        groups = []
        start = low[0]; prev = low[0]
        for x in low[1:]:
            if x == prev+1:
                prev = x
            else:
                groups.append((start,prev)); start=x; prev=x
        groups.append((start,prev))
        print("low-entropy regions (block idx -> file offset):")
        for s,e in groups[:40]:
            print(f"  blocks[{s}:{e}] off[{s*block:#x}:{(e+1)*block:#x}] ent~{ents[s]:.2f}")
    # high uniform entropy => encrypted
    print("first 8 block ents:", [round(e,3) for e in ents[:8]])
    print("last 8 block ents:", [round(e,3) for e in ents[-8:]])

def cmd_autocorr(data, maxlag=2048, sample=None):
    # Detect repeating XOR key: for a fixed-length repeating key, the ciphertext
    # XOR shifted-by-period equals plaintext XOR shifted plaintext. In zero-padded
    # or low-entropy regions this yields many zero bytes at the true period.
    print("=== AUTOCORRELATION (XOR-shift coincidence) ===")
    arr = np.frombuffer(data, dtype=np.uint8)
    if sample:
        arr = arr[:sample]
    n = len(arr)
    best = []
    for lag in range(1, maxlag+1):
        x = np.bitwise_xor(arr[:n-lag], arr[lag:])
        zeros = np.count_nonzero(x == 0)
        rate = zeros / (n-lag)
        best.append((rate, lag))
    best.sort(reverse=True)
    print("top-20 lags by zero-XOR coincidence (rate, lag):")
    for rate,lag in best[:20]:
        print(f"  lag={lag} ({lag:#x}) rate={rate:.5f}")
    # baseline random ~ 1/256 = 0.0039
    print("random baseline ~0.00391")

def cmd_bytehist(data, mod, sample=2_000_000):
    # If keystream is periodic with period `mod`, then within each residue class
    # i%mod, ciphertext byte distribution should be a shifted plaintext dist.
    # Check chi-square / max-freq per residue to see if a single key byte dominates.
    print(f"=== PERIODIC KEY TEST mod={mod} (sample {sample}) ===")
    arr = np.frombuffer(data[:sample], dtype=np.uint8)
    n = len(arr)
    strong = 0
    for r in range(mod):
        col = arr[r::mod]
        cnt = np.bincount(col, minlength=256)
        top = cnt.max()/len(col)
        if top > 0.10:
            strong += 1
    print(f"residues with a byte >10% freq: {strong}/{mod}")

def main():
    data = load()
    cmd = sys.argv[1] if len(sys.argv)>1 else "all"
    if cmd in ("all","basic"): cmd_basic(data)
    if cmd in ("all","entropy"): cmd_entropy(data)
    if cmd in ("all","autocorr"): cmd_autocorr(data)
    if cmd in ("all","period"):
        for m in (16,32,64,128,256,512,1024):
            cmd_bytehist(data, m)

if __name__ == "__main__":
    main()
