// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 9
// Methods: 197

namespace ThirdParty.DotNet.System.Data
{
    public class XDRSchema : XMLSchema
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87276DE0
        public void LoadSchema(){} // RVA: 0x7FFE87276F90
        public void FindTypeNode(){} // RVA: 0x7FFE87277400
        public void IsTextOnlyContent(){} // RVA: 0x7FFE872779C0
        public void IsXDRField(){} // RVA: 0x7FFE87277C50
        public void HandleTable(){} // RVA: 0x7FFE87277E60
        public void FindNameType(){} // RVA: 0x7FFE87278090
        public void ParseDataType(){} // RVA: 0x7FFE87278230
        public void GetInstanceName(){} // RVA: 0x7FFE87278410
        public void HandleColumn(){} // RVA: 0x7FFE872786F0
        public void GetMinMax(){} // RVA: 0x7FFE872792D0 | overloaded x2
        public void HandleTypeNode(){} // RVA: 0x7FFE87279710
        public void InstantiateTable(){} // RVA: 0x7FFE87279940
        public void InstantiateSimpleTable(){} // RVA: 0x7FFE8727A010
        public void .cctor(){} // RVA: 0x7FFE8727A340
    }

    public class XMLDiffLoader : Object
    {
        // ── Methods ──
        public void LoadDiffGram(){} // RVA: 0x7FFE8727C3D0 | overloaded x2
        public void CreateTablesHierarchy(){} // RVA: 0x7FFE8727C0E0
        public void ProcessDiffs(){} // RVA: 0x7FFE8727CBB0 | overloaded x2
        public void ProcessErrors(){} // RVA: 0x7FFE8727D410 | overloaded x2
        public void GetTable(){} // RVA: 0x7FFE8727D980
        public void ReadOldRowData(){} // RVA: 0x7FFE8727DC40
        public void SkipWhitespaces(){} // RVA: 0x7FFE8727ED20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XMLSchema : Object
    {
        // ── Methods ──
        public void GetConverter(){} // RVA: 0x7FFE8727ED90
        public void SetProperties(){} // RVA: 0x7FFE8727EDE0
        public void FEqualIdentity(){} // RVA: 0x7FFE8727F2E0
        public void GetBooleanAttribute(){} // RVA: 0x7FFE8727F3D0
        public void GenUniqueColumnName(){} // RVA: 0x7FFE8727F5B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XSDSchema : XMLSchema
    {
        public System.Xml.Schema.XmlSchemaSet _schemaSet; // 0x10

        // ── Methods ──
        public void get_FromInference(){} // RVA: 0x7FFE820E9360
        public void set_FromInference(){} // RVA: 0x7FFE818DBD80
        public void CollectElementsAnnotations(){} // RVA: 0x7FFE8727F840 | overloaded x2
        public void QualifiedName(){} // RVA: 0x7FFE872802B0
        public void SetProperties(){} // RVA: 0x7FFE87280320
        public void SetExtProperties(){} // RVA: 0x7FFE87281460 | overloaded x2
        public void HandleColumnExpression(){} // RVA: 0x7FFE87281040
        public void GetMsdataAttribute(){} // RVA: 0x7FFE872812D0
        public void HandleRefTableProperties(){} // RVA: 0x7FFE87281710
        public void HandleRelation(){} // RVA: 0x7FFE87281810
        public void HasAttributes(){} // RVA: 0x7FFE87282230
        public void IsDatasetParticle(){} // RVA: 0x7FFE87282470
        public void DatasetElementCount(){} // RVA: 0x7FFE87282BC0
        public void FindDatasetElement(){} // RVA: 0x7FFE87282DE0
        public void LoadSchema(){} // RVA: 0x7FFE872833D0 | overloaded x2
        public void HandleRelations(){} // RVA: 0x7FFE87285040
        public void GetParticleItems(){} // RVA: 0x7FFE87285340
        public void HandleParticle(){} // RVA: 0x7FFE87285660
        public void HandleAttributes(){} // RVA: 0x7FFE87286030
        public void HandleAttributeGroup(){} // RVA: 0x7FFE87286340
        public void HandleComplexType(){} // RVA: 0x7FFE87286700
        public void GetParticle(){} // RVA: 0x7FFE87286FE0
        public void FindField(){} // RVA: 0x7FFE87287190
        public void BuildKey(){} // RVA: 0x7FFE87287470
        public void GetBooleanAttribute(){} // RVA: 0x7FFE87287720
        public void GetStringAttribute(){} // RVA: 0x7FFE87287920
        public void TranslateAcceptRejectRule(){} // RVA: 0x7FFE872879A0
        public void TranslateRule(){} // RVA: 0x7FFE87287A40
        public void HandleKeyref(){} // RVA: 0x7FFE87287BD0
        public void HandleConstraint(){} // RVA: 0x7FFE872885E0
        public void InstantiateSimpleTable(){} // RVA: 0x7FFE87288C40
        public void GetInstanceName(){} // RVA: 0x7FFE87289580
        public void InstantiateTable(){} // RVA: 0x7FFE872896E0
        public void XsdtoClr(){} // RVA: 0x7FFE8728AB60
        public void FindNameType(){} // RVA: 0x7FFE8728AD00
        public void ParseDataType(){} // RVA: 0x7FFE8728AE90
        public void IsXsdType(){} // RVA: 0x7FFE8728B1B0
        public void FindTypeNode(){} // RVA: 0x7FFE8728B2D0
        public void HandleSimpleTypeSimpleContentColumn(){} // RVA: 0x7FFE8728B720
        public void HandleSimpleContentColumn(){} // RVA: 0x7FFE8728C640
        public void HandleAttributeColumn(){} // RVA: 0x7FFE8728D210
        public void HandleElementColumn(){} // RVA: 0x7FFE8728DEE0
        public void HandleDataSet(){} // RVA: 0x7FFE8728F1F0
        public void AddTablesToList(){} // RVA: 0x7FFE87290750
        public void GetPrefix(){} // RVA: 0x7FFE87290930
        public void GetNamespaceFromPrefix(){} // RVA: 0x7FFE87290C10
        public void GetTableNamespace(){} // RVA: 0x7FFE87290F00
        public void GetTableName(){} // RVA: 0x7FFE87291110
        public void IsTable(){} // RVA: 0x7FFE872912B0
        public void HandleTable(){} // RVA: 0x7FFE87291680
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE872918B0
    }

    public class XmlDataLoader : Object
    {
        public System.Data.DataSet _dataSet; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872943A0 | overloaded x4
        public void get_FromInference(){} // RVA: 0x7FFE85BA8C00
        public void set_FromInference(){} // RVA: 0x7FFE86B5F180
        public void AttachRows(){} // RVA: 0x7FFE87294680
        public void CountNonNSAttributes(){} // RVA: 0x7FFE87294810
        public void GetValueForTextOnlyColums(){} // RVA: 0x7FFE872949E0
        public void GetInitialTextFromNodes(){} // RVA: 0x7FFE87294CD0
        public void GetTextOnlyColumn(){} // RVA: 0x7FFE872950C0
        public void GetRowFromElement(){} // RVA: 0x7FFE87295170
        public void FColumnElement(){} // RVA: 0x7FFE87295210
        public void FExcludedNamespace(){} // RVA: 0x7FFE87295340
        public void FIgnoreNamespace(){} // RVA: 0x7FFE872955F0 | overloaded x2
        public void IsTextLikeNode(){} // RVA: 0x7FFE87295750
        public void IsTextOnly(){} // RVA: 0x7FFE872957B0
        public void LoadData(){} // RVA: 0x7FFE87297550 | overloaded x2
        public void LoadRowData(){} // RVA: 0x7FFE87295BE0
        public void LoadRows(){} // RVA: 0x7FFE87296980
        public void SetRowValueFromXmlText(){} // RVA: 0x7FFE87296E50
        public void InitNameTable(){} // RVA: 0x7FFE87296ED0
        public void LoadTopMostTable(){} // RVA: 0x7FFE87297A60
        public void LoadTable(){} // RVA: 0x7FFE87298490
        public void LoadColumn(){} // RVA: 0x7FFE87299630
        public void ProcessXsdSchema(){} // RVA: 0x7FFE8729A170
    }

    public class XmlDataTreeWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872AF5C0 | overloaded x2
        public void CreateToplevelTables(){} // RVA: 0x7FFE872AF960
        public void CreateTablesHierarchy(){} // RVA: 0x7FFE872AFC70
        public void RowHasErrors(){} // RVA: 0x7FFE872AFF60
        public void SaveDiffgramData(){} // RVA: 0x7FFE872B0090
        public void Save(){} // RVA: 0x7FFE872B06E0
        public void GetNestedChildRelations(){} // RVA: 0x7FFE872B0F80
        public void XmlDataRowWriter(){} // RVA: 0x7FFE872B1250
        public void PreserveSpace(){} // RVA: 0x7FFE872B2970
    }

    public class XmlIgnoreNamespaceReader : XmlNodeReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87293780
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE87293980
        public void MoveToNextAttribute(){} // RVA: 0x7FFE87293BC0
    }

    public class XmlToDatasetMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8729A400 | overloaded x4
        public void IsMappedColumn(){} // RVA: 0x7FFE8729A410
        public void AddTableSchema(){} // RVA: 0x7FFE8729A590 | overloaded x2
        public void AddColumnSchema(){} // RVA: 0x7FFE8729AA30 | overloaded x2
        public void BuildIdentityMap(){} // RVA: 0x7FFE8729BD30 | overloaded x4
        public void GetSelfAndDescendants(){} // RVA: 0x7FFE8729C4A0
        public void GetColumnSchema(){} // RVA: 0x7FFE8729C9D0 | overloaded x2
        public void GetSchemaForNode(){} // RVA: 0x7FFE8729CCA0
        public void GetTableForNode(){} // RVA: 0x7FFE8729CDA0
        public void HandleSpecialColumn(){} // RVA: 0x7FFE8729CEE0
    }

    public class XmlTreeGen : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8729D9F0
        public void AddExtendedProperties(){} // RVA: 0x7FFE8729DB50 | overloaded x2
        public void AddXdoProperties(){} // RVA: 0x7FFE8729E190
        public void AddXdoProperty(){} // RVA: 0x7FFE8729E370
        public void XmlDataTypeName(){} // RVA: 0x7FFE8729F0A0
        public void GenerateConstraintNames(){} // RVA: 0x7FFE872A02D0 | overloaded x3
        public void _PropsNotEmpty(){} // RVA: 0x7FFE872A0500
        public void HaveExtendedProperties(){} // RVA: 0x7FFE872A0530
        public void WriteSchemaRoot(){} // RVA: 0x7FFE872A0720
        public void ValidateColumnMapping(){} // RVA: 0x7FFE872A0990
        public void SetupAutoGenerated(){} // RVA: 0x7FFE872A0D70 | overloaded x3
        public void CreateTablesHierarchy(){} // RVA: 0x7FFE872A1790
        public void CreateRelations(){} // RVA: 0x7FFE872A1A80
        public void CreateToplevelTables(){} // RVA: 0x7FFE872A1D40
        public void SchemaTree(){} // RVA: 0x7FFE872A4A70 | overloaded x2
        public void FillDataSetElement(){} // RVA: 0x7FFE872A5240
        public void SetPath(){} // RVA: 0x7FFE872A5A00
        public void Save(){} // RVA: 0x7FFE872A5FC0 | overloaded x5
        public void HandleRelation(){} // RVA: 0x7FFE872A61C0
        public void FindSimpleType(){} // RVA: 0x7FFE872A6930
        public void GetSchema(){} // RVA: 0x7FFE872A6AA0
        public void HandleColumnType(){} // RVA: 0x7FFE872A6D70
        public void AddColumnProperties(){} // RVA: 0x7FFE872A72E0
        public void FindTargetNamespace(){} // RVA: 0x7FFE872A7B20
        public void HandleColumn(){} // RVA: 0x7FFE872A7C60
        public void TranslateAcceptRejectRule(){} // RVA: 0x7FFE872A88A0
        public void TranslateRule(){} // RVA: 0x7FFE872A8910
        public void AppendChildWithoutRef(){} // RVA: 0x7FFE872A89C0
        public void FindTypeNode(){} // RVA: 0x7FFE872A8A80
        public void HandleTable(){} // RVA: 0x7FFE872A99B0 | overloaded x2
        public void HasMixedColumns(){} // RVA: 0x7FFE872A8CD0
        public void AutoGenerated(){} // RVA: 0x7FFE872A97C0 | overloaded x5
        public void IsAutoGenerated(){} // RVA: 0x7FFE872A9970
        public void SetMSDataAttribute(){} // RVA: 0x7FFE872AC4C0
    }

}