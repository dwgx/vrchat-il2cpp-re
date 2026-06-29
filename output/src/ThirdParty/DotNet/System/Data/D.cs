// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 41
// Methods: 959

namespace ThirdParty.DotNet.System.Data
{
    public class DataColumn : MarshalByValueComponent
    {
        public object _allowNull;
        public object _caption;
        public object _columnName;
        public object _dataType;
        public object _storageType;
        public object _defaultValue;
        public object _dateTimeMode;
        public object _expression;
        public object _maxLength;
        public object _ordinal;
        public object _readOnly;
        public object _sortIndex;
        public object _table;
        public object _unique;
        public object _columnMapping;
        public object _hashCode;
        public object _errors;
        public object _isSqlType;
        public object _implementsINullable;
        public object _implementsIChangeTracking;
        public object _implementsIRevertibleChangeTracking;
        public object _implementsIXMLSerializable;
        public object _defaultValueIsNull;
        public object _dependentColumns;
        public object _extendedProperties;
        public object _storage;
        public object _autoInc;
        public object _columnUri;
        public object _columnPrefix;
        public object _encodedColumnName;
        public object _simpleType;
        public object s_objectTypeCount;
        public object _objectID;
        public object _xmlDataType;
        public object PropertyChanging;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x712CDF0
        public void UpdateColumnType(){} // RVA: 0x712D290
        public void get_AllowDBNull(){} // RVA: 0xC38360
        public void set_AllowDBNull(){} // RVA: 0x712D550
        public void get_AutoIncrement(){} // RVA: 0x712D680
        public void set_AutoIncrement(){} // RVA: 0x712D6A0
        public void get_AutoIncrementCurrent(){} // RVA: 0x712D870
        public void set_AutoIncrementCurrent(){} // RVA: 0x712D8C0
        public void get_AutoInc(){} // RVA: 0x712DA30
        public void get_AutoIncrementSeed(){} // RVA: 0x712DB80
        public void set_AutoIncrementSeed(){} // RVA: 0x712DBB0
        public void get_AutoIncrementStep(){} // RVA: 0x712DCA0
        public void set_AutoIncrementStep(){} // RVA: 0x712DCD0
        public void get_Caption(){} // RVA: 0x712DDC0
        public void set_Caption(){} // RVA: 0x712DDE0
        public void get_ColumnName(){} // RVA: 0xD33E60
        public void set_ColumnName(){} // RVA: 0x712DF20
        public void get_EncodedColumnName(){} // RVA: 0x712E430
        public void get_FormatProvider(){} // RVA: 0x712E530
        public void get_Locale(){} // RVA: 0x712E5D0
        public void get_ObjectID(){} // RVA: 0x2540E90
        public void get_Prefix(){} // RVA: 0xBAE420
        public void set_Prefix(){} // RVA: 0x712E670
        public void GetColumnValueAsString(){} // RVA: 0x712E8B0
        public void get_Computed(){} // RVA: 0x5BC35B0
        public void get_DataExpression(){} // RVA: 0xC0FFC0
        public void get_DataType(){} // RVA: 0xD05CA0
        public void set_DataType(){} // RVA: 0x712E9A0
        public void get_DateTimeMode(){} // RVA: 0xE32C80
        public void set_DateTimeMode(){} // RVA: 0x712F2D0
        public void get_DefaultValue(){} // RVA: 0x712F460
        public void set_DefaultValue(){} // RVA: 0x712F620
        public void get_DefaultValueIsNull(){} // RVA: 0x712F980
        public void BindExpression(){} // RVA: 0x712F990
        public void get_Expression(){} // RVA: 0x712F9C0
        public void set_Expression(){} // RVA: 0x712FA40
        public void get_ExtendedProperties(){} // RVA: 0x7130090
        public void get_HasData(){} // RVA: 0x7130160
        public void get_ImplementsINullable(){} // RVA: 0x24BB4D0
        public void get_ImplementsIChangeTracking(){} // RVA: 0x1D61360
        public void get_ImplementsIRevertibleChangeTracking(){} // RVA: 0x7130170
        public void get_IsValueType(){} // RVA: 0x7130180
        public void get_IsSqlType(){} // RVA: 0x1C4D9A0
        public void SetMaxLengthSimpleType(){} // RVA: 0x71301A0
        public void get_MaxLength(){} // RVA: 0xD347A0
        public void set_MaxLength(){} // RVA: 0x7130330
        public void get_Namespace(){} // RVA: 0x7130750
        public void set_Namespace(){} // RVA: 0x7130790
        public void get_Ordinal(){} // RVA: 0xD34720
        public void SetOrdinalInternal(){} // RVA: 0x7130990
        public void get_ReadOnly(){} // RVA: 0xC10030
        public void set_ReadOnly(){} // RVA: 0x7130AD0
        public void get_SortIndex(){} // RVA: 0x7130BA0
        public void get_Table(){} // RVA: 0xCD3320
        public void SetTable(){} // RVA: 0x7130D60
        public void GetDataRow(){} // RVA: 0x7130EE0
        public void get_Item(){} // RVA: 0x7130F20
        public void set_Item(){} // RVA: 0x7130F50
        public void InitializeRecord(){} // RVA: 0x7131100
        public void SetValue(){} // RVA: 0x7131150
        public void FreeRecord(){} // RVA: 0x71312A0
        public void get_Unique(){} // RVA: 0xE3F400
        public void set_Unique(){} // RVA: 0x71312E0
        public void InternalUnique(){} // RVA: 0xE3CFC0
        public void get_XmlDataType(){} // RVA: 0xBC5B30
        public void set_XmlDataType(){} // RVA: 0xBC5B40
        public void get_SimpleType(){} // RVA: 0xC68EB0
        public void set_SimpleType(){} // RVA: 0x7131670
        public void get_ColumnMapping(){} // RVA: 0xD34730
        public void set_ColumnMapping(){} // RVA: 0x7131800
        public void CheckColumnConstraint(){} // RVA: 0x7131BD0
        public void CheckMaxLength(){} // RVA: 0x7131FD0
        public void CheckNotAllowNull(){} // RVA: 0x7132090
        public void CheckNullable(){} // RVA: 0x71323D0
        public void CheckUnique(){} // RVA: 0x7132490
        public void Compare(){} // RVA: 0x7132520
        public void CompareValueTo(){} // RVA: 0x7132790
        public void ConvertValue(){} // RVA: 0x71327C0
        public void Copy(){} // RVA: 0x71327F0
        public void Clone(){} // RVA: 0x7132820
        public void GetAggregateValue(){} // RVA: 0x7132F80
        public void GetStringLength(){} // RVA: 0x71330F0
        public void Init(){} // RVA: 0x7133120
        public void IsAutoIncrementType(){} // RVA: 0x71331F0
        public void get_IsCustomType(){} // RVA: 0x71334C0
        public void IsValueCustomTypeInstance(){} // RVA: 0x7133530
        public void get_ImplementsIXMLSerializable(){} // RVA: 0x6D98D80
        public void IsInRelation(){} // RVA: 0x7133640
        public void IsMaxLengthViolated(){} // RVA: 0x71337E0
        public void IsNotAllowDBNullViolated(){} // RVA: 0x7133C00
        public void FinishInitInProgress(){} // RVA: 0x7133D80
        public void OnPropertyChanging(){} // RVA: 0x7133DA0
        public void RaisePropertyChanging(){} // RVA: 0x7133DD0
        public void InsureStorage(){} // RVA: 0x7133E50
        public void SetCapacity(){} // RVA: 0x7133F30
        public void OnSetDataSet(){} // RVA: 0xB43310
        public void ToString(){} // RVA: 0x7133F80
        public void ConvertXmlToObject(){} // RVA: 0x7134040
        public void ConvertObjectToXml(){} // RVA: 0x71340F0
        public void GetEmptyColumnStore(){} // RVA: 0x7134160
        public void CopyValueIntoStore(){} // RVA: 0x71341B0
        public void SetStorage(){} // RVA: 0x71341F0
        public void AddDependentColumn(){} // RVA: 0x7134250
        public void RemoveDependentColumn(){} // RVA: 0x7134360
        public void HandleDependentColumnList(){} // RVA: 0x7134400
    }

    public class DataColumnChangeEventArgs : EventArgs
    {
        public object _column;
        public object _row;
        public object _proposedValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x715B060
        public void get_ProposedValue(){} // RVA: 0xB700F0
        public void set_ProposedValue(){} // RVA: 0xB70100
        public void InitializeColumnChangeEvent(){} // RVA: 0x6EC9750
    }

    public class DataColumnChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DataColumnCollection : InternalDataCollectionBase
    {
        public object _table;
        public object _list;
        public object _defaultNameIndex;
        public object _delayedAddRangeColumns;
        public object _columnFromName;
        public object _fInClear;
        public object _columnsImplementingIChangeTracking;
        public object _nColumnsImplementingIChangeTracking;
        public object _nColumnsImplementingIRevertibleChangeTracking;
        public object CollectionChanged;
        public object CollectionChanging;
        public object ColumnPropertyChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x715B1C0
        public void get_List(){} // RVA: 0xB465B0
        public void get_ColumnsImplementingIChangeTracking(){} // RVA: 0xBC1B30
        public void get_ColumnsImplementingIChangeTrackingCount(){} // RVA: 0xBE5890
        public void get_ColumnsImplementingIRevertibleChangeTrackingCount(){} // RVA: 0x1D46130
        public void get_Item(){} // RVA: 0x715B680
        public void Add(){} // RVA: 0x715B7A0
        public void AddAt(){} // RVA: 0x715B7B0
        public void add_CollectionChanged(){} // RVA: 0x715BB10
        public void remove_CollectionChanged(){} // RVA: 0x715BC00
        public void add_ColumnPropertyChanged(){} // RVA: 0x715BCF0
        public void remove_ColumnPropertyChanged(){} // RVA: 0x715BDE0
        public void ArrayAdd(){} // RVA: 0x715BF70
        public void ArrayRemove(){} // RVA: 0x715BFE0
        public void AssignName(){} // RVA: 0x715C310
        public void BaseAdd(){} // RVA: 0x715C3C0
        public void BaseGroupSwitch(){} // RVA: 0x715C6E0
        public void BaseRemove(){} // RVA: 0x715C9E0
        public void CanRemove(){} // RVA: 0x715CBE0
        public void CheckIChangeTracking(){} // RVA: 0x715D580
        public void Clear(){} // RVA: 0x715D5D0
        public void Contains(){} // RVA: 0x715DB00
        public void IndexOf(){} // RVA: 0x715DBC0
        public void IndexOfCaseInsensitive(){} // RVA: 0x715DCD0
        public void FinishInitCollection(){} // RVA: 0x715DE80
        public void MakeName(){} // RVA: 0x715DFB0
        public void OnCollectionChanged(){} // RVA: 0x715E060
        public void OnCollectionChanging(){} // RVA: 0x715E160
        public void OnColumnPropertyChanged(){} // RVA: 0x715E180
        public void RegisterColumnName(){} // RVA: 0x715E220
        public void CanRegisterName(){} // RVA: 0x715E470
        public void Remove(){} // RVA: 0x715E4E0
        public void UnregisterName(){} // RVA: 0x715E620
        public void AddColumnsImplementingIChangeTrackingList(){} // RVA: 0x715E770
        public void RemoveColumnsImplementingIChangeTrackingList(){} // RVA: 0x715E890
    }

    public class DataColumnPropertyDescriptor : PropertyDescriptor
    {
        public object _column;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x715EA00
        public void get_Attributes(){} // RVA: 0x715EA90
        public void get_Column(){} // RVA: 0xB813B0
        public void get_ComponentType(){} // RVA: 0x715ECB0
        public void get_IsReadOnly(){} // RVA: 0x715ED30
        public void get_PropertyType(){} // RVA: 0x715ED50
        public void Equals(){} // RVA: 0x715ED70
        public void GetHashCode(){} // RVA: 0x715EE10
        public void CanResetValue(){} // RVA: 0x715EE40
        public void GetValue(){} // RVA: 0x715EF80
        public void ResetValue(){} // RVA: 0x715F010
        public void SetValue(){} // RVA: 0x715F0E0
        public void ShouldSerializeValue(){} // RVA: 0xB43320
        public void get_IsBrowsable(){} // RVA: 0x715F1E0
    }

    public class DataCommonEventSource : EventSource
    {
        public object Log;
        public object s_nextScopeId;

        // ── Methods ──
        public void Trace(){} // RVA: 0xA94080
        public void EnterScope(){} // RVA: 0xA94080
        public void ExitScope(){} // RVA: 0x71561E0
        public void .ctor(){} // RVA: 0x6888090
        public void .cctor(){} // RVA: 0x7156290
    }

    public class DataError : Object
    {
        public object _rowError;
        public object _count;
        public object _errorList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x715F330
        public void get_Text(){} // RVA: 0xB5DBF0
        public void set_Text(){} // RVA: 0x715F420
        public void get_HasErrors(){} // RVA: 0x715F490
        public void SetColumnError(){} // RVA: 0x715F4C0
        public void GetColumnError(){} // RVA: 0x715F710
        public void Clear(){} // RVA: 0x715F830
        public void GetColumnsInError(){} // RVA: 0x715F900
        public void SetText(){} // RVA: 0x715F420
        public void IndexOf(){} // RVA: 0x715FA60
    }

    public class DataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022E0
    }

    public class DataExpression : Object
    {
        public object _originalExpression;
        public object _parsed;
        public object _bound;
        public object _expr;
        public object _table;
        public object _storageType;
        public object _dataType;
        public object _dependency;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71846A0
        public void get_Expression(){} // RVA: 0x7184AC0
        public void get_HasValue(){} // RVA: 0x26C1120
        public void Bind(){} // RVA: 0x7184B10
        public void DependsOn(){} // RVA: 0x7184D90
        public void Evaluate(){} // RVA: 0x7184DD0
        public void Invoke(){} // RVA: 0x7184F40
        public void GetDependency(){} // RVA: 0xBC1B30
        public void IsTableAggregate(){} // RVA: 0x7184FF0
        public void IsUnknown(){} // RVA: 0x7185020
        public void HasLocalAggregate(){} // RVA: 0x7185070
        public void HasRemoteAggregate(){} // RVA: 0x71850A0
        public void ToBoolean(){} // RVA: 0x71850D0
    }

    public class DataKey : ValueType
    {
        public object _columns;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x902F60
        public void get_ColumnsReference(){} // RVA: 0x77900
        public void get_HasValue(){} // RVA: 0x54A60
        public void get_Table(){} // RVA: 0x902F70
        public void CheckState(){} // RVA: 0x902FB0
        public void ColumnsEqual(){} // RVA: 0x71600A0
        public void ContainsColumn(){} // RVA: 0x902FD0
        public void GetHashCode(){} // RVA: 0x903020
        public void Equals(){} // RVA: 0x903100
        public void GetColumnNames(){} // RVA: 0x903110
        public void GetIndexDesc(){} // RVA: 0x903120
        public void GetKeyValues(){} // RVA: 0x903130
        public void GetSortIndex(){} // RVA: 0x9031A0
        public void RecordsEqual(){} // RVA: 0x9031B0
        public void ToArray(){} // RVA: 0x9031C0
    }

    public class DataRelation : Object
    {
        public object _dataSet;
        public object _extendedProperties;
        public object _relationName;
        public object _childKey;
        public object _parentKey;
        public object _parentKeyConstraint;
        public object _childKeyConstraint;
        public object _parentColumnNames;
        public object _childColumnNames;
        public object _parentTableName;
        public object _childTableName;
        public object _parentTableNamespace;
        public object _childTableNamespace;
        public object _nested;
        public object _createConstraints;
        public object _checkMultipleNested;
        public object s_objectTypeCount;
        public object _objectID;
        public object PropertyChanging;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7161130
        public void get_ChildColumns(){} // RVA: 0x7161450
        public void get_ChildColumnsReference(){} // RVA: 0x7161470
        public void get_ChildKey(){} // RVA: 0x7161470
        public void get_ChildTable(){} // RVA: 0x7161490
        public void get_DataSet(){} // RVA: 0x71614D0
        public void get_ParentColumnNames(){} // RVA: 0x71614F0
        public void get_ChildColumnNames(){} // RVA: 0x7161500
        public void IsKeyNull(){} // RVA: 0x7161510
        public void GetChildRows(){} // RVA: 0x71615C0
        public void GetParentRows(){} // RVA: 0x71616E0
        public void GetParentRow(){} // RVA: 0x7161800
        public void SetDataSet(){} // RVA: 0x7161990
        public void get_ParentColumns(){} // RVA: 0x71619F0
        public void get_ParentColumnsReference(){} // RVA: 0xD33E60
        public void get_ParentKey(){} // RVA: 0x7161A10
        public void get_ParentTable(){} // RVA: 0x7161A30
        public void get_RelationName(){} // RVA: 0x7161A70
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7161A90
        public void CheckNestedRelations(){} // RVA: 0x7161D60
        public void get_Nested(){} // RVA: 0x7162250
        public void set_Nested(){} // RVA: 0x7162270
        public void get_ParentKeyConstraint(){} // RVA: 0x7163250
        public void SetParentKeyConstraint(){} // RVA: 0xD09D70
        public void get_ChildKeyConstraint(){} // RVA: 0x7163270
        public void get_ExtendedProperties(){} // RVA: 0x7163290
        public void get_CheckMultipleNested(){} // RVA: 0x11662C0
        public void set_CheckMultipleNested(){} // RVA: 0x1160510
        public void SetChildKeyConstraint(){} // RVA: 0xB6A8C0
        public void CheckState(){} // RVA: 0x7163350
        public void CheckStateForProperty(){} // RVA: 0x7163620
        public void Create(){} // RVA: 0x7163680
        public void Clone(){} // RVA: 0x7163A30
        public void OnPropertyChanging(){} // RVA: 0x71641A0
        public void RaisePropertyChanging(){} // RVA: 0x7164260
        public void ToString(){} // RVA: 0xCADE00
        public void ValidateMultipleNestedRelations(){} // RVA: 0x7164370
        public void IsAutoGenerated(){} // RVA: 0x71647E0
        public void get_ObjectID(){} // RVA: 0x23A4270
    }

    public class DataRelationCollection : InternalDataCollectionBase
    {
        public object _inTransition;
        public object _defaultNameIndex;
        public object _onCollectionChangedDelegate;
        public object _onCollectionChangingDelegate;
        public object s_objectTypeCount;
        public object _objectID;

        // ── Methods ──
        public void get_ObjectID(){} // RVA: 0xB9E080
        public void get_Item(){} // RVA: 0x87C540
        public void Add(){} // RVA: 0x7164A60
        public void AddCore(){} // RVA: 0x7164C90
        public void add_CollectionChanged(){} // RVA: 0x7164F90
        public void remove_CollectionChanged(){} // RVA: 0x71650F0
        public void AssignName(){} // RVA: 0x7165250
        public void Clear(){} // RVA: 0x7165270
        public void Contains(){} // RVA: 0x71654F0
        public void InternalIndexOf(){} // RVA: 0x7165510
        public void GetDataSet(){} // RVA: 0x87C0A0
        public void MakeName(){} // RVA: 0x71656D0
        public void OnCollectionChanged(){} // RVA: 0x7165780
        public void OnCollectionChanging(){} // RVA: 0x7165840
        public void RegisterName(){} // RVA: 0x7165900
        public void Remove(){} // RVA: 0x7165BF0
        public void RemoveAt(){} // RVA: 0x7165DE0
        public void RemoveCore(){} // RVA: 0x7165E60
        public void UnregisterName(){} // RVA: 0x7166040
        public void .ctor(){} // RVA: 0x71661F0
    }

    public class DataRelationPropertyDescriptor : PropertyDescriptor
    {
        public object _relation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7168030
        public void get_Relation(){} // RVA: 0xB813B0
        public void get_ComponentType(){} // RVA: 0x71680E0
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_PropertyType(){} // RVA: 0x7168160
        public void Equals(){} // RVA: 0x71681E0
        public void GetHashCode(){} // RVA: 0x715EE10
        public void CanResetValue(){} // RVA: 0xB43320
        public void GetValue(){} // RVA: 0x7168280
        public void ResetValue(){} // RVA: 0xB43310
        public void SetValue(){} // RVA: 0xB43310
        public void ShouldSerializeValue(){} // RVA: 0xB43320
    }

    public class DataRow : Object
    {
        public object _table;
        public object _columns;
        public object _oldRecord;
        public object _newRecord;
        public object _tempRecord;
        public object _rowID;
        public object _action;
        public object _inChangingEvent;
        public object _inDeletingEvent;
        public object _inCascade;
        public object _lastChangedColumn;
        public object _countColumnChange;
        public object _error;
        public object _rbTreeNodeId;
        public object s_objectTypeCount;
        public object _objectID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7168310
        public void get_LastChangedColumn(){} // RVA: 0x7168450
        public void set_LastChangedColumn(){} // RVA: 0x7168460
        public void get_HasPropertyChanged(){} // RVA: 0x71684C0
        public void get_RBTreeNodeId(){} // RVA: 0x12BB630
        public void set_RBTreeNodeId(){} // RVA: 0x71684D0
        public void get_RowError(){} // RVA: 0x7168570
        public void set_RowError(){} // RVA: 0x71685A0
        public void RowErrorChanged(){} // RVA: 0x7168880
        public void get_rowID(){} // RVA: 0xD33E60
        public void set_rowID(){} // RVA: 0x71688D0
        public void get_RowState(){} // RVA: 0x7168940
        public void get_Table(){} // RVA: 0xB5DBF0
        public void CheckForLoops(){} // RVA: 0x7168B00
        public void GetNestedParentCount(){} // RVA: 0x7168C00
        public void set_Item(){} // RVA: 0x7168E30
        public void get_Item(){} // RVA: 0x7169320
        public void set_ItemArray(){} // RVA: 0x7169410
        public void AcceptChanges(){} // RVA: 0x7169890
        public void BeginEdit(){} // RVA: 0x7169C00
        public void BeginEditInternal(){} // RVA: 0x7169C10
        public void CancelEdit(){} // RVA: 0x7169CE0
        public void CheckColumn(){} // RVA: 0x7169DA0
        public void CheckInTable(){} // RVA: 0x7169E60
        public void Delete(){} // RVA: 0x7169EA0
        public void EndEdit(){} // RVA: 0x7169F10
        public void SetColumnError(){} // RVA: 0x716A0F0
        public void GetColumnError(){} // RVA: 0x716A430
        public void ClearErrors(){} // RVA: 0x716A610
        public void ClearError(){} // RVA: 0x716A730
        public void get_HasErrors(){} // RVA: 0x716A840
        public void GetColumnsInError(){} // RVA: 0x716A880
        public void GetChildRows(){} // RVA: 0x716AA40
        public void GetDataColumn(){} // RVA: 0x716ABB0
        public void GetParentRow(){} // RVA: 0x716AC40
        public void GetNestedParentRow(){} // RVA: 0x716ADC0
        public void GetParentRows(){} // RVA: 0x716AEA0
        public void GetColumnValues(){} // RVA: 0x716B120
        public void GetKeyValues(){} // RVA: 0x716B200
        public void GetCurrentRecordNo(){} // RVA: 0x716B230
        public void GetDefaultRecord(){} // RVA: 0x716B270
        public void GetOriginalRecordNo(){} // RVA: 0x716B2D0
        public void GetProposedRecordNo(){} // RVA: 0x716B310
        public void GetRecordFromVersion(){} // RVA: 0x716B350
        public void GetDefaultRowVersion(){} // RVA: 0x716B440
        public void GetRecordState(){} // RVA: 0x716B470
        public void HasKeyChanged(){} // RVA: 0x716B4F0
        public void HasVersion(){} // RVA: 0x716B580
        public void HaveValuesChanged(){} // RVA: 0x716B640
        public void RejectChanges(){} // RVA: 0x716B7C0
        public void ResetLastChangedColumn(){} // RVA: 0x716BC60
        public void SetKeyValues(){} // RVA: 0x716BCC0
        public void SetNestedParentRow(){} // RVA: 0x716BDE0
        public void SetParentRowToDBNull(){} // RVA: 0x716C360
        public void CopyValuesIntoStore(){} // RVA: 0x716C520
    }

    public class DataRowBuilder : Object
    {
        public object _table;
        public object _record;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class DataRowChangeEventArgs : EventArgs
    {
        public object _row;
        public object _action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x716C910
    }

    public class DataRowChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DataRowCollection : InternalDataCollectionBase
    {
        public object _table;
        public object _list;
        public object _nullInList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x716C9D0
        public void get_Count(){} // RVA: 0x716CB40
        public void get_Item(){} // RVA: 0x716CB90
        public void Add(){} // RVA: 0x716CBE0
        public void DiffInsertAt(){} // RVA: 0x716CC20
        public void IndexOf(){} // RVA: 0x716CF30
        public void AddWithColumnEvents(){} // RVA: 0x716CFC0
        public void ArrayAdd(){} // RVA: 0x716D050
        public void ArrayInsert(){} // RVA: 0x716D0C0
        public void ArrayClear(){} // RVA: 0x716D1B0
        public void ArrayRemove(){} // RVA: 0x716D210
        public void CopyTo(){} // RVA: 0x716D470
        public void GetEnumerator(){} // RVA: 0x716D4E0
    }

    public class DataRowCreatedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DataRowView : Object
    {
        public object _dataView;
        public object _row;
        public object _delayBeginEdit;
        public object s_zeroPropertyDescriptorCollection;
        public object PropertyChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x266A270
        public void get_DataView(){} // RVA: 0xB5DBF0
        public void System.ComponentModel.IDataErrorInfo.get_Item(){} // RVA: 0x716D6A0
        public void System.ComponentModel.IDataErrorInfo.get_Error(){} // RVA: 0x716D6E0
        public void get_RowVersionDefault(){} // RVA: 0x716D720
        public void GetRecord(){} // RVA: 0x716D780
        public void HasRecord(){} // RVA: 0x716D800
        public void GetColumnValue(){} // RVA: 0x716D880
        public void SetColumnValue(){} // RVA: 0x716D900
        public void CreateChildView(){} // RVA: 0x716DBA0
        public void get_Row(){} // RVA: 0xB465B0
        public void BeginEdit(){} // RVA: 0x1B68750
        public void CancelEdit(){} // RVA: 0x716DBB0
        public void EndEdit(){} // RVA: 0x716DC10
        public void get_IsNew(){} // RVA: 0x716DC70
        public void add_PropertyChanged(){} // RVA: 0x716DCA0
        public void remove_PropertyChanged(){} // RVA: 0x716DD90
        public void RaisePropertyChangedEvent(){} // RVA: 0x716DE80
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x716DF10
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x716DFB0
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x716E040
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x2303260
        public void .cctor(){} // RVA: 0x716E0E0
    }

    public class DataSet : MarshalByValueComponent
    {
        public object _defaultViewManager;
        public object _tableCollection;
        public object _relationCollection;
        public object _extendedProperties;
        public object _dataSetName;
        public object _datasetPrefix;
        public object _namespaceURI;
        public object _enforceConstraints;
        public object _caseSensitive;
        public object _culture;
        public object _cultureUserSet;
        public object _fInReadXml;
        public object _fInLoadDiffgram;
        public object _fTopLevelTable;
        public object _fInitInProgress;
        public object _fEnableCascading;
        public object _fIsSchemaLoading;
        public object _mainTableName;
        public object _remotingFormat;
        public object _defaultViewManagerLock;
        public object s_objectTypeCount;
        public object _objectID;
        public object s_schemaTypeForWSDL;
        public object _useDataSetSchemaOnly;
        public object _udtIsWrapped;
        public object PropertyChanging;
        public object MergeFailed;
        public object DataRowCreated;
        public object ClearFunctionCalled;
        public object Initialized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x713C8F0
        public void get_RemotingFormat(){} // RVA: 0x23ADD10
        public void set_RemotingFormat(){} // RVA: 0x713C7A0
        public void get_SchemaSerializationMode(){} // RVA: 0xC3CCE0
        public void GetObjectData(){} // RVA: 0x713CC50
        public void InitializeDerivedDataSet(){} // RVA: 0xB43310
        public void SerializeDataSet(){} // RVA: 0x713CC80
        public void DeserializeDataSet(){} // RVA: 0x713DFF0
        public void DeserializeDataSetSchema(){} // RVA: 0x713E070
        public void DeserializeDataSetData(){} // RVA: 0x713E7A0
        public void SerializeDataSetProperties(){} // RVA: 0x713E990
        public void DeserializeDataSetProperties(){} // RVA: 0x713F220
        public void SerializeRelations(){} // RVA: 0x713F6A0
        public void DeserializeRelations(){} // RVA: 0x713FDE0
        public void FailedEnableConstraints(){} // RVA: 0x71404D0
        public void get_CaseSensitive(){} // RVA: 0x5C8BB10
        public void set_CaseSensitive(){} // RVA: 0x7140510
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0xC2E4C0
        public void get_DefaultViewManager(){} // RVA: 0x7140790
        public void get_EnforceConstraints(){} // RVA: 0xE3F480
        public void set_EnforceConstraints(){} // RVA: 0x7140940
        public void RestoreEnforceConstraints(){} // RVA: 0x1546550
        public void EnableConstraints(){} // RVA: 0x7140A40
        public void get_DataSetName(){} // RVA: 0xBC1B30
        public void set_DataSetName(){} // RVA: 0x7140FC0
        public void get_Namespace(){} // RVA: 0xBE58B0
        public void set_Namespace(){} // RVA: 0x7141150
        public void get_Prefix(){} // RVA: 0xBBF8F0
        public void set_Prefix(){} // RVA: 0x7141570
        public void get_ExtendedProperties(){} // RVA: 0x71417A0
        public void get_IsInitialized(){} // RVA: 0x7141860
        public void get_Locale(){} // RVA: 0xBE2C60
        public void set_Locale(){} // RVA: 0x7141870
        public void SetLocaleValue(){} // RVA: 0x71419A0
        public void ShouldSerializeLocale(){} // RVA: 0xC10030
        public void get_Site(){} // RVA: 0xB5DBF0
        public void set_Site(){} // RVA: 0x7142490
        public void get_Relations(){} // RVA: 0xD33E60
        public void get_Tables(){} // RVA: 0xB70160
        public void add_Initialized(){} // RVA: 0x7142650
        public void remove_Initialized(){} // RVA: 0x7142750
        public void BeginInit(){} // RVA: 0x7142850
        public void EndInit(){} // RVA: 0x7142860
        public void Clear(){} // RVA: 0x7142AF0
        public void Clone(){} // RVA: 0x7142C80
        public void EstimatedXmlStringSize(){} // RVA: 0x7143BE0
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x7143D40
        public void GetRemotingDiffGram(){} // RVA: 0x7143D50
        public void GetXmlSchemaForRemoting(){} // RVA: 0x7143EE0
        public void ReadXmlSchema(){} // RVA: 0x7144100
        public void MoveToElement(){} // RVA: 0x7144D30
        public void ReadEndElement(){} // RVA: 0x7127DD0
        public void ReadXSDSchema(){} // RVA: 0x7144DC0
        public void ReadXDRSchema(){} // RVA: 0x7145190
        public void WriteXmlSchema(){} // RVA: 0x7145470
        public void ReadXml(){} // RVA: 0x7148480
        public void InferSchema(){} // RVA: 0x7146C90
        public void IsEmpty(){} // RVA: 0x7146FC0
        public void ReadXmlDiffgram(){} // RVA: 0x71471A0
        public void WriteXml(){} // RVA: 0x71496C0
        public void Merge(){} // RVA: 0x7149990
        public void OnPropertyChanging(){} // RVA: 0x7149BA0
        public void OnMergeFailed(){} // RVA: 0x7149BD0
        public void RaiseMergeFailed(){} // RVA: 0x7149C50
        public void OnDataRowCreated(){} // RVA: 0x7149E30
        public void OnClearFunctionCalled(){} // RVA: 0x7149E60
        public void OnInitialized(){} // RVA: 0x7149E90
        public void OnRemoveTable(){} // RVA: 0xB43310
        public void OnRemovedTable(){} // RVA: 0x7149F10
        public void OnRemoveRelation(){} // RVA: 0xB43310
        public void OnRemoveRelationHack(){} // RVA: 0x7054390
        public void RaisePropertyChanging(){} // RVA: 0x7149F60
        public void TopLevelTables(){} // RVA: 0x7149FF0
        public void Reset(){} // RVA: 0x714A230
        public void ValidateCaseConstraint(){} // RVA: 0x714A480
        public void ValidateLocaleConstraint(){} // RVA: 0x714A830
        public void FindTable(){} // RVA: 0x714AC60
        public void ReadXmlSerializable(){} // RVA: 0x714ADE0
        public void GetDataSetSchema(){} // RVA: 0x714B470
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x714B940
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x714BB50
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x714BCB0
        public void get_MainTableName(){} // RVA: 0xC10050
        public void set_MainTableName(){} // RVA: 0xC10060
        public void get_ObjectID(){} // RVA: 0x14780B0
    }

    public class DataSetClearEventhandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DataTable : MarshalByValueComponent
    {
        public object _dataSet;
        public object _defaultView;
        public object _nextRowID;
        public object _rowCollection;
        public object _columnCollection;
        public object _constraintCollection;
        public object _elementColumnCount;
        public object _parentRelationsCollection;
        public object _childRelationsCollection;
        public object _recordManager;
        public object _indexes;
        public object _shadowIndexes;
        public object _shadowCount;
        public object _extendedProperties;
        public object _tableName;
        public object _tableNamespace;
        public object _tablePrefix;
        public object _displayExpression;
        public object _fNestedInDataset;
        public object _culture;
        public object _cultureUserSet;
        public object _compareInfo;
        public object _compareFlags;
        public object _formatProvider;
        public object _hashCodeProvider;
        public object _caseSensitive;
        public object _caseSensitiveUserSet;
        public object _encodedTableName;
        public object _xmlText;
        public object _colUnique;
        public object _minOccurs;
        public object _maxOccurs;
        public object _repeatableElement;
        public object _typeName;
        public object _primaryKey;
        public object _primaryIndex;
        public object _delayedSetPrimaryKey;
        public object _loadIndex;
        public object _loadIndexwithOriginalAdded;
        public object _loadIndexwithCurrentDeleted;
        public object _suspendIndexEvents;
        public object _inDataLoad;
        public object _schemaLoading;
        public object _enforceConstraints;
        public object _suspendEnforceConstraints;
        public object fInitInProgress;
        public object _inLoad;
        public object _fInLoadDiffgram;
        public object _isTypedDataTable;
        public object _emptyDataRowArray;
        public object _propertyDescriptorCollectionCache;
        public object _nestedParentRelations;
        public object _dependentColumns;
        public object _mergingData;
        public object _onRowChangedDelegate;
        public object _onRowChangingDelegate;
        public object _onRowDeletingDelegate;
        public object _onRowDeletedDelegate;
        public object _onColumnChangedDelegate;
        public object _onColumnChangingDelegate;
        public object _onTableClearingDelegate;
        public object _onTableClearedDelegate;
        public object _onTableNewRowDelegate;
        public object _onPropertyChangingDelegate;
        public object _onInitialized;
        public object _rowBuilder;
        public object _delayedViews;
        public object _dataViewListeners;
        public object _rowDiffId;
        public object _indexesLock;
        public object _ukColumnPositionForInference;
        public object _remotingFormat;
        public object s_objectTypeCount;
        public object _objectID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x710C2E0
        public void GetObjectData(){} // RVA: 0x710C530
        public void SerializeDataTable(){} // RVA: 0x710C620
        public void DeserializeDataTable(){} // RVA: 0x710D280
        public void SerializeTableSchema(){} // RVA: 0x710D620
        public void DeserializeTableSchema(){} // RVA: 0x710FD70
        public void SerializeConstraints(){} // RVA: 0x7111970
        public void DeserializeConstraints(){} // RVA: 0x7112380
        public void SerializeExpressionColumns(){} // RVA: 0x7112F50
        public void DeserializeExpressionColumns(){} // RVA: 0x7113380
        public void SerializeTableData(){} // RVA: 0x7113590
        public void DeserializeTableData(){} // RVA: 0x71146A0
        public void ConvertToRowState(){} // RVA: 0x71154C0
        public void GetRowAndColumnErrors(){} // RVA: 0x71155A0
        public void ConvertToRowError(){} // RVA: 0x7115940
        public void get_CaseSensitive(){} // RVA: 0x1DFD090
        public void set_CaseSensitive(){} // RVA: 0x7115CC0
        public void get_AreIndexEventsSuspended(){} // RVA: 0x7115D80
        public void RestoreIndexEvents(){} // RVA: 0x7115D90
        public void SuspendIndexEvents(){} // RVA: 0x7116070
        public void get_IsInitialized(){} // RVA: 0x7116100
        public void get_IsTypedDataTable(){} // RVA: 0x7116110
        public void SetCaseSensitiveValue(){} // RVA: 0x71161D0
        public void ShouldSerializeCaseSensitive(){} // RVA: 0x71164B0
        public void get_SelfNested(){} // RVA: 0x71164C0
        public void get_LiveIndexes(){} // RVA: 0x71166C0
        public void get_RemotingFormat(){} // RVA: 0x71167A0
        public void set_RemotingFormat(){} // RVA: 0x71167B0
        public void get_UKColumnPositionForInference(){} // RVA: 0x6E15F80
        public void set_UKColumnPositionForInference(){} // RVA: 0x6E15F90
        public void get_ChildRelations(){} // RVA: 0x7116830
        public void get_Columns(){} // RVA: 0xBC1B30
        public void get_CompareInfo(){} // RVA: 0x71168E0
        public void get_Constraints(){} // RVA: 0xBBF8F0
        public void ResetConstraints(){} // RVA: 0x7116980
        public void get_DataSet(){} // RVA: 0xB700F0
        public void SetDataSet(){} // RVA: 0x71169A0
        public void get_DefaultView(){} // RVA: 0x7116B10
        public void get_DisplayExpressionInternal(){} // RVA: 0x7116CE0
        public void get_EnforceConstraints(){} // RVA: 0x7116D60
        public void set_EnforceConstraints(){} // RVA: 0x7116D90
        public void get_SuspendEnforceConstraints(){} // RVA: 0x7116DD0
        public void set_SuspendEnforceConstraints(){} // RVA: 0x7116DE0
        public void EnableConstraints(){} // RVA: 0x7116DF0
        public void get_ExtendedProperties(){} // RVA: 0x7117340
        public void get_FormatProvider(){} // RVA: 0x7117410
        public void get_Locale(){} // RVA: 0xBAE3B0
        public void set_Locale(){} // RVA: 0x7117500
        public void SetLocaleValue(){} // RVA: 0x71179B0
        public void ShouldSerializeLocale(){} // RVA: 0xB63970
        public void get_MinimumCapacity(){} // RVA: 0x7118030
        public void set_MinimumCapacity(){} // RVA: 0x7118050
        public void get_RecordCapacity(){} // RVA: 0x71180A0
        public void get_ElementColumnCount(){} // RVA: 0xE32C80
        public void set_ElementColumnCount(){} // RVA: 0x71180C0
        public void get_ParentRelations(){} // RVA: 0x7118110
        public void get_MergingData(){} // RVA: 0x6E15480
        public void set_MergingData(){} // RVA: 0x6E15490
        public void get_NestedParentRelations(){} // RVA: 0x1667D40
        public void get_SchemaLoading(){} // RVA: 0x1142480
        public void CacheNestedParent(){} // RVA: 0x71181C0
        public void FindNestedParentRelations(){} // RVA: 0x7118230
        public void get_NestedParentsCount(){} // RVA: 0x7118560
        public void get_PrimaryKey(){} // RVA: 0x71187D0
        public void set_PrimaryKey(){} // RVA: 0x7118840
        public void get_Rows(){} // RVA: 0xD05CA0
        public void get_TableName(){} // RVA: 0x1069350
        public void set_TableName(){} // RVA: 0x7118E30
        public void get_EncodedTableName(){} // RVA: 0x71195D0
        public void GetInheritedNamespace(){} // RVA: 0x71196E0
        public void get_Namespace(){} // RVA: 0x7119960
        public void set_Namespace(){} // RVA: 0x71199F0
        public void IsNamespaceInherited(){} // RVA: 0x7119CB0
        public void CheckCascadingNamespaceConflict(){} // RVA: 0x7119CC0
        public void CheckNamespaceValidityForNestedRelations(){} // RVA: 0x7119FB0
        public void CheckNamespaceValidityForNestedParentRelations(){} // RVA: 0x711A300
        public void DoRaiseNamespaceChange(){} // RVA: 0x711A5A0
        public void BeginInit(){} // RVA: 0x711AAA0
        public void EndInit(){} // RVA: 0x711AAB0
        public void get_Prefix(){} // RVA: 0x106A050
        public void set_Prefix(){} // RVA: 0x711B040
        public void get_XmlText(){} // RVA: 0x135A7B0
        public void set_XmlText(){} // RVA: 0x711B280
        public void get_MaxOccurs(){} // RVA: 0x711B4E0
        public void set_MaxOccurs(){} // RVA: 0x711B4F0
        public void get_MinOccurs(){} // RVA: 0x6D09AE0
        public void set_MinOccurs(){} // RVA: 0x6D09AF0
        public void SetKeyValues(){} // RVA: 0x711B500
        public void FindByIndex(){} // RVA: 0x711B590
        public void FindMergeTarget(){} // RVA: 0x711B630
        public void SetMergeRecords(){} // RVA: 0x711B710
        public void MergeRow(){} // RVA: 0x711B850
        public void CreateInstance(){} // RVA: 0x711C080
        public void Clone(){} // RVA: 0x711C120
        public void IncrementalCloneTo(){} // RVA: 0x711C2A0
        public void CloneHierarchy(){} // RVA: 0x711C550
        public void CloneTo(){} // RVA: 0x711C9A0
        public void add_Initialized(){} // RVA: 0x711DB00
        public void remove_Initialized(){} // RVA: 0x711DC00
        public void get_Site(){} // RVA: 0xB5DBF0
        public void set_Site(){} // RVA: 0x711DD00
        public void AddRow(){} // RVA: 0x711DEC0
        public void InsertRow(){} // RVA: 0x711F9E0
        public void CheckNotModifying(){} // RVA: 0x711E330
        public void Clear(){} // RVA: 0x711E370
        public void CascadeAll(){} // RVA: 0x711ED60
        public void CommitRow(){} // RVA: 0x711EE90
        public void Compare(){} // RVA: 0x711F010
        public void IndexOf(){} // RVA: 0x711F190
        public void IsSuffix(){} // RVA: 0x711F200
        public void System.ComponentModel.IListSource.get_ContainsListCollection(){} // RVA: 0xB43320
        public void DeleteRow(){} // RVA: 0x711F270
        public void FormatSortString(){} // RVA: 0x711F320
        public void FreeRecord(){} // RVA: 0x711F470
        public void GetIndex(){} // RVA: 0x711F4E0
        public void System.ComponentModel.IListSource.GetList(){} // RVA: 0x711F7F0
        public void GetListeners(){} // RVA: 0x164EDD0
        public void GetSpecialHashCode(){} // RVA: 0x711F800
        public void NewRecord(){} // RVA: 0x711FEB0
        public void NewUninitializedRecord(){} // RVA: 0x711FE90
        public void NewEmptyRow(){} // RVA: 0x711FFC0
        public void NewUninitializedRow(){} // RVA: 0x7120040
        public void NewRow(){} // RVA: 0x71205C0
        public void CreateEmptyRow(){} // RVA: 0x7120190
        public void NewRowCreated(){} // RVA: 0x71204C0
        public void NewRowFromBuilder(){} // RVA: 0x71206B0
        public void GetRowType(){} // RVA: 0x7120820
        public void NewRowArray(){} // RVA: 0x71208A0
        public void get_NeedColumnChangeEvents(){} // RVA: 0x7120A40
        public void OnColumnChanging(){} // RVA: 0x7120A80
        public void OnColumnChanged(){} // RVA: 0x7120B40
        public void OnPropertyChanging(){} // RVA: 0x7120C00
        public void OnRemoveColumnInternal(){} // RVA: 0x7120CC0
        public void OnRemoveColumn(){} // RVA: 0xB43310
        public void OnRowChanged(){} // RVA: 0x7120E40
        public void OnRowChanging(){} // RVA: 0x7120F00
        public void OnRowDeleting(){} // RVA: 0x7120FC0
        public void OnRowDeleted(){} // RVA: 0x7121080
        public void OnTableCleared(){} // RVA: 0x7121140
        public void OnTableClearing(){} // RVA: 0x7121200
        public void OnTableNewRow(){} // RVA: 0x71212C0
        public void OnInitialized(){} // RVA: 0x7121380
        public void ParseSortString(){} // RVA: 0x7121480
        public void RaisePropertyChanging(){} // RVA: 0x7121D40
        public void RecordChanged(){} // RVA: 0x7121EF0
        public void RecordStateChanged(){} // RVA: 0x71221C0
        public void RemoveRecordFromIndexes(){} // RVA: 0x71223A0
        public void InsertRecordToIndexes(){} // RVA: 0x7122620
        public void SilentlySetValue(){} // RVA: 0x7122850
        public void RemoveRow(){} // RVA: 0x7122AA0
        public void Reset(){} // RVA: 0x7122E50
        public void ResetIndexes(){} // RVA: 0x7123110
        public void ResetInternalIndexes(){} // RVA: 0x7123120
        public void RollbackRow(){} // RVA: 0x71232B0
        public void RaiseRowChanged(){} // RVA: 0x7123350
        public void RaiseRowChanging(){} // RVA: 0x7123790
        public void SetNewRecord(){} // RVA: 0x7123950
        public void SetNewRecordWorker(){} // RVA: 0x71239D0
        public void SetOldRecord(){} // RVA: 0x71245B0
        public void RestoreShadowIndexes(){} // RVA: 0x7124AB0
        public void SetShadowIndexes(){} // RVA: 0x7124B20
        public void ShadowIndexCopy(){} // RVA: 0x7124BB0
        public void ToString(){} // RVA: 0x7124C90
        public void UpdatingCurrent(){} // RVA: 0x7124D40
        public void AddUniqueKey(){} // RVA: 0x71250B0
        public void AddForeignKey(){} // RVA: 0x71250C0
        public void UpdatePropertyDescriptorCollectionCache(){} // RVA: 0x7125180
        public void GetPropertyDescriptorCollection(){} // RVA: 0x71251E0
        public void get_TypeName(){} // RVA: 0x7125690
        public void set_TypeName(){} // RVA: 0x1658000
        public void Merge(){} // RVA: 0x7125760
        public void WriteXml(){} // RVA: 0x7125970
        public void CheckForClosureOnExpressions(){} // RVA: 0x7125CE0
        public void CheckForClosureOnExpressionTables(){} // RVA: 0x7125DB0
        public void WriteXmlSchema(){} // RVA: 0x7126150
        public void RestoreConstraint(){} // RVA: 0x71264C0
        public void IsEmptyXml(){} // RVA: 0x7126520
        public void ReadXml(){} // RVA: 0x7126840
        public void ReadEndElement(){} // RVA: 0x7127DD0
        public void ReadXDRSchema(){} // RVA: 0x7127E90
        public void MoveToElement(){} // RVA: 0x7127F10
        public void ReadXmlDiffgram(){} // RVA: 0x7127FF0
        public void ReadXSDSchema(){} // RVA: 0x7128AD0
        public void ReadXmlSchema(){} // RVA: 0x7128DA0
        public void CreateTableList(){} // RVA: 0x7129E50
        public void CreateRelationList(){} // RVA: 0x712A180
        public void GetDataTableSchema(){} // RVA: 0x712A4F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x6935620
        public void GetSchema(){} // RVA: 0x712A900
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x712AB00
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x712ABD0
        public void ReadXmlSerializable(){} // RVA: 0x712AC20
        public void get_RowDiffId(){} // RVA: 0x712AC40
        public void get_ObjectID(){} // RVA: 0x2303CF0
        public void AddDependentColumn(){} // RVA: 0x712AD00
        public void RemoveDependentColumn(){} // RVA: 0x712AE20
        public void EvaluateExpressions(){} // RVA: 0x712B7D0
        public void EvaluateDependentExpressions(){} // RVA: 0x712BC40
    }

    public class DataTableClearEventArgs : EventArgs
    {
        public object _table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x716E1A0
    }

    public class DataTableClearEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DataTableCollection : InternalDataCollectionBase
    {
        public object _dataSet;
        public object _list;
        public object _defaultNameIndex;
        public object _delayedAddRangeTables;
        public object _onCollectionChangedDelegate;
        public object _onCollectionChangingDelegate;
        public object s_objectTypeCount;
        public object _objectID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x716E240
        public void get_List(){} // RVA: 0xB465B0
        public void get_ObjectID(){} // RVA: 0xBE5850
        public void get_Item(){} // RVA: 0x716E5F0
        public void GetTable(){} // RVA: 0x716E720
        public void GetTableSmart(){} // RVA: 0x716E8B0
        public void Add(){} // RVA: 0x716EA60
        public void add_CollectionChanged(){} // RVA: 0x716EC70
        public void remove_CollectionChanged(){} // RVA: 0x716EDD0
        public void ArrayAdd(){} // RVA: 0x716EF30
        public void AssignName(){} // RVA: 0x716EF60
        public void BaseAdd(){} // RVA: 0x716EFD0
        public void BaseGroupSwitch(){} // RVA: 0x716F1B0
        public void BaseRemove(){} // RVA: 0x716F370
        public void CanRemove(){} // RVA: 0x716F430
        public void Clear(){} // RVA: 0x716F920
        public void Contains(){} // RVA: 0x716FE90
        public void IndexOf(){} // RVA: 0x7170190
        public void ReplaceFromInference(){} // RVA: 0x7170220
        public void InternalIndexOf(){} // RVA: 0x71704B0
        public void FinishInitCollection(){} // RVA: 0x71706C0
        public void MakeName(){} // RVA: 0x7170780
        public void OnCollectionChanged(){} // RVA: 0x7170830
        public void OnCollectionChanging(){} // RVA: 0x71708F0
        public void RegisterName(){} // RVA: 0x71709B0
        public void Remove(){} // RVA: 0x7170DD0
        public void UnregisterName(){} // RVA: 0x7170F40
    }

    public class DataTableNewRowEventArgs : EventArgs
    {
        public object _row;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71710D0
    }

    public class DataTableNewRowEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DataTablePropertyDescriptor : PropertyDescriptor
    {
        public object _table;

        // ── Methods ──
        public void get_Table(){} // RVA: 0xB813B0
        public void .ctor(){} // RVA: 0x7171170
        public void get_ComponentType(){} // RVA: 0x7171210
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_PropertyType(){} // RVA: 0x7171290
        public void Equals(){} // RVA: 0x7171310
        public void GetHashCode(){} // RVA: 0x715EE10
        public void CanResetValue(){} // RVA: 0xB43320
        public void GetValue(){} // RVA: 0x71713B0
        public void ResetValue(){} // RVA: 0xB43310
        public void SetValue(){} // RVA: 0xB43310
        public void ShouldSerializeValue(){} // RVA: 0xB43320
    }

    public class DataTableTypeConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7171490
        public void GetPropertiesSupported(){} // RVA: 0xB43320
    }

    public class DataTextReader : XmlReader
    {
        public object _xmlreader;

        // ── Methods ──
        public void CreateReader(){} // RVA: 0x71DA310
        public void .ctor(){} // RVA: 0x71DA3E0
        public void get_Settings(){} // RVA: 0x10ACB60
        public void get_NodeType(){} // RVA: 0x10AD460
        public void get_Name(){} // RVA: 0x6AE07D0
        public void get_LocalName(){} // RVA: 0x1085C80
        public void get_NamespaceURI(){} // RVA: 0x678C220
        public void get_Prefix(){} // RVA: 0x678C250
        public void get_Value(){} // RVA: 0x22368C0
        public void get_Depth(){} // RVA: 0x7048FE0
        public void get_BaseURI(){} // RVA: 0x10ADE70
        public void get_IsEmptyElement(){} // RVA: 0x10AD020
        public void get_IsDefault(){} // RVA: 0x10AE060
        public void get_QuoteChar(){} // RVA: 0x10AD890
        public void get_XmlSpace(){} // RVA: 0x10ACFC0
        public void get_XmlLang(){} // RVA: 0x10AC4B0
        public void get_AttributeCount(){} // RVA: 0x6E669C0
        public void GetAttribute(){} // RVA: 0x71DA4B0
        public void MoveToAttribute(){} // RVA: 0x71DA510
        public void MoveToFirstAttribute(){} // RVA: 0x678C400
        public void MoveToNextAttribute(){} // RVA: 0x687B750
        public void MoveToElement(){} // RVA: 0x687B780
        public void ReadAttributeValue(){} // RVA: 0x6ADFF00
        public void Read(){} // RVA: 0x71DA540
        public void get_EOF(){} // RVA: 0x71DA570
        public void Close(){} // RVA: 0x6AE0990
        public void get_ReadState(){} // RVA: 0x71DA5A0
        public void Skip(){} // RVA: 0x66B0FE0
        public void get_NameTable(){} // RVA: 0x6ADFA50
        public void LookupNamespace(){} // RVA: 0x71DA5D0
        public void get_CanResolveEntity(){} // RVA: 0x71DA600
        public void ResolveEntity(){} // RVA: 0x71DA630
        public void get_CanReadValueChunk(){} // RVA: 0x6886990
        public void ReadString(){} // RVA: 0x71DA660
    }

    public class DataTextWriter : XmlWriter
    {
        public object _xmltextWriter;

        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x71D9E70
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_BaseStream(){} // RVA: 0x71D9F00
        public void WriteStartDocument(){} // RVA: 0x71D9F80
        public void WriteEndDocument(){} // RVA: 0x68B1FB0
        public void WriteDocType(){} // RVA: 0x71D9FB0
        public void WriteStartElement(){} // RVA: 0x71D9FE0
        public void WriteEndElement(){} // RVA: 0x673B450
        public void WriteFullEndElement(){} // RVA: 0x71DA010
        public void WriteStartAttribute(){} // RVA: 0x71DA040
        public void WriteEndAttribute(){} // RVA: 0x673B480
        public void WriteCData(){} // RVA: 0x71DA070
        public void WriteComment(){} // RVA: 0x71DA0A0
        public void WriteProcessingInstruction(){} // RVA: 0x71DA0D0
        public void WriteEntityRef(){} // RVA: 0x71DA100
        public void WriteCharEntity(){} // RVA: 0x71DA130
        public void WriteWhitespace(){} // RVA: 0x71DA160
        public void WriteString(){} // RVA: 0x71DA190
        public void WriteSurrogateCharEntity(){} // RVA: 0x71DA1C0
        public void WriteChars(){} // RVA: 0x71DA1F0
        public void WriteRaw(){} // RVA: 0x71DA250
        public void WriteBase64(){} // RVA: 0x71DA280
        public void WriteBinHex(){} // RVA: 0x71DA2B0
        public void get_WriteState(){} // RVA: 0x6806AC0
        public void Close(){} // RVA: 0x6806A60
        public void Flush(){} // RVA: 0x6806A30
        public void LookupPrefix(){} // RVA: 0x71DA2E0
    }

    public class DataView : MarshalByValueComponent
    {
        public object _dataViewManager;
        public object _table;
        public object _locked;
        public object _index;
        public object _findIndexes;
        public object _sort;
        public object _comparison;
        public object _rowFilter;
        public object _recordStates;
        public object _shouldOpen;
        public object _open;
        public object _allowNew;
        public object _allowEdit;
        public object _allowDelete;
        public object _applyDefaultSort;
        public object _addNewRow;
        public object _addNewMoved;
        public object _onListChanged;
        public object s_resetEventArgs;
        public object _delayedTable;
        public object _delayedRowFilter;
        public object _delayedSort;
        public object _delayedRecordStates;
        public object _fInitInProgress;
        public object _fEndInitInProgress;
        public object _rowViewCache;
        public object _rowViewBuffer;
        public object _dvListener;
        public object s_objectTypeCount;
        public object _objectID;
        public object Initialized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7171A60
        public void get_AllowDelete(){} // RVA: 0xC10030
        public void get_AllowEdit(){} // RVA: 0x7171AE0
        public void get_AllowNew(){} // RVA: 0x7171AF0
        public void get_Count(){} // RVA: 0x7171B00
        public void get_CountFromIndex(){} // RVA: 0x7171B50
        public void get_DataViewManager(){} // RVA: 0xB700F0
        public void get_IsInitialized(){} // RVA: 0x7171B80
        public void get_IsOpen(){} // RVA: 0x1D3EFC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void get_RowFilter(){} // RVA: 0x7171B90
        public void set_RowFilter(){} // RVA: 0x7171C30
        public void get_RowStateFilter(){} // RVA: 0xD347A0
        public void set_RowStateFilter(){} // RVA: 0x7171EC0
        public void get_Sort(){} // RVA: 0x7172010
        public void set_Sort(){} // RVA: 0x71721C0
        public void get_SortComparison(){} // RVA: 0xBE58B0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void get_Table(){} // RVA: 0xB70160
        public void set_Table(){} // RVA: 0x71724B0
        public void System.Collections.IList.get_Item(){} // RVA: 0x71727C0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7172830
        public void get_Item(){} // RVA: 0x71727C0
        public void AddNew(){} // RVA: 0x7172860
        public void BeginInit(){} // RVA: 0x7172BD0
        public void EndInit(){} // RVA: 0x7172BE0
        public void CheckOpen(){} // RVA: 0x7173010
        public void CheckSort(){} // RVA: 0x7173050
        public void Close(){} // RVA: 0x71730B0
        public void CopyTo(){} // RVA: 0x7173320
        public void Delete(){} // RVA: 0x71735E0
        public void Dispose(){} // RVA: 0x7173750
        public void FinishAddNew(){} // RVA: 0x71737C0
        public void GetEnumerator(){} // RVA: 0x7173A40
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IList.Add(){} // RVA: 0x7173AF0
        public void System.Collections.IList.Clear(){} // RVA: 0x7173B80
        public void System.Collections.IList.Contains(){} // RVA: 0x7173BB0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7173C40
        public void IndexOf(){} // RVA: 0x7173CD0
        public void IndexOfDataRowView(){} // RVA: 0x7173DF0
        public void System.Collections.IList.Insert(){} // RVA: 0x7173EA0
        public void System.Collections.IList.Remove(){} // RVA: 0x7173ED0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x71735B0
        public void GetFindIndex(){} // RVA: 0x7173FB0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7171AF0
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x6251290
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7171AE0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0xC10030
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x71741E0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7174210
        public void GetSortProperty(){} // RVA: 0x71742B0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7174340
        public void add_ListChanged(){} // RVA: 0x7174380
        public void remove_ListChanged(){} // RVA: 0x71744E0
        public void add_Initialized(){} // RVA: 0x7174640
        public void remove_Initialized(){} // RVA: 0x7174740
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7174840
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7174890
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x71748C0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7174BA0
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7174BF0
        public void System.ComponentModel.IBindingListView.ApplySort(){} // RVA: 0x7174CA0
        public void CreateSortString(){} // RVA: 0x7175080
        public void System.ComponentModel.IBindingListView.RemoveFilter(){} // RVA: 0x7175200
        public void System.ComponentModel.IBindingListView.get_Filter(){} // RVA: 0x71752B0
        public void System.ComponentModel.IBindingListView.set_Filter(){} // RVA: 0x71752D0
        public void System.ComponentModel.IBindingListView.get_SortDescriptions(){} // RVA: 0x71752F0
        public void GetSortDescriptions(){} // RVA: 0x7175300
        public void System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingListView.get_SupportsFiltering(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x71756E0
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7175760
        public void GetFilter(){} // RVA: 0xC0FFC0
        public void GetRecord(){} // RVA: 0x7175840
        public void GetRow(){} // RVA: 0x7175900
        public void GetRowView(){} // RVA: 0x7175B00
        public void IndexListChanged(){} // RVA: 0x7175B60
        public void IndexListChangedInternal(){} // RVA: 0x7175BF0
        public void MaintainDataView(){} // RVA: 0x7175CC0
        public void OnListChanged(){} // RVA: 0x7175FE0
        public void OnInitialized(){} // RVA: 0x71762C0
        public void Reset(){} // RVA: 0x7176340
        public void ResetRowViewCache(){} // RVA: 0x7176370
        public void SetDataViewManager(){} // RVA: 0x7176750
        public void SetIndex(){} // RVA: 0x7176930
        public void SetIndex2(){} // RVA: 0x7176950
        public void UpdateIndex(){} // RVA: 0x7176D40
        public void ChildRelationCollectionChanged(){} // RVA: 0x7177070
        public void ParentRelationCollectionChanged(){} // RVA: 0x71772C0
        public void ColumnCollectionChanged(){} // RVA: 0x7177510
        public void ColumnCollectionChangedInternal(){} // RVA: 0x71777B0
        public void get_ObjectID(){} // RVA: 0xE35F30
        public void .cctor(){} // RVA: 0x71777D0
    }

    public class DataViewListener : Object
    {
        public object _dvWeak;
        public object _table;
        public object _index;
        public object _objectID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7177990
        public void ChildRelationCollectionChanged(){} // RVA: 0x7177A70
        public void ParentRelationCollectionChanged(){} // RVA: 0x7177B50
        public void ColumnCollectionChanged(){} // RVA: 0x7177C30
        public void MaintainDataView(){} // RVA: 0x7177D20
        public void IndexListChanged(){} // RVA: 0x7177E10
        public void RegisterMetaDataEvents(){} // RVA: 0x7177FA0
        public void UnregisterMetaDataEvents(){} // RVA: 0x71783D0
        public void RegisterListChangedEvent(){} // RVA: 0x7178910
        public void UnregisterListChangedEvent(){} // RVA: 0x7178B40
        public void CleanUp(){} // RVA: 0x7178D10
        public void RegisterListener(){} // RVA: 0x7178D30
    }

    public class DataViewManager : MarshalByValueComponent
    {
        public object _dataViewSettingsCollection;
        public object _dataSet;
        public object _item;
        public object _locked;
        public object _nViews;
        public object s_notSupported;
        public object ListChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7178FC0
        public void get_DataSet(){} // RVA: 0xB70160
        public void get_DataViewSettings(){} // RVA: 0xB700F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x71794C0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0xC3CCE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7179550
        public void System.Collections.IList.get_Item(){} // RVA: 0xD33E60
        public void System.Collections.IList.set_Item(){} // RVA: 0x7179610
        public void System.Collections.IList.Add(){} // RVA: 0x7179640
        public void System.Collections.IList.Clear(){} // RVA: 0x7179670
        public void System.Collections.IList.Contains(){} // RVA: 0x71796A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x71796B0
        public void System.Collections.IList.Insert(){} // RVA: 0x71796D0
        public void System.Collections.IList.Remove(){} // RVA: 0x7179700
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7179730
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7179760
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x71797B0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7179800
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7179850
        public void add_ListChanged(){} // RVA: 0x71798A0
        public void remove_ListChanged(){} // RVA: 0x7179990
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0xB43310
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7179A80
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7179AD0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0xB43310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7179B20
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7179B70
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7179C00
        public void CreateDataView(){} // RVA: 0x7179D60
        public void OnListChanged(){} // RVA: 0x7179E10
        public void TableCollectionChanged(){} // RVA: 0x7179E60
        public void RelationCollectionChanged(){} // RVA: 0x717A110
        public void .cctor(){} // RVA: 0x717A360
    }

    public class DataViewManagerListItemTypeDescriptor : Object
    {
        public object _dataViewManager;
        public object _propsCollection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetDataView(){} // RVA: 0x717A450
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x717A4D0
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x717A570
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x717A600
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x2303260
    }

    public class DataViewSetting : Object
    {
        public object _dataViewManager;
        public object _table;
        public object _sort;
        public object _rowFilter;
        public object _rowStateFilter;
        public object _applyDefaultSort;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x717A8F0
        public void get_ApplyDefaultSort(){} // RVA: 0xB78D60
        public void SetDataViewManager(){} // RVA: 0x7161990
        public void SetDataTable(){} // RVA: 0x717A9D0
        public void get_RowFilter(){} // RVA: 0xB70160
        public void get_RowStateFilter(){} // RVA: 0xB9E080
        public void get_Sort(){} // RVA: 0xB700F0
    }

    public class DataViewSettingCollection : Object
    {
        public object _dataViewManager;
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x717AA30
        public void get_Item(){} // RVA: 0x717AB80
        public void set_Item(){} // RVA: 0x717AD70
        public void CopyTo(){} // RVA: 0x717AEA0
        public void get_Count(){} // RVA: 0x717B070
        public void GetEnumerator(){} // RVA: 0x717B0C0
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void Remove(){} // RVA: 0x717B120
    }

    public class DefaultValueTypeConverter : StringConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ConvertTo(){} // RVA: 0x717B4D0
        public void ConvertFrom(){} // RVA: 0x717B670
    }

    public class DeletedRowInaccessibleException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135D90
    }

    public class DuplicateNameException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135E00
    }

}