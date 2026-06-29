#!/usr/bin/env python
"""Extract IL2CPP class/method data from Unity 6 (6000.0.x) VRChat builds via
reverse MethodInfo enumeration.

Why this exists: Unity 6 upgraded the IL2CPP runtime, reshuffling both the
Il2CppClass and MethodInfo layouts vs the June-13 (Unity 2022) build. The
class-name-string-pointer heuristic yields false positives and the old
MethodInfo.klass field (+0x18) now points into the module range, so forward
walking and the June-13 reverse extractor both fail. This tool enumerates
MethodInfo structs directly (stable signature: two module pointers + name +
heap klass) and groups them by their klass pointer, reconstructing every class.

Verified Unity 6 layout (dump VRChat_6456_20260629, ground-truth UnityEngine.Transform):
  MethodInfo:  +0x00 methodPtr(module) +0x08 invoker(module) +0x10 name +0x20 klass(heap)
  Il2CppClass: +0x18 namespace  +0x98 name  self-refs @ +0x10/+0x40/+0x90
  parent: auto-detected by consensus (struct grew; offset not fixed by hand)

vs June-13: MI.klass 0x18->0x20, CL_NAME 0xA8->0x98, self-refs relocated.

Output schema matches data/precise_dump.json:
  {summary, namespaces:{ns:[{name,namespace,parent,methods,method_pointers,fields,va}]}}
"""
import sys, os, json, struct, time, argparse
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from extract_precise_dump import DumpReader

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

# Unity 6 (6000.0.x) offsets
MI_PTR, MI_INVOKER, MI_NAME, MI_KLASS = 0x00, 0x08, 0x10, 0x20
CL_NS, CL_NAME = 0x18, 0x98
CL_SELFREF = 0x10  # klass[+0x10] == klass (self-reference invariant for verify)
CL_PARENT_CANDIDATES = list(range(0x20, 0x160, 8))  # auto-detected at runtime

MODULE_LO, MODULE_HI = 0x00007FF000000000, 0x00007FFFFFFFFFFF

_BEEBYTE = set("ÌÍÎÏ")


def is_ident(s):
    if not s or not (1 <= len(s) < 200):
        return False
    # Beebyte-obfuscated names are runs of U+00CC..U+00CF (non-ASCII) — keep them,
    # they are the primary RE target. Otherwise require a printable ASCII identifier.
    if all(c in _BEEBYTE for c in s):
        return len(s) >= 3
    if not s.isprintable():
        return False
    if s.isascii():
        c0 = s[0]
        return c0.isalpha() or c0 in "_<.$"
    return any(c.isalpha() for c in s)


def detect_heap_band(dr):
    """Find the ASLR-randomized managed-heap VA band by sampling MethodInfo-like
    records (two module pointers @ +0x00/+0x08, heap klass @ MI_KLASS). Returns
    (lo, hi) covering the dominant 4GB-aligned region, or None."""
    from collections import Counter
    buckets = Counter()
    mm = dr.mm
    GB4 = 0x100000000
    for vs, sz, fo in dr.va_map:
        if sz < 0x10000:
            continue
        step_end = fo + min(sz - 0x28, 4 * 1024 * 1024)
        p = fo
        while p <= step_end:
            mptr = struct.unpack_from("<Q", mm, p)[0]
            if MODULE_LO <= mptr <= MODULE_HI:
                invk = struct.unpack_from("<Q", mm, p + MI_INVOKER)[0]
                if MODULE_LO <= invk <= MODULE_HI:
                    klass = struct.unpack_from("<Q", mm, p + MI_KLASS)[0]
                    # managed heap is well below the module range
                    if 0x10000000000 <= klass < MODULE_LO:
                        buckets[klass // GB4] += 1
            p += 8
        if sum(buckets.values()) > 20000:
            break
    if not buckets:
        return None
    top = buckets.most_common(1)[0][0]
    lo_b = hi_b = top
    while (lo_b - 1) in buckets:
        lo_b -= 1
    while (hi_b + 1) in buckets:
        hi_b += 1
    return (lo_b * GB4, (hi_b + 1) * GB4)


def verify_offsets(dr, lo, hi):
    """Confirm Unity 6 offsets hold: locate UnityEngine.Transform by finding a
    pointer to its name string at klass+CL_NAME, then check ns@+0x18 and the
    self-reference invariant klass[+CL_SELFREF]==klass."""
    import struct as _s
    needle = b"Transform\x00"
    for vs, sz, fo in dr.va_map:
        i = dr.mm.find(needle, fo, fo + sz)
        while i != -1:
            sva = vs + (i - fo)
            prev = dr.mm[i - 1] if i > fo else 0
            if not (0x41 <= prev <= 0x5A or 0x61 <= prev <= 0x7A or prev == 0x5F):
                need = _s.pack("<Q", sva)
                for v2, s2, f2 in dr.va_map:
                    if s2 < 8:
                        continue
                    j = dr.mm.find(need, f2, f2 + s2)
                    while j != -1:
                        if (j - f2) % 8 == 0:
                            kl = v2 + (j - f2) - CL_NAME
                            if lo <= kl < hi and dr.rstr_ptr(kl + CL_NAME) == "Transform":
                                if dr.rstr_ptr(kl + CL_NS) == "UnityEngine" and dr.ru64(kl + CL_SELFREF) == kl:
                                    return True
                        j = dr.mm.find(need, j + 1, f2 + s2)
            i = dr.mm.find(needle, i + 1, fo + sz)
    return False


def detect_parent_offset(dr, klass_vas, lo, hi):
    """The Il2CppClass parent pointer offset shifted in Unity 6 and isn't pinned
    by hand. Detect it: for each candidate offset, count how many sampled classes
    have a slot pointing to another valid klass (name@CL_NAME resolves). The real
    parent slot resolves for the large majority of non-root classes."""
    from collections import Counter
    sample = klass_vas[:1500]
    hits = Counter()
    for kl in sample:
        for co in CL_PARENT_CANDIDATES:
            pv = dr.ru64(kl + co)
            if pv and lo <= pv < hi and pv != kl:
                pn = dr.rstr_ptr(pv + CL_NAME)
                if is_ident(pn) and dr.ru64(pv + CL_SELFREF) == pv:
                    hits[co] += 1
    if not hits:
        return None
    best, n = hits.most_common(1)[0]
    if n < len(sample) * 0.25:  # weak signal -> don't trust
        return None
    return best


def main():
    ap = argparse.ArgumentParser(description="Reverse MethodInfo extractor for Unity 6 (6000.0.x) VRChat builds")
    ap.add_argument("dump", nargs="?", default=r"D:\Project\vrchat-il2cpp-re\dumps\VRChat_6456_20260629_163108_full.dmp")
    ap.add_argument("--output-json", default=r"D:\Project\vrchat-il2cpp-re\data\precise_dump_unity6.json")
    ap.add_argument("--max-mi", type=int, default=0, help="cap MethodInfo count (0 = no cap)")
    ap.add_argument("--no-verify", action="store_true", help="skip the Transform offset self-check")
    args = ap.parse_args()

    dr = DumpReader(args.dump)
    print(f"[dump] {args.dump}  ({len(dr.va_map)} ranges)")

    heap_band = detect_heap_band(dr)
    if heap_band is None:
        print("[heap] WARNING: could not auto-detect heap band; falling back to full scan")
        lo, hi = 0x10000000000, MODULE_LO
    else:
        lo, hi = heap_band
        print(f"[heap] auto-detected band 0x{lo:X}..0x{hi:X}")

    heap_ranges = [(vs, sz, fo) for vs, sz, fo in dr.va_map
                   if sz >= 0x1000 and lo <= vs < hi]
    total = sum(sz for _, sz, _ in heap_ranges)
    print(f"[heap] {len(heap_ranges)} ranges, {total/1e9:.2f} GB")

    if not args.no_verify:
        if verify_offsets(dr, lo, hi):
            print("[verify] OK: UnityEngine.Transform resolves (CL_NAME=0x98, ns=0x18, self-ref=0x10)")
        else:
            print("[verify] FAILED: could not resolve UnityEngine.Transform with Unity 6 offsets.")
            print("[verify] The build layout likely changed. Re-derive offsets before trusting output.")
            print("[verify] (pass --no-verify to extract anyway)")
            return 2

    t0 = time.time()
    classes = {}          # klass_va -> {"methods":[], "ptrs":{}}
    mi_count = 0
    mm = dr.mm
    for vs, sz, fo in heap_ranges:
        end = fo + sz - 0x28
        p = fo
        while p <= end:
            mptr = struct.unpack_from("<Q", mm, p)[0]
            if MODULE_LO <= mptr <= MODULE_HI:
                invk = struct.unpack_from("<Q", mm, p + MI_INVOKER)[0]
                if MODULE_LO <= invk <= MODULE_HI:           # two module ptrs = MethodInfo
                    name_ptr = struct.unpack_from("<Q", mm, p + MI_NAME)[0]
                    klass = struct.unpack_from("<Q", mm, p + MI_KLASS)[0]
                    if lo <= klass < hi and dr.ok(name_ptr):
                        nm = dr.rstr(name_ptr, 200)
                        if is_ident(nm):
                            e = classes.get(klass)
                            if e is None:
                                e = {"methods": [], "ptrs": {}}
                                classes[klass] = e
                            e["methods"].append(nm)
                            e["ptrs"][nm] = f"0x{mptr:X}"
                            mi_count += 1
                            if args.max_mi and mi_count >= args.max_mi:
                                p = end + 1
                                break
            p += 8
        if args.max_mi and mi_count >= args.max_mi:
            break
    print(f"[scan] {mi_count} MethodInfos / {len(classes)} klasses in {time.time()-t0:.1f}s")

    # Auto-detect the Unity 6 parent offset from the collected klass set.
    cl_parent = detect_parent_offset(dr, list(classes.keys()), lo, hi)
    print(f"[parent] offset = {hex(cl_parent) if cl_parent else 'unresolved (parents omitted)'}")

    # Resolve class names/namespaces/parents and build namespace tree.
    namespaces = {}
    resolved = 0
    injected = 0
    for kl, e in classes.items():
        nm = dr.rstr_ptr(kl + CL_NAME)
        if not is_ident(nm):
            continue
        ns = dr.rstr_ptr(kl + CL_NS) or ""
        if ns and not (ns.isprintable() and (ns.isascii() or all(c in _BEEBYTE for c in ns))):
            ns = ""
        parent = ""
        if cl_parent is not None:
            pv = dr.ru64(kl + cl_parent)
            if pv and lo <= pv < hi:
                pn = dr.rstr_ptr(pv + CL_NAME)
                if is_ident(pn):
                    parent = pn
        # dedupe by name, preserve order, mark Unity-6 _Injected internal methods
        seen = set(); meths = []
        for m in e["methods"]:
            if m not in seen:
                seen.add(m); meths.append(m)
                if m.endswith("_Injected"):
                    injected += 1
        namespaces.setdefault(ns, []).append({
            "name": nm, "namespace": ns, "parent": parent,
            "methods": meths, "method_pointers": e["ptrs"],
            "fields": [], "va": f"0x{kl:X}",
        })
        resolved += 1

    total_methods = sum(len(c["methods"]) for cl in namespaces.values() for c in cl)
    out = {
        "summary": {
            "total_types": resolved,
            "total_methods": total_methods,
            "total_fields": 0,
            "types_with_methods": sum(1 for cl in namespaces.values() for c in cl if c["methods"]),
            "types_with_fields": 0,
            "namespace_count": len(namespaces),
            "injected_methods": injected,
            "method": "reverse_methodinfo_enumeration",
            "build": "unity6-6000.0",
            "parent_offset": hex(cl_parent) if cl_parent else None,
            "generated": time.strftime("%Y-%m-%d %H:%M:%S"),
            "source_dump": os.path.basename(args.dump),
        },
        "namespaces": namespaces,
    }
    with open(args.output_json, "w", encoding="utf-8") as f:
        json.dump(out, f, ensure_ascii=False, indent=1)
    print(f"[done] {resolved} classes, {total_methods} methods ({injected} _Injected) -> {args.output_json}")
    for ns in ("UnityEngine", "VRC.Dynamics", "VRC.Core"):
        for c in namespaces.get(ns, [])[:1]:
            print(f"  sample {ns}.{c['name']} parent={c['parent']} methods={len(c['methods'])} {c['methods'][:5]}")
    return 0


if __name__ == "__main__":
    sys.exit(main() or 0)
