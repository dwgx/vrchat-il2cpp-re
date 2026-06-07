// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 68
// Methods: 438

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class DatatypeImplementation
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6AE2D20
        public void get_AnySimpleType(){} // RVA: 0x6AE8C70
        public void get_UntypedAtomicType(){} // RVA: 0x6AE8CD0
        public void FromXmlTokenizedType(){} // RVA: 0x6AE8D30
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x6AE8DB0
        public void FromXdrName(){} // RVA: 0x6AE8E30
        public void FromTypeName(){} // RVA: 0x6AE8FC0
        public void StartBuiltinType(){} // RVA: 0x6AE9150
        public void FinishBuiltinType(){} // RVA: 0x6AE9390
        public void CreateBuiltinTypes(){} // RVA: 0x6AE97E0
        public void GetSimpleTypeFromTypeCode(){} // RVA: 0x6AEAA00
        public void GetSimpleTypeFromXsdType(){} // RVA: 0x6AEAA80
        public void GetNormalizedStringTypeV1Compat(){} // RVA: 0x6AEAB50
        public void GetTokenTypeV1Compat(){} // RVA: 0x6AEAEC0
        public void GetBuiltInTypes(){} // RVA: 0x6AEB230
        public void GetPrimitiveTypeCode(){} // RVA: 0x6AEB290
        public void DeriveByRestriction(){} // RVA: 0x6AEB400
        public void DeriveByList(){} // RVA: 0x6AEB660 | overloaded x2
        public void DeriveByUnion(){} // RVA: 0x6AEBA80
        public void VerifySchemaValid(){} // RVA: 0x2DD310
        public void IsDerivedFrom(){} // RVA: 0x6AEBC80
        public void IsEqual(){} // RVA: 0x6AEBF70
        public void IsComparable(){} // RVA: 0x6AEBFA0
        public void CreateValueConverter(){} // RVA: 0x519240
        public void get_FacetsChecker(){} // RVA: 0x6AEC0A0
        public void get_ValueConverter(){} // RVA: 0x6AEC100
        public void get_TokenizedType(){} // RVA: 0x210E2A0
        public void get_ValueType(){} // RVA: 0x6AEC190
        public void get_Variety(){} // RVA: 0x32A5C0
        public void get_TypeCode(){} // RVA: 0x519240
        public void get_Restriction(){} // RVA: 0x2E07C0
        public void get_HasLexicalFacets(){} // RVA: 0x6AEC240
        public void get_HasValueFacets(){} // RVA: 0x6AEC260
        public void get_Base(){} // RVA: 0x30B0C0
        public void get_ListValueType(){} // RVA: 0xCD60
        public void get_ValidRestrictionFlags(){} // RVA: 0xD840
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x519240
        public void ParseValue(){} // RVA: 0x6AEC490 | overloaded x2
        public void TryParseValue(){} // RVA: 0x6AEC630
        public void GetTypeName(){} // RVA: 0x6AECA10
        public void Compare(){} // RVA: 0x6AECA90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Datatype_ENTITY
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6AF4F90
        public void get_TokenizedType(){} // RVA: 0xA7E130
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_ENUMERATION
    {
        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x1730F70
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_ID
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6AF4F80
        public void get_TokenizedType(){} // RVA: 0x3CFAF0
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_IDREF
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6601C20
        public void get_TokenizedType(){} // RVA: 0x3E2CB0
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_List
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AECC20
        public void .ctor(){} // RVA: 0x6AED1A0
        public void Compare(){} // RVA: 0x6AED290
        public void get_ValueType(){} // RVA: 0x6AED570
        public void get_TokenizedType(){} // RVA: 0x6AED590
        public void get_ListValueType(){} // RVA: 0x6AED5C0
        public void get_FacetsChecker(){} // RVA: 0x6AED5F0
        public void get_TypeCode(){} // RVA: 0x36A5B60
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void TryParseValue(){} // RVA: 0x6AEDC80 | overloaded x2
    }

    public class Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x2111860
        public void TryParseValue(){} // RVA: 0x6AF4D90
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_NMTOKEN
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6A21BD0
        public void get_TokenizedType(){} // RVA: 0xA850E0
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_NOTATION
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF1570
        public void get_FacetsChecker(){} // RVA: 0x6AF4FA0
        public void get_TypeCode(){} // RVA: 0x21119B0
        public void get_TokenizedType(){} // RVA: 0xA63AE0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void get_ValueType(){} // RVA: 0x6AF5000
        public void get_ListValueType(){} // RVA: 0x6AF5060
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void TryParseValue(){} // RVA: 0x6AF50C0
        public void VerifySchemaValid(){} // RVA: 0x6AF5300
        public void .ctor(){} // RVA: 0x6AF55B0
        public void .cctor(){} // RVA: 0x6AF5630
    }

    public class Datatype_Name
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6AF4D80
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_QName
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF1570
        public void get_FacetsChecker(){} // RVA: 0x6AF4770
        public void get_TypeCode(){} // RVA: 0x2111970
        public void get_TokenizedType(){} // RVA: 0x5B1C70
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void get_ValueType(){} // RVA: 0x6AF47D0
        public void get_ListValueType(){} // RVA: 0x6AF4830
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void TryParseValue(){} // RVA: 0x6AF4890
        public void .ctor(){} // RVA: 0x6AF4AD0
        public void .cctor(){} // RVA: 0x6AF4B50
    }

    public class Datatype_QNameXdr
    {
        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x5B1C70
        public void ParseValue(){} // RVA: 0x6AFAB10
        public void get_ValueType(){} // RVA: 0x6AFAD30
        public void get_ListValueType(){} // RVA: 0x6AFAD90
        public void .ctor(){} // RVA: 0x6AFADF0
        public void .cctor(){} // RVA: 0x6AFAE70
    }

    public class Datatype_anyAtomicType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AEF590
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x519240
        public void get_TypeCode(){} // RVA: 0x5B1C70
        public void .ctor(){} // RVA: 0x6AEF5F0
    }

    public class Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AEF020
        public void get_FacetsChecker(){} // RVA: 0x6AEF080
        public void get_ValueType(){} // RVA: 0x6AEF0E0
        public void get_TypeCode(){} // RVA: 0x5B1C70
        public void get_ListValueType(){} // RVA: 0x6AEF140
        public void get_TokenizedType(){} // RVA: 0x210E2A0
        public void get_ValidRestrictionFlags(){} // RVA: 0x519240
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void Compare(){} // RVA: 0x6AEF1A0
        public void TryParseValue(){} // RVA: 0x6AEF2B0
        public void .ctor(){} // RVA: 0x6AEF320
        public void .cctor(){} // RVA: 0x6AEF370
    }

    public class Datatype_anyURI
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF1570
        public void get_FacetsChecker(){} // RVA: 0x6AF40E0
        public void get_TypeCode(){} // RVA: 0xF00450
        public void get_ValueType(){} // RVA: 0x6AF4140
        public void get_HasValueFacets(){} // RVA: 0x3C2850
        public void get_ListValueType(){} // RVA: 0x6AF41A0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void Compare(){} // RVA: 0x6AF4200
        public void TryParseValue(){} // RVA: 0x6AF42D0
        public void .ctor(){} // RVA: 0x6AF44D0
        public void .cctor(){} // RVA: 0x6AF4550
    }

    public class Datatype_base64Binary
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF1570
        public void get_FacetsChecker(){} // RVA: 0x6AF3970
        public void get_TypeCode(){} // RVA: 0x6AF39D0
        public void get_ValueType(){} // RVA: 0x6AF39E0
        public void get_ListValueType(){} // RVA: 0x6AF3A40
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void Compare(){} // RVA: 0x6AF3AA0
        public void TryParseValue(){} // RVA: 0x6AF3BC0
        public void .ctor(){} // RVA: 0x6AF3E40
        public void .cctor(){} // RVA: 0x6AF3EC0
    }

    public class Datatype_boolean
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AEFA00
        public void get_FacetsChecker(){} // RVA: 0x6AEFA90
        public void get_TypeCode(){} // RVA: 0x116E0E0
        public void get_ValueType(){} // RVA: 0x6AEFAF0
        public void get_ListValueType(){} // RVA: 0x6AEFB50
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x210E2E0
        public void Compare(){} // RVA: 0x6AEFBB0
        public void TryParseValue(){} // RVA: 0x6AEFC40
        public void .ctor(){} // RVA: 0x6AEFEF0
        public void .cctor(){} // RVA: 0x6AEFF70
    }

    public class Datatype_byte
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF77E0
        public void get_TypeCode(){} // RVA: 0x65B0FF0
        public void Compare(){} // RVA: 0x6AF7840
        public void get_ValueType(){} // RVA: 0x6AF7970
        public void get_ListValueType(){} // RVA: 0x6AF79D0
        public void TryParseValue(){} // RVA: 0x6AF7A30
        public void .ctor(){} // RVA: 0x6AF7CF0
        public void .cctor(){} // RVA: 0x6AF7D80
    }

    public class Datatype_char
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x6AFB090
        public void get_ListValueType(){} // RVA: 0x6AFB0F0
        public void get_ValidRestrictionFlags(){} // RVA: 0x519240
        public void Compare(){} // RVA: 0x6AFB150
        public void ParseValue(){} // RVA: 0x6AFB290
        public void TryParseValue(){} // RVA: 0x6AFB4B0
        public void .ctor(){} // RVA: 0x6AFB830
        public void .cctor(){} // RVA: 0x6AFB8B0
    }

    public class Datatype_date
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x5FAB20
        public void .ctor(){} // RVA: 0x6AF2FF0
    }

    public class Datatype_dateTime
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF2E70
    }

    public class Datatype_dateTimeBase
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF2260
        public void get_FacetsChecker(){} // RVA: 0x6AF22F0
        public void get_TypeCode(){} // RVA: 0x16803D0
        public void .ctor(){} // RVA: 0x6AF2350
        public void get_ValueType(){} // RVA: 0x6AF23E0
        public void get_ListValueType(){} // RVA: 0x6AF2440
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AF02C0
        public void Compare(){} // RVA: 0x6AF24A0
        public void TryParseValue(){} // RVA: 0x6AF26F0
        public void .cctor(){} // RVA: 0x6AF2B90
    }

    public class Datatype_dateTimeNoTimeZone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF2DB0
    }

    public class Datatype_dateTimeTimeZone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF2E10
    }

    public class Datatype_day
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x210E290
        public void .ctor(){} // RVA: 0x6AF3170
    }

    public class Datatype_dayTimeDuration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x6AF1F90
        public void get_TypeCode(){} // RVA: 0x6AF2200
        public void .ctor(){} // RVA: 0x6AF2210
    }

    public class Datatype_decimal
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF0DF0
        public void get_FacetsChecker(){} // RVA: 0x6AF0E80
        public void get_TypeCode(){} // RVA: 0x174E930
        public void get_ValueType(){} // RVA: 0x6AF0EE0
        public void get_ListValueType(){} // RVA: 0x6AF0F40
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AF0FA0
        public void Compare(){} // RVA: 0x6AF0FB0
        public void TryParseValue(){} // RVA: 0x6AF1040
        public void .ctor(){} // RVA: 0x6AF1220
        public void .cctor(){} // RVA: 0x6AF12A0
    }

    public class Datatype_double
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF0190
        public void get_FacetsChecker(){} // RVA: 0x6AF07D0
        public void get_TypeCode(){} // RVA: 0x210E2B0
        public void get_ValueType(){} // RVA: 0x6AF0830
        public void get_ListValueType(){} // RVA: 0x6AF0890
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AF02C0
        public void Compare(){} // RVA: 0x6AF08F0
        public void TryParseValue(){} // RVA: 0x6AF0970
        public void .ctor(){} // RVA: 0x6AF0B50
        public void .cctor(){} // RVA: 0x6AF0BD0
    }

    public class Datatype_doubleXdr
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x6AFA6E0
        public void .ctor(){} // RVA: 0x6AFA8B0
    }

    public class Datatype_duration
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF1570
        public void get_FacetsChecker(){} // RVA: 0x6AF1580
        public void get_TypeCode(){} // RVA: 0x606D1A0
        public void get_ValueType(){} // RVA: 0x6AF15E0
        public void get_ListValueType(){} // RVA: 0x6AF1640
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AF02C0
        public void Compare(){} // RVA: 0x6AF16A0
        public void TryParseValue(){} // RVA: 0x6AF1730
        public void .ctor(){} // RVA: 0x6AF1A30
        public void .cctor(){} // RVA: 0x6AF1AB0
    }

    public class Datatype_fixed
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x6AFBAD0
        public void TryParseValue(){} // RVA: 0x6AFBDA0
        public void .ctor(){} // RVA: 0x6AFBFE0
    }

    public class Datatype_float
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF0190
        public void get_FacetsChecker(){} // RVA: 0x6AF01A0
        public void get_TypeCode(){} // RVA: 0x13ADE30
        public void get_ValueType(){} // RVA: 0x6AF0200
        public void get_ListValueType(){} // RVA: 0x6AF0260
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AF02C0
        public void Compare(){} // RVA: 0x6AF02D0
        public void TryParseValue(){} // RVA: 0x6AF0350
        public void .ctor(){} // RVA: 0x6AF0530
        public void .cctor(){} // RVA: 0x6AF05B0
    }

    public class Datatype_floatXdr
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x6AFA900
        public void .ctor(){} // RVA: 0x6AFAAC0
    }

    public class Datatype_hexBinary
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AF1570
        public void get_FacetsChecker(){} // RVA: 0x6AF3230
        public void get_TypeCode(){} // RVA: 0x6AF3290
        public void get_ValueType(){} // RVA: 0x6AF32A0
        public void get_ListValueType(){} // RVA: 0x6AF3300
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void Compare(){} // RVA: 0x6AF3360
        public void TryParseValue(){} // RVA: 0x6AF3480
        public void .ctor(){} // RVA: 0x6AF36D0
        public void .cctor(){} // RVA: 0x6AF3750
    }

    public class Datatype_int
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF6690
        public void get_TypeCode(){} // RVA: 0x2111950
        public void Compare(){} // RVA: 0x6AF66F0
        public void get_ValueType(){} // RVA: 0x6AF6770
        public void get_ListValueType(){} // RVA: 0x6AF67D0
        public void TryParseValue(){} // RVA: 0x6AF6830
        public void .ctor(){} // RVA: 0x6AF6C40
        public void .cctor(){} // RVA: 0x6AF6CD0
    }

    public class Datatype_integer
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x210E2E0
        public void TryParseValue(){} // RVA: 0x6AF5850
        public void .ctor(){} // RVA: 0x6AF5A00
    }

    public class Datatype_language
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6601100
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_long
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF5DF0
        public void get_HasValueFacets(){} // RVA: 0x3C2850
        public void get_TypeCode(){} // RVA: 0x6AF5E50
        public void Compare(){} // RVA: 0x6AF5E60
        public void get_ValueType(){} // RVA: 0x6AF5EE0
        public void get_ListValueType(){} // RVA: 0x6AF5F40
        public void TryParseValue(){} // RVA: 0x6AF5FA0
        public void .ctor(){} // RVA: 0x6AF5A00
        public void .cctor(){} // RVA: 0x6AF63B0
    }

    public class Datatype_month
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x21119E0
        public void .ctor(){} // RVA: 0x6AF31D0
    }

    public class Datatype_monthDay
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x9FD990
        public void .ctor(){} // RVA: 0x6AF3110
    }

    public class Datatype_negativeInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF5BD0
        public void get_TypeCode(){} // RVA: 0x6AF5C30
        public void .ctor(){} // RVA: 0x6AF5C40
        public void .cctor(){} // RVA: 0x6AF5CD0
    }

    public class Datatype_nonNegativeInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF8050
        public void get_TypeCode(){} // RVA: 0x5E61600
        public void get_HasValueFacets(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x6AF5A00
        public void .cctor(){} // RVA: 0x6AF80B0
    }

    public class Datatype_nonPositiveInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF5A50
        public void get_TypeCode(){} // RVA: 0x6AF5AB0
        public void get_HasValueFacets(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x6AF5A00
        public void .cctor(){} // RVA: 0x6AF5AC0
    }

    public class Datatype_normalizedString
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6601270
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3CFAF0
        public void get_HasValueFacets(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_normalizedStringV1Compat
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x6601270
        public void get_HasValueFacets(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_positiveInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AFA4F0
        public void get_TypeCode(){} // RVA: 0x21118C0
        public void .ctor(){} // RVA: 0x6AFA550
        public void .cctor(){} // RVA: 0x6AFA5E0
    }

    public class Datatype_short
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF6FB0
        public void get_TypeCode(){} // RVA: 0x6AF7010
        public void Compare(){} // RVA: 0x6AF7020
        public void get_ValueType(){} // RVA: 0x6AF7150
        public void get_ListValueType(){} // RVA: 0x6AF71B0
        public void TryParseValue(){} // RVA: 0x6AF7210
        public void .ctor(){} // RVA: 0x6AF74C0
        public void .cctor(){} // RVA: 0x6AF7510
    }

    public class Datatype_string
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AEF6E0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x519240
        public void get_FacetsChecker(){} // RVA: 0x6AEF770
        public void get_TypeCode(){} // RVA: 0x210E2A0
        public void get_TokenizedType(){} // RVA: 0x519240
        public void get_ValidRestrictionFlags(){} // RVA: 0x6AED650
        public void TryParseValue(){} // RVA: 0x6AEF7D0
        public void .ctor(){} // RVA: 0x6AEF980
    }

    public class Datatype_time
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x1701AB0
        public void .ctor(){} // RVA: 0x6AF2F90
    }

    public class Datatype_timeNoTimeZone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF2ED0
    }

    public class Datatype_timeTimeZone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF2F30
    }

    public class Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x210E300
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x3E2CB0
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_tokenV1Compat
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x210E300
        public void .ctor(){} // RVA: 0x6AF4D70
    }

    public class Datatype_union
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AEE1E0
        public void .ctor(){} // RVA: 0x6AEE240
        public void Compare(){} // RVA: 0x6AEE310
        public void get_ValueType(){} // RVA: 0x6AEE420
        public void get_TypeCode(){} // RVA: 0x5B1C70
        public void get_FacetsChecker(){} // RVA: 0x6AEE480
        public void get_ListValueType(){} // RVA: 0x6AEE4E0
        public void get_ValidRestrictionFlags(){} // RVA: 0x210E290
        public void get_BaseMemberTypes(){} // RVA: 0x4976A0
        public void HasAtomicMembers(){} // RVA: 0x6AEE540
        public void IsUnionBaseOf(){} // RVA: 0x6AEE5E0
        public void TryParseValue(){} // RVA: 0x6AEE940 | overloaded x2
        public void .cctor(){} // RVA: 0x6AEEE00
    }

    public class Datatype_unsignedByte
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF9CA0
        public void get_TypeCode(){} // RVA: 0x65E6220
        public void Compare(){} // RVA: 0x6AF9D00
        public void get_ValueType(){} // RVA: 0x6AF9E30
        public void get_ListValueType(){} // RVA: 0x6AF9E90
        public void TryParseValue(){} // RVA: 0x6AF9EF0
        public void .ctor(){} // RVA: 0x6AFA1B0
        public void .cctor(){} // RVA: 0x6AFA200
    }

    public class Datatype_unsignedInt
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF8B30
        public void get_TypeCode(){} // RVA: 0x2111910
        public void Compare(){} // RVA: 0x6AF8B90
        public void get_ValueType(){} // RVA: 0x6AF8C10
        public void get_ListValueType(){} // RVA: 0x6AF8C70
        public void TryParseValue(){} // RVA: 0x6AF8CD0
        public void .ctor(){} // RVA: 0x6AF90E0
        public void .cctor(){} // RVA: 0x6AF9130
    }

    public class Datatype_unsignedLong
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF81B0
        public void get_TypeCode(){} // RVA: 0x210E2D0
        public void Compare(){} // RVA: 0x6AF8210
        public void get_ValueType(){} // RVA: 0x6AF8290
        public void get_ListValueType(){} // RVA: 0x6AF82F0
        public void TryParseValue(){} // RVA: 0x6AF8350
        public void .ctor(){} // RVA: 0x6AF87B0
        public void .cctor(){} // RVA: 0x6AF8840
    }

    public class Datatype_unsignedShort
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x6AF9420
        public void get_TypeCode(){} // RVA: 0x5B1C80
        public void Compare(){} // RVA: 0x6AF9480
        public void get_ValueType(){} // RVA: 0x6AF95B0
        public void get_ListValueType(){} // RVA: 0x6AF9610
        public void TryParseValue(){} // RVA: 0x6AF9670
        public void .ctor(){} // RVA: 0x6AF9920
        public void .cctor(){} // RVA: 0x6AF99B0
    }

    public class Datatype_untypedAtomicType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x6AEF670
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x519240
        public void get_TypeCode(){} // RVA: 0x5E9A940
        public void .ctor(){} // RVA: 0x6AEF6D0
    }

    public class Datatype_uuid
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x6AFC030
        public void get_ListValueType(){} // RVA: 0x6AFC090
        public void get_ValidRestrictionFlags(){} // RVA: 0x519240
        public void Compare(){} // RVA: 0x6AFC0F0
        public void ParseValue(){} // RVA: 0x6AFC230
        public void TryParseValue(){} // RVA: 0x6AFC4A0
        public void .ctor(){} // RVA: 0x6AFC5F0
        public void .cctor(){} // RVA: 0x6AFC670
    }

    public class Datatype_year
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x5D5200
        public void .ctor(){} // RVA: 0x6AF30B0
    }

    public class Datatype_yearMonth
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0xE87380
        public void .ctor(){} // RVA: 0x6AF3050
    }

    public class Datatype_yearMonthDuration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x6AF1CD0
        public void get_TypeCode(){} // RVA: 0xFE5FD0
        public void .ctor(){} // RVA: 0x6AF1F40
    }

    public class DateTimeFacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x6B07D50 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x6B08240 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DfaContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADF450
        public void InitValidation(){} // RVA: 0x6ADF580
        public void ValidateElement(){} // RVA: 0x6ADF5E0
        public void CompleteValidation(){} // RVA: 0x6ADF730
        public void ExpectedElements(){} // RVA: 0x6ADF750
        public void ExpectedParticles(){} // RVA: 0x6ADF940
    }

    public class DoubleLinkAxis
    {
        // ── Methods ──
        public void get_Next(){} // RVA: 0x35A740
        public void set_Next(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x6AD0380
        public void ConvertTree(){} // RVA: 0x6AD04F0
    }

    public class DtdValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AFC890
        public void Init(){} // RVA: 0x6AFC990
        public void Validate(){} // RVA: 0x6AFCC90
        public void MeetsStandAloneConstraint(){} // RVA: 0x6AFD070
        public void ValidatePIComment(){} // RVA: 0x6AFD110
        public void ValidateElement(){} // RVA: 0x6AFD200
        public void ValidateChildElement(){} // RVA: 0x6AFD500
        public void ValidateStartElement(){} // RVA: 0x6AFD6D0
        public void ValidateEndStartElement(){} // RVA: 0x6AFDD30
        public void ProcessElement(){} // RVA: 0x6AFDF40
        public void CompleteValidation(){} // RVA: 0x6AFE180
        public void ValidateEndElement(){} // RVA: 0x6AFE340
        public void get_PreserveWhitespace(){} // RVA: 0x699BC40
        public void ProcessTokenizedType(){} // RVA: 0x6AFE5B0
        public void CheckValue(){} // RVA: 0x6AFE8D0
        public void AddID(){} // RVA: 0x6AFEF30
        public void FindId(){} // RVA: 0x6AFF030
        public void GenEntity(){} // RVA: 0x6AFF060
        public void GetEntity(){} // RVA: 0x6AFF270
        public void CheckForwardRefs(){} // RVA: 0x6AFF330
        public void Push(){} // RVA: 0x6AFF4D0
        public void Pop(){} // RVA: 0x6AFF7C0
        public void SetDefaultTypedValue(){} // RVA: 0x6AFF910
        public void CheckDefaultValue(){} // RVA: 0x6AFFBC0
        public void .cctor(){} // RVA: 0x6AFFF10
    }

    public class DurationFacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x6B077D0 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x6B07BD0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

}