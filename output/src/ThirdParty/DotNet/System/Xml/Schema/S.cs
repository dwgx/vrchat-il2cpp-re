// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 18
// Methods: 325

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class SchemaAttDef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x694BB30 | overloaded x3
        public void System.Xml.IDtdAttributeInfo.get_Prefix(){} // RVA: 0x694BB40
        public void System.Xml.IDtdAttributeInfo.get_LocalName(){} // RVA: 0xB2ECF0
        public void System.Xml.IDtdAttributeInfo.get_LineNumber(){} // RVA: 0x1C91440
        public void System.Xml.IDtdAttributeInfo.get_LinePosition(){} // RVA: 0x1C91460
        public void System.Xml.IDtdAttributeInfo.get_IsNonCDataType(){} // RVA: 0x694BBA0
        public void System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal(){} // RVA: 0x3CB9D0
        public void System.Xml.IDtdAttributeInfo.get_IsXmlAttribute(){} // RVA: 0x694BBD0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded(){} // RVA: 0x694BBE0
        public void System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped(){} // RVA: 0x35A740
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber(){} // RVA: 0x10E5CF0
        public void System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition(){} // RVA: 0x1929080
        public void get_LinePosition(){} // RVA: 0x1C91460
        public void set_LinePosition(){} // RVA: 0x1C91470
        public void get_LineNumber(){} // RVA: 0x1C91440
        public void set_LineNumber(){} // RVA: 0x1C91450
        public void get_ValueLinePosition(){} // RVA: 0x1929080
        public void set_ValueLinePosition(){} // RVA: 0x1D8D640
        public void get_ValueLineNumber(){} // RVA: 0x10E5CF0
        public void set_ValueLineNumber(){} // RVA: 0x475080
        public void get_DefaultValueExpanded(){} // RVA: 0x694BC40
        public void set_DefaultValueExpanded(){} // RVA: 0x37B380
        public void get_TokenizedType(){} // RVA: 0x1BE2A10
        public void set_TokenizedType(){} // RVA: 0x694BCA0
        public void get_Reserved(){} // RVA: 0x1AE3800
        public void set_Reserved(){} // RVA: 0x1AE6D80
        public void get_DefaultValueChecked(){} // RVA: 0x8A89C0
        public void get_SchemaAttribute(){} // RVA: 0x462D00
        public void set_SchemaAttribute(){} // RVA: 0x464450
        public void CheckXmlSpace(){} // RVA: 0x694BD10
        public void Clone(){} // RVA: 0x694C0A0
        public void .cctor(){} // RVA: 0x694C100
    }

    public class SchemaBuilder
    {
        // ── Methods ──
        public void ProcessElement(){}
        public void ProcessAttribute(){} // RVA: 0x2F9F0
        public void IsContentParsed(){} // RVA: 0xDBE0
        public void ProcessMarkup(){} // RVA: 0x24B10
        public void ProcessCData(){} // RVA: 0x24B10
        public void StartChildren(){} // RVA: 0x24A50
        public void EndChildren(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SchemaCollectionCompiler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x694C1B0
        public void Execute(){} // RVA: 0x694C310
        public void Prepare(){} // RVA: 0x694C3C0
        public void Cleanup(){} // RVA: 0x694D570 | overloaded x2
        public void Compile(){} // RVA: 0x694E0D0
        public void Output(){} // RVA: 0x694FDD0
        public void CleanupAttribute(){} // RVA: 0x6950CC0
        public void CleanupAttributeGroup(){} // RVA: 0x6950DA0
        public void CleanupComplexType(){} // RVA: 0x6950E30
        public void CleanupSimpleType(){} // RVA: 0x6951380
        public void CleanupElement(){} // RVA: 0x69513F0
        public void CleanupAttributes(){} // RVA: 0x69516E0
        public void CleanupGroup(){} // RVA: 0x69517D0
        public void CleanupParticle(){} // RVA: 0x6951850
        public void CompileSubstitutionGroup(){} // RVA: 0x6951A70
        public void CheckSubstitutionGroup(){} // RVA: 0x6952080
        public void CompileGroup(){} // RVA: 0x69522D0
        public void CompileSimpleType(){} // RVA: 0x6952410
        public void CompileBaseMemberTypes(){} // RVA: 0x6953040
        public void CheckUnionType(){} // RVA: 0x6953500
        public void CompileComplexType(){} // RVA: 0x6953650
        public void CompileSimpleContentExtension(){} // RVA: 0x69544C0
        public void CompileSimpleContentRestriction(){} // RVA: 0x6954800
        public void CompileComplexContentExtension(){} // RVA: 0x6954CD0
        public void CompileComplexContentRestriction(){} // RVA: 0x6955300
        public void CheckParticleDerivation(){} // RVA: 0x69557C0
        public void CompileContentTypeParticle(){} // RVA: 0x69558D0
        public void CannonicalizeParticle(){} // RVA: 0x6955AF0
        public void CannonicalizeElement(){} // RVA: 0x6955E50
        public void CannonicalizeGroupRef(){} // RVA: 0x6956020
        public void CannonicalizeAll(){} // RVA: 0x6956830
        public void CannonicalizeChoice(){} // RVA: 0x6956F60
        public void CannonicalizeSequence(){} // RVA: 0x69577D0
        public void IsValidRestriction(){} // RVA: 0x6957FB0
        public void IsElementFromElement(){} // RVA: 0x6958AE0
        public void IsElementFromAny(){} // RVA: 0x6958CE0
        public void IsAnyFromAny(){} // RVA: 0x6958D70
        public void IsGroupBaseFromAny(){} // RVA: 0x6958DD0
        public void IsElementFromGroupBase(){} // RVA: 0x6959140
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x69595B0
        public void IsSequenceFromAll(){} // RVA: 0x69598F0
        public void IsSequenceFromChoice(){} // RVA: 0x6959CE0
        public void CalculateSequenceRange(){} // RVA: 0x695A050
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x695A7F0 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x695A940
        public void IsParticleEmptiable(){} // RVA: 0x695AA60
        public void CalculateEffectiveTotalRange(){} // RVA: 0x695AB70
        public void PushComplexType(){} // RVA: 0x695B890
        public void GetSchemaContentType(){} // RVA: 0x695B8C0
        public void CompileAttributeGroup(){} // RVA: 0x695B940
        public void CompileLocalAttributes(){} // RVA: 0x695C090
        public void CompileAnyAttributeUnion(){} // RVA: 0x695D230
        public void CompileAnyAttributeIntersection(){} // RVA: 0x695D2E0
        public void CompileAttribute(){} // RVA: 0x695D390
        public void CompileIdentityConstraint(){} // RVA: 0x695DF10
        public void CompileElement(){} // RVA: 0x695E640
        public void CompileComplexContent(){} // RVA: 0x695F590
        public void BuildParticleContentModel(){} // RVA: 0x6960390
        public void CompileParticleElements(){} // RVA: 0x6960C50
        public void CompileCompexTypeElements(){} // RVA: 0x6960F70
        public void GetSimpleType(){} // RVA: 0x6961050
        public void GetComplexType(){} // RVA: 0x69611D0
        public void GetAnySchemaType(){} // RVA: 0x69612A0
    }

    public class SchemaCollectionPreprocessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6961480
        public void Execute(){} // RVA: 0x6961490
        public void Cleanup(){} // RVA: 0x69617F0
        public void set_XmlResolver(){} // RVA: 0x464450
        public void LoadExternals(){} // RVA: 0x6961DA0
        public void BuildRefNamespaces(){} // RVA: 0x6962A30
        public void Preprocess(){} // RVA: 0x6962CE0
        public void PreprocessRedefine(){} // RVA: 0x6964C30
        public void CountGroupSelfReference(){} // RVA: 0x6965EA0
        public void CheckRefinedGroup(){} // RVA: 0x6966240
        public void CheckRefinedAttributeGroup(){} // RVA: 0x69662E0
        public void CheckRefinedSimpleType(){} // RVA: 0x6966470
        public void CheckRefinedComplexType(){} // RVA: 0x69665C0
        public void PreprocessAttribute(){} // RVA: 0x6966A60
        public void PreprocessLocalAttribute(){} // RVA: 0x6966C40
        public void PreprocessAttributeContent(){} // RVA: 0x6966F00
        public void PreprocessAttributeGroup(){} // RVA: 0x6967240
        public void PreprocessElement(){} // RVA: 0x69673B0
        public void PreprocessLocalElement(){} // RVA: 0x69676A0
        public void PreprocessElementContent(){} // RVA: 0x6967BD0
        public void PreprocessIdentityConstraint(){} // RVA: 0x69680F0
        public void PreprocessSimpleType(){} // RVA: 0x6968610
        public void PreprocessComplexType(){} // RVA: 0x6968FD0
        public void PreprocessGroup(){} // RVA: 0x6969D80
        public void PreprocessNotation(){} // RVA: 0x6969FC0
        public void PreprocessParticle(){} // RVA: 0x696A200
        public void PreprocessAttributes(){} // RVA: 0x696AF70
        public void ValidateIdAttribute(){} // RVA: 0x696B410
        public void ValidateNameAttribute(){} // RVA: 0x696B640
        public void ValidateQNameAttribute(){} // RVA: 0x696B970
        public void SetParent(){} // RVA: 0x694B880
        public void PreprocessAnnotation(){} // RVA: 0x696BA90
        public void ResolveSchemaLocationUri(){} // RVA: 0x696BC20
        public void GetSchemaEntity(){} // RVA: 0x696BC70
    }

    public class SchemaDeclBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x696BF10 | overloaded x2
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Prefix(){} // RVA: 0x696BFC0
        public void set_Prefix(){} // RVA: 0x343E80
        public void get_IsDeclaredInExternal(){} // RVA: 0x3CB9D0
        public void set_IsDeclaredInExternal(){} // RVA: 0x3CB9E0
        public void get_Presence(){} // RVA: 0xCEF5B0
        public void set_Presence(){} // RVA: 0x16E1F00
        public void get_MaxLength(){} // RVA: 0x358730
        public void set_MaxLength(){} // RVA: 0x179D760
        public void get_MinLength(){} // RVA: 0x37E0E0
        public void set_MinLength(){} // RVA: 0x4C4D50
        public void get_SchemaType(){} // RVA: 0x30B130
        public void set_SchemaType(){} // RVA: 0x2DEE90
        public void get_Datatype(){} // RVA: 0x6374D0
        public void set_Datatype(){} // RVA: 0x30B890
        public void AddValue(){} // RVA: 0x696C020
        public void get_Values(){} // RVA: 0x3A5500
        public void set_Values(){} // RVA: 0x3A5510
        public void get_DefaultValueRaw(){} // RVA: 0x696C160
        public void set_DefaultValueRaw(){} // RVA: 0x49B830
        public void get_DefaultValueTyped(){} // RVA: 0x35A740
        public void set_DefaultValueTyped(){} // RVA: 0x305200
        public void CheckEnumeration(){} // RVA: 0x696C1C0
        public void CheckValue(){} // RVA: 0x696C280
    }

    public class SchemaElementDecl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x696C6B0 | overloaded x3
        public void CreateAnyTypeElementDecl(){} // RVA: 0x696C830
        public void System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes(){} // RVA: 0x5AAEFD0
        public void System.Xml.IDtdAttributeListInfo.LookupAttribute(){} // RVA: 0x696C950
        public void System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes(){} // RVA: 0x358D50
        public void get_IsIdDeclared(){} // RVA: 0x359320
        public void set_IsIdDeclared(){} // RVA: 0x359330
        public void get_HasNonCDataAttribute(){} // RVA: 0x5AAEFD0
        public void set_HasNonCDataAttribute(){} // RVA: 0x5AAEFE0
        public void Clone(){} // RVA: 0x696CA10
        public void get_IsAbstract(){} // RVA: 0x5AAEFF0
        public void set_IsAbstract(){} // RVA: 0x5AAF000
        public void get_IsNillable(){} // RVA: 0x635AD00
        public void set_IsNillable(){} // RVA: 0x696CA70
        public void get_Block(){} // RVA: 0x6AFD40
        public void set_Block(){} // RVA: 0xF02F80
        public void get_IsNotationDeclared(){} // RVA: 0x115F200
        public void set_IsNotationDeclared(){} // RVA: 0x6378F10
        public void get_HasDefaultAttribute(){} // RVA: 0x1348BF0
        public void get_HasRequiredAttribute(){} // RVA: 0x1120170
        public void get_ContentValidator(){} // RVA: 0x462D00
        public void set_ContentValidator(){} // RVA: 0x464450
        public void get_AnyAttribute(){} // RVA: 0x31C010
        public void set_AnyAttribute(){} // RVA: 0x463060
        public void get_Constraints(){} // RVA: 0xA1C8C0
        public void set_Constraints(){} // RVA: 0x9AA650
        public void get_SchemaElement(){} // RVA: 0xA085E0
        public void set_SchemaElement(){} // RVA: 0x9AA5F0
        public void AddAttDef(){} // RVA: 0x696CA80
        public void GetAttDef(){} // RVA: 0x696CC30
        public void get_DefaultAttDefs(){} // RVA: 0x358D50
        public void get_AttDefs(){} // RVA: 0x37B370
        public void get_ProhibitedAttributes(){} // RVA: 0x4C7C50
        public void CheckAttributes(){} // RVA: 0x696CCB0
        public void .cctor(){} // RVA: 0x696D030
    }

    public class SchemaEntity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x696D0E0
        public void System.Xml.IDtdEntityInfo.get_Name(){} // RVA: 0xB2ECF0
        public void System.Xml.IDtdEntityInfo.get_IsExternal(){} // RVA: 0x65EEC0
        public void System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal(){} // RVA: 0x1514560
        public void System.Xml.IDtdEntityInfo.get_IsUnparsedEntity(){} // RVA: 0x696D200
        public void System.Xml.IDtdEntityInfo.get_IsParameterEntity(){} // RVA: 0x398C00
        public void System.Xml.IDtdEntityInfo.get_BaseUriString(){} // RVA: 0x696D240
        public void System.Xml.IDtdEntityInfo.get_DeclaredUriString(){} // RVA: 0x696D2A0
        public void System.Xml.IDtdEntityInfo.get_SystemId(){} // RVA: 0x2E07C0
        public void System.Xml.IDtdEntityInfo.get_PublicId(){} // RVA: 0x30B0C0
        public void System.Xml.IDtdEntityInfo.get_Text(){} // RVA: 0x30B130
        public void System.Xml.IDtdEntityInfo.get_LineNumber(){} // RVA: 0xFDC9F0
        public void System.Xml.IDtdEntityInfo.get_LinePosition(){} // RVA: 0x891AF0
        public void IsPredefinedEntity(){} // RVA: 0x696D300
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Url(){} // RVA: 0x2E07C0
        public void set_Url(){} // RVA: 0x696D4B0
        public void get_Pubid(){} // RVA: 0x30B0C0
        public void set_Pubid(){} // RVA: 0x30B0D0
        public void get_IsExternal(){} // RVA: 0x65EEC0
        public void set_IsExternal(){} // RVA: 0x65EEB0
        public void get_DeclaredInExternal(){} // RVA: 0x1514560
        public void set_DeclaredInExternal(){} // RVA: 0x1AF8C50
        public void get_NData(){} // RVA: 0x6374D0
        public void set_NData(){} // RVA: 0x30B890
        public void get_Text(){} // RVA: 0x30B130
        public void set_Text(){} // RVA: 0x696D510
        public void get_Line(){} // RVA: 0xFDC9F0
        public void set_Line(){} // RVA: 0xFDD6E0
        public void get_Pos(){} // RVA: 0x891AF0
        public void set_Pos(){} // RVA: 0x1CB95F0
        public void get_BaseURI(){} // RVA: 0x696D570
        public void set_BaseURI(){} // RVA: 0x358740
        public void get_ParsingInProgress(){} // RVA: 0x65F560
        public void set_ParsingInProgress(){} // RVA: 0x65F1B0
        public void get_DeclaredURI(){} // RVA: 0x696D5D0
        public void set_DeclaredURI(){} // RVA: 0x4354D0
    }

    public class SchemaInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x696D630
        public void get_DocTypeName(){} // RVA: 0x6374D0
        public void set_DocTypeName(){} // RVA: 0x30B890
        public void set_InternalDtdSubset(){} // RVA: 0x49B830
        public void get_ElementDecls(){} // RVA: 0x2F8380
        public void get_UndeclaredElementDecls(){} // RVA: 0x2E07C0
        public void get_GeneralEntities(){} // RVA: 0x696DA10
        public void get_ParameterEntities(){} // RVA: 0x696DAD0
        public void get_SchemaType(){} // RVA: 0x5A54D0
        public void set_SchemaType(){} // RVA: 0x9EACA0
        public void get_TargetNamespaces(){} // RVA: 0x358730
        public void get_ElementDeclsByType(){} // RVA: 0x37B370
        public void get_AttributeDecls(){} // RVA: 0x37E0E0
        public void get_Notations(){} // RVA: 0x696DB90
        public void get_ErrorCount(){} // RVA: 0x9EAB90
        public void set_ErrorCount(){} // RVA: 0x9EAAE0
        public void GetElementDecl(){} // RVA: 0x696DC50
        public void GetTypeDecl(){} // RVA: 0x696DCD0
        public void GetElement(){} // RVA: 0x696DD50
        public void HasSchema(){} // RVA: 0x696DD80
        public void Contains(){} // RVA: 0x696DE00
        public void GetAttributeXdr(){} // RVA: 0x696DE80
        public void GetAttributeXsd(){} // RVA: 0x696E320 | overloaded x2
        public void Add(){} // RVA: 0x696E470
        public void Finish(){} // RVA: 0x696F280
        public void System.Xml.IDtdInfo.get_HasDefaultAttributes(){} // RVA: 0x65EEC0
        public void System.Xml.IDtdInfo.get_HasNonCDataAttributes(){} // RVA: 0x398C00
        public void System.Xml.IDtdInfo.LookupAttributeList(){} // RVA: 0x696F480
        public void System.Xml.IDtdInfo.LookupEntity(){} // RVA: 0x696F560
        public void System.Xml.IDtdInfo.get_Name(){} // RVA: 0x6374D0
        public void System.Xml.IDtdInfo.get_InternalDtdSubset(){} // RVA: 0x4976A0
    }

    public class SchemaNames
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x696F630
        public void CreateTokenToQNameTable(){} // RVA: 0x6973290
        public void SchemaTypeFromRoot(){} // RVA: 0x6975B50
        public void IsXSDRoot(){} // RVA: 0x6975CC0
        public void IsXDRRoot(){} // RVA: 0x6975D70
    }

    public class SchemaNamespaceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4354D0
        public void LookupNamespace(){} // RVA: 0x6975E20
        public void LookupPrefix(){} // RVA: 0x6975FC0
    }

    public class SchemaNotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Name(){} // RVA: 0x2F8380
        public void get_SystemLiteral(){} // RVA: 0x2E07C0
        public void set_SystemLiteral(){} // RVA: 0x343E80
        public void get_Pubid(){} // RVA: 0x30B0C0
        public void set_Pubid(){} // RVA: 0x30B0D0
    }

    public class SelectorActiveAxis
    {
        // ── Methods ──
        public void get_lastDepth(){} // RVA: 0x6AD6C20
        public void .ctor(){} // RVA: 0x6AD6CD0
        public void EndElement(){} // RVA: 0x6AD6DF0
        public void PushKS(){} // RVA: 0x6AD6FE0
        public void PopKS(){} // RVA: 0x6AD75D0
    }

    public class SequenceNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x6ADAD80
        public void get_IsNullable(){} // RVA: 0x6ADB7A0
        public void ExpandTree(){} // RVA: 0x6ADB990
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StarNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x6ADBF20
        public void get_IsNullable(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StateUnion
    {
    }

    public class StringFacetsChecker
    {
        // ── Methods ──
        public void get_LanguagePattern(){} // RVA: 0x6B08370
        public void CheckValueFacets(){} // RVA: 0x6B08520 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x6B08830 | overloaded x2
        public void CheckBuiltInFacets(){} // RVA: 0x6B08AA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SymbolsDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AD8EC0
        public void get_Count(){} // RVA: 0x6AD9010
        public void get_IsUpaEnforced(){} // RVA: 0x4A6500
        public void set_IsUpaEnforced(){} // RVA: 0x4A78C0
        public void AddName(){} // RVA: 0x6AD9020
        public void AddNamespaceList(){} // RVA: 0x6AD9160
        public void AddWildcard(){} // RVA: 0x6AD9450
        public void GetNamespaceListSymbols(){} // RVA: 0x6AD9610
        public void get_Item(){} // RVA: 0x6AD9CB0
        public void Exists(){} // RVA: 0x6AD9DB0
        public void GetParticle(){} // RVA: 0x6AD9DF0
        public void NameOf(){} // RVA: 0x6AD9E30
    }

    public class SyntaxTreeNode
    {
        // ── Methods ──
        public void ExpandTree(){} // RVA: 0x2F090
        public void ConstructPos(){} // RVA: 0x2F090
        public void get_IsNullable(){} // RVA: 0xDBE0
        public void get_IsRangeNode(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DD310
    }

}