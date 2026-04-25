/**
 * trace_auth_flow.js - VRChat EAC/Authentication Token Flow Tracer
 *
 * Hooks EOS SDK exports + Photon auth callbacks to capture the full
 * authentication data flow: Steam ticket -> VRChat API -> Photon custom auth -> EAC session.
 *
 * USAGE:
 *   frida -l tools/trace_auth_flow.js -p <VRChat PID>
 *   frida -f VRChat.exe -l tools/trace_auth_flow.js -- --no-vr
 *
 * OUTPUT: ASCII-safe log of all auth-related calls with argument dumps.
 * SAFE: Read-only hooks, no function calls, no writes.
 */
'use strict';

// =========================================================
// Globals
// =========================================================
var ga = null;
var BASE = null;
var eosModule = null;
var startTime = Date.now();
var hookCount = 0;

function ts() {
    return ((Date.now() - startTime) / 1000).toFixed(2) + 's';
}

function log(tag, msg) {
    var line = '[' + ts() + '][' + tag + '] ' + msg;
    send(line);
    console.log(line);
}

function hexdump_safe(ptr, len) {
    try {
        if (ptr.isNull()) return '<NULL>';
        var bytes = ptr.readByteArray(Math.min(len, 256));
        if (!bytes) return '<unreadable>';
        var arr = new Uint8Array(bytes);
        var hex = [];
        var ascii = [];
        for (var i = 0; i < arr.length; i++) {
            hex.push(('0' + arr[i].toString(16)).slice(-2));
            ascii.push(arr[i] >= 0x20 && arr[i] < 0x7f ? String.fromCharCode(arr[i]) : '.');
        }
        return hex.join(' ') + '  |' + ascii.join('') + '|';
    } catch (e) {
        return '<access violation>';
    }
}

function readUtf16Safe(ptr) {
    try {
        if (ptr.isNull()) return '<NULL>';
        return ptr.readUtf16String();
    } catch (e) {
        return '<unreadable>';
    }
}

function readUtf8Safe(ptr) {
    try {
        if (ptr.isNull()) return '<NULL>';
        return ptr.readUtf8String();
    } catch (e) {
        return '<unreadable>';
    }
}

function readIl2cppString(ptr) {
    // IL2CPP System.String: length at +0x10, chars at +0x14 (UTF-16)
    try {
        if (ptr.isNull()) return '<NULL>';
        var klass = ptr.readPointer();
        if (klass.isNull()) return '<null klass>';
        var len = ptr.add(0x10).readInt32();
        if (len <= 0 || len > 4096) return '<invalid string len=' + len + '>';
        return ptr.add(0x14).readUtf16String(len);
    } catch (e) {
        return '<string read error>';
    }
}

function dumpPointerChain(base, offsets, label) {
    var p = base;
    for (var i = 0; i < offsets.length; i++) {
        try {
            p = p.add(offsets[i]).readPointer();
            if (p.isNull()) {
                log(label, 'chain broke at offset[' + i + '] = 0x' + offsets[i].toString(16));
                return null;
            }
        } catch (e) {
            log(label, 'chain error at offset[' + i + ']: ' + e.message);
            return null;
        }
    }
    return p;
}

// =========================================================
// RVA Table (relative to GameAssembly.dll base)
// Verified from deobfuscated_dump.cs with dump base 0x7FFB4D4F0000
// =========================================================
var RVA = {
    // Photon auth callbacks
    OnConnectedToMaster_34AB:        0x19572F0,  // PhotonConnectionHandler_34AB (VRCPhotonAuthHandler)
    OnConnectedToMaster_E3E5:        0x211A830,  // PhotonConnectionHandler_E3E5 (callback list)
    OnCustomAuthResponse_E3E5:       0x211A240,  // PhotonConnectionHandler_E3E5.OnCustomAuthenticationResponse
    OnCustomAuthFailed_34AB:         0x1956DE0,  // PhotonConnectionHandler_34AB.OnCustomAuthenticationFailed
    OnCustomAuthFailed_E3E5:         0x2119090,  // PhotonConnectionHandler_E3E5.OnCustomAuthenticationFailed
    OnCustomAuthResponse_E1A7:       0x1A99BE0,  // PhotonRoomHandler_E1A7.OnCustomAuthenticationResponse
    OnCustomAuthFailed_E1A7:         0x19F3F0,   // PhotonRoomHandler_E1A7.OnCustomAuthenticationFailed (partial)

    // VRCNetworkingClient (main Photon event dispatcher)
    OnOperationResponse_9F7C:        0x15A2500,  // DispatchIncomingCommandsSendOutgoingComm_9F7C.OnOperationResponse

    // AuthenticateWithSteam
    AuthenticateWithSteam:           0x1F1A8A0,  // VRCFlowManager.AuthenticateWithSteam

    // PlatformOptions.GetKeyServerAuthToken
    GetKeyServerAuthToken:           0x112A080,  // PlatformOptions.GetKeyServerAuthToken

    // FlowManager coroutines
    BeginConnectionToPhoton:         0x18F1740,  // init func called by FlowManager
    FlowManager_Awake:               0x1921E50,

    // OnOperationResponse in the main loadbalancing path
    OnOperationResponse_LB:          0x2149830,  // LoadBalancingClient-ish OnOperationResponse
};

// =========================================================
// Phase 1: EOS SDK Hooks
// =========================================================
function hookEOS() {
    try {
        eosModule = Process.getModuleByName('EOSSDK-Win64-Shipping.dll');
    } catch (e) {
        log('EOS', 'EOSSDK not loaded yet - will retry on DLL load');
        return false;
    }

    log('EOS', 'Module found at ' + eosModule.base + ' size=' + eosModule.size);

    // --- EOS_AntiCheatClient_BeginSession ---
    hookEosExport('EOS_AntiCheatClient_BeginSession', {
        onEnter: function(args) {
            log('EOS-AC', 'BeginSession called');
            log('EOS-AC', '  handle  = ' + args[0]);
            log('EOS-AC', '  options = ' + args[1]);
            if (!args[1].isNull()) {
                // EOS_AntiCheatClient_BeginSession_Options struct
                // ApiVersion at +0, LocalUserId at +8, Mode at +16
                log('EOS-AC', '  options dump (64 bytes):');
                log('EOS-AC', '  ' + hexdump_safe(args[1], 64));
                try {
                    var apiVer = args[1].readInt32();
                    var localUser = args[1].add(8).readPointer();
                    var mode = args[1].add(16).readInt32();
                    log('EOS-AC', '  ApiVersion=' + apiVer + ' LocalUserId=' + localUser + ' Mode=' + mode);
                } catch(e) {}
            }
        },
        onLeave: function(ret) {
            log('EOS-AC', 'BeginSession returned ' + ret.toInt32() + ' (0=success)');
        }
    });

    // --- EOS_AntiCheatClient_AddNotifyMessageToServer ---
    hookEosExport('EOS_AntiCheatClient_AddNotifyMessageToServer', {
        onEnter: function(args) {
            log('EOS-AC', 'AddNotifyMessageToServer called');
            log('EOS-AC', '  handle   = ' + args[0]);
            log('EOS-AC', '  options  = ' + args[1]);
            log('EOS-AC', '  userData = ' + args[2]);
            log('EOS-AC', '  callback = ' + args[3]);
            if (!args[1].isNull()) {
                log('EOS-AC', '  options dump: ' + hexdump_safe(args[1], 32));
            }
        },
        onLeave: function(ret) {
            log('EOS-AC', 'AddNotifyMessageToServer -> notifyId=' + ret);
        }
    });

    // --- EOS_AntiCheatClient_PollStatus ---
    hookEosExport('EOS_AntiCheatClient_PollStatus', {
        onEnter: function(args) {
            this.optionsPtr = args[1];
            this.violationPtr = args[2];
        },
        onLeave: function(ret) {
            var result = ret.toInt32();
            // Only log non-success or first few calls
            if (result !== 0) {
                log('EOS-AC', 'PollStatus returned ' + result + ' (NON-SUCCESS)');
                if (!this.violationPtr.isNull()) {
                    try {
                        var violationType = this.violationPtr.readInt32();
                        var msg = this.violationPtr.add(8).readPointer();
                        log('EOS-AC', '  violation type=' + violationType);
                        if (!msg.isNull()) {
                            log('EOS-AC', '  violation msg=' + readUtf8Safe(msg));
                        }
                    } catch(e) {}
                }
            }
        }
    });

    // --- EOS_AntiCheatClient_ReceiveMessageFromServer ---
    hookEosExport('EOS_AntiCheatClient_ReceiveMessageFromServer', {
        onEnter: function(args) {
            log('EOS-AC', 'ReceiveMessageFromServer called');
            if (!args[1].isNull()) {
                // Options has: ApiVersion, DataLengthBytes, Data
                try {
                    var apiVer = args[1].readInt32();
                    var dataLen = args[1].add(8).readInt32();
                    var dataPtr = args[1].add(16).readPointer();
                    log('EOS-AC', '  ApiVersion=' + apiVer + ' DataLen=' + dataLen);
                    if (!dataPtr.isNull() && dataLen > 0) {
                        log('EOS-AC', '  ServerMsg (' + dataLen + ' bytes): ' + hexdump_safe(dataPtr, Math.min(dataLen, 128)));
                    }
                } catch(e) {}
            }
        },
        onLeave: function(ret) {
            log('EOS-AC', 'ReceiveMessageFromServer -> ' + ret.toInt32());
        }
    });

    // --- EOS_AntiCheatClient_EndSession ---
    hookEosExport('EOS_AntiCheatClient_EndSession', {
        onEnter: function(args) {
            log('EOS-AC', 'EndSession called');
        },
        onLeave: function(ret) {
            log('EOS-AC', 'EndSession -> ' + ret.toInt32());
        }
    });

    // --- EOS Auth functions ---
    var authExports = [
        'EOS_Auth_Login',
        'EOS_Auth_Logout',
        'EOS_Auth_GetLoggedInAccountsCount',
        'EOS_Auth_GetLoggedInAccountByIndex',
        'EOS_Auth_GetLoginStatus',
        'EOS_Auth_CopyUserAuthToken',
        'EOS_Auth_CopyIdToken',
        'EOS_Auth_Token_Release',
        'EOS_Auth_IdToken_Release',
        'EOS_Auth_VerifyUserAuth',
        'EOS_Auth_VerifyIdToken',
        'EOS_Auth_AddNotifyLoginStatusChanged',
    ];

    authExports.forEach(function(name) {
        hookEosExport(name, {
            onEnter: function(args) {
                log('EOS-AUTH', name + ' called');
                log('EOS-AUTH', '  arg0=' + args[0] + ' arg1=' + args[1]);
                if (!args[1].isNull()) {
                    log('EOS-AUTH', '  arg1 dump: ' + hexdump_safe(args[1], 64));
                }
            },
            onLeave: function(ret) {
                log('EOS-AUTH', name + ' -> ' + ret);
            }
        });
    });

    // --- EOS Connect functions (product user IDs, used for anti-cheat) ---
    var connectExports = [
        'EOS_Connect_Login',
        'EOS_Connect_CreateUser',
        'EOS_Connect_GetProductUserId',
        'EOS_Connect_CopyProductUserExternalAccountByAccountType',
        'EOS_Connect_CopyIdToken',
        'EOS_Connect_VerifyIdToken',
        'EOS_Connect_AddNotifyAuthExpiration',
        'EOS_Connect_AddNotifyLoginStatusChanged',
    ];

    connectExports.forEach(function(name) {
        hookEosExport(name, {
            onEnter: function(args) {
                log('EOS-CONN', name + ' called');
                log('EOS-CONN', '  arg0=' + args[0] + ' arg1=' + args[1]);
            },
            onLeave: function(ret) {
                log('EOS-CONN', name + ' -> ' + ret);
            }
        });
    });

    // --- EOS Platform tick (MessageToServer callback fires here) ---
    hookEosExport('EOS_Platform_Tick', {
        onEnter: function(args) {
            // Too noisy to log every tick; track for correlation
            this.handle = args[0];
        }
    });

    log('EOS', 'All EOS hooks installed (' + hookCount + ' total)');
    return true;
}

function hookEosExport(name, callbacks) {
    try {
        var addr = null;
        try { addr = eosModule.findExportByName(name); } catch(e) {}
        if (!addr) return;
        Interceptor.attach(addr, callbacks);
        hookCount++;
    } catch (e) {
        // Export not present -- expected for many optional functions
    }
}

// =========================================================
// Phase 2: GameAssembly IL2CPP Hooks (RVA-based)
// =========================================================
function hookGA() {
    try {
        ga = Process.getModuleByName('GameAssembly.dll');
        BASE = ga.base;
    } catch (e) {
        log('GA', 'GameAssembly.dll not loaded yet');
        return false;
    }

    log('GA', 'GameAssembly.dll @ ' + BASE + ' size=0x' + ga.size.toString(16));

    // --- OnConnectedToMaster (VRCPhotonAuthHandler / PhotonConnectionHandler_34AB) ---
    hookRVA('OnConnectedToMaster_34AB', RVA.OnConnectedToMaster_34AB, {
        onEnter: function(args) {
            log('PHOTON', '*** OnConnectedToMaster (AuthHandler) ***');
            log('PHOTON', '  this=' + args[0]);
            dumpThisFields(args[0], 'AuthHandler');
        }
    });

    // --- OnConnectedToMaster (callback list / PhotonConnectionHandler_E3E5) ---
    hookRVA('OnConnectedToMaster_E3E5', RVA.OnConnectedToMaster_E3E5, {
        onEnter: function(args) {
            log('PHOTON', '*** OnConnectedToMaster (CallbackList) ***');
        }
    });

    // --- OnCustomAuthenticationResponse (E3E5 - callback aggregator) ---
    hookRVA('OnCustomAuthResponse', RVA.OnCustomAuthResponse_E3E5, {
        onEnter: function(args) {
            log('AUTH', '========================================');
            log('AUTH', '*** OnCustomAuthenticationResponse ***');
            log('AUTH', '  this=' + args[0]);
            log('AUTH', '  arg1 (response data)=' + args[1]);
            dumpAuthResponseData(args[1]);
            log('AUTH', '========================================');
        }
    });

    // --- OnCustomAuthenticationResponse (E1A7 - room handler) ---
    hookRVA('OnCustomAuthResponse_Room', RVA.OnCustomAuthResponse_E1A7, {
        onEnter: function(args) {
            log('AUTH', '*** OnCustomAuthenticationResponse (RoomHandler) ***');
            log('AUTH', '  this=' + args[0] + ' arg1=' + args[1]);
            dumpAuthResponseData(args[1]);
        }
    });

    // --- OnCustomAuthenticationFailed (34AB - auth handler) ---
    hookRVA('OnCustomAuthFailed_34AB', RVA.OnCustomAuthFailed_34AB, {
        onEnter: function(args) {
            log('AUTH', '!!! OnCustomAuthenticationFailed (AuthHandler) !!!');
            log('AUTH', '  this=' + args[0]);
            log('AUTH', '  arg1 (error string)=' + args[1]);
            if (!args[1].isNull()) {
                log('AUTH', '  error=' + readIl2cppString(args[1]));
            }
        }
    });

    // --- OnCustomAuthenticationFailed (E3E5 - callback list) ---
    hookRVA('OnCustomAuthFailed_E3E5', RVA.OnCustomAuthFailed_E3E5, {
        onEnter: function(args) {
            log('AUTH', '!!! OnCustomAuthenticationFailed (CallbackList) !!!');
            log('AUTH', '  this=' + args[0] + ' arg1=' + args[1]);
            if (!args[1].isNull()) {
                log('AUTH', '  error=' + readIl2cppString(args[1]));
            }
        }
    });

    // --- AuthenticateWithSteam ---
    hookRVA('AuthenticateWithSteam', RVA.AuthenticateWithSteam, {
        onEnter: function(args) {
            log('AUTH', '*** AuthenticateWithSteam called ***');
            log('AUTH', '  this (VRCFlowManager)=' + args[0]);
            // Try to read fields from VRCFlowManager instance
            dumpFlowManagerAuth(args[0]);
        }
    });

    // --- OnOperationResponse (main Photon client) ---
    // This receives ALL Photon operation responses including auth
    hookRVA('OnOperationResponse_LB', RVA.OnOperationResponse_LB, {
        onEnter: function(args) {
            // OperationResponse object: opCode at some offset
            // We want to see OpCode 230 (Authenticate) and 231 (AuthenticateOnce) responses
            var resp = args[1];
            if (!resp || resp.isNull()) return;
            try {
                // OperationResponse: OperationCode at +0x10 (byte), ReturnCode at +0x12 (short), DebugMessage at +0x18
                var opCode = resp.add(0x10).readU8();
                var retCode = resp.add(0x12).readS16();

                // Only log auth-related opcodes or errors
                if (opCode === 230 || opCode === 231 || retCode !== 0) {
                    log('PHOTON-OP', 'OnOperationResponse opCode=' + opCode + ' retCode=' + retCode);
                    // DebugMessage (IL2CPP string at +0x18)
                    var debugMsg = resp.add(0x18).readPointer();
                    if (!debugMsg.isNull()) {
                        log('PHOTON-OP', '  debugMessage=' + readIl2cppString(debugMsg));
                    }
                    // Parameters dictionary at +0x20
                    var paramsDict = resp.add(0x20).readPointer();
                    if (!paramsDict.isNull()) {
                        log('PHOTON-OP', '  parameters dict=' + paramsDict);
                        log('PHOTON-OP', '  params dump (64b): ' + hexdump_safe(paramsDict, 64));
                    }
                    // Full response dump
                    log('PHOTON-OP', '  response obj dump (96b): ' + hexdump_safe(resp, 96));
                }
            } catch (e) {
                log('PHOTON-OP', 'OnOperationResponse parse error: ' + e.message);
            }
        }
    });

    // --- OnOperationResponse (networking peer / 9F7C) ---
    hookRVA('OnOperationResponse_9F7C', RVA.OnOperationResponse_9F7C, {
        onEnter: function(args) {
            var resp = args[1];
            if (!resp || resp.isNull()) return;
            try {
                var opCode = resp.add(0x10).readU8();
                var retCode = resp.add(0x12).readS16();
                if (opCode === 230 || opCode === 231 || retCode !== 0) {
                    log('NET-OP', 'VRCNetworkingPeer.OnOperationResponse opCode=' + opCode + ' retCode=' + retCode);
                    var debugMsg = resp.add(0x18).readPointer();
                    if (!debugMsg.isNull()) {
                        log('NET-OP', '  debugMessage=' + readIl2cppString(debugMsg));
                    }
                }
            } catch (e) {}
        }
    });

    // --- GetKeyServerAuthToken (PlatformOptions) ---
    hookRVA('GetKeyServerAuthToken', RVA.GetKeyServerAuthToken, {
        onEnter: function(args) {
            log('AUTH', '*** GetKeyServerAuthToken called ***');
            log('AUTH', '  this=' + args[0]);
        },
        onLeave: function(ret) {
            log('AUTH', '  GetKeyServerAuthToken returned=' + ret);
            if (!ret.isNull()) {
                log('AUTH', '  return value: ' + readIl2cppString(ret));
            }
        }
    });

    log('GA', 'All GameAssembly hooks installed');
    return true;
}

function hookRVA(name, rva, callbacks) {
    try {
        var addr = BASE.add(rva);
        Interceptor.attach(addr, callbacks);
        hookCount++;
        log('HOOK', 'Hooked ' + name + ' @ ' + addr + ' (RVA 0x' + rva.toString(16) + ')');
    } catch (e) {
        log('HOOK', 'FAILED to hook ' + name + ' @ RVA 0x' + rva.toString(16) + ': ' + e.message);
    }
}

// =========================================================
// Data Extraction Helpers
// =========================================================
function dumpAuthResponseData(arg) {
    // arg is typically a Dictionary<string, object> or similar auth response
    if (!arg || arg.isNull()) {
        log('AUTH', '  response data: <NULL>');
        return;
    }
    try {
        log('AUTH', '  response obj @ ' + arg);
        log('AUTH', '  dump (128 bytes): ' + hexdump_safe(arg, 128));

        // Try to read as IL2CPP Dictionary - entries array at varying offsets
        // First try: is it a string?
        var possibleStr = readIl2cppString(arg);
        if (possibleStr && possibleStr.indexOf('<') !== 0) {
            log('AUTH', '  as string: ' + possibleStr);
        }
    } catch (e) {
        log('AUTH', '  response parse error: ' + e.message);
    }
}

function dumpThisFields(thisPtr, label) {
    if (!thisPtr || thisPtr.isNull()) return;
    try {
        // Dump first 128 bytes of the object to see field layout
        log(label, '  object dump (128b): ' + hexdump_safe(thisPtr, 128));
    } catch (e) {}
}

function dumpFlowManagerAuth(fmPtr) {
    if (!fmPtr || fmPtr.isNull()) return;
    try {
        // VRCFlowManager fields - look for string fields that might contain tokens
        // Scan offsets 0x10-0x100 for pointers that look like IL2CPP strings
        for (var off = 0x18; off < 0x100; off += 8) {
            try {
                var fieldPtr = fmPtr.add(off).readPointer();
                if (fieldPtr.isNull()) continue;

                // Check if it looks like an IL2CPP string (klass pointer + length)
                var possibleLen = fieldPtr.add(0x10).readInt32();
                if (possibleLen > 0 && possibleLen < 2048) {
                    var str = readIl2cppString(fieldPtr);
                    if (str && str.length > 2 && str.indexOf('<') !== 0) {
                        log('AUTH', '  FM+0x' + off.toString(16) + ' string: "' + str.substring(0, 120) + '"');
                    }
                }
            } catch (e) { /* skip */ }
        }
    } catch (e) {}
}

// =========================================================
// Phase 3: Hook Photon wire-level operations
// =========================================================
function hookPhotonWire() {
    // Hook PhotonPeer.OpCustom to see outgoing operations
    // We look for the EnqueueOperation in PeerBase which is the final path
    // For now, we rely on OnOperationResponse hooks above

    // Hook PhotonPeer.Connect to see connection target
    // PhotonPeer has multiple Connect overloads - hook by scanning exports
    // This is complex; we instrument at the IL2CPP callback level instead
    log('WIRE', 'Wire-level hooks rely on OnOperationResponse interception');
}

// =========================================================
// DLL Load Watcher (for EOSSDK late loading)
// =========================================================
function watchDllLoads() {
    var pLoadLibExW = null;
    try { pLoadLibExW = Process.getModuleByName('KERNELBASE.dll').findExportByName('LoadLibraryExW'); } catch(e) {}
    if (!pLoadLibExW) try { pLoadLibExW = Process.getModuleByName('kernel32.dll').findExportByName('LoadLibraryExW'); } catch(e) {}
    if (!pLoadLibExW) {
        log('DLL', 'Cannot find LoadLibraryExW');
        return;
    }

    Interceptor.attach(pLoadLibExW, {
        onEnter: function(args) {
            try {
                this.name = args[0].readUtf16String();
            } catch (e) {
                this.name = null;
            }
        },
        onLeave: function(ret) {
            if (!this.name) return;
            var lower = this.name.toLowerCase();

            if (lower.indexOf('eossdk') !== -1 && !eosModule) {
                log('DLL', 'EOSSDK loaded: ' + this.name);
                hookEOS();
            }
            if (lower.indexOf('gameassembly') !== -1 && !ga) {
                log('DLL', 'GameAssembly loaded: ' + this.name);
                setTimeout(function() { hookGA(); }, 500);
            }
            // Log other interesting DLLs
            if (lower.indexOf('photon') !== -1 || lower.indexOf('steam') !== -1) {
                log('DLL', 'Loaded: ' + this.name);
            }
        }
    });
    log('DLL', 'DLL load watcher installed');
}

// =========================================================
// Phase 4: Steam API hooks
// =========================================================
function hookSteamAPI() {
    var steamModule = null;
    try {
        steamModule = Process.getModuleByName('steam_api64.dll');
    } catch (e) {
        log('STEAM', 'steam_api64.dll not loaded');
        return false;
    }

    log('STEAM', 'steam_api64.dll @ ' + steamModule.base);

    // Hook SteamAPI_ISteamUser_GetAuthSessionTicket
    try {
        var getTicket = steamModule.getExportByName('SteamAPI_ISteamUser_GetAuthSessionTicket');
        if (getTicket) {
            Interceptor.attach(getTicket, {
                onEnter: function(args) {
                    log('STEAM', '*** GetAuthSessionTicket called ***');
                    log('STEAM', '  self=' + args[0]);
                    log('STEAM', '  pTicket=' + args[1]);
                    log('STEAM', '  cbMaxTicket=' + args[2].toInt32());
                    log('STEAM', '  pcbTicket=' + args[3]);
                    this.ticketBuf = args[1];
                    this.ticketLenPtr = args[3];
                },
                onLeave: function(ret) {
                    log('STEAM', '  GetAuthSessionTicket handle=' + ret);
                    try {
                        var ticketLen = this.ticketLenPtr.readU32();
                        log('STEAM', '  ticket length=' + ticketLen + ' bytes');
                        if (ticketLen > 0 && ticketLen < 2048) {
                            log('STEAM', '  ticket (first 64 bytes): ' + hexdump_safe(this.ticketBuf, Math.min(ticketLen, 64)));
                        }
                    } catch (e) {}
                }
            });
            hookCount++;
            log('STEAM', 'Hooked GetAuthSessionTicket');
        }
    } catch (e) {
        log('STEAM', 'GetAuthSessionTicket hook failed: ' + e.message);
    }

    // Hook SteamAPI_ISteamUser_GetAuthTicketForWebApi
    try {
        var getWebTicket = steamModule.getExportByName('SteamAPI_ISteamUser_GetAuthTicketForWebApi');
        if (getWebTicket) {
            Interceptor.attach(getWebTicket, {
                onEnter: function(args) {
                    log('STEAM', '*** GetAuthTicketForWebApi called ***');
                    log('STEAM', '  identity=' + readUtf8Safe(args[1]));
                },
                onLeave: function(ret) {
                    log('STEAM', '  GetAuthTicketForWebApi handle=' + ret);
                }
            });
            hookCount++;
            log('STEAM', 'Hooked GetAuthTicketForWebApi');
        }
    } catch (e) {}

    return true;
}

// =========================================================
// Main
// =========================================================
log('INIT', '=== VRChat Auth Flow Tracer v1.0 ===');
log('INIT', 'Hooking all auth-related paths...');

watchDllLoads();

var gaOk = hookGA();
var eosOk = hookEOS();
var steamOk = hookSteamAPI();

if (!gaOk) log('INIT', 'GA hooks deferred - will install on DLL load');
if (!eosOk) log('INIT', 'EOS hooks deferred - will install on DLL load');
if (!steamOk) log('INIT', 'Steam hooks deferred');

log('INIT', '=== Tracer ready. ' + hookCount + ' hooks installed. ===');
log('INIT', 'Waiting for auth flow events...');
log('INIT', 'Key events to watch:');
log('INIT', '  STEAM - GetAuthSessionTicket (Steam app ticket generation)');
log('INIT', '  AUTH  - AuthenticateWithSteam (VRChat login via Steam)');
log('INIT', '  AUTH  - GetKeyServerAuthToken (Photon custom auth token)');
log('INIT', '  AUTH  - OnCustomAuthenticationResponse (Photon server accepted)');
log('INIT', '  AUTH  - OnCustomAuthenticationFailed (Photon server rejected)');
log('INIT', '  EOS-AC - BeginSession / PollStatus / MessageToServer');
log('INIT', '  PHOTON - OnConnectedToMaster (connection established)');
log('INIT', '  PHOTON-OP - OnOperationResponse opCode=230/231 (auth ops)');
