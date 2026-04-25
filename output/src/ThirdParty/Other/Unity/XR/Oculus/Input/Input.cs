// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.Oculus.Input
// Classes: 6
// Methods: 104

namespace ThirdParty.Other.Unity.XR.Oculus.Input
{
    public class GearVRTrackedController : XRController
    {
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x1B0
        public UnityEngine.InputSystem.Controls.AxisControl trigger; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl back; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadClicked; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadTouched; // 0x1D8
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x1E0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAcceleration; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularAcceleration; // 0x1F0

        // ── Methods ──
        public void get_touchpad(){} // RVA: 0x7FFAC3549F30
        public void set_touchpad(){} // RVA: 0x7FFAC39A7790
        public void get_trigger(){} // RVA: 0x7FFAC3544330
        public void set_trigger(){} // RVA: 0x7FFAC39AC050
        public void get_back(){} // RVA: 0x7FFAC35422B0
        public void set_back(){} // RVA: 0x7FFAC39AD110
        public void get_triggerPressed(){} // RVA: 0x7FFAC39CCB10
        public void set_triggerPressed(){} // RVA: 0x7FFAC39CF3F0
        public void get_touchpadClicked(){} // RVA: 0x7FFAC39C1920
        public void set_touchpadClicked(){} // RVA: 0x7FFAC39A8050
        public void get_touchpadTouched(){} // RVA: 0x7FFAC39C0A30
        public void set_touchpadTouched(){} // RVA: 0x7FFAC39CF5C0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC33F8150
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC39B1270
        public void get_deviceAcceleration(){} // RVA: 0x7FFAC39B1060
        public void set_deviceAcceleration(){} // RVA: 0x7FFAC39AC5A0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFAC3544EF0
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFAC3541400
        public void FinishSetup(){} // RVA: 0x7FFAC9519010
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OculusHMD : XRHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl userPresence; // 0x1E0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAcceleration; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularAcceleration; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyeAngularVelocity; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyeAcceleration; // 0x208
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyeAngularAcceleration; // 0x210
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyeAngularVelocity; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyeAcceleration; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyeAngularAcceleration; // 0x228
        public UnityEngine.InputSystem.Controls.Vector3Control centerEyeAngularVelocity; // 0x230
        public UnityEngine.InputSystem.Controls.Vector3Control centerEyeAcceleration; // 0x238
        public UnityEngine.InputSystem.Controls.Vector3Control centerEyeAngularAcceleration; // 0x240

        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x7FFAC33F8150
        public void set_userPresence(){} // RVA: 0x7FFAC39B1270
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC39B1060
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC39AC5A0
        public void get_deviceAcceleration(){} // RVA: 0x7FFAC3544EF0
        public void set_deviceAcceleration(){} // RVA: 0x7FFAC3541400
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFAC3541460
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFAC3544450
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7FFAC3544790
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7FFAC354D230
        public void get_leftEyeAcceleration(){} // RVA: 0x7FFAC3544780
        public void set_leftEyeAcceleration(){} // RVA: 0x7FFAC354D290
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x7FFAC354BCB0
        public void set_leftEyeAngularAcceleration(){} // RVA: 0x7FFAC3543140
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7FFAC3541470
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7FFAC3542420
        public void get_rightEyeAcceleration(){} // RVA: 0x7FFAC35493F0
        public void set_rightEyeAcceleration(){} // RVA: 0x7FFAC354AC80
        public void get_rightEyeAngularAcceleration(){} // RVA: 0x7FFAC3540FB0
        public void set_rightEyeAngularAcceleration(){} // RVA: 0x7FFAC39AE720
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7FFAC3542820
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7FFAC39C7D40
        public void get_centerEyeAcceleration(){} // RVA: 0x7FFAC35413D0
        public void set_centerEyeAcceleration(){} // RVA: 0x7FFAC39AA7F0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7FFAC39C9150
        public void set_centerEyeAngularAcceleration(){} // RVA: 0x7FFAC39B5A80
        public void FinishSetup(){} // RVA: 0x7FFAC9517B60
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OculusHMDExtended : OculusHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl back; // 0x248
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x250

        // ── Methods ──
        public void get_back(){} // RVA: 0x7FFAC39A6830
        public void set_back(){} // RVA: 0x7FFAC39A8760
        public void get_touchpad(){} // RVA: 0x7FFAC39C5D60
        public void set_touchpad(){} // RVA: 0x7FFAC39B0650
        public void FinishSetup(){} // RVA: 0x7FFAC9518EB0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OculusRemote : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl back; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl start; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x1A0

        // ── Methods ──
        public void get_back(){} // RVA: 0x7FFAC3540F60
        public void set_back(){} // RVA: 0x7FFAC39AB1D0
        public void get_start(){} // RVA: 0x7FFAC3541C80
        public void set_start(){} // RVA: 0x7FFAC39C8ED0
        public void get_touchpad(){} // RVA: 0x7FFAC354E2E0
        public void set_touchpad(){} // RVA: 0x7FFAC39A8AF0
        public void FinishSetup(){} // RVA: 0x7FFAC9518CD0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OculusTouchController : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.Vector2Control thumbstick; // 0x1B0
        public UnityEngine.InputSystem.Controls.AxisControl trigger; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl primaryButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl secondaryButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl gripPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl start; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl thumbstickClicked; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl primaryTouched; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl secondaryTouched; // 0x1F8
        public UnityEngine.InputSystem.Controls.AxisControl triggerTouched; // 0x200
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x208
        public UnityEngine.InputSystem.Controls.ButtonControl thumbstickTouched; // 0x210
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAcceleration; // 0x228
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularAcceleration; // 0x230

        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7FFAC3549F30
        public void set_thumbstick(){} // RVA: 0x7FFAC39A7790
        public void get_trigger(){} // RVA: 0x7FFAC3544330
        public void set_trigger(){} // RVA: 0x7FFAC39AC050
        public void get_grip(){} // RVA: 0x7FFAC35422B0
        public void set_grip(){} // RVA: 0x7FFAC39AD110
        public void get_primaryButton(){} // RVA: 0x7FFAC39CCB10
        public void set_primaryButton(){} // RVA: 0x7FFAC39CF3F0
        public void get_secondaryButton(){} // RVA: 0x7FFAC39C1920
        public void set_secondaryButton(){} // RVA: 0x7FFAC39A8050
        public void get_gripPressed(){} // RVA: 0x7FFAC39C0A30
        public void set_gripPressed(){} // RVA: 0x7FFAC39CF5C0
        public void get_start(){} // RVA: 0x7FFAC33F8150
        public void set_start(){} // RVA: 0x7FFAC39B1270
        public void get_thumbstickClicked(){} // RVA: 0x7FFAC39B1060
        public void set_thumbstickClicked(){} // RVA: 0x7FFAC39AC5A0
        public void get_primaryTouched(){} // RVA: 0x7FFAC3544EF0
        public void set_primaryTouched(){} // RVA: 0x7FFAC3541400
        public void get_secondaryTouched(){} // RVA: 0x7FFAC3541460
        public void set_secondaryTouched(){} // RVA: 0x7FFAC3544450
        public void get_triggerTouched(){} // RVA: 0x7FFAC3544790
        public void set_triggerTouched(){} // RVA: 0x7FFAC354D230
        public void get_triggerPressed(){} // RVA: 0x7FFAC3544780
        public void set_triggerPressed(){} // RVA: 0x7FFAC354D290
        public void get_thumbstickTouched(){} // RVA: 0x7FFAC354BCB0
        public void set_thumbstickTouched(){} // RVA: 0x7FFAC3543140
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3541470
        public void set_deviceVelocity(){} // RVA: 0x7FFAC3542420
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC35493F0
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC354AC80
        public void get_deviceAcceleration(){} // RVA: 0x7FFAC3540FB0
        public void set_deviceAcceleration(){} // RVA: 0x7FFAC39AE720
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFAC3542820
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFAC39C7D40
        public void FinishSetup(){} // RVA: 0x7FFAC9518250
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OculusTrackingReference : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.IntegerControl trackingState; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl isTracked; // 0x1B8

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7FFAC3549F30
        public void set_trackingState(){} // RVA: 0x7FFAC39A7790
        public void get_isTracked(){} // RVA: 0x7FFAC3544330
        public void set_isTracked(){} // RVA: 0x7FFAC39AC050
        public void FinishSetup(){} // RVA: 0x7FFAC9518B70
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

}