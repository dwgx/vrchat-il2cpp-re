// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCSDK2
// Classes: 67
// Methods: 200

namespace VRCSDK2
{
    public class IPlayerModComponent
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFAC2C70A40
    }

    public class IVRC_SerializableBehaviour
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFAC2C58E90
        public void SetBytes(){} // RVA: 0x7FFAC2C70A40
    }

    public class VRCDebugCommand : MonoBehaviour
    {
        public string Command; // 0x20
        public int ParamInt; // 0x28
        public float ParamFloat; // 0x2C
        public string ParamString; // 0x30
        public UnityEngine.Object ParamObject; // 0x38
        public AwakeDelegate OnAwake;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFEEA40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRCPlayerMod : Object
    {
        public string name; // 0x10
        public System.Collections.Generic.List`1<VRCSDK2.VRCPlayerModProperty> properties; // 0x18
        public string modComponentName; // 0x20
        public bool allowNameEdit; // 0x28

        // ── Methods ──
        public void set_name(){} // RVA: 0x7FFACBFEB1D0
        public void get_name(){} // RVA: 0x7FFAC2F3C380
        public void get_properties(){} // RVA: 0x7FFAC2F247C0
        public void get_modComponentName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_allowNameEdit(){} // RVA: 0x7FFAC30F6BA0
        public void .ctor(){} // RVA: 0x7FFACBFEB230
        public void AddOrUpdateModComponentOn(){} // RVA: 0x7FFACBFEB3C0
        public void Equals(){} // RVA: 0x7FFACBFEB680
    }

    public class VRCPlayerModFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFACBFE94D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VRCPlayerModProperty : Object
    {
        public string name; // 0x10
        public int intValue; // 0x18
        public float floatValue; // 0x1C
        public string stringValue; // 0x20
        public bool boolValue; // 0x28
        public UnityEngine.GameObject gameObjectValue; // 0x30
        public 0x6B17D1A8 keyCodeValue; // 0x38
        public UnityEngine.RuntimeAnimatorController animationController; // 0x40
        public 0x6B2517F8 broadcastValue; // 0x48
        public 0x6B2C5940 onDeathActionValue; // 0x4C
        public VRCSDK2.VRCSerializableSystemType type; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEAAE0 | overloaded x9
        public void value(){} // RVA: 0x7FFACBFEACF0
    }

    public class VRCSerializableSystemType : Object
    {
        public string Name; // 0x10
        public string AssemblyQualifiedName; // 0x18
        public string AssemblyName; // 0x20
        public System.Type SystemType; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC2F247C0
        public void get_AssemblyName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SystemType(){} // RVA: 0x7FFACBFEEAA0
        public void GetSystemType(){} // RVA: 0x7FFACBFEEBB0
        public void .ctor(){} // RVA: 0x7FFACBFEEC80
        public void Equals(){} // RVA: 0x7FFACBFEEF20 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFACBFEEF80
        public void op_Inequality(){} // RVA: 0x7FFACBFEF000
        public void GetHashCode(){} // RVA: 0x7FFACBFEF090
    }

    public class VRCTriggerRelay : VRCTriggerRelay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEF0D0
    }

    public class VRC_AddDamage : MonoBehaviour
    {
        public float damageAmount; // 0x20
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFE2C30
        public void ProvideEvents(){} // RVA: 0x7FFACBFE2C90
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class VRC_AddHealth : MonoBehaviour
    {
        public float healthAmount; // 0x20
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFE2F10
        public void ProvideEvents(){} // RVA: 0x7FFACBFE2F70
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class VRC_AudioBank : MonoBehaviour
    {
        public 0x6B2C6390 Current; // 0x20
        public 0x6B2C63E8 CurrentIdx; // 0x24
        public UnityEngine.AudioSource Source; // 0x28
        public float MinPitchRange; // 0x30
        public float MaxPitchRange; // 0x34
        public CustomTriggerTarget OnPlay; // 0x38
        public CustomTriggerTarget OnStop; // 0x40
        public CustomTriggerTarget OnChange; // 0x48
        public UnityEngine.AudioClip[] Clips; // 0x50
        public int[] playOrder; // 0x58
        public int current; // 0x60
        public float remainingTime; // 0x64
        public System.Random rng; // 0x68

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFACBFEF0E0
        public void get_CurrentIdx(){} // RVA: 0x7FFACBFEF240
        public void Play(){} // RVA: 0x7FFACBFEF270
        public void Stop(){} // RVA: 0x7FFACBFEF2F0
        public void PlayNext(){} // RVA: 0x7FFACBFEF420
        public void Shuffle(){} // RVA: 0x7FFACBFEF5D0
        public void play(){} // RVA: 0x7FFACBFEF750
        public void findCurrent(){} // RVA: 0x7FFACBFEFBE0
        public void reset(){} // RVA: 0x7FFACBFEFC30
        public void Awake(){} // RVA: 0x7FFACBFEFFA0
        public void Update(){} // RVA: 0x7FFACBFF00E0
        public void LateUpdate(){} // RVA: 0x7FFACBFF0190
        public void ProvideEvents(){} // RVA: 0x7FFACBFF01D0
        public void .ctor(){} // RVA: 0x7FFACBFF0A70
        public void <PlayNext>b__21_0(){} // RVA: 0x7FFACBFF0BC0
        public void <Shuffle>b__22_0(){} // RVA: 0x7FFACBFF0BC0
    }

    public class VRC_AvatarDescriptor : VRC_AvatarDescriptor
    {
        public UnityEngine.AnimatorOverrideController CustomStandingAnims; // 0xB8
        public UnityEngine.AnimatorOverrideController CustomSittingAnims; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE1C90
    }

    public class VRC_AvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE31F0
    }

    public class VRC_AvatarVariations : MonoBehaviour
    {
        public VariationCategory[] categories; // 0x20
        public bool initialized; // 0x28
        public string currentVariationSpec; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.MeshRenderer> initialMeshes; // 0x38
        public UnityEngine.Material[] initialMaterials; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACBFE1CA0
        public void RecordInitialState(){} // RVA: 0x7FFACBFE1CD0
        public void SetVariationSpec(){} // RVA: 0x7FFACBFE20A0
        public void RevertVariations(){} // RVA: 0x7FFACBFE2120
        public void ApplyVariations(){} // RVA: 0x7FFACBFE2320
        public void ApplyVariation(){} // RVA: 0x7FFACBFE2590
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_CombatSystem : MonoBehaviour
    {
        public VRCSDK2.VRC_CombatSystem instance;
        public float maxPlayerHealth; // 0x20
        public bool respawnOnDeath; // 0x24
        public UnityEngine.Transform respawnPoint; // 0x28
        public float respawnTime; // 0x30
        public bool resetHealthOnRespawn; // 0x34
        public UnityEngine.GameObject visualDamagePrefab; // 0x38
        public CustomTriggerTarget onPlayerKilledTrigger; // 0x40
        public CustomTriggerTarget onPlayerHealedTrigger; // 0x48
        public CustomTriggerTarget onPlayerDamagedTrigger; // 0x50
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> onPlayerKilled; // 0x58
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> onPlayerHealed; // 0x60
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> onPlayerDamaged; // 0x68
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> onSetupPlayer; // 0x70

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBFE26F0
        public void OnDestroy(){} // RVA: 0x7FFACBFE2730
        public void Awake(){} // RVA: 0x7FFACBFE27D0
        public void RespawnPlayer(){} // RVA: 0x7FFACBFE2960
        public void RespawnPlayerRPC(){} // RVA: 0x7FFACBFE2AD0
        public void .ctor(){} // RVA: 0x7FFACBFE2B70
    }

    public class VRC_CustomRendererBehaviour : MonoBehaviour
    {
        public bool Renderer; // 0x20
        public UnityEngine.Renderer _renderer; // 0x28

        // ── Methods ──
        public void get_Renderer(){} // RVA: 0x7FFACBFF0BF0
        public void Update(){} // RVA: 0x7FFACBFF0D80
        public void .ctor(){} // RVA: 0x7FFAC2F7B060
    }

    public class VRC_DataStorage : VRC_DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_DestructibleStandard : VRC_DestructibleStandard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE2BD0
    }

    public class VRC_EventDispatcher : VRC_EventDispatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_EventHandler : VRC_EventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFF0EB0
    }

    public class VRC_GunStats : VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE3200
    }

    public class VRC_IKFollower : VRC_IKFollower
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Interactable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3368510
    }

    public class VRC_JukeBox : MonoBehaviour
    {
        public bool AutoPlay; // 0x20
        public bool Shuffle; // 0x21
        public UnityEngine.AudioClip[] Songs; // 0x28
        public int PlayingSong; // 0x30
        public System.Collections.Generic.List`1<int> SongLog; // 0x38
        public UnityEngine.AudioSource Speakers; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACBFE3260
        public void Update(){} // RVA: 0x7FFACBFE3300
        public void PlayNextSong(){} // RVA: 0x7FFACBFE35F0
        public void PlayPreviousSong(){} // RVA: 0x7FFACBFE3A10
        public void .ctor(){} // RVA: 0x7FFACBFE3C60
    }

    public class VRC_KeyEvents : VRC_KeyEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Label : VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFF0EC0
    }

    public class VRC_MetadataListener : VRC_MetadataListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_MidiNoteIn : VRC_MidiNoteIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_MirrorReflection : VRC_MirrorReflection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEB740
    }

    public class VRC_NPCSpawn : VRC_NPCSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE3D60
    }

    public class VRC_NpcApi : VRC_NpcApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_ObjectApi : VRC_ObjectApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_ObjectSpawn : VRC_ObjectSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_ObjectSync : VRCNetworkBehaviour
    {
        public InitializationDelegate useGravity;
        public IsLocalDelegate isKinematic; // 0x8
        public bool SynchronizePhysics; // 0x20
        public bool AllowCollisionTransfer; // 0x21
        public TeleportDelegate TeleportHandler; // 0x10
        public System.Action`1<VRCSDK2.VRC_ObjectSync> RespawnHandler; // 0x18
        public System.Func`2<VRCSDK2.VRC_ObjectSync,bool> GetUseGravity; // 0x20
        public System.Func`2<VRCSDK2.VRC_ObjectSync,bool> GetIsKinematic; // 0x28
        public System.Action`2<VRCSDK2.VRC_ObjectSync,bool> SetUseGravity; // 0x30
        public System.Action`2<VRCSDK2.VRC_ObjectSync,bool> SetIsKinematic; // 0x38
        public System.Action`1<VRCSDK2.VRC_ObjectSync> DiscontinuityHandler; // 0x40

        // ── Methods ──
        public void get_useGravity(){} // RVA: 0x7FFACBFE3EA0
        public void set_useGravity(){} // RVA: 0x7FFACBFE3F10
        public void get_isKinematic(){} // RVA: 0x7FFACBFE3F80
        public void set_isKinematic(){} // RVA: 0x7FFACBFE3FF0
        public void TeleportTo(){} // RVA: 0x7FFACBFE41B0 | overloaded x2
        public void Respawn(){} // RVA: 0x7FFACBFE4250
        public void Awake(){} // RVA: 0x7FFACBFE42B0
        public void TakeOwnership(){} // RVA: 0x7FFACBFE4310
        public void FlagDiscontinuity(){} // RVA: 0x7FFACBFE4380
        public void ProvideEvents(){} // RVA: 0x7FFACBFE43E0
        public void .ctor(){} // RVA: 0x7FFAC8C96450
    }

    public class VRC_OscButtonIn : VRC_OscButtonIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_PhysicsRoot : VRC_PhysicsRoot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Pickup : VRC_Pickup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE54A0
    }

    public class VRC_PlayerAudioOverride : MonoBehaviour
    {
        public float VoiceGain; // 0x20
        public float VoiceFar; // 0x24
        public float VoiceNear; // 0x28
        public float VoiceVolumetricRadius; // 0x2C
        public bool VoiceDisableLowpass; // 0x30
        public float AvatarGainLimit; // 0x34
        public float AvatarFarLimit; // 0x38
        public float AvatarNearLimit; // 0x3C
        public float AvatarVolumetricRadiusLimit; // 0x40
        public bool AvatarForceSpatial; // 0x44
        public bool AvatarAllowCustomCurve; // 0x45
        public bool global; // 0x46
        public UnityEngine.Collider region; // 0x48
        public float regionPriority; // 0x50
        public InitializationDelegate Initialize;
        public RegionDelegate onRegionEnter; // 0x58
        public RegionDelegate onRegionExit; // 0x60

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFE1960
        public void OnTriggerEnter(){} // RVA: 0x7FFACBFE1B70
        public void OnTriggerExit(){} // RVA: 0x7FFACBFE1B90
        public void .ctor(){} // RVA: 0x7FFACBFE1BB0
    }

    public class VRC_PlayerMods : MonoBehaviour
    {
        public bool isRoomPlayerMods; // 0x20
        public System.Collections.Generic.List`1<VRCSDK2.VRCPlayerMod> playerMods; // 0x28
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFEB790
        public void AddMod(){} // RVA: 0x7FFACBFEB7F0
        public void RemoveMod(){} // RVA: 0x7FFACBFEBA50
        public void ProvideEvents(){} // RVA: 0x7FFACBFEBC30
        public void .ctor(){} // RVA: 0x7FFACBFEC060
    }

    public class VRC_PortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_PropApi : VRC_PropApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_PropController : VRC_PropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE54B0
    }

    public class VRC_SceneDescriptor : VRC_SceneDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEC160
    }

    public class VRC_SceneResetPosition : MonoBehaviour
    {
        public UnityEngine.Transform Position; // 0x20
        public bool RemoveVelocity; // 0x28
        public UnityEngine.Rigidbody rigidbody; // 0x30
        public VRCSDK2.VRC_ObjectSync sync; // 0x38
        public UnityEngine.Vector3 initialPosition; // 0x40
        public UnityEngine.Quaternion initialRotation; // 0x4C
        public UnityEngine.Vector3 initialScale; // 0x5C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACBFEC1B0
        public void ResetPosition(){} // RVA: 0x7FFACBFEC4A0
        public void ResetPositionWithoutHint(){} // RVA: 0x7FFACBFED010
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
    }

    public class VRC_SceneSmoothShift : MonoBehaviour
    {
        public UnityEngine.AnimationCurve ShiftInterpolationCurve; // 0x20
        public float ShiftSpeed; // 0x28
        public UnityEngine.Transform ShiftStart; // 0x30
        public UnityEngine.Transform ShiftEnd; // 0x38
        public float TargetPosition; // 0x40
        public float ShiftPosition; // 0x44

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACBFED8A0
        public void OnValidate(){} // RVA: 0x7FFACBFEDA60
        public void Update(){} // RVA: 0x7FFACBFEDA70
        public void Shift(){} // RVA: 0x7FFACBFEE240
        public void .ctor(){} // RVA: 0x7FFACBFEE270
    }

    public class VRC_SlideShow : VRC_SlideShow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE55B0
    }

    public class VRC_SpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE1C30
    }

    public class VRC_SpecialLayer : VRC_SpecialLayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Station : VRCStation
    {
        public CustomTriggerTarget OnRemotePlayerEnterStation; // 0x50
        public CustomTriggerTarget OnLocalPlayerEnterStation; // 0x58
        public CustomTriggerTarget OnRemotePlayerExitStation; // 0x60
        public CustomTriggerTarget OnLocalPlayerExitStation; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE430
    }

    public class VRC_StationApi : MonoBehaviour
    {
        public StationOccupiedDelegate IsStationOccupiedDelegate;
        public StationOccupantDelegate GetStationOccupant; // 0x8

        // ── Methods ──
        public void IsStationOccupied(){} // RVA: 0x7FFACBFEE490
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_StationInput : MonoBehaviour
    {
        public VRC.SDKBase.VRCPlayerApi controllingPlayer; // 0x20
        public UnityEngine.Vector2 inputLeftAnalog; // 0x28
        public UnityEngine.Vector2 inputRightAnalog; // 0x30
        public bool inputUseButton; // 0x38
        public UpdateDelegate UpdateInputs;
        public InitializeDelegate Initialize; // 0x8
        public System.Collections.Generic.List`1<InputPairing> customInputs; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFE5600
        public void Update(){} // RVA: 0x7FFACBFE5660
        public void GetInputIndex(){} // RVA: 0x7FFACBFE56D0
        public void .ctor(){} // RVA: 0x7FFACBFE57D0
    }

    public class VRC_StereoObject : VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_SyncAnimation : VRCNetworkBehaviour
    {
        public float AnimationStartPosition; // 0x20
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBFE58F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_SyncVideoPlayer : VRCNetworkBehaviour
    {
        public bool AllowNonOwnerControl; // 0x20
        public string VideoSearchRoot; // 0x28
        public int MaxStreamQuality; // 0x30
        public VideoEntry[] Videos; // 0x38
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Play;
        public System.Action`2<VRCSDK2.VRC_SyncVideoPlayer,int> _PlayIndex; // 0x8
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Stop; // 0x10
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Pause; // 0x18
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Next; // 0x20
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Previous; // 0x28
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Shuffle; // 0x30
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _Clear; // 0x38
        public System.Action`2<VRCSDK2.VRC_SyncVideoPlayer,string> _AddURL; // 0x40
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _SpeedUp; // 0x48
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> _SpeedDown; // 0x50
        public System.Action`2<VRCSDK2.VRC_SyncVideoPlayer,float> _SetMaxQuality; // 0x58
        public System.Action`1<VRCSDK2.VRC_SyncVideoPlayer> Initialize; // 0x60

        // ── Methods ──
        public void Play(){} // RVA: 0x7FFACBFE5950
        public void PlayIndex(){} // RVA: 0x7FFACBFE59B0
        public void Stop(){} // RVA: 0x7FFACBFE5A20
        public void Pause(){} // RVA: 0x7FFACBFE5A80
        public void Next(){} // RVA: 0x7FFACBFE5AE0
        public void Previous(){} // RVA: 0x7FFACBFE5B40
        public void Shuffle(){} // RVA: 0x7FFACBFE5BA0
        public void Clear(){} // RVA: 0x7FFACBFE5C00
        public void AddURL(){} // RVA: 0x7FFACBFE5C60
        public void SpeedUp(){} // RVA: 0x7FFACBFE5CD0
        public void SpeedDown(){} // RVA: 0x7FFACBFE5D30
        public void SetMaxQuality(){} // RVA: 0x7FFACBFE5D90
        public void Awake(){} // RVA: 0x7FFACBFE5E00
        public void ProvideEvents(){} // RVA: 0x7FFACBFE5E60
        public void .ctor(){} // RVA: 0x7FFACBFE6EB0
    }

    public class VRC_SyncVideoStream : VRCNetworkBehaviour
    {
        public bool AllowNonOwnerControl; // 0x20
        public string VideoSearchRoot; // 0x28
        public int MaxStreamQuality; // 0x30
        public bool AutoStart; // 0x34
        public VideoEntry[] Videos; // 0x38
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Play;
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,int> _PlayIndex; // 0x8
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Stop; // 0x10
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Pause; // 0x18
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Next; // 0x20
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Previous; // 0x28
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Shuffle; // 0x30
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _Clear; // 0x38
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,string> _AddURL; // 0x40
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,float> _FastForwardSeconds; // 0x48
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,float> _RewindSeconds; // 0x50
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _LocalResync; // 0x58
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,0x6B2C5680> _SetSyncType; // 0x60
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,float> _SetSyncMinutes; // 0x68
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> _ShowSearch; // 0x70
        public System.Action`2<VRCSDK2.VRC_SyncVideoStream,float> _SetMaxQuality; // 0x78
        public System.Action`1<VRCSDK2.VRC_SyncVideoStream> Initialize; // 0x80

        // ── Methods ──
        public void Play(){} // RVA: 0x7FFACBFE70D0
        public void PlayIndex(){} // RVA: 0x7FFACBFE7130
        public void Stop(){} // RVA: 0x7FFACBFE71A0
        public void Pause(){} // RVA: 0x7FFACBFE7200
        public void Next(){} // RVA: 0x7FFACBFE7260
        public void Previous(){} // RVA: 0x7FFACBFE72C0
        public void Shuffle(){} // RVA: 0x7FFACBFE7320
        public void Clear(){} // RVA: 0x7FFACBFE7380
        public void AddURL(){} // RVA: 0x7FFACBFE73E0
        public void FastForwardSeconds(){} // RVA: 0x7FFACBFE7450
        public void RewindSeconds(){} // RVA: 0x7FFACBFE74C0
        public void Resync(){} // RVA: 0x7FFACBFE7530
        public void SetSyncType(){} // RVA: 0x7FFACBFE7590
        public void SetSyncMinutes(){} // RVA: 0x7FFACBFE7600
        public void ShowSearch(){} // RVA: 0x7FFACBFE7670
        public void SetMaxQuality(){} // RVA: 0x7FFACBFE76D0
        public void Awake(){} // RVA: 0x7FFACBFE7740
        public void ProvideEvents(){} // RVA: 0x7FFACBFE77B0
        public void .ctor(){} // RVA: 0x7FFACBFE8F50
    }

    public class VRC_TimedEvents : VRC_TimedEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE4F0
    }

    public class VRC_Trigger : VRC_Trigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE550
    }

    public class VRC_TriggerColliderEventTrigger : VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE620
    }

    public class VRC_TutorialAction : VRC_TutorialAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_TutorialAreaMarker : VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE9E0
    }

    public class VRC_UiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FD5710
    }

    public class VRC_UseEvents : VRC_UseEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE670
    }

    public class VRC_VideoScreen : MonoBehaviour
    {
        public VRCSDK2.VRC_SyncVideoStream Initialize; // 0x20
        public int _materialIndex; // 0x28
        public string _textureProperty; // 0x30
        public bool _useSharedMaterial; // 0x38
        public System.Action`1<VRCSDK2.VRC_VideoScreen> <Initialize>k__BackingField;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFACBFE9180
        public void set_Initialize(){} // RVA: 0x7FFACBFE91C0
        public void Awake(){} // RVA: 0x7FFACBFE9260
        public void .ctor(){} // RVA: 0x7FFACBFE92C0
    }

    public class VRC_VideoSpeaker : MonoBehaviour
    {
        public VRCSDK2.VRC_SyncVideoStream Initialize; // 0x20
        public 0x6B2C57E0 _channelType; // 0x28
        public System.Action`1<VRCSDK2.VRC_VideoSpeaker> <Initialize>k__BackingField;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFACBFE9390
        public void set_Initialize(){} // RVA: 0x7FFACBFE93D0
        public void Awake(){} // RVA: 0x7FFACBFE9470
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Water : VRC_Water
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE710
    }

    public class VRC_WebPanel : VRC_WebPanel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE8B0
    }

}