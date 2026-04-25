/**
 * VRChat GoHome Identifier + Photon Timing Fix v4
 *
 * STRATEGY:
 * 1. Hook Init function to capture GoHome method pointer from vtable+0x298
 * 2. Hook OnConnectedToMaster to know when Photon is ready
 * 3. When Photon connects, re-invoke the FlowManager's m_A16 (which calls init → GoHome)
 *    to trigger a second world-join attempt that will succeed
 *
 * BACKGROUND (from binary analysis):
 *   Init function (RVA 0x18F1740) is called by FlowManager.m_A16 (RVA 0x1921EF0).
 *   Init does: setup → version check → direct path calls vtable+0x298 (GoHome).
 *   GoHome at +5s fails because Photon connects at +19s.
 *   The first join fails → Error World (broken UI).
 *   After Photon connects, a SECOND GoHome call should succeed → real world.
 *
 *   VRCFlowManager also has _WaitForPhotonConnection_d__70, _BeginConnectionToPhoton_d__68,
 *   and _AuthenticateWithSteamCoroutine_d__79 coroutines (from community vocabulary).
 *
 * USAGE:
 *   frida -l tools/frida_find_gohome.js -p <VRChat PID>
 *   python tools/frida_launch_test.py  (auto-attach)
 */

'use strict';

var ga = Process.getModuleByName("GameAssembly.dll");
var BASE = ga.base;
var startTime = Date.now();

function elapsed() {
    return ((Date.now() - startTime) / 1000).toFixed(1) + "s";
}
function msg(text) {
    send("[" + elapsed() + "] " + text);
}

// ═══════════════════════════════════════════════════
// State
// ═══════════════════════════════════════════════════
var photonConnected = false;
var goHomeRVA = null;
var goHomeAddr = null;
var goHomeMethodInfo = null;
var flowManagerPtr = null;  // FlowManager instance
var initDataPtr = null;     // data pointer passed to m_A16
var initFlags = 0;          // flags passed to m_A16

// ═══════════════════════════════════════════════════
// Key RVAs
// ═══════════════════════════════════════════════════
var RVA = {
    INIT:           0x18F1740,   // Init function (called by m_A16)
    ON_CONNECTED:   0x19572F0,   // PhotonConnectionHandler_34AB.OnConnectedToMaster
    ON_CONNECTED_2: 0x211A830,   // PhotonConnectionHandler_E3E5.OnConnectedToMaster
    AWAKE:          0x1921E50,   // FlowManager.Awake
    M_A16:          0x1921EF0,   // FlowManager.m_A16 → calls init
    POST_GOHOME:    0x7474870,   // Function called after GoHome with its return value
};

// FlowManager method RVAs (VA - 0x7FFB4D4F0000)
var DUMP_BASE = uint64("0x7FFB4D4F0000");
var FM_RVA_MAP = {};
var fm_vas = {
    "m_976": "0x7FFB4EE0E8C0", "m_946": "0x7FFB4EE0EB10", "m_9FA": "0x7FFB4EE0EBB0",
    "m_CAF": "0x7FFB4EE0ECB0", "m_A8A": "0x7FFB4EE0ECC0", "m_2FB": "0x7FFB4EE0EE10",
    "m_13A": "0x7FFB4EE0F0F0", "m_EAB": "0x7FFB4EE0F290", "m_CC1": "0x7FFB4EE0F380",
    "m_B1B": "0x7FFB4EE0F390", "m_C5E": "0x7FFB4EE0F530", "m_00F": "0x7FFB4EE12090",
    "m_541": "0x7FFB4EE0F810", "m_49A": "0x7FFB4EE112C0", "m_BB1": "0x7FFB4EE10CC0",
    "m_72F": "0x7FFB4EE10D00", "m_8C4": "0x7FFB4EE10ED0",
    "m_27D": "0x7FFB4EE110F0", "m_CC2": "0x7FFB4EE11370",
    "m_2E7": "0x7FFB4EE113F0", "m_46E": "0x7FFB4EE114C0", "m_001": "0x7FFB4EE11560",
    "m_F4F": "0x7FFB4EE11600", "m_42A": "0x7FFB4EE11770", "m_E5A": "0x7FFB4EE118A0",
    "m_A16": "0x7FFB4EE11EF0", "m_C93": "0x7FFB4EE11F60",
    "m_BC5": "0x7FFB4EE12250", "m_F43": "0x7FFB4EE122F0",
    "m_D2E": "0x7FFB4EE12410", "m_B80": "0x7FFB4EE125F0", "m_7CA": "0x7FFB4EE12E10",
    "m_9C7": "0x7FFB4EE130B0", "m_0CF": "0x7FFB4EE14070", "m_E84": "0x7FFB4EE141B0",
    "m_935": "0x7FFB4EE14340", "m_216": "0x7FFB4EE143F0", "m_B03": "0x7FFB4EE145A0",
    "m_975": "0x7FFB4EE14740", "m_DBD": "0x7FFB4EE147E0", "m_3FF": "0x7FFB4EE14880",
    "m_B4E": "0x7FFB4EE14A70", "m_B78": "0x7FFB4EE14B10", "m_21C": "0x7FFB4EE16FE0",
    "m_84F": "0x7FFB4EE14CB0", "m_4C7": "0x7FFB4EDD80F0", "m_690": "0x7FFB4EE154C0",
    "m_A0D": "0x7FFB4EE15560", "m_EC3": "0x7FFB4EE15650", "m_B0A": "0x7FFB4EE15670",
    "m_2B1": "0x7FFB4EE15690", "m_ED7": "0x7FFB4EE15730", "m_A6F": "0x7FFB4EE15820",
    "m_706": "0x7FFB4EE15830", "m_7AC": "0x7FFB4E5EF0F0", "m_BCA": "0x7FFB4EE15970",
    "m_23E": "0x7FFB4EE16190", "m_1F1": "0x7FFB4EE162C0", "m_0E6": "0x7FFB4EE16360",
    "m_1CD": "0x7FFB4EE16580", "m_FA6": "0x7FFB4EE16670", "m_2ED": "0x7FFB4EE167E0",
    "m_687": "0x7FFB4EE16880", "m_937": "0x7FFB4EE16E70",
};
for (var n in fm_vas) {
    FM_RVA_MAP[n] = uint64(fm_vas[n]).sub(DUMP_BASE).toNumber();
}

// ═══════════════════════════════════════════════════
// HOOK 1: Init function — capture GoHome pointer + FlowManager instance
// ═══════════════════════════════════════════════════
try {
    Interceptor.attach(BASE.add(RVA.INIT), {
        onEnter: function(args) {
            var fm = args[0];  // rcx = FlowManager this
            flowManagerPtr = fm;
            msg("Init called! FlowManager @ " + fm);

            try {
                var offlineFlag = fm.add(0x158).readU8();
                msg("  +0x158 (offline) = " + offlineFlag);
            } catch(e) {}

            // Read vtable to find GoHome
            try {
                var klass = fm.readPointer();
                var vt298 = klass.add(0x298).readPointer();
                var vt2A0 = klass.add(0x2A0).readPointer();
                var vt2C8 = klass.add(0x2C8).readPointer();

                goHomeAddr = vt298;
                goHomeMethodInfo = vt2A0;
                goHomeRVA = vt298.sub(BASE).toNumber();

                msg("  GoHome addr = " + vt298 + " (RVA 0x" + goHomeRVA.toString(16) + ")");
                msg("  MethodInfo  = " + vt2A0);
                msg("  Coroutine   = " + vt2C8 + " (RVA 0x" + vt2C8.sub(BASE).toNumber().toString(16) + ")");

                // Match to known method names
                for (var mname in FM_RVA_MAP) {
                    if (FM_RVA_MAP[mname] === goHomeRVA) {
                        msg("  ** GoHome = FlowManager." + mname);
                    }
                }

                // Hook GoHome itself to trace when it's called
                hookGoHome(vt298, goHomeRVA);

            } catch(e) {
                msg("  vtable read error: " + e);
            }
        }
    });
    msg("Hook: Init @ " + BASE.add(RVA.INIT));
} catch(e) {
    msg("WARN: Init hook failed: " + e);
}

// ═══════════════════════════════════════════════════
// HOOK 2: OnConnectedToMaster — Photon ready → re-trigger GoHome
// ═══════════════════════════════════════════════════
function hookOnConnected(rva, name) {
    try {
        Interceptor.attach(BASE.add(rva), {
            onEnter: function(args) {
                if (!photonConnected) {
                    photonConnected = true;
                    msg(">>> " + name + " — Photon CONNECTED!");

                    // Strategy: call GoHome directly now
                    if (goHomeAddr && flowManagerPtr) {
                        msg("[*] Attempting to call GoHome now...");
                        setTimeout(function() {
                            retriggerGoHome();
                        }, 2000);  // Small delay to let Photon settle
                    } else {
                        msg("[!] Cannot re-trigger: goHome=" + goHomeAddr + " fm=" + flowManagerPtr);
                    }
                }
            }
        });
        msg("Hook: " + name + " @ " + BASE.add(rva));
    } catch(e) {
        msg("WARN: " + name + " hook failed: " + e);
    }
}

hookOnConnected(RVA.ON_CONNECTED, "PhotonConnectionHandler_34AB.OnConnectedToMaster");
hookOnConnected(RVA.ON_CONNECTED_2, "PhotonConnectionHandler_E3E5.OnConnectedToMaster");

// ═══════════════════════════════════════════════════
// HOOK 3: m_A16 — capture the data arg for later replay
// ═══════════════════════════════════════════════════
try {
    Interceptor.attach(BASE.add(RVA.M_A16), {
        onEnter: function(args) {
            flowManagerPtr = args[0];
            initDataPtr = args[1];   // struct pointer with world data
            initFlags = args[2].toInt32();
            msg("m_A16 called: this=" + args[0] + " data=" + args[1] + " flags=" + args[2]);

            // Save data for later replay
            try {
                // Copy the 0x28 byte data struct so it survives
                var dataCopy = Memory.alloc(0x30);
                Memory.copy(dataCopy, args[1], 0x28);
                initDataPtr = dataCopy;
                msg("  Saved init data (0x28 bytes) for replay");
            } catch(e) {
                msg("  Cannot save data: " + e);
            }
        }
    });
    msg("Hook: m_A16 @ " + BASE.add(RVA.M_A16));
} catch(e) {
    msg("WARN: m_A16 hook failed: " + e);
}

// ═══════════════════════════════════════════════════
// GoHome hook — trace calls
// ═══════════════════════════════════════════════════
var goHomeHooked = false;
function hookGoHome(addr, rva) {
    if (goHomeHooked) return;
    goHomeHooked = true;
    try {
        Interceptor.attach(addr, {
            onEnter: function(args) {
                msg(">>> GoHome called! (RVA 0x" + rva.toString(16) + ")");
                msg("    this=" + args[0] + " arg1=" + args[1] + " arg2=" + args[2]);
                msg("    Photon=" + (photonConnected ? "CONNECTED" : "NOT connected"));
            },
            onLeave: function(retval) {
                msg("<<< GoHome returned: " + retval);
            }
        });
        msg("Hook: GoHome @ " + addr + " (RVA 0x" + rva.toString(16) + ")");
    } catch(e) {
        msg("WARN: GoHome hook failed: " + e);
    }
}

// ═══════════════════════════════════════════════════
// Re-trigger GoHome after Photon connects
// ═══════════════════════════════════════════════════
function retriggerGoHome() {
    if (!goHomeAddr || !flowManagerPtr) {
        msg("Cannot retrigger: missing pointers");
        return;
    }

    msg("=== RE-TRIGGERING GoHome (Photon is connected) ===");

    // Method 1: Call GoHome directly
    // GoHome signature: ptr GoHome(FlowManager* this, int flags, MethodInfo* methodInfo)
    // From the call site: rcx=this, edx=flags([rdi+0x40]), r8=MethodInfo
    try {
        var goHome = new NativeFunction(goHomeAddr, 'pointer', ['pointer', 'int', 'pointer']);
        var flags = 0;
        // Read current flags from the FlowManager context if possible
        try {
            // The flags come from [rdi+0x40] in init, but rdi is a local variable there
            // Use 0 as default
            flags = 0;
        } catch(e) {}

        var methodInfo = goHomeMethodInfo || ptr(0);
        msg("Calling GoHome(" + flowManagerPtr + ", " + flags + ", " + methodInfo + ")");
        var result = goHome(flowManagerPtr, flags, methodInfo);
        msg("GoHome result: " + result);

        // Method 2: If GoHome returned a result, pass it to the post-call function
        if (!result.isNull()) {
            try {
                var postFunc = new NativeFunction(BASE.add(RVA.POST_GOHOME), 'void', ['pointer', 'pointer', 'pointer']);
                msg("Calling post-GoHome function with result...");
                postFunc(flowManagerPtr, result, ptr(0));
                msg("Post-GoHome done!");
            } catch(e) {
                msg("Post-GoHome failed: " + e);
            }
        }
    } catch(e) {
        msg("GoHome direct call failed: " + e);

        // Method 2: Try re-invoking m_A16 with saved data
        if (initDataPtr) {
            msg("Trying m_A16 replay instead...");
            try {
                var m_a16 = new NativeFunction(BASE.add(RVA.M_A16), 'void', ['pointer', 'pointer', 'int']);
                m_a16(flowManagerPtr, initDataPtr, initFlags);
                msg("m_A16 replay done!");
            } catch(e2) {
                msg("m_A16 replay failed: " + e2);
            }
        }
    }
}

// ═══════════════════════════════════════════════════
// Awake hook — trace startup
// ═══════════════════════════════════════════════════
try {
    Interceptor.attach(BASE.add(RVA.AWAKE), {
        onEnter: function(args) {
            msg("FlowManager.Awake()");
        }
    });
} catch(e) {}

// ═══════════════════════════════════════════════════
// Monitor
// ═══════════════════════════════════════════════════
var monitorN = 0;
var monitor = setInterval(function() {
    monitorN++;
    msg("Status: Photon=" + (photonConnected ? "YES" : "no") +
        " GoHome=" + (goHomeRVA ? "0x" + goHomeRVA.toString(16) : "?") +
        " FM=" + (flowManagerPtr ? flowManagerPtr : "?"));
    if (monitorN >= 24) {
        clearInterval(monitor);
        msg("Monitor timeout (2 min)");
    }
    if (photonConnected && goHomeRVA) {
        msg("=== DONE: GoHome RVA=0x" + goHomeRVA.toString(16) + ", Photon=connected ===");
        clearInterval(monitor);
    }
}, 5000);

msg("=== VRChat GoHome Finder + Timing Fix v4 ===");
msg("Hooks: Init, m_A16, GoHome, OnConnected");
msg("On Photon connect -> re-trigger GoHome");
