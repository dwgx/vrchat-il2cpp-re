// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 97
// Methods: 1524

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XdrBuilder : SchemaBuilder
    {
        public int[] S_XDR_Root_Element;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874CD700
        public void ProcessElement(){} // RVA: 0x7FFE874CDE20
        public void ProcessAttribute(){} // RVA: 0x7FFE874CE0E0
        public void set_XmlResolver(){} // RVA: 0x7FFE81166130
        public void LoadSchema(){} // RVA: 0x7FFE874CE680
        public void IsXdrSchema(){} // RVA: 0x7FFE874CEBC0
        public void IsContentParsed(){} // RVA: 0x7FFE811E0850
        public void ProcessMarkup(){} // RVA: 0x7FFE874CEEF0
        public void ProcessCData(){} // RVA: 0x7FFE874CEF50
        public void StartChildren(){} // RVA: 0x7FFE874CF020
        public void EndChildren(){} // RVA: 0x7FFE874CF060
        public void Push(){} // RVA: 0x7FFE874CF1A0
        public void Pop(){} // RVA: 0x7FFE874CF230
        public void PushGroupInfo(){} // RVA: 0x7FFE874CF350
        public void PopGroupInfo(){} // RVA: 0x7FFE874CF400
        public void XDR_InitRoot(){} // RVA: 0x7FFE874CF520
        public void XDR_BuildRoot_Name(){} // RVA: 0x7FFE874CF680
        public void XDR_BuildRoot_ID(){} // RVA: 0x7FFE810FB310
        public void XDR_BeginRoot(){} // RVA: 0x7FFE874CF7E0
        public void XDR_EndRoot(){} // RVA: 0x7FFE874CF9B0
        public void XDR_InitElementType(){} // RVA: 0x7FFE874CFEE0
        public void XDR_BuildElementType_Name(){} // RVA: 0x7FFE874D01A0
        public void XDR_BuildElementType_Content(){} // RVA: 0x7FFE874D04C0
        public void XDR_BuildElementType_Model(){} // RVA: 0x7FFE874D0570
        public void XDR_BuildElementType_Order(){} // RVA: 0x7FFE874D0700
        public void XDR_BuildElementType_DtType(){} // RVA: 0x7FFE874D07C0
        public void XDR_BuildElementType_DtValues(){} // RVA: 0x7FFE874D0990
        public void XDR_BuildElementType_DtMaxLength(){} // RVA: 0x7FFE874D0AE0
        public void XDR_BuildElementType_DtMinLength(){} // RVA: 0x7FFE874D0B70
        public void XDR_BeginElementType(){} // RVA: 0x7FFE874D0C00
        public void XDR_EndElementType(){} // RVA: 0x7FFE874D0FA0
        public void XDR_InitAttributeType(){} // RVA: 0x7FFE874D16D0
        public void XDR_BuildAttributeType_Name(){} // RVA: 0x7FFE874D18D0
        public void XDR_BuildAttributeType_Required(){} // RVA: 0x7FFE874D1D30
        public void XDR_BuildAttributeType_Default(){} // RVA: 0x7FFE874D1DB0
        public void XDR_BuildAttributeType_DtType(){} // RVA: 0x7FFE874D1E20
        public void XDR_BuildAttributeType_DtValues(){} // RVA: 0x7FFE874D2090
        public void XDR_BuildAttributeType_DtMaxLength(){} // RVA: 0x7FFE874D21E0
        public void XDR_BuildAttributeType_DtMinLength(){} // RVA: 0x7FFE874D2270
        public void XDR_BeginAttributeType(){} // RVA: 0x7FFE874D2300
        public void XDR_EndAttributeType(){} // RVA: 0x7FFE874D23C0
        public void XDR_InitElement(){} // RVA: 0x7FFE874D2800
        public void XDR_BuildElement_Type(){} // RVA: 0x7FFE874D28F0
        public void XDR_BuildElement_MinOccurs(){} // RVA: 0x7FFE874D2AE0
        public void XDR_BuildElement_MaxOccurs(){} // RVA: 0x7FFE874D2B60
        public void XDR_EndElement(){} // RVA: 0x7FFE874D2BE0
        public void XDR_InitAttribute(){} // RVA: 0x7FFE874D2D20
        public void XDR_BuildAttribute_Type(){} // RVA: 0x7FFE874D2DF0
        public void XDR_BuildAttribute_Required(){} // RVA: 0x7FFE874D2FA0
        public void XDR_BuildAttribute_Default(){} // RVA: 0x7FFE874D3030
        public void XDR_BeginAttribute(){} // RVA: 0x7FFE874D30A0
        public void XDR_EndAttribute(){} // RVA: 0x7FFE874D3740
        public void XDR_InitGroup(){} // RVA: 0x7FFE874D3770
        public void XDR_BuildGroup_Order(){} // RVA: 0x7FFE874D3950
        public void XDR_BuildGroup_MinOccurs(){} // RVA: 0x7FFE874D3A40
        public void XDR_BuildGroup_MaxOccurs(){} // RVA: 0x7FFE874D3AD0
        public void XDR_EndGroup(){} // RVA: 0x7FFE874D3B60
        public void XDR_InitElementDtType(){} // RVA: 0x7FFE874D3E30
        public void XDR_EndElementDtType(){} // RVA: 0x7FFE874D3F40
        public void XDR_InitAttributeDtType(){} // RVA: 0x7FFE874D4110
        public void XDR_EndAttributeDtType(){} // RVA: 0x7FFE874D41B0
        public void GetNextState(){} // RVA: 0x7FFE874D42E0
        public void IsSkipableElement(){} // RVA: 0x7FFE874D44D0
        public void IsSkipableAttribute(){} // RVA: 0x7FFE874D45D0
        public void GetOrder(){} // RVA: 0x7FFE874D4740
        public void AddOrder(){} // RVA: 0x7FFE874D4900
        public void IsYes(){} // RVA: 0x7FFE874D49C0
        public void ParseMinOccurs(){} // RVA: 0x7FFE874D4B40
        public void ParseMaxOccurs(){} // RVA: 0x7FFE874D4C80
        public void HandleMinMax(){} // RVA: 0x7FFE874D4DE0
        public void ParseDtMaxLength(){} // RVA: 0x7FFE874D4E10
        public void ParseDtMinLength(){} // RVA: 0x7FFE874D4F90
        public void CompareMinMaxLength(){} // RVA: 0x7FFE874D5110
        public void ParseInteger(){} // RVA: 0x7FFE874D5190
        public void XDR_CheckAttributeDefault(){} // RVA: 0x7FFE874D51D0
        public void SetAttributePresence(){} // RVA: 0x7FFE874D52E0
        public void GetContent(){} // RVA: 0x7FFE874D5330
        public void GetModel(){} // RVA: 0x7FFE874D5540
        public void CheckDatatype(){} // RVA: 0x7FFE874D5660
        public void CheckDefaultAttValue(){} // RVA: 0x7FFE874D57F0
        public void IsGlobal(){} // RVA: 0x7FFE874D5960
        public void SendValidationEvent(){} // RVA: 0x7FFE874D5C30 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFE874D5D10
    }

    public class XdrValidator : BaseValidator
    {
        public System.Xml.HWStack validationStack; // 0x80
        public System.Collections.Hashtable attPresence; // 0x88
        public System.Xml.XmlQualifiedName name; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874D8460 | overloaded x2
        public void Init(){} // RVA: 0x7FFE874D8560
        public void Validate(){} // RVA: 0x7FFE874D8990
        public void ValidateElement(){} // RVA: 0x7FFE874D8A70
        public void ValidateChildElement(){} // RVA: 0x7FFE874D8FB0
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7FFE874D9180
        public void ProcessInlineSchema(){} // RVA: 0x7FFE874D9190
        public void ProcessElement(){} // RVA: 0x7FFE874D94E0
        public void ValidateEndElement(){} // RVA: 0x7FFE874D9600
        public void ThoroughGetElementDecl(){} // RVA: 0x7FFE874D99D0
        public void ValidateStartElement(){} // RVA: 0x7FFE874D9E00
        public void ValidateEndStartElement(){} // RVA: 0x7FFE874DA320
        public void LoadSchemaFromLocation(){} // RVA: 0x7FFE874DA6E0
        public void LoadSchema(){} // RVA: 0x7FFE874DAD30
        public void get_HasSchema(){} // RVA: 0x7FFE874DAEF0
        public void get_PreserveWhitespace(){} // RVA: 0x7FFE874DAF10
        public void ProcessTokenizedType(){} // RVA: 0x7FFE874DAF60
        public void CompleteValidation(){} // RVA: 0x7FFE874DB260
        public void CheckValue(){} // RVA: 0x7FFE874DB4F0
        public void CheckDefaultValue(){} // RVA: 0x7FFE874DBBC0
        public void AddID(){} // RVA: 0x7FFE874DC0A0
        public void FindId(){} // RVA: 0x7FFE874DC1A0
        public void Push(){} // RVA: 0x7FFE874DC1D0
        public void Pop(){} // RVA: 0x7FFE874DC4C0
        public void CheckForwardRefs(){} // RVA: 0x7FFE874DC610
        public void QualifiedName(){} // RVA: 0x7FFE874DC7B0
    }

    public class XmlAnyConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87522710
        public void ToBoolean(){} // RVA: 0x7FFE87522910
        public void ToDateTime(){} // RVA: 0x7FFE87522B00
        public void ToDateTimeOffset(){} // RVA: 0x7FFE87522CF0
        public void ToDecimal(){} // RVA: 0x7FFE87522F40
        public void ToDouble(){} // RVA: 0x7FFE87523190
        public void ToInt32(){} // RVA: 0x7FFE87523380
        public void ToInt64(){} // RVA: 0x7FFE87523570
        public void ToSingle(){} // RVA: 0x7FFE87523760
        public void ChangeType(){} // RVA: 0x7FFE87524BB0 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFE87526580
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFE875266E0
        public void ToNavigator(){} // RVA: 0x7FFE87526860
        public void .cctor(){} // RVA: 0x7FFE87526900
    }

    public class XmlAnyListConverter : XmlListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87526AE0
        public void ChangeType(){} // RVA: 0x7FFE87526AF0
        public void .cctor(){} // RVA: 0x7FFE87526D80
    }

    public class XmlAtomicValue : XPathItem
    {
        public System.Xml.Schema.XmlSchemaType xmlType; // 0x10
        public object objVal; // 0x18
        public 0x664BA72C clrType; // 0x20
        public Union unionVal; // 0x28
        public NamespacePrefixForQName nsPrefix; // 0x30
        public object field_5; // 0x53A
        public object field_6; // 0x53B
        public object field_7; // 0x53C
        public object field_8; // 0x53D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874DD260 | overloaded x9
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE827C4A80
        public void get_XmlType(){} // RVA: 0x7FFE81116380
        public void get_ValueType(){} // RVA: 0x7FFE874DD510
        public void get_TypedValue(){} // RVA: 0x7FFE874DD550
        public void get_ValueAsBoolean(){} // RVA: 0x7FFE874DD760
        public void get_ValueAsDateTime(){} // RVA: 0x7FFE874DD870
        public void get_ValueAsDouble(){} // RVA: 0x7FFE874DD980
        public void get_ValueAsInt(){} // RVA: 0x7FFE874DDA90
        public void get_ValueAsLong(){} // RVA: 0x7FFE874DDBA0
        public void ValueAs(){} // RVA: 0x7FFE874DDCB0
        public void get_Value(){} // RVA: 0x7FFE874DDF20
        public void ToString(){} // RVA: 0x7FFE811AFBE0
        public void GetPrefixFromQName(){} // RVA: 0x7FFE874DE060
    }

    public class XmlBaseConverter : XmlValueConverter
    {
        public System.Xml.Schema.XmlSchemaType schemaType; // 0x10
        public 0x6655E654 typeCode; // 0x18
        public System.Type clrTypeDefault; // 0x20
        public System.Type ICollectionType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87506CD0 | overloaded x4
        public void ToBoolean(){} // RVA: 0x7FFE87507280 | overloaded x6
        public void ToDateTime(){} // RVA: 0x7FFE87507910 | overloaded x7
        public void ToDateTimeOffset(){} // RVA: 0x7FFE87507BD0 | overloaded x3
        public void ToDecimal(){} // RVA: 0x7FFE87507D90 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFE87508340 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFE875088B0 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFE87508E20 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFE875090C0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE875099E0 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFE87509D80 | overloaded x8
        public void get_SchemaType(){} // RVA: 0x7FFE81116380
        public void get_TypeCode(){} // RVA: 0x7FFE813DB630
        public void get_XmlTypeName(){} // RVA: 0x7FFE87509DB0
        public void get_DefaultClrType(){} // RVA: 0x7FFE811290C0
        public void IsDerivedFrom(){} // RVA: 0x7FFE87509EC0
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFE87509F70
        public void QNameToString(){} // RVA: 0x7FFE8750BF50 | overloaded x2
        public void ChangeListType(){} // RVA: 0x7FFE8750A3E0
        public void StringToBase64Binary(){} // RVA: 0x7FFE8750A440
        public void StringToDate(){} // RVA: 0x7FFE8750A560
        public void StringToDateTime(){} // RVA: 0x7FFE8750A5E0
        public void StringToDayTimeDuration(){} // RVA: 0x7FFE8750A660
        public void StringToDuration(){} // RVA: 0x7FFE8750A760
        public void StringToGDay(){} // RVA: 0x7FFE8750A860
        public void StringToGMonth(){} // RVA: 0x7FFE8750A8E0
        public void StringToGMonthDay(){} // RVA: 0x7FFE8750A960
        public void StringToGYear(){} // RVA: 0x7FFE8750A9E0
        public void StringToGYearMonth(){} // RVA: 0x7FFE8750AA60
        public void StringToDateOffset(){} // RVA: 0x7FFE8750AAE0
        public void StringToDateTimeOffset(){} // RVA: 0x7FFE8750AB80
        public void StringToGDayOffset(){} // RVA: 0x7FFE8750AC20
        public void StringToGMonthOffset(){} // RVA: 0x7FFE8750ACC0
        public void StringToGMonthDayOffset(){} // RVA: 0x7FFE8750AD60
        public void StringToGYearOffset(){} // RVA: 0x7FFE8750AE00
        public void StringToGYearMonthOffset(){} // RVA: 0x7FFE8750AEA0
        public void StringToHexBinary(){} // RVA: 0x7FFE8750AF40
        public void StringToQName(){} // RVA: 0x7FFE8750B070
        public void StringToTime(){} // RVA: 0x7FFE8750B370
        public void StringToTimeOffset(){} // RVA: 0x7FFE8750B3F0
        public void StringToYearMonthDuration(){} // RVA: 0x7FFE8750B490
        public void AnyUriToString(){} // RVA: 0x7FFE8750B590
        public void Base64BinaryToString(){} // RVA: 0x7FFE8750B600
        public void DateToString(){} // RVA: 0x7FFE8750B710
        public void DateTimeToString(){} // RVA: 0x7FFE8750B790
        public void DayTimeDurationToString(){} // RVA: 0x7FFE8750B810
        public void DurationToString(){} // RVA: 0x7FFE8750B880
        public void GDayToString(){} // RVA: 0x7FFE8750B8E0
        public void GMonthToString(){} // RVA: 0x7FFE8750B960
        public void GMonthDayToString(){} // RVA: 0x7FFE8750B9E0
        public void GYearToString(){} // RVA: 0x7FFE8750BA60
        public void GYearMonthToString(){} // RVA: 0x7FFE8750BAE0
        public void DateOffsetToString(){} // RVA: 0x7FFE8750BB60
        public void DateTimeOffsetToString(){} // RVA: 0x7FFE8750BBF0
        public void GDayOffsetToString(){} // RVA: 0x7FFE8750BC80
        public void GMonthOffsetToString(){} // RVA: 0x7FFE8750BD10
        public void GMonthDayOffsetToString(){} // RVA: 0x7FFE8750BDA0
        public void GYearOffsetToString(){} // RVA: 0x7FFE8750BE30
        public void GYearMonthOffsetToString(){} // RVA: 0x7FFE8750BEC0
        public void TimeToString(){} // RVA: 0x7FFE8750C140
        public void TimeOffsetToString(){} // RVA: 0x7FFE8750C1C0
        public void YearMonthDurationToString(){} // RVA: 0x7FFE8750C250
        public void DateTimeOffsetToDateTime(){} // RVA: 0x7FFE8750C2C0
        public void DecimalToInt32(){} // RVA: 0x7FFE8750C310
        public void DecimalToInt64(){} // RVA: 0x7FFE8750C590
        public void DecimalToUInt64(){} // RVA: 0x7FFE8750C820
        public void Int32ToByte(){} // RVA: 0x7FFE8750CAA0
        public void Int32ToInt16(){} // RVA: 0x7FFE8750CBA0
        public void Int32ToSByte(){} // RVA: 0x7FFE8750CCA0
        public void Int32ToUInt16(){} // RVA: 0x7FFE8750CDA0
        public void Int64ToInt32(){} // RVA: 0x7FFE8750CEA0
        public void Int64ToUInt32(){} // RVA: 0x7FFE8750CFA0
        public void UntypedAtomicToDateTime(){} // RVA: 0x7FFE8750D0A0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x7FFE8750D120
        public void .cctor(){} // RVA: 0x7FFE8750D1C0
    }

    public class XmlBooleanConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87517690
        public void Create(){} // RVA: 0x7FFE875176F0
        public void ToBoolean(){} // RVA: 0x7FFE87517820 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87517BC0 | overloaded x2
        public void ChangeType(){} // RVA: 0x7FFE87518530 | overloaded x3
    }

    public class XmlDateTimeConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87514EA0
        public void Create(){} // RVA: 0x7FFE87514F00
        public void ToDateTime(){} // RVA: 0x7FFE87515340 | overloaded x3
        public void ToDateTimeOffset(){} // RVA: 0x7FFE87515A40 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE875163D0 | overloaded x3
        public void ChangeType(){} // RVA: 0x7FFE87516E80 | overloaded x3
    }

    public class XmlListConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875272D0 | overloaded x3
        public void Create(){} // RVA: 0x7FFE87527330
        public void ChangeType(){} // RVA: 0x7FFE87527510
        public void ChangeListType(){} // RVA: 0x7FFE87527640
        public void IsListType(){} // RVA: 0x7FFE87528570
        public void ToArray(){} // RVA: 0x7FFE80E3FC10
        public void ToList(){} // RVA: 0x7FFE87528700
        public void StringAsList(){} // RVA: 0x7FFE87528C90
        public void ListAsString(){} // RVA: 0x7FFE87528D40
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFE87528FF0
    }

    public class XmlMiscConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87518B80
        public void Create(){} // RVA: 0x7FFE87518BE0
        public void ToString(){} // RVA: 0x7FFE87518C70
        public void ChangeType(){} // RVA: 0x7FFE87519AF0 | overloaded x2
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFE8751AC20
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFE8751AD80
    }

    public class XmlNumeric10Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8750EB70
        public void Create(){} // RVA: 0x7FFE8750EBD0
        public void ToDecimal(){} // RVA: 0x7FFE8750EDE0 | overloaded x2
        public void ToInt32(){} // RVA: 0x7FFE8750F4A0 | overloaded x3
        public void ToInt64(){} // RVA: 0x7FFE8750FA60 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE87510230 | overloaded x4
        public void ChangeType(){} // RVA: 0x7FFE87511740 | overloaded x5
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFE87512800
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFE87512C50
    }

    public class XmlNumeric2Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875130F0
        public void Create(){} // RVA: 0x7FFE87513150
        public void ToDouble(){} // RVA: 0x7FFE875132C0 | overloaded x2
        public void ToSingle(){} // RVA: 0x7FFE87513740 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE87513C60 | overloaded x3
        public void ChangeType(){} // RVA: 0x7FFE87514700 | overloaded x3
    }

    public class XmlSchema : XmlSchemaObject
    {
        public 0x6655D5D4 attributeFormDefault; // 0x38
        public 0x6655D5D4 elementFormDefault; // 0x3C
        public 0x6655CEF4 blockDefault; // 0x40
        public 0x6655CEF4 finalDefault; // 0x44
        public string targetNs; // 0x48
        public string version; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection includes; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x60
        public string id; // 0x68
        public System.Xml.XmlAttribute[] moreAttributes; // 0x70
        public bool isCompiled; // 0x78
        public bool isCompiledBySet; // 0x79
        public bool isPreprocessed; // 0x7A
        public bool isRedefined; // 0x7B
        public int errorCount; // 0x7C
        public System.Xml.Schema.XmlSchemaObjectTable attributes; // 0x80
        public System.Xml.Schema.XmlSchemaObjectTable attributeGroups; // 0x88
        public System.Xml.Schema.XmlSchemaObjectTable elements; // 0x90
        public System.Xml.Schema.XmlSchemaObjectTable types; // 0x98
        public System.Xml.Schema.XmlSchemaObjectTable groups; // 0xA0
        public System.Xml.Schema.XmlSchemaObjectTable notations; // 0xA8
        public System.Xml.Schema.XmlSchemaObjectTable identityConstraints; // 0xB0
        public int globalIdCounter;
        public System.Collections.ArrayList importedSchemas; // 0xB8
        public System.Collections.ArrayList importedNamespaces; // 0xC0
        public int schemaId; // 0xC8
        public System.Uri baseUri; // 0xD0
        public bool isChameleon; // 0xD8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874DE3E0
        public void Read(){} // RVA: 0x7FFE874DE860
        public void CompileSchema(){} // RVA: 0x7FFE874DEA00
        public void CompileSchemaInSet(){} // RVA: 0x7FFE874DEE80
        public void get_AttributeFormDefault(){} // RVA: 0x7FFE81D46090
        public void set_AttributeFormDefault(){} // RVA: 0x7FFE81D46A00
        public void get_BlockDefault(){} // RVA: 0x7FFE8119C080
        public void set_BlockDefault(){} // RVA: 0x7FFE8119C090
        public void get_FinalDefault(){} // RVA: 0x7FFE8119C0A0
        public void set_FinalDefault(){} // RVA: 0x7FFE8119C0B0
        public void get_ElementFormDefault(){} // RVA: 0x7FFE816311C0
        public void set_ElementFormDefault(){} // RVA: 0x7FFE82A4B070
        public void get_TargetNamespace(){} // RVA: 0x7FFE81176730
        public void set_TargetNamespace(){} // RVA: 0x7FFE81176740
        public void get_Version(){} // RVA: 0x7FFE8119C0E0
        public void set_Version(){} // RVA: 0x7FFE812534D0
        public void get_Includes(){} // RVA: 0x7FFE811C3500
        public void get_Items(){} // RVA: 0x7FFE81199370
        public void get_IsCompiledBySet(){} // RVA: 0x7FFE81647650
        public void set_IsCompiledBySet(){} // RVA: 0x7FFE81644C60
        public void get_IsPreprocessed(){} // RVA: 0x7FFE81643F30
        public void set_IsPreprocessed(){} // RVA: 0x7FFE81640520
        public void get_IsRedefined(){} // RVA: 0x7FFE81643A30
        public void set_IsRedefined(){} // RVA: 0x7FFE81644E60
        public void get_Attributes(){} // RVA: 0x7FFE874DEF40
        public void get_AttributeGroups(){} // RVA: 0x7FFE874DF000
        public void get_SchemaTypes(){} // RVA: 0x7FFE874DF0C0
        public void get_Elements(){} // RVA: 0x7FFE874DF180
        public void get_Id(){} // RVA: 0x7FFE81176D50
        public void set_Id(){} // RVA: 0x7FFE81176D60
        public void get_Groups(){} // RVA: 0x7FFE8179C860
        public void get_Notations(){} // RVA: 0x7FFE817AB5E0
        public void get_IdentityConstraints(){} // RVA: 0x7FFE81166040
        public void get_BaseUri(){} // RVA: 0x7FFE81218100
        public void set_BaseUri(){} // RVA: 0x7FFE81218110
        public void get_SchemaId(){} // RVA: 0x7FFE874DF240
        public void get_IsChameleon(){} // RVA: 0x7FFE82078290
        public void set_IsChameleon(){} // RVA: 0x7FFE86C70900
        public void get_Ids(){} // RVA: 0x7FFE8117C900
        public void get_Document(){} // RVA: 0x7FFE874DF2C0
        public void get_ErrorCount(){} // RVA: 0x7FFE8286B570
        public void set_ErrorCount(){} // RVA: 0x7FFE86D89990
        public void Clone(){} // RVA: 0x7FFE874DF380
        public void DeepClone(){} // RVA: 0x7FFE874DF620
        public void get_IdAttribute(){} // RVA: 0x7FFE81176D50
        public void set_IdAttribute(){} // RVA: 0x7FFE81176D60
        public void SetIsCompiled(){} // RVA: 0x7FFE81FE6AC0
        public void SetUnhandledAttributes(){} // RVA: 0x7FFE811C35A0
        public void AddAnnotation(){} // RVA: 0x7FFE874DFBD0
        public void get_ImportedSchemas(){} // RVA: 0x7FFE874DFC30
        public void get_ImportedNamespaces(){} // RVA: 0x7FFE874DFCF0
        public void GetExternalSchemasList(){} // RVA: 0x7FFE874DFDB0
        public void .cctor(){} // RVA: 0x7FFE874DFF30
    }

    public class XmlSchemaAll : XmlSchemaGroupBase
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x78
        public object field_1; // 0x55F

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFE81463AE0
        public void get_IsEmpty(){} // RVA: 0x7FFE874DFF70
        public void SetItems(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE874DFFD0
    }

    public class XmlSchemaAnnotated : XmlSchemaObject
    {
        public string id; // 0x38
        public System.Xml.Schema.XmlSchemaAnnotation annotation; // 0x40
        public System.Xml.XmlAttribute[] moreAttributes; // 0x48
        public object field_3; // 0x561

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE8143BA80
        public void set_Id(){} // RVA: 0x7FFE81437330
        public void get_Annotation(){} // RVA: 0x7FFE81178740
        public void set_Annotation(){} // RVA: 0x7FFE81123200
        public void get_UnhandledAttributes(){} // RVA: 0x7FFE81176730
        public void set_UnhandledAttributes(){} // RVA: 0x7FFE81176740
        public void get_IdAttribute(){} // RVA: 0x7FFE8143BA80
        public void set_IdAttribute(){} // RVA: 0x7FFE81437330
        public void SetUnhandledAttributes(){} // RVA: 0x7FFE81176740
        public void AddAnnotation(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaAnnotation : XmlSchemaObject
    {
        public string id; // 0x38
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x40
        public System.Xml.XmlAttribute[] moreAttributes; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE8143BA80
        public void set_Id(){} // RVA: 0x7FFE81437330
        public void get_Items(){} // RVA: 0x7FFE81178740
        public void get_IdAttribute(){} // RVA: 0x7FFE8143BA80
        public void set_IdAttribute(){} // RVA: 0x7FFE81437330
        public void SetUnhandledAttributes(){} // RVA: 0x7FFE81176740
        public void .ctor(){} // RVA: 0x7FFE874E00B0
    }

    public class XmlSchemaAny : XmlSchemaParticle
    {
        public string ns; // 0x78
        public 0x6655CDEC processContents; // 0x80
        public System.Xml.Schema.NamespaceList namespaceList; // 0x88
        public object field_3; // 0x568
        public object field_4; // 0x569
        public object field_5; // 0x56A

        // ── Methods ──
        public void get_Namespace(){} // RVA: 0x7FFE81463AE0
        public void set_Namespace(){} // RVA: 0x7FFE81464570
        public void set_ProcessContents(){} // RVA: 0x7FFE81D307B0
        public void get_NamespaceList(){} // RVA: 0x7FFE8113A010
        public void get_ResolvedNamespace(){} // RVA: 0x7FFE874E0150
        public void get_ProcessContentsCorrect(){} // RVA: 0x7FFE874E01A0
        public void get_NameString(){} // RVA: 0x7FFE874E01C0
        public void BuildNamespaceList(){} // RVA: 0x7FFE874E0600
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7FFE874E0760
        public void Allows(){} // RVA: 0x7FFE874E08D0
        public void .ctor(){} // RVA: 0x7FFE874E0910
    }

    public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
    {
        public string ns; // 0x50
        public 0x6655CDEC processContents; // 0x58
        public System.Xml.Schema.NamespaceList namespaceList; // 0x60
        public object field_3; // 0x56E

        // ── Methods ──
        public void set_Namespace(){} // RVA: 0x7FFE812534D0
        public void get_ProcessContents(){} // RVA: 0x7FFE8175AC90
        public void set_ProcessContents(){} // RVA: 0x7FFE8175AE70
        public void get_NamespaceList(){} // RVA: 0x7FFE81199370
        public void get_ProcessContentsCorrect(){} // RVA: 0x7FFE874E0960
        public void BuildNamespaceList(){} // RVA: 0x7FFE874E0970
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7FFE874E0AB0
        public void Allows(){} // RVA: 0x7FFE874E0C10
        public void IsSubset(){} // RVA: 0x7FFE874E0C50
        public void Intersection(){} // RVA: 0x7FFE874E0C80
        public void Union(){} // RVA: 0x7FFE874E0DF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaAppInfo : XmlSchemaObject
    {
        public string source; // 0x38
        public System.Xml.XmlNode[] markup; // 0x40

        // ── Methods ──
        public void set_Source(){} // RVA: 0x7FFE81437330
        public void get_Markup(){} // RVA: 0x7FFE81178740
        public void set_Markup(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaAttribute : XmlSchemaAnnotated
    {
        public string defaultValue; // 0x50
        public string fixedValue; // 0x58
        public string name; // 0x60
        public 0x6655D5D4 form; // 0x68
        public 0x6655E33C use; // 0x6C
        public System.Xml.XmlQualifiedName refName; // 0x70
        public System.Xml.XmlQualifiedName typeName; // 0x78
        public System.Xml.XmlQualifiedName qualifiedName; // 0x80
        public System.Xml.Schema.XmlSchemaSimpleType type; // 0x88
        public System.Xml.Schema.XmlSchemaSimpleType attributeType; // 0x90
        public System.Xml.Schema.SchemaAttDef attDef; // 0x98
        public object field_11; // 0x574
        public object field_12; // 0x575

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFE8119C0E0
        public void set_DefaultValue(){} // RVA: 0x7FFE812534D0
        public void get_FixedValue(){} // RVA: 0x7FFE811C3500
        public void set_FixedValue(){} // RVA: 0x7FFE811C3510
        public void get_Form(){} // RVA: 0x7FFE82A22EF0
        public void set_Form(){} // RVA: 0x7FFE82A22F00
        public void get_Name(){} // RVA: 0x7FFE81199370
        public void set_Name(){} // RVA: 0x7FFE81199380
        public void get_RefName(){} // RVA: 0x7FFE811C3590
        public void set_RefName(){} // RVA: 0x7FFE874E0F60
        public void get_SchemaTypeName(){} // RVA: 0x7FFE81463AE0
        public void set_SchemaTypeName(){} // RVA: 0x7FFE874E1040
        public void get_SchemaType(){} // RVA: 0x7FFE8113A010
        public void set_SchemaType(){} // RVA: 0x7FFE81280F90
        public void get_Use(){} // RVA: 0x7FFE82A22F10
        public void set_Use(){} // RVA: 0x7FFE82A22F20
        public void get_QualifiedName(){} // RVA: 0x7FFE81280C30
        public void get_AttributeSchemaType(){} // RVA: 0x7FFE8154EB60
        public void get_Datatype(){} // RVA: 0x7FFE874E1120
        public void SetQualifiedName(){} // RVA: 0x7FFE81282380
        public void SetAttributeType(){} // RVA: 0x7FFE818CE320
        public void get_AttDef(){} // RVA: 0x7FFE817AE360
        public void set_AttDef(){} // RVA: 0x7FFE8171B470
        public void get_NameAttribute(){} // RVA: 0x7FFE81199370
        public void set_NameAttribute(){} // RVA: 0x7FFE81199380
        public void Clone(){} // RVA: 0x7FFE874E1140
        public void .ctor(){} // RVA: 0x7FFE874E1320
    }

    public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
    {
        public string name; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x60
        public System.Xml.XmlQualifiedName qname; // 0x68
        public System.Xml.Schema.XmlSchemaAttributeGroup redefined; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable attributeUses; // 0x78
        public System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard; // 0x80
        public int selfReferenceCount; // 0x88
        public object field_8; // 0x581
        public object field_9; // 0x582

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void set_Name(){} // RVA: 0x7FFE812534D0
        public void get_Attributes(){} // RVA: 0x7FFE811C3500
        public void get_AnyAttribute(){} // RVA: 0x7FFE81199370
        public void set_AnyAttribute(){} // RVA: 0x7FFE81199380
        public void get_QualifiedName(){} // RVA: 0x7FFE81176D50
        public void get_AttributeUses(){} // RVA: 0x7FFE874E14A0
        public void get_AttributeWildcard(){} // RVA: 0x7FFE81280C30
        public void set_AttributeWildcard(){} // RVA: 0x7FFE81282380
        public void get_RedefinedAttributeGroup(){} // RVA: 0x7FFE811C3590
        public void get_Redefined(){} // RVA: 0x7FFE811C3590
        public void set_Redefined(){} // RVA: 0x7FFE811C35A0
        public void get_SelfReferenceCount(){} // RVA: 0x7FFE8194AD00
        public void set_SelfReferenceCount(){} // RVA: 0x7FFE8194A400
        public void get_NameAttribute(){} // RVA: 0x7FFE8119C0E0
        public void set_NameAttribute(){} // RVA: 0x7FFE812534D0
        public void SetQualifiedName(){} // RVA: 0x7FFE81176D60
        public void Clone(){} // RVA: 0x7FFE874E1550
        public void .ctor(){} // RVA: 0x7FFE874E1700
    }

    public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
    {
        public System.Xml.XmlQualifiedName refName; // 0x50

        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7FFE8119C0E0
        public void set_RefName(){} // RVA: 0x7FFE874E1840
        public void .ctor(){} // RVA: 0x7FFE874E1920
    }

    public class XmlSchemaChoice : XmlSchemaGroupBase
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x78
        public object field_1; // 0x58C

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFE81463AE0
        public void get_IsEmpty(){} // RVA: 0x7FFE874E19D0
        public void SetItems(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE874E19E0
    }

    public class XmlSchemaCollection : Object
    {
        public System.Collections.Hashtable collection; // 0x10
        public System.Xml.XmlNameTable nameTable; // 0x18
        public System.Xml.Schema.SchemaNames schemaNames; // 0x20
        public System.Threading.ReaderWriterLock wLock; // 0x28
        public int timeout; // 0x30
        public bool isThreadSafe; // 0x34
        public System.Xml.Schema.ValidationEventHandler validationEventHandler; // 0x38
        public System.Xml.XmlResolver xmlResolver; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E1AC0
        public void get_Count(){} // RVA: 0x7FFE874E1D40
        public void get_NameTable(){} // RVA: 0x7FFE810FE7C0
        public void set_XmlResolver(){} // RVA: 0x7FFE81123200
        public void get_Item(){} // RVA: 0x7FFE874E1D70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE874E1E30
        public void GetEnumerator(){} // RVA: 0x7FFE874E1F00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE874E1FD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE811E0850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE874E1D40
        public void GetSchemaInfo(){} // RVA: 0x7FFE874E2170
        public void GetSchemaNames(){} // RVA: 0x7FFE874E2230
        public void Add(){} // RVA: 0x7FFE874E25B0 | overloaded x3
        public void get_EventHandler(){} // RVA: 0x7FFE8143BA80
        public void set_EventHandler(){} // RVA: 0x7FFE81437330
    }

    public class XmlSchemaCollectionEnumerator : Object
    {
        public System.Collections.IDictionaryEnumerator enumerator; // 0x10
        public object field_1; // 0x599
        public object field_2; // 0x59A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E26F0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE874E2770
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFE874E27C0
        public void MoveNext(){} // RVA: 0x7FFE874E2810
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE874E2860
        public void get_Current(){} // RVA: 0x7FFE874E2870
        public void get_CurrentNode(){} // RVA: 0x7FFE874E2900
    }

    public class XmlSchemaCollectionNode : Object
    {
        public string namespaceUri; // 0x10
        public System.Xml.Schema.SchemaInfo schemaInfo; // 0x18
        public System.Xml.Schema.XmlSchema schema; // 0x20

        // ── Methods ──
        public void set_NamespaceURI(){} // RVA: 0x7FFE810FCE30
        public void get_SchemaInfo(){} // RVA: 0x7FFE810FE7C0
        public void set_SchemaInfo(){} // RVA: 0x7FFE81161E80
        public void get_Schema(){} // RVA: 0x7FFE811290C0
        public void set_Schema(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaCompilationSettings : Object
    {
        public bool enableUpaCheck; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE814B8390
        public void get_EnableUpaCheck(){} // RVA: 0x7FFE811C55E0
    }

    public class XmlSchemaComplexContent : XmlSchemaContentModel
    {
        public System.Xml.Schema.XmlSchemaContent content; // 0x50
        public bool isMixed; // 0x58
        public bool hasMixedAttribute; // 0x59

        // ── Methods ──
        public void get_IsMixed(){} // RVA: 0x7FFE813A1140
        public void set_IsMixed(){} // RVA: 0x7FFE874E2990
        public void get_Content(){} // RVA: 0x7FFE8119C0E0
        public void set_Content(){} // RVA: 0x7FFE812534D0
        public void get_HasMixedAttribute(){} // RVA: 0x7FFE85BA8C00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaComplexContentExtension : XmlSchemaContent
    {
        public System.Xml.Schema.XmlSchemaParticle particle; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x60
        public System.Xml.XmlQualifiedName baseTypeName; // 0x68

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFE81176D50
        public void set_BaseTypeName(){} // RVA: 0x7FFE874E29A0
        public void get_Particle(){} // RVA: 0x7FFE8119C0E0
        public void set_Particle(){} // RVA: 0x7FFE812534D0
        public void get_Attributes(){} // RVA: 0x7FFE811C3500
        public void get_AnyAttribute(){} // RVA: 0x7FFE81199370
        public void set_AnyAttribute(){} // RVA: 0x7FFE81199380
        public void SetAttributes(){} // RVA: 0x7FFE811C3510
        public void .ctor(){} // RVA: 0x7FFE874E2A80
    }

    public class XmlSchemaComplexContentRestriction : XmlSchemaContent
    {
        public System.Xml.Schema.XmlSchemaParticle particle; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x60
        public System.Xml.XmlQualifiedName baseTypeName; // 0x68

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFE81176D50
        public void set_BaseTypeName(){} // RVA: 0x7FFE874E2BC0
        public void get_Particle(){} // RVA: 0x7FFE8119C0E0
        public void set_Particle(){} // RVA: 0x7FFE812534D0
        public void get_Attributes(){} // RVA: 0x7FFE811C3500
        public void get_AnyAttribute(){} // RVA: 0x7FFE81199370
        public void set_AnyAttribute(){} // RVA: 0x7FFE81199380
        public void SetAttributes(){} // RVA: 0x7FFE811C3510
        public void .ctor(){} // RVA: 0x7FFE874E2CA0
    }

    public class XmlSchemaComplexType : XmlSchemaType
    {
        public 0x6655CEF4 block; // 0x98
        public System.Xml.Schema.XmlSchemaContentModel contentModel; // 0xA0
        public System.Xml.Schema.XmlSchemaParticle particle; // 0xA8
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0xB0
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0xB8
        public System.Xml.Schema.XmlSchemaParticle contentTypeParticle; // 0xC0
        public 0x6655CEF4 blockResolved; // 0xC8
        public System.Xml.Schema.XmlSchemaObjectTable localElements; // 0xD0
        public System.Xml.Schema.XmlSchemaObjectTable attributeUses; // 0xD8
        public System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard; // 0xE0
        public System.Xml.Schema.XmlSchemaComplexType anyTypeLax;
        public System.Xml.Schema.XmlSchemaComplexType anyTypeSkip; // 0x8
        public System.Xml.Schema.XmlSchemaComplexType untypedAnyType; // 0x10
        public byte pvFlags; // 0xE8
        public object field_14; // 0x5A8
        public object field_15; // 0x5A9
        public object field_16; // 0x5AA

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE874E2DE0
        public void CreateAnyType(){} // RVA: 0x7FFE874E32F0
        public void .ctor(){} // RVA: 0x7FFE874E3940
        public void get_AnyType(){} // RVA: 0x7FFE874E3A00
        public void get_UntypedAnyType(){} // RVA: 0x7FFE874E3A60
        public void get_AnyTypeContentValidator(){} // RVA: 0x7FFE874E3AC0
        public void get_IsAbstract(){} // RVA: 0x7FFE874E3B40
        public void set_IsAbstract(){} // RVA: 0x7FFE874E3B50
        public void get_Block(){} // RVA: 0x7FFE82B06A40
        public void set_Block(){} // RVA: 0x7FFE82B06FA0
        public void get_IsMixed(){} // RVA: 0x7FFE874E3B80
        public void set_IsMixed(){} // RVA: 0x7FFE874E3B90
        public void get_ContentModel(){} // RVA: 0x7FFE8179C860
        public void set_ContentModel(){} // RVA: 0x7FFE8171B4D0
        public void get_Particle(){} // RVA: 0x7FFE817AB5E0
        public void set_Particle(){} // RVA: 0x7FFE81857260
        public void get_Attributes(){} // RVA: 0x7FFE874E3BC0
        public void get_AnyAttribute(){} // RVA: 0x7FFE811660B0
        public void set_AnyAttribute(){} // RVA: 0x7FFE811660C0
        public void get_ContentType(){} // RVA: 0x7FFE814AA220
        public void get_ContentTypeParticle(){} // RVA: 0x7FFE81166120
        public void get_BlockResolved(){} // RVA: 0x7FFE81790750
        public void get_AttributeUses(){} // RVA: 0x7FFE874E3C80
        public void get_AttributeWildcard(){} // RVA: 0x7FFE8117C900
        public void get_LocalElements(){} // RVA: 0x7FFE874E3D40
        public void SetContentTypeParticle(){} // RVA: 0x7FFE81166130
        public void SetBlockResolved(){} // RVA: 0x7FFE8453D840
        public void SetAttributeWildcard(){} // RVA: 0x7FFE8117C910
        public void set_HasWildCard(){} // RVA: 0x7FFE874E3E00
        public void SetAttributes(){} // RVA: 0x7FFE81166050
        public void ContainsIdAttribute(){} // RVA: 0x7FFE874E3E30
        public void Clone(){} // RVA: 0x7FFE874E40B0 | overloaded x2
        public void ClearCompiledState(){} // RVA: 0x7FFE874E4AD0
        public void CloneAttributes(){} // RVA: 0x7FFE874E4C90
        public void CloneGroupBaseParticles(){} // RVA: 0x7FFE874E4F90
        public void CloneParticle(){} // RVA: 0x7FFE874E50F0
        public void GetResolvedElementForm(){} // RVA: 0x7FFE874E5630
        public void HasParticleRef(){} // RVA: 0x7FFE874E5660
        public void HasAttributeQNameRef(){} // RVA: 0x7FFE874E59E0
    }

    public class XmlSchemaContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaContentModel : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0x7FFE80E2E2E0
        public void set_Content(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaDatatype : Object
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_TokenizedType(){} // RVA: 0x7FFE80E2EDB0
        public void ParseValue(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void get_Variety(){} // RVA: 0x7FFE813240E0
        public void get_TypeCode(){} // RVA: 0x7FFE813240E0
        public void IsDerivedFrom(){} // RVA: 0x7FFE810FB320
        public void get_HasLexicalFacets(){} // RVA: 0x7FFE80E2F150
        public void get_HasValueFacets(){} // RVA: 0x7FFE80E2F150
        public void get_ValueConverter(){} // RVA: 0x7FFE80E2E2E0
        public void get_Restriction(){} // RVA: 0x7FFE80E2E2E0
        public void Compare(){} // RVA: 0x7FFE80E38BF0
        public void TryParseValue(){} // RVA: 0x7FFE80E40660 | overloaded x2
        public void get_FacetsChecker(){} // RVA: 0x7FFE80E2E2E0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE80E2EDB0
        public void DeriveByRestriction(){} // RVA: 0x7FFE80E403A0
        public void DeriveByList(){} // RVA: 0x7FFE80E2E390
        public void VerifySchemaValid(){} // RVA: 0x7FFE80E4F230
        public void IsEqual(){} // RVA: 0x7FFE80E32650
        public void IsComparable(){} // RVA: 0x7FFE80E2F3B0
        public void get_TypeCodeString(){} // RVA: 0x7FFE874E5B90
        public void TypeCodeToString(){} // RVA: 0x7FFE874E5D10
        public void ConcatenatedToString(){} // RVA: 0x7FFE874E6390
        public void FromXmlTokenizedType(){} // RVA: 0x7FFE874E69B0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7FFE874E6A60
        public void FromXdrName(){} // RVA: 0x7FFE874E6B10
        public void DeriveByUnion(){} // RVA: 0x7FFE874E6CD0
        public void XdrCanonizeUri(){} // RVA: 0x7FFE874E6D30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaDocumentation : XmlSchemaObject
    {
        public string source; // 0x38
        public string language; // 0x40
        public System.Xml.XmlNode[] markup; // 0x48

        // ── Methods ──
        public void set_Source(){} // RVA: 0x7FFE81437330
        public void set_Language(){} // RVA: 0x7FFE874E70C0
        public void set_Markup(){} // RVA: 0x7FFE81176740
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE874E7210
    }

    public class XmlSchemaElement : XmlSchemaParticle
    {
        public bool isAbstract; // 0x78
        public bool hasAbstractAttribute; // 0x79
        public bool isNillable; // 0x7A
        public bool hasNillableAttribute; // 0x7B
        public bool isLocalTypeDerivationChecked; // 0x7C
        public 0x6655CEF4 block; // 0x80
        public 0x6655CEF4 final; // 0x84
        public 0x6655D5D4 form; // 0x88
        public string defaultValue; // 0x90
        public string fixedValue; // 0x98
        public string name; // 0xA0
        public System.Xml.XmlQualifiedName refName; // 0xA8
        public System.Xml.XmlQualifiedName substitutionGroup; // 0xB0
        public System.Xml.XmlQualifiedName typeName; // 0xB8
        public System.Xml.Schema.XmlSchemaType type; // 0xC0
        public System.Xml.XmlQualifiedName qualifiedName; // 0xC8
        public System.Xml.Schema.XmlSchemaType elementType; // 0xD0
        public 0x6655CEF4 blockResolved; // 0xD8
        public 0x6655CEF4 finalResolved; // 0xDC
        public System.Xml.Schema.XmlSchemaObjectCollection constraints; // 0xE0
        public System.Xml.Schema.SchemaElementDecl elementDecl; // 0xE8
        public object field_21; // 0x5C8
        public object field_22; // 0x5C9
        public object field_23; // 0x5CA

        // ── Methods ──
        public void get_IsAbstract(){} // RVA: 0x7FFE816400C0
        public void set_IsAbstract(){} // RVA: 0x7FFE874E7330
        public void get_Block(){} // RVA: 0x7FFE81D30560
        public void set_Block(){} // RVA: 0x7FFE81D307B0
        public void get_DefaultValue(){} // RVA: 0x7FFE8154EB60
        public void set_DefaultValue(){} // RVA: 0x7FFE818CE320
        public void get_Final(){} // RVA: 0x7FFE829DF2E0
        public void set_Final(){} // RVA: 0x7FFE829DF3B0
        public void get_FixedValue(){} // RVA: 0x7FFE817AE360
        public void set_FixedValue(){} // RVA: 0x7FFE8171B470
        public void get_Form(){} // RVA: 0x7FFE8194AD00
        public void set_Form(){} // RVA: 0x7FFE8194A400
        public void get_Name(){} // RVA: 0x7FFE8179C860
        public void set_Name(){} // RVA: 0x7FFE8171B4D0
        public void get_IsNillable(){} // RVA: 0x7FFE81643F30
        public void set_IsNillable(){} // RVA: 0x7FFE874E7340
        public void get_HasNillableAttribute(){} // RVA: 0x7FFE81643A30
        public void get_HasAbstractAttribute(){} // RVA: 0x7FFE81647650
        public void get_RefName(){} // RVA: 0x7FFE817AB5E0
        public void set_RefName(){} // RVA: 0x7FFE874E7350
        public void get_SubstitutionGroup(){} // RVA: 0x7FFE81166040
        public void set_SubstitutionGroup(){} // RVA: 0x7FFE874E7440
        public void get_SchemaTypeName(){} // RVA: 0x7FFE811660B0
        public void set_SchemaTypeName(){} // RVA: 0x7FFE874E7530
        public void get_SchemaType(){} // RVA: 0x7FFE81166120
        public void set_SchemaType(){} // RVA: 0x7FFE81166130
        public void get_Constraints(){} // RVA: 0x7FFE874E7620
        public void get_QualifiedName(){} // RVA: 0x7FFE81253460
        public void get_ElementSchemaType(){} // RVA: 0x7FFE81218100
        public void get_BlockResolved(){} // RVA: 0x7FFE82A234F0
        public void get_FinalResolved(){} // RVA: 0x7FFE874E76E0
        public void SetQualifiedName(){} // RVA: 0x7FFE81253470
        public void SetElementType(){} // RVA: 0x7FFE81218110
        public void SetBlockResolved(){} // RVA: 0x7FFE82A23500
        public void SetFinalResolved(){} // RVA: 0x7FFE874E76F0
        public void get_HasConstraints(){} // RVA: 0x7FFE874E7700
        public void get_IsLocalTypeDerivationChecked(){} // RVA: 0x7FFE816402F0
        public void set_IsLocalTypeDerivationChecked(){} // RVA: 0x7FFE81641190
        public void get_ElementDecl(){} // RVA: 0x7FFE8117C970
        public void set_ElementDecl(){} // RVA: 0x7FFE8117C980
        public void get_NameAttribute(){} // RVA: 0x7FFE8179C860
        public void set_NameAttribute(){} // RVA: 0x7FFE8171B4D0
        public void get_NameString(){} // RVA: 0x7FFE874E7750
        public void Clone(){} // RVA: 0x7FFE874E7790 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE874E7C10
    }

    public class XmlSchemaEnumerationFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9880
    }

    public class XmlSchemaException : SystemException
    {
        public string res; // 0x90
        public string[] args; // 0x98
        public string sourceUri; // 0xA0
        public int lineNumber; // 0xA8
        public int linePosition; // 0xAC
        public System.Xml.Schema.XmlSchemaObject sourceSchemaObject; // 0xB0
        public string message; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E93E0 | overloaded x14
        public void GetObjectData(){} // RVA: 0x7FFE874E8660
        public void CreateMessage(){} // RVA: 0x7FFE874E95C0
        public void get_GetRes(){} // RVA: 0x7FFE8154EB60
        public void get_Args(){} // RVA: 0x7FFE817AE360
        public void get_SourceUri(){} // RVA: 0x7FFE8179C860
        public void get_LineNumber(){} // RVA: 0x7FFE81A338E0
        public void get_LinePosition(){} // RVA: 0x7FFE848BEEF0
        public void get_SourceSchemaObject(){} // RVA: 0x7FFE81166040
        public void SetSource(){} // RVA: 0x7FFE874E9680 | overloaded x2
        public void SetSchemaObject(){} // RVA: 0x7FFE81166050
        public void get_Message(){} // RVA: 0x7FFE874E9770
    }

    public class XmlSchemaExternal : XmlSchemaObject
    {
        public string location; // 0x38
        public System.Uri baseUri; // 0x40
        public System.Xml.Schema.XmlSchema schema; // 0x48
        public string id; // 0x50
        public System.Xml.XmlAttribute[] moreAttributes; // 0x58
        public 0x6655B8F4 compositor; // 0x60

        // ── Methods ──
        public void get_SchemaLocation(){} // RVA: 0x7FFE8143BA80
        public void set_SchemaLocation(){} // RVA: 0x7FFE81437330
        public void get_Schema(){} // RVA: 0x7FFE81176730
        public void set_Schema(){} // RVA: 0x7FFE81176740
        public void get_Id(){} // RVA: 0x7FFE8119C0E0
        public void set_Id(){} // RVA: 0x7FFE812534D0
        public void get_BaseUri(){} // RVA: 0x7FFE81178740
        public void set_BaseUri(){} // RVA: 0x7FFE81123200
        public void get_IdAttribute(){} // RVA: 0x7FFE8119C0E0
        public void set_IdAttribute(){} // RVA: 0x7FFE812534D0
        public void SetUnhandledAttributes(){} // RVA: 0x7FFE811C3510
        public void get_Compositor(){} // RVA: 0x7FFE8139EA30
        public void set_Compositor(){} // RVA: 0x7FFE8139E520
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaFacet : XmlSchemaAnnotated
    {
        public string value; // 0x50
        public bool isFixed; // 0x58
        public 0x6655D0AC facetType; // 0x5C

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE8119C0E0
        public void set_Value(){} // RVA: 0x7FFE812534D0
        public void get_IsFixed(){} // RVA: 0x7FFE813A1140
        public void set_IsFixed(){} // RVA: 0x7FFE874E9790
        public void get_FacetType(){} // RVA: 0x7FFE813A7A20
        public void set_FacetType(){} // RVA: 0x7FFE8175ACA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E98E0
    }

    public class XmlSchemaGroup : XmlSchemaAnnotated
    {
        public string name; // 0x50
        public System.Xml.Schema.XmlSchemaGroupBase particle; // 0x58
        public System.Xml.Schema.XmlSchemaParticle canonicalParticle; // 0x60
        public System.Xml.XmlQualifiedName qname; // 0x68
        public System.Xml.Schema.XmlSchemaGroup redefined; // 0x70
        public int selfReferenceCount; // 0x78
        public object field_6; // 0x5F0

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void set_Name(){} // RVA: 0x7FFE812534D0
        public void get_Particle(){} // RVA: 0x7FFE811C3500
        public void set_Particle(){} // RVA: 0x7FFE811C3510
        public void get_QualifiedName(){} // RVA: 0x7FFE81176D50
        public void get_CanonicalParticle(){} // RVA: 0x7FFE81199370
        public void set_CanonicalParticle(){} // RVA: 0x7FFE81199380
        public void get_Redefined(){} // RVA: 0x7FFE811C3590
        public void set_Redefined(){} // RVA: 0x7FFE811C35A0
        public void get_SelfReferenceCount(){} // RVA: 0x7FFE8286C0A0
        public void set_SelfReferenceCount(){} // RVA: 0x7FFE82862F10
        public void get_NameAttribute(){} // RVA: 0x7FFE8119C0E0
        public void set_NameAttribute(){} // RVA: 0x7FFE812534D0
        public void SetQualifiedName(){} // RVA: 0x7FFE81176D60
        public void Clone(){} // RVA: 0x7FFE874E9910 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE874E9B60
    }

    public class XmlSchemaGroupBase : XmlSchemaParticle
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFE80E2E2E0
        public void SetItems(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE874E9C10
    }

    public class XmlSchemaGroupRef : XmlSchemaParticle
    {
        public System.Xml.XmlQualifiedName refName; // 0x78
        public System.Xml.Schema.XmlSchemaGroupBase particle; // 0x80
        public System.Xml.Schema.XmlSchemaGroup refined; // 0x88

        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7FFE81463AE0
        public void set_RefName(){} // RVA: 0x7FFE874E9C60
        public void get_Particle(){} // RVA: 0x7FFE81280C30
        public void SetParticle(){} // RVA: 0x7FFE81282380
        public void get_Redefined(){} // RVA: 0x7FFE8113A010
        public void set_Redefined(){} // RVA: 0x7FFE81280F90
        public void .ctor(){} // RVA: 0x7FFE874E9D40
    }

    public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
    {
        public string name; // 0x50
        public System.Xml.Schema.XmlSchemaXPath selector; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection fields; // 0x60
        public System.Xml.XmlQualifiedName qualifiedName; // 0x68
        public System.Xml.Schema.CompiledIdentityConstraint compiledConstraint; // 0x70
        public object field_5; // 0x5FB

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void set_Name(){} // RVA: 0x7FFE812534D0
        public void get_Selector(){} // RVA: 0x7FFE811C3500
        public void set_Selector(){} // RVA: 0x7FFE811C3510
        public void get_Fields(){} // RVA: 0x7FFE81199370
        public void get_QualifiedName(){} // RVA: 0x7FFE81176D50
        public void SetQualifiedName(){} // RVA: 0x7FFE81176D60
        public void get_CompiledConstraint(){} // RVA: 0x7FFE811C3590
        public void set_CompiledConstraint(){} // RVA: 0x7FFE811C35A0
        public void get_NameAttribute(){} // RVA: 0x7FFE8119C0E0
        public void set_NameAttribute(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE874E9E20
    }

    public class XmlSchemaImport : XmlSchemaExternal
    {
        public string ns; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874EA100
        public void get_Namespace(){} // RVA: 0x7FFE81176D50
        public void set_Namespace(){} // RVA: 0x7FFE81176D60
        public void AddAnnotation(){} // RVA: 0x7FFE811C35A0
    }

    public class XmlSchemaInclude : XmlSchemaExternal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874EA110
        public void AddAnnotation(){} // RVA: 0x7FFE81176D60
    }

    public class XmlSchemaInference : Object
    {
        public System.Xml.XmlQualifiedName ST_boolean;
        public System.Xml.XmlQualifiedName ST_byte; // 0x8

        // ── Methods ──
        public void set_Occurrence(){} // RVA: 0x7FFE8119C0D0
        public void get_Occurrence(){} // RVA: 0x7FFE8119C0C0
        public void set_TypeInference(){} // RVA: 0x7FFE82B06A20
        public void .ctor(){} // RVA: 0x7FFE8746E2D0
        public void InferSchema(){} // RVA: 0x7FFE8746E510
        public void InferSchema1(){} // RVA: 0x7FFE8746E5A0
        public void AddAttribute(){} // RVA: 0x7FFE8746F010
        public void CreateXmlSchema(){} // RVA: 0x7FFE8746FB70
        public void AddElement(){} // RVA: 0x7FFE8746FC50
        public void InferElement(){} // RVA: 0x7FFE874708E0
        public void CheckSimpleContentExtension(){} // RVA: 0x7FFE874722B0
        public void GetEffectiveSchemaType(){} // RVA: 0x7FFE87472460
        public void FindMatchingElement(){} // RVA: 0x7FFE874726A0
        public void ProcessAttributes(){} // RVA: 0x7FFE87473C30
        public void MoveAttributes(){} // RVA: 0x7FFE87474910 | overloaded x2
        public void FindAttribute(){} // RVA: 0x7FFE87474CB0
        public void FindGlobalElement(){} // RVA: 0x7FFE87474F20
        public void FindElement(){} // RVA: 0x7FFE874751A0
        public void FindAttributeRef(){} // RVA: 0x7FFE87475350
        public void FindElementRef(){} // RVA: 0x7FFE87475640
        public void MakeExistingAttributesOptional(){} // RVA: 0x7FFE87475850
        public void SwitchUseToOptional(){} // RVA: 0x7FFE87475920
        public void RefineSimpleType(){} // RVA: 0x7FFE87475AA0
        public void InferSimpleType(){} // RVA: 0x7FFE874768D0
        public void DateTime(){} // RVA: 0x7FFE87477A60
        public void CreateNewElementforChoice(){} // RVA: 0x7FFE87477BB0
        public void GetSchemaType(){} // RVA: 0x7FFE87478360
        public void SetMinMaxOccurs(){} // RVA: 0x7FFE87478F50
        public void .cctor(){} // RVA: 0x7FFE87479180
    }

    public class XmlSchemaInferenceException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8747A660 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFE8747A560
    }

    public class XmlSchemaInfo : Object
    {
        public bool isDefault; // 0x10
        public bool isNil; // 0x11
        public System.Xml.Schema.XmlSchemaElement schemaElement; // 0x18
        public System.Xml.Schema.XmlSchemaAttribute schemaAttribute; // 0x20
        public System.Xml.Schema.XmlSchemaType schemaType; // 0x28
        public System.Xml.Schema.XmlSchemaSimpleType memberType; // 0x30
        public 0x6655E5A4 validity; // 0x38
        public 0x6655CE44 contentType; // 0x3C
        public object field_8; // 0x604
        public object field_9; // 0x605
        public object field_10; // 0x606

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874EA130 | overloaded x2
        public void get_Validity(){} // RVA: 0x7FFE81D46090
        public void set_Validity(){} // RVA: 0x7FFE81D46A00
        public void get_IsDefault(){} // RVA: 0x7FFE811C55E0
        public void set_IsDefault(){} // RVA: 0x7FFE811C55F0
        public void get_IsNil(){} // RVA: 0x7FFE81346E30
        public void set_IsNil(){} // RVA: 0x7FFE813471A0
        public void get_MemberType(){} // RVA: 0x7FFE8144E200
        public void set_MemberType(){} // RVA: 0x7FFE81129890
        public void get_SchemaType(){} // RVA: 0x7FFE81129130
        public void set_SchemaType(){} // RVA: 0x7FFE874EA160
        public void get_SchemaElement(){} // RVA: 0x7FFE810FE7C0
        public void set_SchemaElement(){} // RVA: 0x7FFE874EA1F0
        public void get_SchemaAttribute(){} // RVA: 0x7FFE811290C0
        public void set_SchemaAttribute(){} // RVA: 0x7FFE874EA2B0
        public void get_ContentType(){} // RVA: 0x7FFE816311C0
        public void get_XmlType(){} // RVA: 0x7FFE874EA370
        public void get_HasDefaultValue(){} // RVA: 0x7FFE874EA390
        public void get_IsUnionType(){} // RVA: 0x7FFE874EA3D0
        public void Clear(){} // RVA: 0x7FFE874EA410
    }

    public class XmlSchemaKey : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9F60
    }

    public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
    {
        public System.Xml.XmlQualifiedName refer; // 0x78

        // ── Methods ──
        public void get_Refer(){} // RVA: 0x7FFE81463AE0
        public void set_Refer(){} // RVA: 0x7FFE874E9F70
        public void .ctor(){} // RVA: 0x7FFE874EA050
    }

    public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9840
    }

    public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E98B0
    }

    public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E98C0
    }

    public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9860
    }

    public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9890
    }

    public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E98A0
    }

    public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9850
    }

    public class XmlSchemaNotation : XmlSchemaAnnotated
    {
        public string name; // 0x50
        public string publicId; // 0x58
        public string systemId; // 0x60
        public System.Xml.XmlQualifiedName qname; // 0x68
        public object field_4; // 0x60F

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void set_Name(){} // RVA: 0x7FFE812534D0
        public void get_Public(){} // RVA: 0x7FFE811C3500
        public void set_Public(){} // RVA: 0x7FFE811C3510
        public void get_System(){} // RVA: 0x7FFE81199370
        public void set_System(){} // RVA: 0x7FFE81199380
        public void get_QualifiedName(){} // RVA: 0x7FFE81176D50
        public void set_QualifiedName(){} // RVA: 0x7FFE81176D60
        public void get_NameAttribute(){} // RVA: 0x7FFE8119C0E0
        public void set_NameAttribute(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE874EA580
    }

    public class XmlSchemaNumericFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaObject : Object
    {
        public int lineNum; // 0x10
        public int linePos; // 0x14
        public string sourceUri; // 0x18
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces; // 0x20
        public System.Xml.Schema.XmlSchemaObject parent; // 0x28
        public bool isProcessing; // 0x30
        public object field_6; // 0x614
        public object field_7; // 0x615

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFE811485C0
        public void set_LineNumber(){} // RVA: 0x7FFE810FE0C0
        public void get_LinePosition(){} // RVA: 0x7FFE8164B230
        public void set_LinePosition(){} // RVA: 0x7FFE8164E0F0
        public void get_SourceUri(){} // RVA: 0x7FFE810FE7C0
        public void set_SourceUri(){} // RVA: 0x7FFE81161E80
        public void get_Parent(){} // RVA: 0x7FFE81129130
        public void set_Parent(){} // RVA: 0x7FFE810FCE90
        public void get_Namespaces(){} // RVA: 0x7FFE874EA630
        public void set_Namespaces(){} // RVA: 0x7FFE811290D0
        public void OnAdd(){} // RVA: 0x7FFE810FB310
        public void OnRemove(){} // RVA: 0x7FFE810FB310
        public void OnClear(){} // RVA: 0x7FFE810FB310
        public void get_IdAttribute(){} // RVA: 0x7FFE813240E0
        public void set_IdAttribute(){} // RVA: 0x7FFE810FB310
        public void SetUnhandledAttributes(){} // RVA: 0x7FFE810FB310
        public void AddAnnotation(){} // RVA: 0x7FFE810FB310
        public void get_NameAttribute(){} // RVA: 0x7FFE813240E0
        public void set_NameAttribute(){} // RVA: 0x7FFE810FB310
        public void get_IsProcessing(){} // RVA: 0x7FFE81121450
        public void set_IsProcessing(){} // RVA: 0x7FFE81121460
        public void Clone(){} // RVA: 0x7FFE874EA6D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaObjectCollection : CollectionBase
    {
        public System.Xml.Schema.XmlSchemaObject parent; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8670DB40
        public void get_Item(){} // RVA: 0x7FFE874EA750
        public void set_Item(){} // RVA: 0x7FFE874EA800
        public void GetEnumerator(){} // RVA: 0x7FFE874EA870
        public void Add(){} // RVA: 0x7FFE874EABE0 | overloaded x2
        public void Insert(){} // RVA: 0x7FFE874EA980
        public void Remove(){} // RVA: 0x7FFE874EA9F0
        public void OnInsert(){} // RVA: 0x7FFE874EAA50
        public void OnSet(){} // RVA: 0x7FFE874EAA80
        public void OnClear(){} // RVA: 0x7FFE874EAAF0
        public void OnRemove(){} // RVA: 0x7FFE874EAB20
        public void Clone(){} // RVA: 0x7FFE874EAB50
    }

    public class XmlSchemaObjectEnumerator : Object
    {
        public System.Collections.IEnumerator enumerator; // 0x10
        public object field_1; // 0x61D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void MoveNext(){} // RVA: 0x7FFE874EAC10
        public void get_Current(){} // RVA: 0x7FFE874EAC60
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE874EAD00
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFE874EAD50
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE874EADA0
    }

    public class XmlSchemaObjectTable : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
        public System.Collections.Generic.List`1<XmlSchemaObjectEntry> entries; // 0x18
        public object field_2; // 0x61F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874EADF0
        public void Add(){} // RVA: 0x7FFE874EAF50
        public void Insert(){} // RVA: 0x7FFE874EB0D0
        public void Replace(){} // RVA: 0x7FFE874EB230
        public void Clear(){} // RVA: 0x7FFE874EB370
        public void Remove(){} // RVA: 0x7FFE874EB400
        public void FindIndexByValue(){} // RVA: 0x7FFE874EB4D0
        public void get_Count(){} // RVA: 0x7FFE874EB580
        public void Contains(){} // RVA: 0x7FFE874EB5D0
        public void get_Item(){} // RVA: 0x7FFE874EB650
        public void get_Values(){} // RVA: 0x7FFE874EB6D0
        public void GetEnumerator(){} // RVA: 0x7FFE874EB7A0
    }

    public class XmlSchemaParticle : XmlSchemaAnnotated
    {
        public System.Decimal minOccurs; // 0x50
        public System.Decimal maxOccurs; // 0x60
        public 0x6655DD64 flags; // 0x70
        public System.Xml.Schema.XmlSchemaParticle Empty;
        public object field_4; // 0x629
        public object field_5; // 0x62A

        // ── Methods ──
        public void get_MinOccursString(){} // RVA: 0x7FFE874EC580
        public void set_MinOccursString(){} // RVA: 0x7FFE874EC6C0
        public void get_MaxOccursString(){} // RVA: 0x7FFE874EC8D0
        public void set_MaxOccursString(){} // RVA: 0x7FFE874ECAD0
        public void get_MinOccurs(){} // RVA: 0x7FFE84E45FD0
        public void set_MinOccurs(){} // RVA: 0x7FFE874ECDE0
        public void get_MaxOccurs(){} // RVA: 0x7FFE8432FFC0
        public void set_MaxOccurs(){} // RVA: 0x7FFE874ED060
        public void get_IsEmpty(){} // RVA: 0x7FFE874ED370
        public void get_NameString(){} // RVA: 0x7FFE874ED430
        public void GetQualifiedName(){} // RVA: 0x7FFE874ED470
        public void .ctor(){} // RVA: 0x7FFE874ED650
        public void .cctor(){} // RVA: 0x7FFE874ED6D0
    }

    public class XmlSchemaPatternFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9870
    }

    public class XmlSchemaRedefine : XmlSchemaExternal
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x68
        public System.Xml.Schema.XmlSchemaObjectTable attributeGroups; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable types; // 0x78
        public System.Xml.Schema.XmlSchemaObjectTable groups; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874ED820
        public void get_Items(){} // RVA: 0x7FFE81176D50
        public void get_AttributeGroups(){} // RVA: 0x7FFE811C3590
        public void get_SchemaTypes(){} // RVA: 0x7FFE81463AE0
        public void get_Groups(){} // RVA: 0x7FFE81280C30
        public void AddAnnotation(){} // RVA: 0x7FFE874EDA40
    }

    public class XmlSchemaSequence : XmlSchemaGroupBase
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x78
        public object field_1; // 0x634

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFE81463AE0
        public void get_IsEmpty(){} // RVA: 0x7FFE874DFF70
        public void SetItems(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE874EDAA0
    }

    public class XmlSchemaSet : Object
    {
        public System.Xml.XmlNameTable nameTable; // 0x10
        public System.Xml.Schema.SchemaNames schemaNames; // 0x18
        public System.Collections.SortedList schemas; // 0x20
        public System.Xml.Schema.ValidationEventHandler internalEventHandler; // 0x28
        public System.Xml.Schema.ValidationEventHandler eventHandler; // 0x30
        public bool isCompiled; // 0x38
        public System.Collections.Hashtable schemaLocations; // 0x40
        public System.Collections.Hashtable chameleonSchemas; // 0x48
        public System.Collections.Hashtable targetNamespaces; // 0x50
        public bool compileAll; // 0x58
        public System.Xml.Schema.SchemaInfo cachedCompiledInfo; // 0x60
        public System.Xml.XmlReaderSettings readerSettings; // 0x68
        public System.Xml.Schema.XmlSchema schemaForSchema; // 0x70
        public System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings; // 0x78

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFE874EDB80
        public void .ctor(){} // RVA: 0x7FFE874EDC90 | overloaded x2
        public void add_ValidationEventHandler(){} // RVA: 0x7FFE874EE280
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFE874EE4A0
        public void get_IsCompiled(){} // RVA: 0x7FFE812CF770
        public void set_XmlResolver(){} // RVA: 0x7FFE874EE600
        public void get_CompilationSettings(){} // RVA: 0x7FFE81463AE0
        public void set_CompilationSettings(){} // RVA: 0x7FFE81464570
        public void get_Count(){} // RVA: 0x7FFE874EE620
        public void get_GlobalElements(){} // RVA: 0x7FFE874EE650
        public void get_GlobalAttributes(){} // RVA: 0x7FFE874EE710
        public void get_GlobalTypes(){} // RVA: 0x7FFE874EE7D0
        public void get_SubstitutionGroups(){} // RVA: 0x7FFE874EE890
        public void get_SchemaLocations(){} // RVA: 0x7FFE81178740
        public void get_TypeExtensions(){} // RVA: 0x7FFE874EE950
        public void Add(){} // RVA: 0x7FFE874F16D0 | overloaded x4
        public void RemoveRecursive(){} // RVA: 0x7FFE874EF590
        public void Contains(){} // RVA: 0x7FFE874EFF20
        public void Compile(){} // RVA: 0x7FFE874EFFA0
        public void Reprocess(){} // RVA: 0x7FFE874F09D0
        public void CopyTo(){} // RVA: 0x7FFE874F1310
        public void Schemas(){} // RVA: 0x7FFE874F1470 | overloaded x2
        public void FindSchemaByNSAndUrl(){} // RVA: 0x7FFE874F1C30
        public void AddSchemaToSet(){} // RVA: 0x7FFE874F1F80
        public void ProcessNewSubstitutionGroups(){} // RVA: 0x7FFE874F2470
        public void ResolveSubstitutionGroup(){} // RVA: 0x7FFE874F2810
        public void Remove(){} // RVA: 0x7FFE874F2C40
        public void ClearTables(){} // RVA: 0x7FFE874F3030
        public void PreprocessSchema(){} // RVA: 0x7FFE874F3170
        public void ParseSchema(){} // RVA: 0x7FFE874F3420
        public void CopyFromCompiledSet(){} // RVA: 0x7FFE874F35D0
        public void get_CompiledInfo(){} // RVA: 0x7FFE81199370
        public void get_ReaderSettings(){} // RVA: 0x7FFE81176D50
        public void GetResolver(){} // RVA: 0x7FFE874F49A0
        public void GetEventHandler(){} // RVA: 0x7FFE8144E200
        public void GetSchemaNames(){} // RVA: 0x7FFE874F49C0
        public void IsSchemaLoaded(){} // RVA: 0x7FFE874F4AC0
        public void GetSchemaByUri(){} // RVA: 0x7FFE874F57F0
        public void GetTargetNamespace(){} // RVA: 0x7FFE874F5A40
        public void get_SortedSchemas(){} // RVA: 0x7FFE811290C0
        public void RemoveSchemaFromCaches(){} // RVA: 0x7FFE874F5AA0
        public void RemoveSchemaFromGlobalTables(){} // RVA: 0x7FFE874F5F70
        public void AddToTable(){} // RVA: 0x7FFE874F6980
        public void VerifyTables(){} // RVA: 0x7FFE874F6CF0
        public void InternalValidationCallback(){} // RVA: 0x7FFE874F6F30
        public void SendValidationEvent(){} // RVA: 0x7FFE874F6F80
    }

    public class XmlSchemaSimpleContent : XmlSchemaContentModel
    {
        public System.Xml.Schema.XmlSchemaContent content; // 0x50

        // ── Methods ──
        public void get_Content(){} // RVA: 0x7FFE8119C0E0
        public void set_Content(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaSimpleContentExtension : XmlSchemaContent
    {
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x50
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x58
        public System.Xml.XmlQualifiedName baseTypeName; // 0x60

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFE81199370
        public void set_BaseTypeName(){} // RVA: 0x7FFE874F7050
        public void get_Attributes(){} // RVA: 0x7FFE8119C0E0
        public void get_AnyAttribute(){} // RVA: 0x7FFE811C3500
        public void set_AnyAttribute(){} // RVA: 0x7FFE811C3510
        public void SetAttributes(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE874F7130
    }

    public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
    {
        public System.Xml.XmlQualifiedName baseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType baseType; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection facets; // 0x60
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x68
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x70

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFE8119C0E0
        public void set_BaseTypeName(){} // RVA: 0x7FFE874F7270
        public void get_BaseType(){} // RVA: 0x7FFE811C3500
        public void set_BaseType(){} // RVA: 0x7FFE811C3510
        public void get_Facets(){} // RVA: 0x7FFE81199370
        public void get_Attributes(){} // RVA: 0x7FFE81176D50
        public void get_AnyAttribute(){} // RVA: 0x7FFE811C3590
        public void set_AnyAttribute(){} // RVA: 0x7FFE811C35A0
        public void SetAttributes(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE874F7350
    }

    public class XmlSchemaSimpleType : XmlSchemaType
    {
        public System.Xml.Schema.XmlSchemaSimpleTypeContent content; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874F7510
        public void get_Content(){} // RVA: 0x7FFE817AE360
        public void set_Content(){} // RVA: 0x7FFE8171B470
        public void Clone(){} // RVA: 0x7FFE874F7520
    }

    public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
    {
        public System.Xml.XmlQualifiedName itemTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType itemType; // 0x58
        public System.Xml.Schema.XmlSchemaSimpleType baseItemType; // 0x60

        // ── Methods ──
        public void get_ItemTypeName(){} // RVA: 0x7FFE8119C0E0
        public void set_ItemTypeName(){} // RVA: 0x7FFE874F7690
        public void get_ItemType(){} // RVA: 0x7FFE811C3500
        public void set_ItemType(){} // RVA: 0x7FFE811C3510
        public void get_BaseItemType(){} // RVA: 0x7FFE81199370
        public void set_BaseItemType(){} // RVA: 0x7FFE81199380
        public void Clone(){} // RVA: 0x7FFE874F7770
        public void .ctor(){} // RVA: 0x7FFE874F78D0
    }

    public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
    {
        public System.Xml.XmlQualifiedName baseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType baseType; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection facets; // 0x60

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFE8119C0E0
        public void set_BaseTypeName(){} // RVA: 0x7FFE874F7980
        public void get_BaseType(){} // RVA: 0x7FFE811C3500
        public void set_BaseType(){} // RVA: 0x7FFE811C3510
        public void get_Facets(){} // RVA: 0x7FFE81199370
        public void Clone(){} // RVA: 0x7FFE874F7A60
        public void .ctor(){} // RVA: 0x7FFE874F7BC0
    }

    public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
    {
        public System.Xml.Schema.XmlSchemaObjectCollection baseTypes; // 0x50
        public System.Xml.XmlQualifiedName[] memberTypes; // 0x58
        public System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes; // 0x60

        // ── Methods ──
        public void get_BaseTypes(){} // RVA: 0x7FFE8119C0E0
        public void get_MemberTypes(){} // RVA: 0x7FFE811C3500
        public void set_MemberTypes(){} // RVA: 0x7FFE811C3510
        public void get_BaseMemberTypes(){} // RVA: 0x7FFE81199370
        public void SetBaseMemberTypes(){} // RVA: 0x7FFE81199380
        public void Clone(){} // RVA: 0x7FFE874F7D10
        public void .ctor(){} // RVA: 0x7FFE874F7FF0
    }

    public class XmlSchemaSubstitutionGroup : XmlSchemaObject
    {
        public System.Collections.ArrayList membersList; // 0x38
        public System.Xml.XmlQualifiedName examplar; // 0x40

        // ── Methods ──
        public void get_Members(){} // RVA: 0x7FFE8143BA80
        public void get_Examplar(){} // RVA: 0x7FFE81178740
        public void set_Examplar(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE874F8090
    }

    public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
    {
        public System.Xml.Schema.XmlSchemaChoice choice; // 0x48

        // ── Methods ──
        public void get_Choice(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE874F81D0
    }

    public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E98D0
    }

    public class XmlSchemaType : XmlSchemaAnnotated
    {
        public string name; // 0x50
        public 0x6655CEF4 final; // 0x58
        public 0x6655CEF4 derivedBy; // 0x5C
        public System.Xml.Schema.XmlSchemaType baseSchemaType; // 0x60
        public System.Xml.Schema.XmlSchemaDatatype datatype; // 0x68
        public 0x6655CEF4 finalResolved; // 0x70
        public System.Xml.Schema.SchemaElementDecl elementDecl; // 0x78
        public System.Xml.XmlQualifiedName qname; // 0x80
        public System.Xml.Schema.XmlSchemaType redefined; // 0x88
        public 0x6655CE44 contentType; // 0x90
        public object field_10; // 0x65A
        public object field_11; // 0x65B
        public object field_12; // 0x65C
        public object field_13; // 0x65D

        // ── Methods ──
        public void GetBuiltInSimpleType(){} // RVA: 0x7FFE874F8350 | overloaded x2
        public void GetBuiltInComplexType(){} // RVA: 0x7FFE874F83A0
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void set_Name(){} // RVA: 0x7FFE812534D0
        public void get_Final(){} // RVA: 0x7FFE8175AC90
        public void set_Final(){} // RVA: 0x7FFE8175AE70
        public void get_QualifiedName(){} // RVA: 0x7FFE874F8520
        public void get_FinalResolved(){} // RVA: 0x7FFE81E60180
        public void get_BaseXmlSchemaType(){} // RVA: 0x7FFE81199370
        public void get_DerivedBy(){} // RVA: 0x7FFE813A7A20
        public void get_Datatype(){} // RVA: 0x7FFE81176D50
        public void get_IsMixed(){} // RVA: 0x7FFE810FB320
        public void set_IsMixed(){} // RVA: 0x7FFE810FB310
        public void get_TypeCode(){} // RVA: 0x7FFE874F8530
        public void get_ValueConverter(){} // RVA: 0x7FFE874F85F0
        public void get_SchemaContentType(){} // RVA: 0x7FFE814AA220
        public void SetQualifiedName(){} // RVA: 0x7FFE874F8670
        public void SetFinalResolved(){} // RVA: 0x7FFE81293CF0
        public void SetBaseSchemaType(){} // RVA: 0x7FFE81199380
        public void SetDerivedBy(){} // RVA: 0x7FFE8175ACA0
        public void SetDatatype(){} // RVA: 0x7FFE81176D60
        public void get_ElementDecl(){} // RVA: 0x7FFE874F86D0
        public void set_ElementDecl(){} // RVA: 0x7FFE874F86E0
        public void get_Redefined(){} // RVA: 0x7FFE8113A010
        public void set_Redefined(){} // RVA: 0x7FFE81280F90
        public void SetContentType(){} // RVA: 0x7FFE81C8DB30
        public void IsDerivedFrom(){} // RVA: 0x7FFE874F8740
        public void IsDerivedFromDatatype(){} // RVA: 0x7FFE874F88D0
        public void get_NameAttribute(){} // RVA: 0x7FFE8119C0E0
        public void set_NameAttribute(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE874F89B0
    }

    public class XmlSchemaUnique : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E9F60
    }

    public class XmlSchemaValidationException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874F8B40 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFE8747A560
    }

    public class XmlSchemaValidator : Object
    {
        public System.Xml.Schema.XmlSchemaSet schemaSet; // 0x10
        public 0x6655E444 validationFlags; // 0x18
        public int startIDConstraint; // 0x1C
        public bool isRoot; // 0x20
        public bool rootHasSchema; // 0x21
        public bool attrValid; // 0x22
        public bool checkEntity; // 0x23
        public System.Xml.Schema.SchemaInfo compiledSchemaInfo; // 0x28
        public System.Xml.IDtdInfo dtdSchemaInfo; // 0x30
        public System.Collections.Hashtable validatedNamespaces; // 0x38
        public System.Xml.HWStack validationStack; // 0x40
        public System.Xml.Schema.ValidationState context; // 0x48
        public 0x6655E49C currentState; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874F8C50
        public void Init(){} // RVA: 0x7FFE874F8FA0
        public void Reset(){} // RVA: 0x7FFE874F98C0
        public void set_XmlResolver(){} // RVA: 0x7FFE8117C8A0
        public void set_LineInfoProvider(){} // RVA: 0x7FFE874F99E0
        public void set_SourceUri(){} // RVA: 0x7FFE874F9AB0
        public void set_ValidationEventSender(){} // RVA: 0x7FFE811660C0
        public void add_ValidationEventHandler(){} // RVA: 0x7FFE874F9BA0
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFE874F9CA0
        public void AddSchema(){} // RVA: 0x7FFE874F9DA0
        public void Initialize(){} // RVA: 0x7FFE874FA330 | overloaded x2
        public void ValidateElement(){} // RVA: 0x7FFE874FA650
        public void ValidateAttribute(){} // RVA: 0x7FFE874FACA0 | overloaded x2
        public void ValidateEndOfAttributes(){} // RVA: 0x7FFE874FB720
        public void ValidateText(){} // RVA: 0x7FFE874FB870 | overloaded x2
        public void ValidateWhitespace(){} // RVA: 0x7FFE874FBD50 | overloaded x2
        public void ValidateEndElement(){} // RVA: 0x7FFE874FBFE0
        public void SkipToEndElement(){} // RVA: 0x7FFE874FBFF0
        public void EndValidation(){} // RVA: 0x7FFE874FC270
        public void GetUnspecifiedDefaultAttributes(){} // RVA: 0x7FFE874FC4F0
        public void get_SchemaSet(){} // RVA: 0x7FFE81116380
        public void get_ValidationFlags(){} // RVA: 0x7FFE813DB630
        public void get_CurrentContentType(){} // RVA: 0x7FFE874FCC30
        public void SetDtdSchemaInfo(){} // RVA: 0x7FFE874FCC70
        public void get_StrictlyAssessed(){} // RVA: 0x7FFE874FCCD0
        public void get_HasSchema(){} // RVA: 0x7FFE874FCD10
        public void GetConcatenatedValue(){} // RVA: 0x7FFE874FCD60
        public void InternalValidateEndElement(){} // RVA: 0x7FFE874FCD90
        public void ProcessSchemaLocations(){} // RVA: 0x7FFE874FD430
        public void ValidateElementContext(){} // RVA: 0x7FFE874FD780
        public void GetSubstitutionGroupHead(){} // RVA: 0x7FFE874FDD70
        public void ValidateAtomicValue(){} // RVA: 0x7FFE874FE380 | overloaded x2
        public void GetTypeName(){} // RVA: 0x7FFE874FE810
        public void SaveTextValue(){} // RVA: 0x7FFE874FE880
        public void Push(){} // RVA: 0x7FFE874FE8D0
        public void Pop(){} // RVA: 0x7FFE874FECE0
        public void FastGetElementDecl(){} // RVA: 0x7FFE874FEEE0
        public void CheckXsiTypeAndNil(){} // RVA: 0x7FFE874FF240
        public void ThrowDeclNotFoundWarningOrError(){} // RVA: 0x7FFE874FF9C0
        public void CheckElementProperties(){} // RVA: 0x7FFE874FFC20
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7FFE874FFD20
        public void CheckIsXmlAttribute(){} // RVA: 0x7FFE874FFD80
        public void AddXmlNamespaceSchema(){} // RVA: 0x7FFE874FFF10
        public void CheckMixedValueConstraint(){} // RVA: 0x7FFE87500000
        public void LoadSchema(){} // RVA: 0x7FFE87500130
        public void RecompileSchemaSet(){} // RVA: 0x7FFE87500580
        public void ProcessTokenizedType(){} // RVA: 0x7FFE87500640
        public void CheckAttributeValue(){} // RVA: 0x7FFE87500920
        public void CheckElementValue(){} // RVA: 0x7FFE87500BF0
        public void CheckTokenizedTypes(){} // RVA: 0x7FFE87500F30
        public void FindId(){} // RVA: 0x7FFE875010C0
        public void CheckForwardRefs(){} // RVA: 0x7FFE875010F0
        public void get_HasIdentityConstraints(){} // RVA: 0x7FFE87501280
        public void get_ProcessIdentityConstraints(){} // RVA: 0x7FFE865A0910
        public void get_ReportValidationWarnings(){} // RVA: 0x7FFE865A0350
        public void get_ProcessSchemaHints(){} // RVA: 0x7FFE875012A0
        public void CheckStateTransition(){} // RVA: 0x7FFE875012C0
        public void ClearPSVI(){} // RVA: 0x7FFE87501560
        public void CheckRequiredAttributes(){} // RVA: 0x7FFE87501600
        public void GetSchemaElement(){} // RVA: 0x7FFE875018D0
        public void GetDefaultAttributePrefix(){} // RVA: 0x7FFE87501A20
        public void AddIdentityConstraints(){} // RVA: 0x7FFE87501CD0
        public void ElementIdentityConstraints(){} // RVA: 0x7FFE875022C0
        public void AttributeIdentityConstraints(){} // RVA: 0x7FFE87502670
        public void EndElementIdentityConstraints(){} // RVA: 0x7FFE875029C0
        public void ElementValidationError(){} // RVA: 0x7FFE87503800
        public void CompleteValidationError(){} // RVA: 0x7FFE87504010
        public void PrintExpectedElements(){} // RVA: 0x7FFE87504560
        public void PrintNames(){} // RVA: 0x7FFE875049E0
        public void PrintNamesWithNS(){} // RVA: 0x7FFE87504B80
        public void EnumerateAny(){} // RVA: 0x7FFE875051C0
        public void QNameString(){} // RVA: 0x7FFE87505450
        public void BuildElementName(){} // RVA: 0x7FFE87505530 | overloaded x2
        public void ProcessEntity(){} // RVA: 0x7FFE875056A0
        public void SendValidationEvent(){} // RVA: 0x7FFE87506160 | overloaded x11
        public void .cctor(){} // RVA: 0x7FFE87506220
    }

    public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874E98F0
    }

    public class XmlSchemaXPath : XmlSchemaAnnotated
    {
        public string xpath; // 0x50

        // ── Methods ──
        public void get_XPath(){} // RVA: 0x7FFE8119C0E0
        public void set_XPath(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlStringConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8751AF00
        public void Create(){} // RVA: 0x7FFE8751AF60
        public void ToString(){} // RVA: 0x7FFE8751AFF0
        public void ChangeType(){} // RVA: 0x7FFE8751B4E0 | overloaded x2
    }

    public class XmlUnionConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875292D0
        public void Create(){} // RVA: 0x7FFE87529670
        public void ChangeType(){} // RVA: 0x7FFE875296D0
    }

    public class XmlUntypedConverter : XmlListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8751BA60 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFE8751BCF0 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFE8751BF90 | overloaded x2
        public void ToDateTimeOffset(){} // RVA: 0x7FFE8751C2A0 | overloaded x2
        public void ToDecimal(){} // RVA: 0x7FFE8751C5C0 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFE8751C8D0 | overloaded x2
        public void ToInt32(){} // RVA: 0x7FFE8751CB80 | overloaded x2
        public void ToInt64(){} // RVA: 0x7FFE8751CE40 | overloaded x2
        public void ToSingle(){} // RVA: 0x7FFE8751D0F0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8751D720 | overloaded x9
        public void ChangeType(){} // RVA: 0x7FFE87520140 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFE875219D0
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFE87521B30
        public void ChangeListType(){} // RVA: 0x7FFE87521CB0
        public void SupportsType(){} // RVA: 0x7FFE87522000
        public void .cctor(){} // RVA: 0x7FFE87522580
    }

    public class XmlValueConverter : Object
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0x7FFE80E2F3B0 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFE80E33B00 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFE80E2E390 | overloaded x6
        public void ToDecimal(){} // overloaded x2
        public void ToDouble(){} // RVA: 0x7FFE80E34350 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFE80E43520 | overloaded x3
        public void ToDateTime(){} // overloaded x7
        public void ToDateTimeOffset(){} // overloaded x3
        public void ToString(){} // RVA: 0x7FFE80E3FC10 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFE80E403A0 | overloaded x9
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlValueGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3700
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class XsdBuilder : SchemaBuilder
    {
        public dFixup.ÎÍÎÍÏÍÎ[] SchemaElement;
        public dFixup.ÎÍÎÍÏÍÎ[] SchemaSubelements; // 0x8
        public dFixup.ÎÍÎÍÏÍÎ[] AttributeSubelements; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87529B70
        public void ProcessElement(){} // RVA: 0x7FFE8752A1D0
        public void ProcessAttribute(){} // RVA: 0x7FFE8752A4B0
        public void IsContentParsed(){} // RVA: 0x7FFE8752AAC0
        public void ProcessMarkup(){} // RVA: 0x7FFE81B10700
        public void ProcessCData(){} // RVA: 0x7FFE8752AAE0
        public void StartChildren(){} // RVA: 0x7FFE8752AB30
        public void EndChildren(){} // RVA: 0x7FFE8752AD70
        public void Push(){} // RVA: 0x7FFE8752ADC0
        public void Pop(){} // RVA: 0x7FFE8752B0F0
        public void get_CurrentElement(){} // RVA: 0x7FFE8677C2D0
        public void get_ParentElement(){} // RVA: 0x7FFE8752B250
        public void get_ParentContainer(){} // RVA: 0x7FFE8752B2E0
        public void GetContainer(){} // RVA: 0x7FFE8752B380
        public void SetContainer(){} // RVA: 0x7FFE8752B5D0
        public void BuildAnnotated_Id(){} // RVA: 0x7FFE8752CD50
        public void BuildSchema_AttributeFormDefault(){} // RVA: 0x7FFE8752CD80
        public void BuildSchema_ElementFormDefault(){} // RVA: 0x7FFE8752CE40
        public void BuildSchema_TargetNamespace(){} // RVA: 0x7FFE8752CF00
        public void BuildSchema_Version(){} // RVA: 0x7FFE8752CF70
        public void BuildSchema_FinalDefault(){} // RVA: 0x7FFE8752CFE0
        public void BuildSchema_BlockDefault(){} // RVA: 0x7FFE8752D060
        public void InitSchema(){} // RVA: 0x7FFE8752D0E0
        public void InitInclude(){} // RVA: 0x7FFE8752D150
        public void BuildInclude_SchemaLocation(){} // RVA: 0x7FFE8752D2E0
        public void InitImport(){} // RVA: 0x7FFE8752D350
        public void BuildImport_Namespace(){} // RVA: 0x7FFE8752D4E0
        public void BuildImport_SchemaLocation(){} // RVA: 0x7FFE8752D550
        public void InitRedefine(){} // RVA: 0x7FFE8752D5C0
        public void BuildRedefine_SchemaLocation(){} // RVA: 0x7FFE8752D750
        public void EndRedefine(){} // RVA: 0x7FFE8752D7C0
        public void InitAttribute(){} // RVA: 0x7FFE8752D7E0
        public void BuildAttribute_Default(){} // RVA: 0x7FFE8752D980
        public void BuildAttribute_Fixed(){} // RVA: 0x7FFE8752D9F0
        public void BuildAttribute_Form(){} // RVA: 0x7FFE8752DA60
        public void BuildAttribute_Use(){} // RVA: 0x7FFE8752DB20
        public void BuildAttribute_Ref(){} // RVA: 0x7FFE8752DBE0
        public void BuildAttribute_Name(){} // RVA: 0x7FFE8752DD20
        public void BuildAttribute_Type(){} // RVA: 0x7FFE8752DD90
        public void InitElement(){} // RVA: 0x7FFE8752DED0
        public void BuildElement_Abstract(){} // RVA: 0x7FFE8752E0D0
        public void BuildElement_Block(){} // RVA: 0x7FFE8752E150
        public void BuildElement_Default(){} // RVA: 0x7FFE8752E1D0
        public void BuildElement_Form(){} // RVA: 0x7FFE8752E240
        public void BuildElement_SubstitutionGroup(){} // RVA: 0x7FFE8752E300
        public void BuildElement_Final(){} // RVA: 0x7FFE8752E440
        public void BuildElement_Fixed(){} // RVA: 0x7FFE8752E4C0
        public void BuildElement_MaxOccurs(){} // RVA: 0x7FFE8752E530
        public void BuildElement_MinOccurs(){} // RVA: 0x7FFE8752E560
        public void BuildElement_Name(){} // RVA: 0x7FFE8752E590
        public void BuildElement_Nillable(){} // RVA: 0x7FFE8752E600
        public void BuildElement_Ref(){} // RVA: 0x7FFE8752E680
        public void BuildElement_Type(){} // RVA: 0x7FFE8752E7C0
        public void InitSimpleType(){} // RVA: 0x7FFE8752E900
        public void BuildSimpleType_Name(){} // RVA: 0x7FFE8752EE90
        public void BuildSimpleType_Final(){} // RVA: 0x7FFE8752EF00
        public void InitSimpleTypeUnion(){} // RVA: 0x7FFE8752EF80
        public void BuildSimpleTypeUnion_MemberTypes(){} // RVA: 0x7FFE8752F1E0
        public void InitSimpleTypeList(){} // RVA: 0x7FFE8752F3E0
        public void BuildSimpleTypeList_ItemType(){} // RVA: 0x7FFE8752F5A0
        public void InitSimpleTypeRestriction(){} // RVA: 0x7FFE8752F6E0
        public void BuildSimpleTypeRestriction_Base(){} // RVA: 0x7FFE8752F8A0
        public void InitComplexType(){} // RVA: 0x7FFE8752F9E0
        public void BuildComplexType_Abstract(){} // RVA: 0x7FFE8752FC70
        public void BuildComplexType_Block(){} // RVA: 0x7FFE8752FD00
        public void BuildComplexType_Final(){} // RVA: 0x7FFE8752FD80
        public void BuildComplexType_Mixed(){} // RVA: 0x7FFE8752FE00
        public void BuildComplexType_Name(){} // RVA: 0x7FFE8752FE90
        public void InitComplexContent(){} // RVA: 0x7FFE8752FF00
        public void BuildComplexContent_Mixed(){} // RVA: 0x7FFE87530120
        public void InitComplexContentExtension(){} // RVA: 0x7FFE875301A0
        public void BuildComplexContentExtension_Base(){} // RVA: 0x7FFE87530460
        public void InitComplexContentRestriction(){} // RVA: 0x7FFE875305A0
        public void BuildComplexContentRestriction_Base(){} // RVA: 0x7FFE87530800
        public void InitSimpleContent(){} // RVA: 0x7FFE87530940
        public void InitSimpleContentExtension(){} // RVA: 0x7FFE87530B60
        public void BuildSimpleContentExtension_Base(){} // RVA: 0x7FFE87530D00
        public void InitSimpleContentRestriction(){} // RVA: 0x7FFE87530E40
        public void BuildSimpleContentRestriction_Base(){} // RVA: 0x7FFE87531180
        public void InitAttributeGroup(){} // RVA: 0x7FFE875312C0
        public void BuildAttributeGroup_Name(){} // RVA: 0x7FFE87531460
        public void InitAttributeGroupRef(){} // RVA: 0x7FFE875314D0
        public void BuildAttributeGroupRef_Ref(){} // RVA: 0x7FFE87531680
        public void InitAnyAttribute(){} // RVA: 0x7FFE875317C0
        public void BuildAnyAttribute_Namespace(){} // RVA: 0x7FFE87531D50
        public void BuildAnyAttribute_ProcessContents(){} // RVA: 0x7FFE87531DC0
        public void InitGroup(){} // RVA: 0x7FFE87531E80
        public void BuildGroup_Name(){} // RVA: 0x7FFE875320A0
        public void InitGroupRef(){} // RVA: 0x7FFE87532110
        public void BuildParticle_MaxOccurs(){} // RVA: 0x7FFE87532350
        public void BuildParticle_MinOccurs(){} // RVA: 0x7FFE87532380
        public void BuildGroupRef_Ref(){} // RVA: 0x7FFE875323B0
        public void InitAll(){} // RVA: 0x7FFE875324F0
        public void InitChoice(){} // RVA: 0x7FFE87532660
        public void InitSequence(){} // RVA: 0x7FFE875327D0
        public void InitAny(){} // RVA: 0x7FFE87532940
        public void BuildAny_Namespace(){} // RVA: 0x7FFE87532AF0
        public void BuildAny_ProcessContents(){} // RVA: 0x7FFE87532B60
        public void InitNotation(){} // RVA: 0x7FFE87532C20
        public void BuildNotation_Name(){} // RVA: 0x7FFE87532E10
        public void BuildNotation_Public(){} // RVA: 0x7FFE87532E80
        public void BuildNotation_System(){} // RVA: 0x7FFE87532EF0
        public void InitFacet(){} // RVA: 0x7FFE87532F60
        public void BuildFacet_Fixed(){} // RVA: 0x7FFE87533350
        public void BuildFacet_Value(){} // RVA: 0x7FFE875333E0
        public void InitIdentityConstraint(){} // RVA: 0x7FFE87533450
        public void BuildIdentityConstraint_Name(){} // RVA: 0x7FFE875338C0
        public void BuildIdentityConstraint_Refer(){} // RVA: 0x7FFE87533930
        public void InitSelector(){} // RVA: 0x7FFE87533B30
        public void BuildSelector_XPath(){} // RVA: 0x7FFE87533CF0
        public void InitField(){} // RVA: 0x7FFE87533D60
        public void BuildField_XPath(){} // RVA: 0x7FFE87533CF0
        public void InitAnnotation(){} // RVA: 0x7FFE87533F00
        public void InitAppinfo(){} // RVA: 0x7FFE87534120
        public void BuildAppinfo_Source(){} // RVA: 0x7FFE87534330
        public void EndAppinfo(){} // RVA: 0x7FFE875343F0
        public void InitDocumentation(){} // RVA: 0x7FFE87534460
        public void BuildDocumentation_Source(){} // RVA: 0x7FFE87534670
        public void BuildDocumentation_XmlLang(){} // RVA: 0x7FFE87534730
        public void EndDocumentation(){} // RVA: 0x7FFE87534970
        public void AddAttribute(){} // RVA: 0x7FFE875349E0
        public void AddParticle(){} // RVA: 0x7FFE87534C80
        public void GetNextState(){} // RVA: 0x7FFE875350D0
        public void IsSkipableElement(){} // RVA: 0x7FFE875352A0
        public void SetMinOccurs(){} // RVA: 0x7FFE875352D0
        public void SetMaxOccurs(){} // RVA: 0x7FFE87535330
        public void ParseBoolean(){} // RVA: 0x7FFE87535390
        public void ParseEnum(){} // RVA: 0x7FFE87535430
        public void ParseQName(){} // RVA: 0x7FFE87535550
        public void ParseBlockFinalEnum(){} // RVA: 0x7FFE875357A0
        public void ParseUriReference(){} // RVA: 0x7FFE827C4A80
        public void SendValidationEvent(){} // RVA: 0x7FFE87535F70 | overloaded x5
        public void RecordPosition(){} // RVA: 0x7FFE87535F80
        public void .cctor(){} // RVA: 0x7FFE87536100
    }

    public class XsdDateTime : ValueType
    {
        public System.DateTime dt; // 0x10
        public uint extra; // 0x18
        public int Lzyyyy;
        public int Lzyyyy_; // 0x4
        public int Lzyyyy_MM; // 0x8
        public int Lzyyyy_MM_; // 0xC
        public int Lzyyyy_MM_dd; // 0x10
        public int Lzyyyy_MM_ddT; // 0x14
        public int LzHH; // 0x18
        public int LzHH_; // 0x1C
        public int LzHH_mm; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8753CA50 | overloaded x5
        public void InitiateXsdDateTime(){} // RVA: 0x7FFE8753C450
        public void TryParse(){} // RVA: 0x7FFE8753C590
        public void get_InternalTypeCode(){} // RVA: 0x7FFE8753CCE0
        public void get_InternalKind(){} // RVA: 0x7FFE868B0D00
        public void get_Year(){} // RVA: 0x7FFE8753CCF0
        public void get_Month(){} // RVA: 0x7FFE8753CD80
        public void get_Day(){} // RVA: 0x7FFE8753CE10
        public void get_Hour(){} // RVA: 0x7FFE8753CEA0
        public void get_Minute(){} // RVA: 0x7FFE8753CEF0
        public void get_Second(){} // RVA: 0x7FFE8753CF40
        public void get_Fraction(){} // RVA: 0x7FFE8753CF90
        public void get_ZoneHour(){} // RVA: 0x7FFE828B3170
        public void get_ZoneMinute(){} // RVA: 0x7FFE828B30A0
        public void op_Implicit(){} // RVA: 0x7FFE8753DA80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8753DFD0
        public void PrintDate(){} // RVA: 0x7FFE8753E5D0
        public void PrintTime(){} // RVA: 0x7FFE8753E870
        public void PrintZone(){} // RVA: 0x7FFE8753ECD0
        public void IntToCharArray(){} // RVA: 0x7FFE8753F030
        public void ShortToCharArray(){} // RVA: 0x7FFE8753F0D0
        public void .cctor(){} // RVA: 0x7FFE8753F150
    }

    public class XsdDuration : ValueType
    {
        public int years; // 0x10
        public int months; // 0x14
        public int days; // 0x18
        public int hours; // 0x1C
        public int minutes; // 0x20
        public int seconds; // 0x24
        public uint nanoseconds; // 0x28
        public object field_7; // 0x687

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87541B20 | overloaded x5
        public void get_IsNegative(){} // RVA: 0x7FFE87541BD0
        public void get_Years(){} // RVA: 0x7FFE826F4220
        public void get_Months(){} // RVA: 0x7FFE826F42A0
        public void get_Days(){} // RVA: 0x7FFE82C33000
        public void get_Hours(){} // RVA: 0x7FFE82C33020
        public void get_Minutes(){} // RVA: 0x7FFE811485C0
        public void get_Seconds(){} // RVA: 0x7FFE8164B230
        public void get_Nanoseconds(){} // RVA: 0x7FFE87541BE0
        public void ToTimeSpan(){} // RVA: 0x7FFE87541C40 | overloaded x2
        public void TryToTimeSpan(){} // RVA: 0x7FFE87541CA0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE875422D0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFE87542790 | overloaded x2
        public void TryParseDigits(){} // RVA: 0x7FFE87543350
    }

    public class XsdSimpleValue : Object
    {
        public System.Xml.Schema.XmlSchemaSimpleType xmlType; // 0x10
        public object typedValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_XmlType(){} // RVA: 0x7FFE81116380
        public void get_TypedValue(){} // RVA: 0x7FFE810FE7C0
    }

    public class XsdValidator : BaseValidator
    {
        public int startIDConstraint; // 0x80
        public System.Xml.HWStack validationStack; // 0x88
        public System.Collections.Hashtable attPresence; // 0x90
        public System.Xml.XmlNamespaceManager nsManager; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875434D0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE87543500
        public void Validate(){} // RVA: 0x7FFE87543D40
        public void CompleteValidation(){} // RVA: 0x7FFE87543E20
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7FFE874D9180
        public void ProcessInlineSchema(){} // RVA: 0x7FFE87543FC0
        public void ValidateElement(){} // RVA: 0x7FFE87544290
        public void ValidateChildElement(){} // RVA: 0x7FFE875444A0
        public void ProcessElement(){} // RVA: 0x7FFE87544720
        public void ProcessXsiAttributes(){} // RVA: 0x7FFE87544B70
        public void ValidateEndElement(){} // RVA: 0x7FFE875454A0
        public void FastGetElementDecl(){} // RVA: 0x7FFE87545700
        public void ThoroughGetElementDecl(){} // RVA: 0x7FFE875457F0
        public void ValidateStartElement(){} // RVA: 0x7FFE87545D30
        public void ValidateEndStartElement(){} // RVA: 0x7FFE875466B0
        public void LoadSchemaFromLocation(){} // RVA: 0x7FFE87546B10
        public void LoadSchema(){} // RVA: 0x7FFE87547110
        public void get_HasSchema(){} // RVA: 0x7FFE874DAEF0
        public void get_PreserveWhitespace(){} // RVA: 0x7FFE874DAF10
        public void ProcessTokenizedType(){} // RVA: 0x7FFE87547300
        public void CheckValue(){} // RVA: 0x7FFE87547600
        public void AddID(){} // RVA: 0x7FFE87547BB0
        public void FindId(){} // RVA: 0x7FFE874DC1A0
        public void IsXSDRoot(){} // RVA: 0x7FFE87547CB0
        public void Push(){} // RVA: 0x7FFE87547CD0
        public void Pop(){} // RVA: 0x7FFE87548040
        public void CheckForwardRefs(){} // RVA: 0x7FFE87543E20
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7FFE875481C0
        public void get_HasIdentityConstraints(){} // RVA: 0x7FFE87548220
        public void AddIdentityConstraints(){} // RVA: 0x7FFE87548230
        public void ElementIdentityConstraints(){} // RVA: 0x7FFE87548890
        public void AttributeIdentityConstraints(){} // RVA: 0x7FFE87548CD0
        public void UnWrapUnion(){} // RVA: 0x7FFE87549060
        public void EndElementIdentityConstraints(){} // RVA: 0x7FFE875490E0
        public void .cctor(){} // RVA: 0x7FFE87549F00
    }

}