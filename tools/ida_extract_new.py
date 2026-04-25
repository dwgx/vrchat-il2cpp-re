"""
IDA Python script for headless string/xref extraction on NEW VRChat build.
Run via: idat.exe -A -S"ida_extract_new.py" <path>\\GameAssembly.dll

Extracts:
- String references per function
- Cross-references (callgraph)
- Function names assigned by IDA auto-analysis
- Hex-Rays pseudocode (best-effort) for strong-class hash targets

Outputs land in: output/v_new_ida/
"""

import idautils
import idaapi
import idc
import json
import os
import sys
import traceback

# Hard-coded output path — project root
PROJECT_ROOT = r"D:\WorkSpace\VRChat\VRChat_Data\il2cpp_dump_tools"
OUTPUT_DIR = os.path.join(PROJECT_ROOT, "output", "v_new_ida")

def get_string_refs(func_ea):
    strings = []
    func = idaapi.get_func(func_ea)
    if not func:
        return strings
    try:
        for head in idautils.Heads(func.start_ea, func.end_ea):
            for xref in idautils.DataRefsFrom(head):
                s = idc.get_strlit_contents(xref)
                if s:
                    try:
                        strings.append(s.decode('utf-8', errors='replace'))
                    except Exception:
                        pass
    except Exception:
        pass
    return list(set(strings))

def get_call_targets(func_ea):
    targets = []
    func = idaapi.get_func(func_ea)
    if not func:
        return targets
    try:
        for head in idautils.Heads(func.start_ea, func.end_ea):
            if idc.print_insn_mnem(head) == 'call':
                for xref in idautils.CodeRefsFrom(head, 0):
                    targets.append(hex(xref))
    except Exception:
        pass
    return list(set(targets))

def try_decompile(func_ea):
    """Best-effort Hex-Rays decompile. Returns None if not available."""
    try:
        import ida_hexrays
        if not ida_hexrays.init_hexrays_plugin():
            return None
        cfunc = ida_hexrays.decompile(func_ea)
        if cfunc is None:
            return None
        return str(cfunc)
    except Exception:
        return None

def main():
    print("[*] IDA Extract NEW: Starting analysis...")
    os.makedirs(OUTPUT_DIR, exist_ok=True)

    idaapi.auto_wait()
    print("[*] Auto-analysis complete")

    result = {
        'functions': {},
        'function_names': {},
    }

    total = 0
    with_strings = 0
    with_name = 0
    fn_list = list(idautils.Functions())
    print(f"[*] Total functions to process: {len(fn_list)}")

    for func_ea in fn_list:
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
            with_name += 1

        if entry:
            result['functions'][addr] = entry

        if total % 10000 == 0:
            print(f"[*] Processed {total}/{len(fn_list)} functions, {with_strings} w/strings, {with_name} w/name")

    print(f"[*] Functions: {total} total, {with_strings} w/strings, {with_name} w/ida_name")

    out_json = os.path.join(OUTPUT_DIR, 'ida_analysis.json')
    with open(out_json, 'w', encoding='utf-8') as f:
        json.dump(result, f, indent=2, ensure_ascii=False)
    print(f"[*] Saved {out_json}")

    print("[*] Attempting Hex-Rays export (incremental save every 5K) ...")
    hexrays_export = {}
    out_hx = os.path.join(OUTPUT_DIR, 'hexrays_export.json')
    # Resume if file exists
    if os.path.exists(out_hx):
        try:
            with open(out_hx, 'r', encoding='utf-8') as f:
                hexrays_export = json.load(f)
            print(f"[*] Resuming with {len(hexrays_export)} already done")
        except Exception:
            hexrays_export = {}

    hx_attempted = 0
    hx_ok = sum(1 for v in hexrays_export.values() if v.get('pseudocode'))
    for func_ea in fn_list:
        hx_attempted += 1
        addr = hex(func_ea)
        if addr in hexrays_export:
            continue
        code = try_decompile(func_ea)
        if code:
            hx_ok += 1
            name = idc.get_func_name(func_ea)
            hexrays_export[addr] = {
                'name': name,
                'pseudocode': code[:8000],
            }
        else:
            hexrays_export[addr] = {'name': '', 'pseudocode': ''}
        if hx_attempted % 5000 == 0:
            with open(out_hx, 'w', encoding='utf-8') as f:
                json.dump(hexrays_export, f, indent=2, ensure_ascii=False)
            print(f"[*] Hex-Rays {hx_attempted}/{len(fn_list)}, {hx_ok} ok (saved)")

    with open(out_hx, 'w', encoding='utf-8') as f:
        json.dump(hexrays_export, f, indent=2, ensure_ascii=False)
    print(f"[*] Saved {out_hx} ({hx_ok} funcs decompiled)")

    print("[*] DONE")
    idc.qexit(0)

if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f"[!] FATAL: {e}")
        traceback.print_exc()
        idc.qexit(1)
