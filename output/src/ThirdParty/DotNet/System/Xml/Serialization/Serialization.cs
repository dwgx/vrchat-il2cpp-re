// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Serialization
// Classes: 75
// Methods: 587

namespace ThirdParty.DotNet.System.Xml.Serialization
{
    public class ClassMap : ObjectMap
    {
        public System.Collections.Hashtable IsOrderDependentMap; // 0x10
        public System.Collections.ArrayList DefaultAnyElementMember; // 0x18
        public System.Collections.Hashtable DefaultAnyAttributeMember; // 0x20
        public System.Xml.Serialization.XmlTypeMapMemberAttribute[] NamespaceDeclarations; // 0x28
        public System.Collections.ArrayList AttributeMembers; // 0x30
        public System.Collections.ArrayList ElementMembers; // 0x38
        public System.Collections.ArrayList AllMembers; // 0x40
        public System.Collections.ArrayList FlatLists; // 0x48
        public System.Xml.Serialization.XmlTypeMapMemberAnyElement ListMembers; // 0x50
        public System.Xml.Serialization.XmlTypeMapMemberAnyAttribute XmlTextCollector; // 0x58
        public System.Xml.Serialization.XmlTypeMapMemberNamespaces ReturnMember; // 0x60
        public System.Xml.Serialization.XmlTypeMapMember SimpleContentBaseType; // 0x68
        public System.Xml.Serialization.XmlTypeMapMember HasSimpleContent; // 0x70
        public bool _ignoreMemberNamespace; // 0x78
        public bool _canBeSimpleType; // 0x79
        public System.Nullable`1<bool> _isOrderDependentMap; // 0x7A

        // ── Methods ──
        public void AddMember(){} // RVA: 0x7FFAC9261650
        public void RegisterFlatList(){} // RVA: 0x7FFAC9262410
        public void GetAttribute(){} // RVA: 0x7FFAC9262510
        public void GetElement(){} // RVA: 0x7FFAC92629A0 | overloaded x2
        public void BuildKey(){} // RVA: 0x7FFAC9262C40
        public void get_IsOrderDependentMap(){} // RVA: 0x7FFAC9262D20
        public void get_DefaultAnyElementMember(){} // RVA: 0x7FFAC2FC20E0
        public void get_DefaultAnyAttributeMember(){} // RVA: 0x7FFAC2FE9500
        public void get_NamespaceDeclarations(){} // RVA: 0x7FFAC2FBF370
        public void get_AttributeMembers(){} // RVA: 0x7FFAC9262FA0
        public void get_ElementMembers(){} // RVA: 0x7FFAC2F247C0
        public void get_AllMembers(){} // RVA: 0x7FFAC31D0140
        public void get_FlatLists(){} // RVA: 0x7FFAC31D95E0
        public void get_ListMembers(){} // RVA: 0x7FFAC2F9C730
        public void get_XmlTextCollector(){} // RVA: 0x7FFAC2F9CD50
        public void get_ReturnMember(){} // RVA: 0x7FFAC2FE9590
        public void get_SimpleContentBaseType(){} // RVA: 0x7FFAC9263370
        public void SetCanBeSimpleType(){} // RVA: 0x7FFAC33CBCC0
        public void get_HasSimpleContent(){} // RVA: 0x7FFAC92635A0
        public void .ctor(){} // RVA: 0x7FFAC9263630
    }

    public class CodeIdentifier : Object
    {
        public Microsoft.CSharp.CodeDomProvider csharp;

        // ── Methods ──
        public void MakePascal(){} // RVA: 0x7FFAC922B5C0
        public void MakeValid(){} // RVA: 0x7FFAC922B8B0
        public void IsValidStart(){} // RVA: 0x7FFAC922BAC0
        public void IsValid(){} // RVA: 0x7FFAC922BB20
        public void .cctor(){} // RVA: 0x7FFAC922BBD0
    }

    public class EnumMap : ObjectMap
    {
        public EnumMapMember[] IsFlags; // 0x10
        public bool EnumNames; // 0x18
        public string[] XmlNames; // 0x20
        public string[] Values; // 0x28
        public long[] _values; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92648D0
        public void get_IsFlags(){} // RVA: 0x7FFAC2F3C4E0
        public void get_EnumNames(){} // RVA: 0x7FFAC2F4F0C0
        public void get_XmlNames(){} // RVA: 0x7FFAC2F4F130
        public void get_Values(){} // RVA: 0x7FFAC31D95E0
        public void GetXmlName(){} // RVA: 0x7FFAC9264C50
        public void GetEnumName(){} // RVA: 0x7FFAC9264FD0
    }

    public class IXmlSerializable
    {
        // ── Methods ──
        public void GetSchema(){} // RVA: 0x7FFAC2C58E90
        public void ReadXml(){} // RVA: 0x7FFAC2C70A40
        public void WriteXml(){} // RVA: 0x7FFAC2C70A40
    }

    public class IXmlTextParser
    {
        public object Normalized;

        // ── Methods ──
        public void get_Normalized(){} // RVA: 0x7FFAC2C59D00
        public void set_Normalized(){} // RVA: 0x7FFAC2C71060
    }

    public class KeyHelper : Object
    {
        // ── Methods ──
        public void AddField(){} // RVA: 0x7FFAC922CB30 | overloaded x6
    }

    public class ListMap : ObjectMap
    {
        public System.Xml.Serialization.XmlTypeMapElementInfoList ChoiceMember; // 0x10
        public string ItemInfo; // 0x18

        // ── Methods ──
        public void set_ChoiceMember(){} // RVA: 0x7FFAC2F87E80
        public void get_ItemInfo(){} // RVA: 0x7FFAC2F3C380
        public void set_ItemInfo(){} // RVA: 0x7FFAC2F22E30
        public void FindElement(){} // RVA: 0x7FFAC9263DB0 | overloaded x2
        public void FindTextElement(){} // RVA: 0x7FFAC9264020
        public void GetArrayType(){} // RVA: 0x7FFAC92641F0
        public void Equals(){} // RVA: 0x7FFAC9264730
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ObjectMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectionHelper : Object
    {
        public System.Collections.Hashtable _clrTypes; // 0x10
        public System.Collections.Hashtable _schemaTypes; // 0x18
        public System.Reflection.ParameterModifier[] empty_modifiers;

        // ── Methods ──
        public void RegisterSchemaType(){} // RVA: 0x7FFAC922CC10
        public void GetRegisteredSchemaType(){} // RVA: 0x7FFAC922CCD0
        public void RegisterClrType(){} // RVA: 0x7FFAC922CDD0
        public void GetRegisteredClrType(){} // RVA: 0x7FFAC922CF70
        public void CheckSerializableType(){} // RVA: 0x7FFAC922D130
        public void .ctor(){} // RVA: 0x7FFAC922D4E0
        public void .cctor(){} // RVA: 0x7FFAC922D610
    }

    public class SerializationSource : Object
    {
        public System.Type[] includedTypes; // 0x10
        public string namspace; // 0x18
        public bool canBeGenerated; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922D6C0
        public void BaseEquals(){} // RVA: 0x7FFAC922D780
    }

    public class TypeData : Object
    {
        public System.Type TypeName; // 0x10
        public string XmlType; // 0x18
        public 0x6B15E040 Type; // 0x20
        public System.Type FullTypeName; // 0x28
        public string SchemaType; // 0x30
        public string IsListType; // 0x38
        public System.Xml.Serialization.TypeData IsComplexType; // 0x40
        public System.Xml.Serialization.TypeData IsValueType; // 0x48
        public System.Xml.Schema.XmlSchemaPatternFacet IsNullable; // 0x50
        public System.Reflection.MethodInfo ListItemTypeData; // 0x58
        public bool ListItemType; // 0x60
        public bool IsXsdType; // 0x61
        public string[] HasPublicConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922DDE0 | overloaded x2
        public void LookupTypeConvertor(){} // RVA: 0x7FFAC922E5E0
        public void ConvertForAssignment(){} // RVA: 0x7FFAC922E760
        public void get_TypeName(){} // RVA: 0x7FFAC31D95E0
        public void get_XmlType(){} // RVA: 0x7FFAC2F247C0
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_FullTypeName(){} // RVA: 0x7FFAC31D0140
        public void get_SchemaType(){} // RVA: 0x7FFAC30DBBE0
        public void get_IsListType(){} // RVA: 0x7FFAC922E8A0
        public void get_IsComplexType(){} // RVA: 0x7FFAC922E8B0
        public void get_IsValueType(){} // RVA: 0x7FFAC922E8E0
        public void get_IsNullable(){} // RVA: 0x7FFAC922E980
        public void set_IsNullable(){} // RVA: 0x7FFAC3C04530
        public void get_ListItemTypeData(){} // RVA: 0x7FFAC922EA90
        public void get_ListItemType(){} // RVA: 0x7FFAC922EB90
        public void get_IsXsdType(){} // RVA: 0x7FFAC922F450
        public void get_HasPublicConstructor(){} // RVA: 0x7FFAC2F4A020
        public void GetIndexerProperty(){} // RVA: 0x7FFAC922F460
        public void CreateMissingAddMethodException(){} // RVA: 0x7FFAC922F5B0
        public void GetGenericListItemType(){} // RVA: 0x7FFAC922F720
        public void .cctor(){} // RVA: 0x7FFAC922F940
    }

    public class TypeMember : Object
    {
        public System.Type type; // 0x10
        public string member; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void GetHashCode(){} // RVA: 0x7FFAC9230590
        public void Equals(){} // RVA: 0x7FFAC9230720 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC92307F0
    }

    public class TypeTranslator : Object
    {
        public System.Collections.Hashtable nameCache;
        public System.Collections.Hashtable primitiveTypes; // 0x8
        public System.Collections.Hashtable primitiveArrayTypes; // 0x10
        public System.Collections.Hashtable nullableTypes; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9230860
        public void GetTypeData(){} // RVA: 0x7FFAC9233AB0 | overloaded x2
        public void GetPrimitiveTypeData(){} // RVA: 0x7FFAC92346E0 | overloaded x2
        public void FindPrimitiveTypeData(){} // RVA: 0x7FFAC9234930
        public void GetArrayName(){} // RVA: 0x7FFAC9234A00
        public void ParseArrayType(){} // RVA: 0x7FFAC9234C10
    }

    public class UnreferencedObjectEventArgs : EventArgs
    {
        public object o; // 0x10
        public string id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922C720
    }

    public class UnreferencedObjectEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class XmlAnyAttributeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlAnyElementAttribute : Attribute
    {
        public string Name; // 0x10
        public string Namespace; // 0x18
        public int Order; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5875C30
        public void get_Name(){} // RVA: 0x7FFAC9234ED0
        public void get_Namespace(){} // RVA: 0x7FFAC2F247C0
        public void get_Order(){} // RVA: 0x7FFAC30DBBE0
        public void AddKeyHash(){} // RVA: 0x7FFAC9234F30
    }

    public class XmlAnyElementAttributes : CollectionBase
    {
        public object Item;
        public object Order;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC9235130
        public void Add(){} // RVA: 0x7FFAC92351E0
        public void AddKeyHash(){} // RVA: 0x7FFAC9235240
        public void get_Order(){} // RVA: 0x7FFAC9235400
        public void .ctor(){} // RVA: 0x7FFAC8364240
    }

    public class XmlArrayAttribute : Attribute
    {
        public string ElementName; // 0x10
        public 0x6B164550 Form; // 0x18
        public bool IsNullable; // 0x1C
        public string Namespace; // 0x20
        public int Order; // 0x28

        // ── Methods ──
        public void get_ElementName(){} // RVA: 0x7FFAC92355D0
        public void get_Form(){} // RVA: 0x7FFAC3157800
        public void get_IsNullable(){} // RVA: 0x7FFAC2F3C390
        public void get_Namespace(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Order(){} // RVA: 0x7FFAC32EC4C0
        public void AddKeyHash(){} // RVA: 0x7FFAC9235630
    }

    public class XmlArrayItemAttribute : Attribute
    {
        public string DataType; // 0x10
        public string ElementName; // 0x18
        public 0x6B164550 Form; // 0x20
        public string Namespace; // 0x28
        public bool IsNullable; // 0x30
        public bool IsNullableSpecified; // 0x31
        public int Type; // 0x34
        public System.Type NestingLevel; // 0x38

        // ── Methods ──
        public void get_DataType(){} // RVA: 0x7FFAC9235990
        public void get_ElementName(){} // RVA: 0x7FFAC92359F0
        public void get_Form(){} // RVA: 0x7FFAC30DBBE0
        public void get_Namespace(){} // RVA: 0x7FFAC2F4F130
        public void get_IsNullable(){} // RVA: 0x7FFAC2F47450
        public void get_IsNullableSpecified(){} // RVA: 0x7FFAC2F47470
        public void get_Type(){} // RVA: 0x7FFAC31D0140
        public void get_NestingLevel(){} // RVA: 0x7FFAC3ADEDC0
        public void AddKeyHash(){} // RVA: 0x7FFAC9235A50
    }

    public class XmlArrayItemAttributes : CollectionBase
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC9235F70
        public void Add(){} // RVA: 0x7FFAC9236020
        public void AddKeyHash(){} // RVA: 0x7FFAC9236080
        public void .ctor(){} // RVA: 0x7FFAC8364240
    }

    public class XmlAttributeAttribute : Attribute
    {
        public string AttributeName; // 0x10
        public string DataType; // 0x18
        public System.Type Form; // 0x20
        public 0x6B164550 Namespace; // 0x28
        public string ns; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_AttributeName(){} // RVA: 0x7FFAC9236240
        public void get_DataType(){} // RVA: 0x7FFAC92362A0
        public void set_DataType(){} // RVA: 0x7FFAC2F87E80
        public void get_Form(){} // RVA: 0x7FFAC32EC4C0
        public void get_Namespace(){} // RVA: 0x7FFAC31D95E0
        public void AddKeyHash(){} // RVA: 0x7FFAC9236300
    }

    public class XmlAttributeEventArgs : EventArgs
    {
        public object o; // 0x10
        public System.Xml.XmlAttribute attr; // 0x18
        public string qnames; // 0x20
        public int lineNumber; // 0x28
        public int linePosition; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922C310
    }

    public class XmlAttributeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class XmlAttributeOverrides : Object
    {
        public System.Collections.Hashtable Item; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9236780
        public void get_Item(){} // RVA: 0x7FFAC9236890 | overloaded x2
        public void GetKey(){} // RVA: 0x7FFAC9236A20
        public void AddKeyHash(){} // RVA: 0x7FFAC9236B20
    }

    public class XmlAttributes : Object
    {
        public System.Xml.Serialization.XmlAnyAttributeAttribute XmlAnyAttribute; // 0x10
        public System.Xml.Serialization.XmlAnyElementAttributes XmlAnyElements; // 0x18
        public System.Xml.Serialization.XmlArrayAttribute XmlArray; // 0x20
        public System.Xml.Serialization.XmlArrayItemAttributes XmlArrayItems; // 0x28
        public System.Xml.Serialization.XmlAttributeAttribute XmlAttribute; // 0x30
        public System.Xml.Serialization.XmlChoiceIdentifierAttribute XmlChoiceIdentifier; // 0x38
        public object XmlDefaultValue; // 0x40
        public System.Xml.Serialization.XmlElementAttributes XmlElements; // 0x48
        public System.Xml.Serialization.XmlEnumAttribute XmlIgnore; // 0x50
        public bool Xmlns; // 0x58
        public bool XmlRoot; // 0x59
        public System.Xml.Serialization.XmlRootAttribute XmlText; // 0x60
        public System.Xml.Serialization.XmlTextAttribute XmlType; // 0x68
        public System.Xml.Serialization.XmlTypeAttribute Order; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92371B0 | overloaded x2
        public void get_XmlAnyAttribute(){} // RVA: 0x7FFAC2F3C380
        public void get_XmlAnyElements(){} // RVA: 0x7FFAC2F247C0
        public void get_XmlArray(){} // RVA: 0x7FFAC2F4F0C0
        public void get_XmlArrayItems(){} // RVA: 0x7FFAC2F4F130
        public void get_XmlAttribute(){} // RVA: 0x7FFAC31D95E0
        public void get_XmlChoiceIdentifier(){} // RVA: 0x7FFAC31D0140
        public void get_XmlDefaultValue(){} // RVA: 0x7FFAC2F9E740
        public void get_XmlElements(){} // RVA: 0x7FFAC2F9C730
        public void get_XmlIgnore(){} // RVA: 0x7FFAC313F600
        public void get_Xmlns(){} // RVA: 0x7FFAC778CF40
        public void get_XmlRoot(){} // RVA: 0x7FFAC2FBF370
        public void get_XmlText(){} // RVA: 0x7FFAC2F9CD50
        public void get_XmlType(){} // RVA: 0x7FFAC2FE9590
        public void AddKeyHash(){} // RVA: 0x7FFAC9238220
        public void get_Order(){} // RVA: 0x7FFAC9238740
        public void get_SortableOrder(){} // RVA: 0x7FFAC9238850
    }

    public class XmlChoiceIdentifierAttribute : Attribute
    {
        public string MemberName; // 0x10

        // ── Methods ──
        public void get_MemberName(){} // RVA: 0x7FFAC92388D0
        public void AddKeyHash(){} // RVA: 0x7FFAC9238930
    }

    public class XmlCustomFormatter : Object
    {
        public string[] allTimeFormats;

        // ── Methods ──
        public void FromEnum(){} // RVA: 0x7FFAC9238A80
        public void FromXmlName(){} // RVA: 0x7FFAC9238D40
        public void FromXmlNCName(){} // RVA: 0x7FFAC9238DD0
        public void ToXmlString(){} // RVA: 0x7FFAC9238E60
        public void FromXmlString(){} // RVA: 0x7FFAC923A0C0
        public void .cctor(){} // RVA: 0x7FFAC923B220
    }

    public class XmlElementAttribute : Attribute
    {
        public string DataType; // 0x10
        public string ElementName; // 0x18
        public 0x6B164550 Form; // 0x20
        public string Namespace; // 0x28
        public bool IsNullable; // 0x30
        public System.Type Order; // 0x38
        public int Type; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC923B6C0 | overloaded x2
        public void get_DataType(){} // RVA: 0x7FFAC923B780
        public void get_ElementName(){} // RVA: 0x7FFAC923B7E0
        public void get_Form(){} // RVA: 0x7FFAC30DBBE0
        public void get_Namespace(){} // RVA: 0x7FFAC2F4F130
        public void get_IsNullable(){} // RVA: 0x7FFAC2F47450
        public void get_Order(){} // RVA: 0x7FFAC2FC2080
        public void get_Type(){} // RVA: 0x7FFAC31D0140
        public void AddKeyHash(){} // RVA: 0x7FFAC923B840
    }

    public class XmlElementAttributes : CollectionBase
    {
        public object Item;
        public object Order;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC923BCF0
        public void Add(){} // RVA: 0x7FFAC923BDA0
        public void AddKeyHash(){} // RVA: 0x7FFAC923BE00
        public void get_Order(){} // RVA: 0x7FFAC923BFC0
        public void .ctor(){} // RVA: 0x7FFAC8364240
    }

    public class XmlElementEventArgs : EventArgs
    {
        public object o; // 0x10
        public System.Xml.XmlElement elem; // 0x18
        public string qnames; // 0x20
        public int lineNumber; // 0x28
        public int linePosition; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922C480
    }

    public class XmlElementEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class XmlEnumAttribute : Attribute
    {
        public string Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void AddKeyHash(){} // RVA: 0x7FFAC923C190
    }

    public class XmlIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlIncludeAttribute : Attribute
    {
        public System.Type Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
    }

    public class XmlMapping : Object
    {
        public System.Xml.Serialization.ObjectMap ElementName; // 0x10
        public System.Collections.ArrayList Namespace; // 0x18
        public 0x6B15E8D8 ObjectMap; // 0x20
        public System.Xml.Serialization.SerializationSource RelatedMaps; // 0x28
        public string Format; // 0x30
        public string Source; // 0x38
        public string key; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91AC740
        public void get_ElementName(){} // RVA: 0x7FFAC31D95E0
        public void get_Namespace(){} // RVA: 0x7FFAC31D0140
        public void SetKey(){} // RVA: 0x7FFAC2F49200
        public void get_ObjectMap(){} // RVA: 0x7FFAC2F3C380
        public void set_ObjectMap(){} // RVA: 0x7FFAC2F22E30
        public void get_RelatedMaps(){} // RVA: 0x7FFAC2F247C0
        public void set_RelatedMaps(){} // RVA: 0x7FFAC2F87E80
        public void get_Format(){} // RVA: 0x7FFAC30DBBE0
        public void set_Format(){} // RVA: 0x7FFAC35DB7A0
        public void get_Source(){} // RVA: 0x7FFAC2F4F130
    }

    public class XmlMemberMapping : Object
    {
    }

    public class XmlMembersMapping : XmlMapping
    {
        public bool Count; // 0x48
        public System.Xml.Serialization.XmlMemberMapping[] HasWrapperElement; // 0x50

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC923C2E0
        public void get_HasWrapperElement(){} // RVA: 0x7FFAC2FD8D30
    }

    public class XmlNamespaceDeclarationsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlNodeEventArgs : EventArgs
    {
        public object o; // 0x10
        public System.Xml.XmlNode xmlNode; // 0x18
        public int lineNumber; // 0x20
        public int linePosition; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922C5F0
    }

    public class XmlNodeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class XmlReflectionImporter : Object
    {
        public string initialDefaultNamespace; // 0x10
        public System.Xml.Serialization.XmlAttributeOverrides attributeOverrides; // 0x18
        public System.Collections.ArrayList includedTypes; // 0x20
        public System.Xml.Serialization.ReflectionHelper helper; // 0x28
        public int arrayChoiceCount; // 0x30
        public System.Collections.ArrayList relatedMaps; // 0x38
        public bool allowPrivateTypes; // 0x40
        public string errSimple;
        public string errSimple2; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC923C300
        public void ImportTypeMapping(){} // RVA: 0x7FFAC923C9B0 | overloaded x4
        public void CreateTypeMapping(){} // RVA: 0x7FFAC923CEA0
        public void ImportClassMapping(){} // RVA: 0x7FFAC923D4B0 | overloaded x2
        public void RegisterDerivedMap(){} // RVA: 0x7FFAC923E870
        public void GetTypeNamespace(){} // RVA: 0x7FFAC923E9C0
        public void ImportListMapping(){} // RVA: 0x7FFAC923EBC0 | overloaded x2
        public void ImportXmlNodeMapping(){} // RVA: 0x7FFAC923FB10
        public void ImportPrimitiveMapping(){} // RVA: 0x7FFAC923FE10
        public void ImportEnumMapping(){} // RVA: 0x7FFAC9240000
        public void ImportXmlSerializableMapping(){} // RVA: 0x7FFAC9240840
        public void ImportIncludedTypes(){} // RVA: 0x7FFAC9240A70
        public void GetReflectionMembers(){} // RVA: 0x7FFAC9240C00
        public void CreateMapMember(){} // RVA: 0x7FFAC9241980
        public void ImportElementInfo(){} // RVA: 0x7FFAC92428A0
        public void ImportAnyElementInfo(){} // RVA: 0x7FFAC9243980
        public void ImportTextElementInfo(){} // RVA: 0x7FFAC9243F90
        public void CanBeNull(){} // RVA: 0x7FFAC9244430
        public void IncludeType(){} // RVA: 0x7FFAC9244480
        public void GetDefaultValue(){} // RVA: 0x7FFAC9244970
        public void .cctor(){} // RVA: 0x7FFAC9244B70
    }

    public class XmlReflectionMember : Object
    {
        public bool IsReturnValue; // 0x10
        public string MemberName; // 0x18
        public System.Type MemberType; // 0x20
        public System.Xml.Serialization.XmlAttributes XmlAttributes; // 0x28
        public System.Type DeclaringType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9244DB0
        public void get_IsReturnValue(){} // RVA: 0x7FFAC2FEB5E0
        public void get_MemberName(){} // RVA: 0x7FFAC2F247C0
        public void get_MemberType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_XmlAttributes(){} // RVA: 0x7FFAC9244EB0
        public void get_DeclaringType(){} // RVA: 0x7FFAC31D95E0
        public void set_DeclaringType(){} // RVA: 0x7FFAC2F4F890
    }

    public class XmlRootAttribute : Attribute
    {
        public string DataType; // 0x10
        public string ElementName; // 0x18
        public bool IsNullable; // 0x20
        public string Namespace; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49373B0 | overloaded x2
        public void get_DataType(){} // RVA: 0x7FFAC9244F60
        public void set_DataType(){} // RVA: 0x7FFAC2F22E30
        public void get_ElementName(){} // RVA: 0x7FFAC9244FC0
        public void set_ElementName(){} // RVA: 0x7FFAC2F87E80
        public void get_IsNullable(){} // RVA: 0x7FFAC300F9D0
        public void set_IsNullable(){} // RVA: 0x7FFAC300F9E0
        public void get_Namespace(){} // RVA: 0x7FFAC2F4F130
        public void set_Namespace(){} // RVA: 0x7FFAC2F22E90
        public void AddKeyHash(){} // RVA: 0x7FFAC9245020
    }

    public class XmlSchemaProviderAttribute : Attribute
    {
        public string MethodName; // 0x10
        public bool IsAny; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_MethodName(){} // RVA: 0x7FFAC2F3C380
        public void get_IsAny(){} // RVA: 0x7FFAC2F3C4E0
        public void set_IsAny(){} // RVA: 0x7FFAC2F3C4F0
    }

    public class XmlSerializableMapping : XmlTypeMapping
    {
        public System.Xml.Schema.XmlSchema _schema; // 0x78
        public System.Xml.Schema.XmlSchemaComplexType _schemaType; // 0x80
        public System.Xml.XmlQualifiedName _schemaTypeName; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92607F0
    }

    public class XmlSerializationCollectionFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C4D540
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class XmlSerializationFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class XmlSerializationGeneratedCode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSerializationReadCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD07E0
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class XmlSerializationReader : XmlSerializationGeneratedCode
    {
        public System.Xml.XmlDocument Document; // 0x10
        public System.Xml.XmlReader Reader; // 0x18
        public System.Collections.ArrayList fixups; // 0x20
        public System.Collections.Hashtable collFixups; // 0x28
        public System.Collections.ArrayList collItemFixups; // 0x30
        public System.Collections.Hashtable typesCallbacks; // 0x38
        public System.Collections.ArrayList noIDTargets; // 0x40
        public System.Collections.Hashtable targets; // 0x48
        public System.Collections.Hashtable delayedListFixups; // 0x50
        public System.Xml.Serialization.XmlSerializer eventSource; // 0x58
        public int delayedFixupId; // 0x60
        public System.Collections.Hashtable referencedObjects; // 0x68
        public int readCount; // 0x70
        public int whileIterationCount; // 0x74
        public string w3SchemaNS; // 0x78
        public string w3InstanceNS; // 0x80
        public string w3InstanceNS2000; // 0x88
        public string w3InstanceNS1999; // 0x90
        public string soapNS; // 0x98
        public string wsdlNS; // 0xA0
        public string nullX; // 0xA8
        public string nil; // 0xB0
        public string typeX; // 0xB8
        public string arrayType; // 0xC0
        public System.Xml.XmlQualifiedName arrayQName; // 0xC8

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC92452E0
        public void EnsureArrayList(){} // RVA: 0x7FFAC9245BB0
        public void EnsureHashtable(){} // RVA: 0x7FFAC9245C10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Document(){} // RVA: 0x7FFAC9245C70
        public void get_Reader(){} // RVA: 0x7FFAC2F247C0
        public void AddFixup(){} // RVA: 0x7FFAC9245FB0 | overloaded x3
        public void AddReadCallback(){} // RVA: 0x7FFAC9246090
        public void AddTarget(){} // RVA: 0x7FFAC9246350
        public void CurrentTag(){} // RVA: 0x7FFAC9246550
        public void CreateReadOnlyCollectionException(){} // RVA: 0x7FFAC9246730
        public void CreateUnknownConstantException(){} // RVA: 0x7FFAC92467F0
        public void CreateUnknownNodeException(){} // RVA: 0x7FFAC92468C0
        public void CreateUnknownTypeException(){} // RVA: 0x7FFAC9246950
        public void EnsureArrayIndex(){} // RVA: 0x7FFAC9246AB0
        public void GetNullAttr(){} // RVA: 0x7FFAC9246C20
        public void GetTarget(){} // RVA: 0x7FFAC9246D00
        public void TargetReady(){} // RVA: 0x7FFAC9246DF0
        public void GetXsiType(){} // RVA: 0x7FFAC9246E20
        public void InitCallbacks(){} // RVA: 0x7FFAC2C70980
        public void InitIDs(){} // RVA: 0x7FFAC2C70980
        public void IsXmlnsAttribute(){} // RVA: 0x7FFAC9247100
        public void ParseWsdlArrayType(){} // RVA: 0x7FFAC92471B0
        public void ReadElementQualifiedName(){} // RVA: 0x7FFAC92479F0
        public void ReadEndElement(){} // RVA: 0x7FFAC9247B10
        public void ReadNull(){} // RVA: 0x7FFAC9247BE0
        public void ReadNullableQualifiedName(){} // RVA: 0x7FFAC9247DD0
        public void ReadNullableString(){} // RVA: 0x7FFAC9247E00
        public void ReadReferencedElement(){} // RVA: 0x7FFAC9248010 | overloaded x2
        public void GetCallbackInfo(){} // RVA: 0x7FFAC9247EC0
        public void ReadList(){} // RVA: 0x7FFAC92483B0
        public void ReadReferencedElements(){} // RVA: 0x7FFAC9248A30
        public void ReadReferencingElement(){} // RVA: 0x7FFAC9249900 | overloaded x3
        public void ReadSerializable(){} // RVA: 0x7FFAC9249E00
        public void ReadTypedPrimitive(){} // RVA: 0x7FFAC9249F90 | overloaded x2
        public void ReadXmlNode(){} // RVA: 0x7FFAC924A9F0
        public void ReadXmlDocument(){} // RVA: 0x7FFAC924AA60
        public void ShrinkArray(){} // RVA: 0x7FFAC924ABA0
        public void ToXmlQualifiedName(){} // RVA: 0x7FFAC924AD20
        public void UnknownAttribute(){} // RVA: 0x7FFAC924AFA0
        public void UnknownElement(){} // RVA: 0x7FFAC924B220
        public void UnknownNode(){} // RVA: 0x7FFAC924B510 | overloaded x2
        public void OnUnknownNode(){} // RVA: 0x7FFAC924B590
        public void UnreferencedObject(){} // RVA: 0x7FFAC924B940
    }

    public class XmlSerializationReaderInterpreter : XmlSerializationReader
    {
        public System.Xml.Serialization.XmlMapping _typeMap; // 0xD0
        public 0x6B15E8D8 _format; // 0xD8
        public System.Xml.XmlQualifiedName AnyType;
        public object[] empty_array; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC924BD20
        public void InitCallbacks(){} // RVA: 0x7FFAC924BDA0
        public void InitIDs(){} // RVA: 0x7FFAC2F21310
        public void ReadRoot(){} // RVA: 0x7FFAC924CA30 | overloaded x2
        public void ReadEncodedObject(){} // RVA: 0x7FFAC924C290
        public void ReadMessage(){} // RVA: 0x7FFAC924C460
        public void ReadObject(){} // RVA: 0x7FFAC924CBA0
        public void ReadClassInstance(){} // RVA: 0x7FFAC924CDE0
        public void ReadClassInstanceMembers(){} // RVA: 0x7FFAC924D110
        public void ReadAttributeMembers(){} // RVA: 0x7FFAC924D1C0
        public void ReadMembers(){} // RVA: 0x7FFAC924D810
        public void SetListMembersDefaults(){} // RVA: 0x7FFAC924FBD0
        public void FixupMembers(){} // RVA: 0x7FFAC924FD60
        public void ProcessUnknownAttribute(){} // RVA: 0x7FFAC924B4A0
        public void ProcessUnknownElement(){} // RVA: 0x7FFAC924B4A0
        public void IsReadOnly(){} // RVA: 0x7FFAC92500A0
        public void SetMemberValue(){} // RVA: 0x7FFAC9250260
        public void SetMemberValueFromAttr(){} // RVA: 0x7FFAC9250410
        public void GetMemberValue(){} // RVA: 0x7FFAC9250510
        public void ReadObjectElement(){} // RVA: 0x7FFAC92505F0
        public void ReadPrimitiveValue(){} // RVA: 0x7FFAC92507E0
        public void GetValueFromXmlString(){} // RVA: 0x7FFAC9250980
        public void ReadListElement(){} // RVA: 0x7FFAC9250AB0
        public void ReadListString(){} // RVA: 0x7FFAC9250F90
        public void AddListValue(){} // RVA: 0x7FFAC9251250
        public void CreateInstance(){} // RVA: 0x7FFAC9251620 | overloaded x2
        public void CreateList(){} // RVA: 0x7FFAC92516A0
        public void InitializeList(){} // RVA: 0x7FFAC9251750
        public void FillList(){} // RVA: 0x7FFAC92517E0
        public void CopyEnumerableList(){} // RVA: 0x7FFAC9251800
        public void ReadXmlNodeElement(){} // RVA: 0x7FFAC9251C60
        public void ReadXmlNode(){} // RVA: 0x7FFAC9251C90
        public void ReadPrimitiveElement(){} // RVA: 0x7FFAC9251EA0
        public void ReadEnumElement(){} // RVA: 0x7FFAC9251F60
        public void GetEnumValue(){} // RVA: 0x7FFAC9251FE0
        public void ReadXmlSerializableElement(){} // RVA: 0x7FFAC9252170
        public void .cctor(){} // RVA: 0x7FFAC92523E0
    }

    public class XmlSerializationWriteCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class XmlSerializationWriter : XmlSerializationGeneratedCode
    {
        public System.Runtime.Serialization.ObjectIDGenerator Writer; // 0x10
        public int qnameCount; // 0x18
        public bool topLevelElement; // 0x1C
        public System.Collections.ArrayList namespaces; // 0x20
        public System.Xml.XmlWriter writer; // 0x28
        public System.Collections.Queue referencedElements; // 0x30
        public System.Collections.Hashtable callbacks; // 0x38
        public System.Collections.Hashtable serializedObjects; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92525F0
        public void Initialize(){} // RVA: 0x7FFAC92526A0
        public void get_Writer(){} // RVA: 0x7FFAC2F4F130
        public void AddWriteCallback(){} // RVA: 0x7FFAC92528D0
        public void CreateUnknownAnyElementException(){} // RVA: 0x7FFAC9252B50
        public void CreateUnknownTypeException(){} // RVA: 0x7FFAC9252D10 | overloaded x2
        public void FromXmlQualifiedName(){} // RVA: 0x7FFAC9252DD0
        public void GetId(){} // RVA: 0x7FFAC9252F10
        public void AlreadyQueued(){} // RVA: 0x7FFAC9253100
        public void GetNamespacePrefix(){} // RVA: 0x7FFAC9253140
        public void GetQualifiedName(){} // RVA: 0x7FFAC9253300
        public void InitCallbacks(){} // RVA: 0x7FFAC2C70980
        public void TopLevelElement(){} // RVA: 0x7FFAC9253460
        public void WriteAttribute(){} // RVA: 0x7FFAC92534F0 | overloaded x2
        public void WriteXmlNode(){} // RVA: 0x7FFAC9253580
        public void WriteElementEncoded(){} // RVA: 0x7FFAC9253660
        public void WriteElementLiteral(){} // RVA: 0x7FFAC92537A0
        public void WriteElementQualifiedName(){} // RVA: 0x7FFAC9253900 | overloaded x2
        public void WriteElementString(){} // RVA: 0x7FFAC9253A90 | overloaded x2
        public void WriteEndElement(){} // RVA: 0x7FFAC9253C70 | overloaded x2
        public void WriteNamespaceDeclarations(){} // RVA: 0x7FFAC9253CD0
        public void WriteNullableQualifiedNameEncoded(){} // RVA: 0x7FFAC92540E0
        public void WriteNullableQualifiedNameLiteral(){} // RVA: 0x7FFAC92541C0
        public void WriteNullableStringEncoded(){} // RVA: 0x7FFAC9254290
        public void WriteNullableStringLiteral(){} // RVA: 0x7FFAC92542B0
        public void WriteNullTagEncoded(){} // RVA: 0x7FFAC92542E0
        public void WriteNullTagLiteral(){} // RVA: 0x7FFAC9254410
        public void WritePotentiallyReferencingElement(){} // RVA: 0x7FFAC9254540
        public void WriteReferencedElements(){} // RVA: 0x7FFAC92549E0
        public void IsPrimitiveArray(){} // RVA: 0x7FFAC9254CA0
        public void WriteArray(){} // RVA: 0x7FFAC9254DA0
        public void WriteReferencingElement(){} // RVA: 0x7FFAC92551E0
        public void CheckReferenceQueue(){} // RVA: 0x7FFAC9255360
        public void WriteSerializable(){} // RVA: 0x7FFAC9255520 | overloaded x2
        public void WriteStartDocument(){} // RVA: 0x7FFAC9255620
        public void WriteStartElement(){} // RVA: 0x7FFAC9255740 | overloaded x5
        public void WriteTypedPrimitive(){} // RVA: 0x7FFAC9255E10
        public void WriteValue(){} // RVA: 0x7FFAC9256180
        public void WriteXmlAttribute(){} // RVA: 0x7FFAC92561C0
        public void WriteXsiType(){} // RVA: 0x7FFAC92566D0
    }

    public class XmlSerializationWriterInterpreter : XmlSerializationWriter
    {
        public System.Xml.Serialization.XmlMapping _typeMap; // 0x48
        public 0x6B15E8D8 _format; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9256840
        public void InitCallbacks(){} // RVA: 0x7FFAC9256970
        public void WriteRoot(){} // RVA: 0x7FFAC9256D40
        public void WriteObject(){} // RVA: 0x7FFAC9257010
        public void WriteMessage(){} // RVA: 0x7FFAC9257860
        public void WriteObjectElement(){} // RVA: 0x7FFAC9257B40
        public void WriteObjectElementAttributes(){} // RVA: 0x7FFAC9257C90
        public void WriteObjectElementElements(){} // RVA: 0x7FFAC9257D40
        public void WriteMembers(){} // RVA: 0x7FFAC9257DF0
        public void WriteAttributeMembers(){} // RVA: 0x7FFAC9257E50
        public void WriteElementMembers(){} // RVA: 0x7FFAC92583C0
        public void GetMemberValue(){} // RVA: 0x7FFAC9258970
        public void MemberHasValue(){} // RVA: 0x7FFAC9258A50
        public void WriteMemberElement(){} // RVA: 0x7FFAC9258D50
        public void ImplicitConvert(){} // RVA: 0x7FFAC92593E0
        public void WritePrimitiveValueLiteral(){} // RVA: 0x7FFAC92597A0
        public void WritePrimitiveValueEncoded(){} // RVA: 0x7FFAC9259AA0
        public void WriteListElement(){} // RVA: 0x7FFAC9259DC0
        public void WriteListContent(){} // RVA: 0x7FFAC925A070
        public void GetListCount(){} // RVA: 0x7FFAC925A840
        public void WriteAnyElementContent(){} // RVA: 0x7FFAC925AA10
        public void WritePrimitiveElement(){} // RVA: 0x7FFAC925B050
        public void WriteEnumElement(){} // RVA: 0x7FFAC925B0A0
        public void GetStringValue(){} // RVA: 0x7FFAC925B180
        public void GetEnumXmlValue(){} // RVA: 0x7FFAC925B490
    }

    public class XmlSerializer : Object
    {
        public int Mapping;
        public bool backgroundGeneration; // 0x4
        public bool deleteTempFiles; // 0x5
        public bool generatorFallback; // 0x6
        public bool customSerializer; // 0x10
        public System.Xml.Serialization.XmlMapping typeMapping; // 0x18
        public SerializerData serializerData; // 0x20
        public System.Collections.Hashtable serializerTypes; // 0x8
        public System.Xml.Serialization.UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
        public System.Xml.Serialization.XmlAttributeEventHandler onUnknownAttribute; // 0x30
        public System.Xml.Serialization.XmlElementEventHandler onUnknownElement; // 0x38
        public System.Xml.Serialization.XmlNodeEventHandler onUnknownNode; // 0x40

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC925B600
        public void .ctor(){} // RVA: 0x7FFAC925B750
        public void get_Mapping(){} // RVA: 0x7FFAC2F247C0
        public void OnUnknownAttribute(){} // RVA: 0x7FFAC925B900
        public void OnUnknownElement(){} // RVA: 0x7FFAC925B930
        public void OnUnknownNode(){} // RVA: 0x7FFAC925B960
        public void OnUnreferencedObject(){} // RVA: 0x7FFAC925B990
        public void CreateReader(){} // RVA: 0x7FFAC925C9F0 | overloaded x2
        public void CreateWriter(){} // RVA: 0x7FFAC925C4D0 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFAC925BC70 | overloaded x3
        public void Serialize(){} // RVA: 0x7FFAC925C1F0 | overloaded x4
    }

    public class XmlSerializerFactory : Object
    {
        public System.Collections.Hashtable serializersBySource;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateSerializer(){} // RVA: 0x7FFAC925CBE0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC925D090
    }

    public class XmlSerializerImplementation : Object
    {
        public object Writer;

        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7FFAC925D160
    }

    public class XmlSerializerNamespaces : Object
    {
        public System.Collections.Hashtable Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFAC922BC80
        public void AddInternal(){} // RVA: 0x7FFAC922BD50
        public void ToArray(){} // RVA: 0x7FFAC922BDA0
        public void get_Count(){} // RVA: 0x7FFAC922BEB0
        public void get_NamespaceList(){} // RVA: 0x7FFAC922BEF0
        public void get_Namespaces(){} // RVA: 0x7FFAC922C260
        public void set_Namespaces(){} // RVA: 0x7FFAC2F22E30
    }

    public class XmlTextAttribute : Attribute
    {
        public string DataType; // 0x10
        public System.Type Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_DataType(){} // RVA: 0x7FFAC925D1A0
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
        public void AddKeyHash(){} // RVA: 0x7FFAC925D200
    }

    public class XmlTypeAttribute : Attribute
    {
        public bool IncludeInSchema; // 0x10
        public string Namespace; // 0x18
        public string TypeName; // 0x20

        // ── Methods ──
        public void get_IncludeInSchema(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Namespace(){} // RVA: 0x7FFAC2F247C0
        public void get_TypeName(){} // RVA: 0x7FFAC925D410
        public void AddKeyHash(){} // RVA: 0x7FFAC925D470
    }

    public class XmlTypeConvertorAttribute : Attribute
    {
        public string Method; // 0x10

        // ── Methods ──
        public void get_Method(){} // RVA: 0x7FFAC2F3C380
        public void set_Method(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class XmlTypeMapElementInfo : Object
    {
        public string TypeData; // 0x10
        public string ChoiceValue; // 0x18
        public 0x6B164550 ElementName; // 0x20
        public System.Xml.Serialization.XmlTypeMapMember Namespace; // 0x28
        public object DataTypeNamespace; // 0x30
        public bool DataTypeName; // 0x38
        public int Form; // 0x3C
        public System.Xml.Serialization.XmlTypeMapping MappedType; // 0x40
        public System.Xml.Serialization.TypeData IsNullable; // 0x48
        public bool Member; // 0x50
        public int NestingLevel; // 0x54

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925D690
        public void get_TypeData(){} // RVA: 0x7FFAC2F9C730
        public void get_ChoiceValue(){} // RVA: 0x7FFAC31D95E0
        public void set_ChoiceValue(){} // RVA: 0x7FFAC2F4F890
        public void get_ElementName(){} // RVA: 0x7FFAC2F3C380
        public void set_ElementName(){} // RVA: 0x7FFAC2F22E30
        public void get_Namespace(){} // RVA: 0x7FFAC2F247C0
        public void set_Namespace(){} // RVA: 0x7FFAC2F87E80
        public void get_DataTypeNamespace(){} // RVA: 0x7FFAC925D820
        public void get_DataTypeName(){} // RVA: 0x7FFAC925D8B0
        public void get_Form(){} // RVA: 0x7FFAC30DBBE0
        public void set_Form(){} // RVA: 0x7FFAC35DB7A0
        public void get_MappedType(){} // RVA: 0x7FFAC2F9E740
        public void set_MappedType(){} // RVA: 0x7FFAC2F49200
        public void get_IsNullable(){} // RVA: 0x7FFAC31D95D0
        public void set_IsNullable(){} // RVA: 0x7FFAC31D95C0
        public void get_Member(){} // RVA: 0x7FFAC2F4F130
        public void set_NestingLevel(){} // RVA: 0x7FFAC47E2CD0
        public void get_MultiReferenceType(){} // RVA: 0x7FFAC925D8E0
        public void get_WrappedElement(){} // RVA: 0x7FFAC2FDB8E0
        public void set_WrappedElement(){} // RVA: 0x7FFAC2FDB8F0
        public void get_IsTextElement(){} // RVA: 0x7FFAC925D900
        public void set_IsTextElement(){} // RVA: 0x7FFAC925D980
        public void get_IsUnnamedAnyElement(){} // RVA: 0x7FFAC925DAE0
        public void set_IsUnnamedAnyElement(){} // RVA: 0x7FFAC925DB70
        public void get_ExplicitOrder(){} // RVA: 0x7FFAC38913D0
        public void set_ExplicitOrder(){} // RVA: 0x7FFAC3890750
        public void Equals(){} // RVA: 0x7FFAC925DCD0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
    }

    public class XmlTypeMapElementInfoList : ArrayList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925DEA0
    }

    public class XmlTypeMapMember : Object
    {
        public string Name; // 0x10
        public int DefaultValue; // 0x18
        public int TypeData; // 0x1C
        public int Index; // 0x20
        public System.Xml.Serialization.TypeData GlobalIndex; // 0x28
        public System.Reflection.MemberInfo IsOptionalValueType; // 0x30
        public System.Reflection.MemberInfo IsReturnValue; // 0x38
        public System.Reflection.MethodInfo _shouldSerialize; // 0x40
        public object _defaultValue; // 0x48
        public int _flags; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925DEB0
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_DefaultValue(){} // RVA: 0x7FFAC2F9C730
        public void set_DefaultValue(){} // RVA: 0x7FFAC2F9C740
        public void IsReadOnly(){} // RVA: 0x7FFAC925DF60
        public void GetValue(){} // RVA: 0x7FFAC925E270 | overloaded x2
        public void SetValue(){} // RVA: 0x7FFAC925E680 | overloaded x2
        public void InitMember(){} // RVA: 0x7FFAC925E840
        public void get_TypeData(){} // RVA: 0x7FFAC2F4F130
        public void set_TypeData(){} // RVA: 0x7FFAC2F22E90
        public void get_Index(){} // RVA: 0x7FFAC3157800
        public void set_Index(){} // RVA: 0x7FFAC392CD10
        public void get_GlobalIndex(){} // RVA: 0x7FFAC44357F0
        public void set_GlobalIndex(){} // RVA: 0x7FFAC44474D0
        public void get_IsOptionalValueType(){} // RVA: 0x7FFAC845FF50
        public void set_IsOptionalValueType(){} // RVA: 0x7FFAC925EBE0
        public void get_IsReturnValue(){} // RVA: 0x7FFAC845FF20
        public void set_IsReturnValue(){} // RVA: 0x7FFAC925EC10
        public void CheckOptionalValueType(){} // RVA: 0x7FFAC925EC40
        public void GetValueSpecified(){} // RVA: 0x7FFAC925ED20
        public void SetValueSpecified(){} // RVA: 0x7FFAC925F070
    }

    public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925F430
    }

    public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
    {
        public object IsDefaultAny;

        // ── Methods ──
        public void IsElementDefined(){} // RVA: 0x7FFAC925FA70
        public void get_IsDefaultAny(){} // RVA: 0x7FFAC925FD10
        public void .ctor(){} // RVA: 0x7FFAC925F430
    }

    public class XmlTypeMapMemberAttribute : XmlTypeMapMember
    {
        public string AttributeName; // 0x58
        public string Namespace; // 0x60
        public 0x6B164550 Form; // 0x68
        public System.Xml.Serialization.XmlTypeMapping MappedType; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925F3A0
        public void get_AttributeName(){} // RVA: 0x7FFAC2FE9500
        public void set_AttributeName(){} // RVA: 0x7FFAC2FE9510
        public void get_Namespace(){} // RVA: 0x7FFAC2FBF370
        public void set_Namespace(){} // RVA: 0x7FFAC2FBF380
        public void set_Form(){} // RVA: 0x7FFAC47BAB60
        public void get_MappedType(){} // RVA: 0x7FFAC2FE9590
        public void set_MappedType(){} // RVA: 0x7FFAC2FE95A0
    }

    public class XmlTypeMapMemberElement : XmlTypeMapMember
    {
        public System.Xml.Serialization.XmlTypeMapElementInfoList ElementInfo; // 0x58
        public string ChoiceMember; // 0x60
        public bool ChoiceTypeData; // 0x68
        public System.Xml.Serialization.TypeData IsXmlTextCollector; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925F430
        public void get_ElementInfo(){} // RVA: 0x7FFAC925F440
        public void set_ElementInfo(){} // RVA: 0x7FFAC2FE9510
        public void get_ChoiceMember(){} // RVA: 0x7FFAC2FBF370
        public void set_ChoiceMember(){} // RVA: 0x7FFAC2FBF380
        public void get_ChoiceTypeData(){} // RVA: 0x7FFAC2FE9590
        public void set_ChoiceTypeData(){} // RVA: 0x7FFAC2FE95A0
        public void FindElement(){} // RVA: 0x7FFAC925F4F0
        public void SetChoice(){} // RVA: 0x7FFAC925FA50
        public void get_IsXmlTextCollector(){} // RVA: 0x7FFAC2FE9570
        public void set_IsXmlTextCollector(){} // RVA: 0x7FFAC2FE9580
    }

    public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
    {
        public int FlatArrayIndex; // 0x78

        // ── Methods ──
        public void get_FlatArrayIndex(){} // RVA: 0x7FFAC4596EF0
        public void set_FlatArrayIndex(){} // RVA: 0x7FFAC45963A0
        public void .ctor(){} // RVA: 0x7FFAC925F430
    }

    public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
    {
        public System.Xml.Serialization.ListMap ListMap; // 0x80

        // ── Methods ──
        public void get_ListMap(){} // RVA: 0x7FFAC32EF410
        public void set_ListMap(){} // RVA: 0x7FFAC34D4AA0
        public void .ctor(){} // RVA: 0x7FFAC925F430
    }

    public class XmlTypeMapMemberList : XmlTypeMapMemberElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925F430
    }

    public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925F430
    }

    public class XmlTypeMapping : XmlMapping
    {
        public string TypeFullName; // 0x48
        public string TypeData; // 0x50
        public System.Xml.Serialization.TypeData XmlType; // 0x58
        public System.Xml.Serialization.XmlTypeMapping XmlTypeNamespace; // 0x60
        public bool HasXmlTypeNamespace; // 0x68
        public bool DerivedTypes; // 0x69
        public bool MultiReferenceType; // 0x6A
        public bool BaseMap; // 0x6B
        public System.Collections.ArrayList IncludeInSchema; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC925FEF0
        public void get_TypeFullName(){} // RVA: 0x7FFAC9260150
        public void get_TypeData(){} // RVA: 0x7FFAC2FE9500
        public void get_XmlType(){} // RVA: 0x7FFAC2F9C730
        public void set_XmlType(){} // RVA: 0x7FFAC2F9C740
        public void get_XmlTypeNamespace(){} // RVA: 0x7FFAC9260170
        public void set_XmlTypeNamespace(){} // RVA: 0x7FFAC30794D0
        public void get_HasXmlTypeNamespace(){} // RVA: 0x7FFAC781EE40
        public void get_DerivedTypes(){} // RVA: 0x7FFAC2FE9590
        public void get_MultiReferenceType(){} // RVA: 0x7FFAC2FE9570
        public void get_BaseMap(){} // RVA: 0x7FFAC2FBF370
        public void set_BaseMap(){} // RVA: 0x7FFAC2FBF380
        public void set_IncludeInSchema(){} // RVA: 0x7FFAC466E010
        public void get_IsNullable(){} // RVA: 0x7FFAC8290C80
        public void set_IsNullable(){} // RVA: 0x7FFAC8290C90
        public void get_IsAny(){} // RVA: 0x7FFAC92601C0
        public void set_IsAny(){} // RVA: 0x7FFAC92601D0
        public void GetRealTypeMap(){} // RVA: 0x7FFAC92601E0
        public void GetRealElementMap(){} // RVA: 0x7FFAC9260370
        public void UpdateRoot(){} // RVA: 0x7FFAC92606A0
    }

    public class XmlTypeSerializationSource : SerializationSource
    {
        public string attributeOverridesHash; // 0x28
        public System.Type type; // 0x30
        public string rootHash; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC922D8D0
        public void Equals(){} // RVA: 0x7FFAC922DB70
        public void GetHashCode(){} // RVA: 0x7FFAC856FDE0
    }

}