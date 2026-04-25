// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.WellKnownTypes
// Classes: 22
// Methods: 388

namespace ThirdParty.Google.Google.Protobuf.WellKnownTypes
{
    public class Any : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Any> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Google.Protobuf.ByteString TypeUrl; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81CFF40
        public void get_Descriptor(){} // RVA: 0x7FFAC81CFFA0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D0060
        public void .ctor(){} // RVA: 0x7FFAC81D0210 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D03D0
        public void get_TypeUrl(){} // RVA: 0x7FFAC2F247C0
        public void set_TypeUrl(){} // RVA: 0x7FFAC81D05C0
        public void get_Value(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Value(){} // RVA: 0x7FFAC81D06C0
        public void Equals(){} // RVA: 0x7FFAC81D0920 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D0A40
        public void ToString(){} // RVA: 0x7FFAC81D0B10
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D0B90
        public void CalculateSize(){} // RVA: 0x7FFAC81D0C50
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D0ED0
        public void GetTypeUrl(){} // RVA: 0x7FFAC81D0FA0
        public void GetTypeName(){} // RVA: 0x7FFAC81D1030
        public void Is(){} // RVA: 0x7FFAC81D1120
        public void Unpack(){} // RVA: 0x7FFAC2E8DC40
        public void TryUnpack(){} // RVA: 0x7FFAC2C59F60
        public void Pack(){} // RVA: 0x7FFAC81D12B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC81D14D0
    }

    public class AnyReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81CF9B0
        public void .cctor(){} // RVA: 0x7FFAC81CFA10
    }

    public class Duration : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Duration> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public long pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Seconds; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81D1CF0
        public void get_Descriptor(){} // RVA: 0x7FFAC81D1D50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D1E10
        public void .ctor(){} // RVA: 0x7FFAC81D1E60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D1F50
        public void get_Seconds(){} // RVA: 0x7FFAC2F247C0
        public void set_Seconds(){} // RVA: 0x7FFAC38920D0
        public void get_Nanos(){} // RVA: 0x7FFAC30DBBE0
        public void set_Nanos(){} // RVA: 0x7FFAC35DB7A0
        public void Equals(){} // RVA: 0x7FFAC81D2130 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D2180
        public void ToString(){} // RVA: 0x7FFAC81D21E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D2230
        public void CalculateSize(){} // RVA: 0x7FFAC81D22B0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D24B0
        public void IsNormalized(){} // RVA: 0x7FFAC81D2550
        public void ToTimeSpan(){} // RVA: 0x7FFAC81D2600
        public void FromTimeSpan(){} // RVA: 0x7FFAC81D27D0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC81D2970
        public void op_Addition(){} // RVA: 0x7FFAC81D2AF0
        public void op_Subtraction(){} // RVA: 0x7FFAC81D2CE0
        public void Normalize(){} // RVA: 0x7FFAC81D2ED0
        public void ToJson(){} // RVA: 0x7FFAC81D2F70
        public void ToDiagnosticString(){} // RVA: 0x7FFAC81D32E0
        public void AppendNanoseconds(){} // RVA: 0x7FFAC81D3350
        public void .cctor(){} // RVA: 0x7FFAC81D3590
    }

    public class DurationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81D1730
        public void .cctor(){} // RVA: 0x7FFAC81D1790
    }

    public class Empty : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Empty> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81D3D00
        public void get_Descriptor(){} // RVA: 0x7FFAC81D3D60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D3E20
        public void .ctor(){} // RVA: 0x7FFAC81D3F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D3FF0
        public void Equals(){} // RVA: 0x7FFAC81D41A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D41E0
        public void ToString(){} // RVA: 0x7FFAC81D4220
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D4270
        public void CalculateSize(){} // RVA: 0x7FFAC81D4290
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D4390
        public void .cctor(){} // RVA: 0x7FFAC81D4450
    }

    public class EmptyReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81D37E0
        public void .cctor(){} // RVA: 0x7FFAC81D3840
    }

    public class Enum : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Enum> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.EnumValue> Name; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.EnumValue> Enumvalue; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> Options; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> SourceContext; // 0x28
        public Google.Protobuf.WellKnownTypes.SourceContext Syntax; // 0x30
        public 0x6B22F4B8 syntax_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81E43C0
        public void get_Descriptor(){} // RVA: 0x7FFAC81E4420
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81E44E0
        public void .ctor(){} // RVA: 0x7FFAC81E47A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81E4A90
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC81E4AF0
        public void get_Enumvalue(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void get_SourceContext(){} // RVA: 0x7FFAC31D95E0
        public void set_SourceContext(){} // RVA: 0x7FFAC2F4F890
        public void get_Syntax(){} // RVA: 0x7FFAC358A870
        public void set_Syntax(){} // RVA: 0x7FFAC3588350
        public void Equals(){} // RVA: 0x7FFAC81E4C50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81E4DC0
        public void ToString(){} // RVA: 0x7FFAC81E4EB0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81E4F00
        public void CalculateSize(){} // RVA: 0x7FFAC81E5070
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81E54B0
        public void .cctor(){} // RVA: 0x7FFAC81E56D0
    }

    public class EnumValue : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.EnumValue> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Name; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> Number; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> Options; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81E5B50
        public void get_Descriptor(){} // RVA: 0x7FFAC81E5BB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81E5C70
        public void .ctor(){} // RVA: 0x7FFAC81E5EA0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81E60A0
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC81E6100
        public void get_Number(){} // RVA: 0x7FFAC30DBBE0
        public void set_Number(){} // RVA: 0x7FFAC35DB7A0
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC81E6350 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81E6460
        public void ToString(){} // RVA: 0x7FFAC81E6500
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81E6550
        public void CalculateSize(){} // RVA: 0x7FFAC81E6660
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81E68F0
        public void .cctor(){} // RVA: 0x7FFAC81E6A40
    }

    public class Field : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Field> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public 0x6B22F5C0 pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public 0x6B22F618 Kind; // 0x1C
        public int Cardinality; // 0x20
        public string Number; // 0x28
        public string Name; // 0x30
        public int TypeUrl; // 0x38
        public bool OneofIndex; // 0x3C
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> Packed; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> Options; // 0x40
        public string JsonName; // 0x48
        public string DefaultValue; // 0x50

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81E2670
        public void get_Descriptor(){} // RVA: 0x7FFAC81E26D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81E2790
        public void .ctor(){} // RVA: 0x7FFAC81E2AE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81E2E20
        public void get_Kind(){} // RVA: 0x7FFAC3157800
        public void set_Kind(){} // RVA: 0x7FFAC392CD10
        public void get_Cardinality(){} // RVA: 0x7FFAC44357F0
        public void set_Cardinality(){} // RVA: 0x7FFAC44474D0
        public void get_Number(){} // RVA: 0x7FFAC30DBBE0
        public void set_Number(){} // RVA: 0x7FFAC35DB7A0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void set_Name(){} // RVA: 0x7FFAC81E2E80
        public void get_TypeUrl(){} // RVA: 0x7FFAC31D95E0
        public void set_TypeUrl(){} // RVA: 0x7FFAC81E2F80
        public void get_OneofIndex(){} // RVA: 0x7FFAC358A870
        public void set_OneofIndex(){} // RVA: 0x7FFAC3588350
        public void get_Packed(){} // RVA: 0x7FFAC30864E0
        public void set_Packed(){} // RVA: 0x7FFAC30864F0
        public void get_Options(){} // RVA: 0x7FFAC2F9E740
        public void get_JsonName(){} // RVA: 0x7FFAC2F9C730
        public void set_JsonName(){} // RVA: 0x7FFAC81E3080
        public void get_DefaultValue(){} // RVA: 0x7FFAC2FC20E0
        public void set_DefaultValue(){} // RVA: 0x7FFAC81E3180
        public void Equals(){} // RVA: 0x7FFAC81E32E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81E34F0
        public void ToString(){} // RVA: 0x7FFAC81E3670
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81E36C0
        public void CalculateSize(){} // RVA: 0x7FFAC81E38E0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81E3DA0
        public void .cctor(){} // RVA: 0x7FFAC81E4040
    }

    public class FieldMask : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.FieldMask> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<string> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> Paths; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81D4C10
        public void get_Descriptor(){} // RVA: 0x7FFAC81D4C70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D4D30
        public void .ctor(){} // RVA: 0x7FFAC81D4E40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D4FE0
        public void get_Paths(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC81D52B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC81D53D0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D5420
        public void CalculateSize(){} // RVA: 0x7FFAC81D54E0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D56D0
        public void ToJson(){} // RVA: 0x7FFAC81D57D0
        public void ToDiagnosticString(){} // RVA: 0x7FFAC81D5BD0
        public void FromString(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void FromStringEnumerable(){} // RVA: 0x7FFAC2C58F80
        public void FromFieldNumbers(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void IsPathValid(){} // RVA: 0x7FFAC81D5DC0
        public void IsValid(){} // RVA: 0x7FFAC81D6010 | overloaded x4
        public void Normalize(){} // RVA: 0x7FFAC81D61B0
        public void Union(){} // RVA: 0x7FFAC81D6220
        public void Intersection(){} // RVA: 0x7FFAC81D62E0
        public void Merge(){} // RVA: 0x7FFAC81D6740 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC81D6910
    }

    public class FieldMaskReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81D46A0
        public void .cctor(){} // RVA: 0x7FFAC81D4700
    }

    public class ListValue : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.ListValue> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Value> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Value> Values; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81DC360
        public void get_Descriptor(){} // RVA: 0x7FFAC81DC3C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81DC480
        public void .ctor(){} // RVA: 0x7FFAC81DC590 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81DC730
        public void get_Values(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC81DCA00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC81DCAB0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81DCB00
        public void CalculateSize(){} // RVA: 0x7FFAC81DCBC0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81DCDB0
        public void .cctor(){} // RVA: 0x7FFAC81DCEB0
    }

    public class Option : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Option> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Google.Protobuf.WellKnownTypes.Any Name; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81E6DC0
        public void get_Descriptor(){} // RVA: 0x7FFAC81E6E20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81E6EE0
        public void .ctor(){} // RVA: 0x7FFAC81E7060 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81E7230
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC81E7290
        public void get_Value(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Value(){} // RVA: 0x7FFAC2F4F0D0
        public void Equals(){} // RVA: 0x7FFAC81E74D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81E75C0
        public void ToString(){} // RVA: 0x7FFAC81E7650
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81E76A0
        public void CalculateSize(){} // RVA: 0x7FFAC81E7730
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81E7B10
        public void .cctor(){} // RVA: 0x7FFAC81E7C20
    }

    public class SourceContext : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.SourceContext> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81D7280
        public void get_Descriptor(){} // RVA: 0x7FFAC81D72E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D73A0
        public void .ctor(){} // RVA: 0x7FFAC81D7520 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D7680
        public void get_FileName(){} // RVA: 0x7FFAC2F247C0
        public void set_FileName(){} // RVA: 0x7FFAC81D7810
        public void Equals(){} // RVA: 0x7FFAC81D7A10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D7AC0
        public void ToString(){} // RVA: 0x7FFAC81D7B30
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D7B80
        public void CalculateSize(){} // RVA: 0x7FFAC81D7BF0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D7D80
        public void .cctor(){} // RVA: 0x7FFAC81D7E20
    }

    public class SourceContextReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81D6CF0
        public void .cctor(){} // RVA: 0x7FFAC81D6D50
    }

    public class Struct : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Struct> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Codec<string,Google.Protobuf.WellKnownTypes.Value> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.MapField`2<string,Google.Protobuf.WellKnownTypes.Value> Fields; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81D8C10
        public void get_Descriptor(){} // RVA: 0x7FFAC81D8C70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D8D30
        public void .ctor(){} // RVA: 0x7FFAC81D8E40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D8FE0
        public void get_Fields(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC81D92B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC81D9360
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D93B0
        public void CalculateSize(){} // RVA: 0x7FFAC81D9470
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D9640
        public void .cctor(){} // RVA: 0x7FFAC81D9740
    }

    public class StructReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81D8080
        public void .cctor(){} // RVA: 0x7FFAC81D80E0
    }

    public class Timestamp : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Timestamp> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public long pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Seconds; // 0x20
        public System.DateTime Nanos; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81DD7F0
        public void get_Descriptor(){} // RVA: 0x7FFAC81DD850
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81DD910
        public void .ctor(){} // RVA: 0x7FFAC81D1E60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81DD960
        public void get_Seconds(){} // RVA: 0x7FFAC2F247C0
        public void set_Seconds(){} // RVA: 0x7FFAC38920D0
        public void get_Nanos(){} // RVA: 0x7FFAC30DBBE0
        public void set_Nanos(){} // RVA: 0x7FFAC35DB7A0
        public void Equals(){} // RVA: 0x7FFAC81D2130 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D2180
        public void ToString(){} // RVA: 0x7FFAC81DDB40
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D2230
        public void CalculateSize(){} // RVA: 0x7FFAC81DDB90
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D24B0
        public void IsNormalized(){} // RVA: 0x7FFAC81DDDD0
        public void op_Subtraction(){} // RVA: 0x7FFAC81DE1F0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC81DDFF0
        public void ToDateTime(){} // RVA: 0x7FFAC81DE400
        public void ToDateTimeOffset(){} // RVA: 0x7FFAC81DE5C0
        public void FromDateTime(){} // RVA: 0x7FFAC81DE7F0
        public void FromDateTimeOffset(){} // RVA: 0x7FFAC81DEA20
        public void Normalize(){} // RVA: 0x7FFAC81DEAE0
        public void ToJson(){} // RVA: 0x7FFAC81DEB70
        public void CompareTo(){} // RVA: 0x7FFAC81DEF10
        public void op_LessThan(){} // RVA: 0x7FFAC81DEFB0
        public void op_GreaterThan(){} // RVA: 0x7FFAC81DF040
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC81DF0F0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC81DF1A0
        public void op_Equality(){} // RVA: 0x7FFAC81DF230
        public void op_Inequality(){} // RVA: 0x7FFAC81DF290
        public void ToDiagnosticString(){} // RVA: 0x7FFAC81DF370
        public void .cctor(){} // RVA: 0x7FFAC81DF3E0
    }

    public class TimestampReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81DD230
        public void .cctor(){} // RVA: 0x7FFAC81DD290
    }

    public class Type : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Type> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Field> Name; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Field> Fields; // 0x20
        public Google.Protobuf.FieldCodec`1<string> Oneofs; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> Options; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Option> SourceContext; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Option> Syntax; // 0x30
        public Google.Protobuf.WellKnownTypes.SourceContext sourceContext_; // 0x38
        public 0x6B22F4B8 syntax_; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81E0BA0
        public void get_Descriptor(){} // RVA: 0x7FFAC81E0C00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81E0CC0
        public void .ctor(){} // RVA: 0x7FFAC81E1010 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81E1380
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC81E13E0
        public void get_Fields(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Oneofs(){} // RVA: 0x7FFAC2F4F130
        public void get_Options(){} // RVA: 0x7FFAC31D95E0
        public void get_SourceContext(){} // RVA: 0x7FFAC31D0140
        public void set_SourceContext(){} // RVA: 0x7FFAC31D0C20
        public void get_Syntax(){} // RVA: 0x7FFAC2FC2080
        public void set_Syntax(){} // RVA: 0x7FFAC2FC2090
        public void Equals(){} // RVA: 0x7FFAC81E1540 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81E16F0
        public void ToString(){} // RVA: 0x7FFAC81E1810
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81E1860
        public void CalculateSize(){} // RVA: 0x7FFAC81E1A10
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81E1ED0
        public void .cctor(){} // RVA: 0x7FFAC81E2150
    }

    public class TypeReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81DF680
        public void .cctor(){} // RVA: 0x7FFAC81DF6E0
    }

    public class Value : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.WellKnownTypes.Value> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public object pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public 0x6B22F1A0 NullValue; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81D9BC0
        public void get_Descriptor(){} // RVA: 0x7FFAC81D9C20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81D9CE0
        public void .ctor(){} // RVA: 0x7FFAC81D9D30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81D9FC0
        public void get_NullValue(){} // RVA: 0x7FFAC81DA020
        public void set_NullValue(){} // RVA: 0x7FFAC81DA090
        public void get_NumberValue(){} // RVA: 0x7FFAC81DA140
        public void set_NumberValue(){} // RVA: 0x7FFAC81DA1C0
        public void get_StringValue(){} // RVA: 0x7FFAC81DA270
        public void set_StringValue(){} // RVA: 0x7FFAC81DA2F0
        public void get_BoolValue(){} // RVA: 0x7FFAC81DA3F0
        public void set_BoolValue(){} // RVA: 0x7FFAC81DA470
        public void get_StructValue(){} // RVA: 0x7FFAC81DA520
        public void set_StructValue(){} // RVA: 0x7FFAC81DA580
        public void get_ListValue(){} // RVA: 0x7FFAC81DA5E0
        public void set_ListValue(){} // RVA: 0x7FFAC81DA640
        public void get_KindCase(){} // RVA: 0x7FFAC30DBBE0
        public void ClearKind(){} // RVA: 0x7FFAC81DA6A0
        public void Equals(){} // RVA: 0x7FFAC81DA760 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81DA990
        public void ToString(){} // RVA: 0x7FFAC81DABC0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81DAC10
        public void CalculateSize(){} // RVA: 0x7FFAC81DADE0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81DB3F0
        public void ForString(){} // RVA: 0x7FFAC81DB6F0
        public void ForNumber(){} // RVA: 0x7FFAC81DB7D0
        public void ForBool(){} // RVA: 0x7FFAC81DB840
        public void ForNull(){} // RVA: 0x7FFAC81DB8B0
        public void ForList(){} // RVA: 0x7FFAC81DB910
        public void ForStruct(){} // RVA: 0x7FFAC81DBAB0
        public void .cctor(){} // RVA: 0x7FFAC81DBBE0
    }

}