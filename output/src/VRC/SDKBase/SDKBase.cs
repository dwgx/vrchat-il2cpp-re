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
        public n<BuffersImpl,float> SceneEventHandler;
        public n<BuffersImpl,string> IsNetworkSettled; // 0x8
        public BothDirectoryInformation<ght,BuffersImpl,string,object[]> IsMaster; // 0x10
        public BothDirectoryInformation<ellSize.artCorner,BuffersImpl,string,object[]> IsClogged; // 0x18
        public ormation<bool> IsInstanceOwner; // 0x20
        public ormation<bool> LocalPlayer; // 0x28
        public ormation<bool> Master; // 0x30
        public ormation<bool> InstanceOwner; // 0x38
        public ormation<ellSize.artCorner> _LocalPlayer; // 0x40
        public ormation<ellSize.artCorner> _GetMaster; // 0x48
        public ormation<ellSize.artCorner> _GetInstanceOwner; // 0x50
        public nalInformation<ellSize.artCorner,BuffersImpl,bool> _IsOwner; // 0x58
        public rectoryInformation<ellSize.artCorner,BuffersImpl> _SetOwner; // 0x60
        public n<BuffersImpl,bool> _IsObjectReady; // 0x68
        public ?<e,string,amut,R_12x12,BuffersImpl> _Instantiate; // 0x70
        public n<BuffersImpl,ellSize.artCorner> _GetOwner; // 0x78
        public n<object[],byte[]> _ParameterEncoder; // 0x80
        public n<byte[],object[]> _ParameterDecoder; // 0x88
        public ileFullDirectoryInformation<BuffersImpl> _Destroy; // 0x90
        public ormation<ellSize.ZE_LIMIT_PC> _SceneEventHandler; // 0x98
        public n<string,bool> _GoToRoom; // 0xA0
        public ormation<DependencyInjector> _GetNetworkDateTime; // 0xA8
        public ormation<double> _GetServerTimeInSeconds; // 0xB0
        public ormation<int> _GetServerTimeInMilliseconds; // 0xB8
        public nalInformation<double,double,double> _CalculateServerDeltaTime; // 0xC0
        public n<mePatterns.e,ts> _SafeStartCoroutine; // 0xC8
        public ormation<ellSize.leCalled> _GetEventDispatcher; // 0xD0
        public n<ellSize.artCorner,BuffersImpl[]> _GetPlayerPersistence; // 0xD8
        public n<ellSize.artCorner,int> _GetPlayerDataStorageUsage; // 0xE0
        public n<ellSize.artCorner,int> _GetPlayerObjectStorageUsage; // 0xE8
        public ormation<int> _GetPlayerDataStorageLimit; // 0xF0
        public ormation<int> _GetPlayerObjectStorageLimit; // 0xF8
        public nalInformation<ellSize.artCorner,led,led> _FindComponentInPlayerObjects; // 0x100
        public ÎÌÍÏÏÌÍÏ _RequestStorageUsageUpdate; // 0x108

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
        public bool _isClient;

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
        public roperty _GetDroneFromGameObject;

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
        public n<ellSize.artCorner,bool> isMaster;
        public n<ellSize.artCorner,bool> isInstanceOwner; // 0x8
        public n<ellSize.artCorner,bool> isModerator; // 0x10
        public n<ellSize.artCorner,bool> isSuper; // 0x18
        public n<ellSize.artCorner,bool> isSuspended; // 0x20
        public n<ellSize.artCorner,bool> isVRCPlus; // 0x28
        public bool AllPlayers; // 0x10
        public string playerId; // 0x18
        public gets SetAnimatorBool; // 0x30
        public uldRecalculateClipRects ClaimNetworkControl; // 0x38
        public stClipRectCanvasSpace GetLookRay; // 0x40
        public ce IsGrounded; // 0x48
        public p _GetDroneApi; // 0x50
        public URA.woDigitYearMax<ellSize.artCorner> sPlayers; // 0x58
        public int mPlayerId; // 0x20
        public n<ellSize.artCorner,int> _GetPlayerId; // 0x60
        public n<BuffersImpl,ellSize.artCorner> _GetPlayerByGameObject; // 0x68
        public n<int,ellSize.artCorner> _GetPlayerById; // 0x70
        public nalInformation<ellSize.artCorner,BuffersImpl,bool> _IsOwner; // 0x78
        public rectoryInformation<ellSize.artCorner,BuffersImpl> _TakeOwnership; // 0x80
        public nalInformation<ellSize.artCorner,ness,<>9__192_0> _GetTrackingData; // 0x88
        public nalInformation<ellSize.artCorner,ching,?> _GetBoneTransform; // 0x90
        public nalInformation<ellSize.artCorner,ching,amut> _GetBonePosition; // 0x98
        public nalInformation<ellSize.artCorner,ching,R_12x12> _GetBoneRotation; // 0xA0
        public nalInformation<ellSize.artCorner,Alpha,ellSize.ayIntersectionAllNonAllocCallback> _GetPickupInHand; // 0xA8
        public ÏÍÍÌÎÍÏÏÎÏÏÍÌÍÏ<ellSize.artCorner,Alpha,float,float,float> _PlayHapticEventInHand; // 0xB0
        public formation<ellSize.artCorner,amut,R_12x12> _TeleportTo; // 0xB8
        public BothDirectoryInformation<ellSize.artCorner,amut,R_12x12,nction> _TeleportToOrientation; // 0xC0
        public ÏÍÍÌÎÍÏÏÎÏÏÍÌÍÏ<ellSize.artCorner,amut,R_12x12,nction,bool> _TeleportToOrientationLerp; // 0xC8
        public ileFullDirectoryInformation<ellSize.artCorner> _Respawn; // 0xD0
        public rectoryInformation<ellSize.artCorner,int> _RespawnWithIndex; // 0xD8
        public rectoryInformation<ellSize.artCorner,bool> _EnablePickups; // 0xE0
        public ormation<string[]> _GetAvailableLanguages; // 0xE8
        public ormation<string> _GetCurrentLanguage; // 0xF0
        public rectoryInformation<ellSize.artCorner,?> _SetNamePlateColor; // 0xF8
        public ileFullDirectoryInformation<ellSize.artCorner> _RestoreNamePlateColor; // 0x100
        public rectoryInformation<ellSize.artCorner,bool> _SetNamePlateVisibility; // 0x108
        public ileFullDirectoryInformation<ellSize.artCorner> _RestoreNamePlateVisibility; // 0x110
        public formation<ellSize.artCorner,string,string> _SetPlayerTag; // 0x118
        public nalInformation<ellSize.artCorner,string,string> _GetPlayerTag; // 0x120
        public nalInformation<string,string,URA.woDigitYearMax<int>> _GetPlayersWithTag; // 0x128
        public ileFullDirectoryInformation<ellSize.artCorner> _ClearPlayerTags; // 0x130
        public BothDirectoryInformation<ellSize.artCorner,bool,string,string> _SetInvisibleToTagged; // 0x138
        public BothDirectoryInformation<ellSize.artCorner,bool,string,string> _SetInvisibleToUntagged; // 0x140
        public BothDirectoryInformation<ellSize.artCorner,int,string,string> _SetSilencedToTagged; // 0x148
        public BothDirectoryInformation<ellSize.artCorner,int,string,string> _SetSilencedToUntagged; // 0x150
        public ileFullDirectoryInformation<ellSize.artCorner> _ClearInvisible; // 0x158
        public ileFullDirectoryInformation<ellSize.artCorner> _ClearSilence; // 0x160
        public rectoryInformation<ellSize.artCorner,float> _SetRunSpeed; // 0x168
        public rectoryInformation<ellSize.artCorner,float> _SetWalkSpeed; // 0x170
        public rectoryInformation<ellSize.artCorner,float> _SetStrafeSpeed; // 0x178
        public rectoryInformation<ellSize.artCorner,float> _SetJumpImpulse; // 0x180
        public rectoryInformation<ellSize.artCorner,float> _SetGravityStrength; // 0x188
        public n<ellSize.artCorner,float> _GetRunSpeed; // 0x190
        public n<ellSize.artCorner,float> _GetWalkSpeed; // 0x198
        public n<ellSize.artCorner,float> _GetStrafeSpeed; // 0x1A0
        public n<ellSize.artCorner,float> _GetJumpImpulse; // 0x1A8
        public n<ellSize.artCorner,float> _GetGravityStrength; // 0x1B0
        public rectoryInformation<ellSize.artCorner,float> _SetVoiceGain; // 0x1B8
        public rectoryInformation<ellSize.artCorner,float> _SetVoiceDistanceNear; // 0x1C0
        public rectoryInformation<ellSize.artCorner,float> _SetVoiceDistanceFar; // 0x1C8
        public rectoryInformation<ellSize.artCorner,float> _SetVoiceVolumetricRadius; // 0x1D0
        public rectoryInformation<ellSize.artCorner,bool> _SetVoiceLowpass; // 0x1D8
        public n<ellSize.artCorner,float> _GetVoiceGain; // 0x1E0
        public n<ellSize.artCorner,float> _GetVoiceDistanceNear; // 0x1E8
        public n<ellSize.artCorner,float> _GetVoiceDistanceFar; // 0x1F0
        public n<ellSize.artCorner,float> _GetVoiceVolumetricRadius; // 0x1F8
        public n<ellSize.artCorner,bool> _GetVoiceLowpass; // 0x200
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarAudioGain; // 0x208
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarAudioFarRadius; // 0x210
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarAudioNearRadius; // 0x218
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarAudioVolumetricRadius; // 0x220
        public rectoryInformation<ellSize.artCorner,bool> _SetAvatarAudioForceSpatial; // 0x228
        public rectoryInformation<ellSize.artCorner,bool> _SetAvatarAudioCustomCurve; // 0x230
        public ileFullDirectoryInformation<ellSize.artCorner> _CombatSetup; // 0x238
        public rectoryInformation<ellSize.artCorner,float> _CombatSetMaxHitpoints; // 0x240
        public rectoryInformation<ellSize.artCorner,float> _CombatSetCurrentHitpoints; // 0x248
        public n<ellSize.artCorner,float> _CombatGetCurrentHitpoints; // 0x250
        public BothDirectoryInformation<ellSize.artCorner,bool,float,?> _CombatSetRespawn; // 0x258
        public rectoryInformation<ellSize.artCorner,BuffersImpl> _CombatSetDamageGraphic; // 0x260
        public n<ellSize.artCorner,ellSize.celerationRate> _CombatGetDestructible; // 0x268
        public n<ellSize.artCorner,bool> _IsUserInVR; // 0x270
        public ileFullDirectoryInformation<ellSize.artCorner> _UseLegacyLocomotion; // 0x278
        public ileFullDirectoryInformation<ellSize.artCorner> _UseAttachedStation; // 0x280
        public rectoryInformation<ellSize.artCorner,ColliderDistance2D> _PushAnimations; // 0x288
        public ileFullDirectoryInformation<ellSize.artCorner> _PopAnimations; // 0x290
        public rectoryInformation<ellSize.artCorner,bool> _Immobilize; // 0x298
        public rectoryInformation<ellSize.artCorner,amut> _SetVelocity; // 0x2A0
        public n<ellSize.artCorner,amut> _GetVelocity; // 0x2A8
        public n<ellSize.artCorner,amut> _GetPosition; // 0x2B0
        public n<ellSize.artCorner,R_12x12> _GetRotation; // 0x2B8
        public BuffersImpl gameObject; // 0x28
        public bool _isValid; // 0x30
        public n<ellSize.artCorner,float> _GetAvatarEyeHeightAsMeters; // 0x2C0
        public n<ellSize.artCorner,float> _GetAvatarEyeHeightMaximumAsMeters; // 0x2C8
        public n<ellSize.artCorner,float> _GetAvatarEyeHeightMinimumAsMeters; // 0x2D0
        public n<ellSize.artCorner,bool> _GetManualAvatarScalingAllowed; // 0x2D8
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarEyeHeightByMeters; // 0x2E0
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarEyeHeightByMultiplier; // 0x2E8
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarEyeHeightMaximumByMeters; // 0x2F0
        public rectoryInformation<ellSize.artCorner,float> _SetAvatarEyeHeightMinimumByMeters; // 0x2F8
        public rectoryInformation<ellSize.artCorner,bool> _SetManualAvatarScalingAllowed; // 0x300

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
        public ed PlayerMobility; // 0x20
        public bool canUseStationFromStation; // 0x24
        public ColliderDistance2D animatorController; // 0x28
        public bool disableStationExit; // 0x30
        public bool seated; // 0x31
        public object stationEnterPlayerLocation; // 0x38
        public object stationExitPlayerLocation; // 0x40
        public ellSize.sCache controlsObject; // 0x48
        public object Initialize;
        public rectoryInformation<ellSize.ss,ellSize.artCorner> useStationDelegate; // 0x8
        public rectoryInformation<ellSize.ss,ellSize.artCorner> exitStationDelegate; // 0x10

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5747C3D0
        public void UseStation(){} // RVA: 0x7FFD5747C430
        public void ExitStation(){} // RVA: 0x7FFD5747C4A0
        public void .ctor(){} // RVA: 0x7FFD5740E430
    }

    public class VRCTriggerRelay : MonoBehaviour
    {
        public ileFullDirectoryInformation<ellSize.ttomLeft> Initialize;
        public URA.onsDepth<riteCharacterUnicode>[] triggersInside; // 0x20
        public int currentIdx; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57493910
        public void OnTriggerEnter(){} // RVA: 0x7FFD57493970
        public void OnTriggerExit(){} // RVA: 0x7FFD57493A00
        public void .ctor(){} // RVA: 0x7FFD57493A80
    }

    public class VRCUrl : Object
    {
        public ellSize.t Empty;
        public ormation<URA.bbrevEraNames<string>> DomainExplicitAllowlistDelegate; // 0x8
        public ormation<URA.bbrevEraNames<string>> DomainWildcardAllowlistDelegate; // 0x10
        public string url; // 0x10

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
        public stepSize playable; // 0x18
        public int layer; // 0x1C
        public float goalWeight; // 0x20
        public float blendDuration; // 0x24
        public string debugString; // 0x28
        public object Initialize;
        public CachedReferences ApplySettings; // 0x30

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E3A0
        public void OnStateEnter(){} // RVA: 0x7FFD531D12C0
        public void .ctor(){} // RVA: 0x7FFD57437900
    }

    public class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        public bool disableLocomotion; // 0x18
        public string debugString; // 0x20
        public object Initialize;
        public CachedReferences ApplySettings; // 0x28

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
        public bool enterPoseSpace; // 0x18
        public bool fixedDelay; // 0x19
        public float delayTime; // 0x1C
        public string debugString; // 0x20
        public object Initialize;
        public CachedReferences ApplySettings; // 0x28
        public bool applied; // 0x30
        public float enterTime; // 0x34

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E5D0
        public void OnStateEnter(){} // RVA: 0x7FFD5746E630
        public void OnStateUpdate(){} // RVA: 0x7FFD5746E6C0
        public void .ctor(){} // RVA: 0x7FFD57437960
    }

    public class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        public ch7deltadown trackingHead; // 0x18
        public ch7deltadown trackingLeftHand; // 0x1C
        public ch7deltadown trackingRightHand; // 0x20
        public ch7deltadown trackingHip; // 0x24
        public ch7deltadown trackingLeftFoot; // 0x28
        public ch7deltadown trackingRightFoot; // 0x2C
        public ch7deltadown trackingLeftFingers; // 0x30
        public ch7deltadown trackingRightFingers; // 0x34
        public ch7deltadown trackingEyes; // 0x38
        public ch7deltadown trackingMouth; // 0x3C
        public string debugString; // 0x40
        public object Initialize;
        public CachedReferences ApplySettings; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5746E760
        public void OnStateEnter(){} // RVA: 0x7FFD54804990
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRC_AvatarDescriptor : MonoBehaviour
    {
        public string NetworkIDCollection; // 0x20
        public amut ViewPosition; // 0x28
        public barVisibility Animations; // 0x34
        public bool ScaleIPD; // 0x38
        public rollbarVisibility lipSync; // 0x3C
        public object lipSyncJawBone; // 0x40
        public R_12x12 lipSyncJawClosed; // 0x48
        public R_12x12 lipSyncJawOpen; // 0x58
        public ure VisemeSkinnedMesh; // 0x68
        public string MouthOpenBlendShapeName; // 0x70
        public string[] VisemeBlendShapes; // 0x78
        public object apiAvatar; // 0x80
        public string unityVersion; // 0x88
        public amut portraitCameraPositionOffset; // 0x90
        public R_12x12 portraitCameraRotationOffset; // 0x9C
        public URA.woDigitYearMax<BroadcastType.nEventName> networkIDs; // 0xB0

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
        public URA.woDigitYearMax<e> parameters; // 0x18
        public bool localOnly; // 0x20
        public string debugString; // 0x28
        public bool isLocalPlayer; // 0x30
        public bool isEnabled; // 0x31
        public bool initialized; // 0x32
        public rectoryInformation<ellSize.oLocalMatrix,stfix> OnApplySettings;

        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFD5746F6B0
        public void .ctor(){} // RVA: 0x7FFD5743C070
    }

    public class VRC_AvatarPedestal : VRCNetworkBehaviour
    {
        public string blueprintId; // 0x20
        public bool grantBlueprintAccess; // 0x28
        public object Placement; // 0x30
        public bool ChangeAvatarsOnUse; // 0x38
        public float scale; // 0x3C
        public ÎÌÍÏÏÌÍÏ OnReceiveAvatarImage; // 0x40
        public ector avatarImage; // 0x48
        public BuffersImpl Instance; // 0x50
        public object Instantiate;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574747D0
        public void SwitchAvatar(){} // RVA: 0x7FFD57450BC0 | overloaded x2
        public void SetAvatarUse(){} // RVA: 0x7FFD57474CE0
        public void .ctor(){} // RVA: 0x7FFD57474E20
    }

    public class VRC_DataStorage : VRCNetworkBehaviour
    {
        public ORLD_ASSET_BUNDLE_SIZE_LIMIT_PC[] data; // 0x20
        public object Initialize;
        public _AVATAR_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_PC Serialize; // 0x8
        public SSET_BUNDLE_SIZE_LIMIT_PC Deserialize; // 0x10
        public C ElementChanged; // 0x28
        public nalInformation<ellSize.tAssetBundleSizeLimit,string,int> _GetElementIndex; // 0x18

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
        public float maxHealth; // 0x20
        public float currentHealth; // 0x24
        public bool healable; // 0x28
        public string damageEvent; // 0x30
        public string destroyEvent; // 0x38
        public string healEvent; // 0x40
        public string fullHealthEvent; // 0x48
        public ellSize._DropHandler onDamagedTrigger; // 0x50
        public dImageInternal onDamagedEvent; // 0x58
        public ellSize._DropHandler onDestructedTrigger; // 0x60
        public dImageInternal onDestructedEvent; // 0x68
        public ellSize._DropHandler onHealedTrigger; // 0x70
        public dImageInternal onHealedEvent; // 0x78
        public ellSize._DropHandler onFullHealedTrigger; // 0x80
        public dImageInternal onFullHealedEvent; // 0x88
        public ellSize._DropHandler spawnerOnDamagedTrigger; // 0x90
        public dImageInternal spawnerOnDamagedEvent; // 0x98
        public ellSize._DropHandler spawnerOnDestructedTrigger; // 0xA0
        public dImageInternal spawnerOnDestructedEvent; // 0xA8
        public ellSize._DropHandler spawnerOnHealedTrigger; // 0xB0
        public dImageInternal spawnerOnHealedEvent; // 0xB8
        public ellSize._DropHandler spawnerOnFullHealedTrigger; // 0xC0
        public dImageInternal spawnerOnFullHealedEvent; // 0xC8
        public ellSize.ZE_LIMIT_PC eventHandler; // 0xD0

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
        public URA.woDigitYearMax<dImageInternal> Dispatcher; // 0x20
        public ellSize.leCalled GetInsitgatorId; // 0x28
        public eQueue GetInstigatorId;
        public ges LogEvent; // 0x8
        public URA.woDigitYearMax<itValueA> deferredEvents; // 0x30
        public ts DeferredEventProcessor; // 0x38

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
        public float rateOfFire; // 0x20
        public float damage; // 0x24
        public bool fullAuto; // 0x28
        public BuffersImpl muzzleEffect; // 0x30
        public t muzzleAudio; // 0x38
        public ies[] fireAudio; // 0x40
        public t reloadAudio; // 0x48
        public BuffersImpl[] hitEffects; // 0x50
        public BuffersImpl leftHandContact; // 0x58
        public bool leftHandPositionOnly; // 0x60
        public int clipSize; // 0x64
        public ies EmptyClipFire; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57403200
    }

    public class VRC_IKFollower : MonoBehaviour
    {
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57497AA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Interactable : VRCNetworkBehaviour
    {
        public object IsInteractive; // 0x20
        public string Proximity; // 0x28
        public BuffersImpl interactTextGO; // 0x30
        public float proximity; // 0x38
        public object Initialize;
        public ByGameObject CheckValid; // 0x8

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
        public Flag Key; // 0x20
        public string DownEventName; // 0x28
        public string UpEventName; // 0x30
        public bool LocalOnly; // 0x38
        public e BroadcastType; // 0x3C
        public ellSize.ZE_LIMIT_PC Handler; // 0x40
        public object Initialize;

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
        public string label; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57410EC0
    }

    public class VRC_MetadataListener : MonoBehaviour
    {
        public ingField currentMetadata;
        public ingField metadataUpdate; // 0x20
        public ormation<URA.DateTime<string,object>> _GetCurrentMetadata; // 0x8

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
        public ctor channel; // 0x20
        public ÌÎÍÎÌÌÎ note; // 0x24
        public t_compositionCursorPos OnNoteOn; // 0x28
        public t_compositionCursorPos OnNoteOff; // 0x30
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574742B0
        public void Start(){} // RVA: 0x7FFD4E341310
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_MirrorReflection : MonoBehaviour
    {
        public string CurrentlyRenderingMirror;
        public string CurrentMirrorCenterEyePos;
        public bool m_DisablePixelLights; // 0x20
        public bool TurnOffMirrorOcclusion; // 0x21
        public object m_ReflectLayers; // 0x24
        public e.Utilities.Encoders mirrorResolution; // 0x28
        public object maximumAntialiasing; // 0x2C
        public ojectionMatrix_Injected customShader; // 0x30
        public ChangeEventModule MirrorQualityOverride;
        public utModules PreRenderMirror; // 0x8
        public utModules PostRenderMirror; // 0x10
        public ellSize.elta>k__BackingField <CurrentlyRenderingMirror>k__BackingField; // 0x18
        public amut <CurrentMirrorCenterEyePos>k__BackingField; // 0x20
        public bool allowCustomMirrorShaders; // 0x2C
        public Offset _temporaryRenderTexture; // 0x38
        public URA.DateTime<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ,ÏÏÏÌÏÏÍÎÎ> _mReflections; // 0x40
        public rical _mirrorRenderer; // 0x48
        public atrix_Injected _mirrorRendererMaterialInstance; // 0x50
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ _mirrorCamera; // 0x58
        public Min _mirrorSkybox; // 0x60
        public tSizeBias _parentTransform; // 0x68
        public R_12x12 _parentRotation; // 0xA8
        public int _playerLocalLayer; // 0xB8
        public int[] _texturePropertyId; // 0x30
        public int MAX_AUTO_VR_RESOLUTION;
        public int MAX_AUTO_DESKTOP_RESOLUTION;
        public int MAX_AUTO_RESOLUTION_UNLIMITER;
        public ?[] _frustumPlanes; // 0x38

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
        public string npcName; // 0x20
        public string blueprintId; // 0x28
        public ColliderDistance2D customAnimation; // 0x30
        public float scale; // 0x38
        public object Initialize;
        public BuffersImpl npcGameObject; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57474EE0
        public void .ctor(){} // RVA: 0x7FFD57403D60
    }

    public class VRC_NpcApi : MonoBehaviour
    {
        public liderExpand Initialize;
        public n<BuffersImpl,ellSize.ontalScrollbarSpacing> _GetApiByGameObject; // 0x8
        public BothDirectoryInformation<ellSize.ontalScrollbarSpacing,bool,string,string> _SetNamePlate; // 0x10
        public BothDirectoryInformation<ellSize.ontalScrollbarSpacing,bool,bool,bool> _SetSocialStatus; // 0x18
        public formation<ellSize.ontalScrollbarSpacing,bool,bool> _SetMuteStatus; // 0x20
        public formation<ellSize.ontalScrollbarSpacing,int,bool> _ActThis; // 0x28
        public formation<ellSize.ontalScrollbarSpacing,ies,float> _SayThis; // 0x30

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
        public BuffersImpl ObjectPrefab; // 0x20
        public object Initialize;
        public object Instantiate; // 0x28
        public ctionAllCallback ReapObjects; // 0x30

        // ── Methods ──
        public void SpawnObject(){} // RVA: 0x7FFD574751A0 | overloaded x2
        public void DestroySpawnedObjects(){} // RVA: 0x7FFD4FD68B60
        public void Start(){} // RVA: 0x7FFD574752C0
        public void ProvideEvents(){} // RVA: 0x7FFD57475320
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_OscButtonIn : MonoBehaviour
    {
        public string address; // 0x20
        public t_compositionCursorPos OnButtonOn; // 0x28
        public t_compositionCursorPos OnButtonOff; // 0x30
        public object Initialize;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57474310
        public void Start(){} // RVA: 0x7FFD4E341310
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Panorama : MonoBehaviour
    {
        public rical renderer; // 0x20
        public URA.woDigitYearMax<tionGuard> panoramas; // 0x28
        public int currentlyShown; // 0x30
        public ellSize.tAssetBundleSizeLimit data; // 0x38
        public int dataIndex; // 0x40

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
        public BuffersImpl PhysicsRoot; // 0x20
        public BuffersImpl[] PhysicsObjects; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD57470500
        public void OnDestroy(){} // RVA: 0x7FFD57470B30
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_Pickup : VRCNetworkBehaviour
    {
        public atorMove currentPlayer; // 0x20
        public bool IsHeld; // 0x24
        public object currentHand; // 0x28
        public object Proximity; // 0x30
        public bool allowManipulationWhenEquipped; // 0x38
        public object orientation; // 0x3C
        public et_useGraphicAlpha AutoHold; // 0x40
        public string InteractionText; // 0x48
        public string UseText; // 0x50
        public e useEventBroadcastType; // 0x58
        public string UseDownEventName; // 0x60
        public string UseUpEventName; // 0x68
        public e pickupDropEventBroadcastType; // 0x70
        public string PickupEventName; // 0x78
        public string DropEventName; // 0x80
        public float ThrowVelocityBoostMinSpeed; // 0x88
        public float ThrowVelocityBoostScale; // 0x8C
        public led currentlyHeldBy; // 0x90
        public ellSize.artCorner currentLocalPlayer; // 0x98
        public bool pickupable; // 0xA0
        public float proximity; // 0xA4
        public ShadowZeroAlloc OnAwake;
        public c ForceDrop; // 0x8
        public fectColor OnDestroyed; // 0x10
        public stance HapticEvent; // 0x18
        public n<ellSize.ayIntersectionAllNonAllocCallback,Alpha> _GetPickupHand; // 0x20
        public n<ellSize.ayIntersectionAllNonAllocCallback,ellSize.artCorner> _GetCurrentPlayer; // 0x28

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
        public stepSize layer; // 0x18
        public float goalWeight; // 0x1C
        public float blendDuration; // 0x20
        public string debugString; // 0x28
        public object Initialize;
        public CachedReferences ApplySettings; // 0x30
        public int outputParamHash; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57470C50
        public void OnStateEnter(){} // RVA: 0x7FFD57470CB0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRC_PortalMarker : MonoBehaviour
    {
        public m_EnabledObjectCount world; // 0x20
        public string roomId; // 0x28
        public string customPortalName; // 0x30
        public object sortHeading; // 0x38
        public intananceParam sortOrder; // 0x3C
        public int offset; // 0x40
        public string searchTerm; // 0x48
        public string tag; // 0x50
        public bool useDefaultPresentation; // 0x58
        public string effectPrefabName; // 0x60
        public object Initialize;
        public string roomName; // 0x68
        public bool updateFlag; // 0x70
        public bool initializedWithRoomId; // 0x71

        // ── Methods ──
        public void RefreshPortal(){} // RVA: 0x7FFD4E4F1BC0
        public void Awake(){} // RVA: 0x7FFD574768B0
        public void Update(){} // RVA: 0x7FFD57476930
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PropApi : MonoBehaviour
    {
        public ching mountPoint; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRC_PropController : MonoBehaviour
    {
        public ellSize.artCorner controllingPlayer; // 0x20
        public tionX inputLeftAnalog; // 0x28
        public tionX inputRightAnalog; // 0x30
        public bool inputUseButton; // 0x38
        public object UpdateInputs;
        public liderExpand Initialize; // 0x8
        public URA.woDigitYearMax<s> Inputs; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD574769B0
        public void Update(){} // RVA: 0x7FFD57476A10
        public void GetInputIndex(){} // RVA: 0x7FFD57476A80
        public void .ctor(){} // RVA: 0x7FFD574054B0
    }

    public class VRC_PropDescriptor : MonoBehaviour
    {
        public object NetworkIDCollection; // 0x20
        public string NetworkIDLookup; // 0x28
        public URA.woDigitYearMax<BuffersImpl> DynamicPrefabs; // 0x30
        public URA.DateTime<string,BuffersImpl> sDynamicPrefabs;
        public URA.woDigitYearMax<atrix_Injected> DynamicMaterials; // 0x38
        public URA.DateTime<string,atrix_Injected> sDynamicMaterials; // 0x8
        public ment Initialize; // 0x10
        public URA.woDigitYearMax<BroadcastType.nEventName> NetworkIDs; // 0x40
        public URA.DateTime<BuffersImpl,BroadcastType.nEventName> <NetworkIDLookup>k__BackingField; // 0x48

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
        public ?[] NetworkIDCollection; // 0x20
        public float NetworkIDLookup; // 0x28
        public entChain Instance; // 0x2C
        public nction Exists; // 0x30
        public BuffersImpl BundleUnityMajorVersion; // 0x38
        public float Scene; // 0x40
        public eEvent ObjectBehaviourAtRespawnHeight; // 0x44
        public bool ForbidUserPortals; // 0x48
        public int interactThruLayers; // 0x4C
        public bool autoSpatializeAudioSources; // 0x50
        public amut gravity; // 0x54
        public bool[] layerCollisionArr; // 0x60
        public int capacity; // 0x68
        public bool contentSex; // 0x6C
        public bool contentViolence; // 0x6D
        public bool contentGore; // 0x6E
        public bool contentOther; // 0x6F
        public bool releasePublic; // 0x70
        public string unityVersion; // 0x78
        public URA.woDigitYearMax<string> udonProducts; // 0x80
        public string Name; // 0x88
        public bool NSFW; // 0x90
        public amut SpawnPosition; // 0x94
        public object SpawnLocation; // 0xA0
        public float DrawDistance; // 0xA8
        public bool useAssignedLayers; // 0xAC
        public URA.woDigitYearMax<BuffersImpl> DynamicPrefabs; // 0xB0
        public URA.DateTime<string,BuffersImpl> sDynamicPrefabs;
        public URA.woDigitYearMax<atrix_Injected> DynamicMaterials; // 0xB8
        public URA.DateTime<string,atrix_Injected> sDynamicMaterials; // 0x8
        public ector[] LightMapsNear; // 0xC0
        public ector[] LightMapsFar; // 0xC8
        public idth LightMode; // 0xD0
        public object RenderAmbientEquatorColor; // 0xD4
        public object RenderAmbientGroundColor; // 0xE4
        public float RenderAmbientIntensity; // 0xF4
        public object RenderAmbientLight; // 0xF8
        public ons.ration RenderAmbientMode; // 0x108
        public ons.? RenderAmbientProbe; // 0x10C
        public object RenderAmbientSkyColor; // 0x178
        public bool RenderFog; // 0x188
        public object RenderFogColor; // 0x18C
        public tSide RenderFogMode; // 0x19C
        public float RenderFogDensity; // 0x1A0
        public float RenderFogLinearStart; // 0x1A4
        public float RenderFogLinearEnd; // 0x1A8
        public float RenderHaloStrength; // 0x1AC
        public float RenderFlareFadeSpeed; // 0x1B0
        public float RenderFlareStrength; // 0x1B4
        public tmapST RenderCustomReflection; // 0x1B8
        public ons.icsMemorySize RenderDefaultReflectionMode; // 0x1C0
        public int RenderDefaultReflectionResolution; // 0x1C4
        public int RenderReflectionBounces; // 0x1C8
        public float RenderReflectionIntensity; // 0x1CC
        public atrix_Injected RenderSkybox; // 0x1D0
        public URA.woDigitYearMax<BroadcastType.nEventName> NetworkIDs; // 0x1D8
        public URA.DateTime<BuffersImpl,BroadcastType.nEventName> <NetworkIDLookup>k__BackingField; // 0x1E0
        public URA.woDigitYearMax<BuffersImpl> rootSceneGameObjectsBuffer; // 0x10
        public ment Initialize; // 0x18
        public object apiWorld; // 0x1E8
        public ellSize.lkitOverride _instance; // 0x20
        public int _bundleUnityMajorVersion; // 0x1F0
        public Type.ntWithType _scene; // 0x1F4
        public amut portraitCameraPositionOffset; // 0x1F8
        public R_12x12 portraitCameraRotationOffset; // 0x204

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
        public bool autoplay; // 0x20
        public bool shuffle; // 0x21
        public ector[] images; // 0x28
        public float displayDuration; // 0x30
        public atrix_Injected imageMaterial; // 0x38
        public int showingImage; // 0x40

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
        public float Gain; // 0x20
        public float Far; // 0x24
        public float Near; // 0x28
        public float VolumetricRadius; // 0x2C
        public bool EnableSpatialization; // 0x30
        public bool UseAudioSourceVolumeCurve; // 0x31
        public object Initialize;
        public t _source; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57467DC0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD57468060
        public void .ctor(){} // RVA: 0x7FFD57401C30
    }

    public class VRC_SpecialLayer : MonoBehaviour
    {
        public terUpHandler specialLayer; // 0x20

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
        public bool Repeat; // 0x20
        public float LowPeriodTime; // 0x24
        public float HighPeriodTime; // 0x28
        public bool ResetOnEnable; // 0x2C
        public string EventName; // 0x30
        public e BroadcastType; // 0x38
        public bool EventFired; // 0x3C
        public float Duration; // 0x40
        public float Timer; // 0x44
        public ellSize.ZE_LIMIT_PC Handler; // 0x48

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
        public string EnterEventName; // 0x20
        public string ExitEventName; // 0x28
        public bool TriggerIndividuals; // 0x30
        public object layers; // 0x34
        public ellSize.ZE_LIMIT_PC Handler; // 0x38
        public me CollisionEnter;
        public ta CollisionExit; // 0x8
        public int currentOccupants; // 0x40

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
        public pad RootCanvasRectTransform; // 0x20
        public 16 <RootCanvasRectTransform>k__BackingField; // 0x28
        public bool AllowFocusView; // 0x30
        public pad _uiCanvas; // 0x38
        public 16 _localRectTransform; // 0x40
        public ileFullDirectoryInformation<ellSize.?> OnUiShapeInit; // 0x8
        public ileFullDirectoryInformation<ellSize.?> OnUiShapeDestroy; // 0x10

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
        public string EventName; // 0x40
        public bool isHidden; // 0x48
        public e BroadcastType; // 0x4C
        public object UpdateUse;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5748C340
        public void Start(){} // RVA: 0x7FFD5748C580
        public void Interact(){} // RVA: 0x7FFD5748C810
        public void .ctor(){} // RVA: 0x7FFD5740E670
        public void <Awake>b__5_0(){} // RVA: 0x7FFD5748C9F0
    }

    public class VRC_VisualDamage : MonoBehaviour
    {
        public float fullDamageScale; // 0x20
        public float minDamageScale; // 0x24
        public float offset; // 0x28
        public ÍÎÌÍÍÌÌÎÏÏ curve; // 0x30
        public float currentTime; // 0x38
        public rical renderer; // 0x40
        public amut initScale; // 0x48

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
        public unt waterMode; // 0x20
        public bool disablePixelLights; // 0x24
        public int textureSize; // 0x28
        public float clipPlaneOffset; // 0x2C
        public object reflectLayers; // 0x30
        public object refractLayers; // 0x34
        public bool TurnOffWaterOcclusion; // 0x38
        public URA.DateTime<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ,ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> m_ReflectionCameras; // 0x40
        public URA.DateTime<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ,ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> m_RefractionCameras; // 0x48
        public Offset m_ReflectionTexture; // 0x50
        public Offset m_RefractionTexture; // 0x58
        public unt m_HardwareWaterSupport; // 0x60
        public int m_OldReflectionTextureSize; // 0x64
        public int m_OldRefractionTextureSize; // 0x68
        public bool s_InsideWater;

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
        public string WebRootPath; // 0x40
        public string defaultUrl; // 0x48
        public int resolutionWidth; // 0x50
        public int resolutionHeight; // 0x54
        public dRecorder displayRegion; // 0x58
        public bool interactive; // 0x68
        public atrix_Injected[] extraVideoScreens; // 0x70
        public liderExpand Initialize;
        public bool localOnly; // 0x78
        public bool syncURI; // 0x79
        public bool syncInput; // 0x7A
        public bool syncDisplayAndAudio; // 0x7B
        public BuffersImpl cursor; // 0x80
        public bool transparent; // 0x88
        public ellSize.ss station; // 0x90
        public bool cookiesEnabled; // 0x98
        public bool autoFormSubmit; // 0x99
        public URA.woDigitYearMax<ootRaycaster> webData; // 0xA0
        public ileFullDirectoryInformation<string> _NavigateTo; // 0xA8
        public ÎÌÍÏÏÌÍÏ _WebPanelForward; // 0xB0
        public ÎÌÍÏÏÌÍÏ _WebPanelBackward; // 0xB8
        public ÎÌÍÏÏÌÍÏ _WebPanelReload; // 0xC0
        public ileFullDirectoryInformation<string> _ExecuteScript; // 0xC8
        public nalInformation<string,formation,bool> _BindCall; // 0xD0

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