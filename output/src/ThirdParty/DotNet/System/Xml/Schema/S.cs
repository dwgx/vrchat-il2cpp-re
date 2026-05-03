// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 18
// Methods: 325

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class SchemaAttDef : SchemaDeclBase
    {
        public string defExpanded; // 0x60
        public int lineNum; // 0x68
        public int linePos; // 0x6C
        public int valueLineNum; // 0x70
        public int valueLinePos; // 0x74
        public 0x6655B9FC reserved; // 0x78
        public bool defaultValueChecked; // 0x7C
        public System.Xml.Schema.XmlSchemaAttribute schemaAttribute; // 0x80
        public System.Xml.Schema.SchemaAttDef Empty;
        public object field_9; // 0x4D9
        public object field_10; // 0x4DA
        public object field_11; // 0x4DB
        public object field_12; // 0x4DC
        public object field_13; // 0x4DD
        public object field_14; // 0x4DE
        public object field_15; // 0x4DF
        public object field_16; // 0x4E0
        public object field_17; // 0x4E1
        public object field_18; // 0x4E2
        public object field_19; // 0x4E3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8748AE00 | overloaded x3
        public void System.Xml.IDtdAttributeInfo.get_Prefix(){} // RVA: 0x7FFE8748AE10
        public void System.Xml.IDtdAttributeInfo.get_LocalName(){} // RVA: 0x7FFE8189BB90
        public void System.Xml.IDtdAttributeInfo.get_LineNumber(){} // RVA: 0x7FFE82A22EF0
        public void System.Xml.IDtdAttributeInfo.get_LinePosition(){} // RVA: 0x7FFE82A22F10
        public void System.Xml.IDtdAttributeInfo.get_IsNonCDataType(){} // RVA: 0x7FFE8748AE70
        public void System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal(){} // RVA: 0x7FFE811E99D0
        public void System.Xml.IDtdAttributeInfo.get_IsXmlAttribute(){} // RVA: 0x7FFE8748AEA0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded(){} // RVA: 0x7FFE8748AEB0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped(){} // RVA: 0x7FFE81178740
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber(){} // RVA: 0x7FFE81E60180
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition(){} // RVA: 0x7FFE826A9B90
        public void get_LinePosition(){} // RVA: 0x7FFE82A22F10
        public void set_LinePosition(){} // RVA: 0x7FFE82A22F20
        public void get_LineNumber(){} // RVA: 0x7FFE82A22EF0
        public void set_LineNumber(){} // RVA: 0x7FFE82A22F00
        public void get_ValueLinePosition(){} // RVA: 0x7FFE826A9B90
        public void set_ValueLinePosition(){} // RVA: 0x7FFE82B1F9C0
        public void get_ValueLineNumber(){} // RVA: 0x7FFE81E60180
        public void set_ValueLineNumber(){} // RVA: 0x7FFE81293CF0
        public void get_DefaultValueExpanded(){} // RVA: 0x7FFE8748AF10
        public void set_DefaultValueExpanded(){} // RVA: 0x7FFE81199380
        public void get_TokenizedType(){} // RVA: 0x7FFE82976400
        public void set_TokenizedType(){} // RVA: 0x7FFE8748AF70
        public void get_Reserved(){} // RVA: 0x7FFE8286C0A0
        public void set_Reserved(){} // RVA: 0x7FFE82862F10
        public void get_DefaultValueChecked(){} // RVA: 0x7FFE816402F0
        public void get_SchemaAttribute(){} // RVA: 0x7FFE81280C30
        public void set_SchemaAttribute(){} // RVA: 0x7FFE81282380
        public void CheckXmlSpace(){} // RVA: 0x7FFE8748AFE0
        public void Clone(){} // RVA: 0x7FFE8748B370
        public void .cctor(){} // RVA: 0x7FFE8748B3D0
    }

    public class SchemaBuilder : Object
    {
        // ── Methods ──
        public void ProcessElement(){}
        public void ProcessAttribute(){} // RVA: 0x7FFE80E50FC0
        public void IsContentParsed(){} // RVA: 0x7FFE80E2F150
        public void ProcessMarkup(){} // RVA: 0x7FFE80E460A0
        public void ProcessCData(){} // RVA: 0x7FFE80E460A0
        public void StartChildren(){} // RVA: 0x7FFE80E45FE0
        public void EndChildren(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SchemaCollectionCompiler : BaseProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8748B480
        public void Execute(){} // RVA: 0x7FFE8748B5E0
        public void Prepare(){} // RVA: 0x7FFE8748B690
        public void Cleanup(){} // RVA: 0x7FFE8748C840 | overloaded x2
        public void Compile(){} // RVA: 0x7FFE8748D3A0
        public void Output(){} // RVA: 0x7FFE8748F0A0
        public void CleanupAttribute(){} // RVA: 0x7FFE8748FF90
        public void CleanupAttributeGroup(){} // RVA: 0x7FFE87490070
        public void CleanupComplexType(){} // RVA: 0x7FFE87490100
        public void CleanupSimpleType(){} // RVA: 0x7FFE87490650
        public void CleanupElement(){} // RVA: 0x7FFE874906C0
        public void CleanupAttributes(){} // RVA: 0x7FFE874909B0
        public void CleanupGroup(){} // RVA: 0x7FFE87490AA0
        public void CleanupParticle(){} // RVA: 0x7FFE87490B20
        public void CompileSubstitutionGroup(){} // RVA: 0x7FFE87490D40
        public void CheckSubstitutionGroup(){} // RVA: 0x7FFE87491350
        public void CompileGroup(){} // RVA: 0x7FFE874915A0
        public void CompileSimpleType(){} // RVA: 0x7FFE874916E0
        public void CompileBaseMemberTypes(){} // RVA: 0x7FFE87492310
        public void CheckUnionType(){} // RVA: 0x7FFE874927D0
        public void CompileComplexType(){} // RVA: 0x7FFE87492920
        public void CompileSimpleContentExtension(){} // RVA: 0x7FFE87493790
        public void CompileSimpleContentRestriction(){} // RVA: 0x7FFE87493AD0
        public void CompileComplexContentExtension(){} // RVA: 0x7FFE87493FA0
        public void CompileComplexContentRestriction(){} // RVA: 0x7FFE874945D0
        public void CheckParticleDerivation(){} // RVA: 0x7FFE87494A90
        public void CompileContentTypeParticle(){} // RVA: 0x7FFE87494BA0
        public void CannonicalizeParticle(){} // RVA: 0x7FFE87494DC0
        public void CannonicalizeElement(){} // RVA: 0x7FFE87495120
        public void CannonicalizeGroupRef(){} // RVA: 0x7FFE874952F0
        public void CannonicalizeAll(){} // RVA: 0x7FFE87495B00
        public void CannonicalizeChoice(){} // RVA: 0x7FFE87496230
        public void CannonicalizeSequence(){} // RVA: 0x7FFE87496AA0
        public void IsValidRestriction(){} // RVA: 0x7FFE87497280
        public void IsElementFromElement(){} // RVA: 0x7FFE87497DB0
        public void IsElementFromAny(){} // RVA: 0x7FFE87497FB0
        public void IsAnyFromAny(){} // RVA: 0x7FFE87498040
        public void IsGroupBaseFromAny(){} // RVA: 0x7FFE874980A0
        public void IsElementFromGroupBase(){} // RVA: 0x7FFE87498410
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7FFE87498880
        public void IsSequenceFromAll(){} // RVA: 0x7FFE87498BC0
        public void IsSequenceFromChoice(){} // RVA: 0x7FFE87498FB0
        public void CalculateSequenceRange(){} // RVA: 0x7FFE87499320
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7FFE87499AC0 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x7FFE87499C10
        public void IsParticleEmptiable(){} // RVA: 0x7FFE87499D30
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7FFE87499E40
        public void PushComplexType(){} // RVA: 0x7FFE8749AB60
        public void GetSchemaContentType(){} // RVA: 0x7FFE8749AB90
        public void CompileAttributeGroup(){} // RVA: 0x7FFE8749AC10
        public void CompileLocalAttributes(){} // RVA: 0x7FFE8749B360
        public void CompileAnyAttributeUnion(){} // RVA: 0x7FFE8749C500
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7FFE8749C5B0
        public void CompileAttribute(){} // RVA: 0x7FFE8749C660
        public void CompileIdentityConstraint(){} // RVA: 0x7FFE8749D1E0
        public void CompileElement(){} // RVA: 0x7FFE8749D910
        public void CompileComplexContent(){} // RVA: 0x7FFE8749E860
        public void BuildParticleContentModel(){} // RVA: 0x7FFE8749F660
        public void CompileParticleElements(){} // RVA: 0x7FFE8749FF20
        public void CompileCompexTypeElements(){} // RVA: 0x7FFE874A0240
        public void GetSimpleType(){} // RVA: 0x7FFE874A0320
        public void GetComplexType(){} // RVA: 0x7FFE874A04A0
        public void GetAnySchemaType(){} // RVA: 0x7FFE874A0570
    }

    public class SchemaCollectionPreprocessor : BaseProcessor
    {
        public System.Xml.Schema.XmlSchema schema; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874A0750
        public void Execute(){} // RVA: 0x7FFE874A0760
        public void Cleanup(){} // RVA: 0x7FFE874A0AC0
        public void set_XmlResolver(){} // RVA: 0x7FFE81282380
        public void LoadExternals(){} // RVA: 0x7FFE874A1070
        public void BuildRefNamespaces(){} // RVA: 0x7FFE874A1D00
        public void Preprocess(){} // RVA: 0x7FFE874A1FB0
        public void PreprocessRedefine(){} // RVA: 0x7FFE874A3F00
        public void CountGroupSelfReference(){} // RVA: 0x7FFE874A5170
        public void CheckRefinedGroup(){} // RVA: 0x7FFE874A5510
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7FFE874A55B0
        public void CheckRefinedSimpleType(){} // RVA: 0x7FFE874A5740
        public void CheckRefinedComplexType(){} // RVA: 0x7FFE874A5890
        public void PreprocessAttribute(){} // RVA: 0x7FFE874A5D30
        public void PreprocessLocalAttribute(){} // RVA: 0x7FFE874A5F10
        public void PreprocessAttributeContent(){} // RVA: 0x7FFE874A61D0
        public void PreprocessAttributeGroup(){} // RVA: 0x7FFE874A6510
        public void PreprocessElement(){} // RVA: 0x7FFE874A6680
        public void PreprocessLocalElement(){} // RVA: 0x7FFE874A6970
        public void PreprocessElementContent(){} // RVA: 0x7FFE874A6EA0
        public void PreprocessIdentityConstraint(){} // RVA: 0x7FFE874A73C0
        public void PreprocessSimpleType(){} // RVA: 0x7FFE874A78E0
        public void PreprocessComplexType(){} // RVA: 0x7FFE874A82A0
        public void PreprocessGroup(){} // RVA: 0x7FFE874A9050
        public void PreprocessNotation(){} // RVA: 0x7FFE874A9290
        public void PreprocessParticle(){} // RVA: 0x7FFE874A94D0
        public void PreprocessAttributes(){} // RVA: 0x7FFE874AA240
        public void ValidateIdAttribute(){} // RVA: 0x7FFE874AA6E0
        public void ValidateNameAttribute(){} // RVA: 0x7FFE874AA910
        public void ValidateQNameAttribute(){} // RVA: 0x7FFE874AAC40
        public void SetParent(){} // RVA: 0x7FFE8748AB50
        public void PreprocessAnnotation(){} // RVA: 0x7FFE874AAD60
        public void ResolveSchemaLocationUri(){} // RVA: 0x7FFE874AAEF0
        public void GetSchemaEntity(){} // RVA: 0x7FFE874AAF40
    }

    public class SchemaDeclBase : Object
    {
        public System.Xml.XmlQualifiedName name; // 0x10
        public string prefix; // 0x18
        public bool isDeclaredInExternal; // 0x20
        public dFixup.Id presence; // 0x24
        public System.Xml.Schema.XmlSchemaType schemaType; // 0x28
        public System.Xml.Schema.XmlSchemaDatatype datatype; // 0x30
        public string defaultValueRaw; // 0x38
        public object defaultValueTyped; // 0x40
        public long maxLength; // 0x48
        public long minLength; // 0x50
        public System.Collections.Generic.List`1<string> values; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874AB1E0 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Prefix(){} // RVA: 0x7FFE874AB290
        public void set_Prefix(){} // RVA: 0x7FFE81161E80
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFE811E99D0
        public void set_IsDeclaredInExternal(){} // RVA: 0x7FFE811E99E0
        public void get_Presence(){} // RVA: 0x7FFE81A56130
        public void set_Presence(){} // RVA: 0x7FFE82447980
        public void get_MaxLength(){} // RVA: 0x7FFE81176730
        public void set_MaxLength(){} // RVA: 0x7FFE82502600
        public void get_MinLength(){} // RVA: 0x7FFE8119C0E0
        public void set_MinLength(){} // RVA: 0x7FFE82506C00
        public void get_SchemaType(){} // RVA: 0x7FFE81129130
        public void set_SchemaType(){} // RVA: 0x7FFE810FCE90
        public void get_Datatype(){} // RVA: 0x7FFE8144E200
        public void set_Datatype(){} // RVA: 0x7FFE81129890
        public void AddValue(){} // RVA: 0x7FFE874AB2F0
        public void get_Values(){} // RVA: 0x7FFE811C3500
        public void set_Values(){} // RVA: 0x7FFE811C3510
        public void get_DefaultValueRaw(){} // RVA: 0x7FFE874AB430
        public void set_DefaultValueRaw(){} // RVA: 0x7FFE81437330
        public void get_DefaultValueTyped(){} // RVA: 0x7FFE81178740
        public void set_DefaultValueTyped(){} // RVA: 0x7FFE81123200
        public void CheckEnumeration(){} // RVA: 0x7FFE874AB490
        public void CheckValue(){} // RVA: 0x7FFE874AB550
    }

    public class SchemaElementDecl : SchemaDeclBase
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> attdefs; // 0x60
        public System.Collections.Generic.List`1<System.Xml.IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
        public bool isIdDeclared; // 0x70
        public bool hasNonCDataAttribute; // 0x71
        public bool isAbstract; // 0x72
        public bool isNillable; // 0x73
        public bool hasRequiredAttribute; // 0x74
        public bool isNotationDeclared; // 0x75
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> prohibitedAttributes; // 0x78
        public System.Xml.Schema.ContentValidator contentValidator; // 0x80
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x88
        public 0x6655CEF4 block; // 0x90
        public System.Xml.Schema.CompiledIdentityConstraint[] constraints; // 0x98
        public System.Xml.Schema.XmlSchemaElement schemaElement; // 0xA0
        public System.Xml.Schema.SchemaElementDecl Empty;
        public object field_15; // 0x4F9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874AB980 | overloaded x3
        public void CreateAnyTypeElementDecl(){} // RVA: 0x7FFE874ABB00
        public void System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes(){} // RVA: 0x7FFE865EFE00
        public void System.Xml.IDtdAttributeListInfo.LookupAttribute(){} // RVA: 0x7FFE874ABC20
        public void System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes(){} // RVA: 0x7FFE81176D50
        public void get_IsIdDeclared(){} // RVA: 0x7FFE81177320
        public void set_IsIdDeclared(){} // RVA: 0x7FFE81177330
        public void get_HasNonCDataAttribute(){} // RVA: 0x7FFE865EFE00
        public void set_HasNonCDataAttribute(){} // RVA: 0x7FFE865EFE10
        public void Clone(){} // RVA: 0x7FFE874ABCE0
        public void get_IsAbstract(){} // RVA: 0x7FFE865EFE20
        public void set_IsAbstract(){} // RVA: 0x7FFE865EFE30
        public void get_IsNillable(){} // RVA: 0x7FFE86E9B720
        public void set_IsNillable(){} // RVA: 0x7FFE874ABD40
        public void get_Block(){} // RVA: 0x7FFE814AA220
        public void set_Block(){} // RVA: 0x7FFE81C8DB30
        public void get_IsNotationDeclared(){} // RVA: 0x7FFE81EB9540
        public void set_IsNotationDeclared(){} // RVA: 0x7FFE86EB9930
        public void get_HasDefaultAttribute(){} // RVA: 0x7FFE820C2B70
        public void get_HasRequiredAttribute(){} // RVA: 0x7FFE81E8DCD0
        public void get_ContentValidator(){} // RVA: 0x7FFE81280C30
        public void set_ContentValidator(){} // RVA: 0x7FFE81282380
        public void get_AnyAttribute(){} // RVA: 0x7FFE8113A010
        public void set_AnyAttribute(){} // RVA: 0x7FFE81280F90
        public void get_Constraints(){} // RVA: 0x7FFE817AE360
        public void set_Constraints(){} // RVA: 0x7FFE8171B470
        public void get_SchemaElement(){} // RVA: 0x7FFE8179C860
        public void set_SchemaElement(){} // RVA: 0x7FFE8171B4D0
        public void AddAttDef(){} // RVA: 0x7FFE874ABD50
        public void GetAttDef(){} // RVA: 0x7FFE874ABF00
        public void get_DefaultAttDefs(){} // RVA: 0x7FFE81176D50
        public void get_AttDefs(){} // RVA: 0x7FFE81199370
        public void get_ProhibitedAttributes(){} // RVA: 0x7FFE81463AE0
        public void CheckAttributes(){} // RVA: 0x7FFE874ABF80
        public void .cctor(){} // RVA: 0x7FFE874AC300
    }

    public class SchemaEntity : Object
    {
        public System.Xml.XmlQualifiedName qname; // 0x10
        public string url; // 0x18
        public string pubid; // 0x20
        public string text; // 0x28
        public System.Xml.XmlQualifiedName ndata; // 0x30
        public int lineNumber; // 0x38
        public int linePosition; // 0x3C
        public bool isParameter; // 0x40
        public bool isExternal; // 0x41
        public bool parsingInProgress; // 0x42
        public bool isDeclaredInExternal; // 0x43
        public string baseURI; // 0x48
        public string declaredURI; // 0x50
        public object field_13; // 0x509
        public object field_14; // 0x50A
        public object field_15; // 0x50B
        public object field_16; // 0x50C
        public object field_17; // 0x50D
        public object field_18; // 0x50E
        public object field_19; // 0x50F
        public object field_20; // 0x510
        public object field_21; // 0x511
        public object field_22; // 0x512
        public object field_23; // 0x513

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874AC3B0
        public void System.Xml.IDtdEntityInfo.get_Name(){} // RVA: 0x7FFE8189BB90
        public void System.Xml.IDtdEntityInfo.get_IsExternal(){} // RVA: 0x7FFE814645D0
        public void System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal(){} // RVA: 0x7FFE822BB340
        public void System.Xml.IDtdEntityInfo.get_IsUnparsedEntity(){} // RVA: 0x7FFE874AC4D0
        public void System.Xml.IDtdEntityInfo.get_IsParameterEntity(){} // RVA: 0x7FFE811B6C00
        public void System.Xml.IDtdEntityInfo.get_BaseUriString(){} // RVA: 0x7FFE874AC510
        public void System.Xml.IDtdEntityInfo.get_DeclaredUriString(){} // RVA: 0x7FFE874AC570
        public void System.Xml.IDtdEntityInfo.get_SystemId(){} // RVA: 0x7FFE810FE7C0
        public void System.Xml.IDtdEntityInfo.get_PublicId(){} // RVA: 0x7FFE811290C0
        public void System.Xml.IDtdEntityInfo.get_Text(){} // RVA: 0x7FFE81129130
        public void System.Xml.IDtdEntityInfo.get_LineNumber(){} // RVA: 0x7FFE81D46090
        public void System.Xml.IDtdEntityInfo.get_LinePosition(){} // RVA: 0x7FFE816311C0
        public void IsPredefinedEntity(){} // RVA: 0x7FFE874AC5D0
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Url(){} // RVA: 0x7FFE810FE7C0
        public void set_Url(){} // RVA: 0x7FFE874AC780
        public void get_Pubid(){} // RVA: 0x7FFE811290C0
        public void set_Pubid(){} // RVA: 0x7FFE811290D0
        public void get_IsExternal(){} // RVA: 0x7FFE814645D0
        public void set_IsExternal(){} // RVA: 0x7FFE814641E0
        public void get_DeclaredInExternal(){} // RVA: 0x7FFE822BB340
        public void set_DeclaredInExternal(){} // RVA: 0x7FFE82876450
        public void get_NData(){} // RVA: 0x7FFE8144E200
        public void set_NData(){} // RVA: 0x7FFE81129890
        public void get_Text(){} // RVA: 0x7FFE81129130
        public void set_Text(){} // RVA: 0x7FFE874AC7E0
        public void get_Line(){} // RVA: 0x7FFE81D46090
        public void set_Line(){} // RVA: 0x7FFE81D46A00
        public void get_Pos(){} // RVA: 0x7FFE816311C0
        public void set_Pos(){} // RVA: 0x7FFE82A4B070
        public void get_BaseURI(){} // RVA: 0x7FFE874AC840
        public void set_BaseURI(){} // RVA: 0x7FFE81176740
        public void get_ParsingInProgress(){} // RVA: 0x7FFE81463AF0
        public void set_ParsingInProgress(){} // RVA: 0x7FFE81463C10
        public void get_DeclaredURI(){} // RVA: 0x7FFE874AC8A0
        public void set_DeclaredURI(){} // RVA: 0x7FFE812534D0
    }

    public class SchemaInfo : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> elementDecls; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> undeclaredElementDecls; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> generalEntities; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> parameterEntities; // 0x28
        public System.Xml.XmlQualifiedName docTypeName; // 0x30
        public string internalDtdSubset; // 0x38
        public bool hasNonCDataAttributes; // 0x40
        public bool hasDefaultAttributes; // 0x41
        public System.Collections.Generic.Dictionary`2<string,bool> targetNamespaces; // 0x48
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> attributeDecls; // 0x50
        public int errorCount; // 0x58
        public 0x6655BFD4 schemaType; // 0x5C
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> elementDeclsByType; // 0x60
        public System.Collections.Generic.Dictionary`2<string,System.Xml.Schema.SchemaNotation> notations; // 0x68
        public object field_14; // 0x521
        public object field_15; // 0x522

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874AC900
        public void get_DocTypeName(){} // RVA: 0x7FFE8144E200
        public void set_DocTypeName(){} // RVA: 0x7FFE81129890
        public void set_InternalDtdSubset(){} // RVA: 0x7FFE81437330
        public void get_ElementDecls(){} // RVA: 0x7FFE81116380
        public void get_UndeclaredElementDecls(){} // RVA: 0x7FFE810FE7C0
        public void get_GeneralEntities(){} // RVA: 0x7FFE874ACCE0
        public void get_ParameterEntities(){} // RVA: 0x7FFE874ACDA0
        public void get_SchemaType(){} // RVA: 0x7FFE813A7A20
        public void set_SchemaType(){} // RVA: 0x7FFE8175ACA0
        public void get_TargetNamespaces(){} // RVA: 0x7FFE81176730
        public void get_ElementDeclsByType(){} // RVA: 0x7FFE81199370
        public void get_AttributeDecls(){} // RVA: 0x7FFE8119C0E0
        public void get_Notations(){} // RVA: 0x7FFE874ACE60
        public void get_ErrorCount(){} // RVA: 0x7FFE8175AC90
        public void set_ErrorCount(){} // RVA: 0x7FFE8175AE70
        public void GetElementDecl(){} // RVA: 0x7FFE874ACF20
        public void GetTypeDecl(){} // RVA: 0x7FFE874ACFA0
        public void GetElement(){} // RVA: 0x7FFE874AD020
        public void HasSchema(){} // RVA: 0x7FFE874AD050
        public void Contains(){} // RVA: 0x7FFE874AD0D0
        public void GetAttributeXdr(){} // RVA: 0x7FFE874AD150
        public void GetAttributeXsd(){} // RVA: 0x7FFE874AD5F0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE874AD740
        public void Finish(){} // RVA: 0x7FFE874AE550
        public void System.Xml.IDtdInfo.get_HasDefaultAttributes(){} // RVA: 0x7FFE814645D0
        public void System.Xml.IDtdInfo.get_HasNonCDataAttributes(){} // RVA: 0x7FFE811B6C00
        public void System.Xml.IDtdInfo.LookupAttributeList(){} // RVA: 0x7FFE874AE750
        public void System.Xml.IDtdInfo.LookupEntity(){} // RVA: 0x7FFE874AE830
        public void System.Xml.IDtdInfo.get_Name(){} // RVA: 0x7FFE8144E200
        public void System.Xml.IDtdInfo.get_InternalDtdSubset(){} // RVA: 0x7FFE8143BA80
    }

    public class SchemaNames : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874AE900
        public void CreateTokenToQNameTable(){} // RVA: 0x7FFE874B2560
        public void SchemaTypeFromRoot(){} // RVA: 0x7FFE874B4E20
        public void IsXSDRoot(){} // RVA: 0x7FFE874B4F90
        public void IsXDRRoot(){} // RVA: 0x7FFE874B5040
    }

    public class SchemaNamespaceManager : XmlNamespaceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE812534D0
        public void LookupNamespace(){} // RVA: 0x7FFE874B50F0
        public void LookupPrefix(){} // RVA: 0x7FFE874B5290
    }

    public class SchemaNotation : Object
    {
        public System.Xml.XmlQualifiedName name; // 0x10
        public string systemLiteral; // 0x18
        public string pubid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_SystemLiteral(){} // RVA: 0x7FFE810FE7C0
        public void set_SystemLiteral(){} // RVA: 0x7FFE81161E80
        public void get_Pubid(){} // RVA: 0x7FFE811290C0
        public void set_Pubid(){} // RVA: 0x7FFE811290D0
    }

    public class SelectorActiveAxis : ActiveAxis
    {
        public System.Xml.Schema.ConstraintStruct cs; // 0x28

        // ── Methods ──
        public void get_lastDepth(){} // RVA: 0x7FFE87615F10
        public void .ctor(){} // RVA: 0x7FFE87615FC0
        public void EndElement(){} // RVA: 0x7FFE876160E0
        public void PushKS(){} // RVA: 0x7FFE876162D0
        public void PopKS(){} // RVA: 0x7FFE876168C0
    }

    public class SequenceNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFE8761A070
        public void get_IsNullable(){} // RVA: 0x7FFE8761AA90
        public void ExpandTree(){} // RVA: 0x7FFE8761AC80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StarNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFE8761B210
        public void get_IsNullable(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StateUnion : ValueType
    {
    }

    public class StringFacetsChecker : FacetsChecker
    {
        public System.Text.RegularExpressions.Regex languagePattern;

        // ── Methods ──
        public void get_LanguagePattern(){} // RVA: 0x7FFE87647630
        public void CheckValueFacets(){} // RVA: 0x7FFE876477E0 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x7FFE87647AF0 | overloaded x2
        public void CheckBuiltInFacets(){} // RVA: 0x7FFE87647D60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SymbolsDictionary : Object
    {
        public int last; // 0x10
        public System.Collections.Hashtable names; // 0x18
        public System.Collections.Hashtable wildcards; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876181B0
        public void get_Count(){} // RVA: 0x7FFE87618300
        public void get_IsUpaEnforced(){} // RVA: 0x7FFE812CF770
        public void set_IsUpaEnforced(){} // RVA: 0x7FFE812D0010
        public void AddName(){} // RVA: 0x7FFE87618310
        public void AddNamespaceList(){} // RVA: 0x7FFE87618450
        public void AddWildcard(){} // RVA: 0x7FFE87618740
        public void GetNamespaceListSymbols(){} // RVA: 0x7FFE87618900
        public void get_Item(){} // RVA: 0x7FFE87618FA0
        public void Exists(){} // RVA: 0x7FFE876190A0
        public void GetParticle(){} // RVA: 0x7FFE876190E0
        public void NameOf(){} // RVA: 0x7FFE87619120
    }

    public class SyntaxTreeNode : Object
    {
        // ── Methods ──
        public void ExpandTree(){} // RVA: 0x7FFE80E50660
        public void ConstructPos(){} // RVA: 0x7FFE80E50660
        public void get_IsNullable(){} // RVA: 0x7FFE80E2F150
        public void get_IsRangeNode(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}