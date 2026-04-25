// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.ParticleSystemJobs
// Classes: 4
// Methods: 0

namespace ThirdParty.Unity.UnityEngine.ParticleSystemJobs
{
    public class NativeParticleData : ValueType
    {
        public int count; // 0x10
        public Array3 positions; // 0x18
        public Array3 velocities; // 0x30
        public Array3 axisOfRotations; // 0x48
        public Array3 rotations; // 0x60
        public Array3 rotationalSpeeds; // 0x78
        public Array3 sizes; // 0x90
        public void* startColors; // 0xA8
        public void* aliveTimePercent; // 0xB0
        public void* inverseStartLifetimes; // 0xB8
        public void* randomSeeds; // 0xC0
        public Array4 customData1; // 0xC8
        public Array4 customData2; // 0xE8
        public void* meshIndices; // 0x108
    }

    public class ParticleSystemJobData : ValueType
    {
        public int <count>k__BackingField; // 0x10
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <positions>k__BackingField; // 0x18
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <velocities>k__BackingField; // 0x48
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <axisOfRotations>k__BackingField; // 0x78
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotations>k__BackingField; // 0xA8
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; // 0xD8
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <sizes>k__BackingField; // 0x108
        public Unity.Collections.NativeArray`1<UnityEngine.Color32> <startColors>k__BackingField; // 0x138
        public Unity.Collections.NativeArray`1<float> <aliveTimePercent>k__BackingField; // 0x148
        public Unity.Collections.NativeArray`1<float> <inverseStartLifetimes>k__BackingField; // 0x158
        public Unity.Collections.NativeArray`1<uint> <randomSeeds>k__BackingField; // 0x168
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData1>k__BackingField; // 0x178
        public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData2>k__BackingField; // 0x1B8
        public Unity.Collections.NativeArray`1<int> <meshIndices>k__BackingField; // 0x1F8
    }

    public class ParticleSystemNativeArray3 : ValueType
    {
        public Unity.Collections.NativeArray`1<float> x; // 0x10
        public Unity.Collections.NativeArray`1<float> y; // 0x20
        public Unity.Collections.NativeArray`1<float> z; // 0x30
    }

    public class ParticleSystemNativeArray4 : ValueType
    {
        public Unity.Collections.NativeArray`1<float> x; // 0x10
        public Unity.Collections.NativeArray`1<float> y; // 0x20
        public Unity.Collections.NativeArray`1<float> z; // 0x30
        public Unity.Collections.NativeArray`1<float> w; // 0x40
    }

}