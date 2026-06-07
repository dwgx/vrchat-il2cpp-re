// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 105

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x6EA3340
        public void get_index(){} // RVA: 0x6EA3410
        public void get_id(){} // RVA: 0x19689B0
        public void get_platformUserAccountHandle(){} // RVA: 0x6EA35F0
        public void get_platformUserAccountName(){} // RVA: 0x6EA36A0
        public void get_platformUserAccountId(){} // RVA: 0x6EA3740
        public void get_pairedDevices(){} // RVA: 0x6EA37E0
        public void get_lostDevices(){} // RVA: 0x6EA3910
        public void get_actions(){} // RVA: 0x6EA3A40
        public void get_controlScheme(){} // RVA: 0x6EA3AE0
        public void get_controlSchemeMatch(){} // RVA: 0x6EA3B90
        public void get_hasMissingRequiredDevices(){} // RVA: 0x6EA3C70
        public void get_all(){} // RVA: 0x6EA3D10
        public void add_onChange(){} // RVA: 0x6EA3DF0
        public void remove_onChange(){} // RVA: 0x6EA3EC0
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x6EA3F90
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x6EA4090
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x6EA41A0
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x6EA4270
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x6EA4340
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x6EA43A0
        public void ToString(){} // RVA: 0x6EA44E0
        public void AssociateActionsWithUser(){} // RVA: 0x6EA48A0
        public void ActivateControlScheme(){} // RVA: 0x6EA52C0 | overloaded x2
        public void TryFindControlScheme(){} // RVA: 0x6EA4D20
        public void FindControlScheme(){} // RVA: 0x6EA51A0
        public void ActivateControlSchemeInternal(){} // RVA: 0x6EA54D0
        public void UnpairDevice(){} // RVA: 0x6EA5A80
        public void UnpairDevices(){} // RVA: 0x6EA5BA0
        public void RemoveLostDevicesForUser(){} // RVA: 0x6EA5E40
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x6EA6090
        public void GetUnpairedInputDevices(){} // RVA: 0x6EA6180 | overloaded x2
        public void FindUserPairedToDevice(){} // RVA: 0x6EA64D0
        public void FindUserByAccount(){} // RVA: 0x6EA65F0
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x6EA6870
        public void PerformPairingWithDevice(){} // RVA: 0x6EA68F0
        public void InitiateUserAccountSelection(){} // RVA: 0x6EA6BE0
        public void Equals(){} // RVA: 0x6EA6E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
        public void op_Equality(){} // RVA: 0x2110AC0
        public void op_Inequality(){} // RVA: 0x6DCBE00
        public void AddUser(){} // RVA: 0x6EA6F20
        public void RemoveUser(){} // RVA: 0x6EA7310
        public void Notify(){} // RVA: 0x6EA7840
        public void TryFindUserIndex(){} // RVA: 0x6EA7D00 | overloaded x3
        public void AddDeviceToUser(){} // RVA: 0x6EA7EC0
        public void RemoveDeviceFromUser(){} // RVA: 0x6EA8670
        public void UpdateControlSchemeMatch(){} // RVA: 0x6EA8F30
        public void UpdatePlatformUserAccount(){} // RVA: 0x6EA99B0
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x6EAA1F0
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x6EAA730
        public void OnActionChange(){} // RVA: 0x6EAA7F0
        public void OnDeviceChange(){} // RVA: 0x6EAA8F0
        public void FindLostDevice(){} // RVA: 0x6EAB1D0
        public void OnEvent(){} // RVA: 0x6EAB2C0
        public void SaveAndResetState(){} // RVA: 0x6EAB890
        public void HookIntoActionChange(){} // RVA: 0x6EABEA0
        public void UnhookFromActionChange(){} // RVA: 0x6EAC120
        public void HookIntoDeviceChange(){} // RVA: 0x6EAC2E0
        public void UnhookFromDeviceChange(){} // RVA: 0x6EAC4A0
        public void HookIntoEvents(){} // RVA: 0x6EAC570
        public void UnhookFromDeviceStateChange(){} // RVA: 0x6EAC740
        public void DisposeAndResetGlobalState(){} // RVA: 0x6EAC810
        public void ResetGlobals(){} // RVA: 0x6EAC910
        public void .cctor(){} // RVA: 0x6EAC970
    }

    public class InputUserAccountHandle
    {
        // ── Methods ──
        public void get_apiName(){} // RVA: 0x1AD4690
        public void get_handle(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x6EACFF0
        public void ToString(){} // RVA: 0x6EAD0B0
        public void Equals(){} // RVA: 0x6EAD2D0 | overloaded x2
        public void op_Equality(){} // RVA: 0x6EAD370
        public void op_Inequality(){} // RVA: 0x6EAD390
        public void GetHashCode(){} // RVA: 0x6EAD3B0
    }

    public class InputUserSettings
    {
        // ── Methods ──
        public void get_customBindings(){} // RVA: 0x2F8380
        public void set_customBindings(){} // RVA: 0x2DEE30
        public void get_invertMouseX(){} // RVA: 0x2F84E0
        public void set_invertMouseX(){} // RVA: 0x2F84F0
        public void get_invertMouseY(){} // RVA: 0x6B93D0
        public void set_invertMouseY(){} // RVA: 0xF43D70
        public void get_mouseSmoothing(){} // RVA: 0x6457060
        public void set_mouseSmoothing(){} // RVA: 0x6457070
        public void get_mouseSensitivity(){} // RVA: 0x6EAD400
        public void set_mouseSensitivity(){} // RVA: 0x6EAD410
        public void get_invertStickX(){} // RVA: 0x3BC230
        public void set_invertStickX(){} // RVA: 0x3BC240
        public void get_invertStickY(){} // RVA: 0x4FDE20
        public void set_invertStickY(){} // RVA: 0x4FC950
        public void get_swapSticks(){} // RVA: 0x4FB980
        public void set_swapSticks(){} // RVA: 0x4FB0C0
        public void get_swapBumpers(){} // RVA: 0x4FB960
        public void set_swapBumpers(){} // RVA: 0x4FE7C0
        public void get_swapTriggers(){} // RVA: 0x303450
        public void set_swapTriggers(){} // RVA: 0x303460
        public void get_swapDpadAndLeftStick(){} // RVA: 0x303470
        public void set_swapDpadAndLeftStick(){} // RVA: 0x303480
        public void get_vibrationStrength(){} // RVA: 0x3A7630
        public void set_vibrationStrength(){} // RVA: 0x3A7640
        public void Apply(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
    }

}