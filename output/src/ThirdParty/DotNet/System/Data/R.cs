// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 7
// Methods: 101

namespace ThirdParty.DotNet.System.Data
{
    public class RBTree`1 : Object
    {
        public TreePage<T>[] Count;
        public int[] HasDuplicates;
        public int Item;
        public int _nextFreePageLine;
        public int root;
        public int _version;
        public int _inUseNodeCount;
        public int _inUseSatelliteTreeCount;
        public 0x6B1D0088 _accessMethod;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x7FFAC2E8DC40
        public void CompareSateliteTreeNode(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void InitTree(){} // RVA: 0x7FFAC2C70980
        public void FreePage(){} // RVA: 0x7FFAC2C70A40
        public void AllocPage(){} // RVA: 0x7FFAC2C67DE0
        public void MarkPageFull(){} // RVA: 0x7FFAC2C70A40
        public void MarkPageFree(){} // RVA: 0x7FFAC2C70A40
        public void GetIntValueFromBitMap(){} // RVA: 0x7FFAC2C60110
        public void FreeNode(){} // RVA: 0x7FFAC2C70ED0
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x7FFAC2C5FB50
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_HasDuplicates(){} // RVA: 0x7FFAC2C59D00
        public void GetNewNode(){} // RVA: 0x7FFAC2E8DC40
        public void Successor(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
        public void Minimum(){} // RVA: 0x7FFAC2C600D0
        public void LeftRotate(){}
        public void RightRotate(){}
        public void RBInsert(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateNodeKey(){} // RVA: 0x7FFAC2E8DC40
        public void DeleteByIndex(){} // RVA: 0x7FFAC2E8DC40
        public void RBDelete(){} // RVA: 0x7FFAC2C600D0
        public void RBDeleteX(){}
        public void RBDeleteFixup(){} // RVA: 0x7FFAC2E8DC40
        public void SearchSubTree(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void GetNodeByKey(){} // RVA: 0x7FFAC2E8DC40
        public void GetIndexByKey(){} // RVA: 0x7FFAC2E8DC40
        public void GetIndexByNode(){} // RVA: 0x7FFAC2C600D0
        public void GetIndexByNodePath(){} // RVA: 0x7FFAC2E8DC40
        public void ComputeIndexByNode(){} // RVA: 0x7FFAC2C600D0
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x7FFAC2C600D0
        public void GetNodeByIndex(){} // RVA: 0x7FFAC2E8DC40
        public void ComputeNodeByIndex(){} // RVA: 0x7FFAC2C60290 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void InsertAt(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void CopyTo(){} // RVA: 0x7FFAC2C77970 | overloaded x2
        public void SetRight(){} // RVA: 0x7FFAC2C72E60
        public void SetLeft(){} // RVA: 0x7FFAC2C72E60
        public void SetParent(){} // RVA: 0x7FFAC2C72E60
        public void SetColor(){} // RVA: 0x7FFAC2E8DC40
        public void SetKey(){} // RVA: 0x7FFAC2E8DC40
        public void SetNext(){} // RVA: 0x7FFAC2C72E60
        public void SetSubTreeSize(){} // RVA: 0x7FFAC2C72E60
        public void IncreaseSize(){} // RVA: 0x7FFAC2C70ED0
        public void RecomputeSize(){} // RVA: 0x7FFAC2C70ED0
        public void DecreaseSize(){} // RVA: 0x7FFAC2C70ED0
        public void Right(){} // RVA: 0x7FFAC2C600D0
        public void Left(){} // RVA: 0x7FFAC2C600D0
        public void Parent(){} // RVA: 0x7FFAC2C600D0
        public void color(){} // RVA: 0x7FFAC2E8DC40
        public void Next(){} // RVA: 0x7FFAC2C600D0
        public void SubTreeSize(){} // RVA: 0x7FFAC2C600D0
        public void Key(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Range : ValueType
    {
        public int Count; // 0x10
        public int IsNull; // 0x14
        public bool Min; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EC3AA0
        public void get_Count(){} // RVA: 0x7FFAC8EC3AF0
        public void get_IsNull(){} // RVA: 0x7FFAC8EC3B10
        public void get_Min(){} // RVA: 0x7FFAC8EC3B20
        public void CheckNull(){} // RVA: 0x7FFAC8EC3B60
    }

    public class ReadOnlyException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E63250 | overloaded x3
    }

    public class RecordManager : Object
    {
        public System.Data.DataTable LastFreeRecord; // 0x10
        public int MinimumCapacity; // 0x18
        public int RecordCapacity; // 0x1C
        public int Item; // 0x20
        public System.Collections.Generic.List`1<int> _freeRecordList; // 0x28
        public System.Data.DataRow[] _rows; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EC3BA0
        public void GrowRecordCapacity(){} // RVA: 0x7FFAC8EC3D00
        public void get_LastFreeRecord(){} // RVA: 0x7FFAC3157800
        public void get_MinimumCapacity(){} // RVA: 0x7FFAC44357F0
        public void set_MinimumCapacity(){} // RVA: 0x7FFAC8EC3F60
        public void get_RecordCapacity(){} // RVA: 0x7FFAC30DBBE0
        public void set_RecordCapacity(){} // RVA: 0x7FFAC8EC3FA0
        public void NewCapacity(){} // RVA: 0x7FFAC8EC4080
        public void NormalizedMinimumCapacity(){} // RVA: 0x7FFAC8EC4090
        public void NewRecordBase(){} // RVA: 0x7FFAC8EC40D0
        public void FreeRecord(){} // RVA: 0x7FFAC8EC41B0
        public void Clear(){} // RVA: 0x7FFAC8EC4330
        public void get_Item(){} // RVA: 0x7FFAC8EC45A0
        public void set_Item(){} // RVA: 0x7FFAC8EC45D0
        public void ImportRecord(){} // RVA: 0x7FFAC8EC4640
        public void CopyRecord(){} // RVA: 0x7FFAC8EC4660
        public void SetRowCache(){} // RVA: 0x7FFAC8EC4980
    }

    public class RelatedView : DataView
    {
        public System.Nullable`1<System.Data.DataKey> _parentKey; // 0xD0
        public System.Data.DataKey _childKey; // 0xE0
        public System.Data.DataRowView _parentRowView; // 0xE8
        public object[] _filterValues; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EC4C30 | overloaded x2
        public void GetParentValues(){} // RVA: 0x7FFAC8EC4EE0
        public void Invoke(){} // RVA: 0x7FFAC8EC4FF0
        public void GetFilter(){} // RVA: 0x7FFAC44F81E0
        public void AddNew(){} // RVA: 0x7FFAC8EC5150
        public void SetIndex(){} // RVA: 0x7FFAC8EC51C0
    }

    public class RelationshipConverter : ExpandableObjectConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CanConvertTo(){} // RVA: 0x7FFAC8EC5210
        public void ConvertTo(){} // RVA: 0x7FFAC8EC5300
    }

    public class RowNotInTableException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E632C0 | overloaded x3
    }

}