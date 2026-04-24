/**
 * analyze_authcookie.js - VRChat AuthCookie Analysis & JoinRoom EAC Check Tracer
 *
 * Hooks Photon auth response handlers and JoinRoom (OpCode 226) flow to:
 * 1. Dump full OnCustomAuthenticationResponse data structures
 * 2. Find where AuthCookie is stored in memory after auth
 * 3. Trace AuthCookie usage during JoinRoom
 * 4. Map the OpCode 226 handler to find EAC status checks
 *
 * USAGE:
 *   frida -l tools/analyze_authcookie.js -p <VRChat PID>
 *   frida -f VRChat.exe -l tools/analyze_authcookie.js -- --no-vr
 *
 * OUTPUT: Detailed auth response dumps, AuthCookie memory layout, JoinRoom flow.
 * SAFE: Read-only hooks (except optional cookie injection mode).
 */
'use strict';

// =========================================================
// Globals
// =========================================================
var ga = null;
var BASE = null;
var startTime = Date.now();
var hookCount = 0;

// Captured AuthCookie data
var capturedAuthCookie = null;
var capturedAuthToken = null;
var authResponseHistory = [];
var operationHistory = [];

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

function readIl2cppString(ptr) {
    try {
        if (ptr.isNull()) return null;
        var len = ptr.add(0x10).readInt32();
        if (len <= 0 || len > 8192) return null;
        return ptr.add(0x14).readUtf16String(len);
    } catch (e) {
        return null;
    }
}

function readUtf8Safe(ptr) {
    try {
        if (ptr.isNull()) return null;
        return ptr.readUtf8String();
    } catch (e) {
        return null;
    }
}

function isValidPointer(ptr) {
    try {
        if (ptr.isNull()) return false;
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
    // Photon auth response handlers
    OnCustomAuthResponse_E3E5:       0x211A240,  // PhotonConnectionHandler_E3E5.OnCustomAuthenticationResponse
    OnCustomAuthResponse_E1A7:       0x1A99BE0,  // PhotonRoomHandler_E1A7.OnCustomAuthenticationResponse
    OnCustomAuthFailed_34AB:         0x1956DE0,  // PhotonConnectionHandler_34AB.OnCustomAuthenticationFailed
    OnCustomAuthFailed_E3E5:         0x2119090,  // PhotonConnectionHandler_E3E5.OnCustomAuthenticationFailed

    // Operation response handlers
    OnOperationResponse_LB:          0x2149830,  // LoadBalancingClient OnOperationResponse
    OnOperationResponse_9F7C:        0x15A2500,  // VRCNetworkingPeer OnOperationResponse

    // Auth token
    GetKeyServerAuthToken:           0x112A080,  // PlatformOptions.GetKeyServerAuthToken

    // Connection
    OnConnectedToMaster_34AB:        0x19572F0,
};

// Photon OpCodes
var OP = {
    AUTHENTICATE:       230,
    AUTHENTICATE_ONCE:  231,
    JOIN_ROOM:          226,
    JOIN_RANDOM_ROOM:   227,
    CREATE_ROOM:        227,
    LEAVE_ROOM:         254,
    JOIN_LOBBY:         229,
    SET_PROPERTIES:     252,
    GET_GAME_LIST:      217,
    RAISE_EVENT:        253,
};

var OP_NAMES = {};
Object.keys(OP).forEach(function(k) { OP_NAMES[OP[k]] = k; });

// =========================================================
// IL2CPP Dictionary / Hashtable reader
// =========================================================
function dumpIl2cppDictionary(dictPtr, label) {
    if (!dictPtr || dictPtr.isNull()) {
        log(label, '  dict: <NULL>');
        return null;
    }
    try {
        // IL2CPP Dictionary<TKey, TValue> layout:
        //   +0x10: int[] buckets
        //   +0x18: Entry[] entries
        //   +0x20: int count
        //   +0x24: int version
        //   +0x28: int freeList
        //   +0x2C: int freeCount
        //   +0x30: IEqualityComparer comparer
        //   +0x38: KeyCollection keys
        //   +0x40: ValueCollection values
        var count = dictPtr.add(0x20).readInt32();
        log(label, '  dict count=' + count);

        if (count <= 0 || count > 200) {
            log(label, '  dict raw dump (128b): ' + hexdump_safe(dictPtr, 128));
            return null;
        }

        var entries = dictPtr.add(0x18).readPointer();
        if (entries.isNull()) {
            log(label, '  entries array is NULL');
            return null;
        }

        // Entry struct: { int hashCode, int next, TKey key, TValue value }
        // For Dictionary<string, object>: Entry = { 4, 4, 8, 8 } = 24 bytes
        // For Dictionary<byte, object>: Entry = { 4, 4, 1+padding, 8 } = variable
        // IL2CPP array: +0x18 = first element (after klass, monitor, bounds, max_length)
        var entriesBase = entries.add(0x20); // IL2CPP array data offset

        var result = {};
        for (var i = 0; i < Math.min(count, 50); i++) {
            try {
                // Try Dictionary<byte, object> layout first (Photon uses byte keys)
                // Entry: hashCode(4) + next(4) + key(1+padding to 8) + value(8) = 24
                var entryBase = entriesBase.add(i * 24);
                var hashCode = entryBase.readInt32();
                var key = entryBase.add(8).readU8();
                var valuePtr = entryBase.add(16).readPointer();

                if (hashCode !== -1) {
                    var valueStr = '<ptr ' + valuePtr + '>';
                    if (isValidPointer(valuePtr)) {
                        var asStr = readIl2cppString(valuePtr);
                        if (asStr) {
                            valueStr = '"' + asStr.substring(0, 200) + '"';
                        } else {
                            valueStr = '<obj ' + valuePtr + '> raw: ' + hexdump_safe(valuePtr, 32);
                        }
                    }
                    log(label, '  [' + key + '] = ' + valueStr);
                    result[key] = valueStr;
                }
            } catch (e) {
                // Try string key layout
                try {
                    var entryBase2 = entriesBase.add(i * 32);
                    var keyPtr = entryBase2.add(8).readPointer();
                    var valPtr = entryBase2.add(16).readPointer();
                    var keyStr = readIl2cppString(keyPtr);
                    if (keyStr) {
                        var valStr2 = readIl2cppString(valPtr) || ('<ptr ' + valPtr + '>');
                        log(label, '  ["' + keyStr + '"] = ' + valStr2);
                        result[keyStr] = valStr2;
                    }
                } catch (e2) {}
            }
        }
        return result;
    } catch (e) {
        log(label, '  dict parse error: ' + e.message);
        log(label, '  dict raw dump (128b): ' + hexdump_safe(dictPtr, 128));
        return null;
    }
}

// =========================================================
// Photon OperationResponse parser
// =========================================================
function parseOperationResponse(resp, label) {
    if (!resp || resp.isNull()) return null;

    try {
        // OperationResponse IL2CPP layout (from Photon Realtime):
        //   klass:        +0x00 (pointer)
        //   monitor:      +0x08
        //   OperationCode: +0x10 (byte)
        //   ReturnCode:   +0x12 (short)  -- may have padding
        //   DebugMessage: +0x18 (IL2CPP string ptr)
        //   Parameters:   +0x20 (Dictionary<byte, object>)
        var opCode = resp.add(0x10).readU8();
        var retCode = resp.add(0x12).readS16();
        var debugMsgPtr = resp.add(0x18).readPointer();
        var paramsPtr = resp.add(0x20).readPointer();

        var opName = OP_NAMES[opCode] || ('Unknown_' + opCode);
        var debugMsg = debugMsgPtr.isNull() ? null : readIl2cppString(debugMsgPtr);

        log(label, 'OpCode=' + opCode + ' (' + opName + ') RetCode=' + retCode);
        if (debugMsg) {
            log(label, '  DebugMessage: "' + debugMsg + '"');
        }

        // Full response object dump
        log(label, '  Response obj dump (128b): ' + hexdump_safe(resp, 128));

        // Parse Parameters dictionary
        if (!paramsPtr.isNull()) {
            log(label, '  --- Parameters Dictionary ---');
            dumpIl2cppDictionary(paramsPtr, label);
        }

        // Record for analysis
        var record = {
            time: ts(),
            opCode: opCode,
            opName: opName,
            retCode: retCode,
            debugMsg: debugMsg,
            paramsAddr: paramsPtr.toString()
        };
        operationHistory.push(record);

        return record;
    } catch (e) {
        log(label, '  Response parse error: ' + e.message);
        log(label, '  Raw dump: ' + hexdump_safe(resp, 96));
        return null;
    }
}

// =========================================================
// AuthCookie deep analysis
// =========================================================
function analyzeAuthResponse(thisPtr, responseData, label) {
    log(label, '=== AuthCookie Deep Analysis ===');

    // Dump the 'this' object to find where auth data is stored
    if (isValidPointer(thisPtr)) {
        log(label, '  handler this @ ' + thisPtr);
        log(label, '  handler dump (256b): ' + hexdump_safe(thisPtr, 256));

        // Scan fields for IL2CPP strings (tokens, cookies, etc.)
        for (var off = 0x10; off < 0x100; off += 8) {
            try {
                var fieldPtr = thisPtr.add(off).readPointer();
                if (fieldPtr.isNull()) continue;
                var str = readIl2cppString(fieldPtr);
                if (str && str.length > 2) {
                    log(label, '  this+0x' + off.toString(16) + ' string: "' +
                        str.substring(0, 200) + '"' + (str.length > 200 ? '...' : ''));
                }
            } catch (e) {}
        }
    }

    // Analyze the response data parameter
    if (isValidPointer(responseData)) {
        log(label, '  responseData @ ' + responseData);
        log(label, '  responseData dump (256b): ' + hexdump_safe(responseData, 256));

        // Photon CustomAuthenticationResponse structure:
        // This is typically passed as a Photon OperationResponse or custom event data
        // Try multiple interpretations

        // Interpretation 1: Direct OperationResponse
        parseOperationResponse(responseData, label + '-OP');

        // Interpretation 2: Custom data structure with string fields
        log(label, '  --- Scanning for string fields in response ---');
        for (var off = 0x10; off < 0x100; off += 8) {
            try {
                var fieldPtr = responseData.add(off).readPointer();
                if (fieldPtr.isNull()) continue;
                var str = readIl2cppString(fieldPtr);
                if (str && str.length > 0) {
                    log(label, '  resp+0x' + off.toString(16) + ': "' +
                        str.substring(0, 300) + '"' + (str.length > 300 ? '...' : ''));

                    // Check if this looks like a token/cookie
                    if (str.indexOf('auth') !== -1 || str.indexOf('token') !== -1 ||
                        str.indexOf('cookie') !== -1 || str.indexOf('eac') !== -1 ||
                        str.indexOf('jwt') !== -1 || str.indexOf('eyJ') === 0) {
                        log(label, '  *** POTENTIAL AUTH TOKEN at resp+0x' + off.toString(16) + ' ***');
                        capturedAuthCookie = {
                            offset: off,
                            address: fieldPtr.toString(),
                            value: str,
                            time: ts()
                        };
                    }
                }
            } catch (e) {}
        }

        // Interpretation 3: Dictionary-like structure
        log(label, '  --- Attempting dictionary parse ---');
        dumpIl2cppDictionary(responseData, label + '-DICT');

        // Look for nested objects that might contain AuthValues
        log(label, '  --- Scanning nested objects ---');
        for (var off = 0x10; off < 0x80; off += 8) {
            try {
                var ptr1 = responseData.add(off).readPointer();
                if (!isValidPointer(ptr1)) continue;
                // Check if this nested object has string fields
                for (var off2 = 0x10; off2 < 0x40; off2 += 8) {
                    try {
                        var ptr2 = ptr1.add(off2).readPointer();
                        var str2 = readIl2cppString(ptr2);
                        if (str2 && str2.length > 2) {
                            log(label, '  resp+0x' + off.toString(16) +
                                '->+0x' + off2.toString(16) + ': "' +
                                str2.substring(0, 200) + '"');
                        }
                    } catch (e) {}
                }
            } catch (e) {}
        }

        authResponseHistory.push({
            time: ts(),
            handler: label,
            dataAddr: responseData.toString()
        });
    }
}

// =========================================================
// JoinRoom flow analysis
// =========================================================
function analyzeJoinRoomResponse(opRecord, respPtr) {
    if (!opRecord || opRecord.opCode !== OP.JOIN_ROOM) return;

    log('JOINROOM', '=== JoinRoom Response Analysis ===');
    log('JOINROOM', '  ReturnCode=' + opRecord.retCode + ' (' +
        (opRecord.retCode === 0 ? 'SUCCESS' : 'FAILED') + ')');

    if (opRecord.retCode !== 0) {
        log('JOINROOM', '  !!! JOIN REJECTED !!!');
        log('JOINROOM', '  DebugMessage: "' + (opRecord.debugMsg || '<empty>') + '"');
        log('JOINROOM', '  This is likely the EAC check failure.');
        log('JOINROOM', '  ReturnCode meanings:');
        log('JOINROOM', '    32758 = Plugin error (BeforeJoin hook failed)');
        log('JOINROOM', '    32767 = Internal server error');
        log('JOINROOM', '    32766 = Game does not exist');
        log('JOINROOM', '    32765 = Game full');
        log('JOINROOM', '    32764 = Game closed');

        // Dump the full response for analysis
        if (isValidPointer(respPtr)) {
            log('JOINROOM', '  Full response dump (256b): ' + hexdump_safe(respPtr, 256));
        }
    }
}

// =========================================================
// Hook Installation
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

    // --- OnCustomAuthenticationResponse (E3E5 - main aggregator) ---
    hookRVA('OnCustomAuthResponse_E3E5', RVA.OnCustomAuthResponse_E3E5, {
        onEnter: function(args) {
            log('AUTH', '==========================================');
            log('AUTH', '*** OnCustomAuthenticationResponse (E3E5) ***');
            analyzeAuthResponse(args[0], args[1], 'AUTH-E3E5');
            log('AUTH', '==========================================');
        }
    });

    // --- OnCustomAuthenticationResponse (E1A7 - room handler) ---
    hookRVA('OnCustomAuthResponse_E1A7', RVA.OnCustomAuthResponse_E1A7, {
        onEnter: function(args) {
            log('AUTH', '==========================================');
            log('AUTH', '*** OnCustomAuthenticationResponse (E1A7/Room) ***');
            analyzeAuthResponse(args[0], args[1], 'AUTH-E1A7');
            log('AUTH', '==========================================');
        }
    });

    // --- OnCustomAuthenticationFailed (both handlers) ---
    hookRVA('OnCustomAuthFailed_34AB', RVA.OnCustomAuthFailed_34AB, {
        onEnter: function(args) {
            log('AUTH-FAIL', '!!! OnCustomAuthFailed (34AB) !!!');
            log('AUTH-FAIL', '  this=' + args[0]);
            if (isValidPointer(args[1])) {
                var errStr = readIl2cppString(args[1]);
                log('AUTH-FAIL', '  error="' + (errStr || '<unreadable>') + '"');
            }
        }
    });

    hookRVA('OnCustomAuthFailed_E3E5', RVA.OnCustomAuthFailed_E3E5, {
        onEnter: function(args) {
            log('AUTH-FAIL', '!!! OnCustomAuthFailed (E3E5) !!!');
            if (isValidPointer(args[1])) {
                var errStr = readIl2cppString(args[1]);
                log('AUTH-FAIL', '  error="' + (errStr || '<unreadable>') + '"');
            }
        }
    });

    // --- OnOperationResponse (LoadBalancing - catches ALL ops including JoinRoom) ---
    hookRVA('OnOperationResponse_LB', RVA.OnOperationResponse_LB, {
        onEnter: function(args) {
            var resp = args[1];
            if (!resp || resp.isNull()) return;

            try {
                var opCode = resp.add(0x10).readU8();
                var retCode = resp.add(0x12).readS16();
                var opName = OP_NAMES[opCode] || ('Op_' + opCode);

                // Log ALL operations (not just auth) for complete picture
                if (opCode === OP.JOIN_ROOM || opCode === OP.JOIN_RANDOM_ROOM ||
                    opCode === OP.AUTHENTICATE || opCode === OP.AUTHENTICATE_ONCE ||
                    retCode !== 0) {

                    log('PHOTON-LB', '--- OnOperationResponse ---');
                    var record = parseOperationResponse(resp, 'PHOTON-LB');

                    // Special JoinRoom analysis
                    if (opCode === OP.JOIN_ROOM || opCode === OP.JOIN_RANDOM_ROOM) {
                        analyzeJoinRoomResponse(record, resp);
                    }

                    // Auth response: look for AuthCookie in parameters
                    if (opCode === OP.AUTHENTICATE || opCode === OP.AUTHENTICATE_ONCE) {
                        log('PHOTON-LB', '=== AUTH RESPONSE - Looking for AuthCookie ===');
                        // Photon auth response parameter keys:
                        // 1 = UserId, 2 = AuthCookie (Dictionary), 3 = Nickname
                        // The AuthCookie is parameter key 2 in the OperationResponse
                        var paramsPtr = resp.add(0x20).readPointer();
                        if (isValidPointer(paramsPtr)) {
                            scanAuthParameters(paramsPtr);
                        }
                    }
                }
            } catch (e) {
                log('PHOTON-LB', 'Parse error: ' + e.message);
            }
        }
    });

    // --- OnOperationResponse (VRCNetworkingPeer) ---
    hookRVA('OnOperationResponse_9F7C', RVA.OnOperationResponse_9F7C, {
        onEnter: function(args) {
            var resp = args[1];
            if (!resp || resp.isNull()) return;
            try {
                var opCode = resp.add(0x10).readU8();
                var retCode = resp.add(0x12).readS16();

                if (opCode === OP.JOIN_ROOM || retCode !== 0) {
                    log('VRC-NET', '--- VRCNetworkingPeer.OnOperationResponse ---');
                    parseOperationResponse(resp, 'VRC-NET');
                }
            } catch (e) {}
        }
    });

    // --- GetKeyServerAuthToken ---
    hookRVA('GetKeyServerAuthToken', RVA.GetKeyServerAuthToken, {
        onEnter: function(args) {
            log('TOKEN', '*** GetKeyServerAuthToken ***');
            log('TOKEN', '  this (PlatformOptions)=' + args[0]);
            if (isValidPointer(args[0])) {
                log('TOKEN', '  PlatformOptions dump (128b): ' + hexdump_safe(args[0], 128));
                // The getter does: return this->field_0x18->field_0x10
                try {
                    var inner = args[0].add(0x18).readPointer();
                    if (isValidPointer(inner)) {
                        log('TOKEN', '  inner obj @ ' + inner);
                        var tokenStr = inner.add(0x10).readPointer();
                        if (isValidPointer(tokenStr)) {
                            var token = readIl2cppString(tokenStr);
                            if (token) {
                                log('TOKEN', '  *** AUTH TOKEN: "' + token.substring(0, 100) + '..."');
                                capturedAuthToken = token;
                            }
                        }
                    }
                } catch (e) {}
            }
        },
        onLeave: function(ret) {
            if (isValidPointer(ret)) {
                var token = readIl2cppString(ret);
                if (token) {
                    log('TOKEN', '  returned token: "' + token.substring(0, 100) + '"...');
                    capturedAuthToken = token;
                }
            }
        }
    });

    // --- OnConnectedToMaster ---
    hookRVA('OnConnectedToMaster', RVA.OnConnectedToMaster_34AB, {
        onEnter: function(args) {
            log('PHOTON', '*** OnConnectedToMaster ***');
            log('PHOTON', '  Scanning handler for LoadBalancingClient reference...');

            // The handler 'this' likely has a reference to the LoadBalancingClient
            if (isValidPointer(args[0])) {
                scanForLoadBalancingClient(args[0]);
            }
        }
    });

    log('GA', 'AuthCookie analyzer hooks installed (' + hookCount + ')');
    return true;
}

function hookRVA(name, rva, callbacks) {
    try {
        var addr = BASE.add(rva);
        Interceptor.attach(addr, callbacks);
        hookCount++;
        log('HOOK', name + ' @ ' + addr + ' (RVA 0x' + rva.toString(16) + ')');
    } catch (e) {
        log('HOOK', 'FAILED: ' + name + ' RVA 0x' + rva.toString(16) + ': ' + e.message);
    }
}

// =========================================================
// Deep AuthCookie parameter scanning
// =========================================================
function scanAuthParameters(paramsPtr) {
    // Photon auth response Dictionary<byte, object> keys:
    // Key 1 = Secret (string) - used for further auth
    // Key 2 = AuthCookie (Dictionary<string, object>) - the main prize
    // Key 3 = Nickname (string, optional)
    // Key 230 = EncryptionData (byte[], for encrypted connections)
    log('AUTH-PARAMS', '--- Scanning auth response parameters ---');
    log('AUTH-PARAMS', '  params dict @ ' + paramsPtr);
    log('AUTH-PARAMS', '  params dump (256b): ' + hexdump_safe(paramsPtr, 256));

    dumpIl2cppDictionary(paramsPtr, 'AUTH-PARAMS');

    // Try to find AuthCookie specifically by scanning entries
    try {
        var count = paramsPtr.add(0x20).readInt32();
        var entries = paramsPtr.add(0x18).readPointer();
        if (entries.isNull() || count <= 0) return;

        var entriesBase = entries.add(0x20);
        for (var i = 0; i < Math.min(count, 20); i++) {
            try {
                var entryBase = entriesBase.add(i * 24);
                var key = entryBase.add(8).readU8();
                var valuePtr = entryBase.add(16).readPointer();

                if (key === 2 && isValidPointer(valuePtr)) {
                    log('AUTH-COOKIE', '*** FOUND AuthCookie (param key 2) ***');
                    log('AUTH-COOKIE', '  AuthCookie @ ' + valuePtr);
                    log('AUTH-COOKIE', '  AuthCookie dump (512b): ' + hexdump_safe(valuePtr, 512));

                    // AuthCookie is itself a Dictionary<string, object>
                    // Try to parse it
                    log('AUTH-COOKIE', '  --- AuthCookie contents ---');
                    dumpIl2cppDictionary(valuePtr, 'AUTH-COOKIE');

                    capturedAuthCookie = {
                        address: valuePtr.toString(),
                        time: ts()
                    };

                    // Scan for string values inside the cookie
                    log('AUTH-COOKIE', '  --- Deep scan of AuthCookie fields ---');
                    for (var off = 0x10; off < 0x100; off += 8) {
                        try {
                            var fp = valuePtr.add(off).readPointer();
                            if (!isValidPointer(fp)) continue;
                            var s = readIl2cppString(fp);
                            if (s && s.length > 0) {
                                log('AUTH-COOKIE', '  cookie+0x' + off.toString(16) +
                                    ': "' + s.substring(0, 200) + '"');
                            }
                        } catch (e) {}
                    }
                }

                if (key === 1 && isValidPointer(valuePtr)) {
                    var secret = readIl2cppString(valuePtr);
                    if (secret) {
                        log('AUTH-PARAMS', '  Secret (key 1): "' + secret.substring(0, 60) + '..."');
                    }
                }
            } catch (e) {}
        }
    } catch (e) {
        log('AUTH-PARAMS', '  Deep scan error: ' + e.message);
    }
}

// =========================================================
// LoadBalancingClient scanner
// =========================================================
function scanForLoadBalancingClient(handlerPtr) {
    // The handler should have a reference to the LoadBalancingClient
    // LoadBalancingClient has AuthValues property which stores auth data
    log('LBC', '  Scanning handler for LoadBalancingClient...');
    for (var off = 0x10; off < 0x80; off += 8) {
        try {
            var ptr = handlerPtr.add(off).readPointer();
            if (!isValidPointer(ptr)) continue;

            // LoadBalancingClient indicators: large object with many fields
            // Look for State field (enum, small int at some offset)
            // and AuthValues field (object pointer)
            // Let's check if this has server address strings
            for (var off2 = 0x10; off2 < 0x100; off2 += 8) {
                try {
                    var fp = ptr.add(off2).readPointer();
                    var s = readIl2cppString(fp);
                    if (s && (s.indexOf('photon') !== -1 || s.indexOf('ns.') !== -1 ||
                        s.indexOf('app-') !== -1 || s.indexOf('.photonengine.') !== -1)) {
                        log('LBC', '  Candidate LBC at handler+0x' + off.toString(16));
                        log('LBC', '  LBC+0x' + off2.toString(16) + ' server: "' + s + '"');

                        // Dump this candidate
                        log('LBC', '  LBC dump (256b): ' + hexdump_safe(ptr, 256));

                        // Look for AuthValues in LBC
                        // AuthValues is typically at an early offset
                        scanForAuthValues(ptr);
                        return;
                    }
                } catch (e) {}
            }
        } catch (e) {}
    }
}

function scanForAuthValues(lbcPtr) {
    log('LBC', '  Scanning LBC for AuthValues...');
    // AuthValues is an object with: AuthType, AuthGetParameters, AuthPostData, Token, UserId
    for (var off = 0x10; off < 0x100; off += 8) {
        try {
            var ptr = lbcPtr.add(off).readPointer();
            if (!isValidPointer(ptr)) continue;

            // Check for string fields that look like auth data
            var hasUserId = false, hasToken = false;
            for (var off2 = 0x10; off2 < 0x40; off2 += 8) {
                try {
                    var fp = ptr.add(off2).readPointer();
                    var s = readIl2cppString(fp);
                    if (s) {
                        if (s.indexOf('usr_') === 0) hasUserId = true;
                        if (s.indexOf('authcookie_') === 0 || s.indexOf('eyJ') === 0) hasToken = true;
                        if (s.length > 5) {
                            log('LBC', '  LBC+0x' + off.toString(16) +
                                '->+0x' + off2.toString(16) + ': "' +
                                s.substring(0, 120) + '"');
                        }
                    }
                } catch (e) {}
            }

            if (hasUserId || hasToken) {
                log('LBC', '  *** FOUND AuthValues candidate at LBC+0x' + off.toString(16) + ' ***');
                log('LBC', '  AuthValues dump (128b): ' + hexdump_safe(ptr, 128));
            }
        } catch (e) {}
    }
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
    log('DLL', 'DLL load watcher installed');
}

// =========================================================
// RPC exports for interactive analysis
// =========================================================
rpc.exports = {
    getStatus: function() {
        return {
            hooks: hookCount,
            authCookie: capturedAuthCookie,
            authToken: capturedAuthToken ? capturedAuthToken.substring(0, 50) + '...' : null,
            authResponses: authResponseHistory.length,
            operations: operationHistory.length,
            history: operationHistory.slice(-20)
        };
    },
    getAuthCookie: function() {
        return capturedAuthCookie;
    },
    getOperationHistory: function() {
        return operationHistory;
    },
    dumpMemory: function(addrStr, size) {
        try {
            var p = ptr(addrStr);
            return hexdump_safe(p, size || 256);
        } catch (e) {
            return 'Error: ' + e.message;
        }
    }
};

// =========================================================
// Main
// =========================================================
log('INIT', '=== VRChat AuthCookie Analyzer v1.0 ===');
log('INIT', 'Focus: AuthCookie format, JoinRoom EAC checks');

watchDllLoads();
var gaOk = hookGA();
if (!gaOk) log('INIT', 'GA hooks deferred - will install on DLL load');

log('INIT', hookCount + ' hooks installed');
log('INIT', 'Key events:');
log('INIT', '  AUTH-E3E5/E1A7 - OnCustomAuthenticationResponse (auth data dump)');
log('INIT', '  AUTH-COOKIE - AuthCookie extraction from Photon params');
log('INIT', '  PHOTON-LB - All OperationResponse (focus OpCode 226=JoinRoom)');
log('INIT', '  JOINROOM - Join rejection analysis');
log('INIT', '  TOKEN - GetKeyServerAuthToken capture');
log('INIT', '  LBC - LoadBalancingClient AuthValues scan');
log('INIT', '');
log('INIT', 'RPC: rpc.exports.getStatus(), getAuthCookie(), getOperationHistory()');
