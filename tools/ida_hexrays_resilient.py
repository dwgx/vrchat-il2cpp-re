"""
Resilient surgical Hex-Rays: incremental save every 200 funcs, skip already done.
Target: data/hexrays_target_vas.json (929 strong-class VAs)
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
OUT_FILE = os.path.join(OUTPUT_DIR, "hexrays_resilient.json")
SAVE_EVERY = 100


def main():
    print("[*] Resilient Hex-Rays: starting...")
    os.makedirs(OUTPUT_DIR, exist_ok=True)

    with open(TARGET_FILE, 'r', encoding='utf-8') as f:
        target_vas = json.load(f)

    # Resume from existing
    results = {}
    if os.path.exists(OUT_FILE):
        try:
            with open(OUT_FILE, 'r', encoding='utf-8') as f:
                results = json.load(f)
            print(f"[*] Resuming with {len(results)} already done")
        except Exception:
            results = {}

    print(f"[*] {len(target_vas)} target VAs, {len(target_vas) - len(results)} remaining")

    idaapi.auto_wait()
    print("[*] auto_wait complete")

    if not ida_hexrays.init_hexrays_plugin():
        print("[!] Hex-Rays not available")
        idc.qexit(1)
        return

    todo = [va for va in target_vas if va not in results]
    ok = len(results)
    fail = 0

    for i, va_str in enumerate(todo):
        try:
            va = int(va_str, 16)
        except Exception:
            continue
        try:
            cfunc = ida_hexrays.decompile(va)
            if cfunc is None:
                fail += 1
                results[va_str] = {'name': '', 'pseudocode': ''}  # mark attempted
            else:
                code = str(cfunc)
                name = idc.get_func_name(va) or ''
                results[va_str] = {'name': name, 'pseudocode': code[:8000]}
                ok += 1
        except Exception as e:
            fail += 1
            results[va_str] = {'name': '', 'pseudocode': '', 'err': str(e)[:100]}

        if (i + 1) % SAVE_EVERY == 0:
            with open(OUT_FILE, 'w', encoding='utf-8') as f:
                json.dump(results, f, indent=2, ensure_ascii=False)
            print(f"[*] {ok} ok, {fail} fail, {len(results)}/{len(target_vas)} processed (saved)")

    # Final save
    with open(OUT_FILE, 'w', encoding='utf-8') as f:
        json.dump(results, f, indent=2, ensure_ascii=False)
    print(f"[*] DONE: {ok} ok, {fail} fail")
    idc.qexit(0)


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f"[!] FATAL: {e}")
        traceback.print_exc()
        # Save what we have
        try:
            if 'results' in dir():
                with open(OUT_FILE, 'w', encoding='utf-8') as f:
                    json.dump(results, f, indent=2, ensure_ascii=False)
        except Exception:
            pass
        idc.qexit(1)
