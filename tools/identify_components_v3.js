'use strict';
/**
 * identify_components_v3.js — Session-independent scene traversal component identifier
 *
 * No hardcoded klass VAs. Uses:
 *   - Method RVAs (stable across sessions) for core Unity calls
 *   - Error-state-setter hook to find FlowManager as entry point
 *   - Runtime klass struct reading for fingerprint matching
 *   - Multi-root discovery: DontDestroyOnLoad, singletons, Canvas roots
 *
 * Beebyte IL2CPP struct offsets:
 *   Il2CppClass: +0x18=namespace, +0x58=name, +0x78=MethodInfo**,
 *                +0xA0=FieldInfo*, +0xA8=parent(Il2CppClass*),
 *                +0xB8=static_fields, +0x120=method_count(u16), +0x124=field_count(u16)
 *   MethodInfo:  +0x00=code_ptr, +0x18=name(char*), +0x28=param_count(u8)
 *   Il2CppString: +0x10=length(i32), +0x14=chars(UTF-16)
 */

var _gaMod = Process.findModuleByName('GameAssembly.dll');
if (!_gaMod) throw new Error('GameAssembly.dll not found');
var GA = _gaMod.base;

// ---- error_state_setter RVA (only hook we hardcode) ----
var RVA = {
    error_state_setter: 0x1943BC0, // called ~140/sec, arg0+0x20 = FlowManager
};

// ---- Core NativeFunctions (resolved dynamically from live klass in bootstrap) ----
var fn = {
    getTransform:  null,  // resolved from Component klass
    getGameObject: null,  // resolved from Component klass
    getName:       null,  // resolved from Object klass
    // These get filled in after bootstrap:
    getChildCount: null,
    getChild:      null,
    getRoot:       null,
    getParent:     null,
    getCompCount:  null,
    queryCompAt:   null,
    // Scene enumeration (filled by bootstrapSceneMethods):
    getSceneCount: null,
    getSceneAt:    null,
    getSceneRootCount: null,
    getSceneRootObjects: null,
};

// ---- Helpers ----

function readCStr(p) {
    if (p.isNull()) return null;
    try {
        var s = p.readUtf8String();
        return (s && s.length < 500) ? s : null;
    } catch (e) { return null; }
}

function readIl2CppString(p) {
    if (p.isNull()) return null;
    try {
        var len = p.add(0x10).readInt();
        if (len > 0 && len < 2000) return p.add(0x14).readUtf16String(len);
    } catch (e) {}
    return null;
}

function findMethodByName(klass, methodName) {
    try {
        var methodArr = klass.add(0x78).readPointer();
        if (methodArr.isNull()) return null;
        var mc = klass.add(0x120).readU16();
        var limit = Math.min(mc, 200);
        for (var i = 0; i < limit; i++) {
            var mi = methodArr.add(i * 8).readPointer();
            if (mi.isNull()) return null;
            var name = readCStr(mi.add(0x18).readPointer());
            if (name === methodName) return mi.readPointer();
        }
    } catch (e) {}
    return null;
}

function getMethodNames(klass) {
    var names = [];
    try {
        var methodArr = klass.add(0x78).readPointer();
        if (methodArr.isNull()) return names;
        var mc = klass.add(0x120).readU16();
        var limit = Math.min(mc, 200);
        for (var i = 0; i < limit; i++) {
            var mi = methodArr.add(i * 8).readPointer();
            if (mi.isNull()) break;
            var name = readCStr(mi.add(0x18).readPointer());
            if (name) names.push(name);
        }
    } catch (e) {}
    return names;
}

/**
 * Get method parameter counts for a klass.
 * Returns [{name, paramCount}, ...]
 */
function getMethodSignatures(klass) {
    var sigs = [];
    try {
        var methodArr = klass.add(0x78).readPointer();
        if (methodArr.isNull()) return sigs;
        var mc = klass.add(0x120).readU16();
        var limit = Math.min(mc, 200);
        for (var i = 0; i < limit; i++) {
            var mi = methodArr.add(i * 8).readPointer();
            if (mi.isNull()) break;
            var name = readCStr(mi.add(0x18).readPointer());
            var paramCount = 0;
            try { paramCount = mi.add(0x28).readU8(); } catch (e) {}
            if (name) sigs.push({ name: name, params: paramCount });
        }
    } catch (e) {}
    return sigs;
}

/**
 * Read parent class name from Il2CppClass.
 * Il2CppClass+0xA8 = parent Il2CppClass*
 */
function readParentClassName(klass) {
    try {
        var parent = klass.add(0xA8).readPointer();
        if (parent.isNull()) return null;
        return readCStr(parent.add(0x58).readPointer());
    } catch (e) { return null; }
}

/**
 * Walk the full parent chain.
 */
function readParentChain(klass) {
    var chain = [];
    try {
        var cur = klass.add(0xA8).readPointer();
        var depth = 0;
        while (!cur.isNull() && depth < 20) {
            var name = readCStr(cur.add(0x58).readPointer());
            if (!name) break;
            chain.push(name);
            cur = cur.add(0xA8).readPointer();
            depth++;
        }
    } catch (e) {}
    return chain;
}

function readKlassInfo(klass) {
    try {
        return {
            name: readCStr(klass.add(0x58).readPointer()) || '?',
            ns: readCStr(klass.add(0x18).readPointer()) || '',
            method_count: klass.add(0x120).readU16(),
            field_count: klass.add(0x124).readU16(),
            parent: readParentClassName(klass),
        };
    } catch (e) {
        return null;
    }
}

// ---- Bootstrap: resolve Transform/GameObject methods from live instance ----

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
    // comp is any Component instance (e.g. FlowManager)
    // Step 0: Resolve core methods from live klass hierarchy (no hardcoded RVAs)
    var klass = comp.readPointer();
    if (klass.isNull()) return { error: 'comp klass is null' };

    var componentKlass = findParentClassByName(klass, 'Component');
    if (!componentKlass) return { error: 'Component not found in parent chain' };

    var getTransformCode = findMethodByName(componentKlass, 'get_transform');
    var getGameObjectCode = findMethodByName(componentKlass, 'get_gameObject');
    if (!getTransformCode || !getGameObjectCode) {
        return { error: 'Failed to resolve Component.get_transform/get_gameObject' };
    }
    fn.getTransform  = new NativeFunction(getTransformCode, 'pointer', ['pointer']);
    fn.getGameObject = new NativeFunction(getGameObjectCode, 'pointer', ['pointer']);

    // Resolve Object.get_name from UnityEngine.Object parent
    var objectKlass = findParentClassByName(klass, 'Object');
    if (objectKlass) {
        var getNameCode = findMethodByName(objectKlass, 'get_name');
        if (getNameCode) fn.getName = new NativeFunction(getNameCode, 'pointer', ['pointer']);
    }

    // Step 1: get Transform and resolve its methods
    var transform = fn.getTransform(comp);
    if (transform.isNull()) return { error: 'getTransform returned null' };

    var tKlass = transform.readPointer();
    var tMethods = {
        getChildCount: findMethodByName(tKlass, 'get_childCount'),
        getChild:      findMethodByName(tKlass, 'GetChild'),
        getRoot:       findMethodByName(tKlass, 'get_root'),
        getParent:     findMethodByName(tKlass, 'get_parent'),
    };

    if (!tMethods.getChildCount || !tMethods.getChild) {
        return { error: 'Failed to resolve Transform methods' };
    }

    fn.getChildCount = new NativeFunction(tMethods.getChildCount, 'int', ['pointer']);
    fn.getChild      = new NativeFunction(tMethods.getChild, 'pointer', ['pointer', 'int']);
    fn.getRoot       = tMethods.getRoot ? new NativeFunction(tMethods.getRoot, 'pointer', ['pointer']) : null;
    fn.getParent     = tMethods.getParent ? new NativeFunction(tMethods.getParent, 'pointer', ['pointer']) : null;

    // Step 2: Resolve GameObject methods
    var go = fn.getGameObject(comp);
    if (go.isNull()) return { error: 'getGameObject returned null' };

    var goKlass = go.readPointer();
    var goMethods = {
        getCompCount: findMethodByName(goKlass, 'GetComponentCount'),
        queryCompAt:  findMethodByName(goKlass, 'QueryComponentAtIndex'),
    };

    if (!goMethods.getCompCount || !goMethods.queryCompAt) {
        return { error: 'Failed to resolve GameObject methods' };
    }

    fn.getCompCount = new NativeFunction(goMethods.getCompCount, 'int', ['pointer']);
    fn.queryCompAt  = new NativeFunction(goMethods.queryCompAt, 'pointer', ['pointer', 'int']);

    return {
        ok: true,
        transform_klass: tKlass.toString(),
        go_klass: goKlass.toString(),
    };
}

// ---- Scene Traversal ----

var visitedGOs = {};
var allComponents = [];  // Every component found

function getGoName(goPtr) {
    if (!fn.getName) return null;
    try {
        var nameStr = fn.getName(goPtr);
        return readIl2CppString(nameStr);
    } catch (e) { return null; }
}

/**
 * Build the hierarchy path from a transform up to the root.
 */
function getHierarchyPath(transform) {
    var parts = [];
    try {
        var cur = transform;
        var depth = 0;
        while (!cur.isNull() && depth < 30) {
            var go = fn.getGameObject(cur);
            if (go.isNull()) break;
            var name = getGoName(go);
            parts.unshift(name || '?');
            if (!fn.getParent) break;
            var parent = fn.getParent(cur);
            if (parent.isNull() || parent.equals(cur)) break;
            cur = parent;
            depth++;
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

    // Enumerate all components on this GO
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

                // Get hierarchy path for first instance only (expensive)
                var hierPath = '';
                if (depth <= 5) {
                    try {
                        var tf = fn.getTransform(comp);
                        if (!tf.isNull()) hierPath = getHierarchyPath(tf);
                    } catch (e) {}
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
                    rootSource: rootName || 'FlowManager',
                    hierPath: hierPath,
                });
            } catch (e) {}
        }
    } catch (e) {}

    // Recurse children
    try {
        var transform = fn.getTransform(goPtr);
        if (transform.isNull()) return;

        // Try to go to root first (only at depth 0)
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

// ---- Multi-root scene traversal ----

function findAllSceneRoots(entryTransform) {
    var roots = [];
    var root = fn.getRoot ? fn.getRoot(entryTransform) : entryTransform;
    if (!root.isNull()) {
        roots.push(root);
    }
    return roots;
}

/**
 * Scan DontDestroyOnLoad objects.
 * In Unity, DontDestroyOnLoad objects live in a separate scene.
 * We find them by walking the root transform's parent chain —
 * if a root GO's scene handle differs, it's in DontDestroyOnLoad.
 *
 * Alternative strategy: scan for known singleton klass pointers via
 * static fields (Il2CppClass+0xB8 → static_fields → instance pointers).
 */
function findDontDestroyOnLoadRoots() {
    var ddolRoots = [];
    // Already-found components may include DontDestroyOnLoad objects.
    // We look for GOs whose root transform differs from FlowManager's root.
    // This is handled by scanning singleton static fields instead.
    return ddolRoots;
}

/**
 * Scan singletons via Il2CppClass static fields.
 * For each klass pointer we've seen, check if it has static fields
 * containing self-references (singleton pattern).
 * Returns component pointers that can be used as additional entry points.
 */
function findSingletonEntryPoints() {
    var singletons = [];
    var seenKlasses = {};

    for (var i = 0; i < allComponents.length; i++) {
        var klassStr = allComponents[i].klassPtr;
        if (seenKlasses[klassStr]) continue;
        seenKlasses[klassStr] = true;

        try {
            var klass = ptr(klassStr);
            var staticFields = klass.add(0xB8).readPointer();
            if (staticFields.isNull()) continue;

            // Scan first 8 static field slots for pointers whose klass matches
            for (var off = 0; off <= 0x38; off += 0x8) {
                try {
                    var candidate = staticFields.add(off).readPointer();
                    if (candidate.isNull()) continue;
                    var candKlass = candidate.readPointer();
                    if (candKlass.equals(klass)) {
                        // This is a singleton instance — use it as entry point
                        singletons.push({
                            ptr: candidate.toString(),
                            klass: klassStr,
                            name: allComponents[i].name,
                        });
                        break; // one per klass
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }
    return singletons;
}

/**
 * Find additional roots by scanning for MonoBehaviour-derived objects
 * through GC heap scanning of known klass pointers.
 * This targets objects NOT in the FlowManager scene tree (e.g. DontDestroyOnLoad).
 */
function scanSingletonTrees(singletons) {
    var newRoots = 0;
    var prevGOCount = Object.keys(visitedGOs).length;

    for (var i = 0; i < singletons.length; i++) {
        try {
            var comp = ptr(singletons[i].ptr);
            var transform = fn.getTransform(comp);
            if (transform.isNull()) continue;

            var root = fn.getRoot ? fn.getRoot(transform) : transform;
            if (root.isNull()) continue;

            var rootGO = fn.getGameObject(root);
            if (rootGO.isNull()) continue;

            var goKey = rootGO.toString();
            if (!visitedGOs[goKey]) {
                newRoots++;
                scanGameObject(rootGO, 0, 'singleton:' + singletons[i].name);
            }
        } catch (e) {}
    }
    return {
        singletonsChecked: singletons.length,
        newRoots: newRoots,
        newGOs: Object.keys(visitedGOs).length - prevGOCount,
    };
}

/**
 * Heap scan for MonoBehaviour-derived klass pointers.
 * Scans GA's .data section and nearby heap for Il2CppClass* that have
 * MonoBehaviour in their parent chain. Then reads their static_fields
 * for singleton instances.
 *
 * targetKlassPtrs: array of klass pointer strings to specifically look for
 */
function heapScanForSingletons(targetKlassPtrs) {
    var results = [];
    if (!targetKlassPtrs || targetKlassPtrs.length === 0) return results;

    var targetSet = {};
    for (var i = 0; i < targetKlassPtrs.length; i++) {
        targetSet[targetKlassPtrs[i]] = true;
    }

    // For each target klass, try reading static fields for singleton instances
    for (var i = 0; i < targetKlassPtrs.length; i++) {
        try {
            var klass = ptr(targetKlassPtrs[i]);
            var staticFields = klass.add(0xB8).readPointer();
            if (staticFields.isNull()) continue;

            for (var off = 0; off <= 0x38; off += 0x8) {
                try {
                    var candidate = staticFields.add(off).readPointer();
                    if (candidate.isNull()) continue;
                    var candKlass = candidate.readPointer();
                    if (candKlass.equals(klass)) {
                        results.push({
                            ptr: candidate.toString(),
                            klass: targetKlassPtrs[i],
                        });
                        break;
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }

    return results;
}

// ---- RPC Exports ----

var bootstrapped = false;
var entryComponent = null;

rpc.exports = {
    /**
     * Get GA base info
     */
    getInfo: function () {
        return {
            ga_base: GA.toString(),
            error_state_rva: '0x' + RVA.error_state_setter.toString(16),
        };
    },

    /**
     * Hook error-state-setter and wait for FlowManager.
     * Returns when FlowManager is found (with timeout).
     */
    hookAndWait: function (timeoutMs) {
        if (!timeoutMs) timeoutMs = 10000;

        var found = false;
        var flowManager = null;

        var hook = Interceptor.attach(GA.add(RVA.error_state_setter), {
            onEnter: function (args) {
                if (found) return;
                try {
                    var obj = args[0];
                    if (obj.isNull()) return;
                    var fm = obj.add(0x20).readPointer();
                    if (fm.isNull()) return;
                    // Validate: read klass, check it has methods
                    var klass = fm.readPointer();
                    if (klass.isNull()) return;
                    var mc = klass.add(0x120).readU16();
                    if (mc > 10) { // FlowManager should have many methods
                        flowManager = fm;
                        found = true;
                    }
                } catch (e) {}
            }
        });

        // Busy-wait (in Frida RPC, this blocks the RPC thread, not the main thread)
        var start = Date.now();
        while (!found && (Date.now() - start) < timeoutMs) {
            Thread.sleep(0.05);
        }

        hook.detach();

        if (!found) {
            return { error: 'Timeout waiting for FlowManager (is VRChat fully loaded?)' };
        }

        entryComponent = flowManager;
        return {
            ok: true,
            flowManager: flowManager.toString(),
            klass: flowManager.readPointer().toString(),
            klassName: readCStr(flowManager.readPointer().add(0x58).readPointer()),
        };
    },

    /**
     * Bootstrap Unity methods from the found FlowManager.
     */
    bootstrap: function () {
        if (!entryComponent) return { error: 'Call hookAndWait first' };
        var result = bootstrapFromComponent(entryComponent);
        if (result.ok) bootstrapped = true;
        return result;
    },

    /**
     * Bootstrap from an arbitrary component pointer (for manual use)
     */
    bootstrapFrom: function (ptrStr) {
        entryComponent = ptr(ptrStr);
        var result = bootstrapFromComponent(entryComponent);
        if (result.ok) bootstrapped = true;
        return result;
    },

    /**
     * Full scene scan. Returns all components found.
     * Now includes multi-root discovery:
     *   1. FlowManager's scene tree
     *   2. Singleton static fields → DontDestroyOnLoad objects
     *   3. Extended singleton scan for previously-unseen trees
     */
    scanScene: function () {
        if (!bootstrapped) return { error: 'Not bootstrapped' };

        visitedGOs = {};
        allComponents = [];

        // Phase 1: Scan FlowManager's scene tree
        var entryTransform = fn.getTransform(entryComponent);
        if (entryTransform.isNull()) return { error: 'Entry transform is null' };

        var roots = findAllSceneRoots(entryTransform);
        for (var i = 0; i < roots.length; i++) {
            var rootGO = fn.getGameObject(roots[i]);
            scanGameObject(rootGO, 0, 'FlowManager');
        }

        var phase1GOs = Object.keys(visitedGOs).length;
        var phase1Comps = allComponents.length;

        // Phase 2: Find singletons from discovered classes → scan their trees
        var singletons = findSingletonEntryPoints();
        var singletonResult = scanSingletonTrees(singletons);

        var phase2GOs = Object.keys(visitedGOs).length - phase1GOs;
        var phase2Comps = allComponents.length - phase1Comps;

        return {
            gos_visited: Object.keys(visitedGOs).length,
            components_found: allComponents.length,
            components: allComponents,
            phases: {
                flowManager: { gos: phase1GOs, components: phase1Comps },
                singletons: {
                    checked: singletonResult.singletonsChecked,
                    newRoots: singletonResult.newRoots,
                    gos: phase2GOs,
                    components: phase2Comps,
                },
            },
        };
    },

    /**
     * Scan from multiple component pointers (to cover different scene trees)
     */
    scanMultiRoots: function (ptrStrings) {
        if (!bootstrapped) return { error: 'Not bootstrapped' };

        visitedGOs = {};
        allComponents = [];

        for (var i = 0; i < ptrStrings.length; i++) {
            try {
                var comp = ptr(ptrStrings[i]);
                var klass = comp.readPointer();
                if (klass.isNull()) continue;

                var transform = fn.getTransform(comp);
                if (transform.isNull()) continue;

                var root = fn.getRoot ? fn.getRoot(transform) : transform;
                var rootGO = fn.getGameObject(root);
                scanGameObject(rootGO, 0, 'manual:' + i);
            } catch (e) {}
        }

        return {
            gos_visited: Object.keys(visitedGOs).length,
            components_found: allComponents.length,
            components: allComponents,
        };
    },

    /**
     * Get method names for a klass pointer (for disambiguation)
     */
    getMethodNames: function (klassPtrStr) {
        return getMethodNames(ptr(klassPtrStr));
    },

    /**
     * Get method signatures (name + param count) for a klass pointer
     */
    getMethodSignatures: function (klassPtrStr) {
        return getMethodSignatures(ptr(klassPtrStr));
    },

    /**
     * Read the parent class chain for a klass pointer
     */
    getParentChain: function (klassPtrStr) {
        return readParentChain(ptr(klassPtrStr));
    },

    /**
     * Targeted singleton scan: given a list of klass pointer strings,
     * check their static fields for singleton instances and scan their trees.
     */
    scanTargetedSingletons: function (klassPtrStrings) {
        if (!bootstrapped) return { error: 'Not bootstrapped' };

        var instances = heapScanForSingletons(klassPtrStrings);
        var prevGOs = Object.keys(visitedGOs).length;
        var prevComps = allComponents.length;

        for (var i = 0; i < instances.length; i++) {
            try {
                var comp = ptr(instances[i].ptr);
                var transform = fn.getTransform(comp);
                if (transform.isNull()) continue;
                var root = fn.getRoot ? fn.getRoot(transform) : transform;
                var rootGO = fn.getGameObject(root);
                scanGameObject(rootGO, 0, 'targeted:' + instances[i].klass);
            } catch (e) {}
        }

        return {
            instancesFound: instances.length,
            instances: instances,
            newGOs: Object.keys(visitedGOs).length - prevGOs,
            newComponents: allComponents.length - prevComps,
            totalGOs: Object.keys(visitedGOs).length,
            totalComponents: allComponents.length,
        };
    },

    /**
     * Find additional entry points by scanning known singleton patterns.
     * Improved: scans all discovered klass static fields for self-references,
     * then traverses any new scene trees found.
     */
    findMoreEntryPoints: function () {
        if (!bootstrapped) return { error: 'Not bootstrapped' };

        var singletons = findSingletonEntryPoints();
        var result = scanSingletonTrees(singletons);

        return {
            singletons: singletons.map(function (s) { return { name: s.name, ptr: s.ptr }; }),
            singletonsFound: singletons.length,
            newRoots: result.newRoots,
            newGOs: result.newGOs,
            totalGOs: Object.keys(visitedGOs).length,
            totalComponents: allComponents.length,
        };
    },
};
