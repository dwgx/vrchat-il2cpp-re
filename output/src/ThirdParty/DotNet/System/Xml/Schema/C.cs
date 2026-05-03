// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 106

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ChameleonKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87614E80
        public void GetHashCode(){} // RVA: 0x7FFE87615050
        public void Equals(){} // RVA: 0x7FFE876150F0
    }

    public class ChoiceNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructChildPos(){} // RVA: 0x7FFE8761AE30
        public void ConstructPos(){} // RVA: 0x7FFE8761AF40
        public void get_IsNullable(){} // RVA: 0x7FFE8761B170
        public void ExpandTree(){} // RVA: 0x7FFE8761AC80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CompiledIdentityConstraint : Object
    {
        public System.Xml.XmlQualifiedName name; // 0x10
        public 0x66558EAC role; // 0x18
        public System.Xml.Schema.Asttree selector; // 0x20

        // ── Methods ──
        public void get_Role(){} // RVA: 0x7FFE813DB630
        public void get_Selector(){} // RVA: 0x7FFE811290C0
        public void get_Fields(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE87615330 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87615940
    }

    public class Compiler : BaseProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874B5580
        public void Execute(){} // RVA: 0x7FFE874B5B80
        public void Prepare(){} // RVA: 0x7FFE874B5D70
        public void UpdateSForSSimpleTypes(){} // RVA: 0x7FFE874B7060
        public void Output(){} // RVA: 0x7FFE874B71B0
        public void ImportAllCompiledSchemas(){} // RVA: 0x7FFE874B8180
        public void Compile(){} // RVA: 0x7FFE874B8290
        public void CleanupAttribute(){} // RVA: 0x7FFE874B9FC0
        public void CleanupAttributeGroup(){} // RVA: 0x7FFE874BA050
        public void CleanupComplexType(){} // RVA: 0x7FFE874BA120
        public void CleanupSimpleType(){} // RVA: 0x7FFE874BA810
        public void CleanupElement(){} // RVA: 0x7FFE874BA970
        public void CleanupAttributes(){} // RVA: 0x7FFE874BAC10
        public void CleanupGroup(){} // RVA: 0x7FFE874BAD20
        public void CleanupParticle(){} // RVA: 0x7FFE874BADD0
        public void ProcessSubstitutionGroups(){} // RVA: 0x7FFE874BAFD0
        public void CompileSubstitutionGroup(){} // RVA: 0x7FFE874BB710
        public void RecursivelyCheckRedefinedGroups(){} // RVA: 0x7FFE874BBD00
        public void RecursivelyCheckRedefinedAttributeGroups(){} // RVA: 0x7FFE874BBEE0
        public void CompileGroup(){} // RVA: 0x7FFE874BBF70
        public void CompileSimpleType(){} // RVA: 0x7FFE874BC0A0
        public void CompileBaseMemberTypes(){} // RVA: 0x7FFE874BCB70
        public void CheckUnionType(){} // RVA: 0x7FFE874BD030
        public void CompileComplexType(){} // RVA: 0x7FFE874BD180
        public void CompileSimpleContentExtension(){} // RVA: 0x7FFE874BDDD0
        public void CompileSimpleContentRestriction(){} // RVA: 0x7FFE874BE110
        public void CompileComplexContentExtension(){} // RVA: 0x7FFE874BE5E0
        public void CompileComplexContentRestriction(){} // RVA: 0x7FFE874BEB30
        public void CheckParticleDerivation(){} // RVA: 0x7FFE874BF530 | overloaded x2
        public void CompileContentTypeParticle(){} // RVA: 0x7FFE874BF660
        public void CannonicalizeParticle(){} // RVA: 0x7FFE874BF870
        public void CannonicalizeElement(){} // RVA: 0x7FFE874BFB90
        public void CannonicalizeGroupRef(){} // RVA: 0x7FFE874BFEB0
        public void CannonicalizeAll(){} // RVA: 0x7FFE874C0670
        public void CannonicalizeChoice(){} // RVA: 0x7FFE874C09C0
        public void CannonicalizeSequence(){} // RVA: 0x7FFE874C1230
        public void CannonicalizePointlessRoot(){} // RVA: 0x7FFE874C19E0
        public void IsValidRestriction(){} // RVA: 0x7FFE874C2040
        public void IsElementFromElement(){} // RVA: 0x7FFE874C30F0
        public void IsElementFromAny(){} // RVA: 0x7FFE874C3440
        public void IsAnyFromAny(){} // RVA: 0x7FFE874C3720
        public void IsGroupBaseFromAny(){} // RVA: 0x7FFE874C3910
        public void IsElementFromGroupBase(){} // RVA: 0x7FFE874C3ED0
        public void IsChoiceFromChoiceSubstGroup(){} // RVA: 0x7FFE874C49B0
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7FFE874C4BB0
        public void IsSequenceFromAll(){} // RVA: 0x7FFE874C5010
        public void IsSequenceFromChoice(){} // RVA: 0x7FFE874C5400
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7FFE874C5B80 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x7FFE874C5CD0
        public void IsParticleEmptiable(){} // RVA: 0x7FFE874C5DF0
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7FFE874C5F00
        public void PushComplexType(){} // RVA: 0x7FFE874C6950
        public void GetSchemaContentType(){} // RVA: 0x7FFE8749AB90
        public void CompileAttributeGroup(){} // RVA: 0x7FFE874C6980
        public void CompileLocalAttributes(){} // RVA: 0x7FFE874C7220
        public void CheckAtrributeGroupRestriction(){} // RVA: 0x7FFE874C8440
        public void IsProcessContentsRestricted(){} // RVA: 0x7FFE874C8D90
        public void CompileAnyAttributeUnion(){} // RVA: 0x7FFE874C8E80
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7FFE874C8F30
        public void CompileAttribute(){} // RVA: 0x7FFE874C8FE0
        public void SetDefaultFixed(){} // RVA: 0x7FFE874C9900
        public void CompileIdentityConstraint(){} // RVA: 0x7FFE874C9AC0
        public void CompileElement(){} // RVA: 0x7FFE874CA1D0
        public void CompileComplexContent(){} // RVA: 0x7FFE874CB1B0
        public void BuildParticleContentModel(){} // RVA: 0x7FFE874CBF80
        public void CompileParticleElements(){} // RVA: 0x7FFE874CCB50 | overloaded x2
        public void CompileComplexTypeElements(){} // RVA: 0x7FFE874CCD60
        public void GetSimpleType(){} // RVA: 0x7FFE874CCEA0
        public void GetComplexType(){} // RVA: 0x7FFE874CCFA0
        public void GetAnySchemaType(){} // RVA: 0x7FFE874CD060
        public void CopyPosition(){} // RVA: 0x7FFE874CD230
        public void IsFixedEqual(){} // RVA: 0x7FFE874CD370
    }

    public class ConstraintStruct : Object
    {
        public System.Xml.Schema.CompiledIdentityConstraint constraint; // 0x10

        // ── Methods ──
        public void get_TableDim(){} // RVA: 0x7FFE81D46090
        public void .ctor(){} // RVA: 0x7FFE87615AF0
    }

    public class ContentValidator : Object
    {
        public 0x6655CE44 contentType; // 0x10
        public bool isOpen; // 0x14
        public bool isEmptiable; // 0x15
        public System.Xml.Schema.ContentValidator Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8761B480 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFE811485C0
        public void get_PreserveWhitespace(){} // RVA: 0x7FFE8761B490
        public void get_IsEmptiable(){} // RVA: 0x7FFE8139AC40
        public void get_IsOpen(){} // RVA: 0x7FFE8761B4B0
        public void set_IsOpen(){} // RVA: 0x7FFE8124ABE0
        public void InitValidation(){} // RVA: 0x7FFE810FB310
        public void ValidateElement(){} // RVA: 0x7FFE8761B4D0
        public void CompleteValidation(){} // RVA: 0x7FFE811E0850
        public void ExpectedElements(){} // RVA: 0x7FFE813240E0
        public void ExpectedParticles(){} // RVA: 0x7FFE813240E0
        public void AddParticleToExpected(){} // RVA: 0x7FFE8761B580 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8761B840
    }

}