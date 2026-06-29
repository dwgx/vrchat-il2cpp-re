// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 97
// Methods: 1276

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XdrBuilder : SchemaBuilder
    {
        public object S_XDR_Root_Element;
        public object S_XDR_Root_SubElements;
        public object S_XDR_ElementType_SubElements;
        public object S_XDR_AttributeType_SubElements;
        public object S_XDR_Group_SubElements;
        public object S_XDR_Root_Attributes;
        public object S_XDR_ElementType_Attributes;
        public object S_XDR_AttributeType_Attributes;
        public object S_XDR_Element_Attributes;
        public object S_XDR_Attribute_Attributes;
        public object S_XDR_Group_Attributes;
        public object S_XDR_ElementDataType_Attributes;
        public object S_XDR_AttributeDataType_Attributes;
        public object S_SchemaEntries;
        public object _SchemaInfo;
        public object _TargetNamespace;
        public object _reader;
        public object positionInfo;
        public object _contentValidator;
        public object _CurState;
        public object _NextState;
        public object _StateHistory;
        public object _GroupStack;
        public object _XdrName;
        public object _XdrPrefix;
        public object _ElementDef;
        public object _GroupDef;
        public object _AttributeDef;
        public object _UndefinedAttributeTypes;
        public object _BaseDecl;
        public object _NameTable;
        public object _SchemaNames;
        public object _CurNsMgr;
        public object _Text;
        public object validationEventHandler;
        public object _UndeclaredElements;
        public object xmlResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73F3E20
        public void ProcessElement(){} // RVA: 0x73F4540
        public void ProcessAttribute(){} // RVA: 0x73F48F0
        public void set_XmlResolver(){} // RVA: 0xBAE430
        public void LoadSchema(){} // RVA: 0x73F4F30
        public void IsXdrSchema(){} // RVA: 0x73F5480
        public void IsContentParsed(){} // RVA: 0xC2E4C0
        public void ProcessMarkup(){} // RVA: 0x73F57B0
        public void ProcessCData(){} // RVA: 0x73F5810
        public void StartChildren(){} // RVA: 0x73F58E0
        public void EndChildren(){} // RVA: 0x73F5920
        public void Push(){} // RVA: 0x73F5A60
        public void Pop(){} // RVA: 0x73F5AF0
        public void PushGroupInfo(){} // RVA: 0x73F5C10
        public void PopGroupInfo(){} // RVA: 0x73F5CC0
        public void XDR_InitRoot(){} // RVA: 0x73F5DE0
        public void XDR_BuildRoot_Name(){} // RVA: 0x73F5F40
        public void XDR_BuildRoot_ID(){} // RVA: 0xB43310
        public void XDR_BeginRoot(){} // RVA: 0x73F6060
        public void XDR_EndRoot(){} // RVA: 0x73F6220
        public void XDR_InitElementType(){} // RVA: 0x73F67C0
        public void XDR_BuildElementType_Name(){} // RVA: 0x73F6A80
        public void XDR_BuildElementType_Content(){} // RVA: 0x73F6DA0
        public void XDR_BuildElementType_Model(){} // RVA: 0x73F6E50
        public void XDR_BuildElementType_Order(){} // RVA: 0x73F6FE0
        public void XDR_BuildElementType_DtType(){} // RVA: 0x73F70A0
        public void XDR_BuildElementType_DtValues(){} // RVA: 0x73F7240
        public void XDR_BuildElementType_DtMaxLength(){} // RVA: 0x73F7390
        public void XDR_BuildElementType_DtMinLength(){} // RVA: 0x73F7410
        public void XDR_BeginElementType(){} // RVA: 0x73F7490
        public void XDR_EndElementType(){} // RVA: 0x73F7830
        public void XDR_InitAttributeType(){} // RVA: 0x73F7F90
        public void XDR_BuildAttributeType_Name(){} // RVA: 0x73F8190
        public void XDR_BuildAttributeType_Required(){} // RVA: 0x73F86B0
        public void XDR_BuildAttributeType_Default(){} // RVA: 0x73F8730
        public void XDR_BuildAttributeType_DtType(){} // RVA: 0x73F87A0
        public void XDR_BuildAttributeType_DtValues(){} // RVA: 0x73F8A30
        public void XDR_BuildAttributeType_DtMaxLength(){} // RVA: 0x73F8B80
        public void XDR_BuildAttributeType_DtMinLength(){} // RVA: 0x73F8C00
        public void XDR_BeginAttributeType(){} // RVA: 0x73F8C80
        public void XDR_EndAttributeType(){} // RVA: 0x73F8D20
        public void XDR_InitElement(){} // RVA: 0x73F9130
        public void XDR_BuildElement_Type(){} // RVA: 0x73F91F0
        public void XDR_BuildElement_MinOccurs(){} // RVA: 0x73F93E0
        public void XDR_BuildElement_MaxOccurs(){} // RVA: 0x73F9460
        public void XDR_EndElement(){} // RVA: 0x73F94E0
        public void XDR_InitAttribute(){} // RVA: 0x73F9600
        public void XDR_BuildAttribute_Type(){} // RVA: 0x73F96D0
        public void XDR_BuildAttribute_Required(){} // RVA: 0x73F9880
        public void XDR_BuildAttribute_Default(){} // RVA: 0x73F9910
        public void XDR_BeginAttribute(){} // RVA: 0x73F9980
        public void XDR_EndAttribute(){} // RVA: 0x73FA090
        public void XDR_InitGroup(){} // RVA: 0x73FA0C0
        public void XDR_BuildGroup_Order(){} // RVA: 0x73FA280
        public void XDR_BuildGroup_MinOccurs(){} // RVA: 0x73FA380
        public void XDR_BuildGroup_MaxOccurs(){} // RVA: 0x73FA410
        public void XDR_EndGroup(){} // RVA: 0x73FA4A0
        public void XDR_InitElementDtType(){} // RVA: 0x73FA760
        public void XDR_EndElementDtType(){} // RVA: 0x73FA820
        public void XDR_InitAttributeDtType(){} // RVA: 0x73FA9D0
        public void XDR_EndAttributeDtType(){} // RVA: 0x73FAA50
        public void GetNextState(){} // RVA: 0x73FAB50
        public void IsSkipableElement(){} // RVA: 0x73FAD40
        public void IsSkipableAttribute(){} // RVA: 0x73FAE40
        public void GetOrder(){} // RVA: 0x73FAFB0
        public void AddOrder(){} // RVA: 0x73FB170
        public void IsYes(){} // RVA: 0x73FB230
        public void ParseMinOccurs(){} // RVA: 0x73FB3C0
        public void ParseMaxOccurs(){} // RVA: 0x73FB4C0
        public void HandleMinMax(){} // RVA: 0x73FB620
        public void ParseDtMaxLength(){} // RVA: 0x73FB650
        public void ParseDtMinLength(){} // RVA: 0x73FB7A0
        public void CompareMinMaxLength(){} // RVA: 0x73FB8F0
        public void ParseInteger(){} // RVA: 0x73FB980
        public void XDR_CheckAttributeDefault(){} // RVA: 0x73FB9C0
        public void SetAttributePresence(){} // RVA: 0x73FBAC0
        public void GetContent(){} // RVA: 0x73FBB10
        public void GetModel(){} // RVA: 0x73FBD20
        public void CheckDatatype(){} // RVA: 0x73FBE40
        public void CheckDefaultAttValue(){} // RVA: 0x73FBFE0
        public void IsGlobal(){} // RVA: 0x73FC130
        public void SendValidationEvent(){} // RVA: 0x73FC3C0
        public void .cctor(){} // RVA: 0x73FC4A0
    }

    public class XdrValidator : BaseValidator
    {
        public object validationStack;
        public object attPresence;
        public object name;
        public object nsManager;
        public object isProcessContents;
        public object IDs;
        public object idRefListHead;
        public object inlineSchemaParser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73FEBF0
        public void Init(){} // RVA: 0x73FECF0
        public void Validate(){} // RVA: 0x73FF120
        public void ValidateElement(){} // RVA: 0x73FF200
        public void ValidateChildElement(){} // RVA: 0x73FF740
        public void get_IsInlineSchemaStarted(){} // RVA: 0x73FF900
        public void ProcessInlineSchema(){} // RVA: 0x73FF910
        public void ProcessElement(){} // RVA: 0x73FFC70
        public void ValidateEndElement(){} // RVA: 0x73FFD90
        public void ThoroughGetElementDecl(){} // RVA: 0x7400140
        public void ValidateStartElement(){} // RVA: 0x7400560
        public void ValidateEndStartElement(){} // RVA: 0x7400B80
        public void LoadSchemaFromLocation(){} // RVA: 0x7400F30
        public void LoadSchema(){} // RVA: 0x7401590
        public void get_HasSchema(){} // RVA: 0x7401740
        public void get_PreserveWhitespace(){} // RVA: 0x7401760
        public void ProcessTokenizedType(){} // RVA: 0x74017B0
        public void CompleteValidation(){} // RVA: 0x7401AB0
        public void CheckValue(){} // RVA: 0x7401D20
        public void CheckDefaultValue(){} // RVA: 0x74023D0
        public void AddID(){} // RVA: 0x74028A0
        public void FindId(){} // RVA: 0x74029A0
        public void Push(){} // RVA: 0x74029D0
        public void Pop(){} // RVA: 0x7402CC0
        public void CheckForwardRefs(){} // RVA: 0x7402E00
        public void QualifiedName(){} // RVA: 0x7402FA0
    }

    public class XmlAnyConverter : XmlBaseConverter
    {
        public object Item;
        public object AnyAtomic;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7448820
        public void ToBoolean(){} // RVA: 0x7448A20
        public void ToDateTime(){} // RVA: 0x7448BF0
        public void ToDateTimeOffset(){} // RVA: 0x7448DD0
        public void ToDecimal(){} // RVA: 0x7449010
        public void ToDouble(){} // RVA: 0x7449250
        public void ToInt32(){} // RVA: 0x7449420
        public void ToInt64(){} // RVA: 0x74495F0
        public void ToSingle(){} // RVA: 0x74497C0
        public void ChangeType(){} // RVA: 0x744AB40
        public void ChangeTypeWildcardDestination(){} // RVA: 0x744C940
        public void ChangeTypeWildcardSource(){} // RVA: 0x744CA90
        public void ToNavigator(){} // RVA: 0x744CC00
        public void .cctor(){} // RVA: 0x744CCA0
    }

    public class XmlAnyListConverter : XmlListConverter
    {
        public object ItemList;
        public object AnyAtomicList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x744CE80
        public void ChangeType(){} // RVA: 0x744CE90
        public void .cctor(){} // RVA: 0x744D110
    }

    public class XmlAtomicValue : XPathItem
    {
        public object xmlType;
        public object objVal;
        public object clrType;
        public object unionVal;
        public object nsPrefix;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7403B10
        public void System.ICloneable.Clone(){} // RVA: 0x2303260
        public void get_XmlType(){} // RVA: 0xB5DBF0
        public void get_ValueType(){} // RVA: 0x7403DE0
        public void get_TypedValue(){} // RVA: 0x7403E20
        public void get_ValueAsBoolean(){} // RVA: 0x7404030
        public void get_ValueAsDateTime(){} // RVA: 0x7404140
        public void get_ValueAsDouble(){} // RVA: 0x7404250
        public void get_ValueAsInt(){} // RVA: 0x7404360
        public void get_ValueAsLong(){} // RVA: 0x7404470
        public void ValueAs(){} // RVA: 0x7404580
        public void get_Value(){} // RVA: 0x74047E0
        public void ToString(){} // RVA: 0xBFA230
        public void GetPrefixFromQName(){} // RVA: 0x7404920
    }

    public class XmlBaseConverter : XmlValueConverter
    {
        public object schemaType;
        public object typeCode;
        public object clrTypeDefault;
        public object ICollectionType;
        public object IEnumerableType;
        public object IListType;
        public object ObjectArrayType;
        public object StringArrayType;
        public object XmlAtomicValueArrayType;
        public object DecimalType;
        public object Int32Type;
        public object Int64Type;
        public object StringType;
        public object XmlAtomicValueType;
        public object ObjectType;
        public object ByteType;
        public object Int16Type;
        public object SByteType;
        public object UInt16Type;
        public object UInt32Type;
        public object UInt64Type;
        public object XPathItemType;
        public object DoubleType;
        public object SingleType;
        public object DateTimeType;
        public object DateTimeOffsetType;
        public object BooleanType;
        public object ByteArrayType;
        public object XmlQualifiedNameType;
        public object UriType;
        public object TimeSpanType;
        public object XPathNavigatorType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x742D4D0
        public void ToBoolean(){} // RVA: 0x742DA10
        public void ToDateTime(){} // RVA: 0x742E060
        public void ToDateTimeOffset(){} // RVA: 0x742E320
        public void ToDecimal(){} // RVA: 0x742E4E0
        public void ToDouble(){} // RVA: 0x742EA10
        public void ToInt32(){} // RVA: 0x742EF00
        public void ToInt64(){} // RVA: 0x742F3F0
        public void ToSingle(){} // RVA: 0x742F650
        public void ToString(){} // RVA: 0x742FE80
        public void ChangeType(){} // RVA: 0x7430160
        public void get_SchemaType(){} // RVA: 0xB5DBF0
        public void get_TypeCode(){} // RVA: 0xE62D00
        public void get_XmlTypeName(){} // RVA: 0x7430190
        public void get_DefaultClrType(){} // RVA: 0xB700F0
        public void IsDerivedFrom(){} // RVA: 0x74302A0
        public void CreateInvalidClrMappingException(){} // RVA: 0x7430320
        public void QNameToString(){} // RVA: 0x7432390
        public void ChangeListType(){} // RVA: 0x7430780
        public void StringToBase64Binary(){} // RVA: 0x74307E0
        public void StringToDate(){} // RVA: 0x7430900
        public void StringToDateTime(){} // RVA: 0x7430980
        public void StringToDayTimeDuration(){} // RVA: 0x7430A00
        public void StringToDuration(){} // RVA: 0x7430B00
        public void StringToGDay(){} // RVA: 0x7430C00
        public void StringToGMonth(){} // RVA: 0x7430C80
        public void StringToGMonthDay(){} // RVA: 0x7430D00
        public void StringToGYear(){} // RVA: 0x7430D80
        public void StringToGYearMonth(){} // RVA: 0x7430E00
        public void StringToDateOffset(){} // RVA: 0x7430E80
        public void StringToDateTimeOffset(){} // RVA: 0x7430F20
        public void StringToGDayOffset(){} // RVA: 0x7430FC0
        public void StringToGMonthOffset(){} // RVA: 0x7431060
        public void StringToGMonthDayOffset(){} // RVA: 0x7431100
        public void StringToGYearOffset(){} // RVA: 0x74311A0
        public void StringToGYearMonthOffset(){} // RVA: 0x7431240
        public void StringToHexBinary(){} // RVA: 0x74312E0
        public void StringToQName(){} // RVA: 0x7431410
        public void StringToTime(){} // RVA: 0x74317B0
        public void StringToTimeOffset(){} // RVA: 0x7431830
        public void StringToYearMonthDuration(){} // RVA: 0x74318D0
        public void AnyUriToString(){} // RVA: 0x74319D0
        public void Base64BinaryToString(){} // RVA: 0x7431A40
        public void DateToString(){} // RVA: 0x7431B50
        public void DateTimeToString(){} // RVA: 0x7431BD0
        public void DayTimeDurationToString(){} // RVA: 0x7431C50
        public void DurationToString(){} // RVA: 0x7431CC0
        public void GDayToString(){} // RVA: 0x7431D20
        public void GMonthToString(){} // RVA: 0x7431DA0
        public void GMonthDayToString(){} // RVA: 0x7431E20
        public void GYearToString(){} // RVA: 0x7431EA0
        public void GYearMonthToString(){} // RVA: 0x7431F20
        public void DateOffsetToString(){} // RVA: 0x7431FA0
        public void DateTimeOffsetToString(){} // RVA: 0x7432030
        public void GDayOffsetToString(){} // RVA: 0x74320C0
        public void GMonthOffsetToString(){} // RVA: 0x7432150
        public void GMonthDayOffsetToString(){} // RVA: 0x74321E0
        public void GYearOffsetToString(){} // RVA: 0x7432270
        public void GYearMonthOffsetToString(){} // RVA: 0x7432300
        public void TimeToString(){} // RVA: 0x7432580
        public void TimeOffsetToString(){} // RVA: 0x7432600
        public void YearMonthDurationToString(){} // RVA: 0x7432690
        public void DateTimeOffsetToDateTime(){} // RVA: 0x7432700
        public void DecimalToInt32(){} // RVA: 0x7432750
        public void DecimalToInt64(){} // RVA: 0x74329D0
        public void DecimalToUInt64(){} // RVA: 0x7432C60
        public void Int32ToByte(){} // RVA: 0x7432EE0
        public void Int32ToInt16(){} // RVA: 0x7432FE0
        public void Int32ToSByte(){} // RVA: 0x74330E0
        public void Int32ToUInt16(){} // RVA: 0x74331E0
        public void Int64ToInt32(){} // RVA: 0x74332E0
        public void Int64ToUInt32(){} // RVA: 0x74333E0
        public void UntypedAtomicToDateTime(){} // RVA: 0x74334E0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x7433560
        public void .cctor(){} // RVA: 0x7433600
    }

    public class XmlBooleanConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x743DC50
        public void Create(){} // RVA: 0x743DCB0
        public void ToBoolean(){} // RVA: 0x743DDE0
        public void ToString(){} // RVA: 0x743E150
        public void ChangeType(){} // RVA: 0x743EBB0
    }

    public class XmlDateTimeConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x743B210
        public void Create(){} // RVA: 0x743B270
        public void ToDateTime(){} // RVA: 0x743B6B0
        public void ToDateTimeOffset(){} // RVA: 0x743BD90
        public void ToString(){} // RVA: 0x743C700
        public void ChangeType(){} // RVA: 0x743D2F0
    }

    public class XmlListConverter : XmlBaseConverter
    {
        public object atomicConverter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x744D660
        public void Create(){} // RVA: 0x744D6C0
        public void ChangeType(){} // RVA: 0x744D8A0
        public void ChangeListType(){} // RVA: 0x744D9B0
        public void IsListType(){} // RVA: 0x744E8B0
        public void ToArray(){} // RVA: 0x87C5F0
        public void ToList(){} // RVA: 0x744EA30
        public void StringAsList(){} // RVA: 0x744EFB0
        public void ListAsString(){} // RVA: 0x744F060
        public void CreateInvalidClrMappingException(){} // RVA: 0x744F310
    }

    public class XmlMiscConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x743F330
        public void Create(){} // RVA: 0x743F390
        public void ToString(){} // RVA: 0x743F420
        public void ChangeType(){} // RVA: 0x7440220
        public void ChangeTypeWildcardDestination(){} // RVA: 0x74412B0
        public void ChangeTypeWildcardSource(){} // RVA: 0x7441400
    }

    public class XmlNumeric10Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7434B30
        public void Create(){} // RVA: 0x7434B90
        public void ToDecimal(){} // RVA: 0x7434DA0
        public void ToInt32(){} // RVA: 0x7435420
        public void ToInt64(){} // RVA: 0x74359A0
        public void ToString(){} // RVA: 0x7436120
        public void ChangeType(){} // RVA: 0x7437820
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7438B00
        public void ChangeTypeWildcardSource(){} // RVA: 0x7438EE0
    }

    public class XmlNumeric2Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7439310
        public void Create(){} // RVA: 0x7439370
        public void ToDouble(){} // RVA: 0x74394E0
        public void ToSingle(){} // RVA: 0x7439920
        public void ToString(){} // RVA: 0x7439E00
        public void ChangeType(){} // RVA: 0x743A950
    }

    public class XmlSchema : XmlSchemaObject
    {
        public object attributeFormDefault;
        public object elementFormDefault;
        public object blockDefault;
        public object finalDefault;
        public object targetNs;
        public object version;
        public object includes;
        public object items;
        public object id;
        public object moreAttributes;
        public object isCompiled;
        public object isCompiledBySet;
        public object isPreprocessed;
        public object isRedefined;
        public object errorCount;
        public object attributes;
        public object attributeGroups;
        public object elements;
        public object types;
        public object groups;
        public object notations;
        public object identityConstraints;
        public object globalIdCounter;
        public object importedSchemas;
        public object importedNamespaces;
        public object schemaId;
        public object baseUri;
        public object isChameleon;
        public object ids;
        public object document;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7404C90
        public void Read(){} // RVA: 0x7405110
        public void CompileSchema(){} // RVA: 0x74052B0
        public void CompileSchemaInSet(){} // RVA: 0x7405700
        public void get_AttributeFormDefault(){} // RVA: 0x18A0130
        public void set_AttributeFormDefault(){} // RVA: 0x189D3F0
        public void get_BlockDefault(){} // RVA: 0xBE5850
        public void set_BlockDefault(){} // RVA: 0xBE5860
        public void get_FinalDefault(){} // RVA: 0xBE5870
        public void set_FinalDefault(){} // RVA: 0xBE5880
        public void get_ElementFormDefault(){} // RVA: 0x114DAD0
        public void set_ElementFormDefault(){} // RVA: 0x25671C0
        public void get_TargetNamespace(){} // RVA: 0xBBF8F0
        public void set_TargetNamespace(){} // RVA: 0xBBF900
        public void get_Version(){} // RVA: 0xBE58B0
        public void set_Version(){} // RVA: 0xCA4DF0
        public void get_Includes(){} // RVA: 0xC0FFC0
        public void get_Items(){} // RVA: 0xBE2C60
        public void get_IsCompiledBySet(){} // RVA: 0x1165720
        public void set_IsCompiledBySet(){} // RVA: 0x115DDC0
        public void get_IsPreprocessed(){} // RVA: 0x11662C0
        public void set_IsPreprocessed(){} // RVA: 0x1160510
        public void get_IsRedefined(){} // RVA: 0x1168DB0
        public void set_IsRedefined(){} // RVA: 0x115E5E0
        public void get_Attributes(){} // RVA: 0x74057C0
        public void get_AttributeGroups(){} // RVA: 0x7405880
        public void get_SchemaTypes(){} // RVA: 0x7405940
        public void get_Elements(){} // RVA: 0x7405A00
        public void get_Id(){} // RVA: 0xBBFF90
        public void set_Id(){} // RVA: 0xBBFFA0
        public void get_Groups(){} // RVA: 0x106A050
        public void get_Notations(){} // RVA: 0x12EB090
        public void get_IdentityConstraints(){} // RVA: 0xBAE340
        public void get_BaseUri(){} // RVA: 0xC68EB0
        public void set_BaseUri(){} // RVA: 0xC68EC0
        public void get_SchemaId(){} // RVA: 0x7405AC0
        public void get_IsChameleon(){} // RVA: 0x11629E0
        public void set_IsChameleon(){} // RVA: 0x1AE6E90
        public void get_Ids(){} // RVA: 0xBC5B30
        public void get_Document(){} // RVA: 0x7405B40
        public void get_ErrorCount(){} // RVA: 0x23A4270
        public void set_ErrorCount(){} // RVA: 0x6CB6340
        public void Clone(){} // RVA: 0x7405C00
        public void DeepClone(){} // RVA: 0x7405EA0
        public void get_IdAttribute(){} // RVA: 0xBBFF90
        public void set_IdAttribute(){} // RVA: 0xBBFFA0
        public void SetIsCompiled(){} // RVA: 0x1F749D0
        public void SetUnhandledAttributes(){} // RVA: 0xC10060
        public void AddAnnotation(){} // RVA: 0x7406420
        public void get_ImportedSchemas(){} // RVA: 0x7406480
        public void get_ImportedNamespaces(){} // RVA: 0x7406540
        public void GetExternalSchemasList(){} // RVA: 0x7406600
        public void .cctor(){} // RVA: 0x7406780
    }

    public class XmlSchemaAll : XmlSchemaGroupBase
    {
        public object items;

        // ── Methods ──
        public void get_Items(){} // RVA: 0xCD3320
        public void get_IsEmpty(){} // RVA: 0x74067C0
        public void SetItems(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0x7406820
    }

    public class XmlSchemaAnnotated : XmlSchemaObject
    {
        public object id;
        public object annotation;
        public object moreAttributes;

        // ── Methods ──
        public void get_Id(){} // RVA: 0xD05CA0
        public void set_Id(){} // RVA: 0xD09D70
        public void get_Annotation(){} // RVA: 0xBC1B30
        public void set_Annotation(){} // RVA: 0xB6A8C0
        public void get_UnhandledAttributes(){} // RVA: 0xBBF8F0
        public void set_UnhandledAttributes(){} // RVA: 0xBBF900
        public void get_IdAttribute(){} // RVA: 0xD05CA0
        public void set_IdAttribute(){} // RVA: 0xD09D70
        public void SetUnhandledAttributes(){} // RVA: 0xBBF900
        public void AddAnnotation(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaAnnotation : XmlSchemaObject
    {
        public object id;
        public object items;
        public object moreAttributes;

        // ── Methods ──
        public void get_Id(){} // RVA: 0xD05CA0
        public void set_Id(){} // RVA: 0xD09D70
        public void get_Items(){} // RVA: 0xBC1B30
        public void get_IdAttribute(){} // RVA: 0xD05CA0
        public void set_IdAttribute(){} // RVA: 0xD09D70
        public void SetUnhandledAttributes(){} // RVA: 0xBBF900
        public void .ctor(){} // RVA: 0x7406900
    }

    public class XmlSchemaAny : XmlSchemaParticle
    {
        public object ns;
        public object processContents;
        public object namespaceList;

        // ── Methods ──
        public void get_Namespace(){} // RVA: 0xCD3320
        public void set_Namespace(){} // RVA: 0xCD4740
        public void set_ProcessContents(){} // RVA: 0xD34750
        public void get_NamespaceList(){} // RVA: 0xB813B0
        public void get_ResolvedNamespace(){} // RVA: 0x74069A0
        public void get_ProcessContentsCorrect(){} // RVA: 0x74069F0
        public void get_NameString(){} // RVA: 0x7406A10
        public void BuildNamespaceList(){} // RVA: 0x7406E50
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7406FB0
        public void Allows(){} // RVA: 0x7407120
        public void .ctor(){} // RVA: 0x7407160
    }

    public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
    {
        public object ns;
        public object processContents;
        public object namespaceList;

        // ── Methods ──
        public void set_Namespace(){} // RVA: 0xCA4DF0
        public void get_ProcessContents(){} // RVA: 0x12BB630
        public void set_ProcessContents(){} // RVA: 0x12BB640
        public void get_NamespaceList(){} // RVA: 0xBE2C60
        public void get_ProcessContentsCorrect(){} // RVA: 0x74071B0
        public void BuildNamespaceList(){} // RVA: 0x74071C0
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7407300
        public void Allows(){} // RVA: 0x7407460
        public void IsSubset(){} // RVA: 0x74074A0
        public void Intersection(){} // RVA: 0x74074D0
        public void Union(){} // RVA: 0x7407640
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaAppInfo : XmlSchemaObject
    {
        public object source;
        public object markup;

        // ── Methods ──
        public void set_Source(){} // RVA: 0xD09D70
        public void get_Markup(){} // RVA: 0xBC1B30
        public void set_Markup(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaAttribute : XmlSchemaAnnotated
    {
        public object defaultValue;
        public object fixedValue;
        public object name;
        public object form;
        public object use;
        public object refName;
        public object typeName;
        public object qualifiedName;
        public object type;
        public object attributeType;
        public object attDef;

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0xBE58B0
        public void set_DefaultValue(){} // RVA: 0xCA4DF0
        public void get_FixedValue(){} // RVA: 0xC0FFC0
        public void set_FixedValue(){} // RVA: 0xC0FFD0
        public void get_Form(){} // RVA: 0x2536460
        public void set_Form(){} // RVA: 0x25406E0
        public void get_Name(){} // RVA: 0xBE2C60
        public void set_Name(){} // RVA: 0xBE2C70
        public void get_RefName(){} // RVA: 0xC10050
        public void set_RefName(){} // RVA: 0x74077B0
        public void get_SchemaTypeName(){} // RVA: 0xCD3320
        public void set_SchemaTypeName(){} // RVA: 0x7407890
        public void get_SchemaType(){} // RVA: 0xB813B0
        public void set_SchemaType(){} // RVA: 0xD5CBB0
        public void get_Use(){} // RVA: 0x25406F0
        public void set_Use(){} // RVA: 0x2540700
        public void get_QualifiedName(){} // RVA: 0xCD48B0
        public void get_AttributeSchemaType(){} // RVA: 0x1069350
        public void get_Datatype(){} // RVA: 0x7407970
        public void SetQualifiedName(){} // RVA: 0xCD3600
        public void SetAttributeType(){} // RVA: 0xD5CC10
        public void get_AttDef(){} // RVA: 0x106A7D0
        public void set_AttDef(){} // RVA: 0xD5CC70
        public void get_NameAttribute(){} // RVA: 0xBE2C60
        public void set_NameAttribute(){} // RVA: 0xBE2C70
        public void Clone(){} // RVA: 0x7407990
        public void .ctor(){} // RVA: 0x7407B70
    }

    public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
    {
        public object name;
        public object attributes;
        public object anyAttribute;
        public object qname;
        public object redefined;
        public object attributeUses;
        public object attributeWildcard;
        public object selfReferenceCount;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xBE58B0
        public void set_Name(){} // RVA: 0xCA4DF0
        public void get_Attributes(){} // RVA: 0xC0FFC0
        public void get_AnyAttribute(){} // RVA: 0xBE2C60
        public void set_AnyAttribute(){} // RVA: 0xBE2C70
        public void get_QualifiedName(){} // RVA: 0xBBFF90
        public void get_AttributeUses(){} // RVA: 0x7407CF0
        public void get_AttributeWildcard(){} // RVA: 0xCD48B0
        public void set_AttributeWildcard(){} // RVA: 0xCD3600
        public void get_RedefinedAttributeGroup(){} // RVA: 0xC10050
        public void get_Redefined(){} // RVA: 0xC10050
        public void set_Redefined(){} // RVA: 0xC10060
        public void get_SelfReferenceCount(){} // RVA: 0x14780B0
        public void set_SelfReferenceCount(){} // RVA: 0x147EE80
        public void get_NameAttribute(){} // RVA: 0xBE58B0
        public void set_NameAttribute(){} // RVA: 0xCA4DF0
        public void SetQualifiedName(){} // RVA: 0xBBFFA0
        public void Clone(){} // RVA: 0x7407DA0
        public void .ctor(){} // RVA: 0x7407F50
    }

    public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
    {
        public object refName;

        // ── Methods ──
        public void get_RefName(){} // RVA: 0xBE58B0
        public void set_RefName(){} // RVA: 0x7408090
        public void .ctor(){} // RVA: 0x7408170
    }

    public class XmlSchemaChoice : XmlSchemaGroupBase
    {
        public object items;

        // ── Methods ──
        public void get_Items(){} // RVA: 0xCD3320
        public void get_IsEmpty(){} // RVA: 0x7408220
        public void SetItems(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0x7408230
    }

    public class XmlSchemaCollection : Object
    {
        public object collection;
        public object nameTable;
        public object schemaNames;
        public object wLock;
        public object timeout;
        public object isThreadSafe;
        public object validationEventHandler;
        public object xmlResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7408310
        public void get_Count(){} // RVA: 0x7408590
        public void get_NameTable(){} // RVA: 0xB465B0
        public void set_XmlResolver(){} // RVA: 0xB6A8C0
        public void get_Item(){} // RVA: 0x74085C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7408670
        public void GetEnumerator(){} // RVA: 0x7408740
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7408810
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xC2E4C0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7408590
        public void GetSchemaInfo(){} // RVA: 0x74089B0
        public void GetSchemaNames(){} // RVA: 0x7408A60
        public void Add(){} // RVA: 0x7408DE0
        public void get_EventHandler(){} // RVA: 0xD05CA0
        public void set_EventHandler(){} // RVA: 0xD09D70
    }

    public class XmlSchemaCollectionEnumerator : Object
    {
        public object enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7408F20
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7408FA0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7408FF0
        public void MoveNext(){} // RVA: 0x7409040
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7409090
        public void get_Current(){} // RVA: 0x74090A0
        public void get_CurrentNode(){} // RVA: 0x7409130
    }

    public class XmlSchemaCollectionNode : Object
    {
        public object namespaceUri;
        public object schemaInfo;
        public object schema;

        // ── Methods ──
        public void set_NamespaceURI(){} // RVA: 0xB44D60
        public void get_SchemaInfo(){} // RVA: 0xB465B0
        public void set_SchemaInfo(){} // RVA: 0xBA9BA0
        public void get_Schema(){} // RVA: 0xB700F0
        public void set_Schema(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaCompilationSettings : Object
    {
        public object enableUpaCheck;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF482F0
        public void get_EnableUpaCheck(){} // RVA: 0xC120A0
    }

    public class XmlSchemaComplexContent : XmlSchemaContentModel
    {
        public object content;
        public object isMixed;
        public object hasMixedAttribute;

        // ── Methods ──
        public void get_IsMixed(){} // RVA: 0xE3F480
        public void set_IsMixed(){} // RVA: 0x74091C0
        public void get_Content(){} // RVA: 0xBE58B0
        public void set_Content(){} // RVA: 0xCA4DF0
        public void get_HasMixedAttribute(){} // RVA: 0x5C8BB10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaComplexContentExtension : XmlSchemaContent
    {
        public object particle;
        public object attributes;
        public object anyAttribute;
        public object baseTypeName;

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0xBBFF90
        public void set_BaseTypeName(){} // RVA: 0x74091D0
        public void get_Particle(){} // RVA: 0xBE58B0
        public void set_Particle(){} // RVA: 0xCA4DF0
        public void get_Attributes(){} // RVA: 0xC0FFC0
        public void get_AnyAttribute(){} // RVA: 0xBE2C60
        public void set_AnyAttribute(){} // RVA: 0xBE2C70
        public void SetAttributes(){} // RVA: 0xC0FFD0
        public void .ctor(){} // RVA: 0x74092B0
    }

    public class XmlSchemaComplexContentRestriction : XmlSchemaContent
    {
        public object particle;
        public object attributes;
        public object anyAttribute;
        public object baseTypeName;

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0xBBFF90
        public void set_BaseTypeName(){} // RVA: 0x74093F0
        public void get_Particle(){} // RVA: 0xBE58B0
        public void set_Particle(){} // RVA: 0xCA4DF0
        public void get_Attributes(){} // RVA: 0xC0FFC0
        public void get_AnyAttribute(){} // RVA: 0xBE2C60
        public void set_AnyAttribute(){} // RVA: 0xBE2C70
        public void SetAttributes(){} // RVA: 0xC0FFD0
        public void .ctor(){} // RVA: 0x74094D0
    }

    public class XmlSchemaComplexType : XmlSchemaType
    {
        public object block;
        public object contentModel;
        public object particle;
        public object attributes;
        public object anyAttribute;
        public object contentTypeParticle;
        public object blockResolved;
        public object localElements;
        public object attributeUses;
        public object attributeWildcard;
        public object anyTypeLax;
        public object anyTypeSkip;
        public object untypedAnyType;
        public object pvFlags;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7409610
        public void CreateAnyType(){} // RVA: 0x7409BE0
        public void .ctor(){} // RVA: 0x740A230
        public void get_AnyType(){} // RVA: 0x740A2F0
        public void get_UntypedAnyType(){} // RVA: 0x740A350
        public void get_AnyTypeContentValidator(){} // RVA: 0x740A3B0
        public void get_IsAbstract(){} // RVA: 0x740A430
        public void set_IsAbstract(){} // RVA: 0x740A440
        public void get_Block(){} // RVA: 0x262A930
        public void set_Block(){} // RVA: 0x262A900
        public void get_IsMixed(){} // RVA: 0x740A470
        public void set_IsMixed(){} // RVA: 0x740A480
        public void get_ContentModel(){} // RVA: 0x106A050
        public void set_ContentModel(){} // RVA: 0xD5CCD0
        public void get_Particle(){} // RVA: 0x12EB090
        public void set_Particle(){} // RVA: 0x13B1040
        public void get_Attributes(){} // RVA: 0x740A4B0
        public void get_AnyAttribute(){} // RVA: 0xBAE3B0
        public void set_AnyAttribute(){} // RVA: 0xBAE3C0
        public void get_ContentType(){} // RVA: 0xF3A950
        public void get_ContentTypeParticle(){} // RVA: 0xBAE420
        public void get_BlockResolved(){} // RVA: 0x12CE7D0
        public void get_AttributeUses(){} // RVA: 0x740A570
        public void get_AttributeWildcard(){} // RVA: 0xBC5B30
        public void get_LocalElements(){} // RVA: 0x740A630
        public void SetContentTypeParticle(){} // RVA: 0xBAE430
        public void SetBlockResolved(){} // RVA: 0x421A240
        public void SetAttributeWildcard(){} // RVA: 0xBC5B40
        public void set_HasWildCard(){} // RVA: 0x740A6F0
        public void SetAttributes(){} // RVA: 0xBAE350
        public void ContainsIdAttribute(){} // RVA: 0x740A720
        public void Clone(){} // RVA: 0x740A9A0
        public void ClearCompiledState(){} // RVA: 0x740B4F0
        public void CloneAttributes(){} // RVA: 0x740B6B0
        public void CloneGroupBaseParticles(){} // RVA: 0x740B980
        public void CloneParticle(){} // RVA: 0x740BAE0
        public void GetResolvedElementForm(){} // RVA: 0x740C040
        public void HasParticleRef(){} // RVA: 0x740C070
        public void HasAttributeQNameRef(){} // RVA: 0x740C3D0
    }

    public class XmlSchemaContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaContentModel : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0x87C0A0
        public void set_Content(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaDatatype : Object
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x87C0A0
        public void get_TokenizedType(){} // RVA: 0x87C130
        public void ParseValue(){} // RVA: 0x88E660
        public void get_Variety(){} // RVA: 0xDAC980
        public void get_TypeCode(){} // RVA: 0xDAC980
        public void IsDerivedFrom(){} // RVA: 0xB43320
        public void get_HasLexicalFacets(){} // RVA: 0x87D280
        public void get_HasValueFacets(){} // RVA: 0x87D280
        public void get_ValueConverter(){} // RVA: 0x87C0A0
        public void get_Restriction(){} // RVA: 0x87C0A0
        public void Compare(){} // RVA: 0x881CA0
        public void TryParseValue(){} // RVA: 0x88D2C0
        public void get_FacetsChecker(){} // RVA: 0x87C0A0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x87C130
        public void DeriveByRestriction(){} // RVA: 0x882090
        public void DeriveByList(){} // RVA: 0x87C540
        public void VerifySchemaValid(){} // RVA: 0x8943B0
        public void IsEqual(){} // RVA: 0x87D3C0
        public void IsComparable(){} // RVA: 0x87D350
        public void get_TypeCodeString(){} // RVA: 0x740C570
        public void TypeCodeToString(){} // RVA: 0x740C6E0
        public void ConcatenatedToString(){} // RVA: 0x740CD60
        public void FromXmlTokenizedType(){} // RVA: 0x740D360
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x740D410
        public void FromXdrName(){} // RVA: 0x740D4C0
        public void DeriveByUnion(){} // RVA: 0x740D680
        public void XdrCanonizeUri(){} // RVA: 0x740D6E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaDocumentation : XmlSchemaObject
    {
        public object source;
        public object language;
        public object markup;
        public object languageType;

        // ── Methods ──
        public void set_Source(){} // RVA: 0xD09D70
        public void set_Language(){} // RVA: 0x740DA70
        public void set_Markup(){} // RVA: 0xBBF900
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x740DBB0
    }

    public class XmlSchemaElement : XmlSchemaParticle
    {
        public object isAbstract;
        public object hasAbstractAttribute;
        public object isNillable;
        public object hasNillableAttribute;
        public object isLocalTypeDerivationChecked;
        public object block;
        public object final;
        public object form;
        public object defaultValue;
        public object fixedValue;
        public object name;
        public object refName;
        public object substitutionGroup;
        public object typeName;
        public object type;
        public object qualifiedName;
        public object elementType;
        public object blockResolved;
        public object finalResolved;
        public object constraints;
        public object elementDecl;

        // ── Methods ──
        public void get_IsAbstract(){} // RVA: 0x1165710
        public void set_IsAbstract(){} // RVA: 0x740DDC0
        public void get_Block(){} // RVA: 0xD34760
        public void set_Block(){} // RVA: 0xD34750
        public void get_DefaultValue(){} // RVA: 0x1069350
        public void set_DefaultValue(){} // RVA: 0xD5CC10
        public void get_Final(){} // RVA: 0xD34730
        public void set_Final(){} // RVA: 0xD34790
        public void get_FixedValue(){} // RVA: 0x106A7D0
        public void set_FixedValue(){} // RVA: 0xD5CC70
        public void get_Form(){} // RVA: 0x14780B0
        public void set_Form(){} // RVA: 0x147EE80
        public void get_Name(){} // RVA: 0x106A050
        public void set_Name(){} // RVA: 0xD5CCD0
        public void get_IsNillable(){} // RVA: 0x11662C0
        public void set_IsNillable(){} // RVA: 0x740DDD0
        public void get_HasNillableAttribute(){} // RVA: 0x1168DB0
        public void get_HasAbstractAttribute(){} // RVA: 0x1165720
        public void get_RefName(){} // RVA: 0x12EB090
        public void set_RefName(){} // RVA: 0x740DDE0
        public void get_SubstitutionGroup(){} // RVA: 0xBAE340
        public void set_SubstitutionGroup(){} // RVA: 0x740DED0
        public void get_SchemaTypeName(){} // RVA: 0xBAE3B0
        public void set_SchemaTypeName(){} // RVA: 0x740DFC0
        public void get_SchemaType(){} // RVA: 0xBAE420
        public void set_SchemaType(){} // RVA: 0xBAE430
        public void get_Constraints(){} // RVA: 0x740E0B0
        public void get_QualifiedName(){} // RVA: 0xCA4D80
        public void get_ElementSchemaType(){} // RVA: 0xC68EB0
        public void get_BlockResolved(){} // RVA: 0x2540E90
        public void get_FinalResolved(){} // RVA: 0x1162FE0
        public void SetQualifiedName(){} // RVA: 0xCA4D90
        public void SetElementType(){} // RVA: 0xC68EC0
        public void SetBlockResolved(){} // RVA: 0x2540EA0
        public void SetFinalResolved(){} // RVA: 0x740E170
        public void get_HasConstraints(){} // RVA: 0x740E180
        public void get_IsLocalTypeDerivationChecked(){} // RVA: 0x1163160
        public void set_IsLocalTypeDerivationChecked(){} // RVA: 0x1164780
        public void get_ElementDecl(){} // RVA: 0xBC5BA0
        public void set_ElementDecl(){} // RVA: 0xBC5BB0
        public void get_NameAttribute(){} // RVA: 0x106A050
        public void set_NameAttribute(){} // RVA: 0xD5CCD0
        public void get_NameString(){} // RVA: 0x740E1D0
        public void Clone(){} // RVA: 0x740E210
        public void .ctor(){} // RVA: 0x740E680
    }

    public class XmlSchemaEnumerationFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74101D0
    }

    public class XmlSchemaException : SystemException
    {
        public object res;
        public object args;
        public object sourceUri;
        public object lineNumber;
        public object linePosition;
        public object sourceSchemaObject;
        public object message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x740FD30
        public void GetObjectData(){} // RVA: 0x740EFD0
        public void CreateMessage(){} // RVA: 0x740FF10
        public void get_GetRes(){} // RVA: 0x1069350
        public void get_Args(){} // RVA: 0x106A7D0
        public void get_SourceUri(){} // RVA: 0x106A050
        public void get_LineNumber(){} // RVA: 0x158C700
        public void get_LinePosition(){} // RVA: 0x68504E0
        public void get_SourceSchemaObject(){} // RVA: 0xBAE340
        public void SetSource(){} // RVA: 0x740FFD0
        public void SetSchemaObject(){} // RVA: 0xBAE350
        public void get_Message(){} // RVA: 0x74100C0
    }

    public class XmlSchemaExternal : XmlSchemaObject
    {
        public object location;
        public object baseUri;
        public object schema;
        public object id;
        public object moreAttributes;
        public object compositor;

        // ── Methods ──
        public void get_SchemaLocation(){} // RVA: 0xD05CA0
        public void set_SchemaLocation(){} // RVA: 0xD09D70
        public void get_Schema(){} // RVA: 0xBBF8F0
        public void set_Schema(){} // RVA: 0xBBF900
        public void get_Id(){} // RVA: 0xBE58B0
        public void set_Id(){} // RVA: 0xCA4DF0
        public void get_BaseUri(){} // RVA: 0xBC1B30
        public void set_BaseUri(){} // RVA: 0xB6A8C0
        public void get_IdAttribute(){} // RVA: 0xBE58B0
        public void set_IdAttribute(){} // RVA: 0xCA4DF0
        public void SetUnhandledAttributes(){} // RVA: 0xC0FFD0
        public void get_Compositor(){} // RVA: 0xD347A0
        public void set_Compositor(){} // RVA: 0xD34740
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaFacet : XmlSchemaAnnotated
    {
        public object value;
        public object isFixed;
        public object facetType;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xBE58B0
        public void set_Value(){} // RVA: 0xCA4DF0
        public void get_IsFixed(){} // RVA: 0xE3F480
        public void set_IsFixed(){} // RVA: 0x74100E0
        public void get_FacetType(){} // RVA: 0xE36310
        public void set_FacetType(){} // RVA: 0x12BB610
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410230
    }

    public class XmlSchemaGroup : XmlSchemaAnnotated
    {
        public object name;
        public object particle;
        public object canonicalParticle;
        public object qname;
        public object redefined;
        public object selfReferenceCount;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xBE58B0
        public void set_Name(){} // RVA: 0xCA4DF0
        public void get_Particle(){} // RVA: 0xC0FFC0
        public void set_Particle(){} // RVA: 0xC0FFD0
        public void get_QualifiedName(){} // RVA: 0xBBFF90
        public void get_CanonicalParticle(){} // RVA: 0xBE2C60
        public void set_CanonicalParticle(){} // RVA: 0xBE2C70
        public void get_Redefined(){} // RVA: 0xC10050
        public void set_Redefined(){} // RVA: 0xC10060
        public void get_SelfReferenceCount(){} // RVA: 0x23ADD10
        public void set_SelfReferenceCount(){} // RVA: 0x23B2A80
        public void get_NameAttribute(){} // RVA: 0xBE58B0
        public void set_NameAttribute(){} // RVA: 0xCA4DF0
        public void SetQualifiedName(){} // RVA: 0xBBFFA0
        public void Clone(){} // RVA: 0x7410260
        public void .ctor(){} // RVA: 0x74104E0
    }

    public class XmlSchemaGroupBase : XmlSchemaParticle
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x87C0A0
        public void SetItems(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x7410590
    }

    public class XmlSchemaGroupRef : XmlSchemaParticle
    {
        public object refName;
        public object particle;
        public object refined;

        // ── Methods ──
        public void get_RefName(){} // RVA: 0xCD3320
        public void set_RefName(){} // RVA: 0x74105E0
        public void get_Particle(){} // RVA: 0xCD48B0
        public void SetParticle(){} // RVA: 0xCD3600
        public void get_Redefined(){} // RVA: 0xB813B0
        public void set_Redefined(){} // RVA: 0xD5CBB0
        public void .ctor(){} // RVA: 0x74106C0
    }

    public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
    {
        public object name;
        public object selector;
        public object fields;
        public object qualifiedName;
        public object compiledConstraint;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xBE58B0
        public void set_Name(){} // RVA: 0xCA4DF0
        public void get_Selector(){} // RVA: 0xC0FFC0
        public void set_Selector(){} // RVA: 0xC0FFD0
        public void get_Fields(){} // RVA: 0xBE2C60
        public void get_QualifiedName(){} // RVA: 0xBBFF90
        public void SetQualifiedName(){} // RVA: 0xBBFFA0
        public void get_CompiledConstraint(){} // RVA: 0xC10050
        public void set_CompiledConstraint(){} // RVA: 0xC10060
        public void get_NameAttribute(){} // RVA: 0xBE58B0
        public void set_NameAttribute(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x74107A0
    }

    public class XmlSchemaImport : XmlSchemaExternal
    {
        public object ns;
        public object annotation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410A80
        public void get_Namespace(){} // RVA: 0xBBFF90
        public void set_Namespace(){} // RVA: 0xBBFFA0
        public void AddAnnotation(){} // RVA: 0xC10060
    }

    public class XmlSchemaInclude : XmlSchemaExternal
    {
        public object annotation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410A90
        public void AddAnnotation(){} // RVA: 0xBBFFA0
    }

    public class XmlSchemaInference : Object
    {
        public object ST_boolean;
        public object ST_byte;
        public object ST_unsignedByte;
        public object ST_short;
        public object ST_unsignedShort;
        public object ST_int;
        public object ST_unsignedInt;
        public object ST_long;
        public object ST_unsignedLong;
        public object ST_integer;
        public object ST_decimal;
        public object ST_float;
        public object ST_double;
        public object ST_duration;
        public object ST_dateTime;
        public object ST_time;
        public object ST_date;
        public object ST_gYearMonth;
        public object ST_string;
        public object ST_anySimpleType;
        public object SimpleTypes;
        public object rootSchema;
        public object schemaSet;
        public object xtr;
        public object nametable;
        public object TargetNamespace;
        public object NamespaceManager;
        public object schemaList;
        public object occurrence;
        public object typeInference;

        // ── Methods ──
        public void set_Occurrence(){} // RVA: 0xBE58A0
        public void get_Occurrence(){} // RVA: 0xBE5890
        public void set_TypeInference(){} // RVA: 0x262A680
        public void .ctor(){} // RVA: 0x7393DB0
        public void InferSchema(){} // RVA: 0x7393FF0
        public void InferSchema1(){} // RVA: 0x7394080
        public void AddAttribute(){} // RVA: 0x7394AA0
        public void CreateXmlSchema(){} // RVA: 0x73956E0
        public void AddElement(){} // RVA: 0x73957C0
        public void InferElement(){} // RVA: 0x7396380
        public void CheckSimpleContentExtension(){} // RVA: 0x7397C90
        public void GetEffectiveSchemaType(){} // RVA: 0x7397E10
        public void FindMatchingElement(){} // RVA: 0x7398040
        public void ProcessAttributes(){} // RVA: 0x7399640
        public void MoveAttributes(){} // RVA: 0x739A320
        public void FindAttribute(){} // RVA: 0x739A6B0
        public void FindGlobalElement(){} // RVA: 0x739A900
        public void FindElement(){} // RVA: 0x739AB60
        public void FindAttributeRef(){} // RVA: 0x739AD00
        public void FindElementRef(){} // RVA: 0x739AFC0
        public void MakeExistingAttributesOptional(){} // RVA: 0x739B1C0
        public void SwitchUseToOptional(){} // RVA: 0x739B290
        public void RefineSimpleType(){} // RVA: 0x739B3E0
        public void InferSimpleType(){} // RVA: 0x739C210
        public void DateTime(){} // RVA: 0x739D3B0
        public void CreateNewElementforChoice(){} // RVA: 0x739D500
        public void GetSchemaType(){} // RVA: 0x739DCB0
        public void SetMinMaxOccurs(){} // RVA: 0x739E8A0
        public void .cctor(){} // RVA: 0x739EAD0
    }

    public class XmlSchemaInferenceException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A08C0
        public void GetObjectData(){} // RVA: 0x73A07C0
    }

    public class XmlSchemaInfo : Object
    {
        public object isDefault;
        public object isNil;
        public object schemaElement;
        public object schemaAttribute;
        public object schemaType;
        public object memberType;
        public object validity;
        public object contentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410AB0
        public void get_Validity(){} // RVA: 0x18A0130
        public void set_Validity(){} // RVA: 0x189D3F0
        public void get_IsDefault(){} // RVA: 0xC120A0
        public void set_IsDefault(){} // RVA: 0xC120B0
        public void get_IsNil(){} // RVA: 0xDD5C50
        public void set_IsNil(){} // RVA: 0xDD7A00
        public void get_MemberType(){} // RVA: 0xD33E60
        public void set_MemberType(){} // RVA: 0xB708C0
        public void get_SchemaType(){} // RVA: 0xB70160
        public void set_SchemaType(){} // RVA: 0x7410AE0
        public void get_SchemaElement(){} // RVA: 0xB465B0
        public void set_SchemaElement(){} // RVA: 0x7410B70
        public void get_SchemaAttribute(){} // RVA: 0xB700F0
        public void set_SchemaAttribute(){} // RVA: 0x7410C30
        public void get_ContentType(){} // RVA: 0x114DAD0
        public void get_XmlType(){} // RVA: 0x7410CF0
        public void get_HasDefaultValue(){} // RVA: 0x7410D10
        public void get_IsUnionType(){} // RVA: 0x7410D50
        public void Clear(){} // RVA: 0x7410D90
    }

    public class XmlSchemaKey : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74108E0
    }

    public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
    {
        public object refer;

        // ── Methods ──
        public void get_Refer(){} // RVA: 0xCD3320
        public void set_Refer(){} // RVA: 0x74108F0
        public void .ctor(){} // RVA: 0x74109D0
    }

    public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410190
    }

    public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410200
    }

    public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410210
    }

    public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74101B0
    }

    public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74101E0
    }

    public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74101F0
    }

    public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74101A0
    }

    public class XmlSchemaNotation : XmlSchemaAnnotated
    {
        public object name;
        public object publicId;
        public object systemId;
        public object qname;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xBE58B0
        public void set_Name(){} // RVA: 0xCA4DF0
        public void get_Public(){} // RVA: 0xC0FFC0
        public void set_Public(){} // RVA: 0xC0FFD0
        public void get_System(){} // RVA: 0xBE2C60
        public void set_System(){} // RVA: 0xBE2C70
        public void get_QualifiedName(){} // RVA: 0xBBFF90
        public void set_QualifiedName(){} // RVA: 0xBBFFA0
        public void get_NameAttribute(){} // RVA: 0xBE58B0
        public void set_NameAttribute(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x7410F00
    }

    public class XmlSchemaNumericFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaObject : Object
    {
        public object lineNum;
        public object linePos;
        public object sourceUri;
        public object namespaces;
        public object parent;
        public object isProcessing;

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0xB8F8F0
        public void set_LineNumber(){} // RVA: 0xB460A0
        public void get_LinePosition(){} // RVA: 0x116A650
        public void set_LinePosition(){} // RVA: 0x116BB10
        public void get_SourceUri(){} // RVA: 0xB465B0
        public void set_SourceUri(){} // RVA: 0xBA9BA0
        public void get_Parent(){} // RVA: 0xB70160
        public void set_Parent(){} // RVA: 0xB44DC0
        public void get_Namespaces(){} // RVA: 0x7410FB0
        public void set_Namespaces(){} // RVA: 0xB70100
        public void OnAdd(){} // RVA: 0xB43310
        public void OnRemove(){} // RVA: 0xB43310
        public void OnClear(){} // RVA: 0xB43310
        public void get_IdAttribute(){} // RVA: 0xDAC980
        public void set_IdAttribute(){} // RVA: 0xB43310
        public void SetUnhandledAttributes(){} // RVA: 0xB43310
        public void AddAnnotation(){} // RVA: 0xB43310
        public void get_NameAttribute(){} // RVA: 0xDAC980
        public void set_NameAttribute(){} // RVA: 0xB43310
        public void get_IsProcessing(){} // RVA: 0xB68DF0
        public void set_IsProcessing(){} // RVA: 0xB68E00
        public void Clone(){} // RVA: 0x7411050
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaObjectCollection : CollectionBase
    {
        public object parent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66456C0
        public void get_Item(){} // RVA: 0x74110D0
        public void set_Item(){} // RVA: 0x7411180
        public void GetEnumerator(){} // RVA: 0x74111F0
        public void Add(){} // RVA: 0x7411560
        public void Insert(){} // RVA: 0x7411300
        public void Remove(){} // RVA: 0x7411370
        public void OnInsert(){} // RVA: 0x74113D0
        public void OnSet(){} // RVA: 0x7411400
        public void OnClear(){} // RVA: 0x7411470
        public void OnRemove(){} // RVA: 0x74114A0
        public void Clone(){} // RVA: 0x74114D0
    }

    public class XmlSchemaObjectEnumerator : Object
    {
        public object enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void MoveNext(){} // RVA: 0x7411590
        public void get_Current(){} // RVA: 0x74115E0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7411680
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x74116D0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7411720
    }

    public class XmlSchemaObjectTable : Object
    {
        public object table;
        public object entries;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7411770
        public void Add(){} // RVA: 0x74118D0
        public void Insert(){} // RVA: 0x7411A50
        public void Replace(){} // RVA: 0x7411BB0
        public void Clear(){} // RVA: 0x7411CF0
        public void Remove(){} // RVA: 0x7411D80
        public void FindIndexByValue(){} // RVA: 0x7411E50
        public void get_Count(){} // RVA: 0x7411F00
        public void Contains(){} // RVA: 0x7411F50
        public void get_Item(){} // RVA: 0x7411FD0
        public void get_Values(){} // RVA: 0x7412050
        public void GetEnumerator(){} // RVA: 0x7412120
    }

    public class XmlSchemaParticle : XmlSchemaAnnotated
    {
        public object minOccurs;
        public object maxOccurs;
        public object flags;
        public object Empty;

        // ── Methods ──
        public void get_MinOccursString(){} // RVA: 0x7412ED0
        public void set_MinOccursString(){} // RVA: 0x7413010
        public void get_MaxOccursString(){} // RVA: 0x7413220
        public void set_MaxOccursString(){} // RVA: 0x7413420
        public void get_MinOccurs(){} // RVA: 0x4CBDC80
        public void set_MinOccurs(){} // RVA: 0x7413730
        public void get_MaxOccurs(){} // RVA: 0x4127D80
        public void set_MaxOccurs(){} // RVA: 0x74139A0
        public void get_IsEmpty(){} // RVA: 0x7413CB0
        public void get_NameString(){} // RVA: 0x1584680
        public void GetQualifiedName(){} // RVA: 0x7413D70
        public void .ctor(){} // RVA: 0x7413FD0
        public void .cctor(){} // RVA: 0x7414050
    }

    public class XmlSchemaPatternFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74101C0
    }

    public class XmlSchemaRedefine : XmlSchemaExternal
    {
        public object items;
        public object attributeGroups;
        public object types;
        public object groups;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74141A0
        public void get_Items(){} // RVA: 0xBBFF90
        public void get_AttributeGroups(){} // RVA: 0xC10050
        public void get_SchemaTypes(){} // RVA: 0xCD3320
        public void get_Groups(){} // RVA: 0xCD48B0
        public void AddAnnotation(){} // RVA: 0x74143C0
    }

    public class XmlSchemaSequence : XmlSchemaGroupBase
    {
        public object items;

        // ── Methods ──
        public void get_Items(){} // RVA: 0xCD3320
        public void get_IsEmpty(){} // RVA: 0x74067C0
        public void SetItems(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0x7414420
    }

    public class XmlSchemaSet : Object
    {
        public object nameTable;
        public object schemaNames;
        public object schemas;
        public object internalEventHandler;
        public object eventHandler;
        public object isCompiled;
        public object schemaLocations;
        public object chameleonSchemas;
        public object targetNamespaces;
        public object compileAll;
        public object cachedCompiledInfo;
        public object readerSettings;
        public object schemaForSchema;
        public object compilationSettings;
        public object elements;
        public object attributes;
        public object schemaTypes;
        public object substitutionGroups;
        public object typeExtensions;
        public object internalSyncObject;

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7414500
        public void .ctor(){} // RVA: 0x7414610
        public void add_ValidationEventHandler(){} // RVA: 0x7414C00
        public void remove_ValidationEventHandler(){} // RVA: 0x7414E20
        public void get_IsCompiled(){} // RVA: 0xD16660
        public void set_XmlResolver(){} // RVA: 0x7414F80
        public void get_CompilationSettings(){} // RVA: 0xCD3320
        public void set_CompilationSettings(){} // RVA: 0xCD4740
        public void get_Count(){} // RVA: 0x7414FA0
        public void get_GlobalElements(){} // RVA: 0x7414FD0
        public void get_GlobalAttributes(){} // RVA: 0x7415090
        public void get_GlobalTypes(){} // RVA: 0x7415150
        public void get_SubstitutionGroups(){} // RVA: 0x7415210
        public void get_SchemaLocations(){} // RVA: 0xBC1B30
        public void get_TypeExtensions(){} // RVA: 0x74152D0
        public void Add(){} // RVA: 0x7417EE0
        public void RemoveRecursive(){} // RVA: 0x7415DE0
        public void Contains(){} // RVA: 0x7416700
        public void Compile(){} // RVA: 0x7416750
        public void Reprocess(){} // RVA: 0x74172D0
        public void CopyTo(){} // RVA: 0x7417B90
        public void Schemas(){} // RVA: 0x7417CC0
        public void FindSchemaByNSAndUrl(){} // RVA: 0x7418610
        public void AddSchemaToSet(){} // RVA: 0x7418970
        public void ProcessNewSubstitutionGroups(){} // RVA: 0x7418E10
        public void ResolveSubstitutionGroup(){} // RVA: 0x7419190
        public void Remove(){} // RVA: 0x74195D0
        public void ClearTables(){} // RVA: 0x7419960
        public void PreprocessSchema(){} // RVA: 0x7419AA0
        public void ParseSchema(){} // RVA: 0x7419D50
        public void CopyFromCompiledSet(){} // RVA: 0x7419F00
        public void get_CompiledInfo(){} // RVA: 0xBE2C60
        public void get_ReaderSettings(){} // RVA: 0xBBFF90
        public void GetResolver(){} // RVA: 0x741B250
        public void GetEventHandler(){} // RVA: 0xD33E60
        public void GetSchemaNames(){} // RVA: 0x741B270
        public void IsSchemaLoaded(){} // RVA: 0x741B370
        public void GetSchemaByUri(){} // RVA: 0x741BFF0
        public void GetTargetNamespace(){} // RVA: 0x741C250
        public void get_SortedSchemas(){} // RVA: 0xB700F0
        public void RemoveSchemaFromCaches(){} // RVA: 0x741C290
        public void RemoveSchemaFromGlobalTables(){} // RVA: 0x741C750
        public void AddToTable(){} // RVA: 0x741D120
        public void VerifyTables(){} // RVA: 0x741D480
        public void InternalValidationCallback(){} // RVA: 0x741D6C0
        public void SendValidationEvent(){} // RVA: 0x741D710
    }

    public class XmlSchemaSimpleContent : XmlSchemaContentModel
    {
        public object content;

        // ── Methods ──
        public void get_Content(){} // RVA: 0xBE58B0
        public void set_Content(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaSimpleContentExtension : XmlSchemaContent
    {
        public object attributes;
        public object anyAttribute;
        public object baseTypeName;

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0xBE2C60
        public void set_BaseTypeName(){} // RVA: 0x741D7E0
        public void get_Attributes(){} // RVA: 0xBE58B0
        public void get_AnyAttribute(){} // RVA: 0xC0FFC0
        public void set_AnyAttribute(){} // RVA: 0xC0FFD0
        public void SetAttributes(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x741D8C0
    }

    public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
    {
        public object baseTypeName;
        public object baseType;
        public object facets;
        public object attributes;
        public object anyAttribute;

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0xBE58B0
        public void set_BaseTypeName(){} // RVA: 0x741DA00
        public void get_BaseType(){} // RVA: 0xC0FFC0
        public void set_BaseType(){} // RVA: 0xC0FFD0
        public void get_Facets(){} // RVA: 0xBE2C60
        public void get_Attributes(){} // RVA: 0xBBFF90
        public void get_AnyAttribute(){} // RVA: 0xC10050
        public void set_AnyAttribute(){} // RVA: 0xC10060
        public void SetAttributes(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0x741DAE0
    }

    public class XmlSchemaSimpleType : XmlSchemaType
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x741DCA0
        public void get_Content(){} // RVA: 0x106A7D0
        public void set_Content(){} // RVA: 0xD5CC70
        public void Clone(){} // RVA: 0x741DCB0
    }

    public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
    {
        public object itemTypeName;
        public object itemType;
        public object baseItemType;

        // ── Methods ──
        public void get_ItemTypeName(){} // RVA: 0xBE58B0
        public void set_ItemTypeName(){} // RVA: 0x741DE20
        public void get_ItemType(){} // RVA: 0xC0FFC0
        public void set_ItemType(){} // RVA: 0xC0FFD0
        public void get_BaseItemType(){} // RVA: 0xBE2C60
        public void set_BaseItemType(){} // RVA: 0xBE2C70
        public void Clone(){} // RVA: 0x741DF00
        public void .ctor(){} // RVA: 0x741E060
    }

    public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
    {
        public object baseTypeName;
        public object baseType;
        public object facets;

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0xBE58B0
        public void set_BaseTypeName(){} // RVA: 0x741E110
        public void get_BaseType(){} // RVA: 0xC0FFC0
        public void set_BaseType(){} // RVA: 0xC0FFD0
        public void get_Facets(){} // RVA: 0xBE2C60
        public void Clone(){} // RVA: 0x741E1F0
        public void .ctor(){} // RVA: 0x741E350
    }

    public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
    {
        public object baseTypes;
        public object memberTypes;
        public object baseMemberTypes;

        // ── Methods ──
        public void get_BaseTypes(){} // RVA: 0xBE58B0
        public void get_MemberTypes(){} // RVA: 0xC0FFC0
        public void set_MemberTypes(){} // RVA: 0xC0FFD0
        public void get_BaseMemberTypes(){} // RVA: 0xBE2C60
        public void SetBaseMemberTypes(){} // RVA: 0xBE2C70
        public void Clone(){} // RVA: 0x741E4A0
        public void .ctor(){} // RVA: 0x741E780
    }

    public class XmlSchemaSubstitutionGroup : XmlSchemaObject
    {
        public object membersList;
        public object examplar;

        // ── Methods ──
        public void get_Members(){} // RVA: 0xD05CA0
        public void get_Examplar(){} // RVA: 0xBC1B30
        public void set_Examplar(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0x741E820
    }

    public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
    {
        public object choice;

        // ── Methods ──
        public void get_Choice(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0x741E960
    }

    public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410220
    }

    public class XmlSchemaType : XmlSchemaAnnotated
    {
        public object name;
        public object final;
        public object derivedBy;
        public object baseSchemaType;
        public object datatype;
        public object finalResolved;
        public object elementDecl;
        public object qname;
        public object redefined;
        public object contentType;

        // ── Methods ──
        public void GetBuiltInSimpleType(){} // RVA: 0x741EAE0
        public void GetBuiltInComplexType(){} // RVA: 0x741EB30
        public void get_Name(){} // RVA: 0xBE58B0
        public void set_Name(){} // RVA: 0xCA4DF0
        public void get_Final(){} // RVA: 0x12BB630
        public void set_Final(){} // RVA: 0x12BB640
        public void get_QualifiedName(){} // RVA: 0x741ECB0
        public void get_FinalResolved(){} // RVA: 0x19C6270
        public void get_BaseXmlSchemaType(){} // RVA: 0xBE2C60
        public void get_DerivedBy(){} // RVA: 0xE36310
        public void get_Datatype(){} // RVA: 0xBBFF90
        public void get_IsMixed(){} // RVA: 0xB43320
        public void set_IsMixed(){} // RVA: 0xB43310
        public void get_TypeCode(){} // RVA: 0x741ECC0
        public void get_ValueConverter(){} // RVA: 0x741ED80
        public void get_SchemaContentType(){} // RVA: 0xF3A950
        public void SetQualifiedName(){} // RVA: 0x741EE00
        public void SetFinalResolved(){} // RVA: 0xCE5450
        public void SetBaseSchemaType(){} // RVA: 0xBE2C70
        public void SetDerivedBy(){} // RVA: 0x12BB610
        public void SetDatatype(){} // RVA: 0xBBFFA0
        public void get_ElementDecl(){} // RVA: 0x741EE60
        public void set_ElementDecl(){} // RVA: 0x741EE70
        public void get_Redefined(){} // RVA: 0xB813B0
        public void set_Redefined(){} // RVA: 0xD5CBB0
        public void SetContentType(){} // RVA: 0x17AFA20
        public void IsDerivedFrom(){} // RVA: 0x741EED0
        public void IsDerivedFromDatatype(){} // RVA: 0x741F060
        public void get_NameAttribute(){} // RVA: 0xBE58B0
        public void set_NameAttribute(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x741F140
    }

    public class XmlSchemaUnique : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74108E0
    }

    public class XmlSchemaValidationException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x741F2D0
        public void GetObjectData(){} // RVA: 0x73A07C0
    }

    public class XmlSchemaValidator : Object
    {
        public object schemaSet;
        public object validationFlags;
        public object startIDConstraint;
        public object isRoot;
        public object rootHasSchema;
        public object attrValid;
        public object checkEntity;
        public object compiledSchemaInfo;
        public object dtdSchemaInfo;
        public object validatedNamespaces;
        public object validationStack;
        public object context;
        public object currentState;
        public object attPresence;
        public object wildID;
        public object IDs;
        public object idRefListHead;
        public object contextQName;
        public object NsXs;
        public object NsXsi;
        public object NsXmlNs;
        public object NsXml;
        public object partialValidationType;
        public object textValue;
        public object eventHandler;
        public object validationEventSender;
        public object nameTable;
        public object positionInfo;
        public object dummyPositionInfo;
        public object xmlResolver;
        public object sourceUri;
        public object sourceUriString;
        public object nsResolver;
        public object processContents;
        public object xsiTypeString;
        public object xsiNilString;
        public object xsiSchemaLocationString;
        public object xsiNoNamespaceSchemaLocationString;
        public object dtQName;
        public object dtCDATA;
        public object dtStringArray;
        public object EmptyParticleArray;
        public object EmptyAttributeArray;
        public object xmlCharType;
        public object ValidStates;
        public object MethodNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x741F3E0
        public void Init(){} // RVA: 0x741F730
        public void Reset(){} // RVA: 0x7420050
        public void set_XmlResolver(){} // RVA: 0xBC5AD0
        public void set_LineInfoProvider(){} // RVA: 0x7420170
        public void set_SourceUri(){} // RVA: 0x7420240
        public void set_ValidationEventSender(){} // RVA: 0xBAE3C0
        public void add_ValidationEventHandler(){} // RVA: 0x7420330
        public void remove_ValidationEventHandler(){} // RVA: 0x7420430
        public void AddSchema(){} // RVA: 0x7420530
        public void Initialize(){} // RVA: 0x7420AB0
        public void ValidateElement(){} // RVA: 0x7420DD0
        public void ValidateAttribute(){} // RVA: 0x7421420
        public void ValidateEndOfAttributes(){} // RVA: 0x7421EE0
        public void ValidateText(){} // RVA: 0x7422030
        public void ValidateWhitespace(){} // RVA: 0x7422500
        public void ValidateEndElement(){} // RVA: 0x7422780
        public void SkipToEndElement(){} // RVA: 0x7422790
        public void EndValidation(){} // RVA: 0x7422A10
        public void GetUnspecifiedDefaultAttributes(){} // RVA: 0x7422C90
        public void get_SchemaSet(){} // RVA: 0xB5DBF0
        public void get_ValidationFlags(){} // RVA: 0xE62D00
        public void get_CurrentContentType(){} // RVA: 0x74233B0
        public void SetDtdSchemaInfo(){} // RVA: 0x74233F0
        public void get_StrictlyAssessed(){} // RVA: 0x7423450
        public void get_HasSchema(){} // RVA: 0x7423490
        public void GetConcatenatedValue(){} // RVA: 0x74234E0
        public void InternalValidateEndElement(){} // RVA: 0x7423510
        public void ProcessSchemaLocations(){} // RVA: 0x7423BB0
        public void ValidateElementContext(){} // RVA: 0x7423EF0
        public void GetSubstitutionGroupHead(){} // RVA: 0x74244D0
        public void ValidateAtomicValue(){} // RVA: 0x7424B00
        public void GetTypeName(){} // RVA: 0x7424F80
        public void SaveTextValue(){} // RVA: 0x7424FF0
        public void Push(){} // RVA: 0x7425040
        public void Pop(){} // RVA: 0x7425450
        public void FastGetElementDecl(){} // RVA: 0x7425650
        public void CheckXsiTypeAndNil(){} // RVA: 0x74259A0
        public void ThrowDeclNotFoundWarningOrError(){} // RVA: 0x7426150
        public void CheckElementProperties(){} // RVA: 0x74263B0
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x74264B0
        public void CheckIsXmlAttribute(){} // RVA: 0x7426510
        public void AddXmlNamespaceSchema(){} // RVA: 0x74266A0
        public void CheckMixedValueConstraint(){} // RVA: 0x7426790
        public void LoadSchema(){} // RVA: 0x74268D0
        public void RecompileSchemaSet(){} // RVA: 0x7426D20
        public void ProcessTokenizedType(){} // RVA: 0x7426DE0
        public void CheckAttributeValue(){} // RVA: 0x74270C0
        public void CheckElementValue(){} // RVA: 0x7427380
        public void CheckTokenizedTypes(){} // RVA: 0x74276C0
        public void FindId(){} // RVA: 0x7427850
        public void CheckForwardRefs(){} // RVA: 0x7427880
        public void get_HasIdentityConstraints(){} // RVA: 0x7427A10
        public void get_ProcessIdentityConstraints(){} // RVA: 0x64D9E30
        public void get_ReportValidationWarnings(){} // RVA: 0x64D9870
        public void get_ProcessSchemaHints(){} // RVA: 0x7427A30
        public void CheckStateTransition(){} // RVA: 0x7427A50
        public void ClearPSVI(){} // RVA: 0x7427CF0
        public void CheckRequiredAttributes(){} // RVA: 0x7427D90
        public void GetSchemaElement(){} // RVA: 0x7428070
        public void GetDefaultAttributePrefix(){} // RVA: 0x7428280
        public void AddIdentityConstraints(){} // RVA: 0x7428540
        public void ElementIdentityConstraints(){} // RVA: 0x7428BA0
        public void AttributeIdentityConstraints(){} // RVA: 0x7428F50
        public void EndElementIdentityConstraints(){} // RVA: 0x74292B0
        public void ElementValidationError(){} // RVA: 0x7429EB0
        public void CompleteValidationError(){} // RVA: 0x742A6C0
        public void PrintExpectedElements(){} // RVA: 0x742AC10
        public void PrintNames(){} // RVA: 0x742B200
        public void PrintNamesWithNS(){} // RVA: 0x742B3A0
        public void EnumerateAny(){} // RVA: 0x742B9F0
        public void QNameString(){} // RVA: 0x742BC90
        public void BuildElementName(){} // RVA: 0x742BD70
        public void ProcessEntity(){} // RVA: 0x742BEE0
        public void SendValidationEvent(){} // RVA: 0x742C960
        public void .cctor(){} // RVA: 0x742CA20
    }

    public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7410240
    }

    public class XmlSchemaXPath : XmlSchemaAnnotated
    {
        public object xpath;

        // ── Methods ──
        public void get_XPath(){} // RVA: 0xBE58B0
        public void set_XPath(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlStringConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7441570
        public void Create(){} // RVA: 0x74415D0
        public void ToString(){} // RVA: 0x7441660
        public void ChangeType(){} // RVA: 0x7441B20
    }

    public class XmlUnionConverter : XmlBaseConverter
    {
        public object converters;
        public object hasAtomicMember;
        public object hasListMember;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x744F5E0
        public void Create(){} // RVA: 0x744F980
        public void ChangeType(){} // RVA: 0x744F9E0
    }

    public class XmlUntypedConverter : XmlListConverter
    {
        public object allowListToList;
        public object Untyped;
        public object UntypedList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7442080
        public void ToBoolean(){} // RVA: 0x7442310
        public void ToDateTime(){} // RVA: 0x7442580
        public void ToDateTimeOffset(){} // RVA: 0x7442860
        public void ToDecimal(){} // RVA: 0x7442B60
        public void ToDouble(){} // RVA: 0x7442E50
        public void ToInt32(){} // RVA: 0x74430D0
        public void ToInt64(){} // RVA: 0x7443360
        public void ToSingle(){} // RVA: 0x74435E0
        public void ToString(){} // RVA: 0x7443BE0
        public void ChangeType(){} // RVA: 0x7446370
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7447B20
        public void ChangeTypeWildcardSource(){} // RVA: 0x7447C70
        public void ChangeListType(){} // RVA: 0x7447DE0
        public void SupportsType(){} // RVA: 0x7448120
        public void .cctor(){} // RVA: 0x7448690
    }

    public class XmlValueConverter : Object
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0x87D350
        public void ToInt32(){} // RVA: 0x87D050
        public void ToInt64(){} // RVA: 0x87C540
        public void ToDecimal(){} // RVA: 0x87BF80
        public void ToDouble(){} // RVA: 0x882470
        public void ToSingle(){} // RVA: 0x891020
        public void ToDateTime(){} // RVA: 0x87C540
        public void ToDateTimeOffset(){} // RVA: 0x87BF80
        public void ToString(){} // RVA: 0x87C5F0
        public void ChangeType(){} // RVA: 0x882090
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlValueGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23F1BA0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class XsdBuilder : SchemaBuilder
    {
        public object SchemaElement;
        public object SchemaSubelements;
        public object AttributeSubelements;
        public object ElementSubelements;
        public object ComplexTypeSubelements;
        public object SimpleContentSubelements;
        public object SimpleContentExtensionSubelements;
        public object SimpleContentRestrictionSubelements;
        public object ComplexContentSubelements;
        public object ComplexContentExtensionSubelements;
        public object ComplexContentRestrictionSubelements;
        public object SimpleTypeSubelements;
        public object SimpleTypeRestrictionSubelements;
        public object SimpleTypeListSubelements;
        public object SimpleTypeUnionSubelements;
        public object RedefineSubelements;
        public object AttributeGroupSubelements;
        public object GroupSubelements;
        public object AllSubelements;
        public object ChoiceSequenceSubelements;
        public object IdentityConstraintSubelements;
        public object AnnotationSubelements;
        public object AnnotatedSubelements;
        public object SchemaAttributes;
        public object AttributeAttributes;
        public object ElementAttributes;
        public object ComplexTypeAttributes;
        public object SimpleContentAttributes;
        public object SimpleContentExtensionAttributes;
        public object SimpleContentRestrictionAttributes;
        public object ComplexContentAttributes;
        public object ComplexContentExtensionAttributes;
        public object ComplexContentRestrictionAttributes;
        public object SimpleTypeAttributes;
        public object SimpleTypeRestrictionAttributes;
        public object SimpleTypeUnionAttributes;
        public object SimpleTypeListAttributes;
        public object AttributeGroupAttributes;
        public object AttributeGroupRefAttributes;
        public object GroupAttributes;
        public object GroupRefAttributes;
        public object ParticleAttributes;
        public object AnyAttributes;
        public object IdentityConstraintAttributes;
        public object SelectorAttributes;
        public object FieldAttributes;
        public object NotationAttributes;
        public object IncludeAttributes;
        public object ImportAttributes;
        public object FacetAttributes;
        public object AnyAttributeAttributes;
        public object DocumentationAttributes;
        public object AppinfoAttributes;
        public object RedefineAttributes;
        public object AnnotationAttributes;
        public object SchemaEntries;
        public object DerivationMethodValues;
        public object DerivationMethodStrings;
        public object FormStringValues;
        public object UseStringValues;
        public object ProcessContentsStringValues;
        public object reader;
        public object positionInfo;
        public object currentEntry;
        public object nextEntry;
        public object hasChild;
        public object stateHistory;
        public object containerStack;
        public object nameTable;
        public object schemaNames;
        public object namespaceManager;
        public object canIncludeImport;
        public object schema;
        public object xso;
        public object element;
        public object anyElement;
        public object attribute;
        public object anyAttribute;
        public object complexType;
        public object simpleType;
        public object complexContent;
        public object complexContentExtension;
        public object complexContentRestriction;
        public object simpleContent;
        public object simpleContentExtension;
        public object simpleContentRestriction;
        public object simpleTypeUnion;
        public object simpleTypeList;
        public object simpleTypeRestriction;
        public object group;
        public object groupRef;
        public object all;
        public object choice;
        public object sequence;
        public object particle;
        public object attributeGroup;
        public object attributeGroupRef;
        public object notation;
        public object identityConstraint;
        public object xpath;
        public object include;
        public object import;
        public object annotation;
        public object appInfo;
        public object documentation;
        public object facet;
        public object markup;
        public object redefine;
        public object validationEventHandler;
        public object unhandledAttributes;
        public object namespaces;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x744FE60
        public void ProcessElement(){} // RVA: 0x74504C0
        public void ProcessAttribute(){} // RVA: 0x7450860
        public void IsContentParsed(){} // RVA: 0x7450F70
        public void ProcessMarkup(){} // RVA: 0x165AF80
        public void ProcessCData(){} // RVA: 0x7450F90
        public void StartChildren(){} // RVA: 0x7450FE0
        public void EndChildren(){} // RVA: 0x7451230
        public void Push(){} // RVA: 0x74513C0
        public void Pop(){} // RVA: 0x74516F0
        public void get_CurrentElement(){} // RVA: 0x66B3840
        public void get_ParentElement(){} // RVA: 0x7451850
        public void get_ParentContainer(){} // RVA: 0x74518E0
        public void GetContainer(){} // RVA: 0x7451980
        public void SetContainer(){} // RVA: 0x7451BD0
        public void BuildAnnotated_Id(){} // RVA: 0x7453350
        public void BuildSchema_AttributeFormDefault(){} // RVA: 0x7453380
        public void BuildSchema_ElementFormDefault(){} // RVA: 0x7453440
        public void BuildSchema_TargetNamespace(){} // RVA: 0x7453500
        public void BuildSchema_Version(){} // RVA: 0x7453570
        public void BuildSchema_FinalDefault(){} // RVA: 0x74535E0
        public void BuildSchema_BlockDefault(){} // RVA: 0x7453660
        public void InitSchema(){} // RVA: 0x74536E0
        public void InitInclude(){} // RVA: 0x7453750
        public void BuildInclude_SchemaLocation(){} // RVA: 0x74538E0
        public void InitImport(){} // RVA: 0x7453950
        public void BuildImport_Namespace(){} // RVA: 0x7453AE0
        public void BuildImport_SchemaLocation(){} // RVA: 0x7453B50
        public void InitRedefine(){} // RVA: 0x7453BC0
        public void BuildRedefine_SchemaLocation(){} // RVA: 0x7453D50
        public void EndRedefine(){} // RVA: 0x7453DC0
        public void InitAttribute(){} // RVA: 0x7453DE0
        public void BuildAttribute_Default(){} // RVA: 0x7453F80
        public void BuildAttribute_Fixed(){} // RVA: 0x7453FF0
        public void BuildAttribute_Form(){} // RVA: 0x7454060
        public void BuildAttribute_Use(){} // RVA: 0x7454120
        public void BuildAttribute_Ref(){} // RVA: 0x74541E0
        public void BuildAttribute_Name(){} // RVA: 0x7454320
        public void BuildAttribute_Type(){} // RVA: 0x7454390
        public void InitElement(){} // RVA: 0x74544D0
        public void BuildElement_Abstract(){} // RVA: 0x74546D0
        public void BuildElement_Block(){} // RVA: 0x7454750
        public void BuildElement_Default(){} // RVA: 0x74547D0
        public void BuildElement_Form(){} // RVA: 0x7454840
        public void BuildElement_SubstitutionGroup(){} // RVA: 0x7454900
        public void BuildElement_Final(){} // RVA: 0x7454A40
        public void BuildElement_Fixed(){} // RVA: 0x7454AC0
        public void BuildElement_MaxOccurs(){} // RVA: 0x7454B30
        public void BuildElement_MinOccurs(){} // RVA: 0x7454B60
        public void BuildElement_Name(){} // RVA: 0x7454B90
        public void BuildElement_Nillable(){} // RVA: 0x7454C00
        public void BuildElement_Ref(){} // RVA: 0x7454C80
        public void BuildElement_Type(){} // RVA: 0x7454DC0
        public void InitSimpleType(){} // RVA: 0x7454F00
        public void BuildSimpleType_Name(){} // RVA: 0x74554A0
        public void BuildSimpleType_Final(){} // RVA: 0x7455510
        public void InitSimpleTypeUnion(){} // RVA: 0x7455590
        public void BuildSimpleTypeUnion_MemberTypes(){} // RVA: 0x74557F0
        public void InitSimpleTypeList(){} // RVA: 0x74559F0
        public void BuildSimpleTypeList_ItemType(){} // RVA: 0x7455BB0
        public void InitSimpleTypeRestriction(){} // RVA: 0x7455CF0
        public void BuildSimpleTypeRestriction_Base(){} // RVA: 0x7455EB0
        public void InitComplexType(){} // RVA: 0x7455FF0
        public void BuildComplexType_Abstract(){} // RVA: 0x7456280
        public void BuildComplexType_Block(){} // RVA: 0x7456310
        public void BuildComplexType_Final(){} // RVA: 0x7456390
        public void BuildComplexType_Mixed(){} // RVA: 0x7456410
        public void BuildComplexType_Name(){} // RVA: 0x74564A0
        public void InitComplexContent(){} // RVA: 0x7456510
        public void BuildComplexContent_Mixed(){} // RVA: 0x7456730
        public void InitComplexContentExtension(){} // RVA: 0x74567B0
        public void BuildComplexContentExtension_Base(){} // RVA: 0x7456A70
        public void InitComplexContentRestriction(){} // RVA: 0x7456BB0
        public void BuildComplexContentRestriction_Base(){} // RVA: 0x7456E10
        public void InitSimpleContent(){} // RVA: 0x7456F50
        public void InitSimpleContentExtension(){} // RVA: 0x7457170
        public void BuildSimpleContentExtension_Base(){} // RVA: 0x7457310
        public void InitSimpleContentRestriction(){} // RVA: 0x7457450
        public void BuildSimpleContentRestriction_Base(){} // RVA: 0x7457790
        public void InitAttributeGroup(){} // RVA: 0x74578D0
        public void BuildAttributeGroup_Name(){} // RVA: 0x7457A70
        public void InitAttributeGroupRef(){} // RVA: 0x7457AE0
        public void BuildAttributeGroupRef_Ref(){} // RVA: 0x7457C90
        public void InitAnyAttribute(){} // RVA: 0x7457DD0
        public void BuildAnyAttribute_Namespace(){} // RVA: 0x7458360
        public void BuildAnyAttribute_ProcessContents(){} // RVA: 0x74583D0
        public void InitGroup(){} // RVA: 0x7458490
        public void BuildGroup_Name(){} // RVA: 0x74586B0
        public void InitGroupRef(){} // RVA: 0x7458720
        public void BuildParticle_MaxOccurs(){} // RVA: 0x7458960
        public void BuildParticle_MinOccurs(){} // RVA: 0x7458990
        public void BuildGroupRef_Ref(){} // RVA: 0x74589C0
        public void InitAll(){} // RVA: 0x7458B00
        public void InitChoice(){} // RVA: 0x7458C70
        public void InitSequence(){} // RVA: 0x7458DE0
        public void InitAny(){} // RVA: 0x7458F50
        public void BuildAny_Namespace(){} // RVA: 0x7459100
        public void BuildAny_ProcessContents(){} // RVA: 0x7459170
        public void InitNotation(){} // RVA: 0x7459230
        public void BuildNotation_Name(){} // RVA: 0x7459420
        public void BuildNotation_Public(){} // RVA: 0x7459490
        public void BuildNotation_System(){} // RVA: 0x7459500
        public void InitFacet(){} // RVA: 0x7459570
        public void BuildFacet_Fixed(){} // RVA: 0x7459960
        public void BuildFacet_Value(){} // RVA: 0x74599F0
        public void InitIdentityConstraint(){} // RVA: 0x7459A60
        public void BuildIdentityConstraint_Name(){} // RVA: 0x7459ED0
        public void BuildIdentityConstraint_Refer(){} // RVA: 0x7459F40
        public void InitSelector(){} // RVA: 0x745A140
        public void BuildSelector_XPath(){} // RVA: 0x745A300
        public void InitField(){} // RVA: 0x745A370
        public void BuildField_XPath(){} // RVA: 0x745A300
        public void InitAnnotation(){} // RVA: 0x745A510
        public void InitAppinfo(){} // RVA: 0x745A730
        public void BuildAppinfo_Source(){} // RVA: 0x745A940
        public void EndAppinfo(){} // RVA: 0x745AA00
        public void InitDocumentation(){} // RVA: 0x745AA70
        public void BuildDocumentation_Source(){} // RVA: 0x745AC80
        public void BuildDocumentation_XmlLang(){} // RVA: 0x745AD40
        public void EndDocumentation(){} // RVA: 0x745AF60
        public void AddAttribute(){} // RVA: 0x745AFD0
        public void AddParticle(){} // RVA: 0x745B270
        public void GetNextState(){} // RVA: 0x745B6C0
        public void IsSkipableElement(){} // RVA: 0x745B8A0
        public void SetMinOccurs(){} // RVA: 0x745B8D0
        public void SetMaxOccurs(){} // RVA: 0x745B930
        public void ParseBoolean(){} // RVA: 0x745B990
        public void ParseEnum(){} // RVA: 0x745BA30
        public void ParseQName(){} // RVA: 0x745BB60
        public void ParseBlockFinalEnum(){} // RVA: 0x745BC60
        public void ParseUriReference(){} // RVA: 0x2303260
        public void SendValidationEvent(){} // RVA: 0x745C470
        public void RecordPosition(){} // RVA: 0x745C480
        public void .cctor(){} // RVA: 0x745C600
    }

    public class XsdDateTime : ValueType
    {
        public object dt;
        public object extra;
        public object Lzyyyy;
        public object Lzyyyy_;
        public object Lzyyyy_MM;
        public object Lzyyyy_MM_;
        public object Lzyyyy_MM_dd;
        public object Lzyyyy_MM_ddT;
        public object LzHH;
        public object LzHH_;
        public object LzHH_mm;
        public object LzHH_mm_;
        public object LzHH_mm_ss;
        public object Lz_;
        public object Lz_zz;
        public object Lz_zz_;
        public object Lz_zz_zz;
        public object Lz__;
        public object Lz__mm;
        public object Lz__mm_;
        public object Lz__mm__;
        public object Lz__mm_dd;
        public object Lz___;
        public object Lz___dd;
        public object typeCodes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x914490
        public void InitiateXsdDateTime(){} // RVA: 0x9143D0
        public void TryParse(){} // RVA: 0x7462A90
        public void get_InternalTypeCode(){} // RVA: 0x9144B0
        public void get_InternalKind(){} // RVA: 0x8B0740
        public void get_Year(){} // RVA: 0x9144C0
        public void get_Month(){} // RVA: 0x9144D0
        public void get_Day(){} // RVA: 0x9144E0
        public void get_Hour(){} // RVA: 0x9144F0
        public void get_Minute(){} // RVA: 0x914540
        public void get_Second(){} // RVA: 0x914590
        public void get_Fraction(){} // RVA: 0x9145E0
        public void get_ZoneHour(){} // RVA: 0x7E240
        public void get_ZoneMinute(){} // RVA: 0x7E230
        public void op_Implicit(){} // RVA: 0x7463F70
        public void ToString(){} // RVA: 0x9145F0
        public void PrintDate(){} // RVA: 0x914600
        public void PrintTime(){} // RVA: 0x914610
        public void PrintZone(){} // RVA: 0x914620
        public void IntToCharArray(){} // RVA: 0x914630
        public void ShortToCharArray(){} // RVA: 0x914640
        public void .cctor(){} // RVA: 0x7465690
    }

    public class XsdDuration : ValueType
    {
        public object years;
        public object months;
        public object days;
        public object hours;
        public object minutes;
        public object seconds;
        public object nanoseconds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x914970
        public void get_IsNegative(){} // RVA: 0x914980
        public void get_Years(){} // RVA: 0x77E60
        public void get_Months(){} // RVA: 0x77E50
        public void get_Days(){} // RVA: 0x14790
        public void get_Hours(){} // RVA: 0x92DE0
        public void get_Minutes(){} // RVA: 0x8C7E0
        public void get_Seconds(){} // RVA: 0xAFF50
        public void get_Nanoseconds(){} // RVA: 0x914990
        public void ToTimeSpan(){} // RVA: 0x9149F0
        public void TryToTimeSpan(){} // RVA: 0x914A60
        public void ToString(){} // RVA: 0x914A80
        public void TryParse(){} // RVA: 0x7468D50
        public void TryParseDigits(){} // RVA: 0x7469980
    }

    public class XsdSimpleValue : Object
    {
        public object xmlType;
        public object typedValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_XmlType(){} // RVA: 0xB5DBF0
        public void get_TypedValue(){} // RVA: 0xB465B0
    }

    public class XsdValidator : BaseValidator
    {
        public object startIDConstraint;
        public object validationStack;
        public object attPresence;
        public object nsManager;
        public object bManageNamespaces;
        public object IDs;
        public object idRefListHead;
        public object inlineSchemaParser;
        public object processContents;
        public object dtCDATA;
        public object dtQName;
        public object dtStringArray;
        public object NsXmlNs;
        public object NsXs;
        public object NsXsi;
        public object XsiType;
        public object XsiNil;
        public object XsiSchemaLocation;
        public object XsiNoNamespaceSchemaLocation;
        public object XsdSchema;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7469B00
        public void Init(){} // RVA: 0x7469B30
        public void Validate(){} // RVA: 0x746A370
        public void CompleteValidation(){} // RVA: 0x746A450
        public void get_IsInlineSchemaStarted(){} // RVA: 0x73FF900
        public void ProcessInlineSchema(){} // RVA: 0x746A5F0
        public void ValidateElement(){} // RVA: 0x746A8A0
        public void ValidateChildElement(){} // RVA: 0x746AAB0
        public void ProcessElement(){} // RVA: 0x746AD30
        public void ProcessXsiAttributes(){} // RVA: 0x746B180
        public void ValidateEndElement(){} // RVA: 0x746BA90
        public void FastGetElementDecl(){} // RVA: 0x746BCF0
        public void ThoroughGetElementDecl(){} // RVA: 0x746BDE0
        public void ValidateStartElement(){} // RVA: 0x746C340
        public void ValidateEndStartElement(){} // RVA: 0x746CD60
        public void LoadSchemaFromLocation(){} // RVA: 0x746D1B0
        public void LoadSchema(){} // RVA: 0x746D7B0
        public void get_HasSchema(){} // RVA: 0x7401740
        public void get_PreserveWhitespace(){} // RVA: 0x7401760
        public void ProcessTokenizedType(){} // RVA: 0x746D990
        public void CheckValue(){} // RVA: 0x746DC90
        public void AddID(){} // RVA: 0x746E220
        public void FindId(){} // RVA: 0x74029A0
        public void IsXSDRoot(){} // RVA: 0x746E320
        public void Push(){} // RVA: 0x746E340
        public void Pop(){} // RVA: 0x746E6B0
        public void CheckForwardRefs(){} // RVA: 0x746A450
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x746E840
        public void get_HasIdentityConstraints(){} // RVA: 0x746E8A0
        public void AddIdentityConstraints(){} // RVA: 0x746E8B0
        public void ElementIdentityConstraints(){} // RVA: 0x746EF60
        public void AttributeIdentityConstraints(){} // RVA: 0x746F390
        public void UnWrapUnion(){} // RVA: 0x746F720
        public void EndElementIdentityConstraints(){} // RVA: 0x746F790
        public void .cctor(){} // RVA: 0x74704C0
    }

}