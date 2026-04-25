// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json
// Classes: 37
// Methods: 1043

namespace ThirdParty.DotNet.System.Text.Json
{
    public class AppContextSwitchHelper : Object
    {
        public bool IsSourceGenReflectionFallbackEnabled;

        // ── Methods ──
        public void get_IsSourceGenReflectionFallbackEnabled(){} // RVA: 0x7FFAC8FE4970
        public void .cctor(){} // RVA: 0x7FFAC8FE49D0
    }

    public class ArgumentState : Object
    {
        public object Arguments; // 0x10
        public System.ValueTuple`5<System.Text.Json.Serialization.Metadata.JsonPropertyInfo,System.Text.Json.JsonReaderState,long,byte[],string>[] FoundProperties; // 0x18
        public System.ValueTuple`3<System.Text.Json.Serialization.Metadata.JsonPropertyInfo,object,string>[] FoundPropertiesAsync; // 0x20
        public int FoundPropertyCount; // 0x28
        public System.Text.Json.Serialization.Metadata.JsonParameterInfo JsonParameterInfo; // 0x30
        public int ParameterIndex; // 0x38
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.Metadata.ParameterRef> ParameterRefCache; // 0x40
        public bool FoundKey; // 0x48
        public bool FoundValue; // 0x49

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Arguments`4 : Object
    {
        public U Arg0;
        public V Arg1;
        public W Arg2;
        public T Arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class BitStack : ValueType
    {
        public int[] CurrentDepth; // 0x10
        public ulong _allocationFreeContainer; // 0x18
        public int _currentDepth; // 0x20

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x7FFAC2F6E5C0
        public void PushTrue(){} // RVA: 0x7FFAC8A97C30
        public void PushFalse(){} // RVA: 0x7FFAC8A97C70
        public void PushToArray(){} // RVA: 0x7FFAC8A97CB0
        public void Pop(){} // RVA: 0x7FFAC8A97DD0
        public void PopFromArray(){} // RVA: 0x7FFAC8A97E00
        public void DoubleArray(){} // RVA: 0x7FFAC8A97E50
        public void SetFirstBit(){} // RVA: 0x7FFAC8A97EF0
        public void ResetFirstBit(){} // RVA: 0x7FFAC8A97F00
        public void Div32Rem(){} // RVA: 0x7FFAC8A97F10
    }

    public class JsonCamelCaseNamingPolicy : JsonNamingPolicy
    {
        // ── Methods ──
        public void ConvertName(){} // RVA: 0x7FFAC8A95170
        public void FixCasing(){} // RVA: 0x7FFAC8A95290
        public void .ctor(){} // RVA: 0x7FFAC8A95430
    }

    public class JsonConstants : Object
    {
        public object Utf8Bom;
        public object TrueValue;
        public object FalseValue;
        public object NullValue;
        public object NaNValue;
        public object PositiveInfinityValue;
        public object NegativeInfinityValue;
        public object Delimiters;
        public object EscapableChars;

        // ── Methods ──
        public void get_Utf8Bom(){} // RVA: 0x7FFAC8A955D0
        public void get_TrueValue(){} // RVA: 0x7FFAC8A95640
        public void get_FalseValue(){} // RVA: 0x7FFAC8A956B0
        public void get_NullValue(){} // RVA: 0x7FFAC8A95720
        public void get_NaNValue(){} // RVA: 0x7FFAC8A95790
        public void get_PositiveInfinityValue(){} // RVA: 0x7FFAC8A95800
        public void get_NegativeInfinityValue(){} // RVA: 0x7FFAC8A95870
        public void get_Delimiters(){} // RVA: 0x7FFAC8A958E0
        public void get_EscapableChars(){} // RVA: 0x7FFAC8A95950
    }

    public class JsonDocument : Object
    {
        public System.ReadOnlyMemory`1<byte> IsDisposable; // 0x10
        public MetadataDb RootElement; // 0x20
        public byte[] _extraRentedArrayPoolBytes; // 0x38
        public bool _hasExtraRentedArrayPoolBytes; // 0x40
        public System.Text.Json.PooledByteBufferWriter _extraPooledByteBufferWriter; // 0x48
        public bool _hasExtraPooledByteBufferWriter; // 0x50
        public bool <IsDisposable>k__BackingField; // 0x51
        public System.Text.Json.JsonDocument s_nullLiteral;
        public System.Text.Json.JsonDocument s_trueLiteral; // 0x8
        public System.Text.Json.JsonDocument s_falseLiteral; // 0x10

        // ── Methods ──
        public void get_IsDisposable(){} // RVA: 0x7FFAC8489120
        public void get_RootElement(){} // RVA: 0x7FFAC8A97F20
        public void .ctor(){} // RVA: 0x7FFAC8A97F90
        public void Dispose(){} // RVA: 0x7FFAC8A98140
        public void WriteTo(){} // RVA: 0x7FFAC8A98390
        public void GetJsonTokenType(){} // RVA: 0x7FFAC8A98490
        public void GetArrayLength(){} // RVA: 0x7FFAC8A984C0
        public void GetArrayIndexElement(){} // RVA: 0x7FFAC8A98540
        public void GetEndIndex(){} // RVA: 0x7FFAC8A98710
        public void GetRawValue(){} // RVA: 0x7FFAC8A98790
        public void GetPropertyRawValue(){} // RVA: 0x7FFAC8A989C0
        public void GetString(){} // RVA: 0x7FFAC8A98C90
        public void TextEquals(){} // RVA: 0x7FFAC8A98F70
        public void GetNameOfPropertyValue(){} // RVA: 0x7FFAC8A99490
        public void TryGetValue(){} // RVA: 0x7FFAC8A9A120 | overloaded x6
        public void GetRawValueAsString(){} // RVA: 0x7FFAC8A9A430
        public void GetPropertyRawValueAsString(){} // RVA: 0x7FFAC8A9A4F0
        public void CloneElement(){} // RVA: 0x7FFAC8A9A5B0
        public void WriteElementTo(){} // RVA: 0x7FFAC8A9A930
        public void WriteComplexElement(){} // RVA: 0x7FFAC8A9AF60
        public void UnescapeString(){} // RVA: 0x7FFAC8A9B230
        public void ClearAndReturn(){} // RVA: 0x7FFAC8A9B8E0
        public void WritePropertyName(){} // RVA: 0x7FFAC8A9BAB0
        public void WriteString(){} // RVA: 0x7FFAC8A9BCD0
        public void Parse(){} // RVA: 0x7FFAC8A9E140 | overloaded x6
        public void CheckNotDisposed(){} // RVA: 0x7FFAC8A9C1A0
        public void CheckExpectedType(){} // RVA: 0x7FFAC8A9C230
        public void CheckSupportedOptions(){} // RVA: 0x7FFAC8A9C280
        public void ParseAsync(){} // RVA: 0x7FFAC8A9C5C0
        public void ParseAsyncCore(){} // RVA: 0x7FFAC8A9C630
        public void ParseValue(){} // RVA: 0x7FFAC8A9CD20
        public void TryParseValue(){} // RVA: 0x7FFAC8A9CD50
        public void CreateForLiteral(){} // RVA: 0x7FFAC8A9DDF0
        public void ParseUnrented(){} // RVA: 0x7FFAC8A9E380
        public void ReadToEnd(){} // RVA: 0x7FFAC8A9E660
        public void ReadToEndAsync(){} // RVA: 0x7FFAC8A9EDD0
        public void TryGetNamedPropertyValue(){} // RVA: 0x7FFAC8A9F770 | overloaded x2
        public void <CreateForLiteral>g__Create|74_0(){} // RVA: 0x7FFAC8AA01F0
    }

    public class JsonDocumentOptions : ValueType
    {
        public int CommentHandling; // 0x10
        public 0x6B21D2F0 MaxDepth; // 0x14
        public bool AllowTrailingCommas; // 0x15

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x7FFAC4A0B160
        public void get_MaxDepth(){} // RVA: 0x7FFAC4420210
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFAC4A0B150
        public void GetReaderOptions(){} // RVA: 0x7FFAC8AA3850
    }

    public class JsonElement : ValueType
    {
        public System.Text.Json.JsonDocument TokenType; // 0x10
        public int ValueKind; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC335C3C0
        public void get_TokenType(){} // RVA: 0x7FFAC8AA38F0
        public void get_ValueKind(){} // RVA: 0x7FFAC8AA3930
        public void get_Item(){} // RVA: 0x7FFAC8AA3A20
        public void GetArrayLength(){} // RVA: 0x7FFAC8AA3AA0
        public void GetProperty(){} // RVA: 0x7FFAC8AA3B60
        public void TryGetProperty(){} // RVA: 0x7FFAC8AA3D50 | overloaded x2
        public void GetBoolean(){} // RVA: 0x7FFAC8AA3DD0
        public void GetString(){} // RVA: 0x7FFAC8AA3E60
        public void TryGetInt16(){} // RVA: 0x7FFAC8AA3ED0
        public void GetInt16(){} // RVA: 0x7FFAC8AA3F40
        public void TryGetInt32(){} // RVA: 0x7FFAC8AA3FF0
        public void GetInt32(){} // RVA: 0x7FFAC8AA4060
        public void TryGetInt64(){} // RVA: 0x7FFAC8AA40F0
        public void GetInt64(){} // RVA: 0x7FFAC8AA4160
        public void TryGetDouble(){} // RVA: 0x7FFAC8AA4200
        public void GetDouble(){} // RVA: 0x7FFAC8AA4270
        public void TryGetSingle(){} // RVA: 0x7FFAC8AA4310
        public void GetSingle(){} // RVA: 0x7FFAC8AA4380
        public void TryGetDateTimeOffset(){} // RVA: 0x7FFAC8AA4420
        public void GetDateTimeOffset(){} // RVA: 0x7FFAC8AA4490
        public void GetPropertyName(){} // RVA: 0x7FFAC8AA4530
        public void GetPropertyRawText(){} // RVA: 0x7FFAC8AA45A0
        public void TextEqualsHelper(){} // RVA: 0x7FFAC8AA46A0
        public void WriteTo(){} // RVA: 0x7FFAC8AA4730
        public void EnumerateArray(){} // RVA: 0x7FFAC8AA47E0
        public void EnumerateObject(){} // RVA: 0x7FFAC8AA48C0
        public void ToString(){} // RVA: 0x7FFAC8AA49A0
        public void Clone(){} // RVA: 0x7FFAC8AA4BC0
        public void CheckValidInstance(){} // RVA: 0x7FFAC8AA4C50
        public void ParseValue(){} // RVA: 0x7FFAC8AA4CB0
    }

    public class JsonEncodedText : ValueType
    {
        public byte[] EncodedUtf8Bytes; // 0x10
        public string _value; // 0x18

        // ── Methods ──
        public void get_EncodedUtf8Bytes(){} // RVA: 0x7FFAC8AA55E0
        public void .ctor(){} // RVA: 0x7FFAC8AA5680
        public void Encode(){} // RVA: 0x7FFAC8AA5980 | overloaded x2
        public void TranscodeAndEncode(){} // RVA: 0x7FFAC8AA5A50
        public void EncodeHelper(){} // RVA: 0x7FFAC8AA5F50
        public void Equals(){} // RVA: 0x7FFAC8AA60E0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8AA61C0
        public void GetHashCode(){} // RVA: 0x7FFAC8AA6210
    }

    public class JsonException : Exception
    {
        public string AppendPathInformation; // 0x90
        public bool LineNumber; // 0x98
        public System.Nullable`1<long> BytePositionInLine; // 0xA0
        public System.Nullable`1<long> Path; // 0xB0
        public string Message; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AA6560 | overloaded x5
        public void get_AppendPathInformation(){} // RVA: 0x7FFAC339A7F0
        public void set_AppendPathInformation(){} // RVA: 0x7FFAC339FA20
        public void GetObjectData(){} // RVA: 0x7FFAC8AA6970
        public void get_LineNumber(){} // RVA: 0x7FFAC88C7180
        public void set_LineNumber(){} // RVA: 0x7FFAC88C7190
        public void get_BytePositionInLine(){} // RVA: 0x7FFAC3695970
        public void set_BytePositionInLine(){} // RVA: 0x7FFAC3693CA0
        public void get_Path(){} // RVA: 0x7FFAC2F8C120
        public void set_Path(){} // RVA: 0x7FFAC2F8C130
        public void get_Message(){} // RVA: 0x7FFAC8AA6F50
        public void SetMessage(){} // RVA: 0x7FFAC354E360
    }

    public class JsonHelpers : Object
    {
        public int[] s_daysToMonth365;
        public int[] s_daysToMonth366; // 0x8

        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFAC2C5D5A0
        public void GetSpan(){} // RVA: 0x7FFAC8A959C0
        public void IsInRangeInclusive(){} // RVA: 0x7FFAC8A95AB0 | overloaded x3
        public void IsDigit(){} // RVA: 0x7FFAC8A95AC0
        public void ReadWithVerify(){} // RVA: 0x7FFAC8A95AD0
        public void Utf8GetString(){} // RVA: 0x7FFAC8A95AE0
        public void CreateDictionaryFromCollection(){} // RVA: 0x7FFAC2C58FF0
        public void IsFinite(){} // RVA: 0x7FFAC8A95BA0 | overloaded x2
        public void ValidateInt32MaxArrayLength(){} // RVA: 0x7FFAC8A95BD0
        public void IsValidDateTimeOffsetParseLength(){} // RVA: 0x7FFAC8A95BF0
        public void TryParseAsISO(){} // RVA: 0x7FFAC8A95E10 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFAC8A95F90
        public void TryGetNextTwoDigits(){} // RVA: 0x7FFAC8A966C0
        public void TryCreateDateTimeOffset(){} // RVA: 0x7FFAC8A968C0 | overloaded x2
        public void TryCreateDateTimeOffsetInterpretingDataAsLocalTime(){} // RVA: 0x7FFAC8A969D0
        public void TryCreateDateTime(){} // RVA: 0x7FFAC8A96AD0
        public void GetEscapedPropertyNameSection(){} // RVA: 0x7FFAC8A97260 | overloaded x2
        public void EscapeValue(){} // RVA: 0x7FFAC8A96F10
        public void GetPropertyNameSection(){} // RVA: 0x7FFAC8A97670
        public void .cctor(){} // RVA: 0x7FFAC8A97820
        public void <TryParseDateTimeOffset>g__ParseOffset|22_0(){} // RVA: 0x7FFAC8A979C0
    }

    public class JsonKebabCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FE3C90
    }

    public class JsonKebabCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FE3CE0
    }

    public class JsonNamingPolicy : Object
    {
        public System.Text.Json.JsonNamingPolicy CamelCase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_CamelCase(){} // RVA: 0x7FFAC8A95480
        public void ConvertName(){} // RVA: 0x7FFAC2C58F40
        public void .cctor(){} // RVA: 0x7FFAC8A954E0
    }

    public class JsonProperty : ValueType
    {
        public System.Text.Json.JsonElement Value; // 0x10
        public string _name; // 0x20

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC32C0590
        public void get__name(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC60EFA60
        public void get_Name(){} // RVA: 0x7FFAC8AA54B0
        public void EscapedNameEquals(){} // RVA: 0x7FFAC8AA5530
        public void ToString(){} // RVA: 0x7FFAC8AA55C0
    }

    public class JsonPropertyDictionary`1 : Object
    {
        public System.Collections.Generic.Dictionary`2<string,T> List;
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<string,T>> Count;
        public System.StringComparer Keys;
        public bool Values;
        public KeyCollection<T> IsReadOnly;
        public ValueCollection<T> Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C71610 | overloaded x2
        public void get_List(){} // RVA: 0x7FFAC2C58E90
        public void Add(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryAdd(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void ContainsKey(){} // RVA: 0x7FFAC2C59F60
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void TryGetValue(){} // RVA: 0x7FFAC2C5D200
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void SetValue(){} // RVA: 0x7FFAC2E8DC40
        public void AddValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryAddValue(){} // RVA: 0x7FFAC2E8DC40
        public void CreateDictionaryIfThresholdMet(){} // RVA: 0x7FFAC2C70980
        public void ContainsValue(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsProperty(){} // RVA: 0x7FFAC2C59F60
        public void FindValueIndex(){} // RVA: 0x7FFAC2C5E6B0
        public void TryGetPropertyValue(){} // RVA: 0x7FFAC2C5D200
        public void TryRemoveProperty(){} // RVA: 0x7FFAC2C5D200
        public void GetKeyCollection(){} // RVA: 0x7FFAC2C58E90
        public void GetValueCollection(){} // RVA: 0x7FFAC2C58E90
    }

    public class JsonReaderException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AA7100 | overloaded x2
    }

    public class JsonReaderHelper : Object
    {
        public string SpecialCharacters;
        public System.Text.UTF8Encoding s_utf8Encoding;
        public ulong XorPowerOfTwoToHighByte;

        // ── Methods ──
        public void ContainsSpecialCharacters(){} // RVA: 0x7FFAC8FF7020
        public void CountNewLines(){} // RVA: 0x7FFAC8FF70E0
        public void ToValueKind(){} // RVA: 0x7FFAC8AA7210
        public void IsTokenTypePrimitive(){} // RVA: 0x7FFAC8AA7270
        public void IsHexDigit(){} // RVA: 0x7FFAC8FF7290
        public void TryGetEscapedDateTime(){} // RVA: 0x7FFAC8FF72C0
        public void TryGetEscapedDateTimeOffset(){} // RVA: 0x7FFAC8FF74E0
        public void TryGetEscapedGuid(){} // RVA: 0x7FFAC8FF7710
        public void TryGetFloatingPointConstant(){} // RVA: 0x7FFAC8FF7C70 | overloaded x2
        public void TryGetUnescapedBase64Bytes(){} // RVA: 0x7FFAC8FF7F30
        public void GetUnescapedString(){} // RVA: 0x7FFAC8FF83B0
        public void GetUnescapedSpan(){} // RVA: 0x7FFAC8FF86F0
        public void UnescapeAndCompare(){} // RVA: 0x7FFAC8FF8E20 | overloaded x2
        public void TryDecodeBase64InPlace(){} // RVA: 0x7FFAC8FF9400
        public void TryDecodeBase64(){} // RVA: 0x7FFAC8FF95B0
        public void TranscodeHelper(){} // RVA: 0x7FFAC8FF9BB0 | overloaded x2
        public void ValidateUtf8(){} // RVA: 0x7FFAC8FF9DA0
        public void GetUtf8ByteCount(){} // RVA: 0x7FFAC8FF9EE0
        public void GetUtf8FromText(){} // RVA: 0x7FFAC8FFA020
        public void GetTextFromUtf8(){} // RVA: 0x7FFAC8FFA1F0
        public void Unescape(){} // RVA: 0x7FFAC8FFA480 | overloaded x2
        public void TryUnescape(){} // RVA: 0x7FFAC8FFA5F0 | overloaded x2
        public void TryEncodeToUtf8Bytes(){} // RVA: 0x7FFAC8FFB000
        public void IndexOfQuoteOrAnyControlOrBackSlash(){} // RVA: 0x7FFAC8FFB1A0
        public void LocateFirstFoundByte(){} // RVA: 0x7FFAC8A584F0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8FFB610
    }

    public class JsonReaderOptions : ValueType
    {
        public int CommentHandling; // 0x10
        public 0x6B21D2F0 MaxDepth; // 0x14
        public bool AllowTrailingCommas; // 0x15

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x7FFAC4A0B160
        public void set_CommentHandling(){} // RVA: 0x7FFAC8AAB310
        public void get_MaxDepth(){} // RVA: 0x7FFAC4420210
        public void set_MaxDepth(){} // RVA: 0x7FFAC8AAB360
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFAC4A0B150
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFAC3B9B950
    }

    public class JsonReaderState : ValueType
    {
        public long Options; // 0x10
        public long _bytePositionInLine; // 0x18
        public bool _inObject; // 0x20
        public bool _isNotPrimitive; // 0x21
        public bool _stringHasEscaping; // 0x22
        public bool _trailingCommaBeforeComment; // 0x23
        public 0x6B21D6B8 _tokenType; // 0x24
        public 0x6B21D6B8 _previousTokenType; // 0x25
        public System.Text.Json.JsonReaderOptions _readerOptions; // 0x28
        public System.Text.Json.BitStack _bitStack; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AAB3B0
        public void get_Options(){} // RVA: 0x7FFAC2F247C0
    }

    public class JsonSeparatorNamingPolicy : JsonNamingPolicy
    {
        public bool _lowercase; // 0x10
        public char _separator; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FE3D30
        public void ConvertName(){} // RVA: 0x7FFAC8FE3DA0
        public void ConvertNameCore(){} // RVA: 0x7FFAC8FE3E60
        public void <ConvertNameCore>g__WriteChar|4_0(){} // RVA: 0x7FFAC8FE4580
        public void <ConvertNameCore>g__ExpandBuffer|4_1(){} // RVA: 0x7FFAC8FE4600
    }

    public class JsonSerializer : Object
    {
        public string IsReflectionEnabledByDefault;
        public string SerializationRequiresDynamicCodeMessage;
        public bool <IsReflectionEnabledByDefault>k__BackingField;
        public string IdPropertyName;
        public string RefPropertyName;
        public string TypePropertyName;
        public string ValuesPropertyName;
        public byte[] s_idPropertyName; // 0x8
        public byte[] s_refPropertyName; // 0x10
        public byte[] s_typePropertyName; // 0x18
        public byte[] s_valuesPropertyName; // 0x20
        public System.Text.Json.JsonEncodedText s_metadataId; // 0x28
        public System.Text.Json.JsonEncodedText s_metadataRef; // 0x38
        public System.Text.Json.JsonEncodedText s_metadataType; // 0x48
        public System.Text.Json.JsonEncodedText s_metadataValues; // 0x58
        public float FlushThreshold;

        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFAC903D120 | overloaded x40
        public void ReadFromNode(){} // RVA: 0x7FFAC2E8DC40
        public void ReadFromNodeAsObject(){} // RVA: 0x7FFAC9038640
        public void SerializeToDocument(){} // RVA: 0x7FFAC9038AB0 | overloaded x5
        public void WriteDocument(){} // RVA: 0x7FFAC2C58FF0
        public void WriteDocumentAsObject(){} // RVA: 0x7FFAC9038C20
        public void SerializeToElement(){} // RVA: 0x7FFAC9038F90 | overloaded x5
        public void WriteElement(){} // RVA: 0x7FFAC2E8DC40
        public void WriteElementAsObject(){} // RVA: 0x7FFAC9039120
        public void SerializeToNode(){} // RVA: 0x7FFAC90394C0 | overloaded x5
        public void WriteNode(){} // RVA: 0x7FFAC2C58FF0
        public void WriteNodeAsObject(){} // RVA: 0x7FFAC9039630
        public void get_IsReflectionEnabledByDefault(){} // RVA: 0x7FFAC90397F0
        public void GetTypeInfo(){} // RVA: 0x7FFAC9039A50 | overloaded x3
        public void ValidateInputType(){} // RVA: 0x7FFAC9039AD0
        public void IsValidNumberHandlingValue(){} // RVA: 0x7FFAC9039B60
        public void IsValidCreationHandlingValue(){} // RVA: 0x7FFAC9039B70
        public void IsValidUnmappedMemberHandlingValue(){} // RVA: 0x7FFAC9039B70
        public void UnboxOnRead(){} // RVA: 0x7FFAC2E8DC40
        public void UnboxOnWrite(){} // RVA: 0x7FFAC2E8DC40
        public void TryReadMetadata(){} // RVA: 0x7FFAC9039B80
        public void IsMetadataPropertyName(){} // RVA: 0x7FFAC903A570
        public void GetMetadataPropertyName(){} // RVA: 0x7FFAC903A6D0
        public void TryHandleReferenceFromJsonElement(){} // RVA: 0x7FFAC903A990
        public void TryHandleReferenceFromJsonNode(){} // RVA: 0x7FFAC903B040
        public void ValidateMetadataForObjectConverter(){} // RVA: 0x7FFAC903B560
        public void ValidateMetadataForArrayConverter(){} // RVA: 0x7FFAC903B5F0
        public void ResolveReferenceId(){} // RVA: 0x7FFAC2E8DC40
        public void LookupProperty(){} // RVA: 0x7FFAC903B680
        public void GetPropertyName(){} // RVA: 0x7FFAC903B900
        public void CreateExtensionDataProperty(){} // RVA: 0x7FFAC903BA50
        public void ReadFromSpan(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ReadFromSpanAsObject(){} // RVA: 0x7FFAC903CC80 | overloaded x2
        public void DeserializeAsync(){} // RVA: 0x7FFAC903C350 | overloaded x5
        public void DeserializeAsyncEnumerable(){} // RVA: 0x7FFAC2C6A9B0 | overloaded x2
        public void DeserializeAsyncEnumerableCore(){} // RVA: 0x7FFAC2C6A9B0
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAsObject(){} // RVA: 0x7FFAC903D240
        public void GetReaderScopedToNextValue(){} // RVA: 0x7FFAC903D530
        public void SerializeToUtf8Bytes(){} // RVA: 0x7FFAC903DF80 | overloaded x5
        public void WriteBytes(){} // RVA: 0x7FFAC2C58FF0
        public void WriteBytesAsObject(){} // RVA: 0x7FFAC903E0F0
        public void WriteMetadataForObject(){} // RVA: 0x7FFAC903E2B0
        public void WriteMetadataForCollection(){} // RVA: 0x7FFAC903E660
        public void TryGetReferenceForValue(){} // RVA: 0x7FFAC903E720
        public void SerializeAsync(){} // RVA: 0x7FFAC903EDA0 | overloaded x5
        public void Serialize(){} // RVA: 0x7FFAC903F7B0 | overloaded x15
        public void WriteString(){} // RVA: 0x7FFAC2C58FF0
        public void WriteStringAsObject(){} // RVA: 0x7FFAC903F410
        public void .cctor(){} // RVA: 0x7FFAC903F960
        public void <UnboxOnRead>g__ThrowUnableToCastValue|50_0(){} // RVA: 0x7FFAC2C70A10
        public void <TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(){} // RVA: 0x7FFAC903FF40
        public void <DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerable|90_0(){} // RVA: 0x7FFAC2C6A9B0
        public void <DeserializeAsyncEnumerableCore>g__CreateQueueTypeInfo|90_1(){} // RVA: 0x7FFAC2C58F80
    }

    public class JsonSerializerOptions : Object
    {
        public CachingContext CacheContext; // 0x10
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo ObjectTypeInfo; // 0x18
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo Converters; // 0x20
        public int Default;
        public int TypeInfoResolver;
        public System.Text.Json.JsonSerializerOptions TypeInfoResolverChain;
        public System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver AllowTrailingCommas; // 0x28
        public System.Text.Json.JsonNamingPolicy DefaultBufferSize; // 0x30
        public System.Text.Json.JsonNamingPolicy Encoder; // 0x38
        public 0x6B1D4B78 DictionaryKeyPolicy; // 0x40
        public System.Text.Json.Serialization.ReferenceHandler IgnoreNullValues; // 0x48
        public System.Text.Encodings.Web.JavaScriptEncoder DefaultIgnoreCondition; // 0x50
        public ConverterList NumberHandling; // 0x58
        public 0x6B1D6E30 PreferredObjectCreationHandling; // 0x60
        public 0x6B1D6EE0 IgnoreReadOnlyProperties; // 0x64
        public 0x6B1D6F38 IgnoreReadOnlyFields; // 0x68
        public 0x6B1D70F0 IncludeFields; // 0x6C
        public 0x6B1D6F90 MaxDepth; // 0x70
        public int EffectiveMaxDepth; // 0x74
        public int PropertyNamingPolicy; // 0x78
        public bool PropertyNameCaseInsensitive; // 0x7C
        public bool ReadCommentHandling; // 0x7D
        public bool UnknownTypeHandling; // 0x7E
        public bool UnmappedMemberHandling; // 0x7F
        public bool WriteIndented; // 0x80
        public bool ReferenceHandler; // 0x81
        public bool CanUseFastPathSerializationLogic; // 0x82
        public OptionsBoundJsonTypeInfoResolverChain IsReadOnly; // 0x88
        public int DebuggerDisplay; // 0x90
        public System.Nullable`1<bool> _canUseFastPathSerializationLogic; // 0x94
        public 0x6B1D8010 ReferenceHandlingStrategy; // 0x98
        public bool _isReadOnly; // 0x9C
        public bool _isConfiguredForJsonSerializer; // 0x9D
        public System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver _effectiveJsonTypeInfoResolver; // 0xA0

        // ── Methods ──
        public void get_CacheContext(){} // RVA: 0x7FFAC9040A20
        public void GetTypeInfo(){} // RVA: 0x7FFAC9040AD0
        public void TryGetTypeInfo(){} // RVA: 0x7FFAC9040BB0
        public void GetTypeInfoInternal(){} // RVA: 0x7FFAC9040CE0
        public void TryGetTypeInfoCached(){} // RVA: 0x7FFAC9040ED0
        public void GetTypeInfoForRootType(){} // RVA: 0x7FFAC90410D0
        public void TryGetPolymorphicTypeInfoForRootType(){} // RVA: 0x7FFAC90411F0
        public void get_ObjectTypeInfo(){} // RVA: 0x7FFAC90413F0
        public void ClearCaches(){} // RVA: 0x7FFAC90414F0
        public void get_Converters(){} // RVA: 0x7FFAC9041600
        public void GetConverter(){} // RVA: 0x7FFAC90416B0
        public void GetConverterInternal(){} // RVA: 0x7FFAC9041760
        public void GetConverterFromList(){} // RVA: 0x7FFAC90417E0
        public void ExpandConverterFactory(){} // RVA: 0x7FFAC9041900
        public void CheckConverterNullabilityIsSameAsPropertyType(){} // RVA: 0x7FFAC90419B0
        public void get_Default(){} // RVA: 0x7FFAC9041A80
        public void .ctor(){} // RVA: 0x7FFAC9041E40 | overloaded x3
        public void TrackOptionsInstance(){} // RVA: 0x7FFAC9041FB0
        public void AddContext(){} // RVA: 0x7FFAC2C70980
        public void get_TypeInfoResolver(){} // RVA: 0x7FFAC2F4F130
        public void set_TypeInfoResolver(){} // RVA: 0x7FFAC9042070
        public void get_TypeInfoResolverChain(){} // RVA: 0x7FFAC90421D0
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFAC33CFDF0
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFAC9042300
        public void get_DefaultBufferSize(){} // RVA: 0x7FFAC43D9E20
        public void set_DefaultBufferSize(){} // RVA: 0x7FFAC9042370
        public void get_Encoder(){} // RVA: 0x7FFAC2FC20E0
        public void set_Encoder(){} // RVA: 0x7FFAC9042440
        public void get_DictionaryKeyPolicy(){} // RVA: 0x7FFAC31D95E0
        public void set_DictionaryKeyPolicy(){} // RVA: 0x7FFAC9042500
        public void get_IgnoreNullValues(){} // RVA: 0x7FFAC33CAD30
        public void set_IgnoreNullValues(){} // RVA: 0x7FFAC90425C0
        public void get_DefaultIgnoreCondition(){} // RVA: 0x7FFAC3138C20
        public void set_DefaultIgnoreCondition(){} // RVA: 0x7FFAC90426A0
        public void get_NumberHandling(){} // RVA: 0x7FFAC3138CA0
        public void set_NumberHandling(){} // RVA: 0x7FFAC90427E0
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x7FFAC47BAB50
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x7FFAC90428D0
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x7FFAC33D2830
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x7FFAC90429C0
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x7FFAC33CAD40
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x7FFAC9042A30
        public void get_IncludeFields(){} // RVA: 0x7FFAC313E620
        public void set_IncludeFields(){} // RVA: 0x7FFAC9042AA0
        public void get_MaxDepth(){} // RVA: 0x7FFAC4596EF0
        public void set_MaxDepth(){} // RVA: 0x7FFAC9042B10
        public void get_EffectiveMaxDepth(){} // RVA: 0x7FFAC3220660
        public void set_EffectiveMaxDepth(){} // RVA: 0x7FFAC34D2750
        public void get_PropertyNamingPolicy(){} // RVA: 0x7FFAC31D0140
        public void set_PropertyNamingPolicy(){} // RVA: 0x7FFAC9042BC0
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFAC313DE70
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFAC9042C80
        public void get_ReadCommentHandling(){} // RVA: 0x7FFAC2FDCC00
        public void set_ReadCommentHandling(){} // RVA: 0x7FFAC9042CF0
        public void get_UnknownTypeHandling(){} // RVA: 0x7FFAC47BAB70
        public void set_UnknownTypeHandling(){} // RVA: 0x7FFAC9042DD0
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFAC3B99E80
        public void set_UnmappedMemberHandling(){} // RVA: 0x7FFAC9042E40
        public void get_WriteIndented(){} // RVA: 0x7FFAC3BDEE90
        public void set_WriteIndented(){} // RVA: 0x7FFAC9042EB0
        public void get_ReferenceHandler(){} // RVA: 0x7FFAC2F9C730
        public void set_ReferenceHandler(){} // RVA: 0x7FFAC9042F20
        public void get_CanUseFastPathSerializationLogic(){} // RVA: 0x7FFAC9043000
        public void get_IsReadOnly(){} // RVA: 0x7FFAC90430C0
        public void MakeReadOnly(){} // RVA: 0x7FFAC9043100 | overloaded x2
        public void ConfigureForJsonSerializer(){} // RVA: 0x7FFAC9043150
        public void GetTypeInfoNoCaching(){} // RVA: 0x7FFAC9043580
        public void GetDocumentOptions(){} // RVA: 0x7FFAC90437C0
        public void GetNodeOptions(){} // RVA: 0x7FFAC313DE70
        public void GetReaderOptions(){} // RVA: 0x7FFAC90438A0
        public void GetWriterOptions(){} // RVA: 0x7FFAC9043950
        public void VerifyMutable(){} // RVA: 0x7FFAC9043A20
        public void GetOrCreateDefaultOptionsInstance(){} // RVA: 0x7FFAC9043A80
        public void get_DebuggerDisplay(){} // RVA: 0x7FFAC9043C50
    }

    public class JsonSnakeCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FE48D0
    }

    public class JsonSnakeCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FE4920
    }

    public class JsonWriterHelper : Object
    {
        public System.Text.UTF8Encoding AllowList;
        public System.Buffers.StandardFormat s_dateTimeStandardFormat; // 0x8
        public int LastAsciiCharacter;
        public System.Buffers.StandardFormat s_hexStandardFormat; // 0xA

        // ── Methods ──
        public void WriteIndentation(){} // RVA: 0x7FFAC904A8C0
        public void ValidateProperty(){} // RVA: 0x7FFAC904AAB0 | overloaded x2
        public void ValidateValue(){} // RVA: 0x7FFAC904AB00 | overloaded x2
        public void ValidateDouble(){} // RVA: 0x7FFAC904AA40
        public void ValidateSingle(){} // RVA: 0x7FFAC904AA80
        public void ValidatePropertyAndValue(){} // RVA: 0x7FFAC904ACF0 | overloaded x4
        public void ValidatePropertyNameLength(){} // RVA: 0x7FFAC904ADC0 | overloaded x2
        public void ValidateNumber(){} // RVA: 0x7FFAC904AE10
        public void IsValidUtf8String(){} // RVA: 0x7FFAC904B250
        public void ToUtf8(){} // RVA: 0x7FFAC904B360
        public void WriteDateTimeTrimmed(){} // RVA: 0x7FFAC904B530
        public void WriteDateTimeOffsetTrimmed(){} // RVA: 0x7FFAC904B780
        public void TrimDateTimeOffset(){} // RVA: 0x7FFAC904B9D0
        public void get_AllowList(){} // RVA: 0x7FFAC904BB80
        public void NeedsEscaping(){} // RVA: 0x7FFAC904BD70 | overloaded x3
        public void NeedsEscapingNoBoundsCheck(){} // RVA: 0x7FFAC904BC80
        public void GetMaxEscapedLength(){} // RVA: 0x7FFAC8AC8440
        public void EscapeString(){} // RVA: 0x7FFAC904C830 | overloaded x4
        public void EscapeNextBytes(){} // RVA: 0x7FFAC904C440
        public void IsAsciiValue(){} // RVA: 0x7FFAC850EDF0 | overloaded x2
        public void EscapeNextChars(){} // RVA: 0x7FFAC904CD10
        public void WriteHex(){} // RVA: 0x7FFAC904CFE0
        public void .cctor(){} // RVA: 0x7FFAC904D0A0
    }

    public class JsonWriterOptions : ValueType
    {
        public int Encoder; // 0x10
        public System.Text.Encodings.Web.JavaScriptEncoder Indented; // 0x18

        // ── Methods ──
        public void get_Encoder(){} // RVA: 0x7FFAC4420220
        public void set_Encoder(){} // RVA: 0x7FFAC4420240
        public void get_Indented(){} // RVA: 0x7FFAC8908690
        public void set_Indented(){} // RVA: 0x7FFAC8AC9EC0
        public void get_SkipValidation(){} // RVA: 0x7FFAC89086A0
        public void set_SkipValidation(){} // RVA: 0x7FFAC8AC9EE0
        public void get_IndentedOrNotSkipValidation(){} // RVA: 0x7FFAC8AC9F00
    }

    public class PooledByteBufferWriter : Object
    {
        public byte[] WrittenMemory; // 0x10
        public int _index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A8DE60
        public void get_WrittenMemory(){} // RVA: 0x7FFAC8A8DF20
        public void ClearHelper(){} // RVA: 0x7FFAC8A8E000
        public void Dispose(){} // RVA: 0x7FFAC8A8E110
        public void Advance(){} // RVA: 0x7FFAC8A8E2D0
        public void GetMemory(){} // RVA: 0x7FFAC8A8E2E0
        public void CheckAndResizeBuffer(){} // RVA: 0x7FFAC8A8E400
    }

    public class ReadStack : ValueType
    {
        public char[] IsContinuation;
        public System.Text.Json.ReadStackFrame Current; // 0x10
        public System.Text.Json.ReadStackFrame[] _stack; // 0x88
        public int _count; // 0x90
        public int _continuationCount; // 0x94
        public System.Collections.Generic.List`1<System.Text.Json.ArgumentState> _ctorArgStateCache; // 0x98
        public long BytesConsumed; // 0xA0
        public bool ReadAhead; // 0xA8
        public System.Text.Json.Serialization.ReferenceResolver ReferenceResolver; // 0xB0
        public bool SupportContinuation; // 0xB8
        public bool UseFastPath; // 0xB9

        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x7FFAC8AC4110
        public void EnsurePushCapacity(){} // RVA: 0x7FFAC8AC4120
        public void Initialize(){} // RVA: 0x7FFAC8AC4290 | overloaded x2
        public void Push(){} // RVA: 0x7FFAC8AC4460
        public void Pop(){} // RVA: 0x7FFAC8AC48D0
        public void JsonPath(){} // RVA: 0x7FFAC8AC4C00
        public void SetConstructorArgumentState(){} // RVA: 0x7FFAC8AC4DA0
        public void .cctor(){} // RVA: 0x7FFAC8AC5010
        public void <JsonPath>g__AppendStackFrame|18_0(){} // RVA: 0x7FFAC8AC50F0
        public void <JsonPath>g__GetCount|18_1(){} // RVA: 0x7FFAC8AC5560
        public void <JsonPath>g__AppendPropertyName|18_2(){} // RVA: 0x7FFAC8AC56B0
        public void <JsonPath>g__GetPropertyName|18_3(){} // RVA: 0x7FFAC8AC57C0
    }

    public class ReadStackFrame : ValueType
    {
        public System.Text.Json.Serialization.Metadata.JsonPropertyInfo JsonPropertyInfo; // 0x10
        public 0x6B21DD98 PropertyState; // 0x18
        public bool UseExtensionProperty; // 0x19
        public byte[] JsonPropertyName; // 0x20
        public string JsonPropertyNameAsString; // 0x28
        public object DictionaryKey; // 0x30
        public int OriginalDepth; // 0x38
        public 0x6B21D6B8 OriginalTokenType; // 0x3C
        public object ReturnValue; // 0x40
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo JsonTypeInfo; // 0x48
        public 0x6B21DD40 ObjectState; // 0x50
        public System.Text.Json.Serialization.Converters.LargeJsonObjectExtensionDataSerializationState LargeJsonObjectExtensionDataSerializationState; // 0x58
        public bool ValidateEndTokenOnArray; // 0x60
        public int PropertyIndex; // 0x64
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.Metadata.PropertyRef> PropertyRefCache; // 0x68
        public int CtorArgumentStateIndex; // 0x70
        public System.Text.Json.ArgumentState CtorArgumentState; // 0x78
        public System.Nullable`1<0x6B21E630> NumberHandling; // 0x80

        // ── Methods ──
        public void EndConstructorParameter(){} // RVA: 0x7FFAC8AC5930
        public void EndProperty(){} // RVA: 0x7FFAC8AC5A00
        public void EndElement(){} // RVA: 0x7FFAC8AC5B10
        public void IsProcessingDictionary(){} // RVA: 0x7FFAC8AC5B70
        public void IsProcessingEnumerable(){} // RVA: 0x7FFAC8AC5BA0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(){} // RVA: 0x7FFAC8A8E740
        public void GetArgumentOutOfRangeException_MaxDepthMustBePositive(){} // RVA: 0x7FFAC8A8E7E0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFAC8A8E890
        public void GetArgumentOutOfRangeException_CommentEnumMustBeInRange(){} // RVA: 0x7FFAC8A8E900
        public void GetArgumentException(){} // RVA: 0x7FFAC8A8E9B0
        public void ThrowArgumentException(){} // RVA: 0x7FFAC8A8EBE0 | overloaded x2
        public void ThrowArgumentException_PropertyNameTooLarge(){} // RVA: 0x7FFAC8A8EA40
        public void ThrowArgumentException_ValueTooLarge(){} // RVA: 0x7FFAC8A8EAC0
        public void ThrowArgumentException_ValueNotSupported(){} // RVA: 0x7FFAC8A8EB40
        public void ThrowInvalidOperationException_NeedLargerSpan(){} // RVA: 0x7FFAC8A8EB90
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFAC8A90B60 | overloaded x3
        public void GetInvalidOperationException(){} // RVA: 0x7FFAC8A911F0 | overloaded x4
        public void ThrowInvalidOperationOrArgumentException(){} // RVA: 0x7FFAC8A8EE30
        public void GetInvalidOperationException_ExpectedArray(){} // RVA: 0x7FFAC8A8EF30
        public void GetInvalidOperationException_ExpectedObject(){} // RVA: 0x7FFAC8A8EF80
        public void GetInvalidOperationException_ExpectedNumber(){} // RVA: 0x7FFAC8A8EFD0
        public void GetInvalidOperationException_ExpectedBoolean(){} // RVA: 0x7FFAC8A8F020
        public void GetInvalidOperationException_ExpectedString(){} // RVA: 0x7FFAC8A8F070
        public void GetInvalidOperationException_CannotSkipOnPartial(){} // RVA: 0x7FFAC8A8F0C0
        public void GetJsonElementWrongTypeException(){} // RVA: 0x7FFAC8A8F540 | overloaded x4
        public void ThrowJsonReaderException(){} // RVA: 0x7FFAC8A8F640
        public void GetJsonReaderException(){} // RVA: 0x7FFAC8A8F690
        public void IsPrintable(){} // RVA: 0x7FFAC8A8FA40
        public void GetPrintableString(){} // RVA: 0x7FFAC8A8FA50
        public void GetResourceString(){} // RVA: 0x7FFAC8A91340 | overloaded x2
        public void ThrowArgumentException_InvalidUTF8(){} // RVA: 0x7FFAC8A90B90
        public void ThrowArgumentException_InvalidUTF16(){} // RVA: 0x7FFAC8A90D80
        public void ThrowInvalidOperationException_ReadInvalidUTF16(){} // RVA: 0x7FFAC8A90EE0 | overloaded x2
        public void GetInvalidOperationException_ReadInvalidUTF8(){} // RVA: 0x7FFAC8A90F30
        public void GetArgumentException_ReadInvalidUTF16(){} // RVA: 0x7FFAC8A91060
        public void ThrowOutOfMemoryException(){} // RVA: 0x7FFAC8A912A0
        public void GetFormatException(){} // RVA: 0x7FFAC8A91E50 | overloaded x3
        public void GetInvalidOperationException_ExpectedChar(){} // RVA: 0x7FFAC8A921B0
        public void ThrowArgumentException_NodeValueNotAllowed(){} // RVA: 0x7FFAC8A92200
        public void ThrowArgumentException_NodeArrayTooSmall(){} // RVA: 0x7FFAC8A92270
        public void ThrowArgumentOutOfRangeException_NodeArrayIndexNegative(){} // RVA: 0x7FFAC8A922E0
        public void ThrowArgumentException_DuplicateKey(){} // RVA: 0x7FFAC8A92350
        public void ThrowInvalidOperationException_NodeAlreadyHasParent(){} // RVA: 0x7FFAC8A923C0
        public void ThrowInvalidOperationException_NodeCycleDetected(){} // RVA: 0x7FFAC8A92430
        public void ThrowNotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x7FFAC8A924A0
        public void NotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x7FFAC8A924D0
        public void ThrowNotSupportedException_SerializationNotSupported(){} // RVA: 0x7FFAC8A925B0
        public void ThrowNotSupportedException_TypeRequiresAsyncSerialization(){} // RVA: 0x7FFAC8A92630
        public void ThrowNotSupportedException_ConstructorMaxOf64Parameters(){} // RVA: 0x7FFAC8A926B0
        public void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(){} // RVA: 0x7FFAC8A92730
        public void ThrowJsonException_DeserializeUnableToConvertValue(){} // RVA: 0x7FFAC8A927D0
        public void ThrowInvalidCastException_DeserializeUnableToAssignValue(){} // RVA: 0x7FFAC8A92860
        public void ThrowInvalidOperationException_DeserializeUnableToAssignNull(){} // RVA: 0x7FFAC8A928E0
        public void ThrowJsonException_SerializationConverterRead(){} // RVA: 0x7FFAC8A92960
        public void ThrowJsonException_SerializationConverterWrite(){} // RVA: 0x7FFAC8A929F0
        public void ThrowJsonException_SerializerCycleDetected(){} // RVA: 0x7FFAC8A92A80
        public void ThrowJsonException(){} // RVA: 0x7FFAC8A92B30
        public void ThrowInvalidOperationException_CannotSerializeInvalidType(){} // RVA: 0x7FFAC8A92B90
        public void ThrowInvalidOperationException_SerializationConverterNotCompatible(){} // RVA: 0x7FFAC8A92CB0
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(){} // RVA: 0x7FFAC8A92D30
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x7FFAC8A92E10
        public void ThrowInvalidOperationException_SerializerOptionsImmutable(){} // RVA: 0x7FFAC8A92F00
        public void ThrowInvalidOperationException_SerializerPropertyNameConflict(){} // RVA: 0x7FFAC8A92F80
        public void ThrowInvalidOperationException_SerializerPropertyNameNull(){} // RVA: 0x7FFAC8A93020
        public void ThrowInvalidOperationException_NamingPolicyReturnNull(){} // RVA: 0x7FFAC8A930F0
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(){} // RVA: 0x7FFAC8A93170
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(){} // RVA: 0x7FFAC8A931F0
        public void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(){} // RVA: 0x7FFAC8A93270
        public void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(){} // RVA: 0x7FFAC8A933B0
        public void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x7FFAC8A93430
        public void ThrowInvalidOperationException_JsonIncludeOnNonPublicInvalid(){} // RVA: 0x7FFAC8A934E0
        public void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x7FFAC8A93560
        public void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(){} // RVA: 0x7FFAC8A935E0
        public void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(){} // RVA: 0x7FFAC8A936A0
        public void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotHonored(){} // RVA: 0x7FFAC8A93760
        public void ReThrowWithPath(){} // RVA: 0x7FFAC8A93840
        public void AddJsonExceptionInformation(){} // RVA: 0x7FFAC8A938B0
        public void ThrowInvalidOperationException_SerializationDuplicateAttribute(){} // RVA: 0x7FFAC8A93AF0
        public void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x7FFAC8A93C60
        public void ThrowNotSupportedException(){} // RVA: 0x7FFAC8A940E0 | overloaded x2
        public void ThrowNotSupportedException_DeserializeNoConstructor(){} // RVA: 0x7FFAC8A942B0
        public void ThrowNotSupportedException_CannotPopulateCollection(){} // RVA: 0x7FFAC8A94390
        public void ThrowJsonException_MetadataValuesInvalidToken(){} // RVA: 0x7FFAC8A94430
        public void ThrowJsonException_MetadataReferenceNotFound(){} // RVA: 0x7FFAC8A944B0
        public void ThrowJsonException_MetadataValueWasNotString(){} // RVA: 0x7FFAC8A94590 | overloaded x2
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x7FFAC8A94660 | overloaded x2
        public void ThrowJsonException_MetadataIdIsNotFirstProperty(){} // RVA: 0x7FFAC8A946A0
        public void ThrowJsonException_MetadataMissingIdBeforeValues(){} // RVA: 0x7FFAC8A94720
        public void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x7FFAC8A947A0
        public void ThrowJsonException_MetadataDuplicateIdFound(){} // RVA: 0x7FFAC8A948D0
        public void ThrowJsonException_MetadataInvalidReferenceToValueType(){} // RVA: 0x7FFAC8A94930
        public void ThrowJsonException_MetadataPreservedArrayInvalidProperty(){} // RVA: 0x7FFAC8A94990
        public void ThrowJsonException_MetadataPreservedArrayValuesNotFound(){} // RVA: 0x7FFAC8A94B50
        public void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(){} // RVA: 0x7FFAC8A94BF0
        public void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x7FFAC8A94C50
        public void ThrowUnexpectedMetadataException(){} // RVA: 0x7FFAC8A94CE0
        public void ThrowInvalidOperationException_JsonSerializerOptionsAlreadyBoundToContext(){} // RVA: 0x7FFAC8A94E20
        public void ThrowNotSupportedException_BuiltInConvertersNotRooted(){} // RVA: 0x7FFAC8A94EB0
        public void ThrowNotSupportedException_NoMetadataForType(){} // RVA: 0x7FFAC8A94F30
        public void ThrowInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x7FFAC8A94FB0
        public void ThrowInvalidOperationException_NoMetadataForTypeCtorParams(){} // RVA: 0x7FFAC8A95050
        public void ThrowMissingMemberException_MissingFSharpCoreMember(){} // RVA: 0x7FFAC8A950F0
    }

    public class Utf8JsonReader : ValueType
    {
        public System.ReadOnlySpan`1<byte> IsLastSpan; // 0x10
        public bool OriginalSequence; // 0x28
        public bool OriginalSpan; // 0x29
        public long ValueSpan; // 0x30
        public long BytesConsumed; // 0x38
        public int TokenStartIndex; // 0x40
        public bool CurrentDepth; // 0x44
        public bool IsInArray; // 0x45
        public 0x6B21D6B8 TokenType; // 0x46
        public 0x6B21D6B8 HasValueSequence; // 0x47
        public System.Text.Json.JsonReaderOptions IsFinalBlock; // 0x48
        public System.Text.Json.BitStack ValueSequence; // 0x50
        public long CurrentState; // 0x68
        public bool _isLastSegment; // 0x70
        public bool _stringHasEscaping; // 0x71
        public bool _isMultiSegment; // 0x72
        public bool _trailingCommaBeforeComment; // 0x73
        public System.SequencePosition _nextPosition; // 0x78
        public System.SequencePosition _currentPosition; // 0x88
        public System.Buffers.ReadOnlySequence`1<byte> _sequence; // 0x98
        public System.ReadOnlySpan`1<byte> <ValueSpan>k__BackingField; // 0xB8
        public long <TokenStartIndex>k__BackingField; // 0xD0
        public bool <HasValueSequence>k__BackingField; // 0xD8
        public System.Buffers.ReadOnlySequence`1<byte> <ValueSequence>k__BackingField; // 0xE0

        // ── Methods ──
        public void get_IsLastSpan(){} // RVA: 0x7FFAC8AAB3D0
        public void get_OriginalSequence(){} // RVA: 0x7FFAC8AAB3F0
        public void get_OriginalSpan(){} // RVA: 0x7FFAC8AAB410
        public void get_ValueSpan(){} // RVA: 0x7FFAC519CA20
        public void set_ValueSpan(){} // RVA: 0x7FFAC8AAB4E0
        public void get_BytesConsumed(){} // RVA: 0x7FFAC8AAB550
        public void get_TokenStartIndex(){} // RVA: 0x7FFAC2F8C120
        public void set_TokenStartIndex(){} // RVA: 0x7FFAC45CA280
        public void get_CurrentDepth(){} // RVA: 0x7FFAC8AAB560
        public void get_IsInArray(){} // RVA: 0x7FFAC4878C50
        public void get_TokenType(){} // RVA: 0x7FFAC47394D0
        public void get_HasValueSequence(){} // RVA: 0x7FFAC3D2B010
        public void set_HasValueSequence(){} // RVA: 0x7FFAC3D23EE0
        public void get_IsFinalBlock(){} // RVA: 0x7FFAC2F3C4E0
        public void get_ValueSequence(){} // RVA: 0x7FFAC519CA40
        public void set_ValueSequence(){} // RVA: 0x7FFAC8AAB580
        public void get_CurrentState(){} // RVA: 0x7FFAC8AAB5F0
        public void .ctor(){} // RVA: 0x7FFAC8AAB990 | overloaded x2
        public void Read(){} // RVA: 0x7FFAC8AABA10
        public void Skip(){} // RVA: 0x7FFAC8AABAA0
        public void SkipHelper(){} // RVA: 0x7FFAC8AABAE0
        public void TrySkip(){} // RVA: 0x7FFAC8AABC30
        public void TrySkipHelper(){} // RVA: 0x7FFAC8AABC60
        public void StartObject(){} // RVA: 0x7FFAC8AABF30
        public void EndObject(){} // RVA: 0x7FFAC8AAC090
        public void StartArray(){} // RVA: 0x7FFAC8AAC210
        public void EndArray(){} // RVA: 0x7FFAC8AAC370
        public void UpdateBitStackOnEndToken(){} // RVA: 0x7FFAC8AAC4F0
        public void ReadSingleSegment(){} // RVA: 0x7FFAC8AAC550
        public void HasMoreData(){} // RVA: 0x7FFAC8AAC940 | overloaded x2
        public void ReadFirstToken(){} // RVA: 0x7FFAC8AACA00
        public void SkipWhiteSpace(){} // RVA: 0x7FFAC8AACCD0
        public void ConsumeValue(){} // RVA: 0x7FFAC8AACDA0
        public void ConsumeLiteral(){} // RVA: 0x7FFAC8AAD330
        public void CheckLiteral(){} // RVA: 0x7FFAC8AAD630
        public void ThrowInvalidLiteral(){} // RVA: 0x7FFAC8AAD770
        public void ConsumeNumber(){} // RVA: 0x7FFAC8AAD800
        public void ConsumePropertyName(){} // RVA: 0x7FFAC8AAD960
        public void ConsumeString(){} // RVA: 0x7FFAC8AADAA0
        public void ConsumeStringAndValidate(){} // RVA: 0x7FFAC8AADE10
        public void ValidateHexDigits(){} // RVA: 0x7FFAC8AAE1E0
        public void TryGetNumber(){} // RVA: 0x7FFAC8AAE360
        public void ConsumeNegativeSign(){} // RVA: 0x7FFAC8AAE6C0
        public void ConsumeZero(){} // RVA: 0x7FFAC8AAE8B0
        public void ConsumeIntegerDigits(){} // RVA: 0x7FFAC8AAEB30
        public void ConsumeDecimalDigits(){} // RVA: 0x7FFAC8AAED00
        public void ConsumeSign(){} // RVA: 0x7FFAC8AAEEE0
        public void ConsumeNextTokenOrRollback(){} // RVA: 0x7FFAC8AAF150
        public void ConsumeNextToken(){} // RVA: 0x7FFAC8AAF1D0
        public void ConsumeNextTokenFromLastNonCommentToken(){} // RVA: 0x7FFAC8AAF5A0
        public void SkipAllComments(){} // RVA: 0x7FFAC8AAFBF0 | overloaded x2
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkipped(){} // RVA: 0x7FFAC8AAFCC0
        public void SkipComment(){} // RVA: 0x7FFAC8AB0120
        public void SkipSingleLineComment(){} // RVA: 0x7FFAC8AB0330
        public void FindLineSeparator(){} // RVA: 0x7FFAC8AB04A0
        public void ThrowOnDangerousLineSeparator(){} // RVA: 0x7FFAC8AB06E0
        public void SkipMultiLineComment(){} // RVA: 0x7FFAC8AB07D0
        public void ConsumeComment(){} // RVA: 0x7FFAC8AB0C30
        public void ConsumeSingleLineComment(){} // RVA: 0x7FFAC8AB0E40
        public void ConsumeMultiLineComment(){} // RVA: 0x7FFAC8AB0F70
        public void GetUnescapedSpan(){} // RVA: 0x7FFAC8AB10A0
        public void ReadMultiSegment(){} // RVA: 0x7FFAC8AB1290
        public void ValidateStateAtEndOfData(){} // RVA: 0x7FFAC8AB1610
        public void HasMoreDataMultiSegment(){} // RVA: 0x7FFAC8AB1780 | overloaded x2
        public void GetNextSpan(){} // RVA: 0x7FFAC8AB18A0
        public void ReadFirstTokenMultiSegment(){} // RVA: 0x7FFAC8AB1C40
        public void SkipWhiteSpaceMultiSegment(){} // RVA: 0x7FFAC8AB1EF0
        public void ConsumeValueMultiSegment(){} // RVA: 0x7FFAC8AB1F50
        public void ConsumeLiteralMultiSegment(){} // RVA: 0x7FFAC8AB24E0
        public void CheckLiteralMultiSegment(){} // RVA: 0x7FFAC8AB27E0
        public void FindMismatch(){} // RVA: 0x7FFAC8AB33F0
        public void GetInvalidLiteralMultiSegment(){} // RVA: 0x7FFAC8AB34F0
        public void ConsumeNumberMultiSegment(){} // RVA: 0x7FFAC8AB35A0
        public void ConsumePropertyNameMultiSegment(){} // RVA: 0x7FFAC8AB3700
        public void ConsumeStringMultiSegment(){} // RVA: 0x7FFAC8AB3840
        public void ConsumeStringNextSegment(){} // RVA: 0x7FFAC8AB3BC0
        public void ConsumeStringAndValidateMultiSegment(){} // RVA: 0x7FFAC8AB4680
        public void RollBackState(){} // RVA: 0x7FFAC8AB4E40
        public void TryGetNumberMultiSegment(){} // RVA: 0x7FFAC8AB4EC0
        public void ConsumeNegativeSignMultiSegment(){} // RVA: 0x7FFAC8AB57B0
        public void ConsumeZeroMultiSegment(){} // RVA: 0x7FFAC8AB5A40
        public void ConsumeIntegerDigitsMultiSegment(){} // RVA: 0x7FFAC8AB5D50
        public void ConsumeDecimalDigitsMultiSegment(){} // RVA: 0x7FFAC8AB6080
        public void ConsumeSignMultiSegment(){} // RVA: 0x7FFAC8AB62F0
        public void ConsumeNextTokenOrRollbackMultiSegment(){} // RVA: 0x7FFAC8AB66A0
        public void ConsumeNextTokenMultiSegment(){} // RVA: 0x7FFAC8AB6780
        public void ConsumeNextTokenFromLastNonCommentTokenMultiSegment(){} // RVA: 0x7FFAC8AB6BE0
        public void SkipAllCommentsMultiSegment(){} // RVA: 0x7FFAC8AB72C0 | overloaded x2
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(){} // RVA: 0x7FFAC8AB7390
        public void SkipOrConsumeCommentMultiSegmentWithRollback(){} // RVA: 0x7FFAC8AB78A0
        public void SkipCommentMultiSegment(){} // RVA: 0x7FFAC8AB7D40
        public void SkipSingleLineCommentMultiSegment(){} // RVA: 0x7FFAC8AB80B0
        public void FindLineSeparatorMultiSegment(){} // RVA: 0x7FFAC8AB8290
        public void ThrowOnDangerousLineSeparatorMultiSegment(){} // RVA: 0x7FFAC8AB8670
        public void SkipMultiLineCommentMultiSegment(){} // RVA: 0x7FFAC8AB87E0
        public void CaptureState(){} // RVA: 0x7FFAC8AB8D00
        public void GetString(){} // RVA: 0x7FFAC8AB8D80
        public void GetBoolean(){} // RVA: 0x7FFAC8AB8FB0
        public void GetBytesFromBase64(){} // RVA: 0x7FFAC8AB90B0
        public void GetByte(){} // RVA: 0x7FFAC8AB9110
        public void GetByteWithQuotes(){} // RVA: 0x7FFAC8AB9170
        public void GetSByte(){} // RVA: 0x7FFAC8AB91F0
        public void GetSByteWithQuotes(){} // RVA: 0x7FFAC8AB9250
        public void GetInt16(){} // RVA: 0x7FFAC8AB92E0
        public void GetInt16WithQuotes(){} // RVA: 0x7FFAC8AB9340
        public void GetInt32(){} // RVA: 0x7FFAC8AB93D0
        public void GetInt32WithQuotes(){} // RVA: 0x7FFAC8AB9430
        public void GetInt64(){} // RVA: 0x7FFAC8AB94C0
        public void GetInt64WithQuotes(){} // RVA: 0x7FFAC8AB9520
        public void GetUInt16(){} // RVA: 0x7FFAC8AB95B0
        public void GetUInt16WithQuotes(){} // RVA: 0x7FFAC8AB9610
        public void GetUInt32(){} // RVA: 0x7FFAC8AB96A0
        public void GetUInt32WithQuotes(){} // RVA: 0x7FFAC8AB9700
        public void GetUInt64(){} // RVA: 0x7FFAC8AB9790
        public void GetUInt64WithQuotes(){} // RVA: 0x7FFAC8AB97F0
        public void GetSingle(){} // RVA: 0x7FFAC8AB9880
        public void GetSingleWithQuotes(){} // RVA: 0x7FFAC8AB98E0
        public void GetSingleFloatingPointConstant(){} // RVA: 0x7FFAC8AB9AB0
        public void GetDouble(){} // RVA: 0x7FFAC8AB9B80
        public void GetDoubleWithQuotes(){} // RVA: 0x7FFAC8AB9BE0
        public void GetDoubleFloatingPointConstant(){} // RVA: 0x7FFAC8AB9E70
        public void GetDecimal(){} // RVA: 0x7FFAC8AB9F50
        public void GetDecimalWithQuotes(){} // RVA: 0x7FFAC8AB9FB0
        public void GetDateTime(){} // RVA: 0x7FFAC8ABA020
        public void GetDateTimeNoValidation(){} // RVA: 0x7FFAC8ABA0B0
        public void GetDateTimeOffset(){} // RVA: 0x7FFAC8ABA110
        public void GetDateTimeOffsetNoValidation(){} // RVA: 0x7FFAC8ABA1A0
        public void GetGuid(){} // RVA: 0x7FFAC8ABA200
        public void GetGuidNoValidation(){} // RVA: 0x7FFAC8ABA290
        public void TryGetBytesFromBase64(){} // RVA: 0x7FFAC8ABA2F0
        public void TryGetByte(){} // RVA: 0x7FFAC8ABA520
        public void TryGetByteCore(){} // RVA: 0x7FFAC8ABA650
        public void TryGetSByte(){} // RVA: 0x7FFAC8ABA760
        public void TryGetSByteCore(){} // RVA: 0x7FFAC8ABA890
        public void TryGetInt16(){} // RVA: 0x7FFAC8ABA9A0
        public void TryGetInt16Core(){} // RVA: 0x7FFAC8ABAAD0
        public void TryGetInt32(){} // RVA: 0x7FFAC8ABABE0
        public void TryGetInt32Core(){} // RVA: 0x7FFAC8ABAD10
        public void TryGetInt64(){} // RVA: 0x7FFAC8ABAE20
        public void TryGetInt64Core(){} // RVA: 0x7FFAC8ABAF50
        public void TryGetUInt16(){} // RVA: 0x7FFAC8ABB060
        public void TryGetUInt16Core(){} // RVA: 0x7FFAC8ABB190
        public void TryGetUInt32(){} // RVA: 0x7FFAC8ABB2A0
        public void TryGetUInt32Core(){} // RVA: 0x7FFAC8ABB3D0
        public void TryGetUInt64(){} // RVA: 0x7FFAC8ABB4E0
        public void TryGetUInt64Core(){} // RVA: 0x7FFAC8ABB610
        public void TryGetSingle(){} // RVA: 0x7FFAC8ABB720
        public void TryGetDouble(){} // RVA: 0x7FFAC8ABB910
        public void TryGetDecimal(){} // RVA: 0x7FFAC8ABBB90
        public void TryGetDecimalCore(){} // RVA: 0x7FFAC8ABBCC0
        public void TryGetDateTime(){} // RVA: 0x7FFAC8ABBDA0
        public void TryGetDateTimeCore(){} // RVA: 0x7FFAC8ABBDF0
        public void TryGetDateTimeOffset(){} // RVA: 0x7FFAC8ABC360
        public void TryGetDateTimeOffsetCore(){} // RVA: 0x7FFAC8ABC3B0
        public void TryGetGuid(){} // RVA: 0x7FFAC8ABC920
        public void TryGetGuidCore(){} // RVA: 0x7FFAC8ABC970
    }

    public class Utf8JsonWriter : Object
    {
        public int BytesPending;
        public System.Buffers.IBufferWriter`1<byte> BytesCommitted; // 0x10
        public System.IO.Stream Indentation; // 0x18
        public System.Buffers.ArrayBufferWriter`1<byte> TokenType; // 0x20
        public System.Memory`1<byte> CurrentDepth; // 0x28
        public bool _inObject; // 0x38
        public 0x6B21D6B8 _tokenType; // 0x39
        public System.Text.Json.BitStack _bitStack; // 0x40
        public int _currentDepth; // 0x58
        public System.Text.Json.JsonWriterOptions _options; // 0x60
        public int <BytesPending>k__BackingField; // 0x70
        public long <BytesCommitted>k__BackingField; // 0x78
        public char[] s_singleLineCommentDelimiter; // 0x8

        // ── Methods ──
        public void get_BytesPending(){} // RVA: 0x7FFAC3B99E80
        public void set_BytesPending(){} // RVA: 0x7FFAC30B6520
        public void get_BytesCommitted(){} // RVA: 0x7FFAC30E5600
        public void set_BytesCommitted(){} // RVA: 0x7FFAC8246500
        public void get_Indentation(){} // RVA: 0x7FFAC8AC9F10
        public void get_TokenType(){} // RVA: 0x7FFAC33BCE50
        public void get_CurrentDepth(){} // RVA: 0x7FFAC8AC9F20
        public void .ctor(){} // RVA: 0x7FFAC8ACA060 | overloaded x2
        public void ResetHelper(){} // RVA: 0x7FFAC8ACA340
        public void CheckNotDisposed(){} // RVA: 0x7FFAC8ACA360
        public void Flush(){} // RVA: 0x7FFAC8ACA3D0
        public void Dispose(){} // RVA: 0x7FFAC8ACA5F0
        public void DisposeAsync(){} // RVA: 0x7FFAC8ACA730
        public void FlushAsync(){} // RVA: 0x7FFAC8ACA8C0
        public void WriteStartArray(){} // RVA: 0x7FFAC8ACB5D0 | overloaded x4
        public void WriteStartObject(){} // RVA: 0x7FFAC8ACB6A0 | overloaded x3
        public void WriteStart(){} // RVA: 0x7FFAC8ACAB10
        public void WriteStartMinimized(){} // RVA: 0x7FFAC8ACABD0
        public void WriteStartSlow(){} // RVA: 0x7FFAC8ACACE0
        public void ValidateStart(){} // RVA: 0x7FFAC8ACAD60
        public void WriteStartIndented(){} // RVA: 0x7FFAC8ACADD0
        public void WriteStartHelper(){} // RVA: 0x7FFAC8ACB120
        public void WriteStartByOptions(){} // RVA: 0x7FFAC8ACB950 | overloaded x2
        public void WriteStartEscape(){} // RVA: 0x7FFAC8ACB770
        public void WriteStartEscapeProperty(){} // RVA: 0x7FFAC8ACBA00
        public void WriteEndArray(){} // RVA: 0x7FFAC8ACBE50
        public void WriteEndObject(){} // RVA: 0x7FFAC8ACBE70
        public void WriteEnd(){} // RVA: 0x7FFAC8ACBE90
        public void WriteEndMinimized(){} // RVA: 0x7FFAC8ACBF10
        public void WriteEndSlow(){} // RVA: 0x7FFAC8ACBFF0
        public void ValidateEnd(){} // RVA: 0x7FFAC8ACC050
        public void WriteEndIndented(){} // RVA: 0x7FFAC8ACC130
        public void WriteNewLine(){} // RVA: 0x7FFAC8ACC340
        public void UpdateBitStackOnStart(){} // RVA: 0x7FFAC8ACC420
        public void Grow(){} // RVA: 0x7FFAC8ACC4C0
        public void FirstCallToGetMemory(){} // RVA: 0x7FFAC8ACC710
        public void SetFlagToAddListSeparatorBeforeNextItem(){} // RVA: 0x7FFAC8ACC8C0
        public void WritePropertyName(){} // RVA: 0x7FFAC8ADA140 | overloaded x15
        public void WriteString(){} // RVA: 0x7FFAC8AD70E0 | overloaded x6
        public void WriteStringEscape(){} // RVA: 0x7FFAC8AE0E30 | overloaded x4
        public void WriteStringEscapeProperty(){} // RVA: 0x7FFAC8AD5EB0 | overloaded x3
        public void WriteStringByOptions(){} // RVA: 0x7FFAC8AE0F70 | overloaded x5
        public void WriteStringMinimized(){} // RVA: 0x7FFAC8AE0FE0 | overloaded x5
        public void WriteStringIndented(){} // RVA: 0x7FFAC8AE11F0 | overloaded x5
        public void WriteNumber(){} // RVA: 0x7FFAC8AD9340 | overloaded x9
        public void WriteNumberEscape(){} // RVA: 0x7FFAC8AD9430 | overloaded x4
        public void WriteNumberEscapeProperty(){} // RVA: 0x7FFAC8AD9600 | overloaded x4
        public void WriteNumberByOptions(){} // RVA: 0x7FFAC8AD9A40 | overloaded x4
        public void WriteNumberMinimized(){} // RVA: 0x7FFAC8AD9AB0 | overloaded x4
        public void WriteNumberIndented(){} // RVA: 0x7FFAC8AD9D80 | overloaded x4
        public void ValidatePropertyNameAndDepth(){} // RVA: 0x7FFAC8AD0840
        public void ValidateDepth(){} // RVA: 0x7FFAC8AD08C0
        public void ValidateWritingProperty(){} // RVA: 0x7FFAC8AD0930 | overloaded x2
        public void WritePropertyNameMinimized(){} // RVA: 0x7FFAC8AD0F60 | overloaded x2
        public void WritePropertyNameIndented(){} // RVA: 0x7FFAC8AD1160 | overloaded x2
        public void TranscodeAndWrite(){} // RVA: 0x7FFAC8AD1490
        public void WriteNull(){} // RVA: 0x7FFAC8AD1B30 | overloaded x3
        public void WriteNullSection(){} // RVA: 0x7FFAC8AD1760
        public void WriteLiteralHelper(){} // RVA: 0x7FFAC8AD1980
        public void WriteBoolean(){} // RVA: 0x7FFAC8AD1F00 | overloaded x2
        public void WriteLiteralEscape(){} // RVA: 0x7FFAC8AD20B0
        public void WriteLiteralEscapeProperty(){} // RVA: 0x7FFAC8AD22B0
        public void WriteLiteralByOptions(){} // RVA: 0x7FFAC8ADED60 | overloaded x3
        public void WriteLiteralMinimized(){} // RVA: 0x7FFAC8ADEDD0 | overloaded x3
        public void WriteLiteralSection(){} // RVA: 0x7FFAC8AD2DC0
        public void WriteLiteralIndented(){} // RVA: 0x7FFAC8ADEF70 | overloaded x3
        public void WritePropertyNameSection(){} // RVA: 0x7FFAC8AD4DD0
        public void WritePropertyNameHelper(){} // RVA: 0x7FFAC8AD4EE0
        public void WriteStringByOptionsPropertyName(){} // RVA: 0x7FFAC8AD6320 | overloaded x2
        public void WriteStringMinimizedPropertyName(){} // RVA: 0x7FFAC8AD6390 | overloaded x2
        public void WriteStringIndentedPropertyName(){} // RVA: 0x7FFAC8AD6770 | overloaded x2
        public void WritePropertyNameUnescaped(){} // RVA: 0x7FFAC8AD5DA0
        public void WriteStringPropertyNameSection(){} // RVA: 0x7FFAC8AD65D0
        public void WriteStringHelperEscapeValue(){} // RVA: 0x7FFAC8AD71C0
        public void WriteStringEscapeValueOnly(){} // RVA: 0x7FFAC8AD7420
        public void WriteStringEscapePropertyOrValue(){} // RVA: 0x7FFAC8AD7B80
        public void WriteBase64StringValue(){} // RVA: 0x7FFAC8ADA430
        public void WriteBase64ByOptions(){} // RVA: 0x7FFAC8ADA520
        public void WriteBase64Minimized(){} // RVA: 0x7FFAC8ADA590
        public void WriteBase64Indented(){} // RVA: 0x7FFAC8ADA7A0
        public void WriteStringValue(){} // RVA: 0x7FFAC8AE0C80 | overloaded x7
        public void WriteStringValueMinimized(){} // RVA: 0x7FFAC8ADE0C0 | overloaded x3
        public void WriteStringValueIndented(){} // RVA: 0x7FFAC8ADE2F0 | overloaded x3
        public void WriteNumberValue(){} // RVA: 0x7FFAC8AE19A0 | overloaded x8
        public void WriteNumberValueMinimized(){} // RVA: 0x7FFAC8AE1BC0 | overloaded x6
        public void WriteNumberValueIndented(){} // RVA: 0x7FFAC8AE1DA0 | overloaded x6
        public void WriteNumberValueAsString(){} // RVA: 0x7FFAC8AE2070 | overloaded x5
        public void TryFormatDouble(){} // RVA: 0x7FFAC8ADC4C0
        public void WriteFloatingPointConstant(){} // RVA: 0x7FFAC8ADD850 | overloaded x2
        public void TryFormatSingle(){} // RVA: 0x7FFAC8ADD310
        public void ValidateWritingValue(){} // RVA: 0x7FFAC8ADE5D0
        public void Base64EncodeAndWrite(){} // RVA: 0x7FFAC8ADE640
        public void WriteNullValue(){} // RVA: 0x7FFAC8ADEAC0
        public void WriteBooleanValue(){} // RVA: 0x7FFAC8ADEB90
        public void WriteRawValue(){} // RVA: 0x7FFAC8ADF210
        public void WriteRawValueCore(){} // RVA: 0x7FFAC8ADF2B0
        public void WriteStringEscapeValue(){} // RVA: 0x7FFAC8AE1500 | overloaded x2
        public void WriteNumberValueAsStringUnescaped(){} // RVA: 0x7FFAC8AE1920
        public void .cctor(){} // RVA: 0x7FFAC8AE23B0
    }

    public class Utf8JsonWriterCache : Object
    {
        public ThreadLocalState t_threadLocalState; // 0xFFFF

        // ── Methods ──
        public void RentWriterAndBuffer(){} // RVA: 0x7FFAC90400F0
        public void RentWriter(){} // RVA: 0x7FFAC90404A0
        public void ReturnWriterAndBuffer(){} // RVA: 0x7FFAC9040680
        public void ReturnWriter(){} // RVA: 0x7FFAC9040810
    }

    public class WriteStack : ValueType
    {
        public System.Text.Json.WriteStackFrame IsContinuation; // 0x10
        public System.Text.Json.WriteStackFrame[] _stack; // 0x70
        public int _count; // 0x78
        public int _continuationCount; // 0x7C
        public System.Threading.CancellationToken CancellationToken; // 0x80
        public bool SuppressFlush; // 0x88
        public System.Threading.Tasks.Task PendingTask; // 0x90
        public System.Collections.Generic.List`1<System.IAsyncDisposable> CompletedAsyncDisposables; // 0x98
        public int FlushThreshold; // 0xA0
        public System.Text.Json.Serialization.ReferenceResolver ReferenceResolver; // 0xA8
        public bool SupportContinuation; // 0xB0
        public string BoxedStructReferenceId; // 0xB8

        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x7FFAC8AC5BD0
        public void EnsurePushCapacity(){} // RVA: 0x7FFAC8AC5BE0
        public void Initialize(){} // RVA: 0x7FFAC8AC5CF0 | overloaded x2
        public void Push(){} // RVA: 0x7FFAC8AC5ED0
        public void Pop(){} // RVA: 0x7FFAC8AC6180
        public void AddCompletedAsyncDisposable(){} // RVA: 0x7FFAC8AC63B0
        public void DisposePendingDisposablesOnException(){} // RVA: 0x7FFAC8AC64F0
        public void PropertyPath(){} // RVA: 0x7FFAC8AC65E0
        public void <DisposePendingDisposablesOnException>g__DisposeFrame|21_0(){} // RVA: 0x7FFAC8AC6730
        public void <PropertyPath>g__AppendStackFrame|23_0(){} // RVA: 0x7FFAC8AC67B0
        public void <PropertyPath>g__AppendPropertyName|23_1(){} // RVA: 0x7FFAC8AC68D0
    }

    public class WriteStackFrame : ValueType
    {
        public System.Collections.IEnumerator CollectionEnumerator; // 0x10
        public System.IAsyncDisposable AsyncDisposable; // 0x18
        public bool AsyncEnumeratorIsPendingCompletion; // 0x20
        public System.Text.Json.Serialization.Metadata.JsonPropertyInfo DeclaredJsonPropertyInfo; // 0x28
        public bool IsWritingExtensionDataProperty; // 0x30
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo JsonTypeInfo; // 0x38
        public int OriginalDepth; // 0x40
        public bool ProcessedStartToken; // 0x44
        public bool ProcessedEndToken; // 0x45
        public 0x6B21DD98 PropertyState; // 0x46
        public int EnumeratorIndex; // 0x48
        public string JsonPropertyNameAsString; // 0x50
        public 0x6B21DC38 MetadataPropertyName; // 0x58
        public System.Text.Json.Serialization.Metadata.JsonPropertyInfo PolymorphicJsonPropertyInfo; // 0x60
        public System.Nullable`1<0x6B21E630> NumberHandling; // 0x68

        // ── Methods ──
        public void EndDictionaryElement(){} // RVA: 0x7FFAC8AC69E0
        public void EndProperty(){} // RVA: 0x7FFAC8AC69F0
        public void GetPolymorphicJsonPropertyInfo(){} // RVA: 0x7FFAC8AC6AF0
        public void InitializeReEntry(){} // RVA: 0x7FFAC8AC6B00
    }

}