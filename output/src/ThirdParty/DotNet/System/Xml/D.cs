// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 108

namespace ThirdParty.DotNet.System.Xml
{
    public class DomNameTable : Object
    {
        public System.Xml.XmlName[] entries; // 0x10
        public int count; // 0x18
        public int mask; // 0x1C
        public System.Xml.XmlDocument ownerDocument; // 0x20
        public System.Xml.XmlNameTable nameTable; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E2100
        public void GetName(){} // RVA: 0x7FFAC91E2280
        public void AddName(){} // RVA: 0x7FFAC91E24A0
        public void Grow(){} // RVA: 0x7FFAC91E2A10
    }

    public class DtdParser : Object
    {
        public System.Xml.IDtdParserAdapter ParsingInternalSubset; // 0x10
        public System.Xml.IDtdParserAdapterWithValidation IgnoreEntityReferences; // 0x18
        public System.Xml.XmlNameTable SaveInternalSubsetValue; // 0x20
        public System.Xml.Schema.SchemaInfo ParsingTopLevelMarkup; // 0x28
        public System.Xml.XmlCharType SupportNamespaces; // 0x30
        public string Normalize; // 0x38
        public string LineNo; // 0x40
        public bool LinePos; // 0x48
        public bool BaseUriStr; // 0x49
        public bool supportNamespaces; // 0x4A
        public bool v1Compat; // 0x4B
        public char[] chars; // 0x50
        public int charsUsed; // 0x58
        public int curPos; // 0x5C
        public 0x6B15C9E8 scanningFunction; // 0x60
        public 0x6B15C9E8 nextScaningFunction; // 0x64
        public 0x6B15C9E8 savedScanningFunction; // 0x68
        public bool whitespaceSeen; // 0x6C
        public int tokenStartPos; // 0x70
        public int colonPos; // 0x74
        public System.Text.StringBuilder internalSubsetValueSb; // 0x78
        public int externalEntitiesDepth; // 0x80
        public int currentEntityId; // 0x84
        public bool freeFloatingDtd; // 0x88
        public bool hasFreeFloatingInternalSubset; // 0x89
        public System.Text.StringBuilder stringBuilder; // 0x90
        public int condSectionDepth; // 0x98
        public System.Xml.LineInfo literalLineInfo; // 0x9C
        public char literalQuoteChar; // 0xA4
        public string documentBaseUri; // 0xA8
        public string externalDtdBaseUri; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,UndeclaredNotation> undeclaredNotations; // 0xB8
        public int[] condSectionEntityIds; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9205EE0
        public void Create(){} // RVA: 0x7FFAC9206120
        public void Initialize(){} // RVA: 0x7FFAC9206170
        public void InitializeFreeFloatingDtd(){} // RVA: 0x7FFAC9206580
        public void System.Xml.IDtdParser.ParseInternalDtd(){} // RVA: 0x7FFAC92068F0
        public void System.Xml.IDtdParser.ParseFreeFloatingDtd(){} // RVA: 0x7FFAC9206930
        public void get_ParsingInternalSubset(){} // RVA: 0x7FFAC9206980
        public void get_IgnoreEntityReferences(){} // RVA: 0x7FFAC9206990
        public void get_SaveInternalSubsetValue(){} // RVA: 0x7FFAC92069A0
        public void get_ParsingTopLevelMarkup(){} // RVA: 0x7FFAC9206A10
        public void get_SupportNamespaces(){} // RVA: 0x7FFAC41656F0
        public void get_Normalize(){} // RVA: 0x7FFAC2FD8D30
        public void Parse(){} // RVA: 0x7FFAC9206A30
        public void ParseInDocumentDtd(){} // RVA: 0x7FFAC9206DB0
        public void ParseFreeFloatingDtd(){} // RVA: 0x7FFAC9206FD0
        public void ParseInternalSubset(){} // RVA: 0x7FFAC9207030
        public void ParseExternalSubset(){} // RVA: 0x7FFAC9207040
        public void ParseSubset(){} // RVA: 0x7FFAC9207180
        public void ParseAttlistDecl(){} // RVA: 0x7FFAC9207790
        public void ParseAttlistType(){} // RVA: 0x7FFAC9208030
        public void ParseAttlistDefault(){} // RVA: 0x7FFAC9208820
        public void ParseElementDecl(){} // RVA: 0x7FFAC9208AA0
        public void ParseElementOnlyContent(){} // RVA: 0x7FFAC9208F60
        public void ParseHowMany(){} // RVA: 0x7FFAC9209510
        public void ParseElementMixedContent(){} // RVA: 0x7FFAC92095F0
        public void ParseEntityDecl(){} // RVA: 0x7FFAC9209930
        public void ParseNotationDecl(){} // RVA: 0x7FFAC9209F00
        public void AddUndeclaredNotation(){} // RVA: 0x7FFAC920A2D0
        public void ParseComment(){} // RVA: 0x7FFAC920A6B0
        public void ParsePI(){} // RVA: 0x7FFAC920A880
        public void ParseCondSection(){} // RVA: 0x7FFAC920A990
        public void ParseExternalId(){} // RVA: 0x7FFAC920AC40
        public void GetToken(){} // RVA: 0x7FFAC920B410
        public void ScanSubsetContent(){} // RVA: 0x7FFAC920C6B0
        public void ScanNameExpected(){} // RVA: 0x7FFAC920CED0
        public void ScanQNameExpected(){} // RVA: 0x7FFAC920CF00
        public void ScanNmtokenExpected(){} // RVA: 0x7FFAC920CF30
        public void ScanDoctype1(){} // RVA: 0x7FFAC920CF60
        public void ScanDoctype2(){} // RVA: 0x7FFAC920D0A0
        public void ScanClosingTag(){} // RVA: 0x7FFAC920D150
        public void ScanElement1(){} // RVA: 0x7FFAC920D1E0
        public void ScanElement2(){} // RVA: 0x7FFAC920D4B0
        public void ScanElement3(){} // RVA: 0x7FFAC920D6E0
        public void ScanElement4(){} // RVA: 0x7FFAC920D760
        public void ScanElement5(){} // RVA: 0x7FFAC920D820
        public void ScanElement6(){} // RVA: 0x7FFAC920D910
        public void ScanElement7(){} // RVA: 0x7FFAC920D9E0
        public void ScanAttlist1(){} // RVA: 0x7FFAC920DA30
        public void ScanAttlist2(){} // RVA: 0x7FFAC920DB00
        public void ScanAttlist3(){} // RVA: 0x7FFAC920E290
        public void ScanAttlist4(){} // RVA: 0x7FFAC920E330
        public void ScanAttlist5(){} // RVA: 0x7FFAC920E400
        public void ScanAttlist6(){} // RVA: 0x7FFAC920E4D0
        public void ScanAttlist7(){} // RVA: 0x7FFAC920E970
        public void ScanLiteral(){} // RVA: 0x7FFAC920EA30
        public void ScanEntityName(){} // RVA: 0x7FFAC920FA10
        public void ScanNotation1(){} // RVA: 0x7FFAC920FB20
        public void ScanSystemId(){} // RVA: 0x7FFAC920FC30
        public void ScanEntity1(){} // RVA: 0x7FFAC920FCE0
        public void ScanEntity2(){} // RVA: 0x7FFAC920FD50
        public void ScanEntity3(){} // RVA: 0x7FFAC920FEA0
        public void ScanPublicId1(){} // RVA: 0x7FFAC920FFA0
        public void ScanPublicId2(){} // RVA: 0x7FFAC9210060
        public void ScanCondSection1(){} // RVA: 0x7FFAC92100D0
        public void ScanCondSection2(){} // RVA: 0x7FFAC9210430
        public void ScanCondSection3(){} // RVA: 0x7FFAC92104C0
        public void ScanName(){} // RVA: 0x7FFAC9210B40
        public void ScanQName(){} // RVA: 0x7FFAC9210B60 | overloaded x2
        public void ReadDataInName(){} // RVA: 0x7FFAC9210E20
        public void ScanNmtoken(){} // RVA: 0x7FFAC9210E60
        public void EatPublicKeyword(){} // RVA: 0x7FFAC9211070
        public void EatSystemKeyword(){} // RVA: 0x7FFAC9211130
        public void GetNameQualified(){} // RVA: 0x7FFAC92111F0
        public void GetNameString(){} // RVA: 0x7FFAC92113B0
        public void GetNmtokenString(){} // RVA: 0x7FFAC92113B0
        public void GetValue(){} // RVA: 0x7FFAC92113D0
        public void GetValueWithStrippedSpaces(){} // RVA: 0x7FFAC9211430
        public void ReadData(){} // RVA: 0x7FFAC92114A0
        public void LoadParsingBuffer(){} // RVA: 0x7FFAC9211520
        public void SaveParsingBuffer(){} // RVA: 0x7FFAC9211610 | overloaded x2
        public void HandleEntityReference(){} // RVA: 0x7FFAC9211770 | overloaded x2
        public void HandleEntityEnd(){} // RVA: 0x7FFAC9211A00
        public void VerifyEntityReference(){} // RVA: 0x7FFAC9211B70
        public void SendValidationEvent(){} // RVA: 0x7FFAC92120B0 | overloaded x3
        public void IsAttributeValueType(){} // RVA: 0x7FFAC9212150
        public void get_LineNo(){} // RVA: 0x7FFAC9212160
        public void get_LinePos(){} // RVA: 0x7FFAC92121B0
        public void get_BaseUriStr(){} // RVA: 0x7FFAC9212210
        public void OnUnexpectedError(){} // RVA: 0x7FFAC92122C0
        public void Throw(){} // RVA: 0x7FFAC9212700 | overloaded x4
        public void ThrowInvalidChar(){} // RVA: 0x7FFAC92128F0 | overloaded x2
        public void ThrowUnexpectedToken(){} // RVA: 0x7FFAC92129C0 | overloaded x2
        public void ParseUnexpectedToken(){} // RVA: 0x7FFAC9212B10
        public void StripSpaces(){} // RVA: 0x7FFAC9212BE0
    }

}