// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 30
// Methods: 1041

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable : JsonNameTable
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86A92C90
        public void .ctor(){} // RVA: 0x7FFE86A92CD0
        public void Get(){} // RVA: 0x7FFE86A92D70
        public void Add(){} // RVA: 0x7FFE86A92F60
        public void AddEntry(){} // RVA: 0x7FFE86A931A0
        public void Grow(){} // RVA: 0x7FFE86A934D0
        public void TextEquals(){} // RVA: 0x7FFE86A93670
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7FFE80E3D230
        public void Return(){} // RVA: 0x7FFE80E460A0
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7FFE80E2F150
        public void get_LineNumber(){} // RVA: 0x7FFE80E2EDB0
        public void get_LinePosition(){} // RVA: 0x7FFE80E2EDB0
    }

    public class JsonArrayAttribute : JsonContainerAttribute
    {
        public bool _allowNullItems; // 0x68

        // ── Methods ──
        public void get_AllowNullItems(){} // RVA: 0x7FFE811C3570
        public void set_AllowNullItems(){} // RVA: 0x7FFE811C3580
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
    }

    public class JsonConstructorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonContainerAttribute : Attribute
    {
        public string _id; // 0x10
        public string _title; // 0x18
        public string _description; // 0x20
        public System.Type _itemConverterType; // 0x28
        public object[] _itemConverterParameters; // 0x30
        public Newtonsoft.Json.Serialization.NamingStrategy _namingStrategyInstance; // 0x38
        public System.Nullable`1<bool> _isReference; // 0x40
        public System.Nullable`1<bool> _itemIsReference; // 0x42
        public System.Nullable`1<0x665BF344> _itemReferenceLoopHandling; // 0x44
        public System.Nullable`1<0x665BF4A4> _itemTypeNameHandling; // 0x4C
        public System.Type _namingStrategyType; // 0x58
        public object[] _namingStrategyParameters; // 0x60

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE81116380
        public void set_Id(){} // RVA: 0x7FFE810FCE30
        public void get_Title(){} // RVA: 0x7FFE810FE7C0
        public void set_Title(){} // RVA: 0x7FFE81161E80
        public void get_Description(){} // RVA: 0x7FFE811290C0
        public void set_Description(){} // RVA: 0x7FFE811290D0
        public void get_ItemConverterType(){} // RVA: 0x7FFE81129130
        public void set_ItemConverterType(){} // RVA: 0x7FFE810FCE90
        public void get_ItemConverterParameters(){} // RVA: 0x7FFE8144E200
        public void set_ItemConverterParameters(){} // RVA: 0x7FFE81129890
        public void get_NamingStrategyType(){} // RVA: 0x7FFE811C3500
        public void set_NamingStrategyType(){} // RVA: 0x7FFE86A937C0
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFE81199370
        public void set_NamingStrategyParameters(){} // RVA: 0x7FFE86A93870
        public void get_NamingStrategyInstance(){} // RVA: 0x7FFE8143BA80
        public void set_NamingStrategyInstance(){} // RVA: 0x7FFE81437330
        public void get_IsReference(){} // RVA: 0x7FFE86A93920
        public void set_IsReference(){} // RVA: 0x7FFE86A93960
        public void get_ItemIsReference(){} // RVA: 0x7FFE86A939B0
        public void set_ItemIsReference(){} // RVA: 0x7FFE86A939F0
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86A93A40
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86A93A80
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFE86A93AE0
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFE86A93B20
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class JsonConvert : Object
    {
        public System.Func`1<Newtonsoft.Json.JsonSerializerSettings> _defaultSettings;

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7FFE86A93B80
        public void set_DefaultSettings(){} // RVA: 0x7FFE86A93BE0
        public void ToString(){} // RVA: 0x7FFE86A96240 | overloaded x30
        public void ToStringInternal(){} // RVA: 0x7FFE86A948D0
        public void EnsureFloatFormat(){} // RVA: 0x7FFE86A94DB0
        public void EnsureDecimalPlace(){} // RVA: 0x7FFE86A95360 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFE86A97D00 | overloaded x8
        public void SerializeObjectInternal(){} // RVA: 0x7FFE86A97DD0
        public void DeserializeObject(){} // RVA: 0x7FFE86A982C0 | overloaded x8
        public void DeserializeAnonymousType(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void PopulateObject(){} // RVA: 0x7FFE86A98540 | overloaded x2
        public void SerializeXmlNode(){} // RVA: 0x7FFE86A98980 | overloaded x3
        public void DeserializeXmlNode(){} // RVA: 0x7FFE86A98C90 | overloaded x4
        public void SerializeXNode(){} // RVA: 0x7FFE86A99180 | overloaded x3
        public void DeserializeXNode(){} // RVA: 0x7FFE86A99490 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFE86A996E0
    }

    public class JsonConverter : Object
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE80E50660
        public void ReadJson(){} // RVA: 0x7FFE80E40660
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonConverterAttribute : Attribute
    {
        public System.Type _converterType; // 0x10
        public object[] _converterParameters; // 0x18

        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7FFE81116380
        public void get_ConverterParameters(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86A99B90 | overloaded x2
    }

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A99CF0
    }

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ReadJson(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A99E50 | overloaded x4
        public void Create(){} // RVA: 0x7FFE86A99ED0
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        public bool _writeData; // 0x10
        public bool _readData; // 0x11

        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7FFE811C55E0
        public void set_WriteData(){} // RVA: 0x7FFE811C55F0
        public void get_ReadData(){} // RVA: 0x7FFE81346E30
        public void set_ReadData(){} // RVA: 0x7FFE813471A0
        public void .ctor(){} // RVA: 0x7FFE813752B0
    }

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonNameTable : Object
    {
        // ── Methods ──
        public void Get(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public \ _memberSerialization; // 0x68
        public System.Nullable`1<0x665BF1E4> _missingMemberHandling; // 0x6C
        public System.Nullable`1<0x665BF39C> _itemRequired; // 0x74
        public System.Nullable`1<0x665BF23C> _itemNullValueHandling; // 0x7C

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFE82A22EF0
        public void set_MemberSerialization(){} // RVA: 0x7FFE82A22F00
        public void get_MissingMemberHandling(){} // RVA: 0x7FFE86A99FB0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE86A99FF0
        public void get_ItemNullValueHandling(){} // RVA: 0x7FFE86A9A050
        public void set_ItemNullValueHandling(){} // RVA: 0x7FFE86A9A0A0
        public void get_ItemRequired(){} // RVA: 0x7FFE86A9A100
        public void set_ItemRequired(){} // RVA: 0x7FFE86A9A140
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
    }

    public class JsonPosition : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A9A1A0
        public void CalculateLength(){} // RVA: 0x7FFE86A9A260
        public void WriteTo(){} // RVA: 0x7FFE86A9A300
        public void TypeHasIndex(){} // RVA: 0x7FFE86A9A530
        public void BuildPath(){} // RVA: 0x7FFE86A9A540
        public void FormatMessage(){} // RVA: 0x7FFE86A9AB40
        public void .cctor(){} // RVA: 0x7FFE86A9AEB0
    }

    public class JsonPropertyAttribute : Attribute
    {
        public System.Nullable`1<0x665BF23C> _nullValueHandling; // 0x10
        public System.Nullable`1<[> _defaultValueHandling; // 0x18
        public System.Nullable`1<0x665BF344> _referenceLoopHandling; // 0x20
        public System.Nullable`1<0x665BF294> _objectCreationHandling; // 0x28
        public System.Nullable`1<0x665BF4A4> _typeNameHandling; // 0x30
        public System.Nullable`1<bool> _isReference; // 0x38
        public System.Nullable`1<int> _order; // 0x3C
        public System.Nullable`1<0x665BF39C> _required; // 0x44
        public System.Nullable`1<bool> _itemIsReference; // 0x4C
        public System.Nullable`1<0x665BF344> _itemReferenceLoopHandling; // 0x50
        public System.Nullable`1<0x665BF4A4> _itemTypeNameHandling; // 0x58
        public System.Type _itemConverterType; // 0x60
        public object[] _itemConverterParameters; // 0x68
        public System.Type _namingStrategyType; // 0x70
        public object[] _namingStrategyParameters; // 0x78
        public string _propertyName; // 0x80

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFE81199370
        public void set_ItemConverterType(){} // RVA: 0x7FFE81199380
        public void get_ItemConverterParameters(){} // RVA: 0x7FFE81176D50
        public void set_ItemConverterParameters(){} // RVA: 0x7FFE81176D60
        public void get_NamingStrategyType(){} // RVA: 0x7FFE811C3590
        public void set_NamingStrategyType(){} // RVA: 0x7FFE811C35A0
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFE81463AE0
        public void set_NamingStrategyParameters(){} // RVA: 0x7FFE81464570
        public void get_NullValueHandling(){} // RVA: 0x7FFE86A9AF90
        public void set_NullValueHandling(){} // RVA: 0x7FFE86A9AFD0
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE86A9B030
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE86A9B070
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE86A9B0D0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE86A9B110
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE86A9B170
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE86A9B1B0
        public void get_TypeNameHandling(){} // RVA: 0x7FFE86A9B210
        public void set_TypeNameHandling(){} // RVA: 0x7FFE86A9B250
        public void get_IsReference(){} // RVA: 0x7FFE86A9B2B0
        public void set_IsReference(){} // RVA: 0x7FFE86A9B2F0
        public void get_Order(){} // RVA: 0x7FFE86A9B340
        public void set_Order(){} // RVA: 0x7FFE86A9B380
        public void get_Required(){} // RVA: 0x7FFE86A9B3E0
        public void set_Required(){} // RVA: 0x7FFE86A9B420
        public void get_PropertyName(){} // RVA: 0x7FFE81280C30
        public void set_PropertyName(){} // RVA: 0x7FFE81282380
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86A9B480
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86A9B4C0
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFE86A9B520
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFE86A9B560
        public void get_ItemIsReference(){} // RVA: 0x7FFE86A9B5C0
        public void set_ItemIsReference(){} // RVA: 0x7FFE86A9B600
        public void .ctor(){} // RVA: 0x7FFE81282380 | overloaded x2
    }

    public class JsonReader : Object
    {
        public 0x665BEB5C _tokenType; // 0x10
        public object _value; // 0x18
        public char _quoteChar; // 0x20
        public dFixup.ÎÍÎÍÏÍÎ _currentState; // 0x24
        public Newtonsoft.Json.JsonPosition _currentPosition; // 0x28
        public System.Globalization.CultureInfo _culture; // 0x40
        public 0x665BC8FC _dateTimeZoneHandling; // 0x48
        public System.Nullable`1<int> _maxDepth; // 0x4C
        public bool _hasExceededMaxDepth; // 0x54
        public 0x665BC8A4 _dateParseHandling; // 0x58
        public 0x665BCAB4 _floatParseHandling; // 0x5C
        public string _dateFormatString; // 0x60
        public System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition> _stack; // 0x68
        public bool _closeInput; // 0x70
        public bool _supportMultipleContent; // 0x71

        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x7FFE86A9B650
        public void SkipAsync(){} // RVA: 0x7FFE86A9B810
        public void ReaderReadAndAssertAsync(){} // RVA: 0x7FFE86A9BA20
        public void ReadAsBooleanAsync(){} // RVA: 0x7FFE86A9BC30
        public void ReadAsBytesAsync(){} // RVA: 0x7FFE86A9BDD0
        public void ReadArrayIntoByteArrayAsync(){} // RVA: 0x7FFE86A9BEE0
        public void ReadAsDateTimeAsync(){} // RVA: 0x7FFE86A9C0D0
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x7FFE86A9C2E0
        public void ReadAsDecimalAsync(){} // RVA: 0x7FFE86A9C500
        public void ReadAsDoubleAsync(){} // RVA: 0x7FFE86A9C720
        public void ReadAsInt32Async(){} // RVA: 0x7FFE86A9C850
        public void ReadAsStringAsync(){} // RVA: 0x7FFE86A9C9F0
        public void ReadAndMoveToContentAsync(){} // RVA: 0x7FFE86A9CAC0
        public void MoveToContentAsync(){} // RVA: 0x7FFE86A9CCB0
        public void MoveToContentFromNonContentAsync(){} // RVA: 0x7FFE86A9CD50
        public void get_CurrentState(){} // RVA: 0x7FFE81A56130
        public void get_CloseInput(){} // RVA: 0x7FFE81177320
        public void set_CloseInput(){} // RVA: 0x7FFE81177330
        public void get_SupportMultipleContent(){} // RVA: 0x7FFE865EFE00
        public void set_SupportMultipleContent(){} // RVA: 0x7FFE865EFE10
        public void get_QuoteChar(){} // RVA: 0x7FFE850EF1D0
        public void set_QuoteChar(){} // RVA: 0x7FFE86601D50
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE8119C0C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE86A9CF40
        public void get_DateParseHandling(){} // RVA: 0x7FFE8175AC90
        public void set_DateParseHandling(){} // RVA: 0x7FFE86A9CFB0
        public void get_FloatParseHandling(){} // RVA: 0x7FFE813A7A20
        public void set_FloatParseHandling(){} // RVA: 0x7FFE86A9D020
        public void get_DateFormatString(){} // RVA: 0x7FFE81199370
        public void set_DateFormatString(){} // RVA: 0x7FFE81199380
        public void get_MaxDepth(){} // RVA: 0x7FFE84337910
        public void set_MaxDepth(){} // RVA: 0x7FFE86A9D090
        public void get_TokenType(){} // RVA: 0x7FFE811485C0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void get_ValueType(){} // RVA: 0x7FFE86A9D150
        public void get_Depth(){} // RVA: 0x7FFE86A9D170
        public void get_Path(){} // RVA: 0x7FFE86A9D1E0
        public void get_Culture(){} // RVA: 0x7FFE86A9D360
        public void set_Culture(){} // RVA: 0x7FFE81123200
        public void GetPosition(){} // RVA: 0x7FFE86A9D3C0
        public void .ctor(){} // RVA: 0x7FFE86A9D480
        public void Push(){} // RVA: 0x7FFE86A9D4F0
        public void Pop(){} // RVA: 0x7FFE86A9D840
        public void Peek(){} // RVA: 0x7FFE81549710
        public void Read(){} // RVA: 0x7FFE80E2F150
        public void ReadAsInt32(){} // RVA: 0x7FFE86A9D9F0
        public void ReadInt32String(){} // RVA: 0x7FFE86A9DE40
        public void ReadAsString(){} // RVA: 0x7FFE86A9E1C0
        public void ReadAsBytes(){} // RVA: 0x7FFE86A9E470
        public void ReadArrayIntoByteArray(){} // RVA: 0x7FFE86A9EA90
        public void ReadArrayElementIntoByteArrayReportDone(){} // RVA: 0x7FFE86A9EC90
        public void ReadAsDouble(){} // RVA: 0x7FFE86A9EE90
        public void ReadDoubleString(){} // RVA: 0x7FFE86A9F250
        public void ReadAsBoolean(){} // RVA: 0x7FFE86A9F590
        public void ReadBooleanString(){} // RVA: 0x7FFE86A9F9F0
        public void ReadAsDecimal(){} // RVA: 0x7FFE86A9FDD0
        public void ReadDecimalString(){} // RVA: 0x7FFE86AA0280
        public void ReadAsDateTime(){} // RVA: 0x7FFE86AA0740
        public void ReadDateTimeString(){} // RVA: 0x7FFE86AA0AA0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE86AA0EE0
        public void ReadDateTimeOffsetString(){} // RVA: 0x7FFE86AA1220
        public void ReaderReadAndAssert(){} // RVA: 0x7FFE86AA1650
        public void CreateUnexpectedEndException(){} // RVA: 0x7FFE86AA16A0
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7FFE86AA16F0
        public void Skip(){} // RVA: 0x7FFE86AA1AC0
        public void SetToken(){} // RVA: 0x7FFE86AA1BC0 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x7FFE86AA1DF0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFE86AA1E20
        public void ValidateEnd(){} // RVA: 0x7FFE86AA1E30
        public void SetStateBasedOnCurrent(){} // RVA: 0x7FFE86AA1FF0
        public void SetFinished(){} // RVA: 0x7FFE86AA2100
        public void GetTypeForCloseToken(){} // RVA: 0x7FFE86AA2120
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE86AA2210
        public void Dispose(){} // RVA: 0x7FFE86AA2280
        public void Close(){} // RVA: 0x7FFE86AA22B0
        public void ReadAndAssert(){} // RVA: 0x7FFE86AA2310
        public void ReadForTypeAndAssert(){} // RVA: 0x7FFE86AA2370
        public void ReadForType(){} // RVA: 0x7FFE86AA23C0
        public void ReadAndMoveToContent(){} // RVA: 0x7FFE86AA2680
        public void MoveToContent(){} // RVA: 0x7FFE86AA26E0
        public void GetContentToken(){} // RVA: 0x7FFE86AA2740
    }

    public class JsonReaderException : JsonException
    {
        public int _lineNumber; // 0x90
        public int _linePosition; // 0x94
        public string _path; // 0x98

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFE814AA220
        public void get_LinePosition(){} // RVA: 0x7FFE814AA230
        public void get_Path(){} // RVA: 0x7FFE817AE360
        public void .ctor(){} // RVA: 0x7FFE86AA4070 | overloaded x5
        public void Create(){} // RVA: 0x7FFE86AA4300 | overloaded x3
    }

    public class JsonRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonSerializationException : JsonException
    {
        public int _lineNumber; // 0x90
        public int _linePosition; // 0x94
        public string _path; // 0x98

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFE814AA220
        public void get_LinePosition(){} // RVA: 0x7FFE814AA230
        public void get_Path(){} // RVA: 0x7FFE817AE360
        public void .ctor(){} // RVA: 0x7FFE86AA4070 | overloaded x5
        public void Create(){} // RVA: 0x7FFE86AA45C0 | overloaded x3
    }

    public class JsonSerializer : Object
    {
        public 0x665BF4A4 _typeNameHandling; // 0x10
        public 0x665BF44C _typeNameAssemblyFormatHandling; // 0x14
        public \ _preserveReferencesHandling; // 0x18
        public 0x665BF344 _referenceLoopHandling; // 0x1C
        public 0x665BF1E4 _missingMemberHandling; // 0x20
        public 0x665BF294 _objectCreationHandling; // 0x24
        public 0x665BF23C _nullValueHandling; // 0x28
        public [ _defaultValueHandling; // 0x2C
        public 0x665BC7F4 _constructorHandling; // 0x30
        public 0x665BF18C _metadataPropertyHandling; // 0x34
        public Newtonsoft.Json.JsonConverterCollection _converters; // 0x38
        public Newtonsoft.Json.Serialization.IContractResolver _contractResolver; // 0x40
        public Newtonsoft.Json.Serialization.ITraceWriter _traceWriter; // 0x48
        public System.Collections.IEqualityComparer _equalityComparer; // 0x50
        public Newtonsoft.Json.Serialization.ISerializationBinder _serializationBinder; // 0x58
        public System.Runtime.Serialization.StreamingContext _context; // 0x60
        public Newtonsoft.Json.Serialization.IReferenceResolver _referenceResolver; // 0x70
        public System.Nullable`1<0x665BCB0C> _formatting; // 0x78
        public System.Nullable`1<0x665BC84C> _dateFormatHandling; // 0x80
        public System.Nullable`1<0x665BC8FC> _dateTimeZoneHandling; // 0x88
        public System.Nullable`1<0x665BC8A4> _dateParseHandling; // 0x90
        public System.Nullable`1<0x665BCA5C> _floatFormatHandling; // 0x98
        public System.Nullable`1<0x665BCAB4> _floatParseHandling; // 0xA0
        public System.Nullable`1<0x665BF3F4> _stringEscapeHandling; // 0xA8
        public System.Globalization.CultureInfo _culture; // 0xB0
        public System.Nullable`1<int> _maxDepth; // 0xB8
        public bool _maxDepthSet; // 0xC0
        public System.Nullable`1<bool> _checkAdditionalContent; // 0xC1
        public string _dateFormatString; // 0xC8
        public bool _dateFormatStringSet; // 0xD0

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFE86AA4740
        public void remove_Error(){} // RVA: 0x7FFE86AA4840
        public void get_ReferenceResolver(){} // RVA: 0x7FFE86AA4940
        public void set_ReferenceResolver(){} // RVA: 0x7FFE86AA4950
        public void get_Binder(){} // RVA: 0x7FFE86AA4A20
        public void set_Binder(){} // RVA: 0x7FFE86AA4B40
        public void get_SerializationBinder(){} // RVA: 0x7FFE811C3500
        public void set_SerializationBinder(){} // RVA: 0x7FFE86AA4CA0
        public void get_TraceWriter(){} // RVA: 0x7FFE81176730
        public void set_TraceWriter(){} // RVA: 0x7FFE81176740
        public void get_EqualityComparer(){} // RVA: 0x7FFE8119C0E0
        public void set_EqualityComparer(){} // RVA: 0x7FFE812534D0
        public void get_TypeNameHandling(){} // RVA: 0x7FFE811485C0
        public void set_TypeNameHandling(){} // RVA: 0x7FFE86AA4D70
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFE8164B230
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFE86AA4DE0
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFE8164B230
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFE86AA4E50
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFE813DB630
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFE86AA4EC0
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE82707EE0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE86AA4F30
        public void get_MissingMemberHandling(){} // RVA: 0x7FFE8151D690
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE86AA4FA0
        public void get_NullValueHandling(){} // RVA: 0x7FFE81549710
        public void set_NullValueHandling(){} // RVA: 0x7FFE86AA5010
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE81F84A50
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE86AA5080
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE81A56130
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE86AA50F0
        public void get_ConstructorHandling(){} // RVA: 0x7FFE81156CD0
        public void set_ConstructorHandling(){} // RVA: 0x7FFE86AA5160
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFE82447220
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFE86AA51D0
        public void get_Converters(){} // RVA: 0x7FFE86AA5240
        public void get_ContractResolver(){} // RVA: 0x7FFE81178740
        public void set_ContractResolver(){} // RVA: 0x7FFE86AA5320
        public void get_Context(){} // RVA: 0x7FFE8432FFC0
        public void set_Context(){} // RVA: 0x7FFE86AA53E0
        public void get_Formatting(){} // RVA: 0x7FFE86AA5440
        public void set_Formatting(){} // RVA: 0x7FFE86AA5480
        public void get_DateFormatHandling(){} // RVA: 0x7FFE86AA54E0
        public void set_DateFormatHandling(){} // RVA: 0x7FFE86AA5530
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE86AA5590
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE86AA55F0
        public void get_DateParseHandling(){} // RVA: 0x7FFE86AA5650
        public void set_DateParseHandling(){} // RVA: 0x7FFE86AA56B0
        public void get_FloatParseHandling(){} // RVA: 0x7FFE86AA5710
        public void set_FloatParseHandling(){} // RVA: 0x7FFE86AA5760
        public void get_FloatFormatHandling(){} // RVA: 0x7FFE86AA57C0
        public void set_FloatFormatHandling(){} // RVA: 0x7FFE86AA5810
        public void get_StringEscapeHandling(){} // RVA: 0x7FFE86AA5870
        public void set_StringEscapeHandling(){} // RVA: 0x7FFE86AA58C0
        public void get_DateFormatString(){} // RVA: 0x7FFE86AA5920
        public void set_DateFormatString(){} // RVA: 0x7FFE86AA5970
        public void get_Culture(){} // RVA: 0x7FFE86AA59E0
        public void set_Culture(){} // RVA: 0x7FFE81166050
        public void get_MaxDepth(){} // RVA: 0x7FFE811660B0
        public void set_MaxDepth(){} // RVA: 0x7FFE86AA5A50
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFE86AA5B20
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFE86AA5B70
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFE86AA5BD0
        public void .ctor(){} // RVA: 0x7FFE86AA5C20
        public void Create(){} // RVA: 0x7FFE86AA5F10 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFE86AA6080 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFE86AA60C0
        public void Populate(){} // RVA: 0x7FFE86AA6BE0 | overloaded x2
        public void PopulateInternal(){} // RVA: 0x7FFE86AA6C00
        public void Deserialize(){} // RVA: 0x7FFE86AA6FD0 | overloaded x4
        public void DeserializeInternal(){} // RVA: 0x7FFE86AA6FF0
        public void SetupReader(){} // RVA: 0x7FFE86AA72D0
        public void ResetReader(){} // RVA: 0x7FFE86AA7890
        public void Serialize(){} // RVA: 0x7FFE86AA7CF0 | overloaded x4
        public void CreateTraceJsonReader(){} // RVA: 0x7FFE86AA7D20
        public void SerializeInternal(){} // RVA: 0x7FFE86AA7DE0
        public void GetReferenceResolver(){} // RVA: 0x7FFE86AA8580
        public void GetMatchingConverter(){} // RVA: 0x7FFE86AA8630 | overloaded x2
        public void OnError(){} // RVA: 0x7FFE86AA8700
    }

    public class JsonSerializerSettings : Object
    {
        public 0x665BF344 DefaultReferenceLoopHandling;
        public 0x665BF1E4 DefaultMissingMemberHandling;
        public 0x665BF23C DefaultNullValueHandling;
        public [ DefaultDefaultValueHandling;
        public 0x665BF294 DefaultObjectCreationHandling;
        public \ DefaultPreserveReferencesHandling;
        public 0x665BC7F4 DefaultConstructorHandling;
        public 0x665BF4A4 DefaultTypeNameHandling;
        public 0x665BF18C DefaultMetadataPropertyHandling;
        public System.Runtime.Serialization.StreamingContext DefaultContext;
        public 0x665BCB0C DefaultFormatting;
        public 0x665BC84C DefaultDateFormatHandling;
        public 0x665BC8FC DefaultDateTimeZoneHandling;
        public 0x665BC8A4 DefaultDateParseHandling;
        public 0x665BCAB4 DefaultFloatParseHandling;
        public 0x665BCA5C DefaultFloatFormatHandling;
        public 0x665BF3F4 DefaultStringEscapeHandling;
        public 0x665BF44C DefaultTypeNameAssemblyFormatHandling;
        public System.Globalization.CultureInfo DefaultCulture; // 0x10
        public bool DefaultCheckAdditionalContent;
        public string DefaultDateFormatString;
        public int DefaultMaxDepth;
        public System.Nullable`1<0x665BCB0C> _formatting; // 0x10
        public System.Nullable`1<0x665BC84C> _dateFormatHandling; // 0x18
        public System.Nullable`1<0x665BC8FC> _dateTimeZoneHandling; // 0x20
        public System.Nullable`1<0x665BC8A4> _dateParseHandling; // 0x28
        public System.Nullable`1<0x665BCA5C> _floatFormatHandling; // 0x30
        public System.Nullable`1<0x665BCAB4> _floatParseHandling; // 0x38
        public System.Nullable`1<0x665BF3F4> _stringEscapeHandling; // 0x40
        public System.Globalization.CultureInfo _culture; // 0x48
        public System.Nullable`1<bool> _checkAdditionalContent; // 0x50
        public System.Nullable`1<int> _maxDepth; // 0x54

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE86AA8730
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE86AA8780
        public void get_MissingMemberHandling(){} // RVA: 0x7FFE86AA87E0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE86AA8830
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE86AA8890
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE86AA88E0
        public void get_NullValueHandling(){} // RVA: 0x7FFE86AA8940
        public void set_NullValueHandling(){} // RVA: 0x7FFE86AA8990
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE86AA89F0
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE86AA8A30
        public void get_Converters(){} // RVA: 0x7FFE8181EA80
        public void set_Converters(){} // RVA: 0x7FFE8117C8A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFE86AA8A90
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFE86AA8AE0
        public void get_TypeNameHandling(){} // RVA: 0x7FFE86AA8B40
        public void set_TypeNameHandling(){} // RVA: 0x7FFE86AA8B90
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFE86AA8BF0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFE86AA8C40
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFE86AA8CA0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFE86AA8CE0
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFE86AA8CA0
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFE86AA8CE0
        public void get_ConstructorHandling(){} // RVA: 0x7FFE86AA8D40
        public void set_ConstructorHandling(){} // RVA: 0x7FFE86AA8D90
        public void get_ContractResolver(){} // RVA: 0x7FFE8117C900
        public void set_ContractResolver(){} // RVA: 0x7FFE8117C910
        public void get_EqualityComparer(){} // RVA: 0x7FFE8117C970
        public void set_EqualityComparer(){} // RVA: 0x7FFE8117C980
        public void get_ReferenceResolver(){} // RVA: 0x7FFE86AA8DF0
        public void set_ReferenceResolver(){} // RVA: 0x7FFE86AA8E10
        public void get_ReferenceResolverProvider(){} // RVA: 0x7FFE811662A0
        public void set_ReferenceResolverProvider(){} // RVA: 0x7FFE811662B0
        public void get_TraceWriter(){} // RVA: 0x7FFE8158D5D0
        public void set_TraceWriter(){} // RVA: 0x7FFE81B0E4B0
        public void get_Binder(){} // RVA: 0x7FFE86AA8FA0
        public void set_Binder(){} // RVA: 0x7FFE86AA9080
        public void get_SerializationBinder(){} // RVA: 0x7FFE81828B50
        public void set_SerializationBinder(){} // RVA: 0x7FFE81A58AB0
        public void get_Error(){} // RVA: 0x7FFE8181E3D0
        public void set_Error(){} // RVA: 0x7FFE81A60200
        public void get_Context(){} // RVA: 0x7FFE86AA91A0
        public void set_Context(){} // RVA: 0x7FFE86AA9270
        public void get_DateFormatString(){} // RVA: 0x7FFE86AA9390
        public void set_DateFormatString(){} // RVA: 0x7FFE86AA93E0
        public void get_MaxDepth(){} // RVA: 0x7FFE86AA9440
        public void set_MaxDepth(){} // RVA: 0x7FFE86AA94A0
        public void get_Formatting(){} // RVA: 0x7FFE86AA9560
        public void set_Formatting(){} // RVA: 0x7FFE86AA95A0
        public void get_DateFormatHandling(){} // RVA: 0x7FFE86AA9600
        public void set_DateFormatHandling(){} // RVA: 0x7FFE86AA9640
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE86AA96A0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE86AA9700
        public void get_DateParseHandling(){} // RVA: 0x7FFE86AA9760
        public void set_DateParseHandling(){} // RVA: 0x7FFE86AA97C0
        public void get_FloatFormatHandling(){} // RVA: 0x7FFE86AA9820
        public void set_FloatFormatHandling(){} // RVA: 0x7FFE86AA9860
        public void get_FloatParseHandling(){} // RVA: 0x7FFE86AA98C0
        public void set_FloatParseHandling(){} // RVA: 0x7FFE86AA9900
        public void get_StringEscapeHandling(){} // RVA: 0x7FFE86AA9960
        public void set_StringEscapeHandling(){} // RVA: 0x7FFE86AA99A0
        public void get_Culture(){} // RVA: 0x7FFE86AA9A00
        public void set_Culture(){} // RVA: 0x7FFE81176740
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFE86AA9A70
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFE86AA9AB0
        public void .cctor(){} // RVA: 0x7FFE86AA9B00
        public void .ctor(){} // RVA: 0x7FFE86AA9CE0 | overloaded x2
    }

    public class JsonTextReader : JsonReader
    {
        public bool _safeAsync; // 0x78
        public char UnicodeReplacementChar;
        public int MaximumJavascriptIntegerCharacterLength;
        public int LargeBufferLength;

        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x7FFE86AAA250
        public void DoReadAsync(){} // RVA: 0x7FFE86AAA740 | overloaded x2
        public void ParsePostValueAsync(){} // RVA: 0x7FFE86AAA990
        public void ReadFromFinishedAsync(){} // RVA: 0x7FFE86AAABA0
        public void ReadDataAsync(){} // RVA: 0x7FFE86AAADC0 | overloaded x2
        public void ParseValueAsync(){} // RVA: 0x7FFE86AAAFE0
        public void ReadStringIntoBufferAsync(){} // RVA: 0x7FFE86AAB1E0
        public void ProcessCarriageReturnAsync(){} // RVA: 0x7FFE86AAB570 | overloaded x2
        public void ParseUnicodeAsync(){} // RVA: 0x7FFE86AAB780
        public void EnsureCharsAsync(){} // RVA: 0x7FFE86AAB970
        public void ReadCharsAsync(){} // RVA: 0x7FFE86AABA60
        public void ParseObjectAsync(){} // RVA: 0x7FFE86AABC80
        public void ParseCommentAsync(){} // RVA: 0x7FFE86AABE80
        public void EatWhitespaceAsync(){} // RVA: 0x7FFE86AAC0D0
        public void ParseStringAsync(){} // RVA: 0x7FFE86AAC2E0
        public void MatchValueAsync(){} // RVA: 0x7FFE86AAC520
        public void MatchValueWithTrailingSeparatorAsync(){} // RVA: 0x7FFE86AAC770
        public void MatchAndSetAsync(){} // RVA: 0x7FFE86AAC9C0
        public void ParseTrueAsync(){} // RVA: 0x7FFE86AACC90
        public void ParseFalseAsync(){} // RVA: 0x7FFE86AACD50
        public void ParseNullAsync(){} // RVA: 0x7FFE86AACEA0
        public void ParseConstructorAsync(){} // RVA: 0x7FFE86AACF30
        public void ParseNumberNaNAsync(){} // RVA: 0x7FFE86AAD150
        public void ParseNumberPositiveInfinityAsync(){} // RVA: 0x7FFE86AAD350
        public void ParseNumberNegativeInfinityAsync(){} // RVA: 0x7FFE86AAD550
        public void ParseNumberAsync(){} // RVA: 0x7FFE86AAD750
        public void ParseUndefinedAsync(){} // RVA: 0x7FFE86AAD980
        public void ParsePropertyAsync(){} // RVA: 0x7FFE86AADA10
        public void ReadNumberIntoBufferAsync(){} // RVA: 0x7FFE86AADC10
        public void ParseUnquotedPropertyAsync(){} // RVA: 0x7FFE86AADE20
        public void ReadNullCharAsync(){} // RVA: 0x7FFE86AAE030
        public void HandleNullAsync(){} // RVA: 0x7FFE86AAE220
        public void ReadFinishedAsync(){} // RVA: 0x7FFE86AAE430
        public void ReadStringValueAsync(){} // RVA: 0x7FFE86AAE640
        public void ReadNumberValueAsync(){} // RVA: 0x7FFE86AAE850
        public void ReadAsBooleanAsync(){} // RVA: 0x7FFE86AAEA60
        public void DoReadAsBooleanAsync(){} // RVA: 0x7FFE86AAEA80
        public void ReadAsBytesAsync(){} // RVA: 0x7FFE86AAEC80
        public void DoReadAsBytesAsync(){} // RVA: 0x7FFE86AAEDB0
        public void ReadIntoWrappedTypeObjectAsync(){} // RVA: 0x7FFE86AAEFB0
        public void ReadAsDateTimeAsync(){} // RVA: 0x7FFE86AAF1C0
        public void DoReadAsDateTimeAsync(){} // RVA: 0x7FFE86AAF1E0
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x7FFE86AAF3D0
        public void DoReadAsDateTimeOffsetAsync(){} // RVA: 0x7FFE86AAF3F0
        public void ReadAsDecimalAsync(){} // RVA: 0x7FFE86AAF5E0
        public void DoReadAsDecimalAsync(){} // RVA: 0x7FFE86AAF600
        public void ReadAsDoubleAsync(){} // RVA: 0x7FFE86AAF7F0
        public void DoReadAsDoubleAsync(){} // RVA: 0x7FFE86AAF930
        public void ReadAsInt32Async(){} // RVA: 0x7FFE86AAFB20
        public void DoReadAsInt32Async(){} // RVA: 0x7FFE86AAFB40
        public void ReadAsStringAsync(){} // RVA: 0x7FFE86AAFD30
        public void DoReadAsStringAsync(){} // RVA: 0x7FFE86AAFE20
        public void .ctor(){} // RVA: 0x7FFE86AB0010
        public void get_PropertyNameTable(){} // RVA: 0x7FFE81218100
        public void set_PropertyNameTable(){} // RVA: 0x7FFE81218110
        public void get_ArrayPool(){} // RVA: 0x7FFE81253460
        public void set_ArrayPool(){} // RVA: 0x7FFE86AB01B0
        public void EnsureBufferNotEmpty(){} // RVA: 0x7FFE86AB0260
        public void SetNewLine(){} // RVA: 0x7FFE86AB03B0
        public void OnNewLine(){} // RVA: 0x7FFE86AB0410
        public void ParseString(){} // RVA: 0x7FFE86AB0420
        public void ParseReadString(){} // RVA: 0x7FFE86AB0480
        public void BlockCopyChars(){} // RVA: 0x7FFE86AB0AB0
        public void ShiftBufferIfNeeded(){} // RVA: 0x7FFE86AB0AD0
        public void ReadData(){} // RVA: 0x7FFE86AB0F10 | overloaded x2
        public void PrepareBufferForReadData(){} // RVA: 0x7FFE86AB0BC0
        public void EnsureChars(){} // RVA: 0x7FFE86AB0FE0
        public void ReadChars(){} // RVA: 0x7FFE86AB1130
        public void Read(){} // RVA: 0x7FFE86AB1270
        public void ReadAsInt32(){} // RVA: 0x7FFE86AB15F0
        public void ReadAsDateTime(){} // RVA: 0x7FFE86AB16E0
        public void ReadAsString(){} // RVA: 0x7FFE86AB17D0
        public void ReadAsBytes(){} // RVA: 0x7FFE86AB1840
        public void ReadStringValue(){} // RVA: 0x7FFE86AB1FA0
        public void FinishReadQuotedStringValue(){} // RVA: 0x7FFE86AB2880
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFE86AB2B60
        public void ReadAsBoolean(){} // RVA: 0x7FFE86AB2C70
        public void ProcessValueComma(){} // RVA: 0x7FFE86AB3710
        public void ReadNumberValue(){} // RVA: 0x7FFE86AB3790
        public void FinishReadQuotedNumber(){} // RVA: 0x7FFE86AB3F80
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE86AB4130
        public void ReadAsDecimal(){} // RVA: 0x7FFE86AB4220
        public void ReadAsDouble(){} // RVA: 0x7FFE86AB4310
        public void HandleNull(){} // RVA: 0x7FFE86AB4400
        public void ReadFinished(){} // RVA: 0x7FFE86AB4510
        public void ReadNullChar(){} // RVA: 0x7FFE86AB46C0
        public void EnsureBuffer(){} // RVA: 0x7FFE86AB4710
        public void ReadStringIntoBuffer(){} // RVA: 0x7FFE86AB4820
        public void FinishReadStringIntoBuffer(){} // RVA: 0x7FFE86AB4DD0
        public void WriteCharToBuffer(){} // RVA: 0x7FFE86AB5000
        public void ConvertUnicode(){} // RVA: 0x7FFE86AB50B0
        public void ParseUnicode(){} // RVA: 0x7FFE86AB52E0
        public void ReadNumberIntoBuffer(){} // RVA: 0x7FFE86AB5310
        public void ReadNumberCharIntoBuffer(){} // RVA: 0x7FFE86AB5390
        public void ClearRecentString(){} // RVA: 0x7FFE86AB5550
        public void ParsePostValue(){} // RVA: 0x7FFE86AB5570
        public void ParseObject(){} // RVA: 0x7FFE86AB5A00
        public void ParseProperty(){} // RVA: 0x7FFE86AB5C10
        public void ValidIdentifierChar(){} // RVA: 0x7FFE86AB6120
        public void ParseUnquotedProperty(){} // RVA: 0x7FFE86AB6190
        public void ReadUnquotedPropertyReportIfDone(){} // RVA: 0x7FFE86AB6340
        public void ParseValue(){} // RVA: 0x7FFE86AB6540
        public void ProcessLineFeed(){} // RVA: 0x7FFE86AB7170
        public void ProcessCarriageReturn(){} // RVA: 0x7FFE86AB7190
        public void EatWhitespace(){} // RVA: 0x7FFE86AB7200
        public void ParseConstructor(){} // RVA: 0x7FFE86AB7370
        public void ParseNumber(){} // RVA: 0x7FFE86AB7900
        public void ParseReadNumber(){} // RVA: 0x7FFE86AB7A00
        public void ThrowReaderError(){} // RVA: 0x7FFE86AB9140
        public void BigIntegerParse(){} // RVA: 0x7FFE86AB9210
        public void ParseComment(){} // RVA: 0x7FFE86AB92F0
        public void EndComment(){} // RVA: 0x7FFE86AB9690
        public void MatchValue(){} // RVA: 0x7FFE86AB97A0 | overloaded x2
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7FFE86AB9890
        public void IsSeparator(){} // RVA: 0x7FFE86AB9960
        public void ParseTrue(){} // RVA: 0x7FFE86AB9AB0
        public void ParseNull(){} // RVA: 0x7FFE86AB9C30
        public void ParseUndefined(){} // RVA: 0x7FFE86AB9D70
        public void ParseFalse(){} // RVA: 0x7FFE86AB9EB0
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7FFE86ABA0B0 | overloaded x2
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7FFE86ABA420 | overloaded x2
        public void ParseNumberNaN(){} // RVA: 0x7FFE86ABA790 | overloaded x2
        public void Close(){} // RVA: 0x7FFE86ABAA80
        public void HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void get_LineNumber(){} // RVA: 0x7FFE86ABAC00
        public void get_LinePosition(){} // RVA: 0x7FFE86ABAC50
    }

    public class JsonTextWriter : JsonWriter
    {
        public bool _safeAsync; // 0x60
        public int IndentCharBufferSize;
        public System.IO.TextWriter _writer; // 0x68
        public Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder; // 0x70
        public char _indentChar; // 0x78
        public int _indentation; // 0x7C

        // ── Methods ──
        public void FlushAsync(){} // RVA: 0x7FFE86ACEFE0
        public void DoFlushAsync(){} // RVA: 0x7FFE86ACF140
        public void WriteValueDelimiterAsync(){} // RVA: 0x7FFE86ACF1D0
        public void DoWriteValueDelimiterAsync(){} // RVA: 0x7FFE86ACF310
        public void WriteEndAsync(){} // RVA: 0x7FFE86ACFBE0 | overloaded x2
        public void DoWriteEndAsync(){} // RVA: 0x7FFE86ACF5E0
        public void CloseAsync(){} // RVA: 0x7FFE86ACF720
        public void DoCloseAsync(){} // RVA: 0x7FFE86ACF820
        public void CloseBufferAndWriterAsync(){} // RVA: 0x7FFE86ACFA30
        public void WriteIndentAsync(){} // RVA: 0x7FFE86AD0130 | overloaded x2
        public void DoWriteIndentAsync(){} // RVA: 0x7FFE86AD0020
        public void WriteValueInternalAsync(){} // RVA: 0x7FFE86AD0450 | overloaded x2
        public void WriteIndentSpaceAsync(){} // RVA: 0x7FFE86AD0720
        public void DoWriteIndentSpaceAsync(){} // RVA: 0x7FFE86AD0860
        public void WriteRawAsync(){} // RVA: 0x7FFE86AD08D0
        public void DoWriteRawAsync(){} // RVA: 0x7FFE86AD0A30
        public void WriteNullAsync(){} // RVA: 0x7FFE86AD0AB0
        public void DoWriteNullAsync(){} // RVA: 0x7FFE86AD0C10
        public void WriteDigitsAsync(){} // RVA: 0x7FFE86AD0C90
        public void WriteIntegerValueAsync(){} // RVA: 0x7FFE86AD1150 | overloaded x4
        public void WriteEscapedStringAsync(){} // RVA: 0x7FFE86AD1170
        public void WritePropertyNameAsync(){} // RVA: 0x7FFE86AD18E0 | overloaded x2
        public void DoWritePropertyNameAsync(){} // RVA: 0x7FFE86AD19F0 | overloaded x3
        public void WriteStartArrayAsync(){} // RVA: 0x7FFE86AD1C80
        public void DoWriteStartArrayAsync(){} // RVA: 0x7FFE86AD1F10 | overloaded x2
        public void WriteStartObjectAsync(){} // RVA: 0x7FFE86AD2190
        public void DoWriteStartObjectAsync(){} // RVA: 0x7FFE86AD2420 | overloaded x2
        public void WriteStartConstructorAsync(){} // RVA: 0x7FFE86AD26A0
        public void DoWriteStartConstructorAsync(){} // RVA: 0x7FFE86AD27B0
        public void WriteUndefinedAsync(){} // RVA: 0x7FFE86AD2A30
        public void DoWriteUndefinedAsync(){} // RVA: 0x7FFE86AD2D20 | overloaded x2
        public void WriteWhitespaceAsync(){} // RVA: 0x7FFE86AD2FA0
        public void DoWriteWhitespaceAsync(){} // RVA: 0x7FFE86AD3100
        public void WriteValueAsync(){} // RVA: 0x7FFE86AD8890 | overloaded x41
        public void DoWriteValueAsync(){} // RVA: 0x7FFE86AD8A10 | overloaded x24
        public void WriteValueNonNullAsync(){} // RVA: 0x7FFE86AD39A0
        public void WriteValueNotNullAsync(){} // RVA: 0x7FFE86AD84A0 | overloaded x2
        public void WriteCommentAsync(){} // RVA: 0x7FFE86AD8AB0
        public void DoWriteCommentAsync(){} // RVA: 0x7FFE86AD8BC0
        public void WriteEndArrayAsync(){} // RVA: 0x7FFE86AD8E40
        public void WriteEndConstructorAsync(){} // RVA: 0x7FFE86AD8F40
        public void WriteEndObjectAsync(){} // RVA: 0x7FFE86AD9040
        public void WriteRawValueAsync(){} // RVA: 0x7FFE86AD9140
        public void DoWriteRawValueAsync(){} // RVA: 0x7FFE86AD93E0 | overloaded x2
        public void EnsureWriteBuffer(){} // RVA: 0x7FFE86ADC8A0 | overloaded x2
        public void get_Base64Encoder(){} // RVA: 0x7FFE86AD99C0
        public void get_ArrayPool(){} // RVA: 0x7FFE817AE360
        public void set_ArrayPool(){} // RVA: 0x7FFE86AD9BC0
        public void get_Indentation(){} // RVA: 0x7FFE8286B570
        public void set_Indentation(){} // RVA: 0x7FFE86AD9C70
        public void get_QuoteChar(){} // RVA: 0x7FFE86AD9CE0
        public void set_QuoteChar(){} // RVA: 0x7FFE86AD9CF0
        public void get_IndentChar(){} // RVA: 0x7FFE86AD9D70
        public void set_IndentChar(){} // RVA: 0x7FFE86AD9D80
        public void get_QuoteName(){} // RVA: 0x7FFE81EB0A60
        public void set_QuoteName(){} // RVA: 0x7FFE86AD9DF0
        public void .ctor(){} // RVA: 0x7FFE86AD9E00
        public void Flush(){} // RVA: 0x7FFE86875480
        public void Close(){} // RVA: 0x7FFE86AD9F90
        public void CloseBufferAndWriter(){} // RVA: 0x7FFE86ADA090
        public void WriteStartObject(){} // RVA: 0x7FFE86ADA180
        public void WriteStartArray(){} // RVA: 0x7FFE86ADA1E0
        public void WriteStartConstructor(){} // RVA: 0x7FFE86ADA240
        public void WriteEnd(){} // RVA: 0x7FFE86ADA310
        public void WritePropertyName(){} // RVA: 0x7FFE86ADA4C0 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFE86ADA600
        public void UpdateCharEscapeFlags(){} // RVA: 0x7FFE86ADA610
        public void WriteIndent(){} // RVA: 0x7FFE86ADA6E0
        public void SetIndentChars(){} // RVA: 0x7FFE86ADA850
        public void WriteValueDelimiter(){} // RVA: 0x7FFE86ADAA10
        public void WriteIndentSpace(){} // RVA: 0x7FFE86ADAA40
        public void WriteValueInternal(){} // RVA: 0x7FFE86ADAA70
        public void WriteValue(){} // RVA: 0x7FFE86ADC670 | overloaded x23
        public void WriteNull(){} // RVA: 0x7FFE86ADABD0
        public void WriteUndefined(){} // RVA: 0x7FFE86ADAC70
        public void WriteRaw(){} // RVA: 0x7FFE86ADAA70
        public void WriteEscapedString(){} // RVA: 0x7FFE86ADADE0
        public void WriteValueToBuffer(){} // RVA: 0x7FFE86ADC130 | overloaded x2
        public void WriteComment(){} // RVA: 0x7FFE86ADC780
        public void WriteWhitespace(){} // RVA: 0x7FFE86ADC850
        public void WriteIntegerValue(){} // RVA: 0x7FFE86ADCC30 | overloaded x4
        public void WriteNumberToBuffer(){} // RVA: 0x7FFE86ADCCC0 | overloaded x2
    }

    public class JsonValidatingReader : JsonReader
    {
        public Newtonsoft.Json.JsonReader _reader; // 0x78
        public System.Collections.Generic.Stack`1<SchemaScope> _stack; // 0x80
        public Newtonsoft.Json.Schema.JsonSchema _schema; // 0x88
        public Newtonsoft.Json.Schema.JsonSchemaModel _model; // 0x90
        public SchemaScope _currentScope; // 0x98
        public Newtonsoft.Json.Schema.ValidationEventHandler ValidationEventHandler; // 0xA0
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel> EmptySchemaList;
        public object ValidationEventHandler; // 0x2
        public object Value;
        public object Depth;
        public object Path;
        public object Path; // 0x6840

        // ── Methods ──
        public void add_ValidationEventHandler(){} // RVA: 0x7FFE86AE5280
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFE86AE5370
        public void get_Value(){} // RVA: 0x7FFE86AE5460
        public void get_Depth(){} // RVA: 0x7FFE86AE5490
        public void get_Path(){} // RVA: 0x7FFE86AE54C0
        public void get_QuoteChar(){} // RVA: 0x7FFE86AE54F0
        public void set_QuoteChar(){} // RVA: 0x7FFE810FB310
        public void get_TokenType(){} // RVA: 0x7FFE86AE5520
        public void get_ValueType(){} // RVA: 0x7FFE86AE5550
        public void Push(){} // RVA: 0x7FFE86AE5580
        public void Pop(){} // RVA: 0x7FFE86AE5640
        public void get_CurrentSchemas(){} // RVA: 0x7FFE86AE5740
        public void get_CurrentMemberSchemas(){} // RVA: 0x7FFE86AE5760
        public void RaiseError(){} // RVA: 0x7FFE86AE6240
        public void OnValidationEvent(){} // RVA: 0x7FFE86AE65A0
        public void .ctor(){} // RVA: 0x7FFE86AE6710
        public void get_Schema(){} // RVA: 0x7FFE8113A010
        public void set_Schema(){} // RVA: 0x7FFE86AE68F0
        public void get_Reader(){} // RVA: 0x7FFE81463AE0
        public void Close(){} // RVA: 0x7FFE86AE6A30
        public void ValidateNotDisallowed(){} // RVA: 0x7FFE86AE6AC0
        public void GetCurrentNodeSchemaType(){} // RVA: 0x7FFE86AE6DE0
        public void ReadAsInt32(){} // RVA: 0x7FFE86AE6F70
        public void ReadAsBytes(){} // RVA: 0x7FFE86AE6FC0
        public void ReadAsDecimal(){} // RVA: 0x7FFE86AE7010
        public void ReadAsDouble(){} // RVA: 0x7FFE86AE7070
        public void ReadAsBoolean(){} // RVA: 0x7FFE86AE70D0
        public void ReadAsString(){} // RVA: 0x7FFE86AE7120
        public void ReadAsDateTime(){} // RVA: 0x7FFE86AE7170
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE86AE71D0
        public void Read(){} // RVA: 0x7FFE86AE7230
        public void ValidateCurrentToken(){} // RVA: 0x7FFE86AE72A0
        public void WriteToken(){} // RVA: 0x7FFE86AE8100
        public void ValidateEndObject(){} // RVA: 0x7FFE86AE8B30
        public void ValidateEndArray(){} // RVA: 0x7FFE86AE8F20
        public void ValidateNull(){} // RVA: 0x7FFE86AE9150
        public void ValidateBoolean(){} // RVA: 0x7FFE86AE9190
        public void ValidateString(){} // RVA: 0x7FFE86AE91D0
        public void ValidateInteger(){} // RVA: 0x7FFE86AE95D0
        public void ProcessValue(){} // RVA: 0x7FFE86AE9DD0
        public void ValidateFloat(){} // RVA: 0x7FFE86AEA0F0
        public void FloatingPointRemainder(){} // RVA: 0x7FFE86AEA6C0
        public void IsZero(){} // RVA: 0x7FFE86AEA730
        public void ValidatePropertyName(){} // RVA: 0x7FFE86AEA7A0
        public void IsPropertyDefinied(){} // RVA: 0x7FFE86AEAA00
        public void ValidateArray(){} // RVA: 0x7FFE86AEAC20
        public void ValidateObject(){} // RVA: 0x7FFE86AEAC40
        public void TestType(){} // RVA: 0x7FFE86AEAC60
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE86AEADB0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE86AEAE10
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE86AEAE70
        public void .cctor(){} // RVA: 0x7FFE86AEAED0
    }

    public class JsonWriter : Object
    {
        public dFixup.ÎÍÎÍÏÍÎ[][] StateArray;
        public dFixup.ÎÍÎÍÏÍÎ[][] StateArrayTemplate; // 0x8
        public System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition> _stack; // 0x10
        public Newtonsoft.Json.JsonPosition _currentPosition; // 0x18
        public dFixup.ÎÍÎÍÏÍÎ _currentState; // 0x30
        public 0x665BCB0C _formatting; // 0x34
        public bool _closeOutput; // 0x38
        public bool _autoCompleteOnClose; // 0x39
        public 0x665BC84C _dateFormatHandling; // 0x3C
        public 0x665BC8FC _dateTimeZoneHandling; // 0x40
        public 0x665BF3F4 _stringEscapeHandling; // 0x44
        public 0x665BCA5C _floatFormatHandling; // 0x48
        public string _dateFormatString; // 0x50

        // ── Methods ──
        public void AutoCompleteAsync(){} // RVA: 0x7FFE86AEBE50 | overloaded x2
        public void CloseAsync(){} // RVA: 0x7FFE86AEC060
        public void FlushAsync(){} // RVA: 0x7FFE86AEC140
        public void WriteEndAsync(){} // RVA: 0x7FFE86AEC6B0 | overloaded x2
        public void WriteIndentAsync(){} // RVA: 0x7FFE86AEC310
        public void WriteValueDelimiterAsync(){} // RVA: 0x7FFE86AEC3F0
        public void WriteIndentSpaceAsync(){} // RVA: 0x7FFE86AEC4D0
        public void WriteRawAsync(){} // RVA: 0x7FFE86AEC5B0
        public void WriteEndInternalAsync(){} // RVA: 0x7FFE86AEC790
        public void InternalWriteEndAsync(){} // RVA: 0x7FFE86AEC930
        public void WriteEndArrayAsync(){} // RVA: 0x7FFE86AECBB0
        public void WriteEndConstructorAsync(){} // RVA: 0x7FFE86AECC90
        public void WriteEndObjectAsync(){} // RVA: 0x7FFE86AECD70
        public void WriteNullAsync(){} // RVA: 0x7FFE86AECE50
        public void WritePropertyNameAsync(){} // RVA: 0x7FFE86AED030 | overloaded x2
        public void InternalWritePropertyNameAsync(){} // RVA: 0x7FFE86AED130
        public void WriteStartArrayAsync(){} // RVA: 0x7FFE86AED250
        public void InternalWriteStartAsync(){} // RVA: 0x7FFE86AED330
        public void WriteCommentAsync(){} // RVA: 0x7FFE86AED570
        public void InternalWriteCommentAsync(){} // RVA: 0x7FFE86AED670
        public void WriteRawValueAsync(){} // RVA: 0x7FFE86AED680
        public void WriteStartConstructorAsync(){} // RVA: 0x7FFE86AED780
        public void WriteStartObjectAsync(){} // RVA: 0x7FFE86AED880
        public void WriteTokenAsync(){} // RVA: 0x7FFE86AEE5D0 | overloaded x5
        public void WriteTokenSyncReadingAsync(){} // RVA: 0x7FFE86AEE860
        public void WriteConstructorDateAsync(){} // RVA: 0x7FFE86AEEAE0
        public void WriteValueAsync(){} // RVA: 0x7FFE86AF18D0 | overloaded x39
        public void WriteUndefinedAsync(){} // RVA: 0x7FFE86AF1340
        public void WriteWhitespaceAsync(){} // RVA: 0x7FFE86AF1420
        public void InternalWriteValueAsync(){} // RVA: 0x7FFE86AF1520
        public void SetWriteStateAsync(){} // RVA: 0x7FFE86AF15F0
        public void BuildStateArray(){} // RVA: 0x7FFE86AF2C50
        public void .cctor(){} // RVA: 0x7FFE86AF2F10
        public void get_CloseOutput(){} // RVA: 0x7FFE812CF770
        public void set_CloseOutput(){} // RVA: 0x7FFE812D0010
        public void get_AutoCompleteOnClose(){} // RVA: 0x7FFE812CF7D0
        public void set_AutoCompleteOnClose(){} // RVA: 0x7FFE812D0020
        public void get_Top(){} // RVA: 0x7FFE86AF32A0
        public void get_WriteState(){} // RVA: 0x7FFE86AF3300
        public void get_ContainerPath(){} // RVA: 0x7FFE86AF3420
        public void get_Path(){} // RVA: 0x7FFE86AF34C0
        public void get_Formatting(){} // RVA: 0x7FFE82447220
        public void set_Formatting(){} // RVA: 0x7FFE86AF3640
        public void get_DateFormatHandling(){} // RVA: 0x7FFE816311C0
        public void set_DateFormatHandling(){} // RVA: 0x7FFE86AF36B0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE8119C080
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE86AF3720
        public void get_StringEscapeHandling(){} // RVA: 0x7FFE8119C0A0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFE86AF3790
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFE810FB310
        public void get_FloatFormatHandling(){} // RVA: 0x7FFE8119C0C0
        public void set_FloatFormatHandling(){} // RVA: 0x7FFE86AF3810
        public void get_DateFormatString(){} // RVA: 0x7FFE8119C0E0
        public void set_DateFormatString(){} // RVA: 0x7FFE812534D0
        public void get_Culture(){} // RVA: 0x7FFE86AF3880
        public void set_Culture(){} // RVA: 0x7FFE811C3510
        public void .ctor(){} // RVA: 0x7FFE86AF38E0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFE86AF3900
        public void Push(){} // RVA: 0x7FFE86AF3910
        public void Pop(){} // RVA: 0x7FFE86AF3AC0
        public void Peek(){} // RVA: 0x7FFE813DB630
        public void Flush(){} // RVA: 0x7FFE80E45FE0
        public void Close(){} // RVA: 0x7FFE86AF3C30
        public void WriteStartObject(){} // RVA: 0x7FFE86AF3CA0
        public void WriteEndObject(){} // RVA: 0x7FFE86AF3CE0
        public void WriteStartArray(){} // RVA: 0x7FFE86AF3CF0
        public void WriteEndArray(){} // RVA: 0x7FFE86AF3D30
        public void WriteStartConstructor(){} // RVA: 0x7FFE86AF3D40
        public void WriteEndConstructor(){} // RVA: 0x7FFE86AF3D80
        public void WritePropertyName(){} // RVA: 0x7FFE86AF3E00 | overloaded x2
        public void WriteEnd(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void WriteToken(){} // RVA: 0x7FFE86AF4B00 | overloaded x5
        public void IsWriteTokenIncomplete(){} // RVA: 0x7FFE86AF4DE0
        public void CalculateWriteTokenInitialDepth(){} // RVA: 0x7FFE86AF4EB0
        public void CalculateWriteTokenFinalDepth(){} // RVA: 0x7FFE86AF4F20
        public void WriteConstructorDate(){} // RVA: 0x7FFE86AF4F90
        public void AutoCompleteAll(){} // RVA: 0x7FFE86AF5140
        public void GetCloseTokenForType(){} // RVA: 0x7FFE86AF51B0
        public void AutoCompleteClose(){} // RVA: 0x7FFE86AF5270
        public void CalculateLevelsToComplete(){} // RVA: 0x7FFE86AF5330
        public void UpdateCurrentState(){} // RVA: 0x7FFE86AF5460
        public void WriteIndent(){} // RVA: 0x7FFE810FB310
        public void WriteValueDelimiter(){} // RVA: 0x7FFE810FB310
        public void WriteIndentSpace(){} // RVA: 0x7FFE810FB310
        public void AutoComplete(){} // RVA: 0x7FFE86AF5530
        public void WriteNull(){} // RVA: 0x7FFE86AF5760
        public void WriteUndefined(){} // RVA: 0x7FFE86AF5780
        public void WriteRaw(){} // RVA: 0x7FFE810FB310
        public void WriteRawValue(){} // RVA: 0x7FFE86AF57A0
        public void WriteValue(){} // RVA: 0x7FFE86AF6510 | overloaded x39
        public void WriteComment(){} // RVA: 0x7FFE86AF6450
        public void WriteWhitespace(){} // RVA: 0x7FFE86AF6460
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE86AF6470
        public void Dispose(){} // RVA: 0x7FFE86AF64E0
        public void ResolveConvertibleValue(){} // RVA: 0x7FFE86AF7830
        public void CreateUnsupportedTypeException(){} // RVA: 0x7FFE86AF7A90
        public void SetWriteState(){} // RVA: 0x7FFE86AF7B90
        public void InternalWriteEnd(){} // RVA: 0x7FFE86AF5270
        public void InternalWritePropertyName(){} // RVA: 0x7FFE86AF3D90
        public void InternalWriteRaw(){} // RVA: 0x7FFE810FB310
        public void InternalWriteStart(){} // RVA: 0x7FFE86AF7E30
        public void InternalWriteValue(){} // RVA: 0x7FFE86AF7E70
        public void InternalWriteWhitespace(){} // RVA: 0x7FFE86AF7E90
        public void InternalWriteComment(){} // RVA: 0x7FFE86AF6450
        public void <InternalWriteEndAsync>g__AwaitProperty|11_0(){} // RVA: 0x7FFE86AF7F90
        public void <InternalWriteEndAsync>g__AwaitIndent|11_1(){} // RVA: 0x7FFE86AF8220
        public void <InternalWriteEndAsync>g__AwaitEnd|11_2(){} // RVA: 0x7FFE86AF84C0
        public void <InternalWriteEndAsync>g__AwaitRemaining|11_3(){} // RVA: 0x7FFE86AF8740
    }

    public class JsonWriterException : JsonException
    {
        public string _path; // 0x90

        // ── Methods ──
        public void get_Path(){} // RVA: 0x7FFE8154EB60
        public void .ctor(){} // RVA: 0x7FFE86AFC2E0 | overloaded x5
        public void Create(){} // RVA: 0x7FFE86AFC480 | overloaded x2
    }

}