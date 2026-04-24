// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E35A5F0
        public void FindPairedButton(){} // RVA: 0x7FFD4E35A8B0
        public void OnDisable(){} // RVA: 0x7FFD4E35AB40
        public void OnPointerDown(){} // RVA: 0x7FFD4E35ABA0
        public void OnPointerUp(){} // RVA: 0x7FFD4E35AD40
        public void .ctor(){} // RVA: 0x7FFD4E35AE00
    }

    public class ButtonHandler : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void SetDownState(){} // RVA: 0x7FFD4E35AED0
        public void SetUpState(){} // RVA: 0x7FFD4E35AF90
        public void SetAxisPositiveState(){} // RVA: 0x7FFD4E35B050
        public void SetAxisNeutralState(){} // RVA: 0x7FFD4E35B110
        public void SetAxisNegativeState(){} // RVA: 0x7FFD4E35B1D0
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CrossPlatformInputManager : Object
    {
        public object mousePosition;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E35B290
        public void SwitchActiveInputMethod(){} // RVA: 0x7FFD4E35B470
        public void AxisExists(){} // RVA: 0x7FFD4E35B5D0
        public void ButtonExists(){} // RVA: 0x7FFD4E35B690
        public void RegisterVirtualAxis(){} // RVA: 0x7FFD4E35B750
        public void RegisterVirtualButton(){} // RVA: 0x7FFD4E35B7C0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFD4E35B830
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFD4E35B970
        public void VirtualAxisReference(){} // RVA: 0x7FFD4E35BA60
        public void GetAxis(){} // RVA: 0x7FFD4E35BC20 | overloaded x2
        public void GetAxisRaw(){} // RVA: 0x7FFD4E35BBC0
        public void GetButton(){} // RVA: 0x7FFD4E35BCB0
        public void GetButtonDown(){} // RVA: 0x7FFD4E35BD30
        public void GetButtonUp(){} // RVA: 0x7FFD4E35BDB0
        public void SetButtonDown(){} // RVA: 0x7FFD4E35BE30
        public void SetButtonUp(){} // RVA: 0x7FFD4E35BEB0
        public void SetAxisPositive(){} // RVA: 0x7FFD4E35BF30
        public void SetAxisNegative(){} // RVA: 0x7FFD4E35BFB0
        public void SetAxisZero(){} // RVA: 0x7FFD4E35C030
        public void SetAxis(){} // RVA: 0x7FFD4E35C0B0
        public void get_mousePosition(){} // RVA: 0x7FFD4E35C140
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFD4E35C1D0
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFD4E35C260
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFD4E35C2F0
    }

    public class InputAxisScrollbar : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD4E341310
        public void HandleInput(){} // RVA: 0x7FFD4E35C890
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Joystick : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E35C960
        public void Start(){} // RVA: 0x7FFD4E35C970
        public void UpdateVirtualAxes(){} // RVA: 0x7FFD4E35CA40
        public void CreateVirtualAxes(){} // RVA: 0x7FFD4E35CAC0
        public void OnDrag(){} // RVA: 0x7FFD4E35CD10
        public void OnPointerUp(){} // RVA: 0x7FFD4E35CFD0
        public void OnPointerDown(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD4E35D100
        public void .ctor(){} // RVA: 0x7FFD4E35D1D0
    }

    public class MobileControlRig : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E35D320
        public void Start(){} // RVA: 0x7FFD4E35D330
        public void CheckEnableControlRig(){} // RVA: 0x7FFD4E35D320
        public void EnableControlRig(){} // RVA: 0x7FFD4E35D4A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class TiltInput : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E35D7B0
        public void Update(){} // RVA: 0x7FFD4E35D900
        public void OnDisable(){} // RVA: 0x7FFD4E35DE00
        public void .ctor(){} // RVA: 0x7FFD4E35DE60
    }

    public class TouchPad : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E35DEB0
        public void Start(){} // RVA: 0x7FFD4E35DEC0
        public void CreateVirtualAxes(){} // RVA: 0x7FFD4E35E030
        public void UpdateVirtualAxes(){} // RVA: 0x7FFD4E35E280
        public void OnPointerDown(){} // RVA: 0x7FFD4E35E2F0
        public void Update(){} // RVA: 0x7FFD4E35E340
        public void OnPointerUp(){} // RVA: 0x7FFD4E35E590
        public void OnDisable(){} // RVA: 0x7FFD4E35E6A0
        public void .ctor(){} // RVA: 0x7FFD4E35E770
    }

    public class VirtualInput : Object
    {
        public object virtualMousePosition;

        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x7FFD4E35E8D0
        public void set_virtualMousePosition(){} // RVA: 0x7FFD4E35E8F0
        public void AxisExists(){} // RVA: 0x7FFD4E35E900
        public void ButtonExists(){} // RVA: 0x7FFD4E35E980
        public void RegisterVirtualAxis(){} // RVA: 0x7FFD4E35EA00
        public void RegisterVirtualButton(){} // RVA: 0x7FFD4E35ECD0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFD4E35EFA0
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFD4E35F040
        public void VirtualAxisReference(){} // RVA: 0x7FFD4E35F0E0
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFD4E35F190
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFD4E35F1B0
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFD4E35F1D0
        public void GetAxis(){}
        public void GetButton(){} // RVA: 0x7FFD4E079F60
        public void GetButtonDown(){} // RVA: 0x7FFD4E079F60
        public void GetButtonUp(){} // RVA: 0x7FFD4E079F60
        public void SetButtonDown(){} // RVA: 0x7FFD4E090A40
        public void SetButtonUp(){} // RVA: 0x7FFD4E090A40
        public void SetAxisPositive(){} // RVA: 0x7FFD4E090A40
        public void SetAxisNegative(){} // RVA: 0x7FFD4E090A40
        public void SetAxisZero(){} // RVA: 0x7FFD4E090A40
        public void SetAxis(){} // RVA: 0x7FFD4E09D7B0
        public void MousePosition(){} // RVA: 0x7FFD4E0788A0
        public void .ctor(){} // RVA: 0x7FFD4E35F200
    }

}