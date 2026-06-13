// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 197

namespace ThirdParty.DotNet.System.Data
{
    public class XDRSchema
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6737EE0
        public void LoadSchema(){} // RVA: 0x6738090
        public void FindTypeNode(){} // RVA: 0x6738500
        public void IsTextOnlyContent(){} // RVA: 0x6738AC0
        public void IsXDRField(){} // RVA: 0x6738D50
        public void HandleTable(){} // RVA: 0x6738F60
        public void FindNameType(){} // RVA: 0x6739190
        public void ParseDataType(){} // RVA: 0x6739330
        public void GetInstanceName(){} // RVA: 0x6739510
        public void HandleColumn(){} // RVA: 0x67397F0
        public void GetMinMax(){} // RVA: 0x673A3D0 | overloaded x2
        public void HandleTypeNode(){} // RVA: 0x673A810
        public void InstantiateTable(){} // RVA: 0x673AA40
        public void InstantiateSimpleTable(){} // RVA: 0x673B110
        public void .cctor(){} // RVA: 0x673B440
    }

    public class XMLDiffLoader
    {
        // ── Methods ──
        public void LoadDiffGram(){} // RVA: 0x673D4D0 | overloaded x2
        public void CreateTablesHierarchy(){} // RVA: 0x673D1E0
        public void ProcessDiffs(){} // RVA: 0x673DCB0 | overloaded x2
        public void ProcessErrors(){} // RVA: 0x673E510 | overloaded x2
        public void GetTable(){} // RVA: 0x673EA80
        public void ReadOldRowData(){} // RVA: 0x673ED40
        public void SkipWhitespaces(){} // RVA: 0x673FE20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XMLSchema
    {
        // ── Methods ──
        public void GetConverter(){} // RVA: 0x673FE90
        public void SetProperties(){} // RVA: 0x673FEE0
        public void FEqualIdentity(){} // RVA: 0x67403E0
        public void GetBooleanAttribute(){} // RVA: 0x67404D0
        public void GenUniqueColumnName(){} // RVA: 0x67406B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XSDSchema
    {
        public System.Xml.Schema.XmlSchemaSet FromInference; // 0x10

        // ── Methods ──
        public void get_FromInference(){} // RVA: 0x1B6CD50
        public void set_FromInference(){} // RVA: 0xB70090
        public void CollectElementsAnnotations(){} // RVA: 0x6740940 | overloaded x2
        public void QualifiedName(){} // RVA: 0x67413B0
        public void SetProperties(){} // RVA: 0x6741420
        public void SetExtProperties(){} // RVA: 0x6742560 | overloaded x2
        public void HandleColumnExpression(){} // RVA: 0x6742140
        public void GetMsdataAttribute(){} // RVA: 0x67423D0
        public void HandleRefTableProperties(){} // RVA: 0x6742810
        public void HandleRelation(){} // RVA: 0x6742910
        public void HasAttributes(){} // RVA: 0x6743330
        public void IsDatasetParticle(){} // RVA: 0x6743570
        public void DatasetElementCount(){} // RVA: 0x6743CC0
        public void FindDatasetElement(){} // RVA: 0x6743EE0
        public void LoadSchema(){} // RVA: 0x67444D0 | overloaded x2
        public void HandleRelations(){} // RVA: 0x6746140
        public void GetParticleItems(){} // RVA: 0x6746440
        public void HandleParticle(){} // RVA: 0x6746760
        public void HandleAttributes(){} // RVA: 0x6747130
        public void HandleAttributeGroup(){} // RVA: 0x6747440
        public void HandleComplexType(){} // RVA: 0x6747800
        public void GetParticle(){} // RVA: 0x67480E0
        public void FindField(){} // RVA: 0x6748290
        public void BuildKey(){} // RVA: 0x6748570
        public void GetBooleanAttribute(){} // RVA: 0x6748820
        public void GetStringAttribute(){} // RVA: 0x6748A20
        public void TranslateAcceptRejectRule(){} // RVA: 0x6748AA0
        public void TranslateRule(){} // RVA: 0x6748B40
        public void HandleKeyref(){} // RVA: 0x6748CD0
        public void HandleConstraint(){} // RVA: 0x67496E0
        public void InstantiateSimpleTable(){} // RVA: 0x6749D40
        public void GetInstanceName(){} // RVA: 0x674A680
        public void InstantiateTable(){} // RVA: 0x674A7E0
        public void XsdtoClr(){} // RVA: 0x674BC60
        public void FindNameType(){} // RVA: 0x674BE00
        public void ParseDataType(){} // RVA: 0x674BF90
        public void IsXsdType(){} // RVA: 0x674C2B0
        public void FindTypeNode(){} // RVA: 0x674C3D0
        public void HandleSimpleTypeSimpleContentColumn(){} // RVA: 0x674C820
        public void HandleSimpleContentColumn(){} // RVA: 0x674D740
        public void HandleAttributeColumn(){} // RVA: 0x674E310
        public void HandleElementColumn(){} // RVA: 0x674EFE0
        public void HandleDataSet(){} // RVA: 0x67502F0
        public void AddTablesToList(){} // RVA: 0x6751850
        public void GetPrefix(){} // RVA: 0x6751A30
        public void GetNamespaceFromPrefix(){} // RVA: 0x6751D10
        public void GetTableNamespace(){} // RVA: 0x6752000
        public void GetTableName(){} // RVA: 0x6752210
        public void IsTable(){} // RVA: 0x67523B0
        public void HandleTable(){} // RVA: 0x6752780
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x67529B0
    }

    public class XmlDataLoader
    {
        public System.Data.DataSet _dataSet; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67554A0 | overloaded x4
        public void get_FromInference(){} // RVA: 0x4FE4B90
        public void set_FromInference(){} // RVA: 0x601E3A0
        public void AttachRows(){} // RVA: 0x6755780
        public void CountNonNSAttributes(){} // RVA: 0x6755910
        public void GetValueForTextOnlyColums(){} // RVA: 0x6755AE0
        public void GetInitialTextFromNodes(){} // RVA: 0x6755DD0
        public void GetTextOnlyColumn(){} // RVA: 0x67561C0
        public void GetRowFromElement(){} // RVA: 0x6756270
        public void FColumnElement(){} // RVA: 0x6756310
        public void FExcludedNamespace(){} // RVA: 0x6756440
        public void FIgnoreNamespace(){} // RVA: 0x67566F0 | overloaded x2
        public void IsTextLikeNode(){} // RVA: 0x6756850
        public void IsTextOnly(){} // RVA: 0x67568B0
        public void LoadData(){} // RVA: 0x6758650 | overloaded x2
        public void LoadRowData(){} // RVA: 0x6756CE0
        public void LoadRows(){} // RVA: 0x6757A80
        public void SetRowValueFromXmlText(){} // RVA: 0x6757F50
        public void InitNameTable(){} // RVA: 0x6757FD0
        public void LoadTopMostTable(){} // RVA: 0x6758B60
        public void LoadTable(){} // RVA: 0x6759590
        public void LoadColumn(){} // RVA: 0x675A730
        public void ProcessXsdSchema(){} // RVA: 0x675B270
    }

    public class XmlDataTreeWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67706C0 | overloaded x2
        public void CreateToplevelTables(){} // RVA: 0x6770A60
        public void CreateTablesHierarchy(){} // RVA: 0x6770D70
        public void RowHasErrors(){} // RVA: 0x6771060
        public void SaveDiffgramData(){} // RVA: 0x6771190
        public void Save(){} // RVA: 0x67717E0
        public void GetNestedChildRelations(){} // RVA: 0x6772080
        public void XmlDataRowWriter(){} // RVA: 0x6772350
        public void PreserveSpace(){} // RVA: 0x6773A70
    }

    public class XmlIgnoreNamespaceReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6754880
        public void MoveToFirstAttribute(){} // RVA: 0x6754A80
        public void MoveToNextAttribute(){} // RVA: 0x6754CC0
    }

    public class XmlToDatasetMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x675B500 | overloaded x4
        public void IsMappedColumn(){} // RVA: 0x675B510
        public void AddTableSchema(){} // RVA: 0x675B690 | overloaded x2
        public void AddColumnSchema(){} // RVA: 0x675BB30 | overloaded x2
        public void BuildIdentityMap(){} // RVA: 0x675CE30 | overloaded x4
        public void GetSelfAndDescendants(){} // RVA: 0x675D5A0
        public void GetColumnSchema(){} // RVA: 0x675DAD0 | overloaded x2
        public void GetSchemaForNode(){} // RVA: 0x675DDA0
        public void GetTableForNode(){} // RVA: 0x675DEA0
        public void HandleSpecialColumn(){} // RVA: 0x675DFE0
    }

    public class XmlTreeGen
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x675EAF0
        public void AddExtendedProperties(){} // RVA: 0x675EC50 | overloaded x2
        public void AddXdoProperties(){} // RVA: 0x675F290
        public void AddXdoProperty(){} // RVA: 0x675F470
        public void XmlDataTypeName(){} // RVA: 0x67601A0
        public void GenerateConstraintNames(){} // RVA: 0x67613D0 | overloaded x3
        public void _PropsNotEmpty(){} // RVA: 0x6761600
        public void HaveExtendedProperties(){} // RVA: 0x6761630
        public void WriteSchemaRoot(){} // RVA: 0x6761820
        public void ValidateColumnMapping(){} // RVA: 0x6761A90
        public void SetupAutoGenerated(){} // RVA: 0x6761E70 | overloaded x3
        public void CreateTablesHierarchy(){} // RVA: 0x6762890
        public void CreateRelations(){} // RVA: 0x6762B80
        public void CreateToplevelTables(){} // RVA: 0x6762E40
        public void SchemaTree(){} // RVA: 0x6765B70 | overloaded x2
        public void FillDataSetElement(){} // RVA: 0x6766340
        public void SetPath(){} // RVA: 0x6766B00
        public void Save(){} // RVA: 0x67670C0 | overloaded x5
        public void HandleRelation(){} // RVA: 0x67672C0
        public void FindSimpleType(){} // RVA: 0x6767A30
        public void GetSchema(){} // RVA: 0x6767BA0
        public void HandleColumnType(){} // RVA: 0x6767E70
        public void AddColumnProperties(){} // RVA: 0x67683E0
        public void FindTargetNamespace(){} // RVA: 0x6768C20
        public void HandleColumn(){} // RVA: 0x6768D60
        public void TranslateAcceptRejectRule(){} // RVA: 0x67699A0
        public void TranslateRule(){} // RVA: 0x6769A10
        public void AppendChildWithoutRef(){} // RVA: 0x6769AC0
        public void FindTypeNode(){} // RVA: 0x6769B80
        public void HandleTable(){} // RVA: 0x676AAB0 | overloaded x2
        public void HasMixedColumns(){} // RVA: 0x6769DD0
        public void AutoGenerated(){} // RVA: 0x676A8C0 | overloaded x5
        public void IsAutoGenerated(){} // RVA: 0x676AA70
        public void SetMSDataAttribute(){} // RVA: 0x676D5C0
    }

}