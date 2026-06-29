// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 93

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class Parser : Object
    {
        public object schemaType;
        public object nameTable;
        public object schemaNames;
        public object eventHandler;
        public object namespaceManager;
        public object reader;
        public object positionInfo;
        public object isProcessNamespaces;
        public object schemaXmlDepth;
        public object markupDepth;
        public object builder;
        public object schema;
        public object xdrSchema;
        public object xmlResolver;
        public object dummyDocument;
        public object processMarkup;
        public object parentNode;
        public object annotationNSManager;
        public object xmlns;
        public object xmlCharType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A22C0
        public void Parse(){} // RVA: 0x73A2570
        public void StartParsing(){} // RVA: 0x73A25E0
        public void CheckSchemaRoot(){} // RVA: 0x73A2E70
        public void FinishParsing(){} // RVA: 0xB8F8F0
        public void get_XmlSchema(){} // RVA: 0xBE2C60
        public void set_XmlResolver(){} // RVA: 0xC10060
        public void get_XdrSchema(){} // RVA: 0xBBFF90
        public void ParseReaderNode(){} // RVA: 0x73A3080
        public void ProcessAppInfoDocMarkup(){} // RVA: 0x73A3970
        public void LoadElementNode(){} // RVA: 0x73A3CB0
        public void CreateXmlNsAttribute(){} // RVA: 0x73A4250
        public void LoadAttributeNode(){} // RVA: 0x73A4380
        public void LoadEntityReferenceInAttribute(){} // RVA: 0x73A4540
    }

    public class ParticleContentValidator : ContentValidator
    {
        public object symbols;
        public object positions;
        public object stack;
        public object contentNode;
        public object isPartial;
        public object minMaxNodesCount;
        public object enableUpaCheck;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7540A00
        public void InitValidation(){} // RVA: 0x7540A70
        public void ValidateElement(){} // RVA: 0x7540AB0
        public void CompleteValidation(){} // RVA: 0x7540AF0
        public void Start(){} // RVA: 0x7540B30
        public void OpenGroup(){} // RVA: 0x7540E80
        public void CloseGroup(){} // RVA: 0x7540EB0
        public void Exists(){} // RVA: 0x7541090
        public void AddName(){} // RVA: 0x75410D0
        public void AddNamespaceList(){} // RVA: 0x7541180
        public void AddLeafNode(){} // RVA: 0x75412C0
        public void AddChoice(){} // RVA: 0x75413C0
        public void AddSequence(){} // RVA: 0x7541500
        public void AddStar(){} // RVA: 0x7541640
        public void AddPlus(){} // RVA: 0x7541690
        public void AddQMark(){} // RVA: 0x75416E0
        public void AddLeafRange(){} // RVA: 0x7541730
        public void Closure(){} // RVA: 0x7541850
        public void Finish(){} // RVA: 0x7541A50
        public void CalculateTotalFollowposForRangeNodes(){} // RVA: 0x75424D0
        public void CheckCMUPAWithLeafRangeNodes(){} // RVA: 0x7542920
        public void GetApplicableMinMaxFollowPos(){} // RVA: 0x7542B40
        public void CheckUniqueParticleAttribution(){} // RVA: 0x7542EA0
        public void BuildTransitionTable(){} // RVA: 0x7543120
    }

    public class PlusNode : InteriorNode
    {
        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7540190
        public void get_IsNullable(){} // RVA: 0x10AD460
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Position : ValueType
    {
        public object symbol;
        public object particle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3616C0
    }

    public class Positions : Object
    {
        public object positions;

        // ── Methods ──
        public void Add(){} // RVA: 0x753E5F0
        public void get_Item(){} // RVA: 0x753E6E0
        public void get_Count(){} // RVA: 0x6875CA0
        public void .ctor(){} // RVA: 0x753E780
    }

    public class Preprocessor : BaseProcessor
    {
        public object Xmlns;
        public object NsXsi;
        public object targetNamespace;
        public object rootSchema;
        public object currentSchema;
        public object elementFormDefault;
        public object attributeFormDefault;
        public object blockDefault;
        public object finalDefault;
        public object schemaLocations;
        public object chameleonSchemas;
        public object referenceNamespaces;
        public object processedExternals;
        public object lockList;
        public object readerSettings;
        public object rootSchemaForRedefine;
        public object redefinedList;
        public object builtInSchemaForXmlNS;
        public object xmlResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A47B0
        public void Execute(){} // RVA: 0x73A49B0
        public void Cleanup(){} // RVA: 0x73A5310
        public void CleanupRedefine(){} // RVA: 0x73A5410
        public void set_XmlResolver(){} // RVA: 0xBAE3C0
        public void set_ReaderSettings(){} // RVA: 0xD5CCD0
        public void set_SchemaLocations(){} // RVA: 0xCD4740
        public void set_ChameleonSchemas(){} // RVA: 0xCD3600
        public void get_RootSchema(){} // RVA: 0xC0FFC0
        public void BuildSchemaList(){} // RVA: 0x73A54B0
        public void LoadExternals(){} // RVA: 0x73A5670
        public void GetBuildInSchema(){} // RVA: 0x73A65A0
        public void BuildRefNamespaces(){} // RVA: 0x73A7480
        public void ParseUri(){} // RVA: 0x73A7740
        public void Preprocess(){} // RVA: 0x73A7810
        public void CopyIncludedComponents(){} // RVA: 0x73A8D50
        public void PreprocessRedefine(){} // RVA: 0x73A9C30
        public void GetIncludedSet(){} // RVA: 0x73AABF0
        public void GetParentSchema(){} // RVA: 0x73AAD80
        public void SetSchemaDefaults(){} // RVA: 0x73AAE10
        public void CountGroupSelfReference(){} // RVA: 0x73AAF20
        public void CheckRefinedGroup(){} // RVA: 0x73AB2E0
        public void CheckRefinedAttributeGroup(){} // RVA: 0x73AB390
        public void CheckRefinedSimpleType(){} // RVA: 0x73AB500
        public void CheckRefinedComplexType(){} // RVA: 0x73AB650
        public void PreprocessAttribute(){} // RVA: 0x73ABAF0
        public void PreprocessLocalAttribute(){} // RVA: 0x73ABDA0
        public void PreprocessAttributeContent(){} // RVA: 0x73AC140
        public void PreprocessAttributeGroup(){} // RVA: 0x73AC440
        public void PreprocessElement(){} // RVA: 0x73AC670
        public void PreprocessLocalElement(){} // RVA: 0x73ACA20
        public void PreprocessElementContent(){} // RVA: 0x73AD020
        public void PreprocessIdentityConstraint(){} // RVA: 0x73AD510
        public void PreprocessSimpleType(){} // RVA: 0x73ADAE0
        public void PreprocessComplexType(){} // RVA: 0x73AE550
        public void PreprocessGroup(){} // RVA: 0x73AF380
        public void PreprocessNotation(){} // RVA: 0x73AF680
        public void PreprocessParticle(){} // RVA: 0x73AF9C0
        public void PreprocessAttributes(){} // RVA: 0x73B06A0
        public void ValidateIdAttribute(){} // RVA: 0x73B0A90
        public void ValidateNameAttribute(){} // RVA: 0x73B0D00
        public void ValidateQNameAttribute(){} // RVA: 0x73B1020
        public void ResolveSchemaLocationUri(){} // RVA: 0x73B11D0
        public void GetSchemaEntity(){} // RVA: 0x73B1220
        public void GetChameleonSchema(){} // RVA: 0x73B1260
        public void SetParent(){} // RVA: 0x73B1470
        public void PreprocessAnnotation(){} // RVA: 0x73B15B0
    }

}