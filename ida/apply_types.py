"""
IDA Pro 9.2 Script: Apply IL2CPP Type/Struct Definitions
=========================================================

Usage:
  1. Open GameAssembly.dll (ga_analysis.i64) in IDA Pro 9.2
  2. File -> Script File... -> select this script
     OR: exec(open(r"D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools/ida/apply_types.py", encoding="utf-8").read())

What it does:
  - Loads deobfuscated_dump.json (42,548 types with fields and methods)
  - Creates struct types in IDA's Local Types via parse_decl (IDA 9.2 compatible)
  - Sets function prototypes where method signatures are available
  - Creates enum types for C# enums

Notes:
  - Uses ida_typeinf.parse_decl + set_named_type (ida_struct removed in IDA 9.x)
  - Runtime base auto-detected from method pointers (ASLR safe)
  - Fields use dict format: {name, type, offset} from merge_field_types
  - Safe to run multiple times (checks for existing types)
"""

import os
import sys
import json
import time
import re

import idc
import idaapi
import idautils
import ida_typeinf
import ida_name

# ---------------------------------------------------------------------------
# Configuration
# ---------------------------------------------------------------------------

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__)) if '__file__' in dir() else os.path.dirname(idc.get_idb_path())
BASE_DIR = os.path.normpath(os.path.join(SCRIPT_DIR, ".."))

DEOBF_DUMP_PATH = os.path.join(BASE_DIR, "output", "deobfuscated_dump.json")

IDA_IMAGE_BASE = idaapi.get_imagebase()
RUNTIME_DLL_BASE = None  # auto-detected

PTR_SIZE = 8
IL2CPP_OBJECT_HEADER_SIZE = PTR_SIZE * 2

MAX_TYPES = 0
MIN_FIELDS_FOR_STRUCT = 1

# ---------------------------------------------------------------------------
# C# type -> C type mapping for struct field declarations
# ---------------------------------------------------------------------------

CSHARP_TO_C_TYPE = {
    "System.Boolean": "char",    "bool": "char",     "Boolean": "char",
    "System.Byte": "unsigned char", "byte": "unsigned char", "Byte": "unsigned char",
    "System.SByte": "char",     "sbyte": "char",    "SByte": "char",
    "System.Int16": "short",    "short": "short",   "Int16": "short",
    "System.UInt16": "unsigned short", "ushort": "unsigned short", "UInt16": "unsigned short",
    "System.Char": "unsigned short",   "char": "unsigned short", "Char": "unsigned short",
    "System.Int32": "int",      "int": "int",       "Int32": "int",
    "System.UInt32": "unsigned int",   "uint": "unsigned int", "UInt32": "unsigned int",
    "System.Single": "float",   "float": "float",   "Single": "float",
    "System.Int64": "__int64",  "long": "__int64",  "Int64": "__int64",
    "System.UInt64": "unsigned __int64", "ulong": "unsigned __int64", "UInt64": "unsigned __int64",
    "System.Double": "double",  "double": "double",  "Double": "double",
    "System.IntPtr": "__int64", "IntPtr": "__int64",
    "System.UIntPtr": "unsigned __int64", "UIntPtr": "unsigned __int64",
}

CSHARP_TYPE_SIZES = {
    "System.Boolean": 1,  "bool": 1,   "Boolean": 1,
    "System.Byte": 1,     "byte": 1,   "Byte": 1,
    "System.SByte": 1,    "sbyte": 1,  "SByte": 1,
    "System.Int16": 2,    "short": 2,  "Int16": 2,
    "System.UInt16": 2,   "ushort": 2, "UInt16": 2,
    "System.Char": 2,     "char": 2,   "Char": 2,
    "System.Int32": 4,    "int": 4,    "Int32": 4,
    "System.UInt32": 4,   "uint": 4,   "UInt32": 4,
    "System.Single": 4,   "float": 4,  "Single": 4,
    "System.Int64": 8,    "long": 8,   "Int64": 8,
    "System.UInt64": 8,   "ulong": 8,  "UInt64": 8,
    "System.Double": 8,   "double": 8, "Double": 8,
    "System.IntPtr": 8,   "IntPtr": 8,
    "System.UIntPtr": 8,  "UIntPtr": 8,
}

# ---------------------------------------------------------------------------
# Helpers
# ---------------------------------------------------------------------------

def log(msg):
    print("[ApplyTypes] " + msg)

def auto_detect_runtime_base(deobf_dump):
    global RUNTIME_DLL_BASE
    all_vas = []
    for ns, classes in deobf_dump.get("namespaces", {}).items():
        for cls in classes:
            for ptr_str in cls.get("method_pointers", {}).values():
                if not ptr_str or not isinstance(ptr_str, str):
                    continue
                try:
                    va = int(ptr_str, 16) if ptr_str.startswith("0x") else int(ptr_str)
                except (ValueError, TypeError):
                    continue
                if va > 0x7FF000000000:
                    all_vas.append(va)

    if not all_vas:
        log("WARNING: No method pointers found, using fallback base")
        RUNTIME_DLL_BASE = 0x7FFB55420000
        return

    sorted_vas = sorted(all_vas)
    min_va = sorted_vas[0]

    seg = idaapi.getseg(IDA_IMAGE_BASE + 0x1000)
    text_start_rva = (seg.start_ea - IDA_IMAGE_BASE) if seg else 0x1000
    runtime_base = ((min_va - text_start_rva) // 0x10000) * 0x10000

    test_va = sorted_vas[len(sorted_vas) // 2]
    test_ea = test_va - runtime_base + IDA_IMAGE_BASE
    if not idaapi.get_func(test_ea):
        for adj in range(-16, 17):
            candidate = runtime_base + adj * 0x10000
            test_ea2 = test_va - candidate + IDA_IMAGE_BASE
            if idaapi.get_func(test_ea2):
                runtime_base = candidate
                break

    RUNTIME_DLL_BASE = runtime_base
    log("Auto-detected runtime base: 0x%X" % RUNTIME_DLL_BASE)

def runtime_va_to_ida_va(runtime_va):
    if isinstance(runtime_va, str):
        runtime_va = int(runtime_va, 16)
    rva = runtime_va - RUNTIME_DLL_BASE
    if rva < 0:
        return None
    return IDA_IMAGE_BASE + rva

def load_json(path, description):
    if not os.path.exists(path):
        log("WARNING: %s not found at %s" % (description, path))
        return None
    log("Loading %s ..." % description)
    t0 = time.time()
    try:
        with open(path, 'r', encoding='utf-8') as f:
            data = json.load(f)
        log("  Loaded in %.1f seconds" % (time.time() - t0))
        return data
    except Exception as e:
        log("ERROR loading %s: %s" % (description, str(e)))
        return None

def sanitize_name(name):
    """Make a name safe for IDA C declarations."""
    result = re.sub(r'[^a-zA-Z0-9_]', '_', name)
    while '__' in result:
        result = result.replace('__', '_')
    result = result.strip('_')
    if result and result[0].isdigit():
        result = '_' + result
    if len(result) > 200:
        result = result[:200]
    return result if result else "unknown"

def get_c_type_for_field(field_type_str, field_name):
    """Map C# type to C type for struct declaration."""
    if field_type_str and field_type_str != "err":
        c_type = CSHARP_TO_C_TYPE.get(field_type_str)
        if c_type:
            return c_type
    # Heuristic fallback based on name
    name_lower = field_name.lower()
    if any(p in name_lower for p in ['is_', 'has_', 'can_', 'should_', 'enable', 'active', 'visible']):
        return "char"
    if any(p in name_lower for p in ['count', 'index', 'size', 'length', 'num_', 'id']):
        return "int"
    if any(p in name_lower for p in ['time', 'speed', 'scale', 'alpha', 'ratio', 'distance', 'radius']):
        return "float"
    return "__int64"  # default: pointer/reference

# ---------------------------------------------------------------------------
# Phase 1: Create struct types via parse_decl (IDA 9.2)
# ---------------------------------------------------------------------------

def create_structs(deobf_dump):
    if not deobf_dump:
        return 0

    til = ida_typeinf.get_idati()
    namespaces = deobf_dump.get("namespaces", {})
    created = 0
    skipped = 0
    errors = 0
    processed = 0

    idaapi.show_wait_box("Creating struct types...")
    try:
        for ns_name, types in namespaces.items():
            for type_info in types:
                if idaapi.user_cancelled():
                    log("Cancelled by user.")
                    return created

                processed += 1
                if MAX_TYPES > 0 and processed > MAX_TYPES:
                    return created

                type_name = type_info.get("name", "")
                fields = type_info.get("fields", [])
                parent = type_info.get("parent", "")

                if len(fields) < MIN_FIELDS_FOR_STRUCT:
                    continue

                # Build struct name
                if ns_name:
                    struct_name = "il2cpp_%s_%s" % (sanitize_name(ns_name), sanitize_name(type_name))
                else:
                    struct_name = "il2cpp_%s" % sanitize_name(type_name)

                if not struct_name or struct_name == "il2cpp_":
                    continue

                # Check if already exists in local types
                check_tif = ida_typeinf.tinfo_t()
                if check_tif.get_named_type(til, struct_name):
                    skipped += 1
                    continue

                is_value_type = (parent in ("ValueType", "Enum"))

                # Build C struct declaration
                member_lines = []
                field_names_seen = set()

                if not is_value_type:
                    member_lines.append("  __int64 il2cpp_klass;")
                    member_lines.append("  __int64 il2cpp_monitor;")

                for field_raw in fields:
                    if isinstance(field_raw, dict):
                        raw_name = field_raw.get("name", "unknown")
                        field_type_str = field_raw.get("type", "")
                    else:
                        raw_name = str(field_raw)
                        field_type_str = ""

                    field_name = sanitize_name(raw_name)
                    if not field_name:
                        field_name = "field"

                    # Deduplicate
                    if field_name in field_names_seen:
                        suffix = 2
                        while ("%s_%d" % (field_name, suffix)) in field_names_seen:
                            suffix += 1
                        field_name = "%s_%d" % (field_name, suffix)
                    field_names_seen.add(field_name)

                    c_type = get_c_type_for_field(field_type_str, field_name)
                    member_lines.append("  %s %s;" % (c_type, field_name))

                if not member_lines:
                    continue

                decl = "struct %s { %s };" % (struct_name, " ".join(member_lines))

                tif = ida_typeinf.tinfo_t()
                result = ida_typeinf.parse_decl(tif, til, decl, ida_typeinf.PT_SIL)

                if result is not None:
                    ret = tif.set_named_type(til, struct_name)
                    if ret == 0:
                        created += 1
                    else:
                        errors += 1
                else:
                    errors += 1

                if created % 1000 == 0 and created > 0:
                    log("  Created %d structs (skipped %d, errors %d)..." % (created, skipped, errors))
                    idaapi.replace_wait_box("Creating structs: %d done..." % created)

    finally:
        idaapi.hide_wait_box()

    log("  Struct creation: %d created, %d skipped (existing), %d errors" % (created, skipped, errors))
    return created


# ---------------------------------------------------------------------------
# Phase 2: Apply function prototypes
# ---------------------------------------------------------------------------

def apply_function_prototypes(deobf_dump):
    if not deobf_dump:
        return 0

    til = ida_typeinf.get_idati()
    namespaces = deobf_dump.get("namespaces", {})
    applied = 0
    processed = 0

    idaapi.show_wait_box("Applying function prototypes...")
    try:
        for ns_name, types in namespaces.items():
            for type_info in types:
                if idaapi.user_cancelled():
                    log("Cancelled by user.")
                    return applied

                type_name = type_info.get("name", "")
                namespace = type_info.get("namespace", ns_name)
                method_pointers = type_info.get("method_pointers", {})
                parent = type_info.get("parent", "")

                if not method_pointers:
                    continue

                for method_name, ptr_str in method_pointers.items():
                    processed += 1
                    ida_va = runtime_va_to_ida_va(ptr_str)
                    if ida_va is None:
                        continue

                    func = idaapi.get_func(ida_va)
                    if func is None or func.start_ea != ida_va:
                        continue

                    full_class = "%s.%s" % (namespace, type_name) if namespace else type_name
                    safe_class = sanitize_name(full_class)
                    safe_method = sanitize_name(method_name)

                    is_static = method_name.startswith("op_") or method_name == "cctor"
                    is_ctor = method_name in (".ctor", ".cctor")
                    ret_type = "void" if is_ctor else "__int64"

                    if is_static:
                        proto = "%s __fastcall %s__%s(__int64 method_info)" % (ret_type, safe_class, safe_method)
                    else:
                        proto = "%s __fastcall %s__%s(__int64 __this, __int64 method_info)" % (ret_type, safe_class, safe_method)

                    tinfo = ida_typeinf.tinfo_t()
                    result = ida_typeinf.parse_decl(tinfo, til, proto + ";", ida_typeinf.PT_SIL)

                    if result is not None:
                        if idaapi.apply_tinfo(ida_va, tinfo, idaapi.TINFO_DEFINITE):
                            applied += 1

                    if applied % 5000 == 0 and applied > 0:
                        log("  Applied %d prototypes (processed %d)..." % (applied, processed))
                        idaapi.replace_wait_box("Prototypes: %d applied..." % applied)

    finally:
        idaapi.hide_wait_box()

    log("  Function prototypes: %d applied out of %d processed" % (applied, processed))
    return applied


# ---------------------------------------------------------------------------
# Phase 3: Create enums
# ---------------------------------------------------------------------------

def create_il2cpp_enums(deobf_dump):
    if not deobf_dump:
        return 0

    namespaces = deobf_dump.get("namespaces", {})
    created = 0

    for ns_name, types in namespaces.items():
        for type_info in types:
            if type_info.get("parent") != "Enum":
                continue
            fields = type_info.get("fields", [])
            if len(fields) < 2:
                continue

            type_name = type_info.get("name", "")
            if ns_name:
                enum_name = "il2cpp_enum_%s_%s" % (sanitize_name(ns_name), sanitize_name(type_name))
            else:
                enum_name = "il2cpp_enum_%s" % sanitize_name(type_name)

            eid = idc.get_enum(enum_name)
            if eid != idaapi.BADADDR:
                continue

            eid = idc.add_enum(idaapi.BADADDR, enum_name, 0)
            if eid == idaapi.BADADDR:
                continue

            val = 0
            for field in fields:
                if isinstance(field, dict):
                    field_str = field.get("name", "")
                else:
                    field_str = str(field)
                if field_str == "value__":
                    continue
                member_name = sanitize_name(field_str)
                full_member = "%s_%s" % (sanitize_name(type_name), member_name)
                ret = idc.add_enum_member(eid, full_member, val, idaapi.BADADDR)
                if ret == 0:
                    val += 1
                else:
                    full_member = "%s_%s_%d" % (sanitize_name(type_name), member_name, val)
                    idc.add_enum_member(eid, full_member, val, idaapi.BADADDR)
                    val += 1

            created += 1

    log("  Enums created: %d" % created)
    return created


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def apply_types():
    t_start = time.time()
    log("=" * 60)
    log("Starting type application (IDA 9.2 compatible)")
    log("IDA image base: 0x%X" % IDA_IMAGE_BASE)
    log("=" * 60)

    deobf_dump = load_json(DEOBF_DUMP_PATH, "deobfuscated_dump")
    if not deobf_dump:
        log("ERROR: Could not load deobfuscated dump.")
        return

    summary = deobf_dump.get("summary", {})
    log("Dump: %d types, %d methods, %d fields" % (
        summary.get("total_types", 0),
        summary.get("total_methods", 0),
        summary.get("total_fields", 0)
    ))

    log("")
    log("--- Auto-detecting runtime base ---")
    auto_detect_runtime_base(deobf_dump)

    log("")
    log("--- Phase 1: Creating struct types ---")
    structs_created = create_structs(deobf_dump)

    log("")
    log("--- Phase 2: Creating enum types ---")
    enums_created = create_il2cpp_enums(deobf_dump)

    log("")
    log("--- Phase 3: Applying function prototypes ---")
    protos_applied = apply_function_prototypes(deobf_dump)

    elapsed = time.time() - t_start
    log("")
    log("=" * 60)
    log("SUMMARY")
    log("  Structs created:       %d" % structs_created)
    log("  Enums created:         %d" % enums_created)
    log("  Prototypes applied:    %d" % protos_applied)
    log("  Time elapsed:          %.1f seconds" % elapsed)
    log("=" * 60)
    log("TIP: Save the IDA database (Ctrl+W) to preserve changes.")


if __name__ == "__main__":
    apply_types()
else:
    apply_types()
