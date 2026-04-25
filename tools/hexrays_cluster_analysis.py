#!/usr/bin/env python3
"""
Cross-function similarity clustering via Hex-Rays pseudocode structural features.

Loads hexrays_export.json (10K+ decompiled functions) and deobfuscated_dump.json,
extracts structural features from each function's pseudocode, clusters functions
by identical feature vectors, then propagates names from known functions to
hash-named (m_XXX) unknowns within the same cluster.

Output:
  - output/cluster_propagated_names.json  (ClassName::m_XXX -> PredictedName)
  - stdout stats: cluster counts, propagation counts, top patterns
"""

import json
import re
import sys
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

# ---------------------------------------------------------------------------
# Paths
# ---------------------------------------------------------------------------
BASE = Path(__file__).resolve().parent.parent
HEXRAYS_PATH = BASE / "output" / "hexrays_export.json"
DUMP_PATH = BASE / "output" / "deobfuscated_dump.json"
OUTPUT_PATH = BASE / "output" / "cluster_propagated_names.json"

IDA_BASE = 0x180000000

# Regex for hash method names
HASH_RE = re.compile(r'^m_[0-9a-fA-F]+$')
# Regex for Beebyte obfuscated names
BEEBYTE_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

# ---------------------------------------------------------------------------
# Feature extraction from Hex-Rays pseudocode
# ---------------------------------------------------------------------------

# Precompile all regexes once
RE_IF = re.compile(r'\bif\s*\(')
RE_ELSE = re.compile(r'\belse\b')
RE_LABEL = re.compile(r'^LABEL_\d+:', re.MULTILINE)
RE_GOTO = re.compile(r'\bgoto\b')
RE_CALL_SUB = re.compile(r'\bsub_[0-9A-Fa-f]+\s*\(')
RE_CALL_NAMED = re.compile(r'\b([A-Za-z_]\w+)\s*\(')
RE_STRING_LIT = re.compile(r'"([^"]*)"')
RE_RETURN = re.compile(r'\breturn\b')
RE_FIELD_OFFSET = re.compile(r'\*\([^)]*\)\s*\(\s*\w+\s*\+\s*(\d+)')
RE_VTABLE_CALL = re.compile(r'\(\*\*?\([^)]*\)\s*\(\s*\*?\w+')
RE_LOOP_WHILE = re.compile(r'\bwhile\s*\(')
RE_LOOP_DO = re.compile(r'\bdo\b')
RE_LOOP_FOR = re.compile(r'\bfor\s*\(')
RE_INTERLOCK = re.compile(r'_Interlocked\w+')
RE_NULL_CHECK = re.compile(r'if\s*\(\s*!\s*\w+\s*\)')
RE_THROW = re.compile(r'sub_[0-9A-Fa-f]+.*ThrowException|NullReferenceException|ArgumentException')
RE_PARAM = re.compile(r'__fastcall\s+\w+\(([^)]*)\)')


def classify_return_type(code: str) -> str:
    """Classify function return type from the signature line."""
    first_line = code.split('\n')[0] if code else ''
    fl = first_line.lower()
    if fl.startswith('void ') or 'void __' in fl:
        return 'void'
    if fl.startswith('bool ') or 'bool __' in fl:
        return 'bool'
    if fl.startswith('char ') or 'char __' in fl:
        return 'char'
    if fl.startswith('float ') or 'double ' in fl:
        return 'float'
    if '__int64' in fl or '__int32' in fl or 'int __' in fl or 'signed' in fl:
        return 'int'
    if '*' in fl:
        return 'pointer'
    return 'other'


def count_params(code: str) -> int:
    """Count the number of parameters from the function signature."""
    m = RE_PARAM.search(code)
    if not m:
        return 0
    params = m.group(1).strip()
    if not params or params == 'void':
        return 0
    return params.count(',') + 1


def bucket_value(n: int, thresholds: list) -> str:
    """Bucket a numeric value into ranges for coarser clustering."""
    for t in thresholds:
        if n <= t:
            return str(t)
    return str(thresholds[-1]) + '+'


def extract_features(code: str, line_count: int) -> dict:
    """Extract structural feature vector from pseudocode."""
    n_if = len(RE_IF.findall(code))
    n_else = len(RE_ELSE.findall(code))
    n_labels = len(RE_LABEL.findall(code))
    n_goto = len(RE_GOTO.findall(code))
    n_call_sub = len(RE_CALL_SUB.findall(code))
    n_call_named = len(RE_CALL_NAMED.findall(code))
    strings = RE_STRING_LIT.findall(code)
    n_returns = len(RE_RETURN.findall(code))
    field_offsets = RE_FIELD_OFFSET.findall(code)
    n_vtable = len(RE_VTABLE_CALL.findall(code))
    n_loops = len(RE_LOOP_WHILE.findall(code)) + len(RE_LOOP_DO.findall(code)) + len(RE_LOOP_FOR.findall(code))
    n_interlock = len(RE_INTERLOCK.findall(code))
    n_null_checks = len(RE_NULL_CHECK.findall(code))
    n_throws = len(RE_THROW.findall(code))
    n_params = count_params(code)
    ret_type = classify_return_type(code)

    # Bucket sizes for coarser grouping
    size_bucket = bucket_value(line_count, [5, 10, 20, 40, 80, 160, 320])
    branch_bucket = bucket_value(n_if, [0, 1, 2, 4, 8, 16, 32])
    call_bucket = bucket_value(n_call_sub + n_call_named, [0, 1, 2, 4, 8, 16, 32])

    # String literal signature: sorted unique string values (capped)
    string_sig = tuple(sorted(set(strings))[:8])

    # Field offset signature: sorted unique offsets accessed
    offset_sig = tuple(sorted(set(int(o) for o in field_offsets))[:12])

    return {
        'ret_type': ret_type,
        'n_params': min(n_params, 8),
        'size_bucket': size_bucket,
        'branch_bucket': branch_bucket,
        'n_else': min(n_else, 8),
        'call_bucket': call_bucket,
        'n_labels': min(n_labels, 8),
        'n_goto': min(n_goto, 8),
        'n_returns': min(n_returns, 4),
        'n_vtable': min(n_vtable, 8),
        'n_loops': min(n_loops, 4),
        'n_interlock': min(n_interlock, 4),
        'n_null_checks': min(n_null_checks, 8),
        'n_throws': min(n_throws, 4),
        'string_sig': string_sig,
        'offset_sig': offset_sig,
    }


def feature_key(feat: dict) -> tuple:
    """Convert feature dict to a hashable tuple for grouping."""
    return (
        feat['ret_type'],
        feat['n_params'],
        feat['size_bucket'],
        feat['branch_bucket'],
        feat['n_else'],
        feat['call_bucket'],
        feat['n_labels'],
        feat['n_goto'],
        feat['n_returns'],
        feat['n_vtable'],
        feat['n_loops'],
        feat['n_interlock'],
        feat['n_null_checks'],
        feat['n_throws'],
        feat['string_sig'],
        feat['offset_sig'],
    )


# ---------------------------------------------------------------------------
# Name propagation logic
# ---------------------------------------------------------------------------

def clean_method_name(name: str) -> str:
    """Strip generic class prefix, keep just method-level semantics."""
    # "ClassName::MethodName" -> "MethodName"
    if '::' in name:
        return name.split('::')[-1]
    return name


def derive_pattern_name(named_methods: list) -> str | None:
    """
    Given a list of (class_name, method_name) for known functions in a cluster,
    find a consensus pattern name. Returns None if too ambiguous.
    """
    # Collect clean method names
    method_names = []
    for cls, meth in named_methods:
        clean = clean_method_name(meth)
        if not HASH_RE.match(clean) and not BEEBYTE_RE.match(clean):
            method_names.append(clean)

    if not method_names:
        return None

    # Count occurrences
    counts = defaultdict(int)
    for n in method_names:
        counts[n] += 1

    # Pick the most common name
    best_name, best_count = max(counts.items(), key=lambda x: x[1])

    # Require at least some consensus (majority or sole name)
    if best_count >= len(method_names) * 0.4 or len(counts) == 1:
        return best_name

    # If multiple names but share a prefix like get_/set_, use that
    prefixes = defaultdict(int)
    for n in method_names:
        for p in ('get_', 'set_', 'add_', 'remove_', 'op_', '.ctor', '.cctor',
                  'On', 'Is', 'Has', 'Can', 'Get', 'Set', 'Do', 'Try'):
            if n.startswith(p):
                prefixes[p] += 1
                break

    if prefixes:
        best_prefix, _ = max(prefixes.items(), key=lambda x: x[1])
        return f"[{best_prefix}*]"

    return None


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    print("=" * 70)
    print("Hex-Rays Cross-Function Similarity Clustering")
    print("=" * 70)

    # ---- Load hexrays export ----
    print(f"\n[1/5] Loading {HEXRAYS_PATH.name}...")
    with open(HEXRAYS_PATH, 'r', encoding='utf-8') as f:
        hexrays = json.load(f)
    print(f"  Loaded {len(hexrays)} decompiled functions")

    # ---- Load dump and build RVA -> (class, method) map ----
    print(f"\n[2/5] Loading {DUMP_PATH.name} and building RVA map...")
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    ga_base = int(dump['summary']['ga_base'], 16)
    print(f"  ga_base = 0x{ga_base:X}")

    # Map: RVA -> list of (class_name, method_name)
    # (multiple entries possible for same VA due to generic instantiation)
    rva_to_info = defaultdict(list)
    total_mp = 0
    for ns_name, types in dump['namespaces'].items():
        for t in types:
            class_name = t['name']
            mp = t.get('method_pointers', {})
            if not mp:
                continue
            for mname, va_str in mp.items():
                va = int(va_str, 16)
                rva = va - ga_base
                rva_to_info[rva].append((class_name, mname))
                total_mp += 1

    print(f"  Built RVA map: {len(rva_to_info)} unique RVAs from {total_mp} method pointers")

    # ---- Extract features ----
    print(f"\n[3/5] Extracting structural features from pseudocode...")
    clusters = defaultdict(list)  # feature_key -> list of function info
    no_dump_match = 0
    matched_total = 0

    for ea_str, func in hexrays.items():
        ea = int(ea_str, 16)
        rva = ea - IDA_BASE
        code = func['code']
        lines = func['lines']
        ida_name = func['name']

        feat = extract_features(code, lines)
        fk = feature_key(feat)

        # Look up dump info
        dump_entries = rva_to_info.get(rva, [])
        if dump_entries:
            matched_total += 1
        else:
            no_dump_match += 1

        clusters[fk].append({
            'ea': ea_str,
            'rva': f"0x{rva:X}",
            'ida_name': ida_name,
            'dump_entries': dump_entries,
            'lines': lines,
        })

    total_clusters = len(clusters)
    singleton_clusters = sum(1 for v in clusters.values() if len(v) == 1)
    multi_clusters = total_clusters - singleton_clusters

    print(f"  Total clusters: {total_clusters}")
    print(f"  Singleton clusters: {singleton_clusters}")
    print(f"  Multi-function clusters: {multi_clusters}")
    print(f"  Functions matched to dump: {matched_total}, unmatched: {no_dump_match}")

    # ---- Cluster size distribution ----
    sizes = sorted([len(v) for v in clusters.values()], reverse=True)
    print(f"\n  Cluster size distribution (top 20):")
    for i, s in enumerate(sizes[:20]):
        print(f"    #{i+1}: {s} functions")

    # ---- Propagation ----
    print(f"\n[4/5] Propagating names from known to unknown methods...")
    propagated = {}      # "ClassName::m_XXX" -> predicted name
    cluster_stats = {
        'total_clusters': total_clusters,
        'singleton_clusters': singleton_clusters,
        'multi_function_clusters': multi_clusters,
        'mixed_clusters': 0,    # clusters with both known + unknown
        'total_propagations': 0,
        'pattern_examples': [],
    }

    for fk, members in clusters.items():
        if len(members) < 2:
            continue

        # Separate known (named) and unknown (hash) methods
        known = []   # (class_name, method_name)
        unknown = [] # (class_name, method_name, ea_str)

        for mem in members:
            for cls, meth in mem['dump_entries']:
                if HASH_RE.match(meth) or BEEBYTE_RE.match(meth):
                    unknown.append((cls, meth, mem['ea']))
                elif BEEBYTE_RE.match(cls):
                    # Class is obfuscated but method might be known
                    if not HASH_RE.match(meth):
                        known.append((cls, meth))
                    else:
                        unknown.append((cls, meth, mem['ea']))
                else:
                    known.append((cls, meth))

        if not known or not unknown:
            continue

        cluster_stats['mixed_clusters'] += 1

        # Derive pattern name from known methods
        pattern = derive_pattern_name(known)
        if not pattern:
            continue

        # Record examples for first N patterns
        if len(cluster_stats['pattern_examples']) < 30:
            known_sample = [(c, m) for c, m in known[:3]]
            unknown_sample = [(c, m) for c, m, _ in unknown[:3]]
            cluster_stats['pattern_examples'].append({
                'pattern': pattern,
                'cluster_size': len(members),
                'known_count': len(known),
                'unknown_count': len(unknown),
                'known_sample': known_sample,
                'unknown_sample': unknown_sample,
            })

        # Propagate
        for cls, meth, ea in unknown:
            key = f"{cls}::{meth}"
            propagated[key] = {
                'predicted_name': pattern,
                'confidence': 'structural_cluster',
                'cluster_known_count': len(known),
                'cluster_total': len(members),
                'ea': ea,
                'known_examples': [(c, m) for c, m in known[:3]],
            }
            cluster_stats['total_propagations'] += 1

    print(f"  Mixed clusters (known + unknown): {cluster_stats['mixed_clusters']}")
    print(f"  Total name propagations: {cluster_stats['total_propagations']}")

    # ---- Show top pattern examples ----
    print(f"\n[5/5] Top propagation patterns:")
    print("-" * 70)
    for ex in cluster_stats['pattern_examples'][:20]:
        pattern = ex['pattern']
        known_s = ', '.join(f'{c}::{m}' for c, m in ex['known_sample'])
        unknown_s = ', '.join(f'{c}::{m}' for c, m in ex['unknown_sample'])
        print(f"  Pattern: {pattern}")
        print(f"    Cluster: {ex['cluster_size']} funcs, {ex['known_count']} known, {ex['unknown_count']} unknown")
        print(f"    Known:   {known_s}")
        print(f"    Unknown: {unknown_s}")
        print()

    # ---- Save output ----
    output = {
        'stats': cluster_stats,
        'propagations': propagated,
    }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, indent=2, ensure_ascii=False)

    print(f"\nSaved {len(propagated)} propagations to {OUTPUT_PATH}")
    print("=" * 70)

    # ---- Summary ----
    print(f"\nSummary:")
    print(f"  Functions analyzed:       {len(hexrays)}")
    print(f"  Total clusters:           {total_clusters}")
    print(f"  Multi-function clusters:  {multi_clusters}")
    print(f"  Mixed (known+unknown):    {cluster_stats['mixed_clusters']}")
    print(f"  Names propagated:         {cluster_stats['total_propagations']}")

    # Count unique predicted patterns
    unique_patterns = set()
    for v in propagated.values():
        unique_patterns.add(v['predicted_name'])
    print(f"  Unique predicted patterns: {len(unique_patterns)}")


if __name__ == '__main__':
    main()
