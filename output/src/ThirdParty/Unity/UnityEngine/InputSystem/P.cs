// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 7
// Methods: 201

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Pen : Pointer
    {
        public object _tip;
        public object _eraser;
        public object _firstBarrelButton;
        public object _secondBarrelButton;
        public object _thirdBarrelButton;
        public object _fourthBarrelButton;
        public object _inRange;
        public object _tilt;
        public object _twist;
        public object _current;

        // ── Methods ──
        public void get_tip(){} // RVA: 0x1344890
        public void set_tip(){} // RVA: 0x1662780
        public void get_eraser(){} // RVA: 0x1655DD0
        public void set_eraser(){} // RVA: 0x16694D0
        public void get_firstBarrelButton(){} // RVA: 0x1654670
        public void set_firstBarrelButton(){} // RVA: 0x16612E0
        public void get_secondBarrelButton(){} // RVA: 0x165AD10
        public void set_secondBarrelButton(){} // RVA: 0x1667130
        public void get_thirdBarrelButton(){} // RVA: 0x1184410
        public void set_thirdBarrelButton(){} // RVA: 0x163ACA0
        public void get_fourthBarrelButton(){} // RVA: 0x164FF50
        public void set_fourthBarrelButton(){} // RVA: 0x16529A0
        public void get_inRange(){} // RVA: 0x1659260
        public void set_inRange(){} // RVA: 0x165DAA0
        public void get_tilt(){} // RVA: 0x136ECA0
        public void set_tilt(){} // RVA: 0x164C9D0
        public void get_twist(){} // RVA: 0x165F4F0
        public void set_twist(){} // RVA: 0x164A160
        public void get_current(){} // RVA: 0x785CB00
        public void set_current(){} // RVA: 0x785CB40
        public void get_Item(){} // RVA: 0x785CBE0
        public void MakeCurrent(){} // RVA: 0x785CD10
        public void OnRemoved(){} // RVA: 0x785CD30
        public void FinishSetup(){} // RVA: 0x785CDC0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class PlayerInput : MonoBehaviour
    {
        public object DeviceLostMessage;
        public object DeviceRegainedMessage;
        public object ControlsChangedMessage;
        public object m_AllMapsHashCode;
        public object m_Actions;
        public object m_NotificationBehavior;
        public object m_UIInputModule;
        public object m_DeviceLostEvent;
        public object m_DeviceRegainedEvent;
        public object m_ControlsChangedEvent;
        public object m_ActionEvents;
        public object m_NeverAutoSwitchControlSchemes;
        public object m_DefaultControlScheme;
        public object m_DefaultActionMap;
        public object m_SplitScreenIndex;
        public object m_Camera;
        public object m_InputValueObject;
        public object m_CurrentActionMap;
        public object m_PlayerIndex;
        public object m_InputActive;
        public object m_Enabled;
        public object m_ActionsInitialized;
        public object m_ActionMessageNames;
        public object m_InputUser;
        public object m_ActionTriggeredDelegate;
        public object m_DeviceLostCallbacks;
        public object m_DeviceRegainedCallbacks;
        public object m_ControlsChangedCallbacks;
        public object m_ActionTriggeredCallbacks;
        public object m_UnpairedDeviceUsedDelegate;
        public object m_PreFilterUnpairedDeviceUsedDelegate;
        public object m_OnUnpairedDeviceUsedHooked;
        public object m_DeviceChangeDelegate;
        public object m_OnDeviceChangeHooked;
        public object s_AllActivePlayersCount;
        public object s_AllActivePlayers;
        public object s_UserChangeDelegate;
        public object s_InitPairWithDevicesCount;
        public object s_InitPairWithDevices;
        public object s_InitPlayerIndex;
        public object s_InitSplitScreenIndex;
        public object s_InitControlScheme;
        public object s_DestroyIfDeviceSetupUnsuccessful;

        // ── Methods ──
        public void get_inputIsActive(){} // RVA: 0x6DE6270
        public void get_active(){} // RVA: 0x6DE6270
        public void get_playerIndex(){} // RVA: 0x262A930
        public void get_splitScreenIndex(){} // RVA: 0x23ADD10
        public void get_actions(){} // RVA: 0x78D9C10
        public void set_actions(){} // RVA: 0x78D9C60
        public void get_currentControlScheme(){} // RVA: 0x78D9FB0
        public void get_defaultControlScheme(){} // RVA: 0xBBFF90
        public void set_defaultControlScheme(){} // RVA: 0xBBFFA0
        public void get_neverAutoSwitchControlSchemes(){} // RVA: 0xB6B1A0
        public void set_neverAutoSwitchControlSchemes(){} // RVA: 0x78DA070
        public void get_currentActionMap(){} // RVA: 0x1069350
        public void set_currentActionMap(){} // RVA: 0x78DA0B0
        public void get_defaultActionMap(){} // RVA: 0xC10050
        public void set_defaultActionMap(){} // RVA: 0xC10060
        public void get_notificationBehavior(){} // RVA: 0xB9E080
        public void set_notificationBehavior(){} // RVA: 0x78DA350
        public void get_actionEvents(){} // RVA: 0x78DA3A0
        public void set_actionEvents(){} // RVA: 0x78DA470
        public void get_deviceLostEvent(){} // RVA: 0x78DA530
        public void get_deviceRegainedEvent(){} // RVA: 0x78DA600
        public void get_controlsChangedEvent(){} // RVA: 0x78DA6D0
        public void add_onActionTriggered(){} // RVA: 0x78DA7A0
        public void remove_onActionTriggered(){} // RVA: 0x78DA840
        public void add_onDeviceLost(){} // RVA: 0x78DA8E0
        public void remove_onDeviceLost(){} // RVA: 0x78DA980
        public void add_onDeviceRegained(){} // RVA: 0x78DAA20
        public void remove_onDeviceRegained(){} // RVA: 0x78DAAC0
        public void add_onControlsChanged(){} // RVA: 0x78DAB60
        public void remove_onControlsChanged(){} // RVA: 0x78DAC00
        public void get_camera(){} // RVA: 0xCD48B0
        public void set_camera(){} // RVA: 0xCD3600
        public void get_uiInputModule(){} // RVA: 0xD05CA0
        public void set_uiInputModule(){} // RVA: 0x78DACA0
        public void get_user(){} // RVA: 0x158C700
        public void get_devices(){} // RVA: 0x78DB100
        public void get_hasMissingRequiredDevices(){} // RVA: 0x78DB1B0
        public void get_all(){} // RVA: 0x78DB2B0
        public void get_isSinglePlayer(){} // RVA: 0x78DB390
        public void GetDevice(){} // RVA: 0xA94080
        public void ActivateInput(){} // RVA: 0x78DB520
        public void UpdateDelegates(){} // RVA: 0x78DB650
        public void DeactivateInput(){} // RVA: 0x78DB930
        public void PassivateInput(){} // RVA: 0x78DB930
        public void SwitchCurrentControlScheme(){} // RVA: 0x78DBC20
        public void SwitchCurrentActionMap(){} // RVA: 0x78DBD70
        public void GetPlayerByIndex(){} // RVA: 0x78DBF50
        public void FindFirstPairedToDevice(){} // RVA: 0x78DC060
        public void Instantiate(){} // RVA: 0x78DC4A0
        public void DoInstantiate(){} // RVA: 0x78DC740
        public void InitializeActions(){} // RVA: 0x78DCCA0
        public void CopyActionAssetAndApplyBindingOverrides(){} // RVA: 0x78DD240
        public void UninitializeActions(){} // RVA: 0x78DD5C0
        public void InstallOnActionTriggeredHook(){} // RVA: 0x78DD890
        public void UninstallOnActionTriggeredHook(){} // RVA: 0x78DDB80
        public void OnActionTriggered(){} // RVA: 0x78DDDA0
        public void CacheMessageNames(){} // RVA: 0x78DE0A0
        public void ClearCaches(){} // RVA: 0x78DE570
        public void AssignUserAndDevices(){} // RVA: 0x78DE5D0
        public void HaveBindingForDevice(){} // RVA: 0x78DF360
        public void UnassignUserAndDevices(){} // RVA: 0x78DF4F0
        public void TryToActivateControlScheme(){} // RVA: 0x78DF690
        public void AssignPlayerIndex(){} // RVA: 0x78DFAC0
        public void Awake(){} // RVA: 0x78DFD70
        public void OnEnable(){} // RVA: 0x78DFE50
        public void StartListeningForUnpairedDeviceActivity(){} // RVA: 0x78E0640
        public void StopListeningForUnpairedDeviceActivity(){} // RVA: 0x78E0920
        public void StartListeningForDeviceChanges(){} // RVA: 0x78E0AB0
        public void StopListeningForDeviceChanges(){} // RVA: 0x78E0BD0
        public void OnDisable(){} // RVA: 0x78E0C40
        public void DebugLogAction(){} // RVA: 0x78E11A0
        public void HandleDeviceLost(){} // RVA: 0x78E1200
        public void HandleDeviceRegained(){} // RVA: 0x78E1320
        public void HandleControlsChanged(){} // RVA: 0x78E1440
        public void OnUserChange(){} // RVA: 0x78E1560
        public void OnPreFilterUnpairedDeviceUsed(){} // RVA: 0x78E1770
        public void OnUnpairedDeviceUsed(){} // RVA: 0x78E1A20
        public void OnDeviceChange(){} // RVA: 0x78E2370
        public void SwitchControlSchemeInternal(){} // RVA: 0x78E2540
        public void .ctor(){} // RVA: 0x78E2B00
        public void .cctor(){} // RVA: 0x78E2B60
    }

    public class PlayerInputManager : MonoBehaviour
    {
        public object PlayerJoinedMessage;
        public object PlayerLeftMessage;
        public object _instance;
        public object m_NotificationBehavior;
        public object m_MaxPlayerCount;
        public object m_AllowJoining;
        public object m_JoinBehavior;
        public object m_PlayerJoinedEvent;
        public object m_PlayerLeftEvent;
        public object m_JoinAction;
        public object m_PlayerPrefab;
        public object m_SplitScreen;
        public object m_MaintainAspectRatioInSplitScreen;
        public object m_FixedNumberOfSplitScreens;
        public object m_SplitScreenRect;
        public object m_JoinActionDelegateHooked;
        public object m_UnpairedDeviceUsedDelegateHooked;
        public object m_JoinActionDelegate;
        public object m_UnpairedDeviceUsedDelegate;
        public object m_PlayerJoinedCallbacks;
        public object m_PlayerLeftCallbacks;

        // ── Methods ──
        public void get_splitScreen(){} // RVA: 0xB6B1A0
        public void set_splitScreen(){} // RVA: 0x78E31F0
        public void get_maintainAspectRatioInSplitScreen(){} // RVA: 0x1A1E0A0
        public void get_fixedNumberOfSplitScreens(){} // RVA: 0xD34720
        public void get_splitScreenArea(){} // RVA: 0x4127AD0
        public void get_playerCount(){} // RVA: 0x78E3570
        public void get_maxPlayerCount(){} // RVA: 0x15AF000
        public void get_joiningEnabled(){} // RVA: 0xF73960
        public void get_joinBehavior(){} // RVA: 0x1AE5AC0
        public void set_joinBehavior(){} // RVA: 0x78E35D0
        public void get_joinAction(){} // RVA: 0xB4CDC0
        public void set_joinAction(){} // RVA: 0x78E3620
        public void get_notificationBehavior(){} // RVA: 0xFEAE90
        public void set_notificationBehavior(){} // RVA: 0x1269760
        public void get_playerJoinedEvent(){} // RVA: 0x78E3710
        public void get_playerLeftEvent(){} // RVA: 0x78E37E0
        public void add_onPlayerJoined(){} // RVA: 0x78E38B0
        public void remove_onPlayerJoined(){} // RVA: 0x78E3950
        public void add_onPlayerLeft(){} // RVA: 0x78E39F0
        public void remove_onPlayerLeft(){} // RVA: 0x78E3A90
        public void get_playerPrefab(){} // RVA: 0xC0FFC0
        public void set_playerPrefab(){} // RVA: 0xC0FFD0
        public void get_instance(){} // RVA: 0x78E3B30
        public void set_instance(){} // RVA: 0x78E3B70
        public void EnableJoining(){} // RVA: 0x78E3C10
        public void DisableJoining(){} // RVA: 0x78E3E30
        public void JoinPlayerFromUI(){} // RVA: 0x78E3F30
        public void JoinPlayerFromAction(){} // RVA: 0x78E3F90
        public void JoinPlayerFromActionIfNotAlreadyJoined(){} // RVA: 0x78E4000
        public void JoinPlayer(){} // RVA: 0x78E43A0
        public void get_messages(){} // RVA: 0x78E4460
        public void CheckIfPlayerCanJoin(){} // RVA: 0x78E4500
        public void OnUnpairedDeviceUsed(){} // RVA: 0x78E4870
        public void OnEnable(){} // RVA: 0x78E4920
        public void OnDisable(){} // RVA: 0x78E4EE0
        public void UpdateSplitScreen(){} // RVA: 0x78E5040
        public void IsDeviceUsableWithPlayerActions(){} // RVA: 0x78E57C0
        public void ValidateInputActionAsset(){} // RVA: 0xB43310
        public void NotifyPlayerJoined(){} // RVA: 0x78E5DA0
        public void NotifyPlayerLeft(){} // RVA: 0x78E5EE0
        public void .ctor(){} // RVA: 0x78E6020
    }

    public class Pointer : InputDevice
    {
        public object _position;
        public object _delta;
        public object _radius;
        public object _pressure;
        public object _press;
        public object _displayIndex;
        public object _current;

        // ── Methods ──
        public void get_position(){} // RVA: 0x13659D0
        public void set_position(){} // RVA: 0x166D270
        public void get_delta(){} // RVA: 0x135C160
        public void set_delta(){} // RVA: 0x16614A0
        public void get_radius(){} // RVA: 0x1664460
        public void set_radius(){} // RVA: 0x16679E0
        public void get_pressure(){} // RVA: 0x135A180
        public void set_pressure(){} // RVA: 0x164D690
        public void get_press(){} // RVA: 0x165E8F0
        public void set_press(){} // RVA: 0x165C4D0
        public void get_displayIndex(){} // RVA: 0x1659CB0
        public void set_displayIndex(){} // RVA: 0x163A980
        public void get_current(){} // RVA: 0x785D350
        public void set_current(){} // RVA: 0x785D390
        public void MakeCurrent(){} // RVA: 0x785D430
        public void OnRemoved(){} // RVA: 0x785D440
        public void FinishSetup(){} // RVA: 0x785D490
        public void OnNextUpdate(){} // RVA: 0x785D820
        public void OnStateEvent(){} // RVA: 0x785D8E0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x785D990
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x785D9A0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class Pointer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PressureSensor : Sensor
    {
        public object _atmosphericPressure;
        public object _current;

        // ── Methods ──
        public void get_atmosphericPressure(){} // RVA: 0x13659D0
        public void set_atmosphericPressure(){} // RVA: 0x166D270
        public void get_current(){} // RVA: 0x78BB960
        public void set_current(){} // RVA: 0x78BB9A0
        public void MakeCurrent(){} // RVA: 0x78BBA40
        public void OnRemoved(){} // RVA: 0x78BBA50
        public void FinishSetup(){} // RVA: 0x78BBAA0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class ProximitySensor : Sensor
    {
        public object _distance;
        public object _current;

        // ── Methods ──
        public void get_distance(){} // RVA: 0x13659D0
        public void set_distance(){} // RVA: 0x166D270
        public void get_current(){} // RVA: 0x78BBB50
        public void set_current(){} // RVA: 0x78BBB90
        public void MakeCurrent(){} // RVA: 0x78BBC30
        public void OnRemoved(){} // RVA: 0x78BBC40
        public void FinishSetup(){} // RVA: 0x78BBC90
        public void .ctor(){} // RVA: 0x77D4F00
    }

}