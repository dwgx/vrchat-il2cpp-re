// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase
// Classes: 78
// Methods: 659

namespace VRC.SDKBase
{
    public class IAnimParameterAccess
    {
        public object boolVal;
        public object intVal;
        public object floatVal;

        // ── Methods ──
        public void get_boolVal(){} // RVA: 0x7FFAC2C59D00
        public void set_boolVal(){} // RVA: 0x7FFAC2C71060
        public void get_intVal(){} // RVA: 0x7FFAC2C59960
        public void set_intVal(){} // RVA: 0x7FFAC2C70ED0
        public void get_floatVal(){} // RVA: 0x7FFAC2C6D880
        public void set_floatVal(){} // RVA: 0x7FFAC2C7E480
    }

    public class IEditorOnly
    {
    }

    public class INetworkID
    {
    }

    public class INetworkIDContainer
    {
        public object NetworkIDCollection;

        // ── Methods ──
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAC2C58E90
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAC2C70A40
        public void GetNetworkIDObjects(){} // RVA: 0x7FFAC2C70A40
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFAC2C696F0
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IPreprocessCallbackBehaviour
    {
        public object PreprocessOrder;

        // ── Methods ──
        public void OnPreprocess(){} // RVA: 0x7FFAC2C59D00
        public void get_PreprocessOrder(){} // RVA: 0x7FFAC2C59960
    }

    public class IVRCEventProvider
    {
        // ── Methods ──
        public void ProvideEvents(){} // RVA: 0x7FFAC2C58E90
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
        public void GetState(){} // RVA: 0x7FFAC2C58E90
        public void SetState(){} // RVA: 0x7FFAC2C70A40
        public void GetMaxHealth(){} // RVA: 0x7FFAC2C6D880
        public void GetCurrentHealth(){} // RVA: 0x7FFAC2C6D880
        public void ApplyDamage(){} // RVA: 0x7FFAC2C7E480
        public void ApplyHealing(){} // RVA: 0x7FFAC2C7E480
    }

    public class IValidChecker
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC2C59D00
    }

    public class InputManager : Object
    {
        public System.Func`1<bool> _IsUsingHandController;
        public System.Func`1<0x6B251C18> _GetLastUsedInputMethod; // 0x8
        public System.Func`2<0x6B251BC0,bool> _GetInputSetting; // 0x10
        public System.Action`2<0x6B251BC0,bool> _SetInputSetting; // 0x18
        public System.Action`2<UnityEngine.Renderer,bool> _EnableObjectHighlight; // 0x20

        // ── Methods ──
        public void IsUsingHandController(){} // RVA: 0x7FFACC077B00
        public void GetLastUsedInputMethod(){} // RVA: 0x7FFACC077B60
        public void GetBoolInputSetting(){} // RVA: 0x7FFACC077BD0
        public void SetBoolInputSetting(){} // RVA: 0x7FFACC077C30
        public void EnableObjectHighlight(){} // RVA: 0x7FFACC077DA0 | overloaded x2
    }

    public class MathUtil : Object
    {
        public float PI;
        public float TWO_PI; // 0x4
        public float HALF_PI; // 0x8
        public float QUARTER_PI; // 0xC

        // ── Methods ──
        public void AngleBetweenTwoUnitVectors(){} // RVA: 0x7FFACC054370
        public void AngleClosestBetweenTwoUnitVectors(){} // RVA: 0x7FFACBA2B2D0
        public void ClosestPointOnLineSegment_Value(){} // RVA: 0x7FFACC054550
        public void ClosestPointOnLineSegment(){} // RVA: 0x7FFACC054620
        public void ClosestPointOnPlane(){} // RVA: 0x7FFACBA2B470
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACC054740
    }

    public class Networking : Object
    {
        public System.Func`2<UnityEngine.GameObject,float> SceneEventHandler;
        public System.Func`2<UnityEngine.GameObject,string> IsNetworkSettled; // 0x8
        public System.Action`4<0x6B24ED58,UnityEngine.GameObject,string,object[]> IsMaster; // 0x10
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject,string,object[]> IsClogged; // 0x18
        public System.Func`1<bool> IsInstanceOwner; // 0x20
        public System.Func`1<bool> LocalPlayer; // 0x28
        public System.Func`1<bool> Master; // 0x30
        public System.Func`1<bool> InstanceOwner; // 0x38
        public System.Func`1<VRC.SDKBase.VRCPlayerApi> _LocalPlayer; // 0x40
        public System.Func`1<VRC.SDKBase.VRCPlayerApi> _GetMaster; // 0x48
        public System.Func`1<VRC.SDKBase.VRCPlayerApi> _GetInstanceOwner; // 0x50
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject,bool> _IsOwner; // 0x58
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject> _SetOwner; // 0x60
        public System.Func`2<UnityEngine.GameObject,bool> _IsObjectReady; // 0x68
        public System.Func`5<0x6B2517F8,string,UnityEngine.Vector3,UnityEngine.Quaternion,UnityEngine.GameObject> _Instantiate; // 0x70
        public System.Func`2<UnityEngine.GameObject,VRC.SDKBase.VRCPlayerApi> _GetOwner; // 0x78
        public System.Func`2<object[],byte[]> _ParameterEncoder; // 0x80
        public System.Func`2<byte[],object[]> _ParameterDecoder; // 0x88
        public System.Action`1<UnityEngine.GameObject> _Destroy; // 0x90
        public System.Func`1<VRC.SDKBase.VRC_EventHandler> _SceneEventHandler; // 0x98
        public System.Func`2<string,bool> _GoToRoom; // 0xA0
        public System.Func`1<System.DateTime> _GetNetworkDateTime; // 0xA8
        public System.Func`1<double> _GetServerTimeInSeconds; // 0xB0
        public System.Func`1<int> _GetServerTimeInMilliseconds; // 0xB8
        public System.Func`3<double,double,double> _CalculateServerDeltaTime; // 0xC0
        public System.Func`2<System.Collections.IEnumerator,UnityEngine.Coroutine> _SafeStartCoroutine; // 0xC8
        public System.Func`1<VRC.SDKBase.VRC_EventDispatcher> _GetEventDispatcher; // 0xD0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject[]> _GetPlayerPersistence; // 0xD8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _GetPlayerDataStorageUsage; // 0xE0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _GetPlayerObjectStorageUsage; // 0xE8
        public System.Func`1<int> _GetPlayerDataStorageLimit; // 0xF0
        public System.Func`1<int> _GetPlayerObjectStorageLimit; // 0xF8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,UnityEngine.Component,UnityEngine.Component> _FindComponentInPlayerObjects; // 0x100
        public System.Action _RequestStorageUsageUpdate; // 0x108

        // ── Methods ──
        public void get_SceneEventHandler(){} // RVA: 0x7FFACC053220
        public void get_IsNetworkSettled(){} // RVA: 0x7FFACC053280
        public void get_IsMaster(){} // RVA: 0x7FFACC0532E0
        public void get_IsClogged(){} // RVA: 0x7FFACC053340
        public void get_IsInstanceOwner(){} // RVA: 0x7FFACC0533A0
        public void get_LocalPlayer(){} // RVA: 0x7FFACC053400
        public void get_Master(){} // RVA: 0x7FFACC053460
        public void get_InstanceOwner(){} // RVA: 0x7FFACC0534C0
        public void IsOwner(){} // RVA: 0x7FFACC0535A0 | overloaded x2
        public void GetOwner(){} // RVA: 0x7FFACC053660
        public void SetOwner(){} // RVA: 0x7FFACC0536D0
        public void IsObjectReady(){} // RVA: 0x7FFACC053740
        public void Instantiate(){} // RVA: 0x7FFACC0537B0
        public void RPC(){} // RVA: 0x7FFACC053900 | overloaded x2
        public void EncodeParameters(){} // RVA: 0x7FFACC0539A0
        public void DecodeParameters(){} // RVA: 0x7FFACC053A10
        public void Destroy(){} // RVA: 0x7FFACC053A80
        public void GetUniqueName(){} // RVA: 0x7FFACC053AF0
        public void GoToRoom(){} // RVA: 0x7FFACC053B60
        public void GetNetworkDateTime(){} // RVA: 0x7FFACC053BD0
        public void GetServerTimeInSeconds(){} // RVA: 0x7FFACC053C70
        public void GetServerTimeInMilliseconds(){} // RVA: 0x7FFACC053D20
        public void CalculateServerDeltaTime(){} // RVA: 0x7FFACC053DD0
        public void SafeStartCoroutine(){} // RVA: 0x7FFACC053E60
        public void GetEventDispatcher(){} // RVA: 0x7FFACC053ED0
        public void SimulationTime(){} // RVA: 0x7FFACC053FE0 | overloaded x2
        public void RequestStorageUsageUpdate(){} // RVA: 0x7FFACA156E60
        public void GetPlayerObjects(){} // RVA: 0x7FFACC04B7E0
        public void GetPlayerDataStorageLimit(){} // RVA: 0x7FFACC054090
        public void GetPlayerObjectStorageLimit(){} // RVA: 0x7FFACC0540F0
        public void GetPlayerDataStorageUsage(){} // RVA: 0x7FFACC054150
        public void GetPlayerObjectStorageUsage(){} // RVA: 0x7FFACC0541C0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFACC054230
    }

    public class RPC : Attribute
    {
        public 0x6B24ED58[] allowedTargets; // 0x10
        public short shortCode; // 0x18
        public float playerRateLimit; // 0x1C
        public float globalRateLimit; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC052E40 | overloaded x4
        public void SetupTargets(){} // RVA: 0x7FFACC052E60
    }

    public class RPCIgnoredType : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Tutorial : Object
    {
        public ActivateObjectLabelDelegate _ActivateObjectLabel;
        public DeactivateObjectLabelDelegate _DeactivateObjectLabel; // 0x8
        public ActivateControllerLabelDelegate _ActivateControllerLabel; // 0x10
        public DeactivateControllerLabelDelegate _DeactivateControllerLabel; // 0x18

        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFACC072030
        public void ActivateObjectLabel(){} // RVA: 0x7FFACC072240 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFACC072330
        public void ActivateControllerLabel(){} // RVA: 0x7FFACC072390
        public void DeactivateControllerLabel(){} // RVA: 0x7FFACC072430
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Utilities : Object
    {
        public bool _isClient;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACC07FC50
        public void ShuffleArray(){} // RVA: 0x7FFACC07FDB0 | overloaded x2
        public void IsClient(){} // RVA: 0x7FFACC07FEB0
        public void SetIsClient(){} // RVA: 0x7FFACC07FEF0
        public void Fletcher32Fast(){} // RVA: 0x7FFACC07FF30
    }

    public class VRCBuiltInShaderGlobals : MonoBehaviour
    {
        public int Instance;
        public int GetPreferredTimezoneDelegate; // 0x4
        public int _vrcTimeEncoded1ID; // 0x8
        public int _vrcTimeEncoded2ID; // 0xC
        public VRC.SDKBase.VRCBuiltInShaderGlobals <Instance>k__BackingField; // 0x10
        public System.Func`1<System.TimeZoneInfo> <GetPreferredTimezoneDelegate>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFACC0582E0
        public void set_Instance(){} // RVA: 0x7FFACC058340
        public void get_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFAC2F4F0C0
        public void set_GetPreferredTimezoneDelegate(){} // RVA: 0x7FFAC2F4F0D0
        public void Update(){} // RVA: 0x7FFACC058400
        public void OnDestroy(){} // RVA: 0x7FFACC058AA0
        public void Initialize(){} // RVA: 0x7FFACC058D90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void .cctor(){} // RVA: 0x7FFACC0591D0
    }

    public class VRCCustomAction : MonoBehaviour
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFACC05C310 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRCDroneApi : Object
    {
        public GetDroneFromGameObjectDelegate _GetDroneFromGameObject;

        // ── Methods ──
        public void TryGetDroneFromGameObject(){} // RVA: 0x7FFACC052A00
        public void GetPlayer(){} // RVA: 0x7FFAC2C58E90
        public void IsDeployed(){} // RVA: 0x7FFAC2C59D00
        public void TryGetPosition(){} // RVA: 0x7FFAC2C59F60
        public void GetPosition(){} // RVA: 0x7FFAC2C588A0
        public void TryGetRotation(){} // RVA: 0x7FFAC2C59F60
        public void GetRotation(){} // RVA: 0x7FFAC2C588A0
        public void TryGetVelocity(){} // RVA: 0x7FFAC2C59F60
        public void GetVelocity(){} // RVA: 0x7FFAC2C588A0
        public void TeleportTo(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void SetVelocity(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VRCGraphics : Object
    {
        public System.Lazy`1<UnityEngine.LayerMask> UiLayerMask;

        // ── Methods ──
        public void get_UiLayerMask(){} // RVA: 0x7FFACC059610
        public void Blit(){} // RVA: 0x7FFACC059BE0 | overloaded x7
        public void DrawMeshInstanced(){} // RVA: 0x7FFACC05A570 | overloaded x9
        public void GetLayerMask(){} // RVA: 0x7FFACC05A6D0
        public void CheckBlitTarget(){} // RVA: 0x7FFACC05A6E0
        public void .cctor(){} // RVA: 0x7FFACC05A7F0
    }

    public class VRCPlayerApi : Object
    {
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> isMaster;
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> isInstanceOwner; // 0x8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> isModerator; // 0x10
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> isSuper; // 0x18
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> isSuspended; // 0x20
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> isVRCPlus; // 0x28
        public bool AllPlayers; // 0x10
        public string playerId; // 0x18
        public SetAnimatorBoolDelegate SetAnimatorBool; // 0x30
        public ClaimNetworkControlDelegate ClaimNetworkControl; // 0x38
        public GetLookRayDelegate GetLookRay; // 0x40
        public BoolDelegate IsGrounded; // 0x48
        public GetDroneDelegate _GetDroneApi; // 0x50
        public System.Collections.Generic.List`1<VRC.SDKBase.VRCPlayerApi> sPlayers; // 0x58
        public int mPlayerId; // 0x20
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _GetPlayerId; // 0x60
        public System.Func`2<UnityEngine.GameObject,VRC.SDKBase.VRCPlayerApi> _GetPlayerByGameObject; // 0x68
        public System.Func`2<int,VRC.SDKBase.VRCPlayerApi> _GetPlayerById; // 0x70
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject,bool> _IsOwner; // 0x78
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject> _TakeOwnership; // 0x80
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,0x6B24DA70,TrackingData> _GetTrackingData; // 0x88
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,0x6B29CC78,UnityEngine.Transform> _GetBoneTransform; // 0x90
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,0x6B29CC78,UnityEngine.Vector3> _GetBonePosition; // 0x98
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,0x6B29CC78,UnityEngine.Quaternion> _GetBoneRotation; // 0xA0
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,0x6B24F598,VRC.SDKBase.VRC_Pickup> _GetPickupInHand; // 0xA8
        public Action`5<VRC.SDKBase.VRCPlayerApi,0x6B24F598,float,float,float> _PlayHapticEventInHand; // 0xB0
        public System.Action`3<VRC.SDKBase.VRCPlayerApi,UnityEngine.Vector3,UnityEngine.Quaternion> _TeleportTo; // 0xB8
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,UnityEngine.Vector3,UnityEngine.Quaternion,0x6B2504B8> _TeleportToOrientation; // 0xC0
        public Action`5<VRC.SDKBase.VRCPlayerApi,UnityEngine.Vector3,UnityEngine.Quaternion,0x6B2504B8,bool> _TeleportToOrientationLerp; // 0xC8
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _Respawn; // 0xD0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,int> _RespawnWithIndex; // 0xD8
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _EnablePickups; // 0xE0
        public System.Func`1<string[]> _GetAvailableLanguages; // 0xE8
        public System.Func`1<string> _GetCurrentLanguage; // 0xF0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.Color> _SetNamePlateColor; // 0xF8
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _RestoreNamePlateColor; // 0x100
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _SetNamePlateVisibility; // 0x108
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _RestoreNamePlateVisibility; // 0x110
        public System.Action`3<VRC.SDKBase.VRCPlayerApi,string,string> _SetPlayerTag; // 0x118
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,string> _GetPlayerTag; // 0x120
        public System.Func`3<string,string,System.Collections.Generic.List`1<int>> _GetPlayersWithTag; // 0x128
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _ClearPlayerTags; // 0x130
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,bool,string,string> _SetInvisibleToTagged; // 0x138
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,bool,string,string> _SetInvisibleToUntagged; // 0x140
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,int,string,string> _SetSilencedToTagged; // 0x148
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,int,string,string> _SetSilencedToUntagged; // 0x150
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _ClearInvisible; // 0x158
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _ClearSilence; // 0x160
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetRunSpeed; // 0x168
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetWalkSpeed; // 0x170
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetStrafeSpeed; // 0x178
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetJumpImpulse; // 0x180
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetGravityStrength; // 0x188
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetRunSpeed; // 0x190
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetWalkSpeed; // 0x198
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetStrafeSpeed; // 0x1A0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetJumpImpulse; // 0x1A8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetGravityStrength; // 0x1B0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetVoiceGain; // 0x1B8
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetVoiceDistanceNear; // 0x1C0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetVoiceDistanceFar; // 0x1C8
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetVoiceVolumetricRadius; // 0x1D0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _SetVoiceLowpass; // 0x1D8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetVoiceGain; // 0x1E0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetVoiceDistanceNear; // 0x1E8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetVoiceDistanceFar; // 0x1F0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetVoiceVolumetricRadius; // 0x1F8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _GetVoiceLowpass; // 0x200
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarAudioGain; // 0x208
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarAudioFarRadius; // 0x210
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarAudioNearRadius; // 0x218
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarAudioVolumetricRadius; // 0x220
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _SetAvatarAudioForceSpatial; // 0x228
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _SetAvatarAudioCustomCurve; // 0x230
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _CombatSetup; // 0x238
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _CombatSetMaxHitpoints; // 0x240
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _CombatSetCurrentHitpoints; // 0x248
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _CombatGetCurrentHitpoints; // 0x250
        public System.Action`4<VRC.SDKBase.VRCPlayerApi,bool,float,UnityEngine.Transform> _CombatSetRespawn; // 0x258
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.GameObject> _CombatSetDamageGraphic; // 0x260
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,VRC.SDKBase.IVRC_Destructible> _CombatGetDestructible; // 0x268
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _IsUserInVR; // 0x270
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _UseLegacyLocomotion; // 0x278
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _UseAttachedStation; // 0x280
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.RuntimeAnimatorController> _PushAnimations; // 0x288
        public System.Action`1<VRC.SDKBase.VRCPlayerApi> _PopAnimations; // 0x290
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _Immobilize; // 0x298
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.Vector3> _SetVelocity; // 0x2A0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.Vector3> _GetVelocity; // 0x2A8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.Vector3> _GetPosition; // 0x2B0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,UnityEngine.Quaternion> _GetRotation; // 0x2B8
        public UnityEngine.GameObject gameObject; // 0x28
        public bool _isValid; // 0x30
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetAvatarEyeHeightAsMeters; // 0x2C0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetAvatarEyeHeightMaximumAsMeters; // 0x2C8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _GetAvatarEyeHeightMinimumAsMeters; // 0x2D0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _GetManualAvatarScalingAllowed; // 0x2D8
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarEyeHeightByMeters; // 0x2E0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarEyeHeightByMultiplier; // 0x2E8
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarEyeHeightMaximumByMeters; // 0x2F0
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,float> _SetAvatarEyeHeightMinimumByMeters; // 0x2F8
        public System.Action`2<VRC.SDKBase.VRCPlayerApi,bool> _SetManualAvatarScalingAllowed; // 0x300

        // ── Methods ──
        public void get_isMaster(){} // RVA: 0x7FFACC0488B0
        public void get_isInstanceOwner(){} // RVA: 0x7FFACC048930
        public void get_isModerator(){} // RVA: 0x7FFACC0489B0
        public void get_isSuper(){} // RVA: 0x7FFACC048A30
        public void get_isSuspended(){} // RVA: 0x7FFACC048AB0
        public void get_isVRCPlus(){} // RVA: 0x7FFACC048B30
        public void IsPlayerGrounded(){} // RVA: 0x7FFACC048BB0
        public void GetDrone(){} // RVA: 0x7FFACC048C50
        public void get_AllPlayers(){} // RVA: 0x7FFACC048CD0
        public void GetPlayers(){} // RVA: 0x7FFACC048DE0 | overloaded x2
        public void GetPlayerCount(){} // RVA: 0x7FFACC048E80
        public void GetPlayerId(){} // RVA: 0x7FFACC048F00
        public void get_playerId(){} // RVA: 0x7FFACC048F80
        public void GetPlayerByGameObject(){} // RVA: 0x7FFACC048FE0
        public void GetPlayerById(){} // RVA: 0x7FFACC049060
        public void IsValid(){} // RVA: 0x7FFAC2F47450
        public void IsOwner(){} // RVA: 0x7FFACC0490E0
        public void TakeOwnership(){} // RVA: 0x7FFACC049170
        public void GetTrackingData(){} // RVA: 0x7FFACC049200
        public void GetBoneTransform(){} // RVA: 0x7FFACC0492C0
        public void GetBonePosition(){} // RVA: 0x7FFACC049350
        public void GetBoneRotation(){} // RVA: 0x7FFACC049410
        public void GetPickupInHand(){} // RVA: 0x7FFACC0494C0
        public void SetPickupInHand(){} // RVA: 0x7FFAC2F21310
        public void PlayHapticEventInHand(){} // RVA: 0x7FFACC049550
        public void TeleportTo(){} // RVA: 0x7FFACC049810 | overloaded x3
        public void Respawn(){} // RVA: 0x7FFACC049990 | overloaded x2
        public void EnablePickups(){} // RVA: 0x7FFACC049A20
        public void SetNamePlateColor(){} // RVA: 0x7FFACC049AB0
        public void RestoreNamePlateColor(){} // RVA: 0x7FFACC049B50
        public void SetNamePlateVisibility(){} // RVA: 0x7FFACC049BD0
        public void RestoreNamePlateVisibility(){} // RVA: 0x7FFACC049C60
        public void SetPlayerTag(){} // RVA: 0x7FFACC049CE0
        public void GetPlayerTag(){} // RVA: 0x7FFACC049D80
        public void GetPlayersWithTag(){} // RVA: 0x7FFAC34F9180
        public void ClearPlayerTags(){} // RVA: 0x7FFACC049E10
        public void SetInvisibleToTagged(){} // RVA: 0x7FFACC049E90
        public void SetInvisibleToUntagged(){} // RVA: 0x7FFACC049F50
        public void SetSilencedToTagged(){} // RVA: 0x7FFACC04A010
        public void SetSilencedToUntagged(){} // RVA: 0x7FFACC04A0C0
        public void SetRunSpeed(){} // RVA: 0x7FFACC04A170
        public void SetWalkSpeed(){} // RVA: 0x7FFACC04A200
        public void SetStrafeSpeed(){} // RVA: 0x7FFACC04A290
        public void SetJumpImpulse(){} // RVA: 0x7FFACC04A320
        public void GetGravityStrength(){} // RVA: 0x7FFACC04A3B0
        public void GetRunSpeed(){} // RVA: 0x7FFACC04A430
        public void GetWalkSpeed(){} // RVA: 0x7FFACC04A4B0
        public void GetStrafeSpeed(){} // RVA: 0x7FFACC04A530
        public void GetJumpImpulse(){} // RVA: 0x7FFACC04A5B0
        public void IsUserInVR(){} // RVA: 0x7FFACC04A630
        public void SetGravityStrength(){} // RVA: 0x7FFACC04A6B0
        public void UseLegacyLocomotion(){} // RVA: 0x7FFACC04A740
        public void UseAttachedStation(){} // RVA: 0x7FFACC04A7C0
        public void ClearInvisible(){} // RVA: 0x7FFACC04A840
        public void ClearSilence(){} // RVA: 0x7FFACC04A8C0
        public void AddToList(){} // RVA: 0x7FFACC04A940
        public void RemoveFromList(){} // RVA: 0x7FFACC04A9D0
        public void CombatSetup(){} // RVA: 0x7FFACC04AA60
        public void CombatSetMaxHitpoints(){} // RVA: 0x7FFACC04AAE0
        public void CombatSetCurrentHitpoints(){} // RVA: 0x7FFACC04AB70
        public void CombatGetCurrentHitpoints(){} // RVA: 0x7FFACC04AC00
        public void CombatSetRespawn(){} // RVA: 0x7FFACC04AC80
        public void CombatSetDamageGraphic(){} // RVA: 0x7FFACC04AD40
        public void CombatGetDestructible(){} // RVA: 0x7FFACC04ADD0
        public void SetVoiceGain(){} // RVA: 0x7FFACC04AE50
        public void GetVoiceGain(){} // RVA: 0x7FFACC04AEE0
        public void SetVoiceDistanceNear(){} // RVA: 0x7FFACC04AF60
        public void GetVoiceDistanceNear(){} // RVA: 0x7FFACC04AFF0
        public void SetVoiceDistanceFar(){} // RVA: 0x7FFACC04B070
        public void GetVoiceDistanceFar(){} // RVA: 0x7FFACC04B100
        public void SetVoiceVolumetricRadius(){} // RVA: 0x7FFACC04B180
        public void GetVoiceVolumetricRadius(){} // RVA: 0x7FFACC04B210
        public void SetVoiceLowpass(){} // RVA: 0x7FFACC04B290
        public void GetVoiceLowpass(){} // RVA: 0x7FFACC04B320
        public void SetAvatarAudioGain(){} // RVA: 0x7FFACC04B3A0
        public void SetAvatarAudioFarRadius(){} // RVA: 0x7FFACC04B430
        public void SetAvatarAudioNearRadius(){} // RVA: 0x7FFACC04B4C0
        public void SetAvatarAudioVolumetricRadius(){} // RVA: 0x7FFACC04B550
        public void SetAvatarAudioForceSpatial(){} // RVA: 0x7FFACC04B5E0
        public void SetAvatarAudioCustomCurve(){} // RVA: 0x7FFACC04B670
        public void GetAvailableLanguages(){} // RVA: 0x7FFACC04B700
        public void GetCurrentLanguage(){} // RVA: 0x7FFACC04B770
        public void GetPlayerObjects(){} // RVA: 0x7FFACC04B7E0
        public void FindComponentInPlayerObjects(){} // RVA: 0x7FFACC04B880
        public void PushAnimations(){} // RVA: 0x7FFACC04B890
        public void PopAnimations(){} // RVA: 0x7FFACC04B920
        public void Immobilize(){} // RVA: 0x7FFACC04B9A0
        public void SetVelocity(){} // RVA: 0x7FFACC04BA30
        public void GetVelocity(){} // RVA: 0x7FFACC04BAD0
        public void GetPosition(){} // RVA: 0x7FFACC04BB70
        public void GetRotation(){} // RVA: 0x7FFACC04BC10
        public void GetAvatarEyeHeightAsMeters(){} // RVA: 0x7FFACC04BCB0
        public void GetAvatarEyeHeightMaximumAsMeters(){} // RVA: 0x7FFACC04BD30
        public void GetAvatarEyeHeightMinimumAsMeters(){} // RVA: 0x7FFACC04BDB0
        public void GetManualAvatarScalingAllowed(){} // RVA: 0x7FFACC04BE30
        public void SetAvatarEyeHeightByMeters(){} // RVA: 0x7FFACC04BEB0
        public void SetAvatarEyeHeightByMultiplier(){} // RVA: 0x7FFACC04BF40
        public void SetAvatarEyeHeightMaximumByMeters(){} // RVA: 0x7FFACC04BFD0
        public void SetAvatarEyeHeightMinimumByMeters(){} // RVA: 0x7FFACC04C060
        public void SetManualAvatarScalingAllowed(){} // RVA: 0x7FFACC04C0F0
        public void .ctor(){} // RVA: 0x7FFACC04C180
        public void .cctor(){} // RVA: 0x7FFACC04C210
    }

    public class VRCRenderTexture : Object
    {
        public System.Action`1<UnityEngine.RenderTexture> OnGetTemporaryRenderTexture;
        public System.Action`1<UnityEngine.RenderTexture> OnReleaseTemporaryRenderTexture; // 0x8

        // ── Methods ──
        public void add_OnGetTemporaryRenderTexture(){} // RVA: 0x7FFACC05A9F0
        public void remove_OnGetTemporaryRenderTexture(){} // RVA: 0x7FFACC05AB20
        public void add_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7FFACC05AC50
        public void remove_OnReleaseTemporaryRenderTexture(){} // RVA: 0x7FFACC05AD90
        public void GetTemporary(){} // RVA: 0x7FFACC05AFB0 | overloaded x2
        public void ReleaseTemporary(){} // RVA: 0x7FFACC05B040
    }

    public class VRCShader : Object
    {
        public System.Action`2<int,0x6B24FDD8> OnSetGlobalShaderVariable;
        public System.Collections.Generic.HashSet`1<int> _globalVariableIDWhitelist; // 0x8
        public System.Collections.Generic.List`1<string> _variableNameWhitelist; // 0x10

        // ── Methods ──
        public void add_OnSetGlobalShaderVariable(){} // RVA: 0x7FFACC05B0E0
        public void remove_OnSetGlobalShaderVariable(){} // RVA: 0x7FFACC05B240
        public void PropertyToID(){} // RVA: 0x7FFACC05B3A0
        public void SetGlobalInteger(){} // RVA: 0x7FFACC05B670
        public void SetGlobalFloat(){} // RVA: 0x7FFACC05B740
        public void SetGlobalTexture(){} // RVA: 0x7FFACC05B810
        public void SetGlobalColor(){} // RVA: 0x7FFACC05B8E0
        public void SetGlobalVector(){} // RVA: 0x7FFACC05B9F0
        public void SetGlobalMatrix(){} // RVA: 0x7FFACC05BAD0
        public void SetGlobalFloatArray(){} // RVA: 0x7FFACC05BBC0
        public void SetGlobalVectorArray(){} // RVA: 0x7FFACC05BC60
        public void SetGlobalMatrixArray(){} // RVA: 0x7FFACC05BD00
        public void ValidateAgainstPropertyIDWhitelist(){} // RVA: 0x7FFACC05BDA0
        public void ClearGlobalVariableWhitelist(){} // RVA: 0x7FFACC05BEB0
        public void .cctor(){} // RVA: 0x7FFACC05BF70
    }

    public class VRCStation : MonoBehaviour
    {
        public 0x6B24FEE0 PlayerMobility; // 0x20
        public bool canUseStationFromStation; // 0x24
        public UnityEngine.RuntimeAnimatorController animatorController; // 0x28
        public bool disableStationExit; // 0x30
        public bool seated; // 0x31
        public UnityEngine.Transform stationEnterPlayerLocation; // 0x38
        public UnityEngine.Transform stationExitPlayerLocation; // 0x40
        public VRC.SDKBase.VRC_ObjectApi controlsObject; // 0x48
        public InitializationDelegate Initialize;
        public System.Action`2<VRC.SDKBase.VRCStation,VRC.SDKBase.VRCPlayerApi> useStationDelegate; // 0x8
        public System.Action`2<VRC.SDKBase.VRCStation,VRC.SDKBase.VRCPlayerApi> exitStationDelegate; // 0x10

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC05C3D0
        public void UseStation(){} // RVA: 0x7FFACC05C430
        public void ExitStation(){} // RVA: 0x7FFACC05C4A0
        public void .ctor(){} // RVA: 0x7FFACBFEE430
    }

    public class VRCTriggerRelay : MonoBehaviour
    {
        public System.Action`1<VRC.SDKBase.VRCTriggerRelay> Initialize;
        public System.Collections.Generic.HashSet`1<UnityEngine.Collider>[] triggersInside; // 0x20
        public int currentIdx; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC073910
        public void OnTriggerEnter(){} // RVA: 0x7FFACC073970
        public void OnTriggerExit(){} // RVA: 0x7FFACC073A00
        public void .ctor(){} // RVA: 0x7FFACC073A80
    }

    public class VRCUrl : Object
    {
        public VRC.SDKBase.VRCUrl Empty;
        public System.Func`1<System.Collections.Generic.IEnumerable`1<string>> DomainExplicitAllowlistDelegate; // 0x8
        public System.Func`1<System.Collections.Generic.IEnumerable`1<string>> DomainWildcardAllowlistDelegate; // 0x10
        public string url; // 0x10

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFACC073C40
        public void TryCreateAllowlistedVRCUrl(){} // RVA: 0x7FFACC073CA0
        public void IsNullOrEmpty(){} // RVA: 0x7FFACC073F30
        public void get_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFACC073FD0
        public void set_DomainExplicitAllowlistDelegate(){} // RVA: 0x7FFACC074030
        public void get_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFACC0740F0
        public void set_DomainWildcardAllowlistDelegate(){} // RVA: 0x7FFACC074150
        public void IsAllowlistedUri(){} // RVA: 0x7FFACC074210
        public void .ctor(){} // RVA: 0x7FFACC074470
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFACC074650 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8C3A320
        public void .cctor(){} // RVA: 0x7FFACC0746A0
    }

    public class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        public 0x6B24DBD0 playable; // 0x18
        public int layer; // 0x1C
        public float goalWeight; // 0x20
        public float blendDuration; // 0x24
        public string debugString; // 0x28
        public InitializationDelegate Initialize;
        public ApplySettingsDelegate ApplySettings; // 0x30

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC04E3A0
        public void OnStateEnter(){} // RVA: 0x7FFAC7DB12C0
        public void .ctor(){} // RVA: 0x7FFACC017900
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        public bool disableLocomotion; // 0x18
        public string debugString; // 0x20
        public InitializationDelegate Initialize;
        public ApplySettingsDelegate ApplySettings; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC04E400
        public void OnStateEnter(){} // RVA: 0x7FFAC8E87130
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRC_AnimatorPlayAudio : StateMachineBehaviour
    {
        public UnityEngine.AudioSource ShouldApplyVolume; // 0x18
        public string ShouldApplyPitch; // 0x20
        public 0x6B24DE38 ShouldApplyClip; // 0x28
        public string ShouldApplyLoop; // 0x30
        public UnityEngine.Vector2 Volume; // 0x38
        public 0x6B24DE90 VolumeApplySettings; // 0x40
        public UnityEngine.Vector2 Pitch; // 0x44
        public 0x6B24DE90 PitchApplySettings; // 0x4C
        public UnityEngine.AudioClip[] Clips; // 0x50
        public 0x6B24DE90 ClipsApplySettings; // 0x58
        public bool Loop; // 0x5C
        public 0x6B24DE90 LoopApplySettings; // 0x60
        public float DelayInSeconds; // 0x64
        public bool PlayOnEnter; // 0x68
        public bool StopOnEnter; // 0x69
        public bool PlayOnExit; // 0x6A
        public bool StopOnExit; // 0x6B
        public int playbackIndex; // 0x6C
        public object destParam; // 0x70
        public InitializationDelegate Initialize;
        public EnterStateDelegate EnterState; // 0x78
        public ExitStateDelegate ExitState; // 0x80

        // ── Methods ──
        public void get_ShouldApplyVolume(){} // RVA: 0x7FFACC04E460
        public void get_ShouldApplyPitch(){} // RVA: 0x7FFACC04E470
        public void get_ShouldApplyClip(){} // RVA: 0x7FFACC04E480
        public void get_ShouldApplyLoop(){} // RVA: 0x7FFACC04E490
        public void ShouldApplySetting(){} // RVA: 0x7FFACC04E4A0
        public void Awake(){} // RVA: 0x7FFACC04E520
        public void OnStateEnter(){} // RVA: 0x7FFACC04E580
        public void OnStateExit(){} // RVA: 0x7FFACC04E5A0
        public void .ctor(){} // RVA: 0x7FFACC017910
    }

    public class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        public bool enterPoseSpace; // 0x18
        public bool fixedDelay; // 0x19
        public float delayTime; // 0x1C
        public string debugString; // 0x20
        public InitializationDelegate Initialize;
        public ApplySettingsDelegate ApplySettings; // 0x28
        public bool applied; // 0x30
        public float enterTime; // 0x34

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC04E5D0
        public void OnStateEnter(){} // RVA: 0x7FFACC04E630
        public void OnStateUpdate(){} // RVA: 0x7FFACC04E6C0
        public void .ctor(){} // RVA: 0x7FFACC017960
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        public 0x6B24E150 trackingHead; // 0x18
        public 0x6B24E150 trackingLeftHand; // 0x1C
        public 0x6B24E150 trackingRightHand; // 0x20
        public 0x6B24E150 trackingHip; // 0x24
        public 0x6B24E150 trackingLeftFoot; // 0x28
        public 0x6B24E150 trackingRightFoot; // 0x2C
        public 0x6B24E150 trackingLeftFingers; // 0x30
        public 0x6B24E150 trackingRightFingers; // 0x34
        public 0x6B24E150 trackingEyes; // 0x38
        public 0x6B24E150 trackingMouth; // 0x3C
        public string debugString; // 0x40
        public InitializationDelegate Initialize;
        public ApplySettingsDelegate ApplySettings; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC04E760
        public void OnStateEnter(){} // RVA: 0x7FFAC93E4990
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        public string NetworkIDCollection; // 0x20
        public UnityEngine.Vector3 ViewPosition; // 0x28
        public 0x6B24E2B0 Animations; // 0x34
        public bool ScaleIPD; // 0x38
        public 0x6B24E308 lipSync; // 0x3C
        public UnityEngine.Transform lipSyncJawBone; // 0x40
        public UnityEngine.Quaternion lipSyncJawClosed; // 0x48
        public UnityEngine.Quaternion lipSyncJawOpen; // 0x58
        public UnityEngine.SkinnedMeshRenderer VisemeSkinnedMesh; // 0x68
        public string MouthOpenBlendShapeName; // 0x70
        public string[] VisemeBlendShapes; // 0x78
        public object apiAvatar; // 0x80
        public string unityVersion; // 0x88
        public UnityEngine.Vector3 portraitCameraPositionOffset; // 0x90
        public UnityEngine.Quaternion portraitCameraRotationOffset; // 0x9C
        public System.Collections.Generic.List`1<VRC.SDKBase.Network.NetworkIDPair> networkIDs; // 0xB0

        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFACC04E7C0
        public void PositionPortraitCamera(){} // RVA: 0x7FFACC04EB00
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAC2F8C040
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAC2F8C050
        public void GetNetworkIDObjects(){} // RVA: 0x7FFACC04EF90
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFACC04F030
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFACC04F350
        public void .ctor(){} // RVA: 0x7FFACC04F3D0
    }

    public class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        public System.Collections.Generic.List`1<Parameter> parameters; // 0x18
        public bool localOnly; // 0x20
        public string debugString; // 0x28
        public bool isLocalPlayer; // 0x30
        public bool isEnabled; // 0x31
        public bool initialized; // 0x32
        public System.Action`2<VRC.SDKBase.VRC_AvatarParameterDriver,UnityEngine.Animator> OnApplySettings;

        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFACC04F6B0
        public void .ctor(){} // RVA: 0x7FFACC01C070
    }

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        public string blueprintId; // 0x20
        public bool grantBlueprintAccess; // 0x28
        public UnityEngine.Transform Placement; // 0x30
        public bool ChangeAvatarsOnUse; // 0x38
        public float scale; // 0x3C
        public System.Action OnReceiveAvatarImage; // 0x40
        public UnityEngine.Texture2D avatarImage; // 0x48
        public UnityEngine.GameObject Instance; // 0x50
        public InstantiationDelegate Instantiate;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC0547D0
        public void SwitchAvatar(){} // RVA: 0x7FFACC030BC0 | overloaded x2
        public void SetAvatarUse(){} // RVA: 0x7FFACC054CE0
        public void .ctor(){} // RVA: 0x7FFACC054E20
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        public VrcDataElement[] data; // 0x20
        public InitializationDelegate Initialize;
        public SerializationDelegate Serialize; // 0x8
        public DeserializationDelegate Deserialize; // 0x10
        public DataElementDelegate ElementChanged; // 0x28
        public System.Func`3<VRC.SDKBase.VRC_DataStorage,string,int> _GetElementIndex; // 0x18

        // ── Methods ──
        public void GetElementIndex(){} // RVA: 0x7FFACC074AF0
        public void GetElement(){} // RVA: 0x7FFACC074B60
        public void add_ElementChanged(){} // RVA: 0x7FFACC074BF0
        public void remove_ElementChanged(){} // RVA: 0x7FFACC074CE0
        public void OnDataElementChanged(){} // RVA: 0x7FFACC074DD0
        public void Awake(){} // RVA: 0x7FFACC074E00
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_DestructibleStandard : MonoBehaviour
    {
        public float maxHealth; // 0x20
        public float currentHealth; // 0x24
        public bool healable; // 0x28
        public string damageEvent; // 0x30
        public string destroyEvent; // 0x38
        public string healEvent; // 0x40
        public string fullHealthEvent; // 0x48
        public VRC.SDKBase.VRC_Trigger onDamagedTrigger; // 0x50
        public VrcEvent onDamagedEvent; // 0x58
        public VRC.SDKBase.VRC_Trigger onDestructedTrigger; // 0x60
        public VrcEvent onDestructedEvent; // 0x68
        public VRC.SDKBase.VRC_Trigger onHealedTrigger; // 0x70
        public VrcEvent onHealedEvent; // 0x78
        public VRC.SDKBase.VRC_Trigger onFullHealedTrigger; // 0x80
        public VrcEvent onFullHealedEvent; // 0x88
        public VRC.SDKBase.VRC_Trigger spawnerOnDamagedTrigger; // 0x90
        public VrcEvent spawnerOnDamagedEvent; // 0x98
        public VRC.SDKBase.VRC_Trigger spawnerOnDestructedTrigger; // 0xA0
        public VrcEvent spawnerOnDestructedEvent; // 0xA8
        public VRC.SDKBase.VRC_Trigger spawnerOnHealedTrigger; // 0xB0
        public VrcEvent spawnerOnHealedEvent; // 0xB8
        public VRC.SDKBase.VRC_Trigger spawnerOnFullHealedTrigger; // 0xC0
        public VrcEvent spawnerOnFullHealedEvent; // 0xC8
        public VRC.SDKBase.VRC_EventHandler eventHandler; // 0xD0

        // ── Methods ──
        public void GetMaxHealth(){} // RVA: 0x7FFAC2F4A080
        public void GetCurrentHealth(){} // RVA: 0x7FFAC308EF50
        public void Awake(){} // RVA: 0x7FFACC050D70
        public void ApplyDamage(){} // RVA: 0x7FFACC050F50
        public void ApplyHealing(){} // RVA: 0x7FFACC0514E0
        public void GetState(){} // RVA: 0x7FFACC051AC0
        public void SetState(){} // RVA: 0x7FFACC051B90
        public void HandleCallbackTrigger(){} // RVA: 0x7FFACC051C10
        public void .ctor(){} // RVA: 0x7FFACBFE2BD0
        public void <ApplyDamage>b__27_0(){} // RVA: 0x7FFACC050040
        public void <ApplyDamage>b__27_1(){} // RVA: 0x7FFACC051D50
        public void <ApplyHealing>b__28_0(){} // RVA: 0x7FFACC051D50
        public void <ApplyHealing>b__28_1(){} // RVA: 0x7FFACC051DB0
    }

    public class VRC_EventDispatcher : MonoBehaviour
    {
        // ── Methods ──
        public void TriggerEvent(){}
        public void RegisterEventHandler(){} // RVA: 0x7FFAC2C70A40
        public void UnregisterEventHandler(){} // RVA: 0x7FFAC2C70A40
        public void FindGameObject(){} // RVA: 0x7FFAC2C696F0 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_EventDispatcherLocal : VRC_EventDispatcher
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC052AE0
        public void TriggerEvent(){} // RVA: 0x7FFAC2F21310
        public void RegisterEventHandler(){} // RVA: 0x7FFAC2F21310
        public void UnregisterEventHandler(){} // RVA: 0x7FFAC2F21310
        public void FindGameObject(){} // RVA: 0x7FFACC052B30
        public void GetGameObjectPath(){} // RVA: 0x7FFACC052B80
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_EventHandler : VRCNetworkBehaviour
    {
        public System.Collections.Generic.List`1<VrcEvent> Dispatcher; // 0x20
        public VRC.SDKBase.VRC_EventDispatcher GetInsitgatorId; // 0x28
        public GetNetworkIdDelegate GetInstigatorId;
        public LogEventDelegate LogEvent; // 0x8
        public System.Collections.Generic.List`1<EventInfo> deferredEvents; // 0x30
        public UnityEngine.Coroutine DeferredEventProcessor; // 0x38

        // ── Methods ──
        public void BooleanOp(){} // RVA: 0x7FFACC074EF0
        public void get_Dispatcher(){} // RVA: 0x7FFACC074F10
        public void get_GetInsitgatorId(){} // RVA: 0x7FFACC075030
        public void set_GetInsitgatorId(){} // RVA: 0x7FFACC075070
        public void Awake(){} // RVA: 0x7FFACC075110
        public void VrcAnimationEvent(){} // RVA: 0x7FFACC0754B0
        public void IsReceiverRequiredForEventType(){} // RVA: 0x7FFACC0756A0
        public void TriggerEvent(){} // RVA: 0x7FFACC0766F0 | overloaded x4
        public void InternalTriggerEvent(){} // RVA: 0x7FFACC076160
        public void OnValidate(){} // RVA: 0x7FFACC0768E0
        public void OnDestroy(){} // RVA: 0x7FFACC076A40
        public void GetCombinedNetworkId(){} // RVA: 0x7FFAC34F9180
        public void HasEventTrigger(){} // RVA: 0x7FFACC076BB0
        public void IsReadyForEvents(){} // RVA: 0x7FFAC3006850
        public void DeferEvent(){} // RVA: 0x7FFACC076CB0
        public void ProcessDeferredEvents(){} // RVA: 0x7FFACC076FA0
        public void .ctor(){} // RVA: 0x7FFACC077040
    }

    public class VRC_GunStats : MonoBehaviour
    {
        public float rateOfFire; // 0x20
        public float damage; // 0x24
        public bool fullAuto; // 0x28
        public UnityEngine.GameObject muzzleEffect; // 0x30
        public UnityEngine.AudioSource muzzleAudio; // 0x38
        public UnityEngine.AudioClip[] fireAudio; // 0x40
        public UnityEngine.AudioSource reloadAudio; // 0x48
        public UnityEngine.GameObject[] hitEffects; // 0x50
        public UnityEngine.GameObject leftHandContact; // 0x58
        public bool leftHandPositionOnly; // 0x60
        public int clipSize; // 0x64
        public UnityEngine.AudioClip EmptyClipFire; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE3200
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC077AA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        public UnityEngine.Transform IsInteractive; // 0x20
        public string Proximity; // 0x28
        public UnityEngine.GameObject interactTextGO; // 0x30
        public float proximity; // 0x38
        public InitializationDelegate Initialize;
        public ValidDelegate CheckValid; // 0x8

        // ── Methods ──
        public void get_IsInteractive(){} // RVA: 0x7FFAC2F21320
        public void get_Proximity(){} // RVA: 0x7FFAC3716E90
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void Awake(){} // RVA: 0x7FFACC077E10
        public void Interact(){} // RVA: 0x7FFAC2C70980
        public void OnPickupUseUp(){} // RVA: 0x7FFAC2F21310
        public void OnPickupUseDown(){} // RVA: 0x7FFAC2F21310
        public void OnPickup(){} // RVA: 0x7FFAC2F21310
        public void OnDrop(){} // RVA: 0x7FFAC2F21310
        public void IsInteractiveForPlayer(){} // RVA: 0x7FFACC077E70
        public void .ctor(){} // RVA: 0x7FFACC077F10
    }

    public class VRC_KeyEvents : MonoBehaviour
    {
        public 0x6B17D1A8 Key; // 0x20
        public string DownEventName; // 0x28
        public string UpEventName; // 0x30
        public bool LocalOnly; // 0x38
        public 0x6B2517F8 BroadcastType; // 0x3C
        public VRC.SDKBase.VRC_EventHandler Handler; // 0x40
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC04F730
        public void Update(){} // RVA: 0x7FFACC04F990
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void <Update>b__9_0(){} // RVA: 0x7FFACC04FFE0
        public void <Update>b__9_2(){} // RVA: 0x7FFACC04FFE0
        public void <Update>b__9_1(){} // RVA: 0x7FFACC050040
        public void <Update>b__9_3(){} // RVA: 0x7FFACC050040
    }

    public class VRC_Label : MonoBehaviour
    {
        public string label; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFF0EC0
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        public MetadataCallback currentMetadata;
        public MetadataCallback metadataUpdate; // 0x20
        public System.Func`1<System.Collections.Generic.Dictionary`2<string,object>> _GetCurrentMetadata; // 0x8

        // ── Methods ──
        public void get_currentMetadata(){} // RVA: 0x7FFACC05C510
        public void Awake(){} // RVA: 0x7FFACC05C570
        public void OnDestroy(){} // RVA: 0x7FFACC05C6E0
        public void TriggerUpdate(){} // RVA: 0x7FFACC05C850
        public void MetadataChangedInternal(){} // RVA: 0x7FFACC05C8B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_MidiNoteIn : MonoBehaviour
    {
        public 0x6B24EF10 channel; // 0x20
        public 0x6B24EF68 note; // 0x24
        public CustomTriggerTarget OnNoteOn; // 0x28
        public CustomTriggerTarget OnNoteOff; // 0x30
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC0542B0
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_MirrorReflection : MonoBehaviour
    {
        public string CurrentlyRenderingMirror;
        public string CurrentMirrorCenterEyePos;
        public bool m_DisablePixelLights; // 0x20
        public bool TurnOffMirrorOcclusion; // 0x21
        public UnityEngine.LayerMask m_ReflectLayers; // 0x24
        public 0x6B250098 mirrorResolution; // 0x28
        public 0x6B2500F0 maximumAntialiasing; // 0x2C
        public UnityEngine.Shader customShader; // 0x30
        public 0x6B2501A0 MirrorQualityOverride;
        public RenderMirrorEventDelegate PreRenderMirror; // 0x8
        public RenderMirrorEventDelegate PostRenderMirror; // 0x10
        public VRC.SDKBase.VRC_MirrorReflection <CurrentlyRenderingMirror>k__BackingField; // 0x18
        public UnityEngine.Vector3 <CurrentMirrorCenterEyePos>k__BackingField; // 0x20
        public bool allowCustomMirrorShaders; // 0x2C
        public UnityEngine.RenderTexture _temporaryRenderTexture; // 0x38
        public System.Collections.Generic.Dictionary`2<UnityEngine.Camera,ReflectionData> _mReflections; // 0x40
        public UnityEngine.Renderer _mirrorRenderer; // 0x48
        public UnityEngine.Material _mirrorRendererMaterialInstance; // 0x50
        public UnityEngine.Camera _mirrorCamera; // 0x58
        public UnityEngine.Skybox _mirrorSkybox; // 0x60
        public UnityEngine.Matrix4x4 _parentTransform; // 0x68
        public UnityEngine.Quaternion _parentRotation; // 0xA8
        public int _playerLocalLayer; // 0xB8
        public int[] _texturePropertyId; // 0x30
        public int MAX_AUTO_VR_RESOLUTION;
        public int MAX_AUTO_DESKTOP_RESOLUTION;
        public int MAX_AUTO_RESOLUTION_UNLIMITER;

        // ── Methods ──
        public void add_PreRenderMirror(){} // RVA: 0x7FFACC05C8D0
        public void remove_PreRenderMirror(){} // RVA: 0x7FFACC05CA20
        public void add_PostRenderMirror(){} // RVA: 0x7FFACC05CB70
        public void remove_PostRenderMirror(){} // RVA: 0x7FFACC05CCC0
        public void get_CurrentlyRenderingMirror(){} // RVA: 0x7FFACC05CE10
        public void set_CurrentlyRenderingMirror(){} // RVA: 0x7FFACC05CE70
        public void get_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFACC05CF30
        public void set_CurrentMirrorCenterEyePos(){} // RVA: 0x7FFACC05CFA0
        public void OnValidate(){} // RVA: 0x7FFACC05D010
        public void Start(){} // RVA: 0x7FFACC05D070
        public void TrySetupMaterial(){} // RVA: 0x7FFACC05D480
        public void OnWillRenderObject(){} // RVA: 0x7FFACC05D9D0
        public void RenderMirrorCameras(){} // RVA: 0x7FFACC05DDA0
        public void CameraPostRender(){} // RVA: 0x7FFACC05F060
        public void OnDisable(){} // RVA: 0x7FFACC05F360
        public void OnDestroy(){} // RVA: 0x7FFACC05F800
        public void ShouldRenderLeftEye(){} // RVA: 0x7FFACC05FCB0
        public void ShouldRenderRightEye(){} // RVA: 0x7FFACC05FEC0
        public void ShouldRenderMonoscopic(){} // RVA: 0x7FFACC0600D0
        public void GetWorldEyePos(){} // RVA: 0x7FFACC060330
        public void GetWorldEyeRot(){} // RVA: 0x7FFACC060460
        public void GetEyeProjectionMatrix(){} // RVA: 0x7FFACC060650
        public void GetNormalDirection(){} // RVA: 0x7FFACC060720
        public void RenderMirror(){} // RVA: 0x7FFACC0607D0
        public void UpdateCameraClearing(){} // RVA: 0x7FFACC0614F0
        public void UpdateCameraModes(){} // RVA: 0x7FFACC0618D0
        public void UpdateParentTransform(){} // RVA: 0x7FFACC062240
        public void GetReflectionData(){} // RVA: 0x7FFACC062BB0
        public void GetAutoResolution(){} // RVA: 0x7FFACC0636A0
        public void Plane(){} // RVA: 0x7FFACC063890
        public void CameraSpacePlane(){} // RVA: 0x7FFACC0638F0
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFACC063D00
        public void CopySign(){} // RVA: 0x7FFACC063E70
        public void GetRotation(){} // RVA: 0x7FFACC063EA0
        public void GetPosition(){} // RVA: 0x7FFAC8C343C0
        public void .ctor(){} // RVA: 0x7FFACC0640E0
        public void .cctor(){} // RVA: 0x7FFACC0641F0
    }

    public class VRC_NPCSpawn : MonoBehaviour
    {
        public string npcName; // 0x20
        public string blueprintId; // 0x28
        public UnityEngine.RuntimeAnimatorController customAnimation; // 0x30
        public float scale; // 0x38
        public InstantiationDelegate Initialize;
        public UnityEngine.GameObject npcGameObject; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC054EE0
        public void .ctor(){} // RVA: 0x7FFACBFE3D60
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        public InitializeDelegate Initialize;
        public System.Func`2<UnityEngine.GameObject,VRC.SDKBase.VRC_NpcApi> _GetApiByGameObject; // 0x8
        public System.Action`4<VRC.SDKBase.VRC_NpcApi,bool,string,string> _SetNamePlate; // 0x10
        public System.Action`4<VRC.SDKBase.VRC_NpcApi,bool,bool,bool> _SetSocialStatus; // 0x18
        public System.Action`3<VRC.SDKBase.VRC_NpcApi,bool,bool> _SetMuteStatus; // 0x20
        public System.Action`3<VRC.SDKBase.VRC_NpcApi,int,bool> _ActThis; // 0x28
        public System.Action`3<VRC.SDKBase.VRC_NpcApi,UnityEngine.AudioClip,float> _SayThis; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC0500A0
        public void GetApiByGameObject(){} // RVA: 0x7FFACC050100
        public void ActThis(){} // RVA: 0x7FFACC050210
        public void SayThis(){} // RVA: 0x7FFACC0502A0
        public void SetNamePlate(){} // RVA: 0x7FFACC050330
        public void SetSocialStatus(){} // RVA: 0x7FFACC0503D0
        public void SetMuteStatus(){} // RVA: 0x7FFACC050470
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_ObjectApi : MonoBehaviour
    {
        // ── Methods ──
        public void ClaimControl(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_ObjectSpawn : MonoBehaviour
    {
        public UnityEngine.GameObject ObjectPrefab; // 0x20
        public InitializationDelegate Initialize;
        public InstantiationDelegate Instantiate; // 0x28
        public ObjectReaperDelegate ReapObjects; // 0x30

        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x7FFACC0551A0 | overloaded x2
        public void DestroySpawnedObjects(){} // RVA: 0x7FFAC4948B60
        public void Start(){} // RVA: 0x7FFACC0552C0
        public void ProvideEvents(){} // RVA: 0x7FFACC055320
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        public string address; // 0x20
        public CustomTriggerTarget OnButtonOn; // 0x28
        public CustomTriggerTarget OnButtonOff; // 0x30
        public InitializationDelegate Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC054310
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Panorama : MonoBehaviour
    {
        public UnityEngine.Renderer renderer; // 0x20
        public System.Collections.Generic.List`1<PanoSpec> panoramas; // 0x28
        public int currentlyShown; // 0x30
        public VRC.SDKBase.VRC_DataStorage data; // 0x38
        public int dataIndex; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC064360
        public void Update(){} // RVA: 0x7FFACC064530
        public void NextPano(){} // RVA: 0x7FFACC064800
        public void PrevPano(){} // RVA: 0x7FFACC0648C0
        public void ShowPanoAt(){} // RVA: 0x7FFACC064980
        public void ShowPano(){} // RVA: 0x7FFACC064A10
        public void .ctor(){} // RVA: 0x7FFACBFF0F90
    }

    public class VRC_PhysicsRoot : MonoBehaviour
    {
        public UnityEngine.GameObject PhysicsRoot; // 0x20
        public UnityEngine.GameObject[] PhysicsObjects; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC050500
        public void OnDestroy(){} // RVA: 0x7FFACC050B30
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        public 0x6B29FCF0 currentPlayer; // 0x20
        public bool IsHeld; // 0x24
        public UnityEngine.Transform currentHand; // 0x28
        public UnityEngine.Transform Proximity; // 0x30
        public bool allowManipulationWhenEquipped; // 0x38
        public 0x6B24F4E8 orientation; // 0x3C
        public 0x6B24F540 AutoHold; // 0x40
        public string InteractionText; // 0x48
        public string UseText; // 0x50
        public 0x6B2517F8 useEventBroadcastType; // 0x58
        public string UseDownEventName; // 0x60
        public string UseUpEventName; // 0x68
        public 0x6B2517F8 pickupDropEventBroadcastType; // 0x70
        public string PickupEventName; // 0x78
        public string DropEventName; // 0x80
        public float ThrowVelocityBoostMinSpeed; // 0x88
        public float ThrowVelocityBoostScale; // 0x8C
        public UnityEngine.Component currentlyHeldBy; // 0x90
        public VRC.SDKBase.VRCPlayerApi currentLocalPlayer; // 0x98
        public bool pickupable; // 0xA0
        public float proximity; // 0xA4
        public AwakeDelegate OnAwake;
        public ForceDropDelegate ForceDrop; // 0x8
        public OnDestroyedDelegate OnDestroyed; // 0x10
        public HapticEventDelegate HapticEvent; // 0x18
        public System.Func`2<VRC.SDKBase.VRC_Pickup,0x6B24F598> _GetPickupHand; // 0x20
        public System.Func`2<VRC.SDKBase.VRC_Pickup,VRC.SDKBase.VRCPlayerApi> _GetCurrentPlayer; // 0x28

        // ── Methods ──
        public void IsGlobalAutoHoldPickup(){} // RVA: 0x7FFACC055930 | overloaded x2
        public void get_currentPlayer(){} // RVA: 0x7FFACC055960
        public void get_IsHeld(){} // RVA: 0x7FFACC0559D0
        public void get_currentHand(){} // RVA: 0x7FFACC055A90
        public void get_Proximity(){} // RVA: 0x7FFACC055AF0
        public void Awake(){} // RVA: 0x7FFACC055B00
        public void OnDisable(){} // RVA: 0x7FFACC055B60
        public void Reset(){} // RVA: 0x7FFACC055BA0
        public void Drop(){} // RVA: 0x7FFACC055D30 | overloaded x2
        public void GenerateHapticEvent(){} // RVA: 0x7FFACC055F90
        public void OnDestroy(){} // RVA: 0x7FFACC056030
        public void PlayHaptics(){} // RVA: 0x7FFACC056090
        public void ProvideEvents(){} // RVA: 0x7FFACC0560C0
        public void .ctor(){} // RVA: 0x7FFACC056500
    }

    public class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        public 0x6B24E6D0 layer; // 0x18
        public float goalWeight; // 0x1C
        public float blendDuration; // 0x20
        public string debugString; // 0x28
        public InitializationDelegate Initialize;
        public ApplySettingsDelegate ApplySettings; // 0x30
        public int outputParamHash; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC050C50
        public void OnStateEnter(){} // RVA: 0x7FFACC050CB0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        public 0x6B24F858 world; // 0x20
        public string roomId; // 0x28
        public string customPortalName; // 0x30
        public 0x6B24F7A8 sortHeading; // 0x38
        public 0x6B24F800 sortOrder; // 0x3C
        public int offset; // 0x40
        public string searchTerm; // 0x48
        public string tag; // 0x50
        public bool useDefaultPresentation; // 0x58
        public string effectPrefabName; // 0x60
        public InitializationDelegate Initialize;
        public string roomName; // 0x68
        public bool updateFlag; // 0x70
        public bool initializedWithRoomId; // 0x71

        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x7FFAC30D1BC0
        public void Awake(){} // RVA: 0x7FFACC0568B0
        public void Update(){} // RVA: 0x7FFACC056930
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_PropApi : MonoBehaviour
    {
        public 0x6B29CC78 mountPoint; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_PropController : MonoBehaviour
    {
        public VRC.SDKBase.VRCPlayerApi controllingPlayer; // 0x20
        public UnityEngine.Vector2 inputLeftAnalog; // 0x28
        public UnityEngine.Vector2 inputRightAnalog; // 0x30
        public bool inputUseButton; // 0x38
        public UpdateDelegate UpdateInputs;
        public InitializeDelegate Initialize; // 0x8
        public System.Collections.Generic.List`1<InputPairing> Inputs; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC0569B0
        public void Update(){} // RVA: 0x7FFACC056A10
        public void GetInputIndex(){} // RVA: 0x7FFACC056A80
        public void .ctor(){} // RVA: 0x7FFACBFE54B0
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        public object NetworkIDCollection; // 0x20
        public string NetworkIDLookup; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.GameObject> DynamicPrefabs; // 0x30
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.GameObject> sDynamicPrefabs;
        public System.Collections.Generic.List`1<UnityEngine.Material> DynamicMaterials; // 0x38
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Material> sDynamicMaterials; // 0x8
        public IntializationDelegate Initialize; // 0x10
        public System.Collections.Generic.List`1<VRC.SDKBase.Network.NetworkIDPair> NetworkIDs; // 0x40
        public System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,VRC.SDKBase.Network.NetworkIDPair> <NetworkIDLookup>k__BackingField; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC056B80
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAC2F9E740
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAC2F49200
        public void get_NetworkIDLookup(){} // RVA: 0x7FFAC2F9C730
        public void set_NetworkIDLookup(){} // RVA: 0x7FFAC2F9C740
        public void GetNetworkIDObjects(){} // RVA: 0x7FFACC0575B0
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFACC057650
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFACC04F350
        public void .ctor(){} // RVA: 0x7FFACC057970
    }

    public class VRC_SceneDescriptor : MonoBehaviour
    {
        public UnityEngine.Transform[] NetworkIDCollection; // 0x20
        public float NetworkIDLookup; // 0x28
        public 0x6B250460 Instance; // 0x2C
        public 0x6B2504B8 Exists; // 0x30
        public UnityEngine.GameObject BundleUnityMajorVersion; // 0x38
        public float Scene; // 0x40
        public 0x6B250510 ObjectBehaviourAtRespawnHeight; // 0x44
        public bool ForbidUserPortals; // 0x48
        public int interactThruLayers; // 0x4C
        public bool autoSpatializeAudioSources; // 0x50
        public UnityEngine.Vector3 gravity; // 0x54
        public bool[] layerCollisionArr; // 0x60
        public int capacity; // 0x68
        public bool contentSex; // 0x6C
        public bool contentViolence; // 0x6D
        public bool contentGore; // 0x6E
        public bool contentOther; // 0x6F
        public bool releasePublic; // 0x70
        public string unityVersion; // 0x78
        public System.Collections.Generic.List`1<string> udonProducts; // 0x80
        public string Name; // 0x88
        public bool NSFW; // 0x90
        public UnityEngine.Vector3 SpawnPosition; // 0x94
        public UnityEngine.Transform SpawnLocation; // 0xA0
        public float DrawDistance; // 0xA8
        public bool useAssignedLayers; // 0xAC
        public System.Collections.Generic.List`1<UnityEngine.GameObject> DynamicPrefabs; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.GameObject> sDynamicPrefabs;
        public System.Collections.Generic.List`1<UnityEngine.Material> DynamicMaterials; // 0xB8
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Material> sDynamicMaterials; // 0x8
        public UnityEngine.Texture2D[] LightMapsNear; // 0xC0
        public UnityEngine.Texture2D[] LightMapsFar; // 0xC8
        public 0x6B17C338 LightMode; // 0xD0
        public UnityEngine.Color RenderAmbientEquatorColor; // 0xD4
        public UnityEngine.Color RenderAmbientGroundColor; // 0xE4
        public float RenderAmbientIntensity; // 0xF4
        public UnityEngine.Color RenderAmbientLight; // 0xF8
        public 0x6B1866D8 RenderAmbientMode; // 0x108
        public UnityEngine.Rendering.SphericalHarmonicsL2 RenderAmbientProbe; // 0x10C
        public UnityEngine.Color RenderAmbientSkyColor; // 0x178
        public bool RenderFog; // 0x188
        public UnityEngine.Color RenderFogColor; // 0x18C
        public 0x6B17BB50 RenderFogMode; // 0x19C
        public float RenderFogDensity; // 0x1A0
        public float RenderFogLinearStart; // 0x1A4
        public float RenderFogLinearEnd; // 0x1A8
        public float RenderHaloStrength; // 0x1AC
        public float RenderFlareFadeSpeed; // 0x1B0
        public float RenderFlareStrength; // 0x1B4
        public UnityEngine.Cubemap RenderCustomReflection; // 0x1B8
        public 0x6B186730 RenderDefaultReflectionMode; // 0x1C0
        public int RenderDefaultReflectionResolution; // 0x1C4
        public int RenderReflectionBounces; // 0x1C8
        public float RenderReflectionIntensity; // 0x1CC
        public UnityEngine.Material RenderSkybox; // 0x1D0
        public System.Collections.Generic.List`1<VRC.SDKBase.Network.NetworkIDPair> NetworkIDs; // 0x1D8
        public System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,VRC.SDKBase.Network.NetworkIDPair> <NetworkIDLookup>k__BackingField; // 0x1E0
        public System.Collections.Generic.List`1<UnityEngine.GameObject> rootSceneGameObjectsBuffer; // 0x10
        public IntializationDelegate Initialize; // 0x18
        public object apiWorld; // 0x1E8
        public VRC.SDKBase.VRC_SceneDescriptor _instance; // 0x20
        public int _bundleUnityMajorVersion; // 0x1F0
        public UnityEngine.SceneManagement.Scene _scene; // 0x1F4
        public UnityEngine.Vector3 portraitCameraPositionOffset; // 0x1F8
        public UnityEngine.Quaternion portraitCameraRotationOffset; // 0x204

        // ── Methods ──
        public void GetValidatedSpawnList(){} // RVA: 0x7FFACC065390
        public void GetPrefab(){} // RVA: 0x7FFACC065580
        public void GetMaterial(){} // RVA: 0x7FFACC065970
        public void get_NetworkIDCollection(){} // RVA: 0x7FFAC39C0A30
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAC39CF5C0
        public void get_NetworkIDLookup(){} // RVA: 0x7FFAC33F8150
        public void set_NetworkIDLookup(){} // RVA: 0x7FFAC39B1270
        public void GetNetworkIDObjects(){} // RVA: 0x7FFACC065D60
        public void FindNetworkIDGameObject(){} // RVA: 0x7FFACC066050
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFACC04F350
        public void get_Instance(){} // RVA: 0x7FFACC0665B0
        public void get_Exists(){} // RVA: 0x7FFACC0668C0
        public void get_BundleUnityMajorVersion(){} // RVA: 0x7FFACC0669C0
        public void set_BundleUnityMajorVersion(){} // RVA: 0x7FFACC0669D0
        public void get_Scene(){} // RVA: 0x7FFAC47C4270
        public void set_Scene(){} // RVA: 0x7FFAC47C4280
        public void Awake(){} // RVA: 0x7FFACC0669E0
        public void OnDestroy(){} // RVA: 0x7FFACC0679B0
        public void PositionPortraitCamera(){} // RVA: 0x7FFACC067A70
        public void .ctor(){} // RVA: 0x7FFACC067E40
        public void .cctor(){} // RVA: 0x7FFACC068170
    }

    public class VRC_Serialization : Object
    {
        public System.Collections.Generic.HashSet`1<System.Type> AllowPluginTypes;
        public System.Collections.Generic.HashSet`1<System.Type> SurrogateSelector; // 0x8
        public bool Dispatcher; // 0x10
        public System.Runtime.Serialization.ISurrogateSelector _networkSurrogateSelector; // 0x18

        // ── Methods ──
        public void get_AllowPluginTypes(){} // RVA: 0x7FFACC077FD0
        public void set_AllowPluginTypes(){} // RVA: 0x7FFACC078030
        public void get_SurrogateSelector(){} // RVA: 0x7FFACC078090
        public void RegisterPluginType(){} // RVA: 0x7FFACC0781A0
        public void RegisterType(){} // RVA: 0x7FFACC078290
        public void ParameterEncoder(){} // RVA: 0x7FFACC078380
        public void ParameterDecoder(){} // RVA: 0x7FFACC078590
        public void get_Dispatcher(){} // RVA: 0x7FFACC078800
        public void GetGameObjectPathFallback(){} // RVA: 0x7FFACC078940
        public void GetGameObjectPath(){} // RVA: 0x7FFACC078BB0
        public void FindGameObject(){} // RVA: 0x7FFACC078CF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACC078E50
    }

    public class VRC_SlideShow : MonoBehaviour
    {
        public bool autoplay; // 0x20
        public bool shuffle; // 0x21
        public UnityEngine.Texture2D[] images; // 0x28
        public float displayDuration; // 0x30
        public UnityEngine.Material imageMaterial; // 0x38
        public int showingImage; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC057B90
        public void ShowNextImage(){} // RVA: 0x7FFACC057C50
        public void ShowPreviousImage(){} // RVA: 0x7FFACC057E70
        public void StartAutoplayWithDuration(){} // RVA: 0x7FFACC058040
        public void StopAutoplayWithDuration(){} // RVA: 0x7FFACC058100
        public void .ctor(){} // RVA: 0x7FFACBFE55B0
    }

    public class VRC_SpatialAudioSource : MonoBehaviour
    {
        public float Gain; // 0x20
        public float Far; // 0x24
        public float Near; // 0x28
        public float VolumetricRadius; // 0x2C
        public bool EnableSpatialization; // 0x30
        public bool UseAudioSourceVolumeCurve; // 0x31
        public InitializationDelegate Initialize;
        public UnityEngine.AudioSource _source; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC047DC0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFACC048060
        public void .ctor(){} // RVA: 0x7FFACBFE1C30
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        public 0x6B250670 specialLayer; // 0x20

        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFACC068460
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_StereoObject : MonoBehaviour
    {
        public 0x6B250720 eye; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_TimedEvents : MonoBehaviour
    {
        public bool Repeat; // 0x20
        public float LowPeriodTime; // 0x24
        public float HighPeriodTime; // 0x28
        public bool ResetOnEnable; // 0x2C
        public string EventName; // 0x30
        public 0x6B2517F8 BroadcastType; // 0x38
        public bool EventFired; // 0x3C
        public float Duration; // 0x40
        public float Timer; // 0x44
        public VRC.SDKBase.VRC_EventHandler Handler; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC068690
        public void OnEnable(){} // RVA: 0x7FFACC068860
        public void Update(){} // RVA: 0x7FFACC068870
        public void ResetClock(){} // RVA: 0x7FFACC068A00
        public void .ctor(){} // RVA: 0x7FFACBFEE4F0
    }

    public class VRC_Trigger : VRC_Interactable
    {
        public System.Action`1<VRC.SDKBase.VRC_Trigger> HasKeyTriggers;
        public bool HasTimerTriggers; // 0x40
        public bool HasColliderTriggers; // 0x41
        public bool HasInteractiveTriggers; // 0x42
        public bool HasPickupTriggers; // 0x43
        public 0x6B2508D8 IsInteractive; // 0x8
        public System.Collections.Generic.List`1<TriggerEvent> Triggers; // 0x48
        public System.Action`1<TriggerEvent> ExecuteTrigger; // 0x50

        // ── Methods ──
        public void TriggerCustom(){} // RVA: 0x7FFACC068D10 | overloaded x2
        public void Trigger(){} // RVA: 0x7FFACC068B80
        public void get_HasKeyTriggers(){} // RVA: 0x7FFACC068EA0
        public void get_HasTimerTriggers(){} // RVA: 0x7FFACC069010
        public void get_HasColliderTriggers(){} // RVA: 0x7FFACC069180
        public void get_HasInteractiveTriggers(){} // RVA: 0x7FFACC069420
        public void get_HasPickupTriggers(){} // RVA: 0x7FFACC069590
        public void get_IsInteractive(){} // RVA: 0x7FFACC069700
        public void Awake(){} // RVA: 0x7FFACC0699E0
        public void OnDestroy(){} // RVA: 0x7FFACC069A90
        public void OnEnable(){} // RVA: 0x7FFACC069AA0
        public void OnDisable(){} // RVA: 0x7FFACC069AD0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFACC069B00
        public void Interact(){} // RVA: 0x7FFACC06A0B0
        public void OnPickupUseUp(){} // RVA: 0x7FFACC06A0C0
        public void OnPickupUseDown(){} // RVA: 0x7FFACC06A0D0
        public void OnPickup(){} // RVA: 0x7FFACC06A0E0
        public void OnDrop(){} // RVA: 0x7FFACC06A0F0
        public void ExecuteTriggers(){} // RVA: 0x7FFACC06A100
        public void ExecuteTriggerType(){} // RVA: 0x7FFACC06A400
        public void ExecuteCustomTrigger(){} // RVA: 0x7FFACC06A760
        public void ResetClocks(){} // RVA: 0x7FFACC06AB50
        public void ResetClock(){} // RVA: 0x7FFACC06AEC0
        public void .ctor(){} // RVA: 0x7FFACBFEE550
        public void <OnDrawGizmosSelected>b__33_0(){} // RVA: 0x7FFACC06AF50
    }

    public class VRC_TriggerColliderEventTrigger : MonoBehaviour
    {
        public string EnterEventName; // 0x20
        public string ExitEventName; // 0x28
        public bool TriggerIndividuals; // 0x30
        public UnityEngine.LayerMask layers; // 0x34
        public VRC.SDKBase.VRC_EventHandler Handler; // 0x38
        public CollisionEnterDelegate CollisionEnter;
        public CollisionExitDelegate CollisionExit; // 0x8
        public int currentOccupants; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFACC06BF00
        public void OnTriggerEnter(){} // RVA: 0x7FFACC06C0C0
        public void OnTriggerExit(){} // RVA: 0x7FFACC06C200
        public void .ctor(){} // RVA: 0x7FFACBFEE620
    }

    public class VRC_TutorialAction : MonoBehaviour
    {
        // ── Methods ──
        public void ActivateAreaMarkerLabel(){} // RVA: 0x7FFACC0717A0
        public void ActivateObjectLabel(){} // RVA: 0x7FFACC0719A0 | overloaded x3
        public void DeactivateObjectLabel(){} // RVA: 0x7FFACC071A30
        public void ActivateControllerLabel(){} // RVA: 0x7FFACC071A90
        public void DeactivateControllerLabel(){} // RVA: 0x7FFACC071AC0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRC_TutorialAreaMarker : MonoBehaviour
    {
        public string Text; // 0x20
        public float EnableDistance; // 0x28
        public float MaxVisibleDistance; // 0x2C
        public bool DisableWhenPlayerInRange; // 0x30
        public bool _showingLabel; // 0x31
        public bool _enabled; // 0x32
        public float _timeStarted; // 0x34

        // ── Methods ──
        public void Enable(){} // RVA: 0x7FFAC8259980
        public void Update(){} // RVA: 0x7FFACC071AD0
        public void ShowLabel(){} // RVA: 0x7FFACC071F00
        public void .ctor(){} // RVA: 0x7FFACBFEE9E0
    }

    public class VRC_UiShape : MonoBehaviour
    {
        public GetEventCameraDelegate RootCanvas;
        public UnityEngine.Canvas RootCanvasRectTransform; // 0x20
        public UnityEngine.RectTransform <RootCanvasRectTransform>k__BackingField; // 0x28
        public bool AllowFocusView; // 0x30
        public UnityEngine.Canvas _uiCanvas; // 0x38
        public UnityEngine.RectTransform _localRectTransform; // 0x40
        public System.Action`1<VRC.SDKBase.VRC_UiShape> OnUiShapeInit; // 0x8
        public System.Action`1<VRC.SDKBase.VRC_UiShape> OnUiShapeDestroy; // 0x10

        // ── Methods ──
        public void get_RootCanvas(){} // RVA: 0x7FFAC2F4F0C0
        public void set_RootCanvas(){} // RVA: 0x7FFAC2F4F0D0
        public void get_RootCanvasRectTransform(){} // RVA: 0x7FFAC2F4F130
        public void set_RootCanvasRectTransform(){} // RVA: 0x7FFAC2F22E90
        public void add_OnUiShapeInit(){} // RVA: 0x7FFACC072A80
        public void remove_OnUiShapeInit(){} // RVA: 0x7FFACC072BC0
        public void add_OnUiShapeDestroy(){} // RVA: 0x7FFACC072D00
        public void remove_OnUiShapeDestroy(){} // RVA: 0x7FFACC072E40
        public void Awake(){} // RVA: 0x7FFACC072F80
        public void Start(){} // RVA: 0x7FFACC073120
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFACC073480
        public void SetupCollision(){} // RVA: 0x7FFACC073490
        public void OnDestroy(){} // RVA: 0x7FFACC0738B0
        public void .ctor(){} // RVA: 0x7FFAC2FD5710
    }

    public class VRC_UseEvents : VRC_Interactable
    {
        public string EventName; // 0x40
        public bool isHidden; // 0x48
        public 0x6B2517F8 BroadcastType; // 0x4C
        public UpdateDelegate UpdateUse;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC06C340
        public void Start(){} // RVA: 0x7FFACC06C580
        public void Interact(){} // RVA: 0x7FFACC06C810
        public void .ctor(){} // RVA: 0x7FFACBFEE670
        public void <Awake>b__5_0(){} // RVA: 0x7FFACC06C9F0
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        public float fullDamageScale; // 0x20
        public float minDamageScale; // 0x24
        public float offset; // 0x28
        public UnityEngine.AnimationCurve curve; // 0x30
        public float currentTime; // 0x38
        public UnityEngine.Renderer renderer; // 0x40
        public UnityEngine.Vector3 initScale; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACC051E10
        public void Start(){} // RVA: 0x7FFACC051EA0
        public void OnSceneWasLoaded(){} // RVA: 0x7FFACC0520D0
        public void Update(){} // RVA: 0x7FFACC052170
        public void HideDamageIndicator(){} // RVA: 0x7FFACC0523A0
        public void ShowDamageIndicator(){} // RVA: 0x7FFACC0524C0
        public void SetDamagePercent(){} // RVA: 0x7FFACC0525E0
        public void .ctor(){} // RVA: 0x7FFACC0528E0
    }

    public class VRC_Water : MonoBehaviour
    {
        public 0x6B250D50 waterMode; // 0x20
        public bool disablePixelLights; // 0x24
        public int textureSize; // 0x28
        public float clipPlaneOffset; // 0x2C
        public UnityEngine.LayerMask reflectLayers; // 0x30
        public UnityEngine.LayerMask refractLayers; // 0x34
        public bool TurnOffWaterOcclusion; // 0x38
        public System.Collections.Generic.Dictionary`2<UnityEngine.Camera,UnityEngine.Camera> m_ReflectionCameras; // 0x40
        public System.Collections.Generic.Dictionary`2<UnityEngine.Camera,UnityEngine.Camera> m_RefractionCameras; // 0x48
        public UnityEngine.RenderTexture m_ReflectionTexture; // 0x50
        public UnityEngine.RenderTexture m_RefractionTexture; // 0x58
        public 0x6B250D50 m_HardwareWaterSupport; // 0x60
        public int m_OldReflectionTextureSize; // 0x64
        public int m_OldRefractionTextureSize; // 0x68
        public bool s_InsideWater;

        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFACC06CB00
        public void OnDisable(){} // RVA: 0x7FFACC06D7E0
        public void Update(){} // RVA: 0x7FFACC06DE30
        public void UpdateCameraModes(){} // RVA: 0x7FFACC06E300
        public void CreateWaterObjects(){} // RVA: 0x7FFACC06E880
        public void GetWaterMode(){} // RVA: 0x7FFACC06FC40
        public void FindHardwareWaterSupport(){} // RVA: 0x7FFACC06FC50
        public void CameraSpacePlane(){} // RVA: 0x7FFAC2F38D00
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFAC2F390F0
        public void .ctor(){} // RVA: 0x7FFACBFEE710
    }

    public class VRC_WebPanel : VRC_Interactable
    {
        public string WebRootPath; // 0x40
        public string defaultUrl; // 0x48
        public int resolutionWidth; // 0x50
        public int resolutionHeight; // 0x54
        public UnityEngine.Rect displayRegion; // 0x58
        public bool interactive; // 0x68
        public UnityEngine.Material[] extraVideoScreens; // 0x70
        public InitializeDelegate Initialize;
        public bool localOnly; // 0x78
        public bool syncURI; // 0x79
        public bool syncInput; // 0x7A
        public bool syncDisplayAndAudio; // 0x7B
        public UnityEngine.GameObject cursor; // 0x80
        public bool transparent; // 0x88
        public VRC.SDKBase.VRCStation station; // 0x90
        public bool cookiesEnabled; // 0x98
        public bool autoFormSubmit; // 0x99
        public System.Collections.Generic.List`1<WebFile> webData; // 0xA0
        public System.Action`1<string> _NavigateTo; // 0xA8
        public System.Action _WebPanelForward; // 0xB0
        public System.Action _WebPanelBackward; // 0xB8
        public System.Action _WebPanelReload; // 0xC0
        public System.Action`1<string> _ExecuteScript; // 0xC8
        public System.Func`3<string,System.Delegate,bool> _BindCall; // 0xD0

        // ── Methods ──
        public void WebPanelForward(){} // RVA: 0x7FFACC06FF40
        public void WebPanelBackward(){} // RVA: 0x7FFACC06FF70
        public void WebPanelReload(){} // RVA: 0x7FFACC06FFA0
        public void BindCall(){} // RVA: 0x7FFACC06FFD0
        public void NavigateTo(){} // RVA: 0x7FFACC070000
        public void Awake(){} // RVA: 0x7FFACC070030
        public void Interact(){} // RVA: 0x7FFAC2F21310
        public void get_WebRootPath(){} // RVA: 0x7FFACC070140
        public void ProvideEvents(){} // RVA: 0x7FFACC0702B0
        public void ReadData(){} // RVA: 0x7FFACC070BE0
        public void ImportWebData(){} // RVA: 0x7FFACC070E40
        public void .ctor(){} // RVA: 0x7FFACBFEE8B0
    }

    public class VersionHelper : Object
    {
        // ── Methods ──
        public void GetLatestVersion(){} // RVA: 0x7FFAC2E8DC40
    }

}