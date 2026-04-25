// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 3
// Methods: 45

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : OnScreenControl
    {
        public object controlPathInternal;

        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFD54A78F00
        public void OnPointerDown(){} // RVA: 0x7FFD54A78F50
        public void get_controlPathInternal(){} // RVA: 0x7FFD4E5F0140
        public void set_controlPathInternal(){} // RVA: 0x7FFD4E5F0C20
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnScreenControl : MonoBehaviour
    {
        public object controlPath;
        public object control;
        public object controlPathInternal;
        public object HasAnyActive;

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x7FFD4E3F5BC0
        public void set_controlPath(){} // RVA: 0x7FFD54A78FA0
        public void get_control(){} // RVA: 0x7FFD4E36F0C0
        public void get_controlPathInternal(){} // RVA: 0x7FFD4E078E90
        public void set_controlPathInternal(){} // RVA: 0x7FFD4E090A40
        public void SetupInputControl(){} // RVA: 0x7FFD54A79020
        public void SendValueToControl(){} // RVA: 0x7FFD4E2ADC40
        public void SentDefaultValueToControl(){} // RVA: 0x7FFD54A79A90
        public void get_HasAnyActive(){} // RVA: 0x7FFD54A79B60
        public void OnEnable(){} // RVA: 0x7FFD54A79BA0
        public void OnDisable(){} // RVA: 0x7FFD54A79F80
        public void GetWarningMessage(){} // RVA: 0x7FFD54A7A2C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnScreenStick : OnScreenControl
    {
        public object movementRange;
        public object dynamicOriginRange;
        public object useIsolatedInputActions;
        public object controlPathInternal;
        public object behaviour;

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFD54A7BF50 | overloaded x2
        public void OnDrag(){} // RVA: 0x7FFD54A7AB10
        public void OnPointerUp(){} // RVA: 0x7FFD54A7C8C0 | overloaded x2
        public void Start(){} // RVA: 0x7FFD54A7ABD0
        public void OnDestroy(){} // RVA: 0x7FFD54A7B610
        public void BeginInteraction(){} // RVA: 0x7FFD54A7B6E0
        public void MoveStick(){} // RVA: 0x7FFD54A7B9D0
        public void EndInteraction(){} // RVA: 0x7FFD54A7BDC0
        public void OnPointerChanged(){} // RVA: 0x7FFD54A7C5B0
        public void OnPointerMove(){} // RVA: 0x7FFD54A7C780
        public void GetCameraFromCanvas(){} // RVA: 0x7FFD54A7CA00
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD54A7CBF0
        public void DrawGizmoCircle(){} // RVA: 0x7FFD54A7D170
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x7FFD54A7D330
        public void get_movementRange(){} // RVA: 0x7FFD4EB36E90
        public void set_movementRange(){} // RVA: 0x7FFD4EB37190
        public void get_dynamicOriginRange(){} // RVA: 0x7FFD4EA5CE20
        public void set_dynamicOriginRange(){} // RVA: 0x7FFD54A7D5C0
        public void get_useIsolatedInputActions(){} // RVA: 0x7FFD4F588960
        public void set_useIsolatedInputActions(){} // RVA: 0x7FFD4F58A6F0
        public void get_controlPathInternal(){} // RVA: 0x7FFD4E3BE740
        public void set_controlPathInternal(){} // RVA: 0x7FFD4E369200
        public void get_behaviour(){} // RVA: 0x7FFD4E3E20C0
        public void set_behaviour(){} // RVA: 0x7FFD4E3E20D0
        public void .ctor(){} // RVA: 0x7FFD54A7D5E0
    }

}