'use strict';
/**
 * deep_probe.js — Generic method hooking framework for VRChat system analysis
 *
 * Receives hook config from Python driver via RPC.
 * Installs Interceptor.attach on target methods (by RVA).
 * Logs call events with timing, args, and call frequency.
 *
 * Supports: room lifecycle, Udon VM, network serialization, impostor system
 */

var _gaMod = Process.findModuleByName('GameAssembly.dll');
if (!_gaMod) throw new Error('GameAssembly.dll not found');
var GA = _gaMod.base;
var GA_SIZE = _gaMod.size;

// ---- State ----
var eventLog = [];
var callCounts = {};
var startTime = Date.now();
var MAX_LOG = 10000;
var throttleMap = {};  // per-hook throttle (ms between logs)

// ---- Helpers ----

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

function readKlassName(obj) {
    try {
        var klass = obj.readPointer();
        if (klass.isNull()) return null;
        var namePtr = klass.add(0x58).readPointer();
        return readCStr(namePtr);
    } catch (e) { return null; }
}

function tryReadArg(p) {
    if (p.isNull()) return { type: 'null', value: null };
    try {
        // Try Il2CppString: +0x10 = length(i32), +0x14 = chars(UTF-16)
        var len = p.add(0x10).readInt();
        if (len > 0 && len < 500) {
            var s = p.add(0x14).readUtf16String(len);
            if (s && s.length > 0 && isPrintable(s))
                return { type: 'string', value: s };
        }
    } catch (e) {}

    try {
        // Try managed object — klass at +0x00, name at klass+0x58
        var klass = p.readPointer();
        if (!klass.isNull()) {
            var namePtr = klass.add(0x58).readPointer();
            var name = readCStr(namePtr);
            if (name && name.length > 1 && name.length < 200)
                return { type: 'object', value: name, ptr: p.toString() };
        }
    } catch (e) {}

    return { type: 'ptr', value: p.toString() };
}

function isPrintable(s) {
    for (var i = 0; i < Math.min(s.length, 20); i++) {
        var c = s.charCodeAt(i);
        if (c < 0x20 && c !== 0x0A && c !== 0x0D && c !== 0x09) return false;
    }
    return true;
}

// ---- Specialized arg readers per system ----

var argReaders = {
    // Room system: try to read player info from args
    'OnPlayerJoined': function(args) {
        return { player: tryReadArg(args[1]) };
    },
    'OnPlayerLeft': function(args) {
        return { player: tryReadArg(args[1]) };
    },
    'OnCustomAuthenticationResponse': function(args) {
        return { this: tryReadArg(args[0]), response: tryReadArg(args[1]) };
    },

    // Udon: read event names
    'SendCustomEvent': function(args) {
        var eventName = readIl2CppString(args[1]);
        return { event: eventName || tryReadArg(args[1]) };
    },
    'SendCustomNetworkEvent': function(args) {
        var eventName = readIl2CppString(args[2]);
        return { target: tryReadArg(args[1]), event: eventName || tryReadArg(args[2]) };
    },
    'GetProgramVariable': function(args) {
        var varName = readIl2CppString(args[1]);
        return { variable: varName || tryReadArg(args[1]) };
    },
    'SetProgramVariable': function(args) {
        var varName = readIl2CppString(args[1]);
        return { variable: varName || tryReadArg(args[1]), value: tryReadArg(args[2]) };
    },
    'RunProgram': function(args) {
        var name = readIl2CppString(args[1]);
        return { program: name || tryReadArg(args[1]) };
    },

    // Network: read encode/decode info
    'Encode8': function(args) {
        return { this: tryReadArg(args[0]) };
    },
    'Decode8': function(args) {
        return { this: tryReadArg(args[0]) };
    },
    'Encode32': function(args) {
        return { this: tryReadArg(args[0]) };
    },
    'Decode32': function(args) {
        return { this: tryReadArg(args[0]) };
    },
    'WriteInstance': function(args) {
        return { this: tryReadArg(args[0]), data: tryReadArg(args[1]) };
    },
    'ReadInstance': function(args) {
        return { this: tryReadArg(args[0]), data: tryReadArg(args[1]) };
    },
};

// ---- Hook installation ----

function installHooks(config) {
    var installed = 0;

    for (var i = 0; i < config.length; i++) {
        var h = config[i];
        try {
            var addr = GA.add(h.rva);

            (function(hookInfo, address) {
                var key = hookInfo.className + '.' + hookInfo.methodName;
                callCounts[key] = 0;
                var lastLogTime = 0;
                var readArgCount = hookInfo.readArgs || 0;
                var specialReader = argReaders[hookInfo.methodName] || null;

                Interceptor.attach(address, {
                    onEnter: function(args) {
                        callCounts[key]++;
                        var now = Date.now();

                        // Throttle: max 1 log per 50ms per hook for high-frequency methods
                        var elapsed = now - lastLogTime;
                        if (callCounts[key] > 200 && elapsed < 50) return;

                        // After 1000 calls, only log every 100th
                        if (callCounts[key] > 1000 && callCounts[key] % 100 !== 0) return;

                        lastLogTime = now;

                        var event = {
                            t: now - startTime,
                            hook: key,
                            count: callCounts[key],
                        };

                        // Read args
                        if (specialReader) {
                            try { event.args = specialReader(args); }
                            catch (e) { event.args = { error: e.message }; }
                        } else if (readArgCount > 0) {
                            var argData = {};
                            for (var a = 0; a < Math.min(readArgCount, 4); a++) {
                                try { argData['arg' + a] = tryReadArg(args[a]); }
                                catch (e) { argData['arg' + a] = { type: 'error', value: e.message }; }
                            }
                            event.args = argData;
                        }

                        if (eventLog.length < MAX_LOG) {
                            eventLog.push(event);
                        }
                        send(event);
                    }
                });
                installed++;
            })(h, addr);

        } catch (e) {
            send({ type: 'error', hook: h.className + '.' + h.methodName, error: e.message });
        }
    }

    return installed;
}

// ---- RPC exports ----

rpc.exports = {
    getInfo: function() {
        return {
            ga_base: GA.toString(),
            ga_size: GA_SIZE,
        };
    },

    installHooks: function(config) {
        return installHooks(config);
    },

    getStats: function() {
        return {
            uptime_ms: Date.now() - startTime,
            total_events: eventLog.length,
            call_counts: callCounts,
        };
    },

    getTimeline: function(lastN) {
        var n = lastN || 50;
        return eventLog.slice(-n);
    },

    getTopCallers: function() {
        var sorted = [];
        for (var key in callCounts) {
            sorted.push([key, callCounts[key]]);
        }
        sorted.sort(function(a, b) { return b[1] - a[1]; });
        return sorted.slice(0, 30);
    },

    // Live query: get call count for a specific method
    getCount: function(hookName) {
        return callCounts[hookName] || 0;
    },

    // Reset counters
    reset: function() {
        for (var key in callCounts) callCounts[key] = 0;
        eventLog = [];
        startTime = Date.now();
        return true;
    },
};
