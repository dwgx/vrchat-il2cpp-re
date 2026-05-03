// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Users
// Classes: 3
// Methods: 105

namespace ThirdParty.Unity.UnityEngine.InputSystem.Users
{
    public class InputUser : ValueType
    {
        public uint InvalidId;
        public Unity.Profiling.ProfilerMarker k_InputUserOnChangeMarker;
        public Unity.Profiling.ProfilerMarker k_InputCheckForUnpairMarker; // 0x8
        public uint m_Id; // 0x10
        public GlobalState s_GlobalState; // 0x10
        public int pairingStateVersion; // 0x10
        public uint lastUserId; // 0x14
        public int allUserCount; // 0x18
        public int allPairedDeviceCount; // 0x1C
        public int allLostDeviceCount; // 0x20
        public UnityEngine.InputSystem.Users.InputUser[] allUsers; // 0x28
        public UserData[] allUserData; // 0x30
        public UnityEngine.InputSystem.InputDevice[] allPairedDevices; // 0x38
        public UnityEngine.InputSystem.InputDevice[] allLostDevices; // 0x40

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFE879E41D0
        public void get_index(){} // RVA: 0x7FFE879E42A0
        public void get_id(){} // RVA: 0x7FFE826F4220
        public void get_platformUserAccountHandle(){} // RVA: 0x7FFE879E4480
        public void get_platformUserAccountName(){} // RVA: 0x7FFE879E4530
        public void get_platformUserAccountId(){} // RVA: 0x7FFE879E45D0
        public void get_pairedDevices(){} // RVA: 0x7FFE879E4670
        public void get_lostDevices(){} // RVA: 0x7FFE879E47A0
        public void get_actions(){} // RVA: 0x7FFE879E48D0
        public void get_controlScheme(){} // RVA: 0x7FFE879E4970
        public void get_controlSchemeMatch(){} // RVA: 0x7FFE879E4A20
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFE879E4B00
        public void get_all(){} // RVA: 0x7FFE879E4BA0
        public void add_onChange(){} // RVA: 0x7FFE879E4C80
        public void remove_onChange(){} // RVA: 0x7FFE879E4D50
        public void add_onUnpairedDeviceUsed(){} // RVA: 0x7FFE879E4E20
        public void remove_onUnpairedDeviceUsed(){} // RVA: 0x7FFE879E4F20
        public void add_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFE879E5030
        public void remove_onPrefilterUnpairedDeviceActivity(){} // RVA: 0x7FFE879E5100
        public void get_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFE879E51D0
        public void set_listenForUnpairedDeviceActivity(){} // RVA: 0x7FFE879E5230
        public void ToString(){} // RVA: 0x7FFE879E5370
        public void AssociateActionsWithUser(){} // RVA: 0x7FFE879E5730
        public void ActivateControlScheme(){} // RVA: 0x7FFE879E6150 | overloaded x2
        public void TryFindControlScheme(){} // RVA: 0x7FFE879E5BB0
        public void FindControlScheme(){} // RVA: 0x7FFE879E6030
        public void ActivateControlSchemeInternal(){} // RVA: 0x7FFE879E6360
        public void UnpairDevice(){} // RVA: 0x7FFE879E6910
        public void UnpairDevices(){} // RVA: 0x7FFE879E6A30
        public void RemoveLostDevicesForUser(){} // RVA: 0x7FFE879E6CD0
        public void UnpairDevicesAndRemoveUser(){} // RVA: 0x7FFE879E6F20
        public void GetUnpairedInputDevices(){} // RVA: 0x7FFE879E7010 | overloaded x2
        public void FindUserPairedToDevice(){} // RVA: 0x7FFE879E7360
        public void FindUserByAccount(){} // RVA: 0x7FFE879E7480
        public void CreateUserWithoutPairedDevices(){} // RVA: 0x7FFE879E7700
        public void PerformPairingWithDevice(){} // RVA: 0x7FFE879E7780
        public void InitiateUserAccountSelection(){} // RVA: 0x7FFE879E7A70
        public void Equals(){} // RVA: 0x7FFE879E7D10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void op_Equality(){} // RVA: 0x7FFE835C4F30
        public void op_Inequality(){} // RVA: 0x7FFE8790CC90
        public void AddUser(){} // RVA: 0x7FFE879E7DB0
        public void RemoveUser(){} // RVA: 0x7FFE879E81A0
        public void Notify(){} // RVA: 0x7FFE879E86D0
        public void TryFindUserIndex(){} // RVA: 0x7FFE879E8B90 | overloaded x3
        public void AddDeviceToUser(){} // RVA: 0x7FFE879E8D50
        public void RemoveDeviceFromUser(){} // RVA: 0x7FFE879E9500
        public void UpdateControlSchemeMatch(){} // RVA: 0x7FFE879E9DC0
        public void UpdatePlatformUserAccount(){} // RVA: 0x7FFE879EA840
        public void QueryPairedPlatformUserAccount(){} // RVA: 0x7FFE879EB080
        public void InitiateUserAccountSelectionAtPlatformLevel(){} // RVA: 0x7FFE879EB5C0
        public void OnActionChange(){} // RVA: 0x7FFE879EB680
        public void OnDeviceChange(){} // RVA: 0x7FFE879EB780
        public void FindLostDevice(){} // RVA: 0x7FFE879EC060
        public void OnEvent(){} // RVA: 0x7FFE879EC150
        public void SaveAndResetState(){} // RVA: 0x7FFE879EC720
        public void HookIntoActionChange(){} // RVA: 0x7FFE879ECD30
        public void UnhookFromActionChange(){} // RVA: 0x7FFE879ECFB0
        public void HookIntoDeviceChange(){} // RVA: 0x7FFE879ED170
        public void UnhookFromDeviceChange(){} // RVA: 0x7FFE879ED330
        public void HookIntoEvents(){} // RVA: 0x7FFE879ED400
        public void UnhookFromDeviceStateChange(){} // RVA: 0x7FFE879ED5D0
        public void DisposeAndResetGlobalState(){} // RVA: 0x7FFE879ED6A0
        public void ResetGlobals(){} // RVA: 0x7FFE879ED7A0
        public void .cctor(){} // RVA: 0x7FFE879ED800
    }

    public class InputUserAccountHandle : ValueType
    {
        public string m_ApiName; // 0x10
        public ulong m_Handle; // 0x18

        // ── Methods ──
        public void get_apiName(){} // RVA: 0x7FFE8284EF60
        public void get_handle(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE879EDE80
        public void ToString(){} // RVA: 0x7FFE879EDF40
        public void Equals(){} // RVA: 0x7FFE879EE160 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE879EE200
        public void op_Inequality(){} // RVA: 0x7FFE879EE220
        public void GetHashCode(){} // RVA: 0x7FFE879EE240
    }

    public class InputUserSettings : Object
    {
        public string _customBindings; // 0x10
        public bool _invertMouseX; // 0x18
        public bool _invertMouseY; // 0x19
        public System.Nullable`1<float> _mouseSmoothing; // 0x1C
        public System.Nullable`1<float> _mouseSensitivity; // 0x24
        public bool _invertStickX; // 0x2C
        public bool _invertStickY; // 0x2D
        public bool _swapSticks; // 0x2E
        public bool _swapBumpers; // 0x2F
        public bool _swapTriggers; // 0x30
        public bool _swapDpadAndLeftStick; // 0x31
        public float _vibrationStrength; // 0x34

        // ── Methods ──
        public void get_customBindings(){} // RVA: 0x7FFE81116380
        public void set_customBindings(){} // RVA: 0x7FFE810FCE30
        public void get_invertMouseX(){} // RVA: 0x7FFE811164E0
        public void set_invertMouseX(){} // RVA: 0x7FFE811164F0
        public void get_invertMouseY(){} // RVA: 0x7FFE814B3730
        public void set_invertMouseY(){} // RVA: 0x7FFE81CD0510
        public void get_mouseSmoothing(){} // RVA: 0x7FFE86F97A40
        public void set_mouseSmoothing(){} // RVA: 0x7FFE86F97A50
        public void get_mouseSensitivity(){} // RVA: 0x7FFE879EE290
        public void set_mouseSensitivity(){} // RVA: 0x7FFE879EE2A0
        public void get_invertStickX(){} // RVA: 0x7FFE811DA230
        public void set_invertStickX(){} // RVA: 0x7FFE811DA240
        public void get_invertStickY(){} // RVA: 0x7FFE8130C7C0
        public void set_invertStickY(){} // RVA: 0x7FFE8130B300
        public void get_swapSticks(){} // RVA: 0x7FFE8130ACD0
        public void set_swapSticks(){} // RVA: 0x7FFE81308970
        public void get_swapBumpers(){} // RVA: 0x7FFE8130ACE0
        public void set_swapBumpers(){} // RVA: 0x7FFE8130B130
        public void get_swapTriggers(){} // RVA: 0x7FFE81121450
        public void set_swapTriggers(){} // RVA: 0x7FFE81121460
        public void get_swapDpadAndLeftStick(){} // RVA: 0x7FFE81121470
        public void set_swapDpadAndLeftStick(){} // RVA: 0x7FFE81121480
        public void get_vibrationStrength(){} // RVA: 0x7FFE811C5630
        public void set_vibrationStrength(){} // RVA: 0x7FFE811C5640
        public void Apply(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}