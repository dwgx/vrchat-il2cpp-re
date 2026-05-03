// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 96

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class Parser : Object
    {
        public 0x6655BFD4 schemaType; // 0x10
        public System.Xml.XmlNameTable nameTable; // 0x18
        public System.Xml.Schema.SchemaNames schemaNames; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8747C0C0
        public void Parse(){} // RVA: 0x7FFE8747C360
        public void StartParsing(){} // RVA: 0x7FFE8747C3D0
        public void CheckSchemaRoot(){} // RVA: 0x7FFE8747CB40
        public void FinishParsing(){} // RVA: 0x7FFE811485C0
        public void get_XmlSchema(){} // RVA: 0x7FFE81199370
        public void set_XmlResolver(){} // RVA: 0x7FFE811C35A0
        public void get_XdrSchema(){} // RVA: 0x7FFE81176D50
        public void ParseReaderNode(){} // RVA: 0x7FFE8747CD50
        public void ProcessAppInfoDocMarkup(){} // RVA: 0x7FFE8747D650
        public void LoadElementNode(){} // RVA: 0x7FFE8747D990
        public void CreateXmlNsAttribute(){} // RVA: 0x7FFE8747DF40
        public void LoadAttributeNode(){} // RVA: 0x7FFE8747E080
        public void LoadEntityReferenceInAttribute(){} // RVA: 0x7FFE8747E240
    }

    public class ParticleContentValidator : ContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8761BAD0 | overloaded x2
        public void InitValidation(){} // RVA: 0x7FFE8761BB40
        public void ValidateElement(){} // RVA: 0x7FFE8761BB80
        public void CompleteValidation(){} // RVA: 0x7FFE8761BBC0
        public void Start(){} // RVA: 0x7FFE8761BC00
        public void OpenGroup(){} // RVA: 0x7FFE8761BF50
        public void CloseGroup(){} // RVA: 0x7FFE8761BF80
        public void Exists(){} // RVA: 0x7FFE8761C160
        public void AddName(){} // RVA: 0x7FFE8761C1A0
        public void AddNamespaceList(){} // RVA: 0x7FFE8761C250
        public void AddLeafNode(){} // RVA: 0x7FFE8761C390
        public void AddChoice(){} // RVA: 0x7FFE8761C490
        public void AddSequence(){} // RVA: 0x7FFE8761C5D0
        public void AddStar(){} // RVA: 0x7FFE8761C710
        public void AddPlus(){} // RVA: 0x7FFE8761C760
        public void AddQMark(){} // RVA: 0x7FFE8761C7B0
        public void AddLeafRange(){} // RVA: 0x7FFE8761C800
        public void Closure(){} // RVA: 0x7FFE8761C920
        public void Finish(){} // RVA: 0x7FFE8761CB20
        public void CalculateTotalFollowposForRangeNodes(){} // RVA: 0x7FFE8761D400
        public void CheckCMUPAWithLeafRangeNodes(){} // RVA: 0x7FFE8761D830
        public void GetApplicableMinMaxFollowPos(){} // RVA: 0x7FFE8761DA50
        public void CheckUniqueParticleAttribution(){} // RVA: 0x7FFE8761DDD0 | overloaded x2
        public void BuildTransitionTable(){} // RVA: 0x7FFE8761E050
    }

    public class PlusNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFE8761B210
        public void get_IsNullable(){} // RVA: 0x7FFE81588760
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Position : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844576B0
    }

    public class Positions : Object
    {
        public System.Collections.ArrayList positions; // 0x10
        public object field_1; // 0x3E6

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE876195C0
        public void get_Item(){} // RVA: 0x7FFE876196B0
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void .ctor(){} // RVA: 0x7FFE87619750
    }

    public class Preprocessor : BaseProcessor
    {
        public string Xmlns; // 0x40
        public string NsXsi; // 0x48
        public string targetNamespace; // 0x50
        public System.Xml.Schema.XmlSchema rootSchema; // 0x58
        public System.Xml.Schema.XmlSchema currentSchema; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8747E4D0
        public void Execute(){} // RVA: 0x7FFE8747E6D0
        public void Cleanup(){} // RVA: 0x7FFE8747F050
        public void CleanupRedefine(){} // RVA: 0x7FFE8747F150
        public void set_XmlResolver(){} // RVA: 0x7FFE811660C0
        public void set_ReaderSettings(){} // RVA: 0x7FFE8171B4D0
        public void set_SchemaLocations(){} // RVA: 0x7FFE81464570
        public void set_ChameleonSchemas(){} // RVA: 0x7FFE81282380
        public void get_RootSchema(){} // RVA: 0x7FFE811C3500
        public void BuildSchemaList(){} // RVA: 0x7FFE8747F210
        public void LoadExternals(){} // RVA: 0x7FFE8747F3E0
        public void GetBuildInSchema(){} // RVA: 0x7FFE87480380
        public void BuildRefNamespaces(){} // RVA: 0x7FFE874811A0
        public void ParseUri(){} // RVA: 0x7FFE87481470
        public void Preprocess(){} // RVA: 0x7FFE87481540
        public void CopyIncludedComponents(){} // RVA: 0x7FFE87482A70
        public void PreprocessRedefine(){} // RVA: 0x7FFE87483A00
        public void GetIncludedSet(){} // RVA: 0x7FFE87484A00
        public void GetParentSchema(){} // RVA: 0x7FFE87484B90
        public void SetSchemaDefaults(){} // RVA: 0x7FFE87484C10
        public void CountGroupSelfReference(){} // RVA: 0x7FFE87484D20
        public void CheckRefinedGroup(){} // RVA: 0x7FFE874850F0
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7FFE874851A0
        public void CheckRefinedSimpleType(){} // RVA: 0x7FFE87485330
        public void CheckRefinedComplexType(){} // RVA: 0x7FFE87485480
        public void PreprocessAttribute(){} // RVA: 0x7FFE87485920
        public void PreprocessLocalAttribute(){} // RVA: 0x7FFE87485B00
        public void PreprocessAttributeContent(){} // RVA: 0x7FFE87485DC0
        public void PreprocessAttributeGroup(){} // RVA: 0x7FFE874860C0
        public void PreprocessElement(){} // RVA: 0x7FFE87486230
        public void PreprocessLocalElement(){} // RVA: 0x7FFE87486520
        public void PreprocessElementContent(){} // RVA: 0x7FFE87486A50
        public void PreprocessIdentityConstraint(){} // RVA: 0x7FFE87486F30
        public void PreprocessSimpleType(){} // RVA: 0x7FFE87487450
        public void PreprocessComplexType(){} // RVA: 0x7FFE87487E00
        public void PreprocessGroup(){} // RVA: 0x7FFE87488BB0
        public void PreprocessNotation(){} // RVA: 0x7FFE87488DF0
        public void PreprocessParticle(){} // RVA: 0x7FFE87489050
        public void PreprocessAttributes(){} // RVA: 0x7FFE87489D60
        public void ValidateIdAttribute(){} // RVA: 0x7FFE8748A160
        public void ValidateNameAttribute(){} // RVA: 0x7FFE8748A3D0
        public void ValidateQNameAttribute(){} // RVA: 0x7FFE8748A700
        public void ResolveSchemaLocationUri(){} // RVA: 0x7FFE8748A8B0
        public void GetSchemaEntity(){} // RVA: 0x7FFE8748A900
        public void GetChameleonSchema(){} // RVA: 0x7FFE8748A940
        public void SetParent(){} // RVA: 0x7FFE8748AB50
        public void PreprocessAnnotation(){} // RVA: 0x7FFE8748AC80 | overloaded x2
    }

}