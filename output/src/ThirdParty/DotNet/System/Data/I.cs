// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 7
// Methods: 67

namespace ThirdParty.DotNet.System.Data
{
    public class IFilter
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x87FE70
    }

    public class InRowChangingEventException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135E70
    }

    public class Index : Object
    {
        public object _table;
        public object _indexFields;
        public object _comparison;
        public object _recordStates;
        public object _rowFilter;
        public object _records;
        public object _recordCount;
        public object _refCount;
        public object _listeners;
        public object _suspendEvents;
        public object _isSharable;
        public object _hasRemoteAggregate;
        public object s_objectTypeCount;
        public object _objectID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7197640
        public void GetAllFields(){} // RVA: 0x7197480
        public void Equal(){} // RVA: 0x7197C80
        public void get_HasRemoteAggregate(){} // RVA: 0x24BE000
        public void get_ObjectID(){} // RVA: 0x15443F0
        public void get_RecordStates(){} // RVA: 0x1065D50
        public void get_RowFilter(){} // RVA: 0x7197D50
        public void GetRecord(){} // RVA: 0x7197DE0
        public void get_HasDuplicates(){} // RVA: 0x7197E90
        public void get_RecordCount(){} // RVA: 0xBE5850
        public void AcceptRecord(){} // RVA: 0x7197F10
        public void ListChangedAdd(){} // RVA: 0x7198050
        public void ListChangedRemove(){} // RVA: 0x7198110
        public void get_RefCount(){} // RVA: 0xBE5870
        public void AddRef(){} // RVA: 0x7198170
        public void RemoveRef(){} // RVA: 0x7198370
        public void ApplyChangeAction(){} // RVA: 0x7198530
        public void CheckUnique(){} // RVA: 0x71985D0
        public void CompareRecords(){} // RVA: 0x7198620
        public void CompareDataRows(){} // RVA: 0x7198860
        public void CompareDuplicateRecords(){} // RVA: 0x71988E0
        public void CompareRecordToKey(){} // RVA: 0x7198A50
        public void DeleteRecordFromIndex(){} // RVA: 0x7198B60
        public void DeleteRecord(){} // RVA: 0x7198B80
        public void GetEnumerator(){} // RVA: 0x7198C90
        public void GetIndex(){} // RVA: 0x7198D50
        public void GetUniqueKeyValues(){} // RVA: 0x719B500
        public void FindNodeByKey(){} // RVA: 0x7199040
        public void FindNodeByKeys(){} // RVA: 0x7199310
        public void FindNodeByKeyRecord(){} // RVA: 0x71996E0
        public void GetRangeFromNode(){} // RVA: 0x71997F0
        public void FindRecords(){} // RVA: 0x7199A00
        public void FireResetEvent(){} // RVA: 0x7199A50
        public void GetChangeAction(){} // RVA: 0x7199B40
        public void GetReplaceAction(){} // RVA: 0x7199B60
        public void GetRow(){} // RVA: 0x7199B80
        public void GetRows(){} // RVA: 0x7199C20
        public void InitRecords(){} // RVA: 0x7199E50
        public void InsertRecordToIndex(){} // RVA: 0x719A280
        public void InsertRecord(){} // RVA: 0x719A2E0
        public void IsKeyInIndex(){} // RVA: 0x719A530
        public void IsKeyRecordInIndex(){} // RVA: 0x719A550
        public void get_DoListChanged(){} // RVA: 0x719A670
        public void OnListChanged(){} // RVA: 0x719A820
        public void MaintainDataView(){} // RVA: 0x719AA20
        public void Reset(){} // RVA: 0x719AB60
        public void RecordChanged(){} // RVA: 0x719AD20
        public void RecordStateChanged(){} // RVA: 0x719B020
        public void get_Table(){} // RVA: 0xB5DBF0
        public void IndexOfReference(){} // RVA: 0xA94080
    }

    public class IndexField : ValueType
    {
        public object Column;
        public object IsDescending;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A130
        public void op_Equality(){} // RVA: 0x7197160
        public void Equals(){} // RVA: 0x9035A0
        public void GetHashCode(){} // RVA: 0x903630
    }

    public class InternalDataCollectionBase : Object
    {
        public object s_refreshEventArgs;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7153F40
        public void CopyTo(){} // RVA: 0x7153F80
        public void GetEnumerator(){} // RVA: 0x7153FE0
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void NamesEqual(){} // RVA: 0x7154020
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void get_List(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x71541D0
    }

    public class InvalidConstraintException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135EE0
    }

    public class InvalidExpressionException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135CB0
    }

}