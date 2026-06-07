// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 96

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class Parser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x693CDF0
        public void Parse(){} // RVA: 0x693D090
        public void StartParsing(){} // RVA: 0x693D100
        public void CheckSchemaRoot(){} // RVA: 0x693D870
        public void FinishParsing(){} // RVA: 0x32A5C0
        public void get_XmlSchema(){} // RVA: 0x37B370
        public void set_XmlResolver(){} // RVA: 0x3A55A0
        public void get_XdrSchema(){} // RVA: 0x358D50
        public void ParseReaderNode(){} // RVA: 0x693DA80
        public void ProcessAppInfoDocMarkup(){} // RVA: 0x693E380
        public void LoadElementNode(){} // RVA: 0x693E6C0
        public void CreateXmlNsAttribute(){} // RVA: 0x693EC70
        public void LoadAttributeNode(){} // RVA: 0x693EDB0
        public void LoadEntityReferenceInAttribute(){} // RVA: 0x693EF70
    }

    public class ParticleContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADC7E0 | overloaded x2
        public void InitValidation(){} // RVA: 0x6ADC850
        public void ValidateElement(){} // RVA: 0x6ADC890
        public void CompleteValidation(){} // RVA: 0x6ADC8D0
        public void Start(){} // RVA: 0x6ADC910
        public void OpenGroup(){} // RVA: 0x6ADCC60
        public void CloseGroup(){} // RVA: 0x6ADCC90
        public void Exists(){} // RVA: 0x6ADCE70
        public void AddName(){} // RVA: 0x6ADCEB0
        public void AddNamespaceList(){} // RVA: 0x6ADCF60
        public void AddLeafNode(){} // RVA: 0x6ADD0A0
        public void AddChoice(){} // RVA: 0x6ADD1A0
        public void AddSequence(){} // RVA: 0x6ADD2E0
        public void AddStar(){} // RVA: 0x6ADD420
        public void AddPlus(){} // RVA: 0x6ADD470
        public void AddQMark(){} // RVA: 0x6ADD4C0
        public void AddLeafRange(){} // RVA: 0x6ADD510
        public void Closure(){} // RVA: 0x6ADD630
        public void Finish(){} // RVA: 0x6ADD830
        public void CalculateTotalFollowposForRangeNodes(){} // RVA: 0x6ADE110
        public void CheckCMUPAWithLeafRangeNodes(){} // RVA: 0x6ADE540
        public void GetApplicableMinMaxFollowPos(){} // RVA: 0x6ADE760
        public void CheckUniqueParticleAttribution(){} // RVA: 0x6ADEAE0 | overloaded x2
        public void BuildTransitionTable(){} // RVA: 0x6ADED60
    }

    public class PlusNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x6ADBF20
        public void get_IsNullable(){} // RVA: 0x7F02E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Position
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C6C70
    }

    public class Positions
    {
        public object IsNullable;
        public object IsRangeNode;

        // ── Methods ──
        public void Add(){} // RVA: 0x6ADA2D0
        public void get_Item(){} // RVA: 0x6ADA3C0
        public void get_Count(){} // RVA: 0x5DFC050
        public void .ctor(){} // RVA: 0x6ADA460
    }

    public class Preprocessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x693F200
        public void Execute(){} // RVA: 0x693F400
        public void Cleanup(){} // RVA: 0x693FD80
        public void CleanupRedefine(){} // RVA: 0x693FE80
        public void set_XmlResolver(){} // RVA: 0x3480C0
        public void set_ReaderSettings(){} // RVA: 0x9AA5F0
        public void set_SchemaLocations(){} // RVA: 0x4C34F0
        public void set_ChameleonSchemas(){} // RVA: 0x464450
        public void get_RootSchema(){} // RVA: 0x3A5500
        public void BuildSchemaList(){} // RVA: 0x693FF40
        public void LoadExternals(){} // RVA: 0x6940110
        public void GetBuildInSchema(){} // RVA: 0x69410B0
        public void BuildRefNamespaces(){} // RVA: 0x6941ED0
        public void ParseUri(){} // RVA: 0x69421A0
        public void Preprocess(){} // RVA: 0x6942270
        public void CopyIncludedComponents(){} // RVA: 0x69437A0
        public void PreprocessRedefine(){} // RVA: 0x6944730
        public void GetIncludedSet(){} // RVA: 0x6945730
        public void GetParentSchema(){} // RVA: 0x69458C0
        public void SetSchemaDefaults(){} // RVA: 0x6945940
        public void CountGroupSelfReference(){} // RVA: 0x6945A50
        public void CheckRefinedGroup(){} // RVA: 0x6945E20
        public void CheckRefinedAttributeGroup(){} // RVA: 0x6945ED0
        public void CheckRefinedSimpleType(){} // RVA: 0x6946060
        public void CheckRefinedComplexType(){} // RVA: 0x69461B0
        public void PreprocessAttribute(){} // RVA: 0x6946650
        public void PreprocessLocalAttribute(){} // RVA: 0x6946830
        public void PreprocessAttributeContent(){} // RVA: 0x6946AF0
        public void PreprocessAttributeGroup(){} // RVA: 0x6946DF0
        public void PreprocessElement(){} // RVA: 0x6946F60
        public void PreprocessLocalElement(){} // RVA: 0x6947250
        public void PreprocessElementContent(){} // RVA: 0x6947780
        public void PreprocessIdentityConstraint(){} // RVA: 0x6947C60
        public void PreprocessSimpleType(){} // RVA: 0x6948180
        public void PreprocessComplexType(){} // RVA: 0x6948B30
        public void PreprocessGroup(){} // RVA: 0x69498E0
        public void PreprocessNotation(){} // RVA: 0x6949B20
        public void PreprocessParticle(){} // RVA: 0x6949D80
        public void PreprocessAttributes(){} // RVA: 0x694AA90
        public void ValidateIdAttribute(){} // RVA: 0x694AE90
        public void ValidateNameAttribute(){} // RVA: 0x694B100
        public void ValidateQNameAttribute(){} // RVA: 0x694B430
        public void ResolveSchemaLocationUri(){} // RVA: 0x694B5E0
        public void GetSchemaEntity(){} // RVA: 0x694B630
        public void GetChameleonSchema(){} // RVA: 0x694B670
        public void SetParent(){} // RVA: 0x694B880
        public void PreprocessAnnotation(){} // RVA: 0x694B9B0 | overloaded x2
    }

}