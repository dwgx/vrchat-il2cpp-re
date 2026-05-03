// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 41
// Methods: 1066

namespace ThirdParty.DotNet.System.Data
{
    public class DataColumn : MarshalByValueComponent
    {
        public bool _allowNull; // 0x20
        public string _caption; // 0x28
        public string _columnName; // 0x30
        public System.Type _dataType; // 0x38
        public 0x665CB3C4 _storageType; // 0x40
        public object _defaultValue; // 0x48
        public 0x665C876C _dateTimeMode; // 0x50
        public System.Data.DataExpression _expression; // 0x58
        public int _maxLength; // 0x60
        public int _ordinal; // 0x64
        public bool _readOnly; // 0x68
        public System.Data.Index _sortIndex; // 0x70
        public System.Data.DataTable _table; // 0x78
        public bool _unique; // 0x80
        public 0x665C9634 _columnMapping; // 0x84
        public int _hashCode; // 0x88
        public int _errors; // 0x8C
        public bool _isSqlType; // 0x90
        public bool _implementsINullable; // 0x91
        public bool _implementsIChangeTracking; // 0x92
        public bool _implementsIRevertibleChangeTracking; // 0x93
        public bool _implementsIXMLSerializable; // 0x94
        public bool _defaultValueIsNull; // 0x95
        public System.Collections.Generic.List`1<System.Data.DataColumn> _dependentColumns; // 0x98
        public System.Data.PropertyCollection _extendedProperties; // 0xA0
        public System.Data.Common.DataStorage _storage; // 0xA8
        public System.Data.AutoIncrementValue _autoInc; // 0xB0
        public string _columnUri; // 0xB8
        public string _columnPrefix; // 0xC0
        public string _encodedColumnName; // 0xC8
        public System.Data.SimpleType _simpleType; // 0xD0
        public int s_objectTypeCount;
        public int _objectID; // 0xD8
        public string _xmlDataType; // 0xE0
        public System.ComponentModel.PropertyChangedEventHandler PropertyChanging; // 0xE8
        public object field_35; // 0x3
        public object field_36; // 0x4
        public object field_37; // 0x5
        public object field_38; // 0x6
        public object field_39; // 0x7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872020C0 | overloaded x3
        public void UpdateColumnType(){} // RVA: 0x7FFE87202590
        public void get_AllowDBNull(){} // RVA: 0x7FFE811E99D0
        public void set_AllowDBNull(){} // RVA: 0x7FFE87202850
        public void get_AutoIncrement(){} // RVA: 0x7FFE87202970
        public void set_AutoIncrement(){} // RVA: 0x7FFE87202990
        public void get_AutoIncrementCurrent(){} // RVA: 0x7FFE87202B80
        public void set_AutoIncrementCurrent(){} // RVA: 0x7FFE87202BF0
        public void get_AutoInc(){} // RVA: 0x7FFE87202D60
        public void get_AutoIncrementSeed(){} // RVA: 0x7FFE87202EA0
        public void set_AutoIncrementSeed(){} // RVA: 0x7FFE87202ED0
        public void get_AutoIncrementStep(){} // RVA: 0x7FFE87202FC0
        public void set_AutoIncrementStep(){} // RVA: 0x7FFE87202FF0
        public void get_Caption(){} // RVA: 0x7FFE872030E0
        public void set_Caption(){} // RVA: 0x7FFE87203100
        public void get_ColumnName(){} // RVA: 0x7FFE8144E200
        public void set_ColumnName(){} // RVA: 0x7FFE87203260
        public void get_EncodedColumnName(){} // RVA: 0x7FFE87203780
        public void get_FormatProvider(){} // RVA: 0x7FFE87203880
        public void get_Locale(){} // RVA: 0x7FFE87203920
        public void get_ObjectID(){} // RVA: 0x7FFE82A234F0
        public void get_Prefix(){} // RVA: 0x7FFE81166120
        public void set_Prefix(){} // RVA: 0x7FFE872039C0
        public void GetColumnValueAsString(){} // RVA: 0x7FFE87203C10
        public void get_Computed(){} // RVA: 0x7FFE85C01C60
        public void get_DataExpression(){} // RVA: 0x7FFE811C3500
        public void get_DataType(){} // RVA: 0x7FFE8143BA80
        public void set_DataType(){} // RVA: 0x7FFE87203D00
        public void get_DateTimeMode(){} // RVA: 0x7FFE8139DAD0
        public void set_DateTimeMode(){} // RVA: 0x7FFE87204690
        public void get_DefaultValue(){} // RVA: 0x7FFE87204810
        public void set_DefaultValue(){} // RVA: 0x7FFE872049F0
        public void get_DefaultValueIsNull(){} // RVA: 0x7FFE87204D30
        public void BindExpression(){} // RVA: 0x7FFE87204D40
        public void get_Expression(){} // RVA: 0x7FFE87204D70
        public void set_Expression(){} // RVA: 0x7FFE87204DF0
        public void get_ExtendedProperties(){} // RVA: 0x7FFE872055C0
        public void get_HasData(){} // RVA: 0x7FFE87205690
        public void get_ImplementsINullable(){} // RVA: 0x7FFE82975460
        public void get_ImplementsIChangeTracking(){} // RVA: 0x7FFE821F9410
        public void get_ImplementsIRevertibleChangeTracking(){} // RVA: 0x7FFE872056A0
        public void get_IsValueType(){} // RVA: 0x7FFE872056B0
        public void get_IsSqlType(){} // RVA: 0x7FFE820BF400
        public void SetMaxLengthSimpleType(){} // RVA: 0x7FFE872056D0
        public void get_MaxLength(){} // RVA: 0x7FFE8139EA30
        public void set_MaxLength(){} // RVA: 0x7FFE87205860
        public void get_Namespace(){} // RVA: 0x7FFE87205C60
        public void set_Namespace(){} // RVA: 0x7FFE87205CE0
        public void get_Ordinal(){} // RVA: 0x7FFE8139DA60
        public void SetOrdinalInternal(){} // RVA: 0x7FFE87205EB0
        public void get_ReadOnly(){} // RVA: 0x7FFE811C3570
        public void set_ReadOnly(){} // RVA: 0x7FFE87205FF0
        public void get_SortIndex(){} // RVA: 0x7FFE872060C0
        public void get_Table(){} // RVA: 0x7FFE81463AE0
        public void SetTable(){} // RVA: 0x7FFE87206280
        public void GetDataRow(){} // RVA: 0x7FFE87206400
        public void get_Item(){} // RVA: 0x7FFE87206440
        public void set_Item(){} // RVA: 0x7FFE87206470
        public void InitializeRecord(){} // RVA: 0x7FFE87206620
        public void SetValue(){} // RVA: 0x7FFE87206670
        public void FreeRecord(){} // RVA: 0x7FFE872067C0
        public void get_Unique(){} // RVA: 0x7FFE813A1130
        public void set_Unique(){} // RVA: 0x7FFE87206800
        public void InternalUnique(){} // RVA: 0x7FFE813A2040
        public void get_XmlDataType(){} // RVA: 0x7FFE8117C900
        public void set_XmlDataType(){} // RVA: 0x7FFE8117C910
        public void get_SimpleType(){} // RVA: 0x7FFE81218100
        public void set_SimpleType(){} // RVA: 0x7FFE87206BC0
        public void get_ColumnMapping(){} // RVA: 0x7FFE829DF2E0
        public void set_ColumnMapping(){} // RVA: 0x7FFE87206D40
        public void CheckColumnConstraint(){} // RVA: 0x7FFE87207130
        public void CheckMaxLength(){} // RVA: 0x7FFE87207540 | overloaded x2
        public void CheckNotAllowNull(){} // RVA: 0x7FFE87207600
        public void CheckNullable(){} // RVA: 0x7FFE87207950
        public void CheckUnique(){} // RVA: 0x7FFE87207A10
        public void Compare(){} // RVA: 0x7FFE87207AA0
        public void CompareValueTo(){} // RVA: 0x7FFE87207CF0 | overloaded x2
        public void ConvertValue(){} // RVA: 0x7FFE87207D20
        public void Copy(){} // RVA: 0x7FFE87207D50
        public void Clone(){} // RVA: 0x7FFE87207D80
        public void GetAggregateValue(){} // RVA: 0x7FFE87208500
        public void GetStringLength(){} // RVA: 0x7FFE87208680
        public void Init(){} // RVA: 0x7FFE872086B0
        public void IsAutoIncrementType(){} // RVA: 0x7FFE87208780
        public void get_IsCustomType(){} // RVA: 0x7FFE87208A50
        public void IsValueCustomTypeInstance(){} // RVA: 0x7FFE87208AC0
        public void get_ImplementsIXMLSerializable(){} // RVA: 0x7FFE86E6CDF0
        public void IsInRelation(){} // RVA: 0x7FFE87208BF0
        public void IsMaxLengthViolated(){} // RVA: 0x7FFE87208D80
        public void IsNotAllowDBNullViolated(){} // RVA: 0x7FFE872091A0
        public void FinishInitInProgress(){} // RVA: 0x7FFE87209320
        public void OnPropertyChanging(){} // RVA: 0x7FFE87209340
        public void RaisePropertyChanging(){} // RVA: 0x7FFE87209370
        public void InsureStorage(){} // RVA: 0x7FFE872093F0
        public void SetCapacity(){} // RVA: 0x7FFE872094D0
        public void OnSetDataSet(){} // RVA: 0x7FFE810FB310
        public void ToString(){} // RVA: 0x7FFE87209520
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872095E0 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87209690 | overloaded x2
        public void GetEmptyColumnStore(){} // RVA: 0x7FFE87209700
        public void CopyValueIntoStore(){} // RVA: 0x7FFE87209750
        public void SetStorage(){} // RVA: 0x7FFE87209790
        public void AddDependentColumn(){} // RVA: 0x7FFE872097F0
        public void RemoveDependentColumn(){} // RVA: 0x7FFE87209900
        public void HandleDependentColumnList(){} // RVA: 0x7FFE872099A0
    }

    public class DataColumnChangeEventArgs : EventArgs
    {
        public System.Data.DataColumn _column; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87231670 | overloaded x2
        public void get_ProposedValue(){} // RVA: 0x7FFE811290C0
        public void set_ProposedValue(){} // RVA: 0x7FFE811290D0
        public void InitializeColumnChangeEvent(){} // RVA: 0x7FFE86F99960
    }

    public class DataColumnChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DataColumnCollection : InternalDataCollectionBase
    {
        public System.Data.DataTable _table; // 0x10
        public System.Collections.ArrayList _list; // 0x18
        public int _defaultNameIndex; // 0x20
        public System.Data.DataColumn[] _delayedAddRangeColumns; // 0x28
        public System.Collections.Generic.Dictionary`2<string,System.Data.DataColumn> _columnFromName; // 0x30
        public bool _fInClear; // 0x38
        public System.Data.DataColumn[] _columnsImplementingIChangeTracking; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872317D0
        public void get_List(){} // RVA: 0x7FFE810FE7C0
        public void get_ColumnsImplementingIChangeTracking(){} // RVA: 0x7FFE81178740
        public void get_ColumnsImplementingIChangeTrackingCount(){} // RVA: 0x7FFE8119C0C0
        public void get_ColumnsImplementingIRevertibleChangeTrackingCount(){} // RVA: 0x7FFE821E0A40
        public void get_Item(){} // RVA: 0x7FFE87231CA0 | overloaded x3
        public void Add(){} // RVA: 0x7FFE87231D80
        public void AddAt(){} // RVA: 0x7FFE87231D90
        public void add_CollectionChanged(){} // RVA: 0x7FFE872320F0
        public void remove_CollectionChanged(){} // RVA: 0x7FFE872321E0
        public void add_ColumnPropertyChanged(){} // RVA: 0x7FFE872322D0
        public void remove_ColumnPropertyChanged(){} // RVA: 0x7FFE872323C0
        public void ArrayAdd(){} // RVA: 0x7FFE87232550 | overloaded x2
        public void ArrayRemove(){} // RVA: 0x7FFE872325C0
        public void AssignName(){} // RVA: 0x7FFE872328E0
        public void BaseAdd(){} // RVA: 0x7FFE87232990
        public void BaseGroupSwitch(){} // RVA: 0x7FFE87232D80
        public void BaseRemove(){} // RVA: 0x7FFE87233050
        public void CanRemove(){} // RVA: 0x7FFE87233250
        public void CheckIChangeTracking(){} // RVA: 0x7FFE87233BE0
        public void Clear(){} // RVA: 0x7FFE87233C30
        public void Contains(){} // RVA: 0x7FFE87234200 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE872342C0
        public void IndexOfCaseInsensitive(){} // RVA: 0x7FFE872343D0
        public void FinishInitCollection(){} // RVA: 0x7FFE87234580
        public void MakeName(){} // RVA: 0x7FFE87234690
        public void OnCollectionChanged(){} // RVA: 0x7FFE87234740
        public void OnCollectionChanging(){} // RVA: 0x7FFE87234840
        public void OnColumnPropertyChanged(){} // RVA: 0x7FFE87234860
        public void RegisterColumnName(){} // RVA: 0x7FFE87234900
        public void CanRegisterName(){} // RVA: 0x7FFE87234B50
        public void Remove(){} // RVA: 0x7FFE87234BC0
        public void UnregisterName(){} // RVA: 0x7FFE87234D00
        public void AddColumnsImplementingIChangeTrackingList(){} // RVA: 0x7FFE87234E50
        public void RemoveColumnsImplementingIChangeTrackingList(){} // RVA: 0x7FFE87234F70
    }

    public class DataColumnPropertyDescriptor : PropertyDescriptor
    {
        public System.Data.DataColumn _column; // 0x88
        public object field_1; // 0x8E
        public object field_2; // 0x8F
        public object field_3; // 0x90
        public object field_4; // 0x91
        public object field_5; // 0x92

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872350D0
        public void get_Attributes(){} // RVA: 0x7FFE87235160
        public void get_Column(){} // RVA: 0x7FFE8113A010
        public void get_ComponentType(){} // RVA: 0x7FFE872353B0
        public void get_IsReadOnly(){} // RVA: 0x7FFE87235460
        public void get_PropertyType(){} // RVA: 0x7FFE87235480
        public void Equals(){} // RVA: 0x7FFE872354A0
        public void GetHashCode(){} // RVA: 0x7FFE87235540
        public void CanResetValue(){} // RVA: 0x7FFE87235570
        public void GetValue(){} // RVA: 0x7FFE872356B0
        public void ResetValue(){} // RVA: 0x7FFE87235740
        public void SetValue(){} // RVA: 0x7FFE87235810
        public void ShouldSerializeValue(){} // RVA: 0x7FFE810FB320
        public void get_IsBrowsable(){} // RVA: 0x7FFE87235910
    }

    public class DataCommonEventSource : EventSource
    {
        // ── Methods ──
        public void Trace(){} // RVA: 0x7FFE810A1420 | overloaded x7
        public void EnterScope(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void ExitScope(){} // RVA: 0x7FFE8722C610
        public void .ctor(){} // RVA: 0x7FFE8694F610
        public void .cctor(){} // RVA: 0x7FFE8722C6D0
    }

    public class DataError : Object
    {
        public string _rowError; // 0x10
        public int _count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87235B20 | overloaded x2
        public void get_Text(){} // RVA: 0x7FFE81116380
        public void set_Text(){} // RVA: 0x7FFE87235C60
        public void get_HasErrors(){} // RVA: 0x7FFE87235D00
        public void SetColumnError(){} // RVA: 0x7FFE87235D30
        public void GetColumnError(){} // RVA: 0x7FFE87235F60
        public void Clear(){} // RVA: 0x7FFE872360C0 | overloaded x2
        public void GetColumnsInError(){} // RVA: 0x7FFE872361B0
        public void SetText(){} // RVA: 0x7FFE87235C60
        public void IndexOf(){} // RVA: 0x7FFE872362E0
    }

    public class DataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3C80 | overloaded x4
    }

    public class DataExpression : Object
    {
        public string _originalExpression; // 0x10
        public bool _parsed; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8725B7A0 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFE8725BBC0
        public void get_HasValue(){} // RVA: 0x7FFE82BC81D0
        public void Bind(){} // RVA: 0x7FFE8725BC10
        public void DependsOn(){} // RVA: 0x7FFE8725BE90
        public void Evaluate(){} // RVA: 0x7FFE8725BED0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE8725C0E0
        public void GetDependency(){} // RVA: 0x7FFE81178740
        public void IsTableAggregate(){} // RVA: 0x7FFE8725C190
        public void IsUnknown(){} // RVA: 0x7FFE8725C1C0
        public void HasLocalAggregate(){} // RVA: 0x7FFE8725C210
        public void HasRemoteAggregate(){} // RVA: 0x7FFE8725C240
        public void ToBoolean(){} // RVA: 0x7FFE8725C270
    }

    public class DataKey : ValueType
    {
        public System.Data.DataColumn[] _columns; // 0x10
        public object field_1; // 0x96
        public object field_2; // 0x97

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87236470
        public void get_ColumnsReference(){} // RVA: 0x7FFE8284EF60
        public void get_HasValue(){} // RVA: 0x7FFE81E76100
        public void get_Table(){} // RVA: 0x7FFE87236710
        public void CheckState(){} // RVA: 0x7FFE87236740
        public void ColumnsEqual(){} // RVA: 0x7FFE872368F0 | overloaded x2
        public void ContainsColumn(){} // RVA: 0x7FFE872369A0
        public void GetHashCode(){} // RVA: 0x7FFE872369F0
        public void Equals(){} // RVA: 0x7FFE87236AD0 | overloaded x2
        public void GetColumnNames(){} // RVA: 0x7FFE87236B70
        public void GetIndexDesc(){} // RVA: 0x7FFE87236C80
        public void GetKeyValues(){} // RVA: 0x7FFE87236E20
        public void GetSortIndex(){} // RVA: 0x7FFE87237020 | overloaded x2
        public void RecordsEqual(){} // RVA: 0x7FFE87237090
        public void ToArray(){} // RVA: 0x7FFE87237140
    }

    public class DataRelation : Object
    {
        public System.Data.DataSet _dataSet; // 0x10
        public System.Data.PropertyCollection _extendedProperties; // 0x18
        public string _relationName; // 0x20
        public System.Data.DataKey _childKey; // 0x28
        public System.Data.DataKey _parentKey; // 0x30
        public System.Data.UniqueConstraint _parentKeyConstraint; // 0x38
        public System.Data.ForeignKeyConstraint _childKeyConstraint; // 0x40
        public string[] _parentColumnNames; // 0x48
        public string[] _childColumnNames; // 0x50
        public string _parentTableName; // 0x58
        public string _childTableName; // 0x60
        public string _parentTableNamespace; // 0x68
        public string _childTableNamespace; // 0x70
        public bool _nested; // 0x78
        public bool _createConstraints; // 0x79
        public bool _checkMultipleNested; // 0x7A
        public int s_objectTypeCount;
        public int _objectID; // 0x7C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872378F0 | overloaded x5
        public void get_ChildColumns(){} // RVA: 0x7FFE87237C20
        public void get_ChildColumnsReference(){} // RVA: 0x7FFE87237C40
        public void get_ChildKey(){} // RVA: 0x7FFE87237C40
        public void get_ChildTable(){} // RVA: 0x7FFE87237C60
        public void get_DataSet(){} // RVA: 0x7FFE87237CA0
        public void get_ParentColumnNames(){} // RVA: 0x7FFE87237CC0
        public void get_ChildColumnNames(){} // RVA: 0x7FFE87237CD0
        public void IsKeyNull(){} // RVA: 0x7FFE87237CE0
        public void GetChildRows(){} // RVA: 0x7FFE87237D90
        public void GetParentRows(){} // RVA: 0x7FFE87237EB0
        public void GetParentRow(){} // RVA: 0x7FFE87237FD0
        public void SetDataSet(){} // RVA: 0x7FFE87238160
        public void get_ParentColumns(){} // RVA: 0x7FFE872381C0
        public void get_ParentColumnsReference(){} // RVA: 0x7FFE8144E200
        public void get_ParentKey(){} // RVA: 0x7FFE872381E0
        public void get_ParentTable(){} // RVA: 0x7FFE87238200
        public void get_RelationName(){} // RVA: 0x7FFE87238240
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7FFE87238260
        public void CheckNestedRelations(){} // RVA: 0x7FFE87238540
        public void get_Nested(){} // RVA: 0x7FFE87238A10
        public void set_Nested(){} // RVA: 0x7FFE87238A30
        public void get_ParentKeyConstraint(){} // RVA: 0x7FFE87239A30
        public void SetParentKeyConstraint(){} // RVA: 0x7FFE81437330
        public void get_ChildKeyConstraint(){} // RVA: 0x7FFE87239A50
        public void get_ExtendedProperties(){} // RVA: 0x7FFE87239A70
        public void get_CheckMultipleNested(){} // RVA: 0x7FFE81643F30
        public void set_CheckMultipleNested(){} // RVA: 0x7FFE81640520
        public void SetChildKeyConstraint(){} // RVA: 0x7FFE81123200
        public void CheckState(){} // RVA: 0x7FFE87239B30
        public void CheckStateForProperty(){} // RVA: 0x7FFE87239E10
        public void Create(){} // RVA: 0x7FFE87239F20
        public void Clone(){} // RVA: 0x7FFE8723A2D0
        public void OnPropertyChanging(){} // RVA: 0x7FFE8723AA30
        public void RaisePropertyChanging(){} // RVA: 0x7FFE8723AAF0
        public void ToString(){} // RVA: 0x7FFE8125C1C0
        public void ValidateMultipleNestedRelations(){} // RVA: 0x7FFE8723AC00
        public void IsAutoGenerated(){} // RVA: 0x7FFE8723B080
        public void get_ObjectID(){} // RVA: 0x7FFE8286B570
    }

    public class DataRelationCollection : InternalDataCollectionBase
    {
        public System.Data.DataRelation _inTransition; // 0x10
        public int _defaultNameIndex; // 0x18
        public System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20

        // ── Methods ──
        public void get_ObjectID(){} // RVA: 0x7FFE81156CD0
        public void get_Item(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void Add(){} // RVA: 0x7FFE8723B2F0
        public void AddCore(){} // RVA: 0x7FFE8723B520
        public void add_CollectionChanged(){} // RVA: 0x7FFE8723B820
        public void remove_CollectionChanged(){} // RVA: 0x7FFE8723B980
        public void AssignName(){} // RVA: 0x7FFE8723BAE0
        public void Clear(){} // RVA: 0x7FFE8723BB00
        public void Contains(){} // RVA: 0x7FFE8723BD80
        public void InternalIndexOf(){} // RVA: 0x7FFE8723BDA0
        public void GetDataSet(){} // RVA: 0x7FFE80E2E2E0
        public void MakeName(){} // RVA: 0x7FFE8723BF60
        public void OnCollectionChanged(){} // RVA: 0x7FFE8723C010
        public void OnCollectionChanging(){} // RVA: 0x7FFE8723C0D0
        public void RegisterName(){} // RVA: 0x7FFE8723C190
        public void Remove(){} // RVA: 0x7FFE8723C480
        public void RemoveAt(){} // RVA: 0x7FFE8723C670
        public void RemoveCore(){} // RVA: 0x7FFE8723C700
        public void UnregisterName(){} // RVA: 0x7FFE8723C8E0
        public void .ctor(){} // RVA: 0x7FFE8723CA90
    }

    public class DataRelationPropertyDescriptor : PropertyDescriptor
    {
        public System.Data.DataRelation _relation; // 0x88
        public object field_1; // 0xB4
        public object field_2; // 0xB5
        public object field_3; // 0xB6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8723E940
        public void get_Relation(){} // RVA: 0x7FFE8113A010
        public void get_ComponentType(){} // RVA: 0x7FFE8723E9F0
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_PropertyType(){} // RVA: 0x7FFE8723EAA0
        public void Equals(){} // RVA: 0x7FFE8723EB50
        public void GetHashCode(){} // RVA: 0x7FFE87235540
        public void CanResetValue(){} // RVA: 0x7FFE810FB320
        public void GetValue(){} // RVA: 0x7FFE8723EBF0
        public void ResetValue(){} // RVA: 0x7FFE810FB310
        public void SetValue(){} // RVA: 0x7FFE810FB310
        public void ShouldSerializeValue(){} // RVA: 0x7FFE810FB320
    }

    public class DataRow : Object
    {
        public System.Data.DataTable _table; // 0x10
        public System.Data.DataColumnCollection _columns; // 0x18
        public int _oldRecord; // 0x20
        public int _newRecord; // 0x24
        public int _tempRecord; // 0x28
        public long _rowID; // 0x30
        public 0x665C83A4 _action; // 0x38
        public bool _inChangingEvent; // 0x3C
        public bool _inDeletingEvent; // 0x3D
        public bool _inCascade; // 0x3E
        public System.Data.DataColumn _lastChangedColumn; // 0x40
        public int _countColumnChange; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8723EC80
        public void get_LastChangedColumn(){} // RVA: 0x7FFE8723EDC0
        public void set_LastChangedColumn(){} // RVA: 0x7FFE8723EDD0
        public void get_HasPropertyChanged(){} // RVA: 0x7FFE8723EE30
        public void get_RBTreeNodeId(){} // RVA: 0x7FFE8175AC90
        public void set_RBTreeNodeId(){} // RVA: 0x7FFE8723EE40
        public void get_RowError(){} // RVA: 0x7FFE8723EEE0
        public void set_RowError(){} // RVA: 0x7FFE8723EF40
        public void RowErrorChanged(){} // RVA: 0x7FFE8723F2D0
        public void get_rowID(){} // RVA: 0x7FFE8144E200
        public void set_rowID(){} // RVA: 0x7FFE8723F320
        public void get_RowState(){} // RVA: 0x7FFE8723F390
        public void get_Table(){} // RVA: 0x7FFE81116380
        public void CheckForLoops(){} // RVA: 0x7FFE8723F540
        public void GetNestedParentCount(){} // RVA: 0x7FFE8723F640
        public void set_Item(){} // RVA: 0x7FFE8723F870 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE8723FE00 | overloaded x2
        public void set_ItemArray(){} // RVA: 0x7FFE8723FEF0
        public void AcceptChanges(){} // RVA: 0x7FFE87240410
        public void BeginEdit(){} // RVA: 0x7FFE87240790
        public void BeginEditInternal(){} // RVA: 0x7FFE872407A0
        public void CancelEdit(){} // RVA: 0x7FFE87240870
        public void CheckColumn(){} // RVA: 0x7FFE87240930
        public void CheckInTable(){} // RVA: 0x7FFE872409F0
        public void Delete(){} // RVA: 0x7FFE87240A30
        public void EndEdit(){} // RVA: 0x7FFE87240AA0
        public void SetColumnError(){} // RVA: 0x7FFE87240C80 | overloaded x2
        public void GetColumnError(){} // RVA: 0x7FFE87240FB0 | overloaded x2
        public void ClearErrors(){} // RVA: 0x7FFE872411B0
        public void ClearError(){} // RVA: 0x7FFE872412F0
        public void get_HasErrors(){} // RVA: 0x7FFE872413F0
        public void GetColumnsInError(){} // RVA: 0x7FFE87241430
        public void GetChildRows(){} // RVA: 0x7FFE872415E0 | overloaded x2
        public void GetDataColumn(){} // RVA: 0x7FFE87241750
        public void GetParentRow(){} // RVA: 0x7FFE872417E0 | overloaded x2
        public void GetNestedParentRow(){} // RVA: 0x7FFE87241960
        public void GetParentRows(){} // RVA: 0x7FFE87241A40 | overloaded x2
        public void GetColumnValues(){} // RVA: 0x7FFE87241CC0 | overloaded x2
        public void GetKeyValues(){} // RVA: 0x7FFE87241DA0 | overloaded x2
        public void GetCurrentRecordNo(){} // RVA: 0x7FFE87241DD0
        public void GetDefaultRecord(){} // RVA: 0x7FFE87241E10
        public void GetOriginalRecordNo(){} // RVA: 0x7FFE87241E70
        public void GetProposedRecordNo(){} // RVA: 0x7FFE87241EB0
        public void GetRecordFromVersion(){} // RVA: 0x7FFE87241EF0
        public void GetDefaultRowVersion(){} // RVA: 0x7FFE87241FE0
        public void GetRecordState(){} // RVA: 0x7FFE87242010
        public void HasKeyChanged(){} // RVA: 0x7FFE87242090 | overloaded x2
        public void HasVersion(){} // RVA: 0x7FFE87242120
        public void HaveValuesChanged(){} // RVA: 0x7FFE872421E0 | overloaded x2
        public void RejectChanges(){} // RVA: 0x7FFE87242360
        public void ResetLastChangedColumn(){} // RVA: 0x7FFE87242800
        public void SetKeyValues(){} // RVA: 0x7FFE87242860
        public void SetNestedParentRow(){} // RVA: 0x7FFE87242980
        public void SetParentRowToDBNull(){} // RVA: 0x7FFE87242F20 | overloaded x2
        public void CopyValuesIntoStore(){} // RVA: 0x7FFE872430E0
    }

    public class DataRowBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
    }

    public class DataRowChangeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872434D0
    }

    public class DataRowChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DataRowCollection : InternalDataCollectionBase
    {
        public System.Data.DataTable _table; // 0x10
        public DataRowTree _list; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87243590
        public void get_Count(){} // RVA: 0x7FFE87243700
        public void get_Item(){} // RVA: 0x7FFE87243750
        public void Add(){} // RVA: 0x7FFE872437A0
        public void DiffInsertAt(){} // RVA: 0x7FFE872437E0
        public void IndexOf(){} // RVA: 0x7FFE87243B20
        public void AddWithColumnEvents(){} // RVA: 0x7FFE87243BB0
        public void ArrayAdd(){} // RVA: 0x7FFE87243C40
        public void ArrayInsert(){} // RVA: 0x7FFE87243CB0
        public void ArrayClear(){} // RVA: 0x7FFE87243DA0
        public void ArrayRemove(){} // RVA: 0x7FFE87243E00
        public void CopyTo(){} // RVA: 0x7FFE87244060 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE872440D0
    }

    public class DataRowCreatedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DataRowView : Object
    {
        public System.Data.DataView _dataView; // 0x10
        public System.Data.DataRow _row; // 0x18
        public bool _delayBeginEdit; // 0x20
        public System.ComponentModel.PropertyDescriptorCollection s_zeroPropertyDescriptorCollection;
        public System.ComponentModel.PropertyChangedEventHandler PropertyChanged; // 0x28
        public object field_5; // 0x7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE82B72360
        public void get_DataView(){} // RVA: 0x7FFE81116380
        public void System.ComponentModel.IDataErrorInfo.get_Item(){} // RVA: 0x7FFE87244290
        public void System.ComponentModel.IDataErrorInfo.get_Error(){} // RVA: 0x7FFE872442D0
        public void get_RowVersionDefault(){} // RVA: 0x7FFE87244340
        public void GetRecord(){} // RVA: 0x7FFE872443A0
        public void HasRecord(){} // RVA: 0x7FFE87244420
        public void GetColumnValue(){} // RVA: 0x7FFE872444A0
        public void SetColumnValue(){} // RVA: 0x7FFE87244520
        public void CreateChildView(){} // RVA: 0x7FFE872447C0 | overloaded x2
        public void get_Row(){} // RVA: 0x7FFE810FE7C0
        public void BeginEdit(){} // RVA: 0x7FFE820025B0
        public void CancelEdit(){} // RVA: 0x7FFE872447D0
        public void EndEdit(){} // RVA: 0x7FFE87244830
        public void get_IsNew(){} // RVA: 0x7FFE87244890
        public void add_PropertyChanged(){} // RVA: 0x7FFE872448C0
        public void remove_PropertyChanged(){} // RVA: 0x7FFE872449B0
        public void RaisePropertyChangedEvent(){} // RVA: 0x7FFE87244AA0
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFE87244B30
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFE87244BD0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFE87244C60 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFE827C4A80
        public void .cctor(){} // RVA: 0x7FFE87244D00
    }

    public class DataSet : MarshalByValueComponent
    {
        public System.Data.DataViewManager _defaultViewManager; // 0x20
        public System.Data.DataTableCollection _tableCollection; // 0x28
        public System.Data.DataRelationCollection _relationCollection; // 0x30
        public System.Data.PropertyCollection _extendedProperties; // 0x38
        public string _dataSetName; // 0x40
        public string _datasetPrefix; // 0x48
        public string _namespaceURI; // 0x50
        public bool _enforceConstraints; // 0x58
        public bool _caseSensitive; // 0x59
        public System.Globalization.CultureInfo _culture; // 0x60
        public bool _cultureUserSet; // 0x68
        public bool _fInReadXml; // 0x69
        public bool _fInLoadDiffgram; // 0x6A
        public bool _fTopLevelTable; // 0x6B
        public bool _fInitInProgress; // 0x6C
        public bool _fEnableCascading; // 0x6D
        public bool _fIsSchemaLoading; // 0x6E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87212000 | overloaded x4
        public void get_RemotingFormat(){} // RVA: 0x7FFE8286C0A0
        public void set_RemotingFormat(){} // RVA: 0x7FFE87211EB0
        public void get_SchemaSerializationMode(){} // RVA: 0x7FFE811EDAF0
        public void GetObjectData(){} // RVA: 0x7FFE87212360
        public void InitializeDerivedDataSet(){} // RVA: 0x7FFE810FB310
        public void SerializeDataSet(){} // RVA: 0x7FFE87212390
        public void DeserializeDataSet(){} // RVA: 0x7FFE87213060
        public void DeserializeDataSetSchema(){} // RVA: 0x7FFE872130E0
        public void DeserializeDataSetData(){} // RVA: 0x7FFE87213860
        public void SerializeDataSetProperties(){} // RVA: 0x7FFE87213A50
        public void DeserializeDataSetProperties(){} // RVA: 0x7FFE87214300
        public void SerializeRelations(){} // RVA: 0x7FFE872147F0
        public void DeserializeRelations(){} // RVA: 0x7FFE87214D90
        public void FailedEnableConstraints(){} // RVA: 0x7FFE872154F0
        public void get_CaseSensitive(){} // RVA: 0x7FFE85BA8C00
        public void set_CaseSensitive(){} // RVA: 0x7FFE87215530
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x7FFE811E0850
        public void get_DefaultViewManager(){} // RVA: 0x7FFE872157E0
        public void get_EnforceConstraints(){} // RVA: 0x7FFE813A1140
        public void set_EnforceConstraints(){} // RVA: 0x7FFE872159D0
        public void RestoreEnforceConstraints(){} // RVA: 0x7FFE819E83C0
        public void EnableConstraints(){} // RVA: 0x7FFE87215AC0
        public void get_DataSetName(){} // RVA: 0x7FFE81178740
        public void set_DataSetName(){} // RVA: 0x7FFE87216050
        public void get_Namespace(){} // RVA: 0x7FFE8119C0E0
        public void set_Namespace(){} // RVA: 0x7FFE872161E0
        public void get_Prefix(){} // RVA: 0x7FFE81176730
        public void set_Prefix(){} // RVA: 0x7FFE87216620
        public void get_ExtendedProperties(){} // RVA: 0x7FFE87216860
        public void get_IsInitialized(){} // RVA: 0x7FFE87216920
        public void get_Locale(){} // RVA: 0x7FFE81199370
        public void set_Locale(){} // RVA: 0x7FFE87216930
        public void SetLocaleValue(){} // RVA: 0x7FFE87216A50
        public void ShouldSerializeLocale(){} // RVA: 0x7FFE811C3570
        public void get_Site(){} // RVA: 0x7FFE81116380
        public void set_Site(){} // RVA: 0x7FFE87217680
        public void get_Relations(){} // RVA: 0x7FFE8144E200
        public void get_Tables(){} // RVA: 0x7FFE81129130
        public void add_Initialized(){} // RVA: 0x7FFE87217830
        public void remove_Initialized(){} // RVA: 0x7FFE87217920
        public void BeginInit(){} // RVA: 0x7FFE87217A10
        public void EndInit(){} // RVA: 0x7FFE87217A20
        public void Clear(){} // RVA: 0x7FFE87217CA0
        public void Clone(){} // RVA: 0x7FFE87217E20
        public void EstimatedXmlStringSize(){} // RVA: 0x7FFE87218DA0
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7FFE87218F00
        public void GetRemotingDiffGram(){} // RVA: 0x7FFE87218F10
        public void GetXmlSchemaForRemoting(){} // RVA: 0x7FFE872190A0
        public void ReadXmlSchema(){} // RVA: 0x7FFE872192C0 | overloaded x2
        public void MoveToElement(){} // RVA: 0x7FFE87219F10 | overloaded x2
        public void ReadEndElement(){} // RVA: 0x7FFE871FCFB0
        public void ReadXSDSchema(){} // RVA: 0x7FFE87219FA0
        public void ReadXDRSchema(){} // RVA: 0x7FFE8721A370
        public void WriteXmlSchema(){} // RVA: 0x7FFE8721A660
        public void ReadXml(){} // RVA: 0x7FFE8721D680 | overloaded x4
        public void InferSchema(){} // RVA: 0x7FFE8721BE90
        public void IsEmpty(){} // RVA: 0x7FFE8721C1B0
        public void ReadXmlDiffgram(){} // RVA: 0x7FFE8721C3A0
        public void WriteXml(){} // RVA: 0x7FFE8721E8C0
        public void Merge(){} // RVA: 0x7FFE8721EB80 | overloaded x2
        public void OnPropertyChanging(){} // RVA: 0x7FFE8721ED80
        public void OnMergeFailed(){} // RVA: 0x7FFE8721EDB0
        public void RaiseMergeFailed(){} // RVA: 0x7FFE8721EE30
        public void OnDataRowCreated(){} // RVA: 0x7FFE8721F010
        public void OnClearFunctionCalled(){} // RVA: 0x7FFE8721F040
        public void OnInitialized(){} // RVA: 0x7FFE8721F070
        public void OnRemoveTable(){} // RVA: 0x7FFE810FB310
        public void OnRemovedTable(){} // RVA: 0x7FFE8721F0F0
        public void OnRemoveRelation(){} // RVA: 0x7FFE810FB310
        public void OnRemoveRelationHack(){} // RVA: 0x7FFE87124FD0
        public void RaisePropertyChanging(){} // RVA: 0x7FFE8721F140
        public void TopLevelTables(){} // RVA: 0x7FFE8721F1D0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE8721F410
        public void ValidateCaseConstraint(){} // RVA: 0x7FFE8721F650
        public void ValidateLocaleConstraint(){} // RVA: 0x7FFE8721F9F0
        public void FindTable(){} // RVA: 0x7FFE8721FE20
        public void ReadXmlSerializable(){} // RVA: 0x7FFE8721FFA0
        public void GetDataSetSchema(){} // RVA: 0x7FFE87220630
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE87220B00
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE87220D40
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE87220EC0
        public void get_MainTableName(){} // RVA: 0x7FFE811C3590
        public void set_MainTableName(){} // RVA: 0x7FFE811C35A0
        public void get_ObjectID(){} // RVA: 0x7FFE8194AD00
    }

    public class DataSetClearEventhandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DataTable : MarshalByValueComponent
    {
        public System.Data.DataSet _dataSet; // 0x20
        public System.Data.DataView _defaultView; // 0x28
        public long _nextRowID; // 0x30
        public System.Data.DataRowCollection _rowCollection; // 0x38
        public System.Data.DataColumnCollection _columnCollection; // 0x40
        public System.Data.ConstraintCollection _constraintCollection; // 0x48
        public int _elementColumnCount; // 0x50
        public System.Data.DataRelationCollection _parentRelationsCollection; // 0x58
        public System.Data.DataRelationCollection _childRelationsCollection; // 0x60
        public System.Data.RecordManager _recordManager; // 0x68
        public System.Collections.Generic.List`1<System.Data.Index> _indexes; // 0x70
        public System.Collections.Generic.List`1<System.Data.Index> _shadowIndexes; // 0x78
        public int _shadowCount; // 0x80
        public System.Data.PropertyCollection _extendedProperties; // 0x88
        public string _tableName; // 0x90
        public string _tableNamespace; // 0x98
        public string _tablePrefix; // 0xA0
        public System.Data.DataExpression _displayExpression; // 0xA8
        public bool _fNestedInDataset; // 0xB0
        public System.Globalization.CultureInfo _culture; // 0xB8
        public bool _cultureUserSet; // 0xC0
        public System.Globalization.CompareInfo _compareInfo; // 0xC8
        public 0x664D3F34 _compareFlags; // 0xD0
        public System.IFormatProvider _formatProvider; // 0xD8
        public System.StringComparer _hashCodeProvider; // 0xE0
        public bool _caseSensitive; // 0xE8
        public bool _caseSensitiveUserSet; // 0xE9
        public string _encodedTableName; // 0xF0
        public System.Data.DataColumn _xmlText; // 0xF8
        public System.Data.DataColumn _colUnique; // 0x100
        public System.Decimal _minOccurs; // 0x108
        public System.Decimal _maxOccurs; // 0x118
        public bool _repeatableElement; // 0x128
        public object _typeName; // 0x130
        public System.Data.UniqueConstraint _primaryKey; // 0x138
        public System.Data.IndexField[] _primaryIndex; // 0x140
        public System.Data.DataColumn[] _delayedSetPrimaryKey; // 0x148
        public System.Data.Index _loadIndex; // 0x150
        public System.Data.Index _loadIndexwithOriginalAdded; // 0x158
        public System.Data.Index _loadIndexwithCurrentDeleted; // 0x160
        public int _suspendIndexEvents; // 0x168
        public bool _inDataLoad; // 0x16C
        public bool _schemaLoading; // 0x16D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871E0E20 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFE871E1070
        public void SerializeDataTable(){} // RVA: 0x7FFE871E1160
        public void DeserializeDataTable(){} // RVA: 0x7FFE871E17D0
        public void SerializeTableSchema(){} // RVA: 0x7FFE871E1B60
        public void DeserializeTableSchema(){} // RVA: 0x7FFE871E4860
        public void SerializeConstraints(){} // RVA: 0x7FFE871E6630
        public void DeserializeConstraints(){} // RVA: 0x7FFE871E6E40
        public void SerializeExpressionColumns(){} // RVA: 0x7FFE871E7AA0
        public void DeserializeExpressionColumns(){} // RVA: 0x7FFE871E7EE0
        public void SerializeTableData(){} // RVA: 0x7FFE871E8100
        public void DeserializeTableData(){} // RVA: 0x7FFE871E9220
        public void ConvertToRowState(){} // RVA: 0x7FFE871EA190
        public void GetRowAndColumnErrors(){} // RVA: 0x7FFE871EA270
        public void ConvertToRowError(){} // RVA: 0x7FFE871EA640
        public void get_CaseSensitive(){} // RVA: 0x7FFE822A56E0
        public void set_CaseSensitive(){} // RVA: 0x7FFE871EA9E0
        public void get_AreIndexEventsSuspended(){} // RVA: 0x7FFE871EAAA0
        public void RestoreIndexEvents(){} // RVA: 0x7FFE871EAAB0
        public void SuspendIndexEvents(){} // RVA: 0x7FFE871EAE50
        public void get_IsInitialized(){} // RVA: 0x7FFE871EAEE0
        public void get_IsTypedDataTable(){} // RVA: 0x7FFE871EAEF0
        public void SetCaseSensitiveValue(){} // RVA: 0x7FFE871EAFA0
        public void ShouldSerializeCaseSensitive(){} // RVA: 0x7FFE871EB290
        public void get_SelfNested(){} // RVA: 0x7FFE871EB2A0
        public void get_LiveIndexes(){} // RVA: 0x7FFE871EB4B0
        public void get_RemotingFormat(){} // RVA: 0x7FFE871EB570
        public void set_RemotingFormat(){} // RVA: 0x7FFE871EB580
        public void get_UKColumnPositionForInference(){} // RVA: 0x7FFE86EE8D60
        public void set_UKColumnPositionForInference(){} // RVA: 0x7FFE86EE8D70
        public void get_ChildRelations(){} // RVA: 0x7FFE871EB600
        public void get_Columns(){} // RVA: 0x7FFE81178740
        public void get_CompareInfo(){} // RVA: 0x7FFE871EB6B0
        public void get_Constraints(){} // RVA: 0x7FFE81176730
        public void ResetConstraints(){} // RVA: 0x7FFE871EB750
        public void get_DataSet(){} // RVA: 0x7FFE811290C0
        public void SetDataSet(){} // RVA: 0x7FFE871EB770
        public void get_DefaultView(){} // RVA: 0x7FFE871EB8E0
        public void get_DisplayExpressionInternal(){} // RVA: 0x7FFE871EBAB0
        public void get_EnforceConstraints(){} // RVA: 0x7FFE871EBB50
        public void set_EnforceConstraints(){} // RVA: 0x7FFE871EBB80
        public void get_SuspendEnforceConstraints(){} // RVA: 0x7FFE871EBBC0
        public void set_SuspendEnforceConstraints(){} // RVA: 0x7FFE871EBBD0
        public void EnableConstraints(){} // RVA: 0x7FFE871EBBE0
        public void get_ExtendedProperties(){} // RVA: 0x7FFE871EC160
        public void get_FormatProvider(){} // RVA: 0x7FFE871EC230
        public void get_Locale(){} // RVA: 0x7FFE811660B0
        public void set_Locale(){} // RVA: 0x7FFE871EC320
        public void SetLocaleValue(){} // RVA: 0x7FFE871EC8B0
        public void ShouldSerializeLocale(){} // RVA: 0x7FFE8111C4C0
        public void get_MinimumCapacity(){} // RVA: 0x7FFE871ECF70
        public void set_MinimumCapacity(){} // RVA: 0x7FFE871ECF90
        public void get_RecordCapacity(){} // RVA: 0x7FFE871ECFE0
        public void get_ElementColumnCount(){} // RVA: 0x7FFE8139DAD0
        public void set_ElementColumnCount(){} // RVA: 0x7FFE871ED000
        public void get_ParentRelations(){} // RVA: 0x7FFE871ED050
        public void get_MergingData(){} // RVA: 0x7FFE86EE8260
        public void set_MergingData(){} // RVA: 0x7FFE86EE8270
        public void get_NestedParentRelations(){} // RVA: 0x7FFE81B295E0
        public void get_SchemaLoading(){} // RVA: 0x7FFE816250C0
        public void CacheNestedParent(){} // RVA: 0x7FFE871ED100
        public void FindNestedParentRelations(){} // RVA: 0x7FFE871ED170
        public void get_NestedParentsCount(){} // RVA: 0x7FFE871ED4C0
        public void get_PrimaryKey(){} // RVA: 0x7FFE871ED730
        public void set_PrimaryKey(){} // RVA: 0x7FFE871ED7A0
        public void get_Rows(){} // RVA: 0x7FFE8143BA80
        public void get_TableName(){} // RVA: 0x7FFE8154EB60
        public void set_TableName(){} // RVA: 0x7FFE871EDD60
        public void get_EncodedTableName(){} // RVA: 0x7FFE871EE520
        public void GetInheritedNamespace(){} // RVA: 0x7FFE871EE630
        public void get_Namespace(){} // RVA: 0x7FFE871EE8B0
        public void set_Namespace(){} // RVA: 0x7FFE871EE940
        public void IsNamespaceInherited(){} // RVA: 0x7FFE871EEC00
        public void CheckCascadingNamespaceConflict(){} // RVA: 0x7FFE871EEC10
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7FFE871EEF10
        public void CheckNamespaceValidityForNestedParentRelations(){} // RVA: 0x7FFE871EF270
        public void DoRaiseNamespaceChange(){} // RVA: 0x7FFE871EF520
        public void BeginInit(){} // RVA: 0x7FFE871EFA60
        public void EndInit(){} // RVA: 0x7FFE871EFA70
        public void get_Prefix(){} // RVA: 0x7FFE8179C860
        public void set_Prefix(){} // RVA: 0x7FFE871F0020
        public void get_XmlText(){} // RVA: 0x7FFE8158D5D0
        public void set_XmlText(){} // RVA: 0x7FFE871F0270
        public void get_MaxOccurs(){} // RVA: 0x7FFE871F04C0
        public void set_MaxOccurs(){} // RVA: 0x7FFE871F04D0
        public void get_MinOccurs(){} // RVA: 0x7FFE86DDD5A0
        public void set_MinOccurs(){} // RVA: 0x7FFE86DDD5B0
        public void SetKeyValues(){} // RVA: 0x7FFE871F04E0
        public void FindByIndex(){} // RVA: 0x7FFE871F0560
        public void FindMergeTarget(){} // RVA: 0x7FFE871F0600
        public void SetMergeRecords(){} // RVA: 0x7FFE871F06D0
        public void MergeRow(){} // RVA: 0x7FFE871F0810
        public void CreateInstance(){} // RVA: 0x7FFE871F1050
        public void Clone(){} // RVA: 0x7FFE871F10F0 | overloaded x2
        public void IncrementalCloneTo(){} // RVA: 0x7FFE871F1270
        public void CloneHierarchy(){} // RVA: 0x7FFE871F1530
        public void CloneTo(){} // RVA: 0x7FFE871F1990
        public void add_Initialized(){} // RVA: 0x7FFE871F2AE0
        public void remove_Initialized(){} // RVA: 0x7FFE871F2BE0
        public void get_Site(){} // RVA: 0x7FFE81116380
        public void set_Site(){} // RVA: 0x7FFE871F2CE0
        public void AddRow(){} // RVA: 0x7FFE871F2E90
        public void InsertRow(){} // RVA: 0x7FFE871F49C0 | overloaded x3
        public void CheckNotModifying(){} // RVA: 0x7FFE871F3300
        public void Clear(){} // RVA: 0x7FFE871F3340 | overloaded x2
        public void CascadeAll(){} // RVA: 0x7FFE871F3D40
        public void CommitRow(){} // RVA: 0x7FFE871F3E70
        public void Compare(){} // RVA: 0x7FFE871F3FF0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE871F4170
        public void IsSuffix(){} // RVA: 0x7FFE871F41E0
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0x7FFE810FB320
        public void DeleteRow(){} // RVA: 0x7FFE871F4250
        public void FormatSortString(){} // RVA: 0x7FFE871F4300
        public void FreeRecord(){} // RVA: 0x7FFE871F4450
        public void GetIndex(){} // RVA: 0x7FFE871F44C0 | overloaded x2
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7FFE871F47D0
        public void GetListeners(){} // RVA: 0x7FFE81B2DA70
        public void GetSpecialHashCode(){} // RVA: 0x7FFE871F47E0
        public void NewRecord(){} // RVA: 0x7FFE871F4E80 | overloaded x2
        public void NewUninitializedRecord(){} // RVA: 0x7FFE871F4E60
        public void NewEmptyRow(){} // RVA: 0x7FFE871F4F90
        public void NewUninitializedRow(){} // RVA: 0x7FFE871F5010
        public void NewRow(){} // RVA: 0x7FFE871F55A0 | overloaded x2
        public void CreateEmptyRow(){} // RVA: 0x7FFE871F5160
        public void NewRowCreated(){} // RVA: 0x7FFE871F54A0
        public void NewRowFromBuilder(){} // RVA: 0x7FFE871F5690
        public void GetRowType(){} // RVA: 0x7FFE871F5800
        public void NewRowArray(){} // RVA: 0x7FFE871F58B0
        public void get_NeedColumnChangeEvents(){} // RVA: 0x7FFE871F5A50
        public void OnColumnChanging(){} // RVA: 0x7FFE871F5A90
        public void OnColumnChanged(){} // RVA: 0x7FFE871F5B50
        public void OnPropertyChanging(){} // RVA: 0x7FFE871F5C10
        public void OnRemoveColumnInternal(){} // RVA: 0x7FFE871F5CD0
        public void OnRemoveColumn(){} // RVA: 0x7FFE810FB310
        public void OnRowChanged(){} // RVA: 0x7FFE871F5E50 | overloaded x2
        public void OnRowChanging(){} // RVA: 0x7FFE871F5F10 | overloaded x2
        public void OnRowDeleting(){} // RVA: 0x7FFE871F5FD0
        public void OnRowDeleted(){} // RVA: 0x7FFE871F6090
        public void OnTableCleared(){} // RVA: 0x7FFE871F6150
        public void OnTableClearing(){} // RVA: 0x7FFE871F6210
        public void OnTableNewRow(){} // RVA: 0x7FFE871F62D0
        public void OnInitialized(){} // RVA: 0x7FFE871F6390
        public void ParseSortString(){} // RVA: 0x7FFE871F6490
        public void RaisePropertyChanging(){} // RVA: 0x7FFE871F6D30
        public void RecordChanged(){} // RVA: 0x7FFE871F6EE0 | overloaded x2
        public void RecordStateChanged(){} // RVA: 0x7FFE871F71A0 | overloaded x2
        public void RemoveRecordFromIndexes(){} // RVA: 0x7FFE871F7380
        public void InsertRecordToIndexes(){} // RVA: 0x7FFE871F75F0
        public void SilentlySetValue(){} // RVA: 0x7FFE871F7810
        public void RemoveRow(){} // RVA: 0x7FFE871F7A60
        public void Reset(){} // RVA: 0x7FFE871F7E10
        public void ResetIndexes(){} // RVA: 0x7FFE871F80E0
        public void ResetInternalIndexes(){} // RVA: 0x7FFE871F80F0
        public void RollbackRow(){} // RVA: 0x7FFE871F8280
        public void RaiseRowChanged(){} // RVA: 0x7FFE871F8320
        public void RaiseRowChanging(){} // RVA: 0x7FFE871F8830 | overloaded x2
        public void SetNewRecord(){} // RVA: 0x7FFE871F89F0
        public void SetNewRecordWorker(){} // RVA: 0x7FFE871F8A70
        public void SetOldRecord(){} // RVA: 0x7FFE871F9720
        public void RestoreShadowIndexes(){} // RVA: 0x7FFE871F9C40
        public void SetShadowIndexes(){} // RVA: 0x7FFE871F9CB0
        public void ShadowIndexCopy(){} // RVA: 0x7FFE871F9D40
        public void ToString(){} // RVA: 0x7FFE871F9E20
        public void UpdatingCurrent(){} // RVA: 0x7FFE871F9F10
        public void AddUniqueKey(){} // RVA: 0x7FFE871FA270 | overloaded x2
        public void AddForeignKey(){} // RVA: 0x7FFE871FA280
        public void UpdatePropertyDescriptorCollectionCache(){} // RVA: 0x7FFE871FA340
        public void GetPropertyDescriptorCollection(){} // RVA: 0x7FFE871FA3A0
        public void get_TypeName(){} // RVA: 0x7FFE871FA840
        public void set_TypeName(){} // RVA: 0x7FFE81B31120
        public void Merge(){} // RVA: 0x7FFE871FA910 | overloaded x2
        public void WriteXml(){} // RVA: 0x7FFE871FAB10
        public void CheckForClosureOnExpressions(){} // RVA: 0x7FFE871FAE80
        public void CheckForClosureOnExpressionTables(){} // RVA: 0x7FFE871FAF50
        public void WriteXmlSchema(){} // RVA: 0x7FFE871FB2E0
        public void RestoreConstraint(){} // RVA: 0x7FFE871FB650
        public void IsEmptyXml(){} // RVA: 0x7FFE871FB6C0
        public void ReadXml(){} // RVA: 0x7FFE871FB9E0
        public void ReadEndElement(){} // RVA: 0x7FFE871FCFB0
        public void ReadXDRSchema(){} // RVA: 0x7FFE871FD070
        public void MoveToElement(){} // RVA: 0x7FFE871FD0F0
        public void ReadXmlDiffgram(){} // RVA: 0x7FFE871FD1D0
        public void ReadXSDSchema(){} // RVA: 0x7FFE871FDCD0
        public void ReadXmlSchema(){} // RVA: 0x7FFE871FDFA0
        public void CreateTableList(){} // RVA: 0x7FFE871FF0D0
        public void CreateRelationList(){} // RVA: 0x7FFE871FF410
        public void GetDataTableSchema(){} // RVA: 0x7FFE871FF790
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE869FD7F0
        public void GetSchema(){} // RVA: 0x7FFE871FFB90
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE871FFDC0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE871FFE90
        public void ReadXmlSerializable(){} // RVA: 0x7FFE871FFEE0
        public void get_RowDiffId(){} // RVA: 0x7FFE871FFF00
        public void get_ObjectID(){} // RVA: 0x7FFE827C65C0
        public void AddDependentColumn(){} // RVA: 0x7FFE871FFFC0
        public void RemoveDependentColumn(){} // RVA: 0x7FFE872000E0
        public void EvaluateExpressions(){} // RVA: 0x7FFE87200AC0 | overloaded x3
        public void EvaluateDependentExpressions(){} // RVA: 0x7FFE87200F30 | overloaded x2
    }

    public class DataTableClearEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87244DC0
    }

    public class DataTableClearEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DataTableCollection : InternalDataCollectionBase
    {
        public System.Data.DataSet _dataSet; // 0x10
        public System.Collections.ArrayList _list; // 0x18
        public int _defaultNameIndex; // 0x20
        public System.Data.DataTable[] _delayedAddRangeTables; // 0x28
        public System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87244E60
        public void get_List(){} // RVA: 0x7FFE810FE7C0
        public void get_ObjectID(){} // RVA: 0x7FFE8119C080
        public void get_Item(){} // RVA: 0x7FFE87245210 | overloaded x3
        public void GetTable(){} // RVA: 0x7FFE87245340
        public void GetTableSmart(){} // RVA: 0x7FFE872454D0
        public void Add(){} // RVA: 0x7FFE87245680
        public void add_CollectionChanged(){} // RVA: 0x7FFE87245890
        public void remove_CollectionChanged(){} // RVA: 0x7FFE872459F0
        public void ArrayAdd(){} // RVA: 0x7FFE87245B50
        public void AssignName(){} // RVA: 0x7FFE87245B80
        public void BaseAdd(){} // RVA: 0x7FFE87245BF0
        public void BaseGroupSwitch(){} // RVA: 0x7FFE87245DD0
        public void BaseRemove(){} // RVA: 0x7FFE87245F70
        public void CanRemove(){} // RVA: 0x7FFE87246030
        public void Clear(){} // RVA: 0x7FFE87246520
        public void Contains(){} // RVA: 0x7FFE87246A00 | overloaded x3
        public void IndexOf(){} // RVA: 0x7FFE87246D00 | overloaded x3
        public void ReplaceFromInference(){} // RVA: 0x7FFE87246D90
        public void InternalIndexOf(){} // RVA: 0x7FFE87247020 | overloaded x2
        public void FinishInitCollection(){} // RVA: 0x7FFE87247230
        public void MakeName(){} // RVA: 0x7FFE872472F0
        public void OnCollectionChanged(){} // RVA: 0x7FFE872473A0
        public void OnCollectionChanging(){} // RVA: 0x7FFE87247460
        public void RegisterName(){} // RVA: 0x7FFE87247520
        public void Remove(){} // RVA: 0x7FFE87247940
        public void UnregisterName(){} // RVA: 0x7FFE87247AB0
    }

    public class DataTableNewRowEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87247C40
    }

    public class DataTableNewRowEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DataTablePropertyDescriptor : PropertyDescriptor
    {
        public System.Data.DataTable _table; // 0x88
        public object field_1; // 0xD1
        public object field_2; // 0xD2
        public object field_3; // 0xD3

        // ── Methods ──
        public void get_Table(){} // RVA: 0x7FFE8113A010
        public void .ctor(){} // RVA: 0x7FFE87247CE0
        public void get_ComponentType(){} // RVA: 0x7FFE87247D80
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_PropertyType(){} // RVA: 0x7FFE87247E30
        public void Equals(){} // RVA: 0x7FFE87247EE0
        public void GetHashCode(){} // RVA: 0x7FFE87235540
        public void CanResetValue(){} // RVA: 0x7FFE810FB320
        public void GetValue(){} // RVA: 0x7FFE87247F80
        public void ResetValue(){} // RVA: 0x7FFE810FB310
        public void SetValue(){} // RVA: 0x7FFE810FB310
        public void ShouldSerializeValue(){} // RVA: 0x7FFE810FB320
    }

    public class DataTableTypeConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87248060
        public void GetPropertiesSupported(){} // RVA: 0x7FFE810FB320
    }

    public class DataTextReader : XmlReader
    {
        public System.Xml.XmlReader _xmlreader; // 0x10
        public object field_1; // 0x153
        public object field_2; // 0x154
        public object field_3; // 0x155
        public object field_4; // 0x156
        public object field_5; // 0x157
        public object field_6; // 0x158
        public object field_7; // 0x159
        public object field_8; // 0x15A
        public object field_9; // 0x15B
        public object field_10; // 0x15C
        public object field_11; // 0x15D
        public object field_12; // 0x15E
        public object field_13; // 0x15F
        public object field_14; // 0x160
        public object field_15; // 0x161
        public object field_16; // 0x162
        public object field_17; // 0x163
        public object field_18; // 0x164
        public object field_19; // 0x165

        // ── Methods ──
        public void CreateReader(){} // RVA: 0x7FFE872B2ED0
        public void .ctor(){} // RVA: 0x7FFE872B2FA0
        public void get_Settings(){} // RVA: 0x7FFE815888E0
        public void get_NodeType(){} // RVA: 0x7FFE81588760
        public void get_Name(){} // RVA: 0x7FFE86BADCC0
        public void get_LocalName(){} // RVA: 0x7FFE81567090
        public void get_NamespaceURI(){} // RVA: 0x7FFE86853DC0
        public void get_Prefix(){} // RVA: 0x7FFE86853DF0
        public void get_Value(){} // RVA: 0x7FFE826F8E90
        public void get_Depth(){} // RVA: 0x7FFE87119A80
        public void get_BaseURI(){} // RVA: 0x7FFE815889F0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE81588880
        public void get_IsDefault(){} // RVA: 0x7FFE815888B0
        public void get_QuoteChar(){} // RVA: 0x7FFE81588730
        public void get_XmlSpace(){} // RVA: 0x7FFE815889C0
        public void get_XmlLang(){} // RVA: 0x7FFE81588910
        public void get_AttributeCount(){} // RVA: 0x7FFE86F36C70
        public void GetAttribute(){} // RVA: 0x7FFE872B3070 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE872B30D0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE86853FA0
        public void MoveToNextAttribute(){} // RVA: 0x7FFE86942D00
        public void MoveToElement(){} // RVA: 0x7FFE86942D30
        public void ReadAttributeValue(){} // RVA: 0x7FFE86BAD390
        public void Read(){} // RVA: 0x7FFE872B3100
        public void get_EOF(){} // RVA: 0x7FFE872B3130
        public void Close(){} // RVA: 0x7FFE86BADE80
        public void get_ReadState(){} // RVA: 0x7FFE872B3160
        public void Skip(){} // RVA: 0x7FFE867799F0
        public void get_NameTable(){} // RVA: 0x7FFE86BACEC0
        public void LookupNamespace(){} // RVA: 0x7FFE872B3190
        public void get_CanResolveEntity(){} // RVA: 0x7FFE872B31C0
        public void ResolveEntity(){} // RVA: 0x7FFE872B31F0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFE8694DDD0
        public void ReadString(){} // RVA: 0x7FFE872B3220
    }

    public class DataTextWriter : XmlWriter
    {
        public System.Xml.XmlWriter _xmltextWriter; // 0x18
        public object field_1; // 0x151

        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFE872B2A20
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void get_BaseStream(){} // RVA: 0x7FFE872B2AB0
        public void WriteStartDocument(){} // RVA: 0x7FFE872B2B40 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFE869795A0
        public void WriteDocType(){} // RVA: 0x7FFE872B2B70
        public void WriteStartElement(){} // RVA: 0x7FFE872B2BA0
        public void WriteEndElement(){} // RVA: 0x7FFE86802D70
        public void WriteFullEndElement(){} // RVA: 0x7FFE872B2BD0
        public void WriteStartAttribute(){} // RVA: 0x7FFE872B2C00
        public void WriteEndAttribute(){} // RVA: 0x7FFE86802DA0
        public void WriteCData(){} // RVA: 0x7FFE872B2C30
        public void WriteComment(){} // RVA: 0x7FFE872B2C60
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE872B2C90
        public void WriteEntityRef(){} // RVA: 0x7FFE872B2CC0
        public void WriteCharEntity(){} // RVA: 0x7FFE872B2CF0
        public void WriteWhitespace(){} // RVA: 0x7FFE872B2D20
        public void WriteString(){} // RVA: 0x7FFE872B2D50
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE872B2D80
        public void WriteChars(){} // RVA: 0x7FFE872B2DB0
        public void WriteRaw(){} // RVA: 0x7FFE872B2E10 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE872B2E40
        public void WriteBinHex(){} // RVA: 0x7FFE872B2E70
        public void get_WriteState(){} // RVA: 0x7FFE868CF670
        public void Close(){} // RVA: 0x7FFE868CF610
        public void Flush(){} // RVA: 0x7FFE868CF5E0
        public void LookupPrefix(){} // RVA: 0x7FFE872B2EA0
    }

    public class DataView : MarshalByValueComponent
    {
        public System.Data.DataViewManager _dataViewManager; // 0x20
        public System.Data.DataTable _table; // 0x28
        public bool _locked; // 0x30
        public System.Data.Index _index; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.Data.Index> _findIndexes; // 0x40
        public string _sort; // 0x48
        public System.Comparison`1<System.Data.DataRow> _comparison; // 0x50
        public System.Data.IFilter _rowFilter; // 0x58
        public 0x665C8BE4 _recordStates; // 0x60
        public bool _shouldOpen; // 0x64
        public bool _open; // 0x65
        public bool _allowNew; // 0x66
        public bool _allowEdit; // 0x67
        public bool _allowDelete; // 0x68
        public bool _applyDefaultSort; // 0x69
        public System.Data.DataRow _addNewRow; // 0x70
        public System.ComponentModel.ListChangedEventArgs _addNewMoved; // 0x78
        public System.ComponentModel.ListChangedEventHandler _onListChanged; // 0x80
        public System.ComponentModel.ListChangedEventArgs s_resetEventArgs;
        public System.Data.DataTable _delayedTable; // 0x88
        public string _delayedRowFilter; // 0x90
        public string _delayedSort; // 0x98
        public 0x665C8BE4 _delayedRecordStates; // 0xA0
        public bool _fInitInProgress; // 0xA4
        public bool _fEndInitInProgress; // 0xA5
        public System.Collections.Generic.Dictionary`2<System.Data.DataRow,System.Data.DataRowView> _rowViewCache; // 0xA8
        public System.Collections.Generic.Dictionary`2<System.Data.DataRow,System.Data.DataRowView> _rowViewBuffer; // 0xB0
        public System.Data.DataViewListener _dvListener; // 0xB8
        public int s_objectTypeCount; // 0x8
        public int _objectID; // 0xC0
        public System.EventHandler Initialized; // 0xC8
        public object ListChanged; // 0x9
        public System.EventHandler ListChanged; // 0x8FC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87248670 | overloaded x2
        public void get_AllowDelete(){} // RVA: 0x7FFE811C3570
        public void get_AllowEdit(){} // RVA: 0x7FFE872486F0
        public void get_AllowNew(){} // RVA: 0x7FFE87248700
        public void get_Count(){} // RVA: 0x7FFE87248710
        public void get_CountFromIndex(){} // RVA: 0x7FFE87248760
        public void get_DataViewManager(){} // RVA: 0x7FFE811290C0
        public void get_IsInitialized(){} // RVA: 0x7FFE87248790
        public void get_IsOpen(){} // RVA: 0x7FFE872487A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_RowFilter(){} // RVA: 0x7FFE872487B0
        public void set_RowFilter(){} // RVA: 0x7FFE87248850
        public void get_RowStateFilter(){} // RVA: 0x7FFE8139EA30
        public void set_RowStateFilter(){} // RVA: 0x7FFE87248AF0
        public void get_Sort(){} // RVA: 0x7FFE87248C40
        public void set_Sort(){} // RVA: 0x7FFE87248DE0
        public void get_SortComparison(){} // RVA: 0x7FFE8119C0E0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void get_Table(){} // RVA: 0x7FFE81129130
        public void set_Table(){} // RVA: 0x7FFE872490E0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE872493F0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE87249460
        public void get_Item(){} // RVA: 0x7FFE872493F0
        public void AddNew(){} // RVA: 0x7FFE87249490
        public void BeginInit(){} // RVA: 0x7FFE87249800
        public void EndInit(){} // RVA: 0x7FFE87249810
        public void CheckOpen(){} // RVA: 0x7FFE87249C40
        public void CheckSort(){} // RVA: 0x7FFE87249C80
        public void Close(){} // RVA: 0x7FFE87249CE0
        public void CopyTo(){} // RVA: 0x7FFE87249F50 | overloaded x2
        public void Delete(){} // RVA: 0x7FFE8724A210 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8724A370
        public void FinishAddNew(){} // RVA: 0x7FFE8724A3E0
        public void GetEnumerator(){} // RVA: 0x7FFE8724A660
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE8724A710
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE8724A7A0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8724A7D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8724A860
        public void IndexOf(){} // RVA: 0x7FFE8724A8F0
        public void IndexOfDataRowView(){} // RVA: 0x7FFE8724AA10
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE8724AAC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE8724AAF0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE8724A1E0
        public void GetFindIndex(){} // RVA: 0x7FFE8724ABD0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFE87248700
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFE861D50B0
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFE872486F0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFE811C3570
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFE8724AE00
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFE8724AE30
        public void GetSortProperty(){} // RVA: 0x7FFE8724AED0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFE8724AF60
        public void add_ListChanged(){} // RVA: 0x7FFE8724AFA0
        public void remove_ListChanged(){} // RVA: 0x7FFE8724B100
        public void add_Initialized(){} // RVA: 0x7FFE8724B260
        public void remove_Initialized(){} // RVA: 0x7FFE8724B350
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFE8724B440
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFE8724B490
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFE8724B4C0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFE8724B780
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFE8724B7D0
        public void System.ComponentModel.IBindingListView.ApplySort(){} // RVA: 0x7FFE8724B890
        public void CreateSortString(){} // RVA: 0x7FFE8724BC70
        public void System.ComponentModel.IBindingListView.RemoveFilter(){} // RVA: 0x7FFE8724BDF0
        public void System.ComponentModel.IBindingListView.get_Filter(){} // RVA: 0x7FFE8724BEC0
        public void System.ComponentModel.IBindingListView.set_Filter(){} // RVA: 0x7FFE8724BEE0
        public void System.ComponentModel.IBindingListView.get_SortDescriptions(){} // RVA: 0x7FFE8724BF00
        public void GetSortDescriptions(){} // RVA: 0x7FFE8724BF10
        public void System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingListView.get_SupportsFiltering(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFE8724C2D0
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFE8724C380
        public void GetFilter(){} // RVA: 0x7FFE811C3500
        public void GetRecord(){} // RVA: 0x7FFE8724C460
        public void GetRow(){} // RVA: 0x7FFE8724C520
        public void GetRowView(){} // RVA: 0x7FFE8724C720 | overloaded x2
        public void IndexListChanged(){} // RVA: 0x7FFE8724C780
        public void IndexListChangedInternal(){} // RVA: 0x7FFE8724C810
        public void MaintainDataView(){} // RVA: 0x7FFE8724C8E0
        public void OnListChanged(){} // RVA: 0x7FFE8724CC00
        public void OnInitialized(){} // RVA: 0x7FFE8724CFC0
        public void Reset(){} // RVA: 0x7FFE8724D040
        public void ResetRowViewCache(){} // RVA: 0x7FFE8724D070
        public void SetDataViewManager(){} // RVA: 0x7FFE8724D450
        public void SetIndex(){} // RVA: 0x7FFE8724D6D0
        public void SetIndex2(){} // RVA: 0x7FFE8724D6F0
        public void UpdateIndex(){} // RVA: 0x7FFE8724DAB0 | overloaded x3
        public void ChildRelationCollectionChanged(){} // RVA: 0x7FFE8724DDD0
        public void ParentRelationCollectionChanged(){} // RVA: 0x7FFE8724E020
        public void ColumnCollectionChanged(){} // RVA: 0x7FFE8724E270
        public void ColumnCollectionChangedInternal(){} // RVA: 0x7FFE8724E520
        public void get_ObjectID(){} // RVA: 0x7FFE813AB640
        public void .cctor(){} // RVA: 0x7FFE8724E540
    }

    public class DataViewListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8724E700
        public void ChildRelationCollectionChanged(){} // RVA: 0x7FFE8724E7E0
        public void ParentRelationCollectionChanged(){} // RVA: 0x7FFE8724E8D0
        public void ColumnCollectionChanged(){} // RVA: 0x7FFE8724E9C0
        public void MaintainDataView(){} // RVA: 0x7FFE8724EAB0
        public void IndexListChanged(){} // RVA: 0x7FFE8724EBA0
        public void RegisterMetaDataEvents(){} // RVA: 0x7FFE8724ED30
        public void UnregisterMetaDataEvents(){} // RVA: 0x7FFE8724F160 | overloaded x2
        public void RegisterListChangedEvent(){} // RVA: 0x7FFE8724F6D0
        public void UnregisterListChangedEvent(){} // RVA: 0x7FFE8724F920
        public void CleanUp(){} // RVA: 0x7FFE8724FAE0
        public void RegisterListener(){} // RVA: 0x7FFE8724FB00
    }

    public class DataViewManager : MarshalByValueComponent
    {
        public System.Data.DataViewSettingCollection _dataViewSettingsCollection; // 0x20
        public System.Data.DataSet _dataSet; // 0x28
        public System.Data.DataViewManagerListItemTypeDescriptor _item; // 0x30
        public bool _locked; // 0x38
        public int _nViews; // 0x3C
        public System.NotSupportedException s_notSupported;
        public System.ComponentModel.ListChangedEventHandler ListChanged; // 0x40
        public object ListChanged; // 0xB
        public 0x7FFE81129130 DataSet;
        public 0x7FFE811290C0 DataViewSettings;
        public TM System.Collections.ICollection.Count;
        public object System.Collections.ICollection.SyncRoot;
        public IntPtr System.Collections.ICollection.IsSynchronized;
        public TM System.Collections.IList.IsReadOnly;
        public TM System.Collections.IList.IsFixedSize;
        public object System.Collections.IList.Item; // 0xB6E0
        public IntPtr System.Collections.IList.Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8724FDD0
        public void get_DataSet(){} // RVA: 0x7FFE81129130
        public void get_DataViewSettings(){} // RVA: 0x7FFE811290C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE872502C0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE811EDAF0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE87250350
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8144E200
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE87250410
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE87250440
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE87250470
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE872504A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE872504B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE872504D0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE87250500
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE87250530
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFE87250560
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFE872505B0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFE87250600
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFE87250650
        public void add_ListChanged(){} // RVA: 0x7FFE872506A0
        public void remove_ListChanged(){} // RVA: 0x7FFE87250790
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFE810FB310
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFE87250880
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFE872508D0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFE810FB310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFE87250920
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFE87250970
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFE87250A40
        public void CreateDataView(){} // RVA: 0x7FFE87250BA0
        public void OnListChanged(){} // RVA: 0x7FFE87250C50
        public void TableCollectionChanged(){} // RVA: 0x7FFE87250D40
        public void RelationCollectionChanged(){} // RVA: 0x7FFE87250FF0
        public void .cctor(){} // RVA: 0x7FFE87251240
    }

    public class DataViewManagerListItemTypeDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetDataView(){} // RVA: 0x7FFE87251330
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFE872513B0
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFE87251450 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFE872514E0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFE827C4A80
    }

    public class DataViewSetting : Object
    {
        public System.Data.DataViewManager _dataViewManager; // 0x10
        public System.Data.DataTable _table; // 0x18
        public string _sort; // 0x20
        public string _rowFilter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872517D0
        public void get_ApplyDefaultSort(){} // RVA: 0x7FFE81131C20
        public void SetDataViewManager(){} // RVA: 0x7FFE87238160
        public void SetDataTable(){} // RVA: 0x7FFE872518E0
        public void get_RowFilter(){} // RVA: 0x7FFE81129130
        public void get_RowStateFilter(){} // RVA: 0x7FFE81156CD0
        public void get_Sort(){} // RVA: 0x7FFE811290C0
    }

    public class DataViewSettingCollection : Object
    {
        public System.Data.DataViewManager _dataViewManager; // 0x10
        public System.Collections.Hashtable _list; // 0x18
        public object field_2; // 0x10B
        public object field_3; // 0x10C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87251940
        public void get_Item(){} // RVA: 0x7FFE87251A90
        public void set_Item(){} // RVA: 0x7FFE87251CA0
        public void CopyTo(){} // RVA: 0x7FFE87251DD0
        public void get_Count(){} // RVA: 0x7FFE87251FA0
        public void GetEnumerator(){} // RVA: 0x7FFE87251FF0
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void Remove(){} // RVA: 0x7FFE87252050
    }

    public class DefaultValueTypeConverter : StringConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ConvertTo(){} // RVA: 0x7FFE87252400
        public void ConvertFrom(){} // RVA: 0x7FFE872525A0
    }

    public class DeletedRowInaccessibleException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B450 | overloaded x3
    }

    public class DuplicateNameException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B4C0 | overloaded x3
    }

}