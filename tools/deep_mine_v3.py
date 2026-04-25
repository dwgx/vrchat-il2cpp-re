#!/usr/bin/env python3
"""
Deep mine v3 - Clean, focused extraction from client source repos.
Rebuilds vocabulary from original sources + fresh mining.

Only extracts names that are genuinely useful for IL2CPP deobfuscation:
- VRChat-internal type names (classes, structs, interfaces, enums)
- VRChat-internal method names
- VRChat-internal field/property names
- VRChat-internal namespace names
- VRChat API endpoint strings and RPC names
- Method signature patterns from decompiled code
"""

import os
import re
import json
import sys
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE = Path("D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools")
CLIENT_SOURCES = BASE / "external" / "client-sources"
VOCAB_FILE = BASE / "output" / "master_vocabulary.json"


# ======================================================================
# STEP 1: Reconstruct original vocabulary from source JSON files
# ======================================================================

def load_original_vocabulary():
    """Load the original 2,889-name vocabulary from the source JSON files."""
    names = set()

    # structural_matches.json has community_vocabulary (1880 names)
    struct = json.load(open(BASE / 'output' / 'structural_matches.json', 'r', encoding='utf-8'))
    cv = struct.get('community_vocabulary', [])
    names.update(cv)
    print(f"  From structural_matches community_vocabulary: {len(cv)}")

    # community_name_mapping.json
    comm = json.load(open(BASE / 'output' / 'community_name_mapping.json', 'r', encoding='utf-8'))
    if 'unique_names' in comm and isinstance(comm['unique_names'], list):
        names.update(comm['unique_names'])
        print(f"  From community_name_mapping unique_names: {len(comm['unique_names'])}")
    if 'by_parent' in comm:
        for parent, child_names in comm['by_parent'].items():
            if parent:
                names.add(parent)
            if isinstance(child_names, list):
                names.update(child_names)

    # mod_extracted_names.json
    mod = json.load(open(BASE / 'output' / 'mod_extracted_names.json', 'r', encoding='utf-8'))
    for key in ['class_names_from_mods', 'all_class_names']:
        if key in mod and isinstance(mod[key], list):
            count_before = len(names)
            names.update(mod[key])
            print(f"  From mod_extracted_names.{key}: {len(names) - count_before} new")

    # additional_names.json
    addi = json.load(open(BASE / 'output' / 'additional_names.json', 'r', encoding='utf-8'))
    for key in ['class_names', 'method_names', 'namespaces', 'layer_names', 'ui_paths', 'social_menu_buttons']:
        val = addi.get(key, [])
        if isinstance(val, list):
            count_before = len(names)
            names.update(val)
            print(f"  From additional_names.{key}: {len(names) - count_before} new")
        elif isinstance(val, dict):
            count_before = len(names)
            for k, v in val.items():
                if isinstance(v, str):
                    names.add(v)
                elif isinstance(v, list):
                    names.update(v)
            print(f"  From additional_names.{key}: {len(names) - count_before} new")

    if 'singleton_instances' in addi and isinstance(addi['singleton_instances'], dict):
        for k, v in addi['singleton_instances'].items():
            if isinstance(v, str):
                names.add(v)

    if 'obfuscated_field_patterns' in addi and isinstance(addi['obfuscated_field_patterns'], dict):
        for k, patterns in addi['obfuscated_field_patterns'].items():
            if isinstance(patterns, list):
                for p in patterns:
                    if isinstance(p, dict):
                        for pkey, pval in p.items():
                            if isinstance(pval, str) and len(pval) > 1 and pval[0:1].isupper():
                                names.add(pval)

    # Clean up: remove empty, descriptive strings, etc.
    cleaned = set()
    for n in names:
        if not n or not isinstance(n, str):
            continue
        if len(n) <= 1:
            continue
        # Skip descriptive comments that snuck in
        if n.startswith('(') or '(' in n and len(n) > 50:
            continue
        cleaned.add(n)

    return cleaned


# ======================================================================
# STEP 2: Mine C# sources
# ======================================================================

def mine_csharp_file(filepath):
    """Extract deobfuscation-relevant names from a C# file."""
    try:
        content = Path(filepath).read_text(encoding='utf-8', errors='ignore')
    except:
        return set()

    names = set()

    # --- Using statements (reveal VRChat namespaces) ---
    for m in re.finditer(r'\busing\s+(?:static\s+)?([\w.]+)\s*;', content):
        ns = m.group(1)
        # Only keep VRC-related or game-specific namespaces
        if any(p in ns for p in ('VRC', 'Photon', 'TMPro', 'Il2Cpp', 'Unhollower', 'MelonLoader', 'ExitGames')):
            names.add(ns)
            for part in ns.split('.'):
                if len(part) > 2:
                    names.add(part)

    # --- Type declarations ---
    for m in re.finditer(r'\b(?:class|struct|interface|enum)\s+(\w+)', content):
        name = m.group(1)
        if len(name) > 2 and not re.match(r'^(GClass|GStruct|GEnum|GDelegate|Class)\d+$', name):
            names.add(name)

    # --- Namespace declarations ---
    for m in re.finditer(r'\bnamespace\s+([\w.]+)', content):
        ns = m.group(1)
        if not re.match(r'^ns\d+$', ns):
            names.add(ns)
            for part in ns.split('.'):
                if len(part) > 2 and not re.match(r'^ns\d+$', part):
                    names.add(part)

    # --- typeof() references ---
    for m in re.finditer(r'\btypeof\s*\(\s*(\w+(?:\.\w+)*)', content):
        t = m.group(1)
        names.add(t)
        for part in t.split('.'):
            if len(part) > 2:
                names.add(part)

    # --- IL2CPP decompiler property/field access patterns ---
    # prop_TYPE_N reveals the original type name
    for m in re.finditer(r'prop_(\w+?)_\d+', content):
        names.add(m.group(1))

    # field_Access_TYPE_N
    for m in re.finditer(r'field_(?:Public|Private|Protected|Internal)_(?:Static_)?(\w+?)_\d+', content):
        names.add(m.group(1))

    # field_TYPE_N (shorter form)
    for m in re.finditer(r'field_(\w+?)_\d+', content):
        t = m.group(1)
        if t not in ('Private', 'Public', 'Protected', 'Internal', 'Static'):
            names.add(t)

    # --- Method signature patterns ---
    for m in re.finditer(r'Method_(?:Public|Private|Protected|Internal|FamOrAssem)_(?:Static_)?(?:Virtual_)?(?:New_)?(?:Final_)?(\w+?)_', content):
        t = m.group(1)
        if t not in ('Void', 'Boolean', 'String', 'Int32', 'Single', 'PDM'):
            names.add(t)

    # Full method signature strings
    for m in re.finditer(r'"(Method_\w+)"', content):
        sig = m.group(1)
        names.add(sig)
        # Extract type names from the signature
        for part in sig.split('_'):
            if part and part[0].isupper() and len(part) > 3 and part not in (
                'Method', 'Public', 'Private', 'Protected', 'Internal', 'Static',
                'Virtual', 'New', 'Final', 'Void', 'Boolean', 'String', 'Int32',
                'Single', 'Double', 'Byte', 'Char', 'PDM', 'Type', 'ArrayOf',
                'Action', 'List', 'Dictionary', 'Nullable', 'Object', 'IntPtr',
                'FamOrAssem', 'UniTask'
            ):
                names.add(part)

    # --- Static type access: TypeName.method/field ---
    for m in re.finditer(r'\b([A-Z]\w{2,})\.(?:Method_|field_|prop_|Get|Set|Find|Create|Load)', content):
        names.add(m.group(1))

    # --- Static method calls ---
    for m in re.finditer(r'\b([A-Z]\w{2,})\.\w+\s*\(', content):
        name = m.group(1)
        if not re.match(r'^(GClass|Class)\d+$', name):
            names.add(name)

    # --- Cast patterns ---
    for m in re.finditer(r'\.(?:Cast|TryCast)<(\w+)>', content):
        names.add(m.group(1))

    # --- Generic type references ---
    for m in re.finditer(r'<\s*(\w+)\s*>', content):
        name = m.group(1)
        if len(name) > 2 and name[0].isupper():
            names.add(name)

    # --- Inheritance ---
    for m in re.finditer(r'(?:class|struct|interface)\s+\w+\s*(?:<[^>]+>)?\s*:\s*([^\n{]+)', content):
        bases = m.group(1)
        for b in re.finditer(r'\b([A-Z]\w{2,})\b', bases):
            name = b.group(1)
            if name not in ('where', 'new', 'class', 'struct'):
                names.add(name)

    # --- FindObjectsOfType / GetComponent patterns ---
    for m in re.finditer(r'(?:FindObjectsOfType(?:All)?|GetComponent(?:InChildren|InParent)?)\s*<\s*(\w+)\s*>', content):
        names.add(m.group(1))

    # --- Variable type declarations (VRChat types) ---
    for m in re.finditer(r'\b(VRC\w+|Api\w+|Player\w+|Avatar\w+|World\w+|Photon\w+|Udon\w+|USpeaker\w*|VRCPlayer\w*|APIUser\w*|NetworkManager\w*|RoomManager\w*|ModerationManager\w*|FlatBuffer\w*|ImageThreeSlice\w*|HighlightsFX\w*|GamelikeInputController\w*|PlayerSelector\w*|VRCTrackingManager\w*|VRCVrCamera\w*|VRCUi\w+|PageAvatar\w*|PageUserInfo\w*|PageWorldInfo\w*|SelectedUserMenu\w*|UserCameraController\w*|PortalInternal\w*|VRCAvatarManager\w*|PlayerNet\w*|VRCNetworkBehaviour\w*)\b', content):
        names.add(m.group(1))

    # --- String literals: RPC names ---
    for m in re.finditer(r'"(\w+RPC)"', content):
        names.add(m.group(1))

    # --- String literals: VRChat-specific strings ---
    for m in re.finditer(r'"([^"]{3,100})"', content):
        s = m.group(1)
        # Keep RPC names
        if s.endswith('RPC') or s.endswith('Rpc'):
            names.add(s)
        # Keep method check patterns
        elif s.startswith('OnPlayer') or s.startswith('OnJoined') or s.startswith('OnLeft') or s.startswith('OnMaster'):
            names.add(s)
        # Keep VRChat UI paths
        elif s.startswith('UserInterface/'):
            names.add(s)
        # Keep tag names
        elif s.startswith('admin_') or s.startswith('system_') or s.startswith('show_'):
            names.add(s)
        # Keep assembly-qualified type names
        elif re.match(r'^VRC\.\w+\.\w+,\s*\w+', s):
            names.add(s)
        # Keep clean PascalCase type names (no spaces, likely VRChat internal)
        elif re.match(r'^[A-Z][a-zA-Z0-9]+$', s) and len(s) > 4:
            # Only if it looks like a type name
            if any(s.startswith(p) for p in ('VRC', 'Api', 'Player', 'Avatar', 'World', 'Network', 'Room', 'Udon', 'Photon', 'UI', 'Page', 'Menu', 'Portal', 'Mirror', 'Camera', 'Audio', 'Emote', 'Emoji', 'Gesture', 'Haptic', 'Tracking', 'IK', 'Bone', 'Dynamic', 'Performance', 'Safety', 'Trust', 'Rank', 'Friend', 'Favorite', 'Notification', 'Download', 'Upload', 'Asset', 'Bundle', 'Config', 'Setting', 'Permission', 'Content', 'Session', 'Auth', 'Token', 'Region', 'Relay', 'Voice', 'Spawn', 'Respawn', 'Teleport', 'Pickup', 'Interact', 'Trigger', 'Station', 'Sync', 'Ownership', 'Event', 'Handler', 'Callback', 'Social', 'User', 'Profile', 'Group', 'Invite', 'Image', 'Loading', 'Shader', 'Material', 'Render', 'Particle', 'Cloth', 'Nav', 'Script', 'Behaviour', 'Manager', 'Factory', 'Builder', 'Provider', 'Service', 'Controller', 'System', 'State', 'Buffer', 'Stream', 'Packet', 'Encode', 'Decode', 'Platform', 'Device', 'Input', 'Badge', 'Tag', 'Quest', 'Standalone', 'Android', 'Oculus', 'Steam', 'Quick', 'Action', 'SDK', 'VRCSDK', 'Flat', 'Binary', 'Serializ', 'Canvas', 'HUD', 'Reticle', 'Nameplate', 'Log', 'Warning', 'Error', 'Info')):
                names.add(s)

    # --- Enum values ---
    for m in re.finditer(r'\benum\s+(\w+)\s*(?::\s*\w+\s*)?\{([^}]+)\}', content, re.DOTALL):
        enum_name = m.group(1)
        if not re.match(r'^GEnum\d+$', enum_name):
            names.add(enum_name)
            body = m.group(2)
            for ev in re.finditer(r'(\w+)\s*(?:=|,)', body):
                val = ev.group(1)
                if len(val) > 2:
                    names.add(val)

    # --- Enum.Value references for VRChat enums ---
    for m in re.finditer(r'\b(VRC_EventHandler|VRC_EventLog|VrcBroadcastType|VrcEventType|VrcTargetType|DeveloperType|PlayerRankStatus|AvatarKind|AvatarCloneType|RPC)\s*\.\s*(\w+)', content):
        names.add(m.group(1))
        names.add(m.group(2))

    # --- Attribute usage ---
    for m in re.finditer(r'\[(Serialize\w+|Header|Tooltip|Range|HideInInspector|FormerlySerializedAs|Obsolete|RequireComponent)\b', content):
        names.add(m.group(1))

    return names


def mine_cpp_file(filepath):
    """Extract deobfuscation-relevant names from C++ VRChat-modeling code."""
    try:
        content = Path(filepath).read_text(encoding='utf-8', errors='ignore')
    except:
        return set()

    names = set()

    # --- Struct/class declarations ---
    for m in re.finditer(r'\b(?:class|struct)\s+(\w+)', content):
        name = m.group(1)
        if len(name) > 2:
            names.add(name)

    # --- Namespace declarations ---
    for m in re.finditer(r'\bnamespace\s+([\w:]+)', content):
        for part in m.group(1).split('::'):
            if len(part) > 2:
                names.add(part)

    # --- Function/method names ---
    for m in re.finditer(r'(?:static\s+)?(?:[\w:*&<>]+)\s+(\w+)\s*\([^)]*\)', content):
        name = m.group(1)
        if len(name) > 3 and name not in ('main', 'sizeof', 'return', 'if', 'for', 'while', 'switch'):
            names.add(name)

    # --- Member access (reveals VRChat field/method names) ---
    for m in re.finditer(r'(?:->|\.)\s*(\w+)\s*\(', content):
        name = m.group(1)
        if len(name) > 3:
            names.add(name)

    # --- String literals with VRChat type info ---
    for m in re.finditer(r'"([^"]{3,80})"', content):
        s = m.group(1)
        # Assembly-qualified names
        if re.match(r'^VRC[\w.]+$', s):
            names.add(s)
        # Clean type names
        elif re.match(r'^[A-Z][a-zA-Z0-9]+$', s) and len(s) > 4:
            names.add(s)
        # Dotted namespaces
        elif re.match(r'^[\w]+(?:\.[\w]+)+$', s) and 'VRC' in s:
            names.add(s)

    # --- Enum declarations ---
    for m in re.finditer(r'\benum\s+(?:class\s+)?(\w+)\s*(?::\s*\w+\s*)?\{([^}]+)\}', content, re.DOTALL):
        names.add(m.group(1))
        for ev in re.finditer(r'(\w+)\s*(?:=|,)', m.group(2)):
            if len(ev.group(1)) > 2:
                names.add(ev.group(1))

    # --- Include paths that reveal VRC structure ---
    for m in re.finditer(r'#include\s*"([^"]+)"', content):
        path = m.group(1)
        # Extract meaningful type names from include paths
        basename = path.split('/')[-1].replace('.hpp', '').replace('.cpp', '').replace('.h', '')
        if len(basename) > 3:
            # Convert snake_case to PascalCase for matching
            pascal = ''.join(word.capitalize() for word in basename.split('_'))
            names.add(pascal)

    # --- Comment references to C# type names ---
    for m in re.finditer(r'//\s*(?:Void\'s replication of VRChat\'s\s+)?(\w+(?:\s+\w+)?)\s+class', content):
        names.add(m.group(1).replace(' ', ''))

    return names


# ======================================================================
# STEP 3: Quality filter
# ======================================================================

# C#/C++ keywords to always exclude
KEYWORDS = {
    'if', 'else', 'for', 'while', 'do', 'switch', 'case', 'break', 'continue',
    'return', 'void', 'int', 'bool', 'float', 'double', 'string', 'byte', 'char',
    'long', 'short', 'uint', 'ulong', 'ushort', 'sbyte', 'decimal', 'object',
    'var', 'new', 'null', 'true', 'false', 'this', 'base', 'class', 'struct',
    'enum', 'interface', 'abstract', 'virtual', 'override', 'sealed', 'static',
    'const', 'readonly', 'volatile', 'extern', 'ref', 'out', 'in', 'params',
    'public', 'private', 'protected', 'internal', 'get', 'set', 'value', 'where',
    'async', 'await', 'try', 'catch', 'finally', 'throw', 'using', 'namespace',
    'delegate', 'event', 'is', 'as', 'typeof', 'sizeof', 'nameof', 'yield',
    'auto', 'register', 'template', 'typename', 'friend', 'inline', 'constexpr',
    'noexcept', 'nullptr', 'delete', 'unsigned', 'signed', 'typedef',
    'include', 'define', 'pragma', 'ifdef', 'ifndef', 'endif', 'elif',
}


def quality_filter(names):
    """Keep only names useful for deobfuscation."""
    filtered = set()
    for name in names:
        if not name or not isinstance(name, str):
            continue
        if name in KEYWORDS:
            continue
        if len(name) <= 2:
            continue
        # Skip obfuscated names
        if re.match(r'^(GClass|GStruct|GEnum|GDelegate|Class)\d+$', name):
            continue
        if re.match(r'^ns\d+$', name):
            continue
        # Skip pure numbers/hex
        if re.match(r'^[\d.]+[fFdDuUlL]*$', name):
            continue
        if re.match(r'^0x[0-9a-fA-F]+$', name):
            continue
        # Skip __N patterns
        if re.match(r'^__\d+$', name):
            continue
        # Skip very short all-lowercase
        if name.islower() and len(name) <= 4:
            continue
        # Keep everything else
        filtered.add(name)
    return filtered


# ======================================================================
# MAIN
# ======================================================================

def main():
    print("=" * 70)
    print("DEEP MINE v3 - Clean vocabulary rebuild + fresh mining")
    print("=" * 70)

    # Step 1: Load original vocabulary
    print("\n--- Step 1: Reconstructing original vocabulary ---")
    original_names = load_original_vocabulary()
    print(f"Total original names: {len(original_names)}")

    # Step 2: Mine client sources
    mined_names = set()

    # 2a: MunchenClient (C#, clean names - highest value)
    print("\n--- Step 2a: Mining MunchenClient (C#) ---")
    munchen_path = CLIENT_SOURCES / "MunchenClient"
    munchen_count = 0
    for cs_file in sorted(munchen_path.rglob("*.cs")):
        file_names = mine_csharp_file(cs_file)
        mined_names.update(file_names)
        munchen_count += len(file_names)
    print(f"  Files: {len(list(munchen_path.rglob('*.cs')))}, Raw names: {munchen_count}")

    # 2b: AbyssClient (C#, partially obfuscated)
    print("\n--- Step 2b: Mining AbyssClient (C#) ---")
    abyss_path = CLIENT_SOURCES / "AbyssClient"
    abyss_count = 0
    for cs_file in sorted(abyss_path.rglob("*.cs")):
        file_names = mine_csharp_file(cs_file)
        mined_names.update(file_names)
        abyss_count += len(file_names)
    print(f"  Files: {len(list(abyss_path.rglob('*.cs')))}, Raw names: {abyss_count}")

    # 2c: Void-Public (C++, but ONLY VRC-relevant directories)
    print("\n--- Step 2c: Mining Void-Public (C++, VRC dirs only) ---")
    void_path = CLIENT_SOURCES / "Void-Public"
    void_vrc_dirs = [
        void_path / "Void" / "core" / "assembler" / "vrc",
        void_path / "Void" / "core" / "assembler" / "assembly-csharp",
        void_path / "Void" / "core" / "hooks",
        void_path / "Void" / "core" / "sdk",
        void_path / "Void" / "core" / "assembler" / "il2cpp",
        void_path / "Void" / "core" / "assembler" / "tmpro",
        void_path / "Void" / "core" / "assembler" / "unityengine",
    ]
    void_count = 0
    void_files = 0
    for vrc_dir in void_vrc_dirs:
        if vrc_dir.exists():
            for src_file in sorted(list(vrc_dir.rglob("*.cpp")) + list(vrc_dir.rglob("*.hpp")) + list(vrc_dir.rglob("*.h"))):
                file_names = mine_cpp_file(src_file)
                mined_names.update(file_names)
                void_count += len(file_names)
                void_files += 1
    # Also mine the globals/offsets headers
    for extra_file in ['Void/globals.hpp', 'Void/offsets.hpp']:
        fp = void_path / extra_file
        if fp.exists():
            file_names = mine_cpp_file(fp)
            mined_names.update(file_names)
            void_count += len(file_names)
            void_files += 1
    print(f"  Files: {void_files}, Raw names: {void_count}")

    # Step 3: Filter
    print(f"\n--- Step 3: Filtering ---")
    print(f"  Raw mined: {len(mined_names)}")
    filtered_mined = quality_filter(mined_names)
    print(f"  After filter: {len(filtered_mined)}")

    # Step 4: Merge with original
    print(f"\n--- Step 4: Merging ---")
    all_names = original_names | filtered_mined
    new_from_mining = filtered_mined - original_names
    print(f"  Original vocab: {len(original_names)}")
    print(f"  New from mining: {len(new_from_mining)}")
    print(f"  Total merged: {len(all_names)}")

    # Step 5: Categorize new names
    categories = defaultdict(list)
    for name in sorted(new_from_mining):
        if name.startswith('Method_'):
            categories['Method_signatures'].append(name)
        elif any(name.startswith(p) for p in ('VRC', 'Vrc', 'VRC_')):
            categories['VRC_types'].append(name)
        elif any(name.startswith(p) for p in ('Api', 'API')):
            categories['API_types'].append(name)
        elif any(name.startswith(p) for p in ('Player', 'Avatar', 'World', 'Instance')):
            categories['Game_core'].append(name)
        elif any(name.startswith(p) for p in ('Photon', 'Network', 'Room', 'Udon', 'USpeak')):
            categories['Networking'].append(name)
        elif any(name.startswith(p) for p in ('Il2Cpp', 'il2cpp', 'IL2CPP')):
            categories['IL2CPP'].append(name)
        elif name.endswith('RPC') or name.endswith('Rpc'):
            categories['RPCs'].append(name)
        elif 'UserInterface/' in name or name.startswith('Menu_') or name.startswith('Canvas_'):
            categories['UI_paths'].append(name)
        elif '.' in name:
            categories['Qualified_names'].append(name)
        elif name.startswith('admin_') or name.startswith('system_') or name.startswith('show_'):
            categories['Tags'].append(name)
        elif name.startswith('On') and name[2:3].isupper():
            categories['Callbacks'].append(name)
        elif name.startswith('Get') or name.startswith('Set') or name.startswith('Is') or name.startswith('Has'):
            categories['Accessors'].append(name)
        else:
            categories['Other_types'].append(name)

    print(f"\n{'='*70}")
    print("NEW NAMES BY CATEGORY")
    print(f"{'='*70}")
    for cat in sorted(categories.keys()):
        items = categories[cat]
        print(f"\n  [{cat}] ({len(items)} names)")
        for n in items[:20]:
            print(f"    {n}")
        if len(items) > 20:
            print(f"    ... and {len(items) - 20} more")

    # Step 6: Save
    final_names = sorted(all_names)
    vocab = {
        'total_signatures': len(final_names),
        'unique_names': len(final_names),
        'names': final_names,
        'stats': {
            'original_reconstructed': len(original_names),
            'mined_raw': len(mined_names),
            'mined_filtered': len(filtered_mined),
            'new_from_mining': len(new_from_mining),
            'final_total': len(final_names),
            'sources': {
                'MunchenClient': munchen_count,
                'AbyssClient': abyss_count,
                'Void-Public': void_count,
            },
            'categories': {cat: len(items) for cat, items in categories.items()},
        }
    }

    with open(VOCAB_FILE, 'w', encoding='utf-8') as f:
        json.dump(vocab, f, indent=2, ensure_ascii=False)

    # Save new names separately
    review_file = BASE / "output" / "mined_new_names_v3.json"
    with open(review_file, 'w', encoding='utf-8') as f:
        json.dump({
            'count': len(new_from_mining),
            'categories': dict(categories),
            'all_new': sorted(new_from_mining),
        }, f, indent=2, ensure_ascii=False)

    print(f"\n{'='*70}")
    print("FINAL SUMMARY")
    print(f"{'='*70}")
    print(f"  Original vocabulary (reconstructed): {len(original_names)} names")
    print(f"  New names from deep mining:          {len(new_from_mining)} names")
    print(f"  Total vocabulary:                    {len(final_names)} names")
    print(f"  Saved to: {VOCAB_FILE}")
    print(f"  Review:   {review_file}")


if __name__ == '__main__':
    main()
