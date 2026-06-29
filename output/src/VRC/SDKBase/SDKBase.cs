// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 88
// Methods: 828

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        // ── Methods ──
        public void get_boolVal(){} // RVA: 0x7A7E01900
        public void set_boolVal(){} // RVA: 0x7A7E18C30
        public void get_intVal(){} // RVA: 0x7A7E00710
        public void set_intVal(){} // RVA: 0x7A7E189D0
        public void get_floatVal(){} // RVA: 0x7A7E155B0
        public void set_floatVal(){} // RVA: 0x7A7E262C0
    }

    public class INetworkIDContainer
    {
        // ── Methods ──
        public void get_NetworkIDCollection(){} // RVA: 0x7A7E00680
        public void set_NetworkIDCollection(){} // RVA: 0x7A7E18800
        public void GetNetworkIDObjects(){} // RVA: 0x7A7E18800
        public void FindNetworkIDGameObject(){} // RVA: 0x7A7E01780
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7A7E00BD0
    }

    public class INetworkID[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IPreprocessCallbackBehaviour
    {
        // ── Methods ──
        public void OnPreprocess(){} // RVA: 0x7A7E01900
        public void get_PreprocessOrder(){} // RVA: 0x7A7E00710
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0x7A7E00680
    }

    public class IVRC_Destructible
    {
        // ── Methods ──
        public void GetState(){} // RVA: 0x7A7E00680
        public void SetState(){} // RVA: 0x7A7E18800
        public void GetMaxHealth(){} // RVA: 0x7A7E155B0
        public void GetCurrentHealth(){} // RVA: 0x7A7E155B0
        public void ApplyDamage(){} // RVA: 0x7A7E262C0
        public void ApplyHealing(){} // RVA: 0x7A7E262C0
    }

    public class IValidChecker
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A7E01900
    }

    public class InputManager : Object
    {
        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0x7B18DC2E0
        public void GetLastUsedInputMethod(){} // RVA: 0x7B18DC340
        public void GetBoolInputSetting(){} // RVA: 0x7B18DC3B0
        public void SetBoolInputSetting(){} // RVA: 0x7B18DC410
        public void EnableObjectHighlight(){} // RVA: 0x7B18DC580
    }

    public class MathUtil : Object
    {
        // ── Methods ──
        public void AngleBetweenTwoUnitVectors(){} // RVA: 0x7B18B85F0
        public void AngleClosestBetweenTwoUnitVectors(){} // RVA: 0x7B1254FD0
        public void ClosestPointOnLineSegment_Value(){} // RVA: 0x7B18B87F0
        public void ClosestPointOnLineSegment(){} // RVA: 0x7B1255190
        public void ClosestPointOnPlane(){} // RVA: 0x7B12552B0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B18B88A0
    }

    public class Networking : Object
    {
        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x7B18B74A0
        public void get_IsNetworkSettled(){} // RVA: 0x7B18B7500
        public void get_IsMaster(){} // RVA: 0x7B18B7560
        public void get_IsClogged(){} // RVA: 0x7B18B75C0
        public void get_IsInstanceOwner(){} // RVA: 0x7B18B7620
        public void get_LocalPlayer(){} // RVA: 0x7B18B7680
        public void get_Master(){} // RVA: 0x7B18B76E0
        public void get_InstanceOwner(){} // RVA: 0x7B18B7740
        public void IsOwner(){} // RVA: 0x7B18B7820
        public void GetOwner(){} // RVA: 0x7B18B78E0
        public void SetOwner(){} // RVA: 0x7B18B7950
        public void IsObjectReady(){} // RVA: 0x7B18B79C0
        public void Instantiate(){} // RVA: 0x7B18B7A30
        public void RPC(){} // RVA: 0x7B18B7B80
        public void EncodeParameters(){} // RVA: 0x7B18B7C20
        public void DecodeParameters(){} // RVA: 0x7B18B7C90
        public void Destroy(){} // RVA: 0x7B18B7D00
        public void GetUniqueName(){} // RVA: 0x7B18B7D70
        public void GoToRoom(){} // RVA: 0x7B18B7DE0
        public void GetNetworkDateTime(){} // RVA: 0x7B18B7E50
        public void GetServerTimeInSeconds(){} // RVA: 0x7B18B7EF0
        public void GetServerTimeInMilliseconds(){} // RVA: 0x7B18B7FA0
        public void CalculateServerDeltaTime(){} // RVA: 0x7B18B8050
        public void SafeStartCoroutine(){} // RVA: 0x7B18B80E0
        public void GetEventDispatcher(){} // RVA: 0x7B18B8150
        public void SimulationTime(){} // RVA: 0x7B18B8260
        public void RequestStorageUsageUpdate(){} // RVA: 0x7AF7E22B0
        public void GetPlayerObjects(){} // RVA: 0x7B18AFA70
        public void GetPlayerDataStorageLimit(){} // RVA: 0x7B18B8310
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x7B18B8370
        public void GetPlayerDataStorageUsage(){} // RVA: 0x7B18B83D0
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x7B18B8440
        public void FindComponentInPlayerObjects(){} // RVA: 0x7B18B84B0
    }

    public class RPC : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B18B70C0
        public void SetupTargets(){} // RVA: 0x7B18B70E0
    }

    public class RPCIgnoredType : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RPC[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Tutorial : Object
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7B18D67E0
        public void ActivateObjectLabel(){} // RVA: 0x7B18D69F0
        public void DeactivateObjectLabel(){} // RVA: 0x7B18D6AE0
        public void ActivateControllerLabel(){} // RVA: 0x7B18D6B40
        public void DeactivateControllerLabel(){} // RVA: 0x7B18D6BE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Utilities : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7B18E45D0
        public void ShuffleArray(){} // RVA: 0x7B18E4720
        public void IsClient(){} // RVA: 0x7B18E4850
        public void SetIsClient(){} // RVA: 0x7B18E4890
        public void Fletcher32Fast(){} // RVA: 0x7B18E48D0
    }

    public class VRCBuiltInShaderGlobals : MonoBehaviour
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7B18BC4C0
        public void set_Instance(){} // RVA: 0x7B18BC520
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x7A81052C0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x7A81052D0
        public void Update(){} // RVA: 0x7B18BC5E0
        public void OnDestroy(){} // RVA: 0x7B18BCC80
        public void Initialize(){} // RVA: 0x7B18BCF70
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void .cctor(){} // RVA: 0x7B18BD3B0
    }

    public class VRCCustomAction : MonoBehaviour
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7B18C04F0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRCDroneApi : Object
    {
        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x7B18B6C80
        public void GetPlayer(){} // RVA: 0x7A7E00680
        public void IsDeployed(){} // RVA: 0x7A7E01900
        public void TryGetPosition(){} // RVA: 0x7A7E019D0
        public void GetPosition(){} // RVA: 0x7A7E00490
        public void TryGetRotation(){} // RVA: 0x7A7E019D0
        public void GetRotation(){} // RVA: 0x7A7E00490
        public void TryGetVelocity(){} // RVA: 0x7A7E019D0
        public void GetVelocity(){} // RVA: 0x7A7E00490
        public void TeleportTo(){} // RVA: 0x7A7E1EE20
        public void SetVelocity(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class VRCGraphics : Object
    {
        // ── Methods ──
        public void get_UiLayerMask(){} // RVA: 0x7B18BD7F0
        public void Blit(){} // RVA: 0x7B18BDDC0
        public void DrawMeshInstanced(){} // RVA: 0x7B18BE750
        public void GetLayerMask(){} // RVA: 0x7B18BE8B0
        public void CheckBlitTarget(){} // RVA: 0x7B18BE8C0
        public void .cctor(){} // RVA: 0x7B18BE9D0
    }

    public class VRCPlayerApi : Object
    {
        // ── Methods ──
        public void get_isMaster(){} // RVA: 0x7B18ACB40
        public void get_isInstanceOwner(){} // RVA: 0x7B18ACBC0
        public void get_isModerator(){} // RVA: 0x7B18ACC40
        public void get_isSuper(){} // RVA: 0x7B18ACCC0
        public void get_isSuspended(){} // RVA: 0x7B18ACD40
        public void get_isVRCPlus(){} // RVA: 0x7B18ACDC0
        public void IsPlayerGrounded(){} // RVA: 0x7B18ACE40
        public void GetDrone(){} // RVA: 0x7B18ACEE0
        public void get_AllPlayers(){} // RVA: 0x7B18ACF60
        public void GetPlayers(){} // RVA: 0x7B18AD070
        public void GetPlayerCount(){} // RVA: 0x7B18AD110
        public void GetPlayerId(){} // RVA: 0x7B18AD190
        public void get_playerId(){} // RVA: 0x7B18AD210
        public void GetPlayerByGameObject(){} // RVA: 0x7B18AD270
        public void GetPlayerById(){} // RVA: 0x7B18AD2F0
        public void IsValid(){} // RVA: 0x7A80FD690
        public void IsOwner(){} // RVA: 0x7B18AD370
        public void TakeOwnership(){} // RVA: 0x7B18AD400
        public void GetTrackingData(){} // RVA: 0x7B18AD490
        public void GetBoneTransform(){} // RVA: 0x7B18AD550
        public void GetBonePosition(){} // RVA: 0x7B18AD5E0
        public void GetBoneRotation(){} // RVA: 0x7B18AD6A0
        public void GetPickupInHand(){} // RVA: 0x7B18AD750
        public void SetPickupInHand(){} // RVA: 0x7A80D7310
        public void PlayHapticEventInHand(){} // RVA: 0x7B18AD7E0
        public void TeleportTo(){} // RVA: 0x7B18ADAA0
        public void Respawn(){} // RVA: 0x7B18ADC20
        public void EnablePickups(){} // RVA: 0x7B18ADCB0
        public void SetNamePlateColor(){} // RVA: 0x7B18ADD40
        public void RestoreNamePlateColor(){} // RVA: 0x7B18ADDE0
        public void SetNamePlateVisibility(){} // RVA: 0x7B18ADE60
        public void RestoreNamePlateVisibility(){} // RVA: 0x7B18ADEF0
        public void SetPlayerTag(){} // RVA: 0x7B18ADF70
        public void GetPlayerTag(){} // RVA: 0x7B18AE010
        public void GetPlayersWithTag(){} // RVA: 0x7A82D1450
        public void ClearPlayerTags(){} // RVA: 0x7B18AE0A0
        public void SetInvisibleToTagged(){} // RVA: 0x7B18AE120
        public void SetInvisibleToUntagged(){} // RVA: 0x7B18AE1E0
        public void SetSilencedToTagged(){} // RVA: 0x7B18AE2A0
        public void SetSilencedToUntagged(){} // RVA: 0x7B18AE350
        public void SetRunSpeed(){} // RVA: 0x7B18AE400
        public void SetWalkSpeed(){} // RVA: 0x7B18AE490
        public void SetStrafeSpeed(){} // RVA: 0x7B18AE520
        public void SetJumpImpulse(){} // RVA: 0x7B18AE5B0
        public void GetGravityStrength(){} // RVA: 0x7B18AE640
        public void GetRunSpeed(){} // RVA: 0x7B18AE6C0
        public void GetWalkSpeed(){} // RVA: 0x7B18AE740
        public void GetStrafeSpeed(){} // RVA: 0x7B18AE7C0
        public void GetJumpImpulse(){} // RVA: 0x7B18AE840
        public void IsUserInVR(){} // RVA: 0x7B18AE8C0
        public void SetGravityStrength(){} // RVA: 0x7B18AE940
        public void UseLegacyLocomotion(){} // RVA: 0x7B18AE9D0
        public void UseAttachedStation(){} // RVA: 0x7B18AEA50
        public void ClearInvisible(){} // RVA: 0x7B18AEAD0
        public void ClearSilence(){} // RVA: 0x7B18AEB50
        public void AddToList(){} // RVA: 0x7B18AEBD0
        public void RemoveFromList(){} // RVA: 0x7B18AEC60
        public void CombatSetup(){} // RVA: 0x7B18AECF0
        public void CombatSetMaxHitpoints(){} // RVA: 0x7B18AED70
        public void CombatSetCurrentHitpoints(){} // RVA: 0x7B18AEE00
        public void CombatGetCurrentHitpoints(){} // RVA: 0x7B18AEE90
        public void CombatSetRespawn(){} // RVA: 0x7B18AEF10
        public void CombatSetDamageGraphic(){} // RVA: 0x7B18AEFD0
        public void CombatGetDestructible(){} // RVA: 0x7B18AF060
        public void SetVoiceGain(){} // RVA: 0x7B18AF0E0
        public void GetVoiceGain(){} // RVA: 0x7B18AF170
        public void SetVoiceDistanceNear(){} // RVA: 0x7B18AF1F0
        public void GetVoiceDistanceNear(){} // RVA: 0x7B18AF280
        public void SetVoiceDistanceFar(){} // RVA: 0x7B18AF300
        public void GetVoiceDistanceFar(){} // RVA: 0x7B18AF390
        public void SetVoiceVolumetricRadius(){} // RVA: 0x7B18AF410
        public void GetVoiceVolumetricRadius(){} // RVA: 0x7B18AF4A0
        public void SetVoiceLowpass(){} // RVA: 0x7B18AF520
        public void GetVoiceLowpass(){} // RVA: 0x7B18AF5B0
        public void SetAvatarAudioGain(){} // RVA: 0x7B18AF630
        public void SetAvatarAudioFarRadius(){} // RVA: 0x7B18AF6C0
        public void SetAvatarAudioNearRadius(){} // RVA: 0x7B18AF750
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x7B18AF7E0
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x7B18AF870
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x7B18AF900
        public void GetAvailableLanguages(){} // RVA: 0x7B18AF990
        public void GetCurrentLanguage(){} // RVA: 0x7B18AFA00
        public void GetPlayerObjects(){} // RVA: 0x7B18AFA70
        public void FindComponentInPlayerObjects(){} // RVA: 0x7B18AFB10
        public void PushAnimations(){} // RVA: 0x7B18AFB20
        public void PopAnimations(){} // RVA: 0x7B18AFBB0
        public void Immobilize(){} // RVA: 0x7B18AFC30
        public void SetVelocity(){} // RVA: 0x7B18AFCC0
        public void GetVelocity(){} // RVA: 0x7B18AFD60
        public void GetPosition(){} // RVA: 0x7B18AFE00
        public void GetRotation(){} // RVA: 0x7B18AFEA0
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x7B18AFF40
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x7B18AFFC0
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x7B18B0040
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x7B18B00C0
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x7B18B0140
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x7B18B01D0
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x7B18B0260
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x7B18B02F0
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x7B18B0380
        public void .ctor(){} // RVA: 0x7B18B0410
        public void .cctor(){} // RVA: 0x7B18B04A0
    }

    public class VRCPlayerApi[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRCRenderTexture : Object
    {
        // ── Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0x7B18BEBD0
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0x7B18BED00
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7B18BEE30
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7B18BEF70
        public void GetTemporary(){} // RVA: 0x7B18BF190
        public void ReleaseTemporary(){} // RVA: 0x7B18BF220
    }

    public class VRCShader : Object
    {
        // ── Methods ──
        public void add_OnSetGlobalShaderVariable(){} // RVA: 0x7B18BF2C0
        public void remove_OnSetGlobalShaderVariable(){} // RVA: 0x7B18BF420
        public void PropertyToID(){} // RVA: 0x7B18BF580
        public void SetGlobalInteger(){} // RVA: 0x7B18BF850
        public void SetGlobalFloat(){} // RVA: 0x7B18BF920
        public void SetGlobalTexture(){} // RVA: 0x7B18BF9F0
        public void SetGlobalColor(){} // RVA: 0x7B18BFAC0
        public void SetGlobalVector(){} // RVA: 0x7B18BFBD0
        public void SetGlobalMatrix(){} // RVA: 0x7B18BFCB0
        public void SetGlobalFloatArray(){} // RVA: 0x7B18BFDA0
        public void SetGlobalVectorArray(){} // RVA: 0x7B18BFE40
        public void SetGlobalMatrixArray(){} // RVA: 0x7B18BFEE0
        public void ValidateAgainstPropertyIDWhitelist(){} // RVA: 0x7B18BFF80
        public void ClearGlobalVariableWhitelist(){} // RVA: 0x7B18C0090
        public void .cctor(){} // RVA: 0x7B18C0150
    }

    public class VRCStation : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18C05B0
        public void UseStation(){} // RVA: 0x7B18C0610
        public void ExitStation(){} // RVA: 0x7B18C0680
        public void .ctor(){} // RVA: 0x7B1832050
    }

    public class VRCStation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRCTriggerRelay : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18D80B0
        public void OnTriggerEnter(){} // RVA: 0x7B18D8110
        public void OnTriggerExit(){} // RVA: 0x7B18D81A0
        public void .ctor(){} // RVA: 0x7B18D8220
    }

    public class VRCUrl : Object
    {
        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7B18D83E0
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x7B18D8440
        public void IsNullOrEmpty(){} // RVA: 0x7B18D86D0
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x7B18D8770
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x7B18D87D0
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x7B18D8890
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x7B18D88F0
        public void IsAllowlistedUri(){} // RVA: 0x7B18D89B0
        public void .ctor(){} // RVA: 0x7B18D8C10
        public void Get(){} // RVA: 0x7A80F2570
        public void ToString(){} // RVA: 0x7A80F2570
        public void Equals(){} // RVA: 0x7B18D8DF0
        public void GetHashCode(){} // RVA: 0x7AE290990
        public void .cctor(){} // RVA: 0x7B18D8E40
    }

    public class VRCUrl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B25C0
        public void OnStateEnter(){} // RVA: 0x7AD4F2C50
        public void .ctor(){} // RVA: 0x7B185EE90
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B2620
        public void OnStateEnter(){} // RVA: 0x7AE4DE7F0
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class VRC_AnimatorPlayAudio : StateMachineBehaviour
    {
        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x7B18B2680
        public void get_ShouldApplyPitch(){} // RVA: 0x7B18B2690
        public void get_ShouldApplyClip(){} // RVA: 0x7B18B26A0
        public void get_ShouldApplyLoop(){} // RVA: 0x7B18B26B0
        public void ShouldApplySetting(){} // RVA: 0x7B18B26C0
        public void Awake(){} // RVA: 0x7B18B2740
        public void OnStateEnter(){} // RVA: 0x7B18B27A0
        public void OnStateExit(){} // RVA: 0x7B18B27C0
        public void .ctor(){} // RVA: 0x7B185EEA0
    }

    public class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B27F0
        public void OnStateEnter(){} // RVA: 0x7B18B2850
        public void OnStateUpdate(){} // RVA: 0x7B18B28E0
        public void .ctor(){} // RVA: 0x7B185EEF0
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B2980
        public void OnStateEnter(){} // RVA: 0x7AEA3B400
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7B18B29E0
        public void PositionPortraitCamera(){} // RVA: 0x7B18B2D20
        public void get_NetworkIDCollection(){} // RVA: 0x7A8142610
        public void set_NetworkIDCollection(){} // RVA: 0x7A8142620
        public void GetNetworkIDObjects(){} // RVA: 0x7B18B31B0
        public void FindNetworkIDGameObject(){} // RVA: 0x7B18B3250
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7B18B3570
        public void .ctor(){} // RVA: 0x7B18B35F0
    }

    public class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7B18B38D0
        public void .ctor(){} // RVA: 0x7B18636A0
    }

    public class VRC_AvatarParameterDriver[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B8930
        public void SwitchAvatar(){} // RVA: 0x7B187A5A0
        public void SetAvatarUse(){} // RVA: 0x7B18B8E40
        public void .ctor(){} // RVA: 0x7B18B8F80
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0x7B18D9290
        public void GetElement(){} // RVA: 0x7B18D9300
        public void add_ElementChanged(){} // RVA: 0x7B18D9390
        public void remove_ElementChanged(){} // RVA: 0x7B18D9480
        public void OnDataElementChanged(){} // RVA: 0x7B18D9570
        public void Awake(){} // RVA: 0x7B18D95A0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_DestructibleStandard : MonoBehaviour
    {
        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0x7A81002C0
        public void GetCurrentHealth(){} // RVA: 0x7A82461C0
        public void Awake(){} // RVA: 0x7B18B4FF0
        public void ApplyDamage(){} // RVA: 0x7B18B51D0
        public void ApplyHealing(){} // RVA: 0x7B18B5760
        public void GetState(){} // RVA: 0x7B18B5D40
        public void SetState(){} // RVA: 0x7B18B5E10
        public void HandleCallbackTrigger(){} // RVA: 0x7B18B5E90
        public void .ctor(){} // RVA: 0x7B18266F0
        public void <ApplyDamage>b__27_0(){} // RVA: 0x7B18B4260
        public void <ApplyDamage>b__27_1(){} // RVA: 0x7B18B5FD0
        public void <ApplyHealing>b__28_0(){} // RVA: 0x7B18B5FD0
        public void <ApplyHealing>b__28_1(){} // RVA: 0x7B18B6030
    }

    public class VRC_EventDispatcher : MonoBehaviour
    {
        // ── Methods ──
        public void TriggerEvent(){} // RVA: 0x7A7E22390
        public void RegisterEventHandler(){} // RVA: 0x7A7E18800
        public void UnregisterEventHandler(){} // RVA: 0x7A7E18800
        public void FindGameObject(){} // RVA: 0x7A7E01780
        public void GetGameObjectPath(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcher
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18B6D60
        public void TriggerEvent(){} // RVA: 0x7A80D7310
        public void RegisterEventHandler(){} // RVA: 0x7A80D7310
        public void UnregisterEventHandler(){} // RVA: 0x7A80D7310
        public void FindGameObject(){} // RVA: 0x7B18B6DB0
        public void GetGameObjectPath(){} // RVA: 0x7B18B6E00
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_EventHandler : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void BooleanOp(){} // RVA: 0x7B18D9690
        public void get_Dispatcher(){} // RVA: 0x7B18D96B0
        public void get_GetInsitgatorId(){} // RVA: 0x7B18D97D0
        public void set_GetInsitgatorId(){} // RVA: 0x7B18D9810
        public void Awake(){} // RVA: 0x7B18D98B0
        public void VrcAnimationEvent(){} // RVA: 0x7B18D9C70
        public void IsReceiverRequiredForEventType(){} // RVA: 0x7B18D9E60
        public void TriggerEvent(){} // RVA: 0x7B18DAEC0
        public void InternalTriggerEvent(){} // RVA: 0x7B18DA920
        public void OnValidate(){} // RVA: 0x7B18DB0C0
        public void OnDestroy(){} // RVA: 0x7B18DB230
        public void GetCombinedNetworkId(){} // RVA: 0x7A82D1450
        public void HasEventTrigger(){} // RVA: 0x7B18DB3A0
        public void IsReadyForEvents(){} // RVA: 0x7A81BD750
        public void DeferEvent(){} // RVA: 0x7B18DB4A0
        public void ProcessDeferredEvents(){} // RVA: 0x7B18DB790
        public void .ctor(){} // RVA: 0x7B18DB830
    }

    public class VRC_EventHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_GunStats : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1826D60
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18DC280
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0x7A80D7320
        public void get_Proximity(){} // RVA: 0x7A8891F60
        public void Start(){} // RVA: 0x7A80D7310
        public void Awake(){} // RVA: 0x7B18DC5F0
        public void Interact(){} // RVA: 0x7A7E18770
        public void OnPickupUseUp(){} // RVA: 0x7A80D7310
        public void OnPickupUseDown(){} // RVA: 0x7A80D7310
        public void OnPickup(){} // RVA: 0x7A80D7310
        public void OnDrop(){} // RVA: 0x7A80D7310
        public void IsInteractiveForPlayer(){} // RVA: 0x7B18DC650
        public void .ctor(){} // RVA: 0x7B18DC6F0
    }

    public class VRC_Interactable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_KeyEvents : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18B3950
        public void Update(){} // RVA: 0x7B18B3BB0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void <Update>b__9_0(){} // RVA: 0x7B18B4200
        public void <Update>b__9_2(){} // RVA: 0x7B18B4200
        public void <Update>b__9_1(){} // RVA: 0x7B18B4260
        public void <Update>b__9_3(){} // RVA: 0x7B18B4260
    }

    public class VRC_Label : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1834AF0
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0x7B18C06F0
        public void Awake(){} // RVA: 0x7B18C0750
        public void OnDestroy(){} // RVA: 0x7B18C08C0
        public void TriggerUpdate(){} // RVA: 0x7B18C0A30
        public void MetadataChangedInternal(){} // RVA: 0x7B18C0A90
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_MidiNoteIn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B8530
        public void Start(){} // RVA: 0x7A80D7310
        public void Update(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_MidiNoteIn[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_MirrorReflection : MonoBehaviour
    {
        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x7B18C0AB0
        public void remove_PreRenderMirror(){} // RVA: 0x7B18C0C00
        public void add_PostRenderMirror(){} // RVA: 0x7B18C0D50
        public void remove_PostRenderMirror(){} // RVA: 0x7B18C0EA0
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x7B18C0FF0
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x7B18C1050
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x7B18C1110
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x7B18C1180
        public void OnValidate(){} // RVA: 0x7B18C11F0
        public void Start(){} // RVA: 0x7B18C1250
        public void TrySetupMaterial(){} // RVA: 0x7B18C1510
        public void IsVisibleToCamera(){} // RVA: 0x7B18C1A60
        public void IsLayerRendered(){} // RVA: 0x7B18C1C60
        public void CameraOnPreCull(){} // RVA: 0x7B18C1CE0
        public void RenderMirrorCameras(){} // RVA: 0x7B18C2170
        public void CameraPostRender(){} // RVA: 0x7B18C3410
        public void OnEnable(){} // RVA: 0x7B18C3710
        public void OnDisable(){} // RVA: 0x7B18C39C0
        public void OnDestroy(){} // RVA: 0x7B18C40E0
        public void ShouldRenderLeftEye(){} // RVA: 0x7B18C4430
        public void ShouldRenderRightEye(){} // RVA: 0x7B18C4610
        public void ShouldRenderMonoscopic(){} // RVA: 0x7B18C47F0
        public void GetWorldEyePos(){} // RVA: 0x7B18C4A50
        public void GetWorldEyeRot(){} // RVA: 0x7B18C4B80
        public void GetEyeProjectionMatrix(){} // RVA: 0x7B18C4D70
        public void GetNormalDirection(){} // RVA: 0x7B18C4E30
        public void RenderMirror(){} // RVA: 0x7B18C4EE0
        public void UpdateCameraClearing(){} // RVA: 0x7B18C5C00
        public void UpdateCameraModes(){} // RVA: 0x7B18C5FE0
        public void UpdateParentTransform(){} // RVA: 0x7B18C6970
        public void GetReflectionData(){} // RVA: 0x7B18C72E0
        public void GetAutoResolution(){} // RVA: 0x7B18C7DD0
        public void Plane(){} // RVA: 0x7B18C7FC0
        public void CameraSpacePlane(){} // RVA: 0x7B18C8020
        public void CalculateReflectionMatrix(){} // RVA: 0x7B18C8410
        public void CopySign(){} // RVA: 0x7B18C8580
        public void GetRotation(){} // RVA: 0x7B18C85B0
        public void GetPosition(){} // RVA: 0x7AE28A9E0
        public void .ctor(){} // RVA: 0x7B18C87F0
        public void .cctor(){} // RVA: 0x7B18C8900
    }

    public class VRC_NPCSpawn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B9040
        public void .ctor(){} // RVA: 0x7B18278A0
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18B42C0
        public void GetApiByGameObject(){} // RVA: 0x7B18B4320
        public void ActThis(){} // RVA: 0x7B18B4430
        public void SayThis(){} // RVA: 0x7B18B44C0
        public void SetNamePlate(){} // RVA: 0x7B18B4550
        public void SetSocialStatus(){} // RVA: 0x7B18B45F0
        public void SetMuteStatus(){} // RVA: 0x7B18B4690
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_ObjectApi : MonoBehaviour
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_ObjectSpawn : MonoBehaviour
    {
        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x7B18B9300
        public void DestroySpawnedObjects(){} // RVA: 0x7A9C2F8D0
        public void Start(){} // RVA: 0x7B18B9420
        public void ProvideEvents(){} // RVA: 0x7B18B9480
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B8590
        public void Start(){} // RVA: 0x7A80D7310
        public void Update(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_OscButtonIn[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_Panorama : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18C8B10
        public void Update(){} // RVA: 0x7B18C8D00
        public void NextPano(){} // RVA: 0x7B18C8FD0
        public void PrevPano(){} // RVA: 0x7B18C9090
        public void ShowPanoAt(){} // RVA: 0x7B18C9150
        public void ShowPano(){} // RVA: 0x7B18C91E0
        public void .ctor(){} // RVA: 0x7B1834BC0
    }

    public class VRC_PhysicsRoot : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18B4720
        public void OnDestroy(){} // RVA: 0x7B18B4DA0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7B18B9AC0
        public void get_currentPlayer(){} // RVA: 0x7B18B9AF0
        public void get_IsHeld(){} // RVA: 0x7B18B9B60
        public void get_currentHand(){} // RVA: 0x7B18B9C20
        public void get_Proximity(){} // RVA: 0x7B18B9C80
        public void Awake(){} // RVA: 0x7B18B9C90
        public void OnDisable(){} // RVA: 0x7B18B9CF0
        public void Reset(){} // RVA: 0x7B18B9D30
        public void Drop(){} // RVA: 0x7B18B9EC0
        public void GenerateHapticEvent(){} // RVA: 0x7B18BA120
        public void OnDestroy(){} // RVA: 0x7B18BA1C0
        public void PlayHaptics(){} // RVA: 0x7B18BA220
        public void ProvideEvents(){} // RVA: 0x7B18BA250
        public void .ctor(){} // RVA: 0x7B18BA6B0
    }

    public class VRC_Pickup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B4ED0
        public void OnStateEnter(){} // RVA: 0x7B18B4F30
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x7A828A180
        public void Awake(){} // RVA: 0x7B18BAA50
        public void Update(){} // RVA: 0x7B18BAAD0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_PropApi : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_PropController : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18BAB50
        public void Update(){} // RVA: 0x7B18BABB0
        public void GetInputIndex(){} // RVA: 0x7B18BAC20
        public void .ctor(){} // RVA: 0x7B1828FF0
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18BAD40
        public void get_NetworkIDCollection(){} // RVA: 0x7A8154D80
        public void set_NetworkIDCollection(){} // RVA: 0x7A80FF440
        public void get_NetworkIDLookup(){} // RVA: 0x7A8152D80
        public void set_NetworkIDLookup(){} // RVA: 0x7A8152D90
        public void GetNetworkIDObjects(){} // RVA: 0x7B18BB790
        public void FindNetworkIDGameObject(){} // RVA: 0x7B18BB830
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7B18B3570
        public void .ctor(){} // RVA: 0x7B18BBB50
    }

    public class VRC_SceneDescriptor : MonoBehaviour
    {
        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0x7B18C9A40
        public void GetPrefab(){} // RVA: 0x7B18C9C30
        public void GetMaterial(){} // RVA: 0x7B18CA030
        public void get_NetworkIDCollection(){} // RVA: 0x7A8B5ED30
        public void set_NetworkIDCollection(){} // RVA: 0x7A8B5E380
        public void get_NetworkIDLookup(){} // RVA: 0x7A8688280
        public void set_NetworkIDLookup(){} // RVA: 0x7A8B797E0
        public void GetNetworkIDObjects(){} // RVA: 0x7B18CA430
        public void FindNetworkIDGameObject(){} // RVA: 0x7B18CA730
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7B18B3570
        public void get_Instance(){} // RVA: 0x7B18CACB0
        public void get_Exists(){} // RVA: 0x7B18CAFC0
        public void get_BundleUnityMajorVersion(){} // RVA: 0x7B18CB0C0
        public void set_BundleUnityMajorVersion(){} // RVA: 0x7B18CB0D0
        public void get_Scene(){} // RVA: 0x7A9A9D020
        public void set_Scene(){} // RVA: 0x7A9A9D030
        public void Awake(){} // RVA: 0x7B18CB0E0
        public void OnDestroy(){} // RVA: 0x7B18CC0D0
        public void PositionPortraitCamera(){} // RVA: 0x7B18CC190
        public void .ctor(){} // RVA: 0x7B18CC560
        public void .cctor(){} // RVA: 0x7B18CC890
    }

    public class VRC_SceneDescriptor[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_Serialization : Object
    {
        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x7B18DC7B0
        public void set_AllowPluginTypes(){} // RVA: 0x7B18DC810
        public void get_SurrogateSelector(){} // RVA: 0x7B18DC870
        public void RegisterPluginType(){} // RVA: 0x7B18DC980
        public void RegisterType(){} // RVA: 0x7B18DCA70
        public void ParameterEncoder(){} // RVA: 0x7B18DCB60
        public void ParameterDecoder(){} // RVA: 0x7B18DCD70
        public void get_Dispatcher(){} // RVA: 0x7B18DCFE0
        public void GetGameObjectPathFallback(){} // RVA: 0x7B18DD120
        public void GetGameObjectPath(){} // RVA: 0x7B18DD390
        public void FindGameObject(){} // RVA: 0x7B18DD4D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B18DD630
    }

    public class VRC_SlideShow : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18BBD70
        public void ShowNextImage(){} // RVA: 0x7B18BBE30
        public void ShowPreviousImage(){} // RVA: 0x7B18BC050
        public void StartAutoplayWithDuration(){} // RVA: 0x7B18BC220
        public void StopAutoplayWithDuration(){} // RVA: 0x7B18BC2E0
        public void .ctor(){} // RVA: 0x7B18290F0
    }

    public class VRC_SpatialAudioSource : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18AC050
        public void OnDrawGizmosSelected(){} // RVA: 0x7B18AC2F0
        public void .ctor(){} // RVA: 0x7B1825690
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7B18CCB70
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_SpecialLayer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_StereoObject : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_StereoObject[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRC_TimedEvents : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18CCDA0
        public void OnEnable(){} // RVA: 0x7B18CCF70
        public void Update(){} // RVA: 0x7B18CCF80
        public void ResetClock(){} // RVA: 0x7B18CD110
        public void .ctor(){} // RVA: 0x7B1832110
    }

    public class VRC_Trigger : VRC_Interactable
    {
        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0x7B18CD420
        public void Trigger(){} // RVA: 0x7B18CD290
        public void get_HasKeyTriggers(){} // RVA: 0x7B18CD5B0
        public void get_HasTimerTriggers(){} // RVA: 0x7B18CD720
        public void get_HasColliderTriggers(){} // RVA: 0x7B18CD890
        public void get_HasInteractiveTriggers(){} // RVA: 0x7B18CDB30
        public void get_HasPickupTriggers(){} // RVA: 0x7B18CDCA0
        public void get_IsInteractive(){} // RVA: 0x7B18CDE10
        public void Awake(){} // RVA: 0x7B18CE100
        public void OnDestroy(){} // RVA: 0x7B18CE1B0
        public void OnEnable(){} // RVA: 0x7B18CE1C0
        public void OnDisable(){} // RVA: 0x7B18CE1F0
        public void OnDrawGizmosSelected(){} // RVA: 0x7B18CE220
        public void Interact(){} // RVA: 0x7B18CE7D0
        public void OnPickupUseUp(){} // RVA: 0x7B18CE7E0
        public void OnPickupUseDown(){} // RVA: 0x7B18CE7F0
        public void OnPickup(){} // RVA: 0x7B18CE800
        public void OnDrop(){} // RVA: 0x7B18CE810
        public void ExecuteTriggers(){} // RVA: 0x7B18CE820
        public void ExecuteTriggerType(){} // RVA: 0x7B18CEB20
        public void ExecuteCustomTrigger(){} // RVA: 0x7B18CEE80
        public void ResetClocks(){} // RVA: 0x7B18CF290
        public void ResetClock(){} // RVA: 0x7B18CF620
        public void .ctor(){} // RVA: 0x7B1832170
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x7B18CF6B0
    }

    public class VRC_TriggerColliderEventTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B18D0660
        public void OnTriggerEnter(){} // RVA: 0x7B18D0820
        public void OnTriggerExit(){} // RVA: 0x7B18D0960
        public void .ctor(){} // RVA: 0x7B1832240
    }

    public class VRC_TutorialAction : MonoBehaviour
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7B18D5F70
        public void ActivateObjectLabel(){} // RVA: 0x7B18D6170
        public void DeactivateObjectLabel(){} // RVA: 0x7B18D6200
        public void ActivateControllerLabel(){} // RVA: 0x7B18D6260
        public void DeactivateControllerLabel(){} // RVA: 0x7B18D6290
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRC_TutorialAreaMarker : MonoBehaviour
    {
        // ── Methods ──
        public void Enable(){} // RVA: 0x7AD8AFA40
        public void Update(){} // RVA: 0x7B18D62A0
        public void ShowLabel(){} // RVA: 0x7B18D66B0
        public void .ctor(){} // RVA: 0x7B1832600
    }

    public class VRC_UiShape : MonoBehaviour
    {
        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0x7A81052C0
        public void set_RootCanvas(){} // RVA: 0x7A81052D0
        public void get_RootCanvasRectTransform(){} // RVA: 0x7A8105330
        public void set_RootCanvasRectTransform(){} // RVA: 0x7A80D8E80
        public void add_OnUiShapeInit(){} // RVA: 0x7B18D7220
        public void remove_OnUiShapeInit(){} // RVA: 0x7B18D7360
        public void add_OnUiShapeDestroy(){} // RVA: 0x7B18D74A0
        public void remove_OnUiShapeDestroy(){} // RVA: 0x7B18D75E0
        public void Awake(){} // RVA: 0x7B18D7720
        public void Start(){} // RVA: 0x7B18D78C0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7B18D7C20
        public void SetupCollision(){} // RVA: 0x7B18D7C30
        public void OnDestroy(){} // RVA: 0x7B18D8050
        public void .ctor(){} // RVA: 0x7A818C250
    }

    public class VRC_UseEvents : VRC_Interactable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18D0AA0
        public void Start(){} // RVA: 0x7B18D0CE0
        public void Interact(){} // RVA: 0x7B18D0F70
        public void .ctor(){} // RVA: 0x7B1832290
        public void <Awake>b__5_0(){} // RVA: 0x7B18D1150
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7B18B6090
        public void Start(){} // RVA: 0x7B18B6120
        public void OnSceneWasLoaded(){} // RVA: 0x7B18B6350
        public void Update(){} // RVA: 0x7B18B63F0
        public void HideDamageIndicator(){} // RVA: 0x7B18B6620
        public void ShowDamageIndicator(){} // RVA: 0x7B18B6740
        public void SetDamagePercent(){} // RVA: 0x7B18B6860
        public void .ctor(){} // RVA: 0x7B18B6B60
    }

    public class VRC_Water : MonoBehaviour
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7B18D1260
        public void OnDisable(){} // RVA: 0x7B18D1F40
        public void Update(){} // RVA: 0x7B18D25C0
        public void UpdateCameraModes(){} // RVA: 0x7B18D2A90
        public void CreateWaterObjects(){} // RVA: 0x7B18D3010
        public void GetWaterMode(){} // RVA: 0x7B18D43B0
        public void FindHardwareWaterSupport(){} // RVA: 0x7B18D43C0
        public void CameraSpacePlane(){} // RVA: 0x7A80EEED0
        public void CalculateReflectionMatrix(){} // RVA: 0x7A80EF2C0
        public void .ctor(){} // RVA: 0x7B1832330
    }

    public class VRC_WebPanel : VRC_Interactable
    {
        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0x7B18D46B0
        public void WebPanelBackward(){} // RVA: 0x7B18D46E0
        public void WebPanelReload(){} // RVA: 0x7B18D4710
        public void BindCall(){} // RVA: 0x7B18D4740
        public void NavigateTo(){} // RVA: 0x7B18D4770
        public void Awake(){} // RVA: 0x7B18D47A0
        public void Interact(){} // RVA: 0x7A80D7310
        public void get_WebRootPath(){} // RVA: 0x7B18D48B0
        public void ProvideEvents(){} // RVA: 0x7B18D4A20
        public void ReadData(){} // RVA: 0x7B18D5360
        public void ImportWebData(){} // RVA: 0x7B18D55D0
        public void .ctor(){} // RVA: 0x7B18324D0
    }

    public class VersionHelper : Object
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0x7A8051B10
    }

}