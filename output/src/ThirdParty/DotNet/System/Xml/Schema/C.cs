// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 100

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ChameleonKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8C5FF0
        public void GetHashCode(){} // RVA: 0x7AE8C61D0
        public void Equals(){} // RVA: 0x7AE8C6270
    }

    public class ChoiceNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructChildPos(){} // RVA: 0x7AE8CBEE0
        public void ConstructPos(){} // RVA: 0x7AE8CBFF0
        public void get_IsNullable(){} // RVA: 0x7AE8CC210
        public void ExpandTree(){} // RVA: 0x7AE8CBD30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CompiledIdentityConstraint : Object
    {
        // ── Methods ──
        public void get_Role(){} // RVA: 0x7A83782A0
        public void get_Selector(){} // RVA: 0x7A81052C0
        public void get_Fields(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7AE8C6490
        public void .cctor(){} // RVA: 0x7AE8C6A90
    }

    public class Compiler : BaseProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE764FB0
        public void Execute(){} // RVA: 0x7AE7655B0
        public void Prepare(){} // RVA: 0x7AE7657A0
        public void UpdateSForSSimpleTypes(){} // RVA: 0x7AE7669B0
        public void Output(){} // RVA: 0x7AE766B20
        public void ImportAllCompiledSchemas(){} // RVA: 0x7AE767A70
        public void Compile(){} // RVA: 0x7AE767B80
        public void CleanupAttribute(){} // RVA: 0x7AE769780
        public void CleanupAttributeGroup(){} // RVA: 0x7AE769810
        public void CleanupComplexType(){} // RVA: 0x7AE7698E0
        public void CleanupSimpleType(){} // RVA: 0x7AE769FD0
        public void CleanupElement(){} // RVA: 0x7AE76A120
        public void CleanupAttributes(){} // RVA: 0x7AE76A3D0
        public void CleanupGroup(){} // RVA: 0x7AE76A4C0
        public void CleanupParticle(){} // RVA: 0x7AE76A570
        public void ProcessSubstitutionGroups(){} // RVA: 0x7AE76A750
        public void CompileSubstitutionGroup(){} // RVA: 0x7AE76AE60
        public void RecursivelyCheckRedefinedGroups(){} // RVA: 0x7AE76B450
        public void RecursivelyCheckRedefinedAttributeGroups(){} // RVA: 0x7AE76B630
        public void CompileGroup(){} // RVA: 0x7AE76B6C0
        public void CompileSimpleType(){} // RVA: 0x7AE76B7F0
        public void CompileBaseMemberTypes(){} // RVA: 0x7AE76C2B0
        public void CheckUnionType(){} // RVA: 0x7AE76C780
        public void CompileComplexType(){} // RVA: 0x7AE76C8C0
        public void CompileSimpleContentExtension(){} // RVA: 0x7AE76D500
        public void CompileSimpleContentRestriction(){} // RVA: 0x7AE76D840
        public void CompileComplexContentExtension(){} // RVA: 0x7AE76DD10
        public void CompileComplexContentRestriction(){} // RVA: 0x7AE76E260
        public void CheckParticleDerivation(){} // RVA: 0x7AE76EC40
        public void CompileContentTypeParticle(){} // RVA: 0x7AE76ED70
        public void CannonicalizeParticle(){} // RVA: 0x7AE76EF60
        public void CannonicalizeElement(){} // RVA: 0x7AE76F280
        public void CannonicalizeGroupRef(){} // RVA: 0x7AE76F5A0
        public void CannonicalizeAll(){} // RVA: 0x7AE76FD60
        public void CannonicalizeChoice(){} // RVA: 0x7AE7700B0
        public void CannonicalizeSequence(){} // RVA: 0x7AE770920
        public void CannonicalizePointlessRoot(){} // RVA: 0x7AE7710E0
        public void IsValidRestriction(){} // RVA: 0x7AE771740
        public void IsElementFromElement(){} // RVA: 0x7AE772960
        public void IsElementFromAny(){} // RVA: 0x7AE772CB0
        public void IsAnyFromAny(){} // RVA: 0x7AE772F90
        public void IsGroupBaseFromAny(){} // RVA: 0x7AE773180
        public void IsElementFromGroupBase(){} // RVA: 0x7AE773740
        public void IsChoiceFromChoiceSubstGroup(){} // RVA: 0x7AE774220
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x7AE774420
        public void IsSequenceFromAll(){} // RVA: 0x7AE774890
        public void IsSequenceFromChoice(){} // RVA: 0x7AE774C80
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x7AE775400
        public void GetMappingParticle(){} // RVA: 0x7AE775550
        public void IsParticleEmptiable(){} // RVA: 0x7AE775670
        public void CalculateEffectiveTotalRange(){} // RVA: 0x7AE775780
        public void PushComplexType(){} // RVA: 0x7AE7761C0
        public void GetSchemaContentType(){} // RVA: 0x7AE74A900
        public void CompileAttributeGroup(){} // RVA: 0x7AE7761F0
        public void CompileLocalAttributes(){} // RVA: 0x7AE776A70
        public void CheckAtrributeGroupRestriction(){} // RVA: 0x7AE777C30
        public void IsProcessContentsRestricted(){} // RVA: 0x7AE778550
        public void CompileAnyAttributeUnion(){} // RVA: 0x7AE778640
        public void CompileAnyAttributeIntersection(){} // RVA: 0x7AE7786F0
        public void CompileAttribute(){} // RVA: 0x7AE7787A0
        public void SetDefaultFixed(){} // RVA: 0x7AE7790C0
        public void CompileIdentityConstraint(){} // RVA: 0x7AE779280
        public void CompileElement(){} // RVA: 0x7AE7799A0
        public void CompileComplexContent(){} // RVA: 0x7AE77A960
        public void BuildParticleContentModel(){} // RVA: 0x7AE77B740
        public void CompileParticleElements(){} // RVA: 0x7AE77C310
        public void CompileComplexTypeElements(){} // RVA: 0x7AE77C520
        public void GetSimpleType(){} // RVA: 0x7AE77C660
        public void GetComplexType(){} // RVA: 0x7AE77C750
        public void GetAnySchemaType(){} // RVA: 0x7AE77C800
        public void CopyPosition(){} // RVA: 0x7AE77C9D0
        public void IsFixedEqual(){} // RVA: 0x7AE77CB10
    }

    public class ConstraintStruct : Object
    {
        // ── Methods ──
        public void get_TableDim(){} // RVA: 0x7A8D863F0
        public void .ctor(){} // RVA: 0x7AE8C6C40
    }

    public class ContentValidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8CC4D0
        public void get_ContentType(){} // RVA: 0x7A8124910
        public void get_PreserveWhitespace(){} // RVA: 0x7AE8CC4E0
        public void get_IsEmptiable(){} // RVA: 0x7A83525F0
        public void get_IsOpen(){} // RVA: 0x7AE8CC500
        public void set_IsOpen(){} // RVA: 0x7A8227C10
        public void InitValidation(){} // RVA: 0x7A80D7310
        public void ValidateElement(){} // RVA: 0x7AE8CC520
        public void CompleteValidation(){} // RVA: 0x7A81BD750
        public void ExpectedElements(){} // RVA: 0x7A82D1450
        public void ExpectedParticles(){} // RVA: 0x7A82D1450
        public void AddParticleToExpected(){} // RVA: 0x7AE8CC5D0
        public void .cctor(){} // RVA: 0x7AE8CC890
    }

}