#!/usr/bin/env python
"""
extract_precise_dump.py - Extract IL2CPP type/method/field data from memory dump
using EXACT runtime Il2CppClass structs (not heuristic string grouping).

Discovered managed Il2CppClass layout (a 2026-04-18 dump):
  +0x00: Il2CppImage* image
  +0x10: const char* name
  +0x18: const char* namespaceString
  +0x40: Il2CppClass* element_class  (== self for non-array types)
  +0x48: Il2CppClass* castClass      (== self for non-generic base types)
  +0x78: MethodInfo** methods
  +0xA0: Il2CppClass* parent
  +0xA8: FieldInfo* fields
  +0xD0: NativeClass* nativeEntry (stride-0x50 table in 0x7FFFACE0XXXX)
  +0x120: uint16 method_count
  +0x122: uint16 field_count

MethodInfo layout:
  +0x00: method_pointer (RVA of compiled code)
  +0x28: const char* name

FieldInfo layout (stride 0x30):
  +0x00: metadata
  +0x08: type_info pointer
  +0x18: parent class pointer
  +0x10: const char* name
  +0x28: token/flags

Self-reference check: class.element_class == &class AND class.castClass == &class
"""

import argparse
import mmap
import struct
import sys
import json
import time
import os
from bisect import bisect_right
from collections import defaultdict

try:
    import numpy as np
except ImportError:
    np = None

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

DUMP_PATH = r"tools/process_NEW.dmp"
OUTPUT_DIR = r"<project_root>\il2cpp_full_dump"

# Managed class struct offsets
OFF_IMAGE    = 0x00
OFF_NS       = 0x18
OFF_ELEM     = 0x40
OFF_CAST     = 0x48
OFF_NAME     = 0x10
OFF_METHODS  = 0x78
OFF_FIELDS   = 0xA8
OFF_PARENT   = 0xA0
OFF_NATIVE   = 0xD0
OFF_MCNT     = 0x120  # u16 method_count
OFF_FCNT     = 0x122  # u16 field_count

# MethodInfo offsets
MI_POINTER   = 0x00
MI_NAME      = 0x28

# FieldInfo offsets
FI_STRIDE    = 0x30
FI_NAME      = 0x10

# Heap scan range
HEAP_VA_START = 0x30000000
HEAP_VA_END   = 0x3E000000
USER_VA_LIMIT = 0x0000800000000000
AUTO_MIN_RANGE_SIZE = 0x1000
AUTO_SCAN_CHUNK_SIZE = 64 * 1024 * 1024

CLASS_SIZE = 0x180  # minimum class struct size


class DumpReader:
    def __init__(self, path):
        self.f = open(path, "rb")
        self.mm = mmap.mmap(self.f.fileno(), 0, access=mmap.ACCESS_READ)
        self.va_map = []
        self._parse_mdmp()

    def _parse_mdmp(self):
        mm = self.mm
        assert mm[:4] == b"MDMP"
        sc = struct.unpack_from("<I", mm, 8)[0]
        sd = struct.unpack_from("<I", mm, 12)[0]
        m64 = None
        for i in range(sc):
            off = sd + i * 12
            if struct.unpack_from("<I", mm, off)[0] == 9:
                m64 = struct.unpack_from("<I", mm, off + 8)[0]
                break
        nr = struct.unpack_from("<Q", mm, m64)[0]
        cur = struct.unpack_from("<Q", mm, m64 + 8)[0]
        for i in range(min(nr, 50000)):
            e = m64 + 16 + i * 16
            vs = struct.unpack_from("<Q", mm, e)[0]
            sz = struct.unpack_from("<Q", mm, e + 8)[0]
            self.va_map.append((vs, sz, cur))
            cur += sz
        self.va_map.sort()
        self.va_starts = [vs for vs, _, _ in self.va_map]

    def v2f(self, va):
        idx = bisect_right(self.va_starts, va) - 1
        if idx < 0:
            return None
        vs, sz, fo = self.va_map[idx]
        if vs <= va < vs + sz:
            return fo + (va - vs)
        return None

    def iter_user_ranges(self, min_size=AUTO_MIN_RANGE_SIZE):
        for vs, sz, fo in self.va_map:
            if sz < min_size:
                continue
            if not (0 < vs < USER_VA_LIMIT):
                continue
            end = vs + sz
            if end <= vs:
                continue
            if end > USER_VA_LIMIT:
                sz = USER_VA_LIMIT - vs
                if sz < min_size:
                    continue
            yield vs, sz, fo

    def ok(self, va):
        return va and 0 < va < 0x7FFFFFFFFFFF and self.v2f(va) is not None

    def ru64(self, va):
        fo = self.v2f(va)
        return struct.unpack_from("<Q", self.mm, fo)[0] if fo else None

    def ru32(self, va):
        fo = self.v2f(va)
        return struct.unpack_from("<I", self.mm, fo)[0] if fo else None

    def ru16(self, va):
        fo = self.v2f(va)
        return struct.unpack_from("<H", self.mm, fo)[0] if fo else None

    def rstr(self, va, mx=256):
        fo = self.v2f(va)
        if fo is None:
            return None
        end = self.mm.find(b"\x00", fo, fo + mx)
        if end < 0:
            return None
        try:
            return self.mm[fo:end].decode("utf-8")
        except Exception:
            return None

    def rstr_ptr(self, va):
        ptr = self.ru64(va)
        if ptr and self.ok(ptr):
            return self.rstr(ptr, 256)
        return None


def find_all_classes(dr):
    """Scan heap for Il2CppClass structs using self-reference check."""
    heap_fo = dr.v2f(HEAP_VA_START)
    heap_sz = HEAP_VA_END - HEAP_VA_START
    mm = dr.mm
    classes = []
    step = 8

    print(f"[+] Scanning 0x{HEAP_VA_START:X}-0x{HEAP_VA_END:X} for Il2CppClass entries...")
    t0 = time.time()

    for i in range(0, heap_sz - CLASS_SIZE, step):
        va = HEAP_VA_START + i
        fo = heap_fo + i
        # Quick: +0x40 == self
        v40 = struct.unpack_from("<Q", mm, fo + OFF_ELEM)[0]
        if v40 != va:
            continue
        # +0x48 == self
        v48 = struct.unpack_from("<Q", mm, fo + OFF_CAST)[0]
        if v48 != va:
            continue
        # Name at +0x58
        name_ptr = struct.unpack_from("<Q", mm, fo + OFF_NAME)[0]
        if not name_ptr or not dr.ok(name_ptr):
            continue
        name = dr.rstr(name_ptr, 128)
        if not name or not name.isprintable():
            continue
        # Namespace at +0x18
        ns_ptr = struct.unpack_from("<Q", mm, fo + OFF_NS)[0]
        ns = ""
        if ns_ptr and dr.ok(ns_ptr):
            ns = dr.rstr(ns_ptr, 128) or ""
            if not ns.isprintable():
                ns = ""

        classes.append(va)

    elapsed = time.time() - t0
    print(f"    Found {len(classes)} Il2CppClass entries ({elapsed:.1f}s)")
    return classes


def _validate_class_candidate(dr, va):
    name_ptr = dr.ru64(va + OFF_NAME)
    if not name_ptr or not dr.ok(name_ptr):
        return False
    name = dr.rstr(name_ptr, 128)
    if not name or not name.isprintable():
        return False

    ns_ptr = dr.ru64(va + OFF_NS)
    if ns_ptr and dr.ok(ns_ptr):
        ns = dr.rstr(ns_ptr, 128) or ""
        if ns and not ns.isprintable():
            return False
    return True


def _scan_range_for_classes_numpy(dr, range_start, range_size, file_off, chunk_size=AUTO_SCAN_CHUNK_SIZE):
    classes = []
    remaining = range_size - CLASS_SIZE
    if remaining <= 0:
        return classes

    for chunk_off in range(0, remaining, chunk_size):
        candidate_bytes = min(chunk_size, remaining - chunk_off)
        if candidate_bytes <= 0:
            break

        candidate_count = candidate_bytes // 8
        if candidate_count <= 0:
            continue

        window_bytes = candidate_count * 8 + OFF_CAST + 8
        qword_count = window_bytes // 8
        qwords = np.frombuffer(
            dr.mm,
            dtype="<u8",
            count=qword_count,
            offset=file_off + chunk_off,
        )
        offsets = np.arange(candidate_count, dtype=np.uint64) * 8
        base_vas = np.uint64(range_start + chunk_off) + offsets
        mask = (qwords[OFF_ELEM // 8:OFF_ELEM // 8 + candidate_count] == base_vas)
        mask &= (qwords[OFF_CAST // 8:OFF_CAST // 8 + candidate_count] == base_vas)

        for idx in np.flatnonzero(mask):
            va = int(base_vas[idx])
            if _validate_class_candidate(dr, va):
                classes.append(va)

    return classes


def find_all_classes_auto(dr):
    """Scan every user-mode Memory64List range for Il2CppClass self references."""
    if np is None:
        raise RuntimeError("--auto-heap requires numpy")

    ranges = list(dr.iter_user_ranges())
    total_bytes = sum(sz for _, sz, _ in ranges)
    print(
        f"[+] Auto-scanning {len(ranges):,} user-mode ranges "
        f">= {AUTO_MIN_RANGE_SIZE} bytes ({total_bytes / 1024 / 1024 / 1024:.2f} GiB)..."
    )

    t0 = time.time()
    classes = []
    scanned = 0
    next_report = 512 * 1024 * 1024

    for i, (vs, sz, fo) in enumerate(ranges, 1):
        classes.extend(_scan_range_for_classes_numpy(dr, vs, sz, fo))
        scanned += sz
        if scanned >= next_report or i == len(ranges):
            elapsed = time.time() - t0
            rate = (scanned / 1024 / 1024) / elapsed if elapsed else 0.0
            print(
                f"    {i:,}/{len(ranges):,} ranges, "
                f"{scanned / 1024 / 1024 / 1024:.2f}/{total_bytes / 1024 / 1024 / 1024:.2f} GiB, "
                f"{len(classes):,} classes, {rate:.1f} MiB/s"
            )
            next_report += 512 * 1024 * 1024

    elapsed = time.time() - t0
    print(f"    Found {len(classes)} Il2CppClass entries ({elapsed:.1f}s)")
    return classes


def read_class_info(dr, va):
    """Read full class information from Il2CppClass at va."""
    info = {"va": f"0x{va:X}"}

    # Name
    info["name"] = dr.rstr_ptr(va + OFF_NAME) or ""
    info["namespace"] = dr.rstr_ptr(va + OFF_NS) or ""

    # Parent
    parent = dr.ru64(va + OFF_PARENT)
    if parent and dr.ok(parent):
        info["parent_va"] = f"0x{parent:X}"
        info["parent_name"] = dr.rstr_ptr(parent + OFF_NAME) or ""
    else:
        info["parent_va"] = None
        info["parent_name"] = ""

    # Methods
    methods_arr = dr.ru64(va + OFF_METHODS)
    method_count_raw = dr.ru16(va + OFF_MCNT) if dr.v2f(va + OFF_MCNT) else 0
    methods = []

    if methods_arr and dr.ok(methods_arr) and method_count_raw:
        # Clamp to reasonable max
        mc = min(method_count_raw, 2000)
        for i in range(mc):
            mi_ptr = dr.ru64(methods_arr + i * 8)
            if not mi_ptr or not dr.ok(mi_ptr):
                break
            name = dr.rstr_ptr(mi_ptr + MI_NAME)
            if not name:
                break
            minfo = {"name": name}
            # Method pointer (RVA)
            mptr = dr.ru64(mi_ptr + MI_POINTER)
            if mptr:
                minfo["pointer"] = f"0x{mptr:X}"
            methods.append(minfo)

    info["methods"] = methods
    info["method_count_raw"] = method_count_raw

    # Fields
    fields_ptr = dr.ru64(va + OFF_FIELDS)
    field_count_raw = dr.ru16(va + OFF_FCNT) if dr.v2f(va + OFF_FCNT) else 0
    fields = []
    if fields_ptr and dr.ok(fields_ptr) and field_count_raw:
        fc = min(field_count_raw, 500)
        for fi in range(fc):
            fi_va = fields_ptr + fi * FI_STRIDE
            fname_ptr_va = fi_va + FI_NAME
            fname_ptr = dr.ru64(fname_ptr_va)
            if not fname_ptr or not dr.ok(fname_ptr):
                continue  # skip invalid, don't break
            fname = dr.rstr(fname_ptr, 128)
            if fname and fname.isprintable() and len(fname) > 0:
                fields.append(fname)

    info["fields"] = fields
    info["field_count_raw"] = field_count_raw
    return info


def generate_cs_stub(types_by_ns):
    """Generate C# stub file from extracted data."""
    lines = []
    lines.append("// IL2CPP Full Dump - Precise extraction from runtime Il2CppClass structs")
    lines.append(f"// Generated: {time.strftime('%Y-%m-%d %H:%M:%S')}")
    lines.append(f"// Method: self-reference scan of managed heap")
    lines.append("")

    for ns in sorted(types_by_ns.keys()):
        types = types_by_ns[ns]
        if ns:
            lines.append(f"namespace {ns}")
            lines.append("{")
            indent = "    "
        else:
            indent = ""

        for t in sorted(types, key=lambda x: x["name"]):
            parent_str = ""
            if t["parent_name"]:
                parent_str = f" : {t['parent_name']}"
            lines.append(f"{indent}public class {t['name']}{parent_str}")
            lines.append(f"{indent}{{")

            for f in t["fields"]:
                lines.append(f"{indent}    public object {f};")

            if t["fields"] and t["methods"]:
                lines.append("")

            for m in t["methods"]:
                ptr = m.get("pointer", "")
                comment = f" // {ptr}" if ptr else ""
                lines.append(f"{indent}    public void {m['name']}() {{ }}{comment}")

            lines.append(f"{indent}}}")
            lines.append("")

        if ns:
            lines.append("}")
            lines.append("")

    return "\n".join(lines)


def parse_args():
    parser = argparse.ArgumentParser(
        description="Extract IL2CPP type/method/field data from a target process memory dump."
    )
    parser.add_argument(
        "dump_path",
        nargs="?",
        default=DUMP_PATH,
        help=f"Path to the minidump file (default: {DUMP_PATH})",
    )
    parser.add_argument(
        "--output-dir",
        default=OUTPUT_DIR,
        help=f"Output directory for precise_dump artifacts (default: {OUTPUT_DIR})",
    )
    parser.add_argument(
        "--auto-heap",
        action="store_true",
        help="Scan all user-mode Memory64List ranges instead of the fixed heap VA window",
    )
    parser.add_argument(
        "--output-json",
        default=None,
        help="Explicit path for precise_dump JSON output",
    )
    parser.add_argument(
        "--output-cs",
        default=None,
        help="Explicit path for precise_dump C# stub output",
    )
    return parser.parse_args()


def main():
    args = parse_args()
    dump_path = args.dump_path
    output_dir = args.output_dir

    if not os.path.exists(dump_path):
        print(f"[-] Dump file not found: {dump_path}")
        sys.exit(1)

    print("[+] Opening dump...")
    dr = DumpReader(dump_path)
    print(f"    {len(dr.va_map)} VA ranges loaded")

    # Phase 1: Find all classes
    class_vas = find_all_classes_auto(dr) if args.auto_heap else find_all_classes(dr)

    # Phase 2: Read class info
    print(f"\n[+] Reading class details...")
    t0 = time.time()
    all_classes = []
    for i, va in enumerate(class_vas):
        info = read_class_info(dr, va)
        all_classes.append(info)
        if (i + 1) % 10000 == 0:
            print(f"    {i+1}/{len(class_vas)}...")

    elapsed = time.time() - t0
    print(f"    Done ({elapsed:.1f}s)")

    # Phase 3: Statistics
    total_methods = sum(len(c["methods"]) for c in all_classes)
    total_fields = sum(len(c["fields"]) for c in all_classes)
    with_methods = sum(1 for c in all_classes if c["methods"])
    with_fields = sum(1 for c in all_classes if c["fields"])

    ns_counts = defaultdict(int)
    for c in all_classes:
        ns_counts[c["namespace"]] += 1

    print(f"\n[+] Results:")
    print(f"    Classes:       {len(all_classes)}")
    print(f"    With methods:  {with_methods}")
    print(f"    With fields:   {with_fields}")
    print(f"    Total methods: {total_methods}")
    print(f"    Total fields:  {total_fields}")
    print(f"    Namespaces:    {len(ns_counts)}")

    # VRC specific
    vrc_classes = [c for c in all_classes if c["namespace"].startswith("VRC")]
    vrc_methods = sum(len(c["methods"]) for c in vrc_classes)
    print(f"    VRC.* classes:  {len(vrc_classes)} ({vrc_methods} methods)")

    # Phase 4: Output JSON
    types_by_ns = defaultdict(list)
    for c in all_classes:
        types_by_ns[c["namespace"]].append(c)

    json_out = {
        "summary": {
            "total_types": len(all_classes),
            "total_methods": total_methods,
            "total_fields": total_fields,
            "types_with_methods": with_methods,
            "types_with_fields": with_fields,
            "namespace_count": len(ns_counts),
            "method": "precise_runtime_extraction",
            "generated": time.strftime("%Y-%m-%d %H:%M:%S"),
        },
        "namespaces": {
            ns: [
                {
                    "name": c["name"],
                    "namespace": c["namespace"],
                    "parent": c["parent_name"],
                    "methods": [m["name"] for m in c["methods"]],
                    "method_pointers": {
                        m["name"]: m.get("pointer", "")
                        for m in c["methods"]
                        if m.get("pointer")
                    },
                    "fields": c["fields"],
                    "va": c["va"],
                }
                for c in sorted(types, key=lambda x: x["name"])
            ]
            for ns, types in sorted(types_by_ns.items())
        },
    }

    json_path = args.output_json or os.path.join(output_dir, "precise_dump.json")
    cs_path = args.output_cs or os.path.join(output_dir, "precise_dump.cs")

    os.makedirs(os.path.dirname(json_path) or output_dir, exist_ok=True)
    os.makedirs(os.path.dirname(cs_path) or output_dir, exist_ok=True)

    print(f"\n[+] Writing {json_path}...")
    with open(json_path, "w", encoding="utf-8") as f:
        json.dump(json_out, f, indent=2, ensure_ascii=False)
    print(f"    {os.path.getsize(json_path) / 1024 / 1024:.1f}MB")

    # Phase 5: C# stubs
    print(f"[+] Writing {cs_path}...")
    cs = generate_cs_stub(types_by_ns)
    with open(cs_path, "w", encoding="utf-8") as f:
        f.write(cs)
    line_count = cs.count("\n") + 1
    print(f"    {line_count} lines ({os.path.getsize(cs_path) / 1024 / 1024:.1f}MB)")

    print("\n[+] Done!")


if __name__ == "__main__":
    main()
