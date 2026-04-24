#!/usr/bin/env python3
"""
Extract field TYPE information directly from IL2CPP global-metadata.dat.

IL2CPP metadata v29 layout (relevant parts):
  Header offsets:
    +0x04: version
    +0x08: stringLiteralOffset, +0x0C: stringLiteralSize
    +0x10: stringLiteralDataOffset, +0x14: stringLiteralDataSize
    +0x18: stringOffset, +0x1C: stringSize
    ...
    +0xA8: typeDefinitionsOffset, +0xAC: typeDefinitionsSize
    +0xB8: fieldDefaultValuesOffset, +0xBC: fieldDefaultValuesSize
    +0xC0: fieldAndParameterDefaultValueDataOffset, +0xC4: fieldAndParameterDefaultValueDataSize
    +0xC8: fieldMarshaledSizesOffset
    ...

  We need:
    - strings (for names)
    - typeDefinitions (class metadata)
    - each TypeDefinition has fieldStart + field_count
    - field definitions have typeIndex + nameIndex

  Il2CppFieldDefinition (12 bytes):
    +0x00: int32 nameIndex
    +0x04: int32 typeIndex
    +0x08: uint32 token

  Il2CppTypeDefinition (108 bytes in v29):
    +0x00: int32 nameIndex
    +0x04: int32 namespaceIndex
    ...
    +0x40: int32 fieldStart
    +0x44: int32 methodStart
    ...
    +0x5C: uint16 field_count
    +0x5E: uint16 method_count
    ...
"""

import struct, json, sys, os
from pathlib import Path

BASE_DIR = Path(__file__).resolve().parent.parent
METADATA_PATH = BASE_DIR / 'metadata' / 'global-metadata-fixed.dat'
OUTPUT_PATH = BASE_DIR / 'output' / 'field_types_from_metadata.json'
PRECISE_DUMP_PATH = BASE_DIR / 'data' / 'precise_dump.json'

sys.stdout.reconfigure(encoding='utf-8')


def read_metadata():
    with open(METADATA_PATH, 'rb') as f:
        data = f.read()

    # Header
    magic = struct.unpack_from('<I', data, 0)[0]
    version = struct.unpack_from('<i', data, 4)[0]
    print(f"Metadata magic: 0x{magic:08X}, version: {version}")

    if magic != 0xFAB11BAF:
        print("WARNING: Magic mismatch! Trying anyway...")

    # Parse header offsets (v29 has many fields)
    # String table
    string_offset = struct.unpack_from('<i', data, 0x18)[0]
    string_size = struct.unpack_from('<i', data, 0x1C)[0]

    # Type definitions
    typedef_offset = struct.unpack_from('<i', data, 0xA8)[0]
    typedef_size = struct.unpack_from('<i', data, 0xAC)[0]

    # Field definitions
    field_def_offset = struct.unpack_from('<i', data, 0x98)[0]
    field_def_size = struct.unpack_from('<i', data, 0x9C)[0]

    # Type references (Il2CppTypeDefinitionSizes or Il2CppType table)
    # In v29, the "images" and "assemblies" tables also matter

    print(f"Strings: offset=0x{string_offset:X}, size={string_size}")
    print(f"TypeDefs: offset=0x{typedef_offset:X}, size={typedef_size}")
    print(f"FieldDefs: offset=0x{field_def_offset:X}, size={field_def_size}")

    # Helper: read null-terminated string from string table
    def get_string(index):
        if index < 0 or index >= string_size:
            return ""
        start = string_offset + index
        end = data.index(b'\x00', start)
        return data[start:end].decode('utf-8', errors='replace')

    # Parse type definitions
    TYPEDEF_SIZE = 108  # v29
    num_typedefs = typedef_size // TYPEDEF_SIZE
    print(f"TypeDefs count: {num_typedefs}")

    # Parse field definitions
    FIELDDEF_SIZE = 12
    num_fields = field_def_size // FIELDDEF_SIZE
    print(f"FieldDefs count: {num_fields}")

    # Build field definitions array
    field_defs = []
    for i in range(num_fields):
        off = field_def_offset + i * FIELDDEF_SIZE
        name_idx = struct.unpack_from('<i', data, off)[0]
        type_idx = struct.unpack_from('<i', data, off + 4)[0]
        token = struct.unpack_from('<I', data, off + 8)[0]
        field_defs.append({
            'name': get_string(name_idx),
            'type_index': type_idx,
            'token': token
        })

    # Build type definitions with their fields
    results = {}
    for i in range(num_typedefs):
        off = typedef_offset + i * TYPEDEF_SIZE
        name_idx = struct.unpack_from('<i', data, off + 0x00)[0]
        ns_idx = struct.unpack_from('<i', data, off + 0x04)[0]
        field_start = struct.unpack_from('<i', data, off + 0x40)[0]
        field_count = struct.unpack_from('<H', data, off + 0x5C)[0]

        name = get_string(name_idx)
        namespace = get_string(ns_idx)

        if field_count == 0 or field_count > 2000:
            continue

        # Sanity check field_start
        if field_start < 0 or field_start + field_count > num_fields:
            continue

        fields = []
        for fi in range(field_start, field_start + field_count):
            fd = field_defs[fi]
            fields.append({
                'name': fd['name'],
                'type_index': fd['type_index'],
                'token': fd['token']
            })

        full_name = f"{namespace}.{name}" if namespace else name
        results[full_name] = {
            'namespace': namespace,
            'name': name,
            'typedef_index': i,
            'fields': fields
        }

    print(f"\nTypes with fields: {len(results)}")

    # Now we need to resolve type_index to actual type names
    # The type_index in field definitions refers to the Il2CppType table
    # which is NOT in metadata but in the binary (Il2CppCodeRegistration.types)
    # However, for simple cases, we can check if type_index maps to a typedef

    # Actually, Il2CppType is stored in the binary, not metadata.
    # But we can get a LOT from just matching field names + class names.
    # Let's output what we have and resolve types via the binary later.

    return results, field_defs, num_typedefs, data, string_offset, string_size, get_string, typedef_offset, TYPEDEF_SIZE


def resolve_type_indices(data, get_string, typedef_offset, TYPEDEF_SIZE, num_typedefs, field_defs):
    """Try to build a type_index -> type_name mapping.

    In IL2CPP v29, field type indices reference the Il2CppType array in
    Il2CppCodeRegistration (binary), not metadata. But for CLASS and
    VALUETYPE types, the Il2CppType.data is a TypeDefinitionIndex which
    IS a metadata index.

    We can try another approach: use the parameterDefaultValues or
    look at generic parameters. But simplest: just use the metadata
    to build typedef_index -> name, then when we find type_index values
    that match typedef indices, we can resolve them.

    Actually, a much better approach: the global-metadata.dat does NOT
    contain Il2CppType entries. Those are generated at load time from
    the binary's CodeRegistration. So type_index from FieldDefinition
    can only be resolved at runtime.

    Instead, let's use the approach of reading Il2CppType* from memory
    using a different strategy.
    """
    # Build typedef_index -> name
    typedef_names = {}
    for i in range(num_typedefs):
        off = typedef_offset + i * TYPEDEF_SIZE
        name_idx = struct.unpack_from('<i', data, off + 0x00)[0]
        ns_idx = struct.unpack_from('<i', data, off + 0x04)[0]
        name = get_string(name_idx)
        ns = get_string(ns_idx)
        typedef_names[i] = f"{ns}.{name}" if ns else name

    # Collect unique type indices from fields
    type_indices = set()
    for fd in field_defs:
        type_indices.add(fd['type_index'])

    print(f"Unique type indices in fields: {len(type_indices)}")
    print(f"Type index range: {min(type_indices)} to {max(type_indices)}")
    print(f"TypeDef count: {num_typedefs}")

    # Check how many type indices fall within typedef range
    in_range = sum(1 for ti in type_indices if 0 <= ti < num_typedefs)
    print(f"Type indices within typedef range: {in_range}/{len(type_indices)}")

    return typedef_names, type_indices


def main():
    print("=" * 60)
    print("Extracting Field Types from IL2CPP Metadata")
    print("=" * 60)

    results, field_defs, num_typedefs, data, string_offset, string_size, get_string, typedef_offset, TYPEDEF_SIZE = read_metadata()

    typedef_names, type_indices = resolve_type_indices(
        data, get_string, typedef_offset, TYPEDEF_SIZE, num_typedefs, field_defs
    )

    # Output results with type_index for later resolution
    output = {
        'summary': {
            'types_with_fields': len(results),
            'total_field_defs': len(field_defs),
            'unique_type_indices': len(type_indices),
            'type_index_range': [min(type_indices), max(type_indices)],
            'num_typedefs': num_typedefs
        },
        'types': results
    }

    # Save
    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, ensure_ascii=False, indent=1)
    print(f"\nSaved to: {OUTPUT_PATH}")
    fsize = os.path.getsize(OUTPUT_PATH)
    print(f"File size: {fsize / 1024 / 1024:.1f} MB")

    # Show some examples
    print("\n--- Sample Types ---")
    for name in ['Keyboard', 'SteamVR_Actions', 'VRCPlayer', 'Vector3']:
        for full_name, info in results.items():
            if info['name'] == name:
                print(f"\n{full_name}:")
                for f in info['fields'][:5]:
                    tidx = f['type_index']
                    tname = typedef_names.get(tidx, f"type#{tidx}")
                    print(f"  {f['name']}: type_index={tidx} -> {tname}")
                if len(info['fields']) > 5:
                    print(f"  ... ({len(info['fields'])} total)")
                break


if __name__ == '__main__':
    main()
