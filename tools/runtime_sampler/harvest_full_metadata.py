#!/usr/bin/env python3
"""
harvest_full_metadata.py - the ONE serial live-capture the swarm depends on.

Confirmed live layout (this build) — derived empirically, NOT from the dead
minidump offsets:
  klass + 0x50   -> name pointer (into the metadata string blob)
  klass + 0x120  -> FieldInfo[] array pointer (present iff the class has fields)
  FieldInfo + 0x00 -> field name pointer (into the blob)        (stride 0x20)
  FieldInfo + 0x08 -> Il2CppType* (field type)                   (candidate)
  FieldInfo + 0x18 -> field offset (u32)                         (candidate)

Field COUNT is read by walking the FieldInfo[] until a name pointer fails to
resolve to a blob ASCII string (the empirically robust method — the u16 count
offset shifted between builds and is noisy live).

A genuine Il2CppClass is discriminated by: its name pointer falls inside the
metadata string blob (a single ~128MB rw- region holding all type/field name
C-strings), AND it is referenced as obj[0] by >=2 live objects (frequency gate
filters one-off string objects that merely have ASCII at +0x50).

Pure read-only memory. Zero GameAssembly export calls (Beebyte strips/renames
exports; return-address anti-tamper rejects bridge NativeFunction calls).

Output: output/p2_research/full_metadata_substrate.json
  { session_pid, blob_base, blob_size, harvested,
    classes: [ {klass, name, ns, fields:[{name,type_ptr,offset}], freq, kind, is_dto} ] }
"""
import argparse
import json
import os
import time

REPO = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
OUT = os.path.join(REPO, "output", "p2_research", "full_metadata_substrate.json")

AGENT_JS = r"""
'use strict';
var BB = 0, BE = 0;                       // metadata blob bounds (set by init)
function inBlob(a) { return a >= BB && a < BE; }

function readName(p) {                     // ASCII C-string in the blob, else null
    try {
        var a = parseInt(p.toString(), 16);
        if (!inBlob(a)) return null;
        var s = p.readCString();
        if (!s || s.length === 0 || s.length > 200) return null;
        for (var i = 0; i < s.length; i++) {
            var c = s.charCodeAt(i);
            if (c < 0x20 || c > 0x7e) return null;
        }
        return s;
    } catch (e) { return null; }
}

function klassName(k) { try { return readName(k.add(0x50).readPointer()); } catch (e) { return null; } }

// Namespace pointer: a SECOND blob ASCII pointer in the class header (offsets
// probed live). We try a small set and accept the first that resolves; empty
// string (global namespace) is valid, so we distinguish null (absent) from "".
function klassNs(k) {
    var cands = [0x48, 0x18, 0x10, 0x20, 0x28];
    for (var i = 0; i < cands.length; i++) {
        try {
            var p = k.add(cands[i]).readPointer();
            var a = parseInt(p.toString(), 16);
            if (!inBlob(a)) continue;
            var s = p.readCString();
            if (s === null) continue;
            if (s.length > 120) continue;
            var ok = true;
            for (var j = 0; j < s.length; j++) {
                var c = s.charCodeAt(j);
                if (c < 0x20 || c > 0x7e) { ok = false; break; }
            }
            if (!ok) continue;
            // skip if it's just the name again
            if (s === klassName(k)) continue;
            return s;
        } catch (e) {}
    }
    return null;
}

// Walk FieldInfo[] at klass+0x120, stride 0x20, name at +0x0. Stop when a name
// pointer fails to resolve to a blob string. Capture type ptr (+0x08) and
// field offset (+0x18) as best-effort.
function klassFields(k) {
    var out = [];
    try {
        var fa = k.add(0x120).readPointer();
        if (fa.isNull() || fa.and(0x7).toUInt32() !== 0) return out;
        var faa = parseInt(fa.toString(), 16);
        if (faa < 0x100000 || faa > 0x7FFFFFFFFFFF) return out;
        for (var i = 0; i < 128; i++) {
            var fi = fa.add(i * 0x20);
            var nm = readName(fi.readPointer());
            if (!nm) break;
            var tp = null, foff = 0;
            try {
                var t = fi.add(0x08).readPointer();
                if (!t.isNull()) tp = t.toString();
            } catch (e) {}
            try { foff = fi.add(0x18).readU32(); if (foff > 0x100000) foff = 0; } catch (e) {}
            out.push({ name: nm, type_ptr: tp, offset: foff });
        }
    } catch (e) {}
    return out;
}

rpc.exports = {
    init: function (bbStr, size) { BB = parseInt(bbStr, 16); BE = BB + size; return [BB, BE]; },
    ranges: function () {
        return Process.enumerateRanges('rw-').map(function (r) { return [r.base.toString(), r.size]; });
    },
    // Pass 1: frequency-tally klass-ptr candidates whose name is in the blob.
    tally: function (baseStr, size) {
        var base = ptr(baseStr), freq = {};
        for (var off = 0; off + 0x10 < size; off += 0x10) {
            try {
                var kp = base.add(off).readPointer();
                if (kp.isNull() || kp.and(0x7).toUInt32() !== 0) continue;
                var ks = kp.toString();
                if (freq[ks] !== undefined) { freq[ks]++; continue; }
                var nm = klassName(kp);
                if (!nm || nm.length < 2) continue;
                freq[ks] = 1;
            } catch (e) {}
        }
        return freq;
    },
    // Pass 2: full record for confirmed klass ptrs.
    detail: function (ptrList) {
        var out = [];
        for (var i = 0; i < ptrList.length; i++) {
            try {
                var kp = ptr(ptrList[i]);
                var nm = klassName(kp);
                if (!nm) continue;
                out.push({
                    klass: ptrList[i], name: nm, ns: klassNs(kp),
                    fields: klassFields(kp)
                });
            } catch (e) {}
        }
        return out;
    }
};
"""


FIND_BLOB_JS = r"""
rpc.exports={fb:function(){
  var ranges=Process.enumerateRanges('rw-');var rv={};var n=0;
  for(var i=0;i<ranges.length&&n<4000;i++){
    var base=ranges[i].base,size=Math.min(ranges[i].size,0x200000);
    for(var off=0;off+0x10<size;off+=0x10){
      try{var kp=base.add(off).readPointer();
        if(kp.isNull()||kp.and(0x7).toUInt32()!==0)continue;
        var np=kp.add(0x50).readPointer();
        if(np.isNull()||np.and(0x7).toUInt32()!==0)continue;
        var c=np.readCString();
        if(!c||!/^[A-Z][A-Za-z0-9_]{4,30}$/.test(c))continue;
        var r=Process.findRangeByAddress(np);
        if(r){var k=r.base.toString()+'|'+r.size;rv[k]=(rv[k]||0)+1;n++;}
      }catch(e){}
    }
  }
  return Object.keys(rv).map(function(k){return[k,rv[k]];})
    .sort(function(a,b){return b[1]-a[1];}).slice(0,3);
}};
"""


def discover_pid():
    import frida
    for p in frida.get_local_device().enumerate_processes():
        if p.name.lower() == "vrchat.exe":
            return p.pid
    return None


def discover_blob(session):
    """Most klass name pointers land in the metadata string blob region."""
    sc = session.create_script(FIND_BLOB_JS)
    sc.load()
    top = sc.exports_sync.fb()
    sc.unload()
    if not top:
        return None, None
    base_str, size_str = top[0][0].split("|")
    return base_str, int(size_str)


def classify(name, ns, fields):
    weak = False
    if name and all(c.isalnum() or c == '_' for c in name):
        letters = [c for c in name if c.isalpha()]
        if letters:
            uppers = sum(1 for c in letters if c.isupper())
            ratio = uppers / len(letters)
            if (4 <= len(name) <= 16 and 0.25 < ratio < 0.85
                    and not any(name.lower().startswith(p) for p in (
                        'get_', 'set_', 'cell_', 'page_', 'menu_', 'btn', 'text_'))):
                weak = True
    compiler = bool(name and ('<' in name or '__' in name or name.startswith('$')))
    kind = 'compiler' if compiler else ('weak' if weak else 'real')
    ref_fields = sum(1 for f in fields if f.get('type_ptr'))
    is_dto = len(fields) >= 2 and ref_fields >= 1
    return kind, is_dto


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--pid", type=int, default=0, help="0 = auto-discover VRChat.exe")
    ap.add_argument("--blob-base", default="", help="hex; empty = auto-discover")
    ap.add_argument("--blob-size", type=lambda x: int(x, 0), default=0x8000000)
    ap.add_argument("--min-freq", type=int, default=2)
    ap.add_argument("--min-hits", type=int, default=3)
    ap.add_argument("--out", default=OUT)
    args = ap.parse_args()

    import frida
    pid = args.pid or discover_pid()
    if not pid:
        print("[!] VRChat.exe not found"); return
    s = frida.attach(pid)
    if args.blob_base:
        blob_base, blob_size = args.blob_base, args.blob_size
    else:
        blob_base, blob_size = discover_blob(s)
        if not blob_base:
            print("[!] could not locate metadata blob"); return
    sc = s.create_script(AGENT_JS)
    sc.load()
    api = sc.exports_sync
    api.init(blob_base, blob_size)
    print(f"[+] pid {pid} blob {blob_base} size {blob_size:#x}", flush=True)

    ranges = api.ranges()
    print(f"[+] rw- ranges: {len(ranges)}", flush=True)

    # Find dense regions (cheap head probe) then deep-tally them.
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
    print(f"[+] {len(dense)} dense regions", flush=True)

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
        print(f"\r  region {ri+1}/{len(dense)} cand={len(freq)} {time.time()-t0:.0f}s",
              end="", flush=True)
    print(f"\n[+] pass1: {len(freq)} candidates in {time.time()-t0:.0f}s", flush=True)

    keep = [k for k, c in freq.items() if c >= args.min_freq]
    print(f"[+] {len(keep)} pass freq>={args.min_freq}", flush=True)

    classes = {}
    for i in range(0, len(keep), 400):
        try:
            recs = api.detail(keep[i:i + 400])
        except Exception:
            recs = []
        for r in recs:
            r["freq"] = freq.get(r["klass"], 0)
            classes[r["klass"]] = r
    s.detach()
    print(f"[+] pass2: {len(classes)} confirmed classes", flush=True)

    by_kind = {"real": 0, "weak": 0, "compiler": 0}
    dto = 0
    with_fields = 0
    recs = []
    for r in classes.values():
        kind, is_dto = classify(r["name"], r.get("ns"), r.get("fields", []))
        r["kind"] = kind
        r["is_dto"] = is_dto
        by_kind[kind] += 1
        if is_dto:
            dto += 1
        if r.get("fields"):
            with_fields += 1
        recs.append(r)

    out = {
        "session_pid": pid,
        "blob_base": blob_base,
        "blob_size": blob_size,
        "harvested": len(recs),
        "with_fields": with_fields,
        "by_kind": by_kind,
        "dto_candidates": dto,
        "classes": recs,
    }
    os.makedirs(os.path.dirname(args.out), exist_ok=True)
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(out, f, ensure_ascii=False)
    print(f"[+] kinds={by_kind} with_fields={with_fields} dto={dto}", flush=True)
    print(f"[+] wrote {args.out}", flush=True)


if __name__ == "__main__":
    main()
