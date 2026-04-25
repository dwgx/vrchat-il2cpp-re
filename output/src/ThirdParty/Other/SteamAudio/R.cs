// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 9
// Methods: 5

namespace ThirdParty.Other.SteamAudio
{
    public class RadeonRaysDevice : Object
    {
        public UIntPtr mRadeonRaysDevice; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0DAB0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0DB50
        public void Release(){} // RVA: 0x7FFAC8C0DB90
        public void Get(){} // RVA: 0x7FFAC2F3C380
    }

    public class RadeonRaysDeviceSettings : ValueType
    {
    }

    public class Ray : ValueType
    {
        public SteamAudio.Vector3 origin; // 0x10
        public SteamAudio.Vector3 direction; // 0x1C
    }

    public class ReconstructorInputs : ValueType
    {
        public UIntPtr energyField; // 0x10
    }

    public class ReconstructorOutputs : ValueType
    {
        public UIntPtr impulseResponse; // 0x10
    }

    public class ReconstructorSettings : ValueType
    {
        public float maxDuration; // 0x10
        public int maxOrder; // 0x14
        public int samplingRate; // 0x18
    }

    public class ReconstructorSharedInputs : ValueType
    {
        public float duration; // 0x10
        public int order; // 0x14
    }

    public class ReflectionEffectParams : ValueType
    {
        public 0x6B298B80 type; // 0x10
        public UIntPtr ir; // 0x18
        public float reverbTimesLow; // 0x20
        public float reverbTimesMid; // 0x24
        public float reverbTimesHigh; // 0x28
        public float eqLow; // 0x2C
        public float eqMid; // 0x30
        public float eqHigh; // 0x34
        public int delay; // 0x38
        public int numChannels; // 0x3C
        public int irSize; // 0x40
        public UIntPtr tanDevice; // 0x48
        public int tanSlot; // 0x50
    }

    public class ReflectionsBakeParams : ValueType
    {
        public UIntPtr scene; // 0x10
        public UIntPtr probeBatch; // 0x18
        public 0x6B298658 sceneType; // 0x20
        public SteamAudio.BakedDataIdentifier identifier; // 0x24
        public 0x6B298BD8 flags; // 0x3C
        public int numRays; // 0x40
        public int numDiffuseSamples; // 0x44
        public int numBounces; // 0x48
        public float simulatedDuration; // 0x4C
        public float savedDuration; // 0x50
        public int order; // 0x54
        public int numThreads; // 0x58
        public int rayBatchSize; // 0x5C
        public float irradianceMinDistance; // 0x60
        public int bakeBatchSize; // 0x64
        public UIntPtr openCLDevice; // 0x68
        public UIntPtr radeonRaysDevice; // 0x70
    }

}