/**
 * Frida Retrigger GoHome v4b
 *
 * Attach to a RUNNING VRChat (already in Error World, Photon already connected).
 * Find FlowManager instance via its Il2CppClass pointer, read GoHome from vtable,
 * and invoke it to transition from Error World to the real home world.
 *
 * Usage: frida -p <PID> -l tools/frida_retrigger_gohome.js
 */
'use strict';

var ga = Process.getModuleByName("GameAssembly.dll");
var BASE = ga.base;

function msg(t) { send(t); }

// FlowManager Il2CppClass VA from dump: 0x33757620
// This is a HEAP address — stable across ASLR (code changes, heap doesn't)
var FM_KLASS_VA = ptr("0x33757620");

msg("=== GoHome Retrigger v4b ===");
msg("GA base: " + BASE);

// Step 1: Verify FlowManager klass is valid
var klassName = "";
try {
    // Il2CppClass+0x58 = name (char*)
    var namePtr = FM_KLASS_VA.add(0x58).readPointer();
    klassName = namePtr.readCString();
    msg("FlowManager klass name: " + klassName);
} catch(e) {
    msg("ERROR: Cannot read FlowManager klass at " + FM_KLASS_VA + ": " + e);
    msg("The klass VA might have changed. Need to find it via GC scan.");
}

// Step 2: Read vtable to find GoHome method
var goHomeAddr = null;
var goHomeMethodInfo = null;
try {
    // vtable+0x298 = GoHome, vtable+0x2A0 = MethodInfo
    goHomeAddr = FM_KLASS_VA.add(0x298).readPointer();
    goHomeMethodInfo = FM_KLASS_VA.add(0x2A0).readPointer();
    var goHomeRVA = goHomeAddr.sub(BASE).toNumber();
    msg("GoHome addr: " + goHomeAddr + " (RVA 0x" + goHomeRVA.toString(16) + ")");
    msg("MethodInfo:  " + goHomeMethodInfo);

    // Verify it looks like a valid code pointer (should be in GA range)
    if (goHomeRVA > 0 && goHomeRVA < 0x10000000) {
        // Read first bytes to verify it's code
        var prologue = goHomeAddr.readByteArray(4);
        msg("GoHome prologue: " + Array.from(new Uint8Array(prologue)).map(b => b.toString(16).padStart(2,'0')).join(' '));
    } else {
        msg("WARNING: GoHome RVA looks invalid, vtable might not be at +0x298");
    }
} catch(e) {
    msg("ERROR reading vtable: " + e);
}

// Step 3: Find FlowManager INSTANCE
// The klass has static fields info. FlowManager has a singleton at field_Private_Static_VRCFlowManager_0
// In Il2CppClass, static fields are at +0xB8 (static_fields pointer)
var flowManagerInstance = null;
try {
    var staticFields = FM_KLASS_VA.add(0xB8).readPointer();
    msg("Static fields ptr: " + staticFields);
    if (!staticFields.isNull()) {
        // The singleton is likely the first static field (offset 0)
        // Try reading it as a pointer
        flowManagerInstance = staticFields.readPointer();
        msg("FlowManager instance (static[0]): " + flowManagerInstance);

        // Verify: instance's klass pointer should point back to FM_KLASS_VA
        if (!flowManagerInstance.isNull()) {
            var instKlass = flowManagerInstance.readPointer();
            if (instKlass.equals(FM_KLASS_VA)) {
                msg("[OK] Instance klass matches FlowManager!");
            } else {
                msg("Instance klass: " + instKlass + " (doesn't match, trying other offsets)");
                // Try other static field offsets
                for (var off = 0x8; off <= 0x40; off += 0x8) {
                    var candidate = staticFields.add(off).readPointer();
                    if (!candidate.isNull()) {
                        try {
                            var ck = candidate.readPointer();
                            if (ck.equals(FM_KLASS_VA)) {
                                flowManagerInstance = candidate;
                                msg("[OK] Found FM instance at static+" + off.toString(16) + ": " + candidate);
                                break;
                            }
                        } catch(e2) {}
                    }
                }
            }
        }
    }
} catch(e) {
    msg("ERROR finding FM instance: " + e);
}

// Step 4: Check Photon connection state
if (flowManagerInstance && !flowManagerInstance.isNull()) {
    try {
        var offlineFlag = flowManagerInstance.add(0x158).readU8();
        msg("+0x158 (offline flag): " + offlineFlag + (offlineFlag ? " (ONLINE)" : " (offline)"));
    } catch(e) {}
}

// Step 5: Call GoHome!
if (goHomeAddr && flowManagerInstance && !flowManagerInstance.isNull()) {
    msg("");
    msg("=== CALLING GoHome ===");
    msg("FlowManager: " + flowManagerInstance);
    msg("GoHome:      " + goHomeAddr);
    msg("MethodInfo:  " + goHomeMethodInfo);

    try {
        // GoHome signature: pointer GoHome(this, int flags, MethodInfo*)
        // flags = [rdi+0x40] from init context, but we don't have rdi.
        // Try with flags=0 first
        var goHome = new NativeFunction(goHomeAddr, 'pointer', ['pointer', 'int', 'pointer']);

        msg("Calling GoHome(fm, 0, methodInfo)...");
        var result = goHome(flowManagerInstance, 0, goHomeMethodInfo);
        msg("GoHome returned: " + result);

        if (!result.isNull()) {
            msg("[OK] GoHome returned a non-null result! World join should be in progress.");

            // Call the post-GoHome function to process the result
            try {
                var postFunc = new NativeFunction(BASE.add(0x7474870), 'void', ['pointer', 'pointer', 'pointer']);
                msg("Calling post-GoHome processor...");
                postFunc(flowManagerInstance, result, ptr(0));
                msg("Post-GoHome done!");
            } catch(e) {
                msg("Post-GoHome failed (might be OK): " + e);
            }
        } else {
            msg("GoHome returned null. Trying with different flags...");
            // Try flags = 0x400 (EAC flag set)
            result = goHome(flowManagerInstance, 0x400, goHomeMethodInfo);
            msg("GoHome(flags=0x400) returned: " + result);
        }
    } catch(e) {
        msg("GoHome call FAILED: " + e);
        msg("Trying alternative: call m_A16 instead...");

        // Alternative: find and call m_A16
        // m_A16 RVA = 0x1921EF0
        try {
            var m_a16 = new NativeFunction(BASE.add(0x1921EF0), 'void', ['pointer', 'pointer', 'int']);
            // We need the data struct. Try with null (might crash)
            msg("WARNING: Calling m_A16 with null data, might crash!");
            // Don't actually call this without data - too risky
        } catch(e2) {
            msg("m_A16 also failed: " + e2);
        }
    }
} else {
    msg("");
    msg("[!] Cannot call GoHome: missing FM instance or GoHome pointer");
    msg("    Try using il2cpp_gc_choose via MCP to find FlowManager instances");
}

msg("");
msg("=== Script complete ===");
