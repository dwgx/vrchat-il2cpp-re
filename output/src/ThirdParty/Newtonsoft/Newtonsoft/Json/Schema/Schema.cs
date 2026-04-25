// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Schema
// Classes: 14
// Methods: 226

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Schema
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC87AD1F0 | overloaded x2
        public void Validate(){} // RVA: 0x7FFAC87AD3F0 | overloaded x2
    }

    public class JsonSchema : Object
    {
        public string Id; // 0x10
        public string Title; // 0x18
        public System.Nullable`1<bool> Required; // 0x20
        public System.Nullable`1<bool> ReadOnly; // 0x22
        public System.Nullable`1<bool> Hidden; // 0x24
        public System.Nullable`1<bool> Transient; // 0x26
        public string Description; // 0x28
        public System.Nullable`1<0x6B1C9E90> Type; // 0x30
        public string Pattern; // 0x38
        public System.Nullable`1<int> MinimumLength; // 0x40
        public System.Nullable`1<int> MaximumLength; // 0x48
        public System.Nullable`1<double> DivisibleBy; // 0x50
        public System.Nullable`1<double> Minimum; // 0x60
        public System.Nullable`1<double> Maximum; // 0x70
        public System.Nullable`1<bool> ExclusiveMinimum; // 0x80
        public System.Nullable`1<bool> ExclusiveMaximum; // 0x82
        public System.Nullable`1<int> MinimumItems; // 0x84
        public System.Nullable`1<int> MaximumItems; // 0x8C
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> Items; // 0x98
        public bool PositionalItemsValidation; // 0xA0
        public Newtonsoft.Json.Schema.JsonSchema AdditionalItems; // 0xA8
        public bool AllowAdditionalItems; // 0xB0
        public bool UniqueItems; // 0xB1
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchema> Properties; // 0xB8
        public Newtonsoft.Json.Schema.JsonSchema AdditionalProperties; // 0xC0
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchema> PatternProperties; // 0xC8
        public bool AllowAdditionalProperties; // 0xD0
        public string Requires; // 0xD8
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> Enum; // 0xE0
        public System.Nullable`1<0x6B1C9E90> Disallow; // 0xE8
        public Newtonsoft.Json.Linq.JToken Default; // 0xF0
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> Extends; // 0xF8
        public string Format; // 0x100
        public string Location; // 0x108
        public string InternalId; // 0x110
        public string DeferredReference; // 0x118
        public bool ReferencesResolved; // 0x120

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC2F3C380
        public void set_Id(){} // RVA: 0x7FFAC2F22E30
        public void get_Title(){} // RVA: 0x7FFAC2F247C0
        public void set_Title(){} // RVA: 0x7FFAC2F87E80
        public void get_Required(){} // RVA: 0x7FFAC6D68C80
        public void set_Required(){} // RVA: 0x7FFAC8258410
        public void get_ReadOnly(){} // RVA: 0x7FFAC8258420
        public void set_ReadOnly(){} // RVA: 0x7FFAC8258430
        public void get_Hidden(){} // RVA: 0x7FFAC87AD8B0
        public void set_Hidden(){} // RVA: 0x7FFAC87AD8C0
        public void get_Transient(){} // RVA: 0x7FFAC87AD8D0
        public void set_Transient(){} // RVA: 0x7FFAC87AD8E0
        public void get_Description(){} // RVA: 0x7FFAC2F4F130
        public void set_Description(){} // RVA: 0x7FFAC2F22E90
        public void get_Type(){} // RVA: 0x7FFAC31D95E0
        public void set_Type(){} // RVA: 0x7FFAC4A98000
        public void get_Pattern(){} // RVA: 0x7FFAC31D0140
        public void set_Pattern(){} // RVA: 0x7FFAC31D0C20
        public void get_MinimumLength(){} // RVA: 0x7FFAC2F9E740
        public void set_MinimumLength(){} // RVA: 0x7FFAC5FE03B0
        public void get_MaximumLength(){} // RVA: 0x7FFAC2F9C730
        public void set_MaximumLength(){} // RVA: 0x7FFAC4248FC0
        public void get_DivisibleBy(){} // RVA: 0x7FFAC6AD4D90
        public void set_DivisibleBy(){} // RVA: 0x7FFAC82D1E00
        public void get_Minimum(){} // RVA: 0x7FFAC5FD8A60
        public void set_Minimum(){} // RVA: 0x7FFAC87AD8F0
        public void get_Maximum(){} // RVA: 0x7FFAC87AD900
        public void set_Maximum(){} // RVA: 0x7FFAC87AD910
        public void get_ExclusiveMinimum(){} // RVA: 0x7FFAC8730560
        public void set_ExclusiveMinimum(){} // RVA: 0x7FFAC87AD920
        public void get_ExclusiveMaximum(){} // RVA: 0x7FFAC87AD930
        public void set_ExclusiveMaximum(){} // RVA: 0x7FFAC87AD940
        public void get_MinimumItems(){} // RVA: 0x7FFAC87AD950
        public void set_MinimumItems(){} // RVA: 0x7FFAC87AD960
        public void get_MaximumItems(){} // RVA: 0x7FFAC87AD970
        public void set_MaximumItems(){} // RVA: 0x7FFAC6539400
        public void get_Items(){} // RVA: 0x7FFAC354DFB0
        public void set_Items(){} // RVA: 0x7FFAC354E3C0
        public void get_PositionalItemsValidation(){} // RVA: 0x7FFAC45C9D50
        public void set_PositionalItemsValidation(){} // RVA: 0x7FFAC37B1910
        public void get_AdditionalItems(){} // RVA: 0x7FFAC354B1A0
        public void set_AdditionalItems(){} // RVA: 0x7FFAC334B370
        public void get_AllowAdditionalItems(){} // RVA: 0x7FFAC41E71E0
        public void set_AllowAdditionalItems(){} // RVA: 0x7FFAC41E6D30
        public void get_UniqueItems(){} // RVA: 0x7FFAC65394B0
        public void set_UniqueItems(){} // RVA: 0x7FFAC65394C0
        public void get_Properties(){} // RVA: 0x7FFAC2F8C0B0
        public void set_Properties(){} // RVA: 0x7FFAC2F8C0C0
        public void get_AdditionalProperties(){} // RVA: 0x7FFAC2F8C120
        public void set_AdditionalProperties(){} // RVA: 0x7FFAC2F8C130
        public void get_PatternProperties(){} // RVA: 0x7FFAC3079460
        public void set_PatternProperties(){} // RVA: 0x7FFAC3079470
        public void get_AllowAdditionalProperties(){} // RVA: 0x7FFAC33CFDE0
        public void set_AllowAdditionalProperties(){} // RVA: 0x7FFAC4323510
        public void get_Requires(){} // RVA: 0x7FFAC3540F70
        public void set_Requires(){} // RVA: 0x7FFAC2FA28A0
        public void get_Enum(){} // RVA: 0x7FFAC2FA2900
        public void set_Enum(){} // RVA: 0x7FFAC2FA2910
        public void get_Disallow(){} // RVA: 0x7FFAC2FA2970
        public void set_Disallow(){} // RVA: 0x7FFAC87AD980
        public void get_Default(){} // RVA: 0x7FFAC2F8C2A0
        public void set_Default(){} // RVA: 0x7FFAC2F8C2B0
        public void get_Extends(){} // RVA: 0x7FFAC3331F50
        public void set_Extends(){} // RVA: 0x7FFAC34A4860
        public void get_Format(){} // RVA: 0x7FFAC34F6C80
        public void set_Format(){} // RVA: 0x7FFAC34F6750
        public void get_Location(){} // RVA: 0x7FFAC36D1F40
        public void set_Location(){} // RVA: 0x7FFAC3929BF0
        public void get_InternalId(){} // RVA: 0x7FFAC354B170
        public void get_DeferredReference(){} // RVA: 0x7FFAC33BC6D0
        public void set_DeferredReference(){} // RVA: 0x7FFAC33B8580
        public void get_ReferencesResolved(){} // RVA: 0x7FFAC87898E0
        public void set_ReferencesResolved(){} // RVA: 0x7FFAC87898F0
        public void .ctor(){} // RVA: 0x7FFAC87AD990
        public void Read(){} // RVA: 0x7FFAC87ADAE0 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAC87ADF30 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC87AE130 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC87AE330
    }

    public class JsonSchemaBuilder : Object
    {
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> CurrentSchema; // 0x10
        public Newtonsoft.Json.Schema.JsonSchemaResolver _resolver; // 0x18
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchema> _documentSchemas; // 0x20
        public Newtonsoft.Json.Schema.JsonSchema _currentSchema; // 0x28
        public Newtonsoft.Json.Linq.JObject _rootSchema; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87AE4C0
        public void Push(){} // RVA: 0x7FFAC87AE690
        public void Pop(){} // RVA: 0x7FFAC87AE790
        public void get_CurrentSchema(){} // RVA: 0x7FFAC2F4F130
        public void Read(){} // RVA: 0x7FFAC87AE890
        public void UnescapeReference(){} // RVA: 0x7FFAC87AE9F0
        public void ResolveReferences(){} // RVA: 0x7FFAC87AEAD0
        public void BuildSchema(){} // RVA: 0x7FFAC87AF850
        public void ProcessSchemaProperties(){} // RVA: 0x7FFAC87B0220
        public void ProcessExtends(){} // RVA: 0x7FFAC87B1760
        public void ProcessEnum(){} // RVA: 0x7FFAC87B1AF0
        public void ProcessAdditionalProperties(){} // RVA: 0x7FFAC87B1F10
        public void ProcessAdditionalItems(){} // RVA: 0x7FFAC87B2030
        public void ProcessProperties(){} // RVA: 0x7FFAC87B2150
        public void ProcessItems(){} // RVA: 0x7FFAC87B2530
        public void ProcessType(){} // RVA: 0x7FFAC87B2980
        public void MapType(){} // RVA: 0x7FFAC87B2F10 | overloaded x2
    }

    public class JsonSchemaConstants : Object
    {
        public string TypePropertyName;
        public string PropertiesPropertyName;
        public string ItemsPropertyName;
        public string AdditionalItemsPropertyName;
        public string RequiredPropertyName;
        public string PatternPropertiesPropertyName;
        public string AdditionalPropertiesPropertyName;
        public string RequiresPropertyName;
        public string MinimumPropertyName;
        public string MaximumPropertyName;
        public string ExclusiveMinimumPropertyName;
        public string ExclusiveMaximumPropertyName;
        public string MinimumItemsPropertyName;
        public string MaximumItemsPropertyName;
        public string PatternPropertyName;
        public string MaximumLengthPropertyName;
        public string MinimumLengthPropertyName;
        public string EnumPropertyName;
        public string ReadOnlyPropertyName;
        public string TitlePropertyName;
        public string DescriptionPropertyName;
        public string FormatPropertyName;
        public string DefaultPropertyName;
        public string TransientPropertyName;
        public string DivisibleByPropertyName;
        public string HiddenPropertyName;
        public string DisallowPropertyName;
        public string ExtendsPropertyName;
        public string IdPropertyName;
        public string UniqueItemsPropertyName;
        public string OptionValuePropertyName;
        public string OptionLabelPropertyName;
        public System.Collections.Generic.IDictionary`2<string,0x6B1C9E90> JsonSchemaTypeMapping;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC87B3110
    }

    public class JsonSchemaException : JsonException
    {
        public int LineNumber; // 0x90
        public int LinePosition; // 0x94
        public string Path; // 0x98

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFAC3220660
        public void get_LinePosition(){} // RVA: 0x7FFAC3220670
        public void get_Path(){} // RVA: 0x7FFAC354DFB0
        public void .ctor(){} // RVA: 0x7FFAC87B3440 | overloaded x5
    }

    public class JsonSchemaGenerator : Object
    {
        public 0x6B1C9F98 UndefinedSchemaIdHandling; // 0x10
        public Newtonsoft.Json.Serialization.IContractResolver ContractResolver; // 0x18
        public Newtonsoft.Json.Schema.JsonSchemaResolver CurrentSchema; // 0x20
        public System.Collections.Generic.IList`1<TypeSchema> _stack; // 0x28
        public Newtonsoft.Json.Schema.JsonSchema _currentSchema; // 0x30

        // ── Methods ──
        public void get_UndefinedSchemaIdHandling(){} // RVA: 0x7FFAC2F6E5C0
        public void set_UndefinedSchemaIdHandling(){} // RVA: 0x7FFAC2F240C0
        public void get_ContractResolver(){} // RVA: 0x7FFAC87B34D0
        public void set_ContractResolver(){} // RVA: 0x7FFAC2F87E80
        public void get_CurrentSchema(){} // RVA: 0x7FFAC31D95E0
        public void Push(){} // RVA: 0x7FFAC87B3530
        public void Pop(){} // RVA: 0x7FFAC87B3690
        public void Generate(){} // RVA: 0x7FFAC87B39E0 | overloaded x4
        public void GetTitle(){} // RVA: 0x7FFAC87B3B50
        public void GetDescription(){} // RVA: 0x7FFAC87B3BE0
        public void GetTypeId(){} // RVA: 0x7FFAC87B3CD0
        public void GenerateInternal(){} // RVA: 0x7FFAC87B3DF0
        public void AddNullType(){} // RVA: 0x7FFAC87B4F90
        public void HasFlag(){} // RVA: 0x7FFAC87B5420 | overloaded x2
        public void GenerateObjectSchema(){} // RVA: 0x7FFAC87B4FA0
        public void GenerateISerializableContract(){} // RVA: 0x7FFAC87B5400
        public void GetJsonSchemaType(){} // RVA: 0x7FFAC87B54E0
        public void .ctor(){} // RVA: 0x7FFAC87B5730
    }

    public class JsonSchemaModel : Object
    {
        public bool Required; // 0x10
        public 0x6B1C9E90 Type; // 0x14
        public System.Nullable`1<int> MinimumLength; // 0x18
        public System.Nullable`1<int> MaximumLength; // 0x20
        public System.Nullable`1<double> DivisibleBy; // 0x28
        public System.Nullable`1<double> Minimum; // 0x38
        public System.Nullable`1<double> Maximum; // 0x48
        public bool ExclusiveMinimum; // 0x58
        public bool ExclusiveMaximum; // 0x59
        public System.Nullable`1<int> MinimumItems; // 0x5C
        public System.Nullable`1<int> MaximumItems; // 0x64
        public System.Collections.Generic.IList`1<string> Patterns; // 0x70
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel> Items; // 0x78
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaModel> Properties; // 0x80
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaModel> PatternProperties; // 0x88
        public Newtonsoft.Json.Schema.JsonSchemaModel AdditionalProperties; // 0x90
        public Newtonsoft.Json.Schema.JsonSchemaModel AdditionalItems; // 0x98
        public bool PositionalItemsValidation; // 0xA0
        public bool AllowAdditionalProperties; // 0xA1
        public bool AllowAdditionalItems; // 0xA2
        public bool UniqueItems; // 0xA3
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> Enum; // 0xA8
        public 0x6B1C9E90 Disallow; // 0xB0

        // ── Methods ──
        public void get_Required(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Required(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Type(){} // RVA: 0x7FFAC33D5A20
        public void set_Type(){} // RVA: 0x7FFAC33D4990
        public void get_MinimumLength(){} // RVA: 0x7FFAC2F247C0
        public void set_MinimumLength(){} // RVA: 0x7FFAC38920D0
        public void get_MaximumLength(){} // RVA: 0x7FFAC2F4F0C0
        public void set_MaximumLength(){} // RVA: 0x7FFAC370BEE0
        public void get_DivisibleBy(){} // RVA: 0x7FFAC3BCF020
        public void set_DivisibleBy(){} // RVA: 0x7FFAC3BCC210
        public void get_Minimum(){} // RVA: 0x7FFAC4426F60
        public void set_Minimum(){} // RVA: 0x7FFAC4A97FB0
        public void get_Maximum(){} // RVA: 0x7FFAC4A7F120
        public void set_Maximum(){} // RVA: 0x7FFAC87B5A10
        public void get_ExclusiveMinimum(){} // RVA: 0x7FFAC313F600
        public void set_ExclusiveMinimum(){} // RVA: 0x7FFAC3892770
        public void get_ExclusiveMaximum(){} // RVA: 0x7FFAC778CF40
        public void set_ExclusiveMaximum(){} // RVA: 0x7FFAC87B5A20
        public void get_MinimumItems(){} // RVA: 0x7FFAC8370D20
        public void set_MinimumItems(){} // RVA: 0x7FFAC8370D30
        public void get_MaximumItems(){} // RVA: 0x7FFAC87B5A30
        public void set_MaximumItems(){} // RVA: 0x7FFAC87B5A40
        public void get_Patterns(){} // RVA: 0x7FFAC2FE9590
        public void set_Patterns(){} // RVA: 0x7FFAC2FE95A0
        public void get_Items(){} // RVA: 0x7FFAC30E5600
        public void set_Items(){} // RVA: 0x7FFAC30E06F0
        public void get_Properties(){} // RVA: 0x7FFAC32EF410
        public void set_Properties(){} // RVA: 0x7FFAC34D4AA0
        public void get_PatternProperties(){} // RVA: 0x7FFAC2F60010
        public void set_PatternProperties(){} // RVA: 0x7FFAC354E300
        public void get_AdditionalProperties(){} // RVA: 0x7FFAC32EF640
        public void set_AdditionalProperties(){} // RVA: 0x7FFAC354E360
        public void get_AdditionalItems(){} // RVA: 0x7FFAC354DFB0
        public void set_AdditionalItems(){} // RVA: 0x7FFAC354E3C0
        public void get_PositionalItemsValidation(){} // RVA: 0x7FFAC45C9D50
        public void set_PositionalItemsValidation(){} // RVA: 0x7FFAC37B1910
        public void get_AllowAdditionalProperties(){} // RVA: 0x7FFAC4848B60
        public void set_AllowAdditionalProperties(){} // RVA: 0x7FFAC4848B70
        public void get_AllowAdditionalItems(){} // RVA: 0x7FFAC87B5A50
        public void set_AllowAdditionalItems(){} // RVA: 0x7FFAC87B5A60
        public void get_UniqueItems(){} // RVA: 0x7FFAC87B5A70
        public void set_UniqueItems(){} // RVA: 0x7FFAC87B5A80
        public void get_Enum(){} // RVA: 0x7FFAC354B1A0
        public void set_Enum(){} // RVA: 0x7FFAC334B370
        public void get_Disallow(){} // RVA: 0x7FFAC4BF81F0
        public void set_Disallow(){} // RVA: 0x7FFAC87B5A90
        public void .ctor(){} // RVA: 0x7FFAC87B5AA0
        public void Create(){} // RVA: 0x7FFAC87B5AC0
        public void Combine(){} // RVA: 0x7FFAC87B5CC0
    }

    public class JsonSchemaModelBuilder : Object
    {
        public Newtonsoft.Json.Schema.JsonSchemaNodeCollection _nodes; // 0x10
        public System.Collections.Generic.Dictionary`2<Newtonsoft.Json.Schema.JsonSchemaNode,Newtonsoft.Json.Schema.JsonSchemaModel> _nodeModels; // 0x18
        public Newtonsoft.Json.Schema.JsonSchemaNode _node; // 0x20

        // ── Methods ──
        public void Build(){} // RVA: 0x7FFAC87B6380
        public void AddSchema(){} // RVA: 0x7FFAC87B6580
        public void AddProperties(){} // RVA: 0x7FFAC87B6BC0
        public void AddProperty(){} // RVA: 0x7FFAC87B6F40
        public void AddItem(){} // RVA: 0x7FFAC87B70C0
        public void AddAdditionalProperties(){} // RVA: 0x7FFAC87B7230
        public void AddAdditionalItems(){} // RVA: 0x7FFAC87B72A0
        public void BuildNodeModel(){} // RVA: 0x7FFAC87B7310
        public void .ctor(){} // RVA: 0x7FFAC87B7B70
    }

    public class JsonSchemaNode : Object
    {
        public string Id; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<Newtonsoft.Json.Schema.JsonSchema> Schemas; // 0x18
        public System.Collections.Generic.Dictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaNode> Properties; // 0x20
        public System.Collections.Generic.Dictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaNode> PatternProperties; // 0x28
        public System.Collections.Generic.List`1<Newtonsoft.Json.Schema.JsonSchemaNode> Items; // 0x30
        public Newtonsoft.Json.Schema.JsonSchemaNode AdditionalProperties; // 0x38
        public Newtonsoft.Json.Schema.JsonSchemaNode AdditionalItems; // 0x40

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC2F3C380
        public void get_Schemas(){} // RVA: 0x7FFAC2F247C0
        public void get_Properties(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PatternProperties(){} // RVA: 0x7FFAC2F4F130
        public void get_Items(){} // RVA: 0x7FFAC31D95E0
        public void get_AdditionalProperties(){} // RVA: 0x7FFAC31D0140
        public void set_AdditionalProperties(){} // RVA: 0x7FFAC31D0C20
        public void get_AdditionalItems(){} // RVA: 0x7FFAC2F9E740
        public void set_AdditionalItems(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC87B80C0 | overloaded x2
        public void Combine(){} // RVA: 0x7FFAC87B8640
        public void GetId(){} // RVA: 0x7FFAC87B86B0
    }

    public class JsonSchemaNodeCollection : KeyedCollection`2
    {
        // ── Methods ──
        public void GetKeyForItem(){} // RVA: 0x7FFAC383A0B0
        public void .ctor(){} // RVA: 0x7FFAC87B8AB0
    }

    public class JsonSchemaResolver : Object
    {
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> LoadedSchemas; // 0x10

        // ── Methods ──
        public void get_LoadedSchemas(){} // RVA: 0x7FFAC2F3C380
        public void set_LoadedSchemas(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC87B8B10
        public void GetSchema(){} // RVA: 0x7FFAC87B8BD0
    }

    public class JsonSchemaWriter : Object
    {
        public Newtonsoft.Json.JsonWriter _writer; // 0x10
        public Newtonsoft.Json.Schema.JsonSchemaResolver _resolver; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87B8ED0
        public void ReferenceOrWriteSchema(){} // RVA: 0x7FFAC87B9020
        public void WriteSchema(){} // RVA: 0x7FFAC87B9140
        public void WriteSchemaDictionaryIfNotNull(){} // RVA: 0x7FFAC87BA340
        public void WriteItems(){} // RVA: 0x7FFAC87BA5D0
        public void WriteType(){} // RVA: 0x7FFAC87BA8A0
        public void WritePropertyIfNotNull(){} // RVA: 0x7FFAC87BAE90
    }

    public class ValidationEventArgs : EventArgs
    {
        public Newtonsoft.Json.Schema.JsonSchemaException Exception; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87BAFA0
        public void get_Exception(){} // RVA: 0x7FFAC2F3C380
        public void get_Path(){} // RVA: 0x7FFAC34AEA30
        public void get_Message(){} // RVA: 0x7FFAC87BB0A0
    }

    public class ValidationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

}