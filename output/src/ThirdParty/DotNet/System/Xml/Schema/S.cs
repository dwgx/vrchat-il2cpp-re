// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 17
// Methods: 314

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class SchemaAttDef : SchemaDeclBase
    {
        public object defExpanded;
        public object lineNum;
        public object linePos;
        public object valueLineNum;
        public object valueLinePos;
        public object reserved;
        public object defaultValueChecked;
        public object schemaAttribute;
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73B1730
        public void System.Xml.IDtdAttributeInfo.get_Prefix(){} // RVA: 0x73B1740
        public void System.Xml.IDtdAttributeInfo.get_LocalName(){} // RVA: 0x13F9340
        public void System.Xml.IDtdAttributeInfo.get_LineNumber(){} // RVA: 0x2536460
        public void System.Xml.IDtdAttributeInfo.get_LinePosition(){} // RVA: 0x25406F0
        public void System.Xml.IDtdAttributeInfo.get_IsNonCDataType(){} // RVA: 0x73B1760
        public void System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal(){} // RVA: 0xC38360
        public void System.Xml.IDtdAttributeInfo.get_IsXmlAttribute(){} // RVA: 0x73B1790
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded(){} // RVA: 0x73B17A0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped(){} // RVA: 0xBC1B30
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber(){} // RVA: 0x19C6270
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition(){} // RVA: 0x21EA4F0
        public void get_LinePosition(){} // RVA: 0x25406F0
        public void set_LinePosition(){} // RVA: 0x2540700
        public void get_LineNumber(){} // RVA: 0x2536460
        public void set_LineNumber(){} // RVA: 0x25406E0
        public void get_ValueLinePosition(){} // RVA: 0x21EA4F0
        public void set_ValueLinePosition(){} // RVA: 0x26432E0
        public void get_ValueLineNumber(){} // RVA: 0x19C6270
        public void set_ValueLineNumber(){} // RVA: 0xCE5450
        public void get_DefaultValueExpanded(){} // RVA: 0x73B17C0
        public void set_DefaultValueExpanded(){} // RVA: 0xBE2C70
        public void get_TokenizedType(){} // RVA: 0x24BC920
        public void set_TokenizedType(){} // RVA: 0x73B17E0
        public void get_Reserved(){} // RVA: 0x23ADD10
        public void set_Reserved(){} // RVA: 0x23B2A80
        public void get_DefaultValueChecked(){} // RVA: 0x1163160
        public void get_SchemaAttribute(){} // RVA: 0xCD48B0
        public void set_SchemaAttribute(){} // RVA: 0xCD3600
        public void CheckXmlSpace(){} // RVA: 0x73B1850
        public void Clone(){} // RVA: 0x73B1BC0
        public void .cctor(){} // RVA: 0x73B1C20
    }

    public class SchemaBuilder : Object
    {
        // ── Methods ──
        public void ProcessElement(){} // RVA: 0x87D710
        public void ProcessAttribute(){} // RVA: 0x899870
        public void IsContentParsed(){} // RVA: 0x87D280
        public void ProcessMarkup(){} // RVA: 0x894320
        public void ProcessCData(){} // RVA: 0x894320
        public void StartChildren(){} // RVA: 0x894290
        public void EndChildren(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SchemaCollectionCompiler : BaseProcessor
    {
        public object compileContentModel;
        public object examplars;
        public object complexTypeStack;
        public object schema;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73B1CD0
        public void Execute(){} // RVA: 0x73B1E40
        public void Prepare(){} // RVA: 0x73B1EF0
        public void Cleanup(){} // RVA: 0x73B2FF0
        public void Compile(){} // RVA: 0x73B3A60
        public void Output(){} // RVA: 0x73B5650
        public void CleanupAttribute(){} // RVA: 0x73B64E0
        public void CleanupAttributeGroup(){} // RVA: 0x73B65C0
        public void CleanupComplexType(){} // RVA: 0x73B6650
        public void CleanupSimpleType(){} // RVA: 0x73B6BA0
        public void CleanupElement(){} // RVA: 0x73B6C10
        public void CleanupAttributes(){} // RVA: 0x73B6EF0
        public void CleanupGroup(){} // RVA: 0x73B6FD0
        public void CleanupParticle(){} // RVA: 0x73B7050
        public void CompileSubstitutionGroup(){} // RVA: 0x73B7250
        public void CheckSubstitutionGroup(){} // RVA: 0x73B7860
        public void CompileGroup(){} // RVA: 0x73B7AB0
        public void CompileSimpleType(){} // RVA: 0x73B7BF0
        public void CompileBaseMemberTypes(){} // RVA: 0x73B8810
        public void CheckUnionType(){} // RVA: 0x73B8CB0
        public void CompileComplexType(){} // RVA: 0x73B8DF0
        public void CompileSimpleContentExtension(){} // RVA: 0x73B9C30
        public void CompileSimpleContentRestriction(){} // RVA: 0x73B9F70
        public void CompileComplexContentExtension(){} // RVA: 0x73BA440
        public void CompileComplexContentRestriction(){} // RVA: 0x73BAA50
        public void CheckParticleDerivation(){} // RVA: 0x73BAF10
        public void CompileContentTypeParticle(){} // RVA: 0x73BB000
        public void CannonicalizeParticle(){} // RVA: 0x73BB210
        public void CannonicalizeElement(){} // RVA: 0x73BB570
        public void CannonicalizeGroupRef(){} // RVA: 0x73BB740
        public void CannonicalizeAll(){} // RVA: 0x73BBF50
        public void CannonicalizeChoice(){} // RVA: 0x73BC6A0
        public void CannonicalizeSequence(){} // RVA: 0x73BCF00
        public void IsValidRestriction(){} // RVA: 0x73BD6E0
        public void IsElementFromElement(){} // RVA: 0x73BE210
        public void IsElementFromAny(){} // RVA: 0x73BE410
        public void IsAnyFromAny(){} // RVA: 0x73BE4A0
        public void IsGroupBaseFromAny(){} // RVA: 0x73BE500
        public void IsElementFromGroupBase(){} // RVA: 0x73BE870
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x73BECE0
        public void IsSequenceFromAll(){} // RVA: 0x73BF020
        public void IsSequenceFromChoice(){} // RVA: 0x73BF410
        public void CalculateSequenceRange(){} // RVA: 0x73BF780
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x73BFF30
        public void GetMappingParticle(){} // RVA: 0x73C0080
        public void IsParticleEmptiable(){} // RVA: 0x73C01A0
        public void CalculateEffectiveTotalRange(){} // RVA: 0x73C02B0
        public void PushComplexType(){} // RVA: 0x73C0FD0
        public void GetSchemaContentType(){} // RVA: 0x73C1000
        public void CompileAttributeGroup(){} // RVA: 0x73C1080
        public void CompileLocalAttributes(){} // RVA: 0x73C17C0
        public void CompileAnyAttributeUnion(){} // RVA: 0x73C28D0
        public void CompileAnyAttributeIntersection(){} // RVA: 0x73C2980
        public void CompileAttribute(){} // RVA: 0x73C2A30
        public void CompileIdentityConstraint(){} // RVA: 0x73C35F0
        public void CompileElement(){} // RVA: 0x73C3D20
        public void CompileComplexContent(){} // RVA: 0x73C4C80
        public void BuildParticleContentModel(){} // RVA: 0x73C5A80
        public void CompileParticleElements(){} // RVA: 0x73C6340
        public void CompileCompexTypeElements(){} // RVA: 0x73C6660
        public void GetSimpleType(){} // RVA: 0x73C6740
        public void GetComplexType(){} // RVA: 0x73C68B0
        public void GetAnySchemaType(){} // RVA: 0x73C6970
    }

    public class SchemaCollectionPreprocessor : BaseProcessor
    {
        public object schema;
        public object targetNamespace;
        public object buildinIncluded;
        public object elementFormDefault;
        public object attributeFormDefault;
        public object blockDefault;
        public object finalDefault;
        public object schemaLocations;
        public object referenceNamespaces;
        public object Xmlns;
        public object xmlResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73C6B50
        public void Execute(){} // RVA: 0x73C6B60
        public void Cleanup(){} // RVA: 0x73C6ED0
        public void set_XmlResolver(){} // RVA: 0xCD3600
        public void LoadExternals(){} // RVA: 0x73C7490
        public void BuildRefNamespaces(){} // RVA: 0x73C8110
        public void Preprocess(){} // RVA: 0x73C83A0
        public void PreprocessRedefine(){} // RVA: 0x73CA120
        public void CountGroupSelfReference(){} // RVA: 0x73CB310
        public void CheckRefinedGroup(){} // RVA: 0x73CB690
        public void CheckRefinedAttributeGroup(){} // RVA: 0x73CB730
        public void CheckRefinedSimpleType(){} // RVA: 0x73CB8A0
        public void CheckRefinedComplexType(){} // RVA: 0x73CB9F0
        public void PreprocessAttribute(){} // RVA: 0x73CBE90
        public void PreprocessLocalAttribute(){} // RVA: 0x73CC140
        public void PreprocessAttributeContent(){} // RVA: 0x73CC4E0
        public void PreprocessAttributeGroup(){} // RVA: 0x73CC820
        public void PreprocessElement(){} // RVA: 0x73CCA50
        public void PreprocessLocalElement(){} // RVA: 0x73CCE00
        public void PreprocessElementContent(){} // RVA: 0x73CD400
        public void PreprocessIdentityConstraint(){} // RVA: 0x73CD920
        public void PreprocessSimpleType(){} // RVA: 0x73CDEF0
        public void PreprocessComplexType(){} // RVA: 0x73CE9A0
        public void PreprocessGroup(){} // RVA: 0x73CF710
        public void PreprocessNotation(){} // RVA: 0x73CFA10
        public void PreprocessParticle(){} // RVA: 0x73CFD20
        public void PreprocessAttributes(){} // RVA: 0x73D0A90
        public void ValidateIdAttribute(){} // RVA: 0x73D0F30
        public void ValidateNameAttribute(){} // RVA: 0x73D1160
        public void ValidateQNameAttribute(){} // RVA: 0x73D1480
        public void SetParent(){} // RVA: 0x73B1470
        public void PreprocessAnnotation(){} // RVA: 0x73D15A0
        public void ResolveSchemaLocationUri(){} // RVA: 0x73D1730
        public void GetSchemaEntity(){} // RVA: 0x73D1780
    }

    public class SchemaDeclBase : Object
    {
        public object name;
        public object prefix;
        public object isDeclaredInExternal;
        public object presence;
        public object schemaType;
        public object datatype;
        public object defaultValueRaw;
        public object defaultValueTyped;
        public object maxLength;
        public object minLength;
        public object values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73D1A20
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Prefix(){} // RVA: 0x73D1AD0
        public void set_Prefix(){} // RVA: 0xBA9BA0
        public void get_IsDeclaredInExternal(){} // RVA: 0xC38360
        public void set_IsDeclaredInExternal(){} // RVA: 0xC38370
        public void get_Presence(){} // RVA: 0x15AF000
        public void set_Presence(){} // RVA: 0x1FAA840
        public void get_MaxLength(){} // RVA: 0xBBF8F0
        public void set_MaxLength(){} // RVA: 0x20633C0
        public void get_MinLength(){} // RVA: 0xBE58B0
        public void set_MinLength(){} // RVA: 0xE9E640
        public void get_SchemaType(){} // RVA: 0xB70160
        public void set_SchemaType(){} // RVA: 0xB44DC0
        public void get_Datatype(){} // RVA: 0xD33E60
        public void set_Datatype(){} // RVA: 0xB708C0
        public void AddValue(){} // RVA: 0x73D1AF0
        public void get_Values(){} // RVA: 0xC0FFC0
        public void set_Values(){} // RVA: 0xC0FFD0
        public void get_DefaultValueRaw(){} // RVA: 0x73D1C30
        public void set_DefaultValueRaw(){} // RVA: 0xD09D70
        public void get_DefaultValueTyped(){} // RVA: 0xBC1B30
        public void set_DefaultValueTyped(){} // RVA: 0xB6A8C0
        public void CheckEnumeration(){} // RVA: 0x73D1C50
        public void CheckValue(){} // RVA: 0x73D1D10
    }

    public class SchemaElementDecl : SchemaDeclBase
    {
        public object attdefs;
        public object defaultAttdefs;
        public object isIdDeclared;
        public object hasNonCDataAttribute;
        public object isAbstract;
        public object isNillable;
        public object hasRequiredAttribute;
        public object isNotationDeclared;
        public object prohibitedAttributes;
        public object contentValidator;
        public object anyAttribute;
        public object block;
        public object constraints;
        public object schemaElement;
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73D2140
        public void CreateAnyTypeElementDecl(){} // RVA: 0x73D22D0
        public void System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes(){} // RVA: 0x6529A10
        public void System.Xml.IDtdAttributeListInfo.LookupAttribute(){} // RVA: 0x73D23F0
        public void System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes(){} // RVA: 0xBBFF90
        public void get_IsIdDeclared(){} // RVA: 0xBC03E0
        public void set_IsIdDeclared(){} // RVA: 0xBC03F0
        public void get_HasNonCDataAttribute(){} // RVA: 0x6529A10
        public void set_HasNonCDataAttribute(){} // RVA: 0x6529A20
        public void Clone(){} // RVA: 0x73D2580
        public void get_IsAbstract(){} // RVA: 0x6529A30
        public void set_IsAbstract(){} // RVA: 0x6529A40
        public void get_IsNillable(){} // RVA: 0x6DC81C0
        public void set_IsNillable(){} // RVA: 0x73D25E0
        public void get_Block(){} // RVA: 0xF3A950
        public void set_Block(){} // RVA: 0x17AFA20
        public void get_IsNotationDeclared(){} // RVA: 0x1A1E0B0
        public void set_IsNotationDeclared(){} // RVA: 0x6DE6210
        public void get_HasDefaultAttribute(){} // RVA: 0x1C4F7F0
        public void get_HasRequiredAttribute(){} // RVA: 0x19FAC10
        public void get_ContentValidator(){} // RVA: 0xCD48B0
        public void set_ContentValidator(){} // RVA: 0xCD3600
        public void get_AnyAttribute(){} // RVA: 0xB813B0
        public void set_AnyAttribute(){} // RVA: 0xD5CBB0
        public void get_Constraints(){} // RVA: 0x106A7D0
        public void set_Constraints(){} // RVA: 0xD5CC70
        public void get_SchemaElement(){} // RVA: 0x106A050
        public void set_SchemaElement(){} // RVA: 0xD5CCD0
        public void AddAttDef(){} // RVA: 0x73D25F0
        public void GetAttDef(){} // RVA: 0x73D27A0
        public void get_DefaultAttDefs(){} // RVA: 0xBBFF90
        public void get_AttDefs(){} // RVA: 0xBE2C60
        public void get_ProhibitedAttributes(){} // RVA: 0xCD3320
        public void CheckAttributes(){} // RVA: 0x73D2820
        public void .cctor(){} // RVA: 0x73D2BA0
    }

    public class SchemaEntity : Object
    {
        public object qname;
        public object url;
        public object pubid;
        public object text;
        public object ndata;
        public object lineNumber;
        public object linePosition;
        public object isParameter;
        public object isExternal;
        public object parsingInProgress;
        public object isDeclaredInExternal;
        public object baseURI;
        public object declaredURI;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73D2C50
        public void System.Xml.IDtdEntityInfo.get_Name(){} // RVA: 0x13F9340
        public void System.Xml.IDtdEntityInfo.get_IsExternal(){} // RVA: 0xEEA010
        public void System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal(){} // RVA: 0x1DE3FA0
        public void System.Xml.IDtdEntityInfo.get_IsUnparsedEntity(){} // RVA: 0x73D2D70
        public void System.Xml.IDtdEntityInfo.get_IsParameterEntity(){} // RVA: 0xC02470
        public void System.Xml.IDtdEntityInfo.get_BaseUriString(){} // RVA: 0x73D2DC0
        public void System.Xml.IDtdEntityInfo.get_DeclaredUriString(){} // RVA: 0x73D2DE0
        public void System.Xml.IDtdEntityInfo.get_SystemId(){} // RVA: 0xB465B0
        public void System.Xml.IDtdEntityInfo.get_PublicId(){} // RVA: 0xB700F0
        public void System.Xml.IDtdEntityInfo.get_Text(){} // RVA: 0xB70160
        public void System.Xml.IDtdEntityInfo.get_LineNumber(){} // RVA: 0x18A0130
        public void System.Xml.IDtdEntityInfo.get_LinePosition(){} // RVA: 0x114DAD0
        public void IsPredefinedEntity(){} // RVA: 0x73D2E00
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Url(){} // RVA: 0xB465B0
        public void set_Url(){} // RVA: 0x73D2FB0
        public void get_Pubid(){} // RVA: 0xB700F0
        public void set_Pubid(){} // RVA: 0xB70100
        public void get_IsExternal(){} // RVA: 0xEEA010
        public void set_IsExternal(){} // RVA: 0xEEA000
        public void get_DeclaredInExternal(){} // RVA: 0x1DE3FA0
        public void set_DeclaredInExternal(){} // RVA: 0x23E2280
        public void get_NData(){} // RVA: 0xD33E60
        public void set_NData(){} // RVA: 0xB708C0
        public void get_Text(){} // RVA: 0xB70160
        public void set_Text(){} // RVA: 0x73D3010
        public void get_Line(){} // RVA: 0x18A0130
        public void set_Line(){} // RVA: 0x189D3F0
        public void get_Pos(){} // RVA: 0x114DAD0
        public void set_Pos(){} // RVA: 0x25671C0
        public void get_BaseURI(){} // RVA: 0x73D3070
        public void set_BaseURI(){} // RVA: 0xBBF900
        public void get_ParsingInProgress(){} // RVA: 0xEEA480
        public void set_ParsingInProgress(){} // RVA: 0xEEA470
        public void get_DeclaredURI(){} // RVA: 0x73D3090
        public void set_DeclaredURI(){} // RVA: 0xCA4DF0
    }

    public class SchemaInfo : Object
    {
        public object elementDecls;
        public object undeclaredElementDecls;
        public object generalEntities;
        public object parameterEntities;
        public object docTypeName;
        public object internalDtdSubset;
        public object hasNonCDataAttributes;
        public object hasDefaultAttributes;
        public object targetNamespaces;
        public object attributeDecls;
        public object errorCount;
        public object schemaType;
        public object elementDeclsByType;
        public object notations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73D30B0
        public void get_DocTypeName(){} // RVA: 0xD33E60
        public void set_DocTypeName(){} // RVA: 0xB708C0
        public void set_InternalDtdSubset(){} // RVA: 0xD09D70
        public void get_ElementDecls(){} // RVA: 0xB5DBF0
        public void get_UndeclaredElementDecls(){} // RVA: 0xB465B0
        public void get_GeneralEntities(){} // RVA: 0x73D3470
        public void get_ParameterEntities(){} // RVA: 0x73D3530
        public void get_SchemaType(){} // RVA: 0xE36310
        public void set_SchemaType(){} // RVA: 0x12BB610
        public void get_TargetNamespaces(){} // RVA: 0xBBF8F0
        public void get_ElementDeclsByType(){} // RVA: 0xBE2C60
        public void get_AttributeDecls(){} // RVA: 0xBE58B0
        public void get_Notations(){} // RVA: 0x73D35F0
        public void get_ErrorCount(){} // RVA: 0x12BB630
        public void set_ErrorCount(){} // RVA: 0x12BB640
        public void GetElementDecl(){} // RVA: 0x73D36B0
        public void GetTypeDecl(){} // RVA: 0x73D3730
        public void GetElement(){} // RVA: 0x73D37B0
        public void HasSchema(){} // RVA: 0x73D37E0
        public void Contains(){} // RVA: 0x73D3860
        public void GetAttributeXdr(){} // RVA: 0x73D38E0
        public void GetAttributeXsd(){} // RVA: 0x73D3D80
        public void Add(){} // RVA: 0x73D3ED0
        public void Finish(){} // RVA: 0x73D4CB0
        public void System.Xml.IDtdInfo.get_HasDefaultAttributes(){} // RVA: 0xEEA010
        public void System.Xml.IDtdInfo.get_HasNonCDataAttributes(){} // RVA: 0xC02470
        public void System.Xml.IDtdInfo.LookupAttributeList(){} // RVA: 0x73D4EB0
        public void System.Xml.IDtdInfo.LookupEntity(){} // RVA: 0x73D5050
        public void System.Xml.IDtdInfo.get_Name(){} // RVA: 0xD33E60
        public void System.Xml.IDtdInfo.get_InternalDtdSubset(){} // RVA: 0xD05CA0
    }

    public class SchemaNames : Object
    {
        public object nameTable;
        public object NsDataType;
        public object NsDataTypeAlias;
        public object NsDataTypeOld;
        public object NsXml;
        public object NsXmlNs;
        public object NsXdr;
        public object NsXdrAlias;
        public object NsXs;
        public object NsXsi;
        public object XsiType;
        public object XsiNil;
        public object XsiSchemaLocation;
        public object XsiNoNamespaceSchemaLocation;
        public object XsdSchema;
        public object XdrSchema;
        public object QnPCData;
        public object QnXml;
        public object QnXmlNs;
        public object QnDtDt;
        public object QnXmlLang;
        public object QnName;
        public object QnType;
        public object QnMaxOccurs;
        public object QnMinOccurs;
        public object QnInfinite;
        public object QnModel;
        public object QnOpen;
        public object QnClosed;
        public object QnContent;
        public object QnMixed;
        public object QnEmpty;
        public object QnEltOnly;
        public object QnTextOnly;
        public object QnOrder;
        public object QnSeq;
        public object QnOne;
        public object QnMany;
        public object QnRequired;
        public object QnYes;
        public object QnNo;
        public object QnString;
        public object QnID;
        public object QnIDRef;
        public object QnIDRefs;
        public object QnEntity;
        public object QnEntities;
        public object QnNmToken;
        public object QnNmTokens;
        public object QnEnumeration;
        public object QnDefault;
        public object QnXdrSchema;
        public object QnXdrElementType;
        public object QnXdrElement;
        public object QnXdrGroup;
        public object QnXdrAttributeType;
        public object QnXdrAttribute;
        public object QnXdrDataType;
        public object QnXdrDescription;
        public object QnXdrExtends;
        public object QnXdrAliasSchema;
        public object QnDtType;
        public object QnDtValues;
        public object QnDtMaxLength;
        public object QnDtMinLength;
        public object QnDtMax;
        public object QnDtMin;
        public object QnDtMinExclusive;
        public object QnDtMaxExclusive;
        public object QnTargetNamespace;
        public object QnVersion;
        public object QnFinalDefault;
        public object QnBlockDefault;
        public object QnFixed;
        public object QnAbstract;
        public object QnBlock;
        public object QnSubstitutionGroup;
        public object QnFinal;
        public object QnNillable;
        public object QnRef;
        public object QnBase;
        public object QnDerivedBy;
        public object QnNamespace;
        public object QnProcessContents;
        public object QnRefer;
        public object QnPublic;
        public object QnSystem;
        public object QnSchemaLocation;
        public object QnValue;
        public object QnUse;
        public object QnForm;
        public object QnElementFormDefault;
        public object QnAttributeFormDefault;
        public object QnItemType;
        public object QnMemberTypes;
        public object QnXPath;
        public object QnXsdSchema;
        public object QnXsdAnnotation;
        public object QnXsdInclude;
        public object QnXsdImport;
        public object QnXsdElement;
        public object QnXsdAttribute;
        public object QnXsdAttributeGroup;
        public object QnXsdAnyAttribute;
        public object QnXsdGroup;
        public object QnXsdAll;
        public object QnXsdChoice;
        public object QnXsdSequence;
        public object QnXsdAny;
        public object QnXsdNotation;
        public object QnXsdSimpleType;
        public object QnXsdComplexType;
        public object QnXsdUnique;
        public object QnXsdKey;
        public object QnXsdKeyRef;
        public object QnXsdSelector;
        public object QnXsdField;
        public object QnXsdMinExclusive;
        public object QnXsdMinInclusive;
        public object QnXsdMaxInclusive;
        public object QnXsdMaxExclusive;
        public object QnXsdTotalDigits;
        public object QnXsdFractionDigits;
        public object QnXsdLength;
        public object QnXsdMinLength;
        public object QnXsdMaxLength;
        public object QnXsdEnumeration;
        public object QnXsdPattern;
        public object QnXsdDocumentation;
        public object QnXsdAppinfo;
        public object QnSource;
        public object QnXsdComplexContent;
        public object QnXsdSimpleContent;
        public object QnXsdRestriction;
        public object QnXsdExtension;
        public object QnXsdUnion;
        public object QnXsdList;
        public object QnXsdWhiteSpace;
        public object QnXsdRedefine;
        public object QnXsdAnyType;
        public object TokenToQName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73D5120
        public void CreateTokenToQNameTable(){} // RVA: 0x73D8F70
        public void SchemaTypeFromRoot(){} // RVA: 0x73DB830
        public void IsXSDRoot(){} // RVA: 0x73DB9A0
        public void IsXDRRoot(){} // RVA: 0x73DBA50
    }

    public class SchemaNamespaceManager : XmlNamespaceManager
    {
        public object node;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xCA4DF0
        public void LookupNamespace(){} // RVA: 0x73DBB00
        public void LookupPrefix(){} // RVA: 0x73DBC90
    }

    public class SchemaNotation : Object
    {
        public object name;
        public object systemLiteral;
        public object pubid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_SystemLiteral(){} // RVA: 0xB465B0
        public void set_SystemLiteral(){} // RVA: 0xBA9BA0
        public void get_Pubid(){} // RVA: 0xB700F0
        public void set_Pubid(){} // RVA: 0xB70100
    }

    public class SelectorActiveAxis : ActiveAxis
    {
        public object cs;
        public object KSs;
        public object KSpointer;

        // ── Methods ──
        public void get_lastDepth(){} // RVA: 0x753B030
        public void .ctor(){} // RVA: 0x753B0E0
        public void EndElement(){} // RVA: 0x753B200
        public void PushKS(){} // RVA: 0x753B3F0
        public void PopKS(){} // RVA: 0x753B9F0
    }

    public class SequenceNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x753F090
        public void get_IsNullable(){} // RVA: 0x753FA20
        public void ExpandTree(){} // RVA: 0x753FC10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StarNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7540190
        public void get_IsNullable(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StringFacetsChecker : FacetsChecker
    {
        public object languagePattern;

        // ── Methods ──
        public void get_LanguagePattern(){} // RVA: 0x756BCA0
        public void CheckValueFacets(){} // RVA: 0x756BE50
        public void MatchEnumeration(){} // RVA: 0x756C150
        public void CheckBuiltInFacets(){} // RVA: 0x756C3D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SymbolsDictionary : Object
    {
        public object last;
        public object names;
        public object wildcards;
        public object particles;
        public object particleLast;
        public object isUpaEnforced;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x753D2C0
        public void get_Count(){} // RVA: 0x753D410
        public void get_IsUpaEnforced(){} // RVA: 0xD16660
        public void set_IsUpaEnforced(){} // RVA: 0xD14C10
        public void AddName(){} // RVA: 0x753D420
        public void AddNamespaceList(){} // RVA: 0x753D540
        public void AddWildcard(){} // RVA: 0x753D810
        public void GetNamespaceListSymbols(){} // RVA: 0x753D9C0
        public void get_Item(){} // RVA: 0x753E040
        public void Exists(){} // RVA: 0x753E120
        public void GetParticle(){} // RVA: 0x753E160
        public void NameOf(){} // RVA: 0x753E1A0
    }

    public class SyntaxTreeNode : Object
    {
        // ── Methods ──
        public void ExpandTree(){} // RVA: 0x8954D0
        public void ConstructPos(){} // RVA: 0x8954D0
        public void get_IsNullable(){} // RVA: 0x87D280
        public void get_IsRangeNode(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43310
    }

}