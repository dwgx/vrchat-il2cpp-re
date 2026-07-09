"""
Analyze GameAssembly.dll .text section using capstone disassembler.
Builds intuition about IL2CPP runtime structure and code patterns.
"""
import struct
import random
import sys
from pathlib import Path

try:
    import pefile
except ImportError:
    print("Installing pefile...")
    import subprocess
    subprocess.check_call([sys.executable, "-m", "pip", "install", "pefile", "-q"])
    import pefile

try:
    from capstone import *
except ImportError:
    print("Installing capstone...")
    import subprocess
    subprocess.check_call([sys.executable, "-m", "pip", "install", "capstone", "-q"])
    from capstone import *

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"

def load_pe():
    print(f"Loading {DLL_PATH}...")
    pe = pefile.PE(DLL_PATH, fast_load=False)
    print(f"  ImageBase: 0x{pe.OPTIONAL_HEADER.ImageBase:016X}")
    print(f"  Entry point RVA: 0x{pe.OPTIONAL_HEADER.AddressOfEntryPoint:08X}")
    print(f"  Number of sections: {len(pe.sections)}")
    for s in pe.sections:
        name = s.Name.decode('utf-8', errors='replace').rstrip('\x00')
        print(f"    {name:10s} VA=0x{s.VirtualAddress:08X} Size=0x{s.SizeOfRawData:08X} Flags=0x{s.Characteristics:08X}")
    return pe

def get_text_section(pe):
    for s in pe.sections:
        name = s.Name.decode('utf-8', errors='replace').rstrip('\x00')
        if '.text' in name:
            return s
    # fallback: first executable section
    for s in pe.sections:
        if s.Characteristics & 0x20000000:  # IMAGE_SCN_MEM_EXECUTE
            return s
    return None

def find_export(pe, name):
    """Find an export by name, return its RVA."""
    if not hasattr(pe, 'DIRECTORY_ENTRY_EXPORT'):
        pe.parse_data_directories(directories=[pefile.DIRECTORY_ENTRY['IMAGE_DIRECTORY_ENTRY_EXPORT']])
    for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
        if exp.name and exp.name.decode('utf-8', errors='replace') == name:
            return exp.address
    return None

def disasm_at_rva(pe, text_section, rva, count_bytes, label=""):
    """Disassemble count_bytes at the given RVA."""
    base = pe.OPTIONAL_HEADER.ImageBase
    file_offset = pe.get_offset_from_rva(rva)
    data = pe.get_data(rva, count_bytes)
    va = base + rva

    md = Cs(CS_ARCH_X86, CS_MODE_64)
    md.detail = True

    if label:
        print(f"\n{'='*70}")
        print(f"  {label} (VA=0x{va:016X}, RVA=0x{rva:08X})")
        print(f"{'='*70}")

    lines = []
    for insn in md.disasm(data, va):
        line = f"  0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}"
        lines.append(line)
        print(line)
    return lines


def analyze_patterns(pe, text_section, scan_size=1024*1024):
    """Search first 1MB of .text for interesting patterns."""
    base = pe.OPTIONAL_HEADER.ImageBase
    text_rva = text_section.VirtualAddress
    text_data = text_section.get_data()
    scan_end = min(scan_size, len(text_data))
    data = text_data[:scan_end]

    print(f"\n{'='*70}")
    print(f"  PATTERN ANALYSIS (first {scan_end//1024}KB of .text)")
    print(f"{'='*70}")

    md = Cs(CS_ARCH_X86, CS_MODE_64)
    md.detail = True

    # Pattern counters
    lea_call_count = 0
    xor_ret_count = 0
    nop_sled_count = 0
    int3_count = 0
    lea_call_examples = []
    xor_ret_examples = []
    nop_sled_examples = []

    # Disassemble in one pass for pattern matching
    instructions = list(md.disasm(data, base + text_rva))
    print(f"  Total instructions disassembled: {len(instructions)}")

    for i, insn in enumerate(instructions):
        # Pattern 1: lea rax/rcx/rdx, [rip+...] followed by call
        if insn.mnemonic == 'lea' and 'rip' in insn.op_str:
            if i + 1 < len(instructions) and instructions[i+1].mnemonic == 'call':
                lea_call_count += 1
                if len(lea_call_examples) < 5:
                    lea_call_examples.append(
                        f"    0x{insn.address:X}: {insn.mnemonic} {insn.op_str}\n"
                        f"    0x{instructions[i+1].address:X}: {instructions[i+1].mnemonic} {instructions[i+1].op_str}"
                    )

        # Pattern 2: xor reg,reg followed by ret
        if insn.mnemonic == 'xor':
            parts = insn.op_str.split(',')
            if len(parts) == 2 and parts[0].strip() == parts[1].strip():
                if i + 1 < len(instructions) and instructions[i+1].mnemonic == 'ret':
                    xor_ret_count += 1
                    if len(xor_ret_examples) < 5:
                        xor_ret_examples.append(
                            f"    0x{insn.address:X}: {insn.mnemonic} {insn.op_str}; ret"
                        )

        # Pattern 3: nop sleds (>8 consecutive nops)
        if insn.mnemonic == 'nop':
            count = 1
            j = i + 1
            while j < len(instructions) and instructions[j].mnemonic == 'nop':
                count += 1
                j += 1
            if count > 8 and (i == 0 or instructions[i-1].mnemonic != 'nop'):
                nop_sled_count += 1
                if len(nop_sled_examples) < 3:
                    nop_sled_examples.append(
                        f"    0x{insn.address:X}: {count} consecutive NOPs"
                    )

        # Pattern 4: int3
        if insn.mnemonic == 'int3':
            int3_count += 1

    print(f"\n  [Pattern 1] LEA [rip+...] + CALL (string refs): {lea_call_count}")
    for ex in lea_call_examples:
        print(ex)

    print(f"\n  [Pattern 2] XOR reg,reg + RET (stub/patched functions): {xor_ret_count}")
    for ex in xor_ret_examples:
        print(ex)

    print(f"\n  [Pattern 3] NOP sleds (>8 NOPs): {nop_sled_count}")
    for ex in nop_sled_examples:
        print(ex)

    print(f"\n  [Pattern 4] INT3 breakpoints: {int3_count}")

    return instructions


def count_function_prologues(pe, text_section, scan_size=1024*1024):
    """Count standard function prologues in first 1MB."""
    text_data = text_section.get_data()
    scan_end = min(scan_size, len(text_data))
    data = text_data[:scan_end]

    print(f"\n{'='*70}")
    print(f"  FUNCTION PROLOGUE ANALYSIS")
    print(f"{'='*70}")

    # Pattern: push rbp; mov rbp, rsp = 55 48 89 E5
    push_rbp_mov = b'\x55\x48\x89\xe5'
    # Pattern: sub rsp, imm8 = 48 83 EC xx
    sub_rsp_imm8 = b'\x48\x83\xec'
    # Pattern: sub rsp, imm32 = 48 81 EC xx xx xx xx
    sub_rsp_imm32 = b'\x48\x81\xec'
    # Pattern: push rbp alone (often followed by other pushes)
    push_rbp = b'\x55'

    count_classic = 0  # push rbp; mov rbp, rsp
    count_sub_rsp = 0  # sub rsp, ...
    count_push_rbp = 0  # push rbp (any context)

    i = 0
    while i < scan_end - 4:
        if data[i:i+4] == push_rbp_mov:
            count_classic += 1
            i += 4
        elif data[i:i+3] == sub_rsp_imm8:
            count_sub_rsp += 1
            i += 4
        elif data[i:i+3] == sub_rsp_imm32:
            count_sub_rsp += 1
            i += 7
        else:
            i += 1

    # Also count push rbp occurrences
    i = 0
    while i < scan_end:
        idx = data.find(push_rbp, i)
        if idx == -1:
            break
        count_push_rbp += 1
        i = idx + 1

    print(f"  push rbp; mov rbp, rsp (classic frame): {count_classic}")
    print(f"  sub rsp, imm (frameless alloc): {count_sub_rsp}")
    print(f"  push rbp (any context): {count_push_rbp}")
    print(f"  Estimated function count (classic + sub rsp): {count_classic + count_sub_rsp}")


def sample_random_offsets(pe, text_section, num_samples=10, bytes_each=50):
    """Sample random locations in .text to see typical code."""
    base = pe.OPTIONAL_HEADER.ImageBase
    text_rva = text_section.VirtualAddress
    text_data = text_section.get_data()
    text_size = len(text_data)

    print(f"\n{'='*70}")
    print(f"  RANDOM SAMPLES ({num_samples} locations, {bytes_each} bytes each)")
    print(f"{'='*70}")

    random.seed(42)  # reproducible
    offsets = sorted(random.sample(range(0, text_size - bytes_each), num_samples))

    md = Cs(CS_ARCH_X86, CS_MODE_64)
    md.detail = True

    for idx, offset in enumerate(offsets):
        va = base + text_rva + offset
        chunk = text_data[offset:offset+bytes_each]
        print(f"\n  --- Sample {idx+1}: offset=0x{offset:08X}, VA=0x{va:016X} ---")
        for insn in md.disasm(chunk, va):
            print(f"    0x{insn.address:016X}: {insn.mnemonic:8s} {insn.op_str}")


def list_il2cpp_exports(pe, max_show=30):
    """List IL2CPP-related exports."""
    print(f"\n{'='*70}")
    print(f"  IL2CPP EXPORTS")
    print(f"{'='*70}")

    if not hasattr(pe, 'DIRECTORY_ENTRY_EXPORT'):
        pe.parse_data_directories(directories=[pefile.DIRECTORY_ENTRY['IMAGE_DIRECTORY_ENTRY_EXPORT']])

    il2cpp_exports = []
    all_exports = []
    for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
        if exp.name:
            name = exp.name.decode('utf-8', errors='replace')
            all_exports.append((name, exp.address))
            if 'il2cpp' in name.lower():
                il2cpp_exports.append((name, exp.address))

    print(f"  Total exports: {len(all_exports)}")
    print(f"  IL2CPP exports: {len(il2cpp_exports)}")
    print(f"\n  First {min(max_show, len(il2cpp_exports))} il2cpp exports:")
    for name, rva in sorted(il2cpp_exports)[:max_show]:
        print(f"    {name:50s} RVA=0x{rva:08X}")

    return il2cpp_exports


def main():
    pe = load_pe()
    text_section = get_text_section(pe)
    if not text_section:
        print("ERROR: No .text section found!")
        return

    text_name = text_section.Name.decode('utf-8', errors='replace').rstrip('\x00')
    print(f"\n  Using section: {text_name}, size={len(text_section.get_data())} bytes")

    # 1. List IL2CPP exports
    il2cpp_exports = list_il2cpp_exports(pe)

    # 2. Disassemble DllMain (entry point)
    entry_rva = pe.OPTIONAL_HEADER.AddressOfEntryPoint
    disasm_at_rva(pe, text_section, entry_rva, 1000, "DllMain / Entry Point (first 1000 bytes)")

    # 3. Find and disassemble il2cpp_init
    init_rva = find_export(pe, "il2cpp_init")
    if init_rva:
        disasm_at_rva(pe, text_section, init_rva, 200, "il2cpp_init (first 200 bytes)")
    else:
        print("\n  WARNING: il2cpp_init export not found!")
        # Try il2cpp_init_utf16
        init_rva = find_export(pe, "il2cpp_init_utf16")
        if init_rva:
            disasm_at_rva(pe, text_section, init_rva, 200, "il2cpp_init_utf16 (first 200 bytes)")

    # 4. Pattern analysis
    analyze_patterns(pe, text_section)

    # 5. Function prologue count
    count_function_prologues(pe, text_section)

    # 6. Random samples
    sample_random_offsets(pe, text_section)

    print(f"\n{'='*70}")
    print("  ANALYSIS COMPLETE")
    print(f"{'='*70}")


if __name__ == "__main__":
    main()

