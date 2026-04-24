'use strict';

// Identify ComplexComponent MonoBehaviours by finding their runtime instances
// and reading the GameObject names they're attached to.
//
// Strategy:
// 1. For each ComplexComponent class VA, read the static fields area
//    to find singleton/instance references
// 2. For MonoBehaviour instances: read the m_CachedPtr (native Unity object ptr)
//    at offset +0x10, then use Unity internal API to get GameObject name
// 3. Alternative: scan GC heap for instances of each class

// Beebyte Il2CppClass layout:
//   +0x00: Il2CppImage*
//   +0x18: char* namespace
//   +0x58: char* name
//   +0xA0: FieldInfo* (stride 0x20)
//   +0x124: uint16 field_count
//   +0xB8: static fields data pointer (standard IL2CPP)
//   +0xD0: vtable start (standard)

function readCStr(p) {
    if (p.isNull()) return null;
    try { var s = p.readUtf8String(); return (s && s.length < 500) ? s : null; } catch(e) { return null; }
}

// For each class VA, try to find instances:
// Method 1: Check static fields for self-references
// Method 2: Read the "instance" static field (common singleton pattern)
function findStaticInstance(classVA) {
    var cls = ptr(classVA);

    // Read static fields base - try various offsets for Beebyte
    // Standard: +0xB8 = static_fields pointer
    var staticPtrs = [];
    for (var off = 0xB0; off <= 0xC8; off += 8) {
        try {
            var p = cls.add(off).readPointer();
            if (!p.isNull() && p.compare(ptr("0x10000000")) > 0 && p.compare(ptr("0x80000000")) < 0) {
                staticPtrs.push({off: off, ptr: p});
            }
        } catch(e) {}
    }

    // For each static fields area, scan for pointers that look like instances
    // An instance starts with a klass pointer (offset +0x0 = Il2CppClass*)
    var instances = [];
    staticPtrs.forEach(function(sp) {
        // Read up to 2KB of static data
        for (var i = 0; i < 256; i += 8) {
            try {
                var val = sp.ptr.add(i).readPointer();
                if (val.isNull() || val.compare(ptr("0x10000000")) < 0) continue;
                // Check if val points to an object whose klass == our class
                var objKlass = val.readPointer();
                if (objKlass.equals(cls)) {
                    instances.push(val);
                }
            } catch(e) {}
        }
    });

    return instances;
}

// Read the GameObject name from a MonoBehaviour instance
// MonoBehaviour inherits Component which inherits Object
// Unity Object has m_CachedPtr at instance+0x10 (after IL2CPP header)
// The native Unity object has the name accessible via C++ vtable
//
// Alternative simpler approach:
// Unity stores the object name as an Il2CppString at a known offset
// For UnityEngine.Object, there's typically a "name" property
// Let's try reading it through the managed fields

function getGameObjectName(instance) {
    // MonoBehaviour -> Component -> Behaviour -> UnityEngine.Object
    // UnityEngine.Object has m_CachedPtr at +0x10
    // We can call Object.get_name() if we know the method pointer
    // Or read the native object's name directly

    // The native Unity object (m_CachedPtr) stores data including name
    try {
        var cachedPtr = instance.add(0x10).readPointer();
        if (cachedPtr.isNull()) return null;

        // Native UnityEngine Object layout (approximate):
        // The name is typically accessible through the vtable
        // But simpler: Unity C++ Object has m_Name at varying offsets
        // Let's try reading nearby offsets for an Il2CppString*

        // Actually, for managed MonoBehaviour, the gameObject reference
        // might be accessible through Component's internal pointer
        // Let me try: the gameObject is available via native pointer chain

        // Read the gameObject native ptr from Component
        // In Unity internals: Component has m_GameObject pointer
        // Usually at native_ptr + some_offset

        // For now, just return the native ptr for identification
        return "native:" + cachedPtr;
    } catch(e) {
        return null;
    }
}

rpc.exports = {
    // For each class VA, find static instances and return info
    probeClasses: function(classVAs) {
        var results = [];
        for (var i = 0; i < classVAs.length; i++) {
            var va = classVAs[i];
            try {
                var cls = ptr(va);
                var origName = readCStr(cls.add(0x58).readPointer()) || "?";
                var ns = readCStr(cls.add(0x18).readPointer()) || "";

                // Find instances through static fields
                var instances = findStaticInstance(va);

                var instInfo = [];
                instances.forEach(function(inst) {
                    var goName = getGameObjectName(inst);
                    instInfo.push({ptr: inst.toString(), go: goName});
                });

                results.push({
                    va: va,
                    origName: origName,
                    ns: ns,
                    instances: instInfo.length,
                    details: instInfo.slice(0, 3)
                });
            } catch(e) {
                results.push({va: va, error: e.message});
            }
        }
        return results;
    },

    // Smarter approach: scan the class's vtable for known Unity methods
    // and use that to identify functionality
    analyzeVtable: function(classVA) {
        var cls = ptr(classVA);
        var origName = readCStr(cls.add(0x58).readPointer()) || "?";

        // Method info in Beebyte:
        // MethodInfo at cls + some_offset, or through vtable
        // Let's read method pointers from the method array
        // Standard: methods at +0x88 (but Beebyte: that's PropertyInfo)
        // Try +0x90 or other offsets

        var info = {origName: origName, methods: []};

        // Try to find method count and method array
        // Check various offsets for method-like data
        for (var off = 0x80; off <= 0xB0; off += 8) {
            try {
                var p = cls.add(off).readPointer();
                if (p.isNull()) continue;

                // Check if this looks like a method array (array of MethodInfo*)
                // MethodInfo has: +0x00=code_ptr, +0x08=code_ptr(dup), +0x18=name
                var testMethod = p.readPointer(); // first method's code ptr
                var testName = p.add(0x18).readPointer();
                var name = readCStr(testName);
                if (name && name.length > 0 && name.length < 100) {
                    info.methodArrayOff = off;
                    // Read a few method names
                    for (var mi = 0; mi < 10; mi++) {
                        try {
                            var mptr = p.add(mi * 0x30); // guess stride
                            var mn = readCStr(mptr.add(0x18).readPointer());
                            if (mn) info.methods.push(mn);
                        } catch(e) { break; }
                    }
                    break;
                }
            } catch(e) {}
        }

        return info;
    }
};
