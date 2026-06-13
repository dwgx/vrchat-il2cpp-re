// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 106

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ChameleonKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AD5B90
        public void GetHashCode(){} // RVA: 0x6AD5D60
        public void Equals(){} // RVA: 0x6AD5E00
    }

    public class ChoiceNode
    {
        // ── Methods ──
        public void ConstructChildPos(){} // RVA: 0x6ADBB40
        public void ConstructPos(){} // RVA: 0x6ADBC50
        public void get_IsNullable(){} // RVA: 0x6ADBE80
        public void ExpandTree(){} // RVA: 0x6ADB990
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CompiledIdentityConstraint
    {
        public System.Xml.XmlQualifiedName TableDim; // 0x10
        public 0x6587B010 role; // 0x18
        public System.Xml.Schema.Asttree selector; // 0x20

        // ── Methods ──
        public void get_Role(){} // RVA: 0x5BED50
        public void get_Selector(){} // RVA: 0x30B0C0
        public void get_Fields(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x6AD6040 | overloaded x2
        public void .cctor(){} // RVA: 0x6AD6650
    }

    public class Compiler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69762B0
        public void Execute(){} // RVA: 0x69768B0
        public void Prepare(){} // RVA: 0x6976AA0
        public void UpdateSForSSimpleTypes(){} // RVA: 0x6977D90
        public void Output(){} // RVA: 0x6977EE0
        public void ImportAllCompiledSchemas(){} // RVA: 0x6978EB0
        public void Compile(){} // RVA: 0x6978FC0
        public void CleanupAttribute(){} // RVA: 0x697ACF0
        public void CleanupAttributeGroup(){} // RVA: 0x697AD80
        public void CleanupComplexType(){} // RVA: 0x697AE50
        public void CleanupSimpleType(){} // RVA: 0x697B540
        public void CleanupElement(){} // RVA: 0x697B6A0
        public void CleanupAttributes(){} // RVA: 0x697B940
        public void CleanupGroup(){} // RVA: 0x697BA50
        public void CleanupParticle(){} // RVA: 0x697BB00
        public void ProcessSubstitutionGroups(){} // RVA: 0x697BD00
        public void CompileSubstitutionGroup(){} // RVA: 0x697C440
        public void RecursivelyCheckRedefinedGroups(){} // RVA: 0x697CA30
        public void RecursivelyCheckRedefinedAttributeGroups(){} // RVA: 0x697CC10
        public void CompileGroup(){} // RVA: 0x697CCA0
        public void CompileSimpleType(){} // RVA: 0x697CDD0
        public void CompileBaseMemberTypes(){} // RVA: 0x697D8A0
        public void CheckUnionType(){} // RVA: 0x697DD60
        public void CompileComplexType(){} // RVA: 0x697DEB0
        public void CompileSimpleContentExtension(){} // RVA: 0x697EB00
        public void CompileSimpleContentRestriction(){} // RVA: 0x697EE40
        public void CompileComplexContentExtension(){} // RVA: 0x697F310
        public void CompileComplexContentRestriction(){} // RVA: 0x697F860
        public void CheckParticleDerivation(){} // RVA: 0x6980260 | overloaded x2
        public void CompileContentTypeParticle(){} // RVA: 0x6980390
        public void CannonicalizeParticle(){} // RVA: 0x69805A0
        public void CannonicalizeElement(){} // RVA: 0x69808C0
        public void CannonicalizeGroupRef(){} // RVA: 0x6980BE0
        public void CannonicalizeAll(){} // RVA: 0x69813A0
        public void CannonicalizeChoice(){} // RVA: 0x69816F0
        public void CannonicalizeSequence(){} // RVA: 0x6981F60
        public void CannonicalizePointlessRoot(){} // RVA: 0x6982710
        public void IsValidRestriction(){} // RVA: 0x6982D70
        public void IsElementFromElement(){} // RVA: 0x6983E20
        public void IsElementFromAny(){} // RVA: 0x6984170
        public void IsAnyFromAny(){} // RVA: 0x6984450
        public void IsGroupBaseFromAny(){} // RVA: 0x6984640
        public void IsElementFromGroupBase(){} // RVA: 0x6984C00
        public void IsChoiceFromChoiceSubstGroup(){} // RVA: 0x69856E0
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x69858E0
        public void IsSequenceFromAll(){} // RVA: 0x6985D40
        public void IsSequenceFromChoice(){} // RVA: 0x6986130
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x69868B0 | overloaded x2
        public void GetMappingParticle(){} // RVA: 0x6986A00
        public void IsParticleEmptiable(){} // RVA: 0x6986B20
        public void CalculateEffectiveTotalRange(){} // RVA: 0x6986C30
        public void PushComplexType(){} // RVA: 0x6987680
        public void GetSchemaContentType(){} // RVA: 0x695B8C0
        public void CompileAttributeGroup(){} // RVA: 0x69876B0
        public void CompileLocalAttributes(){} // RVA: 0x6987F50
        public void CheckAtrributeGroupRestriction(){} // RVA: 0x6989170
        public void IsProcessContentsRestricted(){} // RVA: 0x6989AC0
        public void CompileAnyAttributeUnion(){} // RVA: 0x6989BB0
        public void CompileAnyAttributeIntersection(){} // RVA: 0x6989C60
        public void CompileAttribute(){} // RVA: 0x6989D10
        public void SetDefaultFixed(){} // RVA: 0x698A630
        public void CompileIdentityConstraint(){} // RVA: 0x698A7F0
        public void CompileElement(){} // RVA: 0x698AF00
        public void CompileComplexContent(){} // RVA: 0x698BEE0
        public void BuildParticleContentModel(){} // RVA: 0x698CCB0
        public void CompileParticleElements(){} // RVA: 0x698D880 | overloaded x2
        public void CompileComplexTypeElements(){} // RVA: 0x698DA90
        public void GetSimpleType(){} // RVA: 0x698DBD0
        public void GetComplexType(){} // RVA: 0x698DCD0
        public void GetAnySchemaType(){} // RVA: 0x698DD90
        public void CopyPosition(){} // RVA: 0x698DF60
        public void IsFixedEqual(){} // RVA: 0x698E0A0
    }

    public class ConstraintStruct
    {
        public System.Xml.Schema.CompiledIdentityConstraint Column; // 0x10

        // ── Methods ──
        public void get_TableDim(){} // RVA: 0xFDC9F0
        public void .ctor(){} // RVA: 0x6AD6800
    }

    public class ContentValidator
    {
        public 0x6587EFA8 contentType; // 0x10
        public bool isOpen; // 0x14
        public bool isEmptiable; // 0x15
        public System.Xml.Schema.ContentValidator Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADC190 | overloaded x2
        public void get_ContentType(){} // RVA: 0x32A5C0
        public void get_PreserveWhitespace(){} // RVA: 0x6ADC1A0
        public void get_IsEmptiable(){} // RVA: 0x5992B0
        public void get_IsOpen(){} // RVA: 0x6ADC1C0
        public void set_IsOpen(){} // RVA: 0x42CBE0
        public void InitValidation(){} // RVA: 0x2DD310
        public void ValidateElement(){} // RVA: 0x6ADC1E0
        public void CompleteValidation(){} // RVA: 0x3C2850
        public void ExpectedElements(){} // RVA: 0x519240
        public void ExpectedParticles(){} // RVA: 0x519240
        public void AddParticleToExpected(){} // RVA: 0x6ADC290 | overloaded x2
        public void .cctor(){} // RVA: 0x6ADC550
    }

}