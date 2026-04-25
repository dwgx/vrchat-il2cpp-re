// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 49
// Methods: 944

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorBase : Object
    {
        public int Name; // 0x10
        public string FullName; // 0x18
        public Google.Protobuf.Reflection.FileDescriptor File; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8214AA0
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_FullName(){} // RVA: 0x7FFAC2F247C0
        public void get_File(){} // RVA: 0x7FFAC2F4F0C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAC34F9180
    }

    public class DescriptorDeclaration : Object
    {
        public Google.Protobuf.Reflection.IDescriptor StartLine; // 0x10
        public int <StartLine>k__BackingField; // 0x18
        public int <StartColumn>k__BackingField; // 0x1C
        public int <EndLine>k__BackingField; // 0x20
        public int <EndColumn>k__BackingField; // 0x24
        public string <LeadingComments>k__BackingField; // 0x28
        public string <TrailingComments>k__BackingField; // 0x30
        public System.Collections.Generic.IReadOnlyList`1<string> <LeadingDetachedComments>k__BackingField; // 0x38

        // ── Methods ──
        public void get_StartLine(){} // RVA: 0x7FFAC3157800
        public void .ctor(){} // RVA: 0x7FFAC8214B60
        public void FromProto(){} // RVA: 0x7FFAC82150A0
    }

    public class DescriptorPool : Object
    {
        public System.Collections.Generic.IDictionary`2<string,Google.Protobuf.Reflection.IDescriptor> descriptorsByName; // 0x10
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.ObjectIntPair`1<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.FieldDescriptor> fieldsByNumber; // 0x18
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.ObjectIntPair`1<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.EnumValueDescriptor> enumValuesByNumber; // 0x20
        public System.Collections.Generic.HashSet`1<Google.Protobuf.Reflection.FileDescriptor> dependencies; // 0x28
        public System.Text.RegularExpressions.Regex ValidationRegex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8215110
        public void ImportPublicDependencies(){} // RVA: 0x7FFAC82157D0
        public void FindSymbol(){} // RVA: 0x7FFAC2E8DC40
        public void AddPackage(){} // RVA: 0x7FFAC8215A00
        public void AddSymbol(){} // RVA: 0x7FFAC8215E00
        public void ValidateSymbolName(){} // RVA: 0x7FFAC8216220
        public void FindFieldByNumber(){} // RVA: 0x7FFAC82164A0
        public void AddFieldByNumber(){} // RVA: 0x7FFAC8216600
        public void AddEnumValueByNumber(){} // RVA: 0x7FFAC8216A20
        public void LookupSymbol(){} // RVA: 0x7FFAC8216C70
        public void .cctor(){} // RVA: 0x7FFAC8216F60
    }

    public class DescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.DescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string Name; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FieldDescriptorProto> HasName; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FieldDescriptorProto> Field; // 0x20
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FieldDescriptorProto> Extension; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FieldDescriptorProto> NestedType; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.DescriptorProto> EnumType; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.DescriptorProto> ExtensionRange; // 0x30
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.EnumDescriptorProto> OneofDecl; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.EnumDescriptorProto> Options; // 0x38
        public Google.Protobuf.FieldCodec`1<ExtensionRange> ReservedRange; // 0x30
        public Google.Protobuf.Collections.RepeatedField`1<ExtensionRange> ReservedName; // 0x40
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.OneofDescriptorProto> oneofDecl_; // 0x48
        public Google.Protobuf.Reflection.MessageOptions options_; // 0x50
        public Google.Protobuf.FieldCodec`1<ReservedRange> _repeated_reservedRange_codec; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<ReservedRange> reservedRange_; // 0x58
        public Google.Protobuf.FieldCodec`1<string> _repeated_reservedName_codec; // 0x48
        public Google.Protobuf.Collections.RepeatedField`1<string> reservedName_; // 0x60

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81F0740
        public void get_Descriptor(){} // RVA: 0x7FFAC81F07A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F0860
        public void .ctor(){} // RVA: 0x7FFAC81F0D60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81F1350
        public void get_Name(){} // RVA: 0x7FFAC81F13B0
        public void set_Name(){} // RVA: 0x7FFAC81F1420
        public void get_HasName(){} // RVA: 0x7FFAC4860B40
        public void ClearName(){} // RVA: 0x7FFAC515CC20
        public void get_Field(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Extension(){} // RVA: 0x7FFAC2F4F130
        public void get_NestedType(){} // RVA: 0x7FFAC31D95E0
        public void get_EnumType(){} // RVA: 0x7FFAC31D0140
        public void get_ExtensionRange(){} // RVA: 0x7FFAC2F9E740
        public void get_OneofDecl(){} // RVA: 0x7FFAC2F9C730
        public void get_Options(){} // RVA: 0x7FFAC2FC20E0
        public void set_Options(){} // RVA: 0x7FFAC30794D0
        public void get_ReservedRange(){} // RVA: 0x7FFAC2FE9500
        public void get_ReservedName(){} // RVA: 0x7FFAC2FBF370
        public void Equals(){} // RVA: 0x7FFAC81F1580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81F1850
        public void ToString(){} // RVA: 0x7FFAC81F1A20
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81F1A70
        public void CalculateSize(){} // RVA: 0x7FFAC81F1D40
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F23F0
        public void .cctor(){} // RVA: 0x7FFAC81F2860
    }

    public class DescriptorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC81E7E80
        public void .cctor(){} // RVA: 0x7FFAC81E7EE0
    }

    public class DescriptorUtil : Object
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x7FFAC2C58FF0
    }

    public class DescriptorValidationException : Exception
    {
        public string name; // 0x90
        public string description; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8217080
    }

    public class EnumDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.EnumDescriptorProto Name; // 0x28
        public Google.Protobuf.Reflection.MessageDescriptor Values; // 0x30
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.EnumValueDescriptor> values; // 0x38
        public System.Type clrType; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8217220
        public void get_Name(){} // RVA: 0x7FFAC8217690
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAC8217700
        public void get_Values(){} // RVA: 0x7FFAC31D0140
    }

    public class EnumDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string Name; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.EnumValueDescriptorProto> HasName; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.EnumValueDescriptorProto> Value; // 0x20
        public Google.Protobuf.Reflection.EnumOptions Options; // 0x28
        public Google.Protobuf.FieldCodec`1<EnumReservedRange> ReservedRange; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<EnumReservedRange> ReservedName; // 0x30
        public Google.Protobuf.FieldCodec`1<string> _repeated_reservedName_codec; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<string> reservedName_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81F9940
        public void get_Descriptor(){} // RVA: 0x7FFAC81F99A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F9A60
        public void .ctor(){} // RVA: 0x7FFAC81F9CA0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81FA020
        public void get_Name(){} // RVA: 0x7FFAC81FA080
        public void set_Name(){} // RVA: 0x7FFAC81FA0F0
        public void get_HasName(){} // RVA: 0x7FFAC4860B40
        public void ClearName(){} // RVA: 0x7FFAC515CC20
        public void get_Value(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void set_Options(){} // RVA: 0x7FFAC2F22E90
        public void get_ReservedRange(){} // RVA: 0x7FFAC31D95E0
        public void get_ReservedName(){} // RVA: 0x7FFAC31D0140
        public void Equals(){} // RVA: 0x7FFAC81FA250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81FA420
        public void ToString(){} // RVA: 0x7FFAC81FA530
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81FA580
        public void CalculateSize(){} // RVA: 0x7FFAC81FA720
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81FAB80
        public void .cctor(){} // RVA: 0x7FFAC81FADE0
    }

    public class EnumOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.EnumOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool AllowAlias; // 0x8
        public bool HasAllowAlias; // 0x24
        public bool Deprecated; // 0x9
        public bool HasDeprecated; // 0x25
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC8208650
        public void get_Descriptor(){} // RVA: 0x7FFAC82086B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8208770
        public void .ctor(){} // RVA: 0x7FFAC8208920 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8208B40
        public void get_AllowAlias(){} // RVA: 0x7FFAC8208BA0
        public void set_AllowAlias(){} // RVA: 0x7FFAC8204E30
        public void get_HasAllowAlias(){} // RVA: 0x7FFAC8201340
        public void ClearAllowAlias(){} // RVA: 0x7FFAC8201350
        public void get_Deprecated(){} // RVA: 0x7FFAC8208C10
        public void set_Deprecated(){} // RVA: 0x7FFAC8204EB0
        public void get_HasDeprecated(){} // RVA: 0x7FFAC8201160
        public void ClearDeprecated(){} // RVA: 0x7FFAC8201170
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC8208DF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8208F30
        public void ToString(){} // RVA: 0x7FFAC8209040
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8209090
        public void CalculateSize(){} // RVA: 0x7FFAC82091D0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8209460
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC82095E0
    }

    public class EnumValueDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.EnumDescriptor Proto; // 0x28
        public Google.Protobuf.Reflection.EnumValueDescriptorProto Name; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8217810
        public void get_Proto(){} // RVA: 0x7FFAC31D95E0
        public void get_Name(){} // RVA: 0x7FFAC82179D0
        public void get_Number(){} // RVA: 0x7FFAC8217A40
        public void get_EnumDescriptor(){} // RVA: 0x7FFAC2F4F130
    }

    public class EnumValueDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumValueDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public string Name; // 0x8
        public string HasName; // 0x20
        public int Number; // 0x10
        public int HasNumber; // 0x28
        public Google.Protobuf.Reflection.EnumValueOptions Options; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81FBE70
        public void get_Descriptor(){} // RVA: 0x7FFAC81FBED0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81FBF90
        public void .ctor(){} // RVA: 0x7FFAC81FC080 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81FC270
        public void get_Name(){} // RVA: 0x7FFAC81FC2D0
        public void set_Name(){} // RVA: 0x7FFAC81FC340
        public void get_HasName(){} // RVA: 0x7FFAC495C6A0
        public void ClearName(){} // RVA: 0x7FFAC81EE480
        public void get_Number(){} // RVA: 0x7FFAC81FC440
        public void set_Number(){} // RVA: 0x7FFAC81F6900
        public void get_HasNumber(){} // RVA: 0x7FFAC81F3770
        public void ClearNumber(){} // RVA: 0x7FFAC81F3780
        public void get_Options(){} // RVA: 0x7FFAC31D95E0
        public void set_Options(){} // RVA: 0x7FFAC2F4F890
        public void Equals(){} // RVA: 0x7FFAC81FC610 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81FC740
        public void ToString(){} // RVA: 0x7FFAC81FC7F0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81FC840
        public void CalculateSize(){} // RVA: 0x7FFAC81FC8F0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81FCD40
        public void .cctor(){} // RVA: 0x7FFAC81FCE70
    }

    public class EnumValueOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.EnumValueOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.EnumValueOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool Deprecated; // 0x8
        public bool HasDeprecated; // 0x24
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC8209980
        public void get_Descriptor(){} // RVA: 0x7FFAC82099E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8209AA0
        public void .ctor(){} // RVA: 0x7FFAC8209C50 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8209E60
        public void get_Deprecated(){} // RVA: 0x7FFAC8209EC0
        public void set_Deprecated(){} // RVA: 0x7FFAC8204E30
        public void get_HasDeprecated(){} // RVA: 0x7FFAC8201340
        public void ClearDeprecated(){} // RVA: 0x7FFAC8201350
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC820A080 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC820A190
        public void ToString(){} // RVA: 0x7FFAC820A260
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC820A2B0
        public void CalculateSize(){} // RVA: 0x7FFAC820A3C0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC820A620
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC820A770
    }

    public class ExtensionAccessor : Object
    {
        public Google.Protobuf.Extension Descriptor; // 0x10
        public IExtensionReflectionHelper helper; // 0x18
        public Google.Protobuf.Reflection.FieldDescriptor <Descriptor>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8217A60
        public void get_Descriptor(){} // RVA: 0x7FFAC2F4F0C0
        public void Clear(){} // RVA: 0x7FFAC8217BD0
        public void HasValue(){} // RVA: 0x7FFAC8217C30
        public void GetValue(){} // RVA: 0x7FFAC8217C90
        public void SetValue(){} // RVA: 0x7FFAC8217CF0
    }

    public class ExtensionCollection : Object
    {
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor>> UnorderedExtensions; // 0x10
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInNumberOrder; // 0x18
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> <UnorderedExtensions>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8217F60 | overloaded x2
        public void get_UnorderedExtensions(){} // RVA: 0x7FFAC2F4F0C0
        public void CrossLink(){} // RVA: 0x7FFAC8218150
    }

    public class ExtensionRangeOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ExtensionRangeOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.ExtensionRangeOptions> Descriptor; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC81F5120
        public void get_Descriptor(){} // RVA: 0x7FFAC81F5180
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F5240
        public void .ctor(){} // RVA: 0x7FFAC81F53F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81F5600
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFAC81F57A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81F5890
        public void ToString(){} // RVA: 0x7FFAC81F5920
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81F5970
        public void CalculateSize(){} // RVA: 0x7FFAC81F5A60
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F5CA0
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC81F5DD0
    }

    public class FieldAccessorBase : Object
    {
        public System.Func`2<Google.Protobuf.IMessage,object> Descriptor; // 0x10
        public Google.Protobuf.Reflection.FieldDescriptor descriptor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8219100
        public void get_Descriptor(){} // RVA: 0x7FFAC2F247C0
        public void GetValue(){} // RVA: 0x7FFAC7793490
        public void HasValue(){} // RVA: 0x7FFAC2C59F60
        public void Clear(){} // RVA: 0x7FFAC2C70A40
        public void SetValue(){} // RVA: 0x7FFAC2C79B30
    }

    public class FieldDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.EnumDescriptor ContainingType; // 0x28
        public Google.Protobuf.Reflection.MessageDescriptor ContainingOneof; // 0x30
        public Google.Protobuf.Reflection.MessageDescriptor RealContainingOneof; // 0x38
        public 0x6B231718 JsonName; // 0x40
        public Google.Protobuf.Reflection.IFieldAccessor PropertyName; // 0x48
        public Google.Protobuf.Reflection.MessageDescriptor HasPresence; // 0x50
        public Google.Protobuf.Reflection.OneofDescriptor Proto; // 0x58
        public string Extension; // 0x60
        public string Name; // 0x68
        public Google.Protobuf.Reflection.FieldDescriptorProto Accessor; // 0x70
        public Google.Protobuf.Extension IsRepeated; // 0x78

        // ── Methods ──
        public void get_ContainingType(){} // RVA: 0x7FFAC2FC20E0
        public void get_ContainingOneof(){} // RVA: 0x7FFAC2FE9500
        public void get_RealContainingOneof(){} // RVA: 0x7FFAC8219350
        public void get_JsonName(){} // RVA: 0x7FFAC2FBF370
        public void get_PropertyName(){} // RVA: 0x7FFAC2F9CD50
        public void get_HasPresence(){} // RVA: 0x7FFAC8219370
        public void get_Proto(){} // RVA: 0x7FFAC2FE9590
        public void get_Extension(){} // RVA: 0x7FFAC30E5600
        public void .ctor(){} // RVA: 0x7FFAC8219420
        public void get_Name(){} // RVA: 0x7FFAC8219BC0
        public void get_Accessor(){} // RVA: 0x7FFAC2F9C730
        public void GetFieldTypeFromProtoType(){} // RVA: 0x7FFAC8219C30
        public void get_IsRepeated(){} // RVA: 0x7FFAC8219DA0
        public void get_IsMap(){} // RVA: 0x7FFAC8219DD0
        public void get_FieldType(){} // RVA: 0x7FFAC2FC2080
        public void get_FieldNumber(){} // RVA: 0x7FFAC8219E10
        public void CompareTo(){} // RVA: 0x7FFAC8219E30
        public void get_MessageType(){} // RVA: 0x7FFAC8219ED0
        public void get_ExtendeeType(){} // RVA: 0x7FFAC8219F40
        public void CrossLink(){} // RVA: 0x7FFAC8219FC0
        public void CreateAccessor(){} // RVA: 0x7FFAC821A5F0
    }

    public class FieldDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FieldDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public string Name; // 0x8
        public string HasName; // 0x20
        public int Number; // 0x10
        public int HasNumber; // 0x28
        public 0x6B22FEB0 Label; // 0x14
        public 0x6B22FEB0 HasLabel; // 0x2C
        public 0x6B22FE58 Type; // 0x18
        public 0x6B22FE58 HasType; // 0x30
        public string TypeName; // 0x20
        public string HasTypeName; // 0x38
        public string Extendee; // 0x28
        public string HasExtendee; // 0x40
        public string DefaultValue; // 0x30
        public string HasDefaultValue; // 0x48
        public int OneofIndex; // 0x38
        public int HasOneofIndex; // 0x50
        public string JsonName; // 0x40
        public string HasJsonName; // 0x58
        public Google.Protobuf.Reflection.FieldOptions Options; // 0x60
        public bool Proto3Optional; // 0x48
        public bool HasProto3Optional; // 0x68

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81F6150
        public void get_Descriptor(){} // RVA: 0x7FFAC81F61B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F6270
        public void .ctor(){} // RVA: 0x7FFAC81F6360 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81F66C0
        public void get_Name(){} // RVA: 0x7FFAC81F6720
        public void set_Name(){} // RVA: 0x7FFAC81F6790
        public void get_HasName(){} // RVA: 0x7FFAC495C6A0
        public void ClearName(){} // RVA: 0x7FFAC81EE480
        public void get_Number(){} // RVA: 0x7FFAC81F6890
        public void set_Number(){} // RVA: 0x7FFAC81F6900
        public void get_HasNumber(){} // RVA: 0x7FFAC81F3770
        public void ClearNumber(){} // RVA: 0x7FFAC81F3780
        public void get_Label(){} // RVA: 0x7FFAC81F6910
        public void set_Label(){} // RVA: 0x7FFAC81F6980
        public void get_HasLabel(){} // RVA: 0x7FFAC81F3810
        public void ClearLabel(){} // RVA: 0x7FFAC81F3820
        public void get_Type(){} // RVA: 0x7FFAC81F6990
        public void set_Type(){} // RVA: 0x7FFAC81F6A00
        public void get_HasType(){} // RVA: 0x7FFAC81F6A10
        public void ClearType(){} // RVA: 0x7FFAC81F6A20
        public void get_TypeName(){} // RVA: 0x7FFAC81F6A30
        public void set_TypeName(){} // RVA: 0x7FFAC81F6AA0
        public void get_HasTypeName(){} // RVA: 0x7FFAC484B3D0
        public void ClearTypeName(){} // RVA: 0x7FFAC3BB6540
        public void get_Extendee(){} // RVA: 0x7FFAC81F6BA0
        public void set_Extendee(){} // RVA: 0x7FFAC81F6C10
        public void get_HasExtendee(){} // RVA: 0x7FFAC781E0B0
        public void ClearExtendee(){} // RVA: 0x7FFAC81F6D10
        public void get_DefaultValue(){} // RVA: 0x7FFAC81F6D70
        public void set_DefaultValue(){} // RVA: 0x7FFAC81F6DE0
        public void get_HasDefaultValue(){} // RVA: 0x7FFAC81F6EE0
        public void ClearDefaultValue(){} // RVA: 0x7FFAC81F6EF0
        public void get_OneofIndex(){} // RVA: 0x7FFAC81F6F50
        public void set_OneofIndex(){} // RVA: 0x7FFAC81F6FC0
        public void get_HasOneofIndex(){} // RVA: 0x7FFAC81F6FD0
        public void ClearOneofIndex(){} // RVA: 0x7FFAC81F6FE0
        public void get_JsonName(){} // RVA: 0x7FFAC81F6FF0
        public void set_JsonName(){} // RVA: 0x7FFAC81F7060
        public void get_HasJsonName(){} // RVA: 0x7FFAC781EE50
        public void ClearJsonName(){} // RVA: 0x7FFAC81F7160
        public void get_Options(){} // RVA: 0x7FFAC2FBF370
        public void set_Options(){} // RVA: 0x7FFAC2FBF380
        public void get_Proto3Optional(){} // RVA: 0x7FFAC81F71C0
        public void set_Proto3Optional(){} // RVA: 0x7FFAC81F7230
        public void get_HasProto3Optional(){} // RVA: 0x7FFAC81F7240
        public void ClearProto3Optional(){} // RVA: 0x7FFAC81F7250
        public void Equals(){} // RVA: 0x7FFAC81F72C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81F75D0
        public void ToString(){} // RVA: 0x7FFAC81F77D0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81F7820
        public void CalculateSize(){} // RVA: 0x7FFAC81F7A30
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F7FF0
        public void .cctor(){} // RVA: 0x7FFAC81F82B0
    }

    public class FieldOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FieldOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.FieldOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public 0x6B230698 Ctype; // 0x8
        public 0x6B230698 HasCtype; // 0x24
        public bool Packed; // 0xC
        public bool HasPacked; // 0x28
        public 0x6B2306F0 Jstype; // 0x10
        public 0x6B2306F0 HasJstype; // 0x2C
        public bool Lazy; // 0x14
        public bool HasLazy; // 0x30
        public bool UnverifiedLazy; // 0x15
        public bool HasUnverifiedLazy; // 0x31
        public bool Deprecated; // 0x16
        public bool HasDeprecated; // 0x32
        public bool Weak; // 0x17
        public bool HasWeak; // 0x33
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x38

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC8205D30
        public void get_Descriptor(){} // RVA: 0x7FFAC8205D90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8205E50
        public void .ctor(){} // RVA: 0x7FFAC8206000 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8206240
        public void get_Ctype(){} // RVA: 0x7FFAC82062A0
        public void set_Ctype(){} // RVA: 0x7FFAC8206310
        public void get_HasCtype(){} // RVA: 0x7FFAC8201340
        public void ClearCtype(){} // RVA: 0x7FFAC8201350
        public void get_Packed(){} // RVA: 0x7FFAC8206320
        public void set_Packed(){} // RVA: 0x7FFAC8206390
        public void get_HasPacked(){} // RVA: 0x7FFAC8201160
        public void ClearPacked(){} // RVA: 0x7FFAC8201170
        public void get_Jstype(){} // RVA: 0x7FFAC82063A0
        public void set_Jstype(){} // RVA: 0x7FFAC8206410
        public void get_HasJstype(){} // RVA: 0x7FFAC8201690
        public void ClearJstype(){} // RVA: 0x7FFAC82016A0
        public void get_Lazy(){} // RVA: 0x7FFAC8206420
        public void set_Lazy(){} // RVA: 0x7FFAC8206490
        public void get_HasLazy(){} // RVA: 0x7FFAC82015F0
        public void ClearLazy(){} // RVA: 0x7FFAC8201600
        public void get_UnverifiedLazy(){} // RVA: 0x7FFAC82064A0
        public void set_UnverifiedLazy(){} // RVA: 0x7FFAC8206510
        public void get_HasUnverifiedLazy(){} // RVA: 0x7FFAC82017D0
        public void ClearUnverifiedLazy(){} // RVA: 0x7FFAC82017E0
        public void get_Deprecated(){} // RVA: 0x7FFAC8206520
        public void set_Deprecated(){} // RVA: 0x7FFAC8206590
        public void get_HasDeprecated(){} // RVA: 0x7FFAC8201550
        public void ClearDeprecated(){} // RVA: 0x7FFAC8201560
        public void get_Weak(){} // RVA: 0x7FFAC82065A0
        public void set_Weak(){} // RVA: 0x7FFAC8206610
        public void get_HasWeak(){} // RVA: 0x7FFAC8201200
        public void ClearWeak(){} // RVA: 0x7FFAC8201210
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC31D0140
        public void Equals(){} // RVA: 0x7FFAC8206680 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8206860
        public void ToString(){} // RVA: 0x7FFAC8206A10
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8206A60
        public void CalculateSize(){} // RVA: 0x7FFAC8206C70
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8207070
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC82072C0
    }

    public class FileDescriptor : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>> Proto; // 0x10
        public Google.Protobuf.Reflection.FileDescriptorProto Syntax; // 0x18
        public 0x6B231770 Name; // 0x20
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MessageDescriptor> Package; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.EnumDescriptor> MessageTypes; // 0x30
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.ServiceDescriptor> EnumTypes; // 0x38
        public Google.Protobuf.Reflection.ExtensionCollection Services; // 0x40
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FileDescriptor> Extensions; // 0x48
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FileDescriptor> Dependencies; // 0x50
        public Google.Protobuf.ByteString PublicDependencies; // 0x58
        public Google.Protobuf.Reflection.DescriptorPool Google.Protobuf.Reflection.IDescriptor.FullName; // 0x60

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC821A9B0
        public void .ctor(){} // RVA: 0x7FFAC821AA60
        public void CreateDeclarationMap(){} // RVA: 0x7FFAC821B3E0
        public void FindDescriptorForPath(){} // RVA: 0x7FFAC821B6D0
        public void GetDescriptorFromList(){} // RVA: 0x7FFAC821BA80
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAC821BBC0
        public void ComputeFullName(){} // RVA: 0x7FFAC821BCA0
        public void DeterminePublicDependencies(){} // RVA: 0x7FFAC821BD40
        public void get_Proto(){} // RVA: 0x7FFAC2F247C0
        public void get_Syntax(){} // RVA: 0x7FFAC30DBBE0
        public void get_Name(){} // RVA: 0x7FFAC821C190
        public void get_Package(){} // RVA: 0x7FFAC821C200
        public void get_MessageTypes(){} // RVA: 0x7FFAC2F4F130
        public void get_EnumTypes(){} // RVA: 0x7FFAC31D95E0
        public void get_Services(){} // RVA: 0x7FFAC31D0140
        public void get_Extensions(){} // RVA: 0x7FFAC2F9E740
        public void get_Dependencies(){} // RVA: 0x7FFAC2F9C730
        public void get_PublicDependencies(){} // RVA: 0x7FFAC2FC20E0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x7FFAC821C270
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x7FFAC44F81E0
        public void get_DescriptorPool(){} // RVA: 0x7FFAC2FBF370
        public void BuildFrom(){} // RVA: 0x7FFAC821C280
        public void CrossLink(){} // RVA: 0x7FFAC821C410
        public void FromGeneratedCode(){} // RVA: 0x7FFAC821C7C0
        public void GetAllExtensions(){} // RVA: 0x7FFAC821CD90
        public void GetAllGeneratedExtensions(){} // RVA: 0x7FFAC821CF30
        public void GetAllDependedExtensions(){} // RVA: 0x7FFAC821D150
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x7FFAC821D560
        public void ToString(){} // RVA: 0x7FFAC821D8D0
        public void ForceReflectionInitialization(){} // RVA: 0x7FFAC2C709B0
    }

    public class FileDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string Name; // 0x18
        public string HasName; // 0x10
        public string Package; // 0x20
        public Google.Protobuf.FieldCodec`1<string> HasPackage; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<string> Dependency; // 0x28
        public Google.Protobuf.FieldCodec`1<int> PublicDependency; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<int> WeakDependency; // 0x30
        public Google.Protobuf.FieldCodec`1<int> MessageType; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<int> EnumType; // 0x38
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.DescriptorProto> Service; // 0x30
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.DescriptorProto> Extension; // 0x40
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.EnumDescriptorProto> Options; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.EnumDescriptorProto> SourceCodeInfo; // 0x48
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.ServiceDescriptorProto> Syntax; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.ServiceDescriptorProto> HasSyntax; // 0x50
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec; // 0x48
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FieldDescriptorProto> extension_; // 0x58
        public Google.Protobuf.Reflection.FileOptions options_; // 0x60
        public Google.Protobuf.Reflection.SourceCodeInfo sourceCodeInfo_; // 0x68
        public string SyntaxDefaultValue; // 0x50
        public string syntax_; // 0x70

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81ED4A0
        public void get_Descriptor(){} // RVA: 0x7FFAC81ED500
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81ED5C0
        public void .ctor(){} // RVA: 0x7FFAC81EDAD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81EE140
        public void get_Name(){} // RVA: 0x7FFAC81EE1A0
        public void set_Name(){} // RVA: 0x7FFAC81EE210
        public void get_HasName(){} // RVA: 0x7FFAC4860B40
        public void ClearName(){} // RVA: 0x7FFAC515CC20
        public void get_Package(){} // RVA: 0x7FFAC81EE310
        public void set_Package(){} // RVA: 0x7FFAC81EE380
        public void get_HasPackage(){} // RVA: 0x7FFAC495C6A0
        public void ClearPackage(){} // RVA: 0x7FFAC81EE480
        public void get_Dependency(){} // RVA: 0x7FFAC2F4F130
        public void get_PublicDependency(){} // RVA: 0x7FFAC31D95E0
        public void get_WeakDependency(){} // RVA: 0x7FFAC31D0140
        public void get_MessageType(){} // RVA: 0x7FFAC2F9E740
        public void get_EnumType(){} // RVA: 0x7FFAC2F9C730
        public void get_Service(){} // RVA: 0x7FFAC2FC20E0
        public void get_Extension(){} // RVA: 0x7FFAC2FE9500
        public void get_Options(){} // RVA: 0x7FFAC2FBF370
        public void set_Options(){} // RVA: 0x7FFAC2FBF380
        public void get_SourceCodeInfo(){} // RVA: 0x7FFAC2F9CD50
        public void set_SourceCodeInfo(){} // RVA: 0x7FFAC2F9CD60
        public void get_Syntax(){} // RVA: 0x7FFAC81EE4E0
        public void set_Syntax(){} // RVA: 0x7FFAC81EE550
        public void get_HasSyntax(){} // RVA: 0x7FFAC81EE650
        public void ClearSyntax(){} // RVA: 0x7FFAC44CB460
        public void Equals(){} // RVA: 0x7FFAC81EE6C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81EEA40
        public void ToString(){} // RVA: 0x7FFAC81EEC70
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81EECC0
        public void CalculateSize(){} // RVA: 0x7FFAC81EEFC0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81EF8C0
        public void .cctor(){} // RVA: 0x7FFAC81EFDB0
    }

    public class FileDescriptorSet : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileDescriptorSet> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.FileDescriptorProto> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.FileDescriptorProto> File; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81EC530
        public void get_Descriptor(){} // RVA: 0x7FFAC81EC590
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81EC650
        public void .ctor(){} // RVA: 0x7FFAC81EC800 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81EC9A0
        public void get_File(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC81ECC70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC81ECD20
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81ECD70
        public void CalculateSize(){} // RVA: 0x7FFAC81ECE30
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81ED020
        public void .cctor(){} // RVA: 0x7FFAC81ED120
    }

    public class FileOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.FileOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.FileOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public string JavaPackage; // 0x8
        public string HasJavaPackage; // 0x28
        public string JavaOuterClassname; // 0x10
        public string HasJavaOuterClassname; // 0x30
        public bool JavaMultipleFiles; // 0x18
        public bool HasJavaMultipleFiles; // 0x38
        public bool JavaGenerateEqualsAndHash; // 0x19
        public bool HasJavaGenerateEqualsAndHash; // 0x39
        public bool JavaStringCheckUtf8; // 0x1A
        public bool HasJavaStringCheckUtf8; // 0x3A
        public 0x6B230488 OptimizeFor; // 0x1C
        public 0x6B230488 HasOptimizeFor; // 0x3C
        public string GoPackage; // 0x20
        public string HasGoPackage; // 0x40
        public bool CcGenericServices; // 0x28
        public bool HasCcGenericServices; // 0x48
        public bool JavaGenericServices; // 0x29
        public bool HasJavaGenericServices; // 0x49
        public bool PyGenericServices; // 0x2A
        public bool HasPyGenericServices; // 0x4A
        public bool PhpGenericServices; // 0x2B
        public bool HasPhpGenericServices; // 0x4B
        public bool Deprecated; // 0x2C
        public bool HasDeprecated; // 0x4C
        public bool CcEnableArenas; // 0x2D
        public bool HasCcEnableArenas; // 0x4D
        public string ObjcClassPrefix; // 0x30
        public string HasObjcClassPrefix; // 0x50
        public string CsharpNamespace; // 0x38
        public string HasCsharpNamespace; // 0x58
        public string SwiftPrefix; // 0x40
        public string HasSwiftPrefix; // 0x60
        public string PhpClassPrefix; // 0x48
        public string HasPhpClassPrefix; // 0x68
        public string PhpNamespace; // 0x50
        public string HasPhpNamespace; // 0x70
        public string PhpMetadataNamespace; // 0x58
        public string HasPhpMetadataNamespace; // 0x78
        public string RubyPackage; // 0x60
        public string HasRubyPackage; // 0x80
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x68
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x88

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC8200530
        public void get_Descriptor(){} // RVA: 0x7FFAC8200590
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8200650
        public void .ctor(){} // RVA: 0x7FFAC8200800 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8200DA0
        public void get_JavaPackage(){} // RVA: 0x7FFAC8200E00
        public void set_JavaPackage(){} // RVA: 0x7FFAC8200E70
        public void get_HasJavaPackage(){} // RVA: 0x7FFAC81FF390
        public void ClearJavaPackage(){} // RVA: 0x7FFAC53F2F70
        public void get_JavaOuterClassname(){} // RVA: 0x7FFAC8200F70
        public void set_JavaOuterClassname(){} // RVA: 0x7FFAC8200FE0
        public void get_HasJavaOuterClassname(){} // RVA: 0x7FFAC781E0A0
        public void ClearJavaOuterClassname(){} // RVA: 0x7FFAC81FF510
        public void get_JavaMultipleFiles(){} // RVA: 0x7FFAC82010E0
        public void set_JavaMultipleFiles(){} // RVA: 0x7FFAC8201150
        public void get_HasJavaMultipleFiles(){} // RVA: 0x7FFAC8201160
        public void ClearJavaMultipleFiles(){} // RVA: 0x7FFAC8201170
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFAC8201180
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFAC82011F0
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x7FFAC8201200
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x7FFAC8201210
        public void get_JavaStringCheckUtf8(){} // RVA: 0x7FFAC8201220
        public void set_JavaStringCheckUtf8(){} // RVA: 0x7FFAC8201290
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x7FFAC82012A0
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x7FFAC82012B0
        public void get_OptimizeFor(){} // RVA: 0x7FFAC82012C0
        public void set_OptimizeFor(){} // RVA: 0x7FFAC8201330
        public void get_HasOptimizeFor(){} // RVA: 0x7FFAC8201340
        public void ClearOptimizeFor(){} // RVA: 0x7FFAC8201350
        public void get_GoPackage(){} // RVA: 0x7FFAC8201360
        public void set_GoPackage(){} // RVA: 0x7FFAC82013D0
        public void get_HasGoPackage(){} // RVA: 0x7FFAC781E0B0
        public void ClearGoPackage(){} // RVA: 0x7FFAC81F6D10
        public void get_CcGenericServices(){} // RVA: 0x7FFAC82014D0
        public void set_CcGenericServices(){} // RVA: 0x7FFAC8201540
        public void get_HasCcGenericServices(){} // RVA: 0x7FFAC8201550
        public void ClearCcGenericServices(){} // RVA: 0x7FFAC8201560
        public void get_JavaGenericServices(){} // RVA: 0x7FFAC8201570
        public void set_JavaGenericServices(){} // RVA: 0x7FFAC82015E0
        public void get_HasJavaGenericServices(){} // RVA: 0x7FFAC82015F0
        public void ClearJavaGenericServices(){} // RVA: 0x7FFAC8201600
        public void get_PyGenericServices(){} // RVA: 0x7FFAC8201610
        public void set_PyGenericServices(){} // RVA: 0x7FFAC8201680
        public void get_HasPyGenericServices(){} // RVA: 0x7FFAC8201690
        public void ClearPyGenericServices(){} // RVA: 0x7FFAC82016A0
        public void get_PhpGenericServices(){} // RVA: 0x7FFAC82016B0
        public void set_PhpGenericServices(){} // RVA: 0x7FFAC8201720
        public void get_HasPhpGenericServices(){} // RVA: 0x7FFAC8201730
        public void ClearPhpGenericServices(){} // RVA: 0x7FFAC8201740
        public void get_Deprecated(){} // RVA: 0x7FFAC8201750
        public void set_Deprecated(){} // RVA: 0x7FFAC82017C0
        public void get_HasDeprecated(){} // RVA: 0x7FFAC82017D0
        public void ClearDeprecated(){} // RVA: 0x7FFAC82017E0
        public void get_CcEnableArenas(){} // RVA: 0x7FFAC82017F0
        public void set_CcEnableArenas(){} // RVA: 0x7FFAC8201860
        public void get_HasCcEnableArenas(){} // RVA: 0x7FFAC8201870
        public void ClearCcEnableArenas(){} // RVA: 0x7FFAC8201880
        public void get_ObjcClassPrefix(){} // RVA: 0x7FFAC8201890
        public void set_ObjcClassPrefix(){} // RVA: 0x7FFAC8201900
        public void get_HasObjcClassPrefix(){} // RVA: 0x7FFAC781EE40
        public void ClearObjcClassPrefix(){} // RVA: 0x7FFAC44CE0C0
        public void get_CsharpNamespace(){} // RVA: 0x7FFAC8201A00
        public void set_CsharpNamespace(){} // RVA: 0x7FFAC8201A70
        public void get_HasCsharpNamespace(){} // RVA: 0x7FFAC781EE50
        public void ClearCsharpNamespace(){} // RVA: 0x7FFAC81F7160
        public void get_SwiftPrefix(){} // RVA: 0x7FFAC8201B70
        public void set_SwiftPrefix(){} // RVA: 0x7FFAC8201BE0
        public void get_HasSwiftPrefix(){} // RVA: 0x7FFAC4836B90
        public void ClearSwiftPrefix(){} // RVA: 0x7FFAC8201CE0
        public void get_PhpClassPrefix(){} // RVA: 0x7FFAC8201D40
        public void set_PhpClassPrefix(){} // RVA: 0x7FFAC8201DB0
        public void get_HasPhpClassPrefix(){} // RVA: 0x7FFAC3E01380
        public void ClearPhpClassPrefix(){} // RVA: 0x7FFAC44CBCB0
        public void get_PhpNamespace(){} // RVA: 0x7FFAC8201EB0
        public void set_PhpNamespace(){} // RVA: 0x7FFAC8201F20
        public void get_HasPhpNamespace(){} // RVA: 0x7FFAC81EE650
        public void ClearPhpNamespace(){} // RVA: 0x7FFAC44CB460
        public void get_PhpMetadataNamespace(){} // RVA: 0x7FFAC8202020
        public void set_PhpMetadataNamespace(){} // RVA: 0x7FFAC8202090
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x7FFAC8202190
        public void ClearPhpMetadataNamespace(){} // RVA: 0x7FFAC82021A0
        public void get_RubyPackage(){} // RVA: 0x7FFAC8202200
        public void set_RubyPackage(){} // RVA: 0x7FFAC8202270
        public void get_HasRubyPackage(){} // RVA: 0x7FFAC8202370
        public void ClearRubyPackage(){} // RVA: 0x7FFAC42D5870
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F60010
        public void Equals(){} // RVA: 0x7FFAC82023E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8202990
        public void ToString(){} // RVA: 0x7FFAC8202DE0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8202E30
        public void CalculateSize(){} // RVA: 0x7FFAC82032C0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8203A40
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8203FB0
    }

    public class GeneratedClrTypeInfo : Object
    {
        public string[] ClrType;
        public Google.Protobuf.Reflection.GeneratedClrTypeInfo[] Parser; // 0x8
        public Google.Protobuf.Extension[] PropertyNames; // 0x10
        public System.Type Extensions; // 0x10
        public Google.Protobuf.MessageParser OneofNames; // 0x18
        public string[] NestedTypes; // 0x20
        public Google.Protobuf.Extension[] NestedEnums; // 0x28
        public string[] <OneofNames>k__BackingField; // 0x30
        public Google.Protobuf.Reflection.GeneratedClrTypeInfo[] <NestedTypes>k__BackingField; // 0x38
        public System.Type[] <NestedEnums>k__BackingField; // 0x40

        // ── Methods ──
        public void get_ClrType(){} // RVA: 0x7FFAC2F3C380
        public void set_ClrType(){} // RVA: 0x7FFAC2F22E30
        public void get_Parser(){} // RVA: 0x7FFAC2F247C0
        public void get_PropertyNames(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Extensions(){} // RVA: 0x7FFAC2F4F130
        public void get_OneofNames(){} // RVA: 0x7FFAC31D95E0
        public void get_NestedTypes(){} // RVA: 0x7FFAC31D0140
        public void get_NestedEnums(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC821DFC0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC821E000
    }

    public class GeneratedCodeInfo : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.GeneratedCodeInfo> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Annotation> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Annotation> Annotation; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8212740
        public void get_Descriptor(){} // RVA: 0x7FFAC82127A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8212860
        public void .ctor(){} // RVA: 0x7FFAC8212970 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8212B10
        public void get_Annotation(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC8212DE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC8212E90
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8212EE0
        public void CalculateSize(){} // RVA: 0x7FFAC8212FA0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8213190
        public void .cctor(){} // RVA: 0x7FFAC8213290
    }

    public class IDescriptor
    {
        public object Name;
        public object FullName;
        public object File;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_FullName(){} // RVA: 0x7FFAC2C58E90
        public void get_File(){} // RVA: 0x7FFAC2C58E90
    }

    public class IFieldAccessor
    {
        public object Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC2C58E90
        public void Clear(){} // RVA: 0x7FFAC2C70A40
        public void GetValue(){} // RVA: 0x7FFAC2C58F40
        public void HasValue(){} // RVA: 0x7FFAC2C59F60
        public void SetValue(){} // RVA: 0x7FFAC2C79B30
    }

    public class MapFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC821E1E0
        public void Clear(){} // RVA: 0x7FFAC821E1F0
        public void HasValue(){} // RVA: 0x7FFAC821E2B0
        public void SetValue(){} // RVA: 0x7FFAC821E300
    }

    public class MessageDescriptor : DescriptorBase
    {
        public System.Collections.Generic.HashSet`1<string> Name;
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> Proto; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> ClrType; // 0x30
        public System.Collections.Generic.IDictionary`2<string,Google.Protobuf.Reflection.FieldDescriptor> Parser; // 0x38
        public Google.Protobuf.Reflection.DescriptorProto IsWellKnownType; // 0x40
        public System.Type IsWrapperType; // 0x48
        public Google.Protobuf.MessageParser Fields; // 0x50
        public Google.Protobuf.Reflection.MessageDescriptor Extensions; // 0x58
        public FieldCollection NestedTypes; // 0x60
        public Google.Protobuf.Reflection.ExtensionCollection EnumTypes; // 0x68
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MessageDescriptor> Oneofs; // 0x70
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField; // 0x78
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.OneofDescriptor> <Oneofs>k__BackingField; // 0x80
        public int <RealOneofCount>k__BackingField; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC821E350
        public void CreateJsonFieldMap(){} // RVA: 0x7FFAC821F0E0
        public void get_Name(){} // RVA: 0x7FFAC821F470
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAC821F4E0
        public void get_Proto(){} // RVA: 0x7FFAC2F9E740
        public void get_ClrType(){} // RVA: 0x7FFAC2F9C730
        public void get_Parser(){} // RVA: 0x7FFAC2FC20E0
        public void get_IsWellKnownType(){} // RVA: 0x7FFAC821F5C0
        public void get_IsWrapperType(){} // RVA: 0x7FFAC821F6D0
        public void get_Fields(){} // RVA: 0x7FFAC2FBF370
        public void get_Extensions(){} // RVA: 0x7FFAC2F9CD50
        public void get_NestedTypes(){} // RVA: 0x7FFAC2FE9590
        public void get_EnumTypes(){} // RVA: 0x7FFAC30E5600
        public void get_Oneofs(){} // RVA: 0x7FFAC32EF410
        public void FindFieldByName(){} // RVA: 0x7FFAC821F7C0
        public void FindFieldByNumber(){} // RVA: 0x7FFAC821F860
        public void CrossLink(){} // RVA: 0x7FFAC821F9E0
        public void .cctor(){} // RVA: 0x7FFAC821FFA0
    }

    public class MessageOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MessageOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.MessageOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool MessageSetWireFormat; // 0x8
        public bool HasMessageSetWireFormat; // 0x24
        public bool NoStandardDescriptorAccessor; // 0x9
        public bool HasNoStandardDescriptorAccessor; // 0x25
        public bool Deprecated; // 0xA
        public bool HasDeprecated; // 0x26
        public bool MapEntry; // 0xB
        public bool HasMapEntry; // 0x27
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC8204860
        public void get_Descriptor(){} // RVA: 0x7FFAC82048C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8204980
        public void .ctor(){} // RVA: 0x7FFAC8204B30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8204D60
        public void get_MessageSetWireFormat(){} // RVA: 0x7FFAC8204DC0
        public void set_MessageSetWireFormat(){} // RVA: 0x7FFAC8204E30
        public void get_HasMessageSetWireFormat(){} // RVA: 0x7FFAC8201340
        public void ClearMessageSetWireFormat(){} // RVA: 0x7FFAC8201350
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x7FFAC8204E40
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x7FFAC8204EB0
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x7FFAC8201160
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x7FFAC8201170
        public void get_Deprecated(){} // RVA: 0x7FFAC8204EC0
        public void set_Deprecated(){} // RVA: 0x7FFAC8204F30
        public void get_HasDeprecated(){} // RVA: 0x7FFAC8201550
        public void ClearDeprecated(){} // RVA: 0x7FFAC8201560
        public void get_MapEntry(){} // RVA: 0x7FFAC8204F40
        public void set_MapEntry(){} // RVA: 0x7FFAC8204FB0
        public void get_HasMapEntry(){} // RVA: 0x7FFAC82015F0
        public void ClearMapEntry(){} // RVA: 0x7FFAC8201600
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC8205020 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82051A0
        public void ToString(){} // RVA: 0x7FFAC8205300
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8205350
        public void CalculateSize(){} // RVA: 0x7FFAC82054E0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82057A0
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8205970
    }

    public class MethodDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.MethodDescriptorProto Proto; // 0x28
        public Google.Protobuf.Reflection.ServiceDescriptor Name; // 0x30
        public Google.Protobuf.Reflection.MessageDescriptor inputType; // 0x38
        public Google.Protobuf.Reflection.MessageDescriptor outputType; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8220730
        public void get_Proto(){} // RVA: 0x7FFAC2F4F130
        public void get_Name(){} // RVA: 0x7FFAC82208E0
        public void CrossLink(){} // RVA: 0x7FFAC8220950
    }

    public class MethodDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MethodDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public string Name; // 0x8
        public string HasName; // 0x20
        public string InputType; // 0x10
        public string HasInputType; // 0x28
        public string OutputType; // 0x18
        public string HasOutputType; // 0x30
        public Google.Protobuf.Reflection.MethodOptions Options; // 0x38
        public bool ClientStreaming; // 0x20
        public bool HasClientStreaming; // 0x40
        public bool ServerStreaming; // 0x21
        public bool HasServerStreaming; // 0x41

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81FEBA0
        public void get_Descriptor(){} // RVA: 0x7FFAC81FEC00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81FECC0
        public void .ctor(){} // RVA: 0x7FFAC81FEDB0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81FF050
        public void get_Name(){} // RVA: 0x7FFAC81FF0B0
        public void set_Name(){} // RVA: 0x7FFAC81FF120
        public void get_HasName(){} // RVA: 0x7FFAC495C6A0
        public void ClearName(){} // RVA: 0x7FFAC81EE480
        public void get_InputType(){} // RVA: 0x7FFAC81FF220
        public void set_InputType(){} // RVA: 0x7FFAC81FF290
        public void get_HasInputType(){} // RVA: 0x7FFAC81FF390
        public void ClearInputType(){} // RVA: 0x7FFAC53F2F70
        public void get_OutputType(){} // RVA: 0x7FFAC81FF3A0
        public void set_OutputType(){} // RVA: 0x7FFAC81FF410
        public void get_HasOutputType(){} // RVA: 0x7FFAC781E0A0
        public void ClearOutputType(){} // RVA: 0x7FFAC81FF510
        public void get_Options(){} // RVA: 0x7FFAC31D0140
        public void set_Options(){} // RVA: 0x7FFAC31D0C20
        public void get_ClientStreaming(){} // RVA: 0x7FFAC81FF570
        public void set_ClientStreaming(){} // RVA: 0x7FFAC81FF5E0
        public void get_HasClientStreaming(){} // RVA: 0x7FFAC81F3770
        public void ClearClientStreaming(){} // RVA: 0x7FFAC81F3780
        public void get_ServerStreaming(){} // RVA: 0x7FFAC81FF5F0
        public void set_ServerStreaming(){} // RVA: 0x7FFAC81FF660
        public void get_HasServerStreaming(){} // RVA: 0x7FFAC81F3810
        public void ClearServerStreaming(){} // RVA: 0x7FFAC81F3820
        public void Equals(){} // RVA: 0x7FFAC81FF6D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81FF8D0
        public void ToString(){} // RVA: 0x7FFAC81FFA50
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81FFAA0
        public void CalculateSize(){} // RVA: 0x7FFAC81FFBD0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81FFF60
        public void .cctor(){} // RVA: 0x7FFAC8200140
    }

    public class MethodOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.MethodOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.MethodOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool Deprecated; // 0x8
        public bool HasDeprecated; // 0x24
        public 0x6B230B10 IdempotencyLevel; // 0xC
        public 0x6B230B10 HasIdempotencyLevel; // 0x28
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x30

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC820BC90
        public void get_Descriptor(){} // RVA: 0x7FFAC820BCF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC820BDB0
        public void .ctor(){} // RVA: 0x7FFAC820BF60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC820C180
        public void get_Deprecated(){} // RVA: 0x7FFAC820C1E0
        public void set_Deprecated(){} // RVA: 0x7FFAC8204E30
        public void get_HasDeprecated(){} // RVA: 0x7FFAC8201340
        public void ClearDeprecated(){} // RVA: 0x7FFAC8201350
        public void get_IdempotencyLevel(){} // RVA: 0x7FFAC820C250
        public void set_IdempotencyLevel(){} // RVA: 0x7FFAC820C2C0
        public void get_HasIdempotencyLevel(){} // RVA: 0x7FFAC8201160
        public void ClearIdempotencyLevel(){} // RVA: 0x7FFAC8201170
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC31D95E0
        public void Equals(){} // RVA: 0x7FFAC820C440 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC820C580
        public void ToString(){} // RVA: 0x7FFAC820C670
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC820C6C0
        public void CalculateSize(){} // RVA: 0x7FFAC820C800
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC820CB00
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC820CC80
    }

    public class OneofAccessor : Object
    {
        public System.Func`2<Google.Protobuf.IMessage,int> Descriptor; // 0x10
        public System.Action`1<Google.Protobuf.IMessage> clearDelegate; // 0x18
        public Google.Protobuf.Reflection.OneofDescriptor <Descriptor>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8220D00
        public void ForRegularOneof(){} // RVA: 0x7FFAC8220E00
        public void ForSyntheticOneof(){} // RVA: 0x7FFAC8221000
        public void get_Descriptor(){} // RVA: 0x7FFAC2F4F0C0
        public void Clear(){} // RVA: 0x7FFAC3584BC0
        public void GetCaseFieldDescriptor(){} // RVA: 0x7FFAC8221190
    }

    public class OneofDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.MessageDescriptor Name; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.FieldDescriptor> Proto; // 0x30
        public Google.Protobuf.Reflection.OneofAccessor ContainingType; // 0x38
        public Google.Protobuf.Reflection.OneofDescriptorProto Fields; // 0x40
        public bool IsSynthetic; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8221350
        public void get_Name(){} // RVA: 0x7FFAC8221680
        public void get_Proto(){} // RVA: 0x7FFAC2F9E740
        public void get_ContainingType(){} // RVA: 0x7FFAC2F4F130
        public void get_Fields(){} // RVA: 0x7FFAC31D95E0
        public void get_IsSynthetic(){} // RVA: 0x7FFAC2FD8D30
        public void get_Accessor(){} // RVA: 0x7FFAC31D0140
        public void CrossLink(){} // RVA: 0x7FFAC82216F0
        public void CreateAccessor(){} // RVA: 0x7FFAC8221A60
    }

    public class OneofDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.OneofDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string Name; // 0x18
        public Google.Protobuf.Reflection.OneofOptions HasName; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81F87C0
        public void get_Descriptor(){} // RVA: 0x7FFAC81F8820
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F88E0
        public void .ctor(){} // RVA: 0x7FFAC81F89D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81F8BB0
        public void get_Name(){} // RVA: 0x7FFAC81F8C10
        public void set_Name(){} // RVA: 0x7FFAC81F8C80
        public void get_HasName(){} // RVA: 0x7FFAC4860B40
        public void ClearName(){} // RVA: 0x7FFAC515CC20
        public void get_Options(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Options(){} // RVA: 0x7FFAC2F4F0D0
        public void Equals(){} // RVA: 0x7FFAC81F8ED0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81F8FE0
        public void ToString(){} // RVA: 0x7FFAC81F9080
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81F90D0
        public void CalculateSize(){} // RVA: 0x7FFAC81F9150
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F9540
        public void .cctor(){} // RVA: 0x7FFAC81F9650
    }

    public class OneofOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.OneofOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.OneofOptions> Descriptor; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC82076B0
        public void get_Descriptor(){} // RVA: 0x7FFAC8207710
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82077D0
        public void .ctor(){} // RVA: 0x7FFAC8207980 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8207B90
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFAC8207D30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81F5890
        public void ToString(){} // RVA: 0x7FFAC8207E20
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8207E70
        public void CalculateSize(){} // RVA: 0x7FFAC8207F60
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82081A0
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC82082D0
    }

    public class OriginalNameAttribute : Attribute
    {
        public string Name; // 0x10
        public bool PreferredAlias; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_PreferredAlias(){} // RVA: 0x7FFAC2F3C4E0
        public void set_PreferredAlias(){} // RVA: 0x7FFAC2F3C4F0
        public void .ctor(){} // RVA: 0x7FFAC8221FA0
    }

    public class PackageDescriptor : Object
    {
        public string Name; // 0x10
        public string FullName; // 0x18
        public Google.Protobuf.Reflection.FileDescriptor File; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82220A0
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_FullName(){} // RVA: 0x7FFAC2F247C0
        public void get_File(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class ReflectionUtil : Object
    {
        public System.Type[] CanConvertEnumFuncToInt32Func;
        public bool <CanConvertEnumFuncToInt32Func>k__BackingField; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC82221B0
        public void ForceInitialize(){} // RVA: 0x7FFAC2C709B0
        public void CreateFuncIMessageObject(){} // RVA: 0x7FFAC82226F0
        public void CreateFuncIMessageInt32(){} // RVA: 0x7FFAC8222840
        public void CreateActionIMessageObject(){} // RVA: 0x7FFAC8222970
        public void CreateActionIMessage(){} // RVA: 0x7FFAC8222AF0
        public void CreateFuncIMessageBool(){} // RVA: 0x7FFAC8222CB0
        public void CreateExtensionHelper(){} // RVA: 0x7FFAC8222E00
        public void GetReflectionHelper(){} // RVA: 0x7FFAC82230E0
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFAC82232E0
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFAC8223340
        public void SampleEnumMethod(){} // RVA: 0x7FFAC34F9180
    }

    public class RepeatedFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC821E1E0
        public void Clear(){} // RVA: 0x7FFAC8223550
        public void HasValue(){} // RVA: 0x7FFAC8223610
        public void SetValue(){} // RVA: 0x7FFAC8223660
    }

    public class ServiceDescriptor : DescriptorBase
    {
        public Google.Protobuf.Reflection.ServiceDescriptorProto Name; // 0x28
        public System.Collections.Generic.IList`1<Google.Protobuf.Reflection.MethodDescriptor> methods; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82236B0
        public void get_Name(){} // RVA: 0x7FFAC8223A10
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAC8223A80
        public void CrossLink(){} // RVA: 0x7FFAC8223AF0
    }

    public class ServiceDescriptorProto : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ServiceDescriptorProto> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string Name; // 0x18
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.MethodDescriptorProto> HasName; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.MethodDescriptorProto> Method; // 0x20
        public Google.Protobuf.Reflection.ServiceOptions Options; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC81FD530
        public void get_Descriptor(){} // RVA: 0x7FFAC81FD590
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81FD650
        public void .ctor(){} // RVA: 0x7FFAC81FD800 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC81FDA80
        public void get_Name(){} // RVA: 0x7FFAC81FDAE0
        public void set_Name(){} // RVA: 0x7FFAC81FDB50
        public void get_HasName(){} // RVA: 0x7FFAC4860B40
        public void ClearName(){} // RVA: 0x7FFAC515CC20
        public void get_Method(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void set_Options(){} // RVA: 0x7FFAC2F22E90
        public void Equals(){} // RVA: 0x7FFAC81FDDE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81FDF40
        public void ToString(){} // RVA: 0x7FFAC81FE000
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81FE050
        public void CalculateSize(){} // RVA: 0x7FFAC81FE160
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81FE610
        public void .cctor(){} // RVA: 0x7FFAC81FE7A0
    }

    public class ServiceOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.ServiceOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Google.Protobuf.Reflection.ServiceOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool Deprecated; // 0x8
        public bool HasDeprecated; // 0x24
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.Reflection.UninterpretedOption> UninterpretedOption; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC820AB00
        public void get_Descriptor(){} // RVA: 0x7FFAC820AB60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC820AC20
        public void .ctor(){} // RVA: 0x7FFAC820ADD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC820AFE0
        public void get_Deprecated(){} // RVA: 0x7FFAC820B040
        public void set_Deprecated(){} // RVA: 0x7FFAC8204E30
        public void get_HasDeprecated(){} // RVA: 0x7FFAC8201340
        public void ClearDeprecated(){} // RVA: 0x7FFAC8201350
        public void get_UninterpretedOption(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC820B200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC820B310
        public void ToString(){} // RVA: 0x7FFAC820B3E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC820B430
        public void CalculateSize(){} // RVA: 0x7FFAC820B550
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC820B7B0
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC820B900
    }

    public class SingleFieldAccessor : FieldAccessorBase
    {
        public System.Action`2<Google.Protobuf.IMessage,object> setValueDelegate; // 0x20
        public System.Action`1<Google.Protobuf.IMessage> clearDelegate; // 0x28
        public System.Func`2<Google.Protobuf.IMessage,bool> hasDelegate; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8223EB0
        public void GetDefaultValue(){} // RVA: 0x7FFAC8224A30
        public void Clear(){} // RVA: 0x7FFAC5C6F7C0
        public void HasValue(){} // RVA: 0x7FFAC8224FE0
        public void SetValue(){} // RVA: 0x7FFAC8225010
    }

    public class SourceCodeInfo : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.SourceCodeInfo> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Location> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Location> Location; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC820FE50
        public void get_Descriptor(){} // RVA: 0x7FFAC820FEB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC820FF70
        public void .ctor(){} // RVA: 0x7FFAC8210080 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8210220
        public void get_Location(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82104F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82105A0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82105F0
        public void CalculateSize(){} // RVA: 0x7FFAC82106B0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82108A0
        public void .cctor(){} // RVA: 0x7FFAC82109A0
    }

    public class TypeRegistry : Object
    {
        public Google.Protobuf.Reflection.TypeRegistry Empty;
        public System.Collections.Generic.Dictionary`2<string,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap; // 0x10

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFAC8225310
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Find(){} // RVA: 0x7FFAC8225370
        public void .cctor(){} // RVA: 0x7FFAC82253E0
    }

    public class UninterpretedOption : Object
    {
        public Google.Protobuf.MessageParser`1<Google.Protobuf.Reflection.UninterpretedOption> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Google.Protobuf.FieldCodec`1<NamePart> Name; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<NamePart> IdentifierValue; // 0x20
        public string HasIdentifierValue; // 0x10
        public string PositiveIntValue; // 0x28
        public ulong HasPositiveIntValue; // 0x18
        public ulong NegativeIntValue; // 0x30
        public long HasNegativeIntValue; // 0x20
        public long DoubleValue; // 0x38
        public double HasDoubleValue; // 0x28
        public double StringValue; // 0x40
        public Google.Protobuf.ByteString HasStringValue; // 0x30
        public Google.Protobuf.ByteString AggregateValue; // 0x48
        public string HasAggregateValue; // 0x38
        public string aggregateValue_; // 0x50

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC820D020
        public void get_Descriptor(){} // RVA: 0x7FFAC820D080
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC820D140
        public void .ctor(){} // RVA: 0x7FFAC820D250 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC820D4F0
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IdentifierValue(){} // RVA: 0x7FFAC820D550
        public void set_IdentifierValue(){} // RVA: 0x7FFAC820D5C0
        public void get_HasIdentifierValue(){} // RVA: 0x7FFAC81FF390
        public void ClearIdentifierValue(){} // RVA: 0x7FFAC53F2F70
        public void get_PositiveIntValue(){} // RVA: 0x7FFAC820D6C0
        public void set_PositiveIntValue(){} // RVA: 0x7FFAC820D730
        public void get_HasPositiveIntValue(){} // RVA: 0x7FFAC81F3770
        public void ClearPositiveIntValue(){} // RVA: 0x7FFAC81F3780
        public void get_NegativeIntValue(){} // RVA: 0x7FFAC820D740
        public void set_NegativeIntValue(){} // RVA: 0x7FFAC820D7B0
        public void get_HasNegativeIntValue(){} // RVA: 0x7FFAC81F3810
        public void ClearNegativeIntValue(){} // RVA: 0x7FFAC81F3820
        public void get_DoubleValue(){} // RVA: 0x7FFAC820D7C0
        public void set_DoubleValue(){} // RVA: 0x7FFAC820D830
        public void get_HasDoubleValue(){} // RVA: 0x7FFAC81F6A10
        public void ClearDoubleValue(){} // RVA: 0x7FFAC81F6A20
        public void get_StringValue(){} // RVA: 0x7FFAC820D840
        public void set_StringValue(){} // RVA: 0x7FFAC820D8B0
        public void get_HasStringValue(){} // RVA: 0x7FFAC820D9B0
        public void ClearStringValue(){} // RVA: 0x7FFAC81F6EF0
        public void get_AggregateValue(){} // RVA: 0x7FFAC820DA70
        public void set_AggregateValue(){} // RVA: 0x7FFAC820DAE0
        public void get_HasAggregateValue(){} // RVA: 0x7FFAC781EE40
        public void ClearAggregateValue(){} // RVA: 0x7FFAC44CE0C0
        public void Equals(){} // RVA: 0x7FFAC820DC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC820DEB0
        public void ToString(){} // RVA: 0x7FFAC820E060
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC820E0B0
        public void CalculateSize(){} // RVA: 0x7FFAC820E280
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC820E6C0
        public void .cctor(){} // RVA: 0x7FFAC820E8D0
    }

}