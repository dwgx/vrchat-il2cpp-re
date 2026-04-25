#!/usr/bin/env python3
"""
VRChat IL2CPP Beebyte Deobfuscation Script
-------------------------------------------
7-phase maximum-readability deobfuscation for ÌÍÎÏ-obfuscated names.

Input:  il2cpp_full_dump/precise_dump.json
Output: il2cpp_full_dump/deobfuscated_dump.json
        il2cpp_full_dump/deobfuscated_dump.cs
        il2cpp_full_dump/name_mapping.json
        il2cpp_full_dump/deobfuscation_report.md
"""

import json, re, hashlib, collections, sys, os, copy
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

# ── Constants ──────────────────────────────────────────────────────────

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')
CAMEL_SPLIT = re.compile(r'(?<=[a-z])(?=[A-Z])|(?<=[A-Z])(?=[A-Z][a-z])|(?<=\d)(?=[A-Za-z])|(?<=[A-Za-z])(?=\d)')

# Standard methods that don't contribute to naming
STANDARD_METHODS = frozenset({
    '.ctor', '.cctor', 'Finalize', 'ToString', 'GetHashCode', 'Equals',
    'GetType', 'MemberwiseClone', 'Dispose',
    'System.IDisposable.Dispose',
})

# Unity lifecycle methods (useful for classification, not naming)
LIFECYCLE = frozenset({
    'Awake', 'Start', 'Update', 'FixedUpdate', 'LateUpdate',
    'OnEnable', 'OnDisable', 'OnDestroy', 'Reset',
    'OnApplicationPause', 'OnApplicationQuit', 'OnApplicationFocus',
    'OnBecameVisible', 'OnBecameInvisible',
    'OnValidate', 'OnDrawGizmos', 'OnDrawGizmosSelected',
    'OnGUI', 'OnAnimatorIK', 'OnAnimatorMove',
    'OnWillRenderObject', 'OnPreRender', 'OnPostRender',
    'OnRenderObject', 'OnRenderImage',
})

# Common generic words to deprioritize in naming
NOISE_WORDS = frozenset({
    'get', 'set', 'on', 'is', 'has', 'can', 'do', 'the', 'a', 'an',
    'this', 'that', 'new', 'add', 'remove', 'init', 'internal',
    'current', 'value', 'type', 'item', 'index', 'count',
    'system', 'generic', 'collections', 'void', 'bool', 'int',
    'string', 'object', 'float', 'double', 'byte',
})

# VRChat domain keyword → category mapping (scored)
DOMAIN_CATEGORIES = {
    'Avatar':    (['avatar', 'emote', 'gesture', 'pedestal', 'clothing', 'outfit', 'wearable', 'cosmetic', 'calibrat'], 10),
    'Network':   (['rpc', 'sync', 'network', 'photon', 'serialize', 'replicate', 'remote', 'reliable', 'unreliable', 'buffered'], 10),
    'UI':        (['button', 'panel', 'menu', 'screen', 'canvas', 'scroll', 'toggle', 'slider', 'tooltip', 'popup', 'modal', 'dialog', 'tab', 'page', 'list', 'label', 'badge', 'notification'], 8),
    'Pointer':   (['pointer', 'click', 'drag', 'drop', 'hover', 'press', 'release', 'focus', 'submit'], 8),
    'Player':    (['player', 'user', 'locomotion', 'movement', 'controller', 'input', 'vr', 'tracking', 'hand', 'head', 'ik'], 9),
    'World':     (['world', 'room', 'instance', 'portal', 'scene', 'spawn', 'teleport', 'mirror', 'station'], 9),
    'Audio':     (['audio', 'voice', 'sound', 'music', 'volume', 'speaker', 'microphone', 'lip', 'lipsync', 'oculus'], 8),
    'Video':     (['video', 'stream', 'media', 'avpro', 'movie', 'capture'], 8),
    'Camera':    (['camera', 'photo', 'screenshot', 'lens', 'render', 'capture', 'viewfinder'], 8),
    'Physics':   (['collider', 'collision', 'trigger', 'rigidbody', 'physics', 'force', 'joint', 'raycast'], 7),
    'Animation': (['anim', 'animator', 'motion', 'blend', 'layer', 'state', 'transition', 'clip', 'curve', 'keyframe'], 7),
    'Security':  (['safety', 'trust', 'ban', 'block', 'report', 'moderate', 'rank'], 9),
    'Social':    (['friend', 'group', 'invite', 'status', 'presence', 'notification', 'favorite'], 8),
    'Udon':      (['udon', 'behaviour', 'program', 'variable', 'event', 'graph', 'node'], 9),
    'Effect':    (['effect', 'particle', 'vfx', 'fx', 'shader', 'material', 'glow', 'trail'], 7),
    'Data':      (['config', 'setting', 'preference', 'cache', 'store', 'database', 'persist', 'save', 'load', 'json', 'xml', 'csv'], 6),
    'Texture':   (['texture', 'sprite', 'image', 'icon', 'thumbnail', 'resolution', 'mipmap'], 6),
    'PhysBone':  (['physbone', 'bone', 'chain', 'spring', 'dynamic', 'sway', 'jiggle', 'wiggle', 'collider'], 8),
}

# Method name → specific semantic inference
METHOD_SEMANTICS = {
    'PlayEmoteRPC':              ('AvatarEmoteController', 15),
    'ReloadAvatarNetworkedRPC':  ('AvatarReloadController', 15),
    'OnNetworkReady':            ('NetworkReadyHandler', 12),
    'NeedsSync':                 ('NetworkSyncable', 12),
    'Encode':                    ('Encoder', 8),
    'Decode':                    ('Decoder', 8),
    'OnPointerEnter':            ('PointerHandler', 8),
    'OnPointerExit':             ('PointerHandler', 8),
    'OnPointerClick':            ('Clickable', 9),
    'OnPointerDown':             ('Pressable', 8),
    'OnPointerUp':               ('Pressable', 8),
    'OnDrag':                    ('Draggable', 9),
    'OnBeginDrag':               ('Draggable', 9),
    'OnEndDrag':                 ('Draggable', 9),
    'OnDrop':                    ('DropTarget', 9),
    'OnScroll':                  ('Scrollable', 8),
    'OnSelect':                  ('Selectable', 8),
    'OnSubmit':                  ('Submittable', 8),
    'OnCanvasHierarchyChanged':  ('CanvasHierarchyWatcher', 7),
    'OnRectTransformDimensionsChange': ('RectTransformWatcher', 7),
    'OnTransformParentChanged':  ('TransformParentWatcher', 7),
    'CanSerialize32Bit':         ('NetworkSerializer', 10),
    'OnPhotonSerializeView':     ('PhotonSerializable', 12),
    'OnJoinedRoom':              ('PhotonRoomHandler', 11),
    'OnLeftRoom':                ('PhotonRoomHandler', 11),
    'OnPlayerEnteredRoom':       ('PhotonPlayerHandler', 11),
    'OnPlayerLeftRoom':          ('PhotonPlayerHandler', 11),
    'OnMasterClientSwitched':    ('PhotonMasterHandler', 11),
    'OnConnectedToMaster':       ('PhotonConnectionHandler', 11),
}


# ── Helpers ────────────────────────────────────────────────────────────

def is_obf(name: str) -> bool:
    return bool(name and OBF_RE.match(name))

def stable_hash(name: str, length: int = 4) -> str:
    return hashlib.sha256(name.encode('utf-8')).hexdigest()[:length].upper()

def camel_to_words(name: str) -> list[str]:
    """Split CamelCase/snake_case into lowercase words."""
    # Handle interface prefix stripping like System.Collections.Generic.IEnumerator<...>.get_Current
    if '.' in name:
        name = name.rsplit('.', 1)[-1]
    # Remove generic type params
    name = re.sub(r'<.*?>', '', name)
    name = re.sub(r'`\d+', '', name)
    # Split
    parts = CAMEL_SPLIT.split(name)
    words = []
    for p in parts:
        words.extend(p.split('_'))
    return [w.lower() for w in words if w and len(w) > 1]

def extract_property_name(method_name: str) -> str | None:
    """Extract property name from get_X / set_X."""
    if method_name.startswith(('get_', 'set_')) and '_' in method_name:
        prop = method_name.split('_', 1)[1]
        if not is_obf(prop):
            return prop
    return None

def score_domain_category(words: list[str]) -> tuple[str | None, int]:
    """Score words against VRChat domain categories."""
    scores = {}
    for cat, (keywords, weight) in DOMAIN_CATEGORIES.items():
        score = 0
        for w in words:
            for kw in keywords:
                if kw in w or w in kw:
                    score += weight
        if score > 0:
            scores[cat] = score
    if scores:
        best = max(scores, key=scores.get)
        return best, scores[best]
    return None, 0

def best_method_semantic(methods: list[str]) -> tuple[str | None, int]:
    """Find best semantic name from known method patterns."""
    best_name = None
    best_score = 0
    for m in methods:
        if m in METHOD_SEMANTICS:
            name, score = METHOD_SEMANTICS[m]
            if score > best_score:
                best_name = name
                best_score = score
    return best_name, best_score

def extract_interesting_words(cls_data: dict) -> list[str]:
    """Extract all meaningful words from a class's readable names."""
    words = []
    methods = [m for m in cls_data.get('methods', []) if isinstance(m, str)]
    fields = [f for f in cls_data.get('fields', []) if isinstance(f, str)]

    for m in methods:
        if is_obf(m) or m in STANDARD_METHODS or m in LIFECYCLE:
            continue
        # Property names are high-value
        prop = extract_property_name(m)
        if prop:
            words.extend(camel_to_words(prop) * 2)  # double weight
        else:
            words.extend(camel_to_words(m))

    for f in fields:
        if is_obf(f):
            continue
        words.extend(camel_to_words(f))

    # Filter noise
    words = [w for w in words if w not in NOISE_WORDS and len(w) > 1]
    return words


_DOTNET_NOISE_METHODS = frozenset({
    'Equals', 'CompareTo', 'Compare', 'GetEnumerator', 'Clone',
    'CopyTo', 'Contains', 'IndexOf', 'Insert', 'RemoveAt',
    'DisposeAsync', 'ConfigureAwait', 'GetAwaiter', 'GetResult',
})

def pick_best_label(cls_data: dict, max_parts: int = 2) -> str | None:
    """Pick a human-readable label from a class's most distinctive whole names.
    Prefers complete property/method names over word-soup combinations."""
    methods = [m for m in cls_data.get('methods', []) if isinstance(m, str)]
    fields = [f for f in cls_data.get('fields', []) if isinstance(f, str)]

    # Collect candidate labels with scores
    candidates: list[tuple[str, int]] = []

    for m in methods:
        if is_obf(m) or m in STANDARD_METHODS or m in LIFECYCLE:
            continue
        # Skip interface implementation methods (contain dots)
        if '.' in m:
            continue
        # Skip common .NET noise methods
        if m in _DOTNET_NOISE_METHODS:
            continue

        prop = extract_property_name(m)
        if prop and not is_obf(prop):
            # Property names are the best class name source
            candidates.append((prop, len(prop) * 3))
        elif m.startswith('On') and len(m) > 4:
            # Event handlers: strip "On" prefix
            candidates.append((m[2:], len(m) * 2))
        elif not m.startswith(('get_', 'set_', 'add_', 'remove_')):
            candidates.append((m, len(m) * 2))

    for f in fields:
        if is_obf(f):
            continue
        # Skip interface-qualified fields
        if '.' in f:
            continue
        if len(f) > 2:
            candidates.append((f, len(f)))

    if not candidates:
        return None

    # Sort by score (prefer longer, more specific names)
    candidates.sort(key=lambda x: -x[1])

    # Take top 1-2 most distinctive names
    parts = []
    for name, score in candidates[:max_parts]:
        # Clean: remove generic type noise
        name = re.sub(r'<.*?>', '', name)
        name = re.sub(r'`\d+', '', name)
        name = name.strip('_')
        # Cap individual part length
        if len(name) > 25:
            name = name[:25]
        if name and name not in parts:
            parts.append(name)

    result = ''.join(parts) if parts else None
    # Cap total length
    if result and len(result) > 40:
        result = result[:40]
    return result

def most_descriptive_name(words: list[str], max_parts: int = 3) -> str | None:
    """Pick the most descriptive name from word frequency.
    Prefers longer, more specific words. Deduplicates substrings."""
    if not words:
        return None
    freq = collections.Counter(words)
    # Score: frequency * word_length^1.5 (heavily prefer longer/specific words)
    scored = [(w, count * (len(w) ** 1.5)) for w, count in freq.items()]
    scored.sort(key=lambda x: -x[1])

    # Deduplicate: remove words that are substrings of higher-scored words
    selected = []
    for w, _ in scored:
        if len(selected) >= max_parts:
            break
        cap = w.capitalize()
        # Skip if this word is a substring of an already-selected word
        if any(w in sel.lower() for sel in selected):
            continue
        # Skip if an already-selected word is a substring of this one
        # (keep the longer one by replacing)
        replaced = False
        for i, sel in enumerate(selected):
            if sel.lower() in w:
                selected[i] = cap
                replaced = True
                break
        if not replaced:
            selected.append(cap)

    if selected:
        return ''.join(selected)
    return None


# ── Main Deobfuscator ─────────────────────────────────────────────────

class Deobfuscator:
    def __init__(self, dump_path: str):
        print(f'Loading {dump_path}...')
        with open(dump_path, 'r', encoding='utf-8') as f:
            self.data = json.load(f)

        self.class_map: dict[str, str] = {}       # obf_name -> new_name
        self.method_map: dict[str, str] = {}       # obf_method_name -> new_name (context-free)
        self.class_method_map: dict[tuple[str,str], str] = {}  # (class, method) -> new_name
        self.field_map: dict[str, str] = {}        # obf_field_name -> new_name
        self.class_field_map: dict[tuple[str,str], str] = {}   # (class, field) -> new_name
        self.used_names: set[str] = set()
        self.stats: dict[str, int] = collections.Counter()

        # Build class index: name -> (namespace, class_data)
        self.class_index: dict[str, tuple[str, dict]] = {}
        # Track children for each parent
        self.children: dict[str, list[str]] = collections.defaultdict(list)
        # Property names per class
        self.class_properties: dict[str, list[str]] = {}

        for ns, classes in self.data['namespaces'].items():
            for cls in classes:
                name = cls['name']
                # Handle duplicate names by using first occurrence
                if name not in self.class_index:
                    self.class_index[name] = (ns, cls)
                parent = cls.get('parent', '')
                if parent:
                    self.children[parent].append(name)

                # Cache properties
                methods = [m for m in cls.get('methods', []) if isinstance(m, str)]
                props = []
                for m in methods:
                    p = extract_property_name(m)
                    if p:
                        props.append(p)
                if props:
                    self.class_properties[name] = list(set(props))

        self._lifted_vocab = self._load_lifted_vocab()
        self._lifted_class_names = self._lifted_vocab.get('class_name_map', {})
        self._lifted_method_names = self._lifted_vocab.get('method_name_map', {})
        self._lifted_field_names = self._lifted_vocab.get('field_name_map', {})

        total_obf = sum(1 for n in self.class_index if is_obf(n))
        print(f'Indexed {len(self.class_index)} classes, {total_obf} obfuscated')

    def _load_lifted_vocab(self) -> dict:
        base_dir = Path(__file__).resolve().parent.parent
        path = base_dir / 'data' / 'apr25_lifted_vocab.json'
        if not path.exists():
            try:
                from lift_apr18_to_apr25_vocab import build_lifted_vocab
                data, _, _, _ = build_lifted_vocab()
                print(f'  Built lifted Apr25 vocab in-memory '
                      f'({len(data.get("class_name_map", {}))} classes, '
                      f'{len(data.get("method_name_map", {}))} methods, '
                      f'{len(data.get("field_name_map", {}))} fields)')
                return data
            except Exception as e:
                print(f'  Failed to build apr25 lifted vocab in-memory: {e}')
                return {}
        try:
            with open(path, 'r', encoding='utf-8') as f:
                data = json.load(f)
            if isinstance(data, dict):
                print(f'  Using apr25_lifted_vocab.json '
                      f'({len(data.get("class_name_map", {}))} classes, '
                      f'{len(data.get("method_name_map", {}))} methods, '
                      f'{len(data.get("field_name_map", {}))} fields)')
                return data
        except Exception as e:
            print(f'  Failed to load apr25_lifted_vocab.json: {e}')
        return {}

    def unique_name(self, base: str, obf_name: str) -> str:
        """Generate unique name with stable hash suffix."""
        h = stable_hash(obf_name)
        # Clean base name
        base = re.sub(r'[^A-Za-z0-9_]', '', base)
        if not base:
            base = 'Obf'
        candidate = f'{base}_{h}'
        if candidate not in self.used_names:
            self.used_names.add(candidate)
            return candidate
        # Extend hash on collision
        for extra in range(100):
            candidate = f'{base}_{h}{extra}'
            if candidate not in self.used_names:
                self.used_names.add(candidate)
                return candidate
        return candidate

    # ── Phase 1: Compiler Artifacts ────────────────────────────────────

    def phase1_compiler_artifacts(self):
        print('\n=== Phase 1: Compiler Artifacts ===')

        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            methods = set(m for m in cls.get('methods', []) if isinstance(m, str))
            fields = [f for f in cls.get('fields', []) if isinstance(f, str)]
            parent = cls.get('parent', '')

            # Async state machine
            if 'MoveNext' in methods and 'SetStateMachine' in methods:
                self.class_map[name] = self.unique_name('AsyncStateMachine', name)
                self.stats['phase1_async'] += 1
                continue

            # Enumerator (IEnumerator implementation)
            if any('IEnumerator' in f for f in fields):
                # Try to extract the element type
                for f in fields:
                    m = re.search(r'IEnumerator<(.+?)>', f)
                    if m:
                        elem_type = m.group(1).rsplit('.', 1)[-1]
                        if not is_obf(elem_type) and elem_type != 'Object':
                            self.class_map[name] = self.unique_name(f'{elem_type}Enumerator', name)
                            break
                if name not in self.class_map:
                    self.class_map[name] = self.unique_name('Enumerator', name)
                self.stats['phase1_enumerator'] += 1
                continue

            # Delegate
            if parent == 'MulticastDelegate':
                self.class_map[name] = self.unique_name('Delegate', name)
                self.stats['phase1_delegate'] += 1
                continue

            # Compiler display class (closures)
            if '<>c' in name or '$' in name:
                self.class_map[name] = self.unique_name('DisplayClass', name)
                self.stats['phase1_displayclass'] += 1
                continue

        total = sum(v for k, v in self.stats.items() if k.startswith('phase1'))
        print(f'  Classified {total} classes')
        for k, v in sorted(self.stats.items()):
            if k.startswith('phase1'):
                print(f'    {k}: {v}')

    def phase0_lifted_names(self):
        print('\n=== Phase 0: Direct Lifted Names ===')
        applied = 0
        for obf_name, semantic_name in self._lifted_class_names.items():
            if not is_obf(obf_name) or is_obf(semantic_name):
                continue
            if obf_name not in self.class_index or obf_name in self.class_map:
                continue
            self.class_map[obf_name] = self.unique_name(semantic_name, obf_name)
            applied += 1
        self.stats['phase0_lifted'] = applied
        print(f'  Applied {applied} lifted class names')

    # ── Phase 2: Semantic Method Analysis ──────────────────────────────

    def phase2_semantic_methods(self):
        print('\n=== Phase 2: Semantic Method Analysis ===')

        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            methods = [m for m in cls.get('methods', []) if isinstance(m, str)]
            readable = [m for m in methods if not is_obf(m) and m not in STANDARD_METHODS]
            parent = cls.get('parent', '')

            if not readable:
                continue

            # 1. Try known method semantics (highest confidence)
            sem_name, sem_score = best_method_semantic(readable)
            if sem_name and sem_score >= 10:
                self.class_map[name] = self.unique_name(sem_name, name)
                self.stats['phase2_known_method'] += 1
                continue

            # 2. Try pick_best_label (whole names, not word-soup)
            label = pick_best_label(cls, max_parts=2)
            if not label:
                # Fallback to word extraction
                words = extract_interesting_words(cls)
                if not words:
                    continue
                label = most_descriptive_name(words, max_parts=2)
                if not label:
                    continue

            # 3. Domain category scoring
            words_for_domain = extract_interesting_words(cls)
            domain, domain_score = score_domain_category(words_for_domain)

            # 4. Combine domain + label
            if domain and domain_score >= 8 and domain.lower() not in label.lower():
                final_name = f'{domain}{label}'
            else:
                final_name = label

            # Add parent context for MonoBehaviour
            if parent == 'MonoBehaviour' and not final_name.endswith(('Component', 'Behaviour', 'Handler', 'Controller', 'Manager')):
                # Decide suffix based on method patterns
                if any(m.startswith('On') and m not in LIFECYCLE for m in readable):
                    final_name += 'Handler'
                elif LIFECYCLE.intersection(set(readable)):
                    final_name += 'Component'

            self.class_map[name] = self.unique_name(final_name, name)
            self.stats['phase2_semantic'] += 1

        print(f'  Classified {self.stats.get("phase2_known_method", 0)} by known methods')
        print(f'  Classified {self.stats.get("phase2_semantic", 0)} by semantic analysis')

    # ── Phase 3: Property-Driven Naming ────────────────────────────────

    def phase3_property_driven(self):
        print('\n=== Phase 3: Property-Driven Naming ===')

        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue

            props = self.class_properties.get(name, [])
            if not props:
                continue

            # Use property names to build a semantic name
            prop_words = []
            for p in props:
                prop_words.extend(camel_to_words(p))

            prop_words = [w for w in prop_words if w not in NOISE_WORDS and len(w) > 1]
            if not prop_words:
                continue

            desc = most_descriptive_name(prop_words, max_parts=3)
            if desc:
                # Determine if it's a data class or interface
                ns, cls = self.class_index[name]
                parent = cls.get('parent', '')
                methods = [m for m in cls.get('methods', []) if isinstance(m, str)]

                # Pure data class (mostly properties, few other methods)
                non_prop_methods = [m for m in methods if not is_obf(m)
                                    and m not in STANDARD_METHODS
                                    and not m.startswith(('get_', 'set_'))]
                if len(non_prop_methods) <= 2:
                    suffix = 'Data'
                elif parent == 'MonoBehaviour':
                    suffix = 'Component'
                else:
                    suffix = 'Info'

                self.class_map[name] = self.unique_name(f'{desc}{suffix}', name)
                self.stats['phase3_property'] += 1

        print(f'  Classified {self.stats.get("phase3_property", 0)} classes by properties')

    # ── Phase 4: Unity Component Classification ────────────────────────

    def phase4_unity_components(self):
        print('\n=== Phase 4: Unity Component Classification ===')

        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            parent = cls.get('parent', '')
            methods = set(m for m in cls.get('methods', []) if isinstance(m, str))
            method_count = len(cls.get('methods', []))

            # Must be a MonoBehaviour or similar
            is_mono = parent in ('MonoBehaviour', 'UIBehaviour', 'Graphic',
                                 'MaskableGraphic', 'Selectable', 'BaseMeshEffect',
                                 'NetworkBehaviour')
            if not is_mono:
                continue

            has_lifecycle = bool(LIFECYCLE.intersection(methods))
            if not has_lifecycle:
                continue

            # Classify by lifecycle pattern and method count
            has_update = 'Update' in methods
            has_fixed = 'FixedUpdate' in methods
            has_late = 'LateUpdate' in methods

            if method_count > 200:
                prefix = 'MajorSystem'
            elif method_count > 50:
                prefix = 'ComplexComponent'
            elif has_update and has_fixed:
                prefix = 'PhysicsComponent'
            elif has_update:
                prefix = 'UpdateComponent'
            elif has_late:
                prefix = 'LateUpdateComponent'
            elif has_fixed:
                prefix = 'FixedUpdateComponent'
            else:
                prefix = 'LifecycleComponent'

            # Try to add more context from parent
            if parent == 'NetworkBehaviour':
                prefix = 'Network' + prefix
            elif parent in ('UIBehaviour', 'Graphic', 'MaskableGraphic', 'Selectable'):
                prefix = 'UI' + prefix

            self.class_map[name] = self.unique_name(prefix, name)
            self.stats['phase4_unity'] += 1

        print(f'  Classified {self.stats.get("phase4_unity", 0)} Unity components')

    # ── Phase 5: Inheritance Chain Resolution ──────────────────────────

    def phase5_inheritance(self):
        print('\n=== Phase 5: Inheritance Chain Resolution ===')

        # Step 1: Name obfuscated base classes by analyzing their children
        obf_bases = {parent: children
                     for parent, children in self.children.items()
                     if is_obf(parent) and len(children) >= 3}

        for base_name, child_names in sorted(obf_bases.items(), key=lambda x: -len(x[1])):
            if base_name in self.class_map:
                # Already named - propagate to children
                base_readable = self.class_map[base_name]
            else:
                # Analyze children to infer base purpose
                all_child_words = []
                child_method_sets = []

                for cname in child_names:
                    if cname in self.class_index:
                        _, ccls = self.class_index[cname]
                        words = extract_interesting_words(ccls)
                        all_child_words.extend(words)

                        readable_m = [m for m in ccls.get('methods', [])
                                      if isinstance(m, str) and not is_obf(m) and m not in STANDARD_METHODS]
                        child_method_sets.append(set(readable_m))

                # Find common methods across children
                if child_method_sets:
                    common = child_method_sets[0]
                    for s in child_method_sets[1:]:
                        common = common.intersection(s)
                    # Add common method words with high weight
                    for m in common:
                        if m not in LIFECYCLE:
                            all_child_words.extend(camel_to_words(m) * 3)

                desc = most_descriptive_name(all_child_words, max_parts=2)
                child_count = len(child_names)

                if desc:
                    base_readable = self.unique_name(f'{desc}Base', base_name)
                else:
                    base_readable = self.unique_name(f'BaseClass{child_count}', base_name)

                if base_name not in self.class_map:
                    self.class_map[base_name] = base_readable
                    self.stats['phase5_base'] += 1

            # Step 2: Name unnamed children with base prefix
            base_prefix = re.sub(r'_[A-F0-9]+\d*$', '', base_readable)  # strip hash
            for cname in child_names:
                if is_obf(cname) and cname not in self.class_map:
                    # Try to differentiate children using best label
                    if cname in self.class_index:
                        _, ccls = self.class_index[cname]
                        child_label = pick_best_label(ccls, max_parts=2)
                        if not child_label:
                            child_words = extract_interesting_words(ccls)
                            child_label = most_descriptive_name(child_words, max_parts=2)
                        if child_label:
                            self.class_map[cname] = self.unique_name(f'{base_prefix}_{child_label}', cname)
                        else:
                            self.class_map[cname] = self.unique_name(f'{base_prefix}Impl', cname)
                    else:
                        self.class_map[cname] = self.unique_name(f'{base_prefix}Impl', cname)
                    self.stats['phase5_child'] += 1

        print(f'  Named {self.stats.get("phase5_base", 0)} base classes')
        print(f'  Named {self.stats.get("phase5_child", 0)} child classes')

    # ── Phase 6: Cross-Reference from Known Classes ────────────────────

    def phase6_cross_reference(self):
        print('\n=== Phase 6: Cross-Reference from Known Classes ===')

        # For known classes, check if their parent/field types are obfuscated
        # and try to use context to name them
        for name, (ns, cls) in self.class_index.items():
            if is_obf(name):
                continue
            parent = cls.get('parent', '')
            if is_obf(parent) and parent not in self.class_map:
                # Known class inherits from obfuscated base
                # Name the base after the known class
                self.class_map[parent] = self.unique_name(f'{name}Base', parent)
                self.stats['phase6_crossref_parent'] += 1

        # Check method signatures for obfuscated types in known classes
        # (limited since we only have method names, not signatures)

        # Check obfuscated classes that inherit from known non-trivial parents
        known_parents_seen = collections.Counter()
        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            parent = cls.get('parent', '')
            if parent and not is_obf(parent) and parent not in ('Object', 'ValueType', '', 'MonoBehaviour'):
                # Has meaningful known parent
                known_parents_seen[parent] += 1
                suffix_idx = known_parents_seen[parent]
                self.class_map[name] = self.unique_name(f'{parent}Derived', name)
                self.stats['phase6_known_parent'] += 1

        print(f'  Named {self.stats.get("phase6_crossref_parent", 0)} by cross-ref parent')
        print(f'  Named {self.stats.get("phase6_known_parent", 0)} by known parent derivation')

    # ── Phase 6b: Shared Method Inference ─────────────────────────────

    def phase6b_shared_methods(self):
        """Infer class names by analyzing obfuscated methods shared with known classes."""
        print('\n=== Phase 6b: Shared Method Inference ===')

        # Build index: obf_method_name -> list of (class_name, class_data)
        method_owners: dict[str, list[tuple[str, dict]]] = collections.defaultdict(list)
        for name, (ns, cls) in self.class_index.items():
            for m in cls.get('methods', []):
                if isinstance(m, str) and is_obf(m):
                    method_owners[m].append((name, cls))

        # For each unnamed obfuscated class, check if it shares methods with NAMED classes
        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            obf_methods = [m for m in cls.get('methods', []) if isinstance(m, str) and is_obf(m)]

            # Find sibling classes (share at least 3 obfuscated methods)
            sibling_scores: dict[str, int] = collections.Counter()
            for m in obf_methods:
                for owner_name, owner_cls in method_owners.get(m, []):
                    if owner_name != name:
                        sibling_scores[owner_name] += 1

            # Look for siblings that are already named (non-obf or already renamed)
            best_sibling = None
            best_shared = 0
            for sib_name, shared_count in sibling_scores.most_common(10):
                if shared_count < 3:
                    break
                # Check if sibling is named
                if not is_obf(sib_name):
                    if shared_count > best_shared:
                        best_sibling = sib_name
                        best_shared = shared_count
                elif sib_name in self.class_map:
                    resolved = self.class_map[sib_name]
                    # Only use if it's a semantic name (not a fallback)
                    if not resolved.startswith(('Obf_', 'Class_', 'Struct_', 'LargeClass_',
                                                 'DataClass_', 'EmptyClass_')):
                        if shared_count > best_shared:
                            best_sibling = resolved
                            best_shared = shared_count

            if best_sibling and best_shared >= 3:
                # Strip hash suffix from sibling name for prefix
                prefix = re.sub(r'_[A-F0-9]+\d*$', '', best_sibling)
                prefix = prefix[:30]  # cap length
                self.class_map[name] = self.unique_name(f'{prefix}Sibling', name)
                self.stats['phase6b_shared'] += 1

        # Also: name classes by METHOD FREQUENCY CLUSTERS
        # Methods appearing in 10-100 classes are likely domain-specific interfaces
        mid_freq_methods = {m: owners for m, owners in method_owners.items()
                           if 5 <= len(owners) <= 100}

        # Group unnamed classes by which mid-freq methods they implement
        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            obf_methods = set(m for m in cls.get('methods', []) if isinstance(m, str) and is_obf(m))

            # Find mid-freq methods this class implements
            implemented_groups = []
            for mfm, owners in mid_freq_methods.items():
                if mfm in obf_methods:
                    owner_names = [o[0] for o in owners]
                    # Check if any owner is named
                    for on in owner_names:
                        if not is_obf(on):
                            implemented_groups.append(on)
                            break
                        elif on in self.class_map:
                            resolved = self.class_map[on]
                            if not resolved.startswith(('Obf_', 'Class_', 'Struct_')):
                                implemented_groups.append(resolved)
                                break

            if implemented_groups:
                # Pick most common group
                group_freq = collections.Counter(implemented_groups)
                best_group, count = group_freq.most_common(1)[0]
                if count >= 2:
                    prefix = re.sub(r'_[A-F0-9]+\d*$', '', best_group)[:25]
                    self.class_map[name] = self.unique_name(f'{prefix}Related', name)
                    self.stats['phase6b_cluster'] += 1

        print(f'  Named {self.stats.get("phase6b_shared", 0)} by shared method siblings')
        print(f'  Named {self.stats.get("phase6b_cluster", 0)} by method frequency clusters')

    # ── Phase 6c: Binary String Reference Naming ─────────────────────

    def phase6c_binary_strings(self):
        """Use string references extracted from GameAssembly.dll to name opaque classes."""
        print('\n=== Phase 6c: Binary String Reference Naming ===')

        # Try deep_analysis.json first (richer data), fallback to method_string_refs.json
        base_dir = Path(__file__).resolve().parent.parent
        deep_path = base_dir / 'output' / 'deep_analysis.json'
        string_refs_path = base_dir / 'output' / 'method_string_refs.json'
        # Fallback to legacy paths
        if not deep_path.exists():
            deep_path = Path(__file__).parent / 'il2cpp_full_dump' / 'deep_analysis.json'
        if not string_refs_path.exists():
            string_refs_path = Path(__file__).parent / 'il2cpp_full_dump' / 'method_string_refs.json'

        if deep_path.exists():
            with open(deep_path, 'r', encoding='utf-8') as f:
                deep_data = json.load(f)
            refs_data = {'class_string_refs': deep_data.get('class_string_refs', {})}
            # Also load method semantic names for method renaming
            self._deep_method_names = deep_data.get('method_semantic_names', {})
            # Load call graph domains
            self._call_domains = deep_data.get('class_call_domains', {})
            print(f'  Using deep_analysis.json ({len(self._deep_method_names)} method names)')
        elif string_refs_path.exists():
            with open(string_refs_path, 'r', encoding='utf-8') as f:
                refs_data = json.load(f)
            self._deep_method_names = {}
            self._call_domains = {}
        else:
            print('  No binary analysis data found, skipping')
            return

        class_refs = refs_data.get('class_string_refs', {})
        print(f'  Loaded string refs for {len(class_refs)} classes')

        # Unity API → domain category mapping
        API_DOMAIN = {
            'Camera': 'Camera', 'Light': 'Lighting', 'RenderTexture': 'Rendering',
            'AudioSource': 'Audio', 'AudioClip': 'Audio', 'AudioListener': 'Audio',
            'Animator': 'Animation', 'Animation': 'Animation', 'AnimationClip': 'Animation',
            'Rigidbody': 'Physics', 'Collider': 'Physics', 'BoxCollider': 'Physics',
            'SphereCollider': 'Physics', 'CapsuleCollider': 'Physics', 'MeshCollider': 'Physics',
            'Joint': 'Physics', 'CharacterController': 'Physics',
            'Transform': 'Transform', 'RectTransform': 'UITransform',
            'Canvas': 'UI', 'CanvasGroup': 'UI', 'Image': 'UI', 'Text': 'UI',
            'Button': 'UI', 'Toggle': 'UI', 'Slider': 'UI', 'ScrollRect': 'UI',
            'ParticleSystem': 'Particle', 'TrailRenderer': 'Particle',
            'LineRenderer': 'LineRendering', 'MeshRenderer': 'MeshRendering',
            'SkinnedMeshRenderer': 'SkinnedMesh', 'MeshFilter': 'Mesh',
            'Shader': 'Shader', 'Material': 'Material',
            'Texture': 'Texture', 'Texture2D': 'Texture', 'Sprite': 'Sprite',
            'NavMesh': 'Navigation', 'NavMeshAgent': 'Navigation',
            'Terrain': 'Terrain', 'TerrainData': 'Terrain',
            'NetworkManager': 'Network', 'UnityWebRequest': 'WebRequest',
            'Networking': 'Network',
            'Profiling': 'Profiled', 'ProfilerUnsafeUtility': 'Profiled',
            'AsyncOperation': 'Async', 'AsyncGPUReadback': 'GPUReadback',
            'Input': 'Input', 'Cursor': 'Cursor',
            'Screen': 'Screen', 'Display': 'Display', 'Resolution': 'Display',
            'SystemInfo': 'SystemInfo', 'Application': 'Application',
            'PlayerPrefs': 'PlayerPrefs', 'QualitySettings': 'QualitySettings',
            'Physics2D': 'Physics2D', 'Gizmos': 'GizmosDebug',
            'Video': 'Video', 'VideoPlayer': 'Video',
            'Cloth': 'Cloth', 'VFX': 'VFX',
            'ONSP': 'SpatialAudio', 'Ambisonics': 'SpatialAudio',
        }

        for class_name, strings in class_refs.items():
            if not is_obf(class_name) or class_name in self.class_map:
                continue

            # Extract Unity API class names from the string references
            api_hits = collections.Counter()
            for s in strings:
                # Parse "UnityEngine.ClassName::Method()" format
                for api_key, domain in API_DOMAIN.items():
                    if api_key in s:
                        api_hits[domain] += 1

                # Also extract direct class names from method signatures
                m = re.search(r'UnityEngine\.(\w+)::', s)
                if m:
                    unity_class = m.group(1)
                    if unity_class in API_DOMAIN:
                        api_hits[API_DOMAIN[unity_class]] += 1
                    elif len(unity_class) > 3:
                        api_hits[unity_class] += 1

                # Check for VRC-specific strings
                if 'VRC' in s or 'Avatar' in s or 'Player' in s:
                    api_hits['VRC'] += 1

            if not api_hits:
                continue

            # Build name from top 2 API domains
            top_domains = [d for d, _ in api_hits.most_common(2)]
            name_parts = top_domains[:2]

            # Add method count context
            if class_name in self.class_index:
                _, cls = self.class_index[class_name]
                mc = len(cls.get('methods', []))
                parent = cls.get('parent', '')
                if parent == 'MonoBehaviour':
                    suffix = 'Component'
                elif parent == 'ValueType':
                    suffix = 'Struct'
                elif mc > 50:
                    suffix = 'System'
                else:
                    suffix = 'Handler'
            else:
                suffix = 'Handler'

            final_name = ''.join(name_parts) + suffix
            self.class_map[class_name] = self.unique_name(final_name, class_name)
            self.stats['phase6c_binary'] += 1

        # Also name classes by call graph domains
        for class_name, domains in self._call_domains.items():
            if not is_obf(class_name) or class_name in self.class_map:
                continue
            # Use the most-called known class as a domain hint
            domain_freq = collections.Counter(domains)
            top_domain, count = domain_freq.most_common(1)[0] if domain_freq else (None, 0)
            if top_domain and count >= 2:
                prefix = re.sub(r'_[A-F0-9]+\d*$', '', top_domain)[:25]
                if is_obf(prefix):
                    prefix = self.class_map.get(prefix, prefix)
                    prefix = re.sub(r'_[A-F0-9]+\d*$', '', prefix)[:25]
                if not is_obf(prefix):
                    self.class_map[class_name] = self.unique_name(f'{prefix}Caller', class_name)
                    self.stats['phase6c_callgraph'] += 1

        print(f'  Named {self.stats.get("phase6c_binary", 0)} classes by binary string refs')
        print(f'  Named {self.stats.get("phase6c_callgraph", 0)} classes by call graph')

    # ── Phase 6d: Community Confirmed Names ───────────────────────────

    def phase6d_community_names(self):
        """Apply community-confirmed VRChat class names via structural rules."""
        print('\n=== Phase 6d: Community Confirmed Names ===')

        RULES = [
            ('VRCPlayer', lambda m, f, p: 'ReloadAvatarNetworkedRPC' in m and 'PlayEmoteRPC' in m, 99),
            ('VRC_Main', lambda m, f, p: p == 'MonoBehaviour' and len(m) > 900, 95),
            ('VRCUiManager', lambda m, f, p: 'UIManager' in p, 95),
            ('NetworkManager', lambda m, f, p: 'OnNetworkReady' in m and len(m) > 200 and p == 'MonoBehaviour', 90),
            ('VRC_Secondary', lambda m, f, p: p == 'MonoBehaviour' and 450 < len(m) < 550, 85),
            ('FlatBufferNetworkSerializer', lambda m, f, p: 'NeedsSync' in m and 'UpdatePuppetChannelTypes' in m, 90),
            ('VRCNetworkBehaviour', lambda m, f, p: {'NeedsSync','Decode','Encode','OnNetworkReady'}.issubset(m) and len(m) < 50, 90),
            ('VRCNetworkBehaviourBase', lambda m, f, p: 'NeedsSync' in m and 'CanSerialize32Bit' in m and len(m) < 40, 85),
            ('PlayerNet', lambda m, f, p: 'NeedsSync' in m and 'Decode' in m and 'get_TypeId' in m and 100 < len(m) < 200, 85),
            ('VRCFlowNetworkManager', lambda m, f, p: 'OnJoinedRoom' in m and 'OnLeftRoom' in m and 'OnPlayerEnteredRoom' in m, 95),
            ('PlayerModComponentHealth', lambda m, f, p: 'ResetHealthRPC' in m, 85),
            ('VRCFlowManager', lambda m, f, p: 'GoHome' in m, 80),
            ('VRC_MirrorReflection', lambda m, f, p: 'GetReflectionData' in m, 85),
            ('IKSolverVR', lambda m, f, p: 'VrcLateSolve' in m, 90),
            ('IKSolverVR_Arm', lambda m, f, p: 'VrcAvoidElbowClipping' in m, 90),
            ('IKSolverVR_Spine', lambda m, f, p: 'SolvePelvis' in m and 'Solve' in m, 85),
            ('ObjectInstantiator', lambda m, f, p: '_InstantiateObject' in m, 80),
            ('RoomManager', lambda m, f, p: 'OnPlayerJoined' in m and p == 'MonoBehaviour', 75),
            ('VRCMotionState', lambda m, f, p: p == 'MonoBehaviour' and {'FixedUpdate','Update','LateUpdate'}.issubset(m) and 50 < len(m) < 100, 50),
            ('VFXBundleInfo', lambda m, f, p: 'get_EffectBundleID' in m, 80),
            ('ServerTimeManager', lambda m, f, p: 'get_ServerTimeUtc' in m, 80),
            ('LightManager', lambda m, f, p: 'get_LightReservedLayerMask' in m, 75),
            ('AnimatedTexture', lambda m, f, p: 'get_DisplayTexture' in m and 'get_FullResolutionTexture' in m, 80),
            ('InputControlBinding', lambda m, f, p: 'get_controlPathInternal' in m, 75),
            ('AsyncResult', lambda m, f, p: 'get_CompletedSynchronously' in m and 'get_AsyncWaitHandle' in m, 75),
            ('VRC_Interactable', lambda m, f, p: 'get_IsInteractive' in m and 'VRC_Interactable' in p, 80),
        ]

        used_names = set()
        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            methods_set = set(m for m in cls.get('methods', []) if isinstance(m, str))
            fields_list = [f for f in cls.get('fields', []) if isinstance(f, str)]
            parent = cls.get('parent', '')

            for real_name, check_fn, conf in RULES:
                if real_name in used_names:
                    continue
                try:
                    if check_fn(methods_set, fields_list, parent):
                        self.class_map[name] = real_name
                        used_names.add(real_name)
                        self.stats['phase6d_community'] += 1
                        break
                except:
                    pass

        print(f'  Named {self.stats.get("phase6d_community", 0)} classes with confirmed VRChat names')

    # ── Phase 7: Fallback Hashing ──────────────────────────────────────

    def phase7_fallback(self):
        print('\n=== Phase 7: Fallback Hashing ===')

        for name in list(self.class_index.keys()):
            if not is_obf(name) or name in self.class_map:
                continue
            ns, cls = self.class_index[name]
            parent = cls.get('parent', '')
            methods = cls.get('methods', [])
            fields = cls.get('fields', [])
            method_count = len(methods)
            field_count = len(fields)

            # Count obfuscated vs total
            obf_m = sum(1 for m in methods if isinstance(m, str) and is_obf(m))
            obf_f = sum(1 for f in fields if isinstance(f, str) and is_obf(f))

            # Structural classification by parent + size + shape
            if parent == 'ValueType':
                if field_count == 0:
                    prefix = 'EmptyStruct'
                elif field_count <= 4:
                    prefix = f'Struct{field_count}f'
                else:
                    prefix = f'Struct{field_count}f'
            elif parent == 'Enum':
                prefix = 'Enum'
            elif parent == 'Object' or not parent:
                if method_count == 0 and field_count == 0:
                    prefix = 'EmptyType'
                elif method_count == 0:
                    prefix = f'DataOnly{field_count}f'
                elif field_count == 0:
                    prefix = f'Static{method_count}m'
                elif method_count > 100:
                    prefix = f'Major{method_count}m'
                elif method_count > 20:
                    prefix = f'Service{method_count}m'
                elif field_count > method_count * 2:
                    prefix = f'Record{field_count}f'
                else:
                    prefix = f'Type{method_count}m{field_count}f'
            elif parent == 'MonoBehaviour':
                prefix = f'Mono{method_count}m'
            else:
                # Parent is also obfuscated - use its resolved name
                parent_name = self.class_map.get(parent, parent)
                parent_short = re.sub(r'_[A-F0-9]+\d*$', '', parent_name)[:20]
                if not is_obf(parent_short):
                    prefix = f'{parent_short}Impl'
                else:
                    prefix = f'Unknown{method_count}m'

            self.class_map[name] = self.unique_name(prefix, name)
            self.stats['phase7_fallback'] += 1

        print(f'  Fallback-named {self.stats.get("phase7_fallback", 0)} classes')

    # ── Method & Field Renaming ────────────────────────────────────────

    # Type-to-field-name mapping for runtime type inference
    PRIMITIVE_FIELD_NAMES = {
        'bool': '_flag', 'int': '_value', 'float': '_amount', 'double': '_amount',
        'string': '_text', 'byte': '_data', 'short': '_index', 'long': '_id',
        'uint': '_count', 'ulong': '_handle', 'ushort': '_code', 'sbyte': '_raw',
        'char': '_char', 'object': '_ref', 'IntPtr': '_ptr', 'UIntPtr': '_uptr',
        'string[]': '_texts', 'int[]': '_values', 'float[]': '_amounts',
        'bool[]': '_flags', 'byte[]': '_bytes', 'long[]': '_ids',
        'double[]': '_doubles', 'float[]': '_floats', 'char[]': '_chars',
        'object[]': '_refs', 'uint[]': '_counts',
    }

    # Known Unity/VRC type patterns → semantic field names (expanded)
    TYPE_SEMANTIC_MAP = {
        # Unity Core
        'Transform': '_transform', 'GameObject': '_gameObject', 'Animator': '_animator',
        'Animation': '_animation', 'AnimationClip': '_animClip',
        'AnimatorController': '_animController', 'RuntimeAnimatorController': '_animController',
        'Rigidbody': '_rigidbody', 'Rigidbody2D': '_rigidbody2D',
        'Collider': '_collider', 'BoxCollider': '_boxCollider', 'SphereCollider': '_sphereCollider',
        'CapsuleCollider': '_capsuleCollider', 'MeshCollider': '_meshCollider',
        'Collider2D': '_collider2D', 'BoxCollider2D': '_boxCollider2D',
        'CharacterController': '_charController',
        'Renderer': '_renderer', 'MeshRenderer': '_meshRenderer',
        'SkinnedMeshRenderer': '_skinnedRenderer', 'LineRenderer': '_lineRenderer',
        'TrailRenderer': '_trailRenderer', 'ParticleSystemRenderer': '_particleRenderer',
        'Camera': '_camera', 'Light': '_light',
        'AudioSource': '_audioSource', 'AudioClip': '_audioClip', 'AudioMixer': '_audioMixer',
        'Material': '_material', 'Shader': '_shader', 'ComputeShader': '_computeShader',
        'Texture': '_texture', 'Texture2D': '_texture2D', 'RenderTexture': '_renderTexture',
        'Cubemap': '_cubemap', 'Sprite': '_sprite', 'Mesh': '_mesh', 'MeshFilter': '_meshFilter',
        # Unity UI
        'Image': '_image', 'RawImage': '_rawImage', 'Text': '_text', 'TextMeshPro': '_tmpText',
        'TextMeshProUGUI': '_tmpText', 'TMP_Text': '_tmpText', 'TMP_InputField': '_tmpInput',
        'Button': '_button', 'Toggle': '_toggle', 'Slider': '_slider', 'Scrollbar': '_scrollbar',
        'Dropdown': '_dropdown', 'InputField': '_inputField', 'ScrollRect': '_scrollRect',
        'Canvas': '_canvas', 'CanvasGroup': '_canvasGroup', 'CanvasRenderer': '_canvasRenderer',
        'RectTransform': '_rectTransform', 'LayoutGroup': '_layoutGroup',
        'VerticalLayoutGroup': '_vertLayout', 'HorizontalLayoutGroup': '_horzLayout',
        'GridLayoutGroup': '_gridLayout', 'ContentSizeFitter': '_sizeFitter',
        'LayoutElement': '_layoutElement', 'GraphicRaycaster': '_raycaster',
        # Unity Math
        'Vector2': '_vec2', 'Vector3': '_vec3', 'Vector4': '_vec4',
        'Vector2Int': '_vec2i', 'Vector3Int': '_vec3i',
        'Quaternion': '_rotation', 'Color': '_color', 'Color32': '_color32',
        'Matrix4x4': '_matrix', 'Bounds': '_bounds', 'Rect': '_rect', 'Ray': '_ray',
        'Plane': '_plane', 'LayerMask': '_layerMask',
        # Unity Events / Delegates
        'Action': '_callback', 'Func': '_func', 'Delegate': '_delegate',
        'UnityEvent': '_event', 'UnityAction': '_action',
        'EventHandler': '_handler', 'EventArgs': '_args',
        # Unity Async
        'Coroutine': '_coroutine', 'CancellationToken': '_cancellation',
        'CancellationTokenSource': '_cts', 'Task': '_task', 'UniTask': '_uniTask',
        # Collections
        'List': '_list', 'Dictionary': '_dict', 'HashSet': '_set',
        'Array': '_array', 'Queue': '_queue', 'Stack': '_stack',
        'LinkedList': '_linkedList', 'SortedList': '_sortedList',
        'ConcurrentDictionary': '_concurrentDict', 'ConcurrentQueue': '_concurrentQueue',
        'ReadOnlyCollection': '_readOnlyList', 'ObservableCollection': '_observable',
        # IO / Net
        'Stream': '_stream', 'MemoryStream': '_memStream', 'FileStream': '_fileStream',
        'BinaryReader': '_reader', 'BinaryWriter': '_writer',
        'StreamReader': '_streamReader', 'StreamWriter': '_streamWriter',
        'StringBuilder': '_sb', 'StringWriter': '_stringWriter',
        'HttpClient': '_httpClient', 'WebSocket': '_webSocket',
        'IPAddress': '_ipAddress', 'IPEndPoint': '_endpoint',
        # System
        'Type': '_type', 'MethodInfo': '_methodInfo', 'FieldInfo': '_fieldInfo',
        'PropertyInfo': '_propertyInfo', 'Assembly': '_assembly',
        'Timer': '_timer', 'Stopwatch': '_stopwatch', 'DateTime': '_dateTime',
        'TimeSpan': '_timeSpan', 'Guid': '_guid', 'Uri': '_uri',
        'Regex': '_regex', 'Match': '_match',
        'Thread': '_thread', 'Mutex': '_mutex', 'Semaphore': '_semaphore',
        'ManualResetEvent': '_resetEvent', 'AutoResetEvent': '_autoResetEvent',
        # Photon
        'PhotonView': '_photonView', 'PhotonPlayer': '_photonPlayer',
        'Player': '_player', 'Room': '_room', 'RoomOptions': '_roomOptions',
        'RaiseEventOptions': '_raiseEventOptions', 'SendOptions': '_sendOptions',
        'LoadBalancingClient': '_lbClient', 'LoadBalancingPeer': '_lbPeer',
        'OperationResponse': '_opResponse', 'EventData': '_eventData',
        # VRChat
        'VRCPlayer': '_player', 'VRCPlayerApi': '_playerApi',
        'ApiAvatar': '_avatar', 'ApiWorld': '_world', 'ApiUser': '_user',
        'ApiNotification': '_notification', 'ApiFile': '_file',
        'UdonBehaviour': '_udonBehaviour', 'UdonProgram': '_udonProgram',
        'VRC_Pickup': '_pickup', 'VRC_Trigger': '_trigger',
        'VRC_Station': '_station', 'VRC_Mirror': '_mirror',
        'VRC_AvatarDescriptor': '_avatarDescriptor',
        'VRC_SceneDescriptor': '_sceneDescriptor',
        'DynamicBone': '_dynamicBone', 'DynamicBoneCollider': '_dbCollider',
        'PhysBone': '_physBone', 'PhysBoneCollider': '_pbCollider',
        'ContactReceiver': '_contactReceiver', 'ContactSender': '_contactSender',
    }

    # Partial type recovery patterns: substring → field name
    # For garbled type strings from Frida extraction
    TYPE_SUBSTRING_MAP = {
        'atrix': '_matrix', 'ector': '_vector', 'ounds': '_bounds',
        'olor32': '_color32', 'olor': '_color', 'uaternion': '_rotation',
        'aterial': '_material', 'exture': '_texture', 'eader': '_reader',
        'riter': '_writer', 'tream': '_stream', 'uffer': '_buffer',
        'ollider': '_collider', 'igidbody': '_rigidbody', 'nimator': '_animator',
        'amera': '_camera', 'ight': '_light', 'udioSource': '_audioSource',
        'udioClip': '_audioClip', 'ameObject': '_gameObject', 'ransform': '_transform',
        'anvas': '_canvas', 'ectTransform': '_rectTransform', 'mage': '_image',
        'utton': '_button', 'oggle': '_toggle', 'lider': '_slider',
        'oroutine': '_coroutine', 'ankToken': '_cancellation',
        'ist<': '_list', 'ictionary<': '_dict', 'ashSet<': '_set',
        'rray': '_array', 'ueue': '_queue', 'tack': '_stack',
        'tringBuilder': '_sb', 'imeSpan': '_timeSpan', 'ateTime': '_dateTime',
        'otonView': '_photonView', 'otonPlayer': '_photonPlayer',
        'donBehaviour': '_udonBehaviour',
    }

    def _load_field_types(self):
        """Load runtime field types from field_types.json if available."""
        base = Path(__file__).resolve().parent.parent
        ft_path = base / 'output' / 'field_types.json'
        if not ft_path.exists():
            print('  field_types.json not found, skipping runtime type inference')
            return {}

        with open(ft_path, 'r', encoding='utf-8') as f:
            ft_data = json.load(f)

        # Build lookup: (class_name, field_name) -> type_string
        ft_lookup = {}
        for cname, cdata in ft_data.get('classes', {}).items():
            for field in cdata.get('fields', []):
                if isinstance(field, dict):
                    fname = field.get('name', '')
                    ftype = field.get('type', '?')
                    if fname and ftype and ftype != '?':
                        ft_lookup[(cname, fname)] = ftype

        print(f'  Loaded {len(ft_lookup):,} runtime field types')
        return ft_lookup

    def _infer_field_name_from_type(self, type_str: str, class_name: str,
                                     used_in_class: set) -> str | None:
        """Try to derive a semantic field name from a runtime type string."""
        if not type_str or type_str == '?':
            return None

        # Check primitive types first (exact match)
        if type_str in self.PRIMITIVE_FIELD_NAMES:
            base = self.PRIMITIVE_FIELD_NAMES[type_str]
            return self._unique_field_in_class(base, used_in_class)

        # Check known Unity/VRC types (exact or generic match)
        for known_type, field_name in self.TYPE_SEMANTIC_MAP.items():
            if type_str == known_type or type_str.startswith(known_type + '`'):
                return self._unique_field_in_class(field_name, used_in_class)

        # Strategy A: Extract base type from generics like "List<SomeType>"
        generic_match = re.match(r'^([A-Za-z]\w+?)(?:<|\[|`)', type_str)
        if generic_match:
            base_type = generic_match.group(1)
            if base_type in self.TYPE_SEMANTIC_MAP:
                return self._unique_field_in_class(self.TYPE_SEMANTIC_MAP[base_type], used_in_class)
            if base_type in self.PRIMITIVE_FIELD_NAMES:
                return self._unique_field_in_class(self.PRIMITIVE_FIELD_NAMES[base_type], used_in_class)

        # Strategy B: Partial type recovery from garbled/truncated strings
        for substring, field_name in self.TYPE_SUBSTRING_MAP.items():
            if substring in type_str:
                return self._unique_field_in_class(field_name, used_in_class)

        # Strategy C: Try to extract a meaningful name from complex types
        # Strip obfuscated characters but keep alphabetic parts
        # e.g., "SomeClass" → "_someClass", "IFoo" → "_foo"
        # Also handle partial types like "atrix_Injected" → "Matrix"
        clean = re.sub(r'[\u00CC\u00CD\u00CE\u00CF]+', '', type_str)
        clean = re.sub(r'[<>\[\]`\d,\s\.=_]', '', clean)
        # Take the longest alphabetic run
        alpha_runs = re.findall(r'[A-Za-z]{3,}', clean)
        if alpha_runs:
            best = max(alpha_runs, key=len)
            # Remove interface prefix
            if best.startswith('I') and len(best) > 1 and best[1].isupper():
                best = best[1:]
            # Check if the extracted name matches a known type
            for known_type, field_name in self.TYPE_SEMANTIC_MAP.items():
                if best == known_type or known_type.endswith(best):
                    return self._unique_field_in_class(field_name, used_in_class)
            if len(best) >= 4:
                field_name = '_' + best[0].lower() + best[1:]
                return self._unique_field_in_class(field_name, used_in_class)

        return None

    def _unique_field_in_class(self, base: str, used_in_class: set) -> str:
        """Ensure field name is unique within its class."""
        if base not in used_in_class:
            used_in_class.add(base)
            return base
        for i in range(2, 100):
            candidate = f'{base}{i}'
            if candidate not in used_in_class:
                used_in_class.add(candidate)
                return candidate
        return base  # fallback

    def _infer_method_name(self, cls_name: str, method_name: str,
                            cls: dict, method_idx: int,
                            used_methods: set, pass_num: int = 1) -> str | None:
        """Try to derive a semantic method name from class context.
        pass_num=2 means second pass with expanded neighbor data."""
        methods = cls.get('methods', [])
        str_methods = [m for m in methods if isinstance(m, str)]
        named = [m for m in str_methods if not is_obf(m)]
        parent = cls.get('parent', '')
        resolved_cls = self.class_map.get(cls_name, cls_name)
        obf_count = sum(1 for m in str_methods if is_obf(m))

        # In pass 2, also count methods we renamed in pass 1 as "named"
        if pass_num >= 2:
            for m in str_methods:
                if is_obf(m) and (cls_name, m) in self.class_method_map:
                    nm = self.class_method_map[(cls_name, m)]
                    if not nm.startswith('m_'):
                        named.append(nm)

        # Strategy M1: Class role → method naming heuristics (relaxed to ≤5 obf)
        role_patterns = {
            'Handler': ['Handle', 'Process', 'OnReceive', 'OnEvent'],
            'Manager': ['Initialize', 'Shutdown', 'Register', 'Unregister'],
            'Controller': ['Execute', 'Control', 'SetState', 'GetState'],
            'Factory': ['Create', 'Build', 'Make', 'Instantiate'],
            'Provider': ['Provide', 'Get', 'Fetch', 'Supply'],
            'Validator': ['Validate', 'Check', 'Verify', 'IsValid'],
            'Serializer': ['Serialize', 'Deserialize', 'Read', 'Write'],
            'Listener': ['OnEvent', 'HandleEvent', 'Notify', 'Subscribe'],
            'Builder': ['Build', 'AddPart', 'SetOption', 'Configure'],
            'Converter': ['Convert', 'Transform', 'Map', 'Parse'],
            'Resolver': ['Resolve', 'Lookup', 'Find', 'Locate'],
            'Comparer': ['Compare', 'Equals', 'GetHashCode'],
            'Enumerator': ['MoveNext', 'Reset', 'GetCurrent'],
            'Cache': ['Get', 'Set', 'Invalidate', 'Clear'],
            'Pool': ['Acquire', 'Release', 'Reset', 'Resize'],
            'Observer': ['OnNext', 'OnError', 'OnCompleted', 'Subscribe'],
            'Adapter': ['Adapt', 'Wrap', 'Unwrap', 'Convert'],
            'Disposable': ['Dispose', 'Release', 'Cleanup', 'Close'],
        }

        for role, method_candidates in role_patterns.items():
            if role in resolved_cls or role in parent:
                if obf_count <= 5:
                    for candidate in method_candidates:
                        if candidate not in named and candidate not in used_methods:
                            used_methods.add(candidate)
                            return candidate

        # Strategy M2: Method position heuristics (expanded)
        if method_idx > 0:
            prev = methods[method_idx - 1] if method_idx < len(methods) else None
            if isinstance(prev, str):
                if prev == '.ctor' and 'Initialize' not in named and 'Initialize' not in used_methods:
                    used_methods.add('Initialize')
                    return 'Initialize'
                if prev == 'Dispose' and 'Cleanup' not in used_methods:
                    used_methods.add('Cleanup')
                    return 'Cleanup'
                # After OnEnable → likely OnDisable or Setup
                if prev == 'OnEnable' and 'OnDisable' not in named and 'OnDisable' not in used_methods:
                    used_methods.add('OnDisable')
                    return 'OnDisable'
                # After Awake → likely OnDestroy
                if prev == 'Awake' and 'OnDestroy' not in named and 'OnDestroy' not in used_methods:
                    used_methods.add('OnDestroy')
                    return 'OnDestroy'

        # Strategy M3: Interface implementation detection (relaxed to ≤3 obf)
        iface_methods = [m for m in named if '.' in m and not m.startswith('.')]
        iface_names = set()
        for im in iface_methods:
            parts = im.rsplit('.', 1)
            if len(parts) == 2:
                iface_names.add(parts[1])

        obf_methods_in_cls = [m for m in str_methods if is_obf(m)]
        if len(obf_methods_in_cls) <= 3 and iface_names:
            for iname in iface_names:
                if iname not in named and iname not in used_methods:
                    used_methods.add(iname)
                    return iname

        # Strategy M4: get_X / set_X pairing
        # If previous method is get_X, this obf method is likely set_X (or vice versa)
        if method_idx > 0 and method_idx < len(methods):
            prev = methods[method_idx - 1] if isinstance(methods[method_idx - 1], str) else None
            if prev:
                if prev.startswith('get_') and not is_obf(prev):
                    prop = prev[4:]
                    setter = f'set_{prop}'
                    if setter not in named and setter not in used_methods:
                        used_methods.add(setter)
                        return setter
                if prev.startswith('set_') and not is_obf(prev):
                    prop = prev[4:]
                    getter = f'get_{prop}'
                    if getter not in named and getter not in used_methods:
                        used_methods.add(getter)
                        return getter
        # Also check next method for reverse pairing
        if method_idx + 1 < len(methods):
            nxt = methods[method_idx + 1] if isinstance(methods[method_idx + 1], str) else None
            if nxt:
                if nxt.startswith('set_') and not is_obf(nxt):
                    prop = nxt[4:]
                    getter = f'get_{prop}'
                    if getter not in named and getter not in used_methods:
                        used_methods.add(getter)
                        return getter
                if nxt.startswith('get_') and not is_obf(nxt):
                    prop = nxt[4:]
                    setter = f'set_{prop}'
                    if setter not in named and setter not in used_methods:
                        used_methods.add(setter)
                        return setter

        # Strategy M5: add_X / remove_X event pairing
        if method_idx > 0 and method_idx < len(methods):
            prev = methods[method_idx - 1] if isinstance(methods[method_idx - 1], str) else None
            if prev:
                if prev.startswith('add_') and not is_obf(prev):
                    evt = prev[4:]
                    remover = f'remove_{evt}'
                    if remover not in named and remover not in used_methods:
                        used_methods.add(remover)
                        return remover
                if prev.startswith('remove_') and not is_obf(prev):
                    evt = prev[7:]
                    adder = f'add_{evt}'
                    if adder not in named and adder not in used_methods:
                        used_methods.add(adder)
                        return adder

        # Strategy M6: Async state machine detection
        # Classes like <MethodName>d__N have MoveNext as their key method
        async_match = re.match(r'^<(.+?)>d__\d+$', cls_name)
        if async_match:
            source_method = async_match.group(1)
            if not is_obf(source_method):
                # First obf method in an async class is typically MoveNext
                if obf_methods_in_cls and obf_methods_in_cls[0] == method_name:
                    if 'MoveNext' not in named and 'MoveNext' not in used_methods:
                        used_methods.add('MoveNext')
                        return 'MoveNext'
                # Second is often SetStateMachine
                if len(obf_methods_in_cls) >= 2 and obf_methods_in_cls[1] == method_name:
                    if 'SetStateMachine' not in named and 'SetStateMachine' not in used_methods:
                        used_methods.add('SetStateMachine')
                        return 'SetStateMachine'

        # Strategy M7: Parent virtual method propagation
        # If parent has named methods and this class overrides them,
        # obf methods at same relative position are likely overrides
        if parent and not is_obf(parent):
            parent_cls = self._find_class_by_name(parent)
            if parent_cls:
                parent_methods = parent_cls.get('methods', [])
                parent_named = [m for m in parent_methods if isinstance(m, str) and not is_obf(m)]
                # If parent has methods at same index position
                if method_idx < len(parent_methods):
                    parent_m = parent_methods[method_idx]
                    if isinstance(parent_m, str) and not is_obf(parent_m) and parent_m not in STANDARD_METHODS:
                        if parent_m not in used_methods:
                            used_methods.add(parent_m)
                            return parent_m

        # Strategy M8: Singleton pattern detection
        fields = cls.get('fields', [])
        if obf_count == 1 and len(fields) == 1:
            f = fields[0]
            fname = f.get('name', '') if isinstance(f, dict) else str(f)
            if is_obf(fname):
                if 'GetInstance' not in used_methods:
                    used_methods.add('GetInstance')
                    return 'GetInstance'

        # Strategy M9: MonoBehaviour lifecycle — relative position based
        # Instead of limiting by obf_count, check if this obf method is
        # positioned relative to a known lifecycle method in a predictable way
        mono_parents = {'MonoBehaviour', 'UIBehaviour', 'Selectable', 'Graphic',
                        'MaskableGraphic', 'BaseMeshEffect'}
        is_mono = parent in mono_parents or any(p in parent for p in ('Component', 'Behaviour'))
        if is_mono or any(p in resolved_cls for p in ('Component', 'Behaviour')):
            # Position-relative lifecycle pairs (known → adjacent obf)
            lifecycle_pairs = {
                # If prev is X, this obf method is likely Y
                'Update': 'LateUpdate', 'LateUpdate': 'FixedUpdate',
                'Start': 'Update', 'Awake': 'Start',
                'OnEnable': 'OnDisable', 'OnDisable': 'OnDestroy',
            }
            # Check prev method
            if method_idx > 0:
                prev = methods[method_idx - 1] if isinstance(methods[method_idx - 1], str) else None
                if prev in lifecycle_pairs:
                    candidate = lifecycle_pairs[prev]
                    if candidate not in named and candidate not in used_methods:
                        used_methods.add(candidate)
                        return candidate
            # Check next method (reverse pairs)
            reverse_pairs = {v: k for k, v in lifecycle_pairs.items()}
            if method_idx + 1 < len(methods):
                nxt = methods[method_idx + 1] if isinstance(methods[method_idx + 1], str) else None
                if nxt in reverse_pairs:
                    candidate = reverse_pairs[nxt]
                    if candidate not in named and candidate not in used_methods:
                        used_methods.add(candidate)
                        return candidate

        # Strategy M10: ValueType standard methods — no obf_count limit
        # These are guaranteed overrides for value types
        if parent in ('ValueType', 'Enum'):
            vt_methods = ['Equals', 'GetHashCode', 'ToString']
            for candidate in vt_methods:
                if candidate not in named and candidate not in used_methods:
                    used_methods.add(candidate)
                    return candidate

        # Strategy M11: Interface pattern detection — relaxed constraints
        iface_hints = {
            'GetEnumerator': {'IEnumerable', 'Enumerable'},
            'MoveNext': {'IEnumerator', 'Enumerator'},
            'get_Current': {'IEnumerator', 'Enumerator'},
            'Contains': {'ICollection', 'IList', 'Collection'},
            'IndexOf': {'IList', 'List'},
            'CopyTo': {'ICollection', 'Collection'},
            'Clear': {'ICollection', 'IDictionary', 'Collection', 'Dictionary'},
            'ContainsKey': {'IDictionary', 'Dictionary'},
            'TryGetValue': {'IDictionary', 'Dictionary'},
            'Add': {'ICollection', 'IList', 'IDictionary', 'Collection'},
            'Remove': {'ICollection', 'IList', 'IDictionary'},
        }
        # Detect interfaces from explicit methods AND parent class name
        has_iface = set()
        for m in named:
            if '.' in m and not m.startswith('.'):
                parts = m.rsplit('.', 1)[0].split('.')
                for short in parts:
                    has_iface.add(short.split('`')[0])
        # Also check class/parent name for collection-like types
        for check_name in (resolved_cls, parent):
            for iface in ('Enumerator', 'Collection', 'List', 'Dictionary',
                          'Enumerable', 'Comparer', 'EqualityComparer'):
                if iface in check_name:
                    has_iface.add(iface)
        if has_iface:
            for method_name, required_ifaces in iface_hints.items():
                if required_ifaces & has_iface:
                    if method_name not in named and method_name not in used_methods:
                        used_methods.add(method_name)
                        return method_name

        # Strategy M12: get_/set_ unmatched — expanded range
        # For each missing setter, check if there's an obf method near the getter
        all_getters = [m for m in named if m.startswith('get_')]
        all_setters = [m for m in named if m.startswith('set_')]
        getter_props = {g[4:] for g in all_getters}
        setter_props = {s[4:] for s in all_setters}
        missing_setters = getter_props - setter_props
        missing_getters = setter_props - getter_props
        # Check if THIS obf method is near a getter with missing setter (±4 range)
        for prop in missing_setters:
            getter_name = f'get_{prop}'
            for gi, gm in enumerate(methods):
                if isinstance(gm, str) and gm == getter_name:
                    if abs(method_idx - gi) <= 4:
                        setter = f'set_{prop}'
                        if setter not in used_methods:
                            used_methods.add(setter)
                            return setter
                    break
        for prop in missing_getters:
            setter_name = f'set_{prop}'
            for si, sm in enumerate(methods):
                if isinstance(sm, str) and sm == setter_name:
                    if abs(method_idx - si) <= 4:
                        getter = f'get_{prop}'
                        if getter not in used_methods:
                            used_methods.add(getter)
                            return getter
                    break

        # Strategy M13: String-ref domain → method action inference
        # Use class_string_refs to infer method domain, then name by position
        class_strings = getattr(self, '_class_string_refs', {}).get(cls_name, [])
        if class_strings and obf_count <= 20:
            # Extract method actions from Unity API refs
            action_verbs = []
            for s in class_strings:
                m_match = re.search(r'::(\w+)\(', s)
                if m_match:
                    api_method = m_match.group(1)
                    # Extract verb (get_, set_, On, Is, Has, etc.)
                    if api_method.startswith('get_'):
                        action_verbs.append(f'Get{api_method[4:]}')
                    elif api_method.startswith('set_'):
                        action_verbs.append(f'Set{api_method[4:]}')
                    elif not api_method.startswith('.'):
                        action_verbs.append(api_method)

            # Assign unique verbs to obf methods by position
            obf_positions = [(i, m) for i, m in enumerate(methods)
                             if isinstance(m, str) and is_obf(m)]
            my_pos = next((pi for pi, (i, m) in enumerate(obf_positions)
                          if i == method_idx), -1)
            if 0 <= my_pos < len(action_verbs):
                candidate = action_verbs[my_pos]
                if candidate not in used_methods and candidate not in named:
                    used_methods.add(candidate)
                    return candidate

        # Strategy M14: Extended lifecycle chain (multi-step)
        # If any lifecycle method exists in class, map all positions in the chain
        if is_mono or any(p in resolved_cls for p in ('Component', 'Behaviour')):
            lifecycle_order = [
                'Awake', 'OnEnable', 'Start', 'FixedUpdate', 'Update',
                'LateUpdate', 'OnDisable', 'OnDestroy',
                'OnApplicationPause', 'OnApplicationQuit',
                'OnBecameVisible', 'OnBecameInvisible',
                'OnCollisionEnter', 'OnCollisionStay', 'OnCollisionExit',
                'OnTriggerEnter', 'OnTriggerStay', 'OnTriggerExit',
            ]
            # Find ALL known lifecycle positions
            known_positions = {}
            for i, m in enumerate(methods):
                if isinstance(m, str) and m in lifecycle_order:
                    known_positions[m] = i
            # If we have ≥1 known, try to fill gaps
            if known_positions:
                for known_name, known_idx in known_positions.items():
                    known_order_idx = lifecycle_order.index(known_name)
                    offset = method_idx - known_idx
                    target_order_idx = known_order_idx + offset
                    if 0 <= target_order_idx < len(lifecycle_order):
                        candidate = lifecycle_order[target_order_idx]
                        if candidate not in named and candidate not in used_methods:
                            used_methods.add(candidate)
                            return candidate

        # Strategy M15: UI event handler patterns
        # Classes inheriting from UI types often implement specific callbacks
        ui_parents = {'Selectable', 'Button', 'Toggle', 'Slider', 'Dropdown',
                      'InputField', 'ScrollRect', 'Scrollbar'}
        if parent in ui_parents or any(p in resolved_cls for p in ui_parents):
            ui_callbacks = [
                'OnPointerEnter', 'OnPointerExit', 'OnPointerDown', 'OnPointerUp',
                'OnPointerClick', 'OnSelect', 'OnDeselect', 'OnSubmit', 'OnCancel',
                'OnMove', 'OnScroll', 'OnValueChanged', 'OnEndEdit',
            ]
            for candidate in ui_callbacks:
                if candidate not in named and candidate not in used_methods:
                    used_methods.add(candidate)
                    return candidate

        # Strategy M16: Common override methods for known base classes
        override_map = {
            'Object': ['Equals', 'GetHashCode', 'ToString'],
            'IDisposable': ['Dispose'],
            'Exception': ['get_Message', 'get_StackTrace'],
            'Attribute': ['get_TypeId'],
            'EventArgs': ['ToString'],
            'Stream': ['Read', 'Write', 'Flush', 'Close', 'Seek', 'SetLength'],
            'TextWriter': ['Write', 'WriteLine', 'Flush', 'Close'],
            'TextReader': ['Read', 'ReadLine', 'Close'],
            'ISerializable': ['GetObjectData'],
            'ICloneable': ['Clone'],
            'IComparable': ['CompareTo'],
            'IFormattable': ['ToString'],
            'IConvertible': ['GetTypeCode', 'ToBoolean', 'ToChar', 'ToSByte',
                            'ToByte', 'ToInt16', 'ToUInt16', 'ToInt32',
                            'ToUInt32', 'ToInt64', 'ToUInt64', 'ToSingle',
                            'ToDouble', 'ToDecimal', 'ToDateTime', 'ToString',
                            'ToType'],
        }
        # Check parent and interfaces
        for base_name, candidates in override_map.items():
            if base_name in parent or any(base_name in m for m in named if '.' in m):
                for candidate in candidates:
                    if candidate not in named and candidate not in used_methods:
                        used_methods.add(candidate)
                        return candidate

        return None

    def _find_class_by_name(self, name: str) -> dict | None:
        """Find a class dict by name from the dump data."""
        if not hasattr(self, '_class_by_name_cache'):
            self._class_by_name_cache = {}
            for ns, classes in self.data['namespaces'].items():
                for cls in classes:
                    self._class_by_name_cache[cls['name']] = cls
        return self._class_by_name_cache.get(name)

    def rename_methods_and_fields(self):
        print('\n=== Renaming Methods & Fields ===')

        method_count = 0
        method_semantic = 0
        field_count = 0
        field_semantic = 0
        field_backing = 0
        field_type_inferred = 0
        field_accessor_matched = 0

        # Load runtime field types
        ft_lookup = self._load_field_types()

        # Load deep analysis method names if available
        deep_names = getattr(self, '_deep_method_names', {})

        # Load IDA string-ref based method names
        ida_str_names = {}
        base_dir = Path(__file__).resolve().parent.parent
        ida_str_path = base_dir / 'output' / 'ida_method_string_names.json'
        if ida_str_path.exists():
            try:
                with open(ida_str_path, 'r', encoding='utf-8') as f:
                    ida_str_names = json.load(f)
                print(f'  Loaded {len(ida_str_names)} IDA string-ref method names')
            except Exception:
                pass

        # Load cross-version lifted method names (from prior version's deobf)
        cross_ver_names = {}
        cv_path = base_dir / 'output' / 'cross_version_method_names.json'
        if cv_path.exists():
            try:
                with open(cv_path, 'r', encoding='utf-8') as f:
                    cross_ver_names = json.load(f)
                print(f'  Loaded {len(cross_ver_names)} cross-version lifted method names')
            except Exception:
                pass

        # Load VA-based name propagation
        va_prop_names = {}
        va_prop_path = base_dir / 'output' / 'va_propagation_names.json'
        if va_prop_path.exists():
            try:
                with open(va_prop_path, 'r', encoding='utf-8') as f:
                    va_prop_names = json.load(f)
                print(f'  Loaded {len(va_prop_names)} VA-propagated method names')
            except Exception:
                pass

        # Load call graph inferred names
        cg_names = {}
        cg_path = base_dir / 'output' / 'callgraph_method_names.json'
        if cg_path.exists():
            try:
                with open(cg_path, 'r', encoding='utf-8') as f:
                    cg_names = json.load(f)
                print(f'  Loaded {len(cg_names)} call graph method names')
            except Exception:
                pass

        # Load string-API derived names
        str_api_names = {}
        str_api_path = base_dir / 'output' / 'string_api_method_names.json'
        if str_api_path.exists():
            try:
                with open(str_api_path, 'r', encoding='utf-8') as f:
                    str_api_names = json.load(f)
                print(f'  Loaded {len(str_api_names)} string-API method names')
            except Exception:
                pass

        # Load LLM predicted names
        llm_names = {}
        llm_path = base_dir / 'output' / 'llm_predicted_names.json'
        if llm_path.exists():
            try:
                with open(llm_path, 'r', encoding='utf-8') as f:
                    llm_names = json.load(f)
                print(f'  Loaded {len(llm_names)} LLM predicted method names')
            except Exception:
                pass

        # Load class string refs for M13 (string-ref method naming)
        if not hasattr(self, '_class_string_refs'):
            self._class_string_refs = {}
            deep_path = base_dir / 'output' / 'deep_analysis.json'
            if deep_path.exists():
                try:
                    with open(deep_path, 'r', encoding='utf-8') as f:
                        da = json.load(f)
                    self._class_string_refs = da.get('class_string_refs', {})
                except Exception:
                    pass

        # Process ALL classes (not just class_index) to handle duplicates
        all_classes = []
        for ns, classes in self.data['namespaces'].items():
            for cls in classes:
                all_classes.append((ns, cls))

        # === Pass 1: Initial method renaming ===
        pass1_semantic = 0
        for ns, cls in all_classes:
            name = cls['name']
            methods = cls.get('methods', [])

            used_method_names = set(m for m in methods if isinstance(m, str) and not is_obf(m))
            for idx, m in enumerate(methods):
                if not isinstance(m, str) or not is_obf(m):
                    continue

                new_name = None

                # Try direct Apr18->Apr25 lift first
                deep_key = f'{name}::{m}'
                if deep_key in self._lifted_method_names:
                    candidate = self._lifted_method_names[deep_key]
                    if candidate and not is_obf(candidate):
                        if candidate in used_method_names:
                            long_h = stable_hash(m, 12)
                            candidate = f'{candidate}_{long_h}'
                        if candidate not in used_method_names:
                            new_name = candidate
                            used_method_names.add(candidate)
                            method_semantic += 1

                # Try deep analysis semantic name first
                if not new_name and deep_key in deep_names:
                    new_name = deep_names[deep_key]
                    method_semantic += 1

                # Try IDA string-ref based name
                if not new_name and deep_key in ida_str_names:
                    candidate = ida_str_names[deep_key]
                    if candidate not in used_method_names:
                        new_name = candidate
                        used_method_names.add(candidate)
                        method_semantic += 1

                # Try cross-version lifted name (from prior version's deobfuscation)
                if not new_name and cross_ver_names:
                    deobf_cn = self.class_map.get(name, name)
                    h = stable_hash(m, 3)
                    cv_key = f'{deobf_cn}::m_{h}'
                    if cv_key in cross_ver_names:
                        candidate = cross_ver_names[cv_key]
                        if candidate:
                            if candidate in used_method_names:
                                long_h = stable_hash(m, 12)
                                candidate = f'{candidate}_{long_h}'
                            if candidate not in used_method_names:
                                new_name = candidate
                                used_method_names.add(candidate)
                                method_semantic += 1

                # Try VA-based name propagation (same code = same function)
                if not new_name and deep_key in va_prop_names:
                    candidate = va_prop_names[deep_key]
                    # Clean up fully-qualified interface names
                    if '.' in candidate and '>' not in candidate:
                        candidate = candidate.rsplit('.', 1)[-1]
                    elif '>' in candidate:
                        # Like System.Collections.Generic.IEnumerator<X>.get_Current
                        _qm = re.search(r'\.(\w+)$', candidate)
                        if _qm:
                            candidate = _qm.group(1)
                    if candidate and candidate not in used_method_names:
                        new_name = candidate
                        used_method_names.add(candidate)
                        method_semantic += 1

                # Try call graph inferred name
                if not new_name and deep_key in cg_names:
                    candidate = cg_names[deep_key]
                    if candidate not in used_method_names:
                        new_name = candidate
                        used_method_names.add(candidate)
                        method_semantic += 1

                # Try string-API derived name
                if not new_name and deep_key in str_api_names:
                    candidate = str_api_names[deep_key]
                    if candidate not in used_method_names:
                        new_name = candidate
                        used_method_names.add(candidate)
                        method_semantic += 1

                # Try LLM predicted name (keys use deobf class name + hash)
                if not new_name and llm_names:
                    deobf_cn = self.class_map.get(name, name)
                    h = stable_hash(m, 3)
                    llm_key = f'{deobf_cn}::m_{h}'
                    if llm_key in llm_names:
                        candidate = llm_names[llm_key]
                        if candidate in used_method_names:
                            long_h = stable_hash(m, 6)
                            candidate = f'{candidate}_{long_h}'
                        if candidate not in used_method_names:
                            new_name = candidate
                            used_method_names.add(candidate)
                            method_semantic += 1

                # Try context-based semantic inference
                if not new_name:
                    inferred = self._infer_method_name(
                        name, m, cls, idx, used_method_names, pass_num=1)
                    if inferred:
                        new_name = inferred
                        method_semantic += 1

                # Fallback: hash-based
                if not new_name:
                    h = stable_hash(m, 3)
                    new_name = f'm_{h}'

                self.class_method_map[(name, m)] = new_name
                method_count += 1

        pass1_semantic = method_semantic
        print(f'  Pass 1: {pass1_semantic} semantic methods')

        # === Pass 2: Use pass 1 results to name more methods ===
        pass2_new = 0
        for ns, cls in all_classes:
            name = cls['name']
            methods = cls.get('methods', [])

            # Check if this class has any hash methods that pass 2 could improve
            has_hash = False
            for m in methods:
                if isinstance(m, str) and is_obf(m):
                    key = (name, m)
                    if key in self.class_method_map and self.class_method_map[key].startswith('m_'):
                        has_hash = True
                        break
            if not has_hash:
                continue

            # Rebuild used_methods including pass 1 semantic results
            used_method_names = set()
            for m in methods:
                if isinstance(m, str):
                    if not is_obf(m):
                        used_method_names.add(m)
                    else:
                        key = (name, m)
                        if key in self.class_method_map:
                            nm = self.class_method_map[key]
                            if not nm.startswith('m_'):
                                used_method_names.add(nm)

            for idx, m in enumerate(methods):
                if not isinstance(m, str) or not is_obf(m):
                    continue
                key = (name, m)
                if key in self.class_method_map and not self.class_method_map[key].startswith('m_'):
                    continue  # Already has semantic name

                new_name = None
                deep_key = f'{name}::{m}'

                # Try call graph name (may not have been available in pass 1 context)
                if deep_key in cg_names:
                    candidate = cg_names[deep_key]
                    if candidate not in used_method_names:
                        new_name = candidate
                        used_method_names.add(candidate)

                # Try cross-version lifted name again with updated class_map
                if not new_name and cross_ver_names:
                    deobf_cn = self.class_map.get(name, name)
                    h = stable_hash(m, 3)
                    cv_key = f'{deobf_cn}::m_{h}'
                    if cv_key in cross_ver_names:
                        candidate = cross_ver_names[cv_key]
                        if candidate and candidate not in used_method_names:
                            new_name = candidate
                            used_method_names.add(candidate)

                # Try context-based inference with pass 2 neighbor expansion
                if not new_name:
                    new_name = self._infer_method_name(
                        name, m, cls, idx, used_method_names, pass_num=2)

                if new_name:
                    self.class_method_map[key] = new_name
                    method_semantic += 1
                    pass2_new += 1

        print(f'  Pass 2: {pass2_new} additional semantic methods')

        for ns, cls in all_classes:
            name = cls['name']
            fields = cls.get('fields', [])
            methods = cls.get('methods', [])

            # ── Smart Field Renaming ──────────────────────────────────

            # Collect existing non-obf field names to avoid collisions
            used_in_class = set()
            for f in fields:
                if isinstance(f, dict):
                    fname = f.get('name', '')
                else:
                    fname = str(f)
                if not is_obf(fname):
                    used_in_class.add(fname)

            # Build property accessor map: property_name -> [get/set methods]
            prop_accessors = {}
            # Also build ordered list of accessor property names (preserving method order)
            accessor_order = []
            for m in methods:
                if isinstance(m, str) and (m.startswith('get_') or m.startswith('set_')):
                    prop = m.split('_', 1)[1]
                    if not is_obf(prop):
                        if prop not in prop_accessors:
                            prop_accessors[prop] = True
                            accessor_order.append(prop)

            # Collect obfuscated fields for potential accessor matching
            obf_fields = []
            for f in fields:
                if isinstance(f, dict):
                    fname = f.get('name', '')
                else:
                    fname = str(f)
                if is_obf(fname):
                    obf_fields.append(f)

            # Relaxed accessor matching: allow when obf count <= accessor count
            # (some accessors may be for non-obf or inherited fields)
            accessor_names = list(accessor_order) if len(obf_fields) <= len(prop_accessors) and len(obf_fields) > 0 else []
            # Also try when counts are close (within 2)
            if not accessor_names and 0 < len(obf_fields) <= len(prop_accessors) + 2 and len(prop_accessors) > 0:
                accessor_names = list(accessor_order)

            # Also handle backing fields: <X>k__BackingField → _x
            backing_re = re.compile(r'^<(.+?)>k__BackingField$')

            # Pre-compute: unmatched accessor properties (no corresponding named field)
            named_fields = set()
            for f in fields:
                fn = f.get('name', '') if isinstance(f, dict) else str(f)
                if not is_obf(fn) and not backing_re.match(fn):
                    named_fields.add(fn)
            unmatched_accessors = [p for p in accessor_order
                                   if p not in named_fields
                                   and f'_{p[0].lower()}{p[1:]}' not in named_fields]

            for idx, f in enumerate(fields):
                if isinstance(f, dict):
                    fname = f.get('name', '')
                else:
                    fname = str(f)

                # Strategy 0: Clean up backing field names
                bk_match = backing_re.match(fname)
                if bk_match:
                    prop = bk_match.group(1)
                    if not is_obf(prop):
                        if '.' in prop:
                            prop = prop.rsplit('.', 1)[-1]
                        clean = '_' + prop[0].lower() + prop[1:] if prop else fname
                        clean = self._unique_field_in_class(clean, used_in_class)
                        self.class_field_map[(name, fname)] = clean
                        field_backing += 1
                        field_count += 1
                        continue

                if not is_obf(fname) and not bk_match:
                    continue

                new_name = None

                lifted_key = f'{name}::{fname}'
                if lifted_key in self._lifted_field_names:
                    candidate = self._lifted_field_names[lifted_key]
                    if candidate and not is_obf(candidate):
                        new_name = self._unique_field_in_class(candidate, used_in_class)
                        field_semantic += 1

                # Strategy 1: Obfuscated backing field with accessor match
                if bk_match:
                    obf_prop = bk_match.group(1)
                    pass  # handled by accessor matching below

                # Strategy 2: Property accessor matching (relaxed — partial match OK)
                if not new_name and accessor_names:
                    obf_idx = obf_fields.index(f) if f in obf_fields else -1
                    if 0 <= obf_idx < len(accessor_names):
                        prop = accessor_names[obf_idx]
                        new_name = '_' + prop[0].lower() + prop[1:]
                        new_name = self._unique_field_in_class(new_name, used_in_class)
                        field_accessor_matched += 1

                # Strategy 2b: Unmatched accessor → obf field (by position among unmatched)
                if not new_name and unmatched_accessors:
                    obf_idx = obf_fields.index(f) if f in obf_fields else -1
                    if 0 <= obf_idx < len(unmatched_accessors):
                        prop = unmatched_accessors[obf_idx]
                        new_name = '_' + prop[0].lower() + prop[1:]
                        new_name = self._unique_field_in_class(new_name, used_in_class)
                        field_accessor_matched += 1

                # Strategy 3: Runtime type inference from field_types.json
                if not new_name:
                    orig_name = name
                    runtime_type = ft_lookup.get((orig_name, fname))
                    if not runtime_type:
                        for old_cn, new_cn in self.class_map.items():
                            if new_cn == name:
                                runtime_type = ft_lookup.get((old_cn, fname))
                                if runtime_type:
                                    break
                    if runtime_type:
                        inferred = self._infer_field_name_from_type(
                            runtime_type, name, used_in_class)
                        if inferred:
                            new_name = inferred
                            field_type_inferred += 1

                # Strategy 4: Infer from class context (relaxed to ≤5 fields)
                if not new_name and len(obf_fields) == 1 and len(fields) <= 5:
                    resolved_name = self.class_map.get(name, name)
                    if not is_obf(resolved_name) and resolved_name not in ('Object',):
                        base = resolved_name.split('_')[-1] if '_' in resolved_name else resolved_name
                        base = re.sub(r'`\d+', '', base)
                        if base and len(base) >= 2:
                            new_name = '_' + base[0].lower() + base[1:]
                            new_name = self._unique_field_in_class(new_name, used_in_class)

                # Strategy 5: Parent class field pattern propagation
                if not new_name:
                    parent_name = cls.get('parent', '')
                    if parent_name and not is_obf(parent_name):
                        parent_cls = self._find_class_by_name(parent_name)
                        if parent_cls:
                            parent_fields = parent_cls.get('fields', [])
                            if idx < len(parent_fields):
                                pf = parent_fields[idx]
                                pfname = pf.get('name', '') if isinstance(pf, dict) else str(pf)
                                if not is_obf(pfname) and not backing_re.match(pfname):
                                    new_name = '_' + pfname[0].lower() + pfname[1:] if pfname else None
                                    if new_name:
                                        new_name = self._unique_field_in_class(new_name, used_in_class)
                                        field_type_inferred += 1

                # Strategy 6: Delegate/Action/Func field detection
                if not new_name and isinstance(f, dict):
                    # If nearby methods include add_/remove_ with same event name
                    for m in methods:
                        if isinstance(m, str) and m.startswith('add_') and not is_obf(m[4:]):
                            evt = m[4:]
                            candidate = '_on' + evt
                            if candidate not in used_in_class:
                                new_name = self._unique_field_in_class(candidate, used_in_class)
                                field_type_inferred += 1
                                break

                # Fallback: hash-based name
                if not new_name:
                    h = stable_hash(fname, 3)
                    new_name = f'f_{h}'

                self.class_field_map[(name, fname)] = new_name
                field_count += 1

        named_semantic = field_backing + field_type_inferred + field_accessor_matched + field_semantic
        print(f'  Renamed {method_count} methods ({method_semantic} semantic, {method_count-method_semantic} hash)')
        print(f'  Renamed {field_count} fields:')
        print(f'    Backing field:    {field_backing}')
        print(f'    Accessor matched: {field_accessor_matched}')
        print(f'    Type inferred:    {field_type_inferred}')
        print(f'    Context inferred: {field_semantic}')
        print(f'    Hash fallback:    {field_count - named_semantic}')
        self.stats['methods_renamed'] = method_count
        self.stats['methods_semantic'] = method_semantic
        self.stats['fields_renamed'] = field_count
        self.stats['fields_semantic'] = named_semantic

    # ── Output Generation ──────────────────────────────────────────────

    def apply_and_save(self, output_dir: str):
        print(f'\n=== Generating Output ===')
        os.makedirs(output_dir, exist_ok=True)

        # Build new data with renamed classes
        new_data = {
            'summary': copy.deepcopy(self.data.get('summary', {})),
            'namespaces': {},
            'deobfuscation_info': {
                'total_classes_renamed': len(self.class_map),
                'total_methods_renamed': len(self.class_method_map),
                'total_fields_renamed': len(self.class_field_map),
            }
        }

        for ns, classes in self.data['namespaces'].items():
            new_classes = []
            for cls in classes:
                new_cls = {}
                old_name = cls['name']
                new_name = self.class_map.get(old_name, old_name)

                new_cls['name'] = new_name
                if old_name != new_name:
                    new_cls['original_name'] = old_name
                new_cls['namespace'] = cls.get('namespace', ns)

                # Rename parent
                old_parent = cls.get('parent', '')
                new_cls['parent'] = self.class_map.get(old_parent, old_parent)

                # Rename methods
                new_methods = []
                for m in cls.get('methods', []):
                    if isinstance(m, str):
                        renamed = self.class_method_map.get((old_name, m), m)
                        new_methods.append(renamed)
                    else:
                        new_methods.append(m)
                new_cls['methods'] = new_methods

                # Rename fields
                new_fields = []
                for f in cls.get('fields', []):
                    if isinstance(f, str):
                        renamed = self.class_field_map.get((old_name, f), f)
                        new_fields.append(renamed)
                    elif isinstance(f, dict):
                        fname = f.get('name', '')
                        renamed_name = self.class_field_map.get((old_name, fname), fname)
                        if renamed_name != fname:
                            new_f = dict(f)
                            new_f['name'] = renamed_name
                            new_f['original_name'] = fname
                            new_fields.append(new_f)
                        else:
                            new_fields.append(f)
                    else:
                        new_fields.append(f)
                new_cls['fields'] = new_fields

                # Copy method_pointers with renamed keys
                old_ptrs = cls.get('method_pointers', {})
                new_ptrs = {}
                for mk, mv in old_ptrs.items():
                    new_mk = self.class_method_map.get((old_name, mk), mk)
                    new_ptrs[new_mk] = mv
                new_cls['method_pointers'] = new_ptrs

                new_cls['va'] = cls.get('va', '')

                new_classes.append(new_cls)
            new_data['namespaces'][ns] = new_classes

        # Save JSON
        json_path = os.path.join(output_dir, 'deobfuscated_dump.json')
        print(f'  Writing {json_path}...')
        with open(json_path, 'w', encoding='utf-8') as f:
            json.dump(new_data, f, indent=2, ensure_ascii=False, sort_keys=True)
        json_size = os.path.getsize(json_path)
        print(f'    {json_size / 1024 / 1024:.1f} MB')

        # Save CS
        cs_path = os.path.join(output_dir, 'deobfuscated_dump.cs')
        print(f'  Writing {cs_path}...')
        self._write_cs(new_data, cs_path)
        cs_size = os.path.getsize(cs_path)
        print(f'    {cs_size / 1024 / 1024:.1f} MB')

        # Save mapping
        mapping_path = os.path.join(output_dir, 'name_mapping.json')
        print(f'  Writing {mapping_path}...')
        mapping = {
            'classes': {k: v for k, v in self.class_map.items()},
            'methods': {f'{cls}::{m}': new for (cls, m), new in self.class_method_map.items()},
            'fields': {f'{cls}::{f}': new for (cls, f), new in self.class_field_map.items()},
            'reverse_classes': {v: k for k, v in self.class_map.items()},
        }
        with open(mapping_path, 'w', encoding='utf-8') as f:
            json.dump(mapping, f, indent=2, ensure_ascii=False, sort_keys=True)

        # Save report
        report_path = os.path.join(output_dir, 'deobfuscation_report.md')
        self._write_report(report_path)

        print(f'\n  All output saved to {output_dir}/')

    def _write_cs(self, data: dict, path: str):
        """Generate C# stub file from deobfuscated data."""
        lines = []
        lines.append('// ============================================')
        lines.append('// VRChat IL2CPP Deobfuscated Dump')
        lines.append(f'// Classes renamed: {len(self.class_map)}')
        lines.append(f'// Methods renamed: {len(self.class_method_map)}')
        lines.append(f'// Fields renamed: {len(self.class_field_map)}')
        lines.append('// ============================================\n')

        for ns in sorted(data['namespaces'].keys()):
            classes = data['namespaces'][ns]
            if not classes:
                continue

            if ns:
                lines.append(f'namespace {ns}')
                lines.append('{')

            for cls in sorted(classes, key=lambda c: c['name']):
                indent = '    ' if ns else ''
                parent = cls.get('parent', '')
                original = cls.get('original_name', '')
                name = cls['name']

                # Comment with original name
                if original:
                    lines.append(f'{indent}// Originally: {original}')

                parent_str = f' : {parent}' if parent else ''
                lines.append(f'{indent}public class {name}{parent_str}')
                lines.append(f'{indent}{{')

                # Fields
                for f in cls.get('fields', []):
                    if isinstance(f, dict):
                        fname = f.get('name', str(f))
                        orig = f.get('original_name', '')
                        if orig:
                            lines.append(f'{indent}    {fname}; // was: {orig}')
                        else:
                            lines.append(f'{indent}    {fname};')
                    else:
                        lines.append(f'{indent}    {f};')

                # Methods
                ptrs = cls.get('method_pointers', {})
                for m in cls.get('methods', []):
                    ptr = ptrs.get(m, '')
                    ptr_comment = f' // {ptr}' if ptr else ''
                    lines.append(f'{indent}    void {m}();{ptr_comment}')

                lines.append(f'{indent}}}')
                lines.append('')

            if ns:
                lines.append('}')
                lines.append('')

        with open(path, 'w', encoding='utf-8') as f:
            f.write('\n'.join(lines))

    def _write_report(self, path: str):
        """Generate deobfuscation report."""
        total_obf = sum(1 for n in self.class_index if is_obf(n))
        semantic_named = total_obf - self.stats.get('phase7_fallback', 0)

        lines = [
            '# VRChat IL2CPP Deobfuscation Report\n',
            f'## Summary\n',
            f'| Metric | Count |',
            f'|--------|-------|',
            f'| Total obfuscated classes | {total_obf} |',
            f'| Semantically named | {semantic_named} ({100*semantic_named/total_obf:.1f}%) |',
            f'| Fallback-named (hash only) | {self.stats.get("phase7_fallback", 0)} |',
            f'| Methods renamed | {self.stats.get("methods_renamed", 0)} |',
            f'| Fields renamed | {self.stats.get("fields_renamed", 0)} |',
            '',
            '## Phase Breakdown\n',
            '| Phase | Description | Count |',
            '|-------|-------------|-------|',
        ]

        phase_labels = {
            'phase1_async': 'P1: Async State Machines',
            'phase1_enumerator': 'P1: Enumerators',
            'phase1_delegate': 'P1: Delegates',
            'phase1_displayclass': 'P1: Display Classes',
            'phase2_known_method': 'P2: Known Method Semantics',
            'phase2_semantic': 'P2: Semantic Word Analysis',
            'phase3_property': 'P3: Property-Driven',
            'phase4_unity': 'P4: Unity Components',
            'phase5_base': 'P5: Inheritance Base Classes',
            'phase5_child': 'P5: Inheritance Children',
            'phase6_crossref_parent': 'P6: Cross-Reference Parents',
            'phase6_known_parent': 'P6: Known Parent Derivation',
            'phase6b_shared': 'P6b: Shared Method Siblings',
            'phase6b_cluster': 'P6b: Method Frequency Clusters',
            'phase6c_binary': 'P6c: Binary String References',
            'phase6c_callgraph': 'P6c: Call Graph Domains',
            'phase7_fallback': 'P7: Fallback Structural',
        }

        for key, label in phase_labels.items():
            count = self.stats.get(key, 0)
            if count > 0:
                lines.append(f'| {label} | {count} |')

        lines.append('')
        lines.append('## Notable Renames\n')
        lines.append('Top renamed classes by method count:\n')

        # Show biggest renamed classes
        big_classes = []
        for old_name, new_name in self.class_map.items():
            if old_name in self.class_index:
                _, cls = self.class_index[old_name]
                mc = len(cls.get('methods', []))
                big_classes.append((new_name, old_name, mc))
        big_classes.sort(key=lambda x: -x[2])

        lines.append('| New Name | Methods | Original (truncated) |')
        lines.append('|----------|---------|----------------------|')
        for new, old, mc in big_classes[:30]:
            lines.append(f'| `{new}` | {mc} | `{old[:20]}...` |')

        with open(path, 'w', encoding='utf-8') as f:
            f.write('\n'.join(lines))
        print(f'  Report: {path}')

    # ── Run All Phases ─────────────────────────────────────────────────

    def run(self, output_dir: str):
        self.phase0_lifted_names()
        self.phase1_compiler_artifacts()
        self.phase6d_community_names()  # Community confirmed = highest priority
        self.phase2_semantic_methods()
        self.phase3_property_driven()
        self.phase4_unity_components()
        self.phase5_inheritance()
        self.phase6_cross_reference()
        self.phase6b_shared_methods()
        self.phase6c_binary_strings()
        self.phase7_fallback()
        self.rename_methods_and_fields()
        self.apply_and_save(output_dir)

        # Final summary
        total_obf = sum(1 for n in self.class_index if is_obf(n))
        named = len(self.class_map)
        fallback = self.stats.get('phase7_fallback', 0)
        semantic = named - fallback
        print(f'\n{"="*50}')
        print(f'DONE: {named}/{total_obf} obfuscated classes renamed')
        print(f'  Semantic names: {semantic} ({100*semantic/total_obf:.1f}%)')
        print(f'  Fallback names: {fallback} ({100*fallback/total_obf:.1f}%)')
        print(f'  Methods: {self.stats["methods_renamed"]}')
        print(f'  Fields: {self.stats["fields_renamed"]}')
        print(f'{"="*50}')


# ── Main ───────────────────────────────────────────────────────────────

if __name__ == '__main__':
    base = Path(__file__).parent
    input_path = base / 'il2cpp_full_dump' / 'precise_dump.json'
    output_dir = base / 'il2cpp_full_dump'

    if not input_path.exists():
        print(f'ERROR: {input_path} not found')
        sys.exit(1)

    deobf = Deobfuscator(str(input_path))
    deobf.run(str(output_dir))
