// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x2F65F0
        public void FindPairedButton(){} // RVA: 0x2F68B0
        public void OnDisable(){} // RVA: 0x2F6B40
        public void OnPointerDown(){} // RVA: 0x2F6BA0
        public void OnPointerUp(){} // RVA: 0x2F6D40
        public void .ctor(){} // RVA: 0x2F6E00
    }

    public class ButtonHandler
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x2DD310
        public void SetDownState(){} // RVA: 0x2F6ED0
        public void SetUpState(){} // RVA: 0x2F6F90
        public void SetAxisPositiveState(){} // RVA: 0x2F7050
        public void SetAxisNeutralState(){} // RVA: 0x2F7110
        public void SetAxisNegativeState(){} // RVA: 0x2F71D0
        public void Update(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CrossPlatformInputManager
    {
        public object inProgress;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x2F7290
        public void SwitchActiveInputMethod(){} // RVA: 0x2F7470
        public void AxisExists(){} // RVA: 0x2F75D0
        public void ButtonExists(){} // RVA: 0x2F7690
        public void RegisterVirtualAxis(){} // RVA: 0x2F7750
        public void RegisterVirtualButton(){} // RVA: 0x2F77C0
        public void UnRegisterVirtualAxis(){} // RVA: 0x2F7830
        public void UnRegisterVirtualButton(){} // RVA: 0x2F7970
        public void VirtualAxisReference(){} // RVA: 0x2F7A60
        public void GetAxis(){} // RVA: 0x2F7C20 | overloaded x2
        public void GetAxisRaw(){} // RVA: 0x2F7BC0
        public void GetButton(){} // RVA: 0x2F7CB0
        public void GetButtonDown(){} // RVA: 0x2F7D30
        public void GetButtonUp(){} // RVA: 0x2F7DB0
        public void SetButtonDown(){} // RVA: 0x2F7E30
        public void SetButtonUp(){} // RVA: 0x2F7EB0
        public void SetAxisPositive(){} // RVA: 0x2F7F30
        public void SetAxisNegative(){} // RVA: 0x2F7FB0
        public void SetAxisZero(){} // RVA: 0x2F8030
        public void SetAxis(){} // RVA: 0x2F80B0
        public void get_mousePosition(){} // RVA: 0x2F8140
        public void SetVirtualMousePositionX(){} // RVA: 0x2F81D0
        public void SetVirtualMousePositionY(){} // RVA: 0x2F8260
        public void SetVirtualMousePositionZ(){} // RVA: 0x2F82F0
    }

    public class InputAxisScrollbar
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x2DD310
        public void HandleInput(){} // RVA: 0x2F8890
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Joystick
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x2F8960
        public void Start(){} // RVA: 0x2F8970
        public void UpdateVirtualAxes(){} // RVA: 0x2F8A40
        public void CreateVirtualAxes(){} // RVA: 0x2F8AC0
        public void OnDrag(){} // RVA: 0x2F8D10
        public void OnPointerUp(){} // RVA: 0x2F8FD0
        public void OnPointerDown(){} // RVA: 0x2DD310
        public void OnDisable(){} // RVA: 0x2F9100
        public void .ctor(){} // RVA: 0x2F91D0
    }

    public class MobileControlRig
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x2F9320
        public void Start(){} // RVA: 0x2F9330
        public void CheckEnableControlRig(){} // RVA: 0x2F9320
        public void EnableControlRig(){} // RVA: 0x2F94A0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class TiltInput
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x2F97B0
        public void Update(){} // RVA: 0x2F9900
        public void OnDisable(){} // RVA: 0x2F9E00
        public void .ctor(){} // RVA: 0x2F9E60
    }

    public class TouchPad
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x2F9EB0
        public void Start(){} // RVA: 0x2F9EC0
        public void CreateVirtualAxes(){} // RVA: 0x2FA030
        public void UpdateVirtualAxes(){} // RVA: 0x2FA280
        public void OnPointerDown(){} // RVA: 0x2FA2F0
        public void Update(){} // RVA: 0x2FA340
        public void OnPointerUp(){} // RVA: 0x2FA590
        public void OnDisable(){} // RVA: 0x2FA6A0
        public void .ctor(){} // RVA: 0x2FA770
    }

    public class VirtualInput
    {
        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x2FA8D0
        public void set_virtualMousePosition(){} // RVA: 0x2FA8F0
        public void AxisExists(){} // RVA: 0x2FA900
        public void ButtonExists(){} // RVA: 0x2FA980
        public void RegisterVirtualAxis(){} // RVA: 0x2FAA00
        public void RegisterVirtualButton(){} // RVA: 0x2FACD0
        public void UnRegisterVirtualAxis(){} // RVA: 0x2FAFA0
        public void UnRegisterVirtualButton(){} // RVA: 0x2FB040
        public void VirtualAxisReference(){} // RVA: 0x2FB0E0
        public void SetVirtualMousePositionX(){} // RVA: 0x2FB190
        public void SetVirtualMousePositionY(){} // RVA: 0x2FB1B0
        public void SetVirtualMousePositionZ(){} // RVA: 0x2FB1D0
        public void GetAxis(){}
        public void GetButton(){} // RVA: 0xDE40
        public void GetButtonDown(){} // RVA: 0xDE40
        public void GetButtonUp(){} // RVA: 0xDE40
        public void SetButtonDown(){} // RVA: 0x24B10
        public void SetButtonUp(){} // RVA: 0x24B10
        public void SetAxisPositive(){} // RVA: 0x24B10
        public void SetAxisNegative(){} // RVA: 0x24B10
        public void SetAxisZero(){} // RVA: 0x24B10
        public void SetAxis(){} // RVA: 0x318E0
        public void MousePosition(){} // RVA: 0xC770
        public void .ctor(){} // RVA: 0x2FB200
    }

}