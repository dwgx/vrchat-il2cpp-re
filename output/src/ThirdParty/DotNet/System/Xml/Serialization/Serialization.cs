// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Serialization
// Classes: 75
// Methods: 587

namespace ThirdParty.DotNet.System.Xml.Serialization
{
    public class ClassMap : ObjectMap
    {
        public System.Collections.Hashtable _elements; // 0x10
        public System.Collections.ArrayList _elementMembers; // 0x18
        public System.Collections.Hashtable _attributeMembers; // 0x20
        public System.Xml.Serialization.XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
        public System.Collections.ArrayList _flatLists; // 0x30
        public System.Collections.ArrayList _allMembers; // 0x38
        public System.Collections.ArrayList _membersWithDefault; // 0x40
        public System.Collections.ArrayList _listMembers; // 0x48
        public System.Xml.Serialization.XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
        public System.Xml.Serialization.XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
        public System.Xml.Serialization.XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
        public System.Xml.Serialization.XmlTypeMapMember _xmlTextCollector; // 0x68
        public System.Xml.Serialization.XmlTypeMapMember _returnMember; // 0x70

        // ── Methods ──
        public void AddMember(){} // RVA: 0x7FFE87609DC0
        public void RegisterFlatList(){} // RVA: 0x7FFE8760AB80
        public void GetAttribute(){} // RVA: 0x7FFE8760AC80
        public void GetElement(){} // RVA: 0x7FFE8760B110 | overloaded x2
        public void BuildKey(){} // RVA: 0x7FFE8760B3B0
        public void get_IsOrderDependentMap(){} // RVA: 0x7FFE8760B490
        public void get_DefaultAnyElementMember(){} // RVA: 0x7FFE8119C0E0
        public void get_DefaultAnyAttributeMember(){} // RVA: 0x7FFE811C3500
        public void get_NamespaceDeclarations(){} // RVA: 0x7FFE81199370
        public void get_AttributeMembers(){} // RVA: 0x7FFE8760B710
        public void get_ElementMembers(){} // RVA: 0x7FFE810FE7C0
        public void get_AllMembers(){} // RVA: 0x7FFE8143BA80
        public void get_FlatLists(){} // RVA: 0x7FFE8144E200
        public void get_ListMembers(){} // RVA: 0x7FFE81176730
        public void get_XmlTextCollector(){} // RVA: 0x7FFE81176D50
        public void get_ReturnMember(){} // RVA: 0x7FFE811C3590
        public void get_SimpleContentBaseType(){} // RVA: 0x7FFE8760BAE0
        public void SetCanBeSimpleType(){} // RVA: 0x7FFE81644C60
        public void get_HasSimpleContent(){} // RVA: 0x7FFE8760BD10
        public void .ctor(){} // RVA: 0x7FFE8760BDA0
    }

    public class CodeIdentifier : Object
    {
        // ── Methods ──
        public void MakePascal(){} // RVA: 0x7FFE875D3D30
        public void MakeValid(){} // RVA: 0x7FFE875D4020
        public void IsValidStart(){} // RVA: 0x7FFE875D4230
        public void IsValid(){} // RVA: 0x7FFE875D4290
        public void .cctor(){} // RVA: 0x7FFE875D4340
    }

    public class EnumMap : ObjectMap
    {
        public EnumMapMember[] _members; // 0x10
        public bool _isFlags; // 0x18
        public string[] _enumNames; // 0x20
        public string[] _xmlNames; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8760D040
        public void get_IsFlags(){} // RVA: 0x7FFE811164E0
        public void get_EnumNames(){} // RVA: 0x7FFE811290C0
        public void get_XmlNames(){} // RVA: 0x7FFE81129130
        public void get_Values(){} // RVA: 0x7FFE8144E200
        public void GetXmlName(){} // RVA: 0x7FFE8760D3C0
        public void GetEnumName(){} // RVA: 0x7FFE8760D740
    }

    public class IXmlSerializable
    {
        // ── Methods ──
        public void GetSchema(){} // RVA: 0x7FFE80E2E2E0
        public void ReadXml(){} // RVA: 0x7FFE80E460A0
        public void WriteXml(){} // RVA: 0x7FFE80E460A0
    }

    public class IXmlTextParser
    {
        // ── Methods ──
        public void get_Normalized(){} // RVA: 0x7FFE80E2F150
        public void set_Normalized(){} // RVA: 0x7FFE80E466C0
    }

    public class KeyHelper : Object
    {
        // ── Methods ──
        public void AddField(){} // RVA: 0x7FFE875D52A0 | overloaded x6
    }

    public class ListMap : ObjectMap
    {
        public System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo; // 0x10
        public string _choiceMember; // 0x18

        // ── Methods ──
        public void set_ChoiceMember(){} // RVA: 0x7FFE81161E80
        public void get_ItemInfo(){} // RVA: 0x7FFE81116380
        public void set_ItemInfo(){} // RVA: 0x7FFE810FCE30
        public void FindElement(){} // RVA: 0x7FFE8760C520 | overloaded x2
        public void FindTextElement(){} // RVA: 0x7FFE8760C790
        public void GetArrayType(){} // RVA: 0x7FFE8760C960
        public void Equals(){} // RVA: 0x7FFE8760CEA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ObjectMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReflectionHelper : Object
    {
        // ── Methods ──
        public void RegisterSchemaType(){} // RVA: 0x7FFE875D5380
        public void GetRegisteredSchemaType(){} // RVA: 0x7FFE875D5440
        public void RegisterClrType(){} // RVA: 0x7FFE875D5540
        public void GetRegisteredClrType(){} // RVA: 0x7FFE875D56E0
        public void CheckSerializableType(){} // RVA: 0x7FFE875D58A0
        public void .ctor(){} // RVA: 0x7FFE875D5C50
        public void .cctor(){} // RVA: 0x7FFE875D5D80
    }

    public class SerializationSource : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D5E30
        public void BaseEquals(){} // RVA: 0x7FFE875D5EF0
    }

    public class TypeData : Object
    {
        public System.Type type; // 0x10
        public string elementName; // 0x18
        public 0x665570C4 sType; // 0x20
        public System.Type listItemType; // 0x28
        public string typeName; // 0x30
        public string fullTypeName; // 0x38
        public System.Xml.Serialization.TypeData listItemTypeData; // 0x40
        public System.Xml.Serialization.TypeData mappedType; // 0x48
        public System.Xml.Schema.XmlSchemaPatternFacet facet; // 0x50
        public System.Reflection.MethodInfo typeConvertor; // 0x58
        public bool hasPublicConstructor; // 0x60
        public bool nullableOverride; // 0x61
        public string[] keywords;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D6550 | overloaded x2
        public void LookupTypeConvertor(){} // RVA: 0x7FFE875D6D50
        public void ConvertForAssignment(){} // RVA: 0x7FFE875D6ED0
        public void get_TypeName(){} // RVA: 0x7FFE8144E200
        public void get_XmlType(){} // RVA: 0x7FFE810FE7C0
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_FullTypeName(){} // RVA: 0x7FFE8143BA80
        public void get_SchemaType(){} // RVA: 0x7FFE8151D690
        public void get_IsListType(){} // RVA: 0x7FFE875D7010
        public void get_IsComplexType(){} // RVA: 0x7FFE875D7020
        public void get_IsValueType(){} // RVA: 0x7FFE875D7050
        public void get_IsNullable(){} // RVA: 0x7FFE875D70F0
        public void set_IsNullable(){} // RVA: 0x7FFE81EB6360
        public void get_ListItemTypeData(){} // RVA: 0x7FFE875D7200
        public void get_ListItemType(){} // RVA: 0x7FFE875D7300
        public void get_IsXsdType(){} // RVA: 0x7FFE875D7BC0
        public void get_HasPublicConstructor(){} // RVA: 0x7FFE81124020
        public void GetIndexerProperty(){} // RVA: 0x7FFE875D7BD0
        public void CreateMissingAddMethodException(){} // RVA: 0x7FFE875D7D20
        public void GetGenericListItemType(){} // RVA: 0x7FFE875D7E90
        public void .cctor(){} // RVA: 0x7FFE875D80B0
    }

    public class TypeMember : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void GetHashCode(){} // RVA: 0x7FFE875D8D00
        public void Equals(){} // RVA: 0x7FFE875D8E90 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE875D8F60
    }

    public class TypeTranslator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE875D8FD0
        public void GetTypeData(){} // RVA: 0x7FFE875DC220 | overloaded x2
        public void GetPrimitiveTypeData(){} // RVA: 0x7FFE875DCE50 | overloaded x2
        public void FindPrimitiveTypeData(){} // RVA: 0x7FFE875DD0A0
        public void GetArrayName(){} // RVA: 0x7FFE875DD170
        public void ParseArrayType(){} // RVA: 0x7FFE875DD380
    }

    public class UnreferencedObjectEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D4E90
    }

    public class UnreferencedObjectEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class XmlAnyAttributeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlAnyElementAttribute : Attribute
    {
        public string elementName; // 0x10
        public string ns; // 0x18
        public int order; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83BB2D90
        public void get_Name(){} // RVA: 0x7FFE875DD640
        public void get_Namespace(){} // RVA: 0x7FFE810FE7C0
        public void get_Order(){} // RVA: 0x7FFE8151D690
        public void AddKeyHash(){} // RVA: 0x7FFE875DD6A0
    }

    public class XmlAnyElementAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE875DD8A0
        public void Add(){} // RVA: 0x7FFE875DD950
        public void AddKeyHash(){} // RVA: 0x7FFE875DD9B0
        public void get_Order(){} // RVA: 0x7FFE875DDB70
        public void .ctor(){} // RVA: 0x7FFE8670DB40
    }

    public class XmlArrayAttribute : Attribute
    {
        public string elementName; // 0x10
        public 0x6655D5D4 form; // 0x18
        public bool isNullable; // 0x1C
        public string ns; // 0x20
        public int order; // 0x28

        // ── Methods ──
        public void get_ElementName(){} // RVA: 0x7FFE875DDD40
        public void get_Form(){} // RVA: 0x7FFE813DB630
        public void get_IsNullable(){} // RVA: 0x7FFE81116390
        public void get_Namespace(){} // RVA: 0x7FFE811290C0
        public void get_Order(){} // RVA: 0x7FFE81549710
        public void AddKeyHash(){} // RVA: 0x7FFE875DDDA0
    }

    public class XmlArrayItemAttribute : Attribute
    {
        public string dataType; // 0x10
        public string elementName; // 0x18
        public 0x6655D5D4 form; // 0x20
        public string ns; // 0x28
        public bool isNullable; // 0x30
        public bool isNullableSpecified; // 0x31
        public int nestingLevel; // 0x34
        public System.Type type; // 0x38

        // ── Methods ──
        public void get_DataType(){} // RVA: 0x7FFE875DE100
        public void get_ElementName(){} // RVA: 0x7FFE875DE160
        public void get_Form(){} // RVA: 0x7FFE8151D690
        public void get_Namespace(){} // RVA: 0x7FFE81129130
        public void get_IsNullable(){} // RVA: 0x7FFE81121450
        public void get_IsNullableSpecified(){} // RVA: 0x7FFE81121470
        public void get_Type(){} // RVA: 0x7FFE8143BA80
        public void get_NestingLevel(){} // RVA: 0x7FFE82447220
        public void AddKeyHash(){} // RVA: 0x7FFE875DE1C0
    }

    public class XmlArrayItemAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE875DE6E0
        public void Add(){} // RVA: 0x7FFE875DE790
        public void AddKeyHash(){} // RVA: 0x7FFE875DE7F0
        public void .ctor(){} // RVA: 0x7FFE8670DB40
    }

    public class XmlAttributeAttribute : Attribute
    {
        public string attributeName; // 0x10
        public string dataType; // 0x18
        public System.Type type; // 0x20
        public 0x6655D5D4 form; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_AttributeName(){} // RVA: 0x7FFE875DE9B0
        public void get_DataType(){} // RVA: 0x7FFE875DEA10
        public void set_DataType(){} // RVA: 0x7FFE81161E80
        public void get_Form(){} // RVA: 0x7FFE81549710
        public void get_Namespace(){} // RVA: 0x7FFE8144E200
        public void AddKeyHash(){} // RVA: 0x7FFE875DEA70
    }

    public class XmlAttributeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D4A80
    }

    public class XmlAttributeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class XmlAttributeOverrides : Object
    {
        public System.Collections.Hashtable overrides; // 0x10
        public object field_1; // 0x327

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875DEEF0
        public void get_Item(){} // RVA: 0x7FFE875DF000 | overloaded x2
        public void GetKey(){} // RVA: 0x7FFE875DF190
        public void AddKeyHash(){} // RVA: 0x7FFE875DF290
    }

    public class XmlAttributes : Object
    {
        public System.Xml.Serialization.XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
        public System.Xml.Serialization.XmlAnyElementAttributes xmlAnyElements; // 0x18
        public System.Xml.Serialization.XmlArrayAttribute xmlArray; // 0x20
        public System.Xml.Serialization.XmlArrayItemAttributes xmlArrayItems; // 0x28
        public System.Xml.Serialization.XmlAttributeAttribute xmlAttribute; // 0x30
        public System.Xml.Serialization.XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
        public object xmlDefaultValue; // 0x40
        public System.Xml.Serialization.XmlElementAttributes xmlElements; // 0x48
        public System.Xml.Serialization.XmlEnumAttribute xmlEnum; // 0x50
        public bool xmlIgnore; // 0x58
        public bool xmlns; // 0x59
        public System.Xml.Serialization.XmlRootAttribute xmlRoot; // 0x60
        public System.Xml.Serialization.XmlTextAttribute xmlText; // 0x68
        public System.Xml.Serialization.XmlTypeAttribute xmlType; // 0x70
        public object field_14; // 0x329

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875DF920 | overloaded x2
        public void get_XmlAnyAttribute(){} // RVA: 0x7FFE81116380
        public void get_XmlAnyElements(){} // RVA: 0x7FFE810FE7C0
        public void get_XmlArray(){} // RVA: 0x7FFE811290C0
        public void get_XmlArrayItems(){} // RVA: 0x7FFE81129130
        public void get_XmlAttribute(){} // RVA: 0x7FFE8144E200
        public void get_XmlChoiceIdentifier(){} // RVA: 0x7FFE8143BA80
        public void get_XmlDefaultValue(){} // RVA: 0x7FFE81178740
        public void get_XmlElements(){} // RVA: 0x7FFE81176730
        public void get_XmlIgnore(){} // RVA: 0x7FFE813A1140
        public void get_Xmlns(){} // RVA: 0x7FFE85BA8C00
        public void get_XmlRoot(){} // RVA: 0x7FFE81199370
        public void get_XmlText(){} // RVA: 0x7FFE81176D50
        public void get_XmlType(){} // RVA: 0x7FFE811C3590
        public void AddKeyHash(){} // RVA: 0x7FFE875E0990
        public void get_Order(){} // RVA: 0x7FFE875E0EB0
        public void get_SortableOrder(){} // RVA: 0x7FFE875E0FC0
    }

    public class XmlChoiceIdentifierAttribute : Attribute
    {
        public string memberName; // 0x10

        // ── Methods ──
        public void get_MemberName(){} // RVA: 0x7FFE875E1040
        public void AddKeyHash(){} // RVA: 0x7FFE875E10A0
    }

    public class XmlCustomFormatter : Object
    {
        // ── Methods ──
        public void FromEnum(){} // RVA: 0x7FFE875E11F0
        public void FromXmlName(){} // RVA: 0x7FFE875E14B0
        public void FromXmlNCName(){} // RVA: 0x7FFE875E1540
        public void ToXmlString(){} // RVA: 0x7FFE875E15D0
        public void FromXmlString(){} // RVA: 0x7FFE875E2830
        public void .cctor(){} // RVA: 0x7FFE875E3990
    }

    public class XmlElementAttribute : Attribute
    {
        public string dataType; // 0x10
        public string elementName; // 0x18
        public 0x6655D5D4 form; // 0x20
        public string ns; // 0x28
        public bool isNullable; // 0x30
        public System.Type type; // 0x38
        public int order; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875E3E30 | overloaded x2
        public void get_DataType(){} // RVA: 0x7FFE875E3EF0
        public void get_ElementName(){} // RVA: 0x7FFE875E3F50
        public void get_Form(){} // RVA: 0x7FFE8151D690
        public void get_Namespace(){} // RVA: 0x7FFE81129130
        public void get_IsNullable(){} // RVA: 0x7FFE81121450
        public void get_Order(){} // RVA: 0x7FFE8119C080
        public void get_Type(){} // RVA: 0x7FFE8143BA80
        public void AddKeyHash(){} // RVA: 0x7FFE875E3FB0
    }

    public class XmlElementAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE875E4460
        public void Add(){} // RVA: 0x7FFE875E4510
        public void AddKeyHash(){} // RVA: 0x7FFE875E4570
        public void get_Order(){} // RVA: 0x7FFE875E4730
        public void .ctor(){} // RVA: 0x7FFE8670DB40
    }

    public class XmlElementEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D4BF0
    }

    public class XmlElementEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class XmlEnumAttribute : Attribute
    {
        public string name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void AddKeyHash(){} // RVA: 0x7FFE875E4900
    }

    public class XmlIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlIncludeAttribute : Attribute
    {
        public System.Type type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE81116380
    }

    public class XmlMapping : Object
    {
        public System.Xml.Serialization.ObjectMap map; // 0x10
        public System.Collections.ArrayList relatedMaps; // 0x18
        public 0x6655795C format; // 0x20
        public System.Xml.Serialization.SerializationSource source; // 0x28
        public string _elementName; // 0x30
        public string _namespace; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87554EF0
        public void get_ElementName(){} // RVA: 0x7FFE8144E200
        public void get_Namespace(){} // RVA: 0x7FFE8143BA80
        public void SetKey(){} // RVA: 0x7FFE81123200
        public void get_ObjectMap(){} // RVA: 0x7FFE81116380
        public void set_ObjectMap(){} // RVA: 0x7FFE810FCE30
        public void get_RelatedMaps(){} // RVA: 0x7FFE810FE7C0
        public void set_RelatedMaps(){} // RVA: 0x7FFE81161E80
        public void get_Format(){} // RVA: 0x7FFE8151D690
        public void set_Format(){} // RVA: 0x7FFE8170B670
        public void get_Source(){} // RVA: 0x7FFE81129130
    }

    public class XmlMemberMapping : Object
    {
    }

    public class XmlMembersMapping : XmlMapping
    {
        public bool _hasWrapperElement; // 0x48
        public System.Xml.Serialization.XmlMemberMapping[] _mapping; // 0x50

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE875E4A50
        public void get_HasWrapperElement(){} // RVA: 0x7FFE811B2D30
    }

    public class XmlNamespaceDeclarationsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlNodeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D4D60
    }

    public class XmlNodeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class XmlReflectionImporter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875E4A70
        public void ImportTypeMapping(){} // RVA: 0x7FFE875E5120 | overloaded x4
        public void CreateTypeMapping(){} // RVA: 0x7FFE875E5610
        public void ImportClassMapping(){} // RVA: 0x7FFE875E5C20 | overloaded x2
        public void RegisterDerivedMap(){} // RVA: 0x7FFE875E6FE0
        public void GetTypeNamespace(){} // RVA: 0x7FFE875E7130
        public void ImportListMapping(){} // RVA: 0x7FFE875E7330 | overloaded x2
        public void ImportXmlNodeMapping(){} // RVA: 0x7FFE875E8280
        public void ImportPrimitiveMapping(){} // RVA: 0x7FFE875E8580
        public void ImportEnumMapping(){} // RVA: 0x7FFE875E8770
        public void ImportXmlSerializableMapping(){} // RVA: 0x7FFE875E8FB0
        public void ImportIncludedTypes(){} // RVA: 0x7FFE875E91E0
        public void GetReflectionMembers(){} // RVA: 0x7FFE875E9370
        public void CreateMapMember(){} // RVA: 0x7FFE875EA0F0
        public void ImportElementInfo(){} // RVA: 0x7FFE875EB010
        public void ImportAnyElementInfo(){} // RVA: 0x7FFE875EC0F0
        public void ImportTextElementInfo(){} // RVA: 0x7FFE875EC700
        public void CanBeNull(){} // RVA: 0x7FFE875ECBA0
        public void IncludeType(){} // RVA: 0x7FFE875ECBF0
        public void GetDefaultValue(){} // RVA: 0x7FFE875ED0E0
        public void .cctor(){} // RVA: 0x7FFE875ED2E0
    }

    public class XmlReflectionMember : Object
    {
        public bool isReturnValue; // 0x10
        public string memberName; // 0x18
        public System.Type memberType; // 0x20
        public System.Xml.Serialization.XmlAttributes xmlAttributes; // 0x28
        public System.Type declaringType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875ED520
        public void get_IsReturnValue(){} // RVA: 0x7FFE811C55E0
        public void get_MemberName(){} // RVA: 0x7FFE810FE7C0
        public void get_MemberType(){} // RVA: 0x7FFE811290C0
        public void get_XmlAttributes(){} // RVA: 0x7FFE875ED620
        public void get_DeclaringType(){} // RVA: 0x7FFE8144E200
        public void set_DeclaringType(){} // RVA: 0x7FFE81129890
    }

    public class XmlRootAttribute : Attribute
    {
        public string dataType; // 0x10
        public string elementName; // 0x18
        public bool isNullable; // 0x20
        public string ns; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BA02A0 | overloaded x2
        public void get_DataType(){} // RVA: 0x7FFE875ED6D0
        public void set_DataType(){} // RVA: 0x7FFE810FCE30
        public void get_ElementName(){} // RVA: 0x7FFE875ED730
        public void set_ElementName(){} // RVA: 0x7FFE81161E80
        public void get_IsNullable(){} // RVA: 0x7FFE811E99D0
        public void set_IsNullable(){} // RVA: 0x7FFE811E99E0
        public void get_Namespace(){} // RVA: 0x7FFE81129130
        public void set_Namespace(){} // RVA: 0x7FFE810FCE90
        public void AddKeyHash(){} // RVA: 0x7FFE875ED790
    }

    public class XmlSchemaProviderAttribute : Attribute
    {
        public string _methodName; // 0x10
        public bool _isAny; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_MethodName(){} // RVA: 0x7FFE81116380
        public void get_IsAny(){} // RVA: 0x7FFE811164E0
        public void set_IsAny(){} // RVA: 0x7FFE811164F0
    }

    public class XmlSerializableMapping : XmlTypeMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87608F60
    }

    public class XmlSerializationCollectionFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83F84C40
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class XmlSerializationFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class XmlSerializationGeneratedCode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSerializationReadCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3700
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class XmlSerializationReader : XmlSerializationGeneratedCode
    {
        public System.Xml.XmlDocument document; // 0x10
        public System.Xml.XmlReader reader; // 0x18

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE875EDA50
        public void EnsureArrayList(){} // RVA: 0x7FFE875EE320
        public void EnsureHashtable(){} // RVA: 0x7FFE875EE380
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Document(){} // RVA: 0x7FFE875EE3E0
        public void get_Reader(){} // RVA: 0x7FFE810FE7C0
        public void AddFixup(){} // RVA: 0x7FFE875EE720 | overloaded x3
        public void AddReadCallback(){} // RVA: 0x7FFE875EE800
        public void AddTarget(){} // RVA: 0x7FFE875EEAC0
        public void CurrentTag(){} // RVA: 0x7FFE875EECC0
        public void CreateReadOnlyCollectionException(){} // RVA: 0x7FFE875EEEA0
        public void CreateUnknownConstantException(){} // RVA: 0x7FFE875EEF60
        public void CreateUnknownNodeException(){} // RVA: 0x7FFE875EF030
        public void CreateUnknownTypeException(){} // RVA: 0x7FFE875EF0C0
        public void EnsureArrayIndex(){} // RVA: 0x7FFE875EF220
        public void GetNullAttr(){} // RVA: 0x7FFE875EF390
        public void GetTarget(){} // RVA: 0x7FFE875EF470
        public void TargetReady(){} // RVA: 0x7FFE875EF560
        public void GetXsiType(){} // RVA: 0x7FFE875EF590
        public void InitCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void InitIDs(){} // RVA: 0x7FFE80E45FE0
        public void IsXmlnsAttribute(){} // RVA: 0x7FFE875EF870
        public void ParseWsdlArrayType(){} // RVA: 0x7FFE875EF920
        public void ReadElementQualifiedName(){} // RVA: 0x7FFE875F0160
        public void ReadEndElement(){} // RVA: 0x7FFE875F0280
        public void ReadNull(){} // RVA: 0x7FFE875F0350
        public void ReadNullableQualifiedName(){} // RVA: 0x7FFE875F0540
        public void ReadNullableString(){} // RVA: 0x7FFE875F0570
        public void ReadReferencedElement(){} // RVA: 0x7FFE875F0780 | overloaded x2
        public void GetCallbackInfo(){} // RVA: 0x7FFE875F0630
        public void ReadList(){} // RVA: 0x7FFE875F0B20
        public void ReadReferencedElements(){} // RVA: 0x7FFE875F11A0
        public void ReadReferencingElement(){} // RVA: 0x7FFE875F2070 | overloaded x3
        public void ReadSerializable(){} // RVA: 0x7FFE875F2570
        public void ReadTypedPrimitive(){} // RVA: 0x7FFE875F2700 | overloaded x2
        public void ReadXmlNode(){} // RVA: 0x7FFE875F3160
        public void ReadXmlDocument(){} // RVA: 0x7FFE875F31D0
        public void ShrinkArray(){} // RVA: 0x7FFE875F3310
        public void ToXmlQualifiedName(){} // RVA: 0x7FFE875F3490
        public void UnknownAttribute(){} // RVA: 0x7FFE875F3710
        public void UnknownElement(){} // RVA: 0x7FFE875F3990
        public void UnknownNode(){} // RVA: 0x7FFE875F3C80 | overloaded x2
        public void OnUnknownNode(){} // RVA: 0x7FFE875F3D00
        public void UnreferencedObject(){} // RVA: 0x7FFE875F40B0
    }

    public class XmlSerializationReaderInterpreter : XmlSerializationReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875F4490
        public void InitCallbacks(){} // RVA: 0x7FFE875F4510
        public void InitIDs(){} // RVA: 0x7FFE810FB310
        public void ReadRoot(){} // RVA: 0x7FFE875F51A0 | overloaded x2
        public void ReadEncodedObject(){} // RVA: 0x7FFE875F4A00
        public void ReadMessage(){} // RVA: 0x7FFE875F4BD0
        public void ReadObject(){} // RVA: 0x7FFE875F5310
        public void ReadClassInstance(){} // RVA: 0x7FFE875F5550
        public void ReadClassInstanceMembers(){} // RVA: 0x7FFE875F5880
        public void ReadAttributeMembers(){} // RVA: 0x7FFE875F5930
        public void ReadMembers(){} // RVA: 0x7FFE875F5F80
        public void SetListMembersDefaults(){} // RVA: 0x7FFE875F8340
        public void FixupMembers(){} // RVA: 0x7FFE875F84D0
        public void ProcessUnknownAttribute(){} // RVA: 0x7FFE875F3C10
        public void ProcessUnknownElement(){} // RVA: 0x7FFE875F3C10
        public void IsReadOnly(){} // RVA: 0x7FFE875F8810
        public void SetMemberValue(){} // RVA: 0x7FFE875F89D0
        public void SetMemberValueFromAttr(){} // RVA: 0x7FFE875F8B80
        public void GetMemberValue(){} // RVA: 0x7FFE875F8C80
        public void ReadObjectElement(){} // RVA: 0x7FFE875F8D60
        public void ReadPrimitiveValue(){} // RVA: 0x7FFE875F8F50
        public void GetValueFromXmlString(){} // RVA: 0x7FFE875F90F0
        public void ReadListElement(){} // RVA: 0x7FFE875F9220
        public void ReadListString(){} // RVA: 0x7FFE875F9700
        public void AddListValue(){} // RVA: 0x7FFE875F99C0
        public void CreateInstance(){} // RVA: 0x7FFE875F9D90 | overloaded x2
        public void CreateList(){} // RVA: 0x7FFE875F9E10
        public void InitializeList(){} // RVA: 0x7FFE875F9EC0
        public void FillList(){} // RVA: 0x7FFE875F9F50
        public void CopyEnumerableList(){} // RVA: 0x7FFE875F9F70
        public void ReadXmlNodeElement(){} // RVA: 0x7FFE875FA3D0
        public void ReadXmlNode(){} // RVA: 0x7FFE875FA400
        public void ReadPrimitiveElement(){} // RVA: 0x7FFE875FA610
        public void ReadEnumElement(){} // RVA: 0x7FFE875FA6D0
        public void GetEnumValue(){} // RVA: 0x7FFE875FA750
        public void ReadXmlSerializableElement(){} // RVA: 0x7FFE875FA8E0
        public void .cctor(){} // RVA: 0x7FFE875FAB50
    }

    public class XmlSerializationWriteCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class XmlSerializationWriter : XmlSerializationGeneratedCode
    {
        public System.Runtime.Serialization.ObjectIDGenerator idGenerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875FAD60
        public void Initialize(){} // RVA: 0x7FFE875FAE10
        public void get_Writer(){} // RVA: 0x7FFE81129130
        public void AddWriteCallback(){} // RVA: 0x7FFE875FB040
        public void CreateUnknownAnyElementException(){} // RVA: 0x7FFE875FB2C0
        public void CreateUnknownTypeException(){} // RVA: 0x7FFE875FB480 | overloaded x2
        public void FromXmlQualifiedName(){} // RVA: 0x7FFE875FB540
        public void GetId(){} // RVA: 0x7FFE875FB680
        public void AlreadyQueued(){} // RVA: 0x7FFE875FB870
        public void GetNamespacePrefix(){} // RVA: 0x7FFE875FB8B0
        public void GetQualifiedName(){} // RVA: 0x7FFE875FBA70
        public void InitCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void TopLevelElement(){} // RVA: 0x7FFE875FBBD0
        public void WriteAttribute(){} // RVA: 0x7FFE875FBC60 | overloaded x2
        public void WriteXmlNode(){} // RVA: 0x7FFE875FBCF0
        public void WriteElementEncoded(){} // RVA: 0x7FFE875FBDD0
        public void WriteElementLiteral(){} // RVA: 0x7FFE875FBF10
        public void WriteElementQualifiedName(){} // RVA: 0x7FFE875FC070 | overloaded x2
        public void WriteElementString(){} // RVA: 0x7FFE875FC200 | overloaded x2
        public void WriteEndElement(){} // RVA: 0x7FFE875FC3E0 | overloaded x2
        public void WriteNamespaceDeclarations(){} // RVA: 0x7FFE875FC440
        public void WriteNullableQualifiedNameEncoded(){} // RVA: 0x7FFE875FC850
        public void WriteNullableQualifiedNameLiteral(){} // RVA: 0x7FFE875FC930
        public void WriteNullableStringEncoded(){} // RVA: 0x7FFE875FCA00
        public void WriteNullableStringLiteral(){} // RVA: 0x7FFE875FCA20
        public void WriteNullTagEncoded(){} // RVA: 0x7FFE875FCA50
        public void WriteNullTagLiteral(){} // RVA: 0x7FFE875FCB80
        public void WritePotentiallyReferencingElement(){} // RVA: 0x7FFE875FCCB0
        public void WriteReferencedElements(){} // RVA: 0x7FFE875FD150
        public void IsPrimitiveArray(){} // RVA: 0x7FFE875FD410
        public void WriteArray(){} // RVA: 0x7FFE875FD510
        public void WriteReferencingElement(){} // RVA: 0x7FFE875FD950
        public void CheckReferenceQueue(){} // RVA: 0x7FFE875FDAD0
        public void WriteSerializable(){} // RVA: 0x7FFE875FDC90 | overloaded x2
        public void WriteStartDocument(){} // RVA: 0x7FFE875FDD90
        public void WriteStartElement(){} // RVA: 0x7FFE875FDEB0 | overloaded x5
        public void WriteTypedPrimitive(){} // RVA: 0x7FFE875FE580
        public void WriteValue(){} // RVA: 0x7FFE875FE8F0
        public void WriteXmlAttribute(){} // RVA: 0x7FFE875FE930
        public void WriteXsiType(){} // RVA: 0x7FFE875FEE40
    }

    public class XmlSerializationWriterInterpreter : XmlSerializationWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875FEFB0
        public void InitCallbacks(){} // RVA: 0x7FFE875FF0E0
        public void WriteRoot(){} // RVA: 0x7FFE875FF4B0
        public void WriteObject(){} // RVA: 0x7FFE875FF780
        public void WriteMessage(){} // RVA: 0x7FFE875FFFD0
        public void WriteObjectElement(){} // RVA: 0x7FFE876002B0
        public void WriteObjectElementAttributes(){} // RVA: 0x7FFE87600400
        public void WriteObjectElementElements(){} // RVA: 0x7FFE876004B0
        public void WriteMembers(){} // RVA: 0x7FFE87600560
        public void WriteAttributeMembers(){} // RVA: 0x7FFE876005C0
        public void WriteElementMembers(){} // RVA: 0x7FFE87600B30
        public void GetMemberValue(){} // RVA: 0x7FFE876010E0
        public void MemberHasValue(){} // RVA: 0x7FFE876011C0
        public void WriteMemberElement(){} // RVA: 0x7FFE876014C0
        public void ImplicitConvert(){} // RVA: 0x7FFE87601B50
        public void WritePrimitiveValueLiteral(){} // RVA: 0x7FFE87601F10
        public void WritePrimitiveValueEncoded(){} // RVA: 0x7FFE87602210
        public void WriteListElement(){} // RVA: 0x7FFE87602530
        public void WriteListContent(){} // RVA: 0x7FFE876027E0
        public void GetListCount(){} // RVA: 0x7FFE87602FB0
        public void WriteAnyElementContent(){} // RVA: 0x7FFE87603180
        public void WritePrimitiveElement(){} // RVA: 0x7FFE876037C0
        public void WriteEnumElement(){} // RVA: 0x7FFE87603810
        public void GetStringValue(){} // RVA: 0x7FFE876038F0
        public void GetEnumXmlValue(){} // RVA: 0x7FFE87603C00
    }

    public class XmlSerializer : Object
    {
        public int generationThreshold;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87603D70
        public void .ctor(){} // RVA: 0x7FFE87603EC0
        public void get_Mapping(){} // RVA: 0x7FFE810FE7C0
        public void OnUnknownAttribute(){} // RVA: 0x7FFE87604070
        public void OnUnknownElement(){} // RVA: 0x7FFE876040A0
        public void OnUnknownNode(){} // RVA: 0x7FFE876040D0
        public void OnUnreferencedObject(){} // RVA: 0x7FFE87604100
        public void CreateReader(){} // RVA: 0x7FFE87605160 | overloaded x2
        public void CreateWriter(){} // RVA: 0x7FFE87604C40 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFE876043E0 | overloaded x3
        public void Serialize(){} // RVA: 0x7FFE87604960 | overloaded x4
    }

    public class XmlSerializerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateSerializer(){} // RVA: 0x7FFE87605350 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87605800
    }

    public class XmlSerializerImplementation : Object
    {
        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7FFE876058D0
    }

    public class XmlSerializerNamespaces : Object
    {
        public System.Collections.Hashtable namespaces; // 0x10
        public object field_1; // 0x2FE
        public object field_2; // 0x2FF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Add(){} // RVA: 0x7FFE875D43F0
        public void AddInternal(){} // RVA: 0x7FFE875D44C0
        public void ToArray(){} // RVA: 0x7FFE875D4510
        public void get_Count(){} // RVA: 0x7FFE875D4620
        public void get_NamespaceList(){} // RVA: 0x7FFE875D4660
        public void get_Namespaces(){} // RVA: 0x7FFE875D49D0
        public void set_Namespaces(){} // RVA: 0x7FFE810FCE30
    }

    public class XmlTextAttribute : Attribute
    {
        public string dataType; // 0x10
        public System.Type type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_DataType(){} // RVA: 0x7FFE87605910
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
        public void AddKeyHash(){} // RVA: 0x7FFE87605970
    }

    public class XmlTypeAttribute : Attribute
    {
        public bool includeInSchema; // 0x10
        public string ns; // 0x18
        public string typeName; // 0x20

        // ── Methods ──
        public void get_IncludeInSchema(){} // RVA: 0x7FFE811C55E0
        public void get_Namespace(){} // RVA: 0x7FFE810FE7C0
        public void get_TypeName(){} // RVA: 0x7FFE87605B80
        public void AddKeyHash(){} // RVA: 0x7FFE87605BE0
    }

    public class XmlTypeConvertorAttribute : Attribute
    {
        public string _method; // 0x10

        // ── Methods ──
        public void get_Method(){} // RVA: 0x7FFE81116380
        public void set_Method(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class XmlTypeMapElementInfo : Object
    {
        public string _elementName; // 0x10
        public string _namespace; // 0x18
        public 0x6655D5D4 _form; // 0x20
        public System.Xml.Serialization.XmlTypeMapMember _member; // 0x28
        public object _choiceValue; // 0x30
        public bool _isNullable; // 0x38
        public int _nestingLevel; // 0x3C
        public System.Xml.Serialization.XmlTypeMapping _mappedType; // 0x40
        public System.Xml.Serialization.TypeData _type; // 0x48
        public bool _wrappedElement; // 0x50
        public int _explicitOrder; // 0x54
        public object field_11; // 0x36B
        public object field_12; // 0x36C
        public object field_13; // 0x36D
        public object field_14; // 0x36E
        public object field_15; // 0x36F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87605E00
        public void get_TypeData(){} // RVA: 0x7FFE81176730
        public void get_ChoiceValue(){} // RVA: 0x7FFE8144E200
        public void set_ChoiceValue(){} // RVA: 0x7FFE81129890
        public void get_ElementName(){} // RVA: 0x7FFE81116380
        public void set_ElementName(){} // RVA: 0x7FFE810FCE30
        public void get_Namespace(){} // RVA: 0x7FFE810FE7C0
        public void set_Namespace(){} // RVA: 0x7FFE81161E80
        public void get_DataTypeNamespace(){} // RVA: 0x7FFE87605F90
        public void get_DataTypeName(){} // RVA: 0x7FFE87606020
        public void get_Form(){} // RVA: 0x7FFE8151D690
        public void set_Form(){} // RVA: 0x7FFE8170B670
        public void get_MappedType(){} // RVA: 0x7FFE81178740
        public void set_MappedType(){} // RVA: 0x7FFE81123200
        public void get_IsNullable(){} // RVA: 0x7FFE812CF770
        public void set_IsNullable(){} // RVA: 0x7FFE812D0010
        public void get_Member(){} // RVA: 0x7FFE81129130
        public void set_NestingLevel(){} // RVA: 0x7FFE82A4B070
        public void get_MultiReferenceType(){} // RVA: 0x7FFE87606050
        public void get_WrappedElement(){} // RVA: 0x7FFE811B58E0
        public void set_WrappedElement(){} // RVA: 0x7FFE811B58F0
        public void get_IsTextElement(){} // RVA: 0x7FFE87606070
        public void set_IsTextElement(){} // RVA: 0x7FFE876060F0
        public void get_IsUnnamedAnyElement(){} // RVA: 0x7FFE87606250
        public void set_IsUnnamedAnyElement(){} // RVA: 0x7FFE876062E0
        public void get_ExplicitOrder(){} // RVA: 0x7FFE819EA920
        public void set_ExplicitOrder(){} // RVA: 0x7FFE819EA900
        public void Equals(){} // RVA: 0x7FFE87606440
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
    }

    public class XmlTypeMapElementInfoList : ArrayList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87606610
    }

    public class XmlTypeMapMember : Object
    {
        public string _name; // 0x10
        public int _index; // 0x18
        public int _globalIndex; // 0x1C
        public int _specifiedGlobalIndex; // 0x20
        public System.Xml.Serialization.TypeData _typeData; // 0x28
        public System.Reflection.MemberInfo _member; // 0x30
        public System.Reflection.MemberInfo _specifiedMember; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87606620
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_DefaultValue(){} // RVA: 0x7FFE81176730
        public void set_DefaultValue(){} // RVA: 0x7FFE81176740
        public void IsReadOnly(){} // RVA: 0x7FFE876066D0
        public void GetValue(){} // RVA: 0x7FFE876069E0 | overloaded x2
        public void SetValue(){} // RVA: 0x7FFE87606DF0 | overloaded x2
        public void InitMember(){} // RVA: 0x7FFE87606FB0
        public void get_TypeData(){} // RVA: 0x7FFE81129130
        public void set_TypeData(){} // RVA: 0x7FFE810FCE90
        public void get_Index(){} // RVA: 0x7FFE813DB630
        public void set_Index(){} // RVA: 0x7FFE8144DF00
        public void get_GlobalIndex(){} // RVA: 0x7FFE82707EE0
        public void set_GlobalIndex(){} // RVA: 0x7FFE82717690
        public void get_IsOptionalValueType(){} // RVA: 0x7FFE86809860
        public void set_IsOptionalValueType(){} // RVA: 0x7FFE87607350
        public void get_IsReturnValue(){} // RVA: 0x7FFE86809830
        public void set_IsReturnValue(){} // RVA: 0x7FFE87607380
        public void CheckOptionalValueType(){} // RVA: 0x7FFE876073B0
        public void GetValueSpecified(){} // RVA: 0x7FFE87607490
        public void SetValueSpecified(){} // RVA: 0x7FFE876077E0
    }

    public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87607BA0
    }

    public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
    {
        // ── Methods ──
        public void IsElementDefined(){} // RVA: 0x7FFE876081E0
        public void get_IsDefaultAny(){} // RVA: 0x7FFE87608480
        public void .ctor(){} // RVA: 0x7FFE87607BA0
    }

    public class XmlTypeMapMemberAttribute : XmlTypeMapMember
    {
        public string _attributeName; // 0x58
        public string _namespace; // 0x60
        public 0x6655D5D4 _form; // 0x68
        public System.Xml.Serialization.XmlTypeMapping _mappedType; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87607B10
        public void get_AttributeName(){} // RVA: 0x7FFE811C3500
        public void set_AttributeName(){} // RVA: 0x7FFE811C3510
        public void get_Namespace(){} // RVA: 0x7FFE81199370
        public void set_Namespace(){} // RVA: 0x7FFE81199380
        public void set_Form(){} // RVA: 0x7FFE82A22F00
        public void get_MappedType(){} // RVA: 0x7FFE811C3590
        public void set_MappedType(){} // RVA: 0x7FFE811C35A0
    }

    public class XmlTypeMapMemberElement : XmlTypeMapMember
    {
        public System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo; // 0x58
        public string _choiceMember; // 0x60
        public bool _isTextCollector; // 0x68
        public System.Xml.Serialization.TypeData _choiceTypeData; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87607BA0
        public void get_ElementInfo(){} // RVA: 0x7FFE87607BB0
        public void set_ElementInfo(){} // RVA: 0x7FFE811C3510
        public void get_ChoiceMember(){} // RVA: 0x7FFE81199370
        public void set_ChoiceMember(){} // RVA: 0x7FFE81199380
        public void get_ChoiceTypeData(){} // RVA: 0x7FFE811C3590
        public void set_ChoiceTypeData(){} // RVA: 0x7FFE811C35A0
        public void FindElement(){} // RVA: 0x7FFE87607C60
        public void SetChoice(){} // RVA: 0x7FFE876081C0
        public void get_IsXmlTextCollector(){} // RVA: 0x7FFE811C3570
        public void set_IsXmlTextCollector(){} // RVA: 0x7FFE811C3580
    }

    public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
    {
        public int _flatArrayIndex; // 0x78

        // ── Methods ──
        public void get_FlatArrayIndex(){} // RVA: 0x7FFE8286C0A0
        public void set_FlatArrayIndex(){} // RVA: 0x7FFE82862F10
        public void .ctor(){} // RVA: 0x7FFE87607BA0
    }

    public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
    {
        public System.Xml.Serialization.ListMap _listMap; // 0x80

        // ── Methods ──
        public void get_ListMap(){} // RVA: 0x7FFE81280C30
        public void set_ListMap(){} // RVA: 0x7FFE81282380
        public void .ctor(){} // RVA: 0x7FFE87607BA0
    }

    public class XmlTypeMapMemberList : XmlTypeMapMemberElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87607BA0
    }

    public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87607BA0
    }

    public class XmlTypeMapping : XmlMapping
    {
        public string xmlType; // 0x48
        public string xmlTypeNamespace; // 0x50
        public System.Xml.Serialization.TypeData type; // 0x58
        public System.Xml.Serialization.XmlTypeMapping baseMap; // 0x60
        public bool multiReferenceType; // 0x68
        public bool includeInSchema; // 0x69
        public bool isNullable; // 0x6A
        public bool isAny; // 0x6B
        public System.Collections.ArrayList _derivedTypes; // 0x70
        public object field_9; // 0x38D
        public object field_10; // 0x38E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87608660
        public void get_TypeFullName(){} // RVA: 0x7FFE876088C0
        public void get_TypeData(){} // RVA: 0x7FFE811C3500
        public void get_XmlType(){} // RVA: 0x7FFE81176730
        public void set_XmlType(){} // RVA: 0x7FFE81176740
        public void get_XmlTypeNamespace(){} // RVA: 0x7FFE876088E0
        public void set_XmlTypeNamespace(){} // RVA: 0x7FFE812534D0
        public void get_HasXmlTypeNamespace(){} // RVA: 0x7FFE85C018B0
        public void get_DerivedTypes(){} // RVA: 0x7FFE811C3590
        public void get_MultiReferenceType(){} // RVA: 0x7FFE811C3570
        public void get_BaseMap(){} // RVA: 0x7FFE81199370
        public void set_BaseMap(){} // RVA: 0x7FFE81199380
        public void set_IncludeInSchema(){} // RVA: 0x7FFE85B63740
        public void get_IsNullable(){} // RVA: 0x7FFE8663A5A0
        public void set_IsNullable(){} // RVA: 0x7FFE8663A5B0
        public void get_IsAny(){} // RVA: 0x7FFE87608930
        public void set_IsAny(){} // RVA: 0x7FFE87608940
        public void GetRealTypeMap(){} // RVA: 0x7FFE87608950
        public void GetRealElementMap(){} // RVA: 0x7FFE87608AE0
        public void UpdateRoot(){} // RVA: 0x7FFE87608E10
    }

    public class XmlTypeSerializationSource : SerializationSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D6040
        public void Equals(){} // RVA: 0x7FFE875D62E0
        public void GetHashCode(){} // RVA: 0x7FFE86919610
    }

}