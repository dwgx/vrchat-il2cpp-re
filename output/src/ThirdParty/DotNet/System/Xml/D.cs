// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 108

namespace ThirdParty.DotNet.System.Xml
{
    public class DomNameTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758A870
        public void GetName(){} // RVA: 0x7FFE8758A9F0
        public void AddName(){} // RVA: 0x7FFE8758AC10
        public void Grow(){} // RVA: 0x7FFE8758B180
    }

    public class DtdParser : Object
    {
        public System.Xml.IDtdParserAdapter readerAdapter; // 0x10
        public System.Xml.IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
        public System.Xml.XmlNameTable nameTable; // 0x20
        public System.Xml.Schema.SchemaInfo schemaInfo; // 0x28
        public System.Xml.XmlCharType xmlCharType; // 0x30
        public string systemId; // 0x38
        public string publicId; // 0x40
        public bool normalize; // 0x48
        public bool validate; // 0x49

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875AE650
        public void Create(){} // RVA: 0x7FFE875AE890
        public void Initialize(){} // RVA: 0x7FFE875AE8E0
        public void InitializeFreeFloatingDtd(){} // RVA: 0x7FFE875AECF0
        public void System.Xml.IDtdParser.ParseInternalDtd(){} // RVA: 0x7FFE875AF060
        public void System.Xml.IDtdParser.ParseFreeFloatingDtd(){} // RVA: 0x7FFE875AF0A0
        public void get_ParsingInternalSubset(){} // RVA: 0x7FFE875AF0F0
        public void get_IgnoreEntityReferences(){} // RVA: 0x7FFE875AF100
        public void get_SaveInternalSubsetValue(){} // RVA: 0x7FFE875AF110
        public void get_ParsingTopLevelMarkup(){} // RVA: 0x7FFE875AF180
        public void get_SupportNamespaces(){} // RVA: 0x7FFE82446000
        public void get_Normalize(){} // RVA: 0x7FFE811B2D30
        public void Parse(){} // RVA: 0x7FFE875AF1A0
        public void ParseInDocumentDtd(){} // RVA: 0x7FFE875AF520
        public void ParseFreeFloatingDtd(){} // RVA: 0x7FFE875AF740
        public void ParseInternalSubset(){} // RVA: 0x7FFE875AF7A0
        public void ParseExternalSubset(){} // RVA: 0x7FFE875AF7B0
        public void ParseSubset(){} // RVA: 0x7FFE875AF8F0
        public void ParseAttlistDecl(){} // RVA: 0x7FFE875AFF00
        public void ParseAttlistType(){} // RVA: 0x7FFE875B07A0
        public void ParseAttlistDefault(){} // RVA: 0x7FFE875B0F90
        public void ParseElementDecl(){} // RVA: 0x7FFE875B1210
        public void ParseElementOnlyContent(){} // RVA: 0x7FFE875B16D0
        public void ParseHowMany(){} // RVA: 0x7FFE875B1C80
        public void ParseElementMixedContent(){} // RVA: 0x7FFE875B1D60
        public void ParseEntityDecl(){} // RVA: 0x7FFE875B20A0
        public void ParseNotationDecl(){} // RVA: 0x7FFE875B2670
        public void AddUndeclaredNotation(){} // RVA: 0x7FFE875B2A40
        public void ParseComment(){} // RVA: 0x7FFE875B2E20
        public void ParsePI(){} // RVA: 0x7FFE875B2FF0
        public void ParseCondSection(){} // RVA: 0x7FFE875B3100
        public void ParseExternalId(){} // RVA: 0x7FFE875B33B0
        public void GetToken(){} // RVA: 0x7FFE875B3B80
        public void ScanSubsetContent(){} // RVA: 0x7FFE875B4E20
        public void ScanNameExpected(){} // RVA: 0x7FFE875B5640
        public void ScanQNameExpected(){} // RVA: 0x7FFE875B5670
        public void ScanNmtokenExpected(){} // RVA: 0x7FFE875B56A0
        public void ScanDoctype1(){} // RVA: 0x7FFE875B56D0
        public void ScanDoctype2(){} // RVA: 0x7FFE875B5810
        public void ScanClosingTag(){} // RVA: 0x7FFE875B58C0
        public void ScanElement1(){} // RVA: 0x7FFE875B5950
        public void ScanElement2(){} // RVA: 0x7FFE875B5C20
        public void ScanElement3(){} // RVA: 0x7FFE875B5E50
        public void ScanElement4(){} // RVA: 0x7FFE875B5ED0
        public void ScanElement5(){} // RVA: 0x7FFE875B5F90
        public void ScanElement6(){} // RVA: 0x7FFE875B6080
        public void ScanElement7(){} // RVA: 0x7FFE875B6150
        public void ScanAttlist1(){} // RVA: 0x7FFE875B61A0
        public void ScanAttlist2(){} // RVA: 0x7FFE875B6270
        public void ScanAttlist3(){} // RVA: 0x7FFE875B6A00
        public void ScanAttlist4(){} // RVA: 0x7FFE875B6AA0
        public void ScanAttlist5(){} // RVA: 0x7FFE875B6B70
        public void ScanAttlist6(){} // RVA: 0x7FFE875B6C40
        public void ScanAttlist7(){} // RVA: 0x7FFE875B70E0
        public void ScanLiteral(){} // RVA: 0x7FFE875B71A0
        public void ScanEntityName(){} // RVA: 0x7FFE875B8180
        public void ScanNotation1(){} // RVA: 0x7FFE875B8290
        public void ScanSystemId(){} // RVA: 0x7FFE875B83A0
        public void ScanEntity1(){} // RVA: 0x7FFE875B8450
        public void ScanEntity2(){} // RVA: 0x7FFE875B84C0
        public void ScanEntity3(){} // RVA: 0x7FFE875B8610
        public void ScanPublicId1(){} // RVA: 0x7FFE875B8710
        public void ScanPublicId2(){} // RVA: 0x7FFE875B87D0
        public void ScanCondSection1(){} // RVA: 0x7FFE875B8840
        public void ScanCondSection2(){} // RVA: 0x7FFE875B8BA0
        public void ScanCondSection3(){} // RVA: 0x7FFE875B8C30
        public void ScanName(){} // RVA: 0x7FFE875B92B0
        public void ScanQName(){} // RVA: 0x7FFE875B92D0 | overloaded x2
        public void ReadDataInName(){} // RVA: 0x7FFE875B9590
        public void ScanNmtoken(){} // RVA: 0x7FFE875B95D0
        public void EatPublicKeyword(){} // RVA: 0x7FFE875B97E0
        public void EatSystemKeyword(){} // RVA: 0x7FFE875B98A0
        public void GetNameQualified(){} // RVA: 0x7FFE875B9960
        public void GetNameString(){} // RVA: 0x7FFE875B9B20
        public void GetNmtokenString(){} // RVA: 0x7FFE875B9B20
        public void GetValue(){} // RVA: 0x7FFE875B9B40
        public void GetValueWithStrippedSpaces(){} // RVA: 0x7FFE875B9BA0
        public void ReadData(){} // RVA: 0x7FFE875B9C10
        public void LoadParsingBuffer(){} // RVA: 0x7FFE875B9C90
        public void SaveParsingBuffer(){} // RVA: 0x7FFE875B9D80 | overloaded x2
        public void HandleEntityReference(){} // RVA: 0x7FFE875B9EE0 | overloaded x2
        public void HandleEntityEnd(){} // RVA: 0x7FFE875BA170
        public void VerifyEntityReference(){} // RVA: 0x7FFE875BA2E0
        public void SendValidationEvent(){} // RVA: 0x7FFE875BA820 | overloaded x3
        public void IsAttributeValueType(){} // RVA: 0x7FFE875BA8C0
        public void get_LineNo(){} // RVA: 0x7FFE875BA8D0
        public void get_LinePos(){} // RVA: 0x7FFE875BA920
        public void get_BaseUriStr(){} // RVA: 0x7FFE875BA980
        public void OnUnexpectedError(){} // RVA: 0x7FFE875BAA30
        public void Throw(){} // RVA: 0x7FFE875BAE70 | overloaded x4
        public void ThrowInvalidChar(){} // RVA: 0x7FFE875BB060 | overloaded x2
        public void ThrowUnexpectedToken(){} // RVA: 0x7FFE875BB130 | overloaded x2
        public void ParseUnexpectedToken(){} // RVA: 0x7FFE875BB280
        public void StripSpaces(){} // RVA: 0x7FFE875BB350
    }

}