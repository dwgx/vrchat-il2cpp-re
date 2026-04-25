// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 4
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : OnScreenControl
    {
        public string controlPathInternal; // 0x38

        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFAC9658F00
        public void OnPointerDown(){} // RVA: 0x7FFAC9658F50
        public void get_controlPathInternal(){} // RVA: 0x7FFAC31D0140
        public void set_controlPathInternal(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnScreenControl : MonoBehaviour
    {
        public UnityEngine.InputSystem.InputControl controlPath; // 0x20
        public UnityEngine.InputSystem.OnScreen.OnScreenControl control; // 0x28
        public UnityEngine.InputSystem.LowLevel.InputEventPtr controlPathInternal; // 0x30
        public int HasAnyActive;
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<OnScreenDeviceInfo> s_OnScreenDevices; // 0x8

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x7FFAC2FD5BC0
        public void set_controlPath(){} // RVA: 0x7FFAC9658FA0
        public void get_control(){} // RVA: 0x7FFAC2F4F0C0
        public void get_controlPathInternal(){} // RVA: 0x7FFAC2C58E90
        public void set_controlPathInternal(){} // RVA: 0x7FFAC2C70A40
        public void SetupInputControl(){} // RVA: 0x7FFAC9659020
        public void SendValueToControl(){} // RVA: 0x7FFAC2E8DC40
        public void SentDefaultValueToControl(){} // RVA: 0x7FFAC9659A90
        public void get_HasAnyActive(){} // RVA: 0x7FFAC9659B60
        public void OnEnable(){} // RVA: 0x7FFAC9659BA0
        public void OnDisable(){} // RVA: 0x7FFAC9659F80
        public void GetWarningMessage(){} // RVA: 0x7FFAC965A2C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnScreenStick : OnScreenControl
    {
        public string movementRange;
        public float dynamicOriginRange; // 0x38
        public float useIsolatedInputActions; // 0x3C
        public string controlPathInternal; // 0x40
        public 0x6B14B690 behaviour; // 0x48
        public bool m_UseIsolatedInputActions; // 0x4C
        public UnityEngine.InputSystem.InputAction m_PointerDownAction; // 0x50
        public UnityEngine.InputSystem.InputAction m_PointerMoveAction; // 0x58
        public UnityEngine.Vector3 m_StartPos; // 0x60
        public UnityEngine.Vector2 m_PointerDownPos; // 0x6C
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult> m_RaycastResults; // 0x78
        public UnityEngine.EventSystems.PointerEventData m_PointerEventData; // 0x80
        public UnityEngine.InputSystem.Controls.TouchControl m_TouchControl; // 0x88
        public bool m_IsIsolationActive; // 0x90

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFAC965BF50 | overloaded x2
        public void OnDrag(){} // RVA: 0x7FFAC965AB10
        public void OnPointerUp(){} // RVA: 0x7FFAC965C8C0 | overloaded x2
        public void Start(){} // RVA: 0x7FFAC965ABD0
        public void OnDestroy(){} // RVA: 0x7FFAC965B610
        public void BeginInteraction(){} // RVA: 0x7FFAC965B6E0
        public void MoveStick(){} // RVA: 0x7FFAC965B9D0
        public void EndInteraction(){} // RVA: 0x7FFAC965BDC0
        public void OnPointerChanged(){} // RVA: 0x7FFAC965C5B0
        public void OnPointerMove(){} // RVA: 0x7FFAC965C780
        public void GetCameraFromCanvas(){} // RVA: 0x7FFAC965CA00
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC965CBF0
        public void DrawGizmoCircle(){} // RVA: 0x7FFAC965D170
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x7FFAC965D330
        public void get_movementRange(){} // RVA: 0x7FFAC3716E90
        public void set_movementRange(){} // RVA: 0x7FFAC3717190
        public void get_dynamicOriginRange(){} // RVA: 0x7FFAC363CE20
        public void set_dynamicOriginRange(){} // RVA: 0x7FFAC965D5C0
        public void get_useIsolatedInputActions(){} // RVA: 0x7FFAC4168960
        public void set_useIsolatedInputActions(){} // RVA: 0x7FFAC416A6F0
        public void get_controlPathInternal(){} // RVA: 0x7FFAC2F9E740
        public void set_controlPathInternal(){} // RVA: 0x7FFAC2F49200
        public void get_behaviour(){} // RVA: 0x7FFAC2FC20C0
        public void set_behaviour(){} // RVA: 0x7FFAC2FC20D0
        public void .ctor(){} // RVA: 0x7FFAC965D5E0
    }

    public class UGUIOnScreenControlUtils : Object
    {
        // ── Methods ──
        public void GetCanvasRectTransform(){} // RVA: 0x7FFAC965A8D0
    }

}