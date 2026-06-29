// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 49
// Methods: 861

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86A340
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_FullName(){} // RVA: 0x7A80DA7B0
        public void get_File(){} // RVA: 0x7A81052C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7A82D1450
    }

    public class DescriptorDeclaration : Object
    {
        // ── Methods ──
        public void get_StartLine(){} // RVA: 0x7A83782A0
        public void .ctor(){} // RVA: 0x7AD86A400
        public void FromProto(){} // RVA: 0x7AD86A950
    }

    public class DescriptorPool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86A9C0
        public void ImportPublicDependencies(){} // RVA: 0x7AD86B080
        public void FindSymbol(){} // RVA: 0x7A8051B10
        public void AddPackage(){} // RVA: 0x7AD86B2B0
        public void AddSymbol(){} // RVA: 0x7AD86B6B0
        public void ValidateSymbolName(){} // RVA: 0x7AD86BAD0
        public void FindFieldByNumber(){} // RVA: 0x7AD86BD50
        public void AddFieldByNumber(){} // RVA: 0x7AD86BEB0
        public void AddEnumValueByNumber(){} // RVA: 0x7AD86C2D0
        public void LookupSymbol(){} // RVA: 0x7AD86C530
        public void .cctor(){} // RVA: 0x7AD86C820
    }

    public class DescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD845CF0
        public void get_Descriptor(){} // RVA: 0x7AD845D50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD845E10
        public void .ctor(){} // RVA: 0x7AD846310
        public void Clone(){} // RVA: 0x7AD846900
        public void get_Name(){} // RVA: 0x7AD846960
        public void set_Name(){} // RVA: 0x7AD8469D0
        public void get_HasName(){} // RVA: 0x7A9B3D890
        public void ClearName(){} // RVA: 0x7AA4BE520
        public void get_Field(){} // RVA: 0x7A81052C0
        public void get_Extension(){} // RVA: 0x7A8105330
        public void get_NestedType(){} // RVA: 0x7A83F69F0
        public void get_EnumType(){} // RVA: 0x7A8292C30
        public void get_ExtensionRange(){} // RVA: 0x7A8154D80
        public void get_OneofDecl(){} // RVA: 0x7A8152D80
        public void get_Options(){} // RVA: 0x7A8178B90
        public void set_Options(){} // RVA: 0x7A8230620
        public void get_ReservedRange(){} // RVA: 0x7A81A0050
        public void get_ReservedName(){} // RVA: 0x7A8175DF0
        public void Equals(){} // RVA: 0x7AD846B30
        public void GetHashCode(){} // RVA: 0x7AD846E00
        public void ToString(){} // RVA: 0x7AD846FD0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD847020
        public void CalculateSize(){} // RVA: 0x7AD8472F0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8479B0
        public void .cctor(){} // RVA: 0x7AD847E20
    }

    public class DescriptorReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD83D260
        public void .cctor(){} // RVA: 0x7AD83D2C0
    }

    public class DescriptorUtil : Object
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x7A7E00C10
    }

    public class DescriptorValidationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86C940
    }

    public class EnumDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86CAE0
        public void get_Name(){} // RVA: 0x7AD86CF50
        public void GetNestedDescriptorListForField(){} // RVA: 0x7AD86CFC0
        public void get_Values(){} // RVA: 0x7A8292C30
    }

    public class EnumDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD84EF20
        public void get_Descriptor(){} // RVA: 0x7AD84EF80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD84F040
        public void .ctor(){} // RVA: 0x7AD84F280
        public void Clone(){} // RVA: 0x7AD84F600
        public void get_Name(){} // RVA: 0x7AD84F660
        public void set_Name(){} // RVA: 0x7AD84F6D0
        public void get_HasName(){} // RVA: 0x7A9B3D890
        public void ClearName(){} // RVA: 0x7AA4BE520
        public void get_Value(){} // RVA: 0x7A81052C0
        public void get_Options(){} // RVA: 0x7A8105330
        public void set_Options(){} // RVA: 0x7A80D8E80
        public void get_ReservedRange(){} // RVA: 0x7A83F69F0
        public void get_ReservedName(){} // RVA: 0x7A8292C30
        public void Equals(){} // RVA: 0x7AD84F830
        public void GetHashCode(){} // RVA: 0x7AD84FA00
        public void ToString(){} // RVA: 0x7AD84FB10
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD84FB60
        public void CalculateSize(){} // RVA: 0x7AD84FD00
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8502E0
        public void .cctor(){} // RVA: 0x7AD850540
    }

    public class EnumOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD85DED0
        public void get_Descriptor(){} // RVA: 0x7AD85DF30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD85DFF0
        public void .ctor(){} // RVA: 0x7AD85E1A0
        public void Clone(){} // RVA: 0x7AD85E3C0
        public void get_AllowAlias(){} // RVA: 0x7AD85E420
        public void set_AllowAlias(){} // RVA: 0x7AD85A6B0
        public void get_HasAllowAlias(){} // RVA: 0x7AD856C20
        public void ClearAllowAlias(){} // RVA: 0x7AD856C30
        public void get_Deprecated(){} // RVA: 0x7AD85E490
        public void set_Deprecated(){} // RVA: 0x7AD85A730
        public void get_HasDeprecated(){} // RVA: 0x7AD856A40
        public void ClearDeprecated(){} // RVA: 0x7AD856A50
        public void get_UninterpretedOption(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7AD85E670
        public void GetHashCode(){} // RVA: 0x7AD85E7B0
        public void ToString(){} // RVA: 0x7AD85E8C0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD85E910
        public void CalculateSize(){} // RVA: 0x7AD85EA50
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD85ECE0
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD85EE60
    }

    public class EnumValueDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86D0D0
        public void get_Proto(){} // RVA: 0x7A83F69F0
        public void get_Name(){} // RVA: 0x7AD86D2B0
        public void get_Number(){} // RVA: 0x7AD86D320
        public void get_EnumDescriptor(){} // RVA: 0x7A8105330
    }

    public class EnumValueDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8515D0
        public void get_Descriptor(){} // RVA: 0x7AD851630
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8516F0
        public void .ctor(){} // RVA: 0x7AD8517E0
        public void Clone(){} // RVA: 0x7AD8519D0
        public void get_Name(){} // RVA: 0x7AD851A30
        public void set_Name(){} // RVA: 0x7AD851AA0
        public void get_HasName(){} // RVA: 0x7A9C435A0
        public void ClearName(){} // RVA: 0x7AD8439E0
        public void get_Number(){} // RVA: 0x7AD851BA0
        public void set_Number(){} // RVA: 0x7AD84BED0
        public void get_HasNumber(){} // RVA: 0x7AD848D40
        public void ClearNumber(){} // RVA: 0x7AD848D50
        public void get_Options(){} // RVA: 0x7A83F69F0
        public void set_Options(){} // RVA: 0x7A8105A90
        public void Equals(){} // RVA: 0x7AD851D70
        public void GetHashCode(){} // RVA: 0x7AD851EA0
        public void ToString(){} // RVA: 0x7AD851F50
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD851FA0
        public void CalculateSize(){} // RVA: 0x7AD852050
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8524A0
        public void .cctor(){} // RVA: 0x7AD8525D0
    }

    public class EnumValueOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD85F200
        public void get_Descriptor(){} // RVA: 0x7AD85F260
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD85F320
        public void .ctor(){} // RVA: 0x7AD85F4D0
        public void Clone(){} // RVA: 0x7AD85F6F0
        public void get_Deprecated(){} // RVA: 0x7AD85F750
        public void set_Deprecated(){} // RVA: 0x7AD85A6B0
        public void get_HasDeprecated(){} // RVA: 0x7AD856C20
        public void ClearDeprecated(){} // RVA: 0x7AD856C30
        public void get_UninterpretedOption(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7AD85F910
        public void GetHashCode(){} // RVA: 0x7AD85FA20
        public void ToString(){} // RVA: 0x7AD85FAF0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD85FB40
        public void CalculateSize(){} // RVA: 0x7AD85FC50
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD85FEB0
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD860000
    }

    public class ExtensionAccessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86D340
        public void get_Descriptor(){} // RVA: 0x7A81052C0
        public void Clear(){} // RVA: 0x7AD86D4B0
        public void HasValue(){} // RVA: 0x7AD86D510
        public void GetValue(){} // RVA: 0x7AD86D570
        public void SetValue(){} // RVA: 0x7AD86D5D0
    }

    public class ExtensionCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86D850
        public void get_UnorderedExtensions(){} // RVA: 0x7A81052C0
        public void CrossLink(){} // RVA: 0x7AD86DA50
    }

    public class ExtensionRangeOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD84A6F0
        public void get_Descriptor(){} // RVA: 0x7AD84A750
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD84A810
        public void .ctor(){} // RVA: 0x7AD84A9C0
        public void Clone(){} // RVA: 0x7AD84ABD0
        public void get_UninterpretedOption(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7AD84AD70
        public void GetHashCode(){} // RVA: 0x7AD84AE60
        public void ToString(){} // RVA: 0x7AD84AEF0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD84AF40
        public void CalculateSize(){} // RVA: 0x7AD84B030
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD84B270
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD84B3A0
    }

    public class FieldAccessorBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD86EA10
        public void get_Descriptor(){} // RVA: 0x7A80DA7B0
        public void GetValue(){} // RVA: 0x7ACEFA0B0
        public void HasValue(){} // RVA: 0x7A7E019D0
        public void Clear(){} // RVA: 0x7A7E18800
        public void SetValue(){} // RVA: 0x7A7E18890
    }

    public class FieldDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void get_ContainingType(){} // RVA: 0x7A8178B90
        public void get_ContainingOneof(){} // RVA: 0x7A81A0050
        public void get_RealContainingOneof(){} // RVA: 0x7AD86EC80
        public void get_JsonName(){} // RVA: 0x7A8175DF0
        public void get_PropertyName(){} // RVA: 0x7A8153390
        public void get_HasPresence(){} // RVA: 0x7AD86ECA0
        public void get_Proto(){} // RVA: 0x7A81A00E0
        public void get_Extension(){} // RVA: 0x7A82C2060
        public void .ctor(){} // RVA: 0x7AD86ED50
        public void get_Name(){} // RVA: 0x7AD86F4F0
        public void get_Accessor(){} // RVA: 0x7A8152D80
        public void GetFieldTypeFromProtoType(){} // RVA: 0x7AD86F560
        public void get_IsRepeated(){} // RVA: 0x7AD86F6E0
        public void get_IsMap(){} // RVA: 0x7AD86F710
        public void get_FieldType(){} // RVA: 0x7A8178B30
        public void get_FieldNumber(){} // RVA: 0x7AD86F750
        public void CompareTo(){} // RVA: 0x7AD86F770
        public void get_MessageType(){} // RVA: 0x7AD86F810
        public void get_ExtendeeType(){} // RVA: 0x7AD86F880
        public void CrossLink(){} // RVA: 0x7AD86F900
        public void CreateAccessor(){} // RVA: 0x7AD86FF30
    }

    public class FieldDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD84B720
        public void get_Descriptor(){} // RVA: 0x7AD84B780
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD84B840
        public void .ctor(){} // RVA: 0x7AD84B930
        public void Clone(){} // RVA: 0x7AD84BC90
        public void get_Name(){} // RVA: 0x7AD84BCF0
        public void set_Name(){} // RVA: 0x7AD84BD60
        public void get_HasName(){} // RVA: 0x7A9C435A0
        public void ClearName(){} // RVA: 0x7AD8439E0
        public void get_Number(){} // RVA: 0x7AD84BE60
        public void set_Number(){} // RVA: 0x7AD84BED0
        public void get_HasNumber(){} // RVA: 0x7AD848D40
        public void ClearNumber(){} // RVA: 0x7AD848D50
        public void get_Label(){} // RVA: 0x7AD84BEE0
        public void set_Label(){} // RVA: 0x7AD84BF50
        public void get_HasLabel(){} // RVA: 0x7AD848DE0
        public void ClearLabel(){} // RVA: 0x7AD848DF0
        public void get_Type(){} // RVA: 0x7AD84BF60
        public void set_Type(){} // RVA: 0x7AD84BFD0
        public void get_HasType(){} // RVA: 0x7AD84BFE0
        public void ClearType(){} // RVA: 0x7AD84BFF0
        public void get_TypeName(){} // RVA: 0x7AD84C000
        public void set_TypeName(){} // RVA: 0x7AD84C070
        public void get_HasTypeName(){} // RVA: 0x7A9B27F60
        public void ClearTypeName(){} // RVA: 0x7A8EC2FD0
        public void get_Extendee(){} // RVA: 0x7AD84C170
        public void set_Extendee(){} // RVA: 0x7AD84C1E0
        public void get_HasExtendee(){} // RVA: 0x7ACDAB870
        public void ClearExtendee(){} // RVA: 0x7AD84C2E0
        public void get_DefaultValue(){} // RVA: 0x7AD84C340
        public void set_DefaultValue(){} // RVA: 0x7AD84C3B0
        public void get_HasDefaultValue(){} // RVA: 0x7AD84C4B0
        public void ClearDefaultValue(){} // RVA: 0x7AD84C4C0
        public void get_OneofIndex(){} // RVA: 0x7AD84C520
        public void set_OneofIndex(){} // RVA: 0x7AD84C590
        public void get_HasOneofIndex(){} // RVA: 0x7AD84C5A0
        public void ClearOneofIndex(){} // RVA: 0x7AD84C5B0
        public void get_JsonName(){} // RVA: 0x7AD84C5C0
        public void set_JsonName(){} // RVA: 0x7AD84C630
        public void get_HasJsonName(){} // RVA: 0x7ACDAC650
        public void ClearJsonName(){} // RVA: 0x7AD84C730
        public void get_Options(){} // RVA: 0x7A8175DF0
        public void set_Options(){} // RVA: 0x7A8175E00
        public void get_Proto3Optional(){} // RVA: 0x7AD84C790
        public void set_Proto3Optional(){} // RVA: 0x7AD84C800
        public void get_HasProto3Optional(){} // RVA: 0x7AD84C810
        public void ClearProto3Optional(){} // RVA: 0x7AD84C820
        public void Equals(){} // RVA: 0x7AD84C890
        public void GetHashCode(){} // RVA: 0x7AD84CBA0
        public void ToString(){} // RVA: 0x7AD84CDA0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD84CDF0
        public void CalculateSize(){} // RVA: 0x7AD84D000
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD84D5C0
        public void .cctor(){} // RVA: 0x7AD84D880
    }

    public class FieldOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD85B5B0
        public void get_Descriptor(){} // RVA: 0x7AD85B610
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD85B6D0
        public void .ctor(){} // RVA: 0x7AD85B880
        public void Clone(){} // RVA: 0x7AD85BAC0
        public void get_Ctype(){} // RVA: 0x7AD85BB20
        public void set_Ctype(){} // RVA: 0x7AD85BB90
        public void get_HasCtype(){} // RVA: 0x7AD856C20
        public void ClearCtype(){} // RVA: 0x7AD856C30
        public void get_Packed(){} // RVA: 0x7AD85BBA0
        public void set_Packed(){} // RVA: 0x7AD85BC10
        public void get_HasPacked(){} // RVA: 0x7AD856A40
        public void ClearPacked(){} // RVA: 0x7AD856A50
        public void get_Jstype(){} // RVA: 0x7AD85BC20
        public void set_Jstype(){} // RVA: 0x7AD85BC90
        public void get_HasJstype(){} // RVA: 0x7AD856F70
        public void ClearJstype(){} // RVA: 0x7AD856F80
        public void get_Lazy(){} // RVA: 0x7AD85BCA0
        public void set_Lazy(){} // RVA: 0x7AD85BD10
        public void get_HasLazy(){} // RVA: 0x7AD856ED0
        public void ClearLazy(){} // RVA: 0x7AD856EE0
        public void get_UnverifiedLazy(){} // RVA: 0x7AD85BD20
        public void set_UnverifiedLazy(){} // RVA: 0x7AD85BD90
        public void get_HasUnverifiedLazy(){} // RVA: 0x7AD8570B0
        public void ClearUnverifiedLazy(){} // RVA: 0x7AD8570C0
        public void get_Deprecated(){} // RVA: 0x7AD85BDA0
        public void set_Deprecated(){} // RVA: 0x7AD85BE10
        public void get_HasDeprecated(){} // RVA: 0x7AD856E30
        public void ClearDeprecated(){} // RVA: 0x7AD856E40
        public void get_Weak(){} // RVA: 0x7AD85BE20
        public void set_Weak(){} // RVA: 0x7AD85BE90
        public void get_HasWeak(){} // RVA: 0x7AD856AE0
        public void ClearWeak(){} // RVA: 0x7AD856AF0
        public void get_UninterpretedOption(){} // RVA: 0x7A8292C30
        public void Equals(){} // RVA: 0x7AD85BF00
        public void GetHashCode(){} // RVA: 0x7AD85C0E0
        public void ToString(){} // RVA: 0x7AD85C290
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD85C2E0
        public void CalculateSize(){} // RVA: 0x7AD85C4F0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD85C8F0
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD85CB40
    }

    public class FileDescriptor : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD8702F0
        public void .ctor(){} // RVA: 0x7AD8703A0
        public void CreateDeclarationMap(){} // RVA: 0x7AD870D20
        public void FindDescriptorForPath(){} // RVA: 0x7AD871010
        public void GetDescriptorFromList(){} // RVA: 0x7AD8713C0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7AD871500
        public void ComputeFullName(){} // RVA: 0x7AD8715E0
        public void DeterminePublicDependencies(){} // RVA: 0x7AD871680
        public void get_Proto(){} // RVA: 0x7A80DA7B0
        public void get_Syntax(){} // RVA: 0x7A851DB90
        public void get_Name(){} // RVA: 0x7AD871AE0
        public void get_Package(){} // RVA: 0x7AD871B50
        public void get_MessageTypes(){} // RVA: 0x7A8105330
        public void get_EnumTypes(){} // RVA: 0x7A83F69F0
        public void get_Services(){} // RVA: 0x7A8292C30
        public void get_Extensions(){} // RVA: 0x7A8154D80
        public void get_Dependencies(){} // RVA: 0x7A8152D80
        public void get_PublicDependencies(){} // RVA: 0x7A8178B90
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x7AD871BC0
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x7A97F8BA0
        public void get_DescriptorPool(){} // RVA: 0x7A8175DF0
        public void BuildFrom(){} // RVA: 0x7AD871BD0
        public void CrossLink(){} // RVA: 0x7AD871D60
        public void FromGeneratedCode(){} // RVA: 0x7AD872120
        public void GetAllExtensions(){} // RVA: 0x7AD8726F0
        public void GetAllGeneratedExtensions(){} // RVA: 0x7AD872890
        public void GetAllDependedExtensions(){} // RVA: 0x7AD872AB0
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x7AD872EC0
        public void ToString(){} // RVA: 0x7AD873230
        public void ForceReflectionInitialization(){} // RVA: 0x7A7E187D0
    }

    public class FileDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD842880
        public void get_Descriptor(){} // RVA: 0x7AD8428E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8429A0
        public void .ctor(){} // RVA: 0x7AD842EB0
        public void Clone(){} // RVA: 0x7AD8436A0
        public void get_Name(){} // RVA: 0x7AD843700
        public void set_Name(){} // RVA: 0x7AD843770
        public void get_HasName(){} // RVA: 0x7A9B3D890
        public void ClearName(){} // RVA: 0x7AA4BE520
        public void get_Package(){} // RVA: 0x7AD843870
        public void set_Package(){} // RVA: 0x7AD8438E0
        public void get_HasPackage(){} // RVA: 0x7A9C435A0
        public void ClearPackage(){} // RVA: 0x7AD8439E0
        public void get_Dependency(){} // RVA: 0x7A8105330
        public void get_PublicDependency(){} // RVA: 0x7A83F69F0
        public void get_WeakDependency(){} // RVA: 0x7A8292C30
        public void get_MessageType(){} // RVA: 0x7A8154D80
        public void get_EnumType(){} // RVA: 0x7A8152D80
        public void get_Service(){} // RVA: 0x7A8178B90
        public void get_Extension(){} // RVA: 0x7A81A0050
        public void get_Options(){} // RVA: 0x7A8175DF0
        public void set_Options(){} // RVA: 0x7A8175E00
        public void get_SourceCodeInfo(){} // RVA: 0x7A8153390
        public void set_SourceCodeInfo(){} // RVA: 0x7A81533A0
        public void get_Syntax(){} // RVA: 0x7AD843A40
        public void set_Syntax(){} // RVA: 0x7AD843AB0
        public void get_HasSyntax(){} // RVA: 0x7AD843BB0
        public void ClearSyntax(){} // RVA: 0x7AD843BC0
        public void Equals(){} // RVA: 0x7AD843C80
        public void GetHashCode(){} // RVA: 0x7AD844000
        public void ToString(){} // RVA: 0x7AD844230
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD844280
        public void CalculateSize(){} // RVA: 0x7AD844580
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD844E70
        public void .cctor(){} // RVA: 0x7AD845360
    }

    public class FileDescriptorSet : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD841910
        public void get_Descriptor(){} // RVA: 0x7AD841970
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD841A30
        public void .ctor(){} // RVA: 0x7AD841BE0
        public void Clone(){} // RVA: 0x7AD841D80
        public void get_File(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD842050
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD842100
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD842150
        public void CalculateSize(){} // RVA: 0x7AD842210
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD842400
        public void .cctor(){} // RVA: 0x7AD842500
    }

    public class FileOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD855E10
        public void get_Descriptor(){} // RVA: 0x7AD855E70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD855F30
        public void .ctor(){} // RVA: 0x7AD8560E0
        public void Clone(){} // RVA: 0x7AD856680
        public void get_JavaPackage(){} // RVA: 0x7AD8566E0
        public void set_JavaPackage(){} // RVA: 0x7AD856750
        public void get_HasJavaPackage(){} // RVA: 0x7AD854AF0
        public void ClearJavaPackage(){} // RVA: 0x7AA7FD9C0
        public void get_JavaOuterClassname(){} // RVA: 0x7AD856850
        public void set_JavaOuterClassname(){} // RVA: 0x7AD8568C0
        public void get_HasJavaOuterClassname(){} // RVA: 0x7ACDAB700
        public void ClearJavaOuterClassname(){} // RVA: 0x7AD854C70
        public void get_JavaMultipleFiles(){} // RVA: 0x7AD8569C0
        public void set_JavaMultipleFiles(){} // RVA: 0x7AD856A30
        public void get_HasJavaMultipleFiles(){} // RVA: 0x7AD856A40
        public void ClearJavaMultipleFiles(){} // RVA: 0x7AD856A50
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x7AD856A60
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x7AD856AD0
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x7AD856AE0
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x7AD856AF0
        public void get_JavaStringCheckUtf8(){} // RVA: 0x7AD856B00
        public void set_JavaStringCheckUtf8(){} // RVA: 0x7AD856B70
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x7AD856B80
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x7AD856B90
        public void get_OptimizeFor(){} // RVA: 0x7AD856BA0
        public void set_OptimizeFor(){} // RVA: 0x7AD856C10
        public void get_HasOptimizeFor(){} // RVA: 0x7AD856C20
        public void ClearOptimizeFor(){} // RVA: 0x7AD856C30
        public void get_GoPackage(){} // RVA: 0x7AD856C40
        public void set_GoPackage(){} // RVA: 0x7AD856CB0
        public void get_HasGoPackage(){} // RVA: 0x7ACDAB870
        public void ClearGoPackage(){} // RVA: 0x7AD84C2E0
        public void get_CcGenericServices(){} // RVA: 0x7AD856DB0
        public void set_CcGenericServices(){} // RVA: 0x7AD856E20
        public void get_HasCcGenericServices(){} // RVA: 0x7AD856E30
        public void ClearCcGenericServices(){} // RVA: 0x7AD856E40
        public void get_JavaGenericServices(){} // RVA: 0x7AD856E50
        public void set_JavaGenericServices(){} // RVA: 0x7AD856EC0
        public void get_HasJavaGenericServices(){} // RVA: 0x7AD856ED0
        public void ClearJavaGenericServices(){} // RVA: 0x7AD856EE0
        public void get_PyGenericServices(){} // RVA: 0x7AD856EF0
        public void set_PyGenericServices(){} // RVA: 0x7AD856F60
        public void get_HasPyGenericServices(){} // RVA: 0x7AD856F70
        public void ClearPyGenericServices(){} // RVA: 0x7AD856F80
        public void get_PhpGenericServices(){} // RVA: 0x7AD856F90
        public void set_PhpGenericServices(){} // RVA: 0x7AD857000
        public void get_HasPhpGenericServices(){} // RVA: 0x7AD857010
        public void ClearPhpGenericServices(){} // RVA: 0x7AD857020
        public void get_Deprecated(){} // RVA: 0x7AD857030
        public void set_Deprecated(){} // RVA: 0x7AD8570A0
        public void get_HasDeprecated(){} // RVA: 0x7AD8570B0
        public void ClearDeprecated(){} // RVA: 0x7AD8570C0
        public void get_CcEnableArenas(){} // RVA: 0x7AD8570D0
        public void set_CcEnableArenas(){} // RVA: 0x7AD857140
        public void get_HasCcEnableArenas(){} // RVA: 0x7AD857150
        public void ClearCcEnableArenas(){} // RVA: 0x7AD857160
        public void get_ObjcClassPrefix(){} // RVA: 0x7AD857170
        public void set_ObjcClassPrefix(){} // RVA: 0x7AD8571E0
        public void get_HasObjcClassPrefix(){} // RVA: 0x7ACDAC4E0
        public void ClearObjcClassPrefix(){} // RVA: 0x7A82A8E50
        public void get_CsharpNamespace(){} // RVA: 0x7AD8572E0
        public void set_CsharpNamespace(){} // RVA: 0x7AD857350
        public void get_HasCsharpNamespace(){} // RVA: 0x7ACDAC650
        public void ClearCsharpNamespace(){} // RVA: 0x7AD84C730
        public void get_SwiftPrefix(){} // RVA: 0x7AD857450
        public void set_SwiftPrefix(){} // RVA: 0x7AD8574C0
        public void get_HasSwiftPrefix(){} // RVA: 0x7A9B13490
        public void ClearSwiftPrefix(){} // RVA: 0x7AD8575C0
        public void get_PhpClassPrefix(){} // RVA: 0x7AD857620
        public void set_PhpClassPrefix(){} // RVA: 0x7AD857690
        public void get_HasPhpClassPrefix(){} // RVA: 0x7A91002B0
        public void ClearPhpClassPrefix(){} // RVA: 0x7A86FB650
        public void get_PhpNamespace(){} // RVA: 0x7AD857790
        public void set_PhpNamespace(){} // RVA: 0x7AD857800
        public void get_HasPhpNamespace(){} // RVA: 0x7AD843BB0
        public void ClearPhpNamespace(){} // RVA: 0x7AD843BC0
        public void get_PhpMetadataNamespace(){} // RVA: 0x7AD857900
        public void set_PhpMetadataNamespace(){} // RVA: 0x7AD857970
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x7AD857A70
        public void ClearPhpMetadataNamespace(){} // RVA: 0x7A82A7AB0
        public void get_RubyPackage(){} // RVA: 0x7AD857A80
        public void set_RubyPackage(){} // RVA: 0x7AD857AF0
        public void get_HasRubyPackage(){} // RVA: 0x7AD857BF0
        public void ClearRubyPackage(){} // RVA: 0x7A82A7450
        public void get_UninterpretedOption(){} // RVA: 0x7A81163D0
        public void Equals(){} // RVA: 0x7AD857C60
        public void GetHashCode(){} // RVA: 0x7AD858210
        public void ToString(){} // RVA: 0x7AD858660
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8586B0
        public void CalculateSize(){} // RVA: 0x7AD858B40
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8592C0
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD859830
    }

    public class GeneratedClrTypeInfo : Object
    {
        // ── Methods ──
        public void get_ClrType(){} // RVA: 0x7A80F2570
        public void set_ClrType(){} // RVA: 0x7A80D8E20
        public void get_Parser(){} // RVA: 0x7A80DA7B0
        public void get_PropertyNames(){} // RVA: 0x7A81052C0
        public void get_Extensions(){} // RVA: 0x7A8105330
        public void get_OneofNames(){} // RVA: 0x7A83F69F0
        public void get_NestedTypes(){} // RVA: 0x7A8292C30
        public void get_NestedEnums(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7AD873920
        public void .cctor(){} // RVA: 0x7AD873960
    }

    public class GeneratedCodeInfo : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD867FE0
        public void get_Descriptor(){} // RVA: 0x7AD868040
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD868100
        public void .ctor(){} // RVA: 0x7AD868210
        public void Clone(){} // RVA: 0x7AD8683B0
        public void get_Annotation(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD868680
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD868730
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD868780
        public void CalculateSize(){} // RVA: 0x7AD868840
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD868A30
        public void .cctor(){} // RVA: 0x7AD868B30
    }

    public class IDescriptor
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_FullName(){} // RVA: 0x7A7E00680
        public void get_File(){} // RVA: 0x7A7E00680
    }

    public class IFieldAccessor
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7A7E00680
        public void Clear(){} // RVA: 0x7A7E18800
        public void GetValue(){} // RVA: 0x7A7E00B20
        public void HasValue(){} // RVA: 0x7A7E019D0
        public void SetValue(){} // RVA: 0x7A7E18890
    }

    public class MapFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD873B40
        public void Clear(){} // RVA: 0x7AD873B50
        public void HasValue(){} // RVA: 0x7AD873C10
        public void SetValue(){} // RVA: 0x7AD873C60
    }

    public class MessageDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD873CB0
        public void CreateJsonFieldMap(){} // RVA: 0x7AD874A50
        public void get_Name(){} // RVA: 0x7AD874DE0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7AD874E50
        public void get_Proto(){} // RVA: 0x7A8154D80
        public void get_ClrType(){} // RVA: 0x7A8152D80
        public void get_Parser(){} // RVA: 0x7A8178B90
        public void get_IsWellKnownType(){} // RVA: 0x7AD874F30
        public void get_IsWrapperType(){} // RVA: 0x7AD875040
        public void get_Fields(){} // RVA: 0x7A8175DF0
        public void get_Extensions(){} // RVA: 0x7A8153390
        public void get_NestedTypes(){} // RVA: 0x7A81A00E0
        public void get_EnumTypes(){} // RVA: 0x7A82C2060
        public void get_Oneofs(){} // RVA: 0x7A825E100
        public void FindFieldByName(){} // RVA: 0x7AD875130
        public void FindFieldByNumber(){} // RVA: 0x7AD8751D0
        public void CrossLink(){} // RVA: 0x7AD875350
        public void .cctor(){} // RVA: 0x7AD875910
    }

    public class MessageOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD85A0E0
        public void get_Descriptor(){} // RVA: 0x7AD85A140
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD85A200
        public void .ctor(){} // RVA: 0x7AD85A3B0
        public void Clone(){} // RVA: 0x7AD85A5E0
        public void get_MessageSetWireFormat(){} // RVA: 0x7AD85A640
        public void set_MessageSetWireFormat(){} // RVA: 0x7AD85A6B0
        public void get_HasMessageSetWireFormat(){} // RVA: 0x7AD856C20
        public void ClearMessageSetWireFormat(){} // RVA: 0x7AD856C30
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x7AD85A6C0
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x7AD85A730
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x7AD856A40
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x7AD856A50
        public void get_Deprecated(){} // RVA: 0x7AD85A740
        public void set_Deprecated(){} // RVA: 0x7AD85A7B0
        public void get_HasDeprecated(){} // RVA: 0x7AD856E30
        public void ClearDeprecated(){} // RVA: 0x7AD856E40
        public void get_MapEntry(){} // RVA: 0x7AD85A7C0
        public void set_MapEntry(){} // RVA: 0x7AD85A830
        public void get_HasMapEntry(){} // RVA: 0x7AD856ED0
        public void ClearMapEntry(){} // RVA: 0x7AD856EE0
        public void get_UninterpretedOption(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7AD85A8A0
        public void GetHashCode(){} // RVA: 0x7AD85AA20
        public void ToString(){} // RVA: 0x7AD85AB80
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD85ABD0
        public void CalculateSize(){} // RVA: 0x7AD85AD60
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD85B020
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD85B1F0
    }

    public class MethodDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8760A0
        public void get_Proto(){} // RVA: 0x7A8105330
        public void get_Name(){} // RVA: 0x7AD876270
        public void CrossLink(){} // RVA: 0x7AD8762E0
    }

    public class MethodDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD854300
        public void get_Descriptor(){} // RVA: 0x7AD854360
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD854420
        public void .ctor(){} // RVA: 0x7AD854510
        public void Clone(){} // RVA: 0x7AD8547B0
        public void get_Name(){} // RVA: 0x7AD854810
        public void set_Name(){} // RVA: 0x7AD854880
        public void get_HasName(){} // RVA: 0x7A9C435A0
        public void ClearName(){} // RVA: 0x7AD8439E0
        public void get_InputType(){} // RVA: 0x7AD854980
        public void set_InputType(){} // RVA: 0x7AD8549F0
        public void get_HasInputType(){} // RVA: 0x7AD854AF0
        public void ClearInputType(){} // RVA: 0x7AA7FD9C0
        public void get_OutputType(){} // RVA: 0x7AD854B00
        public void set_OutputType(){} // RVA: 0x7AD854B70
        public void get_HasOutputType(){} // RVA: 0x7ACDAB700
        public void ClearOutputType(){} // RVA: 0x7AD854C70
        public void get_Options(){} // RVA: 0x7A8292C30
        public void set_Options(){} // RVA: 0x7A8296DE0
        public void get_ClientStreaming(){} // RVA: 0x7AD854CD0
        public void set_ClientStreaming(){} // RVA: 0x7AD854D40
        public void get_HasClientStreaming(){} // RVA: 0x7AD848D40
        public void ClearClientStreaming(){} // RVA: 0x7AD848D50
        public void get_ServerStreaming(){} // RVA: 0x7AD854D50
        public void set_ServerStreaming(){} // RVA: 0x7AD854DC0
        public void get_HasServerStreaming(){} // RVA: 0x7AD848DE0
        public void ClearServerStreaming(){} // RVA: 0x7AD848DF0
        public void Equals(){} // RVA: 0x7AD854E30
        public void GetHashCode(){} // RVA: 0x7AD855030
        public void ToString(){} // RVA: 0x7AD8551B0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD855200
        public void CalculateSize(){} // RVA: 0x7AD855330
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD855840
        public void .cctor(){} // RVA: 0x7AD855A20
    }

    public class MethodOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD861530
        public void get_Descriptor(){} // RVA: 0x7AD861590
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD861650
        public void .ctor(){} // RVA: 0x7AD861800
        public void Clone(){} // RVA: 0x7AD861A20
        public void get_Deprecated(){} // RVA: 0x7AD861A80
        public void set_Deprecated(){} // RVA: 0x7AD85A6B0
        public void get_HasDeprecated(){} // RVA: 0x7AD856C20
        public void ClearDeprecated(){} // RVA: 0x7AD856C30
        public void get_IdempotencyLevel(){} // RVA: 0x7AD861AF0
        public void set_IdempotencyLevel(){} // RVA: 0x7AD861B60
        public void get_HasIdempotencyLevel(){} // RVA: 0x7AD856A40
        public void ClearIdempotencyLevel(){} // RVA: 0x7AD856A50
        public void get_UninterpretedOption(){} // RVA: 0x7A83F69F0
        public void Equals(){} // RVA: 0x7AD861CE0
        public void GetHashCode(){} // RVA: 0x7AD861E20
        public void ToString(){} // RVA: 0x7AD861F10
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD861F60
        public void CalculateSize(){} // RVA: 0x7AD8620A0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8623A0
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD862520
    }

    public class OneofAccessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD876680
        public void ForRegularOneof(){} // RVA: 0x7AD876780
        public void ForSyntheticOneof(){} // RVA: 0x7AD876980
        public void get_Descriptor(){} // RVA: 0x7A81052C0
        public void Clear(){} // RVA: 0x7A8743650
        public void GetCaseFieldDescriptor(){} // RVA: 0x7AD876B10
    }

    public class OneofDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD876CD0
        public void get_Name(){} // RVA: 0x7AD877000
        public void get_Proto(){} // RVA: 0x7A8154D80
        public void get_ContainingType(){} // RVA: 0x7A8105330
        public void get_Fields(){} // RVA: 0x7A83F69F0
        public void get_IsSynthetic(){} // RVA: 0x7A818F850
        public void get_Accessor(){} // RVA: 0x7A8292C30
        public void CrossLink(){} // RVA: 0x7AD877070
        public void CreateAccessor(){} // RVA: 0x7AD8773F0
    }

    public class OneofDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD84DD90
        public void get_Descriptor(){} // RVA: 0x7AD84DDF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD84DEB0
        public void .ctor(){} // RVA: 0x7AD84DFA0
        public void Clone(){} // RVA: 0x7AD84E180
        public void get_Name(){} // RVA: 0x7AD84E1E0
        public void set_Name(){} // RVA: 0x7AD84E250
        public void get_HasName(){} // RVA: 0x7A9B3D890
        public void ClearName(){} // RVA: 0x7AA4BE520
        public void get_Options(){} // RVA: 0x7A81052C0
        public void set_Options(){} // RVA: 0x7A81052D0
        public void Equals(){} // RVA: 0x7AD84E4A0
        public void GetHashCode(){} // RVA: 0x7AD84E5C0
        public void ToString(){} // RVA: 0x7AD84E660
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD84E6B0
        public void CalculateSize(){} // RVA: 0x7AD84E730
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD84EB20
        public void .cctor(){} // RVA: 0x7AD84EC30
    }

    public class OneofOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD85CF30
        public void get_Descriptor(){} // RVA: 0x7AD85CF90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD85D050
        public void .ctor(){} // RVA: 0x7AD85D200
        public void Clone(){} // RVA: 0x7AD85D410
        public void get_UninterpretedOption(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7AD85D5B0
        public void GetHashCode(){} // RVA: 0x7AD84AE60
        public void ToString(){} // RVA: 0x7AD85D6A0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD85D6F0
        public void CalculateSize(){} // RVA: 0x7AD85D7E0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD85DA20
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD85DB50
    }

    public class OriginalNameAttribute : Attribute
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_PreferredAlias(){} // RVA: 0x7A80F26D0
        public void set_PreferredAlias(){} // RVA: 0x7A80F26E0
        public void .ctor(){} // RVA: 0x7AD877930
    }

    public class PackageDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD877A30
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_FullName(){} // RVA: 0x7A80DA7B0
        public void get_File(){} // RVA: 0x7A81052C0
    }

    public class ReflectionUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD877B40
        public void ForceInitialize(){} // RVA: 0x7A7E187D0
        public void CreateFuncIMessageObject(){} // RVA: 0x7AD878080
        public void CreateFuncIMessageInt32(){} // RVA: 0x7AD8781D0
        public void CreateActionIMessageObject(){} // RVA: 0x7AD878300
        public void CreateActionIMessage(){} // RVA: 0x7AD878480
        public void CreateFuncIMessageBool(){} // RVA: 0x7AD878640
        public void CreateExtensionHelper(){} // RVA: 0x7AD878790
        public void GetReflectionHelper(){} // RVA: 0x7AD878A70
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x7AD878C70
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x7AD878CD0
        public void SampleEnumMethod(){} // RVA: 0x7A82D1450
    }

    public class RepeatedFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD873B40
        public void Clear(){} // RVA: 0x7AD878EE0
        public void HasValue(){} // RVA: 0x7AD878FA0
        public void SetValue(){} // RVA: 0x7AD878FF0
    }

    public class ServiceDescriptor : DescriptorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD879040
        public void get_Name(){} // RVA: 0x7AD8793A0
        public void GetNestedDescriptorListForField(){} // RVA: 0x7AD879410
        public void CrossLink(){} // RVA: 0x7AD879480
    }

    public class ServiceDescriptorProto : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD852C90
        public void get_Descriptor(){} // RVA: 0x7AD852CF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD852DB0
        public void .ctor(){} // RVA: 0x7AD852F60
        public void Clone(){} // RVA: 0x7AD8531E0
        public void get_Name(){} // RVA: 0x7AD853240
        public void set_Name(){} // RVA: 0x7AD8532B0
        public void get_HasName(){} // RVA: 0x7A9B3D890
        public void ClearName(){} // RVA: 0x7AA4BE520
        public void get_Method(){} // RVA: 0x7A81052C0
        public void get_Options(){} // RVA: 0x7A8105330
        public void set_Options(){} // RVA: 0x7A80D8E80
        public void Equals(){} // RVA: 0x7AD853540
        public void GetHashCode(){} // RVA: 0x7AD8536A0
        public void ToString(){} // RVA: 0x7AD853760
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8537B0
        public void CalculateSize(){} // RVA: 0x7AD8538C0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD853D70
        public void .cctor(){} // RVA: 0x7AD853F00
    }

    public class ServiceOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD860390
        public void get_Descriptor(){} // RVA: 0x7AD8603F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8604B0
        public void .ctor(){} // RVA: 0x7AD860660
        public void Clone(){} // RVA: 0x7AD860880
        public void get_Deprecated(){} // RVA: 0x7AD8608E0
        public void set_Deprecated(){} // RVA: 0x7AD85A6B0
        public void get_HasDeprecated(){} // RVA: 0x7AD856C20
        public void ClearDeprecated(){} // RVA: 0x7AD856C30
        public void get_UninterpretedOption(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7AD860AA0
        public void GetHashCode(){} // RVA: 0x7AD860BB0
        public void ToString(){} // RVA: 0x7AD860C80
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD860CD0
        public void CalculateSize(){} // RVA: 0x7AD860DF0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD861050
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD8611A0
    }

    public class SingleFieldAccessor : FieldAccessorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD879840
        public void GetDefaultValue(){} // RVA: 0x7AD87A3C0
        public void Clear(){} // RVA: 0x7AB121480
        public void HasValue(){} // RVA: 0x7AD87A970
        public void SetValue(){} // RVA: 0x7AD87A9A0
    }

    public class SourceCodeInfo : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8656F0
        public void get_Descriptor(){} // RVA: 0x7AD865750
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD865810
        public void .ctor(){} // RVA: 0x7AD865920
        public void Clone(){} // RVA: 0x7AD865AC0
        public void get_Location(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD865D90
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD865E40
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD865E90
        public void CalculateSize(){} // RVA: 0x7AD865F50
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD866140
        public void .cctor(){} // RVA: 0x7AD866240
    }

    public class TypeRegistry : Object
    {
        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7AD87ACA0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Find(){} // RVA: 0x7AD87AD00
        public void .cctor(){} // RVA: 0x7AD87AD70
    }

    public class UninterpretedOption : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8628C0
        public void get_Descriptor(){} // RVA: 0x7AD862920
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8629E0
        public void .ctor(){} // RVA: 0x7AD862AF0
        public void Clone(){} // RVA: 0x7AD862D90
        public void get_Name(){} // RVA: 0x7A81052C0
        public void get_IdentifierValue(){} // RVA: 0x7AD862DF0
        public void set_IdentifierValue(){} // RVA: 0x7AD862E60
        public void get_HasIdentifierValue(){} // RVA: 0x7AD854AF0
        public void ClearIdentifierValue(){} // RVA: 0x7AA7FD9C0
        public void get_PositiveIntValue(){} // RVA: 0x7AD862F60
        public void set_PositiveIntValue(){} // RVA: 0x7AD862FD0
        public void get_HasPositiveIntValue(){} // RVA: 0x7AD848D40
        public void ClearPositiveIntValue(){} // RVA: 0x7AD848D50
        public void get_NegativeIntValue(){} // RVA: 0x7AD862FE0
        public void set_NegativeIntValue(){} // RVA: 0x7AD863050
        public void get_HasNegativeIntValue(){} // RVA: 0x7AD848DE0
        public void ClearNegativeIntValue(){} // RVA: 0x7AD848DF0
        public void get_DoubleValue(){} // RVA: 0x7AD863060
        public void set_DoubleValue(){} // RVA: 0x7AD8630D0
        public void get_HasDoubleValue(){} // RVA: 0x7AD84BFE0
        public void ClearDoubleValue(){} // RVA: 0x7AD84BFF0
        public void get_StringValue(){} // RVA: 0x7AD8630E0
        public void set_StringValue(){} // RVA: 0x7AD863150
        public void get_HasStringValue(){} // RVA: 0x7AD863250
        public void ClearStringValue(){} // RVA: 0x7AD84C4C0
        public void get_AggregateValue(){} // RVA: 0x7AD863310
        public void set_AggregateValue(){} // RVA: 0x7AD863380
        public void get_HasAggregateValue(){} // RVA: 0x7ACDAC4E0
        public void ClearAggregateValue(){} // RVA: 0x7A82A8E50
        public void Equals(){} // RVA: 0x7AD8634E0
        public void GetHashCode(){} // RVA: 0x7AD863750
        public void ToString(){} // RVA: 0x7AD863900
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD863950
        public void CalculateSize(){} // RVA: 0x7AD863B20
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD863F60
        public void .cctor(){} // RVA: 0x7AD864170
    }

}