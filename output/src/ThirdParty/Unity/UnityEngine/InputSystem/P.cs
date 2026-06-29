// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 7
// Methods: 201

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Pen : Pointer
    {
        // ── Methods ──
        public void get_tip(){} // RVA: 0x7A8815B70
        public void set_tip(){} // RVA: 0x7A8B58420
        public void get_eraser(){} // RVA: 0x7A8B6AFA0
        public void set_eraser(){} // RVA: 0x7A8B58B30
        public void get_firstBarrelButton(){} // RVA: 0x7A8B79060
        public void set_firstBarrelButton(){} // RVA: 0x7A8B49820
        public void get_secondBarrelButton(){} // RVA: 0x7A8B5ED30
        public void set_secondBarrelButton(){} // RVA: 0x7A8B5E380
        public void get_thirdBarrelButton(){} // RVA: 0x7A8688280
        public void set_thirdBarrelButton(){} // RVA: 0x7A8B797E0
        public void get_fourthBarrelButton(){} // RVA: 0x7A8B7A210
        public void set_fourthBarrelButton(){} // RVA: 0x7A8B48CD0
        public void get_inRange(){} // RVA: 0x7A8B562C0
        public void set_inRange(){} // RVA: 0x7A8B4A930
        public void get_tilt(){} // RVA: 0x7A8B50AF0
        public void set_tilt(){} // RVA: 0x7A8B61940
        public void get_twist(){} // RVA: 0x7A8B62DA0
        public void set_twist(){} // RVA: 0x7A8B63900
        public void get_current(){} // RVA: 0x7AEBEDDE0
        public void set_current(){} // RVA: 0x7AEBEDE20
        public void get_Item(){} // RVA: 0x7AEBEDEC0
        public void MakeCurrent(){} // RVA: 0x7AEBEE000
        public void OnRemoved(){} // RVA: 0x7AEBEE020
        public void FinishSetup(){} // RVA: 0x7AEBEE0B0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class PlayerInput : MonoBehaviour
    {
        // ── Methods ──
        public void get_inputIsActive(){} // RVA: 0x7AE1658B0
        public void get_active(){} // RVA: 0x7AE1658B0
        public void get_playerIndex(){} // RVA: 0x7A9B79A20
        public void get_splitScreenIndex(){} // RVA: 0x7A989D5C0
        public void get_actions(){} // RVA: 0x7AEC6BEE0
        public void set_actions(){} // RVA: 0x7AEC6BFB0
        public void get_currentControlScheme(){} // RVA: 0x7AEC6C300
        public void get_defaultControlScheme(){} // RVA: 0x7A8153390
        public void set_defaultControlScheme(){} // RVA: 0x7A81533A0
        public void get_neverAutoSwitchControlSchemes(){} // RVA: 0x7A8100260
        public void set_neverAutoSwitchControlSchemes(){} // RVA: 0x7AEC6C3C0
        public void get_currentActionMap(){} // RVA: 0x7A8555100
        public void set_currentActionMap(){} // RVA: 0x7AEC6C400
        public void get_defaultActionMap(){} // RVA: 0x7A81A00E0
        public void set_defaultActionMap(){} // RVA: 0x7A81A00F0
        public void get_notificationBehavior(){} // RVA: 0x7A8133100
        public void set_notificationBehavior(){} // RVA: 0x7AEC6C6A0
        public void get_actionEvents(){} // RVA: 0x7AEC6C6F0
        public void set_actionEvents(){} // RVA: 0x7AEC6C7C0
        public void get_deviceLostEvent(){} // RVA: 0x7AEC6C880
        public void get_deviceRegainedEvent(){} // RVA: 0x7AEC6C950
        public void get_controlsChangedEvent(){} // RVA: 0x7AEC6CA20
        public void add_onActionTriggered(){} // RVA: 0x7AEC6CAF0
        public void remove_onActionTriggered(){} // RVA: 0x7AEC6CB90
        public void add_onDeviceLost(){} // RVA: 0x7AEC6CC30
        public void remove_onDeviceLost(){} // RVA: 0x7AEC6CCD0
        public void add_onDeviceRegained(){} // RVA: 0x7AEC6CD70
        public void remove_onDeviceRegained(){} // RVA: 0x7AEC6CE10
        public void add_onControlsChanged(){} // RVA: 0x7AEC6CEB0
        public void remove_onControlsChanged(){} // RVA: 0x7AEC6CF50
        public void get_camera(){} // RVA: 0x7A825E100
        public void set_camera(){} // RVA: 0x7A825F860
        public void get_uiInputModule(){} // RVA: 0x7A8292C30
        public void set_uiInputModule(){} // RVA: 0x7AEC6CFF0
        public void get_user(){} // RVA: 0x7A8A69800
        public void get_devices(){} // RVA: 0x7AEC6D450
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7AEC6D500
        public void get_all(){} // RVA: 0x7AEC6D600
        public void get_isSinglePlayer(){} // RVA: 0x7AEC6D6E0
        public void GetDevice(){} // RVA: 0x7A8051B10
        public void ActivateInput(){} // RVA: 0x7AEC6D870
        public void UpdateDelegates(){} // RVA: 0x7AEC6D9A0
        public void DeactivateInput(){} // RVA: 0x7AEC6DC80
        public void PassivateInput(){} // RVA: 0x7AEC6DC80
        public void SwitchCurrentControlScheme(){} // RVA: 0x7AEC6DF10
        public void SwitchCurrentActionMap(){} // RVA: 0x7AEC6E060
        public void GetPlayerByIndex(){} // RVA: 0x7AEC6E240
        public void FindFirstPairedToDevice(){} // RVA: 0x7AEC6E350
        public void Instantiate(){} // RVA: 0x7AEC6E790
        public void DoInstantiate(){} // RVA: 0x7AEC6EA30
        public void InitializeActions(){} // RVA: 0x7AEC6EF90
        public void CopyActionAssetAndApplyBindingOverrides(){} // RVA: 0x7AEC6F530
        public void UninitializeActions(){} // RVA: 0x7AEC6F8B0
        public void InstallOnActionTriggeredHook(){} // RVA: 0x7AEC6FB80
        public void UninstallOnActionTriggeredHook(){} // RVA: 0x7AEC6FE70
        public void OnActionTriggered(){} // RVA: 0x7AEC70090
        public void CacheMessageNames(){} // RVA: 0x7AEC70390
        public void ClearCaches(){} // RVA: 0x7AEC708B0
        public void AssignUserAndDevices(){} // RVA: 0x7AEC70910
        public void HaveBindingForDevice(){} // RVA: 0x7AEC716A0
        public void UnassignUserAndDevices(){} // RVA: 0x7AEC71830
        public void TryToActivateControlScheme(){} // RVA: 0x7AEC719D0
        public void AssignPlayerIndex(){} // RVA: 0x7AEC71E00
        public void Awake(){} // RVA: 0x7AEC720B0
        public void OnEnable(){} // RVA: 0x7AEC72190
        public void StartListeningForUnpairedDeviceActivity(){} // RVA: 0x7AEC72980
        public void StopListeningForUnpairedDeviceActivity(){} // RVA: 0x7AEC72C60
        public void StartListeningForDeviceChanges(){} // RVA: 0x7AEC72DF0
        public void StopListeningForDeviceChanges(){} // RVA: 0x7AEC72F10
        public void OnDisable(){} // RVA: 0x7AEC72F80
        public void DebugLogAction(){} // RVA: 0x7AEC734E0
        public void HandleDeviceLost(){} // RVA: 0x7AEC73540
        public void HandleDeviceRegained(){} // RVA: 0x7AEC73660
        public void HandleControlsChanged(){} // RVA: 0x7AEC73780
        public void OnUserChange(){} // RVA: 0x7AEC738A0
        public void OnPreFilterUnpairedDeviceUsed(){} // RVA: 0x7AEC73AB0
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7AEC73D30
        public void OnDeviceChange(){} // RVA: 0x7AEC74680
        public void SwitchControlSchemeInternal(){} // RVA: 0x7AEC74850
        public void .ctor(){} // RVA: 0x7AEC74E10
        public void .cctor(){} // RVA: 0x7AEC74E70
    }

    public class PlayerInputManager : MonoBehaviour
    {
        // ── Methods ──
        public void get_splitScreen(){} // RVA: 0x7A8100260
        public void set_splitScreen(){} // RVA: 0x7AEC75500
        public void get_maintainAspectRatioInSplitScreen(){} // RVA: 0x7A8F1FD00
        public void get_fixedNumberOfSplitScreens(){} // RVA: 0x7A8355900
        public void get_splitScreenArea(){} // RVA: 0x7AB490FA0
        public void get_playerCount(){} // RVA: 0x7AEC75850
        public void get_maxPlayerCount(){} // RVA: 0x7A8AB15F0
        public void get_joiningEnabled(){} // RVA: 0x7A84A5BD0
        public void get_joinBehavior(){} // RVA: 0x7A8F9ACE0
        public void set_joinBehavior(){} // RVA: 0x7AEC758B0
        public void get_joinAction(){} // RVA: 0x7A80E0E30
        public void set_joinAction(){} // RVA: 0x7AEC75900
        public void get_notificationBehavior(){} // RVA: 0x7A851DB90
        public void set_notificationBehavior(){} // RVA: 0x7A8738180
        public void get_playerJoinedEvent(){} // RVA: 0x7AEC759F0
        public void get_playerLeftEvent(){} // RVA: 0x7AEC75AC0
        public void add_onPlayerJoined(){} // RVA: 0x7AEC75B90
        public void remove_onPlayerJoined(){} // RVA: 0x7AEC75C30
        public void add_onPlayerLeft(){} // RVA: 0x7AEC75CD0
        public void remove_onPlayerLeft(){} // RVA: 0x7AEC75D70
        public void get_playerPrefab(){} // RVA: 0x7A81A0050
        public void set_playerPrefab(){} // RVA: 0x7A81A0060
        public void get_instance(){} // RVA: 0x7AEC75E10
        public void set_instance(){} // RVA: 0x7AEC75E50
        public void EnableJoining(){} // RVA: 0x7AEC75EF0
        public void DisableJoining(){} // RVA: 0x7AEC76110
        public void JoinPlayerFromUI(){} // RVA: 0x7AEC76210
        public void JoinPlayerFromAction(){} // RVA: 0x7AEC76270
        public void JoinPlayerFromActionIfNotAlreadyJoined(){} // RVA: 0x7AEC762E0
        public void JoinPlayer(){} // RVA: 0x7AEC76680
        public void get_messages(){} // RVA: 0x7AEC76740
        public void CheckIfPlayerCanJoin(){} // RVA: 0x7AEC767E0
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7AEC76B60
        public void OnEnable(){} // RVA: 0x7AEC76C10
        public void OnDisable(){} // RVA: 0x7AEC771D0
        public void UpdateSplitScreen(){} // RVA: 0x7AEC77330
        public void IsDeviceUsableWithPlayerActions(){} // RVA: 0x7AEC77AA0
        public void ValidateInputActionAsset(){} // RVA: 0x7A80D7310
        public void NotifyPlayerJoined(){} // RVA: 0x7AEC78050
        public void NotifyPlayerLeft(){} // RVA: 0x7AEC78190
        public void .ctor(){} // RVA: 0x7AEC782D0
    }

    public class Pointer : InputDevice
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7A884DD70
        public void set_position(){} // RVA: 0x7A8B5ADA0
        public void get_delta(){} // RVA: 0x7A8855020
        public void set_delta(){} // RVA: 0x7A8B60460
        public void get_radius(){} // RVA: 0x7A8B76160
        public void set_radius(){} // RVA: 0x7A8B592F0
        public void get_pressure(){} // RVA: 0x7A8852B30
        public void set_pressure(){} // RVA: 0x7A8B66E80
        public void get_press(){} // RVA: 0x7A8B69B70
        public void set_press(){} // RVA: 0x7A8B4DC50
        public void get_displayIndex(){} // RVA: 0x7A8B772D0
        public void set_displayIndex(){} // RVA: 0x7A8B58850
        public void get_current(){} // RVA: 0x7AEBEE640
        public void set_current(){} // RVA: 0x7AEBEE680
        public void MakeCurrent(){} // RVA: 0x7AEBEE720
        public void OnRemoved(){} // RVA: 0x7AEBEE730
        public void FinishSetup(){} // RVA: 0x7AEBEE780
        public void OnNextUpdate(){} // RVA: 0x7AEBEEB10
        public void OnStateEvent(){} // RVA: 0x7AEBEEBD0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7AEBEEC80
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7AEBEEC90
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class Pointer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PressureSensor : Sensor
    {
        // ── Methods ──
        public void get_atmosphericPressure(){} // RVA: 0x7A884DD70
        public void set_atmosphericPressure(){} // RVA: 0x7A8B5ADA0
        public void get_current(){} // RVA: 0x7AEC4CE30
        public void set_current(){} // RVA: 0x7AEC4CE70
        public void MakeCurrent(){} // RVA: 0x7AEC4CF10
        public void OnRemoved(){} // RVA: 0x7AEC4CF20
        public void FinishSetup(){} // RVA: 0x7AEC4CF70
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class ProximitySensor : Sensor
    {
        // ── Methods ──
        public void get_distance(){} // RVA: 0x7A884DD70
        public void set_distance(){} // RVA: 0x7A8B5ADA0
        public void get_current(){} // RVA: 0x7AEC4D020
        public void set_current(){} // RVA: 0x7AEC4D060
        public void MakeCurrent(){} // RVA: 0x7AEC4D100
        public void OnRemoved(){} // RVA: 0x7AEC4D110
        public void FinishSetup(){} // RVA: 0x7AEC4D160
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

}