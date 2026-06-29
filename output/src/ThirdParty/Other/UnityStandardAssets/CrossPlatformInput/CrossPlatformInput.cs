// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 92

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB5BE70
        public void FindPairedButton(){} // RVA: 0xB5C130
        public void OnDisable(){} // RVA: 0xB5C390
        public void OnPointerDown(){} // RVA: 0xB5C3F0
        public void OnPointerUp(){} // RVA: 0xB5C5A0
        public void .ctor(){} // RVA: 0xB5C670
    }

    public class ButtonHandler : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB43310
        public void SetDownState(){} // RVA: 0xB5C740
        public void SetUpState(){} // RVA: 0xB5C800
        public void SetAxisPositiveState(){} // RVA: 0xB5C8C0
        public void SetAxisNeutralState(){} // RVA: 0xB5C980
        public void SetAxisNegativeState(){} // RVA: 0xB5CA40
        public void Update(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CrossPlatformInputManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0xB5CB00
        public void SwitchActiveInputMethod(){} // RVA: 0xB5CCE0
        public void AxisExists(){} // RVA: 0xB5CE40
        public void ButtonExists(){} // RVA: 0xB5CF00
        public void RegisterVirtualAxis(){} // RVA: 0xB5CFC0
        public void RegisterVirtualButton(){} // RVA: 0xB5D030
        public void UnRegisterVirtualAxis(){} // RVA: 0xB5D0A0
        public void UnRegisterVirtualButton(){} // RVA: 0xB5D1E0
        public void VirtualAxisReference(){} // RVA: 0xB5D2D0
        public void GetAxis(){} // RVA: 0xB5D490
        public void GetAxisRaw(){} // RVA: 0xB5D430
        public void GetButton(){} // RVA: 0xB5D520
        public void GetButtonDown(){} // RVA: 0xB5D5A0
        public void GetButtonUp(){} // RVA: 0xB5D620
        public void SetButtonDown(){} // RVA: 0xB5D6A0
        public void SetButtonUp(){} // RVA: 0xB5D720
        public void SetAxisPositive(){} // RVA: 0xB5D7A0
        public void SetAxisNegative(){} // RVA: 0xB5D820
        public void SetAxisZero(){} // RVA: 0xB5D8A0
        public void SetAxis(){} // RVA: 0xB5D920
        public void get_mousePosition(){} // RVA: 0xB5D9B0
        public void SetVirtualMousePositionX(){} // RVA: 0xB5DA40
        public void SetVirtualMousePositionY(){} // RVA: 0xB5DAD0
        public void SetVirtualMousePositionZ(){} // RVA: 0xB5DB60
    }

    public class InputAxisScrollbar : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0xB43310
        public void HandleInput(){} // RVA: 0xB5E100
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Joystick : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB5E1D0
        public void Start(){} // RVA: 0xB5E1E0
        public void UpdateVirtualAxes(){} // RVA: 0xB5E2C0
        public void CreateVirtualAxes(){} // RVA: 0xB5E340
        public void OnDrag(){} // RVA: 0xB5E590
        public void OnPointerUp(){} // RVA: 0xB5E850
        public void OnPointerDown(){} // RVA: 0xB43310
        public void OnDisable(){} // RVA: 0xB5E990
        public void .ctor(){} // RVA: 0xB5EA60
    }

    public class MobileControlRig : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB5EBB0
        public void Start(){} // RVA: 0xB5EBC0
        public void CheckEnableControlRig(){} // RVA: 0xB5EBB0
        public void EnableControlRig(){} // RVA: 0xB5ED80
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class TiltInput : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB5F0E0
        public void Update(){} // RVA: 0xB5F230
        public void OnDisable(){} // RVA: 0xB5F740
        public void .ctor(){} // RVA: 0xB5F7A0
    }

    public class TouchPad : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB5F7F0
        public void Start(){} // RVA: 0xB5F800
        public void CreateVirtualAxes(){} // RVA: 0xB5F980
        public void UpdateVirtualAxes(){} // RVA: 0xB5FBD0
        public void OnPointerDown(){} // RVA: 0xB5FC40
        public void Update(){} // RVA: 0xB5FC90
        public void OnPointerUp(){} // RVA: 0xB5FEE0
        public void OnDisable(){} // RVA: 0xB5FFF0
        public void .ctor(){} // RVA: 0xB600C0
    }

    public class VirtualInput : Object
    {
        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0xB60220
        public void set_virtualMousePosition(){} // RVA: 0xB60240
        public void AxisExists(){} // RVA: 0xB60250
        public void ButtonExists(){} // RVA: 0xB602D0
        public void RegisterVirtualAxis(){} // RVA: 0xB60350
        public void RegisterVirtualButton(){} // RVA: 0xB60620
        public void UnRegisterVirtualAxis(){} // RVA: 0xB608F0
        public void UnRegisterVirtualButton(){} // RVA: 0xB60990
        public void VirtualAxisReference(){} // RVA: 0xB60A30
        public void SetVirtualMousePositionX(){} // RVA: 0xB60AE0
        public void SetVirtualMousePositionY(){} // RVA: 0xB60B00
        public void SetVirtualMousePositionZ(){} // RVA: 0xB60B20
        public void GetAxis(){} // RVA: 0x891710
        public void GetButton(){} // RVA: 0x87D350
        public void GetButtonDown(){} // RVA: 0x87D350
        public void GetButtonUp(){} // RVA: 0x87D350
        public void SetButtonDown(){} // RVA: 0x894320
        public void SetButtonUp(){} // RVA: 0x894320
        public void SetAxisPositive(){} // RVA: 0x894320
        public void SetAxisNegative(){} // RVA: 0x894320
        public void SetAxisZero(){} // RVA: 0x894320
        public void SetAxis(){} // RVA: 0x899A40
        public void MousePosition(){} // RVA: 0x87BEB0
        public void .ctor(){} // RVA: 0xB60B50
    }

}