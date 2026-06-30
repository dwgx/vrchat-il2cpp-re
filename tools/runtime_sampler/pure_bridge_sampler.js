/**
 * pure_bridge_sampler.js — Approach B (PURE BRIDGE comparison arm)
 *
 * Goal: drive VRChat IL2CPP runtime instance-value sampling through
 * frida-il2cpp-bridge (vfsfitvnm)'s own API (Il2Cpp.Object.field(name),
 * .class.fields, gc.choose, etc.) instead of manual offsets — IF the bridge can
 * resolve the il2cpp_* exports. VRChat uses a Beebyte-renamed export table, so
 * this script:
 *
 *   1. Wires Il2Cpp.$config.exports from the repo's CONFIRMED export mapping so
 *      findExportByName misses can be patched (the bridge's official escape hatch,
 *      dist/index.js line 304-322 / 697-716). RVAs are resolved per-session
 *      against the live module base (ASLR-safe).
 *   2. Tries the pure-bridge read path first (bridge metadata API).
 *   3. Falls back to a RAW-OFFSET reader (verified Beebyte struct offsets, ZERO
 *      export calls) for everything the bridge cannot reach — which on this
 *      binary is the path that actually runs end-to-end. See B_DESIGN.md VERDICT.
 *
 * Output schema matches Approach A:
 *   { klass, className, namespace, parent, instances: [
 *       { addr, stringFields: {name:val}, classNameFields: {name:className},
 *         numericFields: {name:val}, toString } ] }
 *
 * Run (NOT done here — VRChat not running; syntax validated with `node --check`):
 *   frida -p <VRChat pid> -l pure_bridge_sampler.js
 * then call rpc.exports.sample("<obfClassName>") or .sampleByPtr("0x...").
 *
 * NOTE: 'frida-il2cpp-bridge' is a Frida-agent module; it is normally bundled via
 * frida-compile. This file degrades gracefully: if Il2Cpp is unavailable it runs
 * pure raw-offset mode, so it loads as a standalone Frida script too.
 */

'use strict';

/* ------------------------------------------------------------------ *
 *  Verified Beebyte struct offsets (match tools/vrc_frida_lib.js)
 *  Jun build Il2CppClass / FieldInfo / Il2CppString / MethodInfo layout.
 * ------------------------------------------------------------------ */
const OFF = {
    KLASS_NAME: 0x50,        // char*  class name
    KLASS_NS: 0x18,          // char*  namespace
    KLASS_METHODS: 0x88,     // MethodInfo** array
    KLASS_FIELDS: 0x1D8,     // FieldInfo*  array
    KLASS_PARENT: 0x80,      // Il2CppClass* parent
    KLASS_STATICS: 0xB8,     // static field data
    KLASS_MCOUNT: 0x120,     // uint16 method_count
    KLASS_FCOUNT: 0x122,     // uint16 field_count
    FIELD_STRIDE: 0x30,      // sizeof(FieldInfo) in this layout
    FIELD_NAME: 0x08,        // char* (within FieldInfo)
    FIELD_OFFSET: 0x04,      // uint32 instance offset
    FIELD_TYPE: 0x10,        // Il2CppType*
    OBJ_KLASS: 0x00,         // Il2CppObject.klass at +0x00
    STR_LEN: 0x10,           // Il2CppString length (int32)
    STR_CHARS: 0x14,         // Il2CppString UTF-16 chars
};

/* IL2CppTypeEnum values we treat as "string" / "numeric" for raw reads. */
const IL2CPP_TYPE = {
    I1: 0x04, U1: 0x05, I2: 0x06, U2: 0x07, I4: 0x08, U4: 0x09,
    I8: 0x0a, U8: 0x0b, R4: 0x0c, R8: 0x0d, BOOLEAN: 0x02, CHAR: 0x03,
    STRING: 0x0e, CLASS: 0x12, OBJECT: 0x1c, SZARRAY: 0x1d, GENERICINST: 0x15,
};

/* ------------------------------------------------------------------ *
 *  Per-session export override table (loaded from repo mapping).
 *  Format injected by the loader / RPC: { "il2cpp_domain_get": "0xa2...rva", ... }
 *  Only CONFIRMED mappings should be supplied; low-confidence guesses are unsafe.
 * ------------------------------------------------------------------ */
let EXPORT_RVA = {
    // Confirmed in data/export_mapping.json -> final_mapping (obf name resolved to RVA at runtime).
    // These are the only mappings the bridge can trust today. The 25 core sampler-path
    // APIs are NOT confirmed (see B_DESIGN.md §2), so the bridge path will not fully resolve.
    // Populate via rpc.exports.setExportMap({...}) before perform() if you have more.
};

function gaModule() {
    const m = Process.findModuleByName('GameAssembly.dll');
    if (!m) throw new Error('GameAssembly.dll not found in target');
    return m;
}

/* Build a $config.exports table of () => NativePointer from RVA overrides,
 * resolved against the LIVE module base (ASLR-safe). */
function buildExportOverrides(base) {
    const overrides = {};
    for (const [api, rva] of Object.entries(EXPORT_RVA)) {
        const off = (typeof rva === 'string') ? ptr(rva) : ptr(rva.toString());
        overrides[api] = () => base.add(off);
    }
    return overrides;
}

/* ------------------------------------------------------------------ *
 *  RAW-OFFSET readers (no export calls — survives the anti-tamper
 *  return-address check because nothing calls into GA).
 * ------------------------------------------------------------------ */
const Raw = {
    cstr(p) {
        try {
            if (!p || p.isNull()) return null;
            const s = p.readUtf8String();
            return (s && s.length < 512) ? s : null;
        } catch (e) { return null; }
    },

    klassName(klass) {
        try { return Raw.cstr(klass.add(OFF.KLASS_NAME).readPointer()); } catch (e) { return null; }
    },
    klassNamespace(klass) {
        try { return Raw.cstr(klass.add(OFF.KLASS_NS).readPointer()); } catch (e) { return null; }
    },
    klassParent(klass) {
        try {
            const p = klass.add(OFF.KLASS_PARENT).readPointer();
            return p.isNull() ? null : p;
        } catch (e) { return null; }
    },

    /* Returns [{ptr,name,offset,typeAddr,typeEnum}] — instance fields only path. */
    klassFields(klass) {
        const out = [];
        try {
            const base = klass.add(OFF.KLASS_FIELDS).readPointer();
            if (base.isNull()) return out;
            let count = klass.add(OFF.KLASS_FCOUNT).readU16();
            if (count > 1000) count = 1000;
            for (let i = 0; i < count; i++) {
                const fb = base.add(i * OFF.FIELD_STRIDE);
                const typeAddr = fb.add(OFF.FIELD_TYPE).readPointer();
                out.push({
                    ptr: fb,
                    name: Raw.cstr(fb.add(OFF.FIELD_NAME).readPointer()) || '?',
                    offset: fb.add(OFF.FIELD_OFFSET).readU32(),
                    typeAddr: typeAddr,
                    typeEnum: Raw.typeEnum(typeAddr),
                });
            }
        } catch (e) { /* swallow — partial read */ }
        return out;
    },

    /* Il2CppType: the type enum is the high byte of the bitfield at +0x00 of Il2CppType.
     * Layout: { void* data; uint16 attrs; uint8 type; uint8 bits; } on x64 — type at +0x0A.
     * We read defensively and validate against the known enum range. */
    typeEnum(typeAddr) {
        try {
            if (!typeAddr || typeAddr.isNull()) return -1;
            const t = typeAddr.add(0x0a).readU8();
            return (t > 0 && t < 0x40) ? t : -1;
        } catch (e) { return -1; }
    },

    objKlass(obj) {
        try { return obj.add(OFF.OBJ_KLASS).readPointer(); } catch (e) { return null; }
    },

    /* Il2CppString -> JS string via raw len/chars offsets. */
    readString(strPtr) {
        try {
            if (!strPtr || strPtr.isNull()) return null;
            const len = strPtr.add(OFF.STR_LEN).readInt();
            if (len <= 0 || len > 4096) return null;
            return strPtr.add(OFF.STR_CHARS).readUtf16String(len);
        } catch (e) { return null; }
    },

    /* Read one instance field given its raw descriptor + the object base. */
    readField(obj, field) {
        const at = obj.add(field.offset);
        const te = field.typeEnum;
        try {
            switch (te) {
                case IL2CPP_TYPE.STRING:
                    return { kind: 'string', value: Raw.readString(at.readPointer()) };
                case IL2CPP_TYPE.CLASS:
                case IL2CPP_TYPE.OBJECT: {
                    const ref = at.readPointer();
                    if (ref.isNull()) return { kind: 'class', value: null };
                    const k = Raw.objKlass(ref);
                    return { kind: 'class', value: k ? Raw.klassName(k) : null };
                }
                case IL2CPP_TYPE.BOOLEAN: return { kind: 'numeric', value: at.readU8() !== 0 };
                case IL2CPP_TYPE.I1: return { kind: 'numeric', value: at.readS8() };
                case IL2CPP_TYPE.U1: return { kind: 'numeric', value: at.readU8() };
                case IL2CPP_TYPE.I2: return { kind: 'numeric', value: at.readS16() };
                case IL2CPP_TYPE.U2: case IL2CPP_TYPE.CHAR: return { kind: 'numeric', value: at.readU16() };
                case IL2CPP_TYPE.I4: return { kind: 'numeric', value: at.readS32() };
                case IL2CPP_TYPE.U4: return { kind: 'numeric', value: at.readU32() };
                case IL2CPP_TYPE.I8: return { kind: 'numeric', value: at.readS64().toString() };
                case IL2CPP_TYPE.U8: return { kind: 'numeric', value: at.readU64().toString() };
                case IL2CPP_TYPE.R4: return { kind: 'numeric', value: at.readFloat() };
                case IL2CPP_TYPE.R8: return { kind: 'numeric', value: at.readDouble() };
                default:
                    return { kind: 'skip', value: null };
            }
        } catch (e) { return { kind: 'error', value: null }; }
    },
};

/* ------------------------------------------------------------------ *
 *  Manual heap scan for instances of a klass (no export call).
 *  Mirrors approach A's findInstances: scan committed RW ranges for
 *  pointers whose +0x00 klass matches. Bounded for safety.
 * ------------------------------------------------------------------ */
function rawFindInstances(klass, maxResults) {
    const results = [];
    const limit = maxResults || 64;
    const ranges = Process.enumerateRanges('rw-');
    for (const r of ranges) {
        // skip giant ranges to bound cost; heap objects live in many medium ranges
        if (r.size > 0x8000000) continue;
        let off = 0;
        const base = r.base;
        const size = r.size;
        while (off < size) {
            try {
                const cand = base.add(off).readPointer();
                if (!cand.isNull()) {
                    const k = Raw.objKlass(cand);
                    if (k && !k.isNull() && k.equals(klass)) {
                        results.push(cand);
                        if (results.length >= limit) return results;
                    }
                }
            } catch (e) {
                off += 0x1000 - (off % 0x1000) - 0x8; // jump to next page on fault
            }
            off += Process.pointerSize;
        }
    }
    return results;
}

/* ------------------------------------------------------------------ *
 *  Pure-bridge availability probe.
 *  Returns true only if the bridge resolves the CORE sampler-path exports.
 * ------------------------------------------------------------------ */
function bridgeCoreUsable() {
    if (typeof Il2Cpp === 'undefined') return false;
    try {
        // Touching these getters builds NativeFunctions; .isNull() tells us if the
        // export resolved. The bridge returns a throwing Proxy for unresolved ones,
        // so we guard with try/catch and an explicit isNull where possible.
        const probes = ['objectGetClass', 'classGetName', 'classGetFields', 'fieldGetOffset'];
        for (const p of probes) {
            const fn = Il2Cpp.exports[p];
            if (!fn || (fn.isNull && fn.isNull())) return false;
        }
        return true;
    } catch (e) {
        return false;
    }
}

/* ------------------------------------------------------------------ *
 *  Bridge-path sampler (used only if bridgeCoreUsable()).
 * ------------------------------------------------------------------ */
function sampleViaBridge(klassNameOrObj, maxInstances) {
    const limit = maxInstances || 32;
    const klass = (typeof klassNameOrObj === 'string')
        ? resolveClassViaBridge(klassNameOrObj)
        : klassNameOrObj;
    if (!klass) throw new Error('class not resolved via bridge');

    const out = {
        mode: 'bridge',
        klass: klass.handle.toString(),
        className: klass.name,
        namespace: klass.namespace || '',
        parent: klass.parent ? klass.parent.name : null,
        instances: [],
    };

    const found = Il2Cpp.gc.choose(klass).slice(0, limit);
    for (const obj of found) {
        const inst = { addr: obj.handle.toString(), stringFields: {}, classNameFields: {}, numericFields: {}, toString: null };
        for (const f of klass.fields) {
            if (f.isStatic) continue;
            try {
                const v = obj.field(f.name).value;
                classifyBridgeValue(f.name, v, inst);
            } catch (e) { /* unreadable field */ }
        }
        try { inst.toString = obj.toString(); } catch (e) { /* ignore */ }
        out.instances.push(inst);
    }
    return out;
}

function resolveClassViaBridge(name) {
    // Search assemblies/images for a class by (namespace.)name. Best-effort.
    for (const asm of Il2Cpp.domain.assemblies) {
        try {
            const img = asm.image;
            for (const k of img.classes) {
                if (k.name === name) return k;
            }
        } catch (e) { /* skip image */ }
    }
    return null;
}

function classifyBridgeValue(name, v, inst) {
    if (v == null) return;
    const t = typeof v;
    if (t === 'number' || t === 'boolean') { inst.numericFields[name] = v; return; }
    if (t === 'string') { inst.stringFields[name] = v; return; }
    // Il2Cpp.String / Il2Cpp.Object wrappers
    try {
        if (v.content !== undefined && typeof v.content === 'string') { inst.stringFields[name] = v.content; return; }
        if (v.class && v.class.name) { inst.classNameFields[name] = v.class.name; return; }
    } catch (e) { /* ignore */ }
}

/* ------------------------------------------------------------------ *
 *  Raw-path sampler (the path that actually runs on this binary).
 * ------------------------------------------------------------------ */
function sampleViaRaw(klassPtr, maxInstances) {
    const klass = (typeof klassPtr === 'string') ? ptr(klassPtr) : klassPtr;
    const out = {
        mode: 'raw',
        klass: klass.toString(),
        className: Raw.klassName(klass),
        namespace: Raw.klassNamespace(klass) || '',
        parent: (() => { const p = Raw.klassParent(klass); return p ? Raw.klassName(p) : null; })(),
        instances: [],
    };
    const fields = Raw.klassFields(klass);
    const found = rawFindInstances(klass, maxInstances || 32);
    for (const obj of found) {
        const inst = { addr: obj.toString(), stringFields: {}, classNameFields: {}, numericFields: {}, toString: null };
        for (const f of fields) {
            const r = Raw.readField(obj, f);
            if (r.value === null && r.kind !== 'class') continue;
            if (r.kind === 'string') inst.stringFields[f.name] = r.value;
            else if (r.kind === 'class') { if (r.value) inst.classNameFields[f.name] = r.value; }
            else if (r.kind === 'numeric') inst.numericFields[f.name] = r.value;
        }
        out.instances.push(inst);
    }
    return out;
}

/* ------------------------------------------------------------------ *
 *  Orchestration: try bridge, fall back to raw.
 * ------------------------------------------------------------------ */
function runSample(target, maxInstances) {
    const base = gaModule().base;

    // Wire export overrides into the bridge config if present.
    if (typeof Il2Cpp !== 'undefined') {
        try {
            Il2Cpp.$config.moduleName = 'GameAssembly.dll';
            const overrides = buildExportOverrides(base);
            if (Object.keys(overrides).length) {
                Il2Cpp.$config.exports = Object.assign({}, Il2Cpp.$config.exports, overrides);
            }
        } catch (e) { /* bridge not loaded; raw only */ }
    }

    if (bridgeCoreUsable()) {
        try {
            send({ type: 'info', msg: 'core exports resolved — using PURE BRIDGE path' });
            return sampleViaBridge(target, maxInstances);
        } catch (e) {
            send({ type: 'warn', msg: 'bridge path failed mid-run: ' + e.message + ' — falling back to raw' });
        }
    } else {
        send({ type: 'info', msg: 'bridge core exports NOT resolvable on this Beebyte binary — using RAW-OFFSET fallback (see B_DESIGN.md)' });
    }

    // target for raw path must be a klass pointer (string addr) since name->klass
    // needs class_from_name which is unresolved. Caller supplies klass ptr.
    if (typeof target === 'string' && /^0x/i.test(target)) {
        return sampleViaRaw(target, maxInstances);
    }
    throw new Error('raw fallback needs a klass pointer (0x...); name lookup requires unresolved il2cpp_class_from_name');
}

/* ------------------------------------------------------------------ *
 *  RPC surface
 * ------------------------------------------------------------------ */
rpc.exports = {
    /** Provide confirmed export RVA overrides: { "il2cpp_domain_get": "0xa2c6c0", ... } */
    setExportMap(map) {
        EXPORT_RVA = Object.assign({}, EXPORT_RVA, map || {});
        return Object.keys(EXPORT_RVA).length;
    },
    /** Sample by class name (bridge path only — needs il2cpp_class_from_name). */
    sample(className, maxInstances) {
        return runSample(className, maxInstances);
    },
    /** Sample by raw klass pointer (works in raw fallback mode). */
    sampleByPtr(klassPtrStr, maxInstances) {
        return sampleViaRaw(klassPtrStr, maxInstances);
    },
    /** Diagnostics: is the bridge able to drive sampling on this binary? */
    bridgeStatus() {
        const base = gaModule().base.toString();
        return {
            bridgeLoaded: typeof Il2Cpp !== 'undefined',
            coreExportsUsable: bridgeCoreUsable(),
            gaBase: base,
            exportOverrides: Object.keys(EXPORT_RVA),
        };
    },
};

/* If loaded under frida-il2cpp-bridge, run inside Il2Cpp.perform so the VM is ready.
 * Otherwise the script just exposes RPC for raw-mode use. */
if (typeof Il2Cpp !== 'undefined' && typeof Il2Cpp.perform === 'function') {
    try {
        Il2Cpp.perform(() => {
            send({ type: 'info', msg: 'Il2Cpp.perform entered; RPC ready' });
        });
    } catch (e) {
        send({ type: 'warn', msg: 'Il2Cpp.perform failed (expected on Beebyte binary): ' + e.message });
    }
} else {
    send({ type: 'info', msg: 'frida-il2cpp-bridge not bundled; RAW-OFFSET RPC ready (sampleByPtr)' });
}
