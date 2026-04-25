// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 41
// Methods: 1066

namespace ThirdParty.DotNet.System.Data
{
    public class DataColumn : MarshalByValueComponent
    {
        public bool AllowDBNull; // 0x20
        public string AutoIncrement; // 0x28
        public string AutoIncrementCurrent; // 0x30
        public System.Type AutoInc; // 0x38
        public 0x6B1D1B00 AutoIncrementSeed; // 0x40
        public object AutoIncrementStep; // 0x48
        public 0x6B1CEEA8 Caption; // 0x50
        public System.Data.DataExpression ColumnName; // 0x58
        public int EncodedColumnName; // 0x60
        public int FormatProvider; // 0x64
        public bool Locale; // 0x68
        public System.Data.Index ObjectID; // 0x70
        public System.Data.DataTable Prefix; // 0x78
        public bool Computed; // 0x80
        public 0x6B1CFD70 DataExpression; // 0x84
        public int DataType; // 0x88
        public int DateTimeMode; // 0x8C
        public bool DefaultValue; // 0x90
        public bool DefaultValueIsNull; // 0x91
        public bool Expression; // 0x92
        public bool ExtendedProperties; // 0x93
        public bool HasData; // 0x94
        public bool ImplementsINullable; // 0x95
        public System.Collections.Generic.List`1<System.Data.DataColumn> ImplementsIChangeTracking; // 0x98
        public System.Data.PropertyCollection ImplementsIRevertibleChangeTracking; // 0xA0
        public System.Data.Common.DataStorage IsValueType; // 0xA8
        public System.Data.AutoIncrementValue IsSqlType; // 0xB0
        public string MaxLength; // 0xB8
        public string Namespace; // 0xC0
        public string Ordinal; // 0xC8
        public System.Data.SimpleType ReadOnly; // 0xD0
        public int SortIndex;
        public int Table; // 0xD8
        public string Item; // 0xE0
        public System.ComponentModel.PropertyChangedEventHandler Unique; // 0xE8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E59C90 | overloaded x3
        public void UpdateColumnType(){} // RVA: 0x7FFAC8E5A160
        public void get_AllowDBNull(){} // RVA: 0x7FFAC300F9D0
        public void set_AllowDBNull(){} // RVA: 0x7FFAC8E5A420
        public void get_AutoIncrement(){} // RVA: 0x7FFAC8E5A540
        public void set_AutoIncrement(){} // RVA: 0x7FFAC8E5A560
        public void get_AutoIncrementCurrent(){} // RVA: 0x7FFAC8E5A750
        public void set_AutoIncrementCurrent(){} // RVA: 0x7FFAC8E5A7C0
        public void get_AutoInc(){} // RVA: 0x7FFAC8E5A930
        public void get_AutoIncrementSeed(){} // RVA: 0x7FFAC8E5AA70
        public void set_AutoIncrementSeed(){} // RVA: 0x7FFAC8E5AAA0
        public void get_AutoIncrementStep(){} // RVA: 0x7FFAC8E5AB90
        public void set_AutoIncrementStep(){} // RVA: 0x7FFAC8E5ABC0
        public void get_Caption(){} // RVA: 0x7FFAC8E5ACB0
        public void set_Caption(){} // RVA: 0x7FFAC8E5ACD0
        public void get_ColumnName(){} // RVA: 0x7FFAC31D95E0
        public void set_ColumnName(){} // RVA: 0x7FFAC8E5AE30
        public void get_EncodedColumnName(){} // RVA: 0x7FFAC8E5B350
        public void get_FormatProvider(){} // RVA: 0x7FFAC8E5B450
        public void get_Locale(){} // RVA: 0x7FFAC8E5B4F0
        public void get_ObjectID(){} // RVA: 0x7FFAC47BB150
        public void get_Prefix(){} // RVA: 0x7FFAC2F8C120
        public void set_Prefix(){} // RVA: 0x7FFAC8E5B590
        public void GetColumnValueAsString(){} // RVA: 0x7FFAC8E5B7E0
        public void get_Computed(){} // RVA: 0x7FFAC781EE50
        public void get_DataExpression(){} // RVA: 0x7FFAC2FE9500
        public void get_DataType(){} // RVA: 0x7FFAC31D0140
        public void set_DataType(){} // RVA: 0x7FFAC8E5B8D0
        public void get_DateTimeMode(){} // RVA: 0x7FFAC30F10E0
        public void set_DateTimeMode(){} // RVA: 0x7FFAC8E5C260
        public void get_DefaultValue(){} // RVA: 0x7FFAC8E5C3E0
        public void set_DefaultValue(){} // RVA: 0x7FFAC8E5C5C0
        public void get_DefaultValueIsNull(){} // RVA: 0x7FFAC8E5C900
        public void BindExpression(){} // RVA: 0x7FFAC8E5C910
        public void get_Expression(){} // RVA: 0x7FFAC8E5C940
        public void set_Expression(){} // RVA: 0x7FFAC8E5C9C0
        public void get_ExtendedProperties(){} // RVA: 0x7FFAC8E5D190
        public void get_HasData(){} // RVA: 0x7FFAC8E5D260
        public void get_ImplementsINullable(){} // RVA: 0x7FFAC4862190
        public void get_ImplementsIChangeTracking(){} // RVA: 0x7FFAC3F3F160
        public void get_ImplementsIRevertibleChangeTracking(){} // RVA: 0x7FFAC8E5D270
        public void get_IsValueType(){} // RVA: 0x7FFAC8E5D280
        public void get_IsSqlType(){} // RVA: 0x7FFAC3E0D160
        public void SetMaxLengthSimpleType(){} // RVA: 0x7FFAC8E5D2A0
        public void get_MaxLength(){} // RVA: 0x7FFAC3138C20
        public void set_MaxLength(){} // RVA: 0x7FFAC8E5D430
        public void get_Namespace(){} // RVA: 0x7FFAC8E5D830
        public void set_Namespace(){} // RVA: 0x7FFAC8E5D8B0
        public void get_Ordinal(){} // RVA: 0x7FFAC3138CA0
        public void SetOrdinalInternal(){} // RVA: 0x7FFAC8E5DA80
        public void get_ReadOnly(){} // RVA: 0x7FFAC2FE9570
        public void set_ReadOnly(){} // RVA: 0x7FFAC8E5DBC0
        public void get_SortIndex(){} // RVA: 0x7FFAC8E5DC90
        public void get_Table(){} // RVA: 0x7FFAC30E5600
        public void SetTable(){} // RVA: 0x7FFAC8E5DE50
        public void GetDataRow(){} // RVA: 0x7FFAC8E5DFD0
        public void get_Item(){} // RVA: 0x7FFAC8E5E010
        public void set_Item(){} // RVA: 0x7FFAC8E5E040
        public void InitializeRecord(){} // RVA: 0x7FFAC8E5E1F0
        public void SetValue(){} // RVA: 0x7FFAC8E5E240
        public void FreeRecord(){} // RVA: 0x7FFAC8E5E390
        public void get_Unique(){} // RVA: 0x7FFAC313E620
        public void set_Unique(){} // RVA: 0x7FFAC8E5E3D0
        public void InternalUnique(){} // RVA: 0x7FFAC313D3B0
        public void get_XmlDataType(){} // RVA: 0x7FFAC2FA2900
        public void set_XmlDataType(){} // RVA: 0x7FFAC2FA2910
        public void get_SimpleType(){} // RVA: 0x7FFAC303E100
        public void set_SimpleType(){} // RVA: 0x7FFAC8E5E790
        public void get_ColumnMapping(){} // RVA: 0x7FFAC46D5110
        public void set_ColumnMapping(){} // RVA: 0x7FFAC8E5E910
        public void CheckColumnConstraint(){} // RVA: 0x7FFAC8E5ED00
        public void CheckMaxLength(){} // RVA: 0x7FFAC8E5F110 | overloaded x2
        public void CheckNotAllowNull(){} // RVA: 0x7FFAC8E5F1D0
        public void CheckNullable(){} // RVA: 0x7FFAC8E5F520
        public void CheckUnique(){} // RVA: 0x7FFAC8E5F5E0
        public void Compare(){} // RVA: 0x7FFAC8E5F670
        public void CompareValueTo(){} // RVA: 0x7FFAC8E5F8C0 | overloaded x2
        public void ConvertValue(){} // RVA: 0x7FFAC8E5F8F0
        public void Copy(){} // RVA: 0x7FFAC8E5F920
        public void Clone(){} // RVA: 0x7FFAC8E5F950
        public void GetAggregateValue(){} // RVA: 0x7FFAC8E600D0
        public void GetStringLength(){} // RVA: 0x7FFAC8E60250
        public void Init(){} // RVA: 0x7FFAC8E60280
        public void IsAutoIncrementType(){} // RVA: 0x7FFAC8E60350
        public void get_IsCustomType(){} // RVA: 0x7FFAC8E60620
        public void IsValueCustomTypeInstance(){} // RVA: 0x7FFAC8E60690
        public void get_ImplementsIXMLSerializable(){} // RVA: 0x7FFAC8AC3770
        public void IsInRelation(){} // RVA: 0x7FFAC8E607C0
        public void IsMaxLengthViolated(){} // RVA: 0x7FFAC8E60950
        public void IsNotAllowDBNullViolated(){} // RVA: 0x7FFAC8E60D70
        public void FinishInitInProgress(){} // RVA: 0x7FFAC8E60EF0
        public void OnPropertyChanging(){} // RVA: 0x7FFAC8E60F10
        public void RaisePropertyChanging(){} // RVA: 0x7FFAC8E60F40
        public void InsureStorage(){} // RVA: 0x7FFAC8E60FC0
        public void SetCapacity(){} // RVA: 0x7FFAC8E610A0
        public void OnSetDataSet(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC8E610F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8E611B0 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8E61260 | overloaded x2
        public void GetEmptyColumnStore(){} // RVA: 0x7FFAC8E612D0
        public void CopyValueIntoStore(){} // RVA: 0x7FFAC8E61320
        public void SetStorage(){} // RVA: 0x7FFAC8E61360
        public void AddDependentColumn(){} // RVA: 0x7FFAC8E613C0
        public void RemoveDependentColumn(){} // RVA: 0x7FFAC8E614D0
        public void HandleDependentColumnList(){} // RVA: 0x7FFAC8E61570
    }

    public class DataColumnChangeEventArgs : EventArgs
    {
        public System.Data.DataColumn ProposedValue; // 0x10
        public System.Data.DataRow <Row>k__BackingField; // 0x18
        public object <ProposedValue>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E89240 | overloaded x2
        public void get_ProposedValue(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ProposedValue(){} // RVA: 0x7FFAC2F4F0D0
        public void InitializeColumnChangeEvent(){} // RVA: 0x7FFAC8BF0300
    }

    public class DataColumnChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DataColumnCollection : InternalDataCollectionBase
    {
        public System.Data.DataTable List; // 0x10
        public System.Collections.ArrayList ColumnsImplementingIChangeTracking; // 0x18
        public int ColumnsImplementingIChangeTrackingCount; // 0x20
        public System.Data.DataColumn[] ColumnsImplementingIRevertibleChangeTrackingCount; // 0x28
        public System.Collections.Generic.Dictionary`2<string,System.Data.DataColumn> Item; // 0x30
        public bool Item; // 0x38
        public System.Data.DataColumn[] Item; // 0x40
        public int _nColumnsImplementingIChangeTracking; // 0x48
        public int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
        public System.ComponentModel.CollectionChangeEventHandler CollectionChanged; // 0x50
        public System.ComponentModel.CollectionChangeEventHandler CollectionChanging; // 0x58
        public System.ComponentModel.CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E893A0
        public void get_List(){} // RVA: 0x7FFAC2F247C0
        public void get_ColumnsImplementingIChangeTracking(){} // RVA: 0x7FFAC2F9E740
        public void get_ColumnsImplementingIChangeTrackingCount(){} // RVA: 0x7FFAC2FC20C0
        public void get_ColumnsImplementingIRevertibleChangeTrackingCount(){} // RVA: 0x7FFAC3F2D3C0
        public void get_Item(){} // RVA: 0x7FFAC8E89870 | overloaded x3
        public void Add(){} // RVA: 0x7FFAC8E89950
        public void AddAt(){} // RVA: 0x7FFAC8E89960
        public void add_CollectionChanged(){} // RVA: 0x7FFAC8E89CC0
        public void remove_CollectionChanged(){} // RVA: 0x7FFAC8E89DB0
        public void add_ColumnPropertyChanged(){} // RVA: 0x7FFAC8E89EA0
        public void remove_ColumnPropertyChanged(){} // RVA: 0x7FFAC8E89F90
        public void ArrayAdd(){} // RVA: 0x7FFAC8E8A120 | overloaded x2
        public void ArrayRemove(){} // RVA: 0x7FFAC8E8A190
        public void AssignName(){} // RVA: 0x7FFAC8E8A4B0
        public void BaseAdd(){} // RVA: 0x7FFAC8E8A560
        public void BaseGroupSwitch(){} // RVA: 0x7FFAC8E8A950
        public void BaseRemove(){} // RVA: 0x7FFAC8E8AC20
        public void CanRemove(){} // RVA: 0x7FFAC8E8AE20
        public void CheckIChangeTracking(){} // RVA: 0x7FFAC8E8B7B0
        public void Clear(){} // RVA: 0x7FFAC8E8B800
        public void Contains(){} // RVA: 0x7FFAC8E8BDD0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC8E8BE90
        public void IndexOfCaseInsensitive(){} // RVA: 0x7FFAC8E8BFA0
        public void FinishInitCollection(){} // RVA: 0x7FFAC8E8C150
        public void MakeName(){} // RVA: 0x7FFAC8E8C260
        public void OnCollectionChanged(){} // RVA: 0x7FFAC8E8C310
        public void OnCollectionChanging(){} // RVA: 0x7FFAC8E8C410
        public void OnColumnPropertyChanged(){} // RVA: 0x7FFAC8E8C430
        public void RegisterColumnName(){} // RVA: 0x7FFAC8E8C4D0
        public void CanRegisterName(){} // RVA: 0x7FFAC8E8C720
        public void Remove(){} // RVA: 0x7FFAC8E8C790
        public void UnregisterName(){} // RVA: 0x7FFAC8E8C8D0
        public void AddColumnsImplementingIChangeTrackingList(){} // RVA: 0x7FFAC8E8CA20
        public void RemoveColumnsImplementingIChangeTrackingList(){} // RVA: 0x7FFAC8E8CB40
    }

    public class DataColumnPropertyDescriptor : PropertyDescriptor
    {
        public System.Data.DataColumn Attributes; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E8CCA0
        public void get_Attributes(){} // RVA: 0x7FFAC8E8CD30
        public void get_Column(){} // RVA: 0x7FFAC2F60010
        public void get_ComponentType(){} // RVA: 0x7FFAC8E8CF80
        public void get_IsReadOnly(){} // RVA: 0x7FFAC8E8D030
        public void get_PropertyType(){} // RVA: 0x7FFAC8E8D050
        public void Equals(){} // RVA: 0x7FFAC8E8D070
        public void GetHashCode(){} // RVA: 0x7FFAC8E8D110
        public void CanResetValue(){} // RVA: 0x7FFAC8E8D140
        public void GetValue(){} // RVA: 0x7FFAC8E8D280
        public void ResetValue(){} // RVA: 0x7FFAC8E8D310
        public void SetValue(){} // RVA: 0x7FFAC8E8D3E0
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC2F21320
        public void get_IsBrowsable(){} // RVA: 0x7FFAC8E8D4E0
    }

    public class DataCommonEventSource : EventSource
    {
        public System.Data.DataCommonEventSource Log;
        public long s_nextScopeId; // 0x8

        // ── Methods ──
        public void Trace(){} // RVA: 0x7FFAC2E8DC40 | overloaded x7
        public void EnterScope(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void ExitScope(){} // RVA: 0x7FFAC8E841E0
        public void .ctor(){} // RVA: 0x7FFAC85A5E30
        public void .cctor(){} // RVA: 0x7FFAC8E842A0
    }

    public class DataError : Object
    {
        public string Text; // 0x10
        public int HasErrors; // 0x18
        public ColumnError[] _errorList; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E8D6F0 | overloaded x2
        public void get_Text(){} // RVA: 0x7FFAC2F3C380
        public void set_Text(){} // RVA: 0x7FFAC8E8D830
        public void get_HasErrors(){} // RVA: 0x7FFAC8E8D8D0
        public void SetColumnError(){} // RVA: 0x7FFAC8E8D900
        public void GetColumnError(){} // RVA: 0x7FFAC8E8DB30
        public void Clear(){} // RVA: 0x7FFAC8E8DC90 | overloaded x2
        public void GetColumnsInError(){} // RVA: 0x7FFAC8E8DD80
        public void SetText(){} // RVA: 0x7FFAC8E8D830
        public void IndexOf(){} // RVA: 0x7FFAC8E8DEB0
    }

    public class DataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F75C0 | overloaded x4
    }

    public class DataExpression : Object
    {
        public string Expression; // 0x10
        public bool HasValue; // 0x18
        public bool _bound; // 0x19
        public System.Data.ExpressionNode _expr; // 0x20
        public System.Data.DataTable _table; // 0x28
        public 0x6B1D1B00 _storageType; // 0x30
        public System.Type _dataType; // 0x38
        public System.Data.DataColumn[] _dependency; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EB3350 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFAC8EB3770
        public void get_HasValue(){} // RVA: 0x7FFAC495C6A0
        public void Bind(){} // RVA: 0x7FFAC8EB37C0
        public void DependsOn(){} // RVA: 0x7FFAC8EB3A40
        public void Evaluate(){} // RVA: 0x7FFAC8EB3A80 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC8EB3C90
        public void GetDependency(){} // RVA: 0x7FFAC2F9E740
        public void IsTableAggregate(){} // RVA: 0x7FFAC8EB3D40
        public void IsUnknown(){} // RVA: 0x7FFAC8EB3D70
        public void HasLocalAggregate(){} // RVA: 0x7FFAC8EB3DC0
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC8EB3DF0
        public void ToBoolean(){} // RVA: 0x7FFAC8EB3E20
    }

    public class DataKey : ValueType
    {
        public System.Data.DataColumn[] ColumnsReference; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E8E040
        public void get_ColumnsReference(){} // RVA: 0x7FFAC3AD9F60
        public void get_HasValue(){} // RVA: 0x7FFAC3BB0800
        public void get_Table(){} // RVA: 0x7FFAC8E8E2E0
        public void CheckState(){} // RVA: 0x7FFAC8E8E310
        public void ColumnsEqual(){} // RVA: 0x7FFAC8E8E4C0 | overloaded x2
        public void ContainsColumn(){} // RVA: 0x7FFAC8E8E570
        public void GetHashCode(){} // RVA: 0x7FFAC8E8E5C0
        public void Equals(){} // RVA: 0x7FFAC8E8E6A0 | overloaded x2
        public void GetColumnNames(){} // RVA: 0x7FFAC8E8E740
        public void GetIndexDesc(){} // RVA: 0x7FFAC8E8E850
        public void GetKeyValues(){} // RVA: 0x7FFAC8E8E9F0
        public void GetSortIndex(){} // RVA: 0x7FFAC8E8EBF0 | overloaded x2
        public void RecordsEqual(){} // RVA: 0x7FFAC8E8EC60
        public void ToArray(){} // RVA: 0x7FFAC8E8ED10
    }

    public class DataRelation : Object
    {
        public System.Data.DataSet ChildColumns; // 0x10
        public System.Data.PropertyCollection ChildColumnsReference; // 0x18
        public string ChildKey; // 0x20
        public System.Data.DataKey ChildTable; // 0x28
        public System.Data.DataKey DataSet; // 0x30
        public System.Data.UniqueConstraint ParentColumnNames; // 0x38
        public System.Data.ForeignKeyConstraint ChildColumnNames; // 0x40
        public string[] ParentColumns; // 0x48
        public string[] ParentColumnsReference; // 0x50
        public string ParentKey; // 0x58
        public string ParentTable; // 0x60
        public string RelationName; // 0x68
        public string Nested; // 0x70
        public bool ParentKeyConstraint; // 0x78
        public bool ChildKeyConstraint; // 0x79
        public bool ExtendedProperties; // 0x7A
        public int CheckMultipleNested;
        public int ObjectID; // 0x7C
        public System.ComponentModel.PropertyChangedEventHandler PropertyChanging; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E8F4C0 | overloaded x5
        public void get_ChildColumns(){} // RVA: 0x7FFAC8E8F7F0
        public void get_ChildColumnsReference(){} // RVA: 0x7FFAC8E8F810
        public void get_ChildKey(){} // RVA: 0x7FFAC8E8F810
        public void get_ChildTable(){} // RVA: 0x7FFAC8E8F830
        public void get_DataSet(){} // RVA: 0x7FFAC8E8F870
        public void get_ParentColumnNames(){} // RVA: 0x7FFAC8E8F890
        public void get_ChildColumnNames(){} // RVA: 0x7FFAC8E8F8A0
        public void IsKeyNull(){} // RVA: 0x7FFAC8E8F8B0
        public void GetChildRows(){} // RVA: 0x7FFAC8E8F960
        public void GetParentRows(){} // RVA: 0x7FFAC8E8FA80
        public void GetParentRow(){} // RVA: 0x7FFAC8E8FBA0
        public void SetDataSet(){} // RVA: 0x7FFAC8E8FD30
        public void get_ParentColumns(){} // RVA: 0x7FFAC8E8FD90
        public void get_ParentColumnsReference(){} // RVA: 0x7FFAC31D95E0
        public void get_ParentKey(){} // RVA: 0x7FFAC8E8FDB0
        public void get_ParentTable(){} // RVA: 0x7FFAC8E8FDD0
        public void get_RelationName(){} // RVA: 0x7FFAC8E8FE10
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7FFAC8E8FE30
        public void CheckNestedRelations(){} // RVA: 0x7FFAC8E90110
        public void get_Nested(){} // RVA: 0x7FFAC8E905E0
        public void set_Nested(){} // RVA: 0x7FFAC8E90600
        public void get_ParentKeyConstraint(){} // RVA: 0x7FFAC8E91600
        public void SetParentKeyConstraint(){} // RVA: 0x7FFAC31D0C20
        public void get_ChildKeyConstraint(){} // RVA: 0x7FFAC8E91620
        public void get_ExtendedProperties(){} // RVA: 0x7FFAC8E91640
        public void get_CheckMultipleNested(){} // RVA: 0x7FFAC33D1F80
        public void set_CheckMultipleNested(){} // RVA: 0x7FFAC33CAD50
        public void SetChildKeyConstraint(){} // RVA: 0x7FFAC2F49200
        public void CheckState(){} // RVA: 0x7FFAC8E91700
        public void CheckStateForProperty(){} // RVA: 0x7FFAC8E919E0
        public void Create(){} // RVA: 0x7FFAC8E91AF0
        public void Clone(){} // RVA: 0x7FFAC8E91EA0
        public void OnPropertyChanging(){} // RVA: 0x7FFAC8E92600
        public void RaisePropertyChanging(){} // RVA: 0x7FFAC8E926C0
        public void ToString(){} // RVA: 0x7FFAC30821C0
        public void ValidateMultipleNestedRelations(){} // RVA: 0x7FFAC8E927D0
        public void IsAutoGenerated(){} // RVA: 0x7FFAC8E92C50
        public void get_ObjectID(){} // RVA: 0x7FFAC4598F70
    }

    public class DataRelationCollection : InternalDataCollectionBase
    {
        public System.Data.DataRelation ObjectID; // 0x10
        public int Item; // 0x18
        public System.ComponentModel.CollectionChangeEventHandler Item; // 0x20
        public System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
        public int s_objectTypeCount;
        public int _objectID; // 0x30

        // ── Methods ──
        public void get_ObjectID(){} // RVA: 0x7FFAC2F7CCD0
        public void get_Item(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC8E92EC0
        public void AddCore(){} // RVA: 0x7FFAC8E930F0
        public void add_CollectionChanged(){} // RVA: 0x7FFAC8E933F0
        public void remove_CollectionChanged(){} // RVA: 0x7FFAC8E93550
        public void AssignName(){} // RVA: 0x7FFAC8E936B0
        public void Clear(){} // RVA: 0x7FFAC8E936D0
        public void Contains(){} // RVA: 0x7FFAC8E93950
        public void InternalIndexOf(){} // RVA: 0x7FFAC8E93970
        public void GetDataSet(){} // RVA: 0x7FFAC2C58E90
        public void MakeName(){} // RVA: 0x7FFAC8E93B30
        public void OnCollectionChanged(){} // RVA: 0x7FFAC8E93BE0
        public void OnCollectionChanging(){} // RVA: 0x7FFAC8E93CA0
        public void RegisterName(){} // RVA: 0x7FFAC8E93D60
        public void Remove(){} // RVA: 0x7FFAC8E94050
        public void RemoveAt(){} // RVA: 0x7FFAC8E94240
        public void RemoveCore(){} // RVA: 0x7FFAC8E942D0
        public void UnregisterName(){} // RVA: 0x7FFAC8E944B0
        public void .ctor(){} // RVA: 0x7FFAC8E94660
    }

    public class DataRelationPropertyDescriptor : PropertyDescriptor
    {
        public System.Data.DataRelation Relation; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E96510
        public void get_Relation(){} // RVA: 0x7FFAC2F60010
        public void get_ComponentType(){} // RVA: 0x7FFAC8E965C0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_PropertyType(){} // RVA: 0x7FFAC8E96670
        public void Equals(){} // RVA: 0x7FFAC8E96720
        public void GetHashCode(){} // RVA: 0x7FFAC8E8D110
        public void CanResetValue(){} // RVA: 0x7FFAC2F21320
        public void GetValue(){} // RVA: 0x7FFAC8E967C0
        public void ResetValue(){} // RVA: 0x7FFAC2F21310
        public void SetValue(){} // RVA: 0x7FFAC2F21310
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC2F21320
    }

    public class DataRow : Object
    {
        public System.Data.DataTable LastChangedColumn; // 0x10
        public System.Data.DataColumnCollection HasPropertyChanged; // 0x18
        public int RBTreeNodeId; // 0x20
        public int RowError; // 0x24
        public int rowID; // 0x28
        public long RowState; // 0x30
        public 0x6B1CEAE0 Table; // 0x38
        public bool Item; // 0x3C
        public bool Item; // 0x3D
        public bool Item; // 0x3E
        public System.Data.DataColumn ItemArray; // 0x40
        public int HasErrors; // 0x48
        public System.Data.DataError _error; // 0x50
        public int _rbTreeNodeId; // 0x58
        public int s_objectTypeCount;
        public int _objectID; // 0x5C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E96850
        public void get_LastChangedColumn(){} // RVA: 0x7FFAC8E96990
        public void set_LastChangedColumn(){} // RVA: 0x7FFAC8E969A0
        public void get_HasPropertyChanged(){} // RVA: 0x7FFAC8E96A00
        public void get_RBTreeNodeId(){} // RVA: 0x7FFAC362EA40
        public void set_RBTreeNodeId(){} // RVA: 0x7FFAC8E96A10
        public void get_RowError(){} // RVA: 0x7FFAC8E96AB0
        public void set_RowError(){} // RVA: 0x7FFAC8E96B10
        public void RowErrorChanged(){} // RVA: 0x7FFAC8E96EA0
        public void get_rowID(){} // RVA: 0x7FFAC31D95E0
        public void set_rowID(){} // RVA: 0x7FFAC8E96EF0
        public void get_RowState(){} // RVA: 0x7FFAC8E96F60
        public void get_Table(){} // RVA: 0x7FFAC2F3C380
        public void CheckForLoops(){} // RVA: 0x7FFAC8E97110
        public void GetNestedParentCount(){} // RVA: 0x7FFAC8E97210
        public void set_Item(){} // RVA: 0x7FFAC8E97440 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC8E979D0 | overloaded x2
        public void set_ItemArray(){} // RVA: 0x7FFAC8E97AC0
        public void AcceptChanges(){} // RVA: 0x7FFAC8E97FE0
        public void BeginEdit(){} // RVA: 0x7FFAC8E98360
        public void BeginEditInternal(){} // RVA: 0x7FFAC8E98370
        public void CancelEdit(){} // RVA: 0x7FFAC8E98440
        public void CheckColumn(){} // RVA: 0x7FFAC8E98500
        public void CheckInTable(){} // RVA: 0x7FFAC8E985C0
        public void Delete(){} // RVA: 0x7FFAC8E98600
        public void EndEdit(){} // RVA: 0x7FFAC8E98670
        public void SetColumnError(){} // RVA: 0x7FFAC8E98850 | overloaded x2
        public void GetColumnError(){} // RVA: 0x7FFAC8E98B80 | overloaded x2
        public void ClearErrors(){} // RVA: 0x7FFAC8E98D80
        public void ClearError(){} // RVA: 0x7FFAC8E98EC0
        public void get_HasErrors(){} // RVA: 0x7FFAC8E98FC0
        public void GetColumnsInError(){} // RVA: 0x7FFAC8E99000
        public void GetChildRows(){} // RVA: 0x7FFAC8E991B0 | overloaded x2
        public void GetDataColumn(){} // RVA: 0x7FFAC8E99320
        public void GetParentRow(){} // RVA: 0x7FFAC8E993B0 | overloaded x2
        public void GetNestedParentRow(){} // RVA: 0x7FFAC8E99530
        public void GetParentRows(){} // RVA: 0x7FFAC8E99610 | overloaded x2
        public void GetColumnValues(){} // RVA: 0x7FFAC8E99890 | overloaded x2
        public void GetKeyValues(){} // RVA: 0x7FFAC8E99970 | overloaded x2
        public void GetCurrentRecordNo(){} // RVA: 0x7FFAC8E999A0
        public void GetDefaultRecord(){} // RVA: 0x7FFAC8E999E0
        public void GetOriginalRecordNo(){} // RVA: 0x7FFAC8E99A40
        public void GetProposedRecordNo(){} // RVA: 0x7FFAC8E99A80
        public void GetRecordFromVersion(){} // RVA: 0x7FFAC8E99AC0
        public void GetDefaultRowVersion(){} // RVA: 0x7FFAC8E99BB0
        public void GetRecordState(){} // RVA: 0x7FFAC8E99BE0
        public void HasKeyChanged(){} // RVA: 0x7FFAC8E99C60 | overloaded x2
        public void HasVersion(){} // RVA: 0x7FFAC8E99CF0
        public void HaveValuesChanged(){} // RVA: 0x7FFAC8E99DB0 | overloaded x2
        public void RejectChanges(){} // RVA: 0x7FFAC8E99F30
        public void ResetLastChangedColumn(){} // RVA: 0x7FFAC8E9A3D0
        public void SetKeyValues(){} // RVA: 0x7FFAC8E9A430
        public void SetNestedParentRow(){} // RVA: 0x7FFAC8E9A550
        public void SetParentRowToDBNull(){} // RVA: 0x7FFAC8E9AAF0 | overloaded x2
        public void CopyValuesIntoStore(){} // RVA: 0x7FFAC8E9ACB0
    }

    public class DataRowBuilder : Object
    {
        public System.Data.DataTable _table; // 0x10
        public int _record; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

    public class DataRowChangeEventArgs : EventArgs
    {
        public System.Data.DataRow <Row>k__BackingField; // 0x10
        public 0x6B1CEAE0 <Action>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E9B0A0
    }

    public class DataRowChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DataRowCollection : InternalDataCollectionBase
    {
        public System.Data.DataTable Count; // 0x10
        public DataRowTree Item; // 0x18
        public int _nullInList; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E9B160
        public void get_Count(){} // RVA: 0x7FFAC8E9B2D0
        public void get_Item(){} // RVA: 0x7FFAC8E9B320
        public void Add(){} // RVA: 0x7FFAC8E9B370
        public void DiffInsertAt(){} // RVA: 0x7FFAC8E9B3B0
        public void IndexOf(){} // RVA: 0x7FFAC8E9B6F0
        public void AddWithColumnEvents(){} // RVA: 0x7FFAC8E9B780
        public void ArrayAdd(){} // RVA: 0x7FFAC8E9B810
        public void ArrayInsert(){} // RVA: 0x7FFAC8E9B880
        public void ArrayClear(){} // RVA: 0x7FFAC8E9B970
        public void ArrayRemove(){} // RVA: 0x7FFAC8E9B9D0
        public void CopyTo(){} // RVA: 0x7FFAC8E9BC30 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC8E9BCA0
    }

    public class DataRowCreatedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DataRowView : Object
    {
        public System.Data.DataView DataView; // 0x10
        public System.Data.DataRow System.ComponentModel.IDataErrorInfo.Item; // 0x18
        public bool System.ComponentModel.IDataErrorInfo.Error; // 0x20
        public System.ComponentModel.PropertyDescriptorCollection RowVersionDefault;
        public System.ComponentModel.PropertyChangedEventHandler Row; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC490A6E0
        public void get_DataView(){} // RVA: 0x7FFAC2F3C380
        public void System.ComponentModel.IDataErrorInfo.get_Item(){} // RVA: 0x7FFAC8E9BE60
        public void System.ComponentModel.IDataErrorInfo.get_Error(){} // RVA: 0x7FFAC8E9BEA0
        public void get_RowVersionDefault(){} // RVA: 0x7FFAC8E9BF10
        public void GetRecord(){} // RVA: 0x7FFAC8E9BF70
        public void HasRecord(){} // RVA: 0x7FFAC8E9BFF0
        public void GetColumnValue(){} // RVA: 0x7FFAC8E9C070
        public void SetColumnValue(){} // RVA: 0x7FFAC8E9C0F0
        public void CreateChildView(){} // RVA: 0x7FFAC8E9C390 | overloaded x2
        public void get_Row(){} // RVA: 0x7FFAC2F247C0
        public void BeginEdit(){} // RVA: 0x7FFAC3D3BA70
        public void CancelEdit(){} // RVA: 0x7FFAC8E9C3A0
        public void EndEdit(){} // RVA: 0x7FFAC8E9C400
        public void get_IsNew(){} // RVA: 0x7FFAC8E9C460
        public void add_PropertyChanged(){} // RVA: 0x7FFAC8E9C490
        public void remove_PropertyChanged(){} // RVA: 0x7FFAC8E9C580
        public void RaisePropertyChangedEvent(){} // RVA: 0x7FFAC8E9C670
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFAC8E9C700
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFAC8E9C7A0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFAC8E9C830 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFAC44F81E0
        public void .cctor(){} // RVA: 0x7FFAC8E9C8D0
    }

    public class DataSet : MarshalByValueComponent
    {
        public System.Data.DataViewManager RemotingFormat; // 0x20
        public System.Data.DataTableCollection SchemaSerializationMode; // 0x28
        public System.Data.DataRelationCollection CaseSensitive; // 0x30
        public System.Data.PropertyCollection System.ComponentModel.IListSource.ContainsListCollection; // 0x38
        public string DefaultViewManager; // 0x40
        public string EnforceConstraints; // 0x48
        public string DataSetName; // 0x50
        public bool Namespace; // 0x58
        public bool Prefix; // 0x59
        public System.Globalization.CultureInfo ExtendedProperties; // 0x60
        public bool IsInitialized; // 0x68
        public bool Locale; // 0x69
        public bool Site; // 0x6A
        public bool Relations; // 0x6B
        public bool Tables; // 0x6C
        public bool MainTableName; // 0x6D
        public bool ObjectID; // 0x6E
        public string _mainTableName; // 0x70
        public 0x6B1CEE50 _remotingFormat; // 0x78
        public object _defaultViewManagerLock; // 0x80
        public int s_objectTypeCount;
        public int _objectID; // 0x88
        public System.Xml.Schema.XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
        public bool _useDataSetSchemaOnly; // 0x8C
        public bool _udtIsWrapped; // 0x8D
        public System.ComponentModel.PropertyChangedEventHandler PropertyChanging; // 0x90
        public System.Data.MergeFailedEventHandler MergeFailed; // 0x98
        public System.Data.DataRowCreatedEventHandler DataRowCreated; // 0xA0
        public System.Data.DataSetClearEventhandler ClearFunctionCalled; // 0xA8
        public System.EventHandler Initialized; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E69BD0 | overloaded x4
        public void get_RemotingFormat(){} // RVA: 0x7FFAC4596EF0
        public void set_RemotingFormat(){} // RVA: 0x7FFAC8E69A80
        public void get_SchemaSerializationMode(){} // RVA: 0x7FFAC3013AF0
        public void GetObjectData(){} // RVA: 0x7FFAC8E69F30
        public void InitializeDerivedDataSet(){} // RVA: 0x7FFAC2F21310
        public void SerializeDataSet(){} // RVA: 0x7FFAC8E69F60
        public void DeserializeDataSet(){} // RVA: 0x7FFAC8E6AC30
        public void DeserializeDataSetSchema(){} // RVA: 0x7FFAC8E6ACB0
        public void DeserializeDataSetData(){} // RVA: 0x7FFAC8E6B430
        public void SerializeDataSetProperties(){} // RVA: 0x7FFAC8E6B620
        public void DeserializeDataSetProperties(){} // RVA: 0x7FFAC8E6BED0
        public void SerializeRelations(){} // RVA: 0x7FFAC8E6C3C0
        public void DeserializeRelations(){} // RVA: 0x7FFAC8E6C960
        public void FailedEnableConstraints(){} // RVA: 0x7FFAC8E6D0C0
        public void get_CaseSensitive(){} // RVA: 0x7FFAC778CF40
        public void set_CaseSensitive(){} // RVA: 0x7FFAC8E6D100
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x7FFAC3006850
        public void get_DefaultViewManager(){} // RVA: 0x7FFAC8E6D3B0
        public void get_EnforceConstraints(){} // RVA: 0x7FFAC313F600
        public void set_EnforceConstraints(){} // RVA: 0x7FFAC8E6D5A0
        public void RestoreEnforceConstraints(){} // RVA: 0x7FFAC3892770
        public void EnableConstraints(){} // RVA: 0x7FFAC8E6D690
        public void get_DataSetName(){} // RVA: 0x7FFAC2F9E740
        public void set_DataSetName(){} // RVA: 0x7FFAC8E6DC20
        public void get_Namespace(){} // RVA: 0x7FFAC2FC20E0
        public void set_Namespace(){} // RVA: 0x7FFAC8E6DDB0
        public void get_Prefix(){} // RVA: 0x7FFAC2F9C730
        public void set_Prefix(){} // RVA: 0x7FFAC8E6E1F0
        public void get_ExtendedProperties(){} // RVA: 0x7FFAC8E6E430
        public void get_IsInitialized(){} // RVA: 0x7FFAC8E6E4F0
        public void get_Locale(){} // RVA: 0x7FFAC2FBF370
        public void set_Locale(){} // RVA: 0x7FFAC8E6E500
        public void SetLocaleValue(){} // RVA: 0x7FFAC8E6E620
        public void ShouldSerializeLocale(){} // RVA: 0x7FFAC2FE9570
        public void get_Site(){} // RVA: 0x7FFAC2F3C380
        public void set_Site(){} // RVA: 0x7FFAC8E6F250
        public void get_Relations(){} // RVA: 0x7FFAC31D95E0
        public void get_Tables(){} // RVA: 0x7FFAC2F4F130
        public void add_Initialized(){} // RVA: 0x7FFAC8E6F400
        public void remove_Initialized(){} // RVA: 0x7FFAC8E6F4F0
        public void BeginInit(){} // RVA: 0x7FFAC8E6F5E0
        public void EndInit(){} // RVA: 0x7FFAC8E6F5F0
        public void Clear(){} // RVA: 0x7FFAC8E6F870
        public void Clone(){} // RVA: 0x7FFAC8E6F9F0
        public void EstimatedXmlStringSize(){} // RVA: 0x7FFAC8E70970
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7FFAC8E70AD0
        public void GetRemotingDiffGram(){} // RVA: 0x7FFAC8E70AE0
        public void GetXmlSchemaForRemoting(){} // RVA: 0x7FFAC8E70C70
        public void ReadXmlSchema(){} // RVA: 0x7FFAC8E70E90 | overloaded x2
        public void MoveToElement(){} // RVA: 0x7FFAC8E71AE0 | overloaded x2
        public void ReadEndElement(){} // RVA: 0x7FFAC8E54B80
        public void ReadXSDSchema(){} // RVA: 0x7FFAC8E71B70
        public void ReadXDRSchema(){} // RVA: 0x7FFAC8E71F40
        public void WriteXmlSchema(){} // RVA: 0x7FFAC8E72230
        public void ReadXml(){} // RVA: 0x7FFAC8E75250 | overloaded x4
        public void InferSchema(){} // RVA: 0x7FFAC8E73A60
        public void IsEmpty(){} // RVA: 0x7FFAC8E73D80
        public void ReadXmlDiffgram(){} // RVA: 0x7FFAC8E73F70
        public void WriteXml(){} // RVA: 0x7FFAC8E76490
        public void Merge(){} // RVA: 0x7FFAC8E76750 | overloaded x2
        public void OnPropertyChanging(){} // RVA: 0x7FFAC8E76950
        public void OnMergeFailed(){} // RVA: 0x7FFAC8E76980
        public void RaiseMergeFailed(){} // RVA: 0x7FFAC8E76A00
        public void OnDataRowCreated(){} // RVA: 0x7FFAC8E76BE0
        public void OnClearFunctionCalled(){} // RVA: 0x7FFAC8E76C10
        public void OnInitialized(){} // RVA: 0x7FFAC8E76C40
        public void OnRemoveTable(){} // RVA: 0x7FFAC2F21310
        public void OnRemovedTable(){} // RVA: 0x7FFAC8E76CC0
        public void OnRemoveRelation(){} // RVA: 0x7FFAC2F21310
        public void OnRemoveRelationHack(){} // RVA: 0x7FFAC8D7CBA0
        public void RaisePropertyChanging(){} // RVA: 0x7FFAC8E76D10
        public void TopLevelTables(){} // RVA: 0x7FFAC8E76DA0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAC8E76FE0
        public void ValidateCaseConstraint(){} // RVA: 0x7FFAC8E77220
        public void ValidateLocaleConstraint(){} // RVA: 0x7FFAC8E775C0
        public void FindTable(){} // RVA: 0x7FFAC8E779F0
        public void ReadXmlSerializable(){} // RVA: 0x7FFAC8E77B70
        public void GetDataSetSchema(){} // RVA: 0x7FFAC8E78200
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC8E786D0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8E78910
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8E78A90
        public void get_MainTableName(){} // RVA: 0x7FFAC2FE9590
        public void set_MainTableName(){} // RVA: 0x7FFAC2FE95A0
        public void get_ObjectID(){} // RVA: 0x7FFAC37EE8C0
    }

    public class DataSetClearEventhandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DataTable : MarshalByValueComponent
    {
        public System.Data.DataSet CaseSensitive; // 0x20
        public System.Data.DataView AreIndexEventsSuspended; // 0x28
        public long IsInitialized; // 0x30
        public System.Data.DataRowCollection IsTypedDataTable; // 0x38
        public System.Data.DataColumnCollection SelfNested; // 0x40
        public System.Data.ConstraintCollection LiveIndexes; // 0x48
        public int RemotingFormat; // 0x50
        public System.Data.DataRelationCollection UKColumnPositionForInference; // 0x58
        public System.Data.DataRelationCollection ChildRelations; // 0x60
        public System.Data.RecordManager Columns; // 0x68
        public System.Collections.Generic.List`1<System.Data.Index> CompareInfo; // 0x70
        public System.Collections.Generic.List`1<System.Data.Index> Constraints; // 0x78
        public int DataSet; // 0x80
        public System.Data.PropertyCollection DefaultView; // 0x88
        public string DisplayExpressionInternal; // 0x90
        public string EnforceConstraints; // 0x98
        public string SuspendEnforceConstraints; // 0xA0
        public System.Data.DataExpression ExtendedProperties; // 0xA8
        public bool FormatProvider; // 0xB0
        public System.Globalization.CultureInfo Locale; // 0xB8
        public bool MinimumCapacity; // 0xC0
        public System.Globalization.CompareInfo RecordCapacity; // 0xC8
        public 0x6B0DB010 ElementColumnCount; // 0xD0
        public System.IFormatProvider ParentRelations; // 0xD8
        public System.StringComparer MergingData; // 0xE0
        public bool NestedParentRelations; // 0xE8
        public bool SchemaLoading; // 0xE9
        public string NestedParentsCount; // 0xF0
        public System.Data.DataColumn PrimaryKey; // 0xF8
        public System.Data.DataColumn Rows; // 0x100
        public System.Decimal TableName; // 0x108
        public System.Decimal EncodedTableName; // 0x118
        public bool Namespace; // 0x128
        public object Prefix; // 0x130
        public System.Data.UniqueConstraint XmlText; // 0x138
        public System.Data.IndexField[] MaxOccurs; // 0x140
        public System.Data.DataColumn[] MinOccurs; // 0x148
        public System.Data.Index Site; // 0x150
        public System.Data.Index System.ComponentModel.IListSource.ContainsListCollection; // 0x158
        public System.Data.Index NeedColumnChangeEvents; // 0x160
        public int TypeName; // 0x168
        public bool RowDiffId; // 0x16C
        public bool ObjectID; // 0x16D
        public bool _enforceConstraints; // 0x16E
        public bool _suspendEnforceConstraints; // 0x16F
        public bool fInitInProgress; // 0x170
        public bool _inLoad; // 0x171
        public bool _fInLoadDiffgram; // 0x172
        public byte _isTypedDataTable; // 0x173
        public System.Data.DataRow[] _emptyDataRowArray; // 0x178
        public System.ComponentModel.PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
        public System.Data.DataRelation[] _nestedParentRelations; // 0x188
        public System.Collections.Generic.List`1<System.Data.DataColumn> _dependentColumns; // 0x190
        public bool _mergingData; // 0x198
        public System.Data.DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
        public System.Data.DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
        public System.Data.DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
        public System.Data.DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
        public System.Data.DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
        public System.Data.DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
        public System.Data.DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
        public System.Data.DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
        public System.Data.DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
        public System.ComponentModel.PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
        public System.EventHandler _onInitialized; // 0x1F0
        public System.Data.DataRowBuilder _rowBuilder; // 0x1F8
        public System.Collections.Generic.List`1<System.Data.DataView> _delayedViews; // 0x200
        public System.Collections.Generic.List`1<System.Data.DataViewListener> _dataViewListeners; // 0x208
        public System.Collections.Hashtable _rowDiffId; // 0x210
        public System.Threading.ReaderWriterLockSlim _indexesLock; // 0x218
        public int _ukColumnPositionForInference; // 0x220
        public 0x6B1CEE50 _remotingFormat; // 0x224
        public int s_objectTypeCount;
        public int _objectID; // 0x228

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E389F0 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFAC8E38C40
        public void SerializeDataTable(){} // RVA: 0x7FFAC8E38D30
        public void DeserializeDataTable(){} // RVA: 0x7FFAC8E393A0
        public void SerializeTableSchema(){} // RVA: 0x7FFAC8E39730
        public void DeserializeTableSchema(){} // RVA: 0x7FFAC8E3C430
        public void SerializeConstraints(){} // RVA: 0x7FFAC8E3E200
        public void DeserializeConstraints(){} // RVA: 0x7FFAC8E3EA10
        public void SerializeExpressionColumns(){} // RVA: 0x7FFAC8E3F670
        public void DeserializeExpressionColumns(){} // RVA: 0x7FFAC8E3FAB0
        public void SerializeTableData(){} // RVA: 0x7FFAC8E3FCD0
        public void DeserializeTableData(){} // RVA: 0x7FFAC8E40DF0
        public void ConvertToRowState(){} // RVA: 0x7FFAC8E41D60
        public void GetRowAndColumnErrors(){} // RVA: 0x7FFAC8E41E40
        public void ConvertToRowError(){} // RVA: 0x7FFAC8E42210
        public void get_CaseSensitive(){} // RVA: 0x7FFAC3FD4640
        public void set_CaseSensitive(){} // RVA: 0x7FFAC8E425B0
        public void get_AreIndexEventsSuspended(){} // RVA: 0x7FFAC8E42670
        public void RestoreIndexEvents(){} // RVA: 0x7FFAC8E42680
        public void SuspendIndexEvents(){} // RVA: 0x7FFAC8E42A20
        public void get_IsInitialized(){} // RVA: 0x7FFAC8E42AB0
        public void get_IsTypedDataTable(){} // RVA: 0x7FFAC8E42AC0
        public void SetCaseSensitiveValue(){} // RVA: 0x7FFAC8E42B70
        public void ShouldSerializeCaseSensitive(){} // RVA: 0x7FFAC8E42E60
        public void get_SelfNested(){} // RVA: 0x7FFAC8E42E70
        public void get_LiveIndexes(){} // RVA: 0x7FFAC8E43080
        public void get_RemotingFormat(){} // RVA: 0x7FFAC8E43140
        public void set_RemotingFormat(){} // RVA: 0x7FFAC8E43150
        public void get_UKColumnPositionForInference(){} // RVA: 0x7FFAC8B3F6F0
        public void set_UKColumnPositionForInference(){} // RVA: 0x7FFAC8B3F700
        public void get_ChildRelations(){} // RVA: 0x7FFAC8E431D0
        public void get_Columns(){} // RVA: 0x7FFAC2F9E740
        public void get_CompareInfo(){} // RVA: 0x7FFAC8E43280
        public void get_Constraints(){} // RVA: 0x7FFAC2F9C730
        public void ResetConstraints(){} // RVA: 0x7FFAC8E43320
        public void get_DataSet(){} // RVA: 0x7FFAC2F4F0C0
        public void SetDataSet(){} // RVA: 0x7FFAC8E43340
        public void get_DefaultView(){} // RVA: 0x7FFAC8E434B0
        public void get_DisplayExpressionInternal(){} // RVA: 0x7FFAC8E43680
        public void get_EnforceConstraints(){} // RVA: 0x7FFAC8E43720
        public void set_EnforceConstraints(){} // RVA: 0x7FFAC8E43750
        public void get_SuspendEnforceConstraints(){} // RVA: 0x7FFAC8E43790
        public void set_SuspendEnforceConstraints(){} // RVA: 0x7FFAC8E437A0
        public void EnableConstraints(){} // RVA: 0x7FFAC8E437B0
        public void get_ExtendedProperties(){} // RVA: 0x7FFAC8E43D30
        public void get_FormatProvider(){} // RVA: 0x7FFAC8E43E00
        public void get_Locale(){} // RVA: 0x7FFAC2F8C0B0
        public void set_Locale(){} // RVA: 0x7FFAC8E43EF0
        public void SetLocaleValue(){} // RVA: 0x7FFAC8E44480
        public void ShouldSerializeLocale(){} // RVA: 0x7FFAC2F424C0
        public void get_MinimumCapacity(){} // RVA: 0x7FFAC8E44B40
        public void set_MinimumCapacity(){} // RVA: 0x7FFAC8E44B60
        public void get_RecordCapacity(){} // RVA: 0x7FFAC8E44BB0
        public void get_ElementColumnCount(){} // RVA: 0x7FFAC30F10E0
        public void set_ElementColumnCount(){} // RVA: 0x7FFAC8E44BD0
        public void get_ParentRelations(){} // RVA: 0x7FFAC8E44C20
        public void get_MergingData(){} // RVA: 0x7FFAC8B3EBF0
        public void set_MergingData(){} // RVA: 0x7FFAC8B3EC00
        public void get_NestedParentRelations(){} // RVA: 0x7FFAC35410C0
        public void get_SchemaLoading(){} // RVA: 0x7FFAC33AC360
        public void CacheNestedParent(){} // RVA: 0x7FFAC8E44CD0
        public void FindNestedParentRelations(){} // RVA: 0x7FFAC8E44D40
        public void get_NestedParentsCount(){} // RVA: 0x7FFAC8E45090
        public void get_PrimaryKey(){} // RVA: 0x7FFAC8E45300
        public void set_PrimaryKey(){} // RVA: 0x7FFAC8E45370
        public void get_Rows(){} // RVA: 0x7FFAC31D0140
        public void get_TableName(){} // RVA: 0x7FFAC32EF640
        public void set_TableName(){} // RVA: 0x7FFAC8E45930
        public void get_EncodedTableName(){} // RVA: 0x7FFAC8E460F0
        public void GetInheritedNamespace(){} // RVA: 0x7FFAC8E46200
        public void get_Namespace(){} // RVA: 0x7FFAC8E46480
        public void set_Namespace(){} // RVA: 0x7FFAC8E46510
        public void IsNamespaceInherited(){} // RVA: 0x7FFAC8E467D0
        public void CheckCascadingNamespaceConflict(){} // RVA: 0x7FFAC8E467E0
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7FFAC8E46AE0
        public void CheckNamespaceValidityForNestedParentRelations(){} // RVA: 0x7FFAC8E46E40
        public void DoRaiseNamespaceChange(){} // RVA: 0x7FFAC8E470F0
        public void BeginInit(){} // RVA: 0x7FFAC8E47630
        public void EndInit(){} // RVA: 0x7FFAC8E47640
        public void get_Prefix(){} // RVA: 0x7FFAC3543900
        public void set_Prefix(){} // RVA: 0x7FFAC8E47BF0
        public void get_XmlText(){} // RVA: 0x7FFAC3331F50
        public void set_XmlText(){} // RVA: 0x7FFAC8E47E40
        public void get_MaxOccurs(){} // RVA: 0x7FFAC8E48090
        public void set_MaxOccurs(){} // RVA: 0x7FFAC8E480A0
        public void get_MinOccurs(){} // RVA: 0x7FFAC8A33F20
        public void set_MinOccurs(){} // RVA: 0x7FFAC8A33F30
        public void SetKeyValues(){} // RVA: 0x7FFAC8E480B0
        public void FindByIndex(){} // RVA: 0x7FFAC8E48130
        public void FindMergeTarget(){} // RVA: 0x7FFAC8E481D0
        public void SetMergeRecords(){} // RVA: 0x7FFAC8E482A0
        public void MergeRow(){} // RVA: 0x7FFAC8E483E0
        public void CreateInstance(){} // RVA: 0x7FFAC8E48C20
        public void Clone(){} // RVA: 0x7FFAC8E48CC0 | overloaded x2
        public void IncrementalCloneTo(){} // RVA: 0x7FFAC8E48E40
        public void CloneHierarchy(){} // RVA: 0x7FFAC8E49100
        public void CloneTo(){} // RVA: 0x7FFAC8E49560
        public void add_Initialized(){} // RVA: 0x7FFAC8E4A6B0
        public void remove_Initialized(){} // RVA: 0x7FFAC8E4A7B0
        public void get_Site(){} // RVA: 0x7FFAC2F3C380
        public void set_Site(){} // RVA: 0x7FFAC8E4A8B0
        public void AddRow(){} // RVA: 0x7FFAC8E4AA60
        public void InsertRow(){} // RVA: 0x7FFAC8E4C590 | overloaded x3
        public void CheckNotModifying(){} // RVA: 0x7FFAC8E4AED0
        public void Clear(){} // RVA: 0x7FFAC8E4AF10 | overloaded x2
        public void CascadeAll(){} // RVA: 0x7FFAC8E4B910
        public void CommitRow(){} // RVA: 0x7FFAC8E4BA40
        public void Compare(){} // RVA: 0x7FFAC8E4BBC0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC8E4BD40
        public void IsSuffix(){} // RVA: 0x7FFAC8E4BDB0
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x7FFAC2F21320
        public void DeleteRow(){} // RVA: 0x7FFAC8E4BE20
        public void FormatSortString(){} // RVA: 0x7FFAC8E4BED0
        public void FreeRecord(){} // RVA: 0x7FFAC8E4C020
        public void GetIndex(){} // RVA: 0x7FFAC8E4C090 | overloaded x2
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7FFAC8E4C3A0
        public void GetListeners(){} // RVA: 0x7FFAC3544780
        public void GetSpecialHashCode(){} // RVA: 0x7FFAC8E4C3B0
        public void NewRecord(){} // RVA: 0x7FFAC8E4CA50 | overloaded x2
        public void NewUninitializedRecord(){} // RVA: 0x7FFAC8E4CA30
        public void NewEmptyRow(){} // RVA: 0x7FFAC8E4CB60
        public void NewUninitializedRow(){} // RVA: 0x7FFAC8E4CBE0
        public void NewRow(){} // RVA: 0x7FFAC8E4D170 | overloaded x2
        public void CreateEmptyRow(){} // RVA: 0x7FFAC8E4CD30
        public void NewRowCreated(){} // RVA: 0x7FFAC8E4D070
        public void NewRowFromBuilder(){} // RVA: 0x7FFAC8E4D260
        public void GetRowType(){} // RVA: 0x7FFAC8E4D3D0
        public void NewRowArray(){} // RVA: 0x7FFAC8E4D480
        public void get_NeedColumnChangeEvents(){} // RVA: 0x7FFAC8E4D620
        public void OnColumnChanging(){} // RVA: 0x7FFAC8E4D660
        public void OnColumnChanged(){} // RVA: 0x7FFAC8E4D720
        public void OnPropertyChanging(){} // RVA: 0x7FFAC8E4D7E0
        public void OnRemoveColumnInternal(){} // RVA: 0x7FFAC8E4D8A0
        public void OnRemoveColumn(){} // RVA: 0x7FFAC2F21310
        public void OnRowChanged(){} // RVA: 0x7FFAC8E4DA20 | overloaded x2
        public void OnRowChanging(){} // RVA: 0x7FFAC8E4DAE0 | overloaded x2
        public void OnRowDeleting(){} // RVA: 0x7FFAC8E4DBA0
        public void OnRowDeleted(){} // RVA: 0x7FFAC8E4DC60
        public void OnTableCleared(){} // RVA: 0x7FFAC8E4DD20
        public void OnTableClearing(){} // RVA: 0x7FFAC8E4DDE0
        public void OnTableNewRow(){} // RVA: 0x7FFAC8E4DEA0
        public void OnInitialized(){} // RVA: 0x7FFAC8E4DF60
        public void ParseSortString(){} // RVA: 0x7FFAC8E4E060
        public void RaisePropertyChanging(){} // RVA: 0x7FFAC8E4E900
        public void RecordChanged(){} // RVA: 0x7FFAC8E4EAB0 | overloaded x2
        public void RecordStateChanged(){} // RVA: 0x7FFAC8E4ED70 | overloaded x2
        public void RemoveRecordFromIndexes(){} // RVA: 0x7FFAC8E4EF50
        public void InsertRecordToIndexes(){} // RVA: 0x7FFAC8E4F1C0
        public void SilentlySetValue(){} // RVA: 0x7FFAC8E4F3E0
        public void RemoveRow(){} // RVA: 0x7FFAC8E4F630
        public void Reset(){} // RVA: 0x7FFAC8E4F9E0
        public void ResetIndexes(){} // RVA: 0x7FFAC8E4FCB0
        public void ResetInternalIndexes(){} // RVA: 0x7FFAC8E4FCC0
        public void RollbackRow(){} // RVA: 0x7FFAC8E4FE50
        public void RaiseRowChanged(){} // RVA: 0x7FFAC8E4FEF0
        public void RaiseRowChanging(){} // RVA: 0x7FFAC8E50400 | overloaded x2
        public void SetNewRecord(){} // RVA: 0x7FFAC8E505C0
        public void SetNewRecordWorker(){} // RVA: 0x7FFAC8E50640
        public void SetOldRecord(){} // RVA: 0x7FFAC8E512F0
        public void RestoreShadowIndexes(){} // RVA: 0x7FFAC8E51810
        public void SetShadowIndexes(){} // RVA: 0x7FFAC8E51880
        public void ShadowIndexCopy(){} // RVA: 0x7FFAC8E51910
        public void ToString(){} // RVA: 0x7FFAC8E519F0
        public void UpdatingCurrent(){} // RVA: 0x7FFAC8E51AE0
        public void AddUniqueKey(){} // RVA: 0x7FFAC8E51E40 | overloaded x2
        public void AddForeignKey(){} // RVA: 0x7FFAC8E51E50
        public void UpdatePropertyDescriptorCollectionCache(){} // RVA: 0x7FFAC8E51F10
        public void GetPropertyDescriptorCollection(){} // RVA: 0x7FFAC8E51F70
        public void get_TypeName(){} // RVA: 0x7FFAC8E52410
        public void set_TypeName(){} // RVA: 0x7FFAC39A79B0
        public void Merge(){} // RVA: 0x7FFAC8E524E0 | overloaded x2
        public void WriteXml(){} // RVA: 0x7FFAC8E526E0
        public void CheckForClosureOnExpressions(){} // RVA: 0x7FFAC8E52A50
        public void CheckForClosureOnExpressionTables(){} // RVA: 0x7FFAC8E52B20
        public void WriteXmlSchema(){} // RVA: 0x7FFAC8E52EB0
        public void RestoreConstraint(){} // RVA: 0x7FFAC8E53220
        public void IsEmptyXml(){} // RVA: 0x7FFAC8E53290
        public void ReadXml(){} // RVA: 0x7FFAC8E535B0
        public void ReadEndElement(){} // RVA: 0x7FFAC8E54B80
        public void ReadXDRSchema(){} // RVA: 0x7FFAC8E54C40
        public void MoveToElement(){} // RVA: 0x7FFAC8E54CC0
        public void ReadXmlDiffgram(){} // RVA: 0x7FFAC8E54DA0
        public void ReadXSDSchema(){} // RVA: 0x7FFAC8E558A0
        public void ReadXmlSchema(){} // RVA: 0x7FFAC8E55B70
        public void CreateTableList(){} // RVA: 0x7FFAC8E56CA0
        public void CreateRelationList(){} // RVA: 0x7FFAC8E56FE0
        public void GetDataTableSchema(){} // RVA: 0x7FFAC8E57360
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC8654000
        public void GetSchema(){} // RVA: 0x7FFAC8E57760
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8E57990
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8E57A60
        public void ReadXmlSerializable(){} // RVA: 0x7FFAC8E57AB0
        public void get_RowDiffId(){} // RVA: 0x7FFAC8E57AD0
        public void get_ObjectID(){} // RVA: 0x7FFAC44F99D0
        public void AddDependentColumn(){} // RVA: 0x7FFAC8E57B90
        public void RemoveDependentColumn(){} // RVA: 0x7FFAC8E57CB0
        public void EvaluateExpressions(){} // RVA: 0x7FFAC8E58690 | overloaded x3
        public void EvaluateDependentExpressions(){} // RVA: 0x7FFAC8E58B00 | overloaded x2
    }

    public class DataTableClearEventArgs : EventArgs
    {
        public System.Data.DataTable <Table>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E9C990
    }

    public class DataTableClearEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DataTableCollection : InternalDataCollectionBase
    {
        public System.Data.DataSet List; // 0x10
        public System.Collections.ArrayList ObjectID; // 0x18
        public int Item; // 0x20
        public System.Data.DataTable[] Item; // 0x28
        public System.ComponentModel.CollectionChangeEventHandler Item; // 0x30
        public System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
        public int s_objectTypeCount;
        public int _objectID; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E9CA30
        public void get_List(){} // RVA: 0x7FFAC2F247C0
        public void get_ObjectID(){} // RVA: 0x7FFAC2FC2080
        public void get_Item(){} // RVA: 0x7FFAC8E9CDE0 | overloaded x3
        public void GetTable(){} // RVA: 0x7FFAC8E9CF10
        public void GetTableSmart(){} // RVA: 0x7FFAC8E9D0A0
        public void Add(){} // RVA: 0x7FFAC8E9D250
        public void add_CollectionChanged(){} // RVA: 0x7FFAC8E9D460
        public void remove_CollectionChanged(){} // RVA: 0x7FFAC8E9D5C0
        public void ArrayAdd(){} // RVA: 0x7FFAC8E9D720
        public void AssignName(){} // RVA: 0x7FFAC8E9D750
        public void BaseAdd(){} // RVA: 0x7FFAC8E9D7C0
        public void BaseGroupSwitch(){} // RVA: 0x7FFAC8E9D9A0
        public void BaseRemove(){} // RVA: 0x7FFAC8E9DB40
        public void CanRemove(){} // RVA: 0x7FFAC8E9DC00
        public void Clear(){} // RVA: 0x7FFAC8E9E0F0
        public void Contains(){} // RVA: 0x7FFAC8E9E5D0 | overloaded x3
        public void IndexOf(){} // RVA: 0x7FFAC8E9E8D0 | overloaded x3
        public void ReplaceFromInference(){} // RVA: 0x7FFAC8E9E960
        public void InternalIndexOf(){} // RVA: 0x7FFAC8E9EBF0 | overloaded x2
        public void FinishInitCollection(){} // RVA: 0x7FFAC8E9EE00
        public void MakeName(){} // RVA: 0x7FFAC8E9EEC0
        public void OnCollectionChanged(){} // RVA: 0x7FFAC8E9EF70
        public void OnCollectionChanging(){} // RVA: 0x7FFAC8E9F030
        public void RegisterName(){} // RVA: 0x7FFAC8E9F0F0
        public void Remove(){} // RVA: 0x7FFAC8E9F510
        public void UnregisterName(){} // RVA: 0x7FFAC8E9F680
    }

    public class DataTableNewRowEventArgs : EventArgs
    {
        public System.Data.DataRow <Row>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E9F810
    }

    public class DataTableNewRowEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DataTablePropertyDescriptor : PropertyDescriptor
    {
        public System.Data.DataTable Table; // 0x88

        // ── Methods ──
        public void get_Table(){} // RVA: 0x7FFAC2F60010
        public void .ctor(){} // RVA: 0x7FFAC8E9F8B0
        public void get_ComponentType(){} // RVA: 0x7FFAC8E9F950
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_PropertyType(){} // RVA: 0x7FFAC8E9FA00
        public void Equals(){} // RVA: 0x7FFAC8E9FAB0
        public void GetHashCode(){} // RVA: 0x7FFAC8E8D110
        public void CanResetValue(){} // RVA: 0x7FFAC2F21320
        public void GetValue(){} // RVA: 0x7FFAC8E9FB50
        public void ResetValue(){} // RVA: 0x7FFAC2F21310
        public void SetValue(){} // RVA: 0x7FFAC2F21310
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC2F21320
    }

    public class DataTableTypeConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E9FC30
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC2F21320
    }

    public class DataTextReader : XmlReader
    {
        public System.Xml.XmlReader Settings; // 0x10

        // ── Methods ──
        public void CreateReader(){} // RVA: 0x7FFAC8F0AA80
        public void .ctor(){} // RVA: 0x7FFAC8F0AB50
        public void get_Settings(){} // RVA: 0x7FFAC87BB0A0
        public void get_NodeType(){} // RVA: 0x7FFAC880FE40
        public void get_Name(){} // RVA: 0x7FFAC88045A0
        public void get_LocalName(){} // RVA: 0x7FFAC33088E0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC84AA500
        public void get_Prefix(){} // RVA: 0x7FFAC84AA530
        public void get_Value(){} // RVA: 0x7FFAC4426B30
        public void get_Depth(){} // RVA: 0x7FFAC8D71650
        public void get_BaseURI(){} // RVA: 0x7FFAC8D71620
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC8D711F0
        public void get_IsDefault(){} // RVA: 0x7FFAC8D71270
        public void get_QuoteChar(){} // RVA: 0x7FFAC84AA3A0
        public void get_XmlSpace(){} // RVA: 0x7FFAC84AA770
        public void get_XmlLang(){} // RVA: 0x7FFAC84AA5F0
        public void get_AttributeCount(){} // RVA: 0x7FFAC8B8D5F0
        public void GetAttribute(){} // RVA: 0x7FFAC8F0AC50 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC8F0ACB0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC84AA740
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC8599520
        public void MoveToElement(){} // RVA: 0x7FFAC8599550
        public void ReadAttributeValue(){} // RVA: 0x7FFAC8803C70
        public void Read(){} // RVA: 0x7FFAC32F0BD0
        public void get_EOF(){} // RVA: 0x7FFAC8F0ACE0
        public void Close(){} // RVA: 0x7FFAC8804760
        public void get_ReadState(){} // RVA: 0x7FFAC8F0AD10
        public void Skip(){} // RVA: 0x7FFAC83D00F0
        public void get_NameTable(){} // RVA: 0x7FFAC88037A0
        public void LookupNamespace(){} // RVA: 0x7FFAC8F0AD40
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC8F0AD70
        public void ResolveEntity(){} // RVA: 0x7FFAC8F0ADA0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFAC85A45F0
        public void ReadString(){} // RVA: 0x7FFAC8F0ADD0
    }

    public class DataTextWriter : XmlWriter
    {
        public System.Xml.XmlWriter BaseStream; // 0x18

        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFAC8F0A5D0
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void get_BaseStream(){} // RVA: 0x7FFAC8F0A660
        public void WriteStartDocument(){} // RVA: 0x7FFAC8F0A6F0 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFAC85CFDD0
        public void WriteDocType(){} // RVA: 0x7FFAC8F0A720
        public void WriteStartElement(){} // RVA: 0x7FFAC8F0A750
        public void WriteEndElement(){} // RVA: 0x7FFAC8459460
        public void WriteFullEndElement(){} // RVA: 0x7FFAC8F0A780
        public void WriteStartAttribute(){} // RVA: 0x7FFAC8F0A7B0
        public void WriteEndAttribute(){} // RVA: 0x7FFAC8459490
        public void WriteCData(){} // RVA: 0x7FFAC8F0A7E0
        public void WriteComment(){} // RVA: 0x7FFAC8F0A810
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC8F0A840
        public void WriteEntityRef(){} // RVA: 0x7FFAC8F0A870
        public void WriteCharEntity(){} // RVA: 0x7FFAC8F0A8A0
        public void WriteWhitespace(){} // RVA: 0x7FFAC8F0A8D0
        public void WriteString(){} // RVA: 0x7FFAC8F0A900
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC8F0A930
        public void WriteChars(){} // RVA: 0x7FFAC8F0A960
        public void WriteRaw(){} // RVA: 0x7FFAC8F0A9C0 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC8F0A9F0
        public void WriteBinHex(){} // RVA: 0x7FFAC8F0AA20
        public void get_WriteState(){} // RVA: 0x7FFAC8525E70
        public void Close(){} // RVA: 0x7FFAC8525E10
        public void Flush(){} // RVA: 0x7FFAC8525DE0
        public void LookupPrefix(){} // RVA: 0x7FFAC8F0AA50
    }

    public class DataView : MarshalByValueComponent
    {
        public System.Data.DataViewManager AllowDelete; // 0x20
        public System.Data.DataTable AllowEdit; // 0x28
        public bool AllowNew; // 0x30
        public System.Data.Index Count; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.Data.Index> CountFromIndex; // 0x40
        public string DataViewManager; // 0x48
        public System.Comparison`1<System.Data.DataRow> IsInitialized; // 0x50
        public System.Data.IFilter IsOpen; // 0x58
        public 0x6B1CF320 System.Collections.ICollection.IsSynchronized; // 0x60
        public bool RowFilter; // 0x64
        public bool RowStateFilter; // 0x65
        public bool Sort; // 0x66
        public bool SortComparison; // 0x67
        public bool System.Collections.ICollection.SyncRoot; // 0x68
        public bool Table; // 0x69
        public System.Data.DataRow System.Collections.IList.Item; // 0x70
        public System.ComponentModel.ListChangedEventArgs Item; // 0x78
        public System.ComponentModel.ListChangedEventHandler System.Collections.IList.IsReadOnly; // 0x80
        public System.ComponentModel.ListChangedEventArgs System.Collections.IList.IsFixedSize;
        public System.Data.DataTable System.ComponentModel.IBindingList.AllowNew; // 0x88
        public string System.ComponentModel.IBindingList.AllowEdit; // 0x90
        public string System.ComponentModel.IBindingList.AllowRemove; // 0x98
        public 0x6B1CF320 System.ComponentModel.IBindingList.SupportsChangeNotification; // 0xA0
        public bool System.ComponentModel.IBindingList.SupportsSearching; // 0xA4
        public bool System.ComponentModel.IBindingList.SupportsSorting; // 0xA5
        public System.Collections.Generic.Dictionary`2<System.Data.DataRow,System.Data.DataRowView> System.ComponentModel.IBindingList.IsSorted; // 0xA8
        public System.Collections.Generic.Dictionary`2<System.Data.DataRow,System.Data.DataRowView> System.ComponentModel.IBindingList.SortProperty; // 0xB0
        public System.Data.DataViewListener System.ComponentModel.IBindingList.SortDirection; // 0xB8
        public int System.ComponentModel.IBindingListView.Filter; // 0x8
        public int System.ComponentModel.IBindingListView.SortDescriptions; // 0xC0
        public System.EventHandler System.ComponentModel.IBindingListView.SupportsAdvancedSorting; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EA0240 | overloaded x2
        public void get_AllowDelete(){} // RVA: 0x7FFAC2FE9570
        public void get_AllowEdit(){} // RVA: 0x7FFAC8EA02C0
        public void get_AllowNew(){} // RVA: 0x7FFAC8EA02D0
        public void get_Count(){} // RVA: 0x7FFAC8EA02E0
        public void get_CountFromIndex(){} // RVA: 0x7FFAC8EA0330
        public void get_DataViewManager(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IsInitialized(){} // RVA: 0x7FFAC8EA0360
        public void get_IsOpen(){} // RVA: 0x7FFAC8EA0370
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_RowFilter(){} // RVA: 0x7FFAC8EA0380
        public void set_RowFilter(){} // RVA: 0x7FFAC8EA0420
        public void get_RowStateFilter(){} // RVA: 0x7FFAC3138C20
        public void set_RowStateFilter(){} // RVA: 0x7FFAC8EA06C0
        public void get_Sort(){} // RVA: 0x7FFAC8EA0810
        public void set_Sort(){} // RVA: 0x7FFAC8EA09B0
        public void get_SortComparison(){} // RVA: 0x7FFAC2FC20E0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void get_Table(){} // RVA: 0x7FFAC2F4F130
        public void set_Table(){} // RVA: 0x7FFAC8EA0CB0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC8EA0FC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC8EA1030
        public void get_Item(){} // RVA: 0x7FFAC8EA0FC0
        public void AddNew(){} // RVA: 0x7FFAC8EA1060
        public void BeginInit(){} // RVA: 0x7FFAC8EA13D0
        public void EndInit(){} // RVA: 0x7FFAC8EA13E0
        public void CheckOpen(){} // RVA: 0x7FFAC8EA1810
        public void CheckSort(){} // RVA: 0x7FFAC8EA1850
        public void Close(){} // RVA: 0x7FFAC8EA18B0
        public void CopyTo(){} // RVA: 0x7FFAC8EA1B20 | overloaded x2
        public void Delete(){} // RVA: 0x7FFAC8EA1DE0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC8EA1F40
        public void FinishAddNew(){} // RVA: 0x7FFAC8EA1FB0
        public void GetEnumerator(){} // RVA: 0x7FFAC8EA2230
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC8EA22E0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC8EA2370
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC8EA23A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC8EA2430
        public void IndexOf(){} // RVA: 0x7FFAC8EA24C0
        public void IndexOfDataRowView(){} // RVA: 0x7FFAC8EA25E0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC8EA2690
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC8EA26C0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC8EA1DB0
        public void GetFindIndex(){} // RVA: 0x7FFAC8EA27A0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFAC8EA02D0
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFAC7DB2890
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFAC8EA02C0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFAC2FE9570
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFAC8EA29D0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFAC8EA2A00
        public void GetSortProperty(){} // RVA: 0x7FFAC8EA2AA0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFAC8EA2B30
        public void add_ListChanged(){} // RVA: 0x7FFAC8EA2B70
        public void remove_ListChanged(){} // RVA: 0x7FFAC8EA2CD0
        public void add_Initialized(){} // RVA: 0x7FFAC8EA2E30
        public void remove_Initialized(){} // RVA: 0x7FFAC8EA2F20
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFAC8EA3010
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFAC8EA3060
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFAC8EA3090
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFAC8EA3350
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFAC8EA33A0
        public void System.ComponentModel.IBindingListView.ApplySort(){} // RVA: 0x7FFAC8EA3460
        public void CreateSortString(){} // RVA: 0x7FFAC8EA3840
        public void System.ComponentModel.IBindingListView.RemoveFilter(){} // RVA: 0x7FFAC8EA39C0
        public void System.ComponentModel.IBindingListView.get_Filter(){} // RVA: 0x7FFAC8EA3A90
        public void System.ComponentModel.IBindingListView.set_Filter(){} // RVA: 0x7FFAC8EA3AB0
        public void System.ComponentModel.IBindingListView.get_SortDescriptions(){} // RVA: 0x7FFAC8EA3AD0
        public void GetSortDescriptions(){} // RVA: 0x7FFAC8EA3AE0
        public void System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingListView.get_SupportsFiltering(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFAC8EA3EA0
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFAC8EA3F50
        public void GetFilter(){} // RVA: 0x7FFAC2FE9500
        public void GetRecord(){} // RVA: 0x7FFAC8EA4030
        public void GetRow(){} // RVA: 0x7FFAC8EA40F0
        public void GetRowView(){} // RVA: 0x7FFAC8EA42F0 | overloaded x2
        public void IndexListChanged(){} // RVA: 0x7FFAC8EA4350
        public void IndexListChangedInternal(){} // RVA: 0x7FFAC8EA43E0
        public void MaintainDataView(){} // RVA: 0x7FFAC8EA44B0
        public void OnListChanged(){} // RVA: 0x7FFAC8EA47D0
        public void OnInitialized(){} // RVA: 0x7FFAC8EA4B90
        public void Reset(){} // RVA: 0x7FFAC8EA4C10
        public void ResetRowViewCache(){} // RVA: 0x7FFAC8EA4C40
        public void SetDataViewManager(){} // RVA: 0x7FFAC8EA5020
        public void SetIndex(){} // RVA: 0x7FFAC8EA52A0
        public void SetIndex2(){} // RVA: 0x7FFAC8EA52C0
        public void UpdateIndex(){} // RVA: 0x7FFAC8EA5680 | overloaded x3
        public void ChildRelationCollectionChanged(){} // RVA: 0x7FFAC8EA59A0
        public void ParentRelationCollectionChanged(){} // RVA: 0x7FFAC8EA5BF0
        public void ColumnCollectionChanged(){} // RVA: 0x7FFAC8EA5E40
        public void ColumnCollectionChangedInternal(){} // RVA: 0x7FFAC8EA60F0
        public void get_ObjectID(){} // RVA: 0x7FFAC313B720
        public void .cctor(){} // RVA: 0x7FFAC8EA6110
    }

    public class DataViewListener : Object
    {
        public System.WeakReference _dvWeak; // 0x10
        public System.Data.DataTable _table; // 0x18
        public System.Data.Index _index; // 0x20
        public int _objectID; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EA62D0
        public void ChildRelationCollectionChanged(){} // RVA: 0x7FFAC8EA63B0
        public void ParentRelationCollectionChanged(){} // RVA: 0x7FFAC8EA64A0
        public void ColumnCollectionChanged(){} // RVA: 0x7FFAC8EA6590
        public void MaintainDataView(){} // RVA: 0x7FFAC8EA6680
        public void IndexListChanged(){} // RVA: 0x7FFAC8EA6770
        public void RegisterMetaDataEvents(){} // RVA: 0x7FFAC8EA6900
        public void UnregisterMetaDataEvents(){} // RVA: 0x7FFAC8EA6D30 | overloaded x2
        public void RegisterListChangedEvent(){} // RVA: 0x7FFAC8EA72A0
        public void UnregisterListChangedEvent(){} // RVA: 0x7FFAC8EA74F0
        public void CleanUp(){} // RVA: 0x7FFAC8EA76B0
        public void RegisterListener(){} // RVA: 0x7FFAC8EA76D0
    }

    public class DataViewManager : MarshalByValueComponent
    {
        public System.Data.DataViewSettingCollection DataSet; // 0x20
        public System.Data.DataSet DataViewSettings; // 0x28
        public System.Data.DataViewManagerListItemTypeDescriptor System.Collections.ICollection.Count; // 0x30
        public bool System.Collections.ICollection.SyncRoot; // 0x38
        public int System.Collections.ICollection.IsSynchronized; // 0x3C
        public System.NotSupportedException System.Collections.IList.IsReadOnly;
        public System.ComponentModel.ListChangedEventHandler System.Collections.IList.IsFixedSize; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EA79A0
        public void get_DataSet(){} // RVA: 0x7FFAC2F4F130
        public void get_DataViewSettings(){} // RVA: 0x7FFAC2F4F0C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8EA7E90
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC3013AF0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC8EA7F20
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC31D95E0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC8EA7FE0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC8EA8010
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC8EA8040
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC8EA8070
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC8EA8080
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC8EA80A0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC8EA80D0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC8EA8100
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFAC8EA8130
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFAC8EA8180
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFAC8EA81D0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFAC8EA8220
        public void add_ListChanged(){} // RVA: 0x7FFAC8EA8270
        public void remove_ListChanged(){} // RVA: 0x7FFAC8EA8360
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFAC2F21310
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFAC8EA8450
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFAC8EA84A0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFAC2F21310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFAC8EA84F0
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFAC8EA8540
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFAC8EA8610
        public void CreateDataView(){} // RVA: 0x7FFAC8EA8770
        public void OnListChanged(){} // RVA: 0x7FFAC8EA8820
        public void TableCollectionChanged(){} // RVA: 0x7FFAC8EA8910
        public void RelationCollectionChanged(){} // RVA: 0x7FFAC8EA8BC0
        public void .cctor(){} // RVA: 0x7FFAC8EA8E10
    }

    public class DataViewManagerListItemTypeDescriptor : Object
    {
        public System.Data.DataViewManager _dataViewManager; // 0x10
        public System.ComponentModel.PropertyDescriptorCollection _propsCollection; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetDataView(){} // RVA: 0x7FFAC8EA8F00
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFAC8EA8F80
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFAC8EA9020 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFAC8EA90B0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFAC44F81E0
    }

    public class DataViewSetting : Object
    {
        public System.Data.DataViewManager ApplyDefaultSort; // 0x10
        public System.Data.DataTable RowFilter; // 0x18
        public string RowStateFilter; // 0x20
        public string Sort; // 0x28
        public 0x6B1CF320 _rowStateFilter; // 0x30
        public bool _applyDefaultSort; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EA93A0
        public void get_ApplyDefaultSort(){} // RVA: 0x7FFAC2F57C20
        public void SetDataViewManager(){} // RVA: 0x7FFAC8E8FD30
        public void SetDataTable(){} // RVA: 0x7FFAC8EA94B0
        public void get_RowFilter(){} // RVA: 0x7FFAC2F4F130
        public void get_RowStateFilter(){} // RVA: 0x7FFAC2F7CCD0
        public void get_Sort(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class DataViewSettingCollection : Object
    {
        public System.Data.DataViewManager Item; // 0x10
        public System.Collections.Hashtable Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EA9510
        public void get_Item(){} // RVA: 0x7FFAC8EA9660
        public void set_Item(){} // RVA: 0x7FFAC8EA9870
        public void CopyTo(){} // RVA: 0x7FFAC8EA99A0
        public void get_Count(){} // RVA: 0x7FFAC8EA9B70
        public void GetEnumerator(){} // RVA: 0x7FFAC8EA9BC0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void Remove(){} // RVA: 0x7FFAC8EA9C20
    }

    public class DefaultValueTypeConverter : StringConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ConvertTo(){} // RVA: 0x7FFAC8EA9FD0
        public void ConvertFrom(){} // RVA: 0x7FFAC8EAA170
    }

    public class DeletedRowInaccessibleException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E63020 | overloaded x3
    }

    public class DuplicateNameException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E63090 | overloaded x3
    }

}