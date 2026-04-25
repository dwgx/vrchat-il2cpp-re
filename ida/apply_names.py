"""
IDA Pro Script: Apply Deobfuscated Names to GameAssembly.dll
=============================================================

Usage:
  1. Open GameAssembly.dll (ga_analysis.i64) in IDA Pro
  2. File -> Script File... -> select this script
     OR in IDA Python console: exec(open(r"D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools/ida/apply_names.py").read())

What it does:
  - Loads name_mapping.json (obfuscated -> deobfuscated names)
  - Loads precise_dump.json / deobfuscated_dump.json for method pointers (RVA)
  - Renames functions at known addresses to "ClassName::MethodName" format
  - Sets repeatable comments with original obfuscated names
  - Falls back to scanning IDA function names for obfuscated patterns

Data files expected (relative to this script):
  ../output/name_mapping.json       - 5,562 classes, 59,849 methods, 8,099 fields
  ../data/precise_dump.json         - method pointers (runtime VA)
  ../output/deobfuscated_dump.json  - deobfuscated method pointers

Notes:
  - Runtime DLL base: 0x7FFB4D2AA000  |  IDA image base: 0x180000000
  - method_pointers in dumps are runtime VA; this script converts to IDA VA
  - Safe to run multiple times (idempotent)
  - Progress printed to IDA Output window
"""

import os
import sys
import json
import time
import re

import idc
import idaapi
import idautils

# ---------------------------------------------------------------------------
# Configuration
# ---------------------------------------------------------------------------

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__)) if '__file__' in dir() else os.path.dirname(idc.get_idb_path())
BASE_DIR = os.path.normpath(os.path.join(SCRIPT_DIR, ".."))

NAME_MAPPING_PATH   = os.path.join(BASE_DIR, "output", "name_mapping.json")
PRECISE_DUMP_PATH   = os.path.join(BASE_DIR, "data", "precise_dump.json")
DEOBF_DUMP_PATH     = os.path.join(BASE_DIR, "output", "deobfuscated_dump.json")

# Runtime base address where GameAssembly.dll was loaded during dump extraction
RUNTIME_DLL_BASE = 0x7FFB55420000

# IDA's image base for the loaded binary
IDA_IMAGE_BASE = idaapi.get_imagebase()

# Maximum number of functions to process (0 = unlimited)
MAX_FUNCTIONS = 0

# Whether to add comments with original obfuscated names
ADD_OBFUSCATED_COMMENTS = True

# Whether to rename functions that already have meaningful names
OVERWRITE_EXISTING_NAMES = False

# ---------------------------------------------------------------------------
# Helpers
# ---------------------------------------------------------------------------

def log(msg):
    """Print to IDA output window."""
    print("[ApplyNames] " + msg)

def is_obfuscated_name(name):
    """Check if a name looks like an IL2CPP obfuscated name (Unicode garbage)."""
    if not name:
        return False
    # Obfuscated names use characters in the range U+00CC - U+00CF (accented I variants)
    obf_chars = set('\u00cc\u00cd\u00ce\u00cf')
    clean = name.strip()
    if not clean:
        return False
    # A name is obfuscated if it consists primarily of these characters
    obf_count = sum(1 for c in clean if c in obf_chars)
    return obf_count >= 10 and (obf_count / len(clean)) > 0.8

def is_auto_name(name):
    """Check if a name is IDA's auto-generated name (sub_xxx, loc_xxx, etc.)."""
    if not name:
        return True
    return bool(re.match(r'^(sub_|loc_|unk_|byte_|word_|dword_|qword_|off_|seg_|asc_|stru_|j_)', name))

def sanitize_ida_name(name):
    """
    Sanitize a name for use as an IDA identifier.
    IDA allows: letters, digits, underscore, and a few special chars.
    """
    # Replace common problematic characters
    result = name.replace("::", "__")
    result = result.replace(".", "_")
    result = result.replace("<", "_")
    result = result.replace(">", "_")
    result = result.replace(",", "_")
    result = result.replace(" ", "_")
    result = result.replace("-", "_")
    result = result.replace("/", "_")
    result = result.replace("(", "_")
    result = result.replace(")", "_")
    result = result.replace("[", "_")
    result = result.replace("]", "_")
    result = result.replace("`", "_")
    result = result.replace("$", "_")
    # Remove any remaining non-ASCII characters
    result = ''.join(c if (c.isalnum() or c == '_') else '_' for c in result)
    # Collapse multiple underscores
    while '__' in result:
        result = result.replace('__', '_')
    # Strip leading/trailing underscores
    result = result.strip('_')
    # Ensure it doesn't start with a digit
    if result and result[0].isdigit():
        result = '_' + result
    # Truncate if too long (IDA max is ~511 but let's be safe)
    if len(result) > 400:
        result = result[:400]
    return result

def runtime_va_to_ida_va(runtime_va):
    """Convert a runtime virtual address to an IDA virtual address."""
    if isinstance(runtime_va, str):
        runtime_va = int(runtime_va, 16)
    rva = runtime_va - RUNTIME_DLL_BASE
    if rva < 0:
        return None
    return IDA_IMAGE_BASE + rva

def load_json(path, description):
    """Load a JSON file with error handling."""
    if not os.path.exists(path):
        log("WARNING: %s not found at %s" % (description, path))
        return None
    log("Loading %s from %s ..." % (description, os.path.basename(path)))
    t0 = time.time()
    try:
        with open(path, 'r', encoding='utf-8') as f:
            data = json.load(f)
        elapsed = time.time() - t0
        log("  Loaded in %.1f seconds" % elapsed)
        return data
    except Exception as e:
        log("ERROR loading %s: %s" % (description, str(e)))
        return None

# ---------------------------------------------------------------------------
# Phase 1: Build address -> name mapping from dumps
# ---------------------------------------------------------------------------

def build_address_map(precise_dump, deobf_dump, name_mapping):
    """
    Build a dict of { ida_va: (class_name, method_name, obf_class, obf_method) }
    from the dump data and name mapping.
    """
    addr_map = {}
    class_map = name_mapping.get("classes", {}) if name_mapping else {}
    method_map = name_mapping.get("methods", {}) if name_mapping else {}
    reverse_classes = name_mapping.get("reverse_classes", {}) if name_mapping else {}

    # Use deobfuscated dump as primary source (already has deobf names applied)
    dump = deobf_dump or precise_dump
    if not dump:
        return addr_map

    namespaces = dump.get("namespaces", {})
    total_types = 0
    total_methods = 0

    for ns_name, types in namespaces.items():
        for type_info in types:
            type_name = type_info.get("name", "")
            namespace = type_info.get("namespace", "")
            method_pointers = type_info.get("method_pointers", {})

            if not method_pointers:
                continue

            total_types += 1

            # Build the full qualified name
            if namespace:
                full_class = "%s.%s" % (namespace, type_name)
            else:
                full_class = type_name

            # Determine the original obfuscated class name
            obf_class = reverse_classes.get(type_name, "")

            for method_name, ptr_str in method_pointers.items():
                ida_va = runtime_va_to_ida_va(ptr_str)
                if ida_va is None:
                    continue

                # Build the function name
                # Determine original obfuscated method name
                obf_method = ""
                lookup_key = "%s::%s" % (type_name, method_name)
                # Check if the method name itself is a deobfuscated placeholder
                for obf_k, deobf_v in method_map.items():
                    if deobf_v == method_name and obf_k.startswith(type_name + "::"):
                        obf_method = obf_k.split("::", 1)[1]
                        break

                # Skip dummy/invalid addresses
                func = idaapi.get_func(ida_va)
                if func is None:
                    # Address might not be recognized as a function start
                    continue

                func_start = func.start_ea
                if func_start != ida_va:
                    # Pointer is into the middle of a function, skip
                    continue

                addr_map[ida_va] = (full_class, method_name, obf_class, obf_method)
                total_methods += 1

    log("  Built address map: %d methods across %d types" % (total_methods, total_types))
    return addr_map


# ---------------------------------------------------------------------------
# Phase 2: Build obfuscated function name lookup
# ---------------------------------------------------------------------------

def build_name_scan_map(name_mapping):
    """
    Build a mapping for scanning IDA function names that contain obfuscated tokens.
    Returns { obfuscated_class: deobf_class, ... } and method lookup helpers.
    """
    class_map = name_mapping.get("classes", {}) if name_mapping else {}
    method_map = name_mapping.get("methods", {}) if name_mapping else {}
    return class_map, method_map


# ---------------------------------------------------------------------------
# Phase 3: Apply names
# ---------------------------------------------------------------------------

def apply_names():
    """Main entry point."""
    t_start = time.time()
    log("=" * 60)
    log("Starting name application")
    log("IDA image base: 0x%X" % IDA_IMAGE_BASE)
    log("Runtime DLL base: 0x%X" % RUNTIME_DLL_BASE)
    log("=" * 60)

    # Load data files
    name_mapping = load_json(NAME_MAPPING_PATH, "name_mapping")
    precise_dump = load_json(PRECISE_DUMP_PATH, "precise_dump")
    deobf_dump = load_json(DEOBF_DUMP_PATH, "deobfuscated_dump")

    if not name_mapping and not precise_dump and not deobf_dump:
        log("ERROR: No data files loaded. Cannot proceed.")
        return

    # --- Phase 1: Address-based renaming (most accurate) ---
    log("")
    log("--- Phase 1: Address-based renaming ---")
    addr_map = build_address_map(precise_dump, deobf_dump, name_mapping)

    renamed_addr = 0
    skipped_addr = 0
    commented_addr = 0

    idaapi.show_wait_box("Applying names (Phase 1: address-based)...")
    try:
        for ida_va, (full_class, method_name, obf_class, obf_method) in addr_map.items():
            if idaapi.user_cancelled():
                log("Cancelled by user.")
                break

            current_name = idc.get_func_name(ida_va)
            if not current_name:
                current_name = idc.get_name(ida_va)

            # Build the new name
            new_name = sanitize_ida_name("%s__%s" % (full_class, method_name))
            if not new_name:
                continue

            # Decide whether to rename
            should_rename = True
            if current_name and not OVERWRITE_EXISTING_NAMES:
                # Don't overwrite if it already has a meaningful name that isn't auto-generated
                if not is_auto_name(current_name) and not is_obfuscated_name(current_name):
                    should_rename = False
                    skipped_addr += 1

            if should_rename:
                # Try to set the name; if it conflicts, append address suffix
                if not idc.set_name(ida_va, new_name, idc.SN_NOWARN | idc.SN_NOCHECK):
                    # Name conflict - append address
                    new_name_with_addr = "%s_%X" % (new_name, ida_va & 0xFFFF)
                    if not idc.set_name(ida_va, new_name_with_addr, idc.SN_NOWARN | idc.SN_NOCHECK):
                        skipped_addr += 1
                        continue
                    new_name = new_name_with_addr
                renamed_addr += 1

            # Add comment with original obfuscated name and full signature
            if ADD_OBFUSCATED_COMMENTS:
                comment_parts = []
                comment_parts.append("[IL2CPP] %s::%s" % (full_class, method_name))
                if obf_class:
                    comment_parts.append("Obf class: %s" % obf_class)
                if obf_method:
                    comment_parts.append("Obf method: %s" % obf_method)
                comment = " | ".join(comment_parts)

                existing_cmt = idc.get_func_cmt(ida_va, 1) or ""
                if "[IL2CPP]" not in existing_cmt:
                    idc.set_func_cmt(ida_va, comment, 1)  # 1 = repeatable comment
                    commented_addr += 1

            if renamed_addr % 5000 == 0 and renamed_addr > 0:
                log("  Progress: %d renamed, %d skipped..." % (renamed_addr, skipped_addr))
                idaapi.replace_wait_box("Phase 1: %d renamed..." % renamed_addr)

    finally:
        idaapi.hide_wait_box()

    log("  Phase 1 complete: %d renamed, %d skipped, %d commented" % (renamed_addr, skipped_addr, commented_addr))

    # --- Phase 2: Name-pattern scanning for remaining obfuscated names ---
    log("")
    log("--- Phase 2: Pattern-based renaming (scanning IDA function names) ---")
    class_map, method_map = build_name_scan_map(name_mapping)

    renamed_scan = 0
    scanned = 0
    total_funcs = len(list(idautils.Functions()))

    idaapi.show_wait_box("Applying names (Phase 2: pattern scan)...")
    try:
        for func_ea in idautils.Functions():
            if idaapi.user_cancelled():
                log("Cancelled by user.")
                break

            scanned += 1
            if MAX_FUNCTIONS > 0 and scanned > MAX_FUNCTIONS:
                break

            if scanned % 50000 == 0:
                log("  Scanned %d / %d functions..." % (scanned, total_funcs))
                idaapi.replace_wait_box("Phase 2: scanned %d / %d..." % (scanned, total_funcs))

            # Skip if already renamed in Phase 1
            if func_ea in addr_map:
                continue

            current_name = idc.get_func_name(func_ea)
            if not current_name:
                continue

            # Check if the function name contains obfuscated tokens
            # IDA sometimes shows names like "ClassName::MethodName" or mangled variants
            # Look for obfuscated class names in the current function name
            best_match = None
            for obf_class, deobf_class in class_map.items():
                if obf_class in current_name:
                    new_name = current_name.replace(obf_class, deobf_class)
                    best_match = (obf_class, deobf_class, new_name)
                    break

            if best_match:
                obf_class, deobf_class, new_name = best_match
                new_name = sanitize_ida_name(new_name)
                if new_name and new_name != current_name:
                    if idc.set_name(func_ea, new_name, idc.SN_NOWARN | idc.SN_NOCHECK):
                        renamed_scan += 1
                        if ADD_OBFUSCATED_COMMENTS:
                            comment = "[IL2CPP-scan] Original: %s" % current_name
                            existing_cmt = idc.get_func_cmt(func_ea, 1) or ""
                            if "[IL2CPP" not in existing_cmt:
                                idc.set_func_cmt(func_ea, comment, 1)

    finally:
        idaapi.hide_wait_box()

    log("  Phase 2 complete: %d renamed out of %d scanned" % (renamed_scan, scanned))

    # --- Summary ---
    elapsed = time.time() - t_start
    log("")
    log("=" * 60)
    log("SUMMARY")
    log("  Address-based renames: %d" % renamed_addr)
    log("  Pattern-scan renames:  %d" % renamed_scan)
    log("  Total renamed:         %d" % (renamed_addr + renamed_scan))
    log("  Total comments added:  %d" % commented_addr)
    log("  Time elapsed:          %.1f seconds" % elapsed)
    log("=" * 60)
    log("")
    log("TIP: Save the IDA database (Ctrl+W) to preserve changes.")


# ---------------------------------------------------------------------------
# Entry point
# ---------------------------------------------------------------------------

if __name__ == "__main__":
    apply_names()
else:
    # When loaded via File -> Script File
    apply_names()
