// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 22
// Methods: 321

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7A7E00740
        public void Return(){} // RVA: 0x7A7E18800
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7A7E01900
        public void get_LineNumber(){} // RVA: 0x7A7E00710
        public void get_LinePosition(){} // RVA: 0x7A7E00710
    }

    public class JsonContainerAttribute : Attribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7A80F2570
        public void get_ItemConverterParameters(){} // RVA: 0x7A80DA7B0
        public void get_NamingStrategyType(){} // RVA: 0x7A8154D80
        public void get_NamingStrategyParameters(){} // RVA: 0x7A8152D80
        public void get_NamingStrategyInstance(){} // RVA: 0x7A81052C0
        public void set_NamingStrategyInstance(){} // RVA: 0x7A81052D0
    }

    public class JsonConvert : Object
    {
        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7AF2ECFD0
        public void ToString(){} // RVA: 0x7AF2EDB90
        public void EnsureFloatFormat(){} // RVA: 0x7AF2ED3A0
        public void EnsureDecimalPlace(){} // RVA: 0x7AF2ED7E0
        public void SerializeObject(){} // RVA: 0x7AF2EDD60
        public void SerializeObjectInternal(){} // RVA: 0x7AF2EDE30
        public void DeserializeObject(){} // RVA: 0x7AF2EE120
        public void .cctor(){} // RVA: 0x7AF2EE3F0
    }

    public class JsonConverter : Object
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7A7E1DDC0
        public void ReadJson(){} // RVA: 0x7A7E12DE0
        public void CanConvert(){} // RVA: 0x7A7E019D0
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanWrite(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonConverterAttribute : Attribute
    {
        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7A80F2570
        public void get_ConverterParameters(){} // RVA: 0x7A80DA7B0
    }

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2EE7B0
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2EE910
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7A81A2200
        public void get_ReadData(){} // RVA: 0x7A82FBFB0
    }

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7A8355950
    }

    public class JsonPosition : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F0DCE0
        public void CalculateLength(){} // RVA: 0x7A7F0DCF0
        public void WriteTo(){} // RVA: 0x7A7F0DD00
        public void TypeHasIndex(){} // RVA: 0x7ADD47E30
        public void BuildPath(){} // RVA: 0x7AF2EEC70
        public void FormatMessage(){} // RVA: 0x7AF2EF240
        public void .cctor(){} // RVA: 0x7AF2EF5B0
    }

    public class JsonPropertyAttribute : Attribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7A8175DF0
        public void get_ItemConverterParameters(){} // RVA: 0x7A8153390
        public void get_NamingStrategyType(){} // RVA: 0x7A81A00E0
        public void get_NamingStrategyParameters(){} // RVA: 0x7A82C2060
        public void get_PropertyName(){} // RVA: 0x7A825E100
    }

    public class JsonReader : Object
    {
        // ── Methods ──
        public void get_CurrentState(){} // RVA: 0x7A8AB15F0
        public void get_CloseInput(){} // RVA: 0x7A8153980
        public void set_CloseInput(){} // RVA: 0x7A8153990
        public void get_SupportMultipleContent(){} // RVA: 0x7AD89C540
        public void set_SupportMultipleContent(){} // RVA: 0x7AD89C550
        public void get_DateTimeZoneHandling(){} // RVA: 0x7A8178B70
        public void set_DateTimeZoneHandling(){} // RVA: 0x7AF2EF690
        public void get_DateParseHandling(){} // RVA: 0x7A87A7DA0
        public void set_DateParseHandling(){} // RVA: 0x7AF2EF700
        public void get_FloatParseHandling(){} // RVA: 0x7A835E820
        public void set_FloatParseHandling(){} // RVA: 0x7AF2EF770
        public void get_DateFormatString(){} // RVA: 0x7A8175DF0
        public void set_DateFormatString(){} // RVA: 0x7A8175E00
        public void get_MaxDepth(){} // RVA: 0x7AB498B60
        public void set_MaxDepth(){} // RVA: 0x7AF2EF7E0
        public void get_TokenType(){} // RVA: 0x7A8124910
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void get_ValueType(){} // RVA: 0x7AF2EF8A0
        public void get_Depth(){} // RVA: 0x7AF2EF8C0
        public void get_Path(){} // RVA: 0x7AF2EF940
        public void get_Culture(){} // RVA: 0x7AF2EFAD0
        public void set_Culture(){} // RVA: 0x7A80FF440
        public void GetPosition(){} // RVA: 0x7AF2EFB30
        public void .ctor(){} // RVA: 0x7AF2EFBF0
        public void Push(){} // RVA: 0x7AF2EFC10
        public void Pop(){} // RVA: 0x7AF2EFF60
        public void Peek(){} // RVA: 0x7A854FDE0
        public void Read(){} // RVA: 0x7A7E01900
        public void ReadAsInt32(){} // RVA: 0x7AF2F0120
        public void ReadInt32String(){} // RVA: 0x7AF2F0420
        public void ReadAsString(){} // RVA: 0x7AF2F06A0
        public void ReadAsBytes(){} // RVA: 0x7AF2F0A10
        public void ReadArrayIntoByteArray(){} // RVA: 0x7AF2F0F20
        public void ReadAsDouble(){} // RVA: 0x7AF2F12D0
        public void ReadDoubleString(){} // RVA: 0x7AF2F15E0
        public void ReadAsBoolean(){} // RVA: 0x7AF2F1820
        public void ReadBooleanString(){} // RVA: 0x7AF2F1B00
        public void ReadAsDecimal(){} // RVA: 0x7AF2F1DD0
        public void ReadDecimalString(){} // RVA: 0x7AF2F2110
        public void ReadAsDateTime(){} // RVA: 0x7AF2F23D0
        public void ReadDateTimeString(){} // RVA: 0x7AF2F26F0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7AF2F2970
        public void ReadDateTimeOffsetString(){} // RVA: 0x7AF2F2C70
        public void ReaderReadAndAssert(){} // RVA: 0x7AF2F2F00
        public void CreateUnexpectedEndException(){} // RVA: 0x7AF2F2F50
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7AF2F2FA0
        public void Skip(){} // RVA: 0x7AF2F3350
        public void SetToken(){} // RVA: 0x7AF2F3450
        public void SetPostValueState(){} // RVA: 0x7AF2F3690
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7ADD4E9E0
        public void ValidateEnd(){} // RVA: 0x7AF2F36D0
        public void SetStateBasedOnCurrent(){} // RVA: 0x7AF2F3890
        public void SetFinished(){} // RVA: 0x7AF2F39A0
        public void GetTypeForCloseToken(){} // RVA: 0x7AF2F39C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7AF2F3AB0
        public void Dispose(){} // RVA: 0x7AF2F3B20
        public void Close(){} // RVA: 0x7ADD4EE70
        public void ReadAndAssert(){} // RVA: 0x7AF2F3B50
        public void ReadAndMoveToContent(){} // RVA: 0x7AF2F3BB0
        public void MoveToContent(){} // RVA: 0x7AF2F3C10
        public void GetContentToken(){} // RVA: 0x7AF2F3C70
    }

    public class JsonReaderException : JsonException
    {
        // ── Methods ──
        public void set_LineNumber(){} // RVA: 0x7A8CCD330
        public void set_LinePosition(){} // RVA: 0x7A869B9F0
        public void set_Path(){} // RVA: 0x7A8744720
        public void .ctor(){} // RVA: 0x7AF2F3CE0
        public void Create(){} // RVA: 0x7AF2F3F60
    }

    public class JsonSerializationException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2EE910
        public void Create(){} // RVA: 0x7AF2F4230
    }

    public class JsonSerializer : Object
    {
        // ── Methods ──
        public void add_Error(){} // RVA: 0x7AF2F42F0
        public void remove_Error(){} // RVA: 0x7AF2F4410
        public void set_ReferenceResolver(){} // RVA: 0x7AF2F4530
        public void set_Binder(){} // RVA: 0x7AF2F4600
        public void get_TraceWriter(){} // RVA: 0x7A8152D80
        public void set_TraceWriter(){} // RVA: 0x7A8152D90
        public void set_EqualityComparer(){} // RVA: 0x7A8230620
        public void set_TypeNameHandling(){} // RVA: 0x7AF2F46D0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7AF2F4740
        public void set_PreserveReferencesHandling(){} // RVA: 0x7AF2F47B0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7AF2F4820
        public void set_MissingMemberHandling(){} // RVA: 0x7AF2F4890
        public void set_NullValueHandling(){} // RVA: 0x7AF2F4900
        public void set_DefaultValueHandling(){} // RVA: 0x7AF2F4970
        public void set_ObjectCreationHandling(){} // RVA: 0x7AF2F49E0
        public void set_ConstructorHandling(){} // RVA: 0x7AF2F4A50
        public void get_MetadataPropertyHandling(){} // RVA: 0x7A82C2070
        public void set_MetadataPropertyHandling(){} // RVA: 0x7AF2F4AC0
        public void get_Converters(){} // RVA: 0x7AF2F4B30
        public void get_ContractResolver(){} // RVA: 0x7A8154D80
        public void set_ContractResolver(){} // RVA: 0x7AF2F4C10
        public void get_Context(){} // RVA: 0x7AB491250
        public void set_Context(){} // RVA: 0x7ADD51E90
        public void get_Formatting(){} // RVA: 0x7AF2F4CD0
        public void set_Formatting(){} // RVA: 0x7AF2F4D30
        public void get_CheckAdditionalContent(){} // RVA: 0x7AF2F4D90
        public void set_CheckAdditionalContent(){} // RVA: 0x7AF2F4DF0
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7AF2F4E50
        public void .ctor(){} // RVA: 0x7AF2F4EA0
        public void Create(){} // RVA: 0x7AF2F5190
        public void CreateDefault(){} // RVA: 0x7AF2F5300
        public void ApplySerializerSettings(){} // RVA: 0x7AF2F5340
        public void Deserialize(){} // RVA: 0x7AF2F5F00
        public void DeserializeInternal(){} // RVA: 0x7AF2F5F20
        public void SetupReader(){} // RVA: 0x7AF2F6220
        public void ResetReader(){} // RVA: 0x7AF2F6810
        public void Serialize(){} // RVA: 0x7AF2F6AD0
        public void SerializeInternal(){} // RVA: 0x7AF2F6B00
        public void GetReferenceResolver(){} // RVA: 0x7AF2F72C0
        public void GetMatchingConverter(){} // RVA: 0x7AF2F7370
        public void OnError(){} // RVA: 0x7ADD55160
    }

    public class JsonSerializerSettings : Object
    {
        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7AF2F7440
        public void get_MissingMemberHandling(){} // RVA: 0x7AF2F74A0
        public void get_ObjectCreationHandling(){} // RVA: 0x7AF2F7500
        public void get_NullValueHandling(){} // RVA: 0x7AF2F7560
        public void set_NullValueHandling(){} // RVA: 0x7AF2F75C0
        public void get_DefaultValueHandling(){} // RVA: 0x7AF2F7620
        public void get_Converters(){} // RVA: 0x7A8854870
        public void set_Converters(){} // RVA: 0x7A8158EF0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7AF2F7680
        public void get_TypeNameHandling(){} // RVA: 0x7AF2F76E0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7AF2F7740
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7AF2F77A0
        public void get_ConstructorHandling(){} // RVA: 0x7AF2F7800
        public void get_ContractResolver(){} // RVA: 0x7A8158F50
        public void get_EqualityComparer(){} // RVA: 0x7A8158FC0
        public void get_ReferenceResolverProvider(){} // RVA: 0x7A8142870
        public void get_TraceWriter(){} // RVA: 0x7A8592710
        public void get_Binder(){} // RVA: 0x7A8852A30
        public void get_Error(){} // RVA: 0x7A884DED0
        public void get_Context(){} // RVA: 0x7AF2F7860
        public void .cctor(){} // RVA: 0x7AF2F7930
        public void .ctor(){} // RVA: 0x7AF2F7A50
    }

    public class JsonTextReader : JsonReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2F7B10
        public void EnsureBufferNotEmpty(){} // RVA: 0x7AF2F7BF0
        public void OnNewLine(){} // RVA: 0x7AF2F7D40
        public void ParseString(){} // RVA: 0x7AF2F7D50
        public void BlockCopyChars(){} // RVA: 0x7ADD5D2A0
        public void ShiftBufferIfNeeded(){} // RVA: 0x7AF2F8130
        public void ReadData(){} // RVA: 0x7AF2F8220
        public void EnsureChars(){} // RVA: 0x7AF2F85D0
        public void ReadChars(){} // RVA: 0x7AF2F8680
        public void Read(){} // RVA: 0x7AF2F8710
        public void ReadAsInt32(){} // RVA: 0x7AF2F89E0
        public void ReadAsDateTime(){} // RVA: 0x7AF2F8AD0
        public void ReadAsString(){} // RVA: 0x7AF2F8BC0
        public void ReadAsBytes(){} // RVA: 0x7AF2F8C30
        public void ReadStringValue(){} // RVA: 0x7AF2F9800
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7AF2FA9B0
        public void ReadAsBoolean(){} // RVA: 0x7AF2FAAC0
        public void ProcessValueComma(){} // RVA: 0x7AF2FB700
        public void ReadNumberValue(){} // RVA: 0x7AF2FB760
        public void ReadAsDateTimeOffset(){} // RVA: 0x7AF2FC640
        public void ReadAsDecimal(){} // RVA: 0x7AF2FC740
        public void ReadAsDouble(){} // RVA: 0x7AF2FC840
        public void HandleNull(){} // RVA: 0x7AF2FC930
        public void ReadFinished(){} // RVA: 0x7AF2FCA40
        public void ReadNullChar(){} // RVA: 0x7AF2FCB90
        public void EnsureBuffer(){} // RVA: 0x7AF2FCBE0
        public void ReadStringIntoBuffer(){} // RVA: 0x7AF2FCCF0
        public void WriteCharToBuffer(){} // RVA: 0x7AF2FD3B0
        public void ParseUnicode(){} // RVA: 0x7AF2FD460
        public void ReadNumberIntoBuffer(){} // RVA: 0x7AF2FD5A0
        public void ClearRecentString(){} // RVA: 0x7AF2FD7F0
        public void ParsePostValue(){} // RVA: 0x7AF2FD810
        public void ParseObject(){} // RVA: 0x7AF2FDAE0
        public void ParseProperty(){} // RVA: 0x7AF2FDC90
        public void ValidIdentifierChar(){} // RVA: 0x7AF2FDF60
        public void ParseUnquotedProperty(){} // RVA: 0x7AF2FDFD0
        public void ParseValue(){} // RVA: 0x7AF2FE390
        public void ProcessLineFeed(){} // RVA: 0x7AF2FEB30
        public void ProcessCarriageReturn(){} // RVA: 0x7AF2FEB50
        public void EatWhitespace(){} // RVA: 0x7AF2FEC20
        public void ParseConstructor(){} // RVA: 0x7AF2FED60
        public void ParseNumber(){} // RVA: 0x7AF2FF210
        public void ParseComment(){} // RVA: 0x7AF300A50
        public void EndComment(){} // RVA: 0x7AF300DE0
        public void MatchValue(){} // RVA: 0x7AF300E30
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7AF300F20
        public void IsSeparator(){} // RVA: 0x7AF3011D0
        public void ParseTrue(){} // RVA: 0x7AF301320
        public void ParseNull(){} // RVA: 0x7AF301410
        public void ParseUndefined(){} // RVA: 0x7AF3014D0
        public void ParseFalse(){} // RVA: 0x7AF301590
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7AF301720
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7AF3018F0
        public void ParseNumberNaN(){} // RVA: 0x7AF301AC0
        public void Close(){} // RVA: 0x7AF301C90
        public void HasLineInfo(){} // RVA: 0x7A81BD750
        public void get_LineNumber(){} // RVA: 0x7AF301E10
        public void get_LinePosition(){} // RVA: 0x7AF301E60
    }

    public class JsonTextWriter : JsonWriter
    {
        // ── Methods ──
        public void get_Base64Encoder(){} // RVA: 0x7AF301E70
        public void get_QuoteChar(){} // RVA: 0x7ADD85260
        public void .ctor(){} // RVA: 0x7AF302070
        public void Close(){} // RVA: 0x7AF302190
        public void WriteStartObject(){} // RVA: 0x7AF3022A0
        public void WriteStartArray(){} // RVA: 0x7AF3022F0
        public void WriteStartConstructor(){} // RVA: 0x7AF302340
        public void WriteEnd(){} // RVA: 0x7AF302400
        public void WritePropertyName(){} // RVA: 0x7AF3025A0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7AF3026D0
        public void UpdateCharEscapeFlags(){} // RVA: 0x7AF3026E0
        public void WriteIndent(){} // RVA: 0x7AF3027B0
        public void WriteValueDelimiter(){} // RVA: 0x7AF3029F0
        public void WriteIndentSpace(){} // RVA: 0x7AF302A20
        public void WriteValueInternal(){} // RVA: 0x7AF302A50
        public void WriteNull(){} // RVA: 0x7AF302A80
        public void WriteUndefined(){} // RVA: 0x7AF302B20
        public void WriteRaw(){} // RVA: 0x7AF302A50
        public void WriteValue(){} // RVA: 0x7AF304320
        public void WriteEscapedString(){} // RVA: 0x7AF302C90
        public void WriteComment(){} // RVA: 0x7AF304420
        public void EnsureWriteBuffer(){} // RVA: 0x7AF3044F0
        public void WriteIntegerValue(){} // RVA: 0x7AF304670
    }

    public class JsonWriter : Object
    {
        // ── Methods ──
        public void BuildStateArray(){} // RVA: 0x7AF3047A0
        public void .cctor(){} // RVA: 0x7AF304C10
        public void get_CloseOutput(){} // RVA: 0x7A82A20A0
        public void set_CloseOutput(){} // RVA: 0x7A82A2C90
        public void get_Top(){} // RVA: 0x7AF3053E0
        public void get_WriteState(){} // RVA: 0x7AF305440
        public void get_ContainerPath(){} // RVA: 0x7AF305550
        public void get_Path(){} // RVA: 0x7AF3055F0
        public void get_Formatting(){} // RVA: 0x7A82C2070
        public void set_Formatting(){} // RVA: 0x7AF305780
        public void get_DateFormatHandling(){} // RVA: 0x7A864E8D0
        public void set_DateFormatHandling(){} // RVA: 0x7AF3057F0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7A8178B30
        public void set_DateTimeZoneHandling(){} // RVA: 0x7AF305860
        public void get_StringEscapeHandling(){} // RVA: 0x7A8178B50
        public void set_StringEscapeHandling(){} // RVA: 0x7AF3058D0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7A80D7310
        public void get_FloatFormatHandling(){} // RVA: 0x7A8178B70
        public void set_FloatFormatHandling(){} // RVA: 0x7AF305950
        public void get_DateFormatString(){} // RVA: 0x7A8178B90
        public void set_DateFormatString(){} // RVA: 0x7A8230620
        public void get_Culture(){} // RVA: 0x7AF3059C0
        public void set_Culture(){} // RVA: 0x7A81A0060
        public void .ctor(){} // RVA: 0x7AF305A20
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7ADD9F0C0
        public void Push(){} // RVA: 0x7AF305A40
        public void Pop(){} // RVA: 0x7AF305BF0
        public void Peek(){} // RVA: 0x7A83782A0
        public void Close(){} // RVA: 0x7AF305D70
        public void WriteStartObject(){} // RVA: 0x7AF305DE0
        public void WriteEndObject(){} // RVA: 0x7AF305DF0
        public void WriteStartArray(){} // RVA: 0x7AF305E00
        public void WriteEndArray(){} // RVA: 0x7AF305E10
        public void WriteStartConstructor(){} // RVA: 0x7AF305E20
        public void WriteEndConstructor(){} // RVA: 0x7AF305E30
        public void WritePropertyName(){} // RVA: 0x7ADE348E0
        public void WriteEnd(){} // RVA: 0x7A80D7310
        public void WriteToken(){} // RVA: 0x7AF306B10
        public void WriteConstructorDate(){} // RVA: 0x7AF306DA0
        public void AutoCompleteAll(){} // RVA: 0x7AF305D70
        public void GetCloseTokenForType(){} // RVA: 0x7AF307150
        public void AutoCompleteClose(){} // RVA: 0x7AF307200
        public void WriteIndent(){} // RVA: 0x7A80D7310
        public void WriteValueDelimiter(){} // RVA: 0x7A80D7310
        public void WriteIndentSpace(){} // RVA: 0x7A80D7310
        public void AutoComplete(){} // RVA: 0x7AF307650
        public void WriteNull(){} // RVA: 0x7AF307880
        public void WriteUndefined(){} // RVA: 0x7AF3078A0
        public void WriteRaw(){} // RVA: 0x7A80D7310
        public void WriteRawValue(){} // RVA: 0x7AF3078C0
        public void WriteValue(){} // RVA: 0x7AF3084E0
        public void WriteComment(){} // RVA: 0x7AF308430
        public void System.IDisposable.Dispose(){} // RVA: 0x7AF308440
        public void Dispose(){} // RVA: 0x7AF3084B0
        public void CreateUnsupportedTypeException(){} // RVA: 0x7AF309800
        public void InternalWriteEnd(){} // RVA: 0x7AF309900
        public void InternalWritePropertyName(){} // RVA: 0x7AF305E40
        public void InternalWriteRaw(){} // RVA: 0x7A80D7310
        public void InternalWriteStart(){} // RVA: 0x7AF309910
        public void InternalWriteValue(){} // RVA: 0x7AF309AD0
        public void InternalWriteComment(){} // RVA: 0x7AF308430
    }

    public class JsonWriterException : JsonException
    {
        // ── Methods ──
        public void set_Path(){} // RVA: 0x7A8919DE0
        public void .ctor(){} // RVA: 0x7AF309B50
        public void Create(){} // RVA: 0x7AF309CE0
    }

}