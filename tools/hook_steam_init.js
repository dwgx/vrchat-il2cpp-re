/**
 * Frida spawn-mode: Hook SteamAPI to fake successful initialization.
 *
 * Usage: frida -f VRChat.exe -l tools/hook_steam_init.js -- --no-vr
 */
'use strict';

let hooked = false;

function hookSteamAPI() {
    if (hooked) return true;
    let m;
    try { m = Process.getModuleByName('steam_api64.dll'); } catch (e) { return false; }
    console.log('[*] steam_api64.dll @ ' + m.base);
    hooked = true;

    const hooks = [
        ['SteamAPI_RestartAppIfNecessary', 0, 'false(no restart)'],
        ['SteamAPI_Init', 1, 'true(success)'],
        ['SteamAPI_InitSafe', 1, 'true(success)'],
        ['SteamAPI_IsSteamRunning', 1, 'true'],
    ];

    for (const [name, retVal, desc] of hooks) {
        try {
            const addr = m.getExportByName(name);
            Interceptor.attach(addr, {
                onLeave: function (retval) {
                    var orig = retval.toInt32();
                    retval.replace(retVal);
                    console.log('[V] ' + name + ': ' + orig + ' -> ' + retVal + ' (' + desc + ')');
                }
            });
            console.log('[+] Hooked ' + name + ' @ ' + addr);
        } catch (e) {
            console.log('[!] ' + name + ': ' + e.message);
        }
    }

    console.log('[*] All Steam hooks installed');
    return true;
}

// Watch for DLL load
var loadLibW = Module.getExportByName('kernel32.dll', 'LoadLibraryW');
Interceptor.attach(loadLibW, {
    onEnter: function (args) {
        this.path = args[0].readUtf16String();
    },
    onLeave: function (retval) {
        if (this.path && this.path.toLowerCase().indexOf('steam_api64') !== -1) {
            console.log('[*] DLL loaded: ' + this.path);
            hookSteamAPI();
        }
    }
});

if (!hookSteamAPI()) {
    console.log('[*] Waiting for steam_api64.dll...');
}
console.log('[*] Script ready');
