// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport : Object
    {
        public int enabled;
        public 0x6B149068 s_UpdateMode; // 0x4

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC9667320
        public void Enable(){} // RVA: 0x7FFAC9667360
        public void Disable(){} // RVA: 0x7FFAC9667560
        public void Reset(){} // RVA: 0x7FFAC9667780
        public void SetUpState(){} // RVA: 0x7FFAC9667850
        public void TearDownState(){} // RVA: 0x7FFAC9667B00
        public void OnDeviceChange(){} // RVA: 0x7FFAC9667DA0
        public void OnSettingsChange(){} // RVA: 0x7FFAC9668070
        public void CheckEnabled(){} // RVA: 0x7FFAC9668100
    }

    public class Finger : Object
    {
        public UnityEngine.InputSystem.Touchscreen screen; // 0x10
        public int index; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> isActive; // 0x20

        // ── Methods ──
        public void get_screen(){} // RVA: 0x7FFAC2F3C380
        public void get_index(){} // RVA: 0x7FFAC3157800
        public void get_isActive(){} // RVA: 0x7FFAC9668190
        public void get_screenPosition(){} // RVA: 0x7FFAC9668230
        public void get_lastTouch(){} // RVA: 0x7FFAC9668370
        public void get_currentTouch(){} // RVA: 0x7FFAC96684F0
        public void get_touchHistory(){} // RVA: 0x7FFAC9668760
        public void .ctor(){} // RVA: 0x7FFAC9668860
        public void ShouldRecordTouch(){} // RVA: 0x7FFAC9668EF0
        public void OnTouchRecorded(){} // RVA: 0x7FFAC9668FA0
        public void FindTouch(){} // RVA: 0x7FFAC96692C0
        public void GetTouchHistory(){} // RVA: 0x7FFAC9669570
    }

    public class Touch : ValueType
    {
        public UnityEngine.InputSystem.EnhancedTouch.Finger valid; // 0x10
        public Record<UnityEngine.InputSystem.LowLevel.TouchState> finger; // 0x18
        public GlobalState phase;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAC9669990
        public void get_finger(){} // RVA: 0x7FFAC3AD9F60
        public void get_phase(){} // RVA: 0x7FFAC96699D0
        public void get_began(){} // RVA: 0x7FFAC9669A50
        public void get_inProgress(){} // RVA: 0x7FFAC9669AB0
        public void get_ended(){} // RVA: 0x7FFAC9669B60
        public void get_touchId(){} // RVA: 0x7FFAC9669BF0
        public void get_pressure(){} // RVA: 0x7FFAC9669C70
        public void get_radius(){} // RVA: 0x7FFAC9669CF0
        public void get_startTime(){} // RVA: 0x7FFAC9669D80
        public void get_time(){} // RVA: 0x7FFAC9669E00
        public void get_screen(){} // RVA: 0x7FFAC9669E40
        public void get_screenPosition(){} // RVA: 0x7FFAC9669EA0
        public void get_startScreenPosition(){} // RVA: 0x7FFAC9669F30
        public void get_delta(){} // RVA: 0x7FFAC9669FC0
        public void get_tapCount(){} // RVA: 0x7FFAC966A050
        public void get_isTap(){} // RVA: 0x7FFAC966A0D0
        public void get_displayIndex(){} // RVA: 0x7FFAC966A150
        public void get_isInProgress(){} // RVA: 0x7FFAC966A1D0
        public void get_updateStepCount(){} // RVA: 0x7FFAC966A240
        public void get_uniqueId(){} // RVA: 0x7FFAC966A2C0
        public void get_state(){} // RVA: 0x7FFAC966A340
        public void get_extraData(){} // RVA: 0x7FFAC966A380
        public void get_history(){} // RVA: 0x7FFAC966A3C0
        public void get_activeTouches(){} // RVA: 0x7FFAC966A4F0
        public void get_fingers(){} // RVA: 0x7FFAC966A5F0
        public void get_activeFingers(){} // RVA: 0x7FFAC966A680
        public void get_screens(){} // RVA: 0x7FFAC966A720
        public void add_onFingerDown(){} // RVA: 0x7FFAC966A7B0
        public void remove_onFingerDown(){} // RVA: 0x7FFAC966A880
        public void add_onFingerUp(){} // RVA: 0x7FFAC966A950
        public void remove_onFingerUp(){} // RVA: 0x7FFAC966AA20
        public void add_onFingerMove(){} // RVA: 0x7FFAC966AAF0
        public void remove_onFingerMove(){} // RVA: 0x7FFAC966ABC0
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x7FFAC966AC90
        public void .ctor(){} // RVA: 0x7FFAC60F48A0
        public void ToString(){} // RVA: 0x7FFAC966ACF0
        public void Equals(){} // RVA: 0x7FFAC966B1B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC966B280
        public void AddTouchscreen(){} // RVA: 0x7FFAC966B320
        public void RemoveTouchscreen(){} // RVA: 0x7FFAC966B3C0
        public void BeginUpdate(){} // RVA: 0x7FFAC966B500
        public void CreateGlobalState(){} // RVA: 0x7FFAC966B580
        public void SaveAndResetState(){} // RVA: 0x7FFAC966B5B0
        public void .cctor(){} // RVA: 0x7FFAC966BCB0
    }

    public class TouchHistory : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> Count; // 0x10
        public UnityEngine.InputSystem.EnhancedTouch.Finger Item; // 0x18
        public int m_Count; // 0x20
        public int m_StartIndex; // 0x24
        public uint m_Version; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC966CD60
        public void GetEnumerator(){} // RVA: 0x7FFAC966CE70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC966CF30
        public void get_Count(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Item(){} // RVA: 0x7FFAC966CF40
        public void CheckValid(){} // RVA: 0x7FFAC966D0C0
    }

    public class TouchSimulation : MonoBehaviour
    {
        public UnityEngine.InputSystem.Touchscreen simulatedTouchscreen; // 0x20
        public int instance; // 0x28
        public UnityEngine.InputSystem.Pointer[] m_Pointers; // 0x30
        public UnityEngine.Vector2[] m_CurrentPositions; // 0x38
        public int[] m_CurrentDisplayIndices; // 0x40
        public UnityEngine.InputSystem.Controls.ButtonControl[] m_Touches; // 0x48
        public int[] m_TouchIds; // 0x50
        public int m_LastTouchId; // 0x58
        public System.Action`2<UnityEngine.InputSystem.InputDevice,0x6B147AC0> m_OnDeviceChange; // 0x60
        public System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEvent; // 0x68
        public UnityEngine.InputSystem.EnhancedTouch.TouchSimulation s_Instance;

        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x7FFAC2F4F0C0
        public void set_simulatedTouchscreen(){} // RVA: 0x7FFAC2F4F0D0
        public void get_instance(){} // RVA: 0x7FFAC966D300
        public void Enable(){} // RVA: 0x7FFAC966D340
        public void Disable(){} // RVA: 0x7FFAC966D6E0
        public void Destroy(){} // RVA: 0x7FFAC966D860
        public void AddPointer(){} // RVA: 0x7FFAC966DA40
        public void RemovePointer(){} // RVA: 0x7FFAC966DD10
        public void OnEvent(){} // RVA: 0x7FFAC966E220
        public void OnDeviceChange(){} // RVA: 0x7FFAC966E9D0
        public void OnEnable(){} // RVA: 0x7FFAC966EB40
        public void OnDisable(){} // RVA: 0x7FFAC966F330
        public void UpdateTouch(){} // RVA: 0x7FFAC966F500
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFAC2F21310
        public void InstallStateChangeMonitors(){} // RVA: 0x7FFAC2F21310
        public void OnSourceControlChangedValue(){} // RVA: 0x7FFAC2F21310
        public void UninstallStateChangeMonitors(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}