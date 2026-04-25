#!/usr/bin/env python3
"""Build method names from IDA call graph analysis (ida_analysis.json 82MB)."""
import json, sys, re, time
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
IDA_BASE = 0x180000000
DLL_BASE = 0x7ffaa7e70000  # from precise_dump ga_base
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

t0 = time.time()

# Load call graph
print('Loading ida_analysis.json...')
with open(BASE_DIR / 'data' / 'ida_analysis.json', 'r', encoding='utf-8') as f:
    ida = json.load(f)
funcs = ida['functions']
print(f'  {len(funcs):,} functions ({time.time()-t0:.1f}s)')

# Load dump for method pointers
print('Loading precise_dump.json...')
with open(BASE_DIR / 'data' / 'precise_dump.json', 'r', encoding='utf-8') as f:
    raw = json.load(f)

# Build RVA maps
rva_to_method = {}
for ns, classes in raw['namespaces'].items():
    for cls in classes:
        cn = cls['name']
        for mname, addr_str in cls.get('method_pointers', {}).items():
            try:
                rva = int(addr_str, 16) - DLL_BASE
                rva_to_method[rva] = (cn, mname)
            except Exception:
                pass

named_rvas = {}
obf_rvas = {}
for rva, (cn, mn) in rva_to_method.items():
    if OBF_RE.match(mn):
        obf_rvas[rva] = (cn, mn)
    else:
        named_rvas[rva] = (cn, mn)

print(f'  Named: {len(named_rvas):,}, Obf: {len(obf_rvas):,}')

# Build call graph
print('Building call graph...')
callee_graph = {}
caller_graph = defaultdict(list)

for ida_addr_str, fdata in funcs.items():
    ida_addr = int(ida_addr_str, 16)
    rva = ida_addr - IDA_BASE
    calls = fdata.get('calls', [])
    if calls:
        callee_rvas = []
        for c in calls:
            c_rva = int(c, 16) - IDA_BASE
            callee_rvas.append(c_rva)
            caller_graph[c_rva].append(rva)
        callee_graph[rva] = callee_rvas

print(f'  {len(callee_graph):,} callers, {len(caller_graph):,} callees')

# === STRATEGY 1: Callee-based naming ===
print('\nStrategy 1: Callee-based naming...')
callee_names = {}
for rva, (cn, mn) in obf_rvas.items():
    if rva not in callee_graph:
        continue
    callees = callee_graph[rva]
    sets, gets, actions, handlers = [], [], [], []
    for c_rva in callees:
        if c_rva not in named_rvas:
            continue
        c_cn, c_mn = named_rvas[c_rva]
        if c_mn in ('.ctor', '.cctor', 'Finalize', 'GetHashCode', 'Equals', 'ToString'):
            continue
        if c_mn.startswith('get_'):
            gets.append(c_mn[4:])
        elif c_mn.startswith('set_'):
            sets.append(c_mn[4:])
        elif c_mn.startswith('On'):
            handlers.append(c_mn)
        elif len(c_mn) > 2:
            actions.append(c_mn)

    inferred = None
    if handlers:
        main = max(set(handlers), key=handlers.count)
        inferred = f'Dispatch{main}'
    elif sets and len(sets) >= len(gets):
        main = max(set(sets), key=sets.count)
        inferred = f'Configure{main}'
    elif actions:
        main = max(set(actions), key=actions.count)
        inferred = f'Do{main}'
    elif gets:
        main = max(set(gets), key=gets.count)
        inferred = f'Compute{main}'

    if inferred and 3 < len(inferred) < 50:
        callee_names[f'{cn}::{mn}'] = inferred

print(f'  {len(callee_names):,} callee-based names')

# === STRATEGY 2: Caller-based naming ===
print('Strategy 2: Caller-based naming...')
caller_names = {}
for rva, (cn, mn) in obf_rvas.items():
    key = f'{cn}::{mn}'
    if key in callee_names:
        continue
    if rva not in caller_graph:
        continue
    labels = []
    for c_rva in caller_graph[rva]:
        if c_rva in named_rvas:
            c_cn, c_mn = named_rvas[c_rva]
            if c_mn not in ('.ctor', '.cctor', 'Finalize') and len(c_mn) > 2:
                labels.append(c_mn)
    if not labels:
        continue
    most = max(set(labels), key=labels.count)
    if most.startswith(('get_', 'set_')):
        inferred = f'Helper_{most.split("_", 1)[1]}'
    elif most.startswith('On'):
        inferred = f'{most}_impl'
    else:
        inferred = f'{most}_sub'
    if 3 < len(inferred) < 50:
        caller_names[key] = inferred

print(f'  {len(caller_names):,} caller-based names')

# === STRATEGY 3: Broader string-ref naming ===
print('Strategy 3: String-ref from call graph...')
string_names = {}
for rva, (cn, mn) in obf_rvas.items():
    key = f'{cn}::{mn}'
    if key in callee_names or key in caller_names:
        continue
    ida_addr = hex(rva + IDA_BASE)
    if ida_addr not in funcs:
        continue
    strings = funcs[ida_addr].get('strings', [])
    useful = []
    for s in strings:
        if len(s) < 6 or s == 'H':
            continue
        m = re.search(r'UnityEngine\.(\w+)::(\w+)', s)
        if m:
            useful.append(m.group(2))
        elif re.search(r'VRC|Avatar|Player|Photon|Network', s):
            clean = re.sub(r'[^A-Za-z0-9]', '', s[:25])
            if len(clean) > 3:
                useful.append(clean)
    if useful:
        main = max(set(useful), key=useful.count)
        if main.startswith(('get_', 'set_')):
            string_names[key] = f'Access{main.split("_",1)[1]}'
        else:
            string_names[key] = f'Do{main}'

print(f'  {len(string_names):,} string-ref names')

# Merge (callee > caller > string)
all_names = {}
all_names.update(string_names)
all_names.update(caller_names)
all_names.update(callee_names)
print(f'\nTotal before filter: {len(all_names):,}')

# Quality filter
freq = Counter(all_names.values())
generic = {n for n, c in freq.items() if c > 50}
filtered = {k: v for k, v in all_names.items() if v not in generic}
print(f'Filtered {len(generic)} generic names, remaining: {len(filtered):,}')

# Save
out_path = BASE_DIR / 'output' / 'callgraph_method_names.json'
with open(out_path, 'w', encoding='utf-8') as f:
    json.dump(filtered, f, indent=1, ensure_ascii=False)

print(f'\nSaved to {out_path}')
print(f'Total time: {time.time()-t0:.1f}s')

freq2 = Counter(filtered.values())
print(f'\nTop 20:')
for n, c in freq2.most_common(20):
    print(f'  {n}: {c}')
