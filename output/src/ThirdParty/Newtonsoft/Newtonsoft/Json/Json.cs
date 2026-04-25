// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 10
// Methods: 287

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable : JsonNameTable
    {
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
        public object Id;
        public object Title;
        public object Description;
        public object ItemConverterType;
        public object ItemConverterParameters;
        public object NamingStrategyType;
        public object NamingStrategyParameters;
        public object NamingStrategyInstance;
        public object IsReference;
        public object ItemIsReference;
        public object ItemReferenceLoopHandling;
        public object ItemTypeNameHandling;

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
        public object DefaultSettings;

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
        public object MemberSerialization;
        public object MissingMemberHandling;
        public object ItemNullValueHandling;
        public object ItemRequired;

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
        public object ReferenceResolver;
        public object Binder;
        public object SerializationBinder;
        public object TraceWriter;
        public object EqualityComparer;
        public object TypeNameHandling;
        public object TypeNameAssemblyFormat;
        public object TypeNameAssemblyFormatHandling;
        public object PreserveReferencesHandling;
        public object ReferenceLoopHandling;
        public object MissingMemberHandling;
        public object NullValueHandling;
        public object DefaultValueHandling;
        public object ObjectCreationHandling;
        public object ConstructorHandling;
        public object MetadataPropertyHandling;
        public object Converters;
        public object ContractResolver;
        public object Context;
        public object Formatting;
        public object DateFormatHandling;
        public object DateTimeZoneHandling;
        public object DateParseHandling;
        public object FloatParseHandling;
        public object FloatFormatHandling;
        public object StringEscapeHandling;
        public object DateFormatString;
        public object Culture;
        public object MaxDepth;
        public object CheckAdditionalContent;

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
        public object ReferenceLoopHandling;
        public object MissingMemberHandling;
        public object ObjectCreationHandling;
        public object NullValueHandling;
        public object DefaultValueHandling;
        public object Converters;
        public object PreserveReferencesHandling;
        public object TypeNameHandling;
        public object MetadataPropertyHandling;
        public object TypeNameAssemblyFormat;
        public object TypeNameAssemblyFormatHandling;
        public object ConstructorHandling;
        public object ContractResolver;
        public object EqualityComparer;
        public object ReferenceResolver;
        public object ReferenceResolverProvider;
        public object TraceWriter;
        public object Binder;
        public object SerializationBinder;
        public object Error;
        public object Context;
        public object DateFormatString;
        public object MaxDepth;
        public object Formatting;
        public object DateFormatHandling;
        public object DateTimeZoneHandling;
        public object DateParseHandling;
        public object FloatFormatHandling;
        public object FloatParseHandling;
        public object StringEscapeHandling;
        public object Culture;
        public object CheckAdditionalContent;

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