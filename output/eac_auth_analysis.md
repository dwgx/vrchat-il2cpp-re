# VRChat EAC/EOS Authentication Analysis

## Executive Summary

VRChat uses Epic Online Services (EOS) Anti-Cheat in **Client-Server mode**. The server continuously validates clients via opaque encrypted message exchanges. Without a real EAC session, the server restricts the client (cannot join rooms). **Forging these messages is not feasible** — they are encrypted/signed internally by the EOS SDK.

## EOS Anti-Cheat Protocol (from Epic documentation)

### Message Exchange Flow

```
CLIENT                                    SERVER
  |                                          |
  |--- EOS_AntiCheatClient_BeginSession ---> |--- EOS_AntiCheatServer_RegisterClient
  |                                          |    (starts RegisterTimeout timer)
  |                                          |
  |<-- opaque message (integrity check) -----|--- AddNotifyMessageToClient callback
  |--- EOS_AntiCheatClient_ReceiveMsg        |
  |                                          |
  |--- opaque message (response) ----------->|--- EOS_AntiCheatServer_ReceiveMessageFromClient
  |    (via AddNotifyMessageToServer)        |    (validates integrity)
  |                                          |
  |  ... continuous exchange during session ...|
  |                                          |
  | (if client stops sending)                |--- AuthenticationFailed timeout
  |                                          |--- ClientActionRequired: remove client
```

### Key Properties

1. **Messages are opaque**: EOS SDK encrypts/signs them internally. Games forward without interpretation.
2. **Continuous validation**: Not a one-time handshake. Messages exchange throughout the session.
3. **Timeout enforcement**: If `RegisterTimeout` expires with no valid client messages, server kicks.
4. **Bidirectional**: Server also sends messages to client for validation.

## VRChat's EAC Integration

### Normal Launch (with EAC)

```
Steam → launch.exe → EasyAntiCheat_EOS_Setup.exe → VRChat.exe
                      ↓
                 EAC kernel driver loads
                 EOSSDK-Win64-Shipping.dll initializes
                 BeginSession activates protection
                 Integrity messages start flowing
```

### Our Bypass Launch (without EAC)

```
Steam → launch_bypass.exe → VRChat.exe (direct)
                             ↓
                        No EAC kernel driver
                        EOSSDK initializes but BeginSession has no EAC context
                        No integrity messages generated
                        Server detects missing messages → restricts client
```

### What the Server Validates

Based on protocol analysis and observed behavior:

1. **VRChat API Auth**: Steam ticket → VRChat API → JWT token ✓ (works without EAC)
2. **Photon Custom Auth**: VRChat API token → Photon OpCode 231 → OnCustomAuthenticationResponse ✓ (works)
3. **EOS Anti-Cheat Session**: Continuous opaque messages → Server validates ✗ (fails without EAC)
4. **Room Join Permission**: Server checks EAC status before allowing JoinRoom/CreateRoom ✗ (rejected)

The "Failed to join instance...due to ''" error means: Photon server received the join request, checked EAC status, found no valid session, and silently rejected.

## VRC-EOSDisabler (Reference)

The [VRC-EOSDisabler](https://github.com/Umbra999/VRC-EOSDisabler) tool blocks EOS **telemetry** hosts via system hosts file, but does NOT disable EAC itself. EAC still runs, integrity messages still flow, and users can still play online. This confirms:

- **EAC local validation + message exchange is required for room joins**
- **Blocking analytics/telemetry does NOT affect gameplay**
- **The core EAC session must be real (not faked) for server acceptance**

## Approaches Analysis

### 1. Forge EOS Messages ❌ Not Feasible
Messages are opaque, encrypted, and signed by the EOS SDK. Without the SDK's internal keys, messages cannot be generated externally. The entire point of the protocol is to prevent this.

### 2. Run Real EAC + Frida ❌ Blocked by Kernel Driver
EAC kernel driver (`EasyAntiCheat.sys`) prevents:
- Process memory access from external tools
- Code injection (DLL injection, Frida attach)
- Debug API usage

### 3. MelonLoader under EAC ✅ Most Viable
MelonLoader uses a bootstrapper that loads before EAC validation. It's a well-established approach:
- Launch through normal EAC (launch.exe → EAC → VRChat.exe)
- MelonLoader loads via `version.dll` proxy or similar
- Harmony patches applied at IL2CPP level
- EAC runs normally, integrity messages flow
- Room joins work, Frida NOT available
- C# Harmony provides similar hooking power to Frida for specific use cases

### 4. EAC Kernel Driver Bypass ⚠️ High Risk/Difficulty
Preventing EAC kernel driver while keeping userspace EOS SDK happy:
- Block driver loading via driver signing policy
- Or use hypervisor to hide Frida from EAC
- Extremely complex, fragile, and potentially bannable

### 5. Hybrid Approach ✅ Recommended
Use **two separate workflows**:
- **Online (with EAC)**: Normal launch + MelonLoader mods for Harmony hooking
- **Offline (without EAC)**: Bypass launch + Frida for deep runtime analysis
- Share findings between workflows via the deobfuscation pipeline

## Photon Authentication Token Details

From log analysis, the VRChat Photon auth flow:

```
+0.0s  Steam connection initialized
+0.2s  [Behaviour] authenticating
+0.3s  User Authenticated: dwgx (usr_xxx) — via VRChat API
+0.3s  Using nameserver host: ns.photonengine.io
+22s   OnCustomAuthenticationResponse — Photon auth successful
+22s   OnConnectedToMaster — connected to master in jp
```

The Photon custom auth includes:
- `AuthType`: Custom (VRChat-specific)
- `Token`: VRChat API session token
- `UserId`: VRChat user ID
- Possibly: EAC session identifier or status flag

The join rejection happens at the Photon room level, not during initial auth. This means:
- Photon auth itself succeeds (API + Steam ticket verified)
- Room operations are gated by additional checks (EAC session status)
- The server maintains an EAC session status per client
- Clients without valid EAC are "authenticated but restricted"

## Conclusion (Updated 2026-04-16)

The server-side EAC validation is a fundamental barrier for online play without EAC.

### Updated Stealth Assessment (April 2026)

| Approach | Viability | Risk | Notes |
|----------|-----------|------|-------|
| **Offline Frida (bypass mode)** | ✅ Works | None | Full analysis power, no online features |
| **Photon packet capture** | ✅ Works | None | Headers/opcodes visible, payload AES-256 encrypted |
| **MelonLoader + Harmony** | ❌ Dead | **Ban** | EAC detects DLL proxy injection in 2026, auto-ban |
| **DMA read-only (75T FPGA)** | ✅ Works | Low | Requires 1:1 donor firmware emulation, second PC |
| **Hypervisor-based Frida** | ⚠️ Risky | Medium | EAC detects virtualization (CPUID, timing) |
| **EOS message forgery** | ❌ Impossible | N/A | Messages are opaque, encrypted, signed by SDK |
| **Kernel Frida alternative** | ⚠️ Risky | High | EAC kernel driver monitors driver loading |

### Recommended Path (2026)

1. **For deep runtime analysis**: Continue offline bypass + Frida (current workflow)
2. **For protocol research**: `photon_packet_capture.py` — header/opcode/timing analysis
3. **For online memory reading**: DMA hardware (if available) — zero software footprint
4. **For online behavior study**: Static analysis of deobfuscated dump + offline probe extrapolation
5. **NOT recommended**: MelonLoader, Harmony patching, or any process modification while EAC is active

## Detailed Token Chain (Added 2026-04-09)

### Full 4-Token Authentication Chain

| # | Token | Source | Consumer | Transport |
|---|---|---|---|---|
| 1 | Steam App Ticket | `SteamAPI_ISteamUser_GetAuthSessionTicket` | VRChat API (`api.vrchat.cloud`) | HTTPS POST |
| 2 | VRChat API Token | VRChat API login response | Photon Custom Auth | Photon OpCode 230/231 AuthValues |
| 3 | Photon Auth Token | `PlatformOptions.GetKeyServerAuthToken` (RVA `0x112A080`) | Photon Name Server | OpCode 231 (AuthenticateOnce) |
| 4 | EAC Session Token | EOS SDK `AddNotifyMessageToServer` callback | Photon server plugin / VRChat backend | Unknown (via Photon property or webhook) |

### Token Injection Points in Code

| Function | RVA | Role |
|---|---|---|
| `VRCFlowManager.AuthenticateWithSteam` | `0x1F1A8A0` | Initiates Steam -> VRChat API login |
| `_AuthenticateWithSteamCoroutine_d__79` | (coroutine) | Async Steam auth state machine |
| `PlatformOptions.GetKeyServerAuthToken` | `0x112A080` | Assembles the Photon auth key (may include EAC data) |
| `MatchmakingArguments.AuthValues` | field +0x40 | Photon auth values container |
| `MatchmakingArguments.Ticket` | field +0x80 | Opaque ticket object |
| `PhotonConnectionHandler_34AB.OnConnectedToMaster` | `0x19572F0` | Photon connected |
| `PhotonConnectionHandler_34AB.OnCustomAuthFailed` | `0x1956DE0` | Auth rejection |
| `PhotonConnectionHandler_E3E5.OnCustomAuthResponse` | `0x211A240` | Auth success (aggregator) |
| `PhotonConnectionHandler_E3E5.OnCustomAuthFailed` | `0x2119090` | Auth failure (aggregator) |
| `PhotonRoomHandler_E1A7.OnCustomAuthResponse` | `0x1A99BE0` | Room-level auth success |
| `OnOperationResponse (LoadBalancing)` | `0x2149830` | All Photon op responses |
| `OnOperationResponse (VRCNetworkingPeer)` | `0x15A2500` | VRC-level op handling |

### Server-Side Validation Timeline

```
[+0s]  Steam ticket generated (client-local)
[+0.2s] VRChat API login (HTTPS) -- Token 1 -> Token 2
[+0.3s] EOS_AntiCheatClient_BeginSession -- Token 4 starts generating
[+1-3s] AddNotifyMessageToServer callback fires (integrity data ready)
[+5s]   Photon Connect (AuthenticateOnce, OpCode 231)
         -> Sends Token 2 + Token 3 (assembled by GetKeyServerAuthToken)
         -> Server webhook validates against VRChat API
[+22s]  OnCustomAuthenticationResponse -- Photon auth OK
[+22s]  OnConnectedToMaster
[+23s]  JoinRoom (OpCode 226)
         -> Server checks: auth? YES. EAC session? [NO in bypass]
         -> Empty error rejection
```

## trace_auth_flow.js Hook Summary (Added 2026-04-09)

Frida script at `tools/trace_auth_flow.js` hooks all auth-related paths:

### EOS SDK (by export name from EOSSDK-Win64-Shipping.dll)
- `EOS_AntiCheatClient_BeginSession` -- session start with options struct dump
- `EOS_AntiCheatClient_AddNotifyMessageToServer` -- callback registration
- `EOS_AntiCheatClient_PollStatus` -- periodic status (non-success only)
- `EOS_AntiCheatClient_ReceiveMessageFromServer` -- incoming server data with hex dump
- `EOS_AntiCheatClient_EndSession` -- session end
- `EOS_Auth_*` (12 functions) -- EOS account authentication
- `EOS_Connect_*` (8 functions) -- EOS product user / connect auth

### Steam API (by export name from steam_api64.dll)
- `SteamAPI_ISteamUser_GetAuthSessionTicket` -- captures ticket bytes + length
- `SteamAPI_ISteamUser_GetAuthTicketForWebApi` -- web API variant

### GameAssembly.dll (by RVA, ASLR-resolved at runtime)
- `AuthenticateWithSteam` (0x1F1A8A0) -- VRChat Steam login trigger + field scan
- `GetKeyServerAuthToken` (0x112A080) -- Photon auth token assembly + return value
- `OnConnectedToMaster` x2 (0x19572F0, 0x211A830) -- timing markers
- `OnCustomAuthenticationResponse` x2 (0x211A240, 0x1A99BE0) -- success data dump
- `OnCustomAuthenticationFailed` x2 (0x1956DE0, 0x2119090) -- error string extraction
- `OnOperationResponse` x2 (0x2149830, 0x15A2500) -- OpCode 230/231 filter with full dump

### Usage
```bash
# Attach to running VRChat (offline)
frida -l tools/trace_auth_flow.js -p <VRChat PID>

# Spawn with script
frida -f VRChat.exe -l tools/trace_auth_flow.js -- --no-vr
```

### Key investigation questions the script answers:
1. Does `GetKeyServerAuthToken` return anything in bypass mode?
2. What data flows through `OnCustomAuthenticationResponse` on success?
3. What exact error string appears in `OnCustomAuthenticationFailed`?
4. Does `BeginSession` get called at all? With what parameters?
5. Does `AddNotifyMessageToServer` callback ever fire?
6. What OpCode 230/231 response data does the server return?

## Photon Server-Side Validation Architecture (from web research)

### How VRChat Validates EAC on Server

VRChat uses Photon Server Plugins with webhook-based custom authentication:

```
Client                  Photon Server           VRChat API (webhook)
  |--- AuthenticateOnce --->|                         |
  |    (OpCode 231)         |--- webhook POST ------->|
  |    AuthValues:          |    (Steam ticket,       |
  |    - Token (API token)  |     EAC status,         |
  |    - AuthType (Custom)  |     client info)         |
  |                         |                          |
  |                         |<-- AuthCookie + result --|
  |                         |    (contains EAC status) |
  |<-- OnCustomAuthResp ----|                          |
  |                         |                          |
  |--- JoinRoom (Op 226) -->|                          |
  |                         |-- BeforeJoin hook:       |
  |                         |   check AuthCookie       |
  |                         |   EAC status valid? ---->| (if plugin validates)
  |                         |   YES -> allow join      |
  |                         |   NO  -> Fail("")        |
  |<-- empty error ---------|                          |
```

### Key Architecture Points

1. **AuthCookie**: Set during initial Photon custom auth. Contains user info + EAC validation status.
   Accessible via `ICallInfo.AuthCookie` in Photon Server Plugins.
2. **BeforeJoin hook**: Photon plugin can call `Fail(msg)` to reject room joins.
   The empty error string "" is likely from `Fail("")` in VRChat's server plugin.
3. **Webhook validation**: VRChat API (`api.vrchat.cloud`) validates the client during custom auth.
   The API response becomes the AuthCookie for the Photon session.
4. **AuthCookie is opaque to Photon**: Only VRChat's plugin code reads it.

### GetKeyServerAuthToken (RVA 0x112A080)

Simple getter function:
```
return this->field_0x18->field_0x10;  // nested object field access
```
The auth token is pre-assembled during authentication and stored in PlatformOptions.
Use trace_auth_flow.js to capture its runtime value.

## Prior Art: vrc-eac-emulator (patched 2025/05/23)

[0liteyear/vrc-eac-emulator](https://github.com/0liteyear/vrc-eac-emulator) used a Linux-Windows proxy architecture:

1. Replace `EOSSDK-Win64-Shipping.dll` on Windows with hook DLL
2. Run real EAC on Linux/Wine (weaker integrity checks)
3. Proxy EAC integrity messages via TCP:7777 + HTTP:7778
4. Linux EAC generates valid messages -> forwarded to VRChat server
5. Server sees valid EAC session -> allows room joins

**Why it was patched**: VRChat likely added checks for:
- EAC client environment fingerprinting (Wine detection)
- Message source validation (session binding)
- DLL integrity verification

**Lesson**: Server-side EAC validation CAN be satisfied if real EAC messages are provided.
The challenge is getting a real EAC session that:
- Runs on the same machine as VRChat
- Generates valid messages for the correct session
- Doesn't block analysis tools (Frida)

## Theoretical Attack Vectors (for research purposes)

### 1. AuthCookie Injection
If we could modify the AuthCookie during Photon custom auth to include valid EAC status,
room joins would work. Requires:
- MITM the Photon auth webhook response
- Or modify the Photon client's auth response processing

### 2. Dual-Session Proxy (vrc-eac-emulator approach)
Run real EAC in a separate process/VM, proxy messages.
Patched but the concept is sound. Would need:
- Updated DLL hooks for current VRChat version
- Anti-detection measures for the proxy

### 3. Photon Plugin Bypass
If VRChat's Photon plugin has a code path that doesn't check EAC
(e.g., local instances, certain join methods), exploit that path.
Unconfirmed whether such paths exist.

### 4. EAC Coexistence
Run EAC normally but find a window for Frida injection:
- After EAC validates but before it locks memory
- Using hypervisor to hide Frida from EAC
- Kernel-level Frida alternative that EAC doesn't detect

## Analysis Tools (Added 2026-04-09)

Three new Frida scripts for deep AuthCookie and EAC session analysis:

### tools/analyze_authcookie.js

Focuses on AuthCookie format and JoinRoom EAC validation.

**Hooks:**
- `OnCustomAuthenticationResponse` at both RVAs (0x211A240, 0x1A99BE0) -- deep dumps response data structure, scans all string fields, attempts Dictionary parsing
- `OnOperationResponse` (LoadBalancing 0x2149830 + VRCNetworkingPeer 0x15A2500) -- logs ALL Photon operations, special handling for OpCode 226 (JoinRoom) rejections
- `GetKeyServerAuthToken` (0x112A080) -- captures the assembled auth token with nested object traversal
- `OnConnectedToMaster` (0x19572F0) -- scans handler for LoadBalancingClient reference and AuthValues

**Key Features:**
- Photon OperationResponse parser (opCode, retCode, debugMessage, parameters dictionary)
- Dictionary<byte, object> parser for Photon auth response parameters
- AuthCookie extraction from param key 2 in auth response
- LoadBalancingClient.AuthValues scanner
- RPC exports: `getStatus()`, `getAuthCookie()`, `getOperationHistory()`

**Usage:**
```bash
frida -l tools/analyze_authcookie.js -p <VRChat PID>
```

### tools/intercept_photon_auth.js

Intercepts auth at the transport and IL2CPP layers. Optional injection mode.

**Hooks:**
- All `analyze_authcookie.js` hooks plus:
- `ws2_32!send` / `ws2_32!recv` / `WSASend` -- raw Photon wire traffic (filters on Photon header bytes 0xF3, 0xFB, 0xFD)
- `WinHttpSendRequest` -- WebSocket upgrade detection
- `AuthenticateWithSteam` (0x1F1A8A0) -- scans VRCFlowManager fields for JWT, API tokens, user IDs

**Key Features:**
- Transport layer Photon packet capture
- AuthValues deep scanner (finds usr_ strings, authcookie_ prefixed tokens, JWTs)
- Experimental injection framework via RPC:
  - `setInjectMode(true)` -- enable modification (use with extreme caution)
  - `setInjectCookie({key: value})` -- set cookie data for injection
  - `writeIl2cppString(addr, value)` -- overwrite IL2CPP string in memory
- `getState()` returns captured photonSecret, authCookieAddr, authValuesAddr, lbcAddr

**Usage:**
```bash
frida -l tools/intercept_photon_auth.js -p <VRChat PID>
# Then via Python/REPL:
# script.exports.get_state()
# script.exports.dump_auth_cookie_now()
```

### tools/eac_session_analyzer.js

Comprehensive EOS Anti-Cheat lifecycle tracer. Designed for comparison between EAC-active and bypass modes.

**EOS SDK Hooks:**
- `EOS_Platform_Create` -- ProductId, SandboxId, DeploymentId extraction
- `EOS_Platform_Tick` -- tick frequency sampling
- `EOS_Platform_GetAntiCheatClientInterface` -- NULL detection (bypass indicator)
- `EOS_AntiCheatClient_BeginSession` -- full options dump (LocalUserId, Mode)
- `EOS_AntiCheatClient_AddNotifyMessageToServer` -- callback interception with per-message logging
- `EOS_AntiCheatClient_ReceiveMessageFromServer` -- incoming message hex dump with header analysis
- `EOS_AntiCheatClient_PollStatus` -- result tracking with violation details
- `EOS_AntiCheatClient_EndSession` -- session duration + summary output
- `EOS_AntiCheatClient_AddNotifyClientIntegrityViolated` -- violation callback interception
- `EOS_Auth_Login`, `EOS_Connect_Login` -- credential and token capture
- `EOS_Auth_CopyUserAuthToken` -- AccessToken extraction
- `EOS_ProductUserId_ToString` -- ProductUserId string capture

**GA Hooks:**
- `GetKeyServerAuthToken` -- checks for EAC data in Photon auth token
- `OnCustomAuthResponse` -- correlates EAC session state at auth time
- `OnOperationResponse` -- JoinRoom rejection analysis with EAC state context

**Key Features:**
- Full message statistics: count, size distribution, timing intervals
- PollStatus result distribution tracking
- Session summary with all metrics
- RPC: `getSession()`, `getSummary()`, `getMessages()`, `getMessageStats()`, `compareMode()`

**Usage:**
```bash
# With EAC (via MelonLoader, attach to running VRChat):
frida -l tools/eac_session_analyzer.js -p <VRChat PID>

# Without EAC (bypass mode):
frida -f VRChat.exe -l tools/eac_session_analyzer.js -- --no-vr

# After both runs, compare with:
# script.exports.compare_mode()
```

## AuthCookie Format Analysis (Added 2026-04-09)

### Photon Custom Auth Response Structure

Based on Photon SDK source patterns, the auth OperationResponse (OpCode 230/231) contains:

| Param Key | Type | Content |
|-----------|------|---------|
| 1 | string | Secret -- session secret for re-auth on server switch |
| 2 | Dictionary<string, object> | **AuthCookie** -- opaque blob set by VRChat webhook |
| 3 | string | Nickname (optional) |
| 225 | string | UserId |
| 223 | string | Server position/region |
| 230 | byte[] | EncryptionData (for encrypted connections) |

### AuthCookie Internal Format (Hypothesis)

The AuthCookie is set by VRChat's custom auth webhook (`api.vrchat.cloud`) and stored as a `Dictionary<string, object>` in the Photon server's per-client state. The server plugin reads it via `ICallInfo.AuthCookie` during BeforeJoin.

**Expected fields (unconfirmed, to be verified by tools):**
- `userId` -- VRChat user ID (usr_xxx)
- `displayName` -- display name
- `trustLevel` -- trust rank
- `eacStatus` or similar -- EAC session validation state
- `authTimestamp` -- when auth was performed
- Possibly: HMAC/signature to prevent tampering

### Where AuthCookie Lives in Memory

1. **Server-side**: In Photon's per-client session state. Not directly accessible from client.
2. **Client-side**: The full OperationResponse is received by `OnOperationResponse` (RVA 0x2149830). Parameters dictionary at response+0x20 contains the cookie at key 2. However, the client typically does NOT parse or store the AuthCookie separately -- it's forwarded automatically by Photon to the game server with each room operation.

### Key Insight: Client Cannot Modify AuthCookie

The AuthCookie is **server-side state**. The client receives it during auth but it's stored in the Photon master/game server's memory. When the client sends a JoinRoom (OpCode 226), the Photon server attaches the AuthCookie from its own session store -- the client does NOT send it. Therefore:

- **Client-side AuthCookie modification is ineffective** -- the server uses its own copy
- **The webhook response is the injection point** -- if the webhook returns a different AuthCookie, that's what the server stores
- **MITM the webhook** is the only client-accessible path:
  1. Intercept the HTTPS POST from Photon server to `api.vrchat.cloud`
  2. Modify the response to include valid EAC status
  3. This requires controlling DNS or TLS (not feasible without server access)

### Updated Feasibility Assessment

| Vector | Feasibility | Notes |
|--------|-------------|-------|
| 1. AuthCookie Client Injection | **Not Feasible** | Cookie is server-side state, client cannot modify |
| 2. Webhook MITM | **Extremely Difficult** | Requires HTTPS interception of Photon-to-VRChat API |
| 3. Dual-Session Proxy | **Patched** | vrc-eac-emulator approach detected since 2025/05 |
| 4. Photon Plugin Bypass | **Unknown** | Need to find code paths that skip EAC check |
| 5. EAC Coexistence | **Viable** | Run EAC normally, use hypervisor-hidden Frida |
| 6. Custom Photon Server | **Viable** | VRCCustomServer approach, but isolated from real VRChat |
| 7. EAC-Aware Frida | **Viable** | Frida-server in kernel mode or via hypervisor |

### New Ideas (from Photon SDK analysis)

1. **OpCode 226 Parameter Injection**: The JoinRoom operation includes optional parameters. If the server checks a specific parameter rather than (or in addition to) AuthCookie, injecting that parameter client-side might work. Needs binary analysis of the game server plugin.

2. **Auth Token Composition**: `GetKeyServerAuthToken` assembles the token sent during Photon auth. If EAC status is encoded in this token (e.g., as a signed claim), and we can obtain a valid signed token from a legitimate EAC session, it could be replayed. The `eac_session_analyzer.js` tool captures this for comparison.

3. **Photon Region Exploit**: Different Photon regions may have different server plugin versions. Some regions might have weaker EAC checks or older plugin code.

4. **Event-Based Status Update**: After initial auth, the server might update EAC status via Photon events. If we could send a fake "EAC validated" event, the server might update its state. Requires understanding the server plugin's event handlers.

5. **Race Condition**: If there's a window between Photon auth success and EAC status check during JoinRoom, a rapid join attempt might succeed. The `eac_session_analyzer.js` timing data helps identify this window.

## References

- [EOS Anti-Cheat Using Guide](https://dev.epicgames.com/docs/game-services/anti-cheat/using-anti-cheat)
- [EOS_AntiCheatClient_AddNotifyMessageToServer](https://dev.epicgames.com/docs/en-US/api-ref/functions/eos-anti-cheat-client-add-notify-message-to-server)
- [EOS_AntiCheatServer_ReceiveMessageFromClient](https://dev.epicgames.com/docs/api-ref/functions/eos-anti-cheat-server-receive-message-from-client)
- [Photon Server Plugins Manual](https://doc.photonengine.com/server/current/plugins/manual)
- [Photon OperationResponse Parameters](https://doc.photonengine.com/realtime/current/reference/serialization-in-photon)
- [Photon Custom Authentication](https://doc.photonengine.com/pun/current/connection-and-authentication/authentication/custom-authentication)
- [Photon Server Plugin ICallInfo](https://doc.photonengine.com/server/current/plugins/plugin-manual#icallinfo)
- [vrc-eac-emulator](https://github.com/0liteyear/vrc-eac-emulator) -- semi-emulated bypass PoC (patched 2025/05)
- [EAC_Emu](https://github.com/Rat431/EAC_Emu) -- generic EAC stub emulator (no server validation)
- [VRC-EOSDisabler](https://github.com/Umbra999/VRC-EOSDisabler) -- telemetry blocker (EAC still runs)
- [VRCCustomServer](https://github.com/Slaynash/VRCCustomServer) -- client mod for custom Photon servers
