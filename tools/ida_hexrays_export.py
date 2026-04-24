"""
IDAPython script: batch Hex-Rays decompilation export.

Decompiles functions and exports pseudocode to JSON for LLM prediction pipeline.
Targets hash methods (m_XXX) first, with option to export all.

Usage in IDA:
  File -> Script file -> ida_hexrays_export.py

Or headless (requires IDA Pro with decompiler license):
  idat.exe -A -S"ida_hexrays_export.py" GameAssembly.i64
  (IDA 9.x uses idat.exe instead of idat64.exe; ida.exe instead of ida64.exe)

Configuration via environment variables:
  HEXRAYS_MODE=hash|all|list     (default: hash — only m_XXX methods)
  HEXRAYS_OUTPUT=path            (default: auto-detect output/ dir)
  HEXRAYS_RESUME=1               (skip already-exported functions)
  HEXRAYS_LIMIT=N                (max functions to decompile, 0=unlimited)
  HEXRAYS_BATCH_SIZE=N           (save every N functions, default 500)
"""

import idautils
import idaapi
import idc
import ida_hexrays
import ida_funcs
import ida_name
import json
import os
import sys
import time
import re

# ── Config ──────────────────────────────────────────────────────────────────

MODE = os.environ.get('HEXRAYS_MODE', 'hash')  # hash | all | list
RESUME = os.environ.get('HEXRAYS_RESUME', '1') == '1'
LIMIT = int(os.environ.get('HEXRAYS_LIMIT', '0'))
BATCH_SIZE = int(os.environ.get('HEXRAYS_BATCH_SIZE', '500'))

HASH_RE = re.compile(r'^m_[0-9a-fA-F]{3}$')
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}')

# Path resolution
SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__)) if '__file__' in dir() else os.getcwd()
BASE_DIR = os.path.normpath(os.path.join(SCRIPT_DIR, '..'))

# Try multiple candidate paths for output
OUTPUT_PATH = os.environ.get('HEXRAYS_OUTPUT', '')
if not OUTPUT_PATH:
    candidates = [
        os.path.join(BASE_DIR, 'output', 'hexrays_export.json'),
        os.path.join(SCRIPT_DIR, '..', 'output', 'hexrays_export.json'),
        r'D:\WorkSpace\VRChat\VRChat_Data\il2cpp_dump_tools\output\hexrays_export.json',
    ]
    for c in candidates:
        d = os.path.dirname(c)
        if os.path.isdir(d):
            OUTPUT_PATH = c
            break
    if not OUTPUT_PATH:
        OUTPUT_PATH = os.path.join(os.path.dirname(idc.get_idb_path()), 'hexrays_export.json')

# Stats output
STATS_PATH = OUTPUT_PATH.replace('.json', '_stats.json')

print(f'[HexExport] Mode: {MODE}')
print(f'[HexExport] Output: {OUTPUT_PATH}')
print(f'[HexExport] Resume: {RESUME}')
print(f'[HexExport] Limit: {LIMIT or "unlimited"}')


# ── Init Hex-Rays ───────────────────────────────────────────────────────────

if not ida_hexrays.init_hexrays_plugin():
    print('[HexExport] ERROR: Hex-Rays decompiler not available!')
    print('[HexExport] Make sure you have a valid Hex-Rays license.')
    if 'idc' in dir() and hasattr(idc, 'qexit'):
        idc.qexit(1)
    raise SystemExit(1)

print(f'[HexExport] Hex-Rays initialized: {ida_hexrays.get_hexrays_version()}')

# Wait for auto-analysis
idaapi.auto_wait()
print('[HexExport] Auto-analysis complete')

IDA_BASE = idaapi.get_imagebase()
print(f'[HexExport] Image base: 0x{IDA_BASE:X}')


# ── Load existing data (for resume) ────────────────────────────────────────

existing = {}
if RESUME and os.path.exists(OUTPUT_PATH):
    try:
        with open(OUTPUT_PATH, 'r', encoding='utf-8') as f:
            existing = json.load(f)
        print(f'[HexExport] Loaded {len(existing)} existing entries (resume mode)')
    except Exception as e:
        print(f'[HexExport] Warning: could not load existing file: {e}')
        existing = {}


# ── Build target function list ──────────────────────────────────────────────

def get_func_deobf_name(ea):
    """Get the function name at ea, return (name, is_hash, is_obf)."""
    name = idc.get_func_name(ea)
    if not name:
        return None, False, False

    # Check if this is a renamed function (from ida_apply_names)
    # Hash methods: contain "__m_" followed by hex digits
    # e.g. SomeClass__m_A3F or just m_A3F
    parts = name.rsplit('__', 1)
    if len(parts) == 2:
        method_part = parts[1]
    else:
        method_part = name

    is_hash = bool(HASH_RE.match(method_part))
    is_obf = bool(OBF_RE.match(method_part)) or name.startswith('sub_')
    return name, is_hash, is_obf


def build_target_list():
    """Build list of function EAs to decompile based on MODE."""
    targets = []
    total = 0
    hash_count = 0
    obf_count = 0
    named_count = 0

    for func_ea in idautils.Functions():
        total += 1
        name, is_hash, is_obf = get_func_deobf_name(func_ea)

        if is_hash:
            hash_count += 1
        elif is_obf:
            obf_count += 1
        elif name:
            named_count += 1

        # Filter based on mode
        if MODE == 'hash':
            # Hash methods + still-obfuscated methods
            if is_hash or is_obf:
                targets.append(func_ea)
        elif MODE == 'all':
            targets.append(func_ea)
        # MODE == 'list' handled separately

    print(f'[HexExport] Total functions: {total:,}')
    print(f'[HexExport] Hash (m_XXX): {hash_count:,}')
    print(f'[HexExport] Still obfuscated: {obf_count:,}')
    print(f'[HexExport] Named: {named_count:,}')
    print(f'[HexExport] Targets: {len(targets):,}')

    return targets


def load_target_list_from_file():
    """Load target EAs from an external address list file."""
    list_path = os.environ.get('HEXRAYS_LIST', '')
    if not list_path:
        list_path = os.path.join(BASE_DIR, 'data', 'hexrays_targets.txt')

    if not os.path.exists(list_path):
        print(f'[HexExport] ERROR: target list not found: {list_path}')
        return []

    targets = []
    with open(list_path, 'r') as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith('#'):
                continue
            try:
                ea = int(line, 16) if line.startswith('0x') else int(line)
                if ida_funcs.get_func(ea):
                    targets.append(ea)
            except ValueError:
                pass

    print(f'[HexExport] Loaded {len(targets)} targets from {list_path}')
    return targets


if MODE == 'list':
    targets = load_target_list_from_file()
else:
    targets = build_target_list()

# Skip already-exported (resume mode)
if RESUME and existing:
    before = len(targets)
    existing_eas = set()
    for addr_str in existing.keys():
        try:
            existing_eas.add(int(addr_str, 16))
        except ValueError:
            pass
    targets = [ea for ea in targets if ea not in existing_eas]
    print(f'[HexExport] Skipping {before - len(targets)} already-exported, {len(targets)} remaining')

# Apply limit
if LIMIT > 0 and len(targets) > LIMIT:
    targets = targets[:LIMIT]
    print(f'[HexExport] Limited to {LIMIT} functions')


# ── Decompile ───────────────────────────────────────────────────────────────

results = dict(existing)  # start from existing if resuming
stats = {
    'success': 0,
    'failed': 0,
    'timeout': 0,
    'too_large': 0,
    'total_lines': 0,
    'start_time': time.time(),
}

MAX_PSEUDOCODE_LINES = 2000  # skip absurdly large functions


def decompile_func(ea):
    """Decompile a function, return pseudocode string or None."""
    try:
        cfunc = ida_hexrays.decompile(ea, flags=ida_hexrays.DECOMP_NO_WAIT)
        if cfunc is None:
            return None

        pseudocode = str(cfunc)

        # Sanity check: skip if output is too large
        lines = pseudocode.count('\n') + 1
        if lines > MAX_PSEUDOCODE_LINES:
            stats['too_large'] += 1
            # Still save but truncated with a marker
            truncated = '\n'.join(pseudocode.split('\n')[:MAX_PSEUDOCODE_LINES])
            return truncated + f'\n// ... truncated ({lines} lines total)'

        stats['total_lines'] += lines
        return pseudocode

    except ida_hexrays.DecompilationFailure:
        return None
    except Exception:
        return None


def save_checkpoint():
    """Save current results to disk."""
    os.makedirs(os.path.dirname(OUTPUT_PATH), exist_ok=True)
    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(results, f, ensure_ascii=False, separators=(',', ':'))
    # Also save stats
    stats['elapsed'] = time.time() - stats['start_time']
    stats['exported'] = len(results)
    with open(STATS_PATH, 'w', encoding='utf-8') as f:
        json.dump(stats, f, indent=2)


print(f'\n[HexExport] Starting decompilation of {len(targets):,} functions...')
t0 = time.time()

for i, ea in enumerate(targets):
    addr_key = f'0x{ea:X}'
    name = idc.get_func_name(ea) or f'sub_{ea:X}'

    pseudocode = decompile_func(ea)

    if pseudocode:
        # Compute RVA for cross-referencing with pipeline
        rva = ea - IDA_BASE
        entry = {
            'name': name,
            'rva': f'0x{rva:X}',
            'lines': pseudocode.count('\n') + 1,
            'code': pseudocode,
        }
        results[addr_key] = entry
        stats['success'] += 1
    else:
        stats['failed'] += 1

    # Progress reporting
    done = i + 1
    if done % 100 == 0 or done == len(targets):
        elapsed = time.time() - t0
        rate = done / elapsed if elapsed > 0 else 0
        eta = (len(targets) - done) / rate if rate > 0 else 0
        pct = done * 100 / len(targets)
        print(f'[HexExport] {done:,}/{len(targets):,} ({pct:.1f}%) '
              f'ok={stats["success"]:,} fail={stats["failed"]:,} '
              f'rate={rate:.0f}/s ETA={eta:.0f}s')

    # Checkpoint save
    if done % BATCH_SIZE == 0:
        save_checkpoint()
        print(f'[HexExport] Checkpoint saved ({len(results):,} total)')


# ── Final save ──────────────────────────────────────────────────────────────

save_checkpoint()

elapsed = time.time() - t0
print(f'\n[HexExport] ═══════════════════════════════════════')
print(f'[HexExport] Done in {elapsed:.0f}s')
print(f'[HexExport] Exported: {stats["success"]:,}')
print(f'[HexExport] Failed:   {stats["failed"]:,}')
print(f'[HexExport] Too large:{stats["too_large"]:,}')
print(f'[HexExport] Total pseudocode lines: {stats["total_lines"]:,}')
print(f'[HexExport] Output: {OUTPUT_PATH}')
print(f'[HexExport] ═══════════════════════════════════════')

# In headless mode, exit IDA
if os.environ.get('HEXRAYS_HEADLESS', '0') == '1':
    idc.qexit(0)
