# VRChat Network Layer Analysis

Cross-reference of Photon protocol documentation with deobfuscated IL2CPP dump.

Generated: 2026-04-08

---

## 1. Architecture Overview

VRChat's network layer is built on Photon Realtime (not PUN2 directly). The stack:

```
Application Layer:  VRCPlayer / NetworkManager / UdonBehaviour
                         |
Serialization:      FlatBufferSerializerCodec (8-bit + 32-bit FlatBuffers)
                         |
Event Layer:        VRCPhotonEvent / IFlatBufferNetworkSerializer
                         |
Photon Protocol:    Photon.Client (EventData, OperationResponse, PhotonPeer)
                         |
Transport:          EnetPeer (UDP) / TPeer (TCP) / PhotonClientWebSocket (WSS)
                         |
Encryption:         PhotonEncryptorPlugin (native, DLL-based)
```

---

## 2. Mapped Network Classes

### 2.1 Core Photon Client Layer (`Photon.Client` namespace, 34 types)

| Class | Role | Key Methods |
|---|---|---|
| `PhotonPeer` | Main peer connection (65 methods, 36 fields) | `Connect`, `Disconnect`, `SendOutgoingCommands`, `DispatchIncomingCommands`, `OpCustom` |
| `PeerBase` | Base for EnetPeer/TPeer (57 methods, 21 fields) | `Connect`, `Disconnect`, `EnqueueOperation`, `SendOutgoingCommands` |
| `EnetPeer : PeerBase` | UDP transport peer (41 methods, 4 fields) | `Connect`, `Disconnect`, `DispatchIncomingCommands`, `SendAcksOnly` |
| `TPeer : PeerBase` | TCP transport peer (20 methods, 1 field) | `Connect`, `Disconnect`, `SendData`, `ReceiveIncomingCommands` |
| `EventData` | Incoming event container (7 methods) | `get_Sender`, `get_CustomData`, `get_Item` |
| `OperationResponse` | Server response container (4 methods) | `get_Item`, `ToString`, `ToStringFull` |
| `Protocol` | Serialization protocol (21 methods) | `SerializeEventData`, `DeserializeEventData`, `SerializeOperationRequest`, `DeserializeOperationResponse` |
| `IPhotonPeerListener` | Event callback interface (6 methods) | `OnEvent`, `OnOperationResponse`, `OnStatusChanged`, `DebugReturn`, `OnMessage`, `OnDisconnectMessage` |
| `StreamBuffer` | Binary read/write buffer (20 methods) | `Read`, `Write`, `ReadByte`, `WriteByte`, `ToArray` |
| `PhotonSocket` | Socket abstraction (33 methods) | `Connect`, `Disconnect`, `Send`, `Receive` |
| `SocketUdp : PhotonSocket` | UDP socket (9 methods) | `Connect`, `Disconnect`, `Send`, `Receive`, `DnsAndConnect` |
| `SocketTcp : PhotonSocket` | TCP socket (9 methods) | `Connect`, `Disconnect`, `Send`, `Receive`, `DnsAndConnect` |
| `PhotonClientWebSocket : PhotonSocket` | WebSocket transport (6 methods) | `Connect`, `Disconnect`, `Send`, `Receive` |
| `NCommand` | Network command (15 methods) | `SerializeHeader`, `Serialize`, `CreateAck`, `CreateAck2` |
| `SendOptions` | Send reliability config | `get_Reliability`, `set_Reliability` |
| `PhotonHashtable : Dictionary` | Photon hashtable (12 methods) | Key-value store for event/room properties |
| `NetworkSimulationSet` | Debug lag simulation (8 methods) | `IncomingLossPercentage`, `OutgoingLossPercentage` |
| `TrafficStats` / `TrafficStatsBase` | Network statistics | `BytesIn`, `BytesOut`, `RoundtripTime` |

### 2.2 Photon Realtime Layer (`Photon.Realtime` namespace, 5 types)

| Class | Role | Key Methods/Fields |
|---|---|---|
| `AppSettings` | Photon app configuration (20 methods, 4 fields) | `IsBestRegion`, `IsMasterServerAddress`, `IsDefaultNameServer` |
| `ConnectionHandler : MonoBehaviour` | Connection lifecycle manager (31 methods) | `Awake`, `OnApplicationPause`, `OnDisable` |
| `MatchmakingArguments` | Room join parameters (12 methods) | `UserId`, `Plugins`, `CanRejoin` |
| `MatchmakingReconnectInformation` | Reconnect state (14 methods) | `Timeout`, `HasTimedOut` |
| `AsyncSetup` | Async initialization (10 methods) | `Startup` |

### 2.3 Photon Encryption (`Photon.Client.Encryption`, 2 types)

| Class | Role |
|---|---|
| `ICryptoProvider` | Key exchange + symmetric encrypt/decrypt (`DeriveSharedKey`, `Encrypt`, `Decrypt`) |
| `IPhotonEncryptor` | Native encryption wrapper (`Init`, `Encrypt2`, `Decrypt2`, `CalculateEncryptedSize`) |

Native implementation via `PhotonEncryptorPlugin` DLL (IDA strings at `0x2166fd0`-`0x2167de0`).

---

## 3. VRChat Network Event Dispatch

### 3.1 IPhotonPeerListener Implementors (Event Receivers)

These classes receive raw Photon events via `OnEvent(EventData)`:

| Obfuscated Name | Proposed Name | Parent | Methods | Role |
|---|---|---|---|---|
| `UdonOperationResponseDisconnectMessage_E05D` | **VRCNetworkingClient** | `Object` | 141 methods, 33 fields | **Primary IPhotonPeerListener**: `OnEvent`, `OnOperationResponse`, `OnStatusChanged`, `OnDisconnectMessage`, `OnMessage`, `DebugReturn` |
| `UdonOperationResponseStatusChanged_7727` | **VRCNetworkingClient_Callbacks** | `UdonOperationResponseDisconnectMessage_E05D` | 19 methods, 3 fields | Derived client with additional callback handling |

**Critical identification**: `UdonOperationResponseDisconnectMessage_E05D` implements the full `IPhotonPeerListener` interface (all 6 methods) and has 141 methods + 33 fields. This is the **main Photon event dispatcher** -- it receives all raw events and routes them to the appropriate handler. The protocol doc's `VRC.Core.VRCNetworkingPeer` signature maps here.

### 3.2 PUN-style Callback Implementors

| Obfuscated Name | Proposed Name | Callbacks Implemented | Role |
|---|---|---|---|
| `PhotonRoomHandler_E1A7` | **VRCPhotonRoomCallbacks** (109 methods, 8 fields) | `OnJoinedRoom`, `OnLeftRoom`, `OnCreatedRoom`, `OnMasterClientSwitched`, `OnConnectedToMaster`, `OnCustomAuthenticationResponse`, `OnCustomAuthenticationFailed` | Full room lifecycle handler |
| `PhotonConnectionHandler_92CA` | **VRCPhotonConnectionManager** (72 methods, 28 fields) | `OnConnectedToMaster` | Primary connection state machine |
| `PhotonConnectionHandler_34AB` | **VRCPhotonAuthHandler** (46 methods, 5 fields) | `OnConnectedToMaster`, `OnCustomAuthenticationFailed` | Authentication flow handler |
| `PhotonMasterHandler_F5A9` | **VRCPhotonMasterHandler** (27 methods) | `OnJoinedRoom`, `OnLeftRoom`, `OnMasterClientSwitched`, `OnCreatedRoom` | Master client switch handler. Inherits `ConnectionHandler`. |
| `PhotonConnectionHandler_E3E5` | **VRCPhotonConnectionCallbackList** (14 methods) | `OnConnectedToMaster`, `OnCustomAuthenticationResponse`, `OnCustomAuthenticationFailed` | Connection callback aggregator (inherits `List<T>`) |
| `PhotonConnectionHandler_C364` | **IConnectionCallbacks** (6 methods) | `OnConnectedToMaster`, `OnCustomAuthenticationResponse`, `OnCustomAuthenticationFailed` | Interface definition |
| `PhotonRoomHandler_252B` | **VRCPhotonRoomCallbackList** (14 methods) | `OnCreatedRoom`, `OnJoinedRoom`, `OnLeftRoom` | Room callback aggregator (inherits `List<T>`) |
| `PhotonRoomHandler_01D0` | **IInRoomCallbacks** (7 methods) | `OnCreatedRoom`, `OnJoinedRoom`, `OnLeftRoom` | Interface definition |

### 3.3 NetworkManager (263 methods, 47 fields)

The `NetworkManager` class (root namespace, inherits `MonoBehaviour`) is the **central network coordinator**:
- VA: identified in dump
- Named methods: `Awake`, `Start`, `Update`, `LateUpdate`, `OnNetworkReady`, `OnDestroy`
- 253 obfuscated methods (`m_XXX`) -- likely contains event routing, player management, serialization dispatch
- 47 obfuscated fields (`f_XXX`) -- references to sub-systems

---

## 4. Network Event Flow

### 4.1 Connection Sequence (from protocol docs + dump)

```
1. PhotonConnectionHandler_92CA.Start()
   -> Connect to Photon Name Server
   -> _BeginConnectionToPhoton_d__68 coroutine

2. PhotonConnectionHandler_92CA.OnConnectedToMaster()
   -> _WaitForPhotonConnection_d__70 coroutine
   -> Authenticate (OpCode 230) or AuthenticateOnce (OpCode 231)

3. PhotonRoomHandler_E1A7.OnCustomAuthenticationResponse()
   -> Authentication confirmed
   -> PhotonAuthEvent (Event 223)

4. PhotonRoomHandler_E1A7.OnConnectedToMaster()
   -> JoinLobby (OpCode 229)

5. JoinRoom (OpCode 226) / CreateRoom (OpCode 227) / JoinRandomRoom (OpCode 225)

6. PhotonRoomHandler_E1A7.OnJoinedRoom()
   -> _EnterPhotonRoom_d__28 coroutine
   -> NetworkManager.OnNetworkReady()
   -> Instantiate (Event 202) with VRCPlayer prefab

7. PastEvents (Event 3) -> SyncEvents (Event 4) -> SyncFinished (Event 5)
   -> _PlayerJoinedRequestSerialization_d__114

8. Continuous: UnreliableSerialization (Event 7), ReliableSerialization (Event 9), Voice (Event 1)
```

### 4.2 Room Exit Sequence

```
1. Leave (OpCode 254)
2. PhotonRoomHandler_E1A7.OnLeftRoom()
   -> _LeavePhotonRoom_d__11 coroutine
3. PhotonMasterHandler_F5A9.OnLeftRoom()
4. LeaveLobby (OpCode 228)
```

---

## 5. Serialization Layer

### 5.1 FlatBuffer Serialization Architecture

VRChat uses **Google FlatBuffers** for network serialization, with two precision modes:

| Component | Namespace | Types | Purpose |
|---|---|---|---|
| `FlatBufferSerializerCodec` | `VRC.Core.Networking` | 1 | Central codec: `Encode8`/`Decode8`/`Encode32`/`Decode32` + sparse variants |
| `FlatBuffers8` types | `VRC.Core.Networking.FlatBuffers.FlatBuffers8` | 21 | 8-bit precision serialization (frequent, smaller) |
| `FlatBuffers32` types | `VRC.Core.Networking.FlatBuffers.FlatBuffers32` | 22 | 32-bit precision serialization (less frequent, full precision) |
| `SparseArray8` / `SparseArray32` | `VRC.Core.Networking.FlatBuffers` | 3 | Sparse encoding for delta updates |
| `DecodeParameters8` / `DecodeParameters32` | `VRC.Core.Networking` | 2 | Decode context with `Objects`, `SendTime`, `SerializationRecovery` |

### 5.2 FlatBuffer Serialized Types

**8-bit types (Event 9 - ReliableSerialization, frequent updates):**

| FlatBuffer Type | Content |
|---|---|
| `SyncPlayable` | AV3 params: `StageParamsOffset`, `Puppet`, `AvatarDiscriminator` |
| `DataStorage` | Generic key-value entries (union types) |
| `ObjectPool` | Synced object pool state |
| `Udon` | Udon synced variables (union of typed values) |
| `UdonInfo` | Udon variable names + types metadata |
| `DestructiblePlayer` | Player health state |
| `PlayerDrone` | Drone throttle state |
| `PlayerStationStateData` | Active station state |
| `SerializedObjects` | Container for multiple serialized objects (union dispatch) |
| `SparseSerializedObjects` | Sparse delta variant |

**32-bit types (Event 9/7 - full precision):**

| FlatBuffer Type | Content |
|---|---|
| `SyncPlayable` | Full precision avatar params |
| `ObjectMetadata` | Object metadata: `Is8Bit`, `DoNotPersist`, `Code`, `ComponentInfo`, `InitialPath` |
| `WorldMetadata` | World hash, persistence GUID, max ViewIDs, min ViewID |
| `PlayerDataPair` | Typed player data (Vector2/3/4, Quaternion, Color, wrapped primitives) |
| `PhysBoneGrab` | PhysBone grab state: `ChainIdA`, `ChainIdB`, `Bone`, `Offset` |
| `SerializedObjects` | Full precision serialized objects container |

### 5.3 QuantizedSerialization (`VRC.Core.Networking`)

Quantized encoding for position/rotation:
- `Serialize(Vector3)` / `Deserialize(Vector3)`
- `Serialize(Quaternion)` / `Deserialize(Quaternion)`
- `SerializeQuaternionAsHalfFloat` -- half-precision quaternion
- `SerializeVector3AsNone` / `DeserializeVector3FromNone` -- null-position handling

### 5.4 IVRC_FlatBufferSerializer Interface

All network-synced objects implement this interface:

```
NeedsSync()           -> bool    // Does this object need to sync?
NeedsImportant()      -> bool    // Is this a priority sync?
CanSerialize8Bit()    -> bool    // Supports 8-bit encoding?
CanSerialize32Bit()   -> bool    // Supports 32-bit encoding?
Encode(8-bit)         -> void    // Encode to 8-bit FlatBuffer
Encode(32-bit)        -> void    // Encode to 32-bit FlatBuffer
Decode(8-bit)         -> void    // Decode from 8-bit FlatBuffer
Decode(32-bit)        -> void    // Decode from 32-bit FlatBuffer
SerializedName()      -> string  // Debug name for this serializer
get_TypeId            -> int     // Type identifier
```

### 5.5 Implementors of IVRC_FlatBufferSerializer

| Class | Parent | Methods | Identified Purpose |
|---|---|---|---|
| `FlatBufferNetworkSerializer` | `NetworkReadyHandler_30DA` | 47 | **Avatar serialization** (`UpdatePuppetChannelTypes`, `Reset`) |
| `PlayerNet` | `NetworkReadyHandler_30DA` | 144 | **Player network state** (position, rotation, IK, triggers) |
| `NetworkSyncable_23D2` | `NetworkReadyHandler_30DA` | 119 | **Pickup/physics object sync** (`EnableKinematic`, `DisableKinematic`, `DisableGravity`, collision handlers) |
| `NetworkSyncable_C99C` | `NetworkReadyHandler_30DA` | 70 | **Material/renderer sync** (shared material array access) |
| `NetworkSyncable_D212` | `NetworkReadyHandler_30DA` | 67 | **Video player sync** (`RemoteSetVideos`, `RemoteSetPlaylist`, `RemoteClear`) |
| `NetworkSyncable_5CCF` | `NetworkReadyHandler_30DA` | 79 | **Audio player sync** (`PlayAudio`, `StopAudio`, `RemoteSetPlaylist`, `RemoteClear`) |
| `NetworkSyncable_5DEA` | `NetworkReadyHandler_30DA` | 66 | **Generic sync** (Encode/Decode, Update loop) |
| `NetworkSyncable_1F07` | `NetworkReadyHandler_30DA` | 47 | **Persistent sync** (`CanUsePersistenceHashes`, `GenerateComponentInfo`) |
| `NetworkSyncable_6140` | `NetworkReadyHandler_30DA` | 36 | **Toggle sync** (OnEnable/OnDisable) |
| `NetworkSyncable_9773` | `NetworkReadyHandler_30DA` | 32 | **Generic component sync** |
| `NetworkSyncable_D68A` | `NetworkReadyHandler_30DA` | 35 | **Lightweight sync** (Update loop) |
| `PlayerModComponentHealth` | `NetworkReadyHandler_30DA` | 42 | **Health system sync** (`ApplyDamage`, `ApplyHealing`, `EndDeath`, `SetState`, `GetCurrentHealth`) |
| `VRCNetworkBehaviour` | `NetworkReadyHandler_30DA` | 35 | **Base SDK network behaviour** |
| `VRCNetworkBehaviourBase` | `NetworkReadyHandler_30DA` | 31 | **Extended SDK network behaviour** with persistence |

---

## 6. Network Object Hierarchy

```
MonoBehaviour
  |
  +-- NetworkReadyHandler_30DA (31 methods, 14 fields)    <- Base network-aware component
       |                                                     OnNetworkReady(), INetworkReadyReceiver
       |
       +-- VRCNetworkBehaviour (35 methods)               <- SDK network behaviour base
       |    +-- VRC_EventHandler                          <- Event handler (VRCEvent system)
       |    +-- VRC_Pickup                                <- Pickup objects
       |    +-- VRC_Interactable                          <- Interactable objects
       |    +-- VRCObjectSync                             <- Object sync (SDK3)
       |    +-- VRC_ObjectSync                            <- Object sync (SDK2)
       |    +-- VRC_SyncVideoPlayer                       <- Video player sync
       |    +-- VRC_SyncVideoStream                       <- Video stream sync
       |
       +-- VRCNetworkBehaviourBase (31 methods)           <- Extended base with persistence
       |
       +-- FlatBufferNetworkSerializer (47 methods)       <- Avatar/Playable serialization
       |
       +-- PlayerNet (144 methods)                        <- Player network state (pos/rot/IK)
       |
       +-- NetworkReadyHandler_318A (128 methods)         <- Network event dispatcher
       |                                                     IFlatBufferNetworkSerializer.get_name
       |                                                     IFlatBufferNetworkSerializer.get_EventCode
       |                                                     ILoggableClass (Log/Warn/Error)
       |                                                     IsSparse, Targets, LastEncoding
       |                                                     MakeTransformHash, OnSpawn
       |
       +-- VRCPlayer (251 methods, 66 fields)             <- Player entity
       |    Named: PlayEmoteRPC, ReloadAvatarNetworkedRPC
       |
       +-- NetworkSyncable_23D2 (119 methods)             <- Pickup/physics sync
       +-- NetworkSyncable_C99C (70 methods)              <- Material sync
       +-- NetworkSyncable_D212 (67 methods)              <- Video sync
       +-- NetworkSyncable_5CCF (79 methods)              <- Audio sync
       +-- NetworkSyncable_5DEA (66 methods)              <- Generic sync
       +-- NetworkSyncable_1F07 (47 methods)              <- Persistent sync
       +-- NetworkSyncable_6140 (36 methods)              <- Toggle sync
       +-- NetworkSyncable_9773 (32 methods)              <- Component sync
       +-- NetworkSyncable_D68A (35 methods)              <- Lightweight sync
       +-- PlayerModComponentHealth (42 methods)           <- Health system
       +-- NetworkReadyHandlerImpl_0014 (57 methods)       <- Unknown large handler
       +-- NetworkReadyHandlerImpl_A239 (36 methods)       <- Animation-related (GetClipByName)
       +-- NetworkReadyHandler_F918 (44 methods)           <- Transform sync (SetPositionAndRotation)
       +-- WorldProximityExitStation_7CBD (56 methods)     <- Station base
```

---

## 7. State Management & Persistence

`VRC.Core.Networking.Codec.StateManagement` namespace (3 types):

| Class | Role |
|---|---|
| `AbstractObjectStateManager` | Base: `RecordBunch8`, `RecordBunch32`, `DeleteStateForViewId`, `OnPlayerJoined`, `OnPlayerLeft`, `SendEventToPlayer`, `SendEventToAllPlayers`, `SetOwner` |
| `SimpleObjectStateManager` | In-memory state: `WriteBunches`, `ReadBunches` |
| `PersistenceObjectStateManager` | Persistent state: `WriteInstance`, `ReadInstance`, `WritePlayer`, `ReadPlayer`, `HibernatePlayer`, `RestorePlayerPersistence`, `RestoreInstance` |

Key fields: `MaximumViewID`, `MinimumViewID`, `ManagedPlayerViews`, `ObjectStateSizeBytes`

---

## 8. Event-to-Class Mapping

### 8.1 Voice (Event 1)

| Class | Role |
|---|---|
| `OpusCodec` (18 methods) | Opus encode/decode wrapper |
| `OpusCodecRelated_5419` | Opus codec support |
| `OpusCodecSibling_CCAD` | Opus codec interface |
| `PlayerModComponentVoice` (12 methods) | Voice component: `SetProperties`, `Awake`, `Start`, `OnDestroy` |
| `ApplicationMicrophoneHandler_7546` (10 methods) | Microphone input handler |
| `AudioMicrophoneHandler_B7EA` (10 methods) | Audio microphone handler |

IDA strings confirm native Opus at `0x2167fe0`: `opus_decoder_create`, `opus_decoder_destroy`, `opus_decode_float`

### 8.2 ProcessEvent / RPC (Event 6)

| Class | Evidence |
|---|---|
| `VRCPlayer` | Has `PlayEmoteRPC`, `ReloadAvatarNetworkedRPC` methods |
| `NetworkCancelRPCComponent_8D1F` (26 methods) | RPC cancellation |
| `NetworkEnableMeshRPCSetPresetRPCComponent_9589` (15 methods) | Mesh preset RPC |
| `PlayerModComponentHealth` | Has `AddHealthRPC`, `RemoveHealthRPC`, `ResetHealthRPC` methods |
| `SendNetworkEventDelegate` | Delegate for sending network events |
| `UdonDisableEventProcessing_FF1E` (74 methods) | `SendCustomNetworkEvent` (5 overloads), `RunEventAdvanced` |

### 8.3 UnreliableSerialization (Event 7) & ReliableSerialization (Event 9)

Handled by `FlatBufferSerializerCodec`:
- `Encode8` / `Decode8` -> 8-bit FlatBuffer for frequent updates
- `Encode32` / `Decode32` -> 32-bit FlatBuffer for full precision
- `SparseEncode8` / `SparseDecode8` -> Sparse 8-bit for delta updates
- `DecodePlayer8` / `EncodePlayer8` -> Player-specific encoding
- `IsPlayerSerialization8MissingFields` -> Recovery for missing data
- `ConfigureSparseArrays` -> Setup sparse encoding targets

Primary receivers:
- `PlayerNet` (144 methods) -> Player position/rotation/IK
- `FlatBufferNetworkSerializer` (47 methods) -> Avatar parameters
- All `NetworkSyncable_XXXX` classes -> World objects

### 8.4 InterestManagement (Event 8)

Not directly identified as a separate class. Likely handled within `NetworkManager` or `UdonOperationResponseDisconnectMessage_E05D` event routing.

### 8.5 ExecutiveAction (Event 33) & Moderation

| Class | Role |
|---|---|
| `VRC.Core.ApiPlayerModeration` | API model: `SendModeration`, `DeleteModeration`, `FetchAllAgainstMe` |
| `RemovePlayerModsAddPlayerModsComponent_9B7A` | Add/remove player mods |
| `PlayerModComponentVoice` | Voice moderation component |
| `PlayerModComponentHealth` | Health moderation component |
| `PlayerModComponentJump` | Jump moderation component |
| `PlayerModComponentSpeed` | Speed moderation component |

### 8.6 Instantiate (Event 202)

VRCPlayer prefab instantiation with keys 245=`{48, "VRCPlayer"}`, 247=4.
Handled in `PhotonRoomHandler_E1A7.OnJoinedRoom()` chain.

---

## 9. RPC Dispatch Mechanism

VRChat uses a custom RPC system, not Photon PUN's `[PunRPC]`:

1. **VrcEvent broadcast** (Event 6 - ProcessEvent)
   - Sender constructs a VrcEvent with target, RPC name, parameters
   - `NetworkShouldBroadcastInstigator_03A4` (31 methods, 13 fields) controls broadcast rules
   - `SendNetworkEventDelegate` is the delegate type for sending

2. **Named RPCs on VRCPlayer:**
   - `PlayEmoteRPC` - Play emote animation
   - `ReloadAvatarNetworkedRPC` - Reload avatar

3. **Health RPCs:**
   - `AddHealthRPC` / `RemoveHealthRPC` / `ResetHealthRPC`

4. **Udon Network Events:**
   - `UdonDisableEventProcessing_FF1E.SendCustomNetworkEvent()` (5 overloads)
   - Udon variables serialized via `FlatBuffers8.Udon` / `FlatBuffers8.UdonInfo` types

---

## 10. Network Tween/Interpolation System (`VRC.Core.Networking.Tween`, 10 types)

- `ITweenableValue` interface: `Tween`, `Interpolate`, `Extrapolate`
- `ITimedValue` interface: `get_Time`, `set_Time`, `Copy`
- `PositionEvent : TweenableValue` (20 methods): Position sync with flags for `IsKinematic`, `UseGravity`, `HeldInHand`, `DiscontinuityCounter`
- `ISyncPhysics` interface: `get_LastPosition`, `Decode`
- `SyncPhysicsCodec`: `Encode`, `Decode` with position float extraction

---

## 11. Identified Name Mappings (New)

### 11.1 Confirmed High-Confidence Mappings

| Obfuscated Name | Proposed Deobfuscated Name | Evidence |
|---|---|---|
| `UdonOperationResponseDisconnectMessage_E05D` | `VRCNetworkingClient` | Implements full IPhotonPeerListener (OnEvent, OnOperationResponse, OnStatusChanged, OnMessage, OnDisconnectMessage, DebugReturn); 141 methods, 33 fields |
| `UdonOperationResponseStatusChanged_7727` | `VRCNetworkingClient_Instance` | Inherits VRCNetworkingClient; 19 methods |
| `PhotonRoomHandler_E1A7` | `VRCPhotonRoomCallbacks` | Full room lifecycle: OnJoinedRoom, OnLeftRoom, OnCreatedRoom, OnMasterClientSwitched, OnConnectedToMaster, auth callbacks |
| `PhotonConnectionHandler_92CA` | `VRCPhotonConnectionManager` | Connection state machine (72 methods, 28 fields); OnConnectedToMaster |
| `PhotonConnectionHandler_34AB` | `VRCPhotonAuthHandler` | Auth flow: OnConnectedToMaster, OnCustomAuthenticationFailed |
| `PhotonMasterHandler_F5A9` | `VRCPhotonMasterHandler` | Master client management; inherits ConnectionHandler |
| `PhotonConnectionHandler_C364` | `IPhotonConnectionCallbacks` | Interface: OnConnectedToMaster, OnCustomAuthenticationResponse, OnCustomAuthenticationFailed |
| `PhotonConnectionHandler_E3E5` | `PhotonConnectionCallbackList` | Callback aggregator (List<T>) |
| `PhotonRoomHandler_01D0` | `IPhotonRoomCallbacks` | Interface: OnCreatedRoom, OnJoinedRoom, OnLeftRoom |
| `PhotonRoomHandler_252B` | `PhotonRoomCallbackList` | Callback aggregator (List<T>) |
| `NetworkReadyHandler_30DA` | `VRCNetworkComponent` | Base network-aware MonoBehaviour (OnNetworkReady, INetworkReadyReceiver) |
| `NetworkReadyHandler_318A` | `VRCNetworkEventSerializer` | IFlatBufferNetworkSerializer: EventCode, name, IsSparse, Targets, LastEncoding, MakeTransformHash, OnSpawn; ILoggableClass |
| `NetworkSyncable_23D2` | `VRCPickupSync` | Physics: EnableKinematic, DisableKinematic, DisableGravity, OnCollisionEnter, OnControllerColliderHit |
| `NetworkSyncable_D212` | `VRCVideoSync` | Video: RemoteSetVideos, RemoteSetPlaylist, RemoteClear |
| `NetworkSyncable_5CCF` | `VRCAudioSync` | Audio: PlayAudio, StopAudio, RemoteSetPlaylist, RemoteClear |
| `NetworkSyncable_C99C` | `VRCMaterialSync` | Materials: shared material array access, persistence |
| `NetworkSyncable_1F07` | `VRCPersistentSync` | Persistence: CanUsePersistenceHashes, GenerateComponentInfo |
| `NetworkReadyHandlerImpl_A239` | `VRCAnimationNetworkHandler` | Animation: GetClipByName, profiler |
| `NetworkReadyHandler_F918` | `VRCTransformSync` | Transform: SetPositionAndRotation, LateUpdate tracking |
| `NetworkItem_0D57` | `PhotonHashtable_Extended` | IDictionary + IList implementation (96 methods, 30 fields) |
| `ApplicationMicrophoneHandler_7546` | `VRCMicrophoneManager` | Microphone: device ID, play state |
| `AudioMicrophoneHandler_B7EA` | `VRCAudioMicrophoneInput` | Audio microphone: play helper, device ID |

### 11.2 Medium-Confidence Mappings

| Obfuscated Name | Proposed Name | Evidence |
|---|---|---|
| `NetworkSyncable_5DEA` | `VRCGenericSync` | Generic Encode/Decode, Update loop, dual precision |
| `NetworkSyncable_6140` | `VRCToggleSync` | OnEnable/OnDisable toggle pattern |
| `NetworkSyncable_9773` | `VRCComponentSync` | Basic component serialization |
| `NetworkSyncable_D68A` | `VRCLightweightSync` | Minimal sync (35 methods, 1 field) |
| `NetworkReadyHandlerImpl_0014` | `VRCNetworkUpdateHandler` | Update/FixedUpdate/LateUpdate loop (57 methods) |
| `NetworkDisposeAsync_DFFA` | `VRCNetworkDisposer` | Async disposal (50 methods) |
| `NetworkShouldBroadcastInstigator_03A4` | `VRCEventBroadcastPolicy` | Broadcast rules (31 methods, 13 fields) |
| `PlayerNetSibling_7859` | `PlayerNetworkData` | Player net data container (75 methods, 23 fields) |
| `PlayerNetSibling_6402` | `PlayerNetworkConfig` | Player net config (62 methods, 17 fields) |

---

## 12. Still-Unknown Network Classes

### 12.1 High Priority (need reverse engineering)

| Class | Why Important |
|---|---|
| `NetworkManager` (263 methods, 47 fields) | Central coordinator -- 253 methods still obfuscated. Need to identify event routing, player management, serialization dispatch methods |
| `UdonOperationResponseDisconnectMessage_E05D` obfuscated methods | 134 of 141 methods are `m_XXX`. Need to map event handler switch-case for event codes 1-60, 202, 209-211 |
| `PhotonRoomHandler_E1A7` obfuscated methods | 69 of 109 methods are `m_XXX`. Contains room state management and player tracking |
| `PhotonConnectionHandler_92CA` obfuscated methods | 59 of 72 methods are `m_XXX`. Contains connection state machine and reconnection logic |

### 12.2 Medium Priority

| Class | Why Important |
|---|---|
| `NetworkReadyHandler_318A` (128 methods, 39 fields) | Event serializer -- 89 obfuscated methods. Controls what gets serialized per event |
| `VRCPlayer` (251 methods, 66 fields) | Player entity -- only `PlayEmoteRPC`, `ReloadAvatarNetworkedRPC` named, rest obfuscated |
| `PlayerNet` (144 methods, 53 fields) | Player network state -- Encode/Decode identified but inner logic unknown |
| `NetworkItem_0D57` (96 methods, 30 fields) | Extended hashtable -- collection manipulation logic unclear |
| `VRCNetworkBehaviourSibling*` classes (17+ variants) | Numerous small struct types for serialized network data -- purpose per-type unknown |

### 12.3 Structural Analysis Needed

| Area | What to Look For |
|---|---|
| Event 7/9 binary format | Disassemble `FlatBufferSerializerCodec.Encode8`/`Decode8` to understand bunch structure |
| Event 6 RPC dispatch | Disassemble `UdonOperationResponseDisconnectMessage_E05D.OnEvent` to find switch-case on event code |
| Interest management | Find where Event 8 data is produced/consumed |
| Rate limiting | Find where Event 34/35 data is parsed and applied |

---

## 13. IDA String Reference Summary

| Address Range | Content | Relevance |
|---|---|---|
| `0x2166fd0`-`0x2167de0` | `PhotonEncryptorPlugin` native functions | Encryption: construct, encrypt2, decrypt2, fragment length, logging |
| `0x2167fe0`+ | `opus_decoder_create`, `opus_decode_float` | Voice codec: 64 opus-related function imports |
| `0x9d3e990` | DLL manifest listing | Confirms `PhotonClient.dll`, `VRC.Core.Networking.dll`, `Assembly-CSharp.dll` structure |

---

## 14. DLL Assembly Map

Key networking DLLs identified from IDA strings:

| DLL | Content |
|---|---|
| `PhotonClient.dll` | `Photon.Client` namespace: peer, socket, protocol, encryption |
| `VRC.Core.Networking.dll` | FlatBuffer codec, serialization, tween, state management, quantized serialization |
| `Assembly-CSharp.dll` | NetworkManager, VRCPlayer, PlayerNet, all obfuscated handlers |
| `VRCCore-Standalone.dll` | VRC.Core API classes |
| `VRCSDKBase.dll` | VRC_EventHandler, VRC_Pickup, VRC_Interactable |
| `VRCSDK3.dll` | VRCObjectSync, VRC.SDK3.Network |

---

## 15. Summary Statistics

- **Photon.Client types identified**: 34 (fully named)
- **Photon.Realtime types identified**: 5 (partially obfuscated methods)
- **VRC.Core.Networking types**: 29 (fully named)
- **FlatBuffer types (8+32 bit)**: 43 (fully named)
- **Network callback implementors**: 11 classes
- **IVRC_FlatBufferSerializer implementors**: 15 classes
- **New name mappings proposed**: 31 (22 high-confidence, 9 medium-confidence)
- **NetworkReadyHandler_30DA subclasses**: 37+
- **Total obfuscated methods needing identification**: ~800+ across key network classes
