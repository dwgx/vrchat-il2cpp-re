// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 22
// Methods: 321

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x87C160
        public void Return(){} // RVA: 0x894320
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x87D280
        public void get_LineNumber(){} // RVA: 0x87C130
        public void get_LinePosition(){} // RVA: 0x87C130
    }

    public class JsonContainerAttribute : Attribute
    {
        public object _itemConverterType;
        public object _itemConverterParameters;
        public object _namingStrategyInstance;
        public object _isReference;
        public object _itemIsReference;
        public object _itemReferenceLoopHandling;
        public object _itemTypeNameHandling;
        public object _namingStrategyType;
        public object _namingStrategyParameters;

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0xB5DBF0
        public void get_ItemConverterParameters(){} // RVA: 0xB465B0
        public void get_NamingStrategyType(){} // RVA: 0xBC1B30
        public void get_NamingStrategyParameters(){} // RVA: 0xBBF8F0
        public void get_NamingStrategyInstance(){} // RVA: 0xB700F0
        public void set_NamingStrategyInstance(){} // RVA: 0xB70100
    }

    public class JsonConvert : Object
    {
        public object _defaultSettings;
        public object True;
        public object False;
        public object Null;
        public object Undefined;
        public object PositiveInfinity;
        public object NegativeInfinity;
        public object NaN;

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x8146AD0
        public void ToString(){} // RVA: 0x8147620
        public void EnsureFloatFormat(){} // RVA: 0x8146E90
        public void EnsureDecimalPlace(){} // RVA: 0x8147270
        public void SerializeObject(){} // RVA: 0x81477F0
        public void SerializeObjectInternal(){} // RVA: 0x81478C0
        public void DeserializeObject(){} // RVA: 0x8147BB0
        public void .cctor(){} // RVA: 0x8147E80
    }

    public class JsonConverter : Object
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x8954D0
        public void ReadJson(){} // RVA: 0x88D2C0
        public void CanConvert(){} // RVA: 0x87D350
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonConverterAttribute : Attribute
    {
        public object _converterType;
        public object _converterParameters;

        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0xB5DBF0
        public void get_ConverterParameters(){} // RVA: 0xB465B0
    }

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8148240
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x81483A0
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        public object _writeData;
        public object _readData;

        // ── Methods ──
        public void get_WriteData(){} // RVA: 0xC120A0
        public void get_ReadData(){} // RVA: 0xDD5C50
    }

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public object _memberSerialization;
        public object _itemRequired;

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0xE32C80
    }

    public class JsonPosition : ValueType
    {
        public object SpecialCharacters;
        public object Type;
        public object Position;
        public object PropertyName;
        public object HasIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B1040
        public void CalculateLength(){} // RVA: 0x9B1050
        public void WriteTo(){} // RVA: 0x9B1060
        public void TypeHasIndex(){} // RVA: 0x69D09B0
        public void BuildPath(){} // RVA: 0x8148700
        public void FormatMessage(){} // RVA: 0x8148CD0
        public void .cctor(){} // RVA: 0x8149030
    }

    public class JsonPropertyAttribute : Attribute
    {
        public object _nullValueHandling;
        public object _defaultValueHandling;
        public object _referenceLoopHandling;
        public object _objectCreationHandling;
        public object _typeNameHandling;
        public object _isReference;
        public object _order;
        public object _required;
        public object _itemIsReference;
        public object _itemReferenceLoopHandling;
        public object _itemTypeNameHandling;
        public object _itemConverterType;
        public object _itemConverterParameters;
        public object _namingStrategyType;
        public object _namingStrategyParameters;
        public object _propertyName;

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0xBE2C60
        public void get_ItemConverterParameters(){} // RVA: 0xBBFF90
        public void get_NamingStrategyType(){} // RVA: 0xC10050
        public void get_NamingStrategyParameters(){} // RVA: 0xCD3320
        public void get_PropertyName(){} // RVA: 0xCD48B0
    }

    public class JsonReader : Object
    {
        public object _tokenType;
        public object _value;
        public object _quoteChar;
        public object _currentState;
        public object _currentPosition;
        public object _culture;
        public object _dateTimeZoneHandling;
        public object _maxDepth;
        public object _hasExceededMaxDepth;
        public object _dateParseHandling;
        public object _floatParseHandling;
        public object _dateFormatString;
        public object _stack;
        public object _closeInput;
        public object _supportMultipleContent;

        // ── Methods ──
        public void get_CurrentState(){} // RVA: 0x15AF000
        public void get_CloseInput(){} // RVA: 0xBC03E0
        public void set_CloseInput(){} // RVA: 0xBC03F0
        public void get_SupportMultipleContent(){} // RVA: 0x6529A10
        public void set_SupportMultipleContent(){} // RVA: 0x6529A20
        public void get_DateTimeZoneHandling(){} // RVA: 0xBE5890
        public void set_DateTimeZoneHandling(){} // RVA: 0x8149110
        public void get_DateParseHandling(){} // RVA: 0x12BB630
        public void set_DateParseHandling(){} // RVA: 0x8149180
        public void get_FloatParseHandling(){} // RVA: 0xE36310
        public void set_FloatParseHandling(){} // RVA: 0x81491F0
        public void get_DateFormatString(){} // RVA: 0xBE2C60
        public void set_DateFormatString(){} // RVA: 0xBE2C70
        public void get_MaxDepth(){} // RVA: 0x412F510
        public void set_MaxDepth(){} // RVA: 0x8149260
        public void get_TokenType(){} // RVA: 0xB8F8F0
        public void get_Value(){} // RVA: 0xB465B0
        public void get_ValueType(){} // RVA: 0x8149320
        public void get_Depth(){} // RVA: 0x8149340
        public void get_Path(){} // RVA: 0x81493C0
        public void get_Culture(){} // RVA: 0x8149540
        public void set_Culture(){} // RVA: 0xB6A8C0
        public void GetPosition(){} // RVA: 0x81495A0
        public void .ctor(){} // RVA: 0x8149660
        public void Push(){} // RVA: 0x8149680
        public void Pop(){} // RVA: 0x81499D0
        public void Peek(){} // RVA: 0x1065D50
        public void Read(){} // RVA: 0x87D280
        public void ReadAsInt32(){} // RVA: 0x8149B90
        public void ReadInt32String(){} // RVA: 0x8149E70
        public void ReadAsString(){} // RVA: 0x814A0D0
        public void ReadAsBytes(){} // RVA: 0x814A430
        public void ReadArrayIntoByteArray(){} // RVA: 0x814A920
        public void ReadAsDouble(){} // RVA: 0x814ACD0
        public void ReadDoubleString(){} // RVA: 0x814AFB0
        public void ReadAsBoolean(){} // RVA: 0x814B1D0
        public void ReadBooleanString(){} // RVA: 0x814B480
        public void ReadAsDecimal(){} // RVA: 0x814B720
        public void ReadDecimalString(){} // RVA: 0x814BA50
        public void ReadAsDateTime(){} // RVA: 0x814BD10
        public void ReadDateTimeString(){} // RVA: 0x814C020
        public void ReadAsDateTimeOffset(){} // RVA: 0x814C2A0
        public void ReadDateTimeOffsetString(){} // RVA: 0x814C590
        public void ReaderReadAndAssert(){} // RVA: 0x814C820
        public void CreateUnexpectedEndException(){} // RVA: 0x814C870
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x814C8C0
        public void Skip(){} // RVA: 0x814CC70
        public void SetToken(){} // RVA: 0x814CD70
        public void SetPostValueState(){} // RVA: 0x814CFB0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x69D7420
        public void ValidateEnd(){} // RVA: 0x814CFF0
        public void SetStateBasedOnCurrent(){} // RVA: 0x814D1B0
        public void SetFinished(){} // RVA: 0x814D2C0
        public void GetTypeForCloseToken(){} // RVA: 0x814D2E0
        public void System.IDisposable.Dispose(){} // RVA: 0x814D3D0
        public void Dispose(){} // RVA: 0x814D440
        public void Close(){} // RVA: 0x69D78B0
        public void ReadAndAssert(){} // RVA: 0x814D470
        public void ReadAndMoveToContent(){} // RVA: 0x814D4D0
        public void MoveToContent(){} // RVA: 0x814D530
        public void GetContentToken(){} // RVA: 0x814D590
    }

    public class JsonReaderException : JsonException
    {
        public object _lineNumber;
        public object _linePosition;
        public object _path;

        // ── Methods ──
        public void set_LineNumber(){} // RVA: 0x17AFA20
        public void set_LinePosition(){} // RVA: 0x11A0AB0
        public void set_Path(){} // RVA: 0xD5CC70
        public void .ctor(){} // RVA: 0x814D600
        public void Create(){} // RVA: 0x814D880
    }

    public class JsonSerializationException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x81483A0
        public void Create(){} // RVA: 0x814DB50
    }

    public class JsonSerializer : Object
    {
        public object _typeNameHandling;
        public object _typeNameAssemblyFormat;
        public object _preserveReferencesHandling;
        public object _referenceLoopHandling;
        public object _missingMemberHandling;
        public object _objectCreationHandling;
        public object _nullValueHandling;
        public object _defaultValueHandling;
        public object _constructorHandling;
        public object _metadataPropertyHandling;
        public object _converters;
        public object _contractResolver;
        public object _traceWriter;
        public object _equalityComparer;
        public object _binder;
        public object _context;
        public object _referenceResolver;
        public object _formatting;
        public object _dateFormatHandling;
        public object _dateTimeZoneHandling;
        public object _dateParseHandling;
        public object _floatFormatHandling;
        public object _floatParseHandling;
        public object _stringEscapeHandling;
        public object _culture;
        public object _maxDepth;
        public object _maxDepthSet;
        public object _checkAdditionalContent;
        public object _dateFormatString;
        public object _dateFormatStringSet;
        public object Error;

        // ── Methods ──
        public void add_Error(){} // RVA: 0x814DC10
        public void remove_Error(){} // RVA: 0x814DD30
        public void set_ReferenceResolver(){} // RVA: 0x814DE50
        public void set_Binder(){} // RVA: 0x814DF20
        public void get_TraceWriter(){} // RVA: 0xBBF8F0
        public void set_TraceWriter(){} // RVA: 0xBBF900
        public void set_EqualityComparer(){} // RVA: 0xCA4DF0
        public void set_TypeNameHandling(){} // RVA: 0x814DFF0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x814E060
        public void set_PreserveReferencesHandling(){} // RVA: 0x814E0D0
        public void set_ReferenceLoopHandling(){} // RVA: 0x814E140
        public void set_MissingMemberHandling(){} // RVA: 0x814E1B0
        public void set_NullValueHandling(){} // RVA: 0x814E220
        public void set_DefaultValueHandling(){} // RVA: 0x814E290
        public void set_ObjectCreationHandling(){} // RVA: 0x814E300
        public void set_ConstructorHandling(){} // RVA: 0x814E370
        public void get_MetadataPropertyHandling(){} // RVA: 0xE9CE60
        public void set_MetadataPropertyHandling(){} // RVA: 0x814E3E0
        public void get_Converters(){} // RVA: 0x814E450
        public void get_ContractResolver(){} // RVA: 0xBC1B30
        public void set_ContractResolver(){} // RVA: 0x814E530
        public void get_Context(){} // RVA: 0x4127D80
        public void set_Context(){} // RVA: 0x69DA8C0
        public void get_Formatting(){} // RVA: 0x814E5F0
        public void set_Formatting(){} // RVA: 0x814E650
        public void get_CheckAdditionalContent(){} // RVA: 0x814E6B0
        public void set_CheckAdditionalContent(){} // RVA: 0x814E710
        public void IsCheckAdditionalContentSet(){} // RVA: 0x814E770
        public void .ctor(){} // RVA: 0x814E7C0
        public void Create(){} // RVA: 0x814EAB0
        public void CreateDefault(){} // RVA: 0x814EC20
        public void ApplySerializerSettings(){} // RVA: 0x814EC60
        public void Deserialize(){} // RVA: 0x814F820
        public void DeserializeInternal(){} // RVA: 0x814F840
        public void SetupReader(){} // RVA: 0x814FB40
        public void ResetReader(){} // RVA: 0x8150130
        public void Serialize(){} // RVA: 0x81503F0
        public void SerializeInternal(){} // RVA: 0x8150420
        public void GetReferenceResolver(){} // RVA: 0x8150BE0
        public void GetMatchingConverter(){} // RVA: 0x8150C90
        public void OnError(){} // RVA: 0x69DDB90
    }

    public class JsonSerializerSettings : Object
    {
        public object DefaultContext;
        public object DefaultCulture;
        public object _formatting;
        public object _dateFormatHandling;
        public object _dateTimeZoneHandling;
        public object _dateParseHandling;
        public object _floatFormatHandling;
        public object _floatParseHandling;
        public object _stringEscapeHandling;
        public object _culture;
        public object _checkAdditionalContent;
        public object _maxDepth;
        public object _maxDepthSet;
        public object _dateFormatString;
        public object _dateFormatStringSet;
        public object _typeNameAssemblyFormat;
        public object _defaultValueHandling;
        public object _preserveReferencesHandling;
        public object _nullValueHandling;
        public object _objectCreationHandling;
        public object _missingMemberHandling;
        public object _referenceLoopHandling;
        public object _context;
        public object _constructorHandling;
        public object _typeNameHandling;
        public object _metadataPropertyHandling;
        public object _converters;
        public object _contractResolver;
        public object _equalityComparer;
        public object _referenceResolverProvider;
        public object _traceWriter;
        public object _binder;
        public object _error;

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x8150D60
        public void get_MissingMemberHandling(){} // RVA: 0x8150DC0
        public void get_ObjectCreationHandling(){} // RVA: 0x8150E20
        public void get_NullValueHandling(){} // RVA: 0x8150E80
        public void set_NullValueHandling(){} // RVA: 0x8150EE0
        public void get_DefaultValueHandling(){} // RVA: 0x8150F40
        public void get_Converters(){} // RVA: 0x135D730
        public void set_Converters(){} // RVA: 0xBC5AD0
        public void get_PreserveReferencesHandling(){} // RVA: 0x8150FA0
        public void get_TypeNameHandling(){} // RVA: 0x8151000
        public void get_MetadataPropertyHandling(){} // RVA: 0x8151060
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x81510C0
        public void get_ConstructorHandling(){} // RVA: 0x8151120
        public void get_ContractResolver(){} // RVA: 0xBC5B30
        public void get_EqualityComparer(){} // RVA: 0xBC5BA0
        public void get_ReferenceResolverProvider(){} // RVA: 0xBAE5A0
        public void get_TraceWriter(){} // RVA: 0x135A7B0
        public void get_Binder(){} // RVA: 0x10B4170
        public void get_Error(){} // RVA: 0x10B9D50
        public void get_Context(){} // RVA: 0x8151180
        public void .cctor(){} // RVA: 0x8151250
        public void .ctor(){} // RVA: 0x8151370
    }

    public class JsonTextReader : JsonReader
    {
        public object _reader;
        public object _chars;
        public object _charsUsed;
        public object _charPos;
        public object _lineStartPos;
        public object _lineNumber;
        public object _isEndOfFile;
        public object _stringBuffer;
        public object _stringReference;
        public object _arrayPool;
        public object NameTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8151430
        public void EnsureBufferNotEmpty(){} // RVA: 0x8151510
        public void OnNewLine(){} // RVA: 0x8151660
        public void ParseString(){} // RVA: 0x8151670
        public void BlockCopyChars(){} // RVA: 0x69E5CD0
        public void ShiftBufferIfNeeded(){} // RVA: 0x8151A50
        public void ReadData(){} // RVA: 0x8151B40
        public void EnsureChars(){} // RVA: 0x8151EF0
        public void ReadChars(){} // RVA: 0x8151FA0
        public void Read(){} // RVA: 0x8152030
        public void ReadAsInt32(){} // RVA: 0x8152430
        public void ReadAsDateTime(){} // RVA: 0x8152520
        public void ReadAsString(){} // RVA: 0x8152610
        public void ReadAsBytes(){} // RVA: 0x8152650
        public void ReadStringValue(){} // RVA: 0x8153210
        public void CreateUnexpectedCharacterException(){} // RVA: 0x81543A0
        public void ReadAsBoolean(){} // RVA: 0x81544A0
        public void ProcessValueComma(){} // RVA: 0x81550B0
        public void ReadNumberValue(){} // RVA: 0x8155110
        public void ReadAsDateTimeOffset(){} // RVA: 0x8155FD0
        public void ReadAsDecimal(){} // RVA: 0x81560D0
        public void ReadAsDouble(){} // RVA: 0x81561D0
        public void HandleNull(){} // RVA: 0x81562C0
        public void ReadFinished(){} // RVA: 0x81563D0
        public void ReadNullChar(){} // RVA: 0x8156520
        public void EnsureBuffer(){} // RVA: 0x8156570
        public void ReadStringIntoBuffer(){} // RVA: 0x8156680
        public void WriteCharToBuffer(){} // RVA: 0x8156D20
        public void ParseUnicode(){} // RVA: 0x8156DD0
        public void ReadNumberIntoBuffer(){} // RVA: 0x8157080
        public void ClearRecentString(){} // RVA: 0x81572A0
        public void ParsePostValue(){} // RVA: 0x81572C0
        public void ParseObject(){} // RVA: 0x81575C0
        public void ParseProperty(){} // RVA: 0x8157750
        public void ValidIdentifierChar(){} // RVA: 0x69EB000
        public void ParseUnquotedProperty(){} // RVA: 0x8157A30
        public void ParseValue(){} // RVA: 0x8157DB0
        public void ProcessLineFeed(){} // RVA: 0x8158570
        public void ProcessCarriageReturn(){} // RVA: 0x8158590
        public void EatWhitespace(){} // RVA: 0x8158660
        public void ParseConstructor(){} // RVA: 0x8158780
        public void ParseNumber(){} // RVA: 0x8158C10
        public void ParseComment(){} // RVA: 0x815A430
        public void EndComment(){} // RVA: 0x815A7B0
        public void MatchValue(){} // RVA: 0x815A800
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x815A8F0
        public void IsSeparator(){} // RVA: 0x815AB80
        public void ParseTrue(){} // RVA: 0x815ACB0
        public void ParseNull(){} // RVA: 0x815AD80
        public void ParseUndefined(){} // RVA: 0x815AE40
        public void ParseFalse(){} // RVA: 0x815AF00
        public void ParseNumberNegativeInfinity(){} // RVA: 0x815B080
        public void ParseNumberPositiveInfinity(){} // RVA: 0x815B240
        public void ParseNumberNaN(){} // RVA: 0x815B400
        public void Close(){} // RVA: 0x815B5C0
        public void HasLineInfo(){} // RVA: 0xC2E4C0
        public void get_LineNumber(){} // RVA: 0x815B740
        public void get_LinePosition(){} // RVA: 0x815B790
    }

    public class JsonTextWriter : JsonWriter
    {
        public object _writer;
        public object _base64Encoder;
        public object _indentChar;
        public object _indentation;
        public object _quoteChar;
        public object _quoteName;
        public object _charEscapeFlags;
        public object _writeBuffer;
        public object _arrayPool;
        public object _indentChars;

        // ── Methods ──
        public void get_Base64Encoder(){} // RVA: 0x815B7A0
        public void get_QuoteChar(){} // RVA: 0x6A0DA10
        public void .ctor(){} // RVA: 0x815B9A0
        public void Close(){} // RVA: 0x815BAC0
        public void WriteStartObject(){} // RVA: 0x815BBD0
        public void WriteStartArray(){} // RVA: 0x815BC20
        public void WriteStartConstructor(){} // RVA: 0x815BC70
        public void WriteEnd(){} // RVA: 0x815BD30
        public void WritePropertyName(){} // RVA: 0x815BED0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x815C000
        public void UpdateCharEscapeFlags(){} // RVA: 0x815C010
        public void WriteIndent(){} // RVA: 0x815C0E0
        public void WriteValueDelimiter(){} // RVA: 0x815C300
        public void WriteIndentSpace(){} // RVA: 0x815C330
        public void WriteValueInternal(){} // RVA: 0x815C360
        public void WriteNull(){} // RVA: 0x815C390
        public void WriteUndefined(){} // RVA: 0x815C430
        public void WriteRaw(){} // RVA: 0x815C360
        public void WriteValue(){} // RVA: 0x815DC20
        public void WriteEscapedString(){} // RVA: 0x815C5A0
        public void WriteComment(){} // RVA: 0x815DD20
        public void EnsureWriteBuffer(){} // RVA: 0x815DDF0
        public void WriteIntegerValue(){} // RVA: 0x815DF70
    }

    public class JsonWriter : Object
    {
        public object StateArray;
        public object StateArrayTempate;
        public object _stack;
        public object _currentPosition;
        public object _currentState;
        public object _formatting;
        public object _closeOutput;
        public object _dateFormatHandling;
        public object _dateTimeZoneHandling;
        public object _stringEscapeHandling;
        public object _floatFormatHandling;
        public object _dateFormatString;
        public object _culture;

        // ── Methods ──
        public void BuildStateArray(){} // RVA: 0x815E0A0
        public void .cctor(){} // RVA: 0x815E4E0
        public void get_CloseOutput(){} // RVA: 0xD16660
        public void set_CloseOutput(){} // RVA: 0xD14C10
        public void get_Top(){} // RVA: 0x815ECB0
        public void get_WriteState(){} // RVA: 0x815ED10
        public void get_ContainerPath(){} // RVA: 0x815EE20
        public void get_Path(){} // RVA: 0x815EEB0
        public void get_Formatting(){} // RVA: 0xE9CE60
        public void set_Formatting(){} // RVA: 0x815F030
        public void get_DateFormatHandling(){} // RVA: 0x114DAD0
        public void set_DateFormatHandling(){} // RVA: 0x815F0A0
        public void get_DateTimeZoneHandling(){} // RVA: 0xBE5850
        public void set_DateTimeZoneHandling(){} // RVA: 0x815F110
        public void get_StringEscapeHandling(){} // RVA: 0xBE5870
        public void set_StringEscapeHandling(){} // RVA: 0x815F180
        public void OnStringEscapeHandlingChanged(){} // RVA: 0xB43310
        public void get_FloatFormatHandling(){} // RVA: 0xBE5890
        public void set_FloatFormatHandling(){} // RVA: 0x815F200
        public void get_DateFormatString(){} // RVA: 0xBE58B0
        public void set_DateFormatString(){} // RVA: 0xCA4DF0
        public void get_Culture(){} // RVA: 0x815F270
        public void set_Culture(){} // RVA: 0xC0FFD0
        public void .ctor(){} // RVA: 0x815F2D0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x6A27680
        public void Push(){} // RVA: 0x815F2F0
        public void Pop(){} // RVA: 0x815F4A0
        public void Peek(){} // RVA: 0xE62D00
        public void Close(){} // RVA: 0x815F620
        public void WriteStartObject(){} // RVA: 0x815F690
        public void WriteEndObject(){} // RVA: 0x815F6A0
        public void WriteStartArray(){} // RVA: 0x815F6B0
        public void WriteEndArray(){} // RVA: 0x815F6C0
        public void WriteStartConstructor(){} // RVA: 0x815F6D0
        public void WriteEndConstructor(){} // RVA: 0x815F6E0
        public void WritePropertyName(){} // RVA: 0x6ABC570
        public void WriteEnd(){} // RVA: 0xB43310
        public void WriteToken(){} // RVA: 0x81603A0
        public void WriteConstructorDate(){} // RVA: 0x8160630
        public void AutoCompleteAll(){} // RVA: 0x815F620
        public void GetCloseTokenForType(){} // RVA: 0x81609C0
        public void AutoCompleteClose(){} // RVA: 0x8160A70
        public void WriteIndent(){} // RVA: 0xB43310
        public void WriteValueDelimiter(){} // RVA: 0xB43310
        public void WriteIndentSpace(){} // RVA: 0xB43310
        public void AutoComplete(){} // RVA: 0x8160EC0
        public void WriteNull(){} // RVA: 0x81610F0
        public void WriteUndefined(){} // RVA: 0x8161110
        public void WriteRaw(){} // RVA: 0xB43310
        public void WriteRawValue(){} // RVA: 0x8161130
        public void WriteValue(){} // RVA: 0x8161D50
        public void WriteComment(){} // RVA: 0x8161CA0
        public void System.IDisposable.Dispose(){} // RVA: 0x8161CB0
        public void Dispose(){} // RVA: 0x8161D20
        public void CreateUnsupportedTypeException(){} // RVA: 0x8162FB0
        public void InternalWriteEnd(){} // RVA: 0x81630B0
        public void InternalWritePropertyName(){} // RVA: 0x815F6F0
        public void InternalWriteRaw(){} // RVA: 0xB43310
        public void InternalWriteStart(){} // RVA: 0x81630C0
        public void InternalWriteValue(){} // RVA: 0x8163280
        public void InternalWriteComment(){} // RVA: 0x8161CA0
    }

    public class JsonWriterException : JsonException
    {
        public object _path;

        // ── Methods ──
        public void set_Path(){} // RVA: 0xD5CC10
        public void .ctor(){} // RVA: 0x8163300
        public void Create(){} // RVA: 0x8163490
    }

}