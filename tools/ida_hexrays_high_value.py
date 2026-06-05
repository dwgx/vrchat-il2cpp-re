"""
Resumable Hex-Rays export for data/hexrays_high_value_targets.json.

Output: output/v_new_ida/hexrays_high_value.json
"""

import json
import os
import traceback

import ida_hexrays
import idaapi
import idc


PROJECT_ROOT = r"D:\Project\vrchat-il2cpp-re"
TARGET_FILE = os.path.join(PROJECT_ROOT, "data", "hexrays_high_value_targets.json")
OUTPUT_DIR = os.path.join(PROJECT_ROOT, "output", "v_new_ida")
OUT_FILE = os.path.join(OUTPUT_DIR, "hexrays_high_value.json")
SAVE_EVERY = int(os.environ.get("HEXRAYS_SAVE_EVERY", "25"))


def main():
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    print("[*] Loading high-value targets: %s" % TARGET_FILE)
    with open(TARGET_FILE, "r", encoding="utf-8") as handle:
        targets = json.load(handle)

    results = {}
    if os.path.exists(OUT_FILE):
        try:
            with open(OUT_FILE, "r", encoding="utf-8") as handle:
                results = json.load(handle)
            print("[*] Resuming with %d existing entries" % len(results))
        except Exception:
            results = {}

    idaapi.auto_wait()
    print("[*] auto_wait complete")
    if not ida_hexrays.init_hexrays_plugin():
        print("[!] Hex-Rays not available")
        idc.qexit(1)
        return
    print("[*] Hex-Rays: %s" % ida_hexrays.get_hexrays_version())

    ok = 0
    fail = 0
    for index, target in enumerate(targets):
        ea_text = target["ea"]
        if ea_text in results and results[ea_text].get("pseudocode"):
            continue
        ea = int(ea_text, 16)
        try:
            cfunc = ida_hexrays.decompile(ea)
            if cfunc is None:
                fail += 1
                target_result = dict(target)
                target_result.update({"ida_name": idc.get_func_name(ea) or "", "pseudocode": ""})
            else:
                ok += 1
                target_result = dict(target)
                target_result.update({
                    "ida_name": idc.get_func_name(ea) or "",
                    "pseudocode": str(cfunc)[:12000],
                })
            results[ea_text] = target_result
        except Exception as exc:
            fail += 1
            target_result = dict(target)
            target_result.update({
                "ida_name": idc.get_func_name(ea) or "",
                "pseudocode": "",
                "error": str(exc)[:200],
            })
            results[ea_text] = target_result

        if (index + 1) % SAVE_EVERY == 0:
            with open(OUT_FILE, "w", encoding="utf-8") as handle:
                json.dump(results, handle, indent=2, ensure_ascii=False)
            print("[*] %d/%d processed, ok=%d fail=%d saved" % (
                index + 1, len(targets), ok, fail
            ))

    with open(OUT_FILE, "w", encoding="utf-8") as handle:
        json.dump(results, handle, indent=2, ensure_ascii=False)
    print("[*] DONE: %d entries, ok=%d fail=%d -> %s" % (len(results), ok, fail, OUT_FILE))
    idc.qexit(0)


if __name__ == "__main__":
    try:
        main()
    except Exception as exc:
        print("[!] FATAL: %s" % exc)
        traceback.print_exc()
        idc.qexit(1)
