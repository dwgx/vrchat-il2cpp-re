// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 106

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ChameleonKey : Object
    {
        public string targetNS; // 0x10
        public System.Uri chameleonLocation; // 0x18
        public System.Xml.Schema.XmlSchema originalSchema; // 0x20
        public int hashCode; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC926C710
        public void GetHashCode(){} // RVA: 0x7FFAC926C8E0
        public void Equals(){} // RVA: 0x7FFAC926C980
    }

    public class ChoiceNode : InteriorNode
    {
        public object IsNullable;

        // ── Methods ──
        public void ConstructChildPos(){} // RVA: 0x7FFAC92726C0
        public void ConstructPos(){} // RVA: 0x7FFAC92727D0
        public void get_IsNullable(){} // RVA: 0x7FFAC9272A00
        public void ExpandTree(){} // RVA: 0x7FFAC9272510
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CompiledIdentityConstraint : Object
    {
        public System.Xml.XmlQualifiedName Role; // 0x10
        public 0x6B15FE28 Selector; // 0x18
        public System.Xml.Schema.Asttree Fields; // 0x20
        public System.Xml.Schema.Asttree[] fields; // 0x28
        public System.Xml.XmlQualifiedName refer; // 0x30
        public System.Xml.Schema.CompiledIdentityConstraint Empty;

        // ── Methods ──
        public void get_Role(){} // RVA: 0x7FFAC3157800
        public void get_Selector(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Fields(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC926CBC0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC926D1D0
    }

    public class Compiler : BaseProcessor
    {
        public string restrictionErrorMsg; // 0x40
        public System.Xml.Schema.XmlSchemaObjectTable attributes; // 0x48
        public System.Xml.Schema.XmlSchemaObjectTable attributeGroups; // 0x50
        public System.Xml.Schema.XmlSchemaObjectTable elements; // 0x58
        public System.Xml.Schema.XmlSchemaObjectTable schemaTypes; // 0x60
        public System.Xml.Schema.XmlSchemaObjectTable groups; // 0x68
        public System.Xml.Schema.XmlSchemaObjectTable notations; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable examplars; // 0x78
        public System.Xml.Schema.XmlSchemaObjectTable identityConstraints; // 0x80
        public System.Collections.Stack complexTypeStack; // 0x88
        public System.Collections.Hashtable schemasToCompile; // 0x90
        public System.Collections.Hashtable importedSchemas; // 0x98
        public System.Xml.Schema.XmlSchema schemaForSchema; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC910CDD0
        public void Execute(){} // RVA: 0x7FFAC910D3D0
        public void Prepare(){} // RVA: 0x7FFAC910D5C0
        public void UpdateSForSSimpleTypes(){} // RVA: 0x7FFAC910E8B0
        public void Output(){} // RVA: 0x7FFAC910EA00
        public void ImportAllCompiledSchemas(){} // RVA: 0x7FFAC910F9D0
        public void Compile(){} // RVA: 0x7FFAC910FAE0
        public void CleanupAttribute(){} // RVA: 0x7FFAC9111810
        public void CleanupAttributeGroup(){} // RVA: 0x7FFAC91118A0
        public void CleanupComplexType(){} // RVA: 0x7FFAC9111970
        public void CleanupSimpleType(){} // RVA: 0x7FFAC9112060
        public void CleanupElement(){} // RVA: 0x7FFAC91121C0
        public void CleanupAttributes(){} // RVA: 0x7FFAC9112460
        public void CleanupGroup(){} // RVA: 0x7FFAC9112570
        public void CleanupParticle(){} // RVA: 0x7FFAC9112620
        public void ProcessSubstitutionGroups(){} // RVA: 0x7FFAC9112820
        public void CompileSubstitutionGroup(){} // RVA: 0x7FFAC9112F60
        public void RecursivelyCheckRedefinedGroups(){} // RVA: 0x7FFAC9113550
        public void RecursivelyCheckRedefinedAttributeGroups(){} // RVA: 0x7FFAC9113730
        public void CompileGroup(){} // RVA: 0x7FFAC91137C0
        public void CompileSimpleType(){} // RVA: 0x7FFAC91138F0
        public void CompileBaseMemberTypes(){} // RVA: 0x7FFAC91143C0
        public void CheckUnionType(){} // RVA: 0x7FFAC9114880
        public void CompileComplexType(){} // RVA: 0x7FFAC91149D0
        public void CompileSimpleContentExtension(){} // RVA: 0x7FFAC9115620
        public void CompileSimpleContentRestriction(){} // RVA: 0x7FFAC9115960
        public void CompileComplexContentExtension(){} // RVA: 0x7FFAC9115E30
        public void CompileComplexContentRestriction(){} // RVA: 0x7FFAC9116380
        public void CheckParticleDerivation(){} // RVA: 0x7FFAC9116D80 | overloaded x2
        public void CompileContentTypeParticle(){} // RVA: 0x7FFAC9116EB0
        public void CannonicalizeParticle(){} // RVA: 0x7FFAC91170C0
        public void CannonicalizeElement(){} // RVA: 0x7FFAC91173E0
        public void CannonicalizeGroupRef(){} // RVA: 0x7FFAC9117700
        public void CannonicalizeAll(){} // RVA: 0x7FFAC9117EC0
        public void CannonicalizeChoice(){} // RVA: 0x7FFAC9118210
        public void CannonicalizeSequence(){} // RVA: 0x7FFAC9118A80
        public void CannonicalizePointlessRoot(){} // RVA: 0x7FFAC9119230
        public void IsValidRestriction(){} // RVA: 0x7FFAC9119890
        public void IsElementFromElement(){} // RVA: 0x7FFAC911A940
        public void IsElementFromAny(){} // RVA: 0x7FFAC911AC90
        public void IsAnyFromAny(){} // RVA: 0x7FFAC911AF70
        public void IsGroupBaseFromAny(){} // RVA: 0x7FFAC911B160
        public void IsElementFromGroupBase(){} // RVA: 0x7FFAC911B720
        public void IsChoiceFromChoiceSubstGroup(){} // RVA: 0x7FFAC911C200
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7FFAC911C400
        public void IsSequenceFromAll(){} // RVA: 0x7FFAC911C860
        public void IsSequenceFromChoice(){} // RVA: 0x7FFAC911CC50
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7FFAC911D3D0 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x7FFAC911D520
        public void IsParticleEmptiable(){} // RVA: 0x7FFAC911D640
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7FFAC911D750
        public void PushComplexType(){} // RVA: 0x7FFAC911E1A0
        public void GetSchemaContentType(){} // RVA: 0x7FFAC90F23E0
        public void CompileAttributeGroup(){} // RVA: 0x7FFAC911E1D0
        public void CompileLocalAttributes(){} // RVA: 0x7FFAC911EA70
        public void CheckAtrributeGroupRestriction(){} // RVA: 0x7FFAC911FC90
        public void IsProcessContentsRestricted(){} // RVA: 0x7FFAC91205E0
        public void CompileAnyAttributeUnion(){} // RVA: 0x7FFAC91206D0
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7FFAC9120780
        public void CompileAttribute(){} // RVA: 0x7FFAC9120830
        public void SetDefaultFixed(){} // RVA: 0x7FFAC9121150
        public void CompileIdentityConstraint(){} // RVA: 0x7FFAC9121310
        public void CompileElement(){} // RVA: 0x7FFAC9121A20
        public void CompileComplexContent(){} // RVA: 0x7FFAC9122A00
        public void BuildParticleContentModel(){} // RVA: 0x7FFAC91237D0
        public void CompileParticleElements(){} // RVA: 0x7FFAC91243A0 | overloaded x2
        public void CompileComplexTypeElements(){} // RVA: 0x7FFAC91245B0
        public void GetSimpleType(){} // RVA: 0x7FFAC91246F0
        public void GetComplexType(){} // RVA: 0x7FFAC91247F0
        public void GetAnySchemaType(){} // RVA: 0x7FFAC91248B0
        public void CopyPosition(){} // RVA: 0x7FFAC9124A80
        public void IsFixedEqual(){} // RVA: 0x7FFAC9124BC0
    }

    public class ConstraintStruct : Object
    {
        public System.Xml.Schema.CompiledIdentityConstraint TableDim; // 0x10
        public System.Xml.Schema.SelectorActiveAxis axisSelector; // 0x18
        public System.Collections.ArrayList axisFields; // 0x20
        public System.Collections.Hashtable qualifiedTable; // 0x28
        public System.Collections.Hashtable keyrefTable; // 0x30
        public int tableDim; // 0x38

        // ── Methods ──
        public void get_TableDim(){} // RVA: 0x7FFAC358A870
        public void .ctor(){} // RVA: 0x7FFAC926D380
    }

    public class ContentValidator : Object
    {
        public 0x6B163DC0 ContentType; // 0x10
        public bool PreserveWhitespace; // 0x14
        public bool IsEmptiable; // 0x15
        public System.Xml.Schema.ContentValidator IsOpen;
        public System.Xml.Schema.ContentValidator TextOnly; // 0x8
        public System.Xml.Schema.ContentValidator Mixed; // 0x10
        public System.Xml.Schema.ContentValidator Any; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9272D10 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAC9272D20
        public void get_IsEmptiable(){} // RVA: 0x7FFAC3135090
        public void get_IsOpen(){} // RVA: 0x7FFAC9272D40
        public void set_IsOpen(){} // RVA: 0x7FFAC3070BE0
        public void InitValidation(){} // RVA: 0x7FFAC2F21310
        public void ValidateElement(){} // RVA: 0x7FFAC9272D60
        public void CompleteValidation(){} // RVA: 0x7FFAC3006850
        public void ExpectedElements(){} // RVA: 0x7FFAC34F9180
        public void ExpectedParticles(){} // RVA: 0x7FFAC34F9180
        public void AddParticleToExpected(){} // RVA: 0x7FFAC9272E10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC92730D0
    }

}