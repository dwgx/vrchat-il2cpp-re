/**
 * Frida spawn script: fake EOS Anti-Cheat so VRChat doesn't enter "offline testing mode."
 * Usage: frida -f VRChat.exe -l hook_eos_anticheat.js -- --no-vr
 */
'use strict';

var EOS_Success = 0;
var fakeACHandle = Memory.alloc(256);
fakeACHandle.writeU64(0xDEADBEEF);
var hooked = false;

function installACHooks(eos) {
    if (hooked) return;
    hooked = true;
    console.log('[*] EOSSDK @ ' + eos.base);

    try {
        Interceptor.attach(eos.getExportByName('EOS_Platform_GetAntiCheatClientInterface'), {
            onLeave: function(ret) {
                if (ret.isNull()) {
                    ret.replace(fakeACHandle);
                    console.log('[AC] GetAntiCheatClientInterface: NULL -> fake ' + fakeACHandle);
                }
            }
        });
        console.log('[+] Hooked GetAntiCheatClientInterface');
    } catch(e) { console.log('[!] ' + e.message); }

    try {
        Interceptor.attach(eos.getExportByName('EOS_AntiCheatClient_BeginSession'), {
            onLeave: function(ret) { ret.replace(EOS_Success); console.log('[AC] BeginSession -> success'); }
        });
        console.log('[+] Hooked BeginSession');
    } catch(e) {}

    try {
        Interceptor.attach(eos.getExportByName('EOS_AntiCheatClient_EndSession'), {
            onLeave: function(ret) { ret.replace(EOS_Success); }
        });
    } catch(e) {}

    try {
        Interceptor.attach(eos.getExportByName('EOS_AntiCheatClient_PollStatus'), {
            onLeave: function(ret) { ret.replace(EOS_Success); }
        });
    } catch(e) {}

    var notifyFuncs = [
        'EOS_AntiCheatClient_AddNotifyMessageToServer',
        'EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged',
        'EOS_AntiCheatClient_AddNotifyClientIntegrityViolated',
        'EOS_AntiCheatClient_AddNotifyMessageToPeer',
        'EOS_AntiCheatClient_AddNotifyPeerActionRequired'
    ];
    for (var i = 0; i < notifyFuncs.length; i++) {
        (function(name) {
            try {
                Interceptor.attach(eos.getExportByName(name), {
                    onLeave: function(ret) { if (ret.toInt32() === 0) ret.replace(ptr(42)); }
                });
            } catch(e) {}
        })(notifyFuncs[i]);
    }

    try {
        Interceptor.attach(eos.getExportByName('EOS_AntiCheatClient_ReceiveMessageFromServer'), {
            onLeave: function(ret) { ret.replace(EOS_Success); }
        });
    } catch(e) {}

    console.log('[*] All EOS AntiCheat hooks installed!');
}

// Try immediately
try {
    var eos = Process.getModuleByName('EOSSDK-Win64-Shipping.dll');
    installACHooks(eos);
} catch(e) {
    console.log('[*] EOSSDK not loaded yet, hooking LoadLibraryExW...');

    // Hook LoadLibraryExW which is the underlying function called by LoadLibraryW
    var pLoadLibExW = Module.getExportByName('KERNELBASE.dll', 'LoadLibraryExW') ||
                      Module.getExportByName('kernel32.dll', 'LoadLibraryExW');

    if (pLoadLibExW) {
        Interceptor.attach(pLoadLibExW, {
            onEnter: function(args) {
                try {
                    this.name = args[0].readUtf16String();
                } catch(e) {
                    this.name = null;
                }
            },
            onLeave: function(ret) {
                if (!hooked && this.name && this.name.toLowerCase().indexOf('eossdk') !== -1) {
                    console.log('[*] EOSSDK loaded: ' + this.name);
                    try {
                        var eos = Process.getModuleByName('EOSSDK-Win64-Shipping.dll');
                        installACHooks(eos);
                    } catch(e) {
                        console.log('[!] Failed to hook after load: ' + e.message);
                    }
                }
            }
        });
        console.log('[+] LoadLibraryExW hook installed');
    } else {
        console.log('[!] Could not find LoadLibraryExW');
    }
}

console.log('[*] EOS AntiCheat bypass ready');
