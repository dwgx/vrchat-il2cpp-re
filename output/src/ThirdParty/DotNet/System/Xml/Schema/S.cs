// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 18
// Methods: 325

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class SchemaAttDef : SchemaDeclBase
    {
        public string System.Xml.IDtdAttributeInfo.Prefix; // 0x60
        public int System.Xml.IDtdAttributeInfo.LocalName; // 0x68
        public int System.Xml.IDtdAttributeInfo.LineNumber; // 0x6C
        public int System.Xml.IDtdAttributeInfo.LinePosition; // 0x70
        public int System.Xml.IDtdAttributeInfo.IsNonCDataType; // 0x74
        public 0x6B162978 System.Xml.IDtdAttributeInfo.IsDeclaredInExternal; // 0x78
        public bool System.Xml.IDtdAttributeInfo.IsXmlAttribute; // 0x7C
        public System.Xml.Schema.XmlSchemaAttribute System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded; // 0x80
        public System.Xml.Schema.SchemaAttDef System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90E2650 | overloaded x3
        public void System.Xml.IDtdAttributeInfo.get_Prefix(){} // RVA: 0x7FFAC90E2660
        public void System.Xml.IDtdAttributeInfo.get_LocalName(){} // RVA: 0x7FFAC3511350
        public void System.Xml.IDtdAttributeInfo.get_LineNumber(){} // RVA: 0x7FFAC47BAB50
        public void System.Xml.IDtdAttributeInfo.get_LinePosition(){} // RVA: 0x7FFAC47BAB70
        public void System.Xml.IDtdAttributeInfo.get_IsNonCDataType(){} // RVA: 0x7FFAC90E26C0
        public void System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal(){} // RVA: 0x7FFAC300F9D0
        public void System.Xml.IDtdAttributeInfo.get_IsXmlAttribute(){} // RVA: 0x7FFAC90E26F0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded(){} // RVA: 0x7FFAC90E2700
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped(){} // RVA: 0x7FFAC2F9E740
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber(){} // RVA: 0x7FFAC3B99E80
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition(){} // RVA: 0x7FFAC43D9E20
        public void get_LinePosition(){} // RVA: 0x7FFAC47BAB70
        public void set_LinePosition(){} // RVA: 0x7FFAC47BAB80
        public void get_LineNumber(){} // RVA: 0x7FFAC47BAB50
        public void set_LineNumber(){} // RVA: 0x7FFAC47BAB60
        public void get_ValueLinePosition(){} // RVA: 0x7FFAC43D9E20
        public void set_ValueLinePosition(){} // RVA: 0x7FFAC48B4C80
        public void get_ValueLineNumber(){} // RVA: 0x7FFAC3B99E80
        public void set_ValueLineNumber(){} // RVA: 0x7FFAC30B6520
        public void get_DefaultValueExpanded(){} // RVA: 0x7FFAC90E2760
        public void set_DefaultValueExpanded(){} // RVA: 0x7FFAC2FBF380
        public void get_TokenizedType(){} // RVA: 0x7FFAC46709C0
        public void set_TokenizedType(){} // RVA: 0x7FFAC90E27C0
        public void get_Reserved(){} // RVA: 0x7FFAC4596EF0
        public void set_Reserved(){} // RVA: 0x7FFAC45963A0
        public void get_DefaultValueChecked(){} // RVA: 0x7FFAC33CFDF0
        public void get_SchemaAttribute(){} // RVA: 0x7FFAC32EF410
        public void set_SchemaAttribute(){} // RVA: 0x7FFAC34D4AA0
        public void CheckXmlSpace(){} // RVA: 0x7FFAC90E2830
        public void Clone(){} // RVA: 0x7FFAC90E2BC0
        public void .cctor(){} // RVA: 0x7FFAC90E2C20
    }

    public class SchemaBuilder : Object
    {
        // ── Methods ──
        public void ProcessElement(){}
        public void ProcessAttribute(){} // RVA: 0x7FFAC2C7B8C0
        public void IsContentParsed(){} // RVA: 0x7FFAC2C59D00
        public void ProcessMarkup(){} // RVA: 0x7FFAC2C70A40
        public void ProcessCData(){} // RVA: 0x7FFAC2C70A40
        public void StartChildren(){} // RVA: 0x7FFAC2C70980
        public void EndChildren(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SchemaCollectionCompiler : BaseProcessor
    {
        public bool compileContentModel; // 0x40
        public System.Xml.Schema.XmlSchemaObjectTable examplars; // 0x48
        public System.Collections.Stack complexTypeStack; // 0x50
        public System.Xml.Schema.XmlSchema schema; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90E2CD0
        public void Execute(){} // RVA: 0x7FFAC90E2E30
        public void Prepare(){} // RVA: 0x7FFAC90E2EE0
        public void Cleanup(){} // RVA: 0x7FFAC90E4090 | overloaded x2
        public void Compile(){} // RVA: 0x7FFAC90E4BF0
        public void Output(){} // RVA: 0x7FFAC90E68F0
        public void CleanupAttribute(){} // RVA: 0x7FFAC90E77E0
        public void CleanupAttributeGroup(){} // RVA: 0x7FFAC90E78C0
        public void CleanupComplexType(){} // RVA: 0x7FFAC90E7950
        public void CleanupSimpleType(){} // RVA: 0x7FFAC90E7EA0
        public void CleanupElement(){} // RVA: 0x7FFAC90E7F10
        public void CleanupAttributes(){} // RVA: 0x7FFAC90E8200
        public void CleanupGroup(){} // RVA: 0x7FFAC90E82F0
        public void CleanupParticle(){} // RVA: 0x7FFAC90E8370
        public void CompileSubstitutionGroup(){} // RVA: 0x7FFAC90E8590
        public void CheckSubstitutionGroup(){} // RVA: 0x7FFAC90E8BA0
        public void CompileGroup(){} // RVA: 0x7FFAC90E8DF0
        public void CompileSimpleType(){} // RVA: 0x7FFAC90E8F30
        public void CompileBaseMemberTypes(){} // RVA: 0x7FFAC90E9B60
        public void CheckUnionType(){} // RVA: 0x7FFAC90EA020
        public void CompileComplexType(){} // RVA: 0x7FFAC90EA170
        public void CompileSimpleContentExtension(){} // RVA: 0x7FFAC90EAFE0
        public void CompileSimpleContentRestriction(){} // RVA: 0x7FFAC90EB320
        public void CompileComplexContentExtension(){} // RVA: 0x7FFAC90EB7F0
        public void CompileComplexContentRestriction(){} // RVA: 0x7FFAC90EBE20
        public void CheckParticleDerivation(){} // RVA: 0x7FFAC90EC2E0
        public void CompileContentTypeParticle(){} // RVA: 0x7FFAC90EC3F0
        public void CannonicalizeParticle(){} // RVA: 0x7FFAC90EC610
        public void CannonicalizeElement(){} // RVA: 0x7FFAC90EC970
        public void CannonicalizeGroupRef(){} // RVA: 0x7FFAC90ECB40
        public void CannonicalizeAll(){} // RVA: 0x7FFAC90ED350
        public void CannonicalizeChoice(){} // RVA: 0x7FFAC90EDA80
        public void CannonicalizeSequence(){} // RVA: 0x7FFAC90EE2F0
        public void IsValidRestriction(){} // RVA: 0x7FFAC90EEAD0
        public void IsElementFromElement(){} // RVA: 0x7FFAC90EF600
        public void IsElementFromAny(){} // RVA: 0x7FFAC90EF800
        public void IsAnyFromAny(){} // RVA: 0x7FFAC90EF890
        public void IsGroupBaseFromAny(){} // RVA: 0x7FFAC90EF8F0
        public void IsElementFromGroupBase(){} // RVA: 0x7FFAC90EFC60
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7FFAC90F00D0
        public void IsSequenceFromAll(){} // RVA: 0x7FFAC90F0410
        public void IsSequenceFromChoice(){} // RVA: 0x7FFAC90F0800
        public void CalculateSequenceRange(){} // RVA: 0x7FFAC90F0B70
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7FFAC90F1310 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x7FFAC90F1460
        public void IsParticleEmptiable(){} // RVA: 0x7FFAC90F1580
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7FFAC90F1690
        public void PushComplexType(){} // RVA: 0x7FFAC90F23B0
        public void GetSchemaContentType(){} // RVA: 0x7FFAC90F23E0
        public void CompileAttributeGroup(){} // RVA: 0x7FFAC90F2460
        public void CompileLocalAttributes(){} // RVA: 0x7FFAC90F2BB0
        public void CompileAnyAttributeUnion(){} // RVA: 0x7FFAC90F3D50
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7FFAC90F3E00
        public void CompileAttribute(){} // RVA: 0x7FFAC90F3EB0
        public void CompileIdentityConstraint(){} // RVA: 0x7FFAC90F4A30
        public void CompileElement(){} // RVA: 0x7FFAC90F5160
        public void CompileComplexContent(){} // RVA: 0x7FFAC90F60B0
        public void BuildParticleContentModel(){} // RVA: 0x7FFAC90F6EB0
        public void CompileParticleElements(){} // RVA: 0x7FFAC90F7770
        public void CompileCompexTypeElements(){} // RVA: 0x7FFAC90F7A90
        public void GetSimpleType(){} // RVA: 0x7FFAC90F7B70
        public void GetComplexType(){} // RVA: 0x7FFAC90F7CF0
        public void GetAnySchemaType(){} // RVA: 0x7FFAC90F7DC0
    }

    public class SchemaCollectionPreprocessor : BaseProcessor
    {
        public System.Xml.Schema.XmlSchema XmlResolver; // 0x40
        public string targetNamespace; // 0x48
        public bool buildinIncluded; // 0x50
        public 0x6B164550 elementFormDefault; // 0x54
        public 0x6B164550 attributeFormDefault; // 0x58
        public 0x6B163E70 blockDefault; // 0x5C
        public 0x6B163E70 finalDefault; // 0x60
        public System.Collections.Hashtable schemaLocations; // 0x68
        public System.Collections.Hashtable referenceNamespaces; // 0x70
        public string Xmlns; // 0x78
        public System.Xml.XmlResolver xmlResolver; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90F7FA0
        public void Execute(){} // RVA: 0x7FFAC90F7FB0
        public void Cleanup(){} // RVA: 0x7FFAC90F8310
        public void set_XmlResolver(){} // RVA: 0x7FFAC34D4AA0
        public void LoadExternals(){} // RVA: 0x7FFAC90F88C0
        public void BuildRefNamespaces(){} // RVA: 0x7FFAC90F9550
        public void Preprocess(){} // RVA: 0x7FFAC90F9800
        public void PreprocessRedefine(){} // RVA: 0x7FFAC90FB750
        public void CountGroupSelfReference(){} // RVA: 0x7FFAC90FC9C0
        public void CheckRefinedGroup(){} // RVA: 0x7FFAC90FCD60
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7FFAC90FCE00
        public void CheckRefinedSimpleType(){} // RVA: 0x7FFAC90FCF90
        public void CheckRefinedComplexType(){} // RVA: 0x7FFAC90FD0E0
        public void PreprocessAttribute(){} // RVA: 0x7FFAC90FD580
        public void PreprocessLocalAttribute(){} // RVA: 0x7FFAC90FD760
        public void PreprocessAttributeContent(){} // RVA: 0x7FFAC90FDA20
        public void PreprocessAttributeGroup(){} // RVA: 0x7FFAC90FDD60
        public void PreprocessElement(){} // RVA: 0x7FFAC90FDED0
        public void PreprocessLocalElement(){} // RVA: 0x7FFAC90FE1C0
        public void PreprocessElementContent(){} // RVA: 0x7FFAC90FE6F0
        public void PreprocessIdentityConstraint(){} // RVA: 0x7FFAC90FEC10
        public void PreprocessSimpleType(){} // RVA: 0x7FFAC90FF130
        public void PreprocessComplexType(){} // RVA: 0x7FFAC90FFAF0
        public void PreprocessGroup(){} // RVA: 0x7FFAC91008A0
        public void PreprocessNotation(){} // RVA: 0x7FFAC9100AE0
        public void PreprocessParticle(){} // RVA: 0x7FFAC9100D20
        public void PreprocessAttributes(){} // RVA: 0x7FFAC9101A90
        public void ValidateIdAttribute(){} // RVA: 0x7FFAC9101F30
        public void ValidateNameAttribute(){} // RVA: 0x7FFAC9102160
        public void ValidateQNameAttribute(){} // RVA: 0x7FFAC9102490
        public void SetParent(){} // RVA: 0x7FFAC90E23A0
        public void PreprocessAnnotation(){} // RVA: 0x7FFAC91025B0
        public void ResolveSchemaLocationUri(){} // RVA: 0x7FFAC9102740
        public void GetSchemaEntity(){} // RVA: 0x7FFAC9102790
    }

    public class SchemaDeclBase : Object
    {
        public System.Xml.XmlQualifiedName Name; // 0x10
        public string Prefix; // 0x18
        public bool IsDeclaredInExternal; // 0x20
        public 0x6B162B88 Presence; // 0x24
        public System.Xml.Schema.XmlSchemaType MaxLength; // 0x28
        public System.Xml.Schema.XmlSchemaDatatype MinLength; // 0x30
        public string SchemaType; // 0x38
        public object Datatype; // 0x40
        public long Values; // 0x48
        public long DefaultValueRaw; // 0x50
        public System.Collections.Generic.List`1<string> DefaultValueTyped; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9102A30 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Prefix(){} // RVA: 0x7FFAC9102AE0
        public void set_Prefix(){} // RVA: 0x7FFAC2F87E80
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFAC300F9D0
        public void set_IsDeclaredInExternal(){} // RVA: 0x7FFAC300F9E0
        public void get_Presence(){} // RVA: 0x7FFAC3921980
        public void set_Presence(){} // RVA: 0x7FFAC41674D0
        public void get_MaxLength(){} // RVA: 0x7FFAC2F9C730
        public void set_MaxLength(){} // RVA: 0x7FFAC4248FC0
        public void get_MinLength(){} // RVA: 0x7FFAC2FC20E0
        public void set_MinLength(){} // RVA: 0x7FFAC42499F0
        public void get_SchemaType(){} // RVA: 0x7FFAC2F4F130
        public void set_SchemaType(){} // RVA: 0x7FFAC2F22E90
        public void get_Datatype(){} // RVA: 0x7FFAC31D95E0
        public void set_Datatype(){} // RVA: 0x7FFAC2F4F890
        public void AddValue(){} // RVA: 0x7FFAC9102B40
        public void get_Values(){} // RVA: 0x7FFAC2FE9500
        public void set_Values(){} // RVA: 0x7FFAC2FE9510
        public void get_DefaultValueRaw(){} // RVA: 0x7FFAC9102C80
        public void set_DefaultValueRaw(){} // RVA: 0x7FFAC31D0C20
        public void get_DefaultValueTyped(){} // RVA: 0x7FFAC2F9E740
        public void set_DefaultValueTyped(){} // RVA: 0x7FFAC2F49200
        public void CheckEnumeration(){} // RVA: 0x7FFAC9102CE0
        public void CheckValue(){} // RVA: 0x7FFAC9102DA0
    }

    public class SchemaElementDecl : SchemaDeclBase
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes; // 0x60
        public System.Collections.Generic.List`1<System.Xml.IDtdDefaultAttributeInfo> IsIdDeclared; // 0x68
        public bool HasNonCDataAttribute; // 0x70
        public bool IsAbstract; // 0x71
        public bool IsNillable; // 0x72
        public bool Block; // 0x73
        public bool IsNotationDeclared; // 0x74
        public bool HasDefaultAttribute; // 0x75
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> HasRequiredAttribute; // 0x78
        public System.Xml.Schema.ContentValidator ContentValidator; // 0x80
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute; // 0x88
        public 0x6B163E70 Constraints; // 0x90
        public System.Xml.Schema.CompiledIdentityConstraint[] SchemaElement; // 0x98
        public System.Xml.Schema.XmlSchemaElement DefaultAttDefs; // 0xA0
        public System.Xml.Schema.SchemaElementDecl AttDefs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91031D0 | overloaded x3
        public void CreateAnyTypeElementDecl(){} // RVA: 0x7FFAC9103350
        public void System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes(){} // RVA: 0x7FFAC82464C0
        public void System.Xml.IDtdAttributeListInfo.LookupAttribute(){} // RVA: 0x7FFAC9103470
        public void System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes(){} // RVA: 0x7FFAC2F9CD50
        public void get_IsIdDeclared(){} // RVA: 0x7FFAC2F9D320
        public void set_IsIdDeclared(){} // RVA: 0x7FFAC2F9D330
        public void get_HasNonCDataAttribute(){} // RVA: 0x7FFAC82464C0
        public void set_HasNonCDataAttribute(){} // RVA: 0x7FFAC82464D0
        public void Clone(){} // RVA: 0x7FFAC9103530
        public void get_IsAbstract(){} // RVA: 0x7FFAC82464E0
        public void set_IsAbstract(){} // RVA: 0x7FFAC82464F0
        public void get_IsNillable(){} // RVA: 0x7FFAC8AF20C0
        public void set_IsNillable(){} // RVA: 0x7FFAC9103590
        public void get_Block(){} // RVA: 0x7FFAC3220660
        public void set_Block(){} // RVA: 0x7FFAC34D2750
        public void get_IsNotationDeclared(){} // RVA: 0x7FFAC3C05B90
        public void set_IsNotationDeclared(){} // RVA: 0x7FFAC8B102D0
        public void get_HasDefaultAttribute(){} // RVA: 0x7FFAC3E01380
        public void get_HasRequiredAttribute(){} // RVA: 0x7FFAC3BCD8B0
        public void get_ContentValidator(){} // RVA: 0x7FFAC32EF410
        public void set_ContentValidator(){} // RVA: 0x7FFAC34D4AA0
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2F60010
        public void set_AnyAttribute(){} // RVA: 0x7FFAC354E300
        public void get_Constraints(){} // RVA: 0x7FFAC354DFB0
        public void set_Constraints(){} // RVA: 0x7FFAC354E3C0
        public void get_SchemaElement(){} // RVA: 0x7FFAC3543900
        public void set_SchemaElement(){} // RVA: 0x7FFAC354E420
        public void AddAttDef(){} // RVA: 0x7FFAC91035A0
        public void GetAttDef(){} // RVA: 0x7FFAC9103750
        public void get_DefaultAttDefs(){} // RVA: 0x7FFAC2F9CD50
        public void get_AttDefs(){} // RVA: 0x7FFAC2FBF370
        public void get_ProhibitedAttributes(){} // RVA: 0x7FFAC30E5600
        public void CheckAttributes(){} // RVA: 0x7FFAC91037D0
        public void .cctor(){} // RVA: 0x7FFAC9103B50
    }

    public class SchemaEntity : Object
    {
        public System.Xml.XmlQualifiedName System.Xml.IDtdEntityInfo.Name; // 0x10
        public string System.Xml.IDtdEntityInfo.IsExternal; // 0x18
        public string System.Xml.IDtdEntityInfo.IsDeclaredInExternal; // 0x20
        public string System.Xml.IDtdEntityInfo.IsUnparsedEntity; // 0x28
        public System.Xml.XmlQualifiedName System.Xml.IDtdEntityInfo.IsParameterEntity; // 0x30
        public int System.Xml.IDtdEntityInfo.BaseUriString; // 0x38
        public int System.Xml.IDtdEntityInfo.DeclaredUriString; // 0x3C
        public bool System.Xml.IDtdEntityInfo.SystemId; // 0x40
        public bool System.Xml.IDtdEntityInfo.PublicId; // 0x41
        public bool System.Xml.IDtdEntityInfo.Text; // 0x42
        public bool System.Xml.IDtdEntityInfo.LineNumber; // 0x43
        public string System.Xml.IDtdEntityInfo.LinePosition; // 0x48
        public string Name; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9103C00
        public void System.Xml.IDtdEntityInfo.get_Name(){} // RVA: 0x7FFAC3511350
        public void System.Xml.IDtdEntityInfo.get_IsExternal(){} // RVA: 0x7FFAC31D8A60
        public void System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal(){} // RVA: 0x7FFAC3FA0E90
        public void System.Xml.IDtdEntityInfo.get_IsUnparsedEntity(){} // RVA: 0x7FFAC9103D20
        public void System.Xml.IDtdEntityInfo.get_IsParameterEntity(){} // RVA: 0x7FFAC2FDCC00
        public void System.Xml.IDtdEntityInfo.get_BaseUriString(){} // RVA: 0x7FFAC9103D60
        public void System.Xml.IDtdEntityInfo.get_DeclaredUriString(){} // RVA: 0x7FFAC9103DC0
        public void System.Xml.IDtdEntityInfo.get_SystemId(){} // RVA: 0x7FFAC2F247C0
        public void System.Xml.IDtdEntityInfo.get_PublicId(){} // RVA: 0x7FFAC2F4F0C0
        public void System.Xml.IDtdEntityInfo.get_Text(){} // RVA: 0x7FFAC2F4F130
        public void System.Xml.IDtdEntityInfo.get_LineNumber(){} // RVA: 0x7FFAC358A870
        public void System.Xml.IDtdEntityInfo.get_LinePosition(){} // RVA: 0x7FFAC33BD4A0
        public void IsPredefinedEntity(){} // RVA: 0x7FFAC9103E20
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Url(){} // RVA: 0x7FFAC2F247C0
        public void set_Url(){} // RVA: 0x7FFAC9103FD0
        public void get_Pubid(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Pubid(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IsExternal(){} // RVA: 0x7FFAC31D8A60
        public void set_IsExternal(){} // RVA: 0x7FFAC31D8A10
        public void get_DeclaredInExternal(){} // RVA: 0x7FFAC3FA0E90
        public void set_DeclaredInExternal(){} // RVA: 0x7FFAC45A8320
        public void get_NData(){} // RVA: 0x7FFAC31D95E0
        public void set_NData(){} // RVA: 0x7FFAC2F4F890
        public void get_Text(){} // RVA: 0x7FFAC2F4F130
        public void set_Text(){} // RVA: 0x7FFAC9104030
        public void get_Line(){} // RVA: 0x7FFAC358A870
        public void set_Line(){} // RVA: 0x7FFAC3588350
        public void get_Pos(){} // RVA: 0x7FFAC33BD4A0
        public void set_Pos(){} // RVA: 0x7FFAC47E2CD0
        public void get_BaseURI(){} // RVA: 0x7FFAC9104090
        public void set_BaseURI(){} // RVA: 0x7FFAC2F9C740
        public void get_ParsingInProgress(){} // RVA: 0x7FFAC31D90A0
        public void set_ParsingInProgress(){} // RVA: 0x7FFAC31D9200
        public void get_DeclaredURI(){} // RVA: 0x7FFAC91040F0
        public void set_DeclaredURI(){} // RVA: 0x7FFAC30794D0
    }

    public class SchemaInfo : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> DocTypeName; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> InternalDtdSubset; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> ElementDecls; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> UndeclaredElementDecls; // 0x28
        public System.Xml.XmlQualifiedName GeneralEntities; // 0x30
        public string ParameterEntities; // 0x38
        public bool SchemaType; // 0x40
        public bool TargetNamespaces; // 0x41
        public System.Collections.Generic.Dictionary`2<string,bool> ElementDeclsByType; // 0x48
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> AttributeDecls; // 0x50
        public int Notations; // 0x58
        public 0x6B162F50 ErrorCount; // 0x5C
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> System.Xml.IDtdInfo.HasDefaultAttributes; // 0x60
        public System.Collections.Generic.Dictionary`2<string,System.Xml.Schema.SchemaNotation> System.Xml.IDtdInfo.HasNonCDataAttributes; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9104150
        public void get_DocTypeName(){} // RVA: 0x7FFAC31D95E0
        public void set_DocTypeName(){} // RVA: 0x7FFAC2F4F890
        public void set_InternalDtdSubset(){} // RVA: 0x7FFAC31D0C20
        public void get_ElementDecls(){} // RVA: 0x7FFAC2F3C380
        public void get_UndeclaredElementDecls(){} // RVA: 0x7FFAC2F247C0
        public void get_GeneralEntities(){} // RVA: 0x7FFAC9104530
        public void get_ParameterEntities(){} // RVA: 0x7FFAC91045F0
        public void get_SchemaType(){} // RVA: 0x7FFAC313CBA0
        public void set_SchemaType(){} // RVA: 0x7FFAC362EB40
        public void get_TargetNamespaces(){} // RVA: 0x7FFAC2F9C730
        public void get_ElementDeclsByType(){} // RVA: 0x7FFAC2FBF370
        public void get_AttributeDecls(){} // RVA: 0x7FFAC2FC20E0
        public void get_Notations(){} // RVA: 0x7FFAC91046B0
        public void get_ErrorCount(){} // RVA: 0x7FFAC362EA40
        public void set_ErrorCount(){} // RVA: 0x7FFAC362EA00
        public void GetElementDecl(){} // RVA: 0x7FFAC9104770
        public void GetTypeDecl(){} // RVA: 0x7FFAC91047F0
        public void GetElement(){} // RVA: 0x7FFAC9104870
        public void HasSchema(){} // RVA: 0x7FFAC91048A0
        public void Contains(){} // RVA: 0x7FFAC9104920
        public void GetAttributeXdr(){} // RVA: 0x7FFAC91049A0
        public void GetAttributeXsd(){} // RVA: 0x7FFAC9104E40 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC9104F90
        public void Finish(){} // RVA: 0x7FFAC9105DA0
        public void System.Xml.IDtdInfo.get_HasDefaultAttributes(){} // RVA: 0x7FFAC31D8A60
        public void System.Xml.IDtdInfo.get_HasNonCDataAttributes(){} // RVA: 0x7FFAC2FDCC00
        public void System.Xml.IDtdInfo.LookupAttributeList(){} // RVA: 0x7FFAC9105FA0
        public void System.Xml.IDtdInfo.LookupEntity(){} // RVA: 0x7FFAC9106080
        public void System.Xml.IDtdInfo.get_Name(){} // RVA: 0x7FFAC31D95E0
        public void System.Xml.IDtdInfo.get_InternalDtdSubset(){} // RVA: 0x7FFAC31D0140
    }

    public class SchemaNames : Object
    {
        public System.Xml.XmlNameTable nameTable; // 0x10
        public string NsDataType; // 0x18
        public string NsDataTypeAlias; // 0x20
        public string NsDataTypeOld; // 0x28
        public string NsXml; // 0x30
        public string NsXmlNs; // 0x38
        public string NsXdr; // 0x40
        public string NsXdrAlias; // 0x48
        public string NsXs; // 0x50
        public string NsXsi; // 0x58
        public string XsiType; // 0x60
        public string XsiNil; // 0x68
        public string XsiSchemaLocation; // 0x70
        public string XsiNoNamespaceSchemaLocation; // 0x78
        public string XsdSchema; // 0x80
        public string XdrSchema; // 0x88
        public System.Xml.XmlQualifiedName QnPCData; // 0x90
        public System.Xml.XmlQualifiedName QnXml; // 0x98
        public System.Xml.XmlQualifiedName QnXmlNs; // 0xA0
        public System.Xml.XmlQualifiedName QnDtDt; // 0xA8
        public System.Xml.XmlQualifiedName QnXmlLang; // 0xB0
        public System.Xml.XmlQualifiedName QnName; // 0xB8
        public System.Xml.XmlQualifiedName QnType; // 0xC0
        public System.Xml.XmlQualifiedName QnMaxOccurs; // 0xC8
        public System.Xml.XmlQualifiedName QnMinOccurs; // 0xD0
        public System.Xml.XmlQualifiedName QnInfinite; // 0xD8
        public System.Xml.XmlQualifiedName QnModel; // 0xE0
        public System.Xml.XmlQualifiedName QnOpen; // 0xE8
        public System.Xml.XmlQualifiedName QnClosed; // 0xF0
        public System.Xml.XmlQualifiedName QnContent; // 0xF8
        public System.Xml.XmlQualifiedName QnMixed; // 0x100
        public System.Xml.XmlQualifiedName QnEmpty; // 0x108
        public System.Xml.XmlQualifiedName QnEltOnly; // 0x110
        public System.Xml.XmlQualifiedName QnTextOnly; // 0x118
        public System.Xml.XmlQualifiedName QnOrder; // 0x120
        public System.Xml.XmlQualifiedName QnSeq; // 0x128
        public System.Xml.XmlQualifiedName QnOne; // 0x130
        public System.Xml.XmlQualifiedName QnMany; // 0x138
        public System.Xml.XmlQualifiedName QnRequired; // 0x140
        public System.Xml.XmlQualifiedName QnYes; // 0x148
        public System.Xml.XmlQualifiedName QnNo; // 0x150
        public System.Xml.XmlQualifiedName QnString; // 0x158
        public System.Xml.XmlQualifiedName QnID; // 0x160
        public System.Xml.XmlQualifiedName QnIDRef; // 0x168
        public System.Xml.XmlQualifiedName QnIDRefs; // 0x170
        public System.Xml.XmlQualifiedName QnEntity; // 0x178
        public System.Xml.XmlQualifiedName QnEntities; // 0x180
        public System.Xml.XmlQualifiedName QnNmToken; // 0x188
        public System.Xml.XmlQualifiedName QnNmTokens; // 0x190
        public System.Xml.XmlQualifiedName QnEnumeration; // 0x198
        public System.Xml.XmlQualifiedName QnDefault; // 0x1A0
        public System.Xml.XmlQualifiedName QnXdrSchema; // 0x1A8
        public System.Xml.XmlQualifiedName QnXdrElementType; // 0x1B0
        public System.Xml.XmlQualifiedName QnXdrElement; // 0x1B8
        public System.Xml.XmlQualifiedName QnXdrGroup; // 0x1C0
        public System.Xml.XmlQualifiedName QnXdrAttributeType; // 0x1C8
        public System.Xml.XmlQualifiedName QnXdrAttribute; // 0x1D0
        public System.Xml.XmlQualifiedName QnXdrDataType; // 0x1D8
        public System.Xml.XmlQualifiedName QnXdrDescription; // 0x1E0
        public System.Xml.XmlQualifiedName QnXdrExtends; // 0x1E8
        public System.Xml.XmlQualifiedName QnXdrAliasSchema; // 0x1F0
        public System.Xml.XmlQualifiedName QnDtType; // 0x1F8
        public System.Xml.XmlQualifiedName QnDtValues; // 0x200
        public System.Xml.XmlQualifiedName QnDtMaxLength; // 0x208
        public System.Xml.XmlQualifiedName QnDtMinLength; // 0x210
        public System.Xml.XmlQualifiedName QnDtMax; // 0x218
        public System.Xml.XmlQualifiedName QnDtMin; // 0x220
        public System.Xml.XmlQualifiedName QnDtMinExclusive; // 0x228
        public System.Xml.XmlQualifiedName QnDtMaxExclusive; // 0x230
        public System.Xml.XmlQualifiedName QnTargetNamespace; // 0x238
        public System.Xml.XmlQualifiedName QnVersion; // 0x240
        public System.Xml.XmlQualifiedName QnFinalDefault; // 0x248
        public System.Xml.XmlQualifiedName QnBlockDefault; // 0x250
        public System.Xml.XmlQualifiedName QnFixed; // 0x258
        public System.Xml.XmlQualifiedName QnAbstract; // 0x260
        public System.Xml.XmlQualifiedName QnBlock; // 0x268
        public System.Xml.XmlQualifiedName QnSubstitutionGroup; // 0x270
        public System.Xml.XmlQualifiedName QnFinal; // 0x278
        public System.Xml.XmlQualifiedName QnNillable; // 0x280
        public System.Xml.XmlQualifiedName QnRef; // 0x288
        public System.Xml.XmlQualifiedName QnBase; // 0x290
        public System.Xml.XmlQualifiedName QnDerivedBy; // 0x298
        public System.Xml.XmlQualifiedName QnNamespace; // 0x2A0
        public System.Xml.XmlQualifiedName QnProcessContents; // 0x2A8
        public System.Xml.XmlQualifiedName QnRefer; // 0x2B0
        public System.Xml.XmlQualifiedName QnPublic; // 0x2B8
        public System.Xml.XmlQualifiedName QnSystem; // 0x2C0
        public System.Xml.XmlQualifiedName QnSchemaLocation; // 0x2C8
        public System.Xml.XmlQualifiedName QnValue; // 0x2D0
        public System.Xml.XmlQualifiedName QnUse; // 0x2D8
        public System.Xml.XmlQualifiedName QnForm; // 0x2E0
        public System.Xml.XmlQualifiedName QnElementFormDefault; // 0x2E8
        public System.Xml.XmlQualifiedName QnAttributeFormDefault; // 0x2F0
        public System.Xml.XmlQualifiedName QnItemType; // 0x2F8
        public System.Xml.XmlQualifiedName QnMemberTypes; // 0x300
        public System.Xml.XmlQualifiedName QnXPath; // 0x308
        public System.Xml.XmlQualifiedName QnXsdSchema; // 0x310
        public System.Xml.XmlQualifiedName QnXsdAnnotation; // 0x318
        public System.Xml.XmlQualifiedName QnXsdInclude; // 0x320
        public System.Xml.XmlQualifiedName QnXsdImport; // 0x328
        public System.Xml.XmlQualifiedName QnXsdElement; // 0x330
        public System.Xml.XmlQualifiedName QnXsdAttribute; // 0x338
        public System.Xml.XmlQualifiedName QnXsdAttributeGroup; // 0x340
        public System.Xml.XmlQualifiedName QnXsdAnyAttribute; // 0x348
        public System.Xml.XmlQualifiedName QnXsdGroup; // 0x350
        public System.Xml.XmlQualifiedName QnXsdAll; // 0x358
        public System.Xml.XmlQualifiedName QnXsdChoice; // 0x360
        public System.Xml.XmlQualifiedName QnXsdSequence; // 0x368
        public System.Xml.XmlQualifiedName QnXsdAny; // 0x370
        public System.Xml.XmlQualifiedName QnXsdNotation; // 0x378
        public System.Xml.XmlQualifiedName QnXsdSimpleType; // 0x380
        public System.Xml.XmlQualifiedName QnXsdComplexType; // 0x388
        public System.Xml.XmlQualifiedName QnXsdUnique; // 0x390
        public System.Xml.XmlQualifiedName QnXsdKey; // 0x398
        public System.Xml.XmlQualifiedName QnXsdKeyRef; // 0x3A0
        public System.Xml.XmlQualifiedName QnXsdSelector; // 0x3A8
        public System.Xml.XmlQualifiedName QnXsdField; // 0x3B0
        public System.Xml.XmlQualifiedName QnXsdMinExclusive; // 0x3B8
        public System.Xml.XmlQualifiedName QnXsdMinInclusive; // 0x3C0
        public System.Xml.XmlQualifiedName QnXsdMaxInclusive; // 0x3C8
        public System.Xml.XmlQualifiedName QnXsdMaxExclusive; // 0x3D0
        public System.Xml.XmlQualifiedName QnXsdTotalDigits; // 0x3D8
        public System.Xml.XmlQualifiedName QnXsdFractionDigits; // 0x3E0
        public System.Xml.XmlQualifiedName QnXsdLength; // 0x3E8
        public System.Xml.XmlQualifiedName QnXsdMinLength; // 0x3F0
        public System.Xml.XmlQualifiedName QnXsdMaxLength; // 0x3F8
        public System.Xml.XmlQualifiedName QnXsdEnumeration; // 0x400
        public System.Xml.XmlQualifiedName QnXsdPattern; // 0x408
        public System.Xml.XmlQualifiedName QnXsdDocumentation; // 0x410
        public System.Xml.XmlQualifiedName QnXsdAppinfo; // 0x418
        public System.Xml.XmlQualifiedName QnSource; // 0x420
        public System.Xml.XmlQualifiedName QnXsdComplexContent; // 0x428
        public System.Xml.XmlQualifiedName QnXsdSimpleContent; // 0x430
        public System.Xml.XmlQualifiedName QnXsdRestriction; // 0x438
        public System.Xml.XmlQualifiedName QnXsdExtension; // 0x440
        public System.Xml.XmlQualifiedName QnXsdUnion; // 0x448
        public System.Xml.XmlQualifiedName QnXsdList; // 0x450
        public System.Xml.XmlQualifiedName QnXsdWhiteSpace; // 0x458
        public System.Xml.XmlQualifiedName QnXsdRedefine; // 0x460
        public System.Xml.XmlQualifiedName QnXsdAnyType; // 0x468
        public System.Xml.XmlQualifiedName[] TokenToQName; // 0x470

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9106150
        public void CreateTokenToQNameTable(){} // RVA: 0x7FFAC9109DB0
        public void SchemaTypeFromRoot(){} // RVA: 0x7FFAC910C670
        public void IsXSDRoot(){} // RVA: 0x7FFAC910C7E0
        public void IsXDRRoot(){} // RVA: 0x7FFAC910C890
    }

    public class SchemaNamespaceManager : XmlNamespaceManager
    {
        public System.Xml.Schema.XmlSchemaObject node; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC30794D0
        public void LookupNamespace(){} // RVA: 0x7FFAC910C940
        public void LookupPrefix(){} // RVA: 0x7FFAC910CAE0
    }

    public class SchemaNotation : Object
    {
        public System.Xml.XmlQualifiedName Name; // 0x10
        public string SystemLiteral; // 0x18
        public string Pubid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_SystemLiteral(){} // RVA: 0x7FFAC2F247C0
        public void set_SystemLiteral(){} // RVA: 0x7FFAC2F87E80
        public void get_Pubid(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Pubid(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class SelectorActiveAxis : ActiveAxis
    {
        public System.Xml.Schema.ConstraintStruct lastDepth; // 0x28
        public System.Collections.ArrayList KSs; // 0x30
        public int KSpointer; // 0x38

        // ── Methods ──
        public void get_lastDepth(){} // RVA: 0x7FFAC926D7A0
        public void .ctor(){} // RVA: 0x7FFAC926D850
        public void EndElement(){} // RVA: 0x7FFAC926D970
        public void PushKS(){} // RVA: 0x7FFAC926DB60
        public void PopKS(){} // RVA: 0x7FFAC926E150
    }

    public class SequenceNode : InteriorNode
    {
        public object IsNullable;

        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFAC9271900
        public void get_IsNullable(){} // RVA: 0x7FFAC9272320
        public void ExpandTree(){} // RVA: 0x7FFAC9272510
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StarNode : InteriorNode
    {
        public object IsNullable;

        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFAC9272AA0
        public void get_IsNullable(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StateUnion : ValueType
    {
        public int State; // 0x10
        public int AllElementsRequired; // 0x10
        public int CurPosIndex; // 0x10
        public int NumberOfRunningPos; // 0x10
    }

    public class StringFacetsChecker : FacetsChecker
    {
        public System.Text.RegularExpressions.Regex LanguagePattern;

        // ── Methods ──
        public void get_LanguagePattern(){} // RVA: 0x7FFAC929EEF0
        public void CheckValueFacets(){} // RVA: 0x7FFAC929F0A0 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x7FFAC929F3B0 | overloaded x2
        public void CheckBuiltInFacets(){} // RVA: 0x7FFAC929F620
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SymbolsDictionary : Object
    {
        public int Count; // 0x10
        public System.Collections.Hashtable IsUpaEnforced; // 0x18
        public System.Collections.Hashtable Item; // 0x20
        public System.Collections.ArrayList particles; // 0x28
        public object particleLast; // 0x30
        public bool isUpaEnforced; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC926FA40
        public void get_Count(){} // RVA: 0x7FFAC926FB90
        public void get_IsUpaEnforced(){} // RVA: 0x7FFAC31D95D0
        public void set_IsUpaEnforced(){} // RVA: 0x7FFAC31D95C0
        public void AddName(){} // RVA: 0x7FFAC926FBA0
        public void AddNamespaceList(){} // RVA: 0x7FFAC926FCE0
        public void AddWildcard(){} // RVA: 0x7FFAC926FFD0
        public void GetNamespaceListSymbols(){} // RVA: 0x7FFAC9270190
        public void get_Item(){} // RVA: 0x7FFAC9270830
        public void Exists(){} // RVA: 0x7FFAC9270930
        public void GetParticle(){} // RVA: 0x7FFAC9270970
        public void NameOf(){} // RVA: 0x7FFAC92709B0
    }

    public class SyntaxTreeNode : Object
    {
        public object IsNullable;
        public object IsRangeNode;

        // ── Methods ──
        public void ExpandTree(){} // RVA: 0x7FFAC2C7AF60
        public void ConstructPos(){} // RVA: 0x7FFAC2C7AF60
        public void get_IsNullable(){} // RVA: 0x7FFAC2C59D00
        public void get_IsRangeNode(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}