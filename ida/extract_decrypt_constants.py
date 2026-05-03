"""
Extract the SIMD constants used by sub_180A7E880 and dump full pseudocode
of the loader chain. Resolves:
  xmmword_18B6788F0, xmmword_18B678A70, xmmword_18B678BC0, xmmword_18B679930
plus sub_1809E7EE0 (file open/map) and sub_180AB0FC8 (allocator) and
sub_180AD4B60 (memcpy?).
"""
import idaapi
import idautils
import idc
import ida_bytes
import json
import os
import traceback

OUT_PATH = os.path.join(os.path.dirname(idc.get_idb_path()), 'decrypt_constants.json')


def safe_decompile(ea):
    try:
        import ida_hexrays
        if not ida_hexrays.init_hexrays_plugin():
            return None
        cf = ida_hexrays.decompile(ea)
        return str(cf) if cf else None
    except Exception:
        return None


def read_xmmword(va):
    return ida_bytes.get_bytes(va, 16) or b''


def main():
    print('[*] extracting decrypt constants ...', flush=True)
    out = {}

    consts = {
        'xmmword_18B6788F0': 0x18B6788F0,
        'xmmword_18B678A70': 0x18B678A70,
        'xmmword_18B678BC0': 0x18B678BC0,
        'xmmword_18B679930': 0x18B679930,
    }
    for name, ea in consts.items():
        b = read_xmmword(ea)
        out[name] = {
            'ea': hex(ea),
            'bytes': b.hex(),
            'hex_bytes_array': [f'0x{x:02X}' for x in b],
        }
        print(f'    {name} @ {hex(ea)}: {b.hex()}', flush=True)

    helpers = {
        'sub_1809E7EE0': 0x1809E7EE0,
        'sub_180AB0FC8': 0x180AB0FC8,
        'sub_180AD4B60': 0x180AD4B60,
        'sub_180A7E880': 0x180A7E880,  # the loader itself, full pseudocode
    }
    for name, ea in helpers.items():
        pc = safe_decompile(ea)
        out[name] = {
            'ea': hex(ea),
            'pseudocode': pc,
        }
        sz = len(pc) if pc else 0
        print(f'    {name} pc: {sz} chars', flush=True)

    with open(OUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(out, f, indent=2, ensure_ascii=False)
    print(f'[*] wrote {OUT_PATH}', flush=True)
    idc.qexit(0)


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f'[!] FATAL: {e}', flush=True)
        traceback.print_exc()
        idc.qexit(1)
