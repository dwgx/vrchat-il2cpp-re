// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 30
// Methods: 1041

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable : JsonNameTable
    {
        public int HashCodeRandomizer;
        public int _count; // 0x10
        public Entry[] _entries; // 0x18
        public int _mask; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC86E94E0
        public void .ctor(){} // RVA: 0x7FFAC86E9520
        public void Get(){} // RVA: 0x7FFAC86E95C0
        public void Add(){} // RVA: 0x7FFAC86E97B0
        public void AddEntry(){} // RVA: 0x7FFAC86E99F0
        public void Grow(){} // RVA: 0x7FFAC86E9D20
        public void TextEquals(){} // RVA: 0x7FFAC86E9EC0
    }

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
        public bool AllowNullItems; // 0x68

        // ── Methods ──
        public void get_AllowNullItems(){} // RVA: 0x7FFAC2FE9570
        public void set_AllowNullItems(){} // RVA: 0x7FFAC2FE9580
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
    }

    public class JsonConstructorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonContainerAttribute : Attribute
    {
        public string Id; // 0x10
        public string Title; // 0x18
        public string Description; // 0x20
        public System.Type ItemConverterType; // 0x28
        public object[] ItemConverterParameters; // 0x30
        public Newtonsoft.Json.Serialization.NamingStrategy NamingStrategyType; // 0x38
        public System.Nullable`1<bool> NamingStrategyParameters; // 0x40
        public System.Nullable`1<bool> NamingStrategyInstance; // 0x42
        public System.Nullable`1<0x6B1C5A80> IsReference; // 0x44
        public System.Nullable`1<0x6B1C5BE0> ItemIsReference; // 0x4C
        public System.Type ItemReferenceLoopHandling; // 0x58
        public object[] ItemTypeNameHandling; // 0x60

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC2F3C380
        public void set_Id(){} // RVA: 0x7FFAC2F22E30
        public void get_Title(){} // RVA: 0x7FFAC2F247C0
        public void set_Title(){} // RVA: 0x7FFAC2F87E80
        public void get_Description(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Description(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ItemConverterType(){} // RVA: 0x7FFAC2F4F130
        public void set_ItemConverterType(){} // RVA: 0x7FFAC2F22E90
        public void get_ItemConverterParameters(){} // RVA: 0x7FFAC31D95E0
        public void set_ItemConverterParameters(){} // RVA: 0x7FFAC2F4F890
        public void get_NamingStrategyType(){} // RVA: 0x7FFAC2FE9500
        public void set_NamingStrategyType(){} // RVA: 0x7FFAC86EA010
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFAC2FBF370
        public void set_NamingStrategyParameters(){} // RVA: 0x7FFAC86EA0C0
        public void get_NamingStrategyInstance(){} // RVA: 0x7FFAC31D0140
        public void set_NamingStrategyInstance(){} // RVA: 0x7FFAC31D0C20
        public void get_IsReference(){} // RVA: 0x7FFAC86EA170
        public void set_IsReference(){} // RVA: 0x7FFAC86EA1B0
        public void get_ItemIsReference(){} // RVA: 0x7FFAC86EA200
        public void set_ItemIsReference(){} // RVA: 0x7FFAC86EA240
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC86EA290
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC86EA2D0
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFAC86EA330
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFAC86EA370
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
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
        public void get_DefaultSettings(){} // RVA: 0x7FFAC86EA3D0
        public void set_DefaultSettings(){} // RVA: 0x7FFAC86EA430
        public void ToString(){} // RVA: 0x7FFAC86ECA90 | overloaded x30
        public void ToStringInternal(){} // RVA: 0x7FFAC86EB120
        public void EnsureFloatFormat(){} // RVA: 0x7FFAC86EB600
        public void EnsureDecimalPlace(){} // RVA: 0x7FFAC86EBBB0 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFAC86EE550 | overloaded x8
        public void SerializeObjectInternal(){} // RVA: 0x7FFAC86EE620
        public void DeserializeObject(){} // RVA: 0x7FFAC86EEB10 | overloaded x8
        public void DeserializeAnonymousType(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void PopulateObject(){} // RVA: 0x7FFAC86EED90 | overloaded x2
        public void SerializeXmlNode(){} // RVA: 0x7FFAC86EF1D0 | overloaded x3
        public void DeserializeXmlNode(){} // RVA: 0x7FFAC86EF4E0 | overloaded x4
        public void SerializeXNode(){} // RVA: 0x7FFAC86EF9D0 | overloaded x3
        public void DeserializeXNode(){} // RVA: 0x7FFAC86EFCE0 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFAC86EFF30
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
        public void .ctor(){} // RVA: 0x7FFAC86F03E0 | overloaded x2
    }

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86F0540
    }

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ReadJson(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86F06A0 | overloaded x4
        public void Create(){} // RVA: 0x7FFAC86F0720
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        public bool WriteData; // 0x10
        public bool ReadData; // 0x11

        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7FFAC2FEB5E0
        public void set_WriteData(){} // RVA: 0x7FFAC2FEB5F0
        public void get_ReadData(){} // RVA: 0x7FFAC3771DA0
        public void set_ReadData(){} // RVA: 0x7FFAC3771D90
        public void .ctor(){} // RVA: 0x7FFAC37C9980
    }

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonNameTable : Object
    {
        // ── Methods ──
        public void Get(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public 0x6B1C5870 MemberSerialization; // 0x68
        public System.Nullable`1<0x6B1C5920> MissingMemberHandling; // 0x6C
        public System.Nullable`1<0x6B1C5AD8> ItemNullValueHandling; // 0x74
        public System.Nullable`1<0x6B1C5978> ItemRequired; // 0x7C

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFAC47BAB50
        public void set_MemberSerialization(){} // RVA: 0x7FFAC47BAB60
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAC86F0800
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC86F0840
        public void get_ItemNullValueHandling(){} // RVA: 0x7FFAC86F08A0
        public void set_ItemNullValueHandling(){} // RVA: 0x7FFAC86F08F0
        public void get_ItemRequired(){} // RVA: 0x7FFAC86F0950
        public void set_ItemRequired(){} // RVA: 0x7FFAC86F0990
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
    }

    public class JsonPosition : ValueType
    {
        public char[] SpecialCharacters;
        public 0x6B1C3820 Type; // 0x10
        public int Position; // 0x14
        public string PropertyName; // 0x18
        public bool HasIndex; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86F09F0
        public void CalculateLength(){} // RVA: 0x7FFAC86F0AB0
        public void WriteTo(){} // RVA: 0x7FFAC86F0B50
        public void TypeHasIndex(){} // RVA: 0x7FFAC86F0D80
        public void BuildPath(){} // RVA: 0x7FFAC86F0D90
        public void FormatMessage(){} // RVA: 0x7FFAC86F1390
        public void .cctor(){} // RVA: 0x7FFAC86F1700
    }

    public class JsonPropertyAttribute : Attribute
    {
        public System.Nullable`1<0x6B1C5978> ItemConverterType; // 0x10
        public System.Nullable`1<0x6B1C3140> ItemConverterParameters; // 0x18
        public System.Nullable`1<0x6B1C5A80> NamingStrategyType; // 0x20
        public System.Nullable`1<0x6B1C59D0> NamingStrategyParameters; // 0x28
        public System.Nullable`1<0x6B1C5BE0> NullValueHandling; // 0x30
        public System.Nullable`1<bool> DefaultValueHandling; // 0x38
        public System.Nullable`1<int> ReferenceLoopHandling; // 0x3C
        public System.Nullable`1<0x6B1C5AD8> ObjectCreationHandling; // 0x44
        public System.Nullable`1<bool> TypeNameHandling; // 0x4C
        public System.Nullable`1<0x6B1C5A80> IsReference; // 0x50
        public System.Nullable`1<0x6B1C5BE0> Order; // 0x58
        public System.Type Required; // 0x60
        public object[] PropertyName; // 0x68
        public System.Type ItemReferenceLoopHandling; // 0x70
        public object[] ItemTypeNameHandling; // 0x78
        public string ItemIsReference; // 0x80

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFAC2FBF370
        public void set_ItemConverterType(){} // RVA: 0x7FFAC2FBF380
        public void get_ItemConverterParameters(){} // RVA: 0x7FFAC2F9CD50
        public void set_ItemConverterParameters(){} // RVA: 0x7FFAC2F9CD60
        public void get_NamingStrategyType(){} // RVA: 0x7FFAC2FE9590
        public void set_NamingStrategyType(){} // RVA: 0x7FFAC2FE95A0
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFAC30E5600
        public void set_NamingStrategyParameters(){} // RVA: 0x7FFAC30E06F0
        public void get_NullValueHandling(){} // RVA: 0x7FFAC86F17E0
        public void set_NullValueHandling(){} // RVA: 0x7FFAC86F1820
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC86F1880
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC86F18C0
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC86F1920
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC86F1960
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC86F19C0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC86F1A00
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC86F1A60
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC86F1AA0
        public void get_IsReference(){} // RVA: 0x7FFAC86F1B00
        public void set_IsReference(){} // RVA: 0x7FFAC86F1B40
        public void get_Order(){} // RVA: 0x7FFAC86F1B90
        public void set_Order(){} // RVA: 0x7FFAC86F1BD0
        public void get_Required(){} // RVA: 0x7FFAC86F1C30
        public void set_Required(){} // RVA: 0x7FFAC86F1C70
        public void get_PropertyName(){} // RVA: 0x7FFAC32EF410
        public void set_PropertyName(){} // RVA: 0x7FFAC34D4AA0
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC86F1CD0
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC86F1D10
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFAC86F1D70
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFAC86F1DB0
        public void get_ItemIsReference(){} // RVA: 0x7FFAC86F1E10
        public void set_ItemIsReference(){} // RVA: 0x7FFAC86F1E50
        public void .ctor(){} // RVA: 0x7FFAC34D4AA0 | overloaded x2
    }

    public class JsonReader : Object
    {
        public 0x6B1C5298 CurrentState; // 0x10
        public object CloseInput; // 0x18
        public char SupportMultipleContent; // 0x20
        public 0x6B1C3928 QuoteChar; // 0x24
        public Newtonsoft.Json.JsonPosition DateTimeZoneHandling; // 0x28
        public System.Globalization.CultureInfo DateParseHandling; // 0x40
        public 0x6B1C3038 FloatParseHandling; // 0x48
        public System.Nullable`1<int> DateFormatString; // 0x4C
        public bool MaxDepth; // 0x54
        public 0x6B1C2FE0 TokenType; // 0x58
        public 0x6B1C31F0 Value; // 0x5C
        public string ValueType; // 0x60
        public System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition> Depth; // 0x68
        public bool Path; // 0x70
        public bool Culture; // 0x71

        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x7FFAC86F1EA0
        public void SkipAsync(){} // RVA: 0x7FFAC86F2060
        public void ReaderReadAndAssertAsync(){} // RVA: 0x7FFAC86F2270
        public void ReadAsBooleanAsync(){} // RVA: 0x7FFAC86F2480
        public void ReadAsBytesAsync(){} // RVA: 0x7FFAC86F2620
        public void ReadArrayIntoByteArrayAsync(){} // RVA: 0x7FFAC86F2730
        public void ReadAsDateTimeAsync(){} // RVA: 0x7FFAC86F2920
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x7FFAC86F2B30
        public void ReadAsDecimalAsync(){} // RVA: 0x7FFAC86F2D50
        public void ReadAsDoubleAsync(){} // RVA: 0x7FFAC86F2F70
        public void ReadAsInt32Async(){} // RVA: 0x7FFAC86F30A0
        public void ReadAsStringAsync(){} // RVA: 0x7FFAC86F3240
        public void ReadAndMoveToContentAsync(){} // RVA: 0x7FFAC86F3310
        public void MoveToContentAsync(){} // RVA: 0x7FFAC86F3500
        public void MoveToContentFromNonContentAsync(){} // RVA: 0x7FFAC86F35A0
        public void get_CurrentState(){} // RVA: 0x7FFAC3921980
        public void get_CloseInput(){} // RVA: 0x7FFAC2F9D320
        public void set_CloseInput(){} // RVA: 0x7FFAC2F9D330
        public void get_SupportMultipleContent(){} // RVA: 0x7FFAC82464C0
        public void set_SupportMultipleContent(){} // RVA: 0x7FFAC82464D0
        public void get_QuoteChar(){} // RVA: 0x7FFAC6D68C80
        public void set_QuoteChar(){} // RVA: 0x7FFAC8258410
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC2FC20C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC86F3790
        public void get_DateParseHandling(){} // RVA: 0x7FFAC362EA40
        public void set_DateParseHandling(){} // RVA: 0x7FFAC86F3800
        public void get_FloatParseHandling(){} // RVA: 0x7FFAC313CBA0
        public void set_FloatParseHandling(){} // RVA: 0x7FFAC86F3870
        public void get_DateFormatString(){} // RVA: 0x7FFAC2FBF370
        public void set_DateFormatString(){} // RVA: 0x7FFAC2FBF380
        public void get_MaxDepth(){} // RVA: 0x7FFAC5FE03C0
        public void set_MaxDepth(){} // RVA: 0x7FFAC86F38E0
        public void get_TokenType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void get_ValueType(){} // RVA: 0x7FFAC86F39A0
        public void get_Depth(){} // RVA: 0x7FFAC86F39C0
        public void get_Path(){} // RVA: 0x7FFAC86F3A30
        public void get_Culture(){} // RVA: 0x7FFAC86F3BB0
        public void set_Culture(){} // RVA: 0x7FFAC2F49200
        public void GetPosition(){} // RVA: 0x7FFAC86F3C10
        public void .ctor(){} // RVA: 0x7FFAC86F3CD0
        public void Push(){} // RVA: 0x7FFAC86F3D40
        public void Pop(){} // RVA: 0x7FFAC86F4090
        public void Peek(){} // RVA: 0x7FFAC32EC4C0
        public void Read(){} // RVA: 0x7FFAC2C59D00
        public void ReadAsInt32(){} // RVA: 0x7FFAC86F4240
        public void ReadInt32String(){} // RVA: 0x7FFAC86F4690
        public void ReadAsString(){} // RVA: 0x7FFAC86F4A20
        public void ReadAsBytes(){} // RVA: 0x7FFAC86F4CD0
        public void ReadArrayIntoByteArray(){} // RVA: 0x7FFAC86F52F0
        public void ReadArrayElementIntoByteArrayReportDone(){} // RVA: 0x7FFAC86F54F0
        public void ReadAsDouble(){} // RVA: 0x7FFAC86F56F0
        public void ReadDoubleString(){} // RVA: 0x7FFAC86F5AB0
        public void ReadAsBoolean(){} // RVA: 0x7FFAC86F5DF0
        public void ReadBooleanString(){} // RVA: 0x7FFAC86F6250
        public void ReadAsDecimal(){} // RVA: 0x7FFAC86F6630
        public void ReadDecimalString(){} // RVA: 0x7FFAC86F6AE0
        public void ReadAsDateTime(){} // RVA: 0x7FFAC86F6FA0
        public void ReadDateTimeString(){} // RVA: 0x7FFAC86F7300
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC86F7740
        public void ReadDateTimeOffsetString(){} // RVA: 0x7FFAC86F7A80
        public void ReaderReadAndAssert(){} // RVA: 0x7FFAC86F7EB0
        public void CreateUnexpectedEndException(){} // RVA: 0x7FFAC86F7F00
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7FFAC86F7F50
        public void Skip(){} // RVA: 0x7FFAC86F8320
        public void SetToken(){} // RVA: 0x7FFAC86F8420 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x7FFAC86F8650
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFAC86F8680
        public void ValidateEnd(){} // RVA: 0x7FFAC86F8690
        public void SetStateBasedOnCurrent(){} // RVA: 0x7FFAC86F8850
        public void SetFinished(){} // RVA: 0x7FFAC86F8960
        public void GetTypeForCloseToken(){} // RVA: 0x7FFAC86F8980
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC86F8A70
        public void Dispose(){} // RVA: 0x7FFAC86F8AE0
        public void Close(){} // RVA: 0x7FFAC86F8B10
        public void ReadAndAssert(){} // RVA: 0x7FFAC86F8B70
        public void ReadForTypeAndAssert(){} // RVA: 0x7FFAC86F8BD0
        public void ReadForType(){} // RVA: 0x7FFAC86F8C20
        public void ReadAndMoveToContent(){} // RVA: 0x7FFAC86F8EE0
        public void MoveToContent(){} // RVA: 0x7FFAC86F8F40
        public void GetContentToken(){} // RVA: 0x7FFAC86F8FA0
    }

    public class JsonReaderException : JsonException
    {
        public int LineNumber; // 0x90
        public int LinePosition; // 0x94
        public string Path; // 0x98

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFAC3220660
        public void get_LinePosition(){} // RVA: 0x7FFAC3220670
        public void get_Path(){} // RVA: 0x7FFAC354DFB0
        public void .ctor(){} // RVA: 0x7FFAC86FA8D0 | overloaded x5
        public void Create(){} // RVA: 0x7FFAC86FAB60 | overloaded x3
    }

    public class JsonRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonSerializationException : JsonException
    {
        public int LineNumber; // 0x90
        public int LinePosition; // 0x94
        public string Path; // 0x98

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFAC3220660
        public void get_LinePosition(){} // RVA: 0x7FFAC3220670
        public void get_Path(){} // RVA: 0x7FFAC354DFB0
        public void .ctor(){} // RVA: 0x7FFAC86FA8D0 | overloaded x5
        public void Create(){} // RVA: 0x7FFAC86FAE20 | overloaded x3
    }

    public class JsonSerializer : Object
    {
        public 0x6B1C5BE0 ReferenceResolver; // 0x10
        public 0x6B1C5B88 Binder; // 0x14
        public 0x6B1C5A28 SerializationBinder; // 0x18
        public 0x6B1C5A80 TraceWriter; // 0x1C
        public 0x6B1C5920 EqualityComparer; // 0x20
        public 0x6B1C59D0 TypeNameHandling; // 0x24
        public 0x6B1C5978 TypeNameAssemblyFormat; // 0x28
        public 0x6B1C3140 TypeNameAssemblyFormatHandling; // 0x2C
        public 0x6B1C2F30 PreserveReferencesHandling; // 0x30
        public 0x6B1C58C8 ReferenceLoopHandling; // 0x34
        public Newtonsoft.Json.JsonConverterCollection MissingMemberHandling; // 0x38
        public Newtonsoft.Json.Serialization.IContractResolver NullValueHandling; // 0x40
        public Newtonsoft.Json.Serialization.ITraceWriter DefaultValueHandling; // 0x48
        public System.Collections.IEqualityComparer ObjectCreationHandling; // 0x50
        public Newtonsoft.Json.Serialization.ISerializationBinder ConstructorHandling; // 0x58
        public System.Runtime.Serialization.StreamingContext MetadataPropertyHandling; // 0x60
        public Newtonsoft.Json.Serialization.IReferenceResolver Converters; // 0x70
        public System.Nullable`1<0x6B1C3248> ContractResolver; // 0x78
        public System.Nullable`1<0x6B1C2F88> Context; // 0x80
        public System.Nullable`1<0x6B1C3038> Formatting; // 0x88
        public System.Nullable`1<0x6B1C2FE0> DateFormatHandling; // 0x90
        public System.Nullable`1<0x6B1C3198> DateTimeZoneHandling; // 0x98
        public System.Nullable`1<0x6B1C31F0> DateParseHandling; // 0xA0
        public System.Nullable`1<0x6B1C5B30> FloatParseHandling; // 0xA8
        public System.Globalization.CultureInfo FloatFormatHandling; // 0xB0
        public System.Nullable`1<int> StringEscapeHandling; // 0xB8
        public bool DateFormatString; // 0xC0
        public System.Nullable`1<bool> Culture; // 0xC1
        public string MaxDepth; // 0xC8
        public bool CheckAdditionalContent; // 0xD0
        public System.EventHandler`1<Newtonsoft.Json.Serialization.ErrorEventArgs> Error; // 0xD8

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFAC86FAFA0
        public void remove_Error(){} // RVA: 0x7FFAC86FB0A0
        public void get_ReferenceResolver(){} // RVA: 0x7FFAC86FB1A0
        public void set_ReferenceResolver(){} // RVA: 0x7FFAC86FB1B0
        public void get_Binder(){} // RVA: 0x7FFAC86FB280
        public void set_Binder(){} // RVA: 0x7FFAC86FB3A0
        public void get_SerializationBinder(){} // RVA: 0x7FFAC2FE9500
        public void set_SerializationBinder(){} // RVA: 0x7FFAC86FB500
        public void get_TraceWriter(){} // RVA: 0x7FFAC2F9C730
        public void set_TraceWriter(){} // RVA: 0x7FFAC2F9C740
        public void get_EqualityComparer(){} // RVA: 0x7FFAC2FC20E0
        public void set_EqualityComparer(){} // RVA: 0x7FFAC30794D0
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC2F6E5C0
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC86FB5D0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC33D5A20
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC86FB640
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFAC33D5A20
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFAC86FB6B0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFAC3157800
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFAC86FB720
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC44357F0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC86FB790
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAC30DBBE0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC86FB800
        public void get_NullValueHandling(){} // RVA: 0x7FFAC32EC4C0
        public void set_NullValueHandling(){} // RVA: 0x7FFAC86FB870
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC3C891D0
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC86FB8E0
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC3921980
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC86FB950
        public void get_ConstructorHandling(){} // RVA: 0x7FFAC2F7CCD0
        public void set_ConstructorHandling(){} // RVA: 0x7FFAC86FB9C0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAC3ADEDC0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFAC86FBA30
        public void get_Converters(){} // RVA: 0x7FFAC86FBAA0
        public void get_ContractResolver(){} // RVA: 0x7FFAC2F9E740
        public void set_ContractResolver(){} // RVA: 0x7FFAC86FBB80
        public void get_Context(){} // RVA: 0x7FFAC5FD8A60
        public void set_Context(){} // RVA: 0x7FFAC86FBC40
        public void get_Formatting(){} // RVA: 0x7FFAC86FBCA0
        public void set_Formatting(){} // RVA: 0x7FFAC86FBCE0
        public void get_DateFormatHandling(){} // RVA: 0x7FFAC86FBD40
        public void set_DateFormatHandling(){} // RVA: 0x7FFAC86FBD90
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC86FBDF0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC86FBE50
        public void get_DateParseHandling(){} // RVA: 0x7FFAC86FBEB0
        public void set_DateParseHandling(){} // RVA: 0x7FFAC86FBF10
        public void get_FloatParseHandling(){} // RVA: 0x7FFAC86FBF70
        public void set_FloatParseHandling(){} // RVA: 0x7FFAC86FBFC0
        public void get_FloatFormatHandling(){} // RVA: 0x7FFAC86FC020
        public void set_FloatFormatHandling(){} // RVA: 0x7FFAC86FC070
        public void get_StringEscapeHandling(){} // RVA: 0x7FFAC86FC0D0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFAC86FC120
        public void get_DateFormatString(){} // RVA: 0x7FFAC86FC180
        public void set_DateFormatString(){} // RVA: 0x7FFAC86FC1D0
        public void get_Culture(){} // RVA: 0x7FFAC86FC240
        public void set_Culture(){} // RVA: 0x7FFAC2F8C050
        public void get_MaxDepth(){} // RVA: 0x7FFAC2F8C0B0
        public void set_MaxDepth(){} // RVA: 0x7FFAC86FC2B0
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFAC86FC380
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFAC86FC3D0
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFAC86FC430
        public void .ctor(){} // RVA: 0x7FFAC86FC480
        public void Create(){} // RVA: 0x7FFAC86FC770 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFAC86FC8E0 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFAC86FC920
        public void Populate(){} // RVA: 0x7FFAC86FD440 | overloaded x2
        public void PopulateInternal(){} // RVA: 0x7FFAC86FD460
        public void Deserialize(){} // RVA: 0x7FFAC86FD830 | overloaded x4
        public void DeserializeInternal(){} // RVA: 0x7FFAC86FD850
        public void SetupReader(){} // RVA: 0x7FFAC86FDB30
        public void ResetReader(){} // RVA: 0x7FFAC86FE0F0
        public void Serialize(){} // RVA: 0x7FFAC86FE550 | overloaded x4
        public void CreateTraceJsonReader(){} // RVA: 0x7FFAC86FE580
        public void SerializeInternal(){} // RVA: 0x7FFAC86FE640
        public void GetReferenceResolver(){} // RVA: 0x7FFAC86FEDE0
        public void GetMatchingConverter(){} // RVA: 0x7FFAC86FEE90 | overloaded x2
        public void OnError(){} // RVA: 0x7FFAC86FEF60
    }

    public class JsonSerializerSettings : Object
    {
        public 0x6B1C5A80 ReferenceLoopHandling;
        public 0x6B1C5920 MissingMemberHandling;
        public 0x6B1C5978 ObjectCreationHandling;
        public 0x6B1C3140 NullValueHandling;
        public 0x6B1C59D0 DefaultValueHandling;
        public 0x6B1C5A28 Converters;
        public 0x6B1C2F30 PreserveReferencesHandling;
        public 0x6B1C5BE0 TypeNameHandling;
        public 0x6B1C58C8 MetadataPropertyHandling;
        public System.Runtime.Serialization.StreamingContext TypeNameAssemblyFormat;
        public 0x6B1C3248 TypeNameAssemblyFormatHandling;
        public 0x6B1C2F88 ConstructorHandling;
        public 0x6B1C3038 ContractResolver;
        public 0x6B1C2FE0 EqualityComparer;
        public 0x6B1C31F0 ReferenceResolver;
        public 0x6B1C3198 ReferenceResolverProvider;
        public 0x6B1C5B30 TraceWriter;
        public 0x6B1C5B88 Binder;
        public System.Globalization.CultureInfo SerializationBinder; // 0x10
        public bool Error;
        public string Context;
        public int DateFormatString;
        public System.Nullable`1<0x6B1C3248> MaxDepth; // 0x10
        public System.Nullable`1<0x6B1C2F88> Formatting; // 0x18
        public System.Nullable`1<0x6B1C3038> DateFormatHandling; // 0x20
        public System.Nullable`1<0x6B1C2FE0> DateTimeZoneHandling; // 0x28
        public System.Nullable`1<0x6B1C3198> DateParseHandling; // 0x30
        public System.Nullable`1<0x6B1C31F0> FloatFormatHandling; // 0x38
        public System.Nullable`1<0x6B1C5B30> FloatParseHandling; // 0x40
        public System.Globalization.CultureInfo StringEscapeHandling; // 0x48
        public System.Nullable`1<bool> Culture; // 0x50
        public System.Nullable`1<int> CheckAdditionalContent; // 0x54
        public bool _maxDepthSet; // 0x5C
        public string _dateFormatString; // 0x60
        public bool _dateFormatStringSet; // 0x68
        public System.Nullable`1<0x6B1C5B88> _typeNameAssemblyFormatHandling; // 0x6C
        public System.Nullable`1<0x6B1C3140> _defaultValueHandling; // 0x74
        public System.Nullable`1<0x6B1C5A28> _preserveReferencesHandling; // 0x7C
        public System.Nullable`1<0x6B1C5978> _nullValueHandling; // 0x84
        public System.Nullable`1<0x6B1C59D0> _objectCreationHandling; // 0x8C
        public System.Nullable`1<0x6B1C5920> _missingMemberHandling; // 0x94
        public System.Nullable`1<0x6B1C5A80> _referenceLoopHandling; // 0x9C
        public System.Nullable`1<System.Runtime.Serialization.StreamingContext> _context; // 0xA8
        public System.Nullable`1<0x6B1C2F30> _constructorHandling; // 0xC0
        public System.Nullable`1<0x6B1C5BE0> _typeNameHandling; // 0xC8
        public System.Nullable`1<0x6B1C58C8> _metadataPropertyHandling; // 0xD0
        public System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter> <Converters>k__BackingField; // 0xD8
        public Newtonsoft.Json.Serialization.IContractResolver <ContractResolver>k__BackingField; // 0xE0
        public System.Collections.IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
        public System.Func`1<Newtonsoft.Json.Serialization.IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
        public Newtonsoft.Json.Serialization.ITraceWriter <TraceWriter>k__BackingField; // 0xF8
        public Newtonsoft.Json.Serialization.ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
        public System.EventHandler`1<Newtonsoft.Json.Serialization.ErrorEventArgs> <Error>k__BackingField; // 0x108

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC86FEF90
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC86FEFE0
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAC86FF040
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC86FF090
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC86FF0F0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC86FF140
        public void get_NullValueHandling(){} // RVA: 0x7FFAC86FF1A0
        public void set_NullValueHandling(){} // RVA: 0x7FFAC86FF1F0
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC86FF250
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC86FF290
        public void get_Converters(){} // RVA: 0x7FFAC3540F70
        public void set_Converters(){} // RVA: 0x7FFAC2FA28A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFAC86FF2F0
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFAC86FF340
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC86FF3A0
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC86FF3F0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAC86FF450
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFAC86FF4A0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC86FF500
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC86FF540
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFAC86FF500
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFAC86FF540
        public void get_ConstructorHandling(){} // RVA: 0x7FFAC86FF5A0
        public void set_ConstructorHandling(){} // RVA: 0x7FFAC86FF5F0
        public void get_ContractResolver(){} // RVA: 0x7FFAC2FA2900
        public void set_ContractResolver(){} // RVA: 0x7FFAC2FA2910
        public void get_EqualityComparer(){} // RVA: 0x7FFAC2FA2970
        public void set_EqualityComparer(){} // RVA: 0x7FFAC2FA2980
        public void get_ReferenceResolver(){} // RVA: 0x7FFAC86FF650
        public void set_ReferenceResolver(){} // RVA: 0x7FFAC86FF670
        public void get_ReferenceResolverProvider(){} // RVA: 0x7FFAC2F8C2A0
        public void set_ReferenceResolverProvider(){} // RVA: 0x7FFAC2F8C2B0
        public void get_TraceWriter(){} // RVA: 0x7FFAC3331F50
        public void set_TraceWriter(){} // RVA: 0x7FFAC34A4860
        public void get_Binder(){} // RVA: 0x7FFAC86FF800
        public void set_Binder(){} // RVA: 0x7FFAC86FF8E0
        public void get_SerializationBinder(){} // RVA: 0x7FFAC34F6C80
        public void set_SerializationBinder(){} // RVA: 0x7FFAC34F6750
        public void get_Error(){} // RVA: 0x7FFAC36D1F40
        public void set_Error(){} // RVA: 0x7FFAC3929BF0
        public void get_Context(){} // RVA: 0x7FFAC86FFA00
        public void set_Context(){} // RVA: 0x7FFAC86FFAD0
        public void get_DateFormatString(){} // RVA: 0x7FFAC86FFBF0
        public void set_DateFormatString(){} // RVA: 0x7FFAC86FFC40
        public void get_MaxDepth(){} // RVA: 0x7FFAC86FFCA0
        public void set_MaxDepth(){} // RVA: 0x7FFAC86FFD00
        public void get_Formatting(){} // RVA: 0x7FFAC86FFDC0
        public void set_Formatting(){} // RVA: 0x7FFAC86FFE00
        public void get_DateFormatHandling(){} // RVA: 0x7FFAC86FFE60
        public void set_DateFormatHandling(){} // RVA: 0x7FFAC86FFEA0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC86FFF00
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC86FFF60
        public void get_DateParseHandling(){} // RVA: 0x7FFAC86FFFC0
        public void set_DateParseHandling(){} // RVA: 0x7FFAC8700020
        public void get_FloatFormatHandling(){} // RVA: 0x7FFAC8700080
        public void set_FloatFormatHandling(){} // RVA: 0x7FFAC87000C0
        public void get_FloatParseHandling(){} // RVA: 0x7FFAC8700120
        public void set_FloatParseHandling(){} // RVA: 0x7FFAC8700160
        public void get_StringEscapeHandling(){} // RVA: 0x7FFAC87001C0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFAC8700200
        public void get_Culture(){} // RVA: 0x7FFAC8700260
        public void set_Culture(){} // RVA: 0x7FFAC2F9C740
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFAC87002D0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFAC8700310
        public void .cctor(){} // RVA: 0x7FFAC8700360
        public void .ctor(){} // RVA: 0x7FFAC8700540 | overloaded x2
    }

    public class JsonTextReader : JsonReader
    {
        public bool PropertyNameTable; // 0x78
        public char ArrayPool;
        public int LineNumber;
        public int LinePosition;
        public System.IO.TextReader _reader; // 0x80
        public char[] _chars; // 0x88
        public int _charsUsed; // 0x90
        public int _charPos; // 0x94
        public int _lineStartPos; // 0x98
        public int _lineNumber; // 0x9C
        public bool _isEndOfFile; // 0xA0
        public Newtonsoft.Json.Utilities.StringBuffer _stringBuffer; // 0xA8
        public Newtonsoft.Json.Utilities.StringReference _stringReference; // 0xB8
        public Newtonsoft.Json.IArrayPool`1<char> _arrayPool; // 0xC8
        public Newtonsoft.Json.JsonNameTable <PropertyNameTable>k__BackingField; // 0xD0

        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x7FFAC8700AB0
        public void DoReadAsync(){} // RVA: 0x7FFAC8700FA0 | overloaded x2
        public void ParsePostValueAsync(){} // RVA: 0x7FFAC87011F0
        public void ReadFromFinishedAsync(){} // RVA: 0x7FFAC8701400
        public void ReadDataAsync(){} // RVA: 0x7FFAC8701620 | overloaded x2
        public void ParseValueAsync(){} // RVA: 0x7FFAC8701840
        public void ReadStringIntoBufferAsync(){} // RVA: 0x7FFAC8701A40
        public void ProcessCarriageReturnAsync(){} // RVA: 0x7FFAC8701DD0 | overloaded x2
        public void ParseUnicodeAsync(){} // RVA: 0x7FFAC8701FE0
        public void EnsureCharsAsync(){} // RVA: 0x7FFAC87021D0
        public void ReadCharsAsync(){} // RVA: 0x7FFAC87022C0
        public void ParseObjectAsync(){} // RVA: 0x7FFAC87024E0
        public void ParseCommentAsync(){} // RVA: 0x7FFAC87026E0
        public void EatWhitespaceAsync(){} // RVA: 0x7FFAC8702930
        public void ParseStringAsync(){} // RVA: 0x7FFAC8702B40
        public void MatchValueAsync(){} // RVA: 0x7FFAC8702D80
        public void MatchValueWithTrailingSeparatorAsync(){} // RVA: 0x7FFAC8702FD0
        public void MatchAndSetAsync(){} // RVA: 0x7FFAC8703220
        public void ParseTrueAsync(){} // RVA: 0x7FFAC87034F0
        public void ParseFalseAsync(){} // RVA: 0x7FFAC87035B0
        public void ParseNullAsync(){} // RVA: 0x7FFAC8703700
        public void ParseConstructorAsync(){} // RVA: 0x7FFAC8703790
        public void ParseNumberNaNAsync(){} // RVA: 0x7FFAC87039B0
        public void ParseNumberPositiveInfinityAsync(){} // RVA: 0x7FFAC8703BB0
        public void ParseNumberNegativeInfinityAsync(){} // RVA: 0x7FFAC8703DB0
        public void ParseNumberAsync(){} // RVA: 0x7FFAC8703FB0
        public void ParseUndefinedAsync(){} // RVA: 0x7FFAC87041E0
        public void ParsePropertyAsync(){} // RVA: 0x7FFAC8704270
        public void ReadNumberIntoBufferAsync(){} // RVA: 0x7FFAC8704470
        public void ParseUnquotedPropertyAsync(){} // RVA: 0x7FFAC8704680
        public void ReadNullCharAsync(){} // RVA: 0x7FFAC8704890
        public void HandleNullAsync(){} // RVA: 0x7FFAC8704A80
        public void ReadFinishedAsync(){} // RVA: 0x7FFAC8704C90
        public void ReadStringValueAsync(){} // RVA: 0x7FFAC8704EA0
        public void ReadNumberValueAsync(){} // RVA: 0x7FFAC87050B0
        public void ReadAsBooleanAsync(){} // RVA: 0x7FFAC87052C0
        public void DoReadAsBooleanAsync(){} // RVA: 0x7FFAC87052E0
        public void ReadAsBytesAsync(){} // RVA: 0x7FFAC87054E0
        public void DoReadAsBytesAsync(){} // RVA: 0x7FFAC8705610
        public void ReadIntoWrappedTypeObjectAsync(){} // RVA: 0x7FFAC8705810
        public void ReadAsDateTimeAsync(){} // RVA: 0x7FFAC8705A20
        public void DoReadAsDateTimeAsync(){} // RVA: 0x7FFAC8705A40
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x7FFAC8705C30
        public void DoReadAsDateTimeOffsetAsync(){} // RVA: 0x7FFAC8705C50
        public void ReadAsDecimalAsync(){} // RVA: 0x7FFAC8705E40
        public void DoReadAsDecimalAsync(){} // RVA: 0x7FFAC8705E60
        public void ReadAsDoubleAsync(){} // RVA: 0x7FFAC8706050
        public void DoReadAsDoubleAsync(){} // RVA: 0x7FFAC8706190
        public void ReadAsInt32Async(){} // RVA: 0x7FFAC8706380
        public void DoReadAsInt32Async(){} // RVA: 0x7FFAC87063A0
        public void ReadAsStringAsync(){} // RVA: 0x7FFAC8706590
        public void DoReadAsStringAsync(){} // RVA: 0x7FFAC8706680
        public void .ctor(){} // RVA: 0x7FFAC8706870
        public void get_PropertyNameTable(){} // RVA: 0x7FFAC303E100
        public void set_PropertyNameTable(){} // RVA: 0x7FFAC303E110
        public void get_ArrayPool(){} // RVA: 0x7FFAC3079460
        public void set_ArrayPool(){} // RVA: 0x7FFAC8706A10
        public void EnsureBufferNotEmpty(){} // RVA: 0x7FFAC8706AC0
        public void SetNewLine(){} // RVA: 0x7FFAC8706C10
        public void OnNewLine(){} // RVA: 0x7FFAC8706C70
        public void ParseString(){} // RVA: 0x7FFAC8706C80
        public void ParseReadString(){} // RVA: 0x7FFAC8706CE0
        public void BlockCopyChars(){} // RVA: 0x7FFAC8707310
        public void ShiftBufferIfNeeded(){} // RVA: 0x7FFAC8707330
        public void ReadData(){} // RVA: 0x7FFAC8707770 | overloaded x2
        public void PrepareBufferForReadData(){} // RVA: 0x7FFAC8707420
        public void EnsureChars(){} // RVA: 0x7FFAC8707840
        public void ReadChars(){} // RVA: 0x7FFAC8707990
        public void Read(){} // RVA: 0x7FFAC8707AD0
        public void ReadAsInt32(){} // RVA: 0x7FFAC8707E50
        public void ReadAsDateTime(){} // RVA: 0x7FFAC8707F40
        public void ReadAsString(){} // RVA: 0x7FFAC8708030
        public void ReadAsBytes(){} // RVA: 0x7FFAC87080A0
        public void ReadStringValue(){} // RVA: 0x7FFAC8708800
        public void FinishReadQuotedStringValue(){} // RVA: 0x7FFAC87090E0
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFAC87093C0
        public void ReadAsBoolean(){} // RVA: 0x7FFAC87094D0
        public void ProcessValueComma(){} // RVA: 0x7FFAC8709F70
        public void ReadNumberValue(){} // RVA: 0x7FFAC8709FF0
        public void FinishReadQuotedNumber(){} // RVA: 0x7FFAC870A7E0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC870A990
        public void ReadAsDecimal(){} // RVA: 0x7FFAC870AA90
        public void ReadAsDouble(){} // RVA: 0x7FFAC870AB90
        public void HandleNull(){} // RVA: 0x7FFAC870AC80
        public void ReadFinished(){} // RVA: 0x7FFAC870AD90
        public void ReadNullChar(){} // RVA: 0x7FFAC870AF40
        public void EnsureBuffer(){} // RVA: 0x7FFAC870AF90
        public void ReadStringIntoBuffer(){} // RVA: 0x7FFAC870B0A0
        public void FinishReadStringIntoBuffer(){} // RVA: 0x7FFAC870B650
        public void WriteCharToBuffer(){} // RVA: 0x7FFAC870B880
        public void ConvertUnicode(){} // RVA: 0x7FFAC870B930
        public void ParseUnicode(){} // RVA: 0x7FFAC870BB60
        public void ReadNumberIntoBuffer(){} // RVA: 0x7FFAC870BB90
        public void ReadNumberCharIntoBuffer(){} // RVA: 0x7FFAC870BC10
        public void ClearRecentString(){} // RVA: 0x7FFAC870BDD0
        public void ParsePostValue(){} // RVA: 0x7FFAC870BDF0
        public void ParseObject(){} // RVA: 0x7FFAC870C280
        public void ParseProperty(){} // RVA: 0x7FFAC870C490
        public void ValidIdentifierChar(){} // RVA: 0x7FFAC870C9A0
        public void ParseUnquotedProperty(){} // RVA: 0x7FFAC870CA10
        public void ReadUnquotedPropertyReportIfDone(){} // RVA: 0x7FFAC870CBC0
        public void ParseValue(){} // RVA: 0x7FFAC870CDC0
        public void ProcessLineFeed(){} // RVA: 0x7FFAC870D9F0
        public void ProcessCarriageReturn(){} // RVA: 0x7FFAC870DA10
        public void EatWhitespace(){} // RVA: 0x7FFAC870DA80
        public void ParseConstructor(){} // RVA: 0x7FFAC870DBF0
        public void ParseNumber(){} // RVA: 0x7FFAC870E180
        public void ParseReadNumber(){} // RVA: 0x7FFAC870E280
        public void ThrowReaderError(){} // RVA: 0x7FFAC870F9C0
        public void BigIntegerParse(){} // RVA: 0x7FFAC870FA90
        public void ParseComment(){} // RVA: 0x7FFAC870FB70
        public void EndComment(){} // RVA: 0x7FFAC870FF10
        public void MatchValue(){} // RVA: 0x7FFAC8710020 | overloaded x2
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7FFAC8710110
        public void IsSeparator(){} // RVA: 0x7FFAC87101E0
        public void ParseTrue(){} // RVA: 0x7FFAC8710330
        public void ParseNull(){} // RVA: 0x7FFAC87104B0
        public void ParseUndefined(){} // RVA: 0x7FFAC87105F0
        public void ParseFalse(){} // RVA: 0x7FFAC8710730
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7FFAC8710930 | overloaded x2
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7FFAC8710CA0 | overloaded x2
        public void ParseNumberNaN(){} // RVA: 0x7FFAC8711010 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC8711300
        public void HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void get_LineNumber(){} // RVA: 0x7FFAC8711480
        public void get_LinePosition(){} // RVA: 0x7FFAC87114D0
    }

    public class JsonTextWriter : JsonWriter
    {
        public bool Base64Encoder; // 0x60
        public int ArrayPool;
        public System.IO.TextWriter Indentation; // 0x68
        public Newtonsoft.Json.Utilities.Base64Encoder QuoteChar; // 0x70
        public char IndentChar; // 0x78
        public int QuoteName; // 0x7C
        public char _quoteChar; // 0x80
        public bool _quoteName; // 0x82
        public bool[] _charEscapeFlags; // 0x88
        public char[] _writeBuffer; // 0x90
        public Newtonsoft.Json.IArrayPool`1<char> _arrayPool; // 0x98
        public char[] _indentChars; // 0xA0

        // ── Methods ──
        public void FlushAsync(){} // RVA: 0x7FFAC8725860
        public void DoFlushAsync(){} // RVA: 0x7FFAC87259C0
        public void WriteValueDelimiterAsync(){} // RVA: 0x7FFAC8725A50
        public void DoWriteValueDelimiterAsync(){} // RVA: 0x7FFAC8725B90
        public void WriteEndAsync(){} // RVA: 0x7FFAC8726460 | overloaded x2
        public void DoWriteEndAsync(){} // RVA: 0x7FFAC8725E60
        public void CloseAsync(){} // RVA: 0x7FFAC8725FA0
        public void DoCloseAsync(){} // RVA: 0x7FFAC87260A0
        public void CloseBufferAndWriterAsync(){} // RVA: 0x7FFAC87262B0
        public void WriteIndentAsync(){} // RVA: 0x7FFAC87269B0 | overloaded x2
        public void DoWriteIndentAsync(){} // RVA: 0x7FFAC87268A0
        public void WriteValueInternalAsync(){} // RVA: 0x7FFAC8726CD0 | overloaded x2
        public void WriteIndentSpaceAsync(){} // RVA: 0x7FFAC8726FA0
        public void DoWriteIndentSpaceAsync(){} // RVA: 0x7FFAC87270E0
        public void WriteRawAsync(){} // RVA: 0x7FFAC8727150
        public void DoWriteRawAsync(){} // RVA: 0x7FFAC87272B0
        public void WriteNullAsync(){} // RVA: 0x7FFAC8727330
        public void DoWriteNullAsync(){} // RVA: 0x7FFAC8727490
        public void WriteDigitsAsync(){} // RVA: 0x7FFAC8727510
        public void WriteIntegerValueAsync(){} // RVA: 0x7FFAC87279D0 | overloaded x4
        public void WriteEscapedStringAsync(){} // RVA: 0x7FFAC87279F0
        public void WritePropertyNameAsync(){} // RVA: 0x7FFAC8728160 | overloaded x2
        public void DoWritePropertyNameAsync(){} // RVA: 0x7FFAC8728270 | overloaded x3
        public void WriteStartArrayAsync(){} // RVA: 0x7FFAC8728500
        public void DoWriteStartArrayAsync(){} // RVA: 0x7FFAC8728790 | overloaded x2
        public void WriteStartObjectAsync(){} // RVA: 0x7FFAC8728A10
        public void DoWriteStartObjectAsync(){} // RVA: 0x7FFAC8728CA0 | overloaded x2
        public void WriteStartConstructorAsync(){} // RVA: 0x7FFAC8728F20
        public void DoWriteStartConstructorAsync(){} // RVA: 0x7FFAC8729030
        public void WriteUndefinedAsync(){} // RVA: 0x7FFAC87292B0
        public void DoWriteUndefinedAsync(){} // RVA: 0x7FFAC87295A0 | overloaded x2
        public void WriteWhitespaceAsync(){} // RVA: 0x7FFAC8729820
        public void DoWriteWhitespaceAsync(){} // RVA: 0x7FFAC8729980
        public void WriteValueAsync(){} // RVA: 0x7FFAC872F110 | overloaded x41
        public void DoWriteValueAsync(){} // RVA: 0x7FFAC872F290 | overloaded x24
        public void WriteValueNonNullAsync(){} // RVA: 0x7FFAC872A220
        public void WriteValueNotNullAsync(){} // RVA: 0x7FFAC872ED20 | overloaded x2
        public void WriteCommentAsync(){} // RVA: 0x7FFAC872F330
        public void DoWriteCommentAsync(){} // RVA: 0x7FFAC872F440
        public void WriteEndArrayAsync(){} // RVA: 0x7FFAC872F6C0
        public void WriteEndConstructorAsync(){} // RVA: 0x7FFAC872F7C0
        public void WriteEndObjectAsync(){} // RVA: 0x7FFAC872F8C0
        public void WriteRawValueAsync(){} // RVA: 0x7FFAC872F9C0
        public void DoWriteRawValueAsync(){} // RVA: 0x7FFAC872FC60 | overloaded x2
        public void EnsureWriteBuffer(){} // RVA: 0x7FFAC8733120 | overloaded x2
        public void get_Base64Encoder(){} // RVA: 0x7FFAC8730240
        public void get_ArrayPool(){} // RVA: 0x7FFAC354DFB0
        public void set_ArrayPool(){} // RVA: 0x7FFAC8730440
        public void get_Indentation(){} // RVA: 0x7FFAC4598F70
        public void set_Indentation(){} // RVA: 0x7FFAC87304F0
        public void get_QuoteChar(){} // RVA: 0x7FFAC8730560
        public void set_QuoteChar(){} // RVA: 0x7FFAC8730570
        public void get_IndentChar(){} // RVA: 0x7FFAC87305F0
        public void set_IndentChar(){} // RVA: 0x7FFAC8730600
        public void get_QuoteName(){} // RVA: 0x7FFAC3BDEE90
        public void set_QuoteName(){} // RVA: 0x7FFAC8730670
        public void .ctor(){} // RVA: 0x7FFAC8730680
        public void Flush(){} // RVA: 0x7FFAC84CBC50
        public void Close(){} // RVA: 0x7FFAC8730810
        public void CloseBufferAndWriter(){} // RVA: 0x7FFAC8730910
        public void WriteStartObject(){} // RVA: 0x7FFAC8730A00
        public void WriteStartArray(){} // RVA: 0x7FFAC8730A60
        public void WriteStartConstructor(){} // RVA: 0x7FFAC8730AC0
        public void WriteEnd(){} // RVA: 0x7FFAC8730B90
        public void WritePropertyName(){} // RVA: 0x7FFAC8730D40 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFAC8730E80
        public void UpdateCharEscapeFlags(){} // RVA: 0x7FFAC8730E90
        public void WriteIndent(){} // RVA: 0x7FFAC8730F60
        public void SetIndentChars(){} // RVA: 0x7FFAC87310D0
        public void WriteValueDelimiter(){} // RVA: 0x7FFAC8731290
        public void WriteIndentSpace(){} // RVA: 0x7FFAC87312C0
        public void WriteValueInternal(){} // RVA: 0x7FFAC87312F0
        public void WriteValue(){} // RVA: 0x7FFAC8732EF0 | overloaded x23
        public void WriteNull(){} // RVA: 0x7FFAC8731450
        public void WriteUndefined(){} // RVA: 0x7FFAC87314F0
        public void WriteRaw(){} // RVA: 0x7FFAC87312F0
        public void WriteEscapedString(){} // RVA: 0x7FFAC8731660
        public void WriteValueToBuffer(){} // RVA: 0x7FFAC87329B0 | overloaded x2
        public void WriteComment(){} // RVA: 0x7FFAC8733000
        public void WriteWhitespace(){} // RVA: 0x7FFAC87330D0
        public void WriteIntegerValue(){} // RVA: 0x7FFAC87334B0 | overloaded x4
        public void WriteNumberToBuffer(){} // RVA: 0x7FFAC8733540 | overloaded x2
    }

    public class JsonValidatingReader : JsonReader
    {
        public Newtonsoft.Json.JsonReader Value; // 0x78
        public System.Collections.Generic.Stack`1<SchemaScope> Depth; // 0x80
        public Newtonsoft.Json.Schema.JsonSchema Path; // 0x88
        public Newtonsoft.Json.Schema.JsonSchemaModel QuoteChar; // 0x90
        public SchemaScope TokenType; // 0x98
        public Newtonsoft.Json.Schema.ValidationEventHandler ValueType; // 0xA0
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel> CurrentSchemas;

        // ── Methods ──
        public void add_ValidationEventHandler(){} // RVA: 0x7FFAC873BB00
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFAC873BBF0
        public void get_Value(){} // RVA: 0x7FFAC873BCE0
        public void get_Depth(){} // RVA: 0x7FFAC873BD10
        public void get_Path(){} // RVA: 0x7FFAC873BD40
        public void get_QuoteChar(){} // RVA: 0x7FFAC873BD70
        public void set_QuoteChar(){} // RVA: 0x7FFAC2F21310
        public void get_TokenType(){} // RVA: 0x7FFAC873BDA0
        public void get_ValueType(){} // RVA: 0x7FFAC873BDD0
        public void Push(){} // RVA: 0x7FFAC873BE00
        public void Pop(){} // RVA: 0x7FFAC873BEC0
        public void get_CurrentSchemas(){} // RVA: 0x7FFAC873BFC0
        public void get_CurrentMemberSchemas(){} // RVA: 0x7FFAC873BFE0
        public void RaiseError(){} // RVA: 0x7FFAC873CAC0
        public void OnValidationEvent(){} // RVA: 0x7FFAC873CE20
        public void .ctor(){} // RVA: 0x7FFAC873CF90
        public void get_Schema(){} // RVA: 0x7FFAC2F60010
        public void set_Schema(){} // RVA: 0x7FFAC873D170
        public void get_Reader(){} // RVA: 0x7FFAC30E5600
        public void Close(){} // RVA: 0x7FFAC873D2B0
        public void ValidateNotDisallowed(){} // RVA: 0x7FFAC873D340
        public void GetCurrentNodeSchemaType(){} // RVA: 0x7FFAC873D660
        public void ReadAsInt32(){} // RVA: 0x7FFAC873D7F0
        public void ReadAsBytes(){} // RVA: 0x7FFAC873D840
        public void ReadAsDecimal(){} // RVA: 0x7FFAC873D890
        public void ReadAsDouble(){} // RVA: 0x7FFAC873D8F0
        public void ReadAsBoolean(){} // RVA: 0x7FFAC873D950
        public void ReadAsString(){} // RVA: 0x7FFAC873D9A0
        public void ReadAsDateTime(){} // RVA: 0x7FFAC873D9F0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC873DA50
        public void Read(){} // RVA: 0x7FFAC873DAB0
        public void ValidateCurrentToken(){} // RVA: 0x7FFAC873DB20
        public void WriteToken(){} // RVA: 0x7FFAC873E980
        public void ValidateEndObject(){} // RVA: 0x7FFAC873F3B0
        public void ValidateEndArray(){} // RVA: 0x7FFAC873F7A0
        public void ValidateNull(){} // RVA: 0x7FFAC873F9D0
        public void ValidateBoolean(){} // RVA: 0x7FFAC873FA10
        public void ValidateString(){} // RVA: 0x7FFAC873FA50
        public void ValidateInteger(){} // RVA: 0x7FFAC873FE50
        public void ProcessValue(){} // RVA: 0x7FFAC8740650
        public void ValidateFloat(){} // RVA: 0x7FFAC8740970
        public void FloatingPointRemainder(){} // RVA: 0x7FFAC8740F40
        public void IsZero(){} // RVA: 0x7FFAC8740FB0
        public void ValidatePropertyName(){} // RVA: 0x7FFAC8741020
        public void IsPropertyDefinied(){} // RVA: 0x7FFAC8741280
        public void ValidateArray(){} // RVA: 0x7FFAC87414A0
        public void ValidateObject(){} // RVA: 0x7FFAC87414C0
        public void TestType(){} // RVA: 0x7FFAC87414E0
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC8741630
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC8741690
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC87416F0
        public void .cctor(){} // RVA: 0x7FFAC8741750
    }

    public class JsonWriter : Object
    {
        public 0x6B1C5450[][] CloseOutput;
        public 0x6B1C5450[][] AutoCompleteOnClose; // 0x8
        public System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition> Top; // 0x10
        public Newtonsoft.Json.JsonPosition WriteState; // 0x18
        public 0x6B1C5450 ContainerPath; // 0x30
        public 0x6B1C3248 Path; // 0x34
        public bool Formatting; // 0x38
        public bool DateFormatHandling; // 0x39
        public 0x6B1C2F88 DateTimeZoneHandling; // 0x3C
        public 0x6B1C3038 StringEscapeHandling; // 0x40
        public 0x6B1C5B30 FloatFormatHandling; // 0x44
        public 0x6B1C3198 DateFormatString; // 0x48
        public string Culture; // 0x50
        public System.Globalization.CultureInfo _culture; // 0x58

        // ── Methods ──
        public void AutoCompleteAsync(){} // RVA: 0x7FFAC87426E0 | overloaded x2
        public void CloseAsync(){} // RVA: 0x7FFAC87428F0
        public void FlushAsync(){} // RVA: 0x7FFAC87429D0
        public void WriteEndAsync(){} // RVA: 0x7FFAC8742F40 | overloaded x2
        public void WriteIndentAsync(){} // RVA: 0x7FFAC8742BA0
        public void WriteValueDelimiterAsync(){} // RVA: 0x7FFAC8742C80
        public void WriteIndentSpaceAsync(){} // RVA: 0x7FFAC8742D60
        public void WriteRawAsync(){} // RVA: 0x7FFAC8742E40
        public void WriteEndInternalAsync(){} // RVA: 0x7FFAC8743020
        public void InternalWriteEndAsync(){} // RVA: 0x7FFAC87431C0
        public void WriteEndArrayAsync(){} // RVA: 0x7FFAC8743440
        public void WriteEndConstructorAsync(){} // RVA: 0x7FFAC8743520
        public void WriteEndObjectAsync(){} // RVA: 0x7FFAC8743600
        public void WriteNullAsync(){} // RVA: 0x7FFAC87436E0
        public void WritePropertyNameAsync(){} // RVA: 0x7FFAC87438C0 | overloaded x2
        public void InternalWritePropertyNameAsync(){} // RVA: 0x7FFAC87439C0
        public void WriteStartArrayAsync(){} // RVA: 0x7FFAC8743AE0
        public void InternalWriteStartAsync(){} // RVA: 0x7FFAC8743BC0
        public void WriteCommentAsync(){} // RVA: 0x7FFAC8743E00
        public void InternalWriteCommentAsync(){} // RVA: 0x7FFAC8743F00
        public void WriteRawValueAsync(){} // RVA: 0x7FFAC8743F10
        public void WriteStartConstructorAsync(){} // RVA: 0x7FFAC8744010
        public void WriteStartObjectAsync(){} // RVA: 0x7FFAC8744110
        public void WriteTokenAsync(){} // RVA: 0x7FFAC8744E60 | overloaded x5
        public void WriteTokenSyncReadingAsync(){} // RVA: 0x7FFAC87450F0
        public void WriteConstructorDateAsync(){} // RVA: 0x7FFAC8745370
        public void WriteValueAsync(){} // RVA: 0x7FFAC8748160 | overloaded x39
        public void WriteUndefinedAsync(){} // RVA: 0x7FFAC8747BD0
        public void WriteWhitespaceAsync(){} // RVA: 0x7FFAC8747CB0
        public void InternalWriteValueAsync(){} // RVA: 0x7FFAC8747DB0
        public void SetWriteStateAsync(){} // RVA: 0x7FFAC8747E80
        public void BuildStateArray(){} // RVA: 0x7FFAC87494E0
        public void .cctor(){} // RVA: 0x7FFAC87497A0
        public void get_CloseOutput(){} // RVA: 0x7FFAC31D95D0
        public void set_CloseOutput(){} // RVA: 0x7FFAC31D95C0
        public void get_AutoCompleteOnClose(){} // RVA: 0x7FFAC33BCE50
        public void set_AutoCompleteOnClose(){} // RVA: 0x7FFAC33BD1D0
        public void get_Top(){} // RVA: 0x7FFAC8749B30
        public void get_WriteState(){} // RVA: 0x7FFAC8749B90
        public void get_ContainerPath(){} // RVA: 0x7FFAC8749CB0
        public void get_Path(){} // RVA: 0x7FFAC8749D50
        public void get_Formatting(){} // RVA: 0x7FFAC3ADEDC0
        public void set_Formatting(){} // RVA: 0x7FFAC8749ED0
        public void get_DateFormatHandling(){} // RVA: 0x7FFAC33BD4A0
        public void set_DateFormatHandling(){} // RVA: 0x7FFAC8749F40
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC2FC2080
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC8749FB0
        public void get_StringEscapeHandling(){} // RVA: 0x7FFAC2FC20A0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFAC874A020
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFAC2F21310
        public void get_FloatFormatHandling(){} // RVA: 0x7FFAC2FC20C0
        public void set_FloatFormatHandling(){} // RVA: 0x7FFAC874A0A0
        public void get_DateFormatString(){} // RVA: 0x7FFAC2FC20E0
        public void set_DateFormatString(){} // RVA: 0x7FFAC30794D0
        public void get_Culture(){} // RVA: 0x7FFAC874A110
        public void set_Culture(){} // RVA: 0x7FFAC2FE9510
        public void .ctor(){} // RVA: 0x7FFAC874A170
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFAC874A190
        public void Push(){} // RVA: 0x7FFAC874A1A0
        public void Pop(){} // RVA: 0x7FFAC874A350
        public void Peek(){} // RVA: 0x7FFAC3157800
        public void Flush(){} // RVA: 0x7FFAC2C70980
        public void Close(){} // RVA: 0x7FFAC874A4C0
        public void WriteStartObject(){} // RVA: 0x7FFAC874A530
        public void WriteEndObject(){} // RVA: 0x7FFAC874A570
        public void WriteStartArray(){} // RVA: 0x7FFAC874A580
        public void WriteEndArray(){} // RVA: 0x7FFAC874A5C0
        public void WriteStartConstructor(){} // RVA: 0x7FFAC874A5D0
        public void WriteEndConstructor(){} // RVA: 0x7FFAC874A610
        public void WritePropertyName(){} // RVA: 0x7FFAC874A690 | overloaded x2
        public void WriteEnd(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void WriteToken(){} // RVA: 0x7FFAC874B390 | overloaded x5
        public void IsWriteTokenIncomplete(){} // RVA: 0x7FFAC874B670
        public void CalculateWriteTokenInitialDepth(){} // RVA: 0x7FFAC874B740
        public void CalculateWriteTokenFinalDepth(){} // RVA: 0x7FFAC874B7B0
        public void WriteConstructorDate(){} // RVA: 0x7FFAC874B820
        public void AutoCompleteAll(){} // RVA: 0x7FFAC874B9D0
        public void GetCloseTokenForType(){} // RVA: 0x7FFAC874BA40
        public void AutoCompleteClose(){} // RVA: 0x7FFAC874BB00
        public void CalculateLevelsToComplete(){} // RVA: 0x7FFAC874BBC0
        public void UpdateCurrentState(){} // RVA: 0x7FFAC874BCF0
        public void WriteIndent(){} // RVA: 0x7FFAC2F21310
        public void WriteValueDelimiter(){} // RVA: 0x7FFAC2F21310
        public void WriteIndentSpace(){} // RVA: 0x7FFAC2F21310
        public void AutoComplete(){} // RVA: 0x7FFAC874BDC0
        public void WriteNull(){} // RVA: 0x7FFAC874BFF0
        public void WriteUndefined(){} // RVA: 0x7FFAC874C010
        public void WriteRaw(){} // RVA: 0x7FFAC2F21310
        public void WriteRawValue(){} // RVA: 0x7FFAC874C030
        public void WriteValue(){} // RVA: 0x7FFAC874CDA0 | overloaded x39
        public void WriteComment(){} // RVA: 0x7FFAC874CCE0
        public void WriteWhitespace(){} // RVA: 0x7FFAC874CCF0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC874CD00
        public void Dispose(){} // RVA: 0x7FFAC874CD70
        public void ResolveConvertibleValue(){} // RVA: 0x7FFAC874E0C0
        public void CreateUnsupportedTypeException(){} // RVA: 0x7FFAC874E320
        public void SetWriteState(){} // RVA: 0x7FFAC874E420
        public void InternalWriteEnd(){} // RVA: 0x7FFAC874BB00
        public void InternalWritePropertyName(){} // RVA: 0x7FFAC874A620
        public void InternalWriteRaw(){} // RVA: 0x7FFAC2F21310
        public void InternalWriteStart(){} // RVA: 0x7FFAC874E6C0
        public void InternalWriteValue(){} // RVA: 0x7FFAC874E700
        public void InternalWriteWhitespace(){} // RVA: 0x7FFAC874E720
        public void InternalWriteComment(){} // RVA: 0x7FFAC874CCE0
        public void <InternalWriteEndAsync>g__AwaitProperty|11_0(){} // RVA: 0x7FFAC874E820
        public void <InternalWriteEndAsync>g__AwaitIndent|11_1(){} // RVA: 0x7FFAC874EAB0
        public void <InternalWriteEndAsync>g__AwaitEnd|11_2(){} // RVA: 0x7FFAC874ED50
        public void <InternalWriteEndAsync>g__AwaitRemaining|11_3(){} // RVA: 0x7FFAC874EFD0
    }

    public class JsonWriterException : JsonException
    {
        public string Path; // 0x90

        // ── Methods ──
        public void get_Path(){} // RVA: 0x7FFAC32EF640
        public void .ctor(){} // RVA: 0x7FFAC8752B70 | overloaded x5
        public void Create(){} // RVA: 0x7FFAC8752D10 | overloaded x2
    }

}