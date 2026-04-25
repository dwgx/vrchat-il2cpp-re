#!/usr/bin/env python3
"""Attach to an already-running VRChat and inspect what it's waiting on."""
import frida, sys, time

sys.stdout.reconfigure(encoding='utf-8')

JS = r"""
'use strict';
function log(m){ send({m:String(m)}); }

log('=== MODULES ===');
Process.enumerateModules().forEach(function(m) {
    if (/VRChat|Unity|Mono|il2cpp|Melon|EAC|EasyAnti|GameAssembly/i.test(m.name)) {
        log('  ' + m.name + '  base=' + m.base + '  size=0x' + m.size.toString(16));
    }
});

log('=== THREADS (state + top frame) ===');
Process.enumerateThreads().forEach(function(t, i) {
    var top = '?';
    try {
        var bt = Thread.backtrace(t.context || null, Backtracer.FUZZY);
        if (bt.length > 0) {
            var addr = bt[0];
            var m = Process.findModuleByAddress(addr);
            top = addr + (m ? ('  [' + m.name + '+0x' + addr.sub(m.base).toString(16) + ']') : '');
        }
    } catch(e) { top = 'err:' + e.message.substring(0,50); }
    log('  T' + i + '  tid=' + t.id + '  state=' + t.state + '  top=' + top);
});

// Inspect first 3 threads' deeper backtrace
log('=== DEEP BACKTRACE (first 5 threads) ===');
Process.enumerateThreads().slice(0, 5).forEach(function(t, i) {
    log('-- T' + i + ' tid=' + t.id + ' --');
    try {
        var bt = Thread.backtrace(t.context || null, Backtracer.FUZZY).slice(0, 8);
        bt.forEach(function(addr){
            var m = Process.findModuleByAddress(addr);
            log('    ' + addr + (m ? ('  [' + m.name + '+0x' + addr.sub(m.base).toString(16) + ']') : ''));
        });
    } catch(e) { log('    err: ' + e.message); }
});
"""

def main():
    pid = int(sys.argv[1]) if len(sys.argv) > 1 else None
    try:
        session = frida.attach('VRChat.exe' if pid is None else pid)
    except Exception as e:
        print(f'attach failed: {e}')
        return 1
    print(f'attached to VRChat')
    sc = session.create_script(JS)
    sc.on('message', lambda m, d: print(m.get('payload', {}).get('m', m), flush=True))
    sc.load()
    time.sleep(2)
    session.detach()
    return 0

if __name__ == '__main__':
    sys.exit(main())
