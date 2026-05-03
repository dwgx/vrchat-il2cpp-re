"""
Run inside the pre-built IDA database to find the metadata-decrypt path.

  idat.exe -A -S"find_decrypt_in_idb.py" GameAssembly_may02.dll.i64

Strategy:
  1. Find imports CreateFileW, MapViewOfFile, ReadFile.
  2. Walk callers; pick the function that creates a buffer big enough for a
     35 MB metadata file or that calls VirtualAlloc just before/after.
  3. Dump pseudocode for top candidates.
  4. Save as ida/metadata_loader_candidates.json.
"""
import idaapi
import idautils
import idc
import json
import os
import traceback

OUT_PATH = os.path.join(os.path.dirname(idc.get_idb_path()), 'metadata_loader_candidates.json')


def safe_decompile(ea):
    try:
        import ida_hexrays
        if not ida_hexrays.init_hexrays_plugin():
            return None
        cf = ida_hexrays.decompile(ea)
        return str(cf) if cf else None
    except Exception:
        return None


def main():
    print('[*] waiting for analysis (should already be done)...', flush=True)
    idaapi.auto_wait()

    # Resolve the IAT entries for our key imports
    targets = ['CreateFileW', 'MapViewOfFile', 'OpenFileMappingW', 'ReadFile',
               'VirtualAlloc', 'fopen', '_wfopen']
    target_eas = {}
    for ea, name in idautils.Names():
        for t in targets:
            if name == t or name.endswith('!' + t) or name.endswith('@' + t):
                target_eas[name] = ea
    print(f'[*] resolved imports: {target_eas}', flush=True)

    # Collect callers
    first_callers = {}
    for tname, tea in target_eas.items():
        for x in idautils.XrefsTo(tea, 0):
            if x.iscode:
                f = idaapi.get_func(x.frm)
                if f:
                    first_callers.setdefault(f.start_ea, []).append(tname)
    print(f'[*] {len(first_callers)} first-caller functions', flush=True)

    # Score callers: prefer functions that call MULTIPLE of our targets
    # (file-loader functions tend to: CreateFileW + ReadFile, or
    # CreateFileW + MapViewOfFile + VirtualAlloc).
    scored = sorted(first_callers.items(),
                    key=lambda kv: -len(set(kv[1])))
    findings = {'top_callers': []}
    for fc_ea, tnames in scored[:25]:
        name = idc.get_func_name(fc_ea) or f'sub_{fc_ea:X}'
        f = idaapi.get_func(fc_ea)
        size = (f.end_ea - f.start_ea) if f else 0
        pc = safe_decompile(fc_ea)
        findings['top_callers'].append({
            'ea': hex(fc_ea),
            'name': name,
            'size': size,
            'imports_called': sorted(set(tnames)),
            'pseudocode': pc[:8000] if pc else None,
        })
        print(f'    {hex(fc_ea)} {name} (sz=0x{size:X}) imports={sorted(set(tnames))} pc={len(pc) if pc else 0}', flush=True)

    with open(OUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(findings, f, indent=2, ensure_ascii=False)
    print(f'[*] wrote {OUT_PATH}', flush=True)
    idc.qexit(0)


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f'[!] FATAL: {e}', flush=True)
        traceback.print_exc()
        idc.qexit(1)
