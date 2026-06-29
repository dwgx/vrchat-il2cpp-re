// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 99

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser : ValueType
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x935E40
        public void get_index(){} // RVA: 0x935E50
        public void get_id(){} // RVA: 0x77E60
        public void get_platformUserAccountHandle(){} // RVA: 0x935E60
        public void get_platformUserAccountName(){} // RVA: 0x935F10
        public void get_platformUserAccountId(){} // RVA: 0x935FB0
        public void get_pairedDevices(){} // RVA: 0x936050
        public void get_lostDevices(){} // RVA: 0x936080
        public void get_actions(){} // RVA: 0x9361B0
        public void get_controlScheme(){} // RVA: 0x9361C0
        public void get_controlSchemeMatch(){} // RVA: 0x9361F0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x9362D0
        public void get_all(){} // RVA: 0x78F00E0
        public void add_onChange(){} // RVA: 0x78F01C0
        public void remove_onChange(){} // RVA: 0x78F0290
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x78F0360
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x78F0460
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x78F0570
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x78F0640
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x78F0710
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x78F0770
        public void ToString(){} // RVA: 0x9362E0
        public void AssociateActionsWithUser(){} // RVA: 0x9362F0
        public void ActivateControlScheme(){} // RVA: 0x936330
        public void TryFindControlScheme(){} // RVA: 0x936310
        public void FindControlScheme(){} // RVA: 0x936320
        public void ActivateControlSchemeInternal(){} // RVA: 0x936360
        public void UnpairDevice(){} // RVA: 0x936390
        public void UnpairDevices(){} // RVA: 0x9363A0
        public void RemoveLostDevicesForUser(){} // RVA: 0x78F2220
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x9363B0
        public void GetUnpairedInputDevices(){} // RVA: 0x78F2550
        public void FindUserPairedToDevice(){} // RVA: 0x78F2850
        public void FindUserByAccount(){} // RVA: 0x78F2970
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x78F2C90
        public void PerformPairingWithDevice(){} // RVA: 0x78F2D10
        public void InitiateUserAccountSelection(){} // RVA: 0x78F3000
        public void Equals(){} // RVA: 0x9363C0
        public void GetHashCode(){} // RVA: 0x77E60
        public void op_Equality(){} // RVA: 0x2AFE580
        public void op_Inequality(){} // RVA: 0x782A060
        public void AddUser(){} // RVA: 0x78F3340
        public void RemoveUser(){} // RVA: 0x78F3740
        public void Notify(){} // RVA: 0x78F3C80
        public void TryFindUserIndex(){} // RVA: 0x78F4150
        public void AddDeviceToUser(){} // RVA: 0x78F4310
        public void RemoveDeviceFromUser(){} // RVA: 0x78F4A90
        public void UpdateControlSchemeMatch(){} // RVA: 0x78F5340
        public void UpdatePlatformUserAccount(){} // RVA: 0x78F5E20
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x78F66F0
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x78F6C60
        public void OnActionChange(){} // RVA: 0x78F6D20
        public void OnDeviceChange(){} // RVA: 0x78F6E20
        public void FindLostDevice(){} // RVA: 0x78F7670
        public void OnEvent(){} // RVA: 0x78F7770
        public void SaveAndResetState(){} // RVA: 0x78F7D80
        public void HookIntoActionChange(){} // RVA: 0x78F8380
        public void UnhookFromActionChange(){} // RVA: 0x78F8600
        public void HookIntoDeviceChange(){} // RVA: 0x78F87C0
        public void UnhookFromDeviceChange(){} // RVA: 0x78F8980
        public void HookIntoEvents(){} // RVA: 0x78F8A50
        public void UnhookFromDeviceStateChange(){} // RVA: 0x78F8C20
        public void DisposeAndResetGlobalState(){} // RVA: 0x78F8CF0
        public void ResetGlobals(){} // RVA: 0x78F8DF0
        public void .cctor(){} // RVA: 0x78F8E50
    }

    public class InputUserAccountHandle : ValueType
    {
        // ── Methods ──
        public void get_apiName(){} // RVA: 0x77900
        public void get_handle(){} // RVA: 0x77ED0
        public void .ctor(){} // RVA: 0x937210
        public void ToString(){} // RVA: 0x937220
        public void Equals(){} // RVA: 0x937250
        public void op_Equality(){} // RVA: 0x78F99C0
        public void op_Inequality(){} // RVA: 0x78F99E0
        public void GetHashCode(){} // RVA: 0x9372F0
    }

    public class InputUserSettings : Object
    {
        // ── Methods ──
        public void get_customBindings(){} // RVA: 0xB5DBF0
        public void set_customBindings(){} // RVA: 0xB44D60
        public void get_invertMouseX(){} // RVA: 0xB5DD50
        public void set_invertMouseX(){} // RVA: 0xB5DD60
        public void get_invertMouseY(){} // RVA: 0xF43F30
        public void set_invertMouseY(){} // RVA: 0x17F4D80
        public void get_mouseSmoothing(){} // RVA: 0x6EC7850
        public void set_mouseSmoothing(){} // RVA: 0x6EC7860
        public void get_mouseSensitivity(){} // RVA: 0x78F9A50
        public void set_mouseSensitivity(){} // RVA: 0x78F9A60
        public void get_invertStickX(){} // RVA: 0xC27380
        public void set_invertStickX(){} // RVA: 0xC27390
        public void get_invertStickY(){} // RVA: 0xD96880
        public void set_invertStickY(){} // RVA: 0xD95180
        public void get_swapSticks(){} // RVA: 0xD974C0
        public void set_swapSticks(){} // RVA: 0xD953E0
        public void get_swapBumpers(){} // RVA: 0xD96F70
        public void set_swapBumpers(){} // RVA: 0xD95170
        public void get_swapTriggers(){} // RVA: 0xB68DF0
        public void set_swapTriggers(){} // RVA: 0xB68E00
        public void get_swapDpadAndLeftStick(){} // RVA: 0xB68E10
        public void set_swapDpadAndLeftStick(){} // RVA: 0xB68E20
        public void get_vibrationStrength(){} // RVA: 0xC120F0
        public void set_vibrationStrength(){} // RVA: 0xC12100
        public void Apply(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

}