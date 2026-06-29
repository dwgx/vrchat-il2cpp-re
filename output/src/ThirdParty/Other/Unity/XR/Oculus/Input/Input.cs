// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.Oculus.Input
// Classes: 6
// Methods: 104

namespace ThirdParty.Other.Unity.XR.Oculus.Input
{
    public class GearVRTrackedController : XRController
    {
        // ── Methods ──
        public void get_touchpad(){} // RVA: 0x165E8F0
        public void set_touchpad(){} // RVA: 0x165C4D0
        public void get_trigger(){} // RVA: 0x1659CB0
        public void set_trigger(){} // RVA: 0x163A980
        public void get_back(){} // RVA: 0x1344890
        public void set_back(){} // RVA: 0x1662780
        public void get_triggerPressed(){} // RVA: 0x1655DD0
        public void set_triggerPressed(){} // RVA: 0x16694D0
        public void get_touchpadClicked(){} // RVA: 0x1654670
        public void set_touchpadClicked(){} // RVA: 0x16612E0
        public void get_touchpadTouched(){} // RVA: 0x165AD10
        public void set_touchpadTouched(){} // RVA: 0x1667130
        public void get_deviceAngularVelocity(){} // RVA: 0x1184410
        public void set_deviceAngularVelocity(){} // RVA: 0x163ACA0
        public void get_deviceAcceleration(){} // RVA: 0x164FF50
        public void set_deviceAcceleration(){} // RVA: 0x16529A0
        public void get_deviceAngularAcceleration(){} // RVA: 0x1659260
        public void set_deviceAngularAcceleration(){} // RVA: 0x165DAA0
        public void FinishSetup(){} // RVA: 0x77D7AD0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OculusHMD : XRHMD
    {
        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x1184410
        public void set_userPresence(){} // RVA: 0x163ACA0
        public void get_deviceAngularVelocity(){} // RVA: 0x164FF50
        public void set_deviceAngularVelocity(){} // RVA: 0x16529A0
        public void get_deviceAcceleration(){} // RVA: 0x1659260
        public void set_deviceAcceleration(){} // RVA: 0x165DAA0
        public void get_deviceAngularAcceleration(){} // RVA: 0x136ECA0
        public void set_deviceAngularAcceleration(){} // RVA: 0x164C9D0
        public void get_leftEyeAngularVelocity(){} // RVA: 0x165F4F0
        public void set_leftEyeAngularVelocity(){} // RVA: 0x164A160
        public void get_leftEyeAcceleration(){} // RVA: 0x164EDD0
        public void set_leftEyeAcceleration(){} // RVA: 0x1651390
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x1640C90
        public void set_leftEyeAngularAcceleration(){} // RVA: 0x1668690
        public void get_rightEyeAngularVelocity(){} // RVA: 0x165F950
        public void set_rightEyeAngularVelocity(){} // RVA: 0x164BF20
        public void get_rightEyeAcceleration(){} // RVA: 0x1667A40
        public void set_rightEyeAcceleration(){} // RVA: 0x163A9E0
        public void get_rightEyeAngularAcceleration(){} // RVA: 0x165A670
        public void set_rightEyeAngularAcceleration(){} // RVA: 0x1661A80
        public void get_centerEyeAngularVelocity(){} // RVA: 0x163BF50
        public void set_centerEyeAngularVelocity(){} // RVA: 0x164C6E0
        public void get_centerEyeAcceleration(){} // RVA: 0x163F650
        public void set_centerEyeAcceleration(){} // RVA: 0x1656720
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x164AA90
        public void set_centerEyeAngularAcceleration(){} // RVA: 0x164B2D0
        public void FinishSetup(){} // RVA: 0x77D6620
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OculusHMDExtended : OculusHMD
    {
        // ── Methods ──
        public void get_back(){} // RVA: 0x165DF30
        public void set_back(){} // RVA: 0x164E760
        public void get_touchpad(){} // RVA: 0x16565B0
        public void set_touchpad(){} // RVA: 0x166D140
        public void FinishSetup(){} // RVA: 0x77D7970
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OculusRemote : InputDevice
    {
        // ── Methods ──
        public void get_back(){} // RVA: 0x13659D0
        public void set_back(){} // RVA: 0x166D270
        public void get_start(){} // RVA: 0x135C160
        public void set_start(){} // RVA: 0x16614A0
        public void get_touchpad(){} // RVA: 0x1664460
        public void set_touchpad(){} // RVA: 0x16679E0
        public void FinishSetup(){} // RVA: 0x77D7790
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OculusTouchController : XRControllerWithRumble
    {
        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x165E8F0
        public void set_thumbstick(){} // RVA: 0x165C4D0
        public void get_trigger(){} // RVA: 0x1659CB0
        public void set_trigger(){} // RVA: 0x163A980
        public void get_grip(){} // RVA: 0x1344890
        public void set_grip(){} // RVA: 0x1662780
        public void get_primaryButton(){} // RVA: 0x1655DD0
        public void set_primaryButton(){} // RVA: 0x16694D0
        public void get_secondaryButton(){} // RVA: 0x1654670
        public void set_secondaryButton(){} // RVA: 0x16612E0
        public void get_gripPressed(){} // RVA: 0x165AD10
        public void set_gripPressed(){} // RVA: 0x1667130
        public void get_start(){} // RVA: 0x1184410
        public void set_start(){} // RVA: 0x163ACA0
        public void get_thumbstickClicked(){} // RVA: 0x164FF50
        public void set_thumbstickClicked(){} // RVA: 0x16529A0
        public void get_primaryTouched(){} // RVA: 0x1659260
        public void set_primaryTouched(){} // RVA: 0x165DAA0
        public void get_secondaryTouched(){} // RVA: 0x136ECA0
        public void set_secondaryTouched(){} // RVA: 0x164C9D0
        public void get_triggerTouched(){} // RVA: 0x165F4F0
        public void set_triggerTouched(){} // RVA: 0x164A160
        public void get_triggerPressed(){} // RVA: 0x164EDD0
        public void set_triggerPressed(){} // RVA: 0x1651390
        public void get_thumbstickTouched(){} // RVA: 0x1640C90
        public void set_thumbstickTouched(){} // RVA: 0x1668690
        public void get_deviceVelocity(){} // RVA: 0x165F950
        public void set_deviceVelocity(){} // RVA: 0x164BF20
        public void get_deviceAngularVelocity(){} // RVA: 0x1667A40
        public void set_deviceAngularVelocity(){} // RVA: 0x163A9E0
        public void get_deviceAcceleration(){} // RVA: 0x165A670
        public void set_deviceAcceleration(){} // RVA: 0x1661A80
        public void get_deviceAngularAcceleration(){} // RVA: 0x163BF50
        public void set_deviceAngularAcceleration(){} // RVA: 0x164C6E0
        public void FinishSetup(){} // RVA: 0x77D6D10
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OculusTrackingReference : TrackedDevice
    {
        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x165E8F0
        public void set_trackingState(){} // RVA: 0x165C4D0
        public void get_isTracked(){} // RVA: 0x1659CB0
        public void set_isTracked(){} // RVA: 0x163A980
        public void FinishSetup(){} // RVA: 0x77D7630
        public void .ctor(){} // RVA: 0x77D4F00
    }

}