// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 44
// Methods: 418

namespace ThirdParty.Google.Google.Protobuf
{
    public class ByteString
    {
        // ── Methods ──
        public void AttachBytes(){} // RVA: 0x5A1EB20 | overloaded x2
        public void .ctor(){} // RVA: 0x1F77B90
        public void get_Empty(){} // RVA: 0x5A1ED10
        public void get_Length(){} // RVA: 0x5A1ED70
        public void get_Span(){} // RVA: 0x5A1EDB0
        public void ToBase64(){} // RVA: 0x5A1EE10
        public void CopyFrom(){} // RVA: 0x5A1F030
        public void GetEnumerator(){} // RVA: 0x5A1F200
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5A1F200
        public void CreateCodedInput(){} // RVA: 0x5A1F300
        public void op_Equality(){} // RVA: 0x5A1F6C0
        public void op_Inequality(){} // RVA: 0x5A1F790
        public void Equals(){} // RVA: 0x5A1FA60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A1F9D0
        public void .cctor(){} // RVA: 0x5A1FB60
    }

    public class CodedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A1FFB0 | overloaded x3
        public void set_DiscardUnknownFields(){} // RVA: 0x5A20170
        public void set_ExtensionRegistry(){} // RVA: 0x9AA5F0
        public void get_InternalBuffer(){} // RVA: 0x2E07C0
        public void get_InternalInputStream(){} // RVA: 0x30B0C0
        public void get_InternalState(){} // RVA: 0x5A20180
        public void Dispose(){} // RVA: 0x5A20190
        public void CheckReadEndOfStreamTag(){} // RVA: 0x5A201D0
        public void ReadRawMessage(){} // RVA: 0x5A20240
    }

    public class CodedOutputStream
    {
        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x5A20350
        public void ComputeInt64Size(){} // RVA: 0x5A203A0
        public void ComputeInt32Size(){} // RVA: 0x5A203F0
        public void ComputeFixed64Size(){} // RVA: 0xA63AE0
        public void ComputeFixed32Size(){} // RVA: 0xA7E130
        public void ComputeStringSize(){} // RVA: 0x5A20490
        public void ComputeMessageSize(){} // RVA: 0x5A20540
        public void ComputeBytesSize(){} // RVA: 0x5A205D0
        public void ComputeUInt32Size(){} // RVA: 0x5A20690
        public void ComputeEnumSize(){} // RVA: 0x5A20720
        public void ComputeLengthSize(){} // RVA: 0x5A20770
        public void ComputeRawVarint32Size(){} // RVA: 0x5A20800
        public void ComputeRawVarint64Size(){} // RVA: 0x5A20840
        public void ComputeTagSize(){} // RVA: 0x5A208E0
        public void .ctor(){} // RVA: 0x5A209B0 | overloaded x2
        public void WriteRawMessage(){} // RVA: 0x5A20BE0
        public void Dispose(){} // RVA: 0x5A20DA0
        public void Flush(){} // RVA: 0x5A20EA0
        public void CheckNoSpaceLeft(){} // RVA: 0x5A20F70
        public void get_InternalBuffer(){} // RVA: 0x2E07C0
        public void get_InternalOutputStream(){} // RVA: 0x4976A0
        public void get_InternalState(){} // RVA: 0x5A20F80
        public void .cctor(){} // RVA: 0x5A20F90
    }

    public class Extension
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2E00C0
        public void CreateValue(){} // RVA: 0xCD60
        public void get_FieldNumber(){} // RVA: 0x32A5C0
        public void get_IsRepeated(){} // RVA: 0xDBE0
    }

    public class ExtensionRegistry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A210E0 | overloaded x2
        public void get_Count(){} // RVA: 0x5A21550
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void ContainsInputField(){} // RVA: 0x5A215A0
        public void Add(){} // RVA: 0x5A21710
        public void AddRange(){} // RVA: 0x5A21880
        public void Clear(){} // RVA: 0x5A21AA0
        public void Contains(){} // RVA: 0x5A21AF0
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(){} // RVA: 0x5A21CD0
        public void GetEnumerator(){} // RVA: 0x5A21FF0
        public void Remove(){} // RVA: 0x5A22070
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5A21FF0
        public void Clone(){} // RVA: 0x5A22250
    }

    public class ExtensionSet
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x114C0
        public void Get(){} // RVA: 0xCEC0 | overloaded x2
        public void GetOrInitialize(){} // RVA: 0xCEC0
        public void Set(){} // RVA: 0x283FA0
        public void Has(){} // RVA: 0xE230
        public void Clear(){} // RVA: 0x24D50 | overloaded x2
        public void TryMergeFieldFrom(){} // RVA: 0xE230
        public void MergeFrom(){} // RVA: 0x24D50
        public void Clone(){} // RVA: 0xCE50
    }

    public class ExtensionSet`1
    {
        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0xCD60
        public void GetHashCode(){} // RVA: 0xD840
        public void Equals(){} // RVA: 0xDE40
        public void CalculateSize(){} // RVA: 0xD840
        public void WriteTo(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ExtensionValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void CalculateSize(){} // RVA: 0xD840
        public void Clone(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void MergeFrom(){} // RVA: 0x24B10 | overloaded x2
        public void WriteTo(){} // RVA: 0x24B10
        public void GetValue(){} // RVA: 0x283FA0
        public void SetValue(){} // RVA: 0x283FA0
    }

    public class Extension`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40
        public void get_DefaultValue(){} // RVA: 0x283FA0
        public void get_TargetType(){} // RVA: 0xCD60
        public void get_IsRepeated(){} // RVA: 0xDBE0
        public void CreateValue(){} // RVA: 0xCD60
    }

    public class FieldCodec
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x5A227A0 | overloaded x2
        public void ForInt32(){} // RVA: 0x5A22AA0 | overloaded x2
        public void ForUInt32(){} // RVA: 0x5A22F20 | overloaded x2
        public void ForFloat(){} // RVA: 0x5A233A0 | overloaded x2
        public void ForMessage(){} // RVA: 0x283FA0
    }

    public class FieldCodec`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void IsPackedRepeatedField(){} // RVA: 0xE680
        public void get_PackedRepeatedField(){} // RVA: 0xDBE0
        public void get_ValueWriter(){} // RVA: 0xCD60
        public void get_ValueSizeCalculator(){} // RVA: 0xCD60
        public void get_ValueReader(){} // RVA: 0xCD60
        public void get_ValueMerger(){} // RVA: 0xCD60
        public void get_FieldMerger(){} // RVA: 0xCD60
        public void get_FixedSize(){} // RVA: 0xD840
        public void get_Tag(){} // RVA: 0xD840
        public void get_EndTag(){} // RVA: 0xD840
        public void get_DefaultValue(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x4
        public void WriteTagAndValue(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0 | overloaded x2
        public void CalculateSizeWithTag(){} // RVA: 0x283FA0
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x283FA0
        public void IsDefault(){} // RVA: 0x283FA0
    }

    public class FieldMaskTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A23A90 | overloaded x2
        public void ToString(){} // RVA: 0x5A23B50
        public void AddFieldPath(){} // RVA: 0x5A23B90
        public void MergeFromFieldMask(){} // RVA: 0x5A23E20
        public void ToFieldMask(){} // RVA: 0x5A24000
        public void GetFieldPaths(){} // RVA: 0x5A24130
        public void IntersectFieldPath(){} // RVA: 0x5A243E0
        public void Merge(){} // RVA: 0x5A24900 | overloaded x2
    }

    public class FrameworkPortability
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5A25460
    }

    public class IBufferMessage
    {
        // ── Methods ──
        public void InternalMergeFrom(){} // RVA: 0x24B10
        public void InternalWriteTo(){} // RVA: 0x24B10
    }

    public class ICustomDiagnosticMessage
    {
        // ── Methods ──
        public void ToDiagnosticString(){} // RVA: 0xCD60
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x283FA0
    }

    public class IExtendableMessage`1
    {
        // ── Methods ──
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10
    }

    public class IExtensionValue
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x24B10 | overloaded x2
        public void WriteTo(){} // RVA: 0x24B10
        public void CalculateSize(){} // RVA: 0xD840
    }

    public class IMessage
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x24B10
        public void WriteTo(){} // RVA: 0x24B10
        public void CalculateSize(){} // RVA: 0xD840
        public void get_Descriptor(){} // RVA: 0xCD60
    }

    public class IMessage`1
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x283FA0
    }

    public class InvalidProtocolBufferException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A25630
        public void MoreDataAvailable(){} // RVA: 0x5A25650
        public void TruncatedMessage(){} // RVA: 0x5A256C0
        public void NegativeSize(){} // RVA: 0x5A25730
        public void MalformedVarint(){} // RVA: 0x5A257A0
        public void InvalidTag(){} // RVA: 0x5A25810
        public void InvalidWireType(){} // RVA: 0x5A25880
        public void InvalidEndTag(){} // RVA: 0x5A258F0
        public void RecursionLimitExceeded(){} // RVA: 0x5A25960
        public void SizeLimitExceeded(){} // RVA: 0x5A259D0
    }

    public class JsonFormatter
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x5A25A40
        public void .cctor(){} // RVA: 0x5A25AA0
        public void get_DiagnosticOnly(){} // RVA: 0x5A26FC0
        public void .ctor(){} // RVA: 0x5A27020
        public void Format(){} // RVA: 0x5A271C0 | overloaded x2
        public void ToDiagnosticString(){} // RVA: 0x5A27370
        public void WriteMessage(){} // RVA: 0x5A274D0
        public void WriteMessageFields(){} // RVA: 0x5A276D0
        public void ShouldFormatFieldValue(){} // RVA: 0x5A27CB0
        public void ToJsonName(){} // RVA: 0x5A27E20
        public void WriteNull(){} // RVA: 0x5A27F90
        public void IsDefaultValue(){} // RVA: 0x5A27FF0
        public void WriteValue(){} // RVA: 0x5A28550
        public void WriteWellKnownTypeValue(){} // RVA: 0x5A28F30
        public void WriteTimestamp(){} // RVA: 0x5A29770
        public void WriteDuration(){} // RVA: 0x5A299E0
        public void WriteFieldMask(){} // RVA: 0x5A29C50
        public void WriteAny(){} // RVA: 0x5A29E20
        public void WriteDiagnosticOnlyAny(){} // RVA: 0x5A2A320
        public void WriteStruct(){} // RVA: 0x5A2A680
        public void WriteStructFieldValue(){} // RVA: 0x5A2AB60
        public void WriteList(){} // RVA: 0x5A2AEC0
        public void WriteDictionary(){} // RVA: 0x5A2B1A0
        public void WriteString(){} // RVA: 0x5A2B840
        public void HexEncodeUtf16CodeUnit(){} // RVA: 0x5A2BC50
    }

    public class MessageExtensions
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x5A2D5A0 | overloaded x5
        public void ToByteArray(){} // RVA: 0x5A2CE50
        public void ToByteString(){} // RVA: 0x5A2CFA0
        public void WriteTo(){} // RVA: 0x5A2D080
    }

    public class MessageParser
    {
        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x2F84E0
        public void get_Extensions(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x5A2D7B0
        public void CreateTemplate(){} // RVA: 0x1281E30
        public void ParseFrom(){} // RVA: 0x5A2D870
    }

    public class MessageParser`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2AD00 | overloaded x2
        public void CreateTemplate(){} // RVA: 0x283FA0
        public void ParseFrom(){} // RVA: 0x283FA0 | overloaded x2
        public void WithExtensionRegistry(){} // RVA: 0xCE10
    }

    public class ObjectIntPair`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
    }

    public class ParseContext
    {
        public object CodedInputStream;
        public object DiscardUnknownFields;
        public object ExtensionRegistry;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x5A2DC00 | overloaded x5
        public void get_LastTag(){} // RVA: 0x10E5CF0
        public void get_DiscardUnknownFields(){} // RVA: 0x3BCCE0
        public void set_DiscardUnknownFields(){} // RVA: 0x3BCCF0
        public void get_ExtensionRegistry(){} // RVA: 0x31C010
        public void set_ExtensionRegistry(){} // RVA: 0x463060
        public void ReadTag(){} // RVA: 0x5A2DD20
        public void ReadDouble(){} // RVA: 0x5A2DD30
        public void ReadFloat(){} // RVA: 0x5A2DD40
        public void ReadUInt64(){} // RVA: 0x5A2DD50
        public void ReadInt64(){} // RVA: 0x5A2DD50
        public void ReadInt32(){} // RVA: 0x5A2DD60
        public void ReadFixed64(){} // RVA: 0x5A2DD70
        public void ReadFixed32(){} // RVA: 0x5A2DD80
        public void ReadBool(){} // RVA: 0x5A2DD90
        public void ReadString(){} // RVA: 0x5A2DDB0
        public void ReadMessage(){} // RVA: 0x5A2DDF0
        public void ReadBytes(){} // RVA: 0x5A2DE50
        public void ReadUInt32(){} // RVA: 0x5A2DD60
        public void ReadEnum(){} // RVA: 0x5A2DD60
        public void ReadLength(){} // RVA: 0x5A2DD60
        public void CopyStateTo(){} // RVA: 0x5A2DE60
        public void LoadStateFrom(){} // RVA: 0x5A2DF20
    }

    public class ParserInternalState
    {
        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0x3A5500
        public void get_DiscardUnknownFields(){} // RVA: 0x1120170
        public void set_DiscardUnknownFields(){} // RVA: 0x5A2DFE0
        public void get_ExtensionRegistry(){} // RVA: 0x4C7C50
        public void set_ExtensionRegistry(){} // RVA: 0x4C34F0
    }

    public class ParsingPrimitives
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x5A2DFF0
        public void ParseTag(){} // RVA: 0x5A2E000
        public void MaybeConsumeTag(){} // RVA: 0x5A2E120
        public void PeekTag(){} // RVA: 0x5A2E180
        public void ParseRawVarint64(){} // RVA: 0x5A2E1C0
        public void ParseRawVarint64SlowPath(){} // RVA: 0x5A2E340
        public void ParseRawVarint32(){} // RVA: 0x5A2E420
        public void ParseRawVarint32SlowPath(){} // RVA: 0x5A2E5F0
        public void ParseRawLittleEndian32(){} // RVA: 0x5A2E790
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x5A2E870
        public void ParseRawLittleEndian64(){} // RVA: 0x5A2E9C0
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x5A2EAA0
        public void ParseDouble(){} // RVA: 0x5A2ED40
        public void ParseFloat(){} // RVA: 0x5A2EE00
        public void ParseFloatSlow(){} // RVA: 0x5A2EEC0
        public void ReadRawBytes(){} // RVA: 0x5A2EFC0
        public void ReadRawBytesSlow(){} // RVA: 0x5A2F1B0
        public void SkipRawBytes(){} // RVA: 0x5A2F830
        public void ReadString(){} // RVA: 0x5A2F940
        public void ReadBytes(){} // RVA: 0x5A2F980
        public void ReadRawString(){} // RVA: 0x5A2FA00
        public void ReadStringSlow(){} // RVA: 0x5A2FB90
        public void ValidateCurrentLimit(){} // RVA: 0x5A30090
        public void ReadRawByte(){} // RVA: 0x5A30100
        public void IsDataAvailable(){} // RVA: 0x5A30170
        public void IsDataAvailableInSource(){} // RVA: 0x5A30190
        public void ReadRawBytesIntoSpan(){} // RVA: 0x5A30250
    }

    public class ParsingPrimitivesMessages
    {
        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x5A30460
        public void SkipGroup(){} // RVA: 0x5A30620
        public void ReadMessage(){} // RVA: 0x5A307D0
        public void ReadMapEntry(){} // RVA: 0x283FA0
        public void ReadGroup(){} // RVA: 0x5A30930
        public void ReadRawMessage(){} // RVA: 0x5A30A40
        public void CheckReadEndOfStreamTag(){} // RVA: 0x5A30BE0
        public void CheckLastTagWas(){} // RVA: 0x5A30C20
        public void .cctor(){} // RVA: 0x5A30C60
    }

    public class ProtoPreconditions
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x283FA0
        public void CheckNotNullUnconstrained(){} // RVA: 0x283FA0
    }

    public class RepeatedExtensionValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void CalculateSize(){} // RVA: 0xD840
        public void Clone(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void MergeFrom(){} // RVA: 0x24B10 | overloaded x2
        public void WriteTo(){} // RVA: 0x24B10
        public void GetValue(){} // RVA: 0xCD60
    }

    public class RepeatedExtension`2
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0xCD60
        public void get_IsRepeated(){} // RVA: 0xDBE0
        public void CreateValue(){} // RVA: 0xCD60
    }

    public class SegmentedBufferHelper
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x5A30E10 | overloaded x2
        public void RefillBuffer(){} // RVA: 0x5A31160
        public void get_TotalLength(){} // RVA: 0x1AD4690
        public void get_CodedInputStream(){} // RVA: 0x35A740
        public void PushLimit(){} // RVA: 0x5A31190
        public void PopLimit(){} // RVA: 0x5A31230
        public void IsReachedLimit(){} // RVA: 0x5A31260
        public void IsAtEnd(){} // RVA: 0x5A31280
        public void RefillFromReadOnlySequence(){} // RVA: 0x5A312D0
        public void RefillFromCodedInputStream(){} // RVA: 0x5A314F0
        public void RecomputeBufferSizeAfterLimit(){} // RVA: 0x5A31710
        public void CheckCurrentBufferIsEmpty(){} // RVA: 0x5A31740
    }

    public class UnknownField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Equals(){} // RVA: 0x5A317B0
        public void GetHashCode(){} // RVA: 0x5A31A10
        public void WriteTo(){} // RVA: 0x5A31B10
        public void GetSerializedSize(){} // RVA: 0x5A32410
        public void MergeFrom(){} // RVA: 0x5A32BC0
        public void AddAll(){} // RVA: 0xCEC0
        public void AddVarint(){} // RVA: 0x5A33170
        public void AddFixed32(){} // RVA: 0x5A33210
        public void AddFixed64(){} // RVA: 0x5A33370
        public void AddLengthDelimited(){} // RVA: 0x5A33410
        public void AddGroup(){} // RVA: 0x5A334B0
        public void Add(){} // RVA: 0x283FA0
    }

    public class UnknownFieldSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A33550
        public void HasField(){} // RVA: 0x5A33610
        public void WriteTo(){} // RVA: 0x5A33670
        public void CalculateSize(){} // RVA: 0x5A33890
        public void Equals(){} // RVA: 0x5A33AB0
        public void GetHashCode(){} // RVA: 0x5A33E90
        public void GetOrAddField(){} // RVA: 0x5A340D0
        public void AddOrReplaceField(){} // RVA: 0x5A34200
        public void MergeFieldFrom(){} // RVA: 0x5A34990 | overloaded x2
        public void MergeGroupFrom(){} // RVA: 0x5A34930
        public void MergeFrom(){} // RVA: 0x5A34DC0 | overloaded x2
        public void MergeField(){} // RVA: 0x5A34E40
        public void Clone(){} // RVA: 0x5A34F60
    }

    public class ValueReader`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

    public class ValueWriter`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

    public class WireFormat
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x5A34FE0
        public void GetTagFieldNumber(){} // RVA: 0x5A34FF0
        public void MakeTag(){} // RVA: 0x5A35000
    }

    public class WriteBufferHelper
    {
        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x19689C0
        public void Initialize(){} // RVA: 0x5A35010
        public void InitializeNonRefreshable(){} // RVA: 0x5A350C0
        public void CheckNoSpaceLeft(){} // RVA: 0x5A35170
        public void GetSpaceLeft(){} // RVA: 0x5A351E0
        public void RefreshBuffer(){} // RVA: 0x5A35260
        public void Flush(){} // RVA: 0x5A353A0
    }

    public class WriteContext
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x5A354D0 | overloaded x2
        public void WriteDouble(){} // RVA: 0x5A35530
        public void WriteFloat(){} // RVA: 0x5A355E0
        public void WriteUInt64(){} // RVA: 0x5A35730
        public void WriteInt64(){} // RVA: 0x5A357E0
        public void WriteInt32(){} // RVA: 0x5A35890
        public void WriteFixed64(){} // RVA: 0x5A35900
        public void WriteFixed32(){} // RVA: 0x5A359B0
        public void WriteBool(){} // RVA: 0x5A35B50
        public void WriteString(){} // RVA: 0x5A35C00
        public void WriteMessage(){} // RVA: 0x5A35C70
        public void WriteBytes(){} // RVA: 0x5A35D30
        public void WriteUInt32(){} // RVA: 0x5A35E70
        public void WriteEnum(){} // RVA: 0x5A35F20
        public void WriteLength(){} // RVA: 0x5A35FD0
        public void WriteTag(){} // RVA: 0x5A36100 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x5A36260 | overloaded x2
        public void CheckNoSpaceLeft(){} // RVA: 0x5A36370
        public void CopyStateTo(){} // RVA: 0x5A36380
        public void LoadStateFrom(){} // RVA: 0x5A363F0
    }

    public class WriterInternalState
    {
        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x2F8380
    }

    public class WritingPrimitives
    {
        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x5A36460
        public void WriteFloat(){} // RVA: 0x5A364D0
        public void WriteFloatSlowPath(){} // RVA: 0x5A365F0
        public void WriteUInt64(){} // RVA: 0x5A36710
        public void WriteInt64(){} // RVA: 0x5A36780
        public void WriteInt32(){} // RVA: 0x5A367F0
        public void WriteFixed64(){} // RVA: 0x5A36890
        public void WriteFixed32(){} // RVA: 0x5A36900
        public void WriteBool(){} // RVA: 0x5A36A70
        public void WriteString(){} // RVA: 0x5A36AE0
        public void WriteAsciiStringToBuffer(){} // RVA: 0x5A36D90
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x5A36F20
        public void WriteStringToBuffer(){} // RVA: 0x5A36F40
        public void WriteBytes(){} // RVA: 0x5A370A0
        public void WriteUInt32(){} // RVA: 0x5A371B0
        public void WriteEnum(){} // RVA: 0x5A37220
        public void WriteLength(){} // RVA: 0x5A37290
        public void WriteRawVarint32(){} // RVA: 0x5A37300
        public void WriteRawVarint64(){} // RVA: 0x5A374B0
        public void WriteRawLittleEndian32(){} // RVA: 0x5A37660
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x5A37790
        public void WriteRawLittleEndian64(){} // RVA: 0x5A37840
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x5A37970
        public void WriteRawByte(){} // RVA: 0x5A37A80
        public void WriteRawBytes(){} // RVA: 0x5A37BC0 | overloaded x2
        public void WriteTag(){} // RVA: 0x5A37F80 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x5A38060 | overloaded x2
        public void WriteRawTagSlowPath(){} // RVA: 0x5A38140
        public void .cctor(){} // RVA: 0x5A381D0
    }

    public class WritingPrimitivesMessages
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x5A38270
        public void WriteRawMessage(){} // RVA: 0x5A38330
    }

}