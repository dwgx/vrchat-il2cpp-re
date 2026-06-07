// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 7
// Methods: 101

namespace ThirdParty.DotNet.System.Data
{
    public class RBTree`1
    {
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

    public class Range
    {
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