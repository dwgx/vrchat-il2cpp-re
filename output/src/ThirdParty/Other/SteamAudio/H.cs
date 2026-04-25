// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 3
// Methods: 7

namespace ThirdParty.Other.SteamAudio
{
    public class HRTF : Object
    {
        public UIntPtr mHRTF; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0BE10 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC8C0BEB0
        public void Release(){} // RVA: 0x7FFAC8C0BEF0
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void dBToGain(){} // RVA: 0x7FFAC8C0BF70
    }

    public class HRTFSettings : ValueType
    {
        public 0x6B2986B0 type; // 0x10
        public string sofaFileName; // 0x18
        public UIntPtr sofaFileData; // 0x20
        public int sofaFileDataSize; // 0x28
        public float volume; // 0x2C
        public 0x6B298708 normType; // 0x30
        public UIntPtr sofaPreloaded; // 0x38
        public int sofaPreloadedNumSamples; // 0x40
    }

    public class Hit : ValueType
    {
        public float distance; // 0x10
        public int triangleIndex; // 0x14
        public int objectIndex; // 0x18
        public int materialIndex; // 0x1C
        public SteamAudio.Vector3 normal; // 0x20
        public UIntPtr material; // 0x30
    }

}