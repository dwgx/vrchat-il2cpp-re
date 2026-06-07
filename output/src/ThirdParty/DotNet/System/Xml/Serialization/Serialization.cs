// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Serialization
// Classes: 75
// Methods: 587

namespace ThirdParty.DotNet.System.Xml.Serialization
{
    public class ClassMap
    {
        // ── Methods ──
        public void AddMember(){} // RVA: 0x6ACAAD0
        public void RegisterFlatList(){} // RVA: 0x6ACB890
        public void GetAttribute(){} // RVA: 0x6ACB990
        public void GetElement(){} // RVA: 0x6ACBE20 | overloaded x2
        public void BuildKey(){} // RVA: 0x6ACC0C0
        public void get_IsOrderDependentMap(){} // RVA: 0x6ACC1A0
        public void get_DefaultAnyElementMember(){} // RVA: 0x37E0E0
        public void get_DefaultAnyAttributeMember(){} // RVA: 0x3A5500
        public void get_NamespaceDeclarations(){} // RVA: 0x37B370
        public void get_AttributeMembers(){} // RVA: 0x6ACC420
        public void get_ElementMembers(){} // RVA: 0x2E07C0
        public void get_AllMembers(){} // RVA: 0x4976A0
        public void get_FlatLists(){} // RVA: 0x6374D0
        public void get_ListMembers(){} // RVA: 0x358730
        public void get_XmlTextCollector(){} // RVA: 0x358D50
        public void get_ReturnMember(){} // RVA: 0x3A5590
        public void get_SimpleContentBaseType(){} // RVA: 0x6ACC7F0
        public void SetCanBeSimpleType(){} // RVA: 0x8A8570
        public void get_HasSimpleContent(){} // RVA: 0x6ACCA20
        public void .ctor(){} // RVA: 0x6ACCAB0
    }

    public class CodeIdentifier
    {
        // ── Methods ──
        public void MakePascal(){} // RVA: 0x6A94A40
        public void MakeValid(){} // RVA: 0x6A94D30
        public void IsValidStart(){} // RVA: 0x6A94F40
        public void IsValid(){} // RVA: 0x6A94FA0
        public void .cctor(){} // RVA: 0x6A95050
    }

    public class EnumMap
    {
        public object ProhibitDefaultUrlResolver;
        public object CollapseWhiteSpaceIntoEmptyString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ACDD50
        public void get_IsFlags(){} // RVA: 0x2F84E0
        public void get_EnumNames(){} // RVA: 0x30B0C0
        public void get_XmlNames(){} // RVA: 0x30B130
        public void get_Values(){} // RVA: 0x6374D0
        public void GetXmlName(){} // RVA: 0x6ACE0D0
        public void GetEnumName(){} // RVA: 0x6ACE450
    }

    public class IXmlSerializable
    {
        // ── Methods ──
        public void GetSchema(){} // RVA: 0xCD60
        public void ReadXml(){} // RVA: 0x24B10
        public void WriteXml(){} // RVA: 0x24B10
    }

    public class IXmlTextParser
    {
        // ── Methods ──
        public void get_Normalized(){} // RVA: 0xDBE0
        public void set_Normalized(){} // RVA: 0x25130
    }

    public class KeyHelper
    {
        // ── Methods ──
        public void AddField(){} // RVA: 0x6A95FB0 | overloaded x6
    }

    public class ListMap
    {
        public object XmlName;
        public object EnumName;

        // ── Methods ──
        public void set_ChoiceMember(){} // RVA: 0x343E80
        public void get_ItemInfo(){} // RVA: 0x2F8380
        public void set_ItemInfo(){} // RVA: 0x2DEE30
        public void FindElement(){} // RVA: 0x6ACD230 | overloaded x2
        public void FindTextElement(){} // RVA: 0x6ACD4A0
        public void GetArrayType(){} // RVA: 0x6ACD670
        public void Equals(){} // RVA: 0x6ACDBB0
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ObjectMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReflectionHelper
    {
        // ── Methods ──
        public void RegisterSchemaType(){} // RVA: 0x6A96090
        public void GetRegisteredSchemaType(){} // RVA: 0x6A96150
        public void RegisterClrType(){} // RVA: 0x6A96250
        public void GetRegisteredClrType(){} // RVA: 0x6A963F0
        public void CheckSerializableType(){} // RVA: 0x6A965B0
        public void .ctor(){} // RVA: 0x6A96960
        public void .cctor(){} // RVA: 0x6A96A90
    }

    public class SerializationSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A96B40
        public void BaseEquals(){} // RVA: 0x6A96C00
    }

    public class TypeData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A97260 | overloaded x2
        public void LookupTypeConvertor(){} // RVA: 0x6A97A60
        public void ConvertForAssignment(){} // RVA: 0x6A97BE0
        public void get_TypeName(){} // RVA: 0x6374D0
        public void get_XmlType(){} // RVA: 0x2E07C0
        public void get_Type(){} // RVA: 0x2F8380
        public void get_FullTypeName(){} // RVA: 0x4976A0
        public void get_SchemaType(){} // RVA: 0x760030
        public void get_IsListType(){} // RVA: 0x6A97D20
        public void get_IsComplexType(){} // RVA: 0x6A97D30
        public void get_IsValueType(){} // RVA: 0x6A97D60
        public void get_IsNullable(){} // RVA: 0x6A97E00
        public void set_IsNullable(){} // RVA: 0x114F200
        public void get_ListItemTypeData(){} // RVA: 0x6A97F10
        public void get_ListItemType(){} // RVA: 0x6A98010
        public void get_IsXsdType(){} // RVA: 0x6A988D0
        public void get_HasPublicConstructor(){} // RVA: 0x306020
        public void GetIndexerProperty(){} // RVA: 0x6A988E0
        public void CreateMissingAddMethodException(){} // RVA: 0x6A98A30
        public void GetGenericListItemType(){} // RVA: 0x6A98BA0
        public void .cctor(){} // RVA: 0x6A98DC0
    }

    public class TypeMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void GetHashCode(){} // RVA: 0x6A99A10
        public void Equals(){} // RVA: 0x6A99BA0 | overloaded x2
        public void ToString(){} // RVA: 0x6A99C70
    }

    public class TypeTranslator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6A99CE0
        public void GetTypeData(){} // RVA: 0x6A9CF30 | overloaded x2
        public void GetPrimitiveTypeData(){} // RVA: 0x6A9DB60 | overloaded x2
        public void FindPrimitiveTypeData(){} // RVA: 0x6A9DDB0
        public void GetArrayName(){} // RVA: 0x6A9DE80
        public void ParseArrayType(){} // RVA: 0x6A9E090
    }

    public class UnreferencedObjectEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A95BA0
    }

    public class UnreferencedObjectEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class XmlAnyAttributeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlAnyElementAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2EE3B40
        public void get_Name(){} // RVA: 0x6A9E350
        public void get_Namespace(){} // RVA: 0x2E07C0
        public void get_Order(){} // RVA: 0x760030
        public void AddKeyHash(){} // RVA: 0x6A9E3B0
    }

    public class XmlAnyElementAttributes
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x6A9E5B0
        public void Add(){} // RVA: 0x6A9E660
        public void AddKeyHash(){} // RVA: 0x6A9E6C0
        public void get_Order(){} // RVA: 0x6A9E880
        public void .ctor(){} // RVA: 0x5BCCCF0
    }

    public class XmlArrayAttribute
    {
        // ── Methods ──
        public void get_ElementName(){} // RVA: 0x6A9EA50
        public void get_Form(){} // RVA: 0x5BED50
        public void get_IsNullable(){} // RVA: 0x2F8390
        public void get_Namespace(){} // RVA: 0x30B0C0
        public void get_Order(){} // RVA: 0x791DC0
        public void AddKeyHash(){} // RVA: 0x6A9EAB0
    }

    public class XmlArrayItemAttribute
    {
        // ── Methods ──
        public void get_DataType(){} // RVA: 0x6A9EE10
        public void get_ElementName(){} // RVA: 0x6A9EE70
        public void get_Form(){} // RVA: 0x760030
        public void get_Namespace(){} // RVA: 0x30B130
        public void get_IsNullable(){} // RVA: 0x303450
        public void get_IsNullableSpecified(){} // RVA: 0x303470
        public void get_Type(){} // RVA: 0x4976A0
        public void get_NestingLevel(){} // RVA: 0x4C6670
        public void AddKeyHash(){} // RVA: 0x6A9EED0
    }

    public class XmlArrayItemAttributes
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x6A9F3F0
        public void Add(){} // RVA: 0x6A9F4A0
        public void AddKeyHash(){} // RVA: 0x6A9F500
        public void .ctor(){} // RVA: 0x5BCCCF0
    }

    public class XmlAttributeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_AttributeName(){} // RVA: 0x6A9F6C0
        public void get_DataType(){} // RVA: 0x6A9F720
        public void set_DataType(){} // RVA: 0x343E80
        public void get_Form(){} // RVA: 0x791DC0
        public void get_Namespace(){} // RVA: 0x6374D0
        public void AddKeyHash(){} // RVA: 0x6A9F780
    }

    public class XmlAttributeEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A95790
    }

    public class XmlAttributeEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class XmlAttributeOverrides
    {
        public object XmlAnyAttribute;
        public object XmlAnyElements;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A9FC00
        public void get_Item(){} // RVA: 0x6A9FD10 | overloaded x2
        public void GetKey(){} // RVA: 0x6A9FEA0
        public void AddKeyHash(){} // RVA: 0x6A9FFA0
    }

    public class XmlAttributes
    {
        public object MemberName;
        public object FromXmlNCName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AA0630 | overloaded x2
        public void get_XmlAnyAttribute(){} // RVA: 0x2F8380
        public void get_XmlAnyElements(){} // RVA: 0x2E07C0
        public void get_XmlArray(){} // RVA: 0x30B0C0
        public void get_XmlArrayItems(){} // RVA: 0x30B130
        public void get_XmlAttribute(){} // RVA: 0x6374D0
        public void get_XmlChoiceIdentifier(){} // RVA: 0x4976A0
        public void get_XmlDefaultValue(){} // RVA: 0x35A740
        public void get_XmlElements(){} // RVA: 0x358730
        public void get_XmlIgnore(){} // RVA: 0x59FF30
        public void get_Xmlns(){} // RVA: 0x4FE4B90
        public void get_XmlRoot(){} // RVA: 0x37B370
        public void get_XmlText(){} // RVA: 0x358D50
        public void get_XmlType(){} // RVA: 0x3A5590
        public void AddKeyHash(){} // RVA: 0x6AA16A0
        public void get_Order(){} // RVA: 0x6AA1BC0
        public void get_SortableOrder(){} // RVA: 0x6AA1CD0
    }

    public class XmlChoiceIdentifierAttribute
    {
        // ── Methods ──
        public void get_MemberName(){} // RVA: 0x6AA1D50
        public void AddKeyHash(){} // RVA: 0x6AA1DB0
    }

    public class XmlCustomFormatter
    {
        // ── Methods ──
        public void FromEnum(){} // RVA: 0x6AA1F00
        public void FromXmlName(){} // RVA: 0x6AA21C0
        public void FromXmlNCName(){} // RVA: 0x6AA2250
        public void ToXmlString(){} // RVA: 0x6AA22E0
        public void FromXmlString(){} // RVA: 0x6AA3540
        public void .cctor(){} // RVA: 0x6AA46A0
    }

    public class XmlElementAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AA4B40 | overloaded x2
        public void get_DataType(){} // RVA: 0x6AA4C00
        public void get_ElementName(){} // RVA: 0x6AA4C60
        public void get_Form(){} // RVA: 0x760030
        public void get_Namespace(){} // RVA: 0x30B130
        public void get_IsNullable(){} // RVA: 0x303450
        public void get_Order(){} // RVA: 0x37E080
        public void get_Type(){} // RVA: 0x4976A0
        public void AddKeyHash(){} // RVA: 0x6AA4CC0
    }

    public class XmlElementAttributes
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x6AA5170
        public void Add(){} // RVA: 0x6AA5220
        public void AddKeyHash(){} // RVA: 0x6AA5280
        public void get_Order(){} // RVA: 0x6AA5440
        public void .ctor(){} // RVA: 0x5BCCCF0
    }

    public class XmlElementEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A95900
    }

    public class XmlElementEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class XmlEnumAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Name(){} // RVA: 0x2F8380
        public void AddKeyHash(){} // RVA: 0x6AA5610
    }

    public class XmlIgnoreAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlIncludeAttribute
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x2F8380
    }

    public class XmlMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A15BE0
        public void get_ElementName(){} // RVA: 0x6374D0
        public void get_Namespace(){} // RVA: 0x4976A0
        public void SetKey(){} // RVA: 0x305200
        public void get_ObjectMap(){} // RVA: 0x2F8380
        public void set_ObjectMap(){} // RVA: 0x2DEE30
        public void get_RelatedMaps(){} // RVA: 0x2E07C0
        public void set_RelatedMaps(){} // RVA: 0x343E80
        public void get_Format(){} // RVA: 0x760030
        public void set_Format(){} // RVA: 0x99E0D0
        public void get_Source(){} // RVA: 0x30B130
    }

    public class XmlMemberMapping
    {
    }

    public class XmlMembersMapping
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x6AA5760
        public void get_HasWrapperElement(){} // RVA: 0x394D30
    }

    public class XmlNamespaceDeclarationsAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlNodeEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A95A70
    }

    public class XmlNodeEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class XmlReflectionImporter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AA5780
        public void ImportTypeMapping(){} // RVA: 0x6AA5E30 | overloaded x4
        public void CreateTypeMapping(){} // RVA: 0x6AA6320
        public void ImportClassMapping(){} // RVA: 0x6AA6930 | overloaded x2
        public void RegisterDerivedMap(){} // RVA: 0x6AA7CF0
        public void GetTypeNamespace(){} // RVA: 0x6AA7E40
        public void ImportListMapping(){} // RVA: 0x6AA8040 | overloaded x2
        public void ImportXmlNodeMapping(){} // RVA: 0x6AA8F90
        public void ImportPrimitiveMapping(){} // RVA: 0x6AA9290
        public void ImportEnumMapping(){} // RVA: 0x6AA9480
        public void ImportXmlSerializableMapping(){} // RVA: 0x6AA9CC0
        public void ImportIncludedTypes(){} // RVA: 0x6AA9EF0
        public void GetReflectionMembers(){} // RVA: 0x6AAA080
        public void CreateMapMember(){} // RVA: 0x6AAAE00
        public void ImportElementInfo(){} // RVA: 0x6AABD20
        public void ImportAnyElementInfo(){} // RVA: 0x6AACE00
        public void ImportTextElementInfo(){} // RVA: 0x6AAD410
        public void CanBeNull(){} // RVA: 0x6AAD8B0
        public void IncludeType(){} // RVA: 0x6AAD900
        public void GetDefaultValue(){} // RVA: 0x6AADDF0
        public void .cctor(){} // RVA: 0x6AADFF0
    }

    public class XmlReflectionMember
    {
        public object DataType;
        public object ElementName;
        public object IsNullable;
        public object Namespace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AAE230
        public void get_IsReturnValue(){} // RVA: 0x3A75E0
        public void get_MemberName(){} // RVA: 0x2E07C0
        public void get_MemberType(){} // RVA: 0x30B0C0
        public void get_XmlAttributes(){} // RVA: 0x6AAE330
        public void get_DeclaringType(){} // RVA: 0x6374D0
        public void set_DeclaringType(){} // RVA: 0x30B890
    }

    public class XmlRootAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E13120 | overloaded x2
        public void get_DataType(){} // RVA: 0x6AAE3E0
        public void set_DataType(){} // RVA: 0x2DEE30
        public void get_ElementName(){} // RVA: 0x6AAE440
        public void set_ElementName(){} // RVA: 0x343E80
        public void get_IsNullable(){} // RVA: 0x3CB9D0
        public void set_IsNullable(){} // RVA: 0x3CB9E0
        public void get_Namespace(){} // RVA: 0x30B130
        public void set_Namespace(){} // RVA: 0x2DEE90
        public void AddKeyHash(){} // RVA: 0x6AAE4A0
    }

    public class XmlSchemaProviderAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_MethodName(){} // RVA: 0x2F8380
        public void get_IsAny(){} // RVA: 0x2F84E0
        public void set_IsAny(){} // RVA: 0x2F84F0
    }

    public class XmlSerializableMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC9C70
    }

    public class XmlSerializationCollectionFixupCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33076C0
        public void Invoke(){} // RVA: 0x439370
    }

    public class XmlSerializationFixupCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class XmlSerializationGeneratedCode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSerializationReadCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B072F0
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class XmlSerializationReader
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6AAE760
        public void EnsureArrayList(){} // RVA: 0x6AAF030
        public void EnsureHashtable(){} // RVA: 0x6AAF090
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Document(){} // RVA: 0x6AAF0F0
        public void get_Reader(){} // RVA: 0x2E07C0
        public void AddFixup(){} // RVA: 0x6AAF430 | overloaded x3
        public void AddReadCallback(){} // RVA: 0x6AAF510
        public void AddTarget(){} // RVA: 0x6AAF7D0
        public void CurrentTag(){} // RVA: 0x6AAF9D0
        public void CreateReadOnlyCollectionException(){} // RVA: 0x6AAFBB0
        public void CreateUnknownConstantException(){} // RVA: 0x6AAFC70
        public void CreateUnknownNodeException(){} // RVA: 0x6AAFD40
        public void CreateUnknownTypeException(){} // RVA: 0x6AAFDD0
        public void EnsureArrayIndex(){} // RVA: 0x6AAFF30
        public void GetNullAttr(){} // RVA: 0x6AB00A0
        public void GetTarget(){} // RVA: 0x6AB0180
        public void TargetReady(){} // RVA: 0x6AB0270
        public void GetXsiType(){} // RVA: 0x6AB02A0
        public void InitCallbacks(){} // RVA: 0x24A50
        public void InitIDs(){} // RVA: 0x24A50
        public void IsXmlnsAttribute(){} // RVA: 0x6AB0580
        public void ParseWsdlArrayType(){} // RVA: 0x6AB0630
        public void ReadElementQualifiedName(){} // RVA: 0x6AB0E70
        public void ReadEndElement(){} // RVA: 0x6AB0F90
        public void ReadNull(){} // RVA: 0x6AB1060
        public void ReadNullableQualifiedName(){} // RVA: 0x6AB1250
        public void ReadNullableString(){} // RVA: 0x6AB1280
        public void ReadReferencedElement(){} // RVA: 0x6AB1490 | overloaded x2
        public void GetCallbackInfo(){} // RVA: 0x6AB1340
        public void ReadList(){} // RVA: 0x6AB1830
        public void ReadReferencedElements(){} // RVA: 0x6AB1EB0
        public void ReadReferencingElement(){} // RVA: 0x6AB2D80 | overloaded x3
        public void ReadSerializable(){} // RVA: 0x6AB3280
        public void ReadTypedPrimitive(){} // RVA: 0x6AB3410 | overloaded x2
        public void ReadXmlNode(){} // RVA: 0x6AB3E70
        public void ReadXmlDocument(){} // RVA: 0x6AB3EE0
        public void ShrinkArray(){} // RVA: 0x6AB4020
        public void ToXmlQualifiedName(){} // RVA: 0x6AB41A0
        public void UnknownAttribute(){} // RVA: 0x6AB4420
        public void UnknownElement(){} // RVA: 0x6AB46A0
        public void UnknownNode(){} // RVA: 0x6AB4990 | overloaded x2
        public void OnUnknownNode(){} // RVA: 0x6AB4A10
        public void UnreferencedObject(){} // RVA: 0x6AB4DC0
    }

    public class XmlSerializationReaderInterpreter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AB51A0
        public void InitCallbacks(){} // RVA: 0x6AB5220
        public void InitIDs(){} // RVA: 0x2DD310
        public void ReadRoot(){} // RVA: 0x6AB5EB0 | overloaded x2
        public void ReadEncodedObject(){} // RVA: 0x6AB5710
        public void ReadMessage(){} // RVA: 0x6AB58E0
        public void ReadObject(){} // RVA: 0x6AB6020
        public void ReadClassInstance(){} // RVA: 0x6AB6260
        public void ReadClassInstanceMembers(){} // RVA: 0x6AB6590
        public void ReadAttributeMembers(){} // RVA: 0x6AB6640
        public void ReadMembers(){} // RVA: 0x6AB6C90
        public void SetListMembersDefaults(){} // RVA: 0x6AB9050
        public void FixupMembers(){} // RVA: 0x6AB91E0
        public void ProcessUnknownAttribute(){} // RVA: 0x6AB4920
        public void ProcessUnknownElement(){} // RVA: 0x6AB4920
        public void IsReadOnly(){} // RVA: 0x6AB9520
        public void SetMemberValue(){} // RVA: 0x6AB96E0
        public void SetMemberValueFromAttr(){} // RVA: 0x6AB9890
        public void GetMemberValue(){} // RVA: 0x6AB9990
        public void ReadObjectElement(){} // RVA: 0x6AB9A70
        public void ReadPrimitiveValue(){} // RVA: 0x6AB9C60
        public void GetValueFromXmlString(){} // RVA: 0x6AB9E00
        public void ReadListElement(){} // RVA: 0x6AB9F30
        public void ReadListString(){} // RVA: 0x6ABA410
        public void AddListValue(){} // RVA: 0x6ABA6D0
        public void CreateInstance(){} // RVA: 0x6ABAAA0 | overloaded x2
        public void CreateList(){} // RVA: 0x6ABAB20
        public void InitializeList(){} // RVA: 0x6ABABD0
        public void FillList(){} // RVA: 0x6ABAC60
        public void CopyEnumerableList(){} // RVA: 0x6ABAC80
        public void ReadXmlNodeElement(){} // RVA: 0x6ABB0E0
        public void ReadXmlNode(){} // RVA: 0x6ABB110
        public void ReadPrimitiveElement(){} // RVA: 0x6ABB320
        public void ReadEnumElement(){} // RVA: 0x6ABB3E0
        public void GetEnumValue(){} // RVA: 0x6ABB460
        public void ReadXmlSerializableElement(){} // RVA: 0x6ABB5F0
        public void .cctor(){} // RVA: 0x6ABB860
    }

    public class XmlSerializationWriteCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class XmlSerializationWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ABBA70
        public void Initialize(){} // RVA: 0x6ABBB20
        public void get_Writer(){} // RVA: 0x30B130
        public void AddWriteCallback(){} // RVA: 0x6ABBD50
        public void CreateUnknownAnyElementException(){} // RVA: 0x6ABBFD0
        public void CreateUnknownTypeException(){} // RVA: 0x6ABC190 | overloaded x2
        public void FromXmlQualifiedName(){} // RVA: 0x6ABC250
        public void GetId(){} // RVA: 0x6ABC390
        public void AlreadyQueued(){} // RVA: 0x6ABC580
        public void GetNamespacePrefix(){} // RVA: 0x6ABC5C0
        public void GetQualifiedName(){} // RVA: 0x6ABC780
        public void InitCallbacks(){} // RVA: 0x24A50
        public void TopLevelElement(){} // RVA: 0x6ABC8E0
        public void WriteAttribute(){} // RVA: 0x6ABC970 | overloaded x2
        public void WriteXmlNode(){} // RVA: 0x6ABCA00
        public void WriteElementEncoded(){} // RVA: 0x6ABCAE0
        public void WriteElementLiteral(){} // RVA: 0x6ABCC20
        public void WriteElementQualifiedName(){} // RVA: 0x6ABCD80 | overloaded x2
        public void WriteElementString(){} // RVA: 0x6ABCF10 | overloaded x2
        public void WriteEndElement(){} // RVA: 0x6ABD0F0 | overloaded x2
        public void WriteNamespaceDeclarations(){} // RVA: 0x6ABD150
        public void WriteNullableQualifiedNameEncoded(){} // RVA: 0x6ABD560
        public void WriteNullableQualifiedNameLiteral(){} // RVA: 0x6ABD640
        public void WriteNullableStringEncoded(){} // RVA: 0x6ABD710
        public void WriteNullableStringLiteral(){} // RVA: 0x6ABD730
        public void WriteNullTagEncoded(){} // RVA: 0x6ABD760
        public void WriteNullTagLiteral(){} // RVA: 0x6ABD890
        public void WritePotentiallyReferencingElement(){} // RVA: 0x6ABD9C0
        public void WriteReferencedElements(){} // RVA: 0x6ABDE60
        public void IsPrimitiveArray(){} // RVA: 0x6ABE120
        public void WriteArray(){} // RVA: 0x6ABE220
        public void WriteReferencingElement(){} // RVA: 0x6ABE660
        public void CheckReferenceQueue(){} // RVA: 0x6ABE7E0
        public void WriteSerializable(){} // RVA: 0x6ABE9A0 | overloaded x2
        public void WriteStartDocument(){} // RVA: 0x6ABEAA0
        public void WriteStartElement(){} // RVA: 0x6ABEBC0 | overloaded x5
        public void WriteTypedPrimitive(){} // RVA: 0x6ABF290
        public void WriteValue(){} // RVA: 0x6ABF600
        public void WriteXmlAttribute(){} // RVA: 0x6ABF640
        public void WriteXsiType(){} // RVA: 0x6ABFB50
    }

    public class XmlSerializationWriterInterpreter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ABFCC0
        public void InitCallbacks(){} // RVA: 0x6ABFDF0
        public void WriteRoot(){} // RVA: 0x6AC01C0
        public void WriteObject(){} // RVA: 0x6AC0490
        public void WriteMessage(){} // RVA: 0x6AC0CE0
        public void WriteObjectElement(){} // RVA: 0x6AC0FC0
        public void WriteObjectElementAttributes(){} // RVA: 0x6AC1110
        public void WriteObjectElementElements(){} // RVA: 0x6AC11C0
        public void WriteMembers(){} // RVA: 0x6AC1270
        public void WriteAttributeMembers(){} // RVA: 0x6AC12D0
        public void WriteElementMembers(){} // RVA: 0x6AC1840
        public void GetMemberValue(){} // RVA: 0x6AC1DF0
        public void MemberHasValue(){} // RVA: 0x6AC1ED0
        public void WriteMemberElement(){} // RVA: 0x6AC21D0
        public void ImplicitConvert(){} // RVA: 0x6AC2860
        public void WritePrimitiveValueLiteral(){} // RVA: 0x6AC2C20
        public void WritePrimitiveValueEncoded(){} // RVA: 0x6AC2F20
        public void WriteListElement(){} // RVA: 0x6AC3240
        public void WriteListContent(){} // RVA: 0x6AC34F0
        public void GetListCount(){} // RVA: 0x6AC3CC0
        public void WriteAnyElementContent(){} // RVA: 0x6AC3E90
        public void WritePrimitiveElement(){} // RVA: 0x6AC44D0
        public void WriteEnumElement(){} // RVA: 0x6AC4520
        public void GetStringValue(){} // RVA: 0x6AC4600
        public void GetEnumXmlValue(){} // RVA: 0x6AC4910
    }

    public class XmlSerializer
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6AC4A80
        public void .ctor(){} // RVA: 0x6AC4BD0
        public void get_Mapping(){} // RVA: 0x2E07C0
        public void OnUnknownAttribute(){} // RVA: 0x6AC4D80
        public void OnUnknownElement(){} // RVA: 0x6AC4DB0
        public void OnUnknownNode(){} // RVA: 0x6AC4DE0
        public void OnUnreferencedObject(){} // RVA: 0x6AC4E10
        public void CreateReader(){} // RVA: 0x6AC5E70 | overloaded x2
        public void CreateWriter(){} // RVA: 0x6AC5950 | overloaded x2
        public void Deserialize(){} // RVA: 0x6AC50F0 | overloaded x3
        public void Serialize(){} // RVA: 0x6AC5670 | overloaded x4
    }

    public class XmlSerializerFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateSerializer(){} // RVA: 0x6AC6060 | overloaded x3
        public void .cctor(){} // RVA: 0x6AC6510
    }

    public class XmlSerializerImplementation
    {
        // ── Methods ──
        public void get_Writer(){} // RVA: 0x6AC65E0
    }

    public class XmlSerializerNamespaces
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Add(){} // RVA: 0x6A95100
        public void AddInternal(){} // RVA: 0x6A951D0
        public void ToArray(){} // RVA: 0x6A95220
        public void get_Count(){} // RVA: 0x6A95330
        public void get_NamespaceList(){} // RVA: 0x6A95370
        public void get_Namespaces(){} // RVA: 0x6A956E0
        public void set_Namespaces(){} // RVA: 0x2DEE30
    }

    public class XmlTextAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_DataType(){} // RVA: 0x6AC6620
        public void get_Type(){} // RVA: 0x2E07C0
        public void AddKeyHash(){} // RVA: 0x6AC6680
    }

    public class XmlTypeAttribute
    {
        // ── Methods ──
        public void get_IncludeInSchema(){} // RVA: 0x3A75E0
        public void get_Namespace(){} // RVA: 0x2E07C0
        public void get_TypeName(){} // RVA: 0x6AC6890
        public void AddKeyHash(){} // RVA: 0x6AC68F0
    }

    public class XmlTypeConvertorAttribute
    {
        // ── Methods ──
        public void get_Method(){} // RVA: 0x2F8380
        public void set_Method(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class XmlTypeMapElementInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC6B10
        public void get_TypeData(){} // RVA: 0x358730
        public void get_ChoiceValue(){} // RVA: 0x6374D0
        public void set_ChoiceValue(){} // RVA: 0x30B890
        public void get_ElementName(){} // RVA: 0x2F8380
        public void set_ElementName(){} // RVA: 0x2DEE30
        public void get_Namespace(){} // RVA: 0x2E07C0
        public void set_Namespace(){} // RVA: 0x343E80
        public void get_DataTypeNamespace(){} // RVA: 0x6AC6CA0
        public void get_DataTypeName(){} // RVA: 0x6AC6D30
        public void get_Form(){} // RVA: 0x760030
        public void set_Form(){} // RVA: 0x99E0D0
        public void get_MappedType(){} // RVA: 0x35A740
        public void set_MappedType(){} // RVA: 0x305200
        public void get_IsNullable(){} // RVA: 0x4A6500
        public void set_IsNullable(){} // RVA: 0x4A78C0
        public void get_Member(){} // RVA: 0x30B130
        public void set_NestingLevel(){} // RVA: 0x1CB95F0
        public void get_MultiReferenceType(){} // RVA: 0x6AC6D60
        public void get_WrappedElement(){} // RVA: 0x3978E0
        public void set_WrappedElement(){} // RVA: 0x3978F0
        public void get_IsTextElement(){} // RVA: 0x6AC6D80
        public void set_IsTextElement(){} // RVA: 0x6AC6E00
        public void get_IsUnnamedAnyElement(){} // RVA: 0x6AC6F60
        public void set_IsUnnamedAnyElement(){} // RVA: 0x6AC6FF0
        public void get_ExplicitOrder(){} // RVA: 0xC5BE80
        public void set_ExplicitOrder(){} // RVA: 0xC5BE70
        public void Equals(){} // RVA: 0x6AC7150
        public void GetHashCode(){} // RVA: 0x5C63910
    }

    public class XmlTypeMapElementInfoList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC7320
    }

    public class XmlTypeMapMember
    {
        public object AttributeName;
        public object Namespace;
        public object Form;
        public object MappedType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC7330
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_DefaultValue(){} // RVA: 0x358730
        public void set_DefaultValue(){} // RVA: 0x358740
        public void IsReadOnly(){} // RVA: 0x6AC73E0
        public void GetValue(){} // RVA: 0x6AC76F0 | overloaded x2
        public void SetValue(){} // RVA: 0x6AC7B00 | overloaded x2
        public void InitMember(){} // RVA: 0x6AC7CC0
        public void get_TypeData(){} // RVA: 0x30B130
        public void set_TypeData(){} // RVA: 0x2DEE90
        public void get_Index(){} // RVA: 0x5BED50
        public void set_Index(){} // RVA: 0x6374E0
        public void get_GlobalIndex(){} // RVA: 0x197C3B0
        public void set_GlobalIndex(){} // RVA: 0x1989FD0
        public void get_IsOptionalValueType(){} // RVA: 0x5CC8960
        public void set_IsOptionalValueType(){} // RVA: 0x6AC8060
        public void get_IsReturnValue(){} // RVA: 0x5CC8930
        public void set_IsReturnValue(){} // RVA: 0x6AC8090
        public void CheckOptionalValueType(){} // RVA: 0x6AC80C0
        public void GetValueSpecified(){} // RVA: 0x6AC81A0
        public void SetValueSpecified(){} // RVA: 0x6AC84F0
    }

    public class XmlTypeMapMemberAnyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC88B0
    }

    public class XmlTypeMapMemberAnyElement
    {
        // ── Methods ──
        public void IsElementDefined(){} // RVA: 0x6AC8EF0
        public void get_IsDefaultAny(){} // RVA: 0x6AC9190
        public void .ctor(){} // RVA: 0x6AC88B0
    }

    public class XmlTypeMapMemberAttribute
    {
        public object ElementInfo;
        public object ChoiceMember;
        public object ChoiceTypeData;
        public object IsXmlTextCollector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC8820
        public void get_AttributeName(){} // RVA: 0x3A5500
        public void set_AttributeName(){} // RVA: 0x3A5510
        public void get_Namespace(){} // RVA: 0x37B370
        public void set_Namespace(){} // RVA: 0x37B380
        public void set_Form(){} // RVA: 0x1C91450
        public void get_MappedType(){} // RVA: 0x3A5590
        public void set_MappedType(){} // RVA: 0x3A55A0
    }

    public class XmlTypeMapMemberElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC88B0
        public void get_ElementInfo(){} // RVA: 0x6AC88C0
        public void set_ElementInfo(){} // RVA: 0x3A5510
        public void get_ChoiceMember(){} // RVA: 0x37B370
        public void set_ChoiceMember(){} // RVA: 0x37B380
        public void get_ChoiceTypeData(){} // RVA: 0x3A5590
        public void set_ChoiceTypeData(){} // RVA: 0x3A55A0
        public void FindElement(){} // RVA: 0x6AC8970
        public void SetChoice(){} // RVA: 0x6AC8ED0
        public void get_IsXmlTextCollector(){} // RVA: 0x3A5570
        public void set_IsXmlTextCollector(){} // RVA: 0x3A5580
    }

    public class XmlTypeMapMemberExpandable
    {
        public object ListMap;

        // ── Methods ──
        public void get_FlatArrayIndex(){} // RVA: 0x1AE3800
        public void set_FlatArrayIndex(){} // RVA: 0x1AE6D80
        public void .ctor(){} // RVA: 0x6AC88B0
    }

    public class XmlTypeMapMemberFlatList
    {
        public object IsDefaultAny;

        // ── Methods ──
        public void get_ListMap(){} // RVA: 0x462D00
        public void set_ListMap(){} // RVA: 0x464450
        public void .ctor(){} // RVA: 0x6AC88B0
    }

    public class XmlTypeMapMemberList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC88B0
    }

    public class XmlTypeMapMemberNamespaces
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC88B0
    }

    public class XmlTypeMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AC9370
        public void get_TypeFullName(){} // RVA: 0x6AC95D0
        public void get_TypeData(){} // RVA: 0x3A5500
        public void get_XmlType(){} // RVA: 0x358730
        public void set_XmlType(){} // RVA: 0x358740
        public void get_XmlTypeNamespace(){} // RVA: 0x6AC95F0
        public void set_XmlTypeNamespace(){} // RVA: 0x4354D0
        public void get_HasXmlTypeNamespace(){} // RVA: 0x51563C0
        public void get_DerivedTypes(){} // RVA: 0x3A5590
        public void get_MultiReferenceType(){} // RVA: 0x3A5570
        public void get_BaseMap(){} // RVA: 0x37B370
        public void set_BaseMap(){} // RVA: 0x37B380
        public void set_IncludeInSchema(){} // RVA: 0x4EC47C0
        public void get_IsNullable(){} // RVA: 0x5AF9770
        public void set_IsNullable(){} // RVA: 0x5AF9780
        public void get_IsAny(){} // RVA: 0x6AC9640
        public void set_IsAny(){} // RVA: 0x6AC9650
        public void GetRealTypeMap(){} // RVA: 0x6AC9660
        public void GetRealElementMap(){} // RVA: 0x6AC97F0
        public void UpdateRoot(){} // RVA: 0x6AC9B20
    }

    public class XmlTypeSerializationSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A96D50
        public void Equals(){} // RVA: 0x6A96FF0
        public void GetHashCode(){} // RVA: 0x5DD8780
    }

}