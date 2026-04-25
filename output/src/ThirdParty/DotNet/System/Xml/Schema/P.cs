// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 96

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class Parser : Object
    {
        public 0x6B162F50 XmlSchema; // 0x10
        public System.Xml.XmlNameTable XmlResolver; // 0x18
        public System.Xml.Schema.SchemaNames XdrSchema; // 0x20
        public System.Xml.Schema.ValidationEventHandler eventHandler; // 0x28
        public System.Xml.XmlNamespaceManager namespaceManager; // 0x30
        public System.Xml.XmlReader reader; // 0x38
        public System.Xml.PositionInfo positionInfo; // 0x40
        public bool isProcessNamespaces; // 0x48
        public int schemaXmlDepth; // 0x4C
        public int markupDepth; // 0x50
        public System.Xml.Schema.SchemaBuilder builder; // 0x58
        public System.Xml.Schema.XmlSchema schema; // 0x60
        public System.Xml.Schema.SchemaInfo xdrSchema; // 0x68
        public System.Xml.XmlResolver xmlResolver; // 0x70
        public System.Xml.XmlDocument dummyDocument; // 0x78
        public bool processMarkup; // 0x80
        public System.Xml.XmlNode parentNode; // 0x88
        public System.Xml.XmlNamespaceManager annotationNSManager; // 0x90
        public string xmlns; // 0x98
        public System.Xml.XmlCharType xmlCharType; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90D3910
        public void Parse(){} // RVA: 0x7FFAC90D3BB0
        public void StartParsing(){} // RVA: 0x7FFAC90D3C20
        public void CheckSchemaRoot(){} // RVA: 0x7FFAC90D4390
        public void FinishParsing(){} // RVA: 0x7FFAC2F6E5C0
        public void get_XmlSchema(){} // RVA: 0x7FFAC2FBF370
        public void set_XmlResolver(){} // RVA: 0x7FFAC2FE95A0
        public void get_XdrSchema(){} // RVA: 0x7FFAC2F9CD50
        public void ParseReaderNode(){} // RVA: 0x7FFAC90D45A0
        public void ProcessAppInfoDocMarkup(){} // RVA: 0x7FFAC90D4EA0
        public void LoadElementNode(){} // RVA: 0x7FFAC90D51E0
        public void CreateXmlNsAttribute(){} // RVA: 0x7FFAC90D5790
        public void LoadAttributeNode(){} // RVA: 0x7FFAC90D58D0
        public void LoadEntityReferenceInAttribute(){} // RVA: 0x7FFAC90D5A90
    }

    public class ParticleContentValidator : ContentValidator
    {
        public System.Xml.Schema.SymbolsDictionary symbols; // 0x18
        public System.Xml.Schema.Positions positions; // 0x20
        public System.Collections.Stack stack; // 0x28
        public System.Xml.Schema.SyntaxTreeNode contentNode; // 0x30
        public bool isPartial; // 0x38
        public int minMaxNodesCount; // 0x3C
        public bool enableUpaCheck; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9273360 | overloaded x2
        public void InitValidation(){} // RVA: 0x7FFAC92733D0
        public void ValidateElement(){} // RVA: 0x7FFAC9273410
        public void CompleteValidation(){} // RVA: 0x7FFAC9273450
        public void Start(){} // RVA: 0x7FFAC9273490
        public void OpenGroup(){} // RVA: 0x7FFAC92737E0
        public void CloseGroup(){} // RVA: 0x7FFAC9273810
        public void Exists(){} // RVA: 0x7FFAC92739F0
        public void AddName(){} // RVA: 0x7FFAC9273A30
        public void AddNamespaceList(){} // RVA: 0x7FFAC9273AE0
        public void AddLeafNode(){} // RVA: 0x7FFAC9273C20
        public void AddChoice(){} // RVA: 0x7FFAC9273D20
        public void AddSequence(){} // RVA: 0x7FFAC9273E60
        public void AddStar(){} // RVA: 0x7FFAC9273FA0
        public void AddPlus(){} // RVA: 0x7FFAC9273FF0
        public void AddQMark(){} // RVA: 0x7FFAC9274040
        public void AddLeafRange(){} // RVA: 0x7FFAC9274090
        public void Closure(){} // RVA: 0x7FFAC92741B0
        public void Finish(){} // RVA: 0x7FFAC92743B0
        public void CalculateTotalFollowposForRangeNodes(){} // RVA: 0x7FFAC9274C90
        public void CheckCMUPAWithLeafRangeNodes(){} // RVA: 0x7FFAC92750C0
        public void GetApplicableMinMaxFollowPos(){} // RVA: 0x7FFAC92752E0
        public void CheckUniqueParticleAttribution(){} // RVA: 0x7FFAC9275660 | overloaded x2
        public void BuildTransitionTable(){} // RVA: 0x7FFAC92758E0
    }

    public class PlusNode : InteriorNode
    {
        public object IsNullable;

        // ── Methods ──
        public void ConstructPos(){} // RVA: 0x7FFAC9272AA0
        public void get_IsNullable(){} // RVA: 0x7FFAC880FE40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Position : ValueType
    {
        public int symbol; // 0x10
        public object particle; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F24C0
    }

    public class Positions : Object
    {
        public System.Collections.ArrayList Item; // 0x10

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9270E50
        public void get_Item(){} // RVA: 0x7FFAC9270F40
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void .ctor(){} // RVA: 0x7FFAC9270FE0
    }

    public class Preprocessor : BaseProcessor
    {
        public string XmlResolver; // 0x40
        public string ReaderSettings; // 0x48
        public string SchemaLocations; // 0x50
        public System.Xml.Schema.XmlSchema ChameleonSchemas; // 0x58
        public System.Xml.Schema.XmlSchema RootSchema; // 0x60
        public 0x6B164550 elementFormDefault; // 0x68
        public 0x6B164550 attributeFormDefault; // 0x6C
        public 0x6B163E70 blockDefault; // 0x70
        public 0x6B163E70 finalDefault; // 0x74
        public System.Collections.Hashtable schemaLocations; // 0x78
        public System.Collections.Hashtable chameleonSchemas; // 0x80
        public System.Collections.Hashtable referenceNamespaces; // 0x88
        public System.Collections.Hashtable processedExternals; // 0x90
        public System.Collections.SortedList lockList; // 0x98
        public System.Xml.XmlReaderSettings readerSettings; // 0xA0
        public System.Xml.Schema.XmlSchema rootSchemaForRedefine; // 0xA8
        public System.Collections.ArrayList redefinedList; // 0xB0
        public System.Xml.Schema.XmlSchema builtInSchemaForXmlNS;
        public System.Xml.XmlResolver xmlResolver; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90D5D20
        public void Execute(){} // RVA: 0x7FFAC90D5F20
        public void Cleanup(){} // RVA: 0x7FFAC90D68A0
        public void CleanupRedefine(){} // RVA: 0x7FFAC90D69A0
        public void set_XmlResolver(){} // RVA: 0x7FFAC2F8C0C0
        public void set_ReaderSettings(){} // RVA: 0x7FFAC354E420
        public void set_SchemaLocations(){} // RVA: 0x7FFAC30E06F0
        public void set_ChameleonSchemas(){} // RVA: 0x7FFAC34D4AA0
        public void get_RootSchema(){} // RVA: 0x7FFAC2FE9500
        public void BuildSchemaList(){} // RVA: 0x7FFAC90D6A60
        public void LoadExternals(){} // RVA: 0x7FFAC90D6C30
        public void GetBuildInSchema(){} // RVA: 0x7FFAC90D7BD0
        public void BuildRefNamespaces(){} // RVA: 0x7FFAC90D89F0
        public void ParseUri(){} // RVA: 0x7FFAC90D8CC0
        public void Preprocess(){} // RVA: 0x7FFAC90D8D90
        public void CopyIncludedComponents(){} // RVA: 0x7FFAC90DA2C0
        public void PreprocessRedefine(){} // RVA: 0x7FFAC90DB250
        public void GetIncludedSet(){} // RVA: 0x7FFAC90DC250
        public void GetParentSchema(){} // RVA: 0x7FFAC90DC3E0
        public void SetSchemaDefaults(){} // RVA: 0x7FFAC90DC460
        public void CountGroupSelfReference(){} // RVA: 0x7FFAC90DC570
        public void CheckRefinedGroup(){} // RVA: 0x7FFAC90DC940
        public void CheckRefinedAttributeGroup(){} // RVA: 0x7FFAC90DC9F0
        public void CheckRefinedSimpleType(){} // RVA: 0x7FFAC90DCB80
        public void CheckRefinedComplexType(){} // RVA: 0x7FFAC90DCCD0
        public void PreprocessAttribute(){} // RVA: 0x7FFAC90DD170
        public void PreprocessLocalAttribute(){} // RVA: 0x7FFAC90DD350
        public void PreprocessAttributeContent(){} // RVA: 0x7FFAC90DD610
        public void PreprocessAttributeGroup(){} // RVA: 0x7FFAC90DD910
        public void PreprocessElement(){} // RVA: 0x7FFAC90DDA80
        public void PreprocessLocalElement(){} // RVA: 0x7FFAC90DDD70
        public void PreprocessElementContent(){} // RVA: 0x7FFAC90DE2A0
        public void PreprocessIdentityConstraint(){} // RVA: 0x7FFAC90DE780
        public void PreprocessSimpleType(){} // RVA: 0x7FFAC90DECA0
        public void PreprocessComplexType(){} // RVA: 0x7FFAC90DF650
        public void PreprocessGroup(){} // RVA: 0x7FFAC90E0400
        public void PreprocessNotation(){} // RVA: 0x7FFAC90E0640
        public void PreprocessParticle(){} // RVA: 0x7FFAC90E08A0
        public void PreprocessAttributes(){} // RVA: 0x7FFAC90E15B0
        public void ValidateIdAttribute(){} // RVA: 0x7FFAC90E19B0
        public void ValidateNameAttribute(){} // RVA: 0x7FFAC90E1C20
        public void ValidateQNameAttribute(){} // RVA: 0x7FFAC90E1F50
        public void ResolveSchemaLocationUri(){} // RVA: 0x7FFAC90E2100
        public void GetSchemaEntity(){} // RVA: 0x7FFAC90E2150
        public void GetChameleonSchema(){} // RVA: 0x7FFAC90E2190
        public void SetParent(){} // RVA: 0x7FFAC90E23A0
        public void PreprocessAnnotation(){} // RVA: 0x7FFAC90E24D0 | overloaded x2
    }

}