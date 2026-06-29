// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 88
// Methods: 830

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        // ── Methods ──
        public void get_boolVal(){} // RVA: 0x87D280
        public void set_boolVal(){} // RVA: 0x894750
        public void get_intVal(){} // RVA: 0x87C130
        public void set_intVal(){} // RVA: 0x8944F0
        public void get_floatVal(){} // RVA: 0x890F90
        public void set_floatVal(){} // RVA: 0x8A23A0
    }

    public class INetworkIDContainer
    {
        // ── Methods ──
        public void get_NetworkIDCollection(){} // RVA: 0x87C0A0
        public void set_NetworkIDCollection(){} // RVA: 0x894320
        public void GetNetworkIDObjects(){} // RVA: 0x894320
        public void FindNetworkIDGameObject(){} // RVA: 0x87D1A0
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x87C5F0
    }

    public class INetworkID[] : Array
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

    public class IPreprocessCallbackBehaviour
    {
        // ── Methods ──
        public void OnPreprocess(){} // RVA: 0x87D280
        public void get_PreprocessOrder(){} // RVA: 0x87C130
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0x87C0A0
    }

    public class IVRC_Destructible
    {
        // ── Methods ──
        public void GetState(){} // RVA: 0x87C0A0
        public void SetState(){} // RVA: 0x894320
        public void GetMaxHealth(){} // RVA: 0x890F90
        public void GetCurrentHealth(){} // RVA: 0x890F90
        public void ApplyDamage(){} // RVA: 0x8A23A0
        public void ApplyHealing(){} // RVA: 0x8A23A0
    }

    public class IValidChecker
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x87D280
    }

    public class InputManager : Object
    {
        public object _IsUsingHandController;
        public object _GetLastUsedInputMethod;
        public object _GetInputSetting;
        public object _SetInputSetting;
        public object _EnableObjectHighlight;

        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0xA74A620
        public void GetLastUsedInputMethod(){} // RVA: 0xA74A680
        public void GetBoolInputSetting(){} // RVA: 0xA74A6F0
        public void SetBoolInputSetting(){} // RVA: 0xA74A750
        public void EnableObjectHighlight(){} // RVA: 0xA74A8C0
    }

    public class MathUtil : Object
    {
        public object PI;
        public object TWO_PI;
        public object HALF_PI;
        public object QUARTER_PI;

        // ── Methods ──
        public void AngleBetweenTwoUnitVectors(){} // RVA: 0xA726AC0
        public void AngleClosestBetweenTwoUnitVectors(){} // RVA: 0xA0C0C00
        public void ClosestPointOnLineSegment_Value(){} // RVA: 0xA726CC0
        public void ClosestPointOnLineSegment(){} // RVA: 0xA0C0DC0
        public void ClosestPointOnPlane(){} // RVA: 0xA0C0EE0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA726D70
    }

    public class Networking : Object
    {
        public object _GetSimulationTime;
        public object _GetUniqueName;
        public object _RPC;
        public object _RPCtoPlayer;
        public object _IsNetworkSettled;
        public object _IsMaster;
        public object _IsSuffering;
        public object _IsInstanceOwner;
        public object _LocalPlayer;
        public object _GetMaster;
        public object _GetInstanceOwner;
        public object _IsOwner;
        public object _SetOwner;
        public object _IsObjectReady;
        public object _Instantiate;
        public object _GetOwner;
        public object _ParameterEncoder;
        public object _ParameterDecoder;
        public object _Destroy;
        public object _SceneEventHandler;
        public object _GoToRoom;
        public object _GetNetworkDateTime;
        public object _GetServerTimeInSeconds;
        public object _GetServerTimeInMilliseconds;
        public object _CalculateServerDeltaTime;
        public object _SafeStartCoroutine;
        public object _GetEventDispatcher;
        public object _GetPlayerPersistence;
        public object _GetPlayerDataStorageUsage;
        public object _GetPlayerObjectStorageUsage;
        public object _GetPlayerDataStorageLimit;
        public object _GetPlayerObjectStorageLimit;
        public object _FindComponentInPlayerObjects;
        public object _RequestStorageUsageUpdate;

        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0xA725970
        public void get_IsNetworkSettled(){} // RVA: 0xA7259D0
        public void get_IsMaster(){} // RVA: 0xA725A30
        public void get_IsClogged(){} // RVA: 0xA725A90
        public void get_IsInstanceOwner(){} // RVA: 0xA725AF0
        public void get_LocalPlayer(){} // RVA: 0xA725B50
        public void get_Master(){} // RVA: 0xA725BB0
        public void get_InstanceOwner(){} // RVA: 0xA725C10
        public void IsOwner(){} // RVA: 0xA725CF0
        public void GetOwner(){} // RVA: 0xA725DB0
        public void SetOwner(){} // RVA: 0xA725E20
        public void IsObjectReady(){} // RVA: 0xA725E90
        public void Instantiate(){} // RVA: 0xA725F00
        public void RPC(){} // RVA: 0xA726050
        public void EncodeParameters(){} // RVA: 0xA7260F0
        public void DecodeParameters(){} // RVA: 0xA726160
        public void Destroy(){} // RVA: 0xA7261D0
        public void GetUniqueName(){} // RVA: 0xA726240
        public void GoToRoom(){} // RVA: 0xA7262B0
        public void GetNetworkDateTime(){} // RVA: 0xA726320
        public void GetServerTimeInSeconds(){} // RVA: 0xA7263C0
        public void GetServerTimeInMilliseconds(){} // RVA: 0xA726470
        public void CalculateServerDeltaTime(){} // RVA: 0xA726520
        public void SafeStartCoroutine(){} // RVA: 0xA7265B0
        public void GetEventDispatcher(){} // RVA: 0xA726620
        public void SimulationTime(){} // RVA: 0xA726730
        public void RequestStorageUsageUpdate(){} // RVA: 0x863BEC0
        public void GetPlayerObjects(){} // RVA: 0xA71DF20
        public void GetPlayerDataStorageLimit(){} // RVA: 0xA7267E0
        public void GetPlayerObjectStorageLimit(){} // RVA: 0xA726840
        public void GetPlayerDataStorageUsage(){} // RVA: 0xA7268A0
        public void GetPlayerObjectStorageUsage(){} // RVA: 0xA726910
        public void FindComponentInPlayerObjects(){} // RVA: 0xA726980
    }

    public class RPC : Attribute
    {
        public object allowedTargets;
        public object shortCode;
        public object playerRateLimit;
        public object globalRateLimit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7255C0
        public void SetupTargets(){} // RVA: 0xA7255E0
    }

    public class RPCIgnoredType : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RPC[] : Array
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

    public class Tutorial : Object
    {
        public object _ActivateObjectLabel;
        public object _DeactivateObjectLabel;
        public object _ActivateControllerLabel;
        public object _DeactivateControllerLabel;

        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0xA744D50
        public void ActivateObjectLabel(){} // RVA: 0xA744F60
        public void DeactivateObjectLabel(){} // RVA: 0xA745050
        public void ActivateControllerLabel(){} // RVA: 0xA7450B0
        public void DeactivateControllerLabel(){} // RVA: 0xA745150
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Utilities : Object
    {
        public object _isClient;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA752AD0
        public void ShuffleArray(){} // RVA: 0xA752C20
        public void IsClient(){} // RVA: 0xA752D50
        public void SetIsClient(){} // RVA: 0xA752D90
        public void Fletcher32Fast(){} // RVA: 0xA752DD0
    }

    public class VRCBuiltInShaderGlobals : MonoBehaviour
    {
        public object _vrcTimeUTCUnixSecondsID;
        public object _vrcTimeNetworkMsID;
        public object _vrcTimeEncoded1ID;
        public object _vrcTimeEncoded2ID;
        public object _instance;
        public object _getPreferredTimezoneDelegate;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0xA72A590
        public void set_Instance(){} // RVA: 0xA72A5F0
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0xB700F0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0xB70100
        public void Update(){} // RVA: 0xA72A6B0
        public void OnDestroy(){} // RVA: 0xA72AD50
        public void Initialize(){} // RVA: 0xA72B040
        public void .ctor(){} // RVA: 0xB43D60
        public void .cctor(){} // RVA: 0xA72B450
    }

    public class VRCCustomAction : MonoBehaviour
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0xA72E730
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCDroneApi : Object
    {
        public object _GetDroneFromGameObject;

        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0xA725180
        public void GetPlayer(){} // RVA: 0x87C0A0
        public void IsDeployed(){} // RVA: 0x87D280
        public void TryGetPosition(){} // RVA: 0x87D350
        public void GetPosition(){} // RVA: 0x87BEB0
        public void TryGetRotation(){} // RVA: 0x87D350
        public void GetRotation(){} // RVA: 0x87BEB0
        public void TryGetVelocity(){} // RVA: 0x87D350
        public void GetVelocity(){} // RVA: 0x87BEB0
        public void TeleportTo(){} // RVA: 0x89AA50
        public void SetVelocity(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VRCGraphics : Object
    {
        public object _uiLayerMaskLazy;

        // ── Methods ──
        public void get_UiLayerMask(){} // RVA: 0xA72B7A0
        public void Blit(){} // RVA: 0xA72BE80
        public void DrawMeshInstanced(){} // RVA: 0xA72C900
        public void GetLayerMask(){} // RVA: 0xA72CA60
        public void CheckBlitTarget(){} // RVA: 0xA72CA70
        public void .cctor(){} // RVA: 0xA72CB80
    }

    public class VRCPlayerApi : Object
    {
        public object _isMasterDelegate;
        public object _isInstanceOwnerDelegate;
        public object _isModeratorDelegate;
        public object _isSuperDelegate;
        public object _isSuspendedDelegate;
        public object _isVRCPlusDelegate;
        public object isLocal;
        public object displayName;
        public object SetAnimatorBool;
        public object ClaimNetworkControl;
        public object GetLookRay;
        public object IsGrounded;
        public object _GetDroneApi;
        public object sPlayers;
        public object mPlayerId;
        public object _GetPlayerId;
        public object _GetPlayerByGameObject;
        public object _GetPlayerById;
        public object _IsOwner;
        public object _TakeOwnership;
        public object _GetTrackingData;
        public object _GetBoneTransform;
        public object _GetBonePosition;
        public object _GetBoneRotation;
        public object _GetPickupInHand;
        public object _PlayHapticEventInHand;
        public object _TeleportTo;
        public object _TeleportToOrientation;
        public object _TeleportToOrientationLerp;
        public object _Respawn;
        public object _RespawnWithIndex;
        public object _EnablePickups;
        public object _GetAvailableLanguages;
        public object _GetCurrentLanguage;
        public object _SetNamePlateColor;
        public object _RestoreNamePlateColor;
        public object _SetNamePlateVisibility;
        public object _RestoreNamePlateVisibility;
        public object _SetPlayerTag;
        public object _GetPlayerTag;
        public object _GetPlayersWithTag;
        public object _ClearPlayerTags;
        public object _SetInvisibleToTagged;
        public object _SetInvisibleToUntagged;
        public object _SetSilencedToTagged;
        public object _SetSilencedToUntagged;
        public object _ClearInvisible;
        public object _ClearSilence;
        public object _SetRunSpeed;
        public object _SetWalkSpeed;
        public object _SetStrafeSpeed;
        public object _SetJumpImpulse;
        public object _SetGravityStrength;
        public object _GetRunSpeed;
        public object _GetWalkSpeed;
        public object _GetStrafeSpeed;
        public object _GetJumpImpulse;
        public object _GetGravityStrength;
        public object _SetVoiceGain;
        public object _SetVoiceDistanceNear;
        public object _SetVoiceDistanceFar;
        public object _SetVoiceVolumetricRadius;
        public object _SetVoiceLowpass;
        public object _GetVoiceGain;
        public object _GetVoiceDistanceNear;
        public object _GetVoiceDistanceFar;
        public object _GetVoiceVolumetricRadius;
        public object _GetVoiceLowpass;
        public object _SetAvatarAudioGain;
        public object _SetAvatarAudioFarRadius;
        public object _SetAvatarAudioNearRadius;
        public object _SetAvatarAudioVolumetricRadius;
        public object _SetAvatarAudioForceSpatial;
        public object _SetAvatarAudioCustomCurve;
        public object _CombatSetup;
        public object _CombatSetMaxHitpoints;
        public object _CombatSetCurrentHitpoints;
        public object _CombatGetCurrentHitpoints;
        public object _CombatSetRespawn;
        public object _CombatSetDamageGraphic;
        public object _CombatGetDestructible;
        public object _IsUserInVR;
        public object _UseLegacyLocomotion;
        public object _UseAttachedStation;
        public object _PushAnimations;
        public object _PopAnimations;
        public object _Immobilize;
        public object _SetVelocity;
        public object _GetVelocity;
        public object _GetPosition;
        public object _GetRotation;
        public object gameObject;
        public object _isValid;
        public object _GetAvatarEyeHeightAsMeters;
        public object _GetAvatarEyeHeightMaximumAsMeters;
        public object _GetAvatarEyeHeightMinimumAsMeters;
        public object _GetManualAvatarScalingAllowed;
        public object _SetAvatarEyeHeightByMeters;
        public object _SetAvatarEyeHeightByMultiplier;
        public object _SetAvatarEyeHeightMaximumByMeters;
        public object _SetAvatarEyeHeightMinimumByMeters;
        public object _SetManualAvatarScalingAllowed;

        // ── Methods ──
        public void get_isMaster(){} // RVA: 0xA71AFF0
        public void get_isInstanceOwner(){} // RVA: 0xA71B070
        public void get_isModerator(){} // RVA: 0xA71B0F0
        public void get_isSuper(){} // RVA: 0xA71B170
        public void get_isSuspended(){} // RVA: 0xA71B1F0
        public void get_isVRCPlus(){} // RVA: 0xA71B270
        public void IsPlayerGrounded(){} // RVA: 0xA71B2F0
        public void GetDrone(){} // RVA: 0xA71B390
        public void get_AllPlayers(){} // RVA: 0xA71B410
        public void GetPlayers(){} // RVA: 0xA71B520
        public void GetPlayerCount(){} // RVA: 0xA71B5C0
        public void GetPlayerId(){} // RVA: 0xA71B640
        public void get_playerId(){} // RVA: 0xA71B6C0
        public void GetPlayerByGameObject(){} // RVA: 0xA71B720
        public void GetPlayerById(){} // RVA: 0xA71B7A0
        public void IsValid(){} // RVA: 0xB68DF0
        public void IsOwner(){} // RVA: 0xA71B820
        public void TakeOwnership(){} // RVA: 0xA71B8B0
        public void GetTrackingData(){} // RVA: 0xA71B940
        public void GetBoneTransform(){} // RVA: 0xA71BA00
        public void GetBonePosition(){} // RVA: 0xA71BA90
        public void GetBoneRotation(){} // RVA: 0xA71BB50
        public void GetPickupInHand(){} // RVA: 0xA71BC00
        public void SetPickupInHand(){} // RVA: 0xB43310
        public void PlayHapticEventInHand(){} // RVA: 0xA71BC90
        public void TeleportTo(){} // RVA: 0xA71BF50
        public void Respawn(){} // RVA: 0xA71C0D0
        public void EnablePickups(){} // RVA: 0xA71C160
        public void SetNamePlateColor(){} // RVA: 0xA71C1F0
        public void RestoreNamePlateColor(){} // RVA: 0xA71C290
        public void SetNamePlateVisibility(){} // RVA: 0xA71C310
        public void RestoreNamePlateVisibility(){} // RVA: 0xA71C3A0
        public void SetPlayerTag(){} // RVA: 0xA71C420
        public void GetPlayerTag(){} // RVA: 0xA71C4C0
        public void GetPlayersWithTag(){} // RVA: 0xDAC980
        public void ClearPlayerTags(){} // RVA: 0xA71C550
        public void SetInvisibleToTagged(){} // RVA: 0xA71C5D0
        public void SetInvisibleToUntagged(){} // RVA: 0xA71C690
        public void SetSilencedToTagged(){} // RVA: 0xA71C750
        public void SetSilencedToUntagged(){} // RVA: 0xA71C800
        public void SetRunSpeed(){} // RVA: 0xA71C8B0
        public void SetWalkSpeed(){} // RVA: 0xA71C940
        public void SetStrafeSpeed(){} // RVA: 0xA71C9D0
        public void SetJumpImpulse(){} // RVA: 0xA71CA60
        public void GetGravityStrength(){} // RVA: 0xA71CAF0
        public void GetRunSpeed(){} // RVA: 0xA71CB70
        public void GetWalkSpeed(){} // RVA: 0xA71CBF0
        public void GetStrafeSpeed(){} // RVA: 0xA71CC70
        public void GetJumpImpulse(){} // RVA: 0xA71CCF0
        public void IsUserInVR(){} // RVA: 0xA71CD70
        public void SetGravityStrength(){} // RVA: 0xA71CDF0
        public void UseLegacyLocomotion(){} // RVA: 0xA71CE80
        public void UseAttachedStation(){} // RVA: 0xA71CF00
        public void ClearInvisible(){} // RVA: 0xA71CF80
        public void ClearSilence(){} // RVA: 0xA71D000
        public void AddToList(){} // RVA: 0xA71D080
        public void RemoveFromList(){} // RVA: 0xA71D110
        public void CombatSetup(){} // RVA: 0xA71D1A0
        public void CombatSetMaxHitpoints(){} // RVA: 0xA71D220
        public void CombatSetCurrentHitpoints(){} // RVA: 0xA71D2B0
        public void CombatGetCurrentHitpoints(){} // RVA: 0xA71D340
        public void CombatSetRespawn(){} // RVA: 0xA71D3C0
        public void CombatSetDamageGraphic(){} // RVA: 0xA71D480
        public void CombatGetDestructible(){} // RVA: 0xA71D510
        public void SetVoiceGain(){} // RVA: 0xA71D590
        public void GetVoiceGain(){} // RVA: 0xA71D620
        public void SetVoiceDistanceNear(){} // RVA: 0xA71D6A0
        public void GetVoiceDistanceNear(){} // RVA: 0xA71D730
        public void SetVoiceDistanceFar(){} // RVA: 0xA71D7B0
        public void GetVoiceDistanceFar(){} // RVA: 0xA71D840
        public void SetVoiceVolumetricRadius(){} // RVA: 0xA71D8C0
        public void GetVoiceVolumetricRadius(){} // RVA: 0xA71D950
        public void SetVoiceLowpass(){} // RVA: 0xA71D9D0
        public void GetVoiceLowpass(){} // RVA: 0xA71DA60
        public void SetAvatarAudioGain(){} // RVA: 0xA71DAE0
        public void SetAvatarAudioFarRadius(){} // RVA: 0xA71DB70
        public void SetAvatarAudioNearRadius(){} // RVA: 0xA71DC00
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0xA71DC90
        public void SetAvatarAudioForceSpatial(){} // RVA: 0xA71DD20
        public void SetAvatarAudioCustomCurve(){} // RVA: 0xA71DDB0
        public void GetAvailableLanguages(){} // RVA: 0xA71DE40
        public void GetCurrentLanguage(){} // RVA: 0xA71DEB0
        public void GetPlayerObjects(){} // RVA: 0xA71DF20
        public void FindComponentInPlayerObjects(){} // RVA: 0xA71DFC0
        public void PushAnimations(){} // RVA: 0xA71DFD0
        public void PopAnimations(){} // RVA: 0xA71E060
        public void Immobilize(){} // RVA: 0xA71E0E0
        public void SetVelocity(){} // RVA: 0xA71E170
        public void GetVelocity(){} // RVA: 0xA71E210
        public void GetPosition(){} // RVA: 0xA71E2B0
        public void GetRotation(){} // RVA: 0xA71E350
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0xA71E3F0
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0xA71E470
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0xA71E4F0
        public void GetManualAvatarScalingAllowed(){} // RVA: 0xA71E570
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0xA71E5F0
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0xA71E680
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0xA71E710
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0xA71E7A0
        public void SetManualAvatarScalingAllowed(){} // RVA: 0xA71E830
        public void .ctor(){} // RVA: 0xA71E8C0
        public void .cctor(){} // RVA: 0xA71E950
    }

    public class VRCPlayerApi[] : Array
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

    public class VRCRenderTexture : Object
    {
        public object OnGetTemporaryRenderTexture;
        public object OnReleaseTemporaryRenderTexture;

        // ── Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0xA72CD80
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0xA72CEB0
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0xA72CFE0
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0xA72D120
        public void GetTemporary(){} // RVA: 0xA72D340
        public void ReleaseTemporary(){} // RVA: 0xA72D3D0
    }

    public class VRCShader : Object
    {
        public object OnSetGlobalShaderVariable;
        public object _globalVariableIDWhitelist;
        public object _variableNameWhitelist;

        // ── Methods ──
        public void add_OnSetGlobalShaderVariable(){} // RVA: 0xA72D4B0
        public void remove_OnSetGlobalShaderVariable(){} // RVA: 0xA72D610
        public void PropertyToID(){} // RVA: 0xA72D770
        public void SetGlobalInteger(){} // RVA: 0xA72DA60
        public void SetGlobalFloat(){} // RVA: 0xA72DB30
        public void SetGlobalTexture(){} // RVA: 0xA72DC00
        public void SetGlobalColor(){} // RVA: 0xA72DD10
        public void SetGlobalVector(){} // RVA: 0xA72DE20
        public void SetGlobalMatrix(){} // RVA: 0xA72DF00
        public void SetGlobalFloatArray(){} // RVA: 0xA72DFF0
        public void SetGlobalVectorArray(){} // RVA: 0xA72E090
        public void SetGlobalMatrixArray(){} // RVA: 0xA72E130
        public void ValidateAgainstPropertyIDWhitelist(){} // RVA: 0xA72E1D0
        public void ClearGlobalVariableWhitelist(){} // RVA: 0xA72E2E0
        public void .cctor(){} // RVA: 0xA72E3A0
    }

    public class VRCStation : MonoBehaviour
    {
        public object PlayerMobility;
        public object canUseStationFromStation;
        public object animatorController;
        public object disableStationExit;
        public object seated;
        public object stationEnterPlayerLocation;
        public object stationExitPlayerLocation;
        public object controlsObject;
        public object Initialize;
        public object useStationDelegate;
        public object exitStationDelegate;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA72E7F0
        public void UseStation(){} // RVA: 0xA72E850
        public void ExitStation(){} // RVA: 0xA72E8C0
        public void .ctor(){} // RVA: 0xA69D290
    }

    public class VRCStation[] : Array
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

    public class VRCTriggerRelay : MonoBehaviour
    {
        public object Initialize;
        public object triggersInside;
        public object currentIdx;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA746610
        public void OnTriggerEnter(){} // RVA: 0xA746670
        public void OnTriggerExit(){} // RVA: 0xA746700
        public void .ctor(){} // RVA: 0xA746780
    }

    public class VRCUrl : Object
    {
        public object _empty;
        public object _domainExplicitAllowlistDelegate;
        public object _domainWildcardAllowlistDelegate;
        public object url;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0xA746940
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0xA7469A0
        public void IsNullOrEmpty(){} // RVA: 0xA746C00
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0xA746CA0
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0xA746D00
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0xA746DC0
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0xA746E20
        public void IsAllowlistedUri(){} // RVA: 0xA746EE0
        public void .ctor(){} // RVA: 0x7AA8900
        public void Get(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0xA747260
        public void GetHashCode(){} // RVA: 0x6F0FA20
        public void .cctor(){} // RVA: 0xA7472B0
    }

    public class VRCUrl[] : Array
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

    public class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        public object playable;
        public object layer;
        public object goalWeight;
        public object blendDuration;
        public object debugString;
        public object Initialize;
        public object ApplySettings;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA720A40
        public void OnStateEnter(){} // RVA: 0x624FD50
        public void .ctor(){} // RVA: 0xA6CB4A0
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        public object disableLocomotion;
        public object debugString;
        public object Initialize;
        public object ApplySettings;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA720AA0
        public void OnStateEnter(){} // RVA: 0x7158F20
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRC_AnimatorPlayAudio : StateMachineBehaviour
    {
        public object Source;
        public object SourcePath;
        public object PlaybackOrder;
        public object ParameterName;
        public object Volume;
        public object VolumeApplySettings;
        public object Pitch;
        public object PitchApplySettings;
        public object Clips;
        public object ClipsApplySettings;
        public object Loop;
        public object LoopApplySettings;
        public object DelayInSeconds;
        public object PlayOnEnter;
        public object StopOnEnter;
        public object PlayOnExit;
        public object StopOnExit;
        public object playbackIndex;
        public object destParam;
        public object Initialize;
        public object EnterState;
        public object ExitState;

        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0xA720B00
        public void get_ShouldApplyPitch(){} // RVA: 0xA720B40
        public void get_ShouldApplyClip(){} // RVA: 0xA720B80
        public void get_ShouldApplyLoop(){} // RVA: 0xA720BC0
        public void ShouldApplySetting(){} // RVA: 0xA720C00
        public void Awake(){} // RVA: 0xA720C40
        public void OnStateEnter(){} // RVA: 0xA720CA0
        public void OnStateExit(){} // RVA: 0xA720CC0
        public void .ctor(){} // RVA: 0xA6CB4B0
    }

    public class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        public object enterPoseSpace;
        public object fixedDelay;
        public object delayTime;
        public object debugString;
        public object Initialize;
        public object ApplySettings;
        public object applied;
        public object enterTime;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA720CF0
        public void OnStateEnter(){} // RVA: 0xA720D50
        public void OnStateUpdate(){} // RVA: 0xA720DE0
        public void .ctor(){} // RVA: 0xA6CB500
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        public object trackingHead;
        public object trackingLeftHand;
        public object trackingRightHand;
        public object trackingHip;
        public object trackingLeftFoot;
        public object trackingRightFoot;
        public object trackingLeftFingers;
        public object trackingRightFingers;
        public object trackingEyes;
        public object trackingMouth;
        public object debugString;
        public object Initialize;
        public object ApplySettings;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA720E80
        public void OnStateEnter(){} // RVA: 0x76ACF00
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        public object Name;
        public object ViewPosition;
        public object Animations;
        public object ScaleIPD;
        public object lipSync;
        public object lipSyncJawBone;
        public object lipSyncJawClosed;
        public object lipSyncJawOpen;
        public object VisemeSkinnedMesh;
        public object MouthOpenBlendShapeName;
        public object VisemeBlendShapes;
        public object apiAvatar;
        public object unityVersion;
        public object portraitCameraPositionOffset;
        public object portraitCameraRotationOffset;
        public object networkIDs;

        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0xA720EE0
        public void PositionPortraitCamera(){} // RVA: 0xA721210
        public void get_NetworkIDCollection(){} // RVA: 0xBAE340
        public void set_NetworkIDCollection(){} // RVA: 0xBAE350
        public void GetNetworkIDObjects(){} // RVA: 0xA721720
        public void FindNetworkIDGameObject(){} // RVA: 0xA721790
        public void GetNetworkIDGameObjectPath(){} // RVA: 0xA721970
        public void .ctor(){} // RVA: 0xA7219B0
    }

    public class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        public object parameters;
        public object localOnly;
        public object debugString;
        public object isLocalPlayer;
        public object isEnabled;
        public object initialized;
        public object OnApplySettings;

        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0xA721C90
        public void .ctor(){} // RVA: 0xA6D0560
    }

    public class VRC_AvatarParameterDriver[] : Array
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

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        public object blueprintId;
        public object grantBlueprintAccess;
        public object Placement;
        public object ChangeAvatarsOnUse;
        public object scale;
        public object OnReceiveAvatarImage;
        public object avatarImage;
        public object Instance;
        public object Instantiate;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA726E00
        public void SwitchAvatar(){} // RVA: 0xA6E79D0
        public void SetAvatarUse(){} // RVA: 0xA727310
        public void .ctor(){} // RVA: 0xA727450
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        public object data;
        public object Initialize;
        public object Serialize;
        public object Deserialize;
        public object ElementChanged;
        public object _GetElementIndex;

        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0xA7476F0
        public void GetElement(){} // RVA: 0xA747760
        public void add_ElementChanged(){} // RVA: 0xA7477F0
        public void remove_ElementChanged(){} // RVA: 0xA7478E0
        public void OnDataElementChanged(){} // RVA: 0xA7479D0
        public void Awake(){} // RVA: 0xA747A00
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_DestructibleStandard : MonoBehaviour
    {
        public object maxHealth;
        public object currentHealth;
        public object healable;
        public object damageEvent;
        public object destroyEvent;
        public object healEvent;
        public object fullHealthEvent;
        public object onDamagedTrigger;
        public object onDamagedEvent;
        public object onDestructedTrigger;
        public object onDestructedEvent;
        public object onHealedTrigger;
        public object onHealedEvent;
        public object onFullHealedTrigger;
        public object onFullHealedEvent;
        public object spawnerOnDamagedTrigger;
        public object spawnerOnDamagedEvent;
        public object spawnerOnDestructedTrigger;
        public object spawnerOnDestructedEvent;
        public object spawnerOnHealedTrigger;
        public object spawnerOnHealedEvent;
        public object spawnerOnFullHealedTrigger;
        public object spawnerOnFullHealedEvent;
        public object eventHandler;

        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0xB6B200
        public void GetCurrentHealth(){} // RVA: 0xCBAD90
        public void Awake(){} // RVA: 0xA723650
        public void ApplyDamage(){} // RVA: 0xA723830
        public void ApplyHealing(){} // RVA: 0xA723DC0
        public void GetState(){} // RVA: 0xA7243A0
        public void SetState(){} // RVA: 0xA724450
        public void HandleCallbackTrigger(){} // RVA: 0xA7244B0
        public void .ctor(){} // RVA: 0xA6924A0
        public void <ApplyDamage>b__27_0(){} // RVA: 0xA722660
        public void <ApplyDamage>b__27_1(){} // RVA: 0xA7245B0
        public void <ApplyHealing>b__28_0(){} // RVA: 0xA7245B0
        public void <ApplyHealing>b__28_1(){} // RVA: 0xA724610
    }

    public class VRC_EventDispatcher : MonoBehaviour
    {
        // ── Methods ──
        public void TriggerEvent(){} // RVA: 0x89E0C0
        public void RegisterEventHandler(){} // RVA: 0x894320
        public void UnregisterEventHandler(){} // RVA: 0x894320
        public void FindGameObject(){} // RVA: 0x87D1A0
        public void GetGameObjectPath(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcher
    {
        // ── Methods ──
        public void Start(){} // RVA: 0xA725260
        public void TriggerEvent(){} // RVA: 0xB43310
        public void RegisterEventHandler(){} // RVA: 0xB43310
        public void UnregisterEventHandler(){} // RVA: 0xB43310
        public void FindGameObject(){} // RVA: 0xA7252F0
        public void GetGameObjectPath(){} // RVA: 0xA725300
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_EventHandler : VRCNetworkBehaviour
    {
        public object Events;
        public object _dispatcher;
        public object GetInstigatorId;
        public object LogEvent;
        public object deferredEvents;
        public object DeferredEventProcessor;

        // ── Methods ──
        public void BooleanOp(){} // RVA: 0xA747A60
        public void get_Dispatcher(){} // RVA: 0xA747A80
        public void get_GetInsitgatorId(){} // RVA: 0xA747BA0
        public void set_GetInsitgatorId(){} // RVA: 0xA747BE0
        public void Awake(){} // RVA: 0xA747C80
        public void VrcAnimationEvent(){} // RVA: 0xA747FD0
        public void IsReceiverRequiredForEventType(){} // RVA: 0xA7481C0
        public void TriggerEvent(){} // RVA: 0xA749220
        public void InternalTriggerEvent(){} // RVA: 0xA748C80
        public void OnValidate(){} // RVA: 0xA749420
        public void OnDestroy(){} // RVA: 0xA749590
        public void GetCombinedNetworkId(){} // RVA: 0xDAC980
        public void HasEventTrigger(){} // RVA: 0xA749700
        public void IsReadyForEvents(){} // RVA: 0xC2E4C0
        public void DeferEvent(){} // RVA: 0xA749800
        public void ProcessDeferredEvents(){} // RVA: 0xA749AF0
        public void .ctor(){} // RVA: 0xA749B90
    }

    public class VRC_EventHandler[] : Array
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

    public class VRC_GunStats : MonoBehaviour
    {
        public object rateOfFire;
        public object damage;
        public object fullAuto;
        public object muzzleEffect;
        public object muzzleAudio;
        public object fireAudio;
        public object reloadAudio;
        public object hitEffects;
        public object leftHandContact;
        public object leftHandPositionOnly;
        public object clipSize;
        public object EmptyClipFire;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA692A70
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA74A5C0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        public object interactTextPlacement;
        public object interactText;
        public object interactTextGO;
        public object proximity;
        public object Initialize;
        public object CheckValid;

        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0xB43320
        public void get_Proximity(){} // RVA: 0x11E18C0
        public void Start(){} // RVA: 0xB43310
        public void Awake(){} // RVA: 0xA74A930
        public void Interact(){} // RVA: 0x894290
        public void OnPickupUseUp(){} // RVA: 0xB43310
        public void OnPickupUseDown(){} // RVA: 0xB43310
        public void OnPickup(){} // RVA: 0xB43310
        public void OnDrop(){} // RVA: 0xB43310
        public void IsInteractiveForPlayer(){} // RVA: 0xA74A990
        public void .ctor(){} // RVA: 0xA74AA30
    }

    public class VRC_Interactable[] : Array
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

    public class VRC_KeyEvents : MonoBehaviour
    {
        public object Key;
        public object DownEventName;
        public object UpEventName;
        public object LocalOnly;
        public object BroadcastType;
        public object Handler;
        public object Initialize;

        // ── Methods ──
        public void Start(){} // RVA: 0xA721D10
        public void Update(){} // RVA: 0xA721FB0
        public void .ctor(){} // RVA: 0xB43D60
        public void <Update>b__9_0(){} // RVA: 0xA722600
        public void <Update>b__9_2(){} // RVA: 0xA722600
        public void <Update>b__9_1(){} // RVA: 0xA722660
        public void <Update>b__9_3(){} // RVA: 0xA722660
    }

    public class VRC_Label : MonoBehaviour
    {
        public object label;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69FB20
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        public object callbacks;
        public object metadataUpdate;
        public object _GetCurrentMetadata;

        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0xA72E930
        public void Awake(){} // RVA: 0xA72E990
        public void OnDestroy(){} // RVA: 0xA72EB00
        public void TriggerUpdate(){} // RVA: 0xA72EC70
        public void MetadataChangedInternal(){} // RVA: 0xA72ECD0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_MidiNoteIn : MonoBehaviour
    {
        public object channel;
        public object note;
        public object OnNoteOn;
        public object OnNoteOff;
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA726A00
        public void Start(){} // RVA: 0xB43310
        public void Update(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_MidiNoteIn[] : Array
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

    public class VRC_MirrorReflection : MonoBehaviour
    {
        public object VRC_MIRROR_CAMERA_POS_PROPERTY;
        public object VRC_MIRROR_MODE_PROPERTY;
        public object m_DisablePixelLights;
        public object TurnOffMirrorOcclusion;
        public object m_ReflectLayers;
        public object mirrorResolution;
        public object maximumAntialiasing;
        public object customShader;
        public object MirrorQualityOverride;
        public object PreRenderMirror;
        public object PreRenderMirrorLate;
        public object PostRenderMirror;
        public object _currentlyRenderingMirror;
        public object _currentMirrorCenterEyePos;
        public object allowCustomMirrorShaders;
        public object _temporaryRenderTexture;
        public object _mReflections;
        public object _mirrorRenderer;
        public object _mirrorRendererMaterialInstance;
        public object _mirrorCamera;
        public object _mirrorSkybox;
        public object _parentTransform;
        public object _parentRotation;
        public object _playerLocalLayer;
        public object _texturePropertyId;
        public object MAX_AUTO_VR_RESOLUTION;
        public object MAX_AUTO_DESKTOP_RESOLUTION;
        public object MAX_AUTO_RESOLUTION_UNLIMITER;
        public object _frustumPlanes;

        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0xA72ECF0
        public void remove_PreRenderMirror(){} // RVA: 0xA72EE40
        public void add_PreRenderMirrorLate(){} // RVA: 0xA72EF90
        public void remove_PreRenderMirrorLate(){} // RVA: 0xA72F0E0
        public void add_PostRenderMirror(){} // RVA: 0xA72F230
        public void remove_PostRenderMirror(){} // RVA: 0xA72F380
        public void get_CurrentlyRenderingMirror(){} // RVA: 0xA72F4D0
        public void set_CurrentlyRenderingMirror(){} // RVA: 0xA72F530
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0xA72F5F0
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0xA72F660
        public void OnValidate(){} // RVA: 0xA72F6D0
        public void Start(){} // RVA: 0xA72F730
        public void TrySetupMaterial(){} // RVA: 0xA72F900
        public void IsVisibleToCamera(){} // RVA: 0xA72FDE0
        public void IsLayerRendered(){} // RVA: 0xA730060
        public void CameraOnPreCull(){} // RVA: 0xA730120
        public void RenderMirrorCameras(){} // RVA: 0xA730600
        public void CameraPostRender(){} // RVA: 0xA731930
        public void OnEnable(){} // RVA: 0xA731BC0
        public void OnDisable(){} // RVA: 0xA731E70
        public void OnDestroy(){} // RVA: 0xA732590
        public void ShouldRenderLeftEye(){} // RVA: 0xA7328F0
        public void ShouldRenderRightEye(){} // RVA: 0xA732B50
        public void ShouldRenderMonoscopic(){} // RVA: 0xA732DC0
        public void GetWorldEyePos(){} // RVA: 0xA732FE0
        public void GetWorldEyeRot(){} // RVA: 0xA733110
        public void GetEyeProjectionMatrix(){} // RVA: 0xA733300
        public void GetNormalDirection(){} // RVA: 0xA733410
        public void RenderMirror(){} // RVA: 0xA733480
        public void UpdateCameraClearing(){} // RVA: 0xA7342F0
        public void UpdateCameraModes(){} // RVA: 0xA734730
        public void UpdateParentTransform(){} // RVA: 0xA734FD0
        public void GetReflectionData(){} // RVA: 0xA735850
        public void GetAutoResolution(){} // RVA: 0xA736560
        public void Plane(){} // RVA: 0xA736800
        public void CameraSpacePlane(){} // RVA: 0xA736860
        public void CalculateReflectionMatrix(){} // RVA: 0xA736CA0
        public void CopySign(){} // RVA: 0xA736E10
        public void GetRotation(){} // RVA: 0xA736E40
        public void GetPosition(){} // RVA: 0x6F09DF0
        public void .ctor(){} // RVA: 0xA737080
        public void .cctor(){} // RVA: 0xA737190
    }

    public class VRC_NPCSpawn : MonoBehaviour
    {
        public object npcName;
        public object blueprintId;
        public object customAnimation;
        public object scale;
        public object Initialize;
        public object npcGameObject;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA727510
        public void .ctor(){} // RVA: 0xA693360
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        public object Initialize;
        public object _GetApiByGameObject;
        public object _SetNamePlate;
        public object _SetSocialStatus;
        public object _SetMuteStatus;
        public object _ActThis;
        public object _SayThis;

        // ── Methods ──
        public void Start(){} // RVA: 0xA7226C0
        public void GetApiByGameObject(){} // RVA: 0xA722720
        public void ActThis(){} // RVA: 0xA722830
        public void SayThis(){} // RVA: 0xA7228C0
        public void SetNamePlate(){} // RVA: 0xA722950
        public void SetSocialStatus(){} // RVA: 0xA7229F0
        public void SetMuteStatus(){} // RVA: 0xA722A90
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_ObjectApi : MonoBehaviour
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_ObjectSpawn : MonoBehaviour
    {
        public object ObjectPrefab;
        public object Initialize;
        public object Instantiate;
        public object ReapObjects;

        // ── Methods ──
        public void SpawnObject(){} // RVA: 0xA7277A0
        public void DestroySpawnedObjects(){} // RVA: 0x26AD980
        public void Start(){} // RVA: 0xA727890
        public void ProvideEvents(){} // RVA: 0xA7278F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        public object address;
        public object OnButtonOn;
        public object OnButtonOff;
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA726A60
        public void Start(){} // RVA: 0xB43310
        public void Update(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_OscButtonIn[] : Array
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

    public class VRC_Panorama : MonoBehaviour
    {
        public object renderer;
        public object panoramas;
        public object currentlyShown;
        public object data;
        public object dataIndex;

        // ── Methods ──
        public void Start(){} // RVA: 0xA7373A0
        public void Update(){} // RVA: 0xA737590
        public void NextPano(){} // RVA: 0xA737860
        public void PrevPano(){} // RVA: 0xA737920
        public void ShowPanoAt(){} // RVA: 0xA7379E0
        public void ShowPano(){} // RVA: 0xA737A70
        public void .ctor(){} // RVA: 0xA69FBF0
    }

    public class VRC_PhysicsRoot : MonoBehaviour
    {
        public object PhysicsRoot;
        public object PhysicsObjects;

        // ── Methods ──
        public void Start(){} // RVA: 0xA722B20
        public void OnDestroy(){} // RVA: 0xA723440
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        public object MomentumTransferMethod;
        public object DisallowTheft;
        public object ExactGun;
        public object ExactGrip;
        public object allowManipulationWhenEquipped;
        public object orientation;
        public object AutoHold;
        public object InteractionText;
        public object UseText;
        public object useEventBroadcastType;
        public object UseDownEventName;
        public object UseUpEventName;
        public object pickupDropEventBroadcastType;
        public object PickupEventName;
        public object DropEventName;
        public object ThrowVelocityBoostMinSpeed;
        public object ThrowVelocityBoostScale;
        public object currentlyHeldBy;
        public object currentLocalPlayer;
        public object pickupable;
        public object proximity;
        public object OnAwake;
        public object ForceDrop;
        public object OnDestroyed;
        public object HapticEvent;
        public object _GetPickupHand;
        public object _GetCurrentPlayer;

        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0xA727EA0
        public void get_currentPlayer(){} // RVA: 0xA727ED0
        public void get_IsHeld(){} // RVA: 0xA727F40
        public void get_currentHand(){} // RVA: 0xA728000
        public void get_Proximity(){} // RVA: 0xA728060
        public void Awake(){} // RVA: 0xA728070
        public void OnDisable(){} // RVA: 0xA7280D0
        public void Reset(){} // RVA: 0xA728110
        public void Drop(){} // RVA: 0xA7281F0
        public void GenerateHapticEvent(){} // RVA: 0xA728450
        public void OnDestroy(){} // RVA: 0xA7284F0
        public void PlayHaptics(){} // RVA: 0xA728550
        public void ProvideEvents(){} // RVA: 0xA728580
        public void .ctor(){} // RVA: 0xA728970
    }

    public class VRC_Pickup[] : Array
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

    public class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        public object layer;
        public object goalWeight;
        public object blendDuration;
        public object debugString;
        public object Initialize;
        public object ApplySettings;
        public object outputParamHash;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA723530
        public void OnStateEnter(){} // RVA: 0xA723590
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        public object world;
        public object roomId;
        public object customPortalName;
        public object sortHeading;
        public object sortOrder;
        public object offset;
        public object searchTerm;
        public object tag;
        public object useDefaultPresentation;
        public object effectPrefabName;
        public object Initialize;
        public object roomName;
        public object updateFlag;
        public object initializedWithRoomId;

        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0xCFDA90
        public void Awake(){} // RVA: 0xA728CE0
        public void Update(){} // RVA: 0xA728D60
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_PropApi : MonoBehaviour
    {
        public object mountPoint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_PropController : MonoBehaviour
    {
        public object controllingPlayer;
        public object inputLeftAnalog;
        public object inputRightAnalog;
        public object inputUseButton;
        public object UpdateInputs;
        public object Initialize;
        public object Inputs;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA728DE0
        public void Update(){} // RVA: 0xA728E40
        public void GetInputIndex(){} // RVA: 0xA728EB0
        public void .ctor(){} // RVA: 0xA6948E0
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        public object apiProp;
        public object unityVersion;
        public object DynamicPrefabs;
        public object sDynamicPrefabs;
        public object DynamicMaterials;
        public object sDynamicMaterials;
        public object Initialize;
        public object NetworkIDs;
        public object _networkIDLookup;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA728FD0
        public void get_NetworkIDCollection(){} // RVA: 0xBC1B30
        public void set_NetworkIDCollection(){} // RVA: 0xB6A8C0
        public void get_NetworkIDLookup(){} // RVA: 0xBBF8F0
        public void set_NetworkIDLookup(){} // RVA: 0xBBF900
        public void GetNetworkIDObjects(){} // RVA: 0xA729A20
        public void FindNetworkIDGameObject(){} // RVA: 0xA729A90
        public void GetNetworkIDGameObjectPath(){} // RVA: 0xA721970
        public void .ctor(){} // RVA: 0xA729C70
    }

    public class VRC_SceneDescriptor : MonoBehaviour
    {
        public object spawns;
        public object spawnRadius;
        public object spawnOrder;
        public object spawnOrientation;
        public object ReferenceCamera;
        public object RespawnHeightY;
        public object ObjectBehaviourAtRespawnHeight;
        public object ForbidUserPortals;
        public object interactThruLayers;
        public object autoSpatializeAudioSources;
        public object gravity;
        public object layerCollisionArr;
        public object capacity;
        public object contentSex;
        public object contentViolence;
        public object contentGore;
        public object contentOther;
        public object releasePublic;
        public object unityVersion;
        public object udonProducts;
        public object Name;
        public object NSFW;
        public object SpawnPosition;
        public object SpawnLocation;
        public object DrawDistance;
        public object useAssignedLayers;
        public object DynamicPrefabs;
        public object sDynamicPrefabs;
        public object DynamicMaterials;
        public object sDynamicMaterials;
        public object LightMapsNear;
        public object LightMapsFar;
        public object LightMode;
        public object RenderAmbientEquatorColor;
        public object RenderAmbientGroundColor;
        public object RenderAmbientIntensity;
        public object RenderAmbientLight;
        public object RenderAmbientMode;
        public object RenderAmbientProbe;
        public object RenderAmbientSkyColor;
        public object RenderFog;
        public object RenderFogColor;
        public object RenderFogMode;
        public object RenderFogDensity;
        public object RenderFogLinearStart;
        public object RenderFogLinearEnd;
        public object RenderHaloStrength;
        public object RenderFlareFadeSpeed;
        public object RenderFlareStrength;
        public object RenderCustomReflection;
        public object RenderDefaultReflectionMode;
        public object RenderDefaultReflectionResolution;
        public object RenderReflectionBounces;
        public object RenderReflectionIntensity;
        public object RenderSkybox;
        public object NetworkIDs;
        public object _networkIDLookup;
        public object rootSceneGameObjectsBuffer;
        public object Initialize;
        public object apiWorld;
        public object _instance;
        public object _bundleUnityMajorVersion;
        public object _scene;
        public object portraitCameraPositionOffset;
        public object portraitCameraRotationOffset;

        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0xA7382A0
        public void GetPrefab(){} // RVA: 0xA738490
        public void GetMaterial(){} // RVA: 0xA738890
        public void get_NetworkIDCollection(){} // RVA: 0x165AD10
        public void set_NetworkIDCollection(){} // RVA: 0x1667130
        public void get_NetworkIDLookup(){} // RVA: 0x1184410
        public void set_NetworkIDLookup(){} // RVA: 0x163ACA0
        public void GetNetworkIDObjects(){} // RVA: 0xA738C90
        public void FindNetworkIDGameObject(){} // RVA: 0xA738F10
        public void GetNetworkIDGameObjectPath(){} // RVA: 0xA721970
        public void get_Instance(){} // RVA: 0xA739410
        public void get_Exists(){} // RVA: 0xA7396F0
        public void get_BundleUnityMajorVersion(){} // RVA: 0xA7397F0
        public void set_BundleUnityMajorVersion(){} // RVA: 0xA739800
        public void get_Scene(){} // RVA: 0x2548D00
        public void set_Scene(){} // RVA: 0x2548D10
        public void Awake(){} // RVA: 0xA739810
        public void OnDestroy(){} // RVA: 0xA73A8D0
        public void PositionPortraitCamera(){} // RVA: 0xA73A990
        public void .ctor(){} // RVA: 0xA73ADE0
        public void .cctor(){} // RVA: 0xA73B110
    }

    public class VRC_SceneDescriptor[] : Array
    {
        // ── Methods ──
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
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    }

    public class VRC_Serialization : Object
    {
        public object _allowedTypes;
        public object _allowedPluginTypes;
        public object _allowPluginTypes;
        public object _networkSurrogateSelector;

        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0xA74AAF0
        public void set_AllowPluginTypes(){} // RVA: 0xA74AB50
        public void get_SurrogateSelector(){} // RVA: 0xA74ABB0
        public void RegisterPluginType(){} // RVA: 0xA74ACC0
        public void RegisterType(){} // RVA: 0xA74ADB0
        public void ParameterEncoder(){} // RVA: 0xA74AEA0
        public void ParameterDecoder(){} // RVA: 0xA74B0B0
        public void get_Dispatcher(){} // RVA: 0xA74B320
        public void GetGameObjectPathFallback(){} // RVA: 0xA74B430
        public void GetGameObjectPath(){} // RVA: 0xA74B6A0
        public void FindGameObject(){} // RVA: 0xA74B7E0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA74B910
    }

    public class VRC_SlideShow : MonoBehaviour
    {
        public object autoplay;
        public object shuffle;
        public object images;
        public object displayDuration;
        public object imageMaterial;
        public object showingImage;

        // ── Methods ──
        public void Start(){} // RVA: 0xA729E90
        public void ShowNextImage(){} // RVA: 0xA729F40
        public void ShowPreviousImage(){} // RVA: 0xA72A160
        public void StartAutoplayWithDuration(){} // RVA: 0xA72A330
        public void StopAutoplayWithDuration(){} // RVA: 0xA72A3F0
        public void .ctor(){} // RVA: 0xA6949E0
    }

    public class VRC_SpatialAudioSource : MonoBehaviour
    {
        public object Gain;
        public object Far;
        public object Near;
        public object VolumetricRadius;
        public object EnableSpatialization;
        public object UseAudioSourceVolumeCurve;
        public object Initialize;
        public object _source;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA71A530
        public void OnDrawGizmosSelected(){} // RVA: 0xA71A7A0
        public void .ctor(){} // RVA: 0xA691450
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        public object specialLayer;

        // ── Methods ──
        public void Apply(){} // RVA: 0xA73B3F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_SpecialLayer[] : Array
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

    public class VRC_StereoObject : MonoBehaviour
    {
        public object eye;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_StereoObject[] : Array
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

    public class VRC_TimedEvents : MonoBehaviour
    {
        public object Repeat;
        public object LowPeriodTime;
        public object HighPeriodTime;
        public object ResetOnEnable;
        public object EventName;
        public object BroadcastType;
        public object EventFired;
        public object Duration;
        public object Timer;
        public object Handler;

        // ── Methods ──
        public void Start(){} // RVA: 0xA73B5B0
        public void OnEnable(){} // RVA: 0xA73B780
        public void Update(){} // RVA: 0xA73B790
        public void ResetClock(){} // RVA: 0xA73B920
        public void .ctor(){} // RVA: 0xA69D350
    }

    public class VRC_Trigger : VRC_Interactable
    {
        public object InitializeTrigger;
        public object isHidden;
        public object UsesAdvancedOptions;
        public object TakesOwnershipIfNecessary;
        public object DrawLines;
        public object EditorGlobalTriggerLineMode;
        public object Triggers;
        public object ExecuteTrigger;

        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0xA73BC30
        public void Trigger(){} // RVA: 0xA73BAA0
        public void get_HasKeyTriggers(){} // RVA: 0xA73BDC0
        public void get_HasTimerTriggers(){} // RVA: 0xA73BF30
        public void get_HasColliderTriggers(){} // RVA: 0xA73C0A0
        public void get_HasInteractiveTriggers(){} // RVA: 0xA73C340
        public void get_HasPickupTriggers(){} // RVA: 0xA73C4B0
        public void get_IsInteractive(){} // RVA: 0xA73C620
        public void Awake(){} // RVA: 0xA73C910
        public void OnDestroy(){} // RVA: 0xA73C9C0
        public void OnEnable(){} // RVA: 0xA73C9D0
        public void OnDisable(){} // RVA: 0xA73CA00
        public void OnDrawGizmosSelected(){} // RVA: 0xA73CA30
        public void Interact(){} // RVA: 0xA73CFE0
        public void OnPickupUseUp(){} // RVA: 0xA73CFF0
        public void OnPickupUseDown(){} // RVA: 0xA73D000
        public void OnPickup(){} // RVA: 0xA73D010
        public void OnDrop(){} // RVA: 0xA73D020
        public void ExecuteTriggers(){} // RVA: 0xA73D030
        public void ExecuteTriggerType(){} // RVA: 0xA73D2F0
        public void ExecuteCustomTrigger(){} // RVA: 0xA73D620
        public void ResetClocks(){} // RVA: 0xA73D9F0
        public void ResetClock(){} // RVA: 0xA73DD80
        public void .ctor(){} // RVA: 0xA69D3B0
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0xA73DE10
    }

    public class VRC_TriggerColliderEventTrigger : MonoBehaviour
    {
        public object EnterEventName;
        public object ExitEventName;
        public object TriggerIndividuals;
        public object layers;
        public object Handler;
        public object CollisionEnter;
        public object CollisionExit;
        public object currentOccupants;

        // ── Methods ──
        public void Start(){} // RVA: 0xA73EDC0
        public void OnTriggerEnter(){} // RVA: 0xA73EF80
        public void OnTriggerExit(){} // RVA: 0xA73F0C0
        public void .ctor(){} // RVA: 0xA69D480
    }

    public class VRC_TutorialAction : MonoBehaviour
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0xA7445B0
        public void ActivateObjectLabel(){} // RVA: 0xA7447B0
        public void DeactivateObjectLabel(){} // RVA: 0xA744840
        public void ActivateControllerLabel(){} // RVA: 0xA7448A0
        public void DeactivateControllerLabel(){} // RVA: 0xA7448D0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRC_TutorialAreaMarker : MonoBehaviour
    {
        public object Text;
        public object EnableDistance;
        public object MaxVisibleDistance;
        public object DisableWhenPlayerInRange;
        public object _showingLabel;
        public object _enabled;
        public object _timeStarted;

        // ── Methods ──
        public void Enable(){} // RVA: 0x653CDE0
        public void Update(){} // RVA: 0xA7448E0
        public void ShowLabel(){} // RVA: 0xA744C50
        public void .ctor(){} // RVA: 0xA69D840
    }

    public class VRC_UiShape : MonoBehaviour
    {
        public object GetEventCamera;
        public object _rootCanvas;
        public object _rootCanvasRectTransform;
        public object AllowFocusView;
        public object _uiCanvas;
        public object _localRectTransform;
        public object OnUiShapeInit;
        public object OnUiShapeDestroy;

        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0xB700F0
        public void set_RootCanvas(){} // RVA: 0xB70100
        public void get_RootCanvasRectTransform(){} // RVA: 0xB70160
        public void set_RootCanvasRectTransform(){} // RVA: 0xB44DC0
        public void add_OnUiShapeInit(){} // RVA: 0xA745730
        public void remove_OnUiShapeInit(){} // RVA: 0xA745870
        public void add_OnUiShapeDestroy(){} // RVA: 0xA7459B0
        public void remove_OnUiShapeDestroy(){} // RVA: 0xA745AF0
        public void Awake(){} // RVA: 0xA745C30
        public void Start(){} // RVA: 0xA745DA0
        public void OnRectTransformDimensionsChange(){} // RVA: 0xA7460F0
        public void SetupCollision(){} // RVA: 0xA746100
        public void OnDestroy(){} // RVA: 0xA7465B0
        public void .ctor(){} // RVA: 0xBF9D60
    }

    public class VRC_UseEvents : VRC_Interactable
    {
        public object EventName;
        public object isHidden;
        public object BroadcastType;
        public object UpdateUse;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA73F200
        public void Start(){} // RVA: 0xA73F3F0
        public void Interact(){} // RVA: 0xA73F6C0
        public void .ctor(){} // RVA: 0xA69D4D0
        public void <Awake>b__5_0(){} // RVA: 0xA73F8A0
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        public object fullDamageScale;
        public object minDamageScale;
        public object offset;
        public object curve;
        public object currentTime;
        public object renderer;
        public object initScale;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA724670
        public void Start(){} // RVA: 0xA724700
        public void OnSceneWasLoaded(){} // RVA: 0xA724940
        public void Update(){} // RVA: 0xA7249E0
        public void HideDamageIndicator(){} // RVA: 0xA724C00
        public void ShowDamageIndicator(){} // RVA: 0xA724CF0
        public void SetDamagePercent(){} // RVA: 0xA724DE0
        public void .ctor(){} // RVA: 0xA725080
    }

    public class VRC_Water : MonoBehaviour
    {
        public object waterMode;
        public object disablePixelLights;
        public object textureSize;
        public object clipPlaneOffset;
        public object reflectLayers;
        public object refractLayers;
        public object TurnOffWaterOcclusion;
        public object m_ReflectionCameras;
        public object m_RefractionCameras;
        public object m_ReflectionTexture;
        public object m_RefractionTexture;
        public object m_HardwareWaterSupport;
        public object m_OldReflectionTextureSize;
        public object m_OldRefractionTextureSize;
        public object s_InsideWater;

        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0xA73F9B0
        public void OnDisable(){} // RVA: 0xA740740
        public void Update(){} // RVA: 0xA740EF0
        public void UpdateCameraModes(){} // RVA: 0xA741380
        public void CreateWaterObjects(){} // RVA: 0xA741730
        public void GetWaterMode(){} // RVA: 0xA742C20
        public void FindHardwareWaterSupport(){} // RVA: 0xA742C30
        public void CameraSpacePlane(){} // RVA: 0xB5ABC0
        public void CalculateReflectionMatrix(){} // RVA: 0xB5AFF0
        public void .ctor(){} // RVA: 0xA69D570
    }

    public class VRC_WebPanel : VRC_Interactable
    {
        public object webRoot;
        public object defaultUrl;
        public object resolutionWidth;
        public object resolutionHeight;
        public object displayRegion;
        public object interactive;
        public object extraVideoScreens;
        public object Initialize;
        public object localOnly;
        public object syncURI;
        public object syncInput;
        public object syncDisplayAndAudio;
        public object cursor;
        public object transparent;
        public object station;
        public object cookiesEnabled;
        public object autoFormSubmit;
        public object webData;
        public object _NavigateTo;
        public object _WebPanelForward;
        public object _WebPanelBackward;
        public object _WebPanelReload;
        public object _ExecuteScript;
        public object _BindCall;

        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0xA742EE0
        public void WebPanelBackward(){} // RVA: 0xA742F10
        public void WebPanelReload(){} // RVA: 0xA742F40
        public void BindCall(){} // RVA: 0xA742F70
        public void NavigateTo(){} // RVA: 0xA742FA0
        public void Awake(){} // RVA: 0xA742FD0
        public void Interact(){} // RVA: 0xB43310
        public void get_WebRootPath(){} // RVA: 0xA7430E0
        public void ProvideEvents(){} // RVA: 0xA743220
        public void ReadData(){} // RVA: 0xA743A10
        public void ImportWebData(){} // RVA: 0xA743C80
        public void .ctor(){} // RVA: 0xA69D710
    }

    public class VersionHelper : Object
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0xA94080
    }

}