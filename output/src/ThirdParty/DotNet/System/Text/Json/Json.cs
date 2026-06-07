// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json
// Classes: 37
// Methods: 1043

namespace ThirdParty.DotNet.System.Text.Json
{
    public class AppContextSwitchHelper
    {
        public object CurrentDepth;

        // ── Methods ──
        public void get_IsSourceGenReflectionFallbackEnabled(){} // RVA: 0x684DE50
        public void .cctor(){} // RVA: 0x684DEB0
    }

    public class ArgumentState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Arguments`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class BitStack
    {
        public object Location;

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x32A5C0
        public void PushTrue(){} // RVA: 0x6300890
        public void PushFalse(){} // RVA: 0x63008D0
        public void PushToArray(){} // RVA: 0x6300910
        public void Pop(){} // RVA: 0x6300A30
        public void PopFromArray(){} // RVA: 0x6300A60
        public void DoubleArray(){} // RVA: 0x6300AB0
        public void SetFirstBit(){} // RVA: 0x6300B50
        public void ResetFirstBit(){} // RVA: 0x6300B60
        public void Div32Rem(){} // RVA: 0x6300B70
    }

    public class JsonCamelCaseNamingPolicy
    {
        // ── Methods ──
        public void ConvertName(){} // RVA: 0x62FDDD0
        public void FixCasing(){} // RVA: 0x62FDEF0
        public void .ctor(){} // RVA: 0x62FE090
    }

    public class JsonConstants
    {
        public object OffsetNegative;

        // ── Methods ──
        public void get_Utf8Bom(){} // RVA: 0x62FE230
        public void get_TrueValue(){} // RVA: 0x62FE2A0
        public void get_FalseValue(){} // RVA: 0x62FE310
        public void get_NullValue(){} // RVA: 0x62FE380
        public void get_NaNValue(){} // RVA: 0x62FE3F0
        public void get_PositiveInfinityValue(){} // RVA: 0x62FE460
        public void get_NegativeInfinityValue(){} // RVA: 0x62FE4D0
        public void get_Delimiters(){} // RVA: 0x62FE540
        public void get_EscapableChars(){} // RVA: 0x62FE5B0
    }

    public class JsonDocument
    {
        // ── Methods ──
        public void get_IsDisposable(){} // RVA: 0x1BE4C90
        public void get_RootElement(){} // RVA: 0x6300B80
        public void .ctor(){} // RVA: 0x6300BF0
        public void Dispose(){} // RVA: 0x6300DA0
        public void WriteTo(){} // RVA: 0x6300FF0
        public void GetJsonTokenType(){} // RVA: 0x63010F0
        public void GetArrayLength(){} // RVA: 0x6301120
        public void GetArrayIndexElement(){} // RVA: 0x63011A0
        public void GetEndIndex(){} // RVA: 0x6301370
        public void GetRawValue(){} // RVA: 0x63013F0
        public void GetPropertyRawValue(){} // RVA: 0x6301620
        public void GetString(){} // RVA: 0x63018F0
        public void TextEquals(){} // RVA: 0x6301BD0
        public void GetNameOfPropertyValue(){} // RVA: 0x63020F0
        public void TryGetValue(){} // RVA: 0x6302D80 | overloaded x6
        public void GetRawValueAsString(){} // RVA: 0x6303090
        public void GetPropertyRawValueAsString(){} // RVA: 0x6303150
        public void CloneElement(){} // RVA: 0x6303210
        public void WriteElementTo(){} // RVA: 0x6303590
        public void WriteComplexElement(){} // RVA: 0x6303BC0
        public void UnescapeString(){} // RVA: 0x6303E90
        public void ClearAndReturn(){} // RVA: 0x6304540
        public void WritePropertyName(){} // RVA: 0x6304710
        public void WriteString(){} // RVA: 0x6304930
        public void Parse(){} // RVA: 0x6306DA0 | overloaded x6
        public void CheckNotDisposed(){} // RVA: 0x6304E00
        public void CheckExpectedType(){} // RVA: 0x6304E90
        public void CheckSupportedOptions(){} // RVA: 0x6304EE0
        public void ParseAsync(){} // RVA: 0x6305220
        public void ParseAsyncCore(){} // RVA: 0x6305290
        public void ParseValue(){} // RVA: 0x6305980
        public void TryParseValue(){} // RVA: 0x63059B0
        public void CreateForLiteral(){} // RVA: 0x6306A50
        public void ParseUnrented(){} // RVA: 0x6306FE0
        public void ReadToEnd(){} // RVA: 0x63072C0
        public void ReadToEndAsync(){} // RVA: 0x6307A30
        public void TryGetNamedPropertyValue(){} // RVA: 0x63083D0 | overloaded x2
        public void <CreateForLiteral>g__Create|74_0(){} // RVA: 0x6308E50
    }

    public class JsonDocumentOptions
    {
        public object Current;
        public object System.Collections.IEnumerator.Current;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x1EED2E0
        public void get_MaxDepth(){} // RVA: 0x19689B0
        public void get_AllowTrailingCommas(){} // RVA: 0x1EED2F0
        public void GetReaderOptions(){} // RVA: 0x630C4B0
    }

    public class JsonElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x820840
        public void get_TokenType(){} // RVA: 0x630C550
        public void get_ValueKind(){} // RVA: 0x630C590
        public void get_Item(){} // RVA: 0x630C680
        public void GetArrayLength(){} // RVA: 0x630C700
        public void GetProperty(){} // RVA: 0x630C7C0
        public void TryGetProperty(){} // RVA: 0x630C9B0 | overloaded x2
        public void GetBoolean(){} // RVA: 0x630CA30
        public void GetString(){} // RVA: 0x630CAC0
        public void TryGetInt16(){} // RVA: 0x630CB30
        public void GetInt16(){} // RVA: 0x630CBA0
        public void TryGetInt32(){} // RVA: 0x630CC50
        public void GetInt32(){} // RVA: 0x630CCC0
        public void TryGetInt64(){} // RVA: 0x630CD50
        public void GetInt64(){} // RVA: 0x630CDC0
        public void TryGetDouble(){} // RVA: 0x630CE60
        public void GetDouble(){} // RVA: 0x630CED0
        public void TryGetSingle(){} // RVA: 0x630CF70
        public void GetSingle(){} // RVA: 0x630CFE0
        public void TryGetDateTimeOffset(){} // RVA: 0x630D080
        public void GetDateTimeOffset(){} // RVA: 0x630D0F0
        public void GetPropertyName(){} // RVA: 0x630D190
        public void GetPropertyRawText(){} // RVA: 0x630D200
        public void TextEqualsHelper(){} // RVA: 0x630D300
        public void WriteTo(){} // RVA: 0x630D390
        public void EnumerateArray(){} // RVA: 0x630D440
        public void EnumerateObject(){} // RVA: 0x630D520
        public void ToString(){} // RVA: 0x630D600
        public void Clone(){} // RVA: 0x630D820
        public void CheckValidInstance(){} // RVA: 0x630D8B0
        public void ParseValue(){} // RVA: 0x630D910
    }

    public class JsonEncodedText
    {
        // ── Methods ──
        public void get_EncodedUtf8Bytes(){} // RVA: 0x630E240
        public void .ctor(){} // RVA: 0x630E2E0
        public void Encode(){} // RVA: 0x630E5E0 | overloaded x2
        public void TranscodeAndEncode(){} // RVA: 0x630E6B0
        public void EncodeHelper(){} // RVA: 0x630EBB0
        public void Equals(){} // RVA: 0x630ED40 | overloaded x2
        public void ToString(){} // RVA: 0x630EE20
        public void GetHashCode(){} // RVA: 0x630EE70
    }

    public class JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x630F1C0 | overloaded x5
        public void get_AppendPathInformation(){} // RVA: 0x86DB40
        public void set_AppendPathInformation(){} // RVA: 0x86DB50
        public void GetObjectData(){} // RVA: 0x630F5D0
        public void get_LineNumber(){} // RVA: 0x612FAA0
        public void set_LineNumber(){} // RVA: 0x612FAB0
        public void get_BytePositionInLine(){} // RVA: 0xA4F4E0
        public void set_BytePositionInLine(){} // RVA: 0xA4F4F0
        public void get_Path(){} // RVA: 0x348120
        public void set_Path(){} // RVA: 0x348130
        public void get_Message(){} // RVA: 0x630FBB0
        public void SetMessage(){} // RVA: 0xB54600
    }

    public class JsonHelpers
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x114C0
        public void GetSpan(){} // RVA: 0x62FE620
        public void IsInRangeInclusive(){} // RVA: 0x62FE710 | overloaded x3
        public void IsDigit(){} // RVA: 0x62FE720
        public void ReadWithVerify(){} // RVA: 0x62FE730
        public void Utf8GetString(){} // RVA: 0x62FE740
        public void CreateDictionaryFromCollection(){} // RVA: 0xCEC0
        public void IsFinite(){} // RVA: 0x62FE800 | overloaded x2
        public void ValidateInt32MaxArrayLength(){} // RVA: 0x62FE830
        public void IsValidDateTimeOffsetParseLength(){} // RVA: 0x62FE850
        public void TryParseAsISO(){} // RVA: 0x62FEA70 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x62FEBF0
        public void TryGetNextTwoDigits(){} // RVA: 0x62FF320
        public void TryCreateDateTimeOffset(){} // RVA: 0x62FF520 | overloaded x2
        public void TryCreateDateTimeOffsetInterpretingDataAsLocalTime(){} // RVA: 0x62FF630
        public void TryCreateDateTime(){} // RVA: 0x62FF730
        public void GetEscapedPropertyNameSection(){} // RVA: 0x62FFEC0 | overloaded x2
        public void EscapeValue(){} // RVA: 0x62FFB70
        public void GetPropertyNameSection(){} // RVA: 0x63002D0
        public void .cctor(){} // RVA: 0x6300480
        public void <TryParseDateTimeOffset>g__ParseOffset|22_0(){} // RVA: 0x6300620
    }

    public class JsonKebabCaseLowerNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x684D170
    }

    public class JsonKebabCaseUpperNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x684D1C0
    }

    public class JsonNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_CamelCase(){} // RVA: 0x62FE0E0
        public void ConvertName(){} // RVA: 0xCE10
        public void .cctor(){} // RVA: 0x62FE140
    }

    public class JsonProperty
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x75E7E0
        public void get__name(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x37C4210
        public void get_Name(){} // RVA: 0x630E110
        public void EscapedNameEquals(){} // RVA: 0x630E190
        public void ToString(){} // RVA: 0x630E220
    }

    public class JsonPropertyDictionary`1
    {
        public object System.Collections.Generic.IEnumerator<T>.Current;
        public object System.Collections.IEnumerator.Current;
        public object ICollection`1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25690 | overloaded x2
        public void get_List(){} // RVA: 0xCD60
        public void Add(){} // RVA: 0x283FA0 | overloaded x2
        public void TryAdd(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void ContainsKey(){} // RVA: 0xDE40
        public void get_Count(){} // RVA: 0xD840
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void TryGetValue(){} // RVA: 0x11120
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void SetValue(){} // RVA: 0x283FA0
        public void AddValue(){} // RVA: 0x283FA0
        public void TryAddValue(){} // RVA: 0x283FA0
        public void CreateDictionaryIfThresholdMet(){} // RVA: 0x24A50
        public void ContainsValue(){} // RVA: 0x283FA0
        public void ContainsProperty(){} // RVA: 0xDE40
        public void FindValueIndex(){} // RVA: 0x12590
        public void TryGetPropertyValue(){} // RVA: 0x11120
        public void TryRemoveProperty(){} // RVA: 0x11120
        public void GetKeyCollection(){} // RVA: 0xCD60
        public void GetValueCollection(){} // RVA: 0xCD60
    }

    public class JsonReaderException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x630FD60 | overloaded x2
    }

    public class JsonReaderHelper
    {
        // ── Methods ──
        public void ContainsSpecialCharacters(){} // RVA: 0x6860500
        public void CountNewLines(){} // RVA: 0x68605C0
        public void ToValueKind(){} // RVA: 0x630FE70
        public void IsTokenTypePrimitive(){} // RVA: 0x630FED0
        public void IsHexDigit(){} // RVA: 0x6860770
        public void TryGetEscapedDateTime(){} // RVA: 0x68607A0
        public void TryGetEscapedDateTimeOffset(){} // RVA: 0x68609C0
        public void TryGetEscapedGuid(){} // RVA: 0x6860BF0
        public void TryGetFloatingPointConstant(){} // RVA: 0x6861150 | overloaded x2
        public void TryGetUnescapedBase64Bytes(){} // RVA: 0x6861410
        public void GetUnescapedString(){} // RVA: 0x6861890
        public void GetUnescapedSpan(){} // RVA: 0x6861BD0
        public void UnescapeAndCompare(){} // RVA: 0x6862300 | overloaded x2
        public void TryDecodeBase64InPlace(){} // RVA: 0x68628E0
        public void TryDecodeBase64(){} // RVA: 0x6862A90
        public void TranscodeHelper(){} // RVA: 0x6863090 | overloaded x2
        public void ValidateUtf8(){} // RVA: 0x6863280
        public void GetUtf8ByteCount(){} // RVA: 0x68633C0
        public void GetUtf8FromText(){} // RVA: 0x6863500
        public void GetTextFromUtf8(){} // RVA: 0x68636D0
        public void Unescape(){} // RVA: 0x6863960 | overloaded x2
        public void TryUnescape(){} // RVA: 0x6863AD0 | overloaded x2
        public void TryEncodeToUtf8Bytes(){} // RVA: 0x68644E0
        public void IndexOfQuoteOrAnyControlOrBackSlash(){} // RVA: 0x6864680
        public void LocateFirstFoundByte(){} // RVA: 0x62C1150 | overloaded x2
        public void .cctor(){} // RVA: 0x6864AF0
    }

    public class JsonReaderOptions
    {
        public object Options;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x1EED2E0
        public void set_CommentHandling(){} // RVA: 0x6313F70
        public void get_MaxDepth(){} // RVA: 0x19689B0
        public void set_MaxDepth(){} // RVA: 0x6313FC0
        public void get_AllowTrailingCommas(){} // RVA: 0x1EED2F0
        public void set_AllowTrailingCommas(){} // RVA: 0x10EEBB0
    }

    public class JsonReaderState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6314010
        public void get_Options(){} // RVA: 0x2E07C0
    }

    public class JsonSeparatorNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x684D210
        public void ConvertName(){} // RVA: 0x684D280
        public void ConvertNameCore(){} // RVA: 0x684D340
        public void <ConvertNameCore>g__WriteChar|4_0(){} // RVA: 0x684DA60
        public void <ConvertNameCore>g__ExpandBuffer|4_1(){} // RVA: 0x684DAE0
    }

    public class JsonSerializer
    {
        public object Current;

        // ── Methods ──
        public void Deserialize(){} // RVA: 0x68A6600 | overloaded x40
        public void ReadFromNode(){} // RVA: 0x283FA0
        public void ReadFromNodeAsObject(){} // RVA: 0x68A1B20
        public void SerializeToDocument(){} // RVA: 0x68A1F90 | overloaded x5
        public void WriteDocument(){} // RVA: 0xCEC0
        public void WriteDocumentAsObject(){} // RVA: 0x68A2100
        public void SerializeToElement(){} // RVA: 0x68A2470 | overloaded x5
        public void WriteElement(){} // RVA: 0x283FA0
        public void WriteElementAsObject(){} // RVA: 0x68A2600
        public void SerializeToNode(){} // RVA: 0x68A29A0 | overloaded x5
        public void WriteNode(){} // RVA: 0xCEC0
        public void WriteNodeAsObject(){} // RVA: 0x68A2B10
        public void get_IsReflectionEnabledByDefault(){} // RVA: 0x68A2CD0
        public void GetTypeInfo(){} // RVA: 0x68A2F30 | overloaded x3
        public void ValidateInputType(){} // RVA: 0x68A2FB0
        public void IsValidNumberHandlingValue(){} // RVA: 0x68A3040
        public void IsValidCreationHandlingValue(){} // RVA: 0x68A3050
        public void IsValidUnmappedMemberHandlingValue(){} // RVA: 0x68A3050
        public void UnboxOnRead(){} // RVA: 0x283FA0
        public void UnboxOnWrite(){} // RVA: 0x283FA0
        public void TryReadMetadata(){} // RVA: 0x68A3060
        public void IsMetadataPropertyName(){} // RVA: 0x68A3A50
        public void GetMetadataPropertyName(){} // RVA: 0x68A3BB0
        public void TryHandleReferenceFromJsonElement(){} // RVA: 0x68A3E70
        public void TryHandleReferenceFromJsonNode(){} // RVA: 0x68A4520
        public void ValidateMetadataForObjectConverter(){} // RVA: 0x68A4A40
        public void ValidateMetadataForArrayConverter(){} // RVA: 0x68A4AD0
        public void ResolveReferenceId(){} // RVA: 0x283FA0
        public void LookupProperty(){} // RVA: 0x68A4B60
        public void GetPropertyName(){} // RVA: 0x68A4DE0
        public void CreateExtensionDataProperty(){} // RVA: 0x68A4F30
        public void ReadFromSpan(){} // RVA: 0x283FA0 | overloaded x2
        public void ReadFromSpanAsObject(){} // RVA: 0x68A6160 | overloaded x2
        public void DeserializeAsync(){} // RVA: 0x68A5830 | overloaded x5
        public void DeserializeAsyncEnumerable(){} // RVA: 0x1E960 | overloaded x2
        public void DeserializeAsyncEnumerableCore(){} // RVA: 0x1E960
        public void Read(){} // RVA: 0x283FA0
        public void ReadAsObject(){} // RVA: 0x68A6720
        public void GetReaderScopedToNextValue(){} // RVA: 0x68A6A10
        public void SerializeToUtf8Bytes(){} // RVA: 0x68A7460 | overloaded x5
        public void WriteBytes(){} // RVA: 0xCEC0
        public void WriteBytesAsObject(){} // RVA: 0x68A75D0
        public void WriteMetadataForObject(){} // RVA: 0x68A7790
        public void WriteMetadataForCollection(){} // RVA: 0x68A7B40
        public void TryGetReferenceForValue(){} // RVA: 0x68A7C00
        public void SerializeAsync(){} // RVA: 0x68A8280 | overloaded x5
        public void Serialize(){} // RVA: 0x68A8C90 | overloaded x15
        public void WriteString(){} // RVA: 0xCEC0
        public void WriteStringAsObject(){} // RVA: 0x68A88F0
        public void .cctor(){} // RVA: 0x68A8E40
        public void <UnboxOnRead>g__ThrowUnableToCastValue|50_0(){} // RVA: 0x24AE0
        public void <TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(){} // RVA: 0x68A9420
        public void <DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerable|90_0(){} // RVA: 0x1E960
        public void <DeserializeAsyncEnumerableCore>g__CreateQueueTypeInfo|90_1(){} // RVA: 0xCE50
    }

    public class JsonSerializerOptions
    {
        public object DynamicCodeGeneration;
        public object FullyTrusted;
        public object ReflectionDelegateFactory;
        public object `;
        public object .ctor;
        public object .ctor;

        // ── Methods ──
        public void get_CacheContext(){} // RVA: 0x68A9F00
        public void GetTypeInfo(){} // RVA: 0x68A9FB0
        public void TryGetTypeInfo(){} // RVA: 0x68AA090
        public void GetTypeInfoInternal(){} // RVA: 0x68AA1C0
        public void TryGetTypeInfoCached(){} // RVA: 0x68AA3B0
        public void GetTypeInfoForRootType(){} // RVA: 0x68AA5B0
        public void TryGetPolymorphicTypeInfoForRootType(){} // RVA: 0x68AA6D0
        public void get_ObjectTypeInfo(){} // RVA: 0x68AA8D0
        public void ClearCaches(){} // RVA: 0x68AA9D0
        public void get_Converters(){} // RVA: 0x68AAAE0
        public void GetConverter(){} // RVA: 0x68AAB90
        public void GetConverterInternal(){} // RVA: 0x68AAC40
        public void GetConverterFromList(){} // RVA: 0x68AACC0
        public void ExpandConverterFactory(){} // RVA: 0x68AADE0
        public void CheckConverterNullabilityIsSameAsPropertyType(){} // RVA: 0x68AAE90
        public void get_Default(){} // RVA: 0x68AAF60
        public void .ctor(){} // RVA: 0x68AB320 | overloaded x3
        public void TrackOptionsInstance(){} // RVA: 0x68AB490
        public void AddContext(){} // RVA: 0x24A50
        public void get_TypeInfoResolver(){} // RVA: 0x30B130
        public void set_TypeInfoResolver(){} // RVA: 0x68AB550
        public void get_TypeInfoResolverChain(){} // RVA: 0x68AB6B0
        public void get_AllowTrailingCommas(){} // RVA: 0x8A89C0
        public void set_AllowTrailingCommas(){} // RVA: 0x68AB7E0
        public void get_DefaultBufferSize(){} // RVA: 0x1929080
        public void set_DefaultBufferSize(){} // RVA: 0x68AB850
        public void get_Encoder(){} // RVA: 0x37E0E0
        public void set_Encoder(){} // RVA: 0x68AB920
        public void get_DictionaryKeyPolicy(){} // RVA: 0x6374D0
        public void set_DictionaryKeyPolicy(){} // RVA: 0x68AB9E0
        public void get_IgnoreNullValues(){} // RVA: 0x8A0370
        public void set_IgnoreNullValues(){} // RVA: 0x68ABAA0
        public void get_DefaultIgnoreCondition(){} // RVA: 0x59CEC0
        public void set_DefaultIgnoreCondition(){} // RVA: 0x68ABB80
        public void get_NumberHandling(){} // RVA: 0x59C4F0
        public void set_NumberHandling(){} // RVA: 0x68ABCC0
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x1C91440
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x68ABDB0
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x8A7B20
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x68ABEA0
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x8A79A0
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x68ABF10
        public void get_IncludeFields(){} // RVA: 0x5A8B10
        public void set_IncludeFields(){} // RVA: 0x68ABF80
        public void get_MaxDepth(){} // RVA: 0x1AE3800
        public void set_MaxDepth(){} // RVA: 0x68ABFF0
        public void get_EffectiveMaxDepth(){} // RVA: 0x6AFD40
        public void set_EffectiveMaxDepth(){} // RVA: 0xF02F80
        public void get_PropertyNamingPolicy(){} // RVA: 0x4976A0
        public void set_PropertyNamingPolicy(){} // RVA: 0x68AC0A0
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x59F730
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x68AC160
        public void get_ReadCommentHandling(){} // RVA: 0x398C00
        public void set_ReadCommentHandling(){} // RVA: 0x68AC1D0
        public void get_UnknownTypeHandling(){} // RVA: 0x1C91460
        public void set_UnknownTypeHandling(){} // RVA: 0x68AC2B0
        public void get_UnmappedMemberHandling(){} // RVA: 0x10E5CF0
        public void set_UnmappedMemberHandling(){} // RVA: 0x68AC320
        public void get_WriteIndented(){} // RVA: 0x113C490
        public void set_WriteIndented(){} // RVA: 0x68AC390
        public void get_ReferenceHandler(){} // RVA: 0x358730
        public void set_ReferenceHandler(){} // RVA: 0x68AC400
        public void get_CanUseFastPathSerializationLogic(){} // RVA: 0x68AC4E0
        public void get_IsReadOnly(){} // RVA: 0x68AC5A0
        public void MakeReadOnly(){} // RVA: 0x68AC5E0 | overloaded x2
        public void ConfigureForJsonSerializer(){} // RVA: 0x68AC630
        public void GetTypeInfoNoCaching(){} // RVA: 0x68ACA60
        public void GetDocumentOptions(){} // RVA: 0x68ACCA0
        public void GetNodeOptions(){} // RVA: 0x59F730
        public void GetReaderOptions(){} // RVA: 0x68ACD80
        public void GetWriterOptions(){} // RVA: 0x68ACE30
        public void VerifyMutable(){} // RVA: 0x68ACF00
        public void GetOrCreateDefaultOptionsInstance(){} // RVA: 0x68ACF60
        public void get_DebuggerDisplay(){} // RVA: 0x68AD130
    }

    public class JsonSnakeCaseLowerNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x684DDB0
    }

    public class JsonSnakeCaseUpperNamingPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x684DE00
    }

    public class JsonWriterHelper
    {
        // ── Methods ──
        public void WriteIndentation(){} // RVA: 0x68B3DA0
        public void ValidateProperty(){} // RVA: 0x68B3F90 | overloaded x2
        public void ValidateValue(){} // RVA: 0x68B3FE0 | overloaded x2
        public void ValidateDouble(){} // RVA: 0x68B3F20
        public void ValidateSingle(){} // RVA: 0x68B3F60
        public void ValidatePropertyAndValue(){} // RVA: 0x68B41D0 | overloaded x4
        public void ValidatePropertyNameLength(){} // RVA: 0x68B42A0 | overloaded x2
        public void ValidateNumber(){} // RVA: 0x68B42F0
        public void IsValidUtf8String(){} // RVA: 0x68B4730
        public void ToUtf8(){} // RVA: 0x68B4840
        public void WriteDateTimeTrimmed(){} // RVA: 0x68B4A10
        public void WriteDateTimeOffsetTrimmed(){} // RVA: 0x68B4C60
        public void TrimDateTimeOffset(){} // RVA: 0x68B4EB0
        public void get_AllowList(){} // RVA: 0x68B5060
        public void NeedsEscaping(){} // RVA: 0x68B5250 | overloaded x3
        public void NeedsEscapingNoBoundsCheck(){} // RVA: 0x68B5160
        public void GetMaxEscapedLength(){} // RVA: 0x63310A0
        public void EscapeString(){} // RVA: 0x68B5D10 | overloaded x4
        public void EscapeNextBytes(){} // RVA: 0x68B5920
        public void IsAsciiValue(){} // RVA: 0x5D77760 | overloaded x2
        public void EscapeNextChars(){} // RVA: 0x68B61F0
        public void WriteHex(){} // RVA: 0x68B64C0
        public void .cctor(){} // RVA: 0x68B6580
    }

    public class JsonWriterOptions
    {
        // ── Methods ──
        public void get_Encoder(){} // RVA: 0x19689C0
        public void set_Encoder(){} // RVA: 0x1968950
        public void get_Indented(){} // RVA: 0x6170FA0
        public void set_Indented(){} // RVA: 0x6332B20
        public void get_SkipValidation(){} // RVA: 0x6170FB0
        public void set_SkipValidation(){} // RVA: 0x6332B40
        public void get_IndentedOrNotSkipValidation(){} // RVA: 0x6332B60
    }

    public class PooledByteBufferWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62F6AC0
        public void get_WrittenMemory(){} // RVA: 0x62F6B80
        public void ClearHelper(){} // RVA: 0x62F6C60
        public void Dispose(){} // RVA: 0x62F6D70
        public void Advance(){} // RVA: 0x62F6F30
        public void GetMemory(){} // RVA: 0x62F6F40
        public void CheckAndResizeBuffer(){} // RVA: 0x62F7060
    }

    public class ReadStack
    {
        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x632CD70
        public void EnsurePushCapacity(){} // RVA: 0x632CD80
        public void Initialize(){} // RVA: 0x632CEF0 | overloaded x2
        public void Push(){} // RVA: 0x632D0C0
        public void Pop(){} // RVA: 0x632D530
        public void JsonPath(){} // RVA: 0x632D860
        public void SetConstructorArgumentState(){} // RVA: 0x632DA00
        public void .cctor(){} // RVA: 0x632DC70
        public void <JsonPath>g__AppendStackFrame|18_0(){} // RVA: 0x632DD50
        public void <JsonPath>g__GetCount|18_1(){} // RVA: 0x632E1C0
        public void <JsonPath>g__AppendPropertyName|18_2(){} // RVA: 0x632E310
        public void <JsonPath>g__GetPropertyName|18_3(){} // RVA: 0x632E420
    }

    public class ReadStackFrame
    {
        // ── Methods ──
        public void EndConstructorParameter(){} // RVA: 0x632E590
        public void EndProperty(){} // RVA: 0x632E660
        public void EndElement(){} // RVA: 0x632E770
        public void IsProcessingDictionary(){} // RVA: 0x632E7D0
        public void IsProcessingEnumerable(){} // RVA: 0x632E800
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(){} // RVA: 0x62F73A0
        public void GetArgumentOutOfRangeException_MaxDepthMustBePositive(){} // RVA: 0x62F7440
        public void GetArgumentOutOfRangeException(){} // RVA: 0x62F74F0
        public void GetArgumentOutOfRangeException_CommentEnumMustBeInRange(){} // RVA: 0x62F7560
        public void GetArgumentException(){} // RVA: 0x62F7610
        public void ThrowArgumentException(){} // RVA: 0x62F7840 | overloaded x2
        public void ThrowArgumentException_PropertyNameTooLarge(){} // RVA: 0x62F76A0
        public void ThrowArgumentException_ValueTooLarge(){} // RVA: 0x62F7720
        public void ThrowArgumentException_ValueNotSupported(){} // RVA: 0x62F77A0
        public void ThrowInvalidOperationException_NeedLargerSpan(){} // RVA: 0x62F77F0
        public void ThrowInvalidOperationException(){} // RVA: 0x62F97C0 | overloaded x3
        public void GetInvalidOperationException(){} // RVA: 0x62F9E50 | overloaded x4
        public void ThrowInvalidOperationOrArgumentException(){} // RVA: 0x62F7A90
        public void GetInvalidOperationException_ExpectedArray(){} // RVA: 0x62F7B90
        public void GetInvalidOperationException_ExpectedObject(){} // RVA: 0x62F7BE0
        public void GetInvalidOperationException_ExpectedNumber(){} // RVA: 0x62F7C30
        public void GetInvalidOperationException_ExpectedBoolean(){} // RVA: 0x62F7C80
        public void GetInvalidOperationException_ExpectedString(){} // RVA: 0x62F7CD0
        public void GetInvalidOperationException_CannotSkipOnPartial(){} // RVA: 0x62F7D20
        public void GetJsonElementWrongTypeException(){} // RVA: 0x62F81A0 | overloaded x4
        public void ThrowJsonReaderException(){} // RVA: 0x62F82A0
        public void GetJsonReaderException(){} // RVA: 0x62F82F0
        public void IsPrintable(){} // RVA: 0x62F86A0
        public void GetPrintableString(){} // RVA: 0x62F86B0
        public void GetResourceString(){} // RVA: 0x62F9FA0 | overloaded x2
        public void ThrowArgumentException_InvalidUTF8(){} // RVA: 0x62F97F0
        public void ThrowArgumentException_InvalidUTF16(){} // RVA: 0x62F99E0
        public void ThrowInvalidOperationException_ReadInvalidUTF16(){} // RVA: 0x62F9B40 | overloaded x2
        public void GetInvalidOperationException_ReadInvalidUTF8(){} // RVA: 0x62F9B90
        public void GetArgumentException_ReadInvalidUTF16(){} // RVA: 0x62F9CC0
        public void ThrowOutOfMemoryException(){} // RVA: 0x62F9F00
        public void GetFormatException(){} // RVA: 0x62FAAB0 | overloaded x3
        public void GetInvalidOperationException_ExpectedChar(){} // RVA: 0x62FAE10
        public void ThrowArgumentException_NodeValueNotAllowed(){} // RVA: 0x62FAE60
        public void ThrowArgumentException_NodeArrayTooSmall(){} // RVA: 0x62FAED0
        public void ThrowArgumentOutOfRangeException_NodeArrayIndexNegative(){} // RVA: 0x62FAF40
        public void ThrowArgumentException_DuplicateKey(){} // RVA: 0x62FAFB0
        public void ThrowInvalidOperationException_NodeAlreadyHasParent(){} // RVA: 0x62FB020
        public void ThrowInvalidOperationException_NodeCycleDetected(){} // RVA: 0x62FB090
        public void ThrowNotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x62FB100
        public void NotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x62FB130
        public void ThrowNotSupportedException_SerializationNotSupported(){} // RVA: 0x62FB210
        public void ThrowNotSupportedException_TypeRequiresAsyncSerialization(){} // RVA: 0x62FB290
        public void ThrowNotSupportedException_ConstructorMaxOf64Parameters(){} // RVA: 0x62FB310
        public void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(){} // RVA: 0x62FB390
        public void ThrowJsonException_DeserializeUnableToConvertValue(){} // RVA: 0x62FB430
        public void ThrowInvalidCastException_DeserializeUnableToAssignValue(){} // RVA: 0x62FB4C0
        public void ThrowInvalidOperationException_DeserializeUnableToAssignNull(){} // RVA: 0x62FB540
        public void ThrowJsonException_SerializationConverterRead(){} // RVA: 0x62FB5C0
        public void ThrowJsonException_SerializationConverterWrite(){} // RVA: 0x62FB650
        public void ThrowJsonException_SerializerCycleDetected(){} // RVA: 0x62FB6E0
        public void ThrowJsonException(){} // RVA: 0x62FB790
        public void ThrowInvalidOperationException_CannotSerializeInvalidType(){} // RVA: 0x62FB7F0
        public void ThrowInvalidOperationException_SerializationConverterNotCompatible(){} // RVA: 0x62FB910
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(){} // RVA: 0x62FB990
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x62FBA70
        public void ThrowInvalidOperationException_SerializerOptionsImmutable(){} // RVA: 0x62FBB60
        public void ThrowInvalidOperationException_SerializerPropertyNameConflict(){} // RVA: 0x62FBBE0
        public void ThrowInvalidOperationException_SerializerPropertyNameNull(){} // RVA: 0x62FBC80
        public void ThrowInvalidOperationException_NamingPolicyReturnNull(){} // RVA: 0x62FBD50
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(){} // RVA: 0x62FBDD0
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(){} // RVA: 0x62FBE50
        public void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(){} // RVA: 0x62FBED0
        public void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(){} // RVA: 0x62FC010
        public void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x62FC090
        public void ThrowInvalidOperationException_JsonIncludeOnNonPublicInvalid(){} // RVA: 0x62FC140
        public void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x62FC1C0
        public void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(){} // RVA: 0x62FC240
        public void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(){} // RVA: 0x62FC300
        public void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotHonored(){} // RVA: 0x62FC3C0
        public void ReThrowWithPath(){} // RVA: 0x62FC4A0
        public void AddJsonExceptionInformation(){} // RVA: 0x62FC510
        public void ThrowInvalidOperationException_SerializationDuplicateAttribute(){} // RVA: 0x62FC750
        public void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(){} // RVA: 0x24AE0 | overloaded x2
        public void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x62FC8C0
        public void ThrowNotSupportedException(){} // RVA: 0x62FCD40 | overloaded x2
        public void ThrowNotSupportedException_DeserializeNoConstructor(){} // RVA: 0x62FCF10
        public void ThrowNotSupportedException_CannotPopulateCollection(){} // RVA: 0x62FCFF0
        public void ThrowJsonException_MetadataValuesInvalidToken(){} // RVA: 0x62FD090
        public void ThrowJsonException_MetadataReferenceNotFound(){} // RVA: 0x62FD110
        public void ThrowJsonException_MetadataValueWasNotString(){} // RVA: 0x62FD1F0 | overloaded x2
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x62FD2C0 | overloaded x2
        public void ThrowJsonException_MetadataIdIsNotFirstProperty(){} // RVA: 0x62FD300
        public void ThrowJsonException_MetadataMissingIdBeforeValues(){} // RVA: 0x62FD380
        public void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x62FD400
        public void ThrowJsonException_MetadataDuplicateIdFound(){} // RVA: 0x62FD530
        public void ThrowJsonException_MetadataInvalidReferenceToValueType(){} // RVA: 0x62FD590
        public void ThrowJsonException_MetadataPreservedArrayInvalidProperty(){} // RVA: 0x62FD5F0
        public void ThrowJsonException_MetadataPreservedArrayValuesNotFound(){} // RVA: 0x62FD7B0
        public void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(){} // RVA: 0x62FD850
        public void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x62FD8B0
        public void ThrowUnexpectedMetadataException(){} // RVA: 0x62FD940
        public void ThrowInvalidOperationException_JsonSerializerOptionsAlreadyBoundToContext(){} // RVA: 0x62FDA80
        public void ThrowNotSupportedException_BuiltInConvertersNotRooted(){} // RVA: 0x62FDB10
        public void ThrowNotSupportedException_NoMetadataForType(){} // RVA: 0x62FDB90
        public void ThrowInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x62FDC10
        public void ThrowInvalidOperationException_NoMetadataForTypeCtorParams(){} // RVA: 0x62FDCB0
        public void ThrowMissingMemberException_MissingFSharpCoreMember(){} // RVA: 0x62FDD50
    }

    public class Utf8JsonReader
    {
        // ── Methods ──
        public void get_IsLastSpan(){} // RVA: 0x6314030
        public void get_OriginalSequence(){} // RVA: 0x6314050
        public void get_OriginalSpan(){} // RVA: 0x6314070
        public void get_ValueSpan(){} // RVA: 0x26EB070
        public void set_ValueSpan(){} // RVA: 0x6314140
        public void get_BytesConsumed(){} // RVA: 0x63141B0
        public void get_TokenStartIndex(){} // RVA: 0x348120
        public void set_TokenStartIndex(){} // RVA: 0xEB7880
        public void get_CurrentDepth(){} // RVA: 0x63141C0
        public void get_IsInArray(){} // RVA: 0x1D53150
        public void get_TokenType(){} // RVA: 0x4FB950
        public void get_HasValueSequence(){} // RVA: 0x126AF80
        public void set_HasValueSequence(){} // RVA: 0x126BEE0
        public void get_IsFinalBlock(){} // RVA: 0x2F84E0
        public void get_ValueSequence(){} // RVA: 0x26EB090
        public void set_ValueSequence(){} // RVA: 0x63141E0
        public void get_CurrentState(){} // RVA: 0x6314250
        public void .ctor(){} // RVA: 0x63145F0 | overloaded x2
        public void Read(){} // RVA: 0x6314670
        public void Skip(){} // RVA: 0x6314700
        public void SkipHelper(){} // RVA: 0x6314740
        public void TrySkip(){} // RVA: 0x6314890
        public void TrySkipHelper(){} // RVA: 0x63148C0
        public void StartObject(){} // RVA: 0x6314B90
        public void EndObject(){} // RVA: 0x6314CF0
        public void StartArray(){} // RVA: 0x6314E70
        public void EndArray(){} // RVA: 0x6314FD0
        public void UpdateBitStackOnEndToken(){} // RVA: 0x6315150
        public void ReadSingleSegment(){} // RVA: 0x63151B0
        public void HasMoreData(){} // RVA: 0x63155A0 | overloaded x2
        public void ReadFirstToken(){} // RVA: 0x6315660
        public void SkipWhiteSpace(){} // RVA: 0x6315930
        public void ConsumeValue(){} // RVA: 0x6315A00
        public void ConsumeLiteral(){} // RVA: 0x6315F90
        public void CheckLiteral(){} // RVA: 0x6316290
        public void ThrowInvalidLiteral(){} // RVA: 0x63163D0
        public void ConsumeNumber(){} // RVA: 0x6316460
        public void ConsumePropertyName(){} // RVA: 0x63165C0
        public void ConsumeString(){} // RVA: 0x6316700
        public void ConsumeStringAndValidate(){} // RVA: 0x6316A70
        public void ValidateHexDigits(){} // RVA: 0x6316E40
        public void TryGetNumber(){} // RVA: 0x6316FC0
        public void ConsumeNegativeSign(){} // RVA: 0x6317320
        public void ConsumeZero(){} // RVA: 0x6317510
        public void ConsumeIntegerDigits(){} // RVA: 0x6317790
        public void ConsumeDecimalDigits(){} // RVA: 0x6317960
        public void ConsumeSign(){} // RVA: 0x6317B40
        public void ConsumeNextTokenOrRollback(){} // RVA: 0x6317DB0
        public void ConsumeNextToken(){} // RVA: 0x6317E30
        public void ConsumeNextTokenFromLastNonCommentToken(){} // RVA: 0x6318200
        public void SkipAllComments(){} // RVA: 0x6318850 | overloaded x2
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkipped(){} // RVA: 0x6318920
        public void SkipComment(){} // RVA: 0x6318D80
        public void SkipSingleLineComment(){} // RVA: 0x6318F90
        public void FindLineSeparator(){} // RVA: 0x6319100
        public void ThrowOnDangerousLineSeparator(){} // RVA: 0x6319340
        public void SkipMultiLineComment(){} // RVA: 0x6319430
        public void ConsumeComment(){} // RVA: 0x6319890
        public void ConsumeSingleLineComment(){} // RVA: 0x6319AA0
        public void ConsumeMultiLineComment(){} // RVA: 0x6319BD0
        public void GetUnescapedSpan(){} // RVA: 0x6319D00
        public void ReadMultiSegment(){} // RVA: 0x6319EF0
        public void ValidateStateAtEndOfData(){} // RVA: 0x631A270
        public void HasMoreDataMultiSegment(){} // RVA: 0x631A3E0 | overloaded x2
        public void GetNextSpan(){} // RVA: 0x631A500
        public void ReadFirstTokenMultiSegment(){} // RVA: 0x631A8A0
        public void SkipWhiteSpaceMultiSegment(){} // RVA: 0x631AB50
        public void ConsumeValueMultiSegment(){} // RVA: 0x631ABB0
        public void ConsumeLiteralMultiSegment(){} // RVA: 0x631B140
        public void CheckLiteralMultiSegment(){} // RVA: 0x631B440
        public void FindMismatch(){} // RVA: 0x631C050
        public void GetInvalidLiteralMultiSegment(){} // RVA: 0x631C150
        public void ConsumeNumberMultiSegment(){} // RVA: 0x631C200
        public void ConsumePropertyNameMultiSegment(){} // RVA: 0x631C360
        public void ConsumeStringMultiSegment(){} // RVA: 0x631C4A0
        public void ConsumeStringNextSegment(){} // RVA: 0x631C820
        public void ConsumeStringAndValidateMultiSegment(){} // RVA: 0x631D2E0
        public void RollBackState(){} // RVA: 0x631DAA0
        public void TryGetNumberMultiSegment(){} // RVA: 0x631DB20
        public void ConsumeNegativeSignMultiSegment(){} // RVA: 0x631E410
        public void ConsumeZeroMultiSegment(){} // RVA: 0x631E6A0
        public void ConsumeIntegerDigitsMultiSegment(){} // RVA: 0x631E9B0
        public void ConsumeDecimalDigitsMultiSegment(){} // RVA: 0x631ECE0
        public void ConsumeSignMultiSegment(){} // RVA: 0x631EF50
        public void ConsumeNextTokenOrRollbackMultiSegment(){} // RVA: 0x631F300
        public void ConsumeNextTokenMultiSegment(){} // RVA: 0x631F3E0
        public void ConsumeNextTokenFromLastNonCommentTokenMultiSegment(){} // RVA: 0x631F840
        public void SkipAllCommentsMultiSegment(){} // RVA: 0x631FF20 | overloaded x2
        public void ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(){} // RVA: 0x631FFF0
        public void SkipOrConsumeCommentMultiSegmentWithRollback(){} // RVA: 0x6320500
        public void SkipCommentMultiSegment(){} // RVA: 0x63209A0
        public void SkipSingleLineCommentMultiSegment(){} // RVA: 0x6320D10
        public void FindLineSeparatorMultiSegment(){} // RVA: 0x6320EF0
        public void ThrowOnDangerousLineSeparatorMultiSegment(){} // RVA: 0x63212D0
        public void SkipMultiLineCommentMultiSegment(){} // RVA: 0x6321440
        public void CaptureState(){} // RVA: 0x6321960
        public void GetString(){} // RVA: 0x63219E0
        public void GetBoolean(){} // RVA: 0x6321C10
        public void GetBytesFromBase64(){} // RVA: 0x6321D10
        public void GetByte(){} // RVA: 0x6321D70
        public void GetByteWithQuotes(){} // RVA: 0x6321DD0
        public void GetSByte(){} // RVA: 0x6321E50
        public void GetSByteWithQuotes(){} // RVA: 0x6321EB0
        public void GetInt16(){} // RVA: 0x6321F40
        public void GetInt16WithQuotes(){} // RVA: 0x6321FA0
        public void GetInt32(){} // RVA: 0x6322030
        public void GetInt32WithQuotes(){} // RVA: 0x6322090
        public void GetInt64(){} // RVA: 0x6322120
        public void GetInt64WithQuotes(){} // RVA: 0x6322180
        public void GetUInt16(){} // RVA: 0x6322210
        public void GetUInt16WithQuotes(){} // RVA: 0x6322270
        public void GetUInt32(){} // RVA: 0x6322300
        public void GetUInt32WithQuotes(){} // RVA: 0x6322360
        public void GetUInt64(){} // RVA: 0x63223F0
        public void GetUInt64WithQuotes(){} // RVA: 0x6322450
        public void GetSingle(){} // RVA: 0x63224E0
        public void GetSingleWithQuotes(){} // RVA: 0x6322540
        public void GetSingleFloatingPointConstant(){} // RVA: 0x6322710
        public void GetDouble(){} // RVA: 0x63227E0
        public void GetDoubleWithQuotes(){} // RVA: 0x6322840
        public void GetDoubleFloatingPointConstant(){} // RVA: 0x6322AD0
        public void GetDecimal(){} // RVA: 0x6322BB0
        public void GetDecimalWithQuotes(){} // RVA: 0x6322C10
        public void GetDateTime(){} // RVA: 0x6322C80
        public void GetDateTimeNoValidation(){} // RVA: 0x6322D10
        public void GetDateTimeOffset(){} // RVA: 0x6322D70
        public void GetDateTimeOffsetNoValidation(){} // RVA: 0x6322E00
        public void GetGuid(){} // RVA: 0x6322E60
        public void GetGuidNoValidation(){} // RVA: 0x6322EF0
        public void TryGetBytesFromBase64(){} // RVA: 0x6322F50
        public void TryGetByte(){} // RVA: 0x6323180
        public void TryGetByteCore(){} // RVA: 0x63232B0
        public void TryGetSByte(){} // RVA: 0x63233C0
        public void TryGetSByteCore(){} // RVA: 0x63234F0
        public void TryGetInt16(){} // RVA: 0x6323600
        public void TryGetInt16Core(){} // RVA: 0x6323730
        public void TryGetInt32(){} // RVA: 0x6323840
        public void TryGetInt32Core(){} // RVA: 0x6323970
        public void TryGetInt64(){} // RVA: 0x6323A80
        public void TryGetInt64Core(){} // RVA: 0x6323BB0
        public void TryGetUInt16(){} // RVA: 0x6323CC0
        public void TryGetUInt16Core(){} // RVA: 0x6323DF0
        public void TryGetUInt32(){} // RVA: 0x6323F00
        public void TryGetUInt32Core(){} // RVA: 0x6324030
        public void TryGetUInt64(){} // RVA: 0x6324140
        public void TryGetUInt64Core(){} // RVA: 0x6324270
        public void TryGetSingle(){} // RVA: 0x6324380
        public void TryGetDouble(){} // RVA: 0x6324570
        public void TryGetDecimal(){} // RVA: 0x63247F0
        public void TryGetDecimalCore(){} // RVA: 0x6324920
        public void TryGetDateTime(){} // RVA: 0x6324A00
        public void TryGetDateTimeCore(){} // RVA: 0x6324A50
        public void TryGetDateTimeOffset(){} // RVA: 0x6324FC0
        public void TryGetDateTimeOffsetCore(){} // RVA: 0x6325010
        public void TryGetGuid(){} // RVA: 0x6325580
        public void TryGetGuidCore(){} // RVA: 0x63255D0
    }

    public class Utf8JsonWriter
    {
        // ── Methods ──
        public void get_BytesPending(){} // RVA: 0x10E5CF0
        public void set_BytesPending(){} // RVA: 0x475080
        public void get_BytesCommitted(){} // RVA: 0x4C7C50
        public void set_BytesCommitted(){} // RVA: 0x5AAF010
        public void get_Indentation(){} // RVA: 0x6332B70
        public void get_TokenType(){} // RVA: 0x4A7410
        public void get_CurrentDepth(){} // RVA: 0x6332B80
        public void .ctor(){} // RVA: 0x6332CC0 | overloaded x2
        public void ResetHelper(){} // RVA: 0x6332FA0
        public void CheckNotDisposed(){} // RVA: 0x6332FC0
        public void Flush(){} // RVA: 0x6333030
        public void Dispose(){} // RVA: 0x6333250
        public void DisposeAsync(){} // RVA: 0x6333390
        public void FlushAsync(){} // RVA: 0x6333520
        public void WriteStartArray(){} // RVA: 0x6334230 | overloaded x4
        public void WriteStartObject(){} // RVA: 0x6334300 | overloaded x3
        public void WriteStart(){} // RVA: 0x6333770
        public void WriteStartMinimized(){} // RVA: 0x6333830
        public void WriteStartSlow(){} // RVA: 0x6333940
        public void ValidateStart(){} // RVA: 0x63339C0
        public void WriteStartIndented(){} // RVA: 0x6333A30
        public void WriteStartHelper(){} // RVA: 0x6333D80
        public void WriteStartByOptions(){} // RVA: 0x63345B0 | overloaded x2
        public void WriteStartEscape(){} // RVA: 0x63343D0
        public void WriteStartEscapeProperty(){} // RVA: 0x6334660
        public void WriteEndArray(){} // RVA: 0x6334AB0
        public void WriteEndObject(){} // RVA: 0x6334AD0
        public void WriteEnd(){} // RVA: 0x6334AF0
        public void WriteEndMinimized(){} // RVA: 0x6334B70
        public void WriteEndSlow(){} // RVA: 0x6334C50
        public void ValidateEnd(){} // RVA: 0x6334CB0
        public void WriteEndIndented(){} // RVA: 0x6334D90
        public void WriteNewLine(){} // RVA: 0x6334FA0
        public void UpdateBitStackOnStart(){} // RVA: 0x6335080
        public void Grow(){} // RVA: 0x6335120
        public void FirstCallToGetMemory(){} // RVA: 0x6335370
        public void SetFlagToAddListSeparatorBeforeNextItem(){} // RVA: 0x6335520
        public void WritePropertyName(){} // RVA: 0x6342DA0 | overloaded x15
        public void WriteString(){} // RVA: 0x633FD40 | overloaded x6
        public void WriteStringEscape(){} // RVA: 0x6349A90 | overloaded x4
        public void WriteStringEscapeProperty(){} // RVA: 0x633EB10 | overloaded x3
        public void WriteStringByOptions(){} // RVA: 0x6349BD0 | overloaded x5
        public void WriteStringMinimized(){} // RVA: 0x6349C40 | overloaded x5
        public void WriteStringIndented(){} // RVA: 0x6349E50 | overloaded x5
        public void WriteNumber(){} // RVA: 0x6341FA0 | overloaded x9
        public void WriteNumberEscape(){} // RVA: 0x6342090 | overloaded x4
        public void WriteNumberEscapeProperty(){} // RVA: 0x6342260 | overloaded x4
        public void WriteNumberByOptions(){} // RVA: 0x63426A0 | overloaded x4
        public void WriteNumberMinimized(){} // RVA: 0x6342710 | overloaded x4
        public void WriteNumberIndented(){} // RVA: 0x63429E0 | overloaded x4
        public void ValidatePropertyNameAndDepth(){} // RVA: 0x63394A0
        public void ValidateDepth(){} // RVA: 0x6339520
        public void ValidateWritingProperty(){} // RVA: 0x6339590 | overloaded x2
        public void WritePropertyNameMinimized(){} // RVA: 0x6339BC0 | overloaded x2
        public void WritePropertyNameIndented(){} // RVA: 0x6339DC0 | overloaded x2
        public void TranscodeAndWrite(){} // RVA: 0x633A0F0
        public void WriteNull(){} // RVA: 0x633A790 | overloaded x3
        public void WriteNullSection(){} // RVA: 0x633A3C0
        public void WriteLiteralHelper(){} // RVA: 0x633A5E0
        public void WriteBoolean(){} // RVA: 0x633AB60 | overloaded x2
        public void WriteLiteralEscape(){} // RVA: 0x633AD10
        public void WriteLiteralEscapeProperty(){} // RVA: 0x633AF10
        public void WriteLiteralByOptions(){} // RVA: 0x63479C0 | overloaded x3
        public void WriteLiteralMinimized(){} // RVA: 0x6347A30 | overloaded x3
        public void WriteLiteralSection(){} // RVA: 0x633BA20
        public void WriteLiteralIndented(){} // RVA: 0x6347BD0 | overloaded x3
        public void WritePropertyNameSection(){} // RVA: 0x633DA30
        public void WritePropertyNameHelper(){} // RVA: 0x633DB40
        public void WriteStringByOptionsPropertyName(){} // RVA: 0x633EF80 | overloaded x2
        public void WriteStringMinimizedPropertyName(){} // RVA: 0x633EFF0 | overloaded x2
        public void WriteStringIndentedPropertyName(){} // RVA: 0x633F3D0 | overloaded x2
        public void WritePropertyNameUnescaped(){} // RVA: 0x633EA00
        public void WriteStringPropertyNameSection(){} // RVA: 0x633F230
        public void WriteStringHelperEscapeValue(){} // RVA: 0x633FE20
        public void WriteStringEscapeValueOnly(){} // RVA: 0x6340080
        public void WriteStringEscapePropertyOrValue(){} // RVA: 0x63407E0
        public void WriteBase64StringValue(){} // RVA: 0x6343090
        public void WriteBase64ByOptions(){} // RVA: 0x6343180
        public void WriteBase64Minimized(){} // RVA: 0x63431F0
        public void WriteBase64Indented(){} // RVA: 0x6343400
        public void WriteStringValue(){} // RVA: 0x63498E0 | overloaded x7
        public void WriteStringValueMinimized(){} // RVA: 0x6346D20 | overloaded x3
        public void WriteStringValueIndented(){} // RVA: 0x6346F50 | overloaded x3
        public void WriteNumberValue(){} // RVA: 0x634A600 | overloaded x8
        public void WriteNumberValueMinimized(){} // RVA: 0x634A820 | overloaded x6
        public void WriteNumberValueIndented(){} // RVA: 0x634AA00 | overloaded x6
        public void WriteNumberValueAsString(){} // RVA: 0x634ACD0 | overloaded x5
        public void TryFormatDouble(){} // RVA: 0x6345120
        public void WriteFloatingPointConstant(){} // RVA: 0x63464B0 | overloaded x2
        public void TryFormatSingle(){} // RVA: 0x6345F70
        public void ValidateWritingValue(){} // RVA: 0x6347230
        public void Base64EncodeAndWrite(){} // RVA: 0x63472A0
        public void WriteNullValue(){} // RVA: 0x6347720
        public void WriteBooleanValue(){} // RVA: 0x63477F0
        public void WriteRawValue(){} // RVA: 0x6347E70
        public void WriteRawValueCore(){} // RVA: 0x6347F10
        public void WriteStringEscapeValue(){} // RVA: 0x634A160 | overloaded x2
        public void WriteNumberValueAsStringUnescaped(){} // RVA: 0x634A580
        public void .cctor(){} // RVA: 0x634B010
    }

    public class Utf8JsonWriterCache
    {
        // ── Methods ──
        public void RentWriterAndBuffer(){} // RVA: 0x68A95D0
        public void RentWriter(){} // RVA: 0x68A9980
        public void ReturnWriterAndBuffer(){} // RVA: 0x68A9B60
        public void ReturnWriter(){} // RVA: 0x68A9CF0
    }

    public class WriteStack
    {
        // ── Methods ──
        public void get_IsContinuation(){} // RVA: 0x632E830
        public void EnsurePushCapacity(){} // RVA: 0x632E840
        public void Initialize(){} // RVA: 0x632E950 | overloaded x2
        public void Push(){} // RVA: 0x632EB30
        public void Pop(){} // RVA: 0x632EDE0
        public void AddCompletedAsyncDisposable(){} // RVA: 0x632F010
        public void DisposePendingDisposablesOnException(){} // RVA: 0x632F150
        public void PropertyPath(){} // RVA: 0x632F240
        public void <DisposePendingDisposablesOnException>g__DisposeFrame|21_0(){} // RVA: 0x632F390
        public void <PropertyPath>g__AppendStackFrame|23_0(){} // RVA: 0x632F410
        public void <PropertyPath>g__AppendPropertyName|23_1(){} // RVA: 0x632F530
    }

    public class WriteStackFrame
    {
        // ── Methods ──
        public void EndDictionaryElement(){} // RVA: 0x632F640
        public void EndProperty(){} // RVA: 0x632F650
        public void GetPolymorphicJsonPropertyInfo(){} // RVA: 0x632F750
        public void InitializeReEntry(){} // RVA: 0x632F760
    }

}