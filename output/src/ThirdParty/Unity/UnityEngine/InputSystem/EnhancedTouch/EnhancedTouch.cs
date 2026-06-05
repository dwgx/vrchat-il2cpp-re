// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAF997EBF0
        public void Enable(){} // RVA: 0x7FFAF997EC30
        public void Disable(){} // RVA: 0x7FFAF997EE30
        public void Reset(){} // RVA: 0x7FFAF997F050
        public void SetUpState(){} // RVA: 0x7FFAF997F120
        public void TearDownState(){} // RVA: 0x7FFAF997F3D0
        public void OnDeviceChange(){} // RVA: 0x7FFAF997F670
        public void OnSettingsChange(){} // RVA: 0x7FFAF997F940
        public void CheckEnabled(){} // RVA: 0x7FFAF997F9D0
    }

    public class Finger
    {
        // ── Methods ──
        public void get_screen(){} // RVA: 0x7FFAF2DA8380
        public void get_index(){} // RVA: 0x7FFAF306ED50
        public void get_isActive(){} // RVA: 0x7FFAF997FA60
        public void get_screenPosition(){} // RVA: 0x7FFAF997FB00
        public void get_lastTouch(){} // RVA: 0x7FFAF997FC40
        public void get_currentTouch(){} // RVA: 0x7FFAF997FDC0
        public void get_touchHistory(){} // RVA: 0x7FFAF9980030
        public void .ctor(){} // RVA: 0x7FFAF9980130
        public void ShouldRecordTouch(){} // RVA: 0x7FFAF99807C0
        public void OnTouchRecorded(){} // RVA: 0x7FFAF9980870
        public void FindTouch(){} // RVA: 0x7FFAF9980B90
        public void GetTouchHistory(){} // RVA: 0x7FFAF9980E40
    }

    public class Touch
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAF9981260
        public void get_finger(){} // RVA: 0x7FFAF4584690
        public void get_phase(){} // RVA: 0x7FFAF99812A0
        public void get_began(){} // RVA: 0x7FFAF9981320
        public void get_inProgress(){} // RVA: 0x7FFAF9981380
        public void get_ended(){} // RVA: 0x7FFAF9981430
        public void get_touchId(){} // RVA: 0x7FFAF99814C0
        public void get_pressure(){} // RVA: 0x7FFAF9981540
        public void get_radius(){} // RVA: 0x7FFAF99815C0
        public void get_startTime(){} // RVA: 0x7FFAF9981650
        public void get_time(){} // RVA: 0x7FFAF99816D0
        public void get_screen(){} // RVA: 0x7FFAF9981710
        public void get_screenPosition(){} // RVA: 0x7FFAF9981770
        public void get_startScreenPosition(){} // RVA: 0x7FFAF9981800
        public void get_delta(){} // RVA: 0x7FFAF9981890
        public void get_tapCount(){} // RVA: 0x7FFAF9981920
        public void get_isTap(){} // RVA: 0x7FFAF99819A0
        public void get_displayIndex(){} // RVA: 0x7FFAF9981A20
        public void get_isInProgress(){} // RVA: 0x7FFAF9981AA0
        public void get_updateStepCount(){} // RVA: 0x7FFAF9981B10
        public void get_uniqueId(){} // RVA: 0x7FFAF9981B90
        public void get_state(){} // RVA: 0x7FFAF9981C10
        public void get_extraData(){} // RVA: 0x7FFAF9981C50
        public void get_history(){} // RVA: 0x7FFAF9981C90
        public void get_activeTouches(){} // RVA: 0x7FFAF9981DC0
        public void get_fingers(){} // RVA: 0x7FFAF9981EC0
        public void get_activeFingers(){} // RVA: 0x7FFAF9981F50
        public void get_screens(){} // RVA: 0x7FFAF9981FF0
        public void add_onFingerDown(){} // RVA: 0x7FFAF9982080
        public void remove_onFingerDown(){} // RVA: 0x7FFAF9982150
        public void add_onFingerUp(){} // RVA: 0x7FFAF9982220
        public void remove_onFingerUp(){} // RVA: 0x7FFAF99822F0
        public void add_onFingerMove(){} // RVA: 0x7FFAF99823C0
        public void remove_onFingerMove(){} // RVA: 0x7FFAF9982490
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x7FFAF9982560
        public void .ctor(){} // RVA: 0x7FFAF6279050
        public void ToString(){} // RVA: 0x7FFAF99825C0
        public void Equals(){} // RVA: 0x7FFAF9982A80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9982B50
        public void AddTouchscreen(){} // RVA: 0x7FFAF9982BF0
        public void RemoveTouchscreen(){} // RVA: 0x7FFAF9982C90
        public void BeginUpdate(){} // RVA: 0x7FFAF9982DD0
        public void CreateGlobalState(){} // RVA: 0x7FFAF9982E50
        public void SaveAndResetState(){} // RVA: 0x7FFAF9982E80
        public void .cctor(){} // RVA: 0x7FFAF9983580
    }

    public class TouchHistory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9984630
        public void GetEnumerator(){} // RVA: 0x7FFAF9984740
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF9984800
        public void get_Count(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Item(){} // RVA: 0x7FFAF9984810
        public void CheckValid(){} // RVA: 0x7FFAF9984990
    }

    public class TouchSimulation
    {
        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x7FFAF2DBB0C0
        public void set_simulatedTouchscreen(){} // RVA: 0x7FFAF2DBB0D0
        public void get_instance(){} // RVA: 0x7FFAF9984BD0
        public void Enable(){} // RVA: 0x7FFAF9984C10
        public void Disable(){} // RVA: 0x7FFAF9984FB0
        public void Destroy(){} // RVA: 0x7FFAF9985130
        public void AddPointer(){} // RVA: 0x7FFAF9985310
        public void RemovePointer(){} // RVA: 0x7FFAF99855E0
        public void OnEvent(){} // RVA: 0x7FFAF9985AF0
        public void OnDeviceChange(){} // RVA: 0x7FFAF99862A0
        public void OnEnable(){} // RVA: 0x7FFAF9986410
        public void OnDisable(){} // RVA: 0x7FFAF9986C00
        public void UpdateTouch(){} // RVA: 0x7FFAF9986DD0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFAF2D8D310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFAF2D8D310
        public void InstallStateChangeMonitors(){} // RVA: 0x7FFAF2D8D310
        public void OnSourceControlChangedValue(){} // RVA: 0x7FFAF2D8D310
        public void UninstallStateChangeMonitors(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

}