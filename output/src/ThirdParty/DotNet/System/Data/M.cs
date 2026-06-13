// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 16

namespace ThirdParty.DotNet.System.Data
{
    public class MergeFailedEventArgs
    {
        public System.Data.DataTable <Table>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6729650
        public void get_Conflict(){} // RVA: 0x2E07C0
    }

    public class MergeFailedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class Merger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67297D0 | overloaded x2
        public void MergeDataSet(){} // RVA: 0x6729840
        public void MergeTable(){} // RVA: 0x672A7E0 | overloaded x2
        public void MergeSchema(){} // RVA: 0x672AD10
        public void MergeTableData(){} // RVA: 0x672B780
        public void MergeConstraints(){} // RVA: 0x672B8B0 | overloaded x2
        public void MergeRelation(){} // RVA: 0x672BB90
        public void MergeExtendedProperties(){} // RVA: 0x672C620
        public void GetSrcKey(){} // RVA: 0x672C7F0
    }

}