// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 10
// Methods: 287

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable : JsonNameTable
    {
        public int HashCodeRandomizer;
        public int _count; // 0x10
        public Entry[] _entries; // 0x18
        public int _mask; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53B094E0
        public void .ctor(){} // RVA: 0x7FFD53B09520
        public void Get(){} // RVA: 0x7FFD53B095C0
        public void Add(){} // RVA: 0x7FFD53B097B0
        public void AddEntry(){} // RVA: 0x7FFD53B099F0
        public void Grow(){} // RVA: 0x7FFD53B09D20
        public void TextEquals(){} // RVA: 0x7FFD53B09EC0
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7FFD4E087DE0
        public void Return(){} // RVA: 0x7FFD4E090A40
    }

    public class JsonContainerAttribute : Attribute
    {
        public string Id; // 0x10
        public string Title; // 0x18
        public string Description; // 0x20
        public System.Type ItemConverterType; // 0x28
        public object[] ItemConverterParameters; // 0x30
        public 0x66529548 NamingStrategyType; // 0x38
        public System.Nullable`1<bool> NamingStrategyParameters; // 0x40
        public System.Nullable`1<bool> NamingStrategyInstance; // 0x42
        public System.Nullable`1<0x66525A80> IsReference; // 0x44
        public System.Nullable`1<0x66525BE0> ItemIsReference; // 0x4C
        public System.Type ItemReferenceLoopHandling; // 0x58
        public object[] ItemTypeNameHandling; // 0x60

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFD4E35C380
        public void set_Id(){} // RVA: 0x7FFD4E342E30
        public void get_Title(){} // RVA: 0x7FFD4E3447C0
        public void set_Title(){} // RVA: 0x7FFD4E3A7E80
        public void get_Description(){} // RVA: 0x7FFD4E36F0C0
        public void set_Description(){} // RVA: 0x7FFD4E36F0D0
        public void get_ItemConverterType(){} // RVA: 0x7FFD4E36F130
        public void set_ItemConverterType(){} // RVA: 0x7FFD4E342E90
        public void get_ItemConverterParameters(){} // RVA: 0x7FFD4E5F95E0
        public void set_ItemConverterParameters(){} // RVA: 0x7FFD4E36F890
        public void get_NamingStrategyType(){} // RVA: 0x7FFD4E409500
        public void set_NamingStrategyType(){} // RVA: 0x7FFD53B0A010
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFD4E3DF370
        public void set_NamingStrategyParameters(){} // RVA: 0x7FFD53B0A0C0
        public void get_NamingStrategyInstance(){} // RVA: 0x7FFD4E5F0140
        public void set_NamingStrategyInstance(){} // RVA: 0x7FFD4E5F0C20
        public void get_IsReference(){} // RVA: 0x7FFD53B0A170
        public void set_IsReference(){} // RVA: 0x7FFD53B0A1B0
        public void get_ItemIsReference(){} // RVA: 0x7FFD53B0A200
        public void set_ItemIsReference(){} // RVA: 0x7FFD53B0A240
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFD53B0A290
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFD53B0A2D0
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFD53B0A330
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFD53B0A370
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class JsonConvert : Object
    {
        public System.Func`1<Newtonsoft.Json.JsonSerializerSettings> DefaultSettings;
        public string True; // 0x8
        public string False; // 0x10
        public string Null; // 0x18
        public string Undefined; // 0x20
        public string PositiveInfinity; // 0x28
        public string NegativeInfinity; // 0x30
        public string NaN; // 0x38

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7FFD53B0A3D0
        public void set_DefaultSettings(){} // RVA: 0x7FFD53B0A430
        public void ToString(){} // RVA: 0x7FFD53B0CA90 | overloaded x30
        public void ToStringInternal(){} // RVA: 0x7FFD53B0B120
        public void EnsureFloatFormat(){} // RVA: 0x7FFD53B0B600
        public void EnsureDecimalPlace(){} // RVA: 0x7FFD53B0BBB0 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFD53B0E550 | overloaded x8
        public void SerializeObjectInternal(){} // RVA: 0x7FFD53B0E620
        public void DeserializeObject(){} // RVA: 0x7FFD53B0EB10 | overloaded x8
        public void DeserializeAnonymousType(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void PopulateObject(){} // RVA: 0x7FFD53B0ED90 | overloaded x2
        public void SerializeXmlNode(){} // RVA: 0x7FFD53B0F1D0 | overloaded x3
        public void DeserializeXmlNode(){} // RVA: 0x7FFD53B0F4E0 | overloaded x4
        public void SerializeXNode(){} // RVA: 0x7FFD53B0F9D0 | overloaded x3
        public void DeserializeXNode(){} // RVA: 0x7FFD53B0FCE0 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFD53B0FF30
    }

    public class JsonConverter : Object
    {
        public object CanRead;
        public object CanWrite;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD4E09AF60
        public void ReadJson(){} // RVA: 0x7FFD4E08B140
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void get_CanRead(){} // RVA: 0x7FFD4E426850
        public void get_CanWrite(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ReadJson(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class JsonNameTable : Object
    {
        // ── Methods ──
        public void Get(){}
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public 0x66525870 MemberSerialization; // 0x68
        public System.Nullable`1<0x66525920> MissingMemberHandling; // 0x6C
        public System.Nullable`1<0x66525AD8> ItemNullValueHandling; // 0x74
        public System.Nullable`1<0x66525978> ItemRequired; // 0x7C

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFD4FBDAB50
        public void set_MemberSerialization(){} // RVA: 0x7FFD4FBDAB60
        public void get_MissingMemberHandling(){} // RVA: 0x7FFD53B10800
        public void set_MissingMemberHandling(){} // RVA: 0x7FFD53B10840
        public void get_ItemNullValueHandling(){} // RVA: 0x7FFD53B108A0
        public void set_ItemNullValueHandling(){} // RVA: 0x7FFD53B108F0
        public void get_ItemRequired(){} // RVA: 0x7FFD53B10950
        public void set_ItemRequired(){} // RVA: 0x7FFD53B10990
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x3
    }

    public class JsonSerializer : Object
    {
        public 0x66525BE0 ReferenceResolver; // 0x10
        public 0x66525B88 Binder; // 0x14
        public 0x66525A28 SerializationBinder; // 0x18
        public 0x66525A80 TraceWriter; // 0x1C
        public 0x66525920 EqualityComparer; // 0x20
        public 0x665259D0 TypeNameHandling; // 0x24
        public 0x66525978 TypeNameAssemblyFormat; // 0x28
        public 0x66523140 TypeNameAssemblyFormatHandling; // 0x2C
        public 0x66522F30 PreserveReferencesHandling; // 0x30
        public 0x665258C8 ReferenceLoopHandling; // 0x34
        public 0x665235B8 MissingMemberHandling; // 0x38
        public Newtonsoft.Json.Serialization.IContractResolver NullValueHandling; // 0x40
        public 0x665288E8 DefaultValueHandling; // 0x48
        public System.Collections.IEqualityComparer ObjectCreationHandling; // 0x50
        public Newtonsoft.Json.Serialization.ISerializationBinder ConstructorHandling; // 0x58
        public System.Runtime.Serialization.StreamingContext MetadataPropertyHandling; // 0x60
        public 0x66528838 Converters; // 0x70
        public System.Nullable`1<0x66523248> ContractResolver; // 0x78
        public System.Nullable`1<0x66522F88> Context; // 0x80
        public System.Nullable`1<0x66523038> Formatting; // 0x88
        public System.Nullable`1<0x66522FE0> DateFormatHandling; // 0x90
        public System.Nullable`1<0x66523198> DateTimeZoneHandling; // 0x98
        public System.Nullable`1<0x665231F0> DateParseHandling; // 0xA0
        public System.Nullable`1<0x66525B30> FloatParseHandling; // 0xA8
        public System.Globalization.CultureInfo FloatFormatHandling; // 0xB0
        public System.Nullable`1<int> StringEscapeHandling; // 0xB8
        public bool DateFormatString; // 0xC0
        public System.Nullable`1<bool> Culture; // 0xC1
        public string MaxDepth; // 0xC8
        public bool CheckAdditionalContent; // 0xD0
        public System.EventHandler`1<0x66528730> Error; // 0xD8

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFD53B1AFA0
        public void remove_Error(){} // RVA: 0x7FFD53B1B0A0
        public void get_ReferenceResolver(){} // RVA: 0x7FFD53B1B1A0
        public void set_ReferenceResolver(){} // RVA: 0x7FFD53B1B1B0
        public void get_Binder(){} // RVA: 0x7FFD53B1B280
        public void set_Binder(){} // RVA: 0x7FFD53B1B3A0
        public void get_SerializationBinder(){} // RVA: 0x7FFD4E409500
        public void set_SerializationBinder(){} // RVA: 0x7FFD53B1B500
        public void get_TraceWriter(){} // RVA: 0x7FFD4E3BC730
        public void set_TraceWriter(){} // RVA: 0x7FFD4E3BC740
        public void get_EqualityComparer(){} // RVA: 0x7FFD4E3E20E0
        public void set_EqualityComparer(){} // RVA: 0x7FFD4E4994D0
        public void get_TypeNameHandling(){} // RVA: 0x7FFD4E38E5C0
        public void set_TypeNameHandling(){} // RVA: 0x7FFD53B1B5D0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFD4E7F5A20
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFD53B1B640
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFD4E7F5A20
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFD53B1B6B0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFD4E577800
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFD53B1B720
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFD4F8557F0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFD53B1B790
        public void get_MissingMemberHandling(){} // RVA: 0x7FFD4E4FBBE0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFD53B1B800
        public void get_NullValueHandling(){} // RVA: 0x7FFD4E70C4C0
        public void set_NullValueHandling(){} // RVA: 0x7FFD53B1B870
        public void get_DefaultValueHandling(){} // RVA: 0x7FFD4F0A91D0
        public void set_DefaultValueHandling(){} // RVA: 0x7FFD53B1B8E0
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFD4ED41980
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFD53B1B950
        public void get_ConstructorHandling(){} // RVA: 0x7FFD4E39CCD0
        public void set_ConstructorHandling(){} // RVA: 0x7FFD53B1B9C0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFD4EEFEDC0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFD53B1BA30
        public void get_Converters(){} // RVA: 0x7FFD53B1BAA0
        public void get_ContractResolver(){} // RVA: 0x7FFD4E3BE740
        public void set_ContractResolver(){} // RVA: 0x7FFD53B1BB80
        public void get_Context(){} // RVA: 0x7FFD513F8A60
        public void set_Context(){} // RVA: 0x7FFD53B1BC40
        public void get_Formatting(){} // RVA: 0x7FFD53B1BCA0
        public void set_Formatting(){} // RVA: 0x7FFD53B1BCE0
        public void get_DateFormatHandling(){} // RVA: 0x7FFD53B1BD40
        public void set_DateFormatHandling(){} // RVA: 0x7FFD53B1BD90
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFD53B1BDF0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFD53B1BE50
        public void get_DateParseHandling(){} // RVA: 0x7FFD53B1BEB0
        public void set_DateParseHandling(){} // RVA: 0x7FFD53B1BF10
        public void get_FloatParseHandling(){} // RVA: 0x7FFD53B1BF70
        public void set_FloatParseHandling(){} // RVA: 0x7FFD53B1BFC0
        public void get_FloatFormatHandling(){} // RVA: 0x7FFD53B1C020
        public void set_FloatFormatHandling(){} // RVA: 0x7FFD53B1C070
        public void get_StringEscapeHandling(){} // RVA: 0x7FFD53B1C0D0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFD53B1C120
        public void get_DateFormatString(){} // RVA: 0x7FFD53B1C180
        public void set_DateFormatString(){} // RVA: 0x7FFD53B1C1D0
        public void get_Culture(){} // RVA: 0x7FFD53B1C240
        public void set_Culture(){} // RVA: 0x7FFD4E3AC050
        public void get_MaxDepth(){} // RVA: 0x7FFD4E3AC0B0
        public void set_MaxDepth(){} // RVA: 0x7FFD53B1C2B0
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFD53B1C380
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFD53B1C3D0
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFD53B1C430
        public void .ctor(){} // RVA: 0x7FFD53B1C480
        public void Create(){} // RVA: 0x7FFD53B1C770 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFD53B1C8E0 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFD53B1C920
        public void Populate(){} // RVA: 0x7FFD53B1D440 | overloaded x2
        public void PopulateInternal(){} // RVA: 0x7FFD53B1D460
        public void Deserialize(){} // RVA: 0x7FFD53B1D830 | overloaded x4
        public void DeserializeInternal(){} // RVA: 0x7FFD53B1D850
        public void SetupReader(){} // RVA: 0x7FFD53B1DB30
        public void ResetReader(){} // RVA: 0x7FFD53B1E0F0
        public void Serialize(){} // RVA: 0x7FFD53B1E550 | overloaded x4
        public void CreateTraceJsonReader(){} // RVA: 0x7FFD53B1E580
        public void SerializeInternal(){} // RVA: 0x7FFD53B1E640
        public void GetReferenceResolver(){} // RVA: 0x7FFD53B1EDE0
        public void GetMatchingConverter(){} // RVA: 0x7FFD53B1EE90 | overloaded x2
        public void OnError(){} // RVA: 0x7FFD53B1EF60
    }

    public class JsonSerializerSettings : Object
    {
        public 0x66525A80 ReferenceLoopHandling;
        public 0x66525920 MissingMemberHandling;
        public 0x66525978 ObjectCreationHandling;
        public 0x66523140 NullValueHandling;
        public 0x665259D0 DefaultValueHandling;
        public 0x66525A28 Converters;
        public 0x66522F30 PreserveReferencesHandling;
        public 0x66525BE0 TypeNameHandling;
        public 0x665258C8 MetadataPropertyHandling;
        public System.Runtime.Serialization.StreamingContext TypeNameAssemblyFormat;
        public 0x66523248 TypeNameAssemblyFormatHandling;
        public 0x66522F88 ConstructorHandling;
        public 0x66523038 ContractResolver;
        public 0x66522FE0 EqualityComparer;
        public 0x665231F0 ReferenceResolver;
        public 0x66523198 ReferenceResolverProvider;
        public 0x66525B30 TraceWriter;
        public 0x66525B88 Binder;
        public System.Globalization.CultureInfo SerializationBinder; // 0x10
        public bool Error;
        public string Context;
        public int DateFormatString;
        public System.Nullable`1<0x66523248> MaxDepth; // 0x10
        public System.Nullable`1<0x66522F88> Formatting; // 0x18
        public System.Nullable`1<0x66523038> DateFormatHandling; // 0x20
        public System.Nullable`1<0x66522FE0> DateTimeZoneHandling; // 0x28
        public System.Nullable`1<0x66523198> DateParseHandling; // 0x30
        public System.Nullable`1<0x665231F0> FloatFormatHandling; // 0x38
        public System.Nullable`1<0x66525B30> FloatParseHandling; // 0x40
        public System.Globalization.CultureInfo StringEscapeHandling; // 0x48
        public System.Nullable`1<bool> Culture; // 0x50
        public System.Nullable`1<int> CheckAdditionalContent; // 0x54
        public bool _maxDepthSet; // 0x5C
        public string _dateFormatString; // 0x60
        public bool _dateFormatStringSet; // 0x68
        public System.Nullable`1<0x66525B88> _typeNameAssemblyFormatHandling; // 0x6C
        public System.Nullable`1<0x66523140> _defaultValueHandling; // 0x74
        public System.Nullable`1<0x66525A28> _preserveReferencesHandling; // 0x7C
        public System.Nullable`1<0x66525978> _nullValueHandling; // 0x84
        public System.Nullable`1<0x665259D0> _objectCreationHandling; // 0x8C
        public System.Nullable`1<0x66525920> _missingMemberHandling; // 0x94
        public System.Nullable`1<0x66525A80> _referenceLoopHandling; // 0x9C
        public System.Nullable`1<System.Runtime.Serialization.StreamingContext> _context; // 0xA8
        public System.Nullable`1<0x66522F30> _constructorHandling; // 0xC0
        public System.Nullable`1<0x66525BE0> _typeNameHandling; // 0xC8
        public System.Nullable`1<0x665258C8> _metadataPropertyHandling; // 0xD0
        public System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter> <Converters>k__BackingField; // 0xD8
        public Newtonsoft.Json.Serialization.IContractResolver <ContractResolver>k__BackingField; // 0xE0
        public System.Collections.IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
        public System.Func`1<0x66528838> <ReferenceResolverProvider>k__BackingField; // 0xF0
        public 0x665288E8 <TraceWriter>k__BackingField; // 0xF8
        public Newtonsoft.Json.Serialization.ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
        public System.EventHandler`1<0x66528730> <Error>k__BackingField; // 0x108

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFD53B1EF90
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFD53B1EFE0
        public void get_MissingMemberHandling(){} // RVA: 0x7FFD53B1F040
        public void set_MissingMemberHandling(){} // RVA: 0x7FFD53B1F090
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFD53B1F0F0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFD53B1F140
        public void get_NullValueHandling(){} // RVA: 0x7FFD53B1F1A0
        public void set_NullValueHandling(){} // RVA: 0x7FFD53B1F1F0
        public void get_DefaultValueHandling(){} // RVA: 0x7FFD53B1F250
        public void set_DefaultValueHandling(){} // RVA: 0x7FFD53B1F290
        public void get_Converters(){} // RVA: 0x7FFD4E960F70
        public void set_Converters(){} // RVA: 0x7FFD4E3C28A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFD53B1F2F0
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFD53B1F340
        public void get_TypeNameHandling(){} // RVA: 0x7FFD53B1F3A0
        public void set_TypeNameHandling(){} // RVA: 0x7FFD53B1F3F0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFD53B1F450
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFD53B1F4A0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFD53B1F500
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFD53B1F540
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFD53B1F500
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFD53B1F540
        public void get_ConstructorHandling(){} // RVA: 0x7FFD53B1F5A0
        public void set_ConstructorHandling(){} // RVA: 0x7FFD53B1F5F0
        public void get_ContractResolver(){} // RVA: 0x7FFD4E3C2900
        public void set_ContractResolver(){} // RVA: 0x7FFD4E3C2910
        public void get_EqualityComparer(){} // RVA: 0x7FFD4E3C2970
        public void set_EqualityComparer(){} // RVA: 0x7FFD4E3C2980
        public void get_ReferenceResolver(){} // RVA: 0x7FFD53B1F650
        public void set_ReferenceResolver(){} // RVA: 0x7FFD53B1F670
        public void get_ReferenceResolverProvider(){} // RVA: 0x7FFD4E3AC2A0
        public void set_ReferenceResolverProvider(){} // RVA: 0x7FFD4E3AC2B0
        public void get_TraceWriter(){} // RVA: 0x7FFD4E751F50
        public void set_TraceWriter(){} // RVA: 0x7FFD4E8C4860
        public void get_Binder(){} // RVA: 0x7FFD53B1F800
        public void set_Binder(){} // RVA: 0x7FFD53B1F8E0
        public void get_SerializationBinder(){} // RVA: 0x7FFD4E916C80
        public void set_SerializationBinder(){} // RVA: 0x7FFD4E916750
        public void get_Error(){} // RVA: 0x7FFD4EAF1F40
        public void set_Error(){} // RVA: 0x7FFD4ED49BF0
        public void get_Context(){} // RVA: 0x7FFD53B1FA00
        public void set_Context(){} // RVA: 0x7FFD53B1FAD0
        public void get_DateFormatString(){} // RVA: 0x7FFD53B1FBF0
        public void set_DateFormatString(){} // RVA: 0x7FFD53B1FC40
        public void get_MaxDepth(){} // RVA: 0x7FFD53B1FCA0
        public void set_MaxDepth(){} // RVA: 0x7FFD53B1FD00
        public void get_Formatting(){} // RVA: 0x7FFD53B1FDC0
        public void set_Formatting(){} // RVA: 0x7FFD53B1FE00
        public void get_DateFormatHandling(){} // RVA: 0x7FFD53B1FE60
        public void set_DateFormatHandling(){} // RVA: 0x7FFD53B1FEA0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFD53B1FF00
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFD53B1FF60
        public void get_DateParseHandling(){} // RVA: 0x7FFD53B1FFC0
        public void set_DateParseHandling(){} // RVA: 0x7FFD53B20020
        public void get_FloatFormatHandling(){} // RVA: 0x7FFD53B20080
        public void set_FloatFormatHandling(){} // RVA: 0x7FFD53B200C0
        public void get_FloatParseHandling(){} // RVA: 0x7FFD53B20120
        public void set_FloatParseHandling(){} // RVA: 0x7FFD53B20160
        public void get_StringEscapeHandling(){} // RVA: 0x7FFD53B201C0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFD53B20200
        public void get_Culture(){} // RVA: 0x7FFD53B20260
        public void set_Culture(){} // RVA: 0x7FFD4E3BC740
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFD53B202D0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFD53B20310
        public void .cctor(){} // RVA: 0x7FFD53B20360
        public void .ctor(){} // RVA: 0x7FFD53B20540 | overloaded x2
    }

}