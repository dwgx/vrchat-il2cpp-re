// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCSDK2
// Classes: 67
// Methods: 200

namespace VRCSDK2
{
    public class IPlayerModComponent
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x24B10
    }

    public class IVRC_SerializableBehaviour
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0xCD60
        public void SetBytes(){} // RVA: 0x24B10
    }

    public class VRCDebugCommand
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99F3B80
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCPlayerMod
    {
        public string mName; // 0x10
        public System.Collections.Generic.List`1<VRCSDK2.VRCPlayerModProperty> mProperties; // 0x18
        public string mModComponentName; // 0x20
        public bool mAllowNameEdit; // 0x28

        // ── Methods ──
        public void set_name(){} // RVA: 0x99F0310
        public void get_name(){} // RVA: 0x2F8380
        public void get_properties(){} // RVA: 0x2E07C0
        public void get_modComponentName(){} // RVA: 0x30B0C0
        public void get_allowNameEdit(){} // RVA: 0x6E8A80
        public void .ctor(){} // RVA: 0x99F0370
        public void AddOrUpdateModComponentOn(){} // RVA: 0x99F0500
        public void Equals(){} // RVA: 0x99F07C0
    }

    public class VRCPlayerModFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x99EE610
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class VRCPlayerModProperty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99EFC20 | overloaded x9
        public void value(){} // RVA: 0x99EFE30
    }

    public class VRCSerializableSystemType
    {
        public string m_Name; // 0x10
        public string m_AssemblyQualifiedName; // 0x18
        public string m_AssemblyName; // 0x20
        public System.Type m_SystemType; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_AssemblyQualifiedName(){} // RVA: 0x2E07C0
        public void get_AssemblyName(){} // RVA: 0x30B0C0
        public void get_SystemType(){} // RVA: 0x99F3BE0
        public void GetSystemType(){} // RVA: 0x99F3CF0
        public void .ctor(){} // RVA: 0x99F3DC0
        public void Equals(){} // RVA: 0x99F4060 | overloaded x2
        public void op_Equality(){} // RVA: 0x99F40C0
        public void op_Inequality(){} // RVA: 0x99F4140
        public void GetHashCode(){} // RVA: 0x99F41D0
    }

    public class VRCTriggerRelay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F4210
    }

    public class VRC_AddDamage
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99E7D70
        public void ProvideEvents(){} // RVA: 0x99E7DD0
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class VRC_AddHealth
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99E8050
        public void ProvideEvents(){} // RVA: 0x99E80B0
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class VRC_AudioBank
    {
        public 0x659E9978 PlaybackOrder; // 0x20
        public 0x659E99D0 PlaybackStyle; // 0x24

        // ── Methods ──
        public void get_Current(){} // RVA: 0x99F4220
        public void get_CurrentIdx(){} // RVA: 0x99F4380
        public void Play(){} // RVA: 0x99F43B0
        public void Stop(){} // RVA: 0x99F4430
        public void PlayNext(){} // RVA: 0x99F4560
        public void Shuffle(){} // RVA: 0x99F4710
        public void play(){} // RVA: 0x99F4890
        public void findCurrent(){} // RVA: 0x99F4D20
        public void reset(){} // RVA: 0x99F4D70
        public void Awake(){} // RVA: 0x99F50E0
        public void Update(){} // RVA: 0x99F5220
        public void LateUpdate(){} // RVA: 0x99F52D0
        public void ProvideEvents(){} // RVA: 0x99F5310
        public void .ctor(){} // RVA: 0x99F5BB0
        public void <PlayNext>b__21_0(){} // RVA: 0x99F5D00
        public void <Shuffle>b__22_0(){} // RVA: 0x99F5D00
    }

    public class VRC_AvatarDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E6DD0
    }

    public class VRC_AvatarPedestal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E8330
    }

    public class VRC_AvatarVariations
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x99E6DE0
        public void RecordInitialState(){} // RVA: 0x99E6E10
        public void SetVariationSpec(){} // RVA: 0x99E71E0
        public void RevertVariations(){} // RVA: 0x99E7260
        public void ApplyVariations(){} // RVA: 0x99E7460
        public void ApplyVariation(){} // RVA: 0x99E76D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_CombatSystem
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x99E7830
        public void OnDestroy(){} // RVA: 0x99E7870
        public void Awake(){} // RVA: 0x99E7910
        public void RespawnPlayer(){} // RVA: 0x99E7AA0
        public void RespawnPlayerRPC(){} // RVA: 0x99E7C10
        public void .ctor(){} // RVA: 0x99E7CB0
    }

    public class VRC_CustomRendererBehaviour
    {
        public bool UpdateGIMaterialsEveryTick; // 0x20

        // ── Methods ──
        public void get_Renderer(){} // RVA: 0x99F5D30
        public void Update(){} // RVA: 0x99F5EC0
        public void .ctor(){} // RVA: 0x337060
    }

    public class VRC_DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_DestructibleStandard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E7D10
    }

    public class VRC_EventDispatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_EventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F5FF0
    }

    public class VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E8340
    }

    public class VRC_IKFollower
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x82DF40
    }

    public class VRC_JukeBox
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x99E83A0
        public void Update(){} // RVA: 0x99E8440
        public void PlayNextSong(){} // RVA: 0x99E8730
        public void PlayPreviousSong(){} // RVA: 0x99E8B50
        public void .ctor(){} // RVA: 0x99E8DA0
    }

    public class VRC_KeyEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F6000
    }

    public class VRC_MetadataListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_MidiNoteIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_MirrorReflection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F0880
    }

    public class VRC_NPCSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E8EA0
    }

    public class VRC_NpcApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_ObjectApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_ObjectSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_ObjectSync
    {
        public InitializationDelegate Initialize;
        public IsLocalDelegate IsLocal; // 0x8

        // ── Methods ──
        public void get_useGravity(){} // RVA: 0x99E8FE0
        public void set_useGravity(){} // RVA: 0x99E9050
        public void get_isKinematic(){} // RVA: 0x99E90C0
        public void set_isKinematic(){} // RVA: 0x99E9130
        public void TeleportTo(){} // RVA: 0x99E92F0 | overloaded x2
        public void Respawn(){} // RVA: 0x99E9390
        public void Awake(){} // RVA: 0x99E93F0
        public void TakeOwnership(){} // RVA: 0x99E9450
        public void FlagDiscontinuity(){} // RVA: 0x99E94C0
        public void ProvideEvents(){} // RVA: 0x99E9520
        public void .ctor(){} // RVA: 0x64FF8C0
    }

    public class VRC_OscButtonIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_PhysicsRoot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Pickup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99EA5E0
    }

    public class VRC_PlayerAudioOverride
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99E6AA0
        public void OnTriggerEnter(){} // RVA: 0x99E6CB0
        public void OnTriggerExit(){} // RVA: 0x99E6CD0
        public void .ctor(){} // RVA: 0x99E6CF0
    }

    public class VRC_PlayerMods
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99F08D0
        public void AddMod(){} // RVA: 0x99F0930
        public void RemoveMod(){} // RVA: 0x99F0B90
        public void ProvideEvents(){} // RVA: 0x99F0D70
        public void .ctor(){} // RVA: 0x99F11A0
    }

    public class VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_PropApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_PropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99EA5F0
    }

    public class VRC_SceneDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F12A0
    }

    public class VRC_SceneResetPosition
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x99F12F0
        public void ResetPosition(){} // RVA: 0x99F15E0
        public void ResetPositionWithoutHint(){} // RVA: 0x99F2150
        public void .ctor(){} // RVA: 0x314BB0
    }

    public class VRC_SceneSmoothShift
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x99F29E0
        public void OnValidate(){} // RVA: 0x99F2BA0
        public void Update(){} // RVA: 0x99F2BB0
        public void Shift(){} // RVA: 0x99F3380
        public void .ctor(){} // RVA: 0x99F33B0
    }

    public class VRC_SlideShow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99EA6F0
    }

    public class VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E6D70
    }

    public class VRC_SpecialLayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Station
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3570
    }

    public class VRC_StationApi
    {
        // ── Methods ──
        public void IsStationOccupied(){} // RVA: 0x99F35D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_StationInput
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99EA740
        public void Update(){} // RVA: 0x99EA7A0
        public void GetInputIndex(){} // RVA: 0x99EA810
        public void .ctor(){} // RVA: 0x99EA910
    }

    public class VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_SyncAnimation
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x99EAA30
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_SyncVideoPlayer
    {
        // ── Methods ──
        public void Play(){} // RVA: 0x99EAA90
        public void PlayIndex(){} // RVA: 0x99EAAF0
        public void Stop(){} // RVA: 0x99EAB60
        public void Pause(){} // RVA: 0x99EABC0
        public void Next(){} // RVA: 0x99EAC20
        public void Previous(){} // RVA: 0x99EAC80
        public void Shuffle(){} // RVA: 0x99EACE0
        public void Clear(){} // RVA: 0x99EAD40
        public void AddURL(){} // RVA: 0x99EADA0
        public void SpeedUp(){} // RVA: 0x99EAE10
        public void SpeedDown(){} // RVA: 0x99EAE70
        public void SetMaxQuality(){} // RVA: 0x99EAED0
        public void Awake(){} // RVA: 0x99EAF40
        public void ProvideEvents(){} // RVA: 0x99EAFA0
        public void .ctor(){} // RVA: 0x99EBFF0
    }

    public class VRC_SyncVideoStream
    {
        // ── Methods ──
        public void Play(){} // RVA: 0x99EC210
        public void PlayIndex(){} // RVA: 0x99EC270
        public void Stop(){} // RVA: 0x99EC2E0
        public void Pause(){} // RVA: 0x99EC340
        public void Next(){} // RVA: 0x99EC3A0
        public void Previous(){} // RVA: 0x99EC400
        public void Shuffle(){} // RVA: 0x99EC460
        public void Clear(){} // RVA: 0x99EC4C0
        public void AddURL(){} // RVA: 0x99EC520
        public void FastForwardSeconds(){} // RVA: 0x99EC590
        public void RewindSeconds(){} // RVA: 0x99EC600
        public void Resync(){} // RVA: 0x99EC670
        public void SetSyncType(){} // RVA: 0x99EC6D0
        public void SetSyncMinutes(){} // RVA: 0x99EC740
        public void ShowSearch(){} // RVA: 0x99EC7B0
        public void SetMaxQuality(){} // RVA: 0x99EC810
        public void Awake(){} // RVA: 0x99EC880
        public void ProvideEvents(){} // RVA: 0x99EC8F0
        public void .ctor(){} // RVA: 0x99EE090
    }

    public class VRC_TimedEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3630
    }

    public class VRC_Trigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3690
    }

    public class VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3760
    }

    public class VRC_TutorialAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3B20
    }

    public class VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x391710
    }

    public class VRC_UseEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F37B0
    }

    public class VRC_VideoScreen
    {
        public VRCSDK2.VRC_SyncVideoStream _videoStream; // 0x20

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x99EE2C0
        public void set_Initialize(){} // RVA: 0x99EE300
        public void Awake(){} // RVA: 0x99EE3A0
        public void .ctor(){} // RVA: 0x99EE400
    }

    public class VRC_VideoSpeaker
    {
        public VRCSDK2.VRC_SyncVideoStream _videoStream; // 0x20

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x99EE4D0
        public void set_Initialize(){} // RVA: 0x99EE510
        public void Awake(){} // RVA: 0x99EE5B0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Water
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3850
    }

    public class VRC_WebPanel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F39F0
    }

}