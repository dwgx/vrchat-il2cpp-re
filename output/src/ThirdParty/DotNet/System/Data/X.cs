// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 160

namespace ThirdParty.DotNet.System.Data
{
    public class XDRSchema : XMLSchema
    {
        public object _schemaName;
        public object _schemaUri;
        public object _schemaRoot;
        public object _ds;
        public object s_colonArray;
        public object s_mapNameTypeXdr;
        public object s_enumerationNameType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x719F7A0
        public void LoadSchema(){} // RVA: 0x719F920
        public void FindTypeNode(){} // RVA: 0x719FD80
        public void IsTextOnlyContent(){} // RVA: 0x71A0330
        public void IsXDRField(){} // RVA: 0x71A05C0
        public void HandleTable(){} // RVA: 0x71A07D0
        public void FindNameType(){} // RVA: 0x71A0A00
        public void ParseDataType(){} // RVA: 0x71A0BA0
        public void GetInstanceName(){} // RVA: 0x71A0D80
        public void HandleColumn(){} // RVA: 0x71A1060
        public void GetMinMax(){} // RVA: 0x71A1C50
        public void HandleTypeNode(){} // RVA: 0x71A1F30
        public void InstantiateTable(){} // RVA: 0x71A2160
        public void InstantiateSimpleTable(){} // RVA: 0x71A2810
        public void .cctor(){} // RVA: 0x71A2B40
    }

    public class XMLDiffLoader : Object
    {
        public object _tables;
        public object _dataSet;
        public object _dataTable;

        // ── Methods ──
        public void LoadDiffGram(){} // RVA: 0x71A4670
        public void CreateTablesHierarchy(){} // RVA: 0x71A4390
        public void ProcessDiffs(){} // RVA: 0x71A4E60
        public void ProcessErrors(){} // RVA: 0x71A56C0
        public void GetTable(){} // RVA: 0x71A5C30
        public void ReadOldRowData(){} // RVA: 0x71A5EF0
        public void SkipWhitespaces(){} // RVA: 0x71A6FA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XMLSchema : Object
    {
        // ── Methods ──
        public void GetConverter(){} // RVA: 0x71A7010
        public void SetProperties(){} // RVA: 0x71A7060
        public void FEqualIdentity(){} // RVA: 0x71A7530
        public void GetBooleanAttribute(){} // RVA: 0x71A7620
        public void GenUniqueColumnName(){} // RVA: 0x71A7800
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XSDSchema : XMLSchema
    {
        public object _schemaSet;
        public object _dsElement;
        public object _ds;
        public object _schemaName;
        public object _columnExpressions;
        public object _constraintNodes;
        public object _refTables;
        public object _complexTypes;
        public object _annotations;
        public object _elements;
        public object _attributes;
        public object _elementsTable;
        public object _attributeGroups;
        public object _schemaTypes;
        public object _expressions;
        public object _tableDictionary;
        public object _udSimpleTypes;
        public object _existingSimpleTypeMap;
        public object _fromInference;
        public object s_mapNameTypeXsd;

        // ── Methods ──
        public void get_FromInference(){} // RVA: 0x2443C20
        public void set_FromInference(){} // RVA: 0x143D170
        public void CollectElementsAnnotations(){} // RVA: 0x71A7A90
        public void QualifiedName(){} // RVA: 0x71A84D0
        public void SetProperties(){} // RVA: 0x71A8540
        public void SetExtProperties(){} // RVA: 0x71A9630
        public void HandleColumnExpression(){} // RVA: 0x71A9220
        public void GetMsdataAttribute(){} // RVA: 0x71A94A0
        public void HandleRefTableProperties(){} // RVA: 0x71A98E0
        public void HandleRelation(){} // RVA: 0x71A99E0
        public void HasAttributes(){} // RVA: 0x71AA450
        public void IsDatasetParticle(){} // RVA: 0x71AA690
        public void DatasetElementCount(){} // RVA: 0x71AAD50
        public void FindDatasetElement(){} // RVA: 0x71AAF60
        public void LoadSchema(){} // RVA: 0x71AB550
        public void HandleRelations(){} // RVA: 0x71AD160
        public void GetParticleItems(){} // RVA: 0x71AD450
        public void HandleParticle(){} // RVA: 0x71AD770
        public void HandleAttributes(){} // RVA: 0x71AE150
        public void HandleAttributeGroup(){} // RVA: 0x71AE440
        public void HandleComplexType(){} // RVA: 0x71AE800
        public void GetParticle(){} // RVA: 0x71AF0C0
        public void FindField(){} // RVA: 0x71AF270
        public void BuildKey(){} // RVA: 0x71AF550
        public void GetBooleanAttribute(){} // RVA: 0x71AF820
        public void GetStringAttribute(){} // RVA: 0x71AFA20
        public void TranslateAcceptRejectRule(){} // RVA: 0x71AFAA0
        public void TranslateRule(){} // RVA: 0x71AFB40
        public void HandleKeyref(){} // RVA: 0x71AFCD0
        public void HandleConstraint(){} // RVA: 0x71B06D0
        public void InstantiateSimpleTable(){} // RVA: 0x71B0D40
        public void GetInstanceName(){} // RVA: 0x71B1650
        public void InstantiateTable(){} // RVA: 0x71B17B0
        public void XsdtoClr(){} // RVA: 0x71B2C00
        public void FindNameType(){} // RVA: 0x71B2DA0
        public void ParseDataType(){} // RVA: 0x71B2F30
        public void IsXsdType(){} // RVA: 0x71B3250
        public void FindTypeNode(){} // RVA: 0x71B3370
        public void HandleSimpleTypeSimpleContentColumn(){} // RVA: 0x71B37B0
        public void HandleSimpleContentColumn(){} // RVA: 0x71B4640
        public void HandleAttributeColumn(){} // RVA: 0x71B51D0
        public void HandleElementColumn(){} // RVA: 0x71B5F10
        public void HandleDataSet(){} // RVA: 0x71B71D0
        public void AddTablesToList(){} // RVA: 0x71B85B0
        public void GetPrefix(){} // RVA: 0x71B87A0
        public void GetNamespaceFromPrefix(){} // RVA: 0x71B8A50
        public void GetTableNamespace(){} // RVA: 0x71B8D10
        public void GetTableName(){} // RVA: 0x71B8F10
        public void IsTable(){} // RVA: 0x71B90B0
        public void HandleTable(){} // RVA: 0x71B9490
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x71B96C0
    }

    public class XmlDataLoader : Object
    {
        public object _dataSet;
        public object _nodeToSchemaMap;
        public object _nodeToRowMap;
        public object _childRowsStack;
        public object _htableExcludedNS;
        public object _fIsXdr;
        public object _isDiffgram;
        public object _topMostNode;
        public object _ignoreSchema;
        public object _dataTable;
        public object _isTableLevel;
        public object _fromInference;
        public object _dataReader;
        public object _XSD_XMLNS_NS;
        public object _XDR_SCHEMA;
        public object _XDRNS;
        public object _SQL_SYNC;
        public object _UPDGNS;
        public object _XSD_SCHEMA;
        public object _XSDNS;
        public object _DFFNS;
        public object _MSDNS;
        public object _DIFFID;
        public object _HASCHANGES;
        public object _ROWORDER;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71BBA60
        public void get_FromInference(){} // RVA: 0x5C8BB10
        public void set_FromInference(){} // RVA: 0x6A92EB0
        public void AttachRows(){} // RVA: 0x71BBD50
        public void CountNonNSAttributes(){} // RVA: 0x71BBEE0
        public void GetValueForTextOnlyColums(){} // RVA: 0x71BC0B0
        public void GetInitialTextFromNodes(){} // RVA: 0x71BC390
        public void GetTextOnlyColumn(){} // RVA: 0x71BC770
        public void GetRowFromElement(){} // RVA: 0x71BC820
        public void FColumnElement(){} // RVA: 0x71BC8C0
        public void FExcludedNamespace(){} // RVA: 0x71BC9F0
        public void FIgnoreNamespace(){} // RVA: 0x71BCCA0
        public void IsTextLikeNode(){} // RVA: 0x71BCE00
        public void IsTextOnly(){} // RVA: 0x71BCE60
        public void LoadData(){} // RVA: 0x71BEBD0
        public void LoadRowData(){} // RVA: 0x71BD2A0
        public void LoadRows(){} // RVA: 0x71BE000
        public void SetRowValueFromXmlText(){} // RVA: 0x71BE4D0
        public void InitNameTable(){} // RVA: 0x71BE550
        public void LoadTopMostTable(){} // RVA: 0x71BF0D0
        public void LoadTable(){} // RVA: 0x71BFAD0
        public void LoadColumn(){} // RVA: 0x71C0C30
        public void ProcessXsdSchema(){} // RVA: 0x71C1750
    }

    public class XmlDataTreeWriter : Object
    {
        public object _xmlw;
        public object _ds;
        public object _dt;
        public object _dTables;
        public object _topLevelTables;
        public object _fFromTable;
        public object _isDiffgram;
        public object _rowsOrder;
        public object _writeHierarchy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71D6B20
        public void CreateToplevelTables(){} // RVA: 0x71D6ED0
        public void CreateTablesHierarchy(){} // RVA: 0x71D71E0
        public void RowHasErrors(){} // RVA: 0x71D74C0
        public void SaveDiffgramData(){} // RVA: 0x71D75B0
        public void Save(){} // RVA: 0x71D7BE0
        public void GetNestedChildRelations(){} // RVA: 0x71D8470
        public void XmlDataRowWriter(){} // RVA: 0x71D8730
        public void PreserveSpace(){} // RVA: 0x71D9DE0
    }

    public class XmlIgnoreNamespaceReader : XmlNodeReader
    {
        public object _namespacesToIgnore;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71BAE40
        public void MoveToFirstAttribute(){} // RVA: 0x71BB040
        public void MoveToNextAttribute(){} // RVA: 0x71BB270
    }

    public class XmlToDatasetMap : Object
    {
        public object _tableSchemaMap;
        public object _lastTableSchemaInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71C19E0
        public void IsMappedColumn(){} // RVA: 0x71C19F0
        public void AddTableSchema(){} // RVA: 0x71C1B70
        public void AddColumnSchema(){} // RVA: 0x71C2040
        public void BuildIdentityMap(){} // RVA: 0x71C3390
        public void GetSelfAndDescendants(){} // RVA: 0x71C3B10
        public void GetColumnSchema(){} // RVA: 0x71C4030
        public void GetSchemaForNode(){} // RVA: 0x71C4300
        public void GetTableForNode(){} // RVA: 0x71C4400
        public void HandleSpecialColumn(){} // RVA: 0x71C4540
    }

    public class XmlTreeGen : Object
    {
        public object _constraintNames;
        public object _namespaces;
        public object _autogenerated;
        public object _prefixes;
        public object _ds;
        public object _tables;
        public object _relations;
        public object _dc;
        public object _sRoot;
        public object _prefixCount;
        public object _schFormat;
        public object _filePath;
        public object _fileName;
        public object _fileExt;
        public object _dsElement;
        public object _constraintSeparator;
        public object _targetConverter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71C5040
        public void AddExtendedProperties(){} // RVA: 0x71C51A0
        public void AddXdoProperties(){} // RVA: 0x71C57A0
        public void AddXdoProperty(){} // RVA: 0x71C5980
        public void XmlDataTypeName(){} // RVA: 0x71C66B0
        public void GenerateConstraintNames(){} // RVA: 0x71C7870
        public void _PropsNotEmpty(){} // RVA: 0x71C7A90
        public void HaveExtendedProperties(){} // RVA: 0x71C7AC0
        public void WriteSchemaRoot(){} // RVA: 0x71C7CB0
        public void ValidateColumnMapping(){} // RVA: 0x71C7F20
        public void SetupAutoGenerated(){} // RVA: 0x71C82F0
        public void CreateTablesHierarchy(){} // RVA: 0x71C8CB0
        public void CreateRelations(){} // RVA: 0x71C8F90
        public void CreateToplevelTables(){} // RVA: 0x71C9240
        public void SchemaTree(){} // RVA: 0x71CBF60
        public void FillDataSetElement(){} // RVA: 0x71CC730
        public void SetPath(){} // RVA: 0x71CCEF0
        public void Save(){} // RVA: 0x71CD440
        public void HandleRelation(){} // RVA: 0x71CD640
        public void FindSimpleType(){} // RVA: 0x71CDDD0
        public void GetSchema(){} // RVA: 0x71CDF40
        public void HandleColumnType(){} // RVA: 0x71CE210
        public void AddColumnProperties(){} // RVA: 0x71CE7A0
        public void FindTargetNamespace(){} // RVA: 0x71CEFE0
        public void HandleColumn(){} // RVA: 0x71CF120
        public void TranslateAcceptRejectRule(){} // RVA: 0x71CFF00
        public void TranslateRule(){} // RVA: 0x71CFF70
        public void AppendChildWithoutRef(){} // RVA: 0x71D0020
        public void FindTypeNode(){} // RVA: 0x71D00E0
        public void HandleTable(){} // RVA: 0x71D0FD0
        public void HasMixedColumns(){} // RVA: 0x71D0330
        public void AutoGenerated(){} // RVA: 0x71D0DE0
        public void IsAutoGenerated(){} // RVA: 0x71D0F90
        public void SetMSDataAttribute(){} // RVA: 0x71D3A80
    }

}