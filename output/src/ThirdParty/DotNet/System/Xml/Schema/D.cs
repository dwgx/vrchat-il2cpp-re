// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 68
// Methods: 430

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class DatatypeImplementation : XmlSchemaDatatype
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE8D32C0
        public void get_AnySimpleType(){} // RVA: 0x7AE8D9210
        public void get_UntypedAtomicType(){} // RVA: 0x7AE8D9270
        public void FromXmlTokenizedType(){} // RVA: 0x7AE8D92D0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7AE8D9350
        public void FromXdrName(){} // RVA: 0x7AE8D93D0
        public void FromTypeName(){} // RVA: 0x7AE8D9560
        public void StartBuiltinType(){} // RVA: 0x7AE8D96F0
        public void FinishBuiltinType(){} // RVA: 0x7AE8D9930
        public void CreateBuiltinTypes(){} // RVA: 0x7AE8D9D80
        public void GetSimpleTypeFromTypeCode(){} // RVA: 0x7AE8DB050
        public void GetSimpleTypeFromXsdType(){} // RVA: 0x7AE8DB0D0
        public void GetNormalizedStringTypeV1Compat(){} // RVA: 0x7AE8DB1A0
        public void GetTokenTypeV1Compat(){} // RVA: 0x7AE8DB500
        public void GetBuiltInTypes(){} // RVA: 0x7AE8DB860
        public void GetPrimitiveTypeCode(){} // RVA: 0x7AE8DB8C0
        public void DeriveByRestriction(){} // RVA: 0x7AE8DBA30
        public void DeriveByList(){} // RVA: 0x7AE8DBC90
        public void DeriveByUnion(){} // RVA: 0x7AE8DC0C0
        public void VerifySchemaValid(){} // RVA: 0x7A80D7310
        public void IsDerivedFrom(){} // RVA: 0x7AE8DC2C0
        public void IsEqual(){} // RVA: 0x7AE8DC590
        public void IsComparable(){} // RVA: 0x7AE8DC5C0
        public void CreateValueConverter(){} // RVA: 0x7A82D1450
        public void get_FacetsChecker(){} // RVA: 0x7AE8DC6C0
        public void get_ValueConverter(){} // RVA: 0x7AE8DC720
        public void get_TokenizedType(){} // RVA: 0x7A9F22B10
        public void get_ValueType(){} // RVA: 0x7AE8DC7B0
        public void get_Variety(){} // RVA: 0x7A8124910
        public void get_TypeCode(){} // RVA: 0x7A82D1450
        public void get_Restriction(){} // RVA: 0x7A80DA7B0
        public void get_HasLexicalFacets(){} // RVA: 0x7AE8DC860
        public void get_HasValueFacets(){} // RVA: 0x7AE8DC880
        public void get_Base(){} // RVA: 0x7A81052C0
        public void get_ListValueType(){} // RVA: 0x7A7E00680
        public void get_ValidRestrictionFlags(){} // RVA: 0x7A7E00710
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A82D1450
        public void ParseValue(){} // RVA: 0x7AE8DCAB0
        public void TryParseValue(){} // RVA: 0x7AE8DCC50
        public void GetTypeName(){} // RVA: 0x7AE8DD030
        public void Compare(){} // RVA: 0x7AE8DD0B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Datatype_ENTITY : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE8E5600
        public void get_TokenizedType(){} // RVA: 0x7A883BE70
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_ENUMERATION : Datatype_NMTOKEN
    {
        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x7A94EBBC0
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_ID : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE8E55F0
        public void get_TokenizedType(){} // RVA: 0x7A81CA9D0
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_IDREF : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE3F0410
        public void get_TokenizedType(){} // RVA: 0x7A81DDCC0
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_List : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8DD240
        public void .ctor(){} // RVA: 0x7AE8DD780
        public void Compare(){} // RVA: 0x7AE8DD870
        public void get_ValueType(){} // RVA: 0x7AE8DDB60
        public void get_TokenizedType(){} // RVA: 0x7AE8DDB80
        public void get_ListValueType(){} // RVA: 0x7AE8DDBB0
        public void get_FacetsChecker(){} // RVA: 0x7AE8DDBE0
        public void get_TypeCode(){} // RVA: 0x7AB48B0A0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void TryParseValue(){} // RVA: 0x7AE8DE270
    }

    public class Datatype_NCName : Datatype_Name
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A9F26070
        public void TryParseValue(){} // RVA: 0x7AE8E5400
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_NMTOKEN : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE811E30
        public void get_TokenizedType(){} // RVA: 0x7A8842E60
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_NOTATION : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1BC0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E5610
        public void get_TypeCode(){} // RVA: 0x7A9F261C0
        public void get_TokenizedType(){} // RVA: 0x7A88217C0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void get_ValueType(){} // RVA: 0x7AE8E5670
        public void get_ListValueType(){} // RVA: 0x7AE8E56D0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void TryParseValue(){} // RVA: 0x7AE8E5730
        public void VerifySchemaValid(){} // RVA: 0x7AE8E5970
        public void .ctor(){} // RVA: 0x7AE8E5C20
        public void .cctor(){} // RVA: 0x7AE8E5CA0
    }

    public class Datatype_Name : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE8E53F0
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_QName : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1BC0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E4DE0
        public void get_TypeCode(){} // RVA: 0x7A9F26180
        public void get_TokenizedType(){} // RVA: 0x7A836B0A0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void get_ValueType(){} // RVA: 0x7AE8E4E40
        public void get_ListValueType(){} // RVA: 0x7AE8E4EA0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void TryParseValue(){} // RVA: 0x7AE8E4F00
        public void .ctor(){} // RVA: 0x7AE8E5140
        public void .cctor(){} // RVA: 0x7AE8E51C0
    }

    public class Datatype_QNameXdr : Datatype_anySimpleType
    {
        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x7A836B0A0
        public void ParseValue(){} // RVA: 0x7AE8EB2D0
        public void get_ValueType(){} // RVA: 0x7AE8EB4F0
        public void get_ListValueType(){} // RVA: 0x7AE8EB550
        public void .ctor(){} // RVA: 0x7AE8EB5B0
        public void .cctor(){} // RVA: 0x7AE8EB630
    }

    public class Datatype_anyAtomicType : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8DFBE0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A82D1450
        public void get_TypeCode(){} // RVA: 0x7A836B0A0
        public void .ctor(){} // RVA: 0x7AE8DFC40
    }

    public class Datatype_anySimpleType : DatatypeImplementation
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8DF670
        public void get_FacetsChecker(){} // RVA: 0x7AE8DF6D0
        public void get_ValueType(){} // RVA: 0x7AE8DF730
        public void get_TypeCode(){} // RVA: 0x7A836B0A0
        public void get_ListValueType(){} // RVA: 0x7AE8DF790
        public void get_TokenizedType(){} // RVA: 0x7A9F22B10
        public void get_ValidRestrictionFlags(){} // RVA: 0x7A82D1450
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void Compare(){} // RVA: 0x7AE8DF7F0
        public void TryParseValue(){} // RVA: 0x7AE8DF900
        public void .ctor(){} // RVA: 0x7AE8DF970
        public void .cctor(){} // RVA: 0x7AE8DF9C0
    }

    public class Datatype_anyURI : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1BC0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E4750
        public void get_TypeCode(){} // RVA: 0x7A8CCA610
        public void get_ValueType(){} // RVA: 0x7AE8E47B0
        public void get_HasValueFacets(){} // RVA: 0x7A81BD750
        public void get_ListValueType(){} // RVA: 0x7AE8E4810
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void Compare(){} // RVA: 0x7AE8E4870
        public void TryParseValue(){} // RVA: 0x7AE8E4940
        public void .ctor(){} // RVA: 0x7AE8E4B40
        public void .cctor(){} // RVA: 0x7AE8E4BC0
    }

    public class Datatype_base64Binary : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1BC0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E3FD0
        public void get_TypeCode(){} // RVA: 0x7AE8E4030
        public void get_ValueType(){} // RVA: 0x7AE8E4040
        public void get_ListValueType(){} // RVA: 0x7AE8E40A0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void Compare(){} // RVA: 0x7AE8E4100
        public void TryParseValue(){} // RVA: 0x7AE8E4230
        public void .ctor(){} // RVA: 0x7AE8E44B0
        public void .cctor(){} // RVA: 0x7AE8E4530
    }

    public class Datatype_boolean : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E0050
        public void get_FacetsChecker(){} // RVA: 0x7AE8E00E0
        public void get_TypeCode(){} // RVA: 0x7A8F279F0
        public void get_ValueType(){} // RVA: 0x7AE8E0140
        public void get_ListValueType(){} // RVA: 0x7AE8E01A0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7A9F22B50
        public void Compare(){} // RVA: 0x7AE8E0200
        public void TryParseValue(){} // RVA: 0x7AE8E0290
        public void .ctor(){} // RVA: 0x7AE8E0540
        public void .cctor(){} // RVA: 0x7AE8E05C0
    }

    public class Datatype_byte : Datatype_short
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E7FD0
        public void get_TypeCode(){} // RVA: 0x7AE39F500
        public void Compare(){} // RVA: 0x7AE8E8030
        public void get_ValueType(){} // RVA: 0x7AE8E8160
        public void get_ListValueType(){} // RVA: 0x7AE8E81C0
        public void TryParseValue(){} // RVA: 0x7AE8E8220
        public void .ctor(){} // RVA: 0x7AE8E84D0
        public void .cctor(){} // RVA: 0x7AE8E8560
    }

    public class Datatype_char : Datatype_anySimpleType
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7AE8EB850
        public void get_ListValueType(){} // RVA: 0x7AE8EB8B0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7A82D1450
        public void Compare(){} // RVA: 0x7AE8EB910
        public void ParseValue(){} // RVA: 0x7AE8EBA50
        public void TryParseValue(){} // RVA: 0x7AE8EBC70
        public void .ctor(){} // RVA: 0x7AE8EBFF0
        public void .cctor(){} // RVA: 0x7AE8EC070
    }

    public class Datatype_date : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A83B4040
        public void .ctor(){} // RVA: 0x7AE8E3640
    }

    public class Datatype_dateTime : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8E34C0
    }

    public class Datatype_dateTimeBase : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E28B0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E2940
        public void get_TypeCode(){} // RVA: 0x7A943A740
        public void .ctor(){} // RVA: 0x7AE8E29A0
        public void get_ValueType(){} // RVA: 0x7AE8E2A30
        public void get_ListValueType(){} // RVA: 0x7AE8E2A90
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8E0910
        public void Compare(){} // RVA: 0x7AE8E2AF0
        public void TryParseValue(){} // RVA: 0x7AE8E2D40
        public void .cctor(){} // RVA: 0x7AE8E31E0
    }

    public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8E3400
    }

    public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8E3460
    }

    public class Datatype_day : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A9F22B00
        public void .ctor(){} // RVA: 0x7AE8E37C0
    }

    public class Datatype_dayTimeDuration : Datatype_duration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7AE8E25E0
        public void get_TypeCode(){} // RVA: 0x7AE8E2850
        public void .ctor(){} // RVA: 0x7AE8E2860
    }

    public class Datatype_decimal : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1440
        public void get_FacetsChecker(){} // RVA: 0x7AE8E14D0
        public void get_TypeCode(){} // RVA: 0x7A95096B0
        public void get_ValueType(){} // RVA: 0x7AE8E1530
        public void get_ListValueType(){} // RVA: 0x7AE8E1590
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8E15F0
        public void Compare(){} // RVA: 0x7AE8E1600
        public void TryParseValue(){} // RVA: 0x7AE8E1690
        public void .ctor(){} // RVA: 0x7AE8E1870
        public void .cctor(){} // RVA: 0x7AE8E18F0
    }

    public class Datatype_double : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E07E0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E0E20
        public void get_TypeCode(){} // RVA: 0x7A9F22B20
        public void get_ValueType(){} // RVA: 0x7AE8E0E80
        public void get_ListValueType(){} // RVA: 0x7AE8E0EE0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8E0910
        public void Compare(){} // RVA: 0x7AE8E0F40
        public void TryParseValue(){} // RVA: 0x7AE8E0FC0
        public void .ctor(){} // RVA: 0x7AE8E11A0
        public void .cctor(){} // RVA: 0x7AE8E1220
    }

    public class Datatype_doubleXdr : Datatype_double
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7AE8EAEA0
        public void .ctor(){} // RVA: 0x7AE8EB070
    }

    public class Datatype_duration : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1BC0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E1BD0
        public void get_TypeCode(){} // RVA: 0x7ADE594F0
        public void get_ValueType(){} // RVA: 0x7AE8E1C30
        public void get_ListValueType(){} // RVA: 0x7AE8E1C90
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8E0910
        public void Compare(){} // RVA: 0x7AE8E1CF0
        public void TryParseValue(){} // RVA: 0x7AE8E1D80
        public void .ctor(){} // RVA: 0x7AE8E2080
        public void .cctor(){} // RVA: 0x7AE8E2100
    }

    public class Datatype_fixed : Datatype_decimal
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7AE8EC290
        public void TryParseValue(){} // RVA: 0x7AE8EC560
        public void .ctor(){} // RVA: 0x7AE8EC7B0
    }

    public class Datatype_float : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E07E0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E07F0
        public void get_TypeCode(){} // RVA: 0x7A9165BB0
        public void get_ValueType(){} // RVA: 0x7AE8E0850
        public void get_ListValueType(){} // RVA: 0x7AE8E08B0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8E0910
        public void Compare(){} // RVA: 0x7AE8E0920
        public void TryParseValue(){} // RVA: 0x7AE8E09A0
        public void .ctor(){} // RVA: 0x7AE8E0B80
        public void .cctor(){} // RVA: 0x7AE8E0C00
    }

    public class Datatype_floatXdr : Datatype_float
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7AE8EB0C0
        public void .ctor(){} // RVA: 0x7AE8EB280
    }

    public class Datatype_hexBinary : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8E1BC0
        public void get_FacetsChecker(){} // RVA: 0x7AE8E3880
        public void get_TypeCode(){} // RVA: 0x7AE8E38E0
        public void get_ValueType(){} // RVA: 0x7AE8E38F0
        public void get_ListValueType(){} // RVA: 0x7AE8E3950
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void Compare(){} // RVA: 0x7AE8E39B0
        public void TryParseValue(){} // RVA: 0x7AE8E3AE0
        public void .ctor(){} // RVA: 0x7AE8E3D30
        public void .cctor(){} // RVA: 0x7AE8E3DB0
    }

    public class Datatype_int : Datatype_long
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E6E90
        public void get_TypeCode(){} // RVA: 0x7A9F26160
        public void Compare(){} // RVA: 0x7AE8E6EF0
        public void get_ValueType(){} // RVA: 0x7AE8E6F70
        public void get_ListValueType(){} // RVA: 0x7AE8E6FD0
        public void TryParseValue(){} // RVA: 0x7AE8E7030
        public void .ctor(){} // RVA: 0x7AE8E7430
        public void .cctor(){} // RVA: 0x7AE8E74C0
    }

    public class Datatype_integer : Datatype_decimal
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A9F22B50
        public void TryParseValue(){} // RVA: 0x7AE8E5EC0
        public void .ctor(){} // RVA: 0x7AE8E6200
    }

    public class Datatype_language : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE3EF8F0
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_long : Datatype_integer
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E65F0
        public void get_HasValueFacets(){} // RVA: 0x7A81BD750
        public void get_TypeCode(){} // RVA: 0x7AE8E6650
        public void Compare(){} // RVA: 0x7AE8E6660
        public void get_ValueType(){} // RVA: 0x7AE8E66E0
        public void get_ListValueType(){} // RVA: 0x7AE8E6740
        public void TryParseValue(){} // RVA: 0x7AE8E67A0
        public void .ctor(){} // RVA: 0x7AE8E6200
        public void .cctor(){} // RVA: 0x7AE8E6BB0
    }

    public class Datatype_month : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A9F261F0
        public void .ctor(){} // RVA: 0x7AE8E3820
    }

    public class Datatype_monthDay : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A87BABE0
        public void .ctor(){} // RVA: 0x7AE8E3760
    }

    public class Datatype_negativeInteger : Datatype_nonPositiveInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E63D0
        public void get_TypeCode(){} // RVA: 0x7AE8E6430
        public void .ctor(){} // RVA: 0x7AE8E6440
        public void .cctor(){} // RVA: 0x7AE8E64D0
    }

    public class Datatype_nonNegativeInteger : Datatype_integer
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E8830
        public void get_TypeCode(){} // RVA: 0x7ADC500C0
        public void get_HasValueFacets(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE8E6200
        public void .cctor(){} // RVA: 0x7AE8E8890
    }

    public class Datatype_nonPositiveInteger : Datatype_integer
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E6250
        public void get_TypeCode(){} // RVA: 0x7AE8E62B0
        public void get_HasValueFacets(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE8E6200
        public void .cctor(){} // RVA: 0x7AE8E62C0
    }

    public class Datatype_normalizedString : Datatype_string
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE3EFA60
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81CA9D0
        public void get_HasValueFacets(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_normalizedStringV1Compat : Datatype_string
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7AE3EFA60
        public void get_HasValueFacets(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_positiveInteger : Datatype_nonNegativeInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8EACB0
        public void get_TypeCode(){} // RVA: 0x7A9F260D0
        public void .ctor(){} // RVA: 0x7AE8EAD10
        public void .cctor(){} // RVA: 0x7AE8EADA0
    }

    public class Datatype_short : Datatype_int
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E77A0
        public void get_TypeCode(){} // RVA: 0x7AE8E7800
        public void Compare(){} // RVA: 0x7AE8E7810
        public void get_ValueType(){} // RVA: 0x7AE8E7940
        public void get_ListValueType(){} // RVA: 0x7AE8E79A0
        public void TryParseValue(){} // RVA: 0x7AE8E7A00
        public void .ctor(){} // RVA: 0x7AE8E7CB0
        public void .cctor(){} // RVA: 0x7AE8E7D00
    }

    public class Datatype_string : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8DFD30
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A82D1450
        public void get_FacetsChecker(){} // RVA: 0x7AE8DFDC0
        public void get_TypeCode(){} // RVA: 0x7A9F22B10
        public void get_TokenizedType(){} // RVA: 0x7A82D1450
        public void get_ValidRestrictionFlags(){} // RVA: 0x7AE8DDC40
        public void TryParseValue(){} // RVA: 0x7AE8DFE20
        public void .ctor(){} // RVA: 0x7AE8DFFD0
    }

    public class Datatype_time : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A94BC410
        public void .ctor(){} // RVA: 0x7AE8E35E0
    }

    public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8E3520
    }

    public class Datatype_timeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8E3580
    }

    public class Datatype_token : Datatype_normalizedString
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A9F22B70
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A81DDCC0
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A9F22B70
        public void .ctor(){} // RVA: 0x7AE8E53E0
    }

    public class Datatype_union : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8DE7F0
        public void .ctor(){} // RVA: 0x7AE8DE850
        public void Compare(){} // RVA: 0x7AE8DE920
        public void get_ValueType(){} // RVA: 0x7AE8DEA30
        public void get_TypeCode(){} // RVA: 0x7A836B0A0
        public void get_FacetsChecker(){} // RVA: 0x7AE8DEA90
        public void get_ListValueType(){} // RVA: 0x7AE8DEAF0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7A9F22B00
        public void get_BaseMemberTypes(){} // RVA: 0x7A8292C30
        public void HasAtomicMembers(){} // RVA: 0x7AE8DEB50
        public void IsUnionBaseOf(){} // RVA: 0x7AE8DEC00
        public void TryParseValue(){} // RVA: 0x7AE8DEF70
        public void .cctor(){} // RVA: 0x7AE8DF450
    }

    public class Datatype_unsignedByte : Datatype_unsignedShort
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8EA470
        public void get_TypeCode(){} // RVA: 0x7AE3D4A30
        public void Compare(){} // RVA: 0x7AE8EA4D0
        public void get_ValueType(){} // RVA: 0x7AE8EA600
        public void get_ListValueType(){} // RVA: 0x7AE8EA660
        public void TryParseValue(){} // RVA: 0x7AE8EA6C0
        public void .ctor(){} // RVA: 0x7AE8EA970
        public void .cctor(){} // RVA: 0x7AE8EA9C0
    }

    public class Datatype_unsignedInt : Datatype_unsignedLong
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E9310
        public void get_TypeCode(){} // RVA: 0x7A9F26120
        public void Compare(){} // RVA: 0x7AE8E9370
        public void get_ValueType(){} // RVA: 0x7AE8E93F0
        public void get_ListValueType(){} // RVA: 0x7AE8E9450
        public void TryParseValue(){} // RVA: 0x7AE8E94B0
        public void .ctor(){} // RVA: 0x7AE8E98B0
        public void .cctor(){} // RVA: 0x7AE8E9900
    }

    public class Datatype_unsignedLong : Datatype_nonNegativeInteger
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E8990
        public void get_TypeCode(){} // RVA: 0x7A9F22B40
        public void Compare(){} // RVA: 0x7AE8E89F0
        public void get_ValueType(){} // RVA: 0x7AE8E8A70
        public void get_ListValueType(){} // RVA: 0x7AE8E8AD0
        public void TryParseValue(){} // RVA: 0x7AE8E8B30
        public void .ctor(){} // RVA: 0x7AE8E8F90
        public void .cctor(){} // RVA: 0x7AE8E9020
    }

    public class Datatype_unsignedShort : Datatype_unsignedInt
    {
        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7AE8E9BF0
        public void get_TypeCode(){} // RVA: 0x7A836B0B0
        public void Compare(){} // RVA: 0x7AE8E9C50
        public void get_ValueType(){} // RVA: 0x7AE8E9D80
        public void get_ListValueType(){} // RVA: 0x7AE8E9DE0
        public void TryParseValue(){} // RVA: 0x7AE8E9E40
        public void .ctor(){} // RVA: 0x7AE8EA0F0
        public void .cctor(){} // RVA: 0x7AE8EA180
    }

    public class Datatype_untypedAtomicType : Datatype_anyAtomicType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7AE8DFCC0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7A82D1450
        public void get_TypeCode(){} // RVA: 0x7ADC89490
        public void .ctor(){} // RVA: 0x7AE8DFD20
    }

    public class Datatype_uuid : Datatype_anySimpleType
    {
        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7AE8EC800
        public void get_ListValueType(){} // RVA: 0x7AE8EC860
        public void get_ValidRestrictionFlags(){} // RVA: 0x7A82D1450
        public void Compare(){} // RVA: 0x7AE8EC8C0
        public void ParseValue(){} // RVA: 0x7AE8ECA00
        public void TryParseValue(){} // RVA: 0x7AE8ECC70
        public void .ctor(){} // RVA: 0x7AE8ECDC0
        public void .cctor(){} // RVA: 0x7AE8ECE40
    }

    public class Datatype_year : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A838E9A0
        public void .ctor(){} // RVA: 0x7AE8E3700
    }

    public class Datatype_yearMonth : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7A8C50BC0
        public void .ctor(){} // RVA: 0x7AE8E36A0
    }

    public class Datatype_yearMonthDuration : Datatype_duration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7AE8E2320
        public void get_TypeCode(){} // RVA: 0x7A8D8FC40
        public void .ctor(){} // RVA: 0x7AE8E2590
    }

    public class DateTimeFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7AE8F85A0
        public void MatchEnumeration(){} // RVA: 0x7AE8F8A90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DfaContentValidator : ContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8CF980
        public void InitValidation(){} // RVA: 0x7AE8CFAB0
        public void ValidateElement(){} // RVA: 0x7AE8CFB10
        public void CompleteValidation(){} // RVA: 0x7AE8CFC60
        public void ExpectedElements(){} // RVA: 0x7AE8CFC80
        public void ExpectedParticles(){} // RVA: 0x7AE8CFE70
    }

    public class DoubleLinkAxis : Axis
    {
        // ── Methods ──
        public void get_Next(){} // RVA: 0x7A8154D80
        public void set_Next(){} // RVA: 0x7A80FF440
        public void .ctor(){} // RVA: 0x7AE8C07A0
        public void ConvertTree(){} // RVA: 0x7AE8C0910
    }

    public class DtdValidator : BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8ED060
        public void Init(){} // RVA: 0x7AE8ED160
        public void Validate(){} // RVA: 0x7AE8ED460
        public void MeetsStandAloneConstraint(){} // RVA: 0x7AE8ED840
        public void ValidatePIComment(){} // RVA: 0x7AE8ED8E0
        public void ValidateElement(){} // RVA: 0x7AE8ED9D0
        public void ValidateChildElement(){} // RVA: 0x7AE8EDCC0
        public void ValidateStartElement(){} // RVA: 0x7AE8EDE80
        public void ValidateEndStartElement(){} // RVA: 0x7AE8EE500
        public void ProcessElement(){} // RVA: 0x7AE8EE710
        public void CompleteValidation(){} // RVA: 0x7AE8EE950
        public void ValidateEndElement(){} // RVA: 0x7AE8EEB10
        public void get_PreserveWhitespace(){} // RVA: 0x7AE78A680
        public void ProcessTokenizedType(){} // RVA: 0x7AE8EED70
        public void CheckValue(){} // RVA: 0x7AE8EF090
        public void AddID(){} // RVA: 0x7AE8EF700
        public void FindId(){} // RVA: 0x7AE8EF800
        public void GenEntity(){} // RVA: 0x7AE8EF830
        public void GetEntity(){} // RVA: 0x7AE8EFA40
        public void CheckForwardRefs(){} // RVA: 0x7AE8EFAF0
        public void Push(){} // RVA: 0x7AE8EFC90
        public void Pop(){} // RVA: 0x7AE8EFF80
        public void SetDefaultTypedValue(){} // RVA: 0x7AE8F00D0
        public void CheckDefaultValue(){} // RVA: 0x7AE8F0390
        public void .cctor(){} // RVA: 0x7AE8F06E0
    }

    public class DurationFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7AE8F8020
        public void MatchEnumeration(){} // RVA: 0x7AE8F8420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}