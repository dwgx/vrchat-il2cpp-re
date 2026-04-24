// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 95
// Methods: 140

namespace ThirdParty.Google.Google.Protobuf
{
    public class Extension : Object
    {
        // ── Original Methods ──
        public void get_TargetType(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void CreateValue(){} // RVA: 0x7ffaa86491d0
        public void get_FieldNumber(){} // RVA: 0x7ffaa897f5c0
        public void get_IsRepeated(){} // RVA: 0x7ffaa864a040
    }

    public class ExtensionSet : Object
    {
        // ── Original Methods ──
        public void TryGetValue(){} // RVA: 0x7ffaa864d8e0
        public void Has(){} // RVA: 0x7ffaa864a690
        public void Clear(){} // RVA: 0x7ffaa8660fc0
        public void Clear(){} // RVA: 0x7ffaa8660fc0
        public void TryMergeFieldFrom(){} // RVA: 0x7ffaa864a690
        public void MergeFrom(){} // RVA: 0x7ffaa8660fc0
        public void Clone(){} // RVA: 0x7ffaa86492c0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa8649330
        public void Get(){} // RVA: 0x7ffaa8649330
        public void GetOrInitialize(){} // RVA: 0x7ffaa8649330
        public void Set(){} // RVA: 0x7ffaa887e5c0
    }

    public class ExtensionSet`1 : Object
    {
        // ── Original Methods ──
        public void get_ValuesByNumber(){} // RVA: 0x7ffaa86491d0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void CalculateSize(){} // RVA: 0x7ffaa8649ca0
        public void WriteTo(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
    }

    public class ExtensionValue`1 : Object
    {
        public object `00; // 0x3024EA20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void CalculateSize(){} // RVA: 0x7ffaa8649ca0
        public void Clone(){} // RVA: 0x7ffaa86491d0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void MergeFrom(){} // RVA: 0x7ffaa8660d80
        public void MergeFrom(){} // RVA: 0x7ffaa8660d80
        public void WriteTo(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
        public void GetValue(){} // RVA: 0x7ffaa887e5c0
        public void SetValue(){} // RVA: 0x7ffaa887e5c0
    }

    public class Extension`2 : Extension
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8662f00
        public void get_DefaultValue(){} // RVA: 0x7ffaa887e5c0
        public void get_TargetType(){} // RVA: 0x7ffaa86491d0
        public void get_IsRepeated(){} // RVA: 0x7ffaa864a040
        public void CreateValue(){} // RVA: 0x7ffaa86491d0
    }

    public class FieldCodec : Object
    {
        // ── Original Methods ──
        public void ForString(){} // RVA: 0x7ffaadbdad70
        public void ForInt32(){} // RVA: 0x7ffaadbdb070
        public void ForUInt32(){} // RVA: 0x7ffaadbdb4f0
        public void ForFloat(){} // RVA: 0x7ffaadbdb970
        public void ForString(){} // RVA: 0x7ffaadbdad70
        public void ForInt32(){} // RVA: 0x7ffaadbdb070
        public void ForUInt32(){} // RVA: 0x7ffaadbdb4f0
        public void ForFloat(){} // RVA: 0x7ffaadbdb970
        public void ForMessage(){} // RVA: 0x7ffaa887e5c0
    }

    public class FieldCodec`1 : Object
    {
        public object TypeSupportsPacking; // 0x30B30570
        public object _valueSizeCalculator; // 0x30B30570, was: <ValueSizeCalculator>k__Backin
        public object _fieldMerger; // 0x30B30570, was: <FieldMerger>k__BackingField
        public object _endTag; // 0x30B30570, was: <EndTag>k__BackingField
        public object EqualityComparer; // 0x35D20858
        public object _packedRepeatedField; // 0x35D20858, was: <PackedRepeatedField>k__Backin
        public object _valueReader; // 0x35D20858, was: <ValueReader>k__BackingField

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void IsPackedRepeatedField(){} // RVA: 0x7ffaa864aae0
        public void get_PackedRepeatedField(){} // RVA: 0x7ffaa864a040
        public void get_ValueWriter(){} // RVA: 0x7ffaa86491d0
        public void get_ValueSizeCalculator(){} // RVA: 0x7ffaa86491d0
        public void get_ValueReader(){} // RVA: 0x7ffaa86491d0
        public void get_ValueMerger(){} // RVA: 0x7ffaa86491d0
        public void get_FieldMerger(){} // RVA: 0x7ffaa86491d0
        public void get_FixedSize(){} // RVA: 0x7ffaa8649ca0
        public void get_Tag(){} // RVA: 0x7ffaa8649ca0
        public void get_EndTag(){} // RVA: 0x7ffaa8649ca0
        public void get_DefaultValue(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void WriteTagAndValue(){} // RVA: 0x7ffaa887e5c0
        public void Read(){} // RVA: 0x7ffaa887e5c0
        public void Read(){} // RVA: 0x7ffaa887e5c0
        public void CalculateSizeWithTag(){} // RVA: 0x7ffaa887e5c0
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x7ffaa887e5c0
        public void IsDefault(){} // RVA: 0x7ffaa887e5c0
    }

    public class FieldCodec`1 : Object
    {
        public object TypeSupportsPacking; // 0x35D20858
        public object _valueSizeCalculator; // 0x35D20858, was: <ValueSizeCalculator>k__Backin
        public object _fieldMerger; // 0x35D20858, was: <FieldMerger>k__BackingField
        public object _endTag; // 0x35D20858, was: <EndTag>k__BackingField
        public object C8; // 0xE0031
        public object C8; // 0xE0021
    }

    public class FieldCodec`1 : Object
    {
        public object TypeSupportsPacking; // 0x35D23D60
        public object _valueSizeCalculator; // 0x35D23D60, was: <ValueSizeCalculator>k__Backin
        public object _fieldMerger; // 0x35D23D60, was: <FieldMerger>k__BackingField
        public object _endTag; // 0x35D23D60, was: <EndTag>k__BackingField
    }

    public class FieldCodec`1 : Object
    {
        public object TypeSupportsPacking; // 0x35D27028
        public object _valueSizeCalculator; // 0x35D27028, was: <ValueSizeCalculator>k__Backin
        public object _fieldMerger; // 0x35D27028, was: <FieldMerger>k__BackingField
        public object _endTag; // 0x35D27028, was: <EndTag>k__BackingField
        public object ā@; // 0x800C0031
        public object ā@; // 0x800C0021
    }

    public class IBufferMessage
    {
        // ── Original Methods ──
        public void InternalMergeFrom(){} // RVA: 0x7ffaa8660d80
        public void InternalWriteTo(){} // RVA: 0x7ffaa8660d80
    }

    public class IDeepCloneable`1
    {
        // ── Original Methods ──
        public void Clone(){} // RVA: 0x7ffaa887e5c0
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
        // ── Original Methods ──
        public void Clone(){} // RVA: 0x7ffaa86491d0
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
        // ── Original Methods ──
        public void Clone(){} // RVA: 0x7ffaa8649ca0
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
        // ── Original Methods ──
        public void Clone(){} // RVA: 0x7ffaa865dbc0
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IDeepCloneable`1
    {
    }

    public class IExtendableMessage`1
    {
        // ── Original Methods ──
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class IExtendableMessage`1
    {
    }

    public class IMessage
    {
        // ── Original Methods ──
        public void MergeFrom(){} // RVA: 0x7ffaa8660d80
        public void WriteTo(){} // RVA: 0x7ffaa8660d80
        public void CalculateSize(){} // RVA: 0x7ffaa8649ca0
        public void get_Descriptor(){} // RVA: 0x7ffaa86491d0
    }

    public class IMessage`1
    {
        // ── Original Methods ──
        public void MergeFrom(){} // RVA: 0x7ffaa887e5c0
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class IMessage`1
    {
    }

    public class MessageParser : Object
    {
        public object _extensions; // 0x30BD3A00, was: <Extensions>k__BackingField
        public object DiscardUnknownFields; // 0x1700002B

        // ── Original Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x7ffaa894d4e0
        public void get_Extensions(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaadbe5d80
        public void CreateTemplate(){} // RVA: 0x7ffaa976ee80
        public void ParseFrom(){} // RVA: 0x7ffaadbe5e40
    }

    public class MessageParser`1 : MessageParser
    {
        public object `00; // 0x84B35D08

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8666f10
        public void .ctor(){} // RVA: 0x7ffaa8666f10
        public void CreateTemplate(){} // RVA: 0x7ffaa887e5c0
        public void ParseFrom(){} // RVA: 0x7ffaa887e5c0
        public void ParseFrom(){} // RVA: 0x7ffaa887e5c0
        public void WithExtensionRegistry(){} // RVA: 0x7ffaa8649280
    }

    public class ObjectIntPair`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
    }

    public class ParsingPrimitivesMessages : Object
    {
        // ── Original Methods ──
        public void SkipLastField(){} // RVA: 0x7ffaadbe8a30
        public void SkipGroup(){} // RVA: 0x7ffaadbe8bf0
        public void ReadMessage(){} // RVA: 0x7ffaadbe8da0
        public void ReadMapEntry(){} // RVA: 0x7ffaa887e5c0
        public void ReadGroup(){} // RVA: 0x7ffaadbe8f00
        public void ReadRawMessage(){} // RVA: 0x7ffaadbe9010
        public void .cctor(){} // RVA: 0x7ffaadbe9230
        // ── Binary Analysis Named ──
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7ffaadbe91b0
        public void CheckLastTagWas(){} // RVA: 0x7ffaadbe91f0
    }

    public class ProtoPreconditions : Object
    {
        // ── Binary Analysis Named ──
        public void CheckNotNull(){} // RVA: 0x7ffaa887e5c0
        public void CheckNotNullUnconstrained(){} // RVA: 0x7ffaa887e5c0
    }

    public class RepeatedExtensionValue`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void CalculateSize(){} // RVA: 0x7ffaa8649ca0
        public void Clone(){} // RVA: 0x7ffaa86491d0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void MergeFrom(){} // RVA: 0x7ffaa8660d80
        public void MergeFrom(){} // RVA: 0x7ffaa8660d80
        public void WriteTo(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
        public void GetValue(){} // RVA: 0x7ffaa86491d0
    }

    public class RepeatedExtension`2 : Extension
    {
        // ── Original Methods ──
        public void get_TargetType(){} // RVA: 0x7ffaa86491d0
        public void get_IsRepeated(){} // RVA: 0x7ffaa864a040
        public void CreateValue(){} // RVA: 0x7ffaa86491d0
    }

    public class UnknownField : Object
    {
        public object fixed64List; // 0x31913E10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Equals(){} // RVA: 0x7ffaadbe9d80
        public void WriteTo(){} // RVA: 0x7ffaadbea0e0
        public void MergeFrom(){} // RVA: 0x7ffaadbeb190
        public void AddAll(){} // RVA: 0x7ffaa8649330
        public void AddVarint(){} // RVA: 0x7ffaadbeb740
        public void AddFixed32(){} // RVA: 0x7ffaadbeb7e0
        public void AddFixed64(){} // RVA: 0x7ffaadbeb940
        public void AddLengthDelimited(){} // RVA: 0x7ffaadbeb9e0
        public void AddGroup(){} // RVA: 0x7ffaadbeba80
        public void Add(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadbe9fe0
        public void GetSerializedSize(){} // RVA: 0x7ffaadbea9e0
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class ValueReader`1 : MulticastDelegate
    {
    }

    public class ValueReader`1 : MulticastDelegate
    {
    }

    public class ValueReader`1 : MulticastDelegate
    {
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class ValueWriter`1 : MulticastDelegate
    {
    }

    public class ValueWriter`1 : MulticastDelegate
    {
    }

    public class ValueWriter`1 : MulticastDelegate
    {
    }

}