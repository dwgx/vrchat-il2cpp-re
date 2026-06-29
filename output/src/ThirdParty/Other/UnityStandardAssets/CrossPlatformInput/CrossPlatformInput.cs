// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A80F07C0
        public void FindPairedButton(){} // RVA: 0x7A80F0A80
        public void OnDisable(){} // RVA: 0x7A80F0D10
        public void OnPointerDown(){} // RVA: 0x7A80F0D70
        public void OnPointerUp(){} // RVA: 0x7A80F0F20
        public void .ctor(){} // RVA: 0x7A80F0FF0
    }

    public class ButtonHandler : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void SetDownState(){} // RVA: 0x7A80F10C0
        public void SetUpState(){} // RVA: 0x7A80F1180
        public void SetAxisPositiveState(){} // RVA: 0x7A80F1240
        public void SetAxisNeutralState(){} // RVA: 0x7A80F1300
        public void SetAxisNegativeState(){} // RVA: 0x7A80F13C0
        public void Update(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CrossPlatformInputManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A80F1480
        public void SwitchActiveInputMethod(){} // RVA: 0x7A80F1660
        public void AxisExists(){} // RVA: 0x7A80F17C0
        public void ButtonExists(){} // RVA: 0x7A80F1880
        public void RegisterVirtualAxis(){} // RVA: 0x7A80F1940
        public void RegisterVirtualButton(){} // RVA: 0x7A80F19B0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7A80F1A20
        public void UnRegisterVirtualButton(){} // RVA: 0x7A80F1B60
        public void VirtualAxisReference(){} // RVA: 0x7A80F1C50
        public void GetAxis(){} // RVA: 0x7A80F1E10
        public void GetAxisRaw(){} // RVA: 0x7A80F1DB0
        public void GetButton(){} // RVA: 0x7A80F1EA0
        public void GetButtonDown(){} // RVA: 0x7A80F1F20
        public void GetButtonUp(){} // RVA: 0x7A80F1FA0
        public void SetButtonDown(){} // RVA: 0x7A80F2020
        public void SetButtonUp(){} // RVA: 0x7A80F20A0
        public void SetAxisPositive(){} // RVA: 0x7A80F2120
        public void SetAxisNegative(){} // RVA: 0x7A80F21A0
        public void SetAxisZero(){} // RVA: 0x7A80F2220
        public void SetAxis(){} // RVA: 0x7A80F22A0
        public void get_mousePosition(){} // RVA: 0x7A80F2330
        public void SetVirtualMousePositionX(){} // RVA: 0x7A80F23C0
        public void SetVirtualMousePositionY(){} // RVA: 0x7A80F2450
        public void SetVirtualMousePositionZ(){} // RVA: 0x7A80F24E0
    }

    public class InputAxisScrollbar : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7A80D7310
        public void HandleInput(){} // RVA: 0x7A80F2A80
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class Joystick : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A80F2B50
        public void Start(){} // RVA: 0x7A80F2B60
        public void UpdateVirtualAxes(){} // RVA: 0x7A80F2C30
        public void CreateVirtualAxes(){} // RVA: 0x7A80F2CB0
        public void OnDrag(){} // RVA: 0x7A80F2F00
        public void OnPointerUp(){} // RVA: 0x7A80F31C0
        public void OnPointerDown(){} // RVA: 0x7A80D7310
        public void OnDisable(){} // RVA: 0x7A80F32F0
        public void .ctor(){} // RVA: 0x7A80F33C0
    }

    public class MobileControlRig : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A80F3510
        public void Start(){} // RVA: 0x7A80F3520
        public void CheckEnableControlRig(){} // RVA: 0x7A80F3510
        public void EnableControlRig(){} // RVA: 0x7A80F3690
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class TiltInput : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A80F3990
        public void Update(){} // RVA: 0x7A80F3AE0
        public void OnDisable(){} // RVA: 0x7A80F3FF0
        public void .ctor(){} // RVA: 0x7A80F4050
    }

    public class TouchPad : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A80F40A0
        public void Start(){} // RVA: 0x7A80F40B0
        public void CreateVirtualAxes(){} // RVA: 0x7A80F4220
        public void UpdateVirtualAxes(){} // RVA: 0x7A80F4470
        public void OnPointerDown(){} // RVA: 0x7A80F44E0
        public void Update(){} // RVA: 0x7A80F4530
        public void OnPointerUp(){} // RVA: 0x7A80F4780
        public void OnDisable(){} // RVA: 0x7A80F4890
        public void .ctor(){} // RVA: 0x7A80F4960
    }

    public class VirtualInput : Object
    {
        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x7A80F4AC0
        public void set_virtualMousePosition(){} // RVA: 0x7A80F4AE0
        public void AxisExists(){} // RVA: 0x7A80F4AF0
        public void ButtonExists(){} // RVA: 0x7A80F4B70
        public void RegisterVirtualAxis(){} // RVA: 0x7A80F4BF0
        public void RegisterVirtualButton(){} // RVA: 0x7A80F4EC0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7A80F5190
        public void UnRegisterVirtualButton(){} // RVA: 0x7A80F5230
        public void VirtualAxisReference(){} // RVA: 0x7A80F52D0
        public void SetVirtualMousePositionX(){} // RVA: 0x7A80F5380
        public void SetVirtualMousePositionY(){} // RVA: 0x7A80F53A0
        public void SetVirtualMousePositionZ(){} // RVA: 0x7A80F53C0
        public void GetAxis(){} // RVA: 0x7A7E15D30
        public void GetButton(){} // RVA: 0x7A7E019D0
        public void GetButtonDown(){} // RVA: 0x7A7E019D0
        public void GetButtonUp(){} // RVA: 0x7A7E019D0
        public void SetButtonDown(){} // RVA: 0x7A7E18800
        public void SetButtonUp(){} // RVA: 0x7A7E18800
        public void SetAxisPositive(){} // RVA: 0x7A7E18800
        public void SetAxisNegative(){} // RVA: 0x7A7E18800
        public void SetAxisZero(){} // RVA: 0x7A7E18800
        public void SetAxis(){} // RVA: 0x7A7E1DD40
        public void MousePosition(){} // RVA: 0x7A7E00490
        public void .ctor(){} // RVA: 0x7A80F53F0
        public void <virtualMousePosition>k__BackingField(){} // RVA: 0x7B3FB4428
    }

}