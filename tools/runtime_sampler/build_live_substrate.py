#!/usr/bin/env python3
"""
build_live_substrate.py - one-shot shared substrate for the recovery swarm.

The static target list (runtime_sample_targets.json) keys classes by SYNTHETIC
shape descriptors (e.g. "Type7m2f_19E2") that exist nowhere in the live process,
and by STALE GC-heap VAs that ASLR randomizes every launch. Neither can re-resolve
against a fresh session. So we abandon the stale list and rebuild ground truth
DIRECTLY from the live process:

  * harvest every live Il2CppClass via the object-header invariant (every managed
    object's first qword is its klass pointer) across the rw- heap,
  * read each klass's name / namespace / field+method counts using the VERIFIED
    Beebyte offsets (name +0x50, ns +0x18, fields +0x1D8, fc +0x122, mc +0x120),
  * read each field's name (+0x08), offset (+0x04) and type pointer (+0x10),
  * classify each class: real-named vs Beebyte-weak vs compiler-generated, and
    flag JSON-DTO candidates (has fields, name/ns hints, reference-type fields).

Output: output/p2_research/live_class_substrate.json  (the swarm reads THIS, not
the live process, so dozens of agents don't contend on a single frida channel).

Pure-memory, zero GameAssembly export calls (Beebyte binary strips/renames them;
return-address anti-tamper rejects bridge NativeFunction calls). Read-only.
"""
import argparse
import json
import os
import sys
import time

REPO = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
OUT = os.path.join(REPO, "output", "p2_research", "live_class_substrate.json")

AGENT_JS = r"""
'use strict';
// Verified Beebyte Il2CppClass offsets (Jun build): see tools/vrc_frida_lib.js.
var OFF = { NS: 0x18, NAME: 0x50, FIELDS: 0x1D8, FC: 0x122, MC: 0x120 };

function readCStr(p) {
    try {
        if (p.isNull()) return null;
        var s = p.readCString();
        if (!s || s.length === 0 || s.length > 200) return null;
        for (var i = 0; i < s.length; i++) {
            var c = s.charCodeAt(i);
            if (c < 0x20 || c > 0x7e) return null;   // strict ASCII (names are ASCII)
        }
        return s;
    } catch (e) { return null; }
}

function klassName(k)  { try { return readCStr(k.add(OFF.NAME).readPointer()); } catch (e) { return null; } }
function klassNs(k)    { try { return readCStr(k.add(OFF.NS).readPointer()); } catch (e) { return null; } }

function klassFields(k) {
    var out = [];
    try {
        var fc = k.add(OFF.FC).readU16();
        if (fc <= 0 || fc > 400) return out;
        var base = k.add(OFF.FIELDS).readPointer();
        if (base.isNull()) return out;
        for (var i = 0; i < fc; i++) {
            var fb = base.add(i * 0x20);
            var nm = readCStr(fb.readPointer());
            var off = 0, tp = null;
            try { off = fb.add(0x18).readU32(); } catch (e) {}
            try { tp = fb.add(0x08).readPointer().toString(); } catch (e) {}
            out.push({ name: nm, offset: off, type: tp });
        }
    } catch (e) {}
    return out;
}

rpc.exports = {
    ranges: function () {
        return Process.enumerateRanges('rw-').map(function (r) {
            return [r.base.toString(), r.size];
        });
    },
    // Pass 1: count how often each candidate klass ptr appears as obj[0].
    // A genuine instantiated Il2CppClass is the header of MANY live objects;
    // stray ASCII-named pointers (bone names, Unity field strings) appear once.
    // Returns {klassPtr: freq} for ptrs that have an ASCII name at +0x50 AND a
    // structurally valid field array (fc sane, FieldInfo[0] name+type parse).
    tally: function (baseStr, size) {
        var base = ptr(baseStr);
        var freq = {};
        for (var off = 0; off + 0x10 < size; off += 0x10) {
            try {
                var kp = base.add(off).readPointer();
                if (kp.isNull() || kp.and(0x7).toUInt32() !== 0) continue;
                var n = parseInt(kp.toString(), 16);
                if (n < 0x10000 || n > 0x7FFFFFFFFFFF) continue;
                var ks = kp.toString();
                if (freq[ks] !== undefined) { freq[ks]++; continue; }
                // First sighting: validate it really looks like Il2CppClass.
                var nm = klassName(kp);
                if (!nm || nm.length < 2) continue;
                var fc = 0, mc = 0;
                try { fc = kp.add(OFF.FC).readU16(); } catch (e) { continue; }
                try { mc = kp.add(OFF.MC).readU16(); } catch (e) { continue; }
                if (fc > 400 || mc > 4000) continue;
                // Structural: if fc>0, field array + first field must parse.
                if (fc > 0) {
                    var fb = kp.add(OFF.FIELDS).readPointer();
                    if (fb.isNull()) continue;
                    var f0 = readCStr(fb.readPointer());
                    if (!f0) continue;          // first field name must be ASCII
                }
                freq[ks] = 1;
            } catch (e) {}
        }
        return freq;
    },
    // Pass 2: for a confirmed klass ptr list, return full records.
    detail: function (ptrList) {
        var out = [];
        for (var i = 0; i < ptrList.length; i++) {
            try {
                var kp = ptr(ptrList[i]);
                var nm = klassName(kp);
                if (!nm) continue;
                var fc = 0, mc = 0;
                try { fc = kp.add(OFF.FC).readU16(); } catch (e) {}
                try { mc = kp.add(OFF.MC).readU16(); } catch (e) {}
                out.push({
                    klass: ptrList[i], name: nm, ns: klassNs(kp),
                    nf: fc, nm: mc, fields: klassFields(kp)
                });
            } catch (e) {}
        }
        return out;
    }
};
"""


def classify(name, ns, fields):
    """real | weak | compiler — plus is_dto heuristic."""
    weak = False
    # Beebyte weak: short token-ish or mixed-case gibberish, no separators/spaces.
    if name and all(c.isalnum() or c == '_' for c in name):
        letters = [c for c in name if c.isalpha()]
        if letters:
            uppers = sum(1 for c in letters if c.isupper())
            ratio = uppers / len(letters)
            # gibberish camel like 'ABOOGaFuykF' -> high mixed-case churn
            if (4 <= len(name) <= 16 and 0.25 < ratio < 0.85
                    and not any(name.lower().startswith(p) for p in (
                        'get_', 'set_', 'cell_', 'page_', 'menu_', 'btn'))):
                weak = True
    compiler = bool(name and ('<' in name or '__' in name or name.startswith('$')))
    kind = 'compiler' if compiler else ('weak' if weak else 'real')

    ref_fields = sum(1 for f in fields if f.get('type'))
    is_dto = (len(fields) >= 2 and kind in ('weak', 'compiler')
              and ref_fields >= 1)
    return kind, is_dto


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--pid", type=int, required=True)
    ap.add_argument("--out", default=OUT)
    ap.add_argument("--min-freq", type=int, default=2,
                    help="min object-header sightings for a ptr to count as a klass")
    ap.add_argument("--min-hits", type=int, default=3,
                    help="min klass candidates in a region probe to deep-scan it")
    args = ap.parse_args()

    import frida
    s = frida.attach(args.pid)
    sc = s.create_script(AGENT_JS)
    sc.load()
    api = sc.exports_sync

    ranges = api.ranges()
    print(f"[+] rw- ranges: {len(ranges)}", flush=True)

    # Cheap density probe: scan each region's first 256 KB; only deep-scan
    # regions that already show klass density (proven: the game's klass/object
    # heap lives in a few dozen dense regions, not spread across all 1900).
    dense = []
    for base, size in ranges:
        if size < 0x10000:
            continue
        try:
            f = api.tally(base, min(size, 0x40000))
        except Exception:
            continue
        if len(f) >= args.min_hits:
            dense.append((base, size))
    print(f"[+] {len(dense)} dense regions to deep-scan", flush=True)

    # Frequency tally across dense regions at 16-byte stride (GC objects are
    # 16-aligned, so obj[0] klass ptrs land on 16-byte boundaries).
    freq = {}
    t0 = time.time()
    for ri, (base, size) in enumerate(dense):
        off = 0
        while off < size:
            chunk = min(0x800000, size - off)
            try:
                f = api.tally(hex(int(base, 16) + off), chunk)
            except Exception:
                f = {}
            for k, c in f.items():
                freq[k] = freq.get(k, 0) + c
            off += chunk
        print(f"\r  region {ri+1}/{len(dense)} candidates={len(freq)} "
              f"{time.time()-t0:.0f}s", end="", flush=True)
    print(f"\n[+] pass1: {len(freq)} candidate klass ptrs in "
          f"{time.time()-t0:.0f}s", flush=True)

    # Keep only ptrs that head at least MIN_FREQ object instances OR have fields
    # (a real type with declared fields is a class even if few live instances).
    MIN_FREQ = args.min_freq
    keep = [k for k, c in freq.items() if c >= MIN_FREQ]
    print(f"[+] {len(keep)} ptrs pass freq>={MIN_FREQ} gate")

    # Pass 2: pull full records for kept ptrs (batched).
    classes = {}
    for i in range(0, len(keep), 500):
        batch = keep[i:i + 500]
        try:
            recs = api.detail(batch)
        except Exception:
            recs = []
        for r in recs:
            r["freq"] = freq.get(r["klass"], 0)
            classes[r["klass"]] = r
    s.detach()
    print(f"[+] pass2: {len(classes)} confirmed live classes")

    # Classify + index.
    by_kind = {"real": 0, "weak": 0, "compiler": 0}
    dto = 0
    recs = []
    for r in classes.values():
        kind, is_dto = classify(r["name"], r.get("ns"), r.get("fields", []))
        r["kind"] = kind
        r["is_dto"] = is_dto
        by_kind[kind] += 1
        if is_dto:
            dto += 1
        recs.append(r)

    out = {
        "session_pid": args.pid,
        "harvested": len(recs),
        "by_kind": by_kind,
        "dto_candidates": dto,
        "classes": recs,
    }
    os.makedirs(os.path.dirname(args.out), exist_ok=True)
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(out, f, ensure_ascii=False)
    print(f"[+] kinds: {by_kind}  dto_candidates={dto}")
    print(f"[+] wrote {args.out}")


if __name__ == "__main__":
    main()
