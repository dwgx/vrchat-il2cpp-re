#!/usr/bin/env python3
"""Prepare LLM prediction batches for hash-named methods.

Extracts rich context for each m_XXX method and groups into batch files
ready for Gemini/Codex prediction.
"""
import json, sys, re, time
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')
HASH_RE = re.compile(r'^m_[0-9a-fA-F]{3}$')
IDA_BASE = 0x180000000
DLL_BASE = 0x7ffaa7e70000

# Hex-Rays pseudocode (optional, from ida_hexrays_export.py)
HEXRAYS_PATH = BASE_DIR / 'output' / 'hexrays_export.json'

t0 = time.time()

# Load deobfuscated dump (has all the renamed context)
print('Loading deobfuscated_dump.json...')
with open(BASE_DIR / 'output' / 'deobfuscated_dump.json', 'r', encoding='utf-8') as f:
    dump = json.load(f)

# Load call graph data from ida_analysis
print('Loading ida_analysis.json...')
with open(BASE_DIR / 'data' / 'ida_analysis.json', 'r', encoding='utf-8') as f:
    ida = json.load(f)
funcs = ida['functions']

# Load precise_dump for method_pointers (RVA mapping)
print('Loading precise_dump.json...')
with open(BASE_DIR / 'data' / 'precise_dump.json', 'r', encoding='utf-8') as f:
    raw = json.load(f)

# Load name_mapping to reverse-map deobf names back to original obf names
print('Loading name_mapping.json...')
with open(BASE_DIR / 'output' / 'name_mapping.json', 'r', encoding='utf-8') as f:
    name_map = json.load(f)

# Build reverse mapping: deobf_class -> original_obf_class
deobf_to_obf_class = {}
for obf, deobf in name_map.get('classes', {}).items():
    deobf_to_obf_class[deobf] = obf

# Build RVA -> IDA function data for method_pointers
# original class name -> method_pointers
obf_class_method_ptrs = {}
for ns, classes in raw['namespaces'].items():
    for cls in classes:
        cn = cls['name']
        ptrs = cls.get('method_pointers', {})
        if ptrs:
            obf_class_method_ptrs[cn] = ptrs

# Build RVA -> (strings, calls) from IDA
rva_to_ida = {}
for addr_str, fdata in funcs.items():
    ida_addr = int(addr_str, 16)
    rva = ida_addr - IDA_BASE
    strings = fdata.get('strings', [])
    calls = fdata.get('calls', [])
    if strings or calls:
        rva_to_ida[rva] = {
            'strings': strings[:10],  # limit to 10 most relevant
            'call_count': len(calls),
        }

# Build named RVA map for call targets
rva_to_name = {}
for ns, classes in raw['namespaces'].items():
    for cls in classes:
        cn = cls['name']
        for mname, addr_str in cls.get('method_pointers', {}).items():
            try:
                rva = int(addr_str, 16) - DLL_BASE
                if not OBF_RE.match(mname):
                    rva_to_name[rva] = f'{cn}::{mname}'
            except Exception:
                pass

# Load field types
field_types = {}
ft_path = BASE_DIR / 'output' / 'field_types.json'
if ft_path.exists():
    with open(ft_path, 'r', encoding='utf-8') as f:
        field_types = json.load(f)

# Load Hex-Rays pseudocode (keyed by IDA EA hex string)
hexrays = {}
rva_to_hexrays = {}
if HEXRAYS_PATH.exists():
    print('Loading hexrays_export.json...')
    with open(HEXRAYS_PATH, 'r', encoding='utf-8') as f:
        hexrays_raw = json.load(f)
    # Re-key by RVA for matching with method_pointers
    for ea_str, entry in hexrays_raw.items():
        rva_str = entry.get('rva', '')
        if rva_str:
            try:
                rva = int(rva_str, 16)
                # Truncate pseudocode for batch context (first 60 lines)
                code = entry.get('code', '')
                lines = code.split('\n')
                if len(lines) > 60:
                    code = '\n'.join(lines[:60]) + f'\n// ... ({len(lines)} lines total)'
                rva_to_hexrays[rva] = code
            except ValueError:
                pass
    print(f'  Hex-Rays: {len(rva_to_hexrays):,} functions with pseudocode')
else:
    print('  (No hexrays_export.json found — run ida_hexrays_export.py in IDA first)')

print(f'Data loaded ({time.time()-t0:.1f}s)')

# Collect hash methods with context
print('\nCollecting hash methods with context...')
hash_methods = []
skipped_trivial = 0

for ns, classes in dump['namespaces'].items():
    for cls in classes:
        cls_name = cls['name']
        methods = cls.get('methods', [])
        fields = cls.get('fields', [])
        parent = cls.get('parent', '')

        # Skip compiler-generated classes
        if '<' in cls_name and '>' in cls_name:
            skipped_trivial += len([m for m in methods if isinstance(m, str) and HASH_RE.match(m)])
            continue

        # Get original obf class name for method_pointer lookup
        obf_cn = deobf_to_obf_class.get(cls_name, cls_name)
        method_ptrs = obf_class_method_ptrs.get(obf_cn, {})

        # Collect named methods as context
        named_methods = []
        hash_in_class = []
        for idx, m in enumerate(methods):
            if isinstance(m, dict):
                mname = m.get('name', '')
            else:
                mname = str(m)
            if HASH_RE.match(mname):
                hash_in_class.append((idx, mname))
            elif mname and not OBF_RE.match(mname) and mname not in ('.ctor', '.cctor', 'Finalize'):
                named_methods.append(mname)

        if not hash_in_class:
            continue

        # Collect field info
        field_info = []
        for f in fields[:20]:  # limit
            if isinstance(f, dict):
                fname = f.get('name', '')
                ftype = f.get('type', '')
            else:
                fname = str(f)
                ftype = ''
            if fname and not OBF_RE.match(fname):
                field_info.append(f'{ftype} {fname}' if ftype else fname)

        # For each hash method, get IDA context
        for idx, mname in hash_in_class:
            # Find original obf method name from name_mapping
            obf_mn = None
            for orig_m, mapped_m in name_map.get('methods', {}).items():
                if mapped_m == mname and orig_m.startswith(f'{obf_cn}::'):
                    obf_mn = orig_m.split('::', 1)[1]
                    break

            # Get RVA for this method
            ida_info = None
            pseudocode = None
            rva = None
            if obf_mn and obf_mn in method_ptrs:
                try:
                    rva = int(method_ptrs[obf_mn], 16) - DLL_BASE
                    ida_info = rva_to_ida.get(rva, None)
                    pseudocode = rva_to_hexrays.get(rva, None)
                except Exception:
                    pass

            # Context score: how much useful info we have
            score = len(named_methods) + len(field_info) * 0.5
            if ida_info:
                score += len(ida_info.get('strings', [])) * 2
                score += min(ida_info.get('call_count', 0), 10) * 0.3
            if pseudocode:
                score += 10  # pseudocode is the strongest signal

            entry = {
                'class': cls_name,
                'parent': parent,
                'method': mname,
                'index': idx,
                'total_methods': len(methods),
                'named_methods': named_methods[:30],
                'fields': field_info[:15],
                'score': round(score, 1),
            }
            if ida_info and ida_info.get('strings'):
                entry['strings'] = ida_info['strings']
            if ida_info and ida_info.get('call_count', 0) > 0:
                entry['call_count'] = ida_info['call_count']
            if pseudocode:
                entry['pseudocode'] = pseudocode

            hash_methods.append(entry)

print(f'  Total hash methods: {len(hash_methods):,}')
print(f'  Skipped trivial (compiler-gen): {skipped_trivial:,}')

# Sort by context score (richest first)
hash_methods.sort(key=lambda x: -x['score'])

# Show score distribution
scores = [m['score'] for m in hash_methods]
brackets = [(50, 'excellent'), (20, 'good'), (5, 'fair'), (0, 'poor')]
for threshold, label in brackets:
    count = sum(1 for s in scores if s >= threshold)
    print(f'  Score >= {threshold} ({label}): {count:,}')

# Filter: only predict for methods with score >= 3 (enough context)
predictable = [m for m in hash_methods if m['score'] >= 3]
print(f'\n  Predictable (score >= 3): {len(predictable):,}')

# Group by class for efficient batching
by_class = defaultdict(list)
for m in predictable:
    by_class[m['class']].append(m)

# Create batches (~50 methods each, keeping classes together)
BATCH_SIZE = 50
batches = []
current_batch = []
current_size = 0

for cls_name in sorted(by_class.keys()):
    methods = by_class[cls_name]
    if current_size + len(methods) > BATCH_SIZE and current_batch:
        batches.append(current_batch)
        current_batch = []
        current_size = 0
    current_batch.extend(methods)
    current_size += len(methods)

if current_batch:
    batches.append(current_batch)

print(f'  Batches: {len(batches)} (avg {len(predictable)/max(len(batches),1):.0f} methods/batch)')

# Save batches
out_dir = BASE_DIR / 'output' / 'llm_batches'
out_dir.mkdir(exist_ok=True)

for i, batch in enumerate(batches):
    with open(out_dir / f'batch_{i:04d}.json', 'w', encoding='utf-8') as f:
        json.dump(batch, f, indent=1, ensure_ascii=False)

# Save summary
summary = {
    'total_hash': len(hash_methods),
    'skipped_trivial': skipped_trivial,
    'predictable': len(predictable),
    'batches': len(batches),
    'avg_score': round(sum(m['score'] for m in predictable) / max(len(predictable), 1), 1),
}
with open(out_dir / 'summary.json', 'w', encoding='utf-8') as f:
    json.dump(summary, f, indent=2)

print(f'\nSaved {len(batches)} batches to {out_dir}')
print(f'Total time: {time.time()-t0:.1f}s')
