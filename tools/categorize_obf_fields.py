#!/usr/bin/env python3
import json, sys, re
sys.stdout.reconfigure(encoding='utf-8')
OBF = re.compile(r'^[Ì-Ï]{3,}$')

with open('output/deobfuscated_dump.json', encoding='utf-8') as f:
    d = json.load(f)

counters = {'state_machine': 0, 'display_class': 0, 'backing': 0, 'user_code': 0, 'array': 0, 'lambda_class': 0, 'other': 0}
samples_by_cat = {k: [] for k in counters}

for ns, cs in d['namespaces'].items():
    for c in cs:
        cn = c.get('name', '')
        obf_fields = [f for f in (c.get('fields') or []) if isinstance(f, dict) and isinstance(f.get('name'), str) and OBF.match(f['name'])]
        if not obf_fields:
            continue
        cat = 'user_code'
        if re.search(r'>d__\d+', cn):
            cat = 'state_machine'
        elif '<>c__DisplayClass' in cn:
            cat = 'display_class'
        elif cn.startswith('<>c'):
            cat = 'lambda_class'
        elif 'k__BackingField' in cn:
            cat = 'backing'
        elif cn.startswith('$ArrayType'):
            cat = 'array'
        counters[cat] += len(obf_fields)
        if len(samples_by_cat[cat]) < 3:
            samples_by_cat[cat].append((cn, [(f['name'][:10] + '...', f.get('type', '?')[:40]) for f in obf_fields[:4]]))

for cat, cnt in sorted(counters.items(), key=lambda x: -x[1]):
    print(f'  {cat:18} = {cnt:>6,} fields')
    for cn, fs in samples_by_cat[cat][:2]:
        print(f'    e.g. {cn!r}')
        for fn, ft in fs:
            print(f'      {fn:14} : {ft}')
print(f'TOTAL obf fields: {sum(counters.values()):,}')
