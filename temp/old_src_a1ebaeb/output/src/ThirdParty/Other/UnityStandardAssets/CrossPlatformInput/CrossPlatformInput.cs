// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour
    {
        public object responseSpeed; // 0x3399CCB0
        public object m_Axis; // 0x3399CCB0

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa894b5f0
        public void FindPairedButton(){} // RVA: 0x7ffaa894b8b0
        public void OnDisable(){} // RVA: 0x7ffaa894bb40
        public void OnPointerDown(){} // RVA: 0x7ffaa894bba0
        public void OnPointerUp(){} // RVA: 0x7ffaa894bd40
        public void .ctor(){} // RVA: 0x7ffaa894be00
    }

    public class ButtonHandler : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void Update(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetDownState(){} // RVA: 0x7ffaa894bed0
        public void SetUpState(){} // RVA: 0x7ffaa894bf90
        public void SetAxisPositiveState(){} // RVA: 0x7ffaa894c050
        public void SetAxisNeutralState(){} // RVA: 0x7ffaa894c110
        public void SetAxisNegativeState(){} // RVA: 0x7ffaa894c1d0
    }

    public class CrossPlatformInputManager : Object
    {
        public object s_HardwareInput; // 0x335A8390
        public object mousePosition; // 0x1700001E

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa894c290
        public void SwitchActiveInputMethod(){} // RVA: 0x7ffaa894c470
        public void AxisExists(){} // RVA: 0x7ffaa894c5d0
        public void ButtonExists(){} // RVA: 0x7ffaa894c690
        public void RegisterVirtualAxis(){} // RVA: 0x7ffaa894c750
        public void RegisterVirtualButton(){} // RVA: 0x7ffaa894c7c0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7ffaa894c830
        public void UnRegisterVirtualButton(){} // RVA: 0x7ffaa894c970
        public void VirtualAxisReference(){} // RVA: 0x7ffaa894ca60
        public void get_mousePosition(){} // RVA: 0x7ffaa894d140
        // ── Binary Analysis Named ──
        public void GetAxis(){} // RVA: 0x7ffaa894cc20
        public void GetAxisRaw(){} // RVA: 0x7ffaa894cbc0
        public void GetAxis(){} // RVA: 0x7ffaa894cc20
        public void GetButton(){} // RVA: 0x7ffaa894ccb0
        public void GetButtonDown(){} // RVA: 0x7ffaa894cd30
        public void GetButtonUp(){} // RVA: 0x7ffaa894cdb0
        public void SetButtonDown(){} // RVA: 0x7ffaa894ce30
        public void SetButtonUp(){} // RVA: 0x7ffaa894ceb0
        public void SetAxisPositive(){} // RVA: 0x7ffaa894cf30
        public void SetAxisNegative(){} // RVA: 0x7ffaa894cfb0
        public void SetAxisZero(){} // RVA: 0x7ffaa894d030
        public void SetAxis(){} // RVA: 0x7ffaa894d0b0
        public void SetVirtualMousePositionX(){} // RVA: 0x7ffaa894d1d0
        public void SetVirtualMousePositionY(){} // RVA: 0x7ffaa894d260
        public void SetVirtualMousePositionZ(){} // RVA: 0x7ffaa894d2f0
    }

    public class InputAxisScrollbar : MonoBehaviour
    {
        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaa8932310
        public void HandleInput(){} // RVA: 0x7ffaa894d890
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Joystick : MonoBehaviour
    {
        public object horizontalAxisName; // 0x33312620
        public object m_UseX; // 0x33312620
        public object m_VerticalVirtualAxis; // 0x33312620

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa894d960
        public void Start(){} // RVA: 0x7ffaa894d970
        public void UpdateVirtualAxes(){} // RVA: 0x7ffaa894da40
        public void CreateVirtualAxes(){} // RVA: 0x7ffaa894dac0
        public void OnDrag(){} // RVA: 0x7ffaa894dd10
        public void OnPointerUp(){} // RVA: 0x7ffaa894dfd0
        public void OnPointerDown(){} // RVA: 0x7ffaa8932310
        public void OnDisable(){} // RVA: 0x7ffaa894e100
        public void .ctor(){} // RVA: 0x7ffaa894e1d0
    }

    public class MobileControlRig : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa894e320
        public void Start(){} // RVA: 0x7ffaa894e330
        public void EnableControlRig(){} // RVA: 0x7ffaa894e4a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void CheckEnableControlRig(){} // RVA: 0x7ffaa894e320
    }

    public class TiltInput : MonoBehaviour
    {
        public object fullTiltAngle; // 0x337377E0

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa894e7b0
        public void Update(){} // RVA: 0x7ffaa894e900
        public void OnDisable(){} // RVA: 0x7ffaa894ee00
        public void .ctor(){} // RVA: 0x7ffaa894ee60
    }

    public class TouchPad : MonoBehaviour
    {
        public object horizontalAxisName; // 0x334AD800
        public object Ysensitivity; // 0x334AD800
        public object m_JoytickOutput; // 0x334AD800
        public object m_HorizontalVirtualAxis; // 0x334AD800
        public object m_Id; // 0x334AD800
        public object m_Image; // 0x334AD800

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa894eeb0
        public void Start(){} // RVA: 0x7ffaa894eec0
        public void CreateVirtualAxes(){} // RVA: 0x7ffaa894f030
        public void UpdateVirtualAxes(){} // RVA: 0x7ffaa894f280
        public void OnPointerDown(){} // RVA: 0x7ffaa894f2f0
        public void Update(){} // RVA: 0x7ffaa894f340
        public void OnPointerUp(){} // RVA: 0x7ffaa894f590
        public void OnDisable(){} // RVA: 0x7ffaa894f6a0
        public void .ctor(){} // RVA: 0x7ffaa894f770
    }

    public class VirtualInput : Object
    {
        public object m_VirtualButtons; // 0x33416D10

        // ── Original Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x7ffaa894f8d0
        public void set_virtualMousePosition(){} // RVA: 0x7ffaa894f8f0
        public void AxisExists(){} // RVA: 0x7ffaa894f900
        public void ButtonExists(){} // RVA: 0x7ffaa894f980
        public void RegisterVirtualAxis(){} // RVA: 0x7ffaa894fa00
        public void RegisterVirtualButton(){} // RVA: 0x7ffaa894fcd0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7ffaa894ffa0
        public void UnRegisterVirtualButton(){} // RVA: 0x7ffaa8950040
        public void VirtualAxisReference(){} // RVA: 0x7ffaa89500e0
        public void MousePosition(){} // RVA: 0x7ffaa8648be0
        public void .ctor(){} // RVA: 0x7ffaa8950200
        // ── Binary Analysis Named ──
        public void SetVirtualMousePositionX(){} // RVA: 0x7ffaa8950190
        public void SetVirtualMousePositionY(){} // RVA: 0x7ffaa89501b0
        public void SetVirtualMousePositionZ(){} // RVA: 0x7ffaa89501d0
        public void GetAxis(){}
        public void GetButton(){} // RVA: 0x7ffaa864a2a0
        public void GetButtonDown(){} // RVA: 0x7ffaa864a2a0
        public void GetButtonUp(){} // RVA: 0x7ffaa864a2a0
        public void SetButtonDown(){} // RVA: 0x7ffaa8660d80
        public void SetButtonUp(){} // RVA: 0x7ffaa8660d80
        public void SetAxisPositive(){} // RVA: 0x7ffaa8660d80
        public void SetAxisNegative(){} // RVA: 0x7ffaa8660d80
        public void SetAxisZero(){} // RVA: 0x7ffaa8660d80
        public void SetAxis(){} // RVA: 0x7ffaa866daf0
    }

}