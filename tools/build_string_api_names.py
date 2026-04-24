#!/usr/bin/env python3
"""Build method names from Unity API string references in IDA analysis.

For methods that call known Unity APIs (visible as string refs in ida_analysis.json),
derive meaningful names from the API calls they make.
"""
import json, sys, re, time
from pathlib import Path
from collections import Counter, defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
IDA_BASE = 0x180000000
DLL_BASE = 0x7ffaa7e70000
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')
HASH_RE = re.compile(r'^m_[0-9a-fA-F]{3}$')

t0 = time.time()

# Load all data
print('Loading data...')
with open(BASE_DIR / 'data' / 'ida_analysis.json', 'r', encoding='utf-8') as f:
    ida = json.load(f)
funcs = ida['functions']

with open(BASE_DIR / 'data' / 'precise_dump.json', 'r', encoding='utf-8') as f:
    raw = json.load(f)

with open(BASE_DIR / 'output' / 'name_mapping.json', 'r', encoding='utf-8') as f:
    name_map = json.load(f)

# Build reverse class mapping
deobf_to_obf = {}
for obf, deobf in name_map.get('classes', {}).items():
    deobf_to_obf[deobf] = obf

# Build obf_method → deobf_method mapping
method_rename = {}  # "obf_class::obf_method" → "deobf_name"
for key, val in name_map.get('methods', {}).items():
    method_rename[key] = val

# Build RVA → (obf_class, obf_method) from precise_dump
rva_to_method = {}
obf_class_ptrs = {}
for ns, classes in raw['namespaces'].items():
    for cls in classes:
        cn = cls['name']
        ptrs = cls.get('method_pointers', {})
        obf_class_ptrs[cn] = ptrs
        for mname, addr_str in ptrs.items():
            try:
                rva = int(addr_str, 16) - DLL_BASE
                rva_to_method[rva] = (cn, mname)
            except Exception:
                pass

print(f'  {len(rva_to_method):,} method pointers, {len(funcs):,} IDA functions')

# Parse Unity API signatures
UNITY_API_RE = re.compile(r'(UnityEngine(?:\.\w+)*)\.(\w+)::(\w+)\(')
VRC_API_RE = re.compile(r'(VRC\w*|Photon\w*|ExitGames\.\w+)\.(\w+)::(\w+)\(')

# Domain keywords for categorization
DOMAIN_KEYWORDS = {
    'Transform': 'Transform', 'Position': 'Position', 'Rotation': 'Rotation',
    'Scale': 'Scale', 'Quaternion': 'Rotation',
    'Renderer': 'Render', 'Material': 'Material', 'Shader': 'Shader',
    'Texture': 'Texture', 'RenderTexture': 'RenderTarget',
    'Camera': 'Camera', 'Light': 'Light',
    'Rigidbody': 'Physics', 'Collider': 'Collision', 'Physics': 'Physics',
    'Animator': 'Animation', 'Animation': 'Animation',
    'AudioSource': 'Audio', 'AudioClip': 'Audio',
    'Canvas': 'UI', 'RectTransform': 'UILayout', 'Text': 'Text',
    'Button': 'UIButton', 'Image': 'UIImage', 'Toggle': 'UIToggle',
    'InputField': 'UIInput', 'Slider': 'UISlider', 'Dropdown': 'UIDropdown',
    'Sprite': 'Sprite', 'Color': 'Color', 'Gradient': 'Gradient',
    'ParticleSystem': 'Particle', 'TrailRenderer': 'Trail',
    'NavMesh': 'Navigation', 'NavMeshAgent': 'Navigation',
    'NetworkManager': 'Network', 'Photon': 'Network',
    'XR': 'XR', 'InputTracking': 'XRTracking',
    'Component': 'Component', 'GameObject': 'GameObject',
    'Time': 'Time', 'Coroutine': 'Coroutine',
    'Ray': 'Raycast', 'RaycastHit': 'Raycast',
    'Bounds': 'Bounds', 'AABB': 'Bounds',
    'Mesh': 'Mesh', 'SkinnedMeshRenderer': 'SkinnedMesh',
    'LineRenderer': 'Line', 'MeshFilter': 'Mesh',
    'CanvasGroup': 'UIGroup', 'LayoutGroup': 'UILayout',
    'EventSystem': 'UIEvent', 'PointerEventData': 'Pointer',
    'Screen': 'Screen', 'Display': 'Display',
    'Application': 'App', 'Debug': 'Debug', 'PlayerPrefs': 'Prefs',
}

def derive_method_name(strings, cls_name=''):
    """Derive a method name from Unity API string references."""
    apis = []
    domains = Counter()
    actions = []

    for s in strings:
        # Parse Unity API calls
        m = UNITY_API_RE.search(s)
        if m:
            ns, cls, method = m.group(1), m.group(2), m.group(3)
            apis.append((cls, method))
            # Track domains
            for key, domain in DOMAIN_KEYWORDS.items():
                if key in cls or key in ns:
                    domains[domain] += 1
                    break
            # Track action verbs
            if method.startswith('set_'):
                actions.append(('set', method[4:]))
            elif method.startswith('get_'):
                actions.append(('get', method[4:]))
            elif not method.endswith('_Injected'):
                actions.append(('call', method))
            continue

        # Parse VRC/Photon API calls
        m = VRC_API_RE.search(s)
        if m:
            ns, cls, method = m.group(1), m.group(2), m.group(3)
            apis.append((cls, method))
            domains['VRC'] += 1

    if not apis:
        return None

    # Determine primary domain
    if domains:
        primary_domain = domains.most_common(1)[0][0]
    else:
        primary_domain = apis[0][0]

    # Determine primary action
    sets = [prop for act, prop in actions if act == 'set']
    gets = [prop for act, prop in actions if act == 'get']
    calls = [method for act, method in actions if act == 'call']

    # Name generation
    if len(sets) > len(gets) and len(sets) > len(calls):
        # Primarily setting properties
        main_prop = max(set(sets), key=sets.count)
        # Clean up _Injected suffix artifacts
        main_prop = re.sub(r'_Injected$', '', main_prop)
        if len(sets) > 2:
            return f'Configure{primary_domain}'
        return f'Set{main_prop}'

    elif calls:
        main_call = max(set(calls), key=calls.count)
        main_call = re.sub(r'_Injected$', '', main_call)
        if main_call in ('Destroy', 'Release', 'Dispose'):
            return f'{main_call}{primary_domain}'
        elif main_call in ('Instantiate', 'Create'):
            return f'{main_call}{primary_domain}'
        elif main_call.startswith('Get') or main_call.startswith('Find'):
            return main_call
        elif len(calls) > 2:
            return f'Process{primary_domain}'
        return main_call

    elif gets:
        main_prop = max(set(gets), key=gets.count)
        main_prop = re.sub(r'_Injected$', '', main_prop)
        if len(gets) > 2:
            return f'Read{primary_domain}Properties'
        return f'Get{main_prop}'

    else:
        # Only _Injected methods (transform operations etc.)
        if 'Transform' in primary_domain or 'Position' in primary_domain or 'Rotation' in primary_domain:
            injected_ops = [cls for cls, method in apis if 'Injected' in method]
            if any('Rotation' in m for _, m in apis) and any('Position' in m for _, m in apis):
                return f'UpdateTransformPose'
            elif any('Rotation' in m for _, m in apis):
                return f'UpdateRotation'
            elif any('Position' in m for _, m in apis):
                return f'UpdatePosition'
            return f'UpdateTransform'
        return f'Process{primary_domain}'


# Process all hash methods
print('\nProcessing hash methods...')
predictions = {}
no_rva = 0
no_ida = 0
no_strings = 0
no_good_strings = 0
named = 0

for ns, classes in raw['namespaces'].items():
    for cls in classes:
        obf_cn = cls['name']
        ptrs = cls.get('method_pointers', {})

        for mname, addr_str in ptrs.items():
            if not OBF_RE.match(mname):
                continue

            # Check if this method is still hash-named after deobfuscation
            key = f'{obf_cn}::{mname}'
            deobf_name = method_rename.get(key, mname)
            if not HASH_RE.match(deobf_name):
                continue  # Already has a semantic name

            # Get deobfuscated class name
            deobf_cn = name_map.get('classes', {}).get(obf_cn, obf_cn)

            # Find IDA function
            try:
                rva = int(addr_str, 16) - DLL_BASE
            except Exception:
                no_rva += 1
                continue

            ida_addr = hex(rva + IDA_BASE)
            if ida_addr not in funcs:
                no_ida += 1
                continue

            strings = funcs[ida_addr].get('strings', [])
            if not strings:
                no_strings += 1
                continue

            # Try to derive name
            predicted = derive_method_name(strings, deobf_cn)
            if predicted and len(predicted) > 3 and len(predicted) < 50:
                # Use original obf names as keys (matches pipeline deep_key format)
                predictions[f'{obf_cn}::{mname}'] = predicted
                named += 1
            else:
                no_good_strings += 1

print(f'  Named: {named:,}')
print(f'  No RVA: {no_rva:,}, No IDA: {no_ida:,}, No strings: {no_strings:,}')
print(f'  No good strings: {no_good_strings:,}')

# Quality filter - remove too-frequent names
freq = Counter(predictions.values())
generic = {n for n, c in freq.items() if c > 80}
if generic:
    before = len(predictions)
    predictions = {k: v for k, v in predictions.items() if v not in generic}
    print(f'  Removed {before - len(predictions)} too-generic names ({len(generic)} patterns)')

print(f'\nFinal: {len(predictions):,} string-API method names')

# Save
out_path = BASE_DIR / 'output' / 'string_api_method_names.json'
with open(out_path, 'w', encoding='utf-8') as f:
    json.dump(predictions, f, indent=1, ensure_ascii=False)

print(f'Saved to {out_path}')

# Stats
print(f'\nTop 20 predicted names:')
for n, c in freq.most_common(20):
    print(f'  {n}: {c}')

print(f'\nSample predictions:')
for i, (k, v) in enumerate(list(predictions.items())[:20]):
    print(f'  {k} → {v}')

print(f'\nTotal time: {time.time()-t0:.1f}s')
