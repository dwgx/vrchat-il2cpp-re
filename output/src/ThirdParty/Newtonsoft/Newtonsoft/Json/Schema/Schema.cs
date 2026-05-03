// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Schema
// Classes: 14
// Methods: 226

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Schema
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE86B56960 | overloaded x2
        public void Validate(){} // RVA: 0x7FFE86B56B60 | overloaded x2
    }

    public class JsonSchema : Object
    {
        public string _id; // 0x10
        public string _title; // 0x18
        public System.Nullable`1<bool> _required; // 0x20
        public System.Nullable`1<bool> _readOnly; // 0x22
        public System.Nullable`1<bool> _hidden; // 0x24
        public System.Nullable`1<bool> _transient; // 0x26
        public string _description; // 0x28
        public System.Nullable`1<0x665C3754> _type; // 0x30
        public string _pattern; // 0x38
        public System.Nullable`1<int> _minimumLength; // 0x40
        public System.Nullable`1<int> _maximumLength; // 0x48
        public System.Nullable`1<double> _divisibleBy; // 0x50
        public System.Nullable`1<double> _minimum; // 0x60
        public System.Nullable`1<double> _maximum; // 0x70
        public System.Nullable`1<bool> _exclusiveMinimum; // 0x80
        public System.Nullable`1<bool> _exclusiveMaximum; // 0x82
        public System.Nullable`1<int> _minimumItems; // 0x84
        public System.Nullable`1<int> _maximumItems; // 0x8C
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> _items; // 0x98
        public bool _positionalItemsValidation; // 0xA0
        public Newtonsoft.Json.Schema.JsonSchema _additionalItems; // 0xA8
        public bool _allowAdditionalItems; // 0xB0
        public bool _uniqueItems; // 0xB1
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchema> _properties; // 0xB8
        public Newtonsoft.Json.Schema.JsonSchema _additionalProperties; // 0xC0
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchema> _patternProperties; // 0xC8
        public bool _allowAdditionalProperties; // 0xD0
        public string _requires; // 0xD8
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> _enum; // 0xE0
        public System.Nullable`1<0x665C3754> _disallow; // 0xE8
        public Newtonsoft.Json.Linq.JToken _default; // 0xF0
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> _extends; // 0xF8
        public string _format; // 0x100
        public string _location; // 0x108
        public string _internalId; // 0x110
        public string _deferredReference; // 0x118
        public bool _referencesResolved; // 0x120

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE81116380
        public void set_Id(){} // RVA: 0x7FFE810FCE30
        public void get_Title(){} // RVA: 0x7FFE810FE7C0
        public void set_Title(){} // RVA: 0x7FFE81161E80
        public void get_Required(){} // RVA: 0x7FFE850EF1D0
        public void set_Required(){} // RVA: 0x7FFE86601D50
        public void get_ReadOnly(){} // RVA: 0x7FFE86601D60
        public void set_ReadOnly(){} // RVA: 0x7FFE86601D70
        public void get_Hidden(){} // RVA: 0x7FFE86B57020
        public void set_Hidden(){} // RVA: 0x7FFE86B57030
        public void get_Transient(){} // RVA: 0x7FFE86B57040
        public void set_Transient(){} // RVA: 0x7FFE86B57050
        public void get_Description(){} // RVA: 0x7FFE81129130
        public void set_Description(){} // RVA: 0x7FFE810FCE90
        public void get_Type(){} // RVA: 0x7FFE8144E200
        public void set_Type(){} // RVA: 0x7FFE82D00170
        public void get_Pattern(){} // RVA: 0x7FFE8143BA80
        public void set_Pattern(){} // RVA: 0x7FFE81437330
        public void get_MinimumLength(){} // RVA: 0x7FFE81178740
        public void set_MinimumLength(){} // RVA: 0x7FFE84337900
        public void get_MaximumLength(){} // RVA: 0x7FFE81176730
        public void set_MaximumLength(){} // RVA: 0x7FFE82502600
        public void get_DivisibleBy(){} // RVA: 0x7FFE84E45FD0
        public void set_DivisibleBy(){} // RVA: 0x7FFE8667B700
        public void get_Minimum(){} // RVA: 0x7FFE8432FFC0
        public void set_Minimum(){} // RVA: 0x7FFE86B57060
        public void get_Maximum(){} // RVA: 0x7FFE86B57070
        public void set_Maximum(){} // RVA: 0x7FFE86B57080
        public void get_ExclusiveMinimum(){} // RVA: 0x7FFE86AD9CE0
        public void set_ExclusiveMinimum(){} // RVA: 0x7FFE86B57090
        public void get_ExclusiveMaximum(){} // RVA: 0x7FFE86B570A0
        public void set_ExclusiveMaximum(){} // RVA: 0x7FFE86B570B0
        public void get_MinimumItems(){} // RVA: 0x7FFE86B570C0
        public void set_MinimumItems(){} // RVA: 0x7FFE86B570D0
        public void get_MaximumItems(){} // RVA: 0x7FFE86B570E0
        public void set_MaximumItems(){} // RVA: 0x7FFE848BEE60
        public void get_Items(){} // RVA: 0x7FFE817AE360
        public void set_Items(){} // RVA: 0x7FFE8171B470
        public void get_PositionalItemsValidation(){} // RVA: 0x7FFE820E9360
        public void set_PositionalItemsValidation(){} // RVA: 0x7FFE818DBD80
        public void get_AdditionalItems(){} // RVA: 0x7FFE817AB5E0
        public void set_AdditionalItems(){} // RVA: 0x7FFE81857260
        public void get_AllowAdditionalItems(){} // RVA: 0x7FFE824A0700
        public void set_AllowAdditionalItems(){} // RVA: 0x7FFE824A0BA0
        public void get_UniqueItems(){} // RVA: 0x7FFE848BEF10
        public void set_UniqueItems(){} // RVA: 0x7FFE848BEF20
        public void get_Properties(){} // RVA: 0x7FFE811660B0
        public void set_Properties(){} // RVA: 0x7FFE811660C0
        public void get_AdditionalProperties(){} // RVA: 0x7FFE81166120
        public void set_AdditionalProperties(){} // RVA: 0x7FFE81166130
        public void get_PatternProperties(){} // RVA: 0x7FFE81253460
        public void set_PatternProperties(){} // RVA: 0x7FFE81253470
        public void get_AllowAdditionalProperties(){} // RVA: 0x7FFE81644E40
        public void set_AllowAdditionalProperties(){} // RVA: 0x7FFE82619150
        public void get_Requires(){} // RVA: 0x7FFE8181EA80
        public void set_Requires(){} // RVA: 0x7FFE8117C8A0
        public void get_Enum(){} // RVA: 0x7FFE8117C900
        public void set_Enum(){} // RVA: 0x7FFE8117C910
        public void get_Disallow(){} // RVA: 0x7FFE8117C970
        public void set_Disallow(){} // RVA: 0x7FFE86B570F0
        public void get_Default(){} // RVA: 0x7FFE811662A0
        public void set_Default(){} // RVA: 0x7FFE811662B0
        public void get_Extends(){} // RVA: 0x7FFE8158D5D0
        public void set_Extends(){} // RVA: 0x7FFE81B0E4B0
        public void get_Format(){} // RVA: 0x7FFE81828B50
        public void set_Format(){} // RVA: 0x7FFE81A58AB0
        public void get_Location(){} // RVA: 0x7FFE8181E3D0
        public void set_Location(){} // RVA: 0x7FFE81A60200
        public void get_InternalId(){} // RVA: 0x7FFE81317980
        public void get_DeferredReference(){} // RVA: 0x7FFE81318010
        public void set_DeferredReference(){} // RVA: 0x7FFE81317920
        public void get_ReferencesResolved(){} // RVA: 0x7FFE86B33050
        public void set_ReferencesResolved(){} // RVA: 0x7FFE86B33060
        public void .ctor(){} // RVA: 0x7FFE86B57100
        public void Read(){} // RVA: 0x7FFE86B57250 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE86B576A0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE86B578A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86B57AA0
    }

    public class JsonSchemaBuilder : Object
    {
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> _stack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B57C30
        public void Push(){} // RVA: 0x7FFE86B57E00
        public void Pop(){} // RVA: 0x7FFE86B57F00
        public void get_CurrentSchema(){} // RVA: 0x7FFE81129130
        public void Read(){} // RVA: 0x7FFE86B58000
        public void UnescapeReference(){} // RVA: 0x7FFE86B58160
        public void ResolveReferences(){} // RVA: 0x7FFE86B58240
        public void BuildSchema(){} // RVA: 0x7FFE86B58FC0
        public void ProcessSchemaProperties(){} // RVA: 0x7FFE86B59990
        public void ProcessExtends(){} // RVA: 0x7FFE86B5AED0
        public void ProcessEnum(){} // RVA: 0x7FFE86B5B260
        public void ProcessAdditionalProperties(){} // RVA: 0x7FFE86B5B680
        public void ProcessAdditionalItems(){} // RVA: 0x7FFE86B5B7A0
        public void ProcessProperties(){} // RVA: 0x7FFE86B5B8C0
        public void ProcessItems(){} // RVA: 0x7FFE86B5BCA0
        public void ProcessType(){} // RVA: 0x7FFE86B5C0F0
        public void MapType(){} // RVA: 0x7FFE86B5C680 | overloaded x2
    }

    public class JsonSchemaConstants : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86B5C880
    }

    public class JsonSchemaException : JsonException
    {
        public int _lineNumber; // 0x90
        public int _linePosition; // 0x94
        public string _path; // 0x98

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFE814AA220
        public void get_LinePosition(){} // RVA: 0x7FFE814AA230
        public void get_Path(){} // RVA: 0x7FFE817AE360
        public void .ctor(){} // RVA: 0x7FFE86B5CBB0 | overloaded x5
    }

    public class JsonSchemaGenerator : Object
    {
        public 0x665C385C _undefinedSchemaIdHandling; // 0x10
        public Newtonsoft.Json.Serialization.IContractResolver _contractResolver; // 0x18
        public Newtonsoft.Json.Schema.JsonSchemaResolver _resolver; // 0x20

        // ── Methods ──
        public void get_UndefinedSchemaIdHandling(){} // RVA: 0x7FFE811485C0
        public void set_UndefinedSchemaIdHandling(){} // RVA: 0x7FFE810FE0C0
        public void get_ContractResolver(){} // RVA: 0x7FFE86B5CC40
        public void set_ContractResolver(){} // RVA: 0x7FFE81161E80
        public void get_CurrentSchema(){} // RVA: 0x7FFE8144E200
        public void Push(){} // RVA: 0x7FFE86B5CCA0
        public void Pop(){} // RVA: 0x7FFE86B5CE00
        public void Generate(){} // RVA: 0x7FFE86B5D150 | overloaded x4
        public void GetTitle(){} // RVA: 0x7FFE86B5D2C0
        public void GetDescription(){} // RVA: 0x7FFE86B5D350
        public void GetTypeId(){} // RVA: 0x7FFE86B5D440
        public void GenerateInternal(){} // RVA: 0x7FFE86B5D560
        public void AddNullType(){} // RVA: 0x7FFE86B5E700
        public void HasFlag(){} // RVA: 0x7FFE86B5EB90 | overloaded x2
        public void GenerateObjectSchema(){} // RVA: 0x7FFE86B5E710
        public void GenerateISerializableContract(){} // RVA: 0x7FFE86B5EB70
        public void GetJsonSchemaType(){} // RVA: 0x7FFE86B5EC50
        public void .ctor(){} // RVA: 0x7FFE86B5EEA0
    }

    public class JsonSchemaModel : Object
    {
        public bool _required; // 0x10
        public 0x665C3754 _type; // 0x14
        public System.Nullable`1<int> _minimumLength; // 0x18
        public System.Nullable`1<int> _maximumLength; // 0x20
        public System.Nullable`1<double> _divisibleBy; // 0x28
        public System.Nullable`1<double> _minimum; // 0x38
        public System.Nullable`1<double> _maximum; // 0x48
        public bool _exclusiveMinimum; // 0x58
        public bool _exclusiveMaximum; // 0x59
        public System.Nullable`1<int> _minimumItems; // 0x5C
        public System.Nullable`1<int> _maximumItems; // 0x64
        public System.Collections.Generic.IList`1<string> _patterns; // 0x70
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel> _items; // 0x78
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaModel> _properties; // 0x80
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaModel> _patternProperties; // 0x88
        public Newtonsoft.Json.Schema.JsonSchemaModel _additionalProperties; // 0x90
        public Newtonsoft.Json.Schema.JsonSchemaModel _additionalItems; // 0x98
        public bool _positionalItemsValidation; // 0xA0
        public bool _allowAdditionalProperties; // 0xA1
        public bool _allowAdditionalItems; // 0xA2
        public bool _uniqueItems; // 0xA3
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> _enum; // 0xA8
        public 0x665C3754 _disallow; // 0xB0

        // ── Methods ──
        public void get_Required(){} // RVA: 0x7FFE811C55E0
        public void set_Required(){} // RVA: 0x7FFE811C55F0
        public void get_Type(){} // RVA: 0x7FFE8164B230
        public void set_Type(){} // RVA: 0x7FFE8164E0F0
        public void get_MinimumLength(){} // RVA: 0x7FFE810FE7C0
        public void set_MinimumLength(){} // RVA: 0x7FFE819EA910
        public void get_MaximumLength(){} // RVA: 0x7FFE811290C0
        public void set_MaximumLength(){} // RVA: 0x7FFE81859C50
        public void get_DivisibleBy(){} // RVA: 0x7FFE81E90600
        public void set_DivisibleBy(){} // RVA: 0x7FFE81E8E800
        public void get_Minimum(){} // RVA: 0x7FFE826F9FB0
        public void set_Minimum(){} // RVA: 0x7FFE82D001B0
        public void get_Maximum(){} // RVA: 0x7FFE81C1C440
        public void set_Maximum(){} // RVA: 0x7FFE81C1C640
        public void get_ExclusiveMinimum(){} // RVA: 0x7FFE813A1140
        public void set_ExclusiveMinimum(){} // RVA: 0x7FFE819E83C0
        public void get_ExclusiveMaximum(){} // RVA: 0x7FFE85BA8C00
        public void set_ExclusiveMaximum(){} // RVA: 0x7FFE86B5F180
        public void get_MinimumItems(){} // RVA: 0x7FFE8671A620
        public void set_MinimumItems(){} // RVA: 0x7FFE8671A630
        public void get_MaximumItems(){} // RVA: 0x7FFE86B5F190
        public void set_MaximumItems(){} // RVA: 0x7FFE86B5F1A0
        public void get_Patterns(){} // RVA: 0x7FFE811C3590
        public void set_Patterns(){} // RVA: 0x7FFE811C35A0
        public void get_Items(){} // RVA: 0x7FFE81463AE0
        public void set_Items(){} // RVA: 0x7FFE81464570
        public void get_Properties(){} // RVA: 0x7FFE81280C30
        public void set_Properties(){} // RVA: 0x7FFE81282380
        public void get_PatternProperties(){} // RVA: 0x7FFE8113A010
        public void set_PatternProperties(){} // RVA: 0x7FFE81280F90
        public void get_AdditionalProperties(){} // RVA: 0x7FFE8154EB60
        public void set_AdditionalProperties(){} // RVA: 0x7FFE818CE320
        public void get_AdditionalItems(){} // RVA: 0x7FFE817AE360
        public void set_AdditionalItems(){} // RVA: 0x7FFE8171B470
        public void get_PositionalItemsValidation(){} // RVA: 0x7FFE820E9360
        public void set_PositionalItemsValidation(){} // RVA: 0x7FFE818DBD80
        public void get_AllowAdditionalProperties(){} // RVA: 0x7FFE82AB0F00
        public void set_AllowAdditionalProperties(){} // RVA: 0x7FFE82AB0F10
        public void get_AllowAdditionalItems(){} // RVA: 0x7FFE86B5F1B0
        public void set_AllowAdditionalItems(){} // RVA: 0x7FFE86B5F1C0
        public void get_UniqueItems(){} // RVA: 0x7FFE86B5F1D0
        public void set_UniqueItems(){} // RVA: 0x7FFE86B5F1E0
        public void get_Enum(){} // RVA: 0x7FFE817AB5E0
        public void set_Enum(){} // RVA: 0x7FFE81857260
        public void get_Disallow(){} // RVA: 0x7FFE82E64BF0
        public void set_Disallow(){} // RVA: 0x7FFE86B5F1F0
        public void .ctor(){} // RVA: 0x7FFE86B5F200
        public void Create(){} // RVA: 0x7FFE86B5F220
        public void Combine(){} // RVA: 0x7FFE86B5F420
    }

    public class JsonSchemaModelBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFE86B5FAE0
        public void AddSchema(){} // RVA: 0x7FFE86B5FCE0
        public void AddProperties(){} // RVA: 0x7FFE86B60320
        public void AddProperty(){} // RVA: 0x7FFE86B606A0
        public void AddItem(){} // RVA: 0x7FFE86B60820
        public void AddAdditionalProperties(){} // RVA: 0x7FFE86B60990
        public void AddAdditionalItems(){} // RVA: 0x7FFE86B60A00
        public void BuildNodeModel(){} // RVA: 0x7FFE86B60A70
        public void .ctor(){} // RVA: 0x7FFE86B612D0
    }

    public class JsonSchemaNode : Object
    {
        public string _id; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<Newtonsoft.Json.Schema.JsonSchema> _schemas; // 0x18
        public System.Collections.Generic.Dictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaNode> _properties; // 0x20
        public System.Collections.Generic.Dictionary`2<string,Newtonsoft.Json.Schema.JsonSchemaNode> _patternProperties; // 0x28
        public System.Collections.Generic.List`1<Newtonsoft.Json.Schema.JsonSchemaNode> _items; // 0x30
        public Newtonsoft.Json.Schema.JsonSchemaNode _additionalProperties; // 0x38
        public Newtonsoft.Json.Schema.JsonSchemaNode _additionalItems; // 0x40

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE81116380
        public void get_Schemas(){} // RVA: 0x7FFE810FE7C0
        public void get_Properties(){} // RVA: 0x7FFE811290C0
        public void get_PatternProperties(){} // RVA: 0x7FFE81129130
        public void get_Items(){} // RVA: 0x7FFE8144E200
        public void get_AdditionalProperties(){} // RVA: 0x7FFE8143BA80
        public void set_AdditionalProperties(){} // RVA: 0x7FFE81437330
        public void get_AdditionalItems(){} // RVA: 0x7FFE81178740
        public void set_AdditionalItems(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE86B61820 | overloaded x2
        public void Combine(){} // RVA: 0x7FFE86B61DA0
        public void GetId(){} // RVA: 0x7FFE86B61E10
    }

    public class JsonSchemaNodeCollection : KeyedCollection`2
    {
        // ── Methods ──
        public void GetKeyForItem(){} // RVA: 0x7FFE81994180
        public void .ctor(){} // RVA: 0x7FFE86B62210
    }

    public class JsonSchemaResolver : Object
    {
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema> _loadedSchemas; // 0x10

        // ── Methods ──
        public void get_LoadedSchemas(){} // RVA: 0x7FFE81116380
        public void set_LoadedSchemas(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86B62270
        public void GetSchema(){} // RVA: 0x7FFE86B62330
    }

    public class JsonSchemaWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B62630
        public void ReferenceOrWriteSchema(){} // RVA: 0x7FFE86B62780
        public void WriteSchema(){} // RVA: 0x7FFE86B628A0
        public void WriteSchemaDictionaryIfNotNull(){} // RVA: 0x7FFE86B63AA0
        public void WriteItems(){} // RVA: 0x7FFE86B63D30
        public void WriteType(){} // RVA: 0x7FFE86B64000
        public void WritePropertyIfNotNull(){} // RVA: 0x7FFE86B645F0
    }

    public class ValidationEventArgs : EventArgs
    {
        public Newtonsoft.Json.Schema.JsonSchemaException _ex; // 0x10
        public object field_1; // 0x1C8
        public object field_2; // 0x1C9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B64700
        public void get_Exception(){} // RVA: 0x7FFE81116380
        public void get_Path(){} // RVA: 0x7FFE81759100
        public void get_Message(){} // RVA: 0x7FFE815888E0
    }

    public class ValidationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

}