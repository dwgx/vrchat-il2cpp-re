// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 44
// Methods: 418

namespace ThirdParty.Google.Google.Protobuf
{
    public class ByteString : Object
    {
        public Google.Protobuf.ByteString Empty;
        public System.ReadOnlyMemory`1<byte> Length; // 0x10

        // ── Methods ──
        public void AttachBytes(){} // RVA: 0x7FFAC81B5F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC4A9B120
        public void get_Empty(){} // RVA: 0x7FFAC81B6130
        public void get_Length(){} // RVA: 0x7FFAC81B6190
        public void get_Span(){} // RVA: 0x7FFAC81B61D0
        public void ToBase64(){} // RVA: 0x7FFAC81B6230
        public void CopyFrom(){} // RVA: 0x7FFAC81B6450
        public void GetEnumerator(){} // RVA: 0x7FFAC81B6620
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC81B6620
        public void CreateCodedInput(){} // RVA: 0x7FFAC81B6720
        public void op_Equality(){} // RVA: 0x7FFAC81B6AE0
        public void op_Inequality(){} // RVA: 0x7FFAC81B6BB0
        public void Equals(){} // RVA: 0x7FFAC81B6E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81B6DF0
        public void .cctor(){} // RVA: 0x7FFAC81B6F80
    }

    public class CodedInputStream : Object
    {
        public bool DiscardUnknownFields; // 0x10
        public byte[] ExtensionRegistry; // 0x18
        public System.IO.Stream InternalBuffer; // 0x20
        public Google.Protobuf.ParserInternalState InternalInputStream; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC81B73D0 | overloaded x3
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFAC81B7590
        public void set_ExtensionRegistry(){} // RVA: 0x7FFAC354E420
        public void get_InternalBuffer(){} // RVA: 0x7FFAC2F247C0
        public void get_InternalInputStream(){} // RVA: 0x7FFAC2F4F0C0
        public void get_InternalState(){} // RVA: 0x7FFAC81B75A0
        public void Dispose(){} // RVA: 0x7FFAC81B75B0
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFAC81B75F0
        public void ReadRawMessage(){} // RVA: 0x7FFAC81B7660
    }

    public class CodedOutputStream : Object
    {
        public int InternalBuffer;
        public bool InternalOutputStream; // 0x10
        public byte[] InternalState; // 0x18
        public Google.Protobuf.WriterInternalState state; // 0x20
        public System.IO.Stream output; // 0x38

        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x7FFAC81B7770
        public void ComputeInt64Size(){} // RVA: 0x7FFAC81B77C0
        public void ComputeInt32Size(){} // RVA: 0x7FFAC81B7810
        public void ComputeFixed64Size(){} // RVA: 0x7FFAC3ED8E80
        public void ComputeFixed32Size(){} // RVA: 0x7FFAC36C3910
        public void ComputeStringSize(){} // RVA: 0x7FFAC81B78B0
        public void ComputeMessageSize(){} // RVA: 0x7FFAC81B7960
        public void ComputeBytesSize(){} // RVA: 0x7FFAC81B79F0
        public void ComputeUInt32Size(){} // RVA: 0x7FFAC81B7AB0
        public void ComputeEnumSize(){} // RVA: 0x7FFAC81B7B40
        public void ComputeLengthSize(){} // RVA: 0x7FFAC81B7B90
        public void ComputeRawVarint32Size(){} // RVA: 0x7FFAC81B7C20
        public void ComputeRawVarint64Size(){} // RVA: 0x7FFAC81B7C60
        public void ComputeTagSize(){} // RVA: 0x7FFAC81B7D00
        public void .ctor(){} // RVA: 0x7FFAC81B7DD0 | overloaded x2
        public void WriteRawMessage(){} // RVA: 0x7FFAC81B8000
        public void Dispose(){} // RVA: 0x7FFAC81B81C0
        public void Flush(){} // RVA: 0x7FFAC81B82C0
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFAC81B8390
        public void get_InternalBuffer(){} // RVA: 0x7FFAC2F247C0
        public void get_InternalOutputStream(){} // RVA: 0x7FFAC31D0140
        public void get_InternalState(){} // RVA: 0x7FFAC81B83A0
        public void .cctor(){} // RVA: 0x7FFAC81B83B0
    }

    public class Extension : Object
    {
        public int TargetType; // 0x10

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void CreateValue(){} // RVA: 0x7FFAC2C58E90
        public void get_FieldNumber(){} // RVA: 0x7FFAC2F6E5C0
        public void get_IsRepeated(){} // RVA: 0x7FFAC2C59D00
    }

    public class ExtensionRegistry : Object
    {
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.ObjectIntPair`1<System.Type>,Google.Protobuf.Extension> Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC81B8500 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC81B8970
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void ContainsInputField(){} // RVA: 0x7FFAC81B89C0
        public void Add(){} // RVA: 0x7FFAC81B8B30
        public void AddRange(){} // RVA: 0x7FFAC81B8CA0
        public void Clear(){} // RVA: 0x7FFAC81B8EC0
        public void Contains(){} // RVA: 0x7FFAC81B8F10
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(){} // RVA: 0x7FFAC81B90F0
        public void GetEnumerator(){} // RVA: 0x7FFAC81B9410
        public void Remove(){} // RVA: 0x7FFAC81B9490
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC81B9410
        public void Clone(){} // RVA: 0x7FFAC81B9670
    }

    public class ExtensionSet : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFAC2C5D5A0
        public void Get(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
        public void GetOrInitialize(){} // RVA: 0x7FFAC2C58FF0
        public void Set(){} // RVA: 0x7FFAC2E8DC40
        public void Has(){} // RVA: 0x7FFAC2C5A350
        public void Clear(){} // RVA: 0x7FFAC2C70C80 | overloaded x2
        public void TryMergeFieldFrom(){} // RVA: 0x7FFAC2C5A350
        public void MergeFrom(){} // RVA: 0x7FFAC2C70C80
        public void Clone(){} // RVA: 0x7FFAC2C58F80
    }

    public class ExtensionSet`1 : Object
    {
        public System.Collections.Generic.Dictionary`2<int,Google.Protobuf.IExtensionValue> ValuesByNumber;

        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0x7FFAC2C58E90
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void CalculateSize(){} // RVA: 0x7FFAC2C59960
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ExtensionValue`1 : Object
    {
        public T field;
        public Google.Protobuf.FieldCodec`1<T> codec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void CalculateSize(){} // RVA: 0x7FFAC2C59960
        public void Clone(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void MergeFrom(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void GetValue(){} // RVA: 0x7FFAC2E8DC40
        public void SetValue(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Extension`2 : Extension
    {
        public Google.Protobuf.FieldCodec`1<T> DefaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0
        public void get_DefaultValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_TargetType(){} // RVA: 0x7FFAC2C58E90
        public void get_IsRepeated(){} // RVA: 0x7FFAC2C59D00
        public void CreateValue(){} // RVA: 0x7FFAC2C58E90
    }

    public class FieldCodec : Object
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x7FFAC81B9BC0 | overloaded x2
        public void ForInt32(){} // RVA: 0x7FFAC81B9EC0 | overloaded x2
        public void ForUInt32(){} // RVA: 0x7FFAC81BA340 | overloaded x2
        public void ForFloat(){} // RVA: 0x7FFAC81BA7C0 | overloaded x2
        public void ForMessage(){} // RVA: 0x7FFAC2E8DC40
    }

    public class FieldCodec`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<T> PackedRepeatedField;
        public T ValueWriter;
        public bool ValueSizeCalculator;
        public bool ValueReader;
        public Google.Protobuf.ValueWriter`1<T> ValueMerger;
        public System.Func`2<T,int> FieldMerger;
        public Google.Protobuf.ValueReader`1<T> FixedSize;
        public InputMerger<T> Tag;
        public ValuesMerger<T> EndTag;
        public int DefaultValue;
        public uint <Tag>k__BackingField;
        public uint <EndTag>k__BackingField;
        public T <DefaultValue>k__BackingField;
        public int tagSize;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void IsPackedRepeatedField(){} // RVA: 0x7FFAC2C5A7A0
        public void get_PackedRepeatedField(){} // RVA: 0x7FFAC2C59D00
        public void get_ValueWriter(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueSizeCalculator(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueReader(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueMerger(){} // RVA: 0x7FFAC2C58E90
        public void get_FieldMerger(){} // RVA: 0x7FFAC2C58E90
        public void get_FixedSize(){} // RVA: 0x7FFAC2C59960
        public void get_Tag(){} // RVA: 0x7FFAC2C59960
        public void get_EndTag(){} // RVA: 0x7FFAC2C59960
        public void get_DefaultValue(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void WriteTagAndValue(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CalculateSizeWithTag(){} // RVA: 0x7FFAC2E8DC40
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x7FFAC2E8DC40
        public void IsDefault(){} // RVA: 0x7FFAC2E8DC40
    }

    public class FieldMaskTree : Object
    {
        public Node root; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC81BAEB0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC81BAF70
        public void AddFieldPath(){} // RVA: 0x7FFAC81BAFB0
        public void MergeFromFieldMask(){} // RVA: 0x7FFAC81BB240
        public void ToFieldMask(){} // RVA: 0x7FFAC81BB420
        public void GetFieldPaths(){} // RVA: 0x7FFAC81BB550
        public void IntersectFieldPath(){} // RVA: 0x7FFAC81BB800
        public void Merge(){} // RVA: 0x7FFAC81BBD20 | overloaded x2
    }

    public class FrameworkPortability : Object
    {
        public 0x6B130410 CompiledRegexWhereAvailable;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC81BC880
    }

    public class IBufferMessage
    {
        // ── Methods ──
        public void InternalMergeFrom(){} // RVA: 0x7FFAC2C70A40
        public void InternalWriteTo(){} // RVA: 0x7FFAC2C70A40
    }

    public class ICustomDiagnosticMessage
    {
        // ── Methods ──
        public void ToDiagnosticString(){} // RVA: 0x7FFAC2C58E90
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IExtendableMessage`1
    {
        // ── Methods ──
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40
    }

    public class IExtensionValue
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void CalculateSize(){} // RVA: 0x7FFAC2C59960
    }

    public class IMessage
    {
        public object Descriptor;

        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFAC2C70A40
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void CalculateSize(){} // RVA: 0x7FFAC2C59960
        public void get_Descriptor(){} // RVA: 0x7FFAC2C58E90
    }

    public class IMessage`1
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InvalidProtocolBufferException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC81BCA50
        public void MoreDataAvailable(){} // RVA: 0x7FFAC81BCA70
        public void TruncatedMessage(){} // RVA: 0x7FFAC81BCAE0
        public void NegativeSize(){} // RVA: 0x7FFAC81BCB50
        public void MalformedVarint(){} // RVA: 0x7FFAC81BCBC0
        public void InvalidTag(){} // RVA: 0x7FFAC81BCC30
        public void InvalidWireType(){} // RVA: 0x7FFAC81BCCA0
        public void InvalidEndTag(){} // RVA: 0x7FFAC81BCD10
        public void RecursionLimitExceeded(){} // RVA: 0x7FFAC81BCD80
        public void SizeLimitExceeded(){} // RVA: 0x7FFAC81BCDF0
    }

    public class JsonFormatter : Object
    {
        public Google.Protobuf.JsonFormatter Default;
        public Google.Protobuf.JsonFormatter DiagnosticOnly; // 0x8
        public string[] CommonRepresentations; // 0x10
        public Settings settings; // 0x10

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFAC81BCE60
        public void .cctor(){} // RVA: 0x7FFAC81BCEC0
        public void get_DiagnosticOnly(){} // RVA: 0x7FFAC81BE3E0
        public void .ctor(){} // RVA: 0x7FFAC81BE440
        public void Format(){} // RVA: 0x7FFAC81BE5E0 | overloaded x2
        public void ToDiagnosticString(){} // RVA: 0x7FFAC81BE790
        public void WriteMessage(){} // RVA: 0x7FFAC81BE8F0
        public void WriteMessageFields(){} // RVA: 0x7FFAC81BEAF0
        public void ShouldFormatFieldValue(){} // RVA: 0x7FFAC81BF0D0
        public void ToJsonName(){} // RVA: 0x7FFAC81BF240
        public void WriteNull(){} // RVA: 0x7FFAC81BF3B0
        public void IsDefaultValue(){} // RVA: 0x7FFAC81BF410
        public void WriteValue(){} // RVA: 0x7FFAC81BF970
        public void WriteWellKnownTypeValue(){} // RVA: 0x7FFAC81C0350
        public void WriteTimestamp(){} // RVA: 0x7FFAC81C0B90
        public void WriteDuration(){} // RVA: 0x7FFAC81C0E00
        public void WriteFieldMask(){} // RVA: 0x7FFAC81C1070
        public void WriteAny(){} // RVA: 0x7FFAC81C1240
        public void WriteDiagnosticOnlyAny(){} // RVA: 0x7FFAC81C1740
        public void WriteStruct(){} // RVA: 0x7FFAC81C1AA0
        public void WriteStructFieldValue(){} // RVA: 0x7FFAC81C1F80
        public void WriteList(){} // RVA: 0x7FFAC81C22E0
        public void WriteDictionary(){} // RVA: 0x7FFAC81C25C0
        public void WriteString(){} // RVA: 0x7FFAC81C2C60
        public void HexEncodeUtf16CodeUnit(){} // RVA: 0x7FFAC81C3070
    }

    public class MessageExtensions : Object
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFAC81C49C0 | overloaded x5
        public void ToByteArray(){} // RVA: 0x7FFAC81C4270
        public void ToByteString(){} // RVA: 0x7FFAC81C43C0
        public void WriteTo(){} // RVA: 0x7FFAC81C44A0
    }

    public class MessageParser : Object
    {
        public System.Func`1<Google.Protobuf.IMessage> DiscardUnknownFields; // 0x10
        public bool Extensions; // 0x18
        public Google.Protobuf.ExtensionRegistry <Extensions>k__BackingField; // 0x20

        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Extensions(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC81C4BD0
        public void CreateTemplate(){} // RVA: 0x7FFAC3D3B830
        public void ParseFrom(){} // RVA: 0x7FFAC81C4C90
    }

    public class MessageParser`1 : MessageParser
    {
        public System.Func`1<T> factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C76BD0 | overloaded x2
        public void CreateTemplate(){} // RVA: 0x7FFAC2E8DC40
        public void ParseFrom(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void WithExtensionRegistry(){} // RVA: 0x7FFAC2C58F40
    }

    public class ObjectIntPair`1 : ValueType
    {
        public int number;
        public T obj;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    }

    public class ParseContext : ValueType
    {
        public System.ReadOnlySpan`1<byte> LastTag; // 0x10
        public Google.Protobuf.ParserInternalState DiscardUnknownFields; // 0x20

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC81C5020 | overloaded x5
        public void get_LastTag(){} // RVA: 0x7FFAC3B99E80
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFAC3000CE0
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFAC3000CF0
        public void get_ExtensionRegistry(){} // RVA: 0x7FFAC2F60010
        public void set_ExtensionRegistry(){} // RVA: 0x7FFAC354E300
        public void ReadTag(){} // RVA: 0x7FFAC81C5140
        public void ReadDouble(){} // RVA: 0x7FFAC81C5150
        public void ReadFloat(){} // RVA: 0x7FFAC81C5160
        public void ReadUInt64(){} // RVA: 0x7FFAC81C5170
        public void ReadInt64(){} // RVA: 0x7FFAC81C5170
        public void ReadInt32(){} // RVA: 0x7FFAC81C5180
        public void ReadFixed64(){} // RVA: 0x7FFAC81C5190
        public void ReadFixed32(){} // RVA: 0x7FFAC81C51A0
        public void ReadBool(){} // RVA: 0x7FFAC81C51B0
        public void ReadString(){} // RVA: 0x7FFAC81C51D0
        public void ReadMessage(){} // RVA: 0x7FFAC81C5210
        public void ReadBytes(){} // RVA: 0x7FFAC81C5270
        public void ReadUInt32(){} // RVA: 0x7FFAC81C5180
        public void ReadEnum(){} // RVA: 0x7FFAC81C5180
        public void ReadLength(){} // RVA: 0x7FFAC81C5180
        public void CopyStateTo(){} // RVA: 0x7FFAC81C5280
        public void LoadStateFrom(){} // RVA: 0x7FFAC81C5340
    }

    public class ParserInternalState : ValueType
    {
        public int CodedInputStream; // 0x10
        public int DiscardUnknownFields; // 0x14
        public int ExtensionRegistry; // 0x18
        public int currentLimit; // 0x1C
        public int totalBytesRetired; // 0x20
        public int recursionDepth; // 0x24
        public Google.Protobuf.SegmentedBufferHelper segmentedBufferHelper; // 0x28
        public uint lastTag; // 0x70
        public uint nextTag; // 0x74
        public bool hasNextTag; // 0x78
        public int sizeLimit; // 0x7C
        public int recursionLimit; // 0x80
        public bool <DiscardUnknownFields>k__BackingField; // 0x84
        public Google.Protobuf.ExtensionRegistry <ExtensionRegistry>k__BackingField; // 0x88

        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0x7FFAC2FE9500
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFAC3BCD8B0
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFAC81C5400
        public void get_ExtensionRegistry(){} // RVA: 0x7FFAC30E5600
        public void set_ExtensionRegistry(){} // RVA: 0x7FFAC30E06F0
    }

    public class ParsingPrimitives : Object
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x7FFAC81C5410
        public void ParseTag(){} // RVA: 0x7FFAC81C5420
        public void MaybeConsumeTag(){} // RVA: 0x7FFAC81C5540
        public void PeekTag(){} // RVA: 0x7FFAC81C55A0
        public void ParseRawVarint64(){} // RVA: 0x7FFAC81C55E0
        public void ParseRawVarint64SlowPath(){} // RVA: 0x7FFAC81C5760
        public void ParseRawVarint32(){} // RVA: 0x7FFAC81C5840
        public void ParseRawVarint32SlowPath(){} // RVA: 0x7FFAC81C5A10
        public void ParseRawLittleEndian32(){} // RVA: 0x7FFAC81C5BB0
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x7FFAC81C5C90
        public void ParseRawLittleEndian64(){} // RVA: 0x7FFAC81C5DE0
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x7FFAC81C5EC0
        public void ParseDouble(){} // RVA: 0x7FFAC81C6160
        public void ParseFloat(){} // RVA: 0x7FFAC81C6220
        public void ParseFloatSlow(){} // RVA: 0x7FFAC81C62E0
        public void ReadRawBytes(){} // RVA: 0x7FFAC81C63E0
        public void ReadRawBytesSlow(){} // RVA: 0x7FFAC81C65D0
        public void SkipRawBytes(){} // RVA: 0x7FFAC81C6C50
        public void ReadString(){} // RVA: 0x7FFAC81C6D60
        public void ReadBytes(){} // RVA: 0x7FFAC81C6DA0
        public void ReadRawString(){} // RVA: 0x7FFAC81C6E20
        public void ReadStringSlow(){} // RVA: 0x7FFAC81C6FB0
        public void ValidateCurrentLimit(){} // RVA: 0x7FFAC81C74B0
        public void ReadRawByte(){} // RVA: 0x7FFAC81C7520
        public void IsDataAvailable(){} // RVA: 0x7FFAC81C7590
        public void IsDataAvailableInSource(){} // RVA: 0x7FFAC81C75B0
        public void ReadRawBytesIntoSpan(){} // RVA: 0x7FFAC81C7670
    }

    public class ParsingPrimitivesMessages : Object
    {
        public byte[] ZeroLengthMessageStreamData;

        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x7FFAC81C7880
        public void SkipGroup(){} // RVA: 0x7FFAC81C7A40
        public void ReadMessage(){} // RVA: 0x7FFAC81C7BF0
        public void ReadMapEntry(){} // RVA: 0x7FFAC2E8DC40
        public void ReadGroup(){} // RVA: 0x7FFAC81C7D50
        public void ReadRawMessage(){} // RVA: 0x7FFAC81C7E60
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFAC81C8000
        public void CheckLastTagWas(){} // RVA: 0x7FFAC81C8040
        public void .cctor(){} // RVA: 0x7FFAC81C8080
    }

    public class ProtoPreconditions : Object
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x7FFAC2E8DC40
        public void CheckNotNullUnconstrained(){} // RVA: 0x7FFAC2E8DC40
    }

    public class RepeatedExtensionValue`1 : Object
    {
        public Google.Protobuf.Collections.RepeatedField`1<T> field;
        public Google.Protobuf.FieldCodec`1<T> codec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void CalculateSize(){} // RVA: 0x7FFAC2C59960
        public void Clone(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void MergeFrom(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void GetValue(){} // RVA: 0x7FFAC2C58E90
    }

    public class RepeatedExtension`2 : Extension
    {
        public Google.Protobuf.FieldCodec`1<T> TargetType;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC2C58E90
        public void get_IsRepeated(){} // RVA: 0x7FFAC2C59D00
        public void CreateValue(){} // RVA: 0x7FFAC2C58E90
    }

    public class SegmentedBufferHelper : ValueType
    {
        public System.Nullable`1<int> TotalLength; // 0x10
        public Enumerator<byte> CodedInputStream; // 0x18
        public Google.Protobuf.CodedInputStream codedInputStream; // 0x50

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC81C8230 | overloaded x2
        public void RefillBuffer(){} // RVA: 0x7FFAC81C8580
        public void get_TotalLength(){} // RVA: 0x7FFAC3AD9F60
        public void get_CodedInputStream(){} // RVA: 0x7FFAC2F9E740
        public void PushLimit(){} // RVA: 0x7FFAC81C85B0
        public void PopLimit(){} // RVA: 0x7FFAC81C8650
        public void IsReachedLimit(){} // RVA: 0x7FFAC81C8680
        public void IsAtEnd(){} // RVA: 0x7FFAC81C86A0
        public void RefillFromReadOnlySequence(){} // RVA: 0x7FFAC81C86F0
        public void RefillFromCodedInputStream(){} // RVA: 0x7FFAC81C8910
        public void RecomputeBufferSizeAfterLimit(){} // RVA: 0x7FFAC81C8B30
        public void CheckCurrentBufferIsEmpty(){} // RVA: 0x7FFAC81C8B60
    }

    public class UnknownField : Object
    {
        public System.Collections.Generic.List`1<ulong> varintList; // 0x10
        public System.Collections.Generic.List`1<uint> fixed32List; // 0x18
        public System.Collections.Generic.List`1<ulong> fixed64List; // 0x20
        public System.Collections.Generic.List`1<Google.Protobuf.ByteString> lengthDelimitedList; // 0x28
        public System.Collections.Generic.List`1<Google.Protobuf.UnknownFieldSet> groupList; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC81C8BD0
        public void GetHashCode(){} // RVA: 0x7FFAC81C8E30
        public void WriteTo(){} // RVA: 0x7FFAC81C8F30
        public void GetSerializedSize(){} // RVA: 0x7FFAC81C9830
        public void MergeFrom(){} // RVA: 0x7FFAC81C9FE0
        public void AddAll(){} // RVA: 0x7FFAC2C58FF0
        public void AddVarint(){} // RVA: 0x7FFAC81CA590
        public void AddFixed32(){} // RVA: 0x7FFAC81CA630
        public void AddFixed64(){} // RVA: 0x7FFAC81CA790
        public void AddLengthDelimited(){} // RVA: 0x7FFAC81CA830
        public void AddGroup(){} // RVA: 0x7FFAC81CA8D0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnknownFieldSet : Object
    {
        public System.Collections.Generic.IDictionary`2<int,Google.Protobuf.UnknownField> fields; // 0x10
        public int lastFieldNumber; // 0x18
        public Google.Protobuf.UnknownField lastField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC81CA970
        public void HasField(){} // RVA: 0x7FFAC81CAA30
        public void WriteTo(){} // RVA: 0x7FFAC81CAA90
        public void CalculateSize(){} // RVA: 0x7FFAC81CACB0
        public void Equals(){} // RVA: 0x7FFAC81CAED0
        public void GetHashCode(){} // RVA: 0x7FFAC81CB2B0
        public void GetOrAddField(){} // RVA: 0x7FFAC81CB4F0
        public void AddOrReplaceField(){} // RVA: 0x7FFAC81CB620
        public void MergeFieldFrom(){} // RVA: 0x7FFAC81CBDB0 | overloaded x2
        public void MergeGroupFrom(){} // RVA: 0x7FFAC81CBD50
        public void MergeFrom(){} // RVA: 0x7FFAC81CC1E0 | overloaded x2
        public void MergeField(){} // RVA: 0x7FFAC81CC260
        public void Clone(){} // RVA: 0x7FFAC81CC380
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class WireFormat : Object
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x7FFAC81CC400
        public void GetTagFieldNumber(){} // RVA: 0x7FFAC81CC410
        public void MakeTag(){} // RVA: 0x7FFAC81CC420
    }

    public class WriteBufferHelper : ValueType
    {
        public System.Buffers.IBufferWriter`1<byte> CodedOutputStream; // 0x10
        public Google.Protobuf.CodedOutputStream codedOutputStream; // 0x18

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7FFAC4420220
        public void Initialize(){} // RVA: 0x7FFAC81CC430
        public void InitializeNonRefreshable(){} // RVA: 0x7FFAC81CC4E0
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFAC81CC590
        public void GetSpaceLeft(){} // RVA: 0x7FFAC81CC600
        public void RefreshBuffer(){} // RVA: 0x7FFAC81CC680
        public void Flush(){} // RVA: 0x7FFAC81CC7C0
    }

    public class WriteContext : ValueType
    {
        public System.Span`1<byte> buffer; // 0x10
        public Google.Protobuf.WriterInternalState state; // 0x20

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC81CC8F0 | overloaded x2
        public void WriteDouble(){} // RVA: 0x7FFAC81CC950
        public void WriteFloat(){} // RVA: 0x7FFAC81CCA00
        public void WriteUInt64(){} // RVA: 0x7FFAC81CCB50
        public void WriteInt64(){} // RVA: 0x7FFAC81CCC00
        public void WriteInt32(){} // RVA: 0x7FFAC81CCCB0
        public void WriteFixed64(){} // RVA: 0x7FFAC81CCD20
        public void WriteFixed32(){} // RVA: 0x7FFAC81CCDD0
        public void WriteBool(){} // RVA: 0x7FFAC81CCF70
        public void WriteString(){} // RVA: 0x7FFAC81CD020
        public void WriteMessage(){} // RVA: 0x7FFAC81CD090
        public void WriteBytes(){} // RVA: 0x7FFAC81CD150
        public void WriteUInt32(){} // RVA: 0x7FFAC81CD290
        public void WriteEnum(){} // RVA: 0x7FFAC81CD340
        public void WriteLength(){} // RVA: 0x7FFAC81CD3F0
        public void WriteTag(){} // RVA: 0x7FFAC81CD520 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x7FFAC81CD680 | overloaded x2
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFAC81CD790
        public void CopyStateTo(){} // RVA: 0x7FFAC81CD7A0
        public void LoadStateFrom(){} // RVA: 0x7FFAC81CD810
    }

    public class WriterInternalState : ValueType
    {
        public int CodedOutputStream; // 0x10
        public int position; // 0x14
        public Google.Protobuf.WriteBufferHelper writeBufferHelper; // 0x18

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7FFAC2F3C380
    }

    public class WritingPrimitives : Object
    {
        public System.Text.Encoding Utf8Encoding;

        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x7FFAC81CD880
        public void WriteFloat(){} // RVA: 0x7FFAC81CD8F0
        public void WriteFloatSlowPath(){} // RVA: 0x7FFAC81CDA10
        public void WriteUInt64(){} // RVA: 0x7FFAC81CDB30
        public void WriteInt64(){} // RVA: 0x7FFAC81CDBA0
        public void WriteInt32(){} // RVA: 0x7FFAC81CDC10
        public void WriteFixed64(){} // RVA: 0x7FFAC81CDCB0
        public void WriteFixed32(){} // RVA: 0x7FFAC81CDD20
        public void WriteBool(){} // RVA: 0x7FFAC81CDE90
        public void WriteString(){} // RVA: 0x7FFAC81CDF00
        public void WriteAsciiStringToBuffer(){} // RVA: 0x7FFAC81CE1B0
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x7FFAC81CE340
        public void WriteStringToBuffer(){} // RVA: 0x7FFAC81CE360
        public void WriteBytes(){} // RVA: 0x7FFAC81CE4C0
        public void WriteUInt32(){} // RVA: 0x7FFAC81CE5D0
        public void WriteEnum(){} // RVA: 0x7FFAC81CE640
        public void WriteLength(){} // RVA: 0x7FFAC81CE6B0
        public void WriteRawVarint32(){} // RVA: 0x7FFAC81CE720
        public void WriteRawVarint64(){} // RVA: 0x7FFAC81CE8D0
        public void WriteRawLittleEndian32(){} // RVA: 0x7FFAC81CEA80
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x7FFAC81CEBB0
        public void WriteRawLittleEndian64(){} // RVA: 0x7FFAC81CEC60
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x7FFAC81CED90
        public void WriteRawByte(){} // RVA: 0x7FFAC81CEEA0
        public void WriteRawBytes(){} // RVA: 0x7FFAC81CEFE0 | overloaded x2
        public void WriteTag(){} // RVA: 0x7FFAC81CF3A0 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x7FFAC81CF480 | overloaded x2
        public void WriteRawTagSlowPath(){} // RVA: 0x7FFAC81CF560
        public void .cctor(){} // RVA: 0x7FFAC81CF5F0
    }

    public class WritingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x7FFAC81CF690
        public void WriteRawMessage(){} // RVA: 0x7FFAC81CF750
    }

}