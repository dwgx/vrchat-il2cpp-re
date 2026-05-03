// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 68
// Methods: 438

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class DatatypeImplementation : XmlSchemaDatatype
    {
        public 0x66559954 variety; // 0x10
        public System.Xml.Schema.RestrictionFacets restriction; // 0x18
        public System.Xml.Schema.DatatypeImplementation baseType; // 0x20
        public System.Xml.Schema.XmlValueConverter valueConverter; // 0x28
        public System.Xml.Schema.XmlSchemaType parentSchemaType; // 0x30
        public System.Collections.Hashtable builtinTypes;
        public System.Xml.Schema.XmlSchemaSimpleType[] enumToTypeCode; // 0x8
        public System.Xml.Schema.XmlSchemaSimpleType anySimpleType; // 0x10
        public System.Xml.Schema.XmlSchemaSimpleType anyAtomicType; // 0x18
        public System.Xml.Schema.XmlSchemaSimpleType untypedAtomicType; // 0x20
        public System.Xml.Schema.XmlSchemaSimpleType yearMonthDurationType; // 0x28
        public System.Xml.Schema.XmlSchemaSimpleType dayTimeDurationType; // 0x30
        public System.Xml.Schema.XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
        public System.Xml.Schema.XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
        public System.Xml.XmlQualifiedName QnAnySimpleType; // 0x48

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87622010
        public void get_AnySimpleType(){} // RVA: 0x7FFE87627F60
        public void get_UntypedAtomicType(){} // RVA: 0x7FFE87627FC0
        public void FromXmlTokenizedType(){} // RVA: 0x7FFE87628020
        public void FromXmlTokenizedTypeXsd(){} // RVA: 0x7FFE876280A0
        public void FromXdrName(){} // RVA: 0x7FFE87628120
        public void FromTypeName(){} // RVA: 0x7FFE876282B0
        public void StartBuiltinType(){} // RVA: 0x7FFE87628440
        public void FinishBuiltinType(){} // RVA: 0x7FFE87628680
        public void CreateBuiltinTypes(){} // RVA: 0x7FFE87628AD0
        public void GetSimpleTypeFromTypeCode(){} // RVA: 0x7FFE87629CF0
        public void GetSimpleTypeFromXsdType(){} // RVA: 0x7FFE87629D70
        public void GetNormalizedStringTypeV1Compat(){} // RVA: 0x7FFE87629E40
        public void GetTokenTypeV1Compat(){} // RVA: 0x7FFE8762A1B0
        public void GetBuiltInTypes(){} // RVA: 0x7FFE8762A520
        public void GetPrimitiveTypeCode(){} // RVA: 0x7FFE8762A580
        public void DeriveByRestriction(){} // RVA: 0x7FFE8762A6F0
        public void DeriveByList(){} // RVA: 0x7FFE8762A950 | overloaded x2
        public void DeriveByUnion(){} // RVA: 0x7FFE8762AD70
        public void VerifySchemaValid(){} // RVA: 0x7FFE810FB310
        public void IsDerivedFrom(){} // RVA: 0x7FFE8762AF70
        public void IsEqual(){} // RVA: 0x7FFE8762B260
        public void IsComparable(){} // RVA: 0x7FFE8762B290
        public void CreateValueConverter(){} // RVA: 0x7FFE813240E0
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762B390
        public void get_ValueConverter(){} // RVA: 0x7FFE8762B3F0
        public void get_TokenizedType(){} // RVA: 0x7FFE835C1DE0
        public void get_ValueType(){} // RVA: 0x7FFE8762B480
        public void get_Variety(){} // RVA: 0x7FFE811485C0
        public void get_TypeCode(){} // RVA: 0x7FFE813240E0
        public void get_Restriction(){} // RVA: 0x7FFE810FE7C0
        public void get_HasLexicalFacets(){} // RVA: 0x7FFE8762B530
        public void get_HasValueFacets(){} // RVA: 0x7FFE8762B550
        public void get_Base(){} // RVA: 0x7FFE811290C0
        public void get_ListValueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE80E2EDB0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE813240E0
        public void ParseValue(){} // RVA: 0x7FFE8762B780 | overloaded x2
        public void TryParseValue(){} // RVA: 0x7FFE8762B920
        public void GetTypeName(){} // RVA: 0x7FFE8762BD00
        public void Compare(){} // RVA: 0x7FFE8762BD80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Datatype_ENTITY : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87634290
        public void get_TokenizedType(){} // RVA: 0x7FFE8180E590
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_ENUMERATION : Datatype_NMTOKEN
    {
        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x7FFE8249F650
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_ID : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87634280
        public void get_TokenizedType(){} // RVA: 0x7FFE811EDAF0
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_IDREF : Datatype_NCName
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87140AE0
        public void get_TokenizedType(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_List : Datatype_anySimpleType
    {
        public System.Xml.Schema.DatatypeImplementation itemType; // 0x38
        public int minListSize; // 0x40
        public object field_2; // 0x410
        public object field_3; // 0x411
        public object field_4; // 0x412
        public object field_5; // 0x413

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762BF10
        public void .ctor(){} // RVA: 0x7FFE8762C490
        public void Compare(){} // RVA: 0x7FFE8762C580
        public void get_ValueType(){} // RVA: 0x7FFE8762C860
        public void get_TokenizedType(){} // RVA: 0x7FFE8762C880
        public void get_ListValueType(){} // RVA: 0x7FFE8762C8B0
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762C8E0
        public void get_TypeCode(){} // RVA: 0x7FFE84329C20
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void TryParseValue(){} // RVA: 0x7FFE8762CF70 | overloaded x2
    }

    public class Datatype_NCName : Datatype_Name
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE835C5CB0
        public void TryParseValue(){} // RVA: 0x7FFE87634090
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_NMTOKEN : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87560EE0
        public void get_TokenizedType(){} // RVA: 0x7FFE81815210
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_NOTATION : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x486
        public object field_3; // 0x487
        public object field_4; // 0x488
        public object field_5; // 0x489
        public object field_6; // 0x48A

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87630860
        public void get_FacetsChecker(){} // RVA: 0x7FFE876342A0
        public void get_TypeCode(){} // RVA: 0x7FFE835C5E00
        public void get_TokenizedType(){} // RVA: 0x7FFE82199910
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void get_ValueType(){} // RVA: 0x7FFE87634300
        public void get_ListValueType(){} // RVA: 0x7FFE87634360
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void TryParseValue(){} // RVA: 0x7FFE876343C0
        public void VerifySchemaValid(){} // RVA: 0x7FFE87634600
        public void .ctor(){} // RVA: 0x7FFE876348B0
        public void .cctor(){} // RVA: 0x7FFE87634930
    }

    public class Datatype_Name : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87634080
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_QName : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x46C
        public object field_3; // 0x46D
        public object field_4; // 0x46E
        public object field_5; // 0x46F
        public object field_6; // 0x470

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87630860
        public void get_FacetsChecker(){} // RVA: 0x7FFE87633A70
        public void get_TypeCode(){} // RVA: 0x7FFE835C5DC0
        public void get_TokenizedType(){} // RVA: 0x7FFE813B49D0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void get_ValueType(){} // RVA: 0x7FFE87633AD0
        public void get_ListValueType(){} // RVA: 0x7FFE87633B30
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void TryParseValue(){} // RVA: 0x7FFE87633B90
        public void .ctor(){} // RVA: 0x7FFE87633DD0
        public void .cctor(){} // RVA: 0x7FFE87633E50
    }

    public class Datatype_QNameXdr : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x4B9

        // ── Methods ──
        public void get_TokenizedType(){} // RVA: 0x7FFE813B49D0
        public void ParseValue(){} // RVA: 0x7FFE87639DD0
        public void get_ValueType(){} // RVA: 0x7FFE87639FF0
        public void get_ListValueType(){} // RVA: 0x7FFE8763A050
        public void .ctor(){} // RVA: 0x7FFE8763A0B0
        public void .cctor(){} // RVA: 0x7FFE8763A130
    }

    public class Datatype_anyAtomicType : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762E880
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE813240E0
        public void get_TypeCode(){} // RVA: 0x7FFE813B49D0
        public void .ctor(){} // RVA: 0x7FFE8762E8E0
    }

    public class Datatype_anySimpleType : DatatypeImplementation
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x41C
        public object field_3; // 0x41D
        public object field_4; // 0x41E
        public object field_5; // 0x41F
        public object field_6; // 0x420

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762E310
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762E370
        public void get_ValueType(){} // RVA: 0x7FFE8762E3D0
        public void get_TypeCode(){} // RVA: 0x7FFE813B49D0
        public void get_ListValueType(){} // RVA: 0x7FFE8762E430
        public void get_TokenizedType(){} // RVA: 0x7FFE835C1DE0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE813240E0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void Compare(){} // RVA: 0x7FFE8762E490
        public void TryParseValue(){} // RVA: 0x7FFE8762E5A0
        public void .ctor(){} // RVA: 0x7FFE8762E610
        public void .cctor(){} // RVA: 0x7FFE8762E660
    }

    public class Datatype_anyURI : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x465
        public object field_3; // 0x466
        public object field_4; // 0x467
        public object field_5; // 0x468
        public object field_6; // 0x469

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87630860
        public void get_FacetsChecker(){} // RVA: 0x7FFE876333D0
        public void get_TypeCode(){} // RVA: 0x7FFE87633430
        public void get_ValueType(){} // RVA: 0x7FFE87633440
        public void get_HasValueFacets(){} // RVA: 0x7FFE811E0850
        public void get_ListValueType(){} // RVA: 0x7FFE876334A0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void Compare(){} // RVA: 0x7FFE87633500
        public void TryParseValue(){} // RVA: 0x7FFE876335D0
        public void .ctor(){} // RVA: 0x7FFE876337D0
        public void .cctor(){} // RVA: 0x7FFE87633850
    }

    public class Datatype_base64Binary : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x45F
        public object field_3; // 0x460
        public object field_4; // 0x461
        public object field_5; // 0x462

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87630860
        public void get_FacetsChecker(){} // RVA: 0x7FFE87632C60
        public void get_TypeCode(){} // RVA: 0x7FFE87632CC0
        public void get_ValueType(){} // RVA: 0x7FFE87632CD0
        public void get_ListValueType(){} // RVA: 0x7FFE87632D30
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void Compare(){} // RVA: 0x7FFE87632D90
        public void TryParseValue(){} // RVA: 0x7FFE87632EB0
        public void .ctor(){} // RVA: 0x7FFE87633130
        public void .cctor(){} // RVA: 0x7FFE876331B0
    }

    public class Datatype_boolean : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x42C
        public object field_3; // 0x42D
        public object field_4; // 0x42E
        public object field_5; // 0x42F

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762ECF0
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762ED80
        public void get_TypeCode(){} // RVA: 0x7FFE81EE2040
        public void get_ValueType(){} // RVA: 0x7FFE8762EDE0
        public void get_ListValueType(){} // RVA: 0x7FFE8762EE40
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE835C1DA0
        public void Compare(){} // RVA: 0x7FFE8762EEA0
        public void TryParseValue(){} // RVA: 0x7FFE8762EF30
        public void .ctor(){} // RVA: 0x7FFE8762F1E0
        public void .cctor(){} // RVA: 0x7FFE8762F260
    }

    public class Datatype_byte : Datatype_short
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x4A0

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87636AD0
        public void get_TypeCode(){} // RVA: 0x7FFE870EFE80
        public void Compare(){} // RVA: 0x7FFE87636B30
        public void get_ValueType(){} // RVA: 0x7FFE87636C60
        public void get_ListValueType(){} // RVA: 0x7FFE87636CC0
        public void TryParseValue(){} // RVA: 0x7FFE87636D20
        public void .ctor(){} // RVA: 0x7FFE87636FD0
        public void .cctor(){} // RVA: 0x7FFE87637060
    }

    public class Datatype_char : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x4BD

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFE8763A350
        public void get_ListValueType(){} // RVA: 0x7FFE8763A3B0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE813240E0
        public void Compare(){} // RVA: 0x7FFE8763A410
        public void ParseValue(){} // RVA: 0x7FFE8763A550
        public void TryParseValue(){} // RVA: 0x7FFE8763A770
        public void .ctor(){} // RVA: 0x7FFE8763AAF0
        public void .cctor(){} // RVA: 0x7FFE8763AB70
    }

    public class Datatype_date : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE813FC490
        public void .ctor(){} // RVA: 0x7FFE876322E0
    }

    public class Datatype_dateTime : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87632160
    }

    public class Datatype_dateTimeBase : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public 0x6655EDE4 dateTimeFlags; // 0x38
        public object field_3; // 0x44C
        public object field_4; // 0x44D
        public object field_5; // 0x44E

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87631550
        public void get_FacetsChecker(){} // RVA: 0x7FFE876315E0
        public void get_TypeCode(){} // RVA: 0x7FFE823EBAD0
        public void .ctor(){} // RVA: 0x7FFE87631640
        public void get_ValueType(){} // RVA: 0x7FFE876316D0
        public void get_ListValueType(){} // RVA: 0x7FFE87631730
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762F5B0
        public void Compare(){} // RVA: 0x7FFE87631790
        public void TryParseValue(){} // RVA: 0x7FFE876319E0
        public void .cctor(){} // RVA: 0x7FFE87631E80
    }

    public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876320A0
    }

    public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87632100
    }

    public class Datatype_day : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE835C1D90
        public void .ctor(){} // RVA: 0x7FFE87632460
    }

    public class Datatype_dayTimeDuration : Datatype_duration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7FFE87631280
        public void get_TypeCode(){} // RVA: 0x7FFE876314F0
        public void .ctor(){} // RVA: 0x7FFE87631500
    }

    public class Datatype_decimal : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x43E
        public object field_4; // 0x43F
        public object field_5; // 0x440

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE876300E0
        public void get_FacetsChecker(){} // RVA: 0x7FFE87630170
        public void get_TypeCode(){} // RVA: 0x7FFE824BF490
        public void get_ValueType(){} // RVA: 0x7FFE876301D0
        public void get_ListValueType(){} // RVA: 0x7FFE87630230
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE87630290
        public void Compare(){} // RVA: 0x7FFE876302A0
        public void TryParseValue(){} // RVA: 0x7FFE87630330
        public void .ctor(){} // RVA: 0x7FFE87630510
        public void .cctor(){} // RVA: 0x7FFE87630590
    }

    public class Datatype_double : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x438
        public object field_3; // 0x439
        public object field_4; // 0x43A
        public object field_5; // 0x43B

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762F480
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762FAC0
        public void get_TypeCode(){} // RVA: 0x7FFE835C1D80
        public void get_ValueType(){} // RVA: 0x7FFE8762FB20
        public void get_ListValueType(){} // RVA: 0x7FFE8762FB80
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762F5B0
        public void Compare(){} // RVA: 0x7FFE8762FBE0
        public void TryParseValue(){} // RVA: 0x7FFE8762FC60
        public void .ctor(){} // RVA: 0x7FFE8762FE40
        public void .cctor(){} // RVA: 0x7FFE8762FEC0
    }

    public class Datatype_doubleXdr : Datatype_double
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7FFE876399A0
        public void .ctor(){} // RVA: 0x7FFE87639B70
    }

    public class Datatype_duration : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x444
        public object field_3; // 0x445
        public object field_4; // 0x446
        public object field_5; // 0x447

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87630860
        public void get_FacetsChecker(){} // RVA: 0x7FFE87630870
        public void get_TypeCode(){} // RVA: 0x7FFE86BADF70
        public void get_ValueType(){} // RVA: 0x7FFE876308D0
        public void get_ListValueType(){} // RVA: 0x7FFE87630930
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762F5B0
        public void Compare(){} // RVA: 0x7FFE87630990
        public void TryParseValue(){} // RVA: 0x7FFE87630A20
        public void .ctor(){} // RVA: 0x7FFE87630D20
        public void .cctor(){} // RVA: 0x7FFE87630DA0
    }

    public class Datatype_fixed : Datatype_decimal
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7FFE8763AD90
        public void TryParseValue(){} // RVA: 0x7FFE8763B060
        public void .ctor(){} // RVA: 0x7FFE8763B2A0
    }

    public class Datatype_float : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x432
        public object field_3; // 0x433
        public object field_4; // 0x434
        public object field_5; // 0x435

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762F480
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762F490
        public void get_TypeCode(){} // RVA: 0x7FFE82127E50
        public void get_ValueType(){} // RVA: 0x7FFE8762F4F0
        public void get_ListValueType(){} // RVA: 0x7FFE8762F550
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762F5B0
        public void Compare(){} // RVA: 0x7FFE8762F5C0
        public void TryParseValue(){} // RVA: 0x7FFE8762F640
        public void .ctor(){} // RVA: 0x7FFE8762F820
        public void .cctor(){} // RVA: 0x7FFE8762F8A0
    }

    public class Datatype_floatXdr : Datatype_float
    {
        // ── Methods ──
        public void ParseValue(){} // RVA: 0x7FFE87639BC0
        public void .ctor(){} // RVA: 0x7FFE87639D80
    }

    public class Datatype_hexBinary : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x459
        public object field_3; // 0x45A
        public object field_4; // 0x45B
        public object field_5; // 0x45C

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE87630860
        public void get_FacetsChecker(){} // RVA: 0x7FFE87632520
        public void get_TypeCode(){} // RVA: 0x7FFE87632580
        public void get_ValueType(){} // RVA: 0x7FFE87632590
        public void get_ListValueType(){} // RVA: 0x7FFE876325F0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void Compare(){} // RVA: 0x7FFE87632650
        public void TryParseValue(){} // RVA: 0x7FFE87632770
        public void .ctor(){} // RVA: 0x7FFE876329C0
        public void .cctor(){} // RVA: 0x7FFE87632A40
    }

    public class Datatype_int : Datatype_long
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x498

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87635990
        public void get_TypeCode(){} // RVA: 0x7FFE835C5DA0
        public void Compare(){} // RVA: 0x7FFE876359F0
        public void get_ValueType(){} // RVA: 0x7FFE87635A70
        public void get_ListValueType(){} // RVA: 0x7FFE87635AD0
        public void TryParseValue(){} // RVA: 0x7FFE87635B30
        public void .ctor(){} // RVA: 0x7FFE87635F30
        public void .cctor(){} // RVA: 0x7FFE87635FC0
    }

    public class Datatype_integer : Datatype_decimal
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE835C1DA0
        public void TryParseValue(){} // RVA: 0x7FFE87634B50
        public void .ctor(){} // RVA: 0x7FFE87634D00
    }

    public class Datatype_language : Datatype_token
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE8713FFC0
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_long : Datatype_integer
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x493
        public object field_4; // 0x494

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE876350F0
        public void get_HasValueFacets(){} // RVA: 0x7FFE811E0850
        public void get_TypeCode(){} // RVA: 0x7FFE87635150
        public void Compare(){} // RVA: 0x7FFE87635160
        public void get_ValueType(){} // RVA: 0x7FFE876351E0
        public void get_ListValueType(){} // RVA: 0x7FFE87635240
        public void TryParseValue(){} // RVA: 0x7FFE876352A0
        public void .ctor(){} // RVA: 0x7FFE87634D00
        public void .cctor(){} // RVA: 0x7FFE876356B0
    }

    public class Datatype_month : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE835C5E20
        public void .ctor(){} // RVA: 0x7FFE876324C0
    }

    public class Datatype_monthDay : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE8178CF30
        public void .ctor(){} // RVA: 0x7FFE87632400
    }

    public class Datatype_negativeInteger : Datatype_nonPositiveInteger
    {
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker;
        public object field_1; // 0x491

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87634ED0
        public void get_TypeCode(){} // RVA: 0x7FFE87634F30
        public void .ctor(){} // RVA: 0x7FFE87634F40
        public void .cctor(){} // RVA: 0x7FFE87634FD0
    }

    public class Datatype_nonNegativeInteger : Datatype_integer
    {
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker;
        public object field_1; // 0x4A4
        public object field_2; // 0x4A5

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87637330
        public void get_TypeCode(){} // RVA: 0x7FFE869A2440
        public void get_HasValueFacets(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE87634D00
        public void .cctor(){} // RVA: 0x7FFE87637390
    }

    public class Datatype_nonPositiveInteger : Datatype_integer
    {
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker;
        public object field_1; // 0x48E
        public object field_2; // 0x48F

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87634D50
        public void get_TypeCode(){} // RVA: 0x7FFE87634DB0
        public void get_HasValueFacets(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE87634D00
        public void .cctor(){} // RVA: 0x7FFE87634DC0
    }

    public class Datatype_normalizedString : Datatype_string
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87140130
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE811EDAF0
        public void get_HasValueFacets(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_normalizedStringV1Compat : Datatype_string
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE87140130
        public void get_HasValueFacets(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_positiveInteger : Datatype_nonNegativeInteger
    {
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker;
        public object field_1; // 0x4B7

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE876397B0
        public void get_TypeCode(){} // RVA: 0x7FFE835C5D10
        public void .ctor(){} // RVA: 0x7FFE87639810
        public void .cctor(){} // RVA: 0x7FFE876398A0
    }

    public class Datatype_short : Datatype_int
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x49C

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE876362A0
        public void get_TypeCode(){} // RVA: 0x7FFE87636300
        public void Compare(){} // RVA: 0x7FFE87636310
        public void get_ValueType(){} // RVA: 0x7FFE87636440
        public void get_ListValueType(){} // RVA: 0x7FFE876364A0
        public void TryParseValue(){} // RVA: 0x7FFE87636500
        public void .ctor(){} // RVA: 0x7FFE876367B0
        public void .cctor(){} // RVA: 0x7FFE87636800
    }

    public class Datatype_string : Datatype_anySimpleType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762E9D0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE813240E0
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762EA60
        public void get_TypeCode(){} // RVA: 0x7FFE835C1DE0
        public void get_TokenizedType(){} // RVA: 0x7FFE813240E0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE8762C940
        public void TryParseValue(){} // RVA: 0x7FFE8762EAC0
        public void .ctor(){} // RVA: 0x7FFE8762EC70
    }

    public class Datatype_time : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE8246E550
        public void .ctor(){} // RVA: 0x7FFE87632280
    }

    public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876321C0
    }

    public class Datatype_timeTimeZone : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87632220
    }

    public class Datatype_token : Datatype_normalizedString
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE835C28C0
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE835C28C0
        public void .ctor(){} // RVA: 0x7FFE87634070
    }

    public class Datatype_union : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.XmlSchemaSimpleType[] types; // 0x38
        public object field_3; // 0x416
        public object field_4; // 0x417
        public object field_5; // 0x418

        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762D4D0
        public void .ctor(){} // RVA: 0x7FFE8762D530
        public void Compare(){} // RVA: 0x7FFE8762D600
        public void get_ValueType(){} // RVA: 0x7FFE8762D710
        public void get_TypeCode(){} // RVA: 0x7FFE813B49D0
        public void get_FacetsChecker(){} // RVA: 0x7FFE8762D770
        public void get_ListValueType(){} // RVA: 0x7FFE8762D7D0
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE835C1D90
        public void get_BaseMemberTypes(){} // RVA: 0x7FFE8143BA80
        public void HasAtomicMembers(){} // RVA: 0x7FFE8762D830
        public void IsUnionBaseOf(){} // RVA: 0x7FFE8762D8D0
        public void TryParseValue(){} // RVA: 0x7FFE8762DC30 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8762E0F0
    }

    public class Datatype_unsignedByte : Datatype_unsignedShort
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x4B3

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87638F70
        public void get_TypeCode(){} // RVA: 0x7FFE871250B0
        public void Compare(){} // RVA: 0x7FFE87638FD0
        public void get_ValueType(){} // RVA: 0x7FFE87639100
        public void get_ListValueType(){} // RVA: 0x7FFE87639160
        public void TryParseValue(){} // RVA: 0x7FFE876391C0
        public void .ctor(){} // RVA: 0x7FFE87639470
        public void .cctor(){} // RVA: 0x7FFE876394C0
    }

    public class Datatype_unsignedInt : Datatype_unsignedLong
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x4AB

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87637E10
        public void get_TypeCode(){} // RVA: 0x7FFE835C5D60
        public void Compare(){} // RVA: 0x7FFE87637E70
        public void get_ValueType(){} // RVA: 0x7FFE87637EF0
        public void get_ListValueType(){} // RVA: 0x7FFE87637F50
        public void TryParseValue(){} // RVA: 0x7FFE87637FB0
        public void .ctor(){} // RVA: 0x7FFE876383B0
        public void .cctor(){} // RVA: 0x7FFE87638400
    }

    public class Datatype_unsignedLong : Datatype_nonNegativeInteger
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x4A7

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE87637490
        public void get_TypeCode(){} // RVA: 0x7FFE835C28A0
        public void Compare(){} // RVA: 0x7FFE876374F0
        public void get_ValueType(){} // RVA: 0x7FFE87637570
        public void get_ListValueType(){} // RVA: 0x7FFE876375D0
        public void TryParseValue(){} // RVA: 0x7FFE87637630
        public void .ctor(){} // RVA: 0x7FFE87637A90
        public void .cctor(){} // RVA: 0x7FFE87637B20
    }

    public class Datatype_unsignedShort : Datatype_unsignedInt
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public System.Xml.Schema.FacetsChecker numeric10FacetsChecker; // 0x10
        public object field_3; // 0x4AF

        // ── Methods ──
        public void get_FacetsChecker(){} // RVA: 0x7FFE876386F0
        public void get_TypeCode(){} // RVA: 0x7FFE813B49E0
        public void Compare(){} // RVA: 0x7FFE87638750
        public void get_ValueType(){} // RVA: 0x7FFE87638880
        public void get_ListValueType(){} // RVA: 0x7FFE876388E0
        public void TryParseValue(){} // RVA: 0x7FFE87638940
        public void .ctor(){} // RVA: 0x7FFE87638BF0
        public void .cctor(){} // RVA: 0x7FFE87638C80
    }

    public class Datatype_untypedAtomicType : Datatype_anyAtomicType
    {
        // ── Methods ──
        public void CreateValueConverter(){} // RVA: 0x7FFE8762E960
        public void get_BuiltInWhitespaceFacet(){} // RVA: 0x7FFE813240E0
        public void get_TypeCode(){} // RVA: 0x7FFE869DB780
        public void .ctor(){} // RVA: 0x7FFE8762E9C0
    }

    public class Datatype_uuid : Datatype_anySimpleType
    {
        public System.Type atomicValueType;
        public System.Type listValueType; // 0x8
        public object field_2; // 0x4C0

        // ── Methods ──
        public void get_ValueType(){} // RVA: 0x7FFE8763B2F0
        public void get_ListValueType(){} // RVA: 0x7FFE8763B350
        public void get_ValidRestrictionFlags(){} // RVA: 0x7FFE813240E0
        public void Compare(){} // RVA: 0x7FFE8763B3B0
        public void ParseValue(){} // RVA: 0x7FFE8763B4F0
        public void TryParseValue(){} // RVA: 0x7FFE8763B760
        public void .ctor(){} // RVA: 0x7FFE8763B8B0
        public void .cctor(){} // RVA: 0x7FFE8763B930
    }

    public class Datatype_year : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE813DA8C0
        public void .ctor(){} // RVA: 0x7FFE876323A0
    }

    public class Datatype_yearMonth : Datatype_dateTimeBase
    {
        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE81BE6F60
        public void .ctor(){} // RVA: 0x7FFE87632340
    }

    public class Datatype_yearMonthDuration : Datatype_duration
    {
        // ── Methods ──
        public void TryParseValue(){} // RVA: 0x7FFE87630FC0
        public void get_TypeCode(){} // RVA: 0x7FFE87138970
        public void .ctor(){} // RVA: 0x7FFE87631230
    }

    public class DateTimeFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFE87647010 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFE87647500 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DfaContentValidator : ContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8761E740
        public void InitValidation(){} // RVA: 0x7FFE8761E870
        public void ValidateElement(){} // RVA: 0x7FFE8761E8D0
        public void CompleteValidation(){} // RVA: 0x7FFE8761EA20
        public void ExpectedElements(){} // RVA: 0x7FFE8761EA40
        public void ExpectedParticles(){} // RVA: 0x7FFE8761EC30
    }

    public class DoubleLinkAxis : Axis
    {
        public MS.Internal.Xml.XPath.Axis next; // 0x40

        // ── Methods ──
        public void get_Next(){} // RVA: 0x7FFE81178740
        public void set_Next(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE8760F670
        public void ConvertTree(){} // RVA: 0x7FFE8760F7E0
    }

    public class DtdValidator : BaseValidator
    {
        public NamespaceManager namespaceManager;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8763BB50
        public void Init(){} // RVA: 0x7FFE8763BC50
        public void Validate(){} // RVA: 0x7FFE8763BF50
        public void MeetsStandAloneConstraint(){} // RVA: 0x7FFE8763C330
        public void ValidatePIComment(){} // RVA: 0x7FFE8763C3D0
        public void ValidateElement(){} // RVA: 0x7FFE8763C4C0
        public void ValidateChildElement(){} // RVA: 0x7FFE8763C7C0
        public void ValidateStartElement(){} // RVA: 0x7FFE8763C990
        public void ValidateEndStartElement(){} // RVA: 0x7FFE8763CFF0
        public void ProcessElement(){} // RVA: 0x7FFE8763D200
        public void CompleteValidation(){} // RVA: 0x7FFE8763D440
        public void ValidateEndElement(){} // RVA: 0x7FFE8763D600
        public void get_PreserveWhitespace(){} // RVA: 0x7FFE874DAF10
        public void ProcessTokenizedType(){} // RVA: 0x7FFE8763D870
        public void CheckValue(){} // RVA: 0x7FFE8763DB90
        public void AddID(){} // RVA: 0x7FFE8763E1F0
        public void FindId(){} // RVA: 0x7FFE8763E2F0
        public void GenEntity(){} // RVA: 0x7FFE8763E320
        public void GetEntity(){} // RVA: 0x7FFE8763E530
        public void CheckForwardRefs(){} // RVA: 0x7FFE8763E5F0
        public void Push(){} // RVA: 0x7FFE8763E790
        public void Pop(){} // RVA: 0x7FFE8763EA80
        public void SetDefaultTypedValue(){} // RVA: 0x7FFE8763EBD0
        public void CheckDefaultValue(){} // RVA: 0x7FFE8763EE80
        public void .cctor(){} // RVA: 0x7FFE8763F1D0
    }

    public class DurationFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFE87646A90 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFE87646E90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}