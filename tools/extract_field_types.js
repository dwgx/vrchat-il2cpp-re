/**
 * Frida script: Extract field TYPE information for all Il2CppClass instances.
 * Run with: frida -p <VRChat_PID> -l extract_field_types.js
 *
 * Reads the Il2CppClass structs we already know about (from precise_dump)
 * and extracts the field TYPE names that the Python dump didn't capture.
 *
 * Il2CppClass layout (from our research):
 *   +0x58: name (char*)
 *   +0x78: MethodInfo** methods
 *   +0x88: FieldInfo* fields
 *   +0x100: u16 method_count
 *   +0x122: u16 field_count
 *
 * FieldInfo layout (stride 0x30):
 *   +0x00: Il2CppType* type
 *   +0x08: char* name (at +0x20 based on our findings, let's verify)
 *   +0x20: char* name
 *
 * Il2CppType:
 *   +0x00: void* data (union: Il2CppClass* for CLASS/VALUETYPE, etc.)
 *   type info encoded in bitfield
 */

'use strict';

// Read the class VAs from precise_dump.json (passed as argument or loaded)
const BATCH_SIZE = 100;

function readCString(ptr) {
    if (ptr.isNull()) return null;
    try {
        return ptr.readUtf8String();
    } catch(e) {
        return null;
    }
}

function extractFieldTypes(classVa) {
    try {
        const classPtr = ptr(classVa);

        // Read class name
        const namePtr = classPtr.add(0x58).readPointer();
        const className = readCString(namePtr);
        if (!className) return null;

        // Read field count
        const fieldCount = classPtr.add(0x122).readU16();
        if (fieldCount === 0 || fieldCount > 500) return null;

        // Read fields pointer
        const fieldsPtr = classPtr.add(0x88).readPointer();
        if (fieldsPtr.isNull()) return null;

        const fields = [];
        for (let i = 0; i < fieldCount; i++) {
            const fieldBase = fieldsPtr.add(i * 0x30);

            // Field name at +0x20
            const fieldNamePtr = fieldBase.add(0x20).readPointer();
            const fieldName = readCString(fieldNamePtr);

            // Field type at +0x00
            const typePtr = fieldBase.add(0x00).readPointer();
            let typeName = "unknown";
            let typeNamespace = "";

            if (!typePtr.isNull()) {
                try {
                    // Il2CppType -> data is a union. For class/valuetype,
                    // data points to Il2CppClass* which has name at +0x58
                    const typeClassPtr = typePtr.readPointer();
                    if (!typeClassPtr.isNull()) {
                        const typeNameP = typeClassPtr.add(0x58).readPointer();
                        typeName = readCString(typeNameP) || "unknown";
                        const typeNsP = typeClassPtr.add(0x18).readPointer();
                        typeNamespace = readCString(typeNsP) || "";
                    }
                } catch(e) {
                    // type data might not be a class pointer for primitives
                }
            }

            // Field offset at +0x18
            let offset = 0;
            try {
                offset = fieldBase.add(0x18).readU32();
            } catch(e) {}

            fields.push({
                name: fieldName,
                type: typeName,
                type_namespace: typeNamespace,
                offset: offset,
                is_static: (offset === 0) // rough heuristic
            });
        }

        return {
            class_name: className,
            va: classVa,
            field_count: fieldCount,
            fields: fields
        };
    } catch(e) {
        return null;
    }
}

// Main: read class VAs from stdin or process all from dump
rpc.exports = {
    extractFieldTypes: function(classVas) {
        // classVas = array of hex strings like "0x341759B0"
        const results = [];
        for (const vaStr of classVas) {
            const result = extractFieldTypes(vaStr);
            if (result) {
                results.push(result);
            }
        }
        return results;
    },

    // Quick test with a single class
    testOne: function(vaStr) {
        return extractFieldTypes(vaStr);
    }
};

// Auto-run: output field types for console
console.log("[*] Field type extractor loaded. Use rpc.exports.extractFieldTypes([vas]) or rpc.exports.testOne(va)");
