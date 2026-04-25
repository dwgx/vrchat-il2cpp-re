#!/usr/bin/env python3
"""Build method name propagation from shared method pointers (VA addresses).

When multiple methods share the same compiled code (same VA), they are
typically generic instantiations, interface implementations, or base/derived
overrides. If ANY of them has a non-obfuscated name, we can propagate it
to all the obfuscated ones sharing that VA.

This is the single most effective naming strategy for IL2CPP — it exploits
the fact that the C++ compiler deduplicates identical generic instantiations.
"""
import json, sys, re, time
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

t0 = time.time()

# ── Load data ────────────────────────────────────────────────────────────

print('Loading precise_dump.json...')
with open(BASE_DIR / 'data' / 'precise_dump.json', 'r', encoding='utf-8') as f:
    dump = json.load(f)
print(f'  Loaded ({time.time()-t0:.1f}s)')

# ── Build VA → methods map ───────────────────────────────────────────────

print('Building VA → methods index...')
va_to_methods = defaultdict(list)
total_ptrs = 0

for ns, classes in dump['namespaces'].items():
    for cls in classes:
        cn = cls['name']
        for method_name, ptr_str in cls.get('method_pointers', {}).items():
            if not ptr_str:
                continue
            total_ptrs += 1
            va_to_methods[ptr_str].append((cn, method_name))

print(f'  {total_ptrs:,} method pointers across {len(va_to_methods):,} unique VAs')

# ── Propagate names ──────────────────────────────────────────────────────

print('Propagating names from shared VAs...')
result = {}
stats = {
    'shared_vas': 0,
    'propagated': 0,
    'conflicts': 0,
    'no_source': 0,
}

# Priority scoring for name sources
def name_quality(name):
    """Higher score = better quality name to propagate."""
    if name.startswith('.'):  # .ctor, .cctor
        return 0
    # Explicit interface implementation (System.Collections.IList.get_IsFixedSize)
    if name.count('.') >= 2:
        return 1
    # Simple interface method (IDisposable.Dispose)
    if '.' in name:
        return 2
    # Property accessor
    if name.startswith('get_') or name.startswith('set_'):
        return 4
    # Event accessor
    if name.startswith('add_') or name.startswith('remove_'):
        return 3
    # Regular method name
    return 5


for va, methods in va_to_methods.items():
    if len(methods) < 2:
        continue

    stats['shared_vas'] += 1

    # Separate named and obfuscated
    named = []
    obfuscated = []
    for cn, mn in methods:
        if OBF_RE.match(mn):
            obfuscated.append((cn, mn))
        else:
            named.append((cn, mn))

    if not named or not obfuscated:
        if not named:
            stats['no_source'] += 1
        continue

    # Pick the best name to propagate
    # Prefer: regular methods > property accessors > interface > explicit interface
    best_name = None
    best_score = -1
    for cn, mn in named:
        q = name_quality(mn)
        if q > best_score:
            best_score = q
            best_name = mn

    if not best_name or best_name.startswith('.'):
        continue

    # Skip compiler-generated lambda/closure names
    if '<' in best_name and '>b__' in best_name:
        continue
    if '<' in best_name and '>d__' in best_name:
        continue

    # Skip if too many methods share this VA (likely a trivial stub like null check)
    if len(methods) > 500:
        stats['too_common'] = stats.get('too_common', 0) + 1
        continue

    # Clean up fully-qualified interface names for propagation
    clean_name = best_name
    if '.' in clean_name and '>' not in clean_name:
        # System.Collections.IList.get_IsFixedSize → get_IsFixedSize
        clean_name = clean_name.rsplit('.', 1)[-1]
    elif '>' in clean_name:
        # System.Collections.Generic.IEnumerator<X>.get_Current → get_Current
        m = re.search(r'\.(\w+)$', clean_name)
        if m:
            clean_name = m.group(1)

    # Propagate to all obfuscated methods sharing this VA
    for cn, mn in obfuscated:
        key = f'{cn}::{mn}'
        if key in result and result[key] != clean_name:
            stats['conflicts'] += 1
            # Keep the higher quality name
            existing_q = name_quality(result[key])
            if best_score > existing_q:
                result[key] = clean_name
        else:
            result[key] = clean_name
            stats['propagated'] += 1

# ── Save ─────────────────────────────────────────────────────────────────

output_path = BASE_DIR / 'output' / 'va_propagation_names.json'
with open(output_path, 'w', encoding='utf-8') as f:
    json.dump(result, f, indent=1, ensure_ascii=False)

elapsed = time.time() - t0

print(f'\n=== VA Propagation v2 Results ===')
print(f'  Shared VAs:    {stats["shared_vas"]:,}')
print(f'  Propagated:    {stats["propagated"]:,}')
print(f'  Conflicts:     {stats["conflicts"]:,} (resolved by quality)')
print(f'  No source:     {stats["no_source"]:,} (all obfuscated)')
print(f'  Too common:    {stats.get("too_common", 0):,} (>500 shared, likely stubs)')
print(f'  Output: {output_path}')
print(f'  Time: {elapsed:.1f}s')

# Show top propagated names
name_counts = defaultdict(int)
for v in result.values():
    name_counts[v] += 1
print(f'\nTop propagated names:')
for name, cnt in sorted(name_counts.items(), key=lambda x: -x[1])[:15]:
    print(f'  {cnt:5d}  {name}')
