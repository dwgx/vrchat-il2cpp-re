// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 49
// Methods: 944

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF852D680
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_FullName(){} // RVA: 0x7FFAF2D907C0
        public void get_File(){} // RVA: 0x7FFAF2DBB0C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAF2FC9240
    }

    public class DescriptorDeclaration
    {
        // ── Methods ──
        public void get_StartLine(){} // RVA: 0x7FFAF306ED50
        public void .ctor(){} // RVA: 0x7FFAF852D740
        public void FromProto(){} // RVA: 0x7FFAF852DC80
    }

    public class DescriptorPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF852DCF0
        public void ImportPublicDependencies(){} // RVA: 0x7FFAF852E3B0
        public void FindSymbol(){} // RVA: 0x7FFAF2D33FA0
        public void AddPackage(){} // RVA: 0x7FFAF852E5E0
        public void AddSymbol(){} // RVA: 0x7FFAF852E9E0
        public void ValidateSymbolName(){} // RVA: 0x7FFAF852EE00
        public void FindFieldByNumber(){} // RVA: 0x7FFAF852F080
        public void AddFieldByNumber(){} // RVA: 0x7FFAF852F1E0
        public void AddEnumValueByNumber(){} // RVA: 0x7FFAF852F600
        public void LookupSymbol(){} // RVA: 0x7FFAF852F850
        public void .cctor(){} // RVA: 0x7FFAF852FB40
    }

    public class DescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8509380
        public void get_Descriptor(){} // RVA: 0x7FFAF85093E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85094A0
        public void .ctor(){} // RVA: 0x7FFAF85099A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8509F90
        public void get_Name(){} // RVA: 0x7FFAF8509FF0
        public void set_Name(){} // RVA: 0x7FFAF850A060
        public void get_HasName(){} // RVA: 0x7FFAF47EB060
        public void ClearName(){} // RVA: 0x7FFAF515D280
        public void get_Field(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Extension(){} // RVA: 0x7FFAF2DBB130
        public void get_NestedType(){} // RVA: 0x7FFAF30E74D0
        public void get_EnumType(){} // RVA: 0x7FFAF2F476A0
        public void get_ExtensionRange(){} // RVA: 0x7FFAF2E0A740
        public void get_OneofDecl(){} // RVA: 0x7FFAF2E08730
        public void get_Options(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Options(){} // RVA: 0x7FFAF2EE54D0
        public void get_ReservedRange(){} // RVA: 0x7FFAF2E55500
        public void get_ReservedName(){} // RVA: 0x7FFAF2E2B370
        public void Equals(){} // RVA: 0x7FFAF850A1C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF850A490
        public void ToString(){} // RVA: 0x7FFAF850A660
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF850A6B0
        public void CalculateSize(){} // RVA: 0x7FFAF850A980
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF850B030
        public void .cctor(){} // RVA: 0x7FFAF850B4A0
    }

    public class DescriptorReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF8500A60
        public void .cctor(){} // RVA: 0x7FFAF8500AC0
    }

    public class DescriptorUtil
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x7FFAF2ABCEC0
    }

    public class DescriptorValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF852FC60
    }

    public class EnumDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF852FE00
        public void get_Name(){} // RVA: 0x7FFAF8530270
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAF85302E0
        public void get_Values(){} // RVA: 0x7FFAF2F476A0
    }

    public class EnumDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8512580
        public void get_Descriptor(){} // RVA: 0x7FFAF85125E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85126A0
        public void .ctor(){} // RVA: 0x7FFAF85128E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8512C60
        public void get_Name(){} // RVA: 0x7FFAF8512CC0
        public void set_Name(){} // RVA: 0x7FFAF8512D30
        public void get_HasName(){} // RVA: 0x7FFAF47EB060
        public void ClearName(){} // RVA: 0x7FFAF515D280
        public void get_Value(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Options(){} // RVA: 0x7FFAF2DBB130
        public void set_Options(){} // RVA: 0x7FFAF2D8EE90
        public void get_ReservedRange(){} // RVA: 0x7FFAF30E74D0
        public void get_ReservedName(){} // RVA: 0x7FFAF2F476A0
        public void Equals(){} // RVA: 0x7FFAF8512E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8513060
        public void ToString(){} // RVA: 0x7FFAF8513170
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85131C0
        public void CalculateSize(){} // RVA: 0x7FFAF8513360
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85137C0
        public void .cctor(){} // RVA: 0x7FFAF8513A20
    }

    public class EnumOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF8521230
        public void get_Descriptor(){} // RVA: 0x7FFAF8521290
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8521350
        public void .ctor(){} // RVA: 0x7FFAF8521500 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8521720
        public void get_AllowAlias(){} // RVA: 0x7FFAF8521780
        public void set_AllowAlias(){} // RVA: 0x7FFAF851DA10
        public void get_HasAllowAlias(){} // RVA: 0x7FFAF8519F80
        public void ClearAllowAlias(){} // RVA: 0x7FFAF8519F90
        public void get_Deprecated(){} // RVA: 0x7FFAF85217F0
        public void set_Deprecated(){} // RVA: 0x7FFAF851DA90
        public void get_HasDeprecated(){} // RVA: 0x7FFAF8519DA0
        public void ClearDeprecated(){} // RVA: 0x7FFAF8519DB0
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAF85219D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8521B10
        public void ToString(){} // RVA: 0x7FFAF8521C20
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8521C70
        public void CalculateSize(){} // RVA: 0x7FFAF8521DB0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8522040
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF85221C0
    }

    public class EnumValueDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85303F0
        public void get_Proto(){} // RVA: 0x7FFAF30E74D0
        public void get_Name(){} // RVA: 0x7FFAF85305B0
        public void get_Number(){} // RVA: 0x7FFAF8530620
        public void get_EnumDescriptor(){} // RVA: 0x7FFAF2DBB130
    }

    public class EnumValueDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8514AB0
        public void get_Descriptor(){} // RVA: 0x7FFAF8514B10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8514BD0
        public void .ctor(){} // RVA: 0x7FFAF8514CC0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8514EB0
        public void get_Name(){} // RVA: 0x7FFAF8514F10
        public void set_Name(){} // RVA: 0x7FFAF8514F80
        public void get_HasName(){} // RVA: 0x7FFAF48EEC10
        public void ClearName(){} // RVA: 0x7FFAF8507060
        public void get_Number(){} // RVA: 0x7FFAF8515080
        public void set_Number(){} // RVA: 0x7FFAF850F540
        public void get_HasNumber(){} // RVA: 0x7FFAF850C3B0
        public void ClearNumber(){} // RVA: 0x7FFAF850C3C0
        public void get_Options(){} // RVA: 0x7FFAF30E74D0
        public void set_Options(){} // RVA: 0x7FFAF2DBB890
        public void Equals(){} // RVA: 0x7FFAF8515250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8515380
        public void ToString(){} // RVA: 0x7FFAF8515430
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8515480
        public void CalculateSize(){} // RVA: 0x7FFAF8515530
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8515980
        public void .cctor(){} // RVA: 0x7FFAF8515AB0
    }

    public class EnumValueOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF8522560
        public void get_Descriptor(){} // RVA: 0x7FFAF85225C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8522680
        public void .ctor(){} // RVA: 0x7FFAF8522830 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8522A40
        public void get_Deprecated(){} // RVA: 0x7FFAF8522AA0
        public void set_Deprecated(){} // RVA: 0x7FFAF851DA10
        public void get_HasDeprecated(){} // RVA: 0x7FFAF8519F80
        public void ClearDeprecated(){} // RVA: 0x7FFAF8519F90
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAF8522C60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8522D70
        public void ToString(){} // RVA: 0x7FFAF8522E40
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8522E90
        public void CalculateSize(){} // RVA: 0x7FFAF8522FA0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8523200
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8523350
    }

    public class ExtensionAccessor : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8530640
        public void get_Descriptor(){} // RVA: 0x7FFAF2DBB0C0
        public void Clear(){} // RVA: 0x7FFAF85307B0
        public void HasValue(){} // RVA: 0x7FFAF8530810
        public void GetValue(){} // RVA: 0x7FFAF8530870
        public void SetValue(){} // RVA: 0x7FFAF85308D0
    }

    public class ExtensionCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8530B40 | overloaded x2
        public void get_UnorderedExtensions(){} // RVA: 0x7FFAF2DBB0C0
        public void CrossLink(){} // RVA: 0x7FFAF8530D30
    }

    public class ExtensionRangeOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF850DD60
        public void get_Descriptor(){} // RVA: 0x7FFAF850DDC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF850DE80
        public void .ctor(){} // RVA: 0x7FFAF850E030 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF850E240
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAF850E3E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF850E4D0
        public void ToString(){} // RVA: 0x7FFAF850E560
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF850E5B0
        public void CalculateSize(){} // RVA: 0x7FFAF850E6A0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF850E8E0
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF850EA10
    }

    public class FieldAccessorBase : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8531CE0
        public void get_Descriptor(){} // RVA: 0x7FFAF2D907C0
        public void GetValue(){} // RVA: 0x7FFAF533D780
        public void HasValue(){} // RVA: 0x7FFAF2ABDE40
        public void Clear(){} // RVA: 0x7FFAF2AD4B10
        public void SetValue(){} // RVA: 0x7FFAF2ADDC60
    }

    public class FieldDescriptor
    {
        // ── Methods ──
        public void get_ContainingType(){} // RVA: 0x7FFAF2E2E0E0
        public void get_ContainingOneof(){} // RVA: 0x7FFAF2E55500
        public void get_RealContainingOneof(){} // RVA: 0x7FFAF8531F30
        public void get_JsonName(){} // RVA: 0x7FFAF2E2B370
        public void get_PropertyName(){} // RVA: 0x7FFAF2E08D50
        public void get_HasPresence(){} // RVA: 0x7FFAF8531F50
        public void get_Proto(){} // RVA: 0x7FFAF2E55590
        public void get_Extension(){} // RVA: 0x7FFAF2F77C50
        public void .ctor(){} // RVA: 0x7FFAF8532000
        public void get_Name(){} // RVA: 0x7FFAF85327A0
        public void get_Accessor(){} // RVA: 0x7FFAF2E08730
        public void GetFieldTypeFromProtoType(){} // RVA: 0x7FFAF8532810
        public void get_IsRepeated(){} // RVA: 0x7FFAF8532980
        public void get_IsMap(){} // RVA: 0x7FFAF85329B0
        public void get_FieldType(){} // RVA: 0x7FFAF2E2E080
        public void get_FieldNumber(){} // RVA: 0x7FFAF85329F0
        public void CompareTo(){} // RVA: 0x7FFAF8532A10
        public void get_MessageType(){} // RVA: 0x7FFAF8532AB0
        public void get_ExtendeeType(){} // RVA: 0x7FFAF8532B20
        public void CrossLink(){} // RVA: 0x7FFAF8532BA0
        public void CreateAccessor(){} // RVA: 0x7FFAF85331D0
    }

    public class FieldDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF850ED90
        public void get_Descriptor(){} // RVA: 0x7FFAF850EDF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF850EEB0
        public void .ctor(){} // RVA: 0x7FFAF850EFA0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF850F300
        public void get_Name(){} // RVA: 0x7FFAF850F360
        public void set_Name(){} // RVA: 0x7FFAF850F3D0
        public void get_HasName(){} // RVA: 0x7FFAF48EEC10
        public void ClearName(){} // RVA: 0x7FFAF8507060
        public void get_Number(){} // RVA: 0x7FFAF850F4D0
        public void set_Number(){} // RVA: 0x7FFAF850F540
        public void get_HasNumber(){} // RVA: 0x7FFAF850C3B0
        public void ClearNumber(){} // RVA: 0x7FFAF850C3C0
        public void get_Label(){} // RVA: 0x7FFAF850F550
        public void set_Label(){} // RVA: 0x7FFAF850F5C0
        public void get_HasLabel(){} // RVA: 0x7FFAF850C450
        public void ClearLabel(){} // RVA: 0x7FFAF850C460
        public void get_Type(){} // RVA: 0x7FFAF850F5D0
        public void set_Type(){} // RVA: 0x7FFAF850F640
        public void get_HasType(){} // RVA: 0x7FFAF850F650
        public void ClearType(){} // RVA: 0x7FFAF850F660
        public void get_TypeName(){} // RVA: 0x7FFAF850F670
        public void set_TypeName(){} // RVA: 0x7FFAF850F6E0
        public void get_HasTypeName(){} // RVA: 0x7FFAF47D58F0
        public void ClearTypeName(){} // RVA: 0x7FFAF3BB74B0
        public void get_Extendee(){} // RVA: 0x7FFAF850F7E0
        public void set_Extendee(){} // RVA: 0x7FFAF850F850
        public void get_HasExtendee(){} // RVA: 0x7FFAF7C055F0
        public void ClearExtendee(){} // RVA: 0x7FFAF850F950
        public void get_DefaultValue(){} // RVA: 0x7FFAF850F9B0
        public void set_DefaultValue(){} // RVA: 0x7FFAF850FA20
        public void get_HasDefaultValue(){} // RVA: 0x7FFAF850FB20
        public void ClearDefaultValue(){} // RVA: 0x7FFAF850FB30
        public void get_OneofIndex(){} // RVA: 0x7FFAF850FB90
        public void set_OneofIndex(){} // RVA: 0x7FFAF850FC00
        public void get_HasOneofIndex(){} // RVA: 0x7FFAF850FC10
        public void ClearOneofIndex(){} // RVA: 0x7FFAF850FC20
        public void get_JsonName(){} // RVA: 0x7FFAF850FC30
        public void set_JsonName(){} // RVA: 0x7FFAF850FCA0
        public void get_HasJsonName(){} // RVA: 0x7FFAF7C063D0
        public void ClearJsonName(){} // RVA: 0x7FFAF850FDA0
        public void get_Options(){} // RVA: 0x7FFAF2E2B370
        public void set_Options(){} // RVA: 0x7FFAF2E2B380
        public void get_Proto3Optional(){} // RVA: 0x7FFAF850FE00
        public void set_Proto3Optional(){} // RVA: 0x7FFAF850FE70
        public void get_HasProto3Optional(){} // RVA: 0x7FFAF850FE80
        public void ClearProto3Optional(){} // RVA: 0x7FFAF850FE90
        public void Equals(){} // RVA: 0x7FFAF850FF00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8510210
        public void ToString(){} // RVA: 0x7FFAF8510410
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8510460
        public void CalculateSize(){} // RVA: 0x7FFAF8510670
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8510C30
        public void .cctor(){} // RVA: 0x7FFAF8510EF0
    }

    public class FieldOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF851E910
        public void get_Descriptor(){} // RVA: 0x7FFAF851E970
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF851EA30
        public void .ctor(){} // RVA: 0x7FFAF851EBE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF851EE20
        public void get_Ctype(){} // RVA: 0x7FFAF851EE80
        public void set_Ctype(){} // RVA: 0x7FFAF851EEF0
        public void get_HasCtype(){} // RVA: 0x7FFAF8519F80
        public void ClearCtype(){} // RVA: 0x7FFAF8519F90
        public void get_Packed(){} // RVA: 0x7FFAF851EF00
        public void set_Packed(){} // RVA: 0x7FFAF851EF70
        public void get_HasPacked(){} // RVA: 0x7FFAF8519DA0
        public void ClearPacked(){} // RVA: 0x7FFAF8519DB0
        public void get_Jstype(){} // RVA: 0x7FFAF851EF80
        public void set_Jstype(){} // RVA: 0x7FFAF851EFF0
        public void get_HasJstype(){} // RVA: 0x7FFAF851A2D0
        public void ClearJstype(){} // RVA: 0x7FFAF851A2E0
        public void get_Lazy(){} // RVA: 0x7FFAF851F000
        public void set_Lazy(){} // RVA: 0x7FFAF851F070
        public void get_HasLazy(){} // RVA: 0x7FFAF851A230
        public void ClearLazy(){} // RVA: 0x7FFAF851A240
        public void get_UnverifiedLazy(){} // RVA: 0x7FFAF851F080
        public void set_UnverifiedLazy(){} // RVA: 0x7FFAF851F0F0
        public void get_HasUnverifiedLazy(){} // RVA: 0x7FFAF851A410
        public void ClearUnverifiedLazy(){} // RVA: 0x7FFAF851A420
        public void get_Deprecated(){} // RVA: 0x7FFAF851F100
        public void set_Deprecated(){} // RVA: 0x7FFAF851F170
        public void get_HasDeprecated(){} // RVA: 0x7FFAF851A190
        public void ClearDeprecated(){} // RVA: 0x7FFAF851A1A0
        public void get_Weak(){} // RVA: 0x7FFAF851F180
        public void set_Weak(){} // RVA: 0x7FFAF851F1F0
        public void get_HasWeak(){} // RVA: 0x7FFAF8519E40
        public void ClearWeak(){} // RVA: 0x7FFAF8519E50
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2F476A0
        public void Equals(){} // RVA: 0x7FFAF851F260 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF851F440
        public void ToString(){} // RVA: 0x7FFAF851F5F0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF851F640
        public void CalculateSize(){} // RVA: 0x7FFAF851F850
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF851FC50
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF851FEA0
    }

    public class FileDescriptor
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8533590
        public void .ctor(){} // RVA: 0x7FFAF8533640
        public void CreateDeclarationMap(){} // RVA: 0x7FFAF8533FC0
        public void FindDescriptorForPath(){} // RVA: 0x7FFAF85342B0
        public void GetDescriptorFromList(){} // RVA: 0x7FFAF8534660
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAF85347A0
        public void ComputeFullName(){} // RVA: 0x7FFAF8534880
        public void DeterminePublicDependencies(){} // RVA: 0x7FFAF8534920
        public void get_Proto(){} // RVA: 0x7FFAF2D907C0
        public void get_Syntax(){} // RVA: 0x7FFAF3210030
        public void get_Name(){} // RVA: 0x7FFAF8534D70
        public void get_Package(){} // RVA: 0x7FFAF8534DE0
        public void get_MessageTypes(){} // RVA: 0x7FFAF2DBB130
        public void get_EnumTypes(){} // RVA: 0x7FFAF30E74D0
        public void get_Services(){} // RVA: 0x7FFAF2F476A0
        public void get_Extensions(){} // RVA: 0x7FFAF2E0A740
        public void get_Dependencies(){} // RVA: 0x7FFAF2E08730
        public void get_PublicDependencies(){} // RVA: 0x7FFAF2E2E0E0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x7FFAF8534E50
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x7FFAF44EF520
        public void get_DescriptorPool(){} // RVA: 0x7FFAF2E2B370
        public void BuildFrom(){} // RVA: 0x7FFAF8534E60
        public void CrossLink(){} // RVA: 0x7FFAF8534FF0
        public void FromGeneratedCode(){} // RVA: 0x7FFAF85353A0
        public void GetAllExtensions(){} // RVA: 0x7FFAF8535970
        public void GetAllGeneratedExtensions(){} // RVA: 0x7FFAF8535B10
        public void GetAllDependedExtensions(){} // RVA: 0x7FFAF8535D30
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x7FFAF8536140
        public void ToString(){} // RVA: 0x7FFAF85364B0
        public void ForceReflectionInitialization(){} // RVA: 0x7FFAF2AD4A80
    }

    public class FileDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8506080
        public void get_Descriptor(){} // RVA: 0x7FFAF85060E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85061A0
        public void .ctor(){} // RVA: 0x7FFAF85066B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8506D20
        public void get_Name(){} // RVA: 0x7FFAF8506D80
        public void set_Name(){} // RVA: 0x7FFAF8506DF0
        public void get_HasName(){} // RVA: 0x7FFAF47EB060
        public void ClearName(){} // RVA: 0x7FFAF515D280
        public void get_Package(){} // RVA: 0x7FFAF8506EF0
        public void set_Package(){} // RVA: 0x7FFAF8506F60
        public void get_HasPackage(){} // RVA: 0x7FFAF48EEC10
        public void ClearPackage(){} // RVA: 0x7FFAF8507060
        public void get_Dependency(){} // RVA: 0x7FFAF2DBB130
        public void get_PublicDependency(){} // RVA: 0x7FFAF30E74D0
        public void get_WeakDependency(){} // RVA: 0x7FFAF2F476A0
        public void get_MessageType(){} // RVA: 0x7FFAF2E0A740
        public void get_EnumType(){} // RVA: 0x7FFAF2E08730
        public void get_Service(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Extension(){} // RVA: 0x7FFAF2E55500
        public void get_Options(){} // RVA: 0x7FFAF2E2B370
        public void set_Options(){} // RVA: 0x7FFAF2E2B380
        public void get_SourceCodeInfo(){} // RVA: 0x7FFAF2E08D50
        public void set_SourceCodeInfo(){} // RVA: 0x7FFAF2E08D60
        public void get_Syntax(){} // RVA: 0x7FFAF85070C0
        public void set_Syntax(){} // RVA: 0x7FFAF8507130
        public void get_HasSyntax(){} // RVA: 0x7FFAF8507230
        public void ClearSyntax(){} // RVA: 0x7FFAF8507240
        public void Equals(){} // RVA: 0x7FFAF8507300 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8507680
        public void ToString(){} // RVA: 0x7FFAF85078B0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8507900
        public void CalculateSize(){} // RVA: 0x7FFAF8507C00
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8508500
        public void .cctor(){} // RVA: 0x7FFAF85089F0
    }

    public class FileDescriptorSet
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8505110
        public void get_Descriptor(){} // RVA: 0x7FFAF8505170
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8505230
        public void .ctor(){} // RVA: 0x7FFAF85053E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8505580
        public void get_File(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF8505850 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF8505900
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8505950
        public void CalculateSize(){} // RVA: 0x7FFAF8505A10
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8505C00
        public void .cctor(){} // RVA: 0x7FFAF8505D00
    }

    public class FileOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF8519170
        public void get_Descriptor(){} // RVA: 0x7FFAF85191D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8519290
        public void .ctor(){} // RVA: 0x7FFAF8519440 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85199E0
        public void get_JavaPackage(){} // RVA: 0x7FFAF8519A40
        public void set_JavaPackage(){} // RVA: 0x7FFAF8519AB0
        public void get_HasJavaPackage(){} // RVA: 0x7FFAF8517FD0
        public void ClearJavaPackage(){} // RVA: 0x7FFAF54ADA70
        public void get_JavaOuterClassname(){} // RVA: 0x7FFAF8519BB0
        public void set_JavaOuterClassname(){} // RVA: 0x7FFAF8519C20
        public void get_HasJavaOuterClassname(){} // RVA: 0x7FFAF7C055E0
        public void ClearJavaOuterClassname(){} // RVA: 0x7FFAF8518150
        public void get_JavaMultipleFiles(){} // RVA: 0x7FFAF8519D20
        public void set_JavaMultipleFiles(){} // RVA: 0x7FFAF8519D90
        public void get_HasJavaMultipleFiles(){} // RVA: 0x7FFAF8519DA0
        public void ClearJavaMultipleFiles(){} // RVA: 0x7FFAF8519DB0
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFAF8519DC0
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFAF8519E30
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x7FFAF8519E40
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x7FFAF8519E50
        public void get_JavaStringCheckUtf8(){} // RVA: 0x7FFAF8519E60
        public void set_JavaStringCheckUtf8(){} // RVA: 0x7FFAF8519ED0
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x7FFAF8519EE0
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x7FFAF8519EF0
        public void get_OptimizeFor(){} // RVA: 0x7FFAF8519F00
        public void set_OptimizeFor(){} // RVA: 0x7FFAF8519F70
        public void get_HasOptimizeFor(){} // RVA: 0x7FFAF8519F80
        public void ClearOptimizeFor(){} // RVA: 0x7FFAF8519F90
        public void get_GoPackage(){} // RVA: 0x7FFAF8519FA0
        public void set_GoPackage(){} // RVA: 0x7FFAF851A010
        public void get_HasGoPackage(){} // RVA: 0x7FFAF7C055F0
        public void ClearGoPackage(){} // RVA: 0x7FFAF850F950
        public void get_CcGenericServices(){} // RVA: 0x7FFAF851A110
        public void set_CcGenericServices(){} // RVA: 0x7FFAF851A180
        public void get_HasCcGenericServices(){} // RVA: 0x7FFAF851A190
        public void ClearCcGenericServices(){} // RVA: 0x7FFAF851A1A0
        public void get_JavaGenericServices(){} // RVA: 0x7FFAF851A1B0
        public void set_JavaGenericServices(){} // RVA: 0x7FFAF851A220
        public void get_HasJavaGenericServices(){} // RVA: 0x7FFAF851A230
        public void ClearJavaGenericServices(){} // RVA: 0x7FFAF851A240
        public void get_PyGenericServices(){} // RVA: 0x7FFAF851A250
        public void set_PyGenericServices(){} // RVA: 0x7FFAF851A2C0
        public void get_HasPyGenericServices(){} // RVA: 0x7FFAF851A2D0
        public void ClearPyGenericServices(){} // RVA: 0x7FFAF851A2E0
        public void get_PhpGenericServices(){} // RVA: 0x7FFAF851A2F0
        public void set_PhpGenericServices(){} // RVA: 0x7FFAF851A360
        public void get_HasPhpGenericServices(){} // RVA: 0x7FFAF851A370
        public void ClearPhpGenericServices(){} // RVA: 0x7FFAF851A380
        public void get_Deprecated(){} // RVA: 0x7FFAF851A390
        public void set_Deprecated(){} // RVA: 0x7FFAF851A400
        public void get_HasDeprecated(){} // RVA: 0x7FFAF851A410
        public void ClearDeprecated(){} // RVA: 0x7FFAF851A420
        public void get_CcEnableArenas(){} // RVA: 0x7FFAF851A430
        public void set_CcEnableArenas(){} // RVA: 0x7FFAF851A4A0
        public void get_HasCcEnableArenas(){} // RVA: 0x7FFAF851A4B0
        public void ClearCcEnableArenas(){} // RVA: 0x7FFAF851A4C0
        public void get_ObjcClassPrefix(){} // RVA: 0x7FFAF851A4D0
        public void set_ObjcClassPrefix(){} // RVA: 0x7FFAF851A540
        public void get_HasObjcClassPrefix(){} // RVA: 0x7FFAF7C063C0
        public void ClearObjcClassPrefix(){} // RVA: 0x7FFAF2F5ED90
        public void get_CsharpNamespace(){} // RVA: 0x7FFAF851A640
        public void set_CsharpNamespace(){} // RVA: 0x7FFAF851A6B0
        public void get_HasCsharpNamespace(){} // RVA: 0x7FFAF7C063D0
        public void ClearCsharpNamespace(){} // RVA: 0x7FFAF850FDA0
        public void get_SwiftPrefix(){} // RVA: 0x7FFAF851A7B0
        public void set_SwiftPrefix(){} // RVA: 0x7FFAF851A820
        public void get_HasSwiftPrefix(){} // RVA: 0x7FFAF47C10B0
        public void ClearSwiftPrefix(){} // RVA: 0x7FFAF851A920
        public void get_PhpClassPrefix(){} // RVA: 0x7FFAF851A980
        public void set_PhpClassPrefix(){} // RVA: 0x7FFAF851A9F0
        public void get_HasPhpClassPrefix(){} // RVA: 0x7FFAF3DF8BF0
        public void ClearPhpClassPrefix(){} // RVA: 0x7FFAF33EF810
        public void get_PhpNamespace(){} // RVA: 0x7FFAF851AAF0
        public void set_PhpNamespace(){} // RVA: 0x7FFAF851AB60
        public void get_HasPhpNamespace(){} // RVA: 0x7FFAF8507230
        public void ClearPhpNamespace(){} // RVA: 0x7FFAF8507240
        public void get_PhpMetadataNamespace(){} // RVA: 0x7FFAF851AC60
        public void set_PhpMetadataNamespace(){} // RVA: 0x7FFAF851ACD0
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x7FFAF851ADD0
        public void ClearPhpMetadataNamespace(){} // RVA: 0x7FFAF2F5AF10
        public void get_RubyPackage(){} // RVA: 0x7FFAF851ADE0
        public void set_RubyPackage(){} // RVA: 0x7FFAF851AE50
        public void get_HasRubyPackage(){} // RVA: 0x7FFAF851AF50
        public void ClearRubyPackage(){} // RVA: 0x7FFAF2F5AEB0
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DCC010
        public void Equals(){} // RVA: 0x7FFAF851AFC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF851B570
        public void ToString(){} // RVA: 0x7FFAF851B9C0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF851BA10
        public void CalculateSize(){} // RVA: 0x7FFAF851BEA0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF851C620
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF851CB90
    }

    public class GeneratedClrTypeInfo
    {
        // ── Methods ──
        public void get_ClrType(){} // RVA: 0x7FFAF2DA8380
        public void set_ClrType(){} // RVA: 0x7FFAF2D8EE30
        public void get_Parser(){} // RVA: 0x7FFAF2D907C0
        public void get_PropertyNames(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Extensions(){} // RVA: 0x7FFAF2DBB130
        public void get_OneofNames(){} // RVA: 0x7FFAF30E74D0
        public void get_NestedTypes(){} // RVA: 0x7FFAF2F476A0
        public void get_NestedEnums(){} // RVA: 0x7FFAF2E0A740
        public void .ctor(){} // RVA: 0x7FFAF8536BA0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8536BE0
    }

    public class GeneratedCodeInfo
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF852B320
        public void get_Descriptor(){} // RVA: 0x7FFAF852B380
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF852B440
        public void .ctor(){} // RVA: 0x7FFAF852B550 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF852B6F0
        public void get_Annotation(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF852B9C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF852BA70
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF852BAC0
        public void CalculateSize(){} // RVA: 0x7FFAF852BB80
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF852BD70
        public void .cctor(){} // RVA: 0x7FFAF852BE70
    }

    public class IDescriptor
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_FullName(){} // RVA: 0x7FFAF2ABCD60
        public void get_File(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IFieldAccessor
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF2ABCD60
        public void Clear(){} // RVA: 0x7FFAF2AD4B10
        public void GetValue(){} // RVA: 0x7FFAF2ABCE10
        public void HasValue(){} // RVA: 0x7FFAF2ABDE40
        public void SetValue(){} // RVA: 0x7FFAF2ADDC60
    }

    public class MapFieldAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8536DC0
        public void Clear(){} // RVA: 0x7FFAF8536DD0
        public void HasValue(){} // RVA: 0x7FFAF8536E90
        public void SetValue(){} // RVA: 0x7FFAF8536EE0
    }

    public class MessageDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8536F30
        public void CreateJsonFieldMap(){} // RVA: 0x7FFAF8537CC0
        public void get_Name(){} // RVA: 0x7FFAF8538050
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAF85380C0
        public void get_Proto(){} // RVA: 0x7FFAF2E0A740
        public void get_ClrType(){} // RVA: 0x7FFAF2E08730
        public void get_Parser(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IsWellKnownType(){} // RVA: 0x7FFAF85381A0
        public void get_IsWrapperType(){} // RVA: 0x7FFAF85382B0
        public void get_Fields(){} // RVA: 0x7FFAF2E2B370
        public void get_Extensions(){} // RVA: 0x7FFAF2E08D50
        public void get_NestedTypes(){} // RVA: 0x7FFAF2E55590
        public void get_EnumTypes(){} // RVA: 0x7FFAF2F77C50
        public void get_Oneofs(){} // RVA: 0x7FFAF2F12D00
        public void FindFieldByName(){} // RVA: 0x7FFAF85383A0
        public void FindFieldByNumber(){} // RVA: 0x7FFAF8538440
        public void CrossLink(){} // RVA: 0x7FFAF85385C0
        public void .cctor(){} // RVA: 0x7FFAF8538B80
    }

    public class MessageOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF851D440
        public void get_Descriptor(){} // RVA: 0x7FFAF851D4A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF851D560
        public void .ctor(){} // RVA: 0x7FFAF851D710 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF851D940
        public void get_MessageSetWireFormat(){} // RVA: 0x7FFAF851D9A0
        public void set_MessageSetWireFormat(){} // RVA: 0x7FFAF851DA10
        public void get_HasMessageSetWireFormat(){} // RVA: 0x7FFAF8519F80
        public void ClearMessageSetWireFormat(){} // RVA: 0x7FFAF8519F90
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x7FFAF851DA20
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x7FFAF851DA90
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x7FFAF8519DA0
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x7FFAF8519DB0
        public void get_Deprecated(){} // RVA: 0x7FFAF851DAA0
        public void set_Deprecated(){} // RVA: 0x7FFAF851DB10
        public void get_HasDeprecated(){} // RVA: 0x7FFAF851A190
        public void ClearDeprecated(){} // RVA: 0x7FFAF851A1A0
        public void get_MapEntry(){} // RVA: 0x7FFAF851DB20
        public void set_MapEntry(){} // RVA: 0x7FFAF851DB90
        public void get_HasMapEntry(){} // RVA: 0x7FFAF851A230
        public void ClearMapEntry(){} // RVA: 0x7FFAF851A240
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAF851DC00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF851DD80
        public void ToString(){} // RVA: 0x7FFAF851DEE0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF851DF30
        public void CalculateSize(){} // RVA: 0x7FFAF851E0C0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF851E380
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF851E550
    }

    public class MethodDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8539310
        public void get_Proto(){} // RVA: 0x7FFAF2DBB130
        public void get_Name(){} // RVA: 0x7FFAF85394C0
        public void CrossLink(){} // RVA: 0x7FFAF8539530
    }

    public class MethodDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85177E0
        public void get_Descriptor(){} // RVA: 0x7FFAF8517840
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8517900
        public void .ctor(){} // RVA: 0x7FFAF85179F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8517C90
        public void get_Name(){} // RVA: 0x7FFAF8517CF0
        public void set_Name(){} // RVA: 0x7FFAF8517D60
        public void get_HasName(){} // RVA: 0x7FFAF48EEC10
        public void ClearName(){} // RVA: 0x7FFAF8507060
        public void get_InputType(){} // RVA: 0x7FFAF8517E60
        public void set_InputType(){} // RVA: 0x7FFAF8517ED0
        public void get_HasInputType(){} // RVA: 0x7FFAF8517FD0
        public void ClearInputType(){} // RVA: 0x7FFAF54ADA70
        public void get_OutputType(){} // RVA: 0x7FFAF8517FE0
        public void set_OutputType(){} // RVA: 0x7FFAF8518050
        public void get_HasOutputType(){} // RVA: 0x7FFAF7C055E0
        public void ClearOutputType(){} // RVA: 0x7FFAF8518150
        public void get_Options(){} // RVA: 0x7FFAF2F476A0
        public void set_Options(){} // RVA: 0x7FFAF2F4B830
        public void get_ClientStreaming(){} // RVA: 0x7FFAF85181B0
        public void set_ClientStreaming(){} // RVA: 0x7FFAF8518220
        public void get_HasClientStreaming(){} // RVA: 0x7FFAF850C3B0
        public void ClearClientStreaming(){} // RVA: 0x7FFAF850C3C0
        public void get_ServerStreaming(){} // RVA: 0x7FFAF8518230
        public void set_ServerStreaming(){} // RVA: 0x7FFAF85182A0
        public void get_HasServerStreaming(){} // RVA: 0x7FFAF850C450
        public void ClearServerStreaming(){} // RVA: 0x7FFAF850C460
        public void Equals(){} // RVA: 0x7FFAF8518310 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8518510
        public void ToString(){} // RVA: 0x7FFAF8518690
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85186E0
        public void CalculateSize(){} // RVA: 0x7FFAF8518810
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8518BA0
        public void .cctor(){} // RVA: 0x7FFAF8518D80
    }

    public class MethodOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF8524870
        public void get_Descriptor(){} // RVA: 0x7FFAF85248D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8524990
        public void .ctor(){} // RVA: 0x7FFAF8524B40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8524D60
        public void get_Deprecated(){} // RVA: 0x7FFAF8524DC0
        public void set_Deprecated(){} // RVA: 0x7FFAF851DA10
        public void get_HasDeprecated(){} // RVA: 0x7FFAF8519F80
        public void ClearDeprecated(){} // RVA: 0x7FFAF8519F90
        public void get_IdempotencyLevel(){} // RVA: 0x7FFAF8524E30
        public void set_IdempotencyLevel(){} // RVA: 0x7FFAF8524EA0
        public void get_HasIdempotencyLevel(){} // RVA: 0x7FFAF8519DA0
        public void ClearIdempotencyLevel(){} // RVA: 0x7FFAF8519DB0
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF30E74D0
        public void Equals(){} // RVA: 0x7FFAF8525020 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8525160
        public void ToString(){} // RVA: 0x7FFAF8525250
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85252A0
        public void CalculateSize(){} // RVA: 0x7FFAF85253E0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85256E0
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8525860
    }

    public class OneofAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85398E0
        public void ForRegularOneof(){} // RVA: 0x7FFAF85399E0
        public void ForSyntheticOneof(){} // RVA: 0x7FFAF8539BE0
        public void get_Descriptor(){} // RVA: 0x7FFAF2DBB0C0
        public void Clear(){} // RVA: 0x7FFAF3459580
        public void GetCaseFieldDescriptor(){} // RVA: 0x7FFAF8539D70
    }

    public class OneofDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8539F30
        public void get_Name(){} // RVA: 0x7FFAF853A260
        public void get_Proto(){} // RVA: 0x7FFAF2E0A740
        public void get_ContainingType(){} // RVA: 0x7FFAF2DBB130
        public void get_Fields(){} // RVA: 0x7FFAF30E74D0
        public void get_IsSynthetic(){} // RVA: 0x7FFAF2E44D30
        public void get_Accessor(){} // RVA: 0x7FFAF2F476A0
        public void CrossLink(){} // RVA: 0x7FFAF853A2D0
        public void CreateAccessor(){} // RVA: 0x7FFAF853A640
    }

    public class OneofDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8511400
        public void get_Descriptor(){} // RVA: 0x7FFAF8511460
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8511520
        public void .ctor(){} // RVA: 0x7FFAF8511610 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85117F0
        public void get_Name(){} // RVA: 0x7FFAF8511850
        public void set_Name(){} // RVA: 0x7FFAF85118C0
        public void get_HasName(){} // RVA: 0x7FFAF47EB060
        public void ClearName(){} // RVA: 0x7FFAF515D280
        public void get_Options(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Options(){} // RVA: 0x7FFAF2DBB0D0
        public void Equals(){} // RVA: 0x7FFAF8511B10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8511C20
        public void ToString(){} // RVA: 0x7FFAF8511CC0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8511D10
        public void CalculateSize(){} // RVA: 0x7FFAF8511D90
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8512180
        public void .cctor(){} // RVA: 0x7FFAF8512290
    }

    public class OneofOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF8520290
        public void get_Descriptor(){} // RVA: 0x7FFAF85202F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85203B0
        public void .ctor(){} // RVA: 0x7FFAF8520560 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8520770
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAF8520910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF850E4D0
        public void ToString(){} // RVA: 0x7FFAF8520A00
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8520A50
        public void CalculateSize(){} // RVA: 0x7FFAF8520B40
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8520D80
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8520EB0
    }

    public class OriginalNameAttribute
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_PreferredAlias(){} // RVA: 0x7FFAF2DA84E0
        public void set_PreferredAlias(){} // RVA: 0x7FFAF2DA84F0
        public void .ctor(){} // RVA: 0x7FFAF853AB80
    }

    public class PackageDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF853AC80
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_FullName(){} // RVA: 0x7FFAF2D907C0
        public void get_File(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class ReflectionUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF853AD90
        public void ForceInitialize(){} // RVA: 0x7FFAF2AD4A80
        public void CreateFuncIMessageObject(){} // RVA: 0x7FFAF853B2D0
        public void CreateFuncIMessageInt32(){} // RVA: 0x7FFAF853B420
        public void CreateActionIMessageObject(){} // RVA: 0x7FFAF853B550
        public void CreateActionIMessage(){} // RVA: 0x7FFAF853B6D0
        public void CreateFuncIMessageBool(){} // RVA: 0x7FFAF853B890
        public void CreateExtensionHelper(){} // RVA: 0x7FFAF853B9E0
        public void GetReflectionHelper(){} // RVA: 0x7FFAF853BCC0
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFAF853BEC0
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFAF853BF20
        public void SampleEnumMethod(){} // RVA: 0x7FFAF2FC9240
    }

    public class RepeatedFieldAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8536DC0
        public void Clear(){} // RVA: 0x7FFAF853C130
        public void HasValue(){} // RVA: 0x7FFAF853C1F0
        public void SetValue(){} // RVA: 0x7FFAF853C240
    }

    public class ServiceDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF853C290
        public void get_Name(){} // RVA: 0x7FFAF853C5F0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFAF853C660
        public void CrossLink(){} // RVA: 0x7FFAF853C6D0
    }

    public class ServiceDescriptorProto
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8516170
        public void get_Descriptor(){} // RVA: 0x7FFAF85161D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8516290
        public void .ctor(){} // RVA: 0x7FFAF8516440 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85166C0
        public void get_Name(){} // RVA: 0x7FFAF8516720
        public void set_Name(){} // RVA: 0x7FFAF8516790
        public void get_HasName(){} // RVA: 0x7FFAF47EB060
        public void ClearName(){} // RVA: 0x7FFAF515D280
        public void get_Method(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Options(){} // RVA: 0x7FFAF2DBB130
        public void set_Options(){} // RVA: 0x7FFAF2D8EE90
        public void Equals(){} // RVA: 0x7FFAF8516A20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8516B80
        public void ToString(){} // RVA: 0x7FFAF8516C40
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8516C90
        public void CalculateSize(){} // RVA: 0x7FFAF8516DA0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8517250
        public void .cctor(){} // RVA: 0x7FFAF85173E0
    }

    public class ServiceOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF85236E0
        public void get_Descriptor(){} // RVA: 0x7FFAF8523740
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8523800
        public void .ctor(){} // RVA: 0x7FFAF85239B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8523BC0
        public void get_Deprecated(){} // RVA: 0x7FFAF8523C20
        public void set_Deprecated(){} // RVA: 0x7FFAF851DA10
        public void get_HasDeprecated(){} // RVA: 0x7FFAF8519F80
        public void ClearDeprecated(){} // RVA: 0x7FFAF8519F90
        public void get_UninterpretedOption(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAF8523DE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8523EF0
        public void ToString(){} // RVA: 0x7FFAF8523FC0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8524010
        public void CalculateSize(){} // RVA: 0x7FFAF8524130
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8524390
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF85244E0
    }

    public class SingleFieldAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF853CA90
        public void GetDefaultValue(){} // RVA: 0x7FFAF853D610
        public void Clear(){} // RVA: 0x7FFAF5DD9C00
        public void HasValue(){} // RVA: 0x7FFAF853DBC0
        public void SetValue(){} // RVA: 0x7FFAF853DBF0
    }

    public class SourceCodeInfo
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8528A30
        public void get_Descriptor(){} // RVA: 0x7FFAF8528A90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8528B50
        public void .ctor(){} // RVA: 0x7FFAF8528C60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF8528E00
        public void get_Location(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF85290D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF8529180
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85291D0
        public void CalculateSize(){} // RVA: 0x7FFAF8529290
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8529480
        public void .cctor(){} // RVA: 0x7FFAF8529580
    }

    public class TypeRegistry
    {
        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFAF853DEF0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Find(){} // RVA: 0x7FFAF853DF50
        public void .cctor(){} // RVA: 0x7FFAF853DFC0
    }

    public class UninterpretedOption
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8525C00
        public void get_Descriptor(){} // RVA: 0x7FFAF8525C60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8525D20
        public void .ctor(){} // RVA: 0x7FFAF8525E30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85260D0
        public void get_Name(){} // RVA: 0x7FFAF2DBB0C0
        public void get_IdentifierValue(){} // RVA: 0x7FFAF8526130
        public void set_IdentifierValue(){} // RVA: 0x7FFAF85261A0
        public void get_HasIdentifierValue(){} // RVA: 0x7FFAF8517FD0
        public void ClearIdentifierValue(){} // RVA: 0x7FFAF54ADA70
        public void get_PositiveIntValue(){} // RVA: 0x7FFAF85262A0
        public void set_PositiveIntValue(){} // RVA: 0x7FFAF8526310
        public void get_HasPositiveIntValue(){} // RVA: 0x7FFAF850C3B0
        public void ClearPositiveIntValue(){} // RVA: 0x7FFAF850C3C0
        public void get_NegativeIntValue(){} // RVA: 0x7FFAF8526320
        public void set_NegativeIntValue(){} // RVA: 0x7FFAF8526390
        public void get_HasNegativeIntValue(){} // RVA: 0x7FFAF850C450
        public void ClearNegativeIntValue(){} // RVA: 0x7FFAF850C460
        public void get_DoubleValue(){} // RVA: 0x7FFAF85263A0
        public void set_DoubleValue(){} // RVA: 0x7FFAF8526410
        public void get_HasDoubleValue(){} // RVA: 0x7FFAF850F650
        public void ClearDoubleValue(){} // RVA: 0x7FFAF850F660
        public void get_StringValue(){} // RVA: 0x7FFAF8526420
        public void set_StringValue(){} // RVA: 0x7FFAF8526490
        public void get_HasStringValue(){} // RVA: 0x7FFAF8526590
        public void ClearStringValue(){} // RVA: 0x7FFAF850FB30
        public void get_AggregateValue(){} // RVA: 0x7FFAF8526650
        public void set_AggregateValue(){} // RVA: 0x7FFAF85266C0
        public void get_HasAggregateValue(){} // RVA: 0x7FFAF7C063C0
        public void ClearAggregateValue(){} // RVA: 0x7FFAF2F5ED90
        public void Equals(){} // RVA: 0x7FFAF8526820 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8526A90
        public void ToString(){} // RVA: 0x7FFAF8526C40
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8526C90
        public void CalculateSize(){} // RVA: 0x7FFAF8526E60
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85272A0
        public void .cctor(){} // RVA: 0x7FFAF85274B0
    }

}