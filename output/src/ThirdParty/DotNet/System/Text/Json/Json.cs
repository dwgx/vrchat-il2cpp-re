// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json
// Classes: 10
// Methods: 494

namespace ThirdParty.DotNet.System.Text.Json
{
    public class Arguments`4 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class JsonElement : ValueType
    {
        public object TokenType;
        public object ValueKind;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E77C3C0
        public void get_TokenType(){} // RVA: 0x7FFD53EC38F0
        public void get_ValueKind(){} // RVA: 0x7FFD53EC3930
        public void get_Item(){} // RVA: 0x7FFD53EC3A20
        public void GetArrayLength(){} // RVA: 0x7FFD53EC3AA0
        public void GetProperty(){} // RVA: 0x7FFD53EC3B60
        public void TryGetProperty(){} // RVA: 0x7FFD53EC3D50 | overloaded x2
        public void GetBoolean(){} // RVA: 0x7FFD53EC3DD0
        public void GetString(){} // RVA: 0x7FFD53EC3E60
        public void TryGetInt16(){} // RVA: 0x7FFD53EC3ED0
        public void GetInt16(){} // RVA: 0x7FFD53EC3F40
        public void TryGetInt32(){} // RVA: 0x7FFD53EC3FF0
        public void GetInt32(){} // RVA: 0x7FFD53EC4060
        public void TryGetInt64(){} // RVA: 0x7FFD53EC40F0
        public void GetInt64(){} // RVA: 0x7FFD53EC4160
        public void TryGetDouble(){} // RVA: 0x7FFD53EC4200
        public void GetDouble(){} // RVA: 0x7FFD53EC4270
        public void TryGetSingle(){} // RVA: 0x7FFD53EC4310
        public void GetSingle(){} // RVA: 0x7FFD53EC4380
        public void TryGetDateTimeOffset(){} // RVA: 0x7FFD53EC4420
        public void GetDateTimeOffset(){} // RVA: 0x7FFD53EC4490
        public void GetPropertyName(){} // RVA: 0x7FFD53EC4530
        public void GetPropertyRawText(){} // RVA: 0x7FFD53EC45A0
        public void TextEqualsHelper(){} // RVA: 0x7FFD53EC46A0
        public void WriteTo(){} // RVA: 0x7FFD53EC4730
        public void EnumerateArray(){} // RVA: 0x7FFD53EC47E0
        public void EnumerateObject(){} // RVA: 0x7FFD53EC48C0
        public void ToString(){} // RVA: 0x7FFD53EC49A0
        public void Clone(){} // RVA: 0x7FFD53EC4BC0
        public void CheckValidInstance(){} // RVA: 0x7FFD53EC4C50
        public void ParseValue(){} // RVA: 0x7FFD53EC4CB0
    }

    public class JsonEncodedText : ValueType
    {
        public object EncodedUtf8Bytes;

        // ── Methods ──
        public void get_EncodedUtf8Bytes(){} // RVA: 0x7FFD53EC55E0
        public void .ctor(){} // RVA: 0x7FFD53EC5680
        public void Encode(){} // RVA: 0x7FFD53EC5980 | overloaded x2
        public void TranscodeAndEncode(){} // RVA: 0x7FFD53EC5A50
        public void EncodeHelper(){} // RVA: 0x7FFD53EC5F50
        public void Equals(){} // RVA: 0x7FFD53EC60E0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD53EC61C0
        public void GetHashCode(){} // RVA: 0x7FFD53EC6210
    }

    public class JsonHelpers : Object
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFD4E07D5A0
        public void GetSpan(){} // RVA: 0x7FFD53EB59C0
        public void IsInRangeInclusive(){} // RVA: 0x7FFD53EB5AB0 | overloaded x3
        public void IsDigit(){} // RVA: 0x7FFD53EB5AC0
        public void ReadWithVerify(){} // RVA: 0x7FFD53EB5AD0
        public void Utf8GetString(){} // RVA: 0x7FFD53EB5AE0
        public void CreateDictionaryFromCollection(){} // RVA: 0x7FFD4E078FF0
        public void IsFinite(){} // RVA: 0x7FFD53EB5BA0 | overloaded x2
        public void ValidateInt32MaxArrayLength(){} // RVA: 0x7FFD53EB5BD0
        public void IsValidDateTimeOffsetParseLength(){} // RVA: 0x7FFD53EB5BF0
        public void TryParseAsISO(){} // RVA: 0x7FFD53EB5E10 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFD53EB5F90
        public void TryGetNextTwoDigits(){} // RVA: 0x7FFD53EB66C0
        public void TryCreateDateTimeOffset(){} // RVA: 0x7FFD53EB68C0 | overloaded x2
        public void TryCreateDateTimeOffsetInterpretingDataAsLocalTime(){} // RVA: 0x7FFD53EB69D0
        public void TryCreateDateTime(){} // RVA: 0x7FFD53EB6AD0
        public void GetEscapedPropertyNameSection(){} // RVA: 0x7FFD53EB7260 | overloaded x2
        public void EscapeValue(){} // RVA: 0x7FFD53EB6F10
        public void GetPropertyNameSection(){} // RVA: 0x7FFD53EB7670
        public void .cctor(){} // RVA: 0x7FFD53EB7820
        public void <TryParseDateTimeOffset>g__ParseOffset|22_0(){} // RVA: 0x7FFD53EB79C0
    }

    public class JsonPropertyDictionary`1 : Object
    {
        public object List;
        public object Count;
        public object Keys;
        public object Values;
        public object IsReadOnly;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091610 | overloaded x2
        public void get_List(){} // RVA: 0x7FFD4E078E90
        public void Add(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void ContainsKey(){} // RVA: 0x7FFD4E079F60
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void TryGetValue(){} // RVA: 0x7FFD4E07D200
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void SetValue(){} // RVA: 0x7FFD4E2ADC40
        public void AddValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryAddValue(){} // RVA: 0x7FFD4E2ADC40
        public void CreateDictionaryIfThresholdMet(){} // RVA: 0x7FFD4E090980
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsProperty(){} // RVA: 0x7FFD4E079F60
        public void FindValueIndex(){} // RVA: 0x7FFD4E07E6B0
        public void TryGetPropertyValue(){} // RVA: 0x7FFD4E07D200
        public void TryRemoveProperty(){} // RVA: 0x7FFD4E07D200
        public void GetKeyCollection(){} // RVA: 0x7FFD4E078E90
        public void GetValueCollection(){} // RVA: 0x7FFD4E078E90
    }

    public class JsonReaderHelper : Object
    {
        // ── Methods ──
        public void ContainsSpecialCharacters(){} // RVA: 0x7FFD54417020
        public void CountNewLines(){} // RVA: 0x7FFD544170E0
        public void ToValueKind(){} // RVA: 0x7FFD53EC7210
        public void IsTokenTypePrimitive(){} // RVA: 0x7FFD53EC7270
        public void IsHexDigit(){} // RVA: 0x7FFD54417290
        public void TryGetEscapedDateTime(){} // RVA: 0x7FFD544172C0
        public void TryGetEscapedDateTimeOffset(){} // RVA: 0x7FFD544174E0
        public void TryGetEscapedGuid(){} // RVA: 0x7FFD54417710
        public void TryGetFloatingPointConstant(){} // RVA: 0x7FFD54417C70 | overloaded x2
        public void TryGetUnescapedBase64Bytes(){} // RVA: 0x7FFD54417F30
        public void GetUnescapedString(){} // RVA: 0x7FFD544183B0
        public void GetUnescapedSpan(){} // RVA: 0x7FFD544186F0
        public void UnescapeAndCompare(){} // RVA: 0x7FFD54418E20 | overloaded x2
        public void TryDecodeBase64InPlace(){} // RVA: 0x7FFD54419400
        public void TryDecodeBase64(){} // RVA: 0x7FFD544195B0
        public void TranscodeHelper(){} // RVA: 0x7FFD54419BB0 | overloaded x2
        public void ValidateUtf8(){} // RVA: 0x7FFD54419DA0
        public void GetUtf8ByteCount(){} // RVA: 0x7FFD54419EE0
        public void GetUtf8FromText(){} // RVA: 0x7FFD5441A020
        public void GetTextFromUtf8(){} // RVA: 0x7FFD5441A1F0
        public void Unescape(){} // RVA: 0x7FFD5441A480 | overloaded x2
        public void TryUnescape(){} // RVA: 0x7FFD5441A5F0 | overloaded x2
        public void TryEncodeToUtf8Bytes(){} // RVA: 0x7FFD5441B000
        public void IndexOfQuoteOrAnyControlOrBackSlash(){} // RVA: 0x7FFD5441B1A0
        public void LocateFirstFoundByte(){} // RVA: 0x7FFD53E784F0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5441B610
    }

    public class JsonSerializer : Object
    {
        public object IsReflectionEnabledByDefault;

        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFD5445D120 | overloaded x40
        public void ReadFromNode(){} // RVA: 0x7FFD4E2ADC40
        public void ReadFromNodeAsObject(){} // RVA: 0x7FFD54458640
        public void SerializeToDocument(){} // RVA: 0x7FFD54458AB0 | overloaded x5
        public void WriteDocument(){} // RVA: 0x7FFD4E078FF0
        public void WriteDocumentAsObject(){} // RVA: 0x7FFD54458C20
        public void SerializeToElement(){} // RVA: 0x7FFD54458F90 | overloaded x5
        public void WriteElement(){} // RVA: 0x7FFD4E2ADC40
        public void WriteElementAsObject(){} // RVA: 0x7FFD54459120
        public void SerializeToNode(){} // RVA: 0x7FFD544594C0 | overloaded x5
        public void WriteNode(){} // RVA: 0x7FFD4E078FF0
        public void WriteNodeAsObject(){} // RVA: 0x7FFD54459630
        public void get_IsReflectionEnabledByDefault(){} // RVA: 0x7FFD544597F0
        public void GetTypeInfo(){} // RVA: 0x7FFD54459A50 | overloaded x3
        public void ValidateInputType(){} // RVA: 0x7FFD54459AD0
        public void IsValidNumberHandlingValue(){} // RVA: 0x7FFD54459B60
        public void IsValidCreationHandlingValue(){} // RVA: 0x7FFD54459B70
        public void IsValidUnmappedMemberHandlingValue(){} // RVA: 0x7FFD54459B70
        public void UnboxOnRead(){} // RVA: 0x7FFD4E2ADC40
        public void UnboxOnWrite(){} // RVA: 0x7FFD4E2ADC40
        public void TryReadMetadata(){} // RVA: 0x7FFD54459B80
        public void IsMetadataPropertyName(){} // RVA: 0x7FFD5445A570
        public void GetMetadataPropertyName(){} // RVA: 0x7FFD5445A6D0
        public void TryHandleReferenceFromJsonElement(){} // RVA: 0x7FFD5445A990
        public void TryHandleReferenceFromJsonNode(){} // RVA: 0x7FFD5445B040
        public void ValidateMetadataForObjectConverter(){} // RVA: 0x7FFD5445B560
        public void ValidateMetadataForArrayConverter(){} // RVA: 0x7FFD5445B5F0
        public void ResolveReferenceId(){} // RVA: 0x7FFD4E2ADC40
        public void LookupProperty(){} // RVA: 0x7FFD5445B680
        public void GetPropertyName(){} // RVA: 0x7FFD5445B900
        public void CreateExtensionDataProperty(){} // RVA: 0x7FFD5445BA50
        public void ReadFromSpan(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ReadFromSpanAsObject(){} // RVA: 0x7FFD5445CC80 | overloaded x2
        public void DeserializeAsync(){} // RVA: 0x7FFD5445C350 | overloaded x5
        public void DeserializeAsyncEnumerable(){} // RVA: 0x7FFD4E08A9B0 | overloaded x2
        public void DeserializeAsyncEnumerableCore(){} // RVA: 0x7FFD4E08A9B0
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAsObject(){} // RVA: 0x7FFD5445D240
        public void GetReaderScopedToNextValue(){} // RVA: 0x7FFD5445D530
        public void SerializeToUtf8Bytes(){} // RVA: 0x7FFD5445DF80 | overloaded x5
        public void WriteBytes(){} // RVA: 0x7FFD4E078FF0
        public void WriteBytesAsObject(){} // RVA: 0x7FFD5445E0F0
        public void WriteMetadataForObject(){} // RVA: 0x7FFD5445E2B0
        public void WriteMetadataForCollection(){} // RVA: 0x7FFD5445E660
        public void TryGetReferenceForValue(){} // RVA: 0x7FFD5445E720
        public void SerializeAsync(){} // RVA: 0x7FFD5445EDA0 | overloaded x5
        public void Serialize(){} // RVA: 0x7FFD5445F7B0 | overloaded x15
        public void WriteString(){} // RVA: 0x7FFD4E078FF0
        public void WriteStringAsObject(){} // RVA: 0x7FFD5445F410
        public void .cctor(){} // RVA: 0x7FFD5445F960
        public void <UnboxOnRead>g__ThrowUnableToCastValue|50_0(){} // RVA: 0x7FFD4E090A10
        public void <TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(){} // RVA: 0x7FFD5445FF40
        public void <DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerable|90_0(){} // RVA: 0x7FFD4E08A9B0
        public void <DeserializeAsyncEnumerableCore>g__CreateQueueTypeInfo|90_1(){} // RVA: 0x7FFD4E078F80
    }

    public class JsonSerializerOptions : Object
    {
        public object CacheContext;
        public object ObjectTypeInfo;
        public object Converters;
        public object Default;
        public object TypeInfoResolver;
        public object TypeInfoResolverChain;
        public object AllowTrailingCommas;
        public object DefaultBufferSize;
        public object Encoder;
        public object DictionaryKeyPolicy;
        public object IgnoreNullValues;
        public object DefaultIgnoreCondition;
        public object NumberHandling;
        public object PreferredObjectCreationHandling;
        public object IgnoreReadOnlyProperties;
        public object IgnoreReadOnlyFields;
        public object IncludeFields;
        public object MaxDepth;
        public object EffectiveMaxDepth;
        public object PropertyNamingPolicy;
        public object PropertyNameCaseInsensitive;
        public object ReadCommentHandling;
        public object UnknownTypeHandling;
        public object UnmappedMemberHandling;
        public object WriteIndented;
        public object ReferenceHandler;
        public object CanUseFastPathSerializationLogic;
        public object IsReadOnly;
        public object DebuggerDisplay;

        // ── Methods ──
        public void get_CacheContext(){} // RVA: 0x7FFD54460A20
        public void GetTypeInfo(){} // RVA: 0x7FFD54460AD0
        public void TryGetTypeInfo(){} // RVA: 0x7FFD54460BB0
        public void GetTypeInfoInternal(){} // RVA: 0x7FFD54460CE0
        public void TryGetTypeInfoCached(){} // RVA: 0x7FFD54460ED0
        public void GetTypeInfoForRootType(){} // RVA: 0x7FFD544610D0
        public void TryGetPolymorphicTypeInfoForRootType(){} // RVA: 0x7FFD544611F0
        public void get_ObjectTypeInfo(){} // RVA: 0x7FFD544613F0
        public void ClearCaches(){} // RVA: 0x7FFD544614F0
        public void get_Converters(){} // RVA: 0x7FFD54461600
        public void GetConverter(){} // RVA: 0x7FFD544616B0
        public void GetConverterInternal(){} // RVA: 0x7FFD54461760
        public void GetConverterFromList(){} // RVA: 0x7FFD544617E0
        public void ExpandConverterFactory(){} // RVA: 0x7FFD54461900
        public void CheckConverterNullabilityIsSameAsPropertyType(){} // RVA: 0x7FFD544619B0
        public void get_Default(){} // RVA: 0x7FFD54461A80
        public void .ctor(){} // RVA: 0x7FFD54461E40 | overloaded x3
        public void TrackOptionsInstance(){} // RVA: 0x7FFD54461FB0
        public void AddContext(){} // RVA: 0x7FFD4E090980
        public void get_TypeInfoResolver(){} // RVA: 0x7FFD4E36F130
        public void set_TypeInfoResolver(){} // RVA: 0x7FFD54462070
        public void get_TypeInfoResolverChain(){} // RVA: 0x7FFD544621D0
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFD4E7EFDF0
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFD54462300
        public void get_DefaultBufferSize(){} // RVA: 0x7FFD4F7F9E20
        public void set_DefaultBufferSize(){} // RVA: 0x7FFD54462370
        public void get_Encoder(){} // RVA: 0x7FFD4E3E20E0
        public void set_Encoder(){} // RVA: 0x7FFD54462440
        public void get_DictionaryKeyPolicy(){} // RVA: 0x7FFD4E5F95E0
        public void set_DictionaryKeyPolicy(){} // RVA: 0x7FFD54462500
        public void get_IgnoreNullValues(){} // RVA: 0x7FFD4E7EAD30
        public void set_IgnoreNullValues(){} // RVA: 0x7FFD544625C0
        public void get_DefaultIgnoreCondition(){} // RVA: 0x7FFD4E558C20
        public void set_DefaultIgnoreCondition(){} // RVA: 0x7FFD544626A0
        public void get_NumberHandling(){} // RVA: 0x7FFD4E558CA0
        public void set_NumberHandling(){} // RVA: 0x7FFD544627E0
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x7FFD4FBDAB50
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x7FFD544628D0
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x7FFD4E7F2830
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x7FFD544629C0
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x7FFD4E7EAD40
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x7FFD54462A30
        public void get_IncludeFields(){} // RVA: 0x7FFD4E55E620
        public void set_IncludeFields(){} // RVA: 0x7FFD54462AA0
        public void get_MaxDepth(){} // RVA: 0x7FFD4F9B6EF0
        public void set_MaxDepth(){} // RVA: 0x7FFD54462B10
        public void get_EffectiveMaxDepth(){} // RVA: 0x7FFD4E640660
        public void set_EffectiveMaxDepth(){} // RVA: 0x7FFD4E8F2750
        public void get_PropertyNamingPolicy(){} // RVA: 0x7FFD4E5F0140
        public void set_PropertyNamingPolicy(){} // RVA: 0x7FFD54462BC0
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFD4E55DE70
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFD54462C80
        public void get_ReadCommentHandling(){} // RVA: 0x7FFD4E3FCC00
        public void set_ReadCommentHandling(){} // RVA: 0x7FFD54462CF0
        public void get_UnknownTypeHandling(){} // RVA: 0x7FFD4FBDAB70
        public void set_UnknownTypeHandling(){} // RVA: 0x7FFD54462DD0
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFD4EFB9E80
        public void set_UnmappedMemberHandling(){} // RVA: 0x7FFD54462E40
        public void get_WriteIndented(){} // RVA: 0x7FFD4EFFEE90
        public void set_WriteIndented(){} // RVA: 0x7FFD54462EB0
        public void get_ReferenceHandler(){} // RVA: 0x7FFD4E3BC730
        public void set_ReferenceHandler(){} // RVA: 0x7FFD54462F20
        public void get_CanUseFastPathSerializationLogic(){} // RVA: 0x7FFD54463000
        public void get_IsReadOnly(){} // RVA: 0x7FFD544630C0
        public void MakeReadOnly(){} // RVA: 0x7FFD54463100 | overloaded x2
        public void ConfigureForJsonSerializer(){} // RVA: 0x7FFD54463150
        public void GetTypeInfoNoCaching(){} // RVA: 0x7FFD54463580
        public void GetDocumentOptions(){} // RVA: 0x7FFD544637C0
        public void GetNodeOptions(){} // RVA: 0x7FFD4E55DE70
        public void GetReaderOptions(){} // RVA: 0x7FFD544638A0
        public void GetWriterOptions(){} // RVA: 0x7FFD54463950
        public void VerifyMutable(){} // RVA: 0x7FFD54463A20
        public void GetOrCreateDefaultOptionsInstance(){} // RVA: 0x7FFD54463A80
        public void get_DebuggerDisplay(){} // RVA: 0x7FFD54463C50
    }

    public class JsonWriterHelper : Object
    {
        public object AllowList;

        // ── Methods ──
        public void WriteIndentation(){} // RVA: 0x7FFD5446A8C0
        public void ValidateProperty(){} // RVA: 0x7FFD5446AAB0 | overloaded x2
        public void ValidateValue(){} // RVA: 0x7FFD5446AB00 | overloaded x2
        public void ValidateDouble(){} // RVA: 0x7FFD5446AA40
        public void ValidateSingle(){} // RVA: 0x7FFD5446AA80
        public void ValidatePropertyAndValue(){} // RVA: 0x7FFD5446ACF0 | overloaded x4
        public void ValidatePropertyNameLength(){} // RVA: 0x7FFD5446ADC0 | overloaded x2
        public void ValidateNumber(){} // RVA: 0x7FFD5446AE10
        public void IsValidUtf8String(){} // RVA: 0x7FFD5446B250
        public void ToUtf8(){} // RVA: 0x7FFD5446B360
        public void WriteDateTimeTrimmed(){} // RVA: 0x7FFD5446B530
        public void WriteDateTimeOffsetTrimmed(){} // RVA: 0x7FFD5446B780
        public void TrimDateTimeOffset(){} // RVA: 0x7FFD5446B9D0
        public void get_AllowList(){} // RVA: 0x7FFD5446BB80
        public void NeedsEscaping(){} // RVA: 0x7FFD5446BD70 | overloaded x3
        public void NeedsEscapingNoBoundsCheck(){} // RVA: 0x7FFD5446BC80
        public void GetMaxEscapedLength(){} // RVA: 0x7FFD53EE8440
        public void EscapeString(){} // RVA: 0x7FFD5446C830 | overloaded x4
        public void EscapeNextBytes(){} // RVA: 0x7FFD5446C440
        public void IsAsciiValue(){} // RVA: 0x7FFD5392EDF0 | overloaded x2
        public void EscapeNextChars(){} // RVA: 0x7FFD5446CD10
        public void WriteHex(){} // RVA: 0x7FFD5446CFE0
        public void .cctor(){} // RVA: 0x7FFD5446D0A0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(){} // RVA: 0x7FFD53EAE740
        public void GetArgumentOutOfRangeException_MaxDepthMustBePositive(){} // RVA: 0x7FFD53EAE7E0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFD53EAE890
        public void GetArgumentOutOfRangeException_CommentEnumMustBeInRange(){} // RVA: 0x7FFD53EAE900
        public void GetArgumentException(){} // RVA: 0x7FFD53EAE9B0
        public void ThrowArgumentException(){} // RVA: 0x7FFD53EAEBE0 | overloaded x2
        public void ThrowArgumentException_PropertyNameTooLarge(){} // RVA: 0x7FFD53EAEA40
        public void ThrowArgumentException_ValueTooLarge(){} // RVA: 0x7FFD53EAEAC0
        public void ThrowArgumentException_ValueNotSupported(){} // RVA: 0x7FFD53EAEB40
        public void ThrowInvalidOperationException_NeedLargerSpan(){} // RVA: 0x7FFD53EAEB90
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFD53EB0B60 | overloaded x3
        public void GetInvalidOperationException(){} // RVA: 0x7FFD53EB11F0 | overloaded x4
        public void ThrowInvalidOperationOrArgumentException(){} // RVA: 0x7FFD53EAEE30
        public void GetInvalidOperationException_ExpectedArray(){} // RVA: 0x7FFD53EAEF30
        public void GetInvalidOperationException_ExpectedObject(){} // RVA: 0x7FFD53EAEF80
        public void GetInvalidOperationException_ExpectedNumber(){} // RVA: 0x7FFD53EAEFD0
        public void GetInvalidOperationException_ExpectedBoolean(){} // RVA: 0x7FFD53EAF020
        public void GetInvalidOperationException_ExpectedString(){} // RVA: 0x7FFD53EAF070
        public void GetInvalidOperationException_CannotSkipOnPartial(){} // RVA: 0x7FFD53EAF0C0
        public void GetJsonElementWrongTypeException(){} // RVA: 0x7FFD53EAF540 | overloaded x4
        public void ThrowJsonReaderException(){} // RVA: 0x7FFD53EAF640
        public void GetJsonReaderException(){} // RVA: 0x7FFD53EAF690
        public void IsPrintable(){} // RVA: 0x7FFD53EAFA40
        public void GetPrintableString(){} // RVA: 0x7FFD53EAFA50
        public void GetResourceString(){} // RVA: 0x7FFD53EB1340 | overloaded x2
        public void ThrowArgumentException_InvalidUTF8(){} // RVA: 0x7FFD53EB0B90
        public void ThrowArgumentException_InvalidUTF16(){} // RVA: 0x7FFD53EB0D80
        public void ThrowInvalidOperationException_ReadInvalidUTF16(){} // RVA: 0x7FFD53EB0EE0 | overloaded x2
        public void GetInvalidOperationException_ReadInvalidUTF8(){} // RVA: 0x7FFD53EB0F30
        public void GetArgumentException_ReadInvalidUTF16(){} // RVA: 0x7FFD53EB1060
        public void ThrowOutOfMemoryException(){} // RVA: 0x7FFD53EB12A0
        public void GetFormatException(){} // RVA: 0x7FFD53EB1E50 | overloaded x3
        public void GetInvalidOperationException_ExpectedChar(){} // RVA: 0x7FFD53EB21B0
        public void ThrowArgumentException_NodeValueNotAllowed(){} // RVA: 0x7FFD53EB2200
        public void ThrowArgumentException_NodeArrayTooSmall(){} // RVA: 0x7FFD53EB2270
        public void ThrowArgumentOutOfRangeException_NodeArrayIndexNegative(){} // RVA: 0x7FFD53EB22E0
        public void ThrowArgumentException_DuplicateKey(){} // RVA: 0x7FFD53EB2350
        public void ThrowInvalidOperationException_NodeAlreadyHasParent(){} // RVA: 0x7FFD53EB23C0
        public void ThrowInvalidOperationException_NodeCycleDetected(){} // RVA: 0x7FFD53EB2430
        public void ThrowNotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x7FFD53EB24A0
        public void NotSupportedException_NodeCollectionIsReadOnly(){} // RVA: 0x7FFD53EB24D0
        public void ThrowNotSupportedException_SerializationNotSupported(){} // RVA: 0x7FFD53EB25B0
        public void ThrowNotSupportedException_TypeRequiresAsyncSerialization(){} // RVA: 0x7FFD53EB2630
        public void ThrowNotSupportedException_ConstructorMaxOf64Parameters(){} // RVA: 0x7FFD53EB26B0
        public void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(){} // RVA: 0x7FFD53EB2730
        public void ThrowJsonException_DeserializeUnableToConvertValue(){} // RVA: 0x7FFD53EB27D0
        public void ThrowInvalidCastException_DeserializeUnableToAssignValue(){} // RVA: 0x7FFD53EB2860
        public void ThrowInvalidOperationException_DeserializeUnableToAssignNull(){} // RVA: 0x7FFD53EB28E0
        public void ThrowJsonException_SerializationConverterRead(){} // RVA: 0x7FFD53EB2960
        public void ThrowJsonException_SerializationConverterWrite(){} // RVA: 0x7FFD53EB29F0
        public void ThrowJsonException_SerializerCycleDetected(){} // RVA: 0x7FFD53EB2A80
        public void ThrowJsonException(){} // RVA: 0x7FFD53EB2B30
        public void ThrowInvalidOperationException_CannotSerializeInvalidType(){} // RVA: 0x7FFD53EB2B90
        public void ThrowInvalidOperationException_SerializationConverterNotCompatible(){} // RVA: 0x7FFD53EB2CB0
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(){} // RVA: 0x7FFD53EB2D30
        public void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x7FFD53EB2E10
        public void ThrowInvalidOperationException_SerializerOptionsImmutable(){} // RVA: 0x7FFD53EB2F00
        public void ThrowInvalidOperationException_SerializerPropertyNameConflict(){} // RVA: 0x7FFD53EB2F80
        public void ThrowInvalidOperationException_SerializerPropertyNameNull(){} // RVA: 0x7FFD53EB3020
        public void ThrowInvalidOperationException_NamingPolicyReturnNull(){} // RVA: 0x7FFD53EB30F0
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(){} // RVA: 0x7FFD53EB3170
        public void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(){} // RVA: 0x7FFD53EB31F0
        public void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(){} // RVA: 0x7FFD53EB3270
        public void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(){} // RVA: 0x7FFD53EB33B0
        public void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x7FFD53EB3430
        public void ThrowInvalidOperationException_JsonIncludeOnNonPublicInvalid(){} // RVA: 0x7FFD53EB34E0
        public void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x7FFD53EB3560
        public void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(){} // RVA: 0x7FFD53EB35E0
        public void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(){} // RVA: 0x7FFD53EB36A0
        public void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotHonored(){} // RVA: 0x7FFD53EB3760
        public void ReThrowWithPath(){} // RVA: 0x7FFD53EB3840
        public void AddJsonExceptionInformation(){} // RVA: 0x7FFD53EB38B0
        public void ThrowInvalidOperationException_SerializationDuplicateAttribute(){} // RVA: 0x7FFD53EB3AF0
        public void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x7FFD53EB3C60
        public void ThrowNotSupportedException(){} // RVA: 0x7FFD53EB40E0 | overloaded x2
        public void ThrowNotSupportedException_DeserializeNoConstructor(){} // RVA: 0x7FFD53EB42B0
        public void ThrowNotSupportedException_CannotPopulateCollection(){} // RVA: 0x7FFD53EB4390
        public void ThrowJsonException_MetadataValuesInvalidToken(){} // RVA: 0x7FFD53EB4430
        public void ThrowJsonException_MetadataReferenceNotFound(){} // RVA: 0x7FFD53EB44B0
        public void ThrowJsonException_MetadataValueWasNotString(){} // RVA: 0x7FFD53EB4590 | overloaded x2
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x7FFD53EB4660 | overloaded x2
        public void ThrowJsonException_MetadataIdIsNotFirstProperty(){} // RVA: 0x7FFD53EB46A0
        public void ThrowJsonException_MetadataMissingIdBeforeValues(){} // RVA: 0x7FFD53EB4720
        public void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x7FFD53EB47A0
        public void ThrowJsonException_MetadataDuplicateIdFound(){} // RVA: 0x7FFD53EB48D0
        public void ThrowJsonException_MetadataInvalidReferenceToValueType(){} // RVA: 0x7FFD53EB4930
        public void ThrowJsonException_MetadataPreservedArrayInvalidProperty(){} // RVA: 0x7FFD53EB4990
        public void ThrowJsonException_MetadataPreservedArrayValuesNotFound(){} // RVA: 0x7FFD53EB4B50
        public void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(){} // RVA: 0x7FFD53EB4BF0
        public void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x7FFD53EB4C50
        public void ThrowUnexpectedMetadataException(){} // RVA: 0x7FFD53EB4CE0
        public void ThrowInvalidOperationException_JsonSerializerOptionsAlreadyBoundToContext(){} // RVA: 0x7FFD53EB4E20
        public void ThrowNotSupportedException_BuiltInConvertersNotRooted(){} // RVA: 0x7FFD53EB4EB0
        public void ThrowNotSupportedException_NoMetadataForType(){} // RVA: 0x7FFD53EB4F30
        public void ThrowInvalidOperationException_NoMetadataForTypeProperties(){} // RVA: 0x7FFD53EB4FB0
        public void ThrowInvalidOperationException_NoMetadataForTypeCtorParams(){} // RVA: 0x7FFD53EB5050
        public void ThrowMissingMemberException_MissingFSharpCoreMember(){} // RVA: 0x7FFD53EB50F0
    }

}