# Decrypt Function Chain Analysis

Date: 2026-07-04
Target: GameAssembly.dll (232MB, jun26 VRChat build)
Tool: Python + capstone + mmap

## Key Finding

**0xAC6B80 and 0xAC6B10 are NOT decrypt functions.**

They form a hex-formatting chain that converts 16 raw bytes + 1 DWORD
from a global structure into a hex string. The call chain is:

```
0xAC6B80 (hex-formatter wrapper)
  - Reads 16 bytes from global struct at RVA 0xC09CED0 (.rdata)
  - Reads 1 DWORD from struct+0x14
  - Passes format string "%02hhX" * 16 + "%X" to snprintf_s
  |
  +-> 0xAC6B10 (snprintf_s)
        |
        +-> 0xA7BBE0 (lea rax, [locale_vtable]; ret)
        +-> 0xB188B8 (common_vsprintf, 290 insns)
              |
              +-> 0xB12E80 (_output_s, 112 insns)
              +-> 0xB12D04 (error handler)
              +-> 0xB16008 (format state machine)
              +-> 0xB21AE8 (cleanup)
```

## Global Structure (RVA 0xC09CED0, .rdata)

```
  +0x00: 00 00 00 00 ec 9a 3d 6a 00 00 00 00 02 00 00 00  |......=j........|
  +0x10: 75 00 00 00 54 f9 55 0c 54 e1 55 0c 00 00 00 00  |u...T.U.T.U.....|
  +0x20: ec 9a 3d 6a 00 00 00 00 0c 00 00 00 14 00 00 00  |..=j............|
  +0x30: cc f9 55 0c cc e1 55 0c 00 00 00 00 ec 9a 3d 6a  |..U...U.......=j|
```

### Key Bytes Extracted

The wrapper reads individual bytes via movzx from struct offsets +0x04 to +0x13,
plus a DWORD at +0x14. These are formatted as hex using the format string.

```
  +0x04 = 0xEC
  +0x05 = 0x9A
  +0x06 = 0x3D
  +0x07 = 0x6A
  +0x08 = 0x00
  +0x09 = 0x00
  +0x0A = 0x00
  +0x0B = 0x00
  +0x0C = 0x02
  +0x0D = 0x00
  +0x0E = 0x00
  +0x0F = 0x00
  +0x10 = 0x75
  +0x11 = 0x00
  +0x12 = 0x00
  +0x13 = 0x00
  +0x14 = 0x54
  +0x15 = 0xF9
  +0x16 = 0x55
  +0x17 = 0x0C
  +0x14 (DWORD) = 0x0C55F954
```

### Reconstructed Hex Output

Format: `%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%02hhX%X`

Result: `6A3D9AEC000000000200000075000000C55F954`

Byte read order (wrapper stack param sequence):
  +0x07, +0x06, +0x05, +0x04, +0x09, +0x08, +0x0B, +0x0A, +0x0C, +0x0D, +0x0E, +0x0F, +0x10, +0x11, +0x12, +0x13, then DWORD+0x14

## Function Identity

| RVA | Identity | Evidence |
|-----|----------|----------|
| 0xAC6B80 | Hex format wrapper | Reads bytes, pushes to stack with format string |
| 0xAC6B10 | `_snprintf_s` | Thin wrapper: gets locale, calls vsprintf, error check |
| 0xA7BBE0 | Locale getter | Single `lea rax, [.data]; ret` |
| 0xB188B8 | `common_vsprintf` | 290 insns, calls _output_s, has stack cookie |
| 0xB12E80 | `_output_s` | 112 insns, format parsing with loops |
| 0xB18EC4 | `_bsearch_s` | Binary search with magic constant 0x9375b7955ede8970 |

## Callers of 0xAC6B80

Only 2 call sites in the entire binary:
- RVA 0xA8828B
- RVA 0xA9B66E (in function 0xA9B5E0)

## Wrapper (0xAC6B80) - Full Disassembly

```asm
  0xAC6B80:  4c8bdc                    mov      r11, rsp
  0xAC6B83:  53                        push     rbx
  0xAC6B84:  4881ecf0000000            sub      rsp, 0xf0
  0xAC6B8B:  486305aa9453ff            movsxd   rax, dword ptr [rip - 0xac6b56]
  0xAC6B92:  488d1d679453ff            lea      rbx, [rip - 0xac6b99]
  0xAC6B99:  8b8c18b8000000            mov      ecx, dword ptr [rax + rbx + 0xb8]
  0xAC6BA0:  837c190c02                cmp      dword ptr [rcx + rbx + 0xc], 2
  0xAC6BA5:  0f85ab010000              jne      0xac6d56
  0xAC6BAB:  8b441914                  mov      eax, dword ptr [rcx + rbx + 0x14]
  0xAC6BAF:  b929000000                mov      ecx, 0x29
  0xAC6BB4:  49896bf0                  mov      qword ptr [r11 - 0x10], rbp
  0xAC6BB8:  498973e8                  mov      qword ptr [r11 - 0x18], rsi
  0xAC6BBC:  49897be0                  mov      qword ptr [r11 - 0x20], rdi
  0xAC6BC0:  4d8963d8                  mov      qword ptr [r11 - 0x28], r12
  0xAC6BC4:  4d896bd0                  mov      qword ptr [r11 - 0x30], r13
  0xAC6BC8:  4889842410010000          mov      qword ptr [rsp + 0x110], rax
  0xAC6BD0:  488b0551c9930c            mov      rax, qword ptr [rip + 0xc93c951]
  0xAC6BD7:  4d8973c8                  mov      qword ptr [r11 - 0x38], r14
  0xAC6BDB:  4d897bc0                  mov      qword ptr [r11 - 0x40], r15
  0xAC6BDF:  ffd0                      call     rax
  0xAC6BE1:  488b8c2410010000          mov      rcx, qword ptr [rsp + 0x110]
  0xAC6BE9:  4889842418010000          mov      qword ptr [rsp + 0x118], rax
  0xAC6BF1:  440fb66c1911              movzx    r13d, byte ptr [rcx + rbx + 0x11]
  0xAC6BF7:  0fb6541910                movzx    edx, byte ptr [rcx + rbx + 0x10]
  0xAC6BFC:  440fb664190f              movzx    r12d, byte ptr [rcx + rbx + 0xf]
  0xAC6C02:  440fb67c190e              movzx    r15d, byte ptr [rcx + rbx + 0xe]
  0xAC6C08:  440fb674190d              movzx    r14d, byte ptr [rcx + rbx + 0xd]
  0xAC6C0E:  0fb66c190c                movzx    ebp, byte ptr [rcx + rbx + 0xc]
  0xAC6C13:  0fb674190a                movzx    esi, byte ptr [rcx + rbx + 0xa]
  0xAC6C18:  0fb67c190b                movzx    edi, byte ptr [rcx + rbx + 0xb]
  0xAC6C1D:  0fb65c1908                movzx    ebx, byte ptr [rcx + rbx + 8]
  0xAC6C22:  89942408010000            mov      dword ptr [rsp + 0x108], edx
  0xAC6C29:  488d15d09353ff            lea      rdx, [rip - 0xac6c30]
  0xAC6C30:  4489ac2400010000          mov      dword ptr [rsp + 0x100], r13d
  0xAC6C38:  4c8d2dc19353ff            lea      r13, [rip - 0xac6c3f]
  0xAC6C3F:  428b442904                mov      eax, dword ptr [rcx + r13 + 4]
  0xAC6C44:  460fb6442906              movzx    r8d, byte ptr [rcx + r13 + 6]
  0xAC6C4A:  460fb65c2909              movzx    r11d, byte ptr [rcx + r13 + 9]
  0xAC6C50:  460fb6542904              movzx    r10d, byte ptr [rcx + r13 + 4]
  0xAC6C56:  420fb64c2907              movzx    ecx, byte ptr [rcx + r13 + 7]
  0xAC6C5C:  c1e808                    shr      eax, 8
  0xAC6C5F:  440fb6c8                  movzx    r9d, al
  0xAC6C63:  488b842410010000          mov      rax, qword ptr [rsp + 0x110]
  0xAC6C6B:  428b442814                mov      eax, dword ptr [rax + r13 + 0x14]
  0xAC6C70:  4c8bac2410010000          mov      r13, qword ptr [rsp + 0x110]
  0xAC6C78:  898424a0000000            mov      dword ptr [rsp + 0xa0], eax
  0xAC6C7F:  420fb6442a13              movzx    eax, byte ptr [rdx + r13 + 0x13]
  0xAC6C85:  89842498000000            mov      dword ptr [rsp + 0x98], eax
  0xAC6C8C:  420fb6442a12              movzx    eax, byte ptr [rdx + r13 + 0x12]
  0xAC6C92:  8b942408010000            mov      edx, dword ptr [rsp + 0x108]
  0xAC6C99:  448bac2400010000          mov      r13d, dword ptr [rsp + 0x100]
  0xAC6CA1:  89842490000000            mov      dword ptr [rsp + 0x90], eax
  0xAC6CA8:  4489ac2488000000          mov      dword ptr [rsp + 0x88], r13d
  0xAC6CB0:  89942480000000            mov      dword ptr [rsp + 0x80], edx
  0xAC6CB7:  ba29000000                mov      edx, 0x29
  0xAC6CBC:  4489642478                mov      dword ptr [rsp + 0x78], r12d
  0xAC6CC1:  44897c2470                mov      dword ptr [rsp + 0x70], r15d
  0xAC6CC6:  4489742468                mov      dword ptr [rsp + 0x68], r14d
  0xAC6CCB:  896c2460                  mov      dword ptr [rsp + 0x60], ebp
  0xAC6CCF:  89742458                  mov      dword ptr [rsp + 0x58], esi
  0xAC6CD3:  897c2450                  mov      dword ptr [rsp + 0x50], edi
  0xAC6CD7:  895c2448                  mov      dword ptr [rsp + 0x48], ebx
  0xAC6CDB:  44895c2440                mov      dword ptr [rsp + 0x40], r11d
  0xAC6CE0:  4489542438                mov      dword ptr [rsp + 0x38], r10d
  0xAC6CE5:  44894c2430                mov      dword ptr [rsp + 0x30], r9d
  0xAC6CEA:  4c8d0def5b5c0b            lea      r9, [rip + 0xb5c5bef]
  0xAC6CF1:  4489442428                mov      dword ptr [rsp + 0x28], r8d
  0xAC6CF6:  41b828000000              mov      r8d, 0x28
  0xAC6CFC:  894c2420                  mov      dword ptr [rsp + 0x20], ecx
  0xAC6D00:  488b8c2418010000          mov      rcx, qword ptr [rsp + 0x118]
  0xAC6D08:  e803feffff                call     0xac6b10
  0xAC6D0D:  488b842418010000          mov      rax, qword ptr [rsp + 0x118]
  0xAC6D15:  4c8bbc24b8000000          mov      r15, qword ptr [rsp + 0xb8]
  0xAC6D1D:  4c8bb424c0000000          mov      r14, qword ptr [rsp + 0xc0]
  0xAC6D25:  4c8bac24c8000000          mov      r13, qword ptr [rsp + 0xc8]
  0xAC6D2D:  4c8ba424d0000000          mov      r12, qword ptr [rsp + 0xd0]
  0xAC6D35:  488bbc24d8000000          mov      rdi, qword ptr [rsp + 0xd8]
  0xAC6D3D:  488bb424e0000000          mov      rsi, qword ptr [rsp + 0xe0]
  0xAC6D45:  488bac24e8000000          mov      rbp, qword ptr [rsp + 0xe8]
  0xAC6D4D:  4881c4f0000000            add      rsp, 0xf0
  0xAC6D54:  5b                        pop      rbx
  0xAC6D55:  c3                        ret      
```

### Addressing Scheme

The wrapper uses MSVC `__ImageBase`-relative addressing:
1. `movsxd rax, [rip+disp]` loads the PE offset (e_lfanew = 0x128) from RVA 0x3C
2. `lea rbx, [rip+disp]` sets rbx = 0 (imagebase-relative at RVA level)
3. `mov ecx, [rax+rbx+0xB8]` reads DWORD at file offset 0x1E0 = struct RVA 0x0C09CED0
4. `cmp [rcx+rbx+0xC], 2` verifies struct type field == 2
5. Reads 16+ bytes via movzx and formats them

### Parameter Passing to snprintf_s

```
rcx = buffer (from prior 'call rax' which allocates)
edx = 0x29 (buffer size = 41 bytes)
r8d = 0x28 (max count = 40 chars)
r9  = format string at RVA 0xC08C8E0
[rsp+0x20..0xA0] = 16 byte values + 1 DWORD (varargs)
```

## Executor/snprintf_s (0xAC6B10) - Full Disassembly

```asm
  0xAC6B10:  4c894c2420                mov      qword ptr [rsp + 0x20], r9
  0xAC6B15:  53                        push     rbx
  0xAC6B16:  55                        push     rbp
  0xAC6B17:  56                        push     rsi
  0xAC6B18:  57                        push     rdi
  0xAC6B19:  4156                      push     r14
  0xAC6B1B:  4883ec40                  sub      rsp, 0x40
  0xAC6B1F:  498be9                    mov      rbp, r9
  0xAC6B22:  4c8db42490000000          lea      r14, [rsp + 0x90]
  0xAC6B2A:  498bd8                    mov      rbx, r8
  0xAC6B2D:  488bfa                    mov      rdi, rdx
  0xAC6B30:  488bf1                    mov      rsi, rcx
  0xAC6B33:  e8a850fbff                call     0xa7bbe0
  0xAC6B38:  4c89742430                mov      qword ptr [rsp + 0x30], r14
  0xAC6B3D:  4c8bcb                    mov      r9, rbx
  0xAC6B40:  48c744242800000000        mov      qword ptr [rsp + 0x28], 0
  0xAC6B49:  4c8bc7                    mov      r8, rdi
  0xAC6B4C:  488bd6                    mov      rdx, rsi
  0xAC6B4F:  48896c2420                mov      qword ptr [rsp + 0x20], rbp
  0xAC6B54:  488b08                    mov      rcx, qword ptr [rax]
  0xAC6B57:  e85c1d0500                call     0xb188b8
  0xAC6B5C:  85c0                      test     eax, eax
  0xAC6B5E:  b9ffffffff                mov      ecx, 0xffffffff
  0xAC6B63:  0f48c1                    cmovs    eax, ecx
  0xAC6B66:  4883c440                  add      rsp, 0x40
  0xAC6B6A:  415e                      pop      r14
  0xAC6B6C:  5f                        pop      rdi
  0xAC6B6D:  5e                        pop      rsi
  0xAC6B6E:  5d                        pop      rbp
  0xAC6B6F:  5b                        pop      rbx
  0xAC6B70:  c3                        ret      
```

## common_vsprintf (0xB188B8) - First 100 Instructions

```asm
  0xB188B8:  488bc4                    mov      rax, rsp
  0xB188BB:  48895808                  mov      qword ptr [rax + 8], rbx
  0xB188BF:  48897010                  mov      qword ptr [rax + 0x10], rsi
  0xB188C3:  48897818                  mov      qword ptr [rax + 0x18], rdi
  0xB188C7:  4c896020                  mov      qword ptr [rax + 0x20], r12
  0xB188CB:  55                        push     rbp
  0xB188CC:  4156                      push     r14
  0xB188CE:  4157                      push     r15
  0xB188D0:  488bec                    mov      rbp, rsp
  0xB188D3:  4883ec70                  sub      rsp, 0x70
  0xB188D7:  488b4548                  mov      rax, qword ptr [rbp + 0x48]
  0xB188DB:  4533e4                    xor      r12d, r12d
  0xB188DE:  4c8965c0                  mov      qword ptr [rbp - 0x40], r12
  0xB188E2:  4d8bf1                    mov      r14, r9
  0xB188E5:  448865d0                  mov      byte ptr [rbp - 0x30], r12b
  0xB188E9:  498bf0                    mov      rsi, r8
  0xB188EC:  448865e8                  mov      byte ptr [rbp - 0x18], r12b
  0xB188F0:  488bda                    mov      rbx, rdx
  0xB188F3:  448865f0                  mov      byte ptr [rbp - 0x10], r12b
  0xB188F7:  448865f8                  mov      byte ptr [rbp - 8], r12b
  0xB188FB:  4885c0                    test     rax, rax
  0xB188FE:  7405                      je       0xb18905
  0xB18900:  0f1000                    movups   xmm0, xmmword ptr [rax]
  0xB18903:  eb10                      jmp      0xb18915
  0xB18905:  4439258cca8e0c            cmp      dword ptr [rip + 0xc8eca8c], r12d
  0xB1890C:  7510                      jne      0xb1891e
  0xB1890E:  0f100513edfa0b            movups   xmm0, xmmword ptr [rip + 0xbfaed13]
  0xB18915:  c645e801                  mov      byte ptr [rbp - 0x18], 1
  0xB18919:  f30f7f45d8                movdqu   xmmword ptr [rbp - 0x28], xmm0
  0xB1891E:  4c8b4d40                  mov      r9, qword ptr [rbp + 0x40]
  0xB18922:  4d85c9                    test     r9, r9
  0xB18925:  0f84dd000000              je       0xb18a08
  0xB1892B:  4d85f6                    test     r14, r14
  0xB1892E:  7516                      jne      0xb18946
  0xB18930:  4885db                    test     rbx, rbx
  0xB18933:  751a                      jne      0xb1894f
  0xB18935:  4885f6                    test     rsi, rsi
  0xB18938:  0f85ca000000              jne      0xb18a08
  0xB1893E:  418bfc                    mov      edi, r12d
  0xB18941:  e9ee000000                jmp      0xb18a34
  0xB18946:  4885db                    test     rbx, rbx
  0xB18949:  0f84b9000000              je       0xb18a08
  0xB1894F:  4885f6                    test     rsi, rsi
  0xB18952:  0f84b0000000              je       0xb18a08
  0xB18958:  488b4550                  mov      rax, qword ptr [rbp + 0x50]
  0xB1895C:  4883cfff                  or       rdi, 0xffffffffffffffff
  0xB18960:  4c8b7dec                  mov      r15, qword ptr [rbp - 0x14]
  0xB18964:  4889442428                mov      qword ptr [rsp + 0x28], rax
  0xB18969:  488d45c0                  lea      rax, [rbp - 0x40]
  0xB1896D:  4889442420                mov      qword ptr [rsp + 0x20], rax
  0xB18972:  493bf6                    cmp      rsi, r14
  0xB18975:  762c                      jbe      0xb189a3
  0xB18977:  4d8d4601                  lea      r8, [r14 + 1]
  0xB1897B:  e800a5ffff                call     0xb12e80
  0xB18980:  83f8fe                    cmp      eax, -2
  0xB18983:  7549                      jne      0xb189ce
  0xB18985:  443865f0                  cmp      byte ptr [rbp - 0x10], r12b
  0xB18989:  0f84a1000000              je       0xb18a30
  0xB1898F:  488b45ec                  mov      rax, qword ptr [rbp - 0x14]
  0xB18993:  83f822                    cmp      eax, 0x22
  0xB18996:  490f44c7                  cmove    rax, r15
  0xB1899A:  488945ec                  mov      qword ptr [rbp - 0x14], rax
  0xB1899E:  e98d000000                jmp      0xb18a30
  0xB189A3:  e8d8a4ffff                call     0xb12e80
  0xB189A8:  44886433ff                mov      byte ptr [rbx + rsi - 1], r12b
  0xB189AD:  83f8fe                    cmp      eax, -2
  0xB189B0:  751c                      jne      0xb189ce
  0xB189B2:  4c3bf7                    cmp      r14, rdi
  0xB189B5:  751b                      jne      0xb189d2
  0xB189B7:  443865f0                  cmp      byte ptr [rbp - 0x10], r12b
  0xB189BB:  7477                      je       0xb18a34
  0xB189BD:  488b45ec                  mov      rax, qword ptr [rbp - 0x14]
  0xB189C1:  83f822                    cmp      eax, 0x22
  0xB189C4:  490f44c7                  cmove    rax, r15
  0xB189C8:  488945ec                  mov      qword ptr [rbp - 0x14], rax
  0xB189CC:  eb66                      jmp      0xb18a34
  0xB189CE:  85c0                      test     eax, eax
  0xB189D0:  7932                      jns      0xb18a04
  0xB189D2:  448823                    mov      byte ptr [rbx], r12b
  0xB189D5:  83f8fe                    cmp      eax, -2
  0xB189D8:  755a                      jne      0xb18a34
  0xB189DA:  488d45c0                  lea      rax, [rbp - 0x40]
  0xB189DE:  c645f001                  mov      byte ptr [rbp - 0x10], 1
  0xB189E2:  4889442428                mov      qword ptr [rsp + 0x28], rax
  0xB189E7:  4533c9                    xor      r9d, r9d
  0xB189EA:  4533c0                    xor      r8d, r8d
  0xB189ED:  4c89642420                mov      qword ptr [rsp + 0x20], r12
  0xB189F2:  33d2                      xor      edx, edx
  0xB189F4:  c745ec22000000            mov      dword ptr [rbp - 0x14], 0x22
  0xB189FB:  33c9                      xor      ecx, ecx
  0xB189FD:  e802a3ffff                call     0xb12d04
  0xB18A02:  eb30                      jmp      0xb18a34
  0xB18A04:  8bf8                      mov      edi, eax
  0xB18A06:  eb2c                      jmp      0xb18a34
  0xB18A08:  488d45c0                  lea      rax, [rbp - 0x40]
  0xB18A0C:  c645f001                  mov      byte ptr [rbp - 0x10], 1
  0xB18A10:  4889442428                mov      qword ptr [rsp + 0x28], rax
  0xB18A15:  4533c9                    xor      r9d, r9d
  0xB18A18:  4533c0                    xor      r8d, r8d
  0xB18A1B:  4c89642420                mov      qword ptr [rsp + 0x20], r12
  ... (32 more instructions)
```

## Caller Context: 0xA8828B

```asm
  0xA87BF0:  488bc4                    mov      rax, rsp
  0xA87BF3:  48895818                  mov      qword ptr [rax + 0x18], rbx
  0xA87BF7:  55                        push     rbp
  0xA87BF8:  56                        push     rsi
  0xA87BF9:  57                        push     rdi
  0xA87BFA:  4154                      push     r12
  0xA87BFC:  4155                      push     r13
  0xA87BFE:  4156                      push     r14
  0xA87C00:  4157                      push     r15
  0xA87C02:  488d6888                  lea      rbp, [rax - 0x78]
  0xA87C06:  4881ec40010000            sub      rsp, 0x140
  0xA87C0D:  0f2970b8                  movaps   xmmword ptr [rax - 0x48], xmm6
  0xA87C11:  0f2978a8                  movaps   xmmword ptr [rax - 0x58], xmm7
  0xA87C15:  440f294098                movaps   xmmword ptr [rax - 0x68], xmm8
  0xA87C1A:  4533ed                    xor      r13d, r13d
  0xA87C1D:  458be5                    mov      r12d, r13d
  0xA87C20:  4489ad88000000            mov      dword ptr [rbp + 0x88], r13d
  0xA87C27:  4489ad80000000            mov      dword ptr [rbp + 0x80], r13d
  0xA87C2E:  0f57c0                    xorps    xmm0, xmm0
  0xA87C31:  0f11442430                movups   xmmword ptr [rsp + 0x30], xmm0
  0xA87C36:  418bdd                    mov      ebx, r13d
  0xA87C39:  48895c2440                mov      qword ptr [rsp + 0x40], rbx
  0xA87C3E:  be0f000000                mov      esi, 0xf
  0xA87C43:  4889742448                mov      qword ptr [rsp + 0x48], rsi
  0xA87C48:  885c2430                  mov      byte ptr [rsp + 0x30], bl
  0xA87C4C:  488d4db0                  lea      rcx, [rbp - 0x50]
  0xA87C50:  e86bf40300                call     0xac70c0
  0xA87C55:  90                        nop      
  0xA87C56:  66440f6f0501d8600b        movdqa   xmm8, xmmword ptr [rip + 0xb60d801]
  0xA87C5F:  488b7dc0                  mov      rdi, qword ptr [rbp - 0x40]
  0xA87C63:  4885ff                    test     rdi, rdi
  0xA87C66:  0f8497000000              je       0xa87d03
  0xA87C6C:  488d5db0                  lea      rbx, [rbp - 0x50]
  0xA87C70:  483975c8                  cmp      qword ptr [rbp - 0x38], rsi
  0xA87C74:  480f475db0                cmova    rbx, qword ptr [rbp - 0x50]
  0xA87C79:  0f57c0                    xorps    xmm0, xmm0
  0xA87C7C:  0f114590                  movups   xmmword ptr [rbp - 0x70], xmm0
  0xA87C80:  f3440f7f45a0              movdqu   xmmword ptr [rbp - 0x60], xmm8
  0xA87C86:  44886d90                  mov      byte ptr [rbp - 0x70], r13b
  0xA87C8A:  c7858800000008000000      mov      dword ptr [rbp + 0x88], 8
  0xA87C94:  488d570c                  lea      rdx, [rdi + 0xc]
  0xA87C98:  488d4d90                  lea      rcx, [rbp - 0x70]
  0xA87C9C:  e82f54ffff                call     0xa7d0d0
  0xA87CA1:  4c8bc7                    mov      r8, rdi
  0xA87CA4:  488bd3                    mov      rdx, rbx
  0xA87CA7:  488d4d90                  lea      rcx, [rbp - 0x70]
  0xA87CAB:  e8e056ffff                call     0xa7d390
  0xA87CB0:  41b05c                    mov      r8b, 0x5c
  0xA87CB3:  ba01000000                mov      edx, 1
  0xA87CB8:  488d4d90                  lea      rcx, [rbp - 0x70]
  0xA87CBC:  e87ff6ffff                call     0xa87340
  0xA87CC1:  41b80b000000              mov      r8d, 0xb
  0xA87CC7:  488d1502be5a0b            lea      rdx, [rip + 0xb5abe02]
  0xA87CCE:  488d4d90                  lea      rcx, [rbp - 0x70]
  0xA87CD2:  e8b956ffff                call     0xa7d390
  0xA87CD7:  90                        nop      
  0xA87CD8:  41bc04000000              mov      r12d, 4
  0xA87CDE:  0f104590                  movups   xmm0, xmmword ptr [rbp - 0x70]
  0xA87CE2:  0f11442430                movups   xmmword ptr [rsp + 0x30], xmm0
  0xA87CE7:  0f104da0                  movups   xmm1, xmmword ptr [rbp - 0x60]
  ... (528 more)
```

## Caller Context: 0xA9B5E0

```asm
  0xA9B5E0:  48895c2408                mov      qword ptr [rsp + 8], rbx
  0xA9B5E5:  4889742410                mov      qword ptr [rsp + 0x10], rsi
  0xA9B5EA:  48897c2418                mov      qword ptr [rsp + 0x18], rdi
  0xA9B5EF:  4156                      push     r14
  0xA9B5F1:  4883ec20                  sub      rsp, 0x20
  0xA9B5F5:  4d8bf1                    mov      r14, r9
  0xA9B5F8:  498bf0                    mov      rsi, r8
  0xA9B5FB:  488bfa                    mov      rdi, rdx
  0xA9B5FE:  488bd9                    mov      rbx, rcx
  0xA9B601:  4885c9                    test     rcx, rcx
  0xA9B604:  0f849d000000              je       0xa9b6a7
  0xA9B60A:  4883b98000000000          cmp      qword ptr [rcx + 0x80], 0
  0xA9B612:  0f848f000000              je       0xa9b6a7
  0xA9B618:  488b8180000000            mov      rax, qword ptr [rcx + 0x80]
  0xA9B61F:  48634818                  movsxd   rcx, dword ptr [rax + 0x18]
  0xA9B623:  418908                    mov      dword ptr [r8], ecx
  0xA9B626:  85c9                      test     ecx, ecx
  0xA9B628:  7f04                      jg       0xa9b62e
  0xA9B62A:  33c0                      xor      eax, eax
  0xA9B62C:  eb7e                      jmp      0xa9b6ac
  0xA9B62E:  488b05f37e960c            mov      rax, qword ptr [rip + 0xc967ef3]
  0xA9B635:  48c1e103                  shl      rcx, 3
  0xA9B639:  ffd0                      call     rax
  0xA9B63B:  488907                    mov      qword ptr [rdi], rax
  0xA9B63E:  33c0                      xor      eax, eax
  0xA9B640:  3906                      cmp      dword ptr [rsi], eax
  0xA9B642:  7e2a                      jle      0xa9b66e
  0xA9B644:  448bc0                    mov      r8d, eax
  0xA9B647:  660f1f840000000000        nop      word ptr [rax + rax]
  0xA9B650:  488b8b80000000            mov      rcx, qword ptr [rbx + 0x80]
  0xA9B657:  4d8d4008                  lea      r8, [r8 + 8]
  0xA9B65B:  488b17                    mov      rdx, qword ptr [rdi]
  0xA9B65E:  ffc0                      inc      eax
  0xA9B660:  498b4c0818                mov      rcx, qword ptr [r8 + rcx + 0x18]
  0xA9B665:  49894c10f8                mov      qword ptr [r8 + rdx - 8], rcx
  0xA9B66A:  3b06                      cmp      eax, dword ptr [rsi]
  0xA9B66C:  7ce2                      jl       0xa9b650
  0xA9B66E:  e80db50200                call     0xac6b80
  0xA9B673:  498906                    mov      qword ptr [r14], rax
  0xA9B676:  b905010000                mov      ecx, 0x105
  0xA9B67B:  488b05a67e960c            mov      rax, qword ptr [rip + 0xc967ea6]
  0xA9B682:  ffd0                      call     rax
  0xA9B684:  41b805010000              mov      r8d, 0x105
  0xA9B68A:  488d0d6f4956ff            lea      rcx, [rip - 0xa9b691]
  0xA9B691:  488bd0                    mov      rdx, rax
  0xA9B694:  488bd8                    mov      rbx, rax
  0xA9B697:  ff150b0ade09              call     qword ptr [rip + 0x9de0a0b]
  0xA9B69D:  488b4c2450                mov      rcx, qword ptr [rsp + 0x50]
  0xA9B6A2:  488919                    mov      qword ptr [rcx], rbx
  0xA9B6A5:  eb13                      jmp      0xa9b6ba
  0xA9B6A7:  33c0                      xor      eax, eax
  0xA9B6A9:  418900                    mov      dword ptr [r8], eax
  0xA9B6AC:  488b4c2450                mov      rcx, qword ptr [rsp + 0x50]
  0xA9B6B1:  488902                    mov      qword ptr [rdx], rax
  0xA9B6B4:  498901                    mov      qword ptr [r9], rax
  0xA9B6B7:  488901                    mov      qword ptr [rcx], rax
  0xA9B6BA:  488b5c2430                mov      rbx, qword ptr [rsp + 0x30]
  0xA9B6BF:  488b742438                mov      rsi, qword ptr [rsp + 0x38]
  0xA9B6C4:  488b7c2440                mov      rdi, qword ptr [rsp + 0x40]
  0xA9B6C9:  4883c420                  add      rsp, 0x20
  ... (2 more)
```

## Implications for Decrypt Research

These functions are **CRT string formatting**, not metadata decryption.
The actual metadata decrypt logic (position-based XOR ramp, per trackB findings)
lives elsewhere. The structure at 0xC09CED0 likely holds a build identifier
or license key that gets formatted as a hex string for logging/verification.

The real decrypt chain for metadata is documented in trackB_findings.md:
- Algorithm: `plain[f] = enc[f] XOR ((f + K) & 0xFF)` per section
- Header: non-linear PRNG keystream (prefix recovered)
- The decrypt code is likely inlined or in the metadata loader (~0xAEF640 area)