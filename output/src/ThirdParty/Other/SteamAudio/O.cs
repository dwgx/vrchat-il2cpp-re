// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 3
// Methods: 5

namespace ThirdParty.Other.SteamAudio
{
    public class OpenCLDevice : Object
    {
        public UIntPtr mOpenCLDevice; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0CB10 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0CBB0
        public void Release(){} // RVA: 0x7FFAC8C0CBF0
        public void Get(){} // RVA: 0x7FFAC2F3C380
    }

    public class OpenCLDeviceDesc : ValueType
    {
        public UIntPtr platform; // 0x10
        public string platformName; // 0x18
        public string platformVendor; // 0x20
        public string platformVersion; // 0x28
        public UIntPtr device; // 0x30
        public string deviceName; // 0x38
        public string deviceVendor; // 0x40
        public string deviceVersion; // 0x48
        public 0x6B298600 type; // 0x50
        public int numConvolutionCUs; // 0x54
        public int numIRUpdateCUs; // 0x58
        public int granularity; // 0x5C
        public float perfScore; // 0x60
    }

    public class OpenCLDeviceSettings : ValueType
    {
        public 0x6B298600 type; // 0x10
        public int numCUsToReserve; // 0x14
        public float fractionCUsForIRUpdate; // 0x18
        public 0x6B298448 requiresTAN; // 0x1C
    }

}