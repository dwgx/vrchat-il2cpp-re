"""
IDA Python script for headless string/xref extraction.
Run via: idat.exe -A -S"ida_extract.py" -o"ga_analysis.idb" GameAssembly.dll

Extracts:
- String references per function
- Cross-references between functions
- Function names assigned by IDA auto-analysis
"""

import idautils
import idaapi
import idc
import json
import os
import sys

OUTPUT_DIR = os.path.join(os.path.dirname(idc.get_idb_path()), "il2cpp_dump_tools", "il2cpp_full_dump")

def get_string_refs(func_ea):
    """Get all string references within a function."""
    strings = []
    func = idaapi.get_func(func_ea)
    if not func:
        return strings

    for head in idautils.Heads(func.start_ea, func.end_ea):
        for xref in idautils.DataRefsFrom(head):
            s = idc.get_strlit_contents(xref)
            if s:
                try:
                    strings.append(s.decode('utf-8', errors='replace'))
                except:
                    pass
    return list(set(strings))

def get_call_targets(func_ea):
    """Get all direct call targets from a function."""
    targets = []
    func = idaapi.get_func(func_ea)
    if not func:
        return targets

    for head in idautils.Heads(func.start_ea, func.end_ea):
        if idc.print_insn_mnem(head) == 'call':
            for xref in idautils.CodeRefsFrom(head, 0):
                targets.append(hex(xref))
    return list(set(targets))

def main():
    print("[*] IDA Extract: Starting analysis...")

    # Wait for auto-analysis to complete
    idaapi.auto_wait()
    print("[*] Auto-analysis complete")

    result = {
        'functions': {},
        'function_names': {},
    }

    total = 0
    with_strings = 0

    for func_ea in idautils.Functions():
        total += 1
        name = idc.get_func_name(func_ea)
        addr = hex(func_ea)

        strings = get_string_refs(func_ea)
        calls = get_call_targets(func_ea)

        entry = {}
        if strings:
            entry['strings'] = strings
            with_strings += 1
        if calls:
            entry['calls'] = calls
        if name and not name.startswith('sub_'):
            entry['ida_name'] = name
            result['function_names'][addr] = name

        if entry:
            result['functions'][addr] = entry

        if total % 10000 == 0:
            print(f"[*] Processed {total} functions, {with_strings} with strings")

    print(f"[*] Total: {total} functions, {with_strings} with strings")

    # Save
    output_path = os.path.join(OUTPUT_DIR, 'ida_analysis.json')
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    with open(output_path, 'w', encoding='utf-8') as f:
        json.dump(result, f, indent=2, ensure_ascii=False)

    print(f"[*] Saved to {output_path}")

    # Exit IDA
    idc.qexit(0)

if __name__ == '__main__':
    main()
