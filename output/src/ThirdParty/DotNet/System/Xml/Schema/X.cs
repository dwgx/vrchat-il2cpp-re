// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 97
// Methods: 1524

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XdrBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF943E430
        public void ProcessElement(){} // RVA: 0x7FFAF943EB50
        public void ProcessAttribute(){} // RVA: 0x7FFAF943EE10
        public void set_XmlResolver(){} // RVA: 0x7FFAF2DF8130
        public void LoadSchema(){} // RVA: 0x7FFAF943F3B0
        public void IsXdrSchema(){} // RVA: 0x7FFAF943F8F0
        public void IsContentParsed(){} // RVA: 0x7FFAF2E72850
        public void ProcessMarkup(){} // RVA: 0x7FFAF943FC20
        public void ProcessCData(){} // RVA: 0x7FFAF943FC80
        public void StartChildren(){} // RVA: 0x7FFAF943FD50
        public void EndChildren(){} // RVA: 0x7FFAF943FD90
        public void Push(){} // RVA: 0x7FFAF943FED0
        public void Pop(){} // RVA: 0x7FFAF943FF60
        public void PushGroupInfo(){} // RVA: 0x7FFAF9440080
        public void PopGroupInfo(){} // RVA: 0x7FFAF9440130
        public void XDR_InitRoot(){} // RVA: 0x7FFAF9440250
        public void XDR_BuildRoot_Name(){} // RVA: 0x7FFAF94403B0
        public void XDR_BuildRoot_ID(){} // RVA: 0x7FFAF2D8D310
        public void XDR_BeginRoot(){} // RVA: 0x7FFAF9440510
        public void XDR_EndRoot(){} // RVA: 0x7FFAF94406E0
        public void XDR_InitElementType(){} // RVA: 0x7FFAF9440C10
        public void XDR_BuildElementType_Name(){} // RVA: 0x7FFAF9440ED0
        public void XDR_BuildElementType_Content(){} // RVA: 0x7FFAF94411F0
        public void XDR_BuildElementType_Model(){} // RVA: 0x7FFAF94412A0
        public void XDR_BuildElementType_Order(){} // RVA: 0x7FFAF9441430
        public void XDR_BuildElementType_DtType(){} // RVA: 0x7FFAF94414F0
        public void XDR_BuildElementType_DtValues(){} // RVA: 0x7FFAF94416C0
        public void XDR_BuildElementType_DtMaxLength(){} // RVA: 0x7FFAF9441810
        public void XDR_BuildElementType_DtMinLength(){} // RVA: 0x7FFAF94418A0
        public void XDR_BeginElementType(){} // RVA: 0x7FFAF9441930
        public void XDR_EndElementType(){} // RVA: 0x7FFAF9441CD0
        public void XDR_InitAttributeType(){} // RVA: 0x7FFAF9442400
        public void XDR_BuildAttributeType_Name(){} // RVA: 0x7FFAF9442600
        public void XDR_BuildAttributeType_Required(){} // RVA: 0x7FFAF9442A60
        public void XDR_BuildAttributeType_Default(){} // RVA: 0x7FFAF9442AE0
        public void XDR_BuildAttributeType_DtType(){} // RVA: 0x7FFAF9442B50
        public void XDR_BuildAttributeType_DtValues(){} // RVA: 0x7FFAF9442DC0
        public void XDR_BuildAttributeType_DtMaxLength(){} // RVA: 0x7FFAF9442F10
        public void XDR_BuildAttributeType_DtMinLength(){} // RVA: 0x7FFAF9442FA0
        public void XDR_BeginAttributeType(){} // RVA: 0x7FFAF9443030
        public void XDR_EndAttributeType(){} // RVA: 0x7FFAF94430F0
        public void XDR_InitElement(){} // RVA: 0x7FFAF9443530
        public void XDR_BuildElement_Type(){} // RVA: 0x7FFAF9443620
        public void XDR_BuildElement_MinOccurs(){} // RVA: 0x7FFAF9443810
        public void XDR_BuildElement_MaxOccurs(){} // RVA: 0x7FFAF9443890
        public void XDR_EndElement(){} // RVA: 0x7FFAF9443910
        public void XDR_InitAttribute(){} // RVA: 0x7FFAF9443A50
        public void XDR_BuildAttribute_Type(){} // RVA: 0x7FFAF9443B20
        public void XDR_BuildAttribute_Required(){} // RVA: 0x7FFAF9443CD0
        public void XDR_BuildAttribute_Default(){} // RVA: 0x7FFAF9443D60
        public void XDR_BeginAttribute(){} // RVA: 0x7FFAF9443DD0
        public void XDR_EndAttribute(){} // RVA: 0x7FFAF9444470
        public void XDR_InitGroup(){} // RVA: 0x7FFAF94444A0
        public void XDR_BuildGroup_Order(){} // RVA: 0x7FFAF9444680
        public void XDR_BuildGroup_MinOccurs(){} // RVA: 0x7FFAF9444770
        public void XDR_BuildGroup_MaxOccurs(){} // RVA: 0x7FFAF9444800
        public void XDR_EndGroup(){} // RVA: 0x7FFAF9444890
        public void XDR_InitElementDtType(){} // RVA: 0x7FFAF9444B60
        public void XDR_EndElementDtType(){} // RVA: 0x7FFAF9444C70
        public void XDR_InitAttributeDtType(){} // RVA: 0x7FFAF9444E40
        public void XDR_EndAttributeDtType(){} // RVA: 0x7FFAF9444EE0
        public void GetNextState(){} // RVA: 0x7FFAF9445010
        public void IsSkipableElement(){} // RVA: 0x7FFAF9445200
        public void IsSkipableAttribute(){} // RVA: 0x7FFAF9445300
        public void GetOrder(){} // RVA: 0x7FFAF9445470
        public void AddOrder(){} // RVA: 0x7FFAF9445630
        public void IsYes(){} // RVA: 0x7FFAF94456F0
        public void ParseMinOccurs(){} // RVA: 0x7FFAF9445870
        public void ParseMaxOccurs(){} // RVA: 0x7FFAF94459B0
        public void HandleMinMax(){} // RVA: 0x7FFAF9445B10
        public void ParseDtMaxLength(){} // RVA: 0x7FFAF9445B40
        public void ParseDtMinLength(){} // RVA: 0x7FFAF9445CC0
        public void CompareMinMaxLength(){} // RVA: 0x7FFAF9445E40
        public void ParseInteger(){} // RVA: 0x7FFAF9445EC0
        public void XDR_CheckAttributeDefault(){} // RVA: 0x7FFAF9445F00
        public void SetAttributePresence(){} // RVA: 0x7FFAF9446010
        public void GetContent(){} // RVA: 0x7FFAF9446060
        public void GetModel(){} // RVA: 0x7FFAF9446270
        public void CheckDatatype(){} // RVA: 0x7FFAF9446390
        public void CheckDefaultAttValue(){} // RVA: 0x7FFAF9446520
        public void IsGlobal(){} // RVA: 0x7FFAF9446690
        public void SendValidationEvent(){} // RVA: 0x7FFAF9446960 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFAF9446A40
    }

    public class XdrValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9449190 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF9449290
        public void Validate(){} // RVA: 0x7FFAF94496C0
        public void ValidateElement(){} // RVA: 0x7FFAF94497A0
        public void ValidateChildElement(){} // RVA: 0x7FFAF9449CE0
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7FFAF9449EB0
        public void ProcessInlineSchema(){} // RVA: 0x7FFAF9449EC0
        public void ProcessElement(){} // RVA: 0x7FFAF944A210
        public void ValidateEndElement(){} // RVA: 0x7FFAF944A330
        public void ThoroughGetElementDecl(){} // RVA: 0x7FFAF944A700
        public void ValidateStartElement(){} // RVA: 0x7FFAF944AB30
        public void ValidateEndStartElement(){} // RVA: 0x7FFAF944B050
        public void LoadSchemaFromLocation(){} // RVA: 0x7FFAF944B410
        public void LoadSchema(){} // RVA: 0x7FFAF944BA60
        public void get_HasSchema(){} // RVA: 0x7FFAF944BC20
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAF944BC40
        public void ProcessTokenizedType(){} // RVA: 0x7FFAF944BC90
        public void CompleteValidation(){} // RVA: 0x7FFAF944BF90
        public void CheckValue(){} // RVA: 0x7FFAF944C220
        public void CheckDefaultValue(){} // RVA: 0x7FFAF944C8F0
        public void AddID(){} // RVA: 0x7FFAF944CDD0
        public void FindId(){} // RVA: 0x7FFAF944CED0
        public void Push(){} // RVA: 0x7FFAF944CF00
        public void Pop(){} // RVA: 0x7FFAF944D1F0
        public void CheckForwardRefs(){} // RVA: 0x7FFAF944D340
        public void QualifiedName(){} // RVA: 0x7FFAF944D4E0
    }

    public class XmlAnyConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9493410
        public void ToBoolean(){} // RVA: 0x7FFAF9493610
        public void ToDateTime(){} // RVA: 0x7FFAF9493800
        public void ToDateTimeOffset(){} // RVA: 0x7FFAF94939F0
        public void ToDecimal(){} // RVA: 0x7FFAF9493C40
        public void ToDouble(){} // RVA: 0x7FFAF9493E90
        public void ToInt32(){} // RVA: 0x7FFAF9494080
        public void ToInt64(){} // RVA: 0x7FFAF9494270
        public void ToSingle(){} // RVA: 0x7FFAF9494460
        public void ChangeType(){} // RVA: 0x7FFAF94958B0 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAF9497280
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAF94973E0
        public void ToNavigator(){} // RVA: 0x7FFAF9497560
        public void .cctor(){} // RVA: 0x7FFAF9497600
    }

    public class XmlAnyListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94977E0
        public void ChangeType(){} // RVA: 0x7FFAF94977F0
        public void .cctor(){} // RVA: 0x7FFAF9497A80
    }

    public class XmlAtomicValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF944DF90 | overloaded x9
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAF44EF520
        public void get_XmlType(){} // RVA: 0x7FFAF2DA8380
        public void get_ValueType(){} // RVA: 0x7FFAF944E240
        public void get_TypedValue(){} // RVA: 0x7FFAF944E280
        public void get_ValueAsBoolean(){} // RVA: 0x7FFAF944E490
        public void get_ValueAsDateTime(){} // RVA: 0x7FFAF944E5A0
        public void get_ValueAsDouble(){} // RVA: 0x7FFAF944E6B0
        public void get_ValueAsInt(){} // RVA: 0x7FFAF944E7C0
        public void get_ValueAsLong(){} // RVA: 0x7FFAF944E8D0
        public void ValueAs(){} // RVA: 0x7FFAF944E9E0
        public void get_Value(){} // RVA: 0x7FFAF944EC50
        public void ToString(){} // RVA: 0x7FFAF2E41BE0
        public void GetPrefixFromQName(){} // RVA: 0x7FFAF944ED90
    }

    public class XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94779D0 | overloaded x4
        public void ToBoolean(){} // RVA: 0x7FFAF9477F80 | overloaded x6
        public void ToDateTime(){} // RVA: 0x7FFAF9478610 | overloaded x7
        public void ToDateTimeOffset(){} // RVA: 0x7FFAF94788D0 | overloaded x3
        public void ToDecimal(){} // RVA: 0x7FFAF9478A90 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFAF9479040 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFAF94795B0 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFAF9479B20 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFAF9479DC0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAF947A6E0 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFAF947AA80 | overloaded x8
        public void get_SchemaType(){} // RVA: 0x7FFAF2DA8380
        public void get_TypeCode(){} // RVA: 0x7FFAF306ED50
        public void get_XmlTypeName(){} // RVA: 0x7FFAF947AAB0
        public void get_DefaultClrType(){} // RVA: 0x7FFAF2DBB0C0
        public void IsDerivedFrom(){} // RVA: 0x7FFAF947ABC0
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFAF947AC70
        public void QNameToString(){} // RVA: 0x7FFAF947CC50 | overloaded x2
        public void ChangeListType(){} // RVA: 0x7FFAF947B0E0
        public void StringToBase64Binary(){} // RVA: 0x7FFAF947B140
        public void StringToDate(){} // RVA: 0x7FFAF947B260
        public void StringToDateTime(){} // RVA: 0x7FFAF947B2E0
        public void StringToDayTimeDuration(){} // RVA: 0x7FFAF947B360
        public void StringToDuration(){} // RVA: 0x7FFAF947B460
        public void StringToGDay(){} // RVA: 0x7FFAF947B560
        public void StringToGMonth(){} // RVA: 0x7FFAF947B5E0
        public void StringToGMonthDay(){} // RVA: 0x7FFAF947B660
        public void StringToGYear(){} // RVA: 0x7FFAF947B6E0
        public void StringToGYearMonth(){} // RVA: 0x7FFAF947B760
        public void StringToDateOffset(){} // RVA: 0x7FFAF947B7E0
        public void StringToDateTimeOffset(){} // RVA: 0x7FFAF947B880
        public void StringToGDayOffset(){} // RVA: 0x7FFAF947B920
        public void StringToGMonthOffset(){} // RVA: 0x7FFAF947B9C0
        public void StringToGMonthDayOffset(){} // RVA: 0x7FFAF947BA60
        public void StringToGYearOffset(){} // RVA: 0x7FFAF947BB00
        public void StringToGYearMonthOffset(){} // RVA: 0x7FFAF947BBA0
        public void StringToHexBinary(){} // RVA: 0x7FFAF947BC40
        public void StringToQName(){} // RVA: 0x7FFAF947BD70
        public void StringToTime(){} // RVA: 0x7FFAF947C070
        public void StringToTimeOffset(){} // RVA: 0x7FFAF947C0F0
        public void StringToYearMonthDuration(){} // RVA: 0x7FFAF947C190
        public void AnyUriToString(){} // RVA: 0x7FFAF947C290
        public void Base64BinaryToString(){} // RVA: 0x7FFAF947C300
        public void DateToString(){} // RVA: 0x7FFAF947C410
        public void DateTimeToString(){} // RVA: 0x7FFAF947C490
        public void DayTimeDurationToString(){} // RVA: 0x7FFAF947C510
        public void DurationToString(){} // RVA: 0x7FFAF947C580
        public void GDayToString(){} // RVA: 0x7FFAF947C5E0
        public void GMonthToString(){} // RVA: 0x7FFAF947C660
        public void GMonthDayToString(){} // RVA: 0x7FFAF947C6E0
        public void GYearToString(){} // RVA: 0x7FFAF947C760
        public void GYearMonthToString(){} // RVA: 0x7FFAF947C7E0
        public void DateOffsetToString(){} // RVA: 0x7FFAF947C860
        public void DateTimeOffsetToString(){} // RVA: 0x7FFAF947C8F0
        public void GDayOffsetToString(){} // RVA: 0x7FFAF947C980
        public void GMonthOffsetToString(){} // RVA: 0x7FFAF947CA10
        public void GMonthDayOffsetToString(){} // RVA: 0x7FFAF947CAA0
        public void GYearOffsetToString(){} // RVA: 0x7FFAF947CB30
        public void GYearMonthOffsetToString(){} // RVA: 0x7FFAF947CBC0
        public void TimeToString(){} // RVA: 0x7FFAF947CE40
        public void TimeOffsetToString(){} // RVA: 0x7FFAF947CEC0
        public void YearMonthDurationToString(){} // RVA: 0x7FFAF947CF50
        public void DateTimeOffsetToDateTime(){} // RVA: 0x7FFAF947CFC0
        public void DecimalToInt32(){} // RVA: 0x7FFAF947D010
        public void DecimalToInt64(){} // RVA: 0x7FFAF947D290
        public void DecimalToUInt64(){} // RVA: 0x7FFAF947D520
        public void Int32ToByte(){} // RVA: 0x7FFAF947D7A0
        public void Int32ToInt16(){} // RVA: 0x7FFAF947D8A0
        public void Int32ToSByte(){} // RVA: 0x7FFAF947D9A0
        public void Int32ToUInt16(){} // RVA: 0x7FFAF947DAA0
        public void Int64ToInt32(){} // RVA: 0x7FFAF947DBA0
        public void Int64ToUInt32(){} // RVA: 0x7FFAF947DCA0
        public void UntypedAtomicToDateTime(){} // RVA: 0x7FFAF947DDA0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x7FFAF947DE20
        public void .cctor(){} // RVA: 0x7FFAF947DEC0
    }

    public class XmlBooleanConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9488390
        public void Create(){} // RVA: 0x7FFAF94883F0
        public void ToBoolean(){} // RVA: 0x7FFAF9488520 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF94888C0 | overloaded x2
        public void ChangeType(){} // RVA: 0x7FFAF9489230 | overloaded x3
    }

    public class XmlDateTimeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9485BA0
        public void Create(){} // RVA: 0x7FFAF9485C00
        public void ToDateTime(){} // RVA: 0x7FFAF9486040 | overloaded x3
        public void ToDateTimeOffset(){} // RVA: 0x7FFAF9486740 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAF94870D0 | overloaded x3
        public void ChangeType(){} // RVA: 0x7FFAF9487B80 | overloaded x3
    }

    public class XmlListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9497FD0 | overloaded x3
        public void Create(){} // RVA: 0x7FFAF9498030
        public void ChangeType(){} // RVA: 0x7FFAF9498210
        public void ChangeListType(){} // RVA: 0x7FFAF9498340
        public void IsListType(){} // RVA: 0x7FFAF9499270
        public void ToArray(){} // RVA: 0x7FFAF2ACE6A0
        public void ToList(){} // RVA: 0x7FFAF9499400
        public void StringAsList(){} // RVA: 0x7FFAF9499990
        public void ListAsString(){} // RVA: 0x7FFAF9499A40
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFAF9499CF0
    }

    public class XmlMiscConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9489880
        public void Create(){} // RVA: 0x7FFAF94898E0
        public void ToString(){} // RVA: 0x7FFAF9489970
        public void ChangeType(){} // RVA: 0x7FFAF948A7F0 | overloaded x2
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAF948B920
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAF948BA80
    }

    public class XmlNumeric10Converter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF947F870
        public void Create(){} // RVA: 0x7FFAF947F8D0
        public void ToDecimal(){} // RVA: 0x7FFAF947FAE0 | overloaded x2
        public void ToInt32(){} // RVA: 0x7FFAF94801A0 | overloaded x3
        public void ToInt64(){} // RVA: 0x7FFAF9480760 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAF9480F30 | overloaded x4
        public void ChangeType(){} // RVA: 0x7FFAF9482440 | overloaded x5
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAF9483500
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAF9483950
    }

    public class XmlNumeric2Converter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9483DF0
        public void Create(){} // RVA: 0x7FFAF9483E50
        public void ToDouble(){} // RVA: 0x7FFAF9483FC0 | overloaded x2
        public void ToSingle(){} // RVA: 0x7FFAF9484440 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAF9484960 | overloaded x3
        public void ChangeType(){} // RVA: 0x7FFAF9485400 | overloaded x3
    }

    public class XmlSchema
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF944F110
        public void Read(){} // RVA: 0x7FFAF944F590
        public void CompileSchema(){} // RVA: 0x7FFAF944F730
        public void CompileSchemaInSet(){} // RVA: 0x7FFAF944FBB0
        public void get_AttributeFormDefault(){} // RVA: 0x7FFAF3A8C9F0
        public void set_AttributeFormDefault(){} // RVA: 0x7FFAF3A8D6E0
        public void get_BlockDefault(){} // RVA: 0x7FFAF2E2E080
        public void set_BlockDefault(){} // RVA: 0x7FFAF2E2E090
        public void get_FinalDefault(){} // RVA: 0x7FFAF2E2E0A0
        public void set_FinalDefault(){} // RVA: 0x7FFAF2E2E0B0
        public void get_ElementFormDefault(){} // RVA: 0x7FFAF3341AF0
        public void set_ElementFormDefault(){} // RVA: 0x7FFAF47695F0
        public void get_TargetNamespace(){} // RVA: 0x7FFAF2E08730
        public void set_TargetNamespace(){} // RVA: 0x7FFAF2E08740
        public void get_Version(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Version(){} // RVA: 0x7FFAF2EE54D0
        public void get_Includes(){} // RVA: 0x7FFAF2E55500
        public void get_Items(){} // RVA: 0x7FFAF2E2B370
        public void get_IsCompiledBySet(){} // RVA: 0x7FFAF3357360
        public void set_IsCompiledBySet(){} // RVA: 0x7FFAF3358570
        public void get_IsPreprocessed(){} // RVA: 0x7FFAF3353000
        public void set_IsPreprocessed(){} // RVA: 0x7FFAF3358560
        public void get_IsRedefined(){} // RVA: 0x7FFAF3357350
        public void set_IsRedefined(){} // RVA: 0x7FFAF3353210
        public void get_Attributes(){} // RVA: 0x7FFAF944FC70
        public void get_AttributeGroups(){} // RVA: 0x7FFAF944FD30
        public void get_SchemaTypes(){} // RVA: 0x7FFAF944FDF0
        public void get_Elements(){} // RVA: 0x7FFAF944FEB0
        public void get_Id(){} // RVA: 0x7FFAF2E08D50
        public void set_Id(){} // RVA: 0x7FFAF2E08D60
        public void get_Groups(){} // RVA: 0x7FFAF34B85E0
        public void get_Notations(){} // RVA: 0x7FFAF34CC130
        public void get_IdentityConstraints(){} // RVA: 0x7FFAF2DF8040
        public void get_BaseUri(){} // RVA: 0x7FFAF2EAA100
        public void set_BaseUri(){} // RVA: 0x7FFAF2EAA110
        public void get_SchemaId(){} // RVA: 0x7FFAF944FF70
        public void get_IsChameleon(){} // RVA: 0x7FFAF3DAD610
        public void set_IsChameleon(){} // RVA: 0x7FFAF8BDFB20
        public void get_Ids(){} // RVA: 0x7FFAF2E0E900
        public void get_Document(){} // RVA: 0x7FFAF944FFF0
        public void get_ErrorCount(){} // RVA: 0x7FFAF4596E60
        public void set_ErrorCount(){} // RVA: 0x7FFAF8CF8F70
        public void Clone(){} // RVA: 0x7FFAF94500B0
        public void DeepClone(){} // RVA: 0x7FFAF9450350
        public void get_IdAttribute(){} // RVA: 0x7FFAF2E08D50
        public void set_IdAttribute(){} // RVA: 0x7FFAF2E08D60
        public void SetIsCompiled(){} // RVA: 0x7FFAF4138890
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAF2E555A0
        public void AddAnnotation(){} // RVA: 0x7FFAF9450900
        public void get_ImportedSchemas(){} // RVA: 0x7FFAF9450960
        public void get_ImportedNamespaces(){} // RVA: 0x7FFAF9450A20
        public void GetExternalSchemasList(){} // RVA: 0x7FFAF9450AE0
        public void .cctor(){} // RVA: 0x7FFAF9450C60
    }

    public class XmlSchemaAll
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAF2F77C50
        public void get_IsEmpty(){} // RVA: 0x7FFAF9450CA0
        public void SetItems(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAF9450D00
    }

    public class XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF2F476A0
        public void set_Id(){} // RVA: 0x7FFAF2F4B830
        public void get_Annotation(){} // RVA: 0x7FFAF2E0A740
        public void set_Annotation(){} // RVA: 0x7FFAF2DB5200
        public void get_UnhandledAttributes(){} // RVA: 0x7FFAF2E08730
        public void set_UnhandledAttributes(){} // RVA: 0x7FFAF2E08740
        public void get_IdAttribute(){} // RVA: 0x7FFAF2F476A0
        public void set_IdAttribute(){} // RVA: 0x7FFAF2F4B830
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAF2E08740
        public void AddAnnotation(){} // RVA: 0x7FFAF2DB5200
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaAnnotation
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF2F476A0
        public void set_Id(){} // RVA: 0x7FFAF2F4B830
        public void get_Items(){} // RVA: 0x7FFAF2E0A740
        public void get_IdAttribute(){} // RVA: 0x7FFAF2F476A0
        public void set_IdAttribute(){} // RVA: 0x7FFAF2F4B830
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAF2E08740
        public void .ctor(){} // RVA: 0x7FFAF9450DE0
    }

    public class XmlSchemaAny
    {
        // ── Methods ──
        public void get_Namespace(){} // RVA: 0x7FFAF2F77C50
        public void set_Namespace(){} // RVA: 0x7FFAF2F734F0
        public void set_ProcessContents(){} // RVA: 0x7FFAF3A74560
        public void get_NamespaceList(){} // RVA: 0x7FFAF2DCC010
        public void get_ResolvedNamespace(){} // RVA: 0x7FFAF9450E80
        public void get_ProcessContentsCorrect(){} // RVA: 0x7FFAF9450ED0
        public void get_NameString(){} // RVA: 0x7FFAF9450EF0
        public void BuildNamespaceList(){} // RVA: 0x7FFAF9451330
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7FFAF9451490
        public void Allows(){} // RVA: 0x7FFAF9451600
        public void .ctor(){} // RVA: 0x7FFAF9451640
    }

    public class XmlSchemaAnyAttribute
    {
        // ── Methods ──
        public void set_Namespace(){} // RVA: 0x7FFAF2EE54D0
        public void get_ProcessContents(){} // RVA: 0x7FFAF349AB90
        public void set_ProcessContents(){} // RVA: 0x7FFAF349AAE0
        public void get_NamespaceList(){} // RVA: 0x7FFAF2E2B370
        public void get_ProcessContentsCorrect(){} // RVA: 0x7FFAF9451690
        public void BuildNamespaceList(){} // RVA: 0x7FFAF94516A0
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7FFAF94517E0
        public void Allows(){} // RVA: 0x7FFAF9451940
        public void IsSubset(){} // RVA: 0x7FFAF9451980
        public void Intersection(){} // RVA: 0x7FFAF94519B0
        public void Union(){} // RVA: 0x7FFAF9451B20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaAppInfo
    {
        // ── Methods ──
        public void set_Source(){} // RVA: 0x7FFAF2F4B830
        public void get_Markup(){} // RVA: 0x7FFAF2E0A740
        public void set_Markup(){} // RVA: 0x7FFAF2DB5200
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaAttribute
    {
        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFAF2E2E0E0
        public void set_DefaultValue(){} // RVA: 0x7FFAF2EE54D0
        public void get_FixedValue(){} // RVA: 0x7FFAF2E55500
        public void set_FixedValue(){} // RVA: 0x7FFAF2E55510
        public void get_Form(){} // RVA: 0x7FFAF4741440
        public void set_Form(){} // RVA: 0x7FFAF4741450
        public void get_Name(){} // RVA: 0x7FFAF2E2B370
        public void set_Name(){} // RVA: 0x7FFAF2E2B380
        public void get_RefName(){} // RVA: 0x7FFAF2E55590
        public void set_RefName(){} // RVA: 0x7FFAF9451C90
        public void get_SchemaTypeName(){} // RVA: 0x7FFAF2F77C50
        public void set_SchemaTypeName(){} // RVA: 0x7FFAF9451D70
        public void get_SchemaType(){} // RVA: 0x7FFAF2DCC010
        public void set_SchemaType(){} // RVA: 0x7FFAF2F13060
        public void get_Use(){} // RVA: 0x7FFAF4741460
        public void set_Use(){} // RVA: 0x7FFAF4741470
        public void get_QualifiedName(){} // RVA: 0x7FFAF2F12D00
        public void get_AttributeSchemaType(){} // RVA: 0x7FFAF3246DE0
        public void get_Datatype(){} // RVA: 0x7FFAF9451E50
        public void SetQualifiedName(){} // RVA: 0x7FFAF2F14450
        public void SetAttributeType(){} // RVA: 0x7FFAF3604600
        public void get_AttDef(){} // RVA: 0x7FFAF34CC8C0
        public void set_AttDef(){} // RVA: 0x7FFAF345A650
        public void get_NameAttribute(){} // RVA: 0x7FFAF2E2B370
        public void set_NameAttribute(){} // RVA: 0x7FFAF2E2B380
        public void Clone(){} // RVA: 0x7FFAF9451E70
        public void .ctor(){} // RVA: 0x7FFAF9452050
    }

    public class XmlSchemaAttributeGroup
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Name(){} // RVA: 0x7FFAF2EE54D0
        public void get_Attributes(){} // RVA: 0x7FFAF2E55500
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2E2B370
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2E2B380
        public void get_QualifiedName(){} // RVA: 0x7FFAF2E08D50
        public void get_AttributeUses(){} // RVA: 0x7FFAF94521D0
        public void get_AttributeWildcard(){} // RVA: 0x7FFAF2F12D00
        public void set_AttributeWildcard(){} // RVA: 0x7FFAF2F14450
        public void get_RedefinedAttributeGroup(){} // RVA: 0x7FFAF2E55590
        public void get_Redefined(){} // RVA: 0x7FFAF2E55590
        public void set_Redefined(){} // RVA: 0x7FFAF2E555A0
        public void get_SelfReferenceCount(){} // RVA: 0x7FFAF36690C0
        public void set_SelfReferenceCount(){} // RVA: 0x7FFAF3669E60
        public void get_NameAttribute(){} // RVA: 0x7FFAF2E2E0E0
        public void set_NameAttribute(){} // RVA: 0x7FFAF2EE54D0
        public void SetQualifiedName(){} // RVA: 0x7FFAF2E08D60
        public void Clone(){} // RVA: 0x7FFAF9452280
        public void .ctor(){} // RVA: 0x7FFAF9452430
    }

    public class XmlSchemaAttributeGroupRef
    {
        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7FFAF2E2E0E0
        public void set_RefName(){} // RVA: 0x7FFAF9452570
        public void .ctor(){} // RVA: 0x7FFAF9452650
    }

    public class XmlSchemaChoice
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAF2F77C50
        public void get_IsEmpty(){} // RVA: 0x7FFAF9452700
        public void SetItems(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAF9452710
    }

    public class XmlSchemaCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94527F0
        public void get_Count(){} // RVA: 0x7FFAF9452A70
        public void get_NameTable(){} // RVA: 0x7FFAF2D907C0
        public void set_XmlResolver(){} // RVA: 0x7FFAF2DB5200
        public void get_Item(){} // RVA: 0x7FFAF9452AA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF9452B60
        public void GetEnumerator(){} // RVA: 0x7FFAF9452C30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF9452D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2E72850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAF9452A70
        public void GetSchemaInfo(){} // RVA: 0x7FFAF9452EA0
        public void GetSchemaNames(){} // RVA: 0x7FFAF9452F60
        public void Add(){} // RVA: 0x7FFAF94532E0 | overloaded x3
        public void get_EventHandler(){} // RVA: 0x7FFAF2F476A0
        public void set_EventHandler(){} // RVA: 0x7FFAF2F4B830
    }

    public class XmlSchemaCollectionEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9453420
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAF94534A0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAF94534F0
        public void MoveNext(){} // RVA: 0x7FFAF9453540
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF9453590
        public void get_Current(){} // RVA: 0x7FFAF94535A0
        public void get_CurrentNode(){} // RVA: 0x7FFAF9453630
    }

    public class XmlSchemaCollectionNode
    {
        public object System.Collections.IEnumerator.Current;
        public object Current;
        public object CurrentNode;

        // ── Methods ──
        public void set_NamespaceURI(){} // RVA: 0x7FFAF2D8EE30
        public void get_SchemaInfo(){} // RVA: 0x7FFAF2D907C0
        public void set_SchemaInfo(){} // RVA: 0x7FFAF2DF3E80
        public void get_Schema(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Schema(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaCompilationSettings
    {
        public object IsMixed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF316D7E0
        public void get_EnableUpaCheck(){} // RVA: 0x7FFAF2E575E0
    }

    public class XmlSchemaComplexContent
    {
        // ── Methods ──
        public void get_IsMixed(){} // RVA: 0x7FFAF304FF30
        public void set_IsMixed(){} // RVA: 0x7FFAF94536C0
        public void get_Content(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Content(){} // RVA: 0x7FFAF2EE54D0
        public void get_HasMixedAttribute(){} // RVA: 0x7FFAF7A94B90
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaComplexContentExtension
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAF2E08D50
        public void set_BaseTypeName(){} // RVA: 0x7FFAF94536D0
        public void get_Particle(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Particle(){} // RVA: 0x7FFAF2EE54D0
        public void get_Attributes(){} // RVA: 0x7FFAF2E55500
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2E2B370
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2E2B380
        public void SetAttributes(){} // RVA: 0x7FFAF2E55510
        public void .ctor(){} // RVA: 0x7FFAF94537B0
    }

    public class XmlSchemaComplexContentRestriction
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAF2E08D50
        public void set_BaseTypeName(){} // RVA: 0x7FFAF94538F0
        public void get_Particle(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Particle(){} // RVA: 0x7FFAF2EE54D0
        public void get_Attributes(){} // RVA: 0x7FFAF2E55500
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2E2B370
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2E2B380
        public void SetAttributes(){} // RVA: 0x7FFAF2E55510
        public void .ctor(){} // RVA: 0x7FFAF94539D0
    }

    public class XmlSchemaComplexType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9453B10
        public void CreateAnyType(){} // RVA: 0x7FFAF9454020
        public void .ctor(){} // RVA: 0x7FFAF9454670
        public void get_AnyType(){} // RVA: 0x7FFAF9454730
        public void get_UntypedAnyType(){} // RVA: 0x7FFAF9454790
        public void get_AnyTypeContentValidator(){} // RVA: 0x7FFAF94547F0
        public void get_IsAbstract(){} // RVA: 0x7FFAF9454870
        public void set_IsAbstract(){} // RVA: 0x7FFAF9454880
        public void get_Block(){} // RVA: 0x7FFAF4826570
        public void set_Block(){} // RVA: 0x7FFAF4826000
        public void get_IsMixed(){} // RVA: 0x7FFAF94548B0
        public void set_IsMixed(){} // RVA: 0x7FFAF94548C0
        public void get_ContentModel(){} // RVA: 0x7FFAF34B85E0
        public void set_ContentModel(){} // RVA: 0x7FFAF345A5F0
        public void get_Particle(){} // RVA: 0x7FFAF34CC130
        public void set_Particle(){} // RVA: 0x7FFAF3595030
        public void get_Attributes(){} // RVA: 0x7FFAF94548F0
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2DF80B0
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2DF80C0
        public void get_ContentType(){} // RVA: 0x7FFAF315FD40
        public void get_ContentTypeParticle(){} // RVA: 0x7FFAF2DF8120
        public void get_BlockResolved(){} // RVA: 0x7FFAF34B02A0
        public void get_AttributeUses(){} // RVA: 0x7FFAF94549B0
        public void get_AttributeWildcard(){} // RVA: 0x7FFAF2E0E900
        public void get_LocalElements(){} // RVA: 0x7FFAF9454A70
        public void SetContentTypeParticle(){} // RVA: 0x7FFAF2DF8130
        public void SetBlockResolved(){} // RVA: 0x7FFAF639ED60
        public void SetAttributeWildcard(){} // RVA: 0x7FFAF2E0E910
        public void set_HasWildCard(){} // RVA: 0x7FFAF9454B30
        public void SetAttributes(){} // RVA: 0x7FFAF2DF8050
        public void ContainsIdAttribute(){} // RVA: 0x7FFAF9454B60
        public void Clone(){} // RVA: 0x7FFAF9454DE0 | overloaded x2
        public void ClearCompiledState(){} // RVA: 0x7FFAF9455800
        public void CloneAttributes(){} // RVA: 0x7FFAF94559C0
        public void CloneGroupBaseParticles(){} // RVA: 0x7FFAF9455CC0
        public void CloneParticle(){} // RVA: 0x7FFAF9455E20
        public void GetResolvedElementForm(){} // RVA: 0x7FFAF9456360
        public void HasParticleRef(){} // RVA: 0x7FFAF9456390
        public void HasAttributeQNameRef(){} // RVA: 0x7FFAF9456710
    }

    public class XmlSchemaContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaContentModel
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0x7FFAF2ABCD60
        public void set_Content(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaDatatype
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFAF2ABCD60
        public void get_TokenizedType(){} // RVA: 0x7FFAF2ABD840
        public void ParseValue(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void get_Variety(){} // RVA: 0x7FFAF2FC9240
        public void get_TypeCode(){} // RVA: 0x7FFAF2FC9240
        public void IsDerivedFrom(){} // RVA: 0x7FFAF2D8D320
        public void get_HasLexicalFacets(){} // RVA: 0x7FFAF2ABDBE0
        public void get_HasValueFacets(){} // RVA: 0x7FFAF2ABDBE0
        public void get_ValueConverter(){} // RVA: 0x7FFAF2ABCD60
        public void get_Restriction(){} // RVA: 0x7FFAF2ABCD60
        public void Compare(){} // RVA: 0x7FFAF2AC7680
        public void TryParseValue(){} // RVA: 0x7FFAF2ACF0F0 | overloaded x2
        public void get_FacetsChecker(){} // RVA: 0x7FFAF2ABCD60
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAF2ABD840
        public void DeriveByRestriction(){} // RVA: 0x7FFAF2ACEE30
        public void DeriveByList(){} // RVA: 0x7FFAF2ABCE10
        public void VerifySchemaValid(){} // RVA: 0x7FFAF2ADDC60
        public void IsEqual(){} // RVA: 0x7FFAF2AC1120
        public void IsComparable(){} // RVA: 0x7FFAF2ABDE40
        public void get_TypeCodeString(){} // RVA: 0x7FFAF94568C0
        public void TypeCodeToString(){} // RVA: 0x7FFAF9456A40
        public void ConcatenatedToString(){} // RVA: 0x7FFAF94570C0
        public void FromXmlTokenizedType(){} // RVA: 0x7FFAF94576E0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7FFAF9457790
        public void FromXdrName(){} // RVA: 0x7FFAF9457840
        public void DeriveByUnion(){} // RVA: 0x7FFAF9457A00
        public void XdrCanonizeUri(){} // RVA: 0x7FFAF9457A60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaDocumentation
    {
        // ── Methods ──
        public void set_Source(){} // RVA: 0x7FFAF2F4B830
        public void set_Language(){} // RVA: 0x7FFAF9457DF0
        public void set_Markup(){} // RVA: 0x7FFAF2E08740
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF9457F40
    }

    public class XmlSchemaElement
    {
        // ── Methods ──
        public void get_IsAbstract(){} // RVA: 0x7FFAF33510E0
        public void set_IsAbstract(){} // RVA: 0x7FFAF9458060
        public void get_Block(){} // RVA: 0x7FFAF3A74570
        public void set_Block(){} // RVA: 0x7FFAF3A74560
        public void get_DefaultValue(){} // RVA: 0x7FFAF3246DE0
        public void set_DefaultValue(){} // RVA: 0x7FFAF3604600
        public void get_Final(){} // RVA: 0x7FFAF470A600
        public void set_Final(){} // RVA: 0x7FFAF470A650
        public void get_FixedValue(){} // RVA: 0x7FFAF34CC8C0
        public void set_FixedValue(){} // RVA: 0x7FFAF345A650
        public void get_Form(){} // RVA: 0x7FFAF36690C0
        public void set_Form(){} // RVA: 0x7FFAF3669E60
        public void get_Name(){} // RVA: 0x7FFAF34B85E0
        public void set_Name(){} // RVA: 0x7FFAF345A5F0
        public void get_IsNillable(){} // RVA: 0x7FFAF3353000
        public void set_IsNillable(){} // RVA: 0x7FFAF9458070
        public void get_HasNillableAttribute(){} // RVA: 0x7FFAF3357350
        public void get_HasAbstractAttribute(){} // RVA: 0x7FFAF3357360
        public void get_RefName(){} // RVA: 0x7FFAF34CC130
        public void set_RefName(){} // RVA: 0x7FFAF9458080
        public void get_SubstitutionGroup(){} // RVA: 0x7FFAF2DF8040
        public void set_SubstitutionGroup(){} // RVA: 0x7FFAF9458170
        public void get_SchemaTypeName(){} // RVA: 0x7FFAF2DF80B0
        public void set_SchemaTypeName(){} // RVA: 0x7FFAF9458260
        public void get_SchemaType(){} // RVA: 0x7FFAF2DF8120
        public void set_SchemaType(){} // RVA: 0x7FFAF2DF8130
        public void get_Constraints(){} // RVA: 0x7FFAF9458350
        public void get_QualifiedName(){} // RVA: 0x7FFAF2EE5460
        public void get_ElementSchemaType(){} // RVA: 0x7FFAF2EAA100
        public void get_BlockResolved(){} // RVA: 0x7FFAF4741A50
        public void get_FinalResolved(){} // RVA: 0x7FFAF9458410
        public void SetQualifiedName(){} // RVA: 0x7FFAF2EE5470
        public void SetElementType(){} // RVA: 0x7FFAF2EAA110
        public void SetBlockResolved(){} // RVA: 0x7FFAF4741A60
        public void SetFinalResolved(){} // RVA: 0x7FFAF9458420
        public void get_HasConstraints(){} // RVA: 0x7FFAF9458430
        public void get_IsLocalTypeDerivationChecked(){} // RVA: 0x7FFAF33589C0
        public void set_IsLocalTypeDerivationChecked(){} // RVA: 0x7FFAF3354A90
        public void get_ElementDecl(){} // RVA: 0x7FFAF2E0E970
        public void set_ElementDecl(){} // RVA: 0x7FFAF2E0E980
        public void get_NameAttribute(){} // RVA: 0x7FFAF34B85E0
        public void set_NameAttribute(){} // RVA: 0x7FFAF345A5F0
        public void get_NameString(){} // RVA: 0x7FFAF9458480
        public void Clone(){} // RVA: 0x7FFAF94584C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF9458940
    }

    public class XmlSchemaEnumerationFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A5B0
    }

    public class XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A110 | overloaded x14
        public void GetObjectData(){} // RVA: 0x7FFAF9459390
        public void CreateMessage(){} // RVA: 0x7FFAF945A2F0
        public void get_GetRes(){} // RVA: 0x7FFAF3246DE0
        public void get_Args(){} // RVA: 0x7FFAF34CC8C0
        public void get_SourceUri(){} // RVA: 0x7FFAF34B85E0
        public void get_LineNumber(){} // RVA: 0x7FFAF3773CB0
        public void get_LinePosition(){} // RVA: 0x7FFAF66F9C20
        public void get_SourceSchemaObject(){} // RVA: 0x7FFAF2DF8040
        public void SetSource(){} // RVA: 0x7FFAF945A3B0 | overloaded x2
        public void SetSchemaObject(){} // RVA: 0x7FFAF2DF8050
        public void get_Message(){} // RVA: 0x7FFAF945A4A0
    }

    public class XmlSchemaExternal
    {
        // ── Methods ──
        public void get_SchemaLocation(){} // RVA: 0x7FFAF2F476A0
        public void set_SchemaLocation(){} // RVA: 0x7FFAF2F4B830
        public void get_Schema(){} // RVA: 0x7FFAF2E08730
        public void set_Schema(){} // RVA: 0x7FFAF2E08740
        public void get_Id(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Id(){} // RVA: 0x7FFAF2EE54D0
        public void get_BaseUri(){} // RVA: 0x7FFAF2E0A740
        public void set_BaseUri(){} // RVA: 0x7FFAF2DB5200
        public void get_IdAttribute(){} // RVA: 0x7FFAF2E2E0E0
        public void set_IdAttribute(){} // RVA: 0x7FFAF2EE54D0
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAF2E55510
        public void get_Compositor(){} // RVA: 0x7FFAF304CEC0
        public void set_Compositor(){} // RVA: 0x7FFAF304C530
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaFacet
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Value(){} // RVA: 0x7FFAF2EE54D0
        public void get_IsFixed(){} // RVA: 0x7FFAF304FF30
        public void set_IsFixed(){} // RVA: 0x7FFAF945A4C0
        public void get_FacetType(){} // RVA: 0x7FFAF30554D0
        public void set_FacetType(){} // RVA: 0x7FFAF349ACA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaFractionDigitsFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A610
    }

    public class XmlSchemaGroup
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Name(){} // RVA: 0x7FFAF2EE54D0
        public void get_Particle(){} // RVA: 0x7FFAF2E55500
        public void set_Particle(){} // RVA: 0x7FFAF2E55510
        public void get_QualifiedName(){} // RVA: 0x7FFAF2E08D50
        public void get_CanonicalParticle(){} // RVA: 0x7FFAF2E2B370
        public void set_CanonicalParticle(){} // RVA: 0x7FFAF2E2B380
        public void get_Redefined(){} // RVA: 0x7FFAF2E55590
        public void set_Redefined(){} // RVA: 0x7FFAF2E555A0
        public void get_SelfReferenceCount(){} // RVA: 0x7FFAF4593800
        public void set_SelfReferenceCount(){} // RVA: 0x7FFAF4596D80
        public void get_NameAttribute(){} // RVA: 0x7FFAF2E2E0E0
        public void set_NameAttribute(){} // RVA: 0x7FFAF2EE54D0
        public void SetQualifiedName(){} // RVA: 0x7FFAF2E08D60
        public void Clone(){} // RVA: 0x7FFAF945A640 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF945A890
    }

    public class XmlSchemaGroupBase
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAF2ABCD60
        public void SetItems(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF945A940
    }

    public class XmlSchemaGroupRef
    {
        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7FFAF2F77C50
        public void set_RefName(){} // RVA: 0x7FFAF945A990
        public void get_Particle(){} // RVA: 0x7FFAF2F12D00
        public void SetParticle(){} // RVA: 0x7FFAF2F14450
        public void get_Redefined(){} // RVA: 0x7FFAF2DCC010
        public void set_Redefined(){} // RVA: 0x7FFAF2F13060
        public void .ctor(){} // RVA: 0x7FFAF945AA70
    }

    public class XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Name(){} // RVA: 0x7FFAF2EE54D0
        public void get_Selector(){} // RVA: 0x7FFAF2E55500
        public void set_Selector(){} // RVA: 0x7FFAF2E55510
        public void get_Fields(){} // RVA: 0x7FFAF2E2B370
        public void get_QualifiedName(){} // RVA: 0x7FFAF2E08D50
        public void SetQualifiedName(){} // RVA: 0x7FFAF2E08D60
        public void get_CompiledConstraint(){} // RVA: 0x7FFAF2E55590
        public void set_CompiledConstraint(){} // RVA: 0x7FFAF2E555A0
        public void get_NameAttribute(){} // RVA: 0x7FFAF2E2E0E0
        public void set_NameAttribute(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF945AB50
    }

    public class XmlSchemaImport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945AE30
        public void get_Namespace(){} // RVA: 0x7FFAF2E08D50
        public void set_Namespace(){} // RVA: 0x7FFAF2E08D60
        public void AddAnnotation(){} // RVA: 0x7FFAF2E555A0
    }

    public class XmlSchemaInclude
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945AE40
        public void AddAnnotation(){} // RVA: 0x7FFAF2E08D60
    }

    public class XmlSchemaInference
    {
        // ── Methods ──
        public void set_Occurrence(){} // RVA: 0x7FFAF2E2E0D0
        public void get_Occurrence(){} // RVA: 0x7FFAF2E2E0C0
        public void set_TypeInference(){} // RVA: 0x7FFAF4825D90
        public void .ctor(){} // RVA: 0x7FFAF93DF000
        public void InferSchema(){} // RVA: 0x7FFAF93DF240
        public void InferSchema1(){} // RVA: 0x7FFAF93DF2D0
        public void AddAttribute(){} // RVA: 0x7FFAF93DFD40
        public void CreateXmlSchema(){} // RVA: 0x7FFAF93E08A0
        public void AddElement(){} // RVA: 0x7FFAF93E0980
        public void InferElement(){} // RVA: 0x7FFAF93E1610
        public void CheckSimpleContentExtension(){} // RVA: 0x7FFAF93E2FE0
        public void GetEffectiveSchemaType(){} // RVA: 0x7FFAF93E3190
        public void FindMatchingElement(){} // RVA: 0x7FFAF93E33D0
        public void ProcessAttributes(){} // RVA: 0x7FFAF93E4960
        public void MoveAttributes(){} // RVA: 0x7FFAF93E5640 | overloaded x2
        public void FindAttribute(){} // RVA: 0x7FFAF93E59E0
        public void FindGlobalElement(){} // RVA: 0x7FFAF93E5C50
        public void FindElement(){} // RVA: 0x7FFAF93E5ED0
        public void FindAttributeRef(){} // RVA: 0x7FFAF93E6080
        public void FindElementRef(){} // RVA: 0x7FFAF93E6370
        public void MakeExistingAttributesOptional(){} // RVA: 0x7FFAF93E6580
        public void SwitchUseToOptional(){} // RVA: 0x7FFAF93E6650
        public void RefineSimpleType(){} // RVA: 0x7FFAF93E67D0
        public void InferSimpleType(){} // RVA: 0x7FFAF93E7600
        public void DateTime(){} // RVA: 0x7FFAF93E8790
        public void CreateNewElementforChoice(){} // RVA: 0x7FFAF93E88E0
        public void GetSchemaType(){} // RVA: 0x7FFAF93E9090
        public void SetMinMaxOccurs(){} // RVA: 0x7FFAF93E9C80
        public void .cctor(){} // RVA: 0x7FFAF93E9EB0
    }

    public class XmlSchemaInferenceException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93EB390 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAF93EB290
    }

    public class XmlSchemaInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945AE60 | overloaded x2
        public void get_Validity(){} // RVA: 0x7FFAF3A8C9F0
        public void set_Validity(){} // RVA: 0x7FFAF3A8D6E0
        public void get_IsDefault(){} // RVA: 0x7FFAF2E575E0
        public void set_IsDefault(){} // RVA: 0x7FFAF2E575F0
        public void get_IsNil(){} // RVA: 0x7FFAF2FF3460
        public void set_IsNil(){} // RVA: 0x7FFAF2FF3470
        public void get_MemberType(){} // RVA: 0x7FFAF30E74D0
        public void set_MemberType(){} // RVA: 0x7FFAF2DBB890
        public void get_SchemaType(){} // RVA: 0x7FFAF2DBB130
        public void set_SchemaType(){} // RVA: 0x7FFAF945AE90
        public void get_SchemaElement(){} // RVA: 0x7FFAF2D907C0
        public void set_SchemaElement(){} // RVA: 0x7FFAF945AF20
        public void get_SchemaAttribute(){} // RVA: 0x7FFAF2DBB0C0
        public void set_SchemaAttribute(){} // RVA: 0x7FFAF945AFE0
        public void get_ContentType(){} // RVA: 0x7FFAF3341AF0
        public void get_XmlType(){} // RVA: 0x7FFAF945B0A0
        public void get_HasDefaultValue(){} // RVA: 0x7FFAF945B0C0
        public void get_IsUnionType(){} // RVA: 0x7FFAF945B100
        public void Clear(){} // RVA: 0x7FFAF945B140
    }

    public class XmlSchemaKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945AC90
    }

    public class XmlSchemaKeyref
    {
        // ── Methods ──
        public void get_Refer(){} // RVA: 0x7FFAF2F77C50
        public void set_Refer(){} // RVA: 0x7FFAF945ACA0
        public void .ctor(){} // RVA: 0x7FFAF945AD80
    }

    public class XmlSchemaLengthFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A570
    }

    public class XmlSchemaMaxExclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A5E0
    }

    public class XmlSchemaMaxInclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A5F0
    }

    public class XmlSchemaMaxLengthFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A590
    }

    public class XmlSchemaMinExclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A5C0
    }

    public class XmlSchemaMinInclusiveFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A5D0
    }

    public class XmlSchemaMinLengthFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A580
    }

    public class XmlSchemaNotation
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Name(){} // RVA: 0x7FFAF2EE54D0
        public void get_Public(){} // RVA: 0x7FFAF2E55500
        public void set_Public(){} // RVA: 0x7FFAF2E55510
        public void get_System(){} // RVA: 0x7FFAF2E2B370
        public void set_System(){} // RVA: 0x7FFAF2E2B380
        public void get_QualifiedName(){} // RVA: 0x7FFAF2E08D50
        public void set_QualifiedName(){} // RVA: 0x7FFAF2E08D60
        public void get_NameAttribute(){} // RVA: 0x7FFAF2E2E0E0
        public void set_NameAttribute(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF945B2B0
    }

    public class XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaObject
    {
        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7FFAF2DDA5C0
        public void set_LineNumber(){} // RVA: 0x7FFAF2D900C0
        public void get_LinePosition(){} // RVA: 0x7FFAF335BED0
        public void set_LinePosition(){} // RVA: 0x7FFAF335C660
        public void get_SourceUri(){} // RVA: 0x7FFAF2D907C0
        public void set_SourceUri(){} // RVA: 0x7FFAF2DF3E80
        public void get_Parent(){} // RVA: 0x7FFAF2DBB130
        public void set_Parent(){} // RVA: 0x7FFAF2D8EE90
        public void get_Namespaces(){} // RVA: 0x7FFAF945B360
        public void set_Namespaces(){} // RVA: 0x7FFAF2DBB0D0
        public void OnAdd(){} // RVA: 0x7FFAF2D8D310
        public void OnRemove(){} // RVA: 0x7FFAF2D8D310
        public void OnClear(){} // RVA: 0x7FFAF2D8D310
        public void get_IdAttribute(){} // RVA: 0x7FFAF2FC9240
        public void set_IdAttribute(){} // RVA: 0x7FFAF2D8D310
        public void SetUnhandledAttributes(){} // RVA: 0x7FFAF2D8D310
        public void AddAnnotation(){} // RVA: 0x7FFAF2D8D310
        public void get_NameAttribute(){} // RVA: 0x7FFAF2FC9240
        public void set_NameAttribute(){} // RVA: 0x7FFAF2D8D310
        public void get_IsProcessing(){} // RVA: 0x7FFAF2DB3450
        public void set_IsProcessing(){} // RVA: 0x7FFAF2DB3460
        public void Clone(){} // RVA: 0x7FFAF945B400
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaObjectCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF867CCF0
        public void get_Item(){} // RVA: 0x7FFAF945B480
        public void set_Item(){} // RVA: 0x7FFAF945B530
        public void GetEnumerator(){} // RVA: 0x7FFAF945B5A0
        public void Add(){} // RVA: 0x7FFAF945B910 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAF945B6B0
        public void Remove(){} // RVA: 0x7FFAF945B720
        public void OnInsert(){} // RVA: 0x7FFAF945B780
        public void OnSet(){} // RVA: 0x7FFAF945B7B0
        public void OnClear(){} // RVA: 0x7FFAF945B820
        public void OnRemove(){} // RVA: 0x7FFAF945B850
        public void Clone(){} // RVA: 0x7FFAF945B880
    }

    public class XmlSchemaObjectEnumerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void MoveNext(){} // RVA: 0x7FFAF945B940
        public void get_Current(){} // RVA: 0x7FFAF945B990
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAF945BA30
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAF945BA80
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF945BAD0
    }

    public class XmlSchemaObjectTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945BB20
        public void Add(){} // RVA: 0x7FFAF945BC80
        public void Insert(){} // RVA: 0x7FFAF945BE00
        public void Replace(){} // RVA: 0x7FFAF945BF60
        public void Clear(){} // RVA: 0x7FFAF945C0A0
        public void Remove(){} // RVA: 0x7FFAF945C130
        public void FindIndexByValue(){} // RVA: 0x7FFAF945C200
        public void get_Count(){} // RVA: 0x7FFAF945C2B0
        public void Contains(){} // RVA: 0x7FFAF945C300
        public void get_Item(){} // RVA: 0x7FFAF945C380
        public void get_Values(){} // RVA: 0x7FFAF945C400
        public void GetEnumerator(){} // RVA: 0x7FFAF945C4D0
    }

    public class XmlSchemaParticle
    {
        // ── Methods ──
        public void get_MinOccursString(){} // RVA: 0x7FFAF945D2B0
        public void set_MinOccursString(){} // RVA: 0x7FFAF945D3F0
        public void get_MaxOccursString(){} // RVA: 0x7FFAF945D600
        public void set_MaxOccursString(){} // RVA: 0x7FFAF945D800
        public void get_MinOccurs(){} // RVA: 0x7FFAF6C90130
        public void set_MinOccurs(){} // RVA: 0x7FFAF945DB10
        public void get_MaxOccurs(){} // RVA: 0x7FFAF615BF00
        public void set_MaxOccurs(){} // RVA: 0x7FFAF945DD90
        public void get_IsEmpty(){} // RVA: 0x7FFAF945E0A0
        public void get_NameString(){} // RVA: 0x7FFAF945E160
        public void GetQualifiedName(){} // RVA: 0x7FFAF945E1A0
        public void .ctor(){} // RVA: 0x7FFAF945E380
        public void .cctor(){} // RVA: 0x7FFAF945E400
    }

    public class XmlSchemaPatternFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A5A0
    }

    public class XmlSchemaRedefine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945E550
        public void get_Items(){} // RVA: 0x7FFAF2E08D50
        public void get_AttributeGroups(){} // RVA: 0x7FFAF2E55590
        public void get_SchemaTypes(){} // RVA: 0x7FFAF2F77C50
        public void get_Groups(){} // RVA: 0x7FFAF2F12D00
        public void AddAnnotation(){} // RVA: 0x7FFAF945E770
    }

    public class XmlSchemaSequence
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAF2F77C50
        public void get_IsEmpty(){} // RVA: 0x7FFAF9450CA0
        public void SetItems(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAF945E7D0
    }

    public class XmlSchemaSet
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF945E8B0
        public void .ctor(){} // RVA: 0x7FFAF945E9C0 | overloaded x2
        public void add_ValidationEventHandler(){} // RVA: 0x7FFAF945EFB0
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFAF945F1D0
        public void get_IsCompiled(){} // RVA: 0x7FFAF2F56500
        public void set_XmlResolver(){} // RVA: 0x7FFAF945F330
        public void get_CompilationSettings(){} // RVA: 0x7FFAF2F77C50
        public void set_CompilationSettings(){} // RVA: 0x7FFAF2F734F0
        public void get_Count(){} // RVA: 0x7FFAF945F350
        public void get_GlobalElements(){} // RVA: 0x7FFAF945F380
        public void get_GlobalAttributes(){} // RVA: 0x7FFAF945F440
        public void get_GlobalTypes(){} // RVA: 0x7FFAF945F500
        public void get_SubstitutionGroups(){} // RVA: 0x7FFAF945F5C0
        public void get_SchemaLocations(){} // RVA: 0x7FFAF2E0A740
        public void get_TypeExtensions(){} // RVA: 0x7FFAF945F680
        public void Add(){} // RVA: 0x7FFAF94623D0 | overloaded x4
        public void RemoveRecursive(){} // RVA: 0x7FFAF94602C0
        public void Contains(){} // RVA: 0x7FFAF9460C50
        public void Compile(){} // RVA: 0x7FFAF9460CD0
        public void Reprocess(){} // RVA: 0x7FFAF9461700
        public void CopyTo(){} // RVA: 0x7FFAF9462040
        public void Schemas(){} // RVA: 0x7FFAF9462170 | overloaded x2
        public void FindSchemaByNSAndUrl(){} // RVA: 0x7FFAF9462930
        public void AddSchemaToSet(){} // RVA: 0x7FFAF9462C80
        public void ProcessNewSubstitutionGroups(){} // RVA: 0x7FFAF9463170
        public void ResolveSubstitutionGroup(){} // RVA: 0x7FFAF9463510
        public void Remove(){} // RVA: 0x7FFAF9463940
        public void ClearTables(){} // RVA: 0x7FFAF9463D30
        public void PreprocessSchema(){} // RVA: 0x7FFAF9463E70
        public void ParseSchema(){} // RVA: 0x7FFAF9464120
        public void CopyFromCompiledSet(){} // RVA: 0x7FFAF94642D0
        public void get_CompiledInfo(){} // RVA: 0x7FFAF2E2B370
        public void get_ReaderSettings(){} // RVA: 0x7FFAF2E08D50
        public void GetResolver(){} // RVA: 0x7FFAF94656A0
        public void GetEventHandler(){} // RVA: 0x7FFAF30E74D0
        public void GetSchemaNames(){} // RVA: 0x7FFAF94656C0
        public void IsSchemaLoaded(){} // RVA: 0x7FFAF94657C0
        public void GetSchemaByUri(){} // RVA: 0x7FFAF94664F0
        public void GetTargetNamespace(){} // RVA: 0x7FFAF9466740
        public void get_SortedSchemas(){} // RVA: 0x7FFAF2DBB0C0
        public void RemoveSchemaFromCaches(){} // RVA: 0x7FFAF94667A0
        public void RemoveSchemaFromGlobalTables(){} // RVA: 0x7FFAF9466C70
        public void AddToTable(){} // RVA: 0x7FFAF9467680
        public void VerifyTables(){} // RVA: 0x7FFAF94679F0
        public void InternalValidationCallback(){} // RVA: 0x7FFAF9467C30
        public void SendValidationEvent(){} // RVA: 0x7FFAF9467C80
    }

    public class XmlSchemaSimpleContent
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Content(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaSimpleContentExtension
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAF2E2B370
        public void set_BaseTypeName(){} // RVA: 0x7FFAF9467D50
        public void get_Attributes(){} // RVA: 0x7FFAF2E2E0E0
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2E55500
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2E55510
        public void SetAttributes(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF9467E30
    }

    public class XmlSchemaSimpleContentRestriction
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAF2E2E0E0
        public void set_BaseTypeName(){} // RVA: 0x7FFAF9467F70
        public void get_BaseType(){} // RVA: 0x7FFAF2E55500
        public void set_BaseType(){} // RVA: 0x7FFAF2E55510
        public void get_Facets(){} // RVA: 0x7FFAF2E2B370
        public void get_Attributes(){} // RVA: 0x7FFAF2E08D50
        public void get_AnyAttribute(){} // RVA: 0x7FFAF2E55590
        public void set_AnyAttribute(){} // RVA: 0x7FFAF2E555A0
        public void SetAttributes(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAF9468050
    }

    public class XmlSchemaSimpleType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9468210
        public void get_Content(){} // RVA: 0x7FFAF34CC8C0
        public void set_Content(){} // RVA: 0x7FFAF345A650
        public void Clone(){} // RVA: 0x7FFAF9468220
    }

    public class XmlSchemaSimpleTypeContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSchemaSimpleTypeList
    {
        // ── Methods ──
        public void get_ItemTypeName(){} // RVA: 0x7FFAF2E2E0E0
        public void set_ItemTypeName(){} // RVA: 0x7FFAF9468390
        public void get_ItemType(){} // RVA: 0x7FFAF2E55500
        public void set_ItemType(){} // RVA: 0x7FFAF2E55510
        public void get_BaseItemType(){} // RVA: 0x7FFAF2E2B370
        public void set_BaseItemType(){} // RVA: 0x7FFAF2E2B380
        public void Clone(){} // RVA: 0x7FFAF9468470
        public void .ctor(){} // RVA: 0x7FFAF94685D0
    }

    public class XmlSchemaSimpleTypeRestriction
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7FFAF2E2E0E0
        public void set_BaseTypeName(){} // RVA: 0x7FFAF9468680
        public void get_BaseType(){} // RVA: 0x7FFAF2E55500
        public void set_BaseType(){} // RVA: 0x7FFAF2E55510
        public void get_Facets(){} // RVA: 0x7FFAF2E2B370
        public void Clone(){} // RVA: 0x7FFAF9468760
        public void .ctor(){} // RVA: 0x7FFAF94688C0
    }

    public class XmlSchemaSimpleTypeUnion
    {
        // ── Methods ──
        public void get_BaseTypes(){} // RVA: 0x7FFAF2E2E0E0
        public void get_MemberTypes(){} // RVA: 0x7FFAF2E55500
        public void set_MemberTypes(){} // RVA: 0x7FFAF2E55510
        public void get_BaseMemberTypes(){} // RVA: 0x7FFAF2E2B370
        public void SetBaseMemberTypes(){} // RVA: 0x7FFAF2E2B380
        public void Clone(){} // RVA: 0x7FFAF9468A10
        public void .ctor(){} // RVA: 0x7FFAF9468CF0
    }

    public class XmlSchemaSubstitutionGroup
    {
        // ── Methods ──
        public void get_Members(){} // RVA: 0x7FFAF2F476A0
        public void get_Examplar(){} // RVA: 0x7FFAF2E0A740
        public void set_Examplar(){} // RVA: 0x7FFAF2DB5200
        public void .ctor(){} // RVA: 0x7FFAF9468D90
    }

    public class XmlSchemaSubstitutionGroupV1Compat
    {
        // ── Methods ──
        public void get_Choice(){} // RVA: 0x7FFAF2E08730
        public void .ctor(){} // RVA: 0x7FFAF9468ED0
    }

    public class XmlSchemaTotalDigitsFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A600
    }

    public class XmlSchemaType
    {
        // ── Methods ──
        public void GetBuiltInSimpleType(){} // RVA: 0x7FFAF9469050 | overloaded x2
        public void GetBuiltInComplexType(){} // RVA: 0x7FFAF94690A0
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Name(){} // RVA: 0x7FFAF2EE54D0
        public void get_Final(){} // RVA: 0x7FFAF349AB90
        public void set_Final(){} // RVA: 0x7FFAF349AAE0
        public void get_QualifiedName(){} // RVA: 0x7FFAF9469220
        public void get_FinalResolved(){} // RVA: 0x7FFAF3B95CF0
        public void get_BaseXmlSchemaType(){} // RVA: 0x7FFAF2E2B370
        public void get_DerivedBy(){} // RVA: 0x7FFAF30554D0
        public void get_Datatype(){} // RVA: 0x7FFAF2E08D50
        public void get_IsMixed(){} // RVA: 0x7FFAF2D8D320
        public void set_IsMixed(){} // RVA: 0x7FFAF2D8D310
        public void get_TypeCode(){} // RVA: 0x7FFAF9469230
        public void get_ValueConverter(){} // RVA: 0x7FFAF94692F0
        public void get_SchemaContentType(){} // RVA: 0x7FFAF315FD40
        public void SetQualifiedName(){} // RVA: 0x7FFAF9469370
        public void SetFinalResolved(){} // RVA: 0x7FFAF2F25080
        public void SetBaseSchemaType(){} // RVA: 0x7FFAF2E2B380
        public void SetDerivedBy(){} // RVA: 0x7FFAF349ACA0
        public void SetDatatype(){} // RVA: 0x7FFAF2E08D60
        public void get_ElementDecl(){} // RVA: 0x7FFAF94693D0
        public void set_ElementDecl(){} // RVA: 0x7FFAF94693E0
        public void get_Redefined(){} // RVA: 0x7FFAF2DCC010
        public void set_Redefined(){} // RVA: 0x7FFAF2F13060
        public void SetContentType(){} // RVA: 0x7FFAF39B2F80
        public void IsDerivedFrom(){} // RVA: 0x7FFAF9469440
        public void IsDerivedFromDatatype(){} // RVA: 0x7FFAF94695D0
        public void get_NameAttribute(){} // RVA: 0x7FFAF2E2E0E0
        public void set_NameAttribute(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF94696B0
    }

    public class XmlSchemaUnique
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945AC90
    }

    public class XmlSchemaValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9469840 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFAF93EB290
    }

    public class XmlSchemaValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9469950
        public void Init(){} // RVA: 0x7FFAF9469CA0
        public void Reset(){} // RVA: 0x7FFAF946A5C0
        public void set_XmlResolver(){} // RVA: 0x7FFAF2E0E8A0
        public void set_LineInfoProvider(){} // RVA: 0x7FFAF946A6E0
        public void set_SourceUri(){} // RVA: 0x7FFAF946A7B0
        public void set_ValidationEventSender(){} // RVA: 0x7FFAF2DF80C0
        public void add_ValidationEventHandler(){} // RVA: 0x7FFAF946A8A0
        public void remove_ValidationEventHandler(){} // RVA: 0x7FFAF946A9A0
        public void AddSchema(){} // RVA: 0x7FFAF946AAA0
        public void Initialize(){} // RVA: 0x7FFAF946B030 | overloaded x2
        public void ValidateElement(){} // RVA: 0x7FFAF946B350
        public void ValidateAttribute(){} // RVA: 0x7FFAF946B9A0 | overloaded x2
        public void ValidateEndOfAttributes(){} // RVA: 0x7FFAF946C420
        public void ValidateText(){} // RVA: 0x7FFAF946C570 | overloaded x2
        public void ValidateWhitespace(){} // RVA: 0x7FFAF946CA50 | overloaded x2
        public void ValidateEndElement(){} // RVA: 0x7FFAF946CCE0
        public void SkipToEndElement(){} // RVA: 0x7FFAF946CCF0
        public void EndValidation(){} // RVA: 0x7FFAF946CF70
        public void GetUnspecifiedDefaultAttributes(){} // RVA: 0x7FFAF946D1F0
        public void get_SchemaSet(){} // RVA: 0x7FFAF2DA8380
        public void get_ValidationFlags(){} // RVA: 0x7FFAF306ED50
        public void get_CurrentContentType(){} // RVA: 0x7FFAF946D930
        public void SetDtdSchemaInfo(){} // RVA: 0x7FFAF946D970
        public void get_StrictlyAssessed(){} // RVA: 0x7FFAF946D9D0
        public void get_HasSchema(){} // RVA: 0x7FFAF946DA10
        public void GetConcatenatedValue(){} // RVA: 0x7FFAF946DA60
        public void InternalValidateEndElement(){} // RVA: 0x7FFAF946DA90
        public void ProcessSchemaLocations(){} // RVA: 0x7FFAF946E130
        public void ValidateElementContext(){} // RVA: 0x7FFAF946E480
        public void GetSubstitutionGroupHead(){} // RVA: 0x7FFAF946EA70
        public void ValidateAtomicValue(){} // RVA: 0x7FFAF946F080 | overloaded x2
        public void GetTypeName(){} // RVA: 0x7FFAF946F510
        public void SaveTextValue(){} // RVA: 0x7FFAF946F580
        public void Push(){} // RVA: 0x7FFAF946F5D0
        public void Pop(){} // RVA: 0x7FFAF946F9E0
        public void FastGetElementDecl(){} // RVA: 0x7FFAF946FBE0
        public void CheckXsiTypeAndNil(){} // RVA: 0x7FFAF946FF40
        public void ThrowDeclNotFoundWarningOrError(){} // RVA: 0x7FFAF94706C0
        public void CheckElementProperties(){} // RVA: 0x7FFAF9470920
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7FFAF9470A20
        public void CheckIsXmlAttribute(){} // RVA: 0x7FFAF9470A80
        public void AddXmlNamespaceSchema(){} // RVA: 0x7FFAF9470C10
        public void CheckMixedValueConstraint(){} // RVA: 0x7FFAF9470D00
        public void LoadSchema(){} // RVA: 0x7FFAF9470E30
        public void RecompileSchemaSet(){} // RVA: 0x7FFAF9471280
        public void ProcessTokenizedType(){} // RVA: 0x7FFAF9471340
        public void CheckAttributeValue(){} // RVA: 0x7FFAF9471620
        public void CheckElementValue(){} // RVA: 0x7FFAF94718F0
        public void CheckTokenizedTypes(){} // RVA: 0x7FFAF9471C30
        public void FindId(){} // RVA: 0x7FFAF9471DC0
        public void CheckForwardRefs(){} // RVA: 0x7FFAF9471DF0
        public void get_HasIdentityConstraints(){} // RVA: 0x7FFAF9471F80
        public void get_ProcessIdentityConstraints(){} // RVA: 0x7FFAF850FC10
        public void get_ReportValidationWarnings(){} // RVA: 0x7FFAF850F650
        public void get_ProcessSchemaHints(){} // RVA: 0x7FFAF9471FA0
        public void CheckStateTransition(){} // RVA: 0x7FFAF9471FC0
        public void ClearPSVI(){} // RVA: 0x7FFAF9472260
        public void CheckRequiredAttributes(){} // RVA: 0x7FFAF9472300
        public void GetSchemaElement(){} // RVA: 0x7FFAF94725D0
        public void GetDefaultAttributePrefix(){} // RVA: 0x7FFAF9472720
        public void AddIdentityConstraints(){} // RVA: 0x7FFAF94729D0
        public void ElementIdentityConstraints(){} // RVA: 0x7FFAF9472FC0
        public void AttributeIdentityConstraints(){} // RVA: 0x7FFAF9473370
        public void EndElementIdentityConstraints(){} // RVA: 0x7FFAF94736C0
        public void ElementValidationError(){} // RVA: 0x7FFAF9474500
        public void CompleteValidationError(){} // RVA: 0x7FFAF9474D10
        public void PrintExpectedElements(){} // RVA: 0x7FFAF9475260
        public void PrintNames(){} // RVA: 0x7FFAF94756E0
        public void PrintNamesWithNS(){} // RVA: 0x7FFAF9475880
        public void EnumerateAny(){} // RVA: 0x7FFAF9475EC0
        public void QNameString(){} // RVA: 0x7FFAF9476150
        public void BuildElementName(){} // RVA: 0x7FFAF9476230 | overloaded x2
        public void ProcessEntity(){} // RVA: 0x7FFAF94763A0
        public void SendValidationEvent(){} // RVA: 0x7FFAF9476E60 | overloaded x11
        public void .cctor(){} // RVA: 0x7FFAF9476F20
    }

    public class XmlSchemaWhiteSpaceFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF945A620
    }

    public class XmlSchemaXPath
    {
        // ── Methods ──
        public void get_XPath(){} // RVA: 0x7FFAF2E2E0E0
        public void set_XPath(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlStringConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF948BC00
        public void Create(){} // RVA: 0x7FFAF948BC60
        public void ToString(){} // RVA: 0x7FFAF948BCF0
        public void ChangeType(){} // RVA: 0x7FFAF948C1E0 | overloaded x2
    }

    public class XmlUnionConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9499FD0
        public void Create(){} // RVA: 0x7FFAF949A370
        public void ChangeType(){} // RVA: 0x7FFAF949A3D0
    }

    public class XmlUntypedConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF948C760 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFAF948C9F0 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFAF948CC90 | overloaded x2
        public void ToDateTimeOffset(){} // RVA: 0x7FFAF948CFA0 | overloaded x2
        public void ToDecimal(){} // RVA: 0x7FFAF948D2C0 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFAF948D5D0 | overloaded x2
        public void ToInt32(){} // RVA: 0x7FFAF948D880 | overloaded x2
        public void ToInt64(){} // RVA: 0x7FFAF948DB40 | overloaded x2
        public void ToSingle(){} // RVA: 0x7FFAF948DDF0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF948E420 | overloaded x9
        public void ChangeType(){} // RVA: 0x7FFAF9490E40 | overloaded x8
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7FFAF94926D0
        public void ChangeTypeWildcardSource(){} // RVA: 0x7FFAF9492830
        public void ChangeListType(){} // RVA: 0x7FFAF94929B0
        public void SupportsType(){} // RVA: 0x7FFAF9492D00
        public void .cctor(){} // RVA: 0x7FFAF9493280
    }

    public class XmlValueConverter
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0x7FFAF2ABDE40 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFAF2AC2590 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFAF2ABCE10 | overloaded x6
        public void ToDecimal(){} // overloaded x2
        public void ToDouble(){} // RVA: 0x7FFAF2AC2DE0 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFAF2AD1FA0 | overloaded x3
        public void ToDateTime(){} // overloaded x7
        public void ToDateTimeOffset(){} // overloaded x3
        public void ToString(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFAF2ACEE30 | overloaded x9
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlValueGetter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45B72F0
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
    }

    public class XsdBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF949A870
        public void ProcessElement(){} // RVA: 0x7FFAF949AED0
        public void ProcessAttribute(){} // RVA: 0x7FFAF949B1B0
        public void IsContentParsed(){} // RVA: 0x7FFAF949B7C0
        public void ProcessMarkup(){} // RVA: 0x7FFAF38370D0
        public void ProcessCData(){} // RVA: 0x7FFAF949B7E0
        public void StartChildren(){} // RVA: 0x7FFAF949B830
        public void EndChildren(){} // RVA: 0x7FFAF949BA70
        public void Push(){} // RVA: 0x7FFAF949BAC0
        public void Pop(){} // RVA: 0x7FFAF949BDF0
        public void get_CurrentElement(){} // RVA: 0x7FFAF86EB480
        public void get_ParentElement(){} // RVA: 0x7FFAF949BF50
        public void get_ParentContainer(){} // RVA: 0x7FFAF949BFE0
        public void GetContainer(){} // RVA: 0x7FFAF949C080
        public void SetContainer(){} // RVA: 0x7FFAF949C2D0
        public void BuildAnnotated_Id(){} // RVA: 0x7FFAF949DA50
        public void BuildSchema_AttributeFormDefault(){} // RVA: 0x7FFAF949DA80
        public void BuildSchema_ElementFormDefault(){} // RVA: 0x7FFAF949DB40
        public void BuildSchema_TargetNamespace(){} // RVA: 0x7FFAF949DC00
        public void BuildSchema_Version(){} // RVA: 0x7FFAF949DC70
        public void BuildSchema_FinalDefault(){} // RVA: 0x7FFAF949DCE0
        public void BuildSchema_BlockDefault(){} // RVA: 0x7FFAF949DD60
        public void InitSchema(){} // RVA: 0x7FFAF949DDE0
        public void InitInclude(){} // RVA: 0x7FFAF949DE50
        public void BuildInclude_SchemaLocation(){} // RVA: 0x7FFAF949DFE0
        public void InitImport(){} // RVA: 0x7FFAF949E050
        public void BuildImport_Namespace(){} // RVA: 0x7FFAF949E1E0
        public void BuildImport_SchemaLocation(){} // RVA: 0x7FFAF949E250
        public void InitRedefine(){} // RVA: 0x7FFAF949E2C0
        public void BuildRedefine_SchemaLocation(){} // RVA: 0x7FFAF949E450
        public void EndRedefine(){} // RVA: 0x7FFAF949E4C0
        public void InitAttribute(){} // RVA: 0x7FFAF949E4E0
        public void BuildAttribute_Default(){} // RVA: 0x7FFAF949E680
        public void BuildAttribute_Fixed(){} // RVA: 0x7FFAF949E6F0
        public void BuildAttribute_Form(){} // RVA: 0x7FFAF949E760
        public void BuildAttribute_Use(){} // RVA: 0x7FFAF949E820
        public void BuildAttribute_Ref(){} // RVA: 0x7FFAF949E8E0
        public void BuildAttribute_Name(){} // RVA: 0x7FFAF949EA20
        public void BuildAttribute_Type(){} // RVA: 0x7FFAF949EA90
        public void InitElement(){} // RVA: 0x7FFAF949EBD0
        public void BuildElement_Abstract(){} // RVA: 0x7FFAF949EDD0
        public void BuildElement_Block(){} // RVA: 0x7FFAF949EE50
        public void BuildElement_Default(){} // RVA: 0x7FFAF949EED0
        public void BuildElement_Form(){} // RVA: 0x7FFAF949EF40
        public void BuildElement_SubstitutionGroup(){} // RVA: 0x7FFAF949F000
        public void BuildElement_Final(){} // RVA: 0x7FFAF949F140
        public void BuildElement_Fixed(){} // RVA: 0x7FFAF949F1C0
        public void BuildElement_MaxOccurs(){} // RVA: 0x7FFAF949F230
        public void BuildElement_MinOccurs(){} // RVA: 0x7FFAF949F260
        public void BuildElement_Name(){} // RVA: 0x7FFAF949F290
        public void BuildElement_Nillable(){} // RVA: 0x7FFAF949F300
        public void BuildElement_Ref(){} // RVA: 0x7FFAF949F380
        public void BuildElement_Type(){} // RVA: 0x7FFAF949F4C0
        public void InitSimpleType(){} // RVA: 0x7FFAF949F600
        public void BuildSimpleType_Name(){} // RVA: 0x7FFAF949FB90
        public void BuildSimpleType_Final(){} // RVA: 0x7FFAF949FC00
        public void InitSimpleTypeUnion(){} // RVA: 0x7FFAF949FC80
        public void BuildSimpleTypeUnion_MemberTypes(){} // RVA: 0x7FFAF949FEE0
        public void InitSimpleTypeList(){} // RVA: 0x7FFAF94A00E0
        public void BuildSimpleTypeList_ItemType(){} // RVA: 0x7FFAF94A02A0
        public void InitSimpleTypeRestriction(){} // RVA: 0x7FFAF94A03E0
        public void BuildSimpleTypeRestriction_Base(){} // RVA: 0x7FFAF94A05A0
        public void InitComplexType(){} // RVA: 0x7FFAF94A06E0
        public void BuildComplexType_Abstract(){} // RVA: 0x7FFAF94A0970
        public void BuildComplexType_Block(){} // RVA: 0x7FFAF94A0A00
        public void BuildComplexType_Final(){} // RVA: 0x7FFAF94A0A80
        public void BuildComplexType_Mixed(){} // RVA: 0x7FFAF94A0B00
        public void BuildComplexType_Name(){} // RVA: 0x7FFAF94A0B90
        public void InitComplexContent(){} // RVA: 0x7FFAF94A0C00
        public void BuildComplexContent_Mixed(){} // RVA: 0x7FFAF94A0E20
        public void InitComplexContentExtension(){} // RVA: 0x7FFAF94A0EA0
        public void BuildComplexContentExtension_Base(){} // RVA: 0x7FFAF94A1160
        public void InitComplexContentRestriction(){} // RVA: 0x7FFAF94A12A0
        public void BuildComplexContentRestriction_Base(){} // RVA: 0x7FFAF94A1500
        public void InitSimpleContent(){} // RVA: 0x7FFAF94A1640
        public void InitSimpleContentExtension(){} // RVA: 0x7FFAF94A1860
        public void BuildSimpleContentExtension_Base(){} // RVA: 0x7FFAF94A1A00
        public void InitSimpleContentRestriction(){} // RVA: 0x7FFAF94A1B40
        public void BuildSimpleContentRestriction_Base(){} // RVA: 0x7FFAF94A1E80
        public void InitAttributeGroup(){} // RVA: 0x7FFAF94A1FC0
        public void BuildAttributeGroup_Name(){} // RVA: 0x7FFAF94A2160
        public void InitAttributeGroupRef(){} // RVA: 0x7FFAF94A21D0
        public void BuildAttributeGroupRef_Ref(){} // RVA: 0x7FFAF94A2380
        public void InitAnyAttribute(){} // RVA: 0x7FFAF94A24C0
        public void BuildAnyAttribute_Namespace(){} // RVA: 0x7FFAF94A2A50
        public void BuildAnyAttribute_ProcessContents(){} // RVA: 0x7FFAF94A2AC0
        public void InitGroup(){} // RVA: 0x7FFAF94A2B80
        public void BuildGroup_Name(){} // RVA: 0x7FFAF94A2DA0
        public void InitGroupRef(){} // RVA: 0x7FFAF94A2E10
        public void BuildParticle_MaxOccurs(){} // RVA: 0x7FFAF94A3050
        public void BuildParticle_MinOccurs(){} // RVA: 0x7FFAF94A3080
        public void BuildGroupRef_Ref(){} // RVA: 0x7FFAF94A30B0
        public void InitAll(){} // RVA: 0x7FFAF94A31F0
        public void InitChoice(){} // RVA: 0x7FFAF94A3360
        public void InitSequence(){} // RVA: 0x7FFAF94A34D0
        public void InitAny(){} // RVA: 0x7FFAF94A3640
        public void BuildAny_Namespace(){} // RVA: 0x7FFAF94A37F0
        public void BuildAny_ProcessContents(){} // RVA: 0x7FFAF94A3860
        public void InitNotation(){} // RVA: 0x7FFAF94A3920
        public void BuildNotation_Name(){} // RVA: 0x7FFAF94A3B10
        public void BuildNotation_Public(){} // RVA: 0x7FFAF94A3B80
        public void BuildNotation_System(){} // RVA: 0x7FFAF94A3BF0
        public void InitFacet(){} // RVA: 0x7FFAF94A3C60
        public void BuildFacet_Fixed(){} // RVA: 0x7FFAF94A4050
        public void BuildFacet_Value(){} // RVA: 0x7FFAF94A40E0
        public void InitIdentityConstraint(){} // RVA: 0x7FFAF94A4150
        public void BuildIdentityConstraint_Name(){} // RVA: 0x7FFAF94A45C0
        public void BuildIdentityConstraint_Refer(){} // RVA: 0x7FFAF94A4630
        public void InitSelector(){} // RVA: 0x7FFAF94A4830
        public void BuildSelector_XPath(){} // RVA: 0x7FFAF94A49F0
        public void InitField(){} // RVA: 0x7FFAF94A4A60
        public void BuildField_XPath(){} // RVA: 0x7FFAF94A49F0
        public void InitAnnotation(){} // RVA: 0x7FFAF94A4C00
        public void InitAppinfo(){} // RVA: 0x7FFAF94A4E20
        public void BuildAppinfo_Source(){} // RVA: 0x7FFAF94A5030
        public void EndAppinfo(){} // RVA: 0x7FFAF94A50F0
        public void InitDocumentation(){} // RVA: 0x7FFAF94A5160
        public void BuildDocumentation_Source(){} // RVA: 0x7FFAF94A5370
        public void BuildDocumentation_XmlLang(){} // RVA: 0x7FFAF94A5430
        public void EndDocumentation(){} // RVA: 0x7FFAF94A5670
        public void AddAttribute(){} // RVA: 0x7FFAF94A56E0
        public void AddParticle(){} // RVA: 0x7FFAF94A5980
        public void GetNextState(){} // RVA: 0x7FFAF94A5DD0
        public void IsSkipableElement(){} // RVA: 0x7FFAF94A5FA0
        public void SetMinOccurs(){} // RVA: 0x7FFAF94A5FD0
        public void SetMaxOccurs(){} // RVA: 0x7FFAF94A6030
        public void ParseBoolean(){} // RVA: 0x7FFAF94A6090
        public void ParseEnum(){} // RVA: 0x7FFAF94A6130
        public void ParseQName(){} // RVA: 0x7FFAF94A6250
        public void ParseBlockFinalEnum(){} // RVA: 0x7FFAF94A64A0
        public void ParseUriReference(){} // RVA: 0x7FFAF44EF520
        public void SendValidationEvent(){} // RVA: 0x7FFAF94A6C70 | overloaded x5
        public void RecordPosition(){} // RVA: 0x7FFAF94A6C80
        public void .cctor(){} // RVA: 0x7FFAF94A6E00
    }

    public class XsdDateTime
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94AD750 | overloaded x5
        public void InitiateXsdDateTime(){} // RVA: 0x7FFAF94AD150
        public void TryParse(){} // RVA: 0x7FFAF94AD290
        public void get_InternalTypeCode(){} // RVA: 0x7FFAF94AD9E0
        public void get_InternalKind(){} // RVA: 0x7FFAF881FE70
        public void get_Year(){} // RVA: 0x7FFAF94AD9F0
        public void get_Month(){} // RVA: 0x7FFAF94ADA80
        public void get_Day(){} // RVA: 0x7FFAF94ADB10
        public void get_Hour(){} // RVA: 0x7FFAF94ADBA0
        public void get_Minute(){} // RVA: 0x7FFAF94ADBF0
        public void get_Second(){} // RVA: 0x7FFAF94ADC40
        public void get_Fraction(){} // RVA: 0x7FFAF94ADC90
        public void get_ZoneHour(){} // RVA: 0x7FFAF45B6E00
        public void get_ZoneMinute(){} // RVA: 0x7FFAF45B6CA0
        public void op_Implicit(){} // RVA: 0x7FFAF94AE780 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF94AECD0
        public void PrintDate(){} // RVA: 0x7FFAF94AF2D0
        public void PrintTime(){} // RVA: 0x7FFAF94AF570
        public void PrintZone(){} // RVA: 0x7FFAF94AF9D0
        public void IntToCharArray(){} // RVA: 0x7FFAF94AFD30
        public void ShortToCharArray(){} // RVA: 0x7FFAF94AFDD0
        public void .cctor(){} // RVA: 0x7FFAF94AFE50
    }

    public class XsdDuration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94B2820 | overloaded x5
        public void get_IsNegative(){} // RVA: 0x7FFAF94B28D0
        public void get_Years(){} // RVA: 0x7FFAF44189B0
        public void get_Months(){} // RVA: 0x7FFAF44189E0
        public void get_Days(){} // RVA: 0x7FFAF4959890
        public void get_Hours(){} // RVA: 0x7FFAF49598B0
        public void get_Minutes(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Seconds(){} // RVA: 0x7FFAF335BED0
        public void get_Nanoseconds(){} // RVA: 0x7FFAF94B28E0
        public void ToTimeSpan(){} // RVA: 0x7FFAF94B2940 | overloaded x2
        public void TryToTimeSpan(){} // RVA: 0x7FFAF94B29A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF94B2FD0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFAF94B3490 | overloaded x2
        public void TryParseDigits(){} // RVA: 0x7FFAF94B4050
    }

    public class XsdSimpleValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_XmlType(){} // RVA: 0x7FFAF2DA8380
        public void get_TypedValue(){} // RVA: 0x7FFAF2D907C0
    }

    public class XsdValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94B41D0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF94B4200
        public void Validate(){} // RVA: 0x7FFAF94B4A40
        public void CompleteValidation(){} // RVA: 0x7FFAF94B4B20
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7FFAF9449EB0
        public void ProcessInlineSchema(){} // RVA: 0x7FFAF94B4CC0
        public void ValidateElement(){} // RVA: 0x7FFAF94B4F90
        public void ValidateChildElement(){} // RVA: 0x7FFAF94B51A0
        public void ProcessElement(){} // RVA: 0x7FFAF94B5420
        public void ProcessXsiAttributes(){} // RVA: 0x7FFAF94B5870
        public void ValidateEndElement(){} // RVA: 0x7FFAF94B61A0
        public void FastGetElementDecl(){} // RVA: 0x7FFAF94B6400
        public void ThoroughGetElementDecl(){} // RVA: 0x7FFAF94B64F0
        public void ValidateStartElement(){} // RVA: 0x7FFAF94B6A30
        public void ValidateEndStartElement(){} // RVA: 0x7FFAF94B73B0
        public void LoadSchemaFromLocation(){} // RVA: 0x7FFAF94B7810
        public void LoadSchema(){} // RVA: 0x7FFAF94B7E10
        public void get_HasSchema(){} // RVA: 0x7FFAF944BC20
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAF944BC40
        public void ProcessTokenizedType(){} // RVA: 0x7FFAF94B8000
        public void CheckValue(){} // RVA: 0x7FFAF94B8300
        public void AddID(){} // RVA: 0x7FFAF94B88B0
        public void FindId(){} // RVA: 0x7FFAF944CED0
        public void IsXSDRoot(){} // RVA: 0x7FFAF94B89B0
        public void Push(){} // RVA: 0x7FFAF94B89D0
        public void Pop(){} // RVA: 0x7FFAF94B8D40
        public void CheckForwardRefs(){} // RVA: 0x7FFAF94B4B20
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7FFAF94B8EC0
        public void get_HasIdentityConstraints(){} // RVA: 0x7FFAF94B8F20
        public void AddIdentityConstraints(){} // RVA: 0x7FFAF94B8F30
        public void ElementIdentityConstraints(){} // RVA: 0x7FFAF94B9590
        public void AttributeIdentityConstraints(){} // RVA: 0x7FFAF94B99D0
        public void UnWrapUnion(){} // RVA: 0x7FFAF94B9D60
        public void EndElementIdentityConstraints(){} // RVA: 0x7FFAF94B9DE0
        public void .cctor(){} // RVA: 0x7FFAF94BAC00
    }

}