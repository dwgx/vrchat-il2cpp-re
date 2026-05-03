"""
IDAPython script: locate the metadata decryption routine in GameAssembly.dll.

Invoked headlessly via:
  idat.exe -A -S"find_metadata_decrypt.py" GameAssembly_may02.dll

Strategy:
  1. Wait for auto-analysis.
  2. Find string xrefs to 'global-metadata.dat'.
  3. From those callers walk the call graph one or two hops out -- one
     of them is the file-reader, another is the decrypt routine.
  4. Dump pseudo-code for each candidate so we can read the algo
     offline.
  5. Save results to ida/metadata_decrypt_findings.json.
"""
import idaapi
import idautils
import idc
import json
import os
import traceback

OUT_PATH = os.path.join(os.path.dirname(idc.get_idb_path()), 'metadata_decrypt_findings.json')


def collect_strings_with(needles):
    hits = {}  # ea_of_string -> string
    for s in idautils.Strings():
        text = str(s)
        for needle in needles:
            if needle in text:
                hits[s.ea] = text
                break
    return hits


def callers_of(func_ea):
    callers = set()
    for xref in idautils.XrefsTo(func_ea, 0):
        if xref.iscode:
            f = idaapi.get_func(xref.frm)
            if f:
                callers.add(f.start_ea)
    return callers


def func_xrefs_to_data(data_ea):
    out = set()
    for xref in idautils.XrefsTo(data_ea, 0):
        if xref.iscode:
            f = idaapi.get_func(xref.frm)
            if f:
                out.add(f.start_ea)
    return out


def safe_decompile(ea):
    try:
        import ida_hexrays
        if not ida_hexrays.init_hexrays_plugin():
            return None
        cfunc = ida_hexrays.decompile(ea)
        if cfunc is None:
            return None
        return str(cfunc)
    except Exception:
        return None


def main():
    print('[*] waiting for auto-analysis ...')
    idaapi.auto_wait()
    print('[*] auto-analysis complete')

    findings = {
        'metadata_string_hits': {},
        'metadata_string_callers': {},
        'pseudo_code': {},
    }

    needles = ['global-metadata', 'metadata.dat', 'GlobalMetadata',
               'sanity check', 'FAB11BAF', 'Il2CppGlobalMetadata',
               'Mono_Metadata', 'metadata version']
    print(f'[*] scanning strings for {needles} ...')
    hits = collect_strings_with(needles)
    print(f'    found {len(hits)} string hits')
    for ea, text in hits.items():
        findings['metadata_string_hits'][hex(ea)] = text

    seen_callers = set()
    for ea, text in hits.items():
        callers = func_xrefs_to_data(ea)
        for caller_ea in callers:
            seen_callers.add(caller_ea)
            findings['metadata_string_callers'].setdefault(hex(caller_ea), []).append(text)

    print(f'[*] {len(seen_callers)} unique caller functions; decompiling first 12 ...')
    for caller_ea in list(seen_callers)[:12]:
        name = idc.get_func_name(caller_ea) or f'sub_{caller_ea:X}'
        pc = safe_decompile(caller_ea)
        if pc:
            findings['pseudo_code'][hex(caller_ea)] = {
                'name': name,
                'pseudocode': pc[:12000],
            }
            print(f'    {hex(caller_ea)}  {name}: {len(pc)} chars')
        else:
            findings['pseudo_code'][hex(caller_ea)] = {'name': name, 'pseudocode': None}
            print(f'    {hex(caller_ea)}  {name}: decompile failed')

    with open(OUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(findings, f, indent=2, ensure_ascii=False)
    print(f'[*] wrote {OUT_PATH}')

    idc.qexit(0)


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f'[!] FATAL: {e}')
        traceback.print_exc()
        idc.qexit(1)
