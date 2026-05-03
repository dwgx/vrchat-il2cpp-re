// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 26
// Methods: 421

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
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
    }

    public class JsonConstructorAttribute : Attribute
    {
    }

    public class JsonContainerAttribute : Attribute
    {
        public System.Type _itemConverterType; // 0x10
        public object[] _itemConverterParameters; // 0x18
        public Valve.Newtonsoft.Json.Serialization.NamingStrategy _namingStrategyInstance; // 0x20
        public System.Nullable`1<bool> _isReference; // 0x28
        public System.Nullable`1<bool> _itemIsReference; // 0x2A

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFE81116380
        public void get_ItemConverterParameters(){} // RVA: 0x7FFE810FE7C0
        public void get_NamingStrategyType(){} // RVA: 0x7FFE81178740
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFE81176730
        public void get_NamingStrategyInstance(){} // RVA: 0x7FFE811290C0
        public void set_NamingStrategyInstance(){} // RVA: 0x7FFE811290D0
    }

    public class JsonConvert : Object
    {
        public System.Func`1<Valve.Newtonsoft.Json.JsonSerializerSettings> _defaultSettings;

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7FFE8804D130
        public void ToString(){} // RVA: 0x7FFE8804DD30 | overloaded x8
        public void EnsureFloatFormat(){} // RVA: 0x7FFE8804D520
        public void EnsureDecimalPlace(){} // RVA: 0x7FFE8804D980 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFE8804DF00 | overloaded x2
        public void SerializeObjectInternal(){} // RVA: 0x7FFE8804DFD0
        public void DeserializeObject(){} // RVA: 0x7FFE8804E2C0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE8804E590
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
    }

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804E950
    }

    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804EAB0 | overloaded x4
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        public bool _writeData; // 0x10
        public bool _readData; // 0x11

        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7FFE811C55E0
        public void get_ReadData(){} // RVA: 0x7FFE81346E30
    }

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public \ _memberSerialization; // 0x50

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFE8139DAD0
    }

    public class JsonPosition : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804EB30
        public void CalculateLength(){} // RVA: 0x7FFE8804EBF0
        public void WriteTo(){} // RVA: 0x7FFE8804EC90
        public void TypeHasIndex(){} // RVA: 0x7FFE86A9A530
        public void BuildPath(){} // RVA: 0x7FFE8804EE10
        public void FormatMessage(){} // RVA: 0x7FFE8804F3D0
        public void .cctor(){} // RVA: 0x7FFE8804F740
    }

    public class JsonPropertyAttribute : Attribute
    {
        public System.Nullable`1<0x6663EC74> _nullValueHandling; // 0x10
        public System.Nullable`1<[> _defaultValueHandling; // 0x18
        public System.Nullable`1<0x6663ED7C> _referenceLoopHandling; // 0x20
        public System.Nullable`1<0x6663ECCC> _objectCreationHandling; // 0x28
        public System.Nullable`1<0x6663EE84> _typeNameHandling; // 0x30

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7FFE81199370
        public void get_ItemConverterParameters(){} // RVA: 0x7FFE81176D50
        public void get_NamingStrategyType(){} // RVA: 0x7FFE811C3590
        public void get_NamingStrategyParameters(){} // RVA: 0x7FFE81463AE0
        public void get_PropertyName(){} // RVA: 0x7FFE81280C30
    }

    public class JsonReader : Object
    {
        public 0x6663EA0C _tokenType; // 0x10
        public object _value; // 0x18
        public char _quoteChar; // 0x20
        public dFixup.ÎÍÎÍÏÍÎ _currentState; // 0x24
        public Valve.Newtonsoft.Json.JsonPosition _currentPosition; // 0x28
        public System.Globalization.CultureInfo _culture; // 0x40
        public 0x6663DF0C _dateTimeZoneHandling; // 0x48
        public System.Nullable`1<int> _maxDepth; // 0x4C
        public bool _hasExceededMaxDepth; // 0x54
        public 0x6663DEB4 _dateParseHandling; // 0x58
        public 0x6663E014 _floatParseHandling; // 0x5C
        public string _dateFormatString; // 0x60
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.JsonPosition> _stack; // 0x68
        public bool _closeInput; // 0x70

        // ── Methods ──
        public void get_CurrentState(){} // RVA: 0x7FFE81A56130
        public void get_CloseInput(){} // RVA: 0x7FFE81177320
        public void set_CloseInput(){} // RVA: 0x7FFE81177330
        public void get_SupportMultipleContent(){} // RVA: 0x7FFE865EFE00
        public void set_SupportMultipleContent(){} // RVA: 0x7FFE865EFE10
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE8119C0C0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE8804F820
        public void get_DateParseHandling(){} // RVA: 0x7FFE8175AC90
        public void set_DateParseHandling(){} // RVA: 0x7FFE8804F890
        public void get_FloatParseHandling(){} // RVA: 0x7FFE813A7A20
        public void set_FloatParseHandling(){} // RVA: 0x7FFE8804F900
        public void get_DateFormatString(){} // RVA: 0x7FFE81199370
        public void set_DateFormatString(){} // RVA: 0x7FFE81199380
        public void get_MaxDepth(){} // RVA: 0x7FFE84337910
        public void set_MaxDepth(){} // RVA: 0x7FFE8804F970
        public void get_TokenType(){} // RVA: 0x7FFE811485C0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void get_ValueType(){} // RVA: 0x7FFE8804FA30
        public void get_Depth(){} // RVA: 0x7FFE8804FA50
        public void get_Path(){} // RVA: 0x7FFE8804FAD0
        public void get_Culture(){} // RVA: 0x7FFE8804FC50
        public void set_Culture(){} // RVA: 0x7FFE81123200
        public void GetPosition(){} // RVA: 0x7FFE8804FCB0
        public void .ctor(){} // RVA: 0x7FFE8804FD70
        public void Push(){} // RVA: 0x7FFE8804FD90
        public void Pop(){} // RVA: 0x7FFE880500E0
        public void Peek(){} // RVA: 0x7FFE81549710
        public void Read(){} // RVA: 0x7FFE80E2F150
        public void ReadAsInt32(){} // RVA: 0x7FFE88050290
        public void ReadInt32String(){} // RVA: 0x7FFE88050610
        public void ReadAsString(){} // RVA: 0x7FFE880509B0
        public void ReadAsBytes(){} // RVA: 0x7FFE88050DA0
        public void ReadArrayIntoByteArray(){} // RVA: 0x7FFE880514A0
        public void ReadAsDouble(){} // RVA: 0x7FFE880518A0
        public void ReadDoubleString(){} // RVA: 0x7FFE88051C30
        public void ReadAsBoolean(){} // RVA: 0x7FFE88051F80
        public void ReadBooleanString(){} // RVA: 0x7FFE880522C0
        public void ReadAsDecimal(){} // RVA: 0x7FFE880526C0
        public void ReadDecimalString(){} // RVA: 0x7FFE88052A80
        public void ReadAsDateTime(){} // RVA: 0x7FFE88052E30
        public void ReadDateTimeString(){} // RVA: 0x7FFE880531D0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE88053660
        public void ReadDateTimeOffsetString(){} // RVA: 0x7FFE880539F0
        public void ReaderReadAndAssert(){} // RVA: 0x7FFE88053E30
        public void CreateUnexpectedEndException(){} // RVA: 0x7FFE88053E80
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7FFE88053ED0
        public void Skip(){} // RVA: 0x7FFE88054280
        public void SetToken(){} // RVA: 0x7FFE88054380 | overloaded x3
        public void SetPostValueState(){} // RVA: 0x7FFE880545C0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFE86AA1E20
        public void ValidateEnd(){} // RVA: 0x7FFE88054600
        public void SetStateBasedOnCurrent(){} // RVA: 0x7FFE880547C0
        public void SetFinished(){} // RVA: 0x7FFE880548D0
        public void GetTypeForCloseToken(){} // RVA: 0x7FFE880548F0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE880549E0
        public void Dispose(){} // RVA: 0x7FFE88054A50
        public void Close(){} // RVA: 0x7FFE86AA22B0
        public void ReadAndAssert(){} // RVA: 0x7FFE88054A80
        public void ReadAndMoveToContent(){} // RVA: 0x7FFE88054AE0
        public void MoveToContent(){} // RVA: 0x7FFE88054B40
        public void GetContentToken(){} // RVA: 0x7FFE88054BA0
    }

    public class JsonReaderException : JsonException
    {
        public int _lineNumber; // 0x90
        public int _linePosition; // 0x94
        public string _path; // 0x98

        // ── Methods ──
        public void set_LineNumber(){} // RVA: 0x7FFE81C8DB30
        public void set_LinePosition(){} // RVA: 0x7FFE81680470
        public void set_Path(){} // RVA: 0x7FFE8171B470
        public void .ctor(){} // RVA: 0x7FFE88054C70 | overloaded x3
        public void Create(){} // RVA: 0x7FFE88054EF0 | overloaded x3
    }

    public class JsonRequiredAttribute : Attribute
    {
    }

    public class JsonSerializationException : JsonException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804EAB0 | overloaded x4
        public void Create(){} // RVA: 0x7FFE880551C0 | overloaded x3
    }

    public class JsonSerializer : Object
    {
        public 0x6663EE84 _typeNameHandling; // 0x10
        public 0x664CC4D4 _typeNameAssemblyFormat; // 0x14
        public \ _preserveReferencesHandling; // 0x18
        public 0x6663ED7C _referenceLoopHandling; // 0x1C
        public 0x6663EC1C _missingMemberHandling; // 0x20
        public 0x6663ECCC _objectCreationHandling; // 0x24
        public 0x6663EC74 _nullValueHandling; // 0x28
        public [ _defaultValueHandling; // 0x2C
        public 0x6663DE04 _constructorHandling; // 0x30
        public 0x6663EBC4 _metadataPropertyHandling; // 0x34
        public Valve.Newtonsoft.Json.JsonConverterCollection _converters; // 0x38
        public Valve.Newtonsoft.Json.Serialization.IContractResolver _contractResolver; // 0x40
        public Valve.Newtonsoft.Json.Serialization.ITraceWriter _traceWriter; // 0x48
        public System.Collections.IEqualityComparer _equalityComparer; // 0x50
        public System.Runtime.Serialization.SerializationBinder _binder; // 0x58
        public System.Runtime.Serialization.StreamingContext _context; // 0x60
        public Valve.Newtonsoft.Json.Serialization.IReferenceResolver _referenceResolver; // 0x70
        public System.Nullable`1<0x6663E06C> _formatting; // 0x78
        public System.Nullable`1<0x6663DE5C> _dateFormatHandling; // 0x80

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFE88055280
        public void remove_Error(){} // RVA: 0x7FFE88055380
        public void set_ReferenceResolver(){} // RVA: 0x7FFE88055480
        public void set_Binder(){} // RVA: 0x7FFE88055550
        public void get_TraceWriter(){} // RVA: 0x7FFE81176730
        public void set_TraceWriter(){} // RVA: 0x7FFE81176740
        public void set_EqualityComparer(){} // RVA: 0x7FFE812534D0
        public void set_TypeNameHandling(){} // RVA: 0x7FFE88055620
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFE88055690
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFE88055700
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE88055770
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE880557E0
        public void set_NullValueHandling(){} // RVA: 0x7FFE88055850
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE880558C0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE88055930
        public void set_ConstructorHandling(){} // RVA: 0x7FFE880559A0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFE82447220
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFE88055A10
        public void get_Converters(){} // RVA: 0x7FFE88055A80
        public void get_ContractResolver(){} // RVA: 0x7FFE81178740
        public void set_ContractResolver(){} // RVA: 0x7FFE88055B60
        public void get_Context(){} // RVA: 0x7FFE8432FFC0
        public void set_Context(){} // RVA: 0x7FFE86AA53E0
        public void get_Formatting(){} // RVA: 0x7FFE88055C20
        public void set_Formatting(){} // RVA: 0x7FFE88055C80
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFE88055CE0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFE88055D40
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFE88055DA0
        public void .ctor(){} // RVA: 0x7FFE88055DF0
        public void Create(){} // RVA: 0x7FFE880560E0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFE88056250 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFE88056290
        public void Deserialize(){} // RVA: 0x7FFE88056E50 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFE88056E70
        public void SetupReader(){} // RVA: 0x7FFE88057170
        public void ResetReader(){} // RVA: 0x7FFE88057790
        public void Serialize(){} // RVA: 0x7FFE88057A60 | overloaded x2
        public void SerializeInternal(){} // RVA: 0x7FFE88057A90
        public void GetReferenceResolver(){} // RVA: 0x7FFE88058250
        public void GetMatchingConverter(){} // RVA: 0x7FFE88058300 | overloaded x2
        public void OnError(){} // RVA: 0x7FFE86AA8700
    }

    public class JsonSerializerSettings : Object
    {
        public System.Runtime.Serialization.StreamingContext DefaultContext;
        public System.Globalization.CultureInfo DefaultCulture; // 0x10
        public System.Nullable`1<0x6663E06C> _formatting; // 0x10
        public System.Nullable`1<0x6663DE5C> _dateFormatHandling; // 0x18
        public System.Nullable`1<0x6663DF0C> _dateTimeZoneHandling; // 0x20
        public System.Nullable`1<0x6663DEB4> _dateParseHandling; // 0x28
        public System.Nullable`1<0x6663DFBC> _floatFormatHandling; // 0x30
        public System.Nullable`1<0x6663E014> _floatParseHandling; // 0x38
        public System.Nullable`1<0x6663EE2C> _stringEscapeHandling; // 0x40
        public System.Globalization.CultureInfo _culture; // 0x48
        public System.Nullable`1<bool> _checkAdditionalContent; // 0x50
        public System.Nullable`1<int> _maxDepth; // 0x54
        public bool _maxDepthSet; // 0x5C
        public string _dateFormatString; // 0x60
        public bool _dateFormatStringSet; // 0x68
        public System.Nullable`1<0x664CC4D4> _typeNameAssemblyFormat; // 0x6C
        public System.Nullable`1<[> _defaultValueHandling; // 0x74
        public System.Nullable`1<\> _preserveReferencesHandling; // 0x7C

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE880583D0
        public void get_MissingMemberHandling(){} // RVA: 0x7FFE88058430
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE88058490
        public void get_NullValueHandling(){} // RVA: 0x7FFE880584F0
        public void set_NullValueHandling(){} // RVA: 0x7FFE88058550
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE880585B0
        public void get_Converters(){} // RVA: 0x7FFE8181EA80
        public void set_Converters(){} // RVA: 0x7FFE8117C8A0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFE88058610
        public void get_TypeNameHandling(){} // RVA: 0x7FFE88058670
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFE880586D0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFE88058730
        public void get_ConstructorHandling(){} // RVA: 0x7FFE88058790
        public void get_ContractResolver(){} // RVA: 0x7FFE8117C900
        public void get_EqualityComparer(){} // RVA: 0x7FFE8117C970
        public void get_ReferenceResolverProvider(){} // RVA: 0x7FFE811662A0
        public void get_TraceWriter(){} // RVA: 0x7FFE8158D5D0
        public void get_Binder(){} // RVA: 0x7FFE81828B50
        public void get_Error(){} // RVA: 0x7FFE8181E3D0
        public void get_Context(){} // RVA: 0x7FFE880587F0
        public void .cctor(){} // RVA: 0x7FFE880588C0
        public void .ctor(){} // RVA: 0x7FFE880589E0
    }

    public class JsonTextReader : JsonReader
    {
        public System.IO.TextReader _reader; // 0x78
        public char[] _chars; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88058AA0
        public void EnsureBufferNotEmpty(){} // RVA: 0x7FFE88058B80
        public void OnNewLine(){} // RVA: 0x7FFE88058CD0
        public void ParseString(){} // RVA: 0x7FFE88058CE0
        public void BlockCopyChars(){} // RVA: 0x7FFE86AB0AB0
        public void ShiftBufferIfNeeded(){} // RVA: 0x7FFE88059380
        public void ReadData(){} // RVA: 0x7FFE88059470 | overloaded x2
        public void EnsureChars(){} // RVA: 0x7FFE88059810
        public void ReadChars(){} // RVA: 0x7FFE880598C0
        public void Read(){} // RVA: 0x7FFE88059950
        public void ReadAsInt32(){} // RVA: 0x7FFE88059CD0
        public void ReadAsDateTime(){} // RVA: 0x7FFE88059DC0
        public void ReadAsString(){} // RVA: 0x7FFE88059EB0
        public void ReadAsBytes(){} // RVA: 0x7FFE88059F20
        public void ReadStringValue(){} // RVA: 0x7FFE8805A950
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFE8805B8C0
        public void ReadAsBoolean(){} // RVA: 0x7FFE8805B9D0
        public void ProcessValueComma(){} // RVA: 0x7FFE8805C7D0
        public void ReadNumberValue(){} // RVA: 0x7FFE8805C830
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE8805D410
        public void ReadAsDecimal(){} // RVA: 0x7FFE8805D500
        public void ReadAsDouble(){} // RVA: 0x7FFE8805D5F0
        public void HandleNull(){} // RVA: 0x7FFE8805D6E0
        public void ReadFinished(){} // RVA: 0x7FFE8805D7F0
        public void ReadNullChar(){} // RVA: 0x7FFE8805D9A0
        public void EnsureBuffer(){} // RVA: 0x7FFE8805D9F0
        public void ReadStringIntoBuffer(){} // RVA: 0x7FFE8805DB00
        public void WriteCharToBuffer(){} // RVA: 0x7FFE8805E1C0
        public void ParseUnicode(){} // RVA: 0x7FFE8805E270
        public void ReadNumberIntoBuffer(){} // RVA: 0x7FFE8805E500
        public void ClearRecentString(){} // RVA: 0x7FFE8805E730
        public void ParsePostValue(){} // RVA: 0x7FFE8805E750
        public void ParseObject(){} // RVA: 0x7FFE8805EB80
        public void ParseProperty(){} // RVA: 0x7FFE8805ED90
        public void ValidIdentifierChar(){} // RVA: 0x7FFE8805F120
        public void ParseUnquotedProperty(){} // RVA: 0x7FFE8805F190
        public void ParseValue(){} // RVA: 0x7FFE8805F540
        public void ProcessLineFeed(){} // RVA: 0x7FFE88060180
        public void ProcessCarriageReturn(){} // RVA: 0x7FFE880601A0
        public void EatWhitespace(){} // RVA: 0x7FFE88060270
        public void ParseConstructor(){} // RVA: 0x7FFE880603B0
        public void ParseNumber(){} // RVA: 0x7FFE880608F0
        public void ParseComment(){} // RVA: 0x7FFE88062130
        public void EndComment(){} // RVA: 0x7FFE880624A0
        public void MatchValue(){} // RVA: 0x7FFE88062560
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7FFE88062650
        public void IsSeparator(){} // RVA: 0x7FFE88062900
        public void ParseTrue(){} // RVA: 0x7FFE88062A50
        public void ParseNull(){} // RVA: 0x7FFE88062BD0
        public void ParseUndefined(){} // RVA: 0x7FFE88062D20
        public void ParseFalse(){} // RVA: 0x7FFE88062E70
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7FFE880630A0
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7FFE880633B0
        public void ParseNumberNaN(){} // RVA: 0x7FFE880636C0
        public void Close(){} // RVA: 0x7FFE880639D0
        public void HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void get_LineNumber(){} // RVA: 0x7FFE88063B50
        public void get_LinePosition(){} // RVA: 0x7FFE88063BA0
    }

    public class JsonTextWriter : JsonWriter
    {
        public System.IO.TextWriter _writer; // 0x60
        public Valve.Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder; // 0x68

        // ── Methods ──
        public void get_Base64Encoder(){} // RVA: 0x7FFE88063BB0
        public void get_QuoteChar(){} // RVA: 0x7FFE86AD9D70
        public void .ctor(){} // RVA: 0x7FFE88063DB0
        public void Close(){} // RVA: 0x7FFE88063ED0
        public void WriteStartObject(){} // RVA: 0x7FFE88063FE0
        public void WriteStartArray(){} // RVA: 0x7FFE88064030
        public void WriteStartConstructor(){} // RVA: 0x7FFE88064080
        public void WriteEnd(){} // RVA: 0x7FFE88064140
        public void WritePropertyName(){} // RVA: 0x7FFE880642E0 | overloaded x2
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFE88064410
        public void UpdateCharEscapeFlags(){} // RVA: 0x7FFE88064420
        public void WriteIndent(){} // RVA: 0x7FFE880644F0
        public void WriteValueDelimiter(){} // RVA: 0x7FFE880646E0
        public void WriteIndentSpace(){} // RVA: 0x7FFE88064710
        public void WriteValueInternal(){} // RVA: 0x7FFE88064740
        public void WriteNull(){} // RVA: 0x7FFE88064770
        public void WriteUndefined(){} // RVA: 0x7FFE88064810
        public void WriteRaw(){} // RVA: 0x7FFE88064740
        public void WriteValue(){} // RVA: 0x7FFE88066020 | overloaded x22
        public void WriteEscapedString(){} // RVA: 0x7FFE88064980
        public void WriteComment(){} // RVA: 0x7FFE88066130
        public void EnsureWriteBuffer(){} // RVA: 0x7FFE88066200
        public void WriteIntegerValue(){} // RVA: 0x7FFE88066380 | overloaded x2
    }

    public class JsonWriter : Object
    {
        public dFixup.ÎÍÎÍÏÍÎ[][] StateArray;
        public dFixup.ÎÍÎÍÏÍÎ[][] StateArrayTempate; // 0x8
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.JsonPosition> _stack; // 0x10
        public Valve.Newtonsoft.Json.JsonPosition _currentPosition; // 0x18
        public dFixup.ÎÍÎÍÏÍÎ _currentState; // 0x30
        public 0x6663E06C _formatting; // 0x34
        public bool _closeOutput; // 0x38
        public 0x6663DE5C _dateFormatHandling; // 0x3C
        public 0x6663DF0C _dateTimeZoneHandling; // 0x40
        public 0x6663EE2C _stringEscapeHandling; // 0x44
        public 0x6663DFBC _floatFormatHandling; // 0x48
        public string _dateFormatString; // 0x50

        // ── Methods ──
        public void BuildStateArray(){} // RVA: 0x7FFE880664A0
        public void .cctor(){} // RVA: 0x7FFE88066910
        public void get_CloseOutput(){} // RVA: 0x7FFE812CF770
        public void set_CloseOutput(){} // RVA: 0x7FFE812D0010
        public void get_Top(){} // RVA: 0x7FFE880670E0
        public void get_WriteState(){} // RVA: 0x7FFE88067140
        public void get_ContainerPath(){} // RVA: 0x7FFE88067250
        public void get_Path(){} // RVA: 0x7FFE880672F0
        public void get_Formatting(){} // RVA: 0x7FFE82447220
        public void set_Formatting(){} // RVA: 0x7FFE88067470
        public void get_DateFormatHandling(){} // RVA: 0x7FFE816311C0
        public void set_DateFormatHandling(){} // RVA: 0x7FFE880674E0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE8119C080
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE88067550
        public void get_StringEscapeHandling(){} // RVA: 0x7FFE8119C0A0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFE880675C0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7FFE810FB310
        public void get_FloatFormatHandling(){} // RVA: 0x7FFE8119C0C0
        public void set_FloatFormatHandling(){} // RVA: 0x7FFE88067640
        public void get_DateFormatString(){} // RVA: 0x7FFE8119C0E0
        public void set_DateFormatString(){} // RVA: 0x7FFE812534D0
        public void get_Culture(){} // RVA: 0x7FFE880676B0
        public void set_Culture(){} // RVA: 0x7FFE811C3510
        public void .ctor(){} // RVA: 0x7FFE88067710
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7FFE86AF3900
        public void Push(){} // RVA: 0x7FFE88067730
        public void Pop(){} // RVA: 0x7FFE880678E0
        public void Peek(){} // RVA: 0x7FFE813DB630
        public void Close(){} // RVA: 0x7FFE88067A50
        public void WriteStartObject(){} // RVA: 0x7FFE88067AC0
        public void WriteEndObject(){} // RVA: 0x7FFE88067AD0
        public void WriteStartArray(){} // RVA: 0x7FFE88067AE0
        public void WriteEndArray(){} // RVA: 0x7FFE88067AF0
        public void WriteStartConstructor(){} // RVA: 0x7FFE88067B00
        public void WriteEndConstructor(){} // RVA: 0x7FFE88067B10
        public void WritePropertyName(){} // RVA: 0x7FFE86B88E10 | overloaded x2
        public void WriteEnd(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void WriteToken(){} // RVA: 0x7FFE880687F0 | overloaded x4
        public void WriteConstructorDate(){} // RVA: 0x7FFE88068A80
        public void AutoCompleteAll(){} // RVA: 0x7FFE88067A50
        public void GetCloseTokenForType(){} // RVA: 0x7FFE88068E30
        public void AutoCompleteClose(){} // RVA: 0x7FFE88068EE0
        public void WriteIndent(){} // RVA: 0x7FFE810FB310
        public void WriteValueDelimiter(){} // RVA: 0x7FFE810FB310
        public void WriteIndentSpace(){} // RVA: 0x7FFE810FB310
        public void AutoComplete(){} // RVA: 0x7FFE88069330
        public void WriteNull(){} // RVA: 0x7FFE88069560
        public void WriteUndefined(){} // RVA: 0x7FFE88069580
        public void WriteRaw(){} // RVA: 0x7FFE810FB310
        public void WriteRawValue(){} // RVA: 0x7FFE880695A0
        public void WriteValue(){} // RVA: 0x7FFE8806A1C0 | overloaded x38
        public void WriteComment(){} // RVA: 0x7FFE8806A110
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE8806A120
        public void Dispose(){} // RVA: 0x7FFE8806A190
        public void CreateUnsupportedTypeException(){} // RVA: 0x7FFE8806B4E0
        public void InternalWriteEnd(){} // RVA: 0x7FFE8806B5E0
        public void InternalWritePropertyName(){} // RVA: 0x7FFE88067B20
        public void InternalWriteRaw(){} // RVA: 0x7FFE810FB310
        public void InternalWriteStart(){} // RVA: 0x7FFE8806B5F0
        public void InternalWriteValue(){} // RVA: 0x7FFE8806B7B0
        public void InternalWriteComment(){} // RVA: 0x7FFE8806A110
    }

    public class JsonWriterException : JsonException
    {
        public string _path; // 0x90

        // ── Methods ──
        public void set_Path(){} // RVA: 0x7FFE818CE320
        public void .ctor(){} // RVA: 0x7FFE8806B830 | overloaded x3
        public void Create(){} // RVA: 0x7FFE8806B9C0 | overloaded x2
    }

}