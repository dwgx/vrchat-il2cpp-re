/**
 * Frida spawn-mode script to trace the offline mode check.
 * Hooks key functions to capture call stacks and state.
 *
 * Usage: frida -f VRChat.exe -l tools/trace_offline_check.js -- --no-vr
 */
'use strict';

function waitForModule(name, cb) {
    var check = setInterval(function() {
        try {
            var m = Process.getModuleByName(name);
            clearInterval(check);
            cb(m);
        } catch(e) {}
    }, 100);
}

waitForModule('GameAssembly.dll', function(ga) {
    var base = ga.base;
    console.log('[*] GameAssembly.dll @ ' + base);

    // 1. Hook the "set connect error state" function at RVA 0x1943bc0
    //    to capture rsi (the object whose [+0x178] gets set)
    var stateFunc = base.add(0x1943bc0);
    Interceptor.attach(stateFunc, {
        onEnter: function(args) {
            this.obj = args[0];
            console.log('\n[STATE-FUNC] RVA 0x1943bc0 called, rcx=' + args[0]);
            // Read the class of this object
            try {
                var klass = args[0].readPointer();
                var name = klass.add(0x58).readPointer().readUtf8String();
                var ns = klass.add(0x18).readPointer().readUtf8String();
                console.log('[STATE-FUNC] Object class: ' + ns + '.' + name);
            } catch(e) {
                console.log('[STATE-FUNC] Class read error: ' + e.message);
            }
            // Read current value at +0x178
            try {
                var flagVal = args[0].add(0x178).readU8();
                console.log('[STATE-FUNC] [obj+0x178] before = ' + flagVal);
            } catch(e) {}
            // Stack trace
            var bt = Thread.backtrace(this.context, Backtracer.ACCURATE);
            console.log('[STATE-FUNC] Stack:');
            for (var i = 0; i < bt.length && i < 8; i++) {
                var mod = Process.findModuleByAddress(bt[i]);
                if (mod) console.log('  ' + mod.name + '!' + bt[i].sub(mod.base));
                else console.log('  ' + bt[i]);
            }
        },
        onLeave: function(ret) {
            // Check if flag was set
            try {
                var flagVal = this.obj.add(0x178).readU8();
                console.log('[STATE-FUNC] [obj+0x178] after = ' + flagVal);
            } catch(e) {}
        }
    });
    console.log('[+] Hooked state func @ 0x1943bc0');

    // 2. Hook the byte write at [rsi+0x178] = 1
    //    The instruction is at RVA 0x1944d8a: c6 86 78 01 00 00 01
    var flagWrite = base.add(0x1944d8a);
    // Verify the instruction is there
    var flagBytes = new Uint8Array(flagWrite.readByteArray(7));
    var flagHex = '';
    for (var i = 0; i < flagBytes.length; i++) flagHex += flagBytes[i].toString(16).padStart(2,'0');
    console.log('[*] Flag write bytes at 0x1944d8a: ' + flagHex);

    // 3. Hook the 3 "Failed to join instance" format string usage functions
    var failFuncs = [
        {rva: 0x15d4d60, name: 'fail_join_0'},
        {rva: 0x113494b, name: 'fail_join_1'},
        {rva: 0x18fcd80, name: 'fail_join_2'}
    ];

    for (var fi = 0; fi < failFuncs.length; fi++) {
        (function(f) {
            var addr = base.add(f.rva);
            Interceptor.attach(addr, {
                onEnter: function(args) {
                    console.log('\n[FAIL-JOIN] ' + f.name + ' @ RVA 0x' + f.rva.toString(16));
                    // Try to read string args
                    for (var a = 0; a < 4; a++) {
                        try {
                            var p = args[a];
                            if (!p.isNull()) {
                                var len = p.add(0x10).readS32();
                                if (len > 0 && len < 500) {
                                    console.log('  arg' + a + ': "' + p.add(0x14).readUtf16String(Math.min(len, 80)) + '"');
                                }
                            }
                        } catch(e) {}
                    }
                    var bt = Thread.backtrace(this.context, Backtracer.ACCURATE);
                    console.log('  Stack:');
                    for (var i = 0; i < bt.length && i < 10; i++) {
                        var mod = Process.findModuleByAddress(bt[i]);
                        if (mod) console.log('    ' + mod.name + '!' + bt[i].sub(mod.base));
                        else console.log('    ' + bt[i]);
                    }
                }
            });
            console.log('[+] Hooked ' + f.name + ' @ 0x' + f.rva.toString(16));
        })(failFuncs[fi]);
    }

    // 4. Hook the join validator at RVA 0x1d6de00
    var joinVal = base.add(0x1d6de00);
    Interceptor.attach(joinVal, {
        onEnter: function(args) {
            console.log('\n[JOIN-VAL] Join validator called, rcx=' + args[0] + ' rdx=' + args[1]);
            var bt = Thread.backtrace(this.context, Backtracer.ACCURATE);
            console.log('  Stack:');
            for (var i = 0; i < bt.length && i < 8; i++) {
                var mod = Process.findModuleByAddress(bt[i]);
                if (mod) console.log('    ' + mod.name + '!' + bt[i].sub(mod.base));
                else console.log('    ' + bt[i]);
            }
        },
        onLeave: function(ret) {
            console.log('[JOIN-VAL] Returned: ' + ret);
            // Try to read return as string
            try {
                if (!ret.isNull()) {
                    var len = ret.add(0x10).readS32();
                    if (len > 0 && len < 500) {
                        console.log('[JOIN-VAL] Return string: "' + ret.add(0x14).readUtf16String(Math.min(len, 100)) + '"');
                    }
                }
            } catch(e) {}
        }
    });
    console.log('[+] Hooked join validator @ 0x1d6de00');

    console.log('[*] All hooks installed. Waiting for startup join attempt...');
});
