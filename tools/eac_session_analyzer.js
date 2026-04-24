/**
 * eac_session_analyzer.js - EOS Anti-Cheat Session Flow Analyzer
 *
 * Designed for BOTH normal (with EAC) and bypass (without EAC) launches.
 * Traces the full EOS SDK lifecycle to understand:
 * 1. EOS SDK initialization and platform tick behavior
 * 2. Anti-Cheat session lifecycle (BeginSession -> messages -> EndSession)
 * 3. Integrity message timing, sizes, and exchange patterns
 * 4. EOS session token that gets sent to Photon
 * 5. Differences between EAC-active vs EAC-bypassed launches
 *
 * USAGE:
 *   # Normal launch (with EAC active, e.g. via MelonLoader):
 *   frida -l tools/eac_session_analyzer.js -p <VRChat PID>
 *
 *   # Bypass launch (without EAC):
 *   frida -f VRChat.exe -l tools/eac_session_analyzer.js -- --no-vr
 *
 * OUTPUT: Detailed timing analysis, message hex dumps, session state tracking.
 */
'use strict';

// =========================================================
// Globals
// =========================================================
var eosModule = null;
var ga = null;
var BASE = null;
var startTime = Date.now();
var hookCount = 0;

// Session tracking state
var session = {
    eosInitialized: false,
    acInterfaceHandle: null,
    acSessionActive: false,
    beginSessionTime: null,
    beginSessionOptions: null,
    beginSessionResult: null,

    // Message tracking
    messageToServerCallback: null,
    messageToServerCount: 0,
    messageFromServerCount: 0,
    messages: [],           // All integrity messages with timing
    messageSizes: [],       // Size distribution

    // Poll status tracking
    pollCount: 0,
    pollResults: {},        // result code -> count
    lastPollTime: null,
    pollIntervals: [],

    // EOS Auth
    eosLoginCalled: false,
    eosLoginResult: null,
    connectLoginCalled: false,
    connectLoginResult: null,
    productUserId: null,

    // Photon integration
    photonAuthToken: null,

    // Timing
    firstMessageTime: null,
    lastMessageTime: null,
};

function ts() {
    return ((Date.now() - startTime) / 1000).toFixed(3) + 's';
}

function elapsed() {
    return Date.now() - startTime;
}

function log(tag, msg) {
    var line = '[' + ts() + '][' + tag + '] ' + msg;
    send(line);
    console.log(line);
}

function hexdump_safe(ptr, len) {
    try {
        if (ptr.isNull()) return '<NULL>';
        var bytes = ptr.readByteArray(Math.min(len, 1024));
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

function readUtf8Safe(ptr) {
    try {
        if (!ptr || ptr.isNull()) return null;
        return ptr.readUtf8String();
    } catch (e) {
        return null;
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
// EOS SDK Hooks
// =========================================================
function hookEOS() {
    try {
        eosModule = Process.getModuleByName('EOSSDK-Win64-Shipping.dll');
    } catch (e) {
        log('EOS', 'EOSSDK not loaded yet');
        return false;
    }
    log('EOS', 'EOSSDK @ ' + eosModule.base + ' size=0x' + eosModule.size.toString(16));

    // =====================================================
    // EOS Platform
    // =====================================================

    hookExport('EOS_Platform_Create', {
        onEnter: function(args) {
            log('EOS-PLAT', '*** EOS_Platform_Create ***');
            if (isValidPointer(args[0])) {
                log('EOS-PLAT', '  options dump (128b): ' + hexdump_safe(args[0], 128));
                // EOS_Platform_Options: ApiVersion(4), Reserved(ptr), ProductId(ptr), SandboxId(ptr), ...
                try {
                    var productId = args[0].add(16).readPointer();
                    var sandboxId = args[0].add(24).readPointer();
                    var deploymentId = args[0].add(32).readPointer();
                    log('EOS-PLAT', '  ProductId: ' + readUtf8Safe(productId));
                    log('EOS-PLAT', '  SandboxId: ' + readUtf8Safe(sandboxId));
                    log('EOS-PLAT', '  DeploymentId: ' + readUtf8Safe(deploymentId));
                } catch (e) {}
            }
        },
        onLeave: function(ret) {
            log('EOS-PLAT', '  Platform handle: ' + ret);
            session.eosInitialized = true;
        }
    });

    // Track tick frequency (sample first 100, then every 1000th)
    var tickCount = 0;
    var lastTickTime = 0;
    hookExport('EOS_Platform_Tick', {
        onEnter: function(args) {
            tickCount++;
            var now = elapsed();
            if (tickCount <= 100 || tickCount % 1000 === 0) {
                if (lastTickTime > 0) {
                    var interval = now - lastTickTime;
                    if (tickCount <= 5) {
                        log('EOS-TICK', 'Tick #' + tickCount + ' interval=' + interval + 'ms');
                    }
                }
            }
            lastTickTime = now;
        }
    });

    // =====================================================
    // Anti-Cheat Client Interface
    // =====================================================

    hookExport('EOS_Platform_GetAntiCheatClientInterface', {
        onLeave: function(ret) {
            var isNull = ret.isNull();
            log('EOS-AC', 'GetAntiCheatClientInterface -> ' + ret + (isNull ? ' (NULL - no EAC!)' : ' (valid)'));
            if (!isNull) {
                session.acInterfaceHandle = ret.toString();
            }
        }
    });

    // --- BeginSession ---
    hookExport('EOS_AntiCheatClient_BeginSession', {
        onEnter: function(args) {
            log('EOS-AC', '========================================');
            log('EOS-AC', '*** BeginSession ***');
            log('EOS-AC', '  handle=' + args[0]);
            session.beginSessionTime = ts();

            if (isValidPointer(args[1])) {
                // EOS_AntiCheatClient_BeginSessionOptions:
                //   ApiVersion: int32 (+0)
                //   LocalUserId: EOS_ProductUserId (+8)
                //   Mode: EOS_EAntiCheatClientMode (+16)
                log('EOS-AC', '  options dump (64b): ' + hexdump_safe(args[1], 64));
                try {
                    var apiVer = args[1].readInt32();
                    var localUser = args[1].add(8).readPointer();
                    var mode = args[1].add(16).readInt32();

                    log('EOS-AC', '  ApiVersion=' + apiVer);
                    log('EOS-AC', '  LocalUserId=' + localUser);
                    log('EOS-AC', '  Mode=' + mode + ' (' +
                        (mode === 0 ? 'ClientServer' : mode === 1 ? 'PeerToPeer' : 'Unknown') + ')');

                    if (!localUser.isNull()) {
                        session.productUserId = localUser.toString();
                    }

                    session.beginSessionOptions = {
                        apiVersion: apiVer,
                        localUserId: localUser.toString(),
                        mode: mode
                    };
                } catch (e) {}
            }
        },
        onLeave: function(ret) {
            var result = ret.toInt32();
            log('EOS-AC', '  BeginSession result=' + result + ' (' + eosResultName(result) + ')');
            session.beginSessionResult = result;
            session.acSessionActive = (result === 0);
            log('EOS-AC', '========================================');
        }
    });

    // --- AddNotifyMessageToServer ---
    hookExport('EOS_AntiCheatClient_AddNotifyMessageToServer', {
        onEnter: function(args) {
            log('EOS-AC', '*** AddNotifyMessageToServer ***');
            log('EOS-AC', '  handle=' + args[0]);
            log('EOS-AC', '  callback=' + args[3]);
            session.messageToServerCallback = args[3].toString();

            // Intercept the callback to track messages
            if (!args[3].isNull()) {
                hookMessageToServerCallback(args[3]);
            }
        },
        onLeave: function(ret) {
            log('EOS-AC', '  NotifyId=' + ret);
        }
    });

    // --- ReceiveMessageFromServer ---
    hookExport('EOS_AntiCheatClient_ReceiveMessageFromServer', {
        onEnter: function(args) {
            session.messageFromServerCount++;
            var now = ts();

            if (isValidPointer(args[1])) {
                try {
                    var apiVer = args[1].readInt32();
                    var dataLen = args[1].add(8).readInt32();
                    var dataPtr = args[1].add(16).readPointer();

                    var msg = {
                        dir: 'from_server',
                        time: now,
                        elapsed_ms: elapsed(),
                        size: dataLen,
                        index: session.messageFromServerCount,
                    };

                    if (!session.firstMessageTime) {
                        session.firstMessageTime = elapsed();
                    }
                    session.lastMessageTime = elapsed();
                    session.messageSizes.push(dataLen);

                    log('EOS-MSG', 'FromServer #' + session.messageFromServerCount +
                        ' size=' + dataLen + 'b @ ' + now);

                    if (isValidPointer(dataPtr) && dataLen > 0) {
                        msg.hex = hexdump_safe(dataPtr, Math.min(dataLen, 128));
                        log('EOS-MSG', '  data: ' + msg.hex);

                        // Analyze first bytes for message type patterns
                        try {
                            var firstByte = dataPtr.readU8();
                            var secondByte = dataPtr.add(1).readU8();
                            log('EOS-MSG', '  msg type bytes: 0x' +
                                firstByte.toString(16) + ' 0x' + secondByte.toString(16));
                        } catch (e) {}
                    }

                    session.messages.push(msg);
                } catch (e) {
                    log('EOS-MSG', '  Parse error: ' + e.message);
                }
            }
        },
        onLeave: function(ret) {
            var result = ret.toInt32();
            if (result !== 0) {
                log('EOS-MSG', '  ReceiveMessageFromServer failed: ' + result +
                    ' (' + eosResultName(result) + ')');
            }
        }
    });

    // --- PollStatus ---
    hookExport('EOS_AntiCheatClient_PollStatus', {
        onEnter: function(args) {
            this.violationPtr = args[2];
        },
        onLeave: function(ret) {
            session.pollCount++;
            var result = ret.toInt32();
            var key = result.toString();
            session.pollResults[key] = (session.pollResults[key] || 0) + 1;

            var now = elapsed();
            if (session.lastPollTime) {
                session.pollIntervals.push(now - session.lastPollTime);
            }
            session.lastPollTime = now;

            // Log non-success, first few, and periodic samples
            if (result !== 0 || session.pollCount <= 5 || session.pollCount % 100 === 0) {
                log('EOS-POLL', 'PollStatus #' + session.pollCount +
                    ' result=' + result + ' (' + eosResultName(result) + ')');

                if (result !== 0 && isValidPointer(this.violationPtr)) {
                    try {
                        var violationType = this.violationPtr.readInt32();
                        var msgPtr = this.violationPtr.add(8).readPointer();
                        log('EOS-POLL', '  Violation type=' + violationType);
                        if (isValidPointer(msgPtr)) {
                            log('EOS-POLL', '  Violation msg: ' + readUtf8Safe(msgPtr));
                        }
                    } catch (e) {}
                }
            }
        }
    });

    // --- EndSession ---
    hookExport('EOS_AntiCheatClient_EndSession', {
        onEnter: function(args) {
            log('EOS-AC', '*** EndSession ***');
            log('EOS-AC', '  Session was active for ' +
                (session.beginSessionTime ? (elapsed() - parseInt(session.beginSessionTime)) : '?') + 'ms');
            printSessionSummary();
        },
        onLeave: function(ret) {
            log('EOS-AC', '  EndSession result=' + ret.toInt32());
            session.acSessionActive = false;
        }
    });

    // =====================================================
    // Anti-Cheat notification hooks
    // =====================================================
    hookExport('EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged', {
        onEnter: function(args) {
            log('EOS-AC', 'AddNotifyPeerAuthStatusChanged callback=' + args[3]);
        }
    });

    hookExport('EOS_AntiCheatClient_AddNotifyClientIntegrityViolated', {
        onEnter: function(args) {
            log('EOS-AC', 'AddNotifyClientIntegrityViolated callback=' + args[3]);
            // Hook the callback
            if (!args[3].isNull()) {
                try {
                    Interceptor.attach(args[3], {
                        onEnter: function(cbArgs) {
                            log('EOS-VIOLATION', '!!! CLIENT INTEGRITY VIOLATED !!!');
                            if (isValidPointer(cbArgs[0])) {
                                log('EOS-VIOLATION', '  data dump: ' + hexdump_safe(cbArgs[0], 64));
                            }
                        }
                    });
                } catch (e) {}
            }
        }
    });

    // =====================================================
    // EOS Auth & Connect
    // =====================================================

    hookExport('EOS_Auth_Login', {
        onEnter: function(args) {
            log('EOS-AUTH', '*** EOS_Auth_Login ***');
            session.eosLoginCalled = true;
            if (isValidPointer(args[1])) {
                log('EOS-AUTH', '  options dump (64b): ' + hexdump_safe(args[1], 64));
            }
        }
    });

    hookExport('EOS_Connect_Login', {
        onEnter: function(args) {
            log('EOS-CONN', '*** EOS_Connect_Login ***');
            session.connectLoginCalled = true;
            if (isValidPointer(args[1])) {
                log('EOS-CONN', '  options dump (64b): ' + hexdump_safe(args[1], 64));
                // EOS_Connect_LoginOptions has Credentials at +8
                try {
                    var creds = args[1].add(8).readPointer();
                    if (isValidPointer(creds)) {
                        log('EOS-CONN', '  credentials dump (64b): ' + hexdump_safe(creds, 64));
                        // Credentials: ApiVersion(4), Token(ptr), Type(int)
                        var tokenPtr = creds.add(8).readPointer();
                        var type = creds.add(16).readInt32();
                        log('EOS-CONN', '  CredentialType=' + type);
                        if (isValidPointer(tokenPtr)) {
                            var token = readUtf8Safe(tokenPtr);
                            if (token) {
                                log('EOS-CONN', '  Token (' + token.length + ' chars): "' +
                                    token.substring(0, 100) + '"...');
                            }
                        }
                    }
                } catch (e) {}
            }
        }
    });

    hookExport('EOS_Connect_GetProductUserId', {
        onLeave: function(ret) {
            log('EOS-CONN', 'GetProductUserId -> ' + ret);
            if (!ret.isNull()) {
                session.productUserId = ret.toString();
            }
        }
    });

    hookExport('EOS_Connect_CopyIdToken', {
        onEnter: function(args) {
            log('EOS-CONN', '*** CopyIdToken ***');
        },
        onLeave: function(ret) {
            log('EOS-CONN', '  CopyIdToken result=' + ret.toInt32());
        }
    });

    // EOS_ProductUserId_ToString - captures the string form of ProductUserId
    hookExport('EOS_ProductUserId_ToString', {
        onEnter: function(args) {
            this.bufPtr = args[1];
            this.bufLen = args[2];
        },
        onLeave: function(ret) {
            if (ret.toInt32() === 0 && isValidPointer(this.bufPtr)) {
                var userId = readUtf8Safe(this.bufPtr);
                if (userId) {
                    log('EOS-CONN', '  ProductUserId string: "' + userId + '"');
                    session.productUserId = userId;
                }
            }
        }
    });

    // =====================================================
    // EOS Session Token (for Photon)
    // =====================================================

    // EOS_Auth_CopyUserAuthToken - may contain token sent to Photon
    hookExport('EOS_Auth_CopyUserAuthToken', {
        onEnter: function(args) {
            this.outToken = args[2]; // EOS_Auth_Token**
        },
        onLeave: function(ret) {
            if (ret.toInt32() === 0 && isValidPointer(this.outToken)) {
                try {
                    var tokenPtr = this.outToken.readPointer();
                    if (isValidPointer(tokenPtr)) {
                        log('EOS-TOKEN', '*** Auth Token Captured ***');
                        log('EOS-TOKEN', '  token struct dump (128b): ' + hexdump_safe(tokenPtr, 128));
                        // EOS_Auth_Token: ApiVersion(4), App(ptr), ClientId(ptr), AccountId(ptr),
                        //   AccessToken(ptr), ExpiresIn(double), ExpiresAt(ptr), ...
                        try {
                            var accessToken = tokenPtr.add(32).readPointer();
                            if (isValidPointer(accessToken)) {
                                var token = readUtf8Safe(accessToken);
                                if (token) {
                                    log('EOS-TOKEN', '  AccessToken: "' + token.substring(0, 100) + '"...');
                                    session.photonAuthToken = token;
                                }
                            }
                        } catch (e) {}
                    }
                } catch (e) {}
            }
        }
    });

    log('EOS', 'All EOS hooks installed (' + hookCount + ')');
    return true;
}

function hookExport(name, callbacks) {
    try {
        var addr = eosModule.findExportByName(name);
        if (!addr) return;
        Interceptor.attach(addr, callbacks);
        hookCount++;
    } catch (e) {}
}

// =========================================================
// MessageToServer callback interceptor
// =========================================================
function hookMessageToServerCallback(callbackAddr) {
    try {
        Interceptor.attach(callbackAddr, {
            onEnter: function(args) {
                session.messageToServerCount++;
                var now = ts();

                // EOS_AntiCheatClient_OnMessageToServerCallbackInfo:
                //   ClientData: ptr (+0)
                //   MessageData: ptr (+8)
                //   MessageDataSizeBytes: uint32 (+16)
                var callbackInfo = args[0];
                if (!isValidPointer(callbackInfo)) return;

                try {
                    var msgData = callbackInfo.add(8).readPointer();
                    var msgSize = callbackInfo.add(16).readU32();

                    var msg = {
                        dir: 'to_server',
                        time: now,
                        elapsed_ms: elapsed(),
                        size: msgSize,
                        index: session.messageToServerCount,
                    };

                    if (!session.firstMessageTime) {
                        session.firstMessageTime = elapsed();
                    }
                    session.lastMessageTime = elapsed();
                    session.messageSizes.push(msgSize);

                    log('EOS-MSG', '*** ToServer #' + session.messageToServerCount +
                        ' size=' + msgSize + 'b @ ' + now + ' ***');

                    if (isValidPointer(msgData) && msgSize > 0) {
                        msg.hex = hexdump_safe(msgData, Math.min(msgSize, 128));
                        log('EOS-MSG', '  data: ' + msg.hex);

                        // Analyze message structure
                        try {
                            var header = msgData.readByteArray(Math.min(msgSize, 4));
                            var headerBytes = new Uint8Array(header);
                            log('EOS-MSG', '  header bytes: 0x' +
                                Array.from(headerBytes).map(function(b) {
                                    return ('0' + b.toString(16)).slice(-2);
                                }).join(' '));
                        } catch (e) {}
                    }

                    session.messages.push(msg);
                } catch (e) {
                    log('EOS-MSG', '  Parse error: ' + e.message);
                }
            }
        });
        hookCount++;
        log('EOS-AC', 'MessageToServer callback interceptor installed');
    } catch (e) {
        log('EOS-AC', 'Failed to hook callback: ' + e.message);
    }
}

// =========================================================
// GameAssembly hooks (for Photon-EAC integration)
// =========================================================
function hookGA() {
    try {
        ga = Process.getModuleByName('GameAssembly.dll');
        BASE = ga.base;
    } catch (e) {
        return false;
    }
    log('GA', 'GameAssembly.dll @ ' + BASE);

    var GA_RVA = {
        GetKeyServerAuthToken: 0x112A080,
        OnCustomAuthResponse_E3E5: 0x211A240,
        OnOperationResponse_LB: 0x2149830,
    };

    // --- GetKeyServerAuthToken - capture the token that goes to Photon ---
    hookRVA('GetKeyServerAuthToken', GA_RVA.GetKeyServerAuthToken, {
        onLeave: function(ret) {
            if (isValidPointer(ret)) {
                var token = readIl2cppString(ret);
                if (token) {
                    log('GA-TOKEN', '  Photon auth token (' + token.length + ' chars)');
                    log('GA-TOKEN', '  First 100: "' + token.substring(0, 100) + '"');

                    // Check for EAC data in token
                    var hasEac = token.toLowerCase().indexOf('eac') !== -1 ||
                                 token.indexOf('anticheat') !== -1;
                    log('GA-TOKEN', '  Contains EAC data: ' + (hasEac ? 'YES' : 'NO'));

                    session.photonAuthToken = token;
                }
            }
        }
    });

    // --- OnCustomAuthResponse - capture what Photon server returns ---
    hookRVA('OnCustomAuthResponse', GA_RVA.OnCustomAuthResponse_E3E5, {
        onEnter: function(args) {
            log('GA-AUTH', '*** OnCustomAuthResponse ***');
            log('GA-AUTH', '  EAC session active: ' + session.acSessionActive);
            log('GA-AUTH', '  Messages sent to server: ' + session.messageToServerCount);
            log('GA-AUTH', '  Messages from server: ' + session.messageFromServerCount);
        }
    });

    // --- OnOperationResponse - track auth + join ops ---
    hookRVA('OnOperationResponse_LB', GA_RVA.OnOperationResponse_LB, {
        onEnter: function(args) {
            var resp = args[1];
            if (!resp || resp.isNull()) return;
            try {
                var opCode = resp.add(0x10).readU8();
                var retCode = resp.add(0x12).readS16();

                if (opCode === 230 || opCode === 231) {
                    log('GA-OP', 'Auth response OpCode=' + opCode + ' RetCode=' + retCode);
                    log('GA-OP', '  EAC session: ' + (session.acSessionActive ? 'ACTIVE' : 'INACTIVE'));
                    log('GA-OP', '  EAC messages: ' + session.messageToServerCount +
                        ' to server, ' + session.messageFromServerCount + ' from server');
                }

                if (opCode === 226 || opCode === 227) {
                    log('GA-OP', '*** JoinRoom response OpCode=' + opCode + ' RetCode=' + retCode + ' ***');
                    if (retCode !== 0) {
                        log('GA-OP', '  !!! JOIN REJECTED (likely EAC check failed) !!!');
                        var debugMsg = resp.add(0x18).readPointer();
                        if (isValidPointer(debugMsg)) {
                            log('GA-OP', '  DebugMsg: "' + (readIl2cppString(debugMsg) || '<empty>') + '"');
                        }
                    }
                }
            } catch (e) {}
        }
    });

    log('GA', 'GA hooks installed');
    return true;
}

function hookRVA(name, rva, callbacks) {
    try {
        Interceptor.attach(BASE.add(rva), callbacks);
        hookCount++;
    } catch (e) {
        log('HOOK', 'FAILED: ' + name + ': ' + e.message);
    }
}

// =========================================================
// EOS Result code names
// =========================================================
function eosResultName(code) {
    var names = {
        0: 'Success',
        1: 'NoConnection',
        2: 'InvalidCredentials',
        3: 'InvalidUser',
        4: 'InvalidAuth',
        5: 'AccessDenied',
        6: 'MissingPermissions',
        7: 'Token_Not_Account',
        8: 'TooManyRequests',
        9: 'AlreadyPending',
        10: 'InvalidParameters',
        11: 'InvalidRequest',
        12: 'UnrecognizedResponse',
        13: 'IncompatibleVersion',
        14: 'NotConfigured',
        15: 'AlreadyConfigured',
        16: 'NotImplemented',
        17: 'Canceled',
        18: 'NotFound',
        19: 'OperationWillRetry',
        20: 'NoChange',
        21: 'VersionMismatch',
        22: 'LimitExceeded',
        23: 'Disabled',
        1000: 'AntiCheat_ClientIntegrityViolation',
    };
    return names[code] || ('Unknown_' + code);
}

// =========================================================
// Session Summary
// =========================================================
function printSessionSummary() {
    log('SUMMARY', '========================================');
    log('SUMMARY', '=== EAC Session Summary ===');
    log('SUMMARY', '  EOS Initialized: ' + session.eosInitialized);
    log('SUMMARY', '  AC Interface: ' + (session.acInterfaceHandle || 'NULL'));
    log('SUMMARY', '  Session Active: ' + session.acSessionActive);
    log('SUMMARY', '  BeginSession Result: ' + session.beginSessionResult +
        ' (' + eosResultName(session.beginSessionResult) + ')');
    log('SUMMARY', '');
    log('SUMMARY', '  --- Message Statistics ---');
    log('SUMMARY', '  ToServer count: ' + session.messageToServerCount);
    log('SUMMARY', '  FromServer count: ' + session.messageFromServerCount);
    log('SUMMARY', '  Total messages: ' + session.messages.length);

    if (session.messageSizes.length > 0) {
        var sizes = session.messageSizes;
        var minSize = Math.min.apply(null, sizes);
        var maxSize = Math.max.apply(null, sizes);
        var avgSize = sizes.reduce(function(a, b) { return a + b; }, 0) / sizes.length;
        log('SUMMARY', '  Message sizes: min=' + minSize + ' max=' + maxSize +
            ' avg=' + avgSize.toFixed(0));
    }

    if (session.firstMessageTime && session.lastMessageTime) {
        var duration = session.lastMessageTime - session.firstMessageTime;
        log('SUMMARY', '  Message exchange duration: ' + duration + 'ms');
        if (session.messages.length > 1) {
            var avgInterval = duration / (session.messages.length - 1);
            log('SUMMARY', '  Average message interval: ' + avgInterval.toFixed(0) + 'ms');
        }
    }

    log('SUMMARY', '');
    log('SUMMARY', '  --- Poll Statistics ---');
    log('SUMMARY', '  Total polls: ' + session.pollCount);
    log('SUMMARY', '  Results: ' + JSON.stringify(session.pollResults));

    if (session.pollIntervals.length > 0) {
        var intervals = session.pollIntervals;
        var avgPoll = intervals.reduce(function(a, b) { return a + b; }, 0) / intervals.length;
        log('SUMMARY', '  Average poll interval: ' + avgPoll.toFixed(0) + 'ms');
    }

    log('SUMMARY', '');
    log('SUMMARY', '  --- EOS Auth ---');
    log('SUMMARY', '  EOS_Auth_Login called: ' + session.eosLoginCalled);
    log('SUMMARY', '  EOS_Connect_Login called: ' + session.connectLoginCalled);
    log('SUMMARY', '  ProductUserId: ' + (session.productUserId || '<none>'));
    log('SUMMARY', '  Photon auth token: ' + (session.photonAuthToken ?
        session.photonAuthToken.substring(0, 50) + '...' : '<none>'));

    log('SUMMARY', '========================================');
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
            if (lower.indexOf('eossdk') !== -1 && !eosModule) {
                log('DLL', 'EOSSDK loaded: ' + this.name);
                hookEOS();
            }
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
    getSession: function() {
        return session;
    },
    getSummary: function() {
        printSessionSummary();
        return session;
    },
    getMessages: function() {
        return session.messages;
    },
    getMessageStats: function() {
        return {
            toServer: session.messageToServerCount,
            fromServer: session.messageFromServerCount,
            sizes: session.messageSizes,
            pollCount: session.pollCount,
            pollResults: session.pollResults,
        };
    },
    compareMode: function() {
        // Quick comparison report for with/without EAC
        log('COMPARE', '=== EAC Mode Comparison Data ===');
        log('COMPARE', 'AC Interface: ' + (session.acInterfaceHandle ? 'PRESENT' : 'NULL'));
        log('COMPARE', 'BeginSession: ' + eosResultName(session.beginSessionResult));
        log('COMPARE', 'Session Active: ' + session.acSessionActive);
        log('COMPARE', 'Messages exchanged: ' + session.messages.length);
        log('COMPARE', 'ProductUserId: ' + (session.productUserId || 'NONE'));
        log('COMPARE', '');
        log('COMPARE', 'If AC Interface is NULL and 0 messages:');
        log('COMPARE', '  -> EAC not running (bypass mode)');
        log('COMPARE', 'If AC Interface valid, BeginSession=Success, messages flowing:');
        log('COMPARE', '  -> EAC active (normal mode)');
        return {
            acInterface: session.acInterfaceHandle,
            beginResult: session.beginSessionResult,
            sessionActive: session.acSessionActive,
            messageCount: session.messages.length,
        };
    }
};

// =========================================================
// Main
// =========================================================
log('INIT', '=== EAC Session Analyzer v1.0 ===');
log('INIT', 'Tracks EOS Anti-Cheat lifecycle, message patterns, and Photon integration');

watchDllLoads();
var eosOk = hookEOS();
var gaOk = hookGA();

if (!eosOk) log('INIT', 'EOS hooks deferred - EOSSDK not loaded yet');
if (!gaOk) log('INIT', 'GA hooks deferred');

log('INIT', hookCount + ' hooks installed');
log('INIT', '');
log('INIT', 'RPC:');
log('INIT', '  rpc.exports.getSession()     -- full session state');
log('INIT', '  rpc.exports.getSummary()      -- print + return summary');
log('INIT', '  rpc.exports.getMessages()     -- all integrity messages');
log('INIT', '  rpc.exports.getMessageStats() -- message statistics');
log('INIT', '  rpc.exports.compareMode()     -- EAC vs bypass comparison');
log('INIT', '');
log('INIT', 'Run with EAC active (MelonLoader) and without (bypass) to compare.');
