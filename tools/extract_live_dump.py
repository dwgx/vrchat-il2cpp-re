#!/usr/bin/env python3
"""
extract_live_dump.py - Extract IL2CPP type data from LIVE VRChat process via Frida.

Much faster than take_new_dump.py + extract_precise_dump.py (no 3.6GB dump file).
Scans the managed heap for Il2CppClass structs using the self-reference check,
then reads all class/method/field data.

Usage:
  python tools/extract_live_dump.py                  # full extraction
  python tools/extract_live_dump.py --quick           # only scan, no method pointers
  (VRChat.exe --no-vr must be running)

Output: data/precise_dump.json (overwrites existing)
"""

import json, sys, time, argparse, frida
from pathlib import Path
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
OUTPUT_PATH = BASE_DIR / 'data' / 'precise_dump.json'

EXTRACT_JS = r"""
'use strict';

var _gaMod = Process.findModuleByName('GameAssembly.dll');
if (!_gaMod) throw new Error('GameAssembly.dll not found');
var GA = _gaMod.base;
var GA_SIZE = _gaMod.size;

// Dual layout support: Beebyte-modified vs standard IL2CPP
var OFF_BEEBYTE = {
    NAME: 0x58, METHODS: 0x78, FIELDS: 0xA0, PARENT: 0xA8,
    MC: 0x120, FC: 0x124, MI_NAME: 0x18,
};
var OFF_STANDARD = {
    NAME: 0x10, METHODS: 0x80, FIELDS: 0x80, PARENT: 0x58,
    MC: 0x100, FC: 0x102, MI_NAME: 0x10,
};
// Shared offsets (same for both layouts)
var OFF = {
    IMAGE:    0x00,
    NS:       0x18,
    ELEM:     0x40,
    CAST:     0x48,
    NAME:     0x58,
    METHODS:  0x78,
    FIELDS:   0xA0,
    PARENT:   0xA8,
    STATIC:   0xB8,
    MC:       0x120,
    FC:       0x124,
};

// MethodInfo offsets
var MI_CODE = 0x00;
var MI_NAME = 0x18;

function detectLayout(p) {
    // Try Beebyte name offset first (+0x58)
    try {
        var n58 = p.add(0x58).readPointer();
        if (!n58.isNull()) {
            var s = readCStr(n58);
            if (s && s.length > 0) return 'beebyte';
        }
    } catch(e) {}
    // Standard name offset (+0x10)
    try {
        var n10 = p.add(0x10).readPointer();
        if (!n10.isNull()) {
            var s = readCStr(n10);
            if (s && s.length > 0) return 'standard';
        }
    } catch(e) {}
    return null;
}

// FieldInfo stride and offsets
var FI_STRIDE = 0x30;
var FI_NAME   = 0x20;
var FI_TYPE   = 0x08;
var FI_OFFSET = 0x28;

function readCStr(p) {
    if (p.isNull()) return null;
    try { var s = p.readUtf8String(); return (s && s.length < 500) ? s : null; }
    catch (e) { return null; }
}

// Scan heap for Il2CppClass structs
function scanForClasses(startVA, endVA) {
    var classes = [];
    var step = 8;
    var checked = 0;
    var found = 0;

    for (var va = startVA; va < endVA - 0x180; va += step) {
        checked++;
        try {
            var p = ptr(va);
            // Self-reference check: +0x40 == self AND +0x48 == self
            var elem = p.add(OFF.ELEM).readPointer();
            if (elem.compare(p) !== 0) continue;
            var cast = p.add(OFF.CAST).readPointer();
            if (cast.compare(p) !== 0) continue;

            // Detect layout and read name
            var layout = detectLayout(p);
            if (!layout) continue;
            var L = (layout === 'beebyte') ? OFF_BEEBYTE : OFF_STANDARD;

            var name = readCStr(p.add(L.NAME).readPointer());
            if (!name || name.length === 0) continue;

            // Read method/field counts using detected layout
            var mc = p.add(L.MC).readU16();
            if (mc > 5000) continue;
            var fc = p.add(L.FC).readU16();
            if (fc > 2000) continue;

            var ns = readCStr(p.add(OFF.NS).readPointer()) || '';

            // Read parent class name
            var parentName = '';
            try {
                var parentPtr = p.add(L.PARENT).readPointer();
                if (!parentPtr.isNull()) {
                    var pLayout = detectLayout(parentPtr);
                    var pNameOff = pLayout === 'beebyte' ? 0x58 : 0x10;
                    parentName = readCStr(parentPtr.add(pNameOff).readPointer()) || '';
                }
            } catch (e) {}

            classes.push({
                va: va,
                name: name,
                ns: ns,
                parent: parentName,
                mc: mc,
                fc: fc,
                layout: layout,
            });
            found++;
        } catch (e) {
            // Access violation - skip this address
            continue;
        }
    }
    return { classes: classes, checked: checked, found: found };
}

// Extract methods — try both layouts, keep whichever finds more
function extractMethods(klassVA, mc, layout) {
    var best = { methods: [], method_pointers: {} };
    var configs = [
        {mOff: 0x78, miName: 0x18, mcOff: 0x120},  // Beebyte
        {mOff: 0x78, miName: 0x10, mcOff: 0x120},  // Beebyte methods, standard MI name
        {mOff: 0x80, miName: 0x10, mcOff: 0x100},  // Standard
        {mOff: 0x80, miName: 0x18, mcOff: 0x100},  // Standard methods, Beebyte MI name
    ];
    for (var ci = 0; ci < configs.length; ci++) {
        var cfg = configs[ci];
        var methods = [];
        var methodPtrs = {};
        try {
            var klass = ptr(klassVA);
            var useMc = klass.add(cfg.mcOff).readU16();
            if (useMc > 5000) useMc = mc;
            var methodArr = klass.add(cfg.mOff).readPointer();
            if (methodArr.isNull()) continue;
            for (var i = 0; i < Math.min(useMc, 500); i++) {
                var mi = methodArr.add(i * 8).readPointer();
                if (mi.isNull()) break;
                var name = readCStr(mi.add(cfg.miName).readPointer());
                if (!name) break;
                methods.push(name);
                try {
                    var code = mi.add(MI_CODE).readPointer();
                    if (!code.isNull()) methodPtrs[name] = code.toString();
                } catch (e) {}
            }
        } catch (e) { continue; }
        if (methods.length > best.methods.length) {
            best = { methods: methods, method_pointers: methodPtrs };
        }
    }
    return best;
}

// Extract fields for a class
function extractFields(klassVA, fc) {
    var fields = [];
    try {
        var klass = ptr(klassVA);
        var fieldArr = klass.add(OFF.FIELDS).readPointer();
        if (fieldArr.isNull()) return fields;

        for (var i = 0; i < Math.min(fc, 500); i++) {
            var fi = fieldArr.add(i * FI_STRIDE);
            var name = readCStr(fi.add(FI_NAME).readPointer());
            if (!name) continue;

            var offset = -1;
            try { offset = fi.add(FI_OFFSET).readU32(); } catch (e) {}

            fields.push({ name: name, offset: offset });
        }
    } catch (e) {}
    return fields;
}

rpc.exports = {
    getInfo: function() {
        return {
            ga_base: GA.toString(),
            ga_size: GA_SIZE,
            ga_path: _gaMod.path,
        };
    },

    // Scan a chunk of heap for classes (called in batches to avoid timeout)
    scanChunk: function(startVA, endVA) {
        return scanForClasses(startVA, endVA);
    },

    // Extract method+field data for a batch of classes
    // klassInfos: [{va, layout}, ...]
    extractBatch: function(klassInfos, quick) {
        var results = [];
        for (var i = 0; i < klassInfos.length; i++) {
            var info = klassInfos[i];
            var va = info.va || info;
            var layout = info.layout || 'beebyte';
            var L = (layout === 'beebyte') ? OFF_BEEBYTE : OFF_STANDARD;
            var klass = ptr(va);
            var mc = klass.add(L.MC).readU16();
            var fc = klass.add(L.FC).readU16();

            var entry = { va: '0x' + va.toString(16).toUpperCase() };

            if (!quick) {
                var mdata = extractMethods(va, mc, layout);
                entry.methods = mdata.methods;
                entry.method_pointers = mdata.method_pointers;
            }

            var fdata = extractFields(va, fc);
            entry.fields = fdata;

            results.push(entry);
        }
        return results;
    },
};
"""


def main():
    parser = argparse.ArgumentParser(description='Live IL2CPP dump extraction via Frida')
    parser.add_argument('--quick', action='store_true', help='Skip method pointer extraction')
    args = parser.parse_args()

    print("=" * 60)
    print("  Live IL2CPP Dump Extraction")
    print("=" * 60)

    # Attach to VRChat
    print("\n[1/4] Attaching to VRChat...")
    try:
        session = frida.attach("VRChat.exe")
    except frida.ProcessNotFoundError:
        print("  ERROR: VRChat.exe not running!")
        sys.exit(1)

    script = session.create_script(EXTRACT_JS)
    script.on('message', lambda msg, data: print(f"  JS: {msg}"))
    script.load()
    api = script.exports_sync

    info = api.get_info()
    ga_base = int(info['ga_base'], 16)
    print(f"  GA base: {info['ga_base']}, size: {info['ga_size']:,} bytes")

    # Scan heap for classes in chunks
    print("\n[2/4] Scanning heap for Il2CppClass structs...")
    HEAP_START = 0x28000000
    HEAP_END = 0x48000000
    CHUNK_SIZE = 0x800000  # 8MB chunks

    all_classes = []
    t0 = time.time()

    chunks = list(range(HEAP_START, HEAP_END, CHUNK_SIZE))
    for i, start in enumerate(chunks):
        end = min(start + CHUNK_SIZE, HEAP_END)
        result = api.scan_chunk(start, end)
        all_classes.extend(result['classes'])
        pct = (i + 1) / len(chunks) * 100
        print(f"\r  Scanning: {pct:5.1f}% ({len(all_classes)} classes found)", end='', flush=True)

    elapsed = time.time() - t0
    print(f"\n  Found {len(all_classes)} classes in {elapsed:.1f}s")

    # Extract method and field data
    print(f"\n[3/4] Extracting {'methods + fields' if not args.quick else 'fields only'}...")
    t0 = time.time()

    BATCH_SIZE = 200
    class_infos = [{'va': c['va'], 'layout': c.get('layout', 'beebyte')} for c in all_classes]
    class_lookup = {c['va']: c for c in all_classes}

    for i in range(0, len(class_infos), BATCH_SIZE):
        batch = class_infos[i:i + BATCH_SIZE]
        results = api.extract_batch(batch, args.quick)

        for r in results:
            va = int(r['va'], 16)
            if va in class_lookup:
                if 'methods' in r:
                    class_lookup[va]['methods'] = r['methods']
                    class_lookup[va]['method_pointers'] = r['method_pointers']
                if 'fields' in r:
                    class_lookup[va]['fields'] = r['fields']

        pct = min(i + BATCH_SIZE, len(class_vas)) / len(class_vas) * 100
        print(f"\r  Extracting: {pct:5.1f}%", end='', flush=True)

    elapsed = time.time() - t0
    print(f"\n  Extraction done in {elapsed:.1f}s")

    session.detach()

    # Build output in same format as extract_precise_dump.py
    print("\n[4/4] Building dump...")
    namespaces = defaultdict(list)
    total_methods = 0
    total_fields = 0
    types_with_methods = 0
    types_with_fields = 0

    for c in all_classes:
        ns = c.get('ns', '')
        entry = {
            'name': c['name'],
            'namespace': ns,
            'parent': c.get('parent', ''),
            'va': f"0x{c['va']:X}",
        }

        methods = c.get('methods', [])
        if methods:
            entry['methods'] = methods
            total_methods += len(methods)
            types_with_methods += 1

        mp = c.get('method_pointers', {})
        if mp:
            entry['method_pointers'] = mp

        fields = c.get('fields', [])
        if fields:
            entry['fields'] = fields
            total_fields += len(fields)
            types_with_fields += 1

        namespaces[ns].append(entry)

    dump = {
        'summary': {
            'total_types': len(all_classes),
            'total_methods': total_methods,
            'total_fields': total_fields,
            'types_with_methods': types_with_methods,
            'types_with_fields': types_with_fields,
            'namespace_count': len(namespaces),
            'method': 'live_frida_extraction',
            'generated': time.strftime('%Y-%m-%d %H:%M:%S'),
            'ga_base': info['ga_base'],
            'ga_size': info['ga_size'],
        },
        'namespaces': dict(namespaces),
    }

    # Backup old dump
    if OUTPUT_PATH.exists():
        backup = OUTPUT_PATH.with_suffix('.json.bak')
        import shutil
        shutil.copy2(OUTPUT_PATH, backup)
        print(f"  Backed up old dump to {backup.name}")

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(dump, f, ensure_ascii=False, indent=2)

    print(f"\n{'=' * 60}")
    print(f"  DUMP COMPLETE")
    print(f"{'=' * 60}")
    print(f"  Types:      {len(all_classes):,}")
    print(f"  Methods:    {total_methods:,}")
    print(f"  Fields:     {total_fields:,}")
    print(f"  Namespaces: {len(namespaces)}")
    print(f"  Output:     {OUTPUT_PATH}")
    print(f"{'=' * 60}")


if __name__ == '__main__':
    main()
