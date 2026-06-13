// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.Memory
// Classes: 2
// Methods: 11

namespace ThirdParty.Other.Unity.Profiling.Memory
{
    public class MemoryProfiler
    {
        // ── Methods ──
        public void add_CreatingMetadata(){} // RVA: 0x70B7A40
        public void remove_CreatingMetadata(){} // RVA: 0x70B7B80
        public void PrepareMetadata(){} // RVA: 0x70B7CC0
        public void WriteIntToByteArray(){} // RVA: 0x70B8000
        public void WriteStringToByteArray(){} // RVA: 0x70B8080
        public void FinalizeSnapshot(){} // RVA: 0x70B8100
        public void SaveScreenshotToDisk(){} // RVA: 0x70B81D0
    }

    public class MemorySnapshotMetadata
    {
        public string <Description>k__BackingField; // 0x10
        public byte[] <Data>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Description(){} // RVA: 0x2F8380
        public void set_Description(){} // RVA: 0x2DEE30
        public void get_Data(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x2DD310
    }

}