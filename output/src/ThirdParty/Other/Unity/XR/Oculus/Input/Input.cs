// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.Oculus.Input
// Classes: 6
// Methods: 104

namespace ThirdParty.Other.Unity.XR.Oculus.Input
{
    public class GearVRTrackedController : XRController
    {
        public UnityEngine.InputSystem.Controls.Vector2Control _touchpad; // 0x1B0
        public UnityEngine.InputSystem.Controls.AxisControl _trigger; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl _back; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadClicked; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadTouched; // 0x1D8
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x1E0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAcceleration; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularAcceleration; // 0x1F0

        // ── Methods ──
        public void get_touchpad(){} // RVA: 0x7FFE81B23A60
        public void set_touchpad(){} // RVA: 0x7FFE81B2ACE0
        public void get_trigger(){} // RVA: 0x7FFE81B164E0
        public void set_trigger(){} // RVA: 0x7FFE81B38D70
        public void get_back(){} // RVA: 0x7FFE817EFE00
        public void set_back(){} // RVA: 0x7FFE81B0C930
        public void get_triggerPressed(){} // RVA: 0x7FFE81B16E90
        public void set_triggerPressed(){} // RVA: 0x7FFE81B290E0
        public void get_touchpadClicked(){} // RVA: 0x7FFE81B32320
        public void set_touchpadClicked(){} // RVA: 0x7FFE81B31B60
        public void get_touchpadTouched(){} // RVA: 0x7FFE81B23D60
        public void set_touchpadTouched(){} // RVA: 0x7FFE81B11520
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE816611A0
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B31CF0
        public void get_deviceAcceleration(){} // RVA: 0x7FFE81B27D50
        public void set_deviceAcceleration(){} // RVA: 0x7FFE81B34FD0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFE81B21230
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFE81B374B0
        public void FinishSetup(){} // RVA: 0x7FFE878C1750
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OculusHMD : XRHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _userPresence; // 0x1E0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAcceleration; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularAcceleration; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyeAngularVelocity; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyeAcceleration; // 0x208
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyeAngularAcceleration; // 0x210
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyeAngularVelocity; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyeAcceleration; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyeAngularAcceleration; // 0x228
        public UnityEngine.InputSystem.Controls.Vector3Control _centerEyeAngularVelocity; // 0x230
        public UnityEngine.InputSystem.Controls.Vector3Control _centerEyeAcceleration; // 0x238
        public UnityEngine.InputSystem.Controls.Vector3Control _centerEyeAngularAcceleration; // 0x240

        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x7FFE816611A0
        public void set_userPresence(){} // RVA: 0x7FFE81B31CF0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B27D50
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B34FD0
        public void get_deviceAcceleration(){} // RVA: 0x7FFE81B21230
        public void set_deviceAcceleration(){} // RVA: 0x7FFE81B374B0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFE81B20B40
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFE81B2E610
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7FFE81B14500
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7FFE81B317A0
        public void get_leftEyeAcceleration(){} // RVA: 0x7FFE81B2DA70
        public void set_leftEyeAcceleration(){} // RVA: 0x7FFE81B27F80
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x7FFE81B0A180
        public void set_leftEyeAngularAcceleration(){} // RVA: 0x7FFE81B13850
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7FFE81B296E0
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7FFE81B38350
        public void get_rightEyeAcceleration(){} // RVA: 0x7FFE81B310E0
        public void set_rightEyeAcceleration(){} // RVA: 0x7FFE81B21BD0
        public void get_rightEyeAngularAcceleration(){} // RVA: 0x7FFE81B0D790
        public void set_rightEyeAngularAcceleration(){} // RVA: 0x7FFE81B34BA0
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7FFE81B23A70
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7FFE81B39ED0
        public void get_centerEyeAcceleration(){} // RVA: 0x7FFE81B20B50
        public void set_centerEyeAcceleration(){} // RVA: 0x7FFE81B2F9F0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7FFE81B26960
        public void set_centerEyeAngularAcceleration(){} // RVA: 0x7FFE81B2E9D0
        public void FinishSetup(){} // RVA: 0x7FFE878C02A0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OculusHMDExtended : OculusHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _back; // 0x248
        public UnityEngine.InputSystem.Controls.Vector2Control _touchpad; // 0x250

        // ── Methods ──
        public void get_back(){} // RVA: 0x7FFE81B0DEC0
        public void set_back(){} // RVA: 0x7FFE81B27CF0
        public void get_touchpad(){} // RVA: 0x7FFE81B12420
        public void set_touchpad(){} // RVA: 0x7FFE81B34B40
        public void FinishSetup(){} // RVA: 0x7FFE878C15F0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OculusRemote : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _back; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl _start; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control _touchpad; // 0x1A0

        // ── Methods ──
        public void get_back(){} // RVA: 0x7FFE81825EC0
        public void set_back(){} // RVA: 0x7FFE81B2A360
        public void get_start(){} // RVA: 0x7FFE8181EA60
        public void set_start(){} // RVA: 0x7FFE81B33630
        public void get_touchpad(){} // RVA: 0x7FFE81B32390
        public void set_touchpad(){} // RVA: 0x7FFE81B21CA0
        public void FinishSetup(){} // RVA: 0x7FFE878C1410
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OculusTouchController : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.Vector2Control _thumbstick; // 0x1B0
        public UnityEngine.InputSystem.Controls.AxisControl _trigger; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl _grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _primaryButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _secondaryButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _gripPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _start; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl _thumbstickClicked; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl _primaryTouched; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl _secondaryTouched; // 0x1F8
        public UnityEngine.InputSystem.Controls.AxisControl _triggerTouched; // 0x200
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x208
        public UnityEngine.InputSystem.Controls.ButtonControl _thumbstickTouched; // 0x210
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAcceleration; // 0x228
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularAcceleration; // 0x230

        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7FFE81B23A60
        public void set_thumbstick(){} // RVA: 0x7FFE81B2ACE0
        public void get_trigger(){} // RVA: 0x7FFE81B164E0
        public void set_trigger(){} // RVA: 0x7FFE81B38D70
        public void get_grip(){} // RVA: 0x7FFE817EFE00
        public void set_grip(){} // RVA: 0x7FFE81B0C930
        public void get_primaryButton(){} // RVA: 0x7FFE81B16E90
        public void set_primaryButton(){} // RVA: 0x7FFE81B290E0
        public void get_secondaryButton(){} // RVA: 0x7FFE81B32320
        public void set_secondaryButton(){} // RVA: 0x7FFE81B31B60
        public void get_gripPressed(){} // RVA: 0x7FFE81B23D60
        public void set_gripPressed(){} // RVA: 0x7FFE81B11520
        public void get_start(){} // RVA: 0x7FFE816611A0
        public void set_start(){} // RVA: 0x7FFE81B31CF0
        public void get_thumbstickClicked(){} // RVA: 0x7FFE81B27D50
        public void set_thumbstickClicked(){} // RVA: 0x7FFE81B34FD0
        public void get_primaryTouched(){} // RVA: 0x7FFE81B21230
        public void set_primaryTouched(){} // RVA: 0x7FFE81B374B0
        public void get_secondaryTouched(){} // RVA: 0x7FFE81B20B40
        public void set_secondaryTouched(){} // RVA: 0x7FFE81B2E610
        public void get_triggerTouched(){} // RVA: 0x7FFE81B14500
        public void set_triggerTouched(){} // RVA: 0x7FFE81B317A0
        public void get_triggerPressed(){} // RVA: 0x7FFE81B2DA70
        public void set_triggerPressed(){} // RVA: 0x7FFE81B27F80
        public void get_thumbstickTouched(){} // RVA: 0x7FFE81B0A180
        public void set_thumbstickTouched(){} // RVA: 0x7FFE81B13850
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B296E0
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B38350
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B310E0
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B21BD0
        public void get_deviceAcceleration(){} // RVA: 0x7FFE81B0D790
        public void set_deviceAcceleration(){} // RVA: 0x7FFE81B34BA0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7FFE81B23A70
        public void set_deviceAngularAcceleration(){} // RVA: 0x7FFE81B39ED0
        public void FinishSetup(){} // RVA: 0x7FFE878C0990
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OculusTrackingReference : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.IntegerControl _trackingState; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl _isTracked; // 0x1B8

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7FFE81B23A60
        public void set_trackingState(){} // RVA: 0x7FFE81B2ACE0
        public void get_isTracked(){} // RVA: 0x7FFE81B164E0
        public void set_isTracked(){} // RVA: 0x7FFE81B38D70
        public void FinishSetup(){} // RVA: 0x7FFE878C12B0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

}