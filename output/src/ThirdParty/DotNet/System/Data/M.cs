// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 16

namespace ThirdParty.DotNet.System.Data
{
    public class MergeFailedEventArgs : EventArgs
    {
        public System.Data.DataTable Conflict; // 0x10
        public string <Conflict>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EC0100
        public void get_Conflict(){} // RVA: 0x7FFAC2F247C0
    }

    public class MergeFailedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class Merger : Object
    {
        public System.Data.DataSet _dataSet; // 0x10
        public System.Data.DataTable _dataTable; // 0x18
        public bool _preserveChanges; // 0x20
        public 0x6B1CFED0 _missingSchemaAction; // 0x24
        public bool _isStandAlonetable; // 0x28
        public bool _IgnoreNSforTableLookup; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EC0280 | overloaded x2
        public void MergeDataSet(){} // RVA: 0x7FFAC8EC02F0
        public void MergeTable(){} // RVA: 0x7FFAC8EC1290 | overloaded x2
        public void MergeSchema(){} // RVA: 0x7FFAC8EC17C0
        public void MergeTableData(){} // RVA: 0x7FFAC8EC2230
        public void MergeConstraints(){} // RVA: 0x7FFAC8EC2360 | overloaded x2
        public void MergeRelation(){} // RVA: 0x7FFAC8EC2640
        public void MergeExtendedProperties(){} // RVA: 0x7FFAC8EC30D0
        public void GetSrcKey(){} // RVA: 0x7FFAC8EC32A0
    }

}