// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport : Object
    {
        public int s_Enabled;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFE87A0FA80
        public void Enable(){} // RVA: 0x7FFE87A0FAC0
        public void Disable(){} // RVA: 0x7FFE87A0FCC0
        public void Reset(){} // RVA: 0x7FFE87A0FEE0
        public void SetUpState(){} // RVA: 0x7FFE87A0FFB0
        public void TearDownState(){} // RVA: 0x7FFE87A10260
        public void OnDeviceChange(){} // RVA: 0x7FFE87A10500
        public void OnSettingsChange(){} // RVA: 0x7FFE87A107D0
        public void CheckEnabled(){} // RVA: 0x7FFE87A10860
    }

    public class Finger : Object
    {
        public UnityEngine.InputSystem.Touchscreen _screen; // 0x10
        public int _index; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory; // 0x20
        public object field_3; // 0x3E7
        public object field_4; // 0x3E8
        public object field_5; // 0x3E9
        public object field_6; // 0x3EA

        // ── Methods ──
        public void get_screen(){} // RVA: 0x7FFE81116380
        public void get_index(){} // RVA: 0x7FFE813DB630
        public void get_isActive(){} // RVA: 0x7FFE87A108F0
        public void get_screenPosition(){} // RVA: 0x7FFE87A10990
        public void get_lastTouch(){} // RVA: 0x7FFE87A10AD0
        public void get_currentTouch(){} // RVA: 0x7FFE87A10C50
        public void get_touchHistory(){} // RVA: 0x7FFE87A10EC0
        public void .ctor(){} // RVA: 0x7FFE87A10FC0
        public void ShouldRecordTouch(){} // RVA: 0x7FFE87A11650
        public void OnTouchRecorded(){} // RVA: 0x7FFE87A11700
        public void FindTouch(){} // RVA: 0x7FFE87A11A20
        public void GetTouchHistory(){} // RVA: 0x7FFE87A11CD0
    }

    public class Touch : ValueType
    {
        public UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger; // 0x10
        public Record<UnityEngine.InputSystem.LowLevel.TouchState> m_TouchRecord; // 0x18
        public GlobalState s_GlobalState;
        public object Record; // 0x7AA0
        public object onFingerMove;
        public object valid;
        public object finger;
        public object phase; // 0x8A78
        public object began;
        public object inProgress;
        public object field_10; // 0xE280
        public object field_11; // 0x8610
        public object field_12; // 0x941C
        public object field_13; // 0x3BE5
        public object field_14; // 0x1C20
        public object field_15; // 0x941C
        public object field_16; // 0x3BE5
        public object field_17; // 0x1C20
        public object field_18; // 0x8840
        public object field_19; // 0xAC70
        public object field_20; // 0xDB70
        public object field_21; // 0x6B50
        public object field_22; // 0x25
        public object onFingerMove;
        public object valid;
        public object finger;
        public object phase;
        public object began;
        public object inProgress;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFE87A120F0
        public void get_finger(){} // RVA: 0x7FFE8284EF60
        public void get_phase(){} // RVA: 0x7FFE87A12130
        public void get_began(){} // RVA: 0x7FFE87A121B0
        public void get_inProgress(){} // RVA: 0x7FFE87A12210
        public void get_ended(){} // RVA: 0x7FFE87A122C0
        public void get_touchId(){} // RVA: 0x7FFE87A12350
        public void get_pressure(){} // RVA: 0x7FFE87A123D0
        public void get_radius(){} // RVA: 0x7FFE87A12450
        public void get_startTime(){} // RVA: 0x7FFE87A124E0
        public void get_time(){} // RVA: 0x7FFE87A12560
        public void get_screen(){} // RVA: 0x7FFE87A125A0
        public void get_screenPosition(){} // RVA: 0x7FFE87A12600
        public void get_startScreenPosition(){} // RVA: 0x7FFE87A12690
        public void get_delta(){} // RVA: 0x7FFE87A12720
        public void get_tapCount(){} // RVA: 0x7FFE87A127B0
        public void get_isTap(){} // RVA: 0x7FFE87A12830
        public void get_displayIndex(){} // RVA: 0x7FFE87A128B0
        public void get_isInProgress(){} // RVA: 0x7FFE87A12930
        public void get_updateStepCount(){} // RVA: 0x7FFE87A129A0
        public void get_uniqueId(){} // RVA: 0x7FFE87A12A20
        public void get_state(){} // RVA: 0x7FFE87A12AA0
        public void get_extraData(){} // RVA: 0x7FFE87A12AE0
        public void get_history(){} // RVA: 0x7FFE87A12B20
        public void get_activeTouches(){} // RVA: 0x7FFE87A12C50
        public void get_fingers(){} // RVA: 0x7FFE87A12D50
        public void get_activeFingers(){} // RVA: 0x7FFE87A12DE0
        public void get_screens(){} // RVA: 0x7FFE87A12E80
        public void add_onFingerDown(){} // RVA: 0x7FFE87A12F10
        public void remove_onFingerDown(){} // RVA: 0x7FFE87A12FE0
        public void add_onFingerUp(){} // RVA: 0x7FFE87A130B0
        public void remove_onFingerUp(){} // RVA: 0x7FFE87A13180
        public void add_onFingerMove(){} // RVA: 0x7FFE87A13250
        public void remove_onFingerMove(){} // RVA: 0x7FFE87A13320
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x7FFE87A133F0
        public void .ctor(){} // RVA: 0x7FFE84459A90
        public void ToString(){} // RVA: 0x7FFE87A13450
        public void Equals(){} // RVA: 0x7FFE87A13910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A139E0
        public void AddTouchscreen(){} // RVA: 0x7FFE87A13A80
        public void RemoveTouchscreen(){} // RVA: 0x7FFE87A13B20
        public void BeginUpdate(){} // RVA: 0x7FFE87A13C60
        public void CreateGlobalState(){} // RVA: 0x7FFE87A13CE0
        public void SaveAndResetState(){} // RVA: 0x7FFE87A13D10
        public void .cctor(){} // RVA: 0x7FFE87A14410
    }

    public class TouchHistory : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> m_History; // 0x10
        public UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A154C0
        public void GetEnumerator(){} // RVA: 0x7FFE87A155D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87A15690
        public void get_Count(){} // RVA: 0x7FFE811485C0
        public void get_Item(){} // RVA: 0x7FFE87A156A0
        public void CheckValid(){} // RVA: 0x7FFE87A15820
    }

    public class TouchSimulation : MonoBehaviour
    {
        public UnityEngine.InputSystem.Touchscreen _simulatedTouchscreen; // 0x20
        public int m_NumPointers; // 0x28

        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x7FFE811290C0
        public void set_simulatedTouchscreen(){} // RVA: 0x7FFE811290D0
        public void get_instance(){} // RVA: 0x7FFE87A15A60
        public void Enable(){} // RVA: 0x7FFE87A15AA0
        public void Disable(){} // RVA: 0x7FFE87A15E40
        public void Destroy(){} // RVA: 0x7FFE87A15FC0
        public void AddPointer(){} // RVA: 0x7FFE87A161A0
        public void RemovePointer(){} // RVA: 0x7FFE87A16470
        public void OnEvent(){} // RVA: 0x7FFE87A16980
        public void OnDeviceChange(){} // RVA: 0x7FFE87A17130
        public void OnEnable(){} // RVA: 0x7FFE87A172A0
        public void OnDisable(){} // RVA: 0x7FFE87A17A90
        public void UpdateTouch(){} // RVA: 0x7FFE87A17C60
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFE810FB310
        public void InstallStateChangeMonitors(){} // RVA: 0x7FFE810FB310
        public void OnSourceControlChangedValue(){} // RVA: 0x7FFE810FB310
        public void UninstallStateChangeMonitors(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}