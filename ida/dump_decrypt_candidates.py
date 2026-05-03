"""
Get the FULL pseudocode for the most promising metadata-loader candidates,
plus their immediate parent callers (which would be the entry that
orchestrates open + decrypt + parse).
"""
import idaapi
import idautils
import idc
import json
import os
import traceback

OUT_PATH = os.path.join(os.path.dirname(idc.get_idb_path()), 'decrypt_pseudocode.json')


def safe_decompile(ea):
    try:
        import ida_hexrays
        if not ida_hexrays.init_hexrays_plugin():
            return None
        cf = ida_hexrays.decompile(ea)
        return str(cf) if cf else None
    except Exception:
        return None


def callers_of(ea):
    out = set()
    for x in idautils.XrefsTo(ea, 0):
        if x.iscode:
            f = idaapi.get_func(x.frm)
            if f:
                out.add(f.start_ea)
    return out


CANDIDATES = [
    0x1809EEDC0,  # MapViewOfFile + VirtualAlloc
    0x1809EE9C0,  # OpenFileMappingW
    0x180A3F7B0,  # big CreateFileW caller (0xB7C bytes)
    0x180A86F60,  # CreateFileW (0x4F4 bytes, returns const void*)
    0x180A86800,  # CreateFileW (0x210 bytes)
    0x1809E7EE0,  # CreateFileW (0x436 bytes, returns const void*)
    0x180AB35C0,  # CreateFileW (0x3EF bytes, decompile failed previously)
]


def main():
    print('[*] dumping decompiled candidates ...', flush=True)
    findings = {}

    # Visit each candidate and its parent callers (depth 1)
    seen = set()
    queue = [(ea, 0) for ea in CANDIDATES]
    while queue:
        ea, depth = queue.pop()
        if ea in seen:
            continue
        seen.add(ea)
        name = idc.get_func_name(ea) or f'sub_{ea:X}'
        f = idaapi.get_func(ea)
        if not f:
            continue
        size = f.end_ea - f.start_ea
        pc = safe_decompile(ea)
        findings[hex(ea)] = {
            'name': name,
            'depth': depth,
            'size': size,
            'pseudocode': pc,
        }
        if depth < 1:
            for c_ea in callers_of(ea):
                queue.append((c_ea, depth + 1))

    print(f'[*] dumped {len(findings)} functions', flush=True)
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
