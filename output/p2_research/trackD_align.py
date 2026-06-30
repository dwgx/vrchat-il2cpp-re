#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Track D: hedge path -- map runtime-VA dump symbols onto disk file-VA WITHOUT
decrypting metadata, so runtime method names become usable in Ghidra.

Strategies:
  1. PE section layout of jun13 DLL (pefile): .text file_off / VA / size.
  2. Segmented linear fit: pair (file_ea, runtime_va) by class::method name,
     look for piecewise-constant offset (per-segment linear).
  3. Rank/ordinal alignment: sort both pointer sets, align by index k.

All stdout ASCII to avoid GBK issues on Windows.
"""
import json, sys, bisect
from collections import defaultdict

ROOT = "D:/Project/vrchat-il2cpp-re"
DLL  = ROOT + "/dumps/GameAssembly_jun13.dll"
RT_JUN13 = ROOT + "/data/precise_dump_jun13.json"          # build-matched
RT_TYPED = ROOT + "/data/precise_dump_unity6_typed.json"   # jun29 (mismatch)
GT1 = ROOT + "/output/ghidra_out/p2_batch1_pseudocode.json"
GT2 = ROOT + "/output/ghidra_out/validation_pseudocode.json"

def log(*a):
    print(*a); sys.stdout.flush()

# --- 1. PE sections ---------------------------------------------------------
def pe_sections():
    import pefile
    pe = pefile.PE(DLL, fast_load=True)
    ib = pe.OPTIONAL_HEADER.ImageBase
    log("=== PE SECTION LAYOUT (jun13 DLL) ===")
    log("ImageBase=0x%X  EntryPoint=0x%X  SizeOfImage=0x%X (%dMB)" % (
        ib, pe.OPTIONAL_HEADER.AddressOfEntryPoint,
        pe.OPTIONAL_HEADER.SizeOfImage, pe.OPTIONAL_HEADER.SizeOfImage//(1024*1024)))
    secs = []
    log("%-10s %-12s %-12s %-12s %-12s" % ("name","rva","vsize","fileoff","rawsize"))
    for s in pe.sections:
        name = s.Name.rstrip(b"\x00").decode("ascii","replace")
        d = dict(name=name, rva=s.VirtualAddress, vsize=s.Misc_VirtualSize,
                 foff=s.PointerToRawData, rsize=s.SizeOfRawData,
                 va_lo=ib+s.VirtualAddress,
                 va_hi=ib+s.VirtualAddress+max(s.Misc_VirtualSize, s.SizeOfRawData))
        secs.append(d)
        log("%-10s 0x%-10X 0x%-10X 0x%-10X 0x%-10X" % (
            name, s.VirtualAddress, s.Misc_VirtualSize, s.PointerToRawData, s.SizeOfRawData))
    return ib, secs

# --- 2. ground truth --------------------------------------------------------
def load_gt():
    out = {}
    for path in (GT1, GT2):
        d = json.load(open(path, "r", encoding="utf-8"))
        for it in d:
            ea = it.get("ea")
            if ea is None: continue
            try: ea = int(ea,16) if isinstance(ea,str) else int(ea)
            except: continue
            out[(it.get("class",""), it.get("method",""))] = ea
    return out

# --- 3. runtime dump --------------------------------------------------------
def load_runtime(path):
    d = json.load(open(path, "r", encoding="utf-8"))
    namekey = {}; all_ptrs = []; dup = 0
    for ns, classes in d.get("namespaces", {}).items():
        for c in classes:
            cls = c.get("name","")
            for mth, va in c.get("method_pointers", {}).items():
                try: va = int(va,16) if isinstance(va,str) else int(va)
                except: continue
                all_ptrs.append(va)
                k = (cls, mth)
                if k in namekey and namekey[k] != va: dup += 1
                namekey[k] = va
    return namekey, all_ptrs, dup

def analyze_pairs(pairs, tag):
    """pairs: list of (file_ea, runtime_va, cls, mth). Look for segmented offset."""
    log("\n=== OFFSET ANALYSIS (%s) ===" % tag)
    pairs = sorted(pairs, key=lambda x: x[0])  # by file_ea
    offs = [(fe, rv, rv - fe, cls, mth) for (fe, rv, cls, mth) in pairs]
    # global offset distribution
    diffs = sorted(set(o[2] for o in offs))
    log("distinct (runtime_va - file_ea) offsets: %d (over %d pairs)" % (len(diffs), len(offs)))
    # histogram of offsets
    cnt = defaultdict(int)
    for o in offs: cnt[o[2]] += 1
    top = sorted(cnt.items(), key=lambda x:-x[1])[:10]
    log("top offset values (offset_hex : count):")
    for off, c in top:
        log("   0x%X : %d" % (off & 0xFFFFFFFFFFFFFFFF, c))
    # If one offset dominates -> global linear works
    best_off, best_cnt = top[0]
    log("dominant offset covers %d/%d = %.1f%%" % (best_cnt, len(offs), 100.0*best_cnt/len(offs)))
    # Segmented: walk by file_ea order, group runs where offset is constant
    runs = []; cur_off = None; cur_n = 0; cur_lo = None
    for fe, rv, off, cls, mth in offs:
        if off == cur_off:
            cur_n += 1
        else:
            if cur_off is not None:
                runs.append((cur_lo, cur_off, cur_n))
            cur_off = off; cur_n = 1; cur_lo = fe
    if cur_off is not None:
        runs.append((cur_lo, cur_off, cur_n))
    runs_sorted = sorted(runs, key=lambda x:-x[2])
    log("contiguous-by-file_ea runs with constant offset: %d total" % len(runs))
    log("largest runs (file_ea_lo, offset, len):")
    for lo, off, n in runs_sorted[:8]:
        log("   ea>=0x%X  off=0x%X  len=%d" % (lo, off & 0xFFFFFFFFFFFFFFFF, n))
    big = sum(n for lo,off,n in runs if n >= 3)
    log("pairs in runs of len>=3: %d/%d = %.1f%%" % (big, len(offs), 100.0*big/len(offs)))
    return offs

def rank_align(pairs, all_runtime_ptrs, gt_all_eas, tag):
    """Ordinal alignment: sort both global pointer sets; for each matched pair,
    compare its rank-index in file space vs runtime space."""
    log("\n=== RANK / ORDINAL ALIGNMENT (%s) ===" % tag)
    rt = sorted(set(all_runtime_ptrs))
    fe = sorted(set(gt_all_eas))
    log("runtime uniq ptrs: %d   file_ea uniq (GT only): %d" % (len(rt), len(fe)))
    # For each matched pair, rank in runtime vs rank in (GT) file set.
    # GT is sparse (750), runtime is full -> normalize ranks to [0,1].
    matched = sorted(pairs, key=lambda x: x[0])
    n_ok = 0; samples = []
    for fe_v, rv_v, cls, mth in matched:
        r_rt = bisect.bisect_left(rt, rv_v) / max(1,len(rt))
        r_fe = bisect.bisect_left(fe, fe_v) / max(1,len(fe))
        samples.append((r_fe, r_rt, cls, mth))
    # correlation of normalized ranks
    if len(samples) >= 3:
        import statistics
        xs = [s[0] for s in samples]; ys = [s[1] for s in samples]
        mx = sum(xs)/len(xs); my = sum(ys)/len(ys)
        cov = sum((x-mx)*(y-my) for x,y in zip(xs,ys))
        vx = sum((x-mx)**2 for x in xs); vy = sum((y-my)**2 for y in ys)
        corr = cov/((vx*vy)**0.5) if vx>0 and vy>0 else 0.0
        log("normalized-rank Pearson corr (file vs runtime): %.4f" % corr)
        # monotonicity: count inversions on runtime rank when sorted by file rank
        inv = 0; n = len(samples)
        rorder = [s[1] for s in sorted(samples, key=lambda z:z[0])]
        for i in range(n):
            for j in range(i+1,n):
                if rorder[i] > rorder[j]: inv += 1
        maxinv = n*(n-1)//2
        log("rank inversions: %d / %d (%.1f%% concordant)" % (inv, maxinv,
            100.0*(1 - inv/maxinv) if maxinv else 0))
    return samples

def main():
    image_base, secs = pe_sections()
    t = next((s for s in secs if s["name"] == ".text"), None)
    if t:
        log("\n.text file-VA: 0x%X..0x%X  fileoff=0x%X  vsize=0x%X" %
            (t["va_lo"], t["va_hi"], t["foff"], t["vsize"]))

    gt = load_gt()
    eas = sorted(gt.values())
    log("\n=== GROUND TRUTH ===")
    log("GT pairs w/ file_ea: %d  range 0x%X..0x%X" % (len(gt), eas[0], eas[-1]))
    # how many GT eas fall inside .text?
    if t:
        inside = sum(1 for e in eas if t["va_lo"] <= e < t["va_hi"])
        log("GT eas inside .text: %d/%d" % (inside, len(eas)))

    log("\n=== RUNTIME DUMP (jun13, build-matched) ===")
    nk13, ptrs13, dup13 = load_runtime(RT_JUN13)
    pr = sorted(set(ptrs13))
    log("name-keys=%d all_ptrs=%d uniq=%d dup=%d  range 0x%X..0x%X" %
        (len(nk13), len(ptrs13), len(pr), dup13, pr[0], pr[-1]))

    pairs = []
    for (cls, mth), ea in gt.items():
        va = nk13.get((cls, mth))
        if va is not None:
            pairs.append((ea, va, cls, mth))
    log("\nname-matched pairs (jun13 GT x jun13 runtime): %d / %d GT" % (len(pairs), len(gt)))

    # fallback to jun29 typed if poor match
    used = "jun13"
    if len(pairs) < 10:
        log("!! few matches; trying jun29 typed dump")
        nk29, ptrs29, dup29 = load_runtime(RT_TYPED)
        p2 = [(ea, nk29[(c,m)], c, m) for (c,m),ea in gt.items() if (c,m) in nk29]
        log("jun29 matched: %d" % len(p2))
        if len(p2) > len(pairs):
            pairs = p2; ptrs13 = ptrs29; used = "jun29"

    if not pairs:
        log("\nNO PAIRS -> name keys do not align between GT and runtime dump.")
        # show sample keys from each side for diagnosis
        log("sample GT keys:")
        for k in list(gt.keys())[:5]:
            log("  %r" % (str(k).encode('ascii','replace').decode()))
        log("sample runtime keys:")
        for k in list(nk13.keys())[:5]:
            log("  %r" % (str(k).encode('ascii','replace').decode()))
        return

    analyze_pairs(pairs, used)
    rank_align(pairs, ptrs13, list(gt.values()), used)

    # Dump a few raw pairs for manual inspection
    log("\n=== SAMPLE PAIRS (file_ea, runtime_va, offset) ===")
    for fe, rv, cls, mth in sorted(pairs, key=lambda x:x[0])[:15]:
        log("  fe=0x%-11X rv=0x%-13X off=0x%-12X %s" % (
            fe, rv, (rv-fe)&0xFFFFFFFFFFFFFFFF,
            (cls+"::"+mth).encode('ascii','replace').decode()[:50]))

if __name__ == "__main__":
    main()
