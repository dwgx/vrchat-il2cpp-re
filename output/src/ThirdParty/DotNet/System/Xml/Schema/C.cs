// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 100

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ChameleonKey : Object
    {
        public object targetNS;
        public object chameleonLocation;
        public object originalSchema;
        public object hashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7539FC0
        public void GetHashCode(){} // RVA: 0x753A1A0
        public void Equals(){} // RVA: 0x753A240
    }

    public class ChoiceNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructChildPos(){} // RVA: 0x753FDC0
        public void ConstructPos(){} // RVA: 0x753FED0
        public void get_IsNullable(){} // RVA: 0x75400F0
        public void ExpandTree(){} // RVA: 0x753FC10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CompiledIdentityConstraint : Object
    {
        public object name;
        public object role;
        public object selector;
        public object fields;
        public object refer;
        public object Empty;

        // ── Methods ──
        public void get_Role(){} // RVA: 0xE62D00
        public void get_Selector(){} // RVA: 0xB700F0
        public void get_Fields(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x753A460
        public void .cctor(){} // RVA: 0x753AA60
    }

    public class Compiler : BaseProcessor
    {
        public object restrictionErrorMsg;
        public object attributes;
        public object attributeGroups;
        public object elements;
        public object schemaTypes;
        public object groups;
        public object notations;
        public object examplars;
        public object identityConstraints;
        public object complexTypeStack;
        public object schemasToCompile;
        public object importedSchemas;
        public object schemaForSchema;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73DBF50
        public void Execute(){} // RVA: 0x73DC550
        public void Prepare(){} // RVA: 0x73DC740
        public void UpdateSForSSimpleTypes(){} // RVA: 0x73DD950
        public void Output(){} // RVA: 0x73DDAC0
        public void ImportAllCompiledSchemas(){} // RVA: 0x73DE9F0
        public void Compile(){} // RVA: 0x73DEB00
        public void CleanupAttribute(){} // RVA: 0x73E0700
        public void CleanupAttributeGroup(){} // RVA: 0x73E0790
        public void CleanupComplexType(){} // RVA: 0x73E0860
        public void CleanupSimpleType(){} // RVA: 0x73E0F50
        public void CleanupElement(){} // RVA: 0x73E10A0
        public void CleanupAttributes(){} // RVA: 0x73E1350
        public void CleanupGroup(){} // RVA: 0x73E1440
        public void CleanupParticle(){} // RVA: 0x73E14F0
        public void ProcessSubstitutionGroups(){} // RVA: 0x73E16D0
        public void CompileSubstitutionGroup(){} // RVA: 0x73E1DE0
        public void RecursivelyCheckRedefinedGroups(){} // RVA: 0x73E23D0
        public void RecursivelyCheckRedefinedAttributeGroups(){} // RVA: 0x73E25B0
        public void CompileGroup(){} // RVA: 0x73E2640
        public void CompileSimpleType(){} // RVA: 0x73E2770
        public void CompileBaseMemberTypes(){} // RVA: 0x73E3230
        public void CheckUnionType(){} // RVA: 0x73E36D0
        public void CompileComplexType(){} // RVA: 0x73E3810
        public void CompileSimpleContentExtension(){} // RVA: 0x73E4450
        public void CompileSimpleContentRestriction(){} // RVA: 0x73E4790
        public void CompileComplexContentExtension(){} // RVA: 0x73E4C60
        public void CompileComplexContentRestriction(){} // RVA: 0x73E51B0
        public void CheckParticleDerivation(){} // RVA: 0x73E5B90
        public void CompileContentTypeParticle(){} // RVA: 0x73E5CC0
        public void CannonicalizeParticle(){} // RVA: 0x73E5EB0
        public void CannonicalizeElement(){} // RVA: 0x73E61D0
        public void CannonicalizeGroupRef(){} // RVA: 0x73E64F0
        public void CannonicalizeAll(){} // RVA: 0x73E6CB0
        public void CannonicalizeChoice(){} // RVA: 0x73E7000
        public void CannonicalizeSequence(){} // RVA: 0x73E7870
        public void CannonicalizePointlessRoot(){} // RVA: 0x73E8030
        public void IsValidRestriction(){} // RVA: 0x73E8690
        public void IsElementFromElement(){} // RVA: 0x73E98B0
        public void IsElementFromAny(){} // RVA: 0x73E9C00
        public void IsAnyFromAny(){} // RVA: 0x73E9EE0
        public void IsGroupBaseFromAny(){} // RVA: 0x73EA0D0
        public void IsElementFromGroupBase(){} // RVA: 0x73EA690
        public void IsChoiceFromChoiceSubstGroup(){} // RVA: 0x73EB170
        public void IsGroupBaseFromGroupBase(){} // RVA: 0x73EB370
        public void IsSequenceFromAll(){} // RVA: 0x73EB7E0
        public void IsSequenceFromChoice(){} // RVA: 0x73EBBD0
        public void IsValidOccurrenceRangeRestriction(){} // RVA: 0x73EC350
        public void GetMappingParticle(){} // RVA: 0x73EC4A0
        public void IsParticleEmptiable(){} // RVA: 0x73EC5C0
        public void CalculateEffectiveTotalRange(){} // RVA: 0x73EC6D0
        public void PushComplexType(){} // RVA: 0x73ED110
        public void GetSchemaContentType(){} // RVA: 0x73C1000
        public void CompileAttributeGroup(){} // RVA: 0x73ED140
        public void CompileLocalAttributes(){} // RVA: 0x73ED9C0
        public void CheckAtrributeGroupRestriction(){} // RVA: 0x73EEB80
        public void IsProcessContentsRestricted(){} // RVA: 0x73EF4A0
        public void CompileAnyAttributeUnion(){} // RVA: 0x73EF590
        public void CompileAnyAttributeIntersection(){} // RVA: 0x73EF640
        public void CompileAttribute(){} // RVA: 0x73EF6F0
        public void SetDefaultFixed(){} // RVA: 0x73F0010
        public void CompileIdentityConstraint(){} // RVA: 0x73F01E0
        public void CompileElement(){} // RVA: 0x73F0900
        public void CompileComplexContent(){} // RVA: 0x73F18F0
        public void BuildParticleContentModel(){} // RVA: 0x73F26D0
        public void CompileParticleElements(){} // RVA: 0x73F32A0
        public void CompileComplexTypeElements(){} // RVA: 0x73F34B0
        public void GetSimpleType(){} // RVA: 0x73F35F0
        public void GetComplexType(){} // RVA: 0x73F36E0
        public void GetAnySchemaType(){} // RVA: 0x73F3790
        public void CopyPosition(){} // RVA: 0x73F3960
        public void IsFixedEqual(){} // RVA: 0x73F3AA0
    }

    public class ConstraintStruct : Object
    {
        public object constraint;
        public object axisSelector;
        public object axisFields;
        public object qualifiedTable;
        public object keyrefTable;
        public object tableDim;

        // ── Methods ──
        public void get_TableDim(){} // RVA: 0x18A0130
        public void .ctor(){} // RVA: 0x753AC10
    }

    public class ContentValidator : Object
    {
        public object contentType;
        public object isOpen;
        public object isEmptiable;
        public object Empty;
        public object TextOnly;
        public object Mixed;
        public object Any;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75403B0
        public void get_ContentType(){} // RVA: 0xB8F8F0
        public void get_PreserveWhitespace(){} // RVA: 0x75403C0
        public void get_IsEmptiable(){} // RVA: 0xE2F5E0
        public void get_IsOpen(){} // RVA: 0x75403E0
        public void set_IsOpen(){} // RVA: 0xC9C260
        public void InitValidation(){} // RVA: 0xB43310
        public void ValidateElement(){} // RVA: 0x7540400
        public void CompleteValidation(){} // RVA: 0xC2E4C0
        public void ExpectedElements(){} // RVA: 0xDAC980
        public void ExpectedParticles(){} // RVA: 0xDAC980
        public void AddParticleToExpected(){} // RVA: 0x75404B0
        public void .cctor(){} // RVA: 0x7540770
    }

}