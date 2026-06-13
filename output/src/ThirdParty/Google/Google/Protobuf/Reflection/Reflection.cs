// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 49
// Methods: 944

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorBase
    {
        public int <Index>k__BackingField; // 0x10
        public string <FullName>k__BackingField; // 0x18
        public Google.Protobuf.Reflection.FileDescriptor <File>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A7D680
        public void get_Name(){} // RVA: 0xCD60
        public void get_FullName(){} // RVA: 0x2E07C0
        public void get_File(){} // RVA: 0x30B0C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x519240
    }

    public class DescriptorDeclaration
    {
        public Google.Protobuf.Reflection.IDescriptor <Descriptor>k__BackingField; // 0x10

        // ── Methods ──
        public void get_StartLine(){} // RVA: 0x5BED50
        public void .ctor(){} // RVA: 0x5A7D740
        public void FromProto(){} // RVA: 0x5A7DC80
    }

    public class DescriptorPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A7DCF0
        public void ImportPublicDependencies(){} // RVA: 0x5A7E3B0
        public void FindSymbol(){} // RVA: 0x283FA0
        public void AddPackage(){} // RVA: 0x5A7E5E0
        public void AddSymbol(){} // RVA: 0x5A7E9E0
        public void ValidateSymbolName(){} // RVA: 0x5A7EE00
        public void FindFieldByNumber(){} // RVA: 0x5A7F080
        public void AddFieldByNumber(){} // RVA: 0x5A7F1E0
        public void AddEnumValueByNumber(){} // RVA: 0x5A7F600
        public void LookupSymbol(){} // RVA: 0x5A7F850
        public void .cctor(){} // RVA: 0x5A7FB40
    }

    public class DescriptorProto
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
        public void get_Parser(){} // RVA: 0x5A59380
        public void get_Descriptor(){} // RVA: 0x5A593E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A594A0
        public void .ctor(){} // RVA: 0x5A599A0 | overloaded x2
        public void Clone(){} // RVA: 0x5A59F90
        public void get_Name(){} // RVA: 0x5A59FF0
        public void set_Name(){} // RVA: 0x5A5A060
        public void get_HasName(){} // RVA: 0x1D3B060
        public void ClearName(){} // RVA: 0x26AD280
        public void get_Field(){} // RVA: 0x30B0C0
        public void get_Extension(){} // RVA: 0x30B130
        public void get_NestedType(){} // RVA: 0x6374D0
        public void get_EnumType(){} // RVA: 0x4976A0
        public void get_ExtensionRange(){} // RVA: 0x35A740
        public void get_OneofDecl(){} // RVA: 0x358730
        public void get_Options(){} // RVA: 0x37E0E0
        public void set_Options(){} // RVA: 0x4354D0
        public void get_ReservedRange(){} // RVA: 0x3A5500
        public void get_ReservedName(){} // RVA: 0x37B370
        public void Equals(){} // RVA: 0x5A5A1C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A5A490
        public void ToString(){} // RVA: 0x5A5A660
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A5A6B0
        public void CalculateSize(){} // RVA: 0x5A5A980
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A5B030
        public void .cctor(){} // RVA: 0x5A5B4A0
    }

    public class DescriptorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5A50A60
        public void .cctor(){} // RVA: 0x5A50AC0
    }

    public class DescriptorUtil
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0xCEC0
    }

    public class DescriptorValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A7FC60
    }

    public class EnumDescriptor
    {
        public Google.Protobuf.Reflection.EnumDescriptorProto proto; // 0x28
        public Google.Protobuf.Reflection.MessageDescriptor containingType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A7FE00
        public void get_Name(){} // RVA: 0x5A80270
        public void GetNestedDescriptorListForField(){} // RVA: 0x5A802E0
        public void get_Values(){} // RVA: 0x4976A0
    }

    public class EnumDescriptorProto
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
        public void get_Parser(){} // RVA: 0x5A62580
        public void get_Descriptor(){} // RVA: 0x5A625E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A626A0
        public void .ctor(){} // RVA: 0x5A628E0 | overloaded x2
        public void Clone(){} // RVA: 0x5A62C60
        public void get_Name(){} // RVA: 0x5A62CC0
        public void set_Name(){} // RVA: 0x5A62D30
        public void get_HasName(){} // RVA: 0x1D3B060
        public void ClearName(){} // RVA: 0x26AD280
        public void get_Value(){} // RVA: 0x30B0C0
        public void get_Options(){} // RVA: 0x30B130
        public void set_Options(){} // RVA: 0x2DEE90
        public void get_ReservedRange(){} // RVA: 0x6374D0
        public void get_ReservedName(){} // RVA: 0x4976A0
        public void Equals(){} // RVA: 0x5A62E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A63060
        public void ToString(){} // RVA: 0x5A63170
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A631C0
        public void CalculateSize(){} // RVA: 0x5A63360
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A637C0
        public void .cctor(){} // RVA: 0x5A63A20
    }

    public class EnumOptions
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
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A71230
        public void get_Descriptor(){} // RVA: 0x5A71290
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A71350
        public void .ctor(){} // RVA: 0x5A71500 | overloaded x2
        public void Clone(){} // RVA: 0x5A71720
        public void get_AllowAlias(){} // RVA: 0x5A71780
        public void set_AllowAlias(){} // RVA: 0x5A6DA10
        public void get_HasAllowAlias(){} // RVA: 0x5A69F80
        public void ClearAllowAlias(){} // RVA: 0x5A69F90
        public void get_Deprecated(){} // RVA: 0x5A717F0
        public void set_Deprecated(){} // RVA: 0x5A6DA90
        public void get_HasDeprecated(){} // RVA: 0x5A69DA0
        public void ClearDeprecated(){} // RVA: 0x5A69DB0
        public void get_UninterpretedOption(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x5A719D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A71B10
        public void ToString(){} // RVA: 0x5A71C20
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A71C70
        public void CalculateSize(){} // RVA: 0x5A71DB0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A72040
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A721C0
    }

    public class EnumValueDescriptor
    {
        public Google.Protobuf.Reflection.EnumDescriptor enumDescriptor; // 0x28
        public Google.Protobuf.Reflection.EnumValueDescriptorProto proto; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A803F0
        public void get_Proto(){} // RVA: 0x6374D0
        public void get_Name(){} // RVA: 0x5A805B0
        public void get_Number(){} // RVA: 0x5A80620
        public void get_EnumDescriptor(){} // RVA: 0x30B130
    }

    public class EnumValueDescriptorProto
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
        public void get_Parser(){} // RVA: 0x5A64AB0
        public void get_Descriptor(){} // RVA: 0x5A64B10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A64BD0
        public void .ctor(){} // RVA: 0x5A64CC0 | overloaded x2
        public void Clone(){} // RVA: 0x5A64EB0
        public void get_Name(){} // RVA: 0x5A64F10
        public void set_Name(){} // RVA: 0x5A64F80
        public void get_HasName(){} // RVA: 0x1E3EC10
        public void ClearName(){} // RVA: 0x5A57060
        public void get_Number(){} // RVA: 0x5A65080
        public void set_Number(){} // RVA: 0x5A5F540
        public void get_HasNumber(){} // RVA: 0x5A5C3B0
        public void ClearNumber(){} // RVA: 0x5A5C3C0
        public void get_Options(){} // RVA: 0x6374D0
        public void set_Options(){} // RVA: 0x30B890
        public void Equals(){} // RVA: 0x5A65250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A65380
        public void ToString(){} // RVA: 0x5A65430
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A65480
        public void CalculateSize(){} // RVA: 0x5A65530
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A65980
        public void .cctor(){} // RVA: 0x5A65AB0
    }

    public class EnumValueOptions
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumValueOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.EnumValueOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool DeprecatedDefaultValue; // 0x8
        public bool deprecated_; // 0x24
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A72560
        public void get_Descriptor(){} // RVA: 0x5A725C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A72680
        public void .ctor(){} // RVA: 0x5A72830 | overloaded x2
        public void Clone(){} // RVA: 0x5A72A40
        public void get_Deprecated(){} // RVA: 0x5A72AA0
        public void set_Deprecated(){} // RVA: 0x5A6DA10
        public void get_HasDeprecated(){} // RVA: 0x5A69F80
        public void ClearDeprecated(){} // RVA: 0x5A69F90
        public void get_UninterpretedOption(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x5A72C60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A72D70
        public void ToString(){} // RVA: 0x5A72E40
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A72E90
        public void CalculateSize(){} // RVA: 0x5A72FA0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A73200
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A73350
    }

    public class ExtensionAccessor : .ctor
    {
        public Google.Protobuf.Extension extension; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A80640
        public void get_Descriptor(){} // RVA: 0x30B0C0
        public void Clear(){} // RVA: 0x5A807B0
        public void HasValue(){} // RVA: 0x5A80810
        public void GetValue(){} // RVA: 0x5A80870
        public void SetValue(){} // RVA: 0x5A808D0
    }

    public class ExtensionCollection
    {
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInDeclarationOrder; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A80B40 | overloaded x2
        public void get_UnorderedExtensions(){} // RVA: 0x30B0C0
        public void CrossLink(){} // RVA: 0x5A80D30
    }

    public class ExtensionRangeOptions
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ExtensionRangeOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.ExtensionRangeOptions> _extensions; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A5DD60
        public void get_Descriptor(){} // RVA: 0x5A5DDC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A5DE80
        public void .ctor(){} // RVA: 0x5A5E030 | overloaded x2
        public void Clone(){} // RVA: 0x5A5E240
        public void get_UninterpretedOption(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x5A5E3E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A5E4D0
        public void ToString(){} // RVA: 0x5A5E560
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A5E5B0
        public void CalculateSize(){} // RVA: 0x5A5E6A0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A5E8E0
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A5EA10
    }

    public class FieldAccessorBase : .ctor
    {
        public System.Func`2<Google.Protobuf.IMessage,object> getValueDelegate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A81CE0
        public void get_Descriptor(){} // RVA: 0x2E07C0
        public void GetValue(){} // RVA: 0x288D780
        public void HasValue(){} // RVA: 0xDE40
        public void Clear(){} // RVA: 0x24B10
        public void SetValue(){} // RVA: 0x2DC60
    }

    public class FieldDescriptor
    {
        public Google.Protobuf.Reflection.EnumDescriptor enumType; // 0x28
        public Google.Protobuf.Reflection.MessageDescriptor extendeeType; // 0x30
        public Google.Protobuf.Reflection.MessageDescriptor messageType; // 0x38
        public 0x65951810 fieldType; // 0x40
        public Google.Protobuf.Reflection.IFieldAccessor accessor; // 0x48
        public Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField; // 0x50
        public Google.Protobuf.Reflection.OneofDescriptor <ContainingOneof>k__BackingField; // 0x58
        public string <JsonName>k__BackingField; // 0x60
        public string <PropertyName>k__BackingField; // 0x68
        public Google.Protobuf.Reflection.FieldDescriptorProto <Proto>k__BackingField; // 0x70
        public Google.Protobuf.Extension <Extension>k__BackingField; // 0x78

        // ── Methods ──
        public void get_ContainingType(){} // RVA: 0x37E0E0
        public void get_ContainingOneof(){} // RVA: 0x3A5500
        public void get_RealContainingOneof(){} // RVA: 0x5A81F30
        public void get_JsonName(){} // RVA: 0x37B370
        public void get_PropertyName(){} // RVA: 0x358D50
        public void get_HasPresence(){} // RVA: 0x5A81F50
        public void get_Proto(){} // RVA: 0x3A5590
        public void get_Extension(){} // RVA: 0x4C7C50
        public void .ctor(){} // RVA: 0x5A82000
        public void get_Name(){} // RVA: 0x5A827A0
        public void get_Accessor(){} // RVA: 0x358730
        public void GetFieldTypeFromProtoType(){} // RVA: 0x5A82810
        public void get_IsRepeated(){} // RVA: 0x5A82980
        public void get_IsMap(){} // RVA: 0x5A829B0
        public void get_FieldType(){} // RVA: 0x37E080
        public void get_FieldNumber(){} // RVA: 0x5A829F0
        public void CompareTo(){} // RVA: 0x5A82A10
        public void get_MessageType(){} // RVA: 0x5A82AB0
        public void get_ExtendeeType(){} // RVA: 0x5A82B20
        public void CrossLink(){} // RVA: 0x5A82BA0
        public void CreateAccessor(){} // RVA: 0x5A831D0
    }

    public class FieldDescriptorProto
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FieldDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string NameDefaultValue; // 0x8
        public string name_; // 0x20
        public int NumberDefaultValue; // 0x10
        public int number_; // 0x28
        public 0x6594FFA8 LabelDefaultValue; // 0x14
        public 0x6594FFA8 label_; // 0x2C
        public 0x6594FF50 TypeDefaultValue; // 0x18
        public 0x6594FF50 type_; // 0x30
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
        public void get_Parser(){} // RVA: 0x5A5ED90
        public void get_Descriptor(){} // RVA: 0x5A5EDF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A5EEB0
        public void .ctor(){} // RVA: 0x5A5EFA0 | overloaded x2
        public void Clone(){} // RVA: 0x5A5F300
        public void get_Name(){} // RVA: 0x5A5F360
        public void set_Name(){} // RVA: 0x5A5F3D0
        public void get_HasName(){} // RVA: 0x1E3EC10
        public void ClearName(){} // RVA: 0x5A57060
        public void get_Number(){} // RVA: 0x5A5F4D0
        public void set_Number(){} // RVA: 0x5A5F540
        public void get_HasNumber(){} // RVA: 0x5A5C3B0
        public void ClearNumber(){} // RVA: 0x5A5C3C0
        public void get_Label(){} // RVA: 0x5A5F550
        public void set_Label(){} // RVA: 0x5A5F5C0
        public void get_HasLabel(){} // RVA: 0x5A5C450
        public void ClearLabel(){} // RVA: 0x5A5C460
        public void get_Type(){} // RVA: 0x5A5F5D0
        public void set_Type(){} // RVA: 0x5A5F640
        public void get_HasType(){} // RVA: 0x5A5F650
        public void ClearType(){} // RVA: 0x5A5F660
        public void get_TypeName(){} // RVA: 0x5A5F670
        public void set_TypeName(){} // RVA: 0x5A5F6E0
        public void get_HasTypeName(){} // RVA: 0x1D258F0
        public void ClearTypeName(){} // RVA: 0x11074B0
        public void get_Extendee(){} // RVA: 0x5A5F7E0
        public void set_Extendee(){} // RVA: 0x5A5F850
        public void get_HasExtendee(){} // RVA: 0x51555F0
        public void ClearExtendee(){} // RVA: 0x5A5F950
        public void get_DefaultValue(){} // RVA: 0x5A5F9B0
        public void set_DefaultValue(){} // RVA: 0x5A5FA20
        public void get_HasDefaultValue(){} // RVA: 0x5A5FB20
        public void ClearDefaultValue(){} // RVA: 0x5A5FB30
        public void get_OneofIndex(){} // RVA: 0x5A5FB90
        public void set_OneofIndex(){} // RVA: 0x5A5FC00
        public void get_HasOneofIndex(){} // RVA: 0x5A5FC10
        public void ClearOneofIndex(){} // RVA: 0x5A5FC20
        public void get_JsonName(){} // RVA: 0x5A5FC30
        public void set_JsonName(){} // RVA: 0x5A5FCA0
        public void get_HasJsonName(){} // RVA: 0x51563D0
        public void ClearJsonName(){} // RVA: 0x5A5FDA0
        public void get_Options(){} // RVA: 0x37B370
        public void set_Options(){} // RVA: 0x37B380
        public void get_Proto3Optional(){} // RVA: 0x5A5FE00
        public void set_Proto3Optional(){} // RVA: 0x5A5FE70
        public void get_HasProto3Optional(){} // RVA: 0x5A5FE80
        public void ClearProto3Optional(){} // RVA: 0x5A5FE90
        public void Equals(){} // RVA: 0x5A5FF00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A60210
        public void ToString(){} // RVA: 0x5A60410
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A60460
        public void CalculateSize(){} // RVA: 0x5A60670
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A60C30
        public void .cctor(){} // RVA: 0x5A60EF0
    }

    public class FieldOptions
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FieldOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.FieldOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public 0x65950790 CtypeDefaultValue; // 0x8
        public 0x65950790 ctype_; // 0x24
        public bool PackedDefaultValue; // 0xC
        public bool packed_; // 0x28
        public 0x659507E8 JstypeDefaultValue; // 0x10
        public 0x659507E8 jstype_; // 0x2C
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
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A6E910
        public void get_Descriptor(){} // RVA: 0x5A6E970
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A6EA30
        public void .ctor(){} // RVA: 0x5A6EBE0 | overloaded x2
        public void Clone(){} // RVA: 0x5A6EE20
        public void get_Ctype(){} // RVA: 0x5A6EE80
        public void set_Ctype(){} // RVA: 0x5A6EEF0
        public void get_HasCtype(){} // RVA: 0x5A69F80
        public void ClearCtype(){} // RVA: 0x5A69F90
        public void get_Packed(){} // RVA: 0x5A6EF00
        public void set_Packed(){} // RVA: 0x5A6EF70
        public void get_HasPacked(){} // RVA: 0x5A69DA0
        public void ClearPacked(){} // RVA: 0x5A69DB0
        public void get_Jstype(){} // RVA: 0x5A6EF80
        public void set_Jstype(){} // RVA: 0x5A6EFF0
        public void get_HasJstype(){} // RVA: 0x5A6A2D0
        public void ClearJstype(){} // RVA: 0x5A6A2E0
        public void get_Lazy(){} // RVA: 0x5A6F000
        public void set_Lazy(){} // RVA: 0x5A6F070
        public void get_HasLazy(){} // RVA: 0x5A6A230
        public void ClearLazy(){} // RVA: 0x5A6A240
        public void get_UnverifiedLazy(){} // RVA: 0x5A6F080
        public void set_UnverifiedLazy(){} // RVA: 0x5A6F0F0
        public void get_HasUnverifiedLazy(){} // RVA: 0x5A6A410
        public void ClearUnverifiedLazy(){} // RVA: 0x5A6A420
        public void get_Deprecated(){} // RVA: 0x5A6F100
        public void set_Deprecated(){} // RVA: 0x5A6F170
        public void get_HasDeprecated(){} // RVA: 0x5A6A190
        public void ClearDeprecated(){} // RVA: 0x5A6A1A0
        public void get_Weak(){} // RVA: 0x5A6F180
        public void set_Weak(){} // RVA: 0x5A6F1F0
        public void get_HasWeak(){} // RVA: 0x5A69E40
        public void ClearWeak(){} // RVA: 0x5A69E50
        public void get_UninterpretedOption(){} // RVA: 0x4976A0
        public void Equals(){} // RVA: 0x5A6F260 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A6F440
        public void ToString(){} // RVA: 0x5A6F5F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A6F640
        public void CalculateSize(){} // RVA: 0x5A6F850
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A6FC50
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A6FEA0
    }

    public class FileDescriptor
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>> declarations; // 0x10
        public Google.Protobuf.Reflection.FileDescriptorProto <Proto>k__BackingField; // 0x18
        public 0x65951868 <Syntax>k__BackingField; // 0x20
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MessageDescriptor> <MessageTypes>k__BackingField; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField; // 0x30
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.ServiceDescriptor> <Services>k__BackingField; // 0x38
        public Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField; // 0x40
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FileDescriptor> <Dependencies>k__BackingField; // 0x48
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FileDescriptor> <PublicDependencies>k__BackingField; // 0x50
        public Google.Protobuf.ByteString <SerializedData>k__BackingField; // 0x58
        public Google.Protobuf.Reflection.DescriptorPool <DescriptorPool>k__BackingField; // 0x60

        // ── Methods ──
        public void .cctor(){} // RVA: 0x5A83590
        public void .ctor(){} // RVA: 0x5A83640
        public void CreateDeclarationMap(){} // RVA: 0x5A83FC0
        public void FindDescriptorForPath(){} // RVA: 0x5A842B0
        public void GetDescriptorFromList(){} // RVA: 0x5A84660
        public void GetNestedDescriptorListForField(){} // RVA: 0x5A847A0
        public void ComputeFullName(){} // RVA: 0x5A84880
        public void DeterminePublicDependencies(){} // RVA: 0x5A84920
        public void get_Proto(){} // RVA: 0x2E07C0
        public void get_Syntax(){} // RVA: 0x760030
        public void get_Name(){} // RVA: 0x5A84D70
        public void get_Package(){} // RVA: 0x5A84DE0
        public void get_MessageTypes(){} // RVA: 0x30B130
        public void get_EnumTypes(){} // RVA: 0x6374D0
        public void get_Services(){} // RVA: 0x4976A0
        public void get_Extensions(){} // RVA: 0x35A740
        public void get_Dependencies(){} // RVA: 0x358730
        public void get_PublicDependencies(){} // RVA: 0x37E0E0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x5A84E50
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x1A3F520
        public void get_DescriptorPool(){} // RVA: 0x37B370
        public void BuildFrom(){} // RVA: 0x5A84E60
        public void CrossLink(){} // RVA: 0x5A84FF0
        public void FromGeneratedCode(){} // RVA: 0x5A853A0
        public void GetAllExtensions(){} // RVA: 0x5A85970
        public void GetAllGeneratedExtensions(){} // RVA: 0x5A85B10
        public void GetAllDependedExtensions(){} // RVA: 0x5A85D30
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x5A86140
        public void ToString(){} // RVA: 0x5A864B0
        public void ForceReflectionInitialization(){} // RVA: 0x24A80
    }

    public class FileDescriptorProto
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
        public void get_Parser(){} // RVA: 0x5A56080
        public void get_Descriptor(){} // RVA: 0x5A560E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A561A0
        public void .ctor(){} // RVA: 0x5A566B0 | overloaded x2
        public void Clone(){} // RVA: 0x5A56D20
        public void get_Name(){} // RVA: 0x5A56D80
        public void set_Name(){} // RVA: 0x5A56DF0
        public void get_HasName(){} // RVA: 0x1D3B060
        public void ClearName(){} // RVA: 0x26AD280
        public void get_Package(){} // RVA: 0x5A56EF0
        public void set_Package(){} // RVA: 0x5A56F60
        public void get_HasPackage(){} // RVA: 0x1E3EC10
        public void ClearPackage(){} // RVA: 0x5A57060
        public void get_Dependency(){} // RVA: 0x30B130
        public void get_PublicDependency(){} // RVA: 0x6374D0
        public void get_WeakDependency(){} // RVA: 0x4976A0
        public void get_MessageType(){} // RVA: 0x35A740
        public void get_EnumType(){} // RVA: 0x358730
        public void get_Service(){} // RVA: 0x37E0E0
        public void get_Extension(){} // RVA: 0x3A5500
        public void get_Options(){} // RVA: 0x37B370
        public void set_Options(){} // RVA: 0x37B380
        public void get_SourceCodeInfo(){} // RVA: 0x358D50
        public void set_SourceCodeInfo(){} // RVA: 0x358D60
        public void get_Syntax(){} // RVA: 0x5A570C0
        public void set_Syntax(){} // RVA: 0x5A57130
        public void get_HasSyntax(){} // RVA: 0x5A57230
        public void ClearSyntax(){} // RVA: 0x5A57240
        public void Equals(){} // RVA: 0x5A57300 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A57680
        public void ToString(){} // RVA: 0x5A578B0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A57900
        public void CalculateSize(){} // RVA: 0x5A57C00
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A58500
        public void .cctor(){} // RVA: 0x5A589F0
    }

    public class FileDescriptorSet
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileDescriptorSet> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FileDescriptorProto> _repeated_file_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FileDescriptorProto> file_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A55110
        public void get_Descriptor(){} // RVA: 0x5A55170
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A55230
        public void .ctor(){} // RVA: 0x5A553E0 | overloaded x2
        public void Clone(){} // RVA: 0x5A55580
        public void get_File(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5A55850 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5A55900
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A55950
        public void CalculateSize(){} // RVA: 0x5A55A10
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A55C00
        public void .cctor(){} // RVA: 0x5A55D00
    }

    public class FileOptions
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
        public 0x65950580 OptimizeForDefaultValue; // 0x1C
        public 0x65950580 optimizeFor_; // 0x3C
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
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A69170
        public void get_Descriptor(){} // RVA: 0x5A691D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A69290
        public void .ctor(){} // RVA: 0x5A69440 | overloaded x2
        public void Clone(){} // RVA: 0x5A699E0
        public void get_JavaPackage(){} // RVA: 0x5A69A40
        public void set_JavaPackage(){} // RVA: 0x5A69AB0
        public void get_HasJavaPackage(){} // RVA: 0x5A67FD0
        public void ClearJavaPackage(){} // RVA: 0x29FDA70
        public void get_JavaOuterClassname(){} // RVA: 0x5A69BB0
        public void set_JavaOuterClassname(){} // RVA: 0x5A69C20
        public void get_HasJavaOuterClassname(){} // RVA: 0x51555E0
        public void ClearJavaOuterClassname(){} // RVA: 0x5A68150
        public void get_JavaMultipleFiles(){} // RVA: 0x5A69D20
        public void set_JavaMultipleFiles(){} // RVA: 0x5A69D90
        public void get_HasJavaMultipleFiles(){} // RVA: 0x5A69DA0
        public void ClearJavaMultipleFiles(){} // RVA: 0x5A69DB0
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x5A69DC0
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x5A69E30
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x5A69E40
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x5A69E50
        public void get_JavaStringCheckUtf8(){} // RVA: 0x5A69E60
        public void set_JavaStringCheckUtf8(){} // RVA: 0x5A69ED0
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x5A69EE0
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x5A69EF0
        public void get_OptimizeFor(){} // RVA: 0x5A69F00
        public void set_OptimizeFor(){} // RVA: 0x5A69F70
        public void get_HasOptimizeFor(){} // RVA: 0x5A69F80
        public void ClearOptimizeFor(){} // RVA: 0x5A69F90
        public void get_GoPackage(){} // RVA: 0x5A69FA0
        public void set_GoPackage(){} // RVA: 0x5A6A010
        public void get_HasGoPackage(){} // RVA: 0x51555F0
        public void ClearGoPackage(){} // RVA: 0x5A5F950
        public void get_CcGenericServices(){} // RVA: 0x5A6A110
        public void set_CcGenericServices(){} // RVA: 0x5A6A180
        public void get_HasCcGenericServices(){} // RVA: 0x5A6A190
        public void ClearCcGenericServices(){} // RVA: 0x5A6A1A0
        public void get_JavaGenericServices(){} // RVA: 0x5A6A1B0
        public void set_JavaGenericServices(){} // RVA: 0x5A6A220
        public void get_HasJavaGenericServices(){} // RVA: 0x5A6A230
        public void ClearJavaGenericServices(){} // RVA: 0x5A6A240
        public void get_PyGenericServices(){} // RVA: 0x5A6A250
        public void set_PyGenericServices(){} // RVA: 0x5A6A2C0
        public void get_HasPyGenericServices(){} // RVA: 0x5A6A2D0
        public void ClearPyGenericServices(){} // RVA: 0x5A6A2E0
        public void get_PhpGenericServices(){} // RVA: 0x5A6A2F0
        public void set_PhpGenericServices(){} // RVA: 0x5A6A360
        public void get_HasPhpGenericServices(){} // RVA: 0x5A6A370
        public void ClearPhpGenericServices(){} // RVA: 0x5A6A380
        public void get_Deprecated(){} // RVA: 0x5A6A390
        public void set_Deprecated(){} // RVA: 0x5A6A400
        public void get_HasDeprecated(){} // RVA: 0x5A6A410
        public void ClearDeprecated(){} // RVA: 0x5A6A420
        public void get_CcEnableArenas(){} // RVA: 0x5A6A430
        public void set_CcEnableArenas(){} // RVA: 0x5A6A4A0
        public void get_HasCcEnableArenas(){} // RVA: 0x5A6A4B0
        public void ClearCcEnableArenas(){} // RVA: 0x5A6A4C0
        public void get_ObjcClassPrefix(){} // RVA: 0x5A6A4D0
        public void set_ObjcClassPrefix(){} // RVA: 0x5A6A540
        public void get_HasObjcClassPrefix(){} // RVA: 0x51563C0
        public void ClearObjcClassPrefix(){} // RVA: 0x4AED90
        public void get_CsharpNamespace(){} // RVA: 0x5A6A640
        public void set_CsharpNamespace(){} // RVA: 0x5A6A6B0
        public void get_HasCsharpNamespace(){} // RVA: 0x51563D0
        public void ClearCsharpNamespace(){} // RVA: 0x5A5FDA0
        public void get_SwiftPrefix(){} // RVA: 0x5A6A7B0
        public void set_SwiftPrefix(){} // RVA: 0x5A6A820
        public void get_HasSwiftPrefix(){} // RVA: 0x1D110B0
        public void ClearSwiftPrefix(){} // RVA: 0x5A6A920
        public void get_PhpClassPrefix(){} // RVA: 0x5A6A980
        public void set_PhpClassPrefix(){} // RVA: 0x5A6A9F0
        public void get_HasPhpClassPrefix(){} // RVA: 0x1348BF0
        public void ClearPhpClassPrefix(){} // RVA: 0x93F810
        public void get_PhpNamespace(){} // RVA: 0x5A6AAF0
        public void set_PhpNamespace(){} // RVA: 0x5A6AB60
        public void get_HasPhpNamespace(){} // RVA: 0x5A57230
        public void ClearPhpNamespace(){} // RVA: 0x5A57240
        public void get_PhpMetadataNamespace(){} // RVA: 0x5A6AC60
        public void set_PhpMetadataNamespace(){} // RVA: 0x5A6ACD0
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x5A6ADD0
        public void ClearPhpMetadataNamespace(){} // RVA: 0x4AAF10
        public void get_RubyPackage(){} // RVA: 0x5A6ADE0
        public void set_RubyPackage(){} // RVA: 0x5A6AE50
        public void get_HasRubyPackage(){} // RVA: 0x5A6AF50
        public void ClearRubyPackage(){} // RVA: 0x4AAEB0
        public void get_UninterpretedOption(){} // RVA: 0x31C010
        public void Equals(){} // RVA: 0x5A6AFC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A6B570
        public void ToString(){} // RVA: 0x5A6B9C0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A6BA10
        public void CalculateSize(){} // RVA: 0x5A6BEA0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A6C620
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A6CB90
    }

    public class GeneratedClrTypeInfo
    {
        public string[] EmptyNames;
        public Google.Protobuf.Reflection.GeneratedClrTypeInfo[] EmptyCodeInfo; // 0x8
        public Google.Protobuf.Extension[] EmptyExtensions; // 0x10
        public System.Type <ClrType>k__BackingField; // 0x10
        public Google.Protobuf.MessageParser <Parser>k__BackingField; // 0x18
        public string[] <PropertyNames>k__BackingField; // 0x20
        public Google.Protobuf.Extension[] <Extensions>k__BackingField; // 0x28

        // ── Methods ──
        public void get_ClrType(){} // RVA: 0x2F8380
        public void set_ClrType(){} // RVA: 0x2DEE30
        public void get_Parser(){} // RVA: 0x2E07C0
        public void get_PropertyNames(){} // RVA: 0x30B0C0
        public void get_Extensions(){} // RVA: 0x30B130
        public void get_OneofNames(){} // RVA: 0x6374D0
        public void get_NestedTypes(){} // RVA: 0x4976A0
        public void get_NestedEnums(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x5A86BA0 | overloaded x2
        public void .cctor(){} // RVA: 0x5A86BE0
    }

    public class GeneratedCodeInfo
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.GeneratedCodeInfo> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Annotation> _repeated_annotation_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Annotation> annotation_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A7B320
        public void get_Descriptor(){} // RVA: 0x5A7B380
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A7B440
        public void .ctor(){} // RVA: 0x5A7B550 | overloaded x2
        public void Clone(){} // RVA: 0x5A7B6F0
        public void get_Annotation(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5A7B9C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5A7BA70
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A7BAC0
        public void CalculateSize(){} // RVA: 0x5A7BB80
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A7BD70
        public void .cctor(){} // RVA: 0x5A7BE70
    }

    public class IDescriptor
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_FullName(){} // RVA: 0xCD60
        public void get_File(){} // RVA: 0xCD60
    }

    public class IFieldAccessor
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0xCD60
        public void Clear(){} // RVA: 0x24B10
        public void GetValue(){} // RVA: 0xCE10
        public void HasValue(){} // RVA: 0xDE40
        public void SetValue(){} // RVA: 0x2DC60
    }

    public class MapFieldAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A86DC0
        public void Clear(){} // RVA: 0x5A86DD0
        public void HasValue(){} // RVA: 0x5A86E90
        public void SetValue(){} // RVA: 0x5A86EE0
    }

    public class MessageDescriptor
    {
        public System.Collections.Generic.HashSet`1<string> WellKnownTypeNames;
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder; // 0x30
        public System.Collections.Generic.IDictionary`2<string,Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap; // 0x38
        public Google.Protobuf.Reflection.DescriptorProto <Proto>k__BackingField; // 0x40
        public System.Type <ClrType>k__BackingField; // 0x48
        public Google.Protobuf.MessageParser <Parser>k__BackingField; // 0x50
        public Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField; // 0x58
        public FieldCollection <Fields>k__BackingField; // 0x60
        public Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField; // 0x68
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MessageDescriptor> <NestedTypes>k__BackingField; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A86F30
        public void CreateJsonFieldMap(){} // RVA: 0x5A87CC0
        public void get_Name(){} // RVA: 0x5A88050
        public void GetNestedDescriptorListForField(){} // RVA: 0x5A880C0
        public void get_Proto(){} // RVA: 0x35A740
        public void get_ClrType(){} // RVA: 0x358730
        public void get_Parser(){} // RVA: 0x37E0E0
        public void get_IsWellKnownType(){} // RVA: 0x5A881A0
        public void get_IsWrapperType(){} // RVA: 0x5A882B0
        public void get_Fields(){} // RVA: 0x37B370
        public void get_Extensions(){} // RVA: 0x358D50
        public void get_NestedTypes(){} // RVA: 0x3A5590
        public void get_EnumTypes(){} // RVA: 0x4C7C50
        public void get_Oneofs(){} // RVA: 0x462D00
        public void FindFieldByName(){} // RVA: 0x5A883A0
        public void FindFieldByNumber(){} // RVA: 0x5A88440
        public void CrossLink(){} // RVA: 0x5A885C0
        public void .cctor(){} // RVA: 0x5A88B80
    }

    public class MessageOptions
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
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A6D440
        public void get_Descriptor(){} // RVA: 0x5A6D4A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A6D560
        public void .ctor(){} // RVA: 0x5A6D710 | overloaded x2
        public void Clone(){} // RVA: 0x5A6D940
        public void get_MessageSetWireFormat(){} // RVA: 0x5A6D9A0
        public void set_MessageSetWireFormat(){} // RVA: 0x5A6DA10
        public void get_HasMessageSetWireFormat(){} // RVA: 0x5A69F80
        public void ClearMessageSetWireFormat(){} // RVA: 0x5A69F90
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x5A6DA20
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x5A6DA90
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x5A69DA0
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x5A69DB0
        public void get_Deprecated(){} // RVA: 0x5A6DAA0
        public void set_Deprecated(){} // RVA: 0x5A6DB10
        public void get_HasDeprecated(){} // RVA: 0x5A6A190
        public void ClearDeprecated(){} // RVA: 0x5A6A1A0
        public void get_MapEntry(){} // RVA: 0x5A6DB20
        public void set_MapEntry(){} // RVA: 0x5A6DB90
        public void get_HasMapEntry(){} // RVA: 0x5A6A230
        public void ClearMapEntry(){} // RVA: 0x5A6A240
        public void get_UninterpretedOption(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x5A6DC00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A6DD80
        public void ToString(){} // RVA: 0x5A6DEE0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A6DF30
        public void CalculateSize(){} // RVA: 0x5A6E0C0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A6E380
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A6E550
    }

    public class MethodDescriptor
    {
        public Google.Protobuf.Reflection.MethodDescriptorProto proto; // 0x28
        public Google.Protobuf.Reflection.ServiceDescriptor service; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A89310
        public void get_Proto(){} // RVA: 0x30B130
        public void get_Name(){} // RVA: 0x5A894C0
        public void CrossLink(){} // RVA: 0x5A89530
    }

    public class MethodDescriptorProto
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
        public void get_Parser(){} // RVA: 0x5A677E0
        public void get_Descriptor(){} // RVA: 0x5A67840
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A67900
        public void .ctor(){} // RVA: 0x5A679F0 | overloaded x2
        public void Clone(){} // RVA: 0x5A67C90
        public void get_Name(){} // RVA: 0x5A67CF0
        public void set_Name(){} // RVA: 0x5A67D60
        public void get_HasName(){} // RVA: 0x1E3EC10
        public void ClearName(){} // RVA: 0x5A57060
        public void get_InputType(){} // RVA: 0x5A67E60
        public void set_InputType(){} // RVA: 0x5A67ED0
        public void get_HasInputType(){} // RVA: 0x5A67FD0
        public void ClearInputType(){} // RVA: 0x29FDA70
        public void get_OutputType(){} // RVA: 0x5A67FE0
        public void set_OutputType(){} // RVA: 0x5A68050
        public void get_HasOutputType(){} // RVA: 0x51555E0
        public void ClearOutputType(){} // RVA: 0x5A68150
        public void get_Options(){} // RVA: 0x4976A0
        public void set_Options(){} // RVA: 0x49B830
        public void get_ClientStreaming(){} // RVA: 0x5A681B0
        public void set_ClientStreaming(){} // RVA: 0x5A68220
        public void get_HasClientStreaming(){} // RVA: 0x5A5C3B0
        public void ClearClientStreaming(){} // RVA: 0x5A5C3C0
        public void get_ServerStreaming(){} // RVA: 0x5A68230
        public void set_ServerStreaming(){} // RVA: 0x5A682A0
        public void get_HasServerStreaming(){} // RVA: 0x5A5C450
        public void ClearServerStreaming(){} // RVA: 0x5A5C460
        public void Equals(){} // RVA: 0x5A68310 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A68510
        public void ToString(){} // RVA: 0x5A68690
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A686E0
        public void CalculateSize(){} // RVA: 0x5A68810
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A68BA0
        public void .cctor(){} // RVA: 0x5A68D80
    }

    public class MethodOptions
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MethodOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.MethodOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool DeprecatedDefaultValue; // 0x8
        public bool deprecated_; // 0x24
        public 0x65950C08 IdempotencyLevelDefaultValue; // 0xC
        public 0x65950C08 idempotencyLevel_; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A74870
        public void get_Descriptor(){} // RVA: 0x5A748D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A74990
        public void .ctor(){} // RVA: 0x5A74B40 | overloaded x2
        public void Clone(){} // RVA: 0x5A74D60
        public void get_Deprecated(){} // RVA: 0x5A74DC0
        public void set_Deprecated(){} // RVA: 0x5A6DA10
        public void get_HasDeprecated(){} // RVA: 0x5A69F80
        public void ClearDeprecated(){} // RVA: 0x5A69F90
        public void get_IdempotencyLevel(){} // RVA: 0x5A74E30
        public void set_IdempotencyLevel(){} // RVA: 0x5A74EA0
        public void get_HasIdempotencyLevel(){} // RVA: 0x5A69DA0
        public void ClearIdempotencyLevel(){} // RVA: 0x5A69DB0
        public void get_UninterpretedOption(){} // RVA: 0x6374D0
        public void Equals(){} // RVA: 0x5A75020 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A75160
        public void ToString(){} // RVA: 0x5A75250
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A752A0
        public void CalculateSize(){} // RVA: 0x5A753E0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A756E0
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A75860
    }

    public class OneofAccessor
    {
        public System.Func`2<Google.Protobuf.IMessage,int> caseDelegate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A898E0
        public void ForRegularOneof(){} // RVA: 0x5A899E0
        public void ForSyntheticOneof(){} // RVA: 0x5A89BE0
        public void get_Descriptor(){} // RVA: 0x30B0C0
        public void Clear(){} // RVA: 0x9A9580
        public void GetCaseFieldDescriptor(){} // RVA: 0x5A89D70
    }

    public class OneofDescriptor
    {
        public Google.Protobuf.Reflection.MessageDescriptor containingType; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> fields; // 0x30
        public Google.Protobuf.Reflection.OneofAccessor accessor; // 0x38
        public Google.Protobuf.Reflection.OneofDescriptorProto <Proto>k__BackingField; // 0x40
        public bool <IsSynthetic>k__BackingField; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A89F30
        public void get_Name(){} // RVA: 0x5A8A260
        public void get_Proto(){} // RVA: 0x35A740
        public void get_ContainingType(){} // RVA: 0x30B130
        public void get_Fields(){} // RVA: 0x6374D0
        public void get_IsSynthetic(){} // RVA: 0x394D30
        public void get_Accessor(){} // RVA: 0x4976A0
        public void CrossLink(){} // RVA: 0x5A8A2D0
        public void CreateAccessor(){} // RVA: 0x5A8A640
    }

    public class OneofDescriptorProto
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.OneofDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public Google.Protobuf.Reflection.OneofOptions options_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A61400
        public void get_Descriptor(){} // RVA: 0x5A61460
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A61520
        public void .ctor(){} // RVA: 0x5A61610 | overloaded x2
        public void Clone(){} // RVA: 0x5A617F0
        public void get_Name(){} // RVA: 0x5A61850
        public void set_Name(){} // RVA: 0x5A618C0
        public void get_HasName(){} // RVA: 0x1D3B060
        public void ClearName(){} // RVA: 0x26AD280
        public void get_Options(){} // RVA: 0x30B0C0
        public void set_Options(){} // RVA: 0x30B0D0
        public void Equals(){} // RVA: 0x5A61B10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A61C20
        public void ToString(){} // RVA: 0x5A61CC0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A61D10
        public void CalculateSize(){} // RVA: 0x5A61D90
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A62180
        public void .cctor(){} // RVA: 0x5A62290
    }

    public class OneofOptions
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.OneofOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.OneofOptions> _extensions; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A70290
        public void get_Descriptor(){} // RVA: 0x5A702F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A703B0
        public void .ctor(){} // RVA: 0x5A70560 | overloaded x2
        public void Clone(){} // RVA: 0x5A70770
        public void get_UninterpretedOption(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x5A70910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A5E4D0
        public void ToString(){} // RVA: 0x5A70A00
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A70A50
        public void CalculateSize(){} // RVA: 0x5A70B40
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A70D80
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A70EB0
    }

    public class OriginalNameAttribute
    {
        public string <Name>k__BackingField; // 0x10
        public bool <PreferredAlias>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_PreferredAlias(){} // RVA: 0x2F84E0
        public void set_PreferredAlias(){} // RVA: 0x2F84F0
        public void .ctor(){} // RVA: 0x5A8AB80
    }

    public class PackageDescriptor
    {
        public string name; // 0x10
        public string fullName; // 0x18
        public Google.Protobuf.Reflection.FileDescriptor file; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A8AC80
        public void get_Name(){} // RVA: 0x2F8380
        public void get_FullName(){} // RVA: 0x2E07C0
        public void get_File(){} // RVA: 0x30B0C0
    }

    public class ReflectionUtil
    {
        public System.Type[] EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x5A8AD90
        public void ForceInitialize(){} // RVA: 0x24A80
        public void CreateFuncIMessageObject(){} // RVA: 0x5A8B2D0
        public void CreateFuncIMessageInt32(){} // RVA: 0x5A8B420
        public void CreateActionIMessageObject(){} // RVA: 0x5A8B550
        public void CreateActionIMessage(){} // RVA: 0x5A8B6D0
        public void CreateFuncIMessageBool(){} // RVA: 0x5A8B890
        public void CreateExtensionHelper(){} // RVA: 0x5A8B9E0
        public void GetReflectionHelper(){} // RVA: 0x5A8BCC0
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x5A8BEC0
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x5A8BF20
        public void SampleEnumMethod(){} // RVA: 0x519240
    }

    public class RepeatedFieldAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A86DC0
        public void Clear(){} // RVA: 0x5A8C130
        public void HasValue(){} // RVA: 0x5A8C1F0
        public void SetValue(){} // RVA: 0x5A8C240
    }

    public class ServiceDescriptor
    {
        public Google.Protobuf.Reflection.ServiceDescriptorProto proto; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A8C290
        public void get_Name(){} // RVA: 0x5A8C5F0
        public void GetNestedDescriptorListForField(){} // RVA: 0x5A8C660
        public void CrossLink(){} // RVA: 0x5A8C6D0
    }

    public class ServiceDescriptorProto
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ServiceDescriptorProto> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string NameDefaultValue; // 0x8
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.MethodDescriptorProto> _repeated_method_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.MethodDescriptorProto> method_; // 0x20
        public Google.Protobuf.Reflection.ServiceOptions options_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A66170
        public void get_Descriptor(){} // RVA: 0x5A661D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A66290
        public void .ctor(){} // RVA: 0x5A66440 | overloaded x2
        public void Clone(){} // RVA: 0x5A666C0
        public void get_Name(){} // RVA: 0x5A66720
        public void set_Name(){} // RVA: 0x5A66790
        public void get_HasName(){} // RVA: 0x1D3B060
        public void ClearName(){} // RVA: 0x26AD280
        public void get_Method(){} // RVA: 0x30B0C0
        public void get_Options(){} // RVA: 0x30B130
        public void set_Options(){} // RVA: 0x2DEE90
        public void Equals(){} // RVA: 0x5A66A20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A66B80
        public void ToString(){} // RVA: 0x5A66C40
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A66C90
        public void CalculateSize(){} // RVA: 0x5A66DA0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A67250
        public void .cctor(){} // RVA: 0x5A673E0
    }

    public class ServiceOptions
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ServiceOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.ServiceOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool DeprecatedDefaultValue; // 0x8
        public bool deprecated_; // 0x24
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5A736E0
        public void get_Descriptor(){} // RVA: 0x5A73740
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A73800
        public void .ctor(){} // RVA: 0x5A739B0 | overloaded x2
        public void Clone(){} // RVA: 0x5A73BC0
        public void get_Deprecated(){} // RVA: 0x5A73C20
        public void set_Deprecated(){} // RVA: 0x5A6DA10
        public void get_HasDeprecated(){} // RVA: 0x5A69F80
        public void ClearDeprecated(){} // RVA: 0x5A69F90
        public void get_UninterpretedOption(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x5A73DE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A73EF0
        public void ToString(){} // RVA: 0x5A73FC0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A74010
        public void CalculateSize(){} // RVA: 0x5A74130
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A74390
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5A744E0
    }

    public class SingleFieldAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A8CA90
        public void GetDefaultValue(){} // RVA: 0x5A8D610
        public void Clear(){} // RVA: 0x3329C00
        public void HasValue(){} // RVA: 0x5A8DBC0
        public void SetValue(){} // RVA: 0x5A8DBF0
    }

    public class SourceCodeInfo
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.SourceCodeInfo> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Location> _repeated_location_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Location> location_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5A78A30
        public void get_Descriptor(){} // RVA: 0x5A78A90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A78B50
        public void .ctor(){} // RVA: 0x5A78C60 | overloaded x2
        public void Clone(){} // RVA: 0x5A78E00
        public void get_Location(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5A790D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5A79180
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A791D0
        public void CalculateSize(){} // RVA: 0x5A79290
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A79480
        public void .cctor(){} // RVA: 0x5A79580
    }

    public class TypeRegistry
    {
        public Google.Protobuf.Reflection.TypeRegistry <Empty>k__BackingField;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x5A8DEF0
        public void .ctor(){} // RVA: 0x2DEE30
        public void Find(){} // RVA: 0x5A8DF50
        public void .cctor(){} // RVA: 0x5A8DFC0
    }

    public class UninterpretedOption
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
        public void get_Parser(){} // RVA: 0x5A75C00
        public void get_Descriptor(){} // RVA: 0x5A75C60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A75D20
        public void .ctor(){} // RVA: 0x5A75E30 | overloaded x2
        public void Clone(){} // RVA: 0x5A760D0
        public void get_Name(){} // RVA: 0x30B0C0
        public void get_IdentifierValue(){} // RVA: 0x5A76130
        public void set_IdentifierValue(){} // RVA: 0x5A761A0
        public void get_HasIdentifierValue(){} // RVA: 0x5A67FD0
        public void ClearIdentifierValue(){} // RVA: 0x29FDA70
        public void get_PositiveIntValue(){} // RVA: 0x5A762A0
        public void set_PositiveIntValue(){} // RVA: 0x5A76310
        public void get_HasPositiveIntValue(){} // RVA: 0x5A5C3B0
        public void ClearPositiveIntValue(){} // RVA: 0x5A5C3C0
        public void get_NegativeIntValue(){} // RVA: 0x5A76320
        public void set_NegativeIntValue(){} // RVA: 0x5A76390
        public void get_HasNegativeIntValue(){} // RVA: 0x5A5C450
        public void ClearNegativeIntValue(){} // RVA: 0x5A5C460
        public void get_DoubleValue(){} // RVA: 0x5A763A0
        public void set_DoubleValue(){} // RVA: 0x5A76410
        public void get_HasDoubleValue(){} // RVA: 0x5A5F650
        public void ClearDoubleValue(){} // RVA: 0x5A5F660
        public void get_StringValue(){} // RVA: 0x5A76420
        public void set_StringValue(){} // RVA: 0x5A76490
        public void get_HasStringValue(){} // RVA: 0x5A76590
        public void ClearStringValue(){} // RVA: 0x5A5FB30
        public void get_AggregateValue(){} // RVA: 0x5A76650
        public void set_AggregateValue(){} // RVA: 0x5A766C0
        public void get_HasAggregateValue(){} // RVA: 0x51563C0
        public void ClearAggregateValue(){} // RVA: 0x4AED90
        public void Equals(){} // RVA: 0x5A76820 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A76A90
        public void ToString(){} // RVA: 0x5A76C40
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A76C90
        public void CalculateSize(){} // RVA: 0x5A76E60
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A772A0
        public void .cctor(){} // RVA: 0x5A774B0
    }

}