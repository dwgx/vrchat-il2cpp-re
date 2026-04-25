#!/usr/bin/env python3
"""
Extract string references from GameAssembly.dll function bodies.
For each method pointer, disassemble the first N bytes and find LEA instructions
that reference .rdata addresses, then read the strings at those addresses.
"""

import json, sys, os, re, struct, collections
import pefile
from capstone import Cs, CS_ARCH_X86, CS_MODE_64

sys.stdout.reconfigure(encoding='utf-8')

GA_PATH = os.path.join(os.path.dirname(__file__), '..', '..', 'GameAssembly.dll')
DUMP_PATH = os.path.join(os.path.dirname(__file__), 'il2cpp_full_dump', 'precise_dump.json')
OUTPUT_PATH = os.path.join(os.path.dirname(__file__), 'il2cpp_full_dump', 'method_string_refs.json')

# DLL base in the dumped process
DLL_BASE = 0x7FFB4D2AA000

# How many bytes of each function to disassemble
SCAN_BYTES = 512

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')


def main():
    print('Loading PE...')
    pe = pefile.PE(GA_PATH, fast_load=True)

    # Build section lookup: RVA -> (file_offset, section_name)
    sections = []
    for sec in pe.sections:
        name = sec.Name.decode().rstrip('\x00')
        sections.append({
            'name': name,
            'va': sec.VirtualAddress,
            'vsize': sec.Misc_VirtualSize,
            'raw_offset': sec.PointerToRawData,
            'raw_size': sec.SizeOfRawData,
        })
        print(f'  {name}: VA=0x{sec.VirtualAddress:X} RawOff=0x{sec.PointerToRawData:X}')

    def rva_to_offset(rva):
        for sec in sections:
            if sec['va'] <= rva < sec['va'] + sec['vsize']:
                return sec['raw_offset'] + (rva - sec['va'])
        return None

    # Find .rdata bounds
    rdata = next(s for s in sections if s['name'] == '.rdata')
    rdata_rva_start = rdata['va']
    rdata_rva_end = rdata['va'] + rdata['vsize']
    print(f'\n.rdata RVA range: 0x{rdata_rva_start:X} - 0x{rdata_rva_end:X}')

    # Read the entire file into memory for fast access
    print('Reading GameAssembly.dll into memory...')
    with open(GA_PATH, 'rb') as f:
        ga_data = f.read()
    print(f'  {len(ga_data) / 1024 / 1024:.1f} MB loaded')

    # Load dump data
    print('Loading precise_dump.json...')
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Collect method pointers for opaque obfuscated classes
    # (classes that ended up with fallback names)
    opaque_methods = {}  # class_name -> {method_name: rva}
    all_class_methods = {}  # ALL classes -> {method_name: rva}

    standard = {'.ctor', '.cctor', 'Finalize', 'ToString', 'GetHashCode', 'Equals',
                'GetType', 'MemberwiseClone', 'Dispose', 'System.IDisposable.Dispose',
                'Awake', 'Start', 'Update', 'FixedUpdate', 'LateUpdate',
                'OnEnable', 'OnDisable', 'OnDestroy', 'MoveNext', 'SetStateMachine'}

    for ns, classes in dump['namespaces'].items():
        for cls in classes:
            name = cls['name']
            ptrs = cls.get('method_pointers', {})
            if not ptrs:
                continue

            methods_with_rva = {}
            for m, ptr_str in ptrs.items():
                try:
                    va = int(ptr_str, 16)
                    if va > 0x100000000:
                        rva = va - DLL_BASE
                        if 0x1000 <= rva <= 0x9D3F000:
                            methods_with_rva[m] = rva
                except:
                    pass

            if methods_with_rva:
                all_class_methods[name] = methods_with_rva
                # Check if the class is obfuscated
                if OBF_RE.match(name):
                    readable = [m for m in cls.get('methods', [])
                                if isinstance(m, str) and not OBF_RE.match(m) and m not in standard]
                    # Only target classes with few clues
                    if len(readable) <= 2:
                        opaque_methods[name] = methods_with_rva

    print(f'\nTotal classes with GA method pointers: {len(all_class_methods)}')
    print(f'Opaque classes to scan: {len(opaque_methods)}')

    # Initialize Capstone disassembler
    cs = Cs(CS_ARCH_X86, CS_MODE_64)
    cs.detail = True

    def read_string_at_offset(offset, max_len=200):
        """Try to read a null-terminated ASCII or UTF-16 string at file offset."""
        if offset < 0 or offset >= len(ga_data):
            return None

        # Try ASCII first
        end = ga_data.find(b'\x00', offset, offset + max_len)
        if end > offset:
            candidate = ga_data[offset:end]
            try:
                s = candidate.decode('ascii')
                if len(s) >= 3 and s.isprintable():
                    return s
            except:
                pass

        # Try UTF-16LE
        end16 = ga_data.find(b'\x00\x00', offset, offset + max_len * 2)
        if end16 > offset and (end16 - offset) % 2 == 0:
            candidate = ga_data[offset:end16]
            try:
                s = candidate.decode('utf-16-le')
                if len(s) >= 3 and s.isprintable():
                    return s
            except:
                pass
        return None

    def extract_string_refs_from_function(rva, max_bytes=SCAN_BYTES):
        """Disassemble function and find string references in .rdata."""
        offset = rva_to_offset(rva)
        if offset is None or offset + max_bytes > len(ga_data):
            return []

        code = ga_data[offset:offset + max_bytes]
        strings = []

        for insn in cs.disasm(code, rva, count=80):
            # Look for LEA with RIP-relative addressing
            if insn.mnemonic == 'lea' and len(insn.operands) == 2:
                op = insn.operands[1]
                # RIP-relative: op.mem.base == X86_REG_RIP
                if op.type == 3 and op.mem.base == 41:  # 41 = X86_REG_RIP in capstone
                    target_rva = insn.address + insn.size + op.mem.disp
                    if rdata_rva_start <= target_rva < rdata_rva_end:
                        target_offset = rva_to_offset(target_rva)
                        if target_offset:
                            s = read_string_at_offset(target_offset)
                            if s and len(s) >= 3:
                                strings.append(s)

            # Also check MOV with immediate addresses that point to .rdata
            elif insn.mnemonic == 'mov' and len(insn.operands) == 2:
                op = insn.operands[1]
                if op.type == 2:  # IMM
                    # Check if it's a VA pointing to .rdata
                    target_va = op.imm
                    target_rva = target_va - DLL_BASE
                    if rdata_rva_start <= target_rva < rdata_rva_end:
                        target_offset = rva_to_offset(target_rva)
                        if target_offset:
                            s = read_string_at_offset(target_offset)
                            if s and len(s) >= 3:
                                strings.append(s)

            # Stop at RET or INT3
            if insn.mnemonic in ('ret', 'int3'):
                break

        return list(set(strings))

    # Scan all opaque classes
    print(f'\nScanning {len(opaque_methods)} opaque classes...')
    class_strings = {}  # class_name -> list of strings
    scanned = 0
    found = 0

    for class_name, methods in opaque_methods.items():
        all_strings = []
        for method_name, rva in methods.items():
            refs = extract_string_refs_from_function(rva)
            all_strings.extend(refs)

        if all_strings:
            # Deduplicate and store
            class_strings[class_name] = list(set(all_strings))
            found += 1

        scanned += 1
        if scanned % 500 == 0:
            print(f'  Scanned {scanned}/{len(opaque_methods)}, found strings in {found} classes')

    print(f'\nDone: {found}/{len(opaque_methods)} opaque classes have string references')

    # Show some examples
    examples = sorted(class_strings.items(), key=lambda x: -len(x[1]))[:20]
    print(f'\nTop 20 classes by string reference count:')
    for name, strings in examples:
        method_count = len(opaque_methods.get(name, {}))
        print(f'  {name[:20]}... ({method_count} methods): {strings[:5]}')

    # Save results
    print(f'\nSaving to {OUTPUT_PATH}...')
    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump({
            'dll_base': f'0x{DLL_BASE:X}',
            'classes_scanned': len(opaque_methods),
            'classes_with_strings': found,
            'class_string_refs': class_strings,
        }, f, indent=2, ensure_ascii=False)

    print(f'Saved {found} class string references')


if __name__ == '__main__':
    main()
