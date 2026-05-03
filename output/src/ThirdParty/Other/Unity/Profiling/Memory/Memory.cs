// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.Memory
// Classes: 2
// Methods: 11

namespace ThirdParty.Other.Unity.Profiling.Memory
{
    public class MemoryProfiler : Object
    {
        // ── Methods ──
        public void add_CreatingMetadata(){} // RVA: 0x7FFE87BF8A20
        public void remove_CreatingMetadata(){} // RVA: 0x7FFE87BF8B60
        public void PrepareMetadata(){} // RVA: 0x7FFE87BF8CA0
        public void WriteIntToByteArray(){} // RVA: 0x7FFE87BF8FE0
        public void WriteStringToByteArray(){} // RVA: 0x7FFE87BF9060
        public void FinalizeSnapshot(){} // RVA: 0x7FFE87BF90E0
        public void SaveScreenshotToDisk(){} // RVA: 0x7FFE87BF91B0
    }

    public class MemorySnapshotMetadata : Object
    {
        public string _description; // 0x10
        public byte[] _data; // 0x18

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFE81116380
        public void set_Description(){} // RVA: 0x7FFE810FCE30
        public void get_Data(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}