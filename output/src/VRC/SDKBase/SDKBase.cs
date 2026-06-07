// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 78
// Methods: 662

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        // ── Methods ──
        public void get_boolVal(){} // RVA: 0xDBE0
        public void set_boolVal(){} // RVA: 0x25130
        public void get_intVal(){} // RVA: 0xD840
        public void set_intVal(){} // RVA: 0x24FA0
        public void get_floatVal(){} // RVA: 0x21890
        public void set_floatVal(){} // RVA: 0x325B0
    }

    public class IEditorOnly
    {
    }

    public class INetworkID
    {
    }

    public class INetworkIDContainer
    {
        // ── Methods ──
        public void get_NetworkIDCollection(){} // RVA: 0xCD60
        public void set_NetworkIDCollection(){} // RVA: 0x24B10
        public void GetNetworkIDObjects(){} // RVA: 0x24B10
        public void FindNetworkIDGameObject(){} // RVA: 0x1D640
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x1E6A0
    }

    public class IPreprocessCallbackBehaviour
    {
        // ── Methods ──
        public void OnPreprocess(){} // RVA: 0xDBE0
        public void get_PreprocessOrder(){} // RVA: 0xD840
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0xCD60
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
        public void GetState(){} // RVA: 0xCD60
        public void SetState(){} // RVA: 0x24B10
        public void GetMaxHealth(){} // RVA: 0x21890
        public void GetCurrentHealth(){} // RVA: 0x21890
        public void ApplyDamage(){} // RVA: 0x325B0
        public void ApplyHealing(){} // RVA: 0x325B0
    }

    public class IValidChecker
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0xDBE0
    }

    public class InputManager
    {
        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0x9A9B5C0
        public void GetLastUsedInputMethod(){} // RVA: 0x9A9B620
        public void GetBoolInputSetting(){} // RVA: 0x9A9B690
        public void SetBoolInputSetting(){} // RVA: 0x9A9B6F0
        public void EnableObjectHighlight(){} // RVA: 0x9A9B860 | overloaded x2
    }

    public class MathUtil
    {
        // ── Methods ──
        public void AngleBetweenTwoUnitVectors(){} // RVA: 0x9A77990
        public void AngleClosestBetweenTwoUnitVectors(){} // RVA: 0x9421570
        public void ClosestPointOnLineSegment_Value(){} // RVA: 0x9A77B70
        public void ClosestPointOnLineSegment(){} // RVA: 0x9421710
        public void ClosestPointOnPlane(){} // RVA: 0x9421830
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9A77C40
    }

    public class Networking
    {
        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x9A76840
        public void get_IsNetworkSettled(){} // RVA: 0x9A768A0
        public void get_IsMaster(){} // RVA: 0x9A76900
        public void get_IsClogged(){} // RVA: 0x9A76960
        public void get_IsInstanceOwner(){} // RVA: 0x9A769C0
        public void get_LocalPlayer(){} // RVA: 0x9A76A20
        public void get_Master(){} // RVA: 0x9A76A80
        public void get_InstanceOwner(){} // RVA: 0x9A76AE0
        public void IsOwner(){} // RVA: 0x9A76BC0 | overloaded x2
        public void GetOwner(){} // RVA: 0x9A76C80
        public void SetOwner(){} // RVA: 0x9A76CF0
        public void IsObjectReady(){} // RVA: 0x9A76D60
        public void Instantiate(){} // RVA: 0x9A76DD0
        public void RPC(){} // RVA: 0x9A76F20 | overloaded x2
        public void EncodeParameters(){} // RVA: 0x9A76FC0
        public void DecodeParameters(){} // RVA: 0x9A77030
        public void Destroy(){} // RVA: 0x9A770A0
        public void GetUniqueName(){} // RVA: 0x9A77110
        public void GoToRoom(){} // RVA: 0x9A77180
        public void GetNetworkDateTime(){} // RVA: 0x9A771F0
        public void GetServerTimeInSeconds(){} // RVA: 0x9A77290
        public void GetServerTimeInMilliseconds(){} // RVA: 0x9A77340
        public void CalculateServerDeltaTime(){} // RVA: 0x9A773F0
        public void SafeStartCoroutine(){} // RVA: 0x9A77480
        public void GetEventDispatcher(){} // RVA: 0x9A774F0
        public void SimulationTime(){} // RVA: 0x9A77600 | overloaded x2
        public void RequestStorageUsageUpdate(){} // RVA: 0x7A00240
        public void GetPlayerObjects(){} // RVA: 0x9A6EE60
        public void GetPlayerDataStorageLimit(){} // RVA: 0x9A776B0
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x9A77710
        public void GetPlayerDataStorageUsage(){} // RVA: 0x9A77770
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x9A777E0
        public void FindComponentInPlayerObjects(){} // RVA: 0x9A77850
    }

    public class RPC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A76460 | overloaded x4
        public void SetupTargets(){} // RVA: 0x9A76480
    }

    public class RPCIgnoredType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Tutorial
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x9A95AF0
        public void ActivateObjectLabel(){} // RVA: 0x9A95D00 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x9A95DF0
        public void ActivateControllerLabel(){} // RVA: 0x9A95E50
        public void DeactivateControllerLabel(){} // RVA: 0x9A95EF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Utilities
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x9AA37D0
        public void ShuffleArray(){} // RVA: 0x9AA3930 | overloaded x2
        public void IsClient(){} // RVA: 0x9AA3A30
        public void SetIsClient(){} // RVA: 0x9AA3A70
        public void Fletcher32Fast(){} // RVA: 0x9AA3AB0
    }

    public class VRCBuiltInShaderGlobals
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x9A7B7E0
        public void set_Instance(){} // RVA: 0x9A7B840
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x30B0C0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x30B0D0
        public void Update(){} // RVA: 0x9A7B900
        public void OnDestroy(){} // RVA: 0x9A7BFA0
        public void Initialize(){} // RVA: 0x9A7C290
        public void .ctor(){} // RVA: 0x2DDD50
        public void .cctor(){} // RVA: 0x9A7C6D0
    }

    public class VRCCustomAction
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x9A7F8D0 | overloaded x3
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCDroneApi
    {
        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x9A76020
        public void GetPlayer(){} // RVA: 0xCD60
        public void IsDeployed(){} // RVA: 0xDBE0
        public void TryGetPosition(){} // RVA: 0xDE40
        public void GetPosition(){} // RVA: 0xC770
        public void TryGetRotation(){} // RVA: 0xDE40
        public void GetRotation(){} // RVA: 0xC770
        public void TryGetVelocity(){} // RVA: 0xDE40
        public void GetVelocity(){} // RVA: 0xC770
        public void TeleportTo(){} // RVA: 0x2DC60 | overloaded x2
        public void SetVelocity(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class VRCGraphics
    {
        // ── Methods ──
        public void get_UiLayerMask(){} // RVA: 0x9A7CBD0
        public void Blit(){} // RVA: 0x9A7D1A0 | overloaded x7
        public void DrawMeshInstanced(){} // RVA: 0x9A7DB30 | overloaded x9
        public void GetLayerMask(){} // RVA: 0x9A7DC90
        public void CheckBlitTarget(){} // RVA: 0x9A7DCA0
        public void .cctor(){} // RVA: 0x9A7DDB0
    }

    public class VRCPlayerApi
    {
        // ── Methods ──
        public void get_isMaster(){} // RVA: 0x9A6BF30
        public void get_isInstanceOwner(){} // RVA: 0x9A6BFB0
        public void get_isModerator(){} // RVA: 0x9A6C030
        public void get_isSuper(){} // RVA: 0x9A6C0B0
        public void get_isSuspended(){} // RVA: 0x9A6C130
        public void get_isVRCPlus(){} // RVA: 0x9A6C1B0
        public void IsPlayerGrounded(){} // RVA: 0x9A6C230
        public void GetDrone(){} // RVA: 0x9A6C2D0
        public void get_AllPlayers(){} // RVA: 0x9A6C350
        public void GetPlayers(){} // RVA: 0x9A6C460 | overloaded x2
        public void GetPlayerCount(){} // RVA: 0x9A6C500
        public void GetPlayerId(){} // RVA: 0x9A6C580
        public void get_playerId(){} // RVA: 0x9A6C600
        public void GetPlayerByGameObject(){} // RVA: 0x9A6C660
        public void GetPlayerById(){} // RVA: 0x9A6C6E0
        public void IsValid(){} // RVA: 0x303450
        public void IsOwner(){} // RVA: 0x9A6C760
        public void TakeOwnership(){} // RVA: 0x9A6C7F0
        public void GetTrackingData(){} // RVA: 0x9A6C880
        public void GetBoneTransform(){} // RVA: 0x9A6C940
        public void GetBonePosition(){} // RVA: 0x9A6C9D0
        public void GetBoneRotation(){} // RVA: 0x9A6CA90
        public void GetPickupInHand(){} // RVA: 0x9A6CB40
        public void SetPickupInHand(){} // RVA: 0x2DD310
        public void PlayHapticEventInHand(){} // RVA: 0x9A6CBD0
        public void TeleportTo(){} // RVA: 0x9A6CE90 | overloaded x3
        public void Respawn(){} // RVA: 0x9A6D010 | overloaded x2
        public void EnablePickups(){} // RVA: 0x9A6D0A0
        public void SetNamePlateColor(){} // RVA: 0x9A6D130
        public void RestoreNamePlateColor(){} // RVA: 0x9A6D1D0
        public void SetNamePlateVisibility(){} // RVA: 0x9A6D250
        public void RestoreNamePlateVisibility(){} // RVA: 0x9A6D2E0
        public void SetPlayerTag(){} // RVA: 0x9A6D360
        public void GetPlayerTag(){} // RVA: 0x9A6D400
        public void GetPlayersWithTag(){} // RVA: 0x519240
        public void ClearPlayerTags(){} // RVA: 0x9A6D490
        public void SetInvisibleToTagged(){} // RVA: 0x9A6D510
        public void SetInvisibleToUntagged(){} // RVA: 0x9A6D5D0
        public void SetSilencedToTagged(){} // RVA: 0x9A6D690
        public void SetSilencedToUntagged(){} // RVA: 0x9A6D740
        public void SetRunSpeed(){} // RVA: 0x9A6D7F0
        public void SetWalkSpeed(){} // RVA: 0x9A6D880
        public void SetStrafeSpeed(){} // RVA: 0x9A6D910
        public void SetJumpImpulse(){} // RVA: 0x9A6D9A0
        public void GetGravityStrength(){} // RVA: 0x9A6DA30
        public void GetRunSpeed(){} // RVA: 0x9A6DAB0
        public void GetWalkSpeed(){} // RVA: 0x9A6DB30
        public void GetStrafeSpeed(){} // RVA: 0x9A6DBB0
        public void GetJumpImpulse(){} // RVA: 0x9A6DC30
        public void IsUserInVR(){} // RVA: 0x9A6DCB0
        public void SetGravityStrength(){} // RVA: 0x9A6DD30
        public void UseLegacyLocomotion(){} // RVA: 0x9A6DDC0
        public void UseAttachedStation(){} // RVA: 0x9A6DE40
        public void ClearInvisible(){} // RVA: 0x9A6DEC0
        public void ClearSilence(){} // RVA: 0x9A6DF40
        public void AddToList(){} // RVA: 0x9A6DFC0
        public void RemoveFromList(){} // RVA: 0x9A6E050
        public void CombatSetup(){} // RVA: 0x9A6E0E0
        public void CombatSetMaxHitpoints(){} // RVA: 0x9A6E160
        public void CombatSetCurrentHitpoints(){} // RVA: 0x9A6E1F0
        public void CombatGetCurrentHitpoints(){} // RVA: 0x9A6E280
        public void CombatSetRespawn(){} // RVA: 0x9A6E300
        public void CombatSetDamageGraphic(){} // RVA: 0x9A6E3C0
        public void CombatGetDestructible(){} // RVA: 0x9A6E450
        public void SetVoiceGain(){} // RVA: 0x9A6E4D0
        public void GetVoiceGain(){} // RVA: 0x9A6E560
        public void SetVoiceDistanceNear(){} // RVA: 0x9A6E5E0
        public void GetVoiceDistanceNear(){} // RVA: 0x9A6E670
        public void SetVoiceDistanceFar(){} // RVA: 0x9A6E6F0
        public void GetVoiceDistanceFar(){} // RVA: 0x9A6E780
        public void SetVoiceVolumetricRadius(){} // RVA: 0x9A6E800
        public void GetVoiceVolumetricRadius(){} // RVA: 0x9A6E890
        public void SetVoiceLowpass(){} // RVA: 0x9A6E910
        public void GetVoiceLowpass(){} // RVA: 0x9A6E9A0
        public void SetAvatarAudioGain(){} // RVA: 0x9A6EA20
        public void SetAvatarAudioFarRadius(){} // RVA: 0x9A6EAB0
        public void SetAvatarAudioNearRadius(){} // RVA: 0x9A6EB40
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x9A6EBD0
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x9A6EC60
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x9A6ECF0
        public void GetAvailableLanguages(){} // RVA: 0x9A6ED80
        public void GetCurrentLanguage(){} // RVA: 0x9A6EDF0
        public void GetPlayerObjects(){} // RVA: 0x9A6EE60
        public void FindComponentInPlayerObjects(){} // RVA: 0x9A6EF00
        public void PushAnimations(){} // RVA: 0x9A6EF10
        public void PopAnimations(){} // RVA: 0x9A6EFA0
        public void Immobilize(){} // RVA: 0x9A6F020
        public void SetVelocity(){} // RVA: 0x9A6F0B0
        public void GetVelocity(){} // RVA: 0x9A6F150
        public void GetPosition(){} // RVA: 0x9A6F1F0
        public void GetRotation(){} // RVA: 0x9A6F290
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x9A6F330
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x9A6F3B0
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x9A6F430
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x9A6F4B0
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x9A6F530
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x9A6F5C0
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x9A6F650
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x9A6F6E0
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x9A6F770
        public void .ctor(){} // RVA: 0x9A6F800
        public void .cctor(){} // RVA: 0x9A6F890
    }

    public class VRCRenderTexture
    {
        // ── Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0x9A7DFB0
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0x9A7E0E0
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0x9A7E210
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0x9A7E350
        public void GetTemporary(){} // RVA: 0x9A7E570 | overloaded x2
        public void ReleaseTemporary(){} // RVA: 0x9A7E600
    }

    public class VRCShader
    {
        // ── Methods ──
        public void add_OnSetGlobalShaderVariable(){} // RVA: 0x9A7E6A0
        public void remove_OnSetGlobalShaderVariable(){} // RVA: 0x9A7E800
        public void PropertyToID(){} // RVA: 0x9A7E960
        public void SetGlobalInteger(){} // RVA: 0x9A7EC30
        public void SetGlobalFloat(){} // RVA: 0x9A7ED00
        public void SetGlobalTexture(){} // RVA: 0x9A7EDD0
        public void SetGlobalColor(){} // RVA: 0x9A7EEA0
        public void SetGlobalVector(){} // RVA: 0x9A7EFB0
        public void SetGlobalMatrix(){} // RVA: 0x9A7F090
        public void SetGlobalFloatArray(){} // RVA: 0x9A7F180
        public void SetGlobalVectorArray(){} // RVA: 0x9A7F220
        public void SetGlobalMatrixArray(){} // RVA: 0x9A7F2C0
        public void ValidateAgainstPropertyIDWhitelist(){} // RVA: 0x9A7F360
        public void ClearGlobalVariableWhitelist(){} // RVA: 0x9A7F470
        public void .cctor(){} // RVA: 0x9A7F530
    }

    public class VRCStation
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A7F990
        public void UseStation(){} // RVA: 0x9A7F9F0
        public void ExitStation(){} // RVA: 0x9A7FA60
        public void .ctor(){} // RVA: 0x99F3570
    }

    public class VRCTriggerRelay
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A973D0
        public void OnTriggerEnter(){} // RVA: 0x9A97430
        public void OnTriggerExit(){} // RVA: 0x9A974C0
        public void .ctor(){} // RVA: 0x9A97540
    }

    public class VRCUrl
    {
        // ── Methods ──
        public void get_Empty(){} // RVA: 0x9A97700
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x9A97760
        public void IsNullOrEmpty(){} // RVA: 0x9A979F0
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x9A97A90
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x9A97AF0
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x9A97BB0
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x9A97C10
        public void IsAllowlistedUri(){} // RVA: 0x9A97CD0
        public void .ctor(){} // RVA: 0x9A97F30
        public void Get(){} // RVA: 0x2F8380
        public void ToString(){} // RVA: 0x2F8380
        public void Equals(){} // RVA: 0x9A98110 | overloaded x2
        public void GetHashCode(){} // RVA: 0x64A3790
        public void .cctor(){} // RVA: 0x9A98160
    }

    public class VRC_AnimatorLayerControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A719C0
        public void OnStateEnter(){} // RVA: 0x57231E0
        public void .ctor(){} // RVA: 0x9A21B50
    }

    public class VRC_AnimatorLocomotionControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A71A20
        public void OnStateEnter(){} // RVA: 0x66F0670
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class VRC_AnimatorPlayAudio
    {
        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x9A71A80
        public void get_ShouldApplyPitch(){} // RVA: 0x9A71A90
        public void get_ShouldApplyClip(){} // RVA: 0x9A71AA0
        public void get_ShouldApplyLoop(){} // RVA: 0x9A71AB0
        public void ShouldApplySetting(){} // RVA: 0x9A71AC0
        public void Awake(){} // RVA: 0x9A71B40
        public void OnStateEnter(){} // RVA: 0x9A71BA0
        public void OnStateExit(){} // RVA: 0x9A71BC0
        public void .ctor(){} // RVA: 0x9A21B60
    }

    public class VRC_AnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A71BF0
        public void OnStateEnter(){} // RVA: 0x9A71C50
        public void OnStateUpdate(){} // RVA: 0x9A71CE0
        public void .ctor(){} // RVA: 0x9A21BB0
    }

    public class VRC_AnimatorTrackingControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A71D80
        public void OnStateEnter(){} // RVA: 0x6C4C210
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class VRC_AvatarDescriptor
    {
        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x9A71DE0
        public void PositionPortraitCamera(){} // RVA: 0x9A72120
        public void get_NetworkIDCollection(){} // RVA: 0x348040
        public void set_NetworkIDCollection(){} // RVA: 0x348050
        public void GetNetworkIDObjects(){} // RVA: 0x9A725B0
        public void FindNetworkIDGameObject(){} // RVA: 0x9A72650
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x9A72970
        public void .ctor(){} // RVA: 0x9A729F0
    }

    public class VRC_AvatarParameterDriver
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x9A72CD0
        public void .ctor(){} // RVA: 0x9A26390
    }

    public class VRC_AvatarPedestal
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A77CD0
        public void SwitchAvatar(){} // RVA: 0x9A3AE20 | overloaded x2
        public void SetAvatarUse(){} // RVA: 0x9A781E0
        public void .ctor(){} // RVA: 0x9A78320
    }

    public class VRC_DataStorage
    {
        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0x9A985B0
        public void GetElement(){} // RVA: 0x9A98620
        public void add_ElementChanged(){} // RVA: 0x9A986B0
        public void remove_ElementChanged(){} // RVA: 0x9A987A0
        public void OnDataElementChanged(){} // RVA: 0x9A98890
        public void Awake(){} // RVA: 0x9A988C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_DestructibleStandard
    {
        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0x306080
        public void GetCurrentHealth(){} // RVA: 0x44AF50
        public void Awake(){} // RVA: 0x9A74390
        public void ApplyDamage(){} // RVA: 0x9A74570
        public void ApplyHealing(){} // RVA: 0x9A74B00
        public void GetState(){} // RVA: 0x9A750E0
        public void SetState(){} // RVA: 0x9A751B0
        public void HandleCallbackTrigger(){} // RVA: 0x9A75230
        public void .ctor(){} // RVA: 0x99E7D10
        public void <ApplyDamage>b__27_0(){} // RVA: 0x9A73660
        public void <ApplyDamage>b__27_1(){} // RVA: 0x9A75370
        public void <ApplyHealing>b__28_0(){} // RVA: 0x9A75370
        public void <ApplyHealing>b__28_1(){} // RVA: 0x9A753D0
    }

    public class VRC_EventDispatcher
    {
        // ── Methods ──
        public void TriggerEvent(){}
        public void RegisterEventHandler(){} // RVA: 0x24B10
        public void UnregisterEventHandler(){} // RVA: 0x24B10
        public void FindGameObject(){} // RVA: 0x1D640 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A76100
        public void TriggerEvent(){} // RVA: 0x2DD310
        public void RegisterEventHandler(){} // RVA: 0x2DD310
        public void UnregisterEventHandler(){} // RVA: 0x2DD310
        public void FindGameObject(){} // RVA: 0x9A76150
        public void GetGameObjectPath(){} // RVA: 0x9A761A0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_EventHandler
    {
        // ── Methods ──
        public void BooleanOp(){} // RVA: 0x9A989B0
        public void get_Dispatcher(){} // RVA: 0x9A989D0
        public void get_GetInsitgatorId(){} // RVA: 0x9A98AF0
        public void set_GetInsitgatorId(){} // RVA: 0x9A98B30
        public void Awake(){} // RVA: 0x9A98BD0
        public void VrcAnimationEvent(){} // RVA: 0x9A98F70
        public void IsReceiverRequiredForEventType(){} // RVA: 0x9A99160
        public void TriggerEvent(){} // RVA: 0x9A9A1B0 | overloaded x4
        public void InternalTriggerEvent(){} // RVA: 0x9A99C20
        public void OnValidate(){} // RVA: 0x9A9A3A0
        public void OnDestroy(){} // RVA: 0x9A9A500
        public void GetCombinedNetworkId(){} // RVA: 0x519240
        public void HasEventTrigger(){} // RVA: 0x9A9A670
        public void IsReadyForEvents(){} // RVA: 0x3C2850
        public void DeferEvent(){} // RVA: 0x9A9A770
        public void ProcessDeferredEvents(){} // RVA: 0x9A9AA60
        public void .ctor(){} // RVA: 0x9A9AB00
    }

    public class VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E8340
    }

    public class VRC_IKFollower
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A9B560
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Interactable
    {
        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0x2DD320
        public void get_Proximity(){} // RVA: 0x4FE250
        public void Start(){} // RVA: 0x2DD310
        public void Awake(){} // RVA: 0x9A9B8D0
        public void Interact(){} // RVA: 0x24A50
        public void OnPickupUseUp(){} // RVA: 0x2DD310
        public void OnPickupUseDown(){} // RVA: 0x2DD310
        public void OnPickup(){} // RVA: 0x2DD310
        public void OnDrop(){} // RVA: 0x2DD310
        public void IsInteractiveForPlayer(){} // RVA: 0x9A9B930
        public void .ctor(){} // RVA: 0x9A9B9D0
    }

    public class VRC_KeyEvents
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A72D50
        public void Update(){} // RVA: 0x9A72FB0
        public void .ctor(){} // RVA: 0x2DDD50
        public void <Update>b__9_0(){} // RVA: 0x9A73600
        public void <Update>b__9_2(){} // RVA: 0x9A73600
        public void <Update>b__9_1(){} // RVA: 0x9A73660
        public void <Update>b__9_3(){} // RVA: 0x9A73660
    }

    public class VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F6000
    }

    public class VRC_MetadataListener
    {
        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0x9A7FAD0
        public void Awake(){} // RVA: 0x9A7FB30
        public void OnDestroy(){} // RVA: 0x9A7FCA0
        public void TriggerUpdate(){} // RVA: 0x9A7FE10
        public void MetadataChangedInternal(){} // RVA: 0x9A7FE70
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_MidiNoteIn
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A778D0
        public void Start(){} // RVA: 0x2DD310
        public void Update(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_MirrorReflection
    {
        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x9A7FE90
        public void remove_PreRenderMirror(){} // RVA: 0x9A7FFE0
        public void add_PostRenderMirror(){} // RVA: 0x9A80130
        public void remove_PostRenderMirror(){} // RVA: 0x9A80280
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x9A803D0
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x9A80430
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x9A804F0
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x9A80560
        public void OnValidate(){} // RVA: 0x9A805D0
        public void Start(){} // RVA: 0x9A80630
        public void TrySetupMaterial(){} // RVA: 0x9A808F0
        public void IsVisibleToCamera(){} // RVA: 0x9A80E40
        public void IsLayerRendered(){} // RVA: 0x9A81040
        public void CameraOnPreCull(){} // RVA: 0x9A810C0
        public void RenderMirrorCameras(){} // RVA: 0x9A81540
        public void CameraPostRender(){} // RVA: 0x9A827E0
        public void OnEnable(){} // RVA: 0x9A82AE0
        public void OnDisable(){} // RVA: 0x9A82D90
        public void OnDestroy(){} // RVA: 0x9A834A0
        public void ShouldRenderLeftEye(){} // RVA: 0x9A837F0
        public void ShouldRenderRightEye(){} // RVA: 0x9A83A00
        public void ShouldRenderMonoscopic(){} // RVA: 0x9A83C10
        public void GetWorldEyePos(){} // RVA: 0x9A83E70
        public void GetWorldEyeRot(){} // RVA: 0x9A83FA0
        public void GetEyeProjectionMatrix(){} // RVA: 0x9A84190
        public void GetNormalDirection(){} // RVA: 0x9A84260
        public void RenderMirror(){} // RVA: 0x9A84310
        public void UpdateCameraClearing(){} // RVA: 0x9A85030
        public void UpdateCameraModes(){} // RVA: 0x9A85410
        public void UpdateParentTransform(){} // RVA: 0x9A85D80
        public void GetReflectionData(){} // RVA: 0x9A866F0
        public void GetAutoResolution(){} // RVA: 0x9A871E0
        public void Plane(){} // RVA: 0x9A873D0
        public void CameraSpacePlane(){} // RVA: 0x9A87430
        public void CalculateReflectionMatrix(){} // RVA: 0x9A87840
        public void CopySign(){} // RVA: 0x9A879B0
        public void GetRotation(){} // RVA: 0x9A879E0
        public void GetPosition(){} // RVA: 0x649D830
        public void .ctor(){} // RVA: 0x9A87C20
        public void .cctor(){} // RVA: 0x9A87D30
    }

    public class VRC_NPCSpawn
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A783E0
        public void .ctor(){} // RVA: 0x99E8EA0
    }

    public class VRC_NpcApi
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A736C0
        public void GetApiByGameObject(){} // RVA: 0x9A73720
        public void ActThis(){} // RVA: 0x9A73830
        public void SayThis(){} // RVA: 0x9A738C0
        public void SetNamePlate(){} // RVA: 0x9A73950
        public void SetSocialStatus(){} // RVA: 0x9A739F0
        public void SetMuteStatus(){} // RVA: 0x9A73A90
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_ObjectApi
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_ObjectSpawn
    {
        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x9A786A0 | overloaded x2
        public void DestroySpawnedObjects(){} // RVA: 0x1E2B0D0
        public void Start(){} // RVA: 0x9A787C0
        public void ProvideEvents(){} // RVA: 0x9A78820
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_OscButtonIn
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A77930
        public void Start(){} // RVA: 0x2DD310
        public void Update(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Panorama
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A87F40
        public void Update(){} // RVA: 0x9A88110
        public void NextPano(){} // RVA: 0x9A883E0
        public void PrevPano(){} // RVA: 0x9A884A0
        public void ShowPanoAt(){} // RVA: 0x9A88560
        public void ShowPano(){} // RVA: 0x9A885F0
        public void .ctor(){} // RVA: 0x99F60D0
    }

    public class VRC_PhysicsRoot
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A73B20
        public void OnDestroy(){} // RVA: 0x9A74150
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_Pickup
    {
        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x9A78E30 | overloaded x2
        public void get_currentPlayer(){} // RVA: 0x9A78E60
        public void get_IsHeld(){} // RVA: 0x9A78ED0
        public void get_currentHand(){} // RVA: 0x9A78F90
        public void get_Proximity(){} // RVA: 0x9A78FF0
        public void Awake(){} // RVA: 0x9A79000
        public void OnDisable(){} // RVA: 0x9A79060
        public void Reset(){} // RVA: 0x9A790A0
        public void Drop(){} // RVA: 0x9A79230 | overloaded x2
        public void GenerateHapticEvent(){} // RVA: 0x9A79490
        public void OnDestroy(){} // RVA: 0x9A79530
        public void PlayHaptics(){} // RVA: 0x9A79590
        public void ProvideEvents(){} // RVA: 0x9A795C0
        public void .ctor(){} // RVA: 0x9A79A00
    }

    public class VRC_PlayableLayerControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A74270
        public void OnStateEnter(){} // RVA: 0x9A742D0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class VRC_PortalMarker
    {
        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x48EC40
        public void Awake(){} // RVA: 0x9A79DB0
        public void Update(){} // RVA: 0x9A79E30
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
        public void Awake(){} // RVA: 0x9A79EB0
        public void Update(){} // RVA: 0x9A79F10
        public void GetInputIndex(){} // RVA: 0x9A79F80
        public void .ctor(){} // RVA: 0x99EA5F0
    }

    public class VRC_PropDescriptor : NetworkIDLookup
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A7A080
        public void get_NetworkIDCollection(){} // RVA: 0x35A740
        public void set_NetworkIDCollection(){} // RVA: 0x305200
        public void get_NetworkIDLookup(){} // RVA: 0x358730
        public void set_NetworkIDLookup(){} // RVA: 0x358740
        public void GetNetworkIDObjects(){} // RVA: 0x9A7AAB0
        public void FindNetworkIDGameObject(){} // RVA: 0x9A7AB50
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x9A72970
        public void .ctor(){} // RVA: 0x9A7AE70
    }

    public class VRC_SceneDescriptor
    {
        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0x9A88E50
        public void GetPrefab(){} // RVA: 0x9A89040
        public void GetMaterial(){} // RVA: 0x9A89430
        public void get_NetworkIDCollection(){} // RVA: 0xD9ABC0
        public void set_NetworkIDCollection(){} // RVA: 0xD9A380
        public void get_NetworkIDLookup(){} // RVA: 0x8CBA20
        public void set_NetworkIDLookup(){} // RVA: 0xDB44F0
        public void GetNetworkIDObjects(){} // RVA: 0x9A89820
        public void FindNetworkIDGameObject(){} // RVA: 0x9A89B10
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x9A72970
        public void get_Instance(){} // RVA: 0x9A8A070
        public void get_Exists(){} // RVA: 0x9A8A380
        public void get_BundleUnityMajorVersion(){} // RVA: 0x9A8A480
        public void set_BundleUnityMajorVersion(){} // RVA: 0x9A8A490
        public void get_Scene(){} // RVA: 0x1C9AB70
        public void set_Scene(){} // RVA: 0x1C9AB80
        public void Awake(){} // RVA: 0x9A8A4A0
        public void OnDestroy(){} // RVA: 0x9A8B470
        public void PositionPortraitCamera(){} // RVA: 0x9A8B530
        public void .ctor(){} // RVA: 0x9A8B900
        public void .cctor(){} // RVA: 0x9A8BC30
    }

    public class VRC_Serialization
    {
        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x9A9BA90
        public void set_AllowPluginTypes(){} // RVA: 0x9A9BAF0
        public void get_SurrogateSelector(){} // RVA: 0x9A9BB50
        public void RegisterPluginType(){} // RVA: 0x9A9BC60
        public void RegisterType(){} // RVA: 0x9A9BD50
        public void ParameterEncoder(){} // RVA: 0x9A9BE40
        public void ParameterDecoder(){} // RVA: 0x9A9C050
        public void get_Dispatcher(){} // RVA: 0x9A9C2C0
        public void GetGameObjectPathFallback(){} // RVA: 0x9A9C400
        public void GetGameObjectPath(){} // RVA: 0x9A9C670
        public void FindGameObject(){} // RVA: 0x9A9C7B0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9A9C910
    }

    public class VRC_SlideShow
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A7B090
        public void ShowNextImage(){} // RVA: 0x9A7B150
        public void ShowPreviousImage(){} // RVA: 0x9A7B370
        public void StartAutoplayWithDuration(){} // RVA: 0x9A7B540
        public void StopAutoplayWithDuration(){} // RVA: 0x9A7B600
        public void .ctor(){} // RVA: 0x99EA6F0
    }

    public class VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A6B440
        public void OnDrawGizmosSelected(){} // RVA: 0x9A6B6E0
        public void .ctor(){} // RVA: 0x99E6D70
    }

    public class VRC_SpecialLayer
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x9A8BF20
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_TimedEvents
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A8C150
        public void OnEnable(){} // RVA: 0x9A8C320
        public void Update(){} // RVA: 0x9A8C330
        public void ResetClock(){} // RVA: 0x9A8C4C0
        public void .ctor(){} // RVA: 0x99F3630
    }

    public class VRC_Trigger
    {
        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0x9A8C7D0 | overloaded x2
        public void Trigger(){} // RVA: 0x9A8C640
        public void get_HasKeyTriggers(){} // RVA: 0x9A8C960
        public void get_HasTimerTriggers(){} // RVA: 0x9A8CAD0
        public void get_HasColliderTriggers(){} // RVA: 0x9A8CC40
        public void get_HasInteractiveTriggers(){} // RVA: 0x9A8CEE0
        public void get_HasPickupTriggers(){} // RVA: 0x9A8D050
        public void get_IsInteractive(){} // RVA: 0x9A8D1C0
        public void Awake(){} // RVA: 0x9A8D4A0
        public void OnDestroy(){} // RVA: 0x9A8D550
        public void OnEnable(){} // RVA: 0x9A8D560
        public void OnDisable(){} // RVA: 0x9A8D590
        public void OnDrawGizmosSelected(){} // RVA: 0x9A8D5C0
        public void Interact(){} // RVA: 0x9A8DB70
        public void OnPickupUseUp(){} // RVA: 0x9A8DB80
        public void OnPickupUseDown(){} // RVA: 0x9A8DB90
        public void OnPickup(){} // RVA: 0x9A8DBA0
        public void OnDrop(){} // RVA: 0x9A8DBB0
        public void ExecuteTriggers(){} // RVA: 0x9A8DBC0
        public void ExecuteTriggerType(){} // RVA: 0x9A8DEC0
        public void ExecuteCustomTrigger(){} // RVA: 0x9A8E220
        public void ResetClocks(){} // RVA: 0x9A8E610
        public void ResetClock(){} // RVA: 0x9A8E980
        public void .ctor(){} // RVA: 0x99F3690
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x9A8EA10
    }

    public class VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x9A8F9C0
        public void OnTriggerEnter(){} // RVA: 0x9A8FB80
        public void OnTriggerExit(){} // RVA: 0x9A8FCC0
        public void .ctor(){} // RVA: 0x99F3760
    }

    public class VRC_TutorialAction
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x9A95260
        public void ActivateObjectLabel(){} // RVA: 0x9A95460 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x9A954F0
        public void ActivateControllerLabel(){} // RVA: 0x9A95550
        public void DeactivateControllerLabel(){} // RVA: 0x9A95580
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void Enable(){} // RVA: 0x5AC2490
        public void Update(){} // RVA: 0x9A95590
        public void ShowLabel(){} // RVA: 0x9A959C0
        public void .ctor(){} // RVA: 0x99F3B20
    }

    public class VRC_UiShape
    {
        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0x30B0C0
        public void set_RootCanvas(){} // RVA: 0x30B0D0
        public void get_RootCanvasRectTransform(){} // RVA: 0x30B130
        public void set_RootCanvasRectTransform(){} // RVA: 0x2DEE90
        public void add_OnUiShapeInit(){} // RVA: 0x9A96540
        public void remove_OnUiShapeInit(){} // RVA: 0x9A96680
        public void add_OnUiShapeDestroy(){} // RVA: 0x9A967C0
        public void remove_OnUiShapeDestroy(){} // RVA: 0x9A96900
        public void Awake(){} // RVA: 0x9A96A40
        public void Start(){} // RVA: 0x9A96BE0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x9A96F40
        public void SetupCollision(){} // RVA: 0x9A96F50
        public void OnDestroy(){} // RVA: 0x9A97370
        public void .ctor(){} // RVA: 0x391710
    }

    public class VRC_UseEvents : ؄}e
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A8FE00
        public void Start(){} // RVA: 0x9A90040
        public void Interact(){} // RVA: 0x9A902D0
        public void .ctor(){} // RVA: 0x99F37B0
        public void <Awake>b__5_0(){} // RVA: 0x9A904B0
    }

    public class VRC_VisualDamage
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A75430
        public void Start(){} // RVA: 0x9A754C0
        public void OnSceneWasLoaded(){} // RVA: 0x9A756F0
        public void Update(){} // RVA: 0x9A75790
        public void HideDamageIndicator(){} // RVA: 0x9A759C0
        public void ShowDamageIndicator(){} // RVA: 0x9A75AE0
        public void SetDamagePercent(){} // RVA: 0x9A75C00
        public void .ctor(){} // RVA: 0x9A75F00
    }

    public class VRC_Water
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x9A905C0
        public void OnDisable(){} // RVA: 0x9A912A0
        public void Update(){} // RVA: 0x9A918F0
        public void UpdateCameraModes(){} // RVA: 0x9A91DC0
        public void CreateWaterObjects(){} // RVA: 0x9A92340
        public void GetWaterMode(){} // RVA: 0x9A93700
        public void FindHardwareWaterSupport(){} // RVA: 0x9A93710
        public void CameraSpacePlane(){} // RVA: 0x2F4D00
        public void CalculateReflectionMatrix(){} // RVA: 0x2F50F0
        public void .ctor(){} // RVA: 0x99F3850
    }

    public class VRC_WebPanel : ؄}e
    {
        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0x9A93A00
        public void WebPanelBackward(){} // RVA: 0x9A93A30
        public void WebPanelReload(){} // RVA: 0x9A93A60
        public void BindCall(){} // RVA: 0x9A93A90
        public void NavigateTo(){} // RVA: 0x9A93AC0
        public void Awake(){} // RVA: 0x9A93AF0
        public void Interact(){} // RVA: 0x2DD310
        public void get_WebRootPath(){} // RVA: 0x9A93C00
        public void ProvideEvents(){} // RVA: 0x9A93D70
        public void ReadData(){} // RVA: 0x9A946A0
        public void ImportWebData(){} // RVA: 0x9A94900
        public void .ctor(){} // RVA: 0x99F39F0
    }

    public class VersionHelper
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0x283FA0
    }

}