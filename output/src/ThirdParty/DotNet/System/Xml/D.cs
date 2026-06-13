// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 108

namespace ThirdParty.DotNet.System.Xml
{
    public class DomNameTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A4B580
        public void GetName(){} // RVA: 0x6A4B700
        public void AddName(){} // RVA: 0x6A4B920
        public void Grow(){} // RVA: 0x6A4BE90
    }

    public class DtdParser
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
        public void .ctor(){} // RVA: 0x6A6F360
        public void Create(){} // RVA: 0x6A6F5A0
        public void Initialize(){} // RVA: 0x6A6F5F0
        public void InitializeFreeFloatingDtd(){} // RVA: 0x6A6FA00
        public void System.Xml.IDtdParser.ParseInternalDtd(){} // RVA: 0x6A6FD70
        public void System.Xml.IDtdParser.ParseFreeFloatingDtd(){} // RVA: 0x6A6FDB0
        public void get_ParsingInternalSubset(){} // RVA: 0x6A6FE00
        public void get_IgnoreEntityReferences(){} // RVA: 0x6A6FE10
        public void get_SaveInternalSubsetValue(){} // RVA: 0x6A6FE20
        public void get_ParsingTopLevelMarkup(){} // RVA: 0x6A6FE90
        public void get_SupportNamespaces(){} // RVA: 0x16DF2D0
        public void get_Normalize(){} // RVA: 0x394D30
        public void Parse(){} // RVA: 0x6A6FEB0
        public void ParseInDocumentDtd(){} // RVA: 0x6A70230
        public void ParseFreeFloatingDtd(){} // RVA: 0x6A70450
        public void ParseInternalSubset(){} // RVA: 0x6A704B0
        public void ParseExternalSubset(){} // RVA: 0x6A704C0
        public void ParseSubset(){} // RVA: 0x6A70600
        public void ParseAttlistDecl(){} // RVA: 0x6A70C10
        public void ParseAttlistType(){} // RVA: 0x6A714B0
        public void ParseAttlistDefault(){} // RVA: 0x6A71CA0
        public void ParseElementDecl(){} // RVA: 0x6A71F20
        public void ParseElementOnlyContent(){} // RVA: 0x6A723E0
        public void ParseHowMany(){} // RVA: 0x6A72990
        public void ParseElementMixedContent(){} // RVA: 0x6A72A70
        public void ParseEntityDecl(){} // RVA: 0x6A72DB0
        public void ParseNotationDecl(){} // RVA: 0x6A73380
        public void AddUndeclaredNotation(){} // RVA: 0x6A73750
        public void ParseComment(){} // RVA: 0x6A73B30
        public void ParsePI(){} // RVA: 0x6A73D00
        public void ParseCondSection(){} // RVA: 0x6A73E10
        public void ParseExternalId(){} // RVA: 0x6A740C0
        public void GetToken(){} // RVA: 0x6A74890
        public void ScanSubsetContent(){} // RVA: 0x6A75B30
        public void ScanNameExpected(){} // RVA: 0x6A76350
        public void ScanQNameExpected(){} // RVA: 0x6A76380
        public void ScanNmtokenExpected(){} // RVA: 0x6A763B0
        public void ScanDoctype1(){} // RVA: 0x6A763E0
        public void ScanDoctype2(){} // RVA: 0x6A76520
        public void ScanClosingTag(){} // RVA: 0x6A765D0
        public void ScanElement1(){} // RVA: 0x6A76660
        public void ScanElement2(){} // RVA: 0x6A76930
        public void ScanElement3(){} // RVA: 0x6A76B60
        public void ScanElement4(){} // RVA: 0x6A76BE0
        public void ScanElement5(){} // RVA: 0x6A76CA0
        public void ScanElement6(){} // RVA: 0x6A76D90
        public void ScanElement7(){} // RVA: 0x6A76E60
        public void ScanAttlist1(){} // RVA: 0x6A76EB0
        public void ScanAttlist2(){} // RVA: 0x6A76F80
        public void ScanAttlist3(){} // RVA: 0x6A77710
        public void ScanAttlist4(){} // RVA: 0x6A777B0
        public void ScanAttlist5(){} // RVA: 0x6A77880
        public void ScanAttlist6(){} // RVA: 0x6A77950
        public void ScanAttlist7(){} // RVA: 0x6A77DF0
        public void ScanLiteral(){} // RVA: 0x6A77EB0
        public void ScanEntityName(){} // RVA: 0x6A78E90
        public void ScanNotation1(){} // RVA: 0x6A78FA0
        public void ScanSystemId(){} // RVA: 0x6A790B0
        public void ScanEntity1(){} // RVA: 0x6A79160
        public void ScanEntity2(){} // RVA: 0x6A791D0
        public void ScanEntity3(){} // RVA: 0x6A79320
        public void ScanPublicId1(){} // RVA: 0x6A79420
        public void ScanPublicId2(){} // RVA: 0x6A794E0
        public void ScanCondSection1(){} // RVA: 0x6A79550
        public void ScanCondSection2(){} // RVA: 0x6A798B0
        public void ScanCondSection3(){} // RVA: 0x6A79940
        public void ScanName(){} // RVA: 0x6A79FC0
        public void ScanQName(){} // RVA: 0x6A79FE0 | overloaded x2
        public void ReadDataInName(){} // RVA: 0x6A7A2A0
        public void ScanNmtoken(){} // RVA: 0x6A7A2E0
        public void EatPublicKeyword(){} // RVA: 0x6A7A4F0
        public void EatSystemKeyword(){} // RVA: 0x6A7A5B0
        public void GetNameQualified(){} // RVA: 0x6A7A670
        public void GetNameString(){} // RVA: 0x6A7A830
        public void GetNmtokenString(){} // RVA: 0x6A7A830
        public void GetValue(){} // RVA: 0x6A7A850
        public void GetValueWithStrippedSpaces(){} // RVA: 0x6A7A8B0
        public void ReadData(){} // RVA: 0x6A7A920
        public void LoadParsingBuffer(){} // RVA: 0x6A7A9A0
        public void SaveParsingBuffer(){} // RVA: 0x6A7AA90 | overloaded x2
        public void HandleEntityReference(){} // RVA: 0x6A7ABF0 | overloaded x2
        public void HandleEntityEnd(){} // RVA: 0x6A7AE80
        public void VerifyEntityReference(){} // RVA: 0x6A7AFF0
        public void SendValidationEvent(){} // RVA: 0x6A7B530 | overloaded x3
        public void IsAttributeValueType(){} // RVA: 0x6A7B5D0
        public void get_LineNo(){} // RVA: 0x6A7B5E0
        public void get_LinePos(){} // RVA: 0x6A7B630
        public void get_BaseUriStr(){} // RVA: 0x6A7B690
        public void OnUnexpectedError(){} // RVA: 0x6A7B740
        public void Throw(){} // RVA: 0x6A7BB80 | overloaded x4
        public void ThrowInvalidChar(){} // RVA: 0x6A7BD70 | overloaded x2
        public void ThrowUnexpectedToken(){} // RVA: 0x6A7BE40 | overloaded x2
        public void ParseUnexpectedToken(){} // RVA: 0x6A7BF90
        public void StripSpaces(){} // RVA: 0x6A7C060
    }

}