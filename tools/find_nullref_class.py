#!/usr/bin/env python3
"""Find the EnterWorld NullRef class and method RVAs in precise_dump.json."""
import sys, json, os

sys.stdout.reconfigure(encoding='utf-8')

DUMP = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
                     "data", "precise_dump.json")

# Target class: ÏÏÌÏÍÏÏÎÌÍÎÍÌÌÍÌÍÏÍÍÏÌÏ
target_class = '\u00cf\u00cf\u00cc\u00cf\u00cd\u00cf\u00cf\u00ce\u00cc\u00cd\u00ce\u00cd\u00cc\u00cc\u00cd\u00cc\u00cd\u00cf\u00cd\u00cd\u00cf\u00cc\u00cf'
# Method1: ÎÎÏÎÌÍÎÍÏÍÏÏÏÏÍÌÏÏÏÏÎÍÍ (throws NullRef)
target_m1 = '\u00ce\u00ce\u00cf\u00ce\u00cc\u00cd\u00ce\u00cd\u00cf\u00cd\u00cf\u00cf\u00cf\u00cf\u00cd\u00cc\u00cf\u00cf\u00cf\u00cf\u00ce\u00cd\u00cd'
# Method2: ÌÌÏÎÍÌÏÍÌÎÏÌÍÏÍÍÎÍÌÌÎÎÍ (caller)
target_m2 = '\u00cc\u00cc\u00cf\u00ce\u00cd\u00cc\u00cf\u00cd\u00cc\u00ce\u00cf\u00cc\u00cd\u00cf\u00cd\u00cd\u00ce\u00cd\u00cc\u00cc\u00ce\u00ce\u00cd'

print(f"Loading {DUMP}...")
with open(DUMP, 'r', encoding='utf-8') as f:
    data = json.load(f)

print(f"Searching {len(data.get('classes', []))} classes...")
print(f"Target class (first 10): {repr(target_class[:10])}")
print(f"Target method1 (first 10): {repr(target_m1[:10])}")
print(f"Target method2 (first 10): {repr(target_m2[:10])}")
print()

found = False
for cls in data.get('classes', []):
    name = cls.get('name', '')
    if name == target_class:
        found = True
        print(f"=== FOUND CLASS ===")
        print(f"  Name: {repr(name)}")
        print(f"  Namespace: {cls.get('namespace', '')}")
        print(f"  Parent: {cls.get('parent', '')}")
        print(f"  Methods ({len(cls.get('methods', []))}):")
        for m in cls.get('methods', []):
            mname = m.get('name', '')
            ptr = m.get('method_pointer', '?')
            params = m.get('parameters', [])
            param_str = ', '.join(p.get('type', '?') for p in params) if params else ''
            is_target = ''
            if mname == target_m1:
                is_target = ' *** NULLREF METHOD ***'
            elif mname == target_m2:
                is_target = ' *** CALLER METHOD ***'
            print(f"    {repr(mname[:20])}({param_str}) -> {ptr}{is_target}")
        break

if not found:
    print("Exact match not found. Trying partial match (first 8 chars)...")
    for cls in data.get('classes', []):
        name = cls.get('name', '')
        if len(name) >= 8 and name[:8] == target_class[:8]:
            print(f"  Partial: {repr(name)} (len={len(name)})")
            print(f"    Match: target[:8]={repr(target_class[:8])} == name[:8]={repr(name[:8])}")
            for m in cls.get('methods', []):
                print(f"    Method: {repr(m.get('name','')[:15])} -> {m.get('method_pointer','?')}")

# Also try to find by method name alone
print("\n--- Searching all methods for target_m1 ---")
count = 0
for cls in data.get('classes', []):
    for m in cls.get('methods', []):
        if m.get('name', '') == target_m1:
            print(f"  Found in class {repr(cls.get('name','')[:20])}: ptr={m.get('method_pointer','?')}")
            count += 1
if count == 0:
    # try partial
    print("  No exact match. Trying first 10 chars...")
    for cls in data.get('classes', []):
        for m in cls.get('methods', []):
            mname = m.get('name', '')
            if len(mname) >= 10 and mname[:10] == target_m1[:10]:
                print(f"  Partial: class={repr(cls.get('name','')[:15])} method={repr(mname[:15])} ptr={m.get('method_pointer','?')}")
