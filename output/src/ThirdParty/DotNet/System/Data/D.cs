// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 41
// Methods: 1066

namespace ThirdParty.DotNet.System.Data
{
    public class DataColumn
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66C31D0 | overloaded x3
        public void UpdateColumnType(){} // RVA: 0x66C36A0
        public void get_AllowDBNull(){} // RVA: 0x3CB9D0
        public void set_AllowDBNull(){} // RVA: 0x66C3960
        public void get_AutoIncrement(){} // RVA: 0x66C3A80
        public void set_AutoIncrement(){} // RVA: 0x66C3AA0
        public void get_AutoIncrementCurrent(){} // RVA: 0x66C3C90
        public void set_AutoIncrementCurrent(){} // RVA: 0x66C3D00
        public void get_AutoInc(){} // RVA: 0x66C3E70
        public void get_AutoIncrementSeed(){} // RVA: 0x66C3FB0
        public void set_AutoIncrementSeed(){} // RVA: 0x66C3FE0
        public void get_AutoIncrementStep(){} // RVA: 0x66C40D0
        public void set_AutoIncrementStep(){} // RVA: 0x66C4100
        public void get_Caption(){} // RVA: 0x66C41F0
        public void set_Caption(){} // RVA: 0x66C4210
        public void get_ColumnName(){} // RVA: 0x6374D0
        public void set_ColumnName(){} // RVA: 0x66C4370
        public void get_EncodedColumnName(){} // RVA: 0x66C4890
        public void get_FormatProvider(){} // RVA: 0x66C4990
        public void get_Locale(){} // RVA: 0x66C4A30
        public void get_ObjectID(){} // RVA: 0x1C91A50
        public void get_Prefix(){} // RVA: 0x348120
        public void set_Prefix(){} // RVA: 0x66C4AD0
        public void GetColumnValueAsString(){} // RVA: 0x66C4D20
        public void get_Computed(){} // RVA: 0x51563D0
        public void get_DataExpression(){} // RVA: 0x3A5500
        public void get_DataType(){} // RVA: 0x4976A0
        public void set_DataType(){} // RVA: 0x66C4E10
        public void get_DateTimeMode(){} // RVA: 0x59C540
        public void set_DateTimeMode(){} // RVA: 0x66C57A0
        public void get_DefaultValue(){} // RVA: 0x66C5920
        public void set_DefaultValue(){} // RVA: 0x66C5B00
        public void get_DefaultValueIsNull(){} // RVA: 0x66C5E40
        public void BindExpression(){} // RVA: 0x66C5E50
        public void get_Expression(){} // RVA: 0x66C5E80
        public void set_Expression(){} // RVA: 0x66C5F00
        public void get_ExtendedProperties(){} // RVA: 0x66C66D0
        public void get_HasData(){} // RVA: 0x66C67A0
        public void get_ImplementsINullable(){} // RVA: 0x1BE2CF0
        public void get_ImplementsIChangeTracking(){} // RVA: 0x1491AA0
        public void get_ImplementsIRevertibleChangeTracking(){} // RVA: 0x66C67B0
        public void get_IsValueType(){} // RVA: 0x66C67C0
        public void get_IsSqlType(){} // RVA: 0x134A670
        public void SetMaxLengthSimpleType(){} // RVA: 0x66C67E0
        public void get_MaxLength(){} // RVA: 0x59CEC0
        public void set_MaxLength(){} // RVA: 0x66C6970
        public void get_Namespace(){} // RVA: 0x66C6D70
        public void set_Namespace(){} // RVA: 0x66C6DF0
        public void get_Ordinal(){} // RVA: 0x59C4F0
        public void SetOrdinalInternal(){} // RVA: 0x66C6FC0
        public void get_ReadOnly(){} // RVA: 0x3A5570
        public void set_ReadOnly(){} // RVA: 0x66C7100
        public void get_SortIndex(){} // RVA: 0x66C71D0
        public void get_Table(){} // RVA: 0x4C7C50
        public void SetTable(){} // RVA: 0x66C7390
        public void GetDataRow(){} // RVA: 0x66C7510
        public void get_Item(){} // RVA: 0x66C7550
        public void set_Item(){} // RVA: 0x66C7580
        public void InitializeRecord(){} // RVA: 0x66C7730
        public void SetValue(){} // RVA: 0x66C7780
        public void FreeRecord(){} // RVA: 0x66C78D0
        public void get_Unique(){} // RVA: 0x5A8B10
        public void set_Unique(){} // RVA: 0x66C7910
        public void InternalUnique(){} // RVA: 0x5A6190
        public void get_XmlDataType(){} // RVA: 0x35E900
        public void set_XmlDataType(){} // RVA: 0x35E910
        public void get_SimpleType(){} // RVA: 0x3FA100
        public void set_SimpleType(){} // RVA: 0x66C7CD0
        public void get_ColumnMapping(){} // RVA: 0x1C5A600
        public void set_ColumnMapping(){} // RVA: 0x66C7E50
        public void CheckColumnConstraint(){} // RVA: 0x66C8240
        public void CheckMaxLength(){} // RVA: 0x66C8650 | overloaded x2
        public void CheckNotAllowNull(){} // RVA: 0x66C8710
        public void CheckNullable(){} // RVA: 0x66C8A60
        public void CheckUnique(){} // RVA: 0x66C8B20
        public void Compare(){} // RVA: 0x66C8BB0
        public void CompareValueTo(){} // RVA: 0x66C8E00 | overloaded x2
        public void ConvertValue(){} // RVA: 0x66C8E30
        public void Copy(){} // RVA: 0x66C8E60
        public void Clone(){} // RVA: 0x66C8E90
        public void GetAggregateValue(){} // RVA: 0x66C9610
        public void GetStringLength(){} // RVA: 0x66C9790
        public void Init(){} // RVA: 0x66C97C0
        public void IsAutoIncrementType(){} // RVA: 0x66C9890
        public void get_IsCustomType(){} // RVA: 0x66C9B60
        public void IsValueCustomTypeInstance(){} // RVA: 0x66C9BD0
        public void get_ImplementsIXMLSerializable(){} // RVA: 0x632C3D0
        public void IsInRelation(){} // RVA: 0x66C9D00
        public void IsMaxLengthViolated(){} // RVA: 0x66C9E90
        public void IsNotAllowDBNullViolated(){} // RVA: 0x66CA2B0
        public void FinishInitInProgress(){} // RVA: 0x66CA430
        public void OnPropertyChanging(){} // RVA: 0x66CA450
        public void RaisePropertyChanging(){} // RVA: 0x66CA480
        public void InsureStorage(){} // RVA: 0x66CA500
        public void SetCapacity(){} // RVA: 0x66CA5E0
        public void OnSetDataSet(){} // RVA: 0x2DD310
        public void ToString(){} // RVA: 0x66CA630
        public void ConvertXmlToObject(){} // RVA: 0x66CA6F0 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x66CA7A0 | overloaded x2
        public void GetEmptyColumnStore(){} // RVA: 0x66CA810
        public void CopyValueIntoStore(){} // RVA: 0x66CA860
        public void SetStorage(){} // RVA: 0x66CA8A0
        public void AddDependentColumn(){} // RVA: 0x66CA900
        public void RemoveDependentColumn(){} // RVA: 0x66CAA10
        public void HandleDependentColumnList(){} // RVA: 0x66CAAB0
    }

    public class DataColumnChangeEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F2780 | overloaded x2
        public void get_ProposedValue(){} // RVA: 0x30B0C0
        public void set_ProposedValue(){} // RVA: 0x30B0D0
        public void InitializeColumnChangeEvent(){} // RVA: 0x6458F80
    }

    public class DataColumnChangeEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class DataColumnCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F28E0
        public void get_List(){} // RVA: 0x2E07C0
        public void get_ColumnsImplementingIChangeTracking(){} // RVA: 0x35A740
        public void get_ColumnsImplementingIChangeTrackingCount(){} // RVA: 0x37E0C0
        public void get_ColumnsImplementingIRevertibleChangeTrackingCount(){} // RVA: 0x1479960
        public void get_Item(){} // RVA: 0x66F2DB0 | overloaded x3
        public void Add(){} // RVA: 0x66F2E90
        public void AddAt(){} // RVA: 0x66F2EA0
        public void add_CollectionChanged(){} // RVA: 0x66F3200
        public void remove_CollectionChanged(){} // RVA: 0x66F32F0
        public void add_ColumnPropertyChanged(){} // RVA: 0x66F33E0
        public void remove_ColumnPropertyChanged(){} // RVA: 0x66F34D0
        public void ArrayAdd(){} // RVA: 0x66F3660 | overloaded x2
        public void ArrayRemove(){} // RVA: 0x66F36D0
        public void AssignName(){} // RVA: 0x66F39F0
        public void BaseAdd(){} // RVA: 0x66F3AA0
        public void BaseGroupSwitch(){} // RVA: 0x66F3E90
        public void BaseRemove(){} // RVA: 0x66F4160
        public void CanRemove(){} // RVA: 0x66F4360
        public void CheckIChangeTracking(){} // RVA: 0x66F4CF0
        public void Clear(){} // RVA: 0x66F4D40
        public void Contains(){} // RVA: 0x66F5310 | overloaded x2
        public void IndexOf(){} // RVA: 0x66F53D0
        public void IndexOfCaseInsensitive(){} // RVA: 0x66F54E0
        public void FinishInitCollection(){} // RVA: 0x66F5690
        public void MakeName(){} // RVA: 0x66F57A0
        public void OnCollectionChanged(){} // RVA: 0x66F5850
        public void OnCollectionChanging(){} // RVA: 0x66F5950
        public void OnColumnPropertyChanged(){} // RVA: 0x66F5970
        public void RegisterColumnName(){} // RVA: 0x66F5A10
        public void CanRegisterName(){} // RVA: 0x66F5C60
        public void Remove(){} // RVA: 0x66F5CD0
        public void UnregisterName(){} // RVA: 0x66F5E10
        public void AddColumnsImplementingIChangeTrackingList(){} // RVA: 0x66F5F60
        public void RemoveColumnsImplementingIChangeTrackingList(){} // RVA: 0x66F6080
    }

    public class DataColumnPropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F61E0
        public void get_Attributes(){} // RVA: 0x66F6270
        public void get_Column(){} // RVA: 0x31C010
        public void get_ComponentType(){} // RVA: 0x66F64C0
        public void get_IsReadOnly(){} // RVA: 0x66F6570
        public void get_PropertyType(){} // RVA: 0x66F6590
        public void Equals(){} // RVA: 0x66F65B0
        public void GetHashCode(){} // RVA: 0x66F6650
        public void CanResetValue(){} // RVA: 0x66F6680
        public void GetValue(){} // RVA: 0x66F67C0
        public void ResetValue(){} // RVA: 0x66F6850
        public void SetValue(){} // RVA: 0x66F6920
        public void ShouldSerializeValue(){} // RVA: 0x2DD320
        public void get_IsBrowsable(){} // RVA: 0x66F6A20
    }

    public class DataCommonEventSource
    {
        // ── Methods ──
        public void Trace(){} // RVA: 0x283FA0 | overloaded x7
        public void EnterScope(){} // RVA: 0x283FA0 | overloaded x5
        public void ExitScope(){} // RVA: 0x66ED720
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void .cctor(){} // RVA: 0x66ED7E0
    }

    public class DataError
    {
        public object ColumnsReference;
        public object HasValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F6C30 | overloaded x2
        public void get_Text(){} // RVA: 0x2F8380
        public void set_Text(){} // RVA: 0x66F6D70
        public void get_HasErrors(){} // RVA: 0x66F6E10
        public void SetColumnError(){} // RVA: 0x66F6E40
        public void GetColumnError(){} // RVA: 0x66F7070
        public void Clear(){} // RVA: 0x66F71D0 | overloaded x2
        public void GetColumnsInError(){} // RVA: 0x66F72C0
        public void SetText(){} // RVA: 0x66F6D70
        public void IndexOf(){} // RVA: 0x66F73F0
    }

    public class DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E250 | overloaded x4
    }

    public class DataExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x671C8A0 | overloaded x2
        public void get_Expression(){} // RVA: 0x671CCC0
        public void get_HasValue(){} // RVA: 0x1E3EC10
        public void Bind(){} // RVA: 0x671CD10
        public void DependsOn(){} // RVA: 0x671CF90
        public void Evaluate(){} // RVA: 0x671CFD0 | overloaded x2
        public void Invoke(){} // RVA: 0x671D1E0
        public void GetDependency(){} // RVA: 0x35A740
        public void IsTableAggregate(){} // RVA: 0x671D290
        public void IsUnknown(){} // RVA: 0x671D2C0
        public void HasLocalAggregate(){} // RVA: 0x671D310
        public void HasRemoteAggregate(){} // RVA: 0x671D340
        public void ToBoolean(){} // RVA: 0x671D370
    }

    public class DataKey
    {
        public object ChildColumns;
        public object ChildColumnsReference;
        public object ChildKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F7580
        public void get_ColumnsReference(){} // RVA: 0x1AD4690
        public void get_HasValue(){} // RVA: 0x1102770
        public void get_Table(){} // RVA: 0x66F7820
        public void CheckState(){} // RVA: 0x66F7850
        public void ColumnsEqual(){} // RVA: 0x66F7A00 | overloaded x2
        public void ContainsColumn(){} // RVA: 0x66F7AB0
        public void GetHashCode(){} // RVA: 0x66F7B00
        public void Equals(){} // RVA: 0x66F7BE0 | overloaded x2
        public void GetColumnNames(){} // RVA: 0x66F7C80
        public void GetIndexDesc(){} // RVA: 0x66F7D90
        public void GetKeyValues(){} // RVA: 0x66F7F30
        public void GetSortIndex(){} // RVA: 0x66F8130 | overloaded x2
        public void RecordsEqual(){} // RVA: 0x66F81A0
        public void ToArray(){} // RVA: 0x66F8250
    }

    public class DataRelation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F8A00 | overloaded x5
        public void get_ChildColumns(){} // RVA: 0x66F8D30
        public void get_ChildColumnsReference(){} // RVA: 0x66F8D50
        public void get_ChildKey(){} // RVA: 0x66F8D50
        public void get_ChildTable(){} // RVA: 0x66F8D70
        public void get_DataSet(){} // RVA: 0x66F8DB0
        public void get_ParentColumnNames(){} // RVA: 0x66F8DD0
        public void get_ChildColumnNames(){} // RVA: 0x66F8DE0
        public void IsKeyNull(){} // RVA: 0x66F8DF0
        public void GetChildRows(){} // RVA: 0x66F8EA0
        public void GetParentRows(){} // RVA: 0x66F8FC0
        public void GetParentRow(){} // RVA: 0x66F90E0
        public void SetDataSet(){} // RVA: 0x66F9270
        public void get_ParentColumns(){} // RVA: 0x66F92D0
        public void get_ParentColumnsReference(){} // RVA: 0x6374D0
        public void get_ParentKey(){} // RVA: 0x66F92F0
        public void get_ParentTable(){} // RVA: 0x66F9310
        public void get_RelationName(){} // RVA: 0x66F9350
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x66F9370
        public void CheckNestedRelations(){} // RVA: 0x66F9650
        public void get_Nested(){} // RVA: 0x66F9B20
        public void set_Nested(){} // RVA: 0x66F9B40
        public void get_ParentKeyConstraint(){} // RVA: 0x66FAB40
        public void SetParentKeyConstraint(){} // RVA: 0x49B830
        public void get_ChildKeyConstraint(){} // RVA: 0x66FAB60
        public void get_ExtendedProperties(){} // RVA: 0x66FAB80
        public void get_CheckMultipleNested(){} // RVA: 0x8A3000
        public void set_CheckMultipleNested(){} // RVA: 0x8A8560
        public void SetChildKeyConstraint(){} // RVA: 0x305200
        public void CheckState(){} // RVA: 0x66FAC40
        public void CheckStateForProperty(){} // RVA: 0x66FAF20
        public void Create(){} // RVA: 0x66FB030
        public void Clone(){} // RVA: 0x66FB3E0
        public void OnPropertyChanging(){} // RVA: 0x66FBB40
        public void RaisePropertyChanging(){} // RVA: 0x66FBC00
        public void ToString(){} // RVA: 0x43E1C0
        public void ValidateMultipleNestedRelations(){} // RVA: 0x66FBD10
        public void IsAutoGenerated(){} // RVA: 0x66FC190
        public void get_ObjectID(){} // RVA: 0x1AE6E60
    }

    public class DataRelationCollection
    {
        // ── Methods ──
        public void get_ObjectID(){} // RVA: 0x338CD0
        public void get_Item(){} // RVA: 0xCE10 | overloaded x2
        public void Add(){} // RVA: 0x66FC400
        public void AddCore(){} // RVA: 0x66FC630
        public void add_CollectionChanged(){} // RVA: 0x66FC930
        public void remove_CollectionChanged(){} // RVA: 0x66FCA90
        public void AssignName(){} // RVA: 0x66FCBF0
        public void Clear(){} // RVA: 0x66FCC10
        public void Contains(){} // RVA: 0x66FCE90
        public void InternalIndexOf(){} // RVA: 0x66FCEB0
        public void GetDataSet(){} // RVA: 0xCD60
        public void MakeName(){} // RVA: 0x66FD070
        public void OnCollectionChanged(){} // RVA: 0x66FD120
        public void OnCollectionChanging(){} // RVA: 0x66FD1E0
        public void RegisterName(){} // RVA: 0x66FD2A0
        public void Remove(){} // RVA: 0x66FD590
        public void RemoveAt(){} // RVA: 0x66FD780
        public void RemoveCore(){} // RVA: 0x66FD810
        public void UnregisterName(){} // RVA: 0x66FD9F0
        public void .ctor(){} // RVA: 0x66FDBA0
    }

    public class DataRelationPropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66FFA50
        public void get_Relation(){} // RVA: 0x31C010
        public void get_ComponentType(){} // RVA: 0x66FFB00
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void get_PropertyType(){} // RVA: 0x66FFBB0
        public void Equals(){} // RVA: 0x66FFC60
        public void GetHashCode(){} // RVA: 0x66F6650
        public void CanResetValue(){} // RVA: 0x2DD320
        public void GetValue(){} // RVA: 0x66FFD00
        public void ResetValue(){} // RVA: 0x2DD310
        public void SetValue(){} // RVA: 0x2DD310
        public void ShouldSerializeValue(){} // RVA: 0x2DD320
    }

    public class DataRow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66FFD90
        public void get_LastChangedColumn(){} // RVA: 0x66FFED0
        public void set_LastChangedColumn(){} // RVA: 0x66FFEE0
        public void get_HasPropertyChanged(){} // RVA: 0x66FFF40
        public void get_RBTreeNodeId(){} // RVA: 0x9EAB90
        public void set_RBTreeNodeId(){} // RVA: 0x66FFF50
        public void get_RowError(){} // RVA: 0x66FFFF0
        public void set_RowError(){} // RVA: 0x6700050
        public void RowErrorChanged(){} // RVA: 0x67003E0
        public void get_rowID(){} // RVA: 0x6374D0
        public void set_rowID(){} // RVA: 0x6700430
        public void get_RowState(){} // RVA: 0x67004A0
        public void get_Table(){} // RVA: 0x2F8380
        public void CheckForLoops(){} // RVA: 0x6700650
        public void GetNestedParentCount(){} // RVA: 0x6700750
        public void set_Item(){} // RVA: 0x6700980 | overloaded x2
        public void get_Item(){} // RVA: 0x6700F10 | overloaded x2
        public void set_ItemArray(){} // RVA: 0x6701000
        public void AcceptChanges(){} // RVA: 0x6701520
        public void BeginEdit(){} // RVA: 0x67018A0
        public void BeginEditInternal(){} // RVA: 0x67018B0
        public void CancelEdit(){} // RVA: 0x6701980
        public void CheckColumn(){} // RVA: 0x6701A40
        public void CheckInTable(){} // RVA: 0x6701B00
        public void Delete(){} // RVA: 0x6701B40
        public void EndEdit(){} // RVA: 0x6701BB0
        public void SetColumnError(){} // RVA: 0x6701D90 | overloaded x2
        public void GetColumnError(){} // RVA: 0x67020C0 | overloaded x2
        public void ClearErrors(){} // RVA: 0x67022C0
        public void ClearError(){} // RVA: 0x6702400
        public void get_HasErrors(){} // RVA: 0x6702500
        public void GetColumnsInError(){} // RVA: 0x6702540
        public void GetChildRows(){} // RVA: 0x67026F0 | overloaded x2
        public void GetDataColumn(){} // RVA: 0x6702860
        public void GetParentRow(){} // RVA: 0x67028F0 | overloaded x2
        public void GetNestedParentRow(){} // RVA: 0x6702A70
        public void GetParentRows(){} // RVA: 0x6702B50 | overloaded x2
        public void GetColumnValues(){} // RVA: 0x6702DD0 | overloaded x2
        public void GetKeyValues(){} // RVA: 0x6702EB0 | overloaded x2
        public void GetCurrentRecordNo(){} // RVA: 0x6702EE0
        public void GetDefaultRecord(){} // RVA: 0x6702F20
        public void GetOriginalRecordNo(){} // RVA: 0x6702F80
        public void GetProposedRecordNo(){} // RVA: 0x6702FC0
        public void GetRecordFromVersion(){} // RVA: 0x6703000
        public void GetDefaultRowVersion(){} // RVA: 0x67030F0
        public void GetRecordState(){} // RVA: 0x6703120
        public void HasKeyChanged(){} // RVA: 0x67031A0 | overloaded x2
        public void HasVersion(){} // RVA: 0x6703230
        public void HaveValuesChanged(){} // RVA: 0x67032F0 | overloaded x2
        public void RejectChanges(){} // RVA: 0x6703470
        public void ResetLastChangedColumn(){} // RVA: 0x6703910
        public void SetKeyValues(){} // RVA: 0x6703970
        public void SetNestedParentRow(){} // RVA: 0x6703A90
        public void SetParentRowToDBNull(){} // RVA: 0x6704030 | overloaded x2
        public void CopyValuesIntoStore(){} // RVA: 0x67041F0
    }

    public class DataRowBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
    }

    public class DataRowChangeEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67045E0
    }

    public class DataRowChangeEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class DataRowCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67046A0
        public void get_Count(){} // RVA: 0x6704810
        public void get_Item(){} // RVA: 0x6704860
        public void Add(){} // RVA: 0x67048B0
        public void DiffInsertAt(){} // RVA: 0x67048F0
        public void IndexOf(){} // RVA: 0x6704C30
        public void AddWithColumnEvents(){} // RVA: 0x6704CC0
        public void ArrayAdd(){} // RVA: 0x6704D50
        public void ArrayInsert(){} // RVA: 0x6704DC0
        public void ArrayClear(){} // RVA: 0x6704EB0
        public void ArrayRemove(){} // RVA: 0x6704F10
        public void CopyTo(){} // RVA: 0x6705170 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x67051E0
    }

    public class DataRowCreatedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class DataRowView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x2878D00
        public void GetHashCode(){} // RVA: 0x1DE6980
        public void get_DataView(){} // RVA: 0x2F8380
        public void System.ComponentModel.IDataErrorInfo.get_Item(){} // RVA: 0x67053A0
        public void System.ComponentModel.IDataErrorInfo.get_Error(){} // RVA: 0x67053E0
        public void get_RowVersionDefault(){} // RVA: 0x6705450
        public void GetRecord(){} // RVA: 0x67054B0
        public void HasRecord(){} // RVA: 0x6705530
        public void GetColumnValue(){} // RVA: 0x67055B0
        public void SetColumnValue(){} // RVA: 0x6705630
        public void CreateChildView(){} // RVA: 0x67058D0 | overloaded x2
        public void get_Row(){} // RVA: 0x2E07C0
        public void BeginEdit(){} // RVA: 0x1282B00
        public void CancelEdit(){} // RVA: 0x67058E0
        public void EndEdit(){} // RVA: 0x6705940
        public void get_IsNew(){} // RVA: 0x67059A0
        public void add_PropertyChanged(){} // RVA: 0x67059D0
        public void remove_PropertyChanged(){} // RVA: 0x6705AC0
        public void RaisePropertyChangedEvent(){} // RVA: 0x6705BB0
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x6705C40
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x6705CE0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x6705D70 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x1A3F520
        public void .cctor(){} // RVA: 0x6705E10
    }

    public class DataSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66D3110 | overloaded x4
        public void get_RemotingFormat(){} // RVA: 0x1AE3800
        public void set_RemotingFormat(){} // RVA: 0x66D2FC0
        public void get_SchemaSerializationMode(){} // RVA: 0x3CFAF0
        public void GetObjectData(){} // RVA: 0x66D3470
        public void InitializeDerivedDataSet(){} // RVA: 0x2DD310
        public void SerializeDataSet(){} // RVA: 0x66D34A0
        public void DeserializeDataSet(){} // RVA: 0x66D4170
        public void DeserializeDataSetSchema(){} // RVA: 0x66D41F0
        public void DeserializeDataSetData(){} // RVA: 0x66D4970
        public void SerializeDataSetProperties(){} // RVA: 0x66D4B60
        public void DeserializeDataSetProperties(){} // RVA: 0x66D5410
        public void SerializeRelations(){} // RVA: 0x66D5900
        public void DeserializeRelations(){} // RVA: 0x66D5EA0
        public void FailedEnableConstraints(){} // RVA: 0x66D6600
        public void get_CaseSensitive(){} // RVA: 0x4FE4B90
        public void set_CaseSensitive(){} // RVA: 0x66D6640
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x3C2850
        public void get_DefaultViewManager(){} // RVA: 0x66D68F0
        public void get_EnforceConstraints(){} // RVA: 0x59FF30
        public void set_EnforceConstraints(){} // RVA: 0x66D6AE0
        public void RestoreEnforceConstraints(){} // RVA: 0xC5F680
        public void EnableConstraints(){} // RVA: 0x66D6BD0
        public void get_DataSetName(){} // RVA: 0x35A740
        public void set_DataSetName(){} // RVA: 0x66D7160
        public void get_Namespace(){} // RVA: 0x37E0E0
        public void set_Namespace(){} // RVA: 0x66D72F0
        public void get_Prefix(){} // RVA: 0x358730
        public void set_Prefix(){} // RVA: 0x66D7730
        public void get_ExtendedProperties(){} // RVA: 0x66D7970
        public void get_IsInitialized(){} // RVA: 0x66D7A30
        public void get_Locale(){} // RVA: 0x37B370
        public void set_Locale(){} // RVA: 0x66D7A40
        public void SetLocaleValue(){} // RVA: 0x66D7B60
        public void ShouldSerializeLocale(){} // RVA: 0x3A5570
        public void get_Site(){} // RVA: 0x2F8380
        public void set_Site(){} // RVA: 0x66D8790
        public void get_Relations(){} // RVA: 0x6374D0
        public void get_Tables(){} // RVA: 0x30B130
        public void add_Initialized(){} // RVA: 0x66D8940
        public void remove_Initialized(){} // RVA: 0x66D8A30
        public void BeginInit(){} // RVA: 0x66D8B20
        public void EndInit(){} // RVA: 0x66D8B30
        public void Clear(){} // RVA: 0x66D8DB0
        public void Clone(){} // RVA: 0x66D8F30
        public void EstimatedXmlStringSize(){} // RVA: 0x66D9EB0
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x66DA010
        public void GetRemotingDiffGram(){} // RVA: 0x66DA020
        public void GetXmlSchemaForRemoting(){} // RVA: 0x66DA1B0
        public void ReadXmlSchema(){} // RVA: 0x66DA3D0 | overloaded x2
        public void MoveToElement(){} // RVA: 0x66DB020 | overloaded x2
        public void ReadEndElement(){} // RVA: 0x66BE0C0
        public void ReadXSDSchema(){} // RVA: 0x66DB0B0
        public void ReadXDRSchema(){} // RVA: 0x66DB480
        public void WriteXmlSchema(){} // RVA: 0x66DB770
        public void ReadXml(){} // RVA: 0x66DE790 | overloaded x4
        public void InferSchema(){} // RVA: 0x66DCFA0
        public void IsEmpty(){} // RVA: 0x66DD2C0
        public void ReadXmlDiffgram(){} // RVA: 0x66DD4B0
        public void WriteXml(){} // RVA: 0x66DF9D0
        public void Merge(){} // RVA: 0x66DFC90 | overloaded x2
        public void OnPropertyChanging(){} // RVA: 0x66DFE90
        public void OnMergeFailed(){} // RVA: 0x66DFEC0
        public void RaiseMergeFailed(){} // RVA: 0x66DFF40
        public void OnDataRowCreated(){} // RVA: 0x66E0120
        public void OnClearFunctionCalled(){} // RVA: 0x66E0150
        public void OnInitialized(){} // RVA: 0x66E0180
        public void OnRemoveTable(){} // RVA: 0x2DD310
        public void OnRemovedTable(){} // RVA: 0x66E0200
        public void OnRemoveRelation(){} // RVA: 0x2DD310
        public void OnRemoveRelationHack(){} // RVA: 0x65E6140
        public void RaisePropertyChanging(){} // RVA: 0x66E0250
        public void TopLevelTables(){} // RVA: 0x66E02E0 | overloaded x2
        public void Reset(){} // RVA: 0x66E0520
        public void ValidateCaseConstraint(){} // RVA: 0x66E0760
        public void ValidateLocaleConstraint(){} // RVA: 0x66E0B00
        public void FindTable(){} // RVA: 0x66E0F30
        public void ReadXmlSerializable(){} // RVA: 0x66E10B0
        public void GetDataSetSchema(){} // RVA: 0x66E1740
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x66E1C10
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x66E1E50
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x66E1FD0
        public void get_MainTableName(){} // RVA: 0x3A5590
        public void set_MainTableName(){} // RVA: 0x3A55A0
        public void get_ObjectID(){} // RVA: 0xBB90C0
    }

    public class DataSetClearEventhandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class DataTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66A1F30 | overloaded x3
        public void GetObjectData(){} // RVA: 0x66A2180
        public void SerializeDataTable(){} // RVA: 0x66A2270
        public void DeserializeDataTable(){} // RVA: 0x66A28E0
        public void SerializeTableSchema(){} // RVA: 0x66A2C70
        public void DeserializeTableSchema(){} // RVA: 0x66A5970
        public void SerializeConstraints(){} // RVA: 0x66A7740
        public void DeserializeConstraints(){} // RVA: 0x66A7F50
        public void SerializeExpressionColumns(){} // RVA: 0x66A8BB0
        public void DeserializeExpressionColumns(){} // RVA: 0x66A8FF0
        public void SerializeTableData(){} // RVA: 0x66A9210
        public void DeserializeTableData(){} // RVA: 0x66AA330
        public void ConvertToRowState(){} // RVA: 0x66AB2A0
        public void GetRowAndColumnErrors(){} // RVA: 0x66AB380
        public void ConvertToRowError(){} // RVA: 0x66AB750
        public void get_CaseSensitive(){} // RVA: 0x152E150
        public void set_CaseSensitive(){} // RVA: 0x66ABAF0
        public void get_AreIndexEventsSuspended(){} // RVA: 0x66ABBB0
        public void RestoreIndexEvents(){} // RVA: 0x66ABBC0
        public void SuspendIndexEvents(){} // RVA: 0x66ABF60
        public void get_IsInitialized(){} // RVA: 0x66ABFF0
        public void get_IsTypedDataTable(){} // RVA: 0x66AC000
        public void SetCaseSensitiveValue(){} // RVA: 0x66AC0B0
        public void ShouldSerializeCaseSensitive(){} // RVA: 0x66AC3A0
        public void get_SelfNested(){} // RVA: 0x66AC3B0
        public void get_LiveIndexes(){} // RVA: 0x66AC5C0
        public void get_RemotingFormat(){} // RVA: 0x66AC680
        public void set_RemotingFormat(){} // RVA: 0x66AC690
        public void get_UKColumnPositionForInference(){} // RVA: 0x63A8330
        public void set_UKColumnPositionForInference(){} // RVA: 0x63A8340
        public void get_ChildRelations(){} // RVA: 0x66AC710
        public void get_Columns(){} // RVA: 0x35A740
        public void get_CompareInfo(){} // RVA: 0x66AC7C0
        public void get_Constraints(){} // RVA: 0x358730
        public void ResetConstraints(){} // RVA: 0x66AC860
        public void get_DataSet(){} // RVA: 0x30B0C0
        public void SetDataSet(){} // RVA: 0x66AC880
        public void get_DefaultView(){} // RVA: 0x66AC9F0
        public void get_DisplayExpressionInternal(){} // RVA: 0x66ACBC0
        public void get_EnforceConstraints(){} // RVA: 0x66ACC60
        public void set_EnforceConstraints(){} // RVA: 0x66ACC90
        public void get_SuspendEnforceConstraints(){} // RVA: 0x66ACCD0
        public void set_SuspendEnforceConstraints(){} // RVA: 0x66ACCE0
        public void EnableConstraints(){} // RVA: 0x66ACCF0
        public void get_ExtendedProperties(){} // RVA: 0x66AD270
        public void get_FormatProvider(){} // RVA: 0x66AD340
        public void get_Locale(){} // RVA: 0x3480B0
        public void set_Locale(){} // RVA: 0x66AD430
        public void SetLocaleValue(){} // RVA: 0x66AD9C0
        public void ShouldSerializeLocale(){} // RVA: 0x2FE4C0
        public void get_MinimumCapacity(){} // RVA: 0x66AE080
        public void set_MinimumCapacity(){} // RVA: 0x66AE0A0
        public void get_RecordCapacity(){} // RVA: 0x66AE0F0
        public void get_ElementColumnCount(){} // RVA: 0x59C540
        public void set_ElementColumnCount(){} // RVA: 0x66AE110
        public void get_ParentRelations(){} // RVA: 0x66AE160
        public void get_MergingData(){} // RVA: 0x63A7830
        public void set_MergingData(){} // RVA: 0x63A7840
        public void get_NestedParentRelations(){} // RVA: 0xD83B50
        public void get_SchemaLoading(){} // RVA: 0x87C180
        public void CacheNestedParent(){} // RVA: 0x66AE210
        public void FindNestedParentRelations(){} // RVA: 0x66AE280
        public void get_NestedParentsCount(){} // RVA: 0x66AE5D0
        public void get_PrimaryKey(){} // RVA: 0x66AE840
        public void set_PrimaryKey(){} // RVA: 0x66AE8B0
        public void get_Rows(){} // RVA: 0x4976A0
        public void get_TableName(){} // RVA: 0x796DE0
        public void set_TableName(){} // RVA: 0x66AEE70
        public void get_EncodedTableName(){} // RVA: 0x66AF630
        public void GetInheritedNamespace(){} // RVA: 0x66AF740
        public void get_Namespace(){} // RVA: 0x66AF9C0
        public void set_Namespace(){} // RVA: 0x66AFA50
        public void IsNamespaceInherited(){} // RVA: 0x66AFD10
        public void CheckCascadingNamespaceConflict(){} // RVA: 0x66AFD20
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x66B0020
        public void CheckNamespaceValidityForNestedParentRelations(){} // RVA: 0x66B0380
        public void DoRaiseNamespaceChange(){} // RVA: 0x66B0630
        public void BeginInit(){} // RVA: 0x66B0B70
        public void EndInit(){} // RVA: 0x66B0B80
        public void get_Prefix(){} // RVA: 0xA085E0
        public void set_Prefix(){} // RVA: 0x66B1130
        public void get_XmlText(){} // RVA: 0x7F7DB0
        public void set_XmlText(){} // RVA: 0x66B1380
        public void get_MaxOccurs(){} // RVA: 0x66B15D0
        public void set_MaxOccurs(){} // RVA: 0x66B15E0
        public void get_MinOccurs(){} // RVA: 0x629CB70
        public void set_MinOccurs(){} // RVA: 0x629CB80
        public void SetKeyValues(){} // RVA: 0x66B15F0
        public void FindByIndex(){} // RVA: 0x66B1670
        public void FindMergeTarget(){} // RVA: 0x66B1710
        public void SetMergeRecords(){} // RVA: 0x66B17E0
        public void MergeRow(){} // RVA: 0x66B1920
        public void CreateInstance(){} // RVA: 0x66B2160
        public void Clone(){} // RVA: 0x66B2200 | overloaded x2
        public void IncrementalCloneTo(){} // RVA: 0x66B2380
        public void CloneHierarchy(){} // RVA: 0x66B2640
        public void CloneTo(){} // RVA: 0x66B2AA0
        public void add_Initialized(){} // RVA: 0x66B3BF0
        public void remove_Initialized(){} // RVA: 0x66B3CF0
        public void get_Site(){} // RVA: 0x2F8380
        public void set_Site(){} // RVA: 0x66B3DF0
        public void AddRow(){} // RVA: 0x66B3FA0
        public void InsertRow(){} // RVA: 0x66B5AD0 | overloaded x3
        public void CheckNotModifying(){} // RVA: 0x66B4410
        public void Clear(){} // RVA: 0x66B4450 | overloaded x2
        public void CascadeAll(){} // RVA: 0x66B4E50
        public void CommitRow(){} // RVA: 0x66B4F80
        public void Compare(){} // RVA: 0x66B5100 | overloaded x2
        public void IndexOf(){} // RVA: 0x66B5280
        public void IsSuffix(){} // RVA: 0x66B52F0
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x2DD320
        public void DeleteRow(){} // RVA: 0x66B5360
        public void FormatSortString(){} // RVA: 0x66B5410
        public void FreeRecord(){} // RVA: 0x66B5560
        public void GetIndex(){} // RVA: 0x66B55D0 | overloaded x2
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x66B58E0
        public void GetListeners(){} // RVA: 0xD971B0
        public void GetSpecialHashCode(){} // RVA: 0x66B58F0
        public void NewRecord(){} // RVA: 0x66B5F90 | overloaded x2
        public void NewUninitializedRecord(){} // RVA: 0x66B5F70
        public void NewEmptyRow(){} // RVA: 0x66B60A0
        public void NewUninitializedRow(){} // RVA: 0x66B6120
        public void NewRow(){} // RVA: 0x66B66B0 | overloaded x2
        public void CreateEmptyRow(){} // RVA: 0x66B6270
        public void NewRowCreated(){} // RVA: 0x66B65B0
        public void NewRowFromBuilder(){} // RVA: 0x66B67A0
        public void GetRowType(){} // RVA: 0x66B6910
        public void NewRowArray(){} // RVA: 0x66B69C0
        public void get_NeedColumnChangeEvents(){} // RVA: 0x66B6B60
        public void OnColumnChanging(){} // RVA: 0x66B6BA0
        public void OnColumnChanged(){} // RVA: 0x66B6C60
        public void OnPropertyChanging(){} // RVA: 0x66B6D20
        public void OnRemoveColumnInternal(){} // RVA: 0x66B6DE0
        public void OnRemoveColumn(){} // RVA: 0x2DD310
        public void OnRowChanged(){} // RVA: 0x66B6F60 | overloaded x2
        public void OnRowChanging(){} // RVA: 0x66B7020 | overloaded x2
        public void OnRowDeleting(){} // RVA: 0x66B70E0
        public void OnRowDeleted(){} // RVA: 0x66B71A0
        public void OnTableCleared(){} // RVA: 0x66B7260
        public void OnTableClearing(){} // RVA: 0x66B7320
        public void OnTableNewRow(){} // RVA: 0x66B73E0
        public void OnInitialized(){} // RVA: 0x66B74A0
        public void ParseSortString(){} // RVA: 0x66B75A0
        public void RaisePropertyChanging(){} // RVA: 0x66B7E40
        public void RecordChanged(){} // RVA: 0x66B7FF0 | overloaded x2
        public void RecordStateChanged(){} // RVA: 0x66B82B0 | overloaded x2
        public void RemoveRecordFromIndexes(){} // RVA: 0x66B8490
        public void InsertRecordToIndexes(){} // RVA: 0x66B8700
        public void SilentlySetValue(){} // RVA: 0x66B8920
        public void RemoveRow(){} // RVA: 0x66B8B70
        public void Reset(){} // RVA: 0x66B8F20
        public void ResetIndexes(){} // RVA: 0x66B91F0
        public void ResetInternalIndexes(){} // RVA: 0x66B9200
        public void RollbackRow(){} // RVA: 0x66B9390
        public void RaiseRowChanged(){} // RVA: 0x66B9430
        public void RaiseRowChanging(){} // RVA: 0x66B9940 | overloaded x2
        public void SetNewRecord(){} // RVA: 0x66B9B00
        public void SetNewRecordWorker(){} // RVA: 0x66B9B80
        public void SetOldRecord(){} // RVA: 0x66BA830
        public void RestoreShadowIndexes(){} // RVA: 0x66BAD50
        public void SetShadowIndexes(){} // RVA: 0x66BADC0
        public void ShadowIndexCopy(){} // RVA: 0x66BAE50
        public void ToString(){} // RVA: 0x66BAF30
        public void UpdatingCurrent(){} // RVA: 0x66BB020
        public void AddUniqueKey(){} // RVA: 0x66BB380 | overloaded x2
        public void AddForeignKey(){} // RVA: 0x66BB390
        public void UpdatePropertyDescriptorCollectionCache(){} // RVA: 0x66BB450
        public void GetPropertyDescriptorCollection(){} // RVA: 0x66BB4B0
        public void get_TypeName(){} // RVA: 0x66BB950
        public void set_TypeName(){} // RVA: 0xDA3F70
        public void Merge(){} // RVA: 0x66BBA20 | overloaded x2
        public void WriteXml(){} // RVA: 0x66BBC20
        public void CheckForClosureOnExpressions(){} // RVA: 0x66BBF90
        public void CheckForClosureOnExpressionTables(){} // RVA: 0x66BC060
        public void WriteXmlSchema(){} // RVA: 0x66BC3F0
        public void RestoreConstraint(){} // RVA: 0x66BC760
        public void IsEmptyXml(){} // RVA: 0x66BC7D0
        public void ReadXml(){} // RVA: 0x66BCAF0
        public void ReadEndElement(){} // RVA: 0x66BE0C0
        public void ReadXDRSchema(){} // RVA: 0x66BE180
        public void MoveToElement(){} // RVA: 0x66BE200
        public void ReadXmlDiffgram(){} // RVA: 0x66BE2E0
        public void ReadXSDSchema(){} // RVA: 0x66BEDE0
        public void ReadXmlSchema(){} // RVA: 0x66BF0B0
        public void CreateTableList(){} // RVA: 0x66C01E0
        public void CreateRelationList(){} // RVA: 0x66C0520
        public void GetDataTableSchema(){} // RVA: 0x66C08A0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x5EBC950
        public void GetSchema(){} // RVA: 0x66C0CA0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x66C0ED0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x66C0FA0
        public void ReadXmlSerializable(){} // RVA: 0x66C0FF0
        public void get_RowDiffId(){} // RVA: 0x66C1010
        public void get_ObjectID(){} // RVA: 0x1A40D00
        public void AddDependentColumn(){} // RVA: 0x66C10D0
        public void RemoveDependentColumn(){} // RVA: 0x66C11F0
        public void EvaluateExpressions(){} // RVA: 0x66C1BD0 | overloaded x3
        public void EvaluateDependentExpressions(){} // RVA: 0x66C2040 | overloaded x2
    }

    public class DataTableClearEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6705ED0
    }

    public class DataTableClearEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class DataTableCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6705F70
        public void get_List(){} // RVA: 0x2E07C0
        public void get_ObjectID(){} // RVA: 0x37E080
        public void get_Item(){} // RVA: 0x6706320 | overloaded x3
        public void GetTable(){} // RVA: 0x6706450
        public void GetTableSmart(){} // RVA: 0x67065E0
        public void Add(){} // RVA: 0x6706790
        public void add_CollectionChanged(){} // RVA: 0x67069A0
        public void remove_CollectionChanged(){} // RVA: 0x6706B00
        public void ArrayAdd(){} // RVA: 0x6706C60
        public void AssignName(){} // RVA: 0x6706C90
        public void BaseAdd(){} // RVA: 0x6706D00
        public void BaseGroupSwitch(){} // RVA: 0x6706EE0
        public void BaseRemove(){} // RVA: 0x6707080
        public void CanRemove(){} // RVA: 0x6707140
        public void Clear(){} // RVA: 0x6707630
        public void Contains(){} // RVA: 0x6707B10 | overloaded x3
        public void IndexOf(){} // RVA: 0x6707E10 | overloaded x3
        public void ReplaceFromInference(){} // RVA: 0x6707EA0
        public void InternalIndexOf(){} // RVA: 0x6708130 | overloaded x2
        public void FinishInitCollection(){} // RVA: 0x6708340
        public void MakeName(){} // RVA: 0x6708400
        public void OnCollectionChanged(){} // RVA: 0x67084B0
        public void OnCollectionChanging(){} // RVA: 0x6708570
        public void RegisterName(){} // RVA: 0x6708630
        public void Remove(){} // RVA: 0x6708A50
        public void UnregisterName(){} // RVA: 0x6708BC0
    }

    public class DataTableNewRowEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6708D50
    }

    public class DataTableNewRowEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class DataTablePropertyDescriptor
    {
        // ── Methods ──
        public void get_Table(){} // RVA: 0x31C010
        public void .ctor(){} // RVA: 0x6708DF0
        public void get_ComponentType(){} // RVA: 0x6708E90
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void get_PropertyType(){} // RVA: 0x6708F40
        public void Equals(){} // RVA: 0x6708FF0
        public void GetHashCode(){} // RVA: 0x66F6650
        public void CanResetValue(){} // RVA: 0x2DD320
        public void GetValue(){} // RVA: 0x6709090
        public void ResetValue(){} // RVA: 0x2DD310
        public void SetValue(){} // RVA: 0x2DD310
        public void ShouldSerializeValue(){} // RVA: 0x2DD320
    }

    public class DataTableTypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6709170
        public void GetPropertiesSupported(){} // RVA: 0x2DD320
    }

    public class DataTextReader
    {
        // ── Methods ──
        public void CreateReader(){} // RVA: 0x6773FD0
        public void .ctor(){} // RVA: 0x67740A0
        public void get_Settings(){} // RVA: 0x7F0250
        public void get_NodeType(){} // RVA: 0x7F02E0
        public void get_Name(){} // RVA: 0x606CEF0
        public void get_LocalName(){} // RVA: 0x7AC2C0
        public void get_NamespaceURI(){} // RVA: 0x5D12EC0
        public void get_Prefix(){} // RVA: 0x5D12EF0
        public void get_Value(){} // RVA: 0x196F280
        public void get_Depth(){} // RVA: 0x65DABF0
        public void get_BaseURI(){} // RVA: 0x7F0310
        public void get_IsEmptyElement(){} // RVA: 0x7F0280
        public void get_IsDefault(){} // RVA: 0x7F0180
        public void get_QuoteChar(){} // RVA: 0x7F02B0
        public void get_XmlSpace(){} // RVA: 0x7F0150
        public void get_XmlLang(){} // RVA: 0x7F0370
        public void get_AttributeCount(){} // RVA: 0x63F6270
        public void GetAttribute(){} // RVA: 0x6774170 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x67741D0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x5D130A0
        public void MoveToNextAttribute(){} // RVA: 0x5E01EC0
        public void MoveToElement(){} // RVA: 0x5E01EF0
        public void ReadAttributeValue(){} // RVA: 0x606C5C0
        public void Read(){} // RVA: 0x6774200
        public void get_EOF(){} // RVA: 0x6774230
        public void Close(){} // RVA: 0x606D0B0
        public void get_ReadState(){} // RVA: 0x6774260
        public void Skip(){} // RVA: 0x5C38BA0
        public void get_NameTable(){} // RVA: 0x606C0F0
        public void LookupNamespace(){} // RVA: 0x6774290
        public void get_CanResolveEntity(){} // RVA: 0x67742C0
        public void ResolveEntity(){} // RVA: 0x67742F0
        public void get_CanReadValueChunk(){} // RVA: 0x5E0CF90
        public void ReadString(){} // RVA: 0x6774320
    }

    public class DataTextWriter
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x6773B20
        public void .ctor(){} // RVA: 0x343E80
        public void get_BaseStream(){} // RVA: 0x6773BB0
        public void WriteStartDocument(){} // RVA: 0x6773C40 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x5E38760
        public void WriteDocType(){} // RVA: 0x6773C70
        public void WriteStartElement(){} // RVA: 0x6773CA0
        public void WriteEndElement(){} // RVA: 0x5CC1E70
        public void WriteFullEndElement(){} // RVA: 0x6773CD0
        public void WriteStartAttribute(){} // RVA: 0x6773D00
        public void WriteEndAttribute(){} // RVA: 0x5CC1EA0
        public void WriteCData(){} // RVA: 0x6773D30
        public void WriteComment(){} // RVA: 0x6773D60
        public void WriteProcessingInstruction(){} // RVA: 0x6773D90
        public void WriteEntityRef(){} // RVA: 0x6773DC0
        public void WriteCharEntity(){} // RVA: 0x6773DF0
        public void WriteWhitespace(){} // RVA: 0x6773E20
        public void WriteString(){} // RVA: 0x6773E50
        public void WriteSurrogateCharEntity(){} // RVA: 0x6773E80
        public void WriteChars(){} // RVA: 0x6773EB0
        public void WriteRaw(){} // RVA: 0x6773F10 | overloaded x2
        public void WriteBase64(){} // RVA: 0x6773F40
        public void WriteBinHex(){} // RVA: 0x6773F70
        public void get_WriteState(){} // RVA: 0x5D8E7E0
        public void Close(){} // RVA: 0x5D8E780
        public void Flush(){} // RVA: 0x5D8E750
        public void LookupPrefix(){} // RVA: 0x6773FA0
    }

    public class DataView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6709780 | overloaded x2
        public void get_AllowDelete(){} // RVA: 0x3A5570
        public void get_AllowEdit(){} // RVA: 0x6709800
        public void get_AllowNew(){} // RVA: 0x6709810
        public void get_Count(){} // RVA: 0x6709820
        public void get_CountFromIndex(){} // RVA: 0x6709870
        public void get_DataViewManager(){} // RVA: 0x30B0C0
        public void get_IsInitialized(){} // RVA: 0x67098A0
        public void get_IsOpen(){} // RVA: 0x67098B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_RowFilter(){} // RVA: 0x67098C0
        public void set_RowFilter(){} // RVA: 0x6709960
        public void get_RowStateFilter(){} // RVA: 0x59CEC0
        public void set_RowStateFilter(){} // RVA: 0x6709C00
        public void get_Sort(){} // RVA: 0x6709D50
        public void set_Sort(){} // RVA: 0x6709EF0
        public void get_SortComparison(){} // RVA: 0x37E0E0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void get_Table(){} // RVA: 0x30B130
        public void set_Table(){} // RVA: 0x670A1F0
        public void System.Collections.IList.get_Item(){} // RVA: 0x670A500
        public void System.Collections.IList.set_Item(){} // RVA: 0x670A570
        public void get_Item(){} // RVA: 0x670A500
        public void AddNew(){} // RVA: 0x670A5A0
        public void BeginInit(){} // RVA: 0x670A910
        public void EndInit(){} // RVA: 0x670A920
        public void CheckOpen(){} // RVA: 0x670AD50
        public void CheckSort(){} // RVA: 0x670AD90
        public void Close(){} // RVA: 0x670ADF0
        public void CopyTo(){} // RVA: 0x670B060 | overloaded x2
        public void Delete(){} // RVA: 0x670B320 | overloaded x2
        public void Dispose(){} // RVA: 0x670B480
        public void FinishAddNew(){} // RVA: 0x670B4F0
        public void GetEnumerator(){} // RVA: 0x670B770
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IList.Add(){} // RVA: 0x670B820
        public void System.Collections.IList.Clear(){} // RVA: 0x670B8B0
        public void System.Collections.IList.Contains(){} // RVA: 0x670B8E0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x670B970
        public void IndexOf(){} // RVA: 0x670BA00
        public void IndexOfDataRowView(){} // RVA: 0x670BB20
        public void System.Collections.IList.Insert(){} // RVA: 0x670BBD0
        public void System.Collections.IList.Remove(){} // RVA: 0x670BC00
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x670B2F0
        public void GetFindIndex(){} // RVA: 0x670BCE0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x6709810
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x57247B0
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x6709800
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x3A5570
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x3C2850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x3C2850
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x3C2850
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x670BF10
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x670BF40
        public void GetSortProperty(){} // RVA: 0x670BFE0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x670C070
        public void add_ListChanged(){} // RVA: 0x670C0B0
        public void remove_ListChanged(){} // RVA: 0x670C210
        public void add_Initialized(){} // RVA: 0x670C370
        public void remove_Initialized(){} // RVA: 0x670C460
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x670C550
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x670C5A0
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x670C5D0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x670C890
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x670C8E0
        public void System.ComponentModel.IBindingListView.ApplySort(){} // RVA: 0x670C9A0
        public void CreateSortString(){} // RVA: 0x670CD80
        public void System.ComponentModel.IBindingListView.RemoveFilter(){} // RVA: 0x670CF00
        public void System.ComponentModel.IBindingListView.get_Filter(){} // RVA: 0x670CFD0
        public void System.ComponentModel.IBindingListView.set_Filter(){} // RVA: 0x670CFF0
        public void System.ComponentModel.IBindingListView.get_SortDescriptions(){} // RVA: 0x670D010
        public void GetSortDescriptions(){} // RVA: 0x670D020
        public void System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting(){} // RVA: 0x3C2850
        public void System.ComponentModel.IBindingListView.get_SupportsFiltering(){} // RVA: 0x3C2850
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x670D3E0
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x670D490
        public void GetFilter(){} // RVA: 0x3A5500
        public void GetRecord(){} // RVA: 0x670D570
        public void GetRow(){} // RVA: 0x670D630
        public void GetRowView(){} // RVA: 0x670D830 | overloaded x2
        public void IndexListChanged(){} // RVA: 0x670D890
        public void IndexListChangedInternal(){} // RVA: 0x670D920
        public void MaintainDataView(){} // RVA: 0x670D9F0
        public void OnListChanged(){} // RVA: 0x670DD10
        public void OnInitialized(){} // RVA: 0x670E0D0
        public void Reset(){} // RVA: 0x670E150
        public void ResetRowViewCache(){} // RVA: 0x670E180
        public void SetDataViewManager(){} // RVA: 0x670E560
        public void SetIndex(){} // RVA: 0x670E7E0
        public void SetIndex2(){} // RVA: 0x670E800
        public void UpdateIndex(){} // RVA: 0x670EBC0 | overloaded x3
        public void ChildRelationCollectionChanged(){} // RVA: 0x670EEE0
        public void ParentRelationCollectionChanged(){} // RVA: 0x670F130
        public void ColumnCollectionChanged(){} // RVA: 0x670F380
        public void ColumnCollectionChangedInternal(){} // RVA: 0x670F630
        public void get_ObjectID(){} // RVA: 0x59E510
        public void .cctor(){} // RVA: 0x670F650
    }

    public class DataViewListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x670F810
        public void ChildRelationCollectionChanged(){} // RVA: 0x670F8F0
        public void ParentRelationCollectionChanged(){} // RVA: 0x670F9E0
        public void ColumnCollectionChanged(){} // RVA: 0x670FAD0
        public void MaintainDataView(){} // RVA: 0x670FBC0
        public void IndexListChanged(){} // RVA: 0x670FCB0
        public void RegisterMetaDataEvents(){} // RVA: 0x670FE40
        public void UnregisterMetaDataEvents(){} // RVA: 0x6710270 | overloaded x2
        public void RegisterListChangedEvent(){} // RVA: 0x67107E0
        public void UnregisterListChangedEvent(){} // RVA: 0x6710A30
        public void CleanUp(){} // RVA: 0x6710BF0
        public void RegisterListener(){} // RVA: 0x6710C10
    }

    public class DataViewManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6710EE0
        public void get_DataSet(){} // RVA: 0x30B130
        public void get_DataViewSettings(){} // RVA: 0x30B0C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x67113D0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x3CFAF0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x3C2850
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x3C2850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6711460
        public void System.Collections.IList.get_Item(){} // RVA: 0x6374D0
        public void System.Collections.IList.set_Item(){} // RVA: 0x6711520
        public void System.Collections.IList.Add(){} // RVA: 0x6711550
        public void System.Collections.IList.Clear(){} // RVA: 0x6711580
        public void System.Collections.IList.Contains(){} // RVA: 0x67115B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x67115C0
        public void System.Collections.IList.Insert(){} // RVA: 0x67115E0
        public void System.Collections.IList.Remove(){} // RVA: 0x6711610
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x6711640
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x2DD320
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x6711670
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x2DD320
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x2DD320
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x3C2850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x2DD320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x2DD320
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x67116C0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x6711710
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x6711760
        public void add_ListChanged(){} // RVA: 0x67117B0
        public void remove_ListChanged(){} // RVA: 0x67118A0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x2DD310
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x6711990
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x67119E0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x2DD310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x6711A30
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x6711A80
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x6711B50
        public void CreateDataView(){} // RVA: 0x6711CB0
        public void OnListChanged(){} // RVA: 0x6711D60
        public void TableCollectionChanged(){} // RVA: 0x6711E50
        public void RelationCollectionChanged(){} // RVA: 0x6712100
        public void .cctor(){} // RVA: 0x6712350
    }

    public class DataViewManagerListItemTypeDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetDataView(){} // RVA: 0x6712440
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x67124C0
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x519240
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x6712560 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x67125F0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x1A3F520
    }

    public class DataViewSetting
    {
        public object Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67128E0
        public void get_ApplyDefaultSort(){} // RVA: 0x313C20
        public void SetDataViewManager(){} // RVA: 0x66F9270
        public void SetDataTable(){} // RVA: 0x67129F0
        public void get_RowFilter(){} // RVA: 0x30B130
        public void get_RowStateFilter(){} // RVA: 0x338CD0
        public void get_Sort(){} // RVA: 0x30B0C0
    }

    public class DataViewSettingCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6712A50
        public void get_Item(){} // RVA: 0x6712BA0
        public void set_Item(){} // RVA: 0x6712DB0
        public void CopyTo(){} // RVA: 0x6712EE0
        public void get_Count(){} // RVA: 0x67130B0
        public void GetEnumerator(){} // RVA: 0x6713100
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void Remove(){} // RVA: 0x6713160
    }

    public class DefaultValueTypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ConvertTo(){} // RVA: 0x6713510
        public void ConvertFrom(){} // RVA: 0x67136B0
    }

    public class DeletedRowInaccessibleException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CC560 | overloaded x3
    }

    public class DuplicateNameException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CC5D0 | overloaded x3
    }

}