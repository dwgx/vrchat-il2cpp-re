// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.MemoryProfiler
// Classes: 3
// Methods: 7

namespace ThirdParty.Other.Unity.MemoryProfiler
{
    public class DefaultMetadataCollect : MetadataCollect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7958CD0
        public void CollectMetadata(){} // RVA: 0x7958E30
    }

    public class MetadataCollect : Object
    {
        public object disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7958A70
        public void CollectMetadata(){} // RVA: 0x894320
        public void Dispose(){} // RVA: 0x7958BA0
    }

    public class MetadataInjector : Object
    {
        public object DefaultCollector;
        public object CollectorCount;
        public object DefaultCollectorInjected;

        // ── Methods ──
        public void PlayerInitMetadata(){} // RVA: 0x7958630
        public void InitializeMetadataCollection(){} // RVA: 0x7958860
    }

}