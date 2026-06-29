// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.Oculus.Input
// Classes: 6
// Methods: 105

namespace ThirdParty.Other.Unity.XR.Oculus.Input
{
    public class GearVRTrackedController : XRController
    {
        // ── Methods ──
        public void get_touchpad(){} // RVA: 0x7A8B69B70
        public void set_touchpad(){} // RVA: 0x7A8B4DC50
        public void get_trigger(){} // RVA: 0x7A8B772D0
        public void set_trigger(){} // RVA: 0x7A8B58850
        public void get_back(){} // RVA: 0x7A8815B70
        public void set_back(){} // RVA: 0x7A8B58420
        public void get_triggerPressed(){} // RVA: 0x7A8B6AFA0
        public void set_triggerPressed(){} // RVA: 0x7A8B58B30
        public void get_touchpadClicked(){} // RVA: 0x7A8B79060
        public void set_touchpadClicked(){} // RVA: 0x7A8B49820
        public void get_touchpadTouched(){} // RVA: 0x7A8B5ED30
        public void set_touchpadTouched(){} // RVA: 0x7A8B5E380
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8688280
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B797E0
        public void get_deviceAcceleration(){} // RVA: 0x7A8B7A210
        public void set_deviceAcceleration(){} // RVA: 0x7A8B48CD0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7A8B562C0
        public void set_deviceAngularAcceleration(){} // RVA: 0x7A8B4A930
        public void FinishSetup(){} // RVA: 0x7AEB6E760
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class OculusHMD : XRHMD
    {
        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x7A8688280
        public void set_userPresence(){} // RVA: 0x7A8B797E0
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B7A210
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B48CD0
        public void get_deviceAcceleration(){} // RVA: 0x7A8B562C0
        public void set_deviceAcceleration(){} // RVA: 0x7A8B4A930
        public void get_deviceAngularAcceleration(){} // RVA: 0x7A8B50AF0
        public void set_deviceAngularAcceleration(){} // RVA: 0x7A8B61940
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7A8B62DA0
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7A8B63900
        public void get_leftEyeAcceleration(){} // RVA: 0x7A8B5B150
        public void set_leftEyeAcceleration(){} // RVA: 0x7A8B48310
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x7A8B63C30
        public void set_leftEyeAngularAcceleration(){} // RVA: 0x7A8B5FB80
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7A8B4BD50
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7A8B5EDA0
        public void get_rightEyeAcceleration(){} // RVA: 0x7A8B54F00
        public void set_rightEyeAcceleration(){} // RVA: 0x7A8B56C80
        public void get_rightEyeAngularAcceleration(){} // RVA: 0x7A8B53E80
        public void set_rightEyeAngularAcceleration(){} // RVA: 0x7A8B634D0
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7A8B651B0
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7A8B4D630
        public void get_centerEyeAcceleration(){} // RVA: 0x7A8B54430
        public void set_centerEyeAcceleration(){} // RVA: 0x7A8B580C0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7A8B588C0
        public void set_centerEyeAngularAcceleration(){} // RVA: 0x7A8B605E0
        public void FinishSetup(){} // RVA: 0x7AEB6D2B0
        public void .ctor(){} // RVA: 0x7AEB6BB90
        public void <userPresence>k__BackingField(){} // RVA: 0x7B4177678
    }

    public class OculusHMDExtended : OculusHMD
    {
        // ── Methods ──
        public void get_back(){} // RVA: 0x7A8B45F80
        public void set_back(){} // RVA: 0x7A8B4BC00
        public void get_touchpad(){} // RVA: 0x7A8B53F90
        public void set_touchpad(){} // RVA: 0x7A8B4DEF0
        public void FinishSetup(){} // RVA: 0x7AEB6E600
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class OculusRemote : InputDevice
    {
        // ── Methods ──
        public void get_back(){} // RVA: 0x7A884DD70
        public void set_back(){} // RVA: 0x7A8B5ADA0
        public void get_start(){} // RVA: 0x7A8855020
        public void set_start(){} // RVA: 0x7A8B60460
        public void get_touchpad(){} // RVA: 0x7A8B76160
        public void set_touchpad(){} // RVA: 0x7A8B592F0
        public void FinishSetup(){} // RVA: 0x7AEB6E420
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class OculusTouchController : XRControllerWithRumble
    {
        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7A8B69B70
        public void set_thumbstick(){} // RVA: 0x7A8B4DC50
        public void get_trigger(){} // RVA: 0x7A8B772D0
        public void set_trigger(){} // RVA: 0x7A8B58850
        public void get_grip(){} // RVA: 0x7A8815B70
        public void set_grip(){} // RVA: 0x7A8B58420
        public void get_primaryButton(){} // RVA: 0x7A8B6AFA0
        public void set_primaryButton(){} // RVA: 0x7A8B58B30
        public void get_secondaryButton(){} // RVA: 0x7A8B79060
        public void set_secondaryButton(){} // RVA: 0x7A8B49820
        public void get_gripPressed(){} // RVA: 0x7A8B5ED30
        public void set_gripPressed(){} // RVA: 0x7A8B5E380
        public void get_start(){} // RVA: 0x7A8688280
        public void set_start(){} // RVA: 0x7A8B797E0
        public void get_thumbstickClicked(){} // RVA: 0x7A8B7A210
        public void set_thumbstickClicked(){} // RVA: 0x7A8B48CD0
        public void get_primaryTouched(){} // RVA: 0x7A8B562C0
        public void set_primaryTouched(){} // RVA: 0x7A8B4A930
        public void get_secondaryTouched(){} // RVA: 0x7A8B50AF0
        public void set_secondaryTouched(){} // RVA: 0x7A8B61940
        public void get_triggerTouched(){} // RVA: 0x7A8B62DA0
        public void set_triggerTouched(){} // RVA: 0x7A8B63900
        public void get_triggerPressed(){} // RVA: 0x7A8B5B150
        public void set_triggerPressed(){} // RVA: 0x7A8B48310
        public void get_thumbstickTouched(){} // RVA: 0x7A8B63C30
        public void set_thumbstickTouched(){} // RVA: 0x7A8B5FB80
        public void get_deviceVelocity(){} // RVA: 0x7A8B4BD50
        public void set_deviceVelocity(){} // RVA: 0x7A8B5EDA0
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B54F00
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B56C80
        public void get_deviceAcceleration(){} // RVA: 0x7A8B53E80
        public void set_deviceAcceleration(){} // RVA: 0x7A8B634D0
        public void get_deviceAngularAcceleration(){} // RVA: 0x7A8B651B0
        public void set_deviceAngularAcceleration(){} // RVA: 0x7A8B4D630
        public void FinishSetup(){} // RVA: 0x7AEB6D9A0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class OculusTrackingReference : TrackedDevice
    {
        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7A8B69B70
        public void set_trackingState(){} // RVA: 0x7A8B4DC50
        public void get_isTracked(){} // RVA: 0x7A8B772D0
        public void set_isTracked(){} // RVA: 0x7A8B58850
        public void FinishSetup(){} // RVA: 0x7AEB6E2C0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

}