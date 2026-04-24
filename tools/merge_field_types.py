#!/usr/bin/env python3
"""
Merge field type information into the deobfuscated dump.

Reads:  output/deobfuscated_dump.json  (main dump with field names only)
        output/field_types.json        (93K fields with runtime type info)
Writes: output/deobfuscated_dump.json  (updated: fields now have type+offset)
        output/deobfuscated_dump.cs    (regenerated with type annotations)

Match strategy: VA address (Il2CppClass pointer) is shared between both dumps.
Field pairing: by index position (both extracted in declaration order).
"""

import json, sys, os, re, time, collections
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
OUTPUT_DIR = BASE_DIR / 'output'
DEOBF_JSON = OUTPUT_DIR / 'deobfuscated_dump.json'
FIELD_TYPES = OUTPUT_DIR / 'field_types.json'
DEOBF_CS = OUTPUT_DIR / 'deobfuscated_dump.cs'

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')


def load_field_types():
    """Load field_types.json and index by (namespace, name) full-name.

    VA-based indexing is useless across sessions because heap VAs differ on
    every launch. Class namespace+name is stable across Beebyte re-seeds for
    any class that was already semantically named in Apr 8.
    """
    print('  Loading field_types.json ...')
    with open(FIELD_TYPES, 'r', encoding='utf-8') as f:
        data = json.load(f)

    by_fullname = {}
    skipped_obf = 0
    for key, cls in data['classes'].items():
        n = cls.get('name', '')
        if not n or OBF_RE.match(n):
            skipped_obf += 1
            continue
        ns = cls.get('namespace') or ''
        fullname = f'{ns}.{n}' if ns else n
        by_fullname[fullname] = cls
    print(f'    {len(by_fullname):,} classes indexed by full name (skipped {skipped_obf:,} obf)')
    return by_fullname


def merge_into_dump(ft_by_fullname: dict):
    """Merge field type info into deobfuscated_dump.json by class full name."""
    print('  Loading deobfuscated_dump.json ...')
    with open(DEOBF_JSON, 'r', encoding='utf-8') as f:
        dump = json.load(f)

    stats = {
        'classes_matched': 0,
        'fields_typed': 0,
        'fields_added': 0,  # fields that only exist in ft (deobf had none)
        'fields_total_before': 0,
        'classes_with_new_fields': 0,
        'field_count_mismatch': 0,
    }

    for ns, classes in dump['namespaces'].items():
        for cls in classes:
            cls_name = cls.get('name', '')
            if not cls_name or OBF_RE.match(cls_name):
                continue
            fullname = f'{ns}.{cls_name}' if ns else cls_name
            ft_cls = ft_by_fullname.get(fullname)
            if ft_cls is None:
                continue
            ft_fields = ft_cls.get('fields', [])
            if not ft_fields:
                continue

            deobf_fields = cls.get('fields', [])
            stats['fields_total_before'] += len(deobf_fields)
            stats['classes_matched'] += 1
            if deobf_fields and len(deobf_fields) != len(ft_fields):
                stats['field_count_mismatch'] += 1

            # Build new typed field list
            new_fields = []

            if deobf_fields:
                # Both have fields — pair by index (both in declaration order)
                for i, ft_f in enumerate(ft_fields):
                    ft_name = ft_f.get('n', ft_f.get('name', '?'))
                    ft_type = ft_f.get('t', ft_f.get('type', '?'))
                    ft_offset = ft_f.get('o', ft_f.get('offset', 0))

                    # Use deobf name if available (it may be deobfuscated)
                    if i < len(deobf_fields):
                        deobf_name = deobf_fields[i]
                        if isinstance(deobf_name, dict):
                            deobf_name = deobf_name.get('name', ft_name)
                        # Prefer deobf name unless it's just the obfuscated form
                        if isinstance(deobf_name, str) and not OBF_RE.match(deobf_name):
                            name = deobf_name
                        else:
                            name = ft_name
                    else:
                        name = ft_name

                    new_fields.append({
                        'name': name,
                        'type': ft_type,
                        'offset': ft_offset,
                    })
                    stats['fields_typed'] += 1
            else:
                # Only ft has fields — add them all
                stats['classes_with_new_fields'] += 1
                for ft_f in ft_fields:
                    ft_name = ft_f.get('n', ft_f.get('name', '?'))
                    ft_type = ft_f.get('t', ft_f.get('type', '?'))
                    ft_offset = ft_f.get('o', ft_f.get('offset', 0))
                    new_fields.append({
                        'name': ft_name,
                        'type': ft_type,
                        'offset': ft_offset,
                    })
                    stats['fields_added'] += 1

            cls['fields'] = new_fields

    # Save
    print('  Saving updated deobfuscated_dump.json ...')
    with open(DEOBF_JSON, 'w', encoding='utf-8') as f:
        json.dump(dump, f, indent=2, ensure_ascii=False)

    return dump, stats


def generate_cs(dump: dict):
    """Regenerate deobfuscated_dump.cs with type annotations."""
    print('  Generating deobfuscated_dump.cs with type annotations ...')

    lines = []
    lines.append('// VRChat IL2CPP Deobfuscated Dump (with field types)')
    lines.append(f'// Generated: {time.strftime("%Y-%m-%d %H:%M:%S")}')
    lines.append(f'// Source: deobfuscated_dump.json + field_types.json merge')
    lines.append('')

    class_count = 0
    for ns, classes in sorted(dump['namespaces'].items()):
        if ns:
            lines.append(f'namespace {ns}')
            lines.append('{')

        for cls in classes:
            class_count += 1
            name = cls['name']
            parent = cls.get('parent', '')
            original = cls.get('original_name', '')

            indent = '    ' if ns else ''

            # Class declaration
            if original:
                lines.append(f'{indent}// Original: {original}')
            decl = f'{indent}public class {name}'
            if parent and parent not in ('Object', 'ValueType', 'Enum'):
                decl += f' : {parent}'
            lines.append(decl)
            lines.append(f'{indent}{{')

            # Fields with types
            fields = cls.get('fields', [])
            for f in fields:
                if isinstance(f, dict):
                    fname = f.get('name', '?')
                    ftype = f.get('type', '?')
                    foffset = f.get('offset', 0)
                    # Clean up type for C# display
                    ftype_display = _cs_type(ftype)
                    if foffset > 0:
                        lines.append(f'{indent}    public {ftype_display} {fname}; // 0x{foffset:X}')
                    else:
                        lines.append(f'{indent}    public {ftype_display} {fname};')
                elif isinstance(f, str):
                    lines.append(f'{indent}    public object {f};')

            # Methods
            methods = cls.get('methods', [])
            ptrs = cls.get('method_pointers', {})
            if fields and methods:
                lines.append('')
            for m in methods:
                if isinstance(m, str):
                    ptr = ptrs.get(m, '')
                    if ptr:
                        lines.append(f'{indent}    public void {m}(); // {ptr}')
                    else:
                        lines.append(f'{indent}    public void {m}();')

            lines.append(f'{indent}}}')
            lines.append('')

        if ns:
            lines.append('}')
            lines.append('')

    with open(DEOBF_CS, 'w', encoding='utf-8') as f:
        f.write('\n'.join(lines))

    print(f'    {class_count:,} classes written to {DEOBF_CS.name}')


def _cs_type(t: str) -> str:
    """Convert internal type string to C#-friendly display."""
    if not t or t == '?':
        return 'object'
    # Strip err prefix info
    if t.startswith('err:'):
        return 'object /* ' + t + ' */'
    if t.startswith('type_0x'):
        return 'object /* ' + t + ' */'
    return t


def main():
    print('=' * 60)
    print('  Merge Field Types into Deobfuscated Dump')
    print('=' * 60)

    if not DEOBF_JSON.exists():
        print(f'ERROR: {DEOBF_JSON} not found')
        sys.exit(1)
    if not FIELD_TYPES.exists():
        print(f'ERROR: {FIELD_TYPES} not found')
        sys.exit(1)

    ft_by_fullname = load_field_types()
    dump, stats = merge_into_dump(ft_by_fullname)
    generate_cs(dump)

    print()
    print('  --- Merge Summary ---')
    print(f'  Classes matched by VA:   {stats["classes_matched"]:,}')
    print(f'  Fields with types added: {stats["fields_typed"]:,}')
    print(f'  New fields (deobf had none): {stats["fields_added"]:,}')
    print(f'  Classes gained fields:   {stats["classes_with_new_fields"]:,}')
    print(f'  Total typed fields:      {stats["fields_typed"] + stats["fields_added"]:,}')
    print()


if __name__ == '__main__':
    main()
