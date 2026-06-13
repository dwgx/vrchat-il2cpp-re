// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.WellKnownTypes
// Classes: 22
// Methods: 388

namespace ThirdParty.Google.Google.Protobuf.WellKnownTypes
{
    public class Any
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Any> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string typeUrl_; // 0x18
        public Google.Protobuf.ByteString value_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A38B20
        public void get_Descriptor(){} // RVA: 0x5A38B80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A38C40
        public void .ctor(){} // RVA: 0x5A38DF0 | overloaded x2
        public void Clone(){} // RVA: 0x5A38FB0
        public void get_TypeUrl(){} // RVA: 0x2E07C0
        public void set_TypeUrl(){} // RVA: 0x5A391A0
        public void get_Value(){} // RVA: 0x30B0C0
        public void set_Value(){} // RVA: 0x5A392A0
        public void Equals(){} // RVA: 0x5A39500 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A39620
        public void ToString(){} // RVA: 0x5A396F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A39770
        public void CalculateSize(){} // RVA: 0x5A39830
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A39AB0
        public void GetTypeUrl(){} // RVA: 0x5A39B80
        public void GetTypeName(){} // RVA: 0x5A39C10
        public void Is(){} // RVA: 0x5A39D00
        public void Unpack(){} // RVA: 0x283FA0
        public void TryUnpack(){} // RVA: 0xDE40
        public void Pack(){} // RVA: 0x5A39E90 | overloaded x2
        public void .cctor(){} // RVA: 0x5A3A0B0
    }

    public class AnyReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A38590
        public void .cctor(){} // RVA: 0x5A385F0
    }

    public class Duration
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Duration> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public long seconds_; // 0x18
        public int nanos_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A3A8D0
        public void get_Descriptor(){} // RVA: 0x5A3A930
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A3A9F0
        public void .ctor(){} // RVA: 0x5A3AA40 | overloaded x2
        public void Clone(){} // RVA: 0x5A3AB30
        public void get_Seconds(){} // RVA: 0x2E07C0
        public void set_Seconds(){} // RVA: 0xC5BE60
        public void get_Nanos(){} // RVA: 0x760030
        public void set_Nanos(){} // RVA: 0x99E0D0
        public void Equals(){} // RVA: 0x5A3AD10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3AD60
        public void ToString(){} // RVA: 0x5A3ADC0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3AE10
        public void CalculateSize(){} // RVA: 0x5A3AE90
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3B090
        public void IsNormalized(){} // RVA: 0x5A3B130
        public void ToTimeSpan(){} // RVA: 0x5A3B1E0
        public void FromTimeSpan(){} // RVA: 0x5A3B3B0
        public void op_UnaryNegation(){} // RVA: 0x5A3B550
        public void op_Addition(){} // RVA: 0x5A3B6D0
        public void op_Subtraction(){} // RVA: 0x5A3B8C0
        public void Normalize(){} // RVA: 0x5A3BAB0
        public void ToJson(){} // RVA: 0x5A3BB50
        public void ToDiagnosticString(){} // RVA: 0x5A3BEC0
        public void AppendNanoseconds(){} // RVA: 0x5A3BF30
        public void .cctor(){} // RVA: 0x5A3C170
    }

    public class DurationReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A3A310
        public void .cctor(){} // RVA: 0x5A3A370
    }

    public class Empty
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Empty> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A3C8E0
        public void get_Descriptor(){} // RVA: 0x5A3C940
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A3CA00
        public void .ctor(){} // RVA: 0x5A3CAF0 | overloaded x2
        public void Clone(){} // RVA: 0x5A3CBD0
        public void Equals(){} // RVA: 0x5A3CD80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3CDC0
        public void ToString(){} // RVA: 0x5A3CE00
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3CE50
        public void CalculateSize(){} // RVA: 0x5A3CE70
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3CF70
        public void .cctor(){} // RVA: 0x5A3D030
    }

    public class EmptyReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A3C3C0
        public void .cctor(){} // RVA: 0x5A3C420
    }

    public class Enum
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Enum> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.EnumValue> _repeated_enumvalue_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.EnumValue> enumvalue_; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
        public Google.Protobuf.WellKnownTypes.SourceContext sourceContext_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A4CFA0
        public void get_Descriptor(){} // RVA: 0x5A4D000
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A4D0C0
        public void .ctor(){} // RVA: 0x5A4D380 | overloaded x2
        public void Clone(){} // RVA: 0x5A4D670
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x5A4D6D0
        public void get_Enumvalue(){} // RVA: 0x30B0C0
        public void get_Options(){} // RVA: 0x30B130
        public void get_SourceContext(){} // RVA: 0x6374D0
        public void set_SourceContext(){} // RVA: 0x30B890
        public void get_Syntax(){} // RVA: 0xFDC9F0
        public void set_Syntax(){} // RVA: 0xFDD6E0
        public void Equals(){} // RVA: 0x5A4D830 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A4D9A0
        public void ToString(){} // RVA: 0x5A4DA90
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A4DAE0
        public void CalculateSize(){} // RVA: 0x5A4DC50
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A4E090
        public void .cctor(){} // RVA: 0x5A4E2B0
    }

    public class EnumValue
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.EnumValue> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public int number_; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A4E730
        public void get_Descriptor(){} // RVA: 0x5A4E790
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A4E850
        public void .ctor(){} // RVA: 0x5A4EA80 | overloaded x2
        public void Clone(){} // RVA: 0x5A4EC80
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x5A4ECE0
        public void get_Number(){} // RVA: 0x760030
        public void set_Number(){} // RVA: 0x99E0D0
        public void get_Options(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x5A4EF30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A4F040
        public void ToString(){} // RVA: 0x5A4F0E0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A4F130
        public void CalculateSize(){} // RVA: 0x5A4F240
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A4F4D0
        public void .cctor(){} // RVA: 0x5A4F620
    }

    public class Field
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Field> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public 0x6594F6B8 kind_; // 0x18
        public 0x6594F710 cardinality_; // 0x1C
        public int number_; // 0x20
        public string name_; // 0x28
        public string typeUrl_; // 0x30
        public int oneofIndex_; // 0x38
        public bool packed_; // 0x3C
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
        public string jsonName_; // 0x48
        public string defaultValue_; // 0x50

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A4B250
        public void get_Descriptor(){} // RVA: 0x5A4B2B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A4B370
        public void .ctor(){} // RVA: 0x5A4B6C0 | overloaded x2
        public void Clone(){} // RVA: 0x5A4BA00
        public void get_Kind(){} // RVA: 0x5BED50
        public void set_Kind(){} // RVA: 0x6374E0
        public void get_Cardinality(){} // RVA: 0x197C3B0
        public void set_Cardinality(){} // RVA: 0x1989FD0
        public void get_Number(){} // RVA: 0x760030
        public void set_Number(){} // RVA: 0x99E0D0
        public void get_Name(){} // RVA: 0x30B130
        public void set_Name(){} // RVA: 0x5A4BA60
        public void get_TypeUrl(){} // RVA: 0x6374D0
        public void set_TypeUrl(){} // RVA: 0x5A4BB60
        public void get_OneofIndex(){} // RVA: 0xFDC9F0
        public void set_OneofIndex(){} // RVA: 0xFDD6E0
        public void get_Packed(){} // RVA: 0x4424E0
        public void set_Packed(){} // RVA: 0x4424F0
        public void get_Options(){} // RVA: 0x35A740
        public void get_JsonName(){} // RVA: 0x358730
        public void set_JsonName(){} // RVA: 0x5A4BC60
        public void get_DefaultValue(){} // RVA: 0x37E0E0
        public void set_DefaultValue(){} // RVA: 0x5A4BD60
        public void Equals(){} // RVA: 0x5A4BEC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A4C0D0
        public void ToString(){} // RVA: 0x5A4C250
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A4C2A0
        public void CalculateSize(){} // RVA: 0x5A4C4C0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A4C980
        public void .cctor(){} // RVA: 0x5A4CC20
    }

    public class FieldMask
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.FieldMask> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<string> _repeated_paths_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> paths_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A3D7F0
        public void get_Descriptor(){} // RVA: 0x5A3D850
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A3D910
        public void .ctor(){} // RVA: 0x5A3DA20 | overloaded x2
        public void Clone(){} // RVA: 0x5A3DBC0
        public void get_Paths(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5A3DE90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5A3DFB0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3E000
        public void CalculateSize(){} // RVA: 0x5A3E0C0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3E2B0
        public void ToJson(){} // RVA: 0x5A3E3B0
        public void ToDiagnosticString(){} // RVA: 0x5A3E7B0
        public void FromString(){} // RVA: 0xCE50 | overloaded x2
        public void FromStringEnumerable(){} // RVA: 0xCE50
        public void FromFieldNumbers(){} // RVA: 0xCE50 | overloaded x2
        public void IsPathValid(){} // RVA: 0x5A3E9A0
        public void IsValid(){} // RVA: 0x5A3EBF0 | overloaded x4
        public void Normalize(){} // RVA: 0x5A3ED90
        public void Union(){} // RVA: 0x5A3EE00
        public void Intersection(){} // RVA: 0x5A3EEC0
        public void Merge(){} // RVA: 0x5A3F320 | overloaded x2
        public void .cctor(){} // RVA: 0x5A3F4F0
    }

    public class FieldMaskReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor ReplaceMessageFields;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A3D280
        public void .cctor(){} // RVA: 0x5A3D2E0
    }

    public class ListValue
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.ListValue> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Value> values_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A44F40
        public void get_Descriptor(){} // RVA: 0x5A44FA0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A45060
        public void .ctor(){} // RVA: 0x5A45170 | overloaded x2
        public void Clone(){} // RVA: 0x5A45310
        public void get_Values(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5A455E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5A45690
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A456E0
        public void CalculateSize(){} // RVA: 0x5A457A0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A45990
        public void .cctor(){} // RVA: 0x5A45A90
    }

    public class Option
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Option> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public Google.Protobuf.WellKnownTypes.Any value_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A4F9A0
        public void get_Descriptor(){} // RVA: 0x5A4FA00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A4FAC0
        public void .ctor(){} // RVA: 0x5A4FC40 | overloaded x2
        public void Clone(){} // RVA: 0x5A4FE10
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x5A4FE70
        public void get_Value(){} // RVA: 0x30B0C0
        public void set_Value(){} // RVA: 0x30B0D0
        public void Equals(){} // RVA: 0x5A500B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A501A0
        public void ToString(){} // RVA: 0x5A50230
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A50280
        public void CalculateSize(){} // RVA: 0x5A50310
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A506F0
        public void .cctor(){} // RVA: 0x5A50800
    }

    public class SourceContext
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.SourceContext> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string fileName_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A3FE60
        public void get_Descriptor(){} // RVA: 0x5A3FEC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A3FF80
        public void .ctor(){} // RVA: 0x5A40100 | overloaded x2
        public void Clone(){} // RVA: 0x5A40260
        public void get_FileName(){} // RVA: 0x2E07C0
        public void set_FileName(){} // RVA: 0x5A403F0
        public void Equals(){} // RVA: 0x5A405F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A406A0
        public void ToString(){} // RVA: 0x5A40710
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A40760
        public void CalculateSize(){} // RVA: 0x5A407D0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A40960
        public void .cctor(){} // RVA: 0x5A40A00
    }

    public class SourceContextReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A3F8D0
        public void .cctor(){} // RVA: 0x5A3F930
    }

    public class Struct
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Struct> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Codec<string,Google.Protobuf.WellKnownTypes.Value> _map_fields_codec; // 0x8
        public Google.Protobuf.Collections.MapField`2<string,Google.Protobuf.WellKnownTypes.Value> fields_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A417F0
        public void get_Descriptor(){} // RVA: 0x5A41850
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A41910
        public void .ctor(){} // RVA: 0x5A41A20 | overloaded x2
        public void Clone(){} // RVA: 0x5A41BC0
        public void get_Fields(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5A41E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5A41F40
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A41F90
        public void CalculateSize(){} // RVA: 0x5A42050
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A42220
        public void .cctor(){} // RVA: 0x5A42320
    }

    public class StructReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A40C60
        public void .cctor(){} // RVA: 0x5A40CC0
    }

    public class Timestamp : Google.Protobuf
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Timestamp> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public long seconds_; // 0x18
        public int nanos_; // 0x20
        public System.DateTime UnixEpoch; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A463D0
        public void get_Descriptor(){} // RVA: 0x5A46430
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A464F0
        public void .ctor(){} // RVA: 0x5A3AA40 | overloaded x2
        public void Clone(){} // RVA: 0x5A46540
        public void get_Seconds(){} // RVA: 0x2E07C0
        public void set_Seconds(){} // RVA: 0xC5BE60
        public void get_Nanos(){} // RVA: 0x760030
        public void set_Nanos(){} // RVA: 0x99E0D0
        public void Equals(){} // RVA: 0x5A3AD10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3AD60
        public void ToString(){} // RVA: 0x5A46720
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3AE10
        public void CalculateSize(){} // RVA: 0x5A46770
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3B090
        public void IsNormalized(){} // RVA: 0x5A469B0
        public void op_Subtraction(){} // RVA: 0x5A46DD0 | overloaded x2
        public void op_Addition(){} // RVA: 0x5A46BD0
        public void ToDateTime(){} // RVA: 0x5A46FE0
        public void ToDateTimeOffset(){} // RVA: 0x5A471A0
        public void FromDateTime(){} // RVA: 0x5A473D0
        public void FromDateTimeOffset(){} // RVA: 0x5A47600
        public void Normalize(){} // RVA: 0x5A476C0
        public void ToJson(){} // RVA: 0x5A47750
        public void CompareTo(){} // RVA: 0x5A47AF0
        public void op_LessThan(){} // RVA: 0x5A47B90
        public void op_GreaterThan(){} // RVA: 0x5A47C20
        public void op_LessThanOrEqual(){} // RVA: 0x5A47CD0
        public void op_GreaterThanOrEqual(){} // RVA: 0x5A47D80
        public void op_Equality(){} // RVA: 0x5A47E10
        public void op_Inequality(){} // RVA: 0x5A47E70
        public void ToDiagnosticString(){} // RVA: 0x5A47F50
        public void .cctor(){} // RVA: 0x5A47FC0
    }

    public class TimestampReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A45E10
        public void .cctor(){} // RVA: 0x5A45E70
    }

    public class Type
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Type> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Field> fields_; // 0x20
        public Google.Protobuf.FieldCodec`1<string> _repeated_oneofs_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> oneofs_; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> options_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A49780
        public void get_Descriptor(){} // RVA: 0x5A497E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A498A0
        public void .ctor(){} // RVA: 0x5A49BF0 | overloaded x2
        public void Clone(){} // RVA: 0x5A49F60
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x5A49FC0
        public void get_Fields(){} // RVA: 0x30B0C0
        public void get_Oneofs(){} // RVA: 0x30B130
        public void get_Options(){} // RVA: 0x6374D0
        public void get_SourceContext(){} // RVA: 0x4976A0
        public void set_SourceContext(){} // RVA: 0x49B830
        public void get_Syntax(){} // RVA: 0x37E080
        public void set_Syntax(){} // RVA: 0x37E090
        public void Equals(){} // RVA: 0x5A4A120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A4A2D0
        public void ToString(){} // RVA: 0x5A4A3F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A4A440
        public void CalculateSize(){} // RVA: 0x5A4A5F0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A4AAB0
        public void .cctor(){} // RVA: 0x5A4AD30
    }

    public class TypeReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A48260
        public void .cctor(){} // RVA: 0x5A482C0
    }

    public class Value
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Value> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object kind_; // 0x18
        public 0x6594F298 kindCase_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A427A0
        public void get_Descriptor(){} // RVA: 0x5A42800
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A428C0
        public void .ctor(){} // RVA: 0x5A42910 | overloaded x2
        public void Clone(){} // RVA: 0x5A42BA0
        public void get_NullValue(){} // RVA: 0x5A42C00
        public void set_NullValue(){} // RVA: 0x5A42C70
        public void get_NumberValue(){} // RVA: 0x5A42D20
        public void set_NumberValue(){} // RVA: 0x5A42DA0
        public void get_StringValue(){} // RVA: 0x5A42E50
        public void set_StringValue(){} // RVA: 0x5A42ED0
        public void get_BoolValue(){} // RVA: 0x5A42FD0
        public void set_BoolValue(){} // RVA: 0x5A43050
        public void get_StructValue(){} // RVA: 0x5A43100
        public void set_StructValue(){} // RVA: 0x5A43160
        public void get_ListValue(){} // RVA: 0x5A431C0
        public void set_ListValue(){} // RVA: 0x5A43220
        public void get_KindCase(){} // RVA: 0x760030
        public void ClearKind(){} // RVA: 0x5A43280
        public void Equals(){} // RVA: 0x5A43340 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A43570
        public void ToString(){} // RVA: 0x5A437A0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A437F0
        public void CalculateSize(){} // RVA: 0x5A439C0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A43FD0
        public void ForString(){} // RVA: 0x5A442D0
        public void ForNumber(){} // RVA: 0x5A443B0
        public void ForBool(){} // RVA: 0x5A44420
        public void ForNull(){} // RVA: 0x5A44490
        public void ForList(){} // RVA: 0x5A444F0
        public void ForStruct(){} // RVA: 0x5A44690
        public void .cctor(){} // RVA: 0x5A447C0
    }

}