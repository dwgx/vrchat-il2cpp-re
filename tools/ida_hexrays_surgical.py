"""
Surgical Hex-Rays: decompile ONLY a specific list of VAs from data/hexrays_target_vas.json.
Output: output/v_new_ida/hexrays_surgical.json
"""

import idautils
import idaapi
import idc
import ida_hexrays
import json
import os
import traceback

PROJECT_ROOT = r"D:\WorkSpace\VRChat\VRChat_Data\il2cpp_dump_tools"
OUTPUT_DIR = os.path.join(PROJECT_ROOT, "output", "v_new_ida")
TARGET_FILE = os.path.join(PROJECT_ROOT, "data", "hexrays_target_vas.json")


def main():
    print("[*] Surgical Hex-Rays: loading target VAs...")
    os.makedirs(OUTPUT_DIR, exist_ok=True)

    with open(TARGET_FILE, 'r', encoding='utf-8') as f:
        target_vas = json.load(f)

    print(f"[*] {len(target_vas)} target VAs")

    # Wait for analysis done (DB should be ready)
    idaapi.auto_wait()
    print("[*] auto_wait complete")

    if not ida_hexrays.init_hexrays_plugin():
        print("[!] Hex-Rays not available")
        idc.qexit(1)
        return

    results = {}
    ok = 0
    fail = 0
    for i, va_str in enumerate(target_vas):
        try:
            va = int(va_str, 16)
        except Exception:
            continue
        try:
            cfunc = ida_hexrays.decompile(va)
            if cfunc is None:
                fail += 1
                continue
            code = str(cfunc)
            name = idc.get_func_name(va) or ''
            results[va_str] = {'name': name, 'pseudocode': code[:8000]}
            ok += 1
        except Exception as e:
            fail += 1
        if (i + 1) % 100 == 0:
            print(f"[*] {i+1}/{len(target_vas)} processed, {ok} ok, {fail} fail")

    print(f"[*] Total: {ok} ok, {fail} fail")
    out = os.path.join(OUTPUT_DIR, 'hexrays_surgical.json')
    with open(out, 'w', encoding='utf-8') as f:
        json.dump(results, f, indent=2, ensure_ascii=False)
    print(f"[*] Saved {out}")
    idc.qexit(0)


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f"[!] FATAL: {e}")
        traceback.print_exc()
        idc.qexit(1)
