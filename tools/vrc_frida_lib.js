/**
 * vrc_frida_lib.js - Reusable Frida library for VRChat IL2CPP runtime exploration
 *
 * All offsets are Beebyte-obfuscated IL2CPP layout (NOT standard IL2CPP).
 * Usage:
 *   frida -p <PID> -l tools/vrc_frida_lib.js -l my_script.js
 *   // Then: VRC.klassGetName(klass), VRC.findInstances(klass), etc.
 */
'use strict';

var VRC = (function () {
    var _ga = null, _base = null;
    function _ensureGA() {
        if (!_ga) { _ga = Process.getModuleByName('GameAssembly.dll'); _base = _ga.base; }
        return _ga;
    }

    // === Module 1: IL2CPP Primitives ===

    function readCStr(p) {
        if (p.isNull()) return null;
        try { var s = p.readUtf8String(); return (s && s.length < 500) ? s : null; }
        catch (e) { return null; }
    }

    /** Il2CppString: +0x10=length(int32), +0x14=chars(UTF-16) */
    function readIl2CppString(p) {
        if (p.isNull()) return null;
        try { var len = p.add(0x10).readInt();
            if (len > 0 && len < 2000) return p.add(0x14).readUtf16String(len);
        } catch (e) {} return null;
    }

    // Il2CppClass: +0x18=namespace, +0x58=name, +0x78=methods, +0xA0=fields
    //   +0xB8=static_fields, +0x120=method_count, +0x124=field_count, +0x128=vtable_count
    function klassGetName(klass) {
        try { return readCStr(klass.add(0x58).readPointer()); } catch(e) { return null; }
    }
    function klassGetNamespace(klass) {
        try { return readCStr(klass.add(0x18).readPointer()); } catch(e) { return null; }
    }
    function klassGetFullName(klass) {
        var ns = klassGetNamespace(klass) || '', n = klassGetName(klass) || '?';
        return ns ? (ns + '.' + n) : n;
    }
    /** Returns array of MethodInfo* pointers */
    function klassGetMethods(klass) {
        var out = [];
        try {
            var arr = klass.add(0x78).readPointer(); if (arr.isNull()) return out;
            var count = klass.add(0x120).readU16(); if (count > 500) count = 500;
            for (var i = 0; i < count; i++) {
                var mi = arr.add(i * 8).readPointer(); if (mi.isNull()) break;
                out.push(mi);
            }
        } catch (e) {} return out;
    }
    /** Returns array of {ptr, name, offset, typeAddr} — stride 0x20 */
    function klassGetFields(klass) {
        var out = [];
        try {
            var b = klass.add(0xA0).readPointer(); if (b.isNull()) return out;
            var count = klass.add(0x124).readU16(); if (count > 1000) count = 1000;
            for (var i = 0; i < count; i++) {
                var fb = b.add(i * 0x20);
                out.push({ ptr: fb, name: readCStr(fb.add(0x10).readPointer()) || '?',
                    offset: fb.add(4).readU32(), typeAddr: fb.add(0x08).readPointer() });
            }
        } catch (e) {} return out;
    }
    function klassGetStaticFields(klass) {
        try { return klass.add(0xB8).readPointer(); } catch(e) { return ptr(0); }
    }

    // MethodInfo: +0x00=code, +0x08=code(dup), +0x18=name, +0x28=declaring_class
    function methodGetName(mi) {
        try { return readCStr(mi.add(0x18).readPointer()); } catch(e) { return null; }
    }
    function methodGetCode(mi) {
        try { return mi.readPointer(); } catch(e) { return ptr(0); }
    }
    function methodGetClass(mi) {
        try { return mi.add(0x28).readPointer(); } catch(e) { return ptr(0); }
    }

    /** Find method by name. Returns {code, methodInfo} or null. */
    function findMethod(klass, name) {
        var methods = klassGetMethods(klass);
        for (var i = 0; i < methods.length; i++) {
            if (methodGetName(methods[i]) === name)
                return { code: methodGetCode(methods[i]), methodInfo: methods[i] };
        }
        return null;
    }

    /** Walk vtable. Each entry=16 bytes [code(8), MethodInfo*(8)]. Returns [{slot,code,methodInfo,name}] */
    function walkVtable(klass, maxSlots) {
        if (!maxSlots) maxSlots = 80;
        var out = [];
        try {
            var vtCount = klass.add(0x128).readU16();
            if (vtCount > maxSlots) vtCount = maxSlots;
            var vtBase = klass.add(0x150);
            for (var i = 0; i < vtCount; i++) {
                var entry = vtBase.add(i * 16);
                var code = entry.readPointer(), mi = entry.add(8).readPointer();
                var name = null; try { name = methodGetName(mi); } catch(e) {}
                out.push({ slot: i, code: code, methodInfo: mi, name: name });
            }
        } catch (e) {} return out;
    }

    // === Module 2: Object Discovery ===

    var DEFAULT_SCAN_RANGES = [
        [ptr('0x280000000'), 0x4000000], [ptr('0x290000000'), 0x4000000],
        [ptr('0x298000000'), 0x4000000], [ptr('0x2A0000000'), 0x4000000],
        [ptr('0x2A8000000'), 0x4000000], [ptr('0x2B0000000'), 0x4000000],
        [ptr('0x2B8000000'), 0x4000000], [ptr('0x2C0000000'), 0x4000000],
        [ptr('0x2D0000000'), 0x4000000], [ptr('0x2E0000000'), 0x4000000],
        [ptr('0x2F0000000'), 0x4000000], [ptr('0x300000000'), 0x4000000],
        [ptr('0x310000000'), 0x4000000], [ptr('0x320000000'), 0x4000000],
    ];

    /** Heap scan for instances matching klass pointer at [obj+0x00]. */
    function findInstances(klassPtr, scanRanges, maxResults) {
        if (!scanRanges) scanRanges = DEFAULT_SCAN_RANGES;
        if (!maxResults) maxResults = 10;
        var results = [];
        for (var r = 0; r < scanRanges.length; r++) {
            var base = scanRanges[r][0], size = scanRanges[r][1];
            for (var off = 0; off < size; off += 0x10) {
                try {
                    if (base.add(off).readPointer().equals(klassPtr)) {
                        results.push(base.add(off));
                        if (results.length >= maxResults) return results;
                    }
                } catch (e) { off += 0x1000 - (off % 0x1000) - 0x10; }
            }
        }
        return results;
    }

    /** Find singleton via static fields: klass+0xB8 -> scan for self-referencing instance */
    function findSingleton(klassPtr) {
        try {
            var statics = klassPtr.add(0xB8).readPointer(); if (statics.isNull()) return null;
            for (var off = 0; off <= 0x40; off += 0x8) {
                var c = statics.add(off).readPointer();
                if (!c.isNull()) { try { if (c.readPointer().equals(klassPtr)) return c; } catch(e) {} }
            }
        } catch (e) {} return null;
    }

    // === Module 3: Coroutine / Method Execution ===

    var _startCoroutineAddr = null;

    /** Resolve StartCoroutineManaged2: cached at BASE+0xC5E1100, or via resolver at BASE+0x9F9100 */
    function resolveStartCoroutine() {
        if (_startCoroutineAddr && !_startCoroutineAddr.isNull()) return _startCoroutineAddr;
        _ensureGA();
        try { var c = _base.add(0xC5E1100).readPointer();
            if (!c.isNull()) { _startCoroutineAddr = c; return c; }
        } catch (e) {}
        try { var r = new NativeFunction(_base.add(0x9F9100), 'pointer', ['pointer']);
            var v = r(_base.add(0x9F89760));
            if (!v.isNull()) { _startCoroutineAddr = v; return v; }
        } catch (e) {}
        return null;
    }

    /** Start coroutine on MonoBehaviour. MUST be called from main thread. */
    function startCoroutine(monoBehaviour, coroutineObj) {
        var addr = resolveStartCoroutine();
        if (!addr) throw new Error('Cannot resolve StartCoroutineManaged2');
        return new NativeFunction(addr, 'pointer', ['pointer', 'pointer'])(monoBehaviour, coroutineObj);
    }

    /** Create NativeFunction with error handling. Returns wrapped fn or null. */
    function makeNativeFunc(addr, retType, argTypes) {
        if (!addr || addr.isNull()) return null;
        var fn = new NativeFunction(addr, retType, argTypes);
        return function () { try { return fn.apply(null, arguments); } catch (e) { return null; } };
    }

    // === Module 4: Hook Helpers ===

    /** Run callback ONCE on main thread via error-state-setter hook (RVA 0x1943BC0, ~140/sec). */
    function onMainThread(callback, rva) {
        _ensureGA();
        var fired = false;
        var hook = Interceptor.attach(_base.add(rva || 0x1943BC0), {
            onEnter: function () {
                if (fired) return; fired = true;
                try { callback(); } catch (e) {
                    send({ type: 'error', msg: 'onMainThread failed: ' + e.message });
                } finally { hook.detach(); }
            }
        });
        return hook;
    }

    /** Trace every call to addr, logging argCount args and return value. Returns listener. */
    function traceMethod(addr, name, argCount) {
        if (!argCount) argCount = 3;
        return Interceptor.attach(addr, {
            onEnter: function (args) {
                var a = []; for (var i = 0; i < argCount; i++) a.push(args[i].toString());
                send('>>> ' + name + '(' + a.join(', ') + ')');
            },
            onLeave: function (retval) { send('<<< ' + name + ' -> ' + retval); }
        });
    }

    /** Wait for module to load (spawn mode). Polls every intervalMs. */
    function waitForModule(moduleName, callback, intervalMs) {
        var check = setInterval(function () {
            try { var m = Process.getModuleByName(moduleName); clearInterval(check); callback(m); }
            catch (e) {}
        }, intervalMs || 100);
    }

    // === Module 5: Config Loading ===

    /** Load JSON config. "rva_xxx" -> addr_xxx (BASE+rva), "va_xxx" -> ptr_xxx. */
    function loadConfig(configPath) {
        _ensureGA();
        var f = new File(configPath, 'r'), content = f.readAllText(); f.close();
        var config = JSON.parse(content); config._gaBase = _base;
        var keys = Object.keys(config);
        for (var i = 0; i < keys.length; i++) {
            var k = keys[i];
            if (k.indexOf('rva_') === 0 && typeof config[k] === 'number')
                config['addr_' + k.substring(4)] = _base.add(config[k]);
            if (k.indexOf('va_') === 0 && typeof config[k] === 'string')
                config['ptr_' + k.substring(3)] = ptr(config[k]);
        }
        return config;
    }

    // === Module 6: Utility ===

    function gaBase() { _ensureGA(); return _base; }
    function gaModule() { return _ensureGA(); }
    function rva(offset) { _ensureGA(); return _base.add(offset); }
    function toRVA(addr) { _ensureGA(); return addr.sub(_base).toNumber(); }

    /** Compact class dump: {klass, name, methods[], fields[]} */
    function dumpClass(klass) {
        var methods = klassGetMethods(klass), fields = klassGetFields(klass);
        var mn = [], fd = [];
        for (var i = 0; i < methods.length; i++) { var n = methodGetName(methods[i]); if (n) mn.push(n); }
        for (var j = 0; j < fields.length; j++) fd.push('+0x' + fields[j].offset.toString(16) + ' ' + fields[j].name);
        return { klass: klass.toString(), name: klassGetFullName(klass),
            methodCount: methods.length, fieldCount: fields.length, methods: mn, fields: fd };
    }

    /** Check if string is Beebyte-obfuscated (3+ chars from U+00CC-00CF) */
    function isObfuscated(s) {
        if (!s || s.length < 3) return false;
        for (var i = 0; i < s.length; i++) { var c = s.charCodeAt(i); if (c < 0xCC || c > 0xCF) return false; }
        return true;
    }

    // === Public API ===
    return {
        readCStr: readCStr, readIl2CppString: readIl2CppString,
        klassGetName: klassGetName, klassGetNamespace: klassGetNamespace, klassGetFullName: klassGetFullName,
        klassGetMethods: klassGetMethods, klassGetFields: klassGetFields, klassGetStaticFields: klassGetStaticFields,
        methodGetName: methodGetName, methodGetCode: methodGetCode, methodGetClass: methodGetClass,
        findMethod: findMethod, walkVtable: walkVtable,
        DEFAULT_SCAN_RANGES: DEFAULT_SCAN_RANGES, findInstances: findInstances, findSingleton: findSingleton,
        resolveStartCoroutine: resolveStartCoroutine, startCoroutine: startCoroutine, makeNativeFunc: makeNativeFunc,
        onMainThread: onMainThread, traceMethod: traceMethod, waitForModule: waitForModule,
        loadConfig: loadConfig,
        gaBase: gaBase, gaModule: gaModule, rva: rva, toRVA: toRVA,
        dumpClass: dumpClass, isObfuscated: isObfuscated,
    };
})();
