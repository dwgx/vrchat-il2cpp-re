// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport
    {
        public int s_Enabled;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x6ECEBF0
        public void Enable(){} // RVA: 0x6ECEC30
        public void Disable(){} // RVA: 0x6ECEE30
        public void Reset(){} // RVA: 0x6ECF050
        public void SetUpState(){} // RVA: 0x6ECF120
        public void TearDownState(){} // RVA: 0x6ECF3D0
        public void OnDeviceChange(){} // RVA: 0x6ECF670
        public void OnSettingsChange(){} // RVA: 0x6ECF940
        public void CheckEnabled(){} // RVA: 0x6ECF9D0
    }

    public class Finger
    {
        public UnityEngine.InputSystem.Touchscreen <screen>k__BackingField; // 0x10
        public int <index>k__BackingField; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory; // 0x20

        // ── Methods ──
        public void get_screen(){} // RVA: 0x2F8380
        public void get_index(){} // RVA: 0x5BED50
        public void get_isActive(){} // RVA: 0x6ECFA60
        public void get_screenPosition(){} // RVA: 0x6ECFB00
        public void get_lastTouch(){} // RVA: 0x6ECFC40
        public void get_currentTouch(){} // RVA: 0x6ECFDC0
        public void get_touchHistory(){} // RVA: 0x6ED0030
        public void .ctor(){} // RVA: 0x6ED0130
        public void ShouldRecordTouch(){} // RVA: 0x6ED07C0
        public void OnTouchRecorded(){} // RVA: 0x6ED0870
        public void FindTouch(){} // RVA: 0x6ED0B90
        public void GetTouchHistory(){} // RVA: 0x6ED0E40
    }

    public class Touch
    {
        public UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger; // 0x10
        public Record<UnityEngine.InputSystem.LowLevel.TouchState> m_TouchRecord; // 0x18
        public GlobalState s_GlobalState;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x6ED1260
        public void get_finger(){} // RVA: 0x1AD4690
        public void get_phase(){} // RVA: 0x6ED12A0
        public void get_began(){} // RVA: 0x6ED1320
        public void get_inProgress(){} // RVA: 0x6ED1380
        public void get_ended(){} // RVA: 0x6ED1430
        public void get_touchId(){} // RVA: 0x6ED14C0
        public void get_pressure(){} // RVA: 0x6ED1540
        public void get_radius(){} // RVA: 0x6ED15C0
        public void get_startTime(){} // RVA: 0x6ED1650
        public void get_time(){} // RVA: 0x6ED16D0
        public void get_screen(){} // RVA: 0x6ED1710
        public void get_screenPosition(){} // RVA: 0x6ED1770
        public void get_startScreenPosition(){} // RVA: 0x6ED1800
        public void get_delta(){} // RVA: 0x6ED1890
        public void get_tapCount(){} // RVA: 0x6ED1920
        public void get_isTap(){} // RVA: 0x6ED19A0
        public void get_displayIndex(){} // RVA: 0x6ED1A20
        public void get_isInProgress(){} // RVA: 0x6ED1AA0
        public void get_updateStepCount(){} // RVA: 0x6ED1B10
        public void get_uniqueId(){} // RVA: 0x6ED1B90
        public void get_state(){} // RVA: 0x6ED1C10
        public void get_extraData(){} // RVA: 0x6ED1C50
        public void get_history(){} // RVA: 0x6ED1C90
        public void get_activeTouches(){} // RVA: 0x6ED1DC0
        public void get_fingers(){} // RVA: 0x6ED1EC0
        public void get_activeFingers(){} // RVA: 0x6ED1F50
        public void get_screens(){} // RVA: 0x6ED1FF0
        public void add_onFingerDown(){} // RVA: 0x6ED2080
        public void remove_onFingerDown(){} // RVA: 0x6ED2150
        public void add_onFingerUp(){} // RVA: 0x6ED2220
        public void remove_onFingerUp(){} // RVA: 0x6ED22F0
        public void add_onFingerMove(){} // RVA: 0x6ED23C0
        public void remove_onFingerMove(){} // RVA: 0x6ED2490
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x6ED2560
        public void .ctor(){} // RVA: 0x37C9050
        public void ToString(){} // RVA: 0x6ED25C0
        public void Equals(){} // RVA: 0x6ED2A80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6ED2B50
        public void AddTouchscreen(){} // RVA: 0x6ED2BF0
        public void RemoveTouchscreen(){} // RVA: 0x6ED2C90
        public void BeginUpdate(){} // RVA: 0x6ED2DD0
        public void CreateGlobalState(){} // RVA: 0x6ED2E50
        public void SaveAndResetState(){} // RVA: 0x6ED2E80
        public void .cctor(){} // RVA: 0x6ED3580
    }

    public class TouchHistory
    {
        public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> m_History; // 0x10
        public UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ED4630
        public void GetEnumerator(){} // RVA: 0x6ED4740
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6ED4800
        public void get_Count(){} // RVA: 0x32A5C0
        public void get_Item(){} // RVA: 0x6ED4810
        public void CheckValid(){} // RVA: 0x6ED4990
    }

    public class TouchSimulation
    {
        public UnityEngine.InputSystem.Touchscreen <simulatedTouchscreen>k__BackingField; // 0x20
        public int m_NumPointers; // 0x28

        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x30B0C0
        public void set_simulatedTouchscreen(){} // RVA: 0x30B0D0
        public void get_instance(){} // RVA: 0x6ED4BD0
        public void Enable(){} // RVA: 0x6ED4C10
        public void Disable(){} // RVA: 0x6ED4FB0
        public void Destroy(){} // RVA: 0x6ED5130
        public void AddPointer(){} // RVA: 0x6ED5310
        public void RemovePointer(){} // RVA: 0x6ED55E0
        public void OnEvent(){} // RVA: 0x6ED5AF0
        public void OnDeviceChange(){} // RVA: 0x6ED62A0
        public void OnEnable(){} // RVA: 0x6ED6410
        public void OnDisable(){} // RVA: 0x6ED6C00
        public void UpdateTouch(){} // RVA: 0x6ED6DD0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x2DD310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x2DD310
        public void InstallStateChangeMonitors(){} // RVA: 0x2DD310
        public void OnSourceControlChangedValue(){} // RVA: 0x2DD310
        public void UninstallStateChangeMonitors(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

}