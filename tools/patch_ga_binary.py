#!/usr/bin/env python3
"""
Patch GameAssembly.dll on disk to bypass offline testing mode.
Creates a backup (.bak) before patching. Use --restore to undo.

Patches (8 total):
1. Location.get_isOffline → return false (xor eax,eax; ret)
2. Location.set_isOffline → no-op (ret)
3. API.IsOffline → return false (xor eax,eax; ret)
4. Error state setter function at RVA 0x18E76C0 → return immediately
5. NOP the offline error generator call at RVA 0x191CAEE
   (prevents "offline testing mode" error from being produced during world join)
6. Patch join function branch at RVA 0x191CA80 to skip error path
   (force the code to treat empty result as non-error)
7. Join coroutine +0x158 offline check at RVA 0x191C98D → unconditional jmp
   (bypasses anti-cheat availability check in world join)
8. Secondary offline check at RVA 0x6EA72E1 → unconditional jmp
   (bypasses offline status check in another code path)

Usage:
  python tools/patch_ga_binary.py            # apply patches
  python tools/patch_ga_binary.py --restore  # restore backup
  python tools/patch_ga_binary.py --check    # check patch status
"""
import sys
import os
import shutil
import argparse

sys.stdout.reconfigure(encoding='utf-8')

GA_PATH = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(
    os.path.dirname(os.path.abspath(__file__))))), "GameAssembly.dll")
GA_BAK = GA_PATH + ".bak"

# il2cpp section: VA=0xac2000, raw=0xac0e00, delta=0x1200
DELTA = 0x1200


def find_pattern(data: bytes, pattern: bytes, start: int = 0) -> list[int]:
    """Find all occurrences of pattern in data."""
    results = []
    pos = start
    while True:
        pos = data.find(pattern, pos)
        if pos == -1:
            break
        results.append(pos)
        pos += 1
    return results


def patch_location_isoffline(data: bytearray) -> int:
    """Patch Location.get_isOffline and set_isOffline."""
    getter_pattern = b'\x0f\xb6\x41\x20\xc3'
    setter_pattern = b'\x88\x51\x20\xc3'

    candidates = find_pattern(data, getter_pattern)
    count = 0

    for pos in candidates:
        if pos + 0x10 + len(setter_pattern) <= len(data):
            if data[pos + 0x10:pos + 0x10 + len(setter_pattern)] == bytearray(setter_pattern):
                # Patch getter: xor eax,eax; ret; nop; nop
                data[pos:pos + 5] = b'\x31\xc0\xc3\x90\x90'
                print(f"  [✓] get_isOffline patched at offset 0x{pos:X}")
                count += 1

                # Patch setter: ret; nop; nop; nop
                spos = pos + 0x10
                data[spos:spos + 4] = b'\xc3\x90\x90\x90'
                print(f"  [✓] set_isOffline patched at offset 0x{spos:X}")
                count += 1
                break

    if count == 0:
        print("  [!] Location.get_isOffline not found")
    return count


def patch_api_isoffline(data: bytearray) -> int:
    """Patch API.IsOffline method."""
    tail_pattern = b'\x83\x78\x20\x02\x0f\x94\xc0\x48\x83\xc4\x28\xc3'

    candidates = find_pattern(data, tail_pattern)
    count = 0

    for pos in candidates:
        for back in range(0x10, 0x80):
            start = pos - back
            if start < 1:
                continue
            if (data[start] == 0x48 and data[start + 1] == 0x83 and
                    data[start + 2] == 0xEC and data[start + 3] == 0x28):
                if data[start - 1] in (0xCC, 0xC3):
                    data[start:start + 8] = b'\x31\xc0\xc3\x90\x90\x90\x90\x90'
                    print(f"  [✓] API.IsOffline patched at offset 0x{start:X}")
                    count += 1
                    break
        if count > 0:
            break

    if count == 0:
        print("  [!] API.IsOffline not found")
    return count


def patch_connect_error_state(data: bytearray) -> int:
    """Patch the error state setter function to return immediately.

    The function at RVA 0x18E76C0 (file offset 0x18E64C0) is called from
    multiple places to set connect error state when Steam init fails.
    Rather than NOP individual call sites, we patch the function itself
    to just return immediately: ret (0xC3).

    Original: 40 55 56 41 56 48 8d 6c 24 b9 (push rbp; push rsi; push r14; lea rbp,...)
    Patched:  C3 90 90 90 90 90 90 90 90 90 (ret + NOPs)
    """
    func_rva = 0x18E76C0
    foff = func_rva - DELTA
    # First 10 bytes of the function
    orig = b'\x40\x55\x56\x41\x56\x48\x8d\x6c\x24\xb9'
    patched = b'\xc3\x90\x90\x90\x90\x90\x90\x90\x90\x90'
    count = 0

    if foff + 10 > len(data):
        print(f"  [!] error state setter func: offset 0x{foff:X} out of range")
        return 0

    actual = bytes(data[foff:foff + 10])
    if actual == orig:
        data[foff:foff + 10] = patched
        print(f"  [✓] error state setter func patched (ret) at 0x{foff:X} (RVA 0x{func_rva:X})")
        count = 1
    elif actual == patched:
        print(f"  [·] error state setter func already patched at 0x{foff:X}")
    elif actual[0] == 0xC3:
        print(f"  [·] error state setter func already starts with ret at 0x{foff:X}")
    else:
        print(f"  [!] error state setter func: unexpected bytes at 0x{foff:X}: {actual.hex()}")

    return count


def patch_offline_error_call(data: bytearray) -> int:
    """NOP the call that generates the offline testing mode error.

    At RVA 0x191CAEE in the join coroutine function:
      e8 2d 05 6f 00    call 0x200D020  (generates offline error result)
    Change to: 90 90 90 90 90 (5x NOP)

    When this call is NOP'd, the error result stays zeroed (xorps xmm0,xmm0
    was executed before), and the downstream code sees no error to report.
    """
    rva = 0x191CAEE
    foff = rva - DELTA
    orig = b'\xe8\x2d\x05\x6f\x00'
    patched = b'\x90\x90\x90\x90\x90'

    if foff + 5 > len(data):
        print(f"  [!] offline error call: offset 0x{foff:X} out of range")
        return 0

    actual = bytes(data[foff:foff + 5])
    if actual == orig:
        data[foff:foff + 5] = patched
        print(f"  [✓] offline error generator call NOP'd at 0x{foff:X} (RVA 0x{rva:X})")
        return 1
    elif actual == patched:
        print(f"  [·] offline error call already patched at 0x{foff:X}")
        return 0
    else:
        print(f"  [!] offline error call: unexpected bytes at 0x{foff:X}: {actual.hex()}")
        return 0


def patch_join_branch(data: bytearray) -> int:
    """Patch the join function branch to skip the offline error path.

    At RVA 0x191CA80 in the join coroutine:
      74 06    jz +6  (skip list count check if null)
    Change to: eb 18  (jmp +0x18 → jump to 0x191CA9A = success path)

    This makes the code ALWAYS take the success path (loading data from
    [rdi+0x80]), even when the list is null/empty. Since [rdi+0x80] will
    be null in offline mode, the success data will be all zeros, which
    the downstream code should handle as a no-op rather than an error.
    """
    rva = 0x191CA81
    foff = rva - DELTA
    orig = b'\x74\x06'
    patched = b'\xeb\x17'  # jmp to success path at 0x191CA9A (0x191CA83 + 0x17 = 0x191CA9A)

    if foff + 2 > len(data):
        print(f"  [!] join branch: offset 0x{foff:X} out of range")
        return 0

    actual = bytes(data[foff:foff + 2])
    if actual == orig:
        data[foff:foff + 2] = patched
        print(f"  [✓] join branch patched at 0x{foff:X} (RVA 0x{rva:X})")
        return 1
    elif actual == patched:
        print(f"  [·] join branch already patched at 0x{foff:X}")
        return 0
    else:
        print(f"  [!] join branch: unexpected bytes at 0x{foff:X}: {actual.hex()}")
        return 0


def patch_join_offline_check(data: bytearray) -> int:
    """Patch the join coroutine's anti-cheat availability check.

    At RVA 0x191C98D (after cmp byte [rsi+0x158], 0):
      75 6b    jnz +0x6B  (skip error if anti-cheat initialized)
    Change to: eb 6b  (jmp +0x6B → always skip offline error path)

    The field at +0x158 of the coroutine state object indicates whether
    the EOS anti-cheat client was successfully initialized. Without EAC,
    this is always 0, sending the join to the "offline testing mode" error.
    """
    rva = 0x191C98D
    foff = rva - DELTA
    orig = b'\x75\x6b'
    patched = b'\xeb\x6b'

    if foff + 2 > len(data):
        print(f"  [!] join offline check: offset 0x{foff:X} out of range")
        return 0

    actual = bytes(data[foff:foff + 2])
    if actual == orig:
        data[foff:foff + 2] = patched
        print(f"  [✓] join offline check patched (jnz→jmp) at 0x{foff:X} (RVA 0x{rva:X})")
        return 1
    elif actual == patched:
        print(f"  [·] join offline check already patched at 0x{foff:X}")
        return 0
    else:
        print(f"  [!] join offline check: unexpected bytes at 0x{foff:X}: {actual.hex()}")
        return 0


def patch_secondary_offline_check(data: bytearray) -> int:
    """Patch a secondary offline status check.

    At RVA 0x6EA72E1:
      75 35    jnz +0x35  (skip if [rdi+0x158] != 0)
    Change to: eb 35  (jmp +0x35 → always skip offline path)
    """
    rva = 0x6EA72E1
    foff = rva - DELTA
    orig = b'\x75\x35'
    patched = b'\xeb\x35'

    if foff + 2 > len(data):
        print(f"  [!] secondary offline check: offset 0x{foff:X} out of range")
        return 0

    actual = bytes(data[foff:foff + 2])
    if actual == orig:
        data[foff:foff + 2] = patched
        print(f"  [✓] secondary offline check patched (jnz→jmp) at 0x{foff:X} (RVA 0x{rva:X})")
        return 1
    elif actual == patched:
        print(f"  [·] secondary offline check already patched at 0x{foff:X}")
        return 0
    else:
        print(f"  [!] secondary offline check: unexpected bytes at 0x{foff:X}: {actual.hex()}")
        return 0


def patch_fake_eac_flag(data: bytearray) -> int:
    """Fake the EAC initialization flag in the startup virtual call.

    The init function at ~RVA 0x18F1B00 checks [rdi+0x40] bit 0x400 to
    determine if EAC was initialized. Without EAC, this bit is 0, causing
    the startup flow to skip "wait for Photon" logic and try joining
    immediately — before Photon master server connects (~10s).

    Three-part patch using the skipped error-setup area as a code cave:

    Part A — RVA 0x18F1D25: ja +0x35 → jmp +0x35 (always skip error setup)
      Original: 77 35
      Patched:  EB 35

    Part B — RVA 0x18F1D27: trampoline in former error-setup area
      Writes:   8B 57 40 80 CE 04 EB 4E
                mov edx, [rdi+0x40]; or dh, 4; jmp 0x18F1D7D
      (sets bit 0x400 in edx before the virtual call)

    Part C — RVA 0x18F1D7A: redirect to trampoline
      Original: 8B 57 40  (mov edx, [rdi+0x40])
      Patched:  EB AB 90  (jmp -0x55 to trampoline; nop)
    """
    count = 0

    # Part A: ja→jmp at RVA 0x18F1D25
    rva_a = 0x18F1D25
    foff_a = rva_a - DELTA
    orig_a = b'\x77\x35'
    patched_a = b'\xeb\x35'

    # Part B: trampoline at RVA 0x18F1D27
    # Improved: also write the flag to memory so ALL subsequent checks see it
    rva_b = 0x18F1D27
    foff_b = rva_b - DELTA
    orig_b_len = 12  # we check first 8 bytes for original, but write 12
    orig_b = b'\x48\x8b\x0d\x1a\xdf\x7a\x0a\x83'  # first 8 bytes of error setup
    patched_b = (
        b'\x81\x4f\x40\x00\x04\x00\x00'  # or dword [rdi+0x40], 0x400  (persist flag in memory)
        b'\x8b\x57\x40'                    # mov edx, [rdi+0x40]         (reload with flag)
        b'\xeb\x4a'                         # jmp +0x4A → 0x18F1D7D      (back to mov rcx,r14)
    )  # 12 bytes total, fits in 53-byte cave

    # Part C: redirect at RVA 0x18F1D7A
    rva_c = 0x18F1D7A
    foff_c = rva_c - DELTA
    orig_c = b'\x8b\x57\x40'  # mov edx, [rdi+0x40]
    patched_c = b'\xeb\xab\x90'  # jmp -0x55 (to trampoline); nop

    for label, foff, orig, patched, rva in [
        ('A (ja→jmp)', foff_a, orig_a, patched_a, rva_a),
        ('B (trampoline)', foff_b, orig_b, patched_b, rva_b),
        ('C (redirect)', foff_c, orig_c, patched_c, rva_c),
    ]:
        if foff + len(orig) > len(data):
            print(f"  [!] fake EAC flag part {label}: offset 0x{foff:X} out of range")
            return count
        actual = bytes(data[foff:foff + len(orig)])
        if actual == orig:
            data[foff:foff + len(patched)] = patched
            print(f"  [✓] fake EAC flag part {label} at 0x{foff:X} (RVA 0x{rva:X})")
            count += 1
        elif actual == patched:
            print(f"  [·] fake EAC flag part {label} already patched at 0x{foff:X}")
        else:
            print(f"  [!] fake EAC flag part {label}: unexpected bytes at 0x{foff:X}: {actual.hex()}")
            return count  # don't apply partial patch

    return count


def patch_gohome_photon_check(data: bytearray) -> int:
    """Skip GoHome call during init if Photon isn't connected yet (Patch 11).

    The init function at RVA 0x18F1740 calls GoHome via vtable+0x298 at
    RVA 0x18F1D80. At startup, this fires ~5s after launch, but Photon
    connects at ~19s, so GoHome fails → Error World (broken UI).

    This patch uses the dead code cave (created by Patch 9A's jmp) to add
    a check: if [r14+0x158] == 0 (offline/Photon not connected), skip
    GoHome and the post-call, jump straight to the function epilogue.

    DEPENDS ON: Patch 9 (fake EAC flag) must be applied first.
    REQUIRES:   Frida timing fix v4 (frida_find_gohome.js) to re-trigger
                GoHome after Photon connects.

    Changes:
      11A — RVA 0x18F1D31: change Patch 9B's jmp target to fall through to cave
        Was (after Patch 9): EB 4A  (jmp +0x4A → 0x18F1D7D)
        New:                 EB 00  (jmp +0x00 → 0x18F1D33, fall through to cave)

      11B — RVA 0x18F1D33: code cave (19 bytes in 41-byte dead zone)
        cmp byte [r14+0x158], 0    ; check Photon/offline flag
        je skip_gohome             ; if offline, skip
        mov rcx, r14               ; this = FlowManager
        call rax                   ; GoHome (vtable+0x298)
        jmp 0x18F1D82              ; to post-call processing
        skip_gohome:
        jmp 0x18F1D90              ; to function epilogue (skip everything)

      11C — RVA 0x18F1D7D: NOP original mov+call (5 bytes, now dead code)
        Original: 49 8B CE FF D0  (mov rcx,r14; call rax)
        Patched:  90 90 90 90 90  (NOPs)
    """
    count = 0

    # 11A: modify Patch 9B's final jmp at RVA 0x18F1D31
    rva_a = 0x18F1D31
    foff_a = rva_a - DELTA
    orig_a = b'\xeb\x4a'       # after Patch 9: jmp +0x4A
    patched_a = b'\xeb\x00'    # fall through to code cave

    # 11B: code cave at RVA 0x18F1D33
    rva_b = 0x18F1D33
    foff_b = rva_b - DELTA
    orig_b = b'\x00\x00\x75\x05\xe8'  # first 5 bytes of original dead code
    patched_b = bytes([
        0x41, 0x80, 0xBE, 0x58, 0x01, 0x00, 0x00, 0x00,  # cmp byte [r14+0x158], 0
        0x74, 0x07,                                         # je +7 → skip_gohome (0x18F1D44)
        0x49, 0x8B, 0xCE,                                   # mov rcx, r14
        0xFF, 0xD0,                                          # call rax (GoHome)
        0xEB, 0x3E,                                          # jmp +0x3E → 0x18F1D82
        # skip_gohome (0x18F1D44):
        0xEB, 0x4A,                                          # jmp +0x4A → 0x18F1D90 (epilogue)
    ])  # 19 bytes

    # 11C: NOP original call site at RVA 0x18F1D7D
    rva_c = 0x18F1D7D
    foff_c = rva_c - DELTA
    orig_c = b'\x49\x8b\xce\xff\xd0'  # mov rcx,r14; call rax
    patched_c = b'\x90\x90\x90\x90\x90'  # NOPs

    for label, foff, orig, patched, rva in [
        ('A (cave redirect)', foff_a, orig_a, patched_a, rva_a),
        ('B (Photon check)', foff_b, orig_b, patched_b, rva_b),
        ('C (NOP call site)', foff_c, orig_c, patched_c, rva_c),
    ]:
        if foff + len(orig) > len(data):
            print(f"  [!] GoHome check part {label}: offset 0x{foff:X} out of range")
            return count
        actual = bytes(data[foff:foff + len(orig)])
        if actual == orig[:len(orig)]:
            data[foff:foff + len(patched)] = patched
            print(f"  [✓] GoHome check part {label} at 0x{foff:X} (RVA 0x{rva:X})")
            count += 1
        elif actual == patched[:len(orig)]:
            print(f"  [·] GoHome check part {label} already patched at 0x{foff:X}")
        else:
            print(f"  [!] GoHome check part {label}: unexpected bytes at 0x{foff:X}: {actual.hex()}")
            if label == 'A (cave redirect)' and actual == b'\xeb\x00':
                print(f"      (already patched)")
            else:
                return count
    return count


def patch_enterworld_nullref(data: bytearray) -> int:
    """Patch the EnterWorld listener that throws NullReferenceException.

    When VRChat enters Error World, the EnterWorld event invokes 28 listeners.
    One listener (UpdateComponent_C59A.ÎÎÏÎÌÍÎÍÏÍÏÏÏÏÍÌÏÏÏÏÎÍÍ(Boolean))
    throws NullRef because some object isn't initialized in Error World.
    This crash breaks the UI system, making ESC/QuickMenu unresponsive.

    Fix: patch the method at RVA 0x1A802A0 to return immediately.
    Original: 40 53 48 83 EC 20 (push rbx; sub rsp,0x20)
    Patched:  C3 90 90 90 90 90 (ret; nops)
    """
    rva = 0x1A802A0
    foff = rva - DELTA
    orig = b'\x40\x53\x48\x83\xec\x20'
    patched = b'\xc3\x90\x90\x90\x90\x90'

    if foff + 6 > len(data):
        print(f"  [!] EnterWorld NullRef: offset 0x{foff:X} out of range")
        return 0

    actual = bytes(data[foff:foff + 6])
    if actual == orig:
        data[foff:foff + 6] = patched
        print(f"  [✓] EnterWorld NullRef patched (ret) at 0x{foff:X} (RVA 0x{rva:X})")
        return 1
    elif actual == patched:
        print(f"  [·] EnterWorld NullRef already patched at 0x{foff:X}")
        return 0
    else:
        print(f"  [!] EnterWorld NullRef: unexpected bytes at 0x{foff:X}: {actual.hex()}")
        return 0


def check_patches(data: bytes) -> dict:
    """Check which patches are already applied."""
    status = {}

    # Check Location patches
    getter_patched = b'\x31\xc0\xc3\x90\x90'
    setter_patched = b'\xc3\x90\x90\x90'
    getter_orig = b'\x0f\xb6\x41\x20\xc3'
    setter_orig = b'\x88\x51\x20\xc3'

    gp = find_pattern(data, getter_patched)
    for pos in gp:
        if pos + 0x10 + 4 <= len(data):
            if data[pos + 0x10:pos + 0x10 + 4] == bytearray(setter_patched):
                status['location_getter'] = ('patched', pos)
                status['location_setter'] = ('patched', pos + 0x10)
                break

    if 'location_getter' not in status:
        go = find_pattern(data, getter_orig)
        for pos in go:
            if pos + 0x10 + 4 <= len(data):
                if data[pos + 0x10:pos + 0x10 + 4] == bytearray(setter_orig):
                    status['location_getter'] = ('original', pos)
                    status['location_setter'] = ('original', pos + 0x10)
                    break

    # Check API.IsOffline
    api_off = 0x1D698D0
    if api_off + 3 <= len(data):
        if data[api_off:api_off + 3] == b'\x31\xc0\xc3':
            status['api_isoffline'] = ('patched', api_off)
        elif data[api_off] == 0x48 and data[api_off + 1] == 0x83:
            status['api_isoffline'] = ('original', api_off)

    # Check error state setter function at RVA 0x18E76C0
    func_rva = 0x18E76C0
    func_foff = func_rva - DELTA
    func_orig = b'\x40\x55\x56\x41\x56\x48\x8d\x6c\x24\xb9'
    func_patched = b'\xc3\x90\x90\x90\x90\x90\x90\x90\x90\x90'
    if func_foff + 10 <= len(data):
        actual = bytes(data[func_foff:func_foff + 10])
        if actual == func_patched:
            status['error_state_setter'] = ('patched', func_foff)
        elif actual == func_orig:
            status['error_state_setter'] = ('original', func_foff)

    # Check offline error generator call NOP at RVA 0x191CAEE
    err_call_rva = 0x191CAEE
    err_call_foff = err_call_rva - DELTA
    if err_call_foff + 5 <= len(data):
        actual = bytes(data[err_call_foff:err_call_foff + 5])
        if actual == b'\x90\x90\x90\x90\x90':
            status['offline_error_call'] = ('patched', err_call_foff)
        elif actual == b'\xe8\x2d\x05\x6f\x00':
            status['offline_error_call'] = ('original', err_call_foff)

    # Check join branch patch at RVA 0x191CA80
    jb_rva = 0x191CA81
    jb_foff = jb_rva - DELTA
    if jb_foff + 2 <= len(data):
        actual = bytes(data[jb_foff:jb_foff + 2])
        if actual == b'\xeb\x17':
            status['join_branch'] = ('patched', jb_foff)
        elif actual == b'\x74\x06':
            status['join_branch'] = ('original', jb_foff)

    # Check join offline check at RVA 0x191C98D (patch 7)
    joc_rva = 0x191C98D
    joc_foff = joc_rva - DELTA
    if joc_foff + 2 <= len(data):
        actual = bytes(data[joc_foff:joc_foff + 2])
        if actual == b'\xeb\x6b':
            status['join_offline_check'] = ('patched', joc_foff)
        elif actual == b'\x75\x6b':
            status['join_offline_check'] = ('original', joc_foff)

    # Check secondary offline check at RVA 0x6EA72E1 (patch 8)
    soc_rva = 0x6EA72E1
    soc_foff = soc_rva - DELTA
    if soc_foff + 2 <= len(data):
        actual = bytes(data[soc_foff:soc_foff + 2])
        if actual == b'\xeb\x35':
            status['secondary_offline_check'] = ('patched', soc_foff)
        elif actual == b'\x75\x35':
            status['secondary_offline_check'] = ('original', soc_foff)

    # Check fake EAC flag patch (patch 9) — 3 parts
    eac_a_rva = 0x18F1D25
    eac_a_foff = eac_a_rva - DELTA
    if eac_a_foff + 2 <= len(data):
        actual = bytes(data[eac_a_foff:eac_a_foff + 2])
        if actual == b'\xeb\x35':
            status['fake_eac_flag'] = ('patched', eac_a_foff)
        elif actual == b'\x77\x35':
            status['fake_eac_flag'] = ('original', eac_a_foff)

    # Check GoHome Photon check patch (patch 11)
    gh_rva = 0x18F1D33
    gh_foff = gh_rva - DELTA
    if gh_foff + 5 <= len(data):
        actual = bytes(data[gh_foff:gh_foff + 5])
        if actual == b'\x41\x80\xbe\x58\x01':  # cmp byte [r14+0x158]
            status['gohome_photon_check'] = ('patched', gh_foff)
        elif actual == b'\x00\x00\x75\x05\xe8':  # original dead code
            status['gohome_photon_check'] = ('original', gh_foff)

    # Check EnterWorld NullRef patch (patch 10)
    ew_rva = 0x1A802A0
    ew_foff = ew_rva - DELTA
    if ew_foff + 6 <= len(data):
        actual = bytes(data[ew_foff:ew_foff + 6])
        if actual == b'\xc3\x90\x90\x90\x90\x90':
            status['enterworld_nullref'] = ('patched', ew_foff)
        elif actual == b'\x40\x53\x48\x83\xec\x20':
            status['enterworld_nullref'] = ('original', ew_foff)

    return status


def main():
    parser = argparse.ArgumentParser(description="Patch GameAssembly.dll offline mode")
    parser.add_argument('--restore', action='store_true', help='Restore backup')
    parser.add_argument('--check', action='store_true', help='Check patch status')
    parser.add_argument('--steam-mode', action='store_true',
                        help='Apply only patches 1-4 (safe for Steam online mode)')
    args = parser.parse_args()

    print("=" * 60)
    print("  GameAssembly.dll Offline Mode Binary Patcher")
    print("=" * 60)
    print(f"  DLL: {GA_PATH}")
    print(f"  Size: {os.path.getsize(GA_PATH) / 1024 / 1024:.1f} MB")

    if args.restore:
        if os.path.exists(GA_BAK):
            shutil.copy2(GA_BAK, GA_PATH)
            print("[✓] Restored from backup")
        else:
            print("[!] No backup found")
        return

    # Read DLL
    with open(GA_PATH, 'rb') as f:
        data = f.read()

    if args.check:
        status = check_patches(data)
        print("\nPatch Status:")
        for name, (state, offset) in sorted(status.items()):
            symbol = "✓" if state == "patched" else "○"
            print(f"  [{symbol}] {name}: {state} at 0x{offset:X}")
        if not status:
            print("  (no patches detected)")
        return

    # Check if already patched
    status = check_patches(data)
    already_patched = all(s == 'patched' for s, _ in status.values())
    if already_patched and len(status) >= 11:
        print("\n[*] All patches already applied!")
        return

    # Create backup
    if not os.path.exists(GA_BAK):
        print(f"\n[*] Creating backup: {GA_BAK}")
        shutil.copy2(GA_PATH, GA_BAK)
        print(f"  Backup size: {os.path.getsize(GA_BAK) / 1024 / 1024:.1f} MB")
    else:
        print(f"[*] Backup already exists: {GA_BAK}")

    # Apply patches
    data = bytearray(data)
    total = 0

    print("\n[1-2] Patching Location.get_isOffline / set_isOffline...")
    total += patch_location_isoffline(data)

    print("[3] Patching API.IsOffline...")
    total += patch_api_isoffline(data)

    print("[4] Patching error state setter to ret...")
    total += patch_connect_error_state(data)

    if not args.steam_mode:
        print("[5] NOP'ing offline error generator call...")
        total += patch_offline_error_call(data)

        print("[6] Patching join branch to skip error path...")
        total += patch_join_branch(data)
    else:
        print("[5-6] Skipped (Steam mode — online join flow intact)")

    print("[7] Patching join coroutine offline check (anti-cheat)...")
    total += patch_join_offline_check(data)

    print("[8] Patching secondary offline check...")
    total += patch_secondary_offline_check(data)

    print("[9] Patching init to fake EAC flag (fix Photon timing)...")
    total += patch_fake_eac_flag(data)

    print("[10] Patching EnterWorld NullRef (fix ESC in Error World)...")
    total += patch_enterworld_nullref(data)

    print("[11] Patching GoHome to check Photon connection...")
    total += patch_gohome_photon_check(data)

    if total > 0:
        with open(GA_PATH, 'wb') as f:
            f.write(data)
        print(f"\n[✓] {total} patches written to GameAssembly.dll")
        print("    Run VRChat.exe --no-vr to test")
        print("    Use --restore to undo all patches")
    else:
        print("\n[!] No patches applied")

    print("=" * 60)


if __name__ == '__main__':
    main()
