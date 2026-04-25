// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 3
// Methods: 5

namespace ThirdParty.Other.SteamAudio
{
    public class Triangle : ValueType
    {
        public int index0; // 0x10
        public int index1; // 0x14
        public int index2; // 0x18
    }

    public class TrueAudioNextDevice : Object
    {
        public UIntPtr mTrueAudioNextDevice; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C32280 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C32320
        public void Release(){} // RVA: 0x7FFAC8C32360
        public void Get(){} // RVA: 0x7FFAC2F3C380
    }

    public class TrueAudioNextDeviceSettings : ValueType
    {
        public int frameSize; // 0x10
        public int irSize; // 0x14
        public int order; // 0x18
        public int maxSources; // 0x1C
    }

}