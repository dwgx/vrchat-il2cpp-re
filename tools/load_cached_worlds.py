#!/usr/bin/env python3
"""
Cached World Loader + Component Scanner

Lists VRChat's cached worlds and triggers loading a specific one via Frida,
then runs v3-style component scanning on the loaded world.

Strategy:
  VRChat offline mode loads Error World after failing to connect.
  VRCFlowManager.GoHome coroutine (vtable+0x298) handles world loading.
  The "Destination" is set via a string field on a manager object.

  Approach:
    1. List cached worlds from disk (Cache-WindowsPlayer/)
    2. Cross-reference with VRChat logs to find world IDs for cache entries
    3. Hook the AssetBundleDownload path to redirect world loading
    4. Or: find the destination world ID string in memory and overwrite it
    5. After world loads, run component scanning

  This is research-grade code. Each approach has a chance of failure.
  The script provides multiple strategies and diagnostic output.

Usage:
  python tools/load_cached_worlds.py --list           # list cached worlds
  python tools/load_cached_worlds.py --list-logs       # list worlds from logs
  python tools/load_cached_worlds.py --scan            # scan current world (no reload)
  python tools/load_cached_worlds.py --world wrld_xxx  # load specific world, then scan

Requires: VRChat.exe --no-vr running (offline mode)
"""

import json, sys, os, re, time, argparse, glob
from pathlib import Path
from datetime import datetime
from collections import defaultdict

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
SCRIPT_V3_PATH = BASE_DIR / 'tools' / 'identify_components_v3.js'
OUTPUT_PATH = BASE_DIR / 'output' / 'world_scan_results.json'

# VRChat data paths
VRCHAT_DATA = Path(os.environ.get('LOCALAPPDATA', '')) / '..' / 'LocalLow' / 'VRChat' / 'VRChat'
CACHE_DIR = VRCHAT_DATA / 'Cache-WindowsPlayer'
LOG_DIR = VRCHAT_DATA

# Key RVAs (from binary analysis, same as frida_find_gohome.js / frida_auto_gohome.py)
RVA_ERROR_STATE_SETTER = 0x1943BC0  # called ~140/sec, arg0+0x20 = FlowManager
RVA_FM_GOHOME_VTABLE_OFFSET = 0x298  # FlowManager klass vtable offset for GoHome
RVA_FM_M935 = 0x1924340  # FlowManager.m_935 = GoHome direct RVA

# ════════════════════════════════════════════════════════════
# Part 1: Cache & Log Analysis (no Frida needed)
# ════════════════════════════════════════════════════════════

def list_cached_worlds():
    """List all cached asset bundles with timestamps."""
    if not CACHE_DIR.exists():
        print(f"  Cache directory not found: {CACHE_DIR}")
        return []

    entries = []
    for d in CACHE_DIR.iterdir():
        if not d.is_dir():
            continue
        # Each cache entry has a hex-named subdirectory with __data and __info
        for sub in d.iterdir():
            if not sub.is_dir():
                continue
            info_file = sub / '__info'
            data_file = sub / '__data'
            if not info_file.exists():
                continue
            try:
                info_text = info_file.read_text(encoding='utf-8', errors='replace').strip()
                lines = info_text.split('\n')
                # Format: version\ntimestamp\n?\n__data
                timestamp = int(lines[1]) if len(lines) > 1 else 0
                size = data_file.stat().st_size if data_file.exists() else 0
                entries.append({
                    'cache_key': d.name,
                    'sub_key': sub.name,
                    'path': str(sub),
                    'timestamp': timestamp,
                    'date': datetime.fromtimestamp(timestamp).strftime('%Y-%m-%d %H:%M') if timestamp > 0 else '?',
                    'size_mb': round(size / (1024 * 1024), 1),
                })
            except Exception:
                continue

    entries.sort(key=lambda x: x['timestamp'], reverse=True)
    return entries


def parse_logs_for_worlds():
    """Parse VRChat output logs to find world IDs and their cache associations."""
    worlds = {}  # wrld_id -> {last_seen, name, instances, ...}

    log_files = sorted(LOG_DIR.glob('output_log_*.txt'), reverse=True)
    if not log_files:
        print(f"  No log files found in {LOG_DIR}")
        return worlds

    # Patterns to match
    re_destination = re.compile(r'\[Behaviour\] Destination (?:requested|set|fetching): (wrld_[a-f0-9-]+)')
    re_gohome = re.compile(r'\[Behaviour\] Going to Home Location: (wrld_[a-f0-9-]+)')
    re_unpacking = re.compile(r'\[AssetBundleDownloadManager\] \[\d+\] Unpacking World \((wrld_[a-f0-9-]+)\)')
    re_entering = re.compile(r'\[Behaviour\] Entering Room: (.+)')
    re_loaded = re.compile(r'Memory Usage: after world loaded \[([^\]]+)\]')
    re_timestamp = re.compile(r'^(\d{4}\.\d{2}\.\d{2} \d{2}:\d{2}:\d{2})')

    for log_file in log_files[:50]:  # last 50 logs
        try:
            with open(log_file, 'r', encoding='utf-8', errors='replace') as f:
                current_world = None
                current_time = None
                for line in f:
                    tm = re_timestamp.match(line)
                    if tm:
                        current_time = tm.group(1)

                    for rx in [re_destination, re_gohome, re_unpacking]:
                        m = rx.search(line)
                        if m:
                            wid = m.group(1)
                            if wid not in worlds:
                                worlds[wid] = {
                                    'world_id': wid,
                                    'last_seen': current_time or '?',
                                    'log_file': log_file.name,
                                    'room_name': None,
                                    'visits': 0,
                                }
                            worlds[wid]['visits'] += 1
                            worlds[wid]['last_seen'] = current_time or worlds[wid]['last_seen']
                            current_world = wid

                    m = re_entering.search(line)
                    if m and current_world:
                        worlds[current_world]['room_name'] = m.group(1).strip()
        except Exception as e:
            print(f"  Warning: Could not read {log_file.name}: {e}")

    return worlds


# ════════════════════════════════════════════════════════════
# Part 2: Frida World Loading Agent
# ════════════════════════════════════════════════════════════

WORLD_LOADER_JS = r"""
'use strict';
/**
 * World Loader Agent — Find FlowManager, intercept world loading,
 * redirect to a target world, and trigger GoHome.
 *
 * Beebyte IL2CPP struct offsets:
 *   Il2CppClass: +0x18=namespace, +0x58=name, +0x78=MethodInfo**,
 *                +0xA8=parent, +0xB8=static_fields, +0x120=method_count(u16)
 *   Il2CppString: +0x10=length(i32), +0x14=chars(UTF-16)
 */

var _gaMod = Process.findModuleByName('GameAssembly.dll');
if (!_gaMod) throw new Error('GameAssembly.dll not found');
var GA = _gaMod.base;

var RVA = {
    error_state_setter: 0x1943BC0,
};

var fn = {
    getTransform:  null,  // resolved dynamically from Component klass
    getGameObject: null,
    getName:       null,
    getChildCount: null,
    getChild:      null,
    getRoot:       null,
    getParent:     null,
    getCompCount:  null,
    queryCompAt:   null,
};

function readCStr(p) {
    if (p.isNull()) return null;
    try { var s = p.readUtf8String(); return (s && s.length < 500) ? s : null; }
    catch (e) { return null; }
}

function readIl2CppString(p) {
    if (p.isNull()) return null;
    try {
        var len = p.add(0x10).readInt();
        if (len > 0 && len < 2000) return p.add(0x14).readUtf16String(len);
    } catch (e) {}
    return null;
}

function writeIl2CppString(p, str) {
    // Overwrites an existing Il2CppString in-place (dangerous but useful for research)
    // Only works if new string length <= old string length
    try {
        var oldLen = p.add(0x10).readInt();
        if (str.length > oldLen) return false;
        p.add(0x10).writeInt(str.length);
        for (var i = 0; i < str.length; i++) {
            p.add(0x14 + i * 2).writeU16(str.charCodeAt(i));
        }
        // Null-terminate
        p.add(0x14 + str.length * 2).writeU16(0);
        return true;
    } catch (e) { return false; }
}

function findMethodByName(klass, methodName) {
    try {
        var methodArr = klass.add(0x78).readPointer();
        if (methodArr.isNull()) return null;
        var mc = klass.add(0x120).readU16();
        for (var i = 0; i < Math.min(mc, 200); i++) {
            var mi = methodArr.add(i * 8).readPointer();
            if (mi.isNull()) return null;
            var name = readCStr(mi.add(0x18).readPointer());
            if (name === methodName) return mi.readPointer();
        }
    } catch (e) {}
    return null;
}

function readKlassInfo(klass) {
    try {
        return {
            name: readCStr(klass.add(0x58).readPointer()) || '?',
            ns: readCStr(klass.add(0x18).readPointer()) || '',
            method_count: klass.add(0x120).readU16(),
            field_count: klass.add(0x124).readU16(),
            parent: (function() {
                try {
                    var p = klass.add(0xA8).readPointer();
                    return p.isNull() ? null : readCStr(p.add(0x58).readPointer());
                } catch(e) { return null; }
            })(),
        };
    } catch (e) { return null; }
}

// ═══════════════════════════════════════════════════
// State
// ═══════════════════════════════════════════════════
var flowManagerPtr = null;
var flowManagerKlass = null;
var bootstrapped = false;

var visitedGOs = {};
var allComponents = [];

// ═══════════════════════════════════════════════════
// FlowManager discovery (same as v3)
// ═══════════════════════════════════════════════════
function findFlowManager(timeoutMs) {
    var found = false;
    var result = null;

    var hook = Interceptor.attach(GA.add(RVA.error_state_setter), {
        onEnter: function (args) {
            if (found) return;
            try {
                var obj = args[0];
                if (obj.isNull()) return;
                var fm = obj.add(0x20).readPointer();
                if (fm.isNull()) return;
                var klass = fm.readPointer();
                if (klass.isNull()) return;
                var mc = klass.add(0x120).readU16();
                if (mc > 10) {
                    result = fm;
                    found = true;
                }
            } catch (e) {}
        }
    });

    var start = Date.now();
    while (!found && (Date.now() - start) < timeoutMs) {
        Thread.sleep(0.05);
    }
    hook.detach();

    if (result) {
        flowManagerPtr = result;
        flowManagerKlass = result.readPointer();
    }
    return result;
}

// ═══════════════════════════════════════════════════
// Bootstrap (same as v3)
// ═══════════════════════════════════════════════════
function findParentClassByName(klass, targetName) {
    var cur = klass;
    for (var i = 0; i < 15 && !cur.isNull(); i++) {
        var name = readCStr(cur.add(0x58).readPointer());
        if (name === targetName) return cur;
        try { cur = cur.add(0xA8).readPointer(); } catch (e) { break; }
    }
    return null;
}

function bootstrapFromComponent(comp) {
    // Resolve core methods dynamically from klass hierarchy (no hardcoded RVAs)
    var klass = comp.readPointer();
    if (klass.isNull()) return { error: 'comp klass is null' };

    var componentKlass = findParentClassByName(klass, 'Component');
    if (!componentKlass) return { error: 'Component not found in parent chain' };

    var getTransformCode = findMethodByName(componentKlass, 'get_transform');
    var getGameObjectCode = findMethodByName(componentKlass, 'get_gameObject');
    if (!getTransformCode || !getGameObjectCode)
        return { error: 'Failed to resolve Component.get_transform/get_gameObject' };

    fn.getTransform  = new NativeFunction(getTransformCode, 'pointer', ['pointer']);
    fn.getGameObject = new NativeFunction(getGameObjectCode, 'pointer', ['pointer']);

    var objectKlass = findParentClassByName(klass, 'Object');
    if (objectKlass) {
        var getNameCode = findMethodByName(objectKlass, 'get_name');
        if (getNameCode) fn.getName = new NativeFunction(getNameCode, 'pointer', ['pointer']);
    }

    var transform = fn.getTransform(comp);
    if (transform.isNull()) return { error: 'getTransform returned null' };

    var tKlass = transform.readPointer();
    var tMethods = {
        getChildCount: findMethodByName(tKlass, 'get_childCount'),
        getChild:      findMethodByName(tKlass, 'GetChild'),
        getRoot:       findMethodByName(tKlass, 'get_root'),
        getParent:     findMethodByName(tKlass, 'get_parent'),
    };

    if (!tMethods.getChildCount || !tMethods.getChild)
        return { error: 'Failed to resolve Transform methods' };

    fn.getChildCount = new NativeFunction(tMethods.getChildCount, 'int', ['pointer']);
    fn.getChild      = new NativeFunction(tMethods.getChild, 'pointer', ['pointer', 'int']);
    fn.getRoot       = tMethods.getRoot ? new NativeFunction(tMethods.getRoot, 'pointer', ['pointer']) : null;
    fn.getParent     = tMethods.getParent ? new NativeFunction(tMethods.getParent, 'pointer', ['pointer']) : null;

    var go = fn.getGameObject(comp);
    if (go.isNull()) return { error: 'getGameObject returned null' };

    var goKlass = go.readPointer();
    var goMethods = {
        getCompCount: findMethodByName(goKlass, 'GetComponentCount'),
        queryCompAt:  findMethodByName(goKlass, 'QueryComponentAtIndex'),
    };

    if (!goMethods.getCompCount || !goMethods.queryCompAt)
        return { error: 'Failed to resolve GameObject methods' };

    fn.getCompCount = new NativeFunction(goMethods.getCompCount, 'int', ['pointer']);
    fn.queryCompAt  = new NativeFunction(goMethods.queryCompAt, 'pointer', ['pointer', 'int']);

    bootstrapped = true;
    return { ok: true, transform_klass: tKlass.toString(), go_klass: goKlass.toString() };
}

// ═══════════════════════════════════════════════════
// Scene scanning (same as v3)
// ═══════════════════════════════════════════════════
function getGoName(goPtr) {
    if (!fn.getName) return null;
    try { var s = fn.getName(goPtr); return readIl2CppString(s); }
    catch (e) { return null; }
}

function getHierarchyPath(transform) {
    var parts = [];
    try {
        var cur = transform; var depth = 0;
        while (!cur.isNull() && depth < 30) {
            var go = fn.getGameObject(cur);
            if (go.isNull()) break;
            parts.unshift(getGoName(go) || '?');
            if (!fn.getParent) break;
            var parent = fn.getParent(cur);
            if (parent.isNull() || parent.equals(cur)) break;
            cur = parent; depth++;
        }
    } catch (e) {}
    return parts.join('/');
}

function scanGameObject(goPtr, depth, rootName) {
    if (goPtr.isNull()) return;
    var goKey = goPtr.toString();
    if (visitedGOs[goKey]) return;
    visitedGOs[goKey] = true;
    if (depth > 30) return;

    var goName = getGoName(goPtr);

    try {
        var compCount = fn.getCompCount(goPtr);
        for (var i = 0; i < compCount && i < 200; i++) {
            try {
                var comp = fn.queryCompAt(goPtr, i);
                if (comp.isNull()) continue;
                var klass = comp.readPointer();
                if (klass.isNull()) continue;
                var info = readKlassInfo(klass);
                if (!info) continue;

                var hierPath = '';
                if (depth <= 5) {
                    try { var tf = fn.getTransform(comp); if (!tf.isNull()) hierPath = getHierarchyPath(tf); }
                    catch (e) {}
                }

                allComponents.push({
                    klassPtr: klass.toString(),
                    compPtr: comp.toString(),
                    gameObject: goName,
                    compIndex: i,
                    depth: depth,
                    name: info.name,
                    ns: info.ns,
                    mc: info.method_count,
                    fc: info.field_count,
                    parent: info.parent,
                    rootSource: rootName || 'world',
                    hierPath: hierPath,
                });
            } catch (e) {}
        }
    } catch (e) {}

    try {
        var transform = fn.getTransform(goPtr);
        if (transform.isNull()) return;
        if (depth === 0 && fn.getRoot) {
            var root = fn.getRoot(transform);
            if (!root.isNull() && root.toString() !== transform.toString()) {
                var rootGO = fn.getGameObject(root);
                scanGameObject(rootGO, 0, rootName);
                return;
            }
        }
        var childCount = fn.getChildCount(transform);
        for (var c = 0; c < childCount && c < 500; c++) {
            try {
                var childT = fn.getChild(transform, c);
                if (!childT.isNull()) {
                    var childGO = fn.getGameObject(childT);
                    scanGameObject(childGO, depth + 1, rootName);
                }
            } catch (e) {}
        }
    } catch (e) {}
}

// ═══════════════════════════════════════════════════
// World loading via string field scanning
// ═══════════════════════════════════════════════════

/**
 * Scan FlowManager's instance fields for Il2CppString* containing wrld_ IDs.
 * Returns field offsets and their current values.
 */
function scanForWorldStrings() {
    if (!flowManagerPtr) return { error: 'No FlowManager' };
    var results = [];
    // Scan the first 0x300 bytes of instance data for pointers
    for (var off = 0x10; off < 0x300; off += 0x8) {
        try {
            var p = flowManagerPtr.add(off).readPointer();
            if (p.isNull()) continue;
            // Check if it looks like an Il2CppString (valid length field)
            var len = p.add(0x10).readInt();
            if (len < 5 || len > 200) continue;
            var str = p.add(0x14).readUtf16String(len);
            if (str && (str.indexOf('wrld_') === 0 || str.indexOf('local:') === 0)) {
                results.push({
                    offset: off,
                    offsetHex: '0x' + off.toString(16),
                    stringPtr: p.toString(),
                    value: str,
                    length: len,
                });
            }
        } catch (e) {}
    }
    return results;
}

/**
 * Overwrite a world ID string in FlowManager instance memory.
 * offset: byte offset within FlowManager instance
 * newWorldId: the new wrld_xxx string
 */
function overwriteWorldString(offset, newWorldId) {
    if (!flowManagerPtr) return { error: 'No FlowManager' };
    try {
        var p = flowManagerPtr.add(offset).readPointer();
        if (p.isNull()) return { error: 'Null string pointer at offset ' + offset };
        var oldLen = p.add(0x10).readInt();
        var oldStr = p.add(0x14).readUtf16String(oldLen);
        if (newWorldId.length > oldLen) {
            return { error: 'New string (' + newWorldId.length + ') longer than old (' + oldLen + '). Cannot overwrite in-place.' };
        }
        var ok = writeIl2CppString(p, newWorldId);
        if (ok) {
            return { ok: true, old: oldStr, new: newWorldId, offset: offset };
        } else {
            return { error: 'writeIl2CppString failed' };
        }
    } catch (e) {
        return { error: 'Exception: ' + e };
    }
}

/**
 * Trigger GoHome by calling the coroutine via vtable.
 * This schedules the world load flow.
 * Must be called from the main Unity thread (via error-state-setter hook).
 */
function triggerGoHome() {
    if (!flowManagerPtr || !flowManagerKlass) return { error: 'No FlowManager' };

    var goHomeAddr = flowManagerKlass.add(0x298).readPointer();
    var goHomeMI = flowManagerKlass.add(0x2A0).readPointer();
    var goHomeRVA = goHomeAddr.sub(GA).toNumber();

    // Verify it's in GA range
    if (goHomeRVA < 0 || goHomeRVA > 0x10000000) {
        return { error: 'GoHome address looks invalid: RVA 0x' + goHomeRVA.toString(16) };
    }

    // We need to call GoHome on the main thread.
    // Use the error-state-setter hook (called ~140/sec) to piggyback.
    var triggered = false;
    var result = null;

    var hook = Interceptor.attach(GA.add(RVA.error_state_setter), {
        onEnter: function() {
            if (triggered) return;
            triggered = true;
            try {
                var goHome = new NativeFunction(goHomeAddr, 'pointer', ['pointer', 'int', 'pointer']);
                var coroutine = goHome(flowManagerPtr, 0x1400, goHomeMI);

                if (!coroutine.isNull()) {
                    // Try to start the coroutine via StartCoroutineManaged2
                    // Look it up from the cached pointer
                    try {
                        var cachedAddr = GA.add(0xC5E1100).readPointer();
                        if (!cachedAddr.isNull()) {
                            var startCoro = new NativeFunction(cachedAddr, 'pointer', ['pointer', 'pointer']);
                            var handle = startCoro(flowManagerPtr, coroutine);
                            result = { ok: true, coroutine: coroutine.toString(), handle: handle.toString() };
                        } else {
                            result = { ok: false, note: 'StartCoroutineManaged2 not cached', coroutine: coroutine.toString() };
                        }
                    } catch (e) {
                        result = { ok: false, note: 'StartCoroutine failed: ' + e, coroutine: coroutine.toString() };
                    }
                } else {
                    result = { ok: false, note: 'GoHome returned null coroutine' };
                }
            } catch (e) {
                result = { error: 'GoHome call failed: ' + e };
            }
        }
    });

    // Wait for main thread to execute
    var start = Date.now();
    while (!triggered && (Date.now() - start) < 5000) {
        Thread.sleep(0.05);
    }
    hook.detach();

    if (!triggered) return { error: 'Main thread hook timeout (5s)' };
    return result || { error: 'No result from GoHome call' };
}

/**
 * Wait for world load completion by monitoring component count changes.
 * Polls every second, returns when component count stabilizes.
 */
function waitForWorldLoad(timeoutMs) {
    if (!bootstrapped) return { error: 'Not bootstrapped' };
    if (!timeoutMs) timeoutMs = 30000;

    var lastCount = Object.keys(visitedGOs).length;
    var stableFrames = 0;
    var start = Date.now();

    while ((Date.now() - start) < timeoutMs) {
        Thread.sleep(1.0);
        // Quick re-scan to count GOs
        var testVisited = {};
        try {
            var transform = fn.getTransform(flowManagerPtr);
            if (!transform.isNull()) {
                var root = fn.getRoot ? fn.getRoot(transform) : transform;
                if (!root.isNull()) {
                    var rootGO = fn.getGameObject(root);
                    // Just count children of root as a proxy
                    var childCount = fn.getChildCount(root);
                    if (childCount === lastCount) {
                        stableFrames++;
                        if (stableFrames >= 3) {
                            return { ok: true, elapsed: Date.now() - start, childCount: childCount };
                        }
                    } else {
                        lastCount = childCount;
                        stableFrames = 0;
                    }
                }
            }
        } catch (e) {}
    }

    return { ok: false, note: 'Timeout waiting for world load', elapsed: timeoutMs };
}

// ═══════════════════════════════════════════════════
// RPC Exports
// ═══════════════════════════════════════════════════
rpc.exports = {
    getInfo: function() {
        return { ga_base: GA.toString() };
    },

    findFlowManager: function(timeoutMs) {
        var fm = findFlowManager(timeoutMs || 15000);
        if (!fm) return { error: 'FlowManager not found' };
        return {
            ok: true,
            ptr: fm.toString(),
            klass: flowManagerKlass.toString(),
            name: readCStr(flowManagerKlass.add(0x58).readPointer()),
        };
    },

    bootstrap: function() {
        if (!flowManagerPtr) return { error: 'Find FlowManager first' };
        return bootstrapFromComponent(flowManagerPtr);
    },

    scanWorldStrings: function() {
        return scanForWorldStrings();
    },

    overwriteWorldId: function(offset, newId) {
        return overwriteWorldString(offset, newId);
    },

    triggerGoHome: function() {
        return triggerGoHome();
    },

    waitForLoad: function(timeoutMs) {
        return waitForWorldLoad(timeoutMs);
    },

    scanCurrentWorld: function() {
        if (!bootstrapped) return { error: 'Not bootstrapped' };
        visitedGOs = {};
        allComponents = [];

        var transform = fn.getTransform(flowManagerPtr);
        if (transform.isNull()) return { error: 'Entry transform null' };
        var root = fn.getRoot ? fn.getRoot(transform) : transform;
        if (!root.isNull()) {
            var rootGO = fn.getGameObject(root);
            scanGameObject(rootGO, 0, 'world');
        }

        // Also scan singletons
        var seenKlasses = {};
        for (var i = 0; i < allComponents.length; i++) {
            var ks = allComponents[i].klassPtr;
            if (seenKlasses[ks]) continue;
            seenKlasses[ks] = true;
            try {
                var klass = ptr(ks);
                var sf = klass.add(0xB8).readPointer();
                if (sf.isNull()) continue;
                for (var off = 0; off <= 0x38; off += 0x8) {
                    try {
                        var cand = sf.add(off).readPointer();
                        if (cand.isNull()) continue;
                        if (cand.readPointer().equals(klass)) {
                            var tf = fn.getTransform(cand);
                            if (!tf.isNull()) {
                                var r = fn.getRoot ? fn.getRoot(tf) : tf;
                                var rgo = fn.getGameObject(r);
                                scanGameObject(rgo, 0, 'singleton');
                            }
                            break;
                        }
                    } catch(e) {}
                }
            } catch(e) {}
        }

        return {
            gos_visited: Object.keys(visitedGOs).length,
            components_found: allComponents.length,
            components: allComponents,
        };
    },

    getMethodNames: function(klassPtrStr) {
        var names = [];
        try {
            var klass = ptr(klassPtrStr);
            var methodArr = klass.add(0x78).readPointer();
            if (methodArr.isNull()) return names;
            var mc = klass.add(0x120).readU16();
            for (var i = 0; i < Math.min(mc, 200); i++) {
                var mi = methodArr.add(i * 8).readPointer();
                if (mi.isNull()) break;
                var name = readCStr(mi.add(0x18).readPointer());
                if (name) names.push(name);
            }
        } catch(e) {}
        return names;
    },
};
"""


# ════════════════════════════════════════════════════════════
# Part 3: Python Orchestrator
# ════════════════════════════════════════════════════════════

def cmd_list_cache():
    """List cached worlds from disk."""
    print("\n[Cache] Scanning cached asset bundles...")
    entries = list_cached_worlds()
    if not entries:
        print("  No cache entries found.")
        return

    # Cross-reference with logs
    worlds = parse_logs_for_worlds()

    print(f"\n  Cache entries: {len(entries)}")
    print(f"  Known world IDs from logs: {len(worlds)}")
    print(f"\n  {'Date':17s} {'Size':>8s}  {'Cache Key':20s}")
    print(f"  {'-'*17} {'-'*8}  {'-'*20}")
    for e in entries[:30]:
        print(f"  {e['date']:17s} {e['size_mb']:7.1f}M  {e['cache_key']}")

    if worlds:
        print(f"\n  --- World IDs from logs ---")
        for wid, info in sorted(worlds.items(), key=lambda x: x[1].get('last_seen', ''), reverse=True)[:20]:
            room = info.get('room_name', '') or ''
            visits = info.get('visits', 0)
            print(f"  {wid}  visits={visits}  {room}")


def cmd_list_logs():
    """List worlds from log files."""
    print("\n[Logs] Parsing VRChat logs for world IDs...")
    worlds = parse_logs_for_worlds()
    if not worlds:
        print("  No worlds found in logs.")
        return

    print(f"\n  Found {len(worlds)} unique world IDs:")
    print(f"\n  {'World ID':50s}  {'Last Seen':20s}  {'Visits':>6s}  {'Room Name'}")
    print(f"  {'-'*50}  {'-'*20}  {'-'*6}  {'-'*20}")
    for wid, info in sorted(worlds.items(), key=lambda x: x[1].get('last_seen', ''), reverse=True):
        room = info.get('room_name', '') or '?'
        print(f"  {wid}  {info['last_seen']:20s}  {info['visits']:6d}  {room}")


def cmd_scan_world(world_id=None, timeout=15):
    """Scan current (or redirected) world for components."""
    import frida

    print("\n[Frida] Attaching to VRChat...")
    try:
        session = frida.attach("VRChat.exe")
    except Exception as e:
        print(f"  ERROR: {e}")
        print("  Launch VRChat with: start \"\" \"VRChat.exe\" --no-vr")
        sys.exit(1)

    script = session.create_script(WORLD_LOADER_JS)
    script.load()
    api = script.exports_sync

    info = api.get_info()
    print(f"  GA base: {info['ga_base']}")

    # Find FlowManager
    print(f"\n[Frida] Finding FlowManager (up to {timeout}s)...")
    fm = api.find_flow_manager(timeout * 1000)
    if 'error' in fm:
        print(f"  ERROR: {fm['error']}")
        session.detach()
        sys.exit(1)
    print(f"  FlowManager: {fm['ptr']} ({fm.get('name', '?')})")

    # Bootstrap
    print("\n[Frida] Bootstrapping Unity methods...")
    boot = api.bootstrap()
    if 'error' in boot:
        print(f"  ERROR: {boot['error']}")
        session.detach()
        sys.exit(1)
    print(f"  OK: Transform={boot['transform_klass']}, GO={boot['go_klass']}")

    # If a target world was specified, try to redirect
    if world_id:
        print(f"\n[Frida] Attempting to redirect to: {world_id}")

        # Step 1: Find world string fields
        world_strings = api.scan_world_strings()
        if isinstance(world_strings, dict) and 'error' in world_strings:
            print(f"  ERROR: {world_strings['error']}")
        elif isinstance(world_strings, list) and world_strings:
            print(f"  Found {len(world_strings)} world string fields:")
            for ws in world_strings:
                print(f"    +{ws['offsetHex']}: \"{ws['value']}\" (len={ws['length']})")

            # Try to overwrite the first wrld_ field
            target_field = None
            for ws in world_strings:
                if ws['value'].startswith('wrld_'):
                    target_field = ws
                    break
            if not target_field:
                # Use any field
                target_field = world_strings[0]

            print(f"\n  Overwriting field at +{target_field['offsetHex']}...")
            result = api.overwrite_world_id(target_field['offset'], world_id)
            if isinstance(result, dict) and result.get('ok'):
                print(f"  OK: \"{result['old']}\" -> \"{result['new']}\"")
            else:
                print(f"  Overwrite result: {result}")
                print("  WARNING: String overwrite may have failed. Trying GoHome anyway.")
        else:
            print("  No world string fields found in FlowManager instance.")
            print("  Will try GoHome without redirect (loads default home world).")

        # Step 2: Trigger GoHome
        print("\n[Frida] Triggering GoHome on main thread...")
        gh_result = api.trigger_go_home()
        if isinstance(gh_result, dict) and gh_result.get('ok'):
            print(f"  GoHome started: coroutine={gh_result.get('coroutine', '?')}")
        else:
            print(f"  GoHome result: {gh_result}")
            print("  WARNING: GoHome may have failed. Scanning current scene anyway.")

        # Step 3: Wait for world load
        print("\n[Frida] Waiting for world to load (up to 30s)...")
        wait = api.wait_for_load(30000)
        if isinstance(wait, dict) and wait.get('ok'):
            elapsed = wait.get('elapsed', 0)
            print(f"  World loaded in {elapsed}ms")
        else:
            print(f"  Wait result: {wait}")
            print("  Continuing with scan anyway.")

    # Scan the current world
    print("\n[Frida] Scanning scene tree...")
    scan = api.scan_current_world()
    if 'error' in scan:
        print(f"  ERROR: {scan['error']}")
        session.detach()
        sys.exit(1)

    print(f"  GameObjects: {scan['gos_visited']}")
    print(f"  Components: {scan['components_found']}")

    # Group by klass
    by_klass = defaultdict(list)
    for comp in scan['components']:
        by_klass[comp['klassPtr']].append(comp)

    OBF_RE_LOCAL = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

    obfuscated = 0
    named = 0
    complex_comps = 0
    for klass_ptr, comps in by_klass.items():
        name = comps[0]['name']
        if OBF_RE_LOCAL.match(name):
            obfuscated += 1
        elif 'ComplexComponent' in name:
            complex_comps += 1
        else:
            named += 1

    print(f"\n  Unique classes: {len(by_klass)}")
    print(f"  Named: {named}")
    print(f"  Obfuscated: {obfuscated}")
    print(f"  ComplexComponent: {complex_comps}")

    # Save results
    output = {
        'generated_by': 'load_cached_worlds.py',
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'world_id': world_id or '(current)',
        'ga_base': info['ga_base'],
        'stats': {
            'gos_visited': scan['gos_visited'],
            'total_components': scan['components_found'],
            'unique_classes': len(by_klass),
            'named': named,
            'obfuscated': obfuscated,
            'complex_components': complex_comps,
        },
        'components': [
            {
                'name': comps[0]['name'],
                'ns': comps[0]['ns'],
                'mc': comps[0]['mc'],
                'fc': comps[0]['fc'],
                'parent': comps[0].get('parent', ''),
                'instances': len(comps),
                'gameObjects': list(set(c['gameObject'] for c in comps if c.get('gameObject')))[:5],
                'hierPaths': list(set(c.get('hierPath', '') for c in comps if c.get('hierPath')))[:3],
            }
            for klass_ptr, comps in sorted(by_klass.items())
        ],
    }

    with open(OUTPUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(output, f, ensure_ascii=False, indent=2)
    print(f"\n  Saved to {OUTPUT_PATH.name}")

    session.detach()
    return output


def main():
    parser = argparse.ArgumentParser(description='VRChat Cached World Loader + Scanner')
    parser.add_argument('--list', action='store_true', help='List cached worlds')
    parser.add_argument('--list-logs', action='store_true', help='List world IDs from logs')
    parser.add_argument('--scan', action='store_true', help='Scan current world (no reload)')
    parser.add_argument('--world', type=str, help='Target world ID (wrld_xxx) to load')
    parser.add_argument('--timeout', type=int, default=15, help='FlowManager wait timeout')
    args = parser.parse_args()

    print("=" * 60)
    print("  VRChat Cached World Loader + Component Scanner")
    print("=" * 60)

    if args.list:
        cmd_list_cache()
    elif args.list_logs:
        cmd_list_logs()
    elif args.scan or args.world:
        cmd_scan_world(world_id=args.world, timeout=args.timeout)
    else:
        # Default: show help
        print("\nModes:")
        print("  --list       List cached asset bundles")
        print("  --list-logs  List world IDs from VRChat logs")
        print("  --scan       Scan current world scene (VRChat must be running)")
        print("  --world ID   Load a specific world and scan it")
        print("\nExamples:")
        print("  python tools/load_cached_worlds.py --list")
        print("  python tools/load_cached_worlds.py --list-logs")
        print("  python tools/load_cached_worlds.py --scan")
        print("  python tools/load_cached_worlds.py --world wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd")


if __name__ == '__main__':
    main()
