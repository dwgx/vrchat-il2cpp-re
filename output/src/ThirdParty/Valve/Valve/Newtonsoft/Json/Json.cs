// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 26
// Methods: 421

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
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
    }

    public class JsonConstructorAttribute
    {
    }

    public class JsonContainerAttribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x2F8380
        public void get_ItemConverterParameters(){} // RVA: 0x2E07C0
        public void get_NamingStrategyType(){} // RVA: 0x35A740
        public void get_NamingStrategyParameters(){} // RVA: 0x358730
        public void get_NamingStrategyInstance(){} // RVA: 0x30B0C0
        public void set_NamingStrategyInstance(){} // RVA: 0x30B0D0
    }

    public class JsonConvert
    {
        public object Stream;

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x750CF60
        public void ToString(){} // RVA: 0x750DB60 | overloaded x8
        public void EnsureFloatFormat(){} // RVA: 0x750D350
        public void EnsureDecimalPlace(){} // RVA: 0x750D7B0 | overloaded x2
        public void SerializeObject(){} // RVA: 0x750DD30 | overloaded x2
        public void SerializeObjectInternal(){} // RVA: 0x750DE00
        public void DeserializeObject(){} // RVA: 0x750E0F0 | overloaded x3
        public void .cctor(){} // RVA: 0x750E3C0
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
    }

    public class JsonConverterCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750E780
    }

    public class JsonDictionaryAttribute
    {
    }

    public class JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750E8E0 | overloaded x4
    }

    public class JsonExtensionDataAttribute
    {
        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x3A75E0
        public void get_ReadData(){} // RVA: 0x543460
    }

    public class JsonIgnoreAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonObjectAttribute
    {
        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x59C540
    }

    public class JsonPosition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750E960
        public void CalculateLength(){} // RVA: 0x750EA20
        public void WriteTo(){} // RVA: 0x750EAC0
        public void TypeHasIndex(){} // RVA: 0x5F59710
        public void BuildPath(){} // RVA: 0x750EC40
        public void FormatMessage(){} // RVA: 0x750F200
        public void .cctor(){} // RVA: 0x750F570
    }

    public class JsonPropertyAttribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x37B370
        public void get_ItemConverterParameters(){} // RVA: 0x358D50
        public void get_NamingStrategyType(){} // RVA: 0x3A5590
        public void get_NamingStrategyParameters(){} // RVA: 0x4C7C50
        public void get_PropertyName(){} // RVA: 0x462D00
    }

    public class JsonReader
    {
        // ── Methods ──
        public void get_CurrentState(){} // RVA: 0xCEF5B0
        public void get_CloseInput(){} // RVA: 0x359320
        public void set_CloseInput(){} // RVA: 0x359330
        public void get_SupportMultipleContent(){} // RVA: 0x5AAEFD0
        public void set_SupportMultipleContent(){} // RVA: 0x5AAEFE0
        public void get_DateTimeZoneHandling(){} // RVA: 0x37E0C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x750F650
        public void get_DateParseHandling(){} // RVA: 0x9EAB90
        public void set_DateParseHandling(){} // RVA: 0x750F6C0
        public void get_FloatParseHandling(){} // RVA: 0x5A54D0
        public void set_FloatParseHandling(){} // RVA: 0x750F730
        public void get_DateFormatString(){} // RVA: 0x37B370
        public void set_DateFormatString(){} // RVA: 0x37B380
        public void get_MaxDepth(){} // RVA: 0x36B37B0
        public void set_MaxDepth(){} // RVA: 0x750F7A0
        public void get_TokenType(){} // RVA: 0x32A5C0
        public void get_Value(){} // RVA: 0x2E07C0
        public void get_ValueType(){} // RVA: 0x750F860
        public void get_Depth(){} // RVA: 0x750F880
        public void get_Path(){} // RVA: 0x750F900
        public void get_Culture(){} // RVA: 0x750FA80
        public void set_Culture(){} // RVA: 0x305200
        public void GetPosition(){} // RVA: 0x750FAE0
        public void .ctor(){} // RVA: 0x750FBA0
        public void Push(){} // RVA: 0x750FBC0
        public void Pop(){} // RVA: 0x750FF10
        public void Peek(){} // RVA: 0x791DC0
        public void Read(){} // RVA: 0xDBE0
        public void ReadAsInt32(){} // RVA: 0x75100C0
        public void ReadInt32String(){} // RVA: 0x7510440
        public void ReadAsString(){} // RVA: 0x75107F0
        public void ReadAsBytes(){} // RVA: 0x7510BE0
        public void ReadArrayIntoByteArray(){} // RVA: 0x75112E0
        public void ReadAsDouble(){} // RVA: 0x75116E0
        public void ReadDoubleString(){} // RVA: 0x7511A70
        public void ReadAsBoolean(){} // RVA: 0x7511DC0
        public void ReadBooleanString(){} // RVA: 0x7512100
        public void ReadAsDecimal(){} // RVA: 0x7512500
        public void ReadDecimalString(){} // RVA: 0x75128C0
        public void ReadAsDateTime(){} // RVA: 0x7512C70
        public void ReadDateTimeString(){} // RVA: 0x7513010
        public void ReadAsDateTimeOffset(){} // RVA: 0x75134A0
        public void ReadDateTimeOffsetString(){} // RVA: 0x7513830
        public void ReaderReadAndAssert(){} // RVA: 0x7513C70
        public void CreateUnexpectedEndException(){} // RVA: 0x7513CC0
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7513D10
        public void Skip(){} // RVA: 0x75140C0
        public void SetToken(){} // RVA: 0x75141C0 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x7514400
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x5F61010
        public void ValidateEnd(){} // RVA: 0x7514440
        public void SetStateBasedOnCurrent(){} // RVA: 0x7514600
        public void SetFinished(){} // RVA: 0x7514710
        public void GetTypeForCloseToken(){} // RVA: 0x7514730
        public void System.IDisposable.Dispose(){} // RVA: 0x7514820
        public void Dispose(){} // RVA: 0x7514890
        public void Close(){} // RVA: 0x5F614A0
        public void ReadAndAssert(){} // RVA: 0x75148C0
        public void ReadAndMoveToContent(){} // RVA: 0x7514920
        public void MoveToContent(){} // RVA: 0x7514980
        public void GetContentToken(){} // RVA: 0x75149E0
    }

    public class JsonReaderException
    {
        // ── Methods ──
        public void set_LineNumber(){} // RVA: 0xF02F80
        public void set_LinePosition(){} // RVA: 0x8DF350
        public void set_Path(){} // RVA: 0x9AA650
        public void .ctor(){} // RVA: 0x7514AB0 | overloaded x3
        public void Create(){} // RVA: 0x7514D30 | overloaded x3
    }

    public class JsonRequiredAttribute
    {
    }

    public class JsonSerializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750E8E0 | overloaded x4
        public void Create(){} // RVA: 0x7515000 | overloaded x3
    }

    public class JsonSerializer
    {
        // ── Methods ──
        public void add_Error(){} // RVA: 0x75150C0
        public void remove_Error(){} // RVA: 0x75151C0
        public void set_ReferenceResolver(){} // RVA: 0x75152C0
        public void set_Binder(){} // RVA: 0x7515390
        public void get_TraceWriter(){} // RVA: 0x358730
        public void set_TraceWriter(){} // RVA: 0x358740
        public void set_EqualityComparer(){} // RVA: 0x4354D0
        public void set_TypeNameHandling(){} // RVA: 0x7515460
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x75154D0
        public void set_PreserveReferencesHandling(){} // RVA: 0x7515540
        public void set_ReferenceLoopHandling(){} // RVA: 0x75155B0
        public void set_MissingMemberHandling(){} // RVA: 0x7515620
        public void set_NullValueHandling(){} // RVA: 0x7515690
        public void set_DefaultValueHandling(){} // RVA: 0x7515700
        public void set_ObjectCreationHandling(){} // RVA: 0x7515770
        public void set_ConstructorHandling(){} // RVA: 0x75157E0
        public void get_MetadataPropertyHandling(){} // RVA: 0x4C6670
        public void set_MetadataPropertyHandling(){} // RVA: 0x7515850
        public void get_Converters(){} // RVA: 0x75158C0
        public void get_ContractResolver(){} // RVA: 0x35A740
        public void set_ContractResolver(){} // RVA: 0x75159A0
        public void get_Context(){} // RVA: 0x36ABF00
        public void set_Context(){} // RVA: 0x5F645D0
        public void get_Formatting(){} // RVA: 0x7515A60
        public void set_Formatting(){} // RVA: 0x7515AC0
        public void get_CheckAdditionalContent(){} // RVA: 0x7515B20
        public void set_CheckAdditionalContent(){} // RVA: 0x7515B80
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7515BE0
        public void .ctor(){} // RVA: 0x7515C30
        public void Create(){} // RVA: 0x7515F20 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7516090 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x75160D0
        public void Deserialize(){} // RVA: 0x7516C90 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7516CB0
        public void SetupReader(){} // RVA: 0x7516FB0
        public void ResetReader(){} // RVA: 0x75175D0
        public void Serialize(){} // RVA: 0x75178A0 | overloaded x2
        public void SerializeInternal(){} // RVA: 0x75178D0
        public void GetReferenceResolver(){} // RVA: 0x7518090
        public void GetMatchingConverter(){} // RVA: 0x7518140 | overloaded x2
        public void OnError(){} // RVA: 0x5F678F0
    }

    public class JsonSerializerSettings
    {
        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7518210
        public void get_MissingMemberHandling(){} // RVA: 0x7518270
        public void get_ObjectCreationHandling(){} // RVA: 0x75182D0
        public void get_NullValueHandling(){} // RVA: 0x7518330
        public void set_NullValueHandling(){} // RVA: 0x7518390
        public void get_DefaultValueHandling(){} // RVA: 0x75183F0
        public void get_Converters(){} // RVA: 0xA96D30
        public void set_Converters(){} // RVA: 0x35E8A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7518450
        public void get_TypeNameHandling(){} // RVA: 0x75184B0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7518510
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7518570
        public void get_ConstructorHandling(){} // RVA: 0x75185D0
        public void get_ContractResolver(){} // RVA: 0x35E900
        public void get_EqualityComparer(){} // RVA: 0x35E970
        public void get_ReferenceResolverProvider(){} // RVA: 0x3482A0
        public void get_TraceWriter(){} // RVA: 0x7F7DB0
        public void get_Binder(){} // RVA: 0xA94E10
        public void get_Error(){} // RVA: 0xA902E0
        public void get_Context(){} // RVA: 0x7518630
        public void .cctor(){} // RVA: 0x7518700
        public void .ctor(){} // RVA: 0x7518820
    }

    public class JsonTextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75188E0
        public void EnsureBufferNotEmpty(){} // RVA: 0x75189C0
        public void OnNewLine(){} // RVA: 0x7518B10
        public void ParseString(){} // RVA: 0x7518B20
        public void BlockCopyChars(){} // RVA: 0x5F6FCA0
        public void ShiftBufferIfNeeded(){} // RVA: 0x75191C0
        public void ReadData(){} // RVA: 0x75192B0 | overloaded x2
        public void EnsureChars(){} // RVA: 0x7519650
        public void ReadChars(){} // RVA: 0x7519700
        public void Read(){} // RVA: 0x7519790
        public void ReadAsInt32(){} // RVA: 0x7519B10
        public void ReadAsDateTime(){} // RVA: 0x7519C00
        public void ReadAsString(){} // RVA: 0x7519CF0
        public void ReadAsBytes(){} // RVA: 0x7519D60
        public void ReadStringValue(){} // RVA: 0x751A790
        public void CreateUnexpectedCharacterException(){} // RVA: 0x751B700
        public void ReadAsBoolean(){} // RVA: 0x751B810
        public void ProcessValueComma(){} // RVA: 0x751C610
        public void ReadNumberValue(){} // RVA: 0x751C670
        public void ReadAsDateTimeOffset(){} // RVA: 0x751D250
        public void ReadAsDecimal(){} // RVA: 0x751D350
        public void ReadAsDouble(){} // RVA: 0x751D450
        public void HandleNull(){} // RVA: 0x751D540
        public void ReadFinished(){} // RVA: 0x751D650
        public void ReadNullChar(){} // RVA: 0x751D800
        public void EnsureBuffer(){} // RVA: 0x751D850
        public void ReadStringIntoBuffer(){} // RVA: 0x751D960
        public void WriteCharToBuffer(){} // RVA: 0x751E020
        public void ParseUnicode(){} // RVA: 0x751E0D0
        public void ReadNumberIntoBuffer(){} // RVA: 0x751E360
        public void ClearRecentString(){} // RVA: 0x751E590
        public void ParsePostValue(){} // RVA: 0x751E5B0
        public void ParseObject(){} // RVA: 0x751E9E0
        public void ParseProperty(){} // RVA: 0x751EBF0
        public void ValidIdentifierChar(){} // RVA: 0x751EF80
        public void ParseUnquotedProperty(){} // RVA: 0x751EFF0
        public void ParseValue(){} // RVA: 0x751F3A0
        public void ProcessLineFeed(){} // RVA: 0x751FFE0
        public void ProcessCarriageReturn(){} // RVA: 0x7520000
        public void EatWhitespace(){} // RVA: 0x75200D0
        public void ParseConstructor(){} // RVA: 0x7520210
        public void ParseNumber(){} // RVA: 0x7520750
        public void ParseComment(){} // RVA: 0x7521FA0
        public void EndComment(){} // RVA: 0x7522310
        public void MatchValue(){} // RVA: 0x75223D0
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x75224C0
        public void IsSeparator(){} // RVA: 0x7522770
        public void ParseTrue(){} // RVA: 0x75228C0
        public void ParseNull(){} // RVA: 0x7522A40
        public void ParseUndefined(){} // RVA: 0x7522B90
        public void ParseFalse(){} // RVA: 0x7522CE0
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7522F10
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7523220
        public void ParseNumberNaN(){} // RVA: 0x7523530
        public void Close(){} // RVA: 0x7523840
        public void HasLineInfo(){} // RVA: 0x3C2850
        public void get_LineNumber(){} // RVA: 0x75239C0
        public void get_LinePosition(){} // RVA: 0x7523A10
    }

    public class JsonTextWriter
    {
        // ── Methods ──
        public void get_Base64Encoder(){} // RVA: 0x7523A20
        public void get_QuoteChar(){} // RVA: 0x5F98F80
        public void .ctor(){} // RVA: 0x7523C20
        public void Close(){} // RVA: 0x7523D40
        public void WriteStartObject(){} // RVA: 0x7523E50
        public void WriteStartArray(){} // RVA: 0x7523EA0
        public void WriteStartConstructor(){} // RVA: 0x7523EF0
        public void WriteEnd(){} // RVA: 0x7523FB0
        public void WritePropertyName(){} // RVA: 0x7524150 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7524280
        public void UpdateCharEscapeFlags(){} // RVA: 0x7524290
        public void WriteIndent(){} // RVA: 0x7524360
        public void WriteValueDelimiter(){} // RVA: 0x7524550
        public void WriteIndentSpace(){} // RVA: 0x7524580
        public void WriteValueInternal(){} // RVA: 0x75245B0
        public void WriteNull(){} // RVA: 0x75245E0
        public void WriteUndefined(){} // RVA: 0x7524680
        public void WriteRaw(){} // RVA: 0x75245B0
        public void WriteValue(){} // RVA: 0x7525E90 | overloaded x22
        public void WriteEscapedString(){} // RVA: 0x75247F0
        public void WriteComment(){} // RVA: 0x7525FA0
        public void EnsureWriteBuffer(){} // RVA: 0x7526070
        public void WriteIntegerValue(){} // RVA: 0x75261F0 | overloaded x2
    }

    public class JsonWriter
    {
        // ── Methods ──
        public void BuildStateArray(){} // RVA: 0x7526310
        public void .cctor(){} // RVA: 0x7526780
        public void get_CloseOutput(){} // RVA: 0x4A6500
        public void set_CloseOutput(){} // RVA: 0x4A78C0
        public void get_Top(){} // RVA: 0x7526F50
        public void get_WriteState(){} // RVA: 0x7526FB0
        public void get_ContainerPath(){} // RVA: 0x75270C0
        public void get_Path(){} // RVA: 0x7527160
        public void get_Formatting(){} // RVA: 0x4C6670
        public void set_Formatting(){} // RVA: 0x75272E0
        public void get_DateFormatHandling(){} // RVA: 0x891AF0
        public void set_DateFormatHandling(){} // RVA: 0x7527350
        public void get_DateTimeZoneHandling(){} // RVA: 0x37E080
        public void set_DateTimeZoneHandling(){} // RVA: 0x75273C0
        public void get_StringEscapeHandling(){} // RVA: 0x37E0A0
        public void set_StringEscapeHandling(){} // RVA: 0x7527430
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x2DD310
        public void get_FloatFormatHandling(){} // RVA: 0x37E0C0
        public void set_FloatFormatHandling(){} // RVA: 0x75274B0
        public void get_DateFormatString(){} // RVA: 0x37E0E0
        public void set_DateFormatString(){} // RVA: 0x4354D0
        public void get_Culture(){} // RVA: 0x7527520
        public void set_Culture(){} // RVA: 0x3A5510
        public void .ctor(){} // RVA: 0x7527580
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x5FB2B10
        public void Push(){} // RVA: 0x75275A0
        public void Pop(){} // RVA: 0x7527750
        public void Peek(){} // RVA: 0x5BED50
        public void Close(){} // RVA: 0x75278C0
        public void WriteStartObject(){} // RVA: 0x7527930
        public void WriteEndObject(){} // RVA: 0x7527940
        public void WriteStartArray(){} // RVA: 0x7527950
        public void WriteEndArray(){} // RVA: 0x7527960
        public void WriteStartConstructor(){} // RVA: 0x7527970
        public void WriteEndConstructor(){} // RVA: 0x7527980
        public void WritePropertyName(){} // RVA: 0x6048030 | overloaded x2
        public void WriteEnd(){} // RVA: 0x2DD310 | overloaded x3
        public void WriteToken(){} // RVA: 0x7528660 | overloaded x4
        public void WriteConstructorDate(){} // RVA: 0x75288F0
        public void AutoCompleteAll(){} // RVA: 0x75278C0
        public void GetCloseTokenForType(){} // RVA: 0x7528CA0
        public void AutoCompleteClose(){} // RVA: 0x7528D50
        public void WriteIndent(){} // RVA: 0x2DD310
        public void WriteValueDelimiter(){} // RVA: 0x2DD310
        public void WriteIndentSpace(){} // RVA: 0x2DD310
        public void AutoComplete(){} // RVA: 0x75291A0
        public void WriteNull(){} // RVA: 0x75293D0
        public void WriteUndefined(){} // RVA: 0x75293F0
        public void WriteRaw(){} // RVA: 0x2DD310
        public void WriteRawValue(){} // RVA: 0x7529410
        public void WriteValue(){} // RVA: 0x752A030 | overloaded x38
        public void WriteComment(){} // RVA: 0x7529F80
        public void System.IDisposable.Dispose(){} // RVA: 0x7529F90
        public void Dispose(){} // RVA: 0x752A000
        public void CreateUnsupportedTypeException(){} // RVA: 0x752B350
        public void InternalWriteEnd(){} // RVA: 0x752B450
        public void InternalWritePropertyName(){} // RVA: 0x7527990
        public void InternalWriteRaw(){} // RVA: 0x2DD310
        public void InternalWriteStart(){} // RVA: 0x752B460
        public void InternalWriteValue(){} // RVA: 0x752B620
        public void InternalWriteComment(){} // RVA: 0x7529F80
    }

    public class JsonWriterException
    {
        // ── Methods ──
        public void set_Path(){} // RVA: 0xB54600
        public void .ctor(){} // RVA: 0x752B6A0 | overloaded x3
        public void Create(){} // RVA: 0x752B830 | overloaded x2
    }

}