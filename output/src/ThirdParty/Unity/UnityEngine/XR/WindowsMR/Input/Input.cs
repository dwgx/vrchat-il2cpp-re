// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.WindowsMR.Input
// Classes: 3
// Methods: 50

namespace ThirdParty.Unity.UnityEngine.XR.WindowsMR.Input
{
    public class HololensHand : XRController
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl _airTap; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl _sourceLossRisk; // 0x1C0
        public UnityEngine.InputSystem.Controls.Vector3Control _sourceLossMitigationDirection; // 0x1C8

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B23A60
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B2ACE0
        public void get_airTap(){} // RVA: 0x7FFE81B164E0
        public void set_airTap(){} // RVA: 0x7FFE81B38D70
        public void get_sourceLossRisk(){} // RVA: 0x7FFE817EFE00
        public void set_sourceLossRisk(){} // RVA: 0x7FFE81B0C930
        public void get_sourceLossMitigationDirection(){} // RVA: 0x7FFE81B16E90
        public void set_sourceLossMitigationDirection(){} // RVA: 0x7FFE81B290E0
        public void FinishSetup(){} // RVA: 0x7FFE878C2320
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class WMRHMD : XRHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _userPresence; // 0x1E0

        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x7FFE816611A0
        public void set_userPresence(){} // RVA: 0x7FFE81B31CF0
        public void FinishSetup(){} // RVA: 0x7FFE878C2260
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class WMRSpatialController : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.Vector2Control _joystick; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector2Control _touchpad; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl _grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _gripPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _menu; // 0x1D0
        public UnityEngine.InputSystem.Controls.AxisControl _trigger; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl _joystickClicked; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadClicked; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadTouched; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x208
        public UnityEngine.InputSystem.Controls.AxisControl _batteryLevel; // 0x210
        public UnityEngine.InputSystem.Controls.AxisControl _sourceLossRisk; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control _sourceLossMitigationDirection; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control _pointerPosition; // 0x228
        public UnityEngine.InputSystem.Controls.QuaternionControl _pointerRotation; // 0x230

        // ── Methods ──
        public void get_joystick(){} // RVA: 0x7FFE81B23A60
        public void set_joystick(){} // RVA: 0x7FFE81B2ACE0
        public void get_touchpad(){} // RVA: 0x7FFE81B164E0
        public void set_touchpad(){} // RVA: 0x7FFE81B38D70
        public void get_grip(){} // RVA: 0x7FFE817EFE00
        public void set_grip(){} // RVA: 0x7FFE81B0C930
        public void get_gripPressed(){} // RVA: 0x7FFE81B16E90
        public void set_gripPressed(){} // RVA: 0x7FFE81B290E0
        public void get_menu(){} // RVA: 0x7FFE81B32320
        public void set_menu(){} // RVA: 0x7FFE81B31B60
        public void get_trigger(){} // RVA: 0x7FFE81B23D60
        public void set_trigger(){} // RVA: 0x7FFE81B11520
        public void get_triggerPressed(){} // RVA: 0x7FFE816611A0
        public void set_triggerPressed(){} // RVA: 0x7FFE81B31CF0
        public void get_joystickClicked(){} // RVA: 0x7FFE81B27D50
        public void set_joystickClicked(){} // RVA: 0x7FFE81B34FD0
        public void get_touchpadClicked(){} // RVA: 0x7FFE81B21230
        public void set_touchpadClicked(){} // RVA: 0x7FFE81B374B0
        public void get_touchpadTouched(){} // RVA: 0x7FFE81B20B40
        public void set_touchpadTouched(){} // RVA: 0x7FFE81B2E610
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B14500
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B317A0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B2DA70
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B27F80
        public void get_batteryLevel(){} // RVA: 0x7FFE81B0A180
        public void set_batteryLevel(){} // RVA: 0x7FFE81B13850
        public void get_sourceLossRisk(){} // RVA: 0x7FFE81B296E0
        public void set_sourceLossRisk(){} // RVA: 0x7FFE81B38350
        public void get_sourceLossMitigationDirection(){} // RVA: 0x7FFE81B310E0
        public void set_sourceLossMitigationDirection(){} // RVA: 0x7FFE81B21BD0
        public void get_pointerPosition(){} // RVA: 0x7FFE81B0D790
        public void set_pointerPosition(){} // RVA: 0x7FFE81B34BA0
        public void get_pointerRotation(){} // RVA: 0x7FFE81B23A70
        public void set_pointerRotation(){} // RVA: 0x7FFE81B39ED0
        public void FinishSetup(){} // RVA: 0x7FFE878C25A0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

}