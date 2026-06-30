/**
 * memscan_sampler.js - BRIDGE-INDEPENDENT runtime instance-value sampler for
 * VRChat (Beebyte IL2CPP). Zero il2cpp_* calls, zero frida-il2cpp-bridge objects.
 *
 * WHY THIS EXISTS (see EXPORT_FINDING.md + B_DESIGN.md):
 *   GameAssembly.dll exports only 3 of the ~123 il2cpp_* functions the bridge
 *   needs (the rest are Beebyte-renamed), AND VRChat has a return-address
 *   anti-tamper check that rejects the bridge's NativeFunction calls. So the
 *   bridge very likely CANNOT initialize: Il2Cpp.domain / Il2Cpp.gc.choose /
 *   Il2Cpp.gc.disable are all unavailable. hybrid_sampler.js depends on every
 *   one of those and has no fallback when the bridge fails.
 *
 *   This module replaces ALL of them with raw memory operations from the VRC
 *   helper library (vrc_frida_lib.js), using only verified Beebyte struct
 *   offsets and never calling a single GameAssembly export.
 *
 *   bridge dependency            -> bridge-independent replacement here
 *   ---------------------------------------------------------------------------
 *   Il2Cpp.domain.assemblies     -> object-header klass harvest + self-ref scan
 *     [].image.classes              (buildClassIndex over Process rw- ranges)
 *   Il2Cpp.gc.choose(klass)      -> VRC.findInstances(klass, ranges)
 *     (object-header scan: every IL2CPP object's first qword == its klass ptr)
 *   Il2Cpp.gc.disable()          -> NOT called. Instead: minimize the read
 *                                   window and re-validate each object's header
 *                                   immediately before reading (skip if moved).
 *   Il2Cpp.Object/.Field/.Class  -> VRC.klassGetName/klassGetFields/
 *     metadata accessors             readIl2CppString (raw Beebyte offset reads)
 *   ToString() invoke            -> NOT called (a managed call routes through a
 *                                   NativeFunction and trips the anti-tamper
 *                                   check). tostring is always omitted here.
 *
 * NOT STANDALONE. The Python driver concatenates, in order:
 *   1. vrc_frida_lib.js   (sets global VRC with Beebyte readers)
 *   2. memscan_sampler.js (this file)
 * NO agent.js / bridge is loaded in this mode. `VRC` is the only dependency.
 *
 * Protocol (identical to hybrid_sampler.js so sample_instances.py stays simple):
 *   recv('start', { targets: [...], config: {...} }) -> runs sampling
 *   send({ type: 'class_result', payload: {...} }) per class
 *   send({ type: 'done', ... }) when finished
 *
 * Each target: { name (obfuscated original_name), nfields, nmethods, is_dto, callee_hint }.
 * The stale 'va' from the dump is intentionally IGNORED (prior ASLR base / build).
 * We re-resolve to the CURRENT klass pointer this session by matching
 * name + field/method counts against a fresh class scan.
 *
 * OUTPUT SCHEMA per class (feeds extract_realnames.py directly: it reads
 * obf_class + instances[{strings, json_keys, gameobject_name?, tostring?}]):
 *   { obf_class, original_name, full_name, klass, is_dto, callee_hint,
 *     live_count, matched_by, declared_fields:[{name,offset}],
 *     instances: [ { addr, fields:[...], strings:[...], json_keys:[...] } ] }
 *   strings / json_keys are DERIVED from field values. tostring / gameobject_name
 *   are intentionally absent (both need managed calls the anti-tamper rejects).
 */
'use strict';

/* global VRC */

var MEMSCAN_DEFAULTS = {
    maxInstancesPerClass: 50,   // cap per class (task: ~50)
    maxFieldsPerInstance: 64,   // safety cap; DTO field counts are tiny
    maxStringLen: 2000,
    maxStringsPerInstance: 64,  // cap derived strings[] per instance
    instanceScanCap: 200,       // VRC.findInstances maxResults (then sub-capped)
    revalidateHeader: true,     // GC-safety: re-check [inst+0]==klass before read
    classScanStep: 0x8,         // object headers are 8-aligned
    maxRangeBytes: 0x8000000,   // skip individual rw- regions larger than 128 MB
    maxTotalScanBytes: 0x40000000, // global budget across rw- ranges (~1 GiB)
};

// ---------------------------------------------------------------------------
// Scan-range discovery. Bridge-independent: enumerate the process's committed
// read/write ranges instead of assuming fixed GC heap addresses (those move
// across ASLR runs and Unity builds). Filter out absurd regions and cap the
// total scanned bytes so a single pass stays bounded.
// ---------------------------------------------------------------------------
function buildRwRanges(cfg) {
    var out = [];
    var ranges;
    try { ranges = Process.enumerateRanges('rw-'); }
    catch (e) { ranges = []; }
    var budget = cfg.maxTotalScanBytes;
    for (var i = 0; i < ranges.length && budget > 0; i++) {
        var r = ranges[i];
        var size = r.size;
        if (size <= 0) continue;
        if (size > cfg.maxRangeBytes) continue;
        if (size > budget) size = budget;
        out.push([r.base, size]);
        budget -= size;
    }
    return out;
}

// ---------------------------------------------------------------------------
// Pointer / string sanity helpers (mirror hybrid_sampler.js heuristics so field
// interpretation is comparable across the two paths).
// ---------------------------------------------------------------------------
function looksLikeHeapPtr(p) {
    try {
        if (p.isNull()) return false;
        if (p.and(0x7).toUInt32() !== 0) return false; // 8-aligned
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

function send_(obj) { send(obj); }

// ---------------------------------------------------------------------------
// CLASS INDEX without the bridge.
//
// Technique (the one extract_live_dump.py uses): an Il2CppClass struct is
// self-referential -- for an ordinary (non-array) class, element_class (+0x40)
// and cast_class (+0x48) both point back at the struct itself. That two-pointer
// invariant is rare enough to be a cheap, high-precision filter: we only read
// the (more expensive) name + counts on a hit. We confirm each hit with the VRC
// Beebyte readers (klassGetName must return a printable string; counts must be
// sane). No GameAssembly export is ever called.
//
// We scan the same Process rw- ranges used for instances. Class structs live in
// IL2CPP's own metadata regions, which appear in the rw- set. Only classes whose
// obfuscated name matches a requested target are kept (keeps the index small and
// avoids paying string-read cost on the whole address space).
//
// SELF_REF offsets are layout constants. 0x40/0x48 match the build whose object
// layout extract_live_dump.py verified; expose them via config so a future build
// shift is a one-line change, not a rewrite.
// ---------------------------------------------------------------------------
function readKlassShape(klass) {
    // Returns { name, nf, nm } or null if this does not look like a klass.
    var name = VRC.klassGetName(klass);
    if (!name || !isPrintable(name)) return null;
    var nf, nm;
    try { nf = klass.add(0x122).readU16(); } catch (e) { return null; }
    try { nm = klass.add(0x120).readU16(); } catch (e) { return null; }
    if (nf > 2000 || nm > 5000) return null;
    return { name: name, nf: nf, nm: nm };
}

function buildClassIndex(ranges, cfg, wantNames) {
    var index = {};       // "name|nf|nm" -> [klassPtr,...]
    var byName = {};      // "name"       -> [klassPtr,...]
    var seen = {};        // dedupe klass struct addrs
    var hits = 0, kept = 0, scannedBytes = 0;
    var elemOff = cfg.elemOff, castOff = cfg.castOff, step = cfg.classScanStep;

    for (var r = 0; r < ranges.length; r++) {
        var base = ranges[r][0], size = ranges[r][1];
        scannedBytes += size;
        for (var off = 0; off + 0x180 < size; off += step) {
            var p = base.add(off);
            try {
                // Cheap self-reference gate: two pointer reads + compares.
                var elem = p.add(elemOff).readPointer();
                if (!elem.equals(p)) continue;
                var cast = p.add(castOff).readPointer();
                if (!cast.equals(p)) continue;
            } catch (e) {
                // Unreadable page: skip to the next 4 KiB boundary cheaply.
                off += 0x1000 - (off % 0x1000) - step;
                continue;
            }
            hits++;
            var ks = p.toString();
            if (seen[ks]) continue;
            var shape = readKlassShape(p);
            if (!shape) continue;
            seen[ks] = true;
            // Only retain classes a target asked for.
            if (wantNames && !wantNames[shape.name]) continue;
            kept++;
            var key = shape.name + '|' + shape.nf + '|' + shape.nm;
            (index[key] || (index[key] = [])).push(p);
            (byName[shape.name] || (byName[shape.name] = [])).push(p);
        }
    }
    return { index: index, byName: byName, hits: hits, kept: kept,
             scannedBytes: scannedBytes };
}

// ---------------------------------------------------------------------------
// Re-resolution: stale dump target -> live klass pointer(s) THIS session.
// Match on obfuscated name + field/method counts first; loosen to name-only if
// counts drift (struct re-reads / minor build deltas). Mirrors hybrid_sampler.js
// resolveTargets so the two paths produce comparable matched_by provenance.
// ---------------------------------------------------------------------------
function resolveTargets(targets, idx) {
    var resolved = [], unmatched = 0, ambiguous = 0;
    for (var i = 0; i < targets.length; i++) {
        var t = targets[i];
        var key = t.name + '|' + t.nfields + '|' + t.nmethods;
        var hits = idx.index[key];
        if (hits && hits.length > 0) {
            if (hits.length > 1) ambiguous++;
            resolved.push({ target: t, klasses: hits.slice(), matchedBy: 'name+counts' });
            continue;
        }
        var nameHits = idx.byName[t.name];
        if (!nameHits || nameHits.length === 0) { unmatched++; continue; }
        if (nameHits.length > 1) ambiguous++;
        resolved.push({ target: t, klasses: nameHits.slice(), matchedBy: 'name-only' });
    }
    return { resolved: resolved, unmatched: unmatched, ambiguous: ambiguous };
}
