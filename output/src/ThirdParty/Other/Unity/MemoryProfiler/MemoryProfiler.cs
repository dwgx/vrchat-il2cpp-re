// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.MemoryProfiler
// Classes: 3
// Methods: 7

namespace ThirdParty.Other.Unity.MemoryProfiler
{
    public class DefaultMetadataCollect : MetadataCollect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A5D20
        public void CollectMetadata(){} // RVA: 0x7FFAC96A5E80
    }

    public class MetadataCollect : Object
    {
        public bool disposed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A5AC0
        public void CollectMetadata(){} // RVA: 0x7FFAC2C70A40
        public void Dispose(){} // RVA: 0x7FFAC96A5BF0
    }

    public class MetadataInjector : Object
    {
        public Unity.MemoryProfiler.DefaultMetadataCollect DefaultCollector;
        public long CollectorCount; // 0x8
        public byte DefaultCollectorInjected; // 0x10

        // ── Methods ──
        public void PlayerInitMetadata(){} // RVA: 0x7FFAC96A5680
        public void InitializeMetadataCollection(){} // RVA: 0x7FFAC96A58B0
    }

}