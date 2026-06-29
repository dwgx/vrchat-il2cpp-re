// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 70
// Methods: 474

namespace ThirdParty.Google.Google.Protobuf
{
    public class ByteString : Object
    {
        public object empty;
        public object bytes;

        // ── Methods ──
        public void AttachBytes(){} // RVA: 0x6498D50
        public void .ctor(){} // RVA: 0x27FE060
        public void get_Empty(){} // RVA: 0x6498F40
        public void get_Length(){} // RVA: 0x6498FA0
        public void get_Span(){} // RVA: 0x6498FE0
        public void ToBase64(){} // RVA: 0x6499040
        public void CopyFrom(){} // RVA: 0x6499260
        public void GetEnumerator(){} // RVA: 0x6499430
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6499430
        public void CreateCodedInput(){} // RVA: 0x6499530
        public void op_Equality(){} // RVA: 0x64998F0
        public void op_Inequality(){} // RVA: 0x64999C0
        public void Equals(){} // RVA: 0x6499C90
        public void GetHashCode(){} // RVA: 0x6499C00
        public void .cctor(){} // RVA: 0x6499D90
    }

    public class ByteString[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CodedInputStream : Object
    {
        public object leaveOpen;
        public object buffer;
        public object input;
        public object state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x649A1E0
        public void set_DiscardUnknownFields(){} // RVA: 0x649A3A0
        public void set_ExtensionRegistry(){} // RVA: 0xD5CCD0
        public void get_InternalBuffer(){} // RVA: 0xB465B0
        public void get_InternalInputStream(){} // RVA: 0xB700F0
        public void get_InternalState(){} // RVA: 0x649A3B0
        public void Dispose(){} // RVA: 0x649A3C0
        public void CheckReadEndOfStreamTag(){} // RVA: 0x649A400
        public void ReadRawMessage(){} // RVA: 0x649A470
        public void h(){} // RVA: 0xD066C38
    }

    public class CodedOutputStream : Object
    {
        public object DefaultBufferSize;
        public object leaveOpen;
        public object buffer;
        public object state;
        public object output;

        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x649A580
        public void ComputeInt64Size(){} // RVA: 0x649A5D0
        public void ComputeInt32Size(){} // RVA: 0x649A620
        public void ComputeFixed64Size(){} // RVA: 0x17FCE50
        public void ComputeFixed32Size(){} // RVA: 0x1347420
        public void ComputeStringSize(){} // RVA: 0x649A6C0
        public void ComputeMessageSize(){} // RVA: 0x649A770
        public void ComputeBytesSize(){} // RVA: 0x649A800
        public void ComputeUInt32Size(){} // RVA: 0x649A8C0
        public void ComputeEnumSize(){} // RVA: 0x649A950
        public void ComputeLengthSize(){} // RVA: 0x649A9A0
        public void ComputeRawVarint32Size(){} // RVA: 0x649AA30
        public void ComputeRawVarint64Size(){} // RVA: 0x649AA70
        public void ComputeTagSize(){} // RVA: 0x649AB10
        public void .ctor(){} // RVA: 0x649ABE0
        public void WriteRawMessage(){} // RVA: 0x649AE10
        public void Dispose(){} // RVA: 0x649AFC0
        public void Flush(){} // RVA: 0x649B0C0
        public void CheckNoSpaceLeft(){} // RVA: 0x649B190
        public void get_InternalBuffer(){} // RVA: 0xB465B0
        public void get_InternalOutputStream(){} // RVA: 0xD05CA0
        public void get_InternalState(){} // RVA: 0x649B1A0
        public void .cctor(){} // RVA: 0x649B1B0
        public void h(){} // RVA: 0xD06C518
    }

    public class Extension : Object
    {
        public object _fieldNumber;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB460A0
        public void CreateValue(){} // RVA: 0x87C0A0
        public void get_FieldNumber(){} // RVA: 0xB8F8F0
        public void get_IsRepeated(){} // RVA: 0x87D280
    }

    public class ExtensionRegistry : Object
    {
        public object extensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x649B300
        public void get_Count(){} // RVA: 0x649B760
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly(){} // RVA: 0xB43320
        public void ContainsInputField(){} // RVA: 0x649B7B0
        public void Add(){} // RVA: 0x649B920
        public void AddRange(){} // RVA: 0x649BA90
        public void Clear(){} // RVA: 0x649BCD0
        public void Contains(){} // RVA: 0x649BD20
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(){} // RVA: 0x649BE90
        public void GetEnumerator(){} // RVA: 0x649C1D0
        public void Remove(){} // RVA: 0x649C250
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x649C1D0
        public void Clone(){} // RVA: 0x649C3C0
    }

    public class ExtensionSet : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x880B90
        public void Get(){} // RVA: 0x87C630
        public void GetOrInitialize(){} // RVA: 0x87C630
        public void Set(){} // RVA: 0xA94080
        public void Has(){} // RVA: 0x87D880
        public void Clear(){} // RVA: 0x8945C0
        public void TryMergeFieldFrom(){} // RVA: 0x87D880
        public void MergeFrom(){} // RVA: 0x8945C0
        public void Clone(){} // RVA: 0x87C5C0
    }

    public class ExtensionSet`1 : Object
    {
        public object _valuesByNumber;

        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0x87C0A0
        public void GetHashCode(){} // RVA: 0x87C130
        public void Equals(){} // RVA: 0x87D350
        public void CalculateSize(){} // RVA: 0x87C130
        public void WriteTo(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class ExtensionValue`1 : Object
    {
        public object field;
        public object codec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void CalculateSize(){} // RVA: 0x87C130
        public void Clone(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void MergeFrom(){} // RVA: 0x894320
        public void WriteTo(){} // RVA: 0x894320
        public void GetValue(){} // RVA: 0xA94080
        public void SetValue(){} // RVA: 0xA94080
    }

    public class Extension`2 : Extension
    {
        public object codec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x895750
        public void get_DefaultValue(){} // RVA: 0xA94080
        public void get_TargetType(){} // RVA: 0x87C0A0
        public void get_IsRepeated(){} // RVA: 0x87D280
        public void CreateValue(){} // RVA: 0x87C0A0
    }

    public class FieldCodec : Object
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x649C910
        public void ForInt32(){} // RVA: 0x649CC10
        public void ForUInt32(){} // RVA: 0x649D080
        public void ForFloat(){} // RVA: 0x649D4F0
        public void ForMessage(){} // RVA: 0xA94080
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0xB70160
        public void IsPackedRepeatedField(){} // RVA: 0x3DDB980
        public void get_FixedSize(){} // RVA: 0xBE5850
        public void get_Tag(){} // RVA: 0xBE5870
        public void get_PackedRepeatedField(){} // RVA: 0xC120A0
        public void get_ValueSizeCalculator(){} // RVA: 0xB700F0
        public void get_EndTag(){} // RVA: 0xBE5890
        public void get_ValueWriter(){} // RVA: 0xB465B0
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void IsPackedRepeatedField(){} // RVA: 0x87DD60
        public void get_PackedRepeatedField(){} // RVA: 0x87D280
        public void get_ValueWriter(){} // RVA: 0x87C0A0
        public void get_ValueSizeCalculator(){} // RVA: 0x87C0A0
        public void get_ValueReader(){} // RVA: 0x87C0A0
        public void get_ValueMerger(){} // RVA: 0x87C0A0
        public void get_FieldMerger(){} // RVA: 0x87C0A0
        public void get_FixedSize(){} // RVA: 0x87C130
        public void get_Tag(){} // RVA: 0x87C130
        public void get_EndTag(){} // RVA: 0x87C130
        public void get_DefaultValue(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void WriteTagAndValue(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0xA94080
        public void CalculateSizeWithTag(){} // RVA: 0xA94080
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0xA94080
        public void IsDefault(){} // RVA: 0xA94080
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0xB70160
        public void IsPackedRepeatedField(){} // RVA: 0x3DDB980
        public void get_FixedSize(){} // RVA: 0xBE5850
        public void get_Tag(){} // RVA: 0xBE5870
        public void get_PackedRepeatedField(){} // RVA: 0xC120A0
        public void get_ValueSizeCalculator(){} // RVA: 0xB700F0
        public void get_EndTag(){} // RVA: 0xBE5890
        public void get_ValueWriter(){} // RVA: 0xB465B0
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0xB70160
        public void IsPackedRepeatedField(){} // RVA: 0x3DDA5A0
        public void get_FixedSize(){} // RVA: 0xBE5850
        public void get_Tag(){} // RVA: 0xBE5870
        public void get_PackedRepeatedField(){} // RVA: 0xC120A0
        public void get_ValueSizeCalculator(){} // RVA: 0xB700F0
        public void get_EndTag(){} // RVA: 0xBE5890
        public void get_ValueWriter(){} // RVA: 0xB465B0
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0xB70160
        public void IsPackedRepeatedField(){} // RVA: 0x3DDA5A0
        public void get_FixedSize(){} // RVA: 0xBE5850
        public void get_Tag(){} // RVA: 0xBE5870
        public void get_PackedRepeatedField(){} // RVA: 0xC120A0
        public void get_ValueSizeCalculator(){} // RVA: 0xB700F0
        public void get_EndTag(){} // RVA: 0xBE5890
        public void get_ValueWriter(){} // RVA: 0xB465B0
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0xB70160
        public void IsPackedRepeatedField(){} // RVA: 0x3DDB980
        public void get_FixedSize(){} // RVA: 0xBE5850
        public void get_Tag(){} // RVA: 0xBE5870
        public void get_PackedRepeatedField(){} // RVA: 0xC120A0
        public void get_ValueSizeCalculator(){} // RVA: 0xB700F0
        public void get_EndTag(){} // RVA: 0xBE5890
        public void get_ValueWriter(){} // RVA: 0xB465B0
    }

    public class FieldCodec`1 : Object
    {
        public object EqualityComparer;
        public object DefaultDefault;
        public object TypeSupportsPacking;
        public object _packedRepeatedField;
        public object _valueWriter;
        public object _valueSizeCalculator;
        public object _valueReader;
        public object _valueMerger;
        public object _fieldMerger;
        public object _fixedSize;
        public object _tag;
        public object _endTag;
        public object _defaultValue;
        public object tagSize;

        // ── Methods ──
        public void get_ValueReader(){} // RVA: 0xB70160
        public void IsPackedRepeatedField(){} // RVA: 0x3DDB980
        public void get_FixedSize(){} // RVA: 0xBE5850
        public void get_Tag(){} // RVA: 0xBE5870
        public void get_PackedRepeatedField(){} // RVA: 0xC120A0
        public void get_ValueSizeCalculator(){} // RVA: 0xB700F0
        public void get_EndTag(){} // RVA: 0xBE5890
        public void get_ValueWriter(){} // RVA: 0xB465B0
    }

    public class FieldMaskTree : Object
    {
        public object root;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x649DC80
        public void ToString(){} // RVA: 0x649DD40
        public void AddFieldPath(){} // RVA: 0x649DD80
        public void MergeFromFieldMask(){} // RVA: 0x649E020
        public void ToFieldMask(){} // RVA: 0x649E200
        public void GetFieldPaths(){} // RVA: 0x649E330
        public void IntersectFieldPath(){} // RVA: 0x649E5F0
        public void Merge(){} // RVA: 0x649EB20
    }

    public class FrameworkPortability : Object
    {
        public object CompiledRegexWhereAvailable;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x649F680
    }

    public class IBufferMessage
    {
        // ── Methods ──
        public void InternalMergeFrom(){} // RVA: 0x894320
        public void InternalWriteTo(){} // RVA: 0x894320
    }

    public class ICustomDiagnosticMessage
    {
        // ── Methods ──
        public void ToDiagnosticString(){} // RVA: 0x87C0A0
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x87C0A0
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0xA94080
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x87C0A0
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x87C130
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x890F90
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x87C0A0
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x87C0A0
    }

    public class IExtendableMessage`1
    {
        // ── Methods ──
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
    }

    public class IExtensionValue
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x894320
        public void WriteTo(){} // RVA: 0x894320
        public void CalculateSize(){} // RVA: 0x87C130
    }

    public class IMessage
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x894320
        public void WriteTo(){} // RVA: 0x894320
        public void CalculateSize(){} // RVA: 0x87C130
        public void get_Descriptor(){} // RVA: 0x87C0A0
    }

    public class IMessage`1
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0xA94080
    }

    public class InvalidProtocolBufferException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x649F7E0
        public void MoreDataAvailable(){} // RVA: 0x649F800
        public void TruncatedMessage(){} // RVA: 0x649F870
        public void NegativeSize(){} // RVA: 0x649F8E0
        public void MalformedVarint(){} // RVA: 0x649F950
        public void InvalidTag(){} // RVA: 0x649F9C0
        public void InvalidWireType(){} // RVA: 0x649FA30
        public void InvalidEndTag(){} // RVA: 0x649FAA0
        public void RecursionLimitExceeded(){} // RVA: 0x649FB10
        public void SizeLimitExceeded(){} // RVA: 0x649FB80
    }

    public class JsonFormatter : Object
    {
        public object _default;
        public object diagnosticFormatter;
        public object CommonRepresentations;
        public object settings;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x649FBF0
        public void .cctor(){} // RVA: 0x649FC50
        public void get_DiagnosticOnly(){} // RVA: 0x64A1130
        public void .ctor(){} // RVA: 0x64A1190
        public void Format(){} // RVA: 0x64A1330
        public void ToDiagnosticString(){} // RVA: 0x64A14E0
        public void WriteMessage(){} // RVA: 0x64A1640
        public void WriteMessageFields(){} // RVA: 0x64A1840
        public void ShouldFormatFieldValue(){} // RVA: 0x64A1E20
        public void ToJsonName(){} // RVA: 0x64A1F90
        public void WriteNull(){} // RVA: 0x64A20F0
        public void IsDefaultValue(){} // RVA: 0x64A2150
        public void WriteValue(){} // RVA: 0x64A2620
        public void WriteWellKnownTypeValue(){} // RVA: 0x64A2F70
        public void WriteTimestamp(){} // RVA: 0x64A37B0
        public void WriteDuration(){} // RVA: 0x64A3A00
        public void WriteFieldMask(){} // RVA: 0x64A3C50
        public void WriteAny(){} // RVA: 0x64A3E20
        public void WriteDiagnosticOnlyAny(){} // RVA: 0x64A4310
        public void WriteStruct(){} // RVA: 0x64A4660
        public void WriteStructFieldValue(){} // RVA: 0x64A4B20
        public void WriteList(){} // RVA: 0x64A4E80
        public void WriteDictionary(){} // RVA: 0x64A5150
        public void WriteString(){} // RVA: 0x64A5770
        public void HexEncodeUtf16CodeUnit(){} // RVA: 0x64A5B60
    }

    public class MessageExtensions : Object
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x64A7480
        public void ToByteArray(){} // RVA: 0x64A6D30
        public void ToByteString(){} // RVA: 0x64A6E80
        public void WriteTo(){} // RVA: 0x64A6F60
    }

    public class MessageParser : Object
    {
        public object factory;
        public object _discardUnknownFields;
        public object _extensions;

        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0xB5DD50
        public void get_Extensions(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x64A76B0
        public void CreateTemplate(){} // RVA: 0x1B68170
        public void ParseFrom(){} // RVA: 0x64A7770
    }

    public class MessageParser`1 : MessageParser
    {
        public object factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x89A3D0
        public void CreateTemplate(){} // RVA: 0xA94080
        public void ParseFrom(){} // RVA: 0xA94080
        public void WithExtensionRegistry(){} // RVA: 0x87C540
    }

    public class ObjectIntPair`1 : ValueType
    {
        public object number;
        public object obj;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
    }

    public class ParseContext : ValueType
    {
        public object buffer;
        public object state;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x64A7B00
        public void get_LastTag(){} // RVA: 0xCFAF0
        public void get_DiscardUnknownFields(){} // RVA: 0x7846E0
        public void set_DiscardUnknownFields(){} // RVA: 0x7846F0
        public void get_ExtensionRegistry(){} // RVA: 0xA6AA0
        public void set_ExtensionRegistry(){} // RVA: 0x11A860
        public void ReadTag(){} // RVA: 0x784700
        public void ReadDouble(){} // RVA: 0x784710
        public void ReadFloat(){} // RVA: 0x784720
        public void ReadUInt64(){} // RVA: 0x784730
        public void ReadInt64(){} // RVA: 0x784730
        public void ReadInt32(){} // RVA: 0x784740
        public void ReadFixed64(){} // RVA: 0x784750
        public void ReadFixed32(){} // RVA: 0x784760
        public void ReadBool(){} // RVA: 0x784770
        public void ReadString(){} // RVA: 0x784790
        public void ReadMessage(){} // RVA: 0x7847D0
        public void ReadBytes(){} // RVA: 0x7847E0
        public void ReadUInt32(){} // RVA: 0x784740
        public void ReadEnum(){} // RVA: 0x784740
        public void ReadLength(){} // RVA: 0x784740
        public void CopyStateTo(){} // RVA: 0x7847F0
        public void LoadStateFrom(){} // RVA: 0x784800
    }

    public class ParserInternalState : ValueType
    {
        public object bufferPos;
        public object bufferSize;
        public object bufferSizeAfterLimit;
        public object currentLimit;
        public object totalBytesRetired;
        public object recursionDepth;
        public object segmentedBufferHelper;
        public object lastTag;
        public object nextTag;
        public object hasNextTag;
        public object sizeLimit;
        public object recursionLimit;
        public object _discardUnknownFields;
        public object _extensionRegistry;

        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0xC5D60
        public void get_DiscardUnknownFields(){} // RVA: 0x7848D0
        public void set_DiscardUnknownFields(){} // RVA: 0x7848E0
        public void get_ExtensionRegistry(){} // RVA: 0x7848F0
        public void set_ExtensionRegistry(){} // RVA: 0xB770
    }

    public class ParsingPrimitives : Object
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x64A7EF0
        public void ParseTag(){} // RVA: 0x64A7F00
        public void MaybeConsumeTag(){} // RVA: 0x64A8070
        public void PeekTag(){} // RVA: 0x64A80D0
        public void ParseRawVarint64(){} // RVA: 0x64A8110
        public void ParseRawVarint64SlowPath(){} // RVA: 0x64A8280
        public void ParseRawVarint32(){} // RVA: 0x64A8360
        public void ParseRawVarint32SlowPath(){} // RVA: 0x64A8530
        public void ParseRawLittleEndian32(){} // RVA: 0x64A86D0
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x64A87B0
        public void ParseRawLittleEndian64(){} // RVA: 0x64A8900
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x64A89E0
        public void ParseDouble(){} // RVA: 0x64A8C80
        public void ParseFloat(){} // RVA: 0x64A8D40
        public void ParseFloatSlow(){} // RVA: 0x64A8E00
        public void ReadRawBytes(){} // RVA: 0x64A8F00
        public void ReadRawBytesSlow(){} // RVA: 0x64A90F0
        public void SkipRawBytes(){} // RVA: 0x64A9740
        public void ReadString(){} // RVA: 0x64A9850
        public void ReadBytes(){} // RVA: 0x64A9890
        public void ReadRawString(){} // RVA: 0x64A9910
        public void ReadStringSlow(){} // RVA: 0x64A9A90
        public void ValidateCurrentLimit(){} // RVA: 0x64A9F90
        public void ReadRawByte(){} // RVA: 0x64AA000
        public void IsDataAvailable(){} // RVA: 0x64AA070
        public void IsDataAvailableInSource(){} // RVA: 0x64AA090
        public void ReadRawBytesIntoSpan(){} // RVA: 0x64AA150
    }

    public class ParsingPrimitivesMessages : Object
    {
        public object ZeroLengthMessageStreamData;

        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x64AA360
        public void SkipGroup(){} // RVA: 0x64AA680
        public void ReadMessage(){} // RVA: 0x64AA820
        public void ReadMapEntry(){} // RVA: 0xA94080
        public void ReadGroup(){} // RVA: 0x64AA980
        public void ReadRawMessage(){} // RVA: 0x64AAA90
        public void CheckReadEndOfStreamTag(){} // RVA: 0x64AAC30
        public void CheckLastTagWas(){} // RVA: 0x64AAC70
        public void .cctor(){} // RVA: 0x64AACB0
    }

    public class ProtoPreconditions : Object
    {
        // ── Methods ──
        public void CheckNotNullUnconstrained(){} // RVA: 0x2996010
        public void CheckNotNull(){} // RVA: 0x2996010
    }

    public class RepeatedExtensionValue`1 : Object
    {
        public object field;
        public object codec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void CalculateSize(){} // RVA: 0x87C130
        public void Clone(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void MergeFrom(){} // RVA: 0x894320
        public void WriteTo(){} // RVA: 0x894320
        public void GetValue(){} // RVA: 0x87C0A0
    }

    public class RepeatedExtension`2 : Extension
    {
        public object codec;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x87C0A0
        public void get_IsRepeated(){} // RVA: 0x87D280
        public void CreateValue(){} // RVA: 0x87C0A0
    }

    public class SegmentedBufferHelper : ValueType
    {
        public object totalLength;
        public object readOnlySequenceEnumerator;
        public object codedInputStream;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x64AAE60
        public void RefillBuffer(){} // RVA: 0x7849C0
        public void get_TotalLength(){} // RVA: 0x77900
        public void get_CodedInputStream(){} // RVA: 0xA3290
        public void PushLimit(){} // RVA: 0x64AB1E0
        public void PopLimit(){} // RVA: 0x64AB280
        public void IsReachedLimit(){} // RVA: 0x64AB2B0
        public void IsAtEnd(){} // RVA: 0x64AB2D0
        public void RefillFromReadOnlySequence(){} // RVA: 0x7849F0
        public void RefillFromCodedInputStream(){} // RVA: 0x784A00
        public void RecomputeBufferSizeAfterLimit(){} // RVA: 0x64AB770
        public void CheckCurrentBufferIsEmpty(){} // RVA: 0x64AB7A0
    }

    public class UnknownField : Object
    {
        public object varintList;
        public object fixed32List;
        public object fixed64List;
        public object lengthDelimitedList;
        public object groupList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Equals(){} // RVA: 0x64AB810
        public void GetHashCode(){} // RVA: 0x64ABA80
        public void WriteTo(){} // RVA: 0x64ABB80
        public void GetSerializedSize(){} // RVA: 0x64AC460
        public void MergeFrom(){} // RVA: 0x64ACBE0
        public void AddAll(){} // RVA: 0x87C630
        public void AddVarint(){} // RVA: 0x64AD190
        public void AddFixed32(){} // RVA: 0x64AD230
        public void AddFixed64(){} // RVA: 0x64AD390
        public void AddLengthDelimited(){} // RVA: 0x64AD430
        public void AddGroup(){} // RVA: 0x64AD580
        public void Add(){} // RVA: 0xA94080
    }

    public class UnknownFieldSet : Object
    {
        public object fields;
        public object lastFieldNumber;
        public object lastField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64AD6D0
        public void HasField(){} // RVA: 0x64AD790
        public void WriteTo(){} // RVA: 0x64AD7F0
        public void CalculateSize(){} // RVA: 0x64ADA10
        public void Equals(){} // RVA: 0x64ADC30
        public void GetHashCode(){} // RVA: 0x64AE010
        public void GetOrAddField(){} // RVA: 0x64AE250
        public void AddOrReplaceField(){} // RVA: 0x64AE380
        public void MergeFieldFrom(){} // RVA: 0x64AEC40
        public void MergeGroupFrom(){} // RVA: 0x64AEBE0
        public void MergeFrom(){} // RVA: 0x64AF070
        public void MergeField(){} // RVA: 0x64AF0F0
        public void Clone(){} // RVA: 0x64AF210
    }

    public class UnknownFieldSet[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class WireFormat : Object
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x64AF290
        public void GetTagFieldNumber(){} // RVA: 0x64AF2A0
        public void MakeTag(){} // RVA: 0x64AF2B0
    }

    public class WriteBufferHelper : ValueType
    {
        public object bufferWriter;
        public object codedOutputStream;

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x77ED0
        public void Initialize(){} // RVA: 0x64AF2C0
        public void InitializeNonRefreshable(){} // RVA: 0x64AF370
        public void CheckNoSpaceLeft(){} // RVA: 0x64AF420
        public void GetSpaceLeft(){} // RVA: 0x64AF490
        public void RefreshBuffer(){} // RVA: 0x64AF510
        public void Flush(){} // RVA: 0x64AF650
    }

    public class WriteContext : ValueType
    {
        public object buffer;
        public object state;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x64AF780
        public void WriteDouble(){} // RVA: 0x784B90
        public void WriteFloat(){} // RVA: 0x784BA0
        public void WriteUInt64(){} // RVA: 0x784BB0
        public void WriteInt64(){} // RVA: 0x784BC0
        public void WriteInt32(){} // RVA: 0x784BD0
        public void WriteFixed64(){} // RVA: 0x784BE0
        public void WriteFixed32(){} // RVA: 0x784BF0
        public void WriteBool(){} // RVA: 0x784C00
        public void WriteString(){} // RVA: 0x784C10
        public void WriteMessage(){} // RVA: 0x784C20
        public void WriteBytes(){} // RVA: 0x784C30
        public void WriteUInt32(){} // RVA: 0x784C40
        public void WriteEnum(){} // RVA: 0x784C50
        public void WriteLength(){} // RVA: 0x784C60
        public void WriteTag(){} // RVA: 0x784C80
        public void WriteRawTag(){} // RVA: 0x784CA0
        public void CheckNoSpaceLeft(){} // RVA: 0x784CB0
        public void CopyStateTo(){} // RVA: 0x784CC0
        public void LoadStateFrom(){} // RVA: 0x784D30
    }

    public class WriterInternalState : ValueType
    {
        public object limit;
        public object position;
        public object writeBufferHelper;

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7E450
    }

    public class WritingPrimitives : Object
    {
        public object Utf8Encoding;

        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x64B0670
        public void WriteFloat(){} // RVA: 0x64B06E0
        public void WriteFloatSlowPath(){} // RVA: 0x64B0800
        public void WriteUInt64(){} // RVA: 0x64B0920
        public void WriteInt64(){} // RVA: 0x64B0990
        public void WriteInt32(){} // RVA: 0x64B0A00
        public void WriteFixed64(){} // RVA: 0x64B0AA0
        public void WriteFixed32(){} // RVA: 0x64B0B10
        public void WriteBool(){} // RVA: 0x64B0C80
        public void WriteString(){} // RVA: 0x64B0CF0
        public void WriteAsciiStringToBuffer(){} // RVA: 0x64B0FA0
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x64B1140
        public void WriteStringToBuffer(){} // RVA: 0x64B1160
        public void WriteBytes(){} // RVA: 0x64B12C0
        public void WriteUInt32(){} // RVA: 0x64B13D0
        public void WriteEnum(){} // RVA: 0x64B1440
        public void WriteLength(){} // RVA: 0x64B14B0
        public void WriteRawVarint32(){} // RVA: 0x64B1520
        public void WriteRawVarint64(){} // RVA: 0x64B16D0
        public void WriteRawLittleEndian32(){} // RVA: 0x64B1880
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x64B19B0
        public void WriteRawLittleEndian64(){} // RVA: 0x64B1A60
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x64B1B90
        public void WriteRawByte(){} // RVA: 0x64B1CA0
        public void WriteRawBytes(){} // RVA: 0x64B1DE0
        public void WriteTag(){} // RVA: 0x64B2190
        public void WriteRawTag(){} // RVA: 0x64B2270
        public void WriteRawTagSlowPath(){} // RVA: 0x64B2350
        public void .cctor(){} // RVA: 0x64B23E0
    }

    public class WritingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x64B2480
        public void WriteRawMessage(){} // RVA: 0x64B2530
        public void h(){} // RVA: 0xCFA58F8
    }

}