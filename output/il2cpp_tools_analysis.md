# IL2CPP Tools Analysis for VRChat Reverse Engineering

## 1. IL2CPP_Resolver (459 stars) - Runtime Type Resolution

### Architecture
Header-only C++ library injected into a running Unity/IL2CPP process. Resolves il2cpp exported functions from `GameAssembly.dll` at runtime.

### Key Techniques

**Export Resolution with Anti-Obfuscation:**
- Resolves 22 core il2cpp API exports (`il2cpp_class_from_name`, `il2cpp_domain_get_assemblies`, etc.)
- Handles **ROT cipher obfuscation** on export names: brute-forces ROT-1 through ROT-25 to find renamed exports
- Supports custom `IL2CPP_MAIN_MODULE` definition for non-standard module names

**Type/Class Resolution (Class::Find):**
- Iterates all assemblies via `il2cpp_domain_get_assemblies`
- Splits fully-qualified name at last `.` into namespace + class name
- Calls `il2cpp_class_from_name(image, namespace, className)` on each assembly image

**Obfuscated Class Filtering (Class::Utils::FilterClass):**
- Signature-based class identification using field/method names
- Prefix conventions: `~fieldName` = must be field, `-methodName` = must be method, plain = either
- Counts matching signatures and returns class with highest match count
- Critical for VRChat where class names are obfuscated but member names may survive

**ObscuredValue Support:**
- Built-in XOR-based decryption for Anti-Cheat Toolkit (ACTk) obscured values
- Handles `int`, `float/double`, and `bool` types
- Reads key at field offset, value at offset+sizeof(key), XORs to decrypt
- Directly applicable to VRChat's use of CodeStage Anti-Cheat

**SystemTypeCache:**
- Hash-based cache for frequently-used System.Type objects
- Pre-caches types at initialization for fast runtime lookup

### VRChat Applicability
- No VRChat-specific code, but the FilterClass mechanism is designed for obfuscated games
- ObscuredValue decryption directly targets CodeStage ACTk used by VRChat
- ROT export obfuscation handler not needed for VRChat (standard exports)

---

## 2. IL2CPP-SDK (MagmaMCNet) - Full VRChat Modding Framework

### Architecture
Multi-module C++ SDK with shared-memory vtable architecture:
- **IL2CPP.Common**: Core il2cpp struct definitions, 50+ export function pointers, field/method attribute constants
- **IL2CPP.Module**: High-level reflection API (Class, Field, Method, Property, Type wrappers), ClassResolver, Deobfuscation, ClassCache, MethodHandler
- **Bootstrap.Common**: VRChat-specific data structures, vtable definition, player events, QuickMenu API
- **Bootstrap.Module**: VRChat class wrappers (VRCPlayer, Player, APIUser, Networking, UdonBehaviour, etc.)
- **Hooking.Module**: Detour/prefix/suffix hooking with UI render callbacks

### Key Techniques

**Deobfuscation System (`Deobfuscation.hpp`):**
- Bidirectional mapping: `GetStableName(obfuscated)` and `GetOriginalName(stable)`
- `AddMapping(obfuscated, deobfuscated)` registers new mappings at runtime
- `GetStableNameByShort(shortName)` for bare class name lookups
- `IsObfuscated(name)` checks for non-ASCII/non-printable characters (0x00-0x1F or 0x7F+)
- All Reflection wrappers expose both `.name()` (deobfuscated) and `.raw_name()` (original)

**ClassResolver - Structural Matching Engine (`ClassResolver.hpp`):**
Fluent API for identifying obfuscated classes by structure:

```cpp
ClassResolver resolver(someClass);
resolver.field().byTypeName("String").notStatic().required().toOffset(myOffset);
resolver.field().byType(boolClass).isStatic().toPtr(myPtr);
resolver.method().byName("Update").withParams(0).toPtr(updatePtr);
resolver.counter().byTypeName("Int32").notStatic().expectExact(3);
resolver.collector().byType(floatClass).notStatic().requireCount(5)
    .bindOffset(0, offset0).bindOffset(1, offset1);
resolver.deobfuscate("VRCPlayer");  // register class name mapping
resolver.resolve();  // validate + apply
```

Components:
- **FieldQuery**: Match by type, name, static/instance, self-type; captures offset/pointer/name; registers deobf mappings
- **MethodQuery**: Match by name, param count, param type, return type; collects all or first match
- **FieldCounter**: Count fields by type with exact/min/max/range expectations for structural fingerprinting
- **IndexedFieldCollector**: Capture N-th field of a type, bind by index with deobf registration

**ClassCache - Signature-Based Filtering (`ClassCache.hpp`):**
Rich signature syntax for finding classes:
- `"~fieldName"` - must have field with name
- `"-methodName"` - must have method with name
- `"^className"` - direct parent must be className
- `"^^className"` - any ancestor must be className
- `"!name"` - negative match (must NOT have)
- Plain `"name"` - field or method

Example: `cache.Filter({"~_vrcplayer", "~_USpeaker"}, "Assembly-CSharp")`

**MethodHandler - Safe Method Invocation:**
- `resolve("VRC.SDKBase.Networking", "GetServerTimeInSeconds", 0)` - cached resolution
- `invoke<TReturn>(method, obj, params)` - typed invocation with auto-unboxing
- Handles void, pointer, and value type returns

### VRChat-Specific Code (Extensive)

**VRChat Data Structures (`vrc_types.hpp`):**
| Structure | Fields |
|-----------|--------|
| `PlayerData` | Class, Singleton, VRCPlayerApi, VRCPlayer, APIUser, USpeaker |
| `VRCPlayerData` | VRCPlayerApi, Player, PlayerNameplate, PoseRecorder, Serializer, SyncPhysics, ApiAvatar, ApiAvatarFallback, Color_Administrator/Friend/Visitor/NewUser/User/KnownUser/Trusted/Nuisance |
| `PlayerNameplateData` | 20 GameObject offsets (contents, subText, quickStats, platform, pronouns, etc.) |
| `LoadBalancingClientData` | Class, OnEvent, OpRaiseEvent |
| `FlatBufferNetworkSerializerData` | Class, RequireFastRate |
| `PhotonViewData` | Class, ViewId |
| `VRCPlayerStepHeightData` | maxStepHeight, stepUpThreshold, offsetDistance, characterController, groundedLayers |
| `VRCMotionStateData` | characterController |
| `ONSPAudioData` | audioSource, onspLowPassFilter, onspAudioSource |
| `RoomManagerData` | apiWorld, apiWorldInstance |
| `VRCDroneData` | vrcPickup, trailRenderer, worldCollider, pickupCollider, PlayerOwner |

**VRChat Class Wrappers:**
- `VRCPlayer`: GetVRCPlayerApi(), GetPlayer(), GetNameplate(), GetLocalPlayer()
- `Player`: GetVRCPlayer(), GetAPIUser(), GetUSpeaker(), GetPlayerRank(), GetRankColor()
- `VRCPlayerApi`: Full SDK mirror - 70+ methods covering identity, tracking, movement, voice, avatar scaling, nameplates, ownership
- `APIUser`: GetDisplayName/Username/Pronouns/Bio/BioLinks/Status/Tags/Note, avatar info, social/platform data, GetPlayerRank()
- `Networking`: 30+ static methods - IsNetworkSettled/IsMaster/IsClogged, GetLocalPlayer/Master/Owner, RPC, ownership, storage, timing
- `UdonBehaviour`: SendCustomEvent, SendCustomNetworkEvent, Get/SetProgramVariable, RequestSerialization
- `PlayerNameplate`: GameObject offset access for all nameplate UI elements
- `VRChatEvents`: Player lifecycle callbacks (Awake, Join, JoinComplete, Leave)

**VRChat Enums:**
- TrackingDataType (Head, LeftHand, RightHand, Origin, AvatarRoot)
- HumanBodyBones (55 bones, full humanoid rig)
- SpawnOrientation, VRC_SerializationMethod, EventTiming, NetworkEventTarget
- SyncType, RpcDestination (10 values), VrcBroadcastType (10 values)
- PlayerRank, ApiPlayerRank
- BootstrapSprite (VRC built-in sprites including VRCPlus, Store, Settings, etc.)

**Bootstrap Vtable System:**
The SDK communicates through shared memory with a central Bootstrap process. The vtable provides:
- VRChat data accessors (player data, nameplate data)
- Player event registration
- QuickMenu creation (pages, buttons, toggles, sliders, foldouts)
- Config persistence (int/float/string/bool/vec2/vec3/vec4/color/json)
- TweenService, NameplateService
- Filesystem operations, Clipboard, WebSocket
- KeyAuth integration
- Performance controls (GC, cleanup)

---

## 3. Beebyte-Deobfuscator - Comparative Deobfuscation Plugin

### Architecture
Il2CppInspector plugin that compares an obfuscated binary against an unobfuscated reference to restore original names.

### Key Techniques

**Comparative Matching Algorithm:**
1. Loads both obfuscated and clean (unobfuscated) binaries
2. Creates TypeModels for both
3. Builds a **LookupMatrix** indexing types by structural fingerprint:
   - Static field count
   - Literal (const) field count  
   - Generic (instance) field count
   - Property count
   - Namespace
4. For each clean type, finds candidates in the matrix with matching fingerprint
5. If unique match (1 candidate) -> direct mapping
6. Multiple candidates -> scoring system:
   - `CompareFieldOffsets()`: Penalizes mismatched field offsets
   - `CompareFieldTypes()`: Penalizes mismatched field types
   - Combined score (average of both) determines best match
   - Exact name matches score 1.5 (perfect); non-obfuscated name mismatch scores 0.0 (rejection)

**Field Translation:**
- Separates fields into static and generic (instance) categories
- Matches fields by index position within each category
- Optionally validates by offset (when `checkoffsets = true`)

**Nested Type Translation:**
- Recursively translates children types using same scoring
- Requires field count match as initial filter

**Configuration:**
- `naming-pattern`: Regex identifying obfuscated names (e.g., `^[A-Z]{11}$` for Beebyte's pattern)
- `backend`: IL2CPP or Mono
- `clean-metadata-path`: Path to unobfuscated global-metadata.dat
- `clean-binary-path`: Path to unobfuscated GameAssembly.dll
- Export formats: Il2CppTranslator classes, PlainText, JSON Translations, JSON Mappings

### VRChat Applicability
- Requires an **unobfuscated reference build** of VRChat (e.g., older pre-obfuscation version or VRCSDK)
- The naming regex for VRChat's Beebyte obfuscation would typically match patterns like `^[A-Za-z]{8,15}$` or similar
- Can produce translation maps usable by other tools
- Most effective when structural changes between versions are minimal

---

## 4. Il2CppInterop (BepInEx) - Assembly Rewriting & Xref Scanning

### Architecture
.NET library that rewrite IL2CPP assemblies into managed proxy assemblies for BepInEx/MelonLoader. Includes type deobfuscation and cross-reference scanning.

### Key Techniques

**Obfuscated Name Detection & Rename (Pass05CreateRenameGroups):**
Generates deterministic "unobfuscated" names from structural context:
1. Walks inheritance chain to first non-obfuscated base type
2. Builds name from: base type name + inheritance depth + access modifier + abstract/sealed/interface flags
3. Appends unobfuscated interface names
4. Creates a **UniquificationContext** from: field types, field names, property types, property names
5. For delegates: includes Invoke method return type and parameter types
6. For interfaces: includes method signatures (name, return type, param types)
7. Result: deterministic name like `MonoBehaviour1NPublicSealedBoSiSi` that survives obfuscation changes

**Rename Group Deduplication:**
- Groups types with identical generated names
- If multiple types map to same name -> discards group (ambiguous)
- Uses stable hash for tracking renamed types across passes

**Cross-Reference Scanner (XrefScanner):**
- Disassembles x86/x64 native code using **Iced** disassembler
- Tracks `CALL`/`JMP` instructions -> method cross-references
- Tracks `MOV` with IP-relative addressing -> global/static references
- Caches results via `CachedScanResultsAttribute` for performance
- `XrefScan(method)`: outgoing references from a method
- `UsedBy(method)`: incoming references to a method

**ObfuscatedNameAttribute:**
- Tags generated proxy types with `[ObfuscatedName("originalHash")]`
- Preserves mapping from proxy name back to original obfuscated name
- Used by runtime to resolve types across version updates

### VRChat Applicability
- Standard tool in MelonLoader/BepInEx VRChat modding pipeline
- XrefScanner is essential for finding method relationships when names are obfuscated
- Deterministic rename scheme produces stable names that work across VRChat updates (as long as structure doesn't change)
- `ObfuscatedNameAttribute` enables cross-version mod compatibility

---

## 5. VRChat Class Names Found Across Tools

### From IL2CPP-SDK (Definitive - Active 2026.3)

**Core Player System:**
- `VRCPlayer` / `VRCPlayerApi` / `Player`
- `APIUser` / `ApiModel` / `ApiBadge`
- `PlayerNameplate`

**Networking:**
- `VRC.SDKBase.Networking` (static class, fully qualified)
- `LoadBalancingClient` (Photon)
- `FlatBufferNetworkSerializer`
- `PhotonView`

**Udon System:**
- `UdonBehaviour`
- `VRC_Interactable` (base class)

**World/Room:**
- `RoomManager` (fields: apiWorld, apiWorldInstance)
- `ApiAvatar` / `ApiAvatarFallback`

**Player Physics & Movement:**
- `VRCPlayerStepHeight` (maxStepHeight, stepUpThreshold, offsetDistance)
- `VRCMotionState` (characterController)
- `VRCDrone` (vrcPickup, trailRenderer)

**Audio:**
- `ONSPAudio` (audioSource, onspLowPassFilter, onspAudioSource)
- `USpeaker`

**UI:**
- `VRCRectMask2D`
- `LocalizableString`

**Serialization:**
- `PoseRecorder`
- `Serializer`
- `SyncPhysics`

**SDK Enums & Constants:**
- `PlayerRank` / `ApiPlayerRank`
- `TrackingDataType` / `HumanBodyBones`
- `RpcDestination` / `VrcBroadcastType` / `NetworkEventTarget`
- `SyncType` / `VRC_SerializationMethod`
- `EventTiming` / `SpawnOrientation`

### Trust Rank Colors (from VRCPlayerData):
- Administrator, Friend, Visitor, NewUser, User, KnownUser, Trusted, Nuisance

---

## 6. Recommended Workflow

### Phase 1: Static Analysis
1. **Il2CppInspectorRedux + Beebyte-Deobfuscator**
   - Load VRChat's `GameAssembly.dll` + `global-metadata.dat`
   - If you have a clean VRCSDK reference build, use Beebyte to map names
   - Configure naming regex to match VRChat's obfuscation pattern
   - Export JSON translations for downstream tools

2. **Il2CppInterop (Generator)**
   - Generate proxy assemblies from the Il2CppInspector output
   - Pass05 produces deterministic names even without a reference build
   - XrefScanner data embedded in proxy assemblies for runtime use

### Phase 2: Runtime Analysis  
3. **IL2CPP-SDK (MagmaMCNet) - Primary Runtime Tool**
   - Most complete VRChat integration available
   - Use ClassCache to load assemblies and filter by structural signatures
   - ClassResolver for precise obfuscated class identification
   - Deobfuscation module maintains bidirectional name maps at runtime
   - Full VRChat API wrappers for player, networking, Udon, UI
   - Hooking module for method interception (detour/prefix/suffix)

4. **IL2CPP_Resolver - Lightweight Alternative**
   - Simpler, header-only, for quick prototyping
   - FilterClass for signature-based class finding
   - Built-in ObscuredValue (ACTk) decryption
   - No VRChat-specific code, requires manual setup

### Phase 3: Cross-Reference & Verification
5. Use XrefScanner data to trace call chains through obfuscated methods
6. Compare deobfuscation results from Beebyte, Il2CppInterop, and IL2CPP-SDK
7. Feed confirmed mappings back into IL2CPP-SDK's Deobfuscation.AddMapping()

### Tool Complementarity Matrix

| Capability | IL2CPP_Resolver | IL2CPP-SDK | Beebyte | Il2CppInterop |
|---|---|---|---|---|
| Runtime injection | Yes | Yes | No | No (generator) |
| VRChat types | No | Extensive | No | No |
| Deobfuscation | Signature filter | Full deobf engine | Comparative | Deterministic rename |
| Reference build needed | No | No | Yes | No |
| Hooking | Manual | Built-in module | N/A | N/A |
| ACTk/Obscured values | Built-in | Not built-in | N/A | N/A |
| Cross-references | No | No | No | XrefScanner |
| Export formats | N/A | Runtime maps | JSON/Text/Classes | Proxy DLLs |

---

## 7. VRChat-Specific Configuration Notes

### IL2CPP-SDK Setup
- Module name: `GameAssembly.dll` (standard)
- Primary assembly: `Assembly-CSharp`
- SDK namespace: `VRC.SDKBase`
- Main class names to resolve first: `VRCPlayer`, `Player`, `APIUser`, `Networking`
- Bootstrap connects via shared memory (`SharedMemory::Resolve<Bootstrap::BootstrapVtable>("Bootstrap.Vtable")`)
- Console supports deobfuscated name display: `set_deobfuscate_names(true)`

### Beebyte-Deobfuscator Config for VRChat
- Backend: IL2CPP
- Naming regex: Match Beebyte's obfuscation pattern (typically randomized identifier strings)
- Clean binary: Requires unobfuscated VRCSDK or old VRChat build
- Export: JSON Mappings recommended for integration with other tools

### Obfuscation Detection Heuristic
From IL2CPP-SDK `Deobfuscation::IsObfuscated()`:
```cpp
// A name is obfuscated if it contains non-printable/non-ASCII chars
for each byte: if (byte > 0x7E || byte < 0x20) return true;
```
This catches VRChat's Beebyte-style names which contain non-standard characters.

### Key Structural Signatures for VRChat Classes
From the SDK's ClassCache filter syntax:
- Player class: `{"~_vrcplayer", "~_USpeaker"}`
- VRCPlayer class: Fields VRCPlayerApi, Player, PlayerNameplate, PoseRecorder, Serializer, SyncPhysics, ApiAvatar
- Networking class: Static fields IsNetworkSettled, IsMaster, IsClogged, LocalPlayer, Master
