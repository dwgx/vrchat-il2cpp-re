/**
 * hybrid_sampler.js - Hybrid runtime instance-value sampler for VRChat (Beebyte IL2CPP)
 *
 * APPROACH A (HYBRID):
 *   - frida-il2cpp-bridge is used ONLY for instance enumeration (Il2Cpp.gc.choose),
 *     which walks the Boehm GC heap via the public IL2CPP API and does NOT depend on
 *     the (Beebyte-shuffled) Il2CppClass struct layout.
 *   - Every field VALUE is read with OUR verified Beebyte offsets via the VRC helper
 *     library (vrc_frida_lib.js), never via the bridge's standard-layout assumptions.
 *
 * Scope: class names were compile-time STRIPPED. We leak identity from live data:
 *   string field values, nested object class names, numeric/enum values, ToString().
 *
 * This file is NOT standalone. The Python driver concatenates, in order:
 *   1. agent.js          (frida-compiled frida-il2cpp-bridge -> sets global Il2Cpp)
 *   2. vrc_frida_lib.js  (sets global VRC with Beebyte readers)
 *   3. hybrid_sampler.js (this file)
 * so that `Il2Cpp` and `VRC` are both visible in the shared script scope.
 *
 * Protocol:
 *   recv('start', { targets: [...], config: {...} }) -> runs sampling
 *   send({ type: 'class_result', ... }) per class
 *   send({ type: 'done', ... }) when finished
 *
 * Each target: { name (obfuscated original_name), nfields, nmethods, is_dto, callee_hint }.
 * The stale 'va' from the dump is intentionally IGNORED (captured under a prior ASLR
 * base). We re-resolve to the CURRENT klass pointer by matching name + field/method
 * counts against a fresh class enumeration this session (see resolveTargets).
 */
'use strict';

/* global Il2Cpp, VRC */

var SAMPLE_DEFAULTS = {
    maxInstancesPerClass: 50, // cap per class (task: ~50)
    maxFieldsPerInstance: 64, // safety cap; DTO field counts are tiny
    maxStringLen: 2000,
    invokeToString: false,    // OFF by default: managed-method calls may trip VRChat
                              // anti-tamper return-address checks. See A_DESIGN.md.
    pinGcDuringReads: true,   // il2cpp_gc_disable around choose+read window
};

// ---------------------------------------------------------------------------
// GC pinning. Boehm GC can move/free objects mid-traversal. We disable GC for
// the whole choose+read window of each class, then re-enable. We prefer the
// bridge's wrappers and fall back to the raw resolved exports it exposes.
// ---------------------------------------------------------------------------
function gcDisable() {
    try { if (Il2Cpp.gc && typeof Il2Cpp.gc.disable === 'function') { Il2Cpp.gc.disable(); return true; } } catch (e) {}
    try { if (Il2Cpp.api && Il2Cpp.api.il2cpp_gc_disable) { Il2Cpp.api.il2cpp_gc_disable(); return true; } } catch (e) {}
    return false;
}
function gcEnable() {
    try { if (Il2Cpp.gc && typeof Il2Cpp.gc.enable === 'function') { Il2Cpp.gc.enable(); return true; } } catch (e) {}
    try { if (Il2Cpp.api && Il2Cpp.api.il2cpp_gc_enable) { Il2Cpp.api.il2cpp_gc_enable(); return true; } } catch (e) {}
    return false;
}

// ---------------------------------------------------------------------------
// Re-resolution: stale dump 'va' -> live klass pointer (THIS session).
// Enumerate every class via the bridge (public API, layout-agnostic), read its
// name + counts via OUR Beebyte offsets, index by name|nfields|nmethods, then
// match each target. Returns { resolved: [{target, klasses:[ptr,...]}], stats }.
// ---------------------------------------------------------------------------
function buildClassIndex() {
    var index = {};   // "name|nf|nm" -> [klassPtr,...]
    var total = 0, named = 0;
    var assemblies = Il2Cpp.domain.assemblies;
    for (var ai = 0; ai < assemblies.length; ai++) {
        var classes;
        try { classes = assemblies[ai].image.classes; } catch (e) { continue; }
        for (var ci = 0; ci < classes.length; ci++) {
            total++;
            var klass;
            try { klass = classes[ci].handle; } catch (e) { continue; }
            if (klass.isNull()) continue;
            var name = VRC.klassGetName(klass);
            if (!name) continue;
            named++;
            var nf, nm;
            try { nf = klass.add(0x122).readU16(); } catch (e) { nf = -1; }
            try { nm = klass.add(0x120).readU16(); } catch (e) { nm = -1; }
            var key = name + '|' + nf + '|' + nm;
            (index[key] || (index[key] = [])).push(klass);
        }
    }
    return { index: index, total: total, named: named };
}

function resolveTargets(targets, idx) {
    var index = idx.index;
    var resolved = [], unmatched = 0, ambiguous = 0;
    for (var i = 0; i < targets.length; i++) {
        var t = targets[i];
        var key = t.name + '|' + t.nfields + '|' + t.nmethods;
        var hits = index[key];
        if (!hits || hits.length === 0) {
            // Loosen: match on name alone (counts may drift across struct re-reads).
            var nameHits = [];
            var keys = Object.keys(index);
            for (var k = 0; k < keys.length; k++) {
                if (keys[k].indexOf(t.name + '|') === 0) {
                    var arr = index[keys[k]];
                    for (var a = 0; a < arr.length; a++) nameHits.push(arr[a]);
                }
            }
            if (nameHits.length === 0) { unmatched++; continue; }
            if (nameHits.length > 1) ambiguous++;
            resolved.push({ target: t, klasses: nameHits, matchedBy: 'name-only' });
            continue;
        }
        if (hits.length > 1) ambiguous++;
        resolved.push({ target: t, klasses: hits.slice(), matchedBy: 'name+counts' });
    }
    return { resolved: resolved, unmatched: unmatched, ambiguous: ambiguous };
}

// ---------------------------------------------------------------------------
// Field value heuristics. We do NOT trust Il2CppType layout (Beebyte may shuffle
// it and the task gave us no Il2CppType offsets). Instead we interpret each field
// slot multiple ways and keep whatever decodes cleanly:
//   - Il2CppString  -> string value (strongest identity leak: JSON keys, ids, urls)
//   - object ptr    -> nested class name (read target's [0]=klass, klass+0x50=name)
//   - primitives    -> int/uint/float/double best-effort
// ---------------------------------------------------------------------------
function looksLikeHeapPtr(p) {
    try {
        if (p.isNull()) return false;
        var v = p.toUInt32 ? p : p; // keep NativePointer
        // Reject obvious small ints / unaligned junk; heap pointers are 8-aligned.
        if (p.and(0x7).toUInt32() !== 0) return false;
        var n = parseInt(p.toString(), 16);
        return n > 0x10000 && n < 0x7FFFFFFFFFFF;
    } catch (e) { return false; }
}

function isPrintable(s) {
    if (!s || s.length === 0) return false;
    var printable = 0;
    for (var i = 0; i < s.length; i++) {
        var c = s.charCodeAt(i);
        if (c >= 0x20 && c < 0x7F) printable++;
        else if (c >= 0xCC && c <= 0xCF) printable++; // Beebyte obfuscated glyphs
    }
    return (printable / s.length) >= 0.7;
}

function readFieldValue(instPtr, field, cfg) {
    var out = { name: field.name, offset: '0x' + field.offset.toString(16) };
    var addr;
    try { addr = instPtr.add(field.offset); } catch (e) { out.err = 'addr'; return out; }

    // Primitive interpretations (cheap, always recorded for small inline fields).
    try { out.i32 = addr.readInt(); } catch (e) {}
    try { out.u32 = addr.readU32(); } catch (e) {}
    try {
        var f = addr.readFloat();
        if (isFinite(f) && f !== 0) out.f32 = f;
    } catch (e) {}

    var slot;
    try { slot = addr.readPointer(); } catch (e) { return out; }
    if (slot.isNull() || !looksLikeHeapPtr(slot)) return out;
    out.ptr = slot.toString();

    // (a) Il2CppString value at the slot.
    try {
        var s = VRC.readIl2CppString(slot);
        if (s && s.length > 0 && s.length <= cfg.maxStringLen && isPrintable(s)) {
            out.str = s;
            return out;
        }
    } catch (e) {}

    // (b) Nested managed object: slot -> [klass ptr] -> name via Beebyte +0x50.
    try {
        var nestedKlass = slot.readPointer();
        if (looksLikeHeapPtr(nestedKlass)) {
            var kn = VRC.klassGetName(nestedKlass);
            if (kn && isPrintable(kn)) {
                out.objClass = kn;
                var ns = VRC.klassGetNamespace(nestedKlass);
                if (ns) out.objNamespace = ns;
                out.objIsObfuscated = VRC.isObfuscated(kn);
                // If the nested object is itself a string-bearing DTO, peek field[0].
            }
        }
    } catch (e) {}

    return out;
}

// ---------------------------------------------------------------------------
// ToString() via the bridge. Guarded + OFF by default. A managed call routes
// through a bridge NativeFunction; VRChat's return-address anti-tamper check may
// terminate the process. Enable only when you accept that risk.
// ---------------------------------------------------------------------------
function tryToString(obj) {
    try {
        var m = (typeof obj.tryMethod === 'function') ? obj.tryMethod('ToString', 0) : null;
        if (!m && typeof obj.method === 'function') { try { m = obj.method('ToString', 0); } catch (e) {} }
        if (!m) return null;
        var r = m.invoke();
        if (r == null) return null;
        if (typeof r === 'object' && 'content' in r) return r.content; // Il2Cpp.String
        return r.toString();
    } catch (e) { return null; }
}

// ---------------------------------------------------------------------------
// Sample one resolved klass: gc.choose -> read every instance's fields.
// ---------------------------------------------------------------------------
function sampleKlass(klass, target, cfg) {
    var fields = VRC.klassGetFields(klass);
    var fullName = VRC.klassGetFullName(klass);
    var rec = {
        klass: klass.toString(),
        original_name: target.name,
        full_name: fullName,
        is_dto: !!target.is_dto,
        callee_hint: target.callee_hint || [],
        declared_fields: [],
        instances: [],
    };
    for (var fi = 0; fi < fields.length; fi++) {
        rec.declared_fields.push({ name: fields[fi].name, offset: '0x' + fields[fi].offset.toString(16) });
    }

    var pinned = false;
    if (cfg.pinGcDuringReads) pinned = gcDisable();
    try {
        var instances;
        try {
            var wrapped = new Il2Cpp.Class(klass);
            instances = Il2Cpp.gc.choose(wrapped);
        } catch (e) {
            rec.error = 'gc.choose failed: ' + e.message;
            return rec;
        }
        rec.live_count = instances.length;

        var limit = Math.min(instances.length, cfg.maxInstancesPerClass);
        for (var ii = 0; ii < limit; ii++) {
            var obj = instances[ii];
            var instPtr;
            try { instPtr = obj.handle; } catch (e) { continue; }
            if (instPtr.isNull()) continue;

            var inst = { addr: instPtr.toString(), fields: [] };
            var fcap = Math.min(fields.length, cfg.maxFieldsPerInstance);
            for (var k = 0; k < fcap; k++) {
                inst.fields.push(readFieldValue(instPtr, fields[k], cfg));
            }
            if (cfg.invokeToString) {
                var ts = tryToString(obj);
                if (ts !== null && isPrintable(String(ts))) inst.toString = String(ts);
            }
            rec.instances.push(inst);
        }
    } finally {
        if (pinned) gcEnable();
    }
    return rec;
}

function sampleAll(targets, config) {
    var cfg = {};
    var keys = Object.keys(SAMPLE_DEFAULTS);
    for (var i = 0; i < keys.length; i++) cfg[keys[i]] = SAMPLE_DEFAULTS[keys[i]];
    if (config) { var ck = Object.keys(config); for (var j = 0; j < ck.length; j++) cfg[ck[j]] = config[ck[j]]; }

    send({ type: 'info', msg: 'GA base: ' + VRC.gaBase() + '; targets: ' + targets.length });
    send({ type: 'info', msg: 'Enumerating classes for re-resolution...' });

    var idx = buildClassIndex();
    send({ type: 'info', msg: 'Class enumeration: ' + idx.named + ' named / ' + idx.total + ' total' });

    var res = resolveTargets(targets, idx);
    send({
        type: 'info',
        msg: 'Resolved ' + res.resolved.length + '/' + targets.length +
             ' (unmatched ' + res.unmatched + ', ambiguous ' + res.ambiguous + ')',
    });

    var done = 0, instancesTotal = 0;
    for (var r = 0; r < res.resolved.length; r++) {
        var entry = res.resolved[r];
        // De-dup klass pointers within this target.
        var seen = {};
        for (var c = 0; c < entry.klasses.length; c++) {
            var kp = entry.klasses[c];
            var ks = kp.toString();
            if (seen[ks]) continue;
            seen[ks] = true;
            try {
                var rec = sampleKlass(kp, entry.target, cfg);
                rec.matched_by = entry.matchedBy;
                instancesTotal += rec.instances.length;
                send({ type: 'class_result', payload: rec });
            } catch (e) {
                send({ type: 'error', msg: 'sample ' + entry.target.name + ': ' + e.message });
            }
        }
        done++;
        if (done % 25 === 0) send({ type: 'progress', done: done, total: res.resolved.length });
    }

    send({
        type: 'done',
        resolved: res.resolved.length,
        unmatched: res.unmatched,
        ambiguous: res.ambiguous,
        instances: instancesTotal,
    });
}

// ---------------------------------------------------------------------------
// Entry. Wait for the driver to post the target list, then run inside
// Il2Cpp.perform so the thread is attached and the bridge is initialized.
// ---------------------------------------------------------------------------
function onStart(msg) {
    var targets = (msg && msg.targets) || [];
    var config = (msg && msg.config) || {};
    try {
        Il2Cpp.perform(function () {
            try { sampleAll(targets, config); }
            catch (e) { send({ type: 'error', msg: 'sampleAll: ' + e.message + '\n' + (e.stack || '') }); send({ type: 'done', error: true }); }
        });
    } catch (e) {
        send({ type: 'error', msg: 'Il2Cpp.perform failed: ' + e.message });
        send({ type: 'done', error: true });
    }
}

recv('start', onStart);
send({ type: 'info', msg: 'hybrid_sampler.js ready; waiting for target list (post "start").' });
