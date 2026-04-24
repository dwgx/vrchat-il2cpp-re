#!/usr/bin/env python3
"""
Deep mine all client source repos to extract VRChat-relevant names for deobfuscation vocabulary.
Extracts: class names, method names, field names, enum names+values, property names,
namespace names, type references, string literals (API endpoints, type names).
"""

import os
import re
import json
import sys
from pathlib import Path
from collections import defaultdict

BASE = Path("D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools")
CLIENT_SOURCES = BASE / "external" / "client-sources"
VOCAB_FILE = BASE / "output" / "master_vocabulary.json"

# Stats tracking
stats = defaultdict(lambda: defaultdict(int))

def extract_from_csharp(filepath, all_names):
    """Extract all meaningful names from a C# source file."""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()
    except:
        return

    repo = str(filepath).split('client-sources/')[-1].split('/')[0] if 'client-sources' in str(filepath) else 'unknown'

    # 1. Class/struct/interface/enum declarations
    for m in re.finditer(r'\b(?:class|struct|interface|enum)\s+(\w+)', content):
        name = m.group(1)
        if len(name) > 1 and not name.startswith('_'):
            all_names.add(name)
            stats[repo]['classes'] += 1

    # 2. Namespace declarations
    for m in re.finditer(r'\bnamespace\s+([\w.]+)', content):
        ns = m.group(1)
        all_names.add(ns)
        # Also add individual parts
        for part in ns.split('.'):
            if len(part) > 1:
                all_names.add(part)
        stats[repo]['namespaces'] += 1

    # 3. Method declarations (public/private/protected/internal/static/virtual/override/abstract/async)
    for m in re.finditer(r'(?:public|private|protected|internal|static|virtual|override|abstract|async|sealed|new)\s+(?:(?:public|private|protected|internal|static|virtual|override|abstract|async|sealed|new|readonly|const)\s+)*(?:[\w<>\[\],\s]+?)\s+(\w+)\s*\(', content):
        name = m.group(1)
        if len(name) > 1 and name not in ('if', 'for', 'while', 'switch', 'catch', 'using', 'return', 'get', 'set', 'new', 'var', 'void', 'bool', 'int', 'string', 'float', 'double', 'byte', 'object'):
            all_names.add(name)
            stats[repo]['methods'] += 1

    # 4. Method names from invocations: obj.MethodName( or Type.MethodName(
    for m in re.finditer(r'\.(\w+)\s*\(', content):
        name = m.group(1)
        if len(name) > 2 and name[0].isupper() and not name.startswith('_'):
            all_names.add(name)
            stats[repo]['method_refs'] += 1

    # 5. Property/field declarations
    for m in re.finditer(r'(?:public|private|protected|internal|static|readonly|const)\s+(?:(?:public|private|protected|internal|static|readonly|const|volatile)\s+)*(?:[\w<>\[\],?]+)\s+(\w+)\s*(?:[{;=])', content):
        name = m.group(1)
        if len(name) > 1 and name not in ('if', 'for', 'while', 'switch', 'catch', 'using', 'return', 'get', 'set', 'new', 'var', 'void', 'bool', 'int', 'string', 'float', 'double', 'byte', 'object', 'value', 'true', 'false', 'null'):
            all_names.add(name)
            stats[repo]['fields'] += 1

    # 6. Enum values
    # Find enum bodies and extract values
    for m in re.finditer(r'\benum\s+\w+\s*(?::\s*\w+\s*)?\{([^}]+)\}', content, re.DOTALL):
        body = m.group(1)
        for ev in re.finditer(r'(\w+)\s*(?:=|,|})', body):
            name = ev.group(1)
            if len(name) > 1:
                all_names.add(name)
                stats[repo]['enum_values'] += 1

    # 7. Type references in generics, casts, typeof(), is, as
    for m in re.finditer(r'(?:typeof|is|as|new)\s*\(?\s*(\w+)', content):
        name = m.group(1)
        if len(name) > 1 and name[0].isupper():
            all_names.add(name)
            stats[repo]['type_refs'] += 1

    # 8. Generic type parameters: List<TypeName>, Dictionary<K,V>, etc.
    for m in re.finditer(r'<\s*(\w+)(?:\s*,\s*(\w+))*\s*>', content):
        for g in m.groups():
            if g and len(g) > 1 and g[0].isupper():
                all_names.add(g)
                stats[repo]['generic_refs'] += 1

    # 9. Using statements (namespace references)
    for m in re.finditer(r'\busing\s+(?:static\s+)?([\w.]+)\s*;', content):
        ns = m.group(1)
        all_names.add(ns)
        for part in ns.split('.'):
            if len(part) > 1 and part[0].isupper():
                all_names.add(part)
        stats[repo]['usings'] += 1

    # 10. String literals that look like VRChat API endpoints or type names
    for m in re.finditer(r'"([^"]{3,200})"', content):
        s = m.group(1)
        # API endpoints
        if s.startswith('/') or s.startswith('api/') or 'vrchat' in s.lower() or s.startswith('https://'):
            all_names.add(s)
            stats[repo]['api_strings'] += 1
        # Type-like strings (PascalCase or namespaced)
        elif re.match(r'^[A-Z][a-zA-Z0-9]+(?:\.[A-Z][a-zA-Z0-9]+)*$', s):
            all_names.add(s)
            stats[repo]['type_strings'] += 1
        # Strings with dots that look like qualified names
        elif '.' in s and re.match(r'^[\w.]+$', s) and any(p[0].isupper() for p in s.split('.') if p):
            all_names.add(s)
            stats[repo]['qualified_strings'] += 1

    # 11. Attribute names [AttributeName] or [AttributeName(...)]
    for m in re.finditer(r'\[(\w+?)(?:Attribute)?\s*(?:\(|])', content):
        name = m.group(1)
        if len(name) > 1 and name[0].isupper():
            all_names.add(name)
            all_names.add(name + 'Attribute')
            stats[repo]['attributes'] += 1

    # 12. Delegate/event declarations
    for m in re.finditer(r'\bdelegate\s+[\w<>\[\]]+\s+(\w+)\s*\(', content):
        all_names.add(m.group(1))
        stats[repo]['delegates'] += 1

    for m in re.finditer(r'\bevent\s+[\w<>\[\]]+\s+(\w+)\s*[;{]', content):
        all_names.add(m.group(1))
        stats[repo]['events'] += 1

    # 13. Inheritance: class X : BaseClass, IInterface
    for m in re.finditer(r'(?:class|struct|interface)\s+\w+\s*(?:<[^>]+>)?\s*:\s*([^{]+)', content):
        bases = m.group(1)
        for b in re.finditer(r'(\w+)', bases):
            name = b.group(1)
            if len(name) > 1 and name[0].isupper() and name not in ('where', 'new', 'class', 'struct'):
                all_names.add(name)
                stats[repo]['base_types'] += 1

    # 14. Constant/literal field names that reveal patterns
    for m in re.finditer(r'(?:const|static\s+readonly)\s+\w+\s+(\w+)\s*=', content):
        name = m.group(1)
        if len(name) > 1:
            all_names.add(name)
            stats[repo]['constants'] += 1

    # 15. Property accessors - { get; set; } style
    for m in re.finditer(r'(?:public|private|protected|internal)\s+(?:static\s+)?(?:[\w<>\[\],?]+)\s+(\w+)\s*\{\s*(?:get|set)', content):
        name = m.group(1)
        if len(name) > 1 and name[0].isupper():
            all_names.add(name)
            stats[repo]['properties'] += 1

    # 16. IL2CPP-specific patterns: Il2CppField, method_name patterns
    for m in re.finditer(r'(?:Il2Cpp\w+|il2cpp_\w+)', content):
        all_names.add(m.group(0))
        stats[repo]['il2cpp_refs'] += 1

    # 17. VRC-specific patterns
    for m in re.finditer(r'\b(VRC\w+|Api\w+|Player\w+|Avatar\w+|World\w+|Photon\w+|Udon\w+|USpeak\w+|SDK\w+|Haptic\w+)\b', content):
        name = m.group(1)
        if len(name) > 2:
            all_names.add(name)
            stats[repo]['vrc_specific'] += 1


def extract_from_cpp(filepath, all_names):
    """Extract VRChat-relevant names from C++ source files (Void-Public uses C++)."""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()
    except:
        return

    repo = 'Void-Public'

    # 1. Class/struct declarations
    for m in re.finditer(r'\b(?:class|struct)\s+(\w+)', content):
        name = m.group(1)
        if len(name) > 1:
            all_names.add(name)
            stats[repo]['classes'] += 1

    # 2. Namespace declarations
    for m in re.finditer(r'\bnamespace\s+([\w:]+)', content):
        ns = m.group(1)
        for part in ns.split('::'):
            if len(part) > 1:
                all_names.add(part)
        stats[repo]['namespaces'] += 1

    # 3. Method/function signatures
    for m in re.finditer(r'(?:static\s+)?(?:virtual\s+)?(?:[\w:*&<>]+)\s+(\w+)\s*\(', content):
        name = m.group(1)
        if len(name) > 2 and name not in ('if', 'for', 'while', 'switch', 'return', 'sizeof', 'static_cast', 'dynamic_cast', 'reinterpret_cast', 'const_cast', 'decltype', 'alignof', 'offsetof'):
            all_names.add(name)
            stats[repo]['methods'] += 1

    # 4. Method calls on objects
    for m in re.finditer(r'(?:->|\.)\s*(\w+)\s*\(', content):
        name = m.group(1)
        if len(name) > 2:
            all_names.add(name)
            stats[repo]['method_refs'] += 1

    # 5. String literals with VRChat content
    for m in re.finditer(r'"([^"]{3,200})"', content):
        s = m.group(1)
        if s.startswith('/') or 'vrchat' in s.lower() or s.startswith('api/') or s.startswith('https://'):
            all_names.add(s)
            stats[repo]['api_strings'] += 1
        elif re.match(r'^[A-Z][a-zA-Z0-9]+(?:\.[A-Z][a-zA-Z0-9]+)*$', s):
            all_names.add(s)
            stats[repo]['type_strings'] += 1
        elif '.' in s and re.match(r'^[\w.]+$', s) and any(p[0].isupper() for p in s.split('.') if p):
            all_names.add(s)
            stats[repo]['qualified_strings'] += 1

    # 6. #define constants
    for m in re.finditer(r'#define\s+(\w+)', content):
        name = m.group(1)
        if len(name) > 2:
            all_names.add(name)
            stats[repo]['defines'] += 1

    # 7. Enum values
    for m in re.finditer(r'\benum\s+(?:class\s+)?(\w+)', content):
        all_names.add(m.group(1))
        stats[repo]['enums'] += 1

    for m in re.finditer(r'\benum\s+(?:class\s+)?\w+\s*(?::\s*\w+\s*)?\{([^}]+)\}', content, re.DOTALL):
        body = m.group(1)
        for ev in re.finditer(r'(\w+)\s*(?:=|,|})', body):
            name = ev.group(1)
            if len(name) > 1:
                all_names.add(name)
                stats[repo]['enum_values'] += 1

    # 8. typedef/using type aliases
    for m in re.finditer(r'(?:typedef|using)\s+(?:[\w:*&<>\s]+)\s+(\w+)\s*;', content):
        name = m.group(1)
        if len(name) > 1:
            all_names.add(name)
            stats[repo]['typedefs'] += 1

    # 9. Field declarations with VRChat patterns
    for m in re.finditer(r'\b(VRC\w+|Api\w+|Player\w+|Avatar\w+|World\w+|Photon\w+|Udon\w+|RoomManager\w*|NetworkManager\w*|ModerationManager\w*|USpeaker\w*)\b', content):
        name = m.group(1)
        if len(name) > 2:
            all_names.add(name)
            stats[repo]['vrc_specific'] += 1

    # 10. IL2CPP API calls and types
    for m in re.finditer(r'\b(il2cpp_\w+|Il2Cpp\w+|IL2CPP\w+)\b', content):
        all_names.add(m.group(1))
        stats[repo]['il2cpp_refs'] += 1

    # 11. Member field names (especially in struct/class bodies)
    for m in re.finditer(r'(?:[\w:*&<>]+)\s+(\w+)\s*;', content):
        name = m.group(1)
        if len(name) > 2 and name[0].islower() and not name.startswith('_'):
            all_names.add(name)
            stats[repo]['fields'] += 1

    # 12. Offset patterns like "field_name" in comments referencing C# originals
    for m in re.finditer(r'//.*?(\b[A-Z][a-zA-Z]+(?:[A-Z][a-zA-Z]+)+\b)', content):
        name = m.group(1)
        if len(name) > 3:
            all_names.add(name)
            stats[repo]['comment_names'] += 1


def filter_names(names):
    """Filter out common programming keywords and very short/generic names."""
    # C# / C++ keywords and common types to exclude
    exclude = {
        'if', 'else', 'for', 'while', 'do', 'switch', 'case', 'break', 'continue',
        'return', 'void', 'int', 'bool', 'float', 'double', 'string', 'byte', 'char',
        'long', 'short', 'uint', 'ulong', 'ushort', 'sbyte', 'decimal', 'object',
        'var', 'new', 'null', 'true', 'false', 'this', 'base', 'class', 'struct',
        'enum', 'interface', 'abstract', 'virtual', 'override', 'sealed', 'static',
        'const', 'readonly', 'volatile', 'extern', 'ref', 'out', 'in', 'params',
        'public', 'private', 'protected', 'internal', 'get', 'set', 'value', 'where',
        'select', 'from', 'group', 'into', 'orderby', 'join', 'let', 'on', 'equals',
        'ascending', 'descending', 'async', 'await', 'yield', 'try', 'catch', 'finally',
        'throw', 'using', 'namespace', 'delegate', 'event', 'is', 'as', 'typeof', 'sizeof',
        'checked', 'unchecked', 'fixed', 'unsafe', 'stackalloc', 'lock', 'goto', 'default',
        'implicit', 'explicit', 'operator', 'partial', 'dynamic', 'when', 'nameof',
        # C++ specific
        'auto', 'register', 'template', 'typename', 'friend', 'mutable', 'constexpr',
        'noexcept', 'nullptr', 'delete', 'sizeof', 'alignof', 'decltype', 'inline',
        'volatile', 'unsigned', 'signed', 'wchar_t', 'char16_t', 'char32_t',
        # Common generic names not useful for deobfuscation
        'args', 'arg', 'param', 'result', 'data', 'temp', 'tmp', 'item', 'items',
        'list', 'array', 'dict', 'map', 'key', 'val', 'idx', 'index', 'count',
        'length', 'size', 'name', 'type', 'text', 'str', 'num', 'ptr', 'buf',
        'msg', 'err', 'ret', 'pos', 'src', 'dst', 'end', 'begin',
        'obj', 'func', 'callback', 'handler', 'ctx', 'info',
        # Common .NET types
        'String', 'Int32', 'Int64', 'Boolean', 'Single', 'Double', 'Byte', 'Object',
        'Array', 'List', 'Dictionary', 'HashSet', 'Queue', 'Stack',
        'Task', 'Action', 'Func', 'EventHandler', 'IDisposable', 'IEnumerable',
        'IEnumerator', 'IList', 'ICollection', 'IDictionary', 'IComparer',
        'Exception', 'ArgumentException', 'NullReferenceException',
        'Console', 'Math', 'Convert', 'Encoding', 'Stream', 'File', 'Path',
        'Type', 'Attribute', 'Enum', 'Delegate', 'MulticastDelegate',
        'ValueType', 'Nullable',
        # Common Unity types (not VRChat-specific enough but keep prefixed ones)
        'MonoBehaviour', 'ScriptableObject', 'Component', 'GameObject', 'Transform',
        'Vector2', 'Vector3', 'Vector4', 'Quaternion', 'Matrix4x4', 'Color', 'Color32',
        'Texture', 'Texture2D', 'Material', 'Shader', 'Mesh', 'Renderer',
        'Camera', 'Light', 'AudioSource', 'AudioClip', 'Rigidbody', 'Collider',
        'BoxCollider', 'SphereCollider', 'CapsuleCollider', 'MeshCollider',
        'Canvas', 'Image', 'Text', 'Button', 'Toggle', 'Slider', 'Dropdown',
        'InputField', 'ScrollRect', 'RectTransform', 'LayoutGroup',
        'Animator', 'Animation', 'AnimationClip', 'RuntimeAnimatorController',
        'Time', 'Input', 'Debug', 'Application', 'Resources', 'PlayerPrefs',
        'Screen', 'Display', 'Physics', 'Random', 'Mathf', 'GUI', 'GUILayout',
        'EditorGUILayout', 'Editor', 'AssetDatabase', 'SerializedProperty',
        'Coroutine', 'WaitForSeconds', 'WaitForEndOfFrame',
        'EventSystem', 'PointerEventData', 'BaseEventData',
        'UnityEngine', 'UnityEditor', 'System', 'Collections', 'Generic',
        'Linq', 'Threading', 'Tasks', 'IO', 'Net', 'Reflection',
        'Serialization', 'Runtime', 'CompilerServices', 'Diagnostics',
        # C++ standard
        'std', 'vector', 'pair', 'tuple', 'unique_ptr', 'shared_ptr',
        'make_unique', 'make_shared', 'move', 'forward',
        'printf', 'sprintf', 'malloc', 'free', 'memcpy', 'memset',
        'strlen', 'strcmp', 'strcpy', 'strcat',
        'main', 'include', 'define', 'pragma', 'ifdef', 'ifndef', 'endif',
    }

    filtered = set()
    for name in names:
        # Skip if in exclude list
        if name in exclude:
            continue
        # Skip pure numbers
        if name.isdigit():
            continue
        # Skip very short names (1-2 chars) unless they are VRC-prefixed
        if len(name) <= 2 and not name.startswith('VR'):
            continue
        # Skip names that are all lowercase and very generic
        if name.islower() and len(name) <= 4:
            continue
        # Keep API endpoints and URLs
        if name.startswith('/') or name.startswith('http') or name.startswith('api/'):
            filtered.add(name)
            continue
        # Skip names that look like hex addresses
        if re.match(r'^0x[0-9a-fA-F]+$', name):
            continue
        # Skip ALL_CAPS short names that are likely C preprocessor
        if name.isupper() and len(name) <= 3:
            continue

        filtered.add(name)

    return filtered


def main():
    all_names = set()

    # ---- Mine C# sources (MunchenClient + AbyssClient) ----
    for repo in ['MunchenClient', 'AbyssClient']:
        repo_path = CLIENT_SOURCES / repo
        cs_files = list(repo_path.rglob('*.cs'))
        print(f"\n[{repo}] Found {len(cs_files)} C# files")
        for f in cs_files:
            extract_from_csharp(f, all_names)

    # ---- Mine C++ sources (Void-Public) ----
    void_path = CLIENT_SOURCES / 'Void-Public'
    cpp_files = list(void_path.rglob('*.cpp')) + list(void_path.rglob('*.hpp')) + list(void_path.rglob('*.h'))
    print(f"\n[Void-Public] Found {len(cpp_files)} C/C++ files")
    for f in cpp_files:
        extract_from_cpp(f, all_names)

    # ---- VRTool-Reversed is only RAR files, skip ----
    print(f"\n[VRTool-Reversed] Only contains RAR archives, skipping")

    print(f"\nTotal raw names extracted: {len(all_names)}")

    # Filter names
    filtered_names = filter_names(all_names)
    print(f"After filtering: {len(filtered_names)}")

    # Print stats
    print("\n=== Extraction Stats ===")
    for repo, cat_stats in sorted(stats.items()):
        print(f"\n  {repo}:")
        for cat, count in sorted(cat_stats.items()):
            print(f"    {cat}: {count}")

    # Load existing vocabulary
    with open(VOCAB_FILE, 'r', encoding='utf-8') as f:
        vocab = json.load(f)

    existing_names = set(vocab.get('names', []))
    print(f"\nExisting vocabulary: {len(existing_names)} names")

    # Find new names
    new_names = filtered_names - existing_names
    print(f"New names to add: {len(new_names)}")

    # Merge
    all_vocab_names = sorted(existing_names | filtered_names)

    # Update vocab
    vocab['names'] = all_vocab_names
    vocab['unique_names'] = len(all_vocab_names)
    vocab['total_signatures'] = vocab.get('total_signatures', 0) + len(new_names)
    vocab['mining_stats'] = {
        'raw_extracted': len(all_names),
        'after_filter': len(filtered_names),
        'new_added': len(new_names),
        'sources': {
            'MunchenClient_cs': stats.get('MunchenClient', {}),
            'AbyssClient_cs': stats.get('AbyssClient', {}),
            'Void_Public_cpp': stats.get('Void-Public', {}),
        }
    }

    with open(VOCAB_FILE, 'w', encoding='utf-8') as f:
        json.dump(vocab, f, indent=2, ensure_ascii=False)

    print(f"\nUpdated vocabulary: {len(all_vocab_names)} total names")
    print(f"Saved to: {VOCAB_FILE}")

    # Also save new names separately for review
    new_names_file = BASE / "output" / "mined_new_names.json"
    with open(new_names_file, 'w', encoding='utf-8') as f:
        json.dump({
            'count': len(new_names),
            'names': sorted(new_names),
        }, f, indent=2, ensure_ascii=False)
    print(f"New names saved to: {new_names_file}")

    # Print sample of interesting new names
    vrc_names = sorted([n for n in new_names if any(n.startswith(p) for p in ('VRC', 'Api', 'Player', 'Avatar', 'World', 'Photon', 'Udon', 'Network', 'Room', 'Moderation'))])
    if vrc_names:
        print(f"\n=== Sample VRChat-specific new names ({len(vrc_names)} total) ===")
        for n in vrc_names[:100]:
            print(f"  {n}")
        if len(vrc_names) > 100:
            print(f"  ... and {len(vrc_names) - 100} more")


if __name__ == '__main__':
    main()
