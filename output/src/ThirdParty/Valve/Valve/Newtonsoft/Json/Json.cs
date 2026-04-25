// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 26
// Methods: 421

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7FFAC2C67DE0
        public void Return(){} // RVA: 0x7FFAC2C70A40
    }

    public class IJsonLineInfo
    {
        public object LineNumber;
        public object LinePosition;

        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7FFAC2C59D00
        public void get_LineNumber(){} // RVA: 0x7FFAC2C59960
        public void get_LinePosition(){} // RVA: 0x7FFAC2C59960
    }

    public class JsonArrayAttribute : JsonContainerAttribute
    {
    }

    public class JsonConstructorAttribute : Attribute
    {
    }

    public class JsonContainerAttribute : Attribute
    {
        public System.Type ItemConverterType; // 0x10
        public object[] ItemConverterParameters; // 0x18
        public Valve.Newtonsoft.Json.Serialization.NamingStrategy NamingStrategyType; // 0x20
        public System.Nullable`1<bool> NamingStrategyParameters; // 0x28
        public System.Nullable`1<bool> NamingStrategyInstance; // 0x2A
        public System.Nullable`1<0x6B2453B0> _itemReferenceLoopHandling; // 0x2C
        public System.Nullable`1<0x6B2454B8> _itemTypeNameHandling; // 0x34
        public System.Type _namingStrategyType; // 0x40
        public object[] _namingStrategyParameters; // 0x48

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFAC2F3C380
        public void get_ItemConverterParameters(){} // RVA: 0x7FFAC2F247C0
        public void get_NamingStrategyType(){} // RVA: 0x7FFAC2F9E740
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFAC2F9C730
        public void get_NamingStrategyInstance(){} // RVA: 0x7FFAC2F4F0C0
        public void set_NamingStrategyInstance(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class JsonConvert : Object
    {
        public System.Func`1<Valve.Newtonsoft.Json.JsonSerializerSettings> DefaultSettings;
        public string True; // 0x8
        public string False; // 0x10
        public string Null; // 0x18
        public string Undefined; // 0x20
        public string PositiveInfinity; // 0x28
        public string NegativeInfinity; // 0x30
        public string NaN; // 0x38

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7FFAC9CA48E0
        public void ToString(){} // RVA: 0x7FFAC9CA54E0 | overloaded x8
        public void EnsureFloatFormat(){} // RVA: 0x7FFAC9CA4CD0
        public void EnsureDecimalPlace(){} // RVA: 0x7FFAC9CA5130 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFAC9CA56B0 | overloaded x2
        public void SerializeObjectInternal(){} // RVA: 0x7FFAC9CA5780
        public void DeserializeObject(){} // RVA: 0x7FFAC9CA5A70 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC9CA5D40
    }

    public class JsonConverter : Object
    {
        public object CanRead;
        public object CanWrite;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC2C7AF60
        public void ReadJson(){} // RVA: 0x7FFAC2C6B140
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonConverterAttribute : Attribute
    {
        public System.Type ConverterType; // 0x10
        public object[] ConverterParameters; // 0x18

        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7FFAC2F3C380
        public void get_ConverterParameters(){} // RVA: 0x7FFAC2F247C0
    }

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA6100
    }

    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA6260 | overloaded x4
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        public bool WriteData; // 0x10
        public bool ReadData; // 0x11

        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7FFAC2FEB5E0
        public void get_ReadData(){} // RVA: 0x7FFAC3771DA0
    }

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public 0x6B2451A0 MemberSerialization; // 0x50
        public System.Nullable`1<0x6B245408> _itemRequired; // 0x54

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFAC30F10E0
    }

    public class JsonPosition : ValueType
    {
        public char[] SpecialCharacters;
        public 0x6B244BC8 Type; // 0x10
        public int Position; // 0x14
        public string PropertyName; // 0x18
        public bool HasIndex; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA62E0
        public void CalculateLength(){} // RVA: 0x7FFAC9CA63A0
        public void WriteTo(){} // RVA: 0x7FFAC9CA6440
        public void TypeHasIndex(){} // RVA: 0x7FFAC86F0D80
        public void BuildPath(){} // RVA: 0x7FFAC9CA65C0
        public void FormatMessage(){} // RVA: 0x7FFAC9CA6B80
        public void .cctor(){} // RVA: 0x7FFAC9CA6EF0
    }

    public class JsonPropertyAttribute : Attribute
    {
        public System.Nullable`1<0x6B2452A8> ItemConverterType; // 0x10
        public System.Nullable`1<0x6B244598> ItemConverterParameters; // 0x18
        public System.Nullable`1<0x6B2453B0> NamingStrategyType; // 0x20
        public System.Nullable`1<0x6B245300> NamingStrategyParameters; // 0x28
        public System.Nullable`1<0x6B2454B8> PropertyName; // 0x30
        public System.Nullable`1<bool> _isReference; // 0x38
        public System.Nullable`1<int> _order; // 0x3C
        public System.Nullable`1<0x6B245408> _required; // 0x44
        public System.Nullable`1<bool> _itemIsReference; // 0x4C
        public System.Nullable`1<0x6B2453B0> _itemReferenceLoopHandling; // 0x50
        public System.Nullable`1<0x6B2454B8> _itemTypeNameHandling; // 0x58
        public System.Type <ItemConverterType>k__BackingField; // 0x60
        public object[] <ItemConverterParameters>k__BackingField; // 0x68
        public System.Type <NamingStrategyType>k__BackingField; // 0x70
        public object[] <NamingStrategyParameters>k__BackingField; // 0x78
        public string <PropertyName>k__BackingField; // 0x80

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFAC2FBF370
        public void get_ItemConverterParameters(){} // RVA: 0x7FFAC2F9CD50
        public void get_NamingStrategyType(){} // RVA: 0x7FFAC2FE9590
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFAC30E5600
        public void get_PropertyName(){} // RVA: 0x7FFAC32EF410
    }

    public class JsonReader : Object
    {
        public 0x6B245040 CurrentState; // 0x10
        public object CloseInput; // 0x18
        public char SupportMultipleContent; // 0x20
        public 0x6B244CD0 DateTimeZoneHandling; // 0x24
        public Valve.Newtonsoft.Json.JsonPosition DateParseHandling; // 0x28
        public System.Globalization.CultureInfo FloatParseHandling; // 0x40
        public 0x6B244540 DateFormatString; // 0x48
        public System.Nullable`1<int> MaxDepth; // 0x4C
        public bool TokenType; // 0x54
        public 0x6B2444E8 Value; // 0x58
        public 0x6B244648 ValueType; // 0x5C
        public string Depth; // 0x60
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.JsonPosition> Path; // 0x68
        public bool Culture; // 0x70
        public bool <SupportMultipleContent>k__BackingField; // 0x71

        // ── Methods ──
        public void get_CurrentState(){} // RVA: 0x7FFAC3921980
        public void get_CloseInput(){} // RVA: 0x7FFAC2F9D320
        public void set_CloseInput(){} // RVA: 0x7FFAC2F9D330
        public void get_SupportMultipleContent(){} // RVA: 0x7FFAC82464C0
        public void set_SupportMultipleContent(){} // RVA: 0x7FFAC82464D0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC2FC20C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC9CA6FD0
        public void get_DateParseHandling(){} // RVA: 0x7FFAC362EA40
        public void set_DateParseHandling(){} // RVA: 0x7FFAC9CA7040
        public void get_FloatParseHandling(){} // RVA: 0x7FFAC313CBA0
        public void set_FloatParseHandling(){} // RVA: 0x7FFAC9CA70B0
        public void get_DateFormatString(){} // RVA: 0x7FFAC2FBF370
        public void set_DateFormatString(){} // RVA: 0x7FFAC2FBF380
        public void get_MaxDepth(){} // RVA: 0x7FFAC5FE03C0
        public void set_MaxDepth(){} // RVA: 0x7FFAC9CA7120
        public void get_TokenType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void get_ValueType(){} // RVA: 0x7FFAC9CA71E0
        public void get_Depth(){} // RVA: 0x7FFAC9CA7200
        public void get_Path(){} // RVA: 0x7FFAC9CA7280
        public void get_Culture(){} // RVA: 0x7FFAC9CA7400
        public void set_Culture(){} // RVA: 0x7FFAC2F49200
        public void GetPosition(){} // RVA: 0x7FFAC9CA7460
        public void .ctor(){} // RVA: 0x7FFAC9CA7520
        public void Push(){} // RVA: 0x7FFAC9CA7540
        public void Pop(){} // RVA: 0x7FFAC9CA7890
        public void Peek(){} // RVA: 0x7FFAC32EC4C0
        public void Read(){} // RVA: 0x7FFAC2C59D00
        public void ReadAsInt32(){} // RVA: 0x7FFAC9CA7A40
        public void ReadInt32String(){} // RVA: 0x7FFAC9CA7DC0
        public void ReadAsString(){} // RVA: 0x7FFAC9CA8170
        public void ReadAsBytes(){} // RVA: 0x7FFAC9CA8560
        public void ReadArrayIntoByteArray(){} // RVA: 0x7FFAC9CA8C60
        public void ReadAsDouble(){} // RVA: 0x7FFAC9CA9060
        public void ReadDoubleString(){} // RVA: 0x7FFAC9CA93F0
        public void ReadAsBoolean(){} // RVA: 0x7FFAC9CA9740
        public void ReadBooleanString(){} // RVA: 0x7FFAC9CA9A80
        public void ReadAsDecimal(){} // RVA: 0x7FFAC9CA9E80
        public void ReadDecimalString(){} // RVA: 0x7FFAC9CAA240
        public void ReadAsDateTime(){} // RVA: 0x7FFAC9CAA5F0
        public void ReadDateTimeString(){} // RVA: 0x7FFAC9CAA990
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC9CAAE20
        public void ReadDateTimeOffsetString(){} // RVA: 0x7FFAC9CAB1B0
        public void ReaderReadAndAssert(){} // RVA: 0x7FFAC9CAB5F0
        public void CreateUnexpectedEndException(){} // RVA: 0x7FFAC9CAB640
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7FFAC9CAB690
        public void Skip(){} // RVA: 0x7FFAC9CABA40
        public void SetToken(){} // RVA: 0x7FFAC9CABB40 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x7FFAC9CABD80
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFAC86F8680
        public void ValidateEnd(){} // RVA: 0x7FFAC9CABDC0
        public void SetStateBasedOnCurrent(){} // RVA: 0x7FFAC9CABF80
        public void SetFinished(){} // RVA: 0x7FFAC9CAC090
        public void GetTypeForCloseToken(){} // RVA: 0x7FFAC9CAC0B0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC9CAC1A0
        public void Dispose(){} // RVA: 0x7FFAC9CAC210
        public void Close(){} // RVA: 0x7FFAC86F8B10
        public void ReadAndAssert(){} // RVA: 0x7FFAC9CAC240
        public void ReadAndMoveToContent(){} // RVA: 0x7FFAC9CAC2A0
        public void MoveToContent(){} // RVA: 0x7FFAC9CAC300
        public void GetContentToken(){} // RVA: 0x7FFAC9CAC360
    }

    public class JsonReaderException : JsonException
    {
        public int LineNumber; // 0x90
        public int LinePosition; // 0x94
        public string Path; // 0x98

        // ── Methods ──
        public void set_LineNumber(){} // RVA: 0x7FFAC34D2750
        public void set_LinePosition(){} // RVA: 0x7FFAC342B670
        public void set_Path(){} // RVA: 0x7FFAC354E3C0
        public void .ctor(){} // RVA: 0x7FFAC9CAC430 | overloaded x3
        public void Create(){} // RVA: 0x7FFAC9CAC6B0 | overloaded x3
    }

    public class JsonRequiredAttribute : Attribute
    {
    }

    public class JsonSerializationException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA6260 | overloaded x4
        public void Create(){} // RVA: 0x7FFAC9CAC980 | overloaded x3
    }

    public class JsonSerializer : Object
    {
        public 0x6B2454B8 ReferenceResolver; // 0x10
        public 0x6B0D35B0 Binder; // 0x14
        public 0x6B245358 TraceWriter; // 0x18
        public 0x6B2453B0 EqualityComparer; // 0x1C
        public 0x6B245250 TypeNameHandling; // 0x20
        public 0x6B245300 TypeNameAssemblyFormat; // 0x24
        public 0x6B2452A8 PreserveReferencesHandling; // 0x28
        public 0x6B244598 ReferenceLoopHandling; // 0x2C
        public 0x6B244438 MissingMemberHandling; // 0x30
        public 0x6B2451F8 NullValueHandling; // 0x34
        public Valve.Newtonsoft.Json.JsonConverterCollection DefaultValueHandling; // 0x38
        public Valve.Newtonsoft.Json.Serialization.IContractResolver ObjectCreationHandling; // 0x40
        public Valve.Newtonsoft.Json.Serialization.ITraceWriter ConstructorHandling; // 0x48
        public System.Collections.IEqualityComparer MetadataPropertyHandling; // 0x50
        public System.Runtime.Serialization.SerializationBinder Converters; // 0x58
        public System.Runtime.Serialization.StreamingContext ContractResolver; // 0x60
        public Valve.Newtonsoft.Json.Serialization.IReferenceResolver Context; // 0x70
        public System.Nullable`1<0x6B2446A0> Formatting; // 0x78
        public System.Nullable`1<0x6B244490> CheckAdditionalContent; // 0x80
        public System.Nullable`1<0x6B244540> _dateTimeZoneHandling; // 0x88
        public System.Nullable`1<0x6B2444E8> _dateParseHandling; // 0x90
        public System.Nullable`1<0x6B2445F0> _floatFormatHandling; // 0x98
        public System.Nullable`1<0x6B244648> _floatParseHandling; // 0xA0
        public System.Nullable`1<0x6B245460> _stringEscapeHandling; // 0xA8
        public System.Globalization.CultureInfo _culture; // 0xB0
        public System.Nullable`1<int> _maxDepth; // 0xB8
        public bool _maxDepthSet; // 0xC0
        public System.Nullable`1<bool> _checkAdditionalContent; // 0xC1
        public string _dateFormatString; // 0xC8
        public bool _dateFormatStringSet; // 0xD0
        public System.EventHandler`1<Valve.Newtonsoft.Json.Serialization.ErrorEventArgs> Error; // 0xD8

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFAC9CACA40
        public void remove_Error(){} // RVA: 0x7FFAC9CACB40
        public void set_ReferenceResolver(){} // RVA: 0x7FFAC9CACC40
        public void set_Binder(){} // RVA: 0x7FFAC9CACD10
        public void get_TraceWriter(){} // RVA: 0x7FFAC2F9C730
        public void set_TraceWriter(){} // RVA: 0x7FFAC2F9C740
        public void set_EqualityComparer(){} // RVA: 0x7FFAC30794D0
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC9CACDE0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC9CACE50
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFAC9CACEC0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC9CACF30
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC9CACFA0
        public void set_NullValueHandling(){} // RVA: 0x7FFAC9CAD010
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC9CAD080
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC9CAD0F0
        public void set_ConstructorHandling(){} // RVA: 0x7FFAC9CAD160
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAC3ADEDC0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFAC9CAD1D0
        public void get_Converters(){} // RVA: 0x7FFAC9CAD240
        public void get_ContractResolver(){} // RVA: 0x7FFAC2F9E740
        public void set_ContractResolver(){} // RVA: 0x7FFAC9CAD320
        public void get_Context(){} // RVA: 0x7FFAC5FD8A60
        public void set_Context(){} // RVA: 0x7FFAC86FBC40
        public void get_Formatting(){} // RVA: 0x7FFAC9CAD3E0
        public void set_Formatting(){} // RVA: 0x7FFAC9CAD440
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFAC9CAD4A0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFAC9CAD500
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFAC9CAD560
        public void .ctor(){} // RVA: 0x7FFAC9CAD5B0
        public void Create(){} // RVA: 0x7FFAC9CAD8A0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFAC9CADA10 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFAC9CADA50
        public void Deserialize(){} // RVA: 0x7FFAC9CAE610 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFAC9CAE630
        public void SetupReader(){} // RVA: 0x7FFAC9CAE930
        public void ResetReader(){} // RVA: 0x7FFAC9CAEF50
        public void Serialize(){} // RVA: 0x7FFAC9CAF220 | overloaded x2
        public void SerializeInternal(){} // RVA: 0x7FFAC9CAF250
        public void GetReferenceResolver(){} // RVA: 0x7FFAC9CAFA10
        public void GetMatchingConverter(){} // RVA: 0x7FFAC9CAFAC0 | overloaded x2
        public void OnError(){} // RVA: 0x7FFAC86FEF60
    }

    public class JsonSerializerSettings : Object
    {
        public System.Runtime.Serialization.StreamingContext ReferenceLoopHandling;
        public System.Globalization.CultureInfo MissingMemberHandling; // 0x10
        public System.Nullable`1<0x6B2446A0> ObjectCreationHandling; // 0x10
        public System.Nullable`1<0x6B244490> NullValueHandling; // 0x18
        public System.Nullable`1<0x6B244540> DefaultValueHandling; // 0x20
        public System.Nullable`1<0x6B2444E8> Converters; // 0x28
        public System.Nullable`1<0x6B2445F0> PreserveReferencesHandling; // 0x30
        public System.Nullable`1<0x6B244648> TypeNameHandling; // 0x38
        public System.Nullable`1<0x6B245460> MetadataPropertyHandling; // 0x40
        public System.Globalization.CultureInfo TypeNameAssemblyFormat; // 0x48
        public System.Nullable`1<bool> ConstructorHandling; // 0x50
        public System.Nullable`1<int> ContractResolver; // 0x54
        public bool EqualityComparer; // 0x5C
        public string ReferenceResolverProvider; // 0x60
        public bool TraceWriter; // 0x68
        public System.Nullable`1<0x6B0D35B0> Binder; // 0x6C
        public System.Nullable`1<0x6B244598> Error; // 0x74
        public System.Nullable`1<0x6B245358> Context; // 0x7C
        public System.Nullable`1<0x6B2452A8> _nullValueHandling; // 0x84
        public System.Nullable`1<0x6B245300> _objectCreationHandling; // 0x8C
        public System.Nullable`1<0x6B245250> _missingMemberHandling; // 0x94
        public System.Nullable`1<0x6B2453B0> _referenceLoopHandling; // 0x9C
        public System.Nullable`1<System.Runtime.Serialization.StreamingContext> _context; // 0xA8
        public System.Nullable`1<0x6B244438> _constructorHandling; // 0xC0
        public System.Nullable`1<0x6B2454B8> _typeNameHandling; // 0xC8
        public System.Nullable`1<0x6B2451F8> _metadataPropertyHandling; // 0xD0
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.JsonConverter> <Converters>k__BackingField; // 0xD8
        public Valve.Newtonsoft.Json.Serialization.IContractResolver <ContractResolver>k__BackingField; // 0xE0
        public System.Collections.IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
        public System.Func`1<Valve.Newtonsoft.Json.Serialization.IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
        public Valve.Newtonsoft.Json.Serialization.ITraceWriter <TraceWriter>k__BackingField; // 0xF8
        public System.Runtime.Serialization.SerializationBinder <Binder>k__BackingField; // 0x100
        public System.EventHandler`1<Valve.Newtonsoft.Json.Serialization.ErrorEventArgs> <Error>k__BackingField; // 0x108

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC9CAFB90
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAC9CAFBF0
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC9CAFC50
        public void get_NullValueHandling(){} // RVA: 0x7FFAC9CAFCB0
        public void set_NullValueHandling(){} // RVA: 0x7FFAC9CAFD10
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC9CAFD70
        public void get_Converters(){} // RVA: 0x7FFAC3540F70
        public void set_Converters(){} // RVA: 0x7FFAC2FA28A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFAC9CAFDD0
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC9CAFE30
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAC9CAFE90
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC9CAFEF0
        public void get_ConstructorHandling(){} // RVA: 0x7FFAC9CAFF50
        public void get_ContractResolver(){} // RVA: 0x7FFAC2FA2900
        public void get_EqualityComparer(){} // RVA: 0x7FFAC2FA2970
        public void get_ReferenceResolverProvider(){} // RVA: 0x7FFAC2F8C2A0
        public void get_TraceWriter(){} // RVA: 0x7FFAC3331F50
        public void get_Binder(){} // RVA: 0x7FFAC34F6C80
        public void get_Error(){} // RVA: 0x7FFAC36D1F40
        public void get_Context(){} // RVA: 0x7FFAC9CAFFB0
        public void .cctor(){} // RVA: 0x7FFAC9CB0080
        public void .ctor(){} // RVA: 0x7FFAC9CB01A0
    }

    public class JsonTextReader : JsonReader
    {
        public System.IO.TextReader LineNumber; // 0x78
        public char[] LinePosition; // 0x80
        public int _charsUsed; // 0x88
        public int _charPos; // 0x8C
        public int _lineStartPos; // 0x90
        public int _lineNumber; // 0x94
        public bool _isEndOfFile; // 0x98
        public Valve.Newtonsoft.Json.Utilities.StringBuffer _stringBuffer; // 0xA0
        public Valve.Newtonsoft.Json.Utilities.StringReference _stringReference; // 0xB0
        public Valve.Newtonsoft.Json.IArrayPool`1<char> _arrayPool; // 0xC0
        public Valve.Newtonsoft.Json.Utilities.PropertyNameTable NameTable; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CB0260
        public void EnsureBufferNotEmpty(){} // RVA: 0x7FFAC9CB0340
        public void OnNewLine(){} // RVA: 0x7FFAC9CB0490
        public void ParseString(){} // RVA: 0x7FFAC9CB04A0
        public void BlockCopyChars(){} // RVA: 0x7FFAC8707310
        public void ShiftBufferIfNeeded(){} // RVA: 0x7FFAC9CB0B40
        public void ReadData(){} // RVA: 0x7FFAC9CB0C30 | overloaded x2
        public void EnsureChars(){} // RVA: 0x7FFAC9CB0FD0
        public void ReadChars(){} // RVA: 0x7FFAC9CB1080
        public void Read(){} // RVA: 0x7FFAC9CB1110
        public void ReadAsInt32(){} // RVA: 0x7FFAC9CB1490
        public void ReadAsDateTime(){} // RVA: 0x7FFAC9CB1580
        public void ReadAsString(){} // RVA: 0x7FFAC9CB1670
        public void ReadAsBytes(){} // RVA: 0x7FFAC9CB16E0
        public void ReadStringValue(){} // RVA: 0x7FFAC9CB2110
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFAC9CB3080
        public void ReadAsBoolean(){} // RVA: 0x7FFAC9CB3190
        public void ProcessValueComma(){} // RVA: 0x7FFAC9CB3F90
        public void ReadNumberValue(){} // RVA: 0x7FFAC9CB3FF0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC9CB4BD0
        public void ReadAsDecimal(){} // RVA: 0x7FFAC9CB4CD0
        public void ReadAsDouble(){} // RVA: 0x7FFAC9CB4DD0
        public void HandleNull(){} // RVA: 0x7FFAC9CB4EC0
        public void ReadFinished(){} // RVA: 0x7FFAC9CB4FD0
        public void ReadNullChar(){} // RVA: 0x7FFAC9CB5180
        public void EnsureBuffer(){} // RVA: 0x7FFAC9CB51D0
        public void ReadStringIntoBuffer(){} // RVA: 0x7FFAC9CB52E0
        public void WriteCharToBuffer(){} // RVA: 0x7FFAC9CB59A0
        public void ParseUnicode(){} // RVA: 0x7FFAC9CB5A50
        public void ReadNumberIntoBuffer(){} // RVA: 0x7FFAC9CB5CE0
        public void ClearRecentString(){} // RVA: 0x7FFAC9CB5F10
        public void ParsePostValue(){} // RVA: 0x7FFAC9CB5F30
        public void ParseObject(){} // RVA: 0x7FFAC9CB6360
        public void ParseProperty(){} // RVA: 0x7FFAC9CB6570
        public void ValidIdentifierChar(){} // RVA: 0x7FFAC9CB6900
        public void ParseUnquotedProperty(){} // RVA: 0x7FFAC9CB6970
        public void ParseValue(){} // RVA: 0x7FFAC9CB6D20
        public void ProcessLineFeed(){} // RVA: 0x7FFAC9CB7960
        public void ProcessCarriageReturn(){} // RVA: 0x7FFAC9CB7980
        public void EatWhitespace(){} // RVA: 0x7FFAC9CB7A50
        public void ParseConstructor(){} // RVA: 0x7FFAC9CB7B90
        public void ParseNumber(){} // RVA: 0x7FFAC9CB80D0
        public void ParseComment(){} // RVA: 0x7FFAC9CB9920
        public void EndComment(){} // RVA: 0x7FFAC9CB9C90
        public void MatchValue(){} // RVA: 0x7FFAC9CB9D50
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7FFAC9CB9E40
        public void IsSeparator(){} // RVA: 0x7FFAC9CBA0F0
        public void ParseTrue(){} // RVA: 0x7FFAC9CBA240
        public void ParseNull(){} // RVA: 0x7FFAC9CBA3C0
        public void ParseUndefined(){} // RVA: 0x7FFAC9CBA510
        public void ParseFalse(){} // RVA: 0x7FFAC9CBA660
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7FFAC9CBA890
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7FFAC9CBABA0
        public void ParseNumberNaN(){} // RVA: 0x7FFAC9CBAEB0
        public void Close(){} // RVA: 0x7FFAC9CBB1C0
        public void HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void get_LineNumber(){} // RVA: 0x7FFAC9CBB340
        public void get_LinePosition(){} // RVA: 0x7FFAC9CBB390
    }

    public class JsonTextWriter : JsonWriter
    {
        public System.IO.TextWriter Base64Encoder; // 0x60
        public Valve.Newtonsoft.Json.Utilities.Base64Encoder QuoteChar; // 0x68
        public char _indentChar; // 0x70
        public int _indentation; // 0x74
        public char _quoteChar; // 0x78
        public bool _quoteName; // 0x7A
        public bool[] _charEscapeFlags; // 0x80
        public char[] _writeBuffer; // 0x88
        public Valve.Newtonsoft.Json.IArrayPool`1<char> _arrayPool; // 0x90
        public char[] _indentChars; // 0x98

        // ── Methods ──
        public void get_Base64Encoder(){} // RVA: 0x7FFAC9CBB3A0
        public void get_QuoteChar(){} // RVA: 0x7FFAC87305F0
        public void .ctor(){} // RVA: 0x7FFAC9CBB5A0
        public void Close(){} // RVA: 0x7FFAC9CBB6C0
        public void WriteStartObject(){} // RVA: 0x7FFAC9CBB7D0
        public void WriteStartArray(){} // RVA: 0x7FFAC9CBB820
        public void WriteStartConstructor(){} // RVA: 0x7FFAC9CBB870
        public void WriteEnd(){} // RVA: 0x7FFAC9CBB930
        public void WritePropertyName(){} // RVA: 0x7FFAC9CBBAD0 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFAC9CBBC00
        public void UpdateCharEscapeFlags(){} // RVA: 0x7FFAC9CBBC10
        public void WriteIndent(){} // RVA: 0x7FFAC9CBBCE0
        public void WriteValueDelimiter(){} // RVA: 0x7FFAC9CBBED0
        public void WriteIndentSpace(){} // RVA: 0x7FFAC9CBBF00
        public void WriteValueInternal(){} // RVA: 0x7FFAC9CBBF30
        public void WriteNull(){} // RVA: 0x7FFAC9CBBF60
        public void WriteUndefined(){} // RVA: 0x7FFAC9CBC000
        public void WriteRaw(){} // RVA: 0x7FFAC9CBBF30
        public void WriteValue(){} // RVA: 0x7FFAC9CBD810 | overloaded x22
        public void WriteEscapedString(){} // RVA: 0x7FFAC9CBC170
        public void WriteComment(){} // RVA: 0x7FFAC9CBD920
        public void EnsureWriteBuffer(){} // RVA: 0x7FFAC9CBD9F0
        public void WriteIntegerValue(){} // RVA: 0x7FFAC9CBDB70 | overloaded x2
    }

    public class JsonWriter : Object
    {
        public 0x6B245098[][] CloseOutput;
        public 0x6B245098[][] Top; // 0x8
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.JsonPosition> WriteState; // 0x10
        public Valve.Newtonsoft.Json.JsonPosition ContainerPath; // 0x18
        public 0x6B245098 Path; // 0x30
        public 0x6B2446A0 Formatting; // 0x34
        public bool DateFormatHandling; // 0x38
        public 0x6B244490 DateTimeZoneHandling; // 0x3C
        public 0x6B244540 StringEscapeHandling; // 0x40
        public 0x6B245460 FloatFormatHandling; // 0x44
        public 0x6B2445F0 DateFormatString; // 0x48
        public string Culture; // 0x50
        public System.Globalization.CultureInfo _culture; // 0x58

        // ── Methods ──
        public void BuildStateArray(){} // RVA: 0x7FFAC9CBDC90
        public void .cctor(){} // RVA: 0x7FFAC9CBE100
        public void get_CloseOutput(){} // RVA: 0x7FFAC31D95D0
        public void set_CloseOutput(){} // RVA: 0x7FFAC31D95C0
        public void get_Top(){} // RVA: 0x7FFAC9CBE8D0
        public void get_WriteState(){} // RVA: 0x7FFAC9CBE930
        public void get_ContainerPath(){} // RVA: 0x7FFAC9CBEA40
        public void get_Path(){} // RVA: 0x7FFAC9CBEAE0
        public void get_Formatting(){} // RVA: 0x7FFAC3ADEDC0
        public void set_Formatting(){} // RVA: 0x7FFAC9CBEC60
        public void get_DateFormatHandling(){} // RVA: 0x7FFAC33BD4A0
        public void set_DateFormatHandling(){} // RVA: 0x7FFAC9CBECD0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC2FC2080
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC9CBED40
        public void get_StringEscapeHandling(){} // RVA: 0x7FFAC2FC20A0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFAC9CBEDB0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFAC2F21310
        public void get_FloatFormatHandling(){} // RVA: 0x7FFAC2FC20C0
        public void set_FloatFormatHandling(){} // RVA: 0x7FFAC9CBEE30
        public void get_DateFormatString(){} // RVA: 0x7FFAC2FC20E0
        public void set_DateFormatString(){} // RVA: 0x7FFAC30794D0
        public void get_Culture(){} // RVA: 0x7FFAC9CBEEA0
        public void set_Culture(){} // RVA: 0x7FFAC2FE9510
        public void .ctor(){} // RVA: 0x7FFAC9CBEF00
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFAC874A190
        public void Push(){} // RVA: 0x7FFAC9CBEF20
        public void Pop(){} // RVA: 0x7FFAC9CBF0D0
        public void Peek(){} // RVA: 0x7FFAC3157800
        public void Close(){} // RVA: 0x7FFAC9CBF240
        public void WriteStartObject(){} // RVA: 0x7FFAC9CBF2B0
        public void WriteEndObject(){} // RVA: 0x7FFAC9CBF2C0
        public void WriteStartArray(){} // RVA: 0x7FFAC9CBF2D0
        public void WriteEndArray(){} // RVA: 0x7FFAC9CBF2E0
        public void WriteStartConstructor(){} // RVA: 0x7FFAC9CBF2F0
        public void WriteEndConstructor(){} // RVA: 0x7FFAC9CBF300
        public void WritePropertyName(){} // RVA: 0x7FFAC87DF6E0 | overloaded x2
        public void WriteEnd(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void WriteToken(){} // RVA: 0x7FFAC9CBFFE0 | overloaded x4
        public void WriteConstructorDate(){} // RVA: 0x7FFAC9CC0270
        public void AutoCompleteAll(){} // RVA: 0x7FFAC9CBF240
        public void GetCloseTokenForType(){} // RVA: 0x7FFAC9CC0620
        public void AutoCompleteClose(){} // RVA: 0x7FFAC9CC06D0
        public void WriteIndent(){} // RVA: 0x7FFAC2F21310
        public void WriteValueDelimiter(){} // RVA: 0x7FFAC2F21310
        public void WriteIndentSpace(){} // RVA: 0x7FFAC2F21310
        public void AutoComplete(){} // RVA: 0x7FFAC9CC0B20
        public void WriteNull(){} // RVA: 0x7FFAC9CC0D50
        public void WriteUndefined(){} // RVA: 0x7FFAC9CC0D70
        public void WriteRaw(){} // RVA: 0x7FFAC2F21310
        public void WriteRawValue(){} // RVA: 0x7FFAC9CC0D90
        public void WriteValue(){} // RVA: 0x7FFAC9CC19B0 | overloaded x38
        public void WriteComment(){} // RVA: 0x7FFAC9CC1900
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC9CC1910
        public void Dispose(){} // RVA: 0x7FFAC9CC1980
        public void CreateUnsupportedTypeException(){} // RVA: 0x7FFAC9CC2CD0
        public void InternalWriteEnd(){} // RVA: 0x7FFAC9CC2DD0
        public void InternalWritePropertyName(){} // RVA: 0x7FFAC9CBF310
        public void InternalWriteRaw(){} // RVA: 0x7FFAC2F21310
        public void InternalWriteStart(){} // RVA: 0x7FFAC9CC2DE0
        public void InternalWriteValue(){} // RVA: 0x7FFAC9CC2FA0
        public void InternalWriteComment(){} // RVA: 0x7FFAC9CC1900
    }

    public class JsonWriterException : JsonException
    {
        public string Path; // 0x90

        // ── Methods ──
        public void set_Path(){} // RVA: 0x7FFAC354E360
        public void .ctor(){} // RVA: 0x7FFAC9CC3020 | overloaded x3
        public void Create(){} // RVA: 0x7FFAC9CC31B0 | overloaded x2
    }

}