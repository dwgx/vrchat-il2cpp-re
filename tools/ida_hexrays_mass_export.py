"""
Resumable mass Hex-Rays export for data/hexrays_mass_targets.json.

Environment:
  HEXRAYS_START_INDEX    first target index to process, default 0
  HEXRAYS_LIMIT          max targets for this IDA process, default all
  HEXRAYS_SAVE_EVERY     save interval, default 25
  HEXRAYS_MAX_CHARS      pseudocode character cap, default 12000
"""

import json
import os
import traceback

import ida_hexrays
import idaapi
import idc


PROJECT_ROOT = r"D:\Project\vrchat-il2cpp-re"
TARGET_FILE = os.path.join(PROJECT_ROOT, "data", "hexrays_mass_targets.json")
OUTPUT_DIR = os.path.join(PROJECT_ROOT, "output", "v_new_ida")
OUT_FILE = os.path.join(OUTPUT_DIR, "hexrays_mass_export.json")
SAVE_EVERY = int(os.environ.get("HEXRAYS_SAVE_EVERY", "25"))
START_INDEX = int(os.environ.get("HEXRAYS_START_INDEX", "0"))
LIMIT_TEXT = os.environ.get("HEXRAYS_LIMIT", "").strip()
LIMIT = int(LIMIT_TEXT) if LIMIT_TEXT else 0
MAX_CHARS = int(os.environ.get("HEXRAYS_MAX_CHARS", "12000"))


def save_results(results):
    with open(OUT_FILE, "w", encoding="utf-8") as handle:
        json.dump(results, handle, indent=2, ensure_ascii=False)


def main():
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    print("[*] Loading mass targets: %s" % TARGET_FILE)
    with open(TARGET_FILE, "r", encoding="utf-8") as handle:
        targets = json.load(handle)

    end_index = len(targets) if LIMIT <= 0 else min(len(targets), START_INDEX + LIMIT)
    chunk = targets[START_INDEX:end_index]

    results = {}
    if os.path.exists(OUT_FILE):
        try:
            with open(OUT_FILE, "r", encoding="utf-8") as handle:
                results = json.load(handle)
            print("[*] Resuming with %d existing entries" % len(results))
        except Exception:
            results = {}

    print("[*] Chunk: indices %d..%d (%d targets)" % (START_INDEX, end_index, len(chunk)))
    idaapi.auto_wait()
    print("[*] auto_wait complete")
    if not ida_hexrays.init_hexrays_plugin():
        print("[!] Hex-Rays not available")
        idc.qexit(1)
        return
    print("[*] Hex-Rays: %s" % ida_hexrays.get_hexrays_version())

    ok = 0
    fail = 0
    skipped = 0
    for offset, target in enumerate(chunk):
        index = START_INDEX + offset
        ea_text = target["ea"]
        if ea_text in results and results[ea_text].get("pseudocode"):
            skipped += 1
            continue
        ea = int(ea_text, 16)
        try:
            cfunc = ida_hexrays.decompile(ea)
            target_result = dict(target)
            target_result["target_index"] = index
            target_result["ida_name"] = idc.get_func_name(ea) or ""
            if cfunc is None:
                fail += 1
                target_result["pseudocode"] = ""
            else:
                ok += 1
                target_result["pseudocode"] = str(cfunc)[:MAX_CHARS]
            results[ea_text] = target_result
        except Exception as exc:
            fail += 1
            target_result = dict(target)
            target_result.update({
                "target_index": index,
                "ida_name": idc.get_func_name(ea) or "",
                "pseudocode": "",
                "error": str(exc)[:200],
            })
            results[ea_text] = target_result

        if (offset + 1) % SAVE_EVERY == 0:
            save_results(results)
            print("[*] chunk %d/%d global=%d ok=%d fail=%d skipped=%d saved" % (
                offset + 1, len(chunk), index + 1, ok, fail, skipped
            ))

    save_results(results)
    print("[*] DONE: total_entries=%d chunk_ok=%d chunk_fail=%d chunk_skipped=%d -> %s" % (
        len(results), ok, fail, skipped, OUT_FILE
    ))
    idc.qexit(0)


if __name__ == "__main__":
    try:
        main()
    except Exception as exc:
        print("[!] FATAL: %s" % exc)
        traceback.print_exc()
        idc.qexit(1)
