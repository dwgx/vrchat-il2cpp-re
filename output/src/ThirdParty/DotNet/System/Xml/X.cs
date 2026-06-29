// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 74
// Methods: 2011

namespace ThirdParty.DotNet.System.Xml
{
    public class XmlAsyncCheckReader : XmlReader
    {
        // ── Methods ──
        public void get_CoreReader(){} // RVA: 0x7A80F2570
        public void CreateAsyncCheckWrapper(){} // RVA: 0x7AE805E60
        public void .ctor(){} // RVA: 0x7AE806200
        public void CheckAsync(){} // RVA: 0x7AE806340
        public void get_Settings(){} // RVA: 0x7AE806410
        public void get_NodeType(){} // RVA: 0x7AE8064E0
        public void get_Name(){} // RVA: 0x7AE806520
        public void get_LocalName(){} // RVA: 0x7AE806560
        public void get_NamespaceURI(){} // RVA: 0x7AE8065A0
        public void get_Prefix(){} // RVA: 0x7AE8065E0
        public void get_Value(){} // RVA: 0x7AE806620
        public void get_Depth(){} // RVA: 0x7AE806660
        public void get_BaseURI(){} // RVA: 0x7AE8066A0
        public void get_IsEmptyElement(){} // RVA: 0x7AE8066E0
        public void get_IsDefault(){} // RVA: 0x7AE806720
        public void get_QuoteChar(){} // RVA: 0x7AE806760
        public void get_XmlSpace(){} // RVA: 0x7AE8067A0
        public void get_XmlLang(){} // RVA: 0x7AE8067E0
        public void get_SchemaInfo(){} // RVA: 0x7AE806820
        public void get_ValueType(){} // RVA: 0x7AE806860
        public void get_AttributeCount(){} // RVA: 0x7AE8068A0
        public void GetAttribute(){} // RVA: 0x7AE806990
        public void MoveToAttribute(){} // RVA: 0x7AE806A30
        public void MoveToFirstAttribute(){} // RVA: 0x7AE806A80
        public void MoveToNextAttribute(){} // RVA: 0x7AE806AC0
        public void MoveToElement(){} // RVA: 0x7AE806B00
        public void ReadAttributeValue(){} // RVA: 0x7AE806B40
        public void Read(){} // RVA: 0x7AE806B80
        public void get_EOF(){} // RVA: 0x7AE806BC0
        public void Close(){} // RVA: 0x7AE806C00
        public void get_ReadState(){} // RVA: 0x7AE806C40
        public void Skip(){} // RVA: 0x7AE806C80
        public void get_NameTable(){} // RVA: 0x7AE806CC0
        public void LookupNamespace(){} // RVA: 0x7AE806D00
        public void get_CanResolveEntity(){} // RVA: 0x7AE806D50
        public void ResolveEntity(){} // RVA: 0x7AE806D90
        public void get_CanReadValueChunk(){} // RVA: 0x7AE806DD0
        public void ReadValueChunk(){} // RVA: 0x7AE806E10
        public void ReadString(){} // RVA: 0x7AE806E80
        public void MoveToContent(){} // RVA: 0x7AE806EC0
        public void ReadStartElement(){} // RVA: 0x7AE806F00
        public void ReadElementString(){} // RVA: 0x7AE806F40
        public void ReadEndElement(){} // RVA: 0x7AE806F80
        public void IsStartElement(){} // RVA: 0x7AE806FC0
        public void ReadInnerXml(){} // RVA: 0x7AE807020
        public void get_HasAttributes(){} // RVA: 0x7AE807060
        public void Dispose(){} // RVA: 0x7AE8070A0
        public void get_NamespaceManager(){} // RVA: 0x7AE8070E0
        public void get_DtdInfo(){} // RVA: 0x7AE807120
    }

    public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE807380
        public void HasLineInfo(){} // RVA: 0x7AE807480
        public void get_LineNumber(){} // RVA: 0x7AE8074D0
        public void get_LinePosition(){} // RVA: 0x7AE807520
    }

    public class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE807570
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE807670
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE8076D0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE807730
    }

    public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE807790
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x7AE807890
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x7AE8078E0
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x7AE807930
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x7AE807980
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x7AE8079D0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x7AE807A20
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x7AE807A70
    }

    public class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE807160
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE807260
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE8072C0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE807320
    }

    public class XmlAsyncCheckWriter : XmlWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE807AC0
        public void CheckAsync(){} // RVA: 0x7AE807BE0
        public void WriteStartDocument(){} // RVA: 0x7AE807CF0
        public void WriteEndDocument(){} // RVA: 0x7AE807D40
        public void WriteDocType(){} // RVA: 0x7AE807D80
        public void WriteStartElement(){} // RVA: 0x7AE807DF0
        public void WriteEndElement(){} // RVA: 0x7AE807E60
        public void WriteFullEndElement(){} // RVA: 0x7AE807EA0
        public void WriteStartAttribute(){} // RVA: 0x7AE807EE0
        public void WriteEndAttribute(){} // RVA: 0x7AE807F50
        public void WriteCData(){} // RVA: 0x7AE807F90
        public void WriteComment(){} // RVA: 0x7AE807FE0
        public void WriteProcessingInstruction(){} // RVA: 0x7AE808030
        public void WriteEntityRef(){} // RVA: 0x7AE808090
        public void WriteCharEntity(){} // RVA: 0x7AE8080E0
        public void WriteWhitespace(){} // RVA: 0x7AE808130
        public void WriteString(){} // RVA: 0x7AE808180
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE8081D0
        public void WriteChars(){} // RVA: 0x7AE808230
        public void WriteRaw(){} // RVA: 0x7AE808310
        public void WriteBase64(){} // RVA: 0x7AE808360
        public void WriteBinHex(){} // RVA: 0x7AE8083D0
        public void get_WriteState(){} // RVA: 0x7AE808440
        public void Close(){} // RVA: 0x7AE808480
        public void Flush(){} // RVA: 0x7AE8084C0
        public void LookupPrefix(){} // RVA: 0x7AE808500
        public void WriteValue(){} // RVA: 0x7AE808550
        public void WriteAttributes(){} // RVA: 0x7AE8085A0
        public void WriteNode(){} // RVA: 0x7AE808600
        public void Dispose(){} // RVA: 0x7AE808660
    }

    public class XmlAttribute : XmlNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83C930
        public void get_LocalNameHash(){} // RVA: 0x7AE83C910
        public void get_XmlName(){} // RVA: 0x7A80DA7B0
        public void set_XmlName(){} // RVA: 0x7A813E420
        public void CloneNode(){} // RVA: 0x7AE83C980
        public void get_ParentNode(){} // RVA: 0x7A82D1450
        public void get_Name(){} // RVA: 0x7AE83CA70
        public void get_LocalName(){} // RVA: 0x7ADE59500
        public void get_NamespaceURI(){} // RVA: 0x7A9A9B340
        public void get_Prefix(){} // RVA: 0x7A8D68680
        public void set_Prefix(){} // RVA: 0x7AE83CA90
        public void get_NodeType(){} // RVA: 0x7A81DDCC0
        public void get_OwnerDocument(){} // RVA: 0x7ADE59620
        public void get_Value(){} // RVA: 0x7AE83CBA0
        public void set_Value(){} // RVA: 0x7AE83CBC0
        public void get_SchemaInfo(){} // RVA: 0x7A80DA7B0
        public void set_InnerText(){} // RVA: 0x7AE83CBE0
        public void PrepareOwnerElementInElementIdAttrMap(){} // RVA: 0x7AE83CC50
        public void ResetOwnerElementInElementIdAttrMap(){} // RVA: 0x7AE83CE40
        public void get_IsContainer(){} // RVA: 0x7A81BD750
        public void AppendChildForLoad(){} // RVA: 0x7AE83CF80
        public void get_LastNode(){} // RVA: 0x7A81052C0
        public void set_LastNode(){} // RVA: 0x7A81052D0
        public void IsValidChildType(){} // RVA: 0x7AE83D340
        public void get_Specified(){} // RVA: 0x7A81BD750
        public void InsertBefore(){} // RVA: 0x7AE83D350
        public void InsertAfter(){} // RVA: 0x7AE83D3F0
        public void RemoveChild(){} // RVA: 0x7AE83D490
        public void PrependChild(){} // RVA: 0x7AE83D510
        public void AppendChild(){} // RVA: 0x7AE83D5E0
        public void get_OwnerElement(){} // RVA: 0x7AE83D660
        public void set_InnerXml(){} // RVA: 0x7AE83D6E0
        public void WriteTo(){} // RVA: 0x7AE83D770
        public void WriteContentTo(){} // RVA: 0x7AE83D850
        public void get_BaseURI(){} // RVA: 0x7AE83D8D0
        public void SetParent(){} // RVA: 0x7A80D8E20
        public void get_XmlSpace(){} // RVA: 0x7AE83D970
        public void get_XmlLang(){} // RVA: 0x7AE83D9E0
    }

    public class XmlAttributeCollection : XmlNamedNodeMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ItemOf(){} // RVA: 0x7AE83DD30
        public void FindNodeOffsetNS(){} // RVA: 0x7AE83DF30
        public void SetNamedItem(){} // RVA: 0x7AE83E120
        public void Append(){} // RVA: 0x7AE83E2C0
        public void Remove(){} // RVA: 0x7AE83E510
        public void RemoveAt(){} // RVA: 0x7AE83E5B0
        public void RemoveAll(){} // RVA: 0x7AE83E670
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AE83E750
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7AE83E7E0
        public void AddNode(){} // RVA: 0x7AE83E7F0
        public void InsertNodeAt(){} // RVA: 0x7AE83E9F0
        public void RemoveNodeAt(){} // RVA: 0x7AE83EAA0
        public void Detach(){} // RVA: 0x7AE83EC80
        public void InsertParentIntoElementIdAttrMap(){} // RVA: 0x7AE83ED60
        public void RemoveParentFromElementIdAttrMap(){} // RVA: 0x7AE83EF50
        public void RemoveDuplicateAttribute(){} // RVA: 0x7AE83F140
        public void PrepareParentInElementIdAttrMap(){} // RVA: 0x7AE83F250
        public void ResetParentInElementIdAttrMap(){} // RVA: 0x7AE83F3B0
        public void InternalAppendAttribute(){} // RVA: 0x7AE83F490
    }

    public class XmlAutoDetectWriter : XmlRawWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8089E0
        public void WriteDocType(){} // RVA: 0x7AE808A60
        public void WriteStartElement(){} // RVA: 0x7AE808AE0
        public void WriteStartAttribute(){} // RVA: 0x7AE808BC0
        public void WriteEndAttribute(){} // RVA: 0x7AE47D310
        public void WriteCData(){} // RVA: 0x7AE808C40
        public void WriteComment(){} // RVA: 0x7AE808CA0
        public void WriteProcessingInstruction(){} // RVA: 0x7AE808CE0
        public void WriteWhitespace(){} // RVA: 0x7AE808D20
        public void WriteString(){} // RVA: 0x7AE808D60
        public void WriteChars(){} // RVA: 0x7A9240680
        public void WriteRaw(){} // RVA: 0x7AE808E10
        public void WriteEntityRef(){} // RVA: 0x7AE808E70
        public void WriteCharEntity(){} // RVA: 0x7AE808ED0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE808F30
        public void WriteBase64(){} // RVA: 0x7AE808FA0
        public void WriteBinHex(){} // RVA: 0x7AE809020
        public void Close(){} // RVA: 0x7AE8090A0
        public void Flush(){} // RVA: 0x7AE8090F0
        public void WriteValue(){} // RVA: 0x7AE809140
        public void set_NamespaceResolver(){} // RVA: 0x7AE8091A0
        public void WriteXmlDeclaration(){} // RVA: 0x7AE809280
        public void StartElementContent(){} // RVA: 0x7AE804330
        public void WriteEndElement(){} // RVA: 0x7AE8092E0
        public void WriteFullEndElement(){} // RVA: 0x7AE809310
        public void WriteNamespaceDeclaration(){} // RVA: 0x7AE809340
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7AE804400
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7AE8093B0
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7AE804460
        public void IsHtmlTag(){} // RVA: 0x7AE809410
        public void EnsureWrappedWriter(){} // RVA: 0x7AE809470
        public void TextBlockCreatesWriter(){} // RVA: 0x7AE809480
        public void CreateWrappedWriter(){} // RVA: 0x7AE809530
    }

    public class XmlCDataSection : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83F550
        public void get_Name(){} // RVA: 0x7AE83F560
        public void get_LocalName(){} // RVA: 0x7AE83F560
        public void get_NodeType(){} // RVA: 0x7A883BE70
        public void get_ParentNode(){} // RVA: 0x7AE83F590
        public void CloneNode(){} // RVA: 0x7AE83F630
        public void WriteTo(){} // RVA: 0x7AE83F6A0
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void get_IsText(){} // RVA: 0x7A81BD750
    }

    public class XmlCachedStream : MemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE87A580
    }

    public class XmlCharType : ValueType
    {
        // ── Methods ──
        public void get_StaticLock(){} // RVA: 0x7AE86DA10
        public void InitInstance(){} // RVA: 0x7AE86DAE0
        public void SetProperties(){} // RVA: 0x7AE86E320
        public void .ctor(){} // RVA: 0x7A7637E60
        public void get_Instance(){} // RVA: 0x7AE86E3F0
        public void IsWhiteSpace(){} // RVA: 0x7A7E96D00
        public void IsNCNameSingleChar(){} // RVA: 0x7A7E96D40
        public void IsStartNCNameSingleChar(){} // RVA: 0x7A7E96D80
        public void IsNameSingleChar(){} // RVA: 0x7A7E96DC0
        public void IsCharData(){} // RVA: 0x7A7E96E00
        public void IsPubidChar(){} // RVA: 0x7A7E96E40
        public void IsTextChar(){} // RVA: 0x7A7E96E50
        public void IsLetter(){} // RVA: 0x7A7E96E90
        public void IsNCNameCharXml4e(){} // RVA: 0x7A7E96ED0
        public void IsStartNCNameCharXml4e(){} // RVA: 0x7A7E96F10
        public void IsNameCharXml4e(){} // RVA: 0x7A7E96F50
        public void IsDigit(){} // RVA: 0x7ADC72E50
        public void IsHighSurrogate(){} // RVA: 0x7AE86E7C0
        public void IsLowSurrogate(){} // RVA: 0x7AE86E7D0
        public void IsSurrogate(){} // RVA: 0x7AE0D8040
        public void CombineSurrogateChar(){} // RVA: 0x7AE86E7E0
        public void SplitSurrogateChar(){} // RVA: 0x7AE86E800
        public void IsOnlyWhitespace(){} // RVA: 0x7A7E96F90
        public void IsOnlyWhitespaceWithPos(){} // RVA: 0x7A7E97010
        public void IsOnlyCharData(){} // RVA: 0x7A7E97090
        public void IsOnlyDigits(){} // RVA: 0x7AE86EA30
        public void IsPublicId(){} // RVA: 0x7A7E970A0
        public void InRange(){} // RVA: 0x7ADA3F790
    }

    public class XmlCharacterData : XmlLinkedNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83F6F0
        public void get_Value(){} // RVA: 0x7ADCAB740
        public void set_Value(){} // RVA: 0x7AE83F770
        public void get_InnerText(){} // RVA: 0x7A9AA40B0
        public void set_InnerText(){} // RVA: 0x7ABE84300
        public void get_Data(){} // RVA: 0x7AE83F790
        public void set_Data(){} // RVA: 0x7AE83F7F0
        public void CheckOnData(){} // RVA: 0x7AE83F900
    }

    public class XmlChildEnumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83F980
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7AE83FA70
        public void MoveNext(){} // RVA: 0x7AE83FA70
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AE83FBA0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AE83FC20
        public void get_Current(){} // RVA: 0x7AE83FC20
    }

    public class XmlChildNodes : XmlNodeList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Item(){} // RVA: 0x7AE83FCB0
        public void get_Count(){} // RVA: 0x7AE83FD20
        public void GetEnumerator(){} // RVA: 0x7AE83FD80
    }

    public class XmlComment : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83F550
        public void get_Name(){} // RVA: 0x7AE83FE50
        public void get_LocalName(){} // RVA: 0x7AE83FE50
        public void get_NodeType(){} // RVA: 0x7A88217C0
        public void CloneNode(){} // RVA: 0x7AE83FE80
        public void WriteTo(){} // RVA: 0x7AE83FEF0
        public void WriteContentTo(){} // RVA: 0x7A80D7310
    }

    public class XmlComplianceUtil : Object
    {
        // ── Methods ──
        public void NonCDataNormalize(){} // RVA: 0x7AE86EB10
        public void CDataNormalize(){} // RVA: 0x7AE86EDD0
    }

    public class XmlConvert : Object
    {
        // ── Methods ──
        public void EncodeName(){} // RVA: 0x7AE86F980
        public void EncodeLocalName(){} // RVA: 0x7AE86F050
        public void DecodeName(){} // RVA: 0x7AE86F0B0
        public void FromHex(){} // RVA: 0x7AE8704E0
        public void FromBinHexString(){} // RVA: 0x7AE8705C0
        public void ToBinHexString(){} // RVA: 0x7AE870640
        public void VerifyName(){} // RVA: 0x7AE8707C0
        public void TryVerifyName(){} // RVA: 0x7AE870930
        public void VerifyQName(){} // RVA: 0x7AE870B00
        public void VerifyNCName(){} // RVA: 0x7AE870DF0
        public void TryVerifyNCName(){} // RVA: 0x7AE870F60
        public void VerifyTOKEN(){} // RVA: 0x7AE871040
        public void TryVerifyTOKEN(){} // RVA: 0x7AE871340
        public void TryVerifyNMTOKEN(){} // RVA: 0x7AE871650
        public void TryVerifyNormalizedString(){} // RVA: 0x7AE871890
        public void ToString(){} // RVA: 0x7AE872600
        public void ToBoolean(){} // RVA: 0x7AE872650
        public void TryToBoolean(){} // RVA: 0x7AE8728C0
        public void ToChar(){} // RVA: 0x7AE872BC0
        public void TryToChar(){} // RVA: 0x7AE872C90
        public void ToDecimal(){} // RVA: 0x7AE872E30
        public void TryToDecimal(){} // RVA: 0x7AE872EC0
        public void ToInteger(){} // RVA: 0x7AE873080
        public void TryToInteger(){} // RVA: 0x7AE873110
        public void ToSByte(){} // RVA: 0x7AE8732D0
        public void TryToSByte(){} // RVA: 0x7AE873370
        public void ToInt16(){} // RVA: 0x7AE8735D0
        public void TryToInt16(){} // RVA: 0x7AE873670
        public void ToInt32(){} // RVA: 0x7AE8738C0
        public void TryToInt32(){} // RVA: 0x7AE8738F0
        public void ToInt64(){} // RVA: 0x7AE873A70
        public void TryToInt64(){} // RVA: 0x7AE873AA0
        public void ToByte(){} // RVA: 0x7AE873C20
        public void TryToByte(){} // RVA: 0x7AE873CC0
        public void ToUInt16(){} // RVA: 0x7AE873EB0
        public void TryToUInt16(){} // RVA: 0x7AE873F50
        public void ToUInt32(){} // RVA: 0x7AE874140
        public void TryToUInt32(){} // RVA: 0x7AE874170
        public void ToUInt64(){} // RVA: 0x7AE8742F0
        public void TryToUInt64(){} // RVA: 0x7AE874320
        public void ToSingle(){} // RVA: 0x7AE8744A0
        public void TryToSingle(){} // RVA: 0x7AE874600
        public void ToDouble(){} // RVA: 0x7AE8748D0
        public void TryToDouble(){} // RVA: 0x7AE874A30
        public void ToXPathDouble(){} // RVA: 0x7AE874D10
        public void ToTimeSpan(){} // RVA: 0x7AE874F80
        public void TryToTimeSpan(){} // RVA: 0x7AE875190
        public void get_AllDateTimeFormats(){} // RVA: 0x7AE875250
        public void CreateAllDateTimeFormats(){} // RVA: 0x7AE875300
        public void ToDateTime(){} // RVA: 0x7AE8759D0
        public void ToDateTimeOffset(){} // RVA: 0x7AE875C70
        public void ToGuid(){} // RVA: 0x7AE875D60
        public void TryToGuid(){} // RVA: 0x7AE875D80
        public void SwitchToLocalTime(){} // RVA: 0x7AE8760B0
        public void SwitchToUtcTime(){} // RVA: 0x7AE876240
        public void ToUri(){} // RVA: 0x7AE876390
        public void TryToUri(){} // RVA: 0x7AE8767E0
        public void StrEqual(){} // RVA: 0x7AE876C80
        public void TrimString(){} // RVA: 0x7AE876D30
        public void TrimStringStart(){} // RVA: 0x7AE876DF0
        public void TrimStringEnd(){} // RVA: 0x7AE876EA0
        public void SplitString(){} // RVA: 0x7AE876F60
        public void IsNegativeZero(){} // RVA: 0x7AE877060
        public void DoubleToInt64Bits(){} // RVA: 0x7ADB63230
        public void VerifyCharData(){} // RVA: 0x7AE8770E0
        public void CreateException(){} // RVA: 0x7AE877680
        public void CreateInvalidSurrogatePairException(){} // RVA: 0x7AE877890
        public void CreateInvalidHighSurrogateCharException(){} // RVA: 0x7AE877CC0
        public void CreateInvalidCharException(){} // RVA: 0x7AE878100
        public void CreateInvalidNameCharException(){} // RVA: 0x7AE8781E0
        public void CreateInvalidNameArgumentException(){} // RVA: 0x7AE878300
        public void .cctor(){} // RVA: 0x7AE878400
    }

    public class XmlDeclaration : XmlLinkedNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83FF40
        public void get_Version(){} // RVA: 0x7A81052C0
        public void set_Version(){} // RVA: 0x7A81052D0
        public void get_Encoding(){} // RVA: 0x7A8105330
        public void set_Encoding(){} // RVA: 0x7AE8402A0
        public void get_Standalone(){} // RVA: 0x7A83F69F0
        public void set_Standalone(){} // RVA: 0x7AE840350
        public void get_Value(){} // RVA: 0x7AE83CBA0
        public void set_Value(){} // RVA: 0x7AE83CBC0
        public void get_InnerText(){} // RVA: 0x7AE8405A0
        public void set_InnerText(){} // RVA: 0x7AE840740
        public void get_Name(){} // RVA: 0x7AE8409C0
        public void get_LocalName(){} // RVA: 0x7AE50A3E0
        public void get_NodeType(){} // RVA: 0x7ADE594F0
        public void CloneNode(){} // RVA: 0x7AE840A00
        public void WriteTo(){} // RVA: 0x7AE840A60
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void IsValidXmlVersion(){} // RVA: 0x7AE840AE0
    }

    public class XmlDocument : XmlNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE840CE0
        public void get_DtdSchemaInfo(){} // RVA: 0x7A8152D80
        public void set_DtdSchemaInfo(){} // RVA: 0x7A8152D90
        public void CheckName(){} // RVA: 0x7AE841870
        public void AddXmlName(){} // RVA: 0x7AE841940
        public void GetXmlName(){} // RVA: 0x7AE841970
        public void AddAttrXmlName(){} // RVA: 0x7AE8419A0
        public void AddIdInfo(){} // RVA: 0x7AE841AE0
        public void GetIDInfoByElement_(){} // RVA: 0x7AE841C10
        public void GetIDInfoByElement(){} // RVA: 0x7AE841D30
        public void GetElement(){} // RVA: 0x7AE841E50
        public void AddElementWithId(){} // RVA: 0x7AE8422E0
        public void RemoveElementWithId(){} // RVA: 0x7AE842550
        public void CloneNode(){} // RVA: 0x7AE8426B0
        public void get_NodeType(){} // RVA: 0x7A94EBBC0
        public void get_ParentNode(){} // RVA: 0x7A82D1450
        public void get_DocumentType(){} // RVA: 0x7AE8427F0
        public void get_Declaration(){} // RVA: 0x7AE842880
        public void get_Implementation(){} // RVA: 0x7A80DA7B0
        public void get_Name(){} // RVA: 0x7A87D9C10
        public void get_LocalName(){} // RVA: 0x7A87D9C10
        public void get_DocumentElement(){} // RVA: 0x7AE842930
        public void get_IsContainer(){} // RVA: 0x7A81BD750
        public void get_LastNode(){} // RVA: 0x7A8105330
        public void set_LastNode(){} // RVA: 0x7A80D8E80
        public void get_OwnerDocument(){} // RVA: 0x7A82D1450
        public void set_Schemas(){} // RVA: 0x7A8230620
        public void get_CanReportValidity(){} // RVA: 0x7A8359360
        public void get_HasSetResolver(){} // RVA: 0x7A858F1D0
        public void GetResolver(){} // RVA: 0x7A8357A90
        public void set_XmlResolver(){} // RVA: 0x7AE8429C0
        public void IsValidChildType(){} // RVA: 0x7AE842D20
        public void HasNodeTypeInPrevSiblings(){} // RVA: 0x7AE842EF0
        public void HasNodeTypeInNextSiblings(){} // RVA: 0x7AE842FE0
        public void CanInsertBefore(){} // RVA: 0x7AE843060
        public void CanInsertAfter(){} // RVA: 0x7AE843220
        public void CreateAttribute(){} // RVA: 0x7AE844D40
        public void SetDefaultNamespace(){} // RVA: 0x7AE843450
        public void CreateCDataSection(){} // RVA: 0x7AE843620
        public void CreateComment(){} // RVA: 0x7AE843690
        public void CreateDocumentType(){} // RVA: 0x7AE843700
        public void CreateDocumentFragment(){} // RVA: 0x7AE8437A0
        public void CreateElement(){} // RVA: 0x7AE844E90
        public void AddDefaultAttributes(){} // RVA: 0x7AE843950
        public void GetSchemaElementDecl(){} // RVA: 0x7AE843D00
        public void PrepareDefaultAttribute(){} // RVA: 0x7AE843E30
        public void CreateEntityReference(){} // RVA: 0x7AE843F70
        public void CreateProcessingInstruction(){} // RVA: 0x7AE843FE0
        public void CreateXmlDeclaration(){} // RVA: 0x7AE844060
        public void CreateTextNode(){} // RVA: 0x7AE844100
        public void CreateSignificantWhitespace(){} // RVA: 0x7AE844170
        public void CreateWhitespace(){} // RVA: 0x7AE8441E0
        public void ImportNodeInternal(){} // RVA: 0x7AE8443D0
        public void ImportAttributes(){} // RVA: 0x7AE844B10
        public void ImportChildren(){} // RVA: 0x7AE844C80
        public void get_NameTable(){} // RVA: 0x7A8D68680
        public void CreateDefaultAttribute(){} // RVA: 0x7AE844DE0
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void get_Entities(){} // RVA: 0x7AE844F60
        public void set_Entities(){} // RVA: 0x7A8105A90
        public void get_IsLoading(){} // RVA: 0x7AE4B4A60
        public void set_IsLoading(){} // RVA: 0x7AE845060
        public void get_ActualLoadingStatus(){} // RVA: 0x7ACDBE8E0
        public void ReadNode(){} // RVA: 0x7AE845070
        public void SetupReader(){} // RVA: 0x7AE845130
        public void Load(){} // RVA: 0x7AE8451A0
        public void LoadXml(){} // RVA: 0x7AE8452C0
        public void set_InnerText(){} // RVA: 0x7AE8455A0
        public void set_InnerXml(){} // RVA: 0x7ADD9F5D0
        public void Save(){} // RVA: 0x7AE845600
        public void WriteTo(){} // RVA: 0x7AE8458C0
        public void WriteContentTo(){} // RVA: 0x7AE8458E0
        public void GetEventArgs(){} // RVA: 0x7AE845B30
        public void GetInsertEventArgsForLoad(){} // RVA: 0x7AE845C30
        public void BeforeEvent(){} // RVA: 0x7AE845D00
        public void AfterEvent(){} // RVA: 0x7AE845D80
        public void GetDefaultAttribute(){} // RVA: 0x7AE845E00
        public void get_Version(){} // RVA: 0x7AE846150
        public void get_Encoding(){} // RVA: 0x7AE846180
        public void get_Standalone(){} // RVA: 0x7AE8461B0
        public void GetEntityNode(){} // RVA: 0x7AE8461E0
        public void get_SchemaInfo(){} // RVA: 0x7AE8462D0
        public void get_BaseURI(){} // RVA: 0x7A864CFF0
        public void SetBaseURI(){} // RVA: 0x7A864C880
        public void AppendChildForLoad(){} // RVA: 0x7AE846400
        public void .cctor(){} // RVA: 0x7AE8466B0
    }

    public class XmlDocumentFragment : XmlNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE846940
        public void get_Name(){} // RVA: 0x7AE846A10
        public void get_LocalName(){} // RVA: 0x7AE846A10
        public void get_NodeType(){} // RVA: 0x7ADC89490
        public void get_ParentNode(){} // RVA: 0x7A82D1450
        public void get_OwnerDocument(){} // RVA: 0x7AE846A40
        public void set_InnerXml(){} // RVA: 0x7AE846AC0
        public void CloneNode(){} // RVA: 0x7AE846B50
        public void get_IsContainer(){} // RVA: 0x7A81BD750
        public void get_LastNode(){} // RVA: 0x7A80DA7B0
        public void set_LastNode(){} // RVA: 0x7A813E420
        public void IsValidChildType(){} // RVA: 0x7AE846BF0
        public void CanInsertAfter(){} // RVA: 0x7AE846CB0
        public void CanInsertBefore(){} // RVA: 0x7AE846D30
        public void WriteTo(){} // RVA: 0x7AE8458C0
        public void WriteContentTo(){} // RVA: 0x7AE846DB0
    }

    public class XmlDocumentType : XmlLinkedNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE847000
        public void get_Name(){} // RVA: 0x7A81052C0
        public void get_LocalName(){} // RVA: 0x7A81052C0
        public void get_NodeType(){} // RVA: 0x7A836B0A0
        public void CloneNode(){} // RVA: 0x7AE847260
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void get_Entities(){} // RVA: 0x7AE8472C0
        public void get_Notations(){} // RVA: 0x7AE8473C0
        public void get_PublicId(){} // RVA: 0x7A8105330
        public void get_SystemId(){} // RVA: 0x7A83F69F0
        public void get_InternalSubset(){} // RVA: 0x7A8292C30
        public void get_ParseWithNamespaces(){} // RVA: 0x7A8193790
        public void WriteTo(){} // RVA: 0x7AE8474C0
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void get_DtdSchemaInfo(){} // RVA: 0x7A81A0050
        public void set_DtdSchemaInfo(){} // RVA: 0x7A81A0060
    }

    public class XmlDownloadManager : Object
    {
        // ── Methods ──
        public void GetStream(){} // RVA: 0x7AE878620
        public void GetNonFileStream(){} // RVA: 0x7AE878760
        public void Remove(){} // RVA: 0x7AE878D90
        public void GetStreamAsync(){} // RVA: 0x7AE878F50
        public void GetNonFileStreamAsync(){} // RVA: 0x7AE879130
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlElement : XmlLinkedNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE847740
        public void get_XmlName(){} // RVA: 0x7A81052C0
        public void set_XmlName(){} // RVA: 0x7A81052D0
        public void CloneNode(){} // RVA: 0x7AE8477B0
        public void get_Name(){} // RVA: 0x7AE847C90
        public void get_LocalName(){} // RVA: 0x7A80DF920
        public void get_NamespaceURI(){} // RVA: 0x7AE847CB0
        public void get_Prefix(){} // RVA: 0x7A8D68180
        public void set_Prefix(){} // RVA: 0x7AE847CD0
        public void get_NodeType(){} // RVA: 0x7A81CA9D0
        public void get_ParentNode(){} // RVA: 0x7A80F2570
        public void get_OwnerDocument(){} // RVA: 0x7AE847DF0
        public void get_IsContainer(){} // RVA: 0x7A81BD750
        public void AppendChildForLoad(){} // RVA: 0x7AE847E10
        public void get_IsEmpty(){} // RVA: 0x7AE8481D0
        public void set_IsEmpty(){} // RVA: 0x7AE8481E0
        public void get_LastNode(){} // RVA: 0x7AE8482C0
        public void set_LastNode(){} // RVA: 0x7A8105A90
        public void IsValidChildType(){} // RVA: 0x7AE8482D0
        public void get_Attributes(){} // RVA: 0x7AE848330
        public void get_HasAttributes(){} // RVA: 0x7AE848560
        public void GetAttribute(){} // RVA: 0x7AE8488D0
        public void SetAttribute(){} // RVA: 0x7AE848980
        public void GetAttributeNode(){} // RVA: 0x7AE848AC0
        public void SetAttributeNode(){} // RVA: 0x7AE848B50
        public void HasAttribute(){} // RVA: 0x7AE848C50
        public void WriteTo(){} // RVA: 0x7AE848C80
        public void WriteElementTo(){} // RVA: 0x7AE848DE0
        public void WriteStartElement(){} // RVA: 0x7AE849060
        public void WriteContentTo(){} // RVA: 0x7AE83D850
        public void RemoveAllAttributes(){} // RVA: 0x7AE8491A0
        public void RemoveAll(){} // RVA: 0x7AE8492B0
        public void RemoveAllChildren(){} // RVA: 0x7AE8492E0
        public void get_SchemaInfo(){} // RVA: 0x7A81052C0
        public void set_InnerXml(){} // RVA: 0x7AE8492F0
        public void get_InnerText(){} // RVA: 0x7AE8494E0
        public void set_InnerText(){} // RVA: 0x7AE8494F0
        public void get_NextSibling(){} // RVA: 0x7AE8495E0
        public void SetParent(){} // RVA: 0x7A80D8E20
    }

    public class XmlEncodedRawTextWriter : XmlRawWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE809C10
        public void WriteXmlDeclaration(){} // RVA: 0x7AE80A3D0
        public void WriteDocType(){} // RVA: 0x7AE80A440
        public void WriteStartElement(){} // RVA: 0x7AE80A6E0
        public void StartElementContent(){} // RVA: 0x7AE80A7C0
        public void WriteEndElement(){} // RVA: 0x7AE80A800
        public void WriteFullEndElement(){} // RVA: 0x7AE80A980
        public void WriteStartAttribute(){} // RVA: 0x7AE80AAA0
        public void WriteEndAttribute(){} // RVA: 0x7AE80ABC0
        public void WriteNamespaceDeclaration(){} // RVA: 0x7AE80AC20
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7A81BD750
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7AE80AC80
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7AE80ADE0
        public void WriteCData(){} // RVA: 0x7AE80AE40
        public void WriteComment(){} // RVA: 0x7AE80B080
        public void WriteProcessingInstruction(){} // RVA: 0x7AE80B1E0
        public void WriteEntityRef(){} // RVA: 0x7AE80B330
        public void WriteCharEntity(){} // RVA: 0x7AE80B400
        public void WriteWhitespace(){} // RVA: 0x7AE80B680
        public void WriteString(){} // RVA: 0x7AE80B700
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE80B780
        public void WriteChars(){} // RVA: 0x7AE6EE450
        public void WriteRaw(){} // RVA: 0x7AE805550
        public void Close(){} // RVA: 0x7AE80BA10
        public void Flush(){} // RVA: 0x7AE80BCF0
        public void FlushBuffer(){} // RVA: 0x7AE80BD80
        public void EncodeChars(){} // RVA: 0x7AE80C2E0
        public void FlushEncoder(){} // RVA: 0x7AE80C460
        public void WriteAttributeTextBlock(){} // RVA: 0x7AE80C540
        public void WriteElementTextBlock(){} // RVA: 0x7AE80C850
        public void RawText(){} // RVA: 0x7AE80CBB0
        public void WriteRawWithCharChecking(){} // RVA: 0x7AE80CD50
        public void WriteCommentOrPi(){} // RVA: 0x7AE80CFE0
        public void WriteCDataSection(){} // RVA: 0x7AE80D370
        public void EncodeSurrogate(){} // RVA: 0x7AE80D6F0
        public void InvalidXmlChar(){} // RVA: 0x7AE80D870
        public void EncodeChar(){} // RVA: 0x7AE80DA20
        public void ChangeTextContentMark(){} // RVA: 0x7AE80DB00
        public void GrowTextContentMarks(){} // RVA: 0x7AE80DB80
        public void WriteNewLine(){} // RVA: 0x7AE80DD20
        public void LtEntity(){} // RVA: 0x7AE80DDA0
        public void GtEntity(){} // RVA: 0x7AE80DDC0
        public void AmpEntity(){} // RVA: 0x7AE80DDE0
        public void QuoteEntity(){} // RVA: 0x7AE80DE00
        public void TabEntity(){} // RVA: 0x7AE80DE20
        public void LineFeedEntity(){} // RVA: 0x7AE80DE40
        public void CarriageReturnEntity(){} // RVA: 0x7AE80DE60
        public void CharEntity(){} // RVA: 0x7AE80DE80
        public void RawStartCData(){} // RVA: 0x7AE80DFD0
        public void RawEndCData(){} // RVA: 0x7AE80E000
        public void ValidateContentChars(){} // RVA: 0x7AE80E020
    }

    public class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE80E450
        public void WriteDocType(){} // RVA: 0x7AE80E480
        public void WriteStartElement(){} // RVA: 0x7AE80E4F0
        public void StartElementContent(){} // RVA: 0x7AE80E630
        public void OnRootElement(){} // RVA: 0x7A9B14860
        public void WriteEndElement(){} // RVA: 0x7AE80E6A0
        public void WriteFullEndElement(){} // RVA: 0x7AE80E780
        public void WriteStartAttribute(){} // RVA: 0x7AE80E860
        public void WriteCData(){} // RVA: 0x7AE80E8C0
        public void WriteComment(){} // RVA: 0x7AE80E8D0
        public void WriteProcessingInstruction(){} // RVA: 0x7AE80E910
        public void WriteEntityRef(){} // RVA: 0x7AE80E960
        public void WriteCharEntity(){} // RVA: 0x7AE80EA30
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE80EA40
        public void WriteWhitespace(){} // RVA: 0x7AE80EA50
        public void WriteString(){} // RVA: 0x7AE80EAD0
        public void WriteChars(){} // RVA: 0x7AE80EB50
        public void WriteRaw(){} // RVA: 0x7AE80EC80
        public void WriteBase64(){} // RVA: 0x7AE80ECF0
        public void Init(){} // RVA: 0x7AE80ED10
        public void WriteIndent(){} // RVA: 0x7AE80EEF0
    }

    public class XmlEntity : XmlNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE849620
        public void CloneNode(){} // RVA: 0x7AE849930
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void get_Name(){} // RVA: 0x7A83F69F0
        public void get_LocalName(){} // RVA: 0x7A83F69F0
        public void get_InnerText(){} // RVA: 0x7AE8494E0
        public void set_InnerText(){} // RVA: 0x7AE849990
        public void get_IsContainer(){} // RVA: 0x7A81BD750
        public void get_LastNode(){} // RVA: 0x7AE8499F0
        public void set_LastNode(){} // RVA: 0x7A8152D90
        public void IsValidChildType(){} // RVA: 0x7AE849B00
        public void get_NodeType(){} // RVA: 0x7A8842E60
        public void get_SystemId(){} // RVA: 0x7A81052C0
        public void set_InnerXml(){} // RVA: 0x7AE849B20
        public void WriteTo(){} // RVA: 0x7A80D7310
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void get_BaseURI(){} // RVA: 0x7A8154D80
        public void SetBaseURI(){} // RVA: 0x7A80FF440
    }

    public class XmlEntityReference : XmlLinkedNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE849B80
        public void get_Name(){} // RVA: 0x7A81052C0
        public void get_LocalName(){} // RVA: 0x7A81052C0
        public void get_Value(){} // RVA: 0x7A82D1450
        public void set_Value(){} // RVA: 0x7AE849CC0
        public void get_NodeType(){} // RVA: 0x7A8401A30
        public void CloneNode(){} // RVA: 0x7AE849D20
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void get_IsContainer(){} // RVA: 0x7A81BD750
        public void SetParent(){} // RVA: 0x7AE849D70
        public void SetParentForLoad(){} // RVA: 0x7AE849EF0
        public void get_LastNode(){} // RVA: 0x7A8105330
        public void set_LastNode(){} // RVA: 0x7A80D8E80
        public void IsValidChildType(){} // RVA: 0x7AE8482D0
        public void WriteTo(){} // RVA: 0x7AE849F10
        public void WriteContentTo(){} // RVA: 0x7AE849F50
        public void get_BaseURI(){} // RVA: 0x7AE84A1A0
        public void ConstructBaseURI(){} // RVA: 0x7AE84A1E0
        public void get_ChildBaseURI(){} // RVA: 0x7AE84A2B0
    }

    public class XmlEventCache : XmlRawWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE80EF70
        public void EndEvents(){} // RVA: 0x7AE80EFD0
        public void EventsToWriter(){} // RVA: 0x7AE80F020
        public void WriteDocType(){} // RVA: 0x7AE80FB60
        public void WriteStartElement(){} // RVA: 0x7AE80FBF0
        public void WriteStartAttribute(){} // RVA: 0x7AE80FC80
        public void WriteEndAttribute(){} // RVA: 0x7AE80FD10
        public void WriteCData(){} // RVA: 0x7AE80FD50
        public void WriteComment(){} // RVA: 0x7AE80FD60
        public void WriteProcessingInstruction(){} // RVA: 0x7AE80FD70
        public void WriteWhitespace(){} // RVA: 0x7AE80FDA0
        public void WriteString(){} // RVA: 0x7AE80FDB0
        public void WriteChars(){} // RVA: 0x7A9240680
        public void WriteRaw(){} // RVA: 0x7AE80FDE0
        public void WriteEntityRef(){} // RVA: 0x7AE80FDF0
        public void WriteCharEntity(){} // RVA: 0x7AE80FE00
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE80FE70
        public void WriteBase64(){} // RVA: 0x7AE80FF10
        public void WriteBinHex(){} // RVA: 0x7AE80FF50
        public void Close(){} // RVA: 0x7AE80FF90
        public void Flush(){} // RVA: 0x7AE80FFD0
        public void WriteValue(){} // RVA: 0x7AE810010
        public void Dispose(){} // RVA: 0x7AE810030
        public void WriteXmlDeclaration(){} // RVA: 0x7AE8101A0
        public void StartElementContent(){} // RVA: 0x7AE8101B0
        public void WriteEndElement(){} // RVA: 0x7AE8101F0
        public void WriteFullEndElement(){} // RVA: 0x7AE810280
        public void WriteNamespaceDeclaration(){} // RVA: 0x7AE810310
        public void WriteEndBase64(){} // RVA: 0x7AE810340
        public void AddEvent(){} // RVA: 0x7AE810600
        public void NewEvent(){} // RVA: 0x7AE8106B0
        public void ToBytes(){} // RVA: 0x7AE810970
    }

    public class XmlException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE87E370
        public void GetObjectData(){} // RVA: 0x7AE87D1D0
        public void FormatUserMessage(){} // RVA: 0x7AE87E500
        public void CreateMessage(){} // RVA: 0x7AE87E610
        public void BuildCharExceptionArgs(){} // RVA: 0x7AE87E860
        public void get_LineNumber(){} // RVA: 0x7A9B79A40
        public void get_LinePosition(){} // RVA: 0x7ABA390E0
        public void get_Message(){} // RVA: 0x7AE87EB80
        public void get_ResString(){} // RVA: 0x7A8555100
    }

    public class XmlImplementation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void CreateDocument(){} // RVA: 0x7AE84A5A0
        public void get_NameTable(){} // RVA: 0x7A80F2570
    }

    public class XmlLinkedNode : XmlNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE84A600
        public void get_PreviousSibling(){} // RVA: 0x7AE84A730
        public void get_NextSibling(){} // RVA: 0x7AE84A7C0
    }

    public class XmlLoader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Load(){} // RVA: 0x7AE84A820
        public void LoadDocSequence(){} // RVA: 0x7AE84AC60
        public void ReadCurrentNode(){} // RVA: 0x7AE84ACE0
        public void LoadNode(){} // RVA: 0x7AE84AF20
        public void LoadAttributeNode(){} // RVA: 0x7AE84B6D0
        public void LoadDefaultAttribute(){} // RVA: 0x7AE84BA80
        public void LoadAttributeValue(){} // RVA: 0x7AE84BCB0
        public void LoadEntityReferenceNode(){} // RVA: 0x7AE84C000
        public void LoadDeclarationNode(){} // RVA: 0x7AE84C260
        public void LoadDocumentTypeNode(){} // RVA: 0x7AE84C4E0
        public void LoadNodeDirect(){} // RVA: 0x7AE84C780
        public void LoadAttributeNodeDirect(){} // RVA: 0x7AE84CD90
        public void ParseDocumentType(){} // RVA: 0x7AE84D000
        public void LoadDocumentType(){} // RVA: 0x7AE84D3A0
        public void GetContext(){} // RVA: 0x7AE84E510
        public void ParsePartialContent(){} // RVA: 0x7AE84EF90
        public void LoadInnerXmlElement(){} // RVA: 0x7AE84F2A0
        public void LoadInnerXmlAttribute(){} // RVA: 0x7AE84F440
        public void RemoveDuplicateNamespace(){} // RVA: 0x7AE84F460
        public void EntitizeName(){} // RVA: 0x7AE84F830
        public void ExpandEntity(){} // RVA: 0x7AE84F890
        public void ExpandEntityReference(){} // RVA: 0x7AE84F950
        public void CreateInnerXmlReader(){} // RVA: 0x7AE8500C0
        public void ParseXmlDeclarationValue(){} // RVA: 0x7AE850360
        public void UnexpectedNodeType(){} // RVA: 0x7AE8508A0
    }

    public class XmlName : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE850A10
        public void .ctor(){} // RVA: 0x7AE850B30
        public void get_LocalName(){} // RVA: 0x7A80DA7B0
        public void get_NamespaceURI(){} // RVA: 0x7A81052C0
        public void get_Prefix(){} // RVA: 0x7A80F2570
        public void get_HashCode(){} // RVA: 0x7A8133100
        public void get_OwnerDocument(){} // RVA: 0x7A8292C30
        public void get_Name(){} // RVA: 0x7AE850D50
        public void get_Validity(){} // RVA: 0x7A82D1450
        public void get_IsDefault(){} // RVA: 0x7A80D7320
        public void get_IsNil(){} // RVA: 0x7A80D7320
        public void get_MemberType(){} // RVA: 0x7A82D1450
        public void get_SchemaType(){} // RVA: 0x7A82D1450
        public void get_SchemaElement(){} // RVA: 0x7A82D1450
        public void get_SchemaAttribute(){} // RVA: 0x7A82D1450
        public void Equals(){} // RVA: 0x7A9203000
        public void GetHashCode(){} // RVA: 0x7AE850FE0
    }

    public class XmlNameEx : XmlName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE851050
        public void get_Validity(){} // RVA: 0x7AE8512B0
        public void get_IsDefault(){} // RVA: 0x7AE8512E0
        public void get_IsNil(){} // RVA: 0x7AE8512F0
        public void get_MemberType(){} // RVA: 0x7A8178B90
        public void get_SchemaType(){} // RVA: 0x7A81A0050
        public void get_SchemaElement(){} // RVA: 0x7AE851300
        public void get_SchemaAttribute(){} // RVA: 0x7AE851380
        public void SetValidity(){} // RVA: 0x7AE851400
        public void SetIsDefault(){} // RVA: 0x7AE851410
        public void SetIsNil(){} // RVA: 0x7AE851440
        public void Equals(){} // RVA: 0x7AE851470
    }

    public class XmlNameTable : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7A7E00B20
        public void Add(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlNamedNodeMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetNamedItem(){} // RVA: 0x7AE851630
        public void SetNamedItem(){} // RVA: 0x7AE8517E0
        public void get_Count(){} // RVA: 0x7AE83E7E0
        public void GetEnumerator(){} // RVA: 0x7AE8518C0
        public void FindNodeOffset(){} // RVA: 0x7AE851A00
        public void AddNode(){} // RVA: 0x7AE851B90
        public void AddNodeForLoad(){} // RVA: 0x7AE851D40
        public void RemoveNodeAt(){} // RVA: 0x7AE851E10
        public void ReplaceNodeAt(){} // RVA: 0x7AE851F90
        public void InsertNodeAt(){} // RVA: 0x7AE852000
    }

    public class XmlNamespaceManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE87EBA0
        public void get_NameTable(){} // RVA: 0x7A81052C0
        public void get_DefaultNamespace(){} // RVA: 0x7AE87EF20
        public void PushScope(){} // RVA: 0x7AC20FD40
        public void PopScope(){} // RVA: 0x7AE87EF90
        public void AddNamespace(){} // RVA: 0x7AE87F0A0
        public void RemoveNamespace(){} // RVA: 0x7AE87F560
        public void GetEnumerator(){} // RVA: 0x7AE87F720
        public void GetNamespacesInScope(){} // RVA: 0x7AE87F920
        public void LookupNamespace(){} // RVA: 0x7AE87FAF0
        public void LookupNamespaceDecl(){} // RVA: 0x7AE87FB40
        public void LookupPrefix(){} // RVA: 0x7AE87FD60
    }

    public class XmlNode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE852AE0
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_Value(){} // RVA: 0x7A82D1450
        public void set_Value(){} // RVA: 0x7AE852BB0
        public void get_NodeType(){} // RVA: 0x7A7E00710
        public void get_ParentNode(){} // RVA: 0x7AE852C90
        public void get_ChildNodes(){} // RVA: 0x7AE852D90
        public void get_PreviousSibling(){} // RVA: 0x7A82D1450
        public void get_NextSibling(){} // RVA: 0x7A82D1450
        public void get_Attributes(){} // RVA: 0x7A82D1450
        public void get_OwnerDocument(){} // RVA: 0x7AE852E20
        public void get_FirstChild(){} // RVA: 0x7AE852EF0
        public void get_LastChild(){} // RVA: 0x7AB65E3A0
        public void get_IsContainer(){} // RVA: 0x7A80D7320
        public void get_LastNode(){} // RVA: 0x7A82D1450
        public void set_LastNode(){} // RVA: 0x7A80D7310
        public void AncestorNode(){} // RVA: 0x7AE852F20
        public void InsertBefore(){} // RVA: 0x7AE852FA0
        public void InsertAfter(){} // RVA: 0x7AE853930
        public void RemoveChild(){} // RVA: 0x7AE8542B0
        public void PrependChild(){} // RVA: 0x7AE854870
        public void AppendChild(){} // RVA: 0x7AE8548C0
        public void AppendChildForLoad(){} // RVA: 0x7AE854F70
        public void IsValidChildType(){} // RVA: 0x7A80D7320
        public void CanInsertBefore(){} // RVA: 0x7A81BD750
        public void CanInsertAfter(){} // RVA: 0x7A81BD750
        public void get_HasChildNodes(){} // RVA: 0x7AE8552B0
        public void CloneNode(){} // RVA: 0x7A7E063A0
        public void CopyChildren(){} // RVA: 0x7AE8552E0
        public void get_NamespaceURI(){} // RVA: 0x7AE8553A0
        public void get_Prefix(){} // RVA: 0x7AE8553E0
        public void set_Prefix(){} // RVA: 0x7A80D7310
        public void get_LocalName(){} // RVA: 0x7A7E00680
        public void get_IsReadOnly(){} // RVA: 0x7AE855420
        public void HasReadOnlyParent(){} // RVA: 0x7AE855500
        public void System.ICloneable.Clone(){} // RVA: 0x7AE8555E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE855600
        public void GetEnumerator(){} // RVA: 0x7AE855660
        public void AppendChildText(){} // RVA: 0x7AE8556C0
        public void get_InnerText(){} // RVA: 0x7AE8557F0
        public void set_InnerText(){} // RVA: 0x7AE855930
        public void set_InnerXml(){} // RVA: 0x7AE855A40
        public void get_SchemaInfo(){} // RVA: 0x7AE855AA0
        public void get_BaseURI(){} // RVA: 0x7AE855B00
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void WriteContentTo(){} // RVA: 0x7A7E18800
        public void RemoveAll(){} // RVA: 0x7AE855C20
        public void get_Document(){} // RVA: 0x7AE855CA0
        public void GetPrefixOfNamespace(){} // RVA: 0x7AE855D40
        public void GetPrefixOfNamespaceStrict(){} // RVA: 0x7AE855DA0
        public void SetParent(){} // RVA: 0x7AE856260
        public void SetParentForLoad(){} // RVA: 0x7A80D8E20
        public void SplitName(){} // RVA: 0x7AE856340
        public void FindChild(){} // RVA: 0x7AE8564C0
        public void GetEventArgs(){} // RVA: 0x7AE856550
        public void BeforeEvent(){} // RVA: 0x7AE856690
        public void AfterEvent(){} // RVA: 0x7AE8566E0
        public void get_XmlSpace(){} // RVA: 0x7AE856730
        public void get_XmlLang(){} // RVA: 0x7AE8569C0
        public void get_IsText(){} // RVA: 0x7A80D7320
        public void NestTextNodes(){} // RVA: 0x7AE856AC0
        public void UnnestTextNodes(){} // RVA: 0x7AE856B20
    }

    public class XmlNodeChangedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE856BA0
        public void get_Action(){} // RVA: 0x7A8124910
    }

    public class XmlNodeChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class XmlNodeList : Object
    {
        // ── Methods ──
        public void Item(){} // RVA: 0x7A7E00740
        public void get_Count(){} // RVA: 0x7A7E00710
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void get_ItemOf(){} // RVA: 0x7ABE04E20
        public void System.IDisposable.Dispose(){} // RVA: 0x7AB5DC320
        public void PrivateDisposeNodeList(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlNodeReader : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE85BA60
        public void IsInReadingStates(){} // RVA: 0x7ADF5D750
        public void get_NodeType(){} // RVA: 0x7AE85BBA0
        public void get_Name(){} // RVA: 0x7AE85BBB0
        public void get_LocalName(){} // RVA: 0x7AE85BC20
        public void get_NamespaceURI(){} // RVA: 0x7AE85BD50
        public void get_Prefix(){} // RVA: 0x7AE85BDD0
        public void get_Value(){} // RVA: 0x7AE85BE50
        public void get_Depth(){} // RVA: 0x7A9739200
        public void get_BaseURI(){} // RVA: 0x7AE85BEC0
        public void get_CanResolveEntity(){} // RVA: 0x7A81BD750
        public void get_IsEmptyElement(){} // RVA: 0x7AE85BF00
        public void get_IsDefault(){} // RVA: 0x7AE85BF30
        public void get_XmlSpace(){} // RVA: 0x7AE85C010
        public void get_XmlLang(){} // RVA: 0x7AE85C060
        public void get_SchemaInfo(){} // RVA: 0x7AE85C0E0
        public void get_AttributeCount(){} // RVA: 0x7AE85C130
        public void GetAttribute(){} // RVA: 0x7AE85C240
        public void MoveToAttribute(){} // RVA: 0x7AE85C400
        public void MoveToFirstAttribute(){} // RVA: 0x7AE85C5C0
        public void MoveToNextAttribute(){} // RVA: 0x7AE85C6B0
        public void MoveToElement(){} // RVA: 0x7AE85C7C0
        public void Read(){} // RVA: 0x7AE85C930
        public void ReadNextNode(){} // RVA: 0x7AE85CB00
        public void SetEndOfFile(){} // RVA: 0x7AE85CDC0
        public void ReadAtZeroLevel(){} // RVA: 0x7AE85CDE0
        public void ReadForward(){} // RVA: 0x7AE85CE80
        public void ReSetReadingMarks(){} // RVA: 0x7AE85D070
        public void get_EOF(){} // RVA: 0x7AE85D0A0
        public void Close(){} // RVA: 0x7AE85D0B0
        public void get_ReadState(){} // RVA: 0x7A851DB90
        public void Skip(){} // RVA: 0x7AE85D0C0
        public void ReadString(){} // RVA: 0x7AE85D0D0
        public void get_HasAttributes(){} // RVA: 0x7AE8137B0
        public void get_NameTable(){} // RVA: 0x7A88F42F0
        public void LookupNamespace(){} // RVA: 0x7AE85D180
        public void ResolveEntity(){} // RVA: 0x7AE85D1C0
        public void ReadAttributeValue(){} // RVA: 0x7AE85D250
        public void FinishReadBinary(){} // RVA: 0x7AE85D2A0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE85D2D0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE85D2F0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE85D310
        public void get_DtdInfo(){} // RVA: 0x7AE85D380
    }

    public class XmlNodeReaderNavigator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE856DB0
        public void get_NodeType(){} // RVA: 0x7AE8577A0
        public void get_NamespaceURI(){} // RVA: 0x7ADE59400
        public void get_Name(){} // RVA: 0x7AE8577F0
        public void get_LocalName(){} // RVA: 0x7AE857930
        public void get_CreatedOnAttribute(){} // RVA: 0x7A98A9E50
        public void IsLocalNameEmpty(){} // RVA: 0x7AE857A10
        public void get_Prefix(){} // RVA: 0x7AE5621F0
        public void get_Value(){} // RVA: 0x7AE857A60
        public void get_BaseURI(){} // RVA: 0x7AE5622B0
        public void get_XmlSpace(){} // RVA: 0x7AE857D40
        public void get_XmlLang(){} // RVA: 0x7AE857D70
        public void get_IsEmptyElement(){} // RVA: 0x7AE857DA0
        public void get_IsDefault(){} // RVA: 0x7AE857E50
        public void get_SchemaInfo(){} // RVA: 0x7AE791460
        public void get_NameTable(){} // RVA: 0x7A83F69F0
        public void get_AttributeCount(){} // RVA: 0x7AE857F10
        public void CheckIndexCondition(){} // RVA: 0x7AE858060
        public void InitDecAttr(){} // RVA: 0x7AE8580D0
        public void GetDeclarationAttr(){} // RVA: 0x7AE858660
        public void GetDecAttrInd(){} // RVA: 0x7AE8586B0
        public void InitDocTypeAttr(){} // RVA: 0x7AE858780
        public void GetDocumentTypeAttr(){} // RVA: 0x7AE858B00
        public void GetDocTypeAttrInd(){} // RVA: 0x7AE858B50
        public void GetAttributeFromElement(){} // RVA: 0x7AE858FC0
        public void GetAttribute(){} // RVA: 0x7AE859390
        public void LogMove(){} // RVA: 0x7AE8595F0
        public void RollBackMove(){} // RVA: 0x7AE859660
        public void get_IsOnDeclOrDocType(){} // RVA: 0x7AE8596E0
        public void ResetToAttribute(){} // RVA: 0x7AE859720
        public void ResetMove(){} // RVA: 0x7AE859850
        public void MoveToAttribute(){} // RVA: 0x7AE859FA0
        public void MoveToAttributeFromElement(){} // RVA: 0x7AE859B70
        public void MoveToNextAttribute(){} // RVA: 0x7AE85A170
        public void MoveToParent(){} // RVA: 0x7AE85A370
        public void MoveToFirstChild(){} // RVA: 0x7AE85A410
        public void MoveToNextSibling(){} // RVA: 0x7AE85A4B0
        public void MoveToNext(){} // RVA: 0x7AE85A550
        public void MoveToElement(){} // RVA: 0x7AE85A5B0
        public void LookupNamespace(){} // RVA: 0x7AE85A640
        public void DefaultLookupNamespace(){} // RVA: 0x7AE85A9E0
        public void LookupPrefix(){} // RVA: 0x7AE85AC00
        public void GetNamespacesInScope(){} // RVA: 0x7AE85B1B0
        public void ReadAttributeValue(){} // RVA: 0x7AE85B830
        public void get_Document(){} // RVA: 0x7A8292C30
    }

    public class XmlNotation : XmlNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE85D3B0
        public void get_Name(){} // RVA: 0x7A8105330
        public void get_LocalName(){} // RVA: 0x7A8105330
        public void get_NodeType(){} // RVA: 0x7A9F22B10
        public void CloneNode(){} // RVA: 0x7AE85D600
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void set_InnerXml(){} // RVA: 0x7AE85D660
        public void WriteTo(){} // RVA: 0x7A80D7310
        public void WriteContentTo(){} // RVA: 0x7A80D7310
    }

    public class XmlParserContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE810E00
        public void get_NameTable(){} // RVA: 0x7A80F2570
        public void get_NamespaceManager(){} // RVA: 0x7A80DA7B0
        public void get_DocTypeName(){} // RVA: 0x7A81052C0
        public void get_PublicId(){} // RVA: 0x7A8105330
        public void get_SystemId(){} // RVA: 0x7A83F69F0
        public void get_BaseURI(){} // RVA: 0x7A8178B90
        public void get_InternalSubset(){} // RVA: 0x7A8292C30
        public void get_XmlLang(){} // RVA: 0x7A8154D80
        public void get_XmlSpace(){} // RVA: 0x7A8178B70
        public void get_Encoding(){} // RVA: 0x7A81A0050
        public void get_HasDtdInfo(){} // RVA: 0x7AE811530
    }

    public class XmlProcessingInstruction : XmlLinkedNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE85D6C0
        public void get_Name(){} // RVA: 0x7AE85D7A0
        public void get_LocalName(){} // RVA: 0x7AE50A3E0
        public void get_Value(){} // RVA: 0x7A8105330
        public void set_Value(){} // RVA: 0x7AE85D800
        public void set_Data(){} // RVA: 0x7AE85D810
        public void get_InnerText(){} // RVA: 0x7A8105330
        public void set_InnerText(){} // RVA: 0x7AE85D800
        public void get_NodeType(){} // RVA: 0x7A88258F0
        public void CloneNode(){} // RVA: 0x7AE85D920
        public void WriteTo(){} // RVA: 0x7AE85D970
        public void WriteContentTo(){} // RVA: 0x7A80D7310
    }

    public class XmlQualifiedName : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE880220
        public void get_Namespace(){} // RVA: 0x7A80DA7B0
        public void get_Name(){} // RVA: 0x7A80F2570
        public void GetHashCode(){} // RVA: 0x7AE880350
        public void get_IsEmpty(){} // RVA: 0x7AE880490
        public void ToString(){} // RVA: 0x7AE880890
        public void Equals(){} // RVA: 0x7AE880540
        public void op_Equality(){} // RVA: 0x7AE8806D0
        public void op_Inequality(){} // RVA: 0x7AE880790
        public void GetHashCodeDelegate(){} // RVA: 0x7AE880900
        public void IsRandomizedHashingDisabled(){} // RVA: 0x7A80D7320
        public void GetHashCodeOfString(){} // RVA: 0x7AA8B33C0
        public void Init(){} // RVA: 0x7AE880BE0
        public void SetNamespace(){} // RVA: 0x7A813E420
        public void Verify(){} // RVA: 0x7AE880CA0
        public void Atomize(){} // RVA: 0x7AE880D40
        public void Parse(){} // RVA: 0x7AE880E50
        public void Clone(){} // RVA: 0x7AE880FC0
        public void .cctor(){} // RVA: 0x7AE881040
    }

    public class XmlRawWriter : XmlWriter
    {
        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7AE8116C0
        public void WriteEndDocument(){} // RVA: 0x7AE811720
        public void WriteDocType(){} // RVA: 0x7A80D7310
        public void WriteEndElement(){} // RVA: 0x7A7E1DDC0
        public void WriteFullEndElement(){} // RVA: 0x7AE811C60
        public void WriteBase64(){} // RVA: 0x7AE811840
        public void LookupPrefix(){} // RVA: 0x7AE8119A0
        public void get_WriteState(){} // RVA: 0x7AE811A00
        public void WriteCData(){} // RVA: 0x7AE810010
        public void WriteCharEntity(){} // RVA: 0x7AE811A60
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE811AF0
        public void WriteWhitespace(){} // RVA: 0x7AE810010
        public void WriteChars(){} // RVA: 0x7A9240680
        public void WriteRaw(){} // RVA: 0x7AE810010
        public void WriteValue(){} // RVA: 0x7AE810010
        public void WriteAttributes(){} // RVA: 0x7AE811BA0
        public void WriteNode(){} // RVA: 0x7AE811C00
        public void set_NamespaceResolver(){} // RVA: 0x7A81052D0
        public void WriteXmlDeclaration(){} // RVA: 0x7A80D7310
        public void StartElementContent(){} // RVA: 0x7A7E18770
        public void OnRootElement(){} // RVA: 0x7A80D7310
        public void WriteNamespaceDeclaration(){} // RVA: 0x7A7E18890
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7A80D7320
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7AE811C80
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7AE811CC0
        public void WriteEndBase64(){} // RVA: 0x7AE811D00
        public void Close(){} // RVA: 0x7ADB87DC0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlRawWriterBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6D7A90
        public void WriteChars(){} // RVA: 0x7AE6D7B00
    }

    public class XmlReader : Object
    {
        // ── Methods ──
        public void get_Settings(){} // RVA: 0x7A82D1450
        public void get_NodeType(){} // RVA: 0x7A7E00710
        public void get_Name(){} // RVA: 0x7AE811D20
        public void get_LocalName(){} // RVA: 0x7A7E00680
        public void get_NamespaceURI(){} // RVA: 0x7A7E00680
        public void get_Prefix(){} // RVA: 0x7A7E00680
        public void get_Value(){} // RVA: 0x7A7E00680
        public void get_Depth(){} // RVA: 0x7A7E00710
        public void get_BaseURI(){} // RVA: 0x7A7E00680
        public void get_IsEmptyElement(){} // RVA: 0x7A7E01900
        public void get_IsDefault(){} // RVA: 0x7A80D7320
        public void get_QuoteChar(){} // RVA: 0x7AE811E30
        public void get_XmlSpace(){} // RVA: 0x7A82D1450
        public void get_XmlLang(){} // RVA: 0x7AE811E40
        public void get_SchemaInfo(){} // RVA: 0x7AE811E80
        public void get_ValueType(){} // RVA: 0x7AE811EC0
        public void get_AttributeCount(){} // RVA: 0x7A7E00710
        public void GetAttribute(){} // RVA: 0x7A7E00740
        public void MoveToAttribute(){} // RVA: 0x7AE811F70
        public void MoveToFirstAttribute(){} // RVA: 0x7A7E01900
        public void MoveToNextAttribute(){} // RVA: 0x7A7E01900
        public void MoveToElement(){} // RVA: 0x7A7E01900
        public void ReadAttributeValue(){} // RVA: 0x7A7E01900
        public void Read(){} // RVA: 0x7A7E01900
        public void get_EOF(){} // RVA: 0x7A7E01900
        public void Close(){} // RVA: 0x7A80D7310
        public void get_ReadState(){} // RVA: 0x7A7E00710
        public void Skip(){} // RVA: 0x7AE812040
        public void get_NameTable(){} // RVA: 0x7A7E00680
        public void LookupNamespace(){} // RVA: 0x7A7E00B20
        public void get_CanResolveEntity(){} // RVA: 0x7A80D7320
        public void ResolveEntity(){} // RVA: 0x7A7E18770
        public void get_CanReadValueChunk(){} // RVA: 0x7A80D7320
        public void ReadValueChunk(){} // RVA: 0x7AE812150
        public void ReadString(){} // RVA: 0x7AE8121B0
        public void MoveToContent(){} // RVA: 0x7AE812420
        public void ReadStartElement(){} // RVA: 0x7AE8124C0
        public void ReadElementString(){} // RVA: 0x7AE8125C0
        public void ReadEndElement(){} // RVA: 0x7AE812880
        public void IsStartElement(){} // RVA: 0x7AE812980
        public void ReadInnerXml(){} // RVA: 0x7AE812A80
        public void WriteNode(){} // RVA: 0x7AE812F20
        public void WriteAttributeValue(){} // RVA: 0x7AE813480
        public void CreateWriterForInnerOuterXml(){} // RVA: 0x7AE8135A0
        public void SetNamespacesFlag(){} // RVA: 0x7AE8136D0
        public void get_HasAttributes(){} // RVA: 0x7AE8137B0
        public void Dispose(){} // RVA: 0x7AE813800
        public void get_NamespaceManager(){} // RVA: 0x7A82D1450
        public void IsTextualNode(){} // RVA: 0x7AE813840
        public void HasValueInternal(){} // RVA: 0x7AE8138B0
        public void SkipSubtree(){} // RVA: 0x7AE813920
        public void get_IsDefaultInternal(){} // RVA: 0x7AE813A10
        public void get_DtdInfo(){} // RVA: 0x7A82D1450
        public void Create(){} // RVA: 0x7AE813E30
        public void CreateSqlReader(){} // RVA: 0x7AE813FB0
        public void CalcBufferSize(){} // RVA: 0x7AE8142F0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE814390
    }

    public class XmlReaderSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE814400
        public void get_Async(){} // RVA: 0x7A81A2200
        public void set_Async(){} // RVA: 0x7AE814410
        public void get_NameTable(){} // RVA: 0x7A80DA7B0
        public void set_NameTable(){} // RVA: 0x7AE814470
        public void get_IsXmlResolverSet(){} // RVA: 0x7AD8E6CE0
        public void set_IsXmlResolverSet(){} // RVA: 0x7AD8E6CF0
        public void set_XmlResolver(){} // RVA: 0x7AE814510
        public void GetXmlResolver(){} // RVA: 0x7A81052C0
        public void GetXmlResolver_CheckConfig(){} // RVA: 0x7AE8145B0
        public void get_LineNumberOffset(){} // RVA: 0x7A854FDE0
        public void set_LineNumberOffset(){} // RVA: 0x7AE8145C0
        public void get_LinePositionOffset(){} // RVA: 0x7A8F9ACE0
        public void set_LinePositionOffset(){} // RVA: 0x7AE814610
        public void get_ConformanceLevel(){} // RVA: 0x7A8133100
        public void set_ConformanceLevel(){} // RVA: 0x7AE814660
        public void get_CheckCharacters(){} // RVA: 0x7A810DDD0
        public void set_CheckCharacters(){} // RVA: 0x7AE814700
        public void get_MaxCharactersInDocument(){} // RVA: 0x7A8292C30
        public void set_MaxCharactersInDocument(){} // RVA: 0x7AE814760
        public void get_MaxCharactersFromEntities(){} // RVA: 0x7A8154D80
        public void set_MaxCharactersFromEntities(){} // RVA: 0x7AE814800
        public void get_IgnoreWhitespace(){} // RVA: 0x7A818F850
        public void set_IgnoreWhitespace(){} // RVA: 0x7AE8148A0
        public void get_IgnoreProcessingInstructions(){} // RVA: 0x7A9107BC0
        public void set_IgnoreProcessingInstructions(){} // RVA: 0x7AE814900
        public void get_IgnoreComments(){} // RVA: 0x7A9476890
        public void set_IgnoreComments(){} // RVA: 0x7AE814960
        public void get_DtdProcessing(){} // RVA: 0x7A9231EA0
        public void set_DtdProcessing(){} // RVA: 0x7AE8149C0
        public void get_CloseInput(){} // RVA: 0x7A81A00C0
        public void set_CloseInput(){} // RVA: 0x7AE814A60
        public void get_ValidationType(){} // RVA: 0x7A8355950
        public void set_ValidationType(){} // RVA: 0x7AE814AC0
        public void get_ValidationFlags(){} // RVA: 0x7A8A22410
        public void set_ValidationFlags(){} // RVA: 0x7AE814B60
        public void get_Schemas(){} // RVA: 0x7AE814C00
        public void set_Schemas(){} // RVA: 0x7AE814CB0
        public void Clone(){} // RVA: 0x7AE814D50
        public void GetEventHandler(){} // RVA: 0x7A8175DF0
        public void CreateReader(){} // RVA: 0x7AE814F50
        public void set_ReadOnly(){} // RVA: 0x7ACF040C0
        public void CheckReadOnly(){} // RVA: 0x7AE815090
        public void Initialize(){} // RVA: 0x7AE815140
        public void CreateDefaultResolver(){} // RVA: 0x7AE815360
        public void AddValidation(){} // RVA: 0x7AE8153A0
        public void CreateDtdValidatingReader(){} // RVA: 0x7AE8154D0
        public void EnableLegacyXmlSettings(){} // RVA: 0x7AE815560
    }

    public class XmlRegisteredNonCachedStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE87A090
        public void Finalize(){} // RVA: 0x7AE87A1F0
        public void Dispose(){} // RVA: 0x7AE87A2A0
        public void BeginRead(){} // RVA: 0x7AE87A3E0
        public void BeginWrite(){} // RVA: 0x7AE87A420
        public void EndRead(){} // RVA: 0x7AE87A460
        public void EndWrite(){} // RVA: 0x7AE5D9AF0
        public void Flush(){} // RVA: 0x7AE203670
        public void Read(){} // RVA: 0x7AE87A490
        public void ReadByte(){} // RVA: 0x7ADBF6950
        public void Seek(){} // RVA: 0x7AE87A4C0
        public void SetLength(){} // RVA: 0x7AE47D1C0
        public void Write(){} // RVA: 0x7AE87A4F0
        public void WriteByte(){} // RVA: 0x7AE87A520
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_CanWrite(){} // RVA: 0x7AE87A550
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE804490
    }

    public class XmlResolver : Object
    {
        // ── Methods ──
        public void GetEntity(){} // RVA: 0x7A7E06710
        public void ResolveUri(){} // RVA: 0x7AE8811B0
        public void SupportsType(){} // RVA: 0x7AE881450
        public void GetEntityAsync(){} // RVA: 0x7AE881570
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlSignificantWhitespace : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE85D9B0
        public void get_Name(){} // RVA: 0x7AE85DAB0
        public void get_LocalName(){} // RVA: 0x7AE85DAB0
        public void get_NodeType(){} // RVA: 0x7A95096B0
        public void get_ParentNode(){} // RVA: 0x7AE85DAE0
        public void CloneNode(){} // RVA: 0x7AE85DB90
        public void get_Value(){} // RVA: 0x7ADCAB740
        public void set_Value(){} // RVA: 0x7AE85DC00
        public void WriteTo(){} // RVA: 0x7AE85DD00
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void get_IsText(){} // RVA: 0x7A81BD750
    }

    public class XmlSqlBinaryReader : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6DD5F0
        public void get_Settings(){} // RVA: 0x7AE6DE0B0
        public void get_NodeType(){} // RVA: 0x7A846C750
        public void get_LocalName(){} // RVA: 0x7A87D9480
        public void get_NamespaceURI(){} // RVA: 0x7A8142610
        public void get_Prefix(){} // RVA: 0x7A87C5850
        public void get_Value(){} // RVA: 0x7AE6DE350
        public void get_Depth(){} // RVA: 0x7AE6DE7B0
        public void get_BaseURI(){} // RVA: 0x7A81163D0
        public void get_IsEmptyElement(){} // RVA: 0x7AE6DE880
        public void get_XmlSpace(){} // RVA: 0x7AE6DE8A0
        public void get_XmlLang(){} // RVA: 0x7AE6DE930
        public void get_ValueType(){} // RVA: 0x7A884F050
        public void get_AttributeCount(){} // RVA: 0x7AE6DEA00
        public void GetAttribute(){} // RVA: 0x7AE6DECB0
        public void MoveToAttribute(){} // RVA: 0x7AE6DEDF0
        public void MoveToFirstAttribute(){} // RVA: 0x7AE6DEEA0
        public void MoveToNextAttribute(){} // RVA: 0x7AE6DEF30
        public void MoveToElement(){} // RVA: 0x7AE6DEFE0
        public void get_EOF(){} // RVA: 0x7AE6DF190
        public void ReadAttributeValue(){} // RVA: 0x7AE6DF1A0
        public void Close(){} // RVA: 0x7AE6DF3E0
        public void get_NameTable(){} // RVA: 0x7A8175DF0
        public void LookupNamespace(){} // RVA: 0x7AE6DF570
        public void ResolveEntity(){} // RVA: 0x7AE6DF640
        public void get_ReadState(){} // RVA: 0x7AE6DF680
        public void Read(){} // RVA: 0x7AE6DF700
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE6DF880
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE6DFD40
        public void VerifyVersion(){} // RVA: 0x7AE6DFED0
        public void AddInitNamespace(){} // RVA: 0x7AE6DFF20
        public void AddName(){} // RVA: 0x7AE6E0090
        public void AddQName(){} // RVA: 0x7AE6E01E0
        public void NameFlush(){} // RVA: 0x7AE6E0570
        public void SkipExtn(){} // RVA: 0x7AE6E05D0
        public void ReadQNameRef(){} // RVA: 0x7AE6E0710
        public void ReadNameRef(){} // RVA: 0x7AE6E07E0
        public void FillAllowEOF(){} // RVA: 0x7AE6E08B0
        public void Fill_(){} // RVA: 0x7AE6E0B00
        public void Fill(){} // RVA: 0x7AE6E0B80
        public void ReadByte(){} // RVA: 0x7AE6E0C10
        public void ReadUShort(){} // RVA: 0x7AE6E0C60
        public void ParseMB32(){} // RVA: 0x7AE6E0E80
        public void ParseMB32_(){} // RVA: 0x7AE6E0D20
        public void ParseMB64(){} // RVA: 0x7AE6E0CC0
        public void PeekToken(){} // RVA: 0x7AE6E0FA0
        public void ReadToken(){} // RVA: 0x7AE6E1220
        public void NextToken2(){} // RVA: 0x7AE6E14A0
        public void NextToken1(){} // RVA: 0x7AE6E17E0
        public void NextToken(){} // RVA: 0x7AE6E1850
        public void PeekNextToken(){} // RVA: 0x7AE6E18F0
        public void RescanNextToken(){} // RVA: 0x7AE6E1910
        public void ParseText(){} // RVA: 0x7AE6E1BC0
        public void ScanText(){} // RVA: 0x7AE6E1C80
        public void GetString(){} // RVA: 0x7AE6E1DE0
        public void GetStringAligned(){} // RVA: 0x7AE6E1FB0
        public void GetAttributeText(){} // RVA: 0x7AE6E1FF0
        public void LocateAttribute(){} // RVA: 0x7AE6E2280
        public void PositionOnAttribute(){} // RVA: 0x7AE6E23E0
        public void GrowElements(){} // RVA: 0x7AE6E25D0
        public void GrowAttributes(){} // RVA: 0x7AE6E26D0
        public void ClearAttributes(){} // RVA: 0x7AE6E27B0
        public void PushNamespace(){} // RVA: 0x7AE6E27D0
        public void PopNamespaces(){} // RVA: 0x7AE6E2B20
        public void GenerateImpliedXmlnsAttrs(){} // RVA: 0x7AE6E2C20
        public void ReadInit(){} // RVA: 0x7AE6E2DD0
        public void ScanAttributes(){} // RVA: 0x7AE6E3410
        public void SimpleCheckForDuplicateAttributes(){} // RVA: 0x7AE6E3B40
        public void HashCheckForDuplicateAttributes(){} // RVA: 0x7AE6E3E40
        public void XmlDeclValue(){} // RVA: 0x7AE6E4300
        public void CDATAValue(){} // RVA: 0x7AE6E4470
        public void FinishCDATA(){} // RVA: 0x7AE6E45F0
        public void FinishEndElement(){} // RVA: 0x7AE6E4690
        public void ReadDoc(){} // RVA: 0x7AE6E4810
        public void ImplReadData(){} // RVA: 0x7AE6E5040
        public void ImplReadElement(){} // RVA: 0x7AE6E5290
        public void ImplReadEndElement(){} // RVA: 0x7AE6E5720
        public void ImplReadDoctype(){} // RVA: 0x7AE6E5850
        public void ImplReadPI(){} // RVA: 0x7AE6E5C60
        public void ImplReadComment(){} // RVA: 0x7AE6E5D20
        public void ImplReadCDATA(){} // RVA: 0x7AE6E5D60
        public void ImplReadNest(){} // RVA: 0x7AE6E5DF0
        public void ImplReadEndNest(){} // RVA: 0x7AE6E5FE0
        public void ImplReadXmlText(){} // RVA: 0x7AE6E60D0
        public void UpdateFromTextReader(){} // RVA: 0x7AE6E6A70
        public void CheckAllowContent(){} // RVA: 0x7AE6E6A90
        public void GenerateTokenTypeMap(){} // RVA: 0x7AE6E6AF0
        public void GetValueType(){} // RVA: 0x7AE6E7ED0
        public void ReScanOverValue(){} // RVA: 0x7AE6E7FC0
        public void ScanOverValue(){} // RVA: 0x7AE6E7FE0
        public void ScanOverAnyValue(){} // RVA: 0x7AE6E8200
        public void CheckText(){} // RVA: 0x7AE6E8890
        public void CheckTextIsWS(){} // RVA: 0x7AE6E8AD0
        public void CheckValueTokenBounds(){} // RVA: 0x7AE6E8B70
        public void GetXsdKatmaiTokenLength(){} // RVA: 0x7AE6E8BD0
        public void XsdKatmaiTimeScaleToValueLength(){} // RVA: 0x7AE6E8D30
        public void ValueAsLong(){} // RVA: 0x7AE6E8E00
        public void ValueAsULong(){} // RVA: 0x7AE6E9390
        public void ValueAsDecimal(){} // RVA: 0x7AE6E9430
        public void ValueAsDouble(){} // RVA: 0x7AE6E9750
        public void ValueAsDateTimeString(){} // RVA: 0x7AE6E9950
        public void ValueAsString(){} // RVA: 0x7AE6E9F60
        public void GetInt16(){} // RVA: 0x7AE6EA8E0
        public void GetUInt16(){} // RVA: 0x7AE6EA8E0
        public void GetInt32(){} // RVA: 0x7AE6EA930
        public void GetUInt32(){} // RVA: 0x7AE6EA930
        public void GetInt64(){} // RVA: 0x7AE6EA9B0
        public void GetUInt64(){} // RVA: 0x7AE6EA9B0
        public void GetSingle(){} // RVA: 0x7AE6EAAD0
        public void GetDouble(){} // RVA: 0x7AE6EAB50
        public void ThrowUnexpectedToken(){} // RVA: 0x7AE6EACB0
        public void ThrowXmlException(){} // RVA: 0x7AE6EAD80
        public void ThrowNotSupported(){} // RVA: 0x7AE6EAE70
        public void .cctor(){} // RVA: 0x7AE6EAEE0
    }

    public class XmlText : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83F550
        public void get_Name(){} // RVA: 0x7AE85DD60
        public void get_LocalName(){} // RVA: 0x7AE85DD60
        public void get_NodeType(){} // RVA: 0x7A87EE0F0
        public void get_ParentNode(){} // RVA: 0x7AE83F590
        public void CloneNode(){} // RVA: 0x7AE85DD90
        public void get_Value(){} // RVA: 0x7ADCAB740
        public void set_Value(){} // RVA: 0x7AE85DE00
        public void WriteTo(){} // RVA: 0x7AE85DD00
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void get_IsText(){} // RVA: 0x7A81BD750
    }

    public class XmlTextEncoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE815610
        public void set_QuoteChar(){} // RVA: 0x7AD8A9500
        public void StartAttribute(){} // RVA: 0x7AE8156F0
        public void EndAttribute(){} // RVA: 0x7AE8157C0
        public void get_AttributeValue(){} // RVA: 0x7AE815800
        public void WriteSurrogateChar(){} // RVA: 0x7AE815870
        public void Write(){} // RVA: 0x7AE8160C0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE815E80
        public void WriteRawWithSurrogateChecking(){} // RVA: 0x7AE816650
        public void WriteRaw(){} // RVA: 0x7AE8168A0
        public void WriteCharEntity(){} // RVA: 0x7AE816A60
        public void WriteEntityRef(){} // RVA: 0x7AE816C50
        public void WriteStringFragment(){} // RVA: 0x7AE816CD0
        public void WriteCharEntityImpl(){} // RVA: 0x7AE816E90
        public void WriteEntityRefImpl(){} // RVA: 0x7AE816F40
    }

    public class XmlTextReader : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8174E0
        public void get_NodeType(){} // RVA: 0x7A858ABB0
        public void get_Name(){} // RVA: 0x7ADE59240
        public void get_LocalName(){} // RVA: 0x7A856A750
        public void get_NamespaceURI(){} // RVA: 0x7ADB00ED0
        public void get_Prefix(){} // RVA: 0x7ADB00F00
        public void get_Value(){} // RVA: 0x7A972BF20
        public void get_Depth(){} // RVA: 0x7AE3C9490
        public void get_BaseURI(){} // RVA: 0x7A858ABE0
        public void get_IsEmptyElement(){} // RVA: 0x7A858AB50
        public void get_IsDefault(){} // RVA: 0x7A858AA50
        public void get_QuoteChar(){} // RVA: 0x7A858AB80
        public void get_XmlSpace(){} // RVA: 0x7A858AA20
        public void get_XmlLang(){} // RVA: 0x7A858AC40
        public void get_AttributeCount(){} // RVA: 0x7AE1E3E00
        public void GetAttribute(){} // RVA: 0x7AE562100
        public void MoveToAttribute(){} // RVA: 0x7AE562160
        public void MoveToFirstAttribute(){} // RVA: 0x7ADB010B0
        public void MoveToNextAttribute(){} // RVA: 0x7ADBF0670
        public void MoveToElement(){} // RVA: 0x7A8555880
        public void ReadAttributeValue(){} // RVA: 0x7ADE58970
        public void Read(){} // RVA: 0x7AE562190
        public void get_EOF(){} // RVA: 0x7AE5621C0
        public void Close(){} // RVA: 0x7ADE59400
        public void get_ReadState(){} // RVA: 0x7AE5621F0
        public void Skip(){} // RVA: 0x7ADA26BF0
        public void get_NameTable(){} // RVA: 0x7ADE584C0
        public void LookupNamespace(){} // RVA: 0x7AE817680
        public void get_CanResolveEntity(){} // RVA: 0x7A81BD750
        public void ResolveEntity(){} // RVA: 0x7AE562280
        public void get_CanReadValueChunk(){} // RVA: 0x7A80D7320
        public void ReadString(){} // RVA: 0x7AE8176C0
        public void HasLineInfo(){} // RVA: 0x7A81BD750
        public void get_LineNumber(){} // RVA: 0x7AE8176F0
        public void get_LinePosition(){} // RVA: 0x7AE817720
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE817750
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE562220
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE817790
        public void get_Namespaces(){} // RVA: 0x7A8D77920
        public void get_Normalization(){} // RVA: 0x7AE8177D0
        public void set_Normalization(){} // RVA: 0x7AE8177F0
        public void set_WhitespaceHandling(){} // RVA: 0x7AE8178D0
        public void set_EntityHandling(){} // RVA: 0x7AE8179D0
        public void set_XmlResolver(){} // RVA: 0x7AE817A70
        public void get_Impl(){} // RVA: 0x7A80F2570
        public void get_NamespaceManager(){} // RVA: 0x7AE817A90
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7AE817AC0
        public void get_DtdInfo(){} // RVA: 0x7AE817AE0
    }

    public class XmlTextReaderImpl : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7036F0
        public void FinishInitUriString(){} // RVA: 0x7AE7028C0
        public void FinishInitStream(){} // RVA: 0x7AE7031E0
        public void FinishInitTextReader(){} // RVA: 0x7AE7035B0
        public void get_Settings(){} // RVA: 0x7AE703850
        public void get_NodeType(){} // RVA: 0x7AE703C10
        public void get_Name(){} // RVA: 0x7AE703C30
        public void get_LocalName(){} // RVA: 0x7AE703C60
        public void get_NamespaceURI(){} // RVA: 0x7AE703C80
        public void get_Prefix(){} // RVA: 0x7AE703CA0
        public void get_Value(){} // RVA: 0x7AE703CC0
        public void get_Depth(){} // RVA: 0x7AE703E40
        public void get_BaseURI(){} // RVA: 0x7A863E8E0
        public void get_IsEmptyElement(){} // RVA: 0x7AE703E60
        public void get_IsDefault(){} // RVA: 0x7AE703E90
        public void get_QuoteChar(){} // RVA: 0x7AE703EC0
        public void get_XmlSpace(){} // RVA: 0x7AE703EF0
        public void get_XmlLang(){} // RVA: 0x7AE703F10
        public void get_ReadState(){} // RVA: 0x7AE703F30
        public void get_EOF(){} // RVA: 0x7AE703F40
        public void get_NameTable(){} // RVA: 0x7A8158F50
        public void get_CanResolveEntity(){} // RVA: 0x7A81BD750
        public void get_AttributeCount(){} // RVA: 0x7A87BD4F0
        public void GetAttribute(){} // RVA: 0x7AE704150
        public void MoveToAttribute(){} // RVA: 0x7AE704310
        public void MoveToFirstAttribute(){} // RVA: 0x7AE704440
        public void MoveToNextAttribute(){} // RVA: 0x7AE704500
        public void MoveToElement(){} // RVA: 0x7AE7045E0
        public void FinishInit(){} // RVA: 0x7AE7046B0
        public void Read(){} // RVA: 0x7AE704700
        public void Close(){} // RVA: 0x7AE70B090
        public void Skip(){} // RVA: 0x7AE704FB0
        public void LookupNamespace(){} // RVA: 0x7AE718470
        public void ReadAttributeValue(){} // RVA: 0x7AE705210
        public void ResolveEntity(){} // RVA: 0x7AE705540
        public void set_OuterReader(){} // RVA: 0x7A8B56C80
        public void MoveOffEntityReference(){} // RVA: 0x7AE7057F0
        public void ReadString(){} // RVA: 0x7AE7058C0
        public void get_CanReadValueChunk(){} // RVA: 0x7A81BD750
        public void ReadValueChunk(){} // RVA: 0x7AE7058E0
        public void HasLineInfo(){} // RVA: 0x7A81BD750
        public void get_LineNumber(){} // RVA: 0x7AE705EC0
        public void get_LinePosition(){} // RVA: 0x7AE705EE0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE705F00
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE4A5120
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE705F30
        public void GetNamespacesInScope(){} // RVA: 0x7AE705F00
        public void LookupPrefix(){} // RVA: 0x7AE705F30
        public void get_Namespaces(){} // RVA: 0x7A9906080
        public void set_Namespaces(){} // RVA: 0x7AE705F60
        public void get_Normalization(){} // RVA: 0x7A8F95140
        public void set_Normalization(){} // RVA: 0x7AE706260
        public void set_WhitespaceHandling(){} // RVA: 0x7AE706340
        public void set_EntityHandling(){} // RVA: 0x7AE706430
        public void get_IsResolverSet(){} // RVA: 0x7AE7064C0
        public void set_XmlResolver(){} // RVA: 0x7AE7064D0
        public void get_DtdParserProxy_NameTable(){} // RVA: 0x7A8158F50
        public void get_DtdParserProxy_NamespaceResolver(){} // RVA: 0x7A8850FF0
        public void get_DtdParserProxy_DtdValidation(){} // RVA: 0x7AE706650
        public void get_DtdParserProxy_Normalization(){} // RVA: 0x7A8F95140
        public void get_DtdParserProxy_Namespaces(){} // RVA: 0x7A9906080
        public void get_DtdParserProxy_V1CompatibilityMode(){} // RVA: 0x7AE706660
        public void get_DtdParserProxy_BaseUri(){} // RVA: 0x7AE706670
        public void get_DtdParserProxy_IsEof(){} // RVA: 0x7A90FA160
        public void get_DtdParserProxy_ParsingBuffer(){} // RVA: 0x7A8105330
        public void get_DtdParserProxy_ParsingBufferLength(){} // RVA: 0x7A82C2070
        public void get_DtdParserProxy_CurrentPosition(){} // RVA: 0x7A8133100
        public void set_DtdParserProxy_CurrentPosition(){} // RVA: 0x7A8133110
        public void get_DtdParserProxy_EntityStackLength(){} // RVA: 0x7AE706730
        public void get_DtdParserProxy_IsEntityEolNormalized(){} // RVA: 0x7AE1658B0
        public void get_DtdParserProxy_ValidationEventHandling(){} // RVA: 0x7A8B772D0
        public void DtdParserProxy_OnNewLine(){} // RVA: 0x7AE706740
        public void get_DtdParserProxy_LineNo(){} // RVA: 0x7A8EA8210
        public void get_DtdParserProxy_LineStartPosition(){} // RVA: 0x7A96E4F70
        public void DtdParserProxy_ReadData(){} // RVA: 0x7AE706750
        public void DtdParserProxy_ParseNumericCharRef(){} // RVA: 0x7AE706760
        public void DtdParserProxy_ParseNamedCharRef(){} // RVA: 0x7AE706810
        public void DtdParserProxy_ParsePI(){} // RVA: 0x7AE706820
        public void DtdParserProxy_ParseComment(){} // RVA: 0x7AE706870
        public void get_IsResolverNull(){} // RVA: 0x7AE707070
        public void GetTempResolver(){} // RVA: 0x7AE707080
        public void DtdParserProxy_PushEntity(){} // RVA: 0x7AE7070E0
        public void DtdParserProxy_PopEntity(){} // RVA: 0x7AE7071A0
        public void DtdParserProxy_PushExternalSubset(){} // RVA: 0x7AE707290
        public void DtdParserProxy_PushInternalDtd(){} // RVA: 0x7AE707430
        public void DtdParserProxy_Throw(){} // RVA: 0x7AE707510
        public void DtdParserProxy_OnSystemId(){} // RVA: 0x7AE707520
        public void DtdParserProxy_OnPublicId(){} // RVA: 0x7AE707600
        public void Throw(){} // RVA: 0x7AE707B90
        public void ReThrow(){} // RVA: 0x7AE707C30
        public void ThrowWithoutLineInfo(){} // RVA: 0x7AE707DF0
        public void ThrowInvalidChar(){} // RVA: 0x7AE707E80
        public void SetErrorState(){} // RVA: 0x7AE707EF0
        public void SendValidationEvent(){} // RVA: 0x7AE708000
        public void get_InAttributeValueIterator(){} // RVA: 0x7AE708070
        public void FinishAttributeValueIterator(){} // RVA: 0x7AE708090
        public void get_DtdValidation(){} // RVA: 0x7AE706650
        public void InitStreamInput(){} // RVA: 0x7AE7082B0
        public void InitTextReaderInput(){} // RVA: 0x7AE708990
        public void InitStringInput(){} // RVA: 0x7AE708C00
        public void InitFragmentReader(){} // RVA: 0x7AE708E40
        public void ProcessDtdFromParserContext(){} // RVA: 0x7AE709420
        public void OpenUrl(){} // RVA: 0x7AE709490
        public void OpenUrlDelegate(){} // RVA: 0x7AE709740
        public void DetectEncoding(){} // RVA: 0x7AE709970
        public void SetupEncoding(){} // RVA: 0x7AE709BB0
        public void SwitchEncoding(){} // RVA: 0x7AE709EC0
        public void CheckEncoding(){} // RVA: 0x7AE70A080
        public void UnDecodeChars(){} // RVA: 0x7AE70A750
        public void SwitchEncodingToUTF8(){} // RVA: 0x7AE70A800
        public void ReadData(){} // RVA: 0x7AE70A8A0
        public void GetChars(){} // RVA: 0x7AE70AE40
        public void InvalidCharRecovery(){} // RVA: 0x7AE70AF20
        public void ShiftBuffer(){} // RVA: 0x7AE70B3E0
        public void ParseXmlDeclaration(){} // RVA: 0x7AE70B410
        public void ParseDocumentContent(){} // RVA: 0x7AE70C850
        public void ParseElementContent(){} // RVA: 0x7AE70CEA0
        public void ThrowUnclosedElements(){} // RVA: 0x7AE70D280
        public void ParseElement(){} // RVA: 0x7AE70D470
        public void AddDefaultAttributesAndNormalize(){} // RVA: 0x7AE70DAB0
        public void ParseEndElement(){} // RVA: 0x7AE70E160
        public void ThrowTagMismatch(){} // RVA: 0x7AE70E6C0
        public void ParseAttributes(){} // RVA: 0x7AE70E8A0
        public void ElementNamespaceLookup(){} // RVA: 0x7AE70EEE0
        public void AttributeNamespaceLookup(){} // RVA: 0x7AE70F010
        public void AttributeDuplCheck(){} // RVA: 0x7AE70F0E0
        public void OnDefaultNamespaceDecl(){} // RVA: 0x7AE70F500
        public void OnNamespaceDecl(){} // RVA: 0x7AE70F6F0
        public void OnXmlReservedAttribute(){} // RVA: 0x7AE70F7E0
        public void ParseAttributeValueSlow(){} // RVA: 0x7AE70FB00
        public void AddAttributeChunkToList(){} // RVA: 0x7AE710E10
        public void ParseText(){} // RVA: 0x7AE7113F0
        public void FinishPartialValue(){} // RVA: 0x7AE711AF0
        public void FinishOtherValueIterator(){} // RVA: 0x7AE712040
        public void SkipPartialTextValue(){} // RVA: 0x7AE712190
        public void FinishReadValueChunk(){} // RVA: 0x7AE7121F0
        public void FinishReadContentAsBinary(){} // RVA: 0x7AE712230
        public void FinishReadElementContentAsBinary(){} // RVA: 0x7AE712390
        public void ParseRootLevelWhitespace(){} // RVA: 0x7AE712460
        public void ParseEntityReference(){} // RVA: 0x7AE712690
        public void HandleEntityReference(){} // RVA: 0x7AE712740
        public void HandleGeneralEntityReference(){} // RVA: 0x7AE7129E0
        public void get_InEntity(){} // RVA: 0x7AE712E30
        public void HandleEntityEnd(){} // RVA: 0x7AE712E40
        public void SetupEndEntityNodeInContent(){} // RVA: 0x7AE7130D0
        public void SetupEndEntityNodeInAttribute(){} // RVA: 0x7AE713310
        public void ParsePI(){} // RVA: 0x7AE7133F0
        public void ParsePIValue(){} // RVA: 0x7AE713C10
        public void ParseComment(){} // RVA: 0x7AE713FA0
        public void ParseCData(){} // RVA: 0x7AE714540
        public void ParseCDataOrComment(){} // RVA: 0x7AE714A70
        public void ParseDoctypeDecl(){} // RVA: 0x7AE714EA0
        public void ParseDtd(){} // RVA: 0x7AE7151F0
        public void SkipDtd(){} // RVA: 0x7AE715570
        public void SkipPublicOrSystemIdLiteral(){} // RVA: 0x7AE715F80
        public void SkipUntil(){} // RVA: 0x7AE716020
        public void EatWhitespaces(){} // RVA: 0x7AE7164D0
        public void ParseCharRefInline(){} // RVA: 0x7AE716720
        public void ParseNumericCharRef(){} // RVA: 0x7AE7167A0
        public void ParseNumericCharRefInline(){} // RVA: 0x7AE716870
        public void ParseNamedCharRef(){} // RVA: 0x7AE717060
        public void ParseNamedCharRefInline(){} // RVA: 0x7AE7173A0
        public void ParseName(){} // RVA: 0x7AE7176B0
        public void ParseQName(){} // RVA: 0x7AE717700
        public void ReadDataInName(){} // RVA: 0x7AE7179A0
        public void ParseEntityName(){} // RVA: 0x7AE7179E0
        public void AddNode(){} // RVA: 0x7AE717AE0
        public void AllocNode(){} // RVA: 0x7AE717B30
        public void AddAttributeNoChecks(){} // RVA: 0x7AE717CF0
        public void AddAttribute(){} // RVA: 0x7AE7180D0
        public void PopElementContext(){} // RVA: 0x7AE718270
        public void OnNewLine(){} // RVA: 0x7AE706740
        public void OnEof(){} // RVA: 0x7AE718330
        public void AddNamespace(){} // RVA: 0x7AE718550
        public void ResetAttributes(){} // RVA: 0x7AE718810
        public void FullAttributeCleanup(){} // RVA: 0x7AE718940
        public void PushXmlContext(){} // RVA: 0x7AE718A40
        public void PopXmlContext(){} // RVA: 0x7AE718C00
        public void GetWhitespaceType(){} // RVA: 0x7AE718C90
        public void GetTextNodeType(){} // RVA: 0x7AE718CE0
        public void PushExternalEntityOrSubset(){} // RVA: 0x7AE718D40
        public void OpenAndPush(){} // RVA: 0x7AE7190A0
        public void PushExternalEntity(){} // RVA: 0x7AE7193B0
        public void PushInternalEntity(){} // RVA: 0x7AE7195B0
        public void PopEntity(){} // RVA: 0x7AE719730
        public void RegisterEntity(){} // RVA: 0x7AE7197D0
        public void UnregisterEntity(){} // RVA: 0x7AE719AE0
        public void PushParsingState(){} // RVA: 0x7AE719B50
        public void PopParsingState(){} // RVA: 0x7AE719DE0
        public void IncrementalRead(){} // RVA: 0x7AE719F20
        public void FinishIncrementalRead(){} // RVA: 0x7AE71ACB0
        public void ParseFragmentAttribute(){} // RVA: 0x7AE71ADC0
        public void ParseAttributeValueChunk(){} // RVA: 0x7AE71AE60
        public void ParseXmlDeclarationFragment(){} // RVA: 0x7AE71B5F0
        public void ThrowUnexpectedToken(){} // RVA: 0x7AE71B6D0
        public void ParseUnexpectedToken(){} // RVA: 0x7AE71B850
        public void ThrowExpectingWhitespace(){} // RVA: 0x7AE71B930
        public void GetIndexOfAttributeWithoutPrefix(){} // RVA: 0x7AE71B9C0
        public void GetIndexOfAttributeWithPrefix(){} // RVA: 0x7AE71BAA0
        public void ZeroEndingStream(){} // RVA: 0x7AE71BB80
        public void ParseDtdFromParserContext(){} // RVA: 0x7AE71BBF0
        public void MoveToNextContentNode(){} // RVA: 0x7AE71BE50
        public void SetupFromParserContext(){} // RVA: 0x7AE71BF60
        public void get_DtdInfo(){} // RVA: 0x7A85ECF50
        public void SetDtdInfo(){} // RVA: 0x7AE71C3A0
        public void set_ValidationEventHandling(){} // RVA: 0x7A8B58850
        public void set_OnDefaultAttributeUse(){} // RVA: 0x7A8B58420
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7AE71C4A0
        public void get_FragmentType(){} // RVA: 0x7A8637490
        public void ChangeCurrentNodeType(){} // RVA: 0x7AE71C590
        public void GetResolver(){} // RVA: 0x7AE71C5B0
        public void set_InternalSchemaType(){} // RVA: 0x7AE71C5D0
        public void get_InternalTypedValue(){} // RVA: 0x7AE71C640
        public void set_InternalTypedValue(){} // RVA: 0x7AE71C670
        public void get_StandAlone(){} // RVA: 0x7A9A9D040
        public void get_NamespaceManager(){} // RVA: 0x7A8850FF0
        public void get_V1Compat(){} // RVA: 0x7AE706660
        public void AddDefaultAttributeDtd(){} // RVA: 0x7AE71C6E0
        public void AddDefaultAttributeNonDtd(){} // RVA: 0x7AE71CAA0
        public void AddDefaultAttributeInternal(){} // RVA: 0x7AE71CE60
        public void set_DisableUndeclaredEntityCheck(){} // RVA: 0x7AE71D1C0
        public void UriEqual(){} // RVA: 0x7AE71D1D0
        public void RegisterConsumedCharacters(){} // RVA: 0x7AE71D2E0
        public void StripSpaces(){} // RVA: 0x7AE71D670
        public void BlockCopyChars(){} // RVA: 0x7ADD5D2A0
        public void BlockCopy(){} // RVA: 0x7AE71D7D0
    }

    public class XmlTextWriter : XmlWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE81A780
        public void get_BaseStream(){} // RVA: 0x7AE81A940
        public void set_Namespaces(){} // RVA: 0x7AE81A9C0
        public void set_Formatting(){} // RVA: 0x7AE81AA40
        public void set_QuoteChar(){} // RVA: 0x7AE81AA50
        public void WriteStartDocument(){} // RVA: 0x7AE81AB00
        public void WriteEndDocument(){} // RVA: 0x7AE81AB20
        public void WriteDocType(){} // RVA: 0x7AE81AD10
        public void WriteStartElement(){} // RVA: 0x7AE81B200
        public void WriteEndElement(){} // RVA: 0x7AE81B790
        public void WriteFullEndElement(){} // RVA: 0x7AE81B7A0
        public void WriteStartAttribute(){} // RVA: 0x7AE81B7B0
        public void WriteEndAttribute(){} // RVA: 0x7AE81BFA0
        public void WriteCData(){} // RVA: 0x7AE81BFF0
        public void WriteComment(){} // RVA: 0x7AE81C330
        public void WriteProcessingInstruction(){} // RVA: 0x7AE81C6A0
        public void WriteEntityRef(){} // RVA: 0x7AE81CAA0
        public void WriteCharEntity(){} // RVA: 0x7AE81CB80
        public void WriteWhitespace(){} // RVA: 0x7AE81CBF0
        public void WriteString(){} // RVA: 0x7AE81CD60
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE81CDE0
        public void WriteChars(){} // RVA: 0x7AE81CE70
        public void WriteRaw(){} // RVA: 0x7AE81CFB0
        public void WriteBase64(){} // RVA: 0x7AE81D020
        public void WriteBinHex(){} // RVA: 0x7AE81D1D0
        public void get_WriteState(){} // RVA: 0x7AE81D260
        public void Close(){} // RVA: 0x7AE81D2D0
        public void Flush(){} // RVA: 0x7AE81D3E0
        public void LookupPrefix(){} // RVA: 0x7AE81D410
        public void StartDocument(){} // RVA: 0x7AE81D550
        public void AutoComplete(){} // RVA: 0x7AE81D980
        public void AutoCompleteAll(){} // RVA: 0x7AE81DFA0
        public void InternalWriteEndElement(){} // RVA: 0x7AE81E000
        public void WriteEndStartTag(){} // RVA: 0x7AE81E420
        public void WriteEndAttributeQuote(){} // RVA: 0x7AE81E880
        public void Indent(){} // RVA: 0x7AE81E900
        public void PushNamespace(){} // RVA: 0x7AE81E9F0
        public void AddNamespace(){} // RVA: 0x7AE81ED30
        public void AddToNamespaceHashtable(){} // RVA: 0x7AE81F0B0
        public void PopNamespaces(){} // RVA: 0x7AE81F1F0
        public void GeneratePrefix(){} // RVA: 0x7AE81F320
        public void InternalWriteProcessingInstruction(){} // RVA: 0x7AE81F560
        public void LookupNamespace(){} // RVA: 0x7AE81F680
        public void LookupNamespaceInCurrentScope(){} // RVA: 0x7AE81F7E0
        public void FindPrefix(){} // RVA: 0x7AE81F9A0
        public void ValidateName(){} // RVA: 0x7AE81FAB0
        public void HandleSpecialAttribute(){} // RVA: 0x7AE81FD30
        public void VerifyPrefixXml(){} // RVA: 0x7AE820060
        public void PushStack(){} // RVA: 0x7AE820160
        public void FlushEncoders(){} // RVA: 0x7AE820390
        public void .cctor(){} // RVA: 0x7AE8203D0
    }

    public class XmlTextWriterBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6D7A90
        public void WriteChars(){} // RVA: 0x7AE6D7B30
    }

    public class XmlUnspecifiedAttribute : XmlAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83C930
        public void get_Specified(){} // RVA: 0x7A84A5BD0
        public void CloneNode(){} // RVA: 0x7AE85DEC0
        public void set_InnerText(){} // RVA: 0x7AE85E010
        public void InsertBefore(){} // RVA: 0x7AE85E090
        public void InsertAfter(){} // RVA: 0x7AE85E120
        public void RemoveChild(){} // RVA: 0x7AE85E1B0
        public void AppendChild(){} // RVA: 0x7AE85E240
        public void WriteTo(){} // RVA: 0x7AE85E2D0
        public void SetSpecified(){} // RVA: 0x7A84A5CD0
    }

    public class XmlUrlResolver : XmlResolver
    {
        // ── Methods ──
        public void get_DownloadManager(){} // RVA: 0x7AE8815B0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetEntity(){} // RVA: 0x7AE8816C0
        public void ResolveUri(){} // RVA: 0x7AE881930
        public void GetEntityAsync(){} // RVA: 0x7AE881940
    }

    public class XmlUtf8RawTextWriter : XmlRawWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE820D90
        public void WriteXmlDeclaration(){} // RVA: 0x7AE821370
        public void WriteDocType(){} // RVA: 0x7AE8213E0
        public void WriteStartElement(){} // RVA: 0x7AE821650
        public void StartElementContent(){} // RVA: 0x7AE821700
        public void WriteEndElement(){} // RVA: 0x7AE821740
        public void WriteFullEndElement(){} // RVA: 0x7AE821890
        public void WriteStartAttribute(){} // RVA: 0x7AE821990
        public void WriteEndAttribute(){} // RVA: 0x7AE821A90
        public void WriteNamespaceDeclaration(){} // RVA: 0x7AE80AC20
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7A81BD750
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7AE821AD0
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7AE821C00
        public void WriteCData(){} // RVA: 0x7AE821C40
        public void WriteComment(){} // RVA: 0x7AE821E30
        public void WriteProcessingInstruction(){} // RVA: 0x7AE821F50
        public void WriteEntityRef(){} // RVA: 0x7AE822070
        public void WriteCharEntity(){} // RVA: 0x7AE822110
        public void WriteWhitespace(){} // RVA: 0x7AE822360
        public void WriteString(){} // RVA: 0x7AE822360
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE8223A0
        public void WriteChars(){} // RVA: 0x7AE6F0790
        public void WriteRaw(){} // RVA: 0x7AE8056D0
        public void Close(){} // RVA: 0x7AE8225D0
        public void Flush(){} // RVA: 0x7AE822720
        public void FlushBuffer(){} // RVA: 0x7AE822770
        public void FlushEncoder(){} // RVA: 0x7A80D7310
        public void WriteAttributeTextBlock(){} // RVA: 0x7AE822AE0
        public void WriteElementTextBlock(){} // RVA: 0x7AE822DA0
        public void RawText(){} // RVA: 0x7AE8230C0
        public void WriteRawWithCharChecking(){} // RVA: 0x7AE823250
        public void WriteCommentOrPi(){} // RVA: 0x7AE8234E0
        public void WriteCDataSection(){} // RVA: 0x7AE8238D0
        public void IsSurrogateByte(){} // RVA: 0x7AE823C80
        public void EncodeSurrogate(){} // RVA: 0x7AE823C90
        public void InvalidXmlChar(){} // RVA: 0x7AE823E40
        public void EncodeChar(){} // RVA: 0x7AE824050
        public void EncodeMultibyteUTF8(){} // RVA: 0x7AE824120
        public void CharToUTF8(){} // RVA: 0x7AE824170
        public void WriteNewLine(){} // RVA: 0x7AE824230
        public void LtEntity(){} // RVA: 0x7AE8242A0
        public void GtEntity(){} // RVA: 0x7AE8242B0
        public void AmpEntity(){} // RVA: 0x7AE8242C0
        public void QuoteEntity(){} // RVA: 0x7AE8242D0
        public void TabEntity(){} // RVA: 0x7AE8242F0
        public void LineFeedEntity(){} // RVA: 0x7AE824300
        public void CarriageReturnEntity(){} // RVA: 0x7AE824310
        public void CharEntity(){} // RVA: 0x7AE824320
        public void RawStartCData(){} // RVA: 0x7AE824460
        public void RawEndCData(){} // RVA: 0x7AE824480
        public void ValidateContentChars(){} // RVA: 0x7AE824490
    }

    public class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE824890
        public void WriteDocType(){} // RVA: 0x7AE824A70
        public void WriteStartElement(){} // RVA: 0x7AE824AE0
        public void StartElementContent(){} // RVA: 0x7AE824C00
        public void OnRootElement(){} // RVA: 0x7ADE0AE80
        public void WriteEndElement(){} // RVA: 0x7AE824C70
        public void WriteFullEndElement(){} // RVA: 0x7AE824D50
        public void WriteStartAttribute(){} // RVA: 0x7AE824ED0
        public void WriteCData(){} // RVA: 0x7AE824FE0
        public void WriteComment(){} // RVA: 0x7AE824FF0
        public void WriteProcessingInstruction(){} // RVA: 0x7AE825030
        public void WriteEntityRef(){} // RVA: 0x7AE825170
        public void WriteCharEntity(){} // RVA: 0x7AE825220
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE825230
        public void WriteWhitespace(){} // RVA: 0x7AE825240
        public void WriteString(){} // RVA: 0x7AE825240
        public void WriteChars(){} // RVA: 0x7AE825290
        public void WriteRaw(){} // RVA: 0x7AE825330
        public void WriteBase64(){} // RVA: 0x7AE825380
        public void Init(){} // RVA: 0x7AE8253A0
        public void WriteIndent(){} // RVA: 0x7AE825580
    }

    public class XmlValidatingReader : XmlReader
    {
        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7A858ABB0
        public void get_LocalName(){} // RVA: 0x7A856A750
        public void get_NamespaceURI(){} // RVA: 0x7ADB00ED0
        public void get_Prefix(){} // RVA: 0x7ADB00F00
        public void get_Value(){} // RVA: 0x7A972BF20
        public void get_Depth(){} // RVA: 0x7AE3C9490
        public void get_BaseURI(){} // RVA: 0x7A858ABE0
        public void get_IsEmptyElement(){} // RVA: 0x7A858AB50
        public void get_AttributeCount(){} // RVA: 0x7AE1E3E00
        public void GetAttribute(){} // RVA: 0x7AE562100
        public void MoveToAttribute(){} // RVA: 0x7AE562130
        public void MoveToFirstAttribute(){} // RVA: 0x7ADB010B0
        public void MoveToNextAttribute(){} // RVA: 0x7ADBF0670
        public void MoveToElement(){} // RVA: 0x7A8555880
        public void ReadAttributeValue(){} // RVA: 0x7ADE58970
        public void Read(){} // RVA: 0x7AE562190
        public void get_EOF(){} // RVA: 0x7AE5621C0
        public void get_ReadState(){} // RVA: 0x7AE5621F0
        public void get_NameTable(){} // RVA: 0x7ADE584C0
        public void LookupNamespace(){} // RVA: 0x7AE817680
        public void ResolveEntity(){} // RVA: 0x7AE562280
        public void get_Namespaces(){} // RVA: 0x7AE825600
    }

    public class XmlValidatingReaderImpl : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE825630
        public void get_Settings(){} // RVA: 0x7AE825DE0
        public void get_NodeType(){} // RVA: 0x7A858ABB0
        public void get_Name(){} // RVA: 0x7ADE59240
        public void get_LocalName(){} // RVA: 0x7A856A750
        public void get_NamespaceURI(){} // RVA: 0x7ADB00ED0
        public void get_Prefix(){} // RVA: 0x7ADB00F00
        public void get_Value(){} // RVA: 0x7A972BF20
        public void get_Depth(){} // RVA: 0x7AE3C9490
        public void get_BaseURI(){} // RVA: 0x7A858ABE0
        public void get_IsEmptyElement(){} // RVA: 0x7A858AB50
        public void get_IsDefault(){} // RVA: 0x7A858AA50
        public void get_QuoteChar(){} // RVA: 0x7A858AB80
        public void get_XmlSpace(){} // RVA: 0x7A858AA20
        public void get_XmlLang(){} // RVA: 0x7A858AC40
        public void get_ReadState(){} // RVA: 0x7AE825EF0
        public void get_EOF(){} // RVA: 0x7AE5621C0
        public void get_NameTable(){} // RVA: 0x7ADE584C0
        public void get_AttributeCount(){} // RVA: 0x7AE1E3E00
        public void GetAttribute(){} // RVA: 0x7AE562100
        public void MoveToAttribute(){} // RVA: 0x7AE825F80
        public void MoveToFirstAttribute(){} // RVA: 0x7AE825FC0
        public void MoveToNextAttribute(){} // RVA: 0x7AE826010
        public void MoveToElement(){} // RVA: 0x7AE826060
        public void Read(){} // RVA: 0x7AE8260B0
        public void Close(){} // RVA: 0x7AE826380
        public void LookupNamespace(){} // RVA: 0x7AE8263C0
        public void ReadAttributeValue(){} // RVA: 0x7AE8263F0
        public void get_CanResolveEntity(){} // RVA: 0x7A81BD750
        public void ResolveEntity(){} // RVA: 0x7AE826460
        public void MoveOffEntityReference(){} // RVA: 0x7AE8264A0
        public void ReadString(){} // RVA: 0x7AE826560
        public void HasLineInfo(){} // RVA: 0x7A81BD750
        public void get_LineNumber(){} // RVA: 0x7AE826630
        public void get_LinePosition(){} // RVA: 0x7AE8266D0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE826770
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE4A5120
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE8267D0
        public void GetNamespacesInScope(){} // RVA: 0x7AE826770
        public void LookupPrefix(){} // RVA: 0x7AE8267D0
        public void get_ValidationType(){} // RVA: 0x7A854FDE0
        public void get_Schemas(){} // RVA: 0x7A8292C30
        public void get_Namespaces(){} // RVA: 0x7AE826830
        public void ParseDtdFromParserContext(){} // RVA: 0x7AE826850
        public void ValidateDtd(){} // RVA: 0x7AE8269A0
        public void ResolveEntityInternally(){} // RVA: 0x7AE826B30
        public void SetupValidation(){} // RVA: 0x7AE826BE0
        public void GetResolver(){} // RVA: 0x7AE826EF0
        public void ProcessCoreReaderEvent(){} // RVA: 0x7AE826FE0
        public void get_Validator(){} // RVA: 0x7A83F69F0
        public void set_Validator(){} // RVA: 0x7A8105A90
        public void get_NamespaceManager(){} // RVA: 0x7AE827100
        public void get_StandAlone(){} // RVA: 0x7AE827130
        public void set_SchemaTypeObject(){} // RVA: 0x7AE827150
        public void get_TypedValueObject(){} // RVA: 0x7AE827170
        public void set_TypedValueObject(){} // RVA: 0x7AE8271A0
        public void AddDefaultAttribute(){} // RVA: 0x7AE8271C0
        public void get_DtdInfo(){} // RVA: 0x7AE8271E0
        public void ValidateDefaultAttributeOnUse(){} // RVA: 0x7AE827210
    }

    public class XmlWellFormedWriter : XmlWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE827580
        public void get_WriteState(){} // RVA: 0x7AE827D70
        public void WriteStartDocument(){} // RVA: 0x7AE827E10
        public void WriteEndDocument(){} // RVA: 0x7AE827E40
        public void WriteDocType(){} // RVA: 0x7AE827F50
        public void WriteStartElement(){} // RVA: 0x7AE8284D0
        public void WriteEndElement(){} // RVA: 0x7AE828850
        public void WriteFullEndElement(){} // RVA: 0x7AE828A20
        public void WriteStartAttribute(){} // RVA: 0x7AE828BF0
        public void WriteEndAttribute(){} // RVA: 0x7AE8294E0
        public void WriteCData(){} // RVA: 0x7AE82A7E0
        public void WriteComment(){} // RVA: 0x7AE82A8A0
        public void WriteProcessingInstruction(){} // RVA: 0x7AE82A960
        public void WriteEntityRef(){} // RVA: 0x7AE82AC50
        public void WriteCharEntity(){} // RVA: 0x7AE82AD60
        public void WriteSurrogateCharEntity(){} // RVA: 0x7AE82AF20
        public void WriteWhitespace(){} // RVA: 0x7AE82B130
        public void WriteString(){} // RVA: 0x7AE82B310
        public void WriteChars(){} // RVA: 0x7AE82B450
        public void WriteRaw(){} // RVA: 0x7AE82BA10
        public void WriteBase64(){} // RVA: 0x7AE82BAF0
        public void Close(){} // RVA: 0x7AE82BCD0
        public void Flush(){} // RVA: 0x7AE82C320
        public void LookupPrefix(){} // RVA: 0x7AE82C380
        public void WriteValue(){} // RVA: 0x7AE82C580
        public void WriteBinHex(){} // RVA: 0x7AE82C670
        public void get_RawWriter(){} // RVA: 0x7A81052C0
        public void get_SaveAttrValue(){} // RVA: 0x7AE73AFC0
        public void get_InBase64(){} // RVA: 0x7AE82C760
        public void SetSpecialAttribute(){} // RVA: 0x7AE82C780
        public void WriteStartDocumentImpl(){} // RVA: 0x7AE82C900
        public void StartFragment(){} // RVA: 0x7AE82CAE0
        public void PushNamespaceImplicit(){} // RVA: 0x7AE82CAF0
        public void PushNamespaceExplicit(){} // RVA: 0x7AE82D110
        public void AddNamespace(){} // RVA: 0x7AE82D820
        public void AddToNamespaceHashtable(){} // RVA: 0x7AE82DB60
        public void LookupNamespaceIndex(){} // RVA: 0x7AE82DC90
        public void PopNamespaces(){} // RVA: 0x7AE82DDE0
        public void DupAttrException(){} // RVA: 0x7AE82DF10
        public void AdvanceState(){} // RVA: 0x7AE82E020
        public void StartElementContent(){} // RVA: 0x7AE82E450
        public void GetStateName(){} // RVA: 0x7AE82E540
        public void LookupNamespace(){} // RVA: 0x7AE82E5E0
        public void LookupLocalNamespace(){} // RVA: 0x7AE82E6F0
        public void GeneratePrefix(){} // RVA: 0x7AE82E800
        public void CheckNCName(){} // RVA: 0x7AE82EAD0
        public void InvalidCharsException(){} // RVA: 0x7AE82EC00
        public void ThrowInvalidStateTransition(){} // RVA: 0x7AE82ED70
        public void get_IsClosedOrErrorState(){} // RVA: 0x7AE82EF70
        public void AddAttribute(){} // RVA: 0x7AE82EF80
        public void AddToAttrHashTable(){} // RVA: 0x7AE82F510
        public void .cctor(){} // RVA: 0x7AE82F6B0
    }

    public class XmlWhitespace : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE85E3B0
        public void get_Name(){} // RVA: 0x7AE85E4B0
        public void get_LocalName(){} // RVA: 0x7AE85E4B0
        public void get_NodeType(){} // RVA: 0x7A8F279F0
        public void get_ParentNode(){} // RVA: 0x7AE85DAE0
        public void get_Value(){} // RVA: 0x7ADCAB740
        public void set_Value(){} // RVA: 0x7AE85E4E0
        public void CloneNode(){} // RVA: 0x7AE85E5E0
        public void WriteTo(){} // RVA: 0x7AE85E650
        public void WriteContentTo(){} // RVA: 0x7A80D7310
        public void get_IsText(){} // RVA: 0x7A81BD750
    }

    public class XmlWriter : Object
    {
        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7A7E18C30
        public void WriteEndDocument(){} // RVA: 0x7A7E18770
        public void WriteDocType(){} // RVA: 0x7A7E1DB70
        public void WriteStartElement(){} // RVA: 0x7A7E1DDC0
        public void WriteEndElement(){} // RVA: 0x7A7E18770
        public void WriteFullEndElement(){} // RVA: 0x7A7E18770
        public void WriteAttributeString(){} // RVA: 0x7AE831E70
        public void WriteStartAttribute(){} // RVA: 0x7A7E1DDC0
        public void WriteEndAttribute(){} // RVA: 0x7A7E18770
        public void WriteCData(){} // RVA: 0x7A7E18800
        public void WriteComment(){} // RVA: 0x7A7E18800
        public void WriteProcessingInstruction(){} // RVA: 0x7A7E18890
        public void WriteEntityRef(){} // RVA: 0x7A7E18800
        public void WriteCharEntity(){} // RVA: 0x7A7E18950
        public void WriteWhitespace(){} // RVA: 0x7A7E18800
        public void WriteString(){} // RVA: 0x7A7E18800
        public void WriteSurrogateCharEntity(){} // RVA: 0x7A7E26DB0
        public void WriteChars(){} // RVA: 0x7A7E1E220
        public void WriteRaw(){} // RVA: 0x7A7E18800
        public void WriteBase64(){} // RVA: 0x7A7E1E220
        public void WriteBinHex(){} // RVA: 0x7AE831ED0
        public void get_WriteState(){} // RVA: 0x7A7E00710
        public void Close(){} // RVA: 0x7A80D7310
        public void Flush(){} // RVA: 0x7A7E18770
        public void LookupPrefix(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7AE831F00
        public void WriteAttributes(){} // RVA: 0x7AE831F20
        public void WriteNode(){} // RVA: 0x7AE832290
        public void WriteElementString(){} // RVA: 0x7AE832870
        public void Dispose(){} // RVA: 0x7AE832910
        public void Create(){} // RVA: 0x7AE8329D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XmlWriterSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE832A50
        public void get_Async(){} // RVA: 0x7A81A2200
        public void get_Encoding(){} // RVA: 0x7A80DA7B0
        public void get_OmitXmlDeclaration(){} // RVA: 0x7A81C68D0
        public void set_OmitXmlDeclaration(){} // RVA: 0x7AE832B20
        public void get_NewLineHandling(){} // RVA: 0x7A8AB15F0
        public void get_NewLineChars(){} // RVA: 0x7A8105330
        public void get_Indent(){} // RVA: 0x7AE1B2EC0
        public void set_Indent(){} // RVA: 0x7AE832B80
        public void get_IndentChars(){} // RVA: 0x7A8292C30
        public void get_NewLineOnAttributes(){} // RVA: 0x7A8193790
        public void get_CloseOutput(){} // RVA: 0x7A83F3AD0
        public void get_ConformanceLevel(){} // RVA: 0x7A8178B70
        public void set_ConformanceLevel(){} // RVA: 0x7AE832BE0
        public void get_CheckCharacters(){} // RVA: 0x7A9471CE0
        public void get_NamespaceHandling(){} // RVA: 0x7A8178B50
        public void set_NamespaceHandling(){} // RVA: 0x7AE832C80
        public void get_WriteEndDocumentOnClose(){} // RVA: 0x7AE832D20
        public void get_OutputMethod(){} // RVA: 0x7A8355950
        public void set_OutputMethod(){} // RVA: 0x7A83F4180
        public void Clone(){} // RVA: 0x7AE832D30
        public void get_CDataSectionElements(){} // RVA: 0x7A81A0050
        public void get_DoNotEscapeUriAttributes(){} // RVA: 0x7A8100260
        public void get_MergeCDataSections(){} // RVA: 0x7A8F1FD00
        public void get_MediaType(){} // RVA: 0x7A8153390
        public void get_DocTypeSystem(){} // RVA: 0x7A81A00E0
        public void get_DocTypePublic(){} // RVA: 0x7A82C2060
        public void get_Standalone(){} // RVA: 0x7A8D6DF30
        public void get_AutoXmlDeclaration(){} // RVA: 0x7A81B7B30
        public void get_IndentInternal(){} // RVA: 0x7A8133100
        public void get_IsQuerySpecific(){} // RVA: 0x7AE832E50
        public void CreateWriter(){} // RVA: 0x7AE8334B0
        public void set_ReadOnly(){} // RVA: 0x7AE165890
        public void CheckReadOnly(){} // RVA: 0x7AE8338B0
        public void Initialize(){} // RVA: 0x7AE833960
    }

    public class XsdCachingReader : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE833C30
        public void Init(){} // RVA: 0x7AE833E70
        public void Reset(){} // RVA: 0x7AE834110
        public void get_Settings(){} // RVA: 0x7A858AB20
        public void get_NodeType(){} // RVA: 0x7AE834170
        public void get_Name(){} // RVA: 0x7AE834190
        public void get_LocalName(){} // RVA: 0x7AE8341C0
        public void get_NamespaceURI(){} // RVA: 0x7A87E1E40
        public void get_Prefix(){} // RVA: 0x7AE8341E0
        public void get_Value(){} // RVA: 0x7AE834200
        public void get_Depth(){} // RVA: 0x7AE834230
        public void get_BaseURI(){} // RVA: 0x7A858ABE0
        public void get_IsEmptyElement(){} // RVA: 0x7A80D7320
        public void get_IsDefault(){} // RVA: 0x7A80D7320
        public void get_QuoteChar(){} // RVA: 0x7A858AB80
        public void get_XmlSpace(){} // RVA: 0x7A858AA20
        public void get_XmlLang(){} // RVA: 0x7A858AC40
        public void get_AttributeCount(){} // RVA: 0x7A8178B30
        public void GetAttribute(){} // RVA: 0x7AE834480
        public void MoveToAttribute(){} // RVA: 0x7AE834670
        public void MoveToFirstAttribute(){} // RVA: 0x7AE834760
        public void MoveToNextAttribute(){} // RVA: 0x7AE8347F0
        public void MoveToElement(){} // RVA: 0x7AE834890
        public void Read(){} // RVA: 0x7AE8348E0
        public void RecordTextNode(){} // RVA: 0x7AE834CA0
        public void SwitchTextNodeAndEndElement(){} // RVA: 0x7AE834D20
        public void RecordEndElementNode(){} // RVA: 0x7AE834E70
        public void get_EOF(){} // RVA: 0x7AE835020
        public void Close(){} // RVA: 0x7AE835060
        public void get_ReadState(){} // RVA: 0x7AE5621F0
        public void Skip(){} // RVA: 0x7AE8350A0
        public void get_NameTable(){} // RVA: 0x7A80DA7B0
        public void LookupNamespace(){} // RVA: 0x7AE562220
        public void ResolveEntity(){} // RVA: 0x7AE8351E0
        public void ReadAttributeValue(){} // RVA: 0x7AE835220
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7A81BD750
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7AE8353E0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7AE835400
        public void SetToReplayMode(){} // RVA: 0x7AE835420
        public void GetCoreReader(){} // RVA: 0x7A80F2570
        public void GetLineInfo(){} // RVA: 0x7A8175DF0
        public void ClearAttributesInfo(){} // RVA: 0x7AE835450
        public void AddAttribute(){} // RVA: 0x7AE835460
        public void AddContent(){} // RVA: 0x7AE835640
        public void RecordAttributes(){} // RVA: 0x7AE835810
        public void GetAttributeIndexWithoutPrefix(){} // RVA: 0x7AE835A80
        public void GetAttributeIndexWithPrefix(){} // RVA: 0x7AE835B20
        public void CreateDummyTextNode(){} // RVA: 0x7AE835BD0
    }

    public class XsdValidatingReader : XmlReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8363A0
        public void Init(){} // RVA: 0x7AE8363C0
        public void SetupValidator(){} // RVA: 0x7AE836BC0
        public void get_Settings(){} // RVA: 0x7AE8372D0
        public void get_NodeType(){} // RVA: 0x7AE837460
        public void get_Name(){} // RVA: 0x7AE837530
        public void get_LocalName(){} // RVA: 0x7AE837660
        public void get_NamespaceURI(){} // RVA: 0x7AE8376B0
        public void get_Prefix(){} // RVA: 0x7AE837700
        public void get_Value(){} // RVA: 0x7AE837750
        public void get_Depth(){} // RVA: 0x7AE8377A0
        public void get_BaseURI(){} // RVA: 0x7A858ABE0
        public void get_IsEmptyElement(){} // RVA: 0x7A858AB50
        public void get_IsDefault(){} // RVA: 0x7AE8377F0
        public void get_QuoteChar(){} // RVA: 0x7A858AB80
        public void get_XmlSpace(){} // RVA: 0x7A858AA20
        public void get_XmlLang(){} // RVA: 0x7A858AC40
        public void get_SchemaInfo(){} // RVA: 0x7A97F8BA0
        public void get_ValueType(){} // RVA: 0x7AE837830
        public void get_AttributeCount(){} // RVA: 0x7A8EA8210
        public void GetAttribute(){} // RVA: 0x7AE837AC0
        public void MoveToAttribute(){} // RVA: 0x7AE837CD0
        public void MoveToFirstAttribute(){} // RVA: 0x7AE837EF0
        public void MoveToNextAttribute(){} // RVA: 0x7AE838210
        public void MoveToElement(){} // RVA: 0x7AE838520
        public void Read(){} // RVA: 0x7AE838580
        public void get_EOF(){} // RVA: 0x7AE5621C0
        public void Close(){} // RVA: 0x7AE838860
        public void get_ReadState(){} // RVA: 0x7AE8388A0
        public void Skip(){} // RVA: 0x7AE8388E0
        public void get_NameTable(){} // RVA: 0x7A8142610
        public void LookupNamespace(){} // RVA: 0x7AE838A90
        public void ResolveEntity(){} // RVA: 0x7AE838AF0
        public void ReadAttributeValue(){} // RVA: 0x7AE838B30
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x7AE838D70
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x7AE838E00
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x7AE838E50
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x7AE838F00
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x7AE8390E0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x7AE839140
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x7AE8391A0
        public void HasLineInfo(){} // RVA: 0x7A81BD750
        public void get_LineNumber(){} // RVA: 0x7AE8391F0
        public void get_LinePosition(){} // RVA: 0x7AE839250
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7AE8392B0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7AE839340
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7AE8393D0
        public void GetStringValue(){} // RVA: 0x7A972BF20
        public void get_AttributeSchemaInfo(){} // RVA: 0x7AE839460
        public void ProcessReaderEvent(){} // RVA: 0x7AE839480
        public void ProcessElementEvent(){} // RVA: 0x7AE839740
        public void ProcessEndElementEvent(){} // RVA: 0x7AE839E90
        public void ValidateAttributes(){} // RVA: 0x7AE83A160
        public void ClearAttributesInfo(){} // RVA: 0x7AE83A4C0
        public void GetAttributePSVI(){} // RVA: 0x7AE83A710
        public void GetDefaultAttribute(){} // RVA: 0x7AE83A900
        public void AddAttributePSVI(){} // RVA: 0x7AE83AA50
        public void IsXSDRoot(){} // RVA: 0x7AE83AC90
        public void ProcessInlineSchema(){} // RVA: 0x7AE83ACB0
        public void ReadAheadForMemberType(){} // RVA: 0x7AE83ADF0
        public void GetIsDefault(){} // RVA: 0x7AE83B130
        public void GetMemberType(){} // RVA: 0x7AE83B5B0
        public void GetCachingReader(){} // RVA: 0x7AE83B6F0
        public void CreateDummyTextNode(){} // RVA: 0x7AE83B8F0
        public void CachingCallBack(){} // RVA: 0x7AE83BA50
        public void GetOriginalAtomicValueStringOfElement(){} // RVA: 0x7AE83BB30
    }

}