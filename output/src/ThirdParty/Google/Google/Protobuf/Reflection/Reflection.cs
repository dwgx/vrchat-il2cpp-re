// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 49
// Methods: 863

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorBase : Object
    {
        public object _index;
        public object _fullName;
        public object _file;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F79A0
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_FullName(){} // RVA: 0xB465B0
        public void get_File(){} // RVA: 0xB700F0
        public void GetNestedDescriptorListForField(){} // RVA: 0xDAC980
    }

    public class DescriptorDeclaration : Object
    {
        public object _descriptor;
        public object _startLine;
        public object _startColumn;
        public object _endLine;
        public object _endColumn;
        public object _leadingComments;
        public object _trailingComments;
        public object _leadingDetachedComments;

        // ── Methods ──
        public void get_StartLine(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x64F7A60
        public void FromProto(){} // RVA: 0x64F7FB0
    }

    public class DescriptorPool : Object
    {
        public object descriptorsByName;
        public object fieldsByNumber;
        public object enumValuesByNumber;
        public object dependencies;
        public object ValidationRegex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F8020
        public void ImportPublicDependencies(){} // RVA: 0x64F86E0
        public void FindSymbol(){} // RVA: 0xA94080
        public void AddPackage(){} // RVA: 0x64F8910
        public void AddSymbol(){} // RVA: 0x64F8D10
        public void ValidateSymbolName(){} // RVA: 0x64F9130
        public void FindFieldByNumber(){} // RVA: 0x64F93B0
        public void AddFieldByNumber(){} // RVA: 0x64F9510
        public void AddEnumValueByNumber(){} // RVA: 0x64F9930
        public void LookupSymbol(){} // RVA: 0x64F9B90
        public void .cctor(){} // RVA: 0x64F9E80
    }

    public class DescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object NameDefaultValue;
        public object name_;
        public object _repeated_field_codec;
        public object field_;
        public object _repeated_extension_codec;
        public object extension_;
        public object _repeated_nestedType_codec;
        public object nestedType_;
        public object _repeated_enumType_codec;
        public object enumType_;
        public object _repeated_extensionRange_codec;
        public object extensionRange_;
        public object _repeated_oneofDecl_codec;
        public object oneofDecl_;
        public object options_;
        public object _repeated_reservedRange_codec;
        public object reservedRange_;
        public object _repeated_reservedName_codec;
        public object reservedName_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64D3580
        public void get_Descriptor(){} // RVA: 0x64D35E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64D36A0
        public void .ctor(){} // RVA: 0x64D3BA0
        public void Clone(){} // RVA: 0x64D4190
        public void get_Name(){} // RVA: 0x64D41F0
        public void set_Name(){} // RVA: 0x64D4260
        public void get_HasName(){} // RVA: 0x25E9250
        public void ClearName(){} // RVA: 0x30FBB60
        public void get_Field(){} // RVA: 0xB700F0
        public void get_Extension(){} // RVA: 0xB70160
        public void get_NestedType(){} // RVA: 0xD33E60
        public void get_EnumType(){} // RVA: 0xD05CA0
        public void get_ExtensionRange(){} // RVA: 0xBC1B30
        public void get_OneofDecl(){} // RVA: 0xBBF8F0
        public void get_Options(){} // RVA: 0xBE58B0
        public void set_Options(){} // RVA: 0xCA4DF0
        public void get_ReservedRange(){} // RVA: 0xC0FFC0
        public void get_ReservedName(){} // RVA: 0xBE2C60
        public void Equals(){} // RVA: 0x64D43C0
        public void GetHashCode(){} // RVA: 0x64D4690
        public void ToString(){} // RVA: 0x64D4860
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64D48B0
        public void CalculateSize(){} // RVA: 0x64D4B80
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64D5240
        public void .cctor(){} // RVA: 0x64D56B0
    }

    public class DescriptorReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x64CABF0
        public void .cctor(){} // RVA: 0x64CAC50
    }

    public class DescriptorUtil : Object
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x87C630
    }

    public class DescriptorValidationException : Exception
    {
        public object name;
        public object description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F9FA0
    }

    public class EnumDescriptor : DescriptorBase
    {
        public object proto;
        public object containingType;
        public object values;
        public object clrType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64FA140
        public void get_Name(){} // RVA: 0x64FA5B0
        public void GetNestedDescriptorListForField(){} // RVA: 0x64FA620
        public void get_Values(){} // RVA: 0xD05CA0
    }

    public class EnumDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object NameDefaultValue;
        public object name_;
        public object _repeated_value_codec;
        public object value_;
        public object options_;
        public object _repeated_reservedRange_codec;
        public object reservedRange_;
        public object _repeated_reservedName_codec;
        public object reservedName_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64DC790
        public void get_Descriptor(){} // RVA: 0x64DC7F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64DC8B0
        public void .ctor(){} // RVA: 0x64DCAF0
        public void Clone(){} // RVA: 0x64DCE70
        public void get_Name(){} // RVA: 0x64DCED0
        public void set_Name(){} // RVA: 0x64DCF40
        public void get_HasName(){} // RVA: 0x25E9250
        public void ClearName(){} // RVA: 0x30FBB60
        public void get_Value(){} // RVA: 0xB700F0
        public void get_Options(){} // RVA: 0xB70160
        public void set_Options(){} // RVA: 0xB44DC0
        public void get_ReservedRange(){} // RVA: 0xD33E60
        public void get_ReservedName(){} // RVA: 0xD05CA0
        public void Equals(){} // RVA: 0x64DD0A0
        public void GetHashCode(){} // RVA: 0x64DD270
        public void ToString(){} // RVA: 0x64DD380
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64DD3D0
        public void CalculateSize(){} // RVA: 0x64DD570
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64DDB50
        public void .cctor(){} // RVA: 0x64DDDB0
    }

    public class EnumOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object AllowAliasDefaultValue;
        public object allowAlias_;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64EB5F0
        public void get_Descriptor(){} // RVA: 0x64EB650
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64EB710
        public void .ctor(){} // RVA: 0x64EB8C0
        public void Clone(){} // RVA: 0x64EBAE0
        public void get_AllowAlias(){} // RVA: 0x64EBB40
        public void set_AllowAlias(){} // RVA: 0x64E7E10
        public void get_HasAllowAlias(){} // RVA: 0x64E43B0
        public void ClearAllowAlias(){} // RVA: 0x64E43C0
        public void get_Deprecated(){} // RVA: 0x64EBBB0
        public void set_Deprecated(){} // RVA: 0x64E7E90
        public void get_HasDeprecated(){} // RVA: 0x64E41D0
        public void ClearDeprecated(){} // RVA: 0x64E41E0
        public void get_UninterpretedOption(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0x64EBD90
        public void GetHashCode(){} // RVA: 0x64EBED0
        public void ToString(){} // RVA: 0x64EBFB0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64EC000
        public void CalculateSize(){} // RVA: 0x64EC140
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64EC3D0
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64EC550
    }

    public class EnumValueDescriptor : DescriptorBase
    {
        public object enumDescriptor;
        public object proto;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64FA730
        public void get_Proto(){} // RVA: 0xD33E60
        public void get_Name(){} // RVA: 0x64FA910
        public void get_Number(){} // RVA: 0x64FA980
        public void get_EnumDescriptor(){} // RVA: 0xB70160
    }

    public class EnumValueDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object NameDefaultValue;
        public object name_;
        public object NumberDefaultValue;
        public object number_;
        public object options_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64DEE40
        public void get_Descriptor(){} // RVA: 0x64DEEA0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64DEF60
        public void .ctor(){} // RVA: 0x64DF050
        public void Clone(){} // RVA: 0x64DF240
        public void get_Name(){} // RVA: 0x64DF2A0
        public void set_Name(){} // RVA: 0x64DF310
        public void get_HasName(){} // RVA: 0x26C1120
        public void ClearName(){} // RVA: 0x64D1270
        public void get_Number(){} // RVA: 0x64DF410
        public void set_Number(){} // RVA: 0x64D9760
        public void get_HasNumber(){} // RVA: 0x64D65D0
        public void ClearNumber(){} // RVA: 0x64D65E0
        public void get_Options(){} // RVA: 0xD33E60
        public void set_Options(){} // RVA: 0xB708C0
        public void Equals(){} // RVA: 0x64DF5E0
        public void GetHashCode(){} // RVA: 0x64DF710
        public void ToString(){} // RVA: 0x64DF7C0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64DF810
        public void CalculateSize(){} // RVA: 0x64DF8C0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64DFD10
        public void .cctor(){} // RVA: 0x64DFE40
    }

    public class EnumValueOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64EC8F0
        public void get_Descriptor(){} // RVA: 0x64EC950
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64ECA10
        public void .ctor(){} // RVA: 0x64ECBC0
        public void Clone(){} // RVA: 0x64ECDE0
        public void get_Deprecated(){} // RVA: 0x64ECE40
        public void set_Deprecated(){} // RVA: 0x64E7E10
        public void get_HasDeprecated(){} // RVA: 0x64E43B0
        public void ClearDeprecated(){} // RVA: 0x64E43C0
        public void get_UninterpretedOption(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0x64ED000
        public void GetHashCode(){} // RVA: 0x64ED110
        public void ToString(){} // RVA: 0x64ED1C0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64ED210
        public void CalculateSize(){} // RVA: 0x64ED320
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64ED580
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64ED6D0
    }

    public class ExtensionAccessor : Object
    {
        public object extension;
        public object helper;
        public object _descriptor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64FA9A0
        public void get_Descriptor(){} // RVA: 0xB700F0
        public void Clear(){} // RVA: 0x64FAB10
        public void HasValue(){} // RVA: 0x64FAB70
        public void GetValue(){} // RVA: 0x64FABD0
        public void SetValue(){} // RVA: 0x64FAC30
    }

    public class ExtensionCollection : Object
    {
        public object extensionsByTypeInDeclarationOrder;
        public object extensionsByTypeInNumberOrder;
        public object _unorderedExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64FAEB0
        public void get_UnorderedExtensions(){} // RVA: 0xB700F0
        public void CrossLink(){} // RVA: 0x64FB0B0
    }

    public class ExtensionRangeOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64D7F80
        public void get_Descriptor(){} // RVA: 0x64D7FE0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64D80A0
        public void .ctor(){} // RVA: 0x64D8250
        public void Clone(){} // RVA: 0x64D8460
        public void get_UninterpretedOption(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0x64D8600
        public void GetHashCode(){} // RVA: 0x64D86F0
        public void ToString(){} // RVA: 0x64D8780
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64D87D0
        public void CalculateSize(){} // RVA: 0x64D88C0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64D8B00
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64D8C30
    }

    public class FieldAccessorBase : Object
    {
        public object getValueDelegate;
        public object descriptor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64FC070
        public void get_Descriptor(){} // RVA: 0xB465B0
        public void GetValue(){} // RVA: 0x31D2090
        public void HasValue(){} // RVA: 0x87D350
        public void Clear(){} // RVA: 0x894320
        public void SetValue(){} // RVA: 0x8943B0
    }

    public class FieldDescriptor : DescriptorBase
    {
        public object enumType;
        public object extendeeType;
        public object messageType;
        public object fieldType;
        public object accessor;
        public object _containingType;
        public object _containingOneof;
        public object _jsonName;
        public object _propertyName;
        public object _proto;
        public object _extension;

        // ── Methods ──
        public void get_ContainingType(){} // RVA: 0xBE58B0
        public void get_ContainingOneof(){} // RVA: 0xC0FFC0
        public void get_RealContainingOneof(){} // RVA: 0x64FC2E0
        public void get_JsonName(){} // RVA: 0xBE2C60
        public void get_PropertyName(){} // RVA: 0xBBFF90
        public void get_HasPresence(){} // RVA: 0x64FC300
        public void get_Proto(){} // RVA: 0xC10050
        public void get_Extension(){} // RVA: 0xCD3320
        public void .ctor(){} // RVA: 0x64FC3B0
        public void get_Name(){} // RVA: 0x64FCB40
        public void get_Accessor(){} // RVA: 0xBBF8F0
        public void GetFieldTypeFromProtoType(){} // RVA: 0x64FCBB0
        public void get_IsRepeated(){} // RVA: 0x64FCD30
        public void get_IsMap(){} // RVA: 0x64FCD60
        public void get_FieldType(){} // RVA: 0xBE5850
        public void get_FieldNumber(){} // RVA: 0x64FCDA0
        public void CompareTo(){} // RVA: 0x64FCDC0
        public void get_MessageType(){} // RVA: 0x64FCE60
        public void get_ExtendeeType(){} // RVA: 0x64FCED0
        public void CrossLink(){} // RVA: 0x64FCF50
        public void CreateAccessor(){} // RVA: 0x64FD580
    }

    public class FieldDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object NameDefaultValue;
        public object name_;
        public object NumberDefaultValue;
        public object number_;
        public object LabelDefaultValue;
        public object label_;
        public object TypeDefaultValue;
        public object type_;
        public object TypeNameDefaultValue;
        public object typeName_;
        public object ExtendeeDefaultValue;
        public object extendee_;
        public object DefaultValueDefaultValue;
        public object defaultValue_;
        public object OneofIndexDefaultValue;
        public object oneofIndex_;
        public object JsonNameDefaultValue;
        public object jsonName_;
        public object options_;
        public object Proto3OptionalDefaultValue;
        public object proto3Optional_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64D8FB0
        public void get_Descriptor(){} // RVA: 0x64D9010
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64D90D0
        public void .ctor(){} // RVA: 0x64D91C0
        public void Clone(){} // RVA: 0x64D9520
        public void get_Name(){} // RVA: 0x64D9580
        public void set_Name(){} // RVA: 0x64D95F0
        public void get_HasName(){} // RVA: 0x26C1120
        public void ClearName(){} // RVA: 0x64D1270
        public void get_Number(){} // RVA: 0x64D96F0
        public void set_Number(){} // RVA: 0x64D9760
        public void get_HasNumber(){} // RVA: 0x64D65D0
        public void ClearNumber(){} // RVA: 0x64D65E0
        public void get_Label(){} // RVA: 0x64D9770
        public void set_Label(){} // RVA: 0x64D97E0
        public void get_HasLabel(){} // RVA: 0x64D6670
        public void ClearLabel(){} // RVA: 0x64D6680
        public void get_Type(){} // RVA: 0x64D97F0
        public void set_Type(){} // RVA: 0x64D9860
        public void get_HasType(){} // RVA: 0x64D9870
        public void ClearType(){} // RVA: 0x64D9880
        public void get_TypeName(){} // RVA: 0x64D9890
        public void set_TypeName(){} // RVA: 0x64D9900
        public void get_HasTypeName(){} // RVA: 0x25D3F40
        public void ClearTypeName(){} // RVA: 0x19E2480
        public void get_Extendee(){} // RVA: 0x64D9A00
        public void set_Extendee(){} // RVA: 0x64D9A70
        public void get_HasExtendee(){} // RVA: 0x5BC22C0
        public void ClearExtendee(){} // RVA: 0x64D9B70
        public void get_DefaultValue(){} // RVA: 0x64D9BD0
        public void set_DefaultValue(){} // RVA: 0x64D9C40
        public void get_HasDefaultValue(){} // RVA: 0x64D9D40
        public void ClearDefaultValue(){} // RVA: 0x64D9D50
        public void get_OneofIndex(){} // RVA: 0x64D9DB0
        public void set_OneofIndex(){} // RVA: 0x64D9E20
        public void get_HasOneofIndex(){} // RVA: 0x64D9E30
        public void ClearOneofIndex(){} // RVA: 0x64D9E40
        public void get_JsonName(){} // RVA: 0x64D9E50
        public void set_JsonName(){} // RVA: 0x64D9EC0
        public void get_HasJsonName(){} // RVA: 0x5BC35B0
        public void ClearJsonName(){} // RVA: 0x64D9FC0
        public void get_Options(){} // RVA: 0xBE2C60
        public void set_Options(){} // RVA: 0xBE2C70
        public void get_Proto3Optional(){} // RVA: 0x64DA020
        public void set_Proto3Optional(){} // RVA: 0x64DA090
        public void get_HasProto3Optional(){} // RVA: 0x64DA0A0
        public void ClearProto3Optional(){} // RVA: 0x64DA0B0
        public void Equals(){} // RVA: 0x64DA120
        public void GetHashCode(){} // RVA: 0x64DA430
        public void ToString(){} // RVA: 0x64DA610
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64DA660
        public void CalculateSize(){} // RVA: 0x64DA870
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64DAE30
        public void .cctor(){} // RVA: 0x64DB0F0
    }

    public class FieldOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object CtypeDefaultValue;
        public object ctype_;
        public object PackedDefaultValue;
        public object packed_;
        public object JstypeDefaultValue;
        public object jstype_;
        public object LazyDefaultValue;
        public object lazy_;
        public object UnverifiedLazyDefaultValue;
        public object unverifiedLazy_;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object WeakDefaultValue;
        public object weak_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64E8CF0
        public void get_Descriptor(){} // RVA: 0x64E8D50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64E8E10
        public void .ctor(){} // RVA: 0x64E8FC0
        public void Clone(){} // RVA: 0x64E9200
        public void get_Ctype(){} // RVA: 0x64E9260
        public void set_Ctype(){} // RVA: 0x64E92D0
        public void get_HasCtype(){} // RVA: 0x64E43B0
        public void ClearCtype(){} // RVA: 0x64E43C0
        public void get_Packed(){} // RVA: 0x64E92E0
        public void set_Packed(){} // RVA: 0x64E9350
        public void get_HasPacked(){} // RVA: 0x64E41D0
        public void ClearPacked(){} // RVA: 0x64E41E0
        public void get_Jstype(){} // RVA: 0x64E9360
        public void set_Jstype(){} // RVA: 0x64E93D0
        public void get_HasJstype(){} // RVA: 0x64E4700
        public void ClearJstype(){} // RVA: 0x64E4710
        public void get_Lazy(){} // RVA: 0x64E93E0
        public void set_Lazy(){} // RVA: 0x64E9450
        public void get_HasLazy(){} // RVA: 0x64E4660
        public void ClearLazy(){} // RVA: 0x64E4670
        public void get_UnverifiedLazy(){} // RVA: 0x64E9460
        public void set_UnverifiedLazy(){} // RVA: 0x64E94D0
        public void get_HasUnverifiedLazy(){} // RVA: 0x64E4840
        public void ClearUnverifiedLazy(){} // RVA: 0x64E4850
        public void get_Deprecated(){} // RVA: 0x64E94E0
        public void set_Deprecated(){} // RVA: 0x64E9550
        public void get_HasDeprecated(){} // RVA: 0x64E45C0
        public void ClearDeprecated(){} // RVA: 0x64E45D0
        public void get_Weak(){} // RVA: 0x64E9560
        public void set_Weak(){} // RVA: 0x64E95D0
        public void get_HasWeak(){} // RVA: 0x64E4270
        public void ClearWeak(){} // RVA: 0x64E4280
        public void get_UninterpretedOption(){} // RVA: 0xD05CA0
        public void Equals(){} // RVA: 0x64E9640
        public void GetHashCode(){} // RVA: 0x64E9820
        public void ToString(){} // RVA: 0x64E99B0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64E9A00
        public void CalculateSize(){} // RVA: 0x64E9C10
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64EA010
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64EA260
    }

    public class FileDescriptor : Object
    {
        public object declarations;
        public object _proto;
        public object _syntax;
        public object _messageTypes;
        public object _enumTypes;
        public object _services;
        public object _extensions;
        public object _dependencies;
        public object _publicDependencies;
        public object _serializedData;
        public object _descriptorPool;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x64FD940
        public void .ctor(){} // RVA: 0x64FD9F0
        public void CreateDeclarationMap(){} // RVA: 0x64FE370
        public void FindDescriptorForPath(){} // RVA: 0x64FE660
        public void GetDescriptorFromList(){} // RVA: 0x64FEA10
        public void GetNestedDescriptorListForField(){} // RVA: 0x64FEB50
        public void ComputeFullName(){} // RVA: 0x64FEC30
        public void DeterminePublicDependencies(){} // RVA: 0x64FECD0
        public void get_Proto(){} // RVA: 0xB465B0
        public void get_Syntax(){} // RVA: 0xFEAE90
        public void get_Name(){} // RVA: 0x64FF130
        public void get_Package(){} // RVA: 0x64FF1A0
        public void get_MessageTypes(){} // RVA: 0xB70160
        public void get_EnumTypes(){} // RVA: 0xD33E60
        public void get_Services(){} // RVA: 0xD05CA0
        public void get_Extensions(){} // RVA: 0xBC1B30
        public void get_Dependencies(){} // RVA: 0xBBF8F0
        public void get_PublicDependencies(){} // RVA: 0xBE58B0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x64FF210
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x2303260
        public void get_DescriptorPool(){} // RVA: 0xBE2C60
        public void BuildFrom(){} // RVA: 0x64FF220
        public void CrossLink(){} // RVA: 0x64FF3B0
        public void FromGeneratedCode(){} // RVA: 0x64FF770
        public void GetAllExtensions(){} // RVA: 0x64FFD40
        public void GetAllGeneratedExtensions(){} // RVA: 0x64FFEE0
        public void GetAllDependedExtensions(){} // RVA: 0x6500100
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x6500510
        public void ToString(){} // RVA: 0x6500880
        public void ForceReflectionInitialization(){} // RVA: 0x8942F0
    }

    public class FileDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object NameDefaultValue;
        public object name_;
        public object PackageDefaultValue;
        public object package_;
        public object _repeated_dependency_codec;
        public object dependency_;
        public object _repeated_publicDependency_codec;
        public object publicDependency_;
        public object _repeated_weakDependency_codec;
        public object weakDependency_;
        public object _repeated_messageType_codec;
        public object messageType_;
        public object _repeated_enumType_codec;
        public object enumType_;
        public object _repeated_service_codec;
        public object service_;
        public object _repeated_extension_codec;
        public object extension_;
        public object options_;
        public object sourceCodeInfo_;
        public object SyntaxDefaultValue;
        public object syntax_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64D0110
        public void get_Descriptor(){} // RVA: 0x64D0170
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64D0230
        public void .ctor(){} // RVA: 0x64D0740
        public void Clone(){} // RVA: 0x64D0F30
        public void get_Name(){} // RVA: 0x64D0F90
        public void set_Name(){} // RVA: 0x64D1000
        public void get_HasName(){} // RVA: 0x25E9250
        public void ClearName(){} // RVA: 0x30FBB60
        public void get_Package(){} // RVA: 0x64D1100
        public void set_Package(){} // RVA: 0x64D1170
        public void get_HasPackage(){} // RVA: 0x26C1120
        public void ClearPackage(){} // RVA: 0x64D1270
        public void get_Dependency(){} // RVA: 0xB70160
        public void get_PublicDependency(){} // RVA: 0xD33E60
        public void get_WeakDependency(){} // RVA: 0xD05CA0
        public void get_MessageType(){} // RVA: 0xBC1B30
        public void get_EnumType(){} // RVA: 0xBBF8F0
        public void get_Service(){} // RVA: 0xBE58B0
        public void get_Extension(){} // RVA: 0xC0FFC0
        public void get_Options(){} // RVA: 0xBE2C60
        public void set_Options(){} // RVA: 0xBE2C70
        public void get_SourceCodeInfo(){} // RVA: 0xBBFF90
        public void set_SourceCodeInfo(){} // RVA: 0xBBFFA0
        public void get_Syntax(){} // RVA: 0x64D12D0
        public void set_Syntax(){} // RVA: 0x64D1340
        public void get_HasSyntax(){} // RVA: 0x64D1440
        public void ClearSyntax(){} // RVA: 0x64D1450
        public void Equals(){} // RVA: 0x64D1510
        public void GetHashCode(){} // RVA: 0x64D1890
        public void ToString(){} // RVA: 0x64D1AC0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64D1B10
        public void CalculateSize(){} // RVA: 0x64D1E10
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64D2700
        public void .cctor(){} // RVA: 0x64D2BF0
    }

    public class FileDescriptorSet : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _repeated_file_codec;
        public object file_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64CF1A0
        public void get_Descriptor(){} // RVA: 0x64CF200
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64CF2C0
        public void .ctor(){} // RVA: 0x64CF470
        public void Clone(){} // RVA: 0x64CF610
        public void get_File(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x64CF8E0
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x64CF990
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64CF9E0
        public void CalculateSize(){} // RVA: 0x64CFAA0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64CFC90
        public void .cctor(){} // RVA: 0x64CFD90
    }

    public class FileOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object JavaPackageDefaultValue;
        public object javaPackage_;
        public object JavaOuterClassnameDefaultValue;
        public object javaOuterClassname_;
        public object JavaMultipleFilesDefaultValue;
        public object javaMultipleFiles_;
        public object JavaGenerateEqualsAndHashDefaultValue;
        public object javaGenerateEqualsAndHash_;
        public object JavaStringCheckUtf8DefaultValue;
        public object javaStringCheckUtf8_;
        public object OptimizeForDefaultValue;
        public object optimizeFor_;
        public object GoPackageDefaultValue;
        public object goPackage_;
        public object CcGenericServicesDefaultValue;
        public object ccGenericServices_;
        public object JavaGenericServicesDefaultValue;
        public object javaGenericServices_;
        public object PyGenericServicesDefaultValue;
        public object pyGenericServices_;
        public object PhpGenericServicesDefaultValue;
        public object phpGenericServices_;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object CcEnableArenasDefaultValue;
        public object ccEnableArenas_;
        public object ObjcClassPrefixDefaultValue;
        public object objcClassPrefix_;
        public object CsharpNamespaceDefaultValue;
        public object csharpNamespace_;
        public object SwiftPrefixDefaultValue;
        public object swiftPrefix_;
        public object PhpClassPrefixDefaultValue;
        public object phpClassPrefix_;
        public object PhpNamespaceDefaultValue;
        public object phpNamespace_;
        public object PhpMetadataNamespaceDefaultValue;
        public object phpMetadataNamespace_;
        public object RubyPackageDefaultValue;
        public object rubyPackage_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64E35A0
        public void get_Descriptor(){} // RVA: 0x64E3600
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64E36C0
        public void .ctor(){} // RVA: 0x64E3870
        public void Clone(){} // RVA: 0x64E3E10
        public void get_JavaPackage(){} // RVA: 0x64E3E70
        public void set_JavaPackage(){} // RVA: 0x64E3EE0
        public void get_HasJavaPackage(){} // RVA: 0x64E22A0
        public void ClearJavaPackage(){} // RVA: 0x34243A0
        public void get_JavaOuterClassname(){} // RVA: 0x64E3FE0
        public void set_JavaOuterClassname(){} // RVA: 0x64E4050
        public void get_HasJavaOuterClassname(){} // RVA: 0x5BC22D0
        public void ClearJavaOuterClassname(){} // RVA: 0x64E2420
        public void get_JavaMultipleFiles(){} // RVA: 0x64E4150
        public void set_JavaMultipleFiles(){} // RVA: 0x64E41C0
        public void get_HasJavaMultipleFiles(){} // RVA: 0x64E41D0
        public void ClearJavaMultipleFiles(){} // RVA: 0x64E41E0
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x64E41F0
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x64E4260
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x64E4270
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x64E4280
        public void get_JavaStringCheckUtf8(){} // RVA: 0x64E4290
        public void set_JavaStringCheckUtf8(){} // RVA: 0x64E4300
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x64E4310
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x64E4320
        public void get_OptimizeFor(){} // RVA: 0x64E4330
        public void set_OptimizeFor(){} // RVA: 0x64E43A0
        public void get_HasOptimizeFor(){} // RVA: 0x64E43B0
        public void ClearOptimizeFor(){} // RVA: 0x64E43C0
        public void get_GoPackage(){} // RVA: 0x64E43D0
        public void set_GoPackage(){} // RVA: 0x64E4440
        public void get_HasGoPackage(){} // RVA: 0x5BC22C0
        public void ClearGoPackage(){} // RVA: 0x64D9B70
        public void get_CcGenericServices(){} // RVA: 0x64E4540
        public void set_CcGenericServices(){} // RVA: 0x64E45B0
        public void get_HasCcGenericServices(){} // RVA: 0x64E45C0
        public void ClearCcGenericServices(){} // RVA: 0x64E45D0
        public void get_JavaGenericServices(){} // RVA: 0x64E45E0
        public void set_JavaGenericServices(){} // RVA: 0x64E4650
        public void get_HasJavaGenericServices(){} // RVA: 0x64E4660
        public void ClearJavaGenericServices(){} // RVA: 0x64E4670
        public void get_PyGenericServices(){} // RVA: 0x64E4680
        public void set_PyGenericServices(){} // RVA: 0x64E46F0
        public void get_HasPyGenericServices(){} // RVA: 0x64E4700
        public void ClearPyGenericServices(){} // RVA: 0x64E4710
        public void get_PhpGenericServices(){} // RVA: 0x64E4720
        public void set_PhpGenericServices(){} // RVA: 0x64E4790
        public void get_HasPhpGenericServices(){} // RVA: 0x64E47A0
        public void ClearPhpGenericServices(){} // RVA: 0x64E47B0
        public void get_Deprecated(){} // RVA: 0x64E47C0
        public void set_Deprecated(){} // RVA: 0x64E4830
        public void get_HasDeprecated(){} // RVA: 0x64E4840
        public void ClearDeprecated(){} // RVA: 0x64E4850
        public void get_CcEnableArenas(){} // RVA: 0x64E4860
        public void set_CcEnableArenas(){} // RVA: 0x64E48D0
        public void get_HasCcEnableArenas(){} // RVA: 0x64E48E0
        public void ClearCcEnableArenas(){} // RVA: 0x64E48F0
        public void get_ObjcClassPrefix(){} // RVA: 0x64E4900
        public void set_ObjcClassPrefix(){} // RVA: 0x64E4970
        public void get_HasObjcClassPrefix(){} // RVA: 0x5BC3080
        public void ClearObjcClassPrefix(){} // RVA: 0xD1B6F0
        public void get_CsharpNamespace(){} // RVA: 0x64E4A70
        public void set_CsharpNamespace(){} // RVA: 0x64E4AE0
        public void get_HasCsharpNamespace(){} // RVA: 0x5BC35B0
        public void ClearCsharpNamespace(){} // RVA: 0x64D9FC0
        public void get_SwiftPrefix(){} // RVA: 0x64E4BE0
        public void set_SwiftPrefix(){} // RVA: 0x64E4C50
        public void get_HasSwiftPrefix(){} // RVA: 0x25BF920
        public void ClearSwiftPrefix(){} // RVA: 0x64E4D50
        public void get_PhpClassPrefix(){} // RVA: 0x64E4DB0
        public void set_PhpClassPrefix(){} // RVA: 0x64E4E20
        public void get_HasPhpClassPrefix(){} // RVA: 0x1C4F7F0
        public void ClearPhpClassPrefix(){} // RVA: 0x122A5C0
        public void get_PhpNamespace(){} // RVA: 0x64E4F20
        public void set_PhpNamespace(){} // RVA: 0x64E4F90
        public void get_HasPhpNamespace(){} // RVA: 0x64D1440
        public void ClearPhpNamespace(){} // RVA: 0x64D1450
        public void get_PhpMetadataNamespace(){} // RVA: 0x64E5090
        public void set_PhpMetadataNamespace(){} // RVA: 0x64E5100
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x64E5200
        public void ClearPhpMetadataNamespace(){} // RVA: 0xD18E00
        public void get_RubyPackage(){} // RVA: 0x64E5210
        public void set_RubyPackage(){} // RVA: 0x64E5280
        public void get_HasRubyPackage(){} // RVA: 0x64E5380
        public void ClearRubyPackage(){} // RVA: 0xD18E60
        public void get_UninterpretedOption(){} // RVA: 0xB813B0
        public void Equals(){} // RVA: 0x64E53F0
        public void GetHashCode(){} // RVA: 0x64E59A0
        public void ToString(){} // RVA: 0x64E5DC0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64E5E10
        public void CalculateSize(){} // RVA: 0x64E62A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64E6A20
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64E6F90
    }

    public class GeneratedClrTypeInfo : Object
    {
        public object EmptyNames;
        public object EmptyCodeInfo;
        public object EmptyExtensions;
        public object _clrType;
        public object _parser;
        public object _propertyNames;
        public object _extensions;
        public object _oneofNames;
        public object _nestedTypes;
        public object _nestedEnums;

        // ── Methods ──
        public void get_ClrType(){} // RVA: 0xB5DBF0
        public void set_ClrType(){} // RVA: 0xB44D60
        public void get_Parser(){} // RVA: 0xB465B0
        public void get_PropertyNames(){} // RVA: 0xB700F0
        public void get_Extensions(){} // RVA: 0xB70160
        public void get_OneofNames(){} // RVA: 0xD33E60
        public void get_NestedTypes(){} // RVA: 0xD05CA0
        public void get_NestedEnums(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0x6500F70
        public void .cctor(){} // RVA: 0x6500FB0
    }

    public class GeneratedCodeInfo : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _repeated_annotation_codec;
        public object annotation_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64F5640
        public void get_Descriptor(){} // RVA: 0x64F56A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64F5760
        public void .ctor(){} // RVA: 0x64F5870
        public void Clone(){} // RVA: 0x64F5A10
        public void get_Annotation(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x64F5CE0
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x64F5D90
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64F5DE0
        public void CalculateSize(){} // RVA: 0x64F5EA0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64F6090
        public void .cctor(){} // RVA: 0x64F6190
    }

    public class IDescriptor
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_FullName(){} // RVA: 0x87C0A0
        public void get_File(){} // RVA: 0x87C0A0
    }

    public class IFieldAccessor
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x87C0A0
        public void Clear(){} // RVA: 0x894320
        public void GetValue(){} // RVA: 0x87C540
        public void HasValue(){} // RVA: 0x87D350
        public void SetValue(){} // RVA: 0x8943B0
        public void h(){} // RVA: 0xCFA58F8
    }

    public class MapFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6501190
        public void Clear(){} // RVA: 0x65011A0
        public void HasValue(){} // RVA: 0x6501260
        public void SetValue(){} // RVA: 0x65012B0
    }

    public class MessageDescriptor : DescriptorBase
    {
        public object WellKnownTypeNames;
        public object fieldsInDeclarationOrder;
        public object fieldsInNumberOrder;
        public object jsonFieldMap;
        public object _proto;
        public object _clrType;
        public object _parser;
        public object _containingType;
        public object _fields;
        public object _extensions;
        public object _nestedTypes;
        public object _enumTypes;
        public object _oneofs;
        public object _realOneofCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6501300
        public void CreateJsonFieldMap(){} // RVA: 0x65020A0
        public void get_Name(){} // RVA: 0x6502430
        public void GetNestedDescriptorListForField(){} // RVA: 0x65024A0
        public void get_Proto(){} // RVA: 0xBC1B30
        public void get_ClrType(){} // RVA: 0xBBF8F0
        public void get_Parser(){} // RVA: 0xBE58B0
        public void get_IsWellKnownType(){} // RVA: 0x6502580
        public void get_IsWrapperType(){} // RVA: 0x6502690
        public void get_Fields(){} // RVA: 0xBE2C60
        public void get_Extensions(){} // RVA: 0xBBFF90
        public void get_NestedTypes(){} // RVA: 0xC10050
        public void get_EnumTypes(){} // RVA: 0xCD3320
        public void get_Oneofs(){} // RVA: 0xCD48B0
        public void FindFieldByName(){} // RVA: 0x6502780
        public void FindFieldByNumber(){} // RVA: 0x6502820
        public void CrossLink(){} // RVA: 0x65029A0
        public void .cctor(){} // RVA: 0x6502F60
    }

    public class MessageOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object MessageSetWireFormatDefaultValue;
        public object messageSetWireFormat_;
        public object NoStandardDescriptorAccessorDefaultValue;
        public object noStandardDescriptorAccessor_;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object MapEntryDefaultValue;
        public object mapEntry_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64E7840
        public void get_Descriptor(){} // RVA: 0x64E78A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64E7960
        public void .ctor(){} // RVA: 0x64E7B10
        public void Clone(){} // RVA: 0x64E7D40
        public void get_MessageSetWireFormat(){} // RVA: 0x64E7DA0
        public void set_MessageSetWireFormat(){} // RVA: 0x64E7E10
        public void get_HasMessageSetWireFormat(){} // RVA: 0x64E43B0
        public void ClearMessageSetWireFormat(){} // RVA: 0x64E43C0
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x64E7E20
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x64E7E90
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x64E41D0
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x64E41E0
        public void get_Deprecated(){} // RVA: 0x64E7EA0
        public void set_Deprecated(){} // RVA: 0x64E7F10
        public void get_HasDeprecated(){} // RVA: 0x64E45C0
        public void ClearDeprecated(){} // RVA: 0x64E45D0
        public void get_MapEntry(){} // RVA: 0x64E7F20
        public void set_MapEntry(){} // RVA: 0x64E7F90
        public void get_HasMapEntry(){} // RVA: 0x64E4660
        public void ClearMapEntry(){} // RVA: 0x64E4670
        public void get_UninterpretedOption(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0x64E8000
        public void GetHashCode(){} // RVA: 0x64E8180
        public void ToString(){} // RVA: 0x64E82C0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64E8310
        public void CalculateSize(){} // RVA: 0x64E84A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64E8760
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64E8930
    }

    public class MethodDescriptor : DescriptorBase
    {
        public object proto;
        public object service;
        public object inputType;
        public object outputType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65036F0
        public void get_Proto(){} // RVA: 0xB70160
        public void get_Name(){} // RVA: 0x65038C0
        public void CrossLink(){} // RVA: 0x6503930
    }

    public class MethodDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object NameDefaultValue;
        public object name_;
        public object InputTypeDefaultValue;
        public object inputType_;
        public object OutputTypeDefaultValue;
        public object outputType_;
        public object options_;
        public object ClientStreamingDefaultValue;
        public object clientStreaming_;
        public object ServerStreamingDefaultValue;
        public object serverStreaming_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64E1AB0
        public void get_Descriptor(){} // RVA: 0x64E1B10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64E1BD0
        public void .ctor(){} // RVA: 0x64E1CC0
        public void Clone(){} // RVA: 0x64E1F60
        public void get_Name(){} // RVA: 0x64E1FC0
        public void set_Name(){} // RVA: 0x64E2030
        public void get_HasName(){} // RVA: 0x26C1120
        public void ClearName(){} // RVA: 0x64D1270
        public void get_InputType(){} // RVA: 0x64E2130
        public void set_InputType(){} // RVA: 0x64E21A0
        public void get_HasInputType(){} // RVA: 0x64E22A0
        public void ClearInputType(){} // RVA: 0x34243A0
        public void get_OutputType(){} // RVA: 0x64E22B0
        public void set_OutputType(){} // RVA: 0x64E2320
        public void get_HasOutputType(){} // RVA: 0x5BC22D0
        public void ClearOutputType(){} // RVA: 0x64E2420
        public void get_Options(){} // RVA: 0xD05CA0
        public void set_Options(){} // RVA: 0xD09D70
        public void get_ClientStreaming(){} // RVA: 0x64E2480
        public void set_ClientStreaming(){} // RVA: 0x64E24F0
        public void get_HasClientStreaming(){} // RVA: 0x64D65D0
        public void ClearClientStreaming(){} // RVA: 0x64D65E0
        public void get_ServerStreaming(){} // RVA: 0x64E2500
        public void set_ServerStreaming(){} // RVA: 0x64E2570
        public void get_HasServerStreaming(){} // RVA: 0x64D6670
        public void ClearServerStreaming(){} // RVA: 0x64D6680
        public void Equals(){} // RVA: 0x64E25E0
        public void GetHashCode(){} // RVA: 0x64E27E0
        public void ToString(){} // RVA: 0x64E2940
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64E2990
        public void CalculateSize(){} // RVA: 0x64E2AC0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64E2FD0
        public void .cctor(){} // RVA: 0x64E31B0
    }

    public class MethodOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object IdempotencyLevelDefaultValue;
        public object idempotencyLevel_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64EEBE0
        public void get_Descriptor(){} // RVA: 0x64EEC40
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64EED00
        public void .ctor(){} // RVA: 0x64EEEB0
        public void Clone(){} // RVA: 0x64EF0D0
        public void get_Deprecated(){} // RVA: 0x64EF130
        public void set_Deprecated(){} // RVA: 0x64E7E10
        public void get_HasDeprecated(){} // RVA: 0x64E43B0
        public void ClearDeprecated(){} // RVA: 0x64E43C0
        public void get_IdempotencyLevel(){} // RVA: 0x64EF1A0
        public void set_IdempotencyLevel(){} // RVA: 0x64EF210
        public void get_HasIdempotencyLevel(){} // RVA: 0x64E41D0
        public void ClearIdempotencyLevel(){} // RVA: 0x64E41E0
        public void get_UninterpretedOption(){} // RVA: 0xD33E60
        public void Equals(){} // RVA: 0x64EF390
        public void GetHashCode(){} // RVA: 0x64EF4D0
        public void ToString(){} // RVA: 0x64EF590
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64EF5E0
        public void CalculateSize(){} // RVA: 0x64EF720
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64EFA20
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64EFBA0
    }

    public class OneofAccessor : Object
    {
        public object caseDelegate;
        public object clearDelegate;
        public object _descriptor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6503CD0
        public void ForRegularOneof(){} // RVA: 0x6503DD0
        public void ForSyntheticOneof(){} // RVA: 0x6503FD0
        public void get_Descriptor(){} // RVA: 0xB700F0
        public void Clear(){} // RVA: 0x12751C0
        public void GetCaseFieldDescriptor(){} // RVA: 0x6504160
        public void h(){} // RVA: 0xCF00CA8
    }

    public class OneofDescriptor : DescriptorBase
    {
        public object containingType;
        public object fields;
        public object accessor;
        public object _proto;
        public object _isSynthetic;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6504320
        public void get_Name(){} // RVA: 0x6504650
        public void get_Proto(){} // RVA: 0xBC1B30
        public void get_ContainingType(){} // RVA: 0xB70160
        public void get_Fields(){} // RVA: 0xD33E60
        public void get_IsSynthetic(){} // RVA: 0xBFDA40
        public void get_Accessor(){} // RVA: 0xD05CA0
        public void CrossLink(){} // RVA: 0x65046C0
        public void CreateAccessor(){} // RVA: 0x6504A40
    }

    public class OneofDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object NameDefaultValue;
        public object name_;
        public object options_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64DB600
        public void get_Descriptor(){} // RVA: 0x64DB660
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64DB720
        public void .ctor(){} // RVA: 0x64DB810
        public void Clone(){} // RVA: 0x64DB9F0
        public void get_Name(){} // RVA: 0x64DBA50
        public void set_Name(){} // RVA: 0x64DBAC0
        public void get_HasName(){} // RVA: 0x25E9250
        public void ClearName(){} // RVA: 0x30FBB60
        public void get_Options(){} // RVA: 0xB700F0
        public void set_Options(){} // RVA: 0xB70100
        public void Equals(){} // RVA: 0x64DBD10
        public void GetHashCode(){} // RVA: 0x64DBE30
        public void ToString(){} // RVA: 0x64DBED0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64DBF20
        public void CalculateSize(){} // RVA: 0x64DBFA0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64DC390
        public void .cctor(){} // RVA: 0x64DC4A0
    }

    public class OneofOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64EA650
        public void get_Descriptor(){} // RVA: 0x64EA6B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64EA770
        public void .ctor(){} // RVA: 0x64EA920
        public void Clone(){} // RVA: 0x64EAB30
        public void get_UninterpretedOption(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0x64EACD0
        public void GetHashCode(){} // RVA: 0x64D86F0
        public void ToString(){} // RVA: 0x64EADC0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64EAE10
        public void CalculateSize(){} // RVA: 0x64EAF00
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64EB140
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64EB270
    }

    public class OriginalNameAttribute : Attribute
    {
        public object _name;
        public object _preferredAlias;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_PreferredAlias(){} // RVA: 0xB5DD50
        public void set_PreferredAlias(){} // RVA: 0xB5DD60
        public void .ctor(){} // RVA: 0x6504F80
    }

    public class PackageDescriptor : Object
    {
        public object name;
        public object fullName;
        public object file;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6505080
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_FullName(){} // RVA: 0xB465B0
        public void get_File(){} // RVA: 0xB700F0
    }

    public class ReflectionUtil : Object
    {
        public object EmptyTypes;
        public object _canConvertEnumFuncToInt32Func;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6505190
        public void ForceInitialize(){} // RVA: 0x8942F0
        public void CreateFuncIMessageObject(){} // RVA: 0x65056D0
        public void CreateFuncIMessageInt32(){} // RVA: 0x6505820
        public void CreateActionIMessageObject(){} // RVA: 0x6505950
        public void CreateActionIMessage(){} // RVA: 0x6505AD0
        public void CreateFuncIMessageBool(){} // RVA: 0x6505C50
        public void CreateExtensionHelper(){} // RVA: 0x6505DA0
        public void GetReflectionHelper(){} // RVA: 0x6506050
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x6506220
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x6506280
        public void SampleEnumMethod(){} // RVA: 0xDAC980
    }

    public class RepeatedFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6501190
        public void Clear(){} // RVA: 0x6506440
        public void HasValue(){} // RVA: 0x6506500
        public void SetValue(){} // RVA: 0x6506550
    }

    public class ServiceDescriptor : DescriptorBase
    {
        public object proto;
        public object methods;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65065A0
        public void get_Name(){} // RVA: 0x6506900
        public void GetNestedDescriptorListForField(){} // RVA: 0x6506970
        public void CrossLink(){} // RVA: 0x65069E0
    }

    public class ServiceDescriptorProto : Object
    {
        public object _parser;
        public object _unknownFields;
        public object NameDefaultValue;
        public object name_;
        public object _repeated_method_codec;
        public object method_;
        public object options_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64E0440
        public void get_Descriptor(){} // RVA: 0x64E04A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64E0560
        public void .ctor(){} // RVA: 0x64E0710
        public void Clone(){} // RVA: 0x64E0990
        public void get_Name(){} // RVA: 0x64E09F0
        public void set_Name(){} // RVA: 0x64E0A60
        public void get_HasName(){} // RVA: 0x25E9250
        public void ClearName(){} // RVA: 0x30FBB60
        public void get_Method(){} // RVA: 0xB700F0
        public void get_Options(){} // RVA: 0xB70160
        public void set_Options(){} // RVA: 0xB44DC0
        public void Equals(){} // RVA: 0x64E0CF0
        public void GetHashCode(){} // RVA: 0x64E0E50
        public void ToString(){} // RVA: 0x64E0F10
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64E0F60
        public void CalculateSize(){} // RVA: 0x64E1070
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64E1520
        public void .cctor(){} // RVA: 0x64E16B0
    }

    public class ServiceOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _extensions;
        public object _hasBits0;
        public object DeprecatedDefaultValue;
        public object deprecated_;
        public object _repeated_uninterpretedOption_codec;
        public object uninterpretedOption_;

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x64EDA60
        public void get_Descriptor(){} // RVA: 0x64EDAC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64EDB80
        public void .ctor(){} // RVA: 0x64EDD30
        public void Clone(){} // RVA: 0x64EDF50
        public void get_Deprecated(){} // RVA: 0x64EDFB0
        public void set_Deprecated(){} // RVA: 0x64E7E10
        public void get_HasDeprecated(){} // RVA: 0x64E43B0
        public void ClearDeprecated(){} // RVA: 0x64E43C0
        public void get_UninterpretedOption(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0x64EE170
        public void GetHashCode(){} // RVA: 0x64EE280
        public void ToString(){} // RVA: 0x64EE330
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64EE380
        public void CalculateSize(){} // RVA: 0x64EE4A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64EE700
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x64EE850
    }

    public class SingleFieldAccessor : FieldAccessorBase
    {
        public object setValueDelegate;
        public object clearDelegate;
        public object hasDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6506DA0
        public void GetDefaultValue(){} // RVA: 0x6507940
        public void Clear(){} // RVA: 0x3DDB1D0
        public void HasValue(){} // RVA: 0x6507E80
        public void SetValue(){} // RVA: 0x6507EB0
    }

    public class SourceCodeInfo : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _repeated_location_codec;
        public object location_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64F2D50
        public void get_Descriptor(){} // RVA: 0x64F2DB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64F2E70
        public void .ctor(){} // RVA: 0x64F2F80
        public void Clone(){} // RVA: 0x64F3120
        public void get_Location(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x64F33F0
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x64F34A0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64F34F0
        public void CalculateSize(){} // RVA: 0x64F35B0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64F37A0
        public void .cctor(){} // RVA: 0x64F38A0
    }

    public class TypeRegistry : Object
    {
        public object _empty;
        public object fullNameToMessageMap;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x65081B0
        public void .ctor(){} // RVA: 0xB44D60
        public void Find(){} // RVA: 0x6508210
        public void .cctor(){} // RVA: 0x6508280
    }

    public class UninterpretedOption : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object _repeated_name_codec;
        public object name_;
        public object IdentifierValueDefaultValue;
        public object identifierValue_;
        public object PositiveIntValueDefaultValue;
        public object positiveIntValue_;
        public object NegativeIntValueDefaultValue;
        public object negativeIntValue_;
        public object DoubleValueDefaultValue;
        public object doubleValue_;
        public object StringValueDefaultValue;
        public object stringValue_;
        public object AggregateValueDefaultValue;
        public object aggregateValue_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x64EFF40
        public void get_Descriptor(){} // RVA: 0x64EFFA0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64F0060
        public void .ctor(){} // RVA: 0x64F0170
        public void Clone(){} // RVA: 0x64F0410
        public void get_Name(){} // RVA: 0xB700F0
        public void get_IdentifierValue(){} // RVA: 0x64F0470
        public void set_IdentifierValue(){} // RVA: 0x64F04E0
        public void get_HasIdentifierValue(){} // RVA: 0x64E22A0
        public void ClearIdentifierValue(){} // RVA: 0x34243A0
        public void get_PositiveIntValue(){} // RVA: 0x64F05E0
        public void set_PositiveIntValue(){} // RVA: 0x64F0650
        public void get_HasPositiveIntValue(){} // RVA: 0x64D65D0
        public void ClearPositiveIntValue(){} // RVA: 0x64D65E0
        public void get_NegativeIntValue(){} // RVA: 0x64F0660
        public void set_NegativeIntValue(){} // RVA: 0x64F06D0
        public void get_HasNegativeIntValue(){} // RVA: 0x64D6670
        public void ClearNegativeIntValue(){} // RVA: 0x64D6680
        public void get_DoubleValue(){} // RVA: 0x64F06E0
        public void set_DoubleValue(){} // RVA: 0x64F0750
        public void get_HasDoubleValue(){} // RVA: 0x64D9870
        public void ClearDoubleValue(){} // RVA: 0x64D9880
        public void get_StringValue(){} // RVA: 0x64F0760
        public void set_StringValue(){} // RVA: 0x64F07D0
        public void get_HasStringValue(){} // RVA: 0x64F08D0
        public void ClearStringValue(){} // RVA: 0x64D9D50
        public void get_AggregateValue(){} // RVA: 0x64F0990
        public void set_AggregateValue(){} // RVA: 0x64F0A00
        public void get_HasAggregateValue(){} // RVA: 0x5BC3080
        public void ClearAggregateValue(){} // RVA: 0xD1B6F0
        public void Equals(){} // RVA: 0x64F0B60
        public void GetHashCode(){} // RVA: 0x64F0DD0
        public void ToString(){} // RVA: 0x64F0F80
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64F0FD0
        public void CalculateSize(){} // RVA: 0x64F11A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64F15E0
        public void .cctor(){} // RVA: 0x64F17F0
    }

}