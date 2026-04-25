#!/usr/bin/env python3
"""
Auto-launch VRChat + Frida: wait for Photon, then trigger GoHome.

Flow:
1. Launch VRChat via bypass launcher
2. Attach Frida once GameAssembly.dll is loaded
3. Hook OnConnectedToMaster to know when Photon is ready
4. Once in Error World + Photon connected, find FlowManager instance
5. Leave Error World room, then start GoHome coroutine on main thread

Usage: python tools/frida_auto_gohome.py
"""
import subprocess, time, frida, sys, os

sys.stdout.reconfigure(encoding='utf-8')

STEAM_DIR = r"D:\Steam\steamapps\common\VRChat"
LAUNCH_EXE = os.path.join(STEAM_DIR, "launch.exe")

# Key RVAs (from binary analysis)
RVA_ON_CONNECTED_MASTER = 0x19572F0
RVA_ON_CONNECTED_E3E5 = 0x211A830
RVA_SET_CONNECT_ERROR = 0x1943BC0
RVA_GOHOME_M935 = 0x1924340  # FlowManager.m_935 = GoHome
FM_KLASS_VA = "0x33757620"

RVA_FM_AWAKE = 0x1921E50
RVA_FM_M_A16 = 0x1921EF0

FRIDA_SCRIPT = r"""
'use strict';

var ga = Process.getModuleByName("GameAssembly.dll");
var BASE = ga.base;
var FM_KLASS = ptr("__FM_KLASS__");

// State
var photonConnectCount = 0;
var goHomeTriggered = false;
var fmInstance = null;

function log(t) { send({type:'log', msg:t}); }
function done(ok, msg) { send({type:'done', ok:ok, msg:msg}); }

// ─── Find FlowManager instance via heap scan ───
function findFlowManager() {
    var areas = [
        [ptr("0x290000000"), 0x2000000],
        [ptr("0x298000000"), 0x2000000],
        [ptr("0x2A0000000"), 0x2000000],
        [ptr("0x2B0000000"), 0x2000000],
        [ptr("0x2B6000000"), 0x2000000],
    ];
    for (var i = 0; i < areas.length; i++) {
        var base = areas[i][0]; var size = areas[i][1];
        for (var off = 0; off < size; off += 0x10) {
            try {
                if (base.add(off).readPointer().equals(FM_KLASS)) {
                    return base.add(off);
                }
            } catch(e) {
                off += 0x1000 - (off % 0x1000) - 0x10;
            }
        }
    }
    return null;
}

// ─── Trigger GoHome on main thread ───
function triggerGoHome() {
    if (goHomeTriggered) return;
    goHomeTriggered = true;

    if (!fmInstance) {
        log("Finding FlowManager instance...");
        fmInstance = findFlowManager();
        if (!fmInstance) {
            done(false, "FlowManager instance not found");
            return;
        }
        log("FlowManager instance: " + fmInstance);
    }

    var klass = fmInstance.readPointer();
    var goHomeAddr = klass.add(0x298).readPointer();
    var goHomeMI = klass.add(0x2A0).readPointer();
    log("GoHome: " + goHomeAddr);

    // Resolve StartCoroutineManaged2
    var startCoroutineAddr = null;
    // Check if cached from a previous session
    try {
        // The post-processor at RVA 0x7474870 caches it
        // Second cache: rip+0x516C83F from 0x74748C1
        // Absolute: BASE + 0xC5E1100
        startCoroutineAddr = BASE.add(0xC5E1100).readPointer();
        if (startCoroutineAddr.isNull()) startCoroutineAddr = null;
    } catch(e) {}

    if (!startCoroutineAddr) {
        log("StartCoroutineManaged2 not cached, trying to resolve...");
        // Call the post-processor's resolution path
        // 0x9F9100 resolves native by name
        var resolver = new NativeFunction(BASE.add(0x9F9100), 'pointer', ['pointer']);
        // The name "UnityEngine.MonoBehaviour::StartCoroutineManaged2(System.Collections.IEnumerator)"
        // is at BASE + 0x9F89760
        var namePtr = BASE.add(0x9F89760);
        startCoroutineAddr = resolver(namePtr);
        log("Resolved StartCoroutineManaged2: " + startCoroutineAddr);
    }

    if (!startCoroutineAddr || startCoroutineAddr.isNull()) {
        done(false, "Cannot resolve StartCoroutineManaged2");
        return;
    }

    log("StartCoroutineManaged2: " + startCoroutineAddr);

    // Hook the error-state-setter (main thread, runs ~140/sec) to execute GoHome
    var hookAddr = BASE.add(__RVA_SET_CONNECT_ERROR__);
    var goHome = new NativeFunction(goHomeAddr, 'pointer', ['pointer', 'int', 'pointer']);
    var startCoro = new NativeFunction(startCoroutineAddr, 'pointer', ['pointer', 'pointer']);

    var phase = 0; // 0=create coroutine, 1=done
    Interceptor.attach(hookAddr, {
        onEnter: function(args) {
            if (phase > 0) return;
            phase = 1;
            try {
                log("[MainThread] Creating GoHome coroutine...");
                var coroutine = goHome(fmInstance, 0x1400, goHomeMI);
                log("[MainThread] Coroutine: " + coroutine);
                log("[MainThread] Starting coroutine...");
                var handle = startCoro(fmInstance, coroutine);
                log("[MainThread] Coroutine handle: " + handle);
                done(true, "GoHome coroutine started on main thread!");
            } catch(e) {
                log("[MainThread] ERROR: " + e);
                done(false, "Main thread GoHome failed: " + e);
            }
        }
    });

    log("Hook installed, waiting for main thread callback...");
}

// ─── Hook OnConnectedToMaster ───
function hookPhoton() {
    var addrs = [
        BASE.add(__RVA_ON_CONNECTED__),
        BASE.add(__RVA_ON_CONNECTED_2__)
    ];
    for (var i = 0; i < addrs.length; i++) {
        (function(addr) {
            try {
                Interceptor.attach(addr, {
                    onEnter: function() {
                        photonConnectCount++;
                        log(">>> Photon OnConnectedToMaster #" + photonConnectCount);
                        if (photonConnectCount >= 2) {
                            log("Second connect! Ready to GoHome.");
                            checkAndTrigger();
                        }
                    }
                });
            } catch(e) {}
        })(addrs[i]);
    }
    log("Photon hooks installed");
}

// ─── Hook FlowManager.Awake to capture instance ───
function hookAwake() {
    try {
        Interceptor.attach(BASE.add(__RVA_FM_AWAKE__), {
            onEnter: function(args) {
                if (!fmInstance) {
                    fmInstance = args[0];
                    log(">>> FlowManager.Awake! Instance=" + fmInstance);
                    // Don't checkAndTrigger yet - wait for 2nd Photon connect
                }
            }
        });
        log("Awake hook installed");
    } catch(e) { log("Awake hook failed: " + e); }

    // Also hook m_A16 as backup
    try {
        Interceptor.attach(BASE.add(__RVA_FM_M_A16__), {
            onEnter: function(args) {
                if (!fmInstance) {
                    fmInstance = args[0];
                    log(">>> FlowManager.m_A16! Instance=" + fmInstance);
                }
            }
        });
    } catch(e) {}
}

// ─── Check if both conditions met ───
function checkAndTrigger() {
    if (goHomeTriggered) return;
    if (photonConnectCount >= 2 && fmInstance) {
        log("Both conditions met! Triggering GoHome in 3s...");
        setTimeout(function() { triggerGoHome(); }, 3000);
    }
}

// ─── Startup ───
hookAwake();
hookPhoton();
log("=== VRChat Auto-GoHome ===");
log("Waiting for Awake + Photon connection...");

// Fallback: if hooks missed, try heap scan after 45s
setTimeout(function() {
    if (!goHomeTriggered) {
        if (!fmInstance) {
            log("Timer: 45s. Trying heap scan for FM...");
            fmInstance = findFlowManager();
            if (fmInstance) log("Found FM via scan: " + fmInstance);
        }
        if (photonConnectCount < 2) {
            log("Timer: 45s. Assuming Photon connected x2.");
            photonConnectCount = 2;
        }
        triggerGoHome();
    }
}, 45000);
""".replace("__FM_KLASS__", FM_KLASS_VA) \
   .replace("__RVA_ON_CONNECTED__", hex(RVA_ON_CONNECTED_MASTER)) \
   .replace("__RVA_ON_CONNECTED_2__", hex(RVA_ON_CONNECTED_E3E5)) \
   .replace("__RVA_SET_CONNECT_ERROR__", hex(RVA_SET_CONNECT_ERROR)) \
   .replace("__RVA_FM_AWAKE__", hex(RVA_FM_AWAKE)) \
   .replace("__RVA_FM_M_A16__", hex(RVA_FM_M_A16))


def main():
    print("[*] Launching VRChat...")
    subprocess.Popen([LAUNCH_EXE], cwd=STEAM_DIR)

    print("[*] Waiting for VRChat + GameAssembly.dll...")
    device = frida.get_local_device()
    pid = None
    for attempt in range(60):
        time.sleep(1)
        try:
            for p in device.enumerate_processes():
                if p.name == 'VRChat.exe':
                    pid = p.pid
                    break
            if pid:
                session = device.attach(pid)
                probe = session.create_script(
                    'try{Process.getModuleByName("GameAssembly.dll");send("ok")}catch(e){send("wait")}'
                )
                result = []
                probe.on('message', lambda m, d: result.append(m.get('payload', '')))
                probe.load()
                time.sleep(0.5)
                probe.unload()
                session.detach()
                if 'ok' in result:
                    print(f"[+] VRChat PID={pid}, GA loaded at +{attempt+1}s")
                    break
                pid = None
        except Exception:
            pid = None

    if not pid:
        print("[!] Timeout waiting for VRChat")
        return

    print(f"[*] Attaching Frida to PID {pid}...")
    session = device.attach(pid)
    script = session.create_script(FRIDA_SCRIPT)

    result_event = {'done': False, 'ok': False, 'msg': ''}

    def on_message(message, data):
        payload = message.get('payload', {})
        if isinstance(payload, dict):
            if payload.get('type') == 'log':
                msg = payload.get('msg', '')
                safe = ''.join(c if ord(c) < 128 else '?' for c in msg)
                print(f"  {safe}")
            elif payload.get('type') == 'done':
                result_event['done'] = True
                result_event['ok'] = payload.get('ok', False)
                result_event['msg'] = payload.get('msg', '')
                safe = ''.join(c if ord(c) < 128 else '?' for c in result_event['msg'])
                status = "OK" if result_event['ok'] else "FAIL"
                print(f"[{status}] {safe}")
        elif message.get('type') == 'error':
            print(f"[ERR] {message.get('description', '')[:200]}")

    script.on('message', on_message)
    script.load()
    print("[*] Script loaded. Waiting up to 120s for GoHome...")

    for _ in range(120):
        time.sleep(1)
        if result_event['done']:
            break

    if result_event['ok']:
        print("\n[*] GoHome triggered! Monitoring for 30s...")
        time.sleep(30)
        # Check VRChat log for world transition
        import glob
        logs = sorted(glob.glob(
            os.path.expandvars(r"%LOCALAPPDATA%\..\LocalLow\VRChat\VRChat\output_log_*.txt")
        ))
        if logs:
            with open(logs[-1], 'r', encoding='utf-8', errors='ignore') as f:
                lines = f.readlines()
            recent = [l.strip() for l in lines[-30:] if any(k in l for k in
                      ['Destination', 'Entering Room', 'Failed to join', 'Going to',
                       'Successfully joined', 'room transition'])]
            print("\n[*] Recent VRChat log:")
            for l in recent:
                print(f"  {l}")
    else:
        print(f"\n[!] GoHome not triggered: {result_event['msg']}")

    print("\n[*] Done. VRChat is still running.")


if __name__ == '__main__':
    main()
