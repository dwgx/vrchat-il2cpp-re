// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.Memory
// Classes: 3
// Methods: 26

namespace ThirdParty.Other.Unity.Profiling.Memory
{
    public class MemoryProfiler : Object
    {
        public object m_SnapshotFinished;
        public object m_SaveScreenshotToDisk;
        public object CreatingMetadata;

        // ── Methods ──
        public void add_CreatingMetadata(){} // RVA: 0x7B4A830
        public void remove_CreatingMetadata(){} // RVA: 0x7B4A970
        public void PrepareMetadata(){} // RVA: 0x7B4AAB0
        public void WriteIntToByteArray(){} // RVA: 0x7B4ADD0
        public void WriteStringToByteArray(){} // RVA: 0x7B4AE50
        public void FinalizeSnapshot(){} // RVA: 0x7B4AED0
        public void SaveScreenshotToDisk(){} // RVA: 0x7B4AFA0
    }

    public class MemoryProfiler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MemorySnapshotMetadata : Object
    {
        public object _description;
        public object _data;

        // ── Methods ──
        public void get_Description(){} // RVA: 0xB5DBF0
        public void set_Description(){} // RVA: 0xB44D60
        public void get_Data(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0xB43310
    }

}