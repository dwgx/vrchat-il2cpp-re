// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 91

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport : Object
    {
        public object s_Enabled;
        public object s_UpdateMode;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x791B240
        public void Enable(){} // RVA: 0x791B280
        public void Disable(){} // RVA: 0x791B480
        public void Reset(){} // RVA: 0x791B6A0
        public void SetUpState(){} // RVA: 0x791B770
        public void TearDownState(){} // RVA: 0x791BA20
        public void OnDeviceChange(){} // RVA: 0x791BCD0
        public void OnSettingsChange(){} // RVA: 0x791BF80
        public void CheckEnabled(){} // RVA: 0x791C010
    }

    public class Finger : Object
    {
        public object _screen;
        public object _index;
        public object m_StateHistory;

        // ── Methods ──
        public void get_screen(){} // RVA: 0xB5DBF0
        public void get_index(){} // RVA: 0xE62D00
        public void get_isActive(){} // RVA: 0x791C0A0
        public void get_screenPosition(){} // RVA: 0x791C140
        public void get_lastTouch(){} // RVA: 0x791C280
        public void get_currentTouch(){} // RVA: 0x791C400
        public void get_touchHistory(){} // RVA: 0x791C670
        public void .ctor(){} // RVA: 0x791C770
        public void ShouldRecordTouch(){} // RVA: 0x791CDF0
        public void OnTouchRecorded(){} // RVA: 0x791CEA0
        public void FindTouch(){} // RVA: 0x791D1C0
        public void GetTouchHistory(){} // RVA: 0x791D470
    }

    public class Touch : ValueType
    {
        public object m_Finger;
        public object m_TouchRecord;
        public object s_GlobalState;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x939190
        public void get_finger(){} // RVA: 0x77900
        public void get_phase(){} // RVA: 0x9391D0
        public void get_began(){} // RVA: 0x9391E0
        public void get_inProgress(){} // RVA: 0x939240
        public void get_ended(){} // RVA: 0x9392F0
        public void get_touchId(){} // RVA: 0x939380
        public void get_pressure(){} // RVA: 0x939390
        public void get_radius(){} // RVA: 0x939410
        public void get_startTime(){} // RVA: 0x9394A0
        public void get_time(){} // RVA: 0x939520
        public void get_screen(){} // RVA: 0x939560
        public void get_screenPosition(){} // RVA: 0x9395C0
        public void get_startScreenPosition(){} // RVA: 0x9395D0
        public void get_delta(){} // RVA: 0x939660
        public void get_tapCount(){} // RVA: 0x939670
        public void get_isTap(){} // RVA: 0x9396F0
        public void get_displayIndex(){} // RVA: 0x939770
        public void get_isInProgress(){} // RVA: 0x9397F0
        public void get_updateStepCount(){} // RVA: 0x939800
        public void get_uniqueId(){} // RVA: 0x939810
        public void get_state(){} // RVA: 0x939820
        public void get_extraData(){} // RVA: 0x939860
        public void get_history(){} // RVA: 0x9398A0
        public void get_activeTouches(){} // RVA: 0x791E410
        public void get_fingers(){} // RVA: 0x791E510
        public void get_activeFingers(){} // RVA: 0x791E5A0
        public void get_screens(){} // RVA: 0x791E640
        public void add_onFingerDown(){} // RVA: 0x791E6D0
        public void remove_onFingerDown(){} // RVA: 0x791E7A0
        public void add_onFingerUp(){} // RVA: 0x791E870
        public void remove_onFingerUp(){} // RVA: 0x791E940
        public void add_onFingerMove(){} // RVA: 0x791EA10
        public void remove_onFingerMove(){} // RVA: 0x791EAE0
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x791EBB0
        public void .ctor(){} // RVA: 0x8C1290
        public void ToString(){} // RVA: 0x9399D0
        public void Equals(){} // RVA: 0x939A10
        public void GetHashCode(){} // RVA: 0x939A20
        public void AddTouchscreen(){} // RVA: 0x791F220
        public void RemoveTouchscreen(){} // RVA: 0x791F2C0
        public void BeginUpdate(){} // RVA: 0x791F400
        public void CreateGlobalState(){} // RVA: 0x791F480
        public void SaveAndResetState(){} // RVA: 0x791F4B0
        public void .cctor(){} // RVA: 0x791FBA0
    }

    public class TouchHistory : ValueType
    {
        public object m_History;
        public object m_Finger;
        public object m_Count;
        public object m_StartIndex;
        public object m_Version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x939D60
        public void GetEnumerator(){} // RVA: 0x939D70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x939D80
        public void get_Count(){} // RVA: 0x8C7E0
        public void get_Item(){} // RVA: 0x939D90
        public void CheckValid(){} // RVA: 0x939DC0
    }

    public class TouchSimulation : MonoBehaviour
    {
        public object _simulatedTouchscreen;
        public object m_NumPointers;
        public object m_Pointers;
        public object m_CurrentPositions;
        public object m_CurrentDisplayIndices;
        public object m_Touches;
        public object m_TouchIds;
        public object m_LastTouchId;
        public object m_OnDeviceChange;
        public object m_OnEvent;
        public object s_Instance;

        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0xB700F0
        public void set_simulatedTouchscreen(){} // RVA: 0xB70100
        public void get_instance(){} // RVA: 0x7921230
        public void Enable(){} // RVA: 0x7921270
        public void Disable(){} // RVA: 0x7921510
        public void Destroy(){} // RVA: 0x7921650
        public void AddPointer(){} // RVA: 0x7921820
        public void RemovePointer(){} // RVA: 0x7921AA0
        public void OnEvent(){} // RVA: 0x7921FD0
        public void OnDeviceChange(){} // RVA: 0x7922760
        public void OnEnable(){} // RVA: 0x79228B0
        public void OnDisable(){} // RVA: 0x79230A0
        public void UpdateTouch(){} // RVA: 0x7923280
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0xB43310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0xB43310
        public void InstallStateChangeMonitors(){} // RVA: 0xB43310
        public void OnSourceControlChangedValue(){} // RVA: 0xB43310
        public void UninstallStateChangeMonitors(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

}