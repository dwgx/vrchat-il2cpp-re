// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCSDK2
// Classes: 63
// Methods: 169

namespace VRCSDK2
{
    public class IPlayerModComponent
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFD4E090A40
    }

    public class VRCDebugCommand : MonoBehaviour
    {
        public string Command; // 0x20
        public int ParamInt; // 0x28
        public float ParamFloat; // 0x2C
        public string ParamString; // 0x30
        public object ParamObject; // 0x38
        public ShadowZeroAlloc OnAwake;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5740EA40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCPlayerModFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD574094D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class VRCTriggerRelay : VRCTriggerRelay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740F0D0
    }

    public class VRC_AddDamage : MonoBehaviour
    {
        public float damageAmount; // 0x20
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57402C30
        public void ProvideEvents(){} // RVA: 0x7FFD57402C90
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class VRC_AddHealth : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57402F10
        public void ProvideEvents(){} // RVA: 0x7FFD57402F70
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class VRC_AudioBank : MonoBehaviour
    {
        public Nonce Current; // 0x20
        public Property CurrentIdx; // 0x24
        public t Source; // 0x28
        public float MinPitchRange; // 0x30
        public float MaxPitchRange; // 0x34
        public t_compositionCursorPos OnPlay; // 0x38
        public t_compositionCursorPos OnStop; // 0x40
        public t_compositionCursorPos OnChange; // 0x48
        public ies[] Clips; // 0x50
        public int[] playOrder; // 0x58
        public int current; // 0x60
        public float remainingTime; // 0x64
        public object rng; // 0x68

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFD5740F0E0
        public void get_CurrentIdx(){} // RVA: 0x7FFD5740F240
        public void Play(){} // RVA: 0x7FFD5740F270
        public void Stop(){} // RVA: 0x7FFD5740F2F0
        public void PlayNext(){} // RVA: 0x7FFD5740F420
        public void Shuffle(){} // RVA: 0x7FFD5740F5D0
        public void play(){} // RVA: 0x7FFD5740F750
        public void findCurrent(){} // RVA: 0x7FFD5740FBE0
        public void reset(){} // RVA: 0x7FFD5740FC30
        public void Awake(){} // RVA: 0x7FFD5740FFA0
        public void Update(){} // RVA: 0x7FFD574100E0
        public void LateUpdate(){} // RVA: 0x7FFD57410190
        public void ProvideEvents(){} // RVA: 0x7FFD574101D0
        public void .ctor(){} // RVA: 0x7FFD57410A70
        public void <PlayNext>b__21_0(){} // RVA: 0x7FFD57410BC0
        public void <Shuffle>b__22_0(){} // RVA: 0x7FFD57410BC0
    }

    public class VRC_AvatarDescriptor : VRC_AvatarDescriptor
    {
        public ationSpeed CustomStandingAnims; // 0xB8
        public ationSpeed CustomSittingAnims; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57401C90
    }

    public class VRC_AvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574031F0
    }

    public class VRC_AvatarVariations : MonoBehaviour
    {
        public AudioData[] categories; // 0x20
        public bool initialized; // 0x28
        public string currentVariationSpec; // 0x30
        public URA.woDigitYearMax<terialIndex> initialMeshes; // 0x38
        public atrix_Injected[] initialMaterials; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57401CA0
        public void RecordInitialState(){} // RVA: 0x7FFD57401CD0
        public void SetVariationSpec(){} // RVA: 0x7FFD574020A0
        public void RevertVariations(){} // RVA: 0x7FFD57402120
        public void ApplyVariations(){} // RVA: 0x7FFD57402320
        public void ApplyVariation(){} // RVA: 0x7FFD57402590
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_CombatSystem : MonoBehaviour
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFD574026F0
        public void OnDestroy(){} // RVA: 0x7FFD57402730
        public void Awake(){} // RVA: 0x7FFD574027D0
        public void RespawnPlayer(){} // RVA: 0x7FFD57402960
        public void RespawnPlayerRPC(){} // RVA: 0x7FFD57402AD0
        public void .ctor(){} // RVA: 0x7FFD57402B70
    }

    public class VRC_CustomRendererBehaviour : MonoBehaviour
    {
        public bool Renderer; // 0x20
        public rical _renderer; // 0x28

        // ── Methods ──
        public void get_Renderer(){} // RVA: 0x7FFD57410BF0
        public void Update(){} // RVA: 0x7FFD57410D80
        public void .ctor(){} // RVA: 0x7FFD4E39B060
    }

    public class VRC_DataStorage : VRC_DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_DestructibleStandard : VRC_DestructibleStandard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57402BD0
    }

    public class VRC_EventDispatcher : VRC_EventDispatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_EventHandler : VRC_EventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57410EB0
    }

    public class VRC_GunStats : VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57403200
    }

    public class VRC_IKFollower : VRC_IKFollower
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Interactable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E788510
    }

    public class VRC_JukeBox : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57403260
        public void Update(){} // RVA: 0x7FFD57403300
        public void PlayNextSong(){} // RVA: 0x7FFD574035F0
        public void PlayPreviousSong(){} // RVA: 0x7FFD57403A10
        public void .ctor(){} // RVA: 0x7FFD57403C60
    }

    public class VRC_KeyEvents : VRC_KeyEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Label : VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57410EC0
    }

    public class VRC_MetadataListener : VRC_MetadataListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_MidiNoteIn : VRC_MidiNoteIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_MirrorReflection : VRC_MirrorReflection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740B740
    }

    public class VRC_NPCSpawn : VRC_NPCSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57403D60
    }

    public class VRC_NpcApi : VRC_NpcApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_ObjectApi : VRC_ObjectApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_ObjectSpawn : VRC_ObjectSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_ObjectSync : VRCNetworkBehaviour
    {
        public object useGravity;
        public enerVolume isKinematic; // 0x8
        public bool SynchronizePhysics; // 0x20
        public bool AllowCollisionTransfer; // 0x21
        public gnoreListenerPause TeleportHandler; // 0x10
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up> RespawnHandler; // 0x18
        public n<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up,bool> GetUseGravity; // 0x20
        public n<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up,bool> GetIsKinematic; // 0x28
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up,bool> SetUseGravity; // 0x30
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up,bool> SetIsKinematic; // 0x38
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up> DiscontinuityHandler; // 0x40

        // ── Methods ──
        public void get_useGravity(){} // RVA: 0x7FFD57403EA0
        public void set_useGravity(){} // RVA: 0x7FFD57403F10
        public void get_isKinematic(){} // RVA: 0x7FFD57403F80
        public void set_isKinematic(){} // RVA: 0x7FFD57403FF0
        public void TeleportTo(){} // RVA: 0x7FFD574041B0 | overloaded x2
        public void Respawn(){} // RVA: 0x7FFD57404250
        public void Awake(){} // RVA: 0x7FFD574042B0
        public void TakeOwnership(){} // RVA: 0x7FFD57404310
        public void FlagDiscontinuity(){} // RVA: 0x7FFD57404380
        public void ProvideEvents(){} // RVA: 0x7FFD574043E0
        public void .ctor(){} // RVA: 0x7FFD540B6450
    }

    public class VRC_OscButtonIn : VRC_OscButtonIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PhysicsRoot : VRC_PhysicsRoot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Pickup : VRC_Pickup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574054A0
    }

    public class VRC_PlayerAudioOverride : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57401960
        public void OnTriggerEnter(){} // RVA: 0x7FFD57401B70
        public void OnTriggerExit(){} // RVA: 0x7FFD57401B90
        public void .ctor(){} // RVA: 0x7FFD57401BB0
    }

    public class VRC_PlayerMods : MonoBehaviour
    {
        public bool isRoomPlayerMods; // 0x20
        public URA.woDigitYearMax<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.ffects> playerMods; // 0x28
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5740B790
        public void AddMod(){} // RVA: 0x7FFD5740B7F0
        public void RemoveMod(){} // RVA: 0x7FFD5740BA50
        public void ProvideEvents(){} // RVA: 0x7FFD5740BC30
        public void .ctor(){} // RVA: 0x7FFD5740C060
    }

    public class VRC_PortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PropApi : VRC_PropApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PropController : VRC_PropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574054B0
    }

    public class VRC_SceneDescriptor : VRC_SceneDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740C160
    }

    public class VRC_SceneResetPosition : MonoBehaviour
    {
        public object Position; // 0x20
        public bool RemoveVelocity; // 0x28
        public Touched rigidbody; // 0x30
        public ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.up sync; // 0x38
        public amut initialPosition; // 0x40
        public R_12x12 initialRotation; // 0x4C
        public amut initialScale; // 0x5C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5740C1B0
        public void ResetPosition(){} // RVA: 0x7FFD5740C4A0
        public void ResetPositionWithoutHint(){} // RVA: 0x7FFD5740D010
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
    }

    public class VRC_SceneSmoothShift : MonoBehaviour
    {
        public ÍÎÌÍÍÌÌÎÏÏ ShiftInterpolationCurve; // 0x20
        public float ShiftSpeed; // 0x28
        public object ShiftStart; // 0x30
        public object ShiftEnd; // 0x38
        public float TargetPosition; // 0x40
        public float ShiftPosition; // 0x44

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5740D8A0
        public void OnValidate(){} // RVA: 0x7FFD5740DA60
        public void Update(){} // RVA: 0x7FFD5740DA70
        public void Shift(){} // RVA: 0x7FFD5740E240
        public void .ctor(){} // RVA: 0x7FFD5740E270
    }

    public class VRC_SlideShow : VRC_SlideShow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574055B0
    }

    public class VRC_SpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57401C30
    }

    public class VRC_SpecialLayer : VRC_SpecialLayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Station : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E430
    }

    public class VRC_StationApi : MonoBehaviour
    {
        public t_diffusion IsStationOccupiedDelegate;
        public n GetStationOccupant; // 0x8

        // ── Methods ──
        public void IsStationOccupied(){} // RVA: 0x7FFD5740E490
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_StationInput : MonoBehaviour
    {
        public ellSize.artCorner controllingPlayer; // 0x20
        public tionX inputLeftAnalog; // 0x28
        public tionX inputRightAnalog; // 0x30
        public bool inputUseButton; // 0x38
        public object UpdateInputs;
        public liderExpand Initialize; // 0x8
        public URA.woDigitYearMax<s> customInputs; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57405600
        public void Update(){} // RVA: 0x7FFD57405660
        public void GetInputIndex(){} // RVA: 0x7FFD574056D0
        public void .ctor(){} // RVA: 0x7FFD574057D0
    }

    public class VRC_StereoObject : VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_SyncAnimation : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574058F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_SyncVideoPlayer : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Play(){} // RVA: 0x7FFD57405950
        public void PlayIndex(){} // RVA: 0x7FFD574059B0
        public void Stop(){} // RVA: 0x7FFD57405A20
        public void Pause(){} // RVA: 0x7FFD57405A80
        public void Next(){} // RVA: 0x7FFD57405AE0
        public void Previous(){} // RVA: 0x7FFD57405B40
        public void Shuffle(){} // RVA: 0x7FFD57405BA0
        public void Clear(){} // RVA: 0x7FFD57405C00
        public void AddURL(){} // RVA: 0x7FFD57405C60
        public void SpeedUp(){} // RVA: 0x7FFD57405CD0
        public void SpeedDown(){} // RVA: 0x7FFD57405D30
        public void SetMaxQuality(){} // RVA: 0x7FFD57405D90
        public void Awake(){} // RVA: 0x7FFD57405E00
        public void ProvideEvents(){} // RVA: 0x7FFD57405E60
        public void .ctor(){} // RVA: 0x7FFD57406EB0
    }

    public class VRC_SyncVideoStream : VRCNetworkBehaviour
    {
        public bool AllowNonOwnerControl; // 0x20
        public string VideoSearchRoot; // 0x28
        public int MaxStreamQuality; // 0x30
        public bool AutoStart; // 0x34
        public set_bypassEffects[] Videos; // 0x38
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Play;
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,int> _PlayIndex; // 0x8
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Stop; // 0x10
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Pause; // 0x18
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Next; // 0x20
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Previous; // 0x28
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Shuffle; // 0x30
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _Clear; // 0x38
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,string> _AddURL; // 0x40
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,float> _FastForwardSeconds; // 0x48
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,float> _RewindSeconds; // 0x50
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _LocalResync; // 0x58
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,tOutputData> _SetSyncType; // 0x60
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,float> _SetSyncMinutes; // 0x68
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> _ShowSearch; // 0x70
        public rectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects,float> _SetMaxQuality; // 0x78
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects> Initialize; // 0x80

        // ── Methods ──
        public void Play(){} // RVA: 0x7FFD574070D0
        public void PlayIndex(){} // RVA: 0x7FFD57407130
        public void Stop(){} // RVA: 0x7FFD574071A0
        public void Pause(){} // RVA: 0x7FFD57407200
        public void Next(){} // RVA: 0x7FFD57407260
        public void Previous(){} // RVA: 0x7FFD574072C0
        public void Shuffle(){} // RVA: 0x7FFD57407320
        public void Clear(){} // RVA: 0x7FFD57407380
        public void AddURL(){} // RVA: 0x7FFD574073E0
        public void FastForwardSeconds(){} // RVA: 0x7FFD57407450
        public void RewindSeconds(){} // RVA: 0x7FFD574074C0
        public void Resync(){} // RVA: 0x7FFD57407530
        public void SetSyncType(){} // RVA: 0x7FFD57407590
        public void SetSyncMinutes(){} // RVA: 0x7FFD57407600
        public void ShowSearch(){} // RVA: 0x7FFD57407670
        public void SetMaxQuality(){} // RVA: 0x7FFD574076D0
        public void Awake(){} // RVA: 0x7FFD57407740
        public void ProvideEvents(){} // RVA: 0x7FFD574077B0
        public void .ctor(){} // RVA: 0x7FFD57408F50
    }

    public class VRC_TimedEvents : VRC_TimedEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E4F0
    }

    public class VRC_Trigger : VRC_Trigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E550
    }

    public class VRC_TriggerColliderEventTrigger : VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E620
    }

    public class VRC_TutorialAction : VRC_TutorialAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_TutorialAreaMarker : VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E9E0
    }

    public class VRC_UiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3F5710
    }

    public class VRC_UseEvents : VRC_UseEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E670
    }

    public class VRC_VideoScreen : MonoBehaviour
    {
        public ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects Initialize; // 0x20
        public int _materialIndex; // 0x28
        public string _textureProperty; // 0x30
        public bool _useSharedMaterial; // 0x38
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.inVolume> <Initialize>k__BackingField;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFD57409180
        public void set_Initialize(){} // RVA: 0x7FFD574091C0
        public void Awake(){} // RVA: 0x7FFD57409260
        public void .ctor(){} // RVA: 0x7FFD574092C0
    }

    public class VRC_VideoSpeaker : MonoBehaviour
    {
        public ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ._bypassListenerEffects Initialize; // 0x20
        public alizerFloat _channelType; // 0x28
        public ileFullDirectoryInformation<ÎÌÎÍÎÍÏÌÌÎÌÍÌÏÌ.tor> <Initialize>k__BackingField;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFD57409390
        public void set_Initialize(){} // RVA: 0x7FFD574093D0
        public void Awake(){} // RVA: 0x7FFD57409470
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Water : VRC_Water
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E710
    }

    public class VRC_WebPanel : VRC_WebPanel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E8B0
    }

}