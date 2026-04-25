// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.Memory
// Classes: 2
// Methods: 11

namespace ThirdParty.Other.Unity.Profiling.Memory
{
    public class MemoryProfiler : Object
    {
        public System.Action`2<string,bool> m_SnapshotFinished;
        public System.Action`3<string,bool,Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
        public System.Action`1<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata; // 0x10

        // ── Methods ──
        public void add_CreatingMetadata(){} // RVA: 0x7FFAC9850480
        public void remove_CreatingMetadata(){} // RVA: 0x7FFAC98505C0
        public void PrepareMetadata(){} // RVA: 0x7FFAC9850700
        public void WriteIntToByteArray(){} // RVA: 0x7FFAC9850A40
        public void WriteStringToByteArray(){} // RVA: 0x7FFAC9850AC0
        public void FinalizeSnapshot(){} // RVA: 0x7FFAC9850B40
        public void SaveScreenshotToDisk(){} // RVA: 0x7FFAC9850C10
    }

    public class MemorySnapshotMetadata : Object
    {
        public string Description; // 0x10
        public byte[] Data; // 0x18

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAC2F3C380
        public void set_Description(){} // RVA: 0x7FFAC2F22E30
        public void get_Data(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}