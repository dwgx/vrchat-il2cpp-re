// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 70
// Methods: 610

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        // ── Original Methods ──
        public void get_boolVal(){} // RVA: 0x7ffaa864a040
        public void set_boolVal(){} // RVA: 0x7ffaa86613a0
        public void get_intVal(){} // RVA: 0x7ffaa8649ca0
        public void set_intVal(){} // RVA: 0x7ffaa8661210
        public void get_floatVal(){} // RVA: 0x7ffaa865dbc0
        public void set_floatVal(){} // RVA: 0x7ffaa866e7c0
    }

    public class INetworkID
    {
    }

    public class IVRCEventProvider
    {
        // ── Original Methods ──
        public void ProvideEvents(){} // RVA: 0x7ffaa86491d0
    }

    public class IVRCEventReceiver
    {
    }

    public class IVRCEventSender
    {
    }

    public class IVRC_Destructible
    {
        // ── Original Methods ──
        public void ApplyDamage(){} // RVA: 0x7ffaa866e7c0
        public void ApplyHealing(){} // RVA: 0x7ffaa866e7c0
        // ── Binary Analysis Named ──
        public void GetState(){} // RVA: 0x7ffaa86491d0
        public void SetState(){} // RVA: 0x7ffaa8660d80
        public void GetMaxHealth(){} // RVA: 0x7ffaa865dbc0
        public void GetCurrentHealth(){} // RVA: 0x7ffaa865dbc0
    }

    public class InputManager : Object
    {
        public object _GetInputSetting; // 0x367DEFE0

        // ── Original Methods ──
        public void IsUsingHandController(){} // RVA: 0x7ffab1a93a10
        public void EnableObjectHighlight(){} // RVA: 0x7ffab1a93cb0
        public void EnableObjectHighlight(){} // RVA: 0x7ffab1a93cb0
        // ── Binary Analysis Named ──
        public void GetLastUsedInputMethod(){} // RVA: 0x7ffab1a93a70
        public void GetBoolInputSetting(){} // RVA: 0x7ffab1a93ae0
        public void SetBoolInputSetting(){} // RVA: 0x7ffab1a93b40
    }

    public class Networking : Object
    {
        public object _RPC; // 0x31669920
        public object _IsMaster; // 0x31669920
        public object _LocalPlayer; // 0x31669920
        public object _IsOwner; // 0x31669920
        public object _Instantiate; // 0x31669920
        public object _ParameterDecoder; // 0x31669920
        public object _GoToRoom; // 0x31669920
        public object _GetServerTimeInMilliseconds; // 0x31669920
        public object _GetEventDispatcher; // 0x31669920
        public object _GetPlayerObjectStorageUsage; // 0x31669920
        public object _FindComponentInPlayerObjects; // 0x31669920
        public object `;

        // ── Original Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x7ffab1a6ec10
        public void get_IsNetworkSettled(){} // RVA: 0x7ffab1a6ec70
        public void get_IsMaster(){} // RVA: 0x7ffab1a6ecd0
        public void get_IsClogged(){} // RVA: 0x7ffab1a6ed30
        public void get_IsInstanceOwner(){} // RVA: 0x7ffab1a6ed90
        public void get_LocalPlayer(){} // RVA: 0x7ffab1a6edf0
        public void get_Master(){} // RVA: 0x7ffab1a6ee50
        public void get_InstanceOwner(){} // RVA: 0x7ffab1a6eeb0
        public void IsOwner(){} // RVA: 0x7ffab1a6ef90
        public void IsOwner(){} // RVA: 0x7ffab1a6ef90
        public void IsObjectReady(){} // RVA: 0x7ffab1a6f130
        public void Instantiate(){} // RVA: 0x7ffab1a6f1a0
        public void RPC(){} // RVA: 0x7ffab1a6f2f0
        public void RPC(){} // RVA: 0x7ffab1a6f2f0
        public void EncodeParameters(){} // RVA: 0x7ffab1a6f390
        public void DecodeParameters(){} // RVA: 0x7ffab1a6f400
        public void Destroy(){} // RVA: 0x7ffab1a6f470
        public void GoToRoom(){} // RVA: 0x7ffab1a6f550
        public void CalculateServerDeltaTime(){} // RVA: 0x7ffab1a6f7c0
        public void SafeStartCoroutine(){} // RVA: 0x7ffab1a6f850
        public void SimulationTime(){} // RVA: 0x7ffab1a6f9d0
        public void SimulationTime(){} // RVA: 0x7ffab1a6f9d0
        public void RequestStorageUsageUpdate(){} // RVA: 0x7ffaafb79880
        public void FindComponentInPlayerObjects(){} // RVA: 0x7ffab1a6fc20
        // ── Binary Analysis Named ──
        public void GetOwner(){} // RVA: 0x7ffab1a6f050
        public void SetOwner(){} // RVA: 0x7ffab1a6f0c0
        public void GetUniqueName(){} // RVA: 0x7ffab1a6f4e0
        public void GetNetworkDateTime(){} // RVA: 0x7ffab1a6f5c0
        public void GetServerTimeInSeconds(){} // RVA: 0x7ffab1a6f660
        public void GetServerTimeInMilliseconds(){} // RVA: 0x7ffab1a6f710
        public void GetEventDispatcher(){} // RVA: 0x7ffab1a6f8c0
        public void GetPlayerObjects(){} // RVA: 0x7ffab1a671d0
        public void GetPlayerDataStorageLimit(){} // RVA: 0x7ffab1a6fa80
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x7ffab1a6fae0
        public void GetPlayerDataStorageUsage(){} // RVA: 0x7ffab1a6fb40
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x7ffab1a6fbb0
    }

    public class RPC : Attribute
    {
        public object playerRateLimit; // 0x36806320

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a6e830
        public void .ctor(){} // RVA: 0x7ffab1a6e830
        public void .ctor(){} // RVA: 0x7ffab1a6e830
        public void .ctor(){} // RVA: 0x7ffab1a6e830
        // ── Binary Analysis Named ──
        public void SetupTargets(){} // RVA: 0x7ffab1a6e850
    }

    public class Tutorial : Object
    {
        public object _ActivateControllerLabel; // 0x367955A0

        // ── Original Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7ffab1a8df40
        public void ActivateObjectLabel(){} // RVA: 0x7ffab1a8e150
        public void ActivateObjectLabel(){} // RVA: 0x7ffab1a8e150
        public void ActivateObjectLabel(){} // RVA: 0x7ffab1a8e150
        public void DeactivateObjectLabel(){} // RVA: 0x7ffab1a8e240
        public void ActivateControllerLabel(){} // RVA: 0x7ffab1a8e2a0
        public void DeactivateControllerLabel(){} // RVA: 0x7ffab1a8e340
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Utilities : Object
    {
        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffab1a9bb60
        public void ShuffleArray(){} // RVA: 0x7ffab1a9bcc0
        public void ShuffleArray(){} // RVA: 0x7ffab1a9bcc0
        public void IsClient(){} // RVA: 0x7ffab1a9bdc0
        public void Fletcher32Fast(){} // RVA: 0x7ffab1a9be40
        // ── Binary Analysis Named ──
        public void SetIsClient(){} // RVA: 0x7ffab1a9be00
    }

    public class VRCBuiltInShaderGlobals : MonoBehaviour
    {
        public object _vrcTimeEncoded1ID; // 0x33D20830
        public object _getPreferredTimezoneDelegate; // 0x33D20830, was: <GetPreferredTimezoneDelegate>
        public object Instance; // 0x17000029
        public object GetPreferredTimezoneDelegate; // 0x1700002A

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffab1a73cd0
        public void set_Instance(){} // RVA: 0x7ffab1a73d30
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x7ffaa89600c0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x7ffaa89600d0
        public void Update(){} // RVA: 0x7ffab1a73df0
        public void OnDestroy(){} // RVA: 0x7ffab1a74490
        public void Initialize(){} // RVA: 0x7ffab1a74780
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffab1a74bc0
    }

    public class VRCCustomAction : MonoBehaviour
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffab1a77d00
        public void Execute(){} // RVA: 0x7ffab1a77d00
        public void Execute(){} // RVA: 0x7ffab1a77d00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRCDroneApi : Object
    {
        // ── Original Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x7ffab1a6e3f0
        public void IsDeployed(){} // RVA: 0x7ffaa864a040
        public void TryGetPosition(){} // RVA: 0x7ffaa864a2a0
        public void TryGetRotation(){} // RVA: 0x7ffaa864a2a0
        public void TryGetVelocity(){} // RVA: 0x7ffaa864a2a0
        public void TeleportTo(){} // RVA: 0x7ffaa8669e70
        public void TeleportTo(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetPlayer(){} // RVA: 0x7ffaa86491d0
        public void GetPosition(){} // RVA: 0x7ffaa8648be0
        public void GetRotation(){} // RVA: 0x7ffaa8648be0
        public void GetVelocity(){} // RVA: 0x7ffaa8648be0
        public void SetVelocity(){} // RVA: 0x7ffaa8660d80
    }

    public class VRCPlayerApi : Object
    {
        public object _isModeratorDelegate; // 0x30CDA790
        public object _isVRCPlusDelegate; // 0x30CDA790
        public object SetAnimatorBool; // 0x30CDA790
        public object IsGrounded; // 0x30CDA790
        public object mPlayerId; // 0x30CDA790
        public object _GetPlayerById; // 0x30CDA790
        public object _GetTrackingData; // 0x30CDA790
        public object _GetBoneRotation; // 0x30CDA790
        public object _TeleportTo; // 0x30CDA790
        public object _Respawn; // 0x30CDA790
        public object _GetAvailableLanguages; // 0x30CDA790
        public object _RestoreNamePlateColor; // 0x30CDA790
        public object _SetPlayerTag; // 0x30CDA790
        public object _ClearPlayerTags; // 0x30CDA790
        public object _SetSilencedToTagged; // 0x30CDA790
        public object _ClearSilence; // 0x30CDA790
        public object _SetStrafeSpeed; // 0x30CDA790
        public object _GetRunSpeed; // 0x30CDA790
        public object _GetJumpImpulse; // 0x30CDA790
        public object _SetVoiceDistanceNear; // 0x30CDA790
        public object _SetVoiceLowpass; // 0x30CDA790
        public object _GetVoiceDistanceFar; // 0x30CDA790
        public object _SetAvatarAudioGain; // 0x30CDA790
        public object _SetAvatarAudioVolumetricRadius; // 0x30CDA790
        public object _CombatSetup; // 0x30CDA790
        public object _CombatGetCurrentHitpoints; // 0x30CDA790
        public object _CombatGetDestructible; // 0x30CDA790
        public object _UseAttachedStation; // 0x30CDA790
        public object _Immobilize; // 0x30CDA790
        public object _GetPosition; // 0x30CDA790
        public object _isValid; // 0x30CDA790
        public object _GetAvatarEyeHeightMinimumAsMeters; // 0x30CDA790
        public object _SetAvatarEyeHeightByMultiplier; // 0x30CDA790
        public object _SetManualAvatarScalingAllowed; // 0x30CDA790
        public object isMaster; // 0x17000007
        public object isInstanceOwner; // 0x17000008
        public object isModerator; // 0x17000009
        public object isSuper; // 0x1700000A
        public object isSuspended; // 0x1700000B
        public object isVRCPlus; // 0x1700000C
        public object AllPlayers; // 0x1700000D
        public object playerId; // 0x1700000E
        public object PlayerMobility; // 0x33D05FC0
        public object disableStationExit; // 0x33D05FC0
        public object stationExitPlayerLocation; // 0x33D05FC0
        public object useStationDelegate; // 0x33D05FC0
        public object currentIdx; // 0x331E2830
        public object System; // 0xB40D0C60
        public object `; // 0x367D7458
        public object get_Empty; // 0xB41A4870

        // ── Original Methods ──
        public void get_isMaster(){} // RVA: 0x7ffab1a642a0
        public void get_isInstanceOwner(){} // RVA: 0x7ffab1a64320
        public void get_isModerator(){} // RVA: 0x7ffab1a643a0
        public void get_isSuper(){} // RVA: 0x7ffab1a64420
        public void get_isSuspended(){} // RVA: 0x7ffab1a644a0
        public void get_isVRCPlus(){} // RVA: 0x7ffab1a64520
        public void IsPlayerGrounded(){} // RVA: 0x7ffab1a645a0
        public void get_AllPlayers(){} // RVA: 0x7ffab1a646c0
        public void get_playerId(){} // RVA: 0x7ffab1a64970
        public void IsValid(){} // RVA: 0x7ffaa8958450
        public void IsOwner(){} // RVA: 0x7ffab1a64ad0
        public void TakeOwnership(){} // RVA: 0x7ffab1a64b60
        public void PlayHapticEventInHand(){} // RVA: 0x7ffab1a64f40
        public void TeleportTo(){} // RVA: 0x7ffab1a65200
        public void TeleportTo(){} // RVA: 0x7ffab1a65200
        public void TeleportTo(){} // RVA: 0x7ffab1a65200
        public void Respawn(){} // RVA: 0x7ffab1a65380
        public void Respawn(){} // RVA: 0x7ffab1a65380
        public void EnablePickups(){} // RVA: 0x7ffab1a65410
        public void RestoreNamePlateColor(){} // RVA: 0x7ffab1a65540
        public void RestoreNamePlateVisibility(){} // RVA: 0x7ffab1a65650
        public void ClearPlayerTags(){} // RVA: 0x7ffab1a65800
        public void IsUserInVR(){} // RVA: 0x7ffab1a66020
        public void UseLegacyLocomotion(){} // RVA: 0x7ffab1a66130
        public void UseAttachedStation(){} // RVA: 0x7ffab1a661b0
        public void ClearInvisible(){} // RVA: 0x7ffab1a66230
        public void ClearSilence(){} // RVA: 0x7ffab1a662b0
        public void AddToList(){} // RVA: 0x7ffab1a66330
        public void RemoveFromList(){} // RVA: 0x7ffab1a663c0
        public void CombatSetup(){} // RVA: 0x7ffab1a66450
        public void CombatSetMaxHitpoints(){} // RVA: 0x7ffab1a664d0
        public void CombatSetCurrentHitpoints(){} // RVA: 0x7ffab1a66560
        public void CombatGetCurrentHitpoints(){} // RVA: 0x7ffab1a665f0
        public void CombatSetRespawn(){} // RVA: 0x7ffab1a66670
        public void CombatSetDamageGraphic(){} // RVA: 0x7ffab1a66730
        public void CombatGetDestructible(){} // RVA: 0x7ffab1a667c0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7ffab1a67270
        public void PushAnimations(){} // RVA: 0x7ffab1a67280
        public void PopAnimations(){} // RVA: 0x7ffab1a67310
        public void Immobilize(){} // RVA: 0x7ffab1a67390
        public void .ctor(){} // RVA: 0x7ffab1a67b70
        public void .cctor(){} // RVA: 0x7ffab1a67c00
        // ── Binary Analysis Named ──
        public void GetDrone(){} // RVA: 0x7ffab1a64640
        public void GetPlayers(){} // RVA: 0x7ffab1a647d0
        public void GetPlayers(){} // RVA: 0x7ffab1a647d0
        public void GetPlayerCount(){} // RVA: 0x7ffab1a64870
        public void GetPlayerId(){} // RVA: 0x7ffab1a648f0
        public void GetPlayerByGameObject(){} // RVA: 0x7ffab1a649d0
        public void GetPlayerById(){} // RVA: 0x7ffab1a64a50
        public void GetTrackingData(){} // RVA: 0x7ffab1a64bf0
        public void GetBoneTransform(){} // RVA: 0x7ffab1a64cb0
        public void GetBonePosition(){} // RVA: 0x7ffab1a64d40
        public void GetBoneRotation(){} // RVA: 0x7ffab1a64e00
        public void GetPickupInHand(){} // RVA: 0x7ffab1a64eb0
        public void SetPickupInHand(){} // RVA: 0x7ffaa8932310
        public void SetNamePlateColor(){} // RVA: 0x7ffab1a654a0
        public void SetNamePlateVisibility(){} // RVA: 0x7ffab1a655c0
        public void SetPlayerTag(){} // RVA: 0x7ffab1a656d0
        public void GetPlayerTag(){} // RVA: 0x7ffab1a65770
        public void GetPlayersWithTag(){} // RVA: 0x7ffaa8f22da0
        public void SetInvisibleToTagged(){} // RVA: 0x7ffab1a65880
        public void SetInvisibleToUntagged(){} // RVA: 0x7ffab1a65940
        public void SetSilencedToTagged(){} // RVA: 0x7ffab1a65a00
        public void SetSilencedToUntagged(){} // RVA: 0x7ffab1a65ab0
        public void SetRunSpeed(){} // RVA: 0x7ffab1a65b60
        public void SetWalkSpeed(){} // RVA: 0x7ffab1a65bf0
        public void SetStrafeSpeed(){} // RVA: 0x7ffab1a65c80
        public void SetJumpImpulse(){} // RVA: 0x7ffab1a65d10
        public void GetGravityStrength(){} // RVA: 0x7ffab1a65da0
        public void GetRunSpeed(){} // RVA: 0x7ffab1a65e20
        public void GetWalkSpeed(){} // RVA: 0x7ffab1a65ea0
        public void GetStrafeSpeed(){} // RVA: 0x7ffab1a65f20
        public void GetJumpImpulse(){} // RVA: 0x7ffab1a65fa0
        public void SetGravityStrength(){} // RVA: 0x7ffab1a660a0
        public void SetVoiceGain(){} // RVA: 0x7ffab1a66840
        public void GetVoiceGain(){} // RVA: 0x7ffab1a668d0
        public void SetVoiceDistanceNear(){} // RVA: 0x7ffab1a66950
        public void GetVoiceDistanceNear(){} // RVA: 0x7ffab1a669e0
        public void SetVoiceDistanceFar(){} // RVA: 0x7ffab1a66a60
        public void GetVoiceDistanceFar(){} // RVA: 0x7ffab1a66af0
        public void SetVoiceVolumetricRadius(){} // RVA: 0x7ffab1a66b70
        public void GetVoiceVolumetricRadius(){} // RVA: 0x7ffab1a66c00
        public void SetVoiceLowpass(){} // RVA: 0x7ffab1a66c80
        public void GetVoiceLowpass(){} // RVA: 0x7ffab1a66d10
        public void SetAvatarAudioGain(){} // RVA: 0x7ffab1a66d90
        public void SetAvatarAudioFarRadius(){} // RVA: 0x7ffab1a66e20
        public void SetAvatarAudioNearRadius(){} // RVA: 0x7ffab1a66eb0
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x7ffab1a66f40
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x7ffab1a66fd0
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x7ffab1a67060
        public void GetAvailableLanguages(){} // RVA: 0x7ffab1a670f0
        public void GetCurrentLanguage(){} // RVA: 0x7ffab1a67160
        public void GetPlayerObjects(){} // RVA: 0x7ffab1a671d0
        public void SetVelocity(){} // RVA: 0x7ffab1a67420
        public void GetVelocity(){} // RVA: 0x7ffab1a674c0
        public void GetPosition(){} // RVA: 0x7ffab1a67560
        public void GetRotation(){} // RVA: 0x7ffab1a67600
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x7ffab1a676a0
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x7ffab1a67720
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x7ffab1a677a0
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x7ffab1a67820
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x7ffab1a678a0
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x7ffab1a67930
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x7ffab1a679c0
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x7ffab1a67a50
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x7ffab1a67ae0
    }

    public class VRCRenderTexture : Object
    {
        // ── Original Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0x7ffab1a763e0
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0x7ffab1a76510
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7ffab1a76640
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7ffab1a76780
        public void ReleaseTemporary(){} // RVA: 0x7ffab1a76a30
        // ── Binary Analysis Named ──
        public void GetTemporary(){} // RVA: 0x7ffab1a769a0
        public void GetTemporary(){} // RVA: 0x7ffab1a769a0
    }

    public class VRCStation : MonoBehaviour
    {
        public object animatorController; // 0x33D05FC0
        public object stationEnterPlayerLocation; // 0x33D05FC0
        public object Initialize; // 0x33D05FC0
        public object triggersInside; // 0x331E2830

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a77dc0
        public void UseStation(){} // RVA: 0x7ffab1a77e20
        public void ExitStation(){} // RVA: 0x7ffab1a77e90
        public void .ctor(){} // RVA: 0x7ffab1a0a100
    }

    public class VRCTriggerRelay : MonoBehaviour
    {
        public object currentIdx; // 0x331E2830
        public object System; // 0xB40D0C60

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a8f820
        public void OnTriggerEnter(){} // RVA: 0x7ffab1a8f880
        public void OnTriggerExit(){} // RVA: 0x7ffab1a8f910
        public void .ctor(){} // RVA: 0x7ffab1a8f990
    }

    public class VRCUrl : Object
    {
        public object _domainWildcardAllowlistDelegate; // 0x345635F0, was: <DomainWildcardAllowlistDelega

        // ── Original Methods ──
        public void get_Empty(){} // RVA: 0x7ffab1a8fb50
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x7ffab1a8fbb0
        public void IsNullOrEmpty(){} // RVA: 0x7ffab1a8fe40
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x7ffab1a8fee0
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x7ffab1a8ff40
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x7ffab1a90000
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x7ffab1a90060
        public void IsAllowlistedUri(){} // RVA: 0x7ffab1a90120
        public void .ctor(){} // RVA: 0x7ffab1a90380
        public void ToString(){} // RVA: 0x7ffaa894d380
        public void Equals(){} // RVA: 0x7ffab1a90560
        public void Equals(){} // RVA: 0x7ffab1a90560
        public void .cctor(){} // RVA: 0x7ffab1a905b0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
        public void GetHashCode(){} // RVA: 0x7ffaae65c280
    }

    public class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        public object goalWeight; // 0x331D9370
        public object Initialize; // 0x331D9370

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a69d90
        public void OnStateEnter(){} // RVA: 0x7ffaad7e5c20
        public void .ctor(){} // RVA: 0x7ffab1a332f0
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        public object Initialize; // 0x33208590

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a69df0
        public void OnStateEnter(){} // RVA: 0x7ffaae8a90b0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRC_AnimatorPlayAudio : StateMachineBehaviour
    {
        public object PlaybackOrder; // 0x33D20FB0
        public object VolumeApplySettings; // 0x33D20FB0
        public object Clips; // 0x33D20FB0
        public object LoopApplySettings; // 0x33D20FB0
        public object StopOnEnter; // 0x33D20FB0
        public object playbackIndex; // 0x33D20FB0
        public object EnterState; // 0x33D20FB0

        // ── Original Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x7ffab1a69e50
        public void get_ShouldApplyPitch(){} // RVA: 0x7ffab1a69e60
        public void get_ShouldApplyClip(){} // RVA: 0x7ffab1a69e70
        public void get_ShouldApplyLoop(){} // RVA: 0x7ffab1a69e80
        public void ShouldApplySetting(){} // RVA: 0x7ffab1a69e90
        public void Awake(){} // RVA: 0x7ffab1a69f10
        public void OnStateEnter(){} // RVA: 0x7ffab1a69f70
        public void OnStateExit(){} // RVA: 0x7ffab1a69f90
        public void .ctor(){} // RVA: 0x7ffab1a33300
    }

    public class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        public object delayTime; // 0x33D063A0
        public object ApplySettings; // 0x33D063A0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a69fc0
        public void OnStateEnter(){} // RVA: 0x7ffab1a6a020
        public void OnStateUpdate(){} // RVA: 0x7ffab1a6a0b0
        public void .ctor(){} // RVA: 0x7ffab1a33350
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        public object trackingRightHand; // 0x331EB3B0
        public object trackingRightFoot; // 0x331EB3B0
        public object trackingEyes; // 0x331EB3B0
        public object Initialize; // 0x331EB3B0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a6a150
        public void OnStateEnter(){} // RVA: 0x7ffaaee06960
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        public object Animations; // 0x331E38B0
        public object lipSyncJawBone; // 0x331E38B0
        public object VisemeSkinnedMesh; // 0x331E38B0
        public object apiAvatar; // 0x331E38B0
        public object portraitCameraRotationOffset; // 0x331E38B0
        public object 蔭f; // 0x67500472
        public object 00; // 0x302FFB10
        public object List`1; // 0xB4094870

        // ── Original Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffab1a6a1b0
        public void PositionPortraitCamera(){} // RVA: 0x7ffab1a6a4f0
        public void get_NetworkIDCollection(){} // RVA: 0x7ffaa899d040
        public void set_NetworkIDCollection(){} // RVA: 0x7ffaa899d050
        public void FindNetworkIDGameObject(){} // RVA: 0x7ffab1a6aa20
        public void .ctor(){} // RVA: 0x7ffab1a6adc0
        // ── Binary Analysis Named ──
        public void GetNetworkIDObjects(){} // RVA: 0x7ffab1a6a980
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7ffab1a6ad40
    }

    public class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        public object debugString; // 0x331EA200
        public object initialized; // 0x331EA200
        public object blueprintId; // 0x33D07140

        // ── Original Methods ──
        public void OnStateEnter(){} // RVA: 0x7ffab1a6b0a0
        public void .ctor(){} // RVA: 0x7ffab1a37a60
    }

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        public object Placement; // 0x33D07140
        public object OnReceiveAvatarImage; // 0x33D07140
        public object Instantiate; // 0x33D07140

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a701c0
        public void SwitchAvatar(){} // RVA: 0x7ffab1a4c5b0
        public void SwitchAvatar(){} // RVA: 0x7ffab1a4c5b0
        public void .ctor(){} // RVA: 0x7ffab1a70810
        // ── Binary Analysis Named ──
        public void SetAvatarUse(){} // RVA: 0x7ffab1a706d0
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        public object Serialize; // 0x31A66650
        public object _GetElementIndex; // 0x31A66650

        // ── Original Methods ──
        public void add_ElementChanged(){} // RVA: 0x7ffab1a90b00
        public void remove_ElementChanged(){} // RVA: 0x7ffab1a90bf0
        public void OnDataElementChanged(){} // RVA: 0x7ffab1a90ce0
        public void Awake(){} // RVA: 0x7ffab1a90d10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetElementIndex(){} // RVA: 0x7ffab1a90a00
        public void GetElement(){} // RVA: 0x7ffab1a90a70
    }

    public class VRC_DestructibleStandard : MonoBehaviour
    {
        public object healable; // 0x331DA180
        public object healEvent; // 0x331DA180
        public object onDamagedEvent; // 0x331DA180
        public object onHealedTrigger; // 0x331DA180
        public object onFullHealedEvent; // 0x331DA180
        public object spawnerOnDestructedTrigger; // 0x331DA180
        public object spawnerOnHealedEvent; // 0x331DA180
        public object eventHandler; // 0x331DA180
        public object Unused; // 0x81044780
        public object Toggle; // 0x81044780
        public object !f;

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a6c760
        public void ApplyDamage(){} // RVA: 0x7ffab1a6c940
        public void ApplyHealing(){} // RVA: 0x7ffab1a6ced0
        public void HandleCallbackTrigger(){} // RVA: 0x7ffab1a6d600
        public void .ctor(){} // RVA: 0x7ffab19fe8a0
        public void <ApplyDamage>b__27_0(){} // RVA: 0x7ffab1a6ba30
        public void <ApplyDamage>b__27_1(){} // RVA: 0x7ffab1a6d740
        public void <ApplyHealing>b__28_0(){} // RVA: 0x7ffab1a6d740
        public void <ApplyHealing>b__28_1(){} // RVA: 0x7ffab1a6d7a0
        // ── Binary Analysis Named ──
        public void GetMaxHealth(){} // RVA: 0x7ffaa895b080
        public void GetCurrentHealth(){} // RVA: 0x7ffaa8a9ff50
        public void GetState(){} // RVA: 0x7ffab1a6d4b0
        public void SetState(){} // RVA: 0x7ffab1a6d580
    }

    public class VRC_EventDispatcher : MonoBehaviour
    {
        // ── Original Methods ──
        public void TriggerEvent(){}
        public void RegisterEventHandler(){} // RVA: 0x7ffaa8660d80
        public void UnregisterEventHandler(){} // RVA: 0x7ffaa8660d80
        public void FindGameObject(){} // RVA: 0x7ffaa8659a30
        public void FindGameObject(){} // RVA: 0x7ffaa8659a30
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetGameObjectPath(){} // RVA: 0x7ffaa8649280
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcher
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a6e4d0
        public void TriggerEvent(){} // RVA: 0x7ffaa8932310
        public void RegisterEventHandler(){} // RVA: 0x7ffaa8932310
        public void UnregisterEventHandler(){} // RVA: 0x7ffaa8932310
        public void FindGameObject(){} // RVA: 0x7ffab1a6e520
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetGameObjectPath(){} // RVA: 0x7ffab1a6e570
    }

    public class VRC_EventHandler : VRCNetworkBehaviour
    {
        public object GetInstigatorId; // 0x33208C70
        public object DeferredEventProcessor; // 0x33208C70

        // ── Original Methods ──
        public void BooleanOp(){} // RVA: 0x7ffab1a90e00
        public void get_Dispatcher(){} // RVA: 0x7ffab1a90e20
        public void get_GetInsitgatorId(){} // RVA: 0x7ffab1a90f40
        public void set_GetInsitgatorId(){} // RVA: 0x7ffab1a90f80
        public void Awake(){} // RVA: 0x7ffab1a91020
        public void VrcAnimationEvent(){} // RVA: 0x7ffab1a913c0
        public void IsReceiverRequiredForEventType(){} // RVA: 0x7ffab1a915b0
        public void TriggerEvent(){} // RVA: 0x7ffab1a92600
        public void InternalTriggerEvent(){} // RVA: 0x7ffab1a92070
        public void TriggerEvent(){} // RVA: 0x7ffab1a92600
        public void TriggerEvent(){} // RVA: 0x7ffab1a92600
        public void TriggerEvent(){} // RVA: 0x7ffab1a92600
        public void OnValidate(){} // RVA: 0x7ffab1a927f0
        public void OnDestroy(){} // RVA: 0x7ffab1a92950
        public void HasEventTrigger(){} // RVA: 0x7ffab1a92ac0
        public void IsReadyForEvents(){} // RVA: 0x7ffaa8a17850
        public void DeferEvent(){} // RVA: 0x7ffab1a92bc0
        public void ProcessDeferredEvents(){} // RVA: 0x7ffab1a92eb0
        public void .ctor(){} // RVA: 0x7ffab1a92f50
        // ── Binary Analysis Named ──
        public void GetCombinedNetworkId(){} // RVA: 0x7ffaa8f22da0
    }

    public class VRC_GunStats : MonoBehaviour
    {
        public object fullAuto; // 0x33203C10
        public object fireAudio; // 0x33203C10
        public object leftHandContact; // 0x33203C10
        public object EmptyClipFire; // 0x33203C10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab19feed0
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a939b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        public object interactTextGO; // 0x31668C00
        public object CheckValid; // 0x31668C00
        public object IsInteractive; // 0x17000047
        public object Proximity; // 0x17000048

        // ── Original Methods ──
        public void get_IsInteractive(){} // RVA: 0x7ffaa8932320
        public void get_Proximity(){} // RVA: 0x7ffaa9144a40
        public void Start(){} // RVA: 0x7ffaa8932310
        public void Awake(){} // RVA: 0x7ffab1a93d20
        public void Interact(){} // RVA: 0x7ffaa8660cc0
        public void OnPickupUseUp(){} // RVA: 0x7ffaa8932310
        public void OnPickupUseDown(){} // RVA: 0x7ffaa8932310
        public void OnPickup(){} // RVA: 0x7ffaa8932310
        public void OnDrop(){} // RVA: 0x7ffaa8932310
        public void IsInteractiveForPlayer(){} // RVA: 0x7ffab1a93d80
        public void .ctor(){} // RVA: 0x7ffab1a93e20
    }

    public class VRC_KeyEvents : MonoBehaviour
    {
        public object UpEventName; // 0x331E8330
        public object Handler; // 0x331E8330
        public object ɨf; // 0x6744A3A4

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a6b120
        public void Update(){} // RVA: 0x7ffab1a6b380
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void <Update>b__9_0(){} // RVA: 0x7ffab1a6b9d0
        public void <Update>b__9_2(){} // RVA: 0x7ffab1a6b9d0
        public void <Update>b__9_1(){} // RVA: 0x7ffab1a6ba30
        public void <Update>b__9_3(){} // RVA: 0x7ffab1a6ba30
    }

    public class VRC_Label : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a0cb90
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        public object _GetCurrentMetadata; // 0x33208F70
        public object currentMetadata; // 0x1700002C

        // ── Original Methods ──
        public void get_currentMetadata(){} // RVA: 0x7ffab1a77f00
        public void Awake(){} // RVA: 0x7ffab1a77f60
        public void OnDestroy(){} // RVA: 0x7ffab1a780d0
        public void TriggerUpdate(){} // RVA: 0x7ffab1a78240
        public void MetadataChangedInternal(){} // RVA: 0x7ffab1a782a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_MidiNoteIn : MonoBehaviour
    {
        public object OnNoteOn; // 0x331D96C0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a6fca0
        public void Start(){} // RVA: 0x7ffaa8932310
        public void Update(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_MirrorReflection : MonoBehaviour
    {
        public object m_DisablePixelLights; // 0x332097D0
        public object mirrorResolution; // 0x332097D0
        public object MirrorQualityOverride; // 0x332097D0
        public object _currentlyRenderingMirror; // 0x332097D0, was: <CurrentlyRenderingMirror>k__B
        public object _temporaryRenderTexture; // 0x332097D0
        public object _mirrorRendererMaterialInstance; // 0x332097D0
        public object _parentTransform; // 0x332097D0
        public object _texturePropertyId; // 0x332097D0
        public object MAX_AUTO_RESOLUTION_UNLIMITER; // 0x332097D0
        public object PostRenderMirror; // 0x331F5E00
        public object CurrentlyRenderingMirror; // 0x1700002D
        public object CurrentMirrorCenterEyePos; // 0x1700002E
        public object System.Collections.Generic; // 0xB412FC60

        // ── Original Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x7ffab1a782c0
        public void remove_PreRenderMirror(){} // RVA: 0x7ffab1a78410
        public void add_PostRenderMirror(){} // RVA: 0x7ffab1a78560
        public void remove_PostRenderMirror(){} // RVA: 0x7ffab1a786b0
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x7ffab1a78800
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x7ffab1a78860
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x7ffab1a78920
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x7ffab1a78990
        public void OnValidate(){} // RVA: 0x7ffab1a78a00
        public void Start(){} // RVA: 0x7ffab1a78a60
        public void TrySetupMaterial(){} // RVA: 0x7ffab1a78d20
        public void IsVisibleToCamera(){} // RVA: 0x7ffab1a79270
        public void CameraOnPreCull(){} // RVA: 0x7ffab1a79470
        public void RenderMirrorCameras(){} // RVA: 0x7ffab1a79870
        public void CameraPostRender(){} // RVA: 0x7ffab1a7ab10
        public void OnEnable(){} // RVA: 0x7ffab1a7ae10
        public void OnDisable(){} // RVA: 0x7ffab1a7b0c0
        public void OnDestroy(){} // RVA: 0x7ffab1a7b7d0
        public void ShouldRenderLeftEye(){} // RVA: 0x7ffab1a7bb20
        public void ShouldRenderRightEye(){} // RVA: 0x7ffab1a7bd30
        public void ShouldRenderMonoscopic(){} // RVA: 0x7ffab1a7bf40
        public void RenderMirror(){} // RVA: 0x7ffab1a7c640
        public void UpdateCameraClearing(){} // RVA: 0x7ffab1a7d360
        public void UpdateCameraModes(){} // RVA: 0x7ffab1a7d740
        public void UpdateParentTransform(){} // RVA: 0x7ffab1a7e0b0
        public void Plane(){} // RVA: 0x7ffab1a7f700
        public void CameraSpacePlane(){} // RVA: 0x7ffab1a7f760
        public void CalculateReflectionMatrix(){} // RVA: 0x7ffab1a7fb70
        public void CopySign(){} // RVA: 0x7ffab1a7fce0
        public void .ctor(){} // RVA: 0x7ffab1a7ff50
        public void .cctor(){} // RVA: 0x7ffab1a80060
        // ── Binary Analysis Named ──
        public void GetWorldEyePos(){} // RVA: 0x7ffab1a7c1a0
        public void GetWorldEyeRot(){} // RVA: 0x7ffab1a7c2d0
        public void GetEyeProjectionMatrix(){} // RVA: 0x7ffab1a7c4c0
        public void GetNormalDirection(){} // RVA: 0x7ffab1a7c590
        public void GetReflectionData(){} // RVA: 0x7ffab1a7ea20
        public void GetAutoResolution(){} // RVA: 0x7ffab1a7f510
        public void GetRotation(){} // RVA: 0x7ffab1a7fd10
        public void GetPosition(){} // RVA: 0x7ffaae656320
    }

    public class VRC_NPCSpawn : MonoBehaviour
    {
        public object customAnimation; // 0x33D069A0
        public object npcGameObject; // 0x33D069A0
        public object Initialize; // 0x332090F0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a708d0
        public void .ctor(){} // RVA: 0x7ffab19ffa30
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        public object _SetNamePlate; // 0x331DA000
        public object _ActThis; // 0x331DA000
        public object `;

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a6ba90
        public void ActThis(){} // RVA: 0x7ffab1a6bc00
        public void SayThis(){} // RVA: 0x7ffab1a6bc90
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetApiByGameObject(){} // RVA: 0x7ffab1a6baf0
        public void SetNamePlate(){} // RVA: 0x7ffab1a6bd20
        public void SetSocialStatus(){} // RVA: 0x7ffab1a6bdc0
        public void SetMuteStatus(){} // RVA: 0x7ffab1a6be60
    }

    public class VRC_ObjectApi : MonoBehaviour
    {
        // ── Original Methods ──
        public void ClaimControl(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_ObjectSpawn : MonoBehaviour
    {
        public object Instantiate; // 0x332090F0

        // ── Original Methods ──
        public void SpawnObject(){} // RVA: 0x7ffab1a70b90
        public void SpawnObject(){} // RVA: 0x7ffab1a70b90
        public void DestroySpawnedObjects(){} // RVA: 0x7ffaaa3505f0
        public void Start(){} // RVA: 0x7ffab1a70cb0
        public void ProvideEvents(){} // RVA: 0x7ffab1a70d10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        public object OnButtonOff; // 0x331E9C40
        public object 8؏f; // 0x67500387

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a6fd00
        public void Start(){} // RVA: 0x7ffaa8932310
        public void Update(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_Panorama : MonoBehaviour
    {
        public object currentlyShown; // 0x331E2200

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a80270
        public void Update(){} // RVA: 0x7ffab1a80440
        public void NextPano(){} // RVA: 0x7ffab1a80710
        public void PrevPano(){} // RVA: 0x7ffab1a807d0
        public void ShowPanoAt(){} // RVA: 0x7ffab1a80890
        public void ShowPano(){} // RVA: 0x7ffab1a80920
        public void .ctor(){} // RVA: 0x7ffab1a0cc60
    }

    public class VRC_PhysicsRoot : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a6bef0
        public void OnDestroy(){} // RVA: 0x7ffab1a6c520
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        public object ExactGun; // 0x331E8CF0
        public object orientation; // 0x331E8CF0
        public object UseText; // 0x331E8CF0
        public object UseUpEventName; // 0x331E8CF0
        public object DropEventName; // 0x331E8CF0
        public object currentlyHeldBy; // 0x331E8CF0
        public object proximity; // 0x331E8CF0
        public object OnDestroyed; // 0x331E8CF0
        public object _GetCurrentPlayer; // 0x331E8CF0
        public object currentPlayer; // 0x17000021
        public object IsHeld; // 0x17000022
        public object currentHand; // 0x17000023
        public object Proximity; // 0x17000024

        // ── Original Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7ffab1a71320
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7ffab1a71320
        public void get_currentPlayer(){} // RVA: 0x7ffab1a71350
        public void get_IsHeld(){} // RVA: 0x7ffab1a713c0
        public void get_currentHand(){} // RVA: 0x7ffab1a71480
        public void get_Proximity(){} // RVA: 0x7ffab1a714e0
        public void Awake(){} // RVA: 0x7ffab1a714f0
        public void OnDisable(){} // RVA: 0x7ffab1a71550
        public void Reset(){} // RVA: 0x7ffab1a71590
        public void Drop(){} // RVA: 0x7ffab1a71720
        public void Drop(){} // RVA: 0x7ffab1a71720
        public void GenerateHapticEvent(){} // RVA: 0x7ffab1a71980
        public void OnDestroy(){} // RVA: 0x7ffab1a71a20
        public void PlayHaptics(){} // RVA: 0x7ffab1a71a80
        public void ProvideEvents(){} // RVA: 0x7ffab1a71ab0
        public void .ctor(){} // RVA: 0x7ffab1a71ef0
    }

    public class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        public object blendDuration; // 0x33D07C80
        public object ApplySettings; // 0x33D07C80

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a6c640
        public void OnStateEnter(){} // RVA: 0x7ffab1a6c6a0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        public object customPortalName; // 0x331E84B0
        public object offset; // 0x331E84B0
        public object useDefaultPresentation; // 0x331E84B0
        public object roomName; // 0x331E84B0
        public object inputRightAnalog; // 0x331E34F0
        public object Initialize; // 0x331E34F0

        // ── Original Methods ──
        public void RefreshPortal(){} // RVA: 0x7ffaa8ae2e10
        public void Awake(){} // RVA: 0x7ffab1a722a0
        public void Update(){} // RVA: 0x7ffab1a72320
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_PropApi : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_PropController : MonoBehaviour
    {
        public object inputRightAnalog; // 0x331E34F0
        public object Initialize; // 0x331E34F0
        public object spawnRadius; // 0x331E8B10

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a723a0
        public void Update(){} // RVA: 0x7ffab1a72400
        public void .ctor(){} // RVA: 0x7ffab1a01180
        // ── Binary Analysis Named ──
        public void GetInputIndex(){} // RVA: 0x7ffab1a72470
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        public object DynamicPrefabs; // 0x331E2D10
        public object sDynamicMaterials; // 0x331E2D10
        public object _networkIDLookup; // 0x331E2D10, was: <NetworkIDLookup>k__BackingFie
        public object customAttributes; // 0x331E2B30

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a72570
        public void get_NetworkIDCollection(){} // RVA: 0x7ffaa89af740
        public void set_NetworkIDCollection(){} // RVA: 0x7ffaa895a200
        public void get_NetworkIDLookup(){} // RVA: 0x7ffaa89ad730
        public void set_NetworkIDLookup(){} // RVA: 0x7ffaa89ad740
        public void FindNetworkIDGameObject(){} // RVA: 0x7ffab1a73040
        public void .ctor(){} // RVA: 0x7ffab1a73360
        // ── Binary Analysis Named ──
        public void GetNetworkIDObjects(){} // RVA: 0x7ffab1a72fa0
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7ffab1a6ad40
    }

    public class VRC_SceneDescriptor : MonoBehaviour
    {
        public object spawnOrder; // 0x331E8B10
        public object RespawnHeightY; // 0x331E8B10
        public object interactThruLayers; // 0x331E8B10
        public object layerCollisionArr; // 0x331E8B10
        public object contentViolence; // 0x331E8B10
        public object releasePublic; // 0x331E8B10
        public object Name; // 0x331E8B10
        public object SpawnLocation; // 0x331E8B10
        public object DynamicPrefabs; // 0x331E8B10
        public object sDynamicMaterials; // 0x331E8B10
        public object LightMode; // 0x331E8B10
        public object RenderAmbientIntensity; // 0x331E8B10
        public object RenderAmbientProbe; // 0x331E8B10
        public object RenderFogColor; // 0x331E8B10
        public object RenderFogLinearStart; // 0x331E8B10
        public object RenderFlareFadeSpeed; // 0x331E8B10
        public object RenderDefaultReflectionMode; // 0x331E8B10
        public object RenderReflectionIntensity; // 0x331E8B10
        public object _networkIDLookup; // 0x331E8B10, was: <NetworkIDLookup>k__BackingFie
        public object apiWorld; // 0x331E8B10
        public object _scene; // 0x331E8B10

        // ── Original Methods ──
        public void get_NetworkIDCollection(){} // RVA: 0x7ffaa93e8b10
        public void set_NetworkIDCollection(){} // RVA: 0x7ffaa9400010
        public void get_NetworkIDLookup(){} // RVA: 0x7ffaa8e19790
        public void set_NetworkIDLookup(){} // RVA: 0x7ffaa93fdbe0
        public void FindNetworkIDGameObject(){} // RVA: 0x7ffab1a81f60
        public void get_Instance(){} // RVA: 0x7ffab1a824c0
        public void get_Exists(){} // RVA: 0x7ffab1a827d0
        public void get_BundleUnityMajorVersion(){} // RVA: 0x7ffab1a828d0
        public void set_BundleUnityMajorVersion(){} // RVA: 0x7ffab1a828e0
        public void get_Scene(){} // RVA: 0x7ffaaa1cc160
        public void set_Scene(){} // RVA: 0x7ffaaa1cc170
        public void Awake(){} // RVA: 0x7ffab1a828f0
        public void OnDestroy(){} // RVA: 0x7ffab1a838c0
        public void PositionPortraitCamera(){} // RVA: 0x7ffab1a83980
        public void .ctor(){} // RVA: 0x7ffab1a83d50
        public void .cctor(){} // RVA: 0x7ffab1a84080
        // ── Binary Analysis Named ──
        public void GetValidatedSpawnList(){} // RVA: 0x7ffab1a812a0
        public void GetPrefab(){} // RVA: 0x7ffab1a81490
        public void GetMaterial(){} // RVA: 0x7ffab1a81880
        public void GetNetworkIDObjects(){} // RVA: 0x7ffab1a81c70
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7ffab1a6ad40
    }

    public class VRC_Serialization : Object
    {
        public object _allowPluginTypes; // 0x367EDCC0, was: <AllowPluginTypes>k__BackingFi

        // ── Original Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x7ffab1a93ee0
        public void set_AllowPluginTypes(){} // RVA: 0x7ffab1a93f40
        public void get_SurrogateSelector(){} // RVA: 0x7ffab1a93fa0
        public void RegisterPluginType(){} // RVA: 0x7ffab1a940b0
        public void RegisterType(){} // RVA: 0x7ffab1a941a0
        public void ParameterEncoder(){} // RVA: 0x7ffab1a94290
        public void ParameterDecoder(){} // RVA: 0x7ffab1a944a0
        public void get_Dispatcher(){} // RVA: 0x7ffab1a94710
        public void FindGameObject(){} // RVA: 0x7ffab1a94c00
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffab1a94d60
        // ── Binary Analysis Named ──
        public void GetGameObjectPathFallback(){} // RVA: 0x7ffab1a94850
        public void GetGameObjectPath(){} // RVA: 0x7ffab1a94ac0
    }

    public class VRC_SlideShow : MonoBehaviour
    {
        public object images; // 0x331EB970
        public object showingImage; // 0x331EB970
        public object System; // 0xB4113F20

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a73580
        public void ShowNextImage(){} // RVA: 0x7ffab1a73640
        public void ShowPreviousImage(){} // RVA: 0x7ffab1a73860
        public void StartAutoplayWithDuration(){} // RVA: 0x7ffab1a73a30
        public void StopAutoplayWithDuration(){} // RVA: 0x7ffab1a73af0
        public void .ctor(){} // RVA: 0x7ffab1a01280
    }

    public class VRC_SpatialAudioSource : MonoBehaviour
    {
        public object Near; // 0x331EBC70
        public object UseAudioSourceVolumeCurve; // 0x331EBC70
        public object 00; // 0x367E4030
        public object 00; // 0x400004E

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a637b0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffab1a63a50
        public void .ctor(){} // RVA: 0x7ffab19fd900
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        // ── Original Methods ──
        public void Apply(){} // RVA: 0x7ffab1a84370
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_StereoObject : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_TimedEvents : MonoBehaviour
    {
        public object HighPeriodTime; // 0x331E9490
        public object BroadcastType; // 0x331E9490
        public object Timer; // 0x331E9490
        public object value__; // 0x343AE120

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a845a0
        public void OnEnable(){} // RVA: 0x7ffab1a84770
        public void Update(){} // RVA: 0x7ffab1a84780
        public void ResetClock(){} // RVA: 0x7ffab1a84910
        public void .ctor(){} // RVA: 0x7ffab1a0a1c0
    }

    public class VRC_Trigger : VRC_Interactable
    {
        public object UsesAdvancedOptions; // 0x33D23330
        public object EditorGlobalTriggerLineMode; // 0x33D23330

        // ── Original Methods ──
        public void TriggerCustom(){} // RVA: 0x7ffab1a84c20
        public void Trigger(){} // RVA: 0x7ffab1a84a90
        public void TriggerCustom(){} // RVA: 0x7ffab1a84c20
        public void get_HasKeyTriggers(){} // RVA: 0x7ffab1a84db0
        public void get_HasTimerTriggers(){} // RVA: 0x7ffab1a84f20
        public void get_HasColliderTriggers(){} // RVA: 0x7ffab1a85090
        public void get_HasInteractiveTriggers(){} // RVA: 0x7ffab1a85330
        public void get_HasPickupTriggers(){} // RVA: 0x7ffab1a854a0
        public void get_IsInteractive(){} // RVA: 0x7ffab1a85610
        public void Awake(){} // RVA: 0x7ffab1a858f0
        public void OnDestroy(){} // RVA: 0x7ffab1a859a0
        public void OnEnable(){} // RVA: 0x7ffab1a859b0
        public void OnDisable(){} // RVA: 0x7ffab1a859e0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffab1a85a10
        public void Interact(){} // RVA: 0x7ffab1a85fc0
        public void OnPickupUseUp(){} // RVA: 0x7ffab1a85fd0
        public void OnPickupUseDown(){} // RVA: 0x7ffab1a85fe0
        public void OnPickup(){} // RVA: 0x7ffab1a85ff0
        public void OnDrop(){} // RVA: 0x7ffab1a86000
        public void ExecuteTriggers(){} // RVA: 0x7ffab1a86010
        public void ExecuteTriggerType(){} // RVA: 0x7ffab1a86310
        public void ExecuteCustomTrigger(){} // RVA: 0x7ffab1a86670
        public void ResetClocks(){} // RVA: 0x7ffab1a86a60
        public void ResetClock(){} // RVA: 0x7ffab1a86dd0
        public void .ctor(){} // RVA: 0x7ffab1a0a220
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x7ffab1a86e60
    }

    public class VRC_TriggerColliderEventTrigger : MonoBehaviour
    {
        public object TriggerIndividuals; // 0x332020D0
        public object CollisionEnter; // 0x332020D0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1a87e10
        public void OnTriggerEnter(){} // RVA: 0x7ffab1a87fd0
        public void OnTriggerExit(){} // RVA: 0x7ffab1a88110
        public void .ctor(){} // RVA: 0x7ffab1a0a2f0
    }

    public class VRC_TutorialAction : MonoBehaviour
    {
        // ── Original Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7ffab1a8d6b0
        public void ActivateObjectLabel(){} // RVA: 0x7ffab1a8d8b0
        public void ActivateObjectLabel(){} // RVA: 0x7ffab1a8d8b0
        public void ActivateObjectLabel(){} // RVA: 0x7ffab1a8d8b0
        public void DeactivateObjectLabel(){} // RVA: 0x7ffab1a8d940
        public void ActivateControllerLabel(){} // RVA: 0x7ffab1a8d9a0
        public void DeactivateControllerLabel(){} // RVA: 0x7ffab1a8d9d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRC_TutorialAreaMarker : MonoBehaviour
    {
        public object MaxVisibleDistance; // 0x33D20B30
        public object _enabled; // 0x33D20B30

        // ── Original Methods ──
        public void Enable(){} // RVA: 0x7ffaadc7ab30
        public void Update(){} // RVA: 0x7ffab1a8d9e0
        public void ShowLabel(){} // RVA: 0x7ffab1a8de10
        public void .ctor(){} // RVA: 0x7ffab1a0a6b0
    }

    public class VRC_UiShape : MonoBehaviour
    {
        public object _rootCanvasRectTransform; // 0x331E0970, was: <RootCanvasRectTransform>k__Ba
        public object _localRectTransform; // 0x331E0970

        // ── Original Methods ──
        public void get_RootCanvas(){} // RVA: 0x7ffaa89600c0
        public void set_RootCanvas(){} // RVA: 0x7ffaa89600d0
        public void get_RootCanvasRectTransform(){} // RVA: 0x7ffaa8960130
        public void set_RootCanvasRectTransform(){} // RVA: 0x7ffaa8933e90
        public void add_OnUiShapeInit(){} // RVA: 0x7ffab1a8e990
        public void remove_OnUiShapeInit(){} // RVA: 0x7ffab1a8ead0
        public void add_OnUiShapeDestroy(){} // RVA: 0x7ffab1a8ec10
        public void remove_OnUiShapeDestroy(){} // RVA: 0x7ffab1a8ed50
        public void Awake(){} // RVA: 0x7ffab1a8ee90
        public void Start(){} // RVA: 0x7ffab1a8f030
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffab1a8f390
        public void OnDestroy(){} // RVA: 0x7ffab1a8f7c0
        public void .ctor(){} // RVA: 0x7ffaa89e6710
        // ── Binary Analysis Named ──
        public void SetupCollision(){} // RVA: 0x7ffab1a8f3a0
    }

    public class VRC_UseEvents : VRC_Interactable
    {
        public object BroadcastType; // 0x33D05C30

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a88250
        public void Start(){} // RVA: 0x7ffab1a88490
        public void Interact(){} // RVA: 0x7ffab1a88720
        public void .ctor(){} // RVA: 0x7ffab1a0a340
        public void <Awake>b__5_0(){} // RVA: 0x7ffab1a88900
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        public object offset; // 0x331E3070
        public object renderer; // 0x331E3070

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab1a6d800
        public void Start(){} // RVA: 0x7ffab1a6d890
        public void OnSceneWasLoaded(){} // RVA: 0x7ffab1a6dac0
        public void Update(){} // RVA: 0x7ffab1a6db60
        public void HideDamageIndicator(){} // RVA: 0x7ffab1a6dd90
        public void ShowDamageIndicator(){} // RVA: 0x7ffab1a6deb0
        public void .ctor(){} // RVA: 0x7ffab1a6e2d0
        // ── Binary Analysis Named ──
        public void SetDamagePercent(){} // RVA: 0x7ffab1a6dfd0
    }

    public class VRC_Water : MonoBehaviour
    {
        public object textureSize; // 0x332081B0
        public object refractLayers; // 0x332081B0
        public object m_RefractionCameras; // 0x332081B0
        public object m_HardwareWaterSupport; // 0x332081B0
        public object s_InsideWater; // 0x332081B0

        // ── Original Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7ffab1a88a10
        public void OnDisable(){} // RVA: 0x7ffab1a896f0
        public void Update(){} // RVA: 0x7ffab1a89d40
        public void UpdateCameraModes(){} // RVA: 0x7ffab1a8a210
        public void CreateWaterObjects(){} // RVA: 0x7ffab1a8a790
        public void FindHardwareWaterSupport(){} // RVA: 0x7ffab1a8bb60
        public void CameraSpacePlane(){} // RVA: 0x7ffaa8949d00
        public void CalculateReflectionMatrix(){} // RVA: 0x7ffaa894a0f0
        public void .ctor(){} // RVA: 0x7ffab1a0a3e0
        // ── Binary Analysis Named ──
        public void GetWaterMode(){} // RVA: 0x7ffab1a8bb50
    }

    public class VRC_WebPanel : VRC_Interactable
    {
        public object resolutionWidth; // 0x33D06600
        public object interactive; // 0x33D06600
        public object localOnly; // 0x33D06600
        public object syncDisplayAndAudio; // 0x33D06600
        public object station; // 0x33D06600
        public object webData; // 0x33D06600
        public object _WebPanelBackward; // 0x33D06600
        public object _BindCall; // 0x33D06600
        public object WebRootPath; // 0x1700003D
        public object 00; // 0x4000003
        public object 00; // 0x4000006

        // ── Original Methods ──
        public void WebPanelForward(){} // RVA: 0x7ffab1a8be50
        public void WebPanelBackward(){} // RVA: 0x7ffab1a8be80
        public void WebPanelReload(){} // RVA: 0x7ffab1a8beb0
        public void BindCall(){} // RVA: 0x7ffab1a8bee0
        public void NavigateTo(){} // RVA: 0x7ffab1a8bf10
        public void Awake(){} // RVA: 0x7ffab1a8bf40
        public void Interact(){} // RVA: 0x7ffaa8932310
        public void get_WebRootPath(){} // RVA: 0x7ffab1a8c050
        public void ProvideEvents(){} // RVA: 0x7ffab1a8c1c0
        public void ReadData(){} // RVA: 0x7ffab1a8caf0
        public void ImportWebData(){} // RVA: 0x7ffab1a8cd50
        public void .ctor(){} // RVA: 0x7ffab1a0a580
    }

    public class VersionHelper : Object
    {
        // ── Binary Analysis Named ──
        public void GetLatestVersion(){} // RVA: 0x7ffaa887e5c0
    }

}