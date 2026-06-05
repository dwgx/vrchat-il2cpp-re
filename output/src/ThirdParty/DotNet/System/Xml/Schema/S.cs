// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 18
// Methods: 325

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class SchemaAttDef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93FBB30 | overloaded x3
        public void System.Xml.IDtdAttributeInfo.get_Prefix(){} // RVA: 0x7FFAF93FBB40
        public void System.Xml.IDtdAttributeInfo.get_LocalName(){} // RVA: 0x7FFAF35DECF0
        public void System.Xml.IDtdAttributeInfo.get_LineNumber(){} // RVA: 0x7FFAF4741440
        public void System.Xml.IDtdAttributeInfo.get_LinePosition(){} // RVA: 0x7FFAF4741460
        public void System.Xml.IDtdAttributeInfo.get_IsNonCDataType(){} // RVA: 0x7FFAF93FBBA0
        public void System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal(){} // RVA: 0x7FFAF2E7B9D0
        public void System.Xml.IDtdAttributeInfo.get_IsXmlAttribute(){} // RVA: 0x7FFAF93FBBD0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded(){} // RVA: 0x7FFAF93FBBE0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped(){} // RVA: 0x7FFAF2E0A740
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber(){} // RVA: 0x7FFAF3B95CF0
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition(){} // RVA: 0x7FFAF43D9080
        public void get_LinePosition(){} // RVA: 0x7FFAF4741460
        public void set_LinePosition(){} // RVA: 0x7FFAF4741470
        public void get_LineNumber(){} // RVA: 0x7FFAF4741440
        public void set_LineNumber(){} // RVA: 0x7FFAF4741450
        public void get_ValueLinePosition(){} // RVA: 0x7FFAF43D9080
        public void set_ValueLinePosition(){} // RVA: 0x7FFAF483D640
        public void get_ValueLineNumber(){} // RVA: 0x7FFAF3B95CF0
        public void set_ValueLineNumber(){} // RVA: 0x7FFAF2F25080
        public void get_DefaultValueExpanded(){} // RVA: 0x7FFAF93FBC40
        public void set_DefaultValueExpanded(){} // RVA: 0x7FFAF2E2B380
        public void get_TokenizedType(){} // RVA: 0x7FFAF4692A10
        public void set_TokenizedType(){} // RVA: 0x7FFAF93FBCA0
        public void get_Reserved(){} // RVA: 0x7FFAF4593800
        public void set_Reserved(){} // RVA: 0x7FFAF4596D80
        public void get_DefaultValueChecked(){} // RVA: 0x7FFAF33589C0
        public void get_SchemaAttribute(){} // RVA: 0x7FFAF2F12D00
        public void set_SchemaAttribute(){} // RVA: 0x7FFAF2F14450
        public void CheckXmlSpace(){} // RVA: 0x7FFAF93FBD10
        public void Clone(){} // RVA: 0x7FFAF93FC0A0
        public void .cctor(){} // RVA: 0x7FFAF93FC100
    }

    public class SchemaBuilder
    {
        // ── Methods ──
        public void ProcessElement(){}
        public void ProcessAttribute(){} // RVA: 0x7FFAF2ADF9F0
        public void IsContentParsed(){} // RVA: 0x7FFAF2ABDBE0
        public void ProcessMarkup(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessCData(){} // RVA: 0x7FFAF2AD4B10
        public void StartChildren(){} // RVA: 0x7FFAF2AD4A50
        public void EndChildren(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SchemaCollectionCompiler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93FC1B0
        public void Execute(){} // RVA: 0x7FFAF93FC310
        public void Prepare(){} // RVA: 0x7FFAF93FC3C0
        public void Cleanup(){} // RVA: 0x7FFAF93FD570 | overloaded x2
        public void Compile(){} // RVA: 0x7FFAF93FE0D0
        public void Output(){} // RVA: 0x7FFAF93FFDD0
        public void CleanupAttribute(){} // RVA: 0x7FFAF9400CC0
        public void CleanupAttributeGroup(){} // RVA: 0x7FFAF9400DA0
        public void CleanupComplexType(){} // RVA: 0x7FFAF9400E30
        public void CleanupSimpleType(){} // RVA: 0x7FFAF9401380
        public void CleanupElement(){} // RVA: 0x7FFAF94013F0
        public void CleanupAttributes(){} // RVA: 0x7FFAF94016E0
        public void CleanupGroup(){} // RVA: 0x7FFAF94017D0
        public void CleanupParticle(){} // RVA: 0x7FFAF9401850
        public void CompileSubstitutionGroup(){} // RVA: 0x7FFAF9401A70
        public void CheckSubstitutionGroup(){} // RVA: 0x7FFAF9402080
        public void CompileGroup(){} // RVA: 0x7FFAF94022D0
        public void CompileSimpleType(){} // RVA: 0x7FFAF9402410
        public void CompileBaseMemberTypes(){} // RVA: 0x7FFAF9403040
        public void CheckUnionType(){} // RVA: 0x7FFAF9403500
        public void CompileComplexType(){} // RVA: 0x7FFAF9403650
        public void CompileSimpleContentExtension(){} // RVA: 0x7FFAF94044C0
        public void CompileSimpleContentRestriction(){} // RVA: 0x7FFAF9404800
        public void CompileComplexContentExtension(){} // RVA: 0x7FFAF9404CD0
        public void CompileComplexContentRestriction(){} // RVA: 0x7FFAF9405300
        public void CheckParticleDerivation(){} // RVA: 0x7FFAF94057C0
        public void CompileContentTypeParticle(){} // RVA: 0x7FFAF94058D0
        public void CannonicalizeParticle(){} // RVA: 0x7FFAF9405AF0
        public void CannonicalizeElement(){} // RVA: 0x7FFAF9405E50
        public void CannonicalizeGroupRef(){} // RVA: 0x7FFAF9406020
        public void CannonicalizeAll(){} // RVA: 0x7FFAF9406830
        public void CannonicalizeChoice(){} // RVA: 0x7FFAF9406F60
        public void CannonicalizeSequence(){} // RVA: 0x7FFAF94077D0
        public void IsValidRestriction(){} // RVA: 0x7FFAF9407FB0
        public void IsElementFromElement(){} // RVA: 0x7FFAF9408AE0
        public void IsElementFromAny(){} // RVA: 0x7FFAF9408CE0
        public void IsAnyFromAny(){} // RVA: 0x7FFAF9408D70
        public void IsGroupBaseFromAny(){} // RVA: 0x7FFAF9408DD0
        public void IsElementFromGroupBase(){} // RVA: 0x7FFAF9409140
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7FFAF94095B0
        public void IsSequenceFromAll(){} // RVA: 0x7FFAF94098F0
        public void IsSequenceFromChoice(){} // RVA: 0x7FFAF9409CE0
        public void CalculateSequenceRange(){} // RVA: 0x7FFAF940A050
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7FFAF940A7F0 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x7FFAF940A940
        public void IsParticleEmptiable(){} // RVA: 0x7FFAF940AA60
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7FFAF940AB70
        public void PushComplexType(){} // RVA: 0x7FFAF940B890
        public void GetSchemaContentType(){} // RVA: 0x7FFAF940B8C0
        public void CompileAttributeGroup(){} // RVA: 0x7FFAF940B940
        public void CompileLocalAttributes(){} // RVA: 0x7FFAF940C090
        public void CompileAnyAttributeUnion(){} // RVA: 0x7FFAF940D230
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7FFAF940D2E0
        public void CompileAttribute(){} // RVA: 0x7FFAF940D390
        public void CompileIdentityConstraint(){} // RVA: 0x7FFAF940DF10
        public void CompileElement(){} // RVA: 0x7FFAF940E640
        public void CompileComplexContent(){} // RVA: 0x7FFAF940F590
        public void BuildParticleContentModel(){} // RVA: 0x7FFAF9410390
        public void CompileParticleElements(){} // RVA: 0x7FFAF9410C50
        public void CompileCompexTypeElements(){} // RVA: 0x7FFAF9410F70
        public void GetSimpleType(){} // RVA: 0x7FFAF9411050
        public void GetComplexType(){} // RVA: 0x7FFAF94111D0
        public void GetAnySchemaType(){} // RVA: 0x7FFAF94112A0
    }

    public class SchemaCollectionPreprocessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9411480
        public void Execute(){} // RVA: 0x7FFAF9411490
        public void Cleanup(){} // RVA: 0x7FFAF94117F0
        public void set_XmlResolver(){} // RVA: 0x7FFAF2F14450
        public void LoadExternals(){} // RVA: 0x7FFAF9411DA0
        public void BuildRefNamespaces(){} // RVA: 0x7FFAF9412A30
        public void Preprocess(){} // RVA: 0x7FFAF9412CE0
        public void PreprocessRedefine(){} // RVA: 0x7FFAF9414C30
        public void CountGroupSelfReference(){} // RVA: 0x7FFAF9415EA0
        public void CheckRefinedGroup(){} // RVA: 0x7FFAF9416240
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7FFAF94162E0
        public void CheckRefinedSimpleType(){} // RVA: 0x7FFAF9416470
        public void CheckRefinedComplexType(){} // RVA: 0x7FFAF94165C0
        public void PreprocessAttribute(){} // RVA: 0x7FFAF9416A60
        public void PreprocessLocalAttribute(){} // RVA: 0x7FFAF9416C40
        public void PreprocessAttributeContent(){} // RVA: 0x7FFAF9416F00
        public void PreprocessAttributeGroup(){} // RVA: 0x7FFAF9417240
        public void PreprocessElement(){} // RVA: 0x7FFAF94173B0
        public void PreprocessLocalElement(){} // RVA: 0x7FFAF94176A0
        public void PreprocessElementContent(){} // RVA: 0x7FFAF9417BD0
        public void PreprocessIdentityConstraint(){} // RVA: 0x7FFAF94180F0
        public void PreprocessSimpleType(){} // RVA: 0x7FFAF9418610
        public void PreprocessComplexType(){} // RVA: 0x7FFAF9418FD0
        public void PreprocessGroup(){} // RVA: 0x7FFAF9419D80
        public void PreprocessNotation(){} // RVA: 0x7FFAF9419FC0
        public void PreprocessParticle(){} // RVA: 0x7FFAF941A200
        public void PreprocessAttributes(){} // RVA: 0x7FFAF941AF70
        public void ValidateIdAttribute(){} // RVA: 0x7FFAF941B410
        public void ValidateNameAttribute(){} // RVA: 0x7FFAF941B640
        public void ValidateQNameAttribute(){} // RVA: 0x7FFAF941B970
        public void SetParent(){} // RVA: 0x7FFAF93FB880
        public void PreprocessAnnotation(){} // RVA: 0x7FFAF941BA90
        public void ResolveSchemaLocationUri(){} // RVA: 0x7FFAF941BC20
        public void GetSchemaEntity(){} // RVA: 0x7FFAF941BC70
    }

    public class SchemaDeclBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF941BF10 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_Prefix(){} // RVA: 0x7FFAF941BFC0
        public void set_Prefix(){} // RVA: 0x7FFAF2DF3E80
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFAF2E7B9D0
        public void set_IsDeclaredInExternal(){} // RVA: 0x7FFAF2E7B9E0
        public void get_Presence(){} // RVA: 0x7FFAF379F5B0
        public void set_Presence(){} // RVA: 0x7FFAF4191F00
        public void get_MaxLength(){} // RVA: 0x7FFAF2E08730
        public void set_MaxLength(){} // RVA: 0x7FFAF424D760
        public void get_MinLength(){} // RVA: 0x7FFAF2E2E0E0
        public void set_MinLength(){} // RVA: 0x7FFAF2F74D50
        public void get_SchemaType(){} // RVA: 0x7FFAF2DBB130
        public void set_SchemaType(){} // RVA: 0x7FFAF2D8EE90
        public void get_Datatype(){} // RVA: 0x7FFAF30E74D0
        public void set_Datatype(){} // RVA: 0x7FFAF2DBB890
        public void AddValue(){} // RVA: 0x7FFAF941C020
        public void get_Values(){} // RVA: 0x7FFAF2E55500
        public void set_Values(){} // RVA: 0x7FFAF2E55510
        public void get_DefaultValueRaw(){} // RVA: 0x7FFAF941C160
        public void set_DefaultValueRaw(){} // RVA: 0x7FFAF2F4B830
        public void get_DefaultValueTyped(){} // RVA: 0x7FFAF2E0A740
        public void set_DefaultValueTyped(){} // RVA: 0x7FFAF2DB5200
        public void CheckEnumeration(){} // RVA: 0x7FFAF941C1C0
        public void CheckValue(){} // RVA: 0x7FFAF941C280
    }

    public class SchemaElementDecl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF941C6B0 | overloaded x3
        public void CreateAnyTypeElementDecl(){} // RVA: 0x7FFAF941C830
        public void System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes(){} // RVA: 0x7FFAF855EFD0
        public void System.Xml.IDtdAttributeListInfo.LookupAttribute(){} // RVA: 0x7FFAF941C950
        public void System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes(){} // RVA: 0x7FFAF2E08D50
        public void get_IsIdDeclared(){} // RVA: 0x7FFAF2E09320
        public void set_IsIdDeclared(){} // RVA: 0x7FFAF2E09330
        public void get_HasNonCDataAttribute(){} // RVA: 0x7FFAF855EFD0
        public void set_HasNonCDataAttribute(){} // RVA: 0x7FFAF855EFE0
        public void Clone(){} // RVA: 0x7FFAF941CA10
        public void get_IsAbstract(){} // RVA: 0x7FFAF855EFF0
        public void set_IsAbstract(){} // RVA: 0x7FFAF855F000
        public void get_IsNillable(){} // RVA: 0x7FFAF8E0AD00
        public void set_IsNillable(){} // RVA: 0x7FFAF941CA70
        public void get_Block(){} // RVA: 0x7FFAF315FD40
        public void set_Block(){} // RVA: 0x7FFAF39B2F80
        public void get_IsNotationDeclared(){} // RVA: 0x7FFAF3C0F200
        public void set_IsNotationDeclared(){} // RVA: 0x7FFAF8E28F10
        public void get_HasDefaultAttribute(){} // RVA: 0x7FFAF3DF8BF0
        public void get_HasRequiredAttribute(){} // RVA: 0x7FFAF3BD0170
        public void get_ContentValidator(){} // RVA: 0x7FFAF2F12D00
        public void set_ContentValidator(){} // RVA: 0x7FFAF2F14450
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2DCC010
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2F13060
        public void get_Constraints(){} // RVA: 0x7FFAF34CC8C0
        public void set_Constraints(){} // RVA: 0x7FFAF345A650
        public void get_SchemaElement(){} // RVA: 0x7FFAF34B85E0
        public void set_SchemaElement(){} // RVA: 0x7FFAF345A5F0
        public void AddAttDef(){} // RVA: 0x7FFAF941CA80
        public void GetAttDef(){} // RVA: 0x7FFAF941CC30
        public void get_DefaultAttDefs(){} // RVA: 0x7FFAF2E08D50
        public void get_AttDefs(){} // RVA: 0x7FFAF2E2B370
        public void get_ProhibitedAttributes(){} // RVA: 0x7FFAF2F77C50
        public void CheckAttributes(){} // RVA: 0x7FFAF941CCB0
        public void .cctor(){} // RVA: 0x7FFAF941D030
    }

    public class SchemaEntity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF941D0E0
        public void System.Xml.IDtdEntityInfo.get_Name(){} // RVA: 0x7FFAF35DECF0
        public void System.Xml.IDtdEntityInfo.get_IsExternal(){} // RVA: 0x7FFAF310EEC0
        public void System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal(){} // RVA: 0x7FFAF3FC4560
        public void System.Xml.IDtdEntityInfo.get_IsUnparsedEntity(){} // RVA: 0x7FFAF941D200
        public void System.Xml.IDtdEntityInfo.get_IsParameterEntity(){} // RVA: 0x7FFAF2E48C00
        public void System.Xml.IDtdEntityInfo.get_BaseUriString(){} // RVA: 0x7FFAF941D240
        public void System.Xml.IDtdEntityInfo.get_DeclaredUriString(){} // RVA: 0x7FFAF941D2A0
        public void System.Xml.IDtdEntityInfo.get_SystemId(){} // RVA: 0x7FFAF2D907C0
        public void System.Xml.IDtdEntityInfo.get_PublicId(){} // RVA: 0x7FFAF2DBB0C0
        public void System.Xml.IDtdEntityInfo.get_Text(){} // RVA: 0x7FFAF2DBB130
        public void System.Xml.IDtdEntityInfo.get_LineNumber(){} // RVA: 0x7FFAF3A8C9F0
        public void System.Xml.IDtdEntityInfo.get_LinePosition(){} // RVA: 0x7FFAF3341AF0
        public void IsPredefinedEntity(){} // RVA: 0x7FFAF941D300
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Url(){} // RVA: 0x7FFAF2D907C0
        public void set_Url(){} // RVA: 0x7FFAF941D4B0
        public void get_Pubid(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Pubid(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IsExternal(){} // RVA: 0x7FFAF310EEC0
        public void set_IsExternal(){} // RVA: 0x7FFAF310EEB0
        public void get_DeclaredInExternal(){} // RVA: 0x7FFAF3FC4560
        public void set_DeclaredInExternal(){} // RVA: 0x7FFAF45A8C50
        public void get_NData(){} // RVA: 0x7FFAF30E74D0
        public void set_NData(){} // RVA: 0x7FFAF2DBB890
        public void get_Text(){} // RVA: 0x7FFAF2DBB130
        public void set_Text(){} // RVA: 0x7FFAF941D510
        public void get_Line(){} // RVA: 0x7FFAF3A8C9F0
        public void set_Line(){} // RVA: 0x7FFAF3A8D6E0
        public void get_Pos(){} // RVA: 0x7FFAF3341AF0
        public void set_Pos(){} // RVA: 0x7FFAF47695F0
        public void get_BaseURI(){} // RVA: 0x7FFAF941D570
        public void set_BaseURI(){} // RVA: 0x7FFAF2E08740
        public void get_ParsingInProgress(){} // RVA: 0x7FFAF310F560
        public void set_ParsingInProgress(){} // RVA: 0x7FFAF310F1B0
        public void get_DeclaredURI(){} // RVA: 0x7FFAF941D5D0
        public void set_DeclaredURI(){} // RVA: 0x7FFAF2EE54D0
    }

    public class SchemaInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF941D630
        public void get_DocTypeName(){} // RVA: 0x7FFAF30E74D0
        public void set_DocTypeName(){} // RVA: 0x7FFAF2DBB890
        public void set_InternalDtdSubset(){} // RVA: 0x7FFAF2F4B830
        public void get_ElementDecls(){} // RVA: 0x7FFAF2DA8380
        public void get_UndeclaredElementDecls(){} // RVA: 0x7FFAF2D907C0
        public void get_GeneralEntities(){} // RVA: 0x7FFAF941DA10
        public void get_ParameterEntities(){} // RVA: 0x7FFAF941DAD0
        public void get_SchemaType(){} // RVA: 0x7FFAF30554D0
        public void set_SchemaType(){} // RVA: 0x7FFAF349ACA0
        public void get_TargetNamespaces(){} // RVA: 0x7FFAF2E08730
        public void get_ElementDeclsByType(){} // RVA: 0x7FFAF2E2B370
        public void get_AttributeDecls(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Notations(){} // RVA: 0x7FFAF941DB90
        public void get_ErrorCount(){} // RVA: 0x7FFAF349AB90
        public void set_ErrorCount(){} // RVA: 0x7FFAF349AAE0
        public void GetElementDecl(){} // RVA: 0x7FFAF941DC50
        public void GetTypeDecl(){} // RVA: 0x7FFAF941DCD0
        public void GetElement(){} // RVA: 0x7FFAF941DD50
        public void HasSchema(){} // RVA: 0x7FFAF941DD80
        public void Contains(){} // RVA: 0x7FFAF941DE00
        public void GetAttributeXdr(){} // RVA: 0x7FFAF941DE80
        public void GetAttributeXsd(){} // RVA: 0x7FFAF941E320 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF941E470
        public void Finish(){} // RVA: 0x7FFAF941F280
        public void System.Xml.IDtdInfo.get_HasDefaultAttributes(){} // RVA: 0x7FFAF310EEC0
        public void System.Xml.IDtdInfo.get_HasNonCDataAttributes(){} // RVA: 0x7FFAF2E48C00
        public void System.Xml.IDtdInfo.LookupAttributeList(){} // RVA: 0x7FFAF941F480
        public void System.Xml.IDtdInfo.LookupEntity(){} // RVA: 0x7FFAF941F560
        public void System.Xml.IDtdInfo.get_Name(){} // RVA: 0x7FFAF30E74D0
        public void System.Xml.IDtdInfo.get_InternalDtdSubset(){} // RVA: 0x7FFAF2F476A0
    }

    public class SchemaNames
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF941F630
        public void CreateTokenToQNameTable(){} // RVA: 0x7FFAF9423290
        public void SchemaTypeFromRoot(){} // RVA: 0x7FFAF9425B50
        public void IsXSDRoot(){} // RVA: 0x7FFAF9425CC0
        public void IsXDRRoot(){} // RVA: 0x7FFAF9425D70
    }

    public class SchemaNamespaceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2EE54D0
        public void LookupNamespace(){} // RVA: 0x7FFAF9425E20
        public void LookupPrefix(){} // RVA: 0x7FFAF9425FC0
    }

    public class SchemaNotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_SystemLiteral(){} // RVA: 0x7FFAF2D907C0
        public void set_SystemLiteral(){} // RVA: 0x7FFAF2DF3E80
        public void get_Pubid(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Pubid(){} // RVA: 0x7FFAF2DBB0D0
    }

    public class SelectorActiveAxis
    {
        // ── Methods ──
        public void get_lastDepth(){} // RVA: 0x7FFAF9586C20
        public void .ctor(){} // RVA: 0x7FFAF9586CD0
        public void EndElement(){} // RVA: 0x7FFAF9586DF0
        public void PushKS(){} // RVA: 0x7FFAF9586FE0
        public void PopKS(){} // RVA: 0x7FFAF95875D0
    }

    public class SequenceNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFAF958AD80
        public void get_IsNullable(){} // RVA: 0x7FFAF958B7A0
        public void ExpandTree(){} // RVA: 0x7FFAF958B990
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StarNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFAF958BF20
        public void get_IsNullable(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StateUnion
    {
    }

    public class StringFacetsChecker
    {
        // ── Methods ──
        public void get_LanguagePattern(){} // RVA: 0x7FFAF95B8370
        public void CheckValueFacets(){} // RVA: 0x7FFAF95B8520 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x7FFAF95B8830 | overloaded x2
        public void CheckBuiltInFacets(){} // RVA: 0x7FFAF95B8AA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SymbolsDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9588EC0
        public void get_Count(){} // RVA: 0x7FFAF9589010
        public void get_IsUpaEnforced(){} // RVA: 0x7FFAF2F56500
        public void set_IsUpaEnforced(){} // RVA: 0x7FFAF2F578C0
        public void AddName(){} // RVA: 0x7FFAF9589020
        public void AddNamespaceList(){} // RVA: 0x7FFAF9589160
        public void AddWildcard(){} // RVA: 0x7FFAF9589450
        public void GetNamespaceListSymbols(){} // RVA: 0x7FFAF9589610
        public void get_Item(){} // RVA: 0x7FFAF9589CB0
        public void Exists(){} // RVA: 0x7FFAF9589DB0
        public void GetParticle(){} // RVA: 0x7FFAF9589DF0
        public void NameOf(){} // RVA: 0x7FFAF9589E30
    }

    public class SyntaxTreeNode
    {
        // ── Methods ──
        public void ExpandTree(){} // RVA: 0x7FFAF2ADF090
        public void ConstructPos(){} // RVA: 0x7FFAF2ADF090
        public void get_IsNullable(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsRangeNode(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}