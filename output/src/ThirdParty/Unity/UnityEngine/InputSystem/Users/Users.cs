// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 105

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAF9953340
        public void get_index(){} // RVA: 0x7FFAF9953410
        public void get_id(){} // RVA: 0x7FFAF44189B0
        public void get_platformUserAccountHandle(){} // RVA: 0x7FFAF99535F0
        public void get_platformUserAccountName(){} // RVA: 0x7FFAF99536A0
        public void get_platformUserAccountId(){} // RVA: 0x7FFAF9953740
        public void get_pairedDevices(){} // RVA: 0x7FFAF99537E0
        public void get_lostDevices(){} // RVA: 0x7FFAF9953910
        public void get_actions(){} // RVA: 0x7FFAF9953A40
        public void get_controlScheme(){} // RVA: 0x7FFAF9953AE0
        public void get_controlSchemeMatch(){} // RVA: 0x7FFAF9953B90
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFAF9953C70
        public void get_all(){} // RVA: 0x7FFAF9953D10
        public void add_onChange(){} // RVA: 0x7FFAF9953DF0
        public void remove_onChange(){} // RVA: 0x7FFAF9953EC0
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x7FFAF9953F90
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x7FFAF9954090
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFAF99541A0
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFAF9954270
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFAF9954340
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFAF99543A0
        public void ToString(){} // RVA: 0x7FFAF99544E0
        public void AssociateActionsWithUser(){} // RVA: 0x7FFAF99548A0
        public void ActivateControlScheme(){} // RVA: 0x7FFAF99552C0 | overloaded x2
        public void TryFindControlScheme(){} // RVA: 0x7FFAF9954D20
        public void FindControlScheme(){} // RVA: 0x7FFAF99551A0
        public void ActivateControlSchemeInternal(){} // RVA: 0x7FFAF99554D0
        public void UnpairDevice(){} // RVA: 0x7FFAF9955A80
        public void UnpairDevices(){} // RVA: 0x7FFAF9955BA0
        public void RemoveLostDevicesForUser(){} // RVA: 0x7FFAF9955E40
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x7FFAF9956090
        public void GetUnpairedInputDevices(){} // RVA: 0x7FFAF9956180 | overloaded x2
        public void FindUserPairedToDevice(){} // RVA: 0x7FFAF99564D0
        public void FindUserByAccount(){} // RVA: 0x7FFAF99565F0
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x7FFAF9956870
        public void PerformPairingWithDevice(){} // RVA: 0x7FFAF99568F0
        public void InitiateUserAccountSelection(){} // RVA: 0x7FFAF9956BE0
        public void Equals(){} // RVA: 0x7FFAF9956E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
        public void op_Equality(){} // RVA: 0x7FFAF4BC0AC0
        public void op_Inequality(){} // RVA: 0x7FFAF987BE00
        public void AddUser(){} // RVA: 0x7FFAF9956F20
        public void RemoveUser(){} // RVA: 0x7FFAF9957310
        public void Notify(){} // RVA: 0x7FFAF9957840
        public void TryFindUserIndex(){} // RVA: 0x7FFAF9957D00 | overloaded x3
        public void AddDeviceToUser(){} // RVA: 0x7FFAF9957EC0
        public void RemoveDeviceFromUser(){} // RVA: 0x7FFAF9958670
        public void UpdateControlSchemeMatch(){} // RVA: 0x7FFAF9958F30
        public void UpdatePlatformUserAccount(){} // RVA: 0x7FFAF99599B0
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x7FFAF995A1F0
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x7FFAF995A730
        public void OnActionChange(){} // RVA: 0x7FFAF995A7F0
        public void OnDeviceChange(){} // RVA: 0x7FFAF995A8F0
        public void FindLostDevice(){} // RVA: 0x7FFAF995B1D0
        public void OnEvent(){} // RVA: 0x7FFAF995B2C0
        public void SaveAndResetState(){} // RVA: 0x7FFAF995B890
        public void HookIntoActionChange(){} // RVA: 0x7FFAF995BEA0
        public void UnhookFromActionChange(){} // RVA: 0x7FFAF995C120
        public void HookIntoDeviceChange(){} // RVA: 0x7FFAF995C2E0
        public void UnhookFromDeviceChange(){} // RVA: 0x7FFAF995C4A0
        public void HookIntoEvents(){} // RVA: 0x7FFAF995C570
        public void UnhookFromDeviceStateChange(){} // RVA: 0x7FFAF995C740
        public void DisposeAndResetGlobalState(){} // RVA: 0x7FFAF995C810
        public void ResetGlobals(){} // RVA: 0x7FFAF995C910
        public void .cctor(){} // RVA: 0x7FFAF995C970
    }

    public class InputUserAccountHandle
    {
        // ── Methods ──
        public void get_apiName(){} // RVA: 0x7FFAF4584690
        public void get_handle(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAF995CFF0
        public void ToString(){} // RVA: 0x7FFAF995D0B0
        public void Equals(){} // RVA: 0x7FFAF995D2D0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF995D370
        public void op_Inequality(){} // RVA: 0x7FFAF995D390
        public void GetHashCode(){} // RVA: 0x7FFAF995D3B0
    }

    public class InputUserSettings
    {
        // ── Methods ──
        public void get_customBindings(){} // RVA: 0x7FFAF2DA8380
        public void set_customBindings(){} // RVA: 0x7FFAF2D8EE30
        public void get_invertMouseX(){} // RVA: 0x7FFAF2DA84E0
        public void set_invertMouseX(){} // RVA: 0x7FFAF2DA84F0
        public void get_invertMouseY(){} // RVA: 0x7FFAF31693D0
        public void set_invertMouseY(){} // RVA: 0x7FFAF39F3D70
        public void get_mouseSmoothing(){} // RVA: 0x7FFAF8F07060
        public void set_mouseSmoothing(){} // RVA: 0x7FFAF8F07070
        public void get_mouseSensitivity(){} // RVA: 0x7FFAF995D400
        public void set_mouseSensitivity(){} // RVA: 0x7FFAF995D410
        public void get_invertStickX(){} // RVA: 0x7FFAF2E6C230
        public void set_invertStickX(){} // RVA: 0x7FFAF2E6C240
        public void get_invertStickY(){} // RVA: 0x7FFAF2FADE20
        public void set_invertStickY(){} // RVA: 0x7FFAF2FAC950
        public void get_swapSticks(){} // RVA: 0x7FFAF2FAB980
        public void set_swapSticks(){} // RVA: 0x7FFAF2FAB0C0
        public void get_swapBumpers(){} // RVA: 0x7FFAF2FAB960
        public void set_swapBumpers(){} // RVA: 0x7FFAF2FAE7C0
        public void get_swapTriggers(){} // RVA: 0x7FFAF2DB3450
        public void set_swapTriggers(){} // RVA: 0x7FFAF2DB3460
        public void get_swapDpadAndLeftStick(){} // RVA: 0x7FFAF2DB3470
        public void set_swapDpadAndLeftStick(){} // RVA: 0x7FFAF2DB3480
        public void get_vibrationStrength(){} // RVA: 0x7FFAF2E57630
        public void set_vibrationStrength(){} // RVA: 0x7FFAF2E57640
        public void Apply(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}