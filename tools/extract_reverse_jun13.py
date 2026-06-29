#!/usr/bin/env python
"""Extract IL2CPP class/method data from June-13+ VRChat builds via reverse
MethodInfo enumeration.

Why this exists: extract_precise_dump.py walks Il2CppClass structs forward
(class -> methods array). On the June-13+ build the class layout was reshuffled
AND the class-name-string-pointer heuristic yields false positives, so forward
walking finds 0 confirmed classes. This tool instead enumerates MethodInfo
structs directly (they keep a stable, recognizable signature) and groups them by
their klass pointer, reconstructing every class without needing OFF_METHODS.

Verified June-13+ layout (dump VRChat_40752_20260621):
  MethodInfo:  +0x00 methodPtr(module) +0x08 invoker(module) +0x10 name +0x18 klass
  Il2CppClass: +0x18 namespace  +0x90 parent  +0xA8 name  self-refs @0x40/0x48/0x88

Output schema matches data/precise_dump.json:
  {summary, namespaces:{ns:[{name,namespace,parent,methods,method_pointers,fields,va}]}}
"""
import sys, os, json, struct, time, argparse
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from extract_precise_dump import DumpReader

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

# June-13+ offsets
MI_PTR, MI_INVOKER, MI_NAME, MI_KLASS = 0x00, 0x08, 0x10, 0x18
CL_NS, CL_PARENT, CL_NAME = 0x18, 0x90, 0xA8

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
    # allow ASCII identifiers and managed special names (.ctor, <>c, etc.)
    if s.isascii():
        c0 = s[0]
        return c0.isalpha() or c0 in "_<.$"
    # mixed/other unicode (rare) — accept if printable and has a letter
    return any(c.isalpha() for c in s)


def main():
    ap = argparse.ArgumentParser(description="Reverse MethodInfo extractor for June-13+ VRChat builds")
    ap.add_argument("dump", nargs="?", default=r"D:\Project\vrchat-il2cpp-re\dumps\VRChat_40752_20260621_102014_full.dmp")
    ap.add_argument("--output-json", default=r"D:\Project\vrchat-il2cpp-re\data\precise_dump_jun13.json")
    ap.add_argument("--max-mi", type=int, default=0, help="cap MethodInfo count (0 = no cap)")
    args = ap.parse_args()

    dr = DumpReader(args.dump)
    print(f"[dump] {args.dump}  ({len(dr.va_map)} ranges)")

    # Derive heap band from where klass/string pointers live: the 0x238.. region.
    # Use any range whose VA top byte pattern matches the managed heap (observed 0x238_.._...).
    heap_ranges = [(vs, sz, fo) for vs, sz, fo in dr.va_map
                   if sz >= 0x1000 and 0x20000000000 <= vs < 0x30000000000]
    total = sum(sz for _, sz, _ in heap_ranges)
    print(f"[heap] {len(heap_ranges)} ranges, {total/1e9:.2f} GB")

    t0 = time.time()
    classes = {}          # klass_va -> {"methods":[], "ptrs":{}}
    mi_count = 0
    mm = dr.mm
    for vs, sz, fo in heap_ranges:
        end = fo + sz - 0x20
        p = fo
        while p <= end:
            mptr = struct.unpack_from("<Q", mm, p)[0]
            if MODULE_LO <= mptr <= MODULE_HI:
                invk = struct.unpack_from("<Q", mm, p + MI_INVOKER)[0]
                if MODULE_LO <= invk <= MODULE_HI:           # two module ptrs = MethodInfo, not FieldInfo
                    name_ptr = struct.unpack_from("<Q", mm, p + MI_NAME)[0]
                    klass = struct.unpack_from("<Q", mm, p + MI_KLASS)[0]
                    if 0x20000000000 <= klass < 0x30000000000 and dr.ok(name_ptr):
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

    # Resolve class names/namespaces/parents and build namespace tree
    namespaces = {}
    resolved = 0
    for kl, e in classes.items():
        nm = dr.rstr_ptr(kl + CL_NAME)
        if not is_ident(nm):
            continue
        ns = dr.rstr_ptr(kl + CL_NS) or ""
        if ns and not (ns.isprintable() and (ns.isascii() or all(c in _BEEBYTE for c in ns))):
            ns = ""
        parent = ""
        pv = dr.ru64(kl + CL_PARENT)
        if pv and dr.ok(pv):
            pn = dr.rstr_ptr(pv + CL_NAME)
            if is_ident(pn):
                parent = pn
        # dedupe methods preserving order
        seen = set(); meths = []
        for m in e["methods"]:
            if m not in seen:
                seen.add(m); meths.append(m)
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
            "method": "reverse_methodinfo_enumeration",
            "build": "june13+",
            "generated": time.strftime("%Y-%m-%d %H:%M:%S"),
            "source_dump": os.path.basename(args.dump),
        },
        "namespaces": namespaces,
    }
    with open(args.output_json, "w", encoding="utf-8") as f:
        json.dump(out, f, ensure_ascii=False, indent=1)
    print(f"[done] {resolved} classes, {total_methods} methods -> {args.output_json}")
    # quick sanity sample
    for ns in ("UnityEngine", "VRC.Dynamics"):
        for c in namespaces.get(ns, [])[:1]:
            print(f"  sample {ns}.{c['name']} parent={c['parent']} methods={len(c['methods'])} {c['methods'][:5]}")


if __name__ == "__main__":
    main()
