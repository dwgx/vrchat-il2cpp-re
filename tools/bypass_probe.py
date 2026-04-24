#!/usr/bin/env python3
"""Probe why VRChat.exe self-kills when launched directly.

Step 1: Spawn VRChat.exe suspended via Frida.
Step 2: Inject a tiny Interceptor that logs every loaded DLL and the
        first ExitProcess / TerminateProcess call.
Step 3: Resume. Watch for self-kill trigger within ~30s.

This only probes — does not try to bypass yet.
"""
import frida, sys, time, os
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

VRCHAT_EXE = r'D:\WorkSpace\VRChat\VRChat.exe'
VRCHAT_CWD = r'D:\WorkSpace\VRChat'

HOOK_JS = r"""
'use strict';

function log(msg) { send({t:'log', m: String(msg)}); }

function dumpBacktrace(ctx) {
    try {
        var bt = Thread.backtrace(ctx, Backtracer.ACCURATE).slice(0, 12);
        bt.forEach(function(addr) {
            var m = Process.findModuleByAddress(addr);
            var line = '   ' + addr;
            if (m) line += '  [' + m.name + '+0x' + addr.sub(m.base).toString(16) + ']';
            log(line);
        });
    } catch(e) { log('   (backtrace failed: ' + e.message + ')'); }
}

// ONLY hook process-exit paths. Do NOT hook LoadLibrary (too hot).
var ntExit = Module.findGlobalExportByName('ntdll.dll', 'RtlExitUserProcess');
if (ntExit) {
    Interceptor.attach(ntExit, {
        onEnter: function(args) {
            log('>>> RtlExitUserProcess(code=0x' + args[0].toString(16) + ')');
            dumpBacktrace(this.context);
        }
    });
}

var kExit = Module.findGlobalExportByName('kernel32.dll', 'ExitProcess');
if (kExit) {
    Interceptor.attach(kExit, {
        onEnter: function(args) {
            log('>>> ExitProcess(code=0x' + args[0].toString(16) + ')');
            dumpBacktrace(this.context);
        }
    });
}

var kTerm = Module.findGlobalExportByName('kernel32.dll', 'TerminateProcess');
if (kTerm) {
    Interceptor.attach(kTerm, {
        onEnter: function(args) {
            var h = args[0].toInt32();
            // -1 = current process pseudo-handle
            var self = (h === -1 || h === 0xFFFFFFFF);
            log('>>> TerminateProcess(h=' + (self ? 'SELF' : h) + ', code=0x' + args[1].toString(16) + ')');
            dumpBacktrace(this.context);
        }
    });
}

// Also catch NtTerminateProcess (Windows kernel gate — everything ends here)
var ntTerm = Module.findGlobalExportByName('ntdll.dll', 'NtTerminateProcess');
if (ntTerm) {
    Interceptor.attach(ntTerm, {
        onEnter: function(args) {
            var h = args[0].toInt32();
            var self = (h === 0 || h === -1 || h === 0xFFFFFFFF);
            log('>>> NtTerminateProcess(h=' + (self ? 'SELF' : h) + ', status=0x' + args[1].toString(16) + ')');
            dumpBacktrace(this.context);
        }
    });
}

log('hook installed (minimal: exit paths only)');
"""

def on_message(msg, data):
    if msg.get('type') == 'send':
        p = msg.get('payload', {})
        if p.get('t') == 'log':
            print(p.get('m'), flush=True)
    elif msg.get('type') == 'error':
        print('[ERR]', msg.get('description'), flush=True)


def main():
    print(f'[probe] spawning {VRCHAT_EXE} --no-vr ...', flush=True)
    try:
        pid = frida.spawn([VRCHAT_EXE, '--no-vr'], cwd=VRCHAT_CWD)
        print(f'[probe] spawned pid={pid}', flush=True)
    except Exception as e:
        print(f'[probe] spawn failed: {e}', flush=True)
        return 1

    try:
        session = frida.attach(pid)
        print('[probe] attached', flush=True)
    except Exception as e:
        print(f'[probe] attach failed: {e}', flush=True)
        try: frida.kill(pid)
        except: pass
        return 1

    script = session.create_script(HOOK_JS)
    script.on('message', on_message)
    script.load()
    print('[probe] hook loaded, resuming...', flush=True)
    frida.resume(pid)

    # Watch for 30s — if process still alive after that, success
    start = time.time()
    while time.time() - start < 45:
        time.sleep(1)
        try:
            # probe still alive
            session.detach  # just access
            import psutil
            if not psutil.pid_exists(pid):
                print(f'[probe] process DIED at t={time.time()-start:.1f}s', flush=True)
                return 2
        except Exception as e:
            print(f'[probe] session broken: {e}', flush=True)
            return 3
    print(f'[probe] process STILL ALIVE after 45s — bypass idea might work!', flush=True)
    return 0


if __name__ == '__main__':
    sys.exit(main())
