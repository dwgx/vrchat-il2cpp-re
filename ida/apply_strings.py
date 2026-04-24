"""
IDA Pro Script: Apply String Reference Comments
=================================================

Usage:
  1. Open GameAssembly.dll (ga_analysis.i64) in IDA Pro
  2. File -> Script File... -> select this script
     OR in IDA Python console: exec(open(r"D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools/ida/apply_strings.py").read())

What it does:
  - Loads ida_string_refs.json (140,744 string cross-references across 39,161 functions)
  - Adds repeatable comments to functions listing the strings they reference
  - Helps identify function purposes from their string usage patterns
  - Optionally adds inline comments at function entry points

Data files expected (relative to this script):
  ../output/ida_string_refs.json    - 140K string cross-references

Notes:
  - String ref addresses in the JSON are RVAs relative to IDA image base 0x180000000
  - The JSON was extracted from the same IDA database, so addresses match directly
  - Comments are truncated to avoid overwhelming the disassembly
  - Safe to run multiple times (checks for existing comments)
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

STRING_REFS_PATH = os.path.join(BASE_DIR, "output", "ida_string_refs.json")

# IDA's image base
IDA_IMAGE_BASE = idaapi.get_imagebase()

# Maximum number of strings to show in a function comment
MAX_STRINGS_PER_COMMENT = 15

# Maximum total comment length per function
MAX_COMMENT_LENGTH = 1000

# Truncate individual strings longer than this
MAX_STRING_DISPLAY_LENGTH = 80

# Whether to add anterior (pre-function) comments in addition to func comments
ADD_ANTERIOR_COMMENTS = False

# Comment tag to identify our comments and avoid duplicates
COMMENT_TAG = "[StringRefs]"

# Maximum functions to process (0 = unlimited)
MAX_FUNCTIONS = 0

# ---------------------------------------------------------------------------
# Helpers
# ---------------------------------------------------------------------------

def log(msg):
    print("[ApplyStrings] " + msg)

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

def truncate_string(s, max_len):
    """Truncate a string for display."""
    if len(s) <= max_len:
        return s
    return s[:max_len - 3] + "..."

def categorize_strings(strings):
    """
    Categorize strings to help identify function purpose.
    Returns a dict of { category: [strings] }.
    """
    categories = {
        "error":    [],
        "log":      [],
        "network":  [],
        "ui":       [],
        "api":      [],
        "path":     [],
        "config":   [],
        "other":    [],
    }

    for s in strings:
        sl = s.lower()
        if any(kw in sl for kw in ['error', 'exception', 'fail', 'invalid', 'cannot', 'unable']):
            categories["error"].append(s)
        elif any(kw in sl for kw in ['log', 'debug', 'warn', 'info', 'trace', 'verbose']):
            categories["log"].append(s)
        elif any(kw in sl for kw in ['http', 'url', 'api/', 'endpoint', 'request', 'response', 'socket', 'photon']):
            categories["network"].append(s)
        elif any(kw in sl for kw in ['button', 'text', 'label', 'menu', 'panel', 'screen', 'dialog', 'popup', 'ui']):
            categories["ui"].append(s)
        elif any(kw in sl for kw in ['api.vrchat', 'users/', 'worlds/', 'avatars/', 'friends/']):
            categories["api"].append(s)
        elif any(kw in sl for kw in ['/', '\\', '.dll', '.json', '.txt', '.asset', '.prefab']):
            categories["path"].append(s)
        elif any(kw in sl for kw in ['config', 'setting', 'option', 'pref', 'param']):
            categories["config"].append(s)
        else:
            categories["other"].append(s)

    # Remove empty categories
    return {k: v for k, v in categories.items() if v}


# ---------------------------------------------------------------------------
# Main application
# ---------------------------------------------------------------------------

def apply_string_refs():
    t_start = time.time()
    log("=" * 60)
    log("Starting string reference application")
    log("IDA image base: 0x%X" % IDA_IMAGE_BASE)
    log("=" * 60)

    data = load_json(STRING_REFS_PATH, "ida_string_refs")
    if not data:
        log("ERROR: Could not load string refs. Cannot proceed.")
        return

    # Parse metadata
    json_ida_base = data.get("ida_base", "0x180000000")
    json_dll_base = data.get("dll_base", "")
    total_functions = data.get("total_functions", 0)
    total_string_refs = data.get("total_string_refs", 0)
    function_strings = data.get("function_strings", {})

    json_ida_base_int = int(json_ida_base, 16)

    log("String refs data:")
    log("  IDA base in JSON: 0x%X" % json_ida_base_int)
    log("  Current IDA base: 0x%X" % IDA_IMAGE_BASE)
    log("  Functions with strings: %d" % len(function_strings))
    log("  Total string refs: %d" % total_string_refs)

    # The JSON stores function addresses as RVAs (offsets from ida_base).
    # To get the IDA VA we compute: ida_va = IDA_IMAGE_BASE + rva
    # If the database was rebased, the rebase delta is folded in automatically.
    rebase_delta = IDA_IMAGE_BASE - json_ida_base_int
    if rebase_delta != 0:
        log("  Rebase delta: 0x%X (adjusting addresses)" % rebase_delta)
    else:
        log("  No rebase needed (bases match)")

    # Process functions
    applied = 0
    skipped_existing = 0
    skipped_no_func = 0
    processed = 0
    total = len(function_strings)

    idaapi.show_wait_box("Applying string reference comments...")
    try:
        for addr_str, strings in function_strings.items():
            if idaapi.user_cancelled():
                log("Cancelled by user.")
                break

            processed += 1
            if MAX_FUNCTIONS > 0 and processed > MAX_FUNCTIONS:
                break

            if processed % 5000 == 0:
                log("  Progress: %d / %d functions..." % (processed, total))
                idaapi.replace_wait_box("String refs: %d / %d..." % (processed, total))

            # Parse address (RVA from JSON ida_base)
            try:
                rva = int(addr_str, 16)
            except ValueError:
                continue

            # Convert RVA to IDA VA: add the original base, then apply rebase delta
            ida_addr = json_ida_base_int + rva + rebase_delta

            # Verify this is a valid function
            func = idaapi.get_func(ida_addr)
            if func is None:
                skipped_no_func += 1
                continue

            func_start = func.start_ea

            # Check for existing string ref comment
            existing_cmt = idc.get_func_cmt(func_start, 1) or ""
            if COMMENT_TAG in existing_cmt:
                skipped_existing += 1
                continue

            if not strings:
                continue

            # Build the comment
            # Categorize strings for better readability
            categories = categorize_strings(strings)

            comment_lines = [COMMENT_TAG]

            # Show count summary
            comment_lines.append("%d string refs:" % len(strings))

            # Show categorized strings (prioritize informative ones)
            shown = 0
            priority_order = ["api", "network", "error", "config", "path", "ui", "log", "other"]

            for cat in priority_order:
                if cat not in categories:
                    continue
                cat_strings = categories[cat]
                for s in cat_strings:
                    if shown >= MAX_STRINGS_PER_COMMENT:
                        break
                    display = truncate_string(s, MAX_STRING_DISPLAY_LENGTH)
                    comment_lines.append('  [%s] "%s"' % (cat, display))
                    shown += 1
                if shown >= MAX_STRINGS_PER_COMMENT:
                    remaining = len(strings) - shown
                    if remaining > 0:
                        comment_lines.append("  ... and %d more" % remaining)
                    break

            comment = "\n".join(comment_lines)

            # Truncate if too long
            if len(comment) > MAX_COMMENT_LENGTH:
                comment = comment[:MAX_COMMENT_LENGTH - 20] + "\n  ... (truncated)"

            # Apply the comment
            if existing_cmt:
                full_comment = existing_cmt + "\n" + comment
            else:
                full_comment = comment

            idc.set_func_cmt(func_start, full_comment, 1)

            # Optionally add anterior comment (visible before the function)
            if ADD_ANTERIOR_COMMENTS and len(strings) >= 3:
                # Just show a brief summary as anterior
                brief = "// StringRefs[%d]: %s" % (
                    len(strings),
                    ", ".join(truncate_string(s, 30) for s in strings[:3])
                )
                if len(strings) > 3:
                    brief += " ..."
                # Check if anterior already set
                existing_ant = idc.get_extra_cmt(func_start, idc.E_PREV)
                if not existing_ant or COMMENT_TAG not in existing_ant:
                    idc.set_extra_cmt(func_start, 0, brief)

            applied += 1

    finally:
        idaapi.hide_wait_box()

    # --- Statistics on string content ---
    log("")
    log("--- String content analysis ---")
    all_strings = []
    for strings in function_strings.values():
        all_strings.extend(strings)
    categories = categorize_strings(all_strings)
    for cat, cat_strings in sorted(categories.items(), key=lambda x: -len(x[1])):
        log("  %-10s: %d strings" % (cat, len(cat_strings)))

    # Summary
    elapsed = time.time() - t_start
    log("")
    log("=" * 60)
    log("SUMMARY")
    log("  Functions with comments: %d" % applied)
    log("  Skipped (existing):      %d" % skipped_existing)
    log("  Skipped (no function):   %d" % skipped_no_func)
    log("  Total processed:         %d" % processed)
    log("  Time elapsed:            %.1f seconds" % elapsed)
    log("=" * 60)
    log("")
    log("TIP: Save the IDA database (Ctrl+W) to preserve changes.")


# ---------------------------------------------------------------------------
# Entry point
# ---------------------------------------------------------------------------

if __name__ == "__main__":
    apply_string_refs()
else:
    apply_string_refs()
