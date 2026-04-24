// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 3
// Methods: 0

namespace ThirdParty.Valve.Valve.VR
{
    public class D3D12TextureData_t : ValueType
    {
        public UIntPtr m_pResource; // 0x10
        public UIntPtr m_pCommandQueue; // 0x18
        public uint m_nNodeMask; // 0x20
    }

    public class DistortionCoordinates_t : ValueType
    {
        public float rfRed0; // 0x10
        public float rfRed1; // 0x14
        public float rfGreen0; // 0x18
        public float rfGreen1; // 0x1C
        public float rfBlue0; // 0x20
        public float rfBlue1; // 0x24
    }

    public class DriverDirectMode_FrameTiming : ValueType
    {
        public uint m_nSize; // 0x10
        public uint m_nNumFramePresents; // 0x14
        public uint m_nNumMisPresented; // 0x18
        public uint m_nNumDroppedFrames; // 0x1C
        public uint m_nReprojectionFlags; // 0x20
    }

}