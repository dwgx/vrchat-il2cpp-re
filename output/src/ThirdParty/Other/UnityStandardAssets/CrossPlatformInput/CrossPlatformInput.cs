// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour
    {
        public string axisName; // 0x20
        public float axisValue; // 0x28
        public float responseSpeed; // 0x2C
        public float returnToCentreSpeed; // 0x30
        public UnityStandardAssets.CrossPlatformInput.AxisTouchButton m_PairedWith; // 0x38
        public VirtualAxis m_Axis; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2F3A5F0
        public void FindPairedButton(){} // RVA: 0x7FFAC2F3A8B0
        public void OnDisable(){} // RVA: 0x7FFAC2F3AB40
        public void OnPointerDown(){} // RVA: 0x7FFAC2F3ABA0
        public void OnPointerUp(){} // RVA: 0x7FFAC2F3AD40
        public void .ctor(){} // RVA: 0x7FFAC2F3AE00
    }

    public class ButtonHandler : MonoBehaviour
    {
        public string Name; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void SetDownState(){} // RVA: 0x7FFAC2F3AED0
        public void SetUpState(){} // RVA: 0x7FFAC2F3AF90
        public void SetAxisPositiveState(){} // RVA: 0x7FFAC2F3B050
        public void SetAxisNeutralState(){} // RVA: 0x7FFAC2F3B110
        public void SetAxisNegativeState(){} // RVA: 0x7FFAC2F3B1D0
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CrossPlatformInputManager : Object
    {
        public UnityStandardAssets.CrossPlatformInput.VirtualInput mousePosition;
        public UnityStandardAssets.CrossPlatformInput.VirtualInput s_TouchInput; // 0x8
        public UnityStandardAssets.CrossPlatformInput.VirtualInput s_HardwareInput; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2F3B290
        public void SwitchActiveInputMethod(){} // RVA: 0x7FFAC2F3B470
        public void AxisExists(){} // RVA: 0x7FFAC2F3B5D0
        public void ButtonExists(){} // RVA: 0x7FFAC2F3B690
        public void RegisterVirtualAxis(){} // RVA: 0x7FFAC2F3B750
        public void RegisterVirtualButton(){} // RVA: 0x7FFAC2F3B7C0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFAC2F3B830
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFAC2F3B970
        public void VirtualAxisReference(){} // RVA: 0x7FFAC2F3BA60
        public void GetAxis(){} // RVA: 0x7FFAC2F3BC20 | overloaded x2
        public void GetAxisRaw(){} // RVA: 0x7FFAC2F3BBC0
        public void GetButton(){} // RVA: 0x7FFAC2F3BCB0
        public void GetButtonDown(){} // RVA: 0x7FFAC2F3BD30
        public void GetButtonUp(){} // RVA: 0x7FFAC2F3BDB0
        public void SetButtonDown(){} // RVA: 0x7FFAC2F3BE30
        public void SetButtonUp(){} // RVA: 0x7FFAC2F3BEB0
        public void SetAxisPositive(){} // RVA: 0x7FFAC2F3BF30
        public void SetAxisNegative(){} // RVA: 0x7FFAC2F3BFB0
        public void SetAxisZero(){} // RVA: 0x7FFAC2F3C030
        public void SetAxis(){} // RVA: 0x7FFAC2F3C0B0
        public void get_mousePosition(){} // RVA: 0x7FFAC2F3C140
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFAC2F3C1D0
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFAC2F3C260
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFAC2F3C2F0
    }

    public class InputAxisScrollbar : MonoBehaviour
    {
        public string axis; // 0x20

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void HandleInput(){} // RVA: 0x7FFAC2F3C890
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Joystick : MonoBehaviour
    {
        public int MovementRange; // 0x20
        public 0x6B1BAEA0 axesToUse; // 0x24
        public string horizontalAxisName; // 0x28
        public string verticalAxisName; // 0x30
        public UnityEngine.Vector3 m_StartPos; // 0x38
        public bool m_UseX; // 0x44
        public bool m_UseY; // 0x45
        public VirtualAxis m_HorizontalVirtualAxis; // 0x48
        public VirtualAxis m_VerticalVirtualAxis; // 0x50

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2F3C960
        public void Start(){} // RVA: 0x7FFAC2F3C970
        public void UpdateVirtualAxes(){} // RVA: 0x7FFAC2F3CA40
        public void CreateVirtualAxes(){} // RVA: 0x7FFAC2F3CAC0
        public void OnDrag(){} // RVA: 0x7FFAC2F3CD10
        public void OnPointerUp(){} // RVA: 0x7FFAC2F3CFD0
        public void OnPointerDown(){} // RVA: 0x7FFAC2F21310
        public void OnDisable(){} // RVA: 0x7FFAC2F3D100
        public void .ctor(){} // RVA: 0x7FFAC2F3D1D0
    }

    public class MobileControlRig : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2F3D320
        public void Start(){} // RVA: 0x7FFAC2F3D330
        public void CheckEnableControlRig(){} // RVA: 0x7FFAC2F3D320
        public void EnableControlRig(){} // RVA: 0x7FFAC2F3D4A0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class TiltInput : MonoBehaviour
    {
        public AxisMapping mapping; // 0x20
        public 0x6B1BAFA8 tiltAroundAxis; // 0x28
        public float fullTiltAngle; // 0x2C
        public float centreAngleOffset; // 0x30
        public VirtualAxis m_SteerAxis; // 0x38

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2F3D7B0
        public void Update(){} // RVA: 0x7FFAC2F3D900
        public void OnDisable(){} // RVA: 0x7FFAC2F3DE00
        public void .ctor(){} // RVA: 0x7FFAC2F3DE60
    }

    public class TouchPad : MonoBehaviour
    {
        public 0x6B1BB108 axesToUse; // 0x20
        public 0x6B1BB160 controlStyle; // 0x24
        public string horizontalAxisName; // 0x28
        public string verticalAxisName; // 0x30
        public float Xsensitivity; // 0x38
        public float Ysensitivity; // 0x3C
        public UnityEngine.Vector3 m_StartPos; // 0x40
        public UnityEngine.Vector2 m_PreviousDelta; // 0x4C
        public UnityEngine.Vector3 m_JoytickOutput; // 0x54
        public bool m_UseX; // 0x60
        public bool m_UseY; // 0x61
        public VirtualAxis m_HorizontalVirtualAxis; // 0x68
        public VirtualAxis m_VerticalVirtualAxis; // 0x70
        public bool m_Dragging; // 0x78
        public int m_Id; // 0x7C
        public UnityEngine.Vector2 m_PreviousTouchPos; // 0x80
        public UnityEngine.Vector3 m_Center; // 0x88
        public UnityEngine.UI.Image m_Image; // 0x98

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2F3DEB0
        public void Start(){} // RVA: 0x7FFAC2F3DEC0
        public void CreateVirtualAxes(){} // RVA: 0x7FFAC2F3E030
        public void UpdateVirtualAxes(){} // RVA: 0x7FFAC2F3E280
        public void OnPointerDown(){} // RVA: 0x7FFAC2F3E2F0
        public void Update(){} // RVA: 0x7FFAC2F3E340
        public void OnPointerUp(){} // RVA: 0x7FFAC2F3E590
        public void OnDisable(){} // RVA: 0x7FFAC2F3E6A0
        public void .ctor(){} // RVA: 0x7FFAC2F3E770
    }

    public class VirtualInput : Object
    {
        public UnityEngine.Vector3 virtualMousePosition; // 0x10
        public System.Collections.Generic.Dictionary`2<string,VirtualAxis> m_VirtualAxes; // 0x20
        public System.Collections.Generic.Dictionary`2<string,VirtualButton> m_VirtualButtons; // 0x28
        public System.Collections.Generic.List`1<string> m_AlwaysUseVirtual; // 0x30

        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x7FFAC2F3E8D0
        public void set_virtualMousePosition(){} // RVA: 0x7FFAC2F3E8F0
        public void AxisExists(){} // RVA: 0x7FFAC2F3E900
        public void ButtonExists(){} // RVA: 0x7FFAC2F3E980
        public void RegisterVirtualAxis(){} // RVA: 0x7FFAC2F3EA00
        public void RegisterVirtualButton(){} // RVA: 0x7FFAC2F3ECD0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFAC2F3EFA0
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFAC2F3F040
        public void VirtualAxisReference(){} // RVA: 0x7FFAC2F3F0E0
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFAC2F3F190
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFAC2F3F1B0
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFAC2F3F1D0
        public void GetAxis(){}
        public void GetButton(){} // RVA: 0x7FFAC2C59F60
        public void GetButtonDown(){} // RVA: 0x7FFAC2C59F60
        public void GetButtonUp(){} // RVA: 0x7FFAC2C59F60
        public void SetButtonDown(){} // RVA: 0x7FFAC2C70A40
        public void SetButtonUp(){} // RVA: 0x7FFAC2C70A40
        public void SetAxisPositive(){} // RVA: 0x7FFAC2C70A40
        public void SetAxisNegative(){} // RVA: 0x7FFAC2C70A40
        public void SetAxisZero(){} // RVA: 0x7FFAC2C70A40
        public void SetAxis(){} // RVA: 0x7FFAC2C7D7B0
        public void MousePosition(){} // RVA: 0x7FFAC2C588A0
        public void .ctor(){} // RVA: 0x7FFAC2F3F200
    }

}