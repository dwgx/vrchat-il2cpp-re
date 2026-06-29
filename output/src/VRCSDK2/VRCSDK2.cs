// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCSDK2
// Classes: 68
// Methods: 205

namespace VRCSDK2
{
    public class IPlayerModComponent
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x894320
    }

    public class IVRC_SerializableBehaviour
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x87C0A0
        public void SetBytes(){} // RVA: 0x894320
    }

    public class VRCDebugCommand : MonoBehaviour
    {
        public object Command;
        public object ParamInt;
        public object ParamFloat;
        public object ParamString;
        public object ParamObject;
        public object OnAwake;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA69D8A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCPlayerMod : Object
    {
        public object mName;
        public object mProperties;
        public object mModComponentName;
        public object mAllowNameEdit;

        // ── Methods ──
        public void set_name(){} // RVA: 0xA699D40
        public void get_name(){} // RVA: 0xB5DBF0
        public void get_properties(){} // RVA: 0xB465B0
        public void get_modComponentName(){} // RVA: 0xB700F0
        public void get_allowNameEdit(){} // RVA: 0xF73960
        public void .ctor(){} // RVA: 0xA699DA0
        public void AddOrUpdateModComponentOn(){} // RVA: 0xA699F40
        public void Equals(){} // RVA: 0xA69A1C0
    }

    public class VRCPlayerModFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xA698350
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VRCPlayerModProperty : Object
    {
        public object name;
        public object intValue;
        public object floatValue;
        public object stringValue;
        public object boolValue;
        public object gameObjectValue;
        public object keyCodeValue;
        public object animationController;
        public object broadcastValue;
        public object onDeathActionValue;
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA699700
        public void value(){} // RVA: 0xA6998E0
    }

    public class VRCPlayerMod[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VRCSerializableSystemType : Object
    {
        public object m_Name;
        public object m_AssemblyQualifiedName;
        public object m_AssemblyName;
        public object m_SystemType;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_AssemblyQualifiedName(){} // RVA: 0xB465B0
        public void get_AssemblyName(){} // RVA: 0xB700F0
        public void get_SystemType(){} // RVA: 0xA69D900
        public void GetSystemType(){} // RVA: 0xA69D9E0
        public void .ctor(){} // RVA: 0xA69DAA0
        public void Equals(){} // RVA: 0xA69DD30
        public void op_Equality(){} // RVA: 0xA69DD90
        public void op_Inequality(){} // RVA: 0xA69DE10
        public void GetHashCode(){} // RVA: 0xA69DEA0
    }

    public class VRCTriggerRelay : VRCTriggerRelay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69DEE0
    }

    public class VRC_AddDamage : MonoBehaviour
    {
        public object damageAmount;
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA692500
        public void ProvideEvents(){} // RVA: 0xA692560
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class VRC_AddHealth : MonoBehaviour
    {
        public object healthAmount;
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA6927B0
        public void ProvideEvents(){} // RVA: 0xA692810
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class VRC_AudioBank : MonoBehaviour
    {
        public object PlaybackOrder;
        public object PlaybackStyle;
        public object Source;
        public object MinPitchRange;
        public object MaxPitchRange;
        public object OnPlay;
        public object OnStop;
        public object OnChange;
        public object Clips;
        public object playOrder;
        public object current;
        public object remainingTime;
        public object rng;

        // ── Methods ──
        public void get_Current(){} // RVA: 0xA69DEF0
        public void get_CurrentIdx(){} // RVA: 0xA69E050
        public void Play(){} // RVA: 0xA69E080
        public void Stop(){} // RVA: 0xA69E100
        public void PlayNext(){} // RVA: 0xA69E200
        public void Shuffle(){} // RVA: 0xA69E3B0
        public void play(){} // RVA: 0xA69E530
        public void findCurrent(){} // RVA: 0xA69E980
        public void reset(){} // RVA: 0xA69E9D0
        public void Awake(){} // RVA: 0xA69ED60
        public void Update(){} // RVA: 0xA69EEA0
        public void LateUpdate(){} // RVA: 0xA69EF50
        public void ProvideEvents(){} // RVA: 0xA69EF90
        public void .ctor(){} // RVA: 0xA69F740
        public void <PlayNext>b__21_0(){} // RVA: 0xA69F890
        public void <Shuffle>b__22_0(){} // RVA: 0xA69F890
    }

    public class VRC_AvatarDescriptor : VRC_AvatarDescriptor
    {
        public object CustomStandingAnims;
        public object CustomSittingAnims;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6914B0
    }

    public class VRC_AvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA692A60
    }

    public class VRC_AvatarVariations : MonoBehaviour
    {
        public object categories;
        public object initialized;
        public object currentVariationSpec;
        public object initialMeshes;
        public object initialMaterials;

        // ── Methods ──
        public void Start(){} // RVA: 0xA6914C0
        public void RecordInitialState(){} // RVA: 0xA6914F0
        public void SetVariationSpec(){} // RVA: 0xA691940
        public void RevertVariations(){} // RVA: 0xA6919C0
        public void ApplyVariations(){} // RVA: 0xA691BB0
        public void ApplyVariation(){} // RVA: 0xA691E50
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_CombatSystem : MonoBehaviour
    {
        public object instance;
        public object maxPlayerHealth;
        public object respawnOnDeath;
        public object respawnPoint;
        public object respawnTime;
        public object resetHealthOnRespawn;
        public object visualDamagePrefab;
        public object onPlayerKilledTrigger;
        public object onPlayerHealedTrigger;
        public object onPlayerDamagedTrigger;
        public object onPlayerKilled;
        public object onPlayerHealed;
        public object onPlayerDamaged;
        public object onSetupPlayer;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA691FC0
        public void OnDestroy(){} // RVA: 0xA692000
        public void Awake(){} // RVA: 0xA6920A0
        public void RespawnPlayer(){} // RVA: 0xA692230
        public void RespawnPlayerRPC(){} // RVA: 0xA6923A0
        public void .ctor(){} // RVA: 0xA692440
    }

    public class VRC_CustomRendererBehaviour : MonoBehaviour
    {
        public object UpdateGIMaterialsEveryTick;
        public object _renderer;

        // ── Methods ──
        public void get_Renderer(){} // RVA: 0xA69F8C0
        public void Update(){} // RVA: 0xA69FA20
        public void .ctor(){} // RVA: 0xB9C2F0
    }

    public class VRC_DataStorage : VRC_DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_DestructibleStandard : VRC_DestructibleStandard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6924A0
    }

    public class VRC_EventDispatcher : VRC_EventDispatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_EventHandler : VRC_EventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69FB10
    }

    public class VRC_GunStats : VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA692A70
    }

    public class VRC_IKFollower : VRC_IKFollower
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Interactable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1011E10
    }

    public class VRC_JukeBox : MonoBehaviour
    {
        public object AutoPlay;
        public object Shuffle;
        public object Songs;
        public object PlayingSong;
        public object SongLog;
        public object Speakers;

        // ── Methods ──
        public void Start(){} // RVA: 0xA692AD0
        public void Update(){} // RVA: 0xA692B70
        public void PlayNextSong(){} // RVA: 0xA692D50
        public void PlayPreviousSong(){} // RVA: 0xA6930B0
        public void .ctor(){} // RVA: 0xA693260
    }

    public class VRC_KeyEvents : VRC_KeyEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Label : VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69FB20
    }

    public class VRC_MetadataListener : VRC_MetadataListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_MidiNoteIn : VRC_MidiNoteIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_MirrorReflection : VRC_MirrorReflection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69A280
    }

    public class VRC_NPCSpawn : VRC_NPCSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA693360
    }

    public class VRC_NpcApi : VRC_NpcApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_ObjectApi : VRC_ObjectApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_ObjectSpawn : VRC_ObjectSpawn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_ObjectSync : VRCNetworkBehaviour
    {
        public object Initialize;
        public object IsLocal;
        public object SynchronizePhysics;
        public object AllowCollisionTransfer;
        public object TeleportHandler;
        public object RespawnHandler;
        public object GetUseGravity;
        public object GetIsKinematic;
        public object SetUseGravity;
        public object SetIsKinematic;
        public object DiscontinuityHandler;

        // ── Methods ──
        public void get_useGravity(){} // RVA: 0xA6934A0
        public void set_useGravity(){} // RVA: 0xA693510
        public void get_isKinematic(){} // RVA: 0xA693580
        public void set_isKinematic(){} // RVA: 0xA6935F0
        public void TeleportTo(){} // RVA: 0xA693830
        public void Respawn(){} // RVA: 0xA6938D0
        public void Awake(){} // RVA: 0xA693930
        public void TakeOwnership(){} // RVA: 0xA693990
        public void FlagDiscontinuity(){} // RVA: 0xA6939C0
        public void ProvideEvents(){} // RVA: 0xA693A20
        public void .ctor(){} // RVA: 0x6F6C020
    }

    public class VRC_OscButtonIn : VRC_OscButtonIn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_PhysicsRoot : VRC_PhysicsRoot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Pickup : VRC_Pickup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6948D0
    }

    public class VRC_PlayerAudioOverride : MonoBehaviour
    {
        public object VoiceGain;
        public object VoiceFar;
        public object VoiceNear;
        public object VoiceVolumetricRadius;
        public object VoiceDisableLowpass;
        public object AvatarGainLimit;
        public object AvatarFarLimit;
        public object AvatarNearLimit;
        public object AvatarVolumetricRadiusLimit;
        public object AvatarForceSpatial;
        public object AvatarAllowCustomCurve;
        public object global;
        public object region;
        public object regionPriority;
        public object Initialize;
        public object onRegionEnter;
        public object onRegionExit;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA6911F0
        public void OnTriggerEnter(){} // RVA: 0xA691390
        public void OnTriggerExit(){} // RVA: 0xA6913B0
        public void .ctor(){} // RVA: 0xA6913D0
    }

    public class VRC_PlayerMods : MonoBehaviour
    {
        public object isRoomPlayerMods;
        public object playerMods;
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA69A2D0
        public void AddMod(){} // RVA: 0xA69A330
        public void RemoveMod(){} // RVA: 0xA69A5A0
        public void ProvideEvents(){} // RVA: 0xA69A790
        public void .ctor(){} // RVA: 0xA69AB60
    }

    public class VRC_PortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_PropApi : VRC_PropApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_PropController : VRC_PropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6948E0
    }

    public class VRC_SceneDescriptor : VRC_SceneDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69AC60
    }

    public class VRC_SceneResetPosition : MonoBehaviour
    {
        public object Position;
        public object RemoveVelocity;
        public object rigidbody;
        public object sync;
        public object initialPosition;
        public object initialRotation;
        public object initialScale;

        // ── Methods ──
        public void Start(){} // RVA: 0xA69ACB0
        public void ResetPosition(){} // RVA: 0xA69AFA0
        public void ResetPositionWithoutHint(){} // RVA: 0xA69BC00
        public void .ctor(){} // RVA: 0xB79A60
    }

    public class VRC_SceneSmoothShift : MonoBehaviour
    {
        public object ShiftInterpolationCurve;
        public object ShiftSpeed;
        public object ShiftStart;
        public object ShiftEnd;
        public object TargetPosition;
        public object ShiftPosition;

        // ── Methods ──
        public void Start(){} // RVA: 0xA69C5C0
        public void OnValidate(){} // RVA: 0xA69C740
        public void Update(){} // RVA: 0xA69C750
        public void Shift(){} // RVA: 0xA69D0E0
        public void .ctor(){} // RVA: 0xA69D110
    }

    public class VRC_SlideShow : VRC_SlideShow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6949E0
    }

    public class VRC_SpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA691450
    }

    public class VRC_SpecialLayer : VRC_SpecialLayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Station : VRCStation
    {
        public object OnRemotePlayerEnterStation;
        public object OnLocalPlayerEnterStation;
        public object OnRemotePlayerExitStation;
        public object OnLocalPlayerExitStation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D290
    }

    public class VRC_StationApi : MonoBehaviour
    {
        public object IsStationOccupiedDelegate;
        public object GetStationOccupant;

        // ── Methods ──
        public void IsStationOccupied(){} // RVA: 0xA69D2F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_StationInput : MonoBehaviour
    {
        public object controllingPlayer;
        public object inputLeftAnalog;
        public object inputRightAnalog;
        public object inputUseButton;
        public object UpdateInputs;
        public object Initialize;
        public object customInputs;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA694A30
        public void Update(){} // RVA: 0xA694A90
        public void GetInputIndex(){} // RVA: 0xA694B00
        public void .ctor(){} // RVA: 0xA694C20
    }

    public class VRC_StereoObject : VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_SyncAnimation : VRCNetworkBehaviour
    {
        public object AnimationStartPosition;
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA694D40
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_SyncVideoPlayer : VRCNetworkBehaviour
    {
        public object AllowNonOwnerControl;
        public object VideoSearchRoot;
        public object MaxStreamQuality;
        public object Videos;
        public object _Play;
        public object _PlayIndex;
        public object _Stop;
        public object _Pause;
        public object _Next;
        public object _Previous;
        public object _Shuffle;
        public object _Clear;
        public object _AddURL;
        public object _SpeedUp;
        public object _SpeedDown;
        public object _SetMaxQuality;
        public object Initialize;

        // ── Methods ──
        public void Play(){} // RVA: 0xA694DA0
        public void PlayIndex(){} // RVA: 0xA694E00
        public void Stop(){} // RVA: 0xA694E70
        public void Pause(){} // RVA: 0xA694ED0
        public void Next(){} // RVA: 0xA694F30
        public void Previous(){} // RVA: 0xA694F90
        public void Shuffle(){} // RVA: 0xA694FF0
        public void Clear(){} // RVA: 0xA695050
        public void AddURL(){} // RVA: 0xA6950B0
        public void SpeedUp(){} // RVA: 0xA695120
        public void SpeedDown(){} // RVA: 0xA695180
        public void SetMaxQuality(){} // RVA: 0xA6951E0
        public void Awake(){} // RVA: 0xA695250
        public void ProvideEvents(){} // RVA: 0xA6952B0
        public void .ctor(){} // RVA: 0xA6960A0
    }

    public class VRC_SyncVideoStream : VRCNetworkBehaviour
    {
        public object AllowNonOwnerControl;
        public object VideoSearchRoot;
        public object MaxStreamQuality;
        public object AutoStart;
        public object Videos;
        public object _Play;
        public object _PlayIndex;
        public object _Stop;
        public object _Pause;
        public object _Next;
        public object _Previous;
        public object _Shuffle;
        public object _Clear;
        public object _AddURL;
        public object _FastForwardSeconds;
        public object _RewindSeconds;
        public object _LocalResync;
        public object _SetSyncType;
        public object _SetSyncMinutes;
        public object _ShowSearch;
        public object _SetMaxQuality;
        public object Initialize;

        // ── Methods ──
        public void Play(){} // RVA: 0xA6962C0
        public void PlayIndex(){} // RVA: 0xA696320
        public void Stop(){} // RVA: 0xA696390
        public void Pause(){} // RVA: 0xA6963F0
        public void Next(){} // RVA: 0xA696450
        public void Previous(){} // RVA: 0xA6964B0
        public void Shuffle(){} // RVA: 0xA696510
        public void Clear(){} // RVA: 0xA696570
        public void AddURL(){} // RVA: 0xA6965D0
        public void FastForwardSeconds(){} // RVA: 0xA696640
        public void RewindSeconds(){} // RVA: 0xA6966B0
        public void Resync(){} // RVA: 0xA696720
        public void SetSyncType(){} // RVA: 0xA696780
        public void SetSyncMinutes(){} // RVA: 0xA6967F0
        public void ShowSearch(){} // RVA: 0xA696860
        public void SetMaxQuality(){} // RVA: 0xA6968C0
        public void Awake(){} // RVA: 0xA696930
        public void ProvideEvents(){} // RVA: 0xA6969A0
        public void .ctor(){} // RVA: 0xA697DD0
    }

    public class VRC_TimedEvents : VRC_TimedEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D350
    }

    public class VRC_Trigger : VRC_Trigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D3B0
    }

    public class VRC_TriggerColliderEventTrigger : VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D480
    }

    public class VRC_TutorialAction : VRC_TutorialAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_TutorialAreaMarker : VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D840
    }

    public class VRC_UiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBF9D60
    }

    public class VRC_UseEvents : VRC_UseEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D4D0
    }

    public class VRC_VideoScreen : MonoBehaviour
    {
        public object _videoStream;
        public object _materialIndex;
        public object _textureProperty;
        public object _useSharedMaterial;
        public object _initialize;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0xA698000
        public void set_Initialize(){} // RVA: 0xA698040
        public void Awake(){} // RVA: 0xA6980E0
        public void .ctor(){} // RVA: 0xA698140
    }

    public class VRC_VideoSpeaker : MonoBehaviour
    {
        public object _videoStream;
        public object _channelType;
        public object _initialize;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0xA698210
        public void set_Initialize(){} // RVA: 0xA698250
        public void Awake(){} // RVA: 0xA6982F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Water : VRC_Water
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D570
    }

    public class VRC_WebPanel : VRC_WebPanel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D710
    }

}