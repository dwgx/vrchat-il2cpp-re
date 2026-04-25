#!/usr/bin/env python3
"""Merge LLM-predicted method names into unified output for the pipeline."""
import json, sys, re
from pathlib import Path
from collections import Counter

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
RESULT_DIR = BASE_DIR / 'output' / 'llm_batches' / 'results'
OUTPUT = BASE_DIR / 'output' / 'llm_predicted_names.json'

# Quality filters
BAD_NAMES = {
    'Update', 'Start', 'Awake', 'OnEnable', 'OnDisable', 'OnDestroy',
    'Initialize', 'Init', 'Setup', 'Process', 'Execute', 'Run',
    'Handle', 'DoWork', 'Method', 'Func', 'Unknown',
}
PASCAL_RE = re.compile(r'^[A-Z][a-zA-Z0-9_]{2,49}$')
# Also accept get_/set_ property accessors (valid C# pattern)
PROP_RE = re.compile(r'^[gs]et_[A-Z][a-zA-Z0-9]{2,49}$')
# Common short words that are NOT hallucination fragments
VALID_SHORT_WORDS = {'Is', 'In', 'On', 'As', 'At', 'To', 'By', 'Or', 'If', 'Up', 'Do', 'No', 'Of', 'Id'}
# Valid tail patterns (units, abbreviations)
VALID_TAILS = {'Ms', 'Kb', 'Mb', 'Gb', 'Id', 'Ui', 'Vr', 'Rpc', 'Api', 'Url', 'Sdk'}

print('Merging LLM prediction results...')
all_predictions = {}
file_count = 0

for f in sorted(RESULT_DIR.glob('*_results.json')):
    try:
        with open(f, 'r', encoding='utf-8') as fp:
            data = json.load(fp)
        if isinstance(data, dict):
            all_predictions.update(data)
            file_count += 1
            print(f'  {f.name}: {len(data)} predictions')
    except Exception as e:
        print(f'  {f.name}: ERROR - {e}')

print(f'\nRaw predictions: {len(all_predictions)} from {file_count} files')

# Quality filter
filtered = {}
rejected = Counter()

for key, name in all_predictions.items():
    # Normalize get_/set_ to PascalCase for pipeline compatibility
    normalized = name
    if PROP_RE.match(name):
        # Keep get_/set_ as-is — pipeline handles property accessors
        pass
    elif not PASCAL_RE.match(name):
        rejected['bad_format'] += 1
        continue
    # No generic names
    if normalized in BAD_NAMES:
        rejected['too_generic'] += 1
        continue
    # No hash-like names
    if re.match(r'^m_[0-9a-fA-F]{3}$', normalized):
        rejected['still_hash'] += 1
        continue
    # Reasonable length
    if len(normalized) < 4 or len(normalized) > 50:
        rejected['bad_length'] += 1
        continue
    # Reject names with random character fragments (LLM hallucination from junk strings)
    # But allow common short words like Is, In, On, To, etc.
    word_parts = re.findall(r'[A-Z][a-z]+|[A-Z]+(?=[A-Z][a-z]|\d|$)', normalized)
    junk_short = sum(1 for w in word_parts if len(w) <= 2 and w not in VALID_SHORT_WORDS)
    if junk_short >= 2:
        rejected['hallucinated_fragments'] += 1
        continue
    # Reject names ending in random chars (e.g., ProcessEemjh, HandleEvV)
    # But allow valid tail abbreviations (Ms, Id, Ui, etc.)
    if re.search(r'[A-Z][a-z]{0,1}[A-Z]?$', normalized) and len(normalized) > 8:
        tail = normalized[-4:]
        tail2 = normalized[-2:]
        tail3 = normalized[-3:]
        if not re.match(r'[A-Z][a-z]{2,}', tail) and tail2 not in VALID_TAILS and tail3 not in VALID_TAILS:
            rejected['random_tail'] += 1
            continue
    # Reject names with digits mixed in non-version patterns
    # But allow common numeric patterns (2D, 3D, 180, 360, V2, etc.)
    if re.search(r'[a-z]\d+[A-Za-z]', normalized):
        if not re.search(r'(2D|3D|To\d+|IPv[46]|\d+Range|\d+Degree)', normalized):
            rejected['embedded_digits'] += 1
            continue
    # Reject names containing hex/random suffixes
    if re.search(r'_m_[0-9a-fA-F]{3}$', normalized):
        rejected['hash_suffix'] += 1
        continue
    # Reject names with digits that look like junk
    if re.search(r'\d[A-Z][a-z]?\d', normalized):
        rejected['junk_digits'] += 1
        continue

    filtered[key] = normalized

print(f'Filtered: {len(filtered)} kept, {sum(rejected.values())} rejected')
for reason, count in rejected.most_common():
    print(f'  {reason}: {count}')

# Per-class uniqueness: if >3 methods in same class get the same name, it's hallucination
per_class_names = {}
for k, v in filtered.items():
    cls = k.split('::')[0]
    per_class_names.setdefault(cls, Counter())[v] += 1
class_hallucinated = set()
for cls, counts in per_class_names.items():
    for name, cnt in counts.items():
        if cnt > 3:
            class_hallucinated.add(name)
if class_hallucinated:
    before = len(filtered)
    filtered = {k: v for k, v in filtered.items() if v not in class_hallucinated}
    print(f'Removed {before - len(filtered)} per-class duplicates ({len(class_hallucinated)} names)')

# Check for too-frequent names (LLM hallucination)
freq = Counter(filtered.values())
hallucinated = {n for n, c in freq.items() if c > 10}
if hallucinated:
    before = len(filtered)
    filtered = {k: v for k, v in filtered.items() if v not in hallucinated}
    print(f'Removed {before - len(filtered)} exact-duplicate names ({len(hallucinated)} patterns)')

# Check for templated hallucination (same prefix with random suffixes)
# e.g., FormatText5Qr, FormatTextIkIq → same "FormatText" prefix
prefix_groups = Counter()
for name in filtered.values():
    # Extract the "meaningful prefix" (everything before last 1-3 random chars)
    m = re.match(r'^([A-Z][a-zA-Z]{4,}?)([A-Z0-9][a-z]?[A-Z0-9]?[a-z]?)$', name)
    if m:
        prefix_groups[m.group(1)] += 1
hallucinated_prefixes = {p for p, c in prefix_groups.items() if c > 2}
if hallucinated_prefixes:
    before = len(filtered)
    new_filtered = {}
    for k, v in filtered.items():
        m = re.match(r'^([A-Z][a-zA-Z]{4,}?)([A-Z0-9][a-z]?[A-Z0-9]?[a-z]?)$', v)
        if m and m.group(1) in hallucinated_prefixes:
            continue
        new_filtered[k] = v
    filtered = new_filtered
    print(f'Removed {before - len(filtered)} templated hallucinations ({len(hallucinated_prefixes)} prefix patterns: {list(hallucinated_prefixes)[:5]})')

# Save
with open(OUTPUT, 'w', encoding='utf-8') as f:
    json.dump(filtered, f, indent=1, ensure_ascii=False)

print(f'\nSaved {len(filtered)} predictions to {OUTPUT}')

# Show sample
print('\nSample predictions:')
for i, (k, v) in enumerate(list(filtered.items())[:15]):
    print(f'  {k} → {v}')
