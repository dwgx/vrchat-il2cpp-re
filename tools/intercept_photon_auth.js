/**
 * intercept_photon_auth.js - Photon Auth Response Intercept & AuthCookie Modifier
 *
 * Hooks the Photon client transport layer and auth response processing to:
 * 1. Capture raw auth webhook response from VRChat API
 * 2. Identify AuthCookie format and fields
 * 3. Locate AuthValues in LoadBalancingClient
 * 4. (Optional) Attempt AuthCookie modification before storage
 *
 * USAGE:
 *   frida -l tools/intercept_photon_auth.js -p <VRChat PID>
 *   frida -f VRChat.exe -l tools/intercept_photon_auth.js -- --no-vr
 *
 * MODES:
 *   Default: Read-only capture & analysis
 *   INJECT_MODE: Set via RPC to enable experimental cookie modification
 *
 * WARNING: Cookie injection is experimental and may crash or get banned.
 */
'use strict';

// =========================================================
// Config
// =========================================================
var INJECT_MODE = false;  // Set via RPC: rpc.exports.setInjectMode(true)
var INJECT_COOKIE = null; // Cookie data to inject (set via RPC)

// =========================================================
// Globals
// =========================================================
var ga = null;
var BASE = null;
var startTime = Date.now();
var hookCount = 0;

// Captured state
var authState = {
    photonSecret: null,      // Photon session secret
    authCookieAddr: null,    // Memory address of stored AuthCookie
    authCookieData: null,    // Parsed AuthCookie contents
    authValuesAddr: null,    // LoadBalancingClient.AuthValues address
    lbcAddr: null,           // LoadBalancingClient instance address
    userId: null,            // VRChat user ID
    serverAddr: null,        // Photon server address
    lastAuthResponse: null,  // Raw last auth response
    wsMessages: [],          // Captured WebSocket/transport messages
};

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
        var bytes = ptr.readByteArray(Math.min(len, 512));
        if (!bytes) return '<unreadable>';
        var arr = new Uint8Array(bytes);
        var hex = [];
        for (var i = 0; i < arr.length; i++) {
            hex.push(('0' + arr[i].toString(16)).slice(-2));
        }
        return hex.join(' ');
    } catch (e) {
        return '<access violation>';
    }
}

function readIl2cppString(ptr) {
    try {
        if (!ptr || ptr.isNull()) return null;
        var len = ptr.add(0x10).readInt32();
        if (len <= 0 || len > 8192) return null;
        return ptr.add(0x14).readUtf16String(len);
    } catch (e) {
        return null;
    }
}

function isValidPointer(ptr) {
    try {
        if (!ptr || ptr.isNull()) return false;
        ptr.readU8();
        return true;
    } catch (e) {
        return false;
    }
}

// =========================================================
// RVA Table
// =========================================================
var RVA = {
    OnCustomAuthResponse_E3E5:       0x211A240,
    OnCustomAuthResponse_E1A7:       0x1A99BE0,
    OnOperationResponse_LB:          0x2149830,
    OnOperationResponse_9F7C:        0x15A2500,
    GetKeyServerAuthToken:           0x112A080,
    OnConnectedToMaster_34AB:        0x19572F0,
    AuthenticateWithSteam:           0x1F1A8A0,
};

// =========================================================
// Photon Protocol Constants
// =========================================================
var PHOTON_PARAM = {
    SECRET:          1,   // Auth secret token
    AUTH_COOKIE:     2,   // AuthCookie dictionary
    NICKNAME:        3,   // User nickname
    ENCRYPTION_DATA: 230, // Encryption setup
    USER_ID:        225,  // User ID
    POSITION:       223,  // Server region
};

// =========================================================
// Transport Layer Hooks (WSS/UDP)
// =========================================================
function hookTransportLayer() {
    // Hook WinHTTP / WinSock for raw Photon traffic capture
    // Photon uses either WebSocket (WSS) or UDP depending on config

    // 1. Hook ws2_32.send / WSASend for outgoing
    try {
        var ws2 = Process.getModuleByName('ws2_32.dll');

        var pSend = ws2.findExportByName('send');
        if (pSend) {
            Interceptor.attach(pSend, {
                onEnter: function(args) {
                    this.socket = args[0].toInt32();
                    this.buf = args[1];
                    this.len = args[2].toInt32();
                },
                onLeave: function(ret) {
                    if (this.len > 0 && this.len < 65536 && ret.toInt32() > 0) {
                        // Check if this looks like Photon traffic
                        // Photon binary protocol starts with 0xF3 (header byte)
                        try {
                            var firstByte = this.buf.readU8();
                            if (firstByte === 0xF3 || firstByte === 0xFB || firstByte === 0xFD) {
                                log('WIRE-OUT', 'Photon send ' + this.len + 'b socket=' + this.socket);
                                log('WIRE-OUT', '  header: ' + hexdump_safe(this.buf, Math.min(this.len, 64)));
                                authState.wsMessages.push({
                                    dir: 'out', size: this.len, time: ts(),
                                    header: hexdump_safe(this.buf, Math.min(this.len, 32))
                                });
                            }
                        } catch (e) {}
                    }
                }
            });
            hookCount++;
            log('WIRE', 'Hooked ws2_32!send');
        }

        // 2. Hook ws2_32.recv for incoming
        var pRecv = ws2.findExportByName('recv');
        if (pRecv) {
            Interceptor.attach(pRecv, {
                onEnter: function(args) {
                    this.socket = args[0].toInt32();
                    this.buf = args[1];
                    this.bufLen = args[2].toInt32();
                },
                onLeave: function(ret) {
                    var received = ret.toInt32();
                    if (received > 0 && received < 65536) {
                        try {
                            var firstByte = this.buf.readU8();
                            if (firstByte === 0xF3 || firstByte === 0xFB || firstByte === 0xFD) {
                                log('WIRE-IN', 'Photon recv ' + received + 'b socket=' + this.socket);
                                log('WIRE-IN', '  header: ' + hexdump_safe(this.buf, Math.min(received, 64)));
                                authState.wsMessages.push({
                                    dir: 'in', size: received, time: ts(),
                                    header: hexdump_safe(this.buf, Math.min(received, 32))
                                });
                            }
                        } catch (e) {}
                    }
                }
            });
            hookCount++;
            log('WIRE', 'Hooked ws2_32!recv');
        }

        // 3. Hook WSASend / WSARecv for overlapped IO
        var pWSASend = ws2.findExportByName('WSASend');
        if (pWSASend) {
            Interceptor.attach(pWSASend, {
                onEnter: function(args) {
                    // WSABUF* at args[1], dwBufferCount at args[2]
                    try {
                        var bufCount = args[2].toInt32();
                        if (bufCount > 0) {
                            var wsaBuf = args[1];
                            var len = wsaBuf.readU32();
                            var buf = wsaBuf.add(8).readPointer();
                            if (len > 0 && len < 65536 && isValidPointer(buf)) {
                                var firstByte = buf.readU8();
                                if (firstByte === 0xF3 || firstByte === 0xFB) {
                                    log('WIRE-OUT', 'WSASend Photon ' + len + 'b');
                                    log('WIRE-OUT', '  ' + hexdump_safe(buf, Math.min(len, 64)));
                                }
                            }
                        }
                    } catch (e) {}
                }
            });
            hookCount++;
        }
    } catch (e) {
        log('WIRE', 'Transport hook error: ' + e.message);
    }

    // 4. Hook WinHTTP for WebSocket upgrade (Photon WSS)
    try {
        var winhttp = Process.getModuleByName('winhttp.dll');
        if (winhttp) {
            var pWinHttpSendRequest = winhttp.findExportByName('WinHttpSendRequest');
            if (pWinHttpSendRequest) {
                Interceptor.attach(pWinHttpSendRequest, {
                    onEnter: function(args) {
                        try {
                            var headers = args[1].readUtf16String();
                            if (headers && (headers.indexOf('photon') !== -1 ||
                                headers.indexOf('Upgrade') !== -1)) {
                                log('HTTP', 'WinHttpSendRequest with headers: ' + headers.substring(0, 200));
                            }
                        } catch (e) {}
                    }
                });
                hookCount++;
            }
        }
    } catch (e) {}
}

// =========================================================
// GameAssembly Hooks
// =========================================================
function hookGA() {
    try {
        ga = Process.getModuleByName('GameAssembly.dll');
        BASE = ga.base;
    } catch (e) {
        log('GA', 'GameAssembly.dll not loaded yet');
        return false;
    }
    log('GA', 'GameAssembly.dll @ ' + BASE);

    // --- OnCustomAuthenticationResponse (E3E5) - Primary auth response ---
    hookRVA('OnCustomAuthResponse_E3E5', RVA.OnCustomAuthResponse_E3E5, {
        onEnter: function(args) {
            log('INTERCEPT', '========================================');
            log('INTERCEPT', '*** Auth Response Intercepted (E3E5) ***');

            var thisPtr = args[0];
            var responseData = args[1];

            // Find LoadBalancingClient through handler chain
            findAndDumpLBC(thisPtr);

            // Deep-dump the response data
            if (isValidPointer(responseData)) {
                log('INTERCEPT', '  responseData @ ' + responseData);
                dumpResponseFull(responseData);
                authState.lastAuthResponse = responseData.toString();
            }

            // --- INJECTION POINT ---
            if (INJECT_MODE && INJECT_COOKIE) {
                log('INJECT', '!!! INJECTION MODE ACTIVE !!!');
                attemptCookieInjection(thisPtr, responseData);
            }

            log('INTERCEPT', '========================================');
        }
    });

    // --- OnCustomAuthenticationResponse (E1A7) - Room handler ---
    hookRVA('OnCustomAuthResponse_E1A7', RVA.OnCustomAuthResponse_E1A7, {
        onEnter: function(args) {
            log('INTERCEPT', '*** Auth Response (E1A7/Room) ***');
            if (isValidPointer(args[1])) {
                dumpResponseFull(args[1]);
            }
        }
    });

    // --- OnOperationResponse (LB) - Capture auth op params ---
    hookRVA('OnOperationResponse_LB', RVA.OnOperationResponse_LB, {
        onEnter: function(args) {
            var resp = args[1];
            if (!resp || resp.isNull()) return;

            try {
                var opCode = resp.add(0x10).readU8();
                var retCode = resp.add(0x12).readS16();

                // Auth operations
                if (opCode === 230 || opCode === 231) {
                    log('AUTH-OP', '=== Auth Operation Response (OpCode ' + opCode + ') ===');
                    log('AUTH-OP', '  RetCode=' + retCode);

                    var paramsPtr = resp.add(0x20).readPointer();
                    if (isValidPointer(paramsPtr)) {
                        extractAuthCookieFromParams(paramsPtr);
                    }

                    // Also capture the 'this' (LoadBalancingClient)
                    if (isValidPointer(args[0])) {
                        authState.lbcAddr = args[0].toString();
                        log('AUTH-OP', '  LoadBalancingClient candidate @ ' + args[0]);
                        scanLBCForAuthValues(args[0]);
                    }
                }

                // JoinRoom - trace the request
                if (opCode === 226 || opCode === 227) {
                    log('JOIN-OP', '=== JoinRoom Response (OpCode ' + opCode + ') ===');
                    log('JOIN-OP', '  RetCode=' + retCode + (retCode !== 0 ? ' *** REJECTED ***' : ' OK'));

                    var debugMsg = resp.add(0x18).readPointer();
                    if (isValidPointer(debugMsg)) {
                        var msg = readIl2cppString(debugMsg);
                        log('JOIN-OP', '  DebugMessage: "' + (msg || '') + '"');
                    }

                    if (retCode !== 0) {
                        log('JOIN-OP', '  Full response dump (256b): ' + hexdump_safe(resp, 256));
                    }
                }
            } catch (e) {}
        }
    });

    // --- AuthenticateWithSteam - Capture outgoing auth data ---
    hookRVA('AuthenticateWithSteam', RVA.AuthenticateWithSteam, {
        onEnter: function(args) {
            log('STEAM-AUTH', '*** AuthenticateWithSteam ***');
            log('STEAM-AUTH', '  VRCFlowManager @ ' + args[0]);

            // Scan for auth-related string fields
            if (isValidPointer(args[0])) {
                for (var off = 0x18; off < 0x120; off += 8) {
                    try {
                        var fp = args[0].add(off).readPointer();
                        var s = readIl2cppString(fp);
                        if (s && s.length > 5 && s.length < 2000) {
                            // Classify the string
                            var cls = 'field';
                            if (s.indexOf('usr_') === 0) cls = 'USER_ID';
                            else if (s.indexOf('authcookie_') === 0) cls = 'API_TOKEN';
                            else if (s.indexOf('eyJ') === 0) cls = 'JWT';
                            else if (s.indexOf('http') === 0) cls = 'URL';

                            log('STEAM-AUTH', '  FM+0x' + off.toString(16) +
                                ' [' + cls + ']: "' + s.substring(0, 150) + '"');

                            if (cls === 'USER_ID') authState.userId = s;
                        }
                    } catch (e) {}
                }
            }
        }
    });

    // --- GetKeyServerAuthToken - The assembled Photon auth token ---
    hookRVA('GetKeyServerAuthToken', RVA.GetKeyServerAuthToken, {
        onLeave: function(ret) {
            if (isValidPointer(ret)) {
                var token = readIl2cppString(ret);
                if (token) {
                    log('TOKEN', '  Photon auth token (' + token.length + ' chars):');
                    // Split into parts if it's a composite token
                    if (token.indexOf(';') !== -1) {
                        var parts = token.split(';');
                        for (var i = 0; i < parts.length; i++) {
                            log('TOKEN', '    part[' + i + ']: "' + parts[i].substring(0, 100) + '"');
                        }
                    } else {
                        log('TOKEN', '    "' + token.substring(0, 200) + '"');
                    }

                    // Check if EAC data is embedded in the token
                    if (token.indexOf('eac') !== -1 || token.indexOf('EAC') !== -1 ||
                        token.indexOf('anticheat') !== -1) {
                        log('TOKEN', '    *** EAC DATA FOUND IN AUTH TOKEN ***');
                    }
                }
            }
        }
    });

    log('GA', 'Photon auth intercept hooks installed (' + hookCount + ')');
    return true;
}

function hookRVA(name, rva, callbacks) {
    try {
        var addr = BASE.add(rva);
        Interceptor.attach(addr, callbacks);
        hookCount++;
        log('HOOK', name + ' @ ' + addr);
    } catch (e) {
        log('HOOK', 'FAILED: ' + name + ': ' + e.message);
    }
}

// =========================================================
// Deep response analysis
// =========================================================
function dumpResponseFull(dataPtr) {
    log('RESP', '  --- Full response analysis ---');
    log('RESP', '  obj dump (256b): ' + hexdump_safe(dataPtr, 256));

    // Scan all pointer-sized fields for strings and nested objects
    var strings = [];
    var dicts = [];

    for (var off = 0x10; off < 0x100; off += 8) {
        try {
            var fp = dataPtr.add(off).readPointer();
            if (!isValidPointer(fp)) continue;

            // Try as IL2CPP string
            var s = readIl2cppString(fp);
            if (s && s.length > 0) {
                strings.push({ offset: off, value: s });
                log('RESP', '  +0x' + off.toString(16) + ' str: "' + s.substring(0, 200) + '"');
                continue;
            }

            // Try as Dictionary (check for count field at +0x20)
            try {
                var possibleCount = fp.add(0x20).readInt32();
                if (possibleCount > 0 && possibleCount < 100) {
                    var possibleEntries = fp.add(0x18).readPointer();
                    if (isValidPointer(possibleEntries)) {
                        dicts.push({ offset: off, count: possibleCount });
                        log('RESP', '  +0x' + off.toString(16) + ' dict? count=' + possibleCount);
                    }
                }
            } catch (e) {}

            // Try as array (IL2CPP array: +0x18 = length)
            try {
                var possibleLen = fp.add(0x18).readInt32();
                if (possibleLen > 0 && possibleLen < 10000) {
                    log('RESP', '  +0x' + off.toString(16) + ' array? len=' + possibleLen);
                }
            } catch (e) {}
        } catch (e) {}
    }
}

function findAndDumpLBC(handlerPtr) {
    if (!isValidPointer(handlerPtr)) return;

    // PhotonConnectionHandler typically has a reference to NetworkingClient / LoadBalancingClient
    for (var off = 0x10; off < 0x60; off += 8) {
        try {
            var candidate = handlerPtr.add(off).readPointer();
            if (!isValidPointer(candidate)) continue;

            // Check if it has Photon server strings
            for (var off2 = 0x10; off2 < 0xC0; off2 += 8) {
                try {
                    var fp = candidate.add(off2).readPointer();
                    var s = readIl2cppString(fp);
                    if (s && s.indexOf('.photonengine.') !== -1) {
                        log('LBC', '  Found LBC @ handler+0x' + off.toString(16));
                        authState.lbcAddr = candidate.toString();
                        authState.serverAddr = s;
                        log('LBC', '  Server: ' + s);
                        scanLBCForAuthValues(candidate);
                        return;
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }
}

function scanLBCForAuthValues(lbcPtr) {
    log('LBC', '  Scanning LBC @ ' + lbcPtr + ' for AuthValues...');

    for (var off = 0x10; off < 0x120; off += 8) {
        try {
            var fp = lbcPtr.add(off).readPointer();
            if (!isValidPointer(fp)) continue;

            // AuthValues has: AuthType(int), AuthGetParameters(string), AuthPostData(string/byte[]),
            //                 Token(string), UserId(string)
            // Check for UserId string that starts with "usr_"
            for (var off2 = 0x10; off2 < 0x30; off2 += 8) {
                try {
                    var sp = fp.add(off2).readPointer();
                    var s = readIl2cppString(sp);
                    if (s && s.indexOf('usr_') === 0) {
                        log('LBC', '  *** AuthValues found at LBC+0x' + off.toString(16) + ' ***');
                        log('LBC', '  AuthValues @ ' + fp);
                        log('LBC', '  AuthValues dump (96b): ' + hexdump_safe(fp, 96));
                        authState.authValuesAddr = fp.toString();

                        // Dump all AuthValues fields
                        for (var off3 = 0x10; off3 < 0x48; off3 += 8) {
                            try {
                                var vp = fp.add(off3).readPointer();
                                var vs = readIl2cppString(vp);
                                if (vs) {
                                    log('LBC', '    AV+0x' + off3.toString(16) + ': "' +
                                        vs.substring(0, 150) + '"');
                                }
                            } catch (e) {}
                        }
                        // Also check for integer fields (AuthType enum)
                        try {
                            var authType = fp.add(0x10).readInt32();
                            if (authType >= 0 && authType < 256) {
                                log('LBC', '    AV+0x10 (AuthType?): ' + authType);
                            }
                        } catch (e) {}
                        return;
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }
}

// =========================================================
// AuthCookie extraction from OperationResponse parameters
// =========================================================
function extractAuthCookieFromParams(paramsPtr) {
    log('COOKIE', '  Extracting AuthCookie from params @ ' + paramsPtr);

    try {
        var count = paramsPtr.add(0x20).readInt32();
        if (count <= 0 || count > 50) {
            log('COOKIE', '  Invalid param count: ' + count);
            return;
        }

        var entries = paramsPtr.add(0x18).readPointer();
        if (!isValidPointer(entries)) return;

        var entriesBase = entries.add(0x20);

        for (var i = 0; i < count; i++) {
            try {
                // Dictionary<byte, object> entry: hash(4) + next(4) + key(1+pad to 8) + value(8) = 24
                var entryBase = entriesBase.add(i * 24);
                var hash = entryBase.readInt32();
                if (hash === -1) continue;

                var key = entryBase.add(8).readU8();
                var valuePtr = entryBase.add(16).readPointer();

                log('COOKIE', '  Param[' + key + '] @ ' + valuePtr);

                switch (key) {
                    case PHOTON_PARAM.SECRET: // 1 = Secret
                        if (isValidPointer(valuePtr)) {
                            var secret = readIl2cppString(valuePtr);
                            if (secret) {
                                log('COOKIE', '    SECRET: "' + secret.substring(0, 40) + '..."');
                                authState.photonSecret = secret;
                            }
                        }
                        break;

                    case PHOTON_PARAM.AUTH_COOKIE: // 2 = AuthCookie
                        log('COOKIE', '    *** AUTH COOKIE FOUND ***');
                        authState.authCookieAddr = valuePtr.toString();
                        dumpAuthCookie(valuePtr);
                        break;

                    case PHOTON_PARAM.USER_ID: // 225 = UserId
                        if (isValidPointer(valuePtr)) {
                            var uid = readIl2cppString(valuePtr);
                            if (uid) {
                                log('COOKIE', '    USER_ID: "' + uid + '"');
                                authState.userId = uid;
                            }
                        }
                        break;

                    default:
                        if (isValidPointer(valuePtr)) {
                            var vs = readIl2cppString(valuePtr);
                            if (vs) {
                                log('COOKIE', '    [' + key + ']: "' + vs.substring(0, 100) + '"');
                            } else {
                                log('COOKIE', '    [' + key + ']: <obj> ' + hexdump_safe(valuePtr, 32));
                            }
                        }
                        break;
                }
            } catch (e) {}
        }
    } catch (e) {
        log('COOKIE', '  Extraction error: ' + e.message);
    }
}

function dumpAuthCookie(cookiePtr) {
    if (!isValidPointer(cookiePtr)) return;

    log('COOKIE', '    Cookie object @ ' + cookiePtr);
    log('COOKIE', '    Cookie dump (512b): ' + hexdump_safe(cookiePtr, 512));

    // The AuthCookie from Photon's perspective is just an opaque Dictionary<string, object>
    // set by the webhook response. VRChat's webhook sets it to contain:
    // - User info (userId, displayName, trustLevel, etc.)
    // - EAC session status
    // - Possibly a HMAC/signature

    // Try parsing as Dictionary<string, object>
    try {
        var count = cookiePtr.add(0x20).readInt32();
        log('COOKIE', '    Cookie dict count: ' + count);

        if (count > 0 && count < 200) {
            var entries = cookiePtr.add(0x18).readPointer();
            if (!isValidPointer(entries)) return;

            var entriesBase = entries.add(0x20);
            var cookieData = {};

            for (var i = 0; i < Math.min(count * 2, 100); i++) {
                try {
                    // Dict<string, object>: hash(4) + next(4) + key(ptr, 8) + value(ptr, 8) = 24
                    var entryBase = entriesBase.add(i * 24);
                    var hash = entryBase.readInt32();
                    if (hash === -1) continue;

                    var keyPtr = entryBase.add(8).readPointer();
                    var valPtr = entryBase.add(16).readPointer();

                    var keyStr = readIl2cppString(keyPtr);
                    if (!keyStr) continue;

                    var valStr = null;
                    if (isValidPointer(valPtr)) {
                        valStr = readIl2cppString(valPtr);
                        if (!valStr) {
                            // Try as boxed int/bool
                            try {
                                var boxedVal = valPtr.add(0x10).readInt32();
                                valStr = '<boxed int: ' + boxedVal + '>';
                            } catch (e) {
                                valStr = '<obj @ ' + valPtr + '>';
                            }
                        }
                    }

                    log('COOKIE', '    ["' + keyStr + '"] = ' + (valStr || '<null>'));
                    cookieData[keyStr] = valStr;

                    // Flag EAC-related fields
                    var keyLower = keyStr.toLowerCase();
                    if (keyLower.indexOf('eac') !== -1 || keyLower.indexOf('anticheat') !== -1 ||
                        keyLower.indexOf('integrity') !== -1 || keyLower.indexOf('cheat') !== -1 ||
                        keyLower.indexOf('protect') !== -1 || keyLower.indexOf('status') !== -1) {
                        log('COOKIE', '    *** EAC-RELATED FIELD: "' + keyStr + '" ***');
                    }
                } catch (e) {}
            }

            authState.authCookieData = cookieData;
        }
    } catch (e) {
        log('COOKIE', '    Cookie dict parse error: ' + e.message);
    }
}

// =========================================================
// Cookie Injection (experimental, requires INJECT_MODE)
// =========================================================
function attemptCookieInjection(handlerPtr, responseData) {
    log('INJECT', '  Injection attempt...');

    if (!authState.authCookieAddr) {
        log('INJECT', '  No AuthCookie address captured yet. Run auth first.');
        return;
    }

    if (!INJECT_COOKIE) {
        log('INJECT', '  No injection data set. Use RPC: setInjectCookie({key: value, ...})');
        return;
    }

    log('INJECT', '  Target AuthCookie @ ' + authState.authCookieAddr);
    log('INJECT', '  Injection data: ' + JSON.stringify(INJECT_COOKIE));

    // The actual injection would need to:
    // 1. Locate the Dictionary entries in memory
    // 2. Find the EAC status field
    // 3. Modify the value pointer to point to a new string/value
    // This is highly version-specific and may crash.

    log('INJECT', '  NOTE: Direct memory write injection not yet implemented.');
    log('INJECT', '  Alternative: Hook the auth response BEFORE it gets processed,');
    log('INJECT', '  and modify the OperationResponse parameters in-flight.');
    log('INJECT', '  Use setInjectMode(true) + setInjectCookie() via RPC first.');
}

// =========================================================
// DLL Load Watcher
// =========================================================
function watchDllLoads() {
    var pLoadLibExW = null;
    try { pLoadLibExW = Process.getModuleByName('KERNELBASE.dll').findExportByName('LoadLibraryExW'); } catch(e) {}
    if (!pLoadLibExW) try { pLoadLibExW = Process.getModuleByName('kernel32.dll').findExportByName('LoadLibraryExW'); } catch(e) {}
    if (!pLoadLibExW) return;

    Interceptor.attach(pLoadLibExW, {
        onEnter: function(args) {
            try { this.name = args[0].readUtf16String(); } catch (e) { this.name = null; }
        },
        onLeave: function(ret) {
            if (!this.name) return;
            var lower = this.name.toLowerCase();
            if (lower.indexOf('gameassembly') !== -1 && !ga) {
                log('DLL', 'GameAssembly loaded: ' + this.name);
                setTimeout(function() { hookGA(); }, 500);
            }
        }
    });
}

// =========================================================
// RPC Exports
// =========================================================
rpc.exports = {
    getState: function() {
        return authState;
    },
    setInjectMode: function(enabled) {
        INJECT_MODE = !!enabled;
        log('RPC', 'Inject mode: ' + (INJECT_MODE ? 'ON' : 'OFF'));
        return INJECT_MODE;
    },
    setInjectCookie: function(data) {
        INJECT_COOKIE = data;
        log('RPC', 'Inject cookie set: ' + JSON.stringify(data));
        return true;
    },
    dumpAuthCookieNow: function() {
        if (authState.authCookieAddr) {
            dumpAuthCookie(ptr(authState.authCookieAddr));
            return authState.authCookieData;
        }
        return null;
    },
    dumpLBCNow: function() {
        if (authState.lbcAddr) {
            scanLBCForAuthValues(ptr(authState.lbcAddr));
        }
        return authState.authValuesAddr;
    },
    readMemory: function(addrStr, size) {
        try {
            return hexdump_safe(ptr(addrStr), size || 256);
        } catch (e) {
            return 'Error: ' + e.message;
        }
    },
    writeIl2cppString: function(addrStr, newValue) {
        // Write a new IL2CPP string value at the given address
        // WARNING: This writes into existing string memory. Only use for same-length or shorter strings.
        try {
            var strPtr = ptr(addrStr);
            var newLen = newValue.length;
            strPtr.add(0x10).writeInt32(newLen);
            strPtr.add(0x14).writeUtf16String(newValue);
            log('RPC', 'Wrote IL2CPP string at ' + addrStr + ': "' + newValue + '"');
            return true;
        } catch (e) {
            log('RPC', 'Write error: ' + e.message);
            return false;
        }
    }
};

// =========================================================
// Main
// =========================================================
log('INIT', '=== VRChat Photon Auth Interceptor v1.0 ===');
log('INIT', 'Modes: READ-ONLY (default) | INJECT (via RPC)');

watchDllLoads();
hookTransportLayer();
var gaOk = hookGA();
if (!gaOk) log('INIT', 'GA hooks deferred');

log('INIT', hookCount + ' hooks installed');
log('INIT', '');
log('INIT', 'RPC commands:');
log('INIT', '  rpc.exports.getState()          -- current auth state');
log('INIT', '  rpc.exports.setInjectMode(true)  -- enable injection (dangerous!)');
log('INIT', '  rpc.exports.setInjectCookie({})   -- set cookie data to inject');
log('INIT', '  rpc.exports.dumpAuthCookieNow()   -- re-dump captured cookie');
log('INIT', '  rpc.exports.dumpLBCNow()          -- re-scan LBC for AuthValues');
log('INIT', '  rpc.exports.readMemory(addr, sz)  -- hex dump memory');
