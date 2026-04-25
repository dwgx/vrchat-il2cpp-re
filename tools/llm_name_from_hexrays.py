#!/usr/bin/env python3
"""
Post-IDA LLM naming driver.

Run after IDA finishes: needs output/v_new_ida/ida_analysis.json and
output/v_new_ida/hexrays_export.json.

Builds per-hash-method context from:
- Hex-Rays pseudocode
- String refs from IDA analysis
- Callees (resolved via precise_dump VA map)
- Signature (from precise_dump)

Splits into N batches and writes to output/llm_batches_hexrays/batch_NNN.json.

Then prints a per-batch command line for running codex on each batch.
"""

import json
import re
import sys
import hashlib
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE = Path(__file__).resolve().parent.parent
HASH_METHOD_RE = re.compile(r'^m_[0-9A-F]{3}$')

BATCH_SIZE = 300  # methods per batch — small enough for codex context window
OUT_DIR = BASE / 'output' / 'llm_batches_hexrays'


def stable_hash(name: str, length: int = 3) -> str:
    return hashlib.sha256(name.encode('utf-8')).hexdigest()[:length].upper()


def load_json(p: Path, default=None):
    if not p.exists():
        print(f'  [!] missing: {p.name}')
        return default if default is not None else {}
    with open(p, 'r', encoding='utf-8') as f:
        return json.load(f)


def build_va_to_method(precise_dump: dict) -> dict:
    """Build VA_hex -> {class_obf, method_obf, signature}"""
    va_map = {}
    for ns_name, cls_list in precise_dump.get('namespaces', {}).items():
        if not isinstance(cls_list, list):
            continue
        for cls in cls_list:
            cls_name = cls.get('name', '')
            methods = cls.get('methods', [])
            pointers = cls.get('method_pointers', {})
            if isinstance(pointers, dict):
                for m_name, va in pointers.items():
                    if not va:
                        continue
                    va_key = va.lower() if isinstance(va, str) else hex(va)
                    va_map[va_key] = {
                        'class': cls_name,
                        'method': m_name,
                        'ns': ns_name,
                    }
            elif isinstance(pointers, list):
                for idx, m in enumerate(methods):
                    if idx >= len(pointers):
                        break
                    va = pointers[idx]
                    if not va:
                        continue
                    va_key = va.lower() if isinstance(va, str) else hex(va)
                    va_map[va_key] = {
                        'class': cls_name,
                        'method': m if isinstance(m, str) else str(m),
                        'ns': ns_name,
                    }
    return va_map


def resolve_name_for_va(va_map: dict, va: str, name_mapping: dict) -> str:
    """Get semantic name for a VA, or None."""
    va_key = va.lower() if isinstance(va, str) else hex(va)
    info = va_map.get(va_key)
    if not info:
        return None
    key = f'{info["class"]}::{info["method"]}'
    return name_mapping.get('methods', {}).get(key)


def main():
    print('Loading data ...')
    precise = load_json(BASE / 'data' / 'precise_dump.json', {})
    name_mapping = load_json(BASE / 'output' / 'name_mapping.json', {})
    ida_analysis = load_json(BASE / 'output' / 'v_new_ida' / 'ida_analysis.json', {})
    hexrays = load_json(BASE / 'output' / 'v_new_ida' / 'hexrays_export.json', {})
    class_map = name_mapping.get('classes', {})
    method_map = name_mapping.get('methods', {})

    print(f'  precise classes: {sum(len(v) for v in precise.get("namespaces", {}).values() if isinstance(v, list))}')
    print(f'  name_mapping classes: {len(class_map)}, methods: {len(method_map)}')
    print(f'  IDA functions: {len(ida_analysis.get("functions", {}))}')
    print(f'  Hex-Rays: {len(hexrays)}')

    if not hexrays:
        print('[!] No Hex-Rays data — run IDA auto-analysis first')
        return 1

    va_to_method = build_va_to_method(precise)
    print(f'  VA->method map: {len(va_to_method)}')

    # Gather hash-method contexts
    targets = []
    for cls_obf, cls_semantic in class_map.items():
        if not cls_semantic:
            continue
        # Find class entry
        # We need class's methods and their VAs
        pass

    # Iterate name_mapping.methods to find hash-named entries
    for full_key, new_name in method_map.items():
        if not isinstance(new_name, str):
            continue
        if not HASH_METHOD_RE.match(new_name):
            continue
        parts = full_key.split('::', 1)
        if len(parts) != 2:
            continue
        cls_obf, method_obf = parts
        cls_semantic = class_map.get(cls_obf, cls_obf)
        # Skip weak classes (hash-fallback named)
        if re.search(r'_[0-9A-F]{4}$', cls_semantic) or not cls_semantic:
            continue
        # Find VA
        va_found = None
        for va_key, info in va_to_method.items():
            if info['class'] == cls_obf and info['method'] == method_obf:
                va_found = va_key
                break
        if not va_found:
            continue
        # Get Hex-Rays pseudocode
        pseudocode = None
        hx_entry = hexrays.get(va_found) or hexrays.get(va_found.upper()) or hexrays.get(va_found.lower())
        if hx_entry and isinstance(hx_entry, dict):
            pseudocode = hx_entry.get('pseudocode', '')
        # IDA strings
        ida_info = ida_analysis.get('functions', {}).get(va_found, {})
        strings = ida_info.get('strings', []) if isinstance(ida_info, dict) else []
        calls = ida_info.get('calls', []) if isinstance(ida_info, dict) else []
        # Resolve callee names
        callee_names = []
        for c_va in calls[:20]:
            rn = resolve_name_for_va(va_to_method, c_va, name_mapping)
            if rn and not HASH_METHOD_RE.match(rn):
                callee_names.append(rn)

        targets.append({
            'key': f'{cls_semantic}::{new_name}',  # 'VRC_Main::m_07C'
            'class': cls_semantic,
            'obf': method_obf,
            'va': va_found,
            'pseudocode': (pseudocode or '')[:4000],  # truncate
            'strings': strings[:20],
            'callee_names': callee_names[:15],
        })

    print(f'\nStrong-class hash targets with Hex-Rays: {len(targets)}')
    # Sort by class to keep batches grouped
    targets.sort(key=lambda x: (x['class'], x['key']))

    OUT_DIR.mkdir(parents=True, exist_ok=True)
    # Clear old batches
    for f in OUT_DIR.glob('batch_*.json'):
        f.unlink()

    n_batches = 0
    for i in range(0, len(targets), BATCH_SIZE):
        batch = targets[i:i+BATCH_SIZE]
        out_f = OUT_DIR / f'batch_{n_batches:03d}.json'
        with open(out_f, 'w', encoding='utf-8') as f:
            json.dump(batch, f, indent=2, ensure_ascii=False)
        n_batches += 1

    print(f'Wrote {n_batches} batches to {OUT_DIR}')

    # Generate codex command for each batch
    cmd_file = OUT_DIR / 'run_codex_commands.sh'
    lines = ['#!/bin/bash']
    lines.append('# Run codex on each batch in parallel (8-way)')
    lines.append('set -e')
    for b in range(n_batches):
        batch_path = f'output/llm_batches_hexrays/batch_{b:03d}.json'
        pred_path = f'output/llm_batches_hexrays/predictions_{b:03d}.json'
        lines.append(f'''
filename=$(openssl rand -hex 4)
codex exec --skip-git-repo-check --full-auto \\
  -C "D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools" \\
  --config model_reasoning_effort="medium" \\
  2>>"/tmp/codex-${{filename}}.log" <<CODEXEOF &
Read {batch_path}. For each entry predict a meaningful C#/Unity method name based on pseudocode+strings+callees.
Emit JSON to {pred_path} as {{"key": predicted_name, ...}}. One-word camelCase/PascalCase names. Skip entries where you can't infer confidently. No chat.
CODEXEOF
''')
    lines.append('\nwait')
    lines.append('echo "All batches done"')
    with open(cmd_file, 'w', encoding='utf-8', newline='\n') as f:
        f.write('\n'.join(lines))
    print(f'Wrote {cmd_file}')
    return 0


if __name__ == '__main__':
    sys.exit(main())
