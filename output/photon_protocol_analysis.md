# VRChat Photon Protocol Analysis

Source: `external/protocol-docs/VRC-PhotonDocs/`

---

## 1. OpCode Definitions (Operation Codes)

Operations are RPC-style requests sent to the Photon server.

| Code | OpCode Name        | Description / Notes                          |
|------|--------------------|----------------------------------------------|
| 217  | GetRoomList        | Retrieve list of available rooms             |
| 219  | WebRPC             | Invoke server-side webhook                   |
| 220  | GetRegions         | Get available server regions                 |
| 221  | GetLobbyStats      | Get lobby statistics                         |
| 222  | FindFriends        | Look up friends' online status               |
| 225  | JoinRandomRoom     | Join a random available room                 |
| 226  | JoinRoom           | Join a specific room by name                 |
| 227  | CreateRoom         | Create a new room                            |
| 228  | LeaveLobby         | Leave the current lobby                      |
| 229  | JoinLobby          | Join a lobby                                 |
| 230  | Authenticate       | Authenticate with Photon server              |
| 231  | AuthenticateOnce   | One-time authentication handshake            |
| 251  | GetProperties      | Read room/actor properties                   |
| 252  | SetProperties      | Write room/actor properties                  |
| 253  | RaiseEvent         | Send a custom event to room participants     |
| 254  | Leave              | Leave the current room                       |
| 255  | Join               | Join confirmation event                      |

Official reference: https://doc-api.photonengine.com/en/pun/v1/class_operation_code.html

---

## 2. Event Type Table (RaiseEvent Code -> Name -> Parameters)

Events are raised via Operation `RaiseEvent` (253).

### 2.1 VRChat Custom Events

| Code | Event Name               | Authoritative | Description                                                                               |
|------|--------------------------|---------------|-------------------------------------------------------------------------------------------|
| 1    | Voice                    | No            | Voice transmission via USpeak (Opus-encoded packets)                                      |
| 2    | ExecutiveMessage         | Yes (server)  | Server-to-client disconnect notification (kick message etc.)                              |
| 3    | PastEvents               | No (to Master)| Late-joiner requests past events from room master                                         |
| 4    | SyncEvents               | No            | Room master responds with cached past events                                              |
| 5    | SyncFinished             | No            | Room master signals end of past-event sync                                                |
| 6    | ProcessEvent             | No            | VrcEvent broadcast (RPCs, Udon network events)                                            |
| 7    | UnreliableSerialization   | No            | Interpolatable data: position, rotation, muscles, ping, delta time                        |
| 8    | InterestManagement       | Yes (server)  | PhotonView interest list sync                                                             |
| 9    | ReliableSerialization     | No            | Non-interpolatable reliable data: AV3 params, Udon sync, late-join position              |
| 33   | ExecutiveAction          | Yes (server)  | General moderation event (kick/ban/mute/alert/teleport)                                   |
| 34   | RatelimitValueSync       | Yes (server)  | Server pushes rate-limit configuration to clients                                         |
| 35   | RatelimitUpdate          | Yes (server)  | Tick-based update listing currently rate-limited actors                                    |
| 40   | UserRecordUpdate         | Yes (server)  | Triggers SetActorProperties broadcast after API-side user model change                    |
| 42   | UserRecordUpdate2        | Yes (server)  | Like Event 40 but only sends changed properties (added build 1169, IK beta)              |
| 60   | PhysBonesPermissions     | ???           | PhysBone interaction permission arrays                                                    |
| 202  | Instantiate              | ???           | Self-instantiation in lobby (VRCPlayer prefab)                                            |

### 2.2 Photon Internal Events

| Code | Event Name           | Description                              |
|------|----------------------|------------------------------------------|
| 209  | OwnershipRequest     | Request PhotonView ownership             |
| 210  | OwnershipTransfer    | Transfer PhotonView ownership            |
| 211  | VacantViewIds        | Released/available PhotonView IDs        |
| 223  | PhotonAuthEvent      | Photon authentication event              |

---

## 3. Event Parameter Details

### 3.1 Voice (Event 1) -- USpeak Opus Packets

```c
struct USpeakPacket {
    uint16_t index;              // Packet counter, wraps on overflow
    uint16_t size;               // Byte count of opus payload
    uint8_t  opusData[size];     // Opus-encoded audio
};
struct USpeakHeader {
    int32_t senderActorNr;       // Photon ActorNr of sender
    int32_t serverTicks;         // Server timestamp
    USpeakPacket packets[];      // Typically 2-3 packets per event
};
```

Opus encoding settings:
- Band Mode: 48 kHz
- Bitrate: 24 kHz
- Opus Delay: 20 ms
- Channels: Stereo
- Max single packet size: 0x3FF (1023) bytes

Opus TOC bitfield:
- config (5 bits): codec mode + bandwidth + frame size
- isStereo (1 bit): 0=mono, 1=stereo
- frames (2 bits): 0=1 frame, 1=2 equal, 2=2 different, 3=arbitrary

### 3.2 ExecutiveMessage (Event 2)

Data: Single string. Server-authoritative disconnect reason displayed to client.

### 3.3 PastEvents (Event 3)

No custom data. Sent only to room master on join to request past event sync.

### 3.4 SyncEvents (Event 4)

Raised by room master in response to PastEvents request. Contains cached past events. Format not fully documented.

### 3.5 SyncFinished (Event 5)

No custom data. Signals completion of past-event synchronization.

### 3.6 ProcessEvent (Event 6)

Used for VrcEvent broadcasts (RPCs). Format not documented in public repo (sensitive).

### 3.7 UnreliableSerialization (Event 7)

Data transmitted (unreliably, interpolatable):
- Player network stats: Ping, ping variance, delta time, packet quality/loss
- Camera physics: Position, Rotation, Flags
- Player physics: Position, Rotation, Flags
- Muscle data (humanoid IK)

Binary format details in private repo: `PhotonDocs-Sensitive/UnreliableSerialization/`

### 3.8 InterestManagement (Event 8)

**Sent (client -> server):**
```c
struct InterestEntry {
    int32_t viewId;      // PhotonView ID
    uint8_t byte_1;      // Interest setting 1
    uint8_t byte_2;      // Interest setting 2
};
// May contain multiple entries per event
```

**Received (server -> client):**
Sent on ~1 second interval. Custom data is `int[]` of ActorIDs the client is receiving events from.

### 3.9 ReliableSerialization (Event 9)

Reliable data includes:
- AV3 (Avatar 3.0) synced parameters
- Udon synced variables
- Late-joiner position sync for players and pickups

Binary format details in private repo: `PhotonDocs-Sensitive/ReliableSerialization/`

### 3.10 ExecutiveAction (Event 33)

**Parameter keys:**

| Key | Name            | Type         | Description                                                                |
|-----|-----------------|--------------|----------------------------------------------------------------------------|
| 0   | Type            | byte         | ModNetworkEvent enum value (see below)                                     |
| 1   | Target_User     | int          | Photon ActorId of target. Globals likely 0.                                |
| 2   | Message         | string       | Alert/popup message text                                                   |
| 3   | Main_Property   | varies       | Contextual data (e.g., ActorId for Teleport target)                        |
| 5   | Heading         | string       | Header text when Type is Alert                                             |
| 6   | Location_Data   | varies       | Used when Type is Teleport_User                                            |
| 8   | World_Id        | string       | Used when Type is Warp_To_Instance                                         |
| 9   | Instance_id     | string       | Used when Type is Warp_To_Instance                                         |
| 10  | Blocked_Users   | bool or int  | Block list data (bool or ActorId depending on context)                     |
| 11  | Muted_Users     | bool or int  | Mute list data (bool or ActorId depending on context)                      |

**ModNetworkEvent Type enum:**

| Code | Name                | Description                                           |
|------|---------------------|-------------------------------------------------------|
| 1    | Enforce_Moderation  | Immediately enforce pending moderation action          |
| 2    | Alert               | Show alert dialog                                     |
| 3    | Warn                | Warning notification                                  |
| 4    | Kick                | Kick user from instance                               |
| 5    | Vote_Kick           | Initiate vote-kick                                    |
| 6    | Public_Ban          | Public instance ban                                   |
| 7    | Ban                 | Ban user                                              |
| 8    | Mic_Off             | Force-disable target's microphone                     |
| 9    | Mic_Volume_Adjust   | Adjust target's mic volume                            |
| 10   | Friend_Change       | Broadcast friendship change (add/delete)              |
| 11   | Warp_To_Instance    | DevTools "Warp to Instance" feature                   |
| 12   | Teleport_User       | Teleport user to location                             |
| 13   | Query               | Query (purpose unknown)                               |
| 20   | Request_PlayerMods  | Request player moderation list                        |
| 21   | Reply_PlayerMods    | Response to player moderation request                 |
| 22   | Block_User          | Block a user                                          |
| 23   | Mute_User           | Mute a user                                           |

### 3.11 RatelimitValueSync (Event 34)

Server pushes rate-limit configuration as `Dictionary<byte, int>` (event code -> max per second):

| Event Code | Name                      | Rate/sec |
|------------|---------------------------|----------|
| 1          | Voice (uSpeak)            | 60       |
| 3          | PastEvents                | 5        |
| 4          | SyncEvents (InitialSync)  | 200      |
| 5          | SyncFinished              | 50       |
| 6          | ProcessEvent (VRCEvent)   | 400      |
| 7          | UnreliableSerialization   | 500      |
| 8          | InterestManagement        | 1        |
| 9          | ReliableSerialization     | 75       |
| 33         | ExecutiveAction           | 2        |
| 40         | UserRecordUpdate          | 1        |
| 42         | UserRecordUpdate2         | 1        |
| 60         | PhysBonesPermissions      | 1        |
| 202        | Instantiate               | 1        |
| 209        | OwnershipRequest          | 20       |
| 210        | OwnershipTransfer         | 90       |

### 3.12 RatelimitUpdate (Event 35)

Custom data: `null` (no rate-limited actors) or `int[]` of rate-limited ActorIDs. Sent server-side, ~1/sec tick.

### 3.13 UserRecordUpdate (Event 40)

Data is a `short` bitmask (RecordUpdateFlags):

| Bit    | Flag                  | Triggers on                    |
|--------|-----------------------|--------------------------------|
| 1 << 0 | Avatar                | Avatar change                  |
| 1 << 1 | Fallback_Avatar       | Fallback avatar change         |
| 1 << 2 | User_Icon             | User icon change               |
| 1 << 3 | Status                | Status text change             |
| 1 << 4 | Allow_Avatar_Copying  | Avatar copy permission change  |
| 1 << 5 | Profile_Picture       | Profile picture change         |
| 1 << 6 | Bio                   | Bio text change                |

Raising this causes the server to broadcast `SetActorProperties` with updated user data from the API.

### 3.14 UserRecordUpdate2 (Event 42)

Same behavior as Event 40 but only sends properties that actually changed. Added in build 1169 (IK beta preparation). Replaces Operation 252 (SetProperties) for incremental updates.

### 3.15 PhysBonesPermissions (Event 60)

**Client-raised:** Array of full user IDs (`string[]`) listing users allowed to interact with sender's PhysBones.
- Self-interact ON: includes own user ID
- Interactions paused: empty (or only self if self-interact ON)
- Permission levels: Everyone, Friends-only, Nobody (with per-user overrides)

**Server-raised:** Array of `Int32[][]` (format currently unknown).

### 3.16 Instantiate (Event 202)

**RaiseEvent data:**

| Key | Type      | Value                   |
|-----|-----------|-------------------------|
| 245 | HashTable | `{{48, "VRCPlayer"}}`   |
| 247 | Byte      | Unknown (value: 4)      |

---

## 4. PhotonView ID Assignments

| ViewID | Object             | Purpose                          |
|--------|--------------------|----------------------------------|
| 00001  | VRCPlayer          | Main player network object       |
| 00002  | USpeak             | Voice transmission component     |
| 00003  | PlayableController | Avatar animation controller      |
| 00004  | BigData            | Large data channel               |

---

## 5. Network Class Names (for deobfuscation)

### 5.1 Core Photon Classes

| Obfuscated Signature | Resolved Name |
|---|---|
| ObjectPublicByVoByByByByByByByBy0 | VRCPhotonEvent |
| ObjectPublicByBoByVoBoByVoBoByBoUnique / ObjectPublicByBoByVoByVoBoByBoByUnique | VRCPhotonEventSequence |
| ObjectPublicByVoByByByByByByByBy2 | Photon.Realtime.EventCode |
| ObjectPublicByVoByByByByByByByBy3 | Photon.Realtime.ParameterCode |
| ObjectPublicByVoByByByByByByByBy4 | Photon.Realtime.OperationCode |
| ObjectPublicByVoByByByByByByByBy5 | VRC.Management.ModNetworkEvent |
| PhotonPeer1PrivateInObInBoSiBoLiSi1DiUnique | VRC.Core.VRCNetworkingPeer |
| ObjectPublicAbstractSealedObInObBoStInBoHaOb1Unique | Photon.Pun.PhotonNetwork |
| MonoBehaviourPublicInDoBoObBoviInisObInUnique / MonoBehaviourPublicInNu1SiInBoSiObviisUnique | Photon.Pun.PhotonView |
| ObjectPublicIPhotonPeerListenerObStNuStOb1CoObBoDiUnique | Photon.Realtime.LoadBalancingClient |
| PhotonPeerPublicPo1Di2ByObTyUnique | Photon.Realtime.LoadBalancingPeer |

### 5.2 USpeak Classes

| Obfuscated Signature | Resolved Name |
|---|---|
| MonoBehaviourPublicSiBoSiLi1ObInStVaLiUnique / MonoBehaviourPublicBoSiBoLiSi1ObBoInStUnique | USpeaker |
| MonoBehaviourPublicBoSiSiSiUnique | LocalUSpeakSender |
| MonoBehaviourPublicDi2ObStObDi2ObObObUnique | USpeakOwnerInfo |
| MonoBehaviourPublicDi2ObObUnique | USpeakPhotonManager3D |
| MonoBehaviour2PublicDeObBoNuOb1InObHaUIUnique / MonoBehaviour1PublicDeObBoNuOb1InObHaUIUnique | USpeakPhotonSender3D |
| ObjectPublicStVoIEStVo1VoIE1StUnique | USpeakUtilities |

### 5.3 USpeak Sub-types

| Name | Description |
|---|---|
| USpeaker.DeliveryNetwork | Enum: delivery network type |
| USpeaker.MagnitudeSample | Struct: audio magnitude sample |
| USpeaker.EncodeInfo | Opus encode context |
| USpeakPhotonSender3D.DecodeInfo | Opus decode context |

### 5.4 VRCPlayer & Flow

| Obfuscated Signature | Resolved Name |
|---|---|
| MonoBehaviour2PublicSiObStObSiTeBoObHa1Unique / MonoBehaviour2PublicObSiObStTeObBoHaObSiUnique / MonoBehaviour1PublicOb_pObSt_pTeBoObStSiUnique / MonoBehaviour2PublicOb_pObSt_pTeBoObSiHaUnique | VRCPlayer |
| VRCPlayer.OnAvatarIsReady | Delegate: avatar load complete |
| VRCPlayer.NetworkChange | Enum: network state change |

### 5.5 Serialization Classes

| Name | Description |
|---|---|
| VRC.Core.ParameterSerialization | AV3 parameter serialization |
| VRC.Core.QuantizedSerialization | Quantized value serialization |

### 5.6 Photon Realtime Types (already in vocabulary, listed for reference)

- Photon.Realtime.ActorProperties
- Photon.Realtime.AuthModeOption
- Photon.Realtime.AuthenticationValues
- Photon.Realtime.ClientState
- Photon.Realtime.EncryptionMode
- Photon.Realtime.EncryptionDataParameters
- Photon.Realtime.EventCaching
- Photon.Realtime.EventCode
- Photon.Realtime.JoinMode
- Photon.Realtime.MatchmakingMode
- Photon.Realtime.OperationCode
- Photon.Realtime.ParameterCode
- Photon.Realtime.PropertyTypeFlag
- Photon.Realtime.ReceiverGroup
- Photon.Realtime.ServerConnection
- Photon.Realtime.WebFlags

---

## 6. Authentication / Handshake Protocol

### Connection sequence (inferred from coroutine names):

1. `_BeginConnectionToPhoton_d__68` -- Initiate Photon connection
2. `_WaitForPhotonConnection_d__70` -- Wait for connection established
3. `_ConnectToPhotonEnumerator_d__144` -- Connection state machine
4. `Authenticate` (OpCode 230) or `AuthenticateOnce` (OpCode 231) -- Server auth
5. `PhotonAuthEvent` (Event 223) -- Auth confirmation
6. `JoinLobby` (OpCode 229) / `JoinRoom` (OpCode 226) / `CreateRoom` (OpCode 227) -- Enter room
7. `_EnterPhotonRoom_d__28` -- Room entry coroutine
8. `Instantiate` (Event 202) -- Spawn VRCPlayer with key 245=`{48, "VRCPlayer"}`, key 247=4
9. `PastEvents` (Event 3) -- Request sync from room master
10. `SyncEvents` (Event 4) / `SyncFinished` (Event 5) -- Receive past state
11. `_PlayerJoinedRequestSerialization_d__114` -- Request serialization data from existing players

### Room exit sequence:

1. `Leave` (OpCode 254) -- Leave room
2. `_LeavePhotonRoom_d__11` -- Cleanup coroutine
3. `LeaveLobby` (OpCode 228) -- Leave lobby

---

## 7. Serialization Formats Summary

### 7.1 Voice (USpeak + Opus)

- Transport: Event 1, unreliable
- Container: USpeak framing (index + size + payload)
- Codec: Opus, 48kHz band, 24kHz bitrate, 20ms frames, stereo
- Max packet: 1023 bytes per USpeak packet
- Typical: 2-3 USpeak packets per event

### 7.2 Unreliable Serialization (Event 7)

- Transport: Unreliable channel
- Content: Player transform (pos/rot), camera transform, muscles, network stats
- Purpose: Continuous interpolatable state

### 7.3 Reliable Serialization (Event 9)

- Transport: Reliable channel
- Content: AV3 parameters, Udon synced vars, late-join transforms
- Purpose: State that must arrive

### 7.4 UserRecordUpdate (Event 40/42)

- Transport: Reliable, server-authoritative
- Format: Bitmask `short` indicating which fields changed
- Server broadcasts `SetActorProperties` with fresh API data in response

### 7.5 PhysBonesPermissions (Event 60)

- Client sends: `string[]` of allowed user IDs
- Server responds: `Int32[][]` (format TBD)

### 7.6 Rate Limiting

- Config pushed via Event 34 (RatelimitValueSync): `Dictionary<byte,int>`
- Status pushed via Event 35 (RatelimitUpdate): `int[]` or `null`

### 7.7 Interest Management (Event 8)

- Client sends: array of `{viewId:int32, byte1, byte2}` entries
- Server sends: `int[]` of currently-subscribed actor IDs, ~1/sec

---

## 8. Channel / Transport Notes

- Events 1, 7: Unreliable transport (voice, interpolatable transforms)
- Events 2, 9, 33, 34, 35, 40, 42: Reliable transport / server-authoritative
- Events 3, 4, 5: Reliable, master-client sync protocol
- Event 6 (ProcessEvent/RPC): Broadcast, reliability depends on VrcEvent config
- Event 8: Mixed (client unreliable interest updates, server reliable interest lists)

---

## 9. Tools Referenced

| Tool | URL | Purpose |
|---|---|---|
| ImHex | https://github.com/WerWolv/ImHex | Binary format analysis |
| PhotonDebug | https://github.com/OptoCloud/PhotonDebug | Photon traffic logger to JSON |
| USpeakNative | https://github.com/OptoCloud/USpeakNative | USpeak packet codec (private) |
| PhotonDocs-Sensitive | https://github.com/OptoCloud/PhotonDocs-Sensitive | Private serialization format docs |

---

## 10. Vocabulary Additions

64 new names added to `output/master_vocabulary.json` (2889 -> 2953 unique names).
Categories: OpCodes, Event names, ModNetworkEvent types, serialization structs, UserRecord flags, ViewID objects.
