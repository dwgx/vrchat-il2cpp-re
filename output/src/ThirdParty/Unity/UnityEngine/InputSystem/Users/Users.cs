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
        public GlobalState platformUserAccountName; // 0x10

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAC963BA90
        public void get_index(){} // RVA: 0x7FFAC963BB60
        public void get_id(){} // RVA: 0x7FFAC4420210
        public void get_platformUserAccountHandle(){} // RVA: 0x7FFAC963BD40
        public void get_platformUserAccountName(){} // RVA: 0x7FFAC963BDF0
        public void get_platformUserAccountId(){} // RVA: 0x7FFAC963BE90
        public void get_pairedDevices(){} // RVA: 0x7FFAC963BF30
        public void get_lostDevices(){} // RVA: 0x7FFAC963C060
        public void get_actions(){} // RVA: 0x7FFAC963C190
        public void get_controlScheme(){} // RVA: 0x7FFAC963C230
        public void get_controlSchemeMatch(){} // RVA: 0x7FFAC963C2E0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFAC963C3C0
        public void get_all(){} // RVA: 0x7FFAC963C460
        public void add_onChange(){} // RVA: 0x7FFAC963C540
        public void remove_onChange(){} // RVA: 0x7FFAC963C610
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x7FFAC963C6E0
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x7FFAC963C7E0
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFAC963C8F0
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFAC963C9C0
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFAC963CA90
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFAC963CAF0
        public void ToString(){} // RVA: 0x7FFAC963CC30
        public void AssociateActionsWithUser(){} // RVA: 0x7FFAC963CFF0
        public void ActivateControlScheme(){} // RVA: 0x7FFAC963DA10 | overloaded x2
        public void TryFindControlScheme(){} // RVA: 0x7FFAC963D470
        public void FindControlScheme(){} // RVA: 0x7FFAC963D8F0
        public void ActivateControlSchemeInternal(){} // RVA: 0x7FFAC963DC20
        public void UnpairDevice(){} // RVA: 0x7FFAC963E1D0
        public void UnpairDevices(){} // RVA: 0x7FFAC963E2F0
        public void RemoveLostDevicesForUser(){} // RVA: 0x7FFAC963E590
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x7FFAC963E7E0
        public void GetUnpairedInputDevices(){} // RVA: 0x7FFAC963E8D0 | overloaded x2
        public void FindUserPairedToDevice(){} // RVA: 0x7FFAC963EC20
        public void FindUserByAccount(){} // RVA: 0x7FFAC963ED40
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x7FFAC963EFC0
        public void PerformPairingWithDevice(){} // RVA: 0x7FFAC963F040
        public void InitiateUserAccountSelection(){} // RVA: 0x7FFAC963F330
        public void Equals(){} // RVA: 0x7FFAC963F5D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void op_Equality(){} // RVA: 0x7FFAC530E660
        public void op_Inequality(){} // RVA: 0x7FFAC9564550
        public void AddUser(){} // RVA: 0x7FFAC963F670
        public void RemoveUser(){} // RVA: 0x7FFAC963FA60
        public void Notify(){} // RVA: 0x7FFAC963FF90
        public void TryFindUserIndex(){} // RVA: 0x7FFAC9640450 | overloaded x3
        public void AddDeviceToUser(){} // RVA: 0x7FFAC9640610
        public void RemoveDeviceFromUser(){} // RVA: 0x7FFAC9640DC0
        public void UpdateControlSchemeMatch(){} // RVA: 0x7FFAC9641680
        public void UpdatePlatformUserAccount(){} // RVA: 0x7FFAC9642100
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x7FFAC9642940
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x7FFAC9642E80
        public void OnActionChange(){} // RVA: 0x7FFAC9642F40
        public void OnDeviceChange(){} // RVA: 0x7FFAC9643040
        public void FindLostDevice(){} // RVA: 0x7FFAC9643920
        public void OnEvent(){} // RVA: 0x7FFAC9643A10
        public void SaveAndResetState(){} // RVA: 0x7FFAC9643FE0
        public void HookIntoActionChange(){} // RVA: 0x7FFAC96445F0
        public void UnhookFromActionChange(){} // RVA: 0x7FFAC9644870
        public void HookIntoDeviceChange(){} // RVA: 0x7FFAC9644A30
        public void UnhookFromDeviceChange(){} // RVA: 0x7FFAC9644BF0
        public void HookIntoEvents(){} // RVA: 0x7FFAC9644CC0
        public void UnhookFromDeviceStateChange(){} // RVA: 0x7FFAC9644E90
        public void DisposeAndResetGlobalState(){} // RVA: 0x7FFAC9644F60
        public void ResetGlobals(){} // RVA: 0x7FFAC9645060
        public void .cctor(){} // RVA: 0x7FFAC96450C0
    }

    public class InputUserAccountHandle : ValueType
    {
        public string apiName; // 0x10
        public ulong handle; // 0x18

        // ── Methods ──
        public void get_apiName(){} // RVA: 0x7FFAC3AD9F60
        public void get_handle(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC9645740
        public void ToString(){} // RVA: 0x7FFAC9645800
        public void Equals(){} // RVA: 0x7FFAC9645A20 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9645AC0
        public void op_Inequality(){} // RVA: 0x7FFAC9645AE0
        public void GetHashCode(){} // RVA: 0x7FFAC9645B00
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
        public void get_customBindings(){} // RVA: 0x7FFAC2F3C380
        public void set_customBindings(){} // RVA: 0x7FFAC2F22E30
        public void get_invertMouseX(){} // RVA: 0x7FFAC2F3C4E0
        public void set_invertMouseX(){} // RVA: 0x7FFAC2F3C4F0
        public void get_invertMouseY(){} // RVA: 0x7FFAC3228D50
        public void set_invertMouseY(){} // RVA: 0x7FFAC3515120
        public void get_mouseSmoothing(){} // RVA: 0x7FFAC8BEE3E0
        public void set_mouseSmoothing(){} // RVA: 0x7FFAC8BEE3F0
        public void get_mouseSensitivity(){} // RVA: 0x7FFAC9645B50
        public void set_mouseSensitivity(){} // RVA: 0x7FFAC9645B60
        public void get_invertStickX(){} // RVA: 0x7FFAC3000230
        public void set_invertStickX(){} // RVA: 0x7FFAC3000240
        public void get_invertStickY(){} // RVA: 0x7FFAC392CE00
        public void set_invertStickY(){} // RVA: 0x7FFAC473AAD0
        public void get_swapSticks(){} // RVA: 0x7FFAC473C630
        public void set_swapSticks(){} // RVA: 0x7FFAC473BA00
        public void get_swapBumpers(){} // RVA: 0x7FFAC4738160
        public void set_swapBumpers(){} // RVA: 0x7FFAC473AAC0
        public void get_swapTriggers(){} // RVA: 0x7FFAC2F47450
        public void set_swapTriggers(){} // RVA: 0x7FFAC2F47460
        public void get_swapDpadAndLeftStick(){} // RVA: 0x7FFAC2F47470
        public void set_swapDpadAndLeftStick(){} // RVA: 0x7FFAC2F47480
        public void get_vibrationStrength(){} // RVA: 0x7FFAC2FEB630
        public void set_vibrationStrength(){} // RVA: 0x7FFAC2FEB640
        public void Apply(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}