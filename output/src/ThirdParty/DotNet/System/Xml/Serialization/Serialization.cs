// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Serialization
// Classes: 74
// Methods: 537

namespace ThirdParty.DotNet.System.Xml.Serialization
{
    public class ClassMap : ObjectMap
    {
        public object _elements;
        public object _elementMembers;
        public object _attributeMembers;
        public object _attributeMembersArray;
        public object _flatLists;
        public object _allMembers;
        public object _membersWithDefault;
        public object _listMembers;
        public object _defaultAnyElement;
        public object _defaultAnyAttribute;
        public object _namespaceDeclarations;
        public object _xmlTextCollector;
        public object _returnMember;
        public object _ignoreMemberNamespace;
        public object _canBeSimpleType;
        public object _isOrderDependentMap;

        // ── Methods ──
        public void AddMember(){} // RVA: 0x752F0B0
        public void RegisterFlatList(){} // RVA: 0x752FE30
        public void GetAttribute(){} // RVA: 0x752FF30
        public void GetElement(){} // RVA: 0x75303B0
        public void BuildKey(){} // RVA: 0x7530630
        public void get_IsOrderDependentMap(){} // RVA: 0x7530710
        public void get_DefaultAnyElementMember(){} // RVA: 0xBE58B0
        public void get_DefaultAnyAttributeMember(){} // RVA: 0xC0FFC0
        public void get_NamespaceDeclarations(){} // RVA: 0xBE2C60
        public void get_AttributeMembers(){} // RVA: 0x7530970
        public void get_ElementMembers(){} // RVA: 0xB465B0
        public void get_AllMembers(){} // RVA: 0xD05CA0
        public void get_FlatLists(){} // RVA: 0xD33E60
        public void get_ListMembers(){} // RVA: 0xBBF8F0
        public void get_XmlTextCollector(){} // RVA: 0xBBFF90
        public void get_ReturnMember(){} // RVA: 0xC10050
        public void get_SimpleContentBaseType(){} // RVA: 0x7530D30
        public void SetCanBeSimpleType(){} // RVA: 0x115DDC0
        public void get_HasSimpleContent(){} // RVA: 0x7530F60
        public void .ctor(){} // RVA: 0x7530FF0
    }

    public class CodeIdentifier : Object
    {
        public object csharp;

        // ── Methods ──
        public void MakePascal(){} // RVA: 0x74F9A30
        public void MakeValid(){} // RVA: 0x74F9CE0
        public void IsValidStart(){} // RVA: 0x74F9EE0
        public void IsValid(){} // RVA: 0x74F9F20
        public void .cctor(){} // RVA: 0x74F9FB0
    }

    public class EnumMap : ObjectMap
    {
        public object _members;
        public object _isFlags;
        public object _enumNames;
        public object _xmlNames;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7532200
        public void get_IsFlags(){} // RVA: 0xB5DD50
        public void get_EnumNames(){} // RVA: 0xB700F0
        public void get_XmlNames(){} // RVA: 0xB70160
        public void get_Values(){} // RVA: 0xD33E60
        public void GetXmlName(){} // RVA: 0x7532580
        public void GetEnumName(){} // RVA: 0x75328F0
    }

    public class IXmlSerializable
    {
        // ── Methods ──
        public void GetSchema(){} // RVA: 0x87C0A0
        public void ReadXml(){} // RVA: 0x894320
        public void WriteXml(){} // RVA: 0x894320
    }

    public class IXmlTextParser
    {
        // ── Methods ──
        public void get_Normalized(){} // RVA: 0x87D280
        public void set_Normalized(){} // RVA: 0x894750
    }

    public class KeyHelper : Object
    {
        // ── Methods ──
        public void AddField(){} // RVA: 0x74FB000
    }

    public class ListMap : ObjectMap
    {
        public object _itemInfo;
        public object _choiceMember;

        // ── Methods ──
        public void set_ChoiceMember(){} // RVA: 0xBA9BA0
        public void get_ItemInfo(){} // RVA: 0xB5DBF0
        public void set_ItemInfo(){} // RVA: 0xB44D60
        public void FindElement(){} // RVA: 0x7531720
        public void FindTextElement(){} // RVA: 0x7531970
        public void GetArrayType(){} // RVA: 0x7531B40
        public void Equals(){} // RVA: 0x7532060
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ObjectMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReflectionHelper : Object
    {
        public object _clrTypes;
        public object _schemaTypes;
        public object empty_modifiers;

        // ── Methods ──
        public void RegisterSchemaType(){} // RVA: 0x74FB0D0
        public void GetRegisteredSchemaType(){} // RVA: 0x74FB190
        public void RegisterClrType(){} // RVA: 0x74FB270
        public void GetRegisteredClrType(){} // RVA: 0x74FB3D0
        public void CheckSerializableType(){} // RVA: 0x74FB550
        public void .ctor(){} // RVA: 0x74FB8F0
        public void .cctor(){} // RVA: 0x74FBA20
    }

    public class SerializationSource : Object
    {
        public object includedTypes;
        public object namspace;
        public object canBeGenerated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FBAD0
        public void BaseEquals(){} // RVA: 0x74FBB90
    }

    public class TypeData : Object
    {
        public object type;
        public object elementName;
        public object sType;
        public object listItemType;
        public object typeName;
        public object fullTypeName;
        public object listItemTypeData;
        public object mappedType;
        public object facet;
        public object typeConvertor;
        public object hasPublicConstructor;
        public object nullableOverride;
        public object keywords;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FC1D0
        public void LookupTypeConvertor(){} // RVA: 0x74FC9C0
        public void ConvertForAssignment(){} // RVA: 0x74FCB40
        public void get_TypeName(){} // RVA: 0xD33E60
        public void get_XmlType(){} // RVA: 0xB465B0
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_FullTypeName(){} // RVA: 0xD05CA0
        public void get_SchemaType(){} // RVA: 0xFEAE90
        public void get_IsListType(){} // RVA: 0x74FCC80
        public void get_IsComplexType(){} // RVA: 0x74FCC90
        public void get_IsValueType(){} // RVA: 0x74FCCC0
        public void get_IsNullable(){} // RVA: 0x74FCD40
        public void set_IsNullable(){} // RVA: 0x1A194B0
        public void get_ListItemTypeData(){} // RVA: 0x74FCE40
        public void get_ListItemType(){} // RVA: 0x74FCF30
        public void get_IsXsdType(){} // RVA: 0x74FD7D0
        public void get_HasPublicConstructor(){} // RVA: 0xB6B1A0
        public void GetIndexerProperty(){} // RVA: 0x74FD7E0
        public void CreateMissingAddMethodException(){} // RVA: 0x74FD900
        public void GetGenericListItemType(){} // RVA: 0x74FDA70
        public void .cctor(){} // RVA: 0x74FDCB0
    }

    public class TypeMember : Object
    {
        public object type;
        public object member;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetHashCode(){} // RVA: 0x74FE900
        public void Equals(){} // RVA: 0x74FEA70
        public void ToString(){} // RVA: 0x74FEB20
    }

    public class TypeTranslator : Object
    {
        public object nameCache;
        public object primitiveTypes;
        public object primitiveArrayTypes;
        public object nullableTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x74FEB90
        public void GetTypeData(){} // RVA: 0x7501B20
        public void GetPrimitiveTypeData(){} // RVA: 0x7502740
        public void FindPrimitiveTypeData(){} // RVA: 0x7502990
        public void GetArrayName(){} // RVA: 0x7502A60
        public void ParseArrayType(){} // RVA: 0x7502C30
    }

    public class UnreferencedObjectEventArgs : EventArgs
    {
        public object o;
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FABF0
    }

    public class UnreferencedObjectEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class XmlAnyAttributeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlAnyElementAttribute : Attribute
    {
        public object elementName;
        public object ns;
        public object order;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3928BD0
        public void get_Name(){} // RVA: 0x7502EF0
        public void get_Namespace(){} // RVA: 0xB465B0
        public void get_Order(){} // RVA: 0xFEAE90
        public void AddKeyHash(){} // RVA: 0x7502F10
    }

    public class XmlAnyElementAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7503110
        public void Add(){} // RVA: 0x75031C0
        public void AddKeyHash(){} // RVA: 0x7503220
        public void get_Order(){} // RVA: 0x75033E0
        public void .ctor(){} // RVA: 0x66456C0
    }

    public class XmlArrayAttribute : Attribute
    {
        public object elementName;
        public object form;
        public object isNullable;
        public object ns;
        public object order;

        // ── Methods ──
        public void get_ElementName(){} // RVA: 0x7502EF0
        public void get_Form(){} // RVA: 0xE62D00
        public void get_IsNullable(){} // RVA: 0xB5DC00
        public void get_Namespace(){} // RVA: 0xB700F0
        public void get_Order(){} // RVA: 0x1065D50
        public void AddKeyHash(){} // RVA: 0x75035A0
    }

    public class XmlArrayItemAttribute : Attribute
    {
        public object dataType;
        public object elementName;
        public object form;
        public object ns;
        public object isNullable;
        public object isNullableSpecified;
        public object nestingLevel;
        public object type;

        // ── Methods ──
        public void get_DataType(){} // RVA: 0x7502EF0
        public void get_ElementName(){} // RVA: 0x7503900
        public void get_Form(){} // RVA: 0xFEAE90
        public void get_Namespace(){} // RVA: 0xB70160
        public void get_IsNullable(){} // RVA: 0xB68DF0
        public void get_IsNullableSpecified(){} // RVA: 0xB68E10
        public void get_Type(){} // RVA: 0xD05CA0
        public void get_NestingLevel(){} // RVA: 0xE9CE60
        public void AddKeyHash(){} // RVA: 0x7503920
    }

    public class XmlArrayItemAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7503E30
        public void Add(){} // RVA: 0x7503EE0
        public void AddKeyHash(){} // RVA: 0x7503F40
        public void .ctor(){} // RVA: 0x66456C0
    }

    public class XmlAttributeAttribute : Attribute
    {
        public object attributeName;
        public object dataType;
        public object type;
        public object form;
        public object ns;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AttributeName(){} // RVA: 0x7502EF0
        public void get_DataType(){} // RVA: 0x7503900
        public void set_DataType(){} // RVA: 0xBA9BA0
        public void get_Form(){} // RVA: 0x1065D50
        public void get_Namespace(){} // RVA: 0xD33E60
        public void AddKeyHash(){} // RVA: 0x7504100
    }

    public class XmlAttributeEventArgs : EventArgs
    {
        public object o;
        public object attr;
        public object qnames;
        public object lineNumber;
        public object linePosition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FA7E0
    }

    public class XmlAttributeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class XmlAttributeOverrides : Object
    {
        public object overrides;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7504570
        public void get_Item(){} // RVA: 0x7504640
        public void GetKey(){} // RVA: 0x75047D0
        public void AddKeyHash(){} // RVA: 0x75048D0
    }

    public class XmlAttributes : Object
    {
        public object xmlAnyAttribute;
        public object xmlAnyElements;
        public object xmlArray;
        public object xmlArrayItems;
        public object xmlAttribute;
        public object xmlChoiceIdentifier;
        public object xmlDefaultValue;
        public object xmlElements;
        public object xmlEnum;
        public object xmlIgnore;
        public object xmlns;
        public object xmlRoot;
        public object xmlText;
        public object xmlType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7504F40
        public void get_XmlAnyAttribute(){} // RVA: 0xB5DBF0
        public void get_XmlAnyElements(){} // RVA: 0xB465B0
        public void get_XmlArray(){} // RVA: 0xB700F0
        public void get_XmlArrayItems(){} // RVA: 0xB70160
        public void get_XmlAttribute(){} // RVA: 0xD33E60
        public void get_XmlChoiceIdentifier(){} // RVA: 0xD05CA0
        public void get_XmlDefaultValue(){} // RVA: 0xBC1B30
        public void get_XmlElements(){} // RVA: 0xBBF8F0
        public void get_XmlIgnore(){} // RVA: 0xE3F480
        public void get_Xmlns(){} // RVA: 0x5C8BB10
        public void get_XmlRoot(){} // RVA: 0xBE2C60
        public void get_XmlText(){} // RVA: 0xBBFF90
        public void get_XmlType(){} // RVA: 0xC10050
        public void AddKeyHash(){} // RVA: 0x7505FA0
        public void get_Order(){} // RVA: 0x75064C0
        public void get_SortableOrder(){} // RVA: 0x75065D0
    }

    public class XmlChoiceIdentifierAttribute : Attribute
    {
        public object memberName;

        // ── Methods ──
        public void get_MemberName(){} // RVA: 0x7502EF0
        public void AddKeyHash(){} // RVA: 0x7506650
    }

    public class XmlCustomFormatter : Object
    {
        public object allTimeFormats;

        // ── Methods ──
        public void FromEnum(){} // RVA: 0x75067A0
        public void FromXmlName(){} // RVA: 0x7506AA0
        public void FromXmlNCName(){} // RVA: 0x7506B30
        public void ToXmlString(){} // RVA: 0x7506BC0
        public void FromXmlString(){} // RVA: 0x7507DD0
        public void .cctor(){} // RVA: 0x7508DD0
    }

    public class XmlElementAttribute : Attribute
    {
        public object dataType;
        public object elementName;
        public object form;
        public object ns;
        public object isNullable;
        public object type;
        public object order;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7509270
        public void get_DataType(){} // RVA: 0x7502EF0
        public void get_ElementName(){} // RVA: 0x7503900
        public void get_Form(){} // RVA: 0xFEAE90
        public void get_Namespace(){} // RVA: 0xB70160
        public void get_IsNullable(){} // RVA: 0xB68DF0
        public void get_Order(){} // RVA: 0xBE5850
        public void get_Type(){} // RVA: 0xD05CA0
        public void AddKeyHash(){} // RVA: 0x7509330
    }

    public class XmlElementAttributes : CollectionBase
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x75097D0
        public void Add(){} // RVA: 0x7509880
        public void AddKeyHash(){} // RVA: 0x75098E0
        public void get_Order(){} // RVA: 0x7509AA0
        public void .ctor(){} // RVA: 0x66456C0
    }

    public class XmlElementEventArgs : EventArgs
    {
        public object o;
        public object elem;
        public object qnames;
        public object lineNumber;
        public object linePosition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FA950
    }

    public class XmlElementEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class XmlEnumAttribute : Attribute
    {
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0xB5DBF0
        public void AddKeyHash(){} // RVA: 0x7509C60
    }

    public class XmlIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlIncludeAttribute : Attribute
    {
        public object type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB5DBF0
    }

    public class XmlMapping : Object
    {
        public object map;
        public object relatedMaps;
        public object format;
        public object source;
        public object _elementName;
        public object _namespace;
        public object key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747B460
        public void get_ElementName(){} // RVA: 0xD33E60
        public void get_Namespace(){} // RVA: 0xD05CA0
        public void SetKey(){} // RVA: 0xB6A8C0
        public void get_ObjectMap(){} // RVA: 0xB5DBF0
        public void set_ObjectMap(){} // RVA: 0xB44D60
        public void get_RelatedMaps(){} // RVA: 0xB465B0
        public void set_RelatedMaps(){} // RVA: 0xBA9BA0
        public void get_Format(){} // RVA: 0xFEAE90
        public void set_Format(){} // RVA: 0x1269760
        public void get_Source(){} // RVA: 0xB70160
    }

    public class XmlMembersMapping : XmlMapping
    {
        public object _hasWrapperElement;
        public object _mapping;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7509DB0
        public void get_HasWrapperElement(){} // RVA: 0xBFDA40
    }

    public class XmlNamespaceDeclarationsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlNodeEventArgs : EventArgs
    {
        public object o;
        public object xmlNode;
        public object lineNumber;
        public object linePosition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FAAC0
    }

    public class XmlNodeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class XmlReflectionImporter : Object
    {
        public object initialDefaultNamespace;
        public object attributeOverrides;
        public object includedTypes;
        public object helper;
        public object arrayChoiceCount;
        public object relatedMaps;
        public object allowPrivateTypes;
        public object errSimple;
        public object errSimple2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7509DD0
        public void ImportTypeMapping(){} // RVA: 0x750A470
        public void CreateTypeMapping(){} // RVA: 0x750A930
        public void ImportClassMapping(){} // RVA: 0x750AF00
        public void RegisterDerivedMap(){} // RVA: 0x750C140
        public void GetTypeNamespace(){} // RVA: 0x750C280
        public void ImportListMapping(){} // RVA: 0x750C490
        public void ImportXmlNodeMapping(){} // RVA: 0x750D4A0
        public void ImportPrimitiveMapping(){} // RVA: 0x750D780
        public void ImportEnumMapping(){} // RVA: 0x750D960
        public void ImportXmlSerializableMapping(){} // RVA: 0x750E1A0
        public void ImportIncludedTypes(){} // RVA: 0x750E3D0
        public void GetReflectionMembers(){} // RVA: 0x750E530
        public void CreateMapMember(){} // RVA: 0x750F270
        public void ImportElementInfo(){} // RVA: 0x7510190
        public void ImportAnyElementInfo(){} // RVA: 0x7511240
        public void ImportTextElementInfo(){} // RVA: 0x75117F0
        public void CanBeNull(){} // RVA: 0x7511CA0
        public void IncludeType(){} // RVA: 0x7511CF0
        public void GetDefaultValue(){} // RVA: 0x75121A0
        public void .cctor(){} // RVA: 0x7512390
    }

    public class XmlReflectionMember : Object
    {
        public object isReturnValue;
        public object memberName;
        public object memberType;
        public object xmlAttributes;
        public object declaringType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75125D0
        public void get_IsReturnValue(){} // RVA: 0xC120A0
        public void get_MemberName(){} // RVA: 0xB465B0
        public void get_MemberType(){} // RVA: 0xB700F0
        public void get_XmlAttributes(){} // RVA: 0x75126D0
        public void get_DeclaringType(){} // RVA: 0xD33E60
        public void set_DeclaringType(){} // RVA: 0xB708C0
    }

    public class XmlRootAttribute : Attribute
    {
        public object dataType;
        public object elementName;
        public object isNullable;
        public object ns;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2698EB0
        public void get_DataType(){} // RVA: 0x7502EF0
        public void set_DataType(){} // RVA: 0xB44D60
        public void get_ElementName(){} // RVA: 0x7503900
        public void set_ElementName(){} // RVA: 0xBA9BA0
        public void get_IsNullable(){} // RVA: 0xC38360
        public void set_IsNullable(){} // RVA: 0xC38370
        public void get_Namespace(){} // RVA: 0xB70160
        public void set_Namespace(){} // RVA: 0xB44DC0
        public void AddKeyHash(){} // RVA: 0x7512780
    }

    public class XmlSchemaProviderAttribute : Attribute
    {
        public object _methodName;
        public object _isAny;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_MethodName(){} // RVA: 0xB5DBF0
        public void get_IsAny(){} // RVA: 0xB5DD50
        public void set_IsAny(){} // RVA: 0xB5DD60
    }

    public class XmlSerializableMapping : XmlTypeMapping
    {
        public object _schema;
        public object _schemaType;
        public object _schemaTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x752E280
    }

    public class XmlSerializationCollectionFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB94B0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class XmlSerializationFixupCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class XmlSerializationGeneratedCode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSerializationReadCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23F1BA0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class XmlSerializationReader : XmlSerializationGeneratedCode
    {
        public object document;
        public object reader;
        public object fixups;
        public object collFixups;
        public object collItemFixups;
        public object typesCallbacks;
        public object noIDTargets;
        public object targets;
        public object delayedListFixups;
        public object eventSource;
        public object delayedFixupId;
        public object referencedObjects;
        public object readCount;
        public object whileIterationCount;
        public object w3SchemaNS;
        public object w3InstanceNS;
        public object w3InstanceNS2000;
        public object w3InstanceNS1999;
        public object soapNS;
        public object wsdlNS;
        public object nullX;
        public object nil;
        public object typeX;
        public object arrayType;
        public object arrayQName;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7512A40
        public void EnsureArrayList(){} // RVA: 0x75133E0
        public void EnsureHashtable(){} // RVA: 0x7513440
        public void .ctor(){} // RVA: 0xB43310
        public void get_Document(){} // RVA: 0x75134A0
        public void get_Reader(){} // RVA: 0xB465B0
        public void AddFixup(){} // RVA: 0x75137E0
        public void AddReadCallback(){} // RVA: 0x75138C0
        public void AddTarget(){} // RVA: 0x7513C50
        public void CurrentTag(){} // RVA: 0x7513E50
        public void CreateReadOnlyCollectionException(){} // RVA: 0x7514030
        public void CreateUnknownConstantException(){} // RVA: 0x75140F0
        public void CreateUnknownNodeException(){} // RVA: 0x75141C0
        public void CreateUnknownTypeException(){} // RVA: 0x7514250
        public void EnsureArrayIndex(){} // RVA: 0x75143B0
        public void GetNullAttr(){} // RVA: 0x7514520
        public void GetTarget(){} // RVA: 0x7514600
        public void TargetReady(){} // RVA: 0x75146F0
        public void GetXsiType(){} // RVA: 0x7514720
        public void InitCallbacks(){} // RVA: 0x894290
        public void InitIDs(){} // RVA: 0x894290
        public void IsXmlnsAttribute(){} // RVA: 0x7514BA0
        public void ParseWsdlArrayType(){} // RVA: 0x7514C50
        public void ReadElementQualifiedName(){} // RVA: 0x75153C0
        public void ReadEndElement(){} // RVA: 0x75154C0
        public void ReadNull(){} // RVA: 0x7515590
        public void ReadNullableQualifiedName(){} // RVA: 0x7515780
        public void ReadNullableString(){} // RVA: 0x75157B0
        public void ReadReferencedElement(){} // RVA: 0x75159C0
        public void GetCallbackInfo(){} // RVA: 0x7515870
        public void ReadList(){} // RVA: 0x7515E20
        public void ReadReferencedElements(){} // RVA: 0x7516550
        public void ReadReferencingElement(){} // RVA: 0x7517380
        public void ReadSerializable(){} // RVA: 0x7517940
        public void ReadTypedPrimitive(){} // RVA: 0x7517AD0
        public void ReadXmlNode(){} // RVA: 0x7518530
        public void ReadXmlDocument(){} // RVA: 0x75185A0
        public void ShrinkArray(){} // RVA: 0x75186E0
        public void ToXmlQualifiedName(){} // RVA: 0x7518860
        public void UnknownAttribute(){} // RVA: 0x7518BB0
        public void UnknownElement(){} // RVA: 0x7518E30
        public void UnknownNode(){} // RVA: 0x7519120
        public void OnUnknownNode(){} // RVA: 0x75191A0
        public void UnreferencedObject(){} // RVA: 0x7519560
    }

    public class XmlSerializationReaderInterpreter : XmlSerializationReader
    {
        public object _typeMap;
        public object _format;
        public object AnyType;
        public object empty_array;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7519940
        public void InitCallbacks(){} // RVA: 0x75199C0
        public void InitIDs(){} // RVA: 0xB43310
        public void ReadRoot(){} // RVA: 0x751A640
        public void ReadEncodedObject(){} // RVA: 0x7519EA0
        public void ReadMessage(){} // RVA: 0x751A070
        public void ReadObject(){} // RVA: 0x751A7B0
        public void ReadClassInstance(){} // RVA: 0x751AAA0
        public void ReadClassInstanceMembers(){} // RVA: 0x751ADD0
        public void ReadAttributeMembers(){} // RVA: 0x751AE80
        public void ReadMembers(){} // RVA: 0x751B4B0
        public void SetListMembersDefaults(){} // RVA: 0x751D7F0
        public void FixupMembers(){} // RVA: 0x751D970
        public void ProcessUnknownAttribute(){} // RVA: 0x75190B0
        public void ProcessUnknownElement(){} // RVA: 0x75190B0
        public void IsReadOnly(){} // RVA: 0x751DCA0
        public void SetMemberValue(){} // RVA: 0x751DE50
        public void SetMemberValueFromAttr(){} // RVA: 0x751E000
        public void GetMemberValue(){} // RVA: 0x751E0E0
        public void ReadObjectElement(){} // RVA: 0x751E1C0
        public void ReadPrimitiveValue(){} // RVA: 0x751E3B0
        public void GetValueFromXmlString(){} // RVA: 0x751E520
        public void ReadListElement(){} // RVA: 0x751E670
        public void ReadListString(){} // RVA: 0x751EB30
        public void AddListValue(){} // RVA: 0x751EDE0
        public void CreateInstance(){} // RVA: 0x751F1A0
        public void CreateList(){} // RVA: 0x751F220
        public void InitializeList(){} // RVA: 0x751F2D0
        public void FillList(){} // RVA: 0x751F360
        public void CopyEnumerableList(){} // RVA: 0x751F380
        public void ReadXmlNodeElement(){} // RVA: 0x751F7D0
        public void ReadXmlNode(){} // RVA: 0x751F800
        public void ReadPrimitiveElement(){} // RVA: 0x751F9E0
        public void ReadEnumElement(){} // RVA: 0x751FB70
        public void GetEnumValue(){} // RVA: 0x751FBF0
        public void ReadXmlSerializableElement(){} // RVA: 0x751FD70
        public void .cctor(){} // RVA: 0x751FFE0
    }

    public class XmlSerializationWriteCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class XmlSerializationWriter : XmlSerializationGeneratedCode
    {
        public object idGenerator;
        public object qnameCount;
        public object topLevelElement;
        public object namespaces;
        public object writer;
        public object referencedElements;
        public object callbacks;
        public object serializedObjects;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75202D0
        public void Initialize(){} // RVA: 0x7520380
        public void get_Writer(){} // RVA: 0xB70160
        public void AddWriteCallback(){} // RVA: 0x75205B0
        public void CreateUnknownAnyElementException(){} // RVA: 0x7520830
        public void CreateUnknownTypeException(){} // RVA: 0x75209F0
        public void FromXmlQualifiedName(){} // RVA: 0x7520AB0
        public void GetId(){} // RVA: 0x7520BF0
        public void AlreadyQueued(){} // RVA: 0x7520DD0
        public void GetNamespacePrefix(){} // RVA: 0x7520E10
        public void GetQualifiedName(){} // RVA: 0x7520FC0
        public void InitCallbacks(){} // RVA: 0x894290
        public void TopLevelElement(){} // RVA: 0x7521270
        public void WriteAttribute(){} // RVA: 0x7521300
        public void WriteXmlNode(){} // RVA: 0x7521390
        public void WriteElementEncoded(){} // RVA: 0x7521460
        public void WriteElementLiteral(){} // RVA: 0x7521580
        public void WriteElementQualifiedName(){} // RVA: 0x75216C0
        public void WriteElementString(){} // RVA: 0x7521850
        public void WriteEndElement(){} // RVA: 0x7521A30
        public void WriteNamespaceDeclarations(){} // RVA: 0x7521A90
        public void WriteNullableQualifiedNameEncoded(){} // RVA: 0x7521E80
        public void WriteNullableQualifiedNameLiteral(){} // RVA: 0x7521F60
        public void WriteNullableStringEncoded(){} // RVA: 0x7522030
        public void WriteNullableStringLiteral(){} // RVA: 0x7522050
        public void WriteNullTagEncoded(){} // RVA: 0x7522080
        public void WriteNullTagLiteral(){} // RVA: 0x75221B0
        public void WritePotentiallyReferencingElement(){} // RVA: 0x75222E0
        public void WriteReferencedElements(){} // RVA: 0x7522770
        public void IsPrimitiveArray(){} // RVA: 0x7522A30
        public void WriteArray(){} // RVA: 0x7522B30
        public void WriteReferencingElement(){} // RVA: 0x7522F60
        public void CheckReferenceQueue(){} // RVA: 0x75230E0
        public void WriteSerializable(){} // RVA: 0x75232A0
        public void WriteStartDocument(){} // RVA: 0x75233A0
        public void WriteStartElement(){} // RVA: 0x75234C0
        public void WriteTypedPrimitive(){} // RVA: 0x7523B40
        public void WriteValue(){} // RVA: 0x7523EB0
        public void WriteXmlAttribute(){} // RVA: 0x7523EF0
        public void WriteXsiType(){} // RVA: 0x75243C0
    }

    public class XmlSerializationWriterInterpreter : XmlSerializationWriter
    {
        public object _typeMap;
        public object _format;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7524520
        public void InitCallbacks(){} // RVA: 0x7524650
        public void WriteRoot(){} // RVA: 0x7524A20
        public void WriteObject(){} // RVA: 0x7524CF0
        public void WriteMessage(){} // RVA: 0x7525500
        public void WriteObjectElement(){} // RVA: 0x75257E0
        public void WriteObjectElementAttributes(){} // RVA: 0x7525930
        public void WriteObjectElementElements(){} // RVA: 0x75259E0
        public void WriteMembers(){} // RVA: 0x7525A90
        public void WriteAttributeMembers(){} // RVA: 0x7525AF0
        public void WriteElementMembers(){} // RVA: 0x7526030
        public void GetMemberValue(){} // RVA: 0x75265C0
        public void MemberHasValue(){} // RVA: 0x75266A0
        public void WriteMemberElement(){} // RVA: 0x7526970
        public void ImplicitConvert(){} // RVA: 0x7526FE0
        public void WritePrimitiveValueLiteral(){} // RVA: 0x7527360
        public void WritePrimitiveValueEncoded(){} // RVA: 0x75276C0
        public void WriteListElement(){} // RVA: 0x7527A40
        public void WriteListContent(){} // RVA: 0x7527F30
        public void GetListCount(){} // RVA: 0x75286E0
        public void WriteAnyElementContent(){} // RVA: 0x7528890
        public void WritePrimitiveElement(){} // RVA: 0x7528E20
        public void WriteEnumElement(){} // RVA: 0x7528E70
        public void GetStringValue(){} // RVA: 0x7528F50
        public void GetEnumXmlValue(){} // RVA: 0x7529270
    }

    public class XmlSerializer : Object
    {
        public object generationThreshold;
        public object backgroundGeneration;
        public object deleteTempFiles;
        public object generatorFallback;
        public object customSerializer;
        public object typeMapping;
        public object serializerData;
        public object serializerTypes;
        public object onUnreferencedObject;
        public object onUnknownAttribute;
        public object onUnknownElement;
        public object onUnknownNode;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x75293F0
        public void .ctor(){} // RVA: 0x7529540
        public void get_Mapping(){} // RVA: 0xB465B0
        public void OnUnknownAttribute(){} // RVA: 0x75296E0
        public void OnUnknownElement(){} // RVA: 0x7529710
        public void OnUnknownNode(){} // RVA: 0x7529740
        public void OnUnreferencedObject(){} // RVA: 0x7529770
        public void CreateReader(){} // RVA: 0x752A750
        public void CreateWriter(){} // RVA: 0x752A2A0
        public void Deserialize(){} // RVA: 0x7529A50
        public void Serialize(){} // RVA: 0x7529FC0
    }

    public class XmlSerializerFactory : Object
    {
        public object serializersBySource;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateSerializer(){} // RVA: 0x752A930
        public void .cctor(){} // RVA: 0x752ADA0
    }

    public class XmlSerializerImplementation : Object
    {
        // ── Methods ──
        public void get_Writer(){} // RVA: 0x752AE70
    }

    public class XmlSerializerNamespaces : Object
    {
        public object namespaces;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0x74FA060
        public void AddInternal(){} // RVA: 0x74FA130
        public void ToArray(){} // RVA: 0x74FA180
        public void get_Count(){} // RVA: 0x74FA2B0
        public void get_NamespaceList(){} // RVA: 0x74FA2F0
        public void get_Namespaces(){} // RVA: 0x74FA730
        public void set_Namespaces(){} // RVA: 0xB44D60
    }

    public class XmlTextAttribute : Attribute
    {
        public object dataType;
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_DataType(){} // RVA: 0x7502EF0
        public void get_Type(){} // RVA: 0xB465B0
        public void AddKeyHash(){} // RVA: 0x752AEB0
    }

    public class XmlTypeAttribute : Attribute
    {
        public object includeInSchema;
        public object ns;
        public object typeName;

        // ── Methods ──
        public void get_IncludeInSchema(){} // RVA: 0xC120A0
        public void get_Namespace(){} // RVA: 0xB465B0
        public void get_TypeName(){} // RVA: 0x752B0B0
        public void AddKeyHash(){} // RVA: 0x752B0D0
    }

    public class XmlTypeConvertorAttribute : Attribute
    {
        public object _method;

        // ── Methods ──
        public void get_Method(){} // RVA: 0xB5DBF0
        public void set_Method(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class XmlTypeMapElementInfo : Object
    {
        public object _elementName;
        public object _namespace;
        public object _form;
        public object _member;
        public object _choiceValue;
        public object _isNullable;
        public object _nestingLevel;
        public object _mappedType;
        public object _type;
        public object _wrappedElement;
        public object _explicitOrder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x752B2F0
        public void get_TypeData(){} // RVA: 0xBBF8F0
        public void get_ChoiceValue(){} // RVA: 0xD33E60
        public void set_ChoiceValue(){} // RVA: 0xB708C0
        public void get_ElementName(){} // RVA: 0xB5DBF0
        public void set_ElementName(){} // RVA: 0xB44D60
        public void get_Namespace(){} // RVA: 0xB465B0
        public void set_Namespace(){} // RVA: 0xBA9BA0
        public void get_DataTypeNamespace(){} // RVA: 0x752B480
        public void get_DataTypeName(){} // RVA: 0x752B4F0
        public void get_Form(){} // RVA: 0xFEAE90
        public void set_Form(){} // RVA: 0x1269760
        public void get_MappedType(){} // RVA: 0xBC1B30
        public void set_MappedType(){} // RVA: 0xB6A8C0
        public void get_IsNullable(){} // RVA: 0xD16660
        public void set_IsNullable(){} // RVA: 0xD14C10
        public void get_Member(){} // RVA: 0xB70160
        public void set_NestingLevel(){} // RVA: 0x25671C0
        public void get_MultiReferenceType(){} // RVA: 0x752B520
        public void get_WrappedElement(){} // RVA: 0xC00EC0
        public void set_WrappedElement(){} // RVA: 0xC00ED0
        public void get_IsTextElement(){} // RVA: 0x752B540
        public void set_IsTextElement(){} // RVA: 0x752B5C0
        public void get_IsUnnamedAnyElement(){} // RVA: 0x752B710
        public void set_IsUnnamedAnyElement(){} // RVA: 0x752B760
        public void get_ExplicitOrder(){} // RVA: 0x15443F0
        public void set_ExplicitOrder(){} // RVA: 0x15443E0
        public void Equals(){} // RVA: 0x752B890
        public void GetHashCode(){} // RVA: 0x66DC010
    }

    public class XmlTypeMapElementInfoList : ArrayList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x752BA60
    }

    public class XmlTypeMapMember : Object
    {
        public object _name;
        public object _index;
        public object _globalIndex;
        public object _specifiedGlobalIndex;
        public object _typeData;
        public object _member;
        public object _specifiedMember;
        public object _shouldSerialize;
        public object _defaultValue;
        public object _flags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x752BA70
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_DefaultValue(){} // RVA: 0xBBF8F0
        public void set_DefaultValue(){} // RVA: 0xBBF900
        public void IsReadOnly(){} // RVA: 0x752BB20
        public void GetValue(){} // RVA: 0x752BE10
        public void SetValue(){} // RVA: 0x752C1F0
        public void InitMember(){} // RVA: 0x752C3B0
        public void get_TypeData(){} // RVA: 0xB70160
        public void set_TypeData(){} // RVA: 0xB44DC0
        public void get_Index(){} // RVA: 0xE62D00
        public void set_Index(){} // RVA: 0x1033F40
        public void get_GlobalIndex(){} // RVA: 0x2244FB0
        public void set_GlobalIndex(){} // RVA: 0x22735B0
        public void get_IsOptionalValueType(){} // RVA: 0x6741F40
        public void set_IsOptionalValueType(){} // RVA: 0x752C760
        public void get_IsReturnValue(){} // RVA: 0x6741F30
        public void set_IsReturnValue(){} // RVA: 0x752C790
        public void CheckOptionalValueType(){} // RVA: 0x752C7C0
        public void GetValueSpecified(){} // RVA: 0x752C890
        public void SetValueSpecified(){} // RVA: 0x752CB70
    }

    public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x752CF20
    }

    public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
    {
        // ── Methods ──
        public void IsElementDefined(){} // RVA: 0x752D510
        public void get_IsDefaultAny(){} // RVA: 0x752D7D0
        public void .ctor(){} // RVA: 0x752CF20
    }

    public class XmlTypeMapMemberAttribute : XmlTypeMapMember
    {
        public object _attributeName;
        public object _namespace;
        public object _form;
        public object _mappedType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x752CE90
        public void get_AttributeName(){} // RVA: 0xC0FFC0
        public void set_AttributeName(){} // RVA: 0xC0FFD0
        public void get_Namespace(){} // RVA: 0xBE2C60
        public void set_Namespace(){} // RVA: 0xBE2C70
        public void set_Form(){} // RVA: 0x25406E0
        public void get_MappedType(){} // RVA: 0xC10050
        public void set_MappedType(){} // RVA: 0xC10060
    }

    public class XmlTypeMapMemberElement : XmlTypeMapMember
    {
        public object _elementInfo;
        public object _choiceMember;
        public object _isTextCollector;
        public object _choiceTypeData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x752CF20
        public void get_ElementInfo(){} // RVA: 0x752CF30
        public void set_ElementInfo(){} // RVA: 0xC0FFD0
        public void get_ChoiceMember(){} // RVA: 0xBE2C60
        public void set_ChoiceMember(){} // RVA: 0xBE2C70
        public void get_ChoiceTypeData(){} // RVA: 0xC10050
        public void set_ChoiceTypeData(){} // RVA: 0xC10060
        public void FindElement(){} // RVA: 0x752CFE0
        public void SetChoice(){} // RVA: 0x752D4F0
        public void get_IsXmlTextCollector(){} // RVA: 0xC10030
        public void set_IsXmlTextCollector(){} // RVA: 0xC10040
    }

    public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
    {
        public object _flatArrayIndex;

        // ── Methods ──
        public void get_FlatArrayIndex(){} // RVA: 0x23ADD10
        public void set_FlatArrayIndex(){} // RVA: 0x23B2A80
        public void .ctor(){} // RVA: 0x752CF20
    }

    public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
    {
        public object _listMap;

        // ── Methods ──
        public void get_ListMap(){} // RVA: 0xCD48B0
        public void set_ListMap(){} // RVA: 0xCD3600
        public void .ctor(){} // RVA: 0x752CF20
    }

    public class XmlTypeMapMemberList : XmlTypeMapMemberElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x752CF20
    }

    public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x752CF20
    }

    public class XmlTypeMapping : XmlMapping
    {
        public object xmlType;
        public object xmlTypeNamespace;
        public object type;
        public object baseMap;
        public object multiReferenceType;
        public object includeInSchema;
        public object isNullable;
        public object isAny;
        public object _derivedTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x752D9F0
        public void get_TypeFullName(){} // RVA: 0x752DC60
        public void get_TypeData(){} // RVA: 0xC0FFC0
        public void get_XmlType(){} // RVA: 0xBBF8F0
        public void set_XmlType(){} // RVA: 0xBBF900
        public void get_XmlTypeNamespace(){} // RVA: 0x752DC80
        public void set_XmlTypeNamespace(){} // RVA: 0xCA4DF0
        public void get_HasXmlTypeNamespace(){} // RVA: 0x5BC3080
        public void get_DerivedTypes(){} // RVA: 0xC10050
        public void get_MultiReferenceType(){} // RVA: 0xC10030
        public void get_BaseMap(){} // RVA: 0xBE2C60
        public void set_BaseMap(){} // RVA: 0xBE2C70
        public void set_IncludeInSchema(){} // RVA: 0x6296250
        public void get_IsNullable(){} // RVA: 0x6573C70
        public void set_IsNullable(){} // RVA: 0x6573C80
        public void get_IsAny(){} // RVA: 0x752DCA0
        public void set_IsAny(){} // RVA: 0x752DCB0
        public void GetRealTypeMap(){} // RVA: 0x752DCC0
        public void GetRealElementMap(){} // RVA: 0x752DE40
        public void UpdateRoot(){} // RVA: 0x752E130
    }

    public class XmlTypeSerializationSource : SerializationSource
    {
        public object attributeOverridesHash;
        public object type;
        public object rootHash;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74FBCC0
        public void Equals(){} // RVA: 0x74FBF60
        public void GetHashCode(){} // RVA: 0x6852610
    }

}