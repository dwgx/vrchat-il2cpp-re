#!/usr/bin/env python3
"""
Reverse-engineer the decrypt function chain in GameAssembly.dll.

Target RVAs:
  0xAC6B10 - snprintf_s dispatcher (calls 0xA7BBE0 then 0xB188B8)
  0xAC6B80 - GUID/hash hex-formatter wrapper (reads key bytes, formats via snprintf_s)
  0xA7BBE0 - returns CRT locale vtable pointer (lea rax, [rip+disp]; ret)
  0xB188B8 - common_vsprintf (the CRT printf engine, 290 insns)
  0xB12E80 - _output_s (format output with security checks, 112 insns)

Key finding: 0xAC6B80 is NOT a decrypt function. It formats 16 bytes + 1 DWORD
from a global structure as a hex string using "%02hhX" * 16 + "%X".
The structure at RVA 0xC09CED0 in .rdata contains the key/hash bytes.

Uses capstone for disassembly, mmap for memory-efficient access.
"""
from __future__ import annotations

import mmap
import struct
import sys
from pathlib import Path

from capstone import Cs, CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_INTEL

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

GA_PATH = Path(r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll")
OUT_DIR = Path(r"D:\Project\vrchat-il2cpp-re\output\p2_research")
OUT_DIR.mkdir(parents=True, exist_ok=True)

TEXT_VA = 0x1000
TEXT_RAW_OFF = 0x400
TEXT_RAW_SIZE = 0xB41400

SECTIONS = [
    (".text",  0x00001000, 0x00B41220, 0x00000400, 0x00B41400),
    ("il2cpp", 0x00B43000, 0x09D38F3C, 0x00B41800, 0x09D39000),
    (".rdata", 0x0A87C000, 0x0224A1AE, 0x0A87A800, 0x0224A200),
    (".data",  0x0CAC7000, 0x00C2CE44, 0x0CAC4A00, 0x0093DA00),
    (".pdata", 0x0D6F4000, 0x006E5D10, 0x0D402400, 0x006E5E00),
    (".reloc", 0x0DDDA000, 0x0031672C, 0x0DAE8200, 0x00316800),
]


def rva_to_file(rva):
    return TEXT_RAW_OFF + (rva - TEXT_VA)


def rva_to_file_any(rva):
    for name, va, vsize, raw_off, raw_size in SECTIONS:
        if va <= rva < va + vsize:
            return raw_off + (rva - va), name
    return None, None


def disasm_func(mm, cs, start_rva, max_bytes=8192):
    """Disassemble from start_rva until ret or int3 padding."""
    file_off = rva_to_file(start_rva)
    code = mm[file_off:file_off + max_bytes]
    instructions = []
    for insn in cs.disasm(code, start_rva):
        if insn.mnemonic == 'int3':
            next_off = insn.address - start_rva + insn.size
            if next_off < len(code) and code[next_off] == 0xCC:
                break
            instructions.append(insn)
            continue
        instructions.append(insn)
        if insn.mnemonic == 'ret':
            break
    return instructions


def format_listing(instructions):
    lines = []
    for insn in instructions:
        lines.append(
            f"  0x{insn.address:X}:  {insn.bytes.hex():<24s}  "
            f"{insn.mnemonic:<8s} {insn.op_str}"
        )
    return lines


def main():
    print(f"Opening {GA_PATH} ...")
    with open(GA_PATH, 'rb') as f:
        mm = mmap.mmap(f.fileno(), 0, access=mmap.ACCESS_READ)

        pe_off = struct.unpack_from('<I', mm, 0x3C)[0]
        image_base = struct.unpack_from('<Q', mm, pe_off + 24 + 24)[0]
        print(f"Image base: 0x{image_base:X}")
        print(f"PE offset: 0x{pe_off:X}")

        cs = Cs(CS_ARCH_X86, CS_MODE_64)
        cs.syntax = CS_OPT_SYNTAX_INTEL

        # ===== 1. Disassemble all target functions =====
        targets = {
            0xAC6B10: "snprintf_s dispatcher",
            0xAC6B80: "hex-formatter wrapper",
            0xA7BBE0: "locale vtable getter",
            0xB188B8: "common_vsprintf",
        }

        listings = {}
        for rva, name in targets.items():
            print(f"\n{'='*70}")
            print(f"RVA 0x{rva:X} - {name}")
            print(f"{'='*70}")
            insns = disasm_func(mm, cs, rva)
            listing = format_listing(insns)
            listings[rva] = listing
            print(f"  {len(insns)} instructions")
            for line in listing[:80]:
                print(line)
            if len(listing) > 80:
                print(f"  ... ({len(listing)-80} more)")

        # ===== 2. Resolve the structure pointer =====
        print(f"\n{'='*70}")
        print("Structure resolution")
        print(f"{'='*70}")

        # Wrapper addressing: movsxd rax, [rip+disp] -> reads pe_offset from RVA 0x3C
        # lea rbx, [rip+disp] -> rbx = 0 (imagebase-relative)
        # mov ecx, [rax + rbx + 0xB8] -> reads from RVA pe_off + 0xB8
        struct_ptr_rva = pe_off + 0xB8
        # In file, that's just file offset pe_off + 0xB8 = 0x1E0
        struct_rva = struct.unpack_from('<I', mm, struct_ptr_rva)[0]
        print(f"  PE header offset: 0x{pe_off:X}")
        print(f"  Reads struct pointer from file offset 0x{struct_ptr_rva:X}")
        print(f"  Struct RVA: 0x{struct_rva:X}")

        struct_foff, struct_section = rva_to_file_any(struct_rva)
        print(f"  Section: {struct_section}, file offset: 0x{struct_foff:X}")

        # Read structure
        struct_data = mm[struct_foff:struct_foff + 64]
        print(f"\n  Structure dump (64 bytes):")
        for i in range(0, 64, 16):
            h = struct_data[i:i+16].hex(' ')
            a = ''.join(chr(b) if 32 <= b < 127 else '.' for b in struct_data[i:i+16])
            print(f"    +0x{i:02X}: {h}  |{a}|")

        # The wrapper reads bytes from [ecx + rbx + offset] where ecx=struct_rva, rbx=0
        # So it reads from absolute RVA struct_rva + offset
        # But wait - after the first mov ecx, the addressing changes
        # Actually ecx becomes the VALUE at struct_rva + 0xB8... no.
        # Let me re-read the wrapper more carefully:
        #   movsxd rax, [rip+disp]  -> rax = pe_offset (0x128)
        #   lea rbx, [rip+disp]     -> rbx = 0 (image base relative)
        #   mov ecx, [rax+rbx+0xB8] -> ecx = DWORD at RVA 0x1E0 = 0x0C09CED0
        #   cmp [rcx+rbx+0xC], 2    -> check DWORD at RVA 0x0C09CED0 + 0xC
        # So the struct is at RVA 0x0C09CED0 and fields are read relative to it.

        # Key byte extraction pattern (from the wrapper disasm):
        # After the initial loads, rcx still = struct_rva, rbx = imagebase(=0)
        # movzx r13d, byte ptr [rcx + rbx + 0x11] -> struct[0x11]
        # movzx edx, byte ptr [rcx + rbx + 0x10]  -> struct[0x10]
        # etc.

        # But then lea rdx, [rip - 0xac6c30] -> rdx = 0
        # And lea r13, [rip - 0xac6c3f] -> r13 = 0 as well (same pattern)
        # So [rcx + r13 + 4] = struct[4], etc.

        print(f"\n  Key bytes extracted by wrapper:")
        byte_map = {}
        offsets_first = [0x08, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11]
        offsets_second = [0x04, 0x06, 0x07, 0x09]  # via r13 base
        offsets_third = [0x12, 0x13]  # via rdx base
        all_offsets = sorted(set(offsets_first + offsets_second + offsets_third +
                                 [0x14]))

        for off in range(0x04, 0x18):
            val = struct_data[off]
            byte_map[off] = val
            print(f"    struct+0x{off:02X} = 0x{val:02X} ({val:3d})")

        # The DWORD at +0x14
        dword_14 = struct.unpack_from('<I', struct_data, 0x14)[0]
        print(f"    struct+0x14 (DWORD) = 0x{dword_14:08X}")

        # Format what the hex output would look like
        # Format: "%02hhX" * 16 + "%X"
        # The 16 bytes come from struct offsets, and the final %X is the DWORD at +0x14
        # Byte order from wrapper stack pushes (bottom to top = first to last arg):
        # [rsp+0x20]=ecx(+07), [rsp+0x28]=r8d(+06), [rsp+0x30]=r9d(+05 via shr),
        # [rsp+0x38]=r10d(+04), [rsp+0x40]=r11d(+09), [rsp+0x48]=ebx(+08),
        # [rsp+0x50]=edi(+0B), [rsp+0x58]=esi(+0A), [rsp+0x60]=ebp(+0C),
        # [rsp+0x68]=r14d(+0D), [rsp+0x70]=r15d(+0E), [rsp+0x78]=r12d(+0F),
        # [rsp+0x80]=edx(+10), [rsp+0x88]=r13d(+11), [rsp+0x90]=eax(+12),
        # [rsp+0x98]=eax(+13), [rsp+0xA0]=dword(+14)

        # The snprintf_s calling convention: rcx=buffer, rdx=size(0x29),
        # r8=maxcount(0x28), r9=format_string, then stack params are the varargs
        # Stack params start at [rsp+0x20] for the callee

        # Reconstruct the byte order for formatting:
        byte_order = [0x07, 0x06, 0x05, 0x04, 0x09, 0x08,
                      0x0B, 0x0A, 0x0C, 0x0D, 0x0E, 0x0F,
                      0x10, 0x11, 0x12, 0x13]
        hex_result = ""
        for off in byte_order:
            hex_result += f"{struct_data[off]:02X}"
        hex_result += f"{dword_14:X}"
        print(f"\n  Formatted hex output: {hex_result}")
        print(f"  (16 bytes as hex + DWORD without padding)")

        # Check what this looks like - is it a GUID?
        # Standard GUID format: DWORD-WORD-WORD-2bytes-6bytes
        # Or it could be a hash/fingerprint
        dw = struct.unpack_from('<I', struct_data, 0x04)[0]
        print(f"\n  Interpreting as possible GUID/hash:")
        print(f"    DWORD at +04: 0x{dw:08X} (0x{struct_data[4]:02X}{struct_data[5]:02X}{struct_data[6]:02X}{struct_data[7]:02X})")
        print(f"    Bytes 08-0B: {struct_data[8]:02X} {struct_data[9]:02X} {struct_data[10]:02X} {struct_data[11]:02X}")
        print(f"    Bytes 0C-13: {struct_data[0xC]:02X} {struct_data[0xD]:02X} {struct_data[0xE]:02X} {struct_data[0xF]:02X} {struct_data[0x10]:02X} {struct_data[0x11]:02X} {struct_data[0x12]:02X} {struct_data[0x13]:02X}")

        # ===== 3. Resolve format string =====
        print(f"\n{'='*70}")
        print("Format string")
        print(f"{'='*70}")
        # lea r9, [rip + 0xb5c5bef] at 0xAC6CEA -> target RVA 0xC08C8E0
        fmt_rva = 0xC08C8E0
        fmt_foff, fmt_sec = rva_to_file_any(fmt_rva)
        fmt_data = mm[fmt_foff:fmt_foff + 128]
        end = fmt_data.find(b'\x00')
        fmt_str = fmt_data[:end].decode('ascii') if end > 0 else "?"
        print(f"  RVA: 0x{fmt_rva:X}, section: {fmt_sec}")
        print(f"  String: '{fmt_str}'")
        print(f"  Length: {end} bytes")

        # ===== 4. Find callers =====
        print(f"\n{'='*70}")
        print("Call graph")
        print(f"{'='*70}")
        text_data = mm[TEXT_RAW_OFF:TEXT_RAW_OFF + TEXT_RAW_SIZE]

        for target_rva, name in [(0xAC6B80, "hex-formatter"), (0xAC6B10, "snprintf_s")]:
            callers = []
            for pos in range(len(text_data) - 5):
                if text_data[pos] == 0xE8:
                    disp = struct.unpack_from('<i', text_data, pos + 1)[0]
                    call_rva = TEXT_VA + pos
                    dest = call_rva + 5 + disp
                    if dest == target_rva:
                        callers.append(call_rva)
            print(f"  0x{target_rva:X} ({name}): {len(callers)} callers: "
                  f"{', '.join(f'0x{c:X}' for c in callers[:10])}")

        # ===== 5. Disassemble one level up: 0xA8828B caller context =====
        print(f"\n{'='*70}")
        print("Caller context: RVA 0xA88240 area (calls 0xAC6B80)")
        print(f"{'='*70}")
        # Function around 0xA8828B - look back for CC padding
        pos = 0xA8828B - TEXT_VA
        func_start = 0xA8828B
        for back in range(pos - 1, max(0, pos - 2048), -1):
            if text_data[back] == 0xCC and (back == 0 or text_data[back-1] == 0xCC):
                func_start = TEXT_VA + back + 1
                break
        caller_insns = disasm_func(mm, cs, func_start, max_bytes=4096)
        caller_listing = format_listing(caller_insns)
        print(f"  Function at 0x{func_start:X}, {len(caller_insns)} insns")
        for line in caller_listing[:60]:
            print(line)
        if len(caller_listing) > 60:
            print(f"  ... ({len(caller_listing)-60} more)")

        # ===== 6. Disassemble 0xA9B5E0 (second caller context) =====
        print(f"\n{'='*70}")
        print("Caller context: RVA 0xA9B5E0 (calls 0xAC6B80 at 0xA9B66E)")
        print(f"{'='*70}")
        caller2_insns = disasm_func(mm, cs, 0xA9B5E0, max_bytes=4096)
        caller2_listing = format_listing(caller2_insns)
        print(f"  Function at 0xA9B5E0, {len(caller2_insns)} insns")
        for line in caller2_listing[:60]:
            print(line)
        if len(caller2_listing) > 60:
            print(f"  ... ({len(caller2_listing)-60} more)")

        mm.close()

    # ===== Generate final report =====
    write_report(listings, struct_data, struct_rva, fmt_str, hex_result,
                 byte_order, dword_14, caller_listing, caller2_listing)


def write_report(listings, struct_data, struct_rva, fmt_str, hex_result,
                 byte_order, dword_14, caller1_listing, caller2_listing):
    report_path = OUT_DIR / "decrypt_chain_analysis.md"
    print(f"\nWriting report to {report_path}")
    L = []
    L.append("# Decrypt Function Chain Analysis")
    L.append("")
    L.append("Date: 2026-07-04")
    L.append("Target: GameAssembly.dll (232MB, jun26 VRChat build)")
    L.append("Tool: Python + capstone + mmap")
    L.append("")
    L.append("## Key Finding")
    L.append("")
    L.append("**0xAC6B80 and 0xAC6B10 are NOT decrypt functions.**")
    L.append("")
    L.append("They form a hex-formatting chain that converts 16 raw bytes + 1 DWORD")
    L.append("from a global structure into a hex string. The call chain is:")
    L.append("")
    L.append("```")
    L.append("0xAC6B80 (hex-formatter wrapper)")
    L.append("  - Reads 16 bytes from global struct at RVA 0xC09CED0 (.rdata)")
    L.append("  - Reads 1 DWORD from struct+0x14")
    L.append("  - Passes format string \"%02hhX\" * 16 + \"%X\" to snprintf_s")
    L.append("  |")
    L.append("  +-> 0xAC6B10 (snprintf_s)")
    L.append("        |")
    L.append("        +-> 0xA7BBE0 (lea rax, [locale_vtable]; ret)")
    L.append("        +-> 0xB188B8 (common_vsprintf, 290 insns)")
    L.append("              |")
    L.append("              +-> 0xB12E80 (_output_s, 112 insns)")
    L.append("              +-> 0xB12D04 (error handler)")
    L.append("              +-> 0xB16008 (format state machine)")
    L.append("              +-> 0xB21AE8 (cleanup)")
    L.append("```")
    L.append("")
    L.append("## Global Structure (RVA 0xC09CED0, .rdata)")
    L.append("")
    L.append("```")
    for i in range(0, 64, 16):
        h = struct_data[i:i+16].hex(' ')
        a = ''.join(chr(b) if 32 <= b < 127 else '.' for b in struct_data[i:i+16])
        L.append(f"  +0x{i:02X}: {h}  |{a}|")
    L.append("```")
    L.append("")
    L.append("### Key Bytes Extracted")
    L.append("")
    L.append("The wrapper reads individual bytes via movzx from struct offsets +0x04 to +0x13,")
    L.append("plus a DWORD at +0x14. These are formatted as hex using the format string.")
    L.append("")
    L.append("```")
    for off in range(0x04, 0x18):
        L.append(f"  +0x{off:02X} = 0x{struct_data[off]:02X}")
    L.append(f"  +0x14 (DWORD) = 0x{dword_14:08X}")
    L.append("```")
    L.append("")
    L.append(f"### Reconstructed Hex Output")
    L.append("")
    L.append(f"Format: `{fmt_str}`")
    L.append("")
    L.append(f"Result: `{hex_result}`")
    L.append("")
    L.append("Byte read order (wrapper stack param sequence):")
    L.append(f"  {', '.join(f'+0x{o:02X}' for o in byte_order)}, then DWORD+0x14")
    L.append("")
    L.append("## Function Identity")
    L.append("")
    L.append("| RVA | Identity | Evidence |")
    L.append("|-----|----------|----------|")
    L.append("| 0xAC6B80 | Hex format wrapper | Reads bytes, pushes to stack with format string |")
    L.append("| 0xAC6B10 | `_snprintf_s` | Thin wrapper: gets locale, calls vsprintf, error check |")
    L.append("| 0xA7BBE0 | Locale getter | Single `lea rax, [.data]; ret` |")
    L.append("| 0xB188B8 | `common_vsprintf` | 290 insns, calls _output_s, has stack cookie |")
    L.append("| 0xB12E80 | `_output_s` | 112 insns, format parsing with loops |")
    L.append("| 0xB18EC4 | `_bsearch_s` | Binary search with magic constant 0x9375b7955ede8970 |")
    L.append("")
    L.append("## Callers of 0xAC6B80")
    L.append("")
    L.append("Only 2 call sites in the entire binary:")
    L.append("- RVA 0xA8828B")
    L.append("- RVA 0xA9B66E (in function 0xA9B5E0)")
    L.append("")
    L.append("## Wrapper (0xAC6B80) - Full Disassembly")
    L.append("")
    L.append("```asm")
    for line in listings[0xAC6B80]:
        L.append(line)
    L.append("```")
    L.append("")
    L.append("### Addressing Scheme")
    L.append("")
    L.append("The wrapper uses MSVC `__ImageBase`-relative addressing:")
    L.append("1. `movsxd rax, [rip+disp]` loads the PE offset (e_lfanew = 0x128) from RVA 0x3C")
    L.append("2. `lea rbx, [rip+disp]` sets rbx = 0 (imagebase-relative at RVA level)")
    L.append("3. `mov ecx, [rax+rbx+0xB8]` reads DWORD at file offset 0x1E0 = struct RVA 0x0C09CED0")
    L.append("4. `cmp [rcx+rbx+0xC], 2` verifies struct type field == 2")
    L.append("5. Reads 16+ bytes via movzx and formats them")
    L.append("")
    L.append("### Parameter Passing to snprintf_s")
    L.append("")
    L.append("```")
    L.append("rcx = buffer (from prior 'call rax' which allocates)")
    L.append("edx = 0x29 (buffer size = 41 bytes)")
    L.append("r8d = 0x28 (max count = 40 chars)")
    L.append("r9  = format string at RVA 0xC08C8E0")
    L.append("[rsp+0x20..0xA0] = 16 byte values + 1 DWORD (varargs)")
    L.append("```")
    L.append("")
    L.append("## Executor/snprintf_s (0xAC6B10) - Full Disassembly")
    L.append("")
    L.append("```asm")
    for line in listings[0xAC6B10]:
        L.append(line)
    L.append("```")
    L.append("")
    L.append("## common_vsprintf (0xB188B8) - First 100 Instructions")
    L.append("")
    L.append("```asm")
    for line in listings[0xB188B8][:100]:
        L.append(line)
    if len(listings[0xB188B8]) > 100:
        L.append(f"  ... ({len(listings[0xB188B8])-100} more instructions)")
    L.append("```")
    L.append("")
    L.append("## Caller Context: 0xA8828B")
    L.append("")
    L.append("```asm")
    for line in caller1_listing[:60]:
        L.append(line)
    if len(caller1_listing) > 60:
        L.append(f"  ... ({len(caller1_listing)-60} more)")
    L.append("```")
    L.append("")
    L.append("## Caller Context: 0xA9B5E0")
    L.append("")
    L.append("```asm")
    for line in caller2_listing[:60]:
        L.append(line)
    if len(caller2_listing) > 60:
        L.append(f"  ... ({len(caller2_listing)-60} more)")
    L.append("```")
    L.append("")
    L.append("## Implications for Decrypt Research")
    L.append("")
    L.append("These functions are **CRT string formatting**, not metadata decryption.")
    L.append("The actual metadata decrypt logic (position-based XOR ramp, per trackB findings)")
    L.append("lives elsewhere. The structure at 0xC09CED0 likely holds a build identifier")
    L.append("or license key that gets formatted as a hex string for logging/verification.")
    L.append("")
    L.append("The real decrypt chain for metadata is documented in trackB_findings.md:")
    L.append("- Algorithm: `plain[f] = enc[f] XOR ((f + K) & 0xFF)` per section")
    L.append("- Header: non-linear PRNG keystream (prefix recovered)")
    L.append("- The decrypt code is likely inlined or in the metadata loader (~0xAEF640 area)")

    report_path.write_text('\n'.join(L), encoding='utf-8')
    print(f"Done. {len(L)} lines written.")


if __name__ == '__main__':
    main()
