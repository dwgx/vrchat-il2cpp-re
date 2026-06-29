// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 98

namespace ThirdParty.DotNet.System.Xml
{
    public class DomNameTable : Object
    {
        public object entries;
        public object count;
        public object mask;
        public object ownerDocument;
        public object nameTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B0BC0
        public void GetName(){} // RVA: 0x74B0D40
        public void AddName(){} // RVA: 0x74B0F40
        public void Grow(){} // RVA: 0x74B1480
    }

    public class DtdParser : Object
    {
        public object readerAdapter;
        public object readerAdapterWithValidation;
        public object nameTable;
        public object schemaInfo;
        public object xmlCharType;
        public object systemId;
        public object publicId;
        public object normalize;
        public object validate;
        public object supportNamespaces;
        public object v1Compat;
        public object chars;
        public object charsUsed;
        public object curPos;
        public object scanningFunction;
        public object nextScaningFunction;
        public object savedScanningFunction;
        public object whitespaceSeen;
        public object tokenStartPos;
        public object colonPos;
        public object internalSubsetValueSb;
        public object externalEntitiesDepth;
        public object currentEntityId;
        public object freeFloatingDtd;
        public object hasFreeFloatingInternalSubset;
        public object stringBuilder;
        public object condSectionDepth;
        public object literalLineInfo;
        public object literalQuoteChar;
        public object documentBaseUri;
        public object externalDtdBaseUri;
        public object undeclaredNotations;
        public object condSectionEntityIds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D43A0
        public void Create(){} // RVA: 0x74D45C0
        public void Initialize(){} // RVA: 0x74D4610
        public void InitializeFreeFloatingDtd(){} // RVA: 0x74D4A20
        public void System.Xml.IDtdParser.ParseInternalDtd(){} // RVA: 0x74D4E70
        public void System.Xml.IDtdParser.ParseFreeFloatingDtd(){} // RVA: 0x74D4EB0
        public void get_ParsingInternalSubset(){} // RVA: 0x74D4F00
        public void get_IgnoreEntityReferences(){} // RVA: 0x74D4F10
        public void get_SaveInternalSubsetValue(){} // RVA: 0x74D4F20
        public void get_ParsingTopLevelMarkup(){} // RVA: 0x74D4F90
        public void get_SupportNamespaces(){} // RVA: 0x1FA9920
        public void get_Normalize(){} // RVA: 0xBFDA40
        public void Parse(){} // RVA: 0x74D4FB0
        public void ParseInDocumentDtd(){} // RVA: 0x74D5330
        public void ParseFreeFloatingDtd(){} // RVA: 0x74D5530
        public void ParseInternalSubset(){} // RVA: 0x74D5590
        public void ParseExternalSubset(){} // RVA: 0x74D55A0
        public void ParseSubset(){} // RVA: 0x74D56E0
        public void ParseAttlistDecl(){} // RVA: 0x74D5E00
        public void ParseAttlistType(){} // RVA: 0x74D6650
        public void ParseAttlistDefault(){} // RVA: 0x74D6E50
        public void ParseElementDecl(){} // RVA: 0x74D7090
        public void ParseElementOnlyContent(){} // RVA: 0x74D7570
        public void ParseHowMany(){} // RVA: 0x74D7A70
        public void ParseElementMixedContent(){} // RVA: 0x74D7B50
        public void ParseEntityDecl(){} // RVA: 0x74D7E90
        public void ParseNotationDecl(){} // RVA: 0x74D8470
        public void AddUndeclaredNotation(){} // RVA: 0x74D8840
        public void ParseComment(){} // RVA: 0x74D8C20
        public void ParsePI(){} // RVA: 0x74D8DF0
        public void ParseCondSection(){} // RVA: 0x74D8F00
        public void ParseExternalId(){} // RVA: 0x74D91C0
        public void GetToken(){} // RVA: 0x74D99B0
        public void ScanSubsetContent(){} // RVA: 0x74DACD0
        public void ScanNameExpected(){} // RVA: 0x74DB550
        public void ScanQNameExpected(){} // RVA: 0x74DB580
        public void ScanNmtokenExpected(){} // RVA: 0x74DB5B0
        public void ScanDoctype1(){} // RVA: 0x74DB5E0
        public void ScanDoctype2(){} // RVA: 0x74DB760
        public void ScanClosingTag(){} // RVA: 0x74DB820
        public void ScanElement1(){} // RVA: 0x74DB8B0
        public void ScanElement2(){} // RVA: 0x74DBB40
        public void ScanElement3(){} // RVA: 0x74DBD70
        public void ScanElement4(){} // RVA: 0x74DBDF0
        public void ScanElement5(){} // RVA: 0x74DBED0
        public void ScanElement6(){} // RVA: 0x74DBFD0
        public void ScanElement7(){} // RVA: 0x74DC0B0
        public void ScanAttlist1(){} // RVA: 0x74DC100
        public void ScanAttlist2(){} // RVA: 0x74DC1D0
        public void ScanAttlist3(){} // RVA: 0x74DC9A0
        public void ScanAttlist4(){} // RVA: 0x74DCA40
        public void ScanAttlist5(){} // RVA: 0x74DCB20
        public void ScanAttlist6(){} // RVA: 0x74DCC00
        public void ScanAttlist7(){} // RVA: 0x74DD090
        public void ScanLiteral(){} // RVA: 0x74DD150
        public void ScanEntityName(){} // RVA: 0x74DE050
        public void ScanNotation1(){} // RVA: 0x74DE160
        public void ScanSystemId(){} // RVA: 0x74DE2B0
        public void ScanEntity1(){} // RVA: 0x74DE360
        public void ScanEntity2(){} // RVA: 0x74DE3D0
        public void ScanEntity3(){} // RVA: 0x74DE560
        public void ScanPublicId1(){} // RVA: 0x74DE660
        public void ScanPublicId2(){} // RVA: 0x74DE720
        public void ScanCondSection1(){} // RVA: 0x74DE790
        public void ScanCondSection2(){} // RVA: 0x74DEB00
        public void ScanCondSection3(){} // RVA: 0x74DEB90
        public void ScanName(){} // RVA: 0x74DF1E0
        public void ScanQName(){} // RVA: 0x74DF200
        public void ReadDataInName(){} // RVA: 0x74DF4B0
        public void ScanNmtoken(){} // RVA: 0x74DF4F0
        public void EatPublicKeyword(){} // RVA: 0x74DF700
        public void EatSystemKeyword(){} // RVA: 0x74DF7C0
        public void GetNameQualified(){} // RVA: 0x74DF880
        public void GetNameString(){} // RVA: 0x74DFB00
        public void GetNmtokenString(){} // RVA: 0x74DFB00
        public void GetValue(){} // RVA: 0x74DFB20
        public void GetValueWithStrippedSpaces(){} // RVA: 0x74DFB80
        public void ReadData(){} // RVA: 0x74DFBF0
        public void LoadParsingBuffer(){} // RVA: 0x74DFC70
        public void SaveParsingBuffer(){} // RVA: 0x74DFD60
        public void HandleEntityReference(){} // RVA: 0x74DFEC0
        public void HandleEntityEnd(){} // RVA: 0x74E0170
        public void VerifyEntityReference(){} // RVA: 0x74E02E0
        public void SendValidationEvent(){} // RVA: 0x74E0810
        public void IsAttributeValueType(){} // RVA: 0x74E08B0
        public void get_LineNo(){} // RVA: 0x74E08C0
        public void get_LinePos(){} // RVA: 0x74E0910
        public void get_BaseUriStr(){} // RVA: 0x74E0970
        public void OnUnexpectedError(){} // RVA: 0x74E0A10
        public void Throw(){} // RVA: 0x74E0E20
        public void ThrowInvalidChar(){} // RVA: 0x74E1010
        public void ThrowUnexpectedToken(){} // RVA: 0x74E10E0
        public void ParseUnexpectedToken(){} // RVA: 0x74E1230
        public void StripSpaces(){} // RVA: 0x74E1300
    }

}