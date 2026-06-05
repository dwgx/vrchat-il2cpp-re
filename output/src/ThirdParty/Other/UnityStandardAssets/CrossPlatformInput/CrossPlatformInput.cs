// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF2DA65F0
        public void FindPairedButton(){} // RVA: 0x7FFAF2DA68B0
        public void OnDisable(){} // RVA: 0x7FFAF2DA6B40
        public void OnPointerDown(){} // RVA: 0x7FFAF2DA6BA0
        public void OnPointerUp(){} // RVA: 0x7FFAF2DA6D40
        public void .ctor(){} // RVA: 0x7FFAF2DA6E00
    }

    public class ButtonHandler
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF2D8D310
        public void SetDownState(){} // RVA: 0x7FFAF2DA6ED0
        public void SetUpState(){} // RVA: 0x7FFAF2DA6F90
        public void SetAxisPositiveState(){} // RVA: 0x7FFAF2DA7050
        public void SetAxisNeutralState(){} // RVA: 0x7FFAF2DA7110
        public void SetAxisNegativeState(){} // RVA: 0x7FFAF2DA71D0
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CrossPlatformInputManager
    {
        public object inProgress;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2DA7290
        public void SwitchActiveInputMethod(){} // RVA: 0x7FFAF2DA7470
        public void AxisExists(){} // RVA: 0x7FFAF2DA75D0
        public void ButtonExists(){} // RVA: 0x7FFAF2DA7690
        public void RegisterVirtualAxis(){} // RVA: 0x7FFAF2DA7750
        public void RegisterVirtualButton(){} // RVA: 0x7FFAF2DA77C0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFAF2DA7830
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFAF2DA7970
        public void VirtualAxisReference(){} // RVA: 0x7FFAF2DA7A60
        public void GetAxis(){} // RVA: 0x7FFAF2DA7C20 | overloaded x2
        public void GetAxisRaw(){} // RVA: 0x7FFAF2DA7BC0
        public void GetButton(){} // RVA: 0x7FFAF2DA7CB0
        public void GetButtonDown(){} // RVA: 0x7FFAF2DA7D30
        public void GetButtonUp(){} // RVA: 0x7FFAF2DA7DB0
        public void SetButtonDown(){} // RVA: 0x7FFAF2DA7E30
        public void SetButtonUp(){} // RVA: 0x7FFAF2DA7EB0
        public void SetAxisPositive(){} // RVA: 0x7FFAF2DA7F30
        public void SetAxisNegative(){} // RVA: 0x7FFAF2DA7FB0
        public void SetAxisZero(){} // RVA: 0x7FFAF2DA8030
        public void SetAxis(){} // RVA: 0x7FFAF2DA80B0
        public void get_mousePosition(){} // RVA: 0x7FFAF2DA8140
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFAF2DA81D0
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFAF2DA8260
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFAF2DA82F0
    }

    public class InputAxisScrollbar
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void HandleInput(){} // RVA: 0x7FFAF2DA8890
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Joystick
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF2DA8960
        public void Start(){} // RVA: 0x7FFAF2DA8970
        public void UpdateVirtualAxes(){} // RVA: 0x7FFAF2DA8A40
        public void CreateVirtualAxes(){} // RVA: 0x7FFAF2DA8AC0
        public void OnDrag(){} // RVA: 0x7FFAF2DA8D10
        public void OnPointerUp(){} // RVA: 0x7FFAF2DA8FD0
        public void OnPointerDown(){} // RVA: 0x7FFAF2D8D310
        public void OnDisable(){} // RVA: 0x7FFAF2DA9100
        public void .ctor(){} // RVA: 0x7FFAF2DA91D0
    }

    public class MobileControlRig
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF2DA9320
        public void Start(){} // RVA: 0x7FFAF2DA9330
        public void CheckEnableControlRig(){} // RVA: 0x7FFAF2DA9320
        public void EnableControlRig(){} // RVA: 0x7FFAF2DA94A0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class TiltInput
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF2DA97B0
        public void Update(){} // RVA: 0x7FFAF2DA9900
        public void OnDisable(){} // RVA: 0x7FFAF2DA9E00
        public void .ctor(){} // RVA: 0x7FFAF2DA9E60
    }

    public class TouchPad
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF2DA9EB0
        public void Start(){} // RVA: 0x7FFAF2DA9EC0
        public void CreateVirtualAxes(){} // RVA: 0x7FFAF2DAA030
        public void UpdateVirtualAxes(){} // RVA: 0x7FFAF2DAA280
        public void OnPointerDown(){} // RVA: 0x7FFAF2DAA2F0
        public void Update(){} // RVA: 0x7FFAF2DAA340
        public void OnPointerUp(){} // RVA: 0x7FFAF2DAA590
        public void OnDisable(){} // RVA: 0x7FFAF2DAA6A0
        public void .ctor(){} // RVA: 0x7FFAF2DAA770
    }

    public class VirtualInput
    {
        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x7FFAF2DAA8D0
        public void set_virtualMousePosition(){} // RVA: 0x7FFAF2DAA8F0
        public void AxisExists(){} // RVA: 0x7FFAF2DAA900
        public void ButtonExists(){} // RVA: 0x7FFAF2DAA980
        public void RegisterVirtualAxis(){} // RVA: 0x7FFAF2DAAA00
        public void RegisterVirtualButton(){} // RVA: 0x7FFAF2DAACD0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFAF2DAAFA0
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFAF2DAB040
        public void VirtualAxisReference(){} // RVA: 0x7FFAF2DAB0E0
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFAF2DAB190
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFAF2DAB1B0
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFAF2DAB1D0
        public void GetAxis(){}
        public void GetButton(){} // RVA: 0x7FFAF2ABDE40
        public void GetButtonDown(){} // RVA: 0x7FFAF2ABDE40
        public void GetButtonUp(){} // RVA: 0x7FFAF2ABDE40
        public void SetButtonDown(){} // RVA: 0x7FFAF2AD4B10
        public void SetButtonUp(){} // RVA: 0x7FFAF2AD4B10
        public void SetAxisPositive(){} // RVA: 0x7FFAF2AD4B10
        public void SetAxisNegative(){} // RVA: 0x7FFAF2AD4B10
        public void SetAxisZero(){} // RVA: 0x7FFAF2AD4B10
        public void SetAxis(){} // RVA: 0x7FFAF2AE18E0
        public void MousePosition(){} // RVA: 0x7FFAF2ABC770
        public void .ctor(){} // RVA: 0x7FFAF2DAB200
    }

}