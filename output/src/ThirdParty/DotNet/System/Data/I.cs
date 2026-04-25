// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 7
// Methods: 86

namespace ThirdParty.DotNet.System.Data
{
    public class IFilter
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7FFAC2C5C920
    }

    public class InRowChangingEventException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E63100 | overloaded x3
    }

    public class Index : Object
    {
        public System.Data.DataTable HasRemoteAggregate; // 0x10
        public System.Data.IndexField[] ObjectID; // 0x18
        public System.Comparison`1<System.Data.DataRow> RecordStates; // 0x20
        public 0x6B1CF320 RowFilter; // 0x28
        public System.WeakReference HasDuplicates; // 0x30
        public IndexTree RecordCount; // 0x38
        public int RefCount; // 0x40
        public int DoListChanged; // 0x44
        public System.Data.Listeners`1<System.Data.DataViewListener> Table; // 0x48
        public bool _suspendEvents; // 0x50
        public bool _isSharable; // 0x51
        public bool _hasRemoteAggregate; // 0x52
        public int s_objectTypeCount;
        public int _objectID; // 0x54

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EC6640 | overloaded x3
        public void GetAllFields(){} // RVA: 0x7FFAC8EC6490
        public void Equal(){} // RVA: 0x7FFAC8EC6C80
        public void get_HasRemoteAggregate(){} // RVA: 0x7FFAC825F9A0
        public void get_ObjectID(){} // RVA: 0x7FFAC38913D0
        public void get_RecordStates(){} // RVA: 0x7FFAC32EC4C0
        public void get_RowFilter(){} // RVA: 0x7FFAC8EC6D30
        public void GetRecord(){} // RVA: 0x7FFAC8EC6DC0
        public void get_HasDuplicates(){} // RVA: 0x7FFAC8EC6E70
        public void get_RecordCount(){} // RVA: 0x7FFAC2FC2080
        public void AcceptRecord(){} // RVA: 0x7FFAC8EC6EF0 | overloaded x2
        public void ListChangedAdd(){} // RVA: 0x7FFAC8EC7030
        public void ListChangedRemove(){} // RVA: 0x7FFAC8EC70F0
        public void get_RefCount(){} // RVA: 0x7FFAC2FC20A0
        public void AddRef(){} // RVA: 0x7FFAC8EC72A0
        public void RemoveRef(){} // RVA: 0x7FFAC8EC74A0
        public void ApplyChangeAction(){} // RVA: 0x7FFAC8EC7660
        public void CheckUnique(){} // RVA: 0x7FFAC8EC7700
        public void CompareRecords(){} // RVA: 0x7FFAC8EC7750
        public void CompareDataRows(){} // RVA: 0x7FFAC8EC7980
        public void CompareDuplicateRecords(){} // RVA: 0x7FFAC8EC7A00
        public void CompareRecordToKey(){} // RVA: 0x7FFAC8EC7B90
        public void DeleteRecordFromIndex(){} // RVA: 0x7FFAC8EC7C90
        public void DeleteRecord(){} // RVA: 0x7FFAC8EC7CB0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC8EC7DC0
        public void GetIndex(){} // RVA: 0x7FFAC8EC7E80 | overloaded x2
        public void GetUniqueKeyValues(){} // RVA: 0x7FFAC8ECA630 | overloaded x2
        public void FindNodeByKey(){} // RVA: 0x7FFAC8EC8180
        public void FindNodeByKeys(){} // RVA: 0x7FFAC8EC8450
        public void FindNodeByKeyRecord(){} // RVA: 0x7FFAC8EC8800
        public void GetRangeFromNode(){} // RVA: 0x7FFAC8EC8920
        public void FindRecords(){} // RVA: 0x7FFAC8EC8B30 | overloaded x2
        public void FireResetEvent(){} // RVA: 0x7FFAC8EC8B80
        public void GetChangeAction(){} // RVA: 0x7FFAC8EC8C70
        public void GetReplaceAction(){} // RVA: 0x7FFAC8EC8C90
        public void GetRow(){} // RVA: 0x7FFAC8EC8CB0
        public void GetRows(){} // RVA: 0x7FFAC8EC8D50 | overloaded x2
        public void InitRecords(){} // RVA: 0x7FFAC8EC8F70
        public void InsertRecordToIndex(){} // RVA: 0x7FFAC8EC93B0
        public void InsertRecord(){} // RVA: 0x7FFAC8EC9410
        public void IsKeyInIndex(){} // RVA: 0x7FFAC8EC9660 | overloaded x2
        public void IsKeyRecordInIndex(){} // RVA: 0x7FFAC8EC9680
        public void get_DoListChanged(){} // RVA: 0x7FFAC8EC97A0
        public void OnListChanged(){} // RVA: 0x7FFAC8EC9950 | overloaded x3
        public void MaintainDataView(){} // RVA: 0x7FFAC8EC9B50
        public void Reset(){} // RVA: 0x7FFAC8EC9C90
        public void RecordChanged(){} // RVA: 0x7FFAC8EC9E50 | overloaded x2
        public void RecordStateChanged(){} // RVA: 0x7FFAC8ECA150 | overloaded x2
        public void get_Table(){} // RVA: 0x7FFAC2F3C380
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IndexField : ValueType
    {
        public System.Data.DataColumn Column; // 0x10
        public bool IsDescending; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC37E8550
        public void op_Equality(){} // RVA: 0x7FFAC8EC6140
        public void Equals(){} // RVA: 0x7FFAC8EC6160
        public void GetHashCode(){} // RVA: 0x7FFAC8EC61F0
    }

    public class InternalDataCollectionBase : Object
    {
        public System.ComponentModel.CollectionChangeEventArgs Count;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC8E81970
        public void CopyTo(){} // RVA: 0x7FFAC8E819B0
        public void GetEnumerator(){} // RVA: 0x7FFAC8E81A10
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void NamesEqual(){} // RVA: 0x7FFAC8E81A50
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void get_List(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8E81C00
    }

    public class InvalidConstraintException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E63170 | overloaded x3
    }

    public class InvalidExpressionException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E62F40 | overloaded x3
    }

}