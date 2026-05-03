// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 16

namespace ThirdParty.DotNet.System.Data
{
    public class MergeFailedEventArgs : EventArgs
    {
        public System.Data.DataTable _table; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87268550
        public void get_Conflict(){} // RVA: 0x7FFE810FE7C0
    }

    public class MergeFailedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class Merger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872686D0 | overloaded x2
        public void MergeDataSet(){} // RVA: 0x7FFE87268740
        public void MergeTable(){} // RVA: 0x7FFE872696E0 | overloaded x2
        public void MergeSchema(){} // RVA: 0x7FFE87269C10
        public void MergeTableData(){} // RVA: 0x7FFE8726A680
        public void MergeConstraints(){} // RVA: 0x7FFE8726A7B0 | overloaded x2
        public void MergeRelation(){} // RVA: 0x7FFE8726AA90
        public void MergeExtendedProperties(){} // RVA: 0x7FFE8726B520
        public void GetSrcKey(){} // RVA: 0x7FFE8726B6F0
    }

}