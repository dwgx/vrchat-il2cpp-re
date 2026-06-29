// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 210

namespace ThirdParty.DotNet.System.Data
{
    public class RBTree`1 : Object
    {
        public object _pageTable;
        public object _pageTableMap;
        public object _inUsePageCount;
        public object _nextFreePageLine;
        public object root;
        public object _version;
        public object _inUseNodeCount;
        public object _inUseSatelliteTreeCount;
        public object _accessMethod;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0xA94080
        public void CompareSateliteTreeNode(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x8944F0
        public void InitTree(){} // RVA: 0x894290
        public void FreePage(){} // RVA: 0x894320
        public void AllocPage(){} // RVA: 0x87C160
        public void MarkPageFull(){} // RVA: 0x894320
        public void MarkPageFree(){} // RVA: 0x894320
        public void GetIntValueFromBitMap(){} // RVA: 0x883700
        public void FreeNode(){} // RVA: 0x8944F0
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x882F70
        public void get_Count(){} // RVA: 0x87C130
        public void get_HasDuplicates(){} // RVA: 0x87D280
        public void GetNewNode(){} // RVA: 0xA94080
        public void Successor(){} // RVA: 0x87D3C0
        public void Minimum(){} // RVA: 0x881C20
        public void LeftRotate(){} // RVA: 0x8838D0
        public void RightRotate(){} // RVA: 0x8838D0
        public void RBInsert(){} // RVA: 0xA94080
        public void UpdateNodeKey(){} // RVA: 0xA94080
        public void DeleteByIndex(){} // RVA: 0xA94080
        public void RBDelete(){} // RVA: 0x881C20
        public void RBDeleteX(){} // RVA: 0x8838D0
        public void RBDeleteFixup(){} // RVA: 0xA94080
        public void SearchSubTree(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0xA94080
        public void GetNodeByKey(){} // RVA: 0xA94080
        public void GetIndexByKey(){} // RVA: 0xA94080
        public void GetIndexByNode(){} // RVA: 0x881C20
        public void GetIndexByNodePath(){} // RVA: 0xA94080
        public void ComputeIndexByNode(){} // RVA: 0x881C20
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x881C20
        public void GetNodeByIndex(){} // RVA: 0xA94080
        public void ComputeNodeByIndex(){} // RVA: 0x8830B0
        public void Insert(){} // RVA: 0xA94080
        public void Add(){} // RVA: 0xA94080
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void IndexOf(){} // RVA: 0xA94080
        public void InsertAt(){} // RVA: 0xA94080
        public void RemoveAt(){} // RVA: 0x8944F0
        public void Clear(){} // RVA: 0x894290
        public void CopyTo(){} // RVA: 0x899290
        public void SetRight(){} // RVA: 0x8965E0
        public void SetLeft(){} // RVA: 0x8965E0
        public void SetParent(){} // RVA: 0x8965E0
        public void SetColor(){} // RVA: 0xA94080
        public void SetKey(){} // RVA: 0xA94080
        public void SetNext(){} // RVA: 0x8965E0
        public void SetSubTreeSize(){} // RVA: 0x8965E0
        public void IncreaseSize(){} // RVA: 0x8944F0
        public void RecomputeSize(){} // RVA: 0x8944F0
        public void DecreaseSize(){} // RVA: 0x8944F0
        public void Right(){} // RVA: 0x881C20
        public void Left(){} // RVA: 0x881C20
        public void Parent(){} // RVA: 0x881C20
        public void color(){} // RVA: 0xA94080
        public void Next(){} // RVA: 0x881C20
        public void SubTreeSize(){} // RVA: 0x881C20
        public void Key(){} // RVA: 0xA94080
    }

    public class RBTree`1 : Object
    {
        public object _pageTable;
        public object _pageTableMap;
        public object _inUsePageCount;
        public object _nextFreePageLine;
        public object root;
        public object _version;
        public object _inUseNodeCount;
        public object _inUseSatelliteTreeCount;
        public object _accessMethod;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x881CA0
        public void CompareSateliteTreeNode(){} // RVA: 0x881CA0
        public void .ctor(){} // RVA: 0x48D9500
        public void InitTree(){} // RVA: 0x48D9520
        public void FreePage(){} // RVA: 0x48D3880
        public void AllocPage(){} // RVA: 0x48D9730
        public void MarkPageFull(){} // RVA: 0x48D3C10
        public void MarkPageFree(){} // RVA: 0x48D3C70
        public void GetIntValueFromBitMap(){} // RVA: 0x48D3CD0
        public void FreeNode(){} // RVA: 0x48D9A40
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x48D3EA0
        public void get_Count(){} // RVA: 0x48D4040
        public void get_HasDuplicates(){} // RVA: 0x48D4050
        public void GetNewNode(){} // RVA: 0x48D9BA0
        public void Successor(){} // RVA: 0x48D9F40
        public void Minimum(){} // RVA: 0x48DA060
        public void LeftRotate(){} // RVA: 0x48DA0F0
        public void RightRotate(){} // RVA: 0x48DA8B0
        public void RBInsert(){} // RVA: 0x48DB070
        public void UpdateNodeKey(){} // RVA: 0x48DBE70
        public void DeleteByIndex(){} // RVA: 0x48DBF20
        public void RBDelete(){} // RVA: 0x48DBFE0
        public void RBDeleteX(){} // RVA: 0x48DC010
        public void RBDeleteFixup(){} // RVA: 0x48DD070
        public void SearchSubTree(){} // RVA: 0x48DD5F0
        public void get_Item(){} // RVA: 0x48DD6B0
        public void GetNodeByKey(){} // RVA: 0x48DD720
        public void GetIndexByKey(){} // RVA: 0x48DD8B0
        public void GetIndexByNode(){} // RVA: 0x48DD9D0
        public void GetIndexByNodePath(){} // RVA: 0x48DDB70
        public void ComputeIndexByNode(){} // RVA: 0x48DDC30
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x48DDDA0
        public void GetNodeByIndex(){} // RVA: 0x48DDF60
        public void ComputeNodeByIndex(){} // RVA: 0x48DE1D0
        public void Insert(){} // RVA: 0x48DE520
        public void Add(){} // RVA: 0x48DE2B0
        public void GetEnumerator(){} // RVA: 0x48DE330
        public void IndexOf(){} // RVA: 0x48DE400
        public void InsertAt(){} // RVA: 0x48DE5C0
        public void RemoveAt(){} // RVA: 0x48DE660
        public void Clear(){} // RVA: 0x48DE710
        public void CopyTo(){} // RVA: 0x48DE8C0
        public void SetRight(){} // RVA: 0x48DEAA0
        public void SetLeft(){} // RVA: 0x48DEAF0
        public void SetParent(){} // RVA: 0x48DEB40
        public void SetColor(){} // RVA: 0x48DEB90
        public void SetKey(){} // RVA: 0x48DEBE0
        public void SetNext(){} // RVA: 0x48DECA0
        public void SetSubTreeSize(){} // RVA: 0x48DECF0
        public void IncreaseSize(){} // RVA: 0x48DED40
        public void RecomputeSize(){} // RVA: 0x48DED90
        public void DecreaseSize(){} // RVA: 0x48DEF50
        public void Right(){} // RVA: 0x48DEFA0
        public void Left(){} // RVA: 0x48DF000
        public void Parent(){} // RVA: 0x48DF060
        public void color(){} // RVA: 0x48DF0C0
        public void Next(){} // RVA: 0x48DF120
        public void SubTreeSize(){} // RVA: 0x48DF180
        public void Key(){} // RVA: 0x48DF1E0
    }

    public class RBTree`1 : Object
    {
        public object _pageTable;
        public object _pageTableMap;
        public object _inUsePageCount;
        public object _nextFreePageLine;
        public object root;
        public object _version;
        public object _inUseNodeCount;
        public object _inUseSatelliteTreeCount;
        public object _accessMethod;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x8830B0
        public void CompareSateliteTreeNode(){} // RVA: 0x8830B0
        public void .ctor(){} // RVA: 0x48D3650
        public void InitTree(){} // RVA: 0x48D3670
        public void FreePage(){} // RVA: 0x48D3880
        public void AllocPage(){} // RVA: 0x48D3900
        public void MarkPageFull(){} // RVA: 0x48D3C10
        public void MarkPageFree(){} // RVA: 0x48D3C70
        public void GetIntValueFromBitMap(){} // RVA: 0x48D3CD0
        public void FreeNode(){} // RVA: 0x48D3D40
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x48D3EA0
        public void get_Count(){} // RVA: 0x48D4040
        public void get_HasDuplicates(){} // RVA: 0x48D4050
        public void GetNewNode(){} // RVA: 0x48D4060
        public void Successor(){} // RVA: 0x48D4390
        public void Minimum(){} // RVA: 0x48D44B0
        public void LeftRotate(){} // RVA: 0x48D4540
        public void RightRotate(){} // RVA: 0x48D4C40
        public void RBInsert(){} // RVA: 0x48D5340
        public void UpdateNodeKey(){} // RVA: 0x48D6180
        public void DeleteByIndex(){} // RVA: 0x48D6260
        public void RBDelete(){} // RVA: 0x48D6320
        public void RBDeleteX(){} // RVA: 0x48D6350
        public void RBDeleteFixup(){} // RVA: 0x48D73C0
        public void SearchSubTree(){} // RVA: 0x48D7940
        public void get_Item(){} // RVA: 0x48D7A00
        public void GetNodeByKey(){} // RVA: 0x48D7A70
        public void GetIndexByKey(){} // RVA: 0x48D7C40
        public void GetIndexByNode(){} // RVA: 0x48D7D60
        public void GetIndexByNodePath(){} // RVA: 0x48D7F00
        public void ComputeIndexByNode(){} // RVA: 0x48D7FC0
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x48D8130
        public void GetNodeByIndex(){} // RVA: 0x48D82F0
        public void ComputeNodeByIndex(){} // RVA: 0x48D8570
        public void Insert(){} // RVA: 0x48D8910
        public void Add(){} // RVA: 0x48D8650
        public void GetEnumerator(){} // RVA: 0x48D86D0
        public void IndexOf(){} // RVA: 0x48D87A0
        public void InsertAt(){} // RVA: 0x48D8940
        public void RemoveAt(){} // RVA: 0x48D89E0
        public void Clear(){} // RVA: 0x48D8A00
        public void CopyTo(){} // RVA: 0x48D8BD0
        public void SetRight(){} // RVA: 0x48D8D40
        public void SetLeft(){} // RVA: 0x48D8DA0
        public void SetParent(){} // RVA: 0x48D8E00
        public void SetColor(){} // RVA: 0x48D8E60
        public void SetKey(){} // RVA: 0x48D8EC0
        public void SetNext(){} // RVA: 0x48D8F20
        public void SetSubTreeSize(){} // RVA: 0x48D8F80
        public void IncreaseSize(){} // RVA: 0x48D8FE0
        public void RecomputeSize(){} // RVA: 0x48D9040
        public void DecreaseSize(){} // RVA: 0x48D9200
        public void Right(){} // RVA: 0x48D9260
        public void Left(){} // RVA: 0x48D92C0
        public void Parent(){} // RVA: 0x48D9320
        public void color(){} // RVA: 0x48D9380
        public void Next(){} // RVA: 0x48D93E0
        public void SubTreeSize(){} // RVA: 0x48D9440
        public void Key(){} // RVA: 0x48D94A0
    }

    public class Range : ValueType
    {
        public object _min;
        public object _max;
        public object _isNotNull;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9033E0
        public void get_Count(){} // RVA: 0x903430
        public void get_IsNull(){} // RVA: 0x903450
        public void get_Min(){} // RVA: 0x903460
        public void CheckNull(){} // RVA: 0x9034A0
    }

    public class ReadOnlyException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135FC0
    }

    public class RecordManager : Object
    {
        public object _table;
        public object _lastFreeRecord;
        public object _minimumCapacity;
        public object _recordCapacity;
        public object _freeRecordList;
        public object _rows;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7194BF0
        public void GrowRecordCapacity(){} // RVA: 0x7194D50
        public void get_LastFreeRecord(){} // RVA: 0xE62D00
        public void get_MinimumCapacity(){} // RVA: 0x2244FB0
        public void set_MinimumCapacity(){} // RVA: 0x7194FB0
        public void get_RecordCapacity(){} // RVA: 0xFEAE90
        public void set_RecordCapacity(){} // RVA: 0x7194FF0
        public void NewCapacity(){} // RVA: 0x71950D0
        public void NormalizedMinimumCapacity(){} // RVA: 0x71950E0
        public void NewRecordBase(){} // RVA: 0x7195120
        public void FreeRecord(){} // RVA: 0x7195200
        public void Clear(){} // RVA: 0x7195380
        public void get_Item(){} // RVA: 0x7195620
        public void set_Item(){} // RVA: 0x7195650
        public void ImportRecord(){} // RVA: 0x71956C0
        public void CopyRecord(){} // RVA: 0x71956E0
        public void SetRowCache(){} // RVA: 0x7195950
    }

    public class RelatedView : DataView
    {
        public object _parentKey;
        public object _childKey;
        public object _parentRowView;
        public object _filterValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7195C00
        public void GetParentValues(){} // RVA: 0x7195EB0
        public void Invoke(){} // RVA: 0x7195FC0
        public void GetFilter(){} // RVA: 0x2303260
        public void AddNew(){} // RVA: 0x7196150
        public void SetIndex(){} // RVA: 0x71961C0
    }

    public class RelationshipConverter : ExpandableObjectConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CanConvertTo(){} // RVA: 0x7196210
        public void ConvertTo(){} // RVA: 0x7196310
    }

    public class RowNotInTableException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7136030
    }

}