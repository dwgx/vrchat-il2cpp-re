// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 97
// Methods: 1524

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XdrBuilder
    {
        public int[] S_XDR_Root_Element;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x698E430
        public void ProcessElement(){} // RVA: 0x698EB50
        public void ProcessAttribute(){} // RVA: 0x698EE10
        public void set_XmlResolver(){} // RVA: 0x348130
        public void LoadSchema(){} // RVA: 0x698F3B0
        public void IsXdrSchema(){} // RVA: 0x698F8F0
        public void IsContentParsed(){} // RVA: 0x3C2850
        public void ProcessMarkup(){} // RVA: 0x698FC20
        public void ProcessCData(){} // RVA: 0x698FC80
        public void StartChildren(){} // RVA: 0x698FD50
        public void EndChildren(){} // RVA: 0x698FD90
        public void Push(){} // RVA: 0x698FED0
        public void Pop(){} // RVA: 0x698FF60
        public void PushGroupInfo(){} // RVA: 0x6990080
        public void PopGroupInfo(){} // RVA: 0x6990130
        public void XDR_InitRoot(){} // RVA: 0x6990250
        public void XDR_BuildRoot_Name(){} // RVA: 0x69903B0
        public void XDR_BuildRoot_ID(){} // RVA: 0x2DD310
        public void XDR_BeginRoot(){} // RVA: 0x6990510
        public void XDR_EndRoot(){} // RVA: 0x69906E0
        public void XDR_InitElementType(){} // RVA: 0x6990C10
        public void XDR_BuildElementType_Name(){} // RVA: 0x6990ED0
        public void XDR_BuildElementType_Content(){} // RVA: 0x69911F0
        public void XDR_BuildElementType_Model(){} // RVA: 0x69912A0
        public void XDR_BuildElementType_Order(){} // RVA: 0x6991430
        public void XDR_BuildElementType_DtType(){} // RVA: 0x69914F0
        public void XDR_BuildElementType_DtValues(){} // RVA: 0x69916C0
        public void XDR_BuildElementType_DtMaxLength(){} // RVA: 0x6991810
        public void XDR_BuildElementType_DtMinLength(){} // RVA: 0x69918A0
        public void XDR_BeginElementType(){} // RVA: 0x6991930
        public void XDR_EndElementType(){} // RVA: 0x6991CD0
        public void XDR_InitAttributeType(){} // RVA: 0x6992400
        public void XDR_BuildAttributeType_Name(){} // RVA: 0x6992600
        public void XDR_BuildAttributeType_Required(){} // RVA: 0x6992A60
        public void XDR_BuildAttributeType_Default(){} // RVA: 0x6992AE0
        public void XDR_BuildAttributeType_DtType(){} // RVA: 0x6992B50
        public void XDR_BuildAttributeType_DtValues(){} // RVA: 0x6992DC0
        public void XDR_BuildAttributeType_DtMaxLength(){} // RVA: 0x6992F10
        public void XDR_BuildAttributeType_DtMinLength(){} // RVA: 0x6992FA0
        public void XDR_BeginAttributeType(){} // RVA: 0x6993030
        public void XDR_EndAttributeType(){} // RVA: 0x69930F0
        public void XDR_InitElement(){} // RVA: 0x6993530
        public void XDR_BuildElement_Type(){} // RVA: 0x6993620
        public void XDR_BuildElement_MinOccurs(){} // RVA: 0x6993810
        public void XDR_BuildElement_MaxOccurs(){} // RVA: 0x6993890
        public void XDR_EndElement(){} // RVA: 0x6993910
        public void XDR_InitAttribute(){} // RVA: 0x6993A50
        public void XDR_BuildAttribute_Type(){} // RVA: 0x6993B20
        public void XDR_BuildAttribute_Required(){} // RVA: 0x6993CD0
        public void XDR_BuildAttribute_Default(){} // RVA: 0x6993D60
        public void XDR_BeginAttribute(){} // RVA: 0x6993DD0
        public void XDR_EndAttribute(){} // RVA: 0x6994470
        public void XDR_InitGroup(){} // RVA: 0x69944A0
        public void XDR_BuildGroup_Order(){} // RVA: 0x6994680
        public void XDR_BuildGroup_MinOccurs(){} // RVA: 0x6994770
        public void XDR_BuildGroup_MaxOccurs(){} // RVA: 0x6994800
        public void XDR_EndGroup(){} // RVA: 0x6994890
        public void XDR_InitElementDtType(){} // RVA: 0x6994B60
        public void XDR_EndElementDtType(){} // RVA: 0x6994C70
        public void XDR_InitAttributeDtType(){} // RVA: 0x6994E40
        public void XDR_EndAttributeDtType(){} // RVA: 0x6994EE0
        public void GetNextState(){} // RVA: 0x6995010
        public void IsSkipableElement(){} // RVA: 0x6995200
        public void IsSkipableAttribute(){} // RVA: 0x6995300
        public void GetOrder(){} // RVA: 0x6995470
        public void AddOrder(){} // RVA: 0x6995630
        public void IsYes(){} // RVA: 0x69956F0
        public void ParseMinOccurs(){} // RVA: 0x6995870
        public void ParseMaxOccurs(){} // RVA: 0x69959B0
        public void HandleMinMax(){} // RVA: 0x6995B10
        public void ParseDtMaxLength(){} // RVA: 0x6995B40
        public void ParseDtMinLength(){} // RVA: 0x6995CC0
        public void CompareMinMaxLength(){} // RVA: 0x6995E40
        public void ParseInteger(){} // RVA: 0x6995EC0
        public void XDR_CheckAttributeDefault(){} // RVA: 0x6995F00
        public void SetAttributePresence(){} // RVA: 0x6996010
        public void GetContent(){} // RVA: 0x6996060
        public void GetModel(){} // RVA: 0x6996270
        public void CheckDatatype(){} // RVA: 0x6996390
        public void CheckDefaultAttValue(){} // RVA: 0x6996520
        public void IsGlobal(){} // RVA: 0x6996690
        public void SendValidationEvent(){} // RVA: 0x6996960 | overloaded x4
        public void .cctor(){} // RVA: 0x6996A40
    }

    public class XdrValidator
    {
        public System.Xml.HWStack validationStack; // 0x80
        public System.Collections.Hashtable attPresence; // 0x88
        public System.Xml.XmlQualifiedName name; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6999190 | overloaded x2
        public void Init(){} // RVA: 0x6999290
        public void Validate(){} // RVA: 0x69996C0
        public void ValidateElement(){} // RVA: 0x69997A0
        public void ValidateChildElement(){} // RVA: 0x6999CE0
        public void get_IsInlineSchemaStarted(){} // RVA: 0x6999EB0
        public void ProcessInlineSchema(){} // RVA: 0x6999EC0
        public void ProcessElement(){} // RVA: 0x699A210
        public void ValidateEndElement(){} // RVA: 0x699A330
        public void ThoroughGetElementDecl(){} // RVA: 0x699A700
        public void ValidateStartElement(){} // RVA: 0x699AB30
        public void ValidateEndStartElement(){} // RVA: 0x699B050
        public void LoadSchemaFromLocation(){} // RVA: 0x699B410
        public void LoadSchema(){} // RVA: 0x699BA60
        public void get_HasSchema(){} // RVA: 0x699BC20
        public void get_PreserveWhitespace(){} // RVA: 0x699BC40
        public void ProcessTokenizedType(){} // RVA: 0x699BC90
        public void CompleteValidation(){} // RVA: 0x699BF90
        public void CheckValue(){} // RVA: 0x699C220
        public void CheckDefaultValue(){} // RVA: 0x699C8F0
        public void AddID(){} // RVA: 0x699CDD0
        public void FindId(){} // RVA: 0x699CED0
        public void Push(){} // RVA: 0x699CF00
        public void Pop(){} // RVA: 0x699D1F0
        public void CheckForwardRefs(){} // RVA: 0x699D340
        public void QualifiedName(){} // RVA: 0x699D4E0
    }

    public class XmlAnyConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69E3410
        public void ToBoolean(){} // RVA: 0x69E3610
        public void ToDateTime(){} // RVA: 0x69E3800
        public void ToDateTimeOffset(){} // RVA: 0x69E39F0
        public void ToDecimal(){} // RVA: 0x69E3C40
        public void ToDouble(){} // RVA: 0x69E3E90
        public void ToInt32(){} // RVA: 0x69E4080
        public void ToInt64(){} // RVA: 0x69E4270
        public void ToSingle(){} // RVA: 0x69E4460
        public void ChangeType(){} // RVA: 0x69E58B0 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x69E7280
        public void ChangeTypeWildcardSource(){} // RVA: 0x69E73E0
        public void ToNavigator(){} // RVA: 0x69E7560
        public void .cctor(){} // RVA: 0x69E7600
    }

    public class XmlAnyListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69E77E0
        public void ChangeType(){} // RVA: 0x69E77F0
        public void .cctor(){} // RVA: 0x69E7A80
    }

    public class XmlAtomicValue
    {
        public System.Xml.Schema.XmlSchemaType xmlType; // 0x10
        public object objVal; // 0x18
        public 0x657DC788 clrType; // 0x20
        public Union unionVal; // 0x28
        public NamespacePrefixForQName nsPrefix; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x699DF90 | overloaded x9
        public void System.ICloneable.Clone(){} // RVA: 0x1A3F520
        public void get_XmlType(){} // RVA: 0x2F8380
        public void get_ValueType(){} // RVA: 0x699E240
        public void get_TypedValue(){} // RVA: 0x699E280
        public void get_ValueAsBoolean(){} // RVA: 0x699E490
        public void get_ValueAsDateTime(){} // RVA: 0x699E5A0
        public void get_ValueAsDouble(){} // RVA: 0x699E6B0
        public void get_ValueAsInt(){} // RVA: 0x699E7C0
        public void get_ValueAsLong(){} // RVA: 0x699E8D0
        public void ValueAs(){} // RVA: 0x699E9E0
        public void get_Value(){} // RVA: 0x699EC50
        public void ToString(){} // RVA: 0x391BE0
        public void GetPrefixFromQName(){} // RVA: 0x699ED90
    }

    public class XmlBaseConverter
    {
        public System.Xml.Schema.XmlSchemaType schemaType; // 0x10
        public 0x658807B8 typeCode; // 0x18
        public System.Type clrTypeDefault; // 0x20
        public System.Type ICollectionType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C79D0 | overloaded x4
        public void ToBoolean(){} // RVA: 0x69C7F80 | overloaded x6
        public void ToDateTime(){} // RVA: 0x69C8610 | overloaded x7
        public void ToDateTimeOffset(){} // RVA: 0x69C88D0 | overloaded x3
        public void ToDecimal(){} // RVA: 0x69C8A90 | overloaded x2
        public void ToDouble(){} // RVA: 0x69C9040 | overloaded x6
        public void ToInt32(){} // RVA: 0x69C95B0 | overloaded x6
        public void ToInt64(){} // RVA: 0x69C9B20 | overloaded x6
        public void ToSingle(){} // RVA: 0x69C9DC0 | overloaded x3
        public void ToString(){} // RVA: 0x69CA6E0 | overloaded x10
        public void ChangeType(){} // RVA: 0x69CAA80 | overloaded x8
        public void get_SchemaType(){} // RVA: 0x2F8380
        public void get_TypeCode(){} // RVA: 0x5BED50
        public void get_XmlTypeName(){} // RVA: 0x69CAAB0
        public void get_DefaultClrType(){} // RVA: 0x30B0C0
        public void IsDerivedFrom(){} // RVA: 0x69CABC0
        public void CreateInvalidClrMappingException(){} // RVA: 0x69CAC70
        public void QNameToString(){} // RVA: 0x69CCC50 | overloaded x2
        public void ChangeListType(){} // RVA: 0x69CB0E0
        public void StringToBase64Binary(){} // RVA: 0x69CB140
        public void StringToDate(){} // RVA: 0x69CB260
        public void StringToDateTime(){} // RVA: 0x69CB2E0
        public void StringToDayTimeDuration(){} // RVA: 0x69CB360
        public void StringToDuration(){} // RVA: 0x69CB460
        public void StringToGDay(){} // RVA: 0x69CB560
        public void StringToGMonth(){} // RVA: 0x69CB5E0
        public void StringToGMonthDay(){} // RVA: 0x69CB660
        public void StringToGYear(){} // RVA: 0x69CB6E0
        public void StringToGYearMonth(){} // RVA: 0x69CB760
        public void StringToDateOffset(){} // RVA: 0x69CB7E0
        public void StringToDateTimeOffset(){} // RVA: 0x69CB880
        public void StringToGDayOffset(){} // RVA: 0x69CB920
        public void StringToGMonthOffset(){} // RVA: 0x69CB9C0
        public void StringToGMonthDayOffset(){} // RVA: 0x69CBA60
        public void StringToGYearOffset(){} // RVA: 0x69CBB00
        public void StringToGYearMonthOffset(){} // RVA: 0x69CBBA0
        public void StringToHexBinary(){} // RVA: 0x69CBC40
        public void StringToQName(){} // RVA: 0x69CBD70
        public void StringToTime(){} // RVA: 0x69CC070
        public void StringToTimeOffset(){} // RVA: 0x69CC0F0
        public void StringToYearMonthDuration(){} // RVA: 0x69CC190
        public void AnyUriToString(){} // RVA: 0x69CC290
        public void Base64BinaryToString(){} // RVA: 0x69CC300
        public void DateToString(){} // RVA: 0x69CC410
        public void DateTimeToString(){} // RVA: 0x69CC490
        public void DayTimeDurationToString(){} // RVA: 0x69CC510
        public void DurationToString(){} // RVA: 0x69CC580
        public void GDayToString(){} // RVA: 0x69CC5E0
        public void GMonthToString(){} // RVA: 0x69CC660
        public void GMonthDayToString(){} // RVA: 0x69CC6E0
        public void GYearToString(){} // RVA: 0x69CC760
        public void GYearMonthToString(){} // RVA: 0x69CC7E0
        public void DateOffsetToString(){} // RVA: 0x69CC860
        public void DateTimeOffsetToString(){} // RVA: 0x69CC8F0
        public void GDayOffsetToString(){} // RVA: 0x69CC980
        public void GMonthOffsetToString(){} // RVA: 0x69CCA10
        public void GMonthDayOffsetToString(){} // RVA: 0x69CCAA0
        public void GYearOffsetToString(){} // RVA: 0x69CCB30
        public void GYearMonthOffsetToString(){} // RVA: 0x69CCBC0
        public void TimeToString(){} // RVA: 0x69CCE40
        public void TimeOffsetToString(){} // RVA: 0x69CCEC0
        public void YearMonthDurationToString(){} // RVA: 0x69CCF50
        public void DateTimeOffsetToDateTime(){} // RVA: 0x69CCFC0
        public void DecimalToInt32(){} // RVA: 0x69CD010
        public void DecimalToInt64(){} // RVA: 0x69CD290
        public void DecimalToUInt64(){} // RVA: 0x69CD520
        public void Int32ToByte(){} // RVA: 0x69CD7A0
        public void Int32ToInt16(){} // RVA: 0x69CD8A0
        public void Int32ToSByte(){} // RVA: 0x69CD9A0
        public void Int32ToUInt16(){} // RVA: 0x69CDAA0
        public void Int64ToInt32(){} // RVA: 0x69CDBA0
        public void Int64ToUInt32(){} // RVA: 0x69CDCA0
        public void UntypedAtomicToDateTime(){} // RVA: 0x69CDDA0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x69CDE20
        public void .cctor(){} // RVA: 0x69CDEC0
    }

    public class XmlBooleanConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69D8390
        public void Create(){} // RVA: 0x69D83F0
        public void ToBoolean(){} // RVA: 0x69D8520 | overloaded x2
        public void ToString(){} // RVA: 0x69D88C0 | overloaded x2
        public void ChangeType(){} // RVA: 0x69D9230 | overloaded x3
    }

    public class XmlDateTimeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69D5BA0
        public void Create(){} // RVA: 0x69D5C00
        public void ToDateTime(){} // RVA: 0x69D6040 | overloaded x3
        public void ToDateTimeOffset(){} // RVA: 0x69D6740 | overloaded x3
        public void ToString(){} // RVA: 0x69D70D0 | overloaded x3
        public void ChangeType(){} // RVA: 0x69D7B80 | overloaded x3
    }

    public class XmlListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69E7FD0 | overloaded x3
        public void Create(){} // RVA: 0x69E8030
        public void ChangeType(){} // RVA: 0x69E8210
        public void ChangeListType(){} // RVA: 0x69E8340
        public void IsListType(){} // RVA: 0x69E9270
        public void ToArray(){} // RVA: 0x1E6A0
        public void ToList(){} // RVA: 0x69E9400
        public void StringAsList(){} // RVA: 0x69E9990
        public void ListAsString(){} // RVA: 0x69E9A40
        public void CreateInvalidClrMappingException(){} // RVA: 0x69E9CF0
    }

    public class XmlMiscConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69D9880
        public void Create(){} // RVA: 0x69D98E0
        public void ToString(){} // RVA: 0x69D9970
        public void ChangeType(){} // RVA: 0x69DA7F0 | overloaded x2
        public void ChangeTypeWildcardDestination(){} // RVA: 0x69DB920
        public void ChangeTypeWildcardSource(){} // RVA: 0x69DBA80
    }

    public class XmlNumeric10Converter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69CF870
        public void Create(){} // RVA: 0x69CF8D0
        public void ToDecimal(){} // RVA: 0x69CFAE0 | overloaded x2
        public void ToInt32(){} // RVA: 0x69D01A0 | overloaded x3
        public void ToInt64(){} // RVA: 0x69D0760 | overloaded x3
        public void ToString(){} // RVA: 0x69D0F30 | overloaded x4
        public void ChangeType(){} // RVA: 0x69D2440 | overloaded x5
        public void ChangeTypeWildcardDestination(){} // RVA: 0x69D3500
        public void ChangeTypeWildcardSource(){} // RVA: 0x69D3950
    }

    public class XmlNumeric2Converter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69D3DF0
        public void Create(){} // RVA: 0x69D3E50
        public void ToDouble(){} // RVA: 0x69D3FC0 | overloaded x2
        public void ToSingle(){} // RVA: 0x69D4440 | overloaded x3
        public void ToString(){} // RVA: 0x69D4960 | overloaded x3
        public void ChangeType(){} // RVA: 0x69D5400 | overloaded x3
    }

    public class XmlSchema
    {
        public 0x6587F738 attributeFormDefault; // 0x38
        public 0x6587F738 elementFormDefault; // 0x3C
        public 0x6587F058 blockDefault; // 0x40
        public 0x6587F058 finalDefault; // 0x44
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
        public void .ctor(){} // RVA: 0x699F110
        public void Read(){} // RVA: 0x699F590
        public void CompileSchema(){} // RVA: 0x699F730
        public void CompileSchemaInSet(){} // RVA: 0x699FBB0
        public void get_AttributeFormDefault(){} // RVA: 0xFDC9F0
        public void set_AttributeFormDefault(){} // RVA: 0xFDD6E0
        public void get_BlockDefault(){} // RVA: 0x37E080
        public void set_BlockDefault(){} // RVA: 0x37E090
        public void get_FinalDefault(){} // RVA: 0x37E0A0
        public void set_FinalDefault(){} // RVA: 0x37E0B0
        public void get_ElementFormDefault(){} // RVA: 0x891AF0
        public void set_ElementFormDefault(){} // RVA: 0x1CB95F0
        public void get_TargetNamespace(){} // RVA: 0x358730
        public void set_TargetNamespace(){} // RVA: 0x358740
        public void get_Version(){} // RVA: 0x37E0E0
        public void set_Version(){} // RVA: 0x4354D0
        public void get_Includes(){} // RVA: 0x3A5500
        public void get_Items(){} // RVA: 0x37B370
        public void get_IsCompiledBySet(){} // RVA: 0x8A7360
        public void set_IsCompiledBySet(){} // RVA: 0x8A8570
        public void get_IsPreprocessed(){} // RVA: 0x8A3000
        public void set_IsPreprocessed(){} // RVA: 0x8A8560
        public void get_IsRedefined(){} // RVA: 0x8A7350
        public void set_IsRedefined(){} // RVA: 0x8A3210
        public void get_Attributes(){} // RVA: 0x699FC70
        public void get_AttributeGroups(){} // RVA: 0x699FD30
        public void get_SchemaTypes(){} // RVA: 0x699FDF0
        public void get_Elements(){} // RVA: 0x699FEB0
        public void get_Id(){} // RVA: 0x358D50
        public void set_Id(){} // RVA: 0x358D60
        public void get_Groups(){} // RVA: 0xA085E0
        public void get_Notations(){} // RVA: 0xA1C130
        public void get_IdentityConstraints(){} // RVA: 0x348040
        public void get_BaseUri(){} // RVA: 0x3FA100
        public void set_BaseUri(){} // RVA: 0x3FA110
        public void get_SchemaId(){} // RVA: 0x699FF70
        public void get_IsChameleon(){} // RVA: 0x12FD610
        public void set_IsChameleon(){} // RVA: 0x612FB20
        public void get_Ids(){} // RVA: 0x35E900
        public void get_Document(){} // RVA: 0x699FFF0
        public void get_ErrorCount(){} // RVA: 0x1AE6E60
        public void set_ErrorCount(){} // RVA: 0x6248F70
        public void Clone(){} // RVA: 0x69A00B0
        public void DeepClone(){} // RVA: 0x69A0350
        public void get_IdAttribute(){} // RVA: 0x358D50
        public void set_IdAttribute(){} // RVA: 0x358D60
        public void SetIsCompiled(){} // RVA: 0x1688890
        public void SetUnhandledAttributes(){} // RVA: 0x3A55A0
        public void AddAnnotation(){} // RVA: 0x69A0900
        public void get_ImportedSchemas(){} // RVA: 0x69A0960
        public void get_ImportedNamespaces(){} // RVA: 0x69A0A20
        public void GetExternalSchemasList(){} // RVA: 0x69A0AE0
        public void .cctor(){} // RVA: 0x69A0C60
    }

    public class XmlSchemaAll
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x78

        // ── Methods ──
        public void get_Items(){} // RVA: 0x4C7C50
        public void get_IsEmpty(){} // RVA: 0x69A0CA0
        public void SetItems(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x69A0D00
    }

    public class XmlSchemaAnnotated
    {
        public string id; // 0x38
        public System.Xml.Schema.XmlSchemaAnnotation annotation; // 0x40
        public System.Xml.XmlAttribute[] moreAttributes; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x4976A0
        public void set_Id(){} // RVA: 0x49B830
        public void get_Annotation(){} // RVA: 0x35A740
        public void set_Annotation(){} // RVA: 0x305200
        public void get_UnhandledAttributes(){} // RVA: 0x358730
        public void set_UnhandledAttributes(){} // RVA: 0x358740
        public void get_IdAttribute(){} // RVA: 0x4976A0
        public void set_IdAttribute(){} // RVA: 0x49B830
        public void SetUnhandledAttributes(){} // RVA: 0x358740
        public void AddAnnotation(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaAnnotation
    {
        public string id; // 0x38
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x40
        public System.Xml.XmlAttribute[] moreAttributes; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x4976A0
        public void set_Id(){} // RVA: 0x49B830
        public void get_Items(){} // RVA: 0x35A740
        public void get_IdAttribute(){} // RVA: 0x4976A0
        public void set_IdAttribute(){} // RVA: 0x49B830
        public void SetUnhandledAttributes(){} // RVA: 0x358740
        public void .ctor(){} // RVA: 0x69A0DE0
    }

    public class XmlSchemaAny
    {
        public string ns; // 0x78
        public 0x6587EF50 processContents; // 0x80
        public System.Xml.Schema.NamespaceList namespaceList; // 0x88

        // ── Methods ──
        public void get_Namespace(){} // RVA: 0x4C7C50
        public void set_Namespace(){} // RVA: 0x4C34F0
        public void set_ProcessContents(){} // RVA: 0xFC4560
        public void get_NamespaceList(){} // RVA: 0x31C010
        public void get_ResolvedNamespace(){} // RVA: 0x69A0E80
        public void get_ProcessContentsCorrect(){} // RVA: 0x69A0ED0
        public void get_NameString(){} // RVA: 0x69A0EF0
        public void BuildNamespaceList(){} // RVA: 0x69A1330
        public void BuildNamespaceListV1Compat(){} // RVA: 0x69A1490
        public void Allows(){} // RVA: 0x69A1600
        public void .ctor(){} // RVA: 0x69A1640
    }

    public class XmlSchemaAnyAttribute
    {
        public string ns; // 0x50
        public 0x6587EF50 processContents; // 0x58
        public System.Xml.Schema.NamespaceList namespaceList; // 0x60

        // ── Methods ──
        public void set_Namespace(){} // RVA: 0x4354D0
        public void get_ProcessContents(){} // RVA: 0x9EAB90
        public void set_ProcessContents(){} // RVA: 0x9EAAE0
        public void get_NamespaceList(){} // RVA: 0x37B370
        public void get_ProcessContentsCorrect(){} // RVA: 0x69A1690
        public void BuildNamespaceList(){} // RVA: 0x69A16A0
        public void BuildNamespaceListV1Compat(){} // RVA: 0x69A17E0
        public void Allows(){} // RVA: 0x69A1940
        public void IsSubset(){} // RVA: 0x69A1980
        public void Intersection(){} // RVA: 0x69A19B0
        public void Union(){} // RVA: 0x69A1B20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaAppInfo
    {
        public string source; // 0x38
        public System.Xml.XmlNode[] markup; // 0x40

        // ── Methods ──
        public void set_Source(){} // RVA: 0x49B830
        public void get_Markup(){} // RVA: 0x35A740
        public void set_Markup(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaAttribute
    {
        public string defaultValue; // 0x50
        public string fixedValue; // 0x58
        public string name; // 0x60
        public 0x6587F738 form; // 0x68
        public 0x658804A0 use; // 0x6C
        public System.Xml.XmlQualifiedName refName; // 0x70
        public System.Xml.XmlQualifiedName typeName; // 0x78
        public System.Xml.XmlQualifiedName qualifiedName; // 0x80
        public System.Xml.Schema.XmlSchemaSimpleType type; // 0x88
        public System.Xml.Schema.XmlSchemaSimpleType attributeType; // 0x90
        public System.Xml.Schema.SchemaAttDef attDef; // 0x98

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x37E0E0
        public void set_DefaultValue(){} // RVA: 0x4354D0
        public void get_FixedValue(){} // RVA: 0x3A5500
        public void set_FixedValue(){} // RVA: 0x3A5510
        public void get_Form(){} // RVA: 0x1C91440
        public void set_Form(){} // RVA: 0x1C91450
        public void get_Name(){} // RVA: 0x37B370
        public void set_Name(){} // RVA: 0x37B380
        public void get_RefName(){} // RVA: 0x3A5590
        public void set_RefName(){} // RVA: 0x69A1C90
        public void get_SchemaTypeName(){} // RVA: 0x4C7C50
        public void set_SchemaTypeName(){} // RVA: 0x69A1D70
        public void get_SchemaType(){} // RVA: 0x31C010
        public void set_SchemaType(){} // RVA: 0x463060
        public void get_Use(){} // RVA: 0x1C91460
        public void set_Use(){} // RVA: 0x1C91470
        public void get_QualifiedName(){} // RVA: 0x462D00
        public void get_AttributeSchemaType(){} // RVA: 0x796DE0
        public void get_Datatype(){} // RVA: 0x69A1E50
        public void SetQualifiedName(){} // RVA: 0x464450
        public void SetAttributeType(){} // RVA: 0xB54600
        public void get_AttDef(){} // RVA: 0xA1C8C0
        public void set_AttDef(){} // RVA: 0x9AA650
        public void get_NameAttribute(){} // RVA: 0x37B370
        public void set_NameAttribute(){} // RVA: 0x37B380
        public void Clone(){} // RVA: 0x69A1E70
        public void .ctor(){} // RVA: 0x69A2050
    }

    public class XmlSchemaAttributeGroup
    {
        public string name; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x60
        public System.Xml.XmlQualifiedName qname; // 0x68
        public System.Xml.Schema.XmlSchemaAttributeGroup redefined; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable attributeUses; // 0x78
        public System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard; // 0x80
        public int selfReferenceCount; // 0x88

        // ── Methods ──
        public void get_Name(){} // RVA: 0x37E0E0
        public void set_Name(){} // RVA: 0x4354D0
        public void get_Attributes(){} // RVA: 0x3A5500
        public void get_AnyAttribute(){} // RVA: 0x37B370
        public void set_AnyAttribute(){} // RVA: 0x37B380
        public void get_QualifiedName(){} // RVA: 0x358D50
        public void get_AttributeUses(){} // RVA: 0x69A21D0
        public void get_AttributeWildcard(){} // RVA: 0x462D00
        public void set_AttributeWildcard(){} // RVA: 0x464450
        public void get_RedefinedAttributeGroup(){} // RVA: 0x3A5590
        public void get_Redefined(){} // RVA: 0x3A5590
        public void set_Redefined(){} // RVA: 0x3A55A0
        public void get_SelfReferenceCount(){} // RVA: 0xBB90C0
        public void set_SelfReferenceCount(){} // RVA: 0xBB9E60
        public void get_NameAttribute(){} // RVA: 0x37E0E0
        public void set_NameAttribute(){} // RVA: 0x4354D0
        public void SetQualifiedName(){} // RVA: 0x358D60
        public void Clone(){} // RVA: 0x69A2280
        public void .ctor(){} // RVA: 0x69A2430
    }

    public class XmlSchemaAttributeGroupRef
    {
        public System.Xml.XmlQualifiedName refName; // 0x50

        // ── Methods ──
        public void get_RefName(){} // RVA: 0x37E0E0
        public void set_RefName(){} // RVA: 0x69A2570
        public void .ctor(){} // RVA: 0x69A2650
    }

    public class XmlSchemaChoice
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x78

        // ── Methods ──
        public void get_Items(){} // RVA: 0x4C7C50
        public void get_IsEmpty(){} // RVA: 0x69A2700
        public void SetItems(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x69A2710
    }

    public class XmlSchemaCollection
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
        public void .ctor(){} // RVA: 0x69A27F0
        public void get_Count(){} // RVA: 0x69A2A70
        public void get_NameTable(){} // RVA: 0x2E07C0
        public void set_XmlResolver(){} // RVA: 0x305200
        public void get_Item(){} // RVA: 0x69A2AA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x69A2B60
        public void GetEnumerator(){} // RVA: 0x69A2C30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x69A2D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x3C2850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x69A2A70
        public void GetSchemaInfo(){} // RVA: 0x69A2EA0
        public void GetSchemaNames(){} // RVA: 0x69A2F60
        public void Add(){} // RVA: 0x69A32E0 | overloaded x3
        public void get_EventHandler(){} // RVA: 0x4976A0
        public void set_EventHandler(){} // RVA: 0x49B830
    }

    public class XmlSchemaCollectionEnumerator
    {
        public System.Collections.IDictionaryEnumerator enumerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69A3420
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x69A34A0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x69A34F0
        public void MoveNext(){} // RVA: 0x69A3540
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x69A3590
        public void get_Current(){} // RVA: 0x69A35A0
        public void get_CurrentNode(){} // RVA: 0x69A3630
    }

    public class XmlSchemaCollectionNode
    {
        public string System.Collections.IEnumerator.Current; // 0x10
        public System.Xml.Schema.SchemaInfo Current; // 0x18
        public System.Xml.Schema.XmlSchema CurrentNode; // 0x20

        // ── Methods ──
        public void set_NamespaceURI(){} // RVA: 0x2DEE30
        public void get_SchemaInfo(){} // RVA: 0x2E07C0
        public void set_SchemaInfo(){} // RVA: 0x343E80
        public void get_Schema(){} // RVA: 0x30B0C0
        public void set_Schema(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaCompilationSettings
    {
        public bool IsMixed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD7E0
        public void get_EnableUpaCheck(){} // RVA: 0x3A75E0
    }

    public class XmlSchemaComplexContent
    {
        public System.Xml.Schema.XmlSchemaContent content; // 0x50
        public bool isMixed; // 0x58
        public bool hasMixedAttribute; // 0x59

        // ── Methods ──
        public void get_IsMixed(){} // RVA: 0x59FF30
        public void set_IsMixed(){} // RVA: 0x69A36C0
        public void get_Content(){} // RVA: 0x37E0E0
        public void set_Content(){} // RVA: 0x4354D0
        public void get_HasMixedAttribute(){} // RVA: 0x4FE4B90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaComplexContentExtension
    {
        public System.Xml.Schema.XmlSchemaParticle particle; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x60
        public System.Xml.XmlQualifiedName baseTypeName; // 0x68

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x358D50
        public void set_BaseTypeName(){} // RVA: 0x69A36D0
        public void get_Particle(){} // RVA: 0x37E0E0
        public void set_Particle(){} // RVA: 0x4354D0
        public void get_Attributes(){} // RVA: 0x3A5500
        public void get_AnyAttribute(){} // RVA: 0x37B370
        public void set_AnyAttribute(){} // RVA: 0x37B380
        public void SetAttributes(){} // RVA: 0x3A5510
        public void .ctor(){} // RVA: 0x69A37B0
    }

    public class XmlSchemaComplexContentRestriction
    {
        public System.Xml.Schema.XmlSchemaParticle particle; // 0x50
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x58
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x60
        public System.Xml.XmlQualifiedName baseTypeName; // 0x68

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x358D50
        public void set_BaseTypeName(){} // RVA: 0x69A38F0
        public void get_Particle(){} // RVA: 0x37E0E0
        public void set_Particle(){} // RVA: 0x4354D0
        public void get_Attributes(){} // RVA: 0x3A5500
        public void get_AnyAttribute(){} // RVA: 0x37B370
        public void set_AnyAttribute(){} // RVA: 0x37B380
        public void SetAttributes(){} // RVA: 0x3A5510
        public void .ctor(){} // RVA: 0x69A39D0
    }

    public class XmlSchemaComplexType
    {
        public 0x6587F058 block; // 0x98
        public System.Xml.Schema.XmlSchemaContentModel contentModel; // 0xA0
        public System.Xml.Schema.XmlSchemaParticle particle; // 0xA8
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0xB0
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0xB8
        public System.Xml.Schema.XmlSchemaParticle contentTypeParticle; // 0xC0
        public 0x6587F058 blockResolved; // 0xC8
        public System.Xml.Schema.XmlSchemaObjectTable localElements; // 0xD0
        public System.Xml.Schema.XmlSchemaObjectTable attributeUses; // 0xD8
        public System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard; // 0xE0
        public System.Xml.Schema.XmlSchemaComplexType anyTypeLax;
        public System.Xml.Schema.XmlSchemaComplexType anyTypeSkip; // 0x8
        public System.Xml.Schema.XmlSchemaComplexType untypedAnyType; // 0x10
        public byte pvFlags; // 0xE8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x69A3B10
        public void CreateAnyType(){} // RVA: 0x69A4020
        public void .ctor(){} // RVA: 0x69A4670
        public void get_AnyType(){} // RVA: 0x69A4730
        public void get_UntypedAnyType(){} // RVA: 0x69A4790
        public void get_AnyTypeContentValidator(){} // RVA: 0x69A47F0
        public void get_IsAbstract(){} // RVA: 0x69A4870
        public void set_IsAbstract(){} // RVA: 0x69A4880
        public void get_Block(){} // RVA: 0x1D76570
        public void set_Block(){} // RVA: 0x1D76000
        public void get_IsMixed(){} // RVA: 0x69A48B0
        public void set_IsMixed(){} // RVA: 0x69A48C0
        public void get_ContentModel(){} // RVA: 0xA085E0
        public void set_ContentModel(){} // RVA: 0x9AA5F0
        public void get_Particle(){} // RVA: 0xA1C130
        public void set_Particle(){} // RVA: 0xAE5030
        public void get_Attributes(){} // RVA: 0x69A48F0
        public void get_AnyAttribute(){} // RVA: 0x3480B0
        public void set_AnyAttribute(){} // RVA: 0x3480C0
        public void get_ContentType(){} // RVA: 0x6AFD40
        public void get_ContentTypeParticle(){} // RVA: 0x348120
        public void get_BlockResolved(){} // RVA: 0xA002A0
        public void get_AttributeUses(){} // RVA: 0x69A49B0
        public void get_AttributeWildcard(){} // RVA: 0x35E900
        public void get_LocalElements(){} // RVA: 0x69A4A70
        public void SetContentTypeParticle(){} // RVA: 0x348130
        public void SetBlockResolved(){} // RVA: 0x38EED60
        public void SetAttributeWildcard(){} // RVA: 0x35E910
        public void set_HasWildCard(){} // RVA: 0x69A4B30
        public void SetAttributes(){} // RVA: 0x348050
        public void ContainsIdAttribute(){} // RVA: 0x69A4B60
        public void Clone(){} // RVA: 0x69A4DE0 | overloaded x2
        public void ClearCompiledState(){} // RVA: 0x69A5800
        public void CloneAttributes(){} // RVA: 0x69A59C0
        public void CloneGroupBaseParticles(){} // RVA: 0x69A5CC0
        public void CloneParticle(){} // RVA: 0x69A5E20
        public void GetResolvedElementForm(){} // RVA: 0x69A6360
        public void HasParticleRef(){} // RVA: 0x69A6390
        public void HasAttributeQNameRef(){} // RVA: 0x69A6710
    }

    public class XmlSchemaContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaContentModel
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0xCD60
        public void set_Content(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaDatatype
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0xCD60
        public void get_TokenizedType(){} // RVA: 0xD840
        public void ParseValue(){} // RVA: 0x1EE30 | overloaded x2
        public void get_Variety(){} // RVA: 0x519240
        public void get_TypeCode(){} // RVA: 0x519240
        public void IsDerivedFrom(){} // RVA: 0x2DD320
        public void get_HasLexicalFacets(){} // RVA: 0xDBE0
        public void get_HasValueFacets(){} // RVA: 0xDBE0
        public void get_ValueConverter(){} // RVA: 0xCD60
        public void get_Restriction(){} // RVA: 0xCD60
        public void Compare(){} // RVA: 0x17680
        public void TryParseValue(){} // RVA: 0x1F0F0 | overloaded x2
        public void get_FacetsChecker(){} // RVA: 0xCD60
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xD840
        public void DeriveByRestriction(){} // RVA: 0x1EE30
        public void DeriveByList(){} // RVA: 0xCE10
        public void VerifySchemaValid(){} // RVA: 0x2DC60
        public void IsEqual(){} // RVA: 0x11120
        public void IsComparable(){} // RVA: 0xDE40
        public void get_TypeCodeString(){} // RVA: 0x69A68C0
        public void TypeCodeToString(){} // RVA: 0x69A6A40
        public void ConcatenatedToString(){} // RVA: 0x69A70C0
        public void FromXmlTokenizedType(){} // RVA: 0x69A76E0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x69A7790
        public void FromXdrName(){} // RVA: 0x69A7840
        public void DeriveByUnion(){} // RVA: 0x69A7A00
        public void XdrCanonizeUri(){} // RVA: 0x69A7A60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaDocumentation
    {
        public string source; // 0x38
        public string language; // 0x40
        public System.Xml.XmlNode[] markup; // 0x48

        // ── Methods ──
        public void set_Source(){} // RVA: 0x49B830
        public void set_Language(){} // RVA: 0x69A7DF0
        public void set_Markup(){} // RVA: 0x358740
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x69A7F40
    }

    public class XmlSchemaElement
    {
        public bool isAbstract; // 0x78
        public bool hasAbstractAttribute; // 0x79
        public bool isNillable; // 0x7A
        public bool hasNillableAttribute; // 0x7B
        public bool isLocalTypeDerivationChecked; // 0x7C
        public 0x6587F058 block; // 0x80
        public 0x6587F058 final; // 0x84
        public 0x6587F738 form; // 0x88
        public string defaultValue; // 0x90
        public string fixedValue; // 0x98
        public string name; // 0xA0
        public System.Xml.XmlQualifiedName refName; // 0xA8
        public System.Xml.XmlQualifiedName substitutionGroup; // 0xB0
        public System.Xml.XmlQualifiedName typeName; // 0xB8
        public System.Xml.Schema.XmlSchemaType type; // 0xC0
        public System.Xml.XmlQualifiedName qualifiedName; // 0xC8
        public System.Xml.Schema.XmlSchemaType elementType; // 0xD0
        public 0x6587F058 blockResolved; // 0xD8
        public 0x6587F058 finalResolved; // 0xDC
        public System.Xml.Schema.XmlSchemaObjectCollection constraints; // 0xE0
        public System.Xml.Schema.SchemaElementDecl elementDecl; // 0xE8

        // ── Methods ──
        public void get_IsAbstract(){} // RVA: 0x8A10E0
        public void set_IsAbstract(){} // RVA: 0x69A8060
        public void get_Block(){} // RVA: 0xFC4570
        public void set_Block(){} // RVA: 0xFC4560
        public void get_DefaultValue(){} // RVA: 0x796DE0
        public void set_DefaultValue(){} // RVA: 0xB54600
        public void get_Final(){} // RVA: 0x1C5A600
        public void set_Final(){} // RVA: 0x1C5A650
        public void get_FixedValue(){} // RVA: 0xA1C8C0
        public void set_FixedValue(){} // RVA: 0x9AA650
        public void get_Form(){} // RVA: 0xBB90C0
        public void set_Form(){} // RVA: 0xBB9E60
        public void get_Name(){} // RVA: 0xA085E0
        public void set_Name(){} // RVA: 0x9AA5F0
        public void get_IsNillable(){} // RVA: 0x8A3000
        public void set_IsNillable(){} // RVA: 0x69A8070
        public void get_HasNillableAttribute(){} // RVA: 0x8A7350
        public void get_HasAbstractAttribute(){} // RVA: 0x8A7360
        public void get_RefName(){} // RVA: 0xA1C130
        public void set_RefName(){} // RVA: 0x69A8080
        public void get_SubstitutionGroup(){} // RVA: 0x348040
        public void set_SubstitutionGroup(){} // RVA: 0x69A8170
        public void get_SchemaTypeName(){} // RVA: 0x3480B0
        public void set_SchemaTypeName(){} // RVA: 0x69A8260
        public void get_SchemaType(){} // RVA: 0x348120
        public void set_SchemaType(){} // RVA: 0x348130
        public void get_Constraints(){} // RVA: 0x69A8350
        public void get_QualifiedName(){} // RVA: 0x435460
        public void get_ElementSchemaType(){} // RVA: 0x3FA100
        public void get_BlockResolved(){} // RVA: 0x1C91A50
        public void get_FinalResolved(){} // RVA: 0x69A8410
        public void SetQualifiedName(){} // RVA: 0x435470
        public void SetElementType(){} // RVA: 0x3FA110
        public void SetBlockResolved(){} // RVA: 0x1C91A60
        public void SetFinalResolved(){} // RVA: 0x69A8420
        public void get_HasConstraints(){} // RVA: 0x69A8430
        public void get_IsLocalTypeDerivationChecked(){} // RVA: 0x8A89C0
        public void set_IsLocalTypeDerivationChecked(){} // RVA: 0x8A4A90
        public void get_ElementDecl(){} // RVA: 0x35E970
        public void set_ElementDecl(){} // RVA: 0x35E980
        public void get_NameAttribute(){} // RVA: 0xA085E0
        public void set_NameAttribute(){} // RVA: 0x9AA5F0
        public void get_NameString(){} // RVA: 0x69A8480
        public void Clone(){} // RVA: 0x69A84C0 | overloaded x2
        public void .ctor(){} // RVA: 0x69A8940
    }

    public class XmlSchemaEnumerationFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA5B0
    }

    public class XmlSchemaException
    {
        public string res; // 0x90
        public string[] args; // 0x98
        public string sourceUri; // 0xA0
        public int lineNumber; // 0xA8
        public int linePosition; // 0xAC
        public System.Xml.Schema.XmlSchemaObject sourceSchemaObject; // 0xB0
        public string message; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA110 | overloaded x14
        public void GetObjectData(){} // RVA: 0x69A9390
        public void CreateMessage(){} // RVA: 0x69AA2F0
        public void get_GetRes(){} // RVA: 0x796DE0
        public void get_Args(){} // RVA: 0xA1C8C0
        public void get_SourceUri(){} // RVA: 0xA085E0
        public void get_LineNumber(){} // RVA: 0xCC3CB0
        public void get_LinePosition(){} // RVA: 0x3C49C20
        public void get_SourceSchemaObject(){} // RVA: 0x348040
        public void SetSource(){} // RVA: 0x69AA3B0 | overloaded x2
        public void SetSchemaObject(){} // RVA: 0x348050
        public void get_Message(){} // RVA: 0x69AA4A0
    }

    public class XmlSchemaExternal
    {
        public string location; // 0x38
        public System.Uri baseUri; // 0x40
        public System.Xml.Schema.XmlSchema schema; // 0x48
        public string id; // 0x50
        public System.Xml.XmlAttribute[] moreAttributes; // 0x58
        public 0x6587DA58 compositor; // 0x60

        // ── Methods ──
        public void get_SchemaLocation(){} // RVA: 0x4976A0
        public void set_SchemaLocation(){} // RVA: 0x49B830
        public void get_Schema(){} // RVA: 0x358730
        public void set_Schema(){} // RVA: 0x358740
        public void get_Id(){} // RVA: 0x37E0E0
        public void set_Id(){} // RVA: 0x4354D0
        public void get_BaseUri(){} // RVA: 0x35A740
        public void set_BaseUri(){} // RVA: 0x305200
        public void get_IdAttribute(){} // RVA: 0x37E0E0
        public void set_IdAttribute(){} // RVA: 0x4354D0
        public void SetUnhandledAttributes(){} // RVA: 0x3A5510
        public void get_Compositor(){} // RVA: 0x59CEC0
        public void set_Compositor(){} // RVA: 0x59C530
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaFacet
    {
        public string value; // 0x50
        public bool isFixed; // 0x58
        public 0x6587F210 facetType; // 0x5C

        // ── Methods ──
        public void get_Value(){} // RVA: 0x37E0E0
        public void set_Value(){} // RVA: 0x4354D0
        public void get_IsFixed(){} // RVA: 0x59FF30
        public void set_IsFixed(){} // RVA: 0x69AA4C0
        public void get_FacetType(){} // RVA: 0x5A54D0
        public void set_FacetType(){} // RVA: 0x9EACA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaFractionDigitsFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA610
    }

    public class XmlSchemaGroup
    {
        public string name; // 0x50
        public System.Xml.Schema.XmlSchemaGroupBase particle; // 0x58
        public System.Xml.Schema.XmlSchemaParticle canonicalParticle; // 0x60
        public System.Xml.XmlQualifiedName qname; // 0x68
        public System.Xml.Schema.XmlSchemaGroup redefined; // 0x70
        public int selfReferenceCount; // 0x78

        // ── Methods ──
        public void get_Name(){} // RVA: 0x37E0E0
        public void set_Name(){} // RVA: 0x4354D0
        public void get_Particle(){} // RVA: 0x3A5500
        public void set_Particle(){} // RVA: 0x3A5510
        public void get_QualifiedName(){} // RVA: 0x358D50
        public void get_CanonicalParticle(){} // RVA: 0x37B370
        public void set_CanonicalParticle(){} // RVA: 0x37B380
        public void get_Redefined(){} // RVA: 0x3A5590
        public void set_Redefined(){} // RVA: 0x3A55A0
        public void get_SelfReferenceCount(){} // RVA: 0x1AE3800
        public void set_SelfReferenceCount(){} // RVA: 0x1AE6D80
        public void get_NameAttribute(){} // RVA: 0x37E0E0
        public void set_NameAttribute(){} // RVA: 0x4354D0
        public void SetQualifiedName(){} // RVA: 0x358D60
        public void Clone(){} // RVA: 0x69AA640 | overloaded x2
        public void .ctor(){} // RVA: 0x69AA890
    }

    public class XmlSchemaGroupBase
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0xCD60
        public void SetItems(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x69AA940
    }

    public class XmlSchemaGroupRef
    {
        public System.Xml.XmlQualifiedName refName; // 0x78
        public System.Xml.Schema.XmlSchemaGroupBase particle; // 0x80
        public System.Xml.Schema.XmlSchemaGroup refined; // 0x88

        // ── Methods ──
        public void get_RefName(){} // RVA: 0x4C7C50
        public void set_RefName(){} // RVA: 0x69AA990
        public void get_Particle(){} // RVA: 0x462D00
        public void SetParticle(){} // RVA: 0x464450
        public void get_Redefined(){} // RVA: 0x31C010
        public void set_Redefined(){} // RVA: 0x463060
        public void .ctor(){} // RVA: 0x69AAA70
    }

    public class XmlSchemaIdentityConstraint
    {
        public string name; // 0x50
        public System.Xml.Schema.XmlSchemaXPath selector; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection fields; // 0x60
        public System.Xml.XmlQualifiedName qualifiedName; // 0x68
        public System.Xml.Schema.CompiledIdentityConstraint compiledConstraint; // 0x70

        // ── Methods ──
        public void get_Name(){} // RVA: 0x37E0E0
        public void set_Name(){} // RVA: 0x4354D0
        public void get_Selector(){} // RVA: 0x3A5500
        public void set_Selector(){} // RVA: 0x3A5510
        public void get_Fields(){} // RVA: 0x37B370
        public void get_QualifiedName(){} // RVA: 0x358D50
        public void SetQualifiedName(){} // RVA: 0x358D60
        public void get_CompiledConstraint(){} // RVA: 0x3A5590
        public void set_CompiledConstraint(){} // RVA: 0x3A55A0
        public void get_NameAttribute(){} // RVA: 0x37E0E0
        public void set_NameAttribute(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x69AAB50
    }

    public class XmlSchemaImport
    {
        public string ns; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AAE30
        public void get_Namespace(){} // RVA: 0x358D50
        public void set_Namespace(){} // RVA: 0x358D60
        public void AddAnnotation(){} // RVA: 0x3A55A0
    }

    public class XmlSchemaInclude
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AAE40
        public void AddAnnotation(){} // RVA: 0x358D60
    }

    public class XmlSchemaInference
    {
        public System.Xml.XmlQualifiedName ST_boolean;
        public System.Xml.XmlQualifiedName ST_byte; // 0x8

        // ── Methods ──
        public void set_Occurrence(){} // RVA: 0x37E0D0
        public void get_Occurrence(){} // RVA: 0x37E0C0
        public void set_TypeInference(){} // RVA: 0x1D75D90
        public void .ctor(){} // RVA: 0x692F000
        public void InferSchema(){} // RVA: 0x692F240
        public void InferSchema1(){} // RVA: 0x692F2D0
        public void AddAttribute(){} // RVA: 0x692FD40
        public void CreateXmlSchema(){} // RVA: 0x69308A0
        public void AddElement(){} // RVA: 0x6930980
        public void InferElement(){} // RVA: 0x6931610
        public void CheckSimpleContentExtension(){} // RVA: 0x6932FE0
        public void GetEffectiveSchemaType(){} // RVA: 0x6933190
        public void FindMatchingElement(){} // RVA: 0x69333D0
        public void ProcessAttributes(){} // RVA: 0x6934960
        public void MoveAttributes(){} // RVA: 0x6935640 | overloaded x2
        public void FindAttribute(){} // RVA: 0x69359E0
        public void FindGlobalElement(){} // RVA: 0x6935C50
        public void FindElement(){} // RVA: 0x6935ED0
        public void FindAttributeRef(){} // RVA: 0x6936080
        public void FindElementRef(){} // RVA: 0x6936370
        public void MakeExistingAttributesOptional(){} // RVA: 0x6936580
        public void SwitchUseToOptional(){} // RVA: 0x6936650
        public void RefineSimpleType(){} // RVA: 0x69367D0
        public void InferSimpleType(){} // RVA: 0x6937600
        public void DateTime(){} // RVA: 0x6938790
        public void CreateNewElementforChoice(){} // RVA: 0x69388E0
        public void GetSchemaType(){} // RVA: 0x6939090
        public void SetMinMaxOccurs(){} // RVA: 0x6939C80
        public void .cctor(){} // RVA: 0x6939EB0
    }

    public class XmlSchemaInferenceException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x693B390 | overloaded x4
        public void GetObjectData(){} // RVA: 0x693B290
    }

    public class XmlSchemaInfo
    {
        public bool isDefault; // 0x10
        public bool isNil; // 0x11
        public System.Xml.Schema.XmlSchemaElement schemaElement; // 0x18
        public System.Xml.Schema.XmlSchemaAttribute schemaAttribute; // 0x20
        public System.Xml.Schema.XmlSchemaType schemaType; // 0x28
        public System.Xml.Schema.XmlSchemaSimpleType memberType; // 0x30
        public 0x65880708 validity; // 0x38
        public 0x6587EFA8 contentType; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AAE60 | overloaded x2
        public void get_Validity(){} // RVA: 0xFDC9F0
        public void set_Validity(){} // RVA: 0xFDD6E0
        public void get_IsDefault(){} // RVA: 0x3A75E0
        public void set_IsDefault(){} // RVA: 0x3A75F0
        public void get_IsNil(){} // RVA: 0x543460
        public void set_IsNil(){} // RVA: 0x543470
        public void get_MemberType(){} // RVA: 0x6374D0
        public void set_MemberType(){} // RVA: 0x30B890
        public void get_SchemaType(){} // RVA: 0x30B130
        public void set_SchemaType(){} // RVA: 0x69AAE90
        public void get_SchemaElement(){} // RVA: 0x2E07C0
        public void set_SchemaElement(){} // RVA: 0x69AAF20
        public void get_SchemaAttribute(){} // RVA: 0x30B0C0
        public void set_SchemaAttribute(){} // RVA: 0x69AAFE0
        public void get_ContentType(){} // RVA: 0x891AF0
        public void get_XmlType(){} // RVA: 0x69AB0A0
        public void get_HasDefaultValue(){} // RVA: 0x69AB0C0
        public void get_IsUnionType(){} // RVA: 0x69AB100
        public void Clear(){} // RVA: 0x69AB140
    }

    public class XmlSchemaKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AAC90
    }

    public class XmlSchemaKeyref
    {
        public System.Xml.XmlQualifiedName refer; // 0x78

        // ── Methods ──
        public void get_Refer(){} // RVA: 0x4C7C50
        public void set_Refer(){} // RVA: 0x69AACA0
        public void .ctor(){} // RVA: 0x69AAD80
    }

    public class XmlSchemaLengthFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA570
    }

    public class XmlSchemaMaxExclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA5E0
    }

    public class XmlSchemaMaxInclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA5F0
    }

    public class XmlSchemaMaxLengthFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA590
    }

    public class XmlSchemaMinExclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA5C0
    }

    public class XmlSchemaMinInclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA5D0
    }

    public class XmlSchemaMinLengthFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA580
    }

    public class XmlSchemaNotation
    {
        public string name; // 0x50
        public string publicId; // 0x58
        public string systemId; // 0x60
        public System.Xml.XmlQualifiedName qname; // 0x68

        // ── Methods ──
        public void get_Name(){} // RVA: 0x37E0E0
        public void set_Name(){} // RVA: 0x4354D0
        public void get_Public(){} // RVA: 0x3A5500
        public void set_Public(){} // RVA: 0x3A5510
        public void get_System(){} // RVA: 0x37B370
        public void set_System(){} // RVA: 0x37B380
        public void get_QualifiedName(){} // RVA: 0x358D50
        public void set_QualifiedName(){} // RVA: 0x358D60
        public void get_NameAttribute(){} // RVA: 0x37E0E0
        public void set_NameAttribute(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x69AB2B0
    }

    public class XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaObject
    {
        public int lineNum; // 0x10
        public int linePos; // 0x14
        public string sourceUri; // 0x18
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces; // 0x20
        public System.Xml.Schema.XmlSchemaObject parent; // 0x28
        public bool isProcessing; // 0x30

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x32A5C0
        public void set_LineNumber(){} // RVA: 0x2E00C0
        public void get_LinePosition(){} // RVA: 0x8ABED0
        public void set_LinePosition(){} // RVA: 0x8AC660
        public void get_SourceUri(){} // RVA: 0x2E07C0
        public void set_SourceUri(){} // RVA: 0x343E80
        public void get_Parent(){} // RVA: 0x30B130
        public void set_Parent(){} // RVA: 0x2DEE90
        public void get_Namespaces(){} // RVA: 0x69AB360
        public void set_Namespaces(){} // RVA: 0x30B0D0
        public void OnAdd(){} // RVA: 0x2DD310
        public void OnRemove(){} // RVA: 0x2DD310
        public void OnClear(){} // RVA: 0x2DD310
        public void get_IdAttribute(){} // RVA: 0x519240
        public void set_IdAttribute(){} // RVA: 0x2DD310
        public void SetUnhandledAttributes(){} // RVA: 0x2DD310
        public void AddAnnotation(){} // RVA: 0x2DD310
        public void get_NameAttribute(){} // RVA: 0x519240
        public void set_NameAttribute(){} // RVA: 0x2DD310
        public void get_IsProcessing(){} // RVA: 0x303450
        public void set_IsProcessing(){} // RVA: 0x303460
        public void Clone(){} // RVA: 0x69AB400
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaObjectCollection
    {
        public System.Xml.Schema.XmlSchemaObject parent; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BCCCF0
        public void get_Item(){} // RVA: 0x69AB480
        public void set_Item(){} // RVA: 0x69AB530
        public void GetEnumerator(){} // RVA: 0x69AB5A0
        public void Add(){} // RVA: 0x69AB910 | overloaded x2
        public void Insert(){} // RVA: 0x69AB6B0
        public void Remove(){} // RVA: 0x69AB720
        public void OnInsert(){} // RVA: 0x69AB780
        public void OnSet(){} // RVA: 0x69AB7B0
        public void OnClear(){} // RVA: 0x69AB820
        public void OnRemove(){} // RVA: 0x69AB850
        public void Clone(){} // RVA: 0x69AB880
    }

    public class XmlSchemaObjectEnumerator : .ctor
    {
        public System.Collections.IEnumerator enumerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void MoveNext(){} // RVA: 0x69AB940
        public void get_Current(){} // RVA: 0x69AB990
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x69ABA30
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x69ABA80
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x69ABAD0
    }

    public class XmlSchemaObjectTable
    {
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
        public System.Collections.Generic.List`1<XmlSchemaObjectEntry> entries; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69ABB20
        public void Add(){} // RVA: 0x69ABC80
        public void Insert(){} // RVA: 0x69ABE00
        public void Replace(){} // RVA: 0x69ABF60
        public void Clear(){} // RVA: 0x69AC0A0
        public void Remove(){} // RVA: 0x69AC130
        public void FindIndexByValue(){} // RVA: 0x69AC200
        public void get_Count(){} // RVA: 0x69AC2B0
        public void Contains(){} // RVA: 0x69AC300
        public void get_Item(){} // RVA: 0x69AC380
        public void get_Values(){} // RVA: 0x69AC400
        public void GetEnumerator(){} // RVA: 0x69AC4D0
    }

    public class XmlSchemaParticle
    {
        public System.Decimal minOccurs; // 0x50
        public System.Decimal maxOccurs; // 0x60
        public 0x6587FEC8 flags; // 0x70
        public System.Xml.Schema.XmlSchemaParticle Empty;

        // ── Methods ──
        public void get_MinOccursString(){} // RVA: 0x69AD2B0
        public void set_MinOccursString(){} // RVA: 0x69AD3F0
        public void get_MaxOccursString(){} // RVA: 0x69AD600
        public void set_MaxOccursString(){} // RVA: 0x69AD800
        public void get_MinOccurs(){} // RVA: 0x41E0130
        public void set_MinOccurs(){} // RVA: 0x69ADB10
        public void get_MaxOccurs(){} // RVA: 0x36ABF00
        public void set_MaxOccurs(){} // RVA: 0x69ADD90
        public void get_IsEmpty(){} // RVA: 0x69AE0A0
        public void get_NameString(){} // RVA: 0x69AE160
        public void GetQualifiedName(){} // RVA: 0x69AE1A0
        public void .ctor(){} // RVA: 0x69AE380
        public void .cctor(){} // RVA: 0x69AE400
    }

    public class XmlSchemaPatternFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA5A0
    }

    public class XmlSchemaRedefine
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x68
        public System.Xml.Schema.XmlSchemaObjectTable attributeGroups; // 0x70
        public System.Xml.Schema.XmlSchemaObjectTable types; // 0x78
        public System.Xml.Schema.XmlSchemaObjectTable groups; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AE550
        public void get_Items(){} // RVA: 0x358D50
        public void get_AttributeGroups(){} // RVA: 0x3A5590
        public void get_SchemaTypes(){} // RVA: 0x4C7C50
        public void get_Groups(){} // RVA: 0x462D00
        public void AddAnnotation(){} // RVA: 0x69AE770
    }

    public class XmlSchemaSequence
    {
        public System.Xml.Schema.XmlSchemaObjectCollection items; // 0x78

        // ── Methods ──
        public void get_Items(){} // RVA: 0x4C7C50
        public void get_IsEmpty(){} // RVA: 0x69A0CA0
        public void SetItems(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x69AE7D0
    }

    public class XmlSchemaSet
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
        public void get_InternalSyncObject(){} // RVA: 0x69AE8B0
        public void .ctor(){} // RVA: 0x69AE9C0 | overloaded x2
        public void add_ValidationEventHandler(){} // RVA: 0x69AEFB0
        public void remove_ValidationEventHandler(){} // RVA: 0x69AF1D0
        public void get_IsCompiled(){} // RVA: 0x4A6500
        public void set_XmlResolver(){} // RVA: 0x69AF330
        public void get_CompilationSettings(){} // RVA: 0x4C7C50
        public void set_CompilationSettings(){} // RVA: 0x4C34F0
        public void get_Count(){} // RVA: 0x69AF350
        public void get_GlobalElements(){} // RVA: 0x69AF380
        public void get_GlobalAttributes(){} // RVA: 0x69AF440
        public void get_GlobalTypes(){} // RVA: 0x69AF500
        public void get_SubstitutionGroups(){} // RVA: 0x69AF5C0
        public void get_SchemaLocations(){} // RVA: 0x35A740
        public void get_TypeExtensions(){} // RVA: 0x69AF680
        public void Add(){} // RVA: 0x69B23D0 | overloaded x4
        public void RemoveRecursive(){} // RVA: 0x69B02C0
        public void Contains(){} // RVA: 0x69B0C50
        public void Compile(){} // RVA: 0x69B0CD0
        public void Reprocess(){} // RVA: 0x69B1700
        public void CopyTo(){} // RVA: 0x69B2040
        public void Schemas(){} // RVA: 0x69B2170 | overloaded x2
        public void FindSchemaByNSAndUrl(){} // RVA: 0x69B2930
        public void AddSchemaToSet(){} // RVA: 0x69B2C80
        public void ProcessNewSubstitutionGroups(){} // RVA: 0x69B3170
        public void ResolveSubstitutionGroup(){} // RVA: 0x69B3510
        public void Remove(){} // RVA: 0x69B3940
        public void ClearTables(){} // RVA: 0x69B3D30
        public void PreprocessSchema(){} // RVA: 0x69B3E70
        public void ParseSchema(){} // RVA: 0x69B4120
        public void CopyFromCompiledSet(){} // RVA: 0x69B42D0
        public void get_CompiledInfo(){} // RVA: 0x37B370
        public void get_ReaderSettings(){} // RVA: 0x358D50
        public void GetResolver(){} // RVA: 0x69B56A0
        public void GetEventHandler(){} // RVA: 0x6374D0
        public void GetSchemaNames(){} // RVA: 0x69B56C0
        public void IsSchemaLoaded(){} // RVA: 0x69B57C0
        public void GetSchemaByUri(){} // RVA: 0x69B64F0
        public void GetTargetNamespace(){} // RVA: 0x69B6740
        public void get_SortedSchemas(){} // RVA: 0x30B0C0
        public void RemoveSchemaFromCaches(){} // RVA: 0x69B67A0
        public void RemoveSchemaFromGlobalTables(){} // RVA: 0x69B6C70
        public void AddToTable(){} // RVA: 0x69B7680
        public void VerifyTables(){} // RVA: 0x69B79F0
        public void InternalValidationCallback(){} // RVA: 0x69B7C30
        public void SendValidationEvent(){} // RVA: 0x69B7C80
    }

    public class XmlSchemaSimpleContent
    {
        public System.Xml.Schema.XmlSchemaContent content; // 0x50

        // ── Methods ──
        public void get_Content(){} // RVA: 0x37E0E0
        public void set_Content(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaSimpleContentExtension
    {
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x50
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x58
        public System.Xml.XmlQualifiedName baseTypeName; // 0x60

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x37B370
        public void set_BaseTypeName(){} // RVA: 0x69B7D50
        public void get_Attributes(){} // RVA: 0x37E0E0
        public void get_AnyAttribute(){} // RVA: 0x3A5500
        public void set_AnyAttribute(){} // RVA: 0x3A5510
        public void SetAttributes(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x69B7E30
    }

    public class XmlSchemaSimpleContentRestriction
    {
        public System.Xml.XmlQualifiedName baseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType baseType; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection facets; // 0x60
        public System.Xml.Schema.XmlSchemaObjectCollection attributes; // 0x68
        public System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute; // 0x70

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x37E0E0
        public void set_BaseTypeName(){} // RVA: 0x69B7F70
        public void get_BaseType(){} // RVA: 0x3A5500
        public void set_BaseType(){} // RVA: 0x3A5510
        public void get_Facets(){} // RVA: 0x37B370
        public void get_Attributes(){} // RVA: 0x358D50
        public void get_AnyAttribute(){} // RVA: 0x3A5590
        public void set_AnyAttribute(){} // RVA: 0x3A55A0
        public void SetAttributes(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x69B8050
    }

    public class XmlSchemaSimpleType
    {
        public System.Xml.Schema.XmlSchemaSimpleTypeContent content; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B8210
        public void get_Content(){} // RVA: 0xA1C8C0
        public void set_Content(){} // RVA: 0x9AA650
        public void Clone(){} // RVA: 0x69B8220
    }

    public class XmlSchemaSimpleTypeContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlSchemaSimpleTypeList
    {
        public System.Xml.XmlQualifiedName itemTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType itemType; // 0x58
        public System.Xml.Schema.XmlSchemaSimpleType baseItemType; // 0x60

        // ── Methods ──
        public void get_ItemTypeName(){} // RVA: 0x37E0E0
        public void set_ItemTypeName(){} // RVA: 0x69B8390
        public void get_ItemType(){} // RVA: 0x3A5500
        public void set_ItemType(){} // RVA: 0x3A5510
        public void get_BaseItemType(){} // RVA: 0x37B370
        public void set_BaseItemType(){} // RVA: 0x37B380
        public void Clone(){} // RVA: 0x69B8470
        public void .ctor(){} // RVA: 0x69B85D0
    }

    public class XmlSchemaSimpleTypeRestriction
    {
        public System.Xml.XmlQualifiedName baseTypeName; // 0x50
        public System.Xml.Schema.XmlSchemaSimpleType baseType; // 0x58
        public System.Xml.Schema.XmlSchemaObjectCollection facets; // 0x60

        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x37E0E0
        public void set_BaseTypeName(){} // RVA: 0x69B8680
        public void get_BaseType(){} // RVA: 0x3A5500
        public void set_BaseType(){} // RVA: 0x3A5510
        public void get_Facets(){} // RVA: 0x37B370
        public void Clone(){} // RVA: 0x69B8760
        public void .ctor(){} // RVA: 0x69B88C0
    }

    public class XmlSchemaSimpleTypeUnion
    {
        public System.Xml.Schema.XmlSchemaObjectCollection baseTypes; // 0x50
        public System.Xml.XmlQualifiedName[] memberTypes; // 0x58
        public System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes; // 0x60

        // ── Methods ──
        public void get_BaseTypes(){} // RVA: 0x37E0E0
        public void get_MemberTypes(){} // RVA: 0x3A5500
        public void set_MemberTypes(){} // RVA: 0x3A5510
        public void get_BaseMemberTypes(){} // RVA: 0x37B370
        public void SetBaseMemberTypes(){} // RVA: 0x37B380
        public void Clone(){} // RVA: 0x69B8A10
        public void .ctor(){} // RVA: 0x69B8CF0
    }

    public class XmlSchemaSubstitutionGroup
    {
        public System.Collections.ArrayList membersList; // 0x38
        public System.Xml.XmlQualifiedName examplar; // 0x40

        // ── Methods ──
        public void get_Members(){} // RVA: 0x4976A0
        public void get_Examplar(){} // RVA: 0x35A740
        public void set_Examplar(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x69B8D90
    }

    public class XmlSchemaSubstitutionGroupV1Compat
    {
        public System.Xml.Schema.XmlSchemaChoice choice; // 0x48

        // ── Methods ──
        public void get_Choice(){} // RVA: 0x358730
        public void .ctor(){} // RVA: 0x69B8ED0
    }

    public class XmlSchemaTotalDigitsFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA600
    }

    public class XmlSchemaType
    {
        public string name; // 0x50
        public 0x6587F058 final; // 0x58
        public 0x6587F058 derivedBy; // 0x5C
        public System.Xml.Schema.XmlSchemaType baseSchemaType; // 0x60
        public System.Xml.Schema.XmlSchemaDatatype datatype; // 0x68
        public 0x6587F058 finalResolved; // 0x70
        public System.Xml.Schema.SchemaElementDecl elementDecl; // 0x78
        public System.Xml.XmlQualifiedName qname; // 0x80
        public System.Xml.Schema.XmlSchemaType redefined; // 0x88
        public 0x6587EFA8 contentType; // 0x90

        // ── Methods ──
        public void GetBuiltInSimpleType(){} // RVA: 0x69B9050 | overloaded x2
        public void GetBuiltInComplexType(){} // RVA: 0x69B90A0
        public void get_Name(){} // RVA: 0x37E0E0
        public void set_Name(){} // RVA: 0x4354D0
        public void get_Final(){} // RVA: 0x9EAB90
        public void set_Final(){} // RVA: 0x9EAAE0
        public void get_QualifiedName(){} // RVA: 0x69B9220
        public void get_FinalResolved(){} // RVA: 0x10E5CF0
        public void get_BaseXmlSchemaType(){} // RVA: 0x37B370
        public void get_DerivedBy(){} // RVA: 0x5A54D0
        public void get_Datatype(){} // RVA: 0x358D50
        public void get_IsMixed(){} // RVA: 0x2DD320
        public void set_IsMixed(){} // RVA: 0x2DD310
        public void get_TypeCode(){} // RVA: 0x69B9230
        public void get_ValueConverter(){} // RVA: 0x69B92F0
        public void get_SchemaContentType(){} // RVA: 0x6AFD40
        public void SetQualifiedName(){} // RVA: 0x69B9370
        public void SetFinalResolved(){} // RVA: 0x475080
        public void SetBaseSchemaType(){} // RVA: 0x37B380
        public void SetDerivedBy(){} // RVA: 0x9EACA0
        public void SetDatatype(){} // RVA: 0x358D60
        public void get_ElementDecl(){} // RVA: 0x69B93D0
        public void set_ElementDecl(){} // RVA: 0x69B93E0
        public void get_Redefined(){} // RVA: 0x31C010
        public void set_Redefined(){} // RVA: 0x463060
        public void SetContentType(){} // RVA: 0xF02F80
        public void IsDerivedFrom(){} // RVA: 0x69B9440
        public void IsDerivedFromDatatype(){} // RVA: 0x69B95D0
        public void get_NameAttribute(){} // RVA: 0x37E0E0
        public void set_NameAttribute(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x69B96B0
    }

    public class XmlSchemaUnique
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AAC90
    }

    public class XmlSchemaValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B9840 | overloaded x5
        public void GetObjectData(){} // RVA: 0x693B290
    }

    public class XmlSchemaValidator
    {
        public System.Xml.Schema.XmlSchemaSet schemaSet; // 0x10
        public 0x658805A8 validationFlags; // 0x18
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
        public 0x65880600 currentState; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B9950
        public void Init(){} // RVA: 0x69B9CA0
        public void Reset(){} // RVA: 0x69BA5C0
        public void set_XmlResolver(){} // RVA: 0x35E8A0
        public void set_LineInfoProvider(){} // RVA: 0x69BA6E0
        public void set_SourceUri(){} // RVA: 0x69BA7B0
        public void set_ValidationEventSender(){} // RVA: 0x3480C0
        public void add_ValidationEventHandler(){} // RVA: 0x69BA8A0
        public void remove_ValidationEventHandler(){} // RVA: 0x69BA9A0
        public void AddSchema(){} // RVA: 0x69BAAA0
        public void Initialize(){} // RVA: 0x69BB030 | overloaded x2
        public void ValidateElement(){} // RVA: 0x69BB350
        public void ValidateAttribute(){} // RVA: 0x69BB9A0 | overloaded x2
        public void ValidateEndOfAttributes(){} // RVA: 0x69BC420
        public void ValidateText(){} // RVA: 0x69BC570 | overloaded x2
        public void ValidateWhitespace(){} // RVA: 0x69BCA50 | overloaded x2
        public void ValidateEndElement(){} // RVA: 0x69BCCE0
        public void SkipToEndElement(){} // RVA: 0x69BCCF0
        public void EndValidation(){} // RVA: 0x69BCF70
        public void GetUnspecifiedDefaultAttributes(){} // RVA: 0x69BD1F0
        public void get_SchemaSet(){} // RVA: 0x2F8380
        public void get_ValidationFlags(){} // RVA: 0x5BED50
        public void get_CurrentContentType(){} // RVA: 0x69BD930
        public void SetDtdSchemaInfo(){} // RVA: 0x69BD970
        public void get_StrictlyAssessed(){} // RVA: 0x69BD9D0
        public void get_HasSchema(){} // RVA: 0x69BDA10
        public void GetConcatenatedValue(){} // RVA: 0x69BDA60
        public void InternalValidateEndElement(){} // RVA: 0x69BDA90
        public void ProcessSchemaLocations(){} // RVA: 0x69BE130
        public void ValidateElementContext(){} // RVA: 0x69BE480
        public void GetSubstitutionGroupHead(){} // RVA: 0x69BEA70
        public void ValidateAtomicValue(){} // RVA: 0x69BF080 | overloaded x2
        public void GetTypeName(){} // RVA: 0x69BF510
        public void SaveTextValue(){} // RVA: 0x69BF580
        public void Push(){} // RVA: 0x69BF5D0
        public void Pop(){} // RVA: 0x69BF9E0
        public void FastGetElementDecl(){} // RVA: 0x69BFBE0
        public void CheckXsiTypeAndNil(){} // RVA: 0x69BFF40
        public void ThrowDeclNotFoundWarningOrError(){} // RVA: 0x69C06C0
        public void CheckElementProperties(){} // RVA: 0x69C0920
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x69C0A20
        public void CheckIsXmlAttribute(){} // RVA: 0x69C0A80
        public void AddXmlNamespaceSchema(){} // RVA: 0x69C0C10
        public void CheckMixedValueConstraint(){} // RVA: 0x69C0D00
        public void LoadSchema(){} // RVA: 0x69C0E30
        public void RecompileSchemaSet(){} // RVA: 0x69C1280
        public void ProcessTokenizedType(){} // RVA: 0x69C1340
        public void CheckAttributeValue(){} // RVA: 0x69C1620
        public void CheckElementValue(){} // RVA: 0x69C18F0
        public void CheckTokenizedTypes(){} // RVA: 0x69C1C30
        public void FindId(){} // RVA: 0x69C1DC0
        public void CheckForwardRefs(){} // RVA: 0x69C1DF0
        public void get_HasIdentityConstraints(){} // RVA: 0x69C1F80
        public void get_ProcessIdentityConstraints(){} // RVA: 0x5A5FC10
        public void get_ReportValidationWarnings(){} // RVA: 0x5A5F650
        public void get_ProcessSchemaHints(){} // RVA: 0x69C1FA0
        public void CheckStateTransition(){} // RVA: 0x69C1FC0
        public void ClearPSVI(){} // RVA: 0x69C2260
        public void CheckRequiredAttributes(){} // RVA: 0x69C2300
        public void GetSchemaElement(){} // RVA: 0x69C25D0
        public void GetDefaultAttributePrefix(){} // RVA: 0x69C2720
        public void AddIdentityConstraints(){} // RVA: 0x69C29D0
        public void ElementIdentityConstraints(){} // RVA: 0x69C2FC0
        public void AttributeIdentityConstraints(){} // RVA: 0x69C3370
        public void EndElementIdentityConstraints(){} // RVA: 0x69C36C0
        public void ElementValidationError(){} // RVA: 0x69C4500
        public void CompleteValidationError(){} // RVA: 0x69C4D10
        public void PrintExpectedElements(){} // RVA: 0x69C5260
        public void PrintNames(){} // RVA: 0x69C56E0
        public void PrintNamesWithNS(){} // RVA: 0x69C5880
        public void EnumerateAny(){} // RVA: 0x69C5EC0
        public void QNameString(){} // RVA: 0x69C6150
        public void BuildElementName(){} // RVA: 0x69C6230 | overloaded x2
        public void ProcessEntity(){} // RVA: 0x69C63A0
        public void SendValidationEvent(){} // RVA: 0x69C6E60 | overloaded x11
        public void .cctor(){} // RVA: 0x69C6F20
    }

    public class XmlSchemaWhiteSpaceFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AA620
    }

    public class XmlSchemaXPath
    {
        public string xpath; // 0x50

        // ── Methods ──
        public void get_XPath(){} // RVA: 0x37E0E0
        public void set_XPath(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlStringConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69DBC00
        public void Create(){} // RVA: 0x69DBC60
        public void ToString(){} // RVA: 0x69DBCF0
        public void ChangeType(){} // RVA: 0x69DC1E0 | overloaded x2
    }

    public class XmlUnionConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69E9FD0
        public void Create(){} // RVA: 0x69EA370
        public void ChangeType(){} // RVA: 0x69EA3D0
    }

    public class XmlUntypedConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69DC760 | overloaded x2
        public void ToBoolean(){} // RVA: 0x69DC9F0 | overloaded x2
        public void ToDateTime(){} // RVA: 0x69DCC90 | overloaded x2
        public void ToDateTimeOffset(){} // RVA: 0x69DCFA0 | overloaded x2
        public void ToDecimal(){} // RVA: 0x69DD2C0 | overloaded x2
        public void ToDouble(){} // RVA: 0x69DD5D0 | overloaded x2
        public void ToInt32(){} // RVA: 0x69DD880 | overloaded x2
        public void ToInt64(){} // RVA: 0x69DDB40 | overloaded x2
        public void ToSingle(){} // RVA: 0x69DDDF0 | overloaded x2
        public void ToString(){} // RVA: 0x69DE420 | overloaded x9
        public void ChangeType(){} // RVA: 0x69E0E40 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x69E26D0
        public void ChangeTypeWildcardSource(){} // RVA: 0x69E2830
        public void ChangeListType(){} // RVA: 0x69E29B0
        public void SupportsType(){} // RVA: 0x69E2D00
        public void .cctor(){} // RVA: 0x69E3280
    }

    public class XmlValueConverter
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0xDE40 | overloaded x6
        public void ToInt32(){} // RVA: 0x12590 | overloaded x6
        public void ToInt64(){} // RVA: 0xCE10 | overloaded x6
        public void ToDecimal(){} // overloaded x2
        public void ToDouble(){} // RVA: 0x12DE0 | overloaded x6
        public void ToSingle(){} // RVA: 0x21FA0 | overloaded x3
        public void ToDateTime(){} // overloaded x7
        public void ToDateTimeOffset(){} // overloaded x3
        public void ToString(){} // RVA: 0x1E6A0 | overloaded x10
        public void ChangeType(){} // RVA: 0x1EE30 | overloaded x9
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XmlValueGetter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B072F0
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class XsdBuilder
    {
        public 0x65880C88[] SchemaElement;
        public 0x65880C88[] SchemaSubelements; // 0x8
        public 0x65880C88[] AttributeSubelements; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69EA870
        public void ProcessElement(){} // RVA: 0x69EAED0
        public void ProcessAttribute(){} // RVA: 0x69EB1B0
        public void IsContentParsed(){} // RVA: 0x69EB7C0
        public void ProcessMarkup(){} // RVA: 0xD870D0
        public void ProcessCData(){} // RVA: 0x69EB7E0
        public void StartChildren(){} // RVA: 0x69EB830
        public void EndChildren(){} // RVA: 0x69EBA70
        public void Push(){} // RVA: 0x69EBAC0
        public void Pop(){} // RVA: 0x69EBDF0
        public void get_CurrentElement(){} // RVA: 0x5C3B480
        public void get_ParentElement(){} // RVA: 0x69EBF50
        public void get_ParentContainer(){} // RVA: 0x69EBFE0
        public void GetContainer(){} // RVA: 0x69EC080
        public void SetContainer(){} // RVA: 0x69EC2D0
        public void BuildAnnotated_Id(){} // RVA: 0x69EDA50
        public void BuildSchema_AttributeFormDefault(){} // RVA: 0x69EDA80
        public void BuildSchema_ElementFormDefault(){} // RVA: 0x69EDB40
        public void BuildSchema_TargetNamespace(){} // RVA: 0x69EDC00
        public void BuildSchema_Version(){} // RVA: 0x69EDC70
        public void BuildSchema_FinalDefault(){} // RVA: 0x69EDCE0
        public void BuildSchema_BlockDefault(){} // RVA: 0x69EDD60
        public void InitSchema(){} // RVA: 0x69EDDE0
        public void InitInclude(){} // RVA: 0x69EDE50
        public void BuildInclude_SchemaLocation(){} // RVA: 0x69EDFE0
        public void InitImport(){} // RVA: 0x69EE050
        public void BuildImport_Namespace(){} // RVA: 0x69EE1E0
        public void BuildImport_SchemaLocation(){} // RVA: 0x69EE250
        public void InitRedefine(){} // RVA: 0x69EE2C0
        public void BuildRedefine_SchemaLocation(){} // RVA: 0x69EE450
        public void EndRedefine(){} // RVA: 0x69EE4C0
        public void InitAttribute(){} // RVA: 0x69EE4E0
        public void BuildAttribute_Default(){} // RVA: 0x69EE680
        public void BuildAttribute_Fixed(){} // RVA: 0x69EE6F0
        public void BuildAttribute_Form(){} // RVA: 0x69EE760
        public void BuildAttribute_Use(){} // RVA: 0x69EE820
        public void BuildAttribute_Ref(){} // RVA: 0x69EE8E0
        public void BuildAttribute_Name(){} // RVA: 0x69EEA20
        public void BuildAttribute_Type(){} // RVA: 0x69EEA90
        public void InitElement(){} // RVA: 0x69EEBD0
        public void BuildElement_Abstract(){} // RVA: 0x69EEDD0
        public void BuildElement_Block(){} // RVA: 0x69EEE50
        public void BuildElement_Default(){} // RVA: 0x69EEED0
        public void BuildElement_Form(){} // RVA: 0x69EEF40
        public void BuildElement_SubstitutionGroup(){} // RVA: 0x69EF000
        public void BuildElement_Final(){} // RVA: 0x69EF140
        public void BuildElement_Fixed(){} // RVA: 0x69EF1C0
        public void BuildElement_MaxOccurs(){} // RVA: 0x69EF230
        public void BuildElement_MinOccurs(){} // RVA: 0x69EF260
        public void BuildElement_Name(){} // RVA: 0x69EF290
        public void BuildElement_Nillable(){} // RVA: 0x69EF300
        public void BuildElement_Ref(){} // RVA: 0x69EF380
        public void BuildElement_Type(){} // RVA: 0x69EF4C0
        public void InitSimpleType(){} // RVA: 0x69EF600
        public void BuildSimpleType_Name(){} // RVA: 0x69EFB90
        public void BuildSimpleType_Final(){} // RVA: 0x69EFC00
        public void InitSimpleTypeUnion(){} // RVA: 0x69EFC80
        public void BuildSimpleTypeUnion_MemberTypes(){} // RVA: 0x69EFEE0
        public void InitSimpleTypeList(){} // RVA: 0x69F00E0
        public void BuildSimpleTypeList_ItemType(){} // RVA: 0x69F02A0
        public void InitSimpleTypeRestriction(){} // RVA: 0x69F03E0
        public void BuildSimpleTypeRestriction_Base(){} // RVA: 0x69F05A0
        public void InitComplexType(){} // RVA: 0x69F06E0
        public void BuildComplexType_Abstract(){} // RVA: 0x69F0970
        public void BuildComplexType_Block(){} // RVA: 0x69F0A00
        public void BuildComplexType_Final(){} // RVA: 0x69F0A80
        public void BuildComplexType_Mixed(){} // RVA: 0x69F0B00
        public void BuildComplexType_Name(){} // RVA: 0x69F0B90
        public void InitComplexContent(){} // RVA: 0x69F0C00
        public void BuildComplexContent_Mixed(){} // RVA: 0x69F0E20
        public void InitComplexContentExtension(){} // RVA: 0x69F0EA0
        public void BuildComplexContentExtension_Base(){} // RVA: 0x69F1160
        public void InitComplexContentRestriction(){} // RVA: 0x69F12A0
        public void BuildComplexContentRestriction_Base(){} // RVA: 0x69F1500
        public void InitSimpleContent(){} // RVA: 0x69F1640
        public void InitSimpleContentExtension(){} // RVA: 0x69F1860
        public void BuildSimpleContentExtension_Base(){} // RVA: 0x69F1A00
        public void InitSimpleContentRestriction(){} // RVA: 0x69F1B40
        public void BuildSimpleContentRestriction_Base(){} // RVA: 0x69F1E80
        public void InitAttributeGroup(){} // RVA: 0x69F1FC0
        public void BuildAttributeGroup_Name(){} // RVA: 0x69F2160
        public void InitAttributeGroupRef(){} // RVA: 0x69F21D0
        public void BuildAttributeGroupRef_Ref(){} // RVA: 0x69F2380
        public void InitAnyAttribute(){} // RVA: 0x69F24C0
        public void BuildAnyAttribute_Namespace(){} // RVA: 0x69F2A50
        public void BuildAnyAttribute_ProcessContents(){} // RVA: 0x69F2AC0
        public void InitGroup(){} // RVA: 0x69F2B80
        public void BuildGroup_Name(){} // RVA: 0x69F2DA0
        public void InitGroupRef(){} // RVA: 0x69F2E10
        public void BuildParticle_MaxOccurs(){} // RVA: 0x69F3050
        public void BuildParticle_MinOccurs(){} // RVA: 0x69F3080
        public void BuildGroupRef_Ref(){} // RVA: 0x69F30B0
        public void InitAll(){} // RVA: 0x69F31F0
        public void InitChoice(){} // RVA: 0x69F3360
        public void InitSequence(){} // RVA: 0x69F34D0
        public void InitAny(){} // RVA: 0x69F3640
        public void BuildAny_Namespace(){} // RVA: 0x69F37F0
        public void BuildAny_ProcessContents(){} // RVA: 0x69F3860
        public void InitNotation(){} // RVA: 0x69F3920
        public void BuildNotation_Name(){} // RVA: 0x69F3B10
        public void BuildNotation_Public(){} // RVA: 0x69F3B80
        public void BuildNotation_System(){} // RVA: 0x69F3BF0
        public void InitFacet(){} // RVA: 0x69F3C60
        public void BuildFacet_Fixed(){} // RVA: 0x69F4050
        public void BuildFacet_Value(){} // RVA: 0x69F40E0
        public void InitIdentityConstraint(){} // RVA: 0x69F4150
        public void BuildIdentityConstraint_Name(){} // RVA: 0x69F45C0
        public void BuildIdentityConstraint_Refer(){} // RVA: 0x69F4630
        public void InitSelector(){} // RVA: 0x69F4830
        public void BuildSelector_XPath(){} // RVA: 0x69F49F0
        public void InitField(){} // RVA: 0x69F4A60
        public void BuildField_XPath(){} // RVA: 0x69F49F0
        public void InitAnnotation(){} // RVA: 0x69F4C00
        public void InitAppinfo(){} // RVA: 0x69F4E20
        public void BuildAppinfo_Source(){} // RVA: 0x69F5030
        public void EndAppinfo(){} // RVA: 0x69F50F0
        public void InitDocumentation(){} // RVA: 0x69F5160
        public void BuildDocumentation_Source(){} // RVA: 0x69F5370
        public void BuildDocumentation_XmlLang(){} // RVA: 0x69F5430
        public void EndDocumentation(){} // RVA: 0x69F5670
        public void AddAttribute(){} // RVA: 0x69F56E0
        public void AddParticle(){} // RVA: 0x69F5980
        public void GetNextState(){} // RVA: 0x69F5DD0
        public void IsSkipableElement(){} // RVA: 0x69F5FA0
        public void SetMinOccurs(){} // RVA: 0x69F5FD0
        public void SetMaxOccurs(){} // RVA: 0x69F6030
        public void ParseBoolean(){} // RVA: 0x69F6090
        public void ParseEnum(){} // RVA: 0x69F6130
        public void ParseQName(){} // RVA: 0x69F6250
        public void ParseBlockFinalEnum(){} // RVA: 0x69F64A0
        public void ParseUriReference(){} // RVA: 0x1A3F520
        public void SendValidationEvent(){} // RVA: 0x69F6C70 | overloaded x5
        public void RecordPosition(){} // RVA: 0x69F6C80
        public void .cctor(){} // RVA: 0x69F6E00
    }

    public class XsdDateTime
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
        public void .ctor(){} // RVA: 0x69FD750 | overloaded x5
        public void InitiateXsdDateTime(){} // RVA: 0x69FD150
        public void TryParse(){} // RVA: 0x69FD290
        public void get_InternalTypeCode(){} // RVA: 0x69FD9E0
        public void get_InternalKind(){} // RVA: 0x5D6FE70
        public void get_Year(){} // RVA: 0x69FD9F0
        public void get_Month(){} // RVA: 0x69FDA80
        public void get_Day(){} // RVA: 0x69FDB10
        public void get_Hour(){} // RVA: 0x69FDBA0
        public void get_Minute(){} // RVA: 0x69FDBF0
        public void get_Second(){} // RVA: 0x69FDC40
        public void get_Fraction(){} // RVA: 0x69FDC90
        public void get_ZoneHour(){} // RVA: 0x1B06E00
        public void get_ZoneMinute(){} // RVA: 0x1B06CA0
        public void op_Implicit(){} // RVA: 0x69FE780 | overloaded x2
        public void ToString(){} // RVA: 0x69FECD0
        public void PrintDate(){} // RVA: 0x69FF2D0
        public void PrintTime(){} // RVA: 0x69FF570
        public void PrintZone(){} // RVA: 0x69FF9D0
        public void IntToCharArray(){} // RVA: 0x69FFD30
        public void ShortToCharArray(){} // RVA: 0x69FFDD0
        public void .cctor(){} // RVA: 0x69FFE50
    }

    public class XsdDuration
    {
        public int years; // 0x10
        public int months; // 0x14
        public int days; // 0x18
        public int hours; // 0x1C
        public int minutes; // 0x20
        public int seconds; // 0x24
        public uint nanoseconds; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A02820 | overloaded x5
        public void get_IsNegative(){} // RVA: 0x6A028D0
        public void get_Years(){} // RVA: 0x19689B0
        public void get_Months(){} // RVA: 0x19689E0
        public void get_Days(){} // RVA: 0x1EA9890
        public void get_Hours(){} // RVA: 0x1EA98B0
        public void get_Minutes(){} // RVA: 0x32A5C0
        public void get_Seconds(){} // RVA: 0x8ABED0
        public void get_Nanoseconds(){} // RVA: 0x6A028E0
        public void ToTimeSpan(){} // RVA: 0x6A02940 | overloaded x2
        public void TryToTimeSpan(){} // RVA: 0x6A029A0 | overloaded x2
        public void ToString(){} // RVA: 0x6A02FD0 | overloaded x2
        public void TryParse(){} // RVA: 0x6A03490 | overloaded x2
        public void TryParseDigits(){} // RVA: 0x6A04050
    }

    public class XsdSimpleValue
    {
        public System.Xml.Schema.XmlSchemaSimpleType xmlType; // 0x10
        public object typedValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_XmlType(){} // RVA: 0x2F8380
        public void get_TypedValue(){} // RVA: 0x2E07C0
    }

    public class XsdValidator
    {
        public int startIDConstraint; // 0x80
        public System.Xml.HWStack validationStack; // 0x88
        public System.Collections.Hashtable attPresence; // 0x90
        public System.Xml.XmlNamespaceManager nsManager; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A041D0 | overloaded x2
        public void Init(){} // RVA: 0x6A04200
        public void Validate(){} // RVA: 0x6A04A40
        public void CompleteValidation(){} // RVA: 0x6A04B20
        public void get_IsInlineSchemaStarted(){} // RVA: 0x6999EB0
        public void ProcessInlineSchema(){} // RVA: 0x6A04CC0
        public void ValidateElement(){} // RVA: 0x6A04F90
        public void ValidateChildElement(){} // RVA: 0x6A051A0
        public void ProcessElement(){} // RVA: 0x6A05420
        public void ProcessXsiAttributes(){} // RVA: 0x6A05870
        public void ValidateEndElement(){} // RVA: 0x6A061A0
        public void FastGetElementDecl(){} // RVA: 0x6A06400
        public void ThoroughGetElementDecl(){} // RVA: 0x6A064F0
        public void ValidateStartElement(){} // RVA: 0x6A06A30
        public void ValidateEndStartElement(){} // RVA: 0x6A073B0
        public void LoadSchemaFromLocation(){} // RVA: 0x6A07810
        public void LoadSchema(){} // RVA: 0x6A07E10
        public void get_HasSchema(){} // RVA: 0x699BC20
        public void get_PreserveWhitespace(){} // RVA: 0x699BC40
        public void ProcessTokenizedType(){} // RVA: 0x6A08000
        public void CheckValue(){} // RVA: 0x6A08300
        public void AddID(){} // RVA: 0x6A088B0
        public void FindId(){} // RVA: 0x699CED0
        public void IsXSDRoot(){} // RVA: 0x6A089B0
        public void Push(){} // RVA: 0x6A089D0
        public void Pop(){} // RVA: 0x6A08D40
        public void CheckForwardRefs(){} // RVA: 0x6A04B20
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x6A08EC0
        public void get_HasIdentityConstraints(){} // RVA: 0x6A08F20
        public void AddIdentityConstraints(){} // RVA: 0x6A08F30
        public void ElementIdentityConstraints(){} // RVA: 0x6A09590
        public void AttributeIdentityConstraints(){} // RVA: 0x6A099D0
        public void UnWrapUnion(){} // RVA: 0x6A09D60
        public void EndElementIdentityConstraints(){} // RVA: 0x6A09DE0
        public void .cctor(){} // RVA: 0x6A0AC00
    }

}