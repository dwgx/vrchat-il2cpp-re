// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.Oculus.Input
// Classes: 6
// Methods: 104

namespace ThirdParty.Other.Unity.XR.Oculus.Input
{
    public class GearVRTrackedController : XRController
    {
        public object _back; // 0x34D69720, was: <back>k__BackingField
        public object _touchpadTouched; // 0x34D69720, was: <touchpadTouched>k__BackingFie
        public object _deviceAngularAcceleration; // 0x34D69720, was: <deviceAngularAcceleration>k__
        public object touchpad; // 0x17000055
        public object trigger; // 0x17000056
        public object back; // 0x17000057

        // ── Original Methods ──
        public void get_touchpad(){} // RVA: 0x7ffaa8f6f0f0
        public void set_touchpad(){} // RVA: 0x7ffaa93d9af0
        public void get_trigger(){} // RVA: 0x7ffaa8f78130
        public void set_trigger(){} // RVA: 0x7ffaa93e4fb0
        public void get_back(){} // RVA: 0x7ffaa8f73670
        public void set_back(){} // RVA: 0x7ffaa93e9360
        public void get_triggerPressed(){} // RVA: 0x7ffaa93d5320
        public void set_triggerPressed(){} // RVA: 0x7ffaa93e3d80
        public void get_touchpadClicked(){} // RVA: 0x7ffaa93d4100
        public void set_touchpadClicked(){} // RVA: 0x7ffaa93e7fd0
        public void get_touchpadTouched(){} // RVA: 0x7ffaa93e8b10
        public void set_touchpadTouched(){} // RVA: 0x7ffaa9400010
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa8e19790
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa93fdbe0
        public void get_deviceAcceleration(){} // RVA: 0x7ffaa93d15b0
        public void set_deviceAcceleration(){} // RVA: 0x7ffaa93d3cc0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7ffaa8f6fa20
        public void set_deviceAngularAcceleration(){} // RVA: 0x7ffaa8f774b0
        public void FinishSetup(){} // RVA: 0x7ffaaef3afe0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OculusHMD : XRHMD
    {
        public object _deviceAcceleration; // 0x33455050, was: <deviceAcceleration>k__Backing
        public object _leftEyeAcceleration; // 0x33455050, was: <leftEyeAcceleration>k__Backin
        public object _rightEyeAcceleration; // 0x33455050, was: <rightEyeAcceleration>k__Backi
        public object _centerEyeAcceleration; // 0x33455050, was: <centerEyeAcceleration>k__Back

        // ── Original Methods ──
        public void get_userPresence(){} // RVA: 0x7ffaa8e19790
        public void set_userPresence(){} // RVA: 0x7ffaa93fdbe0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa93d15b0
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa93d3cc0
        public void get_deviceAcceleration(){} // RVA: 0x7ffaa8f6fa20
        public void set_deviceAcceleration(){} // RVA: 0x7ffaa8f774b0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7ffaa8f74aa0
        public void set_deviceAngularAcceleration(){} // RVA: 0x7ffaa8f744d0
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7ffaa8f7aa00
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7ffaa8f77dc0
        public void get_leftEyeAcceleration(){} // RVA: 0x7ffaa8f74940
        public void set_leftEyeAcceleration(){} // RVA: 0x7ffaa8f77e20
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x7ffaa8f6dbe0
        public void set_leftEyeAngularAcceleration(){} // RVA: 0x7ffaa8f6f550
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7ffaa8f70430
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7ffaa8f7aac0
        public void get_rightEyeAcceleration(){} // RVA: 0x7ffaa8f74760
        public void set_rightEyeAcceleration(){} // RVA: 0x7ffaa8f6e0b0
        public void get_rightEyeAngularAcceleration(){} // RVA: 0x7ffaa8f75b00
        public void set_rightEyeAngularAcceleration(){} // RVA: 0x7ffaa93e8560
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7ffaa8f76170
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7ffaa93d3600
        public void get_centerEyeAcceleration(){} // RVA: 0x7ffaa8f6ff20
        public void set_centerEyeAcceleration(){} // RVA: 0x7ffaa93d64a0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7ffaa93e4de0
        public void set_centerEyeAngularAcceleration(){} // RVA: 0x7ffaa93d5a40
        public void FinishSetup(){} // RVA: 0x7ffaaef39b30
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OculusHMDExtended : OculusHMD
    {
        // ── Original Methods ──
        public void get_back(){} // RVA: 0x7ffaa93e4a80
        public void set_back(){} // RVA: 0x7ffaa93fd280
        public void get_touchpad(){} // RVA: 0x7ffaa93e7730
        public void set_touchpad(){} // RVA: 0x7ffaa93ea060
        public void FinishSetup(){} // RVA: 0x7ffaaef3ae80
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OculusRemote : InputDevice
    {
        public object _touchpad; // 0x34D68DB0, was: <touchpad>k__BackingField
        public object back; // 0x17000050

        // ── Original Methods ──
        public void get_back(){} // RVA: 0x7ffaa8f77bc0
        public void set_back(){} // RVA: 0x7ffaa93f5420
        public void get_start(){} // RVA: 0x7ffaa8f75d50
        public void set_start(){} // RVA: 0x7ffaa94036f0
        public void get_touchpad(){} // RVA: 0x7ffaa8f74750
        public void set_touchpad(){} // RVA: 0x7ffaa93e77a0
        public void FinishSetup(){} // RVA: 0x7ffaaef3aca0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OculusTouchController : XRControllerWithRumble
    {
        public object _grip; // 0x34D68B10, was: <grip>k__BackingField
        public object _gripPressed; // 0x34D68B10, was: <gripPressed>k__BackingField
        public object _primaryTouched; // 0x34D68B10, was: <primaryTouched>k__BackingFiel
        public object _triggerPressed; // 0x34D68B10, was: <triggerPressed>k__BackingFiel
        public object _deviceAngularVelocity; // 0x34D68B10, was: <deviceAngularVelocity>k__Back

        // ── Original Methods ──
        public void get_thumbstick(){} // RVA: 0x7ffaa8f6f0f0
        public void set_thumbstick(){} // RVA: 0x7ffaa93d9af0
        public void get_trigger(){} // RVA: 0x7ffaa8f78130
        public void set_trigger(){} // RVA: 0x7ffaa93e4fb0
        public void get_grip(){} // RVA: 0x7ffaa8f73670
        public void set_grip(){} // RVA: 0x7ffaa93e9360
        public void get_primaryButton(){} // RVA: 0x7ffaa93d5320
        public void set_primaryButton(){} // RVA: 0x7ffaa93e3d80
        public void get_secondaryButton(){} // RVA: 0x7ffaa93d4100
        public void set_secondaryButton(){} // RVA: 0x7ffaa93e7fd0
        public void get_gripPressed(){} // RVA: 0x7ffaa93e8b10
        public void set_gripPressed(){} // RVA: 0x7ffaa9400010
        public void get_start(){} // RVA: 0x7ffaa8e19790
        public void set_start(){} // RVA: 0x7ffaa93fdbe0
        public void get_thumbstickClicked(){} // RVA: 0x7ffaa93d15b0
        public void set_thumbstickClicked(){} // RVA: 0x7ffaa93d3cc0
        public void get_primaryTouched(){} // RVA: 0x7ffaa8f6fa20
        public void set_primaryTouched(){} // RVA: 0x7ffaa8f774b0
        public void get_secondaryTouched(){} // RVA: 0x7ffaa8f74aa0
        public void set_secondaryTouched(){} // RVA: 0x7ffaa8f744d0
        public void get_triggerTouched(){} // RVA: 0x7ffaa8f7aa00
        public void set_triggerTouched(){} // RVA: 0x7ffaa8f77dc0
        public void get_triggerPressed(){} // RVA: 0x7ffaa8f74940
        public void set_triggerPressed(){} // RVA: 0x7ffaa8f77e20
        public void get_thumbstickTouched(){} // RVA: 0x7ffaa8f6dbe0
        public void set_thumbstickTouched(){} // RVA: 0x7ffaa8f6f550
        public void get_deviceVelocity(){} // RVA: 0x7ffaa8f70430
        public void set_deviceVelocity(){} // RVA: 0x7ffaa8f7aac0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa8f74760
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa8f6e0b0
        public void get_deviceAcceleration(){} // RVA: 0x7ffaa8f75b00
        public void set_deviceAcceleration(){} // RVA: 0x7ffaa93e8560
        public void get_deviceAngularAcceleration(){} // RVA: 0x7ffaa8f76170
        public void set_deviceAngularAcceleration(){} // RVA: 0x7ffaa93d3600
        public void FinishSetup(){} // RVA: 0x7ffaaef3a220
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OculusTrackingReference : TrackedDevice
    {
        // ── Original Methods ──
        public void get_trackingState(){} // RVA: 0x7ffaa8f6f0f0
        public void set_trackingState(){} // RVA: 0x7ffaa93d9af0
        public void get_isTracked(){} // RVA: 0x7ffaa8f78130
        public void set_isTracked(){} // RVA: 0x7ffaa93e4fb0
        public void FinishSetup(){} // RVA: 0x7ffaaef3ab40
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

}