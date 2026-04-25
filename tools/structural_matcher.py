#!/usr/bin/env python3
"""
Structural Fingerprint Matcher for VRChat Beebyte Deobfuscation
================================================================
Uses known VRChat class identification rules (from community mods)
+ community deobfuscation maps to match obfuscated classes to real names.

Approach:
1. Hard rules: match by unique preserved method names (RPC, callbacks)
2. Structural fingerprints: match by (parent, method_count, field_count, preserved_methods)
3. Community vocabulary: apply known VRChat class names where structure matches

Output: il2cpp_full_dump/structural_matches.json
"""

import json, sys, re, collections, gzip
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).parent
DUMP_PATH = BASE_DIR / 'il2cpp_full_dump' / 'precise_dump.json'
DEOBF_PATH = BASE_DIR / 'il2cpp_full_dump' / 'deobfuscated_dump.json'
MAPS_DIR = BASE_DIR / 'VRChat-Deobfuscation-Maps'
OUTPUT_PATH = BASE_DIR / 'il2cpp_full_dump' / 'structural_matches.json'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

# ── Hard Rules ─────────────────────────────────────────────────────
# Based on vrchat_dumper, ReModCE, VRCMods, and community knowledge.
# Format: rule_name -> (check_function, confidence)
# Each check_function receives (cls_data) and returns bool.

def has_method(cls, name):
    return name in [m for m in cls.get('methods', []) if isinstance(m, str)]

def has_any_method(cls, *names):
    methods = set(m for m in cls.get('methods', []) if isinstance(m, str))
    return bool(methods.intersection(names))

def has_method_containing(cls, substring):
    return any(substring in m for m in cls.get('methods', []) if isinstance(m, str))

def has_field_containing(cls, substring):
    return any(substring in f for f in cls.get('fields', []) if isinstance(f, str))

def method_count_range(cls, lo, hi):
    return lo <= len(cls.get('methods', [])) <= hi

def parent_is(cls, parent):
    return cls.get('parent', '') == parent


# Rule definitions: (real_name, check_func, confidence 1-100)
HARD_RULES = [
    # === Core Player/Avatar ===
    ('VRCPlayer', lambda c: has_method(c, 'ReloadAvatarNetworkedRPC') and has_method(c, 'PlayEmoteRPC'),
     99),
    ('VRCAvatarManager', lambda c: has_method(c, 'ReloadAvatarNetworkedRPC') and not has_method(c, 'PlayEmoteRPC')
     and method_count_range(c, 30, 200) and parent_is(c, 'MonoBehaviour'),
     80),
    ('PlayerNet', lambda c: has_method(c, 'NeedsSync') and has_method(c, 'Decode')
     and has_method(c, 'get_TypeId') and method_count_range(c, 30, 200),
     85),
    ('EmotePlayer', lambda c: has_method(c, 'PlayEmoteRPC') and not has_method(c, 'ReloadAvatarNetworkedRPC'),
     75),

    # === Networking ===
    ('NetworkManager', lambda c: has_method(c, 'OnNetworkReady') and method_count_range(c, 200, 1000)
     and parent_is(c, 'MonoBehaviour'),
     90),
    ('VRCFlowNetworkManager', lambda c: has_method(c, 'OnJoinedRoom') and has_method(c, 'OnLeftRoom')
     and has_method(c, 'OnPlayerEnteredRoom'),
     95),
    ('VRCNetworkBehaviour', lambda c: has_method(c, 'NeedsSync') and has_method(c, 'Decode')
     and has_method(c, 'Encode') and has_method(c, 'OnNetworkReady'),
     90),
    ('VRCNetworkBehaviourBase', lambda c: has_method(c, 'NeedsSync') and has_method(c, 'CanSerialize32Bit')
     and method_count_range(c, 10, 50),
     85),

    # === UI ===
    ('VRCUiManager', lambda c: parent_is(c, 'UIManager') and method_count_range(c, 200, 500),
     95),
    ('QuickMenu', lambda c: has_method_containing(c, 'OnPointerClick') and parent_is(c, 'MonoBehaviour')
     and method_count_range(c, 80, 200),
     60),
    ('ActionMenu', lambda c: has_method_containing(c, 'OnPointerEnter') and has_method_containing(c, 'OnPointerExit')
     and has_method(c, 'Awake') and method_count_range(c, 50, 150),
     50),

    # === Input/VR ===
    ('VRCInputController', lambda c: has_method_containing(c, 'TryGetFeatureValue')
     and parent_is(c, 'MonoBehaviour') and method_count_range(c, 100, 300),
     85),
    ('VRCMotionState', lambda c: has_method(c, 'FixedUpdate') and has_method(c, 'Update')
     and has_method(c, 'LateUpdate') and parent_is(c, 'MonoBehaviour')
     and method_count_range(c, 50, 150),
     50),

    # === Camera ===
    ('CameraControl', lambda c: has_method_containing(c, 'Render') and has_method_containing(c, 'Camera')
     and parent_is(c, 'MonoBehaviour'),
     50),

    # === World ===
    ('VRCFlowManager', lambda c: has_method(c, 'Start') and has_method(c, 'Awake')
     and method_count_range(c, 400, 1200) and parent_is(c, 'MonoBehaviour'),
     60),

    # === Major Systems (the 966-method monster) ===
    ('VRC_Main', lambda c: parent_is(c, 'MonoBehaviour') and method_count_range(c, 900, 1100)
     and has_method(c, 'Awake') and has_method(c, 'Update'),
     95),
    ('VRC_Secondary', lambda c: parent_is(c, 'MonoBehaviour') and method_count_range(c, 450, 550)
     and has_method(c, 'Awake') and has_method(c, 'Update') and has_method(c, 'LateUpdate'),
     85),

    # === Audio ===
    ('PlayerAudioManager', lambda c: has_method(c, 'Awake') and has_method_containing(c, 'Audio')
     and parent_is(c, 'MonoBehaviour'),
     40),

    # === Serialization ===
    ('FlatBufferNetworkSerializer', lambda c: has_method(c, 'NeedsSync')
     and has_method(c, 'Encode') and has_method(c, 'Decode')
     and has_method(c, 'UpdatePuppetChannelTypes'),
     90),
]


# ── Community Map Matching ─────────────────────────────────────────

def load_community_maps():
    """Load all community deobfuscation maps and extract class name vocabulary."""
    all_names = {}  # sig -> name
    if MAPS_DIR.exists():
        for mf in sorted(MAPS_DIR.glob('*.csv.gz')):
            with gzip.open(mf, 'rt', encoding='utf-8-sig') as f:
                for line in f:
                    line = line.strip()
                    if not line or line.startswith('#'):
                        continue
                    parts = line.split(';')
                    if len(parts) >= 2:
                        sig, name = parts[0].strip(), parts[1].strip()
                        if name and not name.startswith('__'):
                            all_names[sig] = name
    return all_names


def parse_unhollower_sig(sig):
    """Extract parent class from unhollower-style signature."""
    parents = ['MonoBehaviour', 'ScriptableObject', 'Object', 'ValueType', 'Enum']
    for p in parents:
        if sig.startswith(f'.{p}') or sig.startswith(p):
            return p
    return ''


# ── Main Matching Engine ───────────────────────────────────────────

def main():
    print('Loading dump...')
    with open(DUMP_PATH, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    # Build class list
    all_classes = []
    for ns, classes in dump['namespaces'].items():
        for cls in classes:
            if OBF_RE.match(cls['name']):
                all_classes.append(cls)

    print(f'Obfuscated classes to match: {len(all_classes)}')

    # Phase 1: Apply hard rules
    print('\n=== Phase 1: Hard Rules ===')
    matches = {}  # obf_name -> {real_name, confidence, rule}
    matched_names = set()  # avoid duplicate real names

    for cls in all_classes:
        best_match = None
        best_conf = 0

        for real_name, check_fn, confidence in HARD_RULES:
            if real_name in matched_names:
                continue  # already assigned
            try:
                if check_fn(cls) and confidence > best_conf:
                    best_match = real_name
                    best_conf = confidence
            except:
                pass

        if best_match and best_conf >= 50:
            matches[cls['name']] = {
                'real_name': best_match,
                'confidence': best_conf,
                'source': 'hard_rule',
                'method_count': len(cls.get('methods', [])),
                'parent': cls.get('parent', ''),
            }
            if best_conf >= 80:
                matched_names.add(best_match)

    print(f'  Hard rule matches: {len(matches)}')
    for obf, info in sorted(matches.items(), key=lambda x: -x[1]['confidence']):
        print(f'    {info["real_name"]:40s} (conf={info["confidence"]:3d}) [{info["parent"]}] {info["method_count"]}m')

    # Phase 2: Structural fingerprint matching with community maps
    print('\n=== Phase 2: Community Map Vocabulary ===')
    community_maps = load_community_maps()
    print(f'  Loaded {len(community_maps)} community mappings')

    # Extract unique class names and their parent types
    community_classes = {}
    for sig, name in community_maps.items():
        parent = parse_unhollower_sig(sig)
        if name not in community_classes:
            community_classes[name] = {'parent': parent, 'sig': sig}

    # Match by parent + preserved method overlap
    # Build a method-name to community-class index
    comm_by_parent = collections.defaultdict(list)
    for name, info in community_classes.items():
        comm_by_parent[info['parent']].append(name)

    # For unmatched obfuscated classes with readable methods:
    # Check if their readable methods suggest a community-known class
    method_to_comm = {
        'ReloadAvatarNetworkedRPC': 'VRCPlayer',
        'PlayEmoteRPC': 'VRCPlayer',
        'CancelRPC': 'VRCNetworkBehaviour',
        'EnableMeshRPC': 'VRCNetworkBehaviour',
        'SetPresetRPC': 'VRCNetworkBehaviour',
        'InternalApplyOverrideRPC': 'VRCNetworkBehaviour',
        'ResetHealthRPC': 'PlayerModComponentHealth',
        'OnJoinedRoom': 'VRCFlowNetworkManager',
        'OnLeftRoom': 'VRCFlowNetworkManager',
        'OnPlayerEnteredRoom': 'VRCFlowNetworkManager',
        'OnPlayerLeftRoom': 'VRCFlowNetworkManager',
        'OnMasterClientSwitched': 'VRCFlowNetworkManager',
        'OnPhotonSerializeView': 'PhotonSerializable',
        'OnNetworkReady': 'VRCNetworkBehaviour',
        'UpdatePuppetChannelTypes': 'FlatBufferNetworkSerializer',
    }

    for cls in all_classes:
        if cls['name'] in matches:
            continue
        methods = [m for m in cls.get('methods', []) if isinstance(m, str) and not OBF_RE.match(m)]
        for m in methods:
            if m in method_to_comm:
                real = method_to_comm[m]
                if real not in matched_names:
                    matches[cls['name']] = {
                        'real_name': real,
                        'confidence': 70,
                        'source': 'method_to_community',
                        'method_count': len(cls.get('methods', [])),
                        'parent': cls.get('parent', ''),
                        'matched_method': m,
                    }
                    matched_names.add(real)
                    break

    phase2_new = sum(1 for v in matches.values() if v['source'] == 'method_to_community')
    print(f'  Method→community matches: {phase2_new}')

    # Phase 3: Property-based matching
    print('\n=== Phase 3: Property-Based Matching ===')

    prop_to_class = {
        'EffectBundleID': 'VFXBundleInfo',
        'IsSpecialFX': 'VFXBundleInfo',
        'controlPathInternal': 'InputControlBinding',
        'ServerTimeUtc': 'ServerTimeManager',
        'CompletedSynchronously': 'AsyncResult',
        'AsyncWaitHandle': 'AsyncResult',
        'IsInteractive': 'VRC_Interactable',
        'LightReservedLayerMask': 'LightManager',
        'DisplayTexture': 'AnimatedTexture',
        'FullResolutionTexture': 'AnimatedTexture',
        'AnimationStyle': 'AnimatedTexture',
        'UniqueHash': 'AnimatedTexture',
        'MaskTag': 'AnimatedTexture',
    }

    for cls in all_classes:
        if cls['name'] in matches:
            continue
        methods = [m for m in cls.get('methods', []) if isinstance(m, str)]
        props = [m.split('_', 1)[1] for m in methods
                 if m.startswith('get_') and '_' in m and not OBF_RE.match(m.split('_', 1)[1])]
        for p in props:
            if p in prop_to_class:
                real = prop_to_class[p]
                if real not in matched_names:
                    matches[cls['name']] = {
                        'real_name': real,
                        'confidence': 65,
                        'source': 'property_match',
                        'method_count': len(cls.get('methods', [])),
                        'parent': cls.get('parent', ''),
                        'matched_property': p,
                    }
                    matched_names.add(real)
                    break

    phase3_new = sum(1 for v in matches.values() if v['source'] == 'property_match')
    print(f'  Property matches: {phase3_new}')

    # Summary
    print(f'\n{"="*60}')
    print(f'TOTAL STRUCTURAL MATCHES: {len(matches)}')
    print(f'{"="*60}')

    high_conf = sum(1 for v in matches.values() if v['confidence'] >= 80)
    med_conf = sum(1 for v in matches.values() if 50 <= v['confidence'] < 80)
    print(f'  High confidence (≥80): {high_conf}')
    print(f'  Medium confidence (50-79): {med_conf}')

    print(f'\nAll matches:')
    for obf, info in sorted(matches.items(), key=lambda x: -x[1]['confidence']):
        print(f'  {info["real_name"]:40s} conf={info["confidence"]:3d}  [{info["parent"]:20s}] {info["method_count"]:4d}m  src={info["source"]}')

    # Save
    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump({
            'total_matches': len(matches),
            'matches': matches,
            'community_vocabulary': sorted(set(community_maps.values())),
            'community_vocab_count': len(set(community_maps.values())),
        }, f, indent=2, ensure_ascii=False)

    print(f'\nSaved to {OUTPUT_PATH}')
    print(f'Community vocabulary: {len(set(community_maps.values()))} names available for future matching')


if __name__ == '__main__':
    main()
