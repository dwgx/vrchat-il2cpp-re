// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 105

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser : ValueType
    {
        public object k_InputCheckForUnpairMarker; // 0x33C07210
        public object pairingStateVersion; // 0x83E601B0

        // ── Original Methods ──
        public void get_valid(){} // RVA: 0x7ffaaf05da70
        public void get_index(){} // RVA: 0x7ffaaf05db40
        public void get_id(){} // RVA: 0x7ffaa9e47550
        public void get_platformUserAccountHandle(){} // RVA: 0x7ffaaf05dd20
        public void get_platformUserAccountName(){} // RVA: 0x7ffaaf05ddd0
        public void get_platformUserAccountId(){} // RVA: 0x7ffaaf05de70
        public void get_pairedDevices(){} // RVA: 0x7ffaaf05df10
        public void get_lostDevices(){} // RVA: 0x7ffaaf05e040
        public void get_actions(){} // RVA: 0x7ffaaf05e170
        public void get_controlScheme(){} // RVA: 0x7ffaaf05e210
        public void get_controlSchemeMatch(){} // RVA: 0x7ffaaf05e2c0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7ffaaf05e3a0
        public void get_all(){} // RVA: 0x7ffaaf05e440
        public void add_onChange(){} // RVA: 0x7ffaaf05e520
        public void remove_onChange(){} // RVA: 0x7ffaaf05e5f0
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x7ffaaf05e6c0
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x7ffaaf05e7c0
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7ffaaf05e8d0
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7ffaaf05e9a0
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x7ffaaf05ea70
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x7ffaaf05ead0
        public void ToString(){} // RVA: 0x7ffaaf05ec10
        public void AssociateActionsWithUser(){} // RVA: 0x7ffaaf05efd0
        public void ActivateControlScheme(){} // RVA: 0x7ffaaf05f9f0
        public void TryFindControlScheme(){} // RVA: 0x7ffaaf05f450
        public void FindControlScheme(){} // RVA: 0x7ffaaf05f8d0
        public void ActivateControlScheme(){} // RVA: 0x7ffaaf05f9f0
        public void ActivateControlSchemeInternal(){} // RVA: 0x7ffaaf05fc00
        public void UnpairDevice(){} // RVA: 0x7ffaaf0601b0
        public void UnpairDevices(){} // RVA: 0x7ffaaf0602d0
        public void RemoveLostDevicesForUser(){} // RVA: 0x7ffaaf060570
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x7ffaaf0607c0
        public void FindUserPairedToDevice(){} // RVA: 0x7ffaaf060c00
        public void FindUserByAccount(){} // RVA: 0x7ffaaf060d20
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x7ffaaf060fa0
        public void PerformPairingWithDevice(){} // RVA: 0x7ffaaf061020
        public void InitiateUserAccountSelection(){} // RVA: 0x7ffaaf061310
        public void Equals(){} // RVA: 0x7ffaaf0615b0
        public void Equals(){} // RVA: 0x7ffaaf0615b0
        public void op_Equality(){} // RVA: 0x7ffaaad105c0
        public void op_Inequality(){} // RVA: 0x7ffaaef86530
        public void AddUser(){} // RVA: 0x7ffaaf061650
        public void RemoveUser(){} // RVA: 0x7ffaaf061a40
        public void Notify(){} // RVA: 0x7ffaaf061f70
        public void TryFindUserIndex(){} // RVA: 0x7ffaaf062430
        public void TryFindUserIndex(){} // RVA: 0x7ffaaf062430
        public void TryFindUserIndex(){} // RVA: 0x7ffaaf062430
        public void AddDeviceToUser(){} // RVA: 0x7ffaaf0625f0
        public void RemoveDeviceFromUser(){} // RVA: 0x7ffaaf062da0
        public void UpdateControlSchemeMatch(){} // RVA: 0x7ffaaf063660
        public void UpdatePlatformUserAccount(){} // RVA: 0x7ffaaf0640e0
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x7ffaaf064920
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x7ffaaf064e60
        public void OnActionChange(){} // RVA: 0x7ffaaf064f20
        public void OnDeviceChange(){} // RVA: 0x7ffaaf065020
        public void FindLostDevice(){} // RVA: 0x7ffaaf065900
        public void OnEvent(){} // RVA: 0x7ffaaf0659f0
        public void SaveAndResetState(){} // RVA: 0x7ffaaf065fc0
        public void HookIntoActionChange(){} // RVA: 0x7ffaaf0665d0
        public void UnhookFromActionChange(){} // RVA: 0x7ffaaf066850
        public void HookIntoDeviceChange(){} // RVA: 0x7ffaaf066a10
        public void UnhookFromDeviceChange(){} // RVA: 0x7ffaaf066bd0
        public void HookIntoEvents(){} // RVA: 0x7ffaaf066ca0
        public void UnhookFromDeviceStateChange(){} // RVA: 0x7ffaaf066e70
        public void DisposeAndResetGlobalState(){} // RVA: 0x7ffaaf066f40
        public void ResetGlobals(){} // RVA: 0x7ffaaf067040
        public void .cctor(){} // RVA: 0x7ffaaf0670a0
        // ── Binary Analysis Named ──
        public void GetUnpairedInputDevices(){} // RVA: 0x7ffaaf0608b0
        public void GetUnpairedInputDevices(){} // RVA: 0x7ffaaf0608b0
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class InputUserAccountHandle : ValueType
    {
        public object hasValue; // 0x317CCE98

        // ── Original Methods ──
        public void get_apiName(){} // RVA: 0x7ffaa950bda0
        public void get_handle(){} // RVA: 0x7ffaa9e47540
        public void .ctor(){} // RVA: 0x7ffaaf067720
        public void ToString(){} // RVA: 0x7ffaaf0677e0
        public void Equals(){} // RVA: 0x7ffaaf067a00
        public void Equals(){} // RVA: 0x7ffaaf067a00
        public void op_Equality(){} // RVA: 0x7ffaaf067aa0
        public void op_Inequality(){} // RVA: 0x7ffaaf067ac0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf067ae0
    }

    public class InputUserSettings : Object
    {
        public object _invertMouseY; // 0x33CC6D70, was: <invertMouseY>k__BackingField
        public object _invertStickX; // 0x33CC6D70, was: <invertStickX>k__BackingField
        public object _swapBumpers; // 0x33CC6D70, was: <swapBumpers>k__BackingField
        public object _vibrationStrength; // 0x33CC6D70, was: <vibrationStrength>k__BackingF

        // ── Original Methods ──
        public void get_customBindings(){} // RVA: 0x7ffaa894d380
        public void set_customBindings(){} // RVA: 0x7ffaa8933e30
        public void get_invertMouseX(){} // RVA: 0x7ffaa894d4e0
        public void set_invertMouseX(){} // RVA: 0x7ffaa894d4f0
        public void get_invertMouseY(){} // RVA: 0x7ffaa8c53420
        public void set_invertMouseY(){} // RVA: 0x7ffaa8f41f20
        public void get_mouseSmoothing(){} // RVA: 0x7ffaae60f5e0
        public void set_mouseSmoothing(){} // RVA: 0x7ffaae60f5f0
        public void get_mouseSensitivity(){} // RVA: 0x7ffaaf067b30
        public void set_mouseSensitivity(){} // RVA: 0x7ffaaf067b40
        public void get_invertStickX(){} // RVA: 0x7ffaa8a11230
        public void set_invertStickX(){} // RVA: 0x7ffaa8a11240
        public void get_invertStickY(){} // RVA: 0x7ffaa9357fe0
        public void set_invertStickY(){} // RVA: 0x7ffaaa14f600
        public void get_swapSticks(){} // RVA: 0x7ffaaa1516c0
        public void set_swapSticks(){} // RVA: 0x7ffaaa151870
        public void get_swapBumpers(){} // RVA: 0x7ffaaa152130
        public void set_swapBumpers(){} // RVA: 0x7ffaaa1518d0
        public void get_swapTriggers(){} // RVA: 0x7ffaa8958450
        public void set_swapTriggers(){} // RVA: 0x7ffaa8958460
        public void get_swapDpadAndLeftStick(){} // RVA: 0x7ffaa8958470
        public void set_swapDpadAndLeftStick(){} // RVA: 0x7ffaa8958480
        public void get_vibrationStrength(){} // RVA: 0x7ffaa89fc630
        public void set_vibrationStrength(){} // RVA: 0x7ffaa89fc640
        public void Apply(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}