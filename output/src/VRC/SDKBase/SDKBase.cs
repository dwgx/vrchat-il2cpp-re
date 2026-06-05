// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 78
// Methods: 662

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        // ── Methods ──
        public void get_boolVal(){} // RVA: 0x7FFAF2ABDBE0
        public void set_boolVal(){} // RVA: 0x7FFAF2AD5130
        public void get_intVal(){} // RVA: 0x7FFAF2ABD840
        public void set_intVal(){} // RVA: 0x7FFAF2AD4FA0
        public void get_floatVal(){} // RVA: 0x7FFAF2AD1890
        public void set_floatVal(){} // RVA: 0x7FFAF2AE25B0
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
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAF2ABCD60
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAF2AD4B10
        public void GetNetworkIDObjects(){} // RVA: 0x7FFAF2AD4B10
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFAF2ACD640
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class IPreprocessCallbackBehaviour
    {
        // ── Methods ──
        public void OnPreprocess(){} // RVA: 0x7FFAF2ABDBE0
        public void get_PreprocessOrder(){} // RVA: 0x7FFAF2ABD840
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0x7FFAF2ABCD60
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
        public void GetState(){} // RVA: 0x7FFAF2ABCD60
        public void SetState(){} // RVA: 0x7FFAF2AD4B10
        public void GetMaxHealth(){} // RVA: 0x7FFAF2AD1890
        public void GetCurrentHealth(){} // RVA: 0x7FFAF2AD1890
        public void ApplyDamage(){} // RVA: 0x7FFAF2AE25B0
        public void ApplyHealing(){} // RVA: 0x7FFAF2AE25B0
    }

    public class IValidChecker
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class InputManager
    {
        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0x7FFAFC54B5C0
        public void GetLastUsedInputMethod(){} // RVA: 0x7FFAFC54B620
        public void GetBoolInputSetting(){} // RVA: 0x7FFAFC54B690
        public void SetBoolInputSetting(){} // RVA: 0x7FFAFC54B6F0
        public void EnableObjectHighlight(){} // RVA: 0x7FFAFC54B860 | overloaded x2
    }

    public class MathUtil
    {
        // ── Methods ──
        public void AngleBetweenTwoUnitVectors(){} // RVA: 0x7FFAFC527990
        public void AngleClosestBetweenTwoUnitVectors(){} // RVA: 0x7FFAFBED1570
        public void ClosestPointOnLineSegment_Value(){} // RVA: 0x7FFAFC527B70
        public void ClosestPointOnLineSegment(){} // RVA: 0x7FFAFBED1710
        public void ClosestPointOnPlane(){} // RVA: 0x7FFAFBED1830
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC527C40
    }

    public class Networking
    {
        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x7FFAFC526840
        public void get_IsNetworkSettled(){} // RVA: 0x7FFAFC5268A0
        public void get_IsMaster(){} // RVA: 0x7FFAFC526900
        public void get_IsClogged(){} // RVA: 0x7FFAFC526960
        public void get_IsInstanceOwner(){} // RVA: 0x7FFAFC5269C0
        public void get_LocalPlayer(){} // RVA: 0x7FFAFC526A20
        public void get_Master(){} // RVA: 0x7FFAFC526A80
        public void get_InstanceOwner(){} // RVA: 0x7FFAFC526AE0
        public void IsOwner(){} // RVA: 0x7FFAFC526BC0 | overloaded x2
        public void GetOwner(){} // RVA: 0x7FFAFC526C80
        public void SetOwner(){} // RVA: 0x7FFAFC526CF0
        public void IsObjectReady(){} // RVA: 0x7FFAFC526D60
        public void Instantiate(){} // RVA: 0x7FFAFC526DD0
        public void RPC(){} // RVA: 0x7FFAFC526F20 | overloaded x2
        public void EncodeParameters(){} // RVA: 0x7FFAFC526FC0
        public void DecodeParameters(){} // RVA: 0x7FFAFC527030
        public void Destroy(){} // RVA: 0x7FFAFC5270A0
        public void GetUniqueName(){} // RVA: 0x7FFAFC527110
        public void GoToRoom(){} // RVA: 0x7FFAFC527180
        public void GetNetworkDateTime(){} // RVA: 0x7FFAFC5271F0
        public void GetServerTimeInSeconds(){} // RVA: 0x7FFAFC527290
        public void GetServerTimeInMilliseconds(){} // RVA: 0x7FFAFC527340
        public void CalculateServerDeltaTime(){} // RVA: 0x7FFAFC5273F0
        public void SafeStartCoroutine(){} // RVA: 0x7FFAFC527480
        public void GetEventDispatcher(){} // RVA: 0x7FFAFC5274F0
        public void SimulationTime(){} // RVA: 0x7FFAFC527600 | overloaded x2
        public void RequestStorageUsageUpdate(){} // RVA: 0x7FFAFA4B0240
        public void GetPlayerObjects(){} // RVA: 0x7FFAFC51EE60
        public void GetPlayerDataStorageLimit(){} // RVA: 0x7FFAFC5276B0
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x7FFAFC527710
        public void GetPlayerDataStorageUsage(){} // RVA: 0x7FFAFC527770
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x7FFAFC5277E0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFAFC527850
    }

    public class RPC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC526460 | overloaded x4
        public void SetupTargets(){} // RVA: 0x7FFAFC526480
    }

    public class RPCIgnoredType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Tutorial
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFAFC545AF0
        public void ActivateObjectLabel(){} // RVA: 0x7FFAFC545D00 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFAFC545DF0
        public void ActivateControllerLabel(){} // RVA: 0x7FFAFC545E50
        public void DeactivateControllerLabel(){} // RVA: 0x7FFAFC545EF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Utilities
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAFC5537D0
        public void ShuffleArray(){} // RVA: 0x7FFAFC553930 | overloaded x2
        public void IsClient(){} // RVA: 0x7FFAFC553A30
        public void SetIsClient(){} // RVA: 0x7FFAFC553A70
        public void Fletcher32Fast(){} // RVA: 0x7FFAFC553AB0
    }

    public class VRCBuiltInShaderGlobals
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAFC52B7E0
        public void set_Instance(){} // RVA: 0x7FFAFC52B840
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFAF2DBB0C0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFAF2DBB0D0
        public void Update(){} // RVA: 0x7FFAFC52B900
        public void OnDestroy(){} // RVA: 0x7FFAFC52BFA0
        public void Initialize(){} // RVA: 0x7FFAFC52C290
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void .cctor(){} // RVA: 0x7FFAFC52C6D0
    }

    public class VRCCustomAction
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAFC52F8D0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCDroneApi
    {
        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x7FFAFC526020
        public void GetPlayer(){} // RVA: 0x7FFAF2ABCD60
        public void IsDeployed(){} // RVA: 0x7FFAF2ABDBE0
        public void TryGetPosition(){} // RVA: 0x7FFAF2ABDE40
        public void GetPosition(){} // RVA: 0x7FFAF2ABC770
        public void TryGetRotation(){} // RVA: 0x7FFAF2ABDE40
        public void GetRotation(){} // RVA: 0x7FFAF2ABC770
        public void TryGetVelocity(){} // RVA: 0x7FFAF2ABDE40
        public void GetVelocity(){} // RVA: 0x7FFAF2ABC770
        public void TeleportTo(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void SetVelocity(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class VRCGraphics
    {
        // ── Methods ──
        public void get_UiLayerMask(){} // RVA: 0x7FFAFC52CBD0
        public void Blit(){} // RVA: 0x7FFAFC52D1A0 | overloaded x7
        public void DrawMeshInstanced(){} // RVA: 0x7FFAFC52DB30 | overloaded x9
        public void GetLayerMask(){} // RVA: 0x7FFAFC52DC90
        public void CheckBlitTarget(){} // RVA: 0x7FFAFC52DCA0
        public void .cctor(){} // RVA: 0x7FFAFC52DDB0
    }

    public class VRCPlayerApi
    {
        // ── Methods ──
        public void get_isMaster(){} // RVA: 0x7FFAFC51BF30
        public void get_isInstanceOwner(){} // RVA: 0x7FFAFC51BFB0
        public void get_isModerator(){} // RVA: 0x7FFAFC51C030
        public void get_isSuper(){} // RVA: 0x7FFAFC51C0B0
        public void get_isSuspended(){} // RVA: 0x7FFAFC51C130
        public void get_isVRCPlus(){} // RVA: 0x7FFAFC51C1B0
        public void IsPlayerGrounded(){} // RVA: 0x7FFAFC51C230
        public void GetDrone(){} // RVA: 0x7FFAFC51C2D0
        public void get_AllPlayers(){} // RVA: 0x7FFAFC51C350
        public void GetPlayers(){} // RVA: 0x7FFAFC51C460 | overloaded x2
        public void GetPlayerCount(){} // RVA: 0x7FFAFC51C500
        public void GetPlayerId(){} // RVA: 0x7FFAFC51C580
        public void get_playerId(){} // RVA: 0x7FFAFC51C600
        public void GetPlayerByGameObject(){} // RVA: 0x7FFAFC51C660
        public void GetPlayerById(){} // RVA: 0x7FFAFC51C6E0
        public void IsValid(){} // RVA: 0x7FFAF2DB3450
        public void IsOwner(){} // RVA: 0x7FFAFC51C760
        public void TakeOwnership(){} // RVA: 0x7FFAFC51C7F0
        public void GetTrackingData(){} // RVA: 0x7FFAFC51C880
        public void GetBoneTransform(){} // RVA: 0x7FFAFC51C940
        public void GetBonePosition(){} // RVA: 0x7FFAFC51C9D0
        public void GetBoneRotation(){} // RVA: 0x7FFAFC51CA90
        public void GetPickupInHand(){} // RVA: 0x7FFAFC51CB40
        public void SetPickupInHand(){} // RVA: 0x7FFAF2D8D310
        public void PlayHapticEventInHand(){} // RVA: 0x7FFAFC51CBD0
        public void TeleportTo(){} // RVA: 0x7FFAFC51CE90 | overloaded x3
        public void Respawn(){} // RVA: 0x7FFAFC51D010 | overloaded x2
        public void EnablePickups(){} // RVA: 0x7FFAFC51D0A0
        public void SetNamePlateColor(){} // RVA: 0x7FFAFC51D130
        public void RestoreNamePlateColor(){} // RVA: 0x7FFAFC51D1D0
        public void SetNamePlateVisibility(){} // RVA: 0x7FFAFC51D250
        public void RestoreNamePlateVisibility(){} // RVA: 0x7FFAFC51D2E0
        public void SetPlayerTag(){} // RVA: 0x7FFAFC51D360
        public void GetPlayerTag(){} // RVA: 0x7FFAFC51D400
        public void GetPlayersWithTag(){} // RVA: 0x7FFAF2FC9240
        public void ClearPlayerTags(){} // RVA: 0x7FFAFC51D490
        public void SetInvisibleToTagged(){} // RVA: 0x7FFAFC51D510
        public void SetInvisibleToUntagged(){} // RVA: 0x7FFAFC51D5D0
        public void SetSilencedToTagged(){} // RVA: 0x7FFAFC51D690
        public void SetSilencedToUntagged(){} // RVA: 0x7FFAFC51D740
        public void SetRunSpeed(){} // RVA: 0x7FFAFC51D7F0
        public void SetWalkSpeed(){} // RVA: 0x7FFAFC51D880
        public void SetStrafeSpeed(){} // RVA: 0x7FFAFC51D910
        public void SetJumpImpulse(){} // RVA: 0x7FFAFC51D9A0
        public void GetGravityStrength(){} // RVA: 0x7FFAFC51DA30
        public void GetRunSpeed(){} // RVA: 0x7FFAFC51DAB0
        public void GetWalkSpeed(){} // RVA: 0x7FFAFC51DB30
        public void GetStrafeSpeed(){} // RVA: 0x7FFAFC51DBB0
        public void GetJumpImpulse(){} // RVA: 0x7FFAFC51DC30
        public void IsUserInVR(){} // RVA: 0x7FFAFC51DCB0
        public void SetGravityStrength(){} // RVA: 0x7FFAFC51DD30
        public void UseLegacyLocomotion(){} // RVA: 0x7FFAFC51DDC0
        public void UseAttachedStation(){} // RVA: 0x7FFAFC51DE40
        public void ClearInvisible(){} // RVA: 0x7FFAFC51DEC0
        public void ClearSilence(){} // RVA: 0x7FFAFC51DF40
        public void AddToList(){} // RVA: 0x7FFAFC51DFC0
        public void RemoveFromList(){} // RVA: 0x7FFAFC51E050
        public void CombatSetup(){} // RVA: 0x7FFAFC51E0E0
        public void CombatSetMaxHitpoints(){} // RVA: 0x7FFAFC51E160
        public void CombatSetCurrentHitpoints(){} // RVA: 0x7FFAFC51E1F0
        public void CombatGetCurrentHitpoints(){} // RVA: 0x7FFAFC51E280
        public void CombatSetRespawn(){} // RVA: 0x7FFAFC51E300
        public void CombatSetDamageGraphic(){} // RVA: 0x7FFAFC51E3C0
        public void CombatGetDestructible(){} // RVA: 0x7FFAFC51E450
        public void SetVoiceGain(){} // RVA: 0x7FFAFC51E4D0
        public void GetVoiceGain(){} // RVA: 0x7FFAFC51E560
        public void SetVoiceDistanceNear(){} // RVA: 0x7FFAFC51E5E0
        public void GetVoiceDistanceNear(){} // RVA: 0x7FFAFC51E670
        public void SetVoiceDistanceFar(){} // RVA: 0x7FFAFC51E6F0
        public void GetVoiceDistanceFar(){} // RVA: 0x7FFAFC51E780
        public void SetVoiceVolumetricRadius(){} // RVA: 0x7FFAFC51E800
        public void GetVoiceVolumetricRadius(){} // RVA: 0x7FFAFC51E890
        public void SetVoiceLowpass(){} // RVA: 0x7FFAFC51E910
        public void GetVoiceLowpass(){} // RVA: 0x7FFAFC51E9A0
        public void SetAvatarAudioGain(){} // RVA: 0x7FFAFC51EA20
        public void SetAvatarAudioFarRadius(){} // RVA: 0x7FFAFC51EAB0
        public void SetAvatarAudioNearRadius(){} // RVA: 0x7FFAFC51EB40
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x7FFAFC51EBD0
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x7FFAFC51EC60
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x7FFAFC51ECF0
        public void GetAvailableLanguages(){} // RVA: 0x7FFAFC51ED80
        public void GetCurrentLanguage(){} // RVA: 0x7FFAFC51EDF0
        public void GetPlayerObjects(){} // RVA: 0x7FFAFC51EE60
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFAFC51EF00
        public void PushAnimations(){} // RVA: 0x7FFAFC51EF10
        public void PopAnimations(){} // RVA: 0x7FFAFC51EFA0
        public void Immobilize(){} // RVA: 0x7FFAFC51F020
        public void SetVelocity(){} // RVA: 0x7FFAFC51F0B0
        public void GetVelocity(){} // RVA: 0x7FFAFC51F150
        public void GetPosition(){} // RVA: 0x7FFAFC51F1F0
        public void GetRotation(){} // RVA: 0x7FFAFC51F290
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x7FFAFC51F330
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x7FFAFC51F3B0
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x7FFAFC51F430
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x7FFAFC51F4B0
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x7FFAFC51F530
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x7FFAFC51F5C0
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x7FFAFC51F650
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x7FFAFC51F6E0
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x7FFAFC51F770
        public void .ctor(){} // RVA: 0x7FFAFC51F800
        public void .cctor(){} // RVA: 0x7FFAFC51F890
    }

    public class VRCRenderTexture
    {
        // ── Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0x7FFAFC52DFB0
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0x7FFAFC52E0E0
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7FFAFC52E210
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7FFAFC52E350
        public void GetTemporary(){} // RVA: 0x7FFAFC52E570 | overloaded x2
        public void ReleaseTemporary(){} // RVA: 0x7FFAFC52E600
    }

    public class VRCShader
    {
        // ── Methods ──
        public void add_OnSetGlobalShaderVariable(){} // RVA: 0x7FFAFC52E6A0
        public void remove_OnSetGlobalShaderVariable(){} // RVA: 0x7FFAFC52E800
        public void PropertyToID(){} // RVA: 0x7FFAFC52E960
        public void SetGlobalInteger(){} // RVA: 0x7FFAFC52EC30
        public void SetGlobalFloat(){} // RVA: 0x7FFAFC52ED00
        public void SetGlobalTexture(){} // RVA: 0x7FFAFC52EDD0
        public void SetGlobalColor(){} // RVA: 0x7FFAFC52EEA0
        public void SetGlobalVector(){} // RVA: 0x7FFAFC52EFB0
        public void SetGlobalMatrix(){} // RVA: 0x7FFAFC52F090
        public void SetGlobalFloatArray(){} // RVA: 0x7FFAFC52F180
        public void SetGlobalVectorArray(){} // RVA: 0x7FFAFC52F220
        public void SetGlobalMatrixArray(){} // RVA: 0x7FFAFC52F2C0
        public void ValidateAgainstPropertyIDWhitelist(){} // RVA: 0x7FFAFC52F360
        public void ClearGlobalVariableWhitelist(){} // RVA: 0x7FFAFC52F470
        public void .cctor(){} // RVA: 0x7FFAFC52F530
    }

    public class VRCStation
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC52F990
        public void UseStation(){} // RVA: 0x7FFAFC52F9F0
        public void ExitStation(){} // RVA: 0x7FFAFC52FA60
        public void .ctor(){} // RVA: 0x7FFAFC4A3570
    }

    public class VRCTriggerRelay
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC5473D0
        public void OnTriggerEnter(){} // RVA: 0x7FFAFC547430
        public void OnTriggerExit(){} // RVA: 0x7FFAFC5474C0
        public void .ctor(){} // RVA: 0x7FFAFC547540
    }

    public class VRCUrl
    {
        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFAFC547700
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x7FFAFC547760
        public void IsNullOrEmpty(){} // RVA: 0x7FFAFC5479F0
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFAFC547A90
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFAFC547AF0
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFAFC547BB0
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFAFC547C10
        public void IsAllowlistedUri(){} // RVA: 0x7FFAFC547CD0
        public void .ctor(){} // RVA: 0x7FFAFC547F30
        public void Get(){} // RVA: 0x7FFAF2DA8380
        public void ToString(){} // RVA: 0x7FFAF2DA8380
        public void Equals(){} // RVA: 0x7FFAFC548110 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8F53790
        public void .cctor(){} // RVA: 0x7FFAFC548160
    }

    public class VRC_AnimatorLayerControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC5219C0
        public void OnStateEnter(){} // RVA: 0x7FFAF81D31E0
        public void .ctor(){} // RVA: 0x7FFAFC4D1B50
    }

    public class VRC_AnimatorLocomotionControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC521A20
        public void OnStateEnter(){} // RVA: 0x7FFAF91A0670
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class VRC_AnimatorPlayAudio
    {
        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x7FFAFC521A80
        public void get_ShouldApplyPitch(){} // RVA: 0x7FFAFC521A90
        public void get_ShouldApplyClip(){} // RVA: 0x7FFAFC521AA0
        public void get_ShouldApplyLoop(){} // RVA: 0x7FFAFC521AB0
        public void ShouldApplySetting(){} // RVA: 0x7FFAFC521AC0
        public void Awake(){} // RVA: 0x7FFAFC521B40
        public void OnStateEnter(){} // RVA: 0x7FFAFC521BA0
        public void OnStateExit(){} // RVA: 0x7FFAFC521BC0
        public void .ctor(){} // RVA: 0x7FFAFC4D1B60
    }

    public class VRC_AnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC521BF0
        public void OnStateEnter(){} // RVA: 0x7FFAFC521C50
        public void OnStateUpdate(){} // RVA: 0x7FFAFC521CE0
        public void .ctor(){} // RVA: 0x7FFAFC4D1BB0
    }

    public class VRC_AnimatorTrackingControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC521D80
        public void OnStateEnter(){} // RVA: 0x7FFAF96FC210
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class VRC_AvatarDescriptor
    {
        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAFC521DE0
        public void PositionPortraitCamera(){} // RVA: 0x7FFAFC522120
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAF2DF8040
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAF2DF8050
        public void GetNetworkIDObjects(){} // RVA: 0x7FFAFC5225B0
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFAFC522650
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFAFC522970
        public void .ctor(){} // RVA: 0x7FFAFC5229F0
    }

    public class VRC_AvatarParameterDriver
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFAFC522CD0
        public void .ctor(){} // RVA: 0x7FFAFC4D6390
    }

    public class VRC_AvatarPedestal
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC527CD0
        public void SwitchAvatar(){} // RVA: 0x7FFAFC4EAE20 | overloaded x2
        public void SetAvatarUse(){} // RVA: 0x7FFAFC5281E0
        public void .ctor(){} // RVA: 0x7FFAFC528320
    }

    public class VRC_DataStorage
    {
        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0x7FFAFC5485B0
        public void GetElement(){} // RVA: 0x7FFAFC548620
        public void add_ElementChanged(){} // RVA: 0x7FFAFC5486B0
        public void remove_ElementChanged(){} // RVA: 0x7FFAFC5487A0
        public void OnDataElementChanged(){} // RVA: 0x7FFAFC548890
        public void Awake(){} // RVA: 0x7FFAFC5488C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_DestructibleStandard
    {
        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0x7FFAF2DB6080
        public void GetCurrentHealth(){} // RVA: 0x7FFAF2EFAF50
        public void Awake(){} // RVA: 0x7FFAFC524390
        public void ApplyDamage(){} // RVA: 0x7FFAFC524570
        public void ApplyHealing(){} // RVA: 0x7FFAFC524B00
        public void GetState(){} // RVA: 0x7FFAFC5250E0
        public void SetState(){} // RVA: 0x7FFAFC5251B0
        public void HandleCallbackTrigger(){} // RVA: 0x7FFAFC525230
        public void .ctor(){} // RVA: 0x7FFAFC497D10
        public void <ApplyDamage>b__27_0(){} // RVA: 0x7FFAFC523660
        public void <ApplyDamage>b__27_1(){} // RVA: 0x7FFAFC525370
        public void <ApplyHealing>b__28_0(){} // RVA: 0x7FFAFC525370
        public void <ApplyHealing>b__28_1(){} // RVA: 0x7FFAFC5253D0
    }

    public class VRC_EventDispatcher
    {
        // ── Methods ──
        public void TriggerEvent(){}
        public void RegisterEventHandler(){} // RVA: 0x7FFAF2AD4B10
        public void UnregisterEventHandler(){} // RVA: 0x7FFAF2AD4B10
        public void FindGameObject(){} // RVA: 0x7FFAF2ACD640 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_EventDispatcherLocal
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC526100
        public void TriggerEvent(){} // RVA: 0x7FFAF2D8D310
        public void RegisterEventHandler(){} // RVA: 0x7FFAF2D8D310
        public void UnregisterEventHandler(){} // RVA: 0x7FFAF2D8D310
        public void FindGameObject(){} // RVA: 0x7FFAFC526150
        public void GetGameObjectPath(){} // RVA: 0x7FFAFC5261A0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_EventHandler
    {
        // ── Methods ──
        public void BooleanOp(){} // RVA: 0x7FFAFC5489B0
        public void get_Dispatcher(){} // RVA: 0x7FFAFC5489D0
        public void get_GetInsitgatorId(){} // RVA: 0x7FFAFC548AF0
        public void set_GetInsitgatorId(){} // RVA: 0x7FFAFC548B30
        public void Awake(){} // RVA: 0x7FFAFC548BD0
        public void VrcAnimationEvent(){} // RVA: 0x7FFAFC548F70
        public void IsReceiverRequiredForEventType(){} // RVA: 0x7FFAFC549160
        public void TriggerEvent(){} // RVA: 0x7FFAFC54A1B0 | overloaded x4
        public void InternalTriggerEvent(){} // RVA: 0x7FFAFC549C20
        public void OnValidate(){} // RVA: 0x7FFAFC54A3A0
        public void OnDestroy(){} // RVA: 0x7FFAFC54A500
        public void GetCombinedNetworkId(){} // RVA: 0x7FFAF2FC9240
        public void HasEventTrigger(){} // RVA: 0x7FFAFC54A670
        public void IsReadyForEvents(){} // RVA: 0x7FFAF2E72850
        public void DeferEvent(){} // RVA: 0x7FFAFC54A770
        public void ProcessDeferredEvents(){} // RVA: 0x7FFAFC54AA60
        public void .ctor(){} // RVA: 0x7FFAFC54AB00
    }

    public class VRC_GunStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC498340
    }

    public class VRC_IKFollower
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC54B560
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_Interactable
    {
        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0x7FFAF2D8D320
        public void get_Proximity(){} // RVA: 0x7FFAF2FAE250
        public void Start(){} // RVA: 0x7FFAF2D8D310
        public void Awake(){} // RVA: 0x7FFAFC54B8D0
        public void Interact(){} // RVA: 0x7FFAF2AD4A50
        public void OnPickupUseUp(){} // RVA: 0x7FFAF2D8D310
        public void OnPickupUseDown(){} // RVA: 0x7FFAF2D8D310
        public void OnPickup(){} // RVA: 0x7FFAF2D8D310
        public void OnDrop(){} // RVA: 0x7FFAF2D8D310
        public void IsInteractiveForPlayer(){} // RVA: 0x7FFAFC54B930
        public void .ctor(){} // RVA: 0x7FFAFC54B9D0
    }

    public class VRC_KeyEvents
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC522D50
        public void Update(){} // RVA: 0x7FFAFC522FB0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void <Update>b__9_0(){} // RVA: 0x7FFAFC523600
        public void <Update>b__9_2(){} // RVA: 0x7FFAFC523600
        public void <Update>b__9_1(){} // RVA: 0x7FFAFC523660
        public void <Update>b__9_3(){} // RVA: 0x7FFAFC523660
    }

    public class VRC_Label
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4A6000
    }

    public class VRC_MetadataListener
    {
        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0x7FFAFC52FAD0
        public void Awake(){} // RVA: 0x7FFAFC52FB30
        public void OnDestroy(){} // RVA: 0x7FFAFC52FCA0
        public void TriggerUpdate(){} // RVA: 0x7FFAFC52FE10
        public void MetadataChangedInternal(){} // RVA: 0x7FFAFC52FE70
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_MidiNoteIn
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC5278D0
        public void Start(){} // RVA: 0x7FFAF2D8D310
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_MirrorReflection
    {
        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x7FFAFC52FE90
        public void remove_PreRenderMirror(){} // RVA: 0x7FFAFC52FFE0
        public void add_PostRenderMirror(){} // RVA: 0x7FFAFC530130
        public void remove_PostRenderMirror(){} // RVA: 0x7FFAFC530280
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x7FFAFC5303D0
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x7FFAFC530430
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFAFC5304F0
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFAFC530560
        public void OnValidate(){} // RVA: 0x7FFAFC5305D0
        public void Start(){} // RVA: 0x7FFAFC530630
        public void TrySetupMaterial(){} // RVA: 0x7FFAFC5308F0
        public void IsVisibleToCamera(){} // RVA: 0x7FFAFC530E40
        public void IsLayerRendered(){} // RVA: 0x7FFAFC531040
        public void CameraOnPreCull(){} // RVA: 0x7FFAFC5310C0
        public void RenderMirrorCameras(){} // RVA: 0x7FFAFC531540
        public void CameraPostRender(){} // RVA: 0x7FFAFC5327E0
        public void OnEnable(){} // RVA: 0x7FFAFC532AE0
        public void OnDisable(){} // RVA: 0x7FFAFC532D90
        public void OnDestroy(){} // RVA: 0x7FFAFC5334A0
        public void ShouldRenderLeftEye(){} // RVA: 0x7FFAFC5337F0
        public void ShouldRenderRightEye(){} // RVA: 0x7FFAFC533A00
        public void ShouldRenderMonoscopic(){} // RVA: 0x7FFAFC533C10
        public void GetWorldEyePos(){} // RVA: 0x7FFAFC533E70
        public void GetWorldEyeRot(){} // RVA: 0x7FFAFC533FA0
        public void GetEyeProjectionMatrix(){} // RVA: 0x7FFAFC534190
        public void GetNormalDirection(){} // RVA: 0x7FFAFC534260
        public void RenderMirror(){} // RVA: 0x7FFAFC534310
        public void UpdateCameraClearing(){} // RVA: 0x7FFAFC535030
        public void UpdateCameraModes(){} // RVA: 0x7FFAFC535410
        public void UpdateParentTransform(){} // RVA: 0x7FFAFC535D80
        public void GetReflectionData(){} // RVA: 0x7FFAFC5366F0
        public void GetAutoResolution(){} // RVA: 0x7FFAFC5371E0
        public void Plane(){} // RVA: 0x7FFAFC5373D0
        public void CameraSpacePlane(){} // RVA: 0x7FFAFC537430
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFAFC537840
        public void CopySign(){} // RVA: 0x7FFAFC5379B0
        public void GetRotation(){} // RVA: 0x7FFAFC5379E0
        public void GetPosition(){} // RVA: 0x7FFAF8F4D830
        public void .ctor(){} // RVA: 0x7FFAFC537C20
        public void .cctor(){} // RVA: 0x7FFAFC537D30
    }

    public class VRC_NPCSpawn
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC5283E0
        public void .ctor(){} // RVA: 0x7FFAFC498EA0
    }

    public class VRC_NpcApi
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC5236C0
        public void GetApiByGameObject(){} // RVA: 0x7FFAFC523720
        public void ActThis(){} // RVA: 0x7FFAFC523830
        public void SayThis(){} // RVA: 0x7FFAFC5238C0
        public void SetNamePlate(){} // RVA: 0x7FFAFC523950
        public void SetSocialStatus(){} // RVA: 0x7FFAFC5239F0
        public void SetMuteStatus(){} // RVA: 0x7FFAFC523A90
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_ObjectApi
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_ObjectSpawn
    {
        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x7FFAFC5286A0 | overloaded x2
        public void DestroySpawnedObjects(){} // RVA: 0x7FFAF48DB0D0
        public void Start(){} // RVA: 0x7FFAFC5287C0
        public void ProvideEvents(){} // RVA: 0x7FFAFC528820
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_OscButtonIn
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC527930
        public void Start(){} // RVA: 0x7FFAF2D8D310
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_Panorama
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC537F40
        public void Update(){} // RVA: 0x7FFAFC538110
        public void NextPano(){} // RVA: 0x7FFAFC5383E0
        public void PrevPano(){} // RVA: 0x7FFAFC5384A0
        public void ShowPanoAt(){} // RVA: 0x7FFAFC538560
        public void ShowPano(){} // RVA: 0x7FFAFC5385F0
        public void .ctor(){} // RVA: 0x7FFAFC4A60D0
    }

    public class VRC_PhysicsRoot
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC523B20
        public void OnDestroy(){} // RVA: 0x7FFAFC524150
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_Pickup
    {
        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7FFAFC528E30 | overloaded x2
        public void get_currentPlayer(){} // RVA: 0x7FFAFC528E60
        public void get_IsHeld(){} // RVA: 0x7FFAFC528ED0
        public void get_currentHand(){} // RVA: 0x7FFAFC528F90
        public void get_Proximity(){} // RVA: 0x7FFAFC528FF0
        public void Awake(){} // RVA: 0x7FFAFC529000
        public void OnDisable(){} // RVA: 0x7FFAFC529060
        public void Reset(){} // RVA: 0x7FFAFC5290A0
        public void Drop(){} // RVA: 0x7FFAFC529230 | overloaded x2
        public void GenerateHapticEvent(){} // RVA: 0x7FFAFC529490
        public void OnDestroy(){} // RVA: 0x7FFAFC529530
        public void PlayHaptics(){} // RVA: 0x7FFAFC529590
        public void ProvideEvents(){} // RVA: 0x7FFAFC5295C0
        public void .ctor(){} // RVA: 0x7FFAFC529A00
    }

    public class VRC_PlayableLayerControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC524270
        public void OnStateEnter(){} // RVA: 0x7FFAFC5242D0
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class VRC_PortalMarker
    {
        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x7FFAF2F3EC40
        public void Awake(){} // RVA: 0x7FFAFC529DB0
        public void Update(){} // RVA: 0x7FFAFC529E30
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_PropApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_PropController
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC529EB0
        public void Update(){} // RVA: 0x7FFAFC529F10
        public void GetInputIndex(){} // RVA: 0x7FFAFC529F80
        public void .ctor(){} // RVA: 0x7FFAFC49A5F0
    }

    public class VRC_PropDescriptor : NetworkIDLookup
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC52A080
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAF2E0A740
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAF2DB5200
        public void get_NetworkIDLookup(){} // RVA: 0x7FFAF2E08730
        public void set_NetworkIDLookup(){} // RVA: 0x7FFAF2E08740
        public void GetNetworkIDObjects(){} // RVA: 0x7FFAFC52AAB0
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFAFC52AB50
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFAFC522970
        public void .ctor(){} // RVA: 0x7FFAFC52AE70
    }

    public class VRC_SceneDescriptor
    {
        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0x7FFAFC538E50
        public void GetPrefab(){} // RVA: 0x7FFAFC539040
        public void GetMaterial(){} // RVA: 0x7FFAFC539430
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAF384ABC0
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAF384A380
        public void get_NetworkIDLookup(){} // RVA: 0x7FFAF337BA20
        public void set_NetworkIDLookup(){} // RVA: 0x7FFAF38644F0
        public void GetNetworkIDObjects(){} // RVA: 0x7FFAFC539820
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFAFC539B10
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFAFC522970
        public void get_Instance(){} // RVA: 0x7FFAFC53A070
        public void get_Exists(){} // RVA: 0x7FFAFC53A380
        public void get_BundleUnityMajorVersion(){} // RVA: 0x7FFAFC53A480
        public void set_BundleUnityMajorVersion(){} // RVA: 0x7FFAFC53A490
        public void get_Scene(){} // RVA: 0x7FFAF474AB70
        public void set_Scene(){} // RVA: 0x7FFAF474AB80
        public void Awake(){} // RVA: 0x7FFAFC53A4A0
        public void OnDestroy(){} // RVA: 0x7FFAFC53B470
        public void PositionPortraitCamera(){} // RVA: 0x7FFAFC53B530
        public void .ctor(){} // RVA: 0x7FFAFC53B900
        public void .cctor(){} // RVA: 0x7FFAFC53BC30
    }

    public class VRC_Serialization
    {
        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x7FFAFC54BA90
        public void set_AllowPluginTypes(){} // RVA: 0x7FFAFC54BAF0
        public void get_SurrogateSelector(){} // RVA: 0x7FFAFC54BB50
        public void RegisterPluginType(){} // RVA: 0x7FFAFC54BC60
        public void RegisterType(){} // RVA: 0x7FFAFC54BD50
        public void ParameterEncoder(){} // RVA: 0x7FFAFC54BE40
        public void ParameterDecoder(){} // RVA: 0x7FFAFC54C050
        public void get_Dispatcher(){} // RVA: 0x7FFAFC54C2C0
        public void GetGameObjectPathFallback(){} // RVA: 0x7FFAFC54C400
        public void GetGameObjectPath(){} // RVA: 0x7FFAFC54C670
        public void FindGameObject(){} // RVA: 0x7FFAFC54C7B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC54C910
    }

    public class VRC_SlideShow
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC52B090
        public void ShowNextImage(){} // RVA: 0x7FFAFC52B150
        public void ShowPreviousImage(){} // RVA: 0x7FFAFC52B370
        public void StartAutoplayWithDuration(){} // RVA: 0x7FFAFC52B540
        public void StopAutoplayWithDuration(){} // RVA: 0x7FFAFC52B600
        public void .ctor(){} // RVA: 0x7FFAFC49A6F0
    }

    public class VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC51B440
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAFC51B6E0
        public void .ctor(){} // RVA: 0x7FFAFC496D70
    }

    public class VRC_SpecialLayer
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFAFC53BF20
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_StereoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_TimedEvents
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC53C150
        public void OnEnable(){} // RVA: 0x7FFAFC53C320
        public void Update(){} // RVA: 0x7FFAFC53C330
        public void ResetClock(){} // RVA: 0x7FFAFC53C4C0
        public void .ctor(){} // RVA: 0x7FFAFC4A3630
    }

    public class VRC_Trigger
    {
        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0x7FFAFC53C7D0 | overloaded x2
        public void Trigger(){} // RVA: 0x7FFAFC53C640
        public void get_HasKeyTriggers(){} // RVA: 0x7FFAFC53C960
        public void get_HasTimerTriggers(){} // RVA: 0x7FFAFC53CAD0
        public void get_HasColliderTriggers(){} // RVA: 0x7FFAFC53CC40
        public void get_HasInteractiveTriggers(){} // RVA: 0x7FFAFC53CEE0
        public void get_HasPickupTriggers(){} // RVA: 0x7FFAFC53D050
        public void get_IsInteractive(){} // RVA: 0x7FFAFC53D1C0
        public void Awake(){} // RVA: 0x7FFAFC53D4A0
        public void OnDestroy(){} // RVA: 0x7FFAFC53D550
        public void OnEnable(){} // RVA: 0x7FFAFC53D560
        public void OnDisable(){} // RVA: 0x7FFAFC53D590
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAFC53D5C0
        public void Interact(){} // RVA: 0x7FFAFC53DB70
        public void OnPickupUseUp(){} // RVA: 0x7FFAFC53DB80
        public void OnPickupUseDown(){} // RVA: 0x7FFAFC53DB90
        public void OnPickup(){} // RVA: 0x7FFAFC53DBA0
        public void OnDrop(){} // RVA: 0x7FFAFC53DBB0
        public void ExecuteTriggers(){} // RVA: 0x7FFAFC53DBC0
        public void ExecuteTriggerType(){} // RVA: 0x7FFAFC53DEC0
        public void ExecuteCustomTrigger(){} // RVA: 0x7FFAFC53E220
        public void ResetClocks(){} // RVA: 0x7FFAFC53E610
        public void ResetClock(){} // RVA: 0x7FFAFC53E980
        public void .ctor(){} // RVA: 0x7FFAFC4A3690
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x7FFAFC53EA10
    }

    public class VRC_TriggerColliderEventTrigger
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAFC53F9C0
        public void OnTriggerEnter(){} // RVA: 0x7FFAFC53FB80
        public void OnTriggerExit(){} // RVA: 0x7FFAFC53FCC0
        public void .ctor(){} // RVA: 0x7FFAFC4A3760
    }

    public class VRC_TutorialAction
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFAFC545260
        public void ActivateObjectLabel(){} // RVA: 0x7FFAFC545460 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFAFC5454F0
        public void ActivateControllerLabel(){} // RVA: 0x7FFAFC545550
        public void DeactivateControllerLabel(){} // RVA: 0x7FFAFC545580
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRC_TutorialAreaMarker
    {
        // ── Methods ──
        public void Enable(){} // RVA: 0x7FFAF8572490
        public void Update(){} // RVA: 0x7FFAFC545590
        public void ShowLabel(){} // RVA: 0x7FFAFC5459C0
        public void .ctor(){} // RVA: 0x7FFAFC4A3B20
    }

    public class VRC_UiShape
    {
        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0x7FFAF2DBB0C0
        public void set_RootCanvas(){} // RVA: 0x7FFAF2DBB0D0
        public void get_RootCanvasRectTransform(){} // RVA: 0x7FFAF2DBB130
        public void set_RootCanvasRectTransform(){} // RVA: 0x7FFAF2D8EE90
        public void add_OnUiShapeInit(){} // RVA: 0x7FFAFC546540
        public void remove_OnUiShapeInit(){} // RVA: 0x7FFAFC546680
        public void add_OnUiShapeDestroy(){} // RVA: 0x7FFAFC5467C0
        public void remove_OnUiShapeDestroy(){} // RVA: 0x7FFAFC546900
        public void Awake(){} // RVA: 0x7FFAFC546A40
        public void Start(){} // RVA: 0x7FFAFC546BE0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAFC546F40
        public void SetupCollision(){} // RVA: 0x7FFAFC546F50
        public void OnDestroy(){} // RVA: 0x7FFAFC547370
        public void .ctor(){} // RVA: 0x7FFAF2E41710
    }

    public class VRC_UseEvents : ؄}e
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC53FE00
        public void Start(){} // RVA: 0x7FFAFC540040
        public void Interact(){} // RVA: 0x7FFAFC5402D0
        public void .ctor(){} // RVA: 0x7FFAFC4A37B0
        public void <Awake>b__5_0(){} // RVA: 0x7FFAFC5404B0
    }

    public class VRC_VisualDamage
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC525430
        public void Start(){} // RVA: 0x7FFAFC5254C0
        public void OnSceneWasLoaded(){} // RVA: 0x7FFAFC5256F0
        public void Update(){} // RVA: 0x7FFAFC525790
        public void HideDamageIndicator(){} // RVA: 0x7FFAFC5259C0
        public void ShowDamageIndicator(){} // RVA: 0x7FFAFC525AE0
        public void SetDamagePercent(){} // RVA: 0x7FFAFC525C00
        public void .ctor(){} // RVA: 0x7FFAFC525F00
    }

    public class VRC_Water
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFAFC5405C0
        public void OnDisable(){} // RVA: 0x7FFAFC5412A0
        public void Update(){} // RVA: 0x7FFAFC5418F0
        public void UpdateCameraModes(){} // RVA: 0x7FFAFC541DC0
        public void CreateWaterObjects(){} // RVA: 0x7FFAFC542340
        public void GetWaterMode(){} // RVA: 0x7FFAFC543700
        public void FindHardwareWaterSupport(){} // RVA: 0x7FFAFC543710
        public void CameraSpacePlane(){} // RVA: 0x7FFAF2DA4D00
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFAF2DA50F0
        public void .ctor(){} // RVA: 0x7FFAFC4A3850
    }

    public class VRC_WebPanel : ؄}e
    {
        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0x7FFAFC543A00
        public void WebPanelBackward(){} // RVA: 0x7FFAFC543A30
        public void WebPanelReload(){} // RVA: 0x7FFAFC543A60
        public void BindCall(){} // RVA: 0x7FFAFC543A90
        public void NavigateTo(){} // RVA: 0x7FFAFC543AC0
        public void Awake(){} // RVA: 0x7FFAFC543AF0
        public void Interact(){} // RVA: 0x7FFAF2D8D310
        public void get_WebRootPath(){} // RVA: 0x7FFAFC543C00
        public void ProvideEvents(){} // RVA: 0x7FFAFC543D70
        public void ReadData(){} // RVA: 0x7FFAFC5446A0
        public void ImportWebData(){} // RVA: 0x7FFAFC544900
        public void .ctor(){} // RVA: 0x7FFAFC4A39F0
    }

    public class VersionHelper
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0x7FFAF2D33FA0
    }

}