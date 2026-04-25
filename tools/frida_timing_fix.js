/**
 * Frida timing fix v3 for VRChat EAC bypass.
 *
 * Problem: VRChat tries to join home world ~5s after start, but Photon
 * master server connects ~27s after start. The join fails because
 * Photon isn't ready, then VRChat goes to Error World.
 *
 * v1/v2 findings:
 * - MoveNext hook blocks coroutine but join failure comes from another path
 * - Init (0x18F1740) is NOT the function that triggers "Going to Home Location"
 * - "set connect error state" (0x1943bc0) sets [obj+0x178] = 1, causing error state
 * - "Failed to join instance due to ''" happens because Photon isn't connected
 *
 * v3 strategy:
 * 1. Hook "set connect error state" (0x1943bc0) to prevent error flag from being set
 * 2. Hook the 3 "Failed to join" functions to block them until Photon connects
 * 3. Keep MoveNext hook as additional backup
 * 4. Once Photon connects, allow everything to proceed naturally
 *
 * Usage: frida -l frida_timing_fix.js -p <VRChat PID>
 *    or: python frida_launch_test.py (auto-launch + attach)
 */

'use strict';

var ga = Process.getModuleByName("GameAssembly.dll");
var BASE = ga.base;

// Key RVAs (from trace_offline_check.js and patch analysis)
var RVA_SET_CONNECT_ERROR = 0x1943bc0;    // "set connect error state" - sets [obj+0x178]=1
var RVA_JOIN_MOVENEXT = 0x191A720;        // Join coroutine MoveNext
var RVA_ON_CONNECTED_MASTER = 0x19572F0;  // PhotonConnectionHandler OnConnectedToMaster
var RVA_FAIL_JOIN_0 = 0x15d4d60;          // "Failed to join instance" path 0
var RVA_FAIL_JOIN_1 = 0x113494b;          // "Failed to join instance" path 1 (mid-function, may not hook cleanly)
var RVA_FAIL_JOIN_2 = 0x18fcd80;          // "Failed to join instance" path 2

// ── State ──
var photonConnected = false;
var errorStateBlocked = 0;
var joinBlocked = 0;
var failJoinBlocked = 0;
var startTime = Date.now();

function elapsed() {
    return ((Date.now() - startTime) / 1000).toFixed(1) + "s";
}

function msg(text) {
    send(text);
}

// ═══════════════════════════════════════════════════════════
// Hook 1: OnConnectedToMaster — track when Photon is ready
// ═══════════════════════════════════════════════════════════
var onConnectedAddr = BASE.add(RVA_ON_CONNECTED_MASTER);
Interceptor.attach(onConnectedAddr, {
    onEnter: function(args) {
        if (!photonConnected) {
            photonConnected = true;
            msg("[" + elapsed() + "] OK Photon OnConnectedToMaster!");
            msg("[" + elapsed() + "]   Blocked: " + errorStateBlocked + " error-state, " + failJoinBlocked + " fail-join, " + joinBlocked + " MoveNext");
        }
    }
});
msg("[" + elapsed() + "] Hook: OnConnectedToMaster @ " + onConnectedAddr);

// ═══════════════════════════════════════════════════════════
// Hook 2: "set connect error state" — let it run but CLEAR the flag after
// This function is actually a Photon state machine callback called ~140/sec.
// We can't NOP it or Photon never connects. Instead, let it run normally
// but immediately clear the error flag [obj+0x178] after each call.
// ═══════════════════════════════════════════════════════════
var setConnectErrorAddr = BASE.add(RVA_SET_CONNECT_ERROR);
var capturedObj = null;  // store the object pointer for flag clearing
Interceptor.attach(setConnectErrorAddr, {
    onEnter: function(args) {
        if (!capturedObj) {
            capturedObj = args[0];
            msg("[" + elapsed() + "] Captured state object @ " + capturedObj);
        }
    },
    onLeave: function(retval) {
        if (!photonConnected && capturedObj) {
            // Clear the error flag after each call
            try {
                var flagVal = capturedObj.add(0x178).readU8();
                if (flagVal !== 0) {
                    capturedObj.add(0x178).writeU8(0);
                    errorStateBlocked++;
                    if (errorStateBlocked <= 5 || errorStateBlocked % 50 === 0) {
                        msg("[" + elapsed() + "] CLEARED error flag (+0x178) #" + errorStateBlocked);
                    }
                }
            } catch(e) {}
        }
    }
});
msg("[" + elapsed() + "] Hook: set-connect-error (CLEAR flag) @ " + setConnectErrorAddr);

// ═══════════════════════════════════════════════════════════
// Hook 3: "Failed to join instance" functions — REPLACE with conditional NOP
// ═══════════════════════════════════════════════════════════
var failJoinRVAs = [
    {rva: RVA_FAIL_JOIN_0, name: 'fail_join_0'},
    {rva: RVA_FAIL_JOIN_2, name: 'fail_join_2'}
];

for (var i = 0; i < failJoinRVAs.length; i++) {
    (function(f) {
        var addr = BASE.add(f.rva);
        try {
            var orig = new NativeFunction(addr, 'void', ['pointer', 'pointer', 'pointer', 'pointer']);
            Interceptor.replace(addr, new NativeCallback(function(a0, a1, a2, a3) {
                if (!photonConnected) {
                    failJoinBlocked++;
                    if (failJoinBlocked <= 5 || failJoinBlocked % 20 === 0) {
                        msg("[" + elapsed() + "] SKIP " + f.name + " #" + failJoinBlocked + " (Photon not ready)");
                    }
                    return;  // Skip entirely
                }
                orig(a0, a1, a2, a3);
            }, 'void', ['pointer', 'pointer', 'pointer', 'pointer']));
            msg("[" + elapsed() + "] Hook: " + f.name + " (REPLACE) @ " + addr);
        } catch(e) {
            msg("[" + elapsed() + "] WARN: Could not hook " + f.name + ": " + e);
        }
    })(failJoinRVAs[i]);
}

// ═══════════════════════════════════════════════════════════
// Hook 4: Join Coroutine MoveNext — backup block
// ═══════════════════════════════════════════════════════════
var joinMoveNextAddr = BASE.add(RVA_JOIN_MOVENEXT);
Interceptor.attach(joinMoveNextAddr, {
    onEnter: function(args) {
        this.shouldBlock = false;
        if (!photonConnected) {
            var state = -999;
            try { state = args[0].add(0x10).readS32(); } catch(e) {}
            if (state >= 0 && state <= 5) {
                this.shouldBlock = true;
                joinBlocked++;
                if (joinBlocked <= 3 || joinBlocked % 50 === 0) {
                    msg("[" + elapsed() + "] BLOCK MoveNext (state=" + state + ", #" + joinBlocked + ")");
                }
            }
        }
    },
    onLeave: function(retval) {
        if (this.shouldBlock) {
            retval.replace(ptr(1));  // yield = continue later
        }
    }
});
msg("[" + elapsed() + "] Hook: MoveNext @ " + joinMoveNextAddr);

// ═══════════════════════════════════════════════════════════
// Monitor
// ═══════════════════════════════════════════════════════════
var monitorInterval = setInterval(function() {
    var e = elapsed();
    if (!photonConnected) {
        msg("[" + e + "] Status: Photon NOT connected | err-state:" + errorStateBlocked + " fail-join:" + failJoinBlocked + " MoveNext:" + joinBlocked);
    } else {
        msg("[" + e + "] Status: Photon CONNECTED | all hooks allowing traffic");
        clearInterval(monitorInterval);
        setInterval(function() {
            msg("[" + elapsed() + "] Status: running normally");
        }, 30000);
    }
}, 5000);

msg("[" + elapsed() + "] =============================================");
msg("[" + elapsed() + "] VRChat Timing Fix v3 loaded");
msg("[" + elapsed() + "] Strategy: Block error-state + fail-join + MoveNext until Photon");
msg("[" + elapsed() + "] =============================================");
