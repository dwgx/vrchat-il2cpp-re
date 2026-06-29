// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 68
// Methods: 430

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class DatatypeImplementation : XmlSchemaDatatype
    {
        public object variety;
        public object restriction;
        public object baseType;
        public object valueConverter;
        public object parentSchemaType;
        public object builtinTypes;
        public object enumToTypeCode;
        public object anySimpleType;
        public object anyAtomicType;
        public object untypedAtomicType;
        public object yearMonthDurationType;
        public object dayTimeDurationType;
        public object normalizedStringTypeV1Compat;
        public object tokenTypeV1Compat;
        public object QnAnySimpleType;
        public object QnAnyType;
        public object stringFacetsChecker;
        public object miscFacetsChecker;
        public object numeric2FacetsChecker;
        public object binaryFacetsChecker;
        public object dateTimeFacetsChecker;
        public object durationFacetsChecker;
        public object listFacetsChecker;
        public object qnameFacetsChecker;
        public object unionFacetsChecker;
        public object c_anySimpleType;
        public object c_anyURI;
        public object c_base64Binary;
        public object c_boolean;
        public object c_byte;
        public object c_char;
        public object c_date;
        public object c_dateTime;
        public object c_dateTimeNoTz;
        public object c_dateTimeTz;
        public object c_day;
        public object c_decimal;
        public object c_double;
        public object c_doubleXdr;
        public object c_duration;
        public object c_ENTITY;
        public object c_ENTITIES;
        public object c_ENUMERATION;
        public object c_fixed;
        public object c_float;
        public object c_floatXdr;
        public object c_hexBinary;
        public object c_ID;
        public object c_IDREF;
        public object c_IDREFS;
        public object c_int;
        public object c_integer;
        public object c_language;
        public object c_long;
        public object c_month;
        public object c_monthDay;
        public object c_Name;
        public object c_NCName;
        public object c_negativeInteger;
        public object c_NMTOKEN;
        public object c_NMTOKENS;
        public object c_nonNegativeInteger;
        public object c_nonPositiveInteger;
        public object c_normalizedString;
        public object c_NOTATION;
        public object c_positiveInteger;
        public object c_QName;
        public object c_QNameXdr;
        public object c_short;
        public object c_string;
        public object c_time;
        public object c_timeNoTz;
        public object c_timeTz;
        public object c_token;
        public object c_unsignedByte;
        public object c_unsignedInt;
        public object c_unsignedLong;
        public object c_unsignedShort;
        public object c_uuid;
        public object c_year;
        public object c_yearMonth;
        public object c_normalizedStringV1Compat;
        public object c_tokenV1Compat;
        public object c_anyAtomicType;
        public object c_dayTimeDuration;
        public object c_untypedAtomicType;
        public object c_yearMonthDuration;
        public object c_tokenizedTypes;
        public object c_tokenizedTypesXsd;
        public object c_XdrTypes;
        public object c_XsdTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7547130
        public void get_AnySimpleType(){} // RVA: 0x754D110
        public void get_UntypedAtomicType(){} // RVA: 0x754D170
        public void FromXmlTokenizedType(){} // RVA: 0x754D1D0
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x754D250
        public void FromXdrName(){} // RVA: 0x754D2D0
        public void FromTypeName(){} // RVA: 0x754D460
        public void StartBuiltinType(){} // RVA: 0x754D5F0
        public void FinishBuiltinType(){} // RVA: 0x754D830
        public void CreateBuiltinTypes(){} // RVA: 0x754DC80
        public void GetSimpleTypeFromTypeCode(){} // RVA: 0x754EFA0
        public void GetSimpleTypeFromXsdType(){} // RVA: 0x754F020
        public void GetNormalizedStringTypeV1Compat(){} // RVA: 0x754F0F0
        public void GetTokenTypeV1Compat(){} // RVA: 0x754F450
        public void GetBuiltInTypes(){} // RVA: 0x754F7B0
        public void GetPrimitiveTypeCode(){} // RVA: 0x754F810
        public void DeriveByRestriction(){} // RVA: 0x754F980
        public void DeriveByList(){} // RVA: 0x754FBE0
        public void DeriveByUnion(){} // RVA: 0x7550000
        public void VerifySchemaValid(){} // RVA: 0xB43310
        public void IsDerivedFrom(){} // RVA: 0x7550200
        public void IsEqual(){} // RVA: 0x75504C0
        public void IsComparable(){} // RVA: 0x75504F0
        public void CreateValueConverter(){} // RVA: 0xDAC980
        public void get_FacetsChecker(){} // RVA: 0x75505F0
        public void get_ValueConverter(){} // RVA: 0x7550650
        public void get_TokenizedType(){} // RVA: 0x2AFB6E0
        public void get_ValueType(){} // RVA: 0x7487430
        public void get_Variety(){} // RVA: 0xB8F8F0
        public void get_TypeCode(){} // RVA: 0xDAC980
        public void get_Restriction(){} // RVA: 0xB465B0
        public void get_HasLexicalFacets(){} // RVA: 0x75506E0
        public void get_HasValueFacets(){} // RVA: 0x7550700
        public void get_Base(){} // RVA: 0xB700F0
        public void get_ListValueType(){} // RVA: 0x87C0A0
        public void get_ValidRestrictionFlags(){} // RVA: 0x87C130
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xDAC980
        public void ParseValue(){} // RVA: 0x7550930
        public void TryParseValue(){} // RVA: 0x7550AD0
        public void GetTypeName(){} // RVA: 0x7550E70
        public void Compare(){} // RVA: 0x7550EF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Datatype_ENTITY : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7558E40
        public void get_TokenizedType(){} // RVA: 0x1347420
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_ENUMERATION : Datatype_NMTOKEN
    {
        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x2006E40
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_ID : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7558E30
        public void get_TokenizedType(){} // RVA: 0xC3CCE0
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_IDREF : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x706F970
        public void get_TokenizedType(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_List : Datatype_anySimpleType
    {
        public object itemType;
        public object minListSize;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7550F80
        public void .ctor(){} // RVA: 0x75514C0
        public void Compare(){} // RVA: 0x75515B0
        public void get_ValueType(){} // RVA: 0x7551890
        public void get_TokenizedType(){} // RVA: 0x75518B0
        public void get_ListValueType(){} // RVA: 0x75518E0
        public void get_FacetsChecker(){} // RVA: 0x7551910
        public void get_TypeCode(){} // RVA: 0x4123800
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void TryParseValue(){} // RVA: 0x7551F50
    }

    public class Datatype_NCName : Datatype_Name
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x2AFBEB0
        public void TryParseValue(){} // RVA: 0x7558C40
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_NMTOKEN : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x74873E0
        public void get_TokenizedType(){} // RVA: 0x13510C0
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_NOTATION : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7555620
        public void get_FacetsChecker(){} // RVA: 0x7558E50
        public void get_TypeCode(){} // RVA: 0x2AFF550
        public void get_TokenizedType(){} // RVA: 0x17FCE50
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void get_ValueType(){} // RVA: 0x7558EB0
        public void get_ListValueType(){} // RVA: 0x7558F10
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void TryParseValue(){} // RVA: 0x7558F70
        public void VerifySchemaValid(){} // RVA: 0x75591A0
        public void .ctor(){} // RVA: 0x7559450
        public void .cctor(){} // RVA: 0x75594D0
    }

    public class Datatype_Name : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7558C30
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_QName : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7555620
        public void get_FacetsChecker(){} // RVA: 0x7558680
        public void get_TypeCode(){} // RVA: 0x2AFF500
        public void get_TokenizedType(){} // RVA: 0xE49B40
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void get_ValueType(){} // RVA: 0x75586E0
        public void get_ListValueType(){} // RVA: 0x7558740
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void TryParseValue(){} // RVA: 0x75587A0
        public void .ctor(){} // RVA: 0x75589D0
        public void .cctor(){} // RVA: 0x7558A50
    }

    public class Datatype_QNameXdr : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0xE49B40
        public void ParseValue(){} // RVA: 0x755E740
        public void get_ValueType(){} // RVA: 0x755E960
        public void get_ListValueType(){} // RVA: 0x755E9C0
        public void .ctor(){} // RVA: 0x755EA20
        public void .cctor(){} // RVA: 0x755EAA0
    }

    public class Datatype_anyAtomicType : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x75537A0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xDAC980
        public void get_TypeCode(){} // RVA: 0xE49B40
        public void .ctor(){} // RVA: 0x7553800
    }

    public class Datatype_anySimpleType : DatatypeImplementation
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7553290
        public void get_FacetsChecker(){} // RVA: 0x75532F0
        public void get_ValueType(){} // RVA: 0x7553350
        public void get_TypeCode(){} // RVA: 0xE49B40
        public void get_ListValueType(){} // RVA: 0x75533B0
        public void get_TokenizedType(){} // RVA: 0x2AFB6E0
        public void get_ValidRestrictionFlags(){} // RVA: 0xDAC980
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void Compare(){} // RVA: 0x7553410
        public void TryParseValue(){} // RVA: 0x7553520
        public void .ctor(){} // RVA: 0x7553590
        public void .cctor(){} // RVA: 0x75535E0
    }

    public class Datatype_anyURI : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7555620
        public void get_FacetsChecker(){} // RVA: 0x7558040
        public void get_TypeCode(){} // RVA: 0x2AFBEE0
        public void get_ValueType(){} // RVA: 0x75580A0
        public void get_HasValueFacets(){} // RVA: 0xC2E4C0
        public void get_ListValueType(){} // RVA: 0x7558100
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void Compare(){} // RVA: 0x7558160
        public void TryParseValue(){} // RVA: 0x7558230
        public void .ctor(){} // RVA: 0x7558430
        public void .cctor(){} // RVA: 0x75584B0
    }

    public class Datatype_base64Binary : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7555620
        public void get_FacetsChecker(){} // RVA: 0x7557910
        public void get_TypeCode(){} // RVA: 0x7557970
        public void get_ValueType(){} // RVA: 0x7557980
        public void get_ListValueType(){} // RVA: 0x75579E0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void Compare(){} // RVA: 0x7557A40
        public void TryParseValue(){} // RVA: 0x7557B70
        public void .ctor(){} // RVA: 0x7557DF0
        public void .cctor(){} // RVA: 0x7557E70
    }

    public class Datatype_boolean : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7553C10
        public void get_FacetsChecker(){} // RVA: 0x7553CA0
        public void get_TypeCode(){} // RVA: 0x1A45300
        public void get_ValueType(){} // RVA: 0x7553D00
        public void get_ListValueType(){} // RVA: 0x7553D60
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x2AFB6A0
        public void Compare(){} // RVA: 0x7553DC0
        public void TryParseValue(){} // RVA: 0x7553ED0
        public void .ctor(){} // RVA: 0x7554170
        public void .cctor(){} // RVA: 0x75541F0
    }

    public class Datatype_byte : Datatype_short
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755B6D0
        public void get_TypeCode(){} // RVA: 0x701F700
        public void Compare(){} // RVA: 0x755B730
        public void get_ValueType(){} // RVA: 0x755B800
        public void get_ListValueType(){} // RVA: 0x755B860
        public void TryParseValue(){} // RVA: 0x755B8C0
        public void .ctor(){} // RVA: 0x755BB60
        public void .cctor(){} // RVA: 0x755BBF0
    }

    public class Datatype_char : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x755EC70
        public void get_ListValueType(){} // RVA: 0x755ECD0
        public void get_ValidRestrictionFlags(){} // RVA: 0xDAC980
        public void Compare(){} // RVA: 0x755ED30
        public void ParseValue(){} // RVA: 0x755EE30
        public void TryParseValue(){} // RVA: 0x755F030
        public void .ctor(){} // RVA: 0x755F390
        public void .cctor(){} // RVA: 0x755F410
    }

    public class Datatype_date : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0xD354C0
        public void .ctor(){} // RVA: 0x7556FD0
    }

    public class Datatype_dateTime : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7556E50
    }

    public class Datatype_dateTimeBase : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;
        public object dateTimeFlags;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7556290
        public void get_FacetsChecker(){} // RVA: 0x7556320
        public void get_TypeCode(){} // RVA: 0x1F7C790
        public void .ctor(){} // RVA: 0x7556380
        public void get_ValueType(){} // RVA: 0x7556410
        public void get_ListValueType(){} // RVA: 0x7556470
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x75544E0
        public void Compare(){} // RVA: 0x75564D0
        public void TryParseValue(){} // RVA: 0x7556720
        public void .cctor(){} // RVA: 0x7556BC0
    }

    public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7556D90
    }

    public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7556DF0
    }

    public class Datatype_day : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x2AFB690
        public void .ctor(){} // RVA: 0x7557150
    }

    public class Datatype_dayTimeDuration : Datatype_duration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7555FD0
        public void get_TypeCode(){} // RVA: 0x7556230
        public void .ctor(){} // RVA: 0x7556240
    }

    public class Datatype_decimal : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7554EF0
        public void get_FacetsChecker(){} // RVA: 0x7554F80
        public void get_TypeCode(){} // RVA: 0x20237F0
        public void get_ValueType(){} // RVA: 0x7554FE0
        public void get_ListValueType(){} // RVA: 0x7555040
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x75550A0
        public void Compare(){} // RVA: 0x75550B0
        public void TryParseValue(){} // RVA: 0x7555140
        public void .ctor(){} // RVA: 0x7555320
        public void .cctor(){} // RVA: 0x75553A0
    }

    public class Datatype_double : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x75543B0
        public void get_FacetsChecker(){} // RVA: 0x7554960
        public void get_TypeCode(){} // RVA: 0x2AFB680
        public void get_ValueType(){} // RVA: 0x75549C0
        public void get_ListValueType(){} // RVA: 0x7554A20
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x75544E0
        public void Compare(){} // RVA: 0x7554A80
        public void TryParseValue(){} // RVA: 0x7554AE0
        public void .ctor(){} // RVA: 0x7554CB0
        public void .cctor(){} // RVA: 0x7554D30
    }

    public class Datatype_doubleXdr : Datatype_double
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x755E330
        public void .ctor(){} // RVA: 0x755E4F0
    }

    public class Datatype_duration : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7555620
        public void get_FacetsChecker(){} // RVA: 0x7555630
        public void get_TypeCode(){} // RVA: 0x6AE0A80
        public void get_ValueType(){} // RVA: 0x7555690
        public void get_ListValueType(){} // RVA: 0x75556F0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x75544E0
        public void Compare(){} // RVA: 0x7555750
        public void TryParseValue(){} // RVA: 0x75557E0
        public void .ctor(){} // RVA: 0x7555AD0
        public void .cctor(){} // RVA: 0x7555B50
    }

    public class Datatype_fixed : Datatype_decimal
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x755F5D0
        public void TryParseValue(){} // RVA: 0x755F8A0
        public void .ctor(){} // RVA: 0x755FAF0
    }

    public class Datatype_float : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x75543B0
        public void get_FacetsChecker(){} // RVA: 0x75543C0
        public void get_TypeCode(){} // RVA: 0x1C8BCF0
        public void get_ValueType(){} // RVA: 0x7554420
        public void get_ListValueType(){} // RVA: 0x7554480
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x75544E0
        public void Compare(){} // RVA: 0x75544F0
        public void TryParseValue(){} // RVA: 0x7554550
        public void .ctor(){} // RVA: 0x7554720
        public void .cctor(){} // RVA: 0x75547A0
    }

    public class Datatype_floatXdr : Datatype_float
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x755E540
        public void .ctor(){} // RVA: 0x755E6F0
    }

    public class Datatype_hexBinary : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7555620
        public void get_FacetsChecker(){} // RVA: 0x7557210
        public void get_TypeCode(){} // RVA: 0x7557270
        public void get_ValueType(){} // RVA: 0x7557280
        public void get_ListValueType(){} // RVA: 0x75572E0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void Compare(){} // RVA: 0x7557340
        public void TryParseValue(){} // RVA: 0x7557470
        public void .ctor(){} // RVA: 0x75576C0
        public void .cctor(){} // RVA: 0x7557740
    }

    public class Datatype_int : Datatype_long
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755A670
        public void get_TypeCode(){} // RVA: 0x2AFBED0
        public void Compare(){} // RVA: 0x755A6D0
        public void get_ValueType(){} // RVA: 0x755A7C0
        public void get_ListValueType(){} // RVA: 0x755A820
        public void TryParseValue(){} // RVA: 0x755A880
        public void .ctor(){} // RVA: 0x755AC70
        public void .cctor(){} // RVA: 0x755AD00
    }

    public class Datatype_integer : Datatype_decimal
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x2AFB6A0
        public void TryParseValue(){} // RVA: 0x75596A0
        public void .ctor(){} // RVA: 0x75599E0
    }

    public class Datatype_language : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x706EEE0
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_long : Datatype_integer
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7559DD0
        public void get_HasValueFacets(){} // RVA: 0xC2E4C0
        public void get_TypeCode(){} // RVA: 0x7559E30
        public void Compare(){} // RVA: 0x7559E40
        public void get_ValueType(){} // RVA: 0x7559F30
        public void get_ListValueType(){} // RVA: 0x7559F90
        public void TryParseValue(){} // RVA: 0x7559FF0
        public void .ctor(){} // RVA: 0x75599E0
        public void .cctor(){} // RVA: 0x755A3F0
    }

    public class Datatype_month : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x10ABA40
        public void .ctor(){} // RVA: 0x75571B0
    }

    public class Datatype_monthDay : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x10AC210
        public void .ctor(){} // RVA: 0x75570F0
    }

    public class Datatype_negativeInteger : Datatype_nonPositiveInteger
    {
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7559BB0
        public void get_TypeCode(){} // RVA: 0x7559C10
        public void .ctor(){} // RVA: 0x7559C20
        public void .cctor(){} // RVA: 0x7559CB0
    }

    public class Datatype_nonNegativeInteger : Datatype_integer
    {
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755BE60
        public void get_TypeCode(){} // RVA: 0x68DAA10
        public void get_HasValueFacets(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x75599E0
        public void .cctor(){} // RVA: 0x755BEC0
    }

    public class Datatype_nonPositiveInteger : Datatype_integer
    {
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7559A30
        public void get_TypeCode(){} // RVA: 0x7559A90
        public void get_HasValueFacets(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x75599E0
        public void .cctor(){} // RVA: 0x7559AA0
    }

    public class Datatype_normalizedString : Datatype_string
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x706F050
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC3CCE0
        public void get_HasValueFacets(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_normalizedStringV1Compat : Datatype_string
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x706F050
        public void get_HasValueFacets(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_positiveInteger : Datatype_nonNegativeInteger
    {
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755E140
        public void get_TypeCode(){} // RVA: 0x2AFBEC0
        public void .ctor(){} // RVA: 0x755E1A0
        public void .cctor(){} // RVA: 0x755E230
    }

    public class Datatype_short : Datatype_int
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755AF80
        public void get_TypeCode(){} // RVA: 0x755AFE0
        public void Compare(){} // RVA: 0x755AFF0
        public void get_ValueType(){} // RVA: 0x755B0C0
        public void get_ListValueType(){} // RVA: 0x755B120
        public void TryParseValue(){} // RVA: 0x755B180
        public void .ctor(){} // RVA: 0x755B410
        public void .cctor(){} // RVA: 0x755B460
    }

    public class Datatype_string : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x75538F0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xDAC980
        public void get_FacetsChecker(){} // RVA: 0x7553980
        public void get_TypeCode(){} // RVA: 0x2AFB6E0
        public void get_TokenizedType(){} // RVA: 0xDAC980
        public void get_ValidRestrictionFlags(){} // RVA: 0x7551970
        public void TryParseValue(){} // RVA: 0x75539E0
        public void .ctor(){} // RVA: 0x7553B90
    }

    public class Datatype_time : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x1FD7BE0
        public void .ctor(){} // RVA: 0x7556F70
    }

    public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7556EB0
    }

    public class Datatype_timeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7556F10
    }

    public class Datatype_token : Datatype_normalizedString
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x2AFBE90
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x2AFBE90
        public void .ctor(){} // RVA: 0x7558C20
    }

    public class Datatype_union : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;
        public object types;

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x75524A0
        public void .ctor(){} // RVA: 0x7552500
        public void Compare(){} // RVA: 0x75525D0
        public void get_ValueType(){} // RVA: 0x75526E0
        public void get_TypeCode(){} // RVA: 0xE49B40
        public void get_FacetsChecker(){} // RVA: 0x7552740
        public void get_ListValueType(){} // RVA: 0x75527A0
        public void get_ValidRestrictionFlags(){} // RVA: 0x2AFB690
        public void get_BaseMemberTypes(){} // RVA: 0xD05CA0
        public void HasAtomicMembers(){} // RVA: 0x7552800
        public void IsUnionBaseOf(){} // RVA: 0x75528B0
        public void TryParseValue(){} // RVA: 0x7552C20
        public void .cctor(){} // RVA: 0x75530D0
    }

    public class Datatype_unsignedByte : Datatype_unsignedShort
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755D9D0
        public void get_TypeCode(){} // RVA: 0x7054470
        public void Compare(){} // RVA: 0x755DA30
        public void get_ValueType(){} // RVA: 0x755DB00
        public void get_ListValueType(){} // RVA: 0x755DB60
        public void TryParseValue(){} // RVA: 0x755DBC0
        public void .ctor(){} // RVA: 0x755DE60
        public void .cctor(){} // RVA: 0x755DEB0
    }

    public class Datatype_unsignedInt : Datatype_unsignedLong
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755C940
        public void get_TypeCode(){} // RVA: 0x2AFF4A0
        public void Compare(){} // RVA: 0x755C9A0
        public void get_ValueType(){} // RVA: 0x755CA90
        public void get_ListValueType(){} // RVA: 0x755CAF0
        public void TryParseValue(){} // RVA: 0x755CB50
        public void .ctor(){} // RVA: 0x755CF40
        public void .cctor(){} // RVA: 0x755CF90
    }

    public class Datatype_unsignedLong : Datatype_nonNegativeInteger
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755BFC0
        public void get_TypeCode(){} // RVA: 0x2AFBE50
        public void Compare(){} // RVA: 0x755C020
        public void get_ValueType(){} // RVA: 0x755C110
        public void get_ListValueType(){} // RVA: 0x755C170
        public void TryParseValue(){} // RVA: 0x755C1D0
        public void .ctor(){} // RVA: 0x755C620
        public void .cctor(){} // RVA: 0x755C6B0
    }

    public class Datatype_unsignedShort : Datatype_unsignedInt
    {
        public object atomicValueType;
        public object listValueType;
        public object numeric10FacetsChecker;

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x755D220
        public void get_TypeCode(){} // RVA: 0xE49B50
        public void Compare(){} // RVA: 0x755D280
        public void get_ValueType(){} // RVA: 0x755D350
        public void get_ListValueType(){} // RVA: 0x755D3B0
        public void TryParseValue(){} // RVA: 0x755D410
        public void .ctor(){} // RVA: 0x755D6B0
        public void .cctor(){} // RVA: 0x755D740
    }

    public class Datatype_untypedAtomicType : Datatype_anyAtomicType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7553880
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0xDAC980
        public void get_TypeCode(){} // RVA: 0x6913E80
        public void .ctor(){} // RVA: 0x75538E0
    }

    public class Datatype_uuid : Datatype_anySimpleType
    {
        public object atomicValueType;
        public object listValueType;

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x755FB40
        public void get_ListValueType(){} // RVA: 0x755FBA0
        public void get_ValidRestrictionFlags(){} // RVA: 0xDAC980
        public void Compare(){} // RVA: 0x755FC00
        public void ParseValue(){} // RVA: 0x755FD40
        public void TryParseValue(){} // RVA: 0x755FFB0
        public void .ctor(){} // RVA: 0x7560100
        public void .cctor(){} // RVA: 0x7560180
    }

    public class Datatype_year : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0xE686A0
        public void .ctor(){} // RVA: 0x7557090
    }

    public class Datatype_yearMonth : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x17321B0
        public void .ctor(){} // RVA: 0x7557030
    }

    public class Datatype_yearMonthDuration : Datatype_duration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7555D20
        public void get_TypeCode(){} // RVA: 0x70678E0
        public void .ctor(){} // RVA: 0x7555F80
    }

    public class DateTimeFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x756B6A0
        public void MatchEnumeration(){} // RVA: 0x756BB70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DfaContentValidator : ContentValidator
    {
        public object transitionTable;
        public object symbols;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7543860
        public void InitValidation(){} // RVA: 0x7543990
        public void ValidateElement(){} // RVA: 0x75439F0
        public void CompleteValidation(){} // RVA: 0x7543B40
        public void ExpectedElements(){} // RVA: 0x7543B60
        public void ExpectedParticles(){} // RVA: 0x7543D50
    }

    public class DoubleLinkAxis : Axis
    {
        public object next;

        // ── Methods ──
        public void get_Next(){} // RVA: 0xBC1B30
        public void set_Next(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0x75347E0
        public void ConvertTree(){} // RVA: 0x7534950
    }

    public class DtdValidator : BaseValidator
    {
        public object namespaceManager;
        public object validationStack;
        public object attPresence;
        public object name;
        public object IDs;
        public object idRefListHead;
        public object processIdentityConstraints;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7560350
        public void Init(){} // RVA: 0x7560450
        public void Validate(){} // RVA: 0x7560750
        public void MeetsStandAloneConstraint(){} // RVA: 0x7560B20
        public void ValidatePIComment(){} // RVA: 0x7560BD0
        public void ValidateElement(){} // RVA: 0x7560CA0
        public void ValidateChildElement(){} // RVA: 0x7560FB0
        public void ValidateStartElement(){} // RVA: 0x7561170
        public void ValidateEndStartElement(){} // RVA: 0x75617D0
        public void ProcessElement(){} // RVA: 0x75619C0
        public void CompleteValidation(){} // RVA: 0x7561C00
        public void ValidateEndElement(){} // RVA: 0x7561DC0
        public void get_PreserveWhitespace(){} // RVA: 0x7401760
        public void ProcessTokenizedType(){} // RVA: 0x7562010
        public void CheckValue(){} // RVA: 0x7562330
        public void AddID(){} // RVA: 0x7562980
        public void FindId(){} // RVA: 0x7562A80
        public void GenEntity(){} // RVA: 0x7562AB0
        public void GetEntity(){} // RVA: 0x7562CE0
        public void CheckForwardRefs(){} // RVA: 0x7562D90
        public void Push(){} // RVA: 0x7562F30
        public void Pop(){} // RVA: 0x7563220
        public void SetDefaultTypedValue(){} // RVA: 0x7563370
        public void CheckDefaultValue(){} // RVA: 0x7563610
        public void .cctor(){} // RVA: 0x7563950
    }

    public class DurationFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x756B130
        public void MatchEnumeration(){} // RVA: 0x756B520
        public void .ctor(){} // RVA: 0xB43310
    }

}