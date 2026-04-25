// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 69
// Methods: 601

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        public object boolVal;
        public object intVal;
        public object floatVal;

        // ── Methods ──
        public void get_boolVal(){} // RVA: 0x7FFD4E079D00
        public void set_boolVal(){} // RVA: 0x7FFD4E091060
        public void get_intVal(){} // RVA: 0x7FFD4E079960
        public void set_intVal(){} // RVA: 0x7FFD4E090ED0
        public void get_floatVal(){} // RVA: 0x7FFD4E08D880
        public void set_floatVal(){} // RVA: 0x7FFD4E09E480
    }

    public class INetworkID
    {
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0x7FFD4E078E90
    }

    public class IVRCEventReceiver
    {
    }

    public class IVRCEventSender
    {
    }

    public class IVRC_Destructible
    {
        // ── Methods ──
        public void GetState(){} // RVA: 0x7FFD4E078E90
        public void SetState(){} // RVA: 0x7FFD4E090A40
        public void GetMaxHealth(){} // RVA: 0x7FFD4E08D880
        public void GetCurrentHealth(){} // RVA: 0x7FFD4E08D880
        public void ApplyDamage(){} // RVA: 0x7FFD4E09E480
        public void ApplyHealing(){} // RVA: 0x7FFD4E09E480
    }

    public class InputManager : Object
    {
        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0x7FFD57497B00
        public void GetLastUsedInputMethod(){} // RVA: 0x7FFD57497B60
        public void GetBoolInputSetting(){} // RVA: 0x7FFD57497BD0
        public void SetBoolInputSetting(){} // RVA: 0x7FFD57497C30
        public void EnableObjectHighlight(){} // RVA: 0x7FFD57497DA0 | overloaded x2
    }

    public class Networking : Object
    {
        public object SceneEventHandler;
        public object IsNetworkSettled;
        public object IsMaster;
        public object IsClogged;
        public object IsInstanceOwner;
        public object LocalPlayer;
        public object Master;
        public object InstanceOwner;

        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x7FFD57473220
        public void get_IsNetworkSettled(){} // RVA: 0x7FFD57473280
        public void get_IsMaster(){} // RVA: 0x7FFD574732E0
        public void get_IsClogged(){} // RVA: 0x7FFD57473340
        public void get_IsInstanceOwner(){} // RVA: 0x7FFD574733A0
        public void get_LocalPlayer(){} // RVA: 0x7FFD57473400
        public void get_Master(){} // RVA: 0x7FFD57473460
        public void get_InstanceOwner(){} // RVA: 0x7FFD574734C0
        public void IsOwner(){} // RVA: 0x7FFD574735A0 | overloaded x2
        public void GetOwner(){} // RVA: 0x7FFD57473660
        public void SetOwner(){} // RVA: 0x7FFD574736D0
        public void IsObjectReady(){} // RVA: 0x7FFD57473740
        public void Instantiate(){} // RVA: 0x7FFD574737B0
        public void RPC(){} // RVA: 0x7FFD57473900 | overloaded x2
        public void EncodeParameters(){} // RVA: 0x7FFD574739A0
        public void DecodeParameters(){} // RVA: 0x7FFD57473A10
        public void Destroy(){} // RVA: 0x7FFD57473A80
        public void GetUniqueName(){} // RVA: 0x7FFD57473AF0
        public void GoToRoom(){} // RVA: 0x7FFD57473B60
        public void GetNetworkDateTime(){} // RVA: 0x7FFD57473BD0
        public void GetServerTimeInSeconds(){} // RVA: 0x7FFD57473C70
        public void GetServerTimeInMilliseconds(){} // RVA: 0x7FFD57473D20
        public void CalculateServerDeltaTime(){} // RVA: 0x7FFD57473DD0
        public void SafeStartCoroutine(){} // RVA: 0x7FFD57473E60
        public void GetEventDispatcher(){} // RVA: 0x7FFD57473ED0
        public void SimulationTime(){} // RVA: 0x7FFD57473FE0 | overloaded x2
        public void RequestStorageUsageUpdate(){} // RVA: 0x7FFD55576E60
        public void GetPlayerObjects(){} // RVA: 0x7FFD5746B7E0
        public void GetPlayerDataStorageLimit(){} // RVA: 0x7FFD57474090
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x7FFD574740F0
        public void GetPlayerDataStorageUsage(){} // RVA: 0x7FFD57474150
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x7FFD574741C0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFD57474230
    }

    public class RPC : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57472E40 | overloaded x4
        public void SetupTargets(){} // RVA: 0x7FFD57472E60
    }

    public class Tutorial : Object
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFD57492030
        public void ActivateObjectLabel(){} // RVA: 0x7FFD57492240 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFD57492330
        public void ActivateControllerLabel(){} // RVA: 0x7FFD57492390
        public void DeactivateControllerLabel(){} // RVA: 0x7FFD57492430
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Utilities : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD5749FC50
        public void ShuffleArray(){} // RVA: 0x7FFD5749FDB0 | overloaded x2
        public void IsClient(){} // RVA: 0x7FFD5749FEB0
        public void SetIsClient(){} // RVA: 0x7FFD5749FEF0
        public void Fletcher32Fast(){} // RVA: 0x7FFD5749FF30
    }

    public class VRCBuiltInShaderGlobals : MonoBehaviour
    {
        public object Instance;
        public object GetPreferredTimezoneDelegate;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD574782E0
        public void set_Instance(){} // RVA: 0x7FFD57478340
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFD4E36F0C0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFD4E36F0D0
        public void Update(){} // RVA: 0x7FFD57478400
        public void OnDestroy(){} // RVA: 0x7FFD57478AA0
        public void Initialize(){} // RVA: 0x7FFD57478D90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD574791D0
    }

    public class VRCCustomAction : MonoBehaviour
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD5747C310 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCDroneApi : Object
    {
        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x7FFD57472A00
        public void GetPlayer(){} // RVA: 0x7FFD4E078E90
        public void IsDeployed(){} // RVA: 0x7FFD4E079D00
        public void TryGetPosition(){} // RVA: 0x7FFD4E079F60
        public void GetPosition(){} // RVA: 0x7FFD4E0788A0
        public void TryGetRotation(){} // RVA: 0x7FFD4E079F60
        public void GetRotation(){} // RVA: 0x7FFD4E0788A0
        public void TryGetVelocity(){} // RVA: 0x7FFD4E079F60
        public void GetVelocity(){} // RVA: 0x7FFD4E0788A0
        public void TeleportTo(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void SetVelocity(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class VRCPlayerApi : Object
    {
        public object isMaster;
        public object isInstanceOwner;
        public object isModerator;
        public object isSuper;
        public object isSuspended;
        public object isVRCPlus;
        public object AllPlayers;
        public object playerId;

        // ── Methods ──
        public void get_isMaster(){} // RVA: 0x7FFD574688B0
        public void get_isInstanceOwner(){} // RVA: 0x7FFD57468930
        public void get_isModerator(){} // RVA: 0x7FFD574689B0
        public void get_isSuper(){} // RVA: 0x7FFD57468A30
        public void get_isSuspended(){} // RVA: 0x7FFD57468AB0
        public void get_isVRCPlus(){} // RVA: 0x7FFD57468B30
        public void IsPlayerGrounded(){} // RVA: 0x7FFD57468BB0
        public void GetDrone(){} // RVA: 0x7FFD57468C50
        public void get_AllPlayers(){} // RVA: 0x7FFD57468CD0
        public void GetPlayers(){} // RVA: 0x7FFD57468DE0 | overloaded x2
        public void GetPlayerCount(){} // RVA: 0x7FFD57468E80
        public void GetPlayerId(){} // RVA: 0x7FFD57468F00
        public void get_playerId(){} // RVA: 0x7FFD57468F80
        public void GetPlayerByGameObject(){} // RVA: 0x7FFD57468FE0
        public void GetPlayerById(){} // RVA: 0x7FFD57469060
        public void IsValid(){} // RVA: 0x7FFD4E367450
        public void IsOwner(){} // RVA: 0x7FFD574690E0
        public void TakeOwnership(){} // RVA: 0x7FFD57469170
        public void GetTrackingData(){} // RVA: 0x7FFD57469200
        public void GetBoneTransform(){} // RVA: 0x7FFD574692C0
        public void GetBonePosition(){} // RVA: 0x7FFD57469350
        public void GetBoneRotation(){} // RVA: 0x7FFD57469410
        public void GetPickupInHand(){} // RVA: 0x7FFD574694C0
        public void SetPickupInHand(){} // RVA: 0x7FFD4E341310
        public void PlayHapticEventInHand(){} // RVA: 0x7FFD57469550
        public void TeleportTo(){} // RVA: 0x7FFD57469810 | overloaded x3
        public void Respawn(){} // RVA: 0x7FFD57469990 | overloaded x2
        public void EnablePickups(){} // RVA: 0x7FFD57469A20
        public void SetNamePlateColor(){} // RVA: 0x7FFD57469AB0
        public void RestoreNamePlateColor(){} // RVA: 0x7FFD57469B50
        public void SetNamePlateVisibility(){} // RVA: 0x7FFD57469BD0
        public void RestoreNamePlateVisibility(){} // RVA: 0x7FFD57469C60
        public void SetPlayerTag(){} // RVA: 0x7FFD57469CE0
        public void GetPlayerTag(){} // RVA: 0x7FFD57469D80
        public void GetPlayersWithTag(){} // RVA: 0x7FFD4E919180
        public void ClearPlayerTags(){} // RVA: 0x7FFD57469E10
        public void SetInvisibleToTagged(){} // RVA: 0x7FFD57469E90
        public void SetInvisibleToUntagged(){} // RVA: 0x7FFD57469F50
        public void SetSilencedToTagged(){} // RVA: 0x7FFD5746A010
        public void SetSilencedToUntagged(){} // RVA: 0x7FFD5746A0C0
        public void SetRunSpeed(){} // RVA: 0x7FFD5746A170
        public void SetWalkSpeed(){} // RVA: 0x7FFD5746A200
        public void SetStrafeSpeed(){} // RVA: 0x7FFD5746A290
        public void SetJumpImpulse(){} // RVA: 0x7FFD5746A320
        public void GetGravityStrength(){} // RVA: 0x7FFD5746A3B0
        public void GetRunSpeed(){} // RVA: 0x7FFD5746A430
        public void GetWalkSpeed(){} // RVA: 0x7FFD5746A4B0
        public void GetStrafeSpeed(){} // RVA: 0x7FFD5746A530
        public void GetJumpImpulse(){} // RVA: 0x7FFD5746A5B0
        public void IsUserInVR(){} // RVA: 0x7FFD5746A630
        public void SetGravityStrength(){} // RVA: 0x7FFD5746A6B0
        public void UseLegacyLocomotion(){} // RVA: 0x7FFD5746A740
        public void UseAttachedStation(){} // RVA: 0x7FFD5746A7C0
        public void ClearInvisible(){} // RVA: 0x7FFD5746A840
        public void ClearSilence(){} // RVA: 0x7FFD5746A8C0
        public void AddToList(){} // RVA: 0x7FFD5746A940
        public void RemoveFromList(){} // RVA: 0x7FFD5746A9D0
        public void CombatSetup(){} // RVA: 0x7FFD5746AA60
        public void CombatSetMaxHitpoints(){} // RVA: 0x7FFD5746AAE0
        public void CombatSetCurrentHitpoints(){} // RVA: 0x7FFD5746AB70
        public void CombatGetCurrentHitpoints(){} // RVA: 0x7FFD5746AC00
        public void CombatSetRespawn(){} // RVA: 0x7FFD5746AC80
        public void CombatSetDamageGraphic(){} // RVA: 0x7FFD5746AD40
        public void CombatGetDestructible(){} // RVA: 0x7FFD5746ADD0
        public void SetVoiceGain(){} // RVA: 0x7FFD5746AE50
        public void GetVoiceGain(){} // RVA: 0x7FFD5746AEE0
        public void SetVoiceDistanceNear(){} // RVA: 0x7FFD5746AF60
        public void GetVoiceDistanceNear(){} // RVA: 0x7FFD5746AFF0
        public void SetVoiceDistanceFar(){} // RVA: 0x7FFD5746B070
        public void GetVoiceDistanceFar(){} // RVA: 0x7FFD5746B100
        public void SetVoiceVolumetricRadius(){} // RVA: 0x7FFD5746B180
        public void GetVoiceVolumetricRadius(){} // RVA: 0x7FFD5746B210
        public void SetVoiceLowpass(){} // RVA: 0x7FFD5746B290
        public void GetVoiceLowpass(){} // RVA: 0x7FFD5746B320
        public void SetAvatarAudioGain(){} // RVA: 0x7FFD5746B3A0
        public void SetAvatarAudioFarRadius(){} // RVA: 0x7FFD5746B430
        public void SetAvatarAudioNearRadius(){} // RVA: 0x7FFD5746B4C0
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x7FFD5746B550
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x7FFD5746B5E0
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x7FFD5746B670
        public void GetAvailableLanguages(){} // RVA: 0x7FFD5746B700
        public void GetCurrentLanguage(){} // RVA: 0x7FFD5746B770
        public void GetPlayerObjects(){} // RVA: 0x7FFD5746B7E0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFD5746B880
        public void PushAnimations(){} // RVA: 0x7FFD5746B890
        public void PopAnimations(){} // RVA: 0x7FFD5746B920
        public void Immobilize(){} // RVA: 0x7FFD5746B9A0
        public void SetVelocity(){} // RVA: 0x7FFD5746BA30
        public void GetVelocity(){} // RVA: 0x7FFD5746BAD0
        public void GetPosition(){} // RVA: 0x7FFD5746BB70
        public void GetRotation(){} // RVA: 0x7FFD5746BC10
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x7FFD5746BCB0
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x7FFD5746BD30
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x7FFD5746BDB0
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x7FFD5746BE30
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x7FFD5746BEB0
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x7FFD5746BF40
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x7FFD5746BFD0
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x7FFD5746C060
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x7FFD5746C0F0
        public void .ctor(){} // RVA: 0x7FFD5746C180
        public void .cctor(){} // RVA: 0x7FFD5746C210
    }

    public class VRCStation : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5747C3D0
        public void UseStation(){} // RVA: 0x7FFD5747C430
        public void ExitStation(){} // RVA: 0x7FFD5747C4A0
        public void .ctor(){} // RVA: 0x7FFD5740E430
    }

    public class VRCTriggerRelay : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57493910
        public void OnTriggerEnter(){} // RVA: 0x7FFD57493970
        public void OnTriggerExit(){} // RVA: 0x7FFD57493A00
        public void .ctor(){} // RVA: 0x7FFD57493A80
    }

    public class VRCUrl : Object
    {
        public object Empty;
        public object DomainExplicitAllowlistDelegate;
        public object DomainWildcardAllowlistDelegate;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFD57493C40
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x7FFD57493CA0
        public void IsNullOrEmpty(){} // RVA: 0x7FFD57493F30
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFD57493FD0
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFD57494030
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFD574940F0
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFD57494150
        public void IsAllowlistedUri(){} // RVA: 0x7FFD57494210
        public void .ctor(){} // RVA: 0x7FFD57494470
        public void Get(){} // RVA: 0x7FFD4E35C380
        public void ToString(){} // RVA: 0x7FFD4E35C380
        public void Equals(){} // RVA: 0x7FFD57494650 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5405A320
        public void .cctor(){} // RVA: 0x7FFD574946A0
    }

    public class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E3A0
        public void OnStateEnter(){} // RVA: 0x7FFD531D12C0
        public void .ctor(){} // RVA: 0x7FFD57437900
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E400
        public void OnStateEnter(){} // RVA: 0x7FFD542A7130
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRC_AnimatorPlayAudio : StateMachineBehaviour
    {
        public object ShouldApplyVolume;
        public object ShouldApplyPitch;
        public object ShouldApplyClip;
        public object ShouldApplyLoop;

        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x7FFD5746E460
        public void get_ShouldApplyPitch(){} // RVA: 0x7FFD5746E470
        public void get_ShouldApplyClip(){} // RVA: 0x7FFD5746E480
        public void get_ShouldApplyLoop(){} // RVA: 0x7FFD5746E490
        public void ShouldApplySetting(){} // RVA: 0x7FFD5746E4A0
        public void Awake(){} // RVA: 0x7FFD5746E520
        public void OnStateEnter(){} // RVA: 0x7FFD5746E580
        public void OnStateExit(){} // RVA: 0x7FFD5746E5A0
        public void .ctor(){} // RVA: 0x7FFD57437910
    }

    public class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E5D0
        public void OnStateEnter(){} // RVA: 0x7FFD5746E630
        public void OnStateUpdate(){} // RVA: 0x7FFD5746E6C0
        public void .ctor(){} // RVA: 0x7FFD57437960
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E760
        public void OnStateEnter(){} // RVA: 0x7FFD54804990
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        public object NetworkIDCollection;

        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD5746E7C0
        public void PositionPortraitCamera(){} // RVA: 0x7FFD5746EB00
        public void get_NetworkIDCollection(){} // RVA: 0x7FFD4E3AC040
        public void set_NetworkIDCollection(){} // RVA: 0x7FFD4E3AC050
        public void GetNetworkIDObjects(){} // RVA: 0x7FFD5746EF90
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFD5746F030
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFD5746F350
        public void .ctor(){} // RVA: 0x7FFD5746F3D0
    }

    public class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFD5746F6B0
        public void .ctor(){} // RVA: 0x7FFD5743C070
    }

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574747D0
        public void SwitchAvatar(){} // RVA: 0x7FFD57450BC0 | overloaded x2
        public void SetAvatarUse(){} // RVA: 0x7FFD57474CE0
        public void .ctor(){} // RVA: 0x7FFD57474E20
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0x7FFD57494AF0
        public void GetElement(){} // RVA: 0x7FFD57494B60
        public void add_ElementChanged(){} // RVA: 0x7FFD57494BF0
        public void remove_ElementChanged(){} // RVA: 0x7FFD57494CE0
        public void OnDataElementChanged(){} // RVA: 0x7FFD57494DD0
        public void Awake(){} // RVA: 0x7FFD57494E00
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_DestructibleStandard : MonoBehaviour
    {
        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0x7FFD4E36A080
        public void GetCurrentHealth(){} // RVA: 0x7FFD4E4AEF50
        public void Awake(){} // RVA: 0x7FFD57470D70
        public void ApplyDamage(){} // RVA: 0x7FFD57470F50
        public void ApplyHealing(){} // RVA: 0x7FFD574714E0
        public void GetState(){} // RVA: 0x7FFD57471AC0
        public void SetState(){} // RVA: 0x7FFD57471B90
        public void HandleCallbackTrigger(){} // RVA: 0x7FFD57471C10
        public void .ctor(){} // RVA: 0x7FFD57402BD0
        public void <ApplyDamage>b__27_0(){} // RVA: 0x7FFD57470040
        public void <ApplyDamage>b__27_1(){} // RVA: 0x7FFD57471D50
        public void <ApplyHealing>b__28_0(){} // RVA: 0x7FFD57471D50
        public void <ApplyHealing>b__28_1(){} // RVA: 0x7FFD57471DB0
    }

    public class VRC_EventDispatcher : MonoBehaviour
    {
        // ── Methods ──
        public void TriggerEvent(){}
        public void RegisterEventHandler(){} // RVA: 0x7FFD4E090A40
        public void UnregisterEventHandler(){} // RVA: 0x7FFD4E090A40
        public void FindGameObject(){} // RVA: 0x7FFD4E0896F0 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcher
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57472AE0
        public void TriggerEvent(){} // RVA: 0x7FFD4E341310
        public void RegisterEventHandler(){} // RVA: 0x7FFD4E341310
        public void UnregisterEventHandler(){} // RVA: 0x7FFD4E341310
        public void FindGameObject(){} // RVA: 0x7FFD57472B30
        public void GetGameObjectPath(){} // RVA: 0x7FFD57472B80
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_EventHandler : VRCNetworkBehaviour
    {
        public object Dispatcher;
        public object GetInsitgatorId;

        // ── Methods ──
        public void BooleanOp(){} // RVA: 0x7FFD57494EF0
        public void get_Dispatcher(){} // RVA: 0x7FFD57494F10
        public void get_GetInsitgatorId(){} // RVA: 0x7FFD57495030
        public void set_GetInsitgatorId(){} // RVA: 0x7FFD57495070
        public void Awake(){} // RVA: 0x7FFD57495110
        public void VrcAnimationEvent(){} // RVA: 0x7FFD574954B0
        public void IsReceiverRequiredForEventType(){} // RVA: 0x7FFD574956A0
        public void TriggerEvent(){} // RVA: 0x7FFD574966F0 | overloaded x4
        public void InternalTriggerEvent(){} // RVA: 0x7FFD57496160
        public void OnValidate(){} // RVA: 0x7FFD574968E0
        public void OnDestroy(){} // RVA: 0x7FFD57496A40
        public void GetCombinedNetworkId(){} // RVA: 0x7FFD4E919180
        public void HasEventTrigger(){} // RVA: 0x7FFD57496BB0
        public void IsReadyForEvents(){} // RVA: 0x7FFD4E426850
        public void DeferEvent(){} // RVA: 0x7FFD57496CB0
        public void ProcessDeferredEvents(){} // RVA: 0x7FFD57496FA0
        public void .ctor(){} // RVA: 0x7FFD57497040
    }

    public class VRC_GunStats : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57403200
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57497AA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        public object IsInteractive;
        public object Proximity;

        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0x7FFD4E341320
        public void get_Proximity(){} // RVA: 0x7FFD4EB36E90
        public void Start(){} // RVA: 0x7FFD4E341310
        public void Awake(){} // RVA: 0x7FFD57497E10
        public void Interact(){} // RVA: 0x7FFD4E090980
        public void OnPickupUseUp(){} // RVA: 0x7FFD4E341310
        public void OnPickupUseDown(){} // RVA: 0x7FFD4E341310
        public void OnPickup(){} // RVA: 0x7FFD4E341310
        public void OnDrop(){} // RVA: 0x7FFD4E341310
        public void IsInteractiveForPlayer(){} // RVA: 0x7FFD57497E70
        public void .ctor(){} // RVA: 0x7FFD57497F10
    }

    public class VRC_KeyEvents : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5746F730
        public void Update(){} // RVA: 0x7FFD5746F990
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void <Update>b__9_0(){} // RVA: 0x7FFD5746FFE0
        public void <Update>b__9_2(){} // RVA: 0x7FFD5746FFE0
        public void <Update>b__9_1(){} // RVA: 0x7FFD57470040
        public void <Update>b__9_3(){} // RVA: 0x7FFD57470040
    }

    public class VRC_Label : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57410EC0
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        public object currentMetadata;

        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0x7FFD5747C510
        public void Awake(){} // RVA: 0x7FFD5747C570
        public void OnDestroy(){} // RVA: 0x7FFD5747C6E0
        public void TriggerUpdate(){} // RVA: 0x7FFD5747C850
        public void MetadataChangedInternal(){} // RVA: 0x7FFD5747C8B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_MidiNoteIn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574742B0
        public void Start(){} // RVA: 0x7FFD4E341310
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_MirrorReflection : MonoBehaviour
    {
        public object CurrentlyRenderingMirror;
        public object CurrentMirrorCenterEyePos;

        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x7FFD5747C8D0
        public void remove_PreRenderMirror(){} // RVA: 0x7FFD5747CA20
        public void add_PostRenderMirror(){} // RVA: 0x7FFD5747CB70
        public void remove_PostRenderMirror(){} // RVA: 0x7FFD5747CCC0
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x7FFD5747CE10
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x7FFD5747CE70
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFD5747CF30
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFD5747CFA0
        public void OnValidate(){} // RVA: 0x7FFD5747D010
        public void Start(){} // RVA: 0x7FFD5747D070
        public void TrySetupMaterial(){} // RVA: 0x7FFD5747D480
        public void OnWillRenderObject(){} // RVA: 0x7FFD5747D9D0
        public void RenderMirrorCameras(){} // RVA: 0x7FFD5747DDA0
        public void CameraPostRender(){} // RVA: 0x7FFD5747F060
        public void OnDisable(){} // RVA: 0x7FFD5747F360
        public void OnDestroy(){} // RVA: 0x7FFD5747F800
        public void ShouldRenderLeftEye(){} // RVA: 0x7FFD5747FCB0
        public void ShouldRenderRightEye(){} // RVA: 0x7FFD5747FEC0
        public void ShouldRenderMonoscopic(){} // RVA: 0x7FFD574800D0
        public void GetWorldEyePos(){} // RVA: 0x7FFD57480330
        public void GetWorldEyeRot(){} // RVA: 0x7FFD57480460
        public void GetEyeProjectionMatrix(){} // RVA: 0x7FFD57480650
        public void GetNormalDirection(){} // RVA: 0x7FFD57480720
        public void RenderMirror(){} // RVA: 0x7FFD574807D0
        public void UpdateCameraClearing(){} // RVA: 0x7FFD574814F0
        public void UpdateCameraModes(){} // RVA: 0x7FFD574818D0
        public void UpdateParentTransform(){} // RVA: 0x7FFD57482240
        public void GetReflectionData(){} // RVA: 0x7FFD57482BB0
        public void GetAutoResolution(){} // RVA: 0x7FFD574836A0
        public void Plane(){} // RVA: 0x7FFD57483890
        public void CameraSpacePlane(){} // RVA: 0x7FFD574838F0
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFD57483D00
        public void CopySign(){} // RVA: 0x7FFD57483E70
        public void GetRotation(){} // RVA: 0x7FFD57483EA0
        public void GetPosition(){} // RVA: 0x7FFD540543C0
        public void .ctor(){} // RVA: 0x7FFD574840E0
        public void .cctor(){} // RVA: 0x7FFD574841F0
    }

    public class VRC_NPCSpawn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57474EE0
        public void .ctor(){} // RVA: 0x7FFD57403D60
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD574700A0
        public void GetApiByGameObject(){} // RVA: 0x7FFD57470100
        public void ActThis(){} // RVA: 0x7FFD57470210
        public void SayThis(){} // RVA: 0x7FFD574702A0
        public void SetNamePlate(){} // RVA: 0x7FFD57470330
        public void SetSocialStatus(){} // RVA: 0x7FFD574703D0
        public void SetMuteStatus(){} // RVA: 0x7FFD57470470
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_ObjectApi : MonoBehaviour
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_ObjectSpawn : MonoBehaviour
    {
        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x7FFD574751A0 | overloaded x2
        public void DestroySpawnedObjects(){} // RVA: 0x7FFD4FD68B60
        public void Start(){} // RVA: 0x7FFD574752C0
        public void ProvideEvents(){} // RVA: 0x7FFD57475320
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57474310
        public void Start(){} // RVA: 0x7FFD4E341310
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Panorama : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57484360
        public void Update(){} // RVA: 0x7FFD57484530
        public void NextPano(){} // RVA: 0x7FFD57484800
        public void PrevPano(){} // RVA: 0x7FFD574848C0
        public void ShowPanoAt(){} // RVA: 0x7FFD57484980
        public void ShowPano(){} // RVA: 0x7FFD57484A10
        public void .ctor(){} // RVA: 0x7FFD57410F90
    }

    public class VRC_PhysicsRoot : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57470500
        public void OnDestroy(){} // RVA: 0x7FFD57470B30
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        public object currentPlayer;
        public object IsHeld;
        public object currentHand;
        public object Proximity;

        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7FFD57475930 | overloaded x2
        public void get_currentPlayer(){} // RVA: 0x7FFD57475960
        public void get_IsHeld(){} // RVA: 0x7FFD574759D0
        public void get_currentHand(){} // RVA: 0x7FFD57475A90
        public void get_Proximity(){} // RVA: 0x7FFD57475AF0
        public void Awake(){} // RVA: 0x7FFD57475B00
        public void OnDisable(){} // RVA: 0x7FFD57475B60
        public void Reset(){} // RVA: 0x7FFD57475BA0
        public void Drop(){} // RVA: 0x7FFD57475D30 | overloaded x2
        public void GenerateHapticEvent(){} // RVA: 0x7FFD57475F90
        public void OnDestroy(){} // RVA: 0x7FFD57476030
        public void PlayHaptics(){} // RVA: 0x7FFD57476090
        public void ProvideEvents(){} // RVA: 0x7FFD574760C0
        public void .ctor(){} // RVA: 0x7FFD57476500
    }

    public class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57470C50
        public void OnStateEnter(){} // RVA: 0x7FFD57470CB0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x7FFD4E4F1BC0
        public void Awake(){} // RVA: 0x7FFD574768B0
        public void Update(){} // RVA: 0x7FFD57476930
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PropApi : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PropController : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574769B0
        public void Update(){} // RVA: 0x7FFD57476A10
        public void GetInputIndex(){} // RVA: 0x7FFD57476A80
        public void .ctor(){} // RVA: 0x7FFD574054B0
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        public object NetworkIDCollection;
        public object NetworkIDLookup;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57476B80
        public void get_NetworkIDCollection(){} // RVA: 0x7FFD4E3BE740
        public void set_NetworkIDCollection(){} // RVA: 0x7FFD4E369200
        public void get_NetworkIDLookup(){} // RVA: 0x7FFD4E3BC730
        public void set_NetworkIDLookup(){} // RVA: 0x7FFD4E3BC740
        public void GetNetworkIDObjects(){} // RVA: 0x7FFD574775B0
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFD57477650
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFD5746F350
        public void .ctor(){} // RVA: 0x7FFD57477970
    }

    public class VRC_SceneDescriptor : MonoBehaviour
    {
        public object NetworkIDCollection;
        public object NetworkIDLookup;
        public object Instance;
        public object Exists;
        public object BundleUnityMajorVersion;
        public object Scene;

        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0x7FFD57485390
        public void GetPrefab(){} // RVA: 0x7FFD57485580
        public void GetMaterial(){} // RVA: 0x7FFD57485970
        public void get_NetworkIDCollection(){} // RVA: 0x7FFD4EDE0A30
        public void set_NetworkIDCollection(){} // RVA: 0x7FFD4EDEF5C0
        public void get_NetworkIDLookup(){} // RVA: 0x7FFD4E818150
        public void set_NetworkIDLookup(){} // RVA: 0x7FFD4EDD1270
        public void GetNetworkIDObjects(){} // RVA: 0x7FFD57485D60
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFD57486050
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFD5746F350
        public void get_Instance(){} // RVA: 0x7FFD574865B0
        public void get_Exists(){} // RVA: 0x7FFD574868C0
        public void get_BundleUnityMajorVersion(){} // RVA: 0x7FFD574869C0
        public void set_BundleUnityMajorVersion(){} // RVA: 0x7FFD574869D0
        public void get_Scene(){} // RVA: 0x7FFD4FBE4270
        public void set_Scene(){} // RVA: 0x7FFD4FBE4280
        public void Awake(){} // RVA: 0x7FFD574869E0
        public void OnDestroy(){} // RVA: 0x7FFD574879B0
        public void PositionPortraitCamera(){} // RVA: 0x7FFD57487A70
        public void .ctor(){} // RVA: 0x7FFD57487E40
        public void .cctor(){} // RVA: 0x7FFD57488170
    }

    public class VRC_Serialization : Object
    {
        public object AllowPluginTypes;
        public object SurrogateSelector;
        public object Dispatcher;

        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x7FFD57497FD0
        public void set_AllowPluginTypes(){} // RVA: 0x7FFD57498030
        public void get_SurrogateSelector(){} // RVA: 0x7FFD57498090
        public void RegisterPluginType(){} // RVA: 0x7FFD574981A0
        public void RegisterType(){} // RVA: 0x7FFD57498290
        public void ParameterEncoder(){} // RVA: 0x7FFD57498380
        public void ParameterDecoder(){} // RVA: 0x7FFD57498590
        public void get_Dispatcher(){} // RVA: 0x7FFD57498800
        public void GetGameObjectPathFallback(){} // RVA: 0x7FFD57498940
        public void GetGameObjectPath(){} // RVA: 0x7FFD57498BB0
        public void FindGameObject(){} // RVA: 0x7FFD57498CF0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD57498E50
    }

    public class VRC_SlideShow : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57477B90
        public void ShowNextImage(){} // RVA: 0x7FFD57477C50
        public void ShowPreviousImage(){} // RVA: 0x7FFD57477E70
        public void StartAutoplayWithDuration(){} // RVA: 0x7FFD57478040
        public void StopAutoplayWithDuration(){} // RVA: 0x7FFD57478100
        public void .ctor(){} // RVA: 0x7FFD574055B0
    }

    public class VRC_SpatialAudioSource : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57467DC0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD57468060
        public void .ctor(){} // RVA: 0x7FFD57401C30
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFD57488460
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_StereoObject : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_TimedEvents : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57488690
        public void OnEnable(){} // RVA: 0x7FFD57488860
        public void Update(){} // RVA: 0x7FFD57488870
        public void ResetClock(){} // RVA: 0x7FFD57488A00
        public void .ctor(){} // RVA: 0x7FFD5740E4F0
    }

    public class VRC_Trigger : VRC_Interactable
    {
        public object HasKeyTriggers;
        public object HasTimerTriggers;
        public object HasColliderTriggers;
        public object HasInteractiveTriggers;
        public object HasPickupTriggers;
        public object IsInteractive;

        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0x7FFD57488D10 | overloaded x2
        public void Trigger(){} // RVA: 0x7FFD57488B80
        public void get_HasKeyTriggers(){} // RVA: 0x7FFD57488EA0
        public void get_HasTimerTriggers(){} // RVA: 0x7FFD57489010
        public void get_HasColliderTriggers(){} // RVA: 0x7FFD57489180
        public void get_HasInteractiveTriggers(){} // RVA: 0x7FFD57489420
        public void get_HasPickupTriggers(){} // RVA: 0x7FFD57489590
        public void get_IsInteractive(){} // RVA: 0x7FFD57489700
        public void Awake(){} // RVA: 0x7FFD574899E0
        public void OnDestroy(){} // RVA: 0x7FFD57489A90
        public void OnEnable(){} // RVA: 0x7FFD57489AA0
        public void OnDisable(){} // RVA: 0x7FFD57489AD0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD57489B00
        public void Interact(){} // RVA: 0x7FFD5748A0B0
        public void OnPickupUseUp(){} // RVA: 0x7FFD5748A0C0
        public void OnPickupUseDown(){} // RVA: 0x7FFD5748A0D0
        public void OnPickup(){} // RVA: 0x7FFD5748A0E0
        public void OnDrop(){} // RVA: 0x7FFD5748A0F0
        public void ExecuteTriggers(){} // RVA: 0x7FFD5748A100
        public void ExecuteTriggerType(){} // RVA: 0x7FFD5748A400
        public void ExecuteCustomTrigger(){} // RVA: 0x7FFD5748A760
        public void ResetClocks(){} // RVA: 0x7FFD5748AB50
        public void ResetClock(){} // RVA: 0x7FFD5748AEC0
        public void .ctor(){} // RVA: 0x7FFD5740E550
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x7FFD5748AF50
    }

    public class VRC_TriggerColliderEventTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5748BF00
        public void OnTriggerEnter(){} // RVA: 0x7FFD5748C0C0
        public void OnTriggerExit(){} // RVA: 0x7FFD5748C200
        public void .ctor(){} // RVA: 0x7FFD5740E620
    }

    public class VRC_TutorialAction : MonoBehaviour
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFD574917A0
        public void ActivateObjectLabel(){} // RVA: 0x7FFD574919A0 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFD57491A30
        public void ActivateControllerLabel(){} // RVA: 0x7FFD57491A90
        public void DeactivateControllerLabel(){} // RVA: 0x7FFD57491AC0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_TutorialAreaMarker : MonoBehaviour
    {
        // ── Methods ──
        public void Enable(){} // RVA: 0x7FFD53679980
        public void Update(){} // RVA: 0x7FFD57491AD0
        public void ShowLabel(){} // RVA: 0x7FFD57491F00
        public void .ctor(){} // RVA: 0x7FFD5740E9E0
    }

    public class VRC_UiShape : MonoBehaviour
    {
        public object RootCanvas;
        public object RootCanvasRectTransform;

        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0x7FFD4E36F0C0
        public void set_RootCanvas(){} // RVA: 0x7FFD4E36F0D0
        public void get_RootCanvasRectTransform(){} // RVA: 0x7FFD4E36F130
        public void set_RootCanvasRectTransform(){} // RVA: 0x7FFD4E342E90
        public void add_OnUiShapeInit(){} // RVA: 0x7FFD57492A80
        public void remove_OnUiShapeInit(){} // RVA: 0x7FFD57492BC0
        public void add_OnUiShapeDestroy(){} // RVA: 0x7FFD57492D00
        public void remove_OnUiShapeDestroy(){} // RVA: 0x7FFD57492E40
        public void Awake(){} // RVA: 0x7FFD57492F80
        public void Start(){} // RVA: 0x7FFD57493120
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD57493480
        public void SetupCollision(){} // RVA: 0x7FFD57493490
        public void OnDestroy(){} // RVA: 0x7FFD574938B0
        public void .ctor(){} // RVA: 0x7FFD4E3F5710
    }

    public class VRC_UseEvents : VRC_Interactable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5748C340
        public void Start(){} // RVA: 0x7FFD5748C580
        public void Interact(){} // RVA: 0x7FFD5748C810
        public void .ctor(){} // RVA: 0x7FFD5740E670
        public void <Awake>b__5_0(){} // RVA: 0x7FFD5748C9F0
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57471E10
        public void Start(){} // RVA: 0x7FFD57471EA0
        public void OnSceneWasLoaded(){} // RVA: 0x7FFD574720D0
        public void Update(){} // RVA: 0x7FFD57472170
        public void HideDamageIndicator(){} // RVA: 0x7FFD574723A0
        public void ShowDamageIndicator(){} // RVA: 0x7FFD574724C0
        public void SetDamagePercent(){} // RVA: 0x7FFD574725E0
        public void .ctor(){} // RVA: 0x7FFD574728E0
    }

    public class VRC_Water : MonoBehaviour
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFD5748CB00
        public void OnDisable(){} // RVA: 0x7FFD5748D7E0
        public void Update(){} // RVA: 0x7FFD5748DE30
        public void UpdateCameraModes(){} // RVA: 0x7FFD5748E300
        public void CreateWaterObjects(){} // RVA: 0x7FFD5748E880
        public void GetWaterMode(){} // RVA: 0x7FFD5748FC40
        public void FindHardwareWaterSupport(){} // RVA: 0x7FFD5748FC50
        public void CameraSpacePlane(){} // RVA: 0x7FFD4E358D00
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFD4E3590F0
        public void .ctor(){} // RVA: 0x7FFD5740E710
    }

    public class VRC_WebPanel : VRC_Interactable
    {
        public object WebRootPath;

        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0x7FFD5748FF40
        public void WebPanelBackward(){} // RVA: 0x7FFD5748FF70
        public void WebPanelReload(){} // RVA: 0x7FFD5748FFA0
        public void BindCall(){} // RVA: 0x7FFD5748FFD0
        public void NavigateTo(){} // RVA: 0x7FFD57490000
        public void Awake(){} // RVA: 0x7FFD57490030
        public void Interact(){} // RVA: 0x7FFD4E341310
        public void get_WebRootPath(){} // RVA: 0x7FFD57490140
        public void ProvideEvents(){} // RVA: 0x7FFD574902B0
        public void ReadData(){} // RVA: 0x7FFD57490BE0
        public void ImportWebData(){} // RVA: 0x7FFD57490E40
        public void .ctor(){} // RVA: 0x7FFD5740E8B0
    }

    public class VersionHelper : Object
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0x7FFD4E2ADC40
    }

}