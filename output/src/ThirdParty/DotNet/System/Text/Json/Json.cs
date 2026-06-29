// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json
// Classes: 67
// Methods: 1654

namespace ThirdParty.DotNet.System.Text.Json
{
    public class AppContextSwitchHelper : Object
    {
        public object _isSourceGenReflectionFallbackEnabled;

        // ── Methods ──
        public void get_IsSourceGenReflectionFallbackEnabled(){} // RVA: 0x72B3750
        public void .cctor(){} // RVA: 0x72B37B0
    }

    public class ArgumentState : Object
    {
        public object Arguments;
        public object FoundProperties;
        public object FoundPropertiesAsync;
        public object FoundPropertyCount;
        public object JsonParameterInfo;
        public object ParameterIndex;
        public object ParameterRefCache;
        public object FoundKey;
        public object FoundValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ArgumentState : Object
    {
        public object Arguments;
        public object FoundProperties;
        public object FoundPropertiesAsync;
        public object FoundPropertyCount;
        public object JsonParameterInfo;
        public object ParameterIndex;
        public object ParameterRefCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Arguments`4 : Object
    {
        public object Arg0;
        public object Arg1;
        public object Arg2;
        public object Arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class Arguments`4 : Object
    {
        public object Arg0;
        public object Arg1;
        public object Arg2;
        public object Arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class BitStack : ValueType
    {
        public object _array;
        public object _allocationFreeContainer;
        public object _currentDepth;

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x8C7E0
        public void PushTrue(){} // RVA: 0x8ED400
        public void PushFalse(){} // RVA: 0x8ED440
        public void PushToArray(){} // RVA: 0x8ED480
        public void Pop(){} // RVA: 0x8ED490
        public void PopFromArray(){} // RVA: 0x8ED4D0
        public void DoubleArray(){} // RVA: 0x8ED4E0
        public void SetFirstBit(){} // RVA: 0x8ED4F0
        public void ResetFirstBit(){} // RVA: 0x8ED500
        public void Div32Rem(){} // RVA: 0x6D6D4B0
    }

    public class BitStack : ValueType
    {
        public object AllocationFreeMaxDepth;
        public object DefaultInitialArraySize;
        public object _array;
        public object _allocationFreeContainer;
        public object _currentDepth;

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x8C7E0
        public void PushTrue(){} // RVA: 0x90CAC0
        public void PushFalse(){} // RVA: 0x90CB00
        public void PushToArray(){} // RVA: 0x90CB40
        public void Pop(){} // RVA: 0x8ED490
        public void PopFromArray(){} // RVA: 0x8ED4D0
        public void DoubleArray(){} // RVA: 0x90CB50
        public void SetFirstBit(){} // RVA: 0x8ED4F0
        public void ResetFirstBit(){} // RVA: 0x8ED500
        public void Div32Rem(){} // RVA: 0x6D6D4B0
    }

    public class JsonCamelCaseNamingPolicy : JsonNamingPolicy
    {
        // ── Methods ──
        public void ConvertName(){} // RVA: 0x6D6A810
        public void FixCasing(){} // RVA: 0x6D6A920
        public void .ctor(){} // RVA: 0x6D6AAB0
    }

    public class JsonCamelCaseNamingPolicy : JsonNamingPolicy
    {
        // ── Methods ──
        public void ConvertName(){} // RVA: 0x72AFF80
        public void FixCasing(){} // RVA: 0x72B0080
        public void .ctor(){} // RVA: 0x72B0210
    }

    public class JsonConstants : Object
    {
        // ── Methods ──
        public void get_Utf8Bom(){} // RVA: 0x6D6AC50
        public void get_TrueValue(){} // RVA: 0x6D6ACC0
        public void get_FalseValue(){} // RVA: 0x6D6AD30
        public void get_NullValue(){} // RVA: 0x6D6ADA0
        public void get_NaNValue(){} // RVA: 0x6D6AE10
        public void get_PositiveInfinityValue(){} // RVA: 0x6D6AE80
        public void get_NegativeInfinityValue(){} // RVA: 0x6D6AEF0
        public void get_Delimiters(){} // RVA: 0x6D6AF60
        public void get_EscapableChars(){} // RVA: 0x6D6AFD0
    }

    public class JsonConstants : Object
    {
        public object DoubleFormatString;
        public object SingleFormatString;
        public object StackallocByteThreshold;
        public object StackallocCharThreshold;
        public object OpenBrace;
        public object CloseBrace;
        public object OpenBracket;
        public object CloseBracket;
        public object Space;
        public object CarriageReturn;
        public object LineFeed;
        public object Tab;
        public object ListSeparator;
        public object KeyValueSeparator;
        public object Quote;
        public object BackSlash;
        public object Slash;
        public object BackSpace;
        public object FormFeed;
        public object Asterisk;
        public object Colon;
        public object Period;
        public object Plus;
        public object Hyphen;
        public object UtcOffsetToken;
        public object TimePrefix;
        public object StartingByteOfNonStandardSeparator;
        public object SpacesPerIndent;
        public object RemoveFlagsBitMask;
        public object MaxExpansionFactorWhileEscaping;
        public object MaxExpansionFactorWhileTranscoding;
        public object ArrayPoolMaxSizeBeforeUsingNormalAlloc;
        public object MaxUtf16RawValueLength;
        public object MaxEscapedTokenSize;
        public object MaxUnescapedTokenSize;
        public object MaxCharacterTokenSize;
        public object MaximumFormatBooleanLength;
        public object MaximumFormatInt64Length;
        public object MaximumFormatUInt64Length;
        public object MaximumFormatDoubleLength;
        public object MaximumFormatSingleLength;
        public object MaximumFormatDecimalLength;
        public object MaximumFormatGuidLength;
        public object MaximumEscapedGuidLength;
        public object MaximumFormatDateTimeLength;
        public object MaximumFormatDateTimeOffsetLength;
        public object MaxDateTimeUtcOffsetHours;
        public object DateTimeNumFractionDigits;
        public object MaxDateTimeFraction;
        public object DateTimeParseNumFractionDigits;
        public object MaximumDateTimeOffsetParseLength;
        public object MinimumDateTimeParseLength;
        public object MaximumEscapedDateTimeOffsetParseLength;
        public object MaximumLiteralLength;
        public object HighSurrogateStart;
        public object HighSurrogateEnd;
        public object LowSurrogateStart;
        public object LowSurrogateEnd;
        public object UnicodePlane01StartValue;
        public object HighSurrogateStartValue;
        public object HighSurrogateEndValue;
        public object LowSurrogateStartValue;
        public object LowSurrogateEndValue;
        public object BitShiftBy10;
        public object UnboxedParameterCountThreshold;

        // ── Methods ──
        public void get_Utf8Bom(){} // RVA: 0x72B0890
        public void get_TrueValue(){} // RVA: 0x72B08F0
        public void get_FalseValue(){} // RVA: 0x72B0950
        public void get_NullValue(){} // RVA: 0x72B09B0
        public void get_NaNValue(){} // RVA: 0x72B0A10
        public void get_PositiveInfinityValue(){} // RVA: 0x72B0A70
        public void get_NegativeInfinityValue(){} // RVA: 0x72B0AD0
        public void get_Delimiters(){} // RVA: 0x72B0B30
        public void get_EscapableChars(){} // RVA: 0x72B0B90
    }

    public class JsonDocument : Object
    {
        public object _utf8Json;
        public object _parsedData;
        public object _extraRentedArrayPoolBytes;
        public object _hasExtraRentedArrayPoolBytes;
        public object _extraPooledByteBufferWriter;
        public object _hasExtraPooledByteBufferWriter;
        public object _isDisposable;
        public object s_nullLiteral;
        public object s_trueLiteral;
        public object s_falseLiteral;

        // ── Methods ──
        public void get_IsDisposable(){} // RVA: 0x24BED30
        public void get_RootElement(){} // RVA: 0x6D6D4C0
        public void .ctor(){} // RVA: 0x6D6D530
        public void Dispose(){} // RVA: 0x6D6D6E0
        public void WriteTo(){} // RVA: 0x6D6D930
        public void GetJsonTokenType(){} // RVA: 0x6D6DA30
        public void GetArrayLength(){} // RVA: 0x6D6DA60
        public void GetArrayIndexElement(){} // RVA: 0x6D6DAE0
        public void GetEndIndex(){} // RVA: 0x6D6DCB0
        public void GetRawValue(){} // RVA: 0x6D6DD30
        public void GetPropertyRawValue(){} // RVA: 0x6D6DF90
        public void GetString(){} // RVA: 0x6D6E270
        public void TextEquals(){} // RVA: 0x6D6E550
        public void GetNameOfPropertyValue(){} // RVA: 0x6D6EA40
        public void TryGetValue(){} // RVA: 0x6D6F6D0
        public void GetRawValueAsString(){} // RVA: 0x6D6F9A0
        public void GetPropertyRawValueAsString(){} // RVA: 0x6D6FA60
        public void CloneElement(){} // RVA: 0x6D6FB20
        public void WriteElementTo(){} // RVA: 0x6D6FE60
        public void WriteComplexElement(){} // RVA: 0x6D70480
        public void UnescapeString(){} // RVA: 0x6D70740
        public void ClearAndReturn(){} // RVA: 0x6D70DF0
        public void WritePropertyName(){} // RVA: 0x6D70FC0
        public void WriteString(){} // RVA: 0x6D711E0
        public void Parse(){} // RVA: 0x6D73670
        public void CheckNotDisposed(){} // RVA: 0x6D716D0
        public void CheckExpectedType(){} // RVA: 0x6D71760
        public void CheckSupportedOptions(){} // RVA: 0x6D717B0
        public void ParseAsync(){} // RVA: 0x6D71AF0
        public void ParseAsyncCore(){} // RVA: 0x6D71B60
        public void ParseValue(){} // RVA: 0x6D72240
        public void TryParseValue(){} // RVA: 0x6D72270
        public void CreateForLiteral(){} // RVA: 0x6D73320
        public void ParseUnrented(){} // RVA: 0x6D739D0
        public void ReadToEnd(){} // RVA: 0x6D73CA0
        public void ReadToEndAsync(){} // RVA: 0x6D743F0
        public void TryGetNamedPropertyValue(){} // RVA: 0x6D74D80
        public void <CreateForLiteral>g__Create|74_0(){} // RVA: 0x6D75770
    }

    public class JsonDocument : Object
    {
        public object _utf8Json;
        public object _parsedData;
        public object _extraRentedArrayPoolBytes;
        public object _extraPooledByteBufferWriter;
        public object _isDisposable;
        public object s_nullLiteral;
        public object s_trueLiteral;
        public object s_falseLiteral;
        public object UnseekableStreamInitialRentSize;

        // ── Methods ──
        public void get_IsDisposable(){} // RVA: 0xBFDA40
        public void get_RootElement(){} // RVA: 0x6D6D4C0
        public void .ctor(){} // RVA: 0x72B3A80
        public void Dispose(){} // RVA: 0x72B3C00
        public void WriteTo(){} // RVA: 0x72B3F10
        public void GetJsonTokenType(){} // RVA: 0x72B4040
        public void GetArrayLength(){} // RVA: 0x72B40A0
        public void GetArrayIndexElement(){} // RVA: 0x72B4130
        public void GetEndIndex(){} // RVA: 0x72B4310
        public void GetRootRawValue(){} // RVA: 0x72B43C0
        public void GetRawValue(){} // RVA: 0x72B4400
        public void GetPropertyRawValue(){} // RVA: 0x72B4640
        public void GetString(){} // RVA: 0x72B4910
        public void TextEquals(){} // RVA: 0x72B4EB0
        public void GetNameOfPropertyValue(){} // RVA: 0x72B51F0
        public void TryGetValue(){} // RVA: 0x72B6E80
        public void GetRawValueAsString(){} // RVA: 0x72B7130
        public void GetPropertyRawValueAsString(){} // RVA: 0x72B71F0
        public void CloneElement(){} // RVA: 0x72B72A0
        public void WriteElementTo(){} // RVA: 0x72B75E0
        public void WriteComplexElement(){} // RVA: 0x72B7C80
        public void UnescapeString(){} // RVA: 0x72B7F60
        public void ClearAndReturn(){} // RVA: 0x72B83D0
        public void WritePropertyName(){} // RVA: 0x72B8520
        public void WriteString(){} // RVA: 0x72B85D0
        public void Parse(){} // RVA: 0x72BB7E0
        public void CheckNotDisposed(){} // RVA: 0x72B8AD0
        public void CheckExpectedType(){} // RVA: 0x72B8B20
        public void CheckSupportedOptions(){} // RVA: 0x72B8B40
        public void ParseRented(){} // RVA: 0x72B91F0
        public void ParseValue(){} // RVA: 0x72BA5A0
        public void ParseAsync(){} // RVA: 0x72B9840
        public void ParseAsyncCore(){} // RVA: 0x72B98B0
        public void ParseAsyncCoreUnrented(){} // RVA: 0x72B9AC0
        public void TryParseValue(){} // RVA: 0x72BA5D0
        public void CreateForLiteral(){} // RVA: 0x72BB4F0
        public void ParseUnrented(){} // RVA: 0x72BBA00
        public void ReadToEnd(){} // RVA: 0x72BBC60
        public void ReadToEndAsync(){} // RVA: 0x72BC390
        public void TryGetNamedPropertyValue(){} // RVA: 0x72BCDD0
        public void <CreateForLiteral>g__Create|73_0(){} // RVA: 0x72BD610
    }

    public class JsonDocumentOptions : ValueType
    {
        public object _maxDepth;
        public object _commentHandling;
        public object _allowTrailingCommas;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x9B0B0
        public void get_MaxDepth(){} // RVA: 0x77E60
        public void get_AllowTrailingCommas(){} // RVA: 0x9B0F0
        public void GetReaderOptions(){} // RVA: 0x8EDAF0
    }

    public class JsonDocumentOptions : ValueType
    {
        public object DefaultMaxDepth;
        public object _maxDepth;
        public object _commentHandling;
        public object _allowTrailingCommas;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x9B0B0
        public void set_CommentHandling(){} // RVA: 0x90CE40
        public void get_MaxDepth(){} // RVA: 0x77E60
        public void set_MaxDepth(){} // RVA: 0x90CE50
        public void get_AllowTrailingCommas(){} // RVA: 0x9B0F0
        public void set_AllowTrailingCommas(){} // RVA: 0x54200
        public void GetReaderOptions(){} // RVA: 0x90CEB0
    }

    public class JsonElement : ValueType
    {
        public object _parent;
        public object _idx;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void get_TokenType(){} // RVA: 0x8EDBC0
        public void get_ValueKind(){} // RVA: 0x8EDC10
        public void get_Item(){} // RVA: 0x8EDC20
        public void GetArrayLength(){} // RVA: 0x8EDCA0
        public void GetProperty(){} // RVA: 0x8EDCB0
        public void TryGetProperty(){} // RVA: 0x8EDE50
        public void GetBoolean(){} // RVA: 0x8EDEE0
        public void GetString(){} // RVA: 0x8EDEF0
        public void TryGetInt16(){} // RVA: 0x8EDF00
        public void GetInt16(){} // RVA: 0x8EDF10
        public void TryGetInt32(){} // RVA: 0x8EDF20
        public void GetInt32(){} // RVA: 0x8EDF30
        public void TryGetInt64(){} // RVA: 0x8EDF40
        public void GetInt64(){} // RVA: 0x8EDF50
        public void TryGetDouble(){} // RVA: 0x8EDF60
        public void GetDouble(){} // RVA: 0x8EDF70
        public void TryGetSingle(){} // RVA: 0x8EDF80
        public void GetSingle(){} // RVA: 0x8EDF90
        public void TryGetDateTimeOffset(){} // RVA: 0x8EDFA0
        public void GetDateTimeOffset(){} // RVA: 0x8EDFB0
        public void GetPropertyName(){} // RVA: 0x8EE050
        public void GetPropertyRawText(){} // RVA: 0x8EE060
        public void TextEqualsHelper(){} // RVA: 0x8EE070
        public void WriteTo(){} // RVA: 0x8EE100
        public void EnumerateArray(){} // RVA: 0x8EE1B0
        public void EnumerateObject(){} // RVA: 0x8EE1E0
        public void ToString(){} // RVA: 0x8EE210
        public void Clone(){} // RVA: 0x8EE220
        public void CheckValidInstance(){} // RVA: 0x8EE2B0
        public void ParseValue(){} // RVA: 0x6D7A1B0
    }

    public class JsonElement : ValueType
    {
        public object _parent;
        public object _idx;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void get_TokenType(){} // RVA: 0x90CF80
        public void get_ValueKind(){} // RVA: 0x90CF90
        public void get_Item(){} // RVA: 0x90CFA0
        public void GetArrayLength(){} // RVA: 0x90D020
        public void GetProperty(){} // RVA: 0x90D1D0
        public void TryGetProperty(){} // RVA: 0x90D2E0
        public void GetBoolean(){} // RVA: 0x90D300
        public void GetString(){} // RVA: 0x90D330
        public void TryGetBytesFromBase64(){} // RVA: 0x90D340
        public void GetBytesFromBase64(){} // RVA: 0x90D350
        public void TryGetSByte(){} // RVA: 0x90D3D0
        public void GetSByte(){} // RVA: 0x90D3E0
        public void TryGetByte(){} // RVA: 0x90D3F0
        public void GetByte(){} // RVA: 0x90D400
        public void TryGetInt16(){} // RVA: 0x90D410
        public void GetInt16(){} // RVA: 0x90D420
        public void TryGetUInt16(){} // RVA: 0x90D430
        public void GetUInt16(){} // RVA: 0x90D440
        public void TryGetInt32(){} // RVA: 0x90D450
        public void GetInt32(){} // RVA: 0x90D460
        public void TryGetUInt32(){} // RVA: 0x90D470
        public void GetUInt32(){} // RVA: 0x90D480
        public void TryGetInt64(){} // RVA: 0x90D490
        public void GetInt64(){} // RVA: 0x90D4A0
        public void TryGetUInt64(){} // RVA: 0x90D4B0
        public void GetUInt64(){} // RVA: 0x90D4C0
        public void TryGetDouble(){} // RVA: 0x90D4D0
        public void GetDouble(){} // RVA: 0x90D4E0
        public void TryGetSingle(){} // RVA: 0x90D4F0
        public void GetSingle(){} // RVA: 0x90D500
        public void TryGetDecimal(){} // RVA: 0x90D510
        public void GetDecimal(){} // RVA: 0x90D520
        public void TryGetDateTime(){} // RVA: 0x90D5B0
        public void GetDateTime(){} // RVA: 0x90D5C0
        public void TryGetDateTimeOffset(){} // RVA: 0x90D5D0
        public void GetDateTimeOffset(){} // RVA: 0x90D5E0
        public void TryGetGuid(){} // RVA: 0x90D670
        public void GetGuid(){} // RVA: 0x90D680
        public void GetPropertyName(){} // RVA: 0x90D710
        public void GetRawText(){} // RVA: 0x90D720
        public void GetRawValue(){} // RVA: 0x90D780
        public void GetPropertyRawText(){} // RVA: 0x90D800
        public void ValueEquals(){} // RVA: 0x90D9F0
        public void TextEqualsHelper(){} // RVA: 0x90DB70
        public void WriteTo(){} // RVA: 0x90DBF0
        public void EnumerateArray(){} // RVA: 0x90DCA0
        public void EnumerateObject(){} // RVA: 0x90DD60
        public void ToString(){} // RVA: 0x90DE20
        public void Clone(){} // RVA: 0x90DE30
        public void CheckValidInstance(){} // RVA: 0x90DEC0
        public void get_DebuggerDisplay(){} // RVA: 0x90DF20
        public void ParseValue(){} // RVA: 0x72C3170
        public void TryParseValue(){} // RVA: 0x72C32D0
        public void <GetBoolean>g__ThrowJsonElementWrongTypeException|17_0(){} // RVA: 0x72C3480
    }

    public class JsonEncodedText : ValueType
    {
        public object _utf8Value;
        public object _value;

        // ── Methods ──
        public void get_EncodedUtf8Bytes(){} // RVA: 0x90EAD0
        public void get_Value(){} // RVA: 0x8BFE10
        public void .ctor(){} // RVA: 0x90EB70
        public void Encode(){} // RVA: 0x72C49C0
        public void TranscodeAndEncode(){} // RVA: 0x72C45A0
        public void EncodeHelper(){} // RVA: 0x72C4BC0
        public void Equals(){} // RVA: 0x90EB80
        public void ToString(){} // RVA: 0x8BFE10
        public void GetHashCode(){} // RVA: 0x8EED50
    }

    public class JsonEncodedText : ValueType
    {
        public object _utf8Value;
        public object _value;

        // ── Methods ──
        public void get_EncodedUtf8Bytes(){} // RVA: 0x8EEC40
        public void .ctor(){} // RVA: 0x8EECE0
        public void Encode(){} // RVA: 0x6D7AE80
        public void TranscodeAndEncode(){} // RVA: 0x6D7AF50
        public void EncodeHelper(){} // RVA: 0x6D7B460
        public void Equals(){} // RVA: 0x8EED40
        public void ToString(){} // RVA: 0x8BFE10
        public void GetHashCode(){} // RVA: 0x8EED50
    }

    public class JsonException : Exception
    {
        public object _message;
        public object _appendPathInformation;
        public object _lineNumber;
        public object _bytePositionInLine;
        public object _path;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D7BA20
        public void get_AppendPathInformation(){} // RVA: 0x11319D0
        public void set_AppendPathInformation(){} // RVA: 0x112ECB0
        public void GetObjectData(){} // RVA: 0x6D7BDF0
        public void get_LineNumber(){} // RVA: 0x6BA2BC0
        public void set_LineNumber(){} // RVA: 0x6BA2BD0
        public void get_BytePositionInLine(){} // RVA: 0x131E8D0
        public void set_BytePositionInLine(){} // RVA: 0x131E370
        public void get_Path(){} // RVA: 0xBAE420
        public void set_Path(){} // RVA: 0xBAE430
        public void get_Message(){} // RVA: 0x6D7C320
        public void SetMessage(){} // RVA: 0xD5CC10
    }

    public class JsonException : Exception
    {
        public object _message;
        public object _appendPathInformation;
        public object _lineNumber;
        public object _bytePositionInLine;
        public object _path;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72C5210
        public void get_AppendPathInformation(){} // RVA: 0x11319D0
        public void set_AppendPathInformation(){} // RVA: 0x112ECB0
        public void GetObjectData(){} // RVA: 0x72C55E0
        public void get_LineNumber(){} // RVA: 0x6BA2BC0
        public void set_LineNumber(){} // RVA: 0x6BA2BD0
        public void get_BytePositionInLine(){} // RVA: 0x131E8D0
        public void set_BytePositionInLine(){} // RVA: 0x131E370
        public void get_Path(){} // RVA: 0xBAE420
        public void set_Path(){} // RVA: 0xBAE430
        public void get_Message(){} // RVA: 0x6D7C320
        public void SetMessage(){} // RVA: 0xD5CC10
    }

    public class JsonHelpers : Object
    {
        public object s_daysToMonth365;
        public object s_daysToMonth366;

        // ── Methods ──
        public void TryAdd(){} // RVA: 0x880B90
        public void GetSpan(){} // RVA: 0x6D6B040
        public void IsInRangeInclusive(){} // RVA: 0x6D6B130
        public void IsDigit(){} // RVA: 0x6D6B140
        public void ReadWithVerify(){} // RVA: 0x6D6B150
        public void Utf8GetString(){} // RVA: 0x6D6B160
        public void CreateDictionaryFromCollection(){} // RVA: 0x87C630
        public void IsFinite(){} // RVA: 0x6D6B220
        public void ValidateInt32MaxArrayLength(){} // RVA: 0x6D6B250
        public void IsValidDateTimeOffsetParseLength(){} // RVA: 0x6D6B270
        public void TryParseAsISO(){} // RVA: 0x6D6B490
        public void TryParseDateTimeOffset(){} // RVA: 0x6D6B610
        public void TryGetNextTwoDigits(){} // RVA: 0x6D6BCB0
        public void TryCreateDateTimeOffset(){} // RVA: 0x6D6BEA0
        public void TryCreateDateTimeOffsetInterpretingDataAsLocalTime(){} // RVA: 0x6D6BFB0
        public void TryCreateDateTime(){} // RVA: 0x6D6C0B0
        public void GetEscapedPropertyNameSection(){} // RVA: 0x6D6C820
        public void EscapeValue(){} // RVA: 0x6D6C4E0
        public void GetPropertyNameSection(){} // RVA: 0x6D6CC30
        public void .cctor(){} // RVA: 0x6D6CDE0
        public void <TryParseDateTimeOffset>g__ParseOffset|22_0(){} // RVA: 0x6D6CF80
    }

    public class JsonHelpers : Object
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0xA94080
        public void TryDequeue(){} // RVA: 0x87D880
        public void RequiresSpecialNumberHandlingOnWrite(){} // RVA: 0x72B0BF0
        public void StableSortByKey(){} // RVA: 0x8945C0
        public void TraverseGraphWithTopologicalSort(){} // RVA: 0xA94080
        public void GetSpan(){} // RVA: 0x72B0C50
        public void IsValidUnicodeScalar(){} // RVA: 0x72B0D40
        public void IsInRangeInclusive(){} // RVA: 0x72B0D60
        public void IsDigit(){} // RVA: 0x6D6B140
        public void ReadWithVerify(){} // RVA: 0x72B0D70
        public void Utf8GetString(){} // RVA: 0x72B0D80
        public void CreateDictionaryFromCollection(){} // RVA: 0x87C630
        public void IsFinite(){} // RVA: 0x6D6B220
        public void ValidateInt32MaxArrayLength(){} // RVA: 0x72B0E00
        public void HasAllSet(){} // RVA: 0x72B0E20
        public void IsValidDateTimeOffsetParseLength(){} // RVA: 0x72B0E80
        public void IsValidUnescapedDateTimeOffsetParseLength(){} // RVA: 0x72B0E90
        public void TryParseAsISO(){} // RVA: 0x72B0FE0
        public void TryParseDateTimeOffset(){} // RVA: 0x72B1110
        public void TryGetNextTwoDigits(){} // RVA: 0x72B1780
        public void TryCreateDateTimeOffset(){} // RVA: 0x72B1910
        public void TryCreateDateTimeOffsetInterpretingDataAsLocalTime(){} // RVA: 0x72B19A0
        public void TryCreateDateTime(){} // RVA: 0x72B1A50
        public void get_DaysToMonth365(){} // RVA: 0x72B1EC0
        public void get_DaysToMonth366(){} // RVA: 0x72B2030
        public void GetEscapedPropertyNameSection(){} // RVA: 0x72B2540
        public void EscapeValue(){} // RVA: 0x72B2260
        public void GetPropertyNameSection(){} // RVA: 0x72B2830
        public void <TryParseDateTimeOffset>g__ParseOffset|24_0(){} // RVA: 0x72B2960
    }

    public class JsonKebabCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72B2AF0
    }

    public class JsonKebabCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72B2B40
    }

    public class JsonNamingPolicy : Object
    {
        public object _camelCase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_CamelCase(){} // RVA: 0x6D6AB00
        public void ConvertName(){} // RVA: 0x87C540
        public void .cctor(){} // RVA: 0x6D6AB60
    }

    public class JsonNamingPolicy : Object
    {
        public object _camelCase;
        public object _snakeCaseLower;
        public object _snakeCaseUpper;
        public object _kebabCaseLower;
        public object _kebabCaseUpper;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_CamelCase(){} // RVA: 0x72B0260
        public void get_SnakeCaseLower(){} // RVA: 0x72B02C0
        public void get_SnakeCaseUpper(){} // RVA: 0x72B0320
        public void get_KebabCaseLower(){} // RVA: 0x72B0380
        public void get_KebabCaseUpper(){} // RVA: 0x72B03E0
        public void ConvertName(){} // RVA: 0x87C540
        public void .cctor(){} // RVA: 0x72B0440
    }

    public class JsonProperty : ValueType
    {
        public object _value;
        public object __name;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7BF80
        public void get__name(){} // RVA: 0x7E450
        public void .ctor(){} // RVA: 0x662C10
        public void get_Name(){} // RVA: 0x8EE9A0
        public void EscapedNameEquals(){} // RVA: 0x8EE9B0
        public void ToString(){} // RVA: 0x8EEA40
    }

    public class JsonProperty : ValueType
    {
        public object _value;
        public object __name;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7BF80
        public void get__name(){} // RVA: 0x7E450
        public void .ctor(){} // RVA: 0x662C10
        public void get_Name(){} // RVA: 0x90E6B0
        public void NameEquals(){} // RVA: 0x90E820
        public void EscapedNameEquals(){} // RVA: 0x90E8A0
        public void WriteTo(){} // RVA: 0x90E930
        public void ToString(){} // RVA: 0x90EA20
        public void get_DebuggerDisplay(){} // RVA: 0x90EA40
    }

    public class JsonPropertyDictionary`1 : Object
    {
        public object _propertyDictionary;
        public object _propertyList;
        public object _stringComparer;
        public object _isReadOnly;
        public object _keyCollection;
        public object _valueCollection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894E70
        public void get_List(){} // RVA: 0x87C0A0
        public void Add(){} // RVA: 0xA94080
        public void TryAdd(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void ContainsKey(){} // RVA: 0x87D350
        public void get_Count(){} // RVA: 0x87C130
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void TryGetValue(){} // RVA: 0x87D3C0
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void SetValue(){} // RVA: 0xA94080
        public void AddValue(){} // RVA: 0xA94080
        public void TryAddValue(){} // RVA: 0xA94080
        public void CreateDictionaryIfThresholdMet(){} // RVA: 0x894290
        public void ContainsValue(){} // RVA: 0xA94080
        public void ContainsProperty(){} // RVA: 0x87D350
        public void FindValueIndex(){} // RVA: 0x87D050
        public void TryGetPropertyValue(){} // RVA: 0x87D3C0
        public void TryRemoveProperty(){} // RVA: 0x87D3C0
        public void GetKeyCollection(){} // RVA: 0x87C0A0
        public void GetValueCollection(){} // RVA: 0x87C0A0
    }

    public class JsonPropertyDictionary`1 : Object
    {
        public object ListToDictionaryThreshold;
        public object _propertyDictionary;
        public object _propertyList;
        public object _stringComparer;
        public object _isReadOnly;
        public object _keyCollection;
        public object _valueCollection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894E70
        public void get_List(){} // RVA: 0x87C0A0
        public void Add(){} // RVA: 0xA94080
        public void TryAdd(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void ContainsKey(){} // RVA: 0x87D350
        public void get_Count(){} // RVA: 0x87C130
        public void Remove(){} // RVA: 0x87D350
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void GetEnumerator(){} // RVA: 0xA94080
        public void get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void TryGetValue(){} // RVA: 0x87D3C0
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void set_IsReadOnly(){} // RVA: 0x894750
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void SetValue(){} // RVA: 0xA94080
        public void AddValue(){} // RVA: 0xA94080
        public void TryAddValue(){} // RVA: 0xA94080
        public void CreateDictionaryIfThresholdMet(){} // RVA: 0x894290
        public void ContainsValue(){} // RVA: 0xA94080
        public void FindValue(){} // RVA: 0xA94080
        public void ContainsProperty(){} // RVA: 0x87D350
        public void FindValueIndex(){} // RVA: 0x87D050
        public void TryGetPropertyValue(){} // RVA: 0x87D3C0
        public void TryRemoveProperty(){} // RVA: 0x87D3C0
        public void GetKeyCollection(){} // RVA: 0x87C0A0
        public void GetValueCollection(){} // RVA: 0x87C0A0
    }

    public class JsonReaderException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D7C4D0
    }

    public class JsonReaderException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72C5CA0
    }

    public class JsonReaderHelper : Object
    {
        public object SpecialCharacters;
        public object s_utf8Encoding;
        public object XorPowerOfTwoToHighByte;

        // ── Methods ──
        public void ContainsSpecialCharacters(){} // RVA: 0x72C5CC0
        public void CountNewLines(){} // RVA: 0x72C5D80
        public void ToValueKind(){} // RVA: 0x6D7C5E0
        public void IsTokenTypePrimitive(){} // RVA: 0x6D7C640
        public void IsHexDigit(){} // RVA: 0x6D7C650
        public void TryGetEscapedDateTime(){} // RVA: 0x72C5F30
        public void TryGetEscapedDateTimeOffset(){} // RVA: 0x72C6140
        public void TryGetEscapedGuid(){} // RVA: 0x72C6360
        public void TryGetFloatingPointConstant(){} // RVA: 0x72C6860
        public void TryGetUnescapedBase64Bytes(){} // RVA: 0x72C6AD0
        public void GetUnescapedString(){} // RVA: 0x72C6F50
        public void GetUnescapedSpan(){} // RVA: 0x72C7290
        public void UnescapeAndCompare(){} // RVA: 0x72C79C0
        public void TryDecodeBase64InPlace(){} // RVA: 0x72C7FA0
        public void TryDecodeBase64(){} // RVA: 0x72C8150
        public void TranscodeHelper(){} // RVA: 0x72C8740
        public void ValidateUtf8(){} // RVA: 0x72C8930
        public void GetUtf8ByteCount(){} // RVA: 0x72C8A70
        public void GetUtf8FromText(){} // RVA: 0x72C8BB0
        public void GetTextFromUtf8(){} // RVA: 0x72C8D80
        public void Unescape(){} // RVA: 0x72C9000
        public void TryUnescape(){} // RVA: 0x72C9170
        public void TryEncodeToUtf8Bytes(){} // RVA: 0x72C9BB0
        public void IndexOfQuoteOrAnyControlOrBackSlash(){} // RVA: 0x72C9D60
        public void LocateFirstFoundByte(){} // RVA: 0x6D2E1E0
        public void .cctor(){} // RVA: 0x72CA200
    }

    public class JsonReaderHelper : Object
    {
        public object s_utf8Encoding;

        // ── Methods ──
        public void CountNewLines(){} // RVA: 0x6D7C4F0
        public void ToValueKind(){} // RVA: 0x6D7C5E0
        public void IsTokenTypePrimitive(){} // RVA: 0x6D7C640
        public void IsHexDigit(){} // RVA: 0x6D7C650
        public void IndexOfQuoteOrAnyControlOrBackSlash(){} // RVA: 0x6D7C680
        public void IndexOfOrLessThan(){} // RVA: 0x6D7C750
        public void LocateFirstFoundByte(){} // RVA: 0x6D2E1E0
        public void TryGetEscapedDateTime(){} // RVA: 0x6D7CBC0
        public void TryGetEscapedDateTimeOffset(){} // RVA: 0x6D7CF40
        public void TryGetEscapedGuid(){} // RVA: 0x6D7D2D0
        public void TryGetFloatingPointConstant(){} // RVA: 0x6D7D9D0
        public void TryGetUnescapedBase64Bytes(){} // RVA: 0x6D7DCB0
        public void GetUnescapedString(){} // RVA: 0x6D7E010
        public void GetUnescapedSpan(){} // RVA: 0x6D7E400
        public void UnescapeAndCompare(){} // RVA: 0x6D7E820
        public void TryDecodeBase64InPlace(){} // RVA: 0x6D7EC90
        public void TryDecodeBase64(){} // RVA: 0x6D7EEE0
        public void TranscodeHelper(){} // RVA: 0x6D7F380
        public void GetUtf8ByteCount(){} // RVA: 0x6D7F5A0
        public void GetUtf8FromText(){} // RVA: 0x6D7F6E0
        public void GetTextFromUtf8(){} // RVA: 0x6D7F8D0
        public void Unescape(){} // RVA: 0x6D7FA90
        public void EncodeToUtf8Bytes(){} // RVA: 0x6D80340
        public void .cctor(){} // RVA: 0x6D805B0
    }

    public class JsonReaderOptions : ValueType
    {
        public object _maxDepth;
        public object _commentHandling;
        public object _allowTrailingCommas;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x9B0B0
        public void set_CommentHandling(){} // RVA: 0x8EED80
        public void get_MaxDepth(){} // RVA: 0x77E60
        public void set_MaxDepth(){} // RVA: 0x8EEDD0
        public void get_AllowTrailingCommas(){} // RVA: 0x9B0F0
        public void set_AllowTrailingCommas(){} // RVA: 0x54200
    }

    public class JsonReaderOptions : ValueType
    {
        public object DefaultMaxDepth;
        public object _maxDepth;
        public object _commentHandling;
        public object _allowTrailingCommas;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x9B0B0
        public void set_CommentHandling(){} // RVA: 0x90EB90
        public void get_MaxDepth(){} // RVA: 0x77E60
        public void set_MaxDepth(){} // RVA: 0x90EBF0
        public void get_AllowTrailingCommas(){} // RVA: 0x9B0F0
        public void set_AllowTrailingCommas(){} // RVA: 0x54200
    }

    public class JsonReaderState : ValueType
    {
        public object _lineNumber;
        public object _bytePositionInLine;
        public object _inObject;
        public object _isNotPrimitive;
        public object _stringHasEscaping;
        public object _trailingCommaBeforeComment;
        public object _tokenType;
        public object _previousTokenType;
        public object _readerOptions;
        public object _bitStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8EF050
        public void get_Options(){} // RVA: 0x931A0
    }

    public class JsonReaderState : ValueType
    {
        public object _lineNumber;
        public object _bytePositionInLine;
        public object _inObject;
        public object _isNotPrimitive;
        public object _valueIsEscaped;
        public object _trailingCommaBeforeComment;
        public object _tokenType;
        public object _previousTokenType;
        public object _readerOptions;
        public object _bitStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8EF050
        public void get_Options(){} // RVA: 0x931A0
    }

    public class JsonSeparatorNamingPolicy : JsonNamingPolicy
    {
        public object _lowercase;
        public object _separator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72B2B90
        public void ConvertName(){} // RVA: 0x72B2C00
        public void ConvertNameCore(){} // RVA: 0x72B2CC0
        public void <ConvertNameCore>g__WriteChar|4_0(){} // RVA: 0x72B3360
        public void <ConvertNameCore>g__ExpandBuffer|4_1(){} // RVA: 0x72B33E0
    }

    public class JsonSerializer : Object
    {
        public object SerializationUnreferencedCodeMessage;
        public object SerializationRequiresDynamicCodeMessage;
        public object _isReflectionEnabledByDefault;
        public object IdPropertyName;
        public object RefPropertyName;
        public object TypePropertyName;
        public object ValuesPropertyName;
        public object s_idPropertyName;
        public object s_refPropertyName;
        public object s_typePropertyName;
        public object s_valuesPropertyName;
        public object s_metadataId;
        public object s_metadataRef;
        public object s_metadataType;
        public object s_metadataValues;
        public object FlushThreshold;

        // ── Methods ──
        public void Serialize(){} // RVA: 0x730DBE0
        public void Deserialize(){} // RVA: 0x730B570
        public void ReadFromNode(){} // RVA: 0xA94080
        public void ReadFromNodeAsObject(){} // RVA: 0x7306A70
        public void SerializeToDocument(){} // RVA: 0x7306EF0
        public void WriteDocument(){} // RVA: 0x87C630
        public void WriteDocumentAsObject(){} // RVA: 0x7307060
        public void SerializeToElement(){} // RVA: 0x73073D0
        public void WriteElement(){} // RVA: 0xA94080
        public void WriteElementAsObject(){} // RVA: 0x7307560
        public void SerializeToNode(){} // RVA: 0x7307900
        public void WriteNode(){} // RVA: 0x87C630
        public void WriteNodeAsObject(){} // RVA: 0x7307A70
        public void get_IsReflectionEnabledByDefault(){} // RVA: 0x7307C30
        public void GetTypeInfo(){} // RVA: 0x7307E80
        public void ValidateInputType(){} // RVA: 0x7307F00
        public void IsValidNumberHandlingValue(){} // RVA: 0x7307F90
        public void IsValidCreationHandlingValue(){} // RVA: 0x7307FA0
        public void IsValidUnmappedMemberHandlingValue(){} // RVA: 0x7307FA0
        public void UnboxOnRead(){} // RVA: 0xA94080
        public void UnboxOnWrite(){} // RVA: 0x3131580
        public void TryReadMetadata(){} // RVA: 0x7307FB0
        public void IsMetadataPropertyName(){} // RVA: 0x7308990
        public void GetMetadataPropertyName(){} // RVA: 0x7308AF0
        public void TryHandleReferenceFromJsonElement(){} // RVA: 0x7308DB0
        public void TryHandleReferenceFromJsonNode(){} // RVA: 0x7309480
        public void ValidateMetadataForObjectConverter(){} // RVA: 0x73099B0
        public void ValidateMetadataForArrayConverter(){} // RVA: 0x7309A40
        public void ResolveReferenceId(){} // RVA: 0xA94080
        public void LookupProperty(){} // RVA: 0x7309AD0
        public void GetPropertyName(){} // RVA: 0x7309D50
        public void CreateExtensionDataProperty(){} // RVA: 0x7309EA0
        public void ReadFromSpan(){} // RVA: 0xA94080
        public void ReadFromSpanAsObject(){} // RVA: 0x730B0E0
        public void DeserializeAsync(){} // RVA: 0x730A7B0
        public void DeserializeAsyncEnumerable(){} // RVA: 0x88E140
        public void DeserializeAsyncEnumerableCore(){} // RVA: 0x88E140
        public void Read(){} // RVA: 0xA94080
        public void ReadAsObject(){} // RVA: 0x730B690
        public void GetReaderScopedToNextValue(){} // RVA: 0x730B9A0
        public void SerializeToUtf8Bytes(){} // RVA: 0x730C400
        public void WriteBytes(){} // RVA: 0x87C630
        public void WriteBytesAsObject(){} // RVA: 0x730C570
        public void WriteMetadataForObject(){} // RVA: 0x730C730
        public void WriteMetadataForCollection(){} // RVA: 0x730CAC0
        public void TryGetReferenceForValue(){} // RVA: 0x730CB80
        public void SerializeAsync(){} // RVA: 0x730D1D0
        public void WriteString(){} // RVA: 0x87C630
        public void WriteStringAsObject(){} // RVA: 0x730D840
        public void .cctor(){} // RVA: 0x730DD90
        public void <UnboxOnRead>g__ThrowUnableToCastValue|50_0(){} // RVA: 0x894350
        public void <TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(){} // RVA: 0x730E370
        public void <DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerable|90_0(){} // RVA: 0x88E140
        public void <DeserializeAsyncEnumerableCore>g__CreateQueueTypeInfo|90_1(){} // RVA: 0x87C5C0
    }

    public class JsonSerializer : Object
    {
        public object s_idPropertyName;
        public object s_refPropertyName;
        public object s_valuesPropertyName;
        public object s_metadataId;
        public object s_metadataRef;
        public object s_metadataValues;

        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x6D93620
        public void ResolveMetadataForJsonObject(){} // RVA: 0x880B90
        public void ResolveMetadataForJsonArray(){} // RVA: 0x880B90
        public void TryReadAheadMetadataAndSetState(){} // RVA: 0x6D93780
        public void GetMetadataPropertyName(){} // RVA: 0x6D93790
        public void TryGetReferenceFromJsonElement(){} // RVA: 0x6D93950
        public void ValidateValueIsCorrectType(){} // RVA: 0x8945C0
        public void LookupProperty(){} // RVA: 0x6D93D70
        public void GetPropertyName(){} // RVA: 0x6D94000
        public void CreateDataExtensionProperty(){} // RVA: 0x6D94230
        public void SerializeToUtf8Bytes(){} // RVA: 0xA94080
        public void WriteBytesUsingSerializer(){} // RVA: 0x87C630
        public void WriteReferenceForObject(){} // RVA: 0x6D943D0
        public void WriteReferenceForCollection(){} // RVA: 0x6D94610
        public void TryWriteReferenceForBoxedStruct(){} // RVA: 0x6D948E0
        public void WriteUsingGeneratedSerializer(){} // RVA: 0x899D10
        public void WriteUsingSerializer(){} // RVA: 0x899D10
        public void GetRuntimeType(){} // RVA: 0x87C5C0
        public void Serialize(){} // RVA: 0xA94080
        public void WriteStringUsingSerializer(){} // RVA: 0x87C630
        public void .cctor(){} // RVA: 0x6D94A80
    }

    public class JsonSerializerOptions : Object
    {
        public object s_defaultSimpleConverters;
        public object s_defaultFactoryConverters;
        public object _converters;
        public object _converters2;
        public object s_defaultOptions;
        public object _classes;
        public object __lastClass;
        public object _context;
        public object _typeInfoCreationFunc;
        public object _memberAccessorStrategy;
        public object _dictionaryKeyPolicy;
        public object _jsonPropertyNamingPolicy;
        public object _readCommentHandling;
        public object _referenceHandler;
        public object _encoder;
        public object _defaultIgnoreCondition;
        public object _numberHandling;
        public object _unknownTypeHandling;
        public object _defaultBufferSize;
        public object _maxDepth;
        public object _allowTrailingCommas;
        public object _haveTypesBeenCreated;
        public object _ignoreNullValues;
        public object _ignoreReadOnlyProperties;
        public object _ignoreReadonlyFields;
        public object _includeFields;
        public object _propertyNameCaseInsensitive;
        public object _writeIndented;
        public object _effectiveMaxDepth;
        public object ReferenceHandlingStrategy;
        public object _isInitializedForReflectionSerializer;

        // ── Methods ──
        public void RootBuiltInConverters(){} // RVA: 0x6D94E80
        public void GetDefaultSimpleConverters(){} // RVA: 0x6D95320
        public void get_Converters(){} // RVA: 0xB465B0
        public void DetermineConverter(){} // RVA: 0x6D96EB0
        public void GetConverterInternal(){} // RVA: 0x6D971B0
        public void GetConverterFromAttribute(){} // RVA: 0x6D978F0
        public void TryGetDefaultSimpleConverter(){} // RVA: 0x6D97C30
        public void GetAttributeThatCanHaveMultiple(){} // RVA: 0x6D97EB0
        public void get__lastClass(){} // RVA: 0xB70160
        public void set__lastClass(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0x6D982D0
        public void TrackOptionsInstance(){} // RVA: 0x6D98920
        public void get_DefaultBufferSize(){} // RVA: 0x23A4270
        public void get_Encoder(){} // RVA: 0xBBFF90
        public void get_DictionaryKeyPolicy(){} // RVA: 0xBBF8F0
        public void get_IgnoreNullValues(){} // RVA: 0x1D5BDB0
        public void get_DefaultIgnoreCondition(){} // RVA: 0x19C6270
        public void set_DefaultIgnoreCondition(){} // RVA: 0x6D989E0
        public void get_NumberHandling(){} // RVA: 0x21EA4F0
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x1DE61D0
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x6D98AF0
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x1C556E0
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x6D98B20
        public void get_IncludeFields(){} // RVA: 0x1C4D0B0
        public void set_IncludeFields(){} // RVA: 0x6D98B50
        public void get_EffectiveMaxDepth(){} // RVA: 0x40A8A30
        public void set_EffectiveMaxDepth(){} // RVA: 0x46CB6C0
        public void get_PropertyNamingPolicy(){} // RVA: 0xBE58B0
        public void set_PropertyNamingPolicy(){} // RVA: 0x6D98B80
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x6D98C00
        public void get_UnknownTypeHandling(){} // RVA: 0x23ADD10
        public void get_WriteIndented(){} // RVA: 0x6D98C10
        public void set_WriteIndented(){} // RVA: 0x6D98C20
        public void get_ReferenceHandler(){} // RVA: 0xBE2C60
        public void set_ReferenceHandler(){} // RVA: 0x6D98C50
        public void get_MemberAccessorStrategy(){} // RVA: 0x6D98CE0
        public void get_IsInitializedForReflectionSerializer(){} // RVA: 0x6D98D80
        public void set_IsInitializedForReflectionSerializer(){} // RVA: 0x6D98D90
        public void InitializeForReflectionSerializer(){} // RVA: 0x6D98DA0
        public void GetOrAddClass(){} // RVA: 0x6D98E70
        public void GetClassFromContextOrCreate(){} // RVA: 0x6D98F70
        public void GetOrAddClassForRootType(){} // RVA: 0x6D98FE0
        public void TryGetClass(){} // RVA: 0x6D990A0
        public void TypeIsCached(){} // RVA: 0x6D99270
        public void GetNodeOptions(){} // RVA: 0x6D98C00
        public void GetWriterOptions(){} // RVA: 0x6D992D0
        public void VerifyMutable(){} // RVA: 0x6D99360
        public void .cctor(){} // RVA: 0x6D99390
        public void <GetDefaultSimpleConverters>g__Add|4_0(){} // RVA: 0x6D99440
        public void <InitializeForReflectionSerializer>g__CreateJsonTypeInfo|112_0(){} // RVA: 0x6D994E0
    }

    public class JsonSerializerOptions : Object
    {
        public object _cachingContext;
        public object _lastTypeInfo;
        public object _objectTypeInfo;
        public object BufferSizeDefault;
        public object DefaultMaxDepth;
        public object s_defaultOptions;
        public object _typeInfoResolver;
        public object _dictionaryKeyPolicy;
        public object _jsonPropertyNamingPolicy;
        public object _readCommentHandling;
        public object _referenceHandler;
        public object _encoder;
        public object _converters;
        public object _defaultIgnoreCondition;
        public object _numberHandling;
        public object _preferredObjectCreationHandling;
        public object _unknownTypeHandling;
        public object _unmappedMemberHandling;
        public object _defaultBufferSize;
        public object _maxDepth;
        public object _allowTrailingCommas;
        public object _ignoreNullValues;
        public object _ignoreReadOnlyProperties;
        public object _ignoreReadonlyFields;
        public object _includeFields;
        public object _propertyNameCaseInsensitive;
        public object _writeIndented;
        public object _typeInfoResolverChain;
        public object _effectiveMaxDepth;
        public object _canUseFastPathSerializationLogic;
        public object ReferenceHandlingStrategy;
        public object _isReadOnly;
        public object _isConfiguredForJsonSerializer;
        public object _effectiveJsonTypeInfoResolver;

        // ── Methods ──
        public void get_CacheContext(){} // RVA: 0x730EE60
        public void GetTypeInfo(){} // RVA: 0x730EF10
        public void TryGetTypeInfo(){} // RVA: 0x730EFF0
        public void GetTypeInfoInternal(){} // RVA: 0x730F120
        public void TryGetTypeInfoCached(){} // RVA: 0x730F310
        public void GetTypeInfoForRootType(){} // RVA: 0x730F510
        public void TryGetPolymorphicTypeInfoForRootType(){} // RVA: 0x730F620
        public void get_ObjectTypeInfo(){} // RVA: 0x730F820
        public void ClearCaches(){} // RVA: 0x730F920
        public void get_Converters(){} // RVA: 0x730FA30
        public void GetConverter(){} // RVA: 0x730FAE0
        public void GetConverterInternal(){} // RVA: 0x730FB90
        public void GetConverterFromList(){} // RVA: 0x730FC10
        public void ExpandConverterFactory(){} // RVA: 0x730FD40
        public void CheckConverterNullabilityIsSameAsPropertyType(){} // RVA: 0x730FDE0
        public void get_Default(){} // RVA: 0x730FEB0
        public void .ctor(){} // RVA: 0x7310270
        public void TrackOptionsInstance(){} // RVA: 0x73103E0
        public void AddContext(){} // RVA: 0x894290
        public void get_TypeInfoResolver(){} // RVA: 0xB70160
        public void set_TypeInfoResolver(){} // RVA: 0x73104A0
        public void get_TypeInfoResolverChain(){} // RVA: 0x7310600
        public void get_AllowTrailingCommas(){} // RVA: 0x1163160
        public void set_AllowTrailingCommas(){} // RVA: 0x7310730
        public void get_DefaultBufferSize(){} // RVA: 0x21EA4F0
        public void set_DefaultBufferSize(){} // RVA: 0x73107A0
        public void get_Encoder(){} // RVA: 0xBE58B0
        public void set_Encoder(){} // RVA: 0x7310870
        public void get_DictionaryKeyPolicy(){} // RVA: 0xD33E60
        public void set_DictionaryKeyPolicy(){} // RVA: 0x7310930
        public void get_IgnoreNullValues(){} // RVA: 0x115E290
        public void set_IgnoreNullValues(){} // RVA: 0x73109F0
        public void get_DefaultIgnoreCondition(){} // RVA: 0xD347A0
        public void set_DefaultIgnoreCondition(){} // RVA: 0x7310AD0
        public void get_NumberHandling(){} // RVA: 0xD34720
        public void set_NumberHandling(){} // RVA: 0x7310C10
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x2536460
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x7310D00
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x115E2A0
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x7310DF0
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x1165070
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x7310E60
        public void get_IncludeFields(){} // RVA: 0xE3F400
        public void set_IncludeFields(){} // RVA: 0x7310ED0
        public void get_MaxDepth(){} // RVA: 0x23ADD10
        public void set_MaxDepth(){} // RVA: 0x7310F40
        public void get_EffectiveMaxDepth(){} // RVA: 0xF3A950
        public void set_EffectiveMaxDepth(){} // RVA: 0x17AFA20
        public void get_PropertyNamingPolicy(){} // RVA: 0xD05CA0
        public void set_PropertyNamingPolicy(){} // RVA: 0x7310FF0
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0xE3A050
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x73110B0
        public void get_ReadCommentHandling(){} // RVA: 0xC02470
        public void set_ReadCommentHandling(){} // RVA: 0x7311120
        public void get_UnknownTypeHandling(){} // RVA: 0x25406F0
        public void set_UnknownTypeHandling(){} // RVA: 0x7311200
        public void get_UnmappedMemberHandling(){} // RVA: 0x19C6270
        public void set_UnmappedMemberHandling(){} // RVA: 0x7311270
        public void get_WriteIndented(){} // RVA: 0x1A177C0
        public void set_WriteIndented(){} // RVA: 0x73112E0
        public void get_ReferenceHandler(){} // RVA: 0xBBF8F0
        public void set_ReferenceHandler(){} // RVA: 0x7311350
        public void get_CanUseFastPathSerializationLogic(){} // RVA: 0x7311430
        public void get_IsReadOnly(){} // RVA: 0x73114F0
        public void MakeReadOnly(){} // RVA: 0x7311530
        public void ConfigureForJsonSerializer(){} // RVA: 0x7311580
        public void GetTypeInfoNoCaching(){} // RVA: 0x73119C0
        public void GetDocumentOptions(){} // RVA: 0x7311C00
        public void GetNodeOptions(){} // RVA: 0xE3A050
        public void GetReaderOptions(){} // RVA: 0x7311CE0
        public void GetWriterOptions(){} // RVA: 0x7311D90
        public void VerifyMutable(){} // RVA: 0x7311E60
        public void GetOrCreateDefaultOptionsInstance(){} // RVA: 0x7311EC0
        public void get_DebuggerDisplay(){} // RVA: 0x7312090
    }

    public class JsonSnakeCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72B36B0
    }

    public class JsonSnakeCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72B3700
    }

    public class JsonWriterHelper : Object
    {
        public object s_utf8Encoding;
        public object s_dateTimeStandardFormat;
        public object LastAsciiCharacter;
        public object s_hexStandardFormat;

        // ── Methods ──
        public void WriteIndentation(){} // RVA: 0x7318D10
        public void ValidateProperty(){} // RVA: 0x7318F00
        public void ValidateValue(){} // RVA: 0x7318F50
        public void ValidateDouble(){} // RVA: 0x7318E90
        public void ValidateSingle(){} // RVA: 0x7318ED0
        public void ValidatePropertyAndValue(){} // RVA: 0x7319140
        public void ValidatePropertyNameLength(){} // RVA: 0x7319210
        public void ValidateNumber(){} // RVA: 0x7319260
        public void IsValidUtf8String(){} // RVA: 0x73196C0
        public void ToUtf8(){} // RVA: 0x73197D0
        public void WriteDateTimeTrimmed(){} // RVA: 0x73199A0
        public void WriteDateTimeOffsetTrimmed(){} // RVA: 0x7319DB0
        public void TrimDateTimeOffset(){} // RVA: 0x731A000
        public void get_AllowList(){} // RVA: 0x731A1E0
        public void NeedsEscaping(){} // RVA: 0x731A3D0
        public void NeedsEscapingNoBoundsCheck(){} // RVA: 0x731A2E0
        public void GetMaxEscapedLength(){} // RVA: 0x6D9DC60
        public void EscapeString(){} // RVA: 0x731AE90
        public void EscapeNextBytes(){} // RVA: 0x731AAA0
        public void IsAsciiValue(){} // RVA: 0x67F0A40
        public void EscapeNextChars(){} // RVA: 0x731B370
        public void WriteHex(){} // RVA: 0x731B650
        public void .cctor(){} // RVA: 0x731B710
    }

    public class JsonWriterHelper : Object
    {
        public object s_dateTimeStandardFormat;
        public object s_hexStandardFormat;

        // ── Methods ──
        public void WriteIndentation(){} // RVA: 0x6D9C200
        public void ValidateProperty(){} // RVA: 0x6D9C550
        public void ValidateValue(){} // RVA: 0x6D9C5A0
        public void ValidateBytes(){} // RVA: 0x6D9C3F0
        public void ValidateDouble(){} // RVA: 0x6D9C440
        public void ValidateSingle(){} // RVA: 0x6D9C4D0
        public void ValidatePropertyAndValue(){} // RVA: 0x6D9C5F0
        public void ValidateNumber(){} // RVA: 0x6D9C680
        public void WriteDateTimeTrimmed(){} // RVA: 0x6D9CC00
        public void WriteDateTimeOffsetTrimmed(){} // RVA: 0x6D9D1B0
        public void TrimDateTimeOffset(){} // RVA: 0x6D9D530
        public void get_AllowList(){} // RVA: 0x6D9D8E0
        public void NeedsEscaping(){} // RVA: 0x6D9DB90
        public void NeedsEscapingNoBoundsCheck(){} // RVA: 0x6D9DA40
        public void GetMaxEscapedLength(){} // RVA: 0x6D9DC60
        public void EscapeString(){} // RVA: 0x6D9E7D0
        public void EscapeNextBytes(){} // RVA: 0x6D9E270
        public void IsAsciiValue(){} // RVA: 0x67F0A40
        public void EscapeNextChars(){} // RVA: 0x6D9ED10
        public void WriteHex(){} // RVA: 0x6D9F070
        public void ToUtf8(){} // RVA: 0x6D9F1D0
        public void PtrDiff(){} // RVA: 0x66C97F0
        public void .cctor(){} // RVA: 0x6D9F6D0
    }

    public class JsonWriterOptions : ValueType
    {
        public object _optionsMask;
        public object _encoder;

        // ── Methods ──
        public void get_Encoder(){} // RVA: 0x77ED0
        public void set_Encoder(){} // RVA: 0x77E70
        public void get_Indented(){} // RVA: 0x8CDA00
        public void set_Indented(){} // RVA: 0x8F1B30
        public void get_SkipValidation(){} // RVA: 0x8CDA10
        public void set_SkipValidation(){} // RVA: 0x8F1B50
        public void get_IndentedOrNotSkipValidation(){} // RVA: 0x8F1B70
    }

    public class JsonWriterOptions : ValueType
    {
        public object DefaultMaxDepth;
        public object _maxDepth;
        public object _optionsMask;
        public object _encoder;
        public object IndentBit;
        public object SkipValidationBit;

        // ── Methods ──
        public void get_Encoder(){} // RVA: 0x77ED0
        public void set_Encoder(){} // RVA: 0x77E70
        public void get_Indented(){} // RVA: 0x912020
        public void set_Indented(){} // RVA: 0x912030
        public void get_MaxDepth(){} // RVA: 0x77E60
        public void set_MaxDepth(){} // RVA: 0x912050
        public void get_SkipValidation(){} // RVA: 0x9120B0
        public void set_SkipValidation(){} // RVA: 0x9120C0
        public void get_IndentedOrNotSkipValidation(){} // RVA: 0x9120E0
    }

    public class PooledByteBufferWriter : Object
    {
        public object _rentedBuffer;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D63620
        public void get_WrittenMemory(){} // RVA: 0x6D636E0
        public void ClearHelper(){} // RVA: 0x6D637C0
        public void Dispose(){} // RVA: 0x6D638D0
        public void Advance(){} // RVA: 0x6D63A90
        public void GetMemory(){} // RVA: 0x6D63AA0
        public void CheckAndResizeBuffer(){} // RVA: 0x6D63BC0
    }

    public class PooledByteBufferWriter : Object
    {
        public object _rentedBuffer;
        public object _index;
        public object MinimumBufferSize;
        public object MaximumBufferSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72A6930
        public void get_WrittenMemory(){} // RVA: 0x72A6A20
        public void get_WrittenCount(){} // RVA: 0xE62D00
        public void get_Capacity(){} // RVA: 0x17F0080
        public void get_FreeCapacity(){} // RVA: 0x2302720
        public void Clear(){} // RVA: 0x72A6AE0
        public void ClearAndReturnBuffers(){} // RVA: 0x72A6AF0
        public void ClearHelper(){} // RVA: 0x72A6BF0
        public void Dispose(){} // RVA: 0x72A6CB0
        public void InitializeEmptyInstance(){} // RVA: 0x72A6DB0
        public void CreateEmptyInstanceForCaching(){} // RVA: 0x72A6EA0
        public void Advance(){} // RVA: 0x6D63A90
        public void GetMemory(){} // RVA: 0x72A6EE0
        public void GetSpan(){} // RVA: 0x72A6FE0
        public void WriteToStreamAsync(){} // RVA: 0x72A70A0
        public void WriteToStream(){} // RVA: 0x72A70F0
        public void CheckAndResizeBuffer(){} // RVA: 0x72A7130
    }

    public class ReadStack : ValueType
    {
        public object SpecialCharacters;
        public object Current;
        public object _stack;
        public object _count;
        public object _continuationCount;
        public object _ctorArgStateCache;
        public object BytesConsumed;
        public object ReadAhead;
        public object ReferenceResolver;
        public object SupportContinuation;
        public object UseFastPath;

        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x8F1530
        public void EnsurePushCapacity(){} // RVA: 0x8F1540
        public void Initialize(){} // RVA: 0x8F15F0
        public void Push(){} // RVA: 0x8F1600
        public void Pop(){} // RVA: 0x8F1610
        public void JsonPath(){} // RVA: 0x8F1620
        public void SetConstructorArgumentState(){} // RVA: 0x8F1630
        public void .cctor(){} // RVA: 0x6D9A600
        public void <JsonPath>g__AppendStackFrame|18_0(){} // RVA: 0x6D9A6E0
        public void <JsonPath>g__GetCount|18_1(){} // RVA: 0x6D9AB50
        public void <JsonPath>g__AppendPropertyName|18_2(){} // RVA: 0x6D9ACA0
        public void <JsonPath>g__GetPropertyName|18_3(){} // RVA: 0x6D9ADB0
    }

    public class ReadStack : ValueType
    {
        public object Current;
        public object _stack;
        public object _count;
        public object _continuationCount;
        public object BytesConsumed;
        public object ReadAhead;
        public object ReferenceResolver;
        public object SupportContinuation;
        public object ReferenceId;
        public object PolymorphicTypeDiscriminator;
        public object PreserveReferences;

        // ── Methods ──
        public void get_Parent(){} // RVA: 0x9113C0
        public void get_ParentProperty(){} // RVA: 0x911400
        public void get_IsContinuation(){} // RVA: 0x8F1530
        public void EnsurePushCapacity(){} // RVA: 0x911450
        public void Initialize(){} // RVA: 0x911460
        public void Push(){} // RVA: 0x911470
        public void Pop(){} // RVA: 0x911480
        public void InitializePolymorphicReEntry(){} // RVA: 0x911490
        public void ResumePolymorphicReEntry(){} // RVA: 0x9114A0
        public void ExitPolymorphicConverter(){} // RVA: 0x9114B0
        public void JsonPath(){} // RVA: 0x9114C0
        public void GetTopJsonTypeInfoWithParameterizedConstructor(){} // RVA: 0x9114D0
        public void SetConstructorArgumentState(){} // RVA: 0x9114E0
        public void get_DebuggerDisplay(){} // RVA: 0x9114F0
        public void <JsonPath>g__AppendStackFrame|24_0(){} // RVA: 0x73151C0
        public void <JsonPath>g__GetCount|24_1(){} // RVA: 0x73155D0
        public void <JsonPath>g__AppendPropertyName|24_2(){} // RVA: 0x7315720
        public void <JsonPath>g__GetPropertyName|24_3(){} // RVA: 0x7315850
    }

    public class ReadStackFrame : ValueType
    {
        public object JsonPropertyInfo;
        public object PropertyState;
        public object UseExtensionProperty;
        public object JsonPropertyName;
        public object JsonPropertyNameAsString;
        public object DictionaryKey;
        public object OriginalDepth;
        public object OriginalTokenType;
        public object ReturnValue;
        public object JsonTypeInfo;
        public object ObjectState;
        public object LargeJsonObjectExtensionDataSerializationState;
        public object ValidateEndTokenOnArray;
        public object PropertyIndex;
        public object PropertyRefCache;
        public object CtorArgumentStateIndex;
        public object CtorArgumentState;
        public object NumberHandling;

        // ── Methods ──
        public void EndConstructorParameter(){} // RVA: 0x8F1700
        public void EndProperty(){} // RVA: 0x8F1710
        public void EndElement(){} // RVA: 0x8F1720
        public void IsProcessingDictionary(){} // RVA: 0x8F1780
        public void IsProcessingEnumerable(){} // RVA: 0x8F17B0
    }

    public class ReadStackFrame : ValueType
    {
        public object JsonPropertyInfo;
        public object PropertyState;
        public object UseExtensionProperty;
        public object JsonPropertyName;
        public object JsonPropertyNameAsString;
        public object DictionaryKey;
        public object ReturnValue;
        public object JsonTypeInfo;
        public object ObjectState;
        public object CanContainMetadata;
        public object LatestMetadataPropertyName;
        public object MetadataPropertyNames;
        public object PolymorphicSerializationState;
        public object PolymorphicJsonTypeInfo;
        public object PropertyIndex;
        public object PropertyRefCache;
        public object CtorArgumentState;
        public object NumberHandling;
        public object RequiredPropertiesSet;
        public object HasParentObject;
        public object IsPopulating;

        // ── Methods ──
        public void get_BaseJsonTypeInfo(){} // RVA: 0x911660
        public void EndConstructorParameter(){} // RVA: 0x911670
        public void EndProperty(){} // RVA: 0x911680
        public void EndElement(){} // RVA: 0x8F1720
        public void IsProcessingDictionary(){} // RVA: 0x911690
        public void IsProcessingEnumerable(){} // RVA: 0x9116C0
        public void MarkRequiredPropertyAsRead(){} // RVA: 0x9116F0
        public void InitializeRequiredPropertiesValidationState(){} // RVA: 0x911730
        public void ValidateAllRequiredPropertiesAreRead(){} // RVA: 0x911740
        public void get_DebuggerDisplay(){} // RVA: 0x9117C0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(){} // RVA: 0x6D63F00
        public void GetArgumentOutOfRangeException_MaxDepthMustBePositive(){} // RVA: 0x6D63F90
        public void GetArgumentOutOfRangeException(){} // RVA: 0x6D64040
        public void GetArgumentOutOfRangeException_CommentEnumMustBeInRange(){} // RVA: 0x6D640B0
        public void GetArgumentException(){} // RVA: 0x6D64160
        public void ThrowArgumentException(){} // RVA: 0x6D64390
        public void ThrowArgumentException_PropertyNameTooLarge(){} // RVA: 0x6D641F0
        public void ThrowArgumentException_ValueTooLarge(){} // RVA: 0x6D64270
        public void ThrowArgumentException_ValueNotSupported(){} // RVA: 0x6D642F0
        public void ThrowInvalidOperationException_NeedLargerSpan(){} // RVA: 0x6D64340
        public void ThrowInvalidOperationException(){} // RVA: 0x6D66270
        public void GetInvalidOperationException(){} // RVA: 0x6D668F0
        public void ThrowInvalidOperationOrArgumentException(){} // RVA: 0x6D645D0
        public void GetInvalidOperationException_ExpectedArray(){} // RVA: 0x6D646C0
        public void GetInvalidOperationException_ExpectedObject(){} // RVA: 0x6D64710
        public void GetInvalidOperationException_ExpectedNumber(){} // RVA: 0x6D64760
        public void GetInvalidOperationException_ExpectedBoolean(){} // RVA: 0x6D647B0
        public void GetInvalidOperationException_ExpectedString(){} // RVA: 0x6D64800
        public void GetInvalidOperationException_CannotSkipOnPartial(){} // RVA: 0x6D64850
        public void GetJsonElementWrongTypeException(){} // RVA: 0x6D64CD0
        public void ThrowJsonReaderException(){} // RVA: 0x6D64DD0
        public void GetJsonReaderException(){} // RVA: 0x6D64E20
        public void IsPrintable(){} // RVA: 0x6D651C0
        public void GetPrintableString(){} // RVA: 0x6D651D0
        public void GetResourceString(){} // RVA: 0x6D66A30
        public void ThrowArgumentException_InvalidUTF8(){} // RVA: 0x6D662A0
        public void ThrowArgumentException_InvalidUTF16(){} // RVA: 0x6D66480
        public void ThrowInvalidOperationException_ReadInvalidUTF16(){} // RVA: 0x6D665C0
        public void GetInvalidOperationException_ReadInvalidUTF8(){} // RVA: 0x6D66610
        public void GetArgumentException_ReadInvalidUTF16(){} // RVA: 0x6D66750
        public void ThrowOutOfMemoryException(){} // RVA: 0x6D669A0
        public void GetFormatException(){} // RVA: 0x6D67540
        public void GetInvalidOperationException_ExpectedChar(){} // RVA: 0x6D678B0
        public void ThrowArgumentException_NodeValueNotAllowed(){} // RVA: 0x6D67900
        public void ThrowArgumentException_NodeArrayTooSmall(){} // RVA: 0x6D67970
        public void ThrowArgumentOutOfRangeException_NodeArrayIndexNegative(){} // RVA: 0x6D679E0
        public void ThrowArgumentException_DuplicateKey(){} // RVA: 0x6D67A50
        public void ThrowInvalidOperationException_NodeAlreadyHasParent(){} // RVA: 0x6D67AC0
        public void ThrowInvalidOperationException_NodeCycleDetected(){} // RVA: 0x6D67B30
        public void ThrowNotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x6D67BA0
        public void NotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x6D67BD0
        public void ThrowNotSupportedException_SerializationNotSupported(){} // RVA: 0x6D67CB0
        public void ThrowNotSupportedException_TypeRequiresAsyncSerialization(){} // RVA: 0x6D67D30
        public void ThrowNotSupportedException_ConstructorMaxOf64Parameters(){} // RVA: 0x6D67DB0
        public void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(){} // RVA: 0x6D67E30
        public void ThrowJsonException_DeserializeUnableToConvertValue(){} // RVA: 0x6D67ED0
        public void ThrowInvalidCastException_DeserializeUnableToAssignValue(){} // RVA: 0x6D67F60
        public void ThrowInvalidOperationException_DeserializeUnableToAssignNull(){} // RVA: 0x6D67FE0
        public void ThrowJsonException_SerializationConverterRead(){} // RVA: 0x6D68060
        public void ThrowJsonException_SerializationConverterWrite(){} // RVA: 0x6D680F0
        public void ThrowJsonException_SerializerCycleDetected(){} // RVA: 0x6D68180
        public void ThrowJsonException(){} // RVA: 0x6D68220
        public void ThrowInvalidOperationException_CannotSerializeInvalidType(){} // RVA: 0x6D68280
        public void ThrowInvalidOperationException_SerializationConverterNotCompatible(){} // RVA: 0x6D683A0
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(){} // RVA: 0x6D68420
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x6D68500
        public void ThrowInvalidOperationException_SerializerOptionsImmutable(){} // RVA: 0x6D685F0
        public void ThrowInvalidOperationException_SerializerPropertyNameConflict(){} // RVA: 0x6D68670
        public void ThrowInvalidOperationException_SerializerPropertyNameNull(){} // RVA: 0x6D68710
        public void ThrowInvalidOperationException_NamingPolicyReturnNull(){} // RVA: 0x6D687E0
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(){} // RVA: 0x6D68860
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(){} // RVA: 0x6D688E0
        public void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(){} // RVA: 0x6D68960
        public void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(){} // RVA: 0x6D68AA0
        public void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x6D68B20
        public void ThrowInvalidOperationException_JsonIncludeOnNonPublicInvalid(){} // RVA: 0x6D68BD0
        public void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x6D68C50
        public void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(){} // RVA: 0x6D68CD0
        public void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(){} // RVA: 0x6D68D90
        public void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotHonored(){} // RVA: 0x6D68E50
        public void ReThrowWithPath(){} // RVA: 0x6D68F30
        public void AddJsonExceptionInformation(){} // RVA: 0x6D68FA0
        public void ThrowInvalidOperationException_SerializationDuplicateAttribute(){} // RVA: 0x6D691E0
        public void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(){} // RVA: 0x894350
        public void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x6D69350
        public void ThrowNotSupportedException(){} // RVA: 0x6D697A0
        public void ThrowNotSupportedException_DeserializeNoConstructor(){} // RVA: 0x6D69950
        public void ThrowNotSupportedException_CannotPopulateCollection(){} // RVA: 0x6D69A30
        public void ThrowJsonException_MetadataValuesInvalidToken(){} // RVA: 0x6D69AD0
        public void ThrowJsonException_MetadataReferenceNotFound(){} // RVA: 0x6D69B50
        public void ThrowJsonException_MetadataValueWasNotString(){} // RVA: 0x6D69C30
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x6D69D00
        public void ThrowJsonException_MetadataIdIsNotFirstProperty(){} // RVA: 0x6D69D40
        public void ThrowJsonException_MetadataMissingIdBeforeValues(){} // RVA: 0x6D69DC0
        public void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x6D69E40
        public void ThrowJsonException_MetadataDuplicateIdFound(){} // RVA: 0x6D69F70
        public void ThrowJsonException_MetadataInvalidReferenceToValueType(){} // RVA: 0x6D69FD0
        public void ThrowJsonException_MetadataPreservedArrayInvalidProperty(){} // RVA: 0x6D6A030
        public void ThrowJsonException_MetadataPreservedArrayValuesNotFound(){} // RVA: 0x6D6A1F0
        public void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(){} // RVA: 0x6D6A290
        public void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x6D6A2F0
        public void ThrowUnexpectedMetadataException(){} // RVA: 0x6D6A380
        public void ThrowInvalidOperationException_JsonSerializerOptionsAlreadyBoundToContext(){} // RVA: 0x6D6A4C0
        public void ThrowNotSupportedException_BuiltInConvertersNotRooted(){} // RVA: 0x6D6A550
        public void ThrowNotSupportedException_NoMetadataForType(){} // RVA: 0x6D6A5D0
        public void ThrowInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x6D6A650
        public void ThrowInvalidOperationException_NoMetadataForTypeCtorParams(){} // RVA: 0x6D6A6F0
        public void ThrowMissingMemberException_MissingFSharpCoreMember(){} // RVA: 0x6D6A790
    }

    public class ThrowHelper : Object
    {
        public object ExceptionSourceValueToRethrowAsJsonException;

        // ── Methods ──
        public void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(){} // RVA: 0x72A7460
        public void ThrowArgumentNullException(){} // RVA: 0x72A74F0
        public void ThrowArgumentOutOfRangeException_MaxDepthMustBePositive(){} // RVA: 0x72A7540
        public void GetArgumentOutOfRangeException(){} // RVA: 0x72A7590
        public void ThrowArgumentOutOfRangeException_CommentEnumMustBeInRange(){} // RVA: 0x72A7600
        public void ThrowArgumentOutOfRangeException_ArrayIndexNegative(){} // RVA: 0x72A7650
        public void ThrowArgumentOutOfRangeException_JsonConverterFactory_TypeNotSupported(){} // RVA: 0x72A76C0
        public void ThrowArgumentException_ArrayTooSmall(){} // RVA: 0x72A7760
        public void GetArgumentException(){} // RVA: 0x72A77D0
        public void ThrowArgumentException(){} // RVA: 0x72A7E70
        public void GetInvalidOperationException_CallFlushFirst(){} // RVA: 0x72A7860
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x72A7940
        public void ThrowArgumentException_PropertyNameTooLarge(){} // RVA: 0x72A7990
        public void ThrowArgumentException_ValueTooLarge(){} // RVA: 0x72A7A10
        public void ThrowArgumentException_ValueNotSupported(){} // RVA: 0x72A7A90
        public void ThrowInvalidOperationException_NeedLargerSpan(){} // RVA: 0x72A7AE0
        public void ThrowPropertyNameTooLargeArgumentException(){} // RVA: 0x72A7B30
        public void ThrowInvalidOperationOrArgumentException(){} // RVA: 0x72A82E0
        public void ThrowInvalidOperationException(){} // RVA: 0x72A9E70
        public void GetInvalidOperationException(){} // RVA: 0x72AA590
        public void ThrowInvalidOperationException_DepthNonZeroOrEmptyJson(){} // RVA: 0x72A81B0
        public void GetInvalidOperationException_ExpectedArray(){} // RVA: 0x72A83D0
        public void GetInvalidOperationException_ExpectedObject(){} // RVA: 0x72A8420
        public void ThrowInvalidOperationException_ExpectedNumber(){} // RVA: 0x72A8470
        public void ThrowInvalidOperationException_ExpectedBoolean(){} // RVA: 0x72A84B0
        public void ThrowInvalidOperationException_ExpectedString(){} // RVA: 0x72A84F0
        public void ThrowInvalidOperationException_ExpectedPropertyName(){} // RVA: 0x72A8530
        public void ThrowInvalidOperationException_ExpectedStringComparison(){} // RVA: 0x72A8570
        public void ThrowInvalidOperationException_ExpectedComment(){} // RVA: 0x72A85A0
        public void ThrowInvalidOperationException_CannotSkipOnPartial(){} // RVA: 0x72A85E0
        public void ThrowJsonElementWrongTypeException(){} // RVA: 0x72A8820
        public void GetJsonElementWrongTypeException(){} // RVA: 0x72A89A0
        public void ThrowJsonReaderException(){} // RVA: 0x72A8AA0
        public void GetJsonReaderException(){} // RVA: 0x72A8AE0
        public void IsPrintable(){} // RVA: 0x6D651C0
        public void GetPrintableString(){} // RVA: 0x72A8E50
        public void GetResourceString(){} // RVA: 0x72AA6D0
        public void ThrowArgumentException_InvalidCommentValue(){} // RVA: 0x72A9EB0
        public void ThrowArgumentException_InvalidUTF8(){} // RVA: 0x72A9F20
        public void ThrowArgumentException_InvalidUTF16(){} // RVA: 0x72AA120
        public void ThrowInvalidOperationException_ReadInvalidUTF16(){} // RVA: 0x72AA1D0
        public void ThrowInvalidOperationException_ReadIncompleteUTF16(){} // RVA: 0x72AA260
        public void GetInvalidOperationException_ReadInvalidUTF8(){} // RVA: 0x72AA2B0
        public void GetArgumentException_ReadInvalidUTF16(){} // RVA: 0x72AA3F0
        public void ThrowOutOfMemoryException(){} // RVA: 0x72AA640
        public void ThrowFormatException(){} // RVA: 0x72AAED0
        public void ThrowInvalidOperationException_ExpectedChar(){} // RVA: 0x72AB000
        public void ThrowObjectDisposedException_Utf8JsonWriter(){} // RVA: 0x72AB040
        public void ThrowObjectDisposedException_JsonDocument(){} // RVA: 0x72AB090
        public void ThrowArgumentException_NodeValueNotAllowed(){} // RVA: 0x72AB0E0
        public void ThrowArgumentException_DuplicateKey(){} // RVA: 0x72AB150
        public void ThrowInvalidOperationException_NodeAlreadyHasParent(){} // RVA: 0x72AB1E0
        public void ThrowInvalidOperationException_NodeCycleDetected(){} // RVA: 0x72AB250
        public void ThrowInvalidOperationException_NodeElementCannotBeObjectOrArray(){} // RVA: 0x72AB2C0
        public void ThrowNotSupportedException_CollectionIsReadOnly(){} // RVA: 0x72AB330
        public void ThrowInvalidOperationException_NodeWrongType(){} // RVA: 0x72AB360
        public void ThrowInvalidOperationException_NodeParentWrongType(){} // RVA: 0x72AB3E0
        public void GetNotSupportedException_CollectionIsReadOnly(){} // RVA: 0x72AB460
        public void ThrowArgumentException_DeserializeWrongType(){} // RVA: 0x72AB540
        public void ThrowArgumentException_SerializerDoesNotSupportComments(){} // RVA: 0x72AB5E0
        public void ThrowNotSupportedException_SerializationNotSupported(){} // RVA: 0x72AB650
        public void ThrowNotSupportedException_TypeRequiresAsyncSerialization(){} // RVA: 0x72AB6D0
        public void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(){} // RVA: 0x72AB750
        public void ThrowJsonException_DeserializeUnableToConvertValue(){} // RVA: 0x72AB7F0
        public void ThrowInvalidCastException_DeserializeUnableToAssignValue(){} // RVA: 0x72AB880
        public void ThrowInvalidOperationException_DeserializeUnableToAssignNull(){} // RVA: 0x72AB900
        public void ThrowInvalidOperationException_ObjectCreationHandlingPopulateNotSupportedByConverter(){} // RVA: 0x72AB980
        public void ThrowInvalidOperationException_ObjectCreationHandlingPropertyMustHaveAGetter(){} // RVA: 0x72ABA30
        public void ThrowInvalidOperationException_ObjectCreationHandlingPropertyValueTypeMustHaveASetter(){} // RVA: 0x72ABAE0
        public void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization(){} // RVA: 0x72ABB90
        public void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReadOnlyMember(){} // RVA: 0x72ABC40
        public void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReferenceHandling(){} // RVA: 0x72ABCF0
        public void ThrowNotSupportedException_ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors(){} // RVA: 0x72ABD60
        public void ThrowJsonException_SerializationConverterRead(){} // RVA: 0x72ABDD0
        public void ThrowJsonException_SerializationConverterWrite(){} // RVA: 0x72ABE60
        public void ThrowJsonException_SerializerCycleDetected(){} // RVA: 0x72ABEF0
        public void ThrowJsonException(){} // RVA: 0x72ABF90
        public void ThrowArgumentException_CannotSerializeInvalidType(){} // RVA: 0x72ABFF0
        public void ThrowInvalidOperationException_CannotSerializeInvalidType(){} // RVA: 0x72AC100
        public void ThrowInvalidOperationException_SerializationConverterNotCompatible(){} // RVA: 0x72AC220
        public void ThrowInvalidOperationException_ResolverTypeNotCompatible(){} // RVA: 0x72AC2A0
        public void ThrowInvalidOperationException_ResolverTypeInfoOptionsNotCompatible(){} // RVA: 0x72AC320
        public void ThrowInvalidOperationException_JsonSerializerOptionsNoTypeInfoResolverSpecified(){} // RVA: 0x72AC390
        public void ThrowInvalidOperationException_JsonSerializerIsReflectionDisabled(){} // RVA: 0x72AC400
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(){} // RVA: 0x72AC470
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x72AC550
        public void ThrowInvalidOperationException_SerializerOptionsReadOnly(){} // RVA: 0x72AC640
        public void ThrowInvalidOperationException_DefaultTypeInfoResolverImmutable(){} // RVA: 0x72AC6C0
        public void ThrowInvalidOperationException_TypeInfoResolverChainImmutable(){} // RVA: 0x72AC730
        public void ThrowInvalidOperationException_TypeInfoImmutable(){} // RVA: 0x72AC7A0
        public void ThrowInvalidOperationException_InvalidChainedResolver(){} // RVA: 0x72AC810
        public void ThrowInvalidOperationException_SerializerPropertyNameConflict(){} // RVA: 0x72AC880
        public void ThrowInvalidOperationException_SerializerPropertyNameNull(){} // RVA: 0x72AC900
        public void ThrowInvalidOperationException_JsonPropertyRequiredAndNotDeserializable(){} // RVA: 0x72AC9B0
        public void ThrowInvalidOperationException_JsonPropertyRequiredAndExtensionData(){} // RVA: 0x72ACA60
        public void ThrowJsonException_JsonRequiredPropertyMissing(){} // RVA: 0x72ACB10
        public void ThrowInvalidOperationException_NamingPolicyReturnNull(){} // RVA: 0x72ACE40
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(){} // RVA: 0x72ACEC0
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(){} // RVA: 0x72ACF40
        public void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(){} // RVA: 0x72ACFC0
        public void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(){} // RVA: 0x72AD100
        public void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x72AD180
        public void ThrowInvalidOperationException_JsonIncludeOnInaccessibleProperty(){} // RVA: 0x72AD220
        public void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x72AD2A0
        public void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(){} // RVA: 0x72AD320
        public void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(){} // RVA: 0x72AD3D0
        public void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(){} // RVA: 0x72AD490
        public void ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(){} // RVA: 0x72AD570
        public void ThrowInvalidOperationException_CreateObjectConverterNotCompatible(){} // RVA: 0x72AD610
        public void ReThrowWithPath(){} // RVA: 0x72ADC60
        public void AddJsonExceptionInformation(){} // RVA: 0x72ADCD0
        public void ThrowInvalidOperationException_SerializationDuplicateAttribute(){} // RVA: 0x72ADF10
        public void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(){} // RVA: 0x894350
        public void ThrowInvalidOperationException_ExtensionDataConflictsWithUnmappedMemberHandling(){} // RVA: 0x72AE0A0
        public void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x72AE140
        public void ThrowInvalidOperationException_NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty(){} // RVA: 0x72AE1F0
        public void ThrowNotSupportedException(){} // RVA: 0x72AE480
        public void ThrowNotSupportedException_DeserializeNoConstructor(){} // RVA: 0x72AE620
        public void ThrowNotSupportedException_CannotPopulateCollection(){} // RVA: 0x72AE700
        public void ThrowJsonException_MetadataValuesInvalidToken(){} // RVA: 0x72AE7A0
        public void ThrowJsonException_MetadataReferenceNotFound(){} // RVA: 0x72AE820
        public void ThrowJsonException_MetadataValueWasNotString(){} // RVA: 0x72AE900
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x72AEAF0
        public void ThrowJsonException_MetadataUnexpectedProperty(){} // RVA: 0x72AE9D0
        public void ThrowJsonException_UnmappedJsonProperty(){} // RVA: 0x72AEA70
        public void ThrowJsonException_MetadataIdIsNotFirstProperty(){} // RVA: 0x72AEB30
        public void ThrowJsonException_MetadataStandaloneValuesProperty(){} // RVA: 0x72AEBB0
        public void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x72AEC30
        public void ThrowJsonException_MetadataDuplicateIdFound(){} // RVA: 0x72AED60
        public void ThrowJsonException_MetadataDuplicateTypeProperty(){} // RVA: 0x72AEDC0
        public void ThrowJsonException_MetadataInvalidReferenceToValueType(){} // RVA: 0x72AEE00
        public void ThrowJsonException_MetadataInvalidPropertyInArrayMetadata(){} // RVA: 0x72AEE60
        public void ThrowJsonException_MetadataPreservedArrayValuesNotFound(){} // RVA: 0x72AF010
        public void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(){} // RVA: 0x72AF0B0
        public void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x72AF110
        public void ThrowInvalidOperationException_JsonPropertyInfoIsBoundToDifferentJsonTypeInfo(){} // RVA: 0x72AF1A0
        public void ThrowUnexpectedMetadataException(){} // RVA: 0x72AF270
        public void ThrowNotSupportedException_NoMetadataForType(){} // RVA: 0x72AF330
        public void GetNotSupportedException_AmbiguousMetadataForType(){} // RVA: 0x72AF400
        public void ThrowNotSupportedException_ConstructorContainsNullParameterNames(){} // RVA: 0x72AF510
        public void ThrowInvalidOperationException_NoMetadataForType(){} // RVA: 0x72AF590
        public void GetInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x72AF660
        public void ThrowInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x72AF7B0
        public void ThrowMissingMemberException_MissingFSharpCoreMember(){} // RVA: 0x72AF7E0
        public void ThrowNotSupportedException_BaseConverterDoesNotSupportMetadata(){} // RVA: 0x72AF860
        public void ThrowNotSupportedException_DerivedConverterDoesNotSupportMetadata(){} // RVA: 0x72AF8E0
        public void ThrowNotSupportedException_RuntimeTypeNotSupported(){} // RVA: 0x72AF960
        public void ThrowNotSupportedException_RuntimeTypeDiamondAmbiguity(){} // RVA: 0x72AF9E0
        public void ThrowInvalidOperationException_TypeDoesNotSupportPolymorphism(){} // RVA: 0x72AFB20
        public void ThrowInvalidOperationException_DerivedTypeNotSupported(){} // RVA: 0x72AFBA0
        public void ThrowInvalidOperationException_DerivedTypeIsAlreadySpecified(){} // RVA: 0x72AFC20
        public void ThrowInvalidOperationException_TypeDicriminatorIdIsAlreadySpecified(){} // RVA: 0x72AFCA0
        public void ThrowInvalidOperationException_InvalidCustomTypeDiscriminatorPropertyName(){} // RVA: 0x72AFD20
        public void ThrowInvalidOperationException_PolymorphicTypeConfigurationDoesNotSpecifyDerivedTypes(){} // RVA: 0x72AFD90
        public void ThrowInvalidOperationException_InvalidEnumTypeWithSpecialChar(){} // RVA: 0x72AFE10
        public void ThrowJsonException_UnrecognizedTypeDiscriminator(){} // RVA: 0x72AFEB0
        public void ThrowArgumentException_JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo(){} // RVA: 0x72AFF10
    }

    public class Utf8JsonReader : ValueType
    {
        public object _buffer;
        public object _isFinalBlock;
        public object _isInputSequence;
        public object _lineNumber;
        public object _bytePositionInLine;
        public object _consumed;
        public object _inObject;
        public object _isNotPrimitive;
        public object _tokenType;
        public object _previousTokenType;
        public object _readerOptions;
        public object _bitStack;
        public object _totalConsumed;
        public object _isLastSegment;
        public object _stringHasEscaping;
        public object _isMultiSegment;
        public object _trailingCommaBeforeComment;
        public object _nextPosition;
        public object _currentPosition;
        public object _sequence;
        public object _valueSpan;
        public object _tokenStartIndex;
        public object _hasValueSequence;
        public object _valueSequence;

        // ── Methods ──
        public void get_IsLastSpan(){} // RVA: 0x8EF140
        public void get_OriginalSequence(){} // RVA: 0x8EF160
        public void get_OriginalSpan(){} // RVA: 0x8EF180
        public void get_ValueSpan(){} // RVA: 0x8EF1B0
        public void set_ValueSpan(){} // RVA: 0x8EF1D0
        public void get_BytesConsumed(){} // RVA: 0x8EF240
        public void get_TokenStartIndex(){} // RVA: 0x8EF250
        public void set_TokenStartIndex(){} // RVA: 0x8EF260
        public void get_CurrentDepth(){} // RVA: 0x8EF270
        public void get_IsInArray(){} // RVA: 0x8EF290
        public void get_TokenType(){} // RVA: 0x8EF2A0
        public void get_HasValueSequence(){} // RVA: 0x8EF2B0
        public void set_HasValueSequence(){} // RVA: 0x8EF2C0
        public void get_IsFinalBlock(){} // RVA: 0x8C6E0
        public void get_ValueSequence(){} // RVA: 0x8EF2D0
        public void set_ValueSequence(){} // RVA: 0x8EF2F0
        public void get_CurrentState(){} // RVA: 0x8EF360
        public void .ctor(){} // RVA: 0x8EF410
        public void Read(){} // RVA: 0x8EF490
        public void Skip(){} // RVA: 0x8EF4A0
        public void SkipHelper(){} // RVA: 0x8EF4F0
        public void TrySkip(){} // RVA: 0x8EF500
        public void TrySkipHelper(){} // RVA: 0x8EF530
        public void StartObject(){} // RVA: 0x8EF540
        public void EndObject(){} // RVA: 0x8EF550
        public void StartArray(){} // RVA: 0x8EF560
        public void EndArray(){} // RVA: 0x8EF570
        public void UpdateBitStackOnEndToken(){} // RVA: 0x8EF580
        public void ReadSingleSegment(){} // RVA: 0x8EF5E0
        public void HasMoreData(){} // RVA: 0x8EF600
        public void ReadFirstToken(){} // RVA: 0x8EF610
        public void SkipWhiteSpace(){} // RVA: 0x8EF620
        public void ConsumeValue(){} // RVA: 0x8EF630
        public void ConsumeLiteral(){} // RVA: 0x8EF640
        public void CheckLiteral(){} // RVA: 0x8EF670
        public void ThrowInvalidLiteral(){} // RVA: 0x8EF6C0
        public void ConsumeNumber(){} // RVA: 0x8EF6F0
        public void ConsumePropertyName(){} // RVA: 0x8EF700
        public void ConsumeString(){} // RVA: 0x8EF710
        public void ConsumeStringAndValidate(){} // RVA: 0x8EF720
        public void ValidateHexDigits(){} // RVA: 0x8EF750
        public void TryGetNumber(){} // RVA: 0x8EF780
        public void ConsumeNegativeSign(){} // RVA: 0x8EF7B0
        public void ConsumeZero(){} // RVA: 0x8EF7C0
        public void ConsumeIntegerDigits(){} // RVA: 0x8EF7D0
        public void ConsumeDecimalDigits(){} // RVA: 0x8EF7E0
        public void ConsumeSign(){} // RVA: 0x8EF7F0
        public void ConsumeNextTokenOrRollback(){} // RVA: 0x8EF800
        public void ConsumeNextToken(){} // RVA: 0x8EF810
        public void ConsumeNextTokenFromLastNonCommentToken(){} // RVA: 0x8EF820
        public void SkipAllComments(){} // RVA: 0x8EF840
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkipped(){} // RVA: 0x8EF850
        public void SkipComment(){} // RVA: 0x8EF860
        public void SkipSingleLineComment(){} // RVA: 0x8EF870
        public void FindLineSeparator(){} // RVA: 0x8EF8A0
        public void ThrowOnDangerousLineSeparator(){} // RVA: 0x8EF8D0
        public void SkipMultiLineComment(){} // RVA: 0x8EF900
        public void ConsumeComment(){} // RVA: 0x8EF930
        public void ConsumeSingleLineComment(){} // RVA: 0x8EF940
        public void ConsumeMultiLineComment(){} // RVA: 0x8EF970
        public void GetUnescapedSpan(){} // RVA: 0x8EF9A0
        public void ReadMultiSegment(){} // RVA: 0x8EF9D0
        public void ValidateStateAtEndOfData(){} // RVA: 0x8EF9E0
        public void HasMoreDataMultiSegment(){} // RVA: 0x8EFA00
        public void GetNextSpan(){} // RVA: 0x8EFA10
        public void ReadFirstTokenMultiSegment(){} // RVA: 0x8EFA20
        public void SkipWhiteSpaceMultiSegment(){} // RVA: 0x8EFA30
        public void ConsumeValueMultiSegment(){} // RVA: 0x8EFA90
        public void ConsumeLiteralMultiSegment(){} // RVA: 0x8EFAA0
        public void CheckLiteralMultiSegment(){} // RVA: 0x8EFAD0
        public void FindMismatch(){} // RVA: 0x8EFB30
        public void GetInvalidLiteralMultiSegment(){} // RVA: 0x8EFB80
        public void ConsumeNumberMultiSegment(){} // RVA: 0x8EFBB0
        public void ConsumePropertyNameMultiSegment(){} // RVA: 0x8EFBC0
        public void ConsumeStringMultiSegment(){} // RVA: 0x8EFBD0
        public void ConsumeStringNextSegment(){} // RVA: 0x8EFBE0
        public void ConsumeStringAndValidateMultiSegment(){} // RVA: 0x8EFBF0
        public void RollBackState(){} // RVA: 0x8EFC20
        public void TryGetNumberMultiSegment(){} // RVA: 0x8EFC30
        public void ConsumeNegativeSignMultiSegment(){} // RVA: 0x8EFC60
        public void ConsumeZeroMultiSegment(){} // RVA: 0x8EFC70
        public void ConsumeIntegerDigitsMultiSegment(){} // RVA: 0x8EFC80
        public void ConsumeDecimalDigitsMultiSegment(){} // RVA: 0x8EFC90
        public void ConsumeSignMultiSegment(){} // RVA: 0x8EFCA0
        public void ConsumeNextTokenOrRollbackMultiSegment(){} // RVA: 0x8EFCB0
        public void ConsumeNextTokenMultiSegment(){} // RVA: 0x8EFCC0
        public void ConsumeNextTokenFromLastNonCommentTokenMultiSegment(){} // RVA: 0x8EFCD0
        public void SkipAllCommentsMultiSegment(){} // RVA: 0x8EFCF0
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(){} // RVA: 0x8EFD00
        public void SkipOrConsumeCommentMultiSegmentWithRollback(){} // RVA: 0x8EFD10
        public void SkipCommentMultiSegment(){} // RVA: 0x8EFD20
        public void SkipSingleLineCommentMultiSegment(){} // RVA: 0x8EFD30
        public void FindLineSeparatorMultiSegment(){} // RVA: 0x8EFD60
        public void ThrowOnDangerousLineSeparatorMultiSegment(){} // RVA: 0x8EFD90
        public void SkipMultiLineCommentMultiSegment(){} // RVA: 0x8EFDC0
        public void CaptureState(){} // RVA: 0x8EFDF0
        public void GetString(){} // RVA: 0x8EFEA0
        public void GetBoolean(){} // RVA: 0x8EFEB0
        public void GetBytesFromBase64(){} // RVA: 0x8EFEC0
        public void GetByte(){} // RVA: 0x8EFF20
        public void GetByteWithQuotes(){} // RVA: 0x8EFF80
        public void GetSByte(){} // RVA: 0x8EFF90
        public void GetSByteWithQuotes(){} // RVA: 0x8EFFF0
        public void GetInt16(){} // RVA: 0x8F0000
        public void GetInt16WithQuotes(){} // RVA: 0x8F0060
        public void GetInt32(){} // RVA: 0x8F0070
        public void GetInt32WithQuotes(){} // RVA: 0x8F00D0
        public void GetInt64(){} // RVA: 0x8F00E0
        public void GetInt64WithQuotes(){} // RVA: 0x8F0140
        public void GetUInt16(){} // RVA: 0x8F0150
        public void GetUInt16WithQuotes(){} // RVA: 0x8F01B0
        public void GetUInt32(){} // RVA: 0x8F01C0
        public void GetUInt32WithQuotes(){} // RVA: 0x8F0220
        public void GetUInt64(){} // RVA: 0x8F0230
        public void GetUInt64WithQuotes(){} // RVA: 0x8F0290
        public void GetSingle(){} // RVA: 0x8F02A0
        public void GetSingleWithQuotes(){} // RVA: 0x8F0300
        public void GetSingleFloatingPointConstant(){} // RVA: 0x8F0310
        public void GetDouble(){} // RVA: 0x8F0320
        public void GetDoubleWithQuotes(){} // RVA: 0x8F0380
        public void GetDoubleFloatingPointConstant(){} // RVA: 0x8F0390
        public void GetDecimal(){} // RVA: 0x8F03A0
        public void GetDecimalWithQuotes(){} // RVA: 0x8F0400
        public void GetDateTime(){} // RVA: 0x8F0520
        public void GetDateTimeNoValidation(){} // RVA: 0x8F0530
        public void GetDateTimeOffset(){} // RVA: 0x8F0590
        public void GetDateTimeOffsetNoValidation(){} // RVA: 0x8F0620
        public void GetGuid(){} // RVA: 0x8F0680
        public void GetGuidNoValidation(){} // RVA: 0x8F0710
        public void TryGetBytesFromBase64(){} // RVA: 0x8F0770
        public void TryGetByte(){} // RVA: 0x8F0780
        public void TryGetByteCore(){} // RVA: 0x8F0790
        public void TryGetSByte(){} // RVA: 0x8F07C0
        public void TryGetSByteCore(){} // RVA: 0x8F07D0
        public void TryGetInt16(){} // RVA: 0x8F0800
        public void TryGetInt16Core(){} // RVA: 0x8F0810
        public void TryGetInt32(){} // RVA: 0x8F0840
        public void TryGetInt32Core(){} // RVA: 0x8F0850
        public void TryGetInt64(){} // RVA: 0x8F0880
        public void TryGetInt64Core(){} // RVA: 0x8F0890
        public void TryGetUInt16(){} // RVA: 0x8F08C0
        public void TryGetUInt16Core(){} // RVA: 0x8F08D0
        public void TryGetUInt32(){} // RVA: 0x8F0900
        public void TryGetUInt32Core(){} // RVA: 0x8F0910
        public void TryGetUInt64(){} // RVA: 0x8F0940
        public void TryGetUInt64Core(){} // RVA: 0x8F0950
        public void TryGetSingle(){} // RVA: 0x8F0980
        public void TryGetDouble(){} // RVA: 0x8F0990
        public void TryGetDecimal(){} // RVA: 0x8F09A0
        public void TryGetDecimalCore(){} // RVA: 0x8F09B0
        public void TryGetDateTime(){} // RVA: 0x8F09E0
        public void TryGetDateTimeCore(){} // RVA: 0x8F0A30
        public void TryGetDateTimeOffset(){} // RVA: 0x8F0A40
        public void TryGetDateTimeOffsetCore(){} // RVA: 0x8F0A90
        public void TryGetGuid(){} // RVA: 0x8F0AA0
        public void TryGetGuidCore(){} // RVA: 0x8F0AF0
    }

    public class Utf8JsonReader : ValueType
    {
        public object _buffer;
        public object _isFinalBlock;
        public object _isInputSequence;
        public object _lineNumber;
        public object _bytePositionInLine;
        public object _consumed;
        public object _inObject;
        public object _isNotPrimitive;
        public object _tokenType;
        public object _previousTokenType;
        public object _readerOptions;
        public object _bitStack;
        public object _totalConsumed;
        public object _isLastSegment;
        public object _isMultiSegment;
        public object _trailingCommaBeforeComment;
        public object _nextPosition;
        public object _currentPosition;
        public object _sequence;
        public object _valueSpan;
        public object _tokenStartIndex;
        public object _hasValueSequence;
        public object _valueIsEscaped;
        public object _valueSequence;

        // ── Methods ──
        public void get_IsLastSpan(){} // RVA: 0x90ED10
        public void get_OriginalSequence(){} // RVA: 0x90ED30
        public void get_OriginalSpan(){} // RVA: 0x90ED50
        public void get_ValueLength(){} // RVA: 0x90EDF0
        public void get_ValueSpan(){} // RVA: 0x11A820
        public void set_ValueSpan(){} // RVA: 0x11A830
        public void get_BytesConsumed(){} // RVA: 0x90EE00
        public void get_TokenStartIndex(){} // RVA: 0x3770
        public void set_TokenStartIndex(){} // RVA: 0x90EE10
        public void get_CurrentDepth(){} // RVA: 0x90EE20
        public void get_IsInArray(){} // RVA: 0x90EE50
        public void get_TokenType(){} // RVA: 0x90EE60
        public void get_HasValueSequence(){} // RVA: 0x90EE70
        public void set_HasValueSequence(){} // RVA: 0x90EE80
        public void get_ValueIsEscaped(){} // RVA: 0x90EE90
        public void set_ValueIsEscaped(){} // RVA: 0x90EEA0
        public void get_IsFinalBlock(){} // RVA: 0xB1800
        public void get_ValueSequence(){} // RVA: 0x90EEB0
        public void set_ValueSequence(){} // RVA: 0x90EED0
        public void get_Position(){} // RVA: 0x90EF40
        public void get_CurrentState(){} // RVA: 0x90F010
        public void .ctor(){} // RVA: 0x90F860
        public void Read(){} // RVA: 0x90F120
        public void Skip(){} // RVA: 0x90F130
        public void SkipHelper(){} // RVA: 0x90F150
        public void TrySkip(){} // RVA: 0x90F160
        public void TrySkipHelper(){} // RVA: 0x90F190
        public void ValueTextEquals(){} // RVA: 0x90F280
        public void TextEqualsHelper(){} // RVA: 0x90F260
        public void CompareToSequence(){} // RVA: 0x90F2A0
        public void UnescapeAndCompare(){} // RVA: 0x90F2C0
        public void UnescapeSequenceAndCompare(){} // RVA: 0x90F2E0
        public void IsTokenTypeString(){} // RVA: 0x72CC120
        public void MatchNotPossible(){} // RVA: 0x90F300
        public void MatchNotPossibleSequence(){} // RVA: 0x90F310
        public void StartObject(){} // RVA: 0x90F320
        public void EndObject(){} // RVA: 0x90F330
        public void StartArray(){} // RVA: 0x90F340
        public void EndArray(){} // RVA: 0x90F350
        public void UpdateBitStackOnEndToken(){} // RVA: 0x90F360
        public void ReadSingleSegment(){} // RVA: 0x90F3C0
        public void HasMoreData(){} // RVA: 0x90F3E0
        public void ReadFirstToken(){} // RVA: 0x90F3F0
        public void SkipWhiteSpace(){} // RVA: 0x90F400
        public void ConsumeValue(){} // RVA: 0x90F410
        public void ConsumeLiteral(){} // RVA: 0x90F420
        public void CheckLiteral(){} // RVA: 0x90F440
        public void ThrowInvalidLiteral(){} // RVA: 0x90F470
        public void ConsumeNumber(){} // RVA: 0x90F490
        public void ConsumePropertyName(){} // RVA: 0x90F4A0
        public void ConsumeString(){} // RVA: 0x90F4B0
        public void ConsumeStringAndValidate(){} // RVA: 0x90F4C0
        public void ValidateHexDigits(){} // RVA: 0x90F4E0
        public void TryGetNumber(){} // RVA: 0x90F500
        public void ConsumeNegativeSign(){} // RVA: 0x90F520
        public void ConsumeZero(){} // RVA: 0x90F530
        public void ConsumeIntegerDigits(){} // RVA: 0x90F540
        public void ConsumeDecimalDigits(){} // RVA: 0x90F550
        public void ConsumeSign(){} // RVA: 0x90F560
        public void ConsumeNextTokenOrRollback(){} // RVA: 0x90F570
        public void ConsumeNextToken(){} // RVA: 0x90F580
        public void ConsumeNextTokenFromLastNonCommentToken(){} // RVA: 0x90F590
        public void SkipAllComments(){} // RVA: 0x90F5B0
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkipped(){} // RVA: 0x90F5C0
        public void SkipComment(){} // RVA: 0x90F5D0
        public void SkipSingleLineComment(){} // RVA: 0x90F5E0
        public void FindLineSeparator(){} // RVA: 0x90F600
        public void ThrowOnDangerousLineSeparator(){} // RVA: 0x90F620
        public void SkipMultiLineComment(){} // RVA: 0x90F640
        public void ConsumeComment(){} // RVA: 0x90F660
        public void ConsumeSingleLineComment(){} // RVA: 0x90F670
        public void ConsumeMultiLineComment(){} // RVA: 0x90F690
        public void get_DebuggerDisplay(){} // RVA: 0x90F6B0
        public void get_DebugTokenType(){} // RVA: 0x90F7B0
        public void GetUnescapedSpan(){} // RVA: 0x90F7C0
        public void ReadMultiSegment(){} // RVA: 0x90F8E0
        public void ValidateStateAtEndOfData(){} // RVA: 0x90F8F0
        public void HasMoreDataMultiSegment(){} // RVA: 0x90F910
        public void GetNextSpan(){} // RVA: 0x90F920
        public void ReadFirstTokenMultiSegment(){} // RVA: 0x90F930
        public void SkipWhiteSpaceMultiSegment(){} // RVA: 0x90F940
        public void ConsumeValueMultiSegment(){} // RVA: 0x90F9A0
        public void ConsumeLiteralMultiSegment(){} // RVA: 0x90F9B0
        public void CheckLiteralMultiSegment(){} // RVA: 0x90F9D0
        public void FindMismatch(){} // RVA: 0x72D2EC0
        public void GetInvalidLiteralMultiSegment(){} // RVA: 0x90FA10
        public void ConsumeNumberMultiSegment(){} // RVA: 0x90FA70
        public void ConsumePropertyNameMultiSegment(){} // RVA: 0x90FA80
        public void ConsumeStringMultiSegment(){} // RVA: 0x90FA90
        public void ConsumeStringNextSegment(){} // RVA: 0x90FAA0
        public void ConsumeStringAndValidateMultiSegment(){} // RVA: 0x90FAB0
        public void RollBackState(){} // RVA: 0x90FAD0
        public void TryGetNumberMultiSegment(){} // RVA: 0x90FAE0
        public void ConsumeNegativeSignMultiSegment(){} // RVA: 0x90FB00
        public void ConsumeZeroMultiSegment(){} // RVA: 0x90FB10
        public void ConsumeIntegerDigitsMultiSegment(){} // RVA: 0x90FB20
        public void ConsumeDecimalDigitsMultiSegment(){} // RVA: 0x90FB30
        public void ConsumeSignMultiSegment(){} // RVA: 0x90FB40
        public void ConsumeNextTokenOrRollbackMultiSegment(){} // RVA: 0x90FB50
        public void ConsumeNextTokenMultiSegment(){} // RVA: 0x90FB60
        public void ConsumeNextTokenFromLastNonCommentTokenMultiSegment(){} // RVA: 0x90FB70
        public void SkipAllCommentsMultiSegment(){} // RVA: 0x90FB90
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(){} // RVA: 0x90FBA0
        public void SkipOrConsumeCommentMultiSegmentWithRollback(){} // RVA: 0x90FBB0
        public void SkipCommentMultiSegment(){} // RVA: 0x90FBC0
        public void SkipSingleLineCommentMultiSegment(){} // RVA: 0x90FBD0
        public void FindLineSeparatorMultiSegment(){} // RVA: 0x90FBF0
        public void ThrowOnDangerousLineSeparatorMultiSegment(){} // RVA: 0x90FC10
        public void SkipMultiLineCommentMultiSegment(){} // RVA: 0x90FC30
        public void CaptureState(){} // RVA: 0x90FC50
        public void GetString(){} // RVA: 0x90FD00
        public void CopyString(){} // RVA: 0x90FD70
        public void CopyValue(){} // RVA: 0x90FDB0
        public void TryCopyEscapedString(){} // RVA: 0x90FDD0
        public void GetComment(){} // RVA: 0x90FDF0
        public void GetBoolean(){} // RVA: 0x90FF10
        public void GetBytesFromBase64(){} // RVA: 0x90FF50
        public void GetByte(){} // RVA: 0x90FF90
        public void GetByteWithQuotes(){} // RVA: 0x90FFD0
        public void GetSByte(){} // RVA: 0x910020
        public void GetSByteWithQuotes(){} // RVA: 0x910060
        public void GetInt16(){} // RVA: 0x9100B0
        public void GetInt16WithQuotes(){} // RVA: 0x9100F0
        public void GetInt32(){} // RVA: 0x910140
        public void GetInt32WithQuotes(){} // RVA: 0x910180
        public void GetInt64(){} // RVA: 0x9101D0
        public void GetInt64WithQuotes(){} // RVA: 0x910210
        public void GetUInt16(){} // RVA: 0x910260
        public void GetUInt16WithQuotes(){} // RVA: 0x9102A0
        public void GetUInt32(){} // RVA: 0x9102F0
        public void GetUInt32WithQuotes(){} // RVA: 0x910330
        public void GetUInt64(){} // RVA: 0x910380
        public void GetUInt64WithQuotes(){} // RVA: 0x9103C0
        public void GetSingle(){} // RVA: 0x910410
        public void GetSingleWithQuotes(){} // RVA: 0x910450
        public void GetSingleFloatingPointConstant(){} // RVA: 0x910460
        public void GetDouble(){} // RVA: 0x910470
        public void GetDoubleWithQuotes(){} // RVA: 0x9104B0
        public void GetDoubleFloatingPointConstant(){} // RVA: 0x9104C0
        public void GetDecimal(){} // RVA: 0x9104D0
        public void GetDecimalWithQuotes(){} // RVA: 0x910520
        public void GetDateTime(){} // RVA: 0x910600
        public void GetDateTimeNoValidation(){} // RVA: 0x910650
        public void GetDateTimeOffset(){} // RVA: 0x910690
        public void GetDateTimeOffsetNoValidation(){} // RVA: 0x9106F0
        public void GetGuid(){} // RVA: 0x910740
        public void GetGuidNoValidation(){} // RVA: 0x9107A0
        public void TryGetBytesFromBase64(){} // RVA: 0x9107F0
        public void TryGetByte(){} // RVA: 0x910800
        public void TryGetByteCore(){} // RVA: 0x72D9A60
        public void TryGetSByte(){} // RVA: 0x910810
        public void TryGetSByteCore(){} // RVA: 0x72D9C60
        public void TryGetInt16(){} // RVA: 0x910820
        public void TryGetInt16Core(){} // RVA: 0x72D9E60
        public void TryGetInt32(){} // RVA: 0x910830
        public void TryGetInt32Core(){} // RVA: 0x72DA070
        public void TryGetInt64(){} // RVA: 0x910840
        public void TryGetInt64Core(){} // RVA: 0x72DA270
        public void TryGetUInt16(){} // RVA: 0x910850
        public void TryGetUInt16Core(){} // RVA: 0x72DA480
        public void TryGetUInt32(){} // RVA: 0x910860
        public void TryGetUInt32Core(){} // RVA: 0x72DA690
        public void TryGetUInt64(){} // RVA: 0x910870
        public void TryGetUInt64Core(){} // RVA: 0x72DA890
        public void TryGetSingle(){} // RVA: 0x910880
        public void TryGetDouble(){} // RVA: 0x910890
        public void TryGetDecimal(){} // RVA: 0x9108A0
        public void TryGetDecimalCore(){} // RVA: 0x72DAE70
        public void TryGetDateTime(){} // RVA: 0x9108B0
        public void TryGetDateTimeCore(){} // RVA: 0x9108E0
        public void TryGetDateTimeOffset(){} // RVA: 0x9108F0
        public void TryGetDateTimeOffsetCore(){} // RVA: 0x910920
        public void TryGetGuid(){} // RVA: 0x910930
        public void TryGetGuidCore(){} // RVA: 0x910960
    }

    public class Utf8JsonWriter : Object
    {
        public object s_newLineLength;
        public object _output;
        public object _stream;
        public object _arrayBufferWriter;
        public object _memory;
        public object _inObject;
        public object _tokenType;
        public object _bitStack;
        public object _currentDepth;
        public object _options;
        public object _bytesPending;
        public object _bytesCommitted;
        public object s_singleLineCommentDelimiter;

        // ── Methods ──
        public void get_BytesPending(){} // RVA: 0x19C6270
        public void set_BytesPending(){} // RVA: 0xCE5450
        public void get_BytesCommitted(){} // RVA: 0xCD3320
        public void set_BytesCommitted(){} // RVA: 0x6529A50
        public void get_Indentation(){} // RVA: 0x6D9F7A0
        public void get_TokenType(){} // RVA: 0xD15320
        public void get_CurrentDepth(){} // RVA: 0x6D9F7B0
        public void .ctor(){} // RVA: 0x6D9F8F0
        public void ResetHelper(){} // RVA: 0x6D9FBD0
        public void CheckNotDisposed(){} // RVA: 0x6D9FBF0
        public void Flush(){} // RVA: 0x6D9FC60
        public void Dispose(){} // RVA: 0x6D9FE80
        public void DisposeAsync(){} // RVA: 0x6D9FFC0
        public void FlushAsync(){} // RVA: 0x6DA0150
        public void WriteStartArray(){} // RVA: 0x6DA0E60
        public void WriteStartObject(){} // RVA: 0x6DA0F30
        public void WriteStart(){} // RVA: 0x6DA03A0
        public void WriteStartMinimized(){} // RVA: 0x6DA0460
        public void WriteStartSlow(){} // RVA: 0x6DA0570
        public void ValidateStart(){} // RVA: 0x6DA05F0
        public void WriteStartIndented(){} // RVA: 0x6DA0660
        public void WriteStartHelper(){} // RVA: 0x6DA09B0
        public void WriteStartByOptions(){} // RVA: 0x6DA11E0
        public void WriteStartEscape(){} // RVA: 0x6DA1000
        public void WriteStartEscapeProperty(){} // RVA: 0x6DA1290
        public void WriteEndArray(){} // RVA: 0x6DA16E0
        public void WriteEndObject(){} // RVA: 0x6DA1730
        public void WriteEnd(){} // RVA: 0x6DA1780
        public void WriteEndMinimized(){} // RVA: 0x6DA17C0
        public void WriteEndSlow(){} // RVA: 0x6DA18A0
        public void ValidateEnd(){} // RVA: 0x6DA1AD0
        public void WriteEndIndented(){} // RVA: 0x6DA1BB0
        public void WriteNewLine(){} // RVA: 0x6DA1DC0
        public void UpdateBitStackOnStart(){} // RVA: 0x6DA1EA0
        public void Grow(){} // RVA: 0x6DA1F40
        public void FirstCallToGetMemory(){} // RVA: 0x6DA2320
        public void SetFlagToAddListSeparatorBeforeNextItem(){} // RVA: 0x6DA24E0
        public void WritePropertyName(){} // RVA: 0x6DAFFD0
        public void WriteString(){} // RVA: 0x6DACFA0
        public void WriteStringEscape(){} // RVA: 0x6DB7040
        public void WriteStringEscapeProperty(){} // RVA: 0x6DABD80
        public void WriteStringByOptions(){} // RVA: 0x6DB7180
        public void WriteStringMinimized(){} // RVA: 0x6DB71F0
        public void WriteStringIndented(){} // RVA: 0x6DB7400
        public void WriteNumber(){} // RVA: 0x6DAF1D0
        public void WriteNumberEscape(){} // RVA: 0x6DAF2C0
        public void WriteNumberEscapeProperty(){} // RVA: 0x6DAF490
        public void WriteNumberByOptions(){} // RVA: 0x6DAF8D0
        public void WriteNumberMinimized(){} // RVA: 0x6DAF940
        public void WriteNumberIndented(){} // RVA: 0x6DAFC10
        public void ValidatePropertyNameAndDepth(){} // RVA: 0x6DA6560
        public void ValidateDepth(){} // RVA: 0x6DA65E0
        public void ValidateWritingProperty(){} // RVA: 0x6DA6650
        public void WritePropertyNameMinimized(){} // RVA: 0x6DA6C80
        public void WritePropertyNameIndented(){} // RVA: 0x6DA6E80
        public void TranscodeAndWrite(){} // RVA: 0x6DA71B0
        public void WriteNull(){} // RVA: 0x6DA7850
        public void WriteNullSection(){} // RVA: 0x6DA7480
        public void WriteLiteralHelper(){} // RVA: 0x6DA76A0
        public void WriteBoolean(){} // RVA: 0x6DA7C20
        public void WriteLiteralEscape(){} // RVA: 0x6DA7DD0
        public void WriteLiteralEscapeProperty(){} // RVA: 0x6DA7FD0
        public void WriteLiteralByOptions(){} // RVA: 0x6DB4C80
        public void WriteLiteralMinimized(){} // RVA: 0x6DB4E80
        public void WriteLiteralSection(){} // RVA: 0x6DA8AF0
        public void WriteLiteralIndented(){} // RVA: 0x6DB5020
        public void WritePropertyNameSection(){} // RVA: 0x6DAAB10
        public void WritePropertyNameHelper(){} // RVA: 0x6DAADA0
        public void WriteStringByOptionsPropertyName(){} // RVA: 0x6DAC1E0
        public void WriteStringMinimizedPropertyName(){} // RVA: 0x6DAC250
        public void WriteStringIndentedPropertyName(){} // RVA: 0x6DAC630
        public void WritePropertyNameUnescaped(){} // RVA: 0x6DABC70
        public void WriteStringPropertyNameSection(){} // RVA: 0x6DAC490
        public void WriteStringHelperEscapeValue(){} // RVA: 0x6DAD080
        public void WriteStringEscapeValueOnly(){} // RVA: 0x6DAD2E0
        public void WriteStringEscapePropertyOrValue(){} // RVA: 0x6DADA10
        public void WriteBase64StringValue(){} // RVA: 0x6DB02E0
        public void WriteBase64ByOptions(){} // RVA: 0x6DB03D0
        public void WriteBase64Minimized(){} // RVA: 0x6DB0440
        public void WriteBase64Indented(){} // RVA: 0x6DB0650
        public void WriteStringValue(){} // RVA: 0x6DB6E90
        public void WriteStringValueMinimized(){} // RVA: 0x6DB40A0
        public void WriteStringValueIndented(){} // RVA: 0x6DB42D0
        public void WriteNumberValue(){} // RVA: 0x6DB7BA0
        public void WriteNumberValueMinimized(){} // RVA: 0x6DB7DC0
        public void WriteNumberValueIndented(){} // RVA: 0x6DB7FA0
        public void WriteNumberValueAsString(){} // RVA: 0x6DB8270
        public void TryFormatDouble(){} // RVA: 0x6DB2340
        public void WriteFloatingPointConstant(){} // RVA: 0x6DB36B0
        public void TryFormatSingle(){} // RVA: 0x6DB3180
        public void ValidateWritingValue(){} // RVA: 0x6DB45B0
        public void Base64EncodeAndWrite(){} // RVA: 0x6DB4620
        public void WriteNullValue(){} // RVA: 0x6DB4AA0
        public void WriteBooleanValue(){} // RVA: 0x6DB4B40
        public void WriteRawValue(){} // RVA: 0x6DB52C0
        public void WriteRawValueCore(){} // RVA: 0x6DB5360
        public void WriteStringEscapeValue(){} // RVA: 0x6DB7710
        public void WriteNumberValueAsStringUnescaped(){} // RVA: 0x6DB7B20
        public void .cctor(){} // RVA: 0x6DB85A0
    }

    public class Utf8JsonWriter : Object
    {
        public object s_newLineLength;
        public object DefaultGrowthSize;
        public object InitialGrowthSize;
        public object _output;
        public object _stream;
        public object _arrayBufferWriter;
        public object _memory;
        public object _inObject;
        public object _commentAfterNoneOrPropertyName;
        public object _tokenType;
        public object _bitStack;
        public object _currentDepth;
        public object _options;
        public object _bytesPending;
        public object _bytesCommitted;
        public object s_singleLineCommentDelimiter;

        // ── Methods ──
        public void get_BytesPending(){} // RVA: 0x19C6270
        public void set_BytesPending(){} // RVA: 0xCE5450
        public void get_BytesCommitted(){} // RVA: 0xCD3320
        public void set_BytesCommitted(){} // RVA: 0x6529A50
        public void get_Options(){} // RVA: 0x4127D80
        public void get_Indentation(){} // RVA: 0x6D9F7A0
        public void get_TokenType(){} // RVA: 0x1DC2880
        public void get_CurrentDepth(){} // RVA: 0x6D9F7B0
        public void .ctor(){} // RVA: 0x72DC840
        public void Reset(){} // RVA: 0x72DD060
        public void ResetAllStateForCacheReuse(){} // RVA: 0x72DCF30
        public void CreateEmptyInstanceForCaching(){} // RVA: 0x72DD150
        public void ResetHelper(){} // RVA: 0x72DD190
        public void CheckNotDisposed(){} // RVA: 0x72DD1C0
        public void Flush(){} // RVA: 0x72DD1E0
        public void Dispose(){} // RVA: 0x72DD410
        public void DisposeAsync(){} // RVA: 0x72DD560
        public void FlushAsync(){} // RVA: 0x72DD6F0
        public void WriteStartArray(){} // RVA: 0x72DE8B0
        public void WriteStartObject(){} // RVA: 0x72DE970
        public void WriteStart(){} // RVA: 0x72DD940
        public void WriteStartMinimized(){} // RVA: 0x72DDA10
        public void WriteStartSlow(){} // RVA: 0x72DDAD0
        public void ValidateStart(){} // RVA: 0x72DDB50
        public void WriteStartIndented(){} // RVA: 0x72DDBE0
        public void WriteStartHelper(){} // RVA: 0x72DDF40
        public void WriteStartEscape(){} // RVA: 0x72DEA30
        public void WriteStartByOptions(){} // RVA: 0x72DEB90
        public void WriteStartEscapeProperty(){} // RVA: 0x72DEDA0
        public void WriteEndArray(){} // RVA: 0x72DF080
        public void WriteEndObject(){} // RVA: 0x72DF0A0
        public void WriteEnd(){} // RVA: 0x72DF0C0
        public void WriteEndMinimized(){} // RVA: 0x72DF140
        public void WriteEndSlow(){} // RVA: 0x72DF1E0
        public void ValidateEnd(){} // RVA: 0x72DF240
        public void WriteEndIndented(){} // RVA: 0x72DF350
        public void WriteNewLine(){} // RVA: 0x72DF530
        public void UpdateBitStackOnStart(){} // RVA: 0x72DF5D0
        public void Grow(){} // RVA: 0x72DF670
        public void FirstCallToGetMemory(){} // RVA: 0x72DF890
        public void SetFlagToAddListSeparatorBeforeNextItem(){} // RVA: 0x6DA24E0
        public void get_DebuggerDisplay(){} // RVA: 0x72DFA40
        public void WriteBase64String(){} // RVA: 0x72DFED0
        public void WriteBase64Escape(){} // RVA: 0x72E02A0
        public void WriteBase64EscapeProperty(){} // RVA: 0x72E0760
        public void WriteBase64ByOptions(){} // RVA: 0x72FC840
        public void WriteBase64Minimized(){} // RVA: 0x72FC8A0
        public void WriteBase64Indented(){} // RVA: 0x72FCA40
        public void WriteString(){} // RVA: 0x72F6120
        public void WriteStringEscape(){} // RVA: 0x7304250
        public void WriteStringEscapeProperty(){} // RVA: 0x72F3E60
        public void WriteStringByOptions(){} // RVA: 0x7304370
        public void WriteStringMinimized(){} // RVA: 0x73043D0
        public void WriteStringIndented(){} // RVA: 0x7304560
        public void WritePropertyName(){} // RVA: 0x72FC640
        public void WriteNumber(){} // RVA: 0x72FAF70
        public void WriteNumberEscape(){} // RVA: 0x72FB150
        public void WriteNumberEscapeProperty(){} // RVA: 0x72FB5D0
        public void WriteNumberByOptions(){} // RVA: 0x72FB9A0
        public void WriteNumberMinimized(){} // RVA: 0x72FBC60
        public void WriteNumberIndented(){} // RVA: 0x72FC2C0
        public void ValidatePropertyNameAndDepth(){} // RVA: 0x72ED930
        public void ValidateDepth(){} // RVA: 0x72ED9B0
        public void ValidateWritingProperty(){} // RVA: 0x72EDA30
        public void WritePropertyNameMinimized(){} // RVA: 0x72EDF20
        public void WritePropertyNameIndented(){} // RVA: 0x72EE080
        public void TranscodeAndWrite(){} // RVA: 0x72EE3B0
        public void WriteNull(){} // RVA: 0x72EEB10
        public void WriteNullSection(){} // RVA: 0x72EE650
        public void WriteLiteralHelper(){} // RVA: 0x72EE880
        public void WriteBoolean(){} // RVA: 0x72EF300
        public void WriteLiteralEscape(){} // RVA: 0x72EF650
        public void WriteLiteralEscapeProperty(){} // RVA: 0x72EFB10
        public void WriteLiteralByOptions(){} // RVA: 0x7301B00
        public void WriteLiteralMinimized(){} // RVA: 0x7301D00
        public void WriteLiteralSection(){} // RVA: 0x72F0280
        public void WriteLiteralIndented(){} // RVA: 0x7301E70
        public void WritePropertyNameSection(){} // RVA: 0x72F2C70
        public void WritePropertyNameHelper(){} // RVA: 0x72F2F30
        public void WriteStringByOptionsPropertyName(){} // RVA: 0x72F41C0
        public void WriteStringMinimizedPropertyName(){} // RVA: 0x72F4230
        public void WriteStringIndentedPropertyName(){} // RVA: 0x72F4540
        public void WritePropertyNameUnescaped(){} // RVA: 0x72F3D40
        public void WriteStringPropertyNameSection(){} // RVA: 0x72F43D0
        public void WriteStringHelper(){} // RVA: 0x72F4A60
        public void WriteStringHelperEscapeValue(){} // RVA: 0x72F5680
        public void WriteStringHelperEscapeProperty(){} // RVA: 0x72F5F50
        public void WriteStringEscapeValueOnly(){} // RVA: 0x72F66D0
        public void WriteStringEscapePropertyOnly(){} // RVA: 0x72F6D60
        public void WriteStringEscapePropertyOrValue(){} // RVA: 0x72F8A60
        public void WriteBase64StringValue(){} // RVA: 0x72FC7E0
        public void get_SingleLineCommentDelimiterUtf8(){} // RVA: 0x72FCD80
        public void WriteCommentValue(){} // RVA: 0x72FD690
        public void WriteCommentByOptions(){} // RVA: 0x72FD930
        public void WriteCommentMinimized(){} // RVA: 0x72FD960
        public void WriteCommentIndented(){} // RVA: 0x72FDB00
        public void WriteStringValue(){} // RVA: 0x73040B0
        public void WriteStringValueMinimized(){} // RVA: 0x7301130
        public void WriteStringValueIndented(){} // RVA: 0x73012F0
        public void WriteNumberValue(){} // RVA: 0x7304BB0
        public void WriteNumberValueMinimized(){} // RVA: 0x7304C00
        public void WriteNumberValueIndented(){} // RVA: 0x7304DC0
        public void WriteNumberValueAsString(){} // RVA: 0x73050F0
        public void TryFormatDouble(){} // RVA: 0x72FF710
        public void WriteFloatingPointConstant(){} // RVA: 0x7300760
        public void TryFormatSingle(){} // RVA: 0x73003B0
        public void ValidateWritingValue(){} // RVA: 0x73015A0
        public void Base64EncodeAndWrite(){} // RVA: 0x7301630
        public void WriteNullValue(){} // RVA: 0x7301980
        public void WriteBooleanValue(){} // RVA: 0x7301A00
        public void WriteRawValue(){} // RVA: 0x7302310
        public void TranscodeAndWriteRawValue(){} // RVA: 0x73026B0
        public void WriteRawValueCore(){} // RVA: 0x73029D0
        public void WriteStringEscapeValue(){} // RVA: 0x73047F0
        public void WriteNumberValueAsStringUnescaped(){} // RVA: 0x7304B00
        public void .cctor(){} // RVA: 0x73052C0
    }

    public class Utf8JsonWriterCache : Object
    {
        public object t_threadLocalState;

        // ── Methods ──
        public void RentWriterAndBuffer(){} // RVA: 0x730E500
        public void RentWriter(){} // RVA: 0x730E8B0
        public void ReturnWriterAndBuffer(){} // RVA: 0x730EAB0
        public void ReturnWriter(){} // RVA: 0x730EC50
    }

    public class WriteStack : ValueType
    {
        public object Current;
        public object _stack;
        public object _count;
        public object _continuationCount;
        public object CancellationToken;
        public object SuppressFlush;
        public object PendingTask;
        public object CompletedAsyncDisposables;
        public object FlushThreshold;
        public object ReferenceResolver;
        public object SupportContinuation;
        public object BoxedStructReferenceId;

        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x8F18A0
        public void EnsurePushCapacity(){} // RVA: 0x8F18B0
        public void Initialize(){} // RVA: 0x8F1910
        public void Push(){} // RVA: 0x8F1920
        public void Pop(){} // RVA: 0x8F1930
        public void AddCompletedAsyncDisposable(){} // RVA: 0x8F1940
        public void DisposePendingDisposablesOnException(){} // RVA: 0x8F1950
        public void PropertyPath(){} // RVA: 0x8F1960
        public void <DisposePendingDisposablesOnException>g__DisposeFrame|21_0(){} // RVA: 0x6D9BD40
        public void <PropertyPath>g__AppendStackFrame|23_0(){} // RVA: 0x6D9BDC0
        public void <PropertyPath>g__AppendPropertyName|23_1(){} // RVA: 0x6D9BEE0
    }

    public class WriteStack : ValueType
    {
        public object Current;
        public object _stack;
        public object _count;
        public object _continuationCount;
        public object _indexOffset;
        public object CancellationToken;
        public object SuppressFlush;
        public object PendingTask;
        public object CompletedAsyncDisposables;
        public object FlushThreshold;
        public object ReferenceResolver;
        public object SupportContinuation;
        public object SupportAsync;
        public object NewReferenceId;
        public object PolymorphicTypeDiscriminator;
        public object PolymorphicTypeResolver;

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0xCFAF0
        public void get_Parent(){} // RVA: 0x911910
        public void get_IsContinuation(){} // RVA: 0x911960
        public void get_CurrentContainsMetadata(){} // RVA: 0x911970
        public void EnsurePushCapacity(){} // RVA: 0x911990
        public void Initialize(){} // RVA: 0x9119A0
        public void PeekNestedJsonTypeInfo(){} // RVA: 0x9119C0
        public void Push(){} // RVA: 0x911A20
        public void Pop(){} // RVA: 0x911A30
        public void AddCompletedAsyncDisposable(){} // RVA: 0x911A40
        public void DisposeCompletedAsyncDisposables(){} // RVA: 0x911A50
        public void DisposePendingDisposablesOnException(){} // RVA: 0x911A80
        public void DisposePendingDisposablesOnExceptionAsync(){} // RVA: 0x911A90
        public void PropertyPath(){} // RVA: 0x911AC0
        public void get_DebuggerDisplay(){} // RVA: 0x911AD0
        public void <DisposePendingDisposablesOnException>g__DisposeFrame|31_0(){} // RVA: 0x7317080
        public void <DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|32_0(){} // RVA: 0x7317100
        public void <PropertyPath>g__AppendStackFrame|33_0(){} // RVA: 0x73173B0
        public void <PropertyPath>g__AppendPropertyName|33_1(){} // RVA: 0x7317500
    }

    public class WriteStackFrame : ValueType
    {
        public object CollectionEnumerator;
        public object AsyncDisposable;
        public object AsyncEnumeratorIsPendingCompletion;
        public object DeclaredJsonPropertyInfo;
        public object IsWritingExtensionDataProperty;
        public object JsonTypeInfo;
        public object OriginalDepth;
        public object ProcessedStartToken;
        public object ProcessedEndToken;
        public object PropertyState;
        public object EnumeratorIndex;
        public object JsonPropertyNameAsString;
        public object MetadataPropertyName;
        public object PolymorphicJsonPropertyInfo;
        public object NumberHandling;

        // ── Methods ──
        public void EndDictionaryElement(){} // RVA: 0x8F1A30
        public void EndProperty(){} // RVA: 0x8F1A40
        public void GetPolymorphicJsonPropertyInfo(){} // RVA: 0x8F1A50
        public void InitializeReEntry(){} // RVA: 0x8F1A60
    }

    public class WriteStackFrame : ValueType
    {
        public object CollectionEnumerator;
        public object AsyncDisposable;
        public object AsyncEnumeratorIsPendingCompletion;
        public object JsonPropertyInfo;
        public object IsWritingExtensionDataProperty;
        public object JsonTypeInfo;
        public object OriginalDepth;
        public object ProcessedStartToken;
        public object ProcessedEndToken;
        public object PropertyState;
        public object EnumeratorIndex;
        public object JsonPropertyNameAsString;
        public object MetadataPropertyName;
        public object PolymorphicSerializationState;
        public object PolymorphicTypeInfo;
        public object NumberHandling;
        public object IsPushedReferenceForCycleDetection;

        // ── Methods ──
        public void EndCollectionElement(){} // RVA: 0x911CC0
        public void EndDictionaryEntry(){} // RVA: 0x911CD0
        public void EndProperty(){} // RVA: 0x911CE0
        public void GetNestedJsonTypeInfo(){} // RVA: 0x911CF0
        public void InitializePolymorphicReEntry(){} // RVA: 0x911D60
        public void ResumePolymorphicReEntry(){} // RVA: 0x911DD0
        public void ExitPolymorphicConverter(){} // RVA: 0x911E00
        public void get_DebuggerDisplay(){} // RVA: 0x911E10
    }

}