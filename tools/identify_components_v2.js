/**
 * identify_components_v2.js — Full scene traversal component identifier
 *
 * Dynamic class resolution — no hardcoded heap VAs.
 *
 * Strategy:
 *   1. Python passes candidate klass VAs from dump; JS validates at runtime
 *   2. Resolve Unity methods from validated class metadata
 *   3. Find scene roots via GC heap scan for MonoBehaviour instances
 *   4. Recursively traverse all GameObjects
 *   5. For each GO: enumerate components, match against target klass set
 *
 * Beebyte IL2CPP struct offsets:
 *   Il2CppClass: +0x18=namespace, +0x58=name, +0x78=MethodInfo**, +0x120=method_count
 *   MethodInfo:  +0x00=code_ptr, +0x08=code_ptr(dup), +0x18=name(char*)
 *   Il2CppString: +0x10=length(int32), +0x14=chars(UTF-16)
 */

'use strict';

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
        var count = klass.add(0x120).readU16();
        if (count > 500) count = 500;
        for (var i = 0; i < count; i++) {
            var mi = methodArr.add(i * 8).readPointer();
            if (mi.isNull()) return null;
            var name = readCStr(mi.add(0x18).readPointer());
            if (name === methodName) return mi.readPointer();
        }
    } catch (e) {}
    return null;
}

function makePtrPattern(p) {
    var pv = p;
    var bytes = [];
    for (var b = 0; b < 8; b++) {
        bytes.push(pv.and(0xFF).toUInt32().toString(16).padStart(2, '0'));
        pv = pv.shr(8);
    }
    return bytes.join(' ');
}

// ---- Dynamic Class Finder ----

/**
 * Validate a candidate klass VA from the dump.
 * Check that +0x58 (name) and +0x18 (namespace) match expected values.
 * Returns the validated pointer or null.
 */
function validateKlass(candidateVA, expectedName, expectedNs) {
    try {
        var p = ptr(candidateVA);
        var name = readCStr(p.add(0x58).readPointer());
        var ns = readCStr(p.add(0x18).readPointer());
        if (name === expectedName && (ns || '') === (expectedNs || '')) {
            return p;
        }
    } catch (e) {}
    return null;
}

/**
 * If the dump VA doesn't match (ASLR shift), scan nearby memory.
 * Falls back to string-based search across heap.
 */
function findKlassNearby(candidateVA, expectedName, expectedNs) {
    // First try exact VA
    var exact = validateKlass(candidateVA, expectedName, expectedNs);
    if (exact) return exact;

    // Scan in a window around the candidate
    // Il2CppClass structs are aligned to 0x10. Scan ±4MB with adaptive stride.
    var base = ptr(candidateVA);
    // Fine: ±256KB with stride 0x10
    for (var off = -0x40000; off <= 0x40000; off += 0x10) {
        if (off === 0) continue;
        try {
            var candidate = base.add(off);
            var name = readCStr(candidate.add(0x58).readPointer());
            if (name !== expectedName) continue;
            var ns = readCStr(candidate.add(0x18).readPointer());
            if ((ns || '') === (expectedNs || '')) return candidate;
        } catch (e) {}
    }
    // Coarse: ±4MB with stride 0x100
    for (var off2 = -0x400000; off2 <= 0x400000; off2 += 0x100) {
        if (off2 >= -0x40000 && off2 <= 0x40000) continue; // already scanned
        try {
            var candidate2 = base.add(off2);
            var name2 = readCStr(candidate2.add(0x58).readPointer());
            if (name2 !== expectedName) continue;
            var ns2 = readCStr(candidate2.add(0x18).readPointer());
            if ((ns2 || '') === (expectedNs || '')) return candidate2;
        } catch (e) {}
    }

    // String-based search: find the name string in memory, then find classes pointing to it
    var nameBytes = [];
    for (var c = 0; c < expectedName.length; c++) {
        nameBytes.push(expectedName.charCodeAt(c).toString(16).padStart(2, '0'));
    }
    nameBytes.push('00');
    var pattern = nameBytes.join(' ');

    // Build list of string locations
    var strAddrs = [];
    var ranges = Process.enumerateRanges('r--');
    for (var r = 0; r < ranges.length; r++) {
        var range = ranges[r];
        if (range.base.compare(ptr('0x20000000')) < 0) continue;
        if (range.base.compare(ptr('0x800000000')) > 0) continue;
        if (range.size > 0x20000000) continue;
        try {
            var matches = Memory.scanSync(range.base, range.size, pattern);
            for (var m = 0; m < matches.length; m++) {
                // Verify it's an exact match (not substring)
                var addr = matches[m].address;
                var fullStr = readCStr(addr);
                if (fullStr === expectedName) {
                    strAddrs.push(addr);
                }
            }
        } catch (e) {}
    }

    // Now scan for Il2CppClass structs that have a pointer to one of these strings at +0x58
    // Build LE pointer patterns for each string address
    for (var s = 0; s < strAddrs.length && s < 20; s++) {
        var strPtr = strAddrs[s];
        var ptrBytes = [];
        var pv = strPtr;
        for (var b = 0; b < 8; b++) {
            ptrBytes.push(pv.and(0xFF).toUInt32().toString(16).padStart(2, '0'));
            pv = pv.shr(8);
        }
        var ptrPattern = ptrBytes.join(' ');

        // Scan heap for this pointer pattern
        var heapRanges = Process.enumerateRanges('rw-');
        for (var hr = 0; hr < heapRanges.length; hr++) {
            var hRange = heapRanges[hr];
            if (hRange.base.compare(ptr('0x20000000')) < 0) continue;
            if (hRange.base.compare(ptr('0x800000000')) > 0) continue;
            if (hRange.size > 0x20000000) continue;
            try {
                var ptrMatches = Memory.scanSync(hRange.base, hRange.size, ptrPattern);
                for (var pm = 0; pm < ptrMatches.length; pm++) {
                    // This match is at some address X where [X] == strPtr
                    // If this is Il2CppClass+0x58, then class base = X - 0x58
                    var klassCandidate = ptrMatches[pm].address.sub(0x58);
                    var valid = validateKlass(klassCandidate.toString(), expectedName, expectedNs);
                    if (valid) return valid;
                }
            } catch (e) {}
        }
    }

    return null;
}

// ---- Resolved State ----

var methods = null;
var targetVAs = null;
var results = [];
var visitedGOs = {};
var resolvedClasses = {};

// ---- Method Resolution ----

function resolveTransformMethods(transformKlass) {
    return {
        get_childCount: findMethodByName(transformKlass, 'get_childCount'),
        GetChild:       findMethodByName(transformKlass, 'GetChild'),
        get_root:       findMethodByName(transformKlass, 'get_root'),
        get_parent:     findMethodByName(transformKlass, 'get_parent'),
    };
}

function resolveGameObjectMethods(goKlass) {
    return {
        GetComponentCount:     findMethodByName(goKlass, 'GetComponentCount'),
        QueryComponentAtIndex: findMethodByName(goKlass, 'QueryComponentAtIndex'),
    };
}

// ---- Bootstrap Helper ----

function bootstrapFromTransform(transformPtr) {
    var transformKlass = transformPtr.readPointer();
    var tMethods = resolveTransformMethods(transformKlass);

    if (!tMethods.get_childCount || !tMethods.GetChild) {
        return { error: 'Failed to resolve Transform methods' };
    }

    methods.getChildCount = new NativeFunction(tMethods.get_childCount, 'int', ['pointer']);
    methods.getChild      = new NativeFunction(tMethods.GetChild, 'pointer', ['pointer', 'int']);
    methods.getRoot       = tMethods.get_root ? new NativeFunction(tMethods.get_root, 'pointer', ['pointer']) : null;

    var go = methods.getGameObject(transformPtr);
    if (!go.isNull()) {
        var goKlass = go.readPointer();
        var goMethods = resolveGameObjectMethods(goKlass);
        if (goMethods.GetComponentCount && goMethods.QueryComponentAtIndex) {
            methods.getCompCount = new NativeFunction(goMethods.GetComponentCount, 'int', ['pointer']);
            methods.queryCompAt  = new NativeFunction(goMethods.QueryComponentAtIndex, 'pointer', ['pointer', 'int']);
        } else {
            return { error: 'Failed to resolve GameObject methods' };
        }
    } else {
        return { error: 'getGameObject returned null for Transform' };
    }

    return { ok: true, transformKlass: transformKlass.toString() };
}

// ---- Scene Traversal ----

function getGoName(goPtr) {
    try {
        var nameStr = methods.getName(goPtr);
        return readIl2CppString(nameStr);
    } catch (e) { return null; }
}

function scanGameObject(goPtr, depth) {
    if (goPtr.isNull()) return;
    var goKey = goPtr.toString();
    if (visitedGOs[goKey]) return;
    visitedGOs[goKey] = true;
    if (depth > 30) return;

    var goName = getGoName(goPtr);

    // Enumerate components
    if (methods.getCompCount && methods.queryCompAt) {
        try {
            var compCount = methods.getCompCount(goPtr);
            for (var i = 0; i < compCount && i < 200; i++) {
                try {
                    var comp = methods.queryCompAt(goPtr, i);
                    if (comp.isNull()) continue;
                    var klass = comp.readPointer();
                    var klassStr = klass.toString();

                    if (targetVAs[klassStr]) {
                        var className = readCStr(klass.add(0x58).readPointer()) || '?';
                        results.push({
                            klassVA: klassStr,
                            gameObject: goName,
                            compIndex: i,
                            compCount: compCount,
                            className: className,
                            depth: depth,
                            instancePtr: comp.toString()
                        });
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }

    // Recurse children
    try {
        var transform = methods.getTransform(goPtr);
        if (!transform.isNull() && methods.getChildCount) {
            var childCount = methods.getChildCount(transform);
            for (var c = 0; c < childCount && c < 500; c++) {
                try {
                    var childT = methods.getChild(transform, c);
                    if (!childT.isNull()) {
                        var childGO = methods.getGameObject(childT);
                        scanGameObject(childGO, depth + 1);
                    }
                } catch (e) {}
            }
        }
    } catch (e) {}
}

// ---- GC Heap Root Discovery ----

/**
 * Find scene root GameObjects by scanning static fields of known MonoBehaviour classes.
 * For each class VA, check static fields area for instance pointers,
 * then get Transform -> root -> GameObject.
 */
function findRootsFromStaticFields(classVAs) {
    var roots = {};
    var instancePtrs = [];

    for (var i = 0; i < classVAs.length; i++) {
        try {
            var cls = ptr(classVAs[i]);
            // Static fields pointer — try offsets 0xB0..0xC8
            for (var off = 0xB0; off <= 0xC8; off += 8) {
                try {
                    var staticBase = cls.add(off).readPointer();
                    if (staticBase.isNull()) continue;
                    if (staticBase.compare(ptr('0x10000000')) < 0) continue;

                    // Scan static area for instance pointers
                    for (var j = 0; j < 64; j++) {
                        try {
                            var val = staticBase.add(j * 8).readPointer();
                            if (val.isNull()) continue;
                            if (val.compare(ptr('0x10000000')) < 0) continue;
                            // Check if this looks like a managed instance (klass ptr == our class)
                            var objKlass = val.readPointer();
                            if (objKlass.equals(cls)) {
                                instancePtrs.push(val);
                            }
                        } catch (e) {}
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }

    // From found instances, trace to scene roots
    for (var k = 0; k < instancePtrs.length; k++) {
        try {
            var transform = methods.getTransform(instancePtrs[k]);
            if (transform.isNull()) continue;
            var root = methods.getRoot ? methods.getRoot(transform) : transform;
            if (!root.isNull()) {
                var rootGO = methods.getGameObject(root);
                if (!rootGO.isNull()) {
                    roots[rootGO.toString()] = rootGO;
                }
            }
        } catch (e) {}
    }

    return {
        roots: Object.keys(roots),
        instanceCount: instancePtrs.length,
        instancePtrs: instancePtrs.map(function(p) { return p.toString(); })
    };
}

/**
 * Broader instance discovery: scan heap for objects whose klass is in our target set.
 * Uses Memory.scanSync with klass pointer patterns.
 */
function heapScanForInstances(classVAs, maxPerClass) {
    if (!maxPerClass) maxPerClass = 5;
    var found = [];
    var klassPtrMap = {};

    for (var i = 0; i < classVAs.length; i++) {
        klassPtrMap[classVAs[i]] = true;
    }

    // For each target class, create a pattern from its pointer bytes and scan GC heap
    var ranges = Process.enumerateRanges('rw-');
    var heapRanges = [];
    for (var r = 0; r < ranges.length; r++) {
        var range = ranges[r];
        // GC heap is typically in high address range, large allocations
        if (range.size < 0x100000) continue;
        if (range.base.compare(ptr('0x100000000')) < 0) continue;
        heapRanges.push(range);
    }

    for (var c = 0; c < classVAs.length && c < 50; c++) {
        var klassPtr = ptr(classVAs[c]);
        var pattern = makePtrPattern(klassPtr);

        var classFound = 0;
        for (var hr = 0; hr < heapRanges.length && classFound < maxPerClass; hr++) {
            try {
                var matches = Memory.scanSync(heapRanges[hr].base, heapRanges[hr].size, pattern);
                for (var m = 0; m < matches.length && classFound < maxPerClass; m++) {
                    var candidate = matches[m].address;
                    // Validate: the match address should be start of an object (klass at +0x00)
                    // MonoBehaviour: check m_CachedPtr at +0x10 is non-null
                    try {
                        var cachedPtr = candidate.add(0x10).readPointer();
                        if (!cachedPtr.isNull() && cachedPtr.compare(ptr('0x10000')) > 0) {
                            found.push(candidate);
                            classFound++;
                        }
                    } catch (e) {}
                }
            } catch (e) {}
        }
    }

    return found;
}

// ---- RPC Exports ----

rpc.exports = {
    /**
     * Find and validate a class by name+namespace.
     * Python provides candidate VAs from dump; JS validates or searches nearby.
     */
    findClass: function (candidateVA, name, namespace) {
        var klass = findKlassNearby(candidateVA, name, namespace || '');
        if (klass) {
            resolvedClasses[name] = klass;
            return { ok: true, va: klass.toString(), name: name, namespace: namespace };
        }
        return { error: 'Class not found: ' + (namespace || '') + '.' + name };
    },

    /**
     * Initialize ALL methods from pre-resolved class pointers.
     * No live instances needed — pure metadata reads.
     */
    initAll: function (componentVA, objectVA, transformVA, gameObjectVA) {
        var compCls = ptr(componentVA);
        var objCls = ptr(objectVA);
        var transCls = ptr(transformVA);
        var goCls = ptr(gameObjectVA);

        var getGameObject = findMethodByName(compCls, 'get_gameObject');
        var getTransform = findMethodByName(compCls, 'get_transform');
        var getName = findMethodByName(objCls, 'get_name');
        var getChildCount = findMethodByName(transCls, 'get_childCount');
        var getChild = findMethodByName(transCls, 'GetChild');
        var getCompCount = findMethodByName(goCls, 'GetComponentCount');
        var queryCompAt = findMethodByName(goCls, 'QueryComponentAtIndex');

        var missing = [];
        if (!getGameObject) missing.push('get_gameObject');
        if (!getTransform) missing.push('get_transform');
        if (!getName) missing.push('get_name');
        if (!getChildCount) missing.push('get_childCount');
        if (!getChild) missing.push('GetChild');
        if (!getCompCount) missing.push('GetComponentCount');
        if (!queryCompAt) missing.push('QueryComponentAtIndex');

        if (missing.length > 0) {
            return { error: 'Failed to resolve: ' + missing.join(', ') };
        }

        methods = {
            getGameObject: new NativeFunction(getGameObject, 'pointer', ['pointer']),
            getName:       new NativeFunction(getName, 'pointer', ['pointer']),
            getTransform:  new NativeFunction(getTransform, 'pointer', ['pointer']),
            getChildCount: new NativeFunction(getChildCount, 'int', ['pointer']),
            getChild:      new NativeFunction(getChild, 'pointer', ['pointer', 'int']),
            getCompCount:  new NativeFunction(getCompCount, 'int', ['pointer']),
            queryCompAt:   new NativeFunction(queryCompAt, 'pointer', ['pointer', 'int']),
        };

        return {
            ok: true,
            methods: {
                get_gameObject: getGameObject.toString(),
                get_name: getName.toString(),
                get_transform: getTransform.toString(),
                get_childCount: getChildCount.toString(),
                GetChild: getChild.toString(),
                GetComponentCount: getCompCount.toString(),
                QueryComponentAtIndex: queryCompAt.toString(),
            }
        };
    },

    /**
     * Discover scene roots by scanning static fields of given classes.
     * Also tries heap scan as fallback.
     */
    findRoots: function (classVAs) {
        var staticResult = findRootsFromStaticFields(classVAs);
        var rootPtrs = staticResult.roots;

        // If few roots found, try heap scan
        if (rootPtrs.length < 3) {
            var heapInstances = heapScanForInstances(classVAs, 3);
            for (var i = 0; i < heapInstances.length; i++) {
                try {
                    var transform = methods.getTransform(heapInstances[i]);
                    if (transform.isNull()) continue;
                    var root = methods.getRoot ? methods.getRoot(transform) : transform;
                    var rootGO = methods.getGameObject(root);
                    if (!rootGO.isNull()) {
                        var key = rootGO.toString();
                        var exists = false;
                        for (var j = 0; j < rootPtrs.length; j++) {
                            if (rootPtrs[j] === key) { exists = true; break; }
                        }
                        if (!exists) rootPtrs.push(key);
                    }
                } catch (e) {}
            }
        }

        return {
            roots: rootPtrs,
            staticInstances: staticResult.instanceCount,
        };
    },

    /**
     * Direct targeted scan: for each ComplexComponent klass VA, scan heap
     * for instances of that class. Then call getGameObject only on matches.
     * Much safer than scanning all Transforms (fewer Unity method calls).
     *
     * classVAs: array of klass VA strings to search for.
     * Returns in batches to avoid timeout.
     */
    scanTargetedHeap: function (classVAs, batchStart, batchSize) {
        if (!batchStart) batchStart = 0;
        if (!batchSize) batchSize = 20;

        results = [];
        var batchEnd = Math.min(batchStart + batchSize, classVAs.length);

        // Enumerate heap ranges once
        var ranges = Process.enumerateRanges('rw-');
        var heapRanges = [];
        for (var r = 0; r < ranges.length; r++) {
            var range = ranges[r];
            if (range.size < 0x100000) continue;
            if (range.base.compare(ptr('0x100000000')) < 0) continue;
            if (range.size > 0x100000000) continue;
            heapRanges.push(range);
        }

        for (var i = batchStart; i < batchEnd; i++) {
            var klassPtr = ptr(classVAs[i]);
            var pattern = makePtrPattern(klassPtr);
            var className = readCStr(klassPtr.add(0x58).readPointer()) || '?';

            for (var hr = 0; hr < heapRanges.length; hr++) {
                try {
                    var matches = Memory.scanSync(heapRanges[hr].base, heapRanges[hr].size, pattern);
                    for (var m = 0; m < matches.length; m++) {
                        var candidate = matches[m].address;
                        try {
                            // Validate: m_CachedPtr at +0x10 non-null (live MonoBehaviour)
                            var cachedPtr = candidate.add(0x10).readPointer();
                            if (cachedPtr.isNull() || cachedPtr.compare(ptr('0x10000')) < 0) continue;

                            // Get GameObject name
                            var go = methods.getGameObject(candidate);
                            if (go.isNull()) continue;

                            var goName = getGoName(go);

                            results.push({
                                klassVA: klassPtr.toString(),
                                gameObject: goName,
                                className: className,
                                instancePtr: candidate.toString()
                            });
                        } catch (e) {}
                    }
                } catch (e) {}
            }
        }

        return {
            matches: results,
            batchStart: batchStart,
            batchEnd: batchEnd,
            total: classVAs.length
        };
    },

    /**
     * Scan from Component instance pointers (legacy interface).
     */
    scanMultipleRoots: function (instanceVAs, classVAs) {
        targetVAs = {};
        for (var i = 0; i < classVAs.length; i++) {
            var p = ptr(classVAs[i]);
            targetVAs[p.toString()] = true;
        }

        results = [];
        visitedGOs = {};

        for (var j = 0; j < instanceVAs.length; j++) {
            try {
                var inst = ptr(instanceVAs[j]);
                var klass = inst.readPointer();
                if (klass.isNull()) continue;

                var transform = methods.getTransform(inst);
                if (transform.isNull()) continue;

                var root = methods.getRoot ? methods.getRoot(transform) : transform;
                var rootGO = methods.getGameObject(root);
                scanGameObject(rootGO, 0);
            } catch (e) {}
        }

        return {
            total_matches: results.length,
            total_gos_visited: Object.keys(visitedGOs).length,
            matches: results
        };
    },

    /**
     * Quick probe instances.
     */
    probeInstances: function (instanceVAs) {
        var out = [];
        for (var i = 0; i < instanceVAs.length; i++) {
            var r = { ptr: instanceVAs[i] };
            try {
                var inst = ptr(instanceVAs[i]);
                var klass = inst.readPointer();
                if (klass.isNull()) { r.error = 'dead'; out.push(r); continue; }
                r.klass = klass.toString();
                r.className = readCStr(klass.add(0x58).readPointer());

                var go = methods.getGameObject(inst);
                if (!go.isNull()) {
                    r.goName = getGoName(go);
                }
            } catch (e) {
                r.error = e.message;
            }
            out.push(r);
        }
        return out;
    }
};
