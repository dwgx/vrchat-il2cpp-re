// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 22
// Methods: 137

namespace ThirdParty.Google.Google.Protobuf
{
    public class Extension : Object
    {
        public object TargetType;
        public object FieldNumber;
        public object IsRepeated;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
        public void CreateValue(){} // RVA: 0x7FFD4E078E90
        public void get_FieldNumber(){} // RVA: 0x7FFD4E38E5C0
        public void get_IsRepeated(){} // RVA: 0x7FFD4E079D00
    }

    public class ExtensionSet : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFD4E07D5A0
        public void Get(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void GetOrInitialize(){} // RVA: 0x7FFD4E078FF0
        public void Set(){} // RVA: 0x7FFD4E2ADC40
        public void Has(){} // RVA: 0x7FFD4E07A350
        public void Clear(){} // RVA: 0x7FFD4E090C80 | overloaded x2
        public void TryMergeFieldFrom(){} // RVA: 0x7FFD4E07A350
        public void MergeFrom(){} // RVA: 0x7FFD4E090C80
        public void Clone(){} // RVA: 0x7FFD4E078F80
    }

    public class ExtensionSet`1 : Object
    {
        public object ValuesByNumber;

        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0x7FFD4E078E90
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void CalculateSize(){} // RVA: 0x7FFD4E079960
        public void WriteTo(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ExtensionValue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void CalculateSize(){} // RVA: 0x7FFD4E079960
        public void Clone(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void MergeFrom(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFD4E090A40
        public void GetValue(){} // RVA: 0x7FFD4E2ADC40
        public void SetValue(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Extension`2 : Extension
    {
        public object DefaultValue;
        public object TargetType;
        public object IsRepeated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0
        public void get_DefaultValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_TargetType(){} // RVA: 0x7FFD4E078E90
        public void get_IsRepeated(){} // RVA: 0x7FFD4E079D00
        public void CreateValue(){} // RVA: 0x7FFD4E078E90
    }

    public class FieldCodec : Object
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x7FFD535D9BC0 | overloaded x2
        public void ForInt32(){} // RVA: 0x7FFD535D9EC0 | overloaded x2
        public void ForUInt32(){} // RVA: 0x7FFD535DA340 | overloaded x2
        public void ForFloat(){} // RVA: 0x7FFD535DA7C0 | overloaded x2
        public void ForMessage(){} // RVA: 0x7FFD4E2ADC40
    }

    public class FieldCodec`1 : Object
    {
        public object PackedRepeatedField;
        public object ValueWriter;
        public object ValueSizeCalculator;
        public object ValueReader;
        public object ValueMerger;
        public object FieldMerger;
        public object FixedSize;
        public object Tag;
        public object EndTag;
        public object DefaultValue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void IsPackedRepeatedField(){} // RVA: 0x7FFD4E07A7A0
        public void get_PackedRepeatedField(){} // RVA: 0x7FFD4E079D00
        public void get_ValueWriter(){} // RVA: 0x7FFD4E078E90
        public void get_ValueSizeCalculator(){} // RVA: 0x7FFD4E078E90
        public void get_ValueReader(){} // RVA: 0x7FFD4E078E90
        public void get_ValueMerger(){} // RVA: 0x7FFD4E078E90
        public void get_FieldMerger(){} // RVA: 0x7FFD4E078E90
        public void get_FixedSize(){} // RVA: 0x7FFD4E079960
        public void get_Tag(){} // RVA: 0x7FFD4E079960
        public void get_EndTag(){} // RVA: 0x7FFD4E079960
        public void get_DefaultValue(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void WriteTagAndValue(){} // RVA: 0x7FFD4E2ADC40
        public void Read(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CalculateSizeWithTag(){} // RVA: 0x7FFD4E2ADC40
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x7FFD4E2ADC40
        public void IsDefault(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IBufferMessage
    {
        // ── Methods ──
        public void InternalMergeFrom(){} // RVA: 0x7FFD4E090A40
        public void InternalWriteTo(){} // RVA: 0x7FFD4E090A40
    }

    public class IDeepCloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IExtendableMessage`1
    {
        // ── Methods ──
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40
    }

    public class IMessage
    {
        public object Descriptor;

        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFD4E090A40
        public void WriteTo(){} // RVA: 0x7FFD4E090A40
        public void CalculateSize(){} // RVA: 0x7FFD4E079960
        public void get_Descriptor(){} // RVA: 0x7FFD4E078E90
    }

    public class IMessage`1
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x7FFD4E2ADC40
    }

    public class MessageParser : Object
    {
        public object DiscardUnknownFields;
        public object Extensions;

        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFD4E35C4E0
        public void get_Extensions(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD535E4BD0
        public void CreateTemplate(){} // RVA: 0x7FFD4F15B830
        public void ParseFrom(){} // RVA: 0x7FFD535E4C90
    }

    public class MessageParser`1 : MessageParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E096BD0 | overloaded x2
        public void CreateTemplate(){} // RVA: 0x7FFD4E2ADC40
        public void ParseFrom(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void WithExtensionRegistry(){} // RVA: 0x7FFD4E078F40
    }

    public class ObjectIntPair`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
    }

    public class ParsingPrimitivesMessages : Object
    {
        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x7FFD535E7880
        public void SkipGroup(){} // RVA: 0x7FFD535E7A40
        public void ReadMessage(){} // RVA: 0x7FFD535E7BF0
        public void ReadMapEntry(){} // RVA: 0x7FFD4E2ADC40
        public void ReadGroup(){} // RVA: 0x7FFD535E7D50
        public void ReadRawMessage(){} // RVA: 0x7FFD535E7E60
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFD535E8000
        public void CheckLastTagWas(){} // RVA: 0x7FFD535E8040
        public void .cctor(){} // RVA: 0x7FFD535E8080
    }

    public class ProtoPreconditions : Object
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x7FFD4E2ADC40
        public void CheckNotNullUnconstrained(){} // RVA: 0x7FFD4E2ADC40
    }

    public class RepeatedExtensionValue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void CalculateSize(){} // RVA: 0x7FFD4E079960
        public void Clone(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void MergeFrom(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFD4E090A40
        public void GetValue(){} // RVA: 0x7FFD4E078E90
    }

    public class RepeatedExtension`2 : Extension
    {
        public object TargetType;
        public object IsRepeated;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFD4E078E90
        public void get_IsRepeated(){} // RVA: 0x7FFD4E079D00
        public void CreateValue(){} // RVA: 0x7FFD4E078E90
    }

    public class UnknownField : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD535E8BD0
        public void GetHashCode(){} // RVA: 0x7FFD535E8E30
        public void WriteTo(){} // RVA: 0x7FFD535E8F30
        public void GetSerializedSize(){} // RVA: 0x7FFD535E9830
        public void MergeFrom(){} // RVA: 0x7FFD535E9FE0
        public void AddAll(){} // RVA: 0x7FFD4E078FF0
        public void AddVarint(){} // RVA: 0x7FFD535EA590
        public void AddFixed32(){} // RVA: 0x7FFD535EA630
        public void AddFixed64(){} // RVA: 0x7FFD535EA790
        public void AddLengthDelimited(){} // RVA: 0x7FFD535EA830
        public void AddGroup(){} // RVA: 0x7FFD535EA8D0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ValueReader`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ValueWriter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

}