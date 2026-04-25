#!/usr/bin/env python3
"""
Generate source-tree-style C# files from deobfuscated dump.
Organizes classes into domain-based folder/namespace structure.

Output: il2cpp_full_dump/src/
        ├── VRC.Avatar/
        ├── VRC.Network/
        ├── VRC.UI/
        ├── VRC.Player/
        ├── VRC.Core/
        ├── ...
        └── ThirdParty/
"""

import json, sys, os, re, collections
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

BASE_DIR = Path(__file__).resolve().parent.parent  # il2cpp_dump_tools/
INPUT_PATH = BASE_DIR / 'output' / 'deobfuscated_dump.json'
OUTPUT_DIR = BASE_DIR / 'output' / 'src'
FIELD_TYPES_PATH = BASE_DIR / 'output' / 'field_types.json'
NAME_MAPPING_PATH = BASE_DIR / 'output' / 'name_mapping.json'

# Global field type index: (semantic_class, semantic_field) -> type
_FIELD_TYPE_INDEX: dict = {}


def _clean_type(t: str) -> str:
    """Normalize a field type string for C# output."""
    if not t or not isinstance(t, str):
        return 'object'
    if t in ('?', '', 'err') or t.startswith(('err:', 'type_0x')):
        return 'object'
    # Drop leading junk prefixes from Frida extraction
    t = t.strip()
    return t or 'object'


def _lookup_field_type(class_name: str, orig_name: str, field_name: str, ns: str = '') -> str:
    """Find field type from pre-built index by (semantic_class, semantic_field)."""
    for cn in (class_name, orig_name):
        if not cn:
            continue
        t = _FIELD_TYPE_INDEX.get((cn, field_name))
        if t:
            return t
    return 'object'


def _build_field_type_index(field_types_data: dict, name_mapping: dict) -> dict:
    """Build index: (semantic_class, semantic_field) -> type string.

    field_types.json uses raw obfuscated field/class names. The dump uses
    semantic names. Translate via name_mapping.classes and .fields.
    """
    idx = {}
    classes_map = name_mapping.get('classes', {})  # obf_cls -> semantic_cls
    fields_map = name_mapping.get('fields', {})     # "obf_cls::obf_field" -> semantic_field

    for ft_key, entry in field_types_data.get('classes', {}).items():
        ft_name = entry.get('name', ft_key)
        # Try both: key itself (might be FQ) and name (bare)
        for obf_cls_candidate in (ft_name, ft_key):
            sem_cls = classes_map.get(obf_cls_candidate, obf_cls_candidate)
            for f in entry.get('fields', []):
                if not isinstance(f, dict):
                    continue
                obf_field = f.get('name', '')
                ftype = _clean_type(f.get('type', 'object'))
                if ftype == 'object':
                    continue
                sem_field = fields_map.get(f'{obf_cls_candidate}::{obf_field}', obf_field)
                # Index both semantic and obf names — the dump may use either
                idx[(sem_cls, sem_field)] = ftype
                idx[(sem_cls, obf_field)] = ftype
    return idx


# ── Domain Classification ──────────────────────────────────────────

def classify_renamed_class(cls: dict) -> str:
    """Classify a renamed obfuscated class into a VRC domain."""
    name = cls['name']
    parent = cls.get('parent', '')
    methods = cls.get('methods', [])
    method_count = len(methods)
    prefix = name.split('_')[0] if '_' in name else name

    # Network domain
    if any(x in prefix for x in ['Network', 'Sync', 'Photon', 'RPC']):
        if method_count > 50:
            return 'VRC.Network.Core'
        return 'VRC.Network'

    # Avatar
    if any(x in prefix for x in ['Avatar', 'Emote', 'Gesture', 'IK', 'Calibrat']):
        return 'VRC.Avatar'

    # UI
    if any(x in prefix for x in ['UI', 'Pointer', 'Click', 'Drag', 'Scroll', 'Submit', 'Selectable',
                                   'Button', 'Panel', 'Menu', 'Screen', 'Tab', 'Page', 'Badge', 'Tooltip']):
        if 'Manager' in prefix:
            return 'VRC.UI.Core'
        return 'VRC.UI'

    # Player
    if 'Player' in prefix:
        return 'VRC.Player'

    # Rendering
    if any(x in prefix for x in ['Camera', 'Render', 'Lighting', 'Shader', 'Material', 'Mesh',
                                   'Skinned', 'Line', 'GPUReadback']):
        return 'VRC.Rendering'

    # Audio
    if any(x in prefix for x in ['Audio', 'Spatial', 'Voice', 'Sound', 'ONSP']):
        return 'VRC.Audio'

    # Physics
    if any(x in prefix for x in ['Physics', 'Collision', 'Trigger', 'Rigidbody', 'Joint', 'Raycast']):
        return 'VRC.Physics'

    # Animation
    if any(x in prefix for x in ['Anim', 'Motion', 'Blend']):
        return 'VRC.Animation'

    # Udon
    if 'Udon' in prefix:
        return 'VRC.Udon'

    # Texture/Visual
    if any(x in prefix for x in ['Texture', 'Animated', 'Sprite', 'Image']):
        return 'VRC.Texture'

    # Effects
    if any(x in prefix for x in ['Particle', 'VFX', 'Effect', 'Trail']):
        return 'VRC.Effects'

    # Transform/GameObject core
    if any(x in prefix for x in ['Transform', 'GameObject', 'Gizmos']):
        return 'VRC.Core.Transform'

    # Video/Media
    if any(x in prefix for x in ['Video', 'Media', 'Stream']):
        return 'VRC.Media'

    # Input
    if any(x in prefix for x in ['Screen', 'Display', 'Input', 'Cursor']):
        return 'VRC.Input'

    # World
    if any(x in prefix for x in ['Navigation', 'Terrain', 'World', 'Room', 'Portal', 'Spawn']):
        return 'VRC.World'

    # Async internals
    if 'Async' in prefix or 'StateMachine' in prefix:
        return 'VRC.Internal.Async'
    if 'Enumerator' in prefix:
        return 'VRC.Internal.Enumerator'
    if 'Delegate' in prefix:
        return 'VRC.Internal.Delegate'
    if 'Profiled' in prefix:
        return 'VRC.Internal.Profiled'

    # Component lifecycle
    if any(x in prefix for x in ['Lifecycle', 'UpdateComponent', 'FixedUpdate', 'LateUpdate']):
        return 'VRC.Core.Component'

    # Major systems
    if any(x in prefix for x in ['Complex', 'Major', 'Service']):
        if method_count > 100:
            return 'VRC.Core.MajorSystem'
        return 'VRC.Core.System'

    # Base classes
    if any(x in prefix for x in ['Base', 'FBase']):
        return 'VRC.Core.Base'

    # Generated/structural fallback
    if any(x in prefix for x in ['Static', 'Empty', 'DataOnly', 'Struct', 'Enum', 'Record', 'Mono']):
        return 'VRC.Internal.Generated'

    # Web/API
    if any(x in prefix for x in ['Web', 'Http', 'API', 'Request']):
        return 'VRC.Network.Web'

    # Security
    if any(x in prefix for x in ['Safety', 'Trust', 'Ban', 'Block', 'Report']):
        return 'VRC.Security'

    # Social
    if any(x in prefix for x in ['Friend', 'Group', 'Invite', 'Status', 'Notification']):
        return 'VRC.Social'

    return 'VRC.Misc'


def classify_existing_namespace(ns: str) -> str:
    """Map existing namespaces to source tree folders."""
    if not ns:
        return 'Global'

    # VRC namespaces keep their structure
    if ns.startswith('VRC'):
        return ns

    # Unity Engine
    if ns.startswith('UnityEngine'):
        return f'ThirdParty.Unity.{ns}'

    # System
    if ns.startswith('System') or ns.startswith('Microsoft') or ns.startswith('Mono'):
        return f'ThirdParty.DotNet.{ns}'

    # Third party libs
    third_party_prefixes = {
        'Photon': 'ThirdParty.Photon',
        'ExitGames': 'ThirdParty.Photon',
        'BestHTTP': 'ThirdParty.BestHTTP',
        'Cinemachine': 'ThirdParty.Cinemachine',
        'DG.Tweening': 'ThirdParty.DOTween',
        'Cysharp': 'ThirdParty.UniTask',
        'Google': 'ThirdParty.Google',
        'Newtonsoft': 'ThirdParty.Newtonsoft',
        'Valve': 'ThirdParty.Valve',
        'Oculus': 'ThirdParty.Oculus',
        'Sentry': 'ThirdParty.Sentry',
        'Depthkit': 'ThirdParty.Depthkit',
        'Discord': 'ThirdParty.Discord',
        'Mediapipe': 'ThirdParty.Mediapipe',
        'Klak': 'ThirdParty.Klak',
        'OscCore': 'ThirdParty.OscCore',
        'Beebyte': 'ThirdParty.Beebyte',
        'Collections.Pooled': 'ThirdParty.CollectionsPooled',
        'ZLinq': 'ThirdParty.ZLinq',
        'RealisticEyeMovements': 'ThirdParty.RealisticEyeMovements',
        'Sigtrap': 'ThirdParty.VrTunnellingPro',
    }

    for prefix, folder in third_party_prefixes.items():
        if ns.startswith(prefix):
            return f'{folder}.{ns}'

    return f'ThirdParty.Other.{ns}'


# ── Source File Generation ─────────────────────────────────────────

def write_cs_file(filepath: Path, namespace: str, classes: list[dict]):
    """Write a C# file with proper formatting."""
    filepath.parent.mkdir(parents=True, exist_ok=True)

    lines = []
    lines.append(f'// IL2CPP Deobfuscated Source')
    lines.append(f'// Namespace: {namespace}')
    lines.append(f'// Classes: {len(classes)}')
    lines.append(f'// Methods: {sum(len(c.get("methods",[])) for c in classes)}')
    lines.append('')

    if namespace and namespace != 'Global':
        lines.append(f'namespace {namespace}')
        lines.append('{')
        indent = '    '
    else:
        indent = ''

    for cls in sorted(classes, key=lambda c: c['name']):
        original = cls.get('original_name', '')
        parent = cls.get('parent', '')
        methods = cls.get('methods', [])
        fields = cls.get('fields', [])
        ptrs = cls.get('method_pointers', {})
        method_count = len(methods)
        real_ns = cls.get('namespace', '')  # real NS for field_types lookup

        # Class header
        if original:
            lines.append(f'{indent}/// <summary>Originally: {original[:60]}</summary>')
        parent_str = f' : {parent}' if parent else ''
        lines.append(f'{indent}public class {cls["name"]}{parent_str}')
        lines.append(f'{indent}{{')

        # Fields - lookup types from field_types.json when not in dump
        if fields:
            for f in fields:
                if isinstance(f, dict):
                    fname = f.get('name', '?')
                    ftype = _clean_type(f.get('type', 'object'))
                    foffset = f.get('offset', 0)
                    forig = f.get('original_name', '')
                    if ftype == 'object':
                        ftype = _lookup_field_type(cls['name'], original, fname, real_ns)
                    comment_parts = []
                    if foffset > 0:
                        comment_parts.append(f'0x{foffset:X}')
                    if forig:
                        comment_parts.append(f'was: {forig[:30]}')
                    comment = f' // {", ".join(comment_parts)}' if comment_parts else ''
                    lines.append(f'{indent}    public {ftype} {fname};{comment}')
                else:
                    # String field — lookup type from field_types
                    ftype = _lookup_field_type(cls['name'], original, f, real_ns)
                    lines.append(f'{indent}    public {ftype} {f};')
            if methods:
                lines.append('')

        # Dedupe methods by name while preserving original ordering
        seen_methods: set = set()
        unique_methods: list = []
        dup_count = collections.Counter()
        for m in methods:
            dup_count[m] += 1
            if m not in seen_methods:
                seen_methods.add(m)
                unique_methods.append(m)

        # Group: semantic (readable) vs hash
        readable_methods = [m for m in unique_methods if not m.startswith('m_')]
        hashed_methods = [m for m in unique_methods if m.startswith('m_')]

        if readable_methods:
            lines.append(f'{indent}    // ── Methods ──')
            for m in readable_methods:
                ptr = ptrs.get(m, '')
                comment_parts = []
                if ptr:
                    comment_parts.append(f'RVA: {ptr}')
                if dup_count[m] > 1:
                    comment_parts.append(f'overloaded x{dup_count[m]}')
                comment = f' // {" | ".join(comment_parts)}' if comment_parts else ''
                lines.append(f'{indent}    public void {m}(){{}}{comment}')

        if hashed_methods:
            if len(hashed_methods) <= 10:
                lines.append(f'{indent}    // ── Unresolved (hash) ──')
                for m in hashed_methods:
                    ptr = ptrs.get(m, '')
                    ptr_comment = f' // RVA: {ptr}' if ptr else ''
                    lines.append(f'{indent}    public void {m}(){{}}{ptr_comment}')
            else:
                lines.append(f'{indent}    // ── {len(hashed_methods)} unresolved (hash) ──')
                for m in hashed_methods[:5]:
                    ptr = ptrs.get(m, '')
                    ptr_comment = f' // RVA: {ptr}' if ptr else ''
                    lines.append(f'{indent}    public void {m}(){{}}{ptr_comment}')
                lines.append(f'{indent}    // ... {len(hashed_methods) - 5} more unresolved methods')

        lines.append(f'{indent}}}')
        lines.append('')

    if namespace and namespace != 'Global':
        lines.append('}')

    with open(filepath, 'w', encoding='utf-8') as f:
        f.write('\n'.join(lines))


# ── Main ───────────────────────────────────────────────────────────

def main():
    print('Loading deobfuscated dump...')
    with open(str(INPUT_PATH), 'r', encoding='utf-8') as f:
        data = json.load(f)

    # Load field_types.json and build reverse index via name_mapping
    global _FIELD_TYPE_INDEX
    if FIELD_TYPES_PATH.exists() and NAME_MAPPING_PATH.exists():
        try:
            with open(str(FIELD_TYPES_PATH), 'r', encoding='utf-8') as f:
                ft_data = json.load(f)
            with open(str(NAME_MAPPING_PATH), 'r', encoding='utf-8') as f:
                name_mapping = json.load(f)
            _FIELD_TYPE_INDEX = _build_field_type_index(ft_data, name_mapping)
            print(f'Built field type index: {len(_FIELD_TYPE_INDEX)} (class,field) pairs')
        except Exception as e:
            print(f'Warning: failed to build field type index: {e}')

    # Clean output directory
    if OUTPUT_DIR.exists():
        import shutil
        shutil.rmtree(OUTPUT_DIR)
    OUTPUT_DIR.mkdir(parents=True)

    # Step 1: Classify ALL classes into source tree domains, deduplicating
    domain_classes: dict[str, list[dict]] = collections.defaultdict(list)
    seen: set[tuple[str, str]] = set()
    total_classes = 0
    dup_skipped = 0

    for ns, classes in data['namespaces'].items():
        for cls in classes:
            total_classes += 1
            # Dedupe: (namespace, class_name) must be unique
            key = (ns, cls['name'])
            if key in seen:
                dup_skipped += 1
                continue
            seen.add(key)

            if cls.get('original_name'):
                # Renamed obfuscated class → classify by name
                domain = classify_renamed_class(cls)
            else:
                # Existing class → classify by namespace
                domain = classify_existing_namespace(ns)

            domain_classes[domain].append(cls)

    print(f'Deduplicated: {dup_skipped} duplicate class entries skipped')

    print(f'Classified {total_classes} classes into {len(domain_classes)} domains')

    # Step 2: Generate source files
    # Split large domains into multiple files (max ~100 classes per file)
    MAX_PER_FILE = 100
    file_count = 0
    total_written = 0

    for domain in sorted(domain_classes.keys()):
        classes = domain_classes[domain]

        # Convert domain to path
        domain_path = domain.replace('.', '/')
        domain_dir = OUTPUT_DIR / domain_path

        if len(classes) <= MAX_PER_FILE:
            # Single file
            filename = domain.rsplit('.', 1)[-1] + '.cs'
            filepath = domain_dir / filename
            write_cs_file(filepath, domain, classes)
            file_count += 1
            total_written += len(classes)
        else:
            # Split into multiple files by sub-grouping
            # Group by first letter of class name
            sub_groups = collections.defaultdict(list)
            for cls in classes:
                first = cls['name'][0].upper()
                if not first.isalpha():
                    first = '_Special'
                sub_groups[first].append(cls)

            for group_key, group_classes in sorted(sub_groups.items()):
                if len(group_classes) > MAX_PER_FILE:
                    # Split further by chunks
                    for i in range(0, len(group_classes), MAX_PER_FILE):
                        chunk = group_classes[i:i+MAX_PER_FILE]
                        suffix = f'_{i//MAX_PER_FILE+1}' if i > 0 else ''
                        filename = f'{group_key}{suffix}.cs'
                        filepath = domain_dir / filename
                        write_cs_file(filepath, domain, chunk)
                        file_count += 1
                        total_written += len(chunk)
                else:
                    filename = f'{group_key}.cs'
                    filepath = domain_dir / filename
                    write_cs_file(filepath, domain, group_classes)
                    file_count += 1
                    total_written += len(group_classes)

    # Step 3: Generate index file
    index_path = OUTPUT_DIR / 'INDEX.md'
    with open(index_path, 'w', encoding='utf-8') as f:
        f.write('# IL2CPP Deobfuscated Source Tree\n\n')
        f.write(f'Total: {total_written} classes in {file_count} files\n\n')
        f.write('## Domain Structure\n\n')
        f.write('| Domain | Classes | Methods | Files |\n')
        f.write('|--------|---------|---------|-------|\n')

        for domain in sorted(domain_classes.keys()):
            classes = domain_classes[domain]
            methods = sum(len(c.get('methods', [])) for c in classes)
            files = max(1, (len(classes) + MAX_PER_FILE - 1) // MAX_PER_FILE)
            f.write(f'| `{domain}` | {len(classes)} | {methods} | {files} |\n')

        f.write('\n## Key Classes\n\n')
        # List the most important renamed classes
        big_renamed = []
        for domain, classes in domain_classes.items():
            for cls in classes:
                if cls.get('original_name') and len(cls.get('methods', [])) > 50:
                    big_renamed.append((cls['name'], domain, len(cls.get('methods', [])), cls.get('parent', '')))
        big_renamed.sort(key=lambda x: -x[2])
        f.write('| Class | Domain | Methods | Parent |\n')
        f.write('|-------|--------|---------|--------|\n')
        for name, domain, mc, parent in big_renamed[:40]:
            f.write(f'| `{name}` | `{domain}` | {mc} | `{parent}` |\n')

    print(f'\nGenerated {file_count} source files with {total_written} classes')
    print(f'Output: {OUTPUT_DIR}/')

    # Print tree summary
    print(f'\nSource Tree:')
    for domain in sorted(domain_classes.keys()):
        if domain.startswith('ThirdParty'):
            continue  # skip third party in summary
        classes = domain_classes[domain]
        methods = sum(len(c.get('methods', [])) for c in classes)
        print(f'  {domain:40s}: {len(classes):5d} classes, {methods:7d} methods')


if __name__ == '__main__':
    main()
