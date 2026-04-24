// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 0

namespace ThirdParty.Valve.Valve.VR
{
    public class Texture_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public lyTransform eType; // 0x18
        public oleForTrackedDeviceIndex eColorSpace; // 0x1C
    }

    public class TrackedDevicePose_t : ValueType
    {
        public hPosePacked mDeviceToAbsoluteTracking; // 0x10
        public VRChaperone vVelocity; // 0x40
        public VRChaperone vAngularVelocity; // 0x4C
        public dDeviceIndex eTrackingResult; // 0x58
        public bool bPoseIsValid; // 0x5C
        public bool bDeviceIsConnected; // 0x5D
    }

}