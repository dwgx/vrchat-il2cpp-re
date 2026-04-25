// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Profiling
// Classes: 3
// Methods: 10

namespace ThirdParty.Unity.UnityEngine.Profiling
{
    public class CustomSampler : Sampler
    {
        public UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98DB4A0
        public void .cctor(){} // RVA: 0x7FFAC98DB4F0
    }

    public class Profiler : Object
    {
        public object enabled;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC98DB220
        public void GetMonoHeapSizeLong(){} // RVA: 0x7FFAC98DB270
        public void GetMonoUsedSizeLong(){} // RVA: 0x7FFAC98DB2C0
        public void GetTotalAllocatedMemoryLong(){} // RVA: 0x7FFAC98DB310
        public void GetTotalUnusedReservedMemoryLong(){} // RVA: 0x7FFAC98DB360
        public void GetTotalReservedMemoryLong(){} // RVA: 0x7FFAC98DB3B0
    }

    public class Sampler : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.Profiling.Sampler s_InvalidSampler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC98DB400
    }

}