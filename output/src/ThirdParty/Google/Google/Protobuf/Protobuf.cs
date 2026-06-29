// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 70
// Methods: 471

namespace ThirdParty.Google.Google.Protobuf
{
    public class ByteString : Object
    {
        // ── Methods ──
        public void AttachBytes(){} // RVA: 0x7AD80AEC0
        public void .ctor(){} // RVA: 0x7A9D82630
        public void get_Empty(){} // RVA: 0x7AD80B0B0
        public void get_Length(){} // RVA: 0x7AD80B110
        public void get_Span(){} // RVA: 0x7AD80B150
        public void ToBase64(){} // RVA: 0x7AD80B1B0
        public void CopyFrom(){} // RVA: 0x7AD80B3D0
        public void GetEnumerator(){} // RVA: 0x7AD80B5A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD80B5A0
        public void CreateCodedInput(){} // RVA: 0x7AD80B6A0
        public void op_Equality(){} // RVA: 0x7AD80BA60
        public void op_Inequality(){} // RVA: 0x7AD80BB30
        public void Equals(){} // RVA: 0x7AD80BE00
        public void GetHashCode(){} // RVA: 0x7AD80BD70
        public void .cctor(){} // RVA: 0x7AD80BF00
    }

    public class ByteString[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CodedInputStream : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD80C350
        public void set_DiscardUnknownFields(){} // RVA: 0x7AD80C510
        public void set_ExtensionRegistry(){} // RVA: 0x7A87446C0
        public void get_InternalBuffer(){} // RVA: 0x7A80DA7B0
        public void get_InternalInputStream(){} // RVA: 0x7A81052C0
        public void get_InternalState(){} // RVA: 0x7AD80C520
        public void Dispose(){} // RVA: 0x7AD80C530
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7AD80C570
        public void ReadRawMessage(){} // RVA: 0x7AD80C5E0
    }

    public class CodedOutputStream : Object
    {
        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x7AD80C6F0
        public void ComputeInt64Size(){} // RVA: 0x7AD80C740
        public void ComputeInt32Size(){} // RVA: 0x7AD80C790
        public void ComputeFixed64Size(){} // RVA: 0x7A88217C0
        public void ComputeFixed32Size(){} // RVA: 0x7A883BE70
        public void ComputeStringSize(){} // RVA: 0x7AD80C830
        public void ComputeMessageSize(){} // RVA: 0x7AD80C8E0
        public void ComputeBytesSize(){} // RVA: 0x7AD80C970
        public void ComputeUInt32Size(){} // RVA: 0x7AD80CA30
        public void ComputeEnumSize(){} // RVA: 0x7AD80CAC0
        public void ComputeLengthSize(){} // RVA: 0x7AD80CB10
        public void ComputeRawVarint32Size(){} // RVA: 0x7AD80CBA0
        public void ComputeRawVarint64Size(){} // RVA: 0x7AD80CBE0
        public void ComputeTagSize(){} // RVA: 0x7AD80CC80
        public void .ctor(){} // RVA: 0x7AD80CD50
        public void WriteRawMessage(){} // RVA: 0x7AD80CF80
        public void Dispose(){} // RVA: 0x7AD80D130
        public void Flush(){} // RVA: 0x7AD80D230
        public void CheckNoSpaceLeft(){} // RVA: 0x7AD80D300
        public void get_InternalBuffer(){} // RVA: 0x7A80DA7B0
        public void get_InternalOutputStream(){} // RVA: 0x7A8292C30
        public void get_InternalState(){} // RVA: 0x7AD80D310
        public void .cctor(){} // RVA: 0x7AD80D320
    }

    public class Extension : Object
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void CreateValue(){} // RVA: 0x7A7E00680
        public void get_FieldNumber(){} // RVA: 0x7A8124910
        public void get_IsRepeated(){} // RVA: 0x7A7E01900
    }

    public class ExtensionRegistry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD80D470
        public void get_Count(){} // RVA: 0x7AD80D8D0
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void ContainsInputField(){} // RVA: 0x7AD80D920
        public void Add(){} // RVA: 0x7AD80DA90
        public void AddRange(){} // RVA: 0x7AD80DC00
        public void Clear(){} // RVA: 0x7AD80DE40
        public void Contains(){} // RVA: 0x7AD80DE90
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(){} // RVA: 0x7AD80E000
        public void GetEnumerator(){} // RVA: 0x7AD80E340
        public void Remove(){} // RVA: 0x7AD80E3C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD80E340
        public void Clone(){} // RVA: 0x7AD80E530
    }

    public class ExtensionSet : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7A7E05210
        public void Get(){} // RVA: 0x7A7E00C10
        public void GetOrInitialize(){} // RVA: 0x7A7E00C10
        public void Set(){} // RVA: 0x7A8051B10
        public void Has(){} // RVA: 0x7A7E01F80
        public void Clear(){} // RVA: 0x7A7E18AA0
        public void TryMergeFieldFrom(){} // RVA: 0x7A7E01F80
        public void MergeFrom(){} // RVA: 0x7A7E18AA0
        public void Clone(){} // RVA: 0x7A7E00BA0
    }

    public class ExtensionSet`1 : Object
    {
        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0x7A7E00680
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void Equals(){} // RVA: 0x7A7E019D0
        public void CalculateSize(){} // RVA: 0x7A7E00710
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class ExtensionValue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void CalculateSize(){} // RVA: 0x7A7E00710
        public void Clone(){} // RVA: 0x7A7E00680
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void MergeFrom(){} // RVA: 0x7A7E18800
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void GetValue(){} // RVA: 0x7A8051B10
        public void SetValue(){} // RVA: 0x7A8051B10
    }

    public class Extension`2 : Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E19BE0
        public void get_DefaultValue(){} // RVA: 0x7A8051B10
        public void get_TargetType(){} // RVA: 0x7A7E00680
        public void get_IsRepeated(){} // RVA: 0x7A7E01900
        public void CreateValue(){} // RVA: 0x7A7E00680
    }

    public class FieldCodec : Object
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x7AD80EA80
        public void ForInt32(){} // RVA: 0x7AD80ED80
        public void ForUInt32(){} // RVA: 0x7AD80F1F0
        public void ForFloat(){} // RVA: 0x7AD80F660
        public void ForMessage(){} // RVA: 0x7A8051B10
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void IsPackedRepeatedField(){} // RVA: 0x7A7E023D0
        public void get_PackedRepeatedField(){} // RVA: 0x7A7E01900
        public void get_ValueWriter(){} // RVA: 0x7A7E00680
        public void get_ValueSizeCalculator(){} // RVA: 0x7A7E00680
        public void get_ValueReader(){} // RVA: 0x7A7E00680
        public void get_ValueMerger(){} // RVA: 0x7A7E00680
        public void get_FieldMerger(){} // RVA: 0x7A7E00680
        public void get_FixedSize(){} // RVA: 0x7A7E00710
        public void get_Tag(){} // RVA: 0x7A7E00710
        public void get_EndTag(){} // RVA: 0x7A7E00710
        public void get_DefaultValue(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
        public void WriteTagAndValue(){} // RVA: 0x7A8051B10
        public void Read(){} // RVA: 0x7A8051B10
        public void CalculateSizeWithTag(){} // RVA: 0x7A8051B10
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x7A8051B10
        public void IsDefault(){} // RVA: 0x7A8051B10
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0x7A8105330
        public void IsPackedRepeatedField(){} // RVA: 0x7AB121C50
        public void get_FixedSize(){} // RVA: 0x7A8178B30
        public void get_Tag(){} // RVA: 0x7A8178B50
        public void get_PackedRepeatedField(){} // RVA: 0x7A81A2200
        public void get_ValueSizeCalculator(){} // RVA: 0x7A81052C0
        public void get_EndTag(){} // RVA: 0x7A8178B70
        public void get_ValueWriter(){} // RVA: 0x7A80DA7B0
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0x7A8105330
        public void IsPackedRepeatedField(){} // RVA: 0x7AB120850
        public void get_FixedSize(){} // RVA: 0x7A8178B30
        public void get_Tag(){} // RVA: 0x7A8178B50
        public void get_PackedRepeatedField(){} // RVA: 0x7A81A2200
        public void get_ValueSizeCalculator(){} // RVA: 0x7A81052C0
        public void get_EndTag(){} // RVA: 0x7A8178B70
        public void get_ValueWriter(){} // RVA: 0x7A80DA7B0
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0x7A8105330
        public void IsPackedRepeatedField(){} // RVA: 0x7AB120850
        public void get_FixedSize(){} // RVA: 0x7A8178B30
        public void get_Tag(){} // RVA: 0x7A8178B50
        public void get_PackedRepeatedField(){} // RVA: 0x7A81A2200
        public void get_ValueSizeCalculator(){} // RVA: 0x7A81052C0
        public void get_EndTag(){} // RVA: 0x7A8178B70
        public void get_ValueWriter(){} // RVA: 0x7A80DA7B0
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0x7A8105330
        public void IsPackedRepeatedField(){} // RVA: 0x7AB121C50
        public void get_FixedSize(){} // RVA: 0x7A8178B30
        public void get_Tag(){} // RVA: 0x7A8178B50
        public void get_PackedRepeatedField(){} // RVA: 0x7A81A2200
        public void get_ValueSizeCalculator(){} // RVA: 0x7A81052C0
        public void get_EndTag(){} // RVA: 0x7A8178B70
        public void get_ValueWriter(){} // RVA: 0x7A80DA7B0
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0x7A8105330
        public void IsPackedRepeatedField(){} // RVA: 0x7AB121C50
        public void get_FixedSize(){} // RVA: 0x7A8178B30
        public void get_Tag(){} // RVA: 0x7A8178B50
        public void get_PackedRepeatedField(){} // RVA: 0x7A81A2200
        public void get_ValueSizeCalculator(){} // RVA: 0x7A81052C0
        public void get_EndTag(){} // RVA: 0x7A8178B70
        public void get_ValueWriter(){} // RVA: 0x7A80DA7B0
    }

    public class FieldCodec`1 : Object
    {
        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0x7A8105330
        public void IsPackedRepeatedField(){} // RVA: 0x7AB121C50
        public void get_FixedSize(){} // RVA: 0x7A8178B30
        public void get_Tag(){} // RVA: 0x7A8178B50
        public void get_PackedRepeatedField(){} // RVA: 0x7A81A2200
        public void get_ValueSizeCalculator(){} // RVA: 0x7A81052C0
        public void get_EndTag(){} // RVA: 0x7A8178B70
        public void get_ValueWriter(){} // RVA: 0x7A80DA7B0
    }

    public class FieldMaskTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD80FDF0
        public void ToString(){} // RVA: 0x7AD80FEB0
        public void AddFieldPath(){} // RVA: 0x7AD80FEF0
        public void MergeFromFieldMask(){} // RVA: 0x7AD810190
        public void ToFieldMask(){} // RVA: 0x7AD810370
        public void GetFieldPaths(){} // RVA: 0x7AD8104A0
        public void IntersectFieldPath(){} // RVA: 0x7AD810760
        public void Merge(){} // RVA: 0x7AD810C90
    }

    public class FrameworkPortability : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD8117F0
    }

    public class IBufferMessage
    {
        // ── Methods ──
        public void InternalMergeFrom(){} // RVA: 0x7A7E18800
        public void InternalWriteTo(){} // RVA: 0x7A7E18800
    }

    public class ICustomDiagnosticMessage
    {
        // ── Methods ──
        public void ToDiagnosticString(){} // RVA: 0x7A7E00680
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A8051B10
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A7E00680
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A7E00710
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A7E155B0
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A7E00680
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A7E00680
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A7E00680
    }

    public class IExtendableMessage`1
    {
        // ── Methods ──
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
    }

    public class IExtensionValue
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7A7E18800
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void CalculateSize(){} // RVA: 0x7A7E00710
    }

    public class IMessage
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7A7E18800
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void CalculateSize(){} // RVA: 0x7A7E00710
        public void get_Descriptor(){} // RVA: 0x7A7E00680
    }

    public class IMessage`1
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7A8051B10
    }

    public class InvalidProtocolBufferException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8119C0
        public void MoreDataAvailable(){} // RVA: 0x7AD8119E0
        public void TruncatedMessage(){} // RVA: 0x7AD811A50
        public void NegativeSize(){} // RVA: 0x7AD811AC0
        public void MalformedVarint(){} // RVA: 0x7AD811B30
        public void InvalidTag(){} // RVA: 0x7AD811BA0
        public void InvalidWireType(){} // RVA: 0x7AD811C10
        public void InvalidEndTag(){} // RVA: 0x7AD811C80
        public void RecursionLimitExceeded(){} // RVA: 0x7AD811CF0
        public void SizeLimitExceeded(){} // RVA: 0x7AD811D60
    }

    public class JsonFormatter : Object
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x7AD811DD0
        public void .cctor(){} // RVA: 0x7AD811E30
        public void get_DiagnosticOnly(){} // RVA: 0x7AD813350
        public void .ctor(){} // RVA: 0x7AD8133B0
        public void Format(){} // RVA: 0x7AD813550
        public void ToDiagnosticString(){} // RVA: 0x7AD813700
        public void WriteMessage(){} // RVA: 0x7AD813860
        public void WriteMessageFields(){} // RVA: 0x7AD813A60
        public void ShouldFormatFieldValue(){} // RVA: 0x7AD814040
        public void ToJsonName(){} // RVA: 0x7AD8141B0
        public void WriteNull(){} // RVA: 0x7AD814320
        public void IsDefaultValue(){} // RVA: 0x7AD814380
        public void WriteValue(){} // RVA: 0x7AD8148E0
        public void WriteWellKnownTypeValue(){} // RVA: 0x7AD8152C0
        public void WriteTimestamp(){} // RVA: 0x7AD815B00
        public void WriteDuration(){} // RVA: 0x7AD815D70
        public void WriteFieldMask(){} // RVA: 0x7AD815FE0
        public void WriteAny(){} // RVA: 0x7AD8161B0
        public void WriteDiagnosticOnlyAny(){} // RVA: 0x7AD8166B0
        public void WriteStruct(){} // RVA: 0x7AD816A10
        public void WriteStructFieldValue(){} // RVA: 0x7AD816EE0
        public void WriteList(){} // RVA: 0x7AD817240
        public void WriteDictionary(){} // RVA: 0x7AD817510
        public void WriteString(){} // RVA: 0x7AD817B90
        public void HexEncodeUtf16CodeUnit(){} // RVA: 0x7AD817F90
    }

    public class MessageExtensions : Object
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7AD8198B0
        public void ToByteArray(){} // RVA: 0x7AD819160
        public void ToByteString(){} // RVA: 0x7AD8192B0
        public void WriteTo(){} // RVA: 0x7AD819390
    }

    public class MessageParser : Object
    {
        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x7A80F26D0
        public void get_Extensions(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AD819AE0
        public void CreateTemplate(){} // RVA: 0x7A9038740
        public void ParseFrom(){} // RVA: 0x7AD819BA0
    }

    public class MessageParser`1 : MessageParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1E800
        public void CreateTemplate(){} // RVA: 0x7A8051B10
        public void ParseFrom(){} // RVA: 0x7A8051B10
        public void WithExtensionRegistry(){} // RVA: 0x7A7E00B20
    }

    public class ObjectIntPair`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
    }

    public class ParseContext : ValueType
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AD819F30
        public void get_LastTag(){} // RVA: 0x7A76B6CB0
        public void get_DiscardUnknownFields(){} // RVA: 0x7A7D13240
        public void set_DiscardUnknownFields(){} // RVA: 0x7A7D13250
        public void get_ExtensionRegistry(){} // RVA: 0x7A7690CE0
        public void set_ExtensionRegistry(){} // RVA: 0x7A76F9760
        public void ReadTag(){} // RVA: 0x7A7D13260
        public void ReadDouble(){} // RVA: 0x7A7D13270
        public void ReadFloat(){} // RVA: 0x7A7D13280
        public void ReadUInt64(){} // RVA: 0x7A7D13290
        public void ReadInt64(){} // RVA: 0x7A7D13290
        public void ReadInt32(){} // RVA: 0x7A7D132A0
        public void ReadFixed64(){} // RVA: 0x7A7D132B0
        public void ReadFixed32(){} // RVA: 0x7A7D132C0
        public void ReadBool(){} // RVA: 0x7A7D132D0
        public void ReadString(){} // RVA: 0x7A7D132F0
        public void ReadMessage(){} // RVA: 0x7A7D13330
        public void ReadBytes(){} // RVA: 0x7A7D13340
        public void ReadUInt32(){} // RVA: 0x7A7D132A0
        public void ReadEnum(){} // RVA: 0x7A7D132A0
        public void ReadLength(){} // RVA: 0x7A7D132A0
        public void CopyStateTo(){} // RVA: 0x7A7D13350
        public void LoadStateFrom(){} // RVA: 0x7A7D13360
    }

    public class ParserInternalState : ValueType
    {
        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0x7A76AD770
        public void get_DiscardUnknownFields(){} // RVA: 0x7A7D13390
        public void set_DiscardUnknownFields(){} // RVA: 0x7A7D133A0
        public void get_ExtensionRegistry(){} // RVA: 0x7A7D133B0
        public void set_ExtensionRegistry(){} // RVA: 0x7A766E2B0
    }

    public class ParsingPrimitives : Object
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x7AD81A320
        public void ParseTag(){} // RVA: 0x7AD81A330
        public void MaybeConsumeTag(){} // RVA: 0x7AD81A4A0
        public void PeekTag(){} // RVA: 0x7AD81A500
        public void ParseRawVarint64(){} // RVA: 0x7AD81A540
        public void ParseRawVarint64SlowPath(){} // RVA: 0x7AD81A6B0
        public void ParseRawVarint32(){} // RVA: 0x7AD81A790
        public void ParseRawVarint32SlowPath(){} // RVA: 0x7AD81A960
        public void ParseRawLittleEndian32(){} // RVA: 0x7AD81AB00
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x7AD81ABE0
        public void ParseRawLittleEndian64(){} // RVA: 0x7AD81AD30
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x7AD81AE10
        public void ParseDouble(){} // RVA: 0x7AD81B0B0
        public void ParseFloat(){} // RVA: 0x7AD81B170
        public void ParseFloatSlow(){} // RVA: 0x7AD81B230
        public void ReadRawBytes(){} // RVA: 0x7AD81B330
        public void ReadRawBytesSlow(){} // RVA: 0x7AD81B520
        public void SkipRawBytes(){} // RVA: 0x7AD81BB70
        public void ReadString(){} // RVA: 0x7AD81BC80
        public void ReadBytes(){} // RVA: 0x7AD81BCC0
        public void ReadRawString(){} // RVA: 0x7AD81BD40
        public void ReadStringSlow(){} // RVA: 0x7AD81BED0
        public void ValidateCurrentLimit(){} // RVA: 0x7AD81C3D0
        public void ReadRawByte(){} // RVA: 0x7AD81C440
        public void IsDataAvailable(){} // RVA: 0x7AD81C4B0
        public void IsDataAvailableInSource(){} // RVA: 0x7AD81C4D0
        public void ReadRawBytesIntoSpan(){} // RVA: 0x7AD81C590
    }

    public class ParsingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x7AD81C7A0
        public void SkipGroup(){} // RVA: 0x7AD81C960
        public void ReadMessage(){} // RVA: 0x7AD81CB10
        public void ReadMapEntry(){} // RVA: 0x7A8051B10
        public void ReadGroup(){} // RVA: 0x7AD81CC70
        public void ReadRawMessage(){} // RVA: 0x7AD81CD80
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7AD81CF20
        public void CheckLastTagWas(){} // RVA: 0x7AD81CF60
        public void .cctor(){} // RVA: 0x7AD81CFA0
    }

    public class ProtoPreconditions : Object
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x7AA56E520
        public void CheckNotNullUnconstrained(){} // RVA: 0x7AA56E520
    }

    public class RepeatedExtensionValue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void CalculateSize(){} // RVA: 0x7A7E00710
        public void Clone(){} // RVA: 0x7A7E00680
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void MergeFrom(){} // RVA: 0x7A7E18800
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void GetValue(){} // RVA: 0x7A7E00680
    }

    public class RepeatedExtension`2 : Extension
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7A7E00680
        public void get_IsRepeated(){} // RVA: 0x7A7E01900
        public void CreateValue(){} // RVA: 0x7A7E00680
    }

    public class SegmentedBufferHelper : ValueType
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AD81D150
        public void RefillBuffer(){} // RVA: 0x7A7D133E0
        public void get_TotalLength(){} // RVA: 0x7A765F710
        public void get_CodedInputStream(){} // RVA: 0x7A768E520
        public void PushLimit(){} // RVA: 0x7AD81D4D0
        public void PopLimit(){} // RVA: 0x7AD81D570
        public void IsReachedLimit(){} // RVA: 0x7AD81D5A0
        public void IsAtEnd(){} // RVA: 0x7AD81D5C0
        public void RefillFromReadOnlySequence(){} // RVA: 0x7A7D13410
        public void RefillFromCodedInputStream(){} // RVA: 0x7A7D13420
        public void RecomputeBufferSizeAfterLimit(){} // RVA: 0x7AD81DA60
        public void CheckCurrentBufferIsEmpty(){} // RVA: 0x7AD81DA90
    }

    public class UnknownField : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Equals(){} // RVA: 0x7AD81DB00
        public void GetHashCode(){} // RVA: 0x7AD81DD70
        public void WriteTo(){} // RVA: 0x7AD81DE70
        public void GetSerializedSize(){} // RVA: 0x7AD81E750
        public void MergeFrom(){} // RVA: 0x7AD81EED0
        public void AddAll(){} // RVA: 0x7A7E00C10
        public void AddVarint(){} // RVA: 0x7AD81F480
        public void AddFixed32(){} // RVA: 0x7AD81F520
        public void AddFixed64(){} // RVA: 0x7AD81F680
        public void AddLengthDelimited(){} // RVA: 0x7AD81F720
        public void AddGroup(){} // RVA: 0x7AD81F870
        public void Add(){} // RVA: 0x7A8051B10
    }

    public class UnknownFieldSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD81F9C0
        public void HasField(){} // RVA: 0x7AD81FA80
        public void WriteTo(){} // RVA: 0x7AD81FAE0
        public void CalculateSize(){} // RVA: 0x7AD81FD00
        public void Equals(){} // RVA: 0x7AD81FF20
        public void GetHashCode(){} // RVA: 0x7AD820300
        public void GetOrAddField(){} // RVA: 0x7AD820540
        public void AddOrReplaceField(){} // RVA: 0x7AD820670
        public void MergeFieldFrom(){} // RVA: 0x7AD820F30
        public void MergeGroupFrom(){} // RVA: 0x7AD820ED0
        public void MergeFrom(){} // RVA: 0x7AD821360
        public void MergeField(){} // RVA: 0x7AD8213E0
        public void Clone(){} // RVA: 0x7AD821500
    }

    public class UnknownFieldSet[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class WireFormat : Object
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x7AD821580
        public void GetTagFieldNumber(){} // RVA: 0x7AD821590
        public void MakeTag(){} // RVA: 0x7AD8215A0
    }

    public class WriteBufferHelper : ValueType
    {
        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7A765F080
        public void Initialize(){} // RVA: 0x7AD8215B0
        public void InitializeNonRefreshable(){} // RVA: 0x7AD821660
        public void CheckNoSpaceLeft(){} // RVA: 0x7AD821710
        public void GetSpaceLeft(){} // RVA: 0x7AD821780
        public void RefreshBuffer(){} // RVA: 0x7AD821800
        public void Flush(){} // RVA: 0x7AD821940
    }

    public class WriteContext : ValueType
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AD821A70
        public void WriteDouble(){} // RVA: 0x7A7D13470
        public void WriteFloat(){} // RVA: 0x7A7D13480
        public void WriteUInt64(){} // RVA: 0x7A7D13490
        public void WriteInt64(){} // RVA: 0x7A7D134A0
        public void WriteInt32(){} // RVA: 0x7A7D134B0
        public void WriteFixed64(){} // RVA: 0x7A7D134C0
        public void WriteFixed32(){} // RVA: 0x7A7D134D0
        public void WriteBool(){} // RVA: 0x7A7D134E0
        public void WriteString(){} // RVA: 0x7A7D134F0
        public void WriteMessage(){} // RVA: 0x7A7D13500
        public void WriteBytes(){} // RVA: 0x7A7D13510
        public void WriteUInt32(){} // RVA: 0x7A7D13520
        public void WriteEnum(){} // RVA: 0x7A7D13530
        public void WriteLength(){} // RVA: 0x7A7D13540
        public void WriteTag(){} // RVA: 0x7A7D13560
        public void WriteRawTag(){} // RVA: 0x7A7D13580
        public void CheckNoSpaceLeft(){} // RVA: 0x7A7D13590
        public void CopyStateTo(){} // RVA: 0x7A7D135A0
        public void LoadStateFrom(){} // RVA: 0x7A7D13610
    }

    public class WriterInternalState : ValueType
    {
        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7A7664CF0
    }

    public class WritingPrimitives : Object
    {
        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x7AD822960
        public void WriteFloat(){} // RVA: 0x7AD8229D0
        public void WriteFloatSlowPath(){} // RVA: 0x7AD822AF0
        public void WriteUInt64(){} // RVA: 0x7AD822C10
        public void WriteInt64(){} // RVA: 0x7AD822C80
        public void WriteInt32(){} // RVA: 0x7AD822CF0
        public void WriteFixed64(){} // RVA: 0x7AD822D90
        public void WriteFixed32(){} // RVA: 0x7AD822E00
        public void WriteBool(){} // RVA: 0x7AD822F70
        public void WriteString(){} // RVA: 0x7AD822FE0
        public void WriteAsciiStringToBuffer(){} // RVA: 0x7AD823290
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x7AD823430
        public void WriteStringToBuffer(){} // RVA: 0x7AD823450
        public void WriteBytes(){} // RVA: 0x7AD8235B0
        public void WriteUInt32(){} // RVA: 0x7AD8236C0
        public void WriteEnum(){} // RVA: 0x7AD823730
        public void WriteLength(){} // RVA: 0x7AD8237A0
        public void WriteRawVarint32(){} // RVA: 0x7AD823810
        public void WriteRawVarint64(){} // RVA: 0x7AD8239C0
        public void WriteRawLittleEndian32(){} // RVA: 0x7AD823B70
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x7AD823CA0
        public void WriteRawLittleEndian64(){} // RVA: 0x7AD823D50
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x7AD823E80
        public void WriteRawByte(){} // RVA: 0x7AD823F90
        public void WriteRawBytes(){} // RVA: 0x7AD8240D0
        public void WriteTag(){} // RVA: 0x7AD824480
        public void WriteRawTag(){} // RVA: 0x7AD824560
        public void WriteRawTagSlowPath(){} // RVA: 0x7AD824640
        public void .cctor(){} // RVA: 0x7AD8246D0
    }

    public class WritingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x7AD824770
        public void WriteRawMessage(){} // RVA: 0x7AD824820
    }

}