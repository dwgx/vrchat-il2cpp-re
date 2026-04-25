#!/usr/bin/env python3
"""
Path B batch builder — hexrays pseudocode + full class context.

Reads hexrays_named.json (724 entries with pseudocode) and builds maximally
rich batches for Gemini/codex: class theme, parent, named siblings, fields,
strings, AND the decompiled pseudocode itself.
"""
import json, re, sys, hashlib
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent

HP = re.compile(r'^m_[0-9A-F]{3}$')
BATCH_SIZE = 10  # small — pseudocode is token-heavy


def sh3(s: str) -> str:
    return hashlib.sha256(s.encode('utf-8')).hexdigest()[:3].upper()


def main():
    hx = json.load(open(BASE / 'output/v_new_ida/hexrays_named.json', 'r', encoding='utf-8'))
    pd = json.load(open(BASE / 'data/precise_dump.json', 'r', encoding='utf-8'))
    nm = json.load(open(BASE / 'output/name_mapping.json', 'r', encoding='utf-8'))
    cv = json.load(open(BASE / 'output/cross_version_method_names.json', 'r', encoding='utf-8'))

    # Try to load IDA string refs for extra context
    ida_strs = {}
    p = BASE / 'output/v_new_ida/ida_analysis.json'
    if p.exists():
        try:
            ida = json.load(open(p, 'r', encoding='utf-8'))
            for va, info in ida.get('functions', {}).items():
                if isinstance(info, dict) and info.get('strings'):
                    ida_strs[va.lower()] = info['strings'][:15]
        except Exception:
            pass

    mm = nm['methods']
    cm = nm['classes']

    # va -> [(cls_obf, method_obf), ...]
    va2pairs = defaultdict(list)
    # cls_obf -> full class record
    cls_records = {}
    for ns, cl_list in pd.get('namespaces', {}).items():
        if not isinstance(cl_list, list):
            continue
        for c in cl_list:
            cls_obf = c.get('name', '')
            cls_records[cls_obf] = c
            ptrs = c.get('method_pointers', {})
            if not isinstance(ptrs, dict):
                continue
            for m_name, va_str in ptrs.items():
                va2pairs[va_str.lower()].append((cls_obf, m_name))

    # Group targets by class
    by_class = defaultdict(list)
    kept_keys = set()

    for va_str, info in hx.items():
        if not info.get('pseudocode'):
            continue
        pairs = va2pairs.get(va_str.lower(), [])
        for cls_obf, m_obf in pairs:
            key = f'{cls_obf}::{m_obf}'
            sem = mm.get(key, '')
            if not (isinstance(sem, str) and HP.match(sem)):
                continue
            cls_sem = cm.get(cls_obf, cls_obf)
            # cross_version key format
            cv_key = f'{cls_sem}::m_{sh3(m_obf)}'
            if cv_key in cv or cv_key in kept_keys:
                continue
            kept_keys.add(cv_key)

            by_class[cls_obf].append({
                'cv_key': cv_key,
                'method_obf': m_obf,
                'hash_name': sem,  # e.g. m_4B2
                'pseudocode': info['pseudocode'],
                'va': va_str,
            })

    print(f'Classes with hash targets: {len(by_class)}')
    print(f'Unique hash methods: {sum(len(v) for v in by_class.values())}')

    # Build batch entries
    all_entries = []
    for cls_obf, methods in by_class.items():
        c = cls_records[cls_obf]
        cls_sem = cm.get(cls_obf, cls_obf)
        parent_obf = c.get('parent', '')
        parent_sem = cm.get(parent_obf, parent_obf) if parent_obf else ''

        # Gather named siblings (semantic names of other methods in this class)
        named_siblings = []
        all_fields = []
        for m_name in c.get('methods', []):
            if not isinstance(m_name, str):
                continue
            k = f'{cls_obf}::{m_name}'
            s = mm.get(k, '')
            if s and isinstance(s, str) and not HP.match(s):
                named_siblings.append(s)
        for f_name in c.get('fields', []):
            if isinstance(f_name, str):
                fk = f'{cls_obf}::{f_name}'
                fs = nm.get('fields', {}).get(fk, '') if 'fields' in nm else ''
                all_fields.append(fs if fs and not HP.match(fs) else f_name)

        # De-dup and cap
        named_siblings = list(dict.fromkeys(named_siblings))[:25]
        all_fields = list(dict.fromkeys(all_fields))[:20]

        for m in methods:
            strings = ida_strs.get(m['va'].lower(), [])
            entry = {
                'class': cls_sem,
                'class_obf': cls_obf,
                'parent': parent_sem,
                'method': m['hash_name'],  # m_XXX display form
                'cv_key': m['cv_key'],
                'named_methods': named_siblings,
                'fields': all_fields,
                'strings': strings,
                'pseudocode': m['pseudocode'],
            }
            all_entries.append(entry)

    # Shuffle by class so each batch is diverse (better for LLM)
    # but keep same-class entries reasonably together for context reuse
    print(f'Total entries: {len(all_entries)}')

    out_dir = BASE / 'output/llm_batches_hexrays_b'
    out_dir.mkdir(exist_ok=True)
    for f in out_dir.glob('batch_*.json'):
        f.unlink()
    for f in out_dir.glob('pred_*.json'):
        f.unlink()

    batches = []
    for i in range(0, len(all_entries), BATCH_SIZE):
        bf = out_dir / f'batch_{i // BATCH_SIZE:03d}.json'
        with open(bf, 'w', encoding='utf-8') as f:
            json.dump(all_entries[i:i + BATCH_SIZE], f, indent=1, ensure_ascii=False)
        batches.append(bf)
    print(f'Wrote {len(batches)} batches to {out_dir}')


if __name__ == '__main__':
    main()
