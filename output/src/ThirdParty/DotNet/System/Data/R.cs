// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 7
// Methods: 101

namespace ThirdParty.DotNet.System.Data
{
    public class RBTree`1 : Object
    {
        public TreePage<T>[] _pageTable;
        public int[] _pageTableMap;
        public int _inUsePageCount;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x7FFE810A1420
        public void CompareSateliteTreeNode(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void InitTree(){} // RVA: 0x7FFE80E45FE0
        public void FreePage(){} // RVA: 0x7FFE80E460A0
        public void AllocPage(){} // RVA: 0x7FFE80E3D230
        public void MarkPageFull(){} // RVA: 0x7FFE80E460A0
        public void MarkPageFree(){} // RVA: 0x7FFE80E460A0
        public void GetIntValueFromBitMap(){} // RVA: 0x7FFE80E35560
        public void FreeNode(){} // RVA: 0x7FFE80E46530
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x7FFE80E34FA0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_HasDuplicates(){} // RVA: 0x7FFE80E2F150
        public void GetNewNode(){} // RVA: 0x7FFE810A1420
        public void Successor(){} // RVA: 0x7FFE80E32650 | overloaded x2
        public void Minimum(){} // RVA: 0x7FFE80E35520
        public void LeftRotate(){}
        public void RightRotate(){}
        public void RBInsert(){} // RVA: 0x7FFE810A1420
        public void UpdateNodeKey(){} // RVA: 0x7FFE810A1420
        public void DeleteByIndex(){} // RVA: 0x7FFE810A1420
        public void RBDelete(){} // RVA: 0x7FFE80E35520
        public void RBDeleteX(){}
        public void RBDeleteFixup(){} // RVA: 0x7FFE810A1420
        public void SearchSubTree(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void GetNodeByKey(){} // RVA: 0x7FFE810A1420
        public void GetIndexByKey(){} // RVA: 0x7FFE810A1420
        public void GetIndexByNode(){} // RVA: 0x7FFE80E35520
        public void GetIndexByNodePath(){} // RVA: 0x7FFE810A1420
        public void ComputeIndexByNode(){} // RVA: 0x7FFE80E35520
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x7FFE80E35520
        public void GetNodeByIndex(){} // RVA: 0x7FFE810A1420
        public void ComputeNodeByIndex(){} // RVA: 0x7FFE80E356E0 | overloaded x2
        public void Insert(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Add(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void InsertAt(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void CopyTo(){} // RVA: 0x7FFE80E4D070 | overloaded x2
        public void SetRight(){} // RVA: 0x7FFE80E484C0
        public void SetLeft(){} // RVA: 0x7FFE80E484C0
        public void SetParent(){} // RVA: 0x7FFE80E484C0
        public void SetColor(){} // RVA: 0x7FFE810A1420
        public void SetKey(){} // RVA: 0x7FFE810A1420
        public void SetNext(){} // RVA: 0x7FFE80E484C0
        public void SetSubTreeSize(){} // RVA: 0x7FFE80E484C0
        public void IncreaseSize(){} // RVA: 0x7FFE80E46530
        public void RecomputeSize(){} // RVA: 0x7FFE80E46530
        public void DecreaseSize(){} // RVA: 0x7FFE80E46530
        public void Right(){} // RVA: 0x7FFE80E35520
        public void Left(){} // RVA: 0x7FFE80E35520
        public void Parent(){} // RVA: 0x7FFE80E35520
        public void color(){} // RVA: 0x7FFE810A1420
        public void Next(){} // RVA: 0x7FFE80E35520
        public void SubTreeSize(){} // RVA: 0x7FFE80E35520
        public void Key(){} // RVA: 0x7FFE810A1420
    }

    public class Range : ValueType
    {
        public int _min; // 0x10
        public int _max; // 0x14
        public bool _isNotNull; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8726BEF0
        public void get_Count(){} // RVA: 0x7FFE8726BF40
        public void get_IsNull(){} // RVA: 0x7FFE8726BF60
        public void get_Min(){} // RVA: 0x7FFE8726BF70
        public void CheckNull(){} // RVA: 0x7FFE8726BFB0
    }

    public class ReadOnlyException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B680 | overloaded x3
    }

    public class RecordManager : Object
    {
        public System.Data.DataTable _table; // 0x10
        public int _lastFreeRecord; // 0x18
        public int _minimumCapacity; // 0x1C
        public int _recordCapacity; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8726BFF0
        public void GrowRecordCapacity(){} // RVA: 0x7FFE8726C150
        public void get_LastFreeRecord(){} // RVA: 0x7FFE813DB630
        public void get_MinimumCapacity(){} // RVA: 0x7FFE82707EE0
        public void set_MinimumCapacity(){} // RVA: 0x7FFE8726C3B0
        public void get_RecordCapacity(){} // RVA: 0x7FFE8151D690
        public void set_RecordCapacity(){} // RVA: 0x7FFE8726C3F0
        public void NewCapacity(){} // RVA: 0x7FFE8726C4D0
        public void NormalizedMinimumCapacity(){} // RVA: 0x7FFE8726C4E0
        public void NewRecordBase(){} // RVA: 0x7FFE8726C520
        public void FreeRecord(){} // RVA: 0x7FFE8726C600
        public void Clear(){} // RVA: 0x7FFE8726C780
        public void get_Item(){} // RVA: 0x7FFE8726C9F0
        public void set_Item(){} // RVA: 0x7FFE8726CA20
        public void ImportRecord(){} // RVA: 0x7FFE8726CA90
        public void CopyRecord(){} // RVA: 0x7FFE8726CAB0
        public void SetRowCache(){} // RVA: 0x7FFE8726CDD0
    }

    public class RelatedView : DataView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8726D080 | overloaded x2
        public void GetParentValues(){} // RVA: 0x7FFE8726D330
        public void Invoke(){} // RVA: 0x7FFE8726D440
        public void GetFilter(){} // RVA: 0x7FFE827C4A80
        public void AddNew(){} // RVA: 0x7FFE8726D5A0
        public void SetIndex(){} // RVA: 0x7FFE8726D610
    }

    public class RelationshipConverter : ExpandableObjectConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CanConvertTo(){} // RVA: 0x7FFE8726D660
        public void ConvertTo(){} // RVA: 0x7FFE8726D750
    }

    public class RowNotInTableException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B6F0 | overloaded x3
    }

}