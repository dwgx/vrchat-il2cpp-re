// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 100

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser : ValueType
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7A7EB4370
        public void get_index(){} // RVA: 0x7A7EB4380
        public void get_id(){} // RVA: 0x7A765F070
        public void get_platformUserAccountHandle(){} // RVA: 0x7A7EB4390
        public void get_platformUserAccountName(){} // RVA: 0x7A7EB4440
        public void get_platformUserAccountId(){} // RVA: 0x7A7EB44E0
        public void get_pairedDevices(){} // RVA: 0x7A7EB4580
        public void get_lostDevices(){} // RVA: 0x7A7EB45B0
        public void get_actions(){} // RVA: 0x7A7EB46E0
        public void get_controlScheme(){} // RVA: 0x7A7EB46F0
        public void get_controlSchemeMatch(){} // RVA: 0x7A7EB4720
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7A7EB4800
        public void get_all(){} // RVA: 0x7AEC82340
        public void add_onChange(){} // RVA: 0x7AEC82420
        public void remove_onChange(){} // RVA: 0x7AEC824F0
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x7AEC825C0
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x7AEC826C0
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7AEC827D0
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7AEC828A0
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x7AEC82970
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x7AEC829D0
        public void ToString(){} // RVA: 0x7A7EB4810
        public void AssociateActionsWithUser(){} // RVA: 0x7A7EB4820
        public void ActivateControlScheme(){} // RVA: 0x7A7EB4860
        public void TryFindControlScheme(){} // RVA: 0x7A7EB4840
        public void FindControlScheme(){} // RVA: 0x7A7EB4850
        public void ActivateControlSchemeInternal(){} // RVA: 0x7A7EB4890
        public void UnpairDevice(){} // RVA: 0x7A7EB48C0
        public void UnpairDevices(){} // RVA: 0x7A7EB48D0
        public void RemoveLostDevicesForUser(){} // RVA: 0x7AEC844C0
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x7A7EB48E0
        public void GetUnpairedInputDevices(){} // RVA: 0x7AEC847F0
        public void FindUserPairedToDevice(){} // RVA: 0x7AEC84AF0
        public void FindUserByAccount(){} // RVA: 0x7AEC84C10
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x7AEC84EA0
        public void PerformPairingWithDevice(){} // RVA: 0x7AEC84F20
        public void InitiateUserAccountSelection(){} // RVA: 0x7AEC85210
        public void Equals(){} // RVA: 0x7A7EB48F0
        public void GetHashCode(){} // RVA: 0x7A765F070
        public void op_Equality(){} // RVA: 0x7A9F252F0
        public void op_Inequality(){} // RVA: 0x7AEBBA8D0
        public void AddUser(){} // RVA: 0x7AEC85550
        public void RemoveUser(){} // RVA: 0x7AEC85950
        public void Notify(){} // RVA: 0x7AEC85E90
        public void TryFindUserIndex(){} // RVA: 0x7AEC86360
        public void AddDeviceToUser(){} // RVA: 0x7AEC86520
        public void RemoveDeviceFromUser(){} // RVA: 0x7AEC86CA0
        public void UpdateControlSchemeMatch(){} // RVA: 0x7AEC87550
        public void UpdatePlatformUserAccount(){} // RVA: 0x7AEC88030
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x7AEC88870
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x7AEC88DE0
        public void OnActionChange(){} // RVA: 0x7AEC88EA0
        public void OnDeviceChange(){} // RVA: 0x7AEC88FA0
        public void FindLostDevice(){} // RVA: 0x7AEC897F0
        public void OnEvent(){} // RVA: 0x7AEC898F0
        public void SaveAndResetState(){} // RVA: 0x7AEC89F00
        public void HookIntoActionChange(){} // RVA: 0x7AEC8A500
        public void UnhookFromActionChange(){} // RVA: 0x7AEC8A780
        public void HookIntoDeviceChange(){} // RVA: 0x7AEC8A940
        public void UnhookFromDeviceChange(){} // RVA: 0x7AEC8AB00
        public void HookIntoEvents(){} // RVA: 0x7AEC8ABD0
        public void UnhookFromDeviceStateChange(){} // RVA: 0x7AEC8ADA0
        public void DisposeAndResetGlobalState(){} // RVA: 0x7AEC8AE70
        public void ResetGlobals(){} // RVA: 0x7AEC8AF70
        public void .cctor(){} // RVA: 0x7AEC8AFD0
    }

    public class InputUserAccountHandle : ValueType
    {
        // ── Methods ──
        public void get_apiName(){} // RVA: 0x7A765F710
        public void get_handle(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7EB5590
        public void ToString(){} // RVA: 0x7A7EB55A0
        public void Equals(){} // RVA: 0x7A7EB55D0
        public void op_Equality(){} // RVA: 0x7AEC8B9D0
        public void op_Inequality(){} // RVA: 0x7AEC8B9F0
        public void GetHashCode(){} // RVA: 0x7A7EB5670
    }

    public class InputUserSettings : Object
    {
        // ── Methods ──
        public void get_customBindings(){} // RVA: 0x7A80F2570
        public void set_customBindings(){} // RVA: 0x7A80D8E20
        public void get_invertMouseX(){} // RVA: 0x7A80F26D0
        public void set_invertMouseX(){} // RVA: 0x7A80F26E0
        public void get_invertMouseY(){} // RVA: 0x7A8475E20
        public void set_invertMouseY(){} // RVA: 0x7A8D0E640
        public void get_mouseSmoothing(){} // RVA: 0x7AE2450C0
        public void set_mouseSmoothing(){} // RVA: 0x7AE2450D0
        public void get_mouseSensitivity(){} // RVA: 0x7AEC8BA60
        public void set_mouseSensitivity(){} // RVA: 0x7AEC8BA70
        public void get_invertStickX(){} // RVA: 0x7A81B7080
        public void set_invertStickX(){} // RVA: 0x7A81B7090
        public void get_invertStickY(){} // RVA: 0x7A8ABD450
        public void set_invertStickY(){} // RVA: 0x7A9A784C0
        public void get_swapSticks(){} // RVA: 0x7A9A77500
        public void set_swapSticks(){} // RVA: 0x7A9A76C50
        public void get_swapBumpers(){} // RVA: 0x7A9A774F0
        public void set_swapBumpers(){} // RVA: 0x7A9A7A2C0
        public void get_swapTriggers(){} // RVA: 0x7A80FD690
        public void set_swapTriggers(){} // RVA: 0x7A80FD6A0
        public void get_swapDpadAndLeftStick(){} // RVA: 0x7A80FD6B0
        public void set_swapDpadAndLeftStick(){} // RVA: 0x7A80FD6C0
        public void get_vibrationStrength(){} // RVA: 0x7A81A2250
        public void set_vibrationStrength(){} // RVA: 0x7A81A2260
        public void Apply(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
        public void <customBindings>k__BackingField(){} // RVA: 0x7B3FAD6B8
    }

}