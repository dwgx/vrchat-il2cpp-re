// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 78
// Methods: 662

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        // ── Methods ──
        public void get_boolVal(){} // RVA: 0x7FFE80E2F150
        public void set_boolVal(){} // RVA: 0x7FFE80E466C0
        public void get_intVal(){} // RVA: 0x7FFE80E2EDB0
        public void set_intVal(){} // RVA: 0x7FFE80E46530
        public void get_floatVal(){} // RVA: 0x7FFE80E42E10
        public void set_floatVal(){} // RVA: 0x7FFE80E53B80
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
        public void get_NetworkIDCollection(){} // RVA: 0x7FFE80E2E2E0
        public void set_NetworkIDCollection(){} // RVA: 0x7FFE80E460A0
        public void GetNetworkIDObjects(){} // RVA: 0x7FFE80E460A0
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFE80E3EBB0
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFE80E3FC10
    }

    public class IPreprocessCallbackBehaviour
    {
        // ── Methods ──
        public void OnPreprocess(){} // RVA: 0x7FFE80E2F150
        public void get_PreprocessOrder(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0x7FFE80E2E2E0
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
        public void GetState(){} // RVA: 0x7FFE80E2E2E0
        public void SetState(){} // RVA: 0x7FFE80E460A0
        public void GetMaxHealth(){} // RVA: 0x7FFE80E42E10
        public void GetCurrentHealth(){} // RVA: 0x7FFE80E42E10
        public void ApplyDamage(){} // RVA: 0x7FFE80E53B80
        public void ApplyHealing(){} // RVA: 0x7FFE80E53B80
    }

    public class IValidChecker
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE80E2F150
    }

    public class InputManager : Object
    {
        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0x7FFE8A4DDAD0
        public void GetLastUsedInputMethod(){} // RVA: 0x7FFE8A4DDB30
        public void GetBoolInputSetting(){} // RVA: 0x7FFE8A4DDBA0
        public void SetBoolInputSetting(){} // RVA: 0x7FFE8A4DDC00
        public void EnableObjectHighlight(){} // RVA: 0x7FFE8A4DDD70 | overloaded x2
    }

    public class MathUtil : Object
    {
        // ── Methods ──
        public void AngleBetweenTwoUnitVectors(){} // RVA: 0x7FFE8A4B9E50
        public void AngleClosestBetweenTwoUnitVectors(){} // RVA: 0x7FFE89E83940
        public void ClosestPointOnLineSegment_Value(){} // RVA: 0x7FFE8A4BA030
        public void ClosestPointOnLineSegment(){} // RVA: 0x7FFE89E83AE0
        public void ClosestPointOnPlane(){} // RVA: 0x7FFE89E83C00
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A4BA100
    }

    public class Networking : Object
    {
        public System.Func`2<UnityEngine.GameObject,float> _GetSimulationTime;
        public System.Func`2<UnityEngine.GameObject,string> _GetUniqueName; // 0x8
        public System.Action`4<0x66648724,UnityEngine.GameObject,string,object[]> _RPC; // 0x10
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject,string,object[]> _RPCtoPlayer; // 0x18
        public System.Func`1<bool> _IsNetworkSettled; // 0x20
        public System.Func`1<bool> _IsMaster; // 0x28
        public System.Func`1<bool> _IsSuffering; // 0x30
        public System.Func`1<bool> _IsInstanceOwner; // 0x38

        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x7FFE8A4B8D00
        public void get_IsNetworkSettled(){} // RVA: 0x7FFE8A4B8D60
        public void get_IsMaster(){} // RVA: 0x7FFE8A4B8DC0
        public void get_IsClogged(){} // RVA: 0x7FFE8A4B8E20
        public void get_IsInstanceOwner(){} // RVA: 0x7FFE8A4B8E80
        public void get_LocalPlayer(){} // RVA: 0x7FFE8A4B8EE0
        public void get_Master(){} // RVA: 0x7FFE8A4B8F40
        public void get_InstanceOwner(){} // RVA: 0x7FFE8A4B8FA0
        public void IsOwner(){} // RVA: 0x7FFE8A4B9080 | overloaded x2
        public void GetOwner(){} // RVA: 0x7FFE8A4B9140
        public void SetOwner(){} // RVA: 0x7FFE8A4B91B0
        public void IsObjectReady(){} // RVA: 0x7FFE8A4B9220
        public void Instantiate(){} // RVA: 0x7FFE8A4B9290
        public void RPC(){} // RVA: 0x7FFE8A4B93E0 | overloaded x2
        public void EncodeParameters(){} // RVA: 0x7FFE8A4B9480
        public void DecodeParameters(){} // RVA: 0x7FFE8A4B94F0
        public void Destroy(){} // RVA: 0x7FFE8A4B9560
        public void GetUniqueName(){} // RVA: 0x7FFE8A4B95D0
        public void GoToRoom(){} // RVA: 0x7FFE8A4B9640
        public void GetNetworkDateTime(){} // RVA: 0x7FFE8A4B96B0
        public void GetServerTimeInSeconds(){} // RVA: 0x7FFE8A4B9750
        public void GetServerTimeInMilliseconds(){} // RVA: 0x7FFE8A4B9800
        public void CalculateServerDeltaTime(){} // RVA: 0x7FFE8A4B98B0
        public void SafeStartCoroutine(){} // RVA: 0x7FFE8A4B9940
        public void GetEventDispatcher(){} // RVA: 0x7FFE8A4B99B0
        public void SimulationTime(){} // RVA: 0x7FFE8A4B9AC0 | overloaded x2
        public void RequestStorageUsageUpdate(){} // RVA: 0x7FFE88516A20
        public void GetPlayerObjects(){} // RVA: 0x7FFE8A4B12C0
        public void GetPlayerDataStorageLimit(){} // RVA: 0x7FFE8A4B9B70
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x7FFE8A4B9BD0
        public void GetPlayerDataStorageUsage(){} // RVA: 0x7FFE8A4B9C30
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x7FFE8A4B9CA0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFE8A4B9D10
    }

    public class RPC : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4B8920 | overloaded x4
        public void SetupTargets(){} // RVA: 0x7FFE8A4B8940
    }

    public class RPCIgnoredType : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Tutorial : Object
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFE8A4D8000
        public void ActivateObjectLabel(){} // RVA: 0x7FFE8A4D8210 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFE8A4D8300
        public void ActivateControllerLabel(){} // RVA: 0x7FFE8A4D8360
        public void DeactivateControllerLabel(){} // RVA: 0x7FFE8A4D8400
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Utilities : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE8A4E5C20
        public void ShuffleArray(){} // RVA: 0x7FFE8A4E5D80 | overloaded x2
        public void IsClient(){} // RVA: 0x7FFE8A4E5E80
        public void SetIsClient(){} // RVA: 0x7FFE8A4E5EC0
        public void Fletcher32Fast(){} // RVA: 0x7FFE8A4E5F00
    }

    public class VRCBuiltInShaderGlobals : MonoBehaviour
    {
        public int _vrcTimeUTCUnixSecondsID;
        public int _vrcTimeNetworkMsID; // 0x4

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE8A4BDC90
        public void set_Instance(){} // RVA: 0x7FFE8A4BDCF0
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFE811290C0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFE811290D0
        public void Update(){} // RVA: 0x7FFE8A4BDDB0
        public void OnDestroy(){} // RVA: 0x7FFE8A4BE450
        public void Initialize(){} // RVA: 0x7FFE8A4BE740
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void .cctor(){} // RVA: 0x7FFE8A4BEB80
    }

    public class VRCCustomAction : MonoBehaviour
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE8A4C1CC0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCDroneApi : Object
    {
        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x7FFE8A4B84E0
        public void GetPlayer(){} // RVA: 0x7FFE80E2E2E0
        public void IsDeployed(){} // RVA: 0x7FFE80E2F150
        public void TryGetPosition(){} // RVA: 0x7FFE80E2F3B0
        public void GetPosition(){} // RVA: 0x7FFE80E2DCF0
        public void TryGetRotation(){} // RVA: 0x7FFE80E2F3B0
        public void GetRotation(){} // RVA: 0x7FFE80E2DCF0
        public void TryGetVelocity(){} // RVA: 0x7FFE80E2F3B0
        public void GetVelocity(){} // RVA: 0x7FFE80E2DCF0
        public void TeleportTo(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void SetVelocity(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VRCGraphics : Object
    {
        public System.Lazy`1<UnityEngine.LayerMask> _uiLayerMaskLazy;

        // ── Methods ──
        public void get_UiLayerMask(){} // RVA: 0x7FFE8A4BEFC0
        public void Blit(){} // RVA: 0x7FFE8A4BF590 | overloaded x7
        public void DrawMeshInstanced(){} // RVA: 0x7FFE8A4BFF20 | overloaded x9
        public void GetLayerMask(){} // RVA: 0x7FFE8A4C0080
        public void CheckBlitTarget(){} // RVA: 0x7FFE8A4C0090
        public void .cctor(){} // RVA: 0x7FFE8A4C01A0
    }

    public class VRCPlayerApi : Object
    {
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _isMasterDelegate;
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _isInstanceOwnerDelegate; // 0x8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _isModeratorDelegate; // 0x10
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _isSuperDelegate; // 0x18
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _isSuspendedDelegate; // 0x20
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _isVRCPlusDelegate; // 0x28
        public bool isLocal; // 0x10
        public string displayName; // 0x18

        // ── Methods ──
        public void get_isMaster(){} // RVA: 0x7FFE8A4AE390
        public void get_isInstanceOwner(){} // RVA: 0x7FFE8A4AE410
        public void get_isModerator(){} // RVA: 0x7FFE8A4AE490
        public void get_isSuper(){} // RVA: 0x7FFE8A4AE510
        public void get_isSuspended(){} // RVA: 0x7FFE8A4AE590
        public void get_isVRCPlus(){} // RVA: 0x7FFE8A4AE610
        public void IsPlayerGrounded(){} // RVA: 0x7FFE8A4AE690
        public void GetDrone(){} // RVA: 0x7FFE8A4AE730
        public void get_AllPlayers(){} // RVA: 0x7FFE8A4AE7B0
        public void GetPlayers(){} // RVA: 0x7FFE8A4AE8C0 | overloaded x2
        public void GetPlayerCount(){} // RVA: 0x7FFE8A4AE960
        public void GetPlayerId(){} // RVA: 0x7FFE8A4AE9E0
        public void get_playerId(){} // RVA: 0x7FFE8A4AEA60
        public void GetPlayerByGameObject(){} // RVA: 0x7FFE8A4AEAC0
        public void GetPlayerById(){} // RVA: 0x7FFE8A4AEB40
        public void IsValid(){} // RVA: 0x7FFE81121450
        public void IsOwner(){} // RVA: 0x7FFE8A4AEBC0
        public void TakeOwnership(){} // RVA: 0x7FFE8A4AEC50
        public void GetTrackingData(){} // RVA: 0x7FFE8A4AECE0
        public void GetBoneTransform(){} // RVA: 0x7FFE8A4AEDA0
        public void GetBonePosition(){} // RVA: 0x7FFE8A4AEE30
        public void GetBoneRotation(){} // RVA: 0x7FFE8A4AEEF0
        public void GetPickupInHand(){} // RVA: 0x7FFE8A4AEFA0
        public void SetPickupInHand(){} // RVA: 0x7FFE810FB310
        public void PlayHapticEventInHand(){} // RVA: 0x7FFE8A4AF030
        public void TeleportTo(){} // RVA: 0x7FFE8A4AF2F0 | overloaded x3
        public void Respawn(){} // RVA: 0x7FFE8A4AF470 | overloaded x2
        public void EnablePickups(){} // RVA: 0x7FFE8A4AF500
        public void SetNamePlateColor(){} // RVA: 0x7FFE8A4AF590
        public void RestoreNamePlateColor(){} // RVA: 0x7FFE8A4AF630
        public void SetNamePlateVisibility(){} // RVA: 0x7FFE8A4AF6B0
        public void RestoreNamePlateVisibility(){} // RVA: 0x7FFE8A4AF740
        public void SetPlayerTag(){} // RVA: 0x7FFE8A4AF7C0
        public void GetPlayerTag(){} // RVA: 0x7FFE8A4AF860
        public void GetPlayersWithTag(){} // RVA: 0x7FFE813240E0
        public void ClearPlayerTags(){} // RVA: 0x7FFE8A4AF8F0
        public void SetInvisibleToTagged(){} // RVA: 0x7FFE8A4AF970
        public void SetInvisibleToUntagged(){} // RVA: 0x7FFE8A4AFA30
        public void SetSilencedToTagged(){} // RVA: 0x7FFE8A4AFAF0
        public void SetSilencedToUntagged(){} // RVA: 0x7FFE8A4AFBA0
        public void SetRunSpeed(){} // RVA: 0x7FFE8A4AFC50
        public void SetWalkSpeed(){} // RVA: 0x7FFE8A4AFCE0
        public void SetStrafeSpeed(){} // RVA: 0x7FFE8A4AFD70
        public void SetJumpImpulse(){} // RVA: 0x7FFE8A4AFE00
        public void GetGravityStrength(){} // RVA: 0x7FFE8A4AFE90
        public void GetRunSpeed(){} // RVA: 0x7FFE8A4AFF10
        public void GetWalkSpeed(){} // RVA: 0x7FFE8A4AFF90
        public void GetStrafeSpeed(){} // RVA: 0x7FFE8A4B0010
        public void GetJumpImpulse(){} // RVA: 0x7FFE8A4B0090
        public void IsUserInVR(){} // RVA: 0x7FFE8A4B0110
        public void SetGravityStrength(){} // RVA: 0x7FFE8A4B0190
        public void UseLegacyLocomotion(){} // RVA: 0x7FFE8A4B0220
        public void UseAttachedStation(){} // RVA: 0x7FFE8A4B02A0
        public void ClearInvisible(){} // RVA: 0x7FFE8A4B0320
        public void ClearSilence(){} // RVA: 0x7FFE8A4B03A0
        public void AddToList(){} // RVA: 0x7FFE8A4B0420
        public void RemoveFromList(){} // RVA: 0x7FFE8A4B04B0
        public void CombatSetup(){} // RVA: 0x7FFE8A4B0540
        public void CombatSetMaxHitpoints(){} // RVA: 0x7FFE8A4B05C0
        public void CombatSetCurrentHitpoints(){} // RVA: 0x7FFE8A4B0650
        public void CombatGetCurrentHitpoints(){} // RVA: 0x7FFE8A4B06E0
        public void CombatSetRespawn(){} // RVA: 0x7FFE8A4B0760
        public void CombatSetDamageGraphic(){} // RVA: 0x7FFE8A4B0820
        public void CombatGetDestructible(){} // RVA: 0x7FFE8A4B08B0
        public void SetVoiceGain(){} // RVA: 0x7FFE8A4B0930
        public void GetVoiceGain(){} // RVA: 0x7FFE8A4B09C0
        public void SetVoiceDistanceNear(){} // RVA: 0x7FFE8A4B0A40
        public void GetVoiceDistanceNear(){} // RVA: 0x7FFE8A4B0AD0
        public void SetVoiceDistanceFar(){} // RVA: 0x7FFE8A4B0B50
        public void GetVoiceDistanceFar(){} // RVA: 0x7FFE8A4B0BE0
        public void SetVoiceVolumetricRadius(){} // RVA: 0x7FFE8A4B0C60
        public void GetVoiceVolumetricRadius(){} // RVA: 0x7FFE8A4B0CF0
        public void SetVoiceLowpass(){} // RVA: 0x7FFE8A4B0D70
        public void GetVoiceLowpass(){} // RVA: 0x7FFE8A4B0E00
        public void SetAvatarAudioGain(){} // RVA: 0x7FFE8A4B0E80
        public void SetAvatarAudioFarRadius(){} // RVA: 0x7FFE8A4B0F10
        public void SetAvatarAudioNearRadius(){} // RVA: 0x7FFE8A4B0FA0
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x7FFE8A4B1030
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x7FFE8A4B10C0
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x7FFE8A4B1150
        public void GetAvailableLanguages(){} // RVA: 0x7FFE8A4B11E0
        public void GetCurrentLanguage(){} // RVA: 0x7FFE8A4B1250
        public void GetPlayerObjects(){} // RVA: 0x7FFE8A4B12C0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFE8A4B1360
        public void PushAnimations(){} // RVA: 0x7FFE8A4B1370
        public void PopAnimations(){} // RVA: 0x7FFE8A4B1400
        public void Immobilize(){} // RVA: 0x7FFE8A4B1480
        public void SetVelocity(){} // RVA: 0x7FFE8A4B1510
        public void GetVelocity(){} // RVA: 0x7FFE8A4B15B0
        public void GetPosition(){} // RVA: 0x7FFE8A4B1650
        public void GetRotation(){} // RVA: 0x7FFE8A4B16F0
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x7FFE8A4B1790
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x7FFE8A4B1810
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x7FFE8A4B1890
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x7FFE8A4B1910
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x7FFE8A4B1990
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x7FFE8A4B1A20
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x7FFE8A4B1AB0
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x7FFE8A4B1B40
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x7FFE8A4B1BD0
        public void .ctor(){} // RVA: 0x7FFE8A4B1C60
        public void .cctor(){} // RVA: 0x7FFE8A4B1CF0
    }

    public class VRCRenderTexture : Object
    {
        // ── Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0x7FFE8A4C03A0
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0x7FFE8A4C04D0
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7FFE8A4C0600
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7FFE8A4C0740
        public void GetTemporary(){} // RVA: 0x7FFE8A4C0960 | overloaded x2
        public void ReleaseTemporary(){} // RVA: 0x7FFE8A4C09F0
    }

    public class VRCShader : Object
    {
        // ── Methods ──
        public void add_OnSetGlobalShaderVariable(){} // RVA: 0x7FFE8A4C0A90
        public void remove_OnSetGlobalShaderVariable(){} // RVA: 0x7FFE8A4C0BF0
        public void PropertyToID(){} // RVA: 0x7FFE8A4C0D50
        public void SetGlobalInteger(){} // RVA: 0x7FFE8A4C1020
        public void SetGlobalFloat(){} // RVA: 0x7FFE8A4C10F0
        public void SetGlobalTexture(){} // RVA: 0x7FFE8A4C11C0
        public void SetGlobalColor(){} // RVA: 0x7FFE8A4C1290
        public void SetGlobalVector(){} // RVA: 0x7FFE8A4C13A0
        public void SetGlobalMatrix(){} // RVA: 0x7FFE8A4C1480
        public void SetGlobalFloatArray(){} // RVA: 0x7FFE8A4C1570
        public void SetGlobalVectorArray(){} // RVA: 0x7FFE8A4C1610
        public void SetGlobalMatrixArray(){} // RVA: 0x7FFE8A4C16B0
        public void ValidateAgainstPropertyIDWhitelist(){} // RVA: 0x7FFE8A4C1750
        public void ClearGlobalVariableWhitelist(){} // RVA: 0x7FFE8A4C1860
        public void .cctor(){} // RVA: 0x7FFE8A4C1920
    }

    public class VRCStation : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4C1D80
        public void UseStation(){} // RVA: 0x7FFE8A4C1DE0
        public void ExitStation(){} // RVA: 0x7FFE8A4C1E50
        public void .ctor(){} // RVA: 0x7FFE8A44EFA0
    }

    public class VRCTriggerRelay : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4D98E0
        public void OnTriggerEnter(){} // RVA: 0x7FFE8A4D9940
        public void OnTriggerExit(){} // RVA: 0x7FFE8A4D99D0
        public void .ctor(){} // RVA: 0x7FFE8A4D9A50
    }

    public class VRCUrl : Object
    {
        public VRC.SDKBase.VRCUrl _empty;
        public System.Func`1<System.Collections.Generic.IEnumerable`1<string>> _domainExplicitAllowlistDelegate; // 0x8
        public System.Func`1<System.Collections.Generic.IEnumerable`1<string>> _domainWildcardAllowlistDelegate; // 0x10

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFE8A4D9C10
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x7FFE8A4D9C70
        public void IsNullOrEmpty(){} // RVA: 0x7FFE8A4D9F00
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFE8A4D9FA0
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFE8A4DA000
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFE8A4DA0C0
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFE8A4DA120
        public void IsAllowlistedUri(){} // RVA: 0x7FFE8A4DA1E0
        public void .ctor(){} // RVA: 0x7FFE8A4DA440
        public void Get(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE8A4DA620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86FE2840
        public void .cctor(){} // RVA: 0x7FFE8A4DA670
    }

    public class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B3E80
        public void OnStateEnter(){} // RVA: 0x7FFE861D3AE0
        public void .ctor(){} // RVA: 0x7FFE8A47D310
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B3EE0
        public void OnStateEnter(){} // RVA: 0x7FFE8722F560
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VRC_AnimatorPlayAudio : StateMachineBehaviour
    {
        public UnityEngine.AudioSource Source; // 0x18
        public string SourcePath; // 0x20
        public 0x66647804 PlaybackOrder; // 0x28
        public string ParameterName; // 0x30

        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x7FFE8A4B3F40
        public void get_ShouldApplyPitch(){} // RVA: 0x7FFE8A4B3F50
        public void get_ShouldApplyClip(){} // RVA: 0x7FFE8A4B3F60
        public void get_ShouldApplyLoop(){} // RVA: 0x7FFE8A4B3F70
        public void ShouldApplySetting(){} // RVA: 0x7FFE8A4B3F80
        public void Awake(){} // RVA: 0x7FFE8A4B4000
        public void OnStateEnter(){} // RVA: 0x7FFE8A4B4060
        public void OnStateExit(){} // RVA: 0x7FFE8A4B4080
        public void .ctor(){} // RVA: 0x7FFE8A47D320
    }

    public class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B40B0
        public void OnStateEnter(){} // RVA: 0x7FFE8A4B4110
        public void OnStateUpdate(){} // RVA: 0x7FFE8A4B41A0
        public void .ctor(){} // RVA: 0x7FFE8A47D370
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B4240
        public void OnStateEnter(){} // RVA: 0x7FFE8778D0C0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        public string Name; // 0x20

        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8A4B42A0
        public void PositionPortraitCamera(){} // RVA: 0x7FFE8A4B45E0
        public void get_NetworkIDCollection(){} // RVA: 0x7FFE81166040
        public void set_NetworkIDCollection(){} // RVA: 0x7FFE81166050
        public void GetNetworkIDObjects(){} // RVA: 0x7FFE8A4B4A70
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFE8A4B4B10
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFE8A4B4E30
        public void .ctor(){} // RVA: 0x7FFE8A4B4EB0
    }

    public class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFE8A4B5190
        public void .ctor(){} // RVA: 0x7FFE8A481B50
    }

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4BA190
        public void SwitchAvatar(){} // RVA: 0x7FFE8A4966A0 | overloaded x2
        public void SetAvatarUse(){} // RVA: 0x7FFE8A4BA6A0
        public void .ctor(){} // RVA: 0x7FFE8A4BA7E0
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0x7FFE8A4DAAC0
        public void GetElement(){} // RVA: 0x7FFE8A4DAB30
        public void add_ElementChanged(){} // RVA: 0x7FFE8A4DABC0
        public void remove_ElementChanged(){} // RVA: 0x7FFE8A4DACB0
        public void OnDataElementChanged(){} // RVA: 0x7FFE8A4DADA0
        public void Awake(){} // RVA: 0x7FFE8A4DADD0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_DestructibleStandard : MonoBehaviour
    {
        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0x7FFE81124080
        public void GetCurrentHealth(){} // RVA: 0x7FFE81268F50
        public void Awake(){} // RVA: 0x7FFE8A4B6850
        public void ApplyDamage(){} // RVA: 0x7FFE8A4B6A30
        public void ApplyHealing(){} // RVA: 0x7FFE8A4B6FC0
        public void GetState(){} // RVA: 0x7FFE8A4B75A0
        public void SetState(){} // RVA: 0x7FFE8A4B7670
        public void HandleCallbackTrigger(){} // RVA: 0x7FFE8A4B76F0
        public void .ctor(){} // RVA: 0x7FFE8A443740
        public void <ApplyDamage>b__27_0(){} // RVA: 0x7FFE8A4B5B20
        public void <ApplyDamage>b__27_1(){} // RVA: 0x7FFE8A4B7830
        public void <ApplyHealing>b__28_0(){} // RVA: 0x7FFE8A4B7830
        public void <ApplyHealing>b__28_1(){} // RVA: 0x7FFE8A4B7890
    }

    public class VRC_EventDispatcher : MonoBehaviour
    {
        // ── Methods ──
        public void TriggerEvent(){}
        public void RegisterEventHandler(){} // RVA: 0x7FFE80E460A0
        public void UnregisterEventHandler(){} // RVA: 0x7FFE80E460A0
        public void FindGameObject(){} // RVA: 0x7FFE80E3EBB0 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcher
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4B85C0
        public void TriggerEvent(){} // RVA: 0x7FFE810FB310
        public void RegisterEventHandler(){} // RVA: 0x7FFE810FB310
        public void UnregisterEventHandler(){} // RVA: 0x7FFE810FB310
        public void FindGameObject(){} // RVA: 0x7FFE8A4B8610
        public void GetGameObjectPath(){} // RVA: 0x7FFE8A4B8660
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_EventHandler : VRCNetworkBehaviour
    {
        public System.Collections.Generic.List`1<VrcEvent> Events; // 0x20
        public VRC.SDKBase.VRC_EventDispatcher _dispatcher; // 0x28

        // ── Methods ──
        public void BooleanOp(){} // RVA: 0x7FFE8A4DAEC0
        public void get_Dispatcher(){} // RVA: 0x7FFE8A4DAEE0
        public void get_GetInsitgatorId(){} // RVA: 0x7FFE8A4DB000
        public void set_GetInsitgatorId(){} // RVA: 0x7FFE8A4DB040
        public void Awake(){} // RVA: 0x7FFE8A4DB0E0
        public void VrcAnimationEvent(){} // RVA: 0x7FFE8A4DB480
        public void IsReceiverRequiredForEventType(){} // RVA: 0x7FFE8A4DB670
        public void TriggerEvent(){} // RVA: 0x7FFE8A4DC6C0 | overloaded x4
        public void InternalTriggerEvent(){} // RVA: 0x7FFE8A4DC130
        public void OnValidate(){} // RVA: 0x7FFE8A4DC8B0
        public void OnDestroy(){} // RVA: 0x7FFE8A4DCA10
        public void GetCombinedNetworkId(){} // RVA: 0x7FFE813240E0
        public void HasEventTrigger(){} // RVA: 0x7FFE8A4DCB80
        public void IsReadyForEvents(){} // RVA: 0x7FFE811E0850
        public void DeferEvent(){} // RVA: 0x7FFE8A4DCC80
        public void ProcessDeferredEvents(){} // RVA: 0x7FFE8A4DCF70
        public void .ctor(){} // RVA: 0x7FFE8A4DD010
    }

    public class VRC_GunStats : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A443D70
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4DDA70
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        public UnityEngine.Transform interactTextPlacement; // 0x20
        public string interactText; // 0x28

        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0x7FFE810FB320
        public void get_Proximity(){} // RVA: 0x7FFE8130ACF0
        public void Start(){} // RVA: 0x7FFE810FB310
        public void Awake(){} // RVA: 0x7FFE8A4DDDE0
        public void Interact(){} // RVA: 0x7FFE80E45FE0
        public void OnPickupUseUp(){} // RVA: 0x7FFE810FB310
        public void OnPickupUseDown(){} // RVA: 0x7FFE810FB310
        public void OnPickup(){} // RVA: 0x7FFE810FB310
        public void OnDrop(){} // RVA: 0x7FFE810FB310
        public void IsInteractiveForPlayer(){} // RVA: 0x7FFE8A4DDE40
        public void .ctor(){} // RVA: 0x7FFE8A4DDEE0
    }

    public class VRC_KeyEvents : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4B5210
        public void Update(){} // RVA: 0x7FFE8A4B5470
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void <Update>b__9_0(){} // RVA: 0x7FFE8A4B5AC0
        public void <Update>b__9_2(){} // RVA: 0x7FFE8A4B5AC0
        public void <Update>b__9_1(){} // RVA: 0x7FFE8A4B5B20
        public void <Update>b__9_3(){} // RVA: 0x7FFE8A4B5B20
    }

    public class VRC_Label : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A451A30
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        public MetadataCallback callbacks;

        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0x7FFE8A4C1EC0
        public void Awake(){} // RVA: 0x7FFE8A4C1F20
        public void OnDestroy(){} // RVA: 0x7FFE8A4C2090
        public void TriggerUpdate(){} // RVA: 0x7FFE8A4C2200
        public void MetadataChangedInternal(){} // RVA: 0x7FFE8A4C2260
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_MidiNoteIn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B9D90
        public void Start(){} // RVA: 0x7FFE810FB310
        public void Update(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_MirrorReflection : MonoBehaviour
    {
        public string VRC_MIRROR_CAMERA_POS_PROPERTY;
        public string VRC_MIRROR_MODE_PROPERTY;

        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x7FFE8A4C2280
        public void remove_PreRenderMirror(){} // RVA: 0x7FFE8A4C23D0
        public void add_PostRenderMirror(){} // RVA: 0x7FFE8A4C2520
        public void remove_PostRenderMirror(){} // RVA: 0x7FFE8A4C2670
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x7FFE8A4C27C0
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x7FFE8A4C2820
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFE8A4C28E0
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFE8A4C2950
        public void OnValidate(){} // RVA: 0x7FFE8A4C29C0
        public void Start(){} // RVA: 0x7FFE8A4C2A20
        public void TrySetupMaterial(){} // RVA: 0x7FFE8A4C2CE0
        public void IsVisibleToCamera(){} // RVA: 0x7FFE8A4C3230
        public void IsLayerRendered(){} // RVA: 0x7FFE8A4C3430
        public void CameraOnPreCull(){} // RVA: 0x7FFE8A4C34B0
        public void RenderMirrorCameras(){} // RVA: 0x7FFE8A4C3930
        public void CameraPostRender(){} // RVA: 0x7FFE8A4C4BD0
        public void OnEnable(){} // RVA: 0x7FFE8A4C4ED0
        public void OnDisable(){} // RVA: 0x7FFE8A4C5180
        public void OnDestroy(){} // RVA: 0x7FFE8A4C5890
        public void ShouldRenderLeftEye(){} // RVA: 0x7FFE8A4C5BE0
        public void ShouldRenderRightEye(){} // RVA: 0x7FFE8A4C5DF0
        public void ShouldRenderMonoscopic(){} // RVA: 0x7FFE8A4C6000
        public void GetWorldEyePos(){} // RVA: 0x7FFE8A4C6260
        public void GetWorldEyeRot(){} // RVA: 0x7FFE8A4C6390
        public void GetEyeProjectionMatrix(){} // RVA: 0x7FFE8A4C6580
        public void GetNormalDirection(){} // RVA: 0x7FFE8A4C6650
        public void RenderMirror(){} // RVA: 0x7FFE8A4C6700
        public void UpdateCameraClearing(){} // RVA: 0x7FFE8A4C7420
        public void UpdateCameraModes(){} // RVA: 0x7FFE8A4C7800
        public void UpdateParentTransform(){} // RVA: 0x7FFE8A4C8170
        public void GetReflectionData(){} // RVA: 0x7FFE8A4C8AE0
        public void GetAutoResolution(){} // RVA: 0x7FFE8A4C95D0
        public void Plane(){} // RVA: 0x7FFE8A4C97C0
        public void CameraSpacePlane(){} // RVA: 0x7FFE8A4C9820
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFE8A4C9C30
        public void CopySign(){} // RVA: 0x7FFE8A4C9DA0
        public void GetRotation(){} // RVA: 0x7FFE8A4C9DD0
        public void GetPosition(){} // RVA: 0x7FFE86FDC8E0
        public void .ctor(){} // RVA: 0x7FFE8A4CA010
        public void .cctor(){} // RVA: 0x7FFE8A4CA120
    }

    public class VRC_NPCSpawn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4BA8A0
        public void .ctor(){} // RVA: 0x7FFE8A4448D0
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4B5B80
        public void GetApiByGameObject(){} // RVA: 0x7FFE8A4B5BE0
        public void ActThis(){} // RVA: 0x7FFE8A4B5CF0
        public void SayThis(){} // RVA: 0x7FFE8A4B5D80
        public void SetNamePlate(){} // RVA: 0x7FFE8A4B5E10
        public void SetSocialStatus(){} // RVA: 0x7FFE8A4B5EB0
        public void SetMuteStatus(){} // RVA: 0x7FFE8A4B5F50
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_ObjectApi : MonoBehaviour
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_ObjectSpawn : MonoBehaviour
    {
        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x7FFE8A4BAB60 | overloaded x2
        public void DestroySpawnedObjects(){} // RVA: 0x7FFE82BB4660
        public void Start(){} // RVA: 0x7FFE8A4BAC80
        public void ProvideEvents(){} // RVA: 0x7FFE8A4BACE0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B9DF0
        public void Start(){} // RVA: 0x7FFE810FB310
        public void Update(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Panorama : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4CA330
        public void Update(){} // RVA: 0x7FFE8A4CA500
        public void NextPano(){} // RVA: 0x7FFE8A4CA7D0
        public void PrevPano(){} // RVA: 0x7FFE8A4CA890
        public void ShowPanoAt(){} // RVA: 0x7FFE8A4CA950
        public void ShowPano(){} // RVA: 0x7FFE8A4CA9E0
        public void .ctor(){} // RVA: 0x7FFE8A451B00
    }

    public class VRC_PhysicsRoot : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4B5FE0
        public void OnDestroy(){} // RVA: 0x7FFE8A4B6610
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        public 0x66699ADC MomentumTransferMethod; // 0x20
        public bool DisallowTheft; // 0x24
        public UnityEngine.Transform ExactGun; // 0x28
        public UnityEngine.Transform ExactGrip; // 0x30

        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7FFE8A4BB2F0 | overloaded x2
        public void get_currentPlayer(){} // RVA: 0x7FFE8A4BB320
        public void get_IsHeld(){} // RVA: 0x7FFE8A4BB390
        public void get_currentHand(){} // RVA: 0x7FFE8A4BB450
        public void get_Proximity(){} // RVA: 0x7FFE89E42210
        public void Awake(){} // RVA: 0x7FFE8A4BB4B0
        public void OnDisable(){} // RVA: 0x7FFE8A4BB510
        public void Reset(){} // RVA: 0x7FFE8A4BB550
        public void Drop(){} // RVA: 0x7FFE8A4BB6E0 | overloaded x2
        public void GenerateHapticEvent(){} // RVA: 0x7FFE8A4BB940
        public void OnDestroy(){} // RVA: 0x7FFE8A4BB9E0
        public void PlayHaptics(){} // RVA: 0x7FFE8A4BBA40
        public void ProvideEvents(){} // RVA: 0x7FFE8A4BBA70
        public void .ctor(){} // RVA: 0x7FFE8A4BBEB0
    }

    public class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B6730
        public void OnStateEnter(){} // RVA: 0x7FFE8A4B6790
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x7FFE812AD970
        public void Awake(){} // RVA: 0x7FFE8A4BC260
        public void Update(){} // RVA: 0x7FFE8A4BC2E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_PropApi : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_PropController : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4BC360
        public void Update(){} // RVA: 0x7FFE8A4BC3C0
        public void GetInputIndex(){} // RVA: 0x7FFE8A4BC430
        public void .ctor(){} // RVA: 0x7FFE8A446020
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        public object apiProp; // 0x20
        public string unityVersion; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4BC530
        public void get_NetworkIDCollection(){} // RVA: 0x7FFE81178740
        public void set_NetworkIDCollection(){} // RVA: 0x7FFE81123200
        public void get_NetworkIDLookup(){} // RVA: 0x7FFE81176730
        public void set_NetworkIDLookup(){} // RVA: 0x7FFE81176740
        public void GetNetworkIDObjects(){} // RVA: 0x7FFE8A4BCF60
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFE8A4BD000
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFE8A4B4E30
        public void .ctor(){} // RVA: 0x7FFE8A4BD320
    }

    public class VRC_SceneDescriptor : MonoBehaviour
    {
        public UnityEngine.Transform[] spawns; // 0x20
        public float spawnRadius; // 0x28
        public 0x66649E84 spawnOrder; // 0x2C
        public 0x66649EDC spawnOrientation; // 0x30
        public UnityEngine.GameObject ReferenceCamera; // 0x38
        public float RespawnHeightY; // 0x40

        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0x7FFE8A4CB360
        public void GetPrefab(){} // RVA: 0x7FFE8A4CB550
        public void GetMaterial(){} // RVA: 0x7FFE8A4CB940
        public void get_NetworkIDCollection(){} // RVA: 0x7FFE81B23D60
        public void set_NetworkIDCollection(){} // RVA: 0x7FFE81B11520
        public void get_NetworkIDLookup(){} // RVA: 0x7FFE816611A0
        public void set_NetworkIDLookup(){} // RVA: 0x7FFE81B31CF0
        public void GetNetworkIDObjects(){} // RVA: 0x7FFE8A4CBD30
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFE8A4CC020
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFE8A4B4E30
        public void get_Instance(){} // RVA: 0x7FFE8A4CC580
        public void get_Exists(){} // RVA: 0x7FFE8A4CC890
        public void get_BundleUnityMajorVersion(){} // RVA: 0x7FFE8A4CC990
        public void set_BundleUnityMajorVersion(){} // RVA: 0x7FFE8A4CC9A0
        public void get_Scene(){} // RVA: 0x7FFE82A2C610
        public void set_Scene(){} // RVA: 0x7FFE82A2C620
        public void Awake(){} // RVA: 0x7FFE8A4CC9B0
        public void OnDestroy(){} // RVA: 0x7FFE8A4CD980
        public void PositionPortraitCamera(){} // RVA: 0x7FFE8A4CDA40
        public void .ctor(){} // RVA: 0x7FFE8A4CDE10
        public void .cctor(){} // RVA: 0x7FFE8A4CE140
    }

    public class VRC_Serialization : Object
    {
        public System.Collections.Generic.HashSet`1<System.Type> _allowedTypes;
        public System.Collections.Generic.HashSet`1<System.Type> _allowedPluginTypes; // 0x8
        public bool _allowPluginTypes; // 0x10

        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x7FFE8A4DDFA0
        public void set_AllowPluginTypes(){} // RVA: 0x7FFE8A4DE000
        public void get_SurrogateSelector(){} // RVA: 0x7FFE8A4DE060
        public void RegisterPluginType(){} // RVA: 0x7FFE8A4DE170
        public void RegisterType(){} // RVA: 0x7FFE8A4DE260
        public void ParameterEncoder(){} // RVA: 0x7FFE8A4DE350
        public void ParameterDecoder(){} // RVA: 0x7FFE8A4DE560
        public void get_Dispatcher(){} // RVA: 0x7FFE8A4DE7D0
        public void GetGameObjectPathFallback(){} // RVA: 0x7FFE8A4DE910
        public void GetGameObjectPath(){} // RVA: 0x7FFE8A4DEB80
        public void FindGameObject(){} // RVA: 0x7FFE8A4DECC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A4DEE20
    }

    public class VRC_SlideShow : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4BD540
        public void ShowNextImage(){} // RVA: 0x7FFE8A4BD600
        public void ShowPreviousImage(){} // RVA: 0x7FFE8A4BD820
        public void StartAutoplayWithDuration(){} // RVA: 0x7FFE8A4BD9F0
        public void StopAutoplayWithDuration(){} // RVA: 0x7FFE8A4BDAB0
        public void .ctor(){} // RVA: 0x7FFE8A446120
    }

    public class VRC_SpatialAudioSource : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4AD8A0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8A4ADB40
        public void .ctor(){} // RVA: 0x7FFE8A4427A0
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFE8A4CE430
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_StereoObject : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_TimedEvents : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4CE660
        public void OnEnable(){} // RVA: 0x7FFE8A4CE830
        public void Update(){} // RVA: 0x7FFE8A4CE840
        public void ResetClock(){} // RVA: 0x7FFE8A4CE9D0
        public void .ctor(){} // RVA: 0x7FFE8A44F060
    }

    public class VRC_Trigger : VRC_Interactable
    {
        public System.Action`1<VRC.SDKBase.VRC_Trigger> InitializeTrigger;
        public bool isHidden; // 0x40
        public bool UsesAdvancedOptions; // 0x41
        public bool TakesOwnershipIfNecessary; // 0x42
        public bool DrawLines; // 0x43
        public 0x6664A2FC EditorGlobalTriggerLineMode; // 0x8

        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0x7FFE8A4CECE0 | overloaded x2
        public void Trigger(){} // RVA: 0x7FFE8A4CEB50
        public void get_HasKeyTriggers(){} // RVA: 0x7FFE8A4CEE70
        public void get_HasTimerTriggers(){} // RVA: 0x7FFE8A4CEFE0
        public void get_HasColliderTriggers(){} // RVA: 0x7FFE8A4CF150
        public void get_HasInteractiveTriggers(){} // RVA: 0x7FFE8A4CF3F0
        public void get_HasPickupTriggers(){} // RVA: 0x7FFE8A4CF560
        public void get_IsInteractive(){} // RVA: 0x7FFE8A4CF6D0
        public void Awake(){} // RVA: 0x7FFE8A4CF9B0
        public void OnDestroy(){} // RVA: 0x7FFE8A4CFA60
        public void OnEnable(){} // RVA: 0x7FFE8A4CFA70
        public void OnDisable(){} // RVA: 0x7FFE8A4CFAA0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8A4CFAD0
        public void Interact(){} // RVA: 0x7FFE8A4D0080
        public void OnPickupUseUp(){} // RVA: 0x7FFE8A4D0090
        public void OnPickupUseDown(){} // RVA: 0x7FFE8A4D00A0
        public void OnPickup(){} // RVA: 0x7FFE8A4D00B0
        public void OnDrop(){} // RVA: 0x7FFE8A4D00C0
        public void ExecuteTriggers(){} // RVA: 0x7FFE8A4D00D0
        public void ExecuteTriggerType(){} // RVA: 0x7FFE8A4D03D0
        public void ExecuteCustomTrigger(){} // RVA: 0x7FFE8A4D0730
        public void ResetClocks(){} // RVA: 0x7FFE8A4D0B20
        public void ResetClock(){} // RVA: 0x7FFE8A4D0E90
        public void .ctor(){} // RVA: 0x7FFE8A44F0C0
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x7FFE8A4D0F20
    }

    public class VRC_TriggerColliderEventTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8A4D1ED0
        public void OnTriggerEnter(){} // RVA: 0x7FFE8A4D2090
        public void OnTriggerExit(){} // RVA: 0x7FFE8A4D21D0
        public void .ctor(){} // RVA: 0x7FFE8A44F190
    }

    public class VRC_TutorialAction : MonoBehaviour
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFE8A4D7770
        public void ActivateObjectLabel(){} // RVA: 0x7FFE8A4D7970 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFE8A4D7A00
        public void ActivateControllerLabel(){} // RVA: 0x7FFE8A4D7A60
        public void DeactivateControllerLabel(){} // RVA: 0x7FFE8A4D7A90
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRC_TutorialAreaMarker : MonoBehaviour
    {
        // ── Methods ──
        public void Enable(){} // RVA: 0x7FFE866032C0
        public void Update(){} // RVA: 0x7FFE8A4D7AA0
        public void ShowLabel(){} // RVA: 0x7FFE8A4D7ED0
        public void .ctor(){} // RVA: 0x7FFE8A44F550
    }

    public class VRC_UiShape : MonoBehaviour
    {
        public GetEventCameraDelegate GetEventCamera;
        public UnityEngine.Canvas _rootCanvas; // 0x20

        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0x7FFE811290C0
        public void set_RootCanvas(){} // RVA: 0x7FFE811290D0
        public void get_RootCanvasRectTransform(){} // RVA: 0x7FFE81129130
        public void set_RootCanvasRectTransform(){} // RVA: 0x7FFE810FCE90
        public void add_OnUiShapeInit(){} // RVA: 0x7FFE8A4D8A50
        public void remove_OnUiShapeInit(){} // RVA: 0x7FFE8A4D8B90
        public void add_OnUiShapeDestroy(){} // RVA: 0x7FFE8A4D8CD0
        public void remove_OnUiShapeDestroy(){} // RVA: 0x7FFE8A4D8E10
        public void Awake(){} // RVA: 0x7FFE8A4D8F50
        public void Start(){} // RVA: 0x7FFE8A4D90F0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE8A4D9450
        public void SetupCollision(){} // RVA: 0x7FFE8A4D9460
        public void OnDestroy(){} // RVA: 0x7FFE8A4D9880
        public void .ctor(){} // RVA: 0x7FFE811AF710
    }

    public class VRC_UseEvents : VRC_Interactable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4D2310
        public void Start(){} // RVA: 0x7FFE8A4D2550
        public void Interact(){} // RVA: 0x7FFE8A4D27E0
        public void .ctor(){} // RVA: 0x7FFE8A44F1E0
        public void <Awake>b__5_0(){} // RVA: 0x7FFE8A4D29C0
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A4B78F0
        public void Start(){} // RVA: 0x7FFE8A4B7980
        public void OnSceneWasLoaded(){} // RVA: 0x7FFE8A4B7BB0
        public void Update(){} // RVA: 0x7FFE8A4B7C50
        public void HideDamageIndicator(){} // RVA: 0x7FFE8A4B7E80
        public void ShowDamageIndicator(){} // RVA: 0x7FFE8A4B7FA0
        public void SetDamagePercent(){} // RVA: 0x7FFE8A4B80C0
        public void .ctor(){} // RVA: 0x7FFE8A4B83C0
    }

    public class VRC_Water : MonoBehaviour
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFE8A4D2AD0
        public void OnDisable(){} // RVA: 0x7FFE8A4D37B0
        public void Update(){} // RVA: 0x7FFE8A4D3E00
        public void UpdateCameraModes(){} // RVA: 0x7FFE8A4D42D0
        public void CreateWaterObjects(){} // RVA: 0x7FFE8A4D4850
        public void GetWaterMode(){} // RVA: 0x7FFE8A4D5C10
        public void FindHardwareWaterSupport(){} // RVA: 0x7FFE8A4D5C20
        public void CameraSpacePlane(){} // RVA: 0x7FFE81112D00
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFE811130F0
        public void .ctor(){} // RVA: 0x7FFE8A44F280
    }

    public class VRC_WebPanel : VRC_Interactable
    {
        public string webRoot; // 0x40

        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0x7FFE8A4D5F10
        public void WebPanelBackward(){} // RVA: 0x7FFE8A4D5F40
        public void WebPanelReload(){} // RVA: 0x7FFE8A4D5F70
        public void BindCall(){} // RVA: 0x7FFE8A4D5FA0
        public void NavigateTo(){} // RVA: 0x7FFE8A4D5FD0
        public void Awake(){} // RVA: 0x7FFE8A4D6000
        public void Interact(){} // RVA: 0x7FFE810FB310
        public void get_WebRootPath(){} // RVA: 0x7FFE8A4D6110
        public void ProvideEvents(){} // RVA: 0x7FFE8A4D6280
        public void ReadData(){} // RVA: 0x7FFE8A4D6BB0
        public void ImportWebData(){} // RVA: 0x7FFE8A4D6E10
        public void .ctor(){} // RVA: 0x7FFE8A44F420
    }

    public class VersionHelper : Object
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0x7FFE810A1420
    }

}