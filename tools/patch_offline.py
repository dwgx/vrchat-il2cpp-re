#!/usr/bin/env python3
"""
Patch VRChat's offline testing mode checks.
Applies 4 patches to bypass all offline testing mode restrictions:

1. Location.get_isOffline → always returns false
2. Location.set_isOffline → no-op
3. API.IsOffline → always returns false
4. Photon connection class offline flag check → skip branch

Usage:
  python tools/patch_offline.py
  python tools/patch_offline.py --attach   # attach to running process instead of spawn
"""
import frida
import sys
import time
import subprocess
import os
import argparse

sys.stdout.reconfigure(encoding='utf-8')

VRCHAT_EXE = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(
    os.path.dirname(os.path.abspath(__file__))))), "VRChat.exe")

PATCH_SCRIPT = r"""
var ga = null;
var gaBase = null;
var patchCount = 0;

function waitForGA() {
    var attempts = 0;
    var checkInterval = setInterval(function() {
        attempts++;
        try {
            ga = Process.getModuleByName("GameAssembly.dll");
            if (ga) {
                clearInterval(checkInterval);
                gaBase = ga.base;
                console.log("[*] GameAssembly.dll at " + gaBase + " size=0x" + ga.size.toString(16));
                waitForInit();
            }
        } catch(e) {
            if (attempts % 50 === 0) console.log("[.] Waiting for GA... attempt " + attempts);
        }
    }, 100);
}

function waitForInit() {
    // Wait for IL2CPP classes to be initialized (check for a known pattern in .data)
    var attempts = 0;
    var checkInterval = setInterval(function() {
        attempts++;
        try {
            // Check if GA's writable sections are populated
            var ranges = Process.enumerateRanges('rw-');
            var gaEnd = gaBase.add(ga.size);
            var ready = false;
            for (var i = 0; i < ranges.length; i++) {
                var r = ranges[i];
                if (r.base.compare(gaBase) >= 0 && r.base.compare(gaEnd) < 0 && r.size > 0x100000) {
                    // Check if some static data is populated
                    try {
                        var testVal = r.base.add(0x1000).readPointer();
                        if (!testVal.isNull()) ready = true;
                    } catch(e2) {}
                }
            }
            if (ready || attempts > 100) {
                clearInterval(checkInterval);
                console.log("[*] GA initialized (attempt " + attempts + "), starting patches...");
                // Give a bit more time for all statics to initialize
                setTimeout(applyAllPatches, 2000);
            }
        } catch(e) {
            if (attempts % 20 === 0) console.log("[.] Waiting for init... " + attempts);
        }
    }, 200);
}

function scanForPattern(pattern, ranges) {
    var results = [];
    for (var i = 0; i < ranges.length; i++) {
        try {
            var matches = Memory.scanSync(ranges[i].base, ranges[i].size, pattern);
            for (var m = 0; m < matches.length; m++) {
                results.push(matches[m].address);
            }
        } catch(e) {}
    }
    return results;
}

function applyAllPatches() {
    var textRanges = [];
    var dataRanges = [];
    var gaEnd = gaBase.add(ga.size);

    var rxRanges = Process.enumerateRanges('r-x');
    for (var i = 0; i < rxRanges.length; i++) {
        var r = rxRanges[i];
        if (r.base.compare(gaBase) >= 0 && r.base.compare(gaEnd) < 0) {
            textRanges.push(r);
        }
    }

    var rwRanges = Process.enumerateRanges('rw-');
    for (var i = 0; i < rwRanges.length; i++) {
        var r = rwRanges[i];
        if (r.base.compare(gaBase) >= 0 && r.base.compare(gaEnd) < 0) {
            dataRanges.push(r);
        }
    }

    console.log("[*] Text ranges: " + textRanges.length + ", Data ranges: " + dataRanges.length);

    // === PATCH 1 & 2: Location.get_isOffline / set_isOffline ===
    // get_isOffline: 0f b6 41 20 c3 (movzx eax,[rcx+0x20]; ret)
    // set_isOffline follows at +0x10: 88 51 20 c3 (mov [rcx+0x20],dl; ret)
    patchLocationIsOffline(textRanges);

    // === PATCH 3: API.IsOffline ===
    // Pattern: sub rsp,28 ... cmp dword ptr [rax+0x20], 2; sete al; add rsp,28; ret
    // Unique pattern in the comparison: 83 78 20 02 0f 94 c0 48 83 c4 28 c3
    patchApiIsOffline(textRanges);

    // === PATCH 4: Offline flag in Photon connection class ===
    // Find callers of API.IsOffline and patch the secondary check
    patchOfflineFlag(textRanges, dataRanges);

    console.log("\n[*] Total patches applied: " + patchCount + "/4");
    if (patchCount >= 3) {
        console.log("[✓] Offline bypass should be active!");
        send({type: "patched", success: true, count: patchCount});
    } else {
        console.log("[!] Some patches failed - offline bypass may not work");
        send({type: "patched", success: false, count: patchCount});
    }
}

function patchLocationIsOffline(textRanges) {
    // Search for: 0f b6 41 20 c3 (movzx eax, byte ptr [rcx+0x20]; ret)
    // Verify setter at +0x10: 88 51 20 c3
    var pattern = "0f b6 41 20 c3";
    var matches = scanForPattern(pattern, textRanges);

    console.log("[1] Location.get_isOffline candidates: " + matches.length);

    for (var i = 0; i < matches.length; i++) {
        var addr = matches[i];
        // Verify setter at +0x10
        try {
            var setterBytes = new Uint8Array(addr.add(0x10).readByteArray(4));
            if (setterBytes[0] === 0x88 && setterBytes[1] === 0x51 && setterBytes[2] === 0x20 && setterBytes[3] === 0xC3) {
                // Found the right one!
                console.log("  [✓] get_isOffline at " + addr);

                // Patch getter: xor eax,eax; ret; nop; nop
                Memory.protect(addr, 8, 'rwx');
                addr.writeByteArray([0x31, 0xC0, 0xC3, 0x90, 0x90]);
                patchCount++;

                // Patch setter: ret; nop; nop; nop
                var setAddr = addr.add(0x10);
                Memory.protect(setAddr, 8, 'rwx');
                setAddr.writeByteArray([0xC3, 0x90, 0x90, 0x90]);
                patchCount++;

                console.log("  [✓] set_isOffline at " + setAddr + " (nop)");
                return;
            }
        } catch(e) {}
    }
    console.log("  [!] Could not find Location.get_isOffline");
}

function patchApiIsOffline(textRanges) {
    // API.IsOffline ends with: cmp dword ptr [rax+0x20], 2; sete al; add rsp,0x28; ret
    // Bytes: 83 78 20 02 0f 94 c0 48 83 c4 28 c3
    var pattern = "83 78 20 02 0f 94 c0 48 83 c4 28 c3";
    var matches = scanForPattern(pattern, textRanges);

    console.log("[3] API.IsOffline candidates: " + matches.length);

    for (var i = 0; i < matches.length; i++) {
        var cmpAddr = matches[i];
        // The method starts with: sub rsp, 0x28
        // Walk back to find the start (sub rsp, 0x28 = 48 83 ec 28)
        for (var back = 0x10; back <= 0x80; back++) {
            var candidate = cmpAddr.sub(back);
            try {
                var bytes = new Uint8Array(candidate.readByteArray(4));
                if (bytes[0] === 0x48 && bytes[1] === 0x83 && bytes[2] === 0xEC && bytes[3] === 0x28) {
                    // Check prev byte is CC or C3 (function boundary)
                    var prev = candidate.sub(1).readU8();
                    if (prev === 0xCC || prev === 0xC3) {
                        console.log("  [✓] API.IsOffline at " + candidate);
                        // Patch start: xor eax,eax; ret
                        Memory.protect(candidate, 8, 'rwx');
                        candidate.writeByteArray([0x31, 0xC0, 0xC3, 0x90, 0x90, 0x90, 0x90, 0x90]);
                        patchCount++;
                        return;
                    }
                }
            } catch(e) {}
        }
    }
    console.log("  [!] Could not find API.IsOffline");
}

function patchOfflineFlag(textRanges, dataRanges) {
    // Find callers of API.IsOffline first
    // API.IsOffline has pattern at its end: 83 78 20 02 0f 94 c0 48 83 c4 28 c3
    // But we already patched it. Let me find it by the patched bytes:
    // 31 c0 c3 90 90 90 90 90 followed by class init code

    // Better approach: find the caller that has the byte-check pattern:
    // mov rax, [rax + 0xb8]   = 48 8B 80 B8 00 00 00
    // cmp byte ptr [rax], 0   = 80 38 00
    // jne XX                  = 75 XX
    var pattern = "48 8b 80 b8 00 00 00 80 38 00 75";
    var matches = scanForPattern(pattern, textRanges);

    console.log("[4] Offline flag check candidates: " + matches.length);

    for (var i = 0; i < matches.length; i++) {
        var addr = matches[i];
        // The jne is at addr+10, patch it to nop nop (skip the branch)
        var jneAddr = addr.add(10);
        var jneBytes = new Uint8Array(jneAddr.readByteArray(2));
        if (jneBytes[0] === 0x75) {
            console.log("  [✓] Offline flag check at " + addr + ", jne at " + jneAddr);
            Memory.protect(jneAddr, 2, 'rwx');
            jneAddr.writeByteArray([0x90, 0x90]); // nop nop
            patchCount++;

            // Also try to find and zero the flag value
            try {
                // The mov rax, [rip+XX] instruction before our pattern loads the static
                // Go back to find it
                var scanBack = addr.sub(0x20);
                for (var b = 0; b < 0x30; b++) {
                    var a = scanBack.add(b);
                    var byte0 = a.readU8();
                    // Look for: mov rax, [rip + XX] = 48 8b 05 XX XX XX XX
                    if (byte0 === 0x48) {
                        var byte1 = a.add(1).readU8();
                        var byte2 = a.add(2).readU8();
                        if (byte1 === 0x8b && byte2 === 0x05) {
                            var ripOff = a.add(3).readS32();
                            var staticAddr = a.add(7).add(ripOff);
                            try {
                                var staticVal = staticAddr.readPointer();
                                var instance = staticVal.add(0xb8).readPointer();
                                var flagVal = instance.readU8();
                                if (flagVal === 1) {
                                    instance.writeU8(0);
                                    console.log("  [✓] Also zeroed flag at " + instance);
                                }
                            } catch(e) {}
                            break;
                        }
                    }
                }
            } catch(e) {}

            return;
        }
    }
    console.log("  [!] Could not find offline flag check");
}

// Start the patching process
waitForGA();
"""

def main():
    parser = argparse.ArgumentParser(description="VRChat Offline Mode Bypass")
    parser.add_argument('--attach', action='store_true', help='Attach to running process')
    args = parser.parse_args()

    print("=" * 60)
    print("  VRChat Offline Mode Bypass (4-patch)")
    print("=" * 60)

    device = frida.get_local_device()

    if args.attach:
        print("[*] Attaching to running VRChat...")
        session = device.attach("VRChat.exe")
        pid = None
    else:
        # Kill existing VRChat
        print("[*] Killing existing VRChat processes...")
        subprocess.run(["taskkill", "/f", "/im", "VRChat.exe"],
                       capture_output=True, timeout=5)
        time.sleep(2)

        print(f"[*] Spawning VRChat: {VRCHAT_EXE}")
        pid = device.spawn([VRCHAT_EXE, "--no-vr"])
        print(f"[*] Spawned PID: {pid}")

        session = device.attach(pid)

    print("[*] Attached to process")

    patched = [False]
    patch_count = [0]

    def on_message(message, data):
        if message['type'] == 'send':
            payload = message.get('payload', {})
            if isinstance(payload, dict) and payload.get('type') == 'patched':
                patched[0] = payload.get('success', False)
                patch_count[0] = payload.get('count', 0)
                print(f"[*] Patch result: {'SUCCESS' if patched[0] else 'PARTIAL'} ({patch_count[0]} patches)")
            else:
                print(f"  {payload}")
        elif message['type'] == 'error':
            print(f"[!] Script error: {message.get('description', message)}")
        else:
            payload = message.get('payload', '')
            if isinstance(payload, str):
                print(payload)

    script = session.create_script(PATCH_SCRIPT)
    script.on('message', on_message)
    script.load()

    if pid is not None:
        print("[*] Script loaded, resuming process...")
        device.resume(pid)

    print("[*] Waiting for patches to apply...")
    for i in range(120):  # up to 60 seconds
        time.sleep(0.5)
        if patched[0]:
            break

    if patched[0]:
        print("\n" + "=" * 60)
        print(f"  [✓] {patch_count[0]} patches applied successfully!")
        print("  VRChat should now bypass offline testing mode.")
        print("  Keep this script running to maintain the Frida session.")
        print("=" * 60)

        try:
            print("\nPress Ctrl+C to detach and exit...")
            while True:
                time.sleep(1)
        except KeyboardInterrupt:
            print("\n[*] Detaching...")
    else:
        print(f"[!] Patches incomplete ({patch_count[0]} applied)")
        print("[*] VRChat is still running, trying to continue...")
        try:
            while True:
                time.sleep(1)
        except KeyboardInterrupt:
            print("\n[*] Detaching...")

    session.detach()


if __name__ == '__main__':
    main()
