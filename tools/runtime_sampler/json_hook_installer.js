/**
 * json_hook_installer.js - Frida agent that installs read-only inline hooks on
 * Newtonsoft.Json's deserialiser to leak (obfuscated class -> real field name)
 * pairs. The JSON wire key is the obf class's pre-rename member name, so the
 * stream of (target_class, UnderlyingName) pairs rebuilds each DTO's schema.
 *
 * Load AFTER vrc_frida_lib.js (uses global VRC). Pure Interceptor.attach reads
 * of incoming arguments only -- it NEVER calls a game function, so it does not
 * trip VRChat's return-address anti-tamper check (which rejects outbound
 * NativeFunction calls into GameAssembly.dll). See JSON_INSTALLER_DESIGN.md.
 *
 *   frida -p <PID> -l tools/vrc_frida_lib.js \
 *                  -l tools/runtime_sampler/json_hook_installer.js
 */
'use strict';

(function () {
    if (typeof VRC === 'undefined') {
        send({ type: 'error', msg: 'VRC global missing - load vrc_frida_lib.js first' });
        return;
    }

    var IMAGE_BASE = ptr('0x180000000');

    // file-VA addresses from output/p2_research/json_hook_points.json.
    // SetPropertyValue is the prime hook (fires once per JSON property, sees both
    // the JsonProperty identity and the target object). Newtonsoft is linked
    // twice, so every method exists as copy A (0x186...) and copy B (0x188...);
    // we attach to both and let whichever the live call sites bind to fire.
    var HOOKS = [
        { name: 'SetPropertyValue', copy: 'A', fileVa: '0x186a71520' },
        { name: 'SetPropertyValue', copy: 'B', fileVa: '0x18818f6d0' }
    ];

    // --- rebase: runtime_addr = module_base + (file_va - 0x180000000) ---
    var gaBase = VRC.gaBase();   // live GameAssembly.dll load base
    var gaMod = VRC.gaModule();
    var gaEnd = gaBase.add(gaMod.size);

    function fileVaToRuntime(fileVaStr) {
        return gaBase.add(ptr(fileVaStr).sub(IMAGE_BASE));
    }

    function inGa(p) {
        try { return !p.isNull() && p.compare(gaBase) >= 0 && p.compare(gaEnd) < 0; }
        catch (e) { return false; }
    }

    // ------------------------------------------------------------------
    // De-dup + aggregation: only emit each (class, key) once to keep the
    // message channel light during a long capture session.
    // ------------------------------------------------------------------
    var seenPairs = {};       // "class|key" -> true
    var emitted = 0;
    var hookFires = 0;        // how many times any hook fired (sanity)

    function emitPair(obfClass, key) {
        if (!obfClass || !key) return;
        var id = obfClass + '|' + key;
        if (seenPairs[id]) return;
        seenPairs[id] = true;
        emitted++;
        send({ type: 'json_keys', obf_class: obfClass, key: key });
    }

    // ------------------------------------------------------------------
    // JsonProperty field-offset resolution (anti-tamper-safe).
    //
    // We must read the property's name WITHOUT calling get_UnderlyingName
    // (that would be an outbound game call -> return-address check). Instead we
    // read the backing STRING FIELD directly. The field offset is discovered at
    // runtime from the JsonProperty class layout (VRC.klassGetFields) the first
    // time we see that class, then cached.
    //
    // Newtonsoft field names are NOT Beebyte-obfuscated (the symbol table keeps
    // JsonProperty::get_UnderlyingName intact), so we match by name:
    //   primary  : *underlyingname*  (UnderlyingName / _underlyingName /
    //              <UnderlyingName>k__BackingField) = pre-rename member name
    //   fallback : *propertyname*    (PropertyName / _propertyName) = wire key
    // Both are System.String references; read ptr at instance+offset then decode
    // as an Il2CppString (len@+0x10, chars@+0x14).
    // ------------------------------------------------------------------
    var jpOffsetCache = {};   // klass.toString() -> { underlying:int|-1, wire:int|-1 }

    function resolveNameOffsets(klass) {
        var key = klass.toString();
        var cached = jpOffsetCache[key];
        if (cached) return cached;
        var res = { underlying: -1, wire: -1 };
        try {
            var fields = VRC.klassGetFields(klass);
            for (var i = 0; i < fields.length; i++) {
                var fn = (fields[i].name || '').toLowerCase();
                if (res.underlying < 0 && fn.indexOf('underlyingname') >= 0)
                    res.underlying = fields[i].offset;
                else if (res.wire < 0 && fn.indexOf('propertyname') >= 0)
                    res.wire = fields[i].offset;
            }
        } catch (e) {}
        jpOffsetCache[key] = res;
        return res;
    }

    /** JsonProperty* -> best available name string (UnderlyingName, else PropertyName). */
    function readPropertyName(jpPtr) {
        if (jpPtr.isNull()) return null;
        try {
            var klass = jpPtr.readPointer();          // obj+0x00 = Il2CppClass*
            if (klass.isNull() || klass.compare(ptr('0x10000')) < 0) return null;
            var offs = resolveNameOffsets(klass);
            var s;
            if (offs.underlying >= 0) {
                s = VRC.readIl2CppString(jpPtr.add(offs.underlying).readPointer());
                if (s) return s;
            }
            if (offs.wire >= 0) {
                s = VRC.readIl2CppString(jpPtr.add(offs.wire).readPointer());
                if (s) return s;
            }
        } catch (e) {}
        return null;
    }

    /** target object* -> its il2cpp class name (obj+0x00 = Il2CppClass*). */
    function readTargetClassName(objPtr) {
        if (objPtr.isNull()) return null;
        try {
            var klass = objPtr.readPointer();
            if (klass.isNull() || klass.compare(ptr('0x10000')) < 0) return null;
            return VRC.klassGetName(klass);
        } catch (e) {}
        return null;
    }

    // ------------------------------------------------------------------
    // Argument layout of JsonSerializerInternalReader::SetPropertyValue.
    //
    // Managed (Newtonsoft, stable 11.x-13.x), instance method:
    //   bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter,
    //       JsonContainerContract containerContract, JsonProperty containerProperty,
    //       JsonReader reader, object target)
    //
    // IL2CPP x64 lowers an instance method to a free function whose first arg is
    // the implicit `this` (the JsonSerializerInternalReader) and whose last
    // hidden arg is the MethodInfo*. So the native frame is:
    //   args[0] = this  (JsonSerializerInternalReader*)
    //   args[1] = property            (JsonProperty*)   <-- the KEY source
    //   args[2] = propertyConverter   (JsonConverter*)
    //   args[3] = containerContract   (JsonContainerContract*)
    //   args[4] = containerProperty   (JsonProperty*)
    //   args[5] = reader              (JsonReader*)
    //   args[6] = target              (object*)         <-- the CLASS source
    //   args[7] = MethodInfo*
    //
    // ASSUMPTION TO VERIFY LIVE: exact arg indices (1 = property, 6 = target).
    // Rather than trust them blindly we SCAN args[1..7]: the property is the arg
    // whose class exposes an UnderlyingName/PropertyName string field, and the
    // target is a different managed object arg whose class name resolves. This
    // makes the hook robust to a one-slot shift or an inlined `this`. The
    // documented indices are tried first as a fast path.
    // ------------------------------------------------------------------
    var MAX_ARG = 8;          // scan args[1..7]

    function looksLikeManagedObj(p) {
        // a managed object's first qword points to an Il2CppClass* inside some
        // committed page; class ptr itself is well above the low reserved range.
        if (p.isNull() || p.compare(ptr('0x10000')) < 0) return false;
        try {
            var klass = p.readPointer();
            return !klass.isNull() && klass.compare(ptr('0x10000')) >= 0;
        } catch (e) { return false; }
    }

    function handleCall(args, tag) {
        hookFires++;
        var key = null, obfClass = null;

        // fast path: documented indices
        try { key = readPropertyName(args[1]); } catch (e) {}
        try { obfClass = readTargetClassName(args[6]); } catch (e) {}

        // fallback scan if either documented slot missed
        if (!key || !obfClass) {
            for (var i = 1; i < MAX_ARG; i++) {
                var a;
                try { a = args[i]; } catch (e) { continue; }
                if (!looksLikeManagedObj(a)) continue;
                if (!key) {
                    var k = readPropertyName(a);
                    if (k) { key = k; continue; }
                }
                if (!obfClass) {
                    var c = readTargetClassName(a);
                    if (c) obfClass = c;
                }
            }
        }

        if (key && obfClass) emitPair(obfClass, key);
    }

    // ------------------------------------------------------------------
    // Install hooks. Guard each attach so one bad address can't abort the rest.
    // ------------------------------------------------------------------
    var installed = 0;
    for (var h = 0; h < HOOKS.length; h++) {
        (function (hook) {
            try {
                var addr = fileVaToRuntime(hook.fileVa);
                if (!inGa(addr)) {
                    send({ type: 'error', msg: 'hook ' + hook.name + ' copy ' +
                        hook.copy + ' @ ' + addr + ' outside GameAssembly range' });
                    return;
                }
                var tag = hook.name + '/' + hook.copy;
                Interceptor.attach(addr, {
                    onEnter: function (args) {
                        try { handleCall(args, tag); } catch (e) {}
                    }
                });
                installed++;
                send({ type: 'info', msg: 'attached ' + tag + ' @ ' + addr +
                    ' (file-VA ' + hook.fileVa + ', base ' + gaBase + ')' });
            } catch (e) {
                send({ type: 'error', msg: 'attach failed for ' + hook.name +
                    ' copy ' + hook.copy + ': ' + e.message });
            }
        })(HOOKS[h]);
    }

    send({ type: 'info', msg: 'json_hook_installer ready: ' + installed + '/' +
        HOOKS.length + ' hooks live, GA base ' + gaBase });

    // periodic heartbeat so the driver can see capture is progressing
    setInterval(function () {
        send({ type: 'stats', hook_fires: hookFires, pairs_emitted: emitted,
            unique_pairs: Object.keys(seenPairs).length });
    }, 5000);
})();
