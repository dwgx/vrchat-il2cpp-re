"""
CORRECT workflow: Apply names FIRST, then Hex-Rays on targets only.
1. auto_wait (use existing DB analysis)
2. Apply 153K function renames from name_mapping
3. Surgical Hex-Rays on 929 strong-class targets
4. Incremental save every 100
"""
import idautils
import idaapi
import idc
import ida_hexrays
import ida_name
import json
import os
import sys
import traceback

PROJECT_ROOT = r"D:\WorkSpace\VRChat\VRChat_Data\il2cpp_dump_tools"
OUTPUT_DIR = os.path.join(PROJECT_ROOT, "output", "v_new_ida")
TARGET_FILE = os.path.join(PROJECT_ROOT, "data", "hexrays_target_vas.json")
NAMES_SCRIPT = os.path.join(PROJECT_ROOT, "output", "ida_apply_names.py")
OUT_FILE = os.path.join(OUTPUT_DIR, "hexrays_named.json")
SLIDE = 0x7FFBCDEFB350
SAVE_EVERY = 50


def apply_names_from_mapping():
    """Apply function names from name_mapping + ida_apply_names."""
    print("[*] Applying function names...")
    nm_path = os.path.join(PROJECT_ROOT, "output", "name_mapping.json")
    with open(nm_path, 'r', encoding='utf-8') as f:
        nm = json.load(f)

    pd_path = os.path.join(PROJECT_ROOT, "data", "precise_dump.json")
    with open(pd_path, 'r', encoding='utf-8') as f:
        pd = json.load(f)

    classes_map = nm.get('classes', {})
    methods_map = nm.get('methods', {})

    applied = 0
    for ns_name, cls_list in pd.get('namespaces', {}).items():
        if not isinstance(cls_list, list):
            continue
        for cls in cls_list:
            cls_obf = cls.get('name', '')
            cls_sem = classes_map.get(cls_obf, cls_obf)
            pointers = cls.get('method_pointers', {})
            if not isinstance(pointers, dict):
                continue
            for m_name, va_str in pointers.items():
                key = f"{cls_obf}::{m_name}"
                sem_name = methods_map.get(key, '')
                if not sem_name:
                    continue
                try:
                    runtime_va = int(va_str, 16)
                    ida_va = runtime_va - SLIDE
                    full_name = f"{cls_sem}__{sem_name}"
                    full_name = full_name.replace('<', '_').replace('>', '_').replace('`', '_').replace(',', '_').replace(' ', '_')
                    if len(full_name) > 200:
                        full_name = full_name[:200]
                    ida_name.set_name(ida_va, full_name, ida_name.SN_FORCE)
                    applied += 1
                except Exception:
                    pass

    print(f"[*] Applied {applied} function names")
    return applied


def main():
    print("[*] Apply-then-HexRays: starting...")
    os.makedirs(OUTPUT_DIR, exist_ok=True)

    # Load targets
    with open(TARGET_FILE, 'r', encoding='utf-8') as f:
        target_vas = json.load(f)
    print(f"[*] {len(target_vas)} target VAs")

    # Wait for analysis
    idaapi.auto_wait()
    print("[*] auto_wait complete")

    # Step 1: Apply names
    apply_names_from_mapping()

    # Step 2: Init Hex-Rays
    if not ida_hexrays.init_hexrays_plugin():
        print("[!] Hex-Rays not available")
        idc.qexit(1)
        return

    # Step 3: Resume from existing
    results = {}
    if os.path.exists(OUT_FILE):
        try:
            with open(OUT_FILE, 'r', encoding='utf-8') as f:
                results = json.load(f)
            print(f"[*] Resuming with {len(results)} already done")
        except Exception:
            results = {}

    # Step 4: Decompile targets
    todo = [va for va in target_vas if va not in results]
    print(f"[*] {len(todo)} remaining to decompile")
    ok = sum(1 for v in results.values() if v.get('pseudocode'))
    fail = 0

    for i, va_str in enumerate(todo):
        try:
            runtime_va = int(va_str, 16)
            ida_va = runtime_va - SLIDE
        except Exception:
            continue
        try:
            cfunc = ida_hexrays.decompile(ida_va)
            if cfunc is None:
                fail += 1
                results[va_str] = {'name': '', 'pseudocode': ''}
            else:
                code = str(cfunc)
                name = idc.get_func_name(ida_va) or ''
                results[va_str] = {'name': name, 'pseudocode': code[:8000]}
                ok += 1
        except Exception as e:
            fail += 1
            results[va_str] = {'name': '', 'pseudocode': '', 'err': str(e)[:100]}

        if (i + 1) % SAVE_EVERY == 0:
            with open(OUT_FILE, 'w', encoding='utf-8') as f:
                json.dump(results, f, indent=2, ensure_ascii=False)
            print(f"[*] {ok} ok, {fail} fail, {len(results)}/{len(target_vas)} (saved)")

    # Final save
    with open(OUT_FILE, 'w', encoding='utf-8') as f:
        json.dump(results, f, indent=2, ensure_ascii=False)
    print(f"[*] DONE: {ok} ok, {fail} fail out of {len(target_vas)}")
    idc.qexit(0)


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f"[!] FATAL: {e}")
        traceback.print_exc()
        try:
            with open(OUT_FILE, 'w', encoding='utf-8') as f:
                json.dump(results, f, indent=2, ensure_ascii=False)
            print("[*] Partial results saved")
        except Exception:
            pass
        idc.qexit(1)
