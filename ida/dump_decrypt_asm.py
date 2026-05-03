"""
Dump assembly listing of sub_180A7E880 (the metadata decrypt routine).

We need raw x86 to disambiguate the SIMD pattern Hex-Rays compressed.
"""
import idaapi
import idautils
import idc
import json
import os

OUT_PATH = os.path.join(os.path.dirname(idc.get_idb_path()), 'decrypt_asm.txt')


def main():
    f = idaapi.get_func(0x180A7E880)
    if not f:
        print('[!] func not found')
        idc.qexit(1)
        return
    out = []
    ea = f.start_ea
    while ea < f.end_ea:
        line = idc.GetDisasm(ea)
        out.append(f'{ea:016X}  {line}')
        ea = idc.next_head(ea, f.end_ea)
    with open(OUT_PATH, 'w', encoding='utf-8') as fh:
        fh.write('\n'.join(out))
    print(f'[*] wrote {OUT_PATH} ({len(out)} lines)')
    idc.qexit(0)


main()
