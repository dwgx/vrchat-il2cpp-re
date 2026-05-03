// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 7
// Methods: 86

namespace ThirdParty.DotNet.System.Data
{
    public class IFilter
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7FFE80E31D70
    }

    public class InRowChangingEventException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B530 | overloaded x3
    }

    public class Index : Object
    {
        public System.Data.DataTable _table; // 0x10
        public System.Data.IndexField[] _indexFields; // 0x18
        public System.Comparison`1<System.Data.DataRow> _comparison; // 0x20
        public 0x665C8BE4 _recordStates; // 0x28
        public System.WeakReference _rowFilter; // 0x30
        public IndexTree _records; // 0x38
        public int _recordCount; // 0x40
        public int _refCount; // 0x44
        public System.Data.Listeners`1<System.Data.DataViewListener> _listeners; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8726EA90 | overloaded x3
        public void GetAllFields(){} // RVA: 0x7FFE8726E8E0
        public void Equal(){} // RVA: 0x7FFE8726F0D0
        public void get_HasRemoteAggregate(){} // RVA: 0x7FFE82976140
        public void get_ObjectID(){} // RVA: 0x7FFE819EA920
        public void get_RecordStates(){} // RVA: 0x7FFE81549710
        public void get_RowFilter(){} // RVA: 0x7FFE8726F180
        public void GetRecord(){} // RVA: 0x7FFE8726F210
        public void get_HasDuplicates(){} // RVA: 0x7FFE8726F2C0
        public void get_RecordCount(){} // RVA: 0x7FFE8119C080
        public void AcceptRecord(){} // RVA: 0x7FFE8726F340 | overloaded x2
        public void ListChangedAdd(){} // RVA: 0x7FFE8726F480
        public void ListChangedRemove(){} // RVA: 0x7FFE8726F540
        public void get_RefCount(){} // RVA: 0x7FFE8119C0A0
        public void AddRef(){} // RVA: 0x7FFE8726F6F0
        public void RemoveRef(){} // RVA: 0x7FFE8726F8F0
        public void ApplyChangeAction(){} // RVA: 0x7FFE8726FAB0
        public void CheckUnique(){} // RVA: 0x7FFE8726FB50
        public void CompareRecords(){} // RVA: 0x7FFE8726FBA0
        public void CompareDataRows(){} // RVA: 0x7FFE8726FDD0
        public void CompareDuplicateRecords(){} // RVA: 0x7FFE8726FE50
        public void CompareRecordToKey(){} // RVA: 0x7FFE8726FFE0
        public void DeleteRecordFromIndex(){} // RVA: 0x7FFE872700E0
        public void DeleteRecord(){} // RVA: 0x7FFE87270100 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE87270210
        public void GetIndex(){} // RVA: 0x7FFE872702D0 | overloaded x2
        public void GetUniqueKeyValues(){} // RVA: 0x7FFE87272A80 | overloaded x2
        public void FindNodeByKey(){} // RVA: 0x7FFE872705D0
        public void FindNodeByKeys(){} // RVA: 0x7FFE872708A0
        public void FindNodeByKeyRecord(){} // RVA: 0x7FFE87270C50
        public void GetRangeFromNode(){} // RVA: 0x7FFE87270D70
        public void FindRecords(){} // RVA: 0x7FFE87270F80 | overloaded x2
        public void FireResetEvent(){} // RVA: 0x7FFE87270FD0
        public void GetChangeAction(){} // RVA: 0x7FFE872710C0
        public void GetReplaceAction(){} // RVA: 0x7FFE872710E0
        public void GetRow(){} // RVA: 0x7FFE87271100
        public void GetRows(){} // RVA: 0x7FFE872711A0 | overloaded x2
        public void InitRecords(){} // RVA: 0x7FFE872713C0
        public void InsertRecordToIndex(){} // RVA: 0x7FFE87271800
        public void InsertRecord(){} // RVA: 0x7FFE87271860
        public void IsKeyInIndex(){} // RVA: 0x7FFE87271AB0 | overloaded x2
        public void IsKeyRecordInIndex(){} // RVA: 0x7FFE87271AD0
        public void get_DoListChanged(){} // RVA: 0x7FFE87271BF0
        public void OnListChanged(){} // RVA: 0x7FFE87271DA0 | overloaded x3
        public void MaintainDataView(){} // RVA: 0x7FFE87271FA0
        public void Reset(){} // RVA: 0x7FFE872720E0
        public void RecordChanged(){} // RVA: 0x7FFE872722A0 | overloaded x2
        public void RecordStateChanged(){} // RVA: 0x7FFE872725A0 | overloaded x2
        public void get_Table(){} // RVA: 0x7FFE81116380
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420
    }

    public class IndexField : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE819409B0
        public void op_Equality(){} // RVA: 0x7FFE8726E590
        public void Equals(){} // RVA: 0x7FFE8726E5B0
        public void GetHashCode(){} // RVA: 0x7FFE8726E640
    }

    public class InternalDataCollectionBase : Object
    {
        public System.ComponentModel.CollectionChangeEventArgs s_refreshEventArgs;
        public object field_1; // 0x77
        public object field_2; // 0x78
        public object field_3; // 0x79

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE87229DA0
        public void CopyTo(){} // RVA: 0x7FFE87229DE0
        public void GetEnumerator(){} // RVA: 0x7FFE87229E40
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void NamesEqual(){} // RVA: 0x7FFE87229E80
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void get_List(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8722A030
    }

    public class InvalidConstraintException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B5A0 | overloaded x3
    }

    public class InvalidExpressionException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B370 | overloaded x3
    }

}