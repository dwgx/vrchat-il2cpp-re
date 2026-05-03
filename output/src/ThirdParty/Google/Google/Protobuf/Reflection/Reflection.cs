// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 49
// Methods: 944

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorBase : Object
    {
        public int _index; // 0x10
        public string _fullName; // 0x18
        public Google.Protobuf.Reflection.FileDescriptor _file; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865BE3E0
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_FullName(){} // RVA: 0x7FFE810FE7C0
        public void get_File(){} // RVA: 0x7FFE811290C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFE813240E0
    }

    public class DescriptorDeclaration : Object
    {
        public Google.Protobuf.Reflection.IDescriptor _descriptor; // 0x10

        // ── Methods ──
        public void get_StartLine(){} // RVA: 0x7FFE813DB630
        public void .ctor(){} // RVA: 0x7FFE865BE4A0
        public void FromProto(){} // RVA: 0x7FFE865BE9E0
    }

    public class DescriptorPool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865BEA50
        public void ImportPublicDependencies(){} // RVA: 0x7FFE865BF110
        public void FindSymbol(){} // RVA: 0x7FFE810A1420
        public void AddPackage(){} // RVA: 0x7FFE865BF340
        public void AddSymbol(){} // RVA: 0x7FFE865BF740
        public void ValidateSymbolName(){} // RVA: 0x7FFE865BFB60
        public void FindFieldByNumber(){} // RVA: 0x7FFE865BFDE0
        public void AddFieldByNumber(){} // RVA: 0x7FFE865BFF40
        public void AddEnumValueByNumber(){} // RVA: 0x7FFE865C0360
        public void LookupSymbol(){} // RVA: 0x7FFE865C05B0
        public void .cctor(){} // RVA: 0x7FFE865C08A0
    }

    public class DescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.DescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_field_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FieldDescriptorProto> field_; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FieldDescriptorProto> extension_; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.DescriptorProto> _repeated_nestedType_codec; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.DescriptorProto> nestedType_; // 0x30
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_; // 0x38
        public Google.Protobuf.FieldCodec`1<ExtensionRange> _repeated_extensionRange_codec; // 0x30
        public Google.Protobuf.Collections.RepeatedField`1<ExtensionRange> extensionRange_; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8659A080
        public void get_Descriptor(){} // RVA: 0x7FFE8659A0E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8659A1A0
        public void .ctor(){} // RVA: 0x7FFE8659A6A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8659AC90
        public void get_Name(){} // RVA: 0x7FFE8659ACF0
        public void set_Name(){} // RVA: 0x7FFE8659AD60
        public void get_HasName(){} // RVA: 0x7FFE82AC8EE0
        public void ClearName(){} // RVA: 0x7FFE8340D8D0
        public void get_Field(){} // RVA: 0x7FFE811290C0
        public void get_Extension(){} // RVA: 0x7FFE81129130
        public void get_NestedType(){} // RVA: 0x7FFE8144E200
        public void get_EnumType(){} // RVA: 0x7FFE8143BA80
        public void get_ExtensionRange(){} // RVA: 0x7FFE81178740
        public void get_OneofDecl(){} // RVA: 0x7FFE81176730
        public void get_Options(){} // RVA: 0x7FFE8119C0E0
        public void set_Options(){} // RVA: 0x7FFE812534D0
        public void get_ReservedRange(){} // RVA: 0x7FFE811C3500
        public void get_ReservedName(){} // RVA: 0x7FFE81199370
        public void Equals(){} // RVA: 0x7FFE8659AEC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8659B190
        public void ToString(){} // RVA: 0x7FFE8659B360
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8659B3B0
        public void CalculateSize(){} // RVA: 0x7FFE8659B680
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8659BD30
        public void .cctor(){} // RVA: 0x7FFE8659C1A0
    }

    public class DescriptorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE865917C0
        public void .cctor(){} // RVA: 0x7FFE86591820
    }

    public class DescriptorUtil : Object
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x7FFE80E2E440
    }

    public class DescriptorValidationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C09C0
    }

    public class EnumDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.EnumDescriptorProto proto; // 0x28
        public Google.Protobuf.Reflection.MessageDescriptor containingType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C0B60
        public void get_Name(){} // RVA: 0x7FFE865C0FD0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFE865C1040
        public void get_Values(){} // RVA: 0x7FFE8143BA80
    }

    public class EnumDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.EnumValueDescriptorProto> _repeated_value_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.EnumValueDescriptorProto> value_; // 0x20
        public Google.Protobuf.Reflection.EnumOptions options_; // 0x28
        public Google.Protobuf.FieldCodec`1<EnumReservedRange> _repeated_reservedRange_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<EnumReservedRange> reservedRange_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865A3280
        public void get_Descriptor(){} // RVA: 0x7FFE865A32E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A33A0
        public void .ctor(){} // RVA: 0x7FFE865A35E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865A3960
        public void get_Name(){} // RVA: 0x7FFE865A39C0
        public void set_Name(){} // RVA: 0x7FFE865A3A30
        public void get_HasName(){} // RVA: 0x7FFE82AC8EE0
        public void ClearName(){} // RVA: 0x7FFE8340D8D0
        public void get_Value(){} // RVA: 0x7FFE811290C0
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void set_Options(){} // RVA: 0x7FFE810FCE90
        public void get_ReservedRange(){} // RVA: 0x7FFE8144E200
        public void get_ReservedName(){} // RVA: 0x7FFE8143BA80
        public void Equals(){} // RVA: 0x7FFE865A3B90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865A3D60
        public void ToString(){} // RVA: 0x7FFE865A3E70
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A3EC0
        public void CalculateSize(){} // RVA: 0x7FFE865A4060
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865A44C0
        public void .cctor(){} // RVA: 0x7FFE865A4720
    }

    public class EnumOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.EnumOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool AllowAliasDefaultValue; // 0x8
        public bool allowAlias_; // 0x24
        public bool DeprecatedDefaultValue; // 0x9
        public bool deprecated_; // 0x25
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865B1F90
        public void get_Descriptor(){} // RVA: 0x7FFE865B1FF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B20B0
        public void .ctor(){} // RVA: 0x7FFE865B2260 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B2480
        public void get_AllowAlias(){} // RVA: 0x7FFE865B24E0
        public void set_AllowAlias(){} // RVA: 0x7FFE865AE770
        public void get_HasAllowAlias(){} // RVA: 0x7FFE865AAC80
        public void ClearAllowAlias(){} // RVA: 0x7FFE865AAC90
        public void get_Deprecated(){} // RVA: 0x7FFE865B2550
        public void set_Deprecated(){} // RVA: 0x7FFE865AE7F0
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AAAA0
        public void ClearDeprecated(){} // RVA: 0x7FFE865AAAB0
        public void get_UninterpretedOption(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE865B2730 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865B2870
        public void ToString(){} // RVA: 0x7FFE865B2980
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B29D0
        public void CalculateSize(){} // RVA: 0x7FFE865B2B10
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B2DA0
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865B2F20
    }

    public class EnumValueDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.EnumDescriptor enumDescriptor; // 0x28
        public Google.Protobuf.Reflection.EnumValueDescriptorProto proto; // 0x30
        public object field_2; // 0x1C6
        public object field_3; // 0x1C7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C1150
        public void get_Proto(){} // RVA: 0x7FFE8144E200
        public void get_Name(){} // RVA: 0x7FFE865C1310
        public void get_Number(){} // RVA: 0x7FFE865C1380
        public void get_EnumDescriptor(){} // RVA: 0x7FFE81129130
    }

    public class EnumValueDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumValueDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string NameDefaultValue; // 0x8
        public string name_; // 0x20
        public int NumberDefaultValue; // 0x10
        public int number_; // 0x28
        public Google.Protobuf.Reflection.EnumValueOptions options_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865A57B0
        public void get_Descriptor(){} // RVA: 0x7FFE865A5810
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A58D0
        public void .ctor(){} // RVA: 0x7FFE865A59C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865A5BB0
        public void get_Name(){} // RVA: 0x7FFE865A5C10
        public void set_Name(){} // RVA: 0x7FFE865A5C80
        public void get_HasName(){} // RVA: 0x7FFE82BC81D0
        public void ClearName(){} // RVA: 0x7FFE86597DC0
        public void get_Number(){} // RVA: 0x7FFE865A5D80
        public void set_Number(){} // RVA: 0x7FFE865A0240
        public void get_HasNumber(){} // RVA: 0x7FFE8659D0B0
        public void ClearNumber(){} // RVA: 0x7FFE8659D0C0
        public void get_Options(){} // RVA: 0x7FFE8144E200
        public void set_Options(){} // RVA: 0x7FFE81129890
        public void Equals(){} // RVA: 0x7FFE865A5F50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865A6080
        public void ToString(){} // RVA: 0x7FFE865A6130
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A6180
        public void CalculateSize(){} // RVA: 0x7FFE865A6230
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865A6680
        public void .cctor(){} // RVA: 0x7FFE865A67B0
    }

    public class EnumValueOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumValueOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.EnumValueOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool DeprecatedDefaultValue; // 0x8
        public bool deprecated_; // 0x24
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865B32C0
        public void get_Descriptor(){} // RVA: 0x7FFE865B3320
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B33E0
        public void .ctor(){} // RVA: 0x7FFE865B3590 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B37A0
        public void get_Deprecated(){} // RVA: 0x7FFE865B3800
        public void set_Deprecated(){} // RVA: 0x7FFE865AE770
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AAC80
        public void ClearDeprecated(){} // RVA: 0x7FFE865AAC90
        public void get_UninterpretedOption(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE865B39C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865B3AD0
        public void ToString(){} // RVA: 0x7FFE865B3BA0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B3BF0
        public void CalculateSize(){} // RVA: 0x7FFE865B3D00
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B3F60
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865B40B0
    }

    public class ExtensionAccessor : Object
    {
        public Google.Protobuf.Extension extension; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C13A0
        public void get_Descriptor(){} // RVA: 0x7FFE811290C0
        public void Clear(){} // RVA: 0x7FFE865C1510
        public void HasValue(){} // RVA: 0x7FFE865C1570
        public void GetValue(){} // RVA: 0x7FFE865C15D0
        public void SetValue(){} // RVA: 0x7FFE865C1630
    }

    public class ExtensionCollection : Object
    {
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInDeclarationOrder; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C18A0 | overloaded x2
        public void get_UnorderedExtensions(){} // RVA: 0x7FFE811290C0
        public void CrossLink(){} // RVA: 0x7FFE865C1A90
    }

    public class ExtensionRangeOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ExtensionRangeOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.ExtensionRangeOptions> _extensions; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE8659EA60
        public void get_Descriptor(){} // RVA: 0x7FFE8659EAC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8659EB80
        public void .ctor(){} // RVA: 0x7FFE8659ED30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8659EF40
        public void get_UninterpretedOption(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE8659F0E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8659F1D0
        public void ToString(){} // RVA: 0x7FFE8659F260
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8659F2B0
        public void CalculateSize(){} // RVA: 0x7FFE8659F3A0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8659F5E0
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8659F710
    }

    public class FieldAccessorBase : Object
    {
        public System.Func`2<Google.Protobuf.IMessage,object> getValueDelegate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C2A40
        public void get_Descriptor(){} // RVA: 0x7FFE810FE7C0
        public void GetValue(){} // RVA: 0x7FFE85A7C5E0
        public void HasValue(){} // RVA: 0x7FFE80E2F3B0
        public void Clear(){} // RVA: 0x7FFE80E460A0
        public void SetValue(){} // RVA: 0x7FFE80E4F230
    }

    public class FieldDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.EnumDescriptor enumType; // 0x28
        public Google.Protobuf.Reflection.MessageDescriptor extendeeType; // 0x30
        public Google.Protobuf.Reflection.MessageDescriptor messageType; // 0x38
        public 0x6662AFDC fieldType; // 0x40
        public Google.Protobuf.Reflection.IFieldAccessor accessor; // 0x48
        public Google.Protobuf.Reflection.MessageDescriptor _containingType; // 0x50
        public Google.Protobuf.Reflection.OneofDescriptor _containingOneof; // 0x58
        public string _jsonName; // 0x60
        public string _propertyName; // 0x68
        public Google.Protobuf.Reflection.FieldDescriptorProto _proto; // 0x70
        public Google.Protobuf.Extension _extension; // 0x78
        public object field_11; // 0x1CD
        public object field_12; // 0x1CE
        public object field_13; // 0x1CF
        public object field_14; // 0x1D0
        public object field_15; // 0x1D1

        // ── Methods ──
        public void get_ContainingType(){} // RVA: 0x7FFE8119C0E0
        public void get_ContainingOneof(){} // RVA: 0x7FFE811C3500
        public void get_RealContainingOneof(){} // RVA: 0x7FFE865C2C90
        public void get_JsonName(){} // RVA: 0x7FFE81199370
        public void get_PropertyName(){} // RVA: 0x7FFE81176D50
        public void get_HasPresence(){} // RVA: 0x7FFE865C2CB0
        public void get_Proto(){} // RVA: 0x7FFE811C3590
        public void get_Extension(){} // RVA: 0x7FFE81463AE0
        public void .ctor(){} // RVA: 0x7FFE865C2D60
        public void get_Name(){} // RVA: 0x7FFE865C3500
        public void get_Accessor(){} // RVA: 0x7FFE81176730
        public void GetFieldTypeFromProtoType(){} // RVA: 0x7FFE865C3570
        public void get_IsRepeated(){} // RVA: 0x7FFE865C36E0
        public void get_IsMap(){} // RVA: 0x7FFE865C3710
        public void get_FieldType(){} // RVA: 0x7FFE8119C080
        public void get_FieldNumber(){} // RVA: 0x7FFE865C3750
        public void CompareTo(){} // RVA: 0x7FFE865C3770
        public void get_MessageType(){} // RVA: 0x7FFE865C3810
        public void get_ExtendeeType(){} // RVA: 0x7FFE865C3880
        public void CrossLink(){} // RVA: 0x7FFE865C3900
        public void CreateAccessor(){} // RVA: 0x7FFE865C3F30
    }

    public class FieldDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FieldDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string NameDefaultValue; // 0x8
        public string name_; // 0x20
        public int NumberDefaultValue; // 0x10
        public int number_; // 0x28
        public dFixup.xt.RegularExpressions.Group>.IndexOf LabelDefaultValue; // 0x14
        public dFixup.xt.RegularExpressions.Group>.IndexOf label_; // 0x2C
        public dFixup.ties TypeDefaultValue; // 0x18
        public dFixup.ties type_; // 0x30
        public string TypeNameDefaultValue; // 0x20
        public string typeName_; // 0x38
        public string ExtendeeDefaultValue; // 0x28
        public string extendee_; // 0x40
        public string DefaultValueDefaultValue; // 0x30
        public string defaultValue_; // 0x48
        public int OneofIndexDefaultValue; // 0x38
        public int oneofIndex_; // 0x50
        public string JsonNameDefaultValue; // 0x40
        public string jsonName_; // 0x58
        public Google.Protobuf.Reflection.FieldOptions options_; // 0x60
        public bool Proto3OptionalDefaultValue; // 0x48
        public bool proto3Optional_; // 0x68

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8659FA90
        public void get_Descriptor(){} // RVA: 0x7FFE8659FAF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8659FBB0
        public void .ctor(){} // RVA: 0x7FFE8659FCA0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865A0000
        public void get_Name(){} // RVA: 0x7FFE865A0060
        public void set_Name(){} // RVA: 0x7FFE865A00D0
        public void get_HasName(){} // RVA: 0x7FFE82BC81D0
        public void ClearName(){} // RVA: 0x7FFE86597DC0
        public void get_Number(){} // RVA: 0x7FFE865A01D0
        public void set_Number(){} // RVA: 0x7FFE865A0240
        public void get_HasNumber(){} // RVA: 0x7FFE8659D0B0
        public void ClearNumber(){} // RVA: 0x7FFE8659D0C0
        public void get_Label(){} // RVA: 0x7FFE865A0250
        public void set_Label(){} // RVA: 0x7FFE865A02C0
        public void get_HasLabel(){} // RVA: 0x7FFE8659D150
        public void ClearLabel(){} // RVA: 0x7FFE8659D160
        public void get_Type(){} // RVA: 0x7FFE865A02D0
        public void set_Type(){} // RVA: 0x7FFE865A0340
        public void get_HasType(){} // RVA: 0x7FFE865A0350
        public void ClearType(){} // RVA: 0x7FFE865A0360
        public void get_TypeName(){} // RVA: 0x7FFE865A0370
        public void set_TypeName(){} // RVA: 0x7FFE865A03E0
        public void get_HasTypeName(){} // RVA: 0x7FFE82AB3770
        public void ClearTypeName(){} // RVA: 0x7FFE81E7B590
        public void get_Extendee(){} // RVA: 0x7FFE865A04E0
        public void set_Extendee(){} // RVA: 0x7FFE865A0550
        public void get_HasExtendee(){} // RVA: 0x7FFE85C00F00
        public void ClearExtendee(){} // RVA: 0x7FFE865A0650
        public void get_DefaultValue(){} // RVA: 0x7FFE865A06B0
        public void set_DefaultValue(){} // RVA: 0x7FFE865A0720
        public void get_HasDefaultValue(){} // RVA: 0x7FFE865A0820
        public void ClearDefaultValue(){} // RVA: 0x7FFE865A0830
        public void get_OneofIndex(){} // RVA: 0x7FFE865A0890
        public void set_OneofIndex(){} // RVA: 0x7FFE865A0900
        public void get_HasOneofIndex(){} // RVA: 0x7FFE865A0910
        public void ClearOneofIndex(){} // RVA: 0x7FFE865A0920
        public void get_JsonName(){} // RVA: 0x7FFE865A0930
        public void set_JsonName(){} // RVA: 0x7FFE865A09A0
        public void get_HasJsonName(){} // RVA: 0x7FFE85C01C60
        public void ClearJsonName(){} // RVA: 0x7FFE865A0AA0
        public void get_Options(){} // RVA: 0x7FFE81199370
        public void set_Options(){} // RVA: 0x7FFE81199380
        public void get_Proto3Optional(){} // RVA: 0x7FFE865A0B00
        public void set_Proto3Optional(){} // RVA: 0x7FFE865A0B70
        public void get_HasProto3Optional(){} // RVA: 0x7FFE865A0B80
        public void ClearProto3Optional(){} // RVA: 0x7FFE865A0B90
        public void Equals(){} // RVA: 0x7FFE865A0C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865A0F10
        public void ToString(){} // RVA: 0x7FFE865A1110
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A1160
        public void CalculateSize(){} // RVA: 0x7FFE865A1370
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865A1930
        public void .cctor(){} // RVA: 0x7FFE865A1BF0
    }

    public class FieldOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FieldOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.FieldOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public dFixup.y CtypeDefaultValue; // 0x8
        public dFixup.y ctype_; // 0x24
        public bool PackedDefaultValue; // 0xC
        public bool packed_; // 0x28
        public 0x66629FB4 JstypeDefaultValue; // 0x10
        public 0x66629FB4 jstype_; // 0x2C
        public bool LazyDefaultValue; // 0x14
        public bool lazy_; // 0x30
        public bool UnverifiedLazyDefaultValue; // 0x15
        public bool unverifiedLazy_; // 0x31
        public bool DeprecatedDefaultValue; // 0x16
        public bool deprecated_; // 0x32
        public bool WeakDefaultValue; // 0x17
        public bool weak_; // 0x33
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865AF670
        public void get_Descriptor(){} // RVA: 0x7FFE865AF6D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865AF790
        public void .ctor(){} // RVA: 0x7FFE865AF940 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865AFB80
        public void get_Ctype(){} // RVA: 0x7FFE865AFBE0
        public void set_Ctype(){} // RVA: 0x7FFE865AFC50
        public void get_HasCtype(){} // RVA: 0x7FFE865AAC80
        public void ClearCtype(){} // RVA: 0x7FFE865AAC90
        public void get_Packed(){} // RVA: 0x7FFE865AFC60
        public void set_Packed(){} // RVA: 0x7FFE865AFCD0
        public void get_HasPacked(){} // RVA: 0x7FFE865AAAA0
        public void ClearPacked(){} // RVA: 0x7FFE865AAAB0
        public void get_Jstype(){} // RVA: 0x7FFE865AFCE0
        public void set_Jstype(){} // RVA: 0x7FFE865AFD50
        public void get_HasJstype(){} // RVA: 0x7FFE865AAFD0
        public void ClearJstype(){} // RVA: 0x7FFE865AAFE0
        public void get_Lazy(){} // RVA: 0x7FFE865AFD60
        public void set_Lazy(){} // RVA: 0x7FFE865AFDD0
        public void get_HasLazy(){} // RVA: 0x7FFE865AAF30
        public void ClearLazy(){} // RVA: 0x7FFE865AAF40
        public void get_UnverifiedLazy(){} // RVA: 0x7FFE865AFDE0
        public void set_UnverifiedLazy(){} // RVA: 0x7FFE865AFE50
        public void get_HasUnverifiedLazy(){} // RVA: 0x7FFE865AB110
        public void ClearUnverifiedLazy(){} // RVA: 0x7FFE865AB120
        public void get_Deprecated(){} // RVA: 0x7FFE865AFE60
        public void set_Deprecated(){} // RVA: 0x7FFE865AFED0
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AAE90
        public void ClearDeprecated(){} // RVA: 0x7FFE865AAEA0
        public void get_Weak(){} // RVA: 0x7FFE865AFEE0
        public void set_Weak(){} // RVA: 0x7FFE865AFF50
        public void get_HasWeak(){} // RVA: 0x7FFE865AAB40
        public void ClearWeak(){} // RVA: 0x7FFE865AAB50
        public void get_UninterpretedOption(){} // RVA: 0x7FFE8143BA80
        public void Equals(){} // RVA: 0x7FFE865AFFC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865B01A0
        public void ToString(){} // RVA: 0x7FFE865B0350
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B03A0
        public void CalculateSize(){} // RVA: 0x7FFE865B05B0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B09B0
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865B0C00
    }

    public class FileDescriptor : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>> declarations; // 0x10
        public Google.Protobuf.Reflection.FileDescriptorProto _proto; // 0x18
        public 0x6662B034 _syntax; // 0x20
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MessageDescriptor> _messageTypes; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.EnumDescriptor> _enumTypes; // 0x30
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.ServiceDescriptor> _services; // 0x38
        public Google.Protobuf.Reflection.ExtensionCollection _extensions; // 0x40
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FileDescriptor> _dependencies; // 0x48
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FileDescriptor> _publicDependencies; // 0x50
        public Google.Protobuf.ByteString _serializedData; // 0x58
        public Google.Protobuf.Reflection.DescriptorPool _descriptorPool; // 0x60
        public object field_11; // 0x1DD
        public object field_12; // 0x1DE

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE865C42F0
        public void .ctor(){} // RVA: 0x7FFE865C43A0
        public void CreateDeclarationMap(){} // RVA: 0x7FFE865C4D20
        public void FindDescriptorForPath(){} // RVA: 0x7FFE865C5010
        public void GetDescriptorFromList(){} // RVA: 0x7FFE865C53C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFE865C5500
        public void ComputeFullName(){} // RVA: 0x7FFE865C55E0
        public void DeterminePublicDependencies(){} // RVA: 0x7FFE865C5680
        public void get_Proto(){} // RVA: 0x7FFE810FE7C0
        public void get_Syntax(){} // RVA: 0x7FFE8151D690
        public void get_Name(){} // RVA: 0x7FFE865C5AD0
        public void get_Package(){} // RVA: 0x7FFE865C5B40
        public void get_MessageTypes(){} // RVA: 0x7FFE81129130
        public void get_EnumTypes(){} // RVA: 0x7FFE8144E200
        public void get_Services(){} // RVA: 0x7FFE8143BA80
        public void get_Extensions(){} // RVA: 0x7FFE81178740
        public void get_Dependencies(){} // RVA: 0x7FFE81176730
        public void get_PublicDependencies(){} // RVA: 0x7FFE8119C0E0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x7FFE865C5BB0
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x7FFE827C4A80
        public void get_DescriptorPool(){} // RVA: 0x7FFE81199370
        public void BuildFrom(){} // RVA: 0x7FFE865C5BC0
        public void CrossLink(){} // RVA: 0x7FFE865C5D50
        public void FromGeneratedCode(){} // RVA: 0x7FFE865C6100
        public void GetAllExtensions(){} // RVA: 0x7FFE865C66D0
        public void GetAllGeneratedExtensions(){} // RVA: 0x7FFE865C6870
        public void GetAllDependedExtensions(){} // RVA: 0x7FFE865C6A90
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x7FFE865C6EA0
        public void ToString(){} // RVA: 0x7FFE865C7210
        public void ForceReflectionInitialization(){} // RVA: 0x7FFE80E46010
    }

    public class FileDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public string PackageDefaultValue; // 0x10
        public string package_; // 0x20
        public Google.Protobuf.FieldCodec`1<string> _repeated_dependency_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<string> dependency_; // 0x28
        public Google.Protobuf.FieldCodec`1<int> _repeated_publicDependency_codec; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<int> publicDependency_; // 0x30
        public Google.Protobuf.FieldCodec`1<int> _repeated_weakDependency_codec; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<int> weakDependency_; // 0x38
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.DescriptorProto> _repeated_messageType_codec; // 0x30
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.DescriptorProto> messageType_; // 0x40
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_; // 0x48
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.ServiceDescriptorProto> _repeated_service_codec; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.ServiceDescriptorProto> service_; // 0x50

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86596DE0
        public void get_Descriptor(){} // RVA: 0x7FFE86596E40
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86596F00
        public void .ctor(){} // RVA: 0x7FFE86597410 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86597A80
        public void get_Name(){} // RVA: 0x7FFE86597AE0
        public void set_Name(){} // RVA: 0x7FFE86597B50
        public void get_HasName(){} // RVA: 0x7FFE82AC8EE0
        public void ClearName(){} // RVA: 0x7FFE8340D8D0
        public void get_Package(){} // RVA: 0x7FFE86597C50
        public void set_Package(){} // RVA: 0x7FFE86597CC0
        public void get_HasPackage(){} // RVA: 0x7FFE82BC81D0
        public void ClearPackage(){} // RVA: 0x7FFE86597DC0
        public void get_Dependency(){} // RVA: 0x7FFE81129130
        public void get_PublicDependency(){} // RVA: 0x7FFE8144E200
        public void get_WeakDependency(){} // RVA: 0x7FFE8143BA80
        public void get_MessageType(){} // RVA: 0x7FFE81178740
        public void get_EnumType(){} // RVA: 0x7FFE81176730
        public void get_Service(){} // RVA: 0x7FFE8119C0E0
        public void get_Extension(){} // RVA: 0x7FFE811C3500
        public void get_Options(){} // RVA: 0x7FFE81199370
        public void set_Options(){} // RVA: 0x7FFE81199380
        public void get_SourceCodeInfo(){} // RVA: 0x7FFE81176D50
        public void set_SourceCodeInfo(){} // RVA: 0x7FFE81176D60
        public void get_Syntax(){} // RVA: 0x7FFE86597E20
        public void set_Syntax(){} // RVA: 0x7FFE86597E90
        public void get_HasSyntax(){} // RVA: 0x7FFE86597F90
        public void ClearSyntax(){} // RVA: 0x7FFE812D43E0
        public void Equals(){} // RVA: 0x7FFE86598000 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86598380
        public void ToString(){} // RVA: 0x7FFE865985B0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86598600
        public void CalculateSize(){} // RVA: 0x7FFE86598900
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86599200
        public void .cctor(){} // RVA: 0x7FFE865996F0
    }

    public class FileDescriptorSet : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileDescriptorSet> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FileDescriptorProto> _repeated_file_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FileDescriptorProto> file_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86595E70
        public void get_Descriptor(){} // RVA: 0x7FFE86595ED0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86595F90
        public void .ctor(){} // RVA: 0x7FFE86596140 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865962E0
        public void get_File(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE865965B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86596660
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865966B0
        public void CalculateSize(){} // RVA: 0x7FFE86596770
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86596960
        public void .cctor(){} // RVA: 0x7FFE86596A60
    }

    public class FileOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.FileOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public string JavaPackageDefaultValue; // 0x8
        public string javaPackage_; // 0x28
        public string JavaOuterClassnameDefaultValue; // 0x10
        public string javaOuterClassname_; // 0x30
        public bool JavaMultipleFilesDefaultValue; // 0x18
        public bool javaMultipleFiles_; // 0x38
        public bool JavaGenerateEqualsAndHashDefaultValue; // 0x19
        public bool javaGenerateEqualsAndHash_; // 0x39
        public bool JavaStringCheckUtf8DefaultValue; // 0x1A
        public bool javaStringCheckUtf8_; // 0x3A
        public 0x66629D4C OptimizeForDefaultValue; // 0x1C
        public 0x66629D4C optimizeFor_; // 0x3C
        public string GoPackageDefaultValue; // 0x20
        public string goPackage_; // 0x40
        public bool CcGenericServicesDefaultValue; // 0x28
        public bool ccGenericServices_; // 0x48
        public bool JavaGenericServicesDefaultValue; // 0x29
        public bool javaGenericServices_; // 0x49
        public bool PyGenericServicesDefaultValue; // 0x2A
        public bool pyGenericServices_; // 0x4A
        public bool PhpGenericServicesDefaultValue; // 0x2B
        public bool phpGenericServices_; // 0x4B
        public bool DeprecatedDefaultValue; // 0x2C
        public bool deprecated_; // 0x4C
        public bool CcEnableArenasDefaultValue; // 0x2D
        public bool ccEnableArenas_; // 0x4D
        public string ObjcClassPrefixDefaultValue; // 0x30
        public string objcClassPrefix_; // 0x50
        public string CsharpNamespaceDefaultValue; // 0x38
        public string csharpNamespace_; // 0x58
        public string SwiftPrefixDefaultValue; // 0x40
        public string swiftPrefix_; // 0x60
        public string PhpClassPrefixDefaultValue; // 0x48
        public string phpClassPrefix_; // 0x68
        public string PhpNamespaceDefaultValue; // 0x50
        public string phpNamespace_; // 0x70
        public string PhpMetadataNamespaceDefaultValue; // 0x58
        public string phpMetadataNamespace_; // 0x78
        public string RubyPackageDefaultValue; // 0x60
        public string rubyPackage_; // 0x80
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x68

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865A9E70
        public void get_Descriptor(){} // RVA: 0x7FFE865A9ED0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A9F90
        public void .ctor(){} // RVA: 0x7FFE865AA140 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865AA6E0
        public void get_JavaPackage(){} // RVA: 0x7FFE865AA740
        public void set_JavaPackage(){} // RVA: 0x7FFE865AA7B0
        public void get_HasJavaPackage(){} // RVA: 0x7FFE865A8CD0
        public void ClearJavaPackage(){} // RVA: 0x7FFE836E7F30
        public void get_JavaOuterClassname(){} // RVA: 0x7FFE865AA8B0
        public void set_JavaOuterClassname(){} // RVA: 0x7FFE865AA920
        public void get_HasJavaOuterClassname(){} // RVA: 0x7FFE85C00B10
        public void ClearJavaOuterClassname(){} // RVA: 0x7FFE865A8E50
        public void get_JavaMultipleFiles(){} // RVA: 0x7FFE865AAA20
        public void set_JavaMultipleFiles(){} // RVA: 0x7FFE865AAA90
        public void get_HasJavaMultipleFiles(){} // RVA: 0x7FFE865AAAA0
        public void ClearJavaMultipleFiles(){} // RVA: 0x7FFE865AAAB0
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFE865AAAC0
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFE865AAB30
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x7FFE865AAB40
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x7FFE865AAB50
        public void get_JavaStringCheckUtf8(){} // RVA: 0x7FFE865AAB60
        public void set_JavaStringCheckUtf8(){} // RVA: 0x7FFE865AABD0
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x7FFE865AABE0
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x7FFE865AABF0
        public void get_OptimizeFor(){} // RVA: 0x7FFE865AAC00
        public void set_OptimizeFor(){} // RVA: 0x7FFE865AAC70
        public void get_HasOptimizeFor(){} // RVA: 0x7FFE865AAC80
        public void ClearOptimizeFor(){} // RVA: 0x7FFE865AAC90
        public void get_GoPackage(){} // RVA: 0x7FFE865AACA0
        public void set_GoPackage(){} // RVA: 0x7FFE865AAD10
        public void get_HasGoPackage(){} // RVA: 0x7FFE85C00F00
        public void ClearGoPackage(){} // RVA: 0x7FFE865A0650
        public void get_CcGenericServices(){} // RVA: 0x7FFE865AAE10
        public void set_CcGenericServices(){} // RVA: 0x7FFE865AAE80
        public void get_HasCcGenericServices(){} // RVA: 0x7FFE865AAE90
        public void ClearCcGenericServices(){} // RVA: 0x7FFE865AAEA0
        public void get_JavaGenericServices(){} // RVA: 0x7FFE865AAEB0
        public void set_JavaGenericServices(){} // RVA: 0x7FFE865AAF20
        public void get_HasJavaGenericServices(){} // RVA: 0x7FFE865AAF30
        public void ClearJavaGenericServices(){} // RVA: 0x7FFE865AAF40
        public void get_PyGenericServices(){} // RVA: 0x7FFE865AAF50
        public void set_PyGenericServices(){} // RVA: 0x7FFE865AAFC0
        public void get_HasPyGenericServices(){} // RVA: 0x7FFE865AAFD0
        public void ClearPyGenericServices(){} // RVA: 0x7FFE865AAFE0
        public void get_PhpGenericServices(){} // RVA: 0x7FFE865AAFF0
        public void set_PhpGenericServices(){} // RVA: 0x7FFE865AB060
        public void get_HasPhpGenericServices(){} // RVA: 0x7FFE865AB070
        public void ClearPhpGenericServices(){} // RVA: 0x7FFE865AB080
        public void get_Deprecated(){} // RVA: 0x7FFE865AB090
        public void set_Deprecated(){} // RVA: 0x7FFE865AB100
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AB110
        public void ClearDeprecated(){} // RVA: 0x7FFE865AB120
        public void get_CcEnableArenas(){} // RVA: 0x7FFE865AB130
        public void set_CcEnableArenas(){} // RVA: 0x7FFE865AB1A0
        public void get_HasCcEnableArenas(){} // RVA: 0x7FFE865AB1B0
        public void ClearCcEnableArenas(){} // RVA: 0x7FFE865AB1C0
        public void get_ObjcClassPrefix(){} // RVA: 0x7FFE865AB1D0
        public void set_ObjcClassPrefix(){} // RVA: 0x7FFE865AB240
        public void get_HasObjcClassPrefix(){} // RVA: 0x7FFE85C018B0
        public void ClearObjcClassPrefix(){} // RVA: 0x7FFE812D6640
        public void get_CsharpNamespace(){} // RVA: 0x7FFE865AB340
        public void set_CsharpNamespace(){} // RVA: 0x7FFE865AB3B0
        public void get_HasCsharpNamespace(){} // RVA: 0x7FFE85C01C60
        public void ClearCsharpNamespace(){} // RVA: 0x7FFE865A0AA0
        public void get_SwiftPrefix(){} // RVA: 0x7FFE865AB4B0
        public void set_SwiftPrefix(){} // RVA: 0x7FFE865AB520
        public void get_HasSwiftPrefix(){} // RVA: 0x7FFE82A9EF30
        public void ClearSwiftPrefix(){} // RVA: 0x7FFE865AB620
        public void get_PhpClassPrefix(){} // RVA: 0x7FFE865AB680
        public void set_PhpClassPrefix(){} // RVA: 0x7FFE865AB6F0
        public void get_HasPhpClassPrefix(){} // RVA: 0x7FFE820C2B70
        public void ClearPhpClassPrefix(){} // RVA: 0x7FFE812D4FC0
        public void get_PhpNamespace(){} // RVA: 0x7FFE865AB7F0
        public void set_PhpNamespace(){} // RVA: 0x7FFE865AB860
        public void get_HasPhpNamespace(){} // RVA: 0x7FFE86597F90
        public void ClearPhpNamespace(){} // RVA: 0x7FFE812D43E0
        public void get_PhpMetadataNamespace(){} // RVA: 0x7FFE865AB960
        public void set_PhpMetadataNamespace(){} // RVA: 0x7FFE865AB9D0
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x7FFE865ABAD0
        public void ClearPhpMetadataNamespace(){} // RVA: 0x7FFE865ABAE0
        public void get_RubyPackage(){} // RVA: 0x7FFE865ABB40
        public void set_RubyPackage(){} // RVA: 0x7FFE865ABBB0
        public void get_HasRubyPackage(){} // RVA: 0x7FFE865ABCB0
        public void ClearRubyPackage(){} // RVA: 0x7FFE825CC5F0
        public void get_UninterpretedOption(){} // RVA: 0x7FFE8113A010
        public void Equals(){} // RVA: 0x7FFE865ABD20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865AC2D0
        public void ToString(){} // RVA: 0x7FFE865AC720
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865AC770
        public void CalculateSize(){} // RVA: 0x7FFE865ACC00
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865AD380
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865AD8F0
    }

    public class GeneratedClrTypeInfo : Object
    {
        public string[] EmptyNames;
        public Google.Protobuf.Reflection.GeneratedClrTypeInfo[] EmptyCodeInfo; // 0x8
        public Google.Protobuf.Extension[] EmptyExtensions; // 0x10
        public System.Type _clrType; // 0x10
        public Google.Protobuf.MessageParser _parser; // 0x18
        public string[] _propertyNames; // 0x20
        public Google.Protobuf.Extension[] _extensions; // 0x28

        // ── Methods ──
        public void get_ClrType(){} // RVA: 0x7FFE81116380
        public void set_ClrType(){} // RVA: 0x7FFE810FCE30
        public void get_Parser(){} // RVA: 0x7FFE810FE7C0
        public void get_PropertyNames(){} // RVA: 0x7FFE811290C0
        public void get_Extensions(){} // RVA: 0x7FFE81129130
        public void get_OneofNames(){} // RVA: 0x7FFE8144E200
        public void get_NestedTypes(){} // RVA: 0x7FFE8143BA80
        public void get_NestedEnums(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE865C7900 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865C7940
    }

    public class GeneratedCodeInfo : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.GeneratedCodeInfo> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Annotation> _repeated_annotation_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Annotation> annotation_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865BC080
        public void get_Descriptor(){} // RVA: 0x7FFE865BC0E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865BC1A0
        public void .ctor(){} // RVA: 0x7FFE865BC2B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865BC450
        public void get_Annotation(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE865BC720 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE865BC7D0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865BC820
        public void CalculateSize(){} // RVA: 0x7FFE865BC8E0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865BCAD0
        public void .cctor(){} // RVA: 0x7FFE865BCBD0
    }

    public class IDescriptor
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_FullName(){} // RVA: 0x7FFE80E2E2E0
        public void get_File(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IFieldAccessor
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE80E2E2E0
        public void Clear(){} // RVA: 0x7FFE80E460A0
        public void GetValue(){} // RVA: 0x7FFE80E2E390
        public void HasValue(){} // RVA: 0x7FFE80E2F3B0
        public void SetValue(){} // RVA: 0x7FFE80E4F230
    }

    public class MapFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C7B20
        public void Clear(){} // RVA: 0x7FFE865C7B30
        public void HasValue(){} // RVA: 0x7FFE865C7BF0
        public void SetValue(){} // RVA: 0x7FFE865C7C40
    }

    public class MessageDescriptor : DescriptorBase
    {
        public System.Collections.Generic.HashSet`1<string> WellKnownTypeNames;
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder; // 0x30
        public System.Collections.Generic.IDictionary`2<string,Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap; // 0x38
        public Google.Protobuf.Reflection.DescriptorProto _proto; // 0x40
        public System.Type _clrType; // 0x48
        public Google.Protobuf.MessageParser _parser; // 0x50
        public Google.Protobuf.Reflection.MessageDescriptor _containingType; // 0x58
        public FieldCollection _fields; // 0x60
        public Google.Protobuf.Reflection.ExtensionCollection _extensions; // 0x68
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MessageDescriptor> _nestedTypes; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C7C90
        public void CreateJsonFieldMap(){} // RVA: 0x7FFE865C8A20
        public void get_Name(){} // RVA: 0x7FFE865C8DB0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFE865C8E20
        public void get_Proto(){} // RVA: 0x7FFE81178740
        public void get_ClrType(){} // RVA: 0x7FFE81176730
        public void get_Parser(){} // RVA: 0x7FFE8119C0E0
        public void get_IsWellKnownType(){} // RVA: 0x7FFE865C8F00
        public void get_IsWrapperType(){} // RVA: 0x7FFE865C9010
        public void get_Fields(){} // RVA: 0x7FFE81199370
        public void get_Extensions(){} // RVA: 0x7FFE81176D50
        public void get_NestedTypes(){} // RVA: 0x7FFE811C3590
        public void get_EnumTypes(){} // RVA: 0x7FFE81463AE0
        public void get_Oneofs(){} // RVA: 0x7FFE81280C30
        public void FindFieldByName(){} // RVA: 0x7FFE865C9100
        public void FindFieldByNumber(){} // RVA: 0x7FFE865C91A0
        public void CrossLink(){} // RVA: 0x7FFE865C9320
        public void .cctor(){} // RVA: 0x7FFE865C98E0
    }

    public class MessageOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MessageOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.MessageOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool MessageSetWireFormatDefaultValue; // 0x8
        public bool messageSetWireFormat_; // 0x24
        public bool NoStandardDescriptorAccessorDefaultValue; // 0x9
        public bool noStandardDescriptorAccessor_; // 0x25
        public bool DeprecatedDefaultValue; // 0xA
        public bool deprecated_; // 0x26
        public bool MapEntryDefaultValue; // 0xB
        public bool mapEntry_; // 0x27
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865AE1A0
        public void get_Descriptor(){} // RVA: 0x7FFE865AE200
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865AE2C0
        public void .ctor(){} // RVA: 0x7FFE865AE470 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865AE6A0
        public void get_MessageSetWireFormat(){} // RVA: 0x7FFE865AE700
        public void set_MessageSetWireFormat(){} // RVA: 0x7FFE865AE770
        public void get_HasMessageSetWireFormat(){} // RVA: 0x7FFE865AAC80
        public void ClearMessageSetWireFormat(){} // RVA: 0x7FFE865AAC90
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x7FFE865AE780
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x7FFE865AE7F0
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x7FFE865AAAA0
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x7FFE865AAAB0
        public void get_Deprecated(){} // RVA: 0x7FFE865AE800
        public void set_Deprecated(){} // RVA: 0x7FFE865AE870
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AAE90
        public void ClearDeprecated(){} // RVA: 0x7FFE865AAEA0
        public void get_MapEntry(){} // RVA: 0x7FFE865AE880
        public void set_MapEntry(){} // RVA: 0x7FFE865AE8F0
        public void get_HasMapEntry(){} // RVA: 0x7FFE865AAF30
        public void ClearMapEntry(){} // RVA: 0x7FFE865AAF40
        public void get_UninterpretedOption(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE865AE960 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865AEAE0
        public void ToString(){} // RVA: 0x7FFE865AEC40
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865AEC90
        public void CalculateSize(){} // RVA: 0x7FFE865AEE20
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865AF0E0
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865AF2B0
    }

    public class MethodDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.MethodDescriptorProto proto; // 0x28
        public Google.Protobuf.Reflection.ServiceDescriptor service; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CA070
        public void get_Proto(){} // RVA: 0x7FFE81129130
        public void get_Name(){} // RVA: 0x7FFE865CA220
        public void CrossLink(){} // RVA: 0x7FFE865CA290
    }

    public class MethodDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MethodDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string NameDefaultValue; // 0x8
        public string name_; // 0x20
        public string InputTypeDefaultValue; // 0x10
        public string inputType_; // 0x28
        public string OutputTypeDefaultValue; // 0x18
        public string outputType_; // 0x30
        public Google.Protobuf.Reflection.MethodOptions options_; // 0x38
        public bool ClientStreamingDefaultValue; // 0x20
        public bool clientStreaming_; // 0x40
        public bool ServerStreamingDefaultValue; // 0x21
        public bool serverStreaming_; // 0x41

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865A84E0
        public void get_Descriptor(){} // RVA: 0x7FFE865A8540
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A8600
        public void .ctor(){} // RVA: 0x7FFE865A86F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865A8990
        public void get_Name(){} // RVA: 0x7FFE865A89F0
        public void set_Name(){} // RVA: 0x7FFE865A8A60
        public void get_HasName(){} // RVA: 0x7FFE82BC81D0
        public void ClearName(){} // RVA: 0x7FFE86597DC0
        public void get_InputType(){} // RVA: 0x7FFE865A8B60
        public void set_InputType(){} // RVA: 0x7FFE865A8BD0
        public void get_HasInputType(){} // RVA: 0x7FFE865A8CD0
        public void ClearInputType(){} // RVA: 0x7FFE836E7F30
        public void get_OutputType(){} // RVA: 0x7FFE865A8CE0
        public void set_OutputType(){} // RVA: 0x7FFE865A8D50
        public void get_HasOutputType(){} // RVA: 0x7FFE85C00B10
        public void ClearOutputType(){} // RVA: 0x7FFE865A8E50
        public void get_Options(){} // RVA: 0x7FFE8143BA80
        public void set_Options(){} // RVA: 0x7FFE81437330
        public void get_ClientStreaming(){} // RVA: 0x7FFE865A8EB0
        public void set_ClientStreaming(){} // RVA: 0x7FFE865A8F20
        public void get_HasClientStreaming(){} // RVA: 0x7FFE8659D0B0
        public void ClearClientStreaming(){} // RVA: 0x7FFE8659D0C0
        public void get_ServerStreaming(){} // RVA: 0x7FFE865A8F30
        public void set_ServerStreaming(){} // RVA: 0x7FFE865A8FA0
        public void get_HasServerStreaming(){} // RVA: 0x7FFE8659D150
        public void ClearServerStreaming(){} // RVA: 0x7FFE8659D160
        public void Equals(){} // RVA: 0x7FFE865A9010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865A9210
        public void ToString(){} // RVA: 0x7FFE865A9390
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A93E0
        public void CalculateSize(){} // RVA: 0x7FFE865A9510
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865A98A0
        public void .cctor(){} // RVA: 0x7FFE865A9A80
    }

    public class MethodOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MethodOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.MethodOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool DeprecatedDefaultValue; // 0x8
        public bool deprecated_; // 0x24
        public 0x6662A3D4 IdempotencyLevelDefaultValue; // 0xC
        public 0x6662A3D4 idempotencyLevel_; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865B55D0
        public void get_Descriptor(){} // RVA: 0x7FFE865B5630
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B56F0
        public void .ctor(){} // RVA: 0x7FFE865B58A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B5AC0
        public void get_Deprecated(){} // RVA: 0x7FFE865B5B20
        public void set_Deprecated(){} // RVA: 0x7FFE865AE770
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AAC80
        public void ClearDeprecated(){} // RVA: 0x7FFE865AAC90
        public void get_IdempotencyLevel(){} // RVA: 0x7FFE865B5B90
        public void set_IdempotencyLevel(){} // RVA: 0x7FFE865B5C00
        public void get_HasIdempotencyLevel(){} // RVA: 0x7FFE865AAAA0
        public void ClearIdempotencyLevel(){} // RVA: 0x7FFE865AAAB0
        public void get_UninterpretedOption(){} // RVA: 0x7FFE8144E200
        public void Equals(){} // RVA: 0x7FFE865B5D80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865B5EC0
        public void ToString(){} // RVA: 0x7FFE865B5FB0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B6000
        public void CalculateSize(){} // RVA: 0x7FFE865B6140
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B6440
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865B65C0
    }

    public class OneofAccessor : Object
    {
        public System.Func`2<Google.Protobuf.IMessage,int> caseDelegate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CA640
        public void ForRegularOneof(){} // RVA: 0x7FFE865CA740
        public void ForSyntheticOneof(){} // RVA: 0x7FFE865CA940
        public void get_Descriptor(){} // RVA: 0x7FFE811290C0
        public void Clear(){} // RVA: 0x7FFE81717120
        public void GetCaseFieldDescriptor(){} // RVA: 0x7FFE865CAAD0
    }

    public class OneofDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.MessageDescriptor containingType; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> fields; // 0x30
        public Google.Protobuf.Reflection.OneofAccessor accessor; // 0x38
        public Google.Protobuf.Reflection.OneofDescriptorProto _proto; // 0x40
        public bool _isSynthetic; // 0x48
        public object field_5; // 0x204

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CAC90
        public void get_Name(){} // RVA: 0x7FFE865CAFC0
        public void get_Proto(){} // RVA: 0x7FFE81178740
        public void get_ContainingType(){} // RVA: 0x7FFE81129130
        public void get_Fields(){} // RVA: 0x7FFE8144E200
        public void get_IsSynthetic(){} // RVA: 0x7FFE811B2D30
        public void get_Accessor(){} // RVA: 0x7FFE8143BA80
        public void CrossLink(){} // RVA: 0x7FFE865CB030
        public void CreateAccessor(){} // RVA: 0x7FFE865CB3A0
    }

    public class OneofDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.OneofDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public Google.Protobuf.Reflection.OneofOptions options_; // 0x20
        public object field_5; // 0xE8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865A2100
        public void get_Descriptor(){} // RVA: 0x7FFE865A2160
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A2220
        public void .ctor(){} // RVA: 0x7FFE865A2310 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865A24F0
        public void get_Name(){} // RVA: 0x7FFE865A2550
        public void set_Name(){} // RVA: 0x7FFE865A25C0
        public void get_HasName(){} // RVA: 0x7FFE82AC8EE0
        public void ClearName(){} // RVA: 0x7FFE8340D8D0
        public void get_Options(){} // RVA: 0x7FFE811290C0
        public void set_Options(){} // RVA: 0x7FFE811290D0
        public void Equals(){} // RVA: 0x7FFE865A2810 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865A2920
        public void ToString(){} // RVA: 0x7FFE865A29C0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A2A10
        public void CalculateSize(){} // RVA: 0x7FFE865A2A90
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865A2E80
        public void .cctor(){} // RVA: 0x7FFE865A2F90
    }

    public class OneofOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.OneofOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.OneofOptions> _extensions; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865B0FF0
        public void get_Descriptor(){} // RVA: 0x7FFE865B1050
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B1110
        public void .ctor(){} // RVA: 0x7FFE865B12C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B14D0
        public void get_UninterpretedOption(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE865B1670 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8659F1D0
        public void ToString(){} // RVA: 0x7FFE865B1760
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B17B0
        public void CalculateSize(){} // RVA: 0x7FFE865B18A0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B1AE0
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865B1C10
    }

    public class OriginalNameAttribute : Attribute
    {
        public string _name; // 0x10
        public bool _preferredAlias; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_PreferredAlias(){} // RVA: 0x7FFE811164E0
        public void set_PreferredAlias(){} // RVA: 0x7FFE811164F0
        public void .ctor(){} // RVA: 0x7FFE865CB8E0
    }

    public class PackageDescriptor : Object
    {
        public string name; // 0x10
        public string fullName; // 0x18
        public Google.Protobuf.Reflection.FileDescriptor file; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CB9E0
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_FullName(){} // RVA: 0x7FFE810FE7C0
        public void get_File(){} // RVA: 0x7FFE811290C0
    }

    public class ReflectionUtil : Object
    {
        public System.Type[] EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE865CBAF0
        public void ForceInitialize(){} // RVA: 0x7FFE80E46010
        public void CreateFuncIMessageObject(){} // RVA: 0x7FFE865CC030
        public void CreateFuncIMessageInt32(){} // RVA: 0x7FFE865CC180
        public void CreateActionIMessageObject(){} // RVA: 0x7FFE865CC2B0
        public void CreateActionIMessage(){} // RVA: 0x7FFE865CC430
        public void CreateFuncIMessageBool(){} // RVA: 0x7FFE865CC5F0
        public void CreateExtensionHelper(){} // RVA: 0x7FFE865CC740
        public void GetReflectionHelper(){} // RVA: 0x7FFE865CCA20
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFE865CCC20
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFE865CCC80
        public void SampleEnumMethod(){} // RVA: 0x7FFE813240E0
    }

    public class RepeatedFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865C7B20
        public void Clear(){} // RVA: 0x7FFE865CCE90
        public void HasValue(){} // RVA: 0x7FFE865CCF50
        public void SetValue(){} // RVA: 0x7FFE865CCFA0
    }

    public class ServiceDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.ServiceDescriptorProto proto; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CCFF0
        public void get_Name(){} // RVA: 0x7FFE865CD350
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFE865CD3C0
        public void CrossLink(){} // RVA: 0x7FFE865CD430
    }

    public class ServiceDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ServiceDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.MethodDescriptorProto> _repeated_method_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.MethodDescriptorProto> method_; // 0x20
        public Google.Protobuf.Reflection.ServiceOptions options_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865A6E70
        public void get_Descriptor(){} // RVA: 0x7FFE865A6ED0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A6F90
        public void .ctor(){} // RVA: 0x7FFE865A7140 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865A73C0
        public void get_Name(){} // RVA: 0x7FFE865A7420
        public void set_Name(){} // RVA: 0x7FFE865A7490
        public void get_HasName(){} // RVA: 0x7FFE82AC8EE0
        public void ClearName(){} // RVA: 0x7FFE8340D8D0
        public void get_Method(){} // RVA: 0x7FFE811290C0
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void set_Options(){} // RVA: 0x7FFE810FCE90
        public void Equals(){} // RVA: 0x7FFE865A7720 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865A7880
        public void ToString(){} // RVA: 0x7FFE865A7940
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A7990
        public void CalculateSize(){} // RVA: 0x7FFE865A7AA0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865A7F50
        public void .cctor(){} // RVA: 0x7FFE865A80E0
    }

    public class ServiceOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ServiceOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.ServiceOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool DeprecatedDefaultValue; // 0x8
        public bool deprecated_; // 0x24
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE865B4440
        public void get_Descriptor(){} // RVA: 0x7FFE865B44A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B4560
        public void .ctor(){} // RVA: 0x7FFE865B4710 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B4920
        public void get_Deprecated(){} // RVA: 0x7FFE865B4980
        public void set_Deprecated(){} // RVA: 0x7FFE865AE770
        public void get_HasDeprecated(){} // RVA: 0x7FFE865AAC80
        public void ClearDeprecated(){} // RVA: 0x7FFE865AAC90
        public void get_UninterpretedOption(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE865B4B40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865B4C50
        public void ToString(){} // RVA: 0x7FFE865B4D20
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B4D70
        public void CalculateSize(){} // RVA: 0x7FFE865B4E90
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B50F0
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865B5240
    }

    public class SingleFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CD7F0
        public void GetDefaultValue(){} // RVA: 0x7FFE865CE370
        public void Clear(){} // RVA: 0x7FFE83FA8560
        public void HasValue(){} // RVA: 0x7FFE865CE920
        public void SetValue(){} // RVA: 0x7FFE865CE950
    }

    public class SourceCodeInfo : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.SourceCodeInfo> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Location> _repeated_location_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Location> location_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865B9790
        public void get_Descriptor(){} // RVA: 0x7FFE865B97F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B98B0
        public void .ctor(){} // RVA: 0x7FFE865B99C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B9B60
        public void get_Location(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE865B9E30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE865B9EE0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B9F30
        public void CalculateSize(){} // RVA: 0x7FFE865B9FF0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865BA1E0
        public void .cctor(){} // RVA: 0x7FFE865BA2E0
    }

    public class TypeRegistry : Object
    {
        public Google.Protobuf.Reflection.TypeRegistry _empty;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFE865CEC50
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Find(){} // RVA: 0x7FFE865CECB0
        public void .cctor(){} // RVA: 0x7FFE865CED20
    }

    public class UninterpretedOption : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.UninterpretedOption> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Google.Protobuf.FieldCodec`1<NamePart> _repeated_name_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<NamePart> name_; // 0x20
        public string IdentifierValueDefaultValue; // 0x10
        public string identifierValue_; // 0x28
        public ulong PositiveIntValueDefaultValue; // 0x18
        public ulong positiveIntValue_; // 0x30
        public long NegativeIntValueDefaultValue; // 0x20
        public long negativeIntValue_; // 0x38
        public double DoubleValueDefaultValue; // 0x28
        public double doubleValue_; // 0x40
        public Google.Protobuf.ByteString StringValueDefaultValue; // 0x30
        public Google.Protobuf.ByteString stringValue_; // 0x48
        public string AggregateValueDefaultValue; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE865B6960
        public void get_Descriptor(){} // RVA: 0x7FFE865B69C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B6A80
        public void .ctor(){} // RVA: 0x7FFE865B6B90 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE865B6E30
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void get_IdentifierValue(){} // RVA: 0x7FFE865B6E90
        public void set_IdentifierValue(){} // RVA: 0x7FFE865B6F00
        public void get_HasIdentifierValue(){} // RVA: 0x7FFE865A8CD0
        public void ClearIdentifierValue(){} // RVA: 0x7FFE836E7F30
        public void get_PositiveIntValue(){} // RVA: 0x7FFE865B7000
        public void set_PositiveIntValue(){} // RVA: 0x7FFE865B7070
        public void get_HasPositiveIntValue(){} // RVA: 0x7FFE8659D0B0
        public void ClearPositiveIntValue(){} // RVA: 0x7FFE8659D0C0
        public void get_NegativeIntValue(){} // RVA: 0x7FFE865B7080
        public void set_NegativeIntValue(){} // RVA: 0x7FFE865B70F0
        public void get_HasNegativeIntValue(){} // RVA: 0x7FFE8659D150
        public void ClearNegativeIntValue(){} // RVA: 0x7FFE8659D160
        public void get_DoubleValue(){} // RVA: 0x7FFE865B7100
        public void set_DoubleValue(){} // RVA: 0x7FFE865B7170
        public void get_HasDoubleValue(){} // RVA: 0x7FFE865A0350
        public void ClearDoubleValue(){} // RVA: 0x7FFE865A0360
        public void get_StringValue(){} // RVA: 0x7FFE865B7180
        public void set_StringValue(){} // RVA: 0x7FFE865B71F0
        public void get_HasStringValue(){} // RVA: 0x7FFE865B72F0
        public void ClearStringValue(){} // RVA: 0x7FFE865A0830
        public void get_AggregateValue(){} // RVA: 0x7FFE865B73B0
        public void set_AggregateValue(){} // RVA: 0x7FFE865B7420
        public void get_HasAggregateValue(){} // RVA: 0x7FFE85C018B0
        public void ClearAggregateValue(){} // RVA: 0x7FFE812D6640
        public void Equals(){} // RVA: 0x7FFE865B7580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE865B77F0
        public void ToString(){} // RVA: 0x7FFE865B79A0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B79F0
        public void CalculateSize(){} // RVA: 0x7FFE865B7BC0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B8000
        public void .cctor(){} // RVA: 0x7FFE865B8210
    }

}