"""
Find the IL2CPP metadata-decrypt function in GameAssembly.dll using IDA's
idalib. The custom Beebyte protector has stripped almost every error-string
and DLL-path constant out of the binary, but the metadata-load path still
goes through CreateFileW/MapViewOfFile or fopen.

We:
  1. Open the dll in idalib (auto-analysis runs).
  2. Walk every caller of CreateFileW/MapViewOfFile/ReadFile imports.
  3. For each caller's outer caller, decompile and dump pseudocode.
  4. Save findings; the human-readable trace lets us spot the decrypt loop.
"""
from __future__ import annotations

import json
import os
import sys
import traceback
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

import idapro

BASE = Path(__file__).resolve().parent.parent
GA = BASE / 'ida' / 'GameAssembly_may02.dll'
OUT = BASE / 'ida' / 'metadata_decrypt_findings.json'


def main() -> None:
    print(f'[+] opening {GA} (auto-analysis triggers; this is slow)...', flush=True)
    rc = idapro.open_database(str(GA), run_auto_analysis=True)
    print(f'    open_database rc={rc}', flush=True)
    try:
        import idaapi
        import idautils
        import idc
        import ida_hexrays
        import ida_name
        import ida_segment
        import ida_funcs

        print('[+] auto-analysis done; segment list:')
        for seg_ea in idautils.Segments():
            print(f'    seg 0x{seg_ea:X}: {ida_segment.get_segm_name(idaapi.getseg(seg_ea))}')

        print('[+] resolving target imports ...')
        targets = ['CreateFileW', 'MapViewOfFile', 'OpenFileMappingW', 'ReadFile', 'fopen', '_wfopen']
        ea_targets: dict[str, int] = {}
        for ea in idautils.Names():
            for t in targets:
                if ea[1] == t or ea[1].endswith(f'!{t}'):
                    ea_targets[t] = ea[0]
        print(f'    matched: {ea_targets}', flush=True)

        # All callers of any of those imports
        first_callers: dict[int, list[str]] = {}
        for tgt, tgt_ea in ea_targets.items():
            for xref in idautils.XrefsTo(tgt_ea, 0):
                if xref.iscode:
                    f = idaapi.get_func(xref.frm)
                    if f:
                        first_callers.setdefault(f.start_ea, []).append(tgt)
        print(f'[+] first-callers (functions calling file-io imports): {len(first_callers)}', flush=True)

        # Decompile each first-caller and ALSO their parent callers
        ida_hexrays.init_hexrays_plugin()
        findings: dict[str, dict] = {}

        def decompile(ea):
            try:
                cf = ida_hexrays.decompile(ea)
                return str(cf) if cf else None
            except Exception:
                return None

        for fc_ea, tgts in list(first_callers.items())[:30]:
            name = idc.get_func_name(fc_ea) or f'sub_{fc_ea:X}'
            pc = decompile(fc_ea)
            findings[hex(fc_ea)] = {
                'name': name,
                'imports_called': tgts,
                'pseudocode': pc[:8000] if pc else None,
            }
            print(f'    fc 0x{fc_ea:X} ({name}): {len(pc) if pc else 0} chars', flush=True)

        # Pump first callers' callers (potential metadata loader)
        print('[+] walking outer callers ...', flush=True)
        outer = set()
        for fc_ea in first_callers:
            for xref in idautils.XrefsTo(fc_ea, 0):
                if xref.iscode:
                    f = idaapi.get_func(xref.frm)
                    if f:
                        outer.add(f.start_ea)
        print(f'    outer callers: {len(outer)}', flush=True)

        for oc_ea in list(outer)[:30]:
            name = idc.get_func_name(oc_ea) or f'sub_{oc_ea:X}'
            pc = decompile(oc_ea)
            key = hex(oc_ea) + '_outer'
            findings[key] = {
                'name': name,
                'pseudocode': pc[:8000] if pc else None,
            }

        OUT.write_text(json.dumps(findings, indent=2, ensure_ascii=False), encoding='utf-8')
        print(f'[+] wrote {OUT}', flush=True)
    finally:
        idapro.close_database()


if __name__ == '__main__':
    try:
        main()
    except Exception as e:
        print(f'[!] FATAL: {e}', flush=True)
        traceback.print_exc()
