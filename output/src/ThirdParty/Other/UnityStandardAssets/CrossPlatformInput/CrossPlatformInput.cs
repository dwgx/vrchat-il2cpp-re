// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE811145F0
        public void FindPairedButton(){} // RVA: 0x7FFE811148B0
        public void OnDisable(){} // RVA: 0x7FFE81114B40
        public void OnPointerDown(){} // RVA: 0x7FFE81114BA0
        public void OnPointerUp(){} // RVA: 0x7FFE81114D40
        public void .ctor(){} // RVA: 0x7FFE81114E00
    }

    public class ButtonHandler : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void SetDownState(){} // RVA: 0x7FFE81114ED0
        public void SetUpState(){} // RVA: 0x7FFE81114F90
        public void SetAxisPositiveState(){} // RVA: 0x7FFE81115050
        public void SetAxisNeutralState(){} // RVA: 0x7FFE81115110
        public void SetAxisNegativeState(){} // RVA: 0x7FFE811151D0
        public void Update(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CrossPlatformInputManager : Object
    {
        public UnityStandardAssets.CrossPlatformInput.VirtualInput activeInput;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE81115290
        public void SwitchActiveInputMethod(){} // RVA: 0x7FFE81115470
        public void AxisExists(){} // RVA: 0x7FFE811155D0
        public void ButtonExists(){} // RVA: 0x7FFE81115690
        public void RegisterVirtualAxis(){} // RVA: 0x7FFE81115750
        public void RegisterVirtualButton(){} // RVA: 0x7FFE811157C0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFE81115830
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFE81115970
        public void VirtualAxisReference(){} // RVA: 0x7FFE81115A60
        public void GetAxis(){} // RVA: 0x7FFE81115C20 | overloaded x2
        public void GetAxisRaw(){} // RVA: 0x7FFE81115BC0
        public void GetButton(){} // RVA: 0x7FFE81115CB0
        public void GetButtonDown(){} // RVA: 0x7FFE81115D30
        public void GetButtonUp(){} // RVA: 0x7FFE81115DB0
        public void SetButtonDown(){} // RVA: 0x7FFE81115E30
        public void SetButtonUp(){} // RVA: 0x7FFE81115EB0
        public void SetAxisPositive(){} // RVA: 0x7FFE81115F30
        public void SetAxisNegative(){} // RVA: 0x7FFE81115FB0
        public void SetAxisZero(){} // RVA: 0x7FFE81116030
        public void SetAxis(){} // RVA: 0x7FFE811160B0
        public void get_mousePosition(){} // RVA: 0x7FFE81116140
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFE811161D0
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFE81116260
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFE811162F0
    }

    public class InputAxisScrollbar : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7FFE810FB310
        public void HandleInput(){} // RVA: 0x7FFE81116890
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Joystick : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE81116960
        public void Start(){} // RVA: 0x7FFE81116970
        public void UpdateVirtualAxes(){} // RVA: 0x7FFE81116A40
        public void CreateVirtualAxes(){} // RVA: 0x7FFE81116AC0
        public void OnDrag(){} // RVA: 0x7FFE81116D10
        public void OnPointerUp(){} // RVA: 0x7FFE81116FD0
        public void OnPointerDown(){} // RVA: 0x7FFE810FB310
        public void OnDisable(){} // RVA: 0x7FFE81117100
        public void .ctor(){} // RVA: 0x7FFE811171D0
    }

    public class MobileControlRig : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE81117320
        public void Start(){} // RVA: 0x7FFE81117330
        public void CheckEnableControlRig(){} // RVA: 0x7FFE81117320
        public void EnableControlRig(){} // RVA: 0x7FFE811174A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class TiltInput : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE811177B0
        public void Update(){} // RVA: 0x7FFE81117900
        public void OnDisable(){} // RVA: 0x7FFE81117E00
        public void .ctor(){} // RVA: 0x7FFE81117E60
    }

    public class TouchPad : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE81117EB0
        public void Start(){} // RVA: 0x7FFE81117EC0
        public void CreateVirtualAxes(){} // RVA: 0x7FFE81118030
        public void UpdateVirtualAxes(){} // RVA: 0x7FFE81118280
        public void OnPointerDown(){} // RVA: 0x7FFE811182F0
        public void Update(){} // RVA: 0x7FFE81118340
        public void OnPointerUp(){} // RVA: 0x7FFE81118590
        public void OnDisable(){} // RVA: 0x7FFE811186A0
        public void .ctor(){} // RVA: 0x7FFE81118770
    }

    public class VirtualInput : Object
    {
        public UnityEngine.Vector3 _virtualMousePosition; // 0x10

        // ── Methods ──
        public void get_virtualMousePosition(){} // RVA: 0x7FFE811188D0
        public void set_virtualMousePosition(){} // RVA: 0x7FFE811188F0
        public void AxisExists(){} // RVA: 0x7FFE81118900
        public void ButtonExists(){} // RVA: 0x7FFE81118980
        public void RegisterVirtualAxis(){} // RVA: 0x7FFE81118A00
        public void RegisterVirtualButton(){} // RVA: 0x7FFE81118CD0
        public void UnRegisterVirtualAxis(){} // RVA: 0x7FFE81118FA0
        public void UnRegisterVirtualButton(){} // RVA: 0x7FFE81119040
        public void VirtualAxisReference(){} // RVA: 0x7FFE811190E0
        public void SetVirtualMousePositionX(){} // RVA: 0x7FFE81119190
        public void SetVirtualMousePositionY(){} // RVA: 0x7FFE811191B0
        public void SetVirtualMousePositionZ(){} // RVA: 0x7FFE811191D0
        public void GetAxis(){}
        public void GetButton(){} // RVA: 0x7FFE80E2F3B0
        public void GetButtonDown(){} // RVA: 0x7FFE80E2F3B0
        public void GetButtonUp(){} // RVA: 0x7FFE80E2F3B0
        public void SetButtonDown(){} // RVA: 0x7FFE80E460A0
        public void SetButtonUp(){} // RVA: 0x7FFE80E460A0
        public void SetAxisPositive(){} // RVA: 0x7FFE80E460A0
        public void SetAxisNegative(){} // RVA: 0x7FFE80E460A0
        public void SetAxisZero(){} // RVA: 0x7FFE80E460A0
        public void SetAxis(){} // RVA: 0x7FFE80E52EB0
        public void MousePosition(){} // RVA: 0x7FFE80E2DCF0
        public void .ctor(){} // RVA: 0x7FFE81119200
    }

}