// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCSDK2
// Classes: 67
// Methods: 200

namespace VRCSDK2
{
    public class IPlayerModComponent
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFE80E460A0
    }

    public class IVRC_SerializableBehaviour
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFE80E2E2E0
        public void SetBytes(){} // RVA: 0x7FFE80E460A0
    }

    public class VRCDebugCommand : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A44F5B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCPlayerMod : Object
    {
        public string mName; // 0x10
        public System.Collections.Generic.List`1<VRCSDK2.VRCPlayerModProperty> mProperties; // 0x18
        public string mModComponentName; // 0x20
        public bool mAllowNameEdit; // 0x28

        // ── Methods ──
        public void set_name(){} // RVA: 0x7FFE8A44BD40
        public void get_name(){} // RVA: 0x7FFE81116380
        public void get_properties(){} // RVA: 0x7FFE810FE7C0
        public void get_modComponentName(){} // RVA: 0x7FFE811290C0
        public void get_allowNameEdit(){} // RVA: 0x7FFE815F1380
        public void .ctor(){} // RVA: 0x7FFE8A44BDA0
        public void AddOrUpdateModComponentOn(){} // RVA: 0x7FFE8A44BF30
        public void Equals(){} // RVA: 0x7FFE8A44C1F0
    }

    public class VRCPlayerModFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8A44A040
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VRCPlayerModProperty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44B650 | overloaded x9
        public void value(){} // RVA: 0x7FFE8A44B860
    }

    public class VRCSerializableSystemType : Object
    {
        public string m_Name; // 0x10
        public string m_AssemblyQualifiedName; // 0x18
        public string m_AssemblyName; // 0x20
        public System.Type m_SystemType; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFE810FE7C0
        public void get_AssemblyName(){} // RVA: 0x7FFE811290C0
        public void get_SystemType(){} // RVA: 0x7FFE8A44F610
        public void GetSystemType(){} // RVA: 0x7FFE8A44F720
        public void .ctor(){} // RVA: 0x7FFE8A44F7F0
        public void Equals(){} // RVA: 0x7FFE8A44FA90 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE8A44FAF0
        public void op_Inequality(){} // RVA: 0x7FFE8A44FB70
        public void GetHashCode(){} // RVA: 0x7FFE8A44FC00
    }

    public class VRCTriggerRelay : VRCTriggerRelay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44FC40
    }

    public class VRC_AddDamage : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4437A0
        public void ProvideEvents(){} // RVA: 0x7FFE8A443800
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class VRC_AddHealth : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A443A80
        public void ProvideEvents(){} // RVA: 0x7FFE8A443AE0
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class VRC_AudioBank : MonoBehaviour
    {
        public 0x666C140C PlaybackOrder; // 0x20
        public 0x666C1464 PlaybackStyle; // 0x24

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFE8A44FC50
        public void get_CurrentIdx(){} // RVA: 0x7FFE8A44FDB0
        public void Play(){} // RVA: 0x7FFE8A44FDE0
        public void Stop(){} // RVA: 0x7FFE8A44FE60
        public void PlayNext(){} // RVA: 0x7FFE8A44FF90
        public void Shuffle(){} // RVA: 0x7FFE8A450140
        public void play(){} // RVA: 0x7FFE8A4502C0
        public void findCurrent(){} // RVA: 0x7FFE8A450750
        public void reset(){} // RVA: 0x7FFE8A4507A0
        public void Awake(){} // RVA: 0x7FFE8A450B10
        public void Update(){} // RVA: 0x7FFE8A450C50
        public void LateUpdate(){} // RVA: 0x7FFE8A450D00
        public void ProvideEvents(){} // RVA: 0x7FFE8A450D40
        public void .ctor(){} // RVA: 0x7FFE8A4515E0
        public void <PlayNext>b__21_0(){} // RVA: 0x7FFE8A451730
        public void <Shuffle>b__22_0(){} // RVA: 0x7FFE8A451730
    }

    public class VRC_AvatarDescriptor : VRC_AvatarDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A442800
    }

    public class VRC_AvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A443D60
    }

    public class VRC_AvatarVariations : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A442810
        public void RecordInitialState(){} // RVA: 0x7FFE8A442840
        public void SetVariationSpec(){} // RVA: 0x7FFE8A442C10
        public void RevertVariations(){} // RVA: 0x7FFE8A442C90
        public void ApplyVariations(){} // RVA: 0x7FFE8A442E90
        public void ApplyVariation(){} // RVA: 0x7FFE8A443100
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_CombatSystem : MonoBehaviour
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A443260
        public void OnDestroy(){} // RVA: 0x7FFE8A4432A0
        public void Awake(){} // RVA: 0x7FFE8A443340
        public void RespawnPlayer(){} // RVA: 0x7FFE8A4434D0
        public void RespawnPlayerRPC(){} // RVA: 0x7FFE8A443640
        public void .ctor(){} // RVA: 0x7FFE8A4436E0
    }

    public class VRC_CustomRendererBehaviour : MonoBehaviour
    {
        public bool UpdateGIMaterialsEveryTick; // 0x20

        // ── Methods ──
        public void get_Renderer(){} // RVA: 0x7FFE8A451760
        public void Update(){} // RVA: 0x7FFE8A4518F0
        public void .ctor(){} // RVA: 0x7FFE81155060
    }

    public class VRC_DataStorage : VRC_DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_DestructibleStandard : VRC_DestructibleStandard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A443740
    }

    public class VRC_EventDispatcher : VRC_EventDispatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_EventHandler : VRC_EventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A451A20
    }

    public class VRC_GunStats : VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A443D70
    }

    public class VRC_IKFollower : VRC_IKFollower
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Interactable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BA3A0
    }

    public class VRC_JukeBox : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A443DD0
        public void Update(){} // RVA: 0x7FFE8A443E70
        public void PlayNextSong(){} // RVA: 0x7FFE8A444160
        public void PlayPreviousSong(){} // RVA: 0x7FFE8A444580
        public void .ctor(){} // RVA: 0x7FFE8A4447D0
    }

    public class VRC_KeyEvents : VRC_KeyEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Label : VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A451A30
    }

    public class VRC_MetadataListener : VRC_MetadataListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_MidiNoteIn : VRC_MidiNoteIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_MirrorReflection : VRC_MirrorReflection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44C2B0
    }

    public class VRC_NPCSpawn : VRC_NPCSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4448D0
    }

    public class VRC_NpcApi : VRC_NpcApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_ObjectApi : VRC_ObjectApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_ObjectSpawn : VRC_ObjectSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_ObjectSync : VRCNetworkBehaviour
    {
        public InitializationDelegate Initialize;
        public IsLocalDelegate IsLocal; // 0x8

        // ── Methods ──
        public void get_useGravity(){} // RVA: 0x7FFE8A444A10
        public void set_useGravity(){} // RVA: 0x7FFE8A444A80
        public void get_isKinematic(){} // RVA: 0x7FFE8A444AF0
        public void set_isKinematic(){} // RVA: 0x7FFE8A444B60
        public void TeleportTo(){} // RVA: 0x7FFE8A444D20 | overloaded x2
        public void Respawn(){} // RVA: 0x7FFE8A444DC0
        public void Awake(){} // RVA: 0x7FFE8A444E20
        public void TakeOwnership(){} // RVA: 0x7FFE8A444E80
        public void FlagDiscontinuity(){} // RVA: 0x7FFE8A444EF0
        public void ProvideEvents(){} // RVA: 0x7FFE8A444F50
        public void .ctor(){} // RVA: 0x7FFE8703E940
    }

    public class VRC_OscButtonIn : VRC_OscButtonIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_PhysicsRoot : VRC_PhysicsRoot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Pickup : VRC_Pickup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A446010
    }

    public class VRC_PlayerAudioOverride : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4424D0
        public void OnTriggerEnter(){} // RVA: 0x7FFE8A4426E0
        public void OnTriggerExit(){} // RVA: 0x7FFE8A442700
        public void .ctor(){} // RVA: 0x7FFE8A442720
    }

    public class VRC_PlayerMods : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A44C300
        public void AddMod(){} // RVA: 0x7FFE8A44C360
        public void RemoveMod(){} // RVA: 0x7FFE8A44C5C0
        public void ProvideEvents(){} // RVA: 0x7FFE8A44C7A0
        public void .ctor(){} // RVA: 0x7FFE8A44CBD0
    }

    public class VRC_PortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_PropApi : VRC_PropApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_PropController : VRC_PropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A446020
    }

    public class VRC_SceneDescriptor : VRC_SceneDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44CCD0
    }

    public class VRC_SceneResetPosition : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A44CD20
        public void ResetPosition(){} // RVA: 0x7FFE8A44D010
        public void ResetPositionWithoutHint(){} // RVA: 0x7FFE8A44DB80
        public void .ctor(){} // RVA: 0x7FFE81132BB0
    }

    public class VRC_SceneSmoothShift : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A44E410
        public void OnValidate(){} // RVA: 0x7FFE8A44E5D0
        public void Update(){} // RVA: 0x7FFE8A44E5E0
        public void Shift(){} // RVA: 0x7FFE8A44EDB0
        public void .ctor(){} // RVA: 0x7FFE8A44EDE0
    }

    public class VRC_SlideShow : VRC_SlideShow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A446120
    }

    public class VRC_SpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4427A0
    }

    public class VRC_SpecialLayer : VRC_SpecialLayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Station : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44EFA0
    }

    public class VRC_StationApi : MonoBehaviour
    {
        // ── Methods ──
        public void IsStationOccupied(){} // RVA: 0x7FFE8A44F000
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_StationInput : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A446170
        public void Update(){} // RVA: 0x7FFE8A4461D0
        public void GetInputIndex(){} // RVA: 0x7FFE8A446240
        public void .ctor(){} // RVA: 0x7FFE8A446340
    }

    public class VRC_StereoObject : VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_SyncAnimation : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A446460
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_SyncVideoPlayer : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Play(){} // RVA: 0x7FFE8A4464C0
        public void PlayIndex(){} // RVA: 0x7FFE8A446520
        public void Stop(){} // RVA: 0x7FFE8A446590
        public void Pause(){} // RVA: 0x7FFE8A4465F0
        public void Next(){} // RVA: 0x7FFE8A446650
        public void Previous(){} // RVA: 0x7FFE8A4466B0
        public void Shuffle(){} // RVA: 0x7FFE8A446710
        public void Clear(){} // RVA: 0x7FFE8A446770
        public void AddURL(){} // RVA: 0x7FFE8A4467D0
        public void SpeedUp(){} // RVA: 0x7FFE8A446840
        public void SpeedDown(){} // RVA: 0x7FFE8A4468A0
        public void SetMaxQuality(){} // RVA: 0x7FFE8A446900
        public void Awake(){} // RVA: 0x7FFE8A446970
        public void ProvideEvents(){} // RVA: 0x7FFE8A4469D0
        public void .ctor(){} // RVA: 0x7FFE8A447A20
    }

    public class VRC_SyncVideoStream : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Play(){} // RVA: 0x7FFE8A447C40
        public void PlayIndex(){} // RVA: 0x7FFE8A447CA0
        public void Stop(){} // RVA: 0x7FFE8A447D10
        public void Pause(){} // RVA: 0x7FFE8A447D70
        public void Next(){} // RVA: 0x7FFE8A447DD0
        public void Previous(){} // RVA: 0x7FFE8A447E30
        public void Shuffle(){} // RVA: 0x7FFE8A447E90
        public void Clear(){} // RVA: 0x7FFE8A447EF0
        public void AddURL(){} // RVA: 0x7FFE8A447F50
        public void FastForwardSeconds(){} // RVA: 0x7FFE8A447FC0
        public void RewindSeconds(){} // RVA: 0x7FFE8A448030
        public void Resync(){} // RVA: 0x7FFE8A4480A0
        public void SetSyncType(){} // RVA: 0x7FFE8A448100
        public void SetSyncMinutes(){} // RVA: 0x7FFE8A448170
        public void ShowSearch(){} // RVA: 0x7FFE8A4481E0
        public void SetMaxQuality(){} // RVA: 0x7FFE8A448240
        public void Awake(){} // RVA: 0x7FFE8A4482B0
        public void ProvideEvents(){} // RVA: 0x7FFE8A448320
        public void .ctor(){} // RVA: 0x7FFE8A449AC0
    }

    public class VRC_TimedEvents : VRC_TimedEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F060
    }

    public class VRC_Trigger : VRC_Trigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F0C0
    }

    public class VRC_TriggerColliderEventTrigger : VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F190
    }

    public class VRC_TutorialAction : VRC_TutorialAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_TutorialAreaMarker : VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F550
    }

    public class VRC_UiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811AF710
    }

    public class VRC_UseEvents : VRC_UseEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F1E0
    }

    public class VRC_VideoScreen : MonoBehaviour
    {
        public VRCSDK2.VRC_SyncVideoStream _videoStream; // 0x20

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFE8A449CF0
        public void set_Initialize(){} // RVA: 0x7FFE8A449D30
        public void Awake(){} // RVA: 0x7FFE8A449DD0
        public void .ctor(){} // RVA: 0x7FFE8A449E30
    }

    public class VRC_VideoSpeaker : MonoBehaviour
    {
        public VRCSDK2.VRC_SyncVideoStream _videoStream; // 0x20

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFE8A449F00
        public void set_Initialize(){} // RVA: 0x7FFE8A449F40
        public void Awake(){} // RVA: 0x7FFE8A449FE0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Water : VRC_Water
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F280
    }

    public class VRC_WebPanel : VRC_WebPanel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44F420
    }

}