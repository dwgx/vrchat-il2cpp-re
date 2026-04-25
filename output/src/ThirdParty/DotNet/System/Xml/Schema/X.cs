// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 97
// Methods: 1524

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XdrBuilder : SchemaBuilder
    {
        public int[] XmlResolver;
        public int[] S_XDR_Root_SubElements; // 0x8
        public int[] S_XDR_ElementType_SubElements; // 0x10
        public int[] S_XDR_AttributeType_SubElements; // 0x18
        public int[] S_XDR_Group_SubElements; // 0x20
        public XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
        public XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
        public XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
        public XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
        public XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
        public XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
        public XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
        public XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
        public XdrEntry[] S_SchemaEntries; // 0x68
        public System.Xml.Schema.SchemaInfo _SchemaInfo; // 0x10
        public string _TargetNamespace; // 0x18
        public System.Xml.XmlReader _reader; // 0x20
        public System.Xml.PositionInfo positionInfo; // 0x28
        public System.Xml.Schema.ParticleContentValidator _contentValidator; // 0x30
        public XdrEntry _CurState; // 0x38
        public XdrEntry _NextState; // 0x40
        public System.Xml.HWStack _StateHistory; // 0x48
        public System.Xml.HWStack _GroupStack; // 0x50
        public string _XdrName; // 0x58
        public string _XdrPrefix; // 0x60
        public ElementContent _ElementDef; // 0x68
        public GroupContent _GroupDef; // 0x70
        public AttributeContent _AttributeDef; // 0x78
        public DeclBaseInfo _UndefinedAttributeTypes; // 0x80
        public DeclBaseInfo _BaseDecl; // 0x88
        public System.Xml.XmlNameTable _NameTable; // 0x90
        public System.Xml.Schema.SchemaNames _SchemaNames; // 0x98
        public System.Xml.XmlNamespaceManager _CurNsMgr; // 0xA0
        public string _Text; // 0xA8
        public System.Xml.Schema.ValidationEventHandler validationEventHandler; // 0xB0
        public System.Collections.Hashtable _UndeclaredElements; // 0xB8
        public System.Xml.XmlResolver xmlResolver; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9124F50
        public void ProcessElement(){} // RVA: 0x7FFAC9125670
        public void ProcessAttribute(){} // RVA: 0x7FFAC9125930
        public void set_XmlResolver(){} // RVA: 0x7FFAC2F8C130
        public void LoadSchema(){} // RVA: 0x7FFAC9125ED0
        public void IsXdrSchema(){} // RVA: 0x7FFAC9126410
        public void IsContentParsed(){} // RVA: 0x7FFAC3006850
        public void ProcessMarkup(){} // RVA: 0x7FFAC9126740
        public void ProcessCData(){} // RVA: 0x7FFAC91267A0
        public void StartChildren(){} // RVA: 0x7FFAC9126870
        public void EndChildren(){} // RVA: 0x7FFAC91268B0
        public void Push(){} // RVA: 0x7FFAC91269F0
        public void Pop(){} // RVA: 0x7FFAC9126A80
        public void PushGroupInfo(){} // RVA: 0x7FFAC9126BA0
        public void PopGroupInfo(){} // RVA: 0x7FFAC9126C50
        public void XDR_InitRoot(){} // RVA: 0x7FFAC9126D70
        public void XDR_BuildRoot_Name(){} // RVA: 0x7FFAC9126ED0
        public void XDR_BuildRoot_ID(){} // RVA: 0x7FFAC2F21310
        public void XDR_BeginRoot(){} // RVA: 0x7FFAC9127030
        public void XDR_EndRoot(){} // RVA: 0x7FFAC9127200
        public void XDR_InitElementType(){} // RVA: 0x7FFAC9127730
        public void XDR_BuildElementType_Name(){} // RVA: 0x7FFAC91279F0
        public void XDR_BuildElementType_Content(){} // RVA: 0x7FFAC9127D10
        public void XDR_BuildElementType_Model(){} // RVA: 0x7FFAC9127DC0
        public void XDR_BuildElementType_Order(){} // RVA: 0x7FFAC9127F50
        public void XDR_BuildElementType_DtType(){} // RVA: 0x7FFAC9128010
        public void XDR_BuildElementType_DtValues(){} // RVA: 0x7FFAC91281E0
        public void XDR_BuildElementType_DtMaxLength(){} // RVA: 0x7FFAC9128330
        public void XDR_BuildElementType_DtMinLength(){} // RVA: 0x7FFAC91283C0
        public void XDR_BeginElementType(){} // RVA: 0x7FFAC9128450
        public void XDR_EndElementType(){} // RVA: 0x7FFAC91287F0
        public void XDR_InitAttributeType(){} // RVA: 0x7FFAC9128F20
        public void XDR_BuildAttributeType_Name(){} // RVA: 0x7FFAC9129120
        public void XDR_BuildAttributeType_Required(){} // RVA: 0x7FFAC9129580
        public void XDR_BuildAttributeType_Default(){} // RVA: 0x7FFAC9129600
        public void XDR_BuildAttributeType_DtType(){} // RVA: 0x7FFAC9129670
        public void XDR_BuildAttributeType_DtValues(){} // RVA: 0x7FFAC91298E0
        public void XDR_BuildAttributeType_DtMaxLength(){} // RVA: 0x7FFAC9129A30
        public void XDR_BuildAttributeType_DtMinLength(){} // RVA: 0x7FFAC9129AC0
        public void XDR_BeginAttributeType(){} // RVA: 0x7FFAC9129B50
        public void XDR_EndAttributeType(){} // RVA: 0x7FFAC9129C10
        public void XDR_InitElement(){} // RVA: 0x7FFAC912A050
        public void XDR_BuildElement_Type(){} // RVA: 0x7FFAC912A140
        public void XDR_BuildElement_MinOccurs(){} // RVA: 0x7FFAC912A330
        public void XDR_BuildElement_MaxOccurs(){} // RVA: 0x7FFAC912A3B0
        public void XDR_EndElement(){} // RVA: 0x7FFAC912A430
        public void XDR_InitAttribute(){} // RVA: 0x7FFAC912A570
        public void XDR_BuildAttribute_Type(){} // RVA: 0x7FFAC912A640
        public void XDR_BuildAttribute_Required(){} // RVA: 0x7FFAC912A7F0
        public void XDR_BuildAttribute_Default(){} // RVA: 0x7FFAC912A880
        public void XDR_BeginAttribute(){} // RVA: 0x7FFAC912A8F0
        public void XDR_EndAttribute(){} // RVA: 0x7FFAC912AF90
        public void XDR_InitGroup(){} // RVA: 0x7FFAC912AFC0
        public void XDR_BuildGroup_Order(){} // RVA: 0x7FFAC912B1A0
        public void XDR_BuildGroup_MinOccurs(){} // RVA: 0x7FFAC912B290
        public void XDR_BuildGroup_MaxOccurs(){} // RVA: 0x7FFAC912B320
        public void XDR_EndGroup(){} // RVA: 0x7FFAC912B3B0
        public void XDR_InitElementDtType(){} // RVA: 0x7FFAC912B680
        public void XDR_EndElementDtType(){} // RVA: 0x7FFAC912B790
        public void XDR_InitAttributeDtType(){} // RVA: 0x7FFAC912B960
        public void XDR_EndAttributeDtType(){} // RVA: 0x7FFAC912BA00
        public void GetNextState(){} // RVA: 0x7FFAC912BB30
        public void IsSkipableElement(){} // RVA: 0x7FFAC912BD20
        public void IsSkipableAttribute(){} // RVA: 0x7FFAC912BE20
        public void GetOrder(){} // RVA: 0x7FFAC912BF90
        public void AddOrder(){} // RVA: 0x7FFAC912C150
        public void IsYes(){} // RVA: 0x7FFAC912C210
        public void ParseMinOccurs(){} // RVA: 0x7FFAC912C390
        public void ParseMaxOccurs(){} // RVA: 0x7FFAC912C4D0
        public void HandleMinMax(){} // RVA: 0x7FFAC912C630
        public void ParseDtMaxLength(){} // RVA: 0x7FFAC912C660
        public void ParseDtMinLength(){} // RVA: 0x7FFAC912C7E0
        public void CompareMinMaxLength(){} // RVA: 0x7FFAC912C960
        public void ParseInteger(){} // RVA: 0x7FFAC912C9E0
        public void XDR_CheckAttributeDefault(){} // RVA: 0x7FFAC912CA20
        public void SetAttributePresence(){} // RVA: 0x7FFAC912CB30
        public void GetContent(){} // RVA: 0x7FFAC912CB80
        public void GetModel(){} // RVA: 0x7FFAC912CD90
        public void CheckDatatype(){} // RVA: 0x7FFAC912CEB0
        public void CheckDefaultAttValue(){} // RVA: 0x7FFAC912D040
        public void IsGlobal(){} // RVA: 0x7FFAC912D1B0
        public void SendValidationEvent(){} // RVA: 0x7FFAC912D480 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFAC912D560
    }

    public class XdrValidator : BaseValidator
    {
        public System.Xml.HWStack IsInlineSchemaStarted; // 0x80
        public System.Collections.Hashtable HasSchema; // 0x88
        public System.Xml.XmlQualifiedName PreserveWhitespace; // 0x90
        public System.Xml.XmlNamespaceManager nsManager; // 0x98
        public bool isProcessContents; // 0xA0
        public System.Collections.Hashtable IDs; // 0xA8
        public System.Xml.Schema.IdRefNode idRefListHead; // 0xB0
        public System.Xml.Schema.Parser inlineSchemaParser; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC912FCB0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC912FDB0
        public void Validate(){} // RVA: 0x7FFAC91301E0
        public void ValidateElement(){} // RVA: 0x7FFAC91302C0
        public void ValidateChildElement(){} // RVA: 0x7FFAC9130800
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7FFAC91309D0
        public void ProcessInlineSchema(){} // RVA: 0x7FFAC91309E0
        public void ProcessElement(){} // RVA: 0x7FFAC9130D30
        public void ValidateEndElement(){} // RVA: 0x7FFAC9130E50
        public void ThoroughGetElementDecl(){} // RVA: 0x7FFAC9131220
        public void ValidateStartElement(){} // RVA: 0x7FFAC9131650
        public void ValidateEndStartElement(){} // RVA: 0x7FFAC9131B70
        public void LoadSchemaFromLocation(){} // RVA: 0x7FFAC9131F30
        public void LoadSchema(){} // RVA: 0x7FFAC9132580
        public void get_HasSchema(){} // RVA: 0x7FFAC9132740
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAC9132760
        public void ProcessTokenizedType(){} // RVA: 0x7FFAC91327B0
        public void CompleteValidation(){} // RVA: 0x7FFAC9132AB0
        public void CheckValue(){} // RVA: 0x7FFAC9132D40
        public void CheckDefaultValue(){} // RVA: 0x7FFAC9133410
        public void AddID(){} // RVA: 0x7FFAC91338F0
        public void FindId(){} // RVA: 0x7FFAC91339F0
        public void Push(){} // RVA: 0x7FFAC9133A20
        public void Pop(){} // RVA: 0x7FFAC9133D10
        public void CheckForwardRefs(){} // RVA: 0x7FFAC9133E60
        public void QualifiedName(){} // RVA: 0x7FFAC9134000
    }

    public class XmlAnyConverter : XmlBaseConverter
    {
        public System.Xml.Schema.XmlValueConverter Item;
        public System.Xml.Schema.XmlValueConverter AnyAtomic; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9179F60
        public void ToBoolean(){} // RVA: 0x7FFAC917A160
        public void ToDateTime(){} // RVA: 0x7FFAC917A350
        public void ToDateTimeOffset(){} // RVA: 0x7FFAC917A540
        public void ToDecimal(){} // RVA: 0x7FFAC917A790
        public void ToDouble(){} // RVA: 0x7FFAC917A9E0
        public void ToInt32(){} // RVA: 0x7FFAC917ABD0
        public void ToInt64(){} // RVA: 0x7FFAC917ADC0
        public void ToSingle(){} // RVA: 0x7FFAC917AFB0
        public void ChangeType(){} // RVA: 0x7FFAC917C400 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAC917DDD0
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAC917DF30
        public void ToNavigator(){} // RVA: 0x7FFAC917E0B0
        public void .cctor(){} // RVA: 0x7FFAC917E150
    }

    public class XmlAnyListConverter : XmlListConverter
    {
        public System.Xml.Schema.XmlValueConverter ItemList;
        public System.Xml.Schema.XmlValueConverter AnyAtomicList; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC917E330
        public void ChangeType(){} // RVA: 0x7FFAC917E340
        public void .cctor(){} // RVA: 0x7FFAC917E5D0
    }

    public class XmlAtomicValue : XPathItem
    {
        public System.Xml.Schema.XmlSchemaType XmlType; // 0x10
        public object ValueType; // 0x18
        public 0x6B0C1808 TypedValue; // 0x20
        public Union ValueAsBoolean; // 0x28
        public NamespacePrefixForQName ValueAsDateTime; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9134AB0 | overloaded x9
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC44F81E0
        public void get_XmlType(){} // RVA: 0x7FFAC2F3C380
        public void get_ValueType(){} // RVA: 0x7FFAC9134D60
        public void get_TypedValue(){} // RVA: 0x7FFAC9134DA0
        public void get_ValueAsBoolean(){} // RVA: 0x7FFAC9134FB0
        public void get_ValueAsDateTime(){} // RVA: 0x7FFAC91350C0
        public void get_ValueAsDouble(){} // RVA: 0x7FFAC91351D0
        public void get_ValueAsInt(){} // RVA: 0x7FFAC91352E0
        public void get_ValueAsLong(){} // RVA: 0x7FFAC91353F0
        public void ValueAs(){} // RVA: 0x7FFAC9135500
        public void get_Value(){} // RVA: 0x7FFAC9135770
        public void ToString(){} // RVA: 0x7FFAC2FD5BE0
        public void GetPrefixFromQName(){} // RVA: 0x7FFAC91358B0
    }

    public class XmlBaseConverter : XmlValueConverter
    {
        public System.Xml.Schema.XmlSchemaType SchemaType; // 0x10
        public 0x6B1655D0 TypeCode; // 0x18
        public System.Type XmlTypeName; // 0x20
        public System.Type DefaultClrType;
        public System.Type IEnumerableType; // 0x8
        public System.Type IListType; // 0x10
        public System.Type ObjectArrayType; // 0x18
        public System.Type StringArrayType; // 0x20
        public System.Type XmlAtomicValueArrayType; // 0x28
        public System.Type DecimalType; // 0x30
        public System.Type Int32Type; // 0x38
        public System.Type Int64Type; // 0x40
        public System.Type StringType; // 0x48
        public System.Type XmlAtomicValueType; // 0x50
        public System.Type ObjectType; // 0x58
        public System.Type ByteType; // 0x60
        public System.Type Int16Type; // 0x68
        public System.Type SByteType; // 0x70
        public System.Type UInt16Type; // 0x78
        public System.Type UInt32Type; // 0x80
        public System.Type UInt64Type; // 0x88
        public System.Type XPathItemType; // 0x90
        public System.Type DoubleType; // 0x98
        public System.Type SingleType; // 0xA0
        public System.Type DateTimeType; // 0xA8
        public System.Type DateTimeOffsetType; // 0xB0
        public System.Type BooleanType; // 0xB8
        public System.Type ByteArrayType; // 0xC0
        public System.Type XmlQualifiedNameType; // 0xC8
        public System.Type UriType; // 0xD0
        public System.Type TimeSpanType; // 0xD8
        public System.Type XPathNavigatorType; // 0xE0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC915E520 | overloaded x4
        public void ToBoolean(){} // RVA: 0x7FFAC915EAD0 | overloaded x6
        public void ToDateTime(){} // RVA: 0x7FFAC915F160 | overloaded x7
        public void ToDateTimeOffset(){} // RVA: 0x7FFAC915F420 | overloaded x3
        public void ToDecimal(){} // RVA: 0x7FFAC915F5E0 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFAC915FB90 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFAC9160100 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFAC9160670 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFAC9160910 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC9161230 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFAC91615D0 | overloaded x8
        public void get_SchemaType(){} // RVA: 0x7FFAC2F3C380
        public void get_TypeCode(){} // RVA: 0x7FFAC3157800
        public void get_XmlTypeName(){} // RVA: 0x7FFAC9161600
        public void get_DefaultClrType(){} // RVA: 0x7FFAC2F4F0C0
        public void IsDerivedFrom(){} // RVA: 0x7FFAC9161710
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFAC91617C0
        public void QNameToString(){} // RVA: 0x7FFAC91637A0 | overloaded x2
        public void ChangeListType(){} // RVA: 0x7FFAC9161C30
        public void StringToBase64Binary(){} // RVA: 0x7FFAC9161C90
        public void StringToDate(){} // RVA: 0x7FFAC9161DB0
        public void StringToDateTime(){} // RVA: 0x7FFAC9161E30
        public void StringToDayTimeDuration(){} // RVA: 0x7FFAC9161EB0
        public void StringToDuration(){} // RVA: 0x7FFAC9161FB0
        public void StringToGDay(){} // RVA: 0x7FFAC91620B0
        public void StringToGMonth(){} // RVA: 0x7FFAC9162130
        public void StringToGMonthDay(){} // RVA: 0x7FFAC91621B0
        public void StringToGYear(){} // RVA: 0x7FFAC9162230
        public void StringToGYearMonth(){} // RVA: 0x7FFAC91622B0
        public void StringToDateOffset(){} // RVA: 0x7FFAC9162330
        public void StringToDateTimeOffset(){} // RVA: 0x7FFAC91623D0
        public void StringToGDayOffset(){} // RVA: 0x7FFAC9162470
        public void StringToGMonthOffset(){} // RVA: 0x7FFAC9162510
        public void StringToGMonthDayOffset(){} // RVA: 0x7FFAC91625B0
        public void StringToGYearOffset(){} // RVA: 0x7FFAC9162650
        public void StringToGYearMonthOffset(){} // RVA: 0x7FFAC91626F0
        public void StringToHexBinary(){} // RVA: 0x7FFAC9162790
        public void StringToQName(){} // RVA: 0x7FFAC91628C0
        public void StringToTime(){} // RVA: 0x7FFAC9162BC0
        public void StringToTimeOffset(){} // RVA: 0x7FFAC9162C40
        public void StringToYearMonthDuration(){} // RVA: 0x7FFAC9162CE0
        public void AnyUriToString(){} // RVA: 0x7FFAC9162DE0
        public void Base64BinaryToString(){} // RVA: 0x7FFAC9162E50
        public void DateToString(){} // RVA: 0x7FFAC9162F60
        public void DateTimeToString(){} // RVA: 0x7FFAC9162FE0
        public void DayTimeDurationToString(){} // RVA: 0x7FFAC9163060
        public void DurationToString(){} // RVA: 0x7FFAC91630D0
        public void GDayToString(){} // RVA: 0x7FFAC9163130
        public void GMonthToString(){} // RVA: 0x7FFAC91631B0
        public void GMonthDayToString(){} // RVA: 0x7FFAC9163230
        public void GYearToString(){} // RVA: 0x7FFAC91632B0
        public void GYearMonthToString(){} // RVA: 0x7FFAC9163330
        public void DateOffsetToString(){} // RVA: 0x7FFAC91633B0
        public void DateTimeOffsetToString(){} // RVA: 0x7FFAC9163440
        public void GDayOffsetToString(){} // RVA: 0x7FFAC91634D0
        public void GMonthOffsetToString(){} // RVA: 0x7FFAC9163560
        public void GMonthDayOffsetToString(){} // RVA: 0x7FFAC91635F0
        public void GYearOffsetToString(){} // RVA: 0x7FFAC9163680
        public void GYearMonthOffsetToString(){} // RVA: 0x7FFAC9163710
        public void TimeToString(){} // RVA: 0x7FFAC9163990
        public void TimeOffsetToString(){} // RVA: 0x7FFAC9163A10
        public void YearMonthDurationToString(){} // RVA: 0x7FFAC9163AA0
        public void DateTimeOffsetToDateTime(){} // RVA: 0x7FFAC9163B10
        public void DecimalToInt32(){} // RVA: 0x7FFAC9163B60
        public void DecimalToInt64(){} // RVA: 0x7FFAC9163DE0
        public void DecimalToUInt64(){} // RVA: 0x7FFAC9164070
        public void Int32ToByte(){} // RVA: 0x7FFAC91642F0
        public void Int32ToInt16(){} // RVA: 0x7FFAC91643F0
        public void Int32ToSByte(){} // RVA: 0x7FFAC91644F0
        public void Int32ToUInt16(){} // RVA: 0x7FFAC91645F0
        public void Int64ToInt32(){} // RVA: 0x7FFAC91646F0
        public void Int64ToUInt32(){} // RVA: 0x7FFAC91647F0
        public void UntypedAtomicToDateTime(){} // RVA: 0x7FFAC91648F0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x7FFAC9164970
        public void .cctor(){} // RVA: 0x7FFAC9164A10
    }

    public class XmlBooleanConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC916EEE0
        public void Create(){} // RVA: 0x7FFAC916EF40
        public void ToBoolean(){} // RVA: 0x7FFAC916F070 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC916F410 | overloaded x2
        public void ChangeType(){} // RVA: 0x7FFAC916FD80 | overloaded x3
    }

    public class XmlDateTimeConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC916C6F0
        public void Create(){} // RVA: 0x7FFAC916C750
        public void ToDateTime(){} // RVA: 0x7FFAC916CB90 | overloaded x3
        public void ToDateTimeOffset(){} // RVA: 0x7FFAC916D290 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC916DC20 | overloaded x3
        public void ChangeType(){} // RVA: 0x7FFAC916E6D0 | overloaded x3
    }

    public class XmlListConverter : XmlBaseConverter
    {
        public System.Xml.Schema.XmlValueConverter atomicConverter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC917EB20 | overloaded x3
        public void Create(){} // RVA: 0x7FFAC917EB80
        public void ChangeType(){} // RVA: 0x7FFAC917ED60
        public void ChangeListType(){} // RVA: 0x7FFAC917EE90
        public void IsListType(){} // RVA: 0x7FFAC917FDC0
        public void ToArray(){} // RVA: 0x7FFAC2C6A6F0
        public void ToList(){} // RVA: 0x7FFAC917FF50
        public void StringAsList(){} // RVA: 0x7FFAC91804E0
        public void ListAsString(){} // RVA: 0x7FFAC9180590
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFAC9180840
    }

    public class XmlMiscConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91703D0
        public void Create(){} // RVA: 0x7FFAC9170430
        public void ToString(){} // RVA: 0x7FFAC91704C0
        public void ChangeType(){} // RVA: 0x7FFAC9171340 | overloaded x2
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAC9172470
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAC91725D0
    }

    public class XmlNumeric10Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91663C0
        public void Create(){} // RVA: 0x7FFAC9166420
        public void ToDecimal(){} // RVA: 0x7FFAC9166630 | overloaded x2
        public void ToInt32(){} // RVA: 0x7FFAC9166CF0 | overloaded x3
        public void ToInt64(){} // RVA: 0x7FFAC91672B0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC9167A80 | overloaded x4
        public void ChangeType(){} // RVA: 0x7FFAC9168F90 | overloaded x5
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAC916A050
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAC916A4A0
    }

    public class XmlNumeric2Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC916A940
        public void Create(){} // RVA: 0x7FFAC916A9A0
        public void ToDouble(){} // RVA: 0x7FFAC916AB10 | overloaded x2
        public void ToSingle(){} // RVA: 0x7FFAC916AF90 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC916B4B0 | overloaded x3
        public void ChangeType(){} // RVA: 0x7FFAC916BF50 | overloaded x3
    }

    public class XmlSchema : XmlSchemaObject
    {
        public 0x6B164550 AttributeFormDefault; // 0x38
        public 0x6B164550 BlockDefault; // 0x3C
        public 0x6B163E70 FinalDefault; // 0x40
        public 0x6B163E70 ElementFormDefault; // 0x44
        public string TargetNamespace; // 0x48
        public string Version; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection Includes; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection Items; // 0x60
        public string IsCompiledBySet; // 0x68
        public System.Xml.XmlAttribute[] IsPreprocessed; // 0x70
        public bool IsRedefined; // 0x78
        public bool Attributes; // 0x79
        public bool AttributeGroups; // 0x7A
        public bool SchemaTypes; // 0x7B
        public int Elements; // 0x7C
        public System.Xml.Schema.XmlSchemaObjectTable Id; // 0x80
        public System.Xml.Schema.XmlSchemaObjectTable Groups; // 0x88
        public System.Xml.Schema.XmlSchemaObjectTable Notations; // 0x90
        public System.Xml.Schema.XmlSchemaObjectTable IdentityConstraints; // 0x98
        public System.Xml.Schema.XmlSchemaObjectTable BaseUri; // 0xA0
        public System.Xml.Schema.XmlSchemaObjectTable SchemaId; // 0xA8
        public System.Xml.Schema.XmlSchemaObjectTable IsChameleon; // 0xB0
        public int Ids;
        public System.Collections.ArrayList Document; // 0xB8
        public System.Collections.ArrayList ErrorCount; // 0xC0
        public int IdAttribute; // 0xC8
        public System.Uri ImportedSchemas; // 0xD0
        public bool ImportedNamespaces; // 0xD8
        public System.Collections.Hashtable ids; // 0xE0
        public System.Xml.XmlDocument document; // 0xE8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9135C30
        public void Read(){} // RVA: 0x7FFAC91360B0
        public void CompileSchema(){} // RVA: 0x7FFAC9136250
        public void CompileSchemaInSet(){} // RVA: 0x7FFAC91366D0
        public void get_AttributeFormDefault(){} // RVA: 0x7FFAC358A870
        public void set_AttributeFormDefault(){} // RVA: 0x7FFAC3588350
        public void get_BlockDefault(){} // RVA: 0x7FFAC2FC2080
        public void set_BlockDefault(){} // RVA: 0x7FFAC2FC2090
        public void get_FinalDefault(){} // RVA: 0x7FFAC2FC20A0
        public void set_FinalDefault(){} // RVA: 0x7FFAC2FC20B0
        public void get_ElementFormDefault(){} // RVA: 0x7FFAC33BD4A0
        public void set_ElementFormDefault(){} // RVA: 0x7FFAC47E2CD0
        public void get_TargetNamespace(){} // RVA: 0x7FFAC2F9C730
        public void set_TargetNamespace(){} // RVA: 0x7FFAC2F9C740
        public void get_Version(){} // RVA: 0x7FFAC2FC20E0
        public void set_Version(){} // RVA: 0x7FFAC30794D0
        public void get_Includes(){} // RVA: 0x7FFAC2FE9500
        public void get_Items(){} // RVA: 0x7FFAC2FBF370
        public void get_IsCompiledBySet(){} // RVA: 0x7FFAC33CC650
        public void set_IsCompiledBySet(){} // RVA: 0x7FFAC33CBCC0
        public void get_IsPreprocessed(){} // RVA: 0x7FFAC33D1F80
        public void set_IsPreprocessed(){} // RVA: 0x7FFAC33CAD50
        public void get_IsRedefined(){} // RVA: 0x7FFAC33D0810
        public void set_IsRedefined(){} // RVA: 0x7FFAC33D1800
        public void get_Attributes(){} // RVA: 0x7FFAC9136790
        public void get_AttributeGroups(){} // RVA: 0x7FFAC9136850
        public void get_SchemaTypes(){} // RVA: 0x7FFAC9136910
        public void get_Elements(){} // RVA: 0x7FFAC91369D0
        public void get_Id(){} // RVA: 0x7FFAC2F9CD50
        public void set_Id(){} // RVA: 0x7FFAC2F9CD60
        public void get_Groups(){} // RVA: 0x7FFAC3543900
        public void get_Notations(){} // RVA: 0x7FFAC354B1A0
        public void get_IdentityConstraints(){} // RVA: 0x7FFAC2F8C040
        public void get_BaseUri(){} // RVA: 0x7FFAC303E100
        public void set_BaseUri(){} // RVA: 0x7FFAC303E110
        public void get_SchemaId(){} // RVA: 0x7FFAC9136A90
        public void get_IsChameleon(){} // RVA: 0x7FFAC3DBD9E0
        public void set_IsChameleon(){} // RVA: 0x7FFAC88C7210
        public void get_Ids(){} // RVA: 0x7FFAC2FA2900
        public void get_Document(){} // RVA: 0x7FFAC9136B10
        public void get_ErrorCount(){} // RVA: 0x7FFAC4598F70
        public void set_ErrorCount(){} // RVA: 0x7FFAC89E0310
        public void Clone(){} // RVA: 0x7FFAC9136BD0
        public void DeepClone(){} // RVA: 0x7FFAC9136E70
        public void get_IdAttribute(){} // RVA: 0x7FFAC2F9CD50
        public void set_IdAttribute(){} // RVA: 0x7FFAC2F9CD60
        public void SetIsCompiled(){} // RVA: 0x7FFAC3D20B50
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAC2FE95A0
        public void AddAnnotation(){} // RVA: 0x7FFAC9137420
        public void get_ImportedSchemas(){} // RVA: 0x7FFAC9137480
        public void get_ImportedNamespaces(){} // RVA: 0x7FFAC9137540
        public void GetExternalSchemasList(){} // RVA: 0x7FFAC9137600
        public void .cctor(){} // RVA: 0x7FFAC9137780
    }

    public class XmlSchemaAll : XmlSchemaGroupBase
    {
        public System.Xml.Schema.XmlSchemaObjectCollection Items; // 0x78

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAC30E5600
        public void get_IsEmpty(){} // RVA: 0x7FFAC91377C0
        public void SetItems(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFAC9137820
    }

    public class XmlSchemaAnnotated : XmlSchemaObject
    {
        public string Id; // 0x38
        public System.Xml.Schema.XmlSchemaAnnotation Annotation; // 0x40
        public System.Xml.XmlAttribute[] UnhandledAttributes; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC31D0140
        public void set_Id(){} // RVA: 0x7FFAC31D0C20
        public void get_Annotation(){} // RVA: 0x7FFAC2F9E740
        public void set_Annotation(){} // RVA: 0x7FFAC2F49200
        public void get_UnhandledAttributes(){} // RVA: 0x7FFAC2F9C730
        public void set_UnhandledAttributes(){} // RVA: 0x7FFAC2F9C740
        public void get_IdAttribute(){} // RVA: 0x7FFAC31D0140
        public void set_IdAttribute(){} // RVA: 0x7FFAC31D0C20
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAC2F9C740
        public void AddAnnotation(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaAnnotation : XmlSchemaObject
    {
        public string Id; // 0x38
        public System.Xml.Schema.XmlSchemaObjectCollection Items; // 0x40
        public System.Xml.XmlAttribute[] IdAttribute; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC31D0140
        public void set_Id(){} // RVA: 0x7FFAC31D0C20
        public void get_Items(){} // RVA: 0x7FFAC2F9E740
        public void get_IdAttribute(){} // RVA: 0x7FFAC31D0140
        public void set_IdAttribute(){} // RVA: 0x7FFAC31D0C20
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAC2F9C740
        public void .ctor(){} // RVA: 0x7FFAC9137900
    }

    public class XmlSchemaAny : XmlSchemaParticle
    {
        public string Namespace; // 0x78
        public 0x6B163D68 ProcessContents; // 0x80
        public System.Xml.Schema.NamespaceList NamespaceList; // 0x88

        // ── Methods ──
        public void get_Namespace(){} // RVA: 0x7FFAC30E5600
        public void set_Namespace(){} // RVA: 0x7FFAC30E06F0
        public void set_ProcessContents(){} // RVA: 0x7FFAC3572BF0
        public void get_NamespaceList(){} // RVA: 0x7FFAC2F60010
        public void get_ResolvedNamespace(){} // RVA: 0x7FFAC91379A0
        public void get_ProcessContentsCorrect(){} // RVA: 0x7FFAC91379F0
        public void get_NameString(){} // RVA: 0x7FFAC9137A10
        public void BuildNamespaceList(){} // RVA: 0x7FFAC9137E50
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7FFAC9137FB0
        public void Allows(){} // RVA: 0x7FFAC9138120
        public void .ctor(){} // RVA: 0x7FFAC9138160
    }

    public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
    {
        public string Namespace; // 0x50
        public 0x6B163D68 ProcessContents; // 0x58
        public System.Xml.Schema.NamespaceList NamespaceList; // 0x60

        // ── Methods ──
        public void set_Namespace(){} // RVA: 0x7FFAC30794D0
        public void get_ProcessContents(){} // RVA: 0x7FFAC362EA40
        public void set_ProcessContents(){} // RVA: 0x7FFAC362EA00
        public void get_NamespaceList(){} // RVA: 0x7FFAC2FBF370
        public void get_ProcessContentsCorrect(){} // RVA: 0x7FFAC91381B0
        public void BuildNamespaceList(){} // RVA: 0x7FFAC91381C0
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7FFAC9138300
        public void Allows(){} // RVA: 0x7FFAC9138460
        public void IsSubset(){} // RVA: 0x7FFAC91384A0
        public void Intersection(){} // RVA: 0x7FFAC91384D0
        public void Union(){} // RVA: 0x7FFAC9138640
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaAppInfo : XmlSchemaObject
    {
        public string Source; // 0x38
        public System.Xml.XmlNode[] Markup; // 0x40

        // ── Methods ──
        public void set_Source(){} // RVA: 0x7FFAC31D0C20
        public void get_Markup(){} // RVA: 0x7FFAC2F9E740
        public void set_Markup(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaAttribute : XmlSchemaAnnotated
    {
        public string DefaultValue; // 0x50
        public string FixedValue; // 0x58
        public string Form; // 0x60
        public 0x6B164550 Name; // 0x68
        public 0x6B1652B8 RefName; // 0x6C
        public System.Xml.XmlQualifiedName SchemaTypeName; // 0x70
        public System.Xml.XmlQualifiedName SchemaType; // 0x78
        public System.Xml.XmlQualifiedName Use; // 0x80
        public System.Xml.Schema.XmlSchemaSimpleType QualifiedName; // 0x88
        public System.Xml.Schema.XmlSchemaSimpleType AttributeSchemaType; // 0x90
        public System.Xml.Schema.SchemaAttDef Datatype; // 0x98

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFAC2FC20E0
        public void set_DefaultValue(){} // RVA: 0x7FFAC30794D0
        public void get_FixedValue(){} // RVA: 0x7FFAC2FE9500
        public void set_FixedValue(){} // RVA: 0x7FFAC2FE9510
        public void get_Form(){} // RVA: 0x7FFAC47BAB50
        public void set_Form(){} // RVA: 0x7FFAC47BAB60
        public void get_Name(){} // RVA: 0x7FFAC2FBF370
        public void set_Name(){} // RVA: 0x7FFAC2FBF380
        public void get_RefName(){} // RVA: 0x7FFAC2FE9590
        public void set_RefName(){} // RVA: 0x7FFAC91387B0
        public void get_SchemaTypeName(){} // RVA: 0x7FFAC30E5600
        public void set_SchemaTypeName(){} // RVA: 0x7FFAC9138890
        public void get_SchemaType(){} // RVA: 0x7FFAC2F60010
        public void set_SchemaType(){} // RVA: 0x7FFAC354E300
        public void get_Use(){} // RVA: 0x7FFAC47BAB70
        public void set_Use(){} // RVA: 0x7FFAC47BAB80
        public void get_QualifiedName(){} // RVA: 0x7FFAC32EF410
        public void get_AttributeSchemaType(){} // RVA: 0x7FFAC32EF640
        public void get_Datatype(){} // RVA: 0x7FFAC9138970
        public void SetQualifiedName(){} // RVA: 0x7FFAC34D4AA0
        public void SetAttributeType(){} // RVA: 0x7FFAC354E360
        public void get_AttDef(){} // RVA: 0x7FFAC354DFB0
        public void set_AttDef(){} // RVA: 0x7FFAC354E3C0
        public void get_NameAttribute(){} // RVA: 0x7FFAC2FBF370
        public void set_NameAttribute(){} // RVA: 0x7FFAC2FBF380
        public void Clone(){} // RVA: 0x7FFAC9138990
        public void .ctor(){} // RVA: 0x7FFAC9138B70
    }

    public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
    {
        public string Name; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute; // 0x60
        public System.Xml.XmlQualifiedName QualifiedName; // 0x68
        public System.Xml.Schema.XmlSchemaAttributeGroup AttributeUses; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable AttributeWildcard; // 0x78
        public System.Xml.Schema.XmlSchemaAnyAttribute RedefinedAttributeGroup; // 0x80
        public int Redefined; // 0x88

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void set_Name(){} // RVA: 0x7FFAC30794D0
        public void get_Attributes(){} // RVA: 0x7FFAC2FE9500
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2FBF370
        public void set_AnyAttribute(){} // RVA: 0x7FFAC2FBF380
        public void get_QualifiedName(){} // RVA: 0x7FFAC2F9CD50
        public void get_AttributeUses(){} // RVA: 0x7FFAC9138CF0
        public void get_AttributeWildcard(){} // RVA: 0x7FFAC32EF410
        public void set_AttributeWildcard(){} // RVA: 0x7FFAC34D4AA0
        public void get_RedefinedAttributeGroup(){} // RVA: 0x7FFAC2FE9590
        public void get_Redefined(){} // RVA: 0x7FFAC2FE9590
        public void set_Redefined(){} // RVA: 0x7FFAC2FE95A0
        public void get_SelfReferenceCount(){} // RVA: 0x7FFAC37EE8C0
        public void set_SelfReferenceCount(){} // RVA: 0x7FFAC37F9DE0
        public void get_NameAttribute(){} // RVA: 0x7FFAC2FC20E0
        public void set_NameAttribute(){} // RVA: 0x7FFAC30794D0
        public void SetQualifiedName(){} // RVA: 0x7FFAC2F9CD60
        public void Clone(){} // RVA: 0x7FFAC9138DA0
        public void .ctor(){} // RVA: 0x7FFAC9138F50
    }

    public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
    {
        public System.Xml.XmlQualifiedName RefName; // 0x50

        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7FFAC2FC20E0
        public void set_RefName(){} // RVA: 0x7FFAC9139090
        public void .ctor(){} // RVA: 0x7FFAC9139170
    }

    public class XmlSchemaChoice : XmlSchemaGroupBase
    {
        public System.Xml.Schema.XmlSchemaObjectCollection Items; // 0x78

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAC30E5600
        public void get_IsEmpty(){} // RVA: 0x7FFAC9139220
        public void SetItems(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFAC9139230
    }

    public class XmlSchemaCollection : Object
    {
        public System.Collections.Hashtable Count; // 0x10
        public System.Xml.XmlNameTable NameTable; // 0x18
        public System.Xml.Schema.SchemaNames XmlResolver; // 0x20
        public System.Threading.ReaderWriterLock Item; // 0x28
        public int System.Collections.ICollection.IsSynchronized; // 0x30
        public bool System.Collections.ICollection.SyncRoot; // 0x34
        public System.Xml.Schema.ValidationEventHandler System.Collections.ICollection.Count; // 0x38
        public System.Xml.XmlResolver EventHandler; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9139310
        public void get_Count(){} // RVA: 0x7FFAC9139590
        public void get_NameTable(){} // RVA: 0x7FFAC2F247C0
        public void set_XmlResolver(){} // RVA: 0x7FFAC2F49200
        public void get_Item(){} // RVA: 0x7FFAC91395C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9139680
        public void GetEnumerator(){} // RVA: 0x7FFAC9139750
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC9139820
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC3006850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC9139590
        public void GetSchemaInfo(){} // RVA: 0x7FFAC91399C0
        public void GetSchemaNames(){} // RVA: 0x7FFAC9139A80
        public void Add(){} // RVA: 0x7FFAC9139E00 | overloaded x3
        public void get_EventHandler(){} // RVA: 0x7FFAC31D0140
        public void set_EventHandler(){} // RVA: 0x7FFAC31D0C20
    }

    public class XmlSchemaCollectionEnumerator : Object
    {
        public System.Collections.IDictionaryEnumerator System.Collections.IEnumerator.Current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9139F40
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9139FC0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC913A010
        public void MoveNext(){} // RVA: 0x7FFAC913A060
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC913A0B0
        public void get_Current(){} // RVA: 0x7FFAC913A0C0
        public void get_CurrentNode(){} // RVA: 0x7FFAC913A150
    }

    public class XmlSchemaCollectionNode : Object
    {
        public string NamespaceURI; // 0x10
        public System.Xml.Schema.SchemaInfo SchemaInfo; // 0x18
        public System.Xml.Schema.XmlSchema Schema; // 0x20

        // ── Methods ──
        public void set_NamespaceURI(){} // RVA: 0x7FFAC2F22E30
        public void get_SchemaInfo(){} // RVA: 0x7FFAC2F247C0
        public void set_SchemaInfo(){} // RVA: 0x7FFAC2F87E80
        public void get_Schema(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Schema(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaCompilationSettings : Object
    {
        public bool EnableUpaCheck; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC322C870
        public void get_EnableUpaCheck(){} // RVA: 0x7FFAC2FEB5E0
    }

    public class XmlSchemaComplexContent : XmlSchemaContentModel
    {
        public System.Xml.Schema.XmlSchemaContent IsMixed; // 0x50
        public bool Content; // 0x58
        public bool HasMixedAttribute; // 0x59

        // ── Methods ──
        public void get_IsMixed(){} // RVA: 0x7FFAC313F600
        public void set_IsMixed(){} // RVA: 0x7FFAC913A1E0
        public void get_Content(){} // RVA: 0x7FFAC2FC20E0
        public void set_Content(){} // RVA: 0x7FFAC30794D0
        public void get_HasMixedAttribute(){} // RVA: 0x7FFAC778CF40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaComplexContentExtension : XmlSchemaContent
    {
        public System.Xml.Schema.XmlSchemaParticle BaseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection Particle; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute Attributes; // 0x60
        public System.Xml.XmlQualifiedName AnyAttribute; // 0x68

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAC2F9CD50
        public void set_BaseTypeName(){} // RVA: 0x7FFAC913A1F0
        public void get_Particle(){} // RVA: 0x7FFAC2FC20E0
        public void set_Particle(){} // RVA: 0x7FFAC30794D0
        public void get_Attributes(){} // RVA: 0x7FFAC2FE9500
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2FBF370
        public void set_AnyAttribute(){} // RVA: 0x7FFAC2FBF380
        public void SetAttributes(){} // RVA: 0x7FFAC2FE9510
        public void .ctor(){} // RVA: 0x7FFAC913A2D0
    }

    public class XmlSchemaComplexContentRestriction : XmlSchemaContent
    {
        public System.Xml.Schema.XmlSchemaParticle BaseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection Particle; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute Attributes; // 0x60
        public System.Xml.XmlQualifiedName AnyAttribute; // 0x68

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAC2F9CD50
        public void set_BaseTypeName(){} // RVA: 0x7FFAC913A410
        public void get_Particle(){} // RVA: 0x7FFAC2FC20E0
        public void set_Particle(){} // RVA: 0x7FFAC30794D0
        public void get_Attributes(){} // RVA: 0x7FFAC2FE9500
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2FBF370
        public void set_AnyAttribute(){} // RVA: 0x7FFAC2FBF380
        public void SetAttributes(){} // RVA: 0x7FFAC2FE9510
        public void .ctor(){} // RVA: 0x7FFAC913A4F0
    }

    public class XmlSchemaComplexType : XmlSchemaType
    {
        public 0x6B163E70 AnyType; // 0x98
        public System.Xml.Schema.XmlSchemaContentModel UntypedAnyType; // 0xA0
        public System.Xml.Schema.XmlSchemaParticle AnyTypeContentValidator; // 0xA8
        public System.Xml.Schema.XmlSchemaObjectCollection IsAbstract; // 0xB0
        public System.Xml.Schema.XmlSchemaAnyAttribute Block; // 0xB8
        public System.Xml.Schema.XmlSchemaParticle IsMixed; // 0xC0
        public 0x6B163E70 ContentModel; // 0xC8
        public System.Xml.Schema.XmlSchemaObjectTable Particle; // 0xD0
        public System.Xml.Schema.XmlSchemaObjectTable Attributes; // 0xD8
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute; // 0xE0
        public System.Xml.Schema.XmlSchemaComplexType ContentType;
        public System.Xml.Schema.XmlSchemaComplexType ContentTypeParticle; // 0x8
        public System.Xml.Schema.XmlSchemaComplexType BlockResolved; // 0x10
        public byte AttributeUses; // 0xE8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC913A630
        public void CreateAnyType(){} // RVA: 0x7FFAC913AB40
        public void .ctor(){} // RVA: 0x7FFAC913B190
        public void get_AnyType(){} // RVA: 0x7FFAC913B250
        public void get_UntypedAnyType(){} // RVA: 0x7FFAC913B2B0
        public void get_AnyTypeContentValidator(){} // RVA: 0x7FFAC913B310
        public void get_IsAbstract(){} // RVA: 0x7FFAC913B390
        public void set_IsAbstract(){} // RVA: 0x7FFAC913B3A0
        public void get_Block(){} // RVA: 0x7FFAC489E530
        public void set_Block(){} // RVA: 0x7FFAC489E540
        public void get_IsMixed(){} // RVA: 0x7FFAC913B3D0
        public void set_IsMixed(){} // RVA: 0x7FFAC913B3E0
        public void get_ContentModel(){} // RVA: 0x7FFAC3543900
        public void set_ContentModel(){} // RVA: 0x7FFAC354E420
        public void get_Particle(){} // RVA: 0x7FFAC354B1A0
        public void set_Particle(){} // RVA: 0x7FFAC334B370
        public void get_Attributes(){} // RVA: 0x7FFAC913B410
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2F8C0B0
        public void set_AnyAttribute(){} // RVA: 0x7FFAC2F8C0C0
        public void get_ContentType(){} // RVA: 0x7FFAC3220660
        public void get_ContentTypeParticle(){} // RVA: 0x7FFAC2F8C120
        public void get_BlockResolved(){} // RVA: 0x7FFAC3641480
        public void get_AttributeUses(){} // RVA: 0x7FFAC913B4D0
        public void get_AttributeWildcard(){} // RVA: 0x7FFAC2FA2900
        public void get_LocalElements(){} // RVA: 0x7FFAC913B590
        public void SetContentTypeParticle(){} // RVA: 0x7FFAC2F8C130
        public void SetBlockResolved(){} // RVA: 0x7FFAC623E970
        public void SetAttributeWildcard(){} // RVA: 0x7FFAC2FA2910
        public void set_HasWildCard(){} // RVA: 0x7FFAC913B650
        public void SetAttributes(){} // RVA: 0x7FFAC2F8C050
        public void ContainsIdAttribute(){} // RVA: 0x7FFAC913B680
        public void Clone(){} // RVA: 0x7FFAC913B900 | overloaded x2
        public void ClearCompiledState(){} // RVA: 0x7FFAC913C320
        public void CloneAttributes(){} // RVA: 0x7FFAC913C4E0
        public void CloneGroupBaseParticles(){} // RVA: 0x7FFAC913C7E0
        public void CloneParticle(){} // RVA: 0x7FFAC913C940
        public void GetResolvedElementForm(){} // RVA: 0x7FFAC913CE80
        public void HasParticleRef(){} // RVA: 0x7FFAC913CEB0
        public void HasAttributeQNameRef(){} // RVA: 0x7FFAC913D230
    }

    public class XmlSchemaContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaContentModel : XmlSchemaAnnotated
    {
        public object Content;

        // ── Methods ──
        public void get_Content(){} // RVA: 0x7FFAC2C58E90
        public void set_Content(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaDatatype : Object
    {
        public object ValueType;
        public object TokenizedType;
        public object Variety;
        public object TypeCode;
        public object HasLexicalFacets;
        public object HasValueFacets;
        public object ValueConverter;
        public object Restriction;
        public object FacetsChecker;
        public object BuiltInWhitespaceFacet;
        public object TypeCodeString;

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFAC2C58E90
        public void get_TokenizedType(){} // RVA: 0x7FFAC2C59960
        public void ParseValue(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void get_Variety(){} // RVA: 0x7FFAC34F9180
        public void get_TypeCode(){} // RVA: 0x7FFAC34F9180
        public void IsDerivedFrom(){} // RVA: 0x7FFAC2F21320
        public void get_HasLexicalFacets(){} // RVA: 0x7FFAC2C59D00
        public void get_HasValueFacets(){} // RVA: 0x7FFAC2C59D00
        public void get_ValueConverter(){} // RVA: 0x7FFAC2C58E90
        public void get_Restriction(){} // RVA: 0x7FFAC2C58E90
        public void Compare(){} // RVA: 0x7FFAC2C637A0
        public void TryParseValue(){} // RVA: 0x7FFAC2C6B140 | overloaded x2
        public void get_FacetsChecker(){} // RVA: 0x7FFAC2C58E90
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC2C59960
        public void DeriveByRestriction(){} // RVA: 0x7FFAC2C6AE80
        public void DeriveByList(){} // RVA: 0x7FFAC2C58F40
        public void VerifySchemaValid(){} // RVA: 0x7FFAC2C79B30
        public void IsEqual(){} // RVA: 0x7FFAC2C5D200
        public void IsComparable(){} // RVA: 0x7FFAC2C59F60
        public void get_TypeCodeString(){} // RVA: 0x7FFAC913D3E0
        public void TypeCodeToString(){} // RVA: 0x7FFAC913D560
        public void ConcatenatedToString(){} // RVA: 0x7FFAC913DBE0
        public void FromXmlTokenizedType(){} // RVA: 0x7FFAC913E200
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7FFAC913E2B0
        public void FromXdrName(){} // RVA: 0x7FFAC913E360
        public void DeriveByUnion(){} // RVA: 0x7FFAC913E520
        public void XdrCanonizeUri(){} // RVA: 0x7FFAC913E580
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaDocumentation : XmlSchemaObject
    {
        public string Source; // 0x38
        public string Language; // 0x40
        public System.Xml.XmlNode[] Markup; // 0x48
        public System.Xml.Schema.XmlSchemaSimpleType languageType;

        // ── Methods ──
        public void set_Source(){} // RVA: 0x7FFAC31D0C20
        public void set_Language(){} // RVA: 0x7FFAC913E910
        public void set_Markup(){} // RVA: 0x7FFAC2F9C740
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC913EA60
    }

    public class XmlSchemaElement : XmlSchemaParticle
    {
        public bool IsAbstract; // 0x78
        public bool Block; // 0x79
        public bool DefaultValue; // 0x7A
        public bool Final; // 0x7B
        public bool FixedValue; // 0x7C
        public 0x6B163E70 Form; // 0x80
        public 0x6B163E70 Name; // 0x84
        public 0x6B164550 IsNillable; // 0x88
        public string HasNillableAttribute; // 0x90
        public string HasAbstractAttribute; // 0x98
        public string RefName; // 0xA0
        public System.Xml.XmlQualifiedName SubstitutionGroup; // 0xA8
        public System.Xml.XmlQualifiedName SchemaTypeName; // 0xB0
        public System.Xml.XmlQualifiedName SchemaType; // 0xB8
        public System.Xml.Schema.XmlSchemaType Constraints; // 0xC0
        public System.Xml.XmlQualifiedName QualifiedName; // 0xC8
        public System.Xml.Schema.XmlSchemaType ElementSchemaType; // 0xD0
        public 0x6B163E70 BlockResolved; // 0xD8
        public 0x6B163E70 FinalResolved; // 0xDC
        public System.Xml.Schema.XmlSchemaObjectCollection HasConstraints; // 0xE0
        public System.Xml.Schema.SchemaElementDecl IsLocalTypeDerivationChecked; // 0xE8

        // ── Methods ──
        public void get_IsAbstract(){} // RVA: 0x7FFAC33CE5C0
        public void set_IsAbstract(){} // RVA: 0x7FFAC913EB80
        public void get_Block(){} // RVA: 0x7FFAC35729C0
        public void set_Block(){} // RVA: 0x7FFAC3572BF0
        public void get_DefaultValue(){} // RVA: 0x7FFAC32EF640
        public void set_DefaultValue(){} // RVA: 0x7FFAC354E360
        public void get_Final(){} // RVA: 0x7FFAC46D5110
        public void set_Final(){} // RVA: 0x7FFAC46D5150
        public void get_FixedValue(){} // RVA: 0x7FFAC354DFB0
        public void set_FixedValue(){} // RVA: 0x7FFAC354E3C0
        public void get_Form(){} // RVA: 0x7FFAC37EE8C0
        public void set_Form(){} // RVA: 0x7FFAC37F9DE0
        public void get_Name(){} // RVA: 0x7FFAC3543900
        public void set_Name(){} // RVA: 0x7FFAC354E420
        public void get_IsNillable(){} // RVA: 0x7FFAC33D1F80
        public void set_IsNillable(){} // RVA: 0x7FFAC913EB90
        public void get_HasNillableAttribute(){} // RVA: 0x7FFAC33D0810
        public void get_HasAbstractAttribute(){} // RVA: 0x7FFAC33CC650
        public void get_RefName(){} // RVA: 0x7FFAC354B1A0
        public void set_RefName(){} // RVA: 0x7FFAC913EBA0
        public void get_SubstitutionGroup(){} // RVA: 0x7FFAC2F8C040
        public void set_SubstitutionGroup(){} // RVA: 0x7FFAC913EC90
        public void get_SchemaTypeName(){} // RVA: 0x7FFAC2F8C0B0
        public void set_SchemaTypeName(){} // RVA: 0x7FFAC913ED80
        public void get_SchemaType(){} // RVA: 0x7FFAC2F8C120
        public void set_SchemaType(){} // RVA: 0x7FFAC2F8C130
        public void get_Constraints(){} // RVA: 0x7FFAC913EE70
        public void get_QualifiedName(){} // RVA: 0x7FFAC3079460
        public void get_ElementSchemaType(){} // RVA: 0x7FFAC303E100
        public void get_BlockResolved(){} // RVA: 0x7FFAC47BB150
        public void get_FinalResolved(){} // RVA: 0x7FFAC913EF30
        public void SetQualifiedName(){} // RVA: 0x7FFAC3079470
        public void SetElementType(){} // RVA: 0x7FFAC303E110
        public void SetBlockResolved(){} // RVA: 0x7FFAC47BB160
        public void SetFinalResolved(){} // RVA: 0x7FFAC913EF40
        public void get_HasConstraints(){} // RVA: 0x7FFAC913EF50
        public void get_IsLocalTypeDerivationChecked(){} // RVA: 0x7FFAC33CFDF0
        public void set_IsLocalTypeDerivationChecked(){} // RVA: 0x7FFAC33C9B20
        public void get_ElementDecl(){} // RVA: 0x7FFAC2FA2970
        public void set_ElementDecl(){} // RVA: 0x7FFAC2FA2980
        public void get_NameAttribute(){} // RVA: 0x7FFAC3543900
        public void set_NameAttribute(){} // RVA: 0x7FFAC354E420
        public void get_NameString(){} // RVA: 0x7FFAC913EFA0
        public void Clone(){} // RVA: 0x7FFAC913EFE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC913F460
    }

    public class XmlSchemaEnumerationFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91410D0
    }

    public class XmlSchemaException : SystemException
    {
        public string GetRes; // 0x90
        public string[] Args; // 0x98
        public string SourceUri; // 0xA0
        public int LineNumber; // 0xA8
        public int LinePosition; // 0xAC
        public System.Xml.Schema.XmlSchemaObject SourceSchemaObject; // 0xB0
        public string Message; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9140C30 | overloaded x14
        public void GetObjectData(){} // RVA: 0x7FFAC913FEB0
        public void CreateMessage(){} // RVA: 0x7FFAC9140E10
        public void get_GetRes(){} // RVA: 0x7FFAC32EF640
        public void get_Args(){} // RVA: 0x7FFAC354DFB0
        public void get_SourceUri(){} // RVA: 0x7FFAC3543900
        public void get_LineNumber(){} // RVA: 0x7FFAC39055C0
        public void get_LinePosition(){} // RVA: 0x7FFAC6539490
        public void get_SourceSchemaObject(){} // RVA: 0x7FFAC2F8C040
        public void SetSource(){} // RVA: 0x7FFAC9140ED0 | overloaded x2
        public void SetSchemaObject(){} // RVA: 0x7FFAC2F8C050
        public void get_Message(){} // RVA: 0x7FFAC9140FC0
    }

    public class XmlSchemaExternal : XmlSchemaObject
    {
        public string SchemaLocation; // 0x38
        public System.Uri Schema; // 0x40
        public System.Xml.Schema.XmlSchema Id; // 0x48
        public string BaseUri; // 0x50
        public System.Xml.XmlAttribute[] IdAttribute; // 0x58
        public 0x6B162870 Compositor; // 0x60

        // ── Methods ──
        public void get_SchemaLocation(){} // RVA: 0x7FFAC31D0140
        public void set_SchemaLocation(){} // RVA: 0x7FFAC31D0C20
        public void get_Schema(){} // RVA: 0x7FFAC2F9C730
        public void set_Schema(){} // RVA: 0x7FFAC2F9C740
        public void get_Id(){} // RVA: 0x7FFAC2FC20E0
        public void set_Id(){} // RVA: 0x7FFAC30794D0
        public void get_BaseUri(){} // RVA: 0x7FFAC2F9E740
        public void set_BaseUri(){} // RVA: 0x7FFAC2F49200
        public void get_IdAttribute(){} // RVA: 0x7FFAC2FC20E0
        public void set_IdAttribute(){} // RVA: 0x7FFAC30794D0
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAC2FE9510
        public void get_Compositor(){} // RVA: 0x7FFAC3138C20
        public void set_Compositor(){} // RVA: 0x7FFAC3138C10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaFacet : XmlSchemaAnnotated
    {
        public string Value; // 0x50
        public bool IsFixed; // 0x58
        public 0x6B164028 FacetType; // 0x5C

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2FC20E0
        public void set_Value(){} // RVA: 0x7FFAC30794D0
        public void get_IsFixed(){} // RVA: 0x7FFAC313F600
        public void set_IsFixed(){} // RVA: 0x7FFAC9140FE0
        public void get_FacetType(){} // RVA: 0x7FFAC313CBA0
        public void set_FacetType(){} // RVA: 0x7FFAC362EB40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141130
    }

    public class XmlSchemaGroup : XmlSchemaAnnotated
    {
        public string Name; // 0x50
        public System.Xml.Schema.XmlSchemaGroupBase Particle; // 0x58
        public System.Xml.Schema.XmlSchemaParticle QualifiedName; // 0x60
        public System.Xml.XmlQualifiedName CanonicalParticle; // 0x68
        public System.Xml.Schema.XmlSchemaGroup Redefined; // 0x70
        public int SelfReferenceCount; // 0x78

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void set_Name(){} // RVA: 0x7FFAC30794D0
        public void get_Particle(){} // RVA: 0x7FFAC2FE9500
        public void set_Particle(){} // RVA: 0x7FFAC2FE9510
        public void get_QualifiedName(){} // RVA: 0x7FFAC2F9CD50
        public void get_CanonicalParticle(){} // RVA: 0x7FFAC2FBF370
        public void set_CanonicalParticle(){} // RVA: 0x7FFAC2FBF380
        public void get_Redefined(){} // RVA: 0x7FFAC2FE9590
        public void set_Redefined(){} // RVA: 0x7FFAC2FE95A0
        public void get_SelfReferenceCount(){} // RVA: 0x7FFAC4596EF0
        public void set_SelfReferenceCount(){} // RVA: 0x7FFAC45963A0
        public void get_NameAttribute(){} // RVA: 0x7FFAC2FC20E0
        public void set_NameAttribute(){} // RVA: 0x7FFAC30794D0
        public void SetQualifiedName(){} // RVA: 0x7FFAC2F9CD60
        public void Clone(){} // RVA: 0x7FFAC9141160 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC91413B0
    }

    public class XmlSchemaGroupBase : XmlSchemaParticle
    {
        public object Items;

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAC2C58E90
        public void SetItems(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC9141460
    }

    public class XmlSchemaGroupRef : XmlSchemaParticle
    {
        public System.Xml.XmlQualifiedName RefName; // 0x78
        public System.Xml.Schema.XmlSchemaGroupBase Particle; // 0x80
        public System.Xml.Schema.XmlSchemaGroup Redefined; // 0x88

        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7FFAC30E5600
        public void set_RefName(){} // RVA: 0x7FFAC91414B0
        public void get_Particle(){} // RVA: 0x7FFAC32EF410
        public void SetParticle(){} // RVA: 0x7FFAC34D4AA0
        public void get_Redefined(){} // RVA: 0x7FFAC2F60010
        public void set_Redefined(){} // RVA: 0x7FFAC354E300
        public void .ctor(){} // RVA: 0x7FFAC9141590
    }

    public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
    {
        public string Name; // 0x50
        public System.Xml.Schema.XmlSchemaXPath Selector; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection Fields; // 0x60
        public System.Xml.XmlQualifiedName QualifiedName; // 0x68
        public System.Xml.Schema.CompiledIdentityConstraint CompiledConstraint; // 0x70

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void set_Name(){} // RVA: 0x7FFAC30794D0
        public void get_Selector(){} // RVA: 0x7FFAC2FE9500
        public void set_Selector(){} // RVA: 0x7FFAC2FE9510
        public void get_Fields(){} // RVA: 0x7FFAC2FBF370
        public void get_QualifiedName(){} // RVA: 0x7FFAC2F9CD50
        public void SetQualifiedName(){} // RVA: 0x7FFAC2F9CD60
        public void get_CompiledConstraint(){} // RVA: 0x7FFAC2FE9590
        public void set_CompiledConstraint(){} // RVA: 0x7FFAC2FE95A0
        public void get_NameAttribute(){} // RVA: 0x7FFAC2FC20E0
        public void set_NameAttribute(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC9141670
    }

    public class XmlSchemaImport : XmlSchemaExternal
    {
        public string Namespace; // 0x68
        public System.Xml.Schema.XmlSchemaAnnotation annotation; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141950
        public void get_Namespace(){} // RVA: 0x7FFAC2F9CD50
        public void set_Namespace(){} // RVA: 0x7FFAC2F9CD60
        public void AddAnnotation(){} // RVA: 0x7FFAC2FE95A0
    }

    public class XmlSchemaInclude : XmlSchemaExternal
    {
        public System.Xml.Schema.XmlSchemaAnnotation annotation; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141960
        public void AddAnnotation(){} // RVA: 0x7FFAC2F9CD60
    }

    public class XmlSchemaInference : Object
    {
        public System.Xml.XmlQualifiedName Occurrence;
        public System.Xml.XmlQualifiedName TypeInference; // 0x8
        public System.Xml.XmlQualifiedName ST_unsignedByte; // 0x10
        public System.Xml.XmlQualifiedName ST_short; // 0x18
        public System.Xml.XmlQualifiedName ST_unsignedShort; // 0x20
        public System.Xml.XmlQualifiedName ST_int; // 0x28
        public System.Xml.XmlQualifiedName ST_unsignedInt; // 0x30
        public System.Xml.XmlQualifiedName ST_long; // 0x38
        public System.Xml.XmlQualifiedName ST_unsignedLong; // 0x40
        public System.Xml.XmlQualifiedName ST_integer; // 0x48
        public System.Xml.XmlQualifiedName ST_decimal; // 0x50
        public System.Xml.XmlQualifiedName ST_float; // 0x58
        public System.Xml.XmlQualifiedName ST_double; // 0x60
        public System.Xml.XmlQualifiedName ST_duration; // 0x68
        public System.Xml.XmlQualifiedName ST_dateTime; // 0x70
        public System.Xml.XmlQualifiedName ST_time; // 0x78
        public System.Xml.XmlQualifiedName ST_date; // 0x80
        public System.Xml.XmlQualifiedName ST_gYearMonth; // 0x88
        public System.Xml.XmlQualifiedName ST_string; // 0x90
        public System.Xml.XmlQualifiedName ST_anySimpleType; // 0x98
        public System.Xml.XmlQualifiedName[] SimpleTypes; // 0xA0
        public System.Xml.Schema.XmlSchema rootSchema; // 0x10
        public System.Xml.Schema.XmlSchemaSet schemaSet; // 0x18
        public System.Xml.XmlReader xtr; // 0x20
        public System.Xml.NameTable nametable; // 0x28
        public string TargetNamespace; // 0x30
        public System.Xml.XmlNamespaceManager NamespaceManager; // 0x38
        public System.Collections.ArrayList schemaList; // 0x40
        public 0x6B162608 occurrence; // 0x48
        public 0x6B162608 typeInference; // 0x4C

        // ── Methods ──
        public void set_Occurrence(){} // RVA: 0x7FFAC2FC20D0
        public void get_Occurrence(){} // RVA: 0x7FFAC2FC20C0
        public void set_TypeInference(){} // RVA: 0x7FFAC489E500
        public void .ctor(){} // RVA: 0x7FFAC90C5B20
        public void InferSchema(){} // RVA: 0x7FFAC90C5D60
        public void InferSchema1(){} // RVA: 0x7FFAC90C5DF0
        public void AddAttribute(){} // RVA: 0x7FFAC90C6860
        public void CreateXmlSchema(){} // RVA: 0x7FFAC90C73C0
        public void AddElement(){} // RVA: 0x7FFAC90C74A0
        public void InferElement(){} // RVA: 0x7FFAC90C8130
        public void CheckSimpleContentExtension(){} // RVA: 0x7FFAC90C9B00
        public void GetEffectiveSchemaType(){} // RVA: 0x7FFAC90C9CB0
        public void FindMatchingElement(){} // RVA: 0x7FFAC90C9EF0
        public void ProcessAttributes(){} // RVA: 0x7FFAC90CB480
        public void MoveAttributes(){} // RVA: 0x7FFAC90CC160 | overloaded x2
        public void FindAttribute(){} // RVA: 0x7FFAC90CC500
        public void FindGlobalElement(){} // RVA: 0x7FFAC90CC770
        public void FindElement(){} // RVA: 0x7FFAC90CC9F0
        public void FindAttributeRef(){} // RVA: 0x7FFAC90CCBA0
        public void FindElementRef(){} // RVA: 0x7FFAC90CCE90
        public void MakeExistingAttributesOptional(){} // RVA: 0x7FFAC90CD0A0
        public void SwitchUseToOptional(){} // RVA: 0x7FFAC90CD170
        public void RefineSimpleType(){} // RVA: 0x7FFAC90CD2F0
        public void InferSimpleType(){} // RVA: 0x7FFAC90CE120
        public void DateTime(){} // RVA: 0x7FFAC90CF2B0
        public void CreateNewElementforChoice(){} // RVA: 0x7FFAC90CF400
        public void GetSchemaType(){} // RVA: 0x7FFAC90CFBB0
        public void SetMinMaxOccurs(){} // RVA: 0x7FFAC90D07A0
        public void .cctor(){} // RVA: 0x7FFAC90D09D0
    }

    public class XmlSchemaInferenceException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90D1EB0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAC90D1DB0
    }

    public class XmlSchemaInfo : Object
    {
        public bool Validity; // 0x10
        public bool IsDefault; // 0x11
        public System.Xml.Schema.XmlSchemaElement IsNil; // 0x18
        public System.Xml.Schema.XmlSchemaAttribute MemberType; // 0x20
        public System.Xml.Schema.XmlSchemaType SchemaType; // 0x28
        public System.Xml.Schema.XmlSchemaSimpleType SchemaElement; // 0x30
        public 0x6B165520 SchemaAttribute; // 0x38
        public 0x6B163DC0 ContentType; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141980 | overloaded x2
        public void get_Validity(){} // RVA: 0x7FFAC358A870
        public void set_Validity(){} // RVA: 0x7FFAC3588350
        public void get_IsDefault(){} // RVA: 0x7FFAC2FEB5E0
        public void set_IsDefault(){} // RVA: 0x7FFAC2FEB5F0
        public void get_IsNil(){} // RVA: 0x7FFAC3771DA0
        public void set_IsNil(){} // RVA: 0x7FFAC3771D90
        public void get_MemberType(){} // RVA: 0x7FFAC31D95E0
        public void set_MemberType(){} // RVA: 0x7FFAC2F4F890
        public void get_SchemaType(){} // RVA: 0x7FFAC2F4F130
        public void set_SchemaType(){} // RVA: 0x7FFAC91419B0
        public void get_SchemaElement(){} // RVA: 0x7FFAC2F247C0
        public void set_SchemaElement(){} // RVA: 0x7FFAC9141A40
        public void get_SchemaAttribute(){} // RVA: 0x7FFAC2F4F0C0
        public void set_SchemaAttribute(){} // RVA: 0x7FFAC9141B00
        public void get_ContentType(){} // RVA: 0x7FFAC33BD4A0
        public void get_XmlType(){} // RVA: 0x7FFAC9141BC0
        public void get_HasDefaultValue(){} // RVA: 0x7FFAC9141BE0
        public void get_IsUnionType(){} // RVA: 0x7FFAC9141C20
        public void Clear(){} // RVA: 0x7FFAC9141C60
    }

    public class XmlSchemaKey : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91417B0
    }

    public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
    {
        public System.Xml.XmlQualifiedName Refer; // 0x78

        // ── Methods ──
        public void get_Refer(){} // RVA: 0x7FFAC30E5600
        public void set_Refer(){} // RVA: 0x7FFAC91417C0
        public void .ctor(){} // RVA: 0x7FFAC91418A0
    }

    public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141090
    }

    public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141100
    }

    public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141110
    }

    public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91410B0
    }

    public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91410E0
    }

    public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91410F0
    }

    public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91410A0
    }

    public class XmlSchemaNotation : XmlSchemaAnnotated
    {
        public string Name; // 0x50
        public string Public; // 0x58
        public string System; // 0x60
        public System.Xml.XmlQualifiedName QualifiedName; // 0x68

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void set_Name(){} // RVA: 0x7FFAC30794D0
        public void get_Public(){} // RVA: 0x7FFAC2FE9500
        public void set_Public(){} // RVA: 0x7FFAC2FE9510
        public void get_System(){} // RVA: 0x7FFAC2FBF370
        public void set_System(){} // RVA: 0x7FFAC2FBF380
        public void get_QualifiedName(){} // RVA: 0x7FFAC2F9CD50
        public void set_QualifiedName(){} // RVA: 0x7FFAC2F9CD60
        public void get_NameAttribute(){} // RVA: 0x7FFAC2FC20E0
        public void set_NameAttribute(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC9141DD0
    }

    public class XmlSchemaNumericFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaObject : Object
    {
        public int LineNumber; // 0x10
        public int LinePosition; // 0x14
        public string SourceUri; // 0x18
        public System.Xml.Serialization.XmlSerializerNamespaces Parent; // 0x20
        public System.Xml.Schema.XmlSchemaObject Namespaces; // 0x28
        public bool IdAttribute; // 0x30

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFAC2F6E5C0
        public void set_LineNumber(){} // RVA: 0x7FFAC2F240C0
        public void get_LinePosition(){} // RVA: 0x7FFAC33D5A20
        public void set_LinePosition(){} // RVA: 0x7FFAC33D4990
        public void get_SourceUri(){} // RVA: 0x7FFAC2F247C0
        public void set_SourceUri(){} // RVA: 0x7FFAC2F87E80
        public void get_Parent(){} // RVA: 0x7FFAC2F4F130
        public void set_Parent(){} // RVA: 0x7FFAC2F22E90
        public void get_Namespaces(){} // RVA: 0x7FFAC9141E80
        public void set_Namespaces(){} // RVA: 0x7FFAC2F4F0D0
        public void OnAdd(){} // RVA: 0x7FFAC2F21310
        public void OnRemove(){} // RVA: 0x7FFAC2F21310
        public void OnClear(){} // RVA: 0x7FFAC2F21310
        public void get_IdAttribute(){} // RVA: 0x7FFAC34F9180
        public void set_IdAttribute(){} // RVA: 0x7FFAC2F21310
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAC2F21310
        public void AddAnnotation(){} // RVA: 0x7FFAC2F21310
        public void get_NameAttribute(){} // RVA: 0x7FFAC34F9180
        public void set_NameAttribute(){} // RVA: 0x7FFAC2F21310
        public void get_IsProcessing(){} // RVA: 0x7FFAC2F47450
        public void set_IsProcessing(){} // RVA: 0x7FFAC2F47460
        public void Clone(){} // RVA: 0x7FFAC9141F20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaObjectCollection : CollectionBase
    {
        public System.Xml.Schema.XmlSchemaObject Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8364240
        public void get_Item(){} // RVA: 0x7FFAC9141FA0
        public void set_Item(){} // RVA: 0x7FFAC9142050
        public void GetEnumerator(){} // RVA: 0x7FFAC91420C0
        public void Add(){} // RVA: 0x7FFAC9142430 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAC91421D0
        public void Remove(){} // RVA: 0x7FFAC9142240
        public void OnInsert(){} // RVA: 0x7FFAC91422A0
        public void OnSet(){} // RVA: 0x7FFAC91422D0
        public void OnClear(){} // RVA: 0x7FFAC9142340
        public void OnRemove(){} // RVA: 0x7FFAC9142370
        public void Clone(){} // RVA: 0x7FFAC91423A0
    }

    public class XmlSchemaObjectEnumerator : Object
    {
        public System.Collections.IEnumerator Current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void MoveNext(){} // RVA: 0x7FFAC9142460
        public void get_Current(){} // RVA: 0x7FFAC91424B0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9142550
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC91425A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC91425F0
    }

    public class XmlSchemaObjectTable : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> Count; // 0x10
        public System.Collections.Generic.List`1<XmlSchemaObjectEntry> Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9142640
        public void Add(){} // RVA: 0x7FFAC91427A0
        public void Insert(){} // RVA: 0x7FFAC9142920
        public void Replace(){} // RVA: 0x7FFAC9142A80
        public void Clear(){} // RVA: 0x7FFAC9142BC0
        public void Remove(){} // RVA: 0x7FFAC9142C50
        public void FindIndexByValue(){} // RVA: 0x7FFAC9142D20
        public void get_Count(){} // RVA: 0x7FFAC9142DD0
        public void Contains(){} // RVA: 0x7FFAC9142E20
        public void get_Item(){} // RVA: 0x7FFAC9142EA0
        public void get_Values(){} // RVA: 0x7FFAC9142F20
        public void GetEnumerator(){} // RVA: 0x7FFAC9142FF0
    }

    public class XmlSchemaParticle : XmlSchemaAnnotated
    {
        public System.Decimal MinOccursString; // 0x50
        public System.Decimal MaxOccursString; // 0x60
        public 0x6B164CE0 MinOccurs; // 0x70
        public System.Xml.Schema.XmlSchemaParticle MaxOccurs;

        // ── Methods ──
        public void get_MinOccursString(){} // RVA: 0x7FFAC9143DD0
        public void set_MinOccursString(){} // RVA: 0x7FFAC9143F10
        public void get_MaxOccursString(){} // RVA: 0x7FFAC9144120
        public void set_MaxOccursString(){} // RVA: 0x7FFAC9144320
        public void get_MinOccurs(){} // RVA: 0x7FFAC6AD4D90
        public void set_MinOccurs(){} // RVA: 0x7FFAC9144630
        public void get_MaxOccurs(){} // RVA: 0x7FFAC5FD8A60
        public void set_MaxOccurs(){} // RVA: 0x7FFAC91448B0
        public void get_IsEmpty(){} // RVA: 0x7FFAC9144BC0
        public void get_NameString(){} // RVA: 0x7FFAC9144C80
        public void GetQualifiedName(){} // RVA: 0x7FFAC9144CC0
        public void .ctor(){} // RVA: 0x7FFAC9144EA0
        public void .cctor(){} // RVA: 0x7FFAC9144F20
    }

    public class XmlSchemaPatternFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91410C0
    }

    public class XmlSchemaRedefine : XmlSchemaExternal
    {
        public System.Xml.Schema.XmlSchemaObjectCollection Items; // 0x68
        public System.Xml.Schema.XmlSchemaObjectTable AttributeGroups; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable SchemaTypes; // 0x78
        public System.Xml.Schema.XmlSchemaObjectTable Groups; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9145070
        public void get_Items(){} // RVA: 0x7FFAC2F9CD50
        public void get_AttributeGroups(){} // RVA: 0x7FFAC2FE9590
        public void get_SchemaTypes(){} // RVA: 0x7FFAC30E5600
        public void get_Groups(){} // RVA: 0x7FFAC32EF410
        public void AddAnnotation(){} // RVA: 0x7FFAC9145290
    }

    public class XmlSchemaSequence : XmlSchemaGroupBase
    {
        public System.Xml.Schema.XmlSchemaObjectCollection Items; // 0x78

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAC30E5600
        public void get_IsEmpty(){} // RVA: 0x7FFAC91377C0
        public void SetItems(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFAC91452F0
    }

    public class XmlSchemaSet : Object
    {
        public System.Xml.XmlNameTable InternalSyncObject; // 0x10
        public System.Xml.Schema.SchemaNames IsCompiled; // 0x18
        public System.Collections.SortedList XmlResolver; // 0x20
        public System.Xml.Schema.ValidationEventHandler CompilationSettings; // 0x28
        public System.Xml.Schema.ValidationEventHandler Count; // 0x30
        public bool GlobalElements; // 0x38
        public System.Collections.Hashtable GlobalAttributes; // 0x40
        public System.Collections.Hashtable GlobalTypes; // 0x48
        public System.Collections.Hashtable SubstitutionGroups; // 0x50
        public bool SchemaLocations; // 0x58
        public System.Xml.Schema.SchemaInfo TypeExtensions; // 0x60
        public System.Xml.XmlReaderSettings CompiledInfo; // 0x68
        public System.Xml.Schema.XmlSchema ReaderSettings; // 0x70
        public System.Xml.Schema.XmlSchemaCompilationSettings SortedSchemas; // 0x78
        public System.Xml.Schema.XmlSchemaObjectTable elements; // 0x80
        public System.Xml.Schema.XmlSchemaObjectTable attributes; // 0x88
        public System.Xml.Schema.XmlSchemaObjectTable schemaTypes; // 0x90
        public System.Xml.Schema.XmlSchemaObjectTable substitutionGroups; // 0x98
        public System.Xml.Schema.XmlSchemaObjectTable typeExtensions; // 0xA0
        public object internalSyncObject; // 0xA8

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC91453D0
        public void .ctor(){} // RVA: 0x7FFAC91454E0 | overloaded x2
        public void add_ValidationEventHandler(){} // RVA: 0x7FFAC9145AD0
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFAC9145CF0
        public void get_IsCompiled(){} // RVA: 0x7FFAC31D95D0
        public void set_XmlResolver(){} // RVA: 0x7FFAC9145E50
        public void get_CompilationSettings(){} // RVA: 0x7FFAC30E5600
        public void set_CompilationSettings(){} // RVA: 0x7FFAC30E06F0
        public void get_Count(){} // RVA: 0x7FFAC9145E70
        public void get_GlobalElements(){} // RVA: 0x7FFAC9145EA0
        public void get_GlobalAttributes(){} // RVA: 0x7FFAC9145F60
        public void get_GlobalTypes(){} // RVA: 0x7FFAC9146020
        public void get_SubstitutionGroups(){} // RVA: 0x7FFAC91460E0
        public void get_SchemaLocations(){} // RVA: 0x7FFAC2F9E740
        public void get_TypeExtensions(){} // RVA: 0x7FFAC91461A0
        public void Add(){} // RVA: 0x7FFAC9148F20 | overloaded x4
        public void RemoveRecursive(){} // RVA: 0x7FFAC9146DE0
        public void Contains(){} // RVA: 0x7FFAC9147770
        public void Compile(){} // RVA: 0x7FFAC91477F0
        public void Reprocess(){} // RVA: 0x7FFAC9148220
        public void CopyTo(){} // RVA: 0x7FFAC9148B60
        public void Schemas(){} // RVA: 0x7FFAC9148CC0 | overloaded x2
        public void FindSchemaByNSAndUrl(){} // RVA: 0x7FFAC9149480
        public void AddSchemaToSet(){} // RVA: 0x7FFAC91497D0
        public void ProcessNewSubstitutionGroups(){} // RVA: 0x7FFAC9149CC0
        public void ResolveSubstitutionGroup(){} // RVA: 0x7FFAC914A060
        public void Remove(){} // RVA: 0x7FFAC914A490
        public void ClearTables(){} // RVA: 0x7FFAC914A880
        public void PreprocessSchema(){} // RVA: 0x7FFAC914A9C0
        public void ParseSchema(){} // RVA: 0x7FFAC914AC70
        public void CopyFromCompiledSet(){} // RVA: 0x7FFAC914AE20
        public void get_CompiledInfo(){} // RVA: 0x7FFAC2FBF370
        public void get_ReaderSettings(){} // RVA: 0x7FFAC2F9CD50
        public void GetResolver(){} // RVA: 0x7FFAC914C1F0
        public void GetEventHandler(){} // RVA: 0x7FFAC31D95E0
        public void GetSchemaNames(){} // RVA: 0x7FFAC914C210
        public void IsSchemaLoaded(){} // RVA: 0x7FFAC914C310
        public void GetSchemaByUri(){} // RVA: 0x7FFAC914D040
        public void GetTargetNamespace(){} // RVA: 0x7FFAC914D290
        public void get_SortedSchemas(){} // RVA: 0x7FFAC2F4F0C0
        public void RemoveSchemaFromCaches(){} // RVA: 0x7FFAC914D2F0
        public void RemoveSchemaFromGlobalTables(){} // RVA: 0x7FFAC914D7C0
        public void AddToTable(){} // RVA: 0x7FFAC914E1D0
        public void VerifyTables(){} // RVA: 0x7FFAC914E540
        public void InternalValidationCallback(){} // RVA: 0x7FFAC914E780
        public void SendValidationEvent(){} // RVA: 0x7FFAC914E7D0
    }

    public class XmlSchemaSimpleContent : XmlSchemaContentModel
    {
        public System.Xml.Schema.XmlSchemaContent Content; // 0x50

        // ── Methods ──
        public void get_Content(){} // RVA: 0x7FFAC2FC20E0
        public void set_Content(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaSimpleContentExtension : XmlSchemaContent
    {
        public System.Xml.Schema.XmlSchemaObjectCollection BaseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaAnyAttribute Attributes; // 0x58
        public System.Xml.XmlQualifiedName AnyAttribute; // 0x60

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAC2FBF370
        public void set_BaseTypeName(){} // RVA: 0x7FFAC914E8A0
        public void get_Attributes(){} // RVA: 0x7FFAC2FC20E0
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2FE9500
        public void set_AnyAttribute(){} // RVA: 0x7FFAC2FE9510
        public void SetAttributes(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC914E980
    }

    public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
    {
        public System.Xml.XmlQualifiedName BaseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType BaseType; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection Facets; // 0x60
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes; // 0x68
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute; // 0x70

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAC2FC20E0
        public void set_BaseTypeName(){} // RVA: 0x7FFAC914EAC0
        public void get_BaseType(){} // RVA: 0x7FFAC2FE9500
        public void set_BaseType(){} // RVA: 0x7FFAC2FE9510
        public void get_Facets(){} // RVA: 0x7FFAC2FBF370
        public void get_Attributes(){} // RVA: 0x7FFAC2F9CD50
        public void get_AnyAttribute(){} // RVA: 0x7FFAC2FE9590
        public void set_AnyAttribute(){} // RVA: 0x7FFAC2FE95A0
        public void SetAttributes(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC914EBA0
    }

    public class XmlSchemaSimpleType : XmlSchemaType
    {
        public System.Xml.Schema.XmlSchemaSimpleTypeContent Content; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC914ED60
        public void get_Content(){} // RVA: 0x7FFAC354DFB0
        public void set_Content(){} // RVA: 0x7FFAC354E3C0
        public void Clone(){} // RVA: 0x7FFAC914ED70
    }

    public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
    {
        public System.Xml.XmlQualifiedName ItemTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType ItemType; // 0x58
        public System.Xml.Schema.XmlSchemaSimpleType BaseItemType; // 0x60

        // ── Methods ──
        public void get_ItemTypeName(){} // RVA: 0x7FFAC2FC20E0
        public void set_ItemTypeName(){} // RVA: 0x7FFAC914EEE0
        public void get_ItemType(){} // RVA: 0x7FFAC2FE9500
        public void set_ItemType(){} // RVA: 0x7FFAC2FE9510
        public void get_BaseItemType(){} // RVA: 0x7FFAC2FBF370
        public void set_BaseItemType(){} // RVA: 0x7FFAC2FBF380
        public void Clone(){} // RVA: 0x7FFAC914EFC0
        public void .ctor(){} // RVA: 0x7FFAC914F120
    }

    public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
    {
        public System.Xml.XmlQualifiedName BaseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType BaseType; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection Facets; // 0x60

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAC2FC20E0
        public void set_BaseTypeName(){} // RVA: 0x7FFAC914F1D0
        public void get_BaseType(){} // RVA: 0x7FFAC2FE9500
        public void set_BaseType(){} // RVA: 0x7FFAC2FE9510
        public void get_Facets(){} // RVA: 0x7FFAC2FBF370
        public void Clone(){} // RVA: 0x7FFAC914F2B0
        public void .ctor(){} // RVA: 0x7FFAC914F410
    }

    public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
    {
        public System.Xml.Schema.XmlSchemaObjectCollection BaseTypes; // 0x50
        public System.Xml.XmlQualifiedName[] MemberTypes; // 0x58
        public System.Xml.Schema.XmlSchemaSimpleType[] BaseMemberTypes; // 0x60

        // ── Methods ──
        public void get_BaseTypes(){} // RVA: 0x7FFAC2FC20E0
        public void get_MemberTypes(){} // RVA: 0x7FFAC2FE9500
        public void set_MemberTypes(){} // RVA: 0x7FFAC2FE9510
        public void get_BaseMemberTypes(){} // RVA: 0x7FFAC2FBF370
        public void SetBaseMemberTypes(){} // RVA: 0x7FFAC2FBF380
        public void Clone(){} // RVA: 0x7FFAC914F560
        public void .ctor(){} // RVA: 0x7FFAC914F840
    }

    public class XmlSchemaSubstitutionGroup : XmlSchemaObject
    {
        public System.Collections.ArrayList Members; // 0x38
        public System.Xml.XmlQualifiedName Examplar; // 0x40

        // ── Methods ──
        public void get_Members(){} // RVA: 0x7FFAC31D0140
        public void get_Examplar(){} // RVA: 0x7FFAC2F9E740
        public void set_Examplar(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC914F8E0
    }

    public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
    {
        public System.Xml.Schema.XmlSchemaChoice Choice; // 0x48

        // ── Methods ──
        public void get_Choice(){} // RVA: 0x7FFAC2F9C730
        public void .ctor(){} // RVA: 0x7FFAC914FA20
    }

    public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141120
    }

    public class XmlSchemaType : XmlSchemaAnnotated
    {
        public string Name; // 0x50
        public 0x6B163E70 Final; // 0x58
        public 0x6B163E70 QualifiedName; // 0x5C
        public System.Xml.Schema.XmlSchemaType FinalResolved; // 0x60
        public System.Xml.Schema.XmlSchemaDatatype BaseXmlSchemaType; // 0x68
        public 0x6B163E70 DerivedBy; // 0x70
        public System.Xml.Schema.SchemaElementDecl Datatype; // 0x78
        public System.Xml.XmlQualifiedName IsMixed; // 0x80
        public System.Xml.Schema.XmlSchemaType TypeCode; // 0x88
        public 0x6B163DC0 ValueConverter; // 0x90

        // ── Methods ──
        public void GetBuiltInSimpleType(){} // RVA: 0x7FFAC914FBA0 | overloaded x2
        public void GetBuiltInComplexType(){} // RVA: 0x7FFAC914FBF0
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void set_Name(){} // RVA: 0x7FFAC30794D0
        public void get_Final(){} // RVA: 0x7FFAC362EA40
        public void set_Final(){} // RVA: 0x7FFAC362EA00
        public void get_QualifiedName(){} // RVA: 0x7FFAC914FD70
        public void get_FinalResolved(){} // RVA: 0x7FFAC3B99E80
        public void get_BaseXmlSchemaType(){} // RVA: 0x7FFAC2FBF370
        public void get_DerivedBy(){} // RVA: 0x7FFAC313CBA0
        public void get_Datatype(){} // RVA: 0x7FFAC2F9CD50
        public void get_IsMixed(){} // RVA: 0x7FFAC2F21320
        public void set_IsMixed(){} // RVA: 0x7FFAC2F21310
        public void get_TypeCode(){} // RVA: 0x7FFAC914FD80
        public void get_ValueConverter(){} // RVA: 0x7FFAC914FE40
        public void get_SchemaContentType(){} // RVA: 0x7FFAC3220660
        public void SetQualifiedName(){} // RVA: 0x7FFAC914FEC0
        public void SetFinalResolved(){} // RVA: 0x7FFAC30B6520
        public void SetBaseSchemaType(){} // RVA: 0x7FFAC2FBF380
        public void SetDerivedBy(){} // RVA: 0x7FFAC362EB40
        public void SetDatatype(){} // RVA: 0x7FFAC2F9CD60
        public void get_ElementDecl(){} // RVA: 0x7FFAC914FF20
        public void set_ElementDecl(){} // RVA: 0x7FFAC914FF30
        public void get_Redefined(){} // RVA: 0x7FFAC2F60010
        public void set_Redefined(){} // RVA: 0x7FFAC354E300
        public void SetContentType(){} // RVA: 0x7FFAC34D2750
        public void IsDerivedFrom(){} // RVA: 0x7FFAC914FF90
        public void IsDerivedFromDatatype(){} // RVA: 0x7FFAC9150120
        public void get_NameAttribute(){} // RVA: 0x7FFAC2FC20E0
        public void set_NameAttribute(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC9150200
    }

    public class XmlSchemaUnique : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91417B0
    }

    public class XmlSchemaValidationException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9150390 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFAC90D1DB0
    }

    public class XmlSchemaValidator : Object
    {
        public System.Xml.Schema.XmlSchemaSet XmlResolver; // 0x10
        public 0x6B1653C0 LineInfoProvider; // 0x18
        public int SourceUri; // 0x1C
        public bool ValidationEventSender; // 0x20
        public bool SchemaSet; // 0x21
        public bool ValidationFlags; // 0x22
        public bool CurrentContentType; // 0x23
        public System.Xml.Schema.SchemaInfo StrictlyAssessed; // 0x28
        public System.Xml.IDtdInfo HasSchema; // 0x30
        public System.Collections.Hashtable HasIdentityConstraints; // 0x38
        public System.Xml.HWStack ProcessIdentityConstraints; // 0x40
        public System.Xml.Schema.ValidationState ReportValidationWarnings; // 0x48
        public 0x6B165418 ProcessSchemaHints; // 0x50
        public System.Collections.Hashtable attPresence; // 0x58
        public System.Xml.Schema.SchemaAttDef wildID; // 0x60
        public System.Collections.Hashtable IDs; // 0x68
        public System.Xml.Schema.IdRefNode idRefListHead; // 0x70
        public System.Xml.XmlQualifiedName contextQName; // 0x78
        public string NsXs; // 0x80
        public string NsXsi; // 0x88
        public string NsXmlNs; // 0x90
        public string NsXml; // 0x98
        public System.Xml.Schema.XmlSchemaObject partialValidationType; // 0xA0
        public System.Text.StringBuilder textValue; // 0xA8
        public System.Xml.Schema.ValidationEventHandler eventHandler; // 0xB0
        public object validationEventSender; // 0xB8
        public System.Xml.XmlNameTable nameTable; // 0xC0
        public System.Xml.IXmlLineInfo positionInfo; // 0xC8
        public System.Xml.IXmlLineInfo dummyPositionInfo; // 0xD0
        public System.Xml.XmlResolver xmlResolver; // 0xD8
        public System.Uri sourceUri; // 0xE0
        public string sourceUriString; // 0xE8
        public System.Xml.IXmlNamespaceResolver nsResolver; // 0xF0
        public 0x6B163D68 processContents; // 0xF8
        public string xsiTypeString; // 0x100
        public string xsiNilString; // 0x108
        public string xsiSchemaLocationString; // 0x110
        public string xsiNoNamespaceSchemaLocationString; // 0x118
        public System.Xml.Schema.XmlSchemaDatatype dtQName;
        public System.Xml.Schema.XmlSchemaDatatype dtCDATA; // 0x8
        public System.Xml.Schema.XmlSchemaDatatype dtStringArray; // 0x10
        public System.Xml.Schema.XmlSchemaParticle[] EmptyParticleArray; // 0x18
        public System.Xml.Schema.XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
        public System.Xml.XmlCharType xmlCharType; // 0x120
        public bool[,] ValidStates; // 0x28
        public string[] MethodNames; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91504A0
        public void Init(){} // RVA: 0x7FFAC91507F0
        public void Reset(){} // RVA: 0x7FFAC9151110
        public void set_XmlResolver(){} // RVA: 0x7FFAC2FA28A0
        public void set_LineInfoProvider(){} // RVA: 0x7FFAC9151230
        public void set_SourceUri(){} // RVA: 0x7FFAC9151300
        public void set_ValidationEventSender(){} // RVA: 0x7FFAC2F8C0C0
        public void add_ValidationEventHandler(){} // RVA: 0x7FFAC91513F0
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFAC91514F0
        public void AddSchema(){} // RVA: 0x7FFAC91515F0
        public void Initialize(){} // RVA: 0x7FFAC9151B80 | overloaded x2
        public void ValidateElement(){} // RVA: 0x7FFAC9151EA0
        public void ValidateAttribute(){} // RVA: 0x7FFAC91524F0 | overloaded x2
        public void ValidateEndOfAttributes(){} // RVA: 0x7FFAC9152F70
        public void ValidateText(){} // RVA: 0x7FFAC91530C0 | overloaded x2
        public void ValidateWhitespace(){} // RVA: 0x7FFAC91535A0 | overloaded x2
        public void ValidateEndElement(){} // RVA: 0x7FFAC9153830
        public void SkipToEndElement(){} // RVA: 0x7FFAC9153840
        public void EndValidation(){} // RVA: 0x7FFAC9153AC0
        public void GetUnspecifiedDefaultAttributes(){} // RVA: 0x7FFAC9153D40
        public void get_SchemaSet(){} // RVA: 0x7FFAC2F3C380
        public void get_ValidationFlags(){} // RVA: 0x7FFAC3157800
        public void get_CurrentContentType(){} // RVA: 0x7FFAC9154480
        public void SetDtdSchemaInfo(){} // RVA: 0x7FFAC91544C0
        public void get_StrictlyAssessed(){} // RVA: 0x7FFAC9154520
        public void get_HasSchema(){} // RVA: 0x7FFAC9154560
        public void GetConcatenatedValue(){} // RVA: 0x7FFAC91545B0
        public void InternalValidateEndElement(){} // RVA: 0x7FFAC91545E0
        public void ProcessSchemaLocations(){} // RVA: 0x7FFAC9154C80
        public void ValidateElementContext(){} // RVA: 0x7FFAC9154FD0
        public void GetSubstitutionGroupHead(){} // RVA: 0x7FFAC91555C0
        public void ValidateAtomicValue(){} // RVA: 0x7FFAC9155BD0 | overloaded x2
        public void GetTypeName(){} // RVA: 0x7FFAC9156060
        public void SaveTextValue(){} // RVA: 0x7FFAC91560D0
        public void Push(){} // RVA: 0x7FFAC9156120
        public void Pop(){} // RVA: 0x7FFAC9156530
        public void FastGetElementDecl(){} // RVA: 0x7FFAC9156730
        public void CheckXsiTypeAndNil(){} // RVA: 0x7FFAC9156A90
        public void ThrowDeclNotFoundWarningOrError(){} // RVA: 0x7FFAC9157210
        public void CheckElementProperties(){} // RVA: 0x7FFAC9157470
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7FFAC9157570
        public void CheckIsXmlAttribute(){} // RVA: 0x7FFAC91575D0
        public void AddXmlNamespaceSchema(){} // RVA: 0x7FFAC9157760
        public void CheckMixedValueConstraint(){} // RVA: 0x7FFAC9157850
        public void LoadSchema(){} // RVA: 0x7FFAC9157980
        public void RecompileSchemaSet(){} // RVA: 0x7FFAC9157DD0
        public void ProcessTokenizedType(){} // RVA: 0x7FFAC9157E90
        public void CheckAttributeValue(){} // RVA: 0x7FFAC9158170
        public void CheckElementValue(){} // RVA: 0x7FFAC9158440
        public void CheckTokenizedTypes(){} // RVA: 0x7FFAC9158780
        public void FindId(){} // RVA: 0x7FFAC9158910
        public void CheckForwardRefs(){} // RVA: 0x7FFAC9158940
        public void get_HasIdentityConstraints(){} // RVA: 0x7FFAC9158AD0
        public void get_ProcessIdentityConstraints(){} // RVA: 0x7FFAC81F6FD0
        public void get_ReportValidationWarnings(){} // RVA: 0x7FFAC81F6A10
        public void get_ProcessSchemaHints(){} // RVA: 0x7FFAC9158AF0
        public void CheckStateTransition(){} // RVA: 0x7FFAC9158B10
        public void ClearPSVI(){} // RVA: 0x7FFAC9158DB0
        public void CheckRequiredAttributes(){} // RVA: 0x7FFAC9158E50
        public void GetSchemaElement(){} // RVA: 0x7FFAC9159120
        public void GetDefaultAttributePrefix(){} // RVA: 0x7FFAC9159270
        public void AddIdentityConstraints(){} // RVA: 0x7FFAC9159520
        public void ElementIdentityConstraints(){} // RVA: 0x7FFAC9159B10
        public void AttributeIdentityConstraints(){} // RVA: 0x7FFAC9159EC0
        public void EndElementIdentityConstraints(){} // RVA: 0x7FFAC915A210
        public void ElementValidationError(){} // RVA: 0x7FFAC915B050
        public void CompleteValidationError(){} // RVA: 0x7FFAC915B860
        public void PrintExpectedElements(){} // RVA: 0x7FFAC915BDB0
        public void PrintNames(){} // RVA: 0x7FFAC915C230
        public void PrintNamesWithNS(){} // RVA: 0x7FFAC915C3D0
        public void EnumerateAny(){} // RVA: 0x7FFAC915CA10
        public void QNameString(){} // RVA: 0x7FFAC915CCA0
        public void BuildElementName(){} // RVA: 0x7FFAC915CD80 | overloaded x2
        public void ProcessEntity(){} // RVA: 0x7FFAC915CEF0
        public void SendValidationEvent(){} // RVA: 0x7FFAC915D9B0 | overloaded x11
        public void .cctor(){} // RVA: 0x7FFAC915DA70
    }

    public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9141140
    }

    public class XmlSchemaXPath : XmlSchemaAnnotated
    {
        public string XPath; // 0x50

        // ── Methods ──
        public void get_XPath(){} // RVA: 0x7FFAC2FC20E0
        public void set_XPath(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlStringConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9172750
        public void Create(){} // RVA: 0x7FFAC91727B0
        public void ToString(){} // RVA: 0x7FFAC9172840
        public void ChangeType(){} // RVA: 0x7FFAC9172D30 | overloaded x2
    }

    public class XmlUnionConverter : XmlBaseConverter
    {
        public System.Xml.Schema.XmlValueConverter[] converters; // 0x28
        public bool hasAtomicMember; // 0x30
        public bool hasListMember; // 0x31

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9180B20
        public void Create(){} // RVA: 0x7FFAC9180EC0
        public void ChangeType(){} // RVA: 0x7FFAC9180F20
    }

    public class XmlUntypedConverter : XmlListConverter
    {
        public bool allowListToList; // 0x30
        public System.Xml.Schema.XmlValueConverter Untyped;
        public System.Xml.Schema.XmlValueConverter UntypedList; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91732B0 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFAC9173540 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFAC91737E0 | overloaded x2
        public void ToDateTimeOffset(){} // RVA: 0x7FFAC9173AF0 | overloaded x2
        public void ToDecimal(){} // RVA: 0x7FFAC9173E10 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFAC9174120 | overloaded x2
        public void ToInt32(){} // RVA: 0x7FFAC91743D0 | overloaded x2
        public void ToInt64(){} // RVA: 0x7FFAC9174690 | overloaded x2
        public void ToSingle(){} // RVA: 0x7FFAC9174940 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9174F70 | overloaded x9
        public void ChangeType(){} // RVA: 0x7FFAC9177990 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAC9179220
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAC9179380
        public void ChangeListType(){} // RVA: 0x7FFAC9179500
        public void SupportsType(){} // RVA: 0x7FFAC9179850
        public void .cctor(){} // RVA: 0x7FFAC9179DD0
    }

    public class XmlValueConverter : Object
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0x7FFAC2C59F60 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFAC2C5E6B0 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFAC2C58F40 | overloaded x6
        public void ToDecimal(){} // overloaded x2
        public void ToDouble(){} // RVA: 0x7FFAC2C5EF00 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFAC2C6DF90 | overloaded x3
        public void ToDateTime(){} // overloaded x7
        public void ToDateTimeOffset(){} // overloaded x3
        public void ToString(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFAC2C6AE80 | overloaded x9
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlValueGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD07E0
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class XsdBuilder : SchemaBuilder
    {
        public 0x6B165AA0[] CurrentElement;
        public 0x6B165AA0[] ParentElement; // 0x8
        public 0x6B165AA0[] ParentContainer; // 0x10
        public 0x6B165AA0[] ElementSubelements; // 0x18
        public 0x6B165AA0[] ComplexTypeSubelements; // 0x20
        public 0x6B165AA0[] SimpleContentSubelements; // 0x28
        public 0x6B165AA0[] SimpleContentExtensionSubelements; // 0x30
        public 0x6B165AA0[] SimpleContentRestrictionSubelements; // 0x38
        public 0x6B165AA0[] ComplexContentSubelements; // 0x40
        public 0x6B165AA0[] ComplexContentExtensionSubelements; // 0x48
        public 0x6B165AA0[] ComplexContentRestrictionSubelements; // 0x50
        public 0x6B165AA0[] SimpleTypeSubelements; // 0x58
        public 0x6B165AA0[] SimpleTypeRestrictionSubelements; // 0x60
        public 0x6B165AA0[] SimpleTypeListSubelements; // 0x68
        public 0x6B165AA0[] SimpleTypeUnionSubelements; // 0x70
        public 0x6B165AA0[] RedefineSubelements; // 0x78
        public 0x6B165AA0[] AttributeGroupSubelements; // 0x80
        public 0x6B165AA0[] GroupSubelements; // 0x88
        public 0x6B165AA0[] AllSubelements; // 0x90
        public 0x6B165AA0[] ChoiceSequenceSubelements; // 0x98
        public 0x6B165AA0[] IdentityConstraintSubelements; // 0xA0
        public 0x6B165AA0[] AnnotationSubelements; // 0xA8
        public 0x6B165AA0[] AnnotatedSubelements; // 0xB0
        public XsdAttributeEntry[] SchemaAttributes; // 0xB8
        public XsdAttributeEntry[] AttributeAttributes; // 0xC0
        public XsdAttributeEntry[] ElementAttributes; // 0xC8
        public XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
        public XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
        public XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
        public XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
        public XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
        public XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
        public XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
        public XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
        public XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
        public XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
        public XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
        public XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
        public XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
        public XsdAttributeEntry[] GroupAttributes; // 0x138
        public XsdAttributeEntry[] GroupRefAttributes; // 0x140
        public XsdAttributeEntry[] ParticleAttributes; // 0x148
        public XsdAttributeEntry[] AnyAttributes; // 0x150
        public XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
        public XsdAttributeEntry[] SelectorAttributes; // 0x160
        public XsdAttributeEntry[] FieldAttributes; // 0x168
        public XsdAttributeEntry[] NotationAttributes; // 0x170
        public XsdAttributeEntry[] IncludeAttributes; // 0x178
        public XsdAttributeEntry[] ImportAttributes; // 0x180
        public XsdAttributeEntry[] FacetAttributes; // 0x188
        public XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
        public XsdAttributeEntry[] DocumentationAttributes; // 0x198
        public XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
        public XsdAttributeEntry[] RedefineAttributes; // 0x1A8
        public XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
        public XsdEntry[] SchemaEntries; // 0x1B8
        public int[] DerivationMethodValues; // 0x1C0
        public string[] DerivationMethodStrings; // 0x1C8
        public string[] FormStringValues; // 0x1D0
        public string[] UseStringValues; // 0x1D8
        public string[] ProcessContentsStringValues; // 0x1E0
        public System.Xml.XmlReader reader; // 0x10
        public System.Xml.PositionInfo positionInfo; // 0x18
        public XsdEntry currentEntry; // 0x20
        public XsdEntry nextEntry; // 0x28
        public bool hasChild; // 0x30
        public System.Xml.HWStack stateHistory; // 0x38
        public System.Collections.Stack containerStack; // 0x40
        public System.Xml.XmlNameTable nameTable; // 0x48
        public System.Xml.Schema.SchemaNames schemaNames; // 0x50
        public System.Xml.XmlNamespaceManager namespaceManager; // 0x58
        public bool canIncludeImport; // 0x60
        public System.Xml.Schema.XmlSchema schema; // 0x68
        public System.Xml.Schema.XmlSchemaObject xso; // 0x70
        public System.Xml.Schema.XmlSchemaElement element; // 0x78
        public System.Xml.Schema.XmlSchemaAny anyElement; // 0x80
        public System.Xml.Schema.XmlSchemaAttribute attribute; // 0x88
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x90
        public System.Xml.Schema.XmlSchemaComplexType complexType; // 0x98
        public System.Xml.Schema.XmlSchemaSimpleType simpleType; // 0xA0
        public System.Xml.Schema.XmlSchemaComplexContent complexContent; // 0xA8
        public System.Xml.Schema.XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
        public System.Xml.Schema.XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
        public System.Xml.Schema.XmlSchemaSimpleContent simpleContent; // 0xC0
        public System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
        public System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
        public System.Xml.Schema.XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
        public System.Xml.Schema.XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
        public System.Xml.Schema.XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
        public System.Xml.Schema.XmlSchemaGroup group; // 0xF0
        public System.Xml.Schema.XmlSchemaGroupRef groupRef; // 0xF8
        public System.Xml.Schema.XmlSchemaAll all; // 0x100
        public System.Xml.Schema.XmlSchemaChoice choice; // 0x108
        public System.Xml.Schema.XmlSchemaSequence sequence; // 0x110
        public System.Xml.Schema.XmlSchemaParticle particle; // 0x118
        public System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup; // 0x120
        public System.Xml.Schema.XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
        public System.Xml.Schema.XmlSchemaNotation notation; // 0x130
        public System.Xml.Schema.XmlSchemaIdentityConstraint identityConstraint; // 0x138
        public System.Xml.Schema.XmlSchemaXPath xpath; // 0x140
        public System.Xml.Schema.XmlSchemaInclude include; // 0x148
        public System.Xml.Schema.XmlSchemaImport import; // 0x150
        public System.Xml.Schema.XmlSchemaAnnotation annotation; // 0x158
        public System.Xml.Schema.XmlSchemaAppInfo appInfo; // 0x160
        public System.Xml.Schema.XmlSchemaDocumentation documentation; // 0x168
        public System.Xml.Schema.XmlSchemaFacet facet; // 0x170
        public System.Xml.XmlNode[] markup; // 0x178
        public System.Xml.Schema.XmlSchemaRedefine redefine; // 0x180
        public System.Xml.Schema.ValidationEventHandler validationEventHandler; // 0x188
        public System.Collections.ArrayList unhandledAttributes; // 0x190
        public System.Collections.Hashtable namespaces; // 0x198

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91813C0
        public void ProcessElement(){} // RVA: 0x7FFAC9181A20
        public void ProcessAttribute(){} // RVA: 0x7FFAC9181D00
        public void IsContentParsed(){} // RVA: 0x7FFAC9182310
        public void ProcessMarkup(){} // RVA: 0x7FFAC39CA130
        public void ProcessCData(){} // RVA: 0x7FFAC9182330
        public void StartChildren(){} // RVA: 0x7FFAC9182380
        public void EndChildren(){} // RVA: 0x7FFAC91825C0
        public void Push(){} // RVA: 0x7FFAC9182610
        public void Pop(){} // RVA: 0x7FFAC9182940
        public void get_CurrentElement(){} // RVA: 0x7FFAC83D29D0
        public void get_ParentElement(){} // RVA: 0x7FFAC9182AA0
        public void get_ParentContainer(){} // RVA: 0x7FFAC9182B30
        public void GetContainer(){} // RVA: 0x7FFAC9182BD0
        public void SetContainer(){} // RVA: 0x7FFAC9182E20
        public void BuildAnnotated_Id(){} // RVA: 0x7FFAC91845A0
        public void BuildSchema_AttributeFormDefault(){} // RVA: 0x7FFAC91845D0
        public void BuildSchema_ElementFormDefault(){} // RVA: 0x7FFAC9184690
        public void BuildSchema_TargetNamespace(){} // RVA: 0x7FFAC9184750
        public void BuildSchema_Version(){} // RVA: 0x7FFAC91847C0
        public void BuildSchema_FinalDefault(){} // RVA: 0x7FFAC9184830
        public void BuildSchema_BlockDefault(){} // RVA: 0x7FFAC91848B0
        public void InitSchema(){} // RVA: 0x7FFAC9184930
        public void InitInclude(){} // RVA: 0x7FFAC91849A0
        public void BuildInclude_SchemaLocation(){} // RVA: 0x7FFAC9184B30
        public void InitImport(){} // RVA: 0x7FFAC9184BA0
        public void BuildImport_Namespace(){} // RVA: 0x7FFAC9184D30
        public void BuildImport_SchemaLocation(){} // RVA: 0x7FFAC9184DA0
        public void InitRedefine(){} // RVA: 0x7FFAC9184E10
        public void BuildRedefine_SchemaLocation(){} // RVA: 0x7FFAC9184FA0
        public void EndRedefine(){} // RVA: 0x7FFAC9185010
        public void InitAttribute(){} // RVA: 0x7FFAC9185030
        public void BuildAttribute_Default(){} // RVA: 0x7FFAC91851D0
        public void BuildAttribute_Fixed(){} // RVA: 0x7FFAC9185240
        public void BuildAttribute_Form(){} // RVA: 0x7FFAC91852B0
        public void BuildAttribute_Use(){} // RVA: 0x7FFAC9185370
        public void BuildAttribute_Ref(){} // RVA: 0x7FFAC9185430
        public void BuildAttribute_Name(){} // RVA: 0x7FFAC9185570
        public void BuildAttribute_Type(){} // RVA: 0x7FFAC91855E0
        public void InitElement(){} // RVA: 0x7FFAC9185720
        public void BuildElement_Abstract(){} // RVA: 0x7FFAC9185920
        public void BuildElement_Block(){} // RVA: 0x7FFAC91859A0
        public void BuildElement_Default(){} // RVA: 0x7FFAC9185A20
        public void BuildElement_Form(){} // RVA: 0x7FFAC9185A90
        public void BuildElement_SubstitutionGroup(){} // RVA: 0x7FFAC9185B50
        public void BuildElement_Final(){} // RVA: 0x7FFAC9185C90
        public void BuildElement_Fixed(){} // RVA: 0x7FFAC9185D10
        public void BuildElement_MaxOccurs(){} // RVA: 0x7FFAC9185D80
        public void BuildElement_MinOccurs(){} // RVA: 0x7FFAC9185DB0
        public void BuildElement_Name(){} // RVA: 0x7FFAC9185DE0
        public void BuildElement_Nillable(){} // RVA: 0x7FFAC9185E50
        public void BuildElement_Ref(){} // RVA: 0x7FFAC9185ED0
        public void BuildElement_Type(){} // RVA: 0x7FFAC9186010
        public void InitSimpleType(){} // RVA: 0x7FFAC9186150
        public void BuildSimpleType_Name(){} // RVA: 0x7FFAC91866E0
        public void BuildSimpleType_Final(){} // RVA: 0x7FFAC9186750
        public void InitSimpleTypeUnion(){} // RVA: 0x7FFAC91867D0
        public void BuildSimpleTypeUnion_MemberTypes(){} // RVA: 0x7FFAC9186A30
        public void InitSimpleTypeList(){} // RVA: 0x7FFAC9186C30
        public void BuildSimpleTypeList_ItemType(){} // RVA: 0x7FFAC9186DF0
        public void InitSimpleTypeRestriction(){} // RVA: 0x7FFAC9186F30
        public void BuildSimpleTypeRestriction_Base(){} // RVA: 0x7FFAC91870F0
        public void InitComplexType(){} // RVA: 0x7FFAC9187230
        public void BuildComplexType_Abstract(){} // RVA: 0x7FFAC91874C0
        public void BuildComplexType_Block(){} // RVA: 0x7FFAC9187550
        public void BuildComplexType_Final(){} // RVA: 0x7FFAC91875D0
        public void BuildComplexType_Mixed(){} // RVA: 0x7FFAC9187650
        public void BuildComplexType_Name(){} // RVA: 0x7FFAC91876E0
        public void InitComplexContent(){} // RVA: 0x7FFAC9187750
        public void BuildComplexContent_Mixed(){} // RVA: 0x7FFAC9187970
        public void InitComplexContentExtension(){} // RVA: 0x7FFAC91879F0
        public void BuildComplexContentExtension_Base(){} // RVA: 0x7FFAC9187CB0
        public void InitComplexContentRestriction(){} // RVA: 0x7FFAC9187DF0
        public void BuildComplexContentRestriction_Base(){} // RVA: 0x7FFAC9188050
        public void InitSimpleContent(){} // RVA: 0x7FFAC9188190
        public void InitSimpleContentExtension(){} // RVA: 0x7FFAC91883B0
        public void BuildSimpleContentExtension_Base(){} // RVA: 0x7FFAC9188550
        public void InitSimpleContentRestriction(){} // RVA: 0x7FFAC9188690
        public void BuildSimpleContentRestriction_Base(){} // RVA: 0x7FFAC91889D0
        public void InitAttributeGroup(){} // RVA: 0x7FFAC9188B10
        public void BuildAttributeGroup_Name(){} // RVA: 0x7FFAC9188CB0
        public void InitAttributeGroupRef(){} // RVA: 0x7FFAC9188D20
        public void BuildAttributeGroupRef_Ref(){} // RVA: 0x7FFAC9188ED0
        public void InitAnyAttribute(){} // RVA: 0x7FFAC9189010
        public void BuildAnyAttribute_Namespace(){} // RVA: 0x7FFAC91895A0
        public void BuildAnyAttribute_ProcessContents(){} // RVA: 0x7FFAC9189610
        public void InitGroup(){} // RVA: 0x7FFAC91896D0
        public void BuildGroup_Name(){} // RVA: 0x7FFAC91898F0
        public void InitGroupRef(){} // RVA: 0x7FFAC9189960
        public void BuildParticle_MaxOccurs(){} // RVA: 0x7FFAC9189BA0
        public void BuildParticle_MinOccurs(){} // RVA: 0x7FFAC9189BD0
        public void BuildGroupRef_Ref(){} // RVA: 0x7FFAC9189C00
        public void InitAll(){} // RVA: 0x7FFAC9189D40
        public void InitChoice(){} // RVA: 0x7FFAC9189EB0
        public void InitSequence(){} // RVA: 0x7FFAC918A020
        public void InitAny(){} // RVA: 0x7FFAC918A190
        public void BuildAny_Namespace(){} // RVA: 0x7FFAC918A340
        public void BuildAny_ProcessContents(){} // RVA: 0x7FFAC918A3B0
        public void InitNotation(){} // RVA: 0x7FFAC918A470
        public void BuildNotation_Name(){} // RVA: 0x7FFAC918A660
        public void BuildNotation_Public(){} // RVA: 0x7FFAC918A6D0
        public void BuildNotation_System(){} // RVA: 0x7FFAC918A740
        public void InitFacet(){} // RVA: 0x7FFAC918A7B0
        public void BuildFacet_Fixed(){} // RVA: 0x7FFAC918ABA0
        public void BuildFacet_Value(){} // RVA: 0x7FFAC918AC30
        public void InitIdentityConstraint(){} // RVA: 0x7FFAC918ACA0
        public void BuildIdentityConstraint_Name(){} // RVA: 0x7FFAC918B110
        public void BuildIdentityConstraint_Refer(){} // RVA: 0x7FFAC918B180
        public void InitSelector(){} // RVA: 0x7FFAC918B380
        public void BuildSelector_XPath(){} // RVA: 0x7FFAC918B540
        public void InitField(){} // RVA: 0x7FFAC918B5B0
        public void BuildField_XPath(){} // RVA: 0x7FFAC918B540
        public void InitAnnotation(){} // RVA: 0x7FFAC918B750
        public void InitAppinfo(){} // RVA: 0x7FFAC918B970
        public void BuildAppinfo_Source(){} // RVA: 0x7FFAC918BB80
        public void EndAppinfo(){} // RVA: 0x7FFAC918BC40
        public void InitDocumentation(){} // RVA: 0x7FFAC918BCB0
        public void BuildDocumentation_Source(){} // RVA: 0x7FFAC918BEC0
        public void BuildDocumentation_XmlLang(){} // RVA: 0x7FFAC918BF80
        public void EndDocumentation(){} // RVA: 0x7FFAC918C1C0
        public void AddAttribute(){} // RVA: 0x7FFAC918C230
        public void AddParticle(){} // RVA: 0x7FFAC918C4D0
        public void GetNextState(){} // RVA: 0x7FFAC918C920
        public void IsSkipableElement(){} // RVA: 0x7FFAC918CAF0
        public void SetMinOccurs(){} // RVA: 0x7FFAC918CB20
        public void SetMaxOccurs(){} // RVA: 0x7FFAC918CB80
        public void ParseBoolean(){} // RVA: 0x7FFAC918CBE0
        public void ParseEnum(){} // RVA: 0x7FFAC918CC80
        public void ParseQName(){} // RVA: 0x7FFAC918CDA0
        public void ParseBlockFinalEnum(){} // RVA: 0x7FFAC918CFF0
        public void ParseUriReference(){} // RVA: 0x7FFAC44F81E0
        public void SendValidationEvent(){} // RVA: 0x7FFAC918D7C0 | overloaded x5
        public void RecordPosition(){} // RVA: 0x7FFAC918D7D0
        public void .cctor(){} // RVA: 0x7FFAC918D950
    }

    public class XsdDateTime : ValueType
    {
        public System.DateTime InternalTypeCode; // 0x10
        public uint InternalKind; // 0x18
        public int Year;
        public int Month; // 0x4
        public int Day; // 0x8
        public int Hour; // 0xC
        public int Minute; // 0x10
        public int Second; // 0x14
        public int Fraction; // 0x18
        public int ZoneHour; // 0x1C
        public int ZoneMinute; // 0x20
        public int LzHH_mm_; // 0x24
        public int LzHH_mm_ss; // 0x28
        public int Lz_; // 0x2C
        public int Lz_zz; // 0x30
        public int Lz_zz_; // 0x34
        public int Lz_zz_zz; // 0x38
        public int Lz__; // 0x3C
        public int Lz__mm; // 0x40
        public int Lz__mm_; // 0x44
        public int Lz__mm__; // 0x48
        public int Lz__mm_dd; // 0x4C
        public int Lz___; // 0x50
        public int Lz___dd; // 0x54
        public 0x6B1655D0[] typeCodes; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91942A0 | overloaded x5
        public void InitiateXsdDateTime(){} // RVA: 0x7FFAC9193CA0
        public void TryParse(){} // RVA: 0x7FFAC9193DE0
        public void get_InternalTypeCode(){} // RVA: 0x7FFAC9194530
        public void get_InternalKind(){} // RVA: 0x7FFAC8507500
        public void get_Year(){} // RVA: 0x7FFAC9194540
        public void get_Month(){} // RVA: 0x7FFAC91945D0
        public void get_Day(){} // RVA: 0x7FFAC9194660
        public void get_Hour(){} // RVA: 0x7FFAC91946F0
        public void get_Minute(){} // RVA: 0x7FFAC9194740
        public void get_Second(){} // RVA: 0x7FFAC9194790
        public void get_Fraction(){} // RVA: 0x7FFAC91947E0
        public void get_ZoneHour(){} // RVA: 0x7FFAC3AD01E0
        public void get_ZoneMinute(){} // RVA: 0x7FFAC3AD0210
        public void op_Implicit(){} // RVA: 0x7FFAC91952D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9195820
        public void PrintDate(){} // RVA: 0x7FFAC9195E20
        public void PrintTime(){} // RVA: 0x7FFAC91960C0
        public void PrintZone(){} // RVA: 0x7FFAC9196520
        public void IntToCharArray(){} // RVA: 0x7FFAC9196880
        public void ShortToCharArray(){} // RVA: 0x7FFAC9196920
        public void .cctor(){} // RVA: 0x7FFAC91969A0
    }

    public class XsdDuration : ValueType
    {
        public int IsNegative; // 0x10
        public int Years; // 0x14
        public int Months; // 0x18
        public int Days; // 0x1C
        public int Hours; // 0x20
        public int Minutes; // 0x24
        public uint Seconds; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9199370 | overloaded x5
        public void get_IsNegative(){} // RVA: 0x7FFAC9199420
        public void get_Years(){} // RVA: 0x7FFAC4420210
        public void get_Months(){} // RVA: 0x7FFAC44202A0
        public void get_Days(){} // RVA: 0x7FFAC49C7500
        public void get_Hours(){} // RVA: 0x7FFAC49C7520
        public void get_Minutes(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Seconds(){} // RVA: 0x7FFAC33D5A20
        public void get_Nanoseconds(){} // RVA: 0x7FFAC9199430
        public void ToTimeSpan(){} // RVA: 0x7FFAC9199490 | overloaded x2
        public void TryToTimeSpan(){} // RVA: 0x7FFAC91994F0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9199B20 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFAC9199FE0 | overloaded x2
        public void TryParseDigits(){} // RVA: 0x7FFAC919ABA0
    }

    public class XsdSimpleValue : Object
    {
        public System.Xml.Schema.XmlSchemaSimpleType XmlType; // 0x10
        public object TypedValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_XmlType(){} // RVA: 0x7FFAC2F3C380
        public void get_TypedValue(){} // RVA: 0x7FFAC2F247C0
    }

    public class XsdValidator : BaseValidator
    {
        public int IsInlineSchemaStarted; // 0x80
        public System.Xml.HWStack HasSchema; // 0x88
        public System.Collections.Hashtable PreserveWhitespace; // 0x90
        public System.Xml.XmlNamespaceManager HasIdentityConstraints; // 0x98
        public bool bManageNamespaces; // 0xA0
        public System.Collections.Hashtable IDs; // 0xA8
        public System.Xml.Schema.IdRefNode idRefListHead; // 0xB0
        public System.Xml.Schema.Parser inlineSchemaParser; // 0xB8
        public 0x6B163D68 processContents; // 0xC0
        public System.Xml.Schema.XmlSchemaDatatype dtCDATA;
        public System.Xml.Schema.XmlSchemaDatatype dtQName; // 0x8
        public System.Xml.Schema.XmlSchemaDatatype dtStringArray; // 0x10
        public string NsXmlNs; // 0xC8
        public string NsXs; // 0xD0
        public string NsXsi; // 0xD8
        public string XsiType; // 0xE0
        public string XsiNil; // 0xE8
        public string XsiSchemaLocation; // 0xF0
        public string XsiNoNamespaceSchemaLocation; // 0xF8
        public string XsdSchema; // 0x100

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC919AD20 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC919AD50
        public void Validate(){} // RVA: 0x7FFAC919B590
        public void CompleteValidation(){} // RVA: 0x7FFAC919B670
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7FFAC91309D0
        public void ProcessInlineSchema(){} // RVA: 0x7FFAC919B810
        public void ValidateElement(){} // RVA: 0x7FFAC919BAE0
        public void ValidateChildElement(){} // RVA: 0x7FFAC919BCF0
        public void ProcessElement(){} // RVA: 0x7FFAC919BF70
        public void ProcessXsiAttributes(){} // RVA: 0x7FFAC919C3C0
        public void ValidateEndElement(){} // RVA: 0x7FFAC919CCF0
        public void FastGetElementDecl(){} // RVA: 0x7FFAC919CF50
        public void ThoroughGetElementDecl(){} // RVA: 0x7FFAC919D040
        public void ValidateStartElement(){} // RVA: 0x7FFAC919D580
        public void ValidateEndStartElement(){} // RVA: 0x7FFAC919DF00
        public void LoadSchemaFromLocation(){} // RVA: 0x7FFAC919E360
        public void LoadSchema(){} // RVA: 0x7FFAC919E960
        public void get_HasSchema(){} // RVA: 0x7FFAC9132740
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAC9132760
        public void ProcessTokenizedType(){} // RVA: 0x7FFAC919EB50
        public void CheckValue(){} // RVA: 0x7FFAC919EE50
        public void AddID(){} // RVA: 0x7FFAC919F400
        public void FindId(){} // RVA: 0x7FFAC91339F0
        public void IsXSDRoot(){} // RVA: 0x7FFAC919F500
        public void Push(){} // RVA: 0x7FFAC919F520
        public void Pop(){} // RVA: 0x7FFAC919F890
        public void CheckForwardRefs(){} // RVA: 0x7FFAC919B670
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7FFAC919FA10
        public void get_HasIdentityConstraints(){} // RVA: 0x7FFAC919FA70
        public void AddIdentityConstraints(){} // RVA: 0x7FFAC919FA80
        public void ElementIdentityConstraints(){} // RVA: 0x7FFAC91A00E0
        public void AttributeIdentityConstraints(){} // RVA: 0x7FFAC91A0520
        public void UnWrapUnion(){} // RVA: 0x7FFAC91A08B0
        public void EndElementIdentityConstraints(){} // RVA: 0x7FFAC91A0930
        public void .cctor(){} // RVA: 0x7FFAC91A1750
    }

}