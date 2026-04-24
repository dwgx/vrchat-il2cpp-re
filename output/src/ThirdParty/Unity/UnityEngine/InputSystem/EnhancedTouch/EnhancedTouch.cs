// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport : Object
    {
        public object enabled;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFD54A87320
        public void Enable(){} // RVA: 0x7FFD54A87360
        public void Disable(){} // RVA: 0x7FFD54A87560
        public void Reset(){} // RVA: 0x7FFD54A87780
        public void SetUpState(){} // RVA: 0x7FFD54A87850
        public void TearDownState(){} // RVA: 0x7FFD54A87B00
        public void OnDeviceChange(){} // RVA: 0x7FFD54A87DA0
        public void OnSettingsChange(){} // RVA: 0x7FFD54A88070
        public void CheckEnabled(){} // RVA: 0x7FFD54A88100
    }

    public class Finger : Object
    {
        public object screen;
        public object index;
        public object isActive;
        public object screenPosition;
        public object lastTouch;
        public object currentTouch;
        public object touchHistory;

        // ── Methods ──
        public void get_screen(){} // RVA: 0x7FFD4E35C380
        public void get_index(){} // RVA: 0x7FFD4E577800
        public void get_isActive(){} // RVA: 0x7FFD54A88190
        public void get_screenPosition(){} // RVA: 0x7FFD54A88230
        public void get_lastTouch(){} // RVA: 0x7FFD54A88370
        public void get_currentTouch(){} // RVA: 0x7FFD54A884F0
        public void get_touchHistory(){} // RVA: 0x7FFD54A88760
        public void .ctor(){} // RVA: 0x7FFD54A88860
        public void ShouldRecordTouch(){} // RVA: 0x7FFD54A88EF0
        public void OnTouchRecorded(){} // RVA: 0x7FFD54A88FA0
        public void FindTouch(){} // RVA: 0x7FFD54A892C0
        public void GetTouchHistory(){} // RVA: 0x7FFD54A89570
    }

    public class Touch : ValueType
    {
        public object valid;
        public object finger;
        public object phase;
        public object began;
        public object inProgress;
        public object ended;
        public object touchId;
        public object pressure;
        public object radius;
        public object startTime;
        public object time;
        public object screen;
        public object screenPosition;
        public object startScreenPosition;
        public object delta;
        public object tapCount;
        public object isTap;
        public object displayIndex;
        public object isInProgress;
        public object updateStepCount;
        public object uniqueId;
        public object state;
        public object extraData;
        public object history;
        public object activeTouches;
        public object fingers;
        public object activeFingers;
        public object screens;
        public object maxHistoryLengthPerFinger;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFD54A89990
        public void get_finger(){} // RVA: 0x7FFD4EEF9F60
        public void get_phase(){} // RVA: 0x7FFD54A899D0
        public void get_began(){} // RVA: 0x7FFD54A89A50
        public void get_inProgress(){} // RVA: 0x7FFD54A89AB0
        public void get_ended(){} // RVA: 0x7FFD54A89B60
        public void get_touchId(){} // RVA: 0x7FFD54A89BF0
        public void get_pressure(){} // RVA: 0x7FFD54A89C70
        public void get_radius(){} // RVA: 0x7FFD54A89CF0
        public void get_startTime(){} // RVA: 0x7FFD54A89D80
        public void get_time(){} // RVA: 0x7FFD54A89E00
        public void get_screen(){} // RVA: 0x7FFD54A89E40
        public void get_screenPosition(){} // RVA: 0x7FFD54A89EA0
        public void get_startScreenPosition(){} // RVA: 0x7FFD54A89F30
        public void get_delta(){} // RVA: 0x7FFD54A89FC0
        public void get_tapCount(){} // RVA: 0x7FFD54A8A050
        public void get_isTap(){} // RVA: 0x7FFD54A8A0D0
        public void get_displayIndex(){} // RVA: 0x7FFD54A8A150
        public void get_isInProgress(){} // RVA: 0x7FFD54A8A1D0
        public void get_updateStepCount(){} // RVA: 0x7FFD54A8A240
        public void get_uniqueId(){} // RVA: 0x7FFD54A8A2C0
        public void get_state(){} // RVA: 0x7FFD54A8A340
        public void get_extraData(){} // RVA: 0x7FFD54A8A380
        public void get_history(){} // RVA: 0x7FFD54A8A3C0
        public void get_activeTouches(){} // RVA: 0x7FFD54A8A4F0
        public void get_fingers(){} // RVA: 0x7FFD54A8A5F0
        public void get_activeFingers(){} // RVA: 0x7FFD54A8A680
        public void get_screens(){} // RVA: 0x7FFD54A8A720
        public void add_onFingerDown(){} // RVA: 0x7FFD54A8A7B0
        public void remove_onFingerDown(){} // RVA: 0x7FFD54A8A880
        public void add_onFingerUp(){} // RVA: 0x7FFD54A8A950
        public void remove_onFingerUp(){} // RVA: 0x7FFD54A8AA20
        public void add_onFingerMove(){} // RVA: 0x7FFD54A8AAF0
        public void remove_onFingerMove(){} // RVA: 0x7FFD54A8ABC0
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x7FFD54A8AC90
        public void .ctor(){} // RVA: 0x7FFD515148A0
        public void ToString(){} // RVA: 0x7FFD54A8ACF0
        public void Equals(){} // RVA: 0x7FFD54A8B1B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54A8B280
        public void AddTouchscreen(){} // RVA: 0x7FFD54A8B320
        public void RemoveTouchscreen(){} // RVA: 0x7FFD54A8B3C0
        public void BeginUpdate(){} // RVA: 0x7FFD54A8B500
        public void CreateGlobalState(){} // RVA: 0x7FFD54A8B580
        public void SaveAndResetState(){} // RVA: 0x7FFD54A8B5B0
        public void .cctor(){} // RVA: 0x7FFD54A8BCB0
    }

    public class TouchHistory : ValueType
    {
        public object Count;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54A8CD60
        public void GetEnumerator(){} // RVA: 0x7FFD54A8CE70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54A8CF30
        public void get_Count(){} // RVA: 0x7FFD4E38E5C0
        public void get_Item(){} // RVA: 0x7FFD54A8CF40
        public void CheckValid(){} // RVA: 0x7FFD54A8D0C0
    }

    public class TouchSimulation : MonoBehaviour
    {
        public object simulatedTouchscreen;
        public object instance;

        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x7FFD4E36F0C0
        public void set_simulatedTouchscreen(){} // RVA: 0x7FFD4E36F0D0
        public void get_instance(){} // RVA: 0x7FFD54A8D300
        public void Enable(){} // RVA: 0x7FFD54A8D340
        public void Disable(){} // RVA: 0x7FFD54A8D6E0
        public void Destroy(){} // RVA: 0x7FFD54A8D860
        public void AddPointer(){} // RVA: 0x7FFD54A8DA40
        public void RemovePointer(){} // RVA: 0x7FFD54A8DD10
        public void OnEvent(){} // RVA: 0x7FFD54A8E220
        public void OnDeviceChange(){} // RVA: 0x7FFD54A8E9D0
        public void OnEnable(){} // RVA: 0x7FFD54A8EB40
        public void OnDisable(){} // RVA: 0x7FFD54A8F330
        public void UpdateTouch(){} // RVA: 0x7FFD54A8F500
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFD4E341310
        public void InstallStateChangeMonitors(){} // RVA: 0x7FFD4E341310
        public void OnSourceControlChangedValue(){} // RVA: 0x7FFD4E341310
        public void UninstallStateChangeMonitors(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}