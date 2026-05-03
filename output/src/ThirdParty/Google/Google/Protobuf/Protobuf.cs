// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 44
// Methods: 418

namespace ThirdParty.Google.Google.Protobuf
{
    public class ByteString : Object
    {
        public Google.Protobuf.ByteString empty;
        public System.ReadOnlyMemory`1<byte> bytes; // 0x10
        public object field_2; // 0x8CD

        // ── Methods ──
        public void AttachBytes(){} // RVA: 0x7FFE8655F880 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE82D033D0
        public void get_Empty(){} // RVA: 0x7FFE8655FA70
        public void get_Length(){} // RVA: 0x7FFE8655FAD0
        public void get_Span(){} // RVA: 0x7FFE8655FB10
        public void ToBase64(){} // RVA: 0x7FFE8655FB70
        public void CopyFrom(){} // RVA: 0x7FFE8655FD90
        public void GetEnumerator(){} // RVA: 0x7FFE8655FF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8655FF60
        public void CreateCodedInput(){} // RVA: 0x7FFE86560060
        public void op_Equality(){} // RVA: 0x7FFE86560420
        public void op_Inequality(){} // RVA: 0x7FFE865604F0
        public void Equals(){} // RVA: 0x7FFE865607C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86560730
        public void .cctor(){} // RVA: 0x7FFE865608C0
    }

    public class CodedInputStream : Object
    {
        public bool leaveOpen; // 0x10
        public byte[] buffer; // 0x18
        public System.IO.Stream input; // 0x20
        public Google.Protobuf.ParserInternalState state; // 0x28
        public int bufferPos; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86560D10 | overloaded x3
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFE86560ED0
        public void set_ExtensionRegistry(){} // RVA: 0x7FFE8171B4D0
        public void get_InternalBuffer(){} // RVA: 0x7FFE810FE7C0
        public void get_InternalInputStream(){} // RVA: 0x7FFE811290C0
        public void get_InternalState(){} // RVA: 0x7FFE86560EE0
        public void Dispose(){} // RVA: 0x7FFE86560EF0
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFE86560F30
        public void ReadRawMessage(){} // RVA: 0x7FFE86560FA0
    }

    public class CodedOutputStream : Object
    {
        public int DefaultBufferSize;
        public bool leaveOpen; // 0x10
        public byte[] buffer; // 0x18

        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x7FFE865610B0
        public void ComputeInt64Size(){} // RVA: 0x7FFE86561100
        public void ComputeInt32Size(){} // RVA: 0x7FFE86561150
        public void ComputeFixed64Size(){} // RVA: 0x7FFE82199910
        public void ComputeFixed32Size(){} // RVA: 0x7FFE8180E590
        public void ComputeStringSize(){} // RVA: 0x7FFE865611F0
        public void ComputeMessageSize(){} // RVA: 0x7FFE865612A0
        public void ComputeBytesSize(){} // RVA: 0x7FFE86561330
        public void ComputeUInt32Size(){} // RVA: 0x7FFE865613F0
        public void ComputeEnumSize(){} // RVA: 0x7FFE86561480
        public void ComputeLengthSize(){} // RVA: 0x7FFE865614D0
        public void ComputeRawVarint32Size(){} // RVA: 0x7FFE86561560
        public void ComputeRawVarint64Size(){} // RVA: 0x7FFE865615A0
        public void ComputeTagSize(){} // RVA: 0x7FFE86561640
        public void .ctor(){} // RVA: 0x7FFE86561710 | overloaded x2
        public void WriteRawMessage(){} // RVA: 0x7FFE86561940
        public void Dispose(){} // RVA: 0x7FFE86561B00
        public void Flush(){} // RVA: 0x7FFE86561C00
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFE86561CD0
        public void get_InternalBuffer(){} // RVA: 0x7FFE810FE7C0
        public void get_InternalOutputStream(){} // RVA: 0x7FFE8143BA80
        public void get_InternalState(){} // RVA: 0x7FFE86561CE0
        public void .cctor(){} // RVA: 0x7FFE86561CF0
    }

    public class Extension : Object
    {
        public int _fieldNumber; // 0x10
        public object field_1; // 0xD
        public object field_2; // 0xE

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void CreateValue(){} // RVA: 0x7FFE80E2E2E0
        public void get_FieldNumber(){} // RVA: 0x7FFE811485C0
        public void get_IsRepeated(){} // RVA: 0x7FFE80E2F150
    }

    public class ExtensionRegistry : Object
    {
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.ObjectIntPair`1<System.Type>,Google.Protobuf.Extension> extensions; // 0x10
        public object field_1; // 0x15

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86561E40 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE865622B0
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void ContainsInputField(){} // RVA: 0x7FFE86562300
        public void Add(){} // RVA: 0x7FFE86562470
        public void AddRange(){} // RVA: 0x7FFE865625E0
        public void Clear(){} // RVA: 0x7FFE86562800
        public void Contains(){} // RVA: 0x7FFE86562850
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(){} // RVA: 0x7FFE86562A30
        public void GetEnumerator(){} // RVA: 0x7FFE86562D50
        public void Remove(){} // RVA: 0x7FFE86562DD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86562D50
        public void Clone(){} // RVA: 0x7FFE86562FB0
    }

    public class ExtensionSet : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFE80E329F0
        public void Get(){} // RVA: 0x7FFE80E2E440 | overloaded x2
        public void GetOrInitialize(){} // RVA: 0x7FFE80E2E440
        public void Set(){} // RVA: 0x7FFE810A1420
        public void Has(){} // RVA: 0x7FFE80E2F7A0
        public void Clear(){} // RVA: 0x7FFE80E462E0 | overloaded x2
        public void TryMergeFieldFrom(){} // RVA: 0x7FFE80E2F7A0
        public void MergeFrom(){} // RVA: 0x7FFE80E462E0
        public void Clone(){} // RVA: 0x7FFE80E2E3D0
    }

    public class ExtensionSet`1 : Object
    {
        public System.Collections.Generic.Dictionary`2<int,Google.Protobuf.IExtensionValue> _valuesByNumber;

        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0x7FFE80E2E2E0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void CalculateSize(){} // RVA: 0x7FFE80E2EDB0
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ExtensionValue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void CalculateSize(){} // RVA: 0x7FFE80E2EDB0
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void MergeFrom(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void GetValue(){} // RVA: 0x7FFE810A1420
        public void SetValue(){} // RVA: 0x7FFE810A1420
    }

    public class Extension`2 : Extension
    {
        public Google.Protobuf.FieldCodec`1<T> codec;
        public object field_1; // 0x10
        public object field_2; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220
        public void get_DefaultValue(){} // RVA: 0x7FFE810A1420
        public void get_TargetType(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsRepeated(){} // RVA: 0x7FFE80E2F150
        public void CreateValue(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FieldCodec : Object
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x7FFE86563500 | overloaded x2
        public void ForInt32(){} // RVA: 0x7FFE86563800 | overloaded x2
        public void ForUInt32(){} // RVA: 0x7FFE86563C80 | overloaded x2
        public void ForFloat(){} // RVA: 0x7FFE86564100 | overloaded x2
        public void ForMessage(){} // RVA: 0x7FFE810A1420
    }

    public class FieldCodec`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<T> EqualityComparer;
        public T DefaultDefault;
        public bool TypeSupportsPacking;
        public bool _packedRepeatedField;
        public Google.Protobuf.ValueWriter`1<T> _valueWriter;
        public System.Func`2<T,int> _valueSizeCalculator;
        public Google.Protobuf.ValueReader`1<T> _valueReader;
        public InputMerger<T> _valueMerger;
        public ValuesMerger<T> _fieldMerger;
        public int _fixedSize;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void IsPackedRepeatedField(){} // RVA: 0x7FFE80E2FBF0
        public void get_PackedRepeatedField(){} // RVA: 0x7FFE80E2F150
        public void get_ValueWriter(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueSizeCalculator(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueReader(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueMerger(){} // RVA: 0x7FFE80E2E2E0
        public void get_FieldMerger(){} // RVA: 0x7FFE80E2E2E0
        public void get_FixedSize(){} // RVA: 0x7FFE80E2EDB0
        public void get_Tag(){} // RVA: 0x7FFE80E2EDB0
        public void get_EndTag(){} // RVA: 0x7FFE80E2EDB0
        public void get_DefaultValue(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void WriteTagAndValue(){} // RVA: 0x7FFE810A1420
        public void Read(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CalculateSizeWithTag(){} // RVA: 0x7FFE810A1420
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x7FFE810A1420
        public void IsDefault(){} // RVA: 0x7FFE810A1420
    }

    public class FieldMaskTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865647F0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE865648B0
        public void AddFieldPath(){} // RVA: 0x7FFE865648F0
        public void MergeFromFieldMask(){} // RVA: 0x7FFE86564B80
        public void ToFieldMask(){} // RVA: 0x7FFE86564D60
        public void GetFieldPaths(){} // RVA: 0x7FFE86564E90
        public void IntersectFieldPath(){} // RVA: 0x7FFE86565140
        public void Merge(){} // RVA: 0x7FFE86565660 | overloaded x2
    }

    public class FrameworkPortability : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE865661C0
    }

    public class IBufferMessage
    {
        // ── Methods ──
        public void InternalMergeFrom(){} // RVA: 0x7FFE80E460A0
        public void InternalWriteTo(){} // RVA: 0x7FFE80E460A0
    }

    public class ICustomDiagnosticMessage
    {
        // ── Methods ──
        public void ToDiagnosticString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFE810A1420
    }

    public class IExtendableMessage`1
    {
        // ── Methods ──
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0
    }

    public class IExtensionValue
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void CalculateSize(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IMessage
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFE80E460A0
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void CalculateSize(){} // RVA: 0x7FFE80E2EDB0
        public void get_Descriptor(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IMessage`1
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFE810A1420
    }

    public class InvalidProtocolBufferException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86566390
        public void MoreDataAvailable(){} // RVA: 0x7FFE865663B0
        public void TruncatedMessage(){} // RVA: 0x7FFE86566420
        public void NegativeSize(){} // RVA: 0x7FFE86566490
        public void MalformedVarint(){} // RVA: 0x7FFE86566500
        public void InvalidTag(){} // RVA: 0x7FFE86566570
        public void InvalidWireType(){} // RVA: 0x7FFE865665E0
        public void InvalidEndTag(){} // RVA: 0x7FFE86566650
        public void RecursionLimitExceeded(){} // RVA: 0x7FFE865666C0
        public void SizeLimitExceeded(){} // RVA: 0x7FFE86566730
    }

    public class JsonFormatter : Object
    {
        public Google.Protobuf.JsonFormatter _default;
        public Google.Protobuf.JsonFormatter diagnosticFormatter; // 0x8

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFE865667A0
        public void .cctor(){} // RVA: 0x7FFE86566800
        public void get_DiagnosticOnly(){} // RVA: 0x7FFE86567D20
        public void .ctor(){} // RVA: 0x7FFE86567D80
        public void Format(){} // RVA: 0x7FFE86567F20 | overloaded x2
        public void ToDiagnosticString(){} // RVA: 0x7FFE865680D0
        public void WriteMessage(){} // RVA: 0x7FFE86568230
        public void WriteMessageFields(){} // RVA: 0x7FFE86568430
        public void ShouldFormatFieldValue(){} // RVA: 0x7FFE86568A10
        public void ToJsonName(){} // RVA: 0x7FFE86568B80
        public void WriteNull(){} // RVA: 0x7FFE86568CF0
        public void IsDefaultValue(){} // RVA: 0x7FFE86568D50
        public void WriteValue(){} // RVA: 0x7FFE865692B0
        public void WriteWellKnownTypeValue(){} // RVA: 0x7FFE86569C90
        public void WriteTimestamp(){} // RVA: 0x7FFE8656A4D0
        public void WriteDuration(){} // RVA: 0x7FFE8656A740
        public void WriteFieldMask(){} // RVA: 0x7FFE8656A9B0
        public void WriteAny(){} // RVA: 0x7FFE8656AB80
        public void WriteDiagnosticOnlyAny(){} // RVA: 0x7FFE8656B080
        public void WriteStruct(){} // RVA: 0x7FFE8656B3E0
        public void WriteStructFieldValue(){} // RVA: 0x7FFE8656B8C0
        public void WriteList(){} // RVA: 0x7FFE8656BC20
        public void WriteDictionary(){} // RVA: 0x7FFE8656BF00
        public void WriteString(){} // RVA: 0x7FFE8656C5A0
        public void HexEncodeUtf16CodeUnit(){} // RVA: 0x7FFE8656C9B0
    }

    public class MessageExtensions : Object
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFE8656E300 | overloaded x5
        public void ToByteArray(){} // RVA: 0x7FFE8656DBB0
        public void ToByteString(){} // RVA: 0x7FFE8656DD00
        public void WriteTo(){} // RVA: 0x7FFE8656DDE0
    }

    public class MessageParser : Object
    {
        public System.Func`1<Google.Protobuf.IMessage> factory; // 0x10
        public bool _discardUnknownFields; // 0x18

        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFE811164E0
        public void get_Extensions(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE8656E510
        public void CreateTemplate(){} // RVA: 0x7FFE82001D60
        public void ParseFrom(){} // RVA: 0x7FFE8656E5D0
    }

    public class MessageParser`1 : MessageParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4C2D0 | overloaded x2
        public void CreateTemplate(){} // RVA: 0x7FFE810A1420
        public void ParseFrom(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void WithExtensionRegistry(){} // RVA: 0x7FFE80E2E390
    }

    public class ObjectIntPair`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ParseContext : ValueType
    {
        public System.ReadOnlySpan`1<byte> buffer; // 0x10
        public Google.Protobuf.ParserInternalState state; // 0x20
        public object field_2; // 0x2D

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE8656E960 | overloaded x5
        public void get_LastTag(){} // RVA: 0x7FFE81E60180
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFE811DACE0
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFE811DACF0
        public void get_ExtensionRegistry(){} // RVA: 0x7FFE8113A010
        public void set_ExtensionRegistry(){} // RVA: 0x7FFE81280F90
        public void ReadTag(){} // RVA: 0x7FFE8656EA80
        public void ReadDouble(){} // RVA: 0x7FFE8656EA90
        public void ReadFloat(){} // RVA: 0x7FFE8656EAA0
        public void ReadUInt64(){} // RVA: 0x7FFE8656EAB0
        public void ReadInt64(){} // RVA: 0x7FFE8656EAB0
        public void ReadInt32(){} // RVA: 0x7FFE8656EAC0
        public void ReadFixed64(){} // RVA: 0x7FFE8656EAD0
        public void ReadFixed32(){} // RVA: 0x7FFE8656EAE0
        public void ReadBool(){} // RVA: 0x7FFE8656EAF0
        public void ReadString(){} // RVA: 0x7FFE8656EB10
        public void ReadMessage(){} // RVA: 0x7FFE8656EB50
        public void ReadBytes(){} // RVA: 0x7FFE8656EBB0
        public void ReadUInt32(){} // RVA: 0x7FFE8656EAC0
        public void ReadEnum(){} // RVA: 0x7FFE8656EAC0
        public void ReadLength(){} // RVA: 0x7FFE8656EAC0
        public void CopyStateTo(){} // RVA: 0x7FFE8656EBC0
        public void LoadStateFrom(){} // RVA: 0x7FFE8656EC80
    }

    public class ParserInternalState : ValueType
    {
        public int bufferPos; // 0x10
        public int bufferSize; // 0x14
        public int bufferSizeAfterLimit; // 0x18

        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0x7FFE811C3500
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFE81E8DCD0
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFE8656ED40
        public void get_ExtensionRegistry(){} // RVA: 0x7FFE81463AE0
        public void set_ExtensionRegistry(){} // RVA: 0x7FFE81464570
    }

    public class ParsingPrimitives : Object
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x7FFE8656ED50
        public void ParseTag(){} // RVA: 0x7FFE8656ED60
        public void MaybeConsumeTag(){} // RVA: 0x7FFE8656EE80
        public void PeekTag(){} // RVA: 0x7FFE8656EEE0
        public void ParseRawVarint64(){} // RVA: 0x7FFE8656EF20
        public void ParseRawVarint64SlowPath(){} // RVA: 0x7FFE8656F0A0
        public void ParseRawVarint32(){} // RVA: 0x7FFE8656F180
        public void ParseRawVarint32SlowPath(){} // RVA: 0x7FFE8656F350
        public void ParseRawLittleEndian32(){} // RVA: 0x7FFE8656F4F0
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x7FFE8656F5D0
        public void ParseRawLittleEndian64(){} // RVA: 0x7FFE8656F720
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x7FFE8656F800
        public void ParseDouble(){} // RVA: 0x7FFE8656FAA0
        public void ParseFloat(){} // RVA: 0x7FFE8656FB60
        public void ParseFloatSlow(){} // RVA: 0x7FFE8656FC20
        public void ReadRawBytes(){} // RVA: 0x7FFE8656FD20
        public void ReadRawBytesSlow(){} // RVA: 0x7FFE8656FF10
        public void SkipRawBytes(){} // RVA: 0x7FFE86570590
        public void ReadString(){} // RVA: 0x7FFE865706A0
        public void ReadBytes(){} // RVA: 0x7FFE865706E0
        public void ReadRawString(){} // RVA: 0x7FFE86570760
        public void ReadStringSlow(){} // RVA: 0x7FFE865708F0
        public void ValidateCurrentLimit(){} // RVA: 0x7FFE86570DF0
        public void ReadRawByte(){} // RVA: 0x7FFE86570E60
        public void IsDataAvailable(){} // RVA: 0x7FFE86570ED0
        public void IsDataAvailableInSource(){} // RVA: 0x7FFE86570EF0
        public void ReadRawBytesIntoSpan(){} // RVA: 0x7FFE86570FB0
    }

    public class ParsingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x7FFE865711C0
        public void SkipGroup(){} // RVA: 0x7FFE86571380
        public void ReadMessage(){} // RVA: 0x7FFE86571530
        public void ReadMapEntry(){} // RVA: 0x7FFE810A1420
        public void ReadGroup(){} // RVA: 0x7FFE86571690
        public void ReadRawMessage(){} // RVA: 0x7FFE865717A0
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFE86571940
        public void CheckLastTagWas(){} // RVA: 0x7FFE86571980
        public void .cctor(){} // RVA: 0x7FFE865719C0
    }

    public class ProtoPreconditions : Object
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x7FFE810A1420
        public void CheckNotNullUnconstrained(){} // RVA: 0x7FFE810A1420
    }

    public class RepeatedExtensionValue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void CalculateSize(){} // RVA: 0x7FFE80E2EDB0
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void MergeFrom(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void GetValue(){} // RVA: 0x7FFE80E2E2E0
    }

    public class RepeatedExtension`2 : Extension
    {
        public Google.Protobuf.FieldCodec`1<T> codec;
        public object field_1; // 0x13

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsRepeated(){} // RVA: 0x7FFE80E2F150
        public void CreateValue(){} // RVA: 0x7FFE80E2E2E0
    }

    public class SegmentedBufferHelper : ValueType
    {
        public System.Nullable`1<int> totalLength; // 0x10
        public Enumerator<byte> readOnlySequenceEnumerator; // 0x18

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE86571B70 | overloaded x2
        public void RefillBuffer(){} // RVA: 0x7FFE86571EC0
        public void get_TotalLength(){} // RVA: 0x7FFE8284EF60
        public void get_CodedInputStream(){} // RVA: 0x7FFE81178740
        public void PushLimit(){} // RVA: 0x7FFE86571EF0
        public void PopLimit(){} // RVA: 0x7FFE86571F90
        public void IsReachedLimit(){} // RVA: 0x7FFE86571FC0
        public void IsAtEnd(){} // RVA: 0x7FFE86571FE0
        public void RefillFromReadOnlySequence(){} // RVA: 0x7FFE86572030
        public void RefillFromCodedInputStream(){} // RVA: 0x7FFE86572250
        public void RecomputeBufferSizeAfterLimit(){} // RVA: 0x7FFE86572470
        public void CheckCurrentBufferIsEmpty(){} // RVA: 0x7FFE865724A0
    }

    public class UnknownField : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE86572510
        public void GetHashCode(){} // RVA: 0x7FFE86572770
        public void WriteTo(){} // RVA: 0x7FFE86572870
        public void GetSerializedSize(){} // RVA: 0x7FFE86573170
        public void MergeFrom(){} // RVA: 0x7FFE86573920
        public void AddAll(){} // RVA: 0x7FFE80E2E440
        public void AddVarint(){} // RVA: 0x7FFE86573ED0
        public void AddFixed32(){} // RVA: 0x7FFE86573F70
        public void AddFixed64(){} // RVA: 0x7FFE865740D0
        public void AddLengthDelimited(){} // RVA: 0x7FFE86574170
        public void AddGroup(){} // RVA: 0x7FFE86574210
        public void Add(){} // RVA: 0x7FFE810A1420
    }

    public class UnknownFieldSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865742B0
        public void HasField(){} // RVA: 0x7FFE86574370
        public void WriteTo(){} // RVA: 0x7FFE865743D0
        public void CalculateSize(){} // RVA: 0x7FFE865745F0
        public void Equals(){} // RVA: 0x7FFE86574810
        public void GetHashCode(){} // RVA: 0x7FFE86574BF0
        public void GetOrAddField(){} // RVA: 0x7FFE86574E30
        public void AddOrReplaceField(){} // RVA: 0x7FFE86574F60
        public void MergeFieldFrom(){} // RVA: 0x7FFE865756F0 | overloaded x2
        public void MergeGroupFrom(){} // RVA: 0x7FFE86575690
        public void MergeFrom(){} // RVA: 0x7FFE86575B20 | overloaded x2
        public void MergeField(){} // RVA: 0x7FFE86575BA0
        public void Clone(){} // RVA: 0x7FFE86575CC0
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class WireFormat : Object
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x7FFE86575D40
        public void GetTagFieldNumber(){} // RVA: 0x7FFE86575D50
        public void MakeTag(){} // RVA: 0x7FFE86575D60
    }

    public class WriteBufferHelper : ValueType
    {
        public System.Buffers.IBufferWriter`1<byte> bufferWriter; // 0x10

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7FFE826F4210
        public void Initialize(){} // RVA: 0x7FFE86575D70
        public void InitializeNonRefreshable(){} // RVA: 0x7FFE86575E20
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFE86575ED0
        public void GetSpaceLeft(){} // RVA: 0x7FFE86575F40
        public void RefreshBuffer(){} // RVA: 0x7FFE86575FC0
        public void Flush(){} // RVA: 0x7FFE86576100
    }

    public class WriteContext : ValueType
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE86576230 | overloaded x2
        public void WriteDouble(){} // RVA: 0x7FFE86576290
        public void WriteFloat(){} // RVA: 0x7FFE86576340
        public void WriteUInt64(){} // RVA: 0x7FFE86576490
        public void WriteInt64(){} // RVA: 0x7FFE86576540
        public void WriteInt32(){} // RVA: 0x7FFE865765F0
        public void WriteFixed64(){} // RVA: 0x7FFE86576660
        public void WriteFixed32(){} // RVA: 0x7FFE86576710
        public void WriteBool(){} // RVA: 0x7FFE865768B0
        public void WriteString(){} // RVA: 0x7FFE86576960
        public void WriteMessage(){} // RVA: 0x7FFE865769D0
        public void WriteBytes(){} // RVA: 0x7FFE86576A90
        public void WriteUInt32(){} // RVA: 0x7FFE86576BD0
        public void WriteEnum(){} // RVA: 0x7FFE86576C80
        public void WriteLength(){} // RVA: 0x7FFE86576D30
        public void WriteTag(){} // RVA: 0x7FFE86576E60 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x7FFE86576FC0 | overloaded x2
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFE865770D0
        public void CopyStateTo(){} // RVA: 0x7FFE865770E0
        public void LoadStateFrom(){} // RVA: 0x7FFE86577150
    }

    public class WriterInternalState : ValueType
    {
        public int limit; // 0x10

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7FFE81116380
    }

    public class WritingPrimitives : Object
    {
        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x7FFE865771C0
        public void WriteFloat(){} // RVA: 0x7FFE86577230
        public void WriteFloatSlowPath(){} // RVA: 0x7FFE86577350
        public void WriteUInt64(){} // RVA: 0x7FFE86577470
        public void WriteInt64(){} // RVA: 0x7FFE865774E0
        public void WriteInt32(){} // RVA: 0x7FFE86577550
        public void WriteFixed64(){} // RVA: 0x7FFE865775F0
        public void WriteFixed32(){} // RVA: 0x7FFE86577660
        public void WriteBool(){} // RVA: 0x7FFE865777D0
        public void WriteString(){} // RVA: 0x7FFE86577840
        public void WriteAsciiStringToBuffer(){} // RVA: 0x7FFE86577AF0
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x7FFE86577C80
        public void WriteStringToBuffer(){} // RVA: 0x7FFE86577CA0
        public void WriteBytes(){} // RVA: 0x7FFE86577E00
        public void WriteUInt32(){} // RVA: 0x7FFE86577F10
        public void WriteEnum(){} // RVA: 0x7FFE86577F80
        public void WriteLength(){} // RVA: 0x7FFE86577FF0
        public void WriteRawVarint32(){} // RVA: 0x7FFE86578060
        public void WriteRawVarint64(){} // RVA: 0x7FFE86578210
        public void WriteRawLittleEndian32(){} // RVA: 0x7FFE865783C0
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x7FFE865784F0
        public void WriteRawLittleEndian64(){} // RVA: 0x7FFE865785A0
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x7FFE865786D0
        public void WriteRawByte(){} // RVA: 0x7FFE865787E0
        public void WriteRawBytes(){} // RVA: 0x7FFE86578920 | overloaded x2
        public void WriteTag(){} // RVA: 0x7FFE86578CE0 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x7FFE86578DC0 | overloaded x2
        public void WriteRawTagSlowPath(){} // RVA: 0x7FFE86578EA0
        public void .cctor(){} // RVA: 0x7FFE86578F30
    }

    public class WritingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x7FFE86578FD0
        public void WriteRawMessage(){} // RVA: 0x7FFE86579090
    }

}