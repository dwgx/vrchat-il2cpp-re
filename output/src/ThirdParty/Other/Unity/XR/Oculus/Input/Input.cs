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
        public void get_touchpad(){} // RVA: 0x7FFD4E969F30
        public void set_touchpad(){} // RVA: 0x7FFD4EDC7790
        public void get_trigger(){} // RVA: 0x7FFD4E964330
        public void set_trigger(){} // RVA: 0x7FFD4EDCC050
        public void get_back(){} // RVA: 0x7FFD4E9622B0
        public void set_back(){} // RVA: 0x7FFD4EDCD110
        public void get_triggerPressed(){} // RVA: 0x7FFD4EDECB10
        public void set_triggerPressed(){} // RVA: 0x7FFD4EDEF3F0
        public void get_touchpadClicked(){} // RVA: 0x7FFD4EDE1920
        public void set_touchpadClicked(){} // RVA: 0x7FFD4EDC8050
        public void get_touchpadTouched(){} // RVA: 0x7FFD4EDE0A30
        public void set_touchpadTouched(){} // RVA: 0x7FFD4EDEF5C0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4E818150
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4EDD1270
        public void get_deviceAcceleration(){} // RVA: 0x7FFD4EDD1060
        public void set_deviceAcceleration(){} // RVA: 0x7FFD4EDCC5A0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFD4E964EF0
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFD4E961400
        public void FinishSetup(){} // RVA: 0x7FFD54939010
        public void .ctor(){} // RVA: 0x7FFD54936440
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
        public void get_userPresence(){} // RVA: 0x7FFD4E818150
        public void set_userPresence(){} // RVA: 0x7FFD4EDD1270
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4EDD1060
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4EDCC5A0
        public void get_deviceAcceleration(){} // RVA: 0x7FFD4E964EF0
        public void set_deviceAcceleration(){} // RVA: 0x7FFD4E961400
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFD4E961460
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFD4E964450
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7FFD4E964790
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7FFD4E96D230
        public void get_leftEyeAcceleration(){} // RVA: 0x7FFD4E964780
        public void set_leftEyeAcceleration(){} // RVA: 0x7FFD4E96D290
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x7FFD4E96BCB0
        public void set_leftEyeAngularAcceleration(){} // RVA: 0x7FFD4E963140
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7FFD4E961470
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7FFD4E962420
        public void get_rightEyeAcceleration(){} // RVA: 0x7FFD4E9693F0
        public void set_rightEyeAcceleration(){} // RVA: 0x7FFD4E96AC80
        public void get_rightEyeAngularAcceleration(){} // RVA: 0x7FFD4E960FB0
        public void set_rightEyeAngularAcceleration(){} // RVA: 0x7FFD4EDCE720
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7FFD4E962820
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7FFD4EDE7D40
        public void get_centerEyeAcceleration(){} // RVA: 0x7FFD4E9613D0
        public void set_centerEyeAcceleration(){} // RVA: 0x7FFD4EDCA7F0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7FFD4EDE9150
        public void set_centerEyeAngularAcceleration(){} // RVA: 0x7FFD4EDD5A80
        public void FinishSetup(){} // RVA: 0x7FFD54937B60
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class OculusHMDExtended : OculusHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl back; // 0x248
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x250

        // ── Methods ──
        public void get_back(){} // RVA: 0x7FFD4EDC6830
        public void set_back(){} // RVA: 0x7FFD4EDC8760
        public void get_touchpad(){} // RVA: 0x7FFD4EDE5D60
        public void set_touchpad(){} // RVA: 0x7FFD4EDD0650
        public void FinishSetup(){} // RVA: 0x7FFD54938EB0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class OculusRemote : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl back; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl start; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x1A0

        // ── Methods ──
        public void get_back(){} // RVA: 0x7FFD4E960F60
        public void set_back(){} // RVA: 0x7FFD4EDCB1D0
        public void get_start(){} // RVA: 0x7FFD4E961C80
        public void set_start(){} // RVA: 0x7FFD4EDE8ED0
        public void get_touchpad(){} // RVA: 0x7FFD4E96E2E0
        public void set_touchpad(){} // RVA: 0x7FFD4EDC8AF0
        public void FinishSetup(){} // RVA: 0x7FFD54938CD0
        public void .ctor(){} // RVA: 0x7FFD54936440
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
        public void get_thumbstick(){} // RVA: 0x7FFD4E969F30
        public void set_thumbstick(){} // RVA: 0x7FFD4EDC7790
        public void get_trigger(){} // RVA: 0x7FFD4E964330
        public void set_trigger(){} // RVA: 0x7FFD4EDCC050
        public void get_grip(){} // RVA: 0x7FFD4E9622B0
        public void set_grip(){} // RVA: 0x7FFD4EDCD110
        public void get_primaryButton(){} // RVA: 0x7FFD4EDECB10
        public void set_primaryButton(){} // RVA: 0x7FFD4EDEF3F0
        public void get_secondaryButton(){} // RVA: 0x7FFD4EDE1920
        public void set_secondaryButton(){} // RVA: 0x7FFD4EDC8050
        public void get_gripPressed(){} // RVA: 0x7FFD4EDE0A30
        public void set_gripPressed(){} // RVA: 0x7FFD4EDEF5C0
        public void get_start(){} // RVA: 0x7FFD4E818150
        public void set_start(){} // RVA: 0x7FFD4EDD1270
        public void get_thumbstickClicked(){} // RVA: 0x7FFD4EDD1060
        public void set_thumbstickClicked(){} // RVA: 0x7FFD4EDCC5A0
        public void get_primaryTouched(){} // RVA: 0x7FFD4E964EF0
        public void set_primaryTouched(){} // RVA: 0x7FFD4E961400
        public void get_secondaryTouched(){} // RVA: 0x7FFD4E961460
        public void set_secondaryTouched(){} // RVA: 0x7FFD4E964450
        public void get_triggerTouched(){} // RVA: 0x7FFD4E964790
        public void set_triggerTouched(){} // RVA: 0x7FFD4E96D230
        public void get_triggerPressed(){} // RVA: 0x7FFD4E964780
        public void set_triggerPressed(){} // RVA: 0x7FFD4E96D290
        public void get_thumbstickTouched(){} // RVA: 0x7FFD4E96BCB0
        public void set_thumbstickTouched(){} // RVA: 0x7FFD4E963140
        public void get_deviceVelocity(){} // RVA: 0x7FFD4E961470
        public void set_deviceVelocity(){} // RVA: 0x7FFD4E962420
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4E9693F0
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4E96AC80
        public void get_deviceAcceleration(){} // RVA: 0x7FFD4E960FB0
        public void set_deviceAcceleration(){} // RVA: 0x7FFD4EDCE720
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFD4E962820
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFD4EDE7D40
        public void FinishSetup(){} // RVA: 0x7FFD54938250
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class OculusTrackingReference : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.IntegerControl trackingState; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl isTracked; // 0x1B8

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7FFD4E969F30
        public void set_trackingState(){} // RVA: 0x7FFD4EDC7790
        public void get_isTracked(){} // RVA: 0x7FFD4E964330
        public void set_isTracked(){} // RVA: 0x7FFD4EDCC050
        public void FinishSetup(){} // RVA: 0x7FFD54938B70
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

}