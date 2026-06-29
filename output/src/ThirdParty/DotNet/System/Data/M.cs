// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 13

namespace ThirdParty.DotNet.System.Data
{
    public class MergeFailedEventArgs : EventArgs
    {
        public object _table;
        public object _conflict;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71912E0
        public void get_Conflict(){} // RVA: 0xB465B0
    }

    public class MergeFailedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Merger : Object
    {
        public object _dataSet;
        public object _dataTable;
        public object _preserveChanges;
        public object _missingSchemaAction;
        public object _isStandAlonetable;
        public object _IgnoreNSforTableLookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7191460
        public void MergeDataSet(){} // RVA: 0x71914D0
        public void MergeTable(){} // RVA: 0x7192430
        public void MergeSchema(){} // RVA: 0x7192950
        public void MergeTableData(){} // RVA: 0x71933B0
        public void MergeConstraints(){} // RVA: 0x71934F0
        public void MergeRelation(){} // RVA: 0x71937D0
        public void MergeExtendedProperties(){} // RVA: 0x7194210
        public void GetSrcKey(){} // RVA: 0x71943E0
    }

}