// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Serialization
// Classes: 74
// Methods: 537

namespace ThirdParty.DotNet.System.Xml.Serialization
{
    public class ClassMap : ObjectMap
    {
        // ── Methods ──
        public void AddMember(){} // RVA: 0x7AE8BAFF0
        public void RegisterFlatList(){} // RVA: 0x7AE8BBD80
        public void GetAttribute(){} // RVA: 0x7AE8BBE80
        public void GetElement(){} // RVA: 0x7AE8BC300
        public void BuildKey(){} // RVA: 0x7AE8BC580
        public void get_IsOrderDependentMap(){} // RVA: 0x7AE8BC660
        public void get_DefaultAnyElementMember(){} // RVA: 0x7A8178B90
        public void get_DefaultAnyAttributeMember(){} // RVA: 0x7A81A0050
        public void get_NamespaceDeclarations(){} // RVA: 0x7A8175DF0
        public void get_AttributeMembers(){} // RVA: 0x7AE8BC8C0
        public void get_ElementMembers(){} // RVA: 0x7A80DA7B0
        public void get_AllMembers(){} // RVA: 0x7A8292C30
        public void get_FlatLists(){} // RVA: 0x7A83F69F0
        public void get_ListMembers(){} // RVA: 0x7A8152D80
        public void get_XmlTextCollector(){} // RVA: 0x7A8153390
        public void get_ReturnMember(){} // RVA: 0x7A81A00E0
        public void get_SimpleContentBaseType(){} // RVA: 0x7AE8BCC80
        public void SetCanBeSimpleType(){} // RVA: 0x7A8665190
        public void get_HasSimpleContent(){} // RVA: 0x7AE8BCEB0
        public void .ctor(){} // RVA: 0x7AE8BCF40
    }

    public class CodeIdentifier : Object
    {
        // ── Methods ──
        public void MakePascal(){} // RVA: 0x7AE8852D0
        public void MakeValid(){} // RVA: 0x7AE8855B0
        public void IsValidStart(){} // RVA: 0x7AE8857C0
        public void IsValid(){} // RVA: 0x7AE885820
        public void .cctor(){} // RVA: 0x7AE8858D0
    }

    public class EnumMap : ObjectMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8BE190
        public void get_IsFlags(){} // RVA: 0x7A80F26D0
        public void get_EnumNames(){} // RVA: 0x7A81052C0
        public void get_XmlNames(){} // RVA: 0x7A8105330
        public void get_Values(){} // RVA: 0x7A83F69F0
        public void GetXmlName(){} // RVA: 0x7AE8BE510
        public void GetEnumName(){} // RVA: 0x7AE8BE890
    }

    public class IXmlSerializable
    {
        // ── Methods ──
        public void GetSchema(){} // RVA: 0x7A7E00680
        public void ReadXml(){} // RVA: 0x7A7E18800
        public void WriteXml(){} // RVA: 0x7A7E18800
    }

    public class IXmlTextParser
    {
        // ── Methods ──
        public void get_Normalized(){} // RVA: 0x7A7E01900
        public void set_Normalized(){} // RVA: 0x7A7E18C30
    }

    public class KeyHelper : Object
    {
        // ── Methods ──
        public void AddField(){} // RVA: 0x7AE886830
    }

    public class ListMap : ObjectMap
    {
        // ── Methods ──
        public void set_ChoiceMember(){} // RVA: 0x7A813E420
        public void get_ItemInfo(){} // RVA: 0x7A80F2570
        public void set_ItemInfo(){} // RVA: 0x7A80D8E20
        public void FindElement(){} // RVA: 0x7AE8BD690
        public void FindTextElement(){} // RVA: 0x7AE8BD8E0
        public void GetArrayType(){} // RVA: 0x7AE8BDAB0
        public void Equals(){} // RVA: 0x7AE8BDFF0
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ObjectMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReflectionHelper : Object
    {
        // ── Methods ──
        public void RegisterSchemaType(){} // RVA: 0x7AE886910
        public void GetRegisteredSchemaType(){} // RVA: 0x7AE8869D0
        public void RegisterClrType(){} // RVA: 0x7AE886AB0
        public void GetRegisteredClrType(){} // RVA: 0x7AE886C50
        public void CheckSerializableType(){} // RVA: 0x7AE886E10
        public void .ctor(){} // RVA: 0x7AE8871C0
        public void .cctor(){} // RVA: 0x7AE8872F0
    }

    public class SerializationSource : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8873A0
        public void BaseEquals(){} // RVA: 0x7AE887460
    }

    public class TypeData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE887AA0
        public void LookupTypeConvertor(){} // RVA: 0x7AE8882A0
        public void ConvertForAssignment(){} // RVA: 0x7AE888420
        public void get_TypeName(){} // RVA: 0x7A83F69F0
        public void get_XmlType(){} // RVA: 0x7A80DA7B0
        public void get_Type(){} // RVA: 0x7A80F2570
        public void get_FullTypeName(){} // RVA: 0x7A8292C30
        public void get_SchemaType(){} // RVA: 0x7A851DB90
        public void get_IsListType(){} // RVA: 0x7AE888560
        public void get_IsComplexType(){} // RVA: 0x7AE888570
        public void get_IsValueType(){} // RVA: 0x7AE8885A0
        public void get_IsNullable(){} // RVA: 0x7AE888640
        public void set_IsNullable(){} // RVA: 0x7A8F17000
        public void get_ListItemTypeData(){} // RVA: 0x7AE888750
        public void get_ListItemType(){} // RVA: 0x7AE888850
        public void get_IsXsdType(){} // RVA: 0x7AE889110
        public void get_HasPublicConstructor(){} // RVA: 0x7A8100260
        public void GetIndexerProperty(){} // RVA: 0x7AE889120
        public void CreateMissingAddMethodException(){} // RVA: 0x7AE889280
        public void GetGenericListItemType(){} // RVA: 0x7AE8893F0
        public void .cctor(){} // RVA: 0x7AE889600
    }

    public class TypeMember : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetHashCode(){} // RVA: 0x7AE88A250
        public void Equals(){} // RVA: 0x7AE88A3E0
        public void ToString(){} // RVA: 0x7AE88A4B0
    }

    public class TypeTranslator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE88A520
        public void GetTypeData(){} // RVA: 0x7AE88D760
        public void GetPrimitiveTypeData(){} // RVA: 0x7AE88E310
        public void FindPrimitiveTypeData(){} // RVA: 0x7AE88E560
        public void GetArrayName(){} // RVA: 0x7AE88E630
        public void ParseArrayType(){} // RVA: 0x7AE88E830
    }

    public class UnreferencedObjectEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE886420
    }

    public class UnreferencedObjectEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class XmlAnyAttributeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlAnyElementAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AACDA600
        public void get_Name(){} // RVA: 0x7AE88EAF0
        public void get_Namespace(){} // RVA: 0x7A80DA7B0
        public void get_Order(){} // RVA: 0x7A851DB90
        public void AddKeyHash(){} // RVA: 0x7AE88EB50
    }

    public class XmlAnyElementAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7AE88ED50
        public void Add(){} // RVA: 0x7AE88EE00
        public void AddKeyHash(){} // RVA: 0x7AE88EE60
        public void get_Order(){} // RVA: 0x7AE88F020
        public void .ctor(){} // RVA: 0x7AD9BA890
    }

    public class XmlArrayAttribute : Attribute
    {
        // ── Methods ──
        public void get_ElementName(){} // RVA: 0x7AE88F1E0
        public void get_Form(){} // RVA: 0x7A83782A0
        public void get_IsNullable(){} // RVA: 0x7A80F2580
        public void get_Namespace(){} // RVA: 0x7A81052C0
        public void get_Order(){} // RVA: 0x7A854FDE0
        public void AddKeyHash(){} // RVA: 0x7AE88F240
    }

    public class XmlArrayItemAttribute : Attribute
    {
        // ── Methods ──
        public void get_DataType(){} // RVA: 0x7AE88F5A0
        public void get_ElementName(){} // RVA: 0x7AE88F600
        public void get_Form(){} // RVA: 0x7A851DB90
        public void get_Namespace(){} // RVA: 0x7A8105330
        public void get_IsNullable(){} // RVA: 0x7A80FD690
        public void get_IsNullableSpecified(){} // RVA: 0x7A80FD6B0
        public void get_Type(){} // RVA: 0x7A8292C30
        public void get_NestingLevel(){} // RVA: 0x7A82C2070
        public void AddKeyHash(){} // RVA: 0x7AE88F660
    }

    public class XmlArrayItemAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7AE88FB80
        public void Add(){} // RVA: 0x7AE88FC30
        public void AddKeyHash(){} // RVA: 0x7AE88FC90
        public void .ctor(){} // RVA: 0x7AD9BA890
    }

    public class XmlAttributeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AttributeName(){} // RVA: 0x7AE88FE50
        public void get_DataType(){} // RVA: 0x7AE88FEB0
        public void set_DataType(){} // RVA: 0x7A813E420
        public void get_Form(){} // RVA: 0x7A854FDE0
        public void get_Namespace(){} // RVA: 0x7A83F69F0
        public void AddKeyHash(){} // RVA: 0x7AE88FF10
    }

    public class XmlAttributeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE886010
    }

    public class XmlAttributeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class XmlAttributeOverrides : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE890390
        public void get_Item(){} // RVA: 0x7AE8904A0
        public void GetKey(){} // RVA: 0x7AE890630
        public void AddKeyHash(){} // RVA: 0x7AE890730
    }

    public class XmlAttributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE890DA0
        public void get_XmlAnyAttribute(){} // RVA: 0x7A80F2570
        public void get_XmlAnyElements(){} // RVA: 0x7A80DA7B0
        public void get_XmlArray(){} // RVA: 0x7A81052C0
        public void get_XmlArrayItems(){} // RVA: 0x7A8105330
        public void get_XmlAttribute(){} // RVA: 0x7A83F69F0
        public void get_XmlChoiceIdentifier(){} // RVA: 0x7A8292C30
        public void get_XmlDefaultValue(){} // RVA: 0x7A8154D80
        public void get_XmlElements(){} // RVA: 0x7A8152D80
        public void get_XmlIgnore(){} // RVA: 0x7A8359360
        public void get_Xmlns(){} // RVA: 0x7ACDBE8E0
        public void get_XmlRoot(){} // RVA: 0x7A8175DF0
        public void get_XmlText(){} // RVA: 0x7A8153390
        public void get_XmlType(){} // RVA: 0x7A81A00E0
        public void AddKeyHash(){} // RVA: 0x7AE891E00
        public void get_Order(){} // RVA: 0x7AE892320
        public void get_SortableOrder(){} // RVA: 0x7AE892430
    }

    public class XmlChoiceIdentifierAttribute : Attribute
    {
        // ── Methods ──
        public void get_MemberName(){} // RVA: 0x7AE8924B0
        public void AddKeyHash(){} // RVA: 0x7AE892510
    }

    public class XmlCustomFormatter : Object
    {
        // ── Methods ──
        public void FromEnum(){} // RVA: 0x7AE892660
        public void FromXmlName(){} // RVA: 0x7AE892970
        public void FromXmlNCName(){} // RVA: 0x7AE892A00
        public void ToXmlString(){} // RVA: 0x7AE892A90
        public void FromXmlString(){} // RVA: 0x7AE893CF0
        public void .cctor(){} // RVA: 0x7AE894E50
    }

    public class XmlElementAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8952F0
        public void get_DataType(){} // RVA: 0x7AE8953B0
        public void get_ElementName(){} // RVA: 0x7AE895410
        public void get_Form(){} // RVA: 0x7A851DB90
        public void get_Namespace(){} // RVA: 0x7A8105330
        public void get_IsNullable(){} // RVA: 0x7A80FD690
        public void get_Order(){} // RVA: 0x7A8178B30
        public void get_Type(){} // RVA: 0x7A8292C30
        public void AddKeyHash(){} // RVA: 0x7AE895470
    }

    public class XmlElementAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7AE895920
        public void Add(){} // RVA: 0x7AE8959D0
        public void AddKeyHash(){} // RVA: 0x7AE895A30
        public void get_Order(){} // RVA: 0x7AE895BF0
        public void .ctor(){} // RVA: 0x7AD9BA890
    }

    public class XmlElementEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE886180
    }

    public class XmlElementEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class XmlEnumAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Name(){} // RVA: 0x7A80F2570
        public void AddKeyHash(){} // RVA: 0x7AE895DB0
    }

    public class XmlIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlIncludeAttribute : Attribute
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A80F2570
    }

    public class XmlMapping : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE805DB0
        public void get_ElementName(){} // RVA: 0x7A83F69F0
        public void get_Namespace(){} // RVA: 0x7A8292C30
        public void SetKey(){} // RVA: 0x7A80FF440
        public void get_ObjectMap(){} // RVA: 0x7A80F2570
        public void set_ObjectMap(){} // RVA: 0x7A80D8E20
        public void get_RelatedMaps(){} // RVA: 0x7A80DA7B0
        public void set_RelatedMaps(){} // RVA: 0x7A813E420
        public void get_Format(){} // RVA: 0x7A851DB90
        public void set_Format(){} // RVA: 0x7A8738180
        public void get_Source(){} // RVA: 0x7A8105330
    }

    public class XmlMembersMapping : XmlMapping
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7AE895F00
        public void get_HasWrapperElement(){} // RVA: 0x7A818F850
    }

    public class XmlNamespaceDeclarationsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlNodeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8862F0
    }

    public class XmlNodeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class XmlReflectionImporter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE895F20
        public void ImportTypeMapping(){} // RVA: 0x7AE8965D0
        public void CreateTypeMapping(){} // RVA: 0x7AE896AC0
        public void ImportClassMapping(){} // RVA: 0x7AE8970D0
        public void RegisterDerivedMap(){} // RVA: 0x7AE8984D0
        public void GetTypeNamespace(){} // RVA: 0x7AE898620
        public void ImportListMapping(){} // RVA: 0x7AE898820
        public void ImportXmlNodeMapping(){} // RVA: 0x7AE899800
        public void ImportPrimitiveMapping(){} // RVA: 0x7AE899B00
        public void ImportEnumMapping(){} // RVA: 0x7AE899CF0
        public void ImportXmlSerializableMapping(){} // RVA: 0x7AE89A530
        public void ImportIncludedTypes(){} // RVA: 0x7AE89A770
        public void GetReflectionMembers(){} // RVA: 0x7AE89A900
        public void CreateMapMember(){} // RVA: 0x7AE89B680
        public void ImportElementInfo(){} // RVA: 0x7AE89C5C0
        public void ImportAnyElementInfo(){} // RVA: 0x7AE89D660
        public void ImportTextElementInfo(){} // RVA: 0x7AE89DC60
        public void CanBeNull(){} // RVA: 0x7AE89E100
        public void IncludeType(){} // RVA: 0x7AE89E150
        public void GetDefaultValue(){} // RVA: 0x7AE89E640
        public void .cctor(){} // RVA: 0x7AE89E840
    }

    public class XmlReflectionMember : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE89EA80
        public void get_IsReturnValue(){} // RVA: 0x7A81A2200
        public void get_MemberName(){} // RVA: 0x7A80DA7B0
        public void get_MemberType(){} // RVA: 0x7A81052C0
        public void get_XmlAttributes(){} // RVA: 0x7AE89EB80
        public void get_DeclaringType(){} // RVA: 0x7A83F69F0
        public void set_DeclaringType(){} // RVA: 0x7A8105A90
    }

    public class XmlRootAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C17550
        public void get_DataType(){} // RVA: 0x7AE89EC30
        public void set_DataType(){} // RVA: 0x7A80D8E20
        public void get_ElementName(){} // RVA: 0x7AE89EC90
        public void set_ElementName(){} // RVA: 0x7A813E420
        public void get_IsNullable(){} // RVA: 0x7A81C68D0
        public void set_IsNullable(){} // RVA: 0x7A81C68E0
        public void get_Namespace(){} // RVA: 0x7A8105330
        public void set_Namespace(){} // RVA: 0x7A80D8E80
        public void AddKeyHash(){} // RVA: 0x7AE89ECF0
    }

    public class XmlSchemaProviderAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_MethodName(){} // RVA: 0x7A80F2570
        public void get_IsAny(){} // RVA: 0x7A80F26D0
        public void set_IsAny(){} // RVA: 0x7A80F26E0
    }

    public class XmlSerializableMapping : XmlTypeMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8BA1A0
    }

    public class XmlSerializationCollectionFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB0FF420
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class XmlSerializationFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class XmlSerializationGeneratedCode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSerializationReadCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98C14D0
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class XmlSerializationReader : XmlSerializationGeneratedCode
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AE89EFB0
        public void EnsureArrayList(){} // RVA: 0x7AE89F880
        public void EnsureHashtable(){} // RVA: 0x7AE89F8E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Document(){} // RVA: 0x7AE89F940
        public void get_Reader(){} // RVA: 0x7A80DA7B0
        public void AddFixup(){} // RVA: 0x7AE89FC80
        public void AddReadCallback(){} // RVA: 0x7AE89FD60
        public void AddTarget(){} // RVA: 0x7AE8A0020
        public void CurrentTag(){} // RVA: 0x7AE8A0220
        public void CreateReadOnlyCollectionException(){} // RVA: 0x7AE8A0400
        public void CreateUnknownConstantException(){} // RVA: 0x7AE8A04C0
        public void CreateUnknownNodeException(){} // RVA: 0x7AE8A0590
        public void CreateUnknownTypeException(){} // RVA: 0x7AE8A0620
        public void EnsureArrayIndex(){} // RVA: 0x7AE8A0780
        public void GetNullAttr(){} // RVA: 0x7AE8A08F0
        public void GetTarget(){} // RVA: 0x7AE8A09D0
        public void TargetReady(){} // RVA: 0x7AE8A0AC0
        public void GetXsiType(){} // RVA: 0x7AE8A0AF0
        public void InitCallbacks(){} // RVA: 0x7A7E18770
        public void InitIDs(){} // RVA: 0x7A7E18770
        public void IsXmlnsAttribute(){} // RVA: 0x7AE8A0DD0
        public void ParseWsdlArrayType(){} // RVA: 0x7AE8A0E80
        public void ReadElementQualifiedName(){} // RVA: 0x7AE8A1660
        public void ReadEndElement(){} // RVA: 0x7AE8A1780
        public void ReadNull(){} // RVA: 0x7AE8A1850
        public void ReadNullableQualifiedName(){} // RVA: 0x7AE8A1A40
        public void ReadNullableString(){} // RVA: 0x7AE8A1A70
        public void ReadReferencedElement(){} // RVA: 0x7AE8A1C80
        public void GetCallbackInfo(){} // RVA: 0x7AE8A1B30
        public void ReadList(){} // RVA: 0x7AE8A2020
        public void ReadReferencedElements(){} // RVA: 0x7AE8A2670
        public void ReadReferencingElement(){} // RVA: 0x7AE8A34B0
        public void ReadSerializable(){} // RVA: 0x7AE8A39B0
        public void ReadTypedPrimitive(){} // RVA: 0x7AE8A3B40
        public void ReadXmlNode(){} // RVA: 0x7AE8A4580
        public void ReadXmlDocument(){} // RVA: 0x7AE8A45F0
        public void ShrinkArray(){} // RVA: 0x7AE8A4730
        public void ToXmlQualifiedName(){} // RVA: 0x7AE8A48B0
        public void UnknownAttribute(){} // RVA: 0x7AE8A4B30
        public void UnknownElement(){} // RVA: 0x7AE8A4DB0
        public void UnknownNode(){} // RVA: 0x7AE8A50A0
        public void OnUnknownNode(){} // RVA: 0x7AE8A5120
        public void UnreferencedObject(){} // RVA: 0x7AE8A54E0
    }

    public class XmlSerializationReaderInterpreter : XmlSerializationReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8A58C0
        public void InitCallbacks(){} // RVA: 0x7AE8A5940
        public void InitIDs(){} // RVA: 0x7A80D7310
        public void ReadRoot(){} // RVA: 0x7AE8A65C0
        public void ReadEncodedObject(){} // RVA: 0x7AE8A5E20
        public void ReadMessage(){} // RVA: 0x7AE8A5FF0
        public void ReadObject(){} // RVA: 0x7AE8A6730
        public void ReadClassInstance(){} // RVA: 0x7AE8A6970
        public void ReadClassInstanceMembers(){} // RVA: 0x7AE8A6CA0
        public void ReadAttributeMembers(){} // RVA: 0x7AE8A6D50
        public void ReadMembers(){} // RVA: 0x7AE8A7390
        public void SetListMembersDefaults(){} // RVA: 0x7AE8A96F0
        public void FixupMembers(){} // RVA: 0x7AE8A9870
        public void ProcessUnknownAttribute(){} // RVA: 0x7AE8A5030
        public void ProcessUnknownElement(){} // RVA: 0x7AE8A5030
        public void IsReadOnly(){} // RVA: 0x7AE8A9BA0
        public void SetMemberValue(){} // RVA: 0x7AE8A9D60
        public void SetMemberValueFromAttr(){} // RVA: 0x7AE8A9F10
        public void GetMemberValue(){} // RVA: 0x7AE8AA010
        public void ReadObjectElement(){} // RVA: 0x7AE8AA0F0
        public void ReadPrimitiveValue(){} // RVA: 0x7AE8AA2E0
        public void GetValueFromXmlString(){} // RVA: 0x7AE8AA480
        public void ReadListElement(){} // RVA: 0x7AE8AA5B0
        public void ReadListString(){} // RVA: 0x7AE8AAA90
        public void AddListValue(){} // RVA: 0x7AE8AAD50
        public void CreateInstance(){} // RVA: 0x7AE8AB120
        public void CreateList(){} // RVA: 0x7AE8AB1A0
        public void InitializeList(){} // RVA: 0x7AE8AB250
        public void FillList(){} // RVA: 0x7AE8AB2E0
        public void CopyEnumerableList(){} // RVA: 0x7AE8AB300
        public void ReadXmlNodeElement(){} // RVA: 0x7AE8AB750
        public void ReadXmlNode(){} // RVA: 0x7AE8AB780
        public void ReadPrimitiveElement(){} // RVA: 0x7AE8AB990
        public void ReadEnumElement(){} // RVA: 0x7AE8ABA50
        public void GetEnumValue(){} // RVA: 0x7AE8ABAD0
        public void ReadXmlSerializableElement(){} // RVA: 0x7AE8ABC60
        public void .cctor(){} // RVA: 0x7AE8ABED0
    }

    public class XmlSerializationWriteCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class XmlSerializationWriter : XmlSerializationGeneratedCode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8AC0E0
        public void Initialize(){} // RVA: 0x7AE8AC190
        public void get_Writer(){} // RVA: 0x7A8105330
        public void AddWriteCallback(){} // RVA: 0x7AE8AC3C0
        public void CreateUnknownAnyElementException(){} // RVA: 0x7AE8AC640
        public void CreateUnknownTypeException(){} // RVA: 0x7AE8AC800
        public void FromXmlQualifiedName(){} // RVA: 0x7AE8AC8C0
        public void GetId(){} // RVA: 0x7AE8ACA00
        public void AlreadyQueued(){} // RVA: 0x7AE8ACBF0
        public void GetNamespacePrefix(){} // RVA: 0x7AE8ACC30
        public void GetQualifiedName(){} // RVA: 0x7AE8ACDF0
        public void InitCallbacks(){} // RVA: 0x7A7E18770
        public void TopLevelElement(){} // RVA: 0x7AE8AD0C0
        public void WriteAttribute(){} // RVA: 0x7AE8AD150
        public void WriteXmlNode(){} // RVA: 0x7AE8AD1E0
        public void WriteElementEncoded(){} // RVA: 0x7AE8AD2B0
        public void WriteElementLiteral(){} // RVA: 0x7AE8AD3F0
        public void WriteElementQualifiedName(){} // RVA: 0x7AE8AD550
        public void WriteElementString(){} // RVA: 0x7AE8AD6E0
        public void WriteEndElement(){} // RVA: 0x7AE8AD8C0
        public void WriteNamespaceDeclarations(){} // RVA: 0x7AE8AD920
        public void WriteNullableQualifiedNameEncoded(){} // RVA: 0x7AE8ADD20
        public void WriteNullableQualifiedNameLiteral(){} // RVA: 0x7AE8ADE00
        public void WriteNullableStringEncoded(){} // RVA: 0x7AE8ADED0
        public void WriteNullableStringLiteral(){} // RVA: 0x7AE8ADEF0
        public void WriteNullTagEncoded(){} // RVA: 0x7AE8ADF20
        public void WriteNullTagLiteral(){} // RVA: 0x7AE8AE050
        public void WritePotentiallyReferencingElement(){} // RVA: 0x7AE8AE180
        public void WriteReferencedElements(){} // RVA: 0x7AE8AE620
        public void IsPrimitiveArray(){} // RVA: 0x7AE8AE8E0
        public void WriteArray(){} // RVA: 0x7AE8AE9E0
        public void WriteReferencingElement(){} // RVA: 0x7AE8AEE20
        public void CheckReferenceQueue(){} // RVA: 0x7AE8AEFA0
        public void WriteSerializable(){} // RVA: 0x7AE8AF160
        public void WriteStartDocument(){} // RVA: 0x7AE8AF260
        public void WriteStartElement(){} // RVA: 0x7AE8AF380
        public void WriteTypedPrimitive(){} // RVA: 0x7AE8AFA10
        public void WriteValue(){} // RVA: 0x7AE8AFD80
        public void WriteXmlAttribute(){} // RVA: 0x7AE8AFDC0
        public void WriteXsiType(){} // RVA: 0x7AE8B02D0
    }

    public class XmlSerializationWriterInterpreter : XmlSerializationWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B0440
        public void InitCallbacks(){} // RVA: 0x7AE8B0570
        public void WriteRoot(){} // RVA: 0x7AE8B0940
        public void WriteObject(){} // RVA: 0x7AE8B0C10
        public void WriteMessage(){} // RVA: 0x7AE8B1440
        public void WriteObjectElement(){} // RVA: 0x7AE8B1720
        public void WriteObjectElementAttributes(){} // RVA: 0x7AE8B1870
        public void WriteObjectElementElements(){} // RVA: 0x7AE8B1920
        public void WriteMembers(){} // RVA: 0x7AE8B19D0
        public void WriteAttributeMembers(){} // RVA: 0x7AE8B1A30
        public void WriteElementMembers(){} // RVA: 0x7AE8B1F70
        public void GetMemberValue(){} // RVA: 0x7AE8B2510
        public void MemberHasValue(){} // RVA: 0x7AE8B25F0
        public void WriteMemberElement(){} // RVA: 0x7AE8B28F0
        public void ImplicitConvert(){} // RVA: 0x7AE8B2F80
        public void WritePrimitiveValueLiteral(){} // RVA: 0x7AE8B3340
        public void WritePrimitiveValueEncoded(){} // RVA: 0x7AE8B3640
        public void WriteListElement(){} // RVA: 0x7AE8B3960
        public void WriteListContent(){} // RVA: 0x7AE8B3C10
        public void GetListCount(){} // RVA: 0x7AE8B43E0
        public void WriteAnyElementContent(){} // RVA: 0x7AE8B45B0
        public void WritePrimitiveElement(){} // RVA: 0x7AE8B4BB0
        public void WriteEnumElement(){} // RVA: 0x7AE8B4C00
        public void GetStringValue(){} // RVA: 0x7AE8B4CE0
        public void GetEnumXmlValue(){} // RVA: 0x7AE8B5000
    }

    public class XmlSerializer : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE8B5180
        public void .ctor(){} // RVA: 0x7AE8B52D0
        public void get_Mapping(){} // RVA: 0x7A80DA7B0
        public void OnUnknownAttribute(){} // RVA: 0x7AE8B5480
        public void OnUnknownElement(){} // RVA: 0x7AE8B54B0
        public void OnUnknownNode(){} // RVA: 0x7AE8B54E0
        public void OnUnreferencedObject(){} // RVA: 0x7AE8B5510
        public void CreateReader(){} // RVA: 0x7AE8B6500
        public void CreateWriter(){} // RVA: 0x7AE8B6040
        public void Deserialize(){} // RVA: 0x7AE8B57F0
        public void Serialize(){} // RVA: 0x7AE8B5D60
    }

    public class XmlSerializerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateSerializer(){} // RVA: 0x7AE8B66F0
        public void .cctor(){} // RVA: 0x7AE8B6B70
    }

    public class XmlSerializerImplementation : Object
    {
        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7AE8B6C40
    }

    public class XmlSerializerNamespaces : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Add(){} // RVA: 0x7AE885980
        public void AddInternal(){} // RVA: 0x7AE885A50
        public void ToArray(){} // RVA: 0x7AE885AA0
        public void get_Count(){} // RVA: 0x7AE885BB0
        public void get_NamespaceList(){} // RVA: 0x7AE885BF0
        public void get_Namespaces(){} // RVA: 0x7AE885F60
        public void set_Namespaces(){} // RVA: 0x7A80D8E20
    }

    public class XmlTextAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_DataType(){} // RVA: 0x7AE8B6C80
        public void get_Type(){} // RVA: 0x7A80DA7B0
        public void AddKeyHash(){} // RVA: 0x7AE8B6CE0
    }

    public class XmlTypeAttribute : Attribute
    {
        // ── Methods ──
        public void get_IncludeInSchema(){} // RVA: 0x7A81A2200
        public void get_Namespace(){} // RVA: 0x7A80DA7B0
        public void get_TypeName(){} // RVA: 0x7AE8B6EF0
        public void AddKeyHash(){} // RVA: 0x7AE8B6F50
    }

    public class XmlTypeConvertorAttribute : Attribute
    {
        // ── Methods ──
        public void get_Method(){} // RVA: 0x7A80F2570
        public void set_Method(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class XmlTypeMapElementInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B7170
        public void get_TypeData(){} // RVA: 0x7A8152D80
        public void get_ChoiceValue(){} // RVA: 0x7A83F69F0
        public void set_ChoiceValue(){} // RVA: 0x7A8105A90
        public void get_ElementName(){} // RVA: 0x7A80F2570
        public void set_ElementName(){} // RVA: 0x7A80D8E20
        public void get_Namespace(){} // RVA: 0x7A80DA7B0
        public void set_Namespace(){} // RVA: 0x7A813E420
        public void get_DataTypeNamespace(){} // RVA: 0x7AE8B7300
        public void get_DataTypeName(){} // RVA: 0x7AE8B7390
        public void get_Form(){} // RVA: 0x7A851DB90
        public void set_Form(){} // RVA: 0x7A8738180
        public void get_MappedType(){} // RVA: 0x7A8154D80
        public void set_MappedType(){} // RVA: 0x7A80FF440
        public void get_IsNullable(){} // RVA: 0x7A82A20A0
        public void set_IsNullable(){} // RVA: 0x7A82A2C90
        public void get_Member(){} // RVA: 0x7A8105330
        public void set_NestingLevel(){} // RVA: 0x7A9ABBD00
        public void get_MultiReferenceType(){} // RVA: 0x7AE8B73C0
        public void get_WrappedElement(){} // RVA: 0x7A8192400
        public void set_WrappedElement(){} // RVA: 0x7A8192410
        public void get_IsTextElement(){} // RVA: 0x7AE8B73E0
        public void set_IsTextElement(){} // RVA: 0x7AE8B7460
        public void get_IsUnnamedAnyElement(){} // RVA: 0x7AE8B75C0
        public void set_IsUnnamedAnyElement(){} // RVA: 0x7AE8B7650
        public void get_ExplicitOrder(){} // RVA: 0x7A8A22410
        public void set_ExplicitOrder(){} // RVA: 0x7A8A25530
        public void Equals(){} // RVA: 0x7AE8B77B0
        public void GetHashCode(){} // RVA: 0x7ADA51890
    }

    public class XmlTypeMapElementInfoList : ArrayList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B7980
    }

    public class XmlTypeMapMember : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B7990
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_DefaultValue(){} // RVA: 0x7A8152D80
        public void set_DefaultValue(){} // RVA: 0x7A8152D90
        public void IsReadOnly(){} // RVA: 0x7AE8B7A40
        public void GetValue(){} // RVA: 0x7AE8B7D40
        public void SetValue(){} // RVA: 0x7AE8B8120
        public void InitMember(){} // RVA: 0x7AE8B82E0
        public void get_TypeData(){} // RVA: 0x7A8105330
        public void set_TypeData(){} // RVA: 0x7A80D8E80
        public void get_Index(){} // RVA: 0x7A83782A0
        public void set_Index(){} // RVA: 0x7A84385B0
        public void get_GlobalIndex(){} // RVA: 0x7A9739200
        public void set_GlobalIndex(){} // RVA: 0x7A9746990
        public void get_IsOptionalValueType(){} // RVA: 0x7ADAB6B60
        public void set_IsOptionalValueType(){} // RVA: 0x7AE8B8680
        public void get_IsReturnValue(){} // RVA: 0x7ADAB6B30
        public void set_IsReturnValue(){} // RVA: 0x7AE8B86B0
        public void CheckOptionalValueType(){} // RVA: 0x7AE8B86E0
        public void GetValueSpecified(){} // RVA: 0x7AE8B87C0
        public void SetValueSpecified(){} // RVA: 0x7AE8B8AC0
    }

    public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B8E80
    }

    public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
    {
        // ── Methods ──
        public void IsElementDefined(){} // RVA: 0x7AE8B9470
        public void get_IsDefaultAny(){} // RVA: 0x7AE8B96F0
        public void .ctor(){} // RVA: 0x7AE8B8E80
    }

    public class XmlTypeMapMemberAttribute : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B8DF0
        public void get_AttributeName(){} // RVA: 0x7A81A0050
        public void set_AttributeName(){} // RVA: 0x7A81A0060
        public void get_Namespace(){} // RVA: 0x7A8175DF0
        public void set_Namespace(){} // RVA: 0x7A8175E00
        public void set_Form(){} // RVA: 0x7A9A93880
        public void get_MappedType(){} // RVA: 0x7A81A00E0
        public void set_MappedType(){} // RVA: 0x7A81A00F0
    }

    public class XmlTypeMapMemberElement : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B8E80
        public void get_ElementInfo(){} // RVA: 0x7AE8B8E90
        public void set_ElementInfo(){} // RVA: 0x7A81A0060
        public void get_ChoiceMember(){} // RVA: 0x7A8175DF0
        public void set_ChoiceMember(){} // RVA: 0x7A8175E00
        public void get_ChoiceTypeData(){} // RVA: 0x7A81A00E0
        public void set_ChoiceTypeData(){} // RVA: 0x7A81A00F0
        public void FindElement(){} // RVA: 0x7AE8B8F40
        public void SetChoice(){} // RVA: 0x7AE8B9450
        public void get_IsXmlTextCollector(){} // RVA: 0x7A81A00C0
        public void set_IsXmlTextCollector(){} // RVA: 0x7A81A00D0
    }

    public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
    {
        // ── Methods ──
        public void get_FlatArrayIndex(){} // RVA: 0x7A989D5C0
        public void set_FlatArrayIndex(){} // RVA: 0x7A98A0B60
        public void .ctor(){} // RVA: 0x7AE8B8E80
    }

    public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
    {
        // ── Methods ──
        public void get_ListMap(){} // RVA: 0x7A825E100
        public void set_ListMap(){} // RVA: 0x7A825F860
        public void .ctor(){} // RVA: 0x7AE8B8E80
    }

    public class XmlTypeMapMemberList : XmlTypeMapMemberElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B8E80
    }

    public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B8E80
    }

    public class XmlTypeMapping : XmlMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8B98C0
        public void get_TypeFullName(){} // RVA: 0x7AE8B9B30
        public void get_TypeData(){} // RVA: 0x7A81A0050
        public void get_XmlType(){} // RVA: 0x7A8152D80
        public void set_XmlType(){} // RVA: 0x7A8152D90
        public void get_XmlTypeNamespace(){} // RVA: 0x7AE8B9B50
        public void set_XmlTypeNamespace(){} // RVA: 0x7A8230620
        public void get_HasXmlTypeNamespace(){} // RVA: 0x7ACDAC4E0
        public void get_DerivedTypes(){} // RVA: 0x7A81A00E0
        public void get_MultiReferenceType(){} // RVA: 0x7A81A00C0
        public void get_BaseMap(){} // RVA: 0x7A8175DF0
        public void set_BaseMap(){} // RVA: 0x7A8175E00
        public void set_IncludeInSchema(){} // RVA: 0x7ACF040C0
        public void get_IsNullable(){} // RVA: 0x7AD8E6CE0
        public void set_IsNullable(){} // RVA: 0x7AD8E6CF0
        public void get_IsAny(){} // RVA: 0x7AE8B9BA0
        public void set_IsAny(){} // RVA: 0x7AE8B9BB0
        public void GetRealTypeMap(){} // RVA: 0x7AE8B9BC0
        public void GetRealElementMap(){} // RVA: 0x7AE8B9D50
        public void UpdateRoot(){} // RVA: 0x7AE8BA050
    }

    public class XmlTypeSerializationSource : SerializationSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE887590
        public void Equals(){} // RVA: 0x7AE887830
        public void GetHashCode(){} // RVA: 0x7ADBC6F50
    }

}