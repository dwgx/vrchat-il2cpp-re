#!/usr/bin/env python3
"""
Match VRChat community deobfuscation maps against our precise_dump.
The maps use Il2CppAssemblyUnhollower-style signatures like:
  MonoBehaviourPublicStInDiIn2ObInSiStVRUnique
which encode: ParentClass + Public/Private + field/method type abbreviations

Strategy: match by structural fingerprint (parent, method count, field count,
readable method names, property names).
"""

import json, sys, os, re, gzip, csv, collections, hashlib
from pathlib import Path
from io import StringIO

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).parent
DUMP_PATH = BASE_DIR / 'il2cpp_full_dump' / 'precise_dump.json'
MAPS_DIR = BASE_DIR / 'VRChat-Deobfuscation-Maps'
OUTPUT_PATH = BASE_DIR / 'il2cpp_full_dump' / 'community_name_mapping.json'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')


def parse_unhollower_sig(sig: str) -> dict:
    """Parse Il2CppAssemblyUnhollower-style signature into structural features."""
    info = {
        'raw': sig,
        'parent': '',
        'visibility': '',
        'is_nested': False,
        'is_enum': False,
        'is_abstract': False,
        'is_sealed': False,
        'method_hint': '',
    }

    # Handle nested types (contains .)
    parts = sig.split('.')
    if len(parts) > 1:
        info['is_nested'] = True
        sig = parts[-1]  # focus on the inner type
        info['parent_sig'] = parts[0]

    # Extract parent class
    parent_map = {
        'MonoBehaviour': 'MonoBehaviour',
        'MonoBehaviour1': 'MonoBehaviour',
        'MonoBehaviour2': 'MonoBehaviour',
        'Object': 'Object',
        'ValueType': 'ValueType',
        'Enum': 'Enum',
        'ScriptableObject': 'ScriptableObject',
    }
    for prefix, parent in parent_map.items():
        if sig.startswith(prefix):
            info['parent'] = parent
            sig = sig[len(prefix):]
            break

    # Extract visibility
    if sig.startswith('Public'):
        info['visibility'] = 'Public'
        sig = sig[len('Public'):]
    elif sig.startswith('Private'):
        info['visibility'] = 'Private'
        sig = sig[len('Private'):]
    elif sig.startswith('NPublic'):
        info['visibility'] = 'Public'
        info['is_nested'] = True
        sig = sig[len('NPublic'):]
    elif sig.startswith('NPrivate'):
        info['visibility'] = 'Private'
        info['is_nested'] = True
        sig = sig[len('NPrivate'):]
    elif sig.startswith('NInternal'):
        info['visibility'] = 'Internal'
        info['is_nested'] = True
        sig = sig[len('NInternal'):]

    if 'Abstract' in sig:
        info['is_abstract'] = True
    if 'Sealed' in sig:
        info['is_sealed'] = True

    # The remaining part encodes field/method types
    # Two-letter codes: St=String, In=Int, Bo=Boolean, Ob=Object, Si=Single,
    # Di=Dictionary, Li=List, Ve=Vector3, Qu=Quaternion, etc.
    info['type_codes'] = sig

    return info


def build_class_fingerprint(cls: dict) -> dict:
    """Build a structural fingerprint from our dump class data."""
    methods = [m for m in cls.get('methods', []) if isinstance(m, str)]
    fields = [f for f in cls.get('fields', []) if isinstance(f, str)]
    parent = cls.get('parent', '')

    readable_methods = sorted([m for m in methods if not OBF_RE.match(m)])
    readable_fields = sorted([f for f in fields if not OBF_RE.match(f)])

    # Extract property names
    props = sorted(set(
        m.split('_', 1)[1] for m in readable_methods
        if m.startswith(('get_', 'set_')) and '_' in m and not OBF_RE.match(m.split('_', 1)[1])
    ))

    return {
        'name': cls['name'],
        'parent': parent,
        'method_count': len(methods),
        'field_count': len(fields),
        'readable_methods': readable_methods,
        'readable_fields': readable_fields,
        'properties': props,
        'has_awake': 'Awake' in readable_methods,
        'has_start': 'Start' in readable_methods,
        'has_update': 'Update' in readable_methods,
    }


def match_score(sig_info: dict, fingerprint: dict) -> float:
    """Score how well a community map signature matches our class fingerprint."""
    score = 0.0

    # Parent match is critical
    if sig_info['parent'] and fingerprint['parent']:
        if sig_info['parent'] == fingerprint['parent']:
            score += 10.0
        elif sig_info['parent'] in fingerprint['parent']:
            score += 5.0
        else:
            return 0.0  # parent mismatch = no match

    # MonoBehaviour specific: check lifecycle methods
    if sig_info['parent'] == 'MonoBehaviour':
        if not fingerprint['parent'] in ('MonoBehaviour', ''):
            # Could still match if parent is derived from MonoBehaviour
            pass

    return score


def main():
    print('Loading precise_dump.json...')
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Build fingerprints for all obfuscated classes
    obf_classes = []
    for ns, classes in dump['namespaces'].items():
        for cls in classes:
            if OBF_RE.match(cls['name']):
                fp = build_class_fingerprint(cls)
                obf_classes.append((cls['name'], fp))

    print(f'Obfuscated classes: {len(obf_classes)}')

    # Load ALL community maps and merge
    all_mappings = {}  # signature -> semantic_name
    map_files = sorted(MAPS_DIR.glob('*.csv.gz'))
    print(f'Found {len(map_files)} map files')

    for mf in map_files:
        with gzip.open(mf, 'rt', encoding='utf-8-sig') as f:
            for line in f:
                line = line.strip()
                if not line or line.startswith('#'):
                    continue
                parts = line.split(';')
                if len(parts) >= 2:
                    sig = parts[0].strip()
                    name = parts[1].strip()
                    if name and not name.startswith('_'):
                        all_mappings[sig] = name

    print(f'Total unique mappings: {len(all_mappings)}')

    # Parse all signatures
    parsed_sigs = {}
    for sig, name in all_mappings.items():
        parsed = parse_unhollower_sig(sig)
        parsed['semantic_name'] = name
        parsed_sigs[sig] = parsed

    # Strategy: the unhollower sig encodes the TYPE SIGNATURE of the class.
    # We can't directly decode it without the full type info.
    # Instead, we'll create a LOOKUP by semantic name for our existing class names.
    # The community maps tell us WHAT names exist in VRChat — we can use these
    # as a vocabulary to improve our naming.

    # Extract unique semantic names by category
    categories = collections.defaultdict(list)
    for sig, name in all_mappings.items():
        parsed = parse_unhollower_sig(sig)
        parent = parsed['parent']
        categories[parent].append(name)

    print('\nMappings by parent class:')
    for parent, names in sorted(categories.items(), key=lambda x: -len(x[1])):
        if parent:
            print(f'  {parent}: {len(names)} names')
            print(f'    Examples: {names[:5]}')

    # Direct name matching: some semantic names might match our readable methods/properties
    # Build reverse lookup: semantic_name -> [signatures]
    name_to_sigs = collections.defaultdict(list)
    for sig, name in all_mappings.items():
        name_to_sigs[name].append(sig)

    # For each obfuscated class in our dump, check if any readable method/property
    # matches a community-known class pattern
    matches = {}
    for obf_name, fp in obf_classes:
        # Check if any property name matches a known class name
        for prop in fp['properties']:
            if prop in name_to_sigs:
                matches[obf_name] = f'{prop}_matched'
                break

        # Check readable methods for VRChat-specific patterns
        for method in fp['readable_methods']:
            # RPC methods are very specific
            if method.endswith('RPC'):
                for name, sigs in name_to_sigs.items():
                    for sig in sigs:
                        if method in sig:
                            matches[obf_name] = name
                            break

    print(f'\nDirect matches found: {len(matches)}')

    # The real value: export the community vocabulary for manual/heuristic use
    vocab = {
        'total_mappings': len(all_mappings),
        'unique_names': sorted(set(all_mappings.values())),
        'by_parent': {k: sorted(set(v)) for k, v in categories.items()},
        'direct_matches': matches,
        'all_mappings': {sig: name for sig, name in list(all_mappings.items())[:500]},
    }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(vocab, f, indent=2, ensure_ascii=False)

    print(f'\nSaved community vocabulary to {OUTPUT_PATH}')
    print(f'  Unique class names: {len(set(all_mappings.values()))}')
    print(f'  Can be used to improve naming vocabulary')

    # Print most interesting VRChat-specific names
    vrc_names = [n for n in set(all_mappings.values())
                 if not n.startswith(('_', '__')) and len(n) > 5]
    vrc_names.sort()

    print(f'\n=== VRChat Internal Class Names (Community Mapped) ===')
    important = [n for n in vrc_names if any(k in n.lower() for k in
        ['player', 'avatar', 'network', 'world', 'udon', 'camera', 'audio',
         'menu', 'ui', 'safety', 'friend', 'portal', 'mirror', 'station'])]
    for n in sorted(important):
        print(f'  {n}')


if __name__ == '__main__':
    main()
