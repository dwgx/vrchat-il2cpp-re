// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 197

namespace ThirdParty.DotNet.System.Data
{
    public class XDRSchema
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91E7EE0
        public void LoadSchema(){} // RVA: 0x7FFAF91E8090
        public void FindTypeNode(){} // RVA: 0x7FFAF91E8500
        public void IsTextOnlyContent(){} // RVA: 0x7FFAF91E8AC0
        public void IsXDRField(){} // RVA: 0x7FFAF91E8D50
        public void HandleTable(){} // RVA: 0x7FFAF91E8F60
        public void FindNameType(){} // RVA: 0x7FFAF91E9190
        public void ParseDataType(){} // RVA: 0x7FFAF91E9330
        public void GetInstanceName(){} // RVA: 0x7FFAF91E9510
        public void HandleColumn(){} // RVA: 0x7FFAF91E97F0
        public void GetMinMax(){} // RVA: 0x7FFAF91EA3D0 | overloaded x2
        public void HandleTypeNode(){} // RVA: 0x7FFAF91EA810
        public void InstantiateTable(){} // RVA: 0x7FFAF91EAA40
        public void InstantiateSimpleTable(){} // RVA: 0x7FFAF91EB110
        public void .cctor(){} // RVA: 0x7FFAF91EB440
    }

    public class XMLDiffLoader
    {
        // ── Methods ──
        public void LoadDiffGram(){} // RVA: 0x7FFAF91ED4D0 | overloaded x2
        public void CreateTablesHierarchy(){} // RVA: 0x7FFAF91ED1E0
        public void ProcessDiffs(){} // RVA: 0x7FFAF91EDCB0 | overloaded x2
        public void ProcessErrors(){} // RVA: 0x7FFAF91EE510 | overloaded x2
        public void GetTable(){} // RVA: 0x7FFAF91EEA80
        public void ReadOldRowData(){} // RVA: 0x7FFAF91EED40
        public void SkipWhitespaces(){} // RVA: 0x7FFAF91EFE20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XMLSchema
    {
        // ── Methods ──
        public void GetConverter(){} // RVA: 0x7FFAF91EFE90
        public void SetProperties(){} // RVA: 0x7FFAF91EFEE0
        public void FEqualIdentity(){} // RVA: 0x7FFAF91F03E0
        public void GetBooleanAttribute(){} // RVA: 0x7FFAF91F04D0
        public void GenUniqueColumnName(){} // RVA: 0x7FFAF91F06B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XSDSchema
    {
        public object FromInference;

        // ── Methods ──
        public void get_FromInference(){} // RVA: 0x7FFAF461CD50
        public void set_FromInference(){} // RVA: 0x7FFAF3620090
        public void CollectElementsAnnotations(){} // RVA: 0x7FFAF91F0940 | overloaded x2
        public void QualifiedName(){} // RVA: 0x7FFAF91F13B0
        public void SetProperties(){} // RVA: 0x7FFAF91F1420
        public void SetExtProperties(){} // RVA: 0x7FFAF91F2560 | overloaded x2
        public void HandleColumnExpression(){} // RVA: 0x7FFAF91F2140
        public void GetMsdataAttribute(){} // RVA: 0x7FFAF91F23D0
        public void HandleRefTableProperties(){} // RVA: 0x7FFAF91F2810
        public void HandleRelation(){} // RVA: 0x7FFAF91F2910
        public void HasAttributes(){} // RVA: 0x7FFAF91F3330
        public void IsDatasetParticle(){} // RVA: 0x7FFAF91F3570
        public void DatasetElementCount(){} // RVA: 0x7FFAF91F3CC0
        public void FindDatasetElement(){} // RVA: 0x7FFAF91F3EE0
        public void LoadSchema(){} // RVA: 0x7FFAF91F44D0 | overloaded x2
        public void HandleRelations(){} // RVA: 0x7FFAF91F6140
        public void GetParticleItems(){} // RVA: 0x7FFAF91F6440
        public void HandleParticle(){} // RVA: 0x7FFAF91F6760
        public void HandleAttributes(){} // RVA: 0x7FFAF91F7130
        public void HandleAttributeGroup(){} // RVA: 0x7FFAF91F7440
        public void HandleComplexType(){} // RVA: 0x7FFAF91F7800
        public void GetParticle(){} // RVA: 0x7FFAF91F80E0
        public void FindField(){} // RVA: 0x7FFAF91F8290
        public void BuildKey(){} // RVA: 0x7FFAF91F8570
        public void GetBooleanAttribute(){} // RVA: 0x7FFAF91F8820
        public void GetStringAttribute(){} // RVA: 0x7FFAF91F8A20
        public void TranslateAcceptRejectRule(){} // RVA: 0x7FFAF91F8AA0
        public void TranslateRule(){} // RVA: 0x7FFAF91F8B40
        public void HandleKeyref(){} // RVA: 0x7FFAF91F8CD0
        public void HandleConstraint(){} // RVA: 0x7FFAF91F96E0
        public void InstantiateSimpleTable(){} // RVA: 0x7FFAF91F9D40
        public void GetInstanceName(){} // RVA: 0x7FFAF91FA680
        public void InstantiateTable(){} // RVA: 0x7FFAF91FA7E0
        public void XsdtoClr(){} // RVA: 0x7FFAF91FBC60
        public void FindNameType(){} // RVA: 0x7FFAF91FBE00
        public void ParseDataType(){} // RVA: 0x7FFAF91FBF90
        public void IsXsdType(){} // RVA: 0x7FFAF91FC2B0
        public void FindTypeNode(){} // RVA: 0x7FFAF91FC3D0
        public void HandleSimpleTypeSimpleContentColumn(){} // RVA: 0x7FFAF91FC820
        public void HandleSimpleContentColumn(){} // RVA: 0x7FFAF91FD740
        public void HandleAttributeColumn(){} // RVA: 0x7FFAF91FE310
        public void HandleElementColumn(){} // RVA: 0x7FFAF91FEFE0
        public void HandleDataSet(){} // RVA: 0x7FFAF92002F0
        public void AddTablesToList(){} // RVA: 0x7FFAF9201850
        public void GetPrefix(){} // RVA: 0x7FFAF9201A30
        public void GetNamespaceFromPrefix(){} // RVA: 0x7FFAF9201D10
        public void GetTableNamespace(){} // RVA: 0x7FFAF9202000
        public void GetTableName(){} // RVA: 0x7FFAF9202210
        public void IsTable(){} // RVA: 0x7FFAF92023B0
        public void HandleTable(){} // RVA: 0x7FFAF9202780
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF92029B0
    }

    public class XmlDataLoader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92054A0 | overloaded x4
        public void get_FromInference(){} // RVA: 0x7FFAF7A94B90
        public void set_FromInference(){} // RVA: 0x7FFAF8ACE3A0
        public void AttachRows(){} // RVA: 0x7FFAF9205780
        public void CountNonNSAttributes(){} // RVA: 0x7FFAF9205910
        public void GetValueForTextOnlyColums(){} // RVA: 0x7FFAF9205AE0
        public void GetInitialTextFromNodes(){} // RVA: 0x7FFAF9205DD0
        public void GetTextOnlyColumn(){} // RVA: 0x7FFAF92061C0
        public void GetRowFromElement(){} // RVA: 0x7FFAF9206270
        public void FColumnElement(){} // RVA: 0x7FFAF9206310
        public void FExcludedNamespace(){} // RVA: 0x7FFAF9206440
        public void FIgnoreNamespace(){} // RVA: 0x7FFAF92066F0 | overloaded x2
        public void IsTextLikeNode(){} // RVA: 0x7FFAF9206850
        public void IsTextOnly(){} // RVA: 0x7FFAF92068B0
        public void LoadData(){} // RVA: 0x7FFAF9208650 | overloaded x2
        public void LoadRowData(){} // RVA: 0x7FFAF9206CE0
        public void LoadRows(){} // RVA: 0x7FFAF9207A80
        public void SetRowValueFromXmlText(){} // RVA: 0x7FFAF9207F50
        public void InitNameTable(){} // RVA: 0x7FFAF9207FD0
        public void LoadTopMostTable(){} // RVA: 0x7FFAF9208B60
        public void LoadTable(){} // RVA: 0x7FFAF9209590
        public void LoadColumn(){} // RVA: 0x7FFAF920A730
        public void ProcessXsdSchema(){} // RVA: 0x7FFAF920B270
    }

    public class XmlDataTreeWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92206C0 | overloaded x2
        public void CreateToplevelTables(){} // RVA: 0x7FFAF9220A60
        public void CreateTablesHierarchy(){} // RVA: 0x7FFAF9220D70
        public void RowHasErrors(){} // RVA: 0x7FFAF9221060
        public void SaveDiffgramData(){} // RVA: 0x7FFAF9221190
        public void Save(){} // RVA: 0x7FFAF92217E0
        public void GetNestedChildRelations(){} // RVA: 0x7FFAF9222080
        public void XmlDataRowWriter(){} // RVA: 0x7FFAF9222350
        public void PreserveSpace(){} // RVA: 0x7FFAF9223A70
    }

    public class XmlIgnoreNamespaceReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9204880
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAF9204A80
        public void MoveToNextAttribute(){} // RVA: 0x7FFAF9204CC0
    }

    public class XmlToDatasetMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF920B500 | overloaded x4
        public void IsMappedColumn(){} // RVA: 0x7FFAF920B510
        public void AddTableSchema(){} // RVA: 0x7FFAF920B690 | overloaded x2
        public void AddColumnSchema(){} // RVA: 0x7FFAF920BB30 | overloaded x2
        public void BuildIdentityMap(){} // RVA: 0x7FFAF920CE30 | overloaded x4
        public void GetSelfAndDescendants(){} // RVA: 0x7FFAF920D5A0
        public void GetColumnSchema(){} // RVA: 0x7FFAF920DAD0 | overloaded x2
        public void GetSchemaForNode(){} // RVA: 0x7FFAF920DDA0
        public void GetTableForNode(){} // RVA: 0x7FFAF920DEA0
        public void HandleSpecialColumn(){} // RVA: 0x7FFAF920DFE0
    }

    public class XmlTreeGen
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF920EAF0
        public void AddExtendedProperties(){} // RVA: 0x7FFAF920EC50 | overloaded x2
        public void AddXdoProperties(){} // RVA: 0x7FFAF920F290
        public void AddXdoProperty(){} // RVA: 0x7FFAF920F470
        public void XmlDataTypeName(){} // RVA: 0x7FFAF92101A0
        public void GenerateConstraintNames(){} // RVA: 0x7FFAF92113D0 | overloaded x3
        public void _PropsNotEmpty(){} // RVA: 0x7FFAF9211600
        public void HaveExtendedProperties(){} // RVA: 0x7FFAF9211630
        public void WriteSchemaRoot(){} // RVA: 0x7FFAF9211820
        public void ValidateColumnMapping(){} // RVA: 0x7FFAF9211A90
        public void SetupAutoGenerated(){} // RVA: 0x7FFAF9211E70 | overloaded x3
        public void CreateTablesHierarchy(){} // RVA: 0x7FFAF9212890
        public void CreateRelations(){} // RVA: 0x7FFAF9212B80
        public void CreateToplevelTables(){} // RVA: 0x7FFAF9212E40
        public void SchemaTree(){} // RVA: 0x7FFAF9215B70 | overloaded x2
        public void FillDataSetElement(){} // RVA: 0x7FFAF9216340
        public void SetPath(){} // RVA: 0x7FFAF9216B00
        public void Save(){} // RVA: 0x7FFAF92170C0 | overloaded x5
        public void HandleRelation(){} // RVA: 0x7FFAF92172C0
        public void FindSimpleType(){} // RVA: 0x7FFAF9217A30
        public void GetSchema(){} // RVA: 0x7FFAF9217BA0
        public void HandleColumnType(){} // RVA: 0x7FFAF9217E70
        public void AddColumnProperties(){} // RVA: 0x7FFAF92183E0
        public void FindTargetNamespace(){} // RVA: 0x7FFAF9218C20
        public void HandleColumn(){} // RVA: 0x7FFAF9218D60
        public void TranslateAcceptRejectRule(){} // RVA: 0x7FFAF92199A0
        public void TranslateRule(){} // RVA: 0x7FFAF9219A10
        public void AppendChildWithoutRef(){} // RVA: 0x7FFAF9219AC0
        public void FindTypeNode(){} // RVA: 0x7FFAF9219B80
        public void HandleTable(){} // RVA: 0x7FFAF921AAB0 | overloaded x2
        public void HasMixedColumns(){} // RVA: 0x7FFAF9219DD0
        public void AutoGenerated(){} // RVA: 0x7FFAF921A8C0 | overloaded x5
        public void IsAutoGenerated(){} // RVA: 0x7FFAF921AA70
        public void SetMSDataAttribute(){} // RVA: 0x7FFAF921D5C0
    }

}