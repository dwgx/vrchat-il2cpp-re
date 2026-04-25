// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.WindowsMR.Input
// Classes: 3
// Methods: 50

namespace ThirdParty.Unity.UnityEngine.XR.WindowsMR.Input
{
    public class HololensHand : XRController
    {
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl airTap; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl sourceLossRisk; // 0x1C0
        public UnityEngine.InputSystem.Controls.Vector3Control sourceLossMitigationDirection; // 0x1C8

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3549F30
        public void set_deviceVelocity(){} // RVA: 0x7FFAC39A7790
        public void get_airTap(){} // RVA: 0x7FFAC3544330
        public void set_airTap(){} // RVA: 0x7FFAC39AC050
        public void get_sourceLossRisk(){} // RVA: 0x7FFAC35422B0
        public void set_sourceLossRisk(){} // RVA: 0x7FFAC39AD110
        public void get_sourceLossMitigationDirection(){} // RVA: 0x7FFAC39CCB10
        public void set_sourceLossMitigationDirection(){} // RVA: 0x7FFAC39CF3F0
        public void FinishSetup(){} // RVA: 0x7FFAC9519BE0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class WMRHMD : XRHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl userPresence; // 0x1E0

        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x7FFAC33F8150
        public void set_userPresence(){} // RVA: 0x7FFAC39B1270
        public void FinishSetup(){} // RVA: 0x7FFAC9519B20
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class WMRSpatialController : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.Vector2Control joystick; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl gripPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl menu; // 0x1D0
        public UnityEngine.InputSystem.Controls.AxisControl trigger; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl joystickClicked; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadClicked; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadTouched; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x208
        public UnityEngine.InputSystem.Controls.AxisControl batteryLevel; // 0x210
        public UnityEngine.InputSystem.Controls.AxisControl sourceLossRisk; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control sourceLossMitigationDirection; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control pointerPosition; // 0x228
        public UnityEngine.InputSystem.Controls.QuaternionControl pointerRotation; // 0x230

        // ── Methods ──
        public void get_joystick(){} // RVA: 0x7FFAC3549F30
        public void set_joystick(){} // RVA: 0x7FFAC39A7790
        public void get_touchpad(){} // RVA: 0x7FFAC3544330
        public void set_touchpad(){} // RVA: 0x7FFAC39AC050
        public void get_grip(){} // RVA: 0x7FFAC35422B0
        public void set_grip(){} // RVA: 0x7FFAC39AD110
        public void get_gripPressed(){} // RVA: 0x7FFAC39CCB10
        public void set_gripPressed(){} // RVA: 0x7FFAC39CF3F0
        public void get_menu(){} // RVA: 0x7FFAC39C1920
        public void set_menu(){} // RVA: 0x7FFAC39A8050
        public void get_trigger(){} // RVA: 0x7FFAC39C0A30
        public void set_trigger(){} // RVA: 0x7FFAC39CF5C0
        public void get_triggerPressed(){} // RVA: 0x7FFAC33F8150
        public void set_triggerPressed(){} // RVA: 0x7FFAC39B1270
        public void get_joystickClicked(){} // RVA: 0x7FFAC39B1060
        public void set_joystickClicked(){} // RVA: 0x7FFAC39AC5A0
        public void get_touchpadClicked(){} // RVA: 0x7FFAC3544EF0
        public void set_touchpadClicked(){} // RVA: 0x7FFAC3541400
        public void get_touchpadTouched(){} // RVA: 0x7FFAC3541460
        public void set_touchpadTouched(){} // RVA: 0x7FFAC3544450
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3544790
        public void set_deviceVelocity(){} // RVA: 0x7FFAC354D230
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC3544780
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC354D290
        public void get_batteryLevel(){} // RVA: 0x7FFAC354BCB0
        public void set_batteryLevel(){} // RVA: 0x7FFAC3543140
        public void get_sourceLossRisk(){} // RVA: 0x7FFAC3541470
        public void set_sourceLossRisk(){} // RVA: 0x7FFAC3542420
        public void get_sourceLossMitigationDirection(){} // RVA: 0x7FFAC35493F0
        public void set_sourceLossMitigationDirection(){} // RVA: 0x7FFAC354AC80
        public void get_pointerPosition(){} // RVA: 0x7FFAC3540FB0
        public void set_pointerPosition(){} // RVA: 0x7FFAC39AE720
        public void get_pointerRotation(){} // RVA: 0x7FFAC3542820
        public void set_pointerRotation(){} // RVA: 0x7FFAC39C7D40
        public void FinishSetup(){} // RVA: 0x7FFAC9519E60
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

}