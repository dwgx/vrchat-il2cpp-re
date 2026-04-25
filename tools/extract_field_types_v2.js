'use strict';

var STRING_BASE = ptr("0x66dde040");
var PRIMITIVES = {
    0x01:"void",0x02:"bool",0x03:"char",0x04:"sbyte",0x05:"byte",
    0x06:"short",0x07:"ushort",0x08:"int",0x09:"uint",
    0x0a:"long",0x0b:"ulong",0x0c:"float",0x0d:"double",
    0x0e:"string",0x0f:"IntPtr",0x16:"TypedByRef",0x18:"UIntPtr",0x1c:"object"
};

function readCStr(p) {
    if (p.isNull()) return null;
    try { var s = p.readUtf8String(); return (s && s.length < 300) ? s : null; } catch(e) { return null; }
}

function resolveTypeName(typeAddr, depth) {
    if (!depth) depth = 0;
    if (depth > 5) return "...";
    if (typeAddr.isNull()) return "?";
    try {
        var data = typeAddr.readPointer();
        var packed = typeAddr.add(8).readU32();
        var te = (packed >> 16) & 0xFF;
        if (PRIMITIVES[te]) return PRIMITIVES[te];

        // CLASS (0x12) / VALUETYPE (0x11) — data is TypeDefinition*
        if (te === 0x11 || te === 0x12) {
            if (!data.isNull()) {
                var ni = data.readU32();
                var nsi = data.add(4).readU32();
                var n = readCStr(STRING_BASE.add(ni)) || "?";
                var ns = readCStr(STRING_BASE.add(nsi)) || "";
                return (ns ? ns + "." : "") + n;
            }
        }

        // SZARRAY (0x1d) — data is Il2CppType* of element
        if (te === 0x1d) return resolveTypeName(data, depth+1) + "[]";

        // GENERICINST (0x15) — data is Il2CppGenericClass*
        //   Il2CppGenericClass+0x00: Il2CppType* type (the generic definition)
        //   Il2CppGenericClass+0x08: Il2CppGenericContext (contains Il2CppGenericInst*)
        //   Il2CppGenericInst+0x00: uint argc
        //   Il2CppGenericInst+0x08: Il2CppType** argv
        if (te === 0x15) {
            if (!data.isNull()) {
                var genDefType = data.readPointer();
                var baseName = resolveTypeName(genDefType, depth+1);
                // Try to resolve generic arguments
                try {
                    var genInstPtr = data.add(0x08).readPointer(); // Il2CppGenericContext.class_inst
                    if (!genInstPtr.isNull()) {
                        var argc = genInstPtr.readU32();
                        if (argc > 0 && argc <= 16) {
                            var argv = genInstPtr.add(0x08).readPointer();
                            var args = [];
                            for (var g = 0; g < argc; g++) {
                                var argType = argv.add(g * Process.pointerSize).readPointer();
                                args.push(resolveTypeName(argType, depth+1));
                            }
                            return baseName + "<" + args.join(",") + ">";
                        }
                    }
                } catch(ge) {}
                return baseName + "<...>";
            }
        }

        // PTR (0x0f) / BYREF (0x10) — data is Il2CppType*
        if (te === 0x0f || te === 0x10) return resolveTypeName(data, depth+1) + (te === 0x0f ? "*" : "&");

        // VAR (0x13) — generic type parameter (T, U, etc.)
        if (te === 0x13) {
            var paramIdx = data.toUInt32();
            var tnames = ["T","U","V","W","T4","T5","T6","T7"];
            return paramIdx < tnames.length ? tnames[paramIdx] : "T" + paramIdx;
        }

        // MVAR (0x1e) — generic method parameter (TResult, etc.)
        if (te === 0x1e) {
            var mparamIdx = data.toUInt32();
            var mnames = ["TResult","TKey","TValue","TSource","TM4","TM5"];
            return mparamIdx < mnames.length ? mnames[mparamIdx] : "TM" + mparamIdx;
        }

        // ARRAY (0x14) — multi-dimensional array
        if (te === 0x14) {
            // data points to Il2CppArrayType: Il2CppType* at +0x00, rank at +0x08
            if (!data.isNull()) {
                var elemType = data.readPointer();
                var rank = data.add(0x08).readU8();
                var dims = rank > 1 ? "[" + new Array(rank).join(",") + "]" : "[]";
                return resolveTypeName(elemType, depth+1) + dims;
            }
        }

        return "type_0x" + te.toString(16);
    } catch(e) { return "err:" + te + ":" + e.message.substring(0,30); }
}

rpc.exports = {
    extractBatch: function(vas) {
        var results = [];
        for (var i = 0; i < vas.length; i++) {
            try {
                var cls = ptr(vas[i]);
                var name = readCStr(cls.add(0x58).readPointer());
                if (!name) continue;
                var ns = readCStr(cls.add(0x18).readPointer()) || "";
                var fieldsPtr = cls.add(0xA0).readPointer();
                var fieldCount = cls.add(0x124).readU16();
                if (fieldCount === 0 || fieldCount > 1000 || fieldsPtr.isNull()) {
                    results.push({va: vas[i], name: name, ns: ns, fc: 0, fields: []});
                    continue;
                }
                var fields = [];
                for (var j = 0; j < fieldCount; j++) {
                    var fb = fieldsPtr.add(j * 0x20);
                    var fn = readCStr(fb.add(0x10).readPointer()) || "?";
                    var ta = fb.add(0x08).readPointer();
                    var tn = resolveTypeName(ta);
                    var off = fb.add(4).readU32();
                    fields.push({n: fn, t: tn, o: off});
                }
                results.push({va: vas[i], name: name, ns: ns, fc: fieldCount, fields: fields});
            } catch(e) {
                results.push({va: vas[i], error: e.message});
            }
        }
        return results;
    }
};
