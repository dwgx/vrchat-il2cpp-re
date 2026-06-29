// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 97
// Methods: 1276

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XdrBuilder : SchemaBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE77CE90
        public void ProcessElement(){} // RVA: 0x7AE77D5B0
        public void ProcessAttribute(){} // RVA: 0x7AE77D880
        public void set_XmlResolver(){} // RVA: 0x7A8142700
        public void LoadSchema(){} // RVA: 0x7AE77DE20
        public void IsXdrSchema(){} // RVA: 0x7AE77E370
        public void IsContentParsed(){} // RVA: 0x7A81BD750
        public void ProcessMarkup(){} // RVA: 0x7AE77E6A0
        public void ProcessCData(){} // RVA: 0x7AE77E700
        public void StartChildren(){} // RVA: 0x7AE77E7D0
        public void EndChildren(){} // RVA: 0x7AE77E810
        public void Push(){} // RVA: 0x7AE77E950
        public void Pop(){} // RVA: 0x7AE77E9E0
        public void PushGroupInfo(){} // RVA: 0x7AE77EB00
        public void PopGroupInfo(){} // RVA: 0x7AE77EBB0
        public void XDR_InitRoot(){} // RVA: 0x7AE77ECD0
        public void XDR_BuildRoot_Name(){} // RVA: 0x7AE77EE30
        public void XDR_BuildRoot_ID(){} // RVA: 0x7A80D7310
        public void XDR_BeginRoot(){} // RVA: 0x7AE77EF90
        public void XDR_EndRoot(){} // RVA: 0x7AE77F160
        public void XDR_InitElementType(){} // RVA: 0x7AE77F670
        public void XDR_BuildElementType_Name(){} // RVA: 0x7AE77F930
        public void XDR_BuildElementType_Content(){} // RVA: 0x7AE77FC50
        public void XDR_BuildElementType_Model(){} // RVA: 0x7AE77FD00
        public void XDR_BuildElementType_Order(){} // RVA: 0x7AE77FE90
        public void XDR_BuildElementType_DtType(){} // RVA: 0x7AE77FF50
        public void XDR_BuildElementType_DtValues(){} // RVA: 0x7AE780120
        public void XDR_BuildElementType_DtMaxLength(){} // RVA: 0x7AE780270
        public void XDR_BuildElementType_DtMinLength(){} // RVA: 0x7AE7802F0
        public void XDR_BeginElementType(){} // RVA: 0x7AE780370
        public void XDR_EndElementType(){} // RVA: 0x7AE780710
        public void XDR_InitAttributeType(){} // RVA: 0x7AE780E50
        public void XDR_BuildAttributeType_Name(){} // RVA: 0x7AE781050
        public void XDR_BuildAttributeType_Required(){} // RVA: 0x7AE7814B0
        public void XDR_BuildAttributeType_Default(){} // RVA: 0x7AE781530
        public void XDR_BuildAttributeType_DtType(){} // RVA: 0x7AE7815A0
        public void XDR_BuildAttributeType_DtValues(){} // RVA: 0x7AE781810
        public void XDR_BuildAttributeType_DtMaxLength(){} // RVA: 0x7AE781960
        public void XDR_BuildAttributeType_DtMinLength(){} // RVA: 0x7AE7819E0
        public void XDR_BeginAttributeType(){} // RVA: 0x7AE781A60
        public void XDR_EndAttributeType(){} // RVA: 0x7AE781B20
        public void XDR_InitElement(){} // RVA: 0x7AE781F60
        public void XDR_BuildElement_Type(){} // RVA: 0x7AE782050
        public void XDR_BuildElement_MinOccurs(){} // RVA: 0x7AE782240
        public void XDR_BuildElement_MaxOccurs(){} // RVA: 0x7AE7822C0
        public void XDR_EndElement(){} // RVA: 0x7AE782340
        public void XDR_InitAttribute(){} // RVA: 0x7AE782480
        public void XDR_BuildAttribute_Type(){} // RVA: 0x7AE782550
        public void XDR_BuildAttribute_Required(){} // RVA: 0x7AE782700
        public void XDR_BuildAttribute_Default(){} // RVA: 0x7AE782790
        public void XDR_BeginAttribute(){} // RVA: 0x7AE782800
        public void XDR_EndAttribute(){} // RVA: 0x7AE782EA0
        public void XDR_InitGroup(){} // RVA: 0x7AE782ED0
        public void XDR_BuildGroup_Order(){} // RVA: 0x7AE7830B0
        public void XDR_BuildGroup_MinOccurs(){} // RVA: 0x7AE7831A0
        public void XDR_BuildGroup_MaxOccurs(){} // RVA: 0x7AE783230
        public void XDR_EndGroup(){} // RVA: 0x7AE7832C0
        public void XDR_InitElementDtType(){} // RVA: 0x7AE783590
        public void XDR_EndElementDtType(){} // RVA: 0x7AE7836A0
        public void XDR_InitAttributeDtType(){} // RVA: 0x7AE783870
        public void XDR_EndAttributeDtType(){} // RVA: 0x7AE783910
        public void GetNextState(){} // RVA: 0x7AE783A40
        public void IsSkipableElement(){} // RVA: 0x7AE783C30
        public void IsSkipableAttribute(){} // RVA: 0x7AE783D30
        public void GetOrder(){} // RVA: 0x7AE783EA0
        public void AddOrder(){} // RVA: 0x7AE784060
        public void IsYes(){} // RVA: 0x7AE784120
        public void ParseMinOccurs(){} // RVA: 0x7AE7842A0
        public void ParseMaxOccurs(){} // RVA: 0x7AE7843E0
        public void HandleMinMax(){} // RVA: 0x7AE784540
        public void ParseDtMaxLength(){} // RVA: 0x7AE784570
        public void ParseDtMinLength(){} // RVA: 0x7AE7846F0
        public void CompareMinMaxLength(){} // RVA: 0x7AE784870
        public void ParseInteger(){} // RVA: 0x7AE7848F0
        public void XDR_CheckAttributeDefault(){} // RVA: 0x7AE784930
        public void SetAttributePresence(){} // RVA: 0x7AE784A40
        public void GetContent(){} // RVA: 0x7AE784A90
        public void GetModel(){} // RVA: 0x7AE784CA0
        public void CheckDatatype(){} // RVA: 0x7AE784DC0
        public void CheckDefaultAttValue(){} // RVA: 0x7AE784F50
        public void IsGlobal(){} // RVA: 0x7AE7850C0
        public void SendValidationEvent(){} // RVA: 0x7AE785390
        public void .cctor(){} // RVA: 0x7AE785470
    }

    public class XdrValidator : BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE787BC0
        public void Init(){} // RVA: 0x7AE787CC0
        public void Validate(){} // RVA: 0x7AE7880F0
        public void ValidateElement(){} // RVA: 0x7AE7881D0
        public void ValidateChildElement(){} // RVA: 0x7AE788710
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7AE7888D0
        public void ProcessInlineSchema(){} // RVA: 0x7AE7888E0
        public void ProcessElement(){} // RVA: 0x7AE788C40
        public void ValidateEndElement(){} // RVA: 0x7AE788D60
        public void ThoroughGetElementDecl(){} // RVA: 0x7AE789120
        public void ValidateStartElement(){} // RVA: 0x7AE789550
        public void ValidateEndStartElement(){} // RVA: 0x7AE789A80
        public void LoadSchemaFromLocation(){} // RVA: 0x7AE789E40
        public void LoadSchema(){} // RVA: 0x7AE78A4A0
        public void get_HasSchema(){} // RVA: 0x7AE78A660
        public void get_PreserveWhitespace(){} // RVA: 0x7AE78A680
        public void ProcessTokenizedType(){} // RVA: 0x7AE78A6D0
        public void CompleteValidation(){} // RVA: 0x7AE78A9D0
        public void CheckValue(){} // RVA: 0x7AE78AC50
        public void CheckDefaultValue(){} // RVA: 0x7AE78B320
        public void AddID(){} // RVA: 0x7AE78B800
        public void FindId(){} // RVA: 0x7AE78B900
        public void Push(){} // RVA: 0x7AE78B930
        public void Pop(){} // RVA: 0x7AE78BC20
        public void CheckForwardRefs(){} // RVA: 0x7AE78BD60
        public void QualifiedName(){} // RVA: 0x7AE78BF00
    }

    public class XmlAnyConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7D2ED0
        public void ToBoolean(){} // RVA: 0x7AE7D30D0
        public void ToDateTime(){} // RVA: 0x7AE7D32C0
        public void ToDateTimeOffset(){} // RVA: 0x7AE7D34B0
        public void ToDecimal(){} // RVA: 0x7AE7D3700
        public void ToDouble(){} // RVA: 0x7AE7D3950
        public void ToInt32(){} // RVA: 0x7AE7D3B40
        public void ToInt64(){} // RVA: 0x7AE7D3D30
        public void ToSingle(){} // RVA: 0x7AE7D3F20
        public void ChangeType(){} // RVA: 0x7AE7D5370
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7AE7D7280
        public void ChangeTypeWildcardSource(){} // RVA: 0x7AE7D73E0
        public void ToNavigator(){} // RVA: 0x7AE7D7560
        public void .cctor(){} // RVA: 0x7AE7D7600
    }

    public class XmlAnyListConverter : XmlListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7D77E0
        public void ChangeType(){} // RVA: 0x7AE7D77F0
        public void .cctor(){} // RVA: 0x7AE7D7A80
    }

    public class XmlAtomicValue : XPathItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE78C9B0
        public void System.ICloneable.Clone(){} // RVA: 0x7A97F8BA0
        public void get_XmlType(){} // RVA: 0x7A80F2570
        public void get_ValueType(){} // RVA: 0x7AE78CC80
        public void get_TypedValue(){} // RVA: 0x7AE78CCC0
        public void get_ValueAsBoolean(){} // RVA: 0x7AE78CED0
        public void get_ValueAsDateTime(){} // RVA: 0x7AE78CFE0
        public void get_ValueAsDouble(){} // RVA: 0x7AE78D0F0
        public void get_ValueAsInt(){} // RVA: 0x7AE78D200
        public void get_ValueAsLong(){} // RVA: 0x7AE78D310
        public void ValueAs(){} // RVA: 0x7AE78D420
        public void get_Value(){} // RVA: 0x7AE78D690
        public void ToString(){} // RVA: 0x7A818C720
        public void GetPrefixFromQName(){} // RVA: 0x7AE78D7D0
    }

    public class XmlBaseConverter : XmlValueConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7B6520
        public void ToBoolean(){} // RVA: 0x7AE7B6AF0
        public void ToDateTime(){} // RVA: 0x7AE7B71A0
        public void ToDateTimeOffset(){} // RVA: 0x7AE7B7460
        public void ToDecimal(){} // RVA: 0x7AE7B7620
        public void ToDouble(){} // RVA: 0x7AE7B7BD0
        public void ToInt32(){} // RVA: 0x7AE7B8170
        public void ToInt64(){} // RVA: 0x7AE7B8710
        public void ToSingle(){} // RVA: 0x7AE7B89C0
        public void ToString(){} // RVA: 0x7AE7B9300
        public void ChangeType(){} // RVA: 0x7AE7B96A0
        public void get_SchemaType(){} // RVA: 0x7A80F2570
        public void get_TypeCode(){} // RVA: 0x7A83782A0
        public void get_XmlTypeName(){} // RVA: 0x7AE7B96D0
        public void get_DefaultClrType(){} // RVA: 0x7A81052C0
        public void IsDerivedFrom(){} // RVA: 0x7AE7B97E0
        public void CreateInvalidClrMappingException(){} // RVA: 0x7AE7B9890
        public void QNameToString(){} // RVA: 0x7AE7BB870
        public void ChangeListType(){} // RVA: 0x7AE7B9D00
        public void StringToBase64Binary(){} // RVA: 0x7AE7B9D60
        public void StringToDate(){} // RVA: 0x7AE7B9E80
        public void StringToDateTime(){} // RVA: 0x7AE7B9F00
        public void StringToDayTimeDuration(){} // RVA: 0x7AE7B9F80
        public void StringToDuration(){} // RVA: 0x7AE7BA080
        public void StringToGDay(){} // RVA: 0x7AE7BA180
        public void StringToGMonth(){} // RVA: 0x7AE7BA200
        public void StringToGMonthDay(){} // RVA: 0x7AE7BA280
        public void StringToGYear(){} // RVA: 0x7AE7BA300
        public void StringToGYearMonth(){} // RVA: 0x7AE7BA380
        public void StringToDateOffset(){} // RVA: 0x7AE7BA400
        public void StringToDateTimeOffset(){} // RVA: 0x7AE7BA4A0
        public void StringToGDayOffset(){} // RVA: 0x7AE7BA540
        public void StringToGMonthOffset(){} // RVA: 0x7AE7BA5E0
        public void StringToGMonthDayOffset(){} // RVA: 0x7AE7BA680
        public void StringToGYearOffset(){} // RVA: 0x7AE7BA720
        public void StringToGYearMonthOffset(){} // RVA: 0x7AE7BA7C0
        public void StringToHexBinary(){} // RVA: 0x7AE7BA860
        public void StringToQName(){} // RVA: 0x7AE7BA990
        public void StringToTime(){} // RVA: 0x7AE7BAC90
        public void StringToTimeOffset(){} // RVA: 0x7AE7BAD10
        public void StringToYearMonthDuration(){} // RVA: 0x7AE7BADB0
        public void AnyUriToString(){} // RVA: 0x7AE7BAEB0
        public void Base64BinaryToString(){} // RVA: 0x7AE7BAF20
        public void DateToString(){} // RVA: 0x7AE7BB030
        public void DateTimeToString(){} // RVA: 0x7AE7BB0B0
        public void DayTimeDurationToString(){} // RVA: 0x7AE7BB130
        public void DurationToString(){} // RVA: 0x7AE7BB1A0
        public void GDayToString(){} // RVA: 0x7AE7BB200
        public void GMonthToString(){} // RVA: 0x7AE7BB280
        public void GMonthDayToString(){} // RVA: 0x7AE7BB300
        public void GYearToString(){} // RVA: 0x7AE7BB380
        public void GYearMonthToString(){} // RVA: 0x7AE7BB400
        public void DateOffsetToString(){} // RVA: 0x7AE7BB480
        public void DateTimeOffsetToString(){} // RVA: 0x7AE7BB510
        public void GDayOffsetToString(){} // RVA: 0x7AE7BB5A0
        public void GMonthOffsetToString(){} // RVA: 0x7AE7BB630
        public void GMonthDayOffsetToString(){} // RVA: 0x7AE7BB6C0
        public void GYearOffsetToString(){} // RVA: 0x7AE7BB750
        public void GYearMonthOffsetToString(){} // RVA: 0x7AE7BB7E0
        public void TimeToString(){} // RVA: 0x7AE7BBA60
        public void TimeOffsetToString(){} // RVA: 0x7AE7BBAE0
        public void YearMonthDurationToString(){} // RVA: 0x7AE7BBB70
        public void DateTimeOffsetToDateTime(){} // RVA: 0x7AE7BBBE0
        public void DecimalToInt32(){} // RVA: 0x7AE7BBC30
        public void DecimalToInt64(){} // RVA: 0x7AE7BBEB0
        public void DecimalToUInt64(){} // RVA: 0x7AE7BC140
        public void Int32ToByte(){} // RVA: 0x7AE7BC3C0
        public void Int32ToInt16(){} // RVA: 0x7AE7BC4C0
        public void Int32ToSByte(){} // RVA: 0x7AE7BC5C0
        public void Int32ToUInt16(){} // RVA: 0x7AE7BC6C0
        public void Int64ToInt32(){} // RVA: 0x7AE7BC7C0
        public void Int64ToUInt32(){} // RVA: 0x7AE7BC8C0
        public void UntypedAtomicToDateTime(){} // RVA: 0x7AE7BC9C0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x7AE7BCA40
        public void .cctor(){} // RVA: 0x7AE7BCAE0
    }

    public class XmlBooleanConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7C7B40
        public void Create(){} // RVA: 0x7AE7C7BA0
        public void ToBoolean(){} // RVA: 0x7AE7C7CD0
        public void ToString(){} // RVA: 0x7AE7C8070
        public void ChangeType(){} // RVA: 0x7AE7C8B40
    }

    public class XmlDateTimeConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7C5050
        public void Create(){} // RVA: 0x7AE7C50B0
        public void ToDateTime(){} // RVA: 0x7AE7C54F0
        public void ToDateTimeOffset(){} // RVA: 0x7AE7C5C00
        public void ToString(){} // RVA: 0x7AE7C6590
        public void ChangeType(){} // RVA: 0x7AE7C71C0
    }

    public class XmlListConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7D7FD0
        public void Create(){} // RVA: 0x7AE7D8030
        public void ChangeType(){} // RVA: 0x7AE7D8210
        public void ChangeListType(){} // RVA: 0x7AE7D8340
        public void IsListType(){} // RVA: 0x7AE7D9270
        public void ToArray(){} // RVA: 0x7A7E00BD0
        public void ToList(){} // RVA: 0x7AE7D9400
        public void StringAsList(){} // RVA: 0x7AE7D9980
        public void ListAsString(){} // RVA: 0x7AE7D9A30
        public void CreateInvalidClrMappingException(){} // RVA: 0x7AE7D9CE0
    }

    public class XmlMiscConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7C92F0
        public void Create(){} // RVA: 0x7AE7C9350
        public void ToString(){} // RVA: 0x7AE7C93E0
        public void ChangeType(){} // RVA: 0x7AE7CA290
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7AE7CB3D0
        public void ChangeTypeWildcardSource(){} // RVA: 0x7AE7CB530
    }

    public class XmlNumeric10Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7BE490
        public void Create(){} // RVA: 0x7AE7BE4F0
        public void ToDecimal(){} // RVA: 0x7AE7BE700
        public void ToInt32(){} // RVA: 0x7AE7BEDC0
        public void ToInt64(){} // RVA: 0x7AE7BF380
        public void ToString(){} // RVA: 0x7AE7BFB50
        public void ChangeType(){} // RVA: 0x7AE7C1370
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7AE7C26F0
        public void ChangeTypeWildcardSource(){} // RVA: 0x7AE7C2B40
    }

    public class XmlNumeric2Converter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7C2FE0
        public void Create(){} // RVA: 0x7AE7C3040
        public void ToDouble(){} // RVA: 0x7AE7C31B0
        public void ToSingle(){} // RVA: 0x7AE7C3630
        public void ToString(){} // RVA: 0x7AE7C3B50
        public void ChangeType(){} // RVA: 0x7AE7C4750
    }

    public class XmlSchema : XmlSchemaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE78DB50
        public void Read(){} // RVA: 0x7AE78DFD0
        public void CompileSchema(){} // RVA: 0x7AE78E170
        public void CompileSchemaInSet(){} // RVA: 0x7AE78E5C0
        public void get_AttributeFormDefault(){} // RVA: 0x7A8D863F0
        public void set_AttributeFormDefault(){} // RVA: 0x7A8D870E0
        public void get_BlockDefault(){} // RVA: 0x7A8178B30
        public void set_BlockDefault(){} // RVA: 0x7A8178B40
        public void get_FinalDefault(){} // RVA: 0x7A8178B50
        public void set_FinalDefault(){} // RVA: 0x7A8178B60
        public void get_ElementFormDefault(){} // RVA: 0x7A864E8D0
        public void set_ElementFormDefault(){} // RVA: 0x7A9ABBD00
        public void get_TargetNamespace(){} // RVA: 0x7A8152D80
        public void set_TargetNamespace(){} // RVA: 0x7A8152D90
        public void get_Version(){} // RVA: 0x7A8178B90
        public void set_Version(){} // RVA: 0x7A8230620
        public void get_Includes(){} // RVA: 0x7A81A0050
        public void get_Items(){} // RVA: 0x7A8175DF0
        public void get_IsCompiledBySet(){} // RVA: 0x7A8663F60
        public void set_IsCompiledBySet(){} // RVA: 0x7A8665190
        public void get_IsPreprocessed(){} // RVA: 0x7A865FC40
        public void set_IsPreprocessed(){} // RVA: 0x7A8665180
        public void get_IsRedefined(){} // RVA: 0x7A8663F50
        public void set_IsRedefined(){} // RVA: 0x7A865FE50
        public void get_Attributes(){} // RVA: 0x7AE78E680
        public void get_AttributeGroups(){} // RVA: 0x7AE78E740
        public void get_SchemaTypes(){} // RVA: 0x7AE78E800
        public void get_Elements(){} // RVA: 0x7AE78E8C0
        public void get_Id(){} // RVA: 0x7A8153390
        public void set_Id(){} // RVA: 0x7A81533A0
        public void get_Groups(){} // RVA: 0x7A87C5850
        public void get_Notations(){} // RVA: 0x7A87D9480
        public void get_IdentityConstraints(){} // RVA: 0x7A8142610
        public void get_BaseUri(){} // RVA: 0x7A81F50F0
        public void set_BaseUri(){} // RVA: 0x7A81F5100
        public void get_SchemaId(){} // RVA: 0x7AE78E980
        public void get_IsChameleon(){} // RVA: 0x7A90B4C50
        public void set_IsChameleon(){} // RVA: 0x7ADF1BE00
        public void get_Ids(){} // RVA: 0x7A8158F50
        public void get_Document(){} // RVA: 0x7AE78EA00
        public void get_ErrorCount(){} // RVA: 0x7A98A0C40
        public void set_ErrorCount(){} // RVA: 0x7AE034E90
        public void Clone(){} // RVA: 0x7AE78EAC0
        public void DeepClone(){} // RVA: 0x7AE78ED60
        public void get_IdAttribute(){} // RVA: 0x7A8153390
        public void set_IdAttribute(){} // RVA: 0x7A81533A0
        public void SetIsCompiled(){} // RVA: 0x7A9442C00
        public void SetUnhandledAttributes(){} // RVA: 0x7A81A00F0
        public void AddAnnotation(){} // RVA: 0x7AE78F2E0
        public void get_ImportedSchemas(){} // RVA: 0x7AE78F340
        public void get_ImportedNamespaces(){} // RVA: 0x7AE78F400
        public void GetExternalSchemasList(){} // RVA: 0x7AE78F4C0
        public void .cctor(){} // RVA: 0x7AE78F640
    }

    public class XmlSchemaAll : XmlSchemaGroupBase
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7A82C2060
        public void get_IsEmpty(){} // RVA: 0x7AE78F680
        public void SetItems(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7AE78F6E0
    }

    public class XmlSchemaAnnotated : XmlSchemaObject
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A8292C30
        public void set_Id(){} // RVA: 0x7A8296DE0
        public void get_Annotation(){} // RVA: 0x7A8154D80
        public void set_Annotation(){} // RVA: 0x7A80FF440
        public void get_UnhandledAttributes(){} // RVA: 0x7A8152D80
        public void set_UnhandledAttributes(){} // RVA: 0x7A8152D90
        public void get_IdAttribute(){} // RVA: 0x7A8292C30
        public void set_IdAttribute(){} // RVA: 0x7A8296DE0
        public void SetUnhandledAttributes(){} // RVA: 0x7A8152D90
        public void AddAnnotation(){} // RVA: 0x7A80FF440
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaAnnotation : XmlSchemaObject
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A8292C30
        public void set_Id(){} // RVA: 0x7A8296DE0
        public void get_Items(){} // RVA: 0x7A8154D80
        public void get_IdAttribute(){} // RVA: 0x7A8292C30
        public void set_IdAttribute(){} // RVA: 0x7A8296DE0
        public void SetUnhandledAttributes(){} // RVA: 0x7A8152D90
        public void .ctor(){} // RVA: 0x7AE78F7C0
    }

    public class XmlSchemaAny : XmlSchemaParticle
    {
        // ── Methods ──
        public void get_Namespace(){} // RVA: 0x7A82C2060
        public void set_Namespace(){} // RVA: 0x7A82C0530
        public void set_ProcessContents(){} // RVA: 0x7A8D6DF20
        public void get_NamespaceList(){} // RVA: 0x7A81163D0
        public void get_ResolvedNamespace(){} // RVA: 0x7AE78F860
        public void get_ProcessContentsCorrect(){} // RVA: 0x7AE78F8B0
        public void get_NameString(){} // RVA: 0x7AE78F8D0
        public void BuildNamespaceList(){} // RVA: 0x7AE78FD20
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7AE78FE80
        public void Allows(){} // RVA: 0x7AE78FFF0
        public void .ctor(){} // RVA: 0x7AE790030
    }

    public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void set_Namespace(){} // RVA: 0x7A8230620
        public void get_ProcessContents(){} // RVA: 0x7A87A7DA0
        public void set_ProcessContents(){} // RVA: 0x7A87A7CF0
        public void get_NamespaceList(){} // RVA: 0x7A8175DF0
        public void get_ProcessContentsCorrect(){} // RVA: 0x7AE790080
        public void BuildNamespaceList(){} // RVA: 0x7AE790090
        public void BuildNamespaceListV1Compat(){} // RVA: 0x7AE7901D0
        public void Allows(){} // RVA: 0x7AE790330
        public void IsSubset(){} // RVA: 0x7AE790370
        public void Intersection(){} // RVA: 0x7AE7903A0
        public void Union(){} // RVA: 0x7AE790510
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaAppInfo : XmlSchemaObject
    {
        // ── Methods ──
        public void set_Source(){} // RVA: 0x7A8296DE0
        public void get_Markup(){} // RVA: 0x7A8154D80
        public void set_Markup(){} // RVA: 0x7A80FF440
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaAttribute : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7A8178B90
        public void set_DefaultValue(){} // RVA: 0x7A8230620
        public void get_FixedValue(){} // RVA: 0x7A81A0050
        public void set_FixedValue(){} // RVA: 0x7A81A0060
        public void get_Form(){} // RVA: 0x7A9A93870
        public void set_Form(){} // RVA: 0x7A9A93880
        public void get_Name(){} // RVA: 0x7A8175DF0
        public void set_Name(){} // RVA: 0x7A8175E00
        public void get_RefName(){} // RVA: 0x7A81A00E0
        public void set_RefName(){} // RVA: 0x7AE790680
        public void get_SchemaTypeName(){} // RVA: 0x7A82C2060
        public void set_SchemaTypeName(){} // RVA: 0x7AE790760
        public void get_SchemaType(){} // RVA: 0x7A81163D0
        public void set_SchemaType(){} // RVA: 0x7A825E460
        public void get_Use(){} // RVA: 0x7A9A93890
        public void set_Use(){} // RVA: 0x7A9A938A0
        public void get_QualifiedName(){} // RVA: 0x7A825E100
        public void get_AttributeSchemaType(){} // RVA: 0x7A8555100
        public void get_Datatype(){} // RVA: 0x7AE790840
        public void SetQualifiedName(){} // RVA: 0x7A825F860
        public void SetAttributeType(){} // RVA: 0x7A8919DE0
        public void get_AttDef(){} // RVA: 0x7A87D9C10
        public void set_AttDef(){} // RVA: 0x7A8744720
        public void get_NameAttribute(){} // RVA: 0x7A8175DF0
        public void set_NameAttribute(){} // RVA: 0x7A8175E00
        public void Clone(){} // RVA: 0x7AE790860
        public void .ctor(){} // RVA: 0x7AE790A40
    }

    public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A8178B90
        public void set_Name(){} // RVA: 0x7A8230620
        public void get_Attributes(){} // RVA: 0x7A81A0050
        public void get_AnyAttribute(){} // RVA: 0x7A8175DF0
        public void set_AnyAttribute(){} // RVA: 0x7A8175E00
        public void get_QualifiedName(){} // RVA: 0x7A8153390
        public void get_AttributeUses(){} // RVA: 0x7AE790BC0
        public void get_AttributeWildcard(){} // RVA: 0x7A825E100
        public void set_AttributeWildcard(){} // RVA: 0x7A825F860
        public void get_RedefinedAttributeGroup(){} // RVA: 0x7A81A00E0
        public void get_Redefined(){} // RVA: 0x7A81A00E0
        public void set_Redefined(){} // RVA: 0x7A81A00F0
        public void get_SelfReferenceCount(){} // RVA: 0x7A897F560
        public void set_SelfReferenceCount(){} // RVA: 0x7A8980300
        public void get_NameAttribute(){} // RVA: 0x7A8178B90
        public void set_NameAttribute(){} // RVA: 0x7A8230620
        public void SetQualifiedName(){} // RVA: 0x7A81533A0
        public void Clone(){} // RVA: 0x7AE790C70
        public void .ctor(){} // RVA: 0x7AE790E20
    }

    public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7A8178B90
        public void set_RefName(){} // RVA: 0x7AE790F60
        public void .ctor(){} // RVA: 0x7AE791040
    }

    public class XmlSchemaChoice : XmlSchemaGroupBase
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7A82C2060
        public void get_IsEmpty(){} // RVA: 0x7AE7910F0
        public void SetItems(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7AE791100
    }

    public class XmlSchemaCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7911E0
        public void get_Count(){} // RVA: 0x7AE791460
        public void get_NameTable(){} // RVA: 0x7A80DA7B0
        public void set_XmlResolver(){} // RVA: 0x7A80FF440
        public void get_Item(){} // RVA: 0x7AE791490
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE791550
        public void GetEnumerator(){} // RVA: 0x7AE791620
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AE7916F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A81BD750
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7AE791460
        public void GetSchemaInfo(){} // RVA: 0x7AE791890
        public void GetSchemaNames(){} // RVA: 0x7AE791950
        public void Add(){} // RVA: 0x7AE791CE0
        public void get_EventHandler(){} // RVA: 0x7A8292C30
        public void set_EventHandler(){} // RVA: 0x7A8296DE0
    }

    public class XmlSchemaCollectionEnumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE791E20
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AE791EA0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7AE791EF0
        public void MoveNext(){} // RVA: 0x7AE791F40
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AE791F90
        public void get_Current(){} // RVA: 0x7AE791FA0
        public void get_CurrentNode(){} // RVA: 0x7AE792030
    }

    public class XmlSchemaCollectionNode : Object
    {
        // ── Methods ──
        public void set_NamespaceURI(){} // RVA: 0x7A80D8E20
        public void get_SchemaInfo(){} // RVA: 0x7A80DA7B0
        public void set_SchemaInfo(){} // RVA: 0x7A813E420
        public void get_Schema(){} // RVA: 0x7A81052C0
        public void set_Schema(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaCompilationSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A847A240
        public void get_EnableUpaCheck(){} // RVA: 0x7A81A2200
    }

    public class XmlSchemaComplexContent : XmlSchemaContentModel
    {
        // ── Methods ──
        public void get_IsMixed(){} // RVA: 0x7A8359360
        public void set_IsMixed(){} // RVA: 0x7AE7920C0
        public void get_Content(){} // RVA: 0x7A8178B90
        public void set_Content(){} // RVA: 0x7A8230620
        public void get_HasMixedAttribute(){} // RVA: 0x7ACDBE8E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaComplexContentExtension : XmlSchemaContent
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7A8153390
        public void set_BaseTypeName(){} // RVA: 0x7AE7920D0
        public void get_Particle(){} // RVA: 0x7A8178B90
        public void set_Particle(){} // RVA: 0x7A8230620
        public void get_Attributes(){} // RVA: 0x7A81A0050
        public void get_AnyAttribute(){} // RVA: 0x7A8175DF0
        public void set_AnyAttribute(){} // RVA: 0x7A8175E00
        public void SetAttributes(){} // RVA: 0x7A81A0060
        public void .ctor(){} // RVA: 0x7AE7921B0
    }

    public class XmlSchemaComplexContentRestriction : XmlSchemaContent
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7A8153390
        public void set_BaseTypeName(){} // RVA: 0x7AE7922F0
        public void get_Particle(){} // RVA: 0x7A8178B90
        public void set_Particle(){} // RVA: 0x7A8230620
        public void get_Attributes(){} // RVA: 0x7A81A0050
        public void get_AnyAttribute(){} // RVA: 0x7A8175DF0
        public void set_AnyAttribute(){} // RVA: 0x7A8175E00
        public void SetAttributes(){} // RVA: 0x7A81A0060
        public void .ctor(){} // RVA: 0x7AE7923D0
    }

    public class XmlSchemaComplexType : XmlSchemaType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE792510
        public void CreateAnyType(){} // RVA: 0x7AE792A20
        public void .ctor(){} // RVA: 0x7AE793070
        public void get_AnyType(){} // RVA: 0x7AE793130
        public void get_UntypedAnyType(){} // RVA: 0x7AE793190
        public void get_AnyTypeContentValidator(){} // RVA: 0x7AE7931F0
        public void get_IsAbstract(){} // RVA: 0x7AE793270
        public void set_IsAbstract(){} // RVA: 0x7AE793280
        public void get_Block(){} // RVA: 0x7A9B79A20
        public void set_Block(){} // RVA: 0x7A9B794B0
        public void get_IsMixed(){} // RVA: 0x7AE7932B0
        public void set_IsMixed(){} // RVA: 0x7AE7932C0
        public void get_ContentModel(){} // RVA: 0x7A87C5850
        public void set_ContentModel(){} // RVA: 0x7A87446C0
        public void get_Particle(){} // RVA: 0x7A87D9480
        public void set_Particle(){} // RVA: 0x7A8881790
        public void get_Attributes(){} // RVA: 0x7AE7932F0
        public void get_AnyAttribute(){} // RVA: 0x7A8142680
        public void set_AnyAttribute(){} // RVA: 0x7A8142690
        public void get_ContentType(){} // RVA: 0x7A846C760
        public void get_ContentTypeParticle(){} // RVA: 0x7A81426F0
        public void get_BlockResolved(){} // RVA: 0x7A87BD4F0
        public void get_AttributeUses(){} // RVA: 0x7AE7933B0
        public void get_AttributeWildcard(){} // RVA: 0x7A8158F50
        public void get_LocalElements(){} // RVA: 0x7AE793470
        public void SetContentTypeParticle(){} // RVA: 0x7A8142700
        public void SetBlockResolved(){} // RVA: 0x7AB6D7260
        public void SetAttributeWildcard(){} // RVA: 0x7A8158F60
        public void set_HasWildCard(){} // RVA: 0x7AE793530
        public void SetAttributes(){} // RVA: 0x7A8142620
        public void ContainsIdAttribute(){} // RVA: 0x7AE793560
        public void Clone(){} // RVA: 0x7AE7937E0
        public void ClearCompiledState(){} // RVA: 0x7AE794330
        public void CloneAttributes(){} // RVA: 0x7AE7944F0
        public void CloneGroupBaseParticles(){} // RVA: 0x7AE7947C0
        public void CloneParticle(){} // RVA: 0x7AE794920
        public void GetResolvedElementForm(){} // RVA: 0x7AE794E80
        public void HasParticleRef(){} // RVA: 0x7AE794EB0
        public void HasAttributeQNameRef(){} // RVA: 0x7AE795210
    }

    public class XmlSchemaContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaContentModel : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0x7A7E00680
        public void set_Content(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaDatatype : Object
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7A7E00680
        public void get_TokenizedType(){} // RVA: 0x7A7E00710
        public void ParseValue(){} // RVA: 0x7A7E12BD0
        public void get_Variety(){} // RVA: 0x7A82D1450
        public void get_TypeCode(){} // RVA: 0x7A82D1450
        public void IsDerivedFrom(){} // RVA: 0x7A80D7320
        public void get_HasLexicalFacets(){} // RVA: 0x7A7E01900
        public void get_HasValueFacets(){} // RVA: 0x7A7E01900
        public void get_ValueConverter(){} // RVA: 0x7A7E00680
        public void get_Restriction(){} // RVA: 0x7A7E00680
        public void Compare(){} // RVA: 0x7A7E06320
        public void TryParseValue(){} // RVA: 0x7A7E12DE0
        public void get_FacetsChecker(){} // RVA: 0x7A7E00680
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A7E00710
        public void DeriveByRestriction(){} // RVA: 0x7A7E06710
        public void DeriveByList(){} // RVA: 0x7A7E00B20
        public void VerifySchemaValid(){} // RVA: 0x7A7E18890
        public void IsEqual(){} // RVA: 0x7A7E01A40
        public void IsComparable(){} // RVA: 0x7A7E019D0
        public void get_TypeCodeString(){} // RVA: 0x7AE7953B0
        public void TypeCodeToString(){} // RVA: 0x7AE795530
        public void ConcatenatedToString(){} // RVA: 0x7AE795BB0
        public void FromXmlTokenizedType(){} // RVA: 0x7AE7961D0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7AE796280
        public void FromXdrName(){} // RVA: 0x7AE796330
        public void DeriveByUnion(){} // RVA: 0x7AE7964F0
        public void XdrCanonizeUri(){} // RVA: 0x7AE796550
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaDocumentation : XmlSchemaObject
    {
        // ── Methods ──
        public void set_Source(){} // RVA: 0x7A8296DE0
        public void set_Language(){} // RVA: 0x7AE7968E0
        public void set_Markup(){} // RVA: 0x7A8152D90
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE796A30
    }

    public class XmlSchemaElement : XmlSchemaParticle
    {
        // ── Methods ──
        public void get_IsAbstract(){} // RVA: 0x7A865DD90
        public void set_IsAbstract(){} // RVA: 0x7AE796B50
        public void get_Block(){} // RVA: 0x7A8D6DF30
        public void set_Block(){} // RVA: 0x7A8D6DF20
        public void get_DefaultValue(){} // RVA: 0x7A8555100
        public void set_DefaultValue(){} // RVA: 0x7A8919DE0
        public void get_Final(){} // RVA: 0x7A9A18C60
        public void set_Final(){} // RVA: 0x7A9A18CB0
        public void get_FixedValue(){} // RVA: 0x7A87D9C10
        public void set_FixedValue(){} // RVA: 0x7A8744720
        public void get_Form(){} // RVA: 0x7A897F560
        public void set_Form(){} // RVA: 0x7A8980300
        public void get_Name(){} // RVA: 0x7A87C5850
        public void set_Name(){} // RVA: 0x7A87446C0
        public void get_IsNillable(){} // RVA: 0x7A865FC40
        public void set_IsNillable(){} // RVA: 0x7AE796B60
        public void get_HasNillableAttribute(){} // RVA: 0x7A8663F50
        public void get_HasAbstractAttribute(){} // RVA: 0x7A8663F60
        public void get_RefName(){} // RVA: 0x7A87D9480
        public void set_RefName(){} // RVA: 0x7AE796B70
        public void get_SubstitutionGroup(){} // RVA: 0x7A8142610
        public void set_SubstitutionGroup(){} // RVA: 0x7AE796C60
        public void get_SchemaTypeName(){} // RVA: 0x7A8142680
        public void set_SchemaTypeName(){} // RVA: 0x7AE796D50
        public void get_SchemaType(){} // RVA: 0x7A81426F0
        public void set_SchemaType(){} // RVA: 0x7A8142700
        public void get_Constraints(){} // RVA: 0x7AE796E40
        public void get_QualifiedName(){} // RVA: 0x7A82305B0
        public void get_ElementSchemaType(){} // RVA: 0x7A81F50F0
        public void get_BlockResolved(){} // RVA: 0x7A9A94050
        public void get_FinalResolved(){} // RVA: 0x7AE796F00
        public void SetQualifiedName(){} // RVA: 0x7A82305C0
        public void SetElementType(){} // RVA: 0x7A81F5100
        public void SetBlockResolved(){} // RVA: 0x7A9A94060
        public void SetFinalResolved(){} // RVA: 0x7AE796F10
        public void get_HasConstraints(){} // RVA: 0x7AE796F20
        public void get_IsLocalTypeDerivationChecked(){} // RVA: 0x7A86655E0
        public void set_IsLocalTypeDerivationChecked(){} // RVA: 0x7A86616D0
        public void get_ElementDecl(){} // RVA: 0x7A8158FC0
        public void set_ElementDecl(){} // RVA: 0x7A8158FD0
        public void get_NameAttribute(){} // RVA: 0x7A87C5850
        public void set_NameAttribute(){} // RVA: 0x7A87446C0
        public void get_NameString(){} // RVA: 0x7AE796F70
        public void Clone(){} // RVA: 0x7AE796FB0
        public void .ctor(){} // RVA: 0x7AE797420
    }

    public class XmlSchemaEnumerationFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799090
    }

    public class XmlSchemaException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE798BF0
        public void GetObjectData(){} // RVA: 0x7AE797E70
        public void CreateMessage(){} // RVA: 0x7AE798DD0
        public void get_GetRes(){} // RVA: 0x7A8555100
        public void get_Args(){} // RVA: 0x7A87D9C10
        public void get_SourceUri(){} // RVA: 0x7A87C5850
        public void get_LineNumber(){} // RVA: 0x7A8A69800
        public void get_LinePosition(){} // RVA: 0x7ABA39100
        public void get_SourceSchemaObject(){} // RVA: 0x7A8142610
        public void SetSource(){} // RVA: 0x7AE798E90
        public void SetSchemaObject(){} // RVA: 0x7A8142620
        public void get_Message(){} // RVA: 0x7AE798F80
    }

    public class XmlSchemaExternal : XmlSchemaObject
    {
        // ── Methods ──
        public void get_SchemaLocation(){} // RVA: 0x7A8292C30
        public void set_SchemaLocation(){} // RVA: 0x7A8296DE0
        public void get_Schema(){} // RVA: 0x7A8152D80
        public void set_Schema(){} // RVA: 0x7A8152D90
        public void get_Id(){} // RVA: 0x7A8178B90
        public void set_Id(){} // RVA: 0x7A8230620
        public void get_BaseUri(){} // RVA: 0x7A8154D80
        public void set_BaseUri(){} // RVA: 0x7A80FF440
        public void get_IdAttribute(){} // RVA: 0x7A8178B90
        public void set_IdAttribute(){} // RVA: 0x7A8230620
        public void SetUnhandledAttributes(){} // RVA: 0x7A81A0060
        public void get_Compositor(){} // RVA: 0x7A83562E0
        public void set_Compositor(){} // RVA: 0x7A8355940
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaFacet : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A8178B90
        public void set_Value(){} // RVA: 0x7A8230620
        public void get_IsFixed(){} // RVA: 0x7A8359360
        public void set_IsFixed(){} // RVA: 0x7AE798FA0
        public void get_FacetType(){} // RVA: 0x7A835E820
        public void set_FacetType(){} // RVA: 0x7A87A7EB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7990F0
    }

    public class XmlSchemaGroup : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A8178B90
        public void set_Name(){} // RVA: 0x7A8230620
        public void get_Particle(){} // RVA: 0x7A81A0050
        public void set_Particle(){} // RVA: 0x7A81A0060
        public void get_QualifiedName(){} // RVA: 0x7A8153390
        public void get_CanonicalParticle(){} // RVA: 0x7A8175DF0
        public void set_CanonicalParticle(){} // RVA: 0x7A8175E00
        public void get_Redefined(){} // RVA: 0x7A81A00E0
        public void set_Redefined(){} // RVA: 0x7A81A00F0
        public void get_SelfReferenceCount(){} // RVA: 0x7A989D5C0
        public void set_SelfReferenceCount(){} // RVA: 0x7A98A0B60
        public void get_NameAttribute(){} // RVA: 0x7A8178B90
        public void set_NameAttribute(){} // RVA: 0x7A8230620
        public void SetQualifiedName(){} // RVA: 0x7A81533A0
        public void Clone(){} // RVA: 0x7AE799120
        public void .ctor(){} // RVA: 0x7AE7993A0
    }

    public class XmlSchemaGroupBase : XmlSchemaParticle
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7A7E00680
        public void SetItems(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7AE799450
    }

    public class XmlSchemaGroupRef : XmlSchemaParticle
    {
        // ── Methods ──
        public void get_RefName(){} // RVA: 0x7A82C2060
        public void set_RefName(){} // RVA: 0x7AE7994A0
        public void get_Particle(){} // RVA: 0x7A825E100
        public void SetParticle(){} // RVA: 0x7A825F860
        public void get_Redefined(){} // RVA: 0x7A81163D0
        public void set_Redefined(){} // RVA: 0x7A825E460
        public void .ctor(){} // RVA: 0x7AE799580
    }

    public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A8178B90
        public void set_Name(){} // RVA: 0x7A8230620
        public void get_Selector(){} // RVA: 0x7A81A0050
        public void set_Selector(){} // RVA: 0x7A81A0060
        public void get_Fields(){} // RVA: 0x7A8175DF0
        public void get_QualifiedName(){} // RVA: 0x7A8153390
        public void SetQualifiedName(){} // RVA: 0x7A81533A0
        public void get_CompiledConstraint(){} // RVA: 0x7A81A00E0
        public void set_CompiledConstraint(){} // RVA: 0x7A81A00F0
        public void get_NameAttribute(){} // RVA: 0x7A8178B90
        public void set_NameAttribute(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7AE799660
    }

    public class XmlSchemaImport : XmlSchemaExternal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799940
        public void get_Namespace(){} // RVA: 0x7A8153390
        public void set_Namespace(){} // RVA: 0x7A81533A0
        public void AddAnnotation(){} // RVA: 0x7A81A00F0
    }

    public class XmlSchemaInclude : XmlSchemaExternal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799950
        public void AddAnnotation(){} // RVA: 0x7A81533A0
    }

    public class XmlSchemaInference : Object
    {
        // ── Methods ──
        public void set_Occurrence(){} // RVA: 0x7A8178B80
        public void get_Occurrence(){} // RVA: 0x7A8178B70
        public void set_TypeInference(){} // RVA: 0x7A9B79240
        public void .ctor(){} // RVA: 0x7AE71E750
        public void InferSchema(){} // RVA: 0x7AE71E990
        public void InferSchema1(){} // RVA: 0x7AE71EA20
        public void AddAttribute(){} // RVA: 0x7AE71F450
        public void CreateXmlSchema(){} // RVA: 0x7AE71FF70
        public void AddElement(){} // RVA: 0x7AE720050
        public void InferElement(){} // RVA: 0x7AE720D10
        public void CheckSimpleContentExtension(){} // RVA: 0x7AE722670
        public void GetEffectiveSchemaType(){} // RVA: 0x7AE7227F0
        public void FindMatchingElement(){} // RVA: 0x7AE722A20
        public void ProcessAttributes(){} // RVA: 0x7AE723FE0
        public void MoveAttributes(){} // RVA: 0x7AE724CC0
        public void FindAttribute(){} // RVA: 0x7AE725050
        public void FindGlobalElement(){} // RVA: 0x7AE7252A0
        public void FindElement(){} // RVA: 0x7AE725500
        public void FindAttributeRef(){} // RVA: 0x7AE7256A0
        public void FindElementRef(){} // RVA: 0x7AE725960
        public void MakeExistingAttributesOptional(){} // RVA: 0x7AE725B60
        public void SwitchUseToOptional(){} // RVA: 0x7AE725C30
        public void RefineSimpleType(){} // RVA: 0x7AE725D80
        public void InferSimpleType(){} // RVA: 0x7AE726BB0
        public void DateTime(){} // RVA: 0x7AE727D50
        public void CreateNewElementforChoice(){} // RVA: 0x7AE727EA0
        public void GetSchemaType(){} // RVA: 0x7AE728650
        public void SetMinMaxOccurs(){} // RVA: 0x7AE729240
        public void .cctor(){} // RVA: 0x7AE729470
    }

    public class XmlSchemaInferenceException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE72A950
        public void GetObjectData(){} // RVA: 0x7AE72A850
    }

    public class XmlSchemaInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799970
        public void get_Validity(){} // RVA: 0x7A8D863F0
        public void set_Validity(){} // RVA: 0x7A8D870E0
        public void get_IsDefault(){} // RVA: 0x7A81A2200
        public void set_IsDefault(){} // RVA: 0x7A81A2210
        public void get_IsNil(){} // RVA: 0x7A82FBFB0
        public void set_IsNil(){} // RVA: 0x7A82FBFC0
        public void get_MemberType(){} // RVA: 0x7A83F69F0
        public void set_MemberType(){} // RVA: 0x7A8105A90
        public void get_SchemaType(){} // RVA: 0x7A8105330
        public void set_SchemaType(){} // RVA: 0x7AE7999A0
        public void get_SchemaElement(){} // RVA: 0x7A80DA7B0
        public void set_SchemaElement(){} // RVA: 0x7AE799A30
        public void get_SchemaAttribute(){} // RVA: 0x7A81052C0
        public void set_SchemaAttribute(){} // RVA: 0x7AE799AF0
        public void get_ContentType(){} // RVA: 0x7A864E8D0
        public void get_XmlType(){} // RVA: 0x7AE799BB0
        public void get_HasDefaultValue(){} // RVA: 0x7AE799BD0
        public void get_IsUnionType(){} // RVA: 0x7AE799C10
        public void Clear(){} // RVA: 0x7AE799C50
    }

    public class XmlSchemaKey : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7997A0
    }

    public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void get_Refer(){} // RVA: 0x7A82C2060
        public void set_Refer(){} // RVA: 0x7AE7997B0
        public void .ctor(){} // RVA: 0x7AE799890
    }

    public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799050
    }

    public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7990C0
    }

    public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7990D0
    }

    public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799070
    }

    public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7990A0
    }

    public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7990B0
    }

    public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799060
    }

    public class XmlSchemaNotation : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A8178B90
        public void set_Name(){} // RVA: 0x7A8230620
        public void get_Public(){} // RVA: 0x7A81A0050
        public void set_Public(){} // RVA: 0x7A81A0060
        public void get_System(){} // RVA: 0x7A8175DF0
        public void set_System(){} // RVA: 0x7A8175E00
        public void get_QualifiedName(){} // RVA: 0x7A8153390
        public void set_QualifiedName(){} // RVA: 0x7A81533A0
        public void get_NameAttribute(){} // RVA: 0x7A8178B90
        public void set_NameAttribute(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7AE799DC0
    }

    public class XmlSchemaNumericFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaObject : Object
    {
        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7A8124910
        public void set_LineNumber(){} // RVA: 0x7A80DA0C0
        public void get_LinePosition(){} // RVA: 0x7A8668BC0
        public void set_LinePosition(){} // RVA: 0x7A8669360
        public void get_SourceUri(){} // RVA: 0x7A80DA7B0
        public void set_SourceUri(){} // RVA: 0x7A813E420
        public void get_Parent(){} // RVA: 0x7A8105330
        public void set_Parent(){} // RVA: 0x7A80D8E80
        public void get_Namespaces(){} // RVA: 0x7AE799E70
        public void set_Namespaces(){} // RVA: 0x7A81052D0
        public void OnAdd(){} // RVA: 0x7A80D7310
        public void OnRemove(){} // RVA: 0x7A80D7310
        public void OnClear(){} // RVA: 0x7A80D7310
        public void get_IdAttribute(){} // RVA: 0x7A82D1450
        public void set_IdAttribute(){} // RVA: 0x7A80D7310
        public void SetUnhandledAttributes(){} // RVA: 0x7A80D7310
        public void AddAnnotation(){} // RVA: 0x7A80D7310
        public void get_NameAttribute(){} // RVA: 0x7A82D1450
        public void set_NameAttribute(){} // RVA: 0x7A80D7310
        public void get_IsProcessing(){} // RVA: 0x7A80FD690
        public void set_IsProcessing(){} // RVA: 0x7A80FD6A0
        public void Clone(){} // RVA: 0x7AE799F10
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaObjectCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9BA890
        public void get_Item(){} // RVA: 0x7AE799F90
        public void set_Item(){} // RVA: 0x7AE79A040
        public void GetEnumerator(){} // RVA: 0x7AE79A0B0
        public void Add(){} // RVA: 0x7AE79A420
        public void Insert(){} // RVA: 0x7AE79A1C0
        public void Remove(){} // RVA: 0x7AE79A230
        public void OnInsert(){} // RVA: 0x7AE79A290
        public void OnSet(){} // RVA: 0x7AE79A2C0
        public void OnClear(){} // RVA: 0x7AE79A330
        public void OnRemove(){} // RVA: 0x7AE79A360
        public void Clone(){} // RVA: 0x7AE79A390
    }

    public class XmlSchemaObjectEnumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void MoveNext(){} // RVA: 0x7AE79A450
        public void get_Current(){} // RVA: 0x7AE79A4A0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AE79A540
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7AE79A590
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AE79A5E0
    }

    public class XmlSchemaObjectTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE79A630
        public void Add(){} // RVA: 0x7AE79A790
        public void Insert(){} // RVA: 0x7AE79A910
        public void Replace(){} // RVA: 0x7AE79AA70
        public void Clear(){} // RVA: 0x7AE79ABB0
        public void Remove(){} // RVA: 0x7AE79AC40
        public void FindIndexByValue(){} // RVA: 0x7AE79AD10
        public void get_Count(){} // RVA: 0x7AE79ADC0
        public void Contains(){} // RVA: 0x7AE79AE10
        public void get_Item(){} // RVA: 0x7AE79AE90
        public void get_Values(){} // RVA: 0x7AE79AF10
        public void GetEnumerator(){} // RVA: 0x7AE79AFE0
    }

    public class XmlSchemaParticle : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_MinOccursString(){} // RVA: 0x7AE79BDD0
        public void set_MinOccursString(){} // RVA: 0x7AE79BF10
        public void get_MaxOccursString(){} // RVA: 0x7AE79C120
        public void set_MaxOccursString(){} // RVA: 0x7AE79C320
        public void get_MinOccurs(){} // RVA: 0x7ABFD09C0
        public void set_MinOccurs(){} // RVA: 0x7AE79C630
        public void get_MaxOccurs(){} // RVA: 0x7AB491250
        public void set_MaxOccurs(){} // RVA: 0x7AE79C8B0
        public void get_IsEmpty(){} // RVA: 0x7AE79CBC0
        public void get_NameString(){} // RVA: 0x7AE79CC80
        public void GetQualifiedName(){} // RVA: 0x7AE79CCC0
        public void .ctor(){} // RVA: 0x7AE79CE70
        public void .cctor(){} // RVA: 0x7AE79CEF0
    }

    public class XmlSchemaPatternFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799080
    }

    public class XmlSchemaRedefine : XmlSchemaExternal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE79D040
        public void get_Items(){} // RVA: 0x7A8153390
        public void get_AttributeGroups(){} // RVA: 0x7A81A00E0
        public void get_SchemaTypes(){} // RVA: 0x7A82C2060
        public void get_Groups(){} // RVA: 0x7A825E100
        public void AddAnnotation(){} // RVA: 0x7AE79D260
    }

    public class XmlSchemaSequence : XmlSchemaGroupBase
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7A82C2060
        public void get_IsEmpty(){} // RVA: 0x7AE78F680
        public void SetItems(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7AE79D2C0
    }

    public class XmlSchemaSet : Object
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7AE79D3A0
        public void .ctor(){} // RVA: 0x7AE79D4B0
        public void add_ValidationEventHandler(){} // RVA: 0x7AE79DAA0
        public void remove_ValidationEventHandler(){} // RVA: 0x7AE79DCC0
        public void get_IsCompiled(){} // RVA: 0x7A82A20A0
        public void set_XmlResolver(){} // RVA: 0x7AE79DE20
        public void get_CompilationSettings(){} // RVA: 0x7A82C2060
        public void set_CompilationSettings(){} // RVA: 0x7A82C0530
        public void get_Count(){} // RVA: 0x7AE79DE40
        public void get_GlobalElements(){} // RVA: 0x7AE79DE70
        public void get_GlobalAttributes(){} // RVA: 0x7AE79DF30
        public void get_GlobalTypes(){} // RVA: 0x7AE79DFF0
        public void get_SubstitutionGroups(){} // RVA: 0x7AE79E0B0
        public void get_SchemaLocations(){} // RVA: 0x7A8154D80
        public void get_TypeExtensions(){} // RVA: 0x7AE79E170
        public void Add(){} // RVA: 0x7AE7A0F10
        public void RemoveRecursive(){} // RVA: 0x7AE79ECC0
        public void Contains(){} // RVA: 0x7AE79F620
        public void Compile(){} // RVA: 0x7AE79F6A0
        public void Reprocess(){} // RVA: 0x7AE7A0230
        public void CopyTo(){} // RVA: 0x7AE7A0B50
        public void Schemas(){} // RVA: 0x7AE7A0CB0
        public void FindSchemaByNSAndUrl(){} // RVA: 0x7AE7A1470
        public void AddSchemaToSet(){} // RVA: 0x7AE7A17E0
        public void ProcessNewSubstitutionGroups(){} // RVA: 0x7AE7A1CD0
        public void ResolveSubstitutionGroup(){} // RVA: 0x7AE7A2050
        public void Remove(){} // RVA: 0x7AE7A2490
        public void ClearTables(){} // RVA: 0x7AE7A2850
        public void PreprocessSchema(){} // RVA: 0x7AE7A2990
        public void ParseSchema(){} // RVA: 0x7AE7A2C40
        public void CopyFromCompiledSet(){} // RVA: 0x7AE7A2DF0
        public void get_CompiledInfo(){} // RVA: 0x7A8175DF0
        public void get_ReaderSettings(){} // RVA: 0x7A8153390
        public void GetResolver(){} // RVA: 0x7AE7A4170
        public void GetEventHandler(){} // RVA: 0x7A83F69F0
        public void GetSchemaNames(){} // RVA: 0x7AE7A4190
        public void IsSchemaLoaded(){} // RVA: 0x7AE7A4290
        public void GetSchemaByUri(){} // RVA: 0x7AE7A4FD0
        public void GetTargetNamespace(){} // RVA: 0x7AE7A5230
        public void get_SortedSchemas(){} // RVA: 0x7A81052C0
        public void RemoveSchemaFromCaches(){} // RVA: 0x7AE7A5290
        public void RemoveSchemaFromGlobalTables(){} // RVA: 0x7AE7A5750
        public void AddToTable(){} // RVA: 0x7AE7A6120
        public void VerifyTables(){} // RVA: 0x7AE7A6490
        public void InternalValidationCallback(){} // RVA: 0x7AE7A66D0
        public void SendValidationEvent(){} // RVA: 0x7AE7A6720
    }

    public class XmlSchemaSimpleContent : XmlSchemaContentModel
    {
        // ── Methods ──
        public void get_Content(){} // RVA: 0x7A8178B90
        public void set_Content(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaSimpleContentExtension : XmlSchemaContent
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7A8175DF0
        public void set_BaseTypeName(){} // RVA: 0x7AE7A67F0
        public void get_Attributes(){} // RVA: 0x7A8178B90
        public void get_AnyAttribute(){} // RVA: 0x7A81A0050
        public void set_AnyAttribute(){} // RVA: 0x7A81A0060
        public void SetAttributes(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7AE7A68D0
    }

    public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7A8178B90
        public void set_BaseTypeName(){} // RVA: 0x7AE7A6A10
        public void get_BaseType(){} // RVA: 0x7A81A0050
        public void set_BaseType(){} // RVA: 0x7A81A0060
        public void get_Facets(){} // RVA: 0x7A8175DF0
        public void get_Attributes(){} // RVA: 0x7A8153390
        public void get_AnyAttribute(){} // RVA: 0x7A81A00E0
        public void set_AnyAttribute(){} // RVA: 0x7A81A00F0
        public void SetAttributes(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7AE7A6AF0
    }

    public class XmlSchemaSimpleType : XmlSchemaType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7A6CB0
        public void get_Content(){} // RVA: 0x7A87D9C10
        public void set_Content(){} // RVA: 0x7A8744720
        public void Clone(){} // RVA: 0x7AE7A6CC0
    }

    public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
    {
        // ── Methods ──
        public void get_ItemTypeName(){} // RVA: 0x7A8178B90
        public void set_ItemTypeName(){} // RVA: 0x7AE7A6E30
        public void get_ItemType(){} // RVA: 0x7A81A0050
        public void set_ItemType(){} // RVA: 0x7A81A0060
        public void get_BaseItemType(){} // RVA: 0x7A8175DF0
        public void set_BaseItemType(){} // RVA: 0x7A8175E00
        public void Clone(){} // RVA: 0x7AE7A6F10
        public void .ctor(){} // RVA: 0x7AE7A7070
    }

    public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
    {
        // ── Methods ──
        public void get_BaseTypeName(){} // RVA: 0x7A8178B90
        public void set_BaseTypeName(){} // RVA: 0x7AE7A7120
        public void get_BaseType(){} // RVA: 0x7A81A0050
        public void set_BaseType(){} // RVA: 0x7A81A0060
        public void get_Facets(){} // RVA: 0x7A8175DF0
        public void Clone(){} // RVA: 0x7AE7A7200
        public void .ctor(){} // RVA: 0x7AE7A7360
    }

    public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
    {
        // ── Methods ──
        public void get_BaseTypes(){} // RVA: 0x7A8178B90
        public void get_MemberTypes(){} // RVA: 0x7A81A0050
        public void set_MemberTypes(){} // RVA: 0x7A81A0060
        public void get_BaseMemberTypes(){} // RVA: 0x7A8175DF0
        public void SetBaseMemberTypes(){} // RVA: 0x7A8175E00
        public void Clone(){} // RVA: 0x7AE7A74B0
        public void .ctor(){} // RVA: 0x7AE7A7790
    }

    public class XmlSchemaSubstitutionGroup : XmlSchemaObject
    {
        // ── Methods ──
        public void get_Members(){} // RVA: 0x7A8292C30
        public void get_Examplar(){} // RVA: 0x7A8154D80
        public void set_Examplar(){} // RVA: 0x7A80FF440
        public void .ctor(){} // RVA: 0x7AE7A7830
    }

    public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
    {
        // ── Methods ──
        public void get_Choice(){} // RVA: 0x7A8152D80
        public void .ctor(){} // RVA: 0x7AE7A7970
    }

    public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7990E0
    }

    public class XmlSchemaType : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void GetBuiltInSimpleType(){} // RVA: 0x7AE7A7AF0
        public void GetBuiltInComplexType(){} // RVA: 0x7AE7A7B40
        public void get_Name(){} // RVA: 0x7A8178B90
        public void set_Name(){} // RVA: 0x7A8230620
        public void get_Final(){} // RVA: 0x7A87A7DA0
        public void set_Final(){} // RVA: 0x7A87A7CF0
        public void get_QualifiedName(){} // RVA: 0x7AE7A7CC0
        public void get_FinalResolved(){} // RVA: 0x7A8EA8210
        public void get_BaseXmlSchemaType(){} // RVA: 0x7A8175DF0
        public void get_DerivedBy(){} // RVA: 0x7A835E820
        public void get_Datatype(){} // RVA: 0x7A8153390
        public void get_IsMixed(){} // RVA: 0x7A80D7320
        public void set_IsMixed(){} // RVA: 0x7A80D7310
        public void get_TypeCode(){} // RVA: 0x7AE7A7CD0
        public void get_ValueConverter(){} // RVA: 0x7AE7A7D90
        public void get_SchemaContentType(){} // RVA: 0x7A846C760
        public void SetQualifiedName(){} // RVA: 0x7AE7A7E10
        public void SetFinalResolved(){} // RVA: 0x7A8270510
        public void SetBaseSchemaType(){} // RVA: 0x7A8175E00
        public void SetDerivedBy(){} // RVA: 0x7A87A7EB0
        public void SetDatatype(){} // RVA: 0x7A81533A0
        public void get_ElementDecl(){} // RVA: 0x7AE7A7E70
        public void set_ElementDecl(){} // RVA: 0x7AE7A7E80
        public void get_Redefined(){} // RVA: 0x7A81163D0
        public void set_Redefined(){} // RVA: 0x7A825E460
        public void SetContentType(){} // RVA: 0x7A8CCD330
        public void IsDerivedFrom(){} // RVA: 0x7AE7A7EE0
        public void IsDerivedFromDatatype(){} // RVA: 0x7AE7A8070
        public void get_NameAttribute(){} // RVA: 0x7A8178B90
        public void set_NameAttribute(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7AE7A8150
    }

    public class XmlSchemaUnique : XmlSchemaIdentityConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7997A0
    }

    public class XmlSchemaValidationException : XmlSchemaException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7A82E0
        public void GetObjectData(){} // RVA: 0x7AE72A850
    }

    public class XmlSchemaValidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7A83F0
        public void Init(){} // RVA: 0x7AE7A8740
        public void Reset(){} // RVA: 0x7AE7A9060
        public void set_XmlResolver(){} // RVA: 0x7A8158EF0
        public void set_LineInfoProvider(){} // RVA: 0x7AE7A9180
        public void set_SourceUri(){} // RVA: 0x7AE7A9250
        public void set_ValidationEventSender(){} // RVA: 0x7A8142690
        public void add_ValidationEventHandler(){} // RVA: 0x7AE7A9340
        public void remove_ValidationEventHandler(){} // RVA: 0x7AE7A9440
        public void AddSchema(){} // RVA: 0x7AE7A9540
        public void Initialize(){} // RVA: 0x7AE7A9AD0
        public void ValidateElement(){} // RVA: 0x7AE7A9DF0
        public void ValidateAttribute(){} // RVA: 0x7AE7AA440
        public void ValidateEndOfAttributes(){} // RVA: 0x7AE7AAED0
        public void ValidateText(){} // RVA: 0x7AE7AB020
        public void ValidateWhitespace(){} // RVA: 0x7AE7AB500
        public void ValidateEndElement(){} // RVA: 0x7AE7AB790
        public void SkipToEndElement(){} // RVA: 0x7AE7AB7A0
        public void EndValidation(){} // RVA: 0x7AE7ABA20
        public void GetUnspecifiedDefaultAttributes(){} // RVA: 0x7AE7ABCA0
        public void get_SchemaSet(){} // RVA: 0x7A80F2570
        public void get_ValidationFlags(){} // RVA: 0x7A83782A0
        public void get_CurrentContentType(){} // RVA: 0x7AE7AC3D0
        public void SetDtdSchemaInfo(){} // RVA: 0x7AE7AC410
        public void get_StrictlyAssessed(){} // RVA: 0x7AE7AC470
        public void get_HasSchema(){} // RVA: 0x7AE7AC4B0
        public void GetConcatenatedValue(){} // RVA: 0x7AE7AC500
        public void InternalValidateEndElement(){} // RVA: 0x7AE7AC530
        public void ProcessSchemaLocations(){} // RVA: 0x7AE7ACBD0
        public void ValidateElementContext(){} // RVA: 0x7AE7ACF20
        public void GetSubstitutionGroupHead(){} // RVA: 0x7AE7AD500
        public void ValidateAtomicValue(){} // RVA: 0x7AE7ADB10
        public void GetTypeName(){} // RVA: 0x7AE7ADFA0
        public void SaveTextValue(){} // RVA: 0x7AE7AE010
        public void Push(){} // RVA: 0x7AE7AE060
        public void Pop(){} // RVA: 0x7AE7AE470
        public void FastGetElementDecl(){} // RVA: 0x7AE7AE670
        public void CheckXsiTypeAndNil(){} // RVA: 0x7AE7AE9D0
        public void ThrowDeclNotFoundWarningOrError(){} // RVA: 0x7AE7AF150
        public void CheckElementProperties(){} // RVA: 0x7AE7AF3B0
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7AE7AF4B0
        public void CheckIsXmlAttribute(){} // RVA: 0x7AE7AF510
        public void AddXmlNamespaceSchema(){} // RVA: 0x7AE7AF6A0
        public void CheckMixedValueConstraint(){} // RVA: 0x7AE7AF790
        public void LoadSchema(){} // RVA: 0x7AE7AF8C0
        public void RecompileSchemaSet(){} // RVA: 0x7AE7AFD10
        public void ProcessTokenizedType(){} // RVA: 0x7AE7AFDD0
        public void CheckAttributeValue(){} // RVA: 0x7AE7B00B0
        public void CheckElementValue(){} // RVA: 0x7AE7B0380
        public void CheckTokenizedTypes(){} // RVA: 0x7AE7B06C0
        public void FindId(){} // RVA: 0x7AE7B0860
        public void CheckForwardRefs(){} // RVA: 0x7AE7B0890
        public void get_HasIdentityConstraints(){} // RVA: 0x7AE7B0A20
        public void get_ProcessIdentityConstraints(){} // RVA: 0x7AD84C5A0
        public void get_ReportValidationWarnings(){} // RVA: 0x7AD84BFE0
        public void get_ProcessSchemaHints(){} // RVA: 0x7AE7B0A40
        public void CheckStateTransition(){} // RVA: 0x7AE7B0A60
        public void ClearPSVI(){} // RVA: 0x7AE7B0D00
        public void CheckRequiredAttributes(){} // RVA: 0x7AE7B0DA0
        public void GetSchemaElement(){} // RVA: 0x7AE7B1080
        public void GetDefaultAttributePrefix(){} // RVA: 0x7AE7B1290
        public void AddIdentityConstraints(){} // RVA: 0x7AE7B1550
        public void ElementIdentityConstraints(){} // RVA: 0x7AE7B1BB0
        public void AttributeIdentityConstraints(){} // RVA: 0x7AE7B1F60
        public void EndElementIdentityConstraints(){} // RVA: 0x7AE7B22C0
        public void ElementValidationError(){} // RVA: 0x7AE7B2EC0
        public void CompleteValidationError(){} // RVA: 0x7AE7B36D0
        public void PrintExpectedElements(){} // RVA: 0x7AE7B3C20
        public void PrintNames(){} // RVA: 0x7AE7B4210
        public void PrintNamesWithNS(){} // RVA: 0x7AE7B43B0
        public void EnumerateAny(){} // RVA: 0x7AE7B4A00
        public void QNameString(){} // RVA: 0x7AE7B4CA0
        public void BuildElementName(){} // RVA: 0x7AE7B4D80
        public void ProcessEntity(){} // RVA: 0x7AE7B4EF0
        public void SendValidationEvent(){} // RVA: 0x7AE7B59B0
        public void .cctor(){} // RVA: 0x7AE7B5A70
    }

    public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE799100
    }

    public class XmlSchemaXPath : XmlSchemaAnnotated
    {
        // ── Methods ──
        public void get_XPath(){} // RVA: 0x7A8178B90
        public void set_XPath(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlStringConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7CB6B0
        public void Create(){} // RVA: 0x7AE7CB710
        public void ToString(){} // RVA: 0x7AE7CB7A0
        public void ChangeType(){} // RVA: 0x7AE7CBC90
    }

    public class XmlUnionConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7D9FC0
        public void Create(){} // RVA: 0x7AE7DA360
        public void ChangeType(){} // RVA: 0x7AE7DA3C0
    }

    public class XmlUntypedConverter : XmlListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7CC210
        public void ToBoolean(){} // RVA: 0x7AE7CC4A0
        public void ToDateTime(){} // RVA: 0x7AE7CC740
        public void ToDateTimeOffset(){} // RVA: 0x7AE7CCA50
        public void ToDecimal(){} // RVA: 0x7AE7CCD70
        public void ToDouble(){} // RVA: 0x7AE7CD080
        public void ToInt32(){} // RVA: 0x7AE7CD330
        public void ToInt64(){} // RVA: 0x7AE7CD5F0
        public void ToSingle(){} // RVA: 0x7AE7CD8B0
        public void ToString(){} // RVA: 0x7AE7CDEE0
        public void ChangeType(){} // RVA: 0x7AE7D0900
        public void ChangeTypeWildcardDestination(){} // RVA: 0x7AE7D2190
        public void ChangeTypeWildcardSource(){} // RVA: 0x7AE7D22F0
        public void ChangeListType(){} // RVA: 0x7AE7D2470
        public void SupportsType(){} // RVA: 0x7AE7D27C0
        public void .cctor(){} // RVA: 0x7AE7D2D40
    }

    public class XmlValueConverter : Object
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0x7A7E019D0
        public void ToInt32(){} // RVA: 0x7A7E01630
        public void ToInt64(){} // RVA: 0x7A7E00B20
        public void ToDecimal(){} // RVA: 0x7A7E00560
        public void ToDouble(){} // RVA: 0x7A7E06AF0
        public void ToSingle(){} // RVA: 0x7A7E15640
        public void ToDateTime(){} // RVA: 0x7A7E00B20
        public void ToDateTimeOffset(){} // RVA: 0x7A7E00560
        public void ToString(){} // RVA: 0x7A7E00BD0
        public void ChangeType(){} // RVA: 0x7A7E06710
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlValueGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98C14D0
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class XsdBuilder : SchemaBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7DA860
        public void ProcessElement(){} // RVA: 0x7AE7DAEC0
        public void ProcessAttribute(){} // RVA: 0x7AE7DB1A0
        public void IsContentParsed(){} // RVA: 0x7AE7DB7C0
        public void ProcessMarkup(){} // RVA: 0x7A8B4A0C0
        public void ProcessCData(){} // RVA: 0x7AE7DB7E0
        public void StartChildren(){} // RVA: 0x7AE7DB830
        public void EndChildren(){} // RVA: 0x7AE7DBA70
        public void Push(){} // RVA: 0x7AE7DBC00
        public void Pop(){} // RVA: 0x7AE7DBF30
        public void get_CurrentElement(){} // RVA: 0x7ADA294C0
        public void get_ParentElement(){} // RVA: 0x7AE7DC090
        public void get_ParentContainer(){} // RVA: 0x7AE7DC120
        public void GetContainer(){} // RVA: 0x7AE7DC1C0
        public void SetContainer(){} // RVA: 0x7AE7DC410
        public void BuildAnnotated_Id(){} // RVA: 0x7AE7DDB90
        public void BuildSchema_AttributeFormDefault(){} // RVA: 0x7AE7DDBC0
        public void BuildSchema_ElementFormDefault(){} // RVA: 0x7AE7DDC80
        public void BuildSchema_TargetNamespace(){} // RVA: 0x7AE7DDD40
        public void BuildSchema_Version(){} // RVA: 0x7AE7DDDB0
        public void BuildSchema_FinalDefault(){} // RVA: 0x7AE7DDE20
        public void BuildSchema_BlockDefault(){} // RVA: 0x7AE7DDEA0
        public void InitSchema(){} // RVA: 0x7AE7DDF20
        public void InitInclude(){} // RVA: 0x7AE7DDF90
        public void BuildInclude_SchemaLocation(){} // RVA: 0x7AE7DE120
        public void InitImport(){} // RVA: 0x7AE7DE190
        public void BuildImport_Namespace(){} // RVA: 0x7AE7DE320
        public void BuildImport_SchemaLocation(){} // RVA: 0x7AE7DE390
        public void InitRedefine(){} // RVA: 0x7AE7DE400
        public void BuildRedefine_SchemaLocation(){} // RVA: 0x7AE7DE590
        public void EndRedefine(){} // RVA: 0x7AE7DE600
        public void InitAttribute(){} // RVA: 0x7AE7DE620
        public void BuildAttribute_Default(){} // RVA: 0x7AE7DE7C0
        public void BuildAttribute_Fixed(){} // RVA: 0x7AE7DE830
        public void BuildAttribute_Form(){} // RVA: 0x7AE7DE8A0
        public void BuildAttribute_Use(){} // RVA: 0x7AE7DE960
        public void BuildAttribute_Ref(){} // RVA: 0x7AE7DEA20
        public void BuildAttribute_Name(){} // RVA: 0x7AE7DEB60
        public void BuildAttribute_Type(){} // RVA: 0x7AE7DEBD0
        public void InitElement(){} // RVA: 0x7AE7DED10
        public void BuildElement_Abstract(){} // RVA: 0x7AE7DEF10
        public void BuildElement_Block(){} // RVA: 0x7AE7DEF90
        public void BuildElement_Default(){} // RVA: 0x7AE7DF010
        public void BuildElement_Form(){} // RVA: 0x7AE7DF080
        public void BuildElement_SubstitutionGroup(){} // RVA: 0x7AE7DF140
        public void BuildElement_Final(){} // RVA: 0x7AE7DF280
        public void BuildElement_Fixed(){} // RVA: 0x7AE7DF300
        public void BuildElement_MaxOccurs(){} // RVA: 0x7AE7DF370
        public void BuildElement_MinOccurs(){} // RVA: 0x7AE7DF3A0
        public void BuildElement_Name(){} // RVA: 0x7AE7DF3D0
        public void BuildElement_Nillable(){} // RVA: 0x7AE7DF440
        public void BuildElement_Ref(){} // RVA: 0x7AE7DF4C0
        public void BuildElement_Type(){} // RVA: 0x7AE7DF600
        public void InitSimpleType(){} // RVA: 0x7AE7DF740
        public void BuildSimpleType_Name(){} // RVA: 0x7AE7DFCE0
        public void BuildSimpleType_Final(){} // RVA: 0x7AE7DFD50
        public void InitSimpleTypeUnion(){} // RVA: 0x7AE7DFDD0
        public void BuildSimpleTypeUnion_MemberTypes(){} // RVA: 0x7AE7E0030
        public void InitSimpleTypeList(){} // RVA: 0x7AE7E0230
        public void BuildSimpleTypeList_ItemType(){} // RVA: 0x7AE7E03F0
        public void InitSimpleTypeRestriction(){} // RVA: 0x7AE7E0530
        public void BuildSimpleTypeRestriction_Base(){} // RVA: 0x7AE7E06F0
        public void InitComplexType(){} // RVA: 0x7AE7E0830
        public void BuildComplexType_Abstract(){} // RVA: 0x7AE7E0AC0
        public void BuildComplexType_Block(){} // RVA: 0x7AE7E0B50
        public void BuildComplexType_Final(){} // RVA: 0x7AE7E0BD0
        public void BuildComplexType_Mixed(){} // RVA: 0x7AE7E0C50
        public void BuildComplexType_Name(){} // RVA: 0x7AE7E0CE0
        public void InitComplexContent(){} // RVA: 0x7AE7E0D50
        public void BuildComplexContent_Mixed(){} // RVA: 0x7AE7E0F70
        public void InitComplexContentExtension(){} // RVA: 0x7AE7E0FF0
        public void BuildComplexContentExtension_Base(){} // RVA: 0x7AE7E12B0
        public void InitComplexContentRestriction(){} // RVA: 0x7AE7E13F0
        public void BuildComplexContentRestriction_Base(){} // RVA: 0x7AE7E1650
        public void InitSimpleContent(){} // RVA: 0x7AE7E1790
        public void InitSimpleContentExtension(){} // RVA: 0x7AE7E19B0
        public void BuildSimpleContentExtension_Base(){} // RVA: 0x7AE7E1B50
        public void InitSimpleContentRestriction(){} // RVA: 0x7AE7E1C90
        public void BuildSimpleContentRestriction_Base(){} // RVA: 0x7AE7E1FD0
        public void InitAttributeGroup(){} // RVA: 0x7AE7E2110
        public void BuildAttributeGroup_Name(){} // RVA: 0x7AE7E22B0
        public void InitAttributeGroupRef(){} // RVA: 0x7AE7E2320
        public void BuildAttributeGroupRef_Ref(){} // RVA: 0x7AE7E24D0
        public void InitAnyAttribute(){} // RVA: 0x7AE7E2610
        public void BuildAnyAttribute_Namespace(){} // RVA: 0x7AE7E2BA0
        public void BuildAnyAttribute_ProcessContents(){} // RVA: 0x7AE7E2C10
        public void InitGroup(){} // RVA: 0x7AE7E2CD0
        public void BuildGroup_Name(){} // RVA: 0x7AE7E2EF0
        public void InitGroupRef(){} // RVA: 0x7AE7E2F60
        public void BuildParticle_MaxOccurs(){} // RVA: 0x7AE7E31A0
        public void BuildParticle_MinOccurs(){} // RVA: 0x7AE7E31D0
        public void BuildGroupRef_Ref(){} // RVA: 0x7AE7E3200
        public void InitAll(){} // RVA: 0x7AE7E3340
        public void InitChoice(){} // RVA: 0x7AE7E34B0
        public void InitSequence(){} // RVA: 0x7AE7E3620
        public void InitAny(){} // RVA: 0x7AE7E3790
        public void BuildAny_Namespace(){} // RVA: 0x7AE7E3940
        public void BuildAny_ProcessContents(){} // RVA: 0x7AE7E39B0
        public void InitNotation(){} // RVA: 0x7AE7E3A70
        public void BuildNotation_Name(){} // RVA: 0x7AE7E3C60
        public void BuildNotation_Public(){} // RVA: 0x7AE7E3CD0
        public void BuildNotation_System(){} // RVA: 0x7AE7E3D40
        public void InitFacet(){} // RVA: 0x7AE7E3DB0
        public void BuildFacet_Fixed(){} // RVA: 0x7AE7E41A0
        public void BuildFacet_Value(){} // RVA: 0x7AE7E4230
        public void InitIdentityConstraint(){} // RVA: 0x7AE7E42A0
        public void BuildIdentityConstraint_Name(){} // RVA: 0x7AE7E4710
        public void BuildIdentityConstraint_Refer(){} // RVA: 0x7AE7E4780
        public void InitSelector(){} // RVA: 0x7AE7E4980
        public void BuildSelector_XPath(){} // RVA: 0x7AE7E4B40
        public void InitField(){} // RVA: 0x7AE7E4BB0
        public void BuildField_XPath(){} // RVA: 0x7AE7E4B40
        public void InitAnnotation(){} // RVA: 0x7AE7E4D50
        public void InitAppinfo(){} // RVA: 0x7AE7E4F70
        public void BuildAppinfo_Source(){} // RVA: 0x7AE7E5180
        public void EndAppinfo(){} // RVA: 0x7AE7E5240
        public void InitDocumentation(){} // RVA: 0x7AE7E52B0
        public void BuildDocumentation_Source(){} // RVA: 0x7AE7E54C0
        public void BuildDocumentation_XmlLang(){} // RVA: 0x7AE7E5580
        public void EndDocumentation(){} // RVA: 0x7AE7E57B0
        public void AddAttribute(){} // RVA: 0x7AE7E5820
        public void AddParticle(){} // RVA: 0x7AE7E5AC0
        public void GetNextState(){} // RVA: 0x7AE7E5F10
        public void IsSkipableElement(){} // RVA: 0x7AE7E60F0
        public void SetMinOccurs(){} // RVA: 0x7AE7E6120
        public void SetMaxOccurs(){} // RVA: 0x7AE7E6180
        public void ParseBoolean(){} // RVA: 0x7AE7E61E0
        public void ParseEnum(){} // RVA: 0x7AE7E6280
        public void ParseQName(){} // RVA: 0x7AE7E63B0
        public void ParseBlockFinalEnum(){} // RVA: 0x7AE7E65F0
        public void ParseUriReference(){} // RVA: 0x7A97F8BA0
        public void SendValidationEvent(){} // RVA: 0x7AE7E6E00
        public void RecordPosition(){} // RVA: 0x7AE7E6E10
        public void .cctor(){} // RVA: 0x7AE7E6F90
    }

    public class XsdDateTime : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E944B0
        public void InitiateXsdDateTime(){} // RVA: 0x7A7E943F0
        public void TryParse(){} // RVA: 0x7AE7ED420
        public void get_InternalTypeCode(){} // RVA: 0x7A7E944D0
        public void get_InternalKind(){} // RVA: 0x7A7E33210
        public void get_Year(){} // RVA: 0x7A7E944E0
        public void get_Month(){} // RVA: 0x7A7E944F0
        public void get_Day(){} // RVA: 0x7A7E94500
        public void get_Hour(){} // RVA: 0x7A7E94510
        public void get_Minute(){} // RVA: 0x7A7E94560
        public void get_Second(){} // RVA: 0x7A7E945B0
        public void get_Fraction(){} // RVA: 0x7A7E94600
        public void get_ZoneHour(){} // RVA: 0x7A7664CC0
        public void get_ZoneMinute(){} // RVA: 0x7A7664BF0
        public void op_Implicit(){} // RVA: 0x7AE7EE900
        public void ToString(){} // RVA: 0x7A7E94610
        public void PrintDate(){} // RVA: 0x7A7E94620
        public void PrintTime(){} // RVA: 0x7A7E94630
        public void PrintZone(){} // RVA: 0x7A7E94640
        public void IntToCharArray(){} // RVA: 0x7A7E94650
        public void ShortToCharArray(){} // RVA: 0x7A7E94660
        public void .cctor(){} // RVA: 0x7AE7F0020
    }

    public class XsdDuration : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E94990
        public void get_IsNegative(){} // RVA: 0x7A7E949A0
        public void get_Years(){} // RVA: 0x7A765F070
        public void get_Months(){} // RVA: 0x7A765F0A0
        public void get_Days(){} // RVA: 0x7A75FEFA0
        public void get_Hours(){} // RVA: 0x7A767FBD0
        public void get_Minutes(){} // RVA: 0x7A7677B20
        public void get_Seconds(){} // RVA: 0x7A7699630
        public void get_Nanoseconds(){} // RVA: 0x7A7E949B0
        public void ToTimeSpan(){} // RVA: 0x7A7E94A10
        public void TryToTimeSpan(){} // RVA: 0x7A7E94A80
        public void ToString(){} // RVA: 0x7A7E94AA0
        public void TryParse(){} // RVA: 0x7AE7F3650
        public void TryParseDigits(){} // RVA: 0x7AE7F4280
    }

    public class XsdSimpleValue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_XmlType(){} // RVA: 0x7A80F2570
        public void get_TypedValue(){} // RVA: 0x7A80DA7B0
    }

    public class XsdValidator : BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7F4400
        public void Init(){} // RVA: 0x7AE7F4430
        public void Validate(){} // RVA: 0x7AE7F4C70
        public void CompleteValidation(){} // RVA: 0x7AE7F4D50
        public void get_IsInlineSchemaStarted(){} // RVA: 0x7AE7888D0
        public void ProcessInlineSchema(){} // RVA: 0x7AE7F4EF0
        public void ValidateElement(){} // RVA: 0x7AE7F51C0
        public void ValidateChildElement(){} // RVA: 0x7AE7F53D0
        public void ProcessElement(){} // RVA: 0x7AE7F5650
        public void ProcessXsiAttributes(){} // RVA: 0x7AE7F5AA0
        public void ValidateEndElement(){} // RVA: 0x7AE7F63C0
        public void FastGetElementDecl(){} // RVA: 0x7AE7F6620
        public void ThoroughGetElementDecl(){} // RVA: 0x7AE7F6710
        public void ValidateStartElement(){} // RVA: 0x7AE7F6C50
        public void ValidateEndStartElement(){} // RVA: 0x7AE7F75D0
        public void LoadSchemaFromLocation(){} // RVA: 0x7AE7F7A30
        public void LoadSchema(){} // RVA: 0x7AE7F8030
        public void get_HasSchema(){} // RVA: 0x7AE78A660
        public void get_PreserveWhitespace(){} // RVA: 0x7AE78A680
        public void ProcessTokenizedType(){} // RVA: 0x7AE7F8220
        public void CheckValue(){} // RVA: 0x7AE7F8520
        public void AddID(){} // RVA: 0x7AE7F8AC0
        public void FindId(){} // RVA: 0x7AE78B900
        public void IsXSDRoot(){} // RVA: 0x7AE7F8BC0
        public void Push(){} // RVA: 0x7AE7F8BE0
        public void Pop(){} // RVA: 0x7AE7F8F50
        public void CheckForwardRefs(){} // RVA: 0x7AE7F4D50
        public void ValidateStartElementIdentityConstraints(){} // RVA: 0x7AE7F90E0
        public void get_HasIdentityConstraints(){} // RVA: 0x7AE7F9140
        public void AddIdentityConstraints(){} // RVA: 0x7AE7F9150
        public void ElementIdentityConstraints(){} // RVA: 0x7AE7F9800
        public void AttributeIdentityConstraints(){} // RVA: 0x7AE7F9C30
        public void UnWrapUnion(){} // RVA: 0x7AE7F9FC0
        public void EndElementIdentityConstraints(){} // RVA: 0x7AE7FA030
        public void .cctor(){} // RVA: 0x7AE7FAD60
    }

}