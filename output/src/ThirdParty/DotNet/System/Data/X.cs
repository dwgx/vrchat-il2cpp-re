// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 197

namespace ThirdParty.DotNet.System.Data
{
    public class XDRSchema : XMLSchema
    {
        public string _schemaName; // 0x10
        public string _schemaUri; // 0x18
        public System.Xml.XmlElement _schemaRoot; // 0x20
        public System.Data.DataSet _ds; // 0x28
        public char[] s_colonArray;
        public NameType[] s_mapNameTypeXdr; // 0x8
        public NameType s_enumerationNameType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8ECE990
        public void LoadSchema(){} // RVA: 0x7FFAC8ECEB40
        public void FindTypeNode(){} // RVA: 0x7FFAC8ECEFB0
        public void IsTextOnlyContent(){} // RVA: 0x7FFAC8ECF570
        public void IsXDRField(){} // RVA: 0x7FFAC8ECF800
        public void HandleTable(){} // RVA: 0x7FFAC8ECFA10
        public void FindNameType(){} // RVA: 0x7FFAC8ECFC40
        public void ParseDataType(){} // RVA: 0x7FFAC8ECFDE0
        public void GetInstanceName(){} // RVA: 0x7FFAC8ECFFC0
        public void HandleColumn(){} // RVA: 0x7FFAC8ED02A0
        public void GetMinMax(){} // RVA: 0x7FFAC8ED0E80 | overloaded x2
        public void HandleTypeNode(){} // RVA: 0x7FFAC8ED12C0
        public void InstantiateTable(){} // RVA: 0x7FFAC8ED14F0
        public void InstantiateSimpleTable(){} // RVA: 0x7FFAC8ED1BC0
        public void .cctor(){} // RVA: 0x7FFAC8ED1EF0
    }

    public class XMLDiffLoader : Object
    {
        public System.Collections.ArrayList _tables; // 0x10
        public System.Data.DataSet _dataSet; // 0x18
        public System.Data.DataTable _dataTable; // 0x20

        // ── Methods ──
        public void LoadDiffGram(){} // RVA: 0x7FFAC8ED3F80 | overloaded x2
        public void CreateTablesHierarchy(){} // RVA: 0x7FFAC8ED3C90
        public void ProcessDiffs(){} // RVA: 0x7FFAC8ED4760 | overloaded x2
        public void ProcessErrors(){} // RVA: 0x7FFAC8ED4FC0 | overloaded x2
        public void GetTable(){} // RVA: 0x7FFAC8ED5530
        public void ReadOldRowData(){} // RVA: 0x7FFAC8ED57F0
        public void SkipWhitespaces(){} // RVA: 0x7FFAC8ED68D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XMLSchema : Object
    {
        // ── Methods ──
        public void GetConverter(){} // RVA: 0x7FFAC8ED6940
        public void SetProperties(){} // RVA: 0x7FFAC8ED6990
        public void FEqualIdentity(){} // RVA: 0x7FFAC8ED6E90
        public void GetBooleanAttribute(){} // RVA: 0x7FFAC8ED6F80
        public void GenUniqueColumnName(){} // RVA: 0x7FFAC8ED7160
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XSDSchema : XMLSchema
    {
        public System.Xml.Schema.XmlSchemaSet FromInference; // 0x10
        public System.Xml.Schema.XmlSchemaElement _dsElement; // 0x18
        public System.Data.DataSet _ds; // 0x20
        public string _schemaName; // 0x28
        public System.Collections.ArrayList _columnExpressions; // 0x30
        public System.Collections.Hashtable _constraintNodes; // 0x38
        public System.Collections.ArrayList _refTables; // 0x40
        public System.Collections.ArrayList _complexTypes; // 0x48
        public System.Xml.Schema.XmlSchemaObjectCollection _annotations; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection _elements; // 0x58
        public System.Collections.Hashtable _attributes; // 0x60
        public System.Collections.Hashtable _elementsTable; // 0x68
        public System.Collections.Hashtable _attributeGroups; // 0x70
        public System.Collections.Hashtable _schemaTypes; // 0x78
        public System.Collections.Hashtable _expressions; // 0x80
        public System.Collections.Generic.Dictionary`2<System.Data.DataTable,System.Collections.Generic.List`1<System.Data.DataTable>> _tableDictionary; // 0x88
        public System.Collections.Hashtable _udSimpleTypes; // 0x90
        public System.Collections.Hashtable _existingSimpleTypeMap; // 0x98
        public bool _fromInference; // 0xA0
        public NameType[] s_mapNameTypeXsd;

        // ── Methods ──
        public void get_FromInference(){} // RVA: 0x7FFAC45C9D50
        public void set_FromInference(){} // RVA: 0x7FFAC37B1910
        public void CollectElementsAnnotations(){} // RVA: 0x7FFAC8ED73F0 | overloaded x2
        public void QualifiedName(){} // RVA: 0x7FFAC8ED7E60
        public void SetProperties(){} // RVA: 0x7FFAC8ED7ED0
        public void SetExtProperties(){} // RVA: 0x7FFAC8ED9010 | overloaded x2
        public void HandleColumnExpression(){} // RVA: 0x7FFAC8ED8BF0
        public void GetMsdataAttribute(){} // RVA: 0x7FFAC8ED8E80
        public void HandleRefTableProperties(){} // RVA: 0x7FFAC8ED92C0
        public void HandleRelation(){} // RVA: 0x7FFAC8ED93C0
        public void HasAttributes(){} // RVA: 0x7FFAC8ED9DE0
        public void IsDatasetParticle(){} // RVA: 0x7FFAC8EDA020
        public void DatasetElementCount(){} // RVA: 0x7FFAC8EDA770
        public void FindDatasetElement(){} // RVA: 0x7FFAC8EDA990
        public void LoadSchema(){} // RVA: 0x7FFAC8EDAF80 | overloaded x2
        public void HandleRelations(){} // RVA: 0x7FFAC8EDCBF0
        public void GetParticleItems(){} // RVA: 0x7FFAC8EDCEF0
        public void HandleParticle(){} // RVA: 0x7FFAC8EDD210
        public void HandleAttributes(){} // RVA: 0x7FFAC8EDDBE0
        public void HandleAttributeGroup(){} // RVA: 0x7FFAC8EDDEF0
        public void HandleComplexType(){} // RVA: 0x7FFAC8EDE2B0
        public void GetParticle(){} // RVA: 0x7FFAC8EDEB90
        public void FindField(){} // RVA: 0x7FFAC8EDED40
        public void BuildKey(){} // RVA: 0x7FFAC8EDF020
        public void GetBooleanAttribute(){} // RVA: 0x7FFAC8EDF2D0
        public void GetStringAttribute(){} // RVA: 0x7FFAC8EDF4D0
        public void TranslateAcceptRejectRule(){} // RVA: 0x7FFAC8EDF550
        public void TranslateRule(){} // RVA: 0x7FFAC8EDF5F0
        public void HandleKeyref(){} // RVA: 0x7FFAC8EDF780
        public void HandleConstraint(){} // RVA: 0x7FFAC8EE0190
        public void InstantiateSimpleTable(){} // RVA: 0x7FFAC8EE07F0
        public void GetInstanceName(){} // RVA: 0x7FFAC8EE1130
        public void InstantiateTable(){} // RVA: 0x7FFAC8EE1290
        public void XsdtoClr(){} // RVA: 0x7FFAC8EE2710
        public void FindNameType(){} // RVA: 0x7FFAC8EE28B0
        public void ParseDataType(){} // RVA: 0x7FFAC8EE2A40
        public void IsXsdType(){} // RVA: 0x7FFAC8EE2D60
        public void FindTypeNode(){} // RVA: 0x7FFAC8EE2E80
        public void HandleSimpleTypeSimpleContentColumn(){} // RVA: 0x7FFAC8EE32D0
        public void HandleSimpleContentColumn(){} // RVA: 0x7FFAC8EE41F0
        public void HandleAttributeColumn(){} // RVA: 0x7FFAC8EE4DC0
        public void HandleElementColumn(){} // RVA: 0x7FFAC8EE5A90
        public void HandleDataSet(){} // RVA: 0x7FFAC8EE6DA0
        public void AddTablesToList(){} // RVA: 0x7FFAC8EE8300
        public void GetPrefix(){} // RVA: 0x7FFAC8EE84E0
        public void GetNamespaceFromPrefix(){} // RVA: 0x7FFAC8EE87C0
        public void GetTableNamespace(){} // RVA: 0x7FFAC8EE8AB0
        public void GetTableName(){} // RVA: 0x7FFAC8EE8CC0
        public void IsTable(){} // RVA: 0x7FFAC8EE8E60
        public void HandleTable(){} // RVA: 0x7FFAC8EE9230
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8EE9460
    }

    public class XmlDataLoader : Object
    {
        public System.Data.DataSet FromInference; // 0x10
        public System.Data.XmlToDatasetMap _nodeToSchemaMap; // 0x18
        public System.Collections.Hashtable _nodeToRowMap; // 0x20
        public System.Collections.Stack _childRowsStack; // 0x28
        public System.Collections.Hashtable _htableExcludedNS; // 0x30
        public bool _fIsXdr; // 0x38
        public bool _isDiffgram; // 0x39
        public System.Xml.XmlElement _topMostNode; // 0x40
        public bool _ignoreSchema; // 0x48
        public System.Data.DataTable _dataTable; // 0x50
        public bool _isTableLevel; // 0x58
        public bool _fromInference; // 0x59
        public System.Xml.XmlReader _dataReader; // 0x60
        public object _XSD_XMLNS_NS; // 0x68
        public object _XDR_SCHEMA; // 0x70
        public object _XDRNS; // 0x78
        public object _SQL_SYNC; // 0x80
        public object _UPDGNS; // 0x88
        public object _XSD_SCHEMA; // 0x90
        public object _XSDNS; // 0x98
        public object _DFFNS; // 0xA0
        public object _MSDNS; // 0xA8
        public object _DIFFID; // 0xB0
        public object _HASCHANGES; // 0xB8
        public object _ROWORDER; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EEBF50 | overloaded x4
        public void get_FromInference(){} // RVA: 0x7FFAC778CF40
        public void set_FromInference(){} // RVA: 0x7FFAC87B5A20
        public void AttachRows(){} // RVA: 0x7FFAC8EEC230
        public void CountNonNSAttributes(){} // RVA: 0x7FFAC8EEC3C0
        public void GetValueForTextOnlyColums(){} // RVA: 0x7FFAC8EEC590
        public void GetInitialTextFromNodes(){} // RVA: 0x7FFAC8EEC880
        public void GetTextOnlyColumn(){} // RVA: 0x7FFAC8EECC70
        public void GetRowFromElement(){} // RVA: 0x7FFAC8EECD20
        public void FColumnElement(){} // RVA: 0x7FFAC8EECDC0
        public void FExcludedNamespace(){} // RVA: 0x7FFAC8EECEF0
        public void FIgnoreNamespace(){} // RVA: 0x7FFAC8EED1A0 | overloaded x2
        public void IsTextLikeNode(){} // RVA: 0x7FFAC8EED300
        public void IsTextOnly(){} // RVA: 0x7FFAC8EED360
        public void LoadData(){} // RVA: 0x7FFAC8EEF100 | overloaded x2
        public void LoadRowData(){} // RVA: 0x7FFAC8EED790
        public void LoadRows(){} // RVA: 0x7FFAC8EEE530
        public void SetRowValueFromXmlText(){} // RVA: 0x7FFAC8EEEA00
        public void InitNameTable(){} // RVA: 0x7FFAC8EEEA80
        public void LoadTopMostTable(){} // RVA: 0x7FFAC8EEF610
        public void LoadTable(){} // RVA: 0x7FFAC8EF0040
        public void LoadColumn(){} // RVA: 0x7FFAC8EF11E0
        public void ProcessXsdSchema(){} // RVA: 0x7FFAC8EF1D20
    }

    public class XmlDataTreeWriter : Object
    {
        public System.Xml.XmlWriter _xmlw; // 0x10
        public System.Data.DataSet _ds; // 0x18
        public System.Data.DataTable _dt; // 0x20
        public System.Collections.ArrayList _dTables; // 0x28
        public System.Data.DataTable[] _topLevelTables; // 0x30
        public bool _fFromTable; // 0x38
        public bool _isDiffgram; // 0x39
        public System.Collections.Hashtable _rowsOrder; // 0x40
        public bool _writeHierarchy; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F07170 | overloaded x2
        public void CreateToplevelTables(){} // RVA: 0x7FFAC8F07510
        public void CreateTablesHierarchy(){} // RVA: 0x7FFAC8F07820
        public void RowHasErrors(){} // RVA: 0x7FFAC8F07B10
        public void SaveDiffgramData(){} // RVA: 0x7FFAC8F07C40
        public void Save(){} // RVA: 0x7FFAC8F08290
        public void GetNestedChildRelations(){} // RVA: 0x7FFAC8F08B30
        public void XmlDataRowWriter(){} // RVA: 0x7FFAC8F08E00
        public void PreserveSpace(){} // RVA: 0x7FFAC8F0A520
    }

    public class XmlIgnoreNamespaceReader : XmlNodeReader
    {
        public System.Collections.Generic.List`1<string> _namespacesToIgnore; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EEB330
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC8EEB530
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC8EEB770
    }

    public class XmlToDatasetMap : Object
    {
        public XmlNodeIdHashtable _tableSchemaMap; // 0x10
        public TableSchemaInfo _lastTableSchemaInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EF1FB0 | overloaded x4
        public void IsMappedColumn(){} // RVA: 0x7FFAC8EF1FC0
        public void AddTableSchema(){} // RVA: 0x7FFAC8EF2140 | overloaded x2
        public void AddColumnSchema(){} // RVA: 0x7FFAC8EF25E0 | overloaded x2
        public void BuildIdentityMap(){} // RVA: 0x7FFAC8EF38E0 | overloaded x4
        public void GetSelfAndDescendants(){} // RVA: 0x7FFAC8EF4050
        public void GetColumnSchema(){} // RVA: 0x7FFAC8EF4580 | overloaded x2
        public void GetSchemaForNode(){} // RVA: 0x7FFAC8EF4850
        public void GetTableForNode(){} // RVA: 0x7FFAC8EF4950
        public void HandleSpecialColumn(){} // RVA: 0x7FFAC8EF4A90
    }

    public class XmlTreeGen : Object
    {
        public System.Collections.ArrayList _constraintNames; // 0x10
        public System.Collections.Hashtable _namespaces; // 0x18
        public System.Collections.Hashtable _autogenerated; // 0x20
        public System.Collections.Hashtable _prefixes; // 0x28
        public System.Data.DataSet _ds; // 0x30
        public System.Collections.ArrayList _tables; // 0x38
        public System.Collections.ArrayList _relations; // 0x40
        public System.Xml.XmlDocument _dc; // 0x48
        public System.Xml.XmlElement _sRoot; // 0x50
        public int _prefixCount; // 0x58
        public 0x6B1D0D40 _schFormat; // 0x5C
        public string _filePath; // 0x60
        public string _fileName; // 0x68
        public string _fileExt; // 0x70
        public System.Xml.XmlElement _dsElement; // 0x78
        public System.Xml.XmlElement _constraintSeparator; // 0x80
        public System.Converter`2<System.Type,string> _targetConverter; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EF55A0
        public void AddExtendedProperties(){} // RVA: 0x7FFAC8EF5700 | overloaded x2
        public void AddXdoProperties(){} // RVA: 0x7FFAC8EF5D40
        public void AddXdoProperty(){} // RVA: 0x7FFAC8EF5F20
        public void XmlDataTypeName(){} // RVA: 0x7FFAC8EF6C50
        public void GenerateConstraintNames(){} // RVA: 0x7FFAC8EF7E80 | overloaded x3
        public void _PropsNotEmpty(){} // RVA: 0x7FFAC8EF80B0
        public void HaveExtendedProperties(){} // RVA: 0x7FFAC8EF80E0
        public void WriteSchemaRoot(){} // RVA: 0x7FFAC8EF82D0
        public void ValidateColumnMapping(){} // RVA: 0x7FFAC8EF8540
        public void SetupAutoGenerated(){} // RVA: 0x7FFAC8EF8920 | overloaded x3
        public void CreateTablesHierarchy(){} // RVA: 0x7FFAC8EF9340
        public void CreateRelations(){} // RVA: 0x7FFAC8EF9630
        public void CreateToplevelTables(){} // RVA: 0x7FFAC8EF98F0
        public void SchemaTree(){} // RVA: 0x7FFAC8EFC620 | overloaded x2
        public void FillDataSetElement(){} // RVA: 0x7FFAC8EFCDF0
        public void SetPath(){} // RVA: 0x7FFAC8EFD5B0
        public void Save(){} // RVA: 0x7FFAC8EFDB70 | overloaded x5
        public void HandleRelation(){} // RVA: 0x7FFAC8EFDD70
        public void FindSimpleType(){} // RVA: 0x7FFAC8EFE4E0
        public void GetSchema(){} // RVA: 0x7FFAC8EFE650
        public void HandleColumnType(){} // RVA: 0x7FFAC8EFE920
        public void AddColumnProperties(){} // RVA: 0x7FFAC8EFEE90
        public void FindTargetNamespace(){} // RVA: 0x7FFAC8EFF6D0
        public void HandleColumn(){} // RVA: 0x7FFAC8EFF810
        public void TranslateAcceptRejectRule(){} // RVA: 0x7FFAC8F00450
        public void TranslateRule(){} // RVA: 0x7FFAC8F004C0
        public void AppendChildWithoutRef(){} // RVA: 0x7FFAC8F00570
        public void FindTypeNode(){} // RVA: 0x7FFAC8F00630
        public void HandleTable(){} // RVA: 0x7FFAC8F01560 | overloaded x2
        public void HasMixedColumns(){} // RVA: 0x7FFAC8F00880
        public void AutoGenerated(){} // RVA: 0x7FFAC8F01370 | overloaded x5
        public void IsAutoGenerated(){} // RVA: 0x7FFAC8F01520
        public void SetMSDataAttribute(){} // RVA: 0x7FFAC8F04070
    }

}