// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 105

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser : ValueType
    {
        public uint valid;
        public Unity.Profiling.ProfilerMarker index;
        public Unity.Profiling.ProfilerMarker id; // 0x8
        public uint platformUserAccountHandle; // 0x10
        public 0x664AA770 platformUserAccountName; // 0x10

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFD54A5BA90
        public void get_index(){} // RVA: 0x7FFD54A5BB60
        public void get_id(){} // RVA: 0x7FFD4F840210
        public void get_platformUserAccountHandle(){} // RVA: 0x7FFD54A5BD40
        public void get_platformUserAccountName(){} // RVA: 0x7FFD54A5BDF0
        public void get_platformUserAccountId(){} // RVA: 0x7FFD54A5BE90
        public void get_pairedDevices(){} // RVA: 0x7FFD54A5BF30
        public void get_lostDevices(){} // RVA: 0x7FFD54A5C060
        public void get_actions(){} // RVA: 0x7FFD54A5C190
        public void get_controlScheme(){} // RVA: 0x7FFD54A5C230
        public void get_controlSchemeMatch(){} // RVA: 0x7FFD54A5C2E0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFD54A5C3C0
        public void get_all(){} // RVA: 0x7FFD54A5C460
        public void add_onChange(){} // RVA: 0x7FFD54A5C540
        public void remove_onChange(){} // RVA: 0x7FFD54A5C610
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x7FFD54A5C6E0
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x7FFD54A5C7E0
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFD54A5C8F0
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFD54A5C9C0
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFD54A5CA90
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFD54A5CAF0
        public void ToString(){} // RVA: 0x7FFD54A5CC30
        public void AssociateActionsWithUser(){} // RVA: 0x7FFD54A5CFF0
        public void ActivateControlScheme(){} // RVA: 0x7FFD54A5DA10 | overloaded x2
        public void TryFindControlScheme(){} // RVA: 0x7FFD54A5D470
        public void FindControlScheme(){} // RVA: 0x7FFD54A5D8F0
        public void ActivateControlSchemeInternal(){} // RVA: 0x7FFD54A5DC20
        public void UnpairDevice(){} // RVA: 0x7FFD54A5E1D0
        public void UnpairDevices(){} // RVA: 0x7FFD54A5E2F0
        public void RemoveLostDevicesForUser(){} // RVA: 0x7FFD54A5E590
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x7FFD54A5E7E0
        public void GetUnpairedInputDevices(){} // RVA: 0x7FFD54A5E8D0 | overloaded x2
        public void FindUserPairedToDevice(){} // RVA: 0x7FFD54A5EC20
        public void FindUserByAccount(){} // RVA: 0x7FFD54A5ED40
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x7FFD54A5EFC0
        public void PerformPairingWithDevice(){} // RVA: 0x7FFD54A5F040
        public void InitiateUserAccountSelection(){} // RVA: 0x7FFD54A5F330
        public void Equals(){} // RVA: 0x7FFD54A5F5D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void op_Equality(){} // RVA: 0x7FFD5072E660
        public void op_Inequality(){} // RVA: 0x7FFD54984550
        public void AddUser(){} // RVA: 0x7FFD54A5F670
        public void RemoveUser(){} // RVA: 0x7FFD54A5FA60
        public void Notify(){} // RVA: 0x7FFD54A5FF90
        public void TryFindUserIndex(){} // RVA: 0x7FFD54A60450 | overloaded x3
        public void AddDeviceToUser(){} // RVA: 0x7FFD54A60610
        public void RemoveDeviceFromUser(){} // RVA: 0x7FFD54A60DC0
        public void UpdateControlSchemeMatch(){} // RVA: 0x7FFD54A61680
        public void UpdatePlatformUserAccount(){} // RVA: 0x7FFD54A62100
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x7FFD54A62940
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x7FFD54A62E80
        public void OnActionChange(){} // RVA: 0x7FFD54A62F40
        public void OnDeviceChange(){} // RVA: 0x7FFD54A63040
        public void FindLostDevice(){} // RVA: 0x7FFD54A63920
        public void OnEvent(){} // RVA: 0x7FFD54A63A10
        public void SaveAndResetState(){} // RVA: 0x7FFD54A63FE0
        public void HookIntoActionChange(){} // RVA: 0x7FFD54A645F0
        public void UnhookFromActionChange(){} // RVA: 0x7FFD54A64870
        public void HookIntoDeviceChange(){} // RVA: 0x7FFD54A64A30
        public void UnhookFromDeviceChange(){} // RVA: 0x7FFD54A64BF0
        public void HookIntoEvents(){} // RVA: 0x7FFD54A64CC0
        public void UnhookFromDeviceStateChange(){} // RVA: 0x7FFD54A64E90
        public void DisposeAndResetGlobalState(){} // RVA: 0x7FFD54A64F60
        public void ResetGlobals(){} // RVA: 0x7FFD54A65060
        public void .cctor(){} // RVA: 0x7FFD54A650C0
    }

    public class InputUserAccountHandle : ValueType
    {
        public string apiName; // 0x10
        public ulong handle; // 0x18

        // ── Methods ──
        public void get_apiName(){} // RVA: 0x7FFD4EEF9F60
        public void get_handle(){} // RVA: 0x7FFD4F840220
        public void .ctor(){} // RVA: 0x7FFD54A65740
        public void ToString(){} // RVA: 0x7FFD54A65800
        public void Equals(){} // RVA: 0x7FFD54A65A20 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54A65AC0
        public void op_Inequality(){} // RVA: 0x7FFD54A65AE0
        public void GetHashCode(){} // RVA: 0x7FFD54A65B00
    }

    public class InputUserSettings : Object
    {
        public string customBindings; // 0x10
        public bool invertMouseX; // 0x18
        public bool invertMouseY; // 0x19
        public System.Nullable`1<float> mouseSmoothing; // 0x1C
        public System.Nullable`1<float> mouseSensitivity; // 0x24
        public bool invertStickX; // 0x2C
        public bool invertStickY; // 0x2D
        public bool swapSticks; // 0x2E
        public bool swapBumpers; // 0x2F
        public bool swapTriggers; // 0x30
        public bool swapDpadAndLeftStick; // 0x31
        public float vibrationStrength; // 0x34
        public string m_CustomBindings; // 0x38

        // ── Methods ──
        public void get_customBindings(){} // RVA: 0x7FFD4E35C380
        public void set_customBindings(){} // RVA: 0x7FFD4E342E30
        public void get_invertMouseX(){} // RVA: 0x7FFD4E35C4E0
        public void set_invertMouseX(){} // RVA: 0x7FFD4E35C4F0
        public void get_invertMouseY(){} // RVA: 0x7FFD4E648D50
        public void set_invertMouseY(){} // RVA: 0x7FFD4E935120
        public void get_mouseSmoothing(){} // RVA: 0x7FFD5400E3E0
        public void set_mouseSmoothing(){} // RVA: 0x7FFD5400E3F0
        public void get_mouseSensitivity(){} // RVA: 0x7FFD54A65B50
        public void set_mouseSensitivity(){} // RVA: 0x7FFD54A65B60
        public void get_invertStickX(){} // RVA: 0x7FFD4E420230
        public void set_invertStickX(){} // RVA: 0x7FFD4E420240
        public void get_invertStickY(){} // RVA: 0x7FFD4ED4CE00
        public void set_invertStickY(){} // RVA: 0x7FFD4FB5AAD0
        public void get_swapSticks(){} // RVA: 0x7FFD4FB5C630
        public void set_swapSticks(){} // RVA: 0x7FFD4FB5BA00
        public void get_swapBumpers(){} // RVA: 0x7FFD4FB58160
        public void set_swapBumpers(){} // RVA: 0x7FFD4FB5AAC0
        public void get_swapTriggers(){} // RVA: 0x7FFD4E367450
        public void set_swapTriggers(){} // RVA: 0x7FFD4E367460
        public void get_swapDpadAndLeftStick(){} // RVA: 0x7FFD4E367470
        public void set_swapDpadAndLeftStick(){} // RVA: 0x7FFD4E367480
        public void get_vibrationStrength(){} // RVA: 0x7FFD4E40B630
        public void set_vibrationStrength(){} // RVA: 0x7FFD4E40B640
        public void Apply(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}