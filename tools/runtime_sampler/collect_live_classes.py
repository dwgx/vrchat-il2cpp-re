#!/usr/bin/env python3
"""
collect_live_classes.py - ONE-SHOT live klass metadata collector.

Single frida attach does everything (no iterative re-attaching, which was the
source of slowness + ASLR/process-death churn):
  1. Locate the metadata string blob dynamically (base moves every launch).
  2. Re-derive the live FieldInfo layout by consensus voting (field-array ptr
     offset within klass, FieldInfo stride, name sub-offset) anchored on real
     classes whose name pointer lands in the blob.
  3. Derive field_count offset, namespace offset, FieldInfo type/offset
     sub-offsets from the consensus layout.
  4. Full harvest: every live klass (object-header invariant + freq) -> name,
     namespace, fields[{name, offset, type_ptr}], counts.
  5. Write output/p2_research/live_class_substrate.json (the swarm reads THIS).

Confirmed-stable invariant across launches: klass name pointer at klass+0x50,
pointing into the decrypted global-metadata string blob. Everything else is
re-derived live because minidump-era offsets don't match this build.

Read-only, pure memory, zero GameAssembly export calls (Beebyte strips exports;
anti-tamper rejects bridge NativeFunction calls). See memory: vrchat-frida-constraints.
"""
import argparse
import json
import os
import sys
import time

REPO = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
OUT = os.path.join(REPO, "output", "p2_research", "live_class_substrate.json")

JS = r"""
'use strict';
var NAME_OFF = 0x50;   // confirmed stable across launches

function isPtr(p) {
    if (p.isNull() || p.and(0x7).toUInt32() !== 0) return false;
    var n = parseInt(p.toString(), 16);
    return n >= 0x100000 && n <= 0x7FFFFFFFFFFF;
}
function asciiName(p) {
    try {
        var c = p.readCString();
        if (c && /^[\x20-\x7e]+$/.test(c) && c.length >= 1 && c.length <= 80) return c;
    } catch (e) {}
    return null;
}

var BLOBS = [];   // [[baseInt, sizeInt], ...]  set by locateBlob
function inBlob(p) {
    var a = parseInt(p.toString(), 16);
    for (var i = 0; i < BLOBS.length; i++) {
        if (a >= BLOBS[i][0] && a < BLOBS[i][0] + BLOBS[i][1]) return true;
    }
    return false;
}

rpc.exports = {
    // --- step 1: locate metadata string blob (densest region of klass names) ---
    locateblob: function () {
        var ranges = Process.enumerateRanges('rw-');
        var hits = {}, info = {}, seen = {}, n = 0;
        for (var i = 0; i < ranges.length && n < 6000; i++) {
            var base = ranges[i].base, size = Math.min(ranges[i].size, 0x400000);
            for (var off = 0; off + 0x60 < size && n < 6000; off += 0x10) {
                try {
                    var kp = base.add(off).readPointer();
                    if (!isPtr(kp)) continue;
                    var ks = kp.toString(); if (seen[ks]) continue;
                    var np = kp.add(NAME_OFF).readPointer();
                    if (!isPtr(np)) continue;
                    var c = np.readCString();
                    if (!c || !/^[A-Za-z_<][a-zA-Z0-9_<>.`]{4,40}$/.test(c)) continue;
                    var r = Process.findRangeByAddress(np);
                    if (!r) continue;
                    var rb = r.base.toString();
                    hits[rb] = (hits[rb] || 0) + 1;
                    info[rb] = r.size;
                    seen[ks] = 1; n++;
                } catch (e) {}
            }
        }
        var arr = Object.keys(hits).map(function (k) {
            return { base: k, hits: hits[k], size: info[k] };
        });
        arr.sort(function (a, b) { return b.hits - a.hits; });
        // keep regions with >=2% of max hits as blob members
        var top = arr.length ? arr[0].hits : 0;
        var keep = arr.filter(function (x) { return x.hits >= Math.max(20, top * 0.02); });
        BLOBS = keep.map(function (x) { return [parseInt(x.base, 16), x.size]; });
        return { chosen: keep, all: arr.slice(0, 8) };
    },

    // --- step 2: re-derive FieldInfo layout by consensus voting ---
    derivelayout: function () {
        var ranges = Process.enumerateRanges('rw-');
        var votes = {}, seen = {}, tried = 0, sample = [];
        for (var i = 0; i < ranges.length && tried < 400; i++) {
            var base = ranges[i].base, size = Math.min(ranges[i].size, 0x800000);
            for (var off = 0; off + 0x140 < size && tried < 400; off += 0x10) {
                try {
                    var kp = base.add(off).readPointer();
                    if (!isPtr(kp)) continue;
                    var ks = kp.toString(); if (seen[ks]) continue;
                    var np = kp.add(NAME_OFF).readPointer();
                    if (!inBlob(np)) continue;
                    var nm = np.readCString();
                    if (!nm || !/^[A-Za-z_<][a-zA-Z0-9_<>.`]{4,40}$/.test(nm)) continue;
                    seen[ks] = 1; tried++;
                    // sweep field-array-ptr offset x stride x name-suboffset
                    for (var apo = 0x88; apo <= 0x130; apo += 0x8) {
                        var fa = kp.add(apo).readPointer();
                        if (!isPtr(fa)) continue;
                        var strides = [0x18, 0x20, 0x28, 0x30];
                        for (var si = 0; si < strides.length; si++) {
                            var st = strides[si];
                            for (var no = 0; no <= 0x8; no += 0x8) {
                                var cnt = 0;
                                for (var fi = 0; fi < 8; fi++) {
                                    var fnp;
                                    try { fnp = fa.add(fi * st + no).readPointer(); }
                                    catch (e) { break; }
                                    if (!isPtr(fnp)) break;
                                    var c = fnp.readCString();
                                    if (c && /^[a-zA-Z_<][a-zA-Z0-9_<>]{1,38}$/.test(c)) cnt++;
                                    else break;
                                }
                                if (cnt >= 4) {
                                    var key = apo + '|' + st + '|' + no;
                                    votes[key] = (votes[key] || 0) + 1;
                                }
                            }
                        }
                    }
                } catch (e) {}
            }
        }
        return { votes: votes, tried: tried };
    },

    // --- step 2b: verify a KNOWN layout quickly (no outer tried cap) ---
    verifylayout: function (apo, st, no) {
        var ranges = Process.enumerateRanges('rw-');
        var seen = {}, ok = 0, samples = [];
        for (var i = 0; i < ranges.length && ok < 200; i++) {
            var base = ranges[i].base, size = Math.min(ranges[i].size, 0x800000);
            for (var off = 0; off + 0x140 < size && ok < 200; off += 0x10) {
                try {
                    var kp = base.add(off).readPointer();
                    if (!isPtr(kp)) continue;
                    var ks = kp.toString(); if (seen[ks]) continue;
                    var np = kp.add(NAME_OFF).readPointer();
                    if (!inBlob(np)) continue;
                    var nm = np.readCString();
                    if (!nm || !/^[A-Za-z_<][a-zA-Z0-9_<>.`]{3,40}$/.test(nm)) continue;
                    var fa = kp.add(apo).readPointer();
                    if (!isPtr(fa)) { seen[ks] = 1; continue; }
                    var names = [];
                    for (var fi = 0; fi < 16; fi++) {
                        var fnp = fa.add(fi * st + no).readPointer();
                        if (!isPtr(fnp)) break;
                        var c = fnp.readCString();
                        if (c && /^[a-zA-Z_<][a-zA-Z0-9_<>]{1,38}$/.test(c)) names.push(c);
                        else break;
                    }
                    seen[ks] = 1;
                    if (names.length >= 3) {
                        ok++;
                        if (samples.length < 5) samples.push({ k: nm, f: names.slice(0, 5) });
                    }
                } catch (e) {}
            }
        }
        return { ok: ok, samples: samples };
    },

    // --- step 3: derive count/ns/type/foff offsets given winning layout ---
    deriveoffsets: function (apo, st, no) {
        var ranges = Process.enumerateRanges('rw-');
        var countHist = {}, nsHist = {}, typeHist = {}, foffHist = {};
        var seen = {}, ok = 0, sample = [];
        for (var i = 0; i < ranges.length && ok < 300; i++) {
            var base = ranges[i].base, size = Math.min(ranges[i].size, 0x800000);
            for (var off = 0; off + 0x140 < size && ok < 300; off += 0x10) {
                try {
                    var kp = base.add(off).readPointer();
                    if (!isPtr(kp)) continue;
                    var ks = kp.toString(); if (seen[ks]) continue;
                    var np = kp.add(NAME_OFF).readPointer();
                    if (!inBlob(np)) continue;
                    var nm = np.readCString();
                    if (!nm || !/^[A-Za-z_<][a-zA-Z0-9_<>.`]{4,40}$/.test(nm)) continue;
                    var fa = kp.add(apo).readPointer();
                    if (!isPtr(fa)) continue;
                    var names = [];
                    for (var fi = 0; fi < 64; fi++) {
                        var fnp = fa.add(fi * st + no).readPointer();
                        if (!isPtr(fnp)) break;
                        var c = fnp.readCString();
                        if (c && /^[a-zA-Z_<][a-zA-Z0-9_<>.]{0,40}$/.test(c)) names.push(c);
                        else break;
                    }
                    if (names.length < 2) continue;
                    seen[ks] = 1; ok++;
                    var N = names.length;
                    var co;
                    for (co = 0x100; co <= 0x130; co += 2) {
                        try { if (kp.add(co).readU16() === N) countHist[co] = (countHist[co] || 0) + 1; } catch (e) {}
                    }
                    var nso;
                    for (nso = 0x10; nso <= 0x40; nso += 8) {
                        try {
                            var q = kp.add(nso).readPointer();
                            if (inBlob(q) && q.toString() !== np.toString()) {
                                var c2 = q.readCString();
                                if (c2 !== null && /^[\x20-\x7e]{0,40}$/.test(c2)) nsHist[nso] = (nsHist[nso] || 0) + 1;
                            }
                        } catch (e) {}
                    }
                    // FieldInfo[0]: type ptr + offset u32
                    var to;
                    for (to = 0x8; to <= 0x18; to += 8) {
                        try { if (isPtr(fa.add(to).readPointer())) typeHist[to] = (typeHist[to] || 0) + 1; } catch (e) {}
                    }
                    var oo;
                    for (oo = 0x10; oo <= 0x1c; oo += 4) {
                        try { var v = fa.add(oo).readU32(); if (v > 0 && v < 0x4000) foffHist[oo] = (foffHist[oo] || 0) + 1; } catch (e) {}
                    }
                } catch (e) {}
            }
        }
        return { ok: ok, countOff: countHist, nsOff: nsHist, typeOff: typeHist, foffOff: foffHist };
    },

    // --- step 4: full harvest of one region (bounded; called per chunk) ---
    setblobs: function (blobs) { BLOBS = blobs; return BLOBS.length; },
    ranges: function () {
        return Process.enumerateRanges('rw-').map(function (r) { return [r.base.toString(), r.size]; });
    },
    harvest: function (baseStr, size, lay) {
        // lay = {apo, st, no, countOff, nsOff, typeOff, foffOff}
        var base = ptr(baseStr);
        var out = [];
        var localSeen = {};
        for (var off = 0; off + 0x10 < size; off += 0x10) {
            try {
                var kp = base.add(off).readPointer();
                if (!isPtr(kp)) continue;
                var ks = kp.toString();
                if (localSeen[ks]) continue;
                var np = kp.add(NAME_OFF).readPointer();
                if (!inBlob(np)) continue;
                var nm = np.readCString();
                if (!nm || nm.length < 2 || nm.length > 80) continue;
                if (!/^[\x20-\x7e]+$/.test(nm)) continue;
                localSeen[ks] = 1;
                var ns = null;
                try {
                    var nsp = kp.add(lay.nsOff).readPointer();
                    if (inBlob(nsp)) ns = nsp.readCString();
                } catch (e) {}
                var fc = 0;
                try { fc = kp.add(lay.countOff).readU16(); } catch (e) {}
                var fields = [];
                if (fc > 0 && fc <= 300) {
                    var fa = kp.add(lay.apo).readPointer();
                    if (isPtr(fa)) {
                        for (var fi = 0; fi < fc; fi++) {
                            var fb = fa.add(fi * lay.st);
                            var fname = null, foff = 0, ftype = null;
                            try {
                                var fnp = fb.add(lay.no).readPointer();
                                if (isPtr(fnp)) {
                                    var fc2 = fnp.readCString();
                                    if (fc2 && /^[a-zA-Z_<][a-zA-Z0-9_<>.]{0,60}$/.test(fc2)) fname = fc2;
                                }
                            } catch (e) {}
                            try { foff = fb.add(lay.foffOff).readU32(); } catch (e) {}
                            try { ftype = fb.add(lay.typeOff).readPointer().toString(); } catch (e) {}
                            fields.push({ n: fname, o: foff, t: ftype });
                        }
                    }
                }
                out.push({ klass: ks, name: nm, ns: ns, nf: fc, fields: fields });
            } catch (e) {}
        }
        return out;
    }
};
"""


def classify(name, ns, fields):
    weak = False
    if name and all(c.isalnum() or c == '_' for c in name):
        letters = [c for c in name if c.isalpha()]
        if letters:
            ratio = sum(1 for c in letters if c.isupper()) / len(letters)
            if (4 <= len(name) <= 16 and 0.25 < ratio < 0.85
                    and not name.lower().startswith(
                        ('get_', 'set_', 'cell_', 'page_', 'menu_', 'btn', 'text_', 'icon'))):
                weak = True
    compiler = bool(name and ('<' in name or '__' in name or name.startswith('$')))
    kind = 'compiler' if compiler else ('weak' if weak else 'real')
    named_fields = [f for f in fields if f.get('n')]
    ref_fields = sum(1 for f in fields if f.get('t'))
    is_dto = len(named_fields) >= 2 and ref_fields >= 1
    return kind, is_dto


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--pid", type=int, required=True)
    ap.add_argument("--out", default=OUT)
    args = ap.parse_args()

    import frida
    s = frida.attach(args.pid)
    sc = s.create_script(JS)
    sc.on('message', lambda m, d: print("  [js]", m.get('payload', m)) if m.get('type') == 'send' else None)
    sc.load()
    api = sc.exports_sync

    print("[1] locating metadata blob ...", flush=True)
    blob = api.locateblob()
    print(f"    chosen blob regions: {[(b['base'], b['hits'], b['size']//1048576) for b in blob['chosen']]}", flush=True)
    if not blob['chosen']:
        print("    FAILED: no blob found"); s.detach(); return

    print("[2] verifying known layout (apo=0x120, st=0x20, no=0) ...", flush=True)
    # Known-good from prior live derivation; verify before trusting.
    KNOWN = (0x120, 0x20, 0x0)
    chk = api.verifylayout(KNOWN[0], KNOWN[1], KNOWN[2])
    if chk['ok'] >= 20:
        apo, st, no = KNOWN
        print(f"    known layout verified: {chk['ok']} field-bearing classes, "
              f"samples={chk['samples'][:3]}", flush=True)
    else:
        print(f"    known layout weak (ok={chk['ok']}); running consensus ...", flush=True)
        lay = api.derivelayout()
        if not lay['votes']:
            print(f"    FAILED: no layout consensus (tried={lay['tried']})"); s.detach(); return
        winner = max(lay['votes'].items(), key=lambda kv: kv[1])
        apo_s, st_s, no_s = winner[0].split('|')
        apo, st, no = int(apo_s), int(st_s), int(no_s)
        print(f"    consensus winner: field_array_ptr=+{apo:#x} stride={st:#x} "
              f"name_sub=+{no:#x} (votes={winner[1]}/{lay['tried']})", flush=True)

    print("[3] deriving count/ns/type/foff offsets ...", flush=True)
    offs = api.deriveoffsets(apo, st, no)
    def best(h, default):
        return int(max(h.items(), key=lambda kv: kv[1])[0]) if h else default
    countOff = best(offs['countOff'], 0x120)
    nsOff = best(offs['nsOff'], 0x18)
    typeOff = best(offs['typeOff'], 0x8)
    foffOff = best(offs['foffOff'], 0x18)
    print(f"    count=+{countOff:#x} ns=+{nsOff:#x} fieldType=+{typeOff:#x} "
          f"fieldOff=+{foffOff:#x} (ok={offs['ok']})", flush=True)

    lay_cfg = {"apo": apo, "st": st, "no": no, "countOff": countOff,
               "nsOff": nsOff, "typeOff": typeOff, "foffOff": foffOff}

    print("[4] full harvest ...", flush=True)
    api.setblobs([[int(b['base'], 16), b['size']] for b in blob['chosen']])
    ranges = api.ranges()
    classes = {}
    t0 = time.time()
    for ri, (base, size) in enumerate(ranges):
        if size < 0x10000:
            continue
        off = 0
        while off < size:
            chunk = min(0x800000, size - off)
            try:
                recs = api.harvest(hex(int(base, 16) + off), chunk, lay_cfg)
            except Exception:
                recs = []
            for r in recs:
                if r["klass"] not in classes:
                    classes[r["klass"]] = r
            off += chunk
        if ri % 200 == 0:
            print(f"\r    region {ri}/{len(ranges)} classes={len(classes)} "
                  f"{time.time()-t0:.0f}s", end="", flush=True)
    s.detach()
    print(f"\n[+] harvested {len(classes)} distinct live classes in {time.time()-t0:.0f}s", flush=True)

    by_kind = {"real": 0, "weak": 0, "compiler": 0}
    dto = 0
    recs = []
    named_field_classes = 0
    for r in classes.values():
        kind, is_dto = classify(r["name"], r.get("ns"), r.get("fields", []))
        r["kind"] = kind
        r["is_dto"] = is_dto
        by_kind[kind] += 1
        if is_dto:
            dto += 1
        if any(f.get("n") for f in r.get("fields", [])):
            named_field_classes += 1
        recs.append(r)

    out = {
        "session_pid": args.pid,
        "layout": lay_cfg,
        "blob": [b['base'] for b in blob['chosen']],
        "harvested": len(recs),
        "by_kind": by_kind,
        "dto_candidates": dto,
        "classes_with_named_fields": named_field_classes,
        "classes": recs,
    }
    os.makedirs(os.path.dirname(args.out), exist_ok=True)
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(out, f, ensure_ascii=False)
    print(f"[+] kinds={by_kind} dto={dto} named_field_classes={named_field_classes}", flush=True)
    print(f"[+] wrote {args.out}", flush=True)


if __name__ == "__main__":
    main()
