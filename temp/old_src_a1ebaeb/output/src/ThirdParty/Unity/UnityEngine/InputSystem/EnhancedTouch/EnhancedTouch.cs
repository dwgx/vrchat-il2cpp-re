// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport : Object
    {
        // ── Original Methods ──
        public void get_enabled(){} // RVA: 0x7ffaaf089300
        public void Enable(){} // RVA: 0x7ffaaf089340
        public void Disable(){} // RVA: 0x7ffaaf089540
        public void Reset(){} // RVA: 0x7ffaaf089760
        public void TearDownState(){} // RVA: 0x7ffaaf089ae0
        public void OnDeviceChange(){} // RVA: 0x7ffaaf089d80
        public void OnSettingsChange(){} // RVA: 0x7ffaaf08a050
        // ── Binary Analysis Named ──
        public void SetUpState(){} // RVA: 0x7ffaaf089830
        public void CheckEnabled(){} // RVA: 0x7ffaaf08a0e0
    }

    public class Finger : Object
    {
        public object m_StateHistory; // 0x33835980
        public object screen; // 0x170003E7

        // ── Original Methods ──
        public void get_screen(){} // RVA: 0x7ffaa894d380
        public void get_index(){} // RVA: 0x7ffaa8b945a0
        public void get_isActive(){} // RVA: 0x7ffaaf08a170
        public void get_screenPosition(){} // RVA: 0x7ffaaf08a210
        public void get_lastTouch(){} // RVA: 0x7ffaaf08a350
        public void get_currentTouch(){} // RVA: 0x7ffaaf08a4d0
        public void get_touchHistory(){} // RVA: 0x7ffaaf08a740
        public void .ctor(){} // RVA: 0x7ffaaf08a840
        public void ShouldRecordTouch(){} // RVA: 0x7ffaaf08aed0
        public void OnTouchRecorded(){} // RVA: 0x7ffaaf08af80
        public void FindTouch(){} // RVA: 0x7ffaaf08b2a0
        // ── Binary Analysis Named ──
        public void GetTouchHistory(){} // RVA: 0x7ffaaf08b550
    }

    public class Touch : ValueType
    {
        public object s_GlobalState; // 0x3376E190

        // ── Original Methods ──
        public void get_valid(){} // RVA: 0x7ffaaf08b970
        public void get_finger(){} // RVA: 0x7ffaa950bda0
        public void get_phase(){} // RVA: 0x7ffaaf08b9b0
        public void get_began(){} // RVA: 0x7ffaaf08ba30
        public void get_inProgress(){} // RVA: 0x7ffaaf08ba90
        public void get_ended(){} // RVA: 0x7ffaaf08bb40
        public void get_touchId(){} // RVA: 0x7ffaaf08bbd0
        public void get_pressure(){} // RVA: 0x7ffaaf08bc50
        public void get_radius(){} // RVA: 0x7ffaaf08bcd0
        public void get_startTime(){} // RVA: 0x7ffaaf08bd60
        public void get_time(){} // RVA: 0x7ffaaf08bde0
        public void get_screen(){} // RVA: 0x7ffaaf08be20
        public void get_screenPosition(){} // RVA: 0x7ffaaf08be80
        public void get_startScreenPosition(){} // RVA: 0x7ffaaf08bf10
        public void get_delta(){} // RVA: 0x7ffaaf08bfa0
        public void get_tapCount(){} // RVA: 0x7ffaaf08c030
        public void get_isTap(){} // RVA: 0x7ffaaf08c0b0
        public void get_displayIndex(){} // RVA: 0x7ffaaf08c130
        public void get_isInProgress(){} // RVA: 0x7ffaaf08c1b0
        public void get_updateStepCount(){} // RVA: 0x7ffaaf08c220
        public void get_uniqueId(){} // RVA: 0x7ffaaf08c2a0
        public void get_state(){} // RVA: 0x7ffaaf08c320
        public void get_extraData(){} // RVA: 0x7ffaaf08c360
        public void get_history(){} // RVA: 0x7ffaaf08c3a0
        public void get_activeTouches(){} // RVA: 0x7ffaaf08c4d0
        public void get_fingers(){} // RVA: 0x7ffaaf08c5d0
        public void get_activeFingers(){} // RVA: 0x7ffaaf08c660
        public void get_screens(){} // RVA: 0x7ffaaf08c700
        public void add_onFingerDown(){} // RVA: 0x7ffaaf08c790
        public void remove_onFingerDown(){} // RVA: 0x7ffaaf08c860
        public void add_onFingerUp(){} // RVA: 0x7ffaaf08c930
        public void remove_onFingerUp(){} // RVA: 0x7ffaaf08ca00
        public void add_onFingerMove(){} // RVA: 0x7ffaaf08cad0
        public void remove_onFingerMove(){} // RVA: 0x7ffaaf08cba0
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x7ffaaf08cc70
        public void .ctor(){} // RVA: 0x7ffaabb05e50
        public void ToString(){} // RVA: 0x7ffaaf08ccd0
        public void Equals(){} // RVA: 0x7ffaaf08d190
        public void Equals(){} // RVA: 0x7ffaaf08d190
        public void AddTouchscreen(){} // RVA: 0x7ffaaf08d300
        public void RemoveTouchscreen(){} // RVA: 0x7ffaaf08d3a0
        public void CreateGlobalState(){} // RVA: 0x7ffaaf08d560
        public void SaveAndResetState(){} // RVA: 0x7ffaaf08d590
        public void .cctor(){} // RVA: 0x7ffaaf08dc90
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf08d260
        public void BeginUpdate(){} // RVA: 0x7ffaaf08d4e0
    }

    public class TouchHistory : ValueType
    {
        public object m_Count; // 0x336CDC60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf08ed40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaf08ef10
        public void get_Count(){} // RVA: 0x7ffaa897f5c0
        public void get_Item(){} // RVA: 0x7ffaaf08ef20
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaf08ee50
        public void CheckValid(){} // RVA: 0x7ffaaf08f0a0
    }

    public class TouchSimulation : MonoBehaviour
    {
        public object m_Pointers; // 0x33C253F0
        public object m_Touches; // 0x33C253F0
        public object m_OnDeviceChange; // 0x33C253F0
        public object System.Collections.Generic; // 0x83BD2E70

        // ── Original Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x7ffaa89600c0
        public void set_simulatedTouchscreen(){} // RVA: 0x7ffaa89600d0
        public void get_instance(){} // RVA: 0x7ffaaf08f2e0
        public void Enable(){} // RVA: 0x7ffaaf08f320
        public void Disable(){} // RVA: 0x7ffaaf08f6c0
        public void Destroy(){} // RVA: 0x7ffaaf08f840
        public void AddPointer(){} // RVA: 0x7ffaaf08fa20
        public void RemovePointer(){} // RVA: 0x7ffaaf08fcf0
        public void OnEvent(){} // RVA: 0x7ffaaf090200
        public void OnDeviceChange(){} // RVA: 0x7ffaaf0909b0
        public void OnEnable(){} // RVA: 0x7ffaaf090b20
        public void OnDisable(){} // RVA: 0x7ffaaf091310
        public void UpdateTouch(){} // RVA: 0x7ffaaf0914e0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7ffaa8932310
        public void InstallStateChangeMonitors(){} // RVA: 0x7ffaa8932310
        public void OnSourceControlChangedValue(){} // RVA: 0x7ffaa8932310
        public void UninstallStateChangeMonitors(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}