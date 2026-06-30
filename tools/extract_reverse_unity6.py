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
MI_RETTYPE = 0x18  # MethodInfo.return_type (Il2CppType*). Verified 2026-06-29:
                   # Transform.get_position->Vector3, get_parent->Transform,
                   # get_childCount->Int32. Resolved via the same handle map as
                   # field types.
MI_PARAMS = 0x28   # MethodInfo.parameters: Il2CppType** (array of count ptrs).
MI_PCOUNT = 0x4A   # MethodInfo.parameters_count (uint8). Verified 2026-06-29:
                   # SetPositionAndRotation->(Vector3,Quaternion), LookAt->
                   # (Transform,Vector3), Rotate->(Vector3,Space). Truncating by
                   # this count avoids reading into the adjacent param pool.
CL_NS, CL_NAME = 0x18, 0x98
CL_SELFREF = 0x10  # klass[+0x10] == klass (self-reference invariant for verify)
CL_BYVAL = 0x20    # inline byval_arg; +0x20 holds the Il2CppMetadataTypeHandle
                   # that field-type Il2CppType.data references (verified 06-29).
CL_PARENT_CANDIDATES = list(range(0x20, 0x160, 8))  # auto-detected at runtime
CL_FIELDS = 0xa8   # FieldInfo[] array pointer (verified vs Vector3/Color/Vector2)

# FieldInfo layout (Unity 6, verified): stride 0x20, name@+0x08, parent@+0x18 (-> klass).
# field_count in the class struct is unreliable here, so fields are enumerated by
# walking the array while FieldInfo.parent == klass (terminates cleanly).
# FI_TYPE: the Il2CppType* for the field's declared type. Verified 2026-06-29 at
# +0x10 (NOT +0x00 — that slot is offset/token): Color.r/g/b/a and Vector3.x/y/z
# all resolve to Single via the type-enum byte at Il2CppType+0x0A.
FI_STRIDE, FI_NAME, FI_PARENT, FI_TYPE = 0x20, 0x08, 0x18, 0x10
FI_MAX = 256  # safety cap per class

# Il2CppTypeEnum (low byte at Il2CppType+0x0A) -> primitive/system type name.
# Class/valuetype kinds (0x11/0x12) carry an Il2CppClass* in Il2CppType.data
# whose name resolution is still being pinned, so they are reported structurally.
IL2CPP_TYPE_ENUM = {
    0x01: "Void", 0x02: "Boolean", 0x03: "Char", 0x04: "SByte", 0x05: "Byte",
    0x06: "Int16", 0x07: "UInt16", 0x08: "Int32", 0x09: "UInt32", 0x0A: "Int64",
    0x0B: "UInt64", 0x0C: "Single", 0x0D: "Double", 0x0E: "String",
    0x18: "IntPtr", 0x19: "UIntPtr", 0x1C: "Object",
}

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


def extract_fields(dr, kl, lo, hi):
    """Walk the FieldInfo array at klass+CL_FIELDS, collecting field names while
    FieldInfo.parent == klass (clean terminator). Unity 6 layout: stride 0x20,
    name@+0x08, parent@+0x18. Returns list of field-name strings."""
    arr = dr.ru64(kl + CL_FIELDS)
    if not arr or not (lo <= arr < hi):
        return []
    out = []
    for k in range(FI_MAX):
        fi = arr + k * FI_STRIDE
        if dr.ru64(fi + FI_PARENT) != kl:
            break
        nm = dr.rstr_ptr(fi + FI_NAME)
        if is_ident(nm):
            out.append(nm)
    return out


def resolve_type_name(dr, tptr, lo, hi, handle2name=None, _depth=0):
    """Resolve an Il2CppType* (from FieldInfo+FI_TYPE) to its declared type name.

    The type kind is the byte at Il2CppType+0x0A; primitives/system types map
    directly via IL2CPP_TYPE_ENUM (verified: Color.r->Single, Camera.kMinBlade
    Count->Int32). For class/valuetype kinds (0x11/0x12) the Il2CppType.data
    (first qword) is an Il2CppMetadataTypeHandle, NOT a runtime klass pointer —
    the same handle is embedded in the owning klass's inline byval_arg at
    klass+CL_BYVAL. So discriminative type names are resolved through a
    handle->name map (built by build_handle_name_map). Verified 2026-06-29:
    Vector3.zeroVector->UnityEngine.Vector3, Camera.onPreCull->CameraCallback.

    GENERICINST (kind 0x15): Il2CppType.data -> Il2CppGenericClass whose +0x00 is
    the generic type-definition Il2CppType* and whose +0x08 is the generic
    context; context+0x00 -> Il2CppGenericInst (+0x00 argc, +0x08 argv =
    Il2CppType**). Verified 2026-06-29: ApiWorld.localWorlds ->
    Dictionary`2<String,ApiWorld>, ApiWorld.mWorldInstances ->
    List`1<ApiWorldInstance>, VRCPlayerApi._isMasterDelegate ->
    Func`2<VRCPlayerApi,Boolean>. Rendered as Base<Arg,...> so the inner
    argument types (often the only discriminative part) become visible to the
    type-signal miners. Returns None when the pointer is unreadable."""
    fo = dr.v2f(tptr) if tptr else None
    if fo is None:
        return None
    kind = dr.mm[fo + 0x0A]
    if kind in IL2CPP_TYPE_ENUM:
        return IL2CPP_TYPE_ENUM[kind]
    if kind in (0x11, 0x12):  # VALUETYPE / CLASS
        if handle2name is not None:
            data = dr.ru64(tptr)
            nm = handle2name.get(data)
            if nm:
                return nm
        return f"<class:0x{kind:02X}>"
    if kind == 0x15:  # GENERICINST
        if _depth < 3:
            gc = dr.ru64(tptr)
            if dr.v2f(gc) is not None:
                base = resolve_type_name(dr, dr.ru64(gc + 0x00), lo, hi,
                                         handle2name, _depth + 1)
                ginst = dr.ru64(gc + 0x08)
                args = []
                if ginst and dr.v2f(ginst) is not None:
                    argc = dr.ru64(ginst + 0x00)
                    argv = dr.ru64(ginst + 0x08)
                    if 1 <= argc <= 8 and argv and dr.v2f(argv) is not None:
                        for i in range(argc):
                            an = resolve_type_name(dr, dr.ru64(argv + i * 8),
                                                   lo, hi, handle2name,
                                                   _depth + 1)
                            args.append(an if an else "?")
                if base and args:
                    # strip the `N arity marker for readability: List`1 -> List
                    b = base.split("`")[0]
                    return f"{b}<{','.join(args)}>"
                if base:
                    return base.split("`")[0]
        return "<genericinst>"
    if kind in (0x14, 0x1D):  # ARRAY (multidim) / SZARRAY (T[])
        # SZARRAY (0x1D): Il2CppType.data is the element Il2CppType* directly.
        # ARRAY (0x14): data -> Il2CppArrayType whose +0x00 is the element
        # Il2CppType*. Verified 2026-06-29: rendering element[] surfaces the
        # element domain type (e.g. ValueTuple<AudioSource,AudioSourceType>[],
        # Entry<..,Sprite>[]) which is the discriminative part for the miners.
        if _depth < 3:
            data = dr.ru64(tptr)
            if dr.v2f(data) is not None:
                etype = data if kind == 0x1D else dr.ru64(data + 0x00)
                en = resolve_type_name(dr, etype, lo, hi, handle2name,
                                       _depth + 1)
                if en and not en.startswith("<"):
                    return f"{en}[]"
        return "<array>"
    if kind in (0x13, 0x1E):
        return "<genericparam>"
    return f"<kind:0x{kind:02X}>"


# Implemented-interface list. Il2CppClass+CL_INTERFACES (verified +0xB0 for the
# Unity 6 06-29 build) points at an INTERLEAVED array of
# Il2CppRuntimeInterfaceOffsetPair: [interface Il2CppClass*, vtable_slot, ...] so
# the stride is 16 bytes and the interface klass is the first qword of each pair.
# Verified 2026-06-29: Button -> IMoveHandler, IEventSystemHandler,
# IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler,
# ISelectHandler, IDeselectHandler. There is no reliable adjacent count field
# (the obvious uint16 slots are constant across classes), so the array is read
# greedily until an entry fails the klass self-reference invariant.
CL_INTERFACES = 0xB0


def extract_interfaces(dr, kl, lo, hi, max_ifaces=48):
    """Return the list of implemented-interface short names for klass kl."""
    ip = dr.ru64(kl + CL_INTERFACES)
    if dr.v2f(ip) is None:
        return []
    out = []
    for i in range(max_ifaces):
        kp = dr.ru64(ip + i * 16)
        if dr.v2f(kp) is None or dr.ru64(kp + CL_SELFREF) != kp:
            break
        nm = dr.rstr_ptr(kp + CL_NAME)
        if not nm:
            break
        out.append(nm)
    return out


def build_handle_name_map(dr, klass_vas, lo, hi):
    """Map Il2CppMetadataTypeHandle -> "Namespace.Name" for every klass.

    Each Il2CppClass carries its handle in the inline byval_arg.data at
    klass+CL_BYVAL (verified +0x20 for the Unity 6 06-29 build). Field types of
    kind class/valuetype reference the same handle, so this map turns their
    Il2CppType.data into a readable type name.

    Scanning only the MethodInfo-derived klasses (klass_vas) misses every klass
    with no enumerated method (interfaces, enums, structs, system valuetypes) —
    that gap was the source of the residual <class:0x11> field types. So this
    sweeps the FULL heap for klasses via the self-reference invariant
    (klass[+CL_SELFREF] == klass), recovering ~21k more handles. klass_vas is
    folded in as a fallback seed so the map is never smaller than before."""
    out = {}

    def record(kl):
        h = dr.ru64(kl + CL_BYVAL)
        if not h or not (lo <= h < hi) or h in out:
            return
        nm = dr.rstr_ptr(kl + CL_NAME)
        if not is_ident(nm):
            return
        ns = dr.rstr_ptr(kl + CL_NS) or ""
        out[h] = f"{ns}.{nm}" if (ns and ns.isascii() and ns.isprintable()) else nm

    # Full-heap self-ref sweep (numpy fast path; falls back per-qword if absent).
    try:
        import numpy as np
        mm = dr.mm
        for vs, sz, fo in dr.va_map:
            if sz < 0x1000 or not (lo <= vs < hi):
                continue
            n = (sz - 0x28) // 8
            if n <= 0:
                continue
            base = np.arange(n, dtype=np.uint64) * np.uint64(8) + np.uint64(vs)
            sr = np.frombuffer(mm, dtype=np.uint64, count=n, offset=fo + CL_SELFREF)
            for i in np.where(sr == base[:len(sr)])[0]:
                record(int(base[int(i)]))
    except ImportError:
        pass

    # Seed/fallback: the known MethodInfo klasses (also covers the no-numpy case).
    for kl in klass_vas:
        record(kl)
    return out


def extract_fields_typed(dr, kl, lo, hi, handle2name=None):
    """Like extract_fields but each entry is {"name", "type"} with the field's
    declared type resolved via FI_TYPE (0x10). type is "" when unresolvable."""
    arr = dr.ru64(kl + CL_FIELDS)
    if not arr or not (lo <= arr < hi):
        return []
    out = []
    for k in range(FI_MAX):
        fi = arr + k * FI_STRIDE
        if dr.ru64(fi + FI_PARENT) != kl:
            break
        nm = dr.rstr_ptr(fi + FI_NAME)
        if is_ident(nm):
            tname = resolve_type_name(dr, dr.ru64(fi + FI_TYPE), lo, hi, handle2name) or ""
            out.append({"name": nm, "type": tname})
    return out


def verify_fields(dr, kl, lo, hi):
    """Ground-truth check: UnityEngine.Color must expose r/g/b/a fields."""
    fs = set(extract_fields(dr, kl, lo, hi))
    return {"r", "g", "b", "a"}.issubset(fs)


def main():
    ap = argparse.ArgumentParser(description="Reverse MethodInfo extractor for Unity 6 (6000.0.x) VRChat builds")
    ap.add_argument("dump", nargs="?", default=r"D:\Project\vrchat-il2cpp-re\dumps\VRChat_6456_20260629_163108_full.dmp")
    ap.add_argument("--output-json", default=r"D:\Project\vrchat-il2cpp-re\data\precise_dump_unity6.json")
    ap.add_argument("--max-mi", type=int, default=0, help="cap MethodInfo count (0 = no cap)")
    ap.add_argument("--no-verify", action="store_true", help="skip the Transform offset self-check")
    ap.add_argument("--typed-fields", action=argparse.BooleanOptionalAction,
                    default=True,
                    help="emit fields as {name,type} with resolved field types "
                         "(additive; on by default — use --no-typed-fields for the "
                         "legacy bare name list / schema v1)")
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
                                e = {"methods": [], "ptrs": {}, "rettype": {},
                                     "params": {}}
                                classes[klass] = e
                            e["methods"].append(nm)
                            e["ptrs"][nm] = f"0x{mptr:X}"
                            if args.typed_fields:
                                # stash the raw return_type Il2CppType* now; the
                                # handle map needed to resolve it is built later.
                                e["rettype"][nm] = struct.unpack_from(
                                    "<Q", mm, p + MI_RETTYPE)[0]
                                # stash param Il2CppType* array (truncated to count)
                                pc = mm[p + MI_PCOUNT]
                                if pc and pc < 64:
                                    parr = struct.unpack_from(
                                        "<Q", mm, p + MI_PARAMS)[0]
                                    e["params"][nm] = [
                                        dr.ru64(parr + i * 8) for i in range(pc)]
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

    # For --typed-fields: build the handle->name map once over all known klasses
    # so class/valuetype field types resolve to readable names.
    handle2name = None
    if args.typed_fields:
        handle2name = build_handle_name_map(dr, list(classes.keys()), lo, hi)
        print(f"[types] handle->name map: {len(handle2name)} entries")

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
        if args.typed_fields:
            typed = extract_fields_typed(dr, kl, lo, hi, handle2name)
            fields = [t["name"] for t in typed]   # keep bare list for compatibility
            field_types = {t["name"]: t["type"] for t in typed if t["type"]}
            # Resolve method return types via the same handle map. Only keep
            # discriminative (non-void, resolvable) entries to stay compact.
            mret = {}
            for m in meths:
                rtp = e["rettype"].get(m)
                if not rtp:
                    continue
                rn = resolve_type_name(dr, rtp, lo, hi, handle2name)
                if rn and rn != "Void" and not rn.startswith("<"):
                    mret[m] = rn
            # Resolve method parameter types (same handle map). Keep only methods
            # with at least one discriminative param type, to stay compact.
            mparams = {}
            for m in meths:
                ptrs = e["params"].get(m)
                if not ptrs:
                    continue
                names = []
                for tp in ptrs:
                    pn = resolve_type_name(dr, tp, lo, hi, handle2name) if tp else None
                    names.append(pn if pn else "")
                if any(n and not n.startswith("<") for n in names):
                    mparams[m] = names
            entry = {
                "name": nm, "namespace": ns, "parent": parent,
                "methods": meths, "method_pointers": e["ptrs"],
                "method_return_types": mret,
                "method_param_types": mparams,
                "fields": fields, "field_types": field_types, "va": f"0x{kl:X}",
            }
        else:
            fields = extract_fields(dr, kl, lo, hi)
            entry = {
                "name": nm, "namespace": ns, "parent": parent,
                "methods": meths, "method_pointers": e["ptrs"],
                "fields": fields, "va": f"0x{kl:X}",
            }
        ifaces = extract_interfaces(dr, kl, lo, hi)
        if ifaces:
            entry["interfaces"] = ifaces
        namespaces.setdefault(ns, []).append(entry)
        resolved += 1

    total_methods = sum(len(c["methods"]) for cl in namespaces.values() for c in cl)
    total_fields = sum(len(c["fields"]) for cl in namespaces.values() for c in cl)

    # Field self-check: UnityEngine.Color must expose r/g/b/a. Warn loudly if the
    # FieldInfo layout shifted (so field output is never silently trusted).
    color_fields = set()
    for c in namespaces.get("UnityEngine", []):
        if c["name"] == "Color":
            color_fields = set(c["fields"]); break
    if {"r", "g", "b", "a"}.issubset(color_fields):
        print("[verify] OK: UnityEngine.Color fields r/g/b/a present (FieldInfo layout valid)")
    else:
        print(f"[verify] WARNING: UnityEngine.Color fields look wrong ({sorted(color_fields)});"
              " FieldInfo offsets may have shifted.")
    out = {
        "summary": {
            "total_types": resolved,
            "total_methods": total_methods,
            "total_fields": total_fields,
            "types_with_methods": sum(1 for cl in namespaces.values() for c in cl if c["methods"]),
            "types_with_fields": sum(1 for cl in namespaces.values() for c in cl if c["fields"]),
            "namespace_count": len(namespaces),
            "injected_methods": injected,
            "method": "reverse_methodinfo_enumeration",
            "build": "unity6-6000.0",
            "parent_offset": hex(cl_parent) if cl_parent else None,
            "field_offsets": {"CL_FIELDS": hex(CL_FIELDS), "FI_STRIDE": hex(FI_STRIDE),
                              "FI_NAME": hex(FI_NAME), "FI_PARENT": hex(FI_PARENT),
                              "FI_TYPE": hex(FI_TYPE), "CL_BYVAL": hex(CL_BYVAL)},
            "typed_fields": bool(args.typed_fields),
            "schema_version": 2 if args.typed_fields else 1,
            "generated": time.strftime("%Y-%m-%d %H:%M:%S"),
            "source_dump": os.path.basename(args.dump),
        },
        "namespaces": namespaces,
    }
    with open(args.output_json, "w", encoding="utf-8") as f:
        json.dump(out, f, ensure_ascii=False, indent=1)
    print(f"[done] {resolved} classes, {total_methods} methods ({injected} _Injected), "
          f"{total_fields} fields -> {args.output_json}")
    for ns in ("UnityEngine", "VRC.Dynamics", "VRC.Core"):
        for c in namespaces.get(ns, [])[:1]:
            print(f"  sample {ns}.{c['name']} parent={c['parent']} "
                  f"methods={len(c['methods'])} fields={len(c['fields'])} {c['methods'][:4]}")
    return 0


if __name__ == "__main__":
    sys.exit(main() or 0)
