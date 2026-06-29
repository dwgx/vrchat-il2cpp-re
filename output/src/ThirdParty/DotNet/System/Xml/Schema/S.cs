// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 17
// Methods: 314

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class SchemaAttDef : SchemaDeclBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE73AF20
        public void System.Xml.IDtdAttributeInfo.get_Prefix(){} // RVA: 0x7AE73AF30
        public void System.Xml.IDtdAttributeInfo.get_LocalName(){} // RVA: 0x7A88F4180
        public void System.Xml.IDtdAttributeInfo.get_LineNumber(){} // RVA: 0x7A9A93870
        public void System.Xml.IDtdAttributeInfo.get_LinePosition(){} // RVA: 0x7A9A93890
        public void System.Xml.IDtdAttributeInfo.get_IsNonCDataType(){} // RVA: 0x7AE73AF90
        public void System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal(){} // RVA: 0x7A81C68D0
        public void System.Xml.IDtdAttributeInfo.get_IsXmlAttribute(){} // RVA: 0x7AE73AFC0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded(){} // RVA: 0x7AE73AFD0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped(){} // RVA: 0x7A8154D80
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber(){} // RVA: 0x7A8EA8210
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition(){} // RVA: 0x7A96E4F70
        public void get_LinePosition(){} // RVA: 0x7A9A93890
        public void set_LinePosition(){} // RVA: 0x7A9A938A0
        public void get_LineNumber(){} // RVA: 0x7A9A93870
        public void set_LineNumber(){} // RVA: 0x7A9A93880
        public void get_ValueLinePosition(){} // RVA: 0x7A96E4F70
        public void set_ValueLinePosition(){} // RVA: 0x7A9B90E90
        public void get_ValueLineNumber(){} // RVA: 0x7A8EA8210
        public void set_ValueLineNumber(){} // RVA: 0x7A8270510
        public void get_DefaultValueExpanded(){} // RVA: 0x7AE73B030
        public void set_DefaultValueExpanded(){} // RVA: 0x7A8175E00
        public void get_TokenizedType(){} // RVA: 0x7A99A0BC0
        public void set_TokenizedType(){} // RVA: 0x7AE73B090
        public void get_Reserved(){} // RVA: 0x7A989D5C0
        public void set_Reserved(){} // RVA: 0x7A98A0B60
        public void get_DefaultValueChecked(){} // RVA: 0x7A86655E0
        public void get_SchemaAttribute(){} // RVA: 0x7A825E100
        public void set_SchemaAttribute(){} // RVA: 0x7A825F860
        public void CheckXmlSpace(){} // RVA: 0x7AE73B100
        public void Clone(){} // RVA: 0x7AE73B490
        public void .cctor(){} // RVA: 0x7AE73B4F0
    }

    public class SchemaBuilder : Object
    {
        // ── Methods ──
        public void ProcessElement(){} // RVA: 0x7A7E01D90
        public void ProcessAttribute(){} // RVA: 0x7A7E1DB70
        public void IsContentParsed(){} // RVA: 0x7A7E01900
        public void ProcessMarkup(){} // RVA: 0x7A7E18800
        public void ProcessCData(){} // RVA: 0x7A7E18800
        public void StartChildren(){} // RVA: 0x7A7E18770
        public void EndChildren(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SchemaCollectionCompiler : BaseProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE73B5A0
        public void Execute(){} // RVA: 0x7AE73B710
        public void Prepare(){} // RVA: 0x7AE73B7C0
        public void Cleanup(){} // RVA: 0x7AE73C8C0
        public void Compile(){} // RVA: 0x7AE73D330
        public void Output(){} // RVA: 0x7AE73EF20
        public void CleanupAttribute(){} // RVA: 0x7AE73FDB0
        public void CleanupAttributeGroup(){} // RVA: 0x7AE73FE90
        public void CleanupComplexType(){} // RVA: 0x7AE73FF20
        public void CleanupSimpleType(){} // RVA: 0x7AE740470
        public void CleanupElement(){} // RVA: 0x7AE7404E0
        public void CleanupAttributes(){} // RVA: 0x7AE7407C0
        public void CleanupGroup(){} // RVA: 0x7AE7408A0
        public void CleanupParticle(){} // RVA: 0x7AE740920
        public void CompileSubstitutionGroup(){} // RVA: 0x7AE740B20
        public void CheckSubstitutionGroup(){} // RVA: 0x7AE741130
        public void CompileGroup(){} // RVA: 0x7AE741380
        public void CompileSimpleType(){} // RVA: 0x7AE7414C0
        public void CompileBaseMemberTypes(){} // RVA: 0x7AE7420E0
        public void CheckUnionType(){} // RVA: 0x7AE7425B0
        public void CompileComplexType(){} // RVA: 0x7AE7426F0
        public void CompileSimpleContentExtension(){} // RVA: 0x7AE743530
        public void CompileSimpleContentRestriction(){} // RVA: 0x7AE743870
        public void CompileComplexContentExtension(){} // RVA: 0x7AE743D40
        public void CompileComplexContentRestriction(){} // RVA: 0x7AE744350
        public void CheckParticleDerivation(){} // RVA: 0x7AE744810
        public void CompileContentTypeParticle(){} // RVA: 0x7AE744900
        public void CannonicalizeParticle(){} // RVA: 0x7AE744B10
        public void CannonicalizeElement(){} // RVA: 0x7AE744E70
        public void CannonicalizeGroupRef(){} // RVA: 0x7AE745040
        public void CannonicalizeAll(){} // RVA: 0x7AE745850
        public void CannonicalizeChoice(){} // RVA: 0x7AE745FA0
        public void CannonicalizeSequence(){} // RVA: 0x7AE746800
        public void IsValidRestriction(){} // RVA: 0x7AE746FE0
        public void IsElementFromElement(){} // RVA: 0x7AE747B10
        public void IsElementFromAny(){} // RVA: 0x7AE747D10
        public void IsAnyFromAny(){} // RVA: 0x7AE747DA0
        public void IsGroupBaseFromAny(){} // RVA: 0x7AE747E00
        public void IsElementFromGroupBase(){} // RVA: 0x7AE748170
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7AE7485E0
        public void IsSequenceFromAll(){} // RVA: 0x7AE748920
        public void IsSequenceFromChoice(){} // RVA: 0x7AE748D10
        public void CalculateSequenceRange(){} // RVA: 0x7AE749080
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7AE749830
        public void GetMappingParticle(){} // RVA: 0x7AE749980
        public void IsParticleEmptiable(){} // RVA: 0x7AE749AA0
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7AE749BB0
        public void PushComplexType(){} // RVA: 0x7AE74A8D0
        public void GetSchemaContentType(){} // RVA: 0x7AE74A900
        public void CompileAttributeGroup(){} // RVA: 0x7AE74A980
        public void CompileLocalAttributes(){} // RVA: 0x7AE74B0C0
        public void CompileAnyAttributeUnion(){} // RVA: 0x7AE74C1D0
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7AE74C280
        public void CompileAttribute(){} // RVA: 0x7AE74C330
        public void CompileIdentityConstraint(){} // RVA: 0x7AE74CEB0
        public void CompileElement(){} // RVA: 0x7AE74D5E0
        public void CompileComplexContent(){} // RVA: 0x7AE74E530
        public void BuildParticleContentModel(){} // RVA: 0x7AE74F330
        public void CompileParticleElements(){} // RVA: 0x7AE74FBF0
        public void CompileCompexTypeElements(){} // RVA: 0x7AE74FF10
        public void GetSimpleType(){} // RVA: 0x7AE74FFF0
        public void GetComplexType(){} // RVA: 0x7AE750160
        public void GetAnySchemaType(){} // RVA: 0x7AE750220
    }

    public class SchemaCollectionPreprocessor : BaseProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE750400
        public void Execute(){} // RVA: 0x7AE750410
        public void Cleanup(){} // RVA: 0x7AE750780
        public void set_XmlResolver(){} // RVA: 0x7A825F860
        public void LoadExternals(){} // RVA: 0x7AE750D40
        public void BuildRefNamespaces(){} // RVA: 0x7AE7519D0
        public void Preprocess(){} // RVA: 0x7AE751C70
        public void PreprocessRedefine(){} // RVA: 0x7AE753A10
        public void CountGroupSelfReference(){} // RVA: 0x7AE754C00
        public void CheckRefinedGroup(){} // RVA: 0x7AE754F80
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7AE755020
        public void CheckRefinedSimpleType(){} // RVA: 0x7AE755190
        public void CheckRefinedComplexType(){} // RVA: 0x7AE7552E0
        public void PreprocessAttribute(){} // RVA: 0x7AE755780
        public void PreprocessLocalAttribute(){} // RVA: 0x7AE755960
        public void PreprocessAttributeContent(){} // RVA: 0x7AE755C20
        public void PreprocessAttributeGroup(){} // RVA: 0x7AE755F60
        public void PreprocessElement(){} // RVA: 0x7AE7560D0
        public void PreprocessLocalElement(){} // RVA: 0x7AE7563C0
        public void PreprocessElementContent(){} // RVA: 0x7AE7568F0
        public void PreprocessIdentityConstraint(){} // RVA: 0x7AE756E10
        public void PreprocessSimpleType(){} // RVA: 0x7AE757330
        public void PreprocessComplexType(){} // RVA: 0x7AE757CF0
        public void PreprocessGroup(){} // RVA: 0x7AE758A60
        public void PreprocessNotation(){} // RVA: 0x7AE758CB0
        public void PreprocessParticle(){} // RVA: 0x7AE758F00
        public void PreprocessAttributes(){} // RVA: 0x7AE759C70
        public void ValidateIdAttribute(){} // RVA: 0x7AE75A110
        public void ValidateNameAttribute(){} // RVA: 0x7AE75A340
        public void ValidateQNameAttribute(){} // RVA: 0x7AE75A670
        public void SetParent(){} // RVA: 0x7AE73AC60
        public void PreprocessAnnotation(){} // RVA: 0x7AE75A790
        public void ResolveSchemaLocationUri(){} // RVA: 0x7AE75A920
        public void GetSchemaEntity(){} // RVA: 0x7AE75A970
    }

    public class SchemaDeclBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE75AC10
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_Prefix(){} // RVA: 0x7AE75ACC0
        public void set_Prefix(){} // RVA: 0x7A813E420
        public void get_IsDeclaredInExternal(){} // RVA: 0x7A81C68D0
        public void set_IsDeclaredInExternal(){} // RVA: 0x7A81C68E0
        public void get_Presence(){} // RVA: 0x7A8AB15F0
        public void set_Presence(){} // RVA: 0x7A94794D0
        public void get_MaxLength(){} // RVA: 0x7A8152D80
        public void set_MaxLength(){} // RVA: 0x7A9558880
        public void get_MinLength(){} // RVA: 0x7A8178B90
        public void set_MinLength(){} // RVA: 0x7A82C1E60
        public void get_SchemaType(){} // RVA: 0x7A8105330
        public void set_SchemaType(){} // RVA: 0x7A80D8E80
        public void get_Datatype(){} // RVA: 0x7A83F69F0
        public void set_Datatype(){} // RVA: 0x7A8105A90
        public void AddValue(){} // RVA: 0x7AE75AD20
        public void get_Values(){} // RVA: 0x7A81A0050
        public void set_Values(){} // RVA: 0x7A81A0060
        public void get_DefaultValueRaw(){} // RVA: 0x7AE75AE60
        public void set_DefaultValueRaw(){} // RVA: 0x7A8296DE0
        public void get_DefaultValueTyped(){} // RVA: 0x7A8154D80
        public void set_DefaultValueTyped(){} // RVA: 0x7A80FF440
        public void CheckEnumeration(){} // RVA: 0x7AE75AEC0
        public void CheckValue(){} // RVA: 0x7AE75AF80
    }

    public class SchemaElementDecl : SchemaDeclBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE75B3B0
        public void CreateAnyTypeElementDecl(){} // RVA: 0x7AE75B540
        public void System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes(){} // RVA: 0x7AD89C540
        public void System.Xml.IDtdAttributeListInfo.LookupAttribute(){} // RVA: 0x7AE75B660
        public void System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes(){} // RVA: 0x7A8153390
        public void get_IsIdDeclared(){} // RVA: 0x7A8153980
        public void set_IsIdDeclared(){} // RVA: 0x7A8153990
        public void get_HasNonCDataAttribute(){} // RVA: 0x7AD89C540
        public void set_HasNonCDataAttribute(){} // RVA: 0x7AD89C550
        public void Clone(){} // RVA: 0x7AE75B720
        public void get_IsAbstract(){} // RVA: 0x7AD89C560
        public void set_IsAbstract(){} // RVA: 0x7AD89C570
        public void get_IsNillable(){} // RVA: 0x7AE147520
        public void set_IsNillable(){} // RVA: 0x7AE75B780
        public void get_Block(){} // RVA: 0x7A846C760
        public void set_Block(){} // RVA: 0x7A8CCD330
        public void get_IsNotationDeclared(){} // RVA: 0x7A8F12D90
        public void set_IsNotationDeclared(){} // RVA: 0x7AE165850
        public void get_HasDefaultAttribute(){} // RVA: 0x7A91002B0
        public void get_HasRequiredAttribute(){} // RVA: 0x7A8EE1FF0
        public void get_ContentValidator(){} // RVA: 0x7A825E100
        public void set_ContentValidator(){} // RVA: 0x7A825F860
        public void get_AnyAttribute(){} // RVA: 0x7A81163D0
        public void set_AnyAttribute(){} // RVA: 0x7A825E460
        public void get_Constraints(){} // RVA: 0x7A87D9C10
        public void set_Constraints(){} // RVA: 0x7A8744720
        public void get_SchemaElement(){} // RVA: 0x7A87C5850
        public void set_SchemaElement(){} // RVA: 0x7A87446C0
        public void AddAttDef(){} // RVA: 0x7AE75B790
        public void GetAttDef(){} // RVA: 0x7AE75B940
        public void get_DefaultAttDefs(){} // RVA: 0x7A8153390
        public void get_AttDefs(){} // RVA: 0x7A8175DF0
        public void get_ProhibitedAttributes(){} // RVA: 0x7A82C2060
        public void CheckAttributes(){} // RVA: 0x7AE75B9C0
        public void .cctor(){} // RVA: 0x7AE75BD50
    }

    public class SchemaEntity : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE75BE00
        public void System.Xml.IDtdEntityInfo.get_Name(){} // RVA: 0x7A88F4180
        public void System.Xml.IDtdEntityInfo.get_IsExternal(){} // RVA: 0x7A83F3AD0
        public void System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal(){} // RVA: 0x7A92A8970
        public void System.Xml.IDtdEntityInfo.get_IsUnparsedEntity(){} // RVA: 0x7AE75BF20
        public void System.Xml.IDtdEntityInfo.get_IsParameterEntity(){} // RVA: 0x7A8193790
        public void System.Xml.IDtdEntityInfo.get_BaseUriString(){} // RVA: 0x7AE75BF70
        public void System.Xml.IDtdEntityInfo.get_DeclaredUriString(){} // RVA: 0x7AE75BFD0
        public void System.Xml.IDtdEntityInfo.get_SystemId(){} // RVA: 0x7A80DA7B0
        public void System.Xml.IDtdEntityInfo.get_PublicId(){} // RVA: 0x7A81052C0
        public void System.Xml.IDtdEntityInfo.get_Text(){} // RVA: 0x7A8105330
        public void System.Xml.IDtdEntityInfo.get_LineNumber(){} // RVA: 0x7A8D863F0
        public void System.Xml.IDtdEntityInfo.get_LinePosition(){} // RVA: 0x7A864E8D0
        public void IsPredefinedEntity(){} // RVA: 0x7AE75C030
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Url(){} // RVA: 0x7A80DA7B0
        public void set_Url(){} // RVA: 0x7AE75C1E0
        public void get_Pubid(){} // RVA: 0x7A81052C0
        public void set_Pubid(){} // RVA: 0x7A81052D0
        public void get_IsExternal(){} // RVA: 0x7A83F3AD0
        public void set_IsExternal(){} // RVA: 0x7A83F3AC0
        public void get_DeclaredInExternal(){} // RVA: 0x7A92A8970
        public void set_DeclaredInExternal(){} // RVA: 0x7A98B2A90
        public void get_NData(){} // RVA: 0x7A83F69F0
        public void set_NData(){} // RVA: 0x7A8105A90
        public void get_Text(){} // RVA: 0x7A8105330
        public void set_Text(){} // RVA: 0x7AE75C240
        public void get_Line(){} // RVA: 0x7A8D863F0
        public void set_Line(){} // RVA: 0x7A8D870E0
        public void get_Pos(){} // RVA: 0x7A864E8D0
        public void set_Pos(){} // RVA: 0x7A9ABBD00
        public void get_BaseURI(){} // RVA: 0x7AE75C2A0
        public void set_BaseURI(){} // RVA: 0x7A8152D90
        public void get_ParsingInProgress(){} // RVA: 0x7A83F4170
        public void set_ParsingInProgress(){} // RVA: 0x7A83F3DC0
        public void get_DeclaredURI(){} // RVA: 0x7AE75C300
        public void set_DeclaredURI(){} // RVA: 0x7A8230620
    }

    public class SchemaInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE75C360
        public void get_DocTypeName(){} // RVA: 0x7A83F69F0
        public void set_DocTypeName(){} // RVA: 0x7A8105A90
        public void set_InternalDtdSubset(){} // RVA: 0x7A8296DE0
        public void get_ElementDecls(){} // RVA: 0x7A80F2570
        public void get_UndeclaredElementDecls(){} // RVA: 0x7A80DA7B0
        public void get_GeneralEntities(){} // RVA: 0x7AE75C740
        public void get_ParameterEntities(){} // RVA: 0x7AE75C800
        public void get_SchemaType(){} // RVA: 0x7A835E820
        public void set_SchemaType(){} // RVA: 0x7A87A7EB0
        public void get_TargetNamespaces(){} // RVA: 0x7A8152D80
        public void get_ElementDeclsByType(){} // RVA: 0x7A8175DF0
        public void get_AttributeDecls(){} // RVA: 0x7A8178B90
        public void get_Notations(){} // RVA: 0x7AE75C8C0
        public void get_ErrorCount(){} // RVA: 0x7A87A7DA0
        public void set_ErrorCount(){} // RVA: 0x7A87A7CF0
        public void GetElementDecl(){} // RVA: 0x7AE75C980
        public void GetTypeDecl(){} // RVA: 0x7AE75CA00
        public void GetElement(){} // RVA: 0x7AE75CA80
        public void HasSchema(){} // RVA: 0x7AE75CAB0
        public void Contains(){} // RVA: 0x7AE75CB30
        public void GetAttributeXdr(){} // RVA: 0x7AE75CBB0
        public void GetAttributeXsd(){} // RVA: 0x7AE75D050
        public void Add(){} // RVA: 0x7AE75D1A0
        public void Finish(){} // RVA: 0x7AE75DF90
        public void System.Xml.IDtdInfo.get_HasDefaultAttributes(){} // RVA: 0x7A83F3AD0
        public void System.Xml.IDtdInfo.get_HasNonCDataAttributes(){} // RVA: 0x7A8193790
        public void System.Xml.IDtdInfo.LookupAttributeList(){} // RVA: 0x7AE75E190
        public void System.Xml.IDtdInfo.LookupEntity(){} // RVA: 0x7AE75E270
        public void System.Xml.IDtdInfo.get_Name(){} // RVA: 0x7A83F69F0
        public void System.Xml.IDtdInfo.get_InternalDtdSubset(){} // RVA: 0x7A8292C30
    }

    public class SchemaNames : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE75E340
        public void CreateTokenToQNameTable(){} // RVA: 0x7AE761FA0
        public void SchemaTypeFromRoot(){} // RVA: 0x7AE764860
        public void IsXSDRoot(){} // RVA: 0x7AE7649D0
        public void IsXDRRoot(){} // RVA: 0x7AE764A80
    }

    public class SchemaNamespaceManager : XmlNamespaceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8230620
        public void LookupNamespace(){} // RVA: 0x7AE764B30
        public void LookupPrefix(){} // RVA: 0x7AE764CD0
    }

    public class SchemaNotation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_SystemLiteral(){} // RVA: 0x7A80DA7B0
        public void set_SystemLiteral(){} // RVA: 0x7A813E420
        public void get_Pubid(){} // RVA: 0x7A81052C0
        public void set_Pubid(){} // RVA: 0x7A81052D0
    }

    public class SelectorActiveAxis : ActiveAxis
    {
        // ── Methods ──
        public void get_lastDepth(){} // RVA: 0x7AE8C7060
        public void .ctor(){} // RVA: 0x7AE8C7110
        public void EndElement(){} // RVA: 0x7AE8C7230
        public void PushKS(){} // RVA: 0x7AE8C7420
        public void PopKS(){} // RVA: 0x7AE8C7A20
    }

    public class SequenceNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7AE8CB1B0
        public void get_IsNullable(){} // RVA: 0x7AE8CBB40
        public void ExpandTree(){} // RVA: 0x7AE8CBD30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StarNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7AE8CC2B0
        public void get_IsNullable(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StringFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void get_LanguagePattern(){} // RVA: 0x7AE8F8BC0
        public void CheckValueFacets(){} // RVA: 0x7AE8F8D70
        public void MatchEnumeration(){} // RVA: 0x7AE8F9080
        public void CheckBuiltInFacets(){} // RVA: 0x7AE8F9310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SymbolsDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8C9330
        public void get_Count(){} // RVA: 0x7AE8C9480
        public void get_IsUpaEnforced(){} // RVA: 0x7A82A20A0
        public void set_IsUpaEnforced(){} // RVA: 0x7A82A2C90
        public void AddName(){} // RVA: 0x7AE8C9490
        public void AddNamespaceList(){} // RVA: 0x7AE8C95D0
        public void AddWildcard(){} // RVA: 0x7AE8C98B0
        public void GetNamespaceListSymbols(){} // RVA: 0x7AE8C9A70
        public void get_Item(){} // RVA: 0x7AE8CA110
        public void Exists(){} // RVA: 0x7AE8CA210
        public void GetParticle(){} // RVA: 0x7AE8CA250
        public void NameOf(){} // RVA: 0x7AE8CA290
    }

    public class SyntaxTreeNode : Object
    {
        // ── Methods ──
        public void ExpandTree(){} // RVA: 0x7A7E1DDC0
        public void ConstructPos(){} // RVA: 0x7A7E1DDC0
        public void get_IsNullable(){} // RVA: 0x7A7E01900
        public void get_IsRangeNode(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}