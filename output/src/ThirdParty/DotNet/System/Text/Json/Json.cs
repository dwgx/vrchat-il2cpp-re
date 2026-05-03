// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json
// Classes: 37
// Methods: 1043

namespace ThirdParty.DotNet.System.Text.Json
{
    public class AppContextSwitchHelper : Object
    {
        public bool _isSourceGenReflectionFallbackEnabled;

        // ── Methods ──
        public void get_IsSourceGenReflectionFallbackEnabled(){} // RVA: 0x7FFE8738D130
        public void .cctor(){} // RVA: 0x7FFE8738D190
    }

    public class ArgumentState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Arguments`4 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class BitStack : ValueType
    {
        public int[] _array; // 0x10

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x7FFE811485C0
        public void PushTrue(){} // RVA: 0x7FFE86E412C0
        public void PushFalse(){} // RVA: 0x7FFE86E41300
        public void PushToArray(){} // RVA: 0x7FFE86E41340
        public void Pop(){} // RVA: 0x7FFE86E41460
        public void PopFromArray(){} // RVA: 0x7FFE86E41490
        public void DoubleArray(){} // RVA: 0x7FFE86E414E0
        public void SetFirstBit(){} // RVA: 0x7FFE86E41580
        public void ResetFirstBit(){} // RVA: 0x7FFE86E41590
        public void Div32Rem(){} // RVA: 0x7FFE86E415A0
    }

    public class JsonCamelCaseNamingPolicy : JsonNamingPolicy
    {
        // ── Methods ──
        public void ConvertName(){} // RVA: 0x7FFE86E3E800
        public void FixCasing(){} // RVA: 0x7FFE86E3E920
        public void .ctor(){} // RVA: 0x7FFE86E3EAC0
    }

    public class JsonConstants : Object
    {
        public string DoubleFormatString;
        public string SingleFormatString;
        public int StackallocByteThreshold;
        public int StackallocCharThreshold;
        public byte OpenBrace;
        public byte CloseBrace;
        public byte OpenBracket;
        public byte CloseBracket;
        public byte Space;

        // ── Methods ──
        public void get_Utf8Bom(){} // RVA: 0x7FFE86E3EC60
        public void get_TrueValue(){} // RVA: 0x7FFE86E3ECD0
        public void get_FalseValue(){} // RVA: 0x7FFE86E3ED40
        public void get_NullValue(){} // RVA: 0x7FFE86E3EDB0
        public void get_NaNValue(){} // RVA: 0x7FFE86E3EE20
        public void get_PositiveInfinityValue(){} // RVA: 0x7FFE86E3EE90
        public void get_NegativeInfinityValue(){} // RVA: 0x7FFE86E3EF00
        public void get_Delimiters(){} // RVA: 0x7FFE86E3EF70
        public void get_EscapableChars(){} // RVA: 0x7FFE86E3EFE0
    }

    public class JsonDocument : Object
    {
        public System.ReadOnlyMemory`1<byte> _utf8Json; // 0x10
        public MetadataDb _parsedData; // 0x20

        // ── Methods ──
        public void get_IsDisposable(){} // RVA: 0x7FFE82976380
        public void get_RootElement(){} // RVA: 0x7FFE86E415B0
        public void .ctor(){} // RVA: 0x7FFE86E41620
        public void Dispose(){} // RVA: 0x7FFE86E417D0
        public void WriteTo(){} // RVA: 0x7FFE86E41A20
        public void GetJsonTokenType(){} // RVA: 0x7FFE86E41B20
        public void GetArrayLength(){} // RVA: 0x7FFE86E41B50
        public void GetArrayIndexElement(){} // RVA: 0x7FFE86E41BD0
        public void GetEndIndex(){} // RVA: 0x7FFE86E41DA0
        public void GetRawValue(){} // RVA: 0x7FFE86E41E20
        public void GetPropertyRawValue(){} // RVA: 0x7FFE86E42050
        public void GetString(){} // RVA: 0x7FFE86E42320
        public void TextEquals(){} // RVA: 0x7FFE86E42600
        public void GetNameOfPropertyValue(){} // RVA: 0x7FFE86E42B20
        public void TryGetValue(){} // RVA: 0x7FFE86E437B0 | overloaded x6
        public void GetRawValueAsString(){} // RVA: 0x7FFE86E43AC0
        public void GetPropertyRawValueAsString(){} // RVA: 0x7FFE86E43B80
        public void CloneElement(){} // RVA: 0x7FFE86E43C40
        public void WriteElementTo(){} // RVA: 0x7FFE86E43FC0
        public void WriteComplexElement(){} // RVA: 0x7FFE86E445F0
        public void UnescapeString(){} // RVA: 0x7FFE86E448C0
        public void ClearAndReturn(){} // RVA: 0x7FFE86E44F70
        public void WritePropertyName(){} // RVA: 0x7FFE86E45140
        public void WriteString(){} // RVA: 0x7FFE86E45360
        public void Parse(){} // RVA: 0x7FFE86E477D0 | overloaded x6
        public void CheckNotDisposed(){} // RVA: 0x7FFE86E45830
        public void CheckExpectedType(){} // RVA: 0x7FFE86E458C0
        public void CheckSupportedOptions(){} // RVA: 0x7FFE86E45910
        public void ParseAsync(){} // RVA: 0x7FFE86E45C50
        public void ParseAsyncCore(){} // RVA: 0x7FFE86E45CC0
        public void ParseValue(){} // RVA: 0x7FFE86E463B0
        public void TryParseValue(){} // RVA: 0x7FFE86E463E0
        public void CreateForLiteral(){} // RVA: 0x7FFE86E47480
        public void ParseUnrented(){} // RVA: 0x7FFE86E47A10
        public void ReadToEnd(){} // RVA: 0x7FFE86E47CF0
        public void ReadToEndAsync(){} // RVA: 0x7FFE86E48460
        public void TryGetNamedPropertyValue(){} // RVA: 0x7FFE86E48E00 | overloaded x2
        public void <CreateForLiteral>g__Create|74_0(){} // RVA: 0x7FFE86E49880
    }

    public class JsonDocumentOptions : ValueType
    {
        public int _maxDepth; // 0x10
        public 0x66616BB4 _commentHandling; // 0x14
        public bool _allowTrailingCommas; // 0x15

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x7FFE82C770F0
        public void get_MaxDepth(){} // RVA: 0x7FFE826F4220
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFE82C77100
        public void GetReaderOptions(){} // RVA: 0x7FFE86E4CEE0
    }

    public class JsonElement : ValueType
    {
        public System.Text.Json.JsonDocument _parent; // 0x10
        public int _idx; // 0x18
        public object field_2; // 0x2378

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815AE520
        public void get_TokenType(){} // RVA: 0x7FFE86E4CF80
        public void get_ValueKind(){} // RVA: 0x7FFE86E4CFC0
        public void get_Item(){} // RVA: 0x7FFE86E4D0B0
        public void GetArrayLength(){} // RVA: 0x7FFE86E4D130
        public void GetProperty(){} // RVA: 0x7FFE86E4D1F0
        public void TryGetProperty(){} // RVA: 0x7FFE86E4D3E0 | overloaded x2
        public void GetBoolean(){} // RVA: 0x7FFE86E4D460
        public void GetString(){} // RVA: 0x7FFE86E4D4F0
        public void TryGetInt16(){} // RVA: 0x7FFE86E4D560
        public void GetInt16(){} // RVA: 0x7FFE86E4D5D0
        public void TryGetInt32(){} // RVA: 0x7FFE86E4D680
        public void GetInt32(){} // RVA: 0x7FFE86E4D6F0
        public void TryGetInt64(){} // RVA: 0x7FFE86E4D780
        public void GetInt64(){} // RVA: 0x7FFE86E4D7F0
        public void TryGetDouble(){} // RVA: 0x7FFE86E4D890
        public void GetDouble(){} // RVA: 0x7FFE86E4D900
        public void TryGetSingle(){} // RVA: 0x7FFE86E4D9A0
        public void GetSingle(){} // RVA: 0x7FFE86E4DA10
        public void TryGetDateTimeOffset(){} // RVA: 0x7FFE86E4DAB0
        public void GetDateTimeOffset(){} // RVA: 0x7FFE86E4DB20
        public void GetPropertyName(){} // RVA: 0x7FFE86E4DBC0
        public void GetPropertyRawText(){} // RVA: 0x7FFE86E4DC30
        public void TextEqualsHelper(){} // RVA: 0x7FFE86E4DD30
        public void WriteTo(){} // RVA: 0x7FFE86E4DDC0
        public void EnumerateArray(){} // RVA: 0x7FFE86E4DE70
        public void EnumerateObject(){} // RVA: 0x7FFE86E4DF50
        public void ToString(){} // RVA: 0x7FFE86E4E030
        public void Clone(){} // RVA: 0x7FFE86E4E250
        public void CheckValidInstance(){} // RVA: 0x7FFE86E4E2E0
        public void ParseValue(){} // RVA: 0x7FFE86E4E340
    }

    public class JsonEncodedText : ValueType
    {
        public byte[] _utf8Value; // 0x10

        // ── Methods ──
        public void get_EncodedUtf8Bytes(){} // RVA: 0x7FFE86E4EC70
        public void .ctor(){} // RVA: 0x7FFE86E4ED10
        public void Encode(){} // RVA: 0x7FFE86E4F010 | overloaded x2
        public void TranscodeAndEncode(){} // RVA: 0x7FFE86E4F0E0
        public void EncodeHelper(){} // RVA: 0x7FFE86E4F5E0
        public void Equals(){} // RVA: 0x7FFE86E4F770 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86E4F850
        public void GetHashCode(){} // RVA: 0x7FFE86E4F8A0
    }

    public class JsonException : Exception
    {
        public string _message; // 0x90
        public bool _appendPathInformation; // 0x98
        public System.Nullable`1<long> _lineNumber; // 0xA0
        public System.Nullable`1<long> _bytePositionInLine; // 0xB0
        public string _path; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E4FBF0 | overloaded x5
        public void get_AppendPathInformation(){} // RVA: 0x7FFE81611920
        public void set_AppendPathInformation(){} // RVA: 0x7FFE81611930
        public void GetObjectData(){} // RVA: 0x7FFE86E4FFF0
        public void get_LineNumber(){} // RVA: 0x7FFE86C70870
        public void set_LineNumber(){} // RVA: 0x7FFE86C70880
        public void get_BytePositionInLine(){} // RVA: 0x7FFE817DEEA0
        public void set_BytePositionInLine(){} // RVA: 0x7FFE817DD430
        public void get_Path(){} // RVA: 0x7FFE81166120
        public void set_Path(){} // RVA: 0x7FFE81166130
        public void get_Message(){} // RVA: 0x7FFE86E505D0
        public void SetMessage(){} // RVA: 0x7FFE818CE320
    }

    public class JsonHelpers : Object
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFE80E329F0
        public void GetSpan(){} // RVA: 0x7FFE86E3F050
        public void IsInRangeInclusive(){} // RVA: 0x7FFE86E3F140 | overloaded x3
        public void IsDigit(){} // RVA: 0x7FFE86E3F150
        public void ReadWithVerify(){} // RVA: 0x7FFE86E3F160
        public void Utf8GetString(){} // RVA: 0x7FFE86E3F170
        public void CreateDictionaryFromCollection(){} // RVA: 0x7FFE80E2E440
        public void IsFinite(){} // RVA: 0x7FFE86E3F230 | overloaded x2
        public void ValidateInt32MaxArrayLength(){} // RVA: 0x7FFE86E3F260
        public void IsValidDateTimeOffsetParseLength(){} // RVA: 0x7FFE86E3F280
        public void TryParseAsISO(){} // RVA: 0x7FFE86E3F4A0 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFE86E3F620
        public void TryGetNextTwoDigits(){} // RVA: 0x7FFE86E3FD50
        public void TryCreateDateTimeOffset(){} // RVA: 0x7FFE86E3FF50 | overloaded x2
        public void TryCreateDateTimeOffsetInterpretingDataAsLocalTime(){} // RVA: 0x7FFE86E40060
        public void TryCreateDateTime(){} // RVA: 0x7FFE86E40160
        public void GetEscapedPropertyNameSection(){} // RVA: 0x7FFE86E408F0 | overloaded x2
        public void EscapeValue(){} // RVA: 0x7FFE86E405A0
        public void GetPropertyNameSection(){} // RVA: 0x7FFE86E40D00
        public void .cctor(){} // RVA: 0x7FFE86E40EB0
        public void <TryParseDateTimeOffset>g__ParseOffset|22_0(){} // RVA: 0x7FFE86E41050
    }

    public class JsonKebabCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8738C450
    }

    public class JsonKebabCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8738C4A0
    }

    public class JsonNamingPolicy : Object
    {
        public System.Text.Json.JsonNamingPolicy _camelCase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_CamelCase(){} // RVA: 0x7FFE86E3EB10
        public void ConvertName(){} // RVA: 0x7FFE80E2E390
        public void .cctor(){} // RVA: 0x7FFE86E3EB70
    }

    public class JsonProperty : ValueType
    {
        public System.Text.Json.JsonElement _value; // 0x10
        public string __name; // 0x20
        public object field_2; // 0xC0

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE8151C410
        public void get__name(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE84454C50
        public void get_Name(){} // RVA: 0x7FFE86E4EB40
        public void EscapedNameEquals(){} // RVA: 0x7FFE86E4EBC0
        public void ToString(){} // RVA: 0x7FFE86E4EC50
    }

    public class JsonPropertyDictionary`1 : Object
    {
        public System.Collections.Generic.Dictionary`2<string,T> _propertyDictionary;
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<string,T>> _propertyList;
        public System.StringComparer _stringComparer;
        public bool _isReadOnly;
        public KeyCollection<T> _keyCollection;
        public ValueCollection<T> _valueCollection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46C70 | overloaded x2
        public void get_List(){} // RVA: 0x7FFE80E2E2E0
        public void Add(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void ContainsKey(){} // RVA: 0x7FFE80E2F3B0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetValue(){} // RVA: 0x7FFE80E32650
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void SetValue(){} // RVA: 0x7FFE810A1420
        public void AddValue(){} // RVA: 0x7FFE810A1420
        public void TryAddValue(){} // RVA: 0x7FFE810A1420
        public void CreateDictionaryIfThresholdMet(){} // RVA: 0x7FFE80E45FE0
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void ContainsProperty(){} // RVA: 0x7FFE80E2F3B0
        public void FindValueIndex(){} // RVA: 0x7FFE80E33B00
        public void TryGetPropertyValue(){} // RVA: 0x7FFE80E32650
        public void TryRemoveProperty(){} // RVA: 0x7FFE80E32650
        public void GetKeyCollection(){} // RVA: 0x7FFE80E2E2E0
        public void GetValueCollection(){} // RVA: 0x7FFE80E2E2E0
    }

    public class JsonReaderException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E50780 | overloaded x2
    }

    public class JsonReaderHelper : Object
    {
        // ── Methods ──
        public void ContainsSpecialCharacters(){} // RVA: 0x7FFE8739F7D0
        public void CountNewLines(){} // RVA: 0x7FFE8739F890
        public void ToValueKind(){} // RVA: 0x7FFE86E50890
        public void IsTokenTypePrimitive(){} // RVA: 0x7FFE86E508F0
        public void IsHexDigit(){} // RVA: 0x7FFE8739FA40
        public void TryGetEscapedDateTime(){} // RVA: 0x7FFE8739FA70
        public void TryGetEscapedDateTimeOffset(){} // RVA: 0x7FFE8739FC90
        public void TryGetEscapedGuid(){} // RVA: 0x7FFE8739FEC0
        public void TryGetFloatingPointConstant(){} // RVA: 0x7FFE873A0420 | overloaded x2
        public void TryGetUnescapedBase64Bytes(){} // RVA: 0x7FFE873A06E0
        public void GetUnescapedString(){} // RVA: 0x7FFE873A0B60
        public void GetUnescapedSpan(){} // RVA: 0x7FFE873A0EA0
        public void UnescapeAndCompare(){} // RVA: 0x7FFE873A15D0 | overloaded x2
        public void TryDecodeBase64InPlace(){} // RVA: 0x7FFE873A1BB0
        public void TryDecodeBase64(){} // RVA: 0x7FFE873A1D60
        public void TranscodeHelper(){} // RVA: 0x7FFE873A2360 | overloaded x2
        public void ValidateUtf8(){} // RVA: 0x7FFE873A2550
        public void GetUtf8ByteCount(){} // RVA: 0x7FFE873A2690
        public void GetUtf8FromText(){} // RVA: 0x7FFE873A27D0
        public void GetTextFromUtf8(){} // RVA: 0x7FFE873A29A0
        public void Unescape(){} // RVA: 0x7FFE873A2C30 | overloaded x2
        public void TryUnescape(){} // RVA: 0x7FFE873A2DA0 | overloaded x2
        public void TryEncodeToUtf8Bytes(){} // RVA: 0x7FFE873A37B0
        public void IndexOfQuoteOrAnyControlOrBackSlash(){} // RVA: 0x7FFE873A3950
        public void LocateFirstFoundByte(){} // RVA: 0x7FFE86E01B80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE873A3DC0
    }

    public class JsonReaderOptions : ValueType
    {
        public int _maxDepth; // 0x10
        public 0x66616BB4 _commentHandling; // 0x14
        public bool _allowTrailingCommas; // 0x15

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x7FFE82C770F0
        public void set_CommentHandling(){} // RVA: 0x7FFE86E54990
        public void get_MaxDepth(){} // RVA: 0x7FFE826F4220
        public void set_MaxDepth(){} // RVA: 0x7FFE86E549E0
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFE82C77100
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFE81E63F70
    }

    public class JsonReaderState : ValueType
    {
        public long _lineNumber; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E54A30
        public void get_Options(){} // RVA: 0x7FFE810FE7C0
    }

    public class JsonSeparatorNamingPolicy : JsonNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8738C4F0
        public void ConvertName(){} // RVA: 0x7FFE8738C560
        public void ConvertNameCore(){} // RVA: 0x7FFE8738C620
        public void <ConvertNameCore>g__WriteChar|4_0(){} // RVA: 0x7FFE8738CD40
        public void <ConvertNameCore>g__ExpandBuffer|4_1(){} // RVA: 0x7FFE8738CDC0
    }

    public class JsonSerializer : Object
    {
        public string SerializationUnreferencedCodeMessage;

        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFE873E58D0 | overloaded x40
        public void ReadFromNode(){} // RVA: 0x7FFE810A1420
        public void ReadFromNodeAsObject(){} // RVA: 0x7FFE873E0DF0
        public void SerializeToDocument(){} // RVA: 0x7FFE873E1260 | overloaded x5
        public void WriteDocument(){} // RVA: 0x7FFE80E2E440
        public void WriteDocumentAsObject(){} // RVA: 0x7FFE873E13D0
        public void SerializeToElement(){} // RVA: 0x7FFE873E1740 | overloaded x5
        public void WriteElement(){} // RVA: 0x7FFE810A1420
        public void WriteElementAsObject(){} // RVA: 0x7FFE873E18D0
        public void SerializeToNode(){} // RVA: 0x7FFE873E1C70 | overloaded x5
        public void WriteNode(){} // RVA: 0x7FFE80E2E440
        public void WriteNodeAsObject(){} // RVA: 0x7FFE873E1DE0
        public void get_IsReflectionEnabledByDefault(){} // RVA: 0x7FFE873E1FA0
        public void GetTypeInfo(){} // RVA: 0x7FFE873E2200 | overloaded x3
        public void ValidateInputType(){} // RVA: 0x7FFE873E2280
        public void IsValidNumberHandlingValue(){} // RVA: 0x7FFE873E2310
        public void IsValidCreationHandlingValue(){} // RVA: 0x7FFE873E2320
        public void IsValidUnmappedMemberHandlingValue(){} // RVA: 0x7FFE873E2320
        public void UnboxOnRead(){} // RVA: 0x7FFE810A1420
        public void UnboxOnWrite(){} // RVA: 0x7FFE810A1420
        public void TryReadMetadata(){} // RVA: 0x7FFE873E2330
        public void IsMetadataPropertyName(){} // RVA: 0x7FFE873E2D20
        public void GetMetadataPropertyName(){} // RVA: 0x7FFE873E2E80
        public void TryHandleReferenceFromJsonElement(){} // RVA: 0x7FFE873E3140
        public void TryHandleReferenceFromJsonNode(){} // RVA: 0x7FFE873E37F0
        public void ValidateMetadataForObjectConverter(){} // RVA: 0x7FFE873E3D10
        public void ValidateMetadataForArrayConverter(){} // RVA: 0x7FFE873E3DA0
        public void ResolveReferenceId(){} // RVA: 0x7FFE810A1420
        public void LookupProperty(){} // RVA: 0x7FFE873E3E30
        public void GetPropertyName(){} // RVA: 0x7FFE873E40B0
        public void CreateExtensionDataProperty(){} // RVA: 0x7FFE873E4200
        public void ReadFromSpan(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ReadFromSpanAsObject(){} // RVA: 0x7FFE873E5430 | overloaded x2
        public void DeserializeAsync(){} // RVA: 0x7FFE873E4B00 | overloaded x5
        public void DeserializeAsyncEnumerable(){} // RVA: 0x7FFE80E3FED0 | overloaded x2
        public void DeserializeAsyncEnumerableCore(){} // RVA: 0x7FFE80E3FED0
        public void Read(){} // RVA: 0x7FFE810A1420
        public void ReadAsObject(){} // RVA: 0x7FFE873E59F0
        public void GetReaderScopedToNextValue(){} // RVA: 0x7FFE873E5CE0
        public void SerializeToUtf8Bytes(){} // RVA: 0x7FFE873E6730 | overloaded x5
        public void WriteBytes(){} // RVA: 0x7FFE80E2E440
        public void WriteBytesAsObject(){} // RVA: 0x7FFE873E68A0
        public void WriteMetadataForObject(){} // RVA: 0x7FFE873E6A60
        public void WriteMetadataForCollection(){} // RVA: 0x7FFE873E6E10
        public void TryGetReferenceForValue(){} // RVA: 0x7FFE873E6ED0
        public void SerializeAsync(){} // RVA: 0x7FFE873E7550 | overloaded x5
        public void Serialize(){} // RVA: 0x7FFE873E7F60 | overloaded x15
        public void WriteString(){} // RVA: 0x7FFE80E2E440
        public void WriteStringAsObject(){} // RVA: 0x7FFE873E7BC0
        public void .cctor(){} // RVA: 0x7FFE873E8110
        public void <UnboxOnRead>g__ThrowUnableToCastValue|50_0(){} // RVA: 0x7FFE80E46070
        public void <TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(){} // RVA: 0x7FFE873E86F0
        public void <DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerable|90_0(){} // RVA: 0x7FFE80E3FED0
        public void <DeserializeAsyncEnumerableCore>g__CreateQueueTypeInfo|90_1(){} // RVA: 0x7FFE80E2E3D0
    }

    public class JsonSerializerOptions : Object
    {
        public CachingContext _cachingContext; // 0x10
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo _lastTypeInfo; // 0x18
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo _objectTypeInfo; // 0x20
        public int BufferSizeDefault;
        public int DefaultMaxDepth;
        public System.Text.Json.JsonSerializerOptions s_defaultOptions;
        public System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver _typeInfoResolver; // 0x28
        public System.Text.Json.JsonNamingPolicy _dictionaryKeyPolicy; // 0x30
        public System.Text.Json.JsonNamingPolicy _jsonPropertyNamingPolicy; // 0x38
        public 0x665CE43C _readCommentHandling; // 0x40
        public System.Text.Json.Serialization.ReferenceHandler _referenceHandler; // 0x48
        public System.Text.Encodings.Web.JavaScriptEncoder _encoder; // 0x50
        public ConverterList _converters; // 0x58
        public 0x665D06F4 _defaultIgnoreCondition; // 0x60
        public 0x665D07A4 _numberHandling; // 0x64
        public 0x665D07FC _preferredObjectCreationHandling; // 0x68
        public 0x665D09B4 _unknownTypeHandling; // 0x6C
        public 0x665D0854 _unmappedMemberHandling; // 0x70
        public int _defaultBufferSize; // 0x74
        public int _maxDepth; // 0x78
        public bool _allowTrailingCommas; // 0x7C
        public bool _ignoreNullValues; // 0x7D
        public bool _ignoreReadOnlyProperties; // 0x7E
        public bool _ignoreReadonlyFields; // 0x7F
        public bool _includeFields; // 0x80
        public bool _propertyNameCaseInsensitive; // 0x81
        public bool _writeIndented; // 0x82
        public OptionsBoundJsonTypeInfoResolverChain _typeInfoResolverChain; // 0x88
        public int _effectiveMaxDepth; // 0x90

        // ── Methods ──
        public void get_CacheContext(){} // RVA: 0x7FFE873E91D0
        public void GetTypeInfo(){} // RVA: 0x7FFE873E9280
        public void TryGetTypeInfo(){} // RVA: 0x7FFE873E9360
        public void GetTypeInfoInternal(){} // RVA: 0x7FFE873E9490
        public void TryGetTypeInfoCached(){} // RVA: 0x7FFE873E9680
        public void GetTypeInfoForRootType(){} // RVA: 0x7FFE873E9880
        public void TryGetPolymorphicTypeInfoForRootType(){} // RVA: 0x7FFE873E99A0
        public void get_ObjectTypeInfo(){} // RVA: 0x7FFE873E9BA0
        public void ClearCaches(){} // RVA: 0x7FFE873E9CA0
        public void get_Converters(){} // RVA: 0x7FFE873E9DB0
        public void GetConverter(){} // RVA: 0x7FFE873E9E60
        public void GetConverterInternal(){} // RVA: 0x7FFE873E9F10
        public void GetConverterFromList(){} // RVA: 0x7FFE873E9F90
        public void ExpandConverterFactory(){} // RVA: 0x7FFE873EA0B0
        public void CheckConverterNullabilityIsSameAsPropertyType(){} // RVA: 0x7FFE873EA160
        public void get_Default(){} // RVA: 0x7FFE873EA230
        public void .ctor(){} // RVA: 0x7FFE873EA5F0 | overloaded x3
        public void TrackOptionsInstance(){} // RVA: 0x7FFE873EA760
        public void AddContext(){} // RVA: 0x7FFE80E45FE0
        public void get_TypeInfoResolver(){} // RVA: 0x7FFE81129130
        public void set_TypeInfoResolver(){} // RVA: 0x7FFE873EA820
        public void get_TypeInfoResolverChain(){} // RVA: 0x7FFE873EA980
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFE816402F0
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFE873EAAB0
        public void get_DefaultBufferSize(){} // RVA: 0x7FFE826A9B90
        public void set_DefaultBufferSize(){} // RVA: 0x7FFE873EAB20
        public void get_Encoder(){} // RVA: 0x7FFE8119C0E0
        public void set_Encoder(){} // RVA: 0x7FFE873EABF0
        public void get_DictionaryKeyPolicy(){} // RVA: 0x7FFE8144E200
        public void set_DictionaryKeyPolicy(){} // RVA: 0x7FFE873EACB0
        public void get_IgnoreNullValues(){} // RVA: 0x7FFE816400B0
        public void set_IgnoreNullValues(){} // RVA: 0x7FFE873EAD70
        public void get_DefaultIgnoreCondition(){} // RVA: 0x7FFE8139EA30
        public void set_DefaultIgnoreCondition(){} // RVA: 0x7FFE873EAE50
        public void get_NumberHandling(){} // RVA: 0x7FFE8139DA60
        public void set_NumberHandling(){} // RVA: 0x7FFE873EAF90
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x7FFE82A22EF0
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x7FFE873EB080
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x7FFE81643A40
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x7FFE873EB170
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x7FFE816411A0
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x7FFE873EB1E0
        public void get_IncludeFields(){} // RVA: 0x7FFE813A1130
        public void set_IncludeFields(){} // RVA: 0x7FFE873EB250
        public void get_MaxDepth(){} // RVA: 0x7FFE8286C0A0
        public void set_MaxDepth(){} // RVA: 0x7FFE873EB2C0
        public void get_EffectiveMaxDepth(){} // RVA: 0x7FFE814AA220
        public void set_EffectiveMaxDepth(){} // RVA: 0x7FFE81C8DB30
        public void get_PropertyNamingPolicy(){} // RVA: 0x7FFE8143BA80
        public void set_PropertyNamingPolicy(){} // RVA: 0x7FFE873EB370
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFE813A1BA0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFE873EB430
        public void get_ReadCommentHandling(){} // RVA: 0x7FFE811B6C00
        public void set_ReadCommentHandling(){} // RVA: 0x7FFE873EB4A0
        public void get_UnknownTypeHandling(){} // RVA: 0x7FFE82A22F10
        public void set_UnknownTypeHandling(){} // RVA: 0x7FFE873EB580
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFE81E60180
        public void set_UnmappedMemberHandling(){} // RVA: 0x7FFE873EB5F0
        public void get_WriteIndented(){} // RVA: 0x7FFE81EB0A60
        public void set_WriteIndented(){} // RVA: 0x7FFE873EB660
        public void get_ReferenceHandler(){} // RVA: 0x7FFE81176730
        public void set_ReferenceHandler(){} // RVA: 0x7FFE873EB6D0
        public void get_CanUseFastPathSerializationLogic(){} // RVA: 0x7FFE873EB7B0
        public void get_IsReadOnly(){} // RVA: 0x7FFE873EB870
        public void MakeReadOnly(){} // RVA: 0x7FFE873EB8B0 | overloaded x2
        public void ConfigureForJsonSerializer(){} // RVA: 0x7FFE873EB900
        public void GetTypeInfoNoCaching(){} // RVA: 0x7FFE873EBD30
        public void GetDocumentOptions(){} // RVA: 0x7FFE873EBF70
        public void GetNodeOptions(){} // RVA: 0x7FFE813A1BA0
        public void GetReaderOptions(){} // RVA: 0x7FFE873EC050
        public void GetWriterOptions(){} // RVA: 0x7FFE873EC100
        public void VerifyMutable(){} // RVA: 0x7FFE873EC1D0
        public void GetOrCreateDefaultOptionsInstance(){} // RVA: 0x7FFE873EC230
        public void get_DebuggerDisplay(){} // RVA: 0x7FFE873EC400
    }

    public class JsonSnakeCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8738D090
    }

    public class JsonSnakeCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8738D0E0
    }

    public class JsonWriterHelper : Object
    {
        public System.Text.UTF8Encoding s_utf8Encoding;

        // ── Methods ──
        public void WriteIndentation(){} // RVA: 0x7FFE873F3070
        public void ValidateProperty(){} // RVA: 0x7FFE873F3260 | overloaded x2
        public void ValidateValue(){} // RVA: 0x7FFE873F32B0 | overloaded x2
        public void ValidateDouble(){} // RVA: 0x7FFE873F31F0
        public void ValidateSingle(){} // RVA: 0x7FFE873F3230
        public void ValidatePropertyAndValue(){} // RVA: 0x7FFE873F34A0 | overloaded x4
        public void ValidatePropertyNameLength(){} // RVA: 0x7FFE873F3570 | overloaded x2
        public void ValidateNumber(){} // RVA: 0x7FFE873F35C0
        public void IsValidUtf8String(){} // RVA: 0x7FFE873F3A00
        public void ToUtf8(){} // RVA: 0x7FFE873F3B10
        public void WriteDateTimeTrimmed(){} // RVA: 0x7FFE873F3CE0
        public void WriteDateTimeOffsetTrimmed(){} // RVA: 0x7FFE873F3F30
        public void TrimDateTimeOffset(){} // RVA: 0x7FFE873F4180
        public void get_AllowList(){} // RVA: 0x7FFE873F4330
        public void NeedsEscaping(){} // RVA: 0x7FFE873F4520 | overloaded x3
        public void NeedsEscapingNoBoundsCheck(){} // RVA: 0x7FFE873F4430
        public void GetMaxEscapedLength(){} // RVA: 0x7FFE86E71AC0
        public void EscapeString(){} // RVA: 0x7FFE873F4FE0 | overloaded x4
        public void EscapeNextBytes(){} // RVA: 0x7FFE873F4BF0
        public void IsAsciiValue(){} // RVA: 0x7FFE868B85F0 | overloaded x2
        public void EscapeNextChars(){} // RVA: 0x7FFE873F54C0
        public void WriteHex(){} // RVA: 0x7FFE873F5790
        public void .cctor(){} // RVA: 0x7FFE873F5850
    }

    public class JsonWriterOptions : ValueType
    {
        public int _optionsMask; // 0x10
        public System.Text.Encodings.Web.JavaScriptEncoder _encoder; // 0x18
        public object field_2; // 0x105
        public object field_3; // 0x106

        // ── Methods ──
        public void get_Encoder(){} // RVA: 0x7FFE826F4210
        public void set_Encoder(){} // RVA: 0x7FFE826F4230
        public void get_Indented(){} // RVA: 0x7FFE86CB1D80
        public void set_Indented(){} // RVA: 0x7FFE86E73540
        public void get_SkipValidation(){} // RVA: 0x7FFE86CB1D90
        public void set_SkipValidation(){} // RVA: 0x7FFE86E73560
        public void get_IndentedOrNotSkipValidation(){} // RVA: 0x7FFE86E73580
    }

    public class PooledByteBufferWriter : Object
    {
        public byte[] _rentedBuffer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E374F0
        public void get_WrittenMemory(){} // RVA: 0x7FFE86E375B0
        public void ClearHelper(){} // RVA: 0x7FFE86E37690
        public void Dispose(){} // RVA: 0x7FFE86E377A0
        public void Advance(){} // RVA: 0x7FFE86E37960
        public void GetMemory(){} // RVA: 0x7FFE86E37970
        public void CheckAndResizeBuffer(){} // RVA: 0x7FFE86E37A90
    }

    public class ReadStack : ValueType
    {
        public char[] SpecialCharacters;

        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x7FFE86E6D790
        public void EnsurePushCapacity(){} // RVA: 0x7FFE86E6D7A0
        public void Initialize(){} // RVA: 0x7FFE86E6D910 | overloaded x2
        public void Push(){} // RVA: 0x7FFE86E6DAE0
        public void Pop(){} // RVA: 0x7FFE86E6DF50
        public void JsonPath(){} // RVA: 0x7FFE86E6E280
        public void SetConstructorArgumentState(){} // RVA: 0x7FFE86E6E420
        public void .cctor(){} // RVA: 0x7FFE86E6E690
        public void <JsonPath>g__AppendStackFrame|18_0(){} // RVA: 0x7FFE86E6E770
        public void <JsonPath>g__GetCount|18_1(){} // RVA: 0x7FFE86E6EBE0
        public void <JsonPath>g__AppendPropertyName|18_2(){} // RVA: 0x7FFE86E6ED30
        public void <JsonPath>g__GetPropertyName|18_3(){} // RVA: 0x7FFE86E6EE40
    }

    public class ReadStackFrame : ValueType
    {
        // ── Methods ──
        public void EndConstructorParameter(){} // RVA: 0x7FFE86E6EFB0
        public void EndProperty(){} // RVA: 0x7FFE86E6F080
        public void EndElement(){} // RVA: 0x7FFE86E6F190
        public void IsProcessingDictionary(){} // RVA: 0x7FFE86E6F1F0
        public void IsProcessingEnumerable(){} // RVA: 0x7FFE86E6F220
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(){} // RVA: 0x7FFE86E37DD0
        public void GetArgumentOutOfRangeException_MaxDepthMustBePositive(){} // RVA: 0x7FFE86E37E70
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFE86E37F20
        public void GetArgumentOutOfRangeException_CommentEnumMustBeInRange(){} // RVA: 0x7FFE86E37F90
        public void GetArgumentException(){} // RVA: 0x7FFE86E38040
        public void ThrowArgumentException(){} // RVA: 0x7FFE86E38270 | overloaded x2
        public void ThrowArgumentException_PropertyNameTooLarge(){} // RVA: 0x7FFE86E380D0
        public void ThrowArgumentException_ValueTooLarge(){} // RVA: 0x7FFE86E38150
        public void ThrowArgumentException_ValueNotSupported(){} // RVA: 0x7FFE86E381D0
        public void ThrowInvalidOperationException_NeedLargerSpan(){} // RVA: 0x7FFE86E38220
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFE86E3A1F0 | overloaded x3
        public void GetInvalidOperationException(){} // RVA: 0x7FFE86E3A880 | overloaded x4
        public void ThrowInvalidOperationOrArgumentException(){} // RVA: 0x7FFE86E384C0
        public void GetInvalidOperationException_ExpectedArray(){} // RVA: 0x7FFE86E385C0
        public void GetInvalidOperationException_ExpectedObject(){} // RVA: 0x7FFE86E38610
        public void GetInvalidOperationException_ExpectedNumber(){} // RVA: 0x7FFE86E38660
        public void GetInvalidOperationException_ExpectedBoolean(){} // RVA: 0x7FFE86E386B0
        public void GetInvalidOperationException_ExpectedString(){} // RVA: 0x7FFE86E38700
        public void GetInvalidOperationException_CannotSkipOnPartial(){} // RVA: 0x7FFE86E38750
        public void GetJsonElementWrongTypeException(){} // RVA: 0x7FFE86E38BD0 | overloaded x4
        public void ThrowJsonReaderException(){} // RVA: 0x7FFE86E38CD0
        public void GetJsonReaderException(){} // RVA: 0x7FFE86E38D20
        public void IsPrintable(){} // RVA: 0x7FFE86E390D0
        public void GetPrintableString(){} // RVA: 0x7FFE86E390E0
        public void GetResourceString(){} // RVA: 0x7FFE86E3A9D0 | overloaded x2
        public void ThrowArgumentException_InvalidUTF8(){} // RVA: 0x7FFE86E3A220
        public void ThrowArgumentException_InvalidUTF16(){} // RVA: 0x7FFE86E3A410
        public void ThrowInvalidOperationException_ReadInvalidUTF16(){} // RVA: 0x7FFE86E3A570 | overloaded x2
        public void GetInvalidOperationException_ReadInvalidUTF8(){} // RVA: 0x7FFE86E3A5C0
        public void GetArgumentException_ReadInvalidUTF16(){} // RVA: 0x7FFE86E3A6F0
        public void ThrowOutOfMemoryException(){} // RVA: 0x7FFE86E3A930
        public void GetFormatException(){} // RVA: 0x7FFE86E3B4E0 | overloaded x3
        public void GetInvalidOperationException_ExpectedChar(){} // RVA: 0x7FFE86E3B840
        public void ThrowArgumentException_NodeValueNotAllowed(){} // RVA: 0x7FFE86E3B890
        public void ThrowArgumentException_NodeArrayTooSmall(){} // RVA: 0x7FFE86E3B900
        public void ThrowArgumentOutOfRangeException_NodeArrayIndexNegative(){} // RVA: 0x7FFE86E3B970
        public void ThrowArgumentException_DuplicateKey(){} // RVA: 0x7FFE86E3B9E0
        public void ThrowInvalidOperationException_NodeAlreadyHasParent(){} // RVA: 0x7FFE86E3BA50
        public void ThrowInvalidOperationException_NodeCycleDetected(){} // RVA: 0x7FFE86E3BAC0
        public void ThrowNotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x7FFE86E3BB30
        public void NotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x7FFE86E3BB60
        public void ThrowNotSupportedException_SerializationNotSupported(){} // RVA: 0x7FFE86E3BC40
        public void ThrowNotSupportedException_TypeRequiresAsyncSerialization(){} // RVA: 0x7FFE86E3BCC0
        public void ThrowNotSupportedException_ConstructorMaxOf64Parameters(){} // RVA: 0x7FFE86E3BD40
        public void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(){} // RVA: 0x7FFE86E3BDC0
        public void ThrowJsonException_DeserializeUnableToConvertValue(){} // RVA: 0x7FFE86E3BE60
        public void ThrowInvalidCastException_DeserializeUnableToAssignValue(){} // RVA: 0x7FFE86E3BEF0
        public void ThrowInvalidOperationException_DeserializeUnableToAssignNull(){} // RVA: 0x7FFE86E3BF70
        public void ThrowJsonException_SerializationConverterRead(){} // RVA: 0x7FFE86E3BFF0
        public void ThrowJsonException_SerializationConverterWrite(){} // RVA: 0x7FFE86E3C080
        public void ThrowJsonException_SerializerCycleDetected(){} // RVA: 0x7FFE86E3C110
        public void ThrowJsonException(){} // RVA: 0x7FFE86E3C1C0
        public void ThrowInvalidOperationException_CannotSerializeInvalidType(){} // RVA: 0x7FFE86E3C220
        public void ThrowInvalidOperationException_SerializationConverterNotCompatible(){} // RVA: 0x7FFE86E3C340
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(){} // RVA: 0x7FFE86E3C3C0
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x7FFE86E3C4A0
        public void ThrowInvalidOperationException_SerializerOptionsImmutable(){} // RVA: 0x7FFE86E3C590
        public void ThrowInvalidOperationException_SerializerPropertyNameConflict(){} // RVA: 0x7FFE86E3C610
        public void ThrowInvalidOperationException_SerializerPropertyNameNull(){} // RVA: 0x7FFE86E3C6B0
        public void ThrowInvalidOperationException_NamingPolicyReturnNull(){} // RVA: 0x7FFE86E3C780
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(){} // RVA: 0x7FFE86E3C800
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(){} // RVA: 0x7FFE86E3C880
        public void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(){} // RVA: 0x7FFE86E3C900
        public void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(){} // RVA: 0x7FFE86E3CA40
        public void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x7FFE86E3CAC0
        public void ThrowInvalidOperationException_JsonIncludeOnNonPublicInvalid(){} // RVA: 0x7FFE86E3CB70
        public void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x7FFE86E3CBF0
        public void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(){} // RVA: 0x7FFE86E3CC70
        public void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(){} // RVA: 0x7FFE86E3CD30
        public void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotHonored(){} // RVA: 0x7FFE86E3CDF0
        public void ReThrowWithPath(){} // RVA: 0x7FFE86E3CED0
        public void AddJsonExceptionInformation(){} // RVA: 0x7FFE86E3CF40
        public void ThrowInvalidOperationException_SerializationDuplicateAttribute(){} // RVA: 0x7FFE86E3D180
        public void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x7FFE86E3D2F0
        public void ThrowNotSupportedException(){} // RVA: 0x7FFE86E3D770 | overloaded x2
        public void ThrowNotSupportedException_DeserializeNoConstructor(){} // RVA: 0x7FFE86E3D940
        public void ThrowNotSupportedException_CannotPopulateCollection(){} // RVA: 0x7FFE86E3DA20
        public void ThrowJsonException_MetadataValuesInvalidToken(){} // RVA: 0x7FFE86E3DAC0
        public void ThrowJsonException_MetadataReferenceNotFound(){} // RVA: 0x7FFE86E3DB40
        public void ThrowJsonException_MetadataValueWasNotString(){} // RVA: 0x7FFE86E3DC20 | overloaded x2
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x7FFE86E3DCF0 | overloaded x2
        public void ThrowJsonException_MetadataIdIsNotFirstProperty(){} // RVA: 0x7FFE86E3DD30
        public void ThrowJsonException_MetadataMissingIdBeforeValues(){} // RVA: 0x7FFE86E3DDB0
        public void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x7FFE86E3DE30
        public void ThrowJsonException_MetadataDuplicateIdFound(){} // RVA: 0x7FFE86E3DF60
        public void ThrowJsonException_MetadataInvalidReferenceToValueType(){} // RVA: 0x7FFE86E3DFC0
        public void ThrowJsonException_MetadataPreservedArrayInvalidProperty(){} // RVA: 0x7FFE86E3E020
        public void ThrowJsonException_MetadataPreservedArrayValuesNotFound(){} // RVA: 0x7FFE86E3E1E0
        public void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(){} // RVA: 0x7FFE86E3E280
        public void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x7FFE86E3E2E0
        public void ThrowUnexpectedMetadataException(){} // RVA: 0x7FFE86E3E370
        public void ThrowInvalidOperationException_JsonSerializerOptionsAlreadyBoundToContext(){} // RVA: 0x7FFE86E3E4B0
        public void ThrowNotSupportedException_BuiltInConvertersNotRooted(){} // RVA: 0x7FFE86E3E540
        public void ThrowNotSupportedException_NoMetadataForType(){} // RVA: 0x7FFE86E3E5C0
        public void ThrowInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x7FFE86E3E640
        public void ThrowInvalidOperationException_NoMetadataForTypeCtorParams(){} // RVA: 0x7FFE86E3E6E0
        public void ThrowMissingMemberException_MissingFSharpCoreMember(){} // RVA: 0x7FFE86E3E780
    }

    public class Utf8JsonReader : ValueType
    {
        public System.ReadOnlySpan`1<byte> _buffer; // 0x10
        public bool _isFinalBlock; // 0x28
        public bool _isInputSequence; // 0x29
        public long _lineNumber; // 0x30
        public long _bytePositionInLine; // 0x38
        public int _consumed; // 0x40
        public bool _inObject; // 0x44
        public bool _isNotPrimitive; // 0x45
        public 0x66616F7C _tokenType; // 0x46
        public 0x66616F7C _previousTokenType; // 0x47
        public System.Text.Json.JsonReaderOptions _readerOptions; // 0x48
        public System.Text.Json.BitStack _bitStack; // 0x50
        public long _totalConsumed; // 0x68

        // ── Methods ──
        public void get_IsLastSpan(){} // RVA: 0x7FFE86E54A50
        public void get_OriginalSequence(){} // RVA: 0x7FFE86E54A70
        public void get_OriginalSpan(){} // RVA: 0x7FFE86E54A90
        public void get_ValueSpan(){} // RVA: 0x7FFE8344D2F0
        public void set_ValueSpan(){} // RVA: 0x7FFE86E54B60
        public void get_BytesConsumed(){} // RVA: 0x7FFE86E54BD0
        public void get_TokenStartIndex(){} // RVA: 0x7FFE81166120
        public void set_TokenStartIndex(){} // RVA: 0x7FFE81C16D50
        public void get_CurrentDepth(){} // RVA: 0x7FFE86E54BE0
        public void get_IsInArray(){} // RVA: 0x7FFE82AE0FD0
        public void get_TokenType(){} // RVA: 0x7FFE8130B2F0
        public void get_HasValueSequence(){} // RVA: 0x7FFE81FF3AD0
        public void set_HasValueSequence(){} // RVA: 0x7FFE81FE9F60
        public void get_IsFinalBlock(){} // RVA: 0x7FFE811164E0
        public void get_ValueSequence(){} // RVA: 0x7FFE8344D310
        public void set_ValueSequence(){} // RVA: 0x7FFE86E54C00
        public void get_CurrentState(){} // RVA: 0x7FFE86E54C70
        public void .ctor(){} // RVA: 0x7FFE86E55010 | overloaded x2
        public void Read(){} // RVA: 0x7FFE86E55090
        public void Skip(){} // RVA: 0x7FFE86E55120
        public void SkipHelper(){} // RVA: 0x7FFE86E55160
        public void TrySkip(){} // RVA: 0x7FFE86E552B0
        public void TrySkipHelper(){} // RVA: 0x7FFE86E552E0
        public void StartObject(){} // RVA: 0x7FFE86E555B0
        public void EndObject(){} // RVA: 0x7FFE86E55710
        public void StartArray(){} // RVA: 0x7FFE86E55890
        public void EndArray(){} // RVA: 0x7FFE86E559F0
        public void UpdateBitStackOnEndToken(){} // RVA: 0x7FFE86E55B70
        public void ReadSingleSegment(){} // RVA: 0x7FFE86E55BD0
        public void HasMoreData(){} // RVA: 0x7FFE86E55FC0 | overloaded x2
        public void ReadFirstToken(){} // RVA: 0x7FFE86E56080
        public void SkipWhiteSpace(){} // RVA: 0x7FFE86E56350
        public void ConsumeValue(){} // RVA: 0x7FFE86E56420
        public void ConsumeLiteral(){} // RVA: 0x7FFE86E569B0
        public void CheckLiteral(){} // RVA: 0x7FFE86E56CB0
        public void ThrowInvalidLiteral(){} // RVA: 0x7FFE86E56DF0
        public void ConsumeNumber(){} // RVA: 0x7FFE86E56E80
        public void ConsumePropertyName(){} // RVA: 0x7FFE86E56FE0
        public void ConsumeString(){} // RVA: 0x7FFE86E57120
        public void ConsumeStringAndValidate(){} // RVA: 0x7FFE86E57490
        public void ValidateHexDigits(){} // RVA: 0x7FFE86E57860
        public void TryGetNumber(){} // RVA: 0x7FFE86E579E0
        public void ConsumeNegativeSign(){} // RVA: 0x7FFE86E57D40
        public void ConsumeZero(){} // RVA: 0x7FFE86E57F30
        public void ConsumeIntegerDigits(){} // RVA: 0x7FFE86E581B0
        public void ConsumeDecimalDigits(){} // RVA: 0x7FFE86E58380
        public void ConsumeSign(){} // RVA: 0x7FFE86E58560
        public void ConsumeNextTokenOrRollback(){} // RVA: 0x7FFE86E587D0
        public void ConsumeNextToken(){} // RVA: 0x7FFE86E58850
        public void ConsumeNextTokenFromLastNonCommentToken(){} // RVA: 0x7FFE86E58C20
        public void SkipAllComments(){} // RVA: 0x7FFE86E59270 | overloaded x2
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkipped(){} // RVA: 0x7FFE86E59340
        public void SkipComment(){} // RVA: 0x7FFE86E597A0
        public void SkipSingleLineComment(){} // RVA: 0x7FFE86E599B0
        public void FindLineSeparator(){} // RVA: 0x7FFE86E59B20
        public void ThrowOnDangerousLineSeparator(){} // RVA: 0x7FFE86E59D60
        public void SkipMultiLineComment(){} // RVA: 0x7FFE86E59E50
        public void ConsumeComment(){} // RVA: 0x7FFE86E5A2B0
        public void ConsumeSingleLineComment(){} // RVA: 0x7FFE86E5A4C0
        public void ConsumeMultiLineComment(){} // RVA: 0x7FFE86E5A5F0
        public void GetUnescapedSpan(){} // RVA: 0x7FFE86E5A720
        public void ReadMultiSegment(){} // RVA: 0x7FFE86E5A910
        public void ValidateStateAtEndOfData(){} // RVA: 0x7FFE86E5AC90
        public void HasMoreDataMultiSegment(){} // RVA: 0x7FFE86E5AE00 | overloaded x2
        public void GetNextSpan(){} // RVA: 0x7FFE86E5AF20
        public void ReadFirstTokenMultiSegment(){} // RVA: 0x7FFE86E5B2C0
        public void SkipWhiteSpaceMultiSegment(){} // RVA: 0x7FFE86E5B570
        public void ConsumeValueMultiSegment(){} // RVA: 0x7FFE86E5B5D0
        public void ConsumeLiteralMultiSegment(){} // RVA: 0x7FFE86E5BB60
        public void CheckLiteralMultiSegment(){} // RVA: 0x7FFE86E5BE60
        public void FindMismatch(){} // RVA: 0x7FFE86E5CA70
        public void GetInvalidLiteralMultiSegment(){} // RVA: 0x7FFE86E5CB70
        public void ConsumeNumberMultiSegment(){} // RVA: 0x7FFE86E5CC20
        public void ConsumePropertyNameMultiSegment(){} // RVA: 0x7FFE86E5CD80
        public void ConsumeStringMultiSegment(){} // RVA: 0x7FFE86E5CEC0
        public void ConsumeStringNextSegment(){} // RVA: 0x7FFE86E5D240
        public void ConsumeStringAndValidateMultiSegment(){} // RVA: 0x7FFE86E5DD00
        public void RollBackState(){} // RVA: 0x7FFE86E5E4C0
        public void TryGetNumberMultiSegment(){} // RVA: 0x7FFE86E5E540
        public void ConsumeNegativeSignMultiSegment(){} // RVA: 0x7FFE86E5EE30
        public void ConsumeZeroMultiSegment(){} // RVA: 0x7FFE86E5F0C0
        public void ConsumeIntegerDigitsMultiSegment(){} // RVA: 0x7FFE86E5F3D0
        public void ConsumeDecimalDigitsMultiSegment(){} // RVA: 0x7FFE86E5F700
        public void ConsumeSignMultiSegment(){} // RVA: 0x7FFE86E5F970
        public void ConsumeNextTokenOrRollbackMultiSegment(){} // RVA: 0x7FFE86E5FD20
        public void ConsumeNextTokenMultiSegment(){} // RVA: 0x7FFE86E5FE00
        public void ConsumeNextTokenFromLastNonCommentTokenMultiSegment(){} // RVA: 0x7FFE86E60260
        public void SkipAllCommentsMultiSegment(){} // RVA: 0x7FFE86E60940 | overloaded x2
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(){} // RVA: 0x7FFE86E60A10
        public void SkipOrConsumeCommentMultiSegmentWithRollback(){} // RVA: 0x7FFE86E60F20
        public void SkipCommentMultiSegment(){} // RVA: 0x7FFE86E613C0
        public void SkipSingleLineCommentMultiSegment(){} // RVA: 0x7FFE86E61730
        public void FindLineSeparatorMultiSegment(){} // RVA: 0x7FFE86E61910
        public void ThrowOnDangerousLineSeparatorMultiSegment(){} // RVA: 0x7FFE86E61CF0
        public void SkipMultiLineCommentMultiSegment(){} // RVA: 0x7FFE86E61E60
        public void CaptureState(){} // RVA: 0x7FFE86E62380
        public void GetString(){} // RVA: 0x7FFE86E62400
        public void GetBoolean(){} // RVA: 0x7FFE86E62630
        public void GetBytesFromBase64(){} // RVA: 0x7FFE86E62730
        public void GetByte(){} // RVA: 0x7FFE86E62790
        public void GetByteWithQuotes(){} // RVA: 0x7FFE86E627F0
        public void GetSByte(){} // RVA: 0x7FFE86E62870
        public void GetSByteWithQuotes(){} // RVA: 0x7FFE86E628D0
        public void GetInt16(){} // RVA: 0x7FFE86E62960
        public void GetInt16WithQuotes(){} // RVA: 0x7FFE86E629C0
        public void GetInt32(){} // RVA: 0x7FFE86E62A50
        public void GetInt32WithQuotes(){} // RVA: 0x7FFE86E62AB0
        public void GetInt64(){} // RVA: 0x7FFE86E62B40
        public void GetInt64WithQuotes(){} // RVA: 0x7FFE86E62BA0
        public void GetUInt16(){} // RVA: 0x7FFE86E62C30
        public void GetUInt16WithQuotes(){} // RVA: 0x7FFE86E62C90
        public void GetUInt32(){} // RVA: 0x7FFE86E62D20
        public void GetUInt32WithQuotes(){} // RVA: 0x7FFE86E62D80
        public void GetUInt64(){} // RVA: 0x7FFE86E62E10
        public void GetUInt64WithQuotes(){} // RVA: 0x7FFE86E62E70
        public void GetSingle(){} // RVA: 0x7FFE86E62F00
        public void GetSingleWithQuotes(){} // RVA: 0x7FFE86E62F60
        public void GetSingleFloatingPointConstant(){} // RVA: 0x7FFE86E63130
        public void GetDouble(){} // RVA: 0x7FFE86E63200
        public void GetDoubleWithQuotes(){} // RVA: 0x7FFE86E63260
        public void GetDoubleFloatingPointConstant(){} // RVA: 0x7FFE86E634F0
        public void GetDecimal(){} // RVA: 0x7FFE86E635D0
        public void GetDecimalWithQuotes(){} // RVA: 0x7FFE86E63630
        public void GetDateTime(){} // RVA: 0x7FFE86E636A0
        public void GetDateTimeNoValidation(){} // RVA: 0x7FFE86E63730
        public void GetDateTimeOffset(){} // RVA: 0x7FFE86E63790
        public void GetDateTimeOffsetNoValidation(){} // RVA: 0x7FFE86E63820
        public void GetGuid(){} // RVA: 0x7FFE86E63880
        public void GetGuidNoValidation(){} // RVA: 0x7FFE86E63910
        public void TryGetBytesFromBase64(){} // RVA: 0x7FFE86E63970
        public void TryGetByte(){} // RVA: 0x7FFE86E63BA0
        public void TryGetByteCore(){} // RVA: 0x7FFE86E63CD0
        public void TryGetSByte(){} // RVA: 0x7FFE86E63DE0
        public void TryGetSByteCore(){} // RVA: 0x7FFE86E63F10
        public void TryGetInt16(){} // RVA: 0x7FFE86E64020
        public void TryGetInt16Core(){} // RVA: 0x7FFE86E64150
        public void TryGetInt32(){} // RVA: 0x7FFE86E64260
        public void TryGetInt32Core(){} // RVA: 0x7FFE86E64390
        public void TryGetInt64(){} // RVA: 0x7FFE86E644A0
        public void TryGetInt64Core(){} // RVA: 0x7FFE86E645D0
        public void TryGetUInt16(){} // RVA: 0x7FFE86E646E0
        public void TryGetUInt16Core(){} // RVA: 0x7FFE86E64810
        public void TryGetUInt32(){} // RVA: 0x7FFE86E64920
        public void TryGetUInt32Core(){} // RVA: 0x7FFE86E64A50
        public void TryGetUInt64(){} // RVA: 0x7FFE86E64B60
        public void TryGetUInt64Core(){} // RVA: 0x7FFE86E64C90
        public void TryGetSingle(){} // RVA: 0x7FFE86E64DA0
        public void TryGetDouble(){} // RVA: 0x7FFE86E64F90
        public void TryGetDecimal(){} // RVA: 0x7FFE86E65210
        public void TryGetDecimalCore(){} // RVA: 0x7FFE86E65340
        public void TryGetDateTime(){} // RVA: 0x7FFE86E65420
        public void TryGetDateTimeCore(){} // RVA: 0x7FFE86E65470
        public void TryGetDateTimeOffset(){} // RVA: 0x7FFE86E659E0
        public void TryGetDateTimeOffsetCore(){} // RVA: 0x7FFE86E65A30
        public void TryGetGuid(){} // RVA: 0x7FFE86E65FA0
        public void TryGetGuidCore(){} // RVA: 0x7FFE86E65FF0
    }

    public class Utf8JsonWriter : Object
    {
        public int s_newLineLength;
        public System.Buffers.IBufferWriter`1<byte> _output; // 0x10
        public System.IO.Stream _stream; // 0x18
        public System.Buffers.ArrayBufferWriter`1<byte> _arrayBufferWriter; // 0x20
        public System.Memory`1<byte> _memory; // 0x28

        // ── Methods ──
        public void get_BytesPending(){} // RVA: 0x7FFE81E60180
        public void set_BytesPending(){} // RVA: 0x7FFE81293CF0
        public void get_BytesCommitted(){} // RVA: 0x7FFE81463AE0
        public void set_BytesCommitted(){} // RVA: 0x7FFE865EFE40
        public void get_Indentation(){} // RVA: 0x7FFE86E73590
        public void get_TokenType(){} // RVA: 0x7FFE812CF7D0
        public void get_CurrentDepth(){} // RVA: 0x7FFE86E735A0
        public void .ctor(){} // RVA: 0x7FFE86E736E0 | overloaded x2
        public void ResetHelper(){} // RVA: 0x7FFE86E739C0
        public void CheckNotDisposed(){} // RVA: 0x7FFE86E739E0
        public void Flush(){} // RVA: 0x7FFE86E73A50
        public void Dispose(){} // RVA: 0x7FFE86E73C70
        public void DisposeAsync(){} // RVA: 0x7FFE86E73DB0
        public void FlushAsync(){} // RVA: 0x7FFE86E73F40
        public void WriteStartArray(){} // RVA: 0x7FFE86E74C50 | overloaded x4
        public void WriteStartObject(){} // RVA: 0x7FFE86E74D20 | overloaded x3
        public void WriteStart(){} // RVA: 0x7FFE86E74190
        public void WriteStartMinimized(){} // RVA: 0x7FFE86E74250
        public void WriteStartSlow(){} // RVA: 0x7FFE86E74360
        public void ValidateStart(){} // RVA: 0x7FFE86E743E0
        public void WriteStartIndented(){} // RVA: 0x7FFE86E74450
        public void WriteStartHelper(){} // RVA: 0x7FFE86E747A0
        public void WriteStartByOptions(){} // RVA: 0x7FFE86E74FD0 | overloaded x2
        public void WriteStartEscape(){} // RVA: 0x7FFE86E74DF0
        public void WriteStartEscapeProperty(){} // RVA: 0x7FFE86E75080
        public void WriteEndArray(){} // RVA: 0x7FFE86E754D0
        public void WriteEndObject(){} // RVA: 0x7FFE86E754F0
        public void WriteEnd(){} // RVA: 0x7FFE86E75510
        public void WriteEndMinimized(){} // RVA: 0x7FFE86E75590
        public void WriteEndSlow(){} // RVA: 0x7FFE86E75670
        public void ValidateEnd(){} // RVA: 0x7FFE86E756D0
        public void WriteEndIndented(){} // RVA: 0x7FFE86E757B0
        public void WriteNewLine(){} // RVA: 0x7FFE86E759C0
        public void UpdateBitStackOnStart(){} // RVA: 0x7FFE86E75AA0
        public void Grow(){} // RVA: 0x7FFE86E75B40
        public void FirstCallToGetMemory(){} // RVA: 0x7FFE86E75D90
        public void SetFlagToAddListSeparatorBeforeNextItem(){} // RVA: 0x7FFE86E75F40
        public void WritePropertyName(){} // RVA: 0x7FFE86E837C0 | overloaded x15
        public void WriteString(){} // RVA: 0x7FFE86E80760 | overloaded x6
        public void WriteStringEscape(){} // RVA: 0x7FFE86E8A4B0 | overloaded x4
        public void WriteStringEscapeProperty(){} // RVA: 0x7FFE86E7F530 | overloaded x3
        public void WriteStringByOptions(){} // RVA: 0x7FFE86E8A5F0 | overloaded x5
        public void WriteStringMinimized(){} // RVA: 0x7FFE86E8A660 | overloaded x5
        public void WriteStringIndented(){} // RVA: 0x7FFE86E8A870 | overloaded x5
        public void WriteNumber(){} // RVA: 0x7FFE86E829C0 | overloaded x9
        public void WriteNumberEscape(){} // RVA: 0x7FFE86E82AB0 | overloaded x4
        public void WriteNumberEscapeProperty(){} // RVA: 0x7FFE86E82C80 | overloaded x4
        public void WriteNumberByOptions(){} // RVA: 0x7FFE86E830C0 | overloaded x4
        public void WriteNumberMinimized(){} // RVA: 0x7FFE86E83130 | overloaded x4
        public void WriteNumberIndented(){} // RVA: 0x7FFE86E83400 | overloaded x4
        public void ValidatePropertyNameAndDepth(){} // RVA: 0x7FFE86E79EC0
        public void ValidateDepth(){} // RVA: 0x7FFE86E79F40
        public void ValidateWritingProperty(){} // RVA: 0x7FFE86E79FB0 | overloaded x2
        public void WritePropertyNameMinimized(){} // RVA: 0x7FFE86E7A5E0 | overloaded x2
        public void WritePropertyNameIndented(){} // RVA: 0x7FFE86E7A7E0 | overloaded x2
        public void TranscodeAndWrite(){} // RVA: 0x7FFE86E7AB10
        public void WriteNull(){} // RVA: 0x7FFE86E7B1B0 | overloaded x3
        public void WriteNullSection(){} // RVA: 0x7FFE86E7ADE0
        public void WriteLiteralHelper(){} // RVA: 0x7FFE86E7B000
        public void WriteBoolean(){} // RVA: 0x7FFE86E7B580 | overloaded x2
        public void WriteLiteralEscape(){} // RVA: 0x7FFE86E7B730
        public void WriteLiteralEscapeProperty(){} // RVA: 0x7FFE86E7B930
        public void WriteLiteralByOptions(){} // RVA: 0x7FFE86E883E0 | overloaded x3
        public void WriteLiteralMinimized(){} // RVA: 0x7FFE86E88450 | overloaded x3
        public void WriteLiteralSection(){} // RVA: 0x7FFE86E7C440
        public void WriteLiteralIndented(){} // RVA: 0x7FFE86E885F0 | overloaded x3
        public void WritePropertyNameSection(){} // RVA: 0x7FFE86E7E450
        public void WritePropertyNameHelper(){} // RVA: 0x7FFE86E7E560
        public void WriteStringByOptionsPropertyName(){} // RVA: 0x7FFE86E7F9A0 | overloaded x2
        public void WriteStringMinimizedPropertyName(){} // RVA: 0x7FFE86E7FA10 | overloaded x2
        public void WriteStringIndentedPropertyName(){} // RVA: 0x7FFE86E7FDF0 | overloaded x2
        public void WritePropertyNameUnescaped(){} // RVA: 0x7FFE86E7F420
        public void WriteStringPropertyNameSection(){} // RVA: 0x7FFE86E7FC50
        public void WriteStringHelperEscapeValue(){} // RVA: 0x7FFE86E80840
        public void WriteStringEscapeValueOnly(){} // RVA: 0x7FFE86E80AA0
        public void WriteStringEscapePropertyOrValue(){} // RVA: 0x7FFE86E81200
        public void WriteBase64StringValue(){} // RVA: 0x7FFE86E83AB0
        public void WriteBase64ByOptions(){} // RVA: 0x7FFE86E83BA0
        public void WriteBase64Minimized(){} // RVA: 0x7FFE86E83C10
        public void WriteBase64Indented(){} // RVA: 0x7FFE86E83E20
        public void WriteStringValue(){} // RVA: 0x7FFE86E8A300 | overloaded x7
        public void WriteStringValueMinimized(){} // RVA: 0x7FFE86E87740 | overloaded x3
        public void WriteStringValueIndented(){} // RVA: 0x7FFE86E87970 | overloaded x3
        public void WriteNumberValue(){} // RVA: 0x7FFE86E8B020 | overloaded x8
        public void WriteNumberValueMinimized(){} // RVA: 0x7FFE86E8B240 | overloaded x6
        public void WriteNumberValueIndented(){} // RVA: 0x7FFE86E8B420 | overloaded x6
        public void WriteNumberValueAsString(){} // RVA: 0x7FFE86E8B6F0 | overloaded x5
        public void TryFormatDouble(){} // RVA: 0x7FFE86E85B40
        public void WriteFloatingPointConstant(){} // RVA: 0x7FFE86E86ED0 | overloaded x2
        public void TryFormatSingle(){} // RVA: 0x7FFE86E86990
        public void ValidateWritingValue(){} // RVA: 0x7FFE86E87C50
        public void Base64EncodeAndWrite(){} // RVA: 0x7FFE86E87CC0
        public void WriteNullValue(){} // RVA: 0x7FFE86E88140
        public void WriteBooleanValue(){} // RVA: 0x7FFE86E88210
        public void WriteRawValue(){} // RVA: 0x7FFE86E88890
        public void WriteRawValueCore(){} // RVA: 0x7FFE86E88930
        public void WriteStringEscapeValue(){} // RVA: 0x7FFE86E8AB80 | overloaded x2
        public void WriteNumberValueAsStringUnescaped(){} // RVA: 0x7FFE86E8AFA0
        public void .cctor(){} // RVA: 0x7FFE86E8BA30
    }

    public class Utf8JsonWriterCache : Object
    {
        // ── Methods ──
        public void RentWriterAndBuffer(){} // RVA: 0x7FFE873E88A0
        public void RentWriter(){} // RVA: 0x7FFE873E8C50
        public void ReturnWriterAndBuffer(){} // RVA: 0x7FFE873E8E30
        public void ReturnWriter(){} // RVA: 0x7FFE873E8FC0
    }

    public class WriteStack : ValueType
    {
        public System.Text.Json.WriteStackFrame Current; // 0x10

        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x7FFE86E6F250
        public void EnsurePushCapacity(){} // RVA: 0x7FFE86E6F260
        public void Initialize(){} // RVA: 0x7FFE86E6F370 | overloaded x2
        public void Push(){} // RVA: 0x7FFE86E6F550
        public void Pop(){} // RVA: 0x7FFE86E6F800
        public void AddCompletedAsyncDisposable(){} // RVA: 0x7FFE86E6FA30
        public void DisposePendingDisposablesOnException(){} // RVA: 0x7FFE86E6FB70
        public void PropertyPath(){} // RVA: 0x7FFE86E6FC60
        public void <DisposePendingDisposablesOnException>g__DisposeFrame|21_0(){} // RVA: 0x7FFE86E6FDB0
        public void <PropertyPath>g__AppendStackFrame|23_0(){} // RVA: 0x7FFE86E6FE30
        public void <PropertyPath>g__AppendPropertyName|23_1(){} // RVA: 0x7FFE86E6FF50
    }

    public class WriteStackFrame : ValueType
    {
        // ── Methods ──
        public void EndDictionaryElement(){} // RVA: 0x7FFE86E70060
        public void EndProperty(){} // RVA: 0x7FFE86E70070
        public void GetPolymorphicJsonPropertyInfo(){} // RVA: 0x7FFE86E70170
        public void InitializeReEntry(){} // RVA: 0x7FFE86E70180
    }

}