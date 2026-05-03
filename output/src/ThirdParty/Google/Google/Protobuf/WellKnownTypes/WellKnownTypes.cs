// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.WellKnownTypes
// Classes: 22
// Methods: 388

namespace ThirdParty.Google.Google.Protobuf.WellKnownTypes
{
    public class Any : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Any> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string typeUrl_; // 0x18
        public Google.Protobuf.ByteString value_; // 0x20
        public object field_4; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86579880
        public void get_Descriptor(){} // RVA: 0x7FFE865798E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865799A0
        public void .ctor(){} // RVA: 0x7FFE86579B50 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86579D10
        public void get_TypeUrl(){} // RVA: 0x7FFE810FE7C0
        public void set_TypeUrl(){} // RVA: 0x7FFE86579F00
        public void get_Value(){} // RVA: 0x7FFE811290C0
        public void set_Value(){} // RVA: 0x7FFE8657A000
        public void Equals(){} // RVA: 0x7FFE8657A260 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657A380
        public void ToString(){} // RVA: 0x7FFE8657A450
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657A4D0
        public void CalculateSize(){} // RVA: 0x7FFE8657A590
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657A810
        public void GetTypeUrl(){} // RVA: 0x7FFE8657A8E0
        public void GetTypeName(){} // RVA: 0x7FFE8657A970
        public void Is(){} // RVA: 0x7FFE8657AA60
        public void Unpack(){} // RVA: 0x7FFE810A1420
        public void TryUnpack(){} // RVA: 0x7FFE80E2F3B0
        public void Pack(){} // RVA: 0x7FFE8657ABF0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8657AE10
    }

    public class AnyReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE865792F0
        public void .cctor(){} // RVA: 0x7FFE86579350
    }

    public class Duration : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Duration> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public long seconds_; // 0x18
        public int nanos_; // 0x20
        public object field_4; // 0x3E

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8657B630
        public void get_Descriptor(){} // RVA: 0x7FFE8657B690
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8657B750
        public void .ctor(){} // RVA: 0x7FFE8657B7A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8657B890
        public void get_Seconds(){} // RVA: 0x7FFE810FE7C0
        public void set_Seconds(){} // RVA: 0x7FFE819EA910
        public void get_Nanos(){} // RVA: 0x7FFE8151D690
        public void set_Nanos(){} // RVA: 0x7FFE8170B670
        public void Equals(){} // RVA: 0x7FFE8657BA70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657BAC0
        public void ToString(){} // RVA: 0x7FFE8657BB20
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657BB70
        public void CalculateSize(){} // RVA: 0x7FFE8657BBF0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657BDF0
        public void IsNormalized(){} // RVA: 0x7FFE8657BE90
        public void ToTimeSpan(){} // RVA: 0x7FFE8657BF40
        public void FromTimeSpan(){} // RVA: 0x7FFE8657C110
        public void op_UnaryNegation(){} // RVA: 0x7FFE8657C2B0
        public void op_Addition(){} // RVA: 0x7FFE8657C430
        public void op_Subtraction(){} // RVA: 0x7FFE8657C620
        public void Normalize(){} // RVA: 0x7FFE8657C810
        public void ToJson(){} // RVA: 0x7FFE8657C8B0
        public void ToDiagnosticString(){} // RVA: 0x7FFE8657CC20
        public void AppendNanoseconds(){} // RVA: 0x7FFE8657CC90
        public void .cctor(){} // RVA: 0x7FFE8657CED0
    }

    public class DurationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8657B070
        public void .cctor(){} // RVA: 0x7FFE8657B0D0
    }

    public class Empty : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Empty> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object field_2; // 0x44

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8657D640
        public void get_Descriptor(){} // RVA: 0x7FFE8657D6A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8657D760
        public void .ctor(){} // RVA: 0x7FFE8657D850 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8657D930
        public void Equals(){} // RVA: 0x7FFE8657DAE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657DB20
        public void ToString(){} // RVA: 0x7FFE8657DB60
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657DBB0
        public void CalculateSize(){} // RVA: 0x7FFE8657DBD0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657DCD0
        public void .cctor(){} // RVA: 0x7FFE8657DD90
    }

    public class EmptyReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8657D120
        public void .cctor(){} // RVA: 0x7FFE8657D180
    }

    public class Enum : Object
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
        public void get_Parser(){} // RVA: 0x7FFE8658DD00
        public void get_Descriptor(){} // RVA: 0x7FFE8658DD60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8658DE20
        public void .ctor(){} // RVA: 0x7FFE8658E0E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8658E3D0
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE8658E430
        public void get_Enumvalue(){} // RVA: 0x7FFE811290C0
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void get_SourceContext(){} // RVA: 0x7FFE8144E200
        public void set_SourceContext(){} // RVA: 0x7FFE81129890
        public void get_Syntax(){} // RVA: 0x7FFE81D46090
        public void set_Syntax(){} // RVA: 0x7FFE81D46A00
        public void Equals(){} // RVA: 0x7FFE8658E590 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8658E700
        public void ToString(){} // RVA: 0x7FFE8658E7F0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8658E840
        public void CalculateSize(){} // RVA: 0x7FFE8658E9B0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8658EDF0
        public void .cctor(){} // RVA: 0x7FFE8658F010
    }

    public class EnumValue : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.EnumValue> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public int number_; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8658F490
        public void get_Descriptor(){} // RVA: 0x7FFE8658F4F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8658F5B0
        public void .ctor(){} // RVA: 0x7FFE8658F7E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8658F9E0
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE8658FA40
        public void get_Number(){} // RVA: 0x7FFE8151D690
        public void set_Number(){} // RVA: 0x7FFE8170B670
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE8658FC90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8658FDA0
        public void ToString(){} // RVA: 0x7FFE8658FE40
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8658FE90
        public void CalculateSize(){} // RVA: 0x7FFE8658FFA0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86590230
        public void .cctor(){} // RVA: 0x7FFE86590380
    }

    public class Field : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Field> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public 0x66628E84 kind_; // 0x18
        public 0x66628EDC cardinality_; // 0x1C
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
        public void get_Parser(){} // RVA: 0x7FFE8658BFB0
        public void get_Descriptor(){} // RVA: 0x7FFE8658C010
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8658C0D0
        public void .ctor(){} // RVA: 0x7FFE8658C420 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8658C760
        public void get_Kind(){} // RVA: 0x7FFE813DB630
        public void set_Kind(){} // RVA: 0x7FFE8144DF00
        public void get_Cardinality(){} // RVA: 0x7FFE82707EE0
        public void set_Cardinality(){} // RVA: 0x7FFE82717690
        public void get_Number(){} // RVA: 0x7FFE8151D690
        public void set_Number(){} // RVA: 0x7FFE8170B670
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void set_Name(){} // RVA: 0x7FFE8658C7C0
        public void get_TypeUrl(){} // RVA: 0x7FFE8144E200
        public void set_TypeUrl(){} // RVA: 0x7FFE8658C8C0
        public void get_OneofIndex(){} // RVA: 0x7FFE81D46090
        public void set_OneofIndex(){} // RVA: 0x7FFE81D46A00
        public void get_Packed(){} // RVA: 0x7FFE812604E0
        public void set_Packed(){} // RVA: 0x7FFE812604F0
        public void get_Options(){} // RVA: 0x7FFE81178740
        public void get_JsonName(){} // RVA: 0x7FFE81176730
        public void set_JsonName(){} // RVA: 0x7FFE8658C9C0
        public void get_DefaultValue(){} // RVA: 0x7FFE8119C0E0
        public void set_DefaultValue(){} // RVA: 0x7FFE8658CAC0
        public void Equals(){} // RVA: 0x7FFE8658CC20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8658CE30
        public void ToString(){} // RVA: 0x7FFE8658CFB0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8658D000
        public void CalculateSize(){} // RVA: 0x7FFE8658D220
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8658D6E0
        public void .cctor(){} // RVA: 0x7FFE8658D980
    }

    public class FieldMask : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.FieldMask> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<string> _repeated_paths_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> paths_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8657E550
        public void get_Descriptor(){} // RVA: 0x7FFE8657E5B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8657E670
        public void .ctor(){} // RVA: 0x7FFE8657E780 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8657E920
        public void get_Paths(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8657EBF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE8657ED10
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657ED60
        public void CalculateSize(){} // RVA: 0x7FFE8657EE20
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657F010
        public void ToJson(){} // RVA: 0x7FFE8657F110
        public void ToDiagnosticString(){} // RVA: 0x7FFE8657F510
        public void FromString(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void FromStringEnumerable(){} // RVA: 0x7FFE80E2E3D0
        public void FromFieldNumbers(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void IsPathValid(){} // RVA: 0x7FFE8657F700
        public void IsValid(){} // RVA: 0x7FFE8657F950 | overloaded x4
        public void Normalize(){} // RVA: 0x7FFE8657FAF0
        public void Union(){} // RVA: 0x7FFE8657FB60
        public void Intersection(){} // RVA: 0x7FFE8657FC20
        public void Merge(){} // RVA: 0x7FFE86580080 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86580250
    }

    public class FieldMaskReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8657DFE0
        public void .cctor(){} // RVA: 0x7FFE8657E040
    }

    public class ListValue : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.ListValue> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Value> values_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86585CA0
        public void get_Descriptor(){} // RVA: 0x7FFE86585D00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86585DC0
        public void .ctor(){} // RVA: 0x7FFE86585ED0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86586070
        public void get_Values(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86586340 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE865863F0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86586440
        public void CalculateSize(){} // RVA: 0x7FFE86586500
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865866F0
        public void .cctor(){} // RVA: 0x7FFE865867F0
    }

    public class Option : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Option> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public Google.Protobuf.WellKnownTypes.Any value_; // 0x20
        public object field_4; // 0x92

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86590700
        public void get_Descriptor(){} // RVA: 0x7FFE86590760
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86590820
        public void .ctor(){} // RVA: 0x7FFE865909A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86590B70
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE86590BD0
        public void get_Value(){} // RVA: 0x7FFE811290C0
        public void set_Value(){} // RVA: 0x7FFE811290D0
        public void Equals(){} // RVA: 0x7FFE86590E10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86590F00
        public void ToString(){} // RVA: 0x7FFE86590F90
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86590FE0
        public void CalculateSize(){} // RVA: 0x7FFE86591070
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86591450
        public void .cctor(){} // RVA: 0x7FFE86591560
    }

    public class SourceContext : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.SourceContext> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string fileName_; // 0x18
        public object field_3; // 0x50

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86580BC0
        public void get_Descriptor(){} // RVA: 0x7FFE86580C20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86580CE0
        public void .ctor(){} // RVA: 0x7FFE86580E60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86580FC0
        public void get_FileName(){} // RVA: 0x7FFE810FE7C0
        public void set_FileName(){} // RVA: 0x7FFE86581150
        public void Equals(){} // RVA: 0x7FFE86581350 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86581400
        public void ToString(){} // RVA: 0x7FFE86581470
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865814C0
        public void CalculateSize(){} // RVA: 0x7FFE86581530
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865816C0
        public void .cctor(){} // RVA: 0x7FFE86581760
    }

    public class SourceContextReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86580630
        public void .cctor(){} // RVA: 0x7FFE86580690
    }

    public class Struct : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Struct> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Codec<string,Google.Protobuf.WellKnownTypes.Value> _map_fields_codec; // 0x8
        public Google.Protobuf.Collections.MapField`2<string,Google.Protobuf.WellKnownTypes.Value> fields_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86582550
        public void get_Descriptor(){} // RVA: 0x7FFE865825B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86582670
        public void .ctor(){} // RVA: 0x7FFE86582780 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86582920
        public void get_Fields(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86582BF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86582CA0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86582CF0
        public void CalculateSize(){} // RVA: 0x7FFE86582DB0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86582F80
        public void .cctor(){} // RVA: 0x7FFE86583080
    }

    public class StructReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE865819C0
        public void .cctor(){} // RVA: 0x7FFE86581A20
    }

    public class Timestamp : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Timestamp> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public long seconds_; // 0x18
        public int nanos_; // 0x20
        public System.DateTime UnixEpoch; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86587130
        public void get_Descriptor(){} // RVA: 0x7FFE86587190
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86587250
        public void .ctor(){} // RVA: 0x7FFE8657B7A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865872A0
        public void get_Seconds(){} // RVA: 0x7FFE810FE7C0
        public void set_Seconds(){} // RVA: 0x7FFE819EA910
        public void get_Nanos(){} // RVA: 0x7FFE8151D690
        public void set_Nanos(){} // RVA: 0x7FFE8170B670
        public void Equals(){} // RVA: 0x7FFE8657BA70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657BAC0
        public void ToString(){} // RVA: 0x7FFE86587480
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657BB70
        public void CalculateSize(){} // RVA: 0x7FFE865874D0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657BDF0
        public void IsNormalized(){} // RVA: 0x7FFE86587710
        public void op_Subtraction(){} // RVA: 0x7FFE86587B30 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFE86587930
        public void ToDateTime(){} // RVA: 0x7FFE86587D40
        public void ToDateTimeOffset(){} // RVA: 0x7FFE86587F00
        public void FromDateTime(){} // RVA: 0x7FFE86588130
        public void FromDateTimeOffset(){} // RVA: 0x7FFE86588360
        public void Normalize(){} // RVA: 0x7FFE86588420
        public void ToJson(){} // RVA: 0x7FFE865884B0
        public void CompareTo(){} // RVA: 0x7FFE86588850
        public void op_LessThan(){} // RVA: 0x7FFE865888F0
        public void op_GreaterThan(){} // RVA: 0x7FFE86588980
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE86588A30
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE86588AE0
        public void op_Equality(){} // RVA: 0x7FFE86588B70
        public void op_Inequality(){} // RVA: 0x7FFE86588BD0
        public void ToDiagnosticString(){} // RVA: 0x7FFE86588CB0
        public void .cctor(){} // RVA: 0x7FFE86588D20
    }

    public class TimestampReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86586B70
        public void .cctor(){} // RVA: 0x7FFE86586BD0
    }

    public class Type : Object
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
        public void get_Parser(){} // RVA: 0x7FFE8658A4E0
        public void get_Descriptor(){} // RVA: 0x7FFE8658A540
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8658A600
        public void .ctor(){} // RVA: 0x7FFE8658A950 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8658ACC0
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE8658AD20
        public void get_Fields(){} // RVA: 0x7FFE811290C0
        public void get_Oneofs(){} // RVA: 0x7FFE81129130
        public void get_Options(){} // RVA: 0x7FFE8144E200
        public void get_SourceContext(){} // RVA: 0x7FFE8143BA80
        public void set_SourceContext(){} // RVA: 0x7FFE81437330
        public void get_Syntax(){} // RVA: 0x7FFE8119C080
        public void set_Syntax(){} // RVA: 0x7FFE8119C090
        public void Equals(){} // RVA: 0x7FFE8658AE80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8658B030
        public void ToString(){} // RVA: 0x7FFE8658B150
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8658B1A0
        public void CalculateSize(){} // RVA: 0x7FFE8658B350
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8658B810
        public void .cctor(){} // RVA: 0x7FFE8658BA90
    }

    public class TypeReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86588FC0
        public void .cctor(){} // RVA: 0x7FFE86589020
    }

    public class Value : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Value> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object kind_; // 0x18
        public 0x66628A64 kindCase_; // 0x20
        public object field_4; // 0x59
        public object field_5; // 0x5A
        public object field_6; // 0x5B
        public object field_7; // 0x5C
        public object field_8; // 0x5D
        public object field_9; // 0x5E

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86583500
        public void get_Descriptor(){} // RVA: 0x7FFE86583560
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86583620
        public void .ctor(){} // RVA: 0x7FFE86583670 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86583900
        public void get_NullValue(){} // RVA: 0x7FFE86583960
        public void set_NullValue(){} // RVA: 0x7FFE865839D0
        public void get_NumberValue(){} // RVA: 0x7FFE86583A80
        public void set_NumberValue(){} // RVA: 0x7FFE86583B00
        public void get_StringValue(){} // RVA: 0x7FFE86583BB0
        public void set_StringValue(){} // RVA: 0x7FFE86583C30
        public void get_BoolValue(){} // RVA: 0x7FFE86583D30
        public void set_BoolValue(){} // RVA: 0x7FFE86583DB0
        public void get_StructValue(){} // RVA: 0x7FFE86583E60
        public void set_StructValue(){} // RVA: 0x7FFE86583EC0
        public void get_ListValue(){} // RVA: 0x7FFE86583F20
        public void set_ListValue(){} // RVA: 0x7FFE86583F80
        public void get_KindCase(){} // RVA: 0x7FFE8151D690
        public void ClearKind(){} // RVA: 0x7FFE86583FE0
        public void Equals(){} // RVA: 0x7FFE865840A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865842D0
        public void ToString(){} // RVA: 0x7FFE86584500
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86584550
        public void CalculateSize(){} // RVA: 0x7FFE86584720
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86584D30
        public void ForString(){} // RVA: 0x7FFE86585030
        public void ForNumber(){} // RVA: 0x7FFE86585110
        public void ForBool(){} // RVA: 0x7FFE86585180
        public void ForNull(){} // RVA: 0x7FFE865851F0
        public void ForList(){} // RVA: 0x7FFE86585250
        public void ForStruct(){} // RVA: 0x7FFE865853F0
        public void .cctor(){} // RVA: 0x7FFE86585520
    }

}