// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 2
// Methods: 0

namespace ThirdParty.Other.OVR.OpenVR
{
    public class Texture_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public 0x6B1B5B70 eType; // 0x18
        public 0x6B1B5BC8 eColorSpace; // 0x1C
    }

    public class TrackedDevicePose_t : ValueType
    {
        public OVR.OpenVR.HmdMatrix34_t mDeviceToAbsoluteTracking; // 0x10
        public OVR.OpenVR.HmdVector3_t vVelocity; // 0x40
        public OVR.OpenVR.HmdVector3_t vAngularVelocity; // 0x4C
        public 0x6B1B5C20 eTrackingResult; // 0x58
        public bool bPoseIsValid; // 0x5C
        public bool bDeviceIsConnected; // 0x5D
    }

}