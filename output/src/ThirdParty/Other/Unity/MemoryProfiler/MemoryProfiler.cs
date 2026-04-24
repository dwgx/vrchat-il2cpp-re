// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.MemoryProfiler
// Classes: 3
// Methods: 7

namespace ThirdParty.Other.Unity.MemoryProfiler
{
    public class DefaultMetadataCollect : MetadataCollect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AC5D20
        public void CollectMetadata(){} // RVA: 0x7FFD54AC5E80
    }

    public class MetadataCollect : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AC5AC0
        public void CollectMetadata(){} // RVA: 0x7FFD4E090A40
        public void Dispose(){} // RVA: 0x7FFD54AC5BF0
    }

    public class MetadataInjector : Object
    {
        public etNames.ts DefaultCollector;
        public long CollectorCount; // 0x8
        public byte DefaultCollectorInjected; // 0x10

        // ── Methods ──
        public void PlayerInitMetadata(){} // RVA: 0x7FFD54AC5680
        public void InitializeMetadataCollection(){} // RVA: 0x7FFD54AC58B0
    }

}