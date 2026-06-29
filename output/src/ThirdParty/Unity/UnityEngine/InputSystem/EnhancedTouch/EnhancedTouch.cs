// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
// Classes: 5
// Methods: 92

namespace ThirdParty.Unity.UnityEngine.InputSystem.EnhancedTouch
{
    public class EnhancedTouchSupport : Object
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7AECAD440
        public void Enable(){} // RVA: 0x7AECAD480
        public void Disable(){} // RVA: 0x7AECAD680
        public void Reset(){} // RVA: 0x7AECAD8A0
        public void SetUpState(){} // RVA: 0x7AECAD970
        public void TearDownState(){} // RVA: 0x7AECADC20
        public void OnDeviceChange(){} // RVA: 0x7AECADED0
        public void OnSettingsChange(){} // RVA: 0x7AECAE180
        public void CheckEnabled(){} // RVA: 0x7AECAE210
    }

    public class Finger : Object
    {
        // ── Methods ──
        public void get_screen(){} // RVA: 0x7A80F2570
        public void get_index(){} // RVA: 0x7A83782A0
        public void get_isActive(){} // RVA: 0x7AECAE2A0
        public void get_screenPosition(){} // RVA: 0x7AECAE340
        public void get_lastTouch(){} // RVA: 0x7AECAE480
        public void get_currentTouch(){} // RVA: 0x7AECAE600
        public void get_touchHistory(){} // RVA: 0x7AECAE870
        public void .ctor(){} // RVA: 0x7AECAE970
        public void ShouldRecordTouch(){} // RVA: 0x7AECAEFF0
        public void OnTouchRecorded(){} // RVA: 0x7AECAF0A0
        public void FindTouch(){} // RVA: 0x7AECAF3C0
        public void GetTouchHistory(){} // RVA: 0x7AECAF670
        public void <screen>k__BackingField(){} // RVA: 0x7B3FA6F38
    }

    public class Touch : ValueType
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7A7EB6D90
        public void get_finger(){} // RVA: 0x7A765F710
        public void get_phase(){} // RVA: 0x7A7EB6DD0
        public void get_began(){} // RVA: 0x7A7EB6DE0
        public void get_inProgress(){} // RVA: 0x7A7EB6E40
        public void get_ended(){} // RVA: 0x7A7EB6EF0
        public void get_touchId(){} // RVA: 0x7A7EB6F80
        public void get_pressure(){} // RVA: 0x7A7EB6F90
        public void get_radius(){} // RVA: 0x7A7EB7010
        public void get_startTime(){} // RVA: 0x7A7EB70A0
        public void get_time(){} // RVA: 0x7A7EB7120
        public void get_screen(){} // RVA: 0x7A7EB7160
        public void get_screenPosition(){} // RVA: 0x7A7EB71C0
        public void get_startScreenPosition(){} // RVA: 0x7A7EB71D0
        public void get_delta(){} // RVA: 0x7A7EB7260
        public void get_tapCount(){} // RVA: 0x7A7EB7270
        public void get_isTap(){} // RVA: 0x7A7EB72F0
        public void get_displayIndex(){} // RVA: 0x7A7EB7370
        public void get_isInProgress(){} // RVA: 0x7A7EB73F0
        public void get_updateStepCount(){} // RVA: 0x7A7EB7400
        public void get_uniqueId(){} // RVA: 0x7A7EB7410
        public void get_state(){} // RVA: 0x7A7EB7420
        public void get_extraData(){} // RVA: 0x7A7EB7460
        public void get_history(){} // RVA: 0x7A7EB74A0
        public void get_activeTouches(){} // RVA: 0x7AECB0610
        public void get_fingers(){} // RVA: 0x7AECB0710
        public void get_activeFingers(){} // RVA: 0x7AECB07A0
        public void get_screens(){} // RVA: 0x7AECB0840
        public void add_onFingerDown(){} // RVA: 0x7AECB08D0
        public void remove_onFingerDown(){} // RVA: 0x7AECB09A0
        public void add_onFingerUp(){} // RVA: 0x7AECB0A70
        public void remove_onFingerUp(){} // RVA: 0x7AECB0B40
        public void add_onFingerMove(){} // RVA: 0x7AECB0C10
        public void remove_onFingerMove(){} // RVA: 0x7AECB0CE0
        public void get_maxHistoryLengthPerFinger(){} // RVA: 0x7AECB0DB0
        public void .ctor(){} // RVA: 0x7A7E43120
        public void ToString(){} // RVA: 0x7A7EB75D0
        public void Equals(){} // RVA: 0x7A7EB7610
        public void GetHashCode(){} // RVA: 0x7A7EB7620
        public void AddTouchscreen(){} // RVA: 0x7AECB1440
        public void RemoveTouchscreen(){} // RVA: 0x7AECB14E0
        public void BeginUpdate(){} // RVA: 0x7AECB1620
        public void CreateGlobalState(){} // RVA: 0x7AECB16A0
        public void SaveAndResetState(){} // RVA: 0x7AECB16D0
        public void .cctor(){} // RVA: 0x7AECB1DC0
    }

    public class TouchHistory : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EB7780
        public void GetEnumerator(){} // RVA: 0x7A7EB7790
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7EB77A0
        public void get_Count(){} // RVA: 0x7A7677B20
        public void get_Item(){} // RVA: 0x7A7EB77B0
        public void CheckValid(){} // RVA: 0x7A7EB77E0
    }

    public class TouchSimulation : MonoBehaviour
    {
        // ── Methods ──
        public void get_simulatedTouchscreen(){} // RVA: 0x7A81052C0
        public void set_simulatedTouchscreen(){} // RVA: 0x7A81052D0
        public void get_instance(){} // RVA: 0x7AECB3460
        public void Enable(){} // RVA: 0x7AECB34A0
        public void Disable(){} // RVA: 0x7AECB3840
        public void Destroy(){} // RVA: 0x7AECB39C0
        public void AddPointer(){} // RVA: 0x7AECB3BA0
        public void RemovePointer(){} // RVA: 0x7AECB3E20
        public void OnEvent(){} // RVA: 0x7AECB4350
        public void OnDeviceChange(){} // RVA: 0x7AECB4AE0
        public void OnEnable(){} // RVA: 0x7AECB4C30
        public void OnDisable(){} // RVA: 0x7AECB5420
        public void UpdateTouch(){} // RVA: 0x7AECB5600
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7A80D7310
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7A80D7310
        public void InstallStateChangeMonitors(){} // RVA: 0x7A80D7310
        public void OnSourceControlChangedValue(){} // RVA: 0x7A80D7310
        public void UninstallStateChangeMonitors(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

}