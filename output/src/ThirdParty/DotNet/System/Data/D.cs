// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 41
// Methods: 959

namespace ThirdParty.DotNet.System.Data
{
    public class DataColumn : MarshalByValueComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4B14B0
        public void UpdateColumnType(){} // RVA: 0x7AE4B1980
        public void get_AllowDBNull(){} // RVA: 0x7A81C68D0
        public void set_AllowDBNull(){} // RVA: 0x7AE4B1C40
        public void get_AutoIncrement(){} // RVA: 0x7AE4B1D70
        public void set_AutoIncrement(){} // RVA: 0x7AE4B1D90
        public void get_AutoIncrementCurrent(){} // RVA: 0x7AE4B1F80
        public void set_AutoIncrementCurrent(){} // RVA: 0x7AE4B1FF0
        public void get_AutoInc(){} // RVA: 0x7AE4B2160
        public void get_AutoIncrementSeed(){} // RVA: 0x7AE4B22A0
        public void set_AutoIncrementSeed(){} // RVA: 0x7AE4B22D0
        public void get_AutoIncrementStep(){} // RVA: 0x7AE4B23C0
        public void set_AutoIncrementStep(){} // RVA: 0x7AE4B23F0
        public void get_Caption(){} // RVA: 0x7AE4B24E0
        public void set_Caption(){} // RVA: 0x7AE4B2500
        public void get_ColumnName(){} // RVA: 0x7A83F69F0
        public void set_ColumnName(){} // RVA: 0x7AE4B2660
        public void get_EncodedColumnName(){} // RVA: 0x7AE4B2B80
        public void get_FormatProvider(){} // RVA: 0x7AE4B2C80
        public void get_Locale(){} // RVA: 0x7AE4B2D20
        public void get_ObjectID(){} // RVA: 0x7A9A94050
        public void get_Prefix(){} // RVA: 0x7A81426F0
        public void set_Prefix(){} // RVA: 0x7AE4B2DC0
        public void GetColumnValueAsString(){} // RVA: 0x7AE4B3010
        public void get_Computed(){} // RVA: 0x7ACDAC650
        public void get_DataExpression(){} // RVA: 0x7A81A0050
        public void get_DataType(){} // RVA: 0x7A8292C30
        public void set_DataType(){} // RVA: 0x7AE4B3100
        public void get_DateTimeMode(){} // RVA: 0x7A8355950
        public void set_DateTimeMode(){} // RVA: 0x7AE4B3A90
        public void get_DefaultValue(){} // RVA: 0x7AE4B3C10
        public void set_DefaultValue(){} // RVA: 0x7AE4B3DD0
        public void get_DefaultValueIsNull(){} // RVA: 0x7AE4B4110
        public void BindExpression(){} // RVA: 0x7AE4B4120
        public void get_Expression(){} // RVA: 0x7AE4B4150
        public void set_Expression(){} // RVA: 0x7AE4B41D0
        public void get_ExtendedProperties(){} // RVA: 0x7AE4B4980
        public void get_HasData(){} // RVA: 0x7AE4B4A50
        public void get_ImplementsINullable(){} // RVA: 0x7A99A0EA0
        public void get_ImplementsIChangeTracking(){} // RVA: 0x7A924A130
        public void get_ImplementsIRevertibleChangeTracking(){} // RVA: 0x7AE4B4A60
        public void get_IsValueType(){} // RVA: 0x7AE4B4A70
        public void get_IsSqlType(){} // RVA: 0x7A9101D40
        public void SetMaxLengthSimpleType(){} // RVA: 0x7AE4B4A90
        public void get_MaxLength(){} // RVA: 0x7A83562E0
        public void set_MaxLength(){} // RVA: 0x7AE4B4C20
        public void get_Namespace(){} // RVA: 0x7AE4B5030
        public void set_Namespace(){} // RVA: 0x7AE4B50B0
        public void get_Ordinal(){} // RVA: 0x7A8355900
        public void SetOrdinalInternal(){} // RVA: 0x7AE4B5280
        public void get_ReadOnly(){} // RVA: 0x7A81A00C0
        public void set_ReadOnly(){} // RVA: 0x7AE4B53C0
        public void get_SortIndex(){} // RVA: 0x7AE4B5490
        public void get_Table(){} // RVA: 0x7A82C2060
        public void SetTable(){} // RVA: 0x7AE4B5650
        public void GetDataRow(){} // RVA: 0x7AE4B57D0
        public void get_Item(){} // RVA: 0x7AE4B5810
        public void set_Item(){} // RVA: 0x7AE4B5840
        public void InitializeRecord(){} // RVA: 0x7AE4B59F0
        public void SetValue(){} // RVA: 0x7AE4B5A40
        public void FreeRecord(){} // RVA: 0x7AE4B5B90
        public void get_Unique(){} // RVA: 0x7A8361EA0
        public void set_Unique(){} // RVA: 0x7AE4B5BD0
        public void InternalUnique(){} // RVA: 0x7A835F4F0
        public void get_XmlDataType(){} // RVA: 0x7A8158F50
        public void set_XmlDataType(){} // RVA: 0x7A8158F60
        public void get_SimpleType(){} // RVA: 0x7A81F50F0
        public void set_SimpleType(){} // RVA: 0x7AE4B5F60
        public void get_ColumnMapping(){} // RVA: 0x7A9A18C60
        public void set_ColumnMapping(){} // RVA: 0x7AE4B60F0
        public void CheckColumnConstraint(){} // RVA: 0x7AE4B64E0
        public void CheckMaxLength(){} // RVA: 0x7AE4B68E0
        public void CheckNotAllowNull(){} // RVA: 0x7AE4B69A0
        public void CheckNullable(){} // RVA: 0x7AE4B6CE0
        public void CheckUnique(){} // RVA: 0x7AE4B6DA0
        public void Compare(){} // RVA: 0x7AE4B6E30
        public void CompareValueTo(){} // RVA: 0x7AE4B7080
        public void ConvertValue(){} // RVA: 0x7AE4B70B0
        public void Copy(){} // RVA: 0x7AE4B70E0
        public void Clone(){} // RVA: 0x7AE4B7110
        public void GetAggregateValue(){} // RVA: 0x7AE4B7870
        public void GetStringLength(){} // RVA: 0x7AE4B79F0
        public void Init(){} // RVA: 0x7AE4B7A20
        public void IsAutoIncrementType(){} // RVA: 0x7AE4B7AF0
        public void get_IsCustomType(){} // RVA: 0x7AE4B7DC0
        public void IsValueCustomTypeInstance(){} // RVA: 0x7AE4B7E30
        public void get_ImplementsIXMLSerializable(){} // RVA: 0x7AE117EA0
        public void IsInRelation(){} // RVA: 0x7AE4B7F50
        public void IsMaxLengthViolated(){} // RVA: 0x7AE4B80F0
        public void IsNotAllowDBNullViolated(){} // RVA: 0x7AE4B8520
        public void FinishInitInProgress(){} // RVA: 0x7AE4B86A0
        public void OnPropertyChanging(){} // RVA: 0x7AE4B86C0
        public void RaisePropertyChanging(){} // RVA: 0x7AE4B86F0
        public void InsureStorage(){} // RVA: 0x7AE4B8770
        public void SetCapacity(){} // RVA: 0x7AE4B8850
        public void OnSetDataSet(){} // RVA: 0x7A80D7310
        public void ToString(){} // RVA: 0x7AE4B88A0
        public void ConvertXmlToObject(){} // RVA: 0x7AE4B8960
        public void ConvertObjectToXml(){} // RVA: 0x7AE4B8A10
        public void GetEmptyColumnStore(){} // RVA: 0x7AE4B8A80
        public void CopyValueIntoStore(){} // RVA: 0x7AE4B8AD0
        public void SetStorage(){} // RVA: 0x7AE4B8B10
        public void AddDependentColumn(){} // RVA: 0x7AE4B8B70
        public void RemoveDependentColumn(){} // RVA: 0x7AE4B8C80
        public void HandleDependentColumnList(){} // RVA: 0x7AE4B8D20
    }

    public class DataColumnChangeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4E0930
        public void get_ProposedValue(){} // RVA: 0x7A81052C0
        public void set_ProposedValue(){} // RVA: 0x7A81052D0
        public void InitializeColumnChangeEvent(){} // RVA: 0x7AE247030
    }

    public class DataColumnChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DataColumnCollection : InternalDataCollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4E0A90
        public void get_List(){} // RVA: 0x7A80DA7B0
        public void get_ColumnsImplementingIChangeTracking(){} // RVA: 0x7A8154D80
        public void get_ColumnsImplementingIChangeTrackingCount(){} // RVA: 0x7A8178B70
        public void get_ColumnsImplementingIRevertibleChangeTrackingCount(){} // RVA: 0x7A9231EA0
        public void get_Item(){} // RVA: 0x7AE4E0F50
        public void Add(){} // RVA: 0x7AE4E1030
        public void AddAt(){} // RVA: 0x7AE4E1040
        public void add_CollectionChanged(){} // RVA: 0x7AE4E13A0
        public void remove_CollectionChanged(){} // RVA: 0x7AE4E1490
        public void add_ColumnPropertyChanged(){} // RVA: 0x7AE4E1580
        public void remove_ColumnPropertyChanged(){} // RVA: 0x7AE4E1670
        public void ArrayAdd(){} // RVA: 0x7AE4E1800
        public void ArrayRemove(){} // RVA: 0x7AE4E1870
        public void AssignName(){} // RVA: 0x7AE4E1BA0
        public void BaseAdd(){} // RVA: 0x7AE4E1C50
        public void BaseGroupSwitch(){} // RVA: 0x7AE4E2010
        public void BaseRemove(){} // RVA: 0x7AE4E2310
        public void CanRemove(){} // RVA: 0x7AE4E2510
        public void CheckIChangeTracking(){} // RVA: 0x7AE4E2EB0
        public void Clear(){} // RVA: 0x7AE4E2F00
        public void Contains(){} // RVA: 0x7AE4E34C0
        public void IndexOf(){} // RVA: 0x7AE4E3580
        public void IndexOfCaseInsensitive(){} // RVA: 0x7AE4E3690
        public void FinishInitCollection(){} // RVA: 0x7AE4E3840
        public void MakeName(){} // RVA: 0x7AE4E3970
        public void OnCollectionChanged(){} // RVA: 0x7AE4E3A20
        public void OnCollectionChanging(){} // RVA: 0x7AE4E3B20
        public void OnColumnPropertyChanged(){} // RVA: 0x7AE4E3B40
        public void RegisterColumnName(){} // RVA: 0x7AE4E3BE0
        public void CanRegisterName(){} // RVA: 0x7AE4E3E30
        public void Remove(){} // RVA: 0x7AE4E3EA0
        public void UnregisterName(){} // RVA: 0x7AE4E3FE0
        public void AddColumnsImplementingIChangeTrackingList(){} // RVA: 0x7AE4E4130
        public void RemoveColumnsImplementingIChangeTrackingList(){} // RVA: 0x7AE4E4250
    }

    public class DataColumnPropertyDescriptor : PropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4E43C0
        public void get_Attributes(){} // RVA: 0x7AE4E4450
        public void get_Column(){} // RVA: 0x7A81163D0
        public void get_ComponentType(){} // RVA: 0x7AE4E46A0
        public void get_IsReadOnly(){} // RVA: 0x7AE4E4750
        public void get_PropertyType(){} // RVA: 0x7AE4E4770
        public void Equals(){} // RVA: 0x7AE4E4790
        public void GetHashCode(){} // RVA: 0x7AE4E4830
        public void CanResetValue(){} // RVA: 0x7AE4E4860
        public void GetValue(){} // RVA: 0x7AE4E49A0
        public void ResetValue(){} // RVA: 0x7AE4E4A30
        public void SetValue(){} // RVA: 0x7AE4E4B00
        public void ShouldSerializeValue(){} // RVA: 0x7A80D7320
        public void get_IsBrowsable(){} // RVA: 0x7AE4E4C00
    }

    public class DataCommonEventSource : EventSource
    {
        // ── Methods ──
        public void Trace(){} // RVA: 0x7A8051B10
        public void EnterScope(){} // RVA: 0x7A8051B10
        public void ExitScope(){} // RVA: 0x7AE4DB920
        public void .ctor(){} // RVA: 0x7ADBFCE20
        public void .cctor(){} // RVA: 0x7AE4DB9E0
    }

    public class DataError : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4E4E10
        public void get_Text(){} // RVA: 0x7A80F2570
        public void set_Text(){} // RVA: 0x7AE4E4F50
        public void get_HasErrors(){} // RVA: 0x7AE4E4FF0
        public void SetColumnError(){} // RVA: 0x7AE4E5020
        public void GetColumnError(){} // RVA: 0x7AE4E5270
        public void Clear(){} // RVA: 0x7AE4E53D0
        public void GetColumnsInError(){} // RVA: 0x7AE4E54C0
        public void SetText(){} // RVA: 0x7AE4E4F50
        public void IndexOf(){} // RVA: 0x7AE4E5620
    }

    public class DataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F78F0
    }

    public class DataExpression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE50ACD0
        public void get_Expression(){} // RVA: 0x7AE50B0F0
        public void get_HasValue(){} // RVA: 0x7A9C435A0
        public void Bind(){} // RVA: 0x7AE50B140
        public void DependsOn(){} // RVA: 0x7AE50B3C0
        public void Evaluate(){} // RVA: 0x7AE50B400
        public void Invoke(){} // RVA: 0x7AE50B600
        public void GetDependency(){} // RVA: 0x7A8154D80
        public void IsTableAggregate(){} // RVA: 0x7AE50B6B0
        public void IsUnknown(){} // RVA: 0x7AE50B6E0
        public void HasLocalAggregate(){} // RVA: 0x7AE50B730
        public void HasRemoteAggregate(){} // RVA: 0x7AE50B760
        public void ToBoolean(){} // RVA: 0x7AE50B790
    }

    public class DataKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E83570
        public void get_ColumnsReference(){} // RVA: 0x7A765F710
        public void get_HasValue(){} // RVA: 0x7A763CB50
        public void get_Table(){} // RVA: 0x7A7E83580
        public void CheckState(){} // RVA: 0x7A7E835C0
        public void ColumnsEqual(){} // RVA: 0x7AE4E5C60
        public void ContainsColumn(){} // RVA: 0x7A7E835E0
        public void GetHashCode(){} // RVA: 0x7A7E83630
        public void Equals(){} // RVA: 0x7A7E83710
        public void GetColumnNames(){} // RVA: 0x7A7E83720
        public void GetIndexDesc(){} // RVA: 0x7A7E83730
        public void GetKeyValues(){} // RVA: 0x7A7E83740
        public void GetSortIndex(){} // RVA: 0x7A7E837B0
        public void RecordsEqual(){} // RVA: 0x7A7E837C0
        public void ToArray(){} // RVA: 0x7A7E837D0
    }

    public class DataRelation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4E6D20
        public void get_ChildColumns(){} // RVA: 0x7AE4E7050
        public void get_ChildColumnsReference(){} // RVA: 0x7AE4E7070
        public void get_ChildKey(){} // RVA: 0x7AE4E7070
        public void get_ChildTable(){} // RVA: 0x7AE4E7090
        public void get_DataSet(){} // RVA: 0x7AE4E70D0
        public void get_ParentColumnNames(){} // RVA: 0x7AE4E70F0
        public void get_ChildColumnNames(){} // RVA: 0x7AE4E7100
        public void IsKeyNull(){} // RVA: 0x7AE4E7110
        public void GetChildRows(){} // RVA: 0x7AE4E71C0
        public void GetParentRows(){} // RVA: 0x7AE4E72E0
        public void GetParentRow(){} // RVA: 0x7AE4E7400
        public void SetDataSet(){} // RVA: 0x7AE4E7590
        public void get_ParentColumns(){} // RVA: 0x7AE4E75F0
        public void get_ParentColumnsReference(){} // RVA: 0x7A83F69F0
        public void get_ParentKey(){} // RVA: 0x7AE4E7610
        public void get_ParentTable(){} // RVA: 0x7AE4E7630
        public void get_RelationName(){} // RVA: 0x7AE4E7670
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7AE4E7690
        public void CheckNestedRelations(){} // RVA: 0x7AE4E7960
        public void get_Nested(){} // RVA: 0x7AE4E7E50
        public void set_Nested(){} // RVA: 0x7AE4E7E70
        public void get_ParentKeyConstraint(){} // RVA: 0x7AE4E8E50
        public void SetParentKeyConstraint(){} // RVA: 0x7A8296DE0
        public void get_ChildKeyConstraint(){} // RVA: 0x7AE4E8E70
        public void get_ExtendedProperties(){} // RVA: 0x7AE4E8E90
        public void get_CheckMultipleNested(){} // RVA: 0x7A865FC40
        public void set_CheckMultipleNested(){} // RVA: 0x7A8665180
        public void SetChildKeyConstraint(){} // RVA: 0x7A80FF440
        public void CheckState(){} // RVA: 0x7AE4E8F50
        public void CheckStateForProperty(){} // RVA: 0x7AE4E9230
        public void Create(){} // RVA: 0x7AE4E9330
        public void Clone(){} // RVA: 0x7AE4E96E0
        public void OnPropertyChanging(){} // RVA: 0x7AE4E9E50
        public void RaisePropertyChanging(){} // RVA: 0x7AE4E9F10
        public void ToString(){} // RVA: 0x7A82393C0
        public void ValidateMultipleNestedRelations(){} // RVA: 0x7AE4EA020
        public void IsAutoGenerated(){} // RVA: 0x7AE4EA490
        public void get_ObjectID(){} // RVA: 0x7A98A0C40
    }

    public class DataRelationCollection : InternalDataCollectionBase
    {
        // ── Methods ──
        public void get_ObjectID(){} // RVA: 0x7A8133100
        public void get_Item(){} // RVA: 0x7A7E00B20
        public void Add(){} // RVA: 0x7AE4EA700
        public void AddCore(){} // RVA: 0x7AE4EA930
        public void add_CollectionChanged(){} // RVA: 0x7AE4EAC30
        public void remove_CollectionChanged(){} // RVA: 0x7AE4EAD90
        public void AssignName(){} // RVA: 0x7AE4EAEF0
        public void Clear(){} // RVA: 0x7AE4EAF10
        public void Contains(){} // RVA: 0x7AE4EB190
        public void InternalIndexOf(){} // RVA: 0x7AE4EB1B0
        public void GetDataSet(){} // RVA: 0x7A7E00680
        public void MakeName(){} // RVA: 0x7AE4EB370
        public void OnCollectionChanged(){} // RVA: 0x7AE4EB420
        public void OnCollectionChanging(){} // RVA: 0x7AE4EB4E0
        public void RegisterName(){} // RVA: 0x7AE4EB5A0
        public void Remove(){} // RVA: 0x7AE4EB890
        public void RemoveAt(){} // RVA: 0x7AE4EBA80
        public void RemoveCore(){} // RVA: 0x7AE4EBB10
        public void UnregisterName(){} // RVA: 0x7AE4EBCF0
        public void .ctor(){} // RVA: 0x7AE4EBEA0
    }

    public class DataRelationPropertyDescriptor : PropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4EDD80
        public void get_Relation(){} // RVA: 0x7A81163D0
        public void get_ComponentType(){} // RVA: 0x7AE4EDE30
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void get_PropertyType(){} // RVA: 0x7AE4EDEE0
        public void Equals(){} // RVA: 0x7AE4EDF90
        public void GetHashCode(){} // RVA: 0x7AE4E4830
        public void CanResetValue(){} // RVA: 0x7A80D7320
        public void GetValue(){} // RVA: 0x7AE4EE030
        public void ResetValue(){} // RVA: 0x7A80D7310
        public void SetValue(){} // RVA: 0x7A80D7310
        public void ShouldSerializeValue(){} // RVA: 0x7A80D7320
    }

    public class DataRow : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4EE0C0
        public void get_LastChangedColumn(){} // RVA: 0x7AE4EE200
        public void set_LastChangedColumn(){} // RVA: 0x7AE4EE210
        public void get_HasPropertyChanged(){} // RVA: 0x7AE4EE270
        public void get_RBTreeNodeId(){} // RVA: 0x7A87A7DA0
        public void set_RBTreeNodeId(){} // RVA: 0x7AE4EE280
        public void get_RowError(){} // RVA: 0x7AE4EE320
        public void set_RowError(){} // RVA: 0x7AE4EE380
        public void RowErrorChanged(){} // RVA: 0x7AE4EE710
        public void get_rowID(){} // RVA: 0x7A83F69F0
        public void set_rowID(){} // RVA: 0x7AE4EE760
        public void get_RowState(){} // RVA: 0x7AE4EE7D0
        public void get_Table(){} // RVA: 0x7A80F2570
        public void CheckForLoops(){} // RVA: 0x7AE4EE990
        public void GetNestedParentCount(){} // RVA: 0x7AE4EEA90
        public void set_Item(){} // RVA: 0x7AE4EECC0
        public void get_Item(){} // RVA: 0x7AE4EF250
        public void set_ItemArray(){} // RVA: 0x7AE4EF340
        public void AcceptChanges(){} // RVA: 0x7AE4EF860
        public void BeginEdit(){} // RVA: 0x7AE4EFBD0
        public void BeginEditInternal(){} // RVA: 0x7AE4EFBE0
        public void CancelEdit(){} // RVA: 0x7AE4EFCB0
        public void CheckColumn(){} // RVA: 0x7AE4EFD70
        public void CheckInTable(){} // RVA: 0x7AE4EFE30
        public void Delete(){} // RVA: 0x7AE4EFE70
        public void EndEdit(){} // RVA: 0x7AE4EFEE0
        public void SetColumnError(){} // RVA: 0x7AE4F00C0
        public void GetColumnError(){} // RVA: 0x7AE4F0400
        public void ClearErrors(){} // RVA: 0x7AE4F0600
        public void ClearError(){} // RVA: 0x7AE4F0730
        public void get_HasErrors(){} // RVA: 0x7AE4F0840
        public void GetColumnsInError(){} // RVA: 0x7AE4F0880
        public void GetChildRows(){} // RVA: 0x7AE4F0A40
        public void GetDataColumn(){} // RVA: 0x7AE4F0BB0
        public void GetParentRow(){} // RVA: 0x7AE4F0C40
        public void GetNestedParentRow(){} // RVA: 0x7AE4F0DC0
        public void GetParentRows(){} // RVA: 0x7AE4F0EA0
        public void GetColumnValues(){} // RVA: 0x7AE4F1120
        public void GetKeyValues(){} // RVA: 0x7AE4F1200
        public void GetCurrentRecordNo(){} // RVA: 0x7AE4F1230
        public void GetDefaultRecord(){} // RVA: 0x7AE4F1270
        public void GetOriginalRecordNo(){} // RVA: 0x7AE4F12D0
        public void GetProposedRecordNo(){} // RVA: 0x7AE4F1310
        public void GetRecordFromVersion(){} // RVA: 0x7AE4F1350
        public void GetDefaultRowVersion(){} // RVA: 0x7AE4F1440
        public void GetRecordState(){} // RVA: 0x7AE4F1470
        public void HasKeyChanged(){} // RVA: 0x7AE4F14F0
        public void HasVersion(){} // RVA: 0x7AE4F1580
        public void HaveValuesChanged(){} // RVA: 0x7AE4F1640
        public void RejectChanges(){} // RVA: 0x7AE4F17C0
        public void ResetLastChangedColumn(){} // RVA: 0x7AE4F1C60
        public void SetKeyValues(){} // RVA: 0x7AE4F1CC0
        public void SetNestedParentRow(){} // RVA: 0x7AE4F1DE0
        public void SetParentRowToDBNull(){} // RVA: 0x7AE4F2360
        public void CopyValuesIntoStore(){} // RVA: 0x7AE4F2520
    }

    public class DataRowBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
    }

    public class DataRowChangeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F2910
    }

    public class DataRowChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DataRowCollection : InternalDataCollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F29D0
        public void get_Count(){} // RVA: 0x7AE4F2B40
        public void get_Item(){} // RVA: 0x7AE4F2B90
        public void Add(){} // RVA: 0x7AE4F2BE0
        public void DiffInsertAt(){} // RVA: 0x7AE4F2C20
        public void IndexOf(){} // RVA: 0x7AE4F2F30
        public void AddWithColumnEvents(){} // RVA: 0x7AE4F2FC0
        public void ArrayAdd(){} // RVA: 0x7AE4F3050
        public void ArrayInsert(){} // RVA: 0x7AE4F30C0
        public void ArrayClear(){} // RVA: 0x7AE4F31B0
        public void ArrayRemove(){} // RVA: 0x7AE4F3210
        public void CopyTo(){} // RVA: 0x7AE4F3470
        public void GetEnumerator(){} // RVA: 0x7AE4F34E0
    }

    public class DataRowCreatedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DataRowView : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AA68A530
        public void GetHashCode(){} // RVA: 0x7A9BEA620
        public void get_DataView(){} // RVA: 0x7A80F2570
        public void System.ComponentModel.IDataErrorInfo.get_Item(){} // RVA: 0x7AE4F36A0
        public void System.ComponentModel.IDataErrorInfo.get_Error(){} // RVA: 0x7AE4F36E0
        public void get_RowVersionDefault(){} // RVA: 0x7AE4F3750
        public void GetRecord(){} // RVA: 0x7AE4F37B0
        public void HasRecord(){} // RVA: 0x7AE4F3830
        public void GetColumnValue(){} // RVA: 0x7AE4F38B0
        public void SetColumnValue(){} // RVA: 0x7AE4F3930
        public void CreateChildView(){} // RVA: 0x7AE4F3BD0
        public void get_Row(){} // RVA: 0x7A80DA7B0
        public void BeginEdit(){} // RVA: 0x7A9039410
        public void CancelEdit(){} // RVA: 0x7AE4F3BE0
        public void EndEdit(){} // RVA: 0x7AE4F3C40
        public void get_IsNew(){} // RVA: 0x7AE4F3CA0
        public void add_PropertyChanged(){} // RVA: 0x7AE4F3CD0
        public void remove_PropertyChanged(){} // RVA: 0x7AE4F3DC0
        public void RaisePropertyChangedEvent(){} // RVA: 0x7AE4F3EB0
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7AE4F3F40
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7AE4F3FE0
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7AE4F4070
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7A97F8BA0
        public void .cctor(){} // RVA: 0x7AE4F4110
    }

    public class DataSet : MarshalByValueComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4C13C0
        public void get_RemotingFormat(){} // RVA: 0x7A989D5C0
        public void set_RemotingFormat(){} // RVA: 0x7AE4C1270
        public void get_SchemaSerializationMode(){} // RVA: 0x7A81CA9D0
        public void GetObjectData(){} // RVA: 0x7AE4C1720
        public void InitializeDerivedDataSet(){} // RVA: 0x7A80D7310
        public void SerializeDataSet(){} // RVA: 0x7AE4C1750
        public void DeserializeDataSet(){} // RVA: 0x7AE4C23C0
        public void DeserializeDataSetSchema(){} // RVA: 0x7AE4C2440
        public void DeserializeDataSetData(){} // RVA: 0x7AE4C2BC0
        public void SerializeDataSetProperties(){} // RVA: 0x7AE4C2DB0
        public void DeserializeDataSetProperties(){} // RVA: 0x7AE4C3660
        public void SerializeRelations(){} // RVA: 0x7AE4C3B50
        public void DeserializeRelations(){} // RVA: 0x7AE4C40B0
        public void FailedEnableConstraints(){} // RVA: 0x7AE4C47F0
        public void get_CaseSensitive(){} // RVA: 0x7ACDBE8E0
        public void set_CaseSensitive(){} // RVA: 0x7AE4C4830
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x7A81BD750
        public void get_DefaultViewManager(){} // RVA: 0x7AE4C4AB0
        public void get_EnforceConstraints(){} // RVA: 0x7A8359360
        public void set_EnforceConstraints(){} // RVA: 0x7AE4C4C60
        public void RestoreEnforceConstraints(){} // RVA: 0x7A8A21900
        public void EnableConstraints(){} // RVA: 0x7AE4C4D60
        public void get_DataSetName(){} // RVA: 0x7A8154D80
        public void set_DataSetName(){} // RVA: 0x7AE4C52E0
        public void get_Namespace(){} // RVA: 0x7A8178B90
        public void set_Namespace(){} // RVA: 0x7AE4C5470
        public void get_Prefix(){} // RVA: 0x7A8152D80
        public void set_Prefix(){} // RVA: 0x7AE4C58A0
        public void get_ExtendedProperties(){} // RVA: 0x7AE4C5AE0
        public void get_IsInitialized(){} // RVA: 0x7AE4C5BA0
        public void get_Locale(){} // RVA: 0x7A8175DF0
        public void set_Locale(){} // RVA: 0x7AE4C5BB0
        public void SetLocaleValue(){} // RVA: 0x7AE4C5CE0
        public void ShouldSerializeLocale(){} // RVA: 0x7A81A00C0
        public void get_Site(){} // RVA: 0x7A80F2570
        public void set_Site(){} // RVA: 0x7AE4C68B0
        public void get_Relations(){} // RVA: 0x7A83F69F0
        public void get_Tables(){} // RVA: 0x7A8105330
        public void add_Initialized(){} // RVA: 0x7AE4C6A70
        public void remove_Initialized(){} // RVA: 0x7AE4C6B70
        public void BeginInit(){} // RVA: 0x7AE4C6C70
        public void EndInit(){} // RVA: 0x7AE4C6C80
        public void Clear(){} // RVA: 0x7AE4C6F10
        public void Clone(){} // RVA: 0x7AE4C70A0
        public void EstimatedXmlStringSize(){} // RVA: 0x7AE4C8000
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7AE4C8160
        public void GetRemotingDiffGram(){} // RVA: 0x7AE4C8170
        public void GetXmlSchemaForRemoting(){} // RVA: 0x7AE4C8300
        public void ReadXmlSchema(){} // RVA: 0x7AE4C8520
        public void MoveToElement(){} // RVA: 0x7AE4C9150
        public void ReadEndElement(){} // RVA: 0x7AE4AC3F0
        public void ReadXSDSchema(){} // RVA: 0x7AE4C91E0
        public void ReadXDRSchema(){} // RVA: 0x7AE4C95B0
        public void WriteXmlSchema(){} // RVA: 0x7AE4C98B0
        public void ReadXml(){} // RVA: 0x7AE4CC8F0
        public void InferSchema(){} // RVA: 0x7AE4CB100
        public void IsEmpty(){} // RVA: 0x7AE4CB430
        public void ReadXmlDiffgram(){} // RVA: 0x7AE4CB610
        public void WriteXml(){} // RVA: 0x7AE4CDB30
        public void Merge(){} // RVA: 0x7AE4CDE00
        public void OnPropertyChanging(){} // RVA: 0x7AE4CE010
        public void OnMergeFailed(){} // RVA: 0x7AE4CE040
        public void RaiseMergeFailed(){} // RVA: 0x7AE4CE0C0
        public void OnDataRowCreated(){} // RVA: 0x7AE4CE2A0
        public void OnClearFunctionCalled(){} // RVA: 0x7AE4CE2D0
        public void OnInitialized(){} // RVA: 0x7AE4CE300
        public void OnRemoveTable(){} // RVA: 0x7A80D7310
        public void OnRemovedTable(){} // RVA: 0x7AE4CE380
        public void OnRemoveRelation(){} // RVA: 0x7A80D7310
        public void OnRemoveRelationHack(){} // RVA: 0x7AE3D4950
        public void RaisePropertyChanging(){} // RVA: 0x7AE4CE3D0
        public void TopLevelTables(){} // RVA: 0x7AE4CE460
        public void Reset(){} // RVA: 0x7AE4CE6A0
        public void ValidateCaseConstraint(){} // RVA: 0x7AE4CE8F0
        public void ValidateLocaleConstraint(){} // RVA: 0x7AE4CECA0
        public void FindTable(){} // RVA: 0x7AE4CF0D0
        public void ReadXmlSerializable(){} // RVA: 0x7AE4CF250
        public void GetDataSetSchema(){} // RVA: 0x7AE4CF8E0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7AE4CFDB0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7AE4CFFF0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7AE4D0150
        public void get_MainTableName(){} // RVA: 0x7A81A00E0
        public void set_MainTableName(){} // RVA: 0x7A81A00F0
        public void get_ObjectID(){} // RVA: 0x7A897F560
    }

    public class DataSetClearEventhandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DataTable : MarshalByValueComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE490270
        public void GetObjectData(){} // RVA: 0x7AE4904C0
        public void SerializeDataTable(){} // RVA: 0x7AE4905B0
        public void DeserializeDataTable(){} // RVA: 0x7AE490CF0
        public void SerializeTableSchema(){} // RVA: 0x7AE491080
        public void DeserializeTableSchema(){} // RVA: 0x7AE493D90
        public void SerializeConstraints(){} // RVA: 0x7AE495B80
        public void DeserializeConstraints(){} // RVA: 0x7AE4963E0
        public void SerializeExpressionColumns(){} // RVA: 0x7AE497010
        public void DeserializeExpressionColumns(){} // RVA: 0x7AE497450
        public void SerializeTableData(){} // RVA: 0x7AE497670
        public void DeserializeTableData(){} // RVA: 0x7AE4987B0
        public void ConvertToRowState(){} // RVA: 0x7AE4996A0
        public void GetRowAndColumnErrors(){} // RVA: 0x7AE499780
        public void ConvertToRowError(){} // RVA: 0x7AE499B60
        public void get_CaseSensitive(){} // RVA: 0x7A92C23E0
        public void set_CaseSensitive(){} // RVA: 0x7AE499F10
        public void get_AreIndexEventsSuspended(){} // RVA: 0x7AE499FD0
        public void RestoreIndexEvents(){} // RVA: 0x7AE499FE0
        public void SuspendIndexEvents(){} // RVA: 0x7AE49A370
        public void get_IsInitialized(){} // RVA: 0x7AE49A400
        public void get_IsTypedDataTable(){} // RVA: 0x7AE49A410
        public void SetCaseSensitiveValue(){} // RVA: 0x7AE49A4C0
        public void ShouldSerializeCaseSensitive(){} // RVA: 0x7AE49A7A0
        public void get_SelfNested(){} // RVA: 0x7AE49A7B0
        public void get_LiveIndexes(){} // RVA: 0x7AE49A9B0
        public void get_RemotingFormat(){} // RVA: 0x7AE49AA90
        public void set_RemotingFormat(){} // RVA: 0x7AE49AAA0
        public void get_UKColumnPositionForInference(){} // RVA: 0x7AE194F10
        public void set_UKColumnPositionForInference(){} // RVA: 0x7AE194F20
        public void get_ChildRelations(){} // RVA: 0x7AE49AB20
        public void get_Columns(){} // RVA: 0x7A8154D80
        public void get_CompareInfo(){} // RVA: 0x7AE49ABD0
        public void get_Constraints(){} // RVA: 0x7A8152D80
        public void ResetConstraints(){} // RVA: 0x7AE49AC70
        public void get_DataSet(){} // RVA: 0x7A81052C0
        public void SetDataSet(){} // RVA: 0x7AE49AC90
        public void get_DefaultView(){} // RVA: 0x7AE49AE00
        public void get_DisplayExpressionInternal(){} // RVA: 0x7AE49AFD0
        public void get_EnforceConstraints(){} // RVA: 0x7AE49B070
        public void set_EnforceConstraints(){} // RVA: 0x7AE49B0A0
        public void get_SuspendEnforceConstraints(){} // RVA: 0x7AE49B0E0
        public void set_SuspendEnforceConstraints(){} // RVA: 0x7AE49B0F0
        public void EnableConstraints(){} // RVA: 0x7AE49B100
        public void get_ExtendedProperties(){} // RVA: 0x7AE49B650
        public void get_FormatProvider(){} // RVA: 0x7AE49B720
        public void get_Locale(){} // RVA: 0x7A8142680
        public void set_Locale(){} // RVA: 0x7AE49B810
        public void SetLocaleValue(){} // RVA: 0x7AE49BDA0
        public void ShouldSerializeLocale(){} // RVA: 0x7A80F86D0
        public void get_MinimumCapacity(){} // RVA: 0x7AE49C420
        public void set_MinimumCapacity(){} // RVA: 0x7AE49C440
        public void get_RecordCapacity(){} // RVA: 0x7AE49C490
        public void get_ElementColumnCount(){} // RVA: 0x7A8355950
        public void set_ElementColumnCount(){} // RVA: 0x7AE49C4B0
        public void get_ParentRelations(){} // RVA: 0x7AE49C500
        public void get_MergingData(){} // RVA: 0x7AE194410
        public void set_MergingData(){} // RVA: 0x7AE194420
        public void get_NestedParentRelations(){} // RVA: 0x7A8B46B20
        public void get_SchemaLoading(){} // RVA: 0x7A8639110
        public void CacheNestedParent(){} // RVA: 0x7AE49C5B0
        public void FindNestedParentRelations(){} // RVA: 0x7AE49C620
        public void get_NestedParentsCount(){} // RVA: 0x7AE49C950
        public void get_PrimaryKey(){} // RVA: 0x7AE49CBC0
        public void set_PrimaryKey(){} // RVA: 0x7AE49CC30
        public void get_Rows(){} // RVA: 0x7A8292C30
        public void get_TableName(){} // RVA: 0x7A8555100
        public void set_TableName(){} // RVA: 0x7AE49D220
        public void get_EncodedTableName(){} // RVA: 0x7AE49D9D0
        public void GetInheritedNamespace(){} // RVA: 0x7AE49DAE0
        public void get_Namespace(){} // RVA: 0x7AE49DD70
        public void set_Namespace(){} // RVA: 0x7AE49DE00
        public void IsNamespaceInherited(){} // RVA: 0x7AE49E0C0
        public void CheckCascadingNamespaceConflict(){} // RVA: 0x7AE49E0D0
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7AE49E3C0
        public void CheckNamespaceValidityForNestedParentRelations(){} // RVA: 0x7AE49E710
        public void DoRaiseNamespaceChange(){} // RVA: 0x7AE49E9B0
        public void BeginInit(){} // RVA: 0x7AE49EEB0
        public void EndInit(){} // RVA: 0x7AE49EEC0
        public void get_Prefix(){} // RVA: 0x7A87C5850
        public void set_Prefix(){} // RVA: 0x7AE49F450
        public void get_XmlText(){} // RVA: 0x7A8592710
        public void set_XmlText(){} // RVA: 0x7AE49F6A0
        public void get_MaxOccurs(){} // RVA: 0x7AE49F900
        public void set_MaxOccurs(){} // RVA: 0x7AE49F910
        public void get_MinOccurs(){} // RVA: 0x7AE088A40
        public void set_MinOccurs(){} // RVA: 0x7AE088A50
        public void SetKeyValues(){} // RVA: 0x7AE49F920
        public void FindByIndex(){} // RVA: 0x7AE49F9B0
        public void FindMergeTarget(){} // RVA: 0x7AE49FA50
        public void SetMergeRecords(){} // RVA: 0x7AE49FB30
        public void MergeRow(){} // RVA: 0x7AE49FC70
        public void CreateInstance(){} // RVA: 0x7AE4A04B0
        public void Clone(){} // RVA: 0x7AE4A0550
        public void IncrementalCloneTo(){} // RVA: 0x7AE4A06D0
        public void CloneHierarchy(){} // RVA: 0x7AE4A0980
        public void CloneTo(){} // RVA: 0x7AE4A0DD0
        public void add_Initialized(){} // RVA: 0x7AE4A1F30
        public void remove_Initialized(){} // RVA: 0x7AE4A2030
        public void get_Site(){} // RVA: 0x7A80F2570
        public void set_Site(){} // RVA: 0x7AE4A2130
        public void AddRow(){} // RVA: 0x7AE4A22F0
        public void InsertRow(){} // RVA: 0x7AE4A3E10
        public void CheckNotModifying(){} // RVA: 0x7AE4A2760
        public void Clear(){} // RVA: 0x7AE4A27A0
        public void CascadeAll(){} // RVA: 0x7AE4A3190
        public void CommitRow(){} // RVA: 0x7AE4A32C0
        public void Compare(){} // RVA: 0x7AE4A3440
        public void IndexOf(){} // RVA: 0x7AE4A35C0
        public void IsSuffix(){} // RVA: 0x7AE4A3630
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x7A80D7320
        public void DeleteRow(){} // RVA: 0x7AE4A36A0
        public void FormatSortString(){} // RVA: 0x7AE4A3750
        public void FreeRecord(){} // RVA: 0x7AE4A38A0
        public void GetIndex(){} // RVA: 0x7AE4A3910
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7AE4A3C20
        public void GetListeners(){} // RVA: 0x7A8B5B150
        public void GetSpecialHashCode(){} // RVA: 0x7AE4A3C30
        public void NewRecord(){} // RVA: 0x7AE4A42E0
        public void NewUninitializedRecord(){} // RVA: 0x7AE4A42C0
        public void NewEmptyRow(){} // RVA: 0x7AE4A43F0
        public void NewUninitializedRow(){} // RVA: 0x7AE4A4470
        public void NewRow(){} // RVA: 0x7AE4A49F0
        public void CreateEmptyRow(){} // RVA: 0x7AE4A45C0
        public void NewRowCreated(){} // RVA: 0x7AE4A48F0
        public void NewRowFromBuilder(){} // RVA: 0x7AE4A4AE0
        public void GetRowType(){} // RVA: 0x7AE4A4C50
        public void NewRowArray(){} // RVA: 0x7AE4A4D00
        public void get_NeedColumnChangeEvents(){} // RVA: 0x7AE4A4EA0
        public void OnColumnChanging(){} // RVA: 0x7AE4A4EE0
        public void OnColumnChanged(){} // RVA: 0x7AE4A4FA0
        public void OnPropertyChanging(){} // RVA: 0x7AE4A5060
        public void OnRemoveColumnInternal(){} // RVA: 0x7AE4A5120
        public void OnRemoveColumn(){} // RVA: 0x7A80D7310
        public void OnRowChanged(){} // RVA: 0x7AE4A52A0
        public void OnRowChanging(){} // RVA: 0x7AE4A5360
        public void OnRowDeleting(){} // RVA: 0x7AE4A5420
        public void OnRowDeleted(){} // RVA: 0x7AE4A54E0
        public void OnTableCleared(){} // RVA: 0x7AE4A55A0
        public void OnTableClearing(){} // RVA: 0x7AE4A5660
        public void OnTableNewRow(){} // RVA: 0x7AE4A5720
        public void OnInitialized(){} // RVA: 0x7AE4A57E0
        public void ParseSortString(){} // RVA: 0x7AE4A58E0
        public void RaisePropertyChanging(){} // RVA: 0x7AE4A61A0
        public void RecordChanged(){} // RVA: 0x7AE4A6350
        public void RecordStateChanged(){} // RVA: 0x7AE4A6620
        public void RemoveRecordFromIndexes(){} // RVA: 0x7AE4A6800
        public void InsertRecordToIndexes(){} // RVA: 0x7AE4A6A80
        public void SilentlySetValue(){} // RVA: 0x7AE4A6CB0
        public void RemoveRow(){} // RVA: 0x7AE4A6F00
        public void Reset(){} // RVA: 0x7AE4A72B0
        public void ResetIndexes(){} // RVA: 0x7AE4A7580
        public void ResetInternalIndexes(){} // RVA: 0x7AE4A7590
        public void RollbackRow(){} // RVA: 0x7AE4A7720
        public void RaiseRowChanged(){} // RVA: 0x7AE4A77C0
        public void RaiseRowChanging(){} // RVA: 0x7AE4A7CD0
        public void SetNewRecord(){} // RVA: 0x7AE4A7E90
        public void SetNewRecordWorker(){} // RVA: 0x7AE4A7F10
        public void SetOldRecord(){} // RVA: 0x7AE4A8BA0
        public void RestoreShadowIndexes(){} // RVA: 0x7AE4A90A0
        public void SetShadowIndexes(){} // RVA: 0x7AE4A9110
        public void ShadowIndexCopy(){} // RVA: 0x7AE4A91A0
        public void ToString(){} // RVA: 0x7AE4A9280
        public void UpdatingCurrent(){} // RVA: 0x7AE4A9370
        public void AddUniqueKey(){} // RVA: 0x7AE4A96D0
        public void AddForeignKey(){} // RVA: 0x7AE4A96E0
        public void UpdatePropertyDescriptorCollectionCache(){} // RVA: 0x7AE4A97A0
        public void GetPropertyDescriptorCollection(){} // RVA: 0x7AE4A9800
        public void get_TypeName(){} // RVA: 0x7AE4A9CB0
        public void set_TypeName(){} // RVA: 0x7A8B68960
        public void Merge(){} // RVA: 0x7AE4A9D80
        public void WriteXml(){} // RVA: 0x7AE4A9F90
        public void CheckForClosureOnExpressions(){} // RVA: 0x7AE4AA300
        public void CheckForClosureOnExpressionTables(){} // RVA: 0x7AE4AA3D0
        public void WriteXmlSchema(){} // RVA: 0x7AE4AA770
        public void RestoreConstraint(){} // RVA: 0x7AE4AAAE0
        public void IsEmptyXml(){} // RVA: 0x7AE4AAB40
        public void ReadXml(){} // RVA: 0x7AE4AAE60
        public void ReadEndElement(){} // RVA: 0x7AE4AC3F0
        public void ReadXDRSchema(){} // RVA: 0x7AE4AC4B0
        public void MoveToElement(){} // RVA: 0x7AE4AC530
        public void ReadXmlDiffgram(){} // RVA: 0x7AE4AC610
        public void ReadXSDSchema(){} // RVA: 0x7AE4AD0F0
        public void ReadXmlSchema(){} // RVA: 0x7AE4AD3C0
        public void CreateTableList(){} // RVA: 0x7AE4AE490
        public void CreateRelationList(){} // RVA: 0x7AE4AE7C0
        public void GetDataTableSchema(){} // RVA: 0x7AE4AEB30
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7ADCAB470
        public void GetSchema(){} // RVA: 0x7AE4AEF40
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7AE4AF170
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7AE4AF240
        public void ReadXmlSerializable(){} // RVA: 0x7AE4AF290
        public void get_RowDiffId(){} // RVA: 0x7AE4AF2B0
        public void get_ObjectID(){} // RVA: 0x7A97FA380
        public void AddDependentColumn(){} // RVA: 0x7AE4AF370
        public void RemoveDependentColumn(){} // RVA: 0x7AE4AF490
        public void EvaluateExpressions(){} // RVA: 0x7AE4AFE40
        public void EvaluateDependentExpressions(){} // RVA: 0x7AE4B02B0
    }

    public class DataTableClearEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F41D0
    }

    public class DataTableClearEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DataTableCollection : InternalDataCollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F4270
        public void get_List(){} // RVA: 0x7A80DA7B0
        public void get_ObjectID(){} // RVA: 0x7A8178B30
        public void get_Item(){} // RVA: 0x7AE4F4620
        public void GetTable(){} // RVA: 0x7AE4F4750
        public void GetTableSmart(){} // RVA: 0x7AE4F48E0
        public void Add(){} // RVA: 0x7AE4F4A90
        public void add_CollectionChanged(){} // RVA: 0x7AE4F4CA0
        public void remove_CollectionChanged(){} // RVA: 0x7AE4F4E00
        public void ArrayAdd(){} // RVA: 0x7AE4F4F60
        public void AssignName(){} // RVA: 0x7AE4F4F90
        public void BaseAdd(){} // RVA: 0x7AE4F5000
        public void BaseGroupSwitch(){} // RVA: 0x7AE4F51E0
        public void BaseRemove(){} // RVA: 0x7AE4F53A0
        public void CanRemove(){} // RVA: 0x7AE4F5460
        public void Clear(){} // RVA: 0x7AE4F5950
        public void Contains(){} // RVA: 0x7AE4F5EC0
        public void IndexOf(){} // RVA: 0x7AE4F61C0
        public void ReplaceFromInference(){} // RVA: 0x7AE4F6250
        public void InternalIndexOf(){} // RVA: 0x7AE4F64E0
        public void FinishInitCollection(){} // RVA: 0x7AE4F66F0
        public void MakeName(){} // RVA: 0x7AE4F67B0
        public void OnCollectionChanged(){} // RVA: 0x7AE4F6860
        public void OnCollectionChanging(){} // RVA: 0x7AE4F6920
        public void RegisterName(){} // RVA: 0x7AE4F69E0
        public void Remove(){} // RVA: 0x7AE4F6E00
        public void UnregisterName(){} // RVA: 0x7AE4F6F70
    }

    public class DataTableNewRowEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F7100
    }

    public class DataTableNewRowEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DataTablePropertyDescriptor : PropertyDescriptor
    {
        // ── Methods ──
        public void get_Table(){} // RVA: 0x7A81163D0
        public void .ctor(){} // RVA: 0x7AE4F71A0
        public void get_ComponentType(){} // RVA: 0x7AE4F7240
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void get_PropertyType(){} // RVA: 0x7AE4F72F0
        public void Equals(){} // RVA: 0x7AE4F73A0
        public void GetHashCode(){} // RVA: 0x7AE4E4830
        public void CanResetValue(){} // RVA: 0x7A80D7320
        public void GetValue(){} // RVA: 0x7AE4F7440
        public void ResetValue(){} // RVA: 0x7A80D7310
        public void SetValue(){} // RVA: 0x7A80D7310
        public void ShouldSerializeValue(){} // RVA: 0x7A80D7320
    }

    public class DataTableTypeConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F7520
        public void GetPropertiesSupported(){} // RVA: 0x7A80D7320
    }

    public class DataTextReader : XmlReader
    {
        // ── Methods ──
        public void CreateReader(){} // RVA: 0x7AE561F60
        public void .ctor(){} // RVA: 0x7AE562030
        public void get_Settings(){} // RVA: 0x7A858AB20
        public void get_NodeType(){} // RVA: 0x7A858ABB0
        public void get_Name(){} // RVA: 0x7ADE59240
        public void get_LocalName(){} // RVA: 0x7A856A750
        public void get_NamespaceURI(){} // RVA: 0x7ADB00ED0
        public void get_Prefix(){} // RVA: 0x7ADB00F00
        public void get_Value(){} // RVA: 0x7A972BF20
        public void get_Depth(){} // RVA: 0x7AE3C9490
        public void get_BaseURI(){} // RVA: 0x7A858ABE0
        public void get_IsEmptyElement(){} // RVA: 0x7A858AB50
        public void get_IsDefault(){} // RVA: 0x7A858AA50
        public void get_QuoteChar(){} // RVA: 0x7A858AB80
        public void get_XmlSpace(){} // RVA: 0x7A858AA20
        public void get_XmlLang(){} // RVA: 0x7A858AC40
        public void get_AttributeCount(){} // RVA: 0x7AE1E3E00
        public void GetAttribute(){} // RVA: 0x7AE562100
        public void MoveToAttribute(){} // RVA: 0x7AE562160
        public void MoveToFirstAttribute(){} // RVA: 0x7ADB010B0
        public void MoveToNextAttribute(){} // RVA: 0x7ADBF0670
        public void MoveToElement(){} // RVA: 0x7A8555880
        public void ReadAttributeValue(){} // RVA: 0x7ADE58970
        public void Read(){} // RVA: 0x7AE562190
        public void get_EOF(){} // RVA: 0x7AE5621C0
        public void Close(){} // RVA: 0x7ADE59400
        public void get_ReadState(){} // RVA: 0x7AE5621F0
        public void Skip(){} // RVA: 0x7ADA26BF0
        public void get_NameTable(){} // RVA: 0x7ADE584C0
        public void LookupNamespace(){} // RVA: 0x7AE562220
        public void get_CanResolveEntity(){} // RVA: 0x7AE562250
        public void ResolveEntity(){} // RVA: 0x7AE562280
        public void get_CanReadValueChunk(){} // RVA: 0x7ADBFB720
        public void ReadString(){} // RVA: 0x7AE5622B0
    }

    public class DataTextWriter : XmlWriter
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7AE561AC0
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_BaseStream(){} // RVA: 0x7AE561B50
        public void WriteStartDocument(){} // RVA: 0x7AE561BD0
        public void WriteEndDocument(){} // RVA: 0x7ADC27120
        public void WriteDocType(){} // RVA: 0x7AE561C00
        public void WriteStartElement(){} // RVA: 0x7AE561C30
        public void WriteEndElement(){} // RVA: 0x7ADAB0020
        public void WriteFullEndElement(){} // RVA: 0x7AE561C60
        public void WriteStartAttribute(){} // RVA: 0x7AE561C90
        public void WriteEndAttribute(){} // RVA: 0x7ADAB0050
        public void WriteCData(){} // RVA: 0x7AE561CC0
        public void WriteComment(){} // RVA: 0x7AE561CF0
        public void WriteProcessingInstruction(){} // RVA: 0x7AE561D20
        public void WriteEntityRef(){} // RVA: 0x7AE561D50
        public void WriteCharEntity(){} // RVA: 0x7AE561D80
        public void WriteWhitespace(){} // RVA: 0x7AE561DB0
        public void WriteString(){} // RVA: 0x7AE561DE0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE561E10
        public void WriteChars(){} // RVA: 0x7AE561E40
        public void WriteRaw(){} // RVA: 0x7AE561EA0
        public void WriteBase64(){} // RVA: 0x7AE561ED0
        public void WriteBinHex(){} // RVA: 0x7AE561F00
        public void get_WriteState(){} // RVA: 0x7ADB7C8A0
        public void Close(){} // RVA: 0x7ADB7C840
        public void Flush(){} // RVA: 0x7ACF0AE10
        public void LookupPrefix(){} // RVA: 0x7AE561F30
    }

    public class DataView : MarshalByValueComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4F7B30
        public void get_AllowDelete(){} // RVA: 0x7A81A00C0
        public void get_AllowEdit(){} // RVA: 0x7AE4F7BB0
        public void get_AllowNew(){} // RVA: 0x7AE4F7BC0
        public void get_Count(){} // RVA: 0x7AE4F7BD0
        public void get_CountFromIndex(){} // RVA: 0x7AE4F7C20
        public void get_DataViewManager(){} // RVA: 0x7A81052C0
        public void get_IsInitialized(){} // RVA: 0x7AE4F7C50
        public void get_IsOpen(){} // RVA: 0x7AE4F7C60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_RowFilter(){} // RVA: 0x7AE4F7C70
        public void set_RowFilter(){} // RVA: 0x7AE4F7D10
        public void get_RowStateFilter(){} // RVA: 0x7A83562E0
        public void set_RowStateFilter(){} // RVA: 0x7AE4F7FB0
        public void get_Sort(){} // RVA: 0x7AE4F8100
        public void set_Sort(){} // RVA: 0x7AE4F82B0
        public void get_SortComparison(){} // RVA: 0x7A8178B90
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void get_Table(){} // RVA: 0x7A8105330
        public void set_Table(){} // RVA: 0x7AE4F85B0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7AE4F88C0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AE4F8930
        public void get_Item(){} // RVA: 0x7AE4F88C0
        public void AddNew(){} // RVA: 0x7AE4F8960
        public void BeginInit(){} // RVA: 0x7AE4F8CD0
        public void EndInit(){} // RVA: 0x7AE4F8CE0
        public void CheckOpen(){} // RVA: 0x7AE4F9110
        public void CheckSort(){} // RVA: 0x7AE4F9150
        public void Close(){} // RVA: 0x7AE4F91B0
        public void CopyTo(){} // RVA: 0x7AE4F9420
        public void Delete(){} // RVA: 0x7AE4F96E0
        public void Dispose(){} // RVA: 0x7AE4F9850
        public void FinishAddNew(){} // RVA: 0x7AE4F98C0
        public void GetEnumerator(){} // RVA: 0x7AE4F9B40
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.Add(){} // RVA: 0x7AE4F9BF0
        public void System.Collections.IList.Clear(){} // RVA: 0x7AE4F9C80
        public void System.Collections.IList.Contains(){} // RVA: 0x7AE4F9CB0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7AE4F9D40
        public void IndexOf(){} // RVA: 0x7AE4F9DD0
        public void IndexOfDataRowView(){} // RVA: 0x7AE4F9EF0
        public void System.Collections.IList.Insert(){} // RVA: 0x7AE4F9FA0
        public void System.Collections.IList.Remove(){} // RVA: 0x7AE4F9FD0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7AE4F96B0
        public void GetFindIndex(){} // RVA: 0x7AE4FA0B0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7AE4F7BC0
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7AD4F41C0
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7AE4F7BB0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7A81A00C0
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7AE4FA2E0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7AE4FA310
        public void GetSortProperty(){} // RVA: 0x7AE4FA3B0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7AE4FA440
        public void add_ListChanged(){} // RVA: 0x7AE4FA480
        public void remove_ListChanged(){} // RVA: 0x7AE4FA5E0
        public void add_Initialized(){} // RVA: 0x7AE4FA740
        public void remove_Initialized(){} // RVA: 0x7AE4FA840
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7AE4FA940
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7AE4FA990
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7AE4FA9C0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7AE4FACA0
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7AE4FACF0
        public void System.ComponentModel.IBindingListView.ApplySort(){} // RVA: 0x7AE4FADB0
        public void CreateSortString(){} // RVA: 0x7AE4FB190
        public void System.ComponentModel.IBindingListView.RemoveFilter(){} // RVA: 0x7AE4FB310
        public void System.ComponentModel.IBindingListView.get_Filter(){} // RVA: 0x7AE4FB3E0
        public void System.ComponentModel.IBindingListView.set_Filter(){} // RVA: 0x7AE4FB400
        public void System.ComponentModel.IBindingListView.get_SortDescriptions(){} // RVA: 0x7AE4FB420
        public void GetSortDescriptions(){} // RVA: 0x7AE4FB430
        public void System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingListView.get_SupportsFiltering(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7AE4FB810
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7AE4FB8C0
        public void GetFilter(){} // RVA: 0x7A81A0050
        public void GetRecord(){} // RVA: 0x7AE4FB9A0
        public void GetRow(){} // RVA: 0x7AE4FBA60
        public void GetRowView(){} // RVA: 0x7AE4FBC60
        public void IndexListChanged(){} // RVA: 0x7AE4FBCC0
        public void IndexListChangedInternal(){} // RVA: 0x7AE4FBD50
        public void MaintainDataView(){} // RVA: 0x7AE4FBE20
        public void OnListChanged(){} // RVA: 0x7AE4FC140
        public void OnInitialized(){} // RVA: 0x7AE4FC4E0
        public void Reset(){} // RVA: 0x7AE4FC560
        public void ResetRowViewCache(){} // RVA: 0x7AE4FC590
        public void SetDataViewManager(){} // RVA: 0x7AE4FC970
        public void SetIndex(){} // RVA: 0x7AE4FCBF0
        public void SetIndex2(){} // RVA: 0x7AE4FCC10
        public void UpdateIndex(){} // RVA: 0x7AE4FD000
        public void ChildRelationCollectionChanged(){} // RVA: 0x7AE4FD330
        public void ParentRelationCollectionChanged(){} // RVA: 0x7AE4FD580
        public void ColumnCollectionChanged(){} // RVA: 0x7AE4FD7D0
        public void ColumnCollectionChangedInternal(){} // RVA: 0x7AE4FDA70
        public void get_ObjectID(){} // RVA: 0x7A8357940
        public void .cctor(){} // RVA: 0x7AE4FDA90
    }

    public class DataViewListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4FDC50
        public void ChildRelationCollectionChanged(){} // RVA: 0x7AE4FDD30
        public void ParentRelationCollectionChanged(){} // RVA: 0x7AE4FDE10
        public void ColumnCollectionChanged(){} // RVA: 0x7AE4FDEF0
        public void MaintainDataView(){} // RVA: 0x7AE4FDFE0
        public void IndexListChanged(){} // RVA: 0x7AE4FE0D0
        public void RegisterMetaDataEvents(){} // RVA: 0x7AE4FE260
        public void UnregisterMetaDataEvents(){} // RVA: 0x7AE4FE690
        public void RegisterListChangedEvent(){} // RVA: 0x7AE4FEBD0
        public void UnregisterListChangedEvent(){} // RVA: 0x7AE4FEE00
        public void CleanUp(){} // RVA: 0x7AE4FEFD0
        public void RegisterListener(){} // RVA: 0x7AE4FEFF0
    }

    public class DataViewManager : MarshalByValueComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4FF280
        public void get_DataSet(){} // RVA: 0x7A8105330
        public void get_DataViewSettings(){} // RVA: 0x7A81052C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE4FF780
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7A81CA9D0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A81BD750
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AE4FF810
        public void System.Collections.IList.get_Item(){} // RVA: 0x7A83F69F0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AE4FF8D0
        public void System.Collections.IList.Add(){} // RVA: 0x7AE4FF900
        public void System.Collections.IList.Clear(){} // RVA: 0x7AE4FF930
        public void System.Collections.IList.Contains(){} // RVA: 0x7AE4FF960
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7AE4FF970
        public void System.Collections.IList.Insert(){} // RVA: 0x7AE4FF990
        public void System.Collections.IList.Remove(){} // RVA: 0x7AE4FF9C0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7AE4FF9F0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7AE4FFA20
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7AE4FFA70
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7AE4FFAC0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7AE4FFB10
        public void add_ListChanged(){} // RVA: 0x7AE4FFB60
        public void remove_ListChanged(){} // RVA: 0x7AE4FFC50
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7A80D7310
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7AE4FFD40
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7AE4FFD90
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7A80D7310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7AE4FFDE0
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7AE4FFE30
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7AE4FFF00
        public void CreateDataView(){} // RVA: 0x7AE500060
        public void OnListChanged(){} // RVA: 0x7AE500110
        public void TableCollectionChanged(){} // RVA: 0x7AE500200
        public void RelationCollectionChanged(){} // RVA: 0x7AE5004B0
        public void .cctor(){} // RVA: 0x7AE500700
    }

    public class DataViewManagerListItemTypeDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetDataView(){} // RVA: 0x7AE5007F0
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7AE500870
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7AE500910
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7AE5009A0
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7A97F8BA0
    }

    public class DataViewSetting : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE500C90
        public void get_ApplyDefaultSort(){} // RVA: 0x7A810DDD0
        public void SetDataViewManager(){} // RVA: 0x7AE4E7590
        public void SetDataTable(){} // RVA: 0x7AE500DA0
        public void get_RowFilter(){} // RVA: 0x7A8105330
        public void get_RowStateFilter(){} // RVA: 0x7A8133100
        public void get_Sort(){} // RVA: 0x7A81052C0
    }

    public class DataViewSettingCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE500E00
        public void get_Item(){} // RVA: 0x7AE500F50
        public void set_Item(){} // RVA: 0x7AE501160
        public void CopyTo(){} // RVA: 0x7AE501290
        public void get_Count(){} // RVA: 0x7AE501460
        public void GetEnumerator(){} // RVA: 0x7AE5014B0
        public void get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void Remove(){} // RVA: 0x7AE501510
    }

    public class DefaultValueTypeConverter : StringConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ConvertTo(){} // RVA: 0x7AE5018C0
        public void ConvertFrom(){} // RVA: 0x7AE501A60
    }

    public class DeletedRowInaccessibleException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4BA800
    }

    public class DuplicateNameException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4BA870
    }

}