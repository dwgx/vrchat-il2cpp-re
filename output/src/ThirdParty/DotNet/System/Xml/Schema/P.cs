// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 96

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class Parser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93ECDF0
        public void Parse(){} // RVA: 0x7FFAF93ED090
        public void StartParsing(){} // RVA: 0x7FFAF93ED100
        public void CheckSchemaRoot(){} // RVA: 0x7FFAF93ED870
        public void FinishParsing(){} // RVA: 0x7FFAF2DDA5C0
        public void get_XmlSchema(){} // RVA: 0x7FFAF2E2B370
        public void set_XmlResolver(){} // RVA: 0x7FFAF2E555A0
        public void get_XdrSchema(){} // RVA: 0x7FFAF2E08D50
        public void ParseReaderNode(){} // RVA: 0x7FFAF93EDA80
        public void ProcessAppInfoDocMarkup(){} // RVA: 0x7FFAF93EE380
        public void LoadElementNode(){} // RVA: 0x7FFAF93EE6C0
        public void CreateXmlNsAttribute(){} // RVA: 0x7FFAF93EEC70
        public void LoadAttributeNode(){} // RVA: 0x7FFAF93EEDB0
        public void LoadEntityReferenceInAttribute(){} // RVA: 0x7FFAF93EEF70
    }

    public class ParticleContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF958C7E0 | overloaded x2
        public void InitValidation(){} // RVA: 0x7FFAF958C850
        public void ValidateElement(){} // RVA: 0x7FFAF958C890
        public void CompleteValidation(){} // RVA: 0x7FFAF958C8D0
        public void Start(){} // RVA: 0x7FFAF958C910
        public void OpenGroup(){} // RVA: 0x7FFAF958CC60
        public void CloseGroup(){} // RVA: 0x7FFAF958CC90
        public void Exists(){} // RVA: 0x7FFAF958CE70
        public void AddName(){} // RVA: 0x7FFAF958CEB0
        public void AddNamespaceList(){} // RVA: 0x7FFAF958CF60
        public void AddLeafNode(){} // RVA: 0x7FFAF958D0A0
        public void AddChoice(){} // RVA: 0x7FFAF958D1A0
        public void AddSequence(){} // RVA: 0x7FFAF958D2E0
        public void AddStar(){} // RVA: 0x7FFAF958D420
        public void AddPlus(){} // RVA: 0x7FFAF958D470
        public void AddQMark(){} // RVA: 0x7FFAF958D4C0
        public void AddLeafRange(){} // RVA: 0x7FFAF958D510
        public void Closure(){} // RVA: 0x7FFAF958D630
        public void Finish(){} // RVA: 0x7FFAF958D830
        public void CalculateTotalFollowposForRangeNodes(){} // RVA: 0x7FFAF958E110
        public void CheckCMUPAWithLeafRangeNodes(){} // RVA: 0x7FFAF958E540
        public void GetApplicableMinMaxFollowPos(){} // RVA: 0x7FFAF958E760
        public void CheckUniqueParticleAttribution(){} // RVA: 0x7FFAF958EAE0 | overloaded x2
        public void BuildTransitionTable(){} // RVA: 0x7FFAF958ED60
    }

    public class PlusNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFAF958BF20
        public void get_IsNullable(){} // RVA: 0x7FFAF32A02E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Position
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6276C70
    }

    public class Positions
    {
        public object IsNullable;
        public object IsRangeNode;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF958A2D0
        public void get_Item(){} // RVA: 0x7FFAF958A3C0
        public void get_Count(){} // RVA: 0x7FFAF88AC050
        public void .ctor(){} // RVA: 0x7FFAF958A460
    }

    public class Preprocessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93EF200
        public void Execute(){} // RVA: 0x7FFAF93EF400
        public void Cleanup(){} // RVA: 0x7FFAF93EFD80
        public void CleanupRedefine(){} // RVA: 0x7FFAF93EFE80
        public void set_XmlResolver(){} // RVA: 0x7FFAF2DF80C0
        public void set_ReaderSettings(){} // RVA: 0x7FFAF345A5F0
        public void set_SchemaLocations(){} // RVA: 0x7FFAF2F734F0
        public void set_ChameleonSchemas(){} // RVA: 0x7FFAF2F14450
        public void get_RootSchema(){} // RVA: 0x7FFAF2E55500
        public void BuildSchemaList(){} // RVA: 0x7FFAF93EFF40
        public void LoadExternals(){} // RVA: 0x7FFAF93F0110
        public void GetBuildInSchema(){} // RVA: 0x7FFAF93F10B0
        public void BuildRefNamespaces(){} // RVA: 0x7FFAF93F1ED0
        public void ParseUri(){} // RVA: 0x7FFAF93F21A0
        public void Preprocess(){} // RVA: 0x7FFAF93F2270
        public void CopyIncludedComponents(){} // RVA: 0x7FFAF93F37A0
        public void PreprocessRedefine(){} // RVA: 0x7FFAF93F4730
        public void GetIncludedSet(){} // RVA: 0x7FFAF93F5730
        public void GetParentSchema(){} // RVA: 0x7FFAF93F58C0
        public void SetSchemaDefaults(){} // RVA: 0x7FFAF93F5940
        public void CountGroupSelfReference(){} // RVA: 0x7FFAF93F5A50
        public void CheckRefinedGroup(){} // RVA: 0x7FFAF93F5E20
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7FFAF93F5ED0
        public void CheckRefinedSimpleType(){} // RVA: 0x7FFAF93F6060
        public void CheckRefinedComplexType(){} // RVA: 0x7FFAF93F61B0
        public void PreprocessAttribute(){} // RVA: 0x7FFAF93F6650
        public void PreprocessLocalAttribute(){} // RVA: 0x7FFAF93F6830
        public void PreprocessAttributeContent(){} // RVA: 0x7FFAF93F6AF0
        public void PreprocessAttributeGroup(){} // RVA: 0x7FFAF93F6DF0
        public void PreprocessElement(){} // RVA: 0x7FFAF93F6F60
        public void PreprocessLocalElement(){} // RVA: 0x7FFAF93F7250
        public void PreprocessElementContent(){} // RVA: 0x7FFAF93F7780
        public void PreprocessIdentityConstraint(){} // RVA: 0x7FFAF93F7C60
        public void PreprocessSimpleType(){} // RVA: 0x7FFAF93F8180
        public void PreprocessComplexType(){} // RVA: 0x7FFAF93F8B30
        public void PreprocessGroup(){} // RVA: 0x7FFAF93F98E0
        public void PreprocessNotation(){} // RVA: 0x7FFAF93F9B20
        public void PreprocessParticle(){} // RVA: 0x7FFAF93F9D80
        public void PreprocessAttributes(){} // RVA: 0x7FFAF93FAA90
        public void ValidateIdAttribute(){} // RVA: 0x7FFAF93FAE90
        public void ValidateNameAttribute(){} // RVA: 0x7FFAF93FB100
        public void ValidateQNameAttribute(){} // RVA: 0x7FFAF93FB430
        public void ResolveSchemaLocationUri(){} // RVA: 0x7FFAF93FB5E0
        public void GetSchemaEntity(){} // RVA: 0x7FFAF93FB630
        public void GetChameleonSchema(){} // RVA: 0x7FFAF93FB670
        public void SetParent(){} // RVA: 0x7FFAF93FB880
        public void PreprocessAnnotation(){} // RVA: 0x7FFAF93FB9B0 | overloaded x2
    }

}