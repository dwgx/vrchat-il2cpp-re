// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 30
// Methods: 1041

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5F51E70
        public void .ctor(){} // RVA: 0x5F51EB0
        public void Get(){} // RVA: 0x5F51F50
        public void Add(){} // RVA: 0x5F52140
        public void AddEntry(){} // RVA: 0x5F52380
        public void Grow(){} // RVA: 0x5F526B0
        public void TextEquals(){} // RVA: 0x5F52850
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x24B10
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0xDBE0
        public void get_LineNumber(){} // RVA: 0xD840
        public void get_LinePosition(){} // RVA: 0xD840
    }

    public class JsonArrayAttribute
    {
        // ── Methods ──
        public void get_AllowNullItems(){} // RVA: 0x3A5570
        public void set_AllowNullItems(){} // RVA: 0x3A5580
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
    }

    public class JsonConstructorAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonContainerAttribute
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x2F8380
        public void set_Id(){} // RVA: 0x2DEE30
        public void get_Title(){} // RVA: 0x2E07C0
        public void set_Title(){} // RVA: 0x343E80
        public void get_Description(){} // RVA: 0x30B0C0
        public void set_Description(){} // RVA: 0x30B0D0
        public void get_ItemConverterType(){} // RVA: 0x30B130
        public void set_ItemConverterType(){} // RVA: 0x2DEE90
        public void get_ItemConverterParameters(){} // RVA: 0x6374D0
        public void set_ItemConverterParameters(){} // RVA: 0x30B890
        public void get_NamingStrategyType(){} // RVA: 0x3A5500
        public void set_NamingStrategyType(){} // RVA: 0x5F529A0
        public void get_NamingStrategyParameters(){} // RVA: 0x37B370
        public void set_NamingStrategyParameters(){} // RVA: 0x5F52A50
        public void get_NamingStrategyInstance(){} // RVA: 0x4976A0
        public void set_NamingStrategyInstance(){} // RVA: 0x49B830
        public void get_IsReference(){} // RVA: 0x5F52B00
        public void set_IsReference(){} // RVA: 0x5F52B40
        public void get_ItemIsReference(){} // RVA: 0x5F52B90
        public void set_ItemIsReference(){} // RVA: 0x5F52BD0
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x5F52C20
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x5F52C60
        public void get_ItemTypeNameHandling(){} // RVA: 0x5F52CC0
        public void set_ItemTypeNameHandling(){} // RVA: 0x5F52D00
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class JsonConvert
    {
        public object DefaultSettings;

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x5F52D60
        public void set_DefaultSettings(){} // RVA: 0x5F52DC0
        public void ToString(){} // RVA: 0x5F55420 | overloaded x30
        public void ToStringInternal(){} // RVA: 0x5F53AB0
        public void EnsureFloatFormat(){} // RVA: 0x5F53F90
        public void EnsureDecimalPlace(){} // RVA: 0x5F54540 | overloaded x2
        public void SerializeObject(){} // RVA: 0x5F56EE0 | overloaded x8
        public void SerializeObjectInternal(){} // RVA: 0x5F56FB0
        public void DeserializeObject(){} // RVA: 0x5F574A0 | overloaded x8
        public void DeserializeAnonymousType(){} // RVA: 0x283FA0 | overloaded x2
        public void PopulateObject(){} // RVA: 0x5F57720 | overloaded x2
        public void SerializeXmlNode(){} // RVA: 0x5F57B60 | overloaded x3
        public void DeserializeXmlNode(){} // RVA: 0x5F57E70 | overloaded x4
        public void SerializeXNode(){} // RVA: 0x5F58360 | overloaded x3
        public void DeserializeXNode(){} // RVA: 0x5F58670 | overloaded x4
        public void .cctor(){} // RVA: 0x5F588C0
    }

    public class JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x2F090
        public void ReadJson(){} // RVA: 0x1F0F0
        public void CanConvert(){} // RVA: 0xDE40
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonConverterAttribute
    {
        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x2F8380
        public void get_ConverterParameters(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x5F58D70 | overloaded x2
    }

    public class JsonConverterCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F58ED0
    }

    public class JsonConverter`1
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x283FA0 | overloaded x2
        public void ReadJson(){} // RVA: 0x283FA0 | overloaded x2
        public void CanConvert(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x24A50
    }

    public class JsonDictionaryAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F59030 | overloaded x4
        public void Create(){} // RVA: 0x5F590B0
    }

    public class JsonExtensionDataAttribute
    {
        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x3A75E0
        public void set_WriteData(){} // RVA: 0x3A75F0
        public void get_ReadData(){} // RVA: 0x543460
        public void set_ReadData(){} // RVA: 0x543470
        public void .ctor(){} // RVA: 0x570B20
    }

    public class JsonIgnoreAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonNameTable
    {
        // ── Methods ──
        public void Get(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonObjectAttribute
    {
        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x1C91440
        public void set_MemberSerialization(){} // RVA: 0x1C91450
        public void get_MissingMemberHandling(){} // RVA: 0x5F59190
        public void set_MissingMemberHandling(){} // RVA: 0x5F591D0
        public void get_ItemNullValueHandling(){} // RVA: 0x5F59230
        public void set_ItemNullValueHandling(){} // RVA: 0x5F59280
        public void get_ItemRequired(){} // RVA: 0x5F592E0
        public void set_ItemRequired(){} // RVA: 0x5F59320
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
    }

    public class JsonPosition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F59380
        public void CalculateLength(){} // RVA: 0x5F59440
        public void WriteTo(){} // RVA: 0x5F594E0
        public void TypeHasIndex(){} // RVA: 0x5F59710
        public void BuildPath(){} // RVA: 0x5F59720
        public void FormatMessage(){} // RVA: 0x5F59D20
        public void .cctor(){} // RVA: 0x5F5A090
    }

    public class JsonPropertyAttribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x37B370
        public void set_ItemConverterType(){} // RVA: 0x37B380
        public void get_ItemConverterParameters(){} // RVA: 0x358D50
        public void set_ItemConverterParameters(){} // RVA: 0x358D60
        public void get_NamingStrategyType(){} // RVA: 0x3A5590
        public void set_NamingStrategyType(){} // RVA: 0x3A55A0
        public void get_NamingStrategyParameters(){} // RVA: 0x4C7C50
        public void set_NamingStrategyParameters(){} // RVA: 0x4C34F0
        public void get_NullValueHandling(){} // RVA: 0x5F5A170
        public void set_NullValueHandling(){} // RVA: 0x5F5A1B0
        public void get_DefaultValueHandling(){} // RVA: 0x5F5A210
        public void set_DefaultValueHandling(){} // RVA: 0x5F5A250
        public void get_ReferenceLoopHandling(){} // RVA: 0x5F5A2B0
        public void set_ReferenceLoopHandling(){} // RVA: 0x5F5A2F0
        public void get_ObjectCreationHandling(){} // RVA: 0x5F5A350
        public void set_ObjectCreationHandling(){} // RVA: 0x5F5A390
        public void get_TypeNameHandling(){} // RVA: 0x5F5A3F0
        public void set_TypeNameHandling(){} // RVA: 0x5F5A430
        public void get_IsReference(){} // RVA: 0x5F5A490
        public void set_IsReference(){} // RVA: 0x5F5A4D0
        public void get_Order(){} // RVA: 0x5F5A520
        public void set_Order(){} // RVA: 0x5F5A560
        public void get_Required(){} // RVA: 0x5F5A5C0
        public void set_Required(){} // RVA: 0x5F5A600
        public void get_PropertyName(){} // RVA: 0x462D00
        public void set_PropertyName(){} // RVA: 0x464450
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x5F5A660
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x5F5A6A0
        public void get_ItemTypeNameHandling(){} // RVA: 0x5F5A700
        public void set_ItemTypeNameHandling(){} // RVA: 0x5F5A740
        public void get_ItemIsReference(){} // RVA: 0x5F5A7A0
        public void set_ItemIsReference(){} // RVA: 0x5F5A7E0
        public void .ctor(){} // RVA: 0x464450 | overloaded x2
    }

    public class JsonReader
    {
        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x5F5A830
        public void SkipAsync(){} // RVA: 0x5F5A9F0
        public void ReaderReadAndAssertAsync(){} // RVA: 0x5F5AC00
        public void ReadAsBooleanAsync(){} // RVA: 0x5F5AE10
        public void ReadAsBytesAsync(){} // RVA: 0x5F5AFB0
        public void ReadArrayIntoByteArrayAsync(){} // RVA: 0x5F5B0C0
        public void ReadAsDateTimeAsync(){} // RVA: 0x5F5B2B0
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x5F5B4C0
        public void ReadAsDecimalAsync(){} // RVA: 0x5F5B6E0
        public void ReadAsDoubleAsync(){} // RVA: 0x5F5B900
        public void ReadAsInt32Async(){} // RVA: 0x5F5BA30
        public void ReadAsStringAsync(){} // RVA: 0x5F5BBD0
        public void ReadAndMoveToContentAsync(){} // RVA: 0x5F5BCA0
        public void MoveToContentAsync(){} // RVA: 0x5F5BE90
        public void MoveToContentFromNonContentAsync(){} // RVA: 0x5F5BF30
        public void get_CurrentState(){} // RVA: 0xCEF5B0
        public void get_CloseInput(){} // RVA: 0x359320
        public void set_CloseInput(){} // RVA: 0x359330
        public void get_SupportMultipleContent(){} // RVA: 0x5AAEFD0
        public void set_SupportMultipleContent(){} // RVA: 0x5AAEFE0
        public void get_QuoteChar(){} // RVA: 0x44B4370
        public void set_QuoteChar(){} // RVA: 0x5AC0F20
        public void get_DateTimeZoneHandling(){} // RVA: 0x37E0C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x5F5C120
        public void get_DateParseHandling(){} // RVA: 0x9EAB90
        public void set_DateParseHandling(){} // RVA: 0x5F5C190
        public void get_FloatParseHandling(){} // RVA: 0x5A54D0
        public void set_FloatParseHandling(){} // RVA: 0x5F5C200
        public void get_DateFormatString(){} // RVA: 0x37B370
        public void set_DateFormatString(){} // RVA: 0x37B380
        public void get_MaxDepth(){} // RVA: 0x36B37B0
        public void set_MaxDepth(){} // RVA: 0x5F5C270
        public void get_TokenType(){} // RVA: 0x32A5C0
        public void get_Value(){} // RVA: 0x2E07C0
        public void get_ValueType(){} // RVA: 0x5F5C330
        public void get_Depth(){} // RVA: 0x5F5C350
        public void get_Path(){} // RVA: 0x5F5C3C0
        public void get_Culture(){} // RVA: 0x5F5C540
        public void set_Culture(){} // RVA: 0x305200
        public void GetPosition(){} // RVA: 0x5F5C5A0
        public void .ctor(){} // RVA: 0x5F5C660
        public void Push(){} // RVA: 0x5F5C6D0
        public void Pop(){} // RVA: 0x5F5CA20
        public void Peek(){} // RVA: 0x791DC0
        public void Read(){} // RVA: 0xDBE0
        public void ReadAsInt32(){} // RVA: 0x5F5CBD0
        public void ReadInt32String(){} // RVA: 0x5F5D020
        public void ReadAsString(){} // RVA: 0x5F5D3B0
        public void ReadAsBytes(){} // RVA: 0x5F5D660
        public void ReadArrayIntoByteArray(){} // RVA: 0x5F5DC80
        public void ReadArrayElementIntoByteArrayReportDone(){} // RVA: 0x5F5DE80
        public void ReadAsDouble(){} // RVA: 0x5F5E080
        public void ReadDoubleString(){} // RVA: 0x5F5E440
        public void ReadAsBoolean(){} // RVA: 0x5F5E780
        public void ReadBooleanString(){} // RVA: 0x5F5EBE0
        public void ReadAsDecimal(){} // RVA: 0x5F5EFC0
        public void ReadDecimalString(){} // RVA: 0x5F5F470
        public void ReadAsDateTime(){} // RVA: 0x5F5F930
        public void ReadDateTimeString(){} // RVA: 0x5F5FC90
        public void ReadAsDateTimeOffset(){} // RVA: 0x5F600D0
        public void ReadDateTimeOffsetString(){} // RVA: 0x5F60410
        public void ReaderReadAndAssert(){} // RVA: 0x5F60840
        public void CreateUnexpectedEndException(){} // RVA: 0x5F60890
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x5F608E0
        public void Skip(){} // RVA: 0x5F60CB0
        public void SetToken(){} // RVA: 0x5F60DB0 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x5F60FE0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x5F61010
        public void ValidateEnd(){} // RVA: 0x5F61020
        public void SetStateBasedOnCurrent(){} // RVA: 0x5F611E0
        public void SetFinished(){} // RVA: 0x5F612F0
        public void GetTypeForCloseToken(){} // RVA: 0x5F61310
        public void System.IDisposable.Dispose(){} // RVA: 0x5F61400
        public void Dispose(){} // RVA: 0x5F61470
        public void Close(){} // RVA: 0x5F614A0
        public void ReadAndAssert(){} // RVA: 0x5F61500
        public void ReadForTypeAndAssert(){} // RVA: 0x5F61560
        public void ReadForType(){} // RVA: 0x5F615B0
        public void ReadAndMoveToContent(){} // RVA: 0x5F61870
        public void MoveToContent(){} // RVA: 0x5F618D0
        public void GetContentToken(){} // RVA: 0x5F61930
    }

    public class JsonReaderException
    {
        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x6AFD40
        public void get_LinePosition(){} // RVA: 0x6AFD30
        public void get_Path(){} // RVA: 0xA1C8C0
        public void .ctor(){} // RVA: 0x5F63260 | overloaded x5
        public void Create(){} // RVA: 0x5F634F0 | overloaded x3
    }

    public class JsonRequiredAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonSerializationException
    {
        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x6AFD40
        public void get_LinePosition(){} // RVA: 0x6AFD30
        public void get_Path(){} // RVA: 0xA1C8C0
        public void .ctor(){} // RVA: 0x5F63260 | overloaded x5
        public void Create(){} // RVA: 0x5F637B0 | overloaded x3
    }

    public class JsonSerializer
    {
        // ── Methods ──
        public void add_Error(){} // RVA: 0x5F63930
        public void remove_Error(){} // RVA: 0x5F63A30
        public void get_ReferenceResolver(){} // RVA: 0x5F63B30
        public void set_ReferenceResolver(){} // RVA: 0x5F63B40
        public void get_Binder(){} // RVA: 0x5F63C10
        public void set_Binder(){} // RVA: 0x5F63D30
        public void get_SerializationBinder(){} // RVA: 0x3A5500
        public void set_SerializationBinder(){} // RVA: 0x5F63E90
        public void get_TraceWriter(){} // RVA: 0x358730
        public void set_TraceWriter(){} // RVA: 0x358740
        public void get_EqualityComparer(){} // RVA: 0x37E0E0
        public void set_EqualityComparer(){} // RVA: 0x4354D0
        public void get_TypeNameHandling(){} // RVA: 0x32A5C0
        public void set_TypeNameHandling(){} // RVA: 0x5F63F60
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x8ABED0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x5F63FD0
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x8ABED0
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x5F64040
        public void get_PreserveReferencesHandling(){} // RVA: 0x5BED50
        public void set_PreserveReferencesHandling(){} // RVA: 0x5F640B0
        public void get_ReferenceLoopHandling(){} // RVA: 0x197C3B0
        public void set_ReferenceLoopHandling(){} // RVA: 0x5F64120
        public void get_MissingMemberHandling(){} // RVA: 0x760030
        public void set_MissingMemberHandling(){} // RVA: 0x5F64190
        public void get_NullValueHandling(){} // RVA: 0x791DC0
        public void set_NullValueHandling(){} // RVA: 0x5F64200
        public void get_DefaultValueHandling(){} // RVA: 0x1209F00
        public void set_DefaultValueHandling(){} // RVA: 0x5F64270
        public void get_ObjectCreationHandling(){} // RVA: 0xCEF5B0
        public void set_ObjectCreationHandling(){} // RVA: 0x5F642E0
        public void get_ConstructorHandling(){} // RVA: 0x338CD0
        public void set_ConstructorHandling(){} // RVA: 0x5F64350
        public void get_MetadataPropertyHandling(){} // RVA: 0x4C6670
        public void set_MetadataPropertyHandling(){} // RVA: 0x5F643C0
        public void get_Converters(){} // RVA: 0x5F64430
        public void get_ContractResolver(){} // RVA: 0x35A740
        public void set_ContractResolver(){} // RVA: 0x5F64510
        public void get_Context(){} // RVA: 0x36ABF00
        public void set_Context(){} // RVA: 0x5F645D0
        public void get_Formatting(){} // RVA: 0x5F64630
        public void set_Formatting(){} // RVA: 0x5F64670
        public void get_DateFormatHandling(){} // RVA: 0x5F646D0
        public void set_DateFormatHandling(){} // RVA: 0x5F64720
        public void get_DateTimeZoneHandling(){} // RVA: 0x5F64780
        public void set_DateTimeZoneHandling(){} // RVA: 0x5F647E0
        public void get_DateParseHandling(){} // RVA: 0x5F64840
        public void set_DateParseHandling(){} // RVA: 0x5F648A0
        public void get_FloatParseHandling(){} // RVA: 0x5F64900
        public void set_FloatParseHandling(){} // RVA: 0x5F64950
        public void get_FloatFormatHandling(){} // RVA: 0x5F649B0
        public void set_FloatFormatHandling(){} // RVA: 0x5F64A00
        public void get_StringEscapeHandling(){} // RVA: 0x5F64A60
        public void set_StringEscapeHandling(){} // RVA: 0x5F64AB0
        public void get_DateFormatString(){} // RVA: 0x5F64B10
        public void set_DateFormatString(){} // RVA: 0x5F64B60
        public void get_Culture(){} // RVA: 0x5F64BD0
        public void set_Culture(){} // RVA: 0x348050
        public void get_MaxDepth(){} // RVA: 0x3480B0
        public void set_MaxDepth(){} // RVA: 0x5F64C40
        public void get_CheckAdditionalContent(){} // RVA: 0x5F64D10
        public void set_CheckAdditionalContent(){} // RVA: 0x5F64D60
        public void IsCheckAdditionalContentSet(){} // RVA: 0x5F64DC0
        public void .ctor(){} // RVA: 0x5F64E10
        public void Create(){} // RVA: 0x5F65100 | overloaded x2
        public void CreateDefault(){} // RVA: 0x5F65270 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x5F652B0
        public void Populate(){} // RVA: 0x5F65DD0 | overloaded x2
        public void PopulateInternal(){} // RVA: 0x5F65DF0
        public void Deserialize(){} // RVA: 0x5F661C0 | overloaded x4
        public void DeserializeInternal(){} // RVA: 0x5F661E0
        public void SetupReader(){} // RVA: 0x5F664C0
        public void ResetReader(){} // RVA: 0x5F66A80
        public void Serialize(){} // RVA: 0x5F66EE0 | overloaded x4
        public void CreateTraceJsonReader(){} // RVA: 0x5F66F10
        public void SerializeInternal(){} // RVA: 0x5F66FD0
        public void GetReferenceResolver(){} // RVA: 0x5F67770
        public void GetMatchingConverter(){} // RVA: 0x5F67820 | overloaded x2
        public void OnError(){} // RVA: 0x5F678F0
    }

    public class JsonSerializerSettings
    {
        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x5F67920
        public void set_ReferenceLoopHandling(){} // RVA: 0x5F67970
        public void get_MissingMemberHandling(){} // RVA: 0x5F679D0
        public void set_MissingMemberHandling(){} // RVA: 0x5F67A20
        public void get_ObjectCreationHandling(){} // RVA: 0x5F67A80
        public void set_ObjectCreationHandling(){} // RVA: 0x5F67AD0
        public void get_NullValueHandling(){} // RVA: 0x5F67B30
        public void set_NullValueHandling(){} // RVA: 0x5F67B80
        public void get_DefaultValueHandling(){} // RVA: 0x5F67BE0
        public void set_DefaultValueHandling(){} // RVA: 0x5F67C20
        public void get_Converters(){} // RVA: 0xA96D30
        public void set_Converters(){} // RVA: 0x35E8A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x5F67C80
        public void set_PreserveReferencesHandling(){} // RVA: 0x5F67CD0
        public void get_TypeNameHandling(){} // RVA: 0x5F67D30
        public void set_TypeNameHandling(){} // RVA: 0x5F67D80
        public void get_MetadataPropertyHandling(){} // RVA: 0x5F67DE0
        public void set_MetadataPropertyHandling(){} // RVA: 0x5F67E30
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x5F67E90
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x5F67ED0
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x5F67E90
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x5F67ED0
        public void get_ConstructorHandling(){} // RVA: 0x5F67F30
        public void set_ConstructorHandling(){} // RVA: 0x5F67F80
        public void get_ContractResolver(){} // RVA: 0x35E900
        public void set_ContractResolver(){} // RVA: 0x35E910
        public void get_EqualityComparer(){} // RVA: 0x35E970
        public void set_EqualityComparer(){} // RVA: 0x35E980
        public void get_ReferenceResolver(){} // RVA: 0x5F67FE0
        public void set_ReferenceResolver(){} // RVA: 0x5F68000
        public void get_ReferenceResolverProvider(){} // RVA: 0x3482A0
        public void set_ReferenceResolverProvider(){} // RVA: 0x3482B0
        public void get_TraceWriter(){} // RVA: 0x7F7DB0
        public void set_TraceWriter(){} // RVA: 0x63D280
        public void get_Binder(){} // RVA: 0x5F68190
        public void set_Binder(){} // RVA: 0x5F68270
        public void get_SerializationBinder(){} // RVA: 0xA94E10
        public void set_SerializationBinder(){} // RVA: 0xCF6DE0
        public void get_Error(){} // RVA: 0xA902E0
        public void set_Error(){} // RVA: 0xCF4780
        public void get_Context(){} // RVA: 0x5F68390
        public void set_Context(){} // RVA: 0x5F68460
        public void get_DateFormatString(){} // RVA: 0x5F68580
        public void set_DateFormatString(){} // RVA: 0x5F685D0
        public void get_MaxDepth(){} // RVA: 0x5F68630
        public void set_MaxDepth(){} // RVA: 0x5F68690
        public void get_Formatting(){} // RVA: 0x5F68750
        public void set_Formatting(){} // RVA: 0x5F68790
        public void get_DateFormatHandling(){} // RVA: 0x5F687F0
        public void set_DateFormatHandling(){} // RVA: 0x5F68830
        public void get_DateTimeZoneHandling(){} // RVA: 0x5F68890
        public void set_DateTimeZoneHandling(){} // RVA: 0x5F688F0
        public void get_DateParseHandling(){} // RVA: 0x5F68950
        public void set_DateParseHandling(){} // RVA: 0x5F689B0
        public void get_FloatFormatHandling(){} // RVA: 0x5F68A10
        public void set_FloatFormatHandling(){} // RVA: 0x5F68A50
        public void get_FloatParseHandling(){} // RVA: 0x5F68AB0
        public void set_FloatParseHandling(){} // RVA: 0x5F68AF0
        public void get_StringEscapeHandling(){} // RVA: 0x5F68B50
        public void set_StringEscapeHandling(){} // RVA: 0x5F68B90
        public void get_Culture(){} // RVA: 0x5F68BF0
        public void set_Culture(){} // RVA: 0x358740
        public void get_CheckAdditionalContent(){} // RVA: 0x5F68C60
        public void set_CheckAdditionalContent(){} // RVA: 0x5F68CA0
        public void .cctor(){} // RVA: 0x5F68CF0
        public void .ctor(){} // RVA: 0x5F68ED0 | overloaded x2
    }

    public class JsonTextReader
    {
        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x5F69440
        public void DoReadAsync(){} // RVA: 0x5F69930 | overloaded x2
        public void ParsePostValueAsync(){} // RVA: 0x5F69B80
        public void ReadFromFinishedAsync(){} // RVA: 0x5F69D90
        public void ReadDataAsync(){} // RVA: 0x5F69FB0 | overloaded x2
        public void ParseValueAsync(){} // RVA: 0x5F6A1D0
        public void ReadStringIntoBufferAsync(){} // RVA: 0x5F6A3D0
        public void ProcessCarriageReturnAsync(){} // RVA: 0x5F6A760 | overloaded x2
        public void ParseUnicodeAsync(){} // RVA: 0x5F6A970
        public void EnsureCharsAsync(){} // RVA: 0x5F6AB60
        public void ReadCharsAsync(){} // RVA: 0x5F6AC50
        public void ParseObjectAsync(){} // RVA: 0x5F6AE70
        public void ParseCommentAsync(){} // RVA: 0x5F6B070
        public void EatWhitespaceAsync(){} // RVA: 0x5F6B2C0
        public void ParseStringAsync(){} // RVA: 0x5F6B4D0
        public void MatchValueAsync(){} // RVA: 0x5F6B710
        public void MatchValueWithTrailingSeparatorAsync(){} // RVA: 0x5F6B960
        public void MatchAndSetAsync(){} // RVA: 0x5F6BBB0
        public void ParseTrueAsync(){} // RVA: 0x5F6BE80
        public void ParseFalseAsync(){} // RVA: 0x5F6BF40
        public void ParseNullAsync(){} // RVA: 0x5F6C090
        public void ParseConstructorAsync(){} // RVA: 0x5F6C120
        public void ParseNumberNaNAsync(){} // RVA: 0x5F6C340
        public void ParseNumberPositiveInfinityAsync(){} // RVA: 0x5F6C540
        public void ParseNumberNegativeInfinityAsync(){} // RVA: 0x5F6C740
        public void ParseNumberAsync(){} // RVA: 0x5F6C940
        public void ParseUndefinedAsync(){} // RVA: 0x5F6CB70
        public void ParsePropertyAsync(){} // RVA: 0x5F6CC00
        public void ReadNumberIntoBufferAsync(){} // RVA: 0x5F6CE00
        public void ParseUnquotedPropertyAsync(){} // RVA: 0x5F6D010
        public void ReadNullCharAsync(){} // RVA: 0x5F6D220
        public void HandleNullAsync(){} // RVA: 0x5F6D410
        public void ReadFinishedAsync(){} // RVA: 0x5F6D620
        public void ReadStringValueAsync(){} // RVA: 0x5F6D830
        public void ReadNumberValueAsync(){} // RVA: 0x5F6DA40
        public void ReadAsBooleanAsync(){} // RVA: 0x5F6DC50
        public void DoReadAsBooleanAsync(){} // RVA: 0x5F6DC70
        public void ReadAsBytesAsync(){} // RVA: 0x5F6DE70
        public void DoReadAsBytesAsync(){} // RVA: 0x5F6DFA0
        public void ReadIntoWrappedTypeObjectAsync(){} // RVA: 0x5F6E1A0
        public void ReadAsDateTimeAsync(){} // RVA: 0x5F6E3B0
        public void DoReadAsDateTimeAsync(){} // RVA: 0x5F6E3D0
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x5F6E5C0
        public void DoReadAsDateTimeOffsetAsync(){} // RVA: 0x5F6E5E0
        public void ReadAsDecimalAsync(){} // RVA: 0x5F6E7D0
        public void DoReadAsDecimalAsync(){} // RVA: 0x5F6E7F0
        public void ReadAsDoubleAsync(){} // RVA: 0x5F6E9E0
        public void DoReadAsDoubleAsync(){} // RVA: 0x5F6EB20
        public void ReadAsInt32Async(){} // RVA: 0x5F6ED10
        public void DoReadAsInt32Async(){} // RVA: 0x5F6ED30
        public void ReadAsStringAsync(){} // RVA: 0x5F6EF20
        public void DoReadAsStringAsync(){} // RVA: 0x5F6F010
        public void .ctor(){} // RVA: 0x5F6F200
        public void get_PropertyNameTable(){} // RVA: 0x3FA100
        public void set_PropertyNameTable(){} // RVA: 0x3FA110
        public void get_ArrayPool(){} // RVA: 0x435460
        public void set_ArrayPool(){} // RVA: 0x5F6F3A0
        public void EnsureBufferNotEmpty(){} // RVA: 0x5F6F450
        public void SetNewLine(){} // RVA: 0x5F6F5A0
        public void OnNewLine(){} // RVA: 0x5F6F600
        public void ParseString(){} // RVA: 0x5F6F610
        public void ParseReadString(){} // RVA: 0x5F6F670
        public void BlockCopyChars(){} // RVA: 0x5F6FCA0
        public void ShiftBufferIfNeeded(){} // RVA: 0x5F6FCC0
        public void ReadData(){} // RVA: 0x5F70100 | overloaded x2
        public void PrepareBufferForReadData(){} // RVA: 0x5F6FDB0
        public void EnsureChars(){} // RVA: 0x5F701D0
        public void ReadChars(){} // RVA: 0x5F70320
        public void Read(){} // RVA: 0x5F70460
        public void ReadAsInt32(){} // RVA: 0x5F707E0
        public void ReadAsDateTime(){} // RVA: 0x5F708D0
        public void ReadAsString(){} // RVA: 0x5F709C0
        public void ReadAsBytes(){} // RVA: 0x5F70A30
        public void ReadStringValue(){} // RVA: 0x5F71190
        public void FinishReadQuotedStringValue(){} // RVA: 0x5F71A70
        public void CreateUnexpectedCharacterException(){} // RVA: 0x5F71D50
        public void ReadAsBoolean(){} // RVA: 0x5F71E60
        public void ProcessValueComma(){} // RVA: 0x5F72900
        public void ReadNumberValue(){} // RVA: 0x5F72980
        public void FinishReadQuotedNumber(){} // RVA: 0x5F73170
        public void ReadAsDateTimeOffset(){} // RVA: 0x5F73320
        public void ReadAsDecimal(){} // RVA: 0x5F73420
        public void ReadAsDouble(){} // RVA: 0x5F73520
        public void HandleNull(){} // RVA: 0x5F73610
        public void ReadFinished(){} // RVA: 0x5F73720
        public void ReadNullChar(){} // RVA: 0x5F738D0
        public void EnsureBuffer(){} // RVA: 0x5F73920
        public void ReadStringIntoBuffer(){} // RVA: 0x5F73A30
        public void FinishReadStringIntoBuffer(){} // RVA: 0x5F73FE0
        public void WriteCharToBuffer(){} // RVA: 0x5F74210
        public void ConvertUnicode(){} // RVA: 0x5F742C0
        public void ParseUnicode(){} // RVA: 0x5F744F0
        public void ReadNumberIntoBuffer(){} // RVA: 0x5F74520
        public void ReadNumberCharIntoBuffer(){} // RVA: 0x5F745A0
        public void ClearRecentString(){} // RVA: 0x5F74760
        public void ParsePostValue(){} // RVA: 0x5F74780
        public void ParseObject(){} // RVA: 0x5F74C10
        public void ParseProperty(){} // RVA: 0x5F74E20
        public void ValidIdentifierChar(){} // RVA: 0x5F75330
        public void ParseUnquotedProperty(){} // RVA: 0x5F753A0
        public void ReadUnquotedPropertyReportIfDone(){} // RVA: 0x5F75550
        public void ParseValue(){} // RVA: 0x5F75750
        public void ProcessLineFeed(){} // RVA: 0x5F76380
        public void ProcessCarriageReturn(){} // RVA: 0x5F763A0
        public void EatWhitespace(){} // RVA: 0x5F76410
        public void ParseConstructor(){} // RVA: 0x5F76580
        public void ParseNumber(){} // RVA: 0x5F76B10
        public void ParseReadNumber(){} // RVA: 0x5F76C10
        public void ThrowReaderError(){} // RVA: 0x5F78350
        public void BigIntegerParse(){} // RVA: 0x5F78420
        public void ParseComment(){} // RVA: 0x5F78500
        public void EndComment(){} // RVA: 0x5F788A0
        public void MatchValue(){} // RVA: 0x5F789B0 | overloaded x2
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x5F78AA0
        public void IsSeparator(){} // RVA: 0x5F78B70
        public void ParseTrue(){} // RVA: 0x5F78CC0
        public void ParseNull(){} // RVA: 0x5F78E40
        public void ParseUndefined(){} // RVA: 0x5F78F80
        public void ParseFalse(){} // RVA: 0x5F790C0
        public void ParseNumberNegativeInfinity(){} // RVA: 0x5F792C0 | overloaded x2
        public void ParseNumberPositiveInfinity(){} // RVA: 0x5F79630 | overloaded x2
        public void ParseNumberNaN(){} // RVA: 0x5F799A0 | overloaded x2
        public void Close(){} // RVA: 0x5F79C90
        public void HasLineInfo(){} // RVA: 0x3C2850
        public void get_LineNumber(){} // RVA: 0x5F79E10
        public void get_LinePosition(){} // RVA: 0x5F79E60
    }

    public class JsonTextWriter
    {
        // ── Methods ──
        public void FlushAsync(){} // RVA: 0x5F8E1F0
        public void DoFlushAsync(){} // RVA: 0x5F8E350
        public void WriteValueDelimiterAsync(){} // RVA: 0x5F8E3E0
        public void DoWriteValueDelimiterAsync(){} // RVA: 0x5F8E520
        public void WriteEndAsync(){} // RVA: 0x5F8EDF0 | overloaded x2
        public void DoWriteEndAsync(){} // RVA: 0x5F8E7F0
        public void CloseAsync(){} // RVA: 0x5F8E930
        public void DoCloseAsync(){} // RVA: 0x5F8EA30
        public void CloseBufferAndWriterAsync(){} // RVA: 0x5F8EC40
        public void WriteIndentAsync(){} // RVA: 0x5F8F340 | overloaded x2
        public void DoWriteIndentAsync(){} // RVA: 0x5F8F230
        public void WriteValueInternalAsync(){} // RVA: 0x5F8F660 | overloaded x2
        public void WriteIndentSpaceAsync(){} // RVA: 0x5F8F930
        public void DoWriteIndentSpaceAsync(){} // RVA: 0x5F8FA70
        public void WriteRawAsync(){} // RVA: 0x5F8FAE0
        public void DoWriteRawAsync(){} // RVA: 0x5F8FC40
        public void WriteNullAsync(){} // RVA: 0x5F8FCC0
        public void DoWriteNullAsync(){} // RVA: 0x5F8FE20
        public void WriteDigitsAsync(){} // RVA: 0x5F8FEA0
        public void WriteIntegerValueAsync(){} // RVA: 0x5F90360 | overloaded x4
        public void WriteEscapedStringAsync(){} // RVA: 0x5F90380
        public void WritePropertyNameAsync(){} // RVA: 0x5F90AF0 | overloaded x2
        public void DoWritePropertyNameAsync(){} // RVA: 0x5F90C00 | overloaded x3
        public void WriteStartArrayAsync(){} // RVA: 0x5F90E90
        public void DoWriteStartArrayAsync(){} // RVA: 0x5F91120 | overloaded x2
        public void WriteStartObjectAsync(){} // RVA: 0x5F913A0
        public void DoWriteStartObjectAsync(){} // RVA: 0x5F91630 | overloaded x2
        public void WriteStartConstructorAsync(){} // RVA: 0x5F918B0
        public void DoWriteStartConstructorAsync(){} // RVA: 0x5F919C0
        public void WriteUndefinedAsync(){} // RVA: 0x5F91C40
        public void DoWriteUndefinedAsync(){} // RVA: 0x5F91F30 | overloaded x2
        public void WriteWhitespaceAsync(){} // RVA: 0x5F921B0
        public void DoWriteWhitespaceAsync(){} // RVA: 0x5F92310
        public void WriteValueAsync(){} // RVA: 0x5F97AA0 | overloaded x41
        public void DoWriteValueAsync(){} // RVA: 0x5F97C20 | overloaded x24
        public void WriteValueNonNullAsync(){} // RVA: 0x5F92BB0
        public void WriteValueNotNullAsync(){} // RVA: 0x5F976B0 | overloaded x2
        public void WriteCommentAsync(){} // RVA: 0x5F97CC0
        public void DoWriteCommentAsync(){} // RVA: 0x5F97DD0
        public void WriteEndArrayAsync(){} // RVA: 0x5F98050
        public void WriteEndConstructorAsync(){} // RVA: 0x5F98150
        public void WriteEndObjectAsync(){} // RVA: 0x5F98250
        public void WriteRawValueAsync(){} // RVA: 0x5F98350
        public void DoWriteRawValueAsync(){} // RVA: 0x5F985F0 | overloaded x2
        public void EnsureWriteBuffer(){} // RVA: 0x5F9BAB0 | overloaded x2
        public void get_Base64Encoder(){} // RVA: 0x5F98BD0
        public void get_ArrayPool(){} // RVA: 0xA1C8C0
        public void set_ArrayPool(){} // RVA: 0x5F98DD0
        public void get_Indentation(){} // RVA: 0x1AE6E60
        public void set_Indentation(){} // RVA: 0x5F98E80
        public void get_QuoteChar(){} // RVA: 0x5F98EF0
        public void set_QuoteChar(){} // RVA: 0x5F98F00
        public void get_IndentChar(){} // RVA: 0x5F98F80
        public void set_IndentChar(){} // RVA: 0x5F98F90
        public void get_QuoteName(){} // RVA: 0x113C490
        public void set_QuoteName(){} // RVA: 0x5F99000
        public void .ctor(){} // RVA: 0x5F99010
        public void Flush(){} // RVA: 0x5D34580
        public void Close(){} // RVA: 0x5F991A0
        public void CloseBufferAndWriter(){} // RVA: 0x5F992A0
        public void WriteStartObject(){} // RVA: 0x5F99390
        public void WriteStartArray(){} // RVA: 0x5F993F0
        public void WriteStartConstructor(){} // RVA: 0x5F99450
        public void WriteEnd(){} // RVA: 0x5F99520
        public void WritePropertyName(){} // RVA: 0x5F996D0 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x5F99810
        public void UpdateCharEscapeFlags(){} // RVA: 0x5F99820
        public void WriteIndent(){} // RVA: 0x5F998F0
        public void SetIndentChars(){} // RVA: 0x5F99A60
        public void WriteValueDelimiter(){} // RVA: 0x5F99C20
        public void WriteIndentSpace(){} // RVA: 0x5F99C50
        public void WriteValueInternal(){} // RVA: 0x5F99C80
        public void WriteValue(){} // RVA: 0x5F9B880 | overloaded x23
        public void WriteNull(){} // RVA: 0x5F99DE0
        public void WriteUndefined(){} // RVA: 0x5F99E80
        public void WriteRaw(){} // RVA: 0x5F99C80
        public void WriteEscapedString(){} // RVA: 0x5F99FF0
        public void WriteValueToBuffer(){} // RVA: 0x5F9B340 | overloaded x2
        public void WriteComment(){} // RVA: 0x5F9B990
        public void WriteWhitespace(){} // RVA: 0x5F9BA60
        public void WriteIntegerValue(){} // RVA: 0x5F9BE40 | overloaded x4
        public void WriteNumberToBuffer(){} // RVA: 0x5F9BED0 | overloaded x2
    }

    public class JsonValidatingReader
    {
        // ── Methods ──
        public void add_ValidationEventHandler(){} // RVA: 0x5FA4490
        public void remove_ValidationEventHandler(){} // RVA: 0x5FA4580
        public void get_Value(){} // RVA: 0x5FA4670
        public void get_Depth(){} // RVA: 0x5FA46A0
        public void get_Path(){} // RVA: 0x5FA46D0
        public void get_QuoteChar(){} // RVA: 0x5FA4700
        public void set_QuoteChar(){} // RVA: 0x2DD310
        public void get_TokenType(){} // RVA: 0x5FA4730
        public void get_ValueType(){} // RVA: 0x5FA4760
        public void Push(){} // RVA: 0x5FA4790
        public void Pop(){} // RVA: 0x5FA4850
        public void get_CurrentSchemas(){} // RVA: 0x5FA4950
        public void get_CurrentMemberSchemas(){} // RVA: 0x5FA4970
        public void RaiseError(){} // RVA: 0x5FA5450
        public void OnValidationEvent(){} // RVA: 0x5FA57B0
        public void .ctor(){} // RVA: 0x5FA5920
        public void get_Schema(){} // RVA: 0x31C010
        public void set_Schema(){} // RVA: 0x5FA5B00
        public void get_Reader(){} // RVA: 0x4C7C50
        public void Close(){} // RVA: 0x5FA5C40
        public void ValidateNotDisallowed(){} // RVA: 0x5FA5CD0
        public void GetCurrentNodeSchemaType(){} // RVA: 0x5FA5FF0
        public void ReadAsInt32(){} // RVA: 0x5FA6180
        public void ReadAsBytes(){} // RVA: 0x5FA61D0
        public void ReadAsDecimal(){} // RVA: 0x5FA6220
        public void ReadAsDouble(){} // RVA: 0x5FA6280
        public void ReadAsBoolean(){} // RVA: 0x5FA62E0
        public void ReadAsString(){} // RVA: 0x5FA6330
        public void ReadAsDateTime(){} // RVA: 0x5FA6380
        public void ReadAsDateTimeOffset(){} // RVA: 0x5FA63E0
        public void Read(){} // RVA: 0x5FA6440
        public void ValidateCurrentToken(){} // RVA: 0x5FA64B0
        public void WriteToken(){} // RVA: 0x5FA7310
        public void ValidateEndObject(){} // RVA: 0x5FA7D40
        public void ValidateEndArray(){} // RVA: 0x5FA8130
        public void ValidateNull(){} // RVA: 0x5FA8360
        public void ValidateBoolean(){} // RVA: 0x5FA83A0
        public void ValidateString(){} // RVA: 0x5FA83E0
        public void ValidateInteger(){} // RVA: 0x5FA87E0
        public void ProcessValue(){} // RVA: 0x5FA8FE0
        public void ValidateFloat(){} // RVA: 0x5FA9300
        public void FloatingPointRemainder(){} // RVA: 0x5FA98D0
        public void IsZero(){} // RVA: 0x5FA9940
        public void ValidatePropertyName(){} // RVA: 0x5FA99B0
        public void IsPropertyDefinied(){} // RVA: 0x5FA9C10
        public void ValidateArray(){} // RVA: 0x5FA9E30
        public void ValidateObject(){} // RVA: 0x5FA9E50
        public void TestType(){} // RVA: 0x5FA9E70
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x5FA9FC0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x5FAA020
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x5FAA080
        public void .cctor(){} // RVA: 0x5FAA0E0
    }

    public class JsonWriter
    {
        // ── Methods ──
        public void AutoCompleteAsync(){} // RVA: 0x5FAB060 | overloaded x2
        public void CloseAsync(){} // RVA: 0x5FAB270
        public void FlushAsync(){} // RVA: 0x5FAB350
        public void WriteEndAsync(){} // RVA: 0x5FAB8C0 | overloaded x2
        public void WriteIndentAsync(){} // RVA: 0x5FAB520
        public void WriteValueDelimiterAsync(){} // RVA: 0x5FAB600
        public void WriteIndentSpaceAsync(){} // RVA: 0x5FAB6E0
        public void WriteRawAsync(){} // RVA: 0x5FAB7C0
        public void WriteEndInternalAsync(){} // RVA: 0x5FAB9A0
        public void InternalWriteEndAsync(){} // RVA: 0x5FABB40
        public void WriteEndArrayAsync(){} // RVA: 0x5FABDC0
        public void WriteEndConstructorAsync(){} // RVA: 0x5FABEA0
        public void WriteEndObjectAsync(){} // RVA: 0x5FABF80
        public void WriteNullAsync(){} // RVA: 0x5FAC060
        public void WritePropertyNameAsync(){} // RVA: 0x5FAC240 | overloaded x2
        public void InternalWritePropertyNameAsync(){} // RVA: 0x5FAC340
        public void WriteStartArrayAsync(){} // RVA: 0x5FAC460
        public void InternalWriteStartAsync(){} // RVA: 0x5FAC540
        public void WriteCommentAsync(){} // RVA: 0x5FAC780
        public void InternalWriteCommentAsync(){} // RVA: 0x5FAC880
        public void WriteRawValueAsync(){} // RVA: 0x5FAC890
        public void WriteStartConstructorAsync(){} // RVA: 0x5FAC990
        public void WriteStartObjectAsync(){} // RVA: 0x5FACA90
        public void WriteTokenAsync(){} // RVA: 0x5FAD7E0 | overloaded x5
        public void WriteTokenSyncReadingAsync(){} // RVA: 0x5FADA70
        public void WriteConstructorDateAsync(){} // RVA: 0x5FADCF0
        public void WriteValueAsync(){} // RVA: 0x5FB0AE0 | overloaded x39
        public void WriteUndefinedAsync(){} // RVA: 0x5FB0550
        public void WriteWhitespaceAsync(){} // RVA: 0x5FB0630
        public void InternalWriteValueAsync(){} // RVA: 0x5FB0730
        public void SetWriteStateAsync(){} // RVA: 0x5FB0800
        public void BuildStateArray(){} // RVA: 0x5FB1E60
        public void .cctor(){} // RVA: 0x5FB2120
        public void get_CloseOutput(){} // RVA: 0x4A6500
        public void set_CloseOutput(){} // RVA: 0x4A78C0
        public void get_AutoCompleteOnClose(){} // RVA: 0x4A7410
        public void set_AutoCompleteOnClose(){} // RVA: 0x4A7670
        public void get_Top(){} // RVA: 0x5FB24B0
        public void get_WriteState(){} // RVA: 0x5FB2510
        public void get_ContainerPath(){} // RVA: 0x5FB2630
        public void get_Path(){} // RVA: 0x5FB26D0
        public void get_Formatting(){} // RVA: 0x4C6670
        public void set_Formatting(){} // RVA: 0x5FB2850
        public void get_DateFormatHandling(){} // RVA: 0x891AF0
        public void set_DateFormatHandling(){} // RVA: 0x5FB28C0
        public void get_DateTimeZoneHandling(){} // RVA: 0x37E080
        public void set_DateTimeZoneHandling(){} // RVA: 0x5FB2930
        public void get_StringEscapeHandling(){} // RVA: 0x37E0A0
        public void set_StringEscapeHandling(){} // RVA: 0x5FB29A0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x2DD310
        public void get_FloatFormatHandling(){} // RVA: 0x37E0C0
        public void set_FloatFormatHandling(){} // RVA: 0x5FB2A20
        public void get_DateFormatString(){} // RVA: 0x37E0E0
        public void set_DateFormatString(){} // RVA: 0x4354D0
        public void get_Culture(){} // RVA: 0x5FB2A90
        public void set_Culture(){} // RVA: 0x3A5510
        public void .ctor(){} // RVA: 0x5FB2AF0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x5FB2B10
        public void Push(){} // RVA: 0x5FB2B20
        public void Pop(){} // RVA: 0x5FB2CD0
        public void Peek(){} // RVA: 0x5BED50
        public void Flush(){} // RVA: 0x24A50
        public void Close(){} // RVA: 0x5FB2E40
        public void WriteStartObject(){} // RVA: 0x5FB2EB0
        public void WriteEndObject(){} // RVA: 0x5FB2EF0
        public void WriteStartArray(){} // RVA: 0x5FB2F00
        public void WriteEndArray(){} // RVA: 0x5FB2F40
        public void WriteStartConstructor(){} // RVA: 0x5FB2F50
        public void WriteEndConstructor(){} // RVA: 0x5FB2F90
        public void WritePropertyName(){} // RVA: 0x5FB3010 | overloaded x2
        public void WriteEnd(){} // RVA: 0x2DD310 | overloaded x3
        public void WriteToken(){} // RVA: 0x5FB3D10 | overloaded x5
        public void IsWriteTokenIncomplete(){} // RVA: 0x5FB3FF0
        public void CalculateWriteTokenInitialDepth(){} // RVA: 0x5FB40C0
        public void CalculateWriteTokenFinalDepth(){} // RVA: 0x5FB4130
        public void WriteConstructorDate(){} // RVA: 0x5FB41A0
        public void AutoCompleteAll(){} // RVA: 0x5FB4350
        public void GetCloseTokenForType(){} // RVA: 0x5FB43C0
        public void AutoCompleteClose(){} // RVA: 0x5FB4480
        public void CalculateLevelsToComplete(){} // RVA: 0x5FB4540
        public void UpdateCurrentState(){} // RVA: 0x5FB4670
        public void WriteIndent(){} // RVA: 0x2DD310
        public void WriteValueDelimiter(){} // RVA: 0x2DD310
        public void WriteIndentSpace(){} // RVA: 0x2DD310
        public void AutoComplete(){} // RVA: 0x5FB4740
        public void WriteNull(){} // RVA: 0x5FB4970
        public void WriteUndefined(){} // RVA: 0x5FB4990
        public void WriteRaw(){} // RVA: 0x2DD310
        public void WriteRawValue(){} // RVA: 0x5FB49B0
        public void WriteValue(){} // RVA: 0x5FB5720 | overloaded x39
        public void WriteComment(){} // RVA: 0x5FB5660
        public void WriteWhitespace(){} // RVA: 0x5FB5670
        public void System.IDisposable.Dispose(){} // RVA: 0x5FB5680
        public void Dispose(){} // RVA: 0x5FB56F0
        public void ResolveConvertibleValue(){} // RVA: 0x5FB6A40
        public void CreateUnsupportedTypeException(){} // RVA: 0x5FB6CA0
        public void SetWriteState(){} // RVA: 0x5FB6DA0
        public void InternalWriteEnd(){} // RVA: 0x5FB4480
        public void InternalWritePropertyName(){} // RVA: 0x5FB2FA0
        public void InternalWriteRaw(){} // RVA: 0x2DD310
        public void InternalWriteStart(){} // RVA: 0x5FB7040
        public void InternalWriteValue(){} // RVA: 0x5FB7080
        public void InternalWriteWhitespace(){} // RVA: 0x5FB70A0
        public void InternalWriteComment(){} // RVA: 0x5FB5660
        public void <InternalWriteEndAsync>g__AwaitProperty|11_0(){} // RVA: 0x5FB71A0
        public void <InternalWriteEndAsync>g__AwaitIndent|11_1(){} // RVA: 0x5FB7430
        public void <InternalWriteEndAsync>g__AwaitEnd|11_2(){} // RVA: 0x5FB76D0
        public void <InternalWriteEndAsync>g__AwaitRemaining|11_3(){} // RVA: 0x5FB7950
    }

    public class JsonWriterException
    {
        // ── Methods ──
        public void get_Path(){} // RVA: 0x796DE0
        public void .ctor(){} // RVA: 0x5FBB4F0 | overloaded x5
        public void Create(){} // RVA: 0x5FBB690 | overloaded x2
    }

}