// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 93

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class Parser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE72C3B0
        public void Parse(){} // RVA: 0x7AE72C660
        public void StartParsing(){} // RVA: 0x7AE72C6D0
        public void CheckSchemaRoot(){} // RVA: 0x7AE72CE40
        public void FinishParsing(){} // RVA: 0x7A8124910
        public void get_XmlSchema(){} // RVA: 0x7A8175DF0
        public void set_XmlResolver(){} // RVA: 0x7A81A00F0
        public void get_XdrSchema(){} // RVA: 0x7A8153390
        public void ParseReaderNode(){} // RVA: 0x7AE72D050
        public void ProcessAppInfoDocMarkup(){} // RVA: 0x7AE72D950
        public void LoadElementNode(){} // RVA: 0x7AE72DC90
        public void CreateXmlNsAttribute(){} // RVA: 0x7AE72E240
        public void LoadAttributeNode(){} // RVA: 0x7AE72E380
        public void LoadEntityReferenceInAttribute(){} // RVA: 0x7AE72E540
    }

    public class ParticleContentValidator : ContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8CCB20
        public void InitValidation(){} // RVA: 0x7AE8CCB90
        public void ValidateElement(){} // RVA: 0x7AE8CCBD0
        public void CompleteValidation(){} // RVA: 0x7AE8CCC10
        public void Start(){} // RVA: 0x7AE8CCC50
        public void OpenGroup(){} // RVA: 0x7AE8CCFA0
        public void CloseGroup(){} // RVA: 0x7AE8CCFD0
        public void Exists(){} // RVA: 0x7AE8CD1B0
        public void AddName(){} // RVA: 0x7AE8CD1F0
        public void AddNamespaceList(){} // RVA: 0x7AE8CD2A0
        public void AddLeafNode(){} // RVA: 0x7AE8CD3E0
        public void AddChoice(){} // RVA: 0x7AE8CD4E0
        public void AddSequence(){} // RVA: 0x7AE8CD620
        public void AddStar(){} // RVA: 0x7AE8CD760
        public void AddPlus(){} // RVA: 0x7AE8CD7B0
        public void AddQMark(){} // RVA: 0x7AE8CD800
        public void AddLeafRange(){} // RVA: 0x7AE8CD850
        public void Closure(){} // RVA: 0x7AE8CD970
        public void Finish(){} // RVA: 0x7AE8CDB70
        public void CalculateTotalFollowposForRangeNodes(){} // RVA: 0x7AE8CE5F0
        public void CheckCMUPAWithLeafRangeNodes(){} // RVA: 0x7AE8CEA40
        public void GetApplicableMinMaxFollowPos(){} // RVA: 0x7AE8CEC60
        public void CheckUniqueParticleAttribution(){} // RVA: 0x7AE8CEFC0
        public void BuildTransitionTable(){} // RVA: 0x7AE8CF240
    }

    public class PlusNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7AE8CC2B0
        public void get_IsNullable(){} // RVA: 0x7A858ABB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Position : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A790A7A0
    }

    public class Positions : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AE8CA700
        public void get_Item(){} // RVA: 0x7AE8CA7F0
        public void get_Count(){} // RVA: 0x7ADBEAB80
        public void .ctor(){} // RVA: 0x7AE8CA890
    }

    public class Preprocessor : BaseProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE72E7D0
        public void Execute(){} // RVA: 0x7AE72E9D0
        public void Cleanup(){} // RVA: 0x7AE72F330
        public void CleanupRedefine(){} // RVA: 0x7AE72F430
        public void set_XmlResolver(){} // RVA: 0x7A8142690
        public void set_ReaderSettings(){} // RVA: 0x7A87446C0
        public void set_SchemaLocations(){} // RVA: 0x7A82C0530
        public void set_ChameleonSchemas(){} // RVA: 0x7A825F860
        public void get_RootSchema(){} // RVA: 0x7A81A0050
        public void BuildSchemaList(){} // RVA: 0x7AE72F4D0
        public void LoadExternals(){} // RVA: 0x7AE72F6A0
        public void GetBuildInSchema(){} // RVA: 0x7AE7305F0
        public void BuildRefNamespaces(){} // RVA: 0x7AE731410
        public void ParseUri(){} // RVA: 0x7AE7316E0
        public void Preprocess(){} // RVA: 0x7AE7317B0
        public void CopyIncludedComponents(){} // RVA: 0x7AE732CE0
        public void PreprocessRedefine(){} // RVA: 0x7AE733BC0
        public void GetIncludedSet(){} // RVA: 0x7AE734B90
        public void GetParentSchema(){} // RVA: 0x7AE734D20
        public void SetSchemaDefaults(){} // RVA: 0x7AE734DB0
        public void CountGroupSelfReference(){} // RVA: 0x7AE734EC0
        public void CheckRefinedGroup(){} // RVA: 0x7AE735280
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7AE735330
        public void CheckRefinedSimpleType(){} // RVA: 0x7AE7354A0
        public void CheckRefinedComplexType(){} // RVA: 0x7AE7355F0
        public void PreprocessAttribute(){} // RVA: 0x7AE735A90
        public void PreprocessLocalAttribute(){} // RVA: 0x7AE735C70
        public void PreprocessAttributeContent(){} // RVA: 0x7AE735F30
        public void PreprocessAttributeGroup(){} // RVA: 0x7AE736230
        public void PreprocessElement(){} // RVA: 0x7AE7363A0
        public void PreprocessLocalElement(){} // RVA: 0x7AE736690
        public void PreprocessElementContent(){} // RVA: 0x7AE736BC0
        public void PreprocessIdentityConstraint(){} // RVA: 0x7AE7370B0
        public void PreprocessSimpleType(){} // RVA: 0x7AE7375D0
        public void PreprocessComplexType(){} // RVA: 0x7AE737F80
        public void PreprocessGroup(){} // RVA: 0x7AE738CF0
        public void PreprocessNotation(){} // RVA: 0x7AE738F40
        public void PreprocessParticle(){} // RVA: 0x7AE7391A0
        public void PreprocessAttributes(){} // RVA: 0x7AE739E80
        public void ValidateIdAttribute(){} // RVA: 0x7AE73A270
        public void ValidateNameAttribute(){} // RVA: 0x7AE73A4E0
        public void ValidateQNameAttribute(){} // RVA: 0x7AE73A810
        public void ResolveSchemaLocationUri(){} // RVA: 0x7AE73A9C0
        public void GetSchemaEntity(){} // RVA: 0x7AE73AA10
        public void GetChameleonSchema(){} // RVA: 0x7AE73AA50
        public void SetParent(){} // RVA: 0x7AE73AC60
        public void PreprocessAnnotation(){} // RVA: 0x7AE73ADA0
    }

}