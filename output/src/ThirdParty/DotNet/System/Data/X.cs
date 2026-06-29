// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 160

namespace ThirdParty.DotNet.System.Data
{
    public class XDRSchema : XMLSchema
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5263C0
        public void LoadSchema(){} // RVA: 0x7AE526570
        public void FindTypeNode(){} // RVA: 0x7AE5269E0
        public void IsTextOnlyContent(){} // RVA: 0x7AE526F90
        public void IsXDRField(){} // RVA: 0x7AE527220
        public void HandleTable(){} // RVA: 0x7AE527430
        public void FindNameType(){} // RVA: 0x7AE527660
        public void ParseDataType(){} // RVA: 0x7AE527800
        public void GetInstanceName(){} // RVA: 0x7AE5279E0
        public void HandleColumn(){} // RVA: 0x7AE527CC0
        public void GetMinMax(){} // RVA: 0x7AE5288A0
        public void HandleTypeNode(){} // RVA: 0x7AE528CD0
        public void InstantiateTable(){} // RVA: 0x7AE528F00
        public void InstantiateSimpleTable(){} // RVA: 0x7AE5295D0
        public void .cctor(){} // RVA: 0x7AE529900
    }

    public class XMLDiffLoader : Object
    {
        // ── Methods ──
        public void LoadDiffGram(){} // RVA: 0x7AE52B980
        public void CreateTablesHierarchy(){} // RVA: 0x7AE52B6A0
        public void ProcessDiffs(){} // RVA: 0x7AE52C170
        public void ProcessErrors(){} // RVA: 0x7AE52C9D0
        public void GetTable(){} // RVA: 0x7AE52CF40
        public void ReadOldRowData(){} // RVA: 0x7AE52D200
        public void SkipWhitespaces(){} // RVA: 0x7AE52E310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XMLSchema : Object
    {
        // ── Methods ──
        public void GetConverter(){} // RVA: 0x7AE52E380
        public void SetProperties(){} // RVA: 0x7AE52E3D0
        public void FEqualIdentity(){} // RVA: 0x7AE52E8D0
        public void GetBooleanAttribute(){} // RVA: 0x7AE52E9C0
        public void GenUniqueColumnName(){} // RVA: 0x7AE52EBA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XSDSchema : XMLSchema
    {
        // ── Methods ──
        public void get_FromInference(){} // RVA: 0x7A9905F60
        public void set_FromInference(){} // RVA: 0x7A8935600
        public void CollectElementsAnnotations(){} // RVA: 0x7AE52EE30
        public void QualifiedName(){} // RVA: 0x7AE52F870
        public void SetProperties(){} // RVA: 0x7AE52F8E0
        public void SetExtProperties(){} // RVA: 0x7AE530A00
        public void HandleColumnExpression(){} // RVA: 0x7AE5305F0
        public void GetMsdataAttribute(){} // RVA: 0x7AE530870
        public void HandleRefTableProperties(){} // RVA: 0x7AE530CB0
        public void HandleRelation(){} // RVA: 0x7AE530DB0
        public void HasAttributes(){} // RVA: 0x7AE531820
        public void IsDatasetParticle(){} // RVA: 0x7AE531A60
        public void DatasetElementCount(){} // RVA: 0x7AE532120
        public void FindDatasetElement(){} // RVA: 0x7AE532330
        public void LoadSchema(){} // RVA: 0x7AE532920
        public void HandleRelations(){} // RVA: 0x7AE534540
        public void GetParticleItems(){} // RVA: 0x7AE534830
        public void HandleParticle(){} // RVA: 0x7AE534B50
        public void HandleAttributes(){} // RVA: 0x7AE535530
        public void HandleAttributeGroup(){} // RVA: 0x7AE535820
        public void HandleComplexType(){} // RVA: 0x7AE535BE0
        public void GetParticle(){} // RVA: 0x7AE5364A0
        public void FindField(){} // RVA: 0x7AE536650
        public void BuildKey(){} // RVA: 0x7AE536930
        public void GetBooleanAttribute(){} // RVA: 0x7AE536C00
        public void GetStringAttribute(){} // RVA: 0x7AE536E00
        public void TranslateAcceptRejectRule(){} // RVA: 0x7AE536E80
        public void TranslateRule(){} // RVA: 0x7AE536F20
        public void HandleKeyref(){} // RVA: 0x7AE5370B0
        public void HandleConstraint(){} // RVA: 0x7AE537AB0
        public void InstantiateSimpleTable(){} // RVA: 0x7AE538120
        public void GetInstanceName(){} // RVA: 0x7AE538A30
        public void InstantiateTable(){} // RVA: 0x7AE538B90
        public void XsdtoClr(){} // RVA: 0x7AE539FE0
        public void FindNameType(){} // RVA: 0x7AE53A180
        public void ParseDataType(){} // RVA: 0x7AE53A310
        public void IsXsdType(){} // RVA: 0x7AE53A630
        public void FindTypeNode(){} // RVA: 0x7AE53A750
        public void HandleSimpleTypeSimpleContentColumn(){} // RVA: 0x7AE53AB90
        public void HandleSimpleContentColumn(){} // RVA: 0x7AE53BA60
        public void HandleAttributeColumn(){} // RVA: 0x7AE53C610
        public void HandleElementColumn(){} // RVA: 0x7AE53D2B0
        public void HandleDataSet(){} // RVA: 0x7AE53E610
        public void AddTablesToList(){} // RVA: 0x7AE53F9F0
        public void GetPrefix(){} // RVA: 0x7AE53FBE0
        public void GetNamespaceFromPrefix(){} // RVA: 0x7AE53FE90
        public void GetTableNamespace(){} // RVA: 0x7AE540150
        public void GetTableName(){} // RVA: 0x7AE540360
        public void IsTable(){} // RVA: 0x7AE540500
        public void HandleTable(){} // RVA: 0x7AE5408E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE540B10
    }

    public class XmlDataLoader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE543600
        public void get_FromInference(){} // RVA: 0x7ACDBE8E0
        public void set_FromInference(){} // RVA: 0x7ADE0AE10
        public void AttachRows(){} // RVA: 0x7AE5438F0
        public void CountNonNSAttributes(){} // RVA: 0x7AE543A80
        public void GetValueForTextOnlyColums(){} // RVA: 0x7AE543C50
        public void GetInitialTextFromNodes(){} // RVA: 0x7AE543F40
        public void GetTextOnlyColumn(){} // RVA: 0x7AE544330
        public void GetRowFromElement(){} // RVA: 0x7AE5443E0
        public void FColumnElement(){} // RVA: 0x7AE544480
        public void FExcludedNamespace(){} // RVA: 0x7AE5445B0
        public void FIgnoreNamespace(){} // RVA: 0x7AE544860
        public void IsTextLikeNode(){} // RVA: 0x7AE5449C0
        public void IsTextOnly(){} // RVA: 0x7AE544A20
        public void LoadData(){} // RVA: 0x7AE546790
        public void LoadRowData(){} // RVA: 0x7AE544E60
        public void LoadRows(){} // RVA: 0x7AE545BC0
        public void SetRowValueFromXmlText(){} // RVA: 0x7AE546090
        public void InitNameTable(){} // RVA: 0x7AE546110
        public void LoadTopMostTable(){} // RVA: 0x7AE546C90
        public void LoadTable(){} // RVA: 0x7AE547690
        public void LoadColumn(){} // RVA: 0x7AE548840
        public void ProcessXsdSchema(){} // RVA: 0x7AE549360
    }

    public class XmlDataTreeWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE55E6E0
        public void CreateToplevelTables(){} // RVA: 0x7AE55EA90
        public void CreateTablesHierarchy(){} // RVA: 0x7AE55EDA0
        public void RowHasErrors(){} // RVA: 0x7AE55F080
        public void SaveDiffgramData(){} // RVA: 0x7AE55F1B0
        public void Save(){} // RVA: 0x7AE55F7E0
        public void GetNestedChildRelations(){} // RVA: 0x7AE560070
        public void XmlDataRowWriter(){} // RVA: 0x7AE560330
        public void PreserveSpace(){} // RVA: 0x7AE561A10
    }

    public class XmlIgnoreNamespaceReader : XmlNodeReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5429E0
        public void MoveToFirstAttribute(){} // RVA: 0x7AE542BE0
        public void MoveToNextAttribute(){} // RVA: 0x7AE542E10
    }

    public class XmlToDatasetMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5495F0
        public void IsMappedColumn(){} // RVA: 0x7AE549600
        public void AddTableSchema(){} // RVA: 0x7AE549780
        public void AddColumnSchema(){} // RVA: 0x7AE549C20
        public void BuildIdentityMap(){} // RVA: 0x7AE54AF00
        public void GetSelfAndDescendants(){} // RVA: 0x7AE54B680
        public void GetColumnSchema(){} // RVA: 0x7AE54BBA0
        public void GetSchemaForNode(){} // RVA: 0x7AE54BE70
        public void GetTableForNode(){} // RVA: 0x7AE54BF70
        public void HandleSpecialColumn(){} // RVA: 0x7AE54C0B0
    }

    public class XmlTreeGen : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE54CBE0
        public void AddExtendedProperties(){} // RVA: 0x7AE54CD40
        public void AddXdoProperties(){} // RVA: 0x7AE54D370
        public void AddXdoProperty(){} // RVA: 0x7AE54D550
        public void XmlDataTypeName(){} // RVA: 0x7AE54E280
        public void GenerateConstraintNames(){} // RVA: 0x7AE54F4A0
        public void _PropsNotEmpty(){} // RVA: 0x7AE54F6C0
        public void HaveExtendedProperties(){} // RVA: 0x7AE54F6F0
        public void WriteSchemaRoot(){} // RVA: 0x7AE54F8E0
        public void ValidateColumnMapping(){} // RVA: 0x7AE54FB50
        public void SetupAutoGenerated(){} // RVA: 0x7AE54FF20
        public void CreateTablesHierarchy(){} // RVA: 0x7AE5508E0
        public void CreateRelations(){} // RVA: 0x7AE550BC0
        public void CreateToplevelTables(){} // RVA: 0x7AE550E70
        public void SchemaTree(){} // RVA: 0x7AE553B80
        public void FillDataSetElement(){} // RVA: 0x7AE554350
        public void SetPath(){} // RVA: 0x7AE554B10
        public void Save(){} // RVA: 0x7AE555060
        public void HandleRelation(){} // RVA: 0x7AE555260
        public void FindSimpleType(){} // RVA: 0x7AE5559F0
        public void GetSchema(){} // RVA: 0x7AE555B60
        public void HandleColumnType(){} // RVA: 0x7AE555E30
        public void AddColumnProperties(){} // RVA: 0x7AE5563A0
        public void FindTargetNamespace(){} // RVA: 0x7AE556BF0
        public void HandleColumn(){} // RVA: 0x7AE556D30
        public void TranslateAcceptRejectRule(){} // RVA: 0x7AE5579A0
        public void TranslateRule(){} // RVA: 0x7AE557A10
        public void AppendChildWithoutRef(){} // RVA: 0x7AE557AC0
        public void FindTypeNode(){} // RVA: 0x7AE557B80
        public void HandleTable(){} // RVA: 0x7AE558A80
        public void HasMixedColumns(){} // RVA: 0x7AE557DD0
        public void AutoGenerated(){} // RVA: 0x7AE558890
        public void IsAutoGenerated(){} // RVA: 0x7AE558A40
        public void SetMSDataAttribute(){} // RVA: 0x7AE55B560
    }

}