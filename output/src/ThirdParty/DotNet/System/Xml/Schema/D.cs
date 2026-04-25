// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 68
// Methods: 438

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class DatatypeImplementation : XmlSchemaDatatype
    {
        public 0x6B1608D0 AnySimpleType; // 0x10
        public System.Xml.Schema.RestrictionFacets UntypedAtomicType; // 0x18
        public System.Xml.Schema.DatatypeImplementation FacetsChecker; // 0x20
        public System.Xml.Schema.XmlValueConverter ValueConverter; // 0x28
        public System.Xml.Schema.XmlSchemaType TokenizedType; // 0x30
        public System.Collections.Hashtable ValueType;
        public System.Xml.Schema.XmlSchemaSimpleType[] Variety; // 0x8
        public System.Xml.Schema.XmlSchemaSimpleType TypeCode; // 0x10
        public System.Xml.Schema.XmlSchemaSimpleType Restriction; // 0x18
        public System.Xml.Schema.XmlSchemaSimpleType HasLexicalFacets; // 0x20
        public System.Xml.Schema.XmlSchemaSimpleType HasValueFacets; // 0x28
        public System.Xml.Schema.XmlSchemaSimpleType Base; // 0x30
        public System.Xml.Schema.XmlSchemaSimpleType ListValueType; // 0x38
        public System.Xml.Schema.XmlSchemaSimpleType ValidRestrictionFlags; // 0x40
        public System.Xml.XmlQualifiedName BuiltInWhitespaceFacet; // 0x48
        public System.Xml.XmlQualifiedName QnAnyType; // 0x50
        public System.Xml.Schema.FacetsChecker stringFacetsChecker; // 0x58
        public System.Xml.Schema.FacetsChecker miscFacetsChecker; // 0x60
        public System.Xml.Schema.FacetsChecker numeric2FacetsChecker; // 0x68
        public System.Xml.Schema.FacetsChecker binaryFacetsChecker; // 0x70
        public System.Xml.Schema.FacetsChecker dateTimeFacetsChecker; // 0x78
        public System.Xml.Schema.FacetsChecker durationFacetsChecker; // 0x80
        public System.Xml.Schema.FacetsChecker listFacetsChecker; // 0x88
        public System.Xml.Schema.FacetsChecker qnameFacetsChecker; // 0x90
        public System.Xml.Schema.FacetsChecker unionFacetsChecker; // 0x98
        public System.Xml.Schema.DatatypeImplementation c_anySimpleType; // 0xA0
        public System.Xml.Schema.DatatypeImplementation c_anyURI; // 0xA8
        public System.Xml.Schema.DatatypeImplementation c_base64Binary; // 0xB0
        public System.Xml.Schema.DatatypeImplementation c_boolean; // 0xB8
        public System.Xml.Schema.DatatypeImplementation c_byte; // 0xC0
        public System.Xml.Schema.DatatypeImplementation c_char; // 0xC8
        public System.Xml.Schema.DatatypeImplementation c_date; // 0xD0
        public System.Xml.Schema.DatatypeImplementation c_dateTime; // 0xD8
        public System.Xml.Schema.DatatypeImplementation c_dateTimeNoTz; // 0xE0
        public System.Xml.Schema.DatatypeImplementation c_dateTimeTz; // 0xE8
        public System.Xml.Schema.DatatypeImplementation c_day; // 0xF0
        public System.Xml.Schema.DatatypeImplementation c_decimal; // 0xF8
        public System.Xml.Schema.DatatypeImplementation c_double; // 0x100
        public System.Xml.Schema.DatatypeImplementation c_doubleXdr; // 0x108
        public System.Xml.Schema.DatatypeImplementation c_duration; // 0x110
        public System.Xml.Schema.DatatypeImplementation c_ENTITY; // 0x118
        public System.Xml.Schema.DatatypeImplementation c_ENTITIES; // 0x120
        public System.Xml.Schema.DatatypeImplementation c_ENUMERATION; // 0x128
        public System.Xml.Schema.DatatypeImplementation c_fixed; // 0x130
        public System.Xml.Schema.DatatypeImplementation c_float; // 0x138
        public System.Xml.Schema.DatatypeImplementation c_floatXdr; // 0x140
        public System.Xml.Schema.DatatypeImplementation c_hexBinary; // 0x148
        public System.Xml.Schema.DatatypeImplementation c_ID; // 0x150
        public System.Xml.Schema.DatatypeImplementation c_IDREF; // 0x158
        public System.Xml.Schema.DatatypeImplementation c_IDREFS; // 0x160
        public System.Xml.Schema.DatatypeImplementation c_int; // 0x168
        public System.Xml.Schema.DatatypeImplementation c_integer; // 0x170
        public System.Xml.Schema.DatatypeImplementation c_language; // 0x178
        public System.Xml.Schema.DatatypeImplementation c_long; // 0x180
        public System.Xml.Schema.DatatypeImplementation c_month; // 0x188
        public System.Xml.Schema.DatatypeImplementation c_monthDay; // 0x190
        public System.Xml.Schema.DatatypeImplementation c_Name; // 0x198
        public System.Xml.Schema.DatatypeImplementation c_NCName; // 0x1A0
        public System.Xml.Schema.DatatypeImplementation c_negativeInteger; // 0x1A8
        public System.Xml.Schema.DatatypeImplementation c_NMTOKEN; // 0x1B0
        public System.Xml.Schema.DatatypeImplementation c_NMTOKENS; // 0x1B8
        public System.Xml.Schema.DatatypeImplementation c_nonNegativeInteger; // 0x1C0
        public System.Xml.Schema.DatatypeImplementation c_nonPositiveInteger; // 0x1C8
        public System.Xml.Schema.DatatypeImplementation c_normalizedString; // 0x1D0
        public System.Xml.Schema.DatatypeImplementation c_NOTATION; // 0x1D8
        public System.Xml.Schema.DatatypeImplementation c_positiveInteger; // 0x1E0
        public System.Xml.Schema.DatatypeImplementation c_QName; // 0x1E8
        public System.Xml.Schema.DatatypeImplementation c_QNameXdr; // 0x1F0
        public System.Xml.Schema.DatatypeImplementation c_short; // 0x1F8
        public System.Xml.Schema.DatatypeImplementation c_string; // 0x200
        public System.Xml.Schema.DatatypeImplementation c_time; // 0x208
        public System.Xml.Schema.DatatypeImplementation c_timeNoTz; // 0x210
        public System.Xml.Schema.DatatypeImplementation c_timeTz; // 0x218
        public System.Xml.Schema.DatatypeImplementation c_token; // 0x220
        public System.Xml.Schema.DatatypeImplementation c_unsignedByte; // 0x228
        public System.Xml.Schema.DatatypeImplementation c_unsignedInt; // 0x230
        public System.Xml.Schema.DatatypeImplementation c_unsignedLong; // 0x238
        public System.Xml.Schema.DatatypeImplementation c_unsignedShort; // 0x240
        public System.Xml.Schema.DatatypeImplementation c_uuid; // 0x248
        public System.Xml.Schema.DatatypeImplementation c_year; // 0x250
        public System.Xml.Schema.DatatypeImplementation c_yearMonth; // 0x258
        public System.Xml.Schema.DatatypeImplementation c_normalizedStringV1Compat; // 0x260
        public System.Xml.Schema.DatatypeImplementation c_tokenV1Compat; // 0x268
        public System.Xml.Schema.DatatypeImplementation c_anyAtomicType; // 0x270
        public System.Xml.Schema.DatatypeImplementation c_dayTimeDuration; // 0x278
        public System.Xml.Schema.DatatypeImplementation c_untypedAtomicType; // 0x280
        public System.Xml.Schema.DatatypeImplementation c_yearMonthDuration; // 0x288
        public System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypes; // 0x290
        public System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
        public SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
        public SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC92798A0
        public void get_AnySimpleType(){} // RVA: 0x7FFAC927F7F0
        public void get_UntypedAtomicType(){} // RVA: 0x7FFAC927F850
        public void FromXmlTokenizedType(){} // RVA: 0x7FFAC927F8B0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7FFAC927F930
        public void FromXdrName(){} // RVA: 0x7FFAC927F9B0
        public void FromTypeName(){} // RVA: 0x7FFAC927FB40
        public void StartBuiltinType(){} // RVA: 0x7FFAC927FCD0
        public void FinishBuiltinType(){} // RVA: 0x7FFAC927FF10
        public void CreateBuiltinTypes(){} // RVA: 0x7FFAC9280360
        public void GetSimpleTypeFromTypeCode(){} // RVA: 0x7FFAC9281580
        public void GetSimpleTypeFromXsdType(){} // RVA: 0x7FFAC9281600
        public void GetNormalizedStringTypeV1Compat(){} // RVA: 0x7FFAC92816D0
        public void GetTokenTypeV1Compat(){} // RVA: 0x7FFAC9281A40
        public void GetBuiltInTypes(){} // RVA: 0x7FFAC9281DB0
        public void GetPrimitiveTypeCode(){} // RVA: 0x7FFAC9281E10
        public void DeriveByRestriction(){} // RVA: 0x7FFAC9281F80
        public void DeriveByList(){} // RVA: 0x7FFAC92821E0 | overloaded x2
        public void DeriveByUnion(){} // RVA: 0x7FFAC9282600
        public void VerifySchemaValid(){} // RVA: 0x7FFAC2F21310
        public void IsDerivedFrom(){} // RVA: 0x7FFAC9282800
        public void IsEqual(){} // RVA: 0x7FFAC9282AF0
        public void IsComparable(){} // RVA: 0x7FFAC9282B20
        public void CreateValueConverter(){} // RVA: 0x7FFAC34F9180
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9282C20
        public void get_ValueConverter(){} // RVA: 0x7FFAC9282C80
        public void get_TokenizedType(){} // RVA: 0x7FFAC530B5A0
        public void get_ValueType(){} // RVA: 0x7FFAC9282D10
        public void get_Variety(){} // RVA: 0x7FFAC2F6E5C0
        public void get_TypeCode(){} // RVA: 0x7FFAC34F9180
        public void get_Restriction(){} // RVA: 0x7FFAC2F247C0
        public void get_HasLexicalFacets(){} // RVA: 0x7FFAC9282DC0
        public void get_HasValueFacets(){} // RVA: 0x7FFAC9282DE0
        public void get_Base(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ListValueType(){} // RVA: 0x7FFAC2C58E90
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC2C59960
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC34F9180
        public void ParseValue(){} // RVA: 0x7FFAC9283010 | overloaded x2
        public void TryParseValue(){} // RVA: 0x7FFAC92831B0
        public void GetTypeName(){} // RVA: 0x7FFAC9283590
        public void Compare(){} // RVA: 0x7FFAC9283610
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Datatype_ENTITY : Datatype_NCName
    {
        public object TypeCode;
        public object TokenizedType;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC928BB10
        public void get_TokenizedType(){} // RVA: 0x7FFAC36C3910
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_ENUMERATION : Datatype_NMTOKEN
    {
        public object TokenizedType;

        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x7FFAC41E44C0
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_ID : Datatype_NCName
    {
        public object TypeCode;
        public object TokenizedType;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC928BB00
        public void get_TokenizedType(){} // RVA: 0x7FFAC3013AF0
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_IDREF : Datatype_NCName
    {
        public object TypeCode;
        public object TokenizedType;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC8D986B0
        public void get_TokenizedType(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_List : Datatype_anySimpleType
    {
        public System.Xml.Schema.DatatypeImplementation ValueType; // 0x38
        public int TokenizedType; // 0x40

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92837A0
        public void .ctor(){} // RVA: 0x7FFAC9283D20
        public void Compare(){} // RVA: 0x7FFAC9283E10
        public void get_ValueType(){} // RVA: 0x7FFAC92840F0
        public void get_TokenizedType(){} // RVA: 0x7FFAC9284110
        public void get_ListValueType(){} // RVA: 0x7FFAC9284140
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9284170
        public void get_TypeCode(){} // RVA: 0x7FFAC5FD26C0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void TryParseValue(){} // RVA: 0x7FFAC9284800 | overloaded x2
    }

    public class Datatype_NCName : Datatype_Name
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC530F3E0
        public void TryParseValue(){} // RVA: 0x7FFAC928B910
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_NMTOKEN : Datatype_token
    {
        public object TypeCode;
        public object TokenizedType;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC91B8730
        public void get_TokenizedType(){} // RVA: 0x7FFAC36A9850
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_NOTATION : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92880F0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928BB20
        public void get_TypeCode(){} // RVA: 0x7FFAC530F510
        public void get_TokenizedType(){} // RVA: 0x7FFAC3ED8E80
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void get_ValueType(){} // RVA: 0x7FFAC928BB80
        public void get_ListValueType(){} // RVA: 0x7FFAC928BBE0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void TryParseValue(){} // RVA: 0x7FFAC928BC40
        public void VerifySchemaValid(){} // RVA: 0x7FFAC928BE80
        public void .ctor(){} // RVA: 0x7FFAC928C130
        public void .cctor(){} // RVA: 0x7FFAC928C1B0
    }

    public class Datatype_Name : Datatype_token
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC928B900
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_QName : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92880F0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928B2F0
        public void get_TypeCode(){} // RVA: 0x7FFAC530F4D0
        public void get_TokenizedType(){} // RVA: 0x7FFAC314F980
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void get_ValueType(){} // RVA: 0x7FFAC928B350
        public void get_ListValueType(){} // RVA: 0x7FFAC928B3B0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void TryParseValue(){} // RVA: 0x7FFAC928B410
        public void .ctor(){} // RVA: 0x7FFAC928B650
        public void .cctor(){} // RVA: 0x7FFAC928B6D0
    }

    public class Datatype_QNameXdr : Datatype_anySimpleType
    {
        public System.Type TokenizedType;
        public System.Type ValueType; // 0x8

        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x7FFAC314F980
        public void ParseValue(){} // RVA: 0x7FFAC9291690
        public void get_ValueType(){} // RVA: 0x7FFAC92918B0
        public void get_ListValueType(){} // RVA: 0x7FFAC9291910
        public void .ctor(){} // RVA: 0x7FFAC9291970
        public void .cctor(){} // RVA: 0x7FFAC92919F0
    }

    public class Datatype_anyAtomicType : Datatype_anySimpleType
    {
        public object BuiltInWhitespaceFacet;
        public object TypeCode;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9286110
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC34F9180
        public void get_TypeCode(){} // RVA: 0x7FFAC314F980
        public void .ctor(){} // RVA: 0x7FFAC9286170
    }

    public class Datatype_anySimpleType : DatatypeImplementation
    {
        public System.Type FacetsChecker;
        public System.Type ValueType; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9285BA0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9285C00
        public void get_ValueType(){} // RVA: 0x7FFAC9285C60
        public void get_TypeCode(){} // RVA: 0x7FFAC314F980
        public void get_ListValueType(){} // RVA: 0x7FFAC9285CC0
        public void get_TokenizedType(){} // RVA: 0x7FFAC530B5A0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC34F9180
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void Compare(){} // RVA: 0x7FFAC9285D20
        public void TryParseValue(){} // RVA: 0x7FFAC9285E30
        public void .ctor(){} // RVA: 0x7FFAC9285EA0
        public void .cctor(){} // RVA: 0x7FFAC9285EF0
    }

    public class Datatype_anyURI : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92880F0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928AC50
        public void get_TypeCode(){} // RVA: 0x7FFAC928ACB0
        public void get_ValueType(){} // RVA: 0x7FFAC928ACC0
        public void get_HasValueFacets(){} // RVA: 0x7FFAC3006850
        public void get_ListValueType(){} // RVA: 0x7FFAC928AD20
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void Compare(){} // RVA: 0x7FFAC928AD80
        public void TryParseValue(){} // RVA: 0x7FFAC928AE50
        public void .ctor(){} // RVA: 0x7FFAC928B050
        public void .cctor(){} // RVA: 0x7FFAC928B0D0
    }

    public class Datatype_base64Binary : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92880F0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928A4E0
        public void get_TypeCode(){} // RVA: 0x7FFAC928A540
        public void get_ValueType(){} // RVA: 0x7FFAC928A550
        public void get_ListValueType(){} // RVA: 0x7FFAC928A5B0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void Compare(){} // RVA: 0x7FFAC928A610
        public void TryParseValue(){} // RVA: 0x7FFAC928A730
        public void .ctor(){} // RVA: 0x7FFAC928A9B0
        public void .cctor(){} // RVA: 0x7FFAC928AA30
    }

    public class Datatype_boolean : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9286580
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9286610
        public void get_TypeCode(){} // RVA: 0x7FFAC3C15CE0
        public void get_ValueType(){} // RVA: 0x7FFAC9286670
        public void get_ListValueType(){} // RVA: 0x7FFAC92866D0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC530B560
        public void Compare(){} // RVA: 0x7FFAC9286730
        public void TryParseValue(){} // RVA: 0x7FFAC92867C0
        public void .ctor(){} // RVA: 0x7FFAC9286A70
        public void .cctor(){} // RVA: 0x7FFAC9286AF0
    }

    public class Datatype_byte : Datatype_short
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928E360
        public void get_TypeCode(){} // RVA: 0x7FFAC8D479C0
        public void Compare(){} // RVA: 0x7FFAC928E3C0
        public void get_ValueType(){} // RVA: 0x7FFAC928E4F0
        public void get_ListValueType(){} // RVA: 0x7FFAC928E550
        public void TryParseValue(){} // RVA: 0x7FFAC928E5B0
        public void .ctor(){} // RVA: 0x7FFAC928E870
        public void .cctor(){} // RVA: 0x7FFAC928E900
    }

    public class Datatype_char : Datatype_anySimpleType
    {
        public System.Type ValueType;
        public System.Type ListValueType; // 0x8

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFAC9291C10
        public void get_ListValueType(){} // RVA: 0x7FFAC9291C70
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC34F9180
        public void Compare(){} // RVA: 0x7FFAC9291CD0
        public void ParseValue(){} // RVA: 0x7FFAC9291E10
        public void TryParseValue(){} // RVA: 0x7FFAC9292030
        public void .ctor(){} // RVA: 0x7FFAC92923B0
        public void .cctor(){} // RVA: 0x7FFAC9292430
    }

    public class Datatype_date : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC3195EF0
        public void .ctor(){} // RVA: 0x7FFAC9289B70
    }

    public class Datatype_dateTime : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92899F0
    }

    public class Datatype_dateTimeBase : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public 0x6B165D60 ValueType; // 0x38

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9288DE0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9288E70
        public void get_TypeCode(){} // RVA: 0x7FFAC413E570
        public void .ctor(){} // RVA: 0x7FFAC9288ED0
        public void get_ValueType(){} // RVA: 0x7FFAC9288F60
        public void get_ListValueType(){} // RVA: 0x7FFAC9288FC0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC9286E40
        public void Compare(){} // RVA: 0x7FFAC9289020
        public void TryParseValue(){} // RVA: 0x7FFAC9289270
        public void .cctor(){} // RVA: 0x7FFAC9289710
    }

    public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9289930
    }

    public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9289990
    }

    public class Datatype_day : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC530B550
        public void .ctor(){} // RVA: 0x7FFAC9289CF0
    }

    public class Datatype_dayTimeDuration : Datatype_duration
    {
        public object TypeCode;

        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7FFAC9288B10
        public void get_TypeCode(){} // RVA: 0x7FFAC9288D80
        public void .ctor(){} // RVA: 0x7FFAC9288D90
    }

    public class Datatype_decimal : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9287970
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9287A00
        public void get_TypeCode(){} // RVA: 0x7FFAC4206550
        public void get_ValueType(){} // RVA: 0x7FFAC9287A60
        public void get_ListValueType(){} // RVA: 0x7FFAC9287AC0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC9287B20
        public void Compare(){} // RVA: 0x7FFAC9287B30
        public void TryParseValue(){} // RVA: 0x7FFAC9287BC0
        public void .ctor(){} // RVA: 0x7FFAC9287DA0
        public void .cctor(){} // RVA: 0x7FFAC9287E20
    }

    public class Datatype_double : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9286D10
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9287350
        public void get_TypeCode(){} // RVA: 0x7FFAC530B540
        public void get_ValueType(){} // RVA: 0x7FFAC92873B0
        public void get_ListValueType(){} // RVA: 0x7FFAC9287410
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC9286E40
        public void Compare(){} // RVA: 0x7FFAC9287470
        public void TryParseValue(){} // RVA: 0x7FFAC92874F0
        public void .ctor(){} // RVA: 0x7FFAC92876D0
        public void .cctor(){} // RVA: 0x7FFAC9287750
    }

    public class Datatype_doubleXdr : Datatype_double
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7FFAC9291260
        public void .ctor(){} // RVA: 0x7FFAC9291430
    }

    public class Datatype_duration : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92880F0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9288100
        public void get_TypeCode(){} // RVA: 0x7FFAC8804850
        public void get_ValueType(){} // RVA: 0x7FFAC9288160
        public void get_ListValueType(){} // RVA: 0x7FFAC92881C0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC9286E40
        public void Compare(){} // RVA: 0x7FFAC9288220
        public void TryParseValue(){} // RVA: 0x7FFAC92882B0
        public void .ctor(){} // RVA: 0x7FFAC92885B0
        public void .cctor(){} // RVA: 0x7FFAC9288630
    }

    public class Datatype_fixed : Datatype_decimal
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7FFAC9292650
        public void TryParseValue(){} // RVA: 0x7FFAC9292920
        public void .ctor(){} // RVA: 0x7FFAC9292B60
    }

    public class Datatype_float : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9286D10
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9286D20
        public void get_TypeCode(){} // RVA: 0x7FFAC3E454F0
        public void get_ValueType(){} // RVA: 0x7FFAC9286D80
        public void get_ListValueType(){} // RVA: 0x7FFAC9286DE0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC9286E40
        public void Compare(){} // RVA: 0x7FFAC9286E50
        public void TryParseValue(){} // RVA: 0x7FFAC9286ED0
        public void .ctor(){} // RVA: 0x7FFAC92870B0
        public void .cctor(){} // RVA: 0x7FFAC9287130
    }

    public class Datatype_floatXdr : Datatype_float
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7FFAC9291480
        public void .ctor(){} // RVA: 0x7FFAC9291640
    }

    public class Datatype_hexBinary : Datatype_anySimpleType
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92880F0
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9289DB0
        public void get_TypeCode(){} // RVA: 0x7FFAC3B3F630
        public void get_ValueType(){} // RVA: 0x7FFAC9289E10
        public void get_ListValueType(){} // RVA: 0x7FFAC9289E70
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void Compare(){} // RVA: 0x7FFAC9289ED0
        public void TryParseValue(){} // RVA: 0x7FFAC9289FF0
        public void .ctor(){} // RVA: 0x7FFAC928A240
        public void .cctor(){} // RVA: 0x7FFAC928A2C0
    }

    public class Datatype_int : Datatype_long
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928D210
        public void get_TypeCode(){} // RVA: 0x7FFAC530F4B0
        public void Compare(){} // RVA: 0x7FFAC928D270
        public void get_ValueType(){} // RVA: 0x7FFAC928D2F0
        public void get_ListValueType(){} // RVA: 0x7FFAC928D350
        public void TryParseValue(){} // RVA: 0x7FFAC928D3B0
        public void .ctor(){} // RVA: 0x7FFAC928D7C0
        public void .cctor(){} // RVA: 0x7FFAC928D850
    }

    public class Datatype_integer : Datatype_decimal
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC530B560
        public void TryParseValue(){} // RVA: 0x7FFAC928C3D0
        public void .ctor(){} // RVA: 0x7FFAC928C580
    }

    public class Datatype_language : Datatype_token
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC8D97B90
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_long : Datatype_integer
    {
        public System.Type FacetsChecker;
        public System.Type HasValueFacets; // 0x8
        public System.Xml.Schema.FacetsChecker TypeCode; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928C970
        public void get_HasValueFacets(){} // RVA: 0x7FFAC3006850
        public void get_TypeCode(){} // RVA: 0x7FFAC928C9D0
        public void Compare(){} // RVA: 0x7FFAC928C9E0
        public void get_ValueType(){} // RVA: 0x7FFAC928CA60
        public void get_ListValueType(){} // RVA: 0x7FFAC928CAC0
        public void TryParseValue(){} // RVA: 0x7FFAC928CB20
        public void .ctor(){} // RVA: 0x7FFAC928C580
        public void .cctor(){} // RVA: 0x7FFAC928CF30
    }

    public class Datatype_month : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC530F540
        public void .ctor(){} // RVA: 0x7FFAC9289D50
    }

    public class Datatype_monthDay : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC3641DE0
        public void .ctor(){} // RVA: 0x7FFAC9289C90
    }

    public class Datatype_negativeInteger : Datatype_nonPositiveInteger
    {
        public System.Xml.Schema.FacetsChecker FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928C750
        public void get_TypeCode(){} // RVA: 0x7FFAC928C7B0
        public void .ctor(){} // RVA: 0x7FFAC928C7C0
        public void .cctor(){} // RVA: 0x7FFAC928C850
    }

    public class Datatype_nonNegativeInteger : Datatype_integer
    {
        public System.Xml.Schema.FacetsChecker FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928EBD0
        public void get_TypeCode(){} // RVA: 0x7FFAC85F8C70
        public void get_HasValueFacets(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC928C580
        public void .cctor(){} // RVA: 0x7FFAC928EC30
    }

    public class Datatype_nonPositiveInteger : Datatype_integer
    {
        public System.Xml.Schema.FacetsChecker FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928C5D0
        public void get_TypeCode(){} // RVA: 0x7FFAC928C630
        public void get_HasValueFacets(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC928C580
        public void .cctor(){} // RVA: 0x7FFAC928C640
    }

    public class Datatype_normalizedString : Datatype_string
    {
        public object TypeCode;
        public object BuiltInWhitespaceFacet;
        public object HasValueFacets;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC8D97D00
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3013AF0
        public void get_HasValueFacets(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_normalizedStringV1Compat : Datatype_string
    {
        public object TypeCode;
        public object HasValueFacets;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC8D97D00
        public void get_HasValueFacets(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_positiveInteger : Datatype_nonNegativeInteger
    {
        public System.Xml.Schema.FacetsChecker FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9291070
        public void get_TypeCode(){} // RVA: 0x7FFAC530F440
        public void .ctor(){} // RVA: 0x7FFAC92910D0
        public void .cctor(){} // RVA: 0x7FFAC9291160
    }

    public class Datatype_short : Datatype_int
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928DB30
        public void get_TypeCode(){} // RVA: 0x7FFAC928DB90
        public void Compare(){} // RVA: 0x7FFAC928DBA0
        public void get_ValueType(){} // RVA: 0x7FFAC928DCD0
        public void get_ListValueType(){} // RVA: 0x7FFAC928DD30
        public void TryParseValue(){} // RVA: 0x7FFAC928DD90
        public void .ctor(){} // RVA: 0x7FFAC928E040
        public void .cctor(){} // RVA: 0x7FFAC928E090
    }

    public class Datatype_string : Datatype_anySimpleType
    {
        public object BuiltInWhitespaceFacet;
        public object FacetsChecker;
        public object TypeCode;
        public object TokenizedType;
        public object ValidRestrictionFlags;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9286260
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC34F9180
        public void get_FacetsChecker(){} // RVA: 0x7FFAC92862F0
        public void get_TypeCode(){} // RVA: 0x7FFAC530B5A0
        public void get_TokenizedType(){} // RVA: 0x7FFAC34F9180
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC92841D0
        public void TryParseValue(){} // RVA: 0x7FFAC9286350
        public void .ctor(){} // RVA: 0x7FFAC9286500
    }

    public class Datatype_time : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC4192070
        public void .ctor(){} // RVA: 0x7FFAC9289B10
    }

    public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9289A50
    }

    public class Datatype_timeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9289AB0
    }

    public class Datatype_token : Datatype_normalizedString
    {
        public object TypeCode;
        public object BuiltInWhitespaceFacet;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC530BFF0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC530BFF0
        public void .ctor(){} // RVA: 0x7FFAC928B8F0
    }

    public class Datatype_union : Datatype_anySimpleType
    {
        public System.Type ValueType;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.XmlSchemaSimpleType[] FacetsChecker; // 0x38

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC9284D60
        public void .ctor(){} // RVA: 0x7FFAC9284DC0
        public void Compare(){} // RVA: 0x7FFAC9284E90
        public void get_ValueType(){} // RVA: 0x7FFAC9284FA0
        public void get_TypeCode(){} // RVA: 0x7FFAC314F980
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9285000
        public void get_ListValueType(){} // RVA: 0x7FFAC9285060
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC530B550
        public void get_BaseMemberTypes(){} // RVA: 0x7FFAC31D0140
        public void HasAtomicMembers(){} // RVA: 0x7FFAC92850C0
        public void IsUnionBaseOf(){} // RVA: 0x7FFAC9285160
        public void TryParseValue(){} // RVA: 0x7FFAC92854C0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9285980
    }

    public class Datatype_unsignedByte : Datatype_unsignedShort
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC9290820
        public void get_TypeCode(){} // RVA: 0x7FFAC8D7CC80
        public void Compare(){} // RVA: 0x7FFAC9290880
        public void get_ValueType(){} // RVA: 0x7FFAC92909B0
        public void get_ListValueType(){} // RVA: 0x7FFAC9290A10
        public void TryParseValue(){} // RVA: 0x7FFAC9290A70
        public void .ctor(){} // RVA: 0x7FFAC9290D30
        public void .cctor(){} // RVA: 0x7FFAC9290D80
    }

    public class Datatype_unsignedInt : Datatype_unsignedLong
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928F6B0
        public void get_TypeCode(){} // RVA: 0x7FFAC530F470
        public void Compare(){} // RVA: 0x7FFAC928F710
        public void get_ValueType(){} // RVA: 0x7FFAC928F790
        public void get_ListValueType(){} // RVA: 0x7FFAC928F7F0
        public void TryParseValue(){} // RVA: 0x7FFAC928F850
        public void .ctor(){} // RVA: 0x7FFAC928FC60
        public void .cctor(){} // RVA: 0x7FFAC928FCB0
    }

    public class Datatype_unsignedLong : Datatype_nonNegativeInteger
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928ED30
        public void get_TypeCode(){} // RVA: 0x7FFAC530BFD0
        public void Compare(){} // RVA: 0x7FFAC928ED90
        public void get_ValueType(){} // RVA: 0x7FFAC928EE10
        public void get_ListValueType(){} // RVA: 0x7FFAC928EE70
        public void TryParseValue(){} // RVA: 0x7FFAC928EED0
        public void .ctor(){} // RVA: 0x7FFAC928F330
        public void .cctor(){} // RVA: 0x7FFAC928F3C0
    }

    public class Datatype_unsignedShort : Datatype_unsignedInt
    {
        public System.Type FacetsChecker;
        public System.Type TypeCode; // 0x8
        public System.Xml.Schema.FacetsChecker ValueType; // 0x10

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFAC928FFA0
        public void get_TypeCode(){} // RVA: 0x7FFAC314F990
        public void Compare(){} // RVA: 0x7FFAC9290000
        public void get_ValueType(){} // RVA: 0x7FFAC9290130
        public void get_ListValueType(){} // RVA: 0x7FFAC9290190
        public void TryParseValue(){} // RVA: 0x7FFAC92901F0
        public void .ctor(){} // RVA: 0x7FFAC92904A0
        public void .cctor(){} // RVA: 0x7FFAC9290530
    }

    public class Datatype_untypedAtomicType : Datatype_anyAtomicType
    {
        public object BuiltInWhitespaceFacet;
        public object TypeCode;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFAC92861F0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFAC34F9180
        public void get_TypeCode(){} // RVA: 0x7FFAC8631FB0
        public void .ctor(){} // RVA: 0x7FFAC9286250
    }

    public class Datatype_uuid : Datatype_anySimpleType
    {
        public System.Type ValueType;
        public System.Type ListValueType; // 0x8

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFAC9292BB0
        public void get_ListValueType(){} // RVA: 0x7FFAC9292C10
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFAC34F9180
        public void Compare(){} // RVA: 0x7FFAC9292C70
        public void ParseValue(){} // RVA: 0x7FFAC9292DB0
        public void TryParseValue(){} // RVA: 0x7FFAC9293020
        public void .ctor(){} // RVA: 0x7FFAC9293170
        public void .cctor(){} // RVA: 0x7FFAC92931F0
    }

    public class Datatype_year : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC31719D0
        public void .ctor(){} // RVA: 0x7FFAC9289C30
    }

    public class Datatype_yearMonth : Datatype_dateTimeBase
    {
        public object TypeCode;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC3AA6690
        public void .ctor(){} // RVA: 0x7FFAC9289BD0
    }

    public class Datatype_yearMonthDuration : Datatype_duration
    {
        public object TypeCode;

        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7FFAC9288850
        public void get_TypeCode(){} // RVA: 0x7FFAC8D90540
        public void .ctor(){} // RVA: 0x7FFAC9288AC0
    }

    public class DateTimeFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFAC929E8D0 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFAC929EDC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DfaContentValidator : ContentValidator
    {
        public int[][] transitionTable; // 0x18
        public System.Xml.Schema.SymbolsDictionary symbols; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9275FD0
        public void InitValidation(){} // RVA: 0x7FFAC9276100
        public void ValidateElement(){} // RVA: 0x7FFAC9276160
        public void CompleteValidation(){} // RVA: 0x7FFAC92762B0
        public void ExpectedElements(){} // RVA: 0x7FFAC92762D0
        public void ExpectedParticles(){} // RVA: 0x7FFAC92764C0
    }

    public class DoubleLinkAxis : Axis
    {
        public MS.Internal.Xml.XPath.Axis Next; // 0x40

        // ── Methods ──
        public void get_Next(){} // RVA: 0x7FFAC2F9E740
        public void set_Next(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC9266F00
        public void ConvertTree(){} // RVA: 0x7FFAC9267070
    }

    public class DtdValidator : BaseValidator
    {
        public NamespaceManager PreserveWhitespace;
        public System.Xml.HWStack validationStack; // 0x80
        public System.Collections.Hashtable attPresence; // 0x88
        public System.Xml.XmlQualifiedName name; // 0x90
        public System.Collections.Hashtable IDs; // 0x98
        public System.Xml.Schema.IdRefNode idRefListHead; // 0xA0
        public bool processIdentityConstraints; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9293410
        public void Init(){} // RVA: 0x7FFAC9293510
        public void Validate(){} // RVA: 0x7FFAC9293810
        public void MeetsStandAloneConstraint(){} // RVA: 0x7FFAC9293BF0
        public void ValidatePIComment(){} // RVA: 0x7FFAC9293C90
        public void ValidateElement(){} // RVA: 0x7FFAC9293D80
        public void ValidateChildElement(){} // RVA: 0x7FFAC9294080
        public void ValidateStartElement(){} // RVA: 0x7FFAC9294250
        public void ValidateEndStartElement(){} // RVA: 0x7FFAC92948B0
        public void ProcessElement(){} // RVA: 0x7FFAC9294AC0
        public void CompleteValidation(){} // RVA: 0x7FFAC9294D00
        public void ValidateEndElement(){} // RVA: 0x7FFAC9294EC0
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAC9132760
        public void ProcessTokenizedType(){} // RVA: 0x7FFAC9295130
        public void CheckValue(){} // RVA: 0x7FFAC9295450
        public void AddID(){} // RVA: 0x7FFAC9295AB0
        public void FindId(){} // RVA: 0x7FFAC9295BB0
        public void GenEntity(){} // RVA: 0x7FFAC9295BE0
        public void GetEntity(){} // RVA: 0x7FFAC9295DF0
        public void CheckForwardRefs(){} // RVA: 0x7FFAC9295EB0
        public void Push(){} // RVA: 0x7FFAC9296050
        public void Pop(){} // RVA: 0x7FFAC9296340
        public void SetDefaultTypedValue(){} // RVA: 0x7FFAC9296490
        public void CheckDefaultValue(){} // RVA: 0x7FFAC9296740
        public void .cctor(){} // RVA: 0x7FFAC9296A90
    }

    public class DurationFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFAC929E350 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFAC929E750 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}