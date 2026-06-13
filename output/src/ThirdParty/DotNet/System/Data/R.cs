// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 227

namespace ThirdParty.DotNet.System.Data
{
    public class RBTree`1
    {
        public TreePage<T>[] _pageTable;
        public int[] _pageTableMap;
        public int _inUsePageCount;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x283FA0
        public void CompareSateliteTreeNode(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24FA0
        public void InitTree(){} // RVA: 0x24A50
        public void FreePage(){} // RVA: 0x24B10
        public void AllocPage(){} // RVA: 0x1BCC0
        public void MarkPageFull(){} // RVA: 0x24B10
        public void MarkPageFree(){} // RVA: 0x24B10
        public void GetIntValueFromBitMap(){} // RVA: 0x13FF0
        public void FreeNode(){} // RVA: 0x24FA0
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x13A30
        public void get_Count(){} // RVA: 0xD840
        public void get_HasDuplicates(){} // RVA: 0xDBE0
        public void GetNewNode(){} // RVA: 0x283FA0
        public void Successor(){} // RVA: 0x11120 | overloaded x2
        public void Minimum(){} // RVA: 0x13FB0
        public void LeftRotate(){}
        public void RightRotate(){}
        public void RBInsert(){} // RVA: 0x283FA0
        public void UpdateNodeKey(){} // RVA: 0x283FA0
        public void DeleteByIndex(){} // RVA: 0x283FA0
        public void RBDelete(){} // RVA: 0x13FB0
        public void RBDeleteX(){}
        public void RBDeleteFixup(){} // RVA: 0x283FA0
        public void SearchSubTree(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void GetNodeByKey(){} // RVA: 0x283FA0
        public void GetIndexByKey(){} // RVA: 0x283FA0
        public void GetIndexByNode(){} // RVA: 0x13FB0
        public void GetIndexByNodePath(){} // RVA: 0x283FA0
        public void ComputeIndexByNode(){} // RVA: 0x13FB0
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x13FB0
        public void GetNodeByIndex(){} // RVA: 0x283FA0
        public void ComputeNodeByIndex(){} // RVA: 0x14170 | overloaded x2
        public void Insert(){} // RVA: 0x283FA0 | overloaded x2
        public void Add(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void IndexOf(){} // RVA: 0x283FA0
        public void InsertAt(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void Clear(){} // RVA: 0x24A50
        public void CopyTo(){} // RVA: 0x2BAA0 | overloaded x2
        public void SetRight(){} // RVA: 0x26EE0
        public void SetLeft(){} // RVA: 0x26EE0
        public void SetParent(){} // RVA: 0x26EE0
        public void SetColor(){} // RVA: 0x283FA0
        public void SetKey(){} // RVA: 0x283FA0
        public void SetNext(){} // RVA: 0x26EE0
        public void SetSubTreeSize(){} // RVA: 0x26EE0
        public void IncreaseSize(){} // RVA: 0x24FA0
        public void RecomputeSize(){} // RVA: 0x24FA0
        public void DecreaseSize(){} // RVA: 0x24FA0
        public void Right(){} // RVA: 0x13FB0
        public void Left(){} // RVA: 0x13FB0
        public void Parent(){} // RVA: 0x13FB0
        public void color(){} // RVA: 0x283FA0
        public void Next(){} // RVA: 0x13FB0
        public void SubTreeSize(){} // RVA: 0x13FB0
        public void Key(){} // RVA: 0x283FA0
    }

    public class RBTree`1
    {
        public TreePage<System.Data.DataRow>[] _pageTable; // 0x10
        public int[] _pageTableMap; // 0x18
        public int _inUsePageCount; // 0x20

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x17680
        public void CompareSateliteTreeNode(){} // RVA: 0x17680
        public void .ctor(){} // RVA: 0x3E3B3E0
        public void InitTree(){} // RVA: 0x3E3B400
        public void FreePage(){} // RVA: 0x3E354C0
        public void AllocPage(){} // RVA: 0x3E3B610
        public void MarkPageFull(){} // RVA: 0x3E35850
        public void MarkPageFree(){} // RVA: 0x3E358B0
        public void GetIntValueFromBitMap(){} // RVA: 0x3E35910
        public void FreeNode(){} // RVA: 0x3E3B920
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x3E35AE0
        public void get_Count(){} // RVA: 0x3E35C70
        public void get_HasDuplicates(){} // RVA: 0x3E35C80
        public void GetNewNode(){} // RVA: 0x3E3BA90
        public void Successor(){} // RVA: 0x3E3BE70 | overloaded x2
        public void Minimum(){} // RVA: 0x3E3BF90
        public void LeftRotate(){} // RVA: 0x3E3C020
        public void RightRotate(){} // RVA: 0x3E3C8B0
        public void RBInsert(){} // RVA: 0x3E3D140
        public void UpdateNodeKey(){} // RVA: 0x3E3DF40
        public void DeleteByIndex(){} // RVA: 0x3E3DFF0
        public void RBDelete(){} // RVA: 0x3E3E0B0
        public void RBDeleteX(){} // RVA: 0x3E3E0E0
        public void RBDeleteFixup(){} // RVA: 0x3E3F150
        public void SearchSubTree(){} // RVA: 0x3E3F6D0
        public void get_Item(){} // RVA: 0x3E3F790
        public void GetNodeByKey(){} // RVA: 0x3E3F800
        public void GetIndexByKey(){} // RVA: 0x3E3F9A0
        public void GetIndexByNode(){} // RVA: 0x3E3FAC0
        public void GetIndexByNodePath(){} // RVA: 0x3E3FC60
        public void ComputeIndexByNode(){} // RVA: 0x3E3FD20
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x3E3FE90
        public void GetNodeByIndex(){} // RVA: 0x3E40050
        public void ComputeNodeByIndex(){} // RVA: 0x3E402C0 | overloaded x2
        public void Insert(){} // RVA: 0x3E40610 | overloaded x2
        public void Add(){} // RVA: 0x3E403A0
        public void GetEnumerator(){} // RVA: 0x3E40420
        public void IndexOf(){} // RVA: 0x3E404F0
        public void InsertAt(){} // RVA: 0x3E406B0
        public void RemoveAt(){} // RVA: 0x3E40750
        public void Clear(){} // RVA: 0x3E40800
        public void CopyTo(){} // RVA: 0x3E409B0 | overloaded x2
        public void SetRight(){} // RVA: 0x3E40B70
        public void SetLeft(){} // RVA: 0x3E40BC0
        public void SetParent(){} // RVA: 0x3E40C10
        public void SetColor(){} // RVA: 0x3E40C60
        public void SetKey(){} // RVA: 0x3E40CB0
        public void SetNext(){} // RVA: 0x3E40D70
        public void SetSubTreeSize(){} // RVA: 0x3E40DC0
        public void IncreaseSize(){} // RVA: 0x3E40E10
        public void RecomputeSize(){} // RVA: 0x3E40E60
        public void DecreaseSize(){} // RVA: 0x3E41080
        public void Right(){} // RVA: 0x3E410D0
        public void Left(){} // RVA: 0x3E41130
        public void Parent(){} // RVA: 0x3E41190
        public void color(){} // RVA: 0x3E411F0
        public void Next(){} // RVA: 0x3E41250
        public void SubTreeSize(){} // RVA: 0x3E412B0
        public void Key(){} // RVA: 0x3E41310
    }

    public class RBTree`1
    {
        public TreePage<int>[] _pageTable; // 0x10
        public int[] _pageTableMap; // 0x18
        public int _inUsePageCount; // 0x20

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x14170
        public void CompareSateliteTreeNode(){} // RVA: 0x14170
        public void .ctor(){} // RVA: 0x3E35290
        public void InitTree(){} // RVA: 0x3E352B0
        public void FreePage(){} // RVA: 0x3E354C0
        public void AllocPage(){} // RVA: 0x3E35540
        public void MarkPageFull(){} // RVA: 0x3E35850
        public void MarkPageFree(){} // RVA: 0x3E358B0
        public void GetIntValueFromBitMap(){} // RVA: 0x3E35910
        public void FreeNode(){} // RVA: 0x3E35980
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x3E35AE0
        public void get_Count(){} // RVA: 0x3E35C70
        public void get_HasDuplicates(){} // RVA: 0x3E35C80
        public void GetNewNode(){} // RVA: 0x3E35C90
        public void Successor(){} // RVA: 0x3E35FF0 | overloaded x2
        public void Minimum(){} // RVA: 0x3E36110
        public void LeftRotate(){} // RVA: 0x3E361A0
        public void RightRotate(){} // RVA: 0x3E36970
        public void RBInsert(){} // RVA: 0x3E37140
        public void UpdateNodeKey(){} // RVA: 0x3E37F70
        public void DeleteByIndex(){} // RVA: 0x3E38050
        public void RBDelete(){} // RVA: 0x3E38110
        public void RBDeleteX(){} // RVA: 0x3E38140
        public void RBDeleteFixup(){} // RVA: 0x3E39200
        public void SearchSubTree(){} // RVA: 0x3E39780
        public void get_Item(){} // RVA: 0x3E39840
        public void GetNodeByKey(){} // RVA: 0x3E398B0
        public void GetIndexByKey(){} // RVA: 0x3E39AC0
        public void GetIndexByNode(){} // RVA: 0x3E39BE0
        public void GetIndexByNodePath(){} // RVA: 0x3E39D80
        public void ComputeIndexByNode(){} // RVA: 0x3E39E40
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x3E39FB0
        public void GetNodeByIndex(){} // RVA: 0x3E3A170
        public void ComputeNodeByIndex(){} // RVA: 0x3E3A3E0 | overloaded x2
        public void Insert(){} // RVA: 0x3E3A780 | overloaded x2
        public void Add(){} // RVA: 0x3E3A4C0
        public void GetEnumerator(){} // RVA: 0x3E3A540
        public void IndexOf(){} // RVA: 0x3E3A610
        public void InsertAt(){} // RVA: 0x3E3A7B0
        public void RemoveAt(){} // RVA: 0x3E3A850
        public void Clear(){} // RVA: 0x3E3A870
        public void CopyTo(){} // RVA: 0x3E3AA40 | overloaded x2
        public void SetRight(){} // RVA: 0x3E3ABC0
        public void SetLeft(){} // RVA: 0x3E3AC20
        public void SetParent(){} // RVA: 0x3E3AC80
        public void SetColor(){} // RVA: 0x3E3ACE0
        public void SetKey(){} // RVA: 0x3E3AD40
        public void SetNext(){} // RVA: 0x3E3ADA0
        public void SetSubTreeSize(){} // RVA: 0x3E3AE00
        public void IncreaseSize(){} // RVA: 0x3E3AE60
        public void RecomputeSize(){} // RVA: 0x3E3AEC0
        public void DecreaseSize(){} // RVA: 0x3E3B0E0
        public void Right(){} // RVA: 0x3E3B140
        public void Left(){} // RVA: 0x3E3B1A0
        public void Parent(){} // RVA: 0x3E3B200
        public void color(){} // RVA: 0x3E3B260
        public void Next(){} // RVA: 0x3E3B2C0
        public void SubTreeSize(){} // RVA: 0x3E3B320
        public void Key(){} // RVA: 0x3E3B380
    }

    public class Range
    {
        public int _min; // 0x10
        public int _max; // 0x14
        public bool _isNotNull; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x672CFF0
        public void get_Count(){} // RVA: 0x672D040
        public void get_IsNull(){} // RVA: 0x672D060
        public void get_Min(){} // RVA: 0x672D070
        public void CheckNull(){} // RVA: 0x672D0B0
    }

    public class ReadOnlyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CC790 | overloaded x3
    }

    public class RecordManager
    {
        public System.Data.DataTable _table; // 0x10
        public int _lastFreeRecord; // 0x18
        public int _minimumCapacity; // 0x1C
        public int _recordCapacity; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x672D0F0
        public void GrowRecordCapacity(){} // RVA: 0x672D250
        public void get_LastFreeRecord(){} // RVA: 0x5BED50
        public void get_MinimumCapacity(){} // RVA: 0x197C3B0
        public void set_MinimumCapacity(){} // RVA: 0x672D4B0
        public void get_RecordCapacity(){} // RVA: 0x760030
        public void set_RecordCapacity(){} // RVA: 0x672D4F0
        public void NewCapacity(){} // RVA: 0x672D5D0
        public void NormalizedMinimumCapacity(){} // RVA: 0x672D5E0
        public void NewRecordBase(){} // RVA: 0x672D620
        public void FreeRecord(){} // RVA: 0x672D700
        public void Clear(){} // RVA: 0x672D880
        public void get_Item(){} // RVA: 0x672DAF0
        public void set_Item(){} // RVA: 0x672DB20
        public void ImportRecord(){} // RVA: 0x672DB90
        public void CopyRecord(){} // RVA: 0x672DBB0
        public void SetRowCache(){} // RVA: 0x672DED0
    }

    public class RelatedView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x672E180 | overloaded x2
        public void GetParentValues(){} // RVA: 0x672E430
        public void Invoke(){} // RVA: 0x672E540
        public void GetFilter(){} // RVA: 0x1A3F520
        public void AddNew(){} // RVA: 0x672E6A0
        public void SetIndex(){} // RVA: 0x672E710
    }

    public class RelationshipConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CanConvertTo(){} // RVA: 0x672E760
        public void ConvertTo(){} // RVA: 0x672E850
    }

    public class RowNotInTableException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CC800 | overloaded x3
    }

}