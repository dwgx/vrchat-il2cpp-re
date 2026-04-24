#!/usr/bin/env python3
"""
Deep mine v2 - Focused, quality-driven extraction of VRChat-relevant names
from client source repos for deobfuscation vocabulary.

Strategy:
1. Extract ALL type references (class, struct, interface, enum used in code)
2. Extract ALL method names that appear to be VRChat API calls
3. Extract ALL field/property names accessed on VRChat types
4. Extract enum values
5. Extract string literals (API endpoints, RPC names, type names)
6. Extract namespace names
7. Filter aggressively to keep only deobfuscation-relevant names
"""

import os
import re
import json
from pathlib import Path
from collections import defaultdict

BASE = Path("D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools")
CLIENT_SOURCES = BASE / "external" / "client-sources"
VOCAB_FILE = BASE / "output" / "master_vocabulary.json"

# ==================== COMPREHENSIVE EXTRACTION ====================

def extract_all_identifiers_from_csharp(content):
    """Extract every meaningful identifier from C# source."""
    names = set()

    # --- Type declarations ---
    for m in re.finditer(r'\b(?:class|struct|interface|enum)\s+(\w+)', content):
        names.add(m.group(1))

    # --- Namespace declarations ---
    for m in re.finditer(r'\bnamespace\s+([\w.]+)', content):
        ns = m.group(1)
        names.add(ns)
        for part in ns.split('.'):
            if len(part) > 1:
                names.add(part)

    # --- Using statements (full namespace paths) ---
    for m in re.finditer(r'\busing\s+(?:static\s+)?([\w.]+)\s*;', content):
        ns = m.group(1)
        names.add(ns)
        for part in ns.split('.'):
            if len(part) > 1:
                names.add(part)

    # --- Type references in code: typeof(X), X.Method, new X(), (X)cast, X variable ---
    # Capture PascalCase identifiers that are likely type names
    for m in re.finditer(r'\btypeof\s*\(\s*(\w+)', content):
        names.add(m.group(1))

    # --- Property/field access patterns: obj.prop_TYPE_N, field_TYPE_N ---
    # These are IL2CPP decompiler patterns revealing original type names
    for m in re.finditer(r'(?:prop|field)_(?:Public|Private|Protected|Internal)_(?:Static_)?(\w+?)_\d+', content):
        type_name = m.group(1)
        names.add(type_name)

    # More specific prop_ patterns
    for m in re.finditer(r'prop_(\w+?)_\d+', content):
        names.add(m.group(1))

    for m in re.finditer(r'field_(\w+?)_\d+', content):
        names.add(m.group(1))

    # --- Method name patterns from decompiled code ---
    # Method_Access_ReturnType_ParamTypes pattern
    for m in re.finditer(r'Method_(?:Public|Private|Protected|Internal)_(?:Static_)?(?:Virtual_)?(?:New_)?(?:Final_)?(\w+?)_', content):
        type_name = m.group(1)
        names.add(type_name)

    # Full method signature strings reveal return types and param types
    for m in re.finditer(r'"(Method_\w+)"', content):
        method_sig = m.group(1)
        names.add(method_sig)
        # Extract type parts
        parts = method_sig.split('_')
        for p in parts:
            if p and p[0].isupper() and len(p) > 2 and p not in ('Method', 'Public', 'Private', 'Protected', 'Internal', 'Static', 'Virtual', 'New', 'Final', 'Void', 'Boolean', 'String', 'Int32', 'Single', 'PDM'):
                names.add(p)

    # --- Type usage in generics ---
    for m in re.finditer(r'<\s*(\w+)(?:\s*,\s*(\w+))*\s*>', content):
        for g in m.groups():
            if g and len(g) > 1 and g[0].isupper():
                names.add(g)

    # --- Inheritance ---
    for m in re.finditer(r'(?:class|struct|interface)\s+\w+\s*(?:<[^>]+>)?\s*:\s*([^{]+)', content):
        bases = m.group(1)
        for b in re.finditer(r'(\w+)', bases):
            name = b.group(1)
            if len(name) > 1 and name[0].isupper() and name not in ('where', 'new', 'class', 'struct'):
                names.add(name)

    # --- Static method calls: TypeName.MethodName( ---
    for m in re.finditer(r'\b([A-Z]\w+)\.([A-Z]\w+)\s*\(', content):
        names.add(m.group(1))
        names.add(m.group(2))

    # --- Static field/property access: TypeName.FieldName ---
    for m in re.finditer(r'\b([A-Z]\w+)\.(field_\w+|prop_\w+)', content):
        names.add(m.group(1))

    # --- Cast patterns: .Cast<TypeName>() ---
    for m in re.finditer(r'\.Cast<(\w+)>', content):
        names.add(m.group(1))

    # --- TryCast patterns ---
    for m in re.finditer(r'\.TryCast<(\w+)>', content):
        names.add(m.group(1))

    # --- Enum value references: EnumType.Value ---
    for m in re.finditer(r'\b([A-Z]\w+)\.([A-Z]\w+)\b(?!\s*\()', content):
        t, v = m.group(1), m.group(2)
        if len(t) > 1 and len(v) > 1:
            names.add(t)
            names.add(v)

    # --- Enum declarations with values ---
    for m in re.finditer(r'\benum\s+(\w+)\s*(?::\s*\w+\s*)?\{([^}]+)\}', content, re.DOTALL):
        names.add(m.group(1))
        body = m.group(2)
        for ev in re.finditer(r'(\w+)\s*(?:=|,|$)', body):
            if len(ev.group(1)) > 1:
                names.add(ev.group(1))

    # --- String literals that are meaningful ---
    for m in re.finditer(r'"([^"\\]{2,200})"', content):
        s = m.group(1)
        # RPC names
        if s.endswith('RPC') or s.endswith('Rpc'):
            names.add(s)
        # Method signature patterns
        elif s.startswith('Method_'):
            names.add(s)
        # VRChat-specific strings
        elif any(s.startswith(p) for p in ('VRC', 'VRC_', 'Api', 'vrc', 'api/')):
            names.add(s)
        # PascalCase type names (no spaces, no special chars)
        elif re.match(r'^[A-Z][a-zA-Z0-9]+$', s) and len(s) > 3:
            names.add(s)
        # Namespaced type names
        elif re.match(r'^[A-Z][\w]+(?:\.[A-Z][\w]+)+$', s):
            names.add(s)
        # GameObject paths that reveal VRChat UI structure
        elif s.startswith('UserInterface/') or s.startswith('Player ') or 'Menu' in s or 'Canvas' in s:
            names.add(s)
        # Tags
        elif s.startswith('admin_') or s.startswith('system_') or s.startswith('show_'):
            names.add(s)

    # --- Attribute names ---
    for m in re.finditer(r'\[(\w+?)(?:Attribute)?\s*(?:\(|])', content):
        name = m.group(1)
        if len(name) > 2 and name[0].isupper():
            names.add(name)

    # --- Delegate type references ---
    for m in re.finditer(r'\bdelegate\s+[\w<>\[\],\s]+\s+(\w+)\s*\(', content):
        names.add(m.group(1))

    # --- Event declarations ---
    for m in re.finditer(r'\bevent\s+(\w+)', content):
        names.add(m.group(1))

    # --- FindObjectsOfType<T> patterns ---
    for m in re.finditer(r'FindObjectsOfType(?:All)?<(\w+)>', content):
        names.add(m.group(1))

    # --- GetComponent<T> patterns ---
    for m in re.finditer(r'GetComponent(?:InChildren|InParent)?<(\w+)>', content):
        names.add(m.group(1))

    # --- Variable declarations with type names ---
    for m in re.finditer(r'\b([A-Z]\w+)\s+\w+\s*=', content):
        name = m.group(1)
        if len(name) > 2:
            names.add(name)

    # --- Method parameters with type names ---
    for m in re.finditer(r'(?:ref\s+|out\s+|in\s+)?([A-Z]\w+)\s+__\d+', content):
        names.add(m.group(1))

    return names


def extract_all_identifiers_from_cpp(content):
    """Extract VRChat-relevant identifiers from C++ source."""
    names = set()

    # --- Class/struct names ---
    for m in re.finditer(r'\b(?:class|struct)\s+(\w+)', content):
        names.add(m.group(1))

    # --- Namespace names ---
    for m in re.finditer(r'\bnamespace\s+([\w:]+)', content):
        for part in m.group(1).split('::'):
            if len(part) > 1:
                names.add(part)

    # --- Enum declarations ---
    for m in re.finditer(r'\benum\s+(?:class\s+)?(\w+)', content):
        names.add(m.group(1))

    for m in re.finditer(r'\benum\s+(?:class\s+)?\w+\s*(?::\s*\w+\s*)?\{([^}]+)\}', content, re.DOTALL):
        for ev in re.finditer(r'(\w+)\s*(?:=|,|$)', m.group(1)):
            if len(ev.group(1)) > 1:
                names.add(ev.group(1))

    # --- Function/method names ---
    for m in re.finditer(r'(?:static\s+)?(?:virtual\s+)?(?:inline\s+)?(?:[\w:*&<>]+)\s+(\w+)\s*\([^)]*\)\s*(?:\{|;|const)', content):
        name = m.group(1)
        if len(name) > 2 and name not in ('if', 'for', 'while', 'switch', 'return', 'sizeof', 'main'):
            names.add(name)

    # --- Member access ---
    for m in re.finditer(r'(?:->|\.)\s*(\w+)', content):
        name = m.group(1)
        if len(name) > 2:
            names.add(name)

    # --- String literals ---
    for m in re.finditer(r'"([^"\\]{2,200})"', content):
        s = m.group(1)
        if re.match(r'^[A-Z][a-zA-Z0-9]+$', s) and len(s) > 3:
            names.add(s)
        elif re.match(r'^[A-Z][\w]+(?:\.[A-Z][\w]+)+$', s):
            names.add(s)
        elif any(s.startswith(p) for p in ('VRC', 'Api', 'vrc')):
            names.add(s)

    # --- #define names ---
    for m in re.finditer(r'#define\s+(\w+)', content):
        names.add(m.group(1))

    # --- typedef/using aliases ---
    for m in re.finditer(r'(?:typedef|using)\s+(\w+)\s*=', content):
        names.add(m.group(1))

    # --- Comment references to C# types ---
    for m in re.finditer(r'//.*?([A-Z][a-zA-Z]+(?:[A-Z][a-zA-Z]+)+)', content):
        names.add(m.group(1))

    return names


# ==================== FILTERING ====================

# Comprehensive exclusion sets
CSHARP_KEYWORDS = {
    'if', 'else', 'for', 'while', 'do', 'switch', 'case', 'break', 'continue',
    'return', 'void', 'int', 'bool', 'float', 'double', 'string', 'byte', 'char',
    'long', 'short', 'uint', 'ulong', 'ushort', 'sbyte', 'decimal', 'object',
    'var', 'new', 'null', 'true', 'false', 'this', 'base', 'class', 'struct',
    'enum', 'interface', 'abstract', 'virtual', 'override', 'sealed', 'static',
    'const', 'readonly', 'volatile', 'extern', 'ref', 'out', 'in', 'params',
    'public', 'private', 'protected', 'internal', 'get', 'set', 'value', 'where',
    'async', 'await', 'yield', 'try', 'catch', 'finally', 'throw', 'using',
    'namespace', 'delegate', 'event', 'is', 'as', 'typeof', 'sizeof', 'nameof',
    'checked', 'unchecked', 'fixed', 'unsafe', 'lock', 'goto', 'default',
    'implicit', 'explicit', 'operator', 'partial', 'dynamic', 'when',
}

CPP_KEYWORDS = {
    'auto', 'register', 'template', 'typename', 'friend', 'mutable', 'constexpr',
    'noexcept', 'nullptr', 'delete', 'sizeof', 'alignof', 'decltype', 'inline',
    'unsigned', 'signed', 'const', 'static', 'extern', 'volatile', 'virtual',
    'override', 'final', 'public', 'private', 'protected', 'typedef', 'using',
}

# Common .NET / Unity types that are NOT VRChat-specific
# We KEEP these because they help with deobfuscation matching
STANDARD_DOTNET = {
    'Void', 'Boolean', 'Int32', 'Int64', 'Int16', 'UInt32', 'UInt64', 'UInt16',
    'Single', 'Double', 'Byte', 'SByte', 'Char', 'String', 'Object', 'Decimal',
}

# Noise patterns to exclude
NOISE_PATTERNS = [
    r'^[a-z]{1,4}$',           # Very short lowercase
    r'^_+\w*$',                # Leading underscores
    r'^0x[0-9a-fA-F]+$',      # Hex addresses
    r'^\d+[UuLl]*$',          # Pure numbers
    r'^[A-Z]{1,3}$',          # Very short ALL_CAPS
    r'^ns\d+$',               # Obfuscated namespaces (ns1, ns100)
    r'^GClass\d+$',           # Obfuscated classes
    r'^GStruct\d+$',          # Obfuscated structs
    r'^GEnum\d+$',            # Obfuscated enums
    r'^GDelegate\d+$',        # Obfuscated delegates
    r'^Class\d+$',            # Obfuscated classes
    r'^[a-z]\d+$',            # a1, b2 etc.
    r'^__\d+$',               # __0, __1 etc.
    r'^\w*Attribute$',        # Keep these actually
]
NOISE_REGEXES = [re.compile(p) for p in NOISE_PATTERNS[:-1]]  # Skip Attribute filter

# Client-mod-specific names to exclude (not VRChat internal)
MOD_SPECIFIC = {
    'MunchenClient', 'MunchenClientLocal', 'AbyssClient', 'Void', 'VRTool',
    'ConsoleUtils', 'Configuration', 'ModuleManager', 'ModuleComponent',
    'PatchComponent', 'PatchManager', 'AssetLoader', 'LanguageManager',
    'ConsoleColor', 'FastMethodInfo', 'PerformanceProfiler', 'DependencyDownload',
    'DependencyDownloader', 'CompatibilityLayer', 'EngineCompatibilityChecker',
    'OculusCompatibilityChecker', 'ColorConfig', 'GeneralConfig', 'MiscUtils',
    'PlayerUtils', 'WorldUtils', 'GeneralUtils', 'PlayerInformation',
    'AudioUtils', 'CustomContractResolver', 'LanguageConfig', 'LovenseConfig',
    'AdminPanelMenu', 'ApplicationBotHandler', 'CameraFeaturesHandler',
    'FlashlightHandler', 'GlobalDynamicBonesHandler', 'KeybindHandler',
    'MenuColorHandler', 'MimicHandler', 'PortableMirrorMenu',
    'HttpClientWrapper', 'Event1Wrapper', 'Event7Wrapper',
}

# C++ standard library noise
CPP_STDLIB = {
    'std', 'vector', 'string', 'pair', 'tuple', 'map', 'set', 'list',
    'unique_ptr', 'shared_ptr', 'weak_ptr', 'make_unique', 'make_shared',
    'move', 'forward', 'size_t', 'nullptr_t', 'ptrdiff_t',
    'printf', 'sprintf', 'fprintf', 'scanf', 'malloc', 'free', 'calloc', 'realloc',
    'memcpy', 'memset', 'memmove', 'memcmp', 'strlen', 'strcmp', 'strcpy', 'strcat',
    'strstr', 'strtol', 'strtod', 'atoi', 'atof', 'abort', 'exit', 'atexit',
    'main', 'argc', 'argv', 'cout', 'cin', 'endl', 'cerr',
    'true', 'false', 'NULL', 'EOF',
    'FILE', 'size_t', 'time_t', 'clock_t',
    'DWORD', 'HANDLE', 'HMODULE', 'LPVOID', 'BOOL', 'BYTE', 'WORD',
    'INT', 'UINT', 'LONG', 'ULONG', 'CHAR', 'WCHAR', 'TCHAR',
    'TRUE', 'FALSE', 'INVALID_HANDLE_VALUE',
}

# Crypto library names (from libsodium/NaCl bundled in Void-Public)
CRYPTO_NOISE_PREFIXES = [
    'AES', 'AEAD', 'SHA', 'HMAC', 'ChaCha', 'Poly', 'Salsa', 'XSalsa',
    'Ed25519', 'Curve25519', 'X25519', 'HKDF', 'PBKDF', 'Argon',
    'Scrypt', 'Blake', 'SipHash', 'Gimli',
    'crypto_', 'sodium_', 'randombytes_',
    'fe_', 'ge_', 'sc_',
]


def is_relevant_name(name):
    """Check if a name is relevant for VRChat deobfuscation."""
    # Skip keywords
    if name in CSHARP_KEYWORDS or name in CPP_KEYWORDS or name in CPP_STDLIB:
        return False

    # Skip mod-specific names
    if name in MOD_SPECIFIC:
        return False

    # Skip noise patterns
    for regex in NOISE_REGEXES:
        if regex.match(name):
            return False

    # Skip very short names
    if len(name) <= 2:
        return False

    # Skip crypto library noise
    for prefix in CRYPTO_NOISE_PREFIXES:
        if name.startswith(prefix):
            return False

    # Skip names with spaces (they're UI paths, keep only meaningful ones)
    if ' ' in name and not any(kw in name for kw in ('Menu', 'UserInterface', 'Player', 'Avatar', 'VRC', 'Nameplate', 'Quick', 'World')):
        return False

    # Skip pure numbers
    if name.isdigit():
        return False

    # Skip all-lowercase short names
    if name.islower() and len(name) <= 5:
        return False

    return True


# ==================== VRC-SPECIFIC HIGH-VALUE PATTERNS ====================

VRC_HIGH_VALUE_PREFIXES = [
    'VRC', 'VRC_', 'Vrc', 'Api', 'API',
    'Player', 'Avatar', 'World', 'Instance',
    'Photon', 'Udon', 'USpeaker', 'USpeak',
    'Network', 'Room', 'Portal', 'Moderation',
    'SDK', 'VRCSDK', 'Haptic', 'Tracking',
    'InputController', 'Locomotion',
    'Nameplate', 'QuickMenu', 'ActionMenu',
    'FlatBuffer', 'Serializ',
    'DynamicBone', 'FinalIK',
    'Il2Cpp', 'il2cpp_',
    'Oculus', 'Steam', 'XR',
    'Photon', 'PUN', 'Realtime',
    'Page', 'Panel', 'Popup', 'Menu',
    'Download', 'Upload', 'AssetBundle',
    'Cache', 'Auth', 'Token', 'Session',
    'Friend', 'Favorite', 'Notification',
    'Trust', 'Rank', 'Tag', 'Badge',
    'Permission', 'Config', 'Setting',
    'Camera', 'Mirror', 'Video', 'Audio',
    'Emote', 'Emoji', 'Gesture',
    'IK', 'Calibrat', 'Bone',
    'Performance', 'Safety', 'Shield',
    'Content', 'Asset', 'Bundle',
    'Region', 'Relay', 'Voice',
    'Animation', 'Animator', 'Layer',
    'Spawn', 'Respawn', 'Teleport',
    'Pickup', 'Interact', 'Trigger',
    'Station', 'Chair', 'Seat',
    'Sandbox', 'Object', 'Component',
    'Sync', 'Ownership', 'RPC',
    'Event', 'Handler', 'Callback', 'Listener',
    'UI', 'HUD', 'Canvas',
    'Social', 'User', 'Profile', 'Bio',
    'Group', 'Team', 'Invite',
    'Image', 'Texture', 'Icon', 'Thumbnail',
    'Loading', 'Splash', 'Boot',
    'Error', 'Warning', 'Info', 'Log',
    'Shader', 'Material', 'Render', 'Light',
    'Particle', 'Trail', 'Line',
    'Cloth', 'Physics', 'Collider',
    'Nav', 'Path', 'Waypoint',
    'Script', 'Behaviour', 'Manager',
    'Factory', 'Builder', 'Provider',
    'Service', 'Controller', 'System',
    'State', 'Machine', 'Transition',
    'Buffer', 'Stream', 'Packet',
    'Encode', 'Decode', 'Compress',
    'Encrypt', 'Decrypt', 'Hash',
    'Platform', 'Device', 'Input',
]


def main():
    all_names = set()
    repo_names = defaultdict(set)

    # ==================== Mine MunchenClient (C#, clean names) ====================
    print("=" * 60)
    print("Mining MunchenClient (263 C# files, clean names)...")
    print("=" * 60)
    munchen_path = CLIENT_SOURCES / "MunchenClient"
    for cs_file in sorted(munchen_path.rglob("*.cs")):
        try:
            content = cs_file.read_text(encoding='utf-8', errors='ignore')
            names = extract_all_identifiers_from_csharp(content)
            all_names.update(names)
            repo_names['MunchenClient'].update(names)
        except Exception as e:
            print(f"  Error reading {cs_file}: {e}")
    print(f"  Extracted {len(repo_names['MunchenClient'])} raw names")

    # ==================== Mine AbyssClient (C#, partially obfuscated) ====================
    print("\n" + "=" * 60)
    print("Mining AbyssClient (562 C# files, partially obfuscated)...")
    print("=" * 60)
    abyss_path = CLIENT_SOURCES / "AbyssClient"
    for cs_file in sorted(abyss_path.rglob("*.cs")):
        try:
            content = cs_file.read_text(encoding='utf-8', errors='ignore')
            names = extract_all_identifiers_from_csharp(content)
            all_names.update(names)
            repo_names['AbyssClient'].update(names)
        except Exception as e:
            print(f"  Error reading {cs_file}: {e}")
    print(f"  Extracted {len(repo_names['AbyssClient'])} raw names")

    # ==================== Mine Void-Public (C++, VRChat type models) ====================
    print("\n" + "=" * 60)
    print("Mining Void-Public (872 C/C++ files, VRChat type models)...")
    print("=" * 60)
    void_path = CLIENT_SOURCES / "Void-Public"
    for src_file in sorted(list(void_path.rglob("*.cpp")) + list(void_path.rglob("*.hpp")) + list(void_path.rglob("*.h"))):
        try:
            content = src_file.read_text(encoding='utf-8', errors='ignore')
            names = extract_all_identifiers_from_cpp(content)
            all_names.update(names)
            repo_names['Void-Public'].update(names)
        except Exception as e:
            print(f"  Error reading {src_file}: {e}")
    print(f"  Extracted {len(repo_names['Void-Public'])} raw names")

    print(f"\nTotal raw names from all repos: {len(all_names)}")

    # ==================== Filter ====================
    print("\nFiltering...")
    filtered = {name for name in all_names if is_relevant_name(name)}
    print(f"After filtering: {len(filtered)}")

    # ==================== Load existing vocab ====================
    with open(VOCAB_FILE, 'r', encoding='utf-8') as f:
        vocab = json.load(f)

    existing = set(vocab.get('names', []))
    print(f"Existing vocabulary: {len(existing)} names")

    new_names = filtered - existing
    print(f"New names to add: {len(new_names)}")

    # ==================== Categorize new names ====================
    categories = defaultdict(list)
    for name in sorted(new_names):
        categorized = False
        # VRC-specific
        if any(name.startswith(p) for p in ('VRC', 'Vrc', 'VRC_')):
            categories['VRC_types'].append(name)
            categorized = True
        elif any(name.startswith(p) for p in ('Api', 'API')):
            categories['API_types'].append(name)
            categorized = True
        elif any(name.startswith(p) for p in ('Player', 'Avatar', 'World', 'Instance')):
            categories['Core_types'].append(name)
            categorized = True
        elif any(name.startswith(p) for p in ('Photon', 'Network', 'Room', 'Udon', 'USpeaker')):
            categories['Network_types'].append(name)
            categorized = True
        elif any(name.startswith(p) for p in ('Il2Cpp', 'il2cpp_', 'IL2CPP')):
            categories['IL2CPP'].append(name)
            categorized = True
        elif name.startswith('Method_') or name.endswith('RPC'):
            categories['Method_sigs'].append(name)
            categorized = True
        elif '/' in name or name.startswith('UserInterface'):
            categories['UI_paths'].append(name)
            categorized = True
        elif '.' in name:
            categories['Qualified_names'].append(name)
            categorized = True
        elif name.startswith('prop_') or name.startswith('field_'):
            categories['IL2CPP_fields'].append(name)
            categorized = True

        if not categorized:
            categories['Other'].append(name)

    print(f"\n{'='*60}")
    print("NEW NAMES BY CATEGORY")
    print(f"{'='*60}")
    for cat in sorted(categories.keys()):
        items = categories[cat]
        print(f"\n--- {cat} ({len(items)} names) ---")
        for name in items[:30]:
            print(f"  {name}")
        if len(items) > 30:
            print(f"  ... and {len(items) - 30} more")

    # ==================== Update vocabulary ====================
    merged = sorted(existing | filtered)
    vocab['names'] = merged
    vocab['unique_names'] = len(merged)
    vocab['total_signatures'] = len(merged)
    vocab['deep_mine_v2_stats'] = {
        'raw_extracted': len(all_names),
        'after_filter': len(filtered),
        'new_added': len(new_names),
        'previous_count': len(existing),
        'new_total': len(merged),
        'by_repo': {
            'MunchenClient': len(repo_names['MunchenClient']),
            'AbyssClient': len(repo_names['AbyssClient']),
            'Void-Public': len(repo_names['Void-Public']),
        },
        'by_category': {cat: len(items) for cat, items in categories.items()},
    }

    with open(VOCAB_FILE, 'w', encoding='utf-8') as f:
        json.dump(vocab, f, indent=2, ensure_ascii=False)

    # Save new names for review
    review_file = BASE / "output" / "mined_new_names_v2.json"
    with open(review_file, 'w', encoding='utf-8') as f:
        json.dump({
            'count': len(new_names),
            'categories': {cat: items for cat, items in sorted(categories.items())},
            'all_new': sorted(new_names),
        }, f, indent=2, ensure_ascii=False)

    print(f"\n{'='*60}")
    print(f"SUMMARY")
    print(f"{'='*60}")
    print(f"Previous vocabulary: {len(existing)} names")
    print(f"New names added:     {len(new_names)} names")
    print(f"New total:           {len(merged)} names")
    print(f"Saved to: {VOCAB_FILE}")
    print(f"Review:   {review_file}")


if __name__ == '__main__':
    main()
