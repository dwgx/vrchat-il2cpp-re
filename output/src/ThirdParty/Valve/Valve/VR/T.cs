// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 0

namespace ThirdParty.Valve.Valve.VR
{
    public class Texture_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public 0x6659FE70 eType; // 0x18
        public 0x6659FEC8 eColorSpace; // 0x1C
    }

    public class TrackedDevicePose_t : ValueType
    {
        public Valve.VR.HmdMatrix34_t mDeviceToAbsoluteTracking; // 0x10
        public Valve.VR.HmdVector3_t vVelocity; // 0x40
        public Valve.VR.HmdVector3_t vAngularVelocity; // 0x4C
        public 0x6659FF20 eTrackingResult; // 0x58
        public bool bPoseIsValid; // 0x5C
        public bool bDeviceIsConnected; // 0x5D
    }

}