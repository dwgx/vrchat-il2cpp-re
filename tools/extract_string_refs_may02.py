#!/usr/bin/env python3
"""
Static string-reference miner for the May 2 GameAssembly.dll.

For every IL2CPP method we know the RVA of, disassemble the first 512 bytes
and pull out every LEA/MOV-immediate that points into .rdata. Strings the
compiler kept around -- exception messages, log lines, JSON keys, asset paths
-- frequently leak the original class/method/field names that Beebyte tried
to hide.

Outputs:
  data/method_string_refs_may02.json  - {class_name: [strings]}
  data/all_method_strings_may02.json  - {method_va_hex: [strings]}
"""
from __future__ import annotations

import json
import sys
from pathlib import Path

import pefile
from capstone import Cs, CS_ARCH_X86, CS_MODE_64, CS_OP_IMM, CS_OP_MEM
from capstone.x86 import X86_REG_RIP

sys.stdout.reconfigure(encoding='utf-8')

BASE = Path(__file__).resolve().parent.parent
GA_PATH = Path(r'D:\Steam\steamapps\common\VRChat\GameAssembly.dll')
DUMP_PATH = BASE / 'data' / 'precise_dump.json'
CLASS_OUT = BASE / 'data' / 'method_string_refs_may02.json'
METHOD_OUT = BASE / 'data' / 'all_method_strings_may02.json'

SCAN_BYTES = 512
MIN_STR = 4
MAX_STR = 200
MIN_PRINTABLE_RATIO = 0.85


def main() -> None:
    if not GA_PATH.exists():
        print(f'[!] {GA_PATH} not found')
        sys.exit(1)

    print(f'[+] Loading PE: {GA_PATH}')
    pe = pefile.PE(str(GA_PATH), fast_load=True)
    sections = []
    for sec in pe.sections:
        sections.append({
            'name': sec.Name.decode().rstrip('\x00'),
            'va': sec.VirtualAddress,
            'vsize': sec.Misc_VirtualSize,
            'raw_offset': sec.PointerToRawData,
        })
    rdata = next(s for s in sections if s['name'] == '.rdata')
    rdata_start = rdata['va']
    rdata_end = rdata['va'] + rdata['vsize']
    image_size = pe.OPTIONAL_HEADER.SizeOfImage
    print(f'    .rdata  RVA 0x{rdata_start:X} - 0x{rdata_end:X}')
    print(f'    SizeOfImage 0x{image_size:X}')

    def rva_to_off(rva: int) -> int | None:
        for s in sections:
            if s['va'] <= rva < s['va'] + s['vsize']:
                return s['raw_offset'] + (rva - s['va'])
        return None

    print(f'[+] Reading {GA_PATH.name} into memory...')
    ga_data = GA_PATH.read_bytes()
    print(f'    {len(ga_data) / 1024 / 1024:.1f} MB')

    print(f'[+] Loading dump: {DUMP_PATH}')
    dump = json.loads(DUMP_PATH.read_text(encoding='utf-8'))

    # IL2CPP layout: method bodies live in the custom `il2cpp` section, NOT
    # `.text`. .text is only ~11 MB of trampoline stubs.
    text = next(s for s in sections if s['name'] == '.text')
    il2cpp_sec = next((s for s in sections if s['name'] == 'il2cpp'), None)
    code_sections = [text] + ([il2cpp_sec] if il2cpp_sec else [])

    def in_code(rva: int) -> bool:
        return any(s['va'] <= rva < s['va'] + s['vsize'] for s in code_sections)

    ptrs: list[int] = []
    for ns_classes in dump['namespaces'].values():
        for cls in ns_classes:
            for ptr_str in cls.get('method_pointers', {}).values():
                try:
                    p = int(ptr_str, 16)
                except (TypeError, ValueError):
                    continue
                if p > 0x100000000:
                    ptrs.append(p)
    if not ptrs:
        print('[!] no method pointers in dump')
        sys.exit(2)
    min_ptr = min(ptrs)
    max_ptr = max(ptrs)
    # GA load base ≈ min_ptr - text RVA; round down to page
    dll_base = (min_ptr - text['va']) & ~0xFFF
    if not (dll_base <= max_ptr < dll_base + image_size):
        dll_base = min_ptr & ~0xFFF
    print(f'[+] auto-detected DLL_BASE = 0x{dll_base:X}')
    print(f'    spans [0x{dll_base:X} ... 0x{dll_base + image_size:X}]')
    print(f'    method ptrs        [0x{min_ptr:X} ... 0x{max_ptr:X}]')
    print(f'    code sections      : {[s["name"] for s in code_sections]}')

    cs = Cs(CS_ARCH_X86, CS_MODE_64)
    cs.detail = True

    def read_str(off: int) -> str | None:
        if off < 0 or off >= len(ga_data):
            return None
        end = ga_data.find(b'\x00', off, off + MAX_STR)
        if end <= off:
            return None
        raw = ga_data[off:end]
        try:
            s = raw.decode('ascii')
        except UnicodeDecodeError:
            return None
        if len(s) < MIN_STR:
            return None
        printable = sum(1 for ch in s if ch.isprintable())
        if printable / len(s) < MIN_PRINTABLE_RATIO:
            return None
        return s

    def scan_method(rva: int) -> list[str]:
        off = rva_to_off(rva)
        if off is None or off + SCAN_BYTES > len(ga_data):
            return []
        seen: set[str] = set()
        for insn in cs.disasm(ga_data[off:off + SCAN_BYTES], rva, count=120):
            if insn.mnemonic == 'lea' and len(insn.operands) == 2:
                op = insn.operands[1]
                if op.type == CS_OP_MEM and op.mem.base == X86_REG_RIP:
                    target = insn.address + insn.size + op.mem.disp
                    if rdata_start <= target < rdata_end:
                        s = read_str(rva_to_off(target) or -1)
                        if s:
                            seen.add(s)
            elif insn.mnemonic == 'mov' and len(insn.operands) == 2:
                op = insn.operands[1]
                if op.type == CS_OP_IMM:
                    target_va = op.imm
                    target_rva = target_va - dll_base
                    if rdata_start <= target_rva < rdata_end:
                        s = read_str(rva_to_off(target_rva) or -1)
                        if s:
                            seen.add(s)
            # ret / int3 are real terminators; jmp can be a tail call mid-body.
            if insn.mnemonic in ('ret', 'int3'):
                break
        return list(seen)

    classes_with_strs: dict[str, list[str]] = {}
    methods_with_strs: dict[str, list[str]] = {}
    scanned = 0
    total_methods = 0

    for ns_classes in dump['namespaces'].values():
        for cls in ns_classes:
            ptrs_map = cls.get('method_pointers', {})
            if not ptrs_map:
                continue
            cls_strings: set[str] = set()
            for m, ptr_str in ptrs_map.items():
                try:
                    va = int(ptr_str, 16)
                except (TypeError, ValueError):
                    continue
                rva = va - dll_base
                if not in_code(rva):
                    continue
                strings = scan_method(rva)
                total_methods += 1
                if strings:
                    cls_strings.update(strings)
                    methods_with_strs[ptr_str] = strings
            if cls_strings:
                classes_with_strs[cls['name']] = sorted(cls_strings)
            scanned += 1
            if scanned % 5000 == 0:
                print(f'    scanned {scanned} classes, {len(classes_with_strs)} with strings, '
                      f'{total_methods} methods')

    print()
    print(f'[+] scanned {scanned} classes / {total_methods} methods')
    print(f'    {len(classes_with_strs)} classes ({100*len(classes_with_strs)/scanned:.1f}%) have string refs')
    print(f'    {len(methods_with_strs)} method-VA buckets')

    CLASS_OUT.write_text(json.dumps(classes_with_strs, indent=1, ensure_ascii=False), encoding='utf-8')
    METHOD_OUT.write_text(json.dumps(methods_with_strs, indent=1, ensure_ascii=False), encoding='utf-8')
    print(f'    -> {CLASS_OUT}  ({CLASS_OUT.stat().st_size/1024/1024:.1f} MB)')
    print(f'    -> {METHOD_OUT}  ({METHOD_OUT.stat().st_size/1024/1024:.1f} MB)')


if __name__ == '__main__':
    main()
