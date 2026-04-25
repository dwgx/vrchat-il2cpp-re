// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 3
// Methods: 5

namespace ThirdParty.Other.SteamAudio
{
    public class EmbreeDevice : Object
    {
        public UIntPtr mEmbreeDevice; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0B750 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0B7F0
        public void Release(){} // RVA: 0x7FFAC8C0B830
        public void Get(){} // RVA: 0x7FFAC2F3C380
    }

    public class EmbreeDeviceSettings : ValueType
    {
    }

    public class EnergyFieldSettings : ValueType
    {
        public float duration; // 0x10
        public int order; // 0x14
    }

}