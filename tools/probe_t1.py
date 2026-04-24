#!/usr/bin/env python3
"""Deep dive on the VERSION.dll thread + list all modules."""
import frida, sys, time

sys.stdout.reconfigure(encoding='utf-8')

JS = r"""
'use strict';
function log(m){ send({m:String(m)}); }

log('=== ALL MODULES ===');
Process.enumerateModules().forEach(function(m){
    log('  ' + m.base + '  size=0x' + m.size.toString(16).padStart(8,'0') + '  ' + m.name + '  ' + (m.path || ''));
});

log('=== VERSION region check ===');
// 0x7fff52b6a9ec was seen — figure out what's actually mapped there
var probe = ptr('0x7fff52b6a9ec');
var range = Process.findRangeByAddress(probe);
if (range) {
    log('  range: base=' + range.base + ' size=0x' + range.size.toString(16) + ' prot=' + range.protection + ' file=' + (range.file ? range.file.path : 'none'));
}

log('=== DEEPER T1 ===');
// T1 index on previous run — re-enumerate
var threads = Process.enumerateThreads();
threads.forEach(function(t, i) {
    try {
        var bt = Thread.backtrace(t.context || null, Backtracer.FUZZY).slice(0, 20);
        // Only dump threads that touch VERSION.dll or non-UnityPlayer stuff
        var interesting = bt.some(function(addr){
            var m = Process.findModuleByAddress(addr);
            return m && /VERSION|EasyAnti|EAC|steam|Mono|il2cpp|Melon/i.test(m.name);
        });
        if (interesting) {
            log('-- T' + i + ' tid=' + t.id + ' --');
            bt.forEach(function(addr){
                var m = Process.findModuleByAddress(addr);
                log('    ' + addr + (m ? ('  [' + m.name + '+0x' + addr.sub(m.base).toString(16) + ']  ' + (m.path || '')) : ''));
            });
        }
    } catch(e) {}
});

// Check for steam_api64, EasyAntiCheat, MelonLoader
log('=== SEARCHES ===');
['steam_api64.dll','EasyAntiCheat_x64.dll','EOSSDK-Win64-Shipping.dll','version.dll','GameAssembly.dll','MelonLoader.NativeHost.dll','dobby.dll','bootstrap.dll','mono-2.0-bdwgc.dll'].forEach(function(n){
    var m = Process.findModuleByName(n);
    log('  ' + n + ' => ' + (m ? m.base + ' sz=0x' + m.size.toString(16) : 'NOT LOADED'));
});
"""

def main():
    pid = int(sys.argv[1])
    try:
        session = frida.attach(pid)
    except Exception as e:
        print(f'attach failed: {e}')
        return 1
    sc = session.create_script(JS)
    sc.on('message', lambda m, d: print(m.get('payload', {}).get('m', m), flush=True))
    sc.load()
    time.sleep(2.5)
    session.detach()
    return 0

if __name__ == '__main__':
    sys.exit(main())
