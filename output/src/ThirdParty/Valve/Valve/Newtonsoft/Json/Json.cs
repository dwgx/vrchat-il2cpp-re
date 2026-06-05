// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 26
// Methods: 421

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7FFAF2ACBCC0
        public void Return(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7FFAF2ABDBE0
        public void get_LineNumber(){} // RVA: 0x7FFAF2ABD840
        public void get_LinePosition(){} // RVA: 0x7FFAF2ABD840
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
        public void get_ItemConverterType(){} // RVA: 0x7FFAF2DA8380
        public void get_ItemConverterParameters(){} // RVA: 0x7FFAF2D907C0
        public void get_NamingStrategyType(){} // RVA: 0x7FFAF2E0A740
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFAF2E08730
        public void get_NamingStrategyInstance(){} // RVA: 0x7FFAF2DBB0C0
        public void set_NamingStrategyInstance(){} // RVA: 0x7FFAF2DBB0D0
    }

    public class JsonConvert
    {
        public object Stream;

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7FFAF9FBCF60
        public void ToString(){} // RVA: 0x7FFAF9FBDB60 | overloaded x8
        public void EnsureFloatFormat(){} // RVA: 0x7FFAF9FBD350
        public void EnsureDecimalPlace(){} // RVA: 0x7FFAF9FBD7B0 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFAF9FBDD30 | overloaded x2
        public void SerializeObjectInternal(){} // RVA: 0x7FFAF9FBDE00
        public void DeserializeObject(){} // RVA: 0x7FFAF9FBE0F0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAF9FBE3C0
    }

    public class JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAF2ADF090
        public void ReadJson(){} // RVA: 0x7FFAF2ACF0F0
        public void CanConvert(){} // RVA: 0x7FFAF2ABDE40
        public void get_CanRead(){} // RVA: 0x7FFAF2E72850
        public void get_CanWrite(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class JsonConverterAttribute
    {
        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7FFAF2DA8380
        public void get_ConverterParameters(){} // RVA: 0x7FFAF2D907C0
    }

    public class JsonConverterCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBE780
    }

    public class JsonDictionaryAttribute
    {
    }

    public class JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBE8E0 | overloaded x4
    }

    public class JsonExtensionDataAttribute
    {
        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7FFAF2E575E0
        public void get_ReadData(){} // RVA: 0x7FFAF2FF3460
    }

    public class JsonIgnoreAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class JsonObjectAttribute
    {
        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFAF304C540
    }

    public class JsonPosition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBE960
        public void CalculateLength(){} // RVA: 0x7FFAF9FBEA20
        public void WriteTo(){} // RVA: 0x7FFAF9FBEAC0
        public void TypeHasIndex(){} // RVA: 0x7FFAF8A09710
        public void BuildPath(){} // RVA: 0x7FFAF9FBEC40
        public void FormatMessage(){} // RVA: 0x7FFAF9FBF200
        public void .cctor(){} // RVA: 0x7FFAF9FBF570
    }

    public class JsonPropertyAttribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFAF2E2B370
        public void get_ItemConverterParameters(){} // RVA: 0x7FFAF2E08D50
        public void get_NamingStrategyType(){} // RVA: 0x7FFAF2E55590
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFAF2F77C50
        public void get_PropertyName(){} // RVA: 0x7FFAF2F12D00
    }

    public class JsonReader
    {
        // ── Methods ──
        public void get_CurrentState(){} // RVA: 0x7FFAF379F5B0
        public void get_CloseInput(){} // RVA: 0x7FFAF2E09320
        public void set_CloseInput(){} // RVA: 0x7FFAF2E09330
        public void get_SupportMultipleContent(){} // RVA: 0x7FFAF855EFD0
        public void set_SupportMultipleContent(){} // RVA: 0x7FFAF855EFE0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAF2E2E0C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAF9FBF650
        public void get_DateParseHandling(){} // RVA: 0x7FFAF349AB90
        public void set_DateParseHandling(){} // RVA: 0x7FFAF9FBF6C0
        public void get_FloatParseHandling(){} // RVA: 0x7FFAF30554D0
        public void set_FloatParseHandling(){} // RVA: 0x7FFAF9FBF730
        public void get_DateFormatString(){} // RVA: 0x7FFAF2E2B370
        public void set_DateFormatString(){} // RVA: 0x7FFAF2E2B380
        public void get_MaxDepth(){} // RVA: 0x7FFAF61637B0
        public void set_MaxDepth(){} // RVA: 0x7FFAF9FBF7A0
        public void get_TokenType(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void get_ValueType(){} // RVA: 0x7FFAF9FBF860
        public void get_Depth(){} // RVA: 0x7FFAF9FBF880
        public void get_Path(){} // RVA: 0x7FFAF9FBF900
        public void get_Culture(){} // RVA: 0x7FFAF9FBFA80
        public void set_Culture(){} // RVA: 0x7FFAF2DB5200
        public void GetPosition(){} // RVA: 0x7FFAF9FBFAE0
        public void .ctor(){} // RVA: 0x7FFAF9FBFBA0
        public void Push(){} // RVA: 0x7FFAF9FBFBC0
        public void Pop(){} // RVA: 0x7FFAF9FBFF10
        public void Peek(){} // RVA: 0x7FFAF3241DC0
        public void Read(){} // RVA: 0x7FFAF2ABDBE0
        public void ReadAsInt32(){} // RVA: 0x7FFAF9FC00C0
        public void ReadInt32String(){} // RVA: 0x7FFAF9FC0440
        public void ReadAsString(){} // RVA: 0x7FFAF9FC07F0
        public void ReadAsBytes(){} // RVA: 0x7FFAF9FC0BE0
        public void ReadArrayIntoByteArray(){} // RVA: 0x7FFAF9FC12E0
        public void ReadAsDouble(){} // RVA: 0x7FFAF9FC16E0
        public void ReadDoubleString(){} // RVA: 0x7FFAF9FC1A70
        public void ReadAsBoolean(){} // RVA: 0x7FFAF9FC1DC0
        public void ReadBooleanString(){} // RVA: 0x7FFAF9FC2100
        public void ReadAsDecimal(){} // RVA: 0x7FFAF9FC2500
        public void ReadDecimalString(){} // RVA: 0x7FFAF9FC28C0
        public void ReadAsDateTime(){} // RVA: 0x7FFAF9FC2C70
        public void ReadDateTimeString(){} // RVA: 0x7FFAF9FC3010
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAF9FC34A0
        public void ReadDateTimeOffsetString(){} // RVA: 0x7FFAF9FC3830
        public void ReaderReadAndAssert(){} // RVA: 0x7FFAF9FC3C70
        public void CreateUnexpectedEndException(){} // RVA: 0x7FFAF9FC3CC0
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7FFAF9FC3D10
        public void Skip(){} // RVA: 0x7FFAF9FC40C0
        public void SetToken(){} // RVA: 0x7FFAF9FC41C0 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x7FFAF9FC4400
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFAF8A11010
        public void ValidateEnd(){} // RVA: 0x7FFAF9FC4440
        public void SetStateBasedOnCurrent(){} // RVA: 0x7FFAF9FC4600
        public void SetFinished(){} // RVA: 0x7FFAF9FC4710
        public void GetTypeForCloseToken(){} // RVA: 0x7FFAF9FC4730
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF9FC4820
        public void Dispose(){} // RVA: 0x7FFAF9FC4890
        public void Close(){} // RVA: 0x7FFAF8A114A0
        public void ReadAndAssert(){} // RVA: 0x7FFAF9FC48C0
        public void ReadAndMoveToContent(){} // RVA: 0x7FFAF9FC4920
        public void MoveToContent(){} // RVA: 0x7FFAF9FC4980
        public void GetContentToken(){} // RVA: 0x7FFAF9FC49E0
    }

    public class JsonReaderException
    {
        // ── Methods ──
        public void set_LineNumber(){} // RVA: 0x7FFAF39B2F80
        public void set_LinePosition(){} // RVA: 0x7FFAF338F350
        public void set_Path(){} // RVA: 0x7FFAF345A650
        public void .ctor(){} // RVA: 0x7FFAF9FC4AB0 | overloaded x3
        public void Create(){} // RVA: 0x7FFAF9FC4D30 | overloaded x3
    }

    public class JsonRequiredAttribute
    {
    }

    public class JsonSerializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBE8E0 | overloaded x4
        public void Create(){} // RVA: 0x7FFAF9FC5000 | overloaded x3
    }

    public class JsonSerializer
    {
        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFAF9FC50C0
        public void remove_Error(){} // RVA: 0x7FFAF9FC51C0
        public void set_ReferenceResolver(){} // RVA: 0x7FFAF9FC52C0
        public void set_Binder(){} // RVA: 0x7FFAF9FC5390
        public void get_TraceWriter(){} // RVA: 0x7FFAF2E08730
        public void set_TraceWriter(){} // RVA: 0x7FFAF2E08740
        public void set_EqualityComparer(){} // RVA: 0x7FFAF2EE54D0
        public void set_TypeNameHandling(){} // RVA: 0x7FFAF9FC5460
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFAF9FC54D0
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFAF9FC5540
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAF9FC55B0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAF9FC5620
        public void set_NullValueHandling(){} // RVA: 0x7FFAF9FC5690
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAF9FC5700
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAF9FC5770
        public void set_ConstructorHandling(){} // RVA: 0x7FFAF9FC57E0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAF2F76670
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFAF9FC5850
        public void get_Converters(){} // RVA: 0x7FFAF9FC58C0
        public void get_ContractResolver(){} // RVA: 0x7FFAF2E0A740
        public void set_ContractResolver(){} // RVA: 0x7FFAF9FC59A0
        public void get_Context(){} // RVA: 0x7FFAF615BF00
        public void set_Context(){} // RVA: 0x7FFAF8A145D0
        public void get_Formatting(){} // RVA: 0x7FFAF9FC5A60
        public void set_Formatting(){} // RVA: 0x7FFAF9FC5AC0
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFAF9FC5B20
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFAF9FC5B80
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFAF9FC5BE0
        public void .ctor(){} // RVA: 0x7FFAF9FC5C30
        public void Create(){} // RVA: 0x7FFAF9FC5F20 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFAF9FC6090 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFAF9FC60D0
        public void Deserialize(){} // RVA: 0x7FFAF9FC6C90 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFAF9FC6CB0
        public void SetupReader(){} // RVA: 0x7FFAF9FC6FB0
        public void ResetReader(){} // RVA: 0x7FFAF9FC75D0
        public void Serialize(){} // RVA: 0x7FFAF9FC78A0 | overloaded x2
        public void SerializeInternal(){} // RVA: 0x7FFAF9FC78D0
        public void GetReferenceResolver(){} // RVA: 0x7FFAF9FC8090
        public void GetMatchingConverter(){} // RVA: 0x7FFAF9FC8140 | overloaded x2
        public void OnError(){} // RVA: 0x7FFAF8A178F0
    }

    public class JsonSerializerSettings
    {
        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAF9FC8210
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAF9FC8270
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAF9FC82D0
        public void get_NullValueHandling(){} // RVA: 0x7FFAF9FC8330
        public void set_NullValueHandling(){} // RVA: 0x7FFAF9FC8390
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAF9FC83F0
        public void get_Converters(){} // RVA: 0x7FFAF3546D30
        public void set_Converters(){} // RVA: 0x7FFAF2E0E8A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFAF9FC8450
        public void get_TypeNameHandling(){} // RVA: 0x7FFAF9FC84B0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAF9FC8510
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFAF9FC8570
        public void get_ConstructorHandling(){} // RVA: 0x7FFAF9FC85D0
        public void get_ContractResolver(){} // RVA: 0x7FFAF2E0E900
        public void get_EqualityComparer(){} // RVA: 0x7FFAF2E0E970
        public void get_ReferenceResolverProvider(){} // RVA: 0x7FFAF2DF82A0
        public void get_TraceWriter(){} // RVA: 0x7FFAF32A7DB0
        public void get_Binder(){} // RVA: 0x7FFAF3544E10
        public void get_Error(){} // RVA: 0x7FFAF35402E0
        public void get_Context(){} // RVA: 0x7FFAF9FC8630
        public void .cctor(){} // RVA: 0x7FFAF9FC8700
        public void .ctor(){} // RVA: 0x7FFAF9FC8820
    }

    public class JsonTextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FC88E0
        public void EnsureBufferNotEmpty(){} // RVA: 0x7FFAF9FC89C0
        public void OnNewLine(){} // RVA: 0x7FFAF9FC8B10
        public void ParseString(){} // RVA: 0x7FFAF9FC8B20
        public void BlockCopyChars(){} // RVA: 0x7FFAF8A1FCA0
        public void ShiftBufferIfNeeded(){} // RVA: 0x7FFAF9FC91C0
        public void ReadData(){} // RVA: 0x7FFAF9FC92B0 | overloaded x2
        public void EnsureChars(){} // RVA: 0x7FFAF9FC9650
        public void ReadChars(){} // RVA: 0x7FFAF9FC9700
        public void Read(){} // RVA: 0x7FFAF9FC9790
        public void ReadAsInt32(){} // RVA: 0x7FFAF9FC9B10
        public void ReadAsDateTime(){} // RVA: 0x7FFAF9FC9C00
        public void ReadAsString(){} // RVA: 0x7FFAF9FC9CF0
        public void ReadAsBytes(){} // RVA: 0x7FFAF9FC9D60
        public void ReadStringValue(){} // RVA: 0x7FFAF9FCA790
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFAF9FCB700
        public void ReadAsBoolean(){} // RVA: 0x7FFAF9FCB810
        public void ProcessValueComma(){} // RVA: 0x7FFAF9FCC610
        public void ReadNumberValue(){} // RVA: 0x7FFAF9FCC670
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAF9FCD250
        public void ReadAsDecimal(){} // RVA: 0x7FFAF9FCD350
        public void ReadAsDouble(){} // RVA: 0x7FFAF9FCD450
        public void HandleNull(){} // RVA: 0x7FFAF9FCD540
        public void ReadFinished(){} // RVA: 0x7FFAF9FCD650
        public void ReadNullChar(){} // RVA: 0x7FFAF9FCD800
        public void EnsureBuffer(){} // RVA: 0x7FFAF9FCD850
        public void ReadStringIntoBuffer(){} // RVA: 0x7FFAF9FCD960
        public void WriteCharToBuffer(){} // RVA: 0x7FFAF9FCE020
        public void ParseUnicode(){} // RVA: 0x7FFAF9FCE0D0
        public void ReadNumberIntoBuffer(){} // RVA: 0x7FFAF9FCE360
        public void ClearRecentString(){} // RVA: 0x7FFAF9FCE590
        public void ParsePostValue(){} // RVA: 0x7FFAF9FCE5B0
        public void ParseObject(){} // RVA: 0x7FFAF9FCE9E0
        public void ParseProperty(){} // RVA: 0x7FFAF9FCEBF0
        public void ValidIdentifierChar(){} // RVA: 0x7FFAF9FCEF80
        public void ParseUnquotedProperty(){} // RVA: 0x7FFAF9FCEFF0
        public void ParseValue(){} // RVA: 0x7FFAF9FCF3A0
        public void ProcessLineFeed(){} // RVA: 0x7FFAF9FCFFE0
        public void ProcessCarriageReturn(){} // RVA: 0x7FFAF9FD0000
        public void EatWhitespace(){} // RVA: 0x7FFAF9FD00D0
        public void ParseConstructor(){} // RVA: 0x7FFAF9FD0210
        public void ParseNumber(){} // RVA: 0x7FFAF9FD0750
        public void ParseComment(){} // RVA: 0x7FFAF9FD1FA0
        public void EndComment(){} // RVA: 0x7FFAF9FD2310
        public void MatchValue(){} // RVA: 0x7FFAF9FD23D0
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7FFAF9FD24C0
        public void IsSeparator(){} // RVA: 0x7FFAF9FD2770
        public void ParseTrue(){} // RVA: 0x7FFAF9FD28C0
        public void ParseNull(){} // RVA: 0x7FFAF9FD2A40
        public void ParseUndefined(){} // RVA: 0x7FFAF9FD2B90
        public void ParseFalse(){} // RVA: 0x7FFAF9FD2CE0
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7FFAF9FD2F10
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7FFAF9FD3220
        public void ParseNumberNaN(){} // RVA: 0x7FFAF9FD3530
        public void Close(){} // RVA: 0x7FFAF9FD3840
        public void HasLineInfo(){} // RVA: 0x7FFAF2E72850
        public void get_LineNumber(){} // RVA: 0x7FFAF9FD39C0
        public void get_LinePosition(){} // RVA: 0x7FFAF9FD3A10
    }

    public class JsonTextWriter
    {
        // ── Methods ──
        public void get_Base64Encoder(){} // RVA: 0x7FFAF9FD3A20
        public void get_QuoteChar(){} // RVA: 0x7FFAF8A48F80
        public void .ctor(){} // RVA: 0x7FFAF9FD3C20
        public void Close(){} // RVA: 0x7FFAF9FD3D40
        public void WriteStartObject(){} // RVA: 0x7FFAF9FD3E50
        public void WriteStartArray(){} // RVA: 0x7FFAF9FD3EA0
        public void WriteStartConstructor(){} // RVA: 0x7FFAF9FD3EF0
        public void WriteEnd(){} // RVA: 0x7FFAF9FD3FB0
        public void WritePropertyName(){} // RVA: 0x7FFAF9FD4150 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFAF9FD4280
        public void UpdateCharEscapeFlags(){} // RVA: 0x7FFAF9FD4290
        public void WriteIndent(){} // RVA: 0x7FFAF9FD4360
        public void WriteValueDelimiter(){} // RVA: 0x7FFAF9FD4550
        public void WriteIndentSpace(){} // RVA: 0x7FFAF9FD4580
        public void WriteValueInternal(){} // RVA: 0x7FFAF9FD45B0
        public void WriteNull(){} // RVA: 0x7FFAF9FD45E0
        public void WriteUndefined(){} // RVA: 0x7FFAF9FD4680
        public void WriteRaw(){} // RVA: 0x7FFAF9FD45B0
        public void WriteValue(){} // RVA: 0x7FFAF9FD5E90 | overloaded x22
        public void WriteEscapedString(){} // RVA: 0x7FFAF9FD47F0
        public void WriteComment(){} // RVA: 0x7FFAF9FD5FA0
        public void EnsureWriteBuffer(){} // RVA: 0x7FFAF9FD6070
        public void WriteIntegerValue(){} // RVA: 0x7FFAF9FD61F0 | overloaded x2
    }

    public class JsonWriter
    {
        // ── Methods ──
        public void BuildStateArray(){} // RVA: 0x7FFAF9FD6310
        public void .cctor(){} // RVA: 0x7FFAF9FD6780
        public void get_CloseOutput(){} // RVA: 0x7FFAF2F56500
        public void set_CloseOutput(){} // RVA: 0x7FFAF2F578C0
        public void get_Top(){} // RVA: 0x7FFAF9FD6F50
        public void get_WriteState(){} // RVA: 0x7FFAF9FD6FB0
        public void get_ContainerPath(){} // RVA: 0x7FFAF9FD70C0
        public void get_Path(){} // RVA: 0x7FFAF9FD7160
        public void get_Formatting(){} // RVA: 0x7FFAF2F76670
        public void set_Formatting(){} // RVA: 0x7FFAF9FD72E0
        public void get_DateFormatHandling(){} // RVA: 0x7FFAF3341AF0
        public void set_DateFormatHandling(){} // RVA: 0x7FFAF9FD7350
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAF2E2E080
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAF9FD73C0
        public void get_StringEscapeHandling(){} // RVA: 0x7FFAF2E2E0A0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFAF9FD7430
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFAF2D8D310
        public void get_FloatFormatHandling(){} // RVA: 0x7FFAF2E2E0C0
        public void set_FloatFormatHandling(){} // RVA: 0x7FFAF9FD74B0
        public void get_DateFormatString(){} // RVA: 0x7FFAF2E2E0E0
        public void set_DateFormatString(){} // RVA: 0x7FFAF2EE54D0
        public void get_Culture(){} // RVA: 0x7FFAF9FD7520
        public void set_Culture(){} // RVA: 0x7FFAF2E55510
        public void .ctor(){} // RVA: 0x7FFAF9FD7580
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFAF8A62B10
        public void Push(){} // RVA: 0x7FFAF9FD75A0
        public void Pop(){} // RVA: 0x7FFAF9FD7750
        public void Peek(){} // RVA: 0x7FFAF306ED50
        public void Close(){} // RVA: 0x7FFAF9FD78C0
        public void WriteStartObject(){} // RVA: 0x7FFAF9FD7930
        public void WriteEndObject(){} // RVA: 0x7FFAF9FD7940
        public void WriteStartArray(){} // RVA: 0x7FFAF9FD7950
        public void WriteEndArray(){} // RVA: 0x7FFAF9FD7960
        public void WriteStartConstructor(){} // RVA: 0x7FFAF9FD7970
        public void WriteEndConstructor(){} // RVA: 0x7FFAF9FD7980
        public void WritePropertyName(){} // RVA: 0x7FFAF8AF8030 | overloaded x2
        public void WriteEnd(){} // RVA: 0x7FFAF2D8D310 | overloaded x3
        public void WriteToken(){} // RVA: 0x7FFAF9FD8660 | overloaded x4
        public void WriteConstructorDate(){} // RVA: 0x7FFAF9FD88F0
        public void AutoCompleteAll(){} // RVA: 0x7FFAF9FD78C0
        public void GetCloseTokenForType(){} // RVA: 0x7FFAF9FD8CA0
        public void AutoCompleteClose(){} // RVA: 0x7FFAF9FD8D50
        public void WriteIndent(){} // RVA: 0x7FFAF2D8D310
        public void WriteValueDelimiter(){} // RVA: 0x7FFAF2D8D310
        public void WriteIndentSpace(){} // RVA: 0x7FFAF2D8D310
        public void AutoComplete(){} // RVA: 0x7FFAF9FD91A0
        public void WriteNull(){} // RVA: 0x7FFAF9FD93D0
        public void WriteUndefined(){} // RVA: 0x7FFAF9FD93F0
        public void WriteRaw(){} // RVA: 0x7FFAF2D8D310
        public void WriteRawValue(){} // RVA: 0x7FFAF9FD9410
        public void WriteValue(){} // RVA: 0x7FFAF9FDA030 | overloaded x38
        public void WriteComment(){} // RVA: 0x7FFAF9FD9F80
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF9FD9F90
        public void Dispose(){} // RVA: 0x7FFAF9FDA000
        public void CreateUnsupportedTypeException(){} // RVA: 0x7FFAF9FDB350
        public void InternalWriteEnd(){} // RVA: 0x7FFAF9FDB450
        public void InternalWritePropertyName(){} // RVA: 0x7FFAF9FD7990
        public void InternalWriteRaw(){} // RVA: 0x7FFAF2D8D310
        public void InternalWriteStart(){} // RVA: 0x7FFAF9FDB460
        public void InternalWriteValue(){} // RVA: 0x7FFAF9FDB620
        public void InternalWriteComment(){} // RVA: 0x7FFAF9FD9F80
    }

    public class JsonWriterException
    {
        // ── Methods ──
        public void set_Path(){} // RVA: 0x7FFAF3604600
        public void .ctor(){} // RVA: 0x7FFAF9FDB6A0 | overloaded x3
        public void Create(){} // RVA: 0x7FFAF9FDB830 | overloaded x2
    }

}