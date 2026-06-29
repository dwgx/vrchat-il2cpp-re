// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 74
// Methods: 2011

namespace ThirdParty.DotNet.System.Xml
{
    public class XmlAsyncCheckReader : XmlReader
    {
        public object coreReader;
        public object lastTask;

        // ── Methods ──
        public void get_CoreReader(){} // RVA: 0xB5DBF0
        public void CreateAsyncCheckWrapper(){} // RVA: 0x747B510
        public void .ctor(){} // RVA: 0x747B8B0
        public void CheckAsync(){} // RVA: 0x747B9F0
        public void get_Settings(){} // RVA: 0x747BAC0
        public void get_NodeType(){} // RVA: 0x747BB90
        public void get_Name(){} // RVA: 0x747BBD0
        public void get_LocalName(){} // RVA: 0x747BC10
        public void get_NamespaceURI(){} // RVA: 0x747BC50
        public void get_Prefix(){} // RVA: 0x747BC90
        public void get_Value(){} // RVA: 0x747BCD0
        public void get_Depth(){} // RVA: 0x747BD10
        public void get_BaseURI(){} // RVA: 0x747BD50
        public void get_IsEmptyElement(){} // RVA: 0x747BD90
        public void get_IsDefault(){} // RVA: 0x747BDD0
        public void get_QuoteChar(){} // RVA: 0x747BE10
        public void get_XmlSpace(){} // RVA: 0x747BE50
        public void get_XmlLang(){} // RVA: 0x747BE90
        public void get_SchemaInfo(){} // RVA: 0x747BED0
        public void get_ValueType(){} // RVA: 0x747BF10
        public void get_AttributeCount(){} // RVA: 0x747BF50
        public void GetAttribute(){} // RVA: 0x747C040
        public void MoveToAttribute(){} // RVA: 0x747C0E0
        public void MoveToFirstAttribute(){} // RVA: 0x747C130
        public void MoveToNextAttribute(){} // RVA: 0x747C170
        public void MoveToElement(){} // RVA: 0x747C1B0
        public void ReadAttributeValue(){} // RVA: 0x747C1F0
        public void Read(){} // RVA: 0x747C230
        public void get_EOF(){} // RVA: 0x747C270
        public void Close(){} // RVA: 0x747C2B0
        public void get_ReadState(){} // RVA: 0x747C2F0
        public void Skip(){} // RVA: 0x747C330
        public void get_NameTable(){} // RVA: 0x747C370
        public void LookupNamespace(){} // RVA: 0x747C3B0
        public void get_CanResolveEntity(){} // RVA: 0x747C400
        public void ResolveEntity(){} // RVA: 0x747C440
        public void get_CanReadValueChunk(){} // RVA: 0x747C480
        public void ReadValueChunk(){} // RVA: 0x747C4C0
        public void ReadString(){} // RVA: 0x747C530
        public void MoveToContent(){} // RVA: 0x747C570
        public void ReadStartElement(){} // RVA: 0x747C5B0
        public void ReadElementString(){} // RVA: 0x747C5F0
        public void ReadEndElement(){} // RVA: 0x747C630
        public void IsStartElement(){} // RVA: 0x747C670
        public void ReadInnerXml(){} // RVA: 0x747C6D0
        public void get_HasAttributes(){} // RVA: 0x747C710
        public void Dispose(){} // RVA: 0x747C750
        public void get_NamespaceManager(){} // RVA: 0x747C790
        public void get_DtdInfo(){} // RVA: 0x747C7D0
    }

    public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader
    {
        public object readerAsIXmlLineInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747CA30
        public void HasLineInfo(){} // RVA: 0x747CB30
        public void get_LineNumber(){} // RVA: 0x747CB80
        public void get_LinePosition(){} // RVA: 0x747CBD0
    }

    public class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo
    {
        public object readerAsIXmlNamespaceResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747CC20
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x747CD20
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x747CD80
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x747CDE0
    }

    public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS
    {
        public object readerAsIXmlSchemaInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747CE40
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x747CF40
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x747CF90
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x747CFE0
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x747D030
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x747D080
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x747D0D0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x747D120
    }

    public class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader
    {
        public object readerAsIXmlNamespaceResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747C810
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x747C910
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x747C970
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x747C9D0
    }

    public class XmlAsyncCheckWriter : XmlWriter
    {
        public object coreWriter;
        public object lastTask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747D170
        public void CheckAsync(){} // RVA: 0x747D290
        public void WriteStartDocument(){} // RVA: 0x747D3A0
        public void WriteEndDocument(){} // RVA: 0x747D3F0
        public void WriteDocType(){} // RVA: 0x747D430
        public void WriteStartElement(){} // RVA: 0x747D4A0
        public void WriteEndElement(){} // RVA: 0x747D510
        public void WriteFullEndElement(){} // RVA: 0x747D550
        public void WriteStartAttribute(){} // RVA: 0x747D590
        public void WriteEndAttribute(){} // RVA: 0x747D600
        public void WriteCData(){} // RVA: 0x747D640
        public void WriteComment(){} // RVA: 0x747D690
        public void WriteProcessingInstruction(){} // RVA: 0x747D6E0
        public void WriteEntityRef(){} // RVA: 0x747D740
        public void WriteCharEntity(){} // RVA: 0x747D790
        public void WriteWhitespace(){} // RVA: 0x747D7E0
        public void WriteString(){} // RVA: 0x747D830
        public void WriteSurrogateCharEntity(){} // RVA: 0x747D880
        public void WriteChars(){} // RVA: 0x747D8E0
        public void WriteRaw(){} // RVA: 0x747D9C0
        public void WriteBase64(){} // RVA: 0x747DA10
        public void WriteBinHex(){} // RVA: 0x747DA80
        public void get_WriteState(){} // RVA: 0x747DAF0
        public void Close(){} // RVA: 0x747DB30
        public void Flush(){} // RVA: 0x747DB70
        public void LookupPrefix(){} // RVA: 0x747DBB0
        public void WriteValue(){} // RVA: 0x747DC00
        public void WriteAttributes(){} // RVA: 0x747DC50
        public void WriteNode(){} // RVA: 0x747DCB0
        public void Dispose(){} // RVA: 0x747DD10
    }

    public class XmlAttribute : XmlNode
    {
        public object name;
        public object lastChild;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B18C0
        public void get_LocalNameHash(){} // RVA: 0x74B18A0
        public void get_XmlName(){} // RVA: 0xB465B0
        public void set_XmlName(){} // RVA: 0xBA9BA0
        public void CloneNode(){} // RVA: 0x74B1910
        public void get_ParentNode(){} // RVA: 0xDAC980
        public void get_Name(){} // RVA: 0x74B1A00
        public void get_LocalName(){} // RVA: 0x6AE0A90
        public void get_NamespaceURI(){} // RVA: 0x2547880
        public void get_Prefix(){} // RVA: 0x1853320
        public void set_Prefix(){} // RVA: 0x74B1A20
        public void get_NodeType(){} // RVA: 0xC50A80
        public void get_OwnerDocument(){} // RVA: 0x6AE0BB0
        public void get_Value(){} // RVA: 0x74B1B30
        public void set_Value(){} // RVA: 0x74B1B50
        public void get_SchemaInfo(){} // RVA: 0xB465B0
        public void set_InnerText(){} // RVA: 0x74B1B70
        public void PrepareOwnerElementInElementIdAttrMap(){} // RVA: 0x74B1BE0
        public void ResetOwnerElementInElementIdAttrMap(){} // RVA: 0x74B1DD0
        public void get_IsContainer(){} // RVA: 0xC2E4C0
        public void AppendChildForLoad(){} // RVA: 0x74B1F10
        public void get_LastNode(){} // RVA: 0xB700F0
        public void set_LastNode(){} // RVA: 0xB70100
        public void IsValidChildType(){} // RVA: 0x74B22D0
        public void get_Specified(){} // RVA: 0xC2E4C0
        public void InsertBefore(){} // RVA: 0x74B22E0
        public void InsertAfter(){} // RVA: 0x74B2380
        public void RemoveChild(){} // RVA: 0x74B2420
        public void PrependChild(){} // RVA: 0x74B24A0
        public void AppendChild(){} // RVA: 0x74B2570
        public void get_OwnerElement(){} // RVA: 0x74B25F0
        public void set_InnerXml(){} // RVA: 0x74B2670
        public void WriteTo(){} // RVA: 0x74B2700
        public void WriteContentTo(){} // RVA: 0x74B27E0
        public void get_BaseURI(){} // RVA: 0x74B2860
        public void SetParent(){} // RVA: 0xB44D60
        public void get_XmlSpace(){} // RVA: 0x74B28E0
        public void get_XmlLang(){} // RVA: 0x74B2950
    }

    public class XmlAttributeCollection : XmlNamedNodeMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ItemOf(){} // RVA: 0x74B2C80
        public void FindNodeOffsetNS(){} // RVA: 0x74B2E80
        public void SetNamedItem(){} // RVA: 0x74B3070
        public void Append(){} // RVA: 0x74B3210
        public void Remove(){} // RVA: 0x74B3460
        public void RemoveAt(){} // RVA: 0x74B3500
        public void RemoveAll(){} // RVA: 0x74B35C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x74B36A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x74B3730
        public void AddNode(){} // RVA: 0x74B3740
        public void InsertNodeAt(){} // RVA: 0x74B3940
        public void RemoveNodeAt(){} // RVA: 0x74B39F0
        public void Detach(){} // RVA: 0x74B3BD0
        public void InsertParentIntoElementIdAttrMap(){} // RVA: 0x74B3CB0
        public void RemoveParentFromElementIdAttrMap(){} // RVA: 0x74B3EA0
        public void RemoveDuplicateAttribute(){} // RVA: 0x74B4090
        public void PrepareParentInElementIdAttrMap(){} // RVA: 0x74B41A0
        public void ResetParentInElementIdAttrMap(){} // RVA: 0x74B4300
        public void InternalAppendAttribute(){} // RVA: 0x74B43E0
    }

    public class XmlAutoDetectWriter : XmlRawWriter
    {
        public object wrapped;
        public object onRemove;
        public object writerSettings;
        public object eventCache;
        public object textWriter;
        public object strm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747E080
        public void WriteDocType(){} // RVA: 0x747E100
        public void WriteStartElement(){} // RVA: 0x747E180
        public void WriteStartAttribute(){} // RVA: 0x747E260
        public void WriteEndAttribute(){} // RVA: 0x70F9400
        public void WriteCData(){} // RVA: 0x747E2E0
        public void WriteComment(){} // RVA: 0x747E340
        public void WriteProcessingInstruction(){} // RVA: 0x747E380
        public void WriteWhitespace(){} // RVA: 0x747E3C0
        public void WriteString(){} // RVA: 0x747E400
        public void WriteChars(){} // RVA: 0x1D55C90
        public void WriteRaw(){} // RVA: 0x747E4B0
        public void WriteEntityRef(){} // RVA: 0x747E510
        public void WriteCharEntity(){} // RVA: 0x747E570
        public void WriteSurrogateCharEntity(){} // RVA: 0x747E5D0
        public void WriteBase64(){} // RVA: 0x747E640
        public void WriteBinHex(){} // RVA: 0x747E6C0
        public void Close(){} // RVA: 0x747E740
        public void Flush(){} // RVA: 0x747E790
        public void WriteValue(){} // RVA: 0x747E7E0
        public void set_NamespaceResolver(){} // RVA: 0x747E840
        public void WriteXmlDeclaration(){} // RVA: 0x747E920
        public void StartElementContent(){} // RVA: 0x7479A60
        public void WriteEndElement(){} // RVA: 0x747E980
        public void WriteFullEndElement(){} // RVA: 0x747E9B0
        public void WriteNamespaceDeclaration(){} // RVA: 0x747E9E0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7479B30
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x747EA50
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7479B90
        public void IsHtmlTag(){} // RVA: 0x747EAB0
        public void EnsureWrappedWriter(){} // RVA: 0x747EB10
        public void TextBlockCreatesWriter(){} // RVA: 0x747EB20
        public void CreateWrappedWriter(){} // RVA: 0x747EBD0
    }

    public class XmlCDataSection : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B44A0
        public void get_Name(){} // RVA: 0x74B44B0
        public void get_LocalName(){} // RVA: 0x74B44B0
        public void get_NodeType(){} // RVA: 0x1347420
        public void get_ParentNode(){} // RVA: 0x74B44E0
        public void CloneNode(){} // RVA: 0x74B4580
        public void WriteTo(){} // RVA: 0x74B45F0
        public void WriteContentTo(){} // RVA: 0xB43310
        public void get_IsText(){} // RVA: 0xC2E4C0
    }

    public class XmlCachedStream : MemoryStream
    {
        public object uri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74EEF40
    }

    public class XmlCharType : ValueType
    {
        public object s_Lock;
        public object s_CharProperties;
        public object charProperties;

        // ── Methods ──
        public void get_StaticLock(){} // RVA: 0x74E2500
        public void InitInstance(){} // RVA: 0x74E25D0
        public void SetProperties(){} // RVA: 0x74E2E10
        public void .ctor(){} // RVA: 0x47F10
        public void get_Instance(){} // RVA: 0x74E2EE0
        public void IsWhiteSpace(){} // RVA: 0x916E00
        public void IsNCNameSingleChar(){} // RVA: 0x916E40
        public void IsStartNCNameSingleChar(){} // RVA: 0x916E80
        public void IsNameSingleChar(){} // RVA: 0x916EC0
        public void IsCharData(){} // RVA: 0x916F00
        public void IsPubidChar(){} // RVA: 0x916F40
        public void IsTextChar(){} // RVA: 0x916F50
        public void IsLetter(){} // RVA: 0x916F90
        public void IsNCNameCharXml4e(){} // RVA: 0x916FD0
        public void IsStartNCNameCharXml4e(){} // RVA: 0x917010
        public void IsNameCharXml4e(){} // RVA: 0x917050
        public void IsDigit(){} // RVA: 0x68FD610
        public void IsHighSurrogate(){} // RVA: 0x74E32B0
        public void IsLowSurrogate(){} // RVA: 0x74E32C0
        public void IsSurrogate(){} // RVA: 0x6D59050
        public void CombineSurrogateChar(){} // RVA: 0x74E32D0
        public void SplitSurrogateChar(){} // RVA: 0x74E32F0
        public void IsOnlyWhitespace(){} // RVA: 0x917090
        public void IsOnlyWhitespaceWithPos(){} // RVA: 0x917110
        public void IsOnlyCharData(){} // RVA: 0x917190
        public void IsOnlyDigits(){} // RVA: 0x74E3520
        public void IsPublicId(){} // RVA: 0x9171A0
        public void InRange(){} // RVA: 0x66C9800
    }

    public class XmlCharacterData : XmlLinkedNode
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B4640
        public void get_Value(){} // RVA: 0x69358F0
        public void set_Value(){} // RVA: 0x74B46C0
        public void get_InnerText(){} // RVA: 0x254FA90
        public void set_InnerText(){} // RVA: 0x4B52F00
        public void get_Data(){} // RVA: 0x74B46E0
        public void set_Data(){} // RVA: 0x74B4700
        public void CheckOnData(){} // RVA: 0x74B4810
    }

    public class XmlChildEnumerator : Object
    {
        public object container;
        public object child;
        public object isFirst;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B4890
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x74B4980
        public void MoveNext(){} // RVA: 0x74B4980
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x74B4AB0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x74B4B30
        public void get_Current(){} // RVA: 0x74B4B30
    }

    public class XmlChildNodes : XmlNodeList
    {
        public object container;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Item(){} // RVA: 0x74B4BC0
        public void get_Count(){} // RVA: 0x74B4C30
        public void GetEnumerator(){} // RVA: 0x74B4C90
    }

    public class XmlComment : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B44A0
        public void get_Name(){} // RVA: 0x74B4D60
        public void get_LocalName(){} // RVA: 0x74B4D60
        public void get_NodeType(){} // RVA: 0x17FCE50
        public void CloneNode(){} // RVA: 0x74B4D90
        public void WriteTo(){} // RVA: 0x74B4E00
        public void WriteContentTo(){} // RVA: 0xB43310
    }

    public class XmlComplianceUtil : Object
    {
        // ── Methods ──
        public void NonCDataNormalize(){} // RVA: 0x74E3600
        public void CDataNormalize(){} // RVA: 0x74E38B0
    }

    public class XmlConvert : Object
    {
        public object xmlCharType;
        public object crt;
        public object c_EncodedCharLength;
        public object c_EncodeCharPattern;
        public object c_DecodeCharPattern;
        public object s_allDateTimeFormats;
        public object WhitespaceChars;

        // ── Methods ──
        public void EncodeName(){} // RVA: 0x74E4450
        public void EncodeLocalName(){} // RVA: 0x74E3B20
        public void DecodeName(){} // RVA: 0x74E3B80
        public void FromHex(){} // RVA: 0x74E4FB0
        public void FromBinHexString(){} // RVA: 0x74E5090
        public void ToBinHexString(){} // RVA: 0x74E5110
        public void VerifyName(){} // RVA: 0x74E5290
        public void TryVerifyName(){} // RVA: 0x74E5400
        public void VerifyQName(){} // RVA: 0x74E55C0
        public void VerifyNCName(){} // RVA: 0x74E58B0
        public void TryVerifyNCName(){} // RVA: 0x74E5A20
        public void VerifyTOKEN(){} // RVA: 0x74E5B00
        public void TryVerifyTOKEN(){} // RVA: 0x74E5E00
        public void TryVerifyNMTOKEN(){} // RVA: 0x74E6110
        public void TryVerifyNormalizedString(){} // RVA: 0x74E6340
        public void ToString(){} // RVA: 0x74E7020
        public void ToBoolean(){} // RVA: 0x74E7070
        public void TryToBoolean(){} // RVA: 0x74E72E0
        public void ToChar(){} // RVA: 0x74E75E0
        public void TryToChar(){} // RVA: 0x74E76B0
        public void ToDecimal(){} // RVA: 0x74E7840
        public void TryToDecimal(){} // RVA: 0x74E78D0
        public void ToInteger(){} // RVA: 0x74E7A90
        public void TryToInteger(){} // RVA: 0x74E7B20
        public void ToSByte(){} // RVA: 0x74E7CE0
        public void TryToSByte(){} // RVA: 0x74E7D80
        public void ToInt16(){} // RVA: 0x74E7FE0
        public void TryToInt16(){} // RVA: 0x74E8080
        public void ToInt32(){} // RVA: 0x74E82D0
        public void TryToInt32(){} // RVA: 0x74E8300
        public void ToInt64(){} // RVA: 0x74E8480
        public void TryToInt64(){} // RVA: 0x74E84B0
        public void ToByte(){} // RVA: 0x74E8630
        public void TryToByte(){} // RVA: 0x74E86D0
        public void ToUInt16(){} // RVA: 0x74E88C0
        public void TryToUInt16(){} // RVA: 0x74E8960
        public void ToUInt32(){} // RVA: 0x74E8B50
        public void TryToUInt32(){} // RVA: 0x74E8B80
        public void ToUInt64(){} // RVA: 0x74E8D00
        public void TryToUInt64(){} // RVA: 0x74E8D30
        public void ToSingle(){} // RVA: 0x74E8EB0
        public void TryToSingle(){} // RVA: 0x74E9010
        public void ToDouble(){} // RVA: 0x74E92E0
        public void TryToDouble(){} // RVA: 0x74E9440
        public void ToXPathDouble(){} // RVA: 0x74E9720
        public void ToTimeSpan(){} // RVA: 0x74E9960
        public void TryToTimeSpan(){} // RVA: 0x74E9B70
        public void get_AllDateTimeFormats(){} // RVA: 0x74E9C30
        public void CreateAllDateTimeFormats(){} // RVA: 0x74E9CE0
        public void ToDateTime(){} // RVA: 0x74EA3B0
        public void ToDateTimeOffset(){} // RVA: 0x74EA650
        public void ToGuid(){} // RVA: 0x74EA740
        public void TryToGuid(){} // RVA: 0x74EA760
        public void SwitchToLocalTime(){} // RVA: 0x74EAA90
        public void SwitchToUtcTime(){} // RVA: 0x74EAC20
        public void ToUri(){} // RVA: 0x74EAD70
        public void TryToUri(){} // RVA: 0x74EB1C0
        public void StrEqual(){} // RVA: 0x74EB660
        public void TrimString(){} // RVA: 0x74EB710
        public void TrimStringStart(){} // RVA: 0x74EB7D0
        public void TrimStringEnd(){} // RVA: 0x74EB880
        public void SplitString(){} // RVA: 0x74EB940
        public void IsNegativeZero(){} // RVA: 0x74EBA40
        public void DoubleToInt64Bits(){} // RVA: 0x67EE620
        public void VerifyCharData(){} // RVA: 0x74EBAC0
        public void CreateException(){} // RVA: 0x74EC040
        public void CreateInvalidSurrogatePairException(){} // RVA: 0x74EC250
        public void CreateInvalidHighSurrogateCharException(){} // RVA: 0x74EC680
        public void CreateInvalidCharException(){} // RVA: 0x74ECAC0
        public void CreateInvalidNameCharException(){} // RVA: 0x74ECBA0
        public void CreateInvalidNameArgumentException(){} // RVA: 0x74ECCC0
        public void .cctor(){} // RVA: 0x74ECDC0
    }

    public class XmlDeclaration : XmlLinkedNode
    {
        public object version;
        public object encoding;
        public object standalone;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B4E50
        public void get_Version(){} // RVA: 0xB700F0
        public void set_Version(){} // RVA: 0xB70100
        public void get_Encoding(){} // RVA: 0xB70160
        public void set_Encoding(){} // RVA: 0x74B5190
        public void get_Standalone(){} // RVA: 0xD33E60
        public void set_Standalone(){} // RVA: 0x74B5210
        public void get_Value(){} // RVA: 0x74B1B30
        public void set_Value(){} // RVA: 0x74B1B50
        public void get_InnerText(){} // RVA: 0x74B5440
        public void set_InnerText(){} // RVA: 0x74B55E0
        public void get_Name(){} // RVA: 0x74B5A40
        public void get_LocalName(){} // RVA: 0x7183E10
        public void get_NodeType(){} // RVA: 0x6AE0A80
        public void CloneNode(){} // RVA: 0x74B5A80
        public void WriteTo(){} // RVA: 0x74B5AE0
        public void WriteContentTo(){} // RVA: 0xB43310
        public void IsValidXmlVersion(){} // RVA: 0x74B5B60
    }

    public class XmlDocument : XmlNode
    {
        public object implementation;
        public object domNameTable;
        public object lastChild;
        public object entities;
        public object htElementIdMap;
        public object htElementIDAttrDecl;
        public object schemaInfo;
        public object schemas;
        public object reportValidity;
        public object actualLoadingStatus;
        public object onNodeInsertingDelegate;
        public object onNodeInsertedDelegate;
        public object onNodeRemovingDelegate;
        public object onNodeRemovedDelegate;
        public object onNodeChangingDelegate;
        public object onNodeChangedDelegate;
        public object fEntRefNodesPresent;
        public object fCDataNodesPresent;
        public object preserveWhitespace;
        public object isLoading;
        public object strDocumentName;
        public object strDocumentFragmentName;
        public object strCommentName;
        public object strTextName;
        public object strCDataSectionName;
        public object strEntityName;
        public object strID;
        public object strXmlns;
        public object strXml;
        public object strSpace;
        public object strLang;
        public object strEmpty;
        public object strNonSignificantWhitespaceName;
        public object strSignificantWhitespaceName;
        public object strReservedXmlns;
        public object strReservedXml;
        public object baseURI;
        public object resolver;
        public object bSetResolver;
        public object objLock;
        public object EmptyEnumerator;
        public object NotKnownSchemaInfo;
        public object ValidSchemaInfo;
        public object InvalidSchemaInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B5D60
        public void get_DtdSchemaInfo(){} // RVA: 0xBBF8F0
        public void set_DtdSchemaInfo(){} // RVA: 0xBBF900
        public void CheckName(){} // RVA: 0x74B68E0
        public void AddXmlName(){} // RVA: 0x74B69B0
        public void GetXmlName(){} // RVA: 0x74B69E0
        public void AddAttrXmlName(){} // RVA: 0x74B6A10
        public void AddIdInfo(){} // RVA: 0x74B6B50
        public void GetIDInfoByElement_(){} // RVA: 0x74B6C80
        public void GetIDInfoByElement(){} // RVA: 0x74B6D90
        public void GetElement(){} // RVA: 0x74B6EA0
        public void AddElementWithId(){} // RVA: 0x74B7330
        public void RemoveElementWithId(){} // RVA: 0x74B75A0
        public void CloneNode(){} // RVA: 0x74B7700
        public void get_NodeType(){} // RVA: 0x2006E40
        public void get_ParentNode(){} // RVA: 0xDAC980
        public void get_DocumentType(){} // RVA: 0x74B7840
        public void get_Declaration(){} // RVA: 0x74B78D0
        public void get_Implementation(){} // RVA: 0xB465B0
        public void get_Name(){} // RVA: 0x106A7D0
        public void get_LocalName(){} // RVA: 0x106A7D0
        public void get_DocumentElement(){} // RVA: 0x74B7980
        public void get_IsContainer(){} // RVA: 0xC2E4C0
        public void get_LastNode(){} // RVA: 0xB70160
        public void set_LastNode(){} // RVA: 0xB44DC0
        public void get_OwnerDocument(){} // RVA: 0xDAC980
        public void set_Schemas(){} // RVA: 0xCA4DF0
        public void get_CanReportValidity(){} // RVA: 0xE3F480
        public void get_HasSetResolver(){} // RVA: 0x186B250
        public void GetResolver(){} // RVA: 0x114AC20
        public void set_XmlResolver(){} // RVA: 0x74B7A10
        public void IsValidChildType(){} // RVA: 0x74B7D50
        public void HasNodeTypeInPrevSiblings(){} // RVA: 0x74B7F20
        public void HasNodeTypeInNextSiblings(){} // RVA: 0x74B8010
        public void CanInsertBefore(){} // RVA: 0x74B8090
        public void CanInsertAfter(){} // RVA: 0x74B8250
        public void CreateAttribute(){} // RVA: 0x74B9D30
        public void SetDefaultNamespace(){} // RVA: 0x74B8460
        public void CreateCDataSection(){} // RVA: 0x74B8630
        public void CreateComment(){} // RVA: 0x74B86A0
        public void CreateDocumentType(){} // RVA: 0x74B8710
        public void CreateDocumentFragment(){} // RVA: 0x74B87B0
        public void CreateElement(){} // RVA: 0x74B9E80
        public void AddDefaultAttributes(){} // RVA: 0x74B8930
        public void GetSchemaElementDecl(){} // RVA: 0x74B8CB0
        public void PrepareDefaultAttribute(){} // RVA: 0x74B8EA0
        public void CreateEntityReference(){} // RVA: 0x74B8FC0
        public void CreateProcessingInstruction(){} // RVA: 0x74B9030
        public void CreateXmlDeclaration(){} // RVA: 0x74B90B0
        public void CreateTextNode(){} // RVA: 0x74B9150
        public void CreateSignificantWhitespace(){} // RVA: 0x74B91C0
        public void CreateWhitespace(){} // RVA: 0x74B9230
        public void ImportNodeInternal(){} // RVA: 0x74B93C0
        public void ImportAttributes(){} // RVA: 0x74B9B00
        public void ImportChildren(){} // RVA: 0x74B9C70
        public void get_NameTable(){} // RVA: 0x1853320
        public void CreateDefaultAttribute(){} // RVA: 0x74B9DD0
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_Entities(){} // RVA: 0x74B9F50
        public void set_Entities(){} // RVA: 0xB708C0
        public void get_IsLoading(){} // RVA: 0x7130170
        public void set_IsLoading(){} // RVA: 0x74BA050
        public void get_ActualLoadingStatus(){} // RVA: 0x5C8BB10
        public void ReadNode(){} // RVA: 0x74BA060
        public void SetupReader(){} // RVA: 0x74BA120
        public void Load(){} // RVA: 0x74BA190
        public void LoadXml(){} // RVA: 0x74BA2B0
        public void set_InnerText(){} // RVA: 0x74BA570
        public void set_InnerXml(){} // RVA: 0x6A27B90
        public void Save(){} // RVA: 0x74BA5D0
        public void WriteTo(){} // RVA: 0x74BA890
        public void WriteContentTo(){} // RVA: 0x74BA8B0
        public void GetEventArgs(){} // RVA: 0x74BAB00
        public void GetInsertEventArgsForLoad(){} // RVA: 0x74BAC00
        public void BeforeEvent(){} // RVA: 0x74BACD0
        public void AfterEvent(){} // RVA: 0x74BAD50
        public void GetDefaultAttribute(){} // RVA: 0x74BADD0
        public void get_Version(){} // RVA: 0x74BB120
        public void get_Encoding(){} // RVA: 0x74BB150
        public void get_Standalone(){} // RVA: 0x74BB180
        public void GetEntityNode(){} // RVA: 0x74BB1B0
        public void get_SchemaInfo(){} // RVA: 0x74BB2A0
        public void get_BaseURI(){} // RVA: 0xDA0520
        public void SetBaseURI(){} // RVA: 0xD9D570
        public void AppendChildForLoad(){} // RVA: 0x74BB3D0
        public void .cctor(){} // RVA: 0x74BB680
    }

    public class XmlDocumentFragment : XmlNode
    {
        public object lastChild;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74BB910
        public void get_Name(){} // RVA: 0x74BB9E0
        public void get_LocalName(){} // RVA: 0x74BB9E0
        public void get_NodeType(){} // RVA: 0x6913E80
        public void get_ParentNode(){} // RVA: 0xDAC980
        public void get_OwnerDocument(){} // RVA: 0x74BBA10
        public void set_InnerXml(){} // RVA: 0x74BBA90
        public void CloneNode(){} // RVA: 0x74BBB20
        public void get_IsContainer(){} // RVA: 0xC2E4C0
        public void get_LastNode(){} // RVA: 0xB465B0
        public void set_LastNode(){} // RVA: 0xBA9BA0
        public void IsValidChildType(){} // RVA: 0x74BBBC0
        public void CanInsertAfter(){} // RVA: 0x74BBC80
        public void CanInsertBefore(){} // RVA: 0x74BBD00
        public void WriteTo(){} // RVA: 0x74BA890
        public void WriteContentTo(){} // RVA: 0x74BBD80
    }

    public class XmlDocumentType : XmlLinkedNode
    {
        public object name;
        public object publicId;
        public object systemId;
        public object internalSubset;
        public object namespaces;
        public object entities;
        public object notations;
        public object schemaInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74BBFD0
        public void get_Name(){} // RVA: 0xB700F0
        public void get_LocalName(){} // RVA: 0xB700F0
        public void get_NodeType(){} // RVA: 0xE49B40
        public void CloneNode(){} // RVA: 0x74BC230
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_Entities(){} // RVA: 0x74BC290
        public void get_Notations(){} // RVA: 0x74BC390
        public void get_PublicId(){} // RVA: 0xB70160
        public void get_SystemId(){} // RVA: 0xD33E60
        public void get_InternalSubset(){} // RVA: 0xD05CA0
        public void get_ParseWithNamespaces(){} // RVA: 0xC02470
        public void WriteTo(){} // RVA: 0x74BC490
        public void WriteContentTo(){} // RVA: 0xB43310
        public void get_DtdSchemaInfo(){} // RVA: 0xC0FFC0
        public void set_DtdSchemaInfo(){} // RVA: 0xC0FFD0
    }

    public class XmlDownloadManager : Object
    {
        public object connections;

        // ── Methods ──
        public void GetStream(){} // RVA: 0x74ECFE0
        public void GetNonFileStream(){} // RVA: 0x74ED120
        public void Remove(){} // RVA: 0x74ED750
        public void GetStreamAsync(){} // RVA: 0x74ED910
        public void GetNonFileStreamAsync(){} // RVA: 0x74EDAF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlElement : XmlLinkedNode
    {
        public object name;
        public object attributes;
        public object lastChild;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74BC710
        public void get_XmlName(){} // RVA: 0xB700F0
        public void set_XmlName(){} // RVA: 0xB70100
        public void CloneNode(){} // RVA: 0x74BC780
        public void get_Name(){} // RVA: 0x74BCC60
        public void get_LocalName(){} // RVA: 0xB4B8A0
        public void get_NamespaceURI(){} // RVA: 0x74BCC80
        public void get_Prefix(){} // RVA: 0x1853470
        public void set_Prefix(){} // RVA: 0x74BCCA0
        public void get_NodeType(){} // RVA: 0xC3CCE0
        public void get_ParentNode(){} // RVA: 0xB5DBF0
        public void get_OwnerDocument(){} // RVA: 0x74BCDC0
        public void get_IsContainer(){} // RVA: 0xC2E4C0
        public void AppendChildForLoad(){} // RVA: 0x74BCDE0
        public void get_IsEmpty(){} // RVA: 0x74BD1A0
        public void set_IsEmpty(){} // RVA: 0x74BD1B0
        public void get_LastNode(){} // RVA: 0x74BD290
        public void set_LastNode(){} // RVA: 0xB708C0
        public void IsValidChildType(){} // RVA: 0x74BD2A0
        public void get_Attributes(){} // RVA: 0x74BD300
        public void get_HasAttributes(){} // RVA: 0x74BD530
        public void GetAttribute(){} // RVA: 0x74BD860
        public void SetAttribute(){} // RVA: 0x74BD8B0
        public void GetAttributeNode(){} // RVA: 0x74BD9D0
        public void SetAttributeNode(){} // RVA: 0x74BDA60
        public void HasAttribute(){} // RVA: 0x74BDB30
        public void WriteTo(){} // RVA: 0x74BDB60
        public void WriteElementTo(){} // RVA: 0x74BDC90
        public void WriteStartElement(){} // RVA: 0x74BDED0
        public void WriteContentTo(){} // RVA: 0x74B27E0
        public void RemoveAllAttributes(){} // RVA: 0x74BE010
        public void RemoveAll(){} // RVA: 0x74BE120
        public void RemoveAllChildren(){} // RVA: 0x74BE150
        public void get_SchemaInfo(){} // RVA: 0xB700F0
        public void set_InnerXml(){} // RVA: 0x74BE160
        public void get_InnerText(){} // RVA: 0x74BE350
        public void set_InnerText(){} // RVA: 0x74BE360
        public void get_NextSibling(){} // RVA: 0x74BE450
        public void SetParent(){} // RVA: 0xB44D60
    }

    public class XmlEncodedRawTextWriter : XmlRawWriter
    {
        public object useAsync;
        public object bufBytes;
        public object stream;
        public object encoding;
        public object xmlCharType;
        public object bufPos;
        public object textPos;
        public object contentPos;
        public object cdataPos;
        public object attrEndPos;
        public object bufLen;
        public object writeToNull;
        public object hadDoubleBracket;
        public object inAttributeValue;
        public object bufBytesUsed;
        public object bufChars;
        public object encoder;
        public object writer;
        public object trackTextContent;
        public object inTextContent;
        public object lastMarkPos;
        public object textContentMarks;
        public object charEntityFallback;
        public object newLineHandling;
        public object closeOutput;
        public object omitXmlDeclaration;
        public object newLineChars;
        public object checkCharacters;
        public object standalone;
        public object outputMethod;
        public object autoXmlDeclaration;
        public object mergeCDataSections;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747F2B0
        public void WriteXmlDeclaration(){} // RVA: 0x747FA70
        public void WriteDocType(){} // RVA: 0x747FAE0
        public void WriteStartElement(){} // RVA: 0x747FD80
        public void StartElementContent(){} // RVA: 0x747FE60
        public void WriteEndElement(){} // RVA: 0x747FEA0
        public void WriteFullEndElement(){} // RVA: 0x7480020
        public void WriteStartAttribute(){} // RVA: 0x7480140
        public void WriteEndAttribute(){} // RVA: 0x7480260
        public void WriteNamespaceDeclaration(){} // RVA: 0x74802C0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0xC2E4C0
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7480320
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7480480
        public void WriteCData(){} // RVA: 0x74804E0
        public void WriteComment(){} // RVA: 0x7480720
        public void WriteProcessingInstruction(){} // RVA: 0x7480880
        public void WriteEntityRef(){} // RVA: 0x74809D0
        public void WriteCharEntity(){} // RVA: 0x7480AA0
        public void WriteWhitespace(){} // RVA: 0x7480D20
        public void WriteString(){} // RVA: 0x7480DA0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7480E20
        public void WriteChars(){} // RVA: 0x7364230
        public void WriteRaw(){} // RVA: 0x747AC70
        public void Close(){} // RVA: 0x74810B0
        public void Flush(){} // RVA: 0x7481390
        public void FlushBuffer(){} // RVA: 0x7481420
        public void EncodeChars(){} // RVA: 0x7481980
        public void FlushEncoder(){} // RVA: 0x7481B00
        public void WriteAttributeTextBlock(){} // RVA: 0x7481BE0
        public void WriteElementTextBlock(){} // RVA: 0x7481EF0
        public void RawText(){} // RVA: 0x7482250
        public void WriteRawWithCharChecking(){} // RVA: 0x74823F0
        public void WriteCommentOrPi(){} // RVA: 0x7482680
        public void WriteCDataSection(){} // RVA: 0x7482A10
        public void EncodeSurrogate(){} // RVA: 0x7482D90
        public void InvalidXmlChar(){} // RVA: 0x7482F10
        public void EncodeChar(){} // RVA: 0x74830C0
        public void ChangeTextContentMark(){} // RVA: 0x74831A0
        public void GrowTextContentMarks(){} // RVA: 0x7483220
        public void WriteNewLine(){} // RVA: 0x74833C0
        public void LtEntity(){} // RVA: 0x7483440
        public void GtEntity(){} // RVA: 0x7483460
        public void AmpEntity(){} // RVA: 0x7483480
        public void QuoteEntity(){} // RVA: 0x74834A0
        public void TabEntity(){} // RVA: 0x74834C0
        public void LineFeedEntity(){} // RVA: 0x74834E0
        public void CarriageReturnEntity(){} // RVA: 0x7483500
        public void CharEntity(){} // RVA: 0x7483520
        public void RawStartCData(){} // RVA: 0x7483670
        public void RawEndCData(){} // RVA: 0x74836A0
        public void ValidateContentChars(){} // RVA: 0x74836C0
    }

    public class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
    {
        public object indentLevel;
        public object newLineOnAttributes;
        public object indentChars;
        public object mixedContent;
        public object mixedContentStack;
        public object conformanceLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7483AF0
        public void WriteDocType(){} // RVA: 0x7483B20
        public void WriteStartElement(){} // RVA: 0x7483B90
        public void StartElementContent(){} // RVA: 0x7483CD0
        public void OnRootElement(){} // RVA: 0x25C0CE0
        public void WriteEndElement(){} // RVA: 0x7483D40
        public void WriteFullEndElement(){} // RVA: 0x7483E20
        public void WriteStartAttribute(){} // RVA: 0x7483F00
        public void WriteCData(){} // RVA: 0x7483F60
        public void WriteComment(){} // RVA: 0x7483F70
        public void WriteProcessingInstruction(){} // RVA: 0x7483FB0
        public void WriteEntityRef(){} // RVA: 0x7484000
        public void WriteCharEntity(){} // RVA: 0x74840D0
        public void WriteSurrogateCharEntity(){} // RVA: 0x74840E0
        public void WriteWhitespace(){} // RVA: 0x74840F0
        public void WriteString(){} // RVA: 0x7484170
        public void WriteChars(){} // RVA: 0x74841F0
        public void WriteRaw(){} // RVA: 0x7484320
        public void WriteBase64(){} // RVA: 0x7484390
        public void Init(){} // RVA: 0x74843B0
        public void WriteIndent(){} // RVA: 0x7484590
    }

    public class XmlEntity : XmlNode
    {
        public object publicId;
        public object systemId;
        public object notationName;
        public object name;
        public object unparsedReplacementStr;
        public object baseURI;
        public object lastChild;
        public object childrenFoliating;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74BE490
        public void CloneNode(){} // RVA: 0x74BE7A0
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_Name(){} // RVA: 0xD33E60
        public void get_LocalName(){} // RVA: 0xD33E60
        public void get_InnerText(){} // RVA: 0x74BE350
        public void set_InnerText(){} // RVA: 0x74BE800
        public void get_IsContainer(){} // RVA: 0xC2E4C0
        public void get_LastNode(){} // RVA: 0x74BE860
        public void set_LastNode(){} // RVA: 0xBBF900
        public void IsValidChildType(){} // RVA: 0x74BE970
        public void get_NodeType(){} // RVA: 0x13510C0
        public void get_SystemId(){} // RVA: 0xB700F0
        public void set_InnerXml(){} // RVA: 0x74BE990
        public void WriteTo(){} // RVA: 0xB43310
        public void WriteContentTo(){} // RVA: 0xB43310
        public void get_BaseURI(){} // RVA: 0xBC1B30
        public void SetBaseURI(){} // RVA: 0xB6A8C0
    }

    public class XmlEntityReference : XmlLinkedNode
    {
        public object name;
        public object lastChild;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74BE9F0
        public void get_Name(){} // RVA: 0xB700F0
        public void get_LocalName(){} // RVA: 0xB700F0
        public void get_Value(){} // RVA: 0xDAC980
        public void set_Value(){} // RVA: 0x74BEB30
        public void get_NodeType(){} // RVA: 0xEF4110
        public void CloneNode(){} // RVA: 0x74BEB90
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_IsContainer(){} // RVA: 0xC2E4C0
        public void SetParent(){} // RVA: 0x74BEBE0
        public void SetParentForLoad(){} // RVA: 0x74BED60
        public void get_LastNode(){} // RVA: 0xB70160
        public void set_LastNode(){} // RVA: 0xB44DC0
        public void IsValidChildType(){} // RVA: 0x74BD2A0
        public void WriteTo(){} // RVA: 0x74BED80
        public void WriteContentTo(){} // RVA: 0x74BEDC0
        public void get_BaseURI(){} // RVA: 0x74BF010
        public void ConstructBaseURI(){} // RVA: 0x74BF050
        public void get_ChildBaseURI(){} // RVA: 0x74BF120
    }

    public class XmlEventCache : XmlRawWriter
    {
        public object pages;
        public object pageCurr;
        public object pageSize;
        public object hasRootNode;
        public object singleText;
        public object baseUri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7484610
        public void EndEvents(){} // RVA: 0x7484670
        public void EventsToWriter(){} // RVA: 0x74846C0
        public void WriteDocType(){} // RVA: 0x74851E0
        public void WriteStartElement(){} // RVA: 0x7485270
        public void WriteStartAttribute(){} // RVA: 0x7485300
        public void WriteEndAttribute(){} // RVA: 0x7485390
        public void WriteCData(){} // RVA: 0x74853D0
        public void WriteComment(){} // RVA: 0x74853E0
        public void WriteProcessingInstruction(){} // RVA: 0x74853F0
        public void WriteWhitespace(){} // RVA: 0x7485420
        public void WriteString(){} // RVA: 0x7485430
        public void WriteChars(){} // RVA: 0x1D55C90
        public void WriteRaw(){} // RVA: 0x7485460
        public void WriteEntityRef(){} // RVA: 0x7485470
        public void WriteCharEntity(){} // RVA: 0x7485480
        public void WriteSurrogateCharEntity(){} // RVA: 0x74854C0
        public void WriteBase64(){} // RVA: 0x7485560
        public void WriteBinHex(){} // RVA: 0x74855A0
        public void Close(){} // RVA: 0x74855E0
        public void Flush(){} // RVA: 0x7485620
        public void WriteValue(){} // RVA: 0x7485660
        public void Dispose(){} // RVA: 0x7485680
        public void WriteXmlDeclaration(){} // RVA: 0x74857F0
        public void StartElementContent(){} // RVA: 0x7485800
        public void WriteEndElement(){} // RVA: 0x7485840
        public void WriteFullEndElement(){} // RVA: 0x74858D0
        public void WriteNamespaceDeclaration(){} // RVA: 0x7485960
        public void WriteEndBase64(){} // RVA: 0x7485990
        public void AddEvent(){} // RVA: 0x7485C50
        public void NewEvent(){} // RVA: 0x7485D00
        public void ToBytes(){} // RVA: 0x7485FC0
    }

    public class XmlException : SystemException
    {
        public object res;
        public object args;
        public object lineNumber;
        public object linePosition;
        public object sourceUri;
        public object message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F2BE0
        public void GetObjectData(){} // RVA: 0x74F1A60
        public void FormatUserMessage(){} // RVA: 0x74F2D70
        public void CreateMessage(){} // RVA: 0x74F2E80
        public void BuildCharExceptionArgs(){} // RVA: 0x74F30D0
        public void get_LineNumber(){} // RVA: 0x262A8F0
        public void get_LinePosition(){} // RVA: 0x6C8E620
        public void get_Message(){} // RVA: 0x74F33B0
        public void get_ResString(){} // RVA: 0x1069350
    }

    public class XmlImplementation : Object
    {
        public object nameTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CreateDocument(){} // RVA: 0x74BF3F0
        public void get_NameTable(){} // RVA: 0xB5DBF0
    }

    public class XmlLinkedNode : XmlNode
    {
        public object next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74BF450
        public void get_PreviousSibling(){} // RVA: 0x74BF580
        public void get_NextSibling(){} // RVA: 0x74BF610
    }

    public class XmlLoader : Object
    {
        public object doc;
        public object reader;
        public object preserveWhitespace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Load(){} // RVA: 0x74BF670
        public void LoadDocSequence(){} // RVA: 0x74BFA80
        public void ReadCurrentNode(){} // RVA: 0x74BFB00
        public void LoadNode(){} // RVA: 0x74BFD40
        public void LoadAttributeNode(){} // RVA: 0x74C04F0
        public void LoadDefaultAttribute(){} // RVA: 0x74C0880
        public void LoadAttributeValue(){} // RVA: 0x74C0AB0
        public void LoadEntityReferenceNode(){} // RVA: 0x74C0DF0
        public void LoadDeclarationNode(){} // RVA: 0x74C1040
        public void LoadDocumentTypeNode(){} // RVA: 0x74C12C0
        public void LoadNodeDirect(){} // RVA: 0x74C1560
        public void LoadAttributeNodeDirect(){} // RVA: 0x74C1B70
        public void ParseDocumentType(){} // RVA: 0x74C1DE0
        public void LoadDocumentType(){} // RVA: 0x74C2170
        public void GetContext(){} // RVA: 0x74C3310
        public void ParsePartialContent(){} // RVA: 0x74C3D80
        public void LoadInnerXmlElement(){} // RVA: 0x74C4090
        public void LoadInnerXmlAttribute(){} // RVA: 0x74C4230
        public void RemoveDuplicateNamespace(){} // RVA: 0x74C4250
        public void EntitizeName(){} // RVA: 0x74C4620
        public void ExpandEntity(){} // RVA: 0x74C4680
        public void ExpandEntityReference(){} // RVA: 0x74C4740
        public void CreateInnerXmlReader(){} // RVA: 0x74C4EB0
        public void ParseXmlDeclarationValue(){} // RVA: 0x74C5150
        public void UnexpectedNodeType(){} // RVA: 0x74C5670
    }

    public class XmlName : Object
    {
        public object prefix;
        public object localName;
        public object ns;
        public object name;
        public object hashCode;
        public object ownerDoc;
        public object next;

        // ── Methods ──
        public void Create(){} // RVA: 0x74C57E0
        public void .ctor(){} // RVA: 0x74C5900
        public void get_LocalName(){} // RVA: 0xB465B0
        public void get_NamespaceURI(){} // RVA: 0xB700F0
        public void get_Prefix(){} // RVA: 0xB5DBF0
        public void get_HashCode(){} // RVA: 0xB9E080
        public void get_OwnerDocument(){} // RVA: 0xD05CA0
        public void get_Name(){} // RVA: 0x74C5B20
        public void get_Validity(){} // RVA: 0xDAC980
        public void get_IsDefault(){} // RVA: 0xB43320
        public void get_IsNil(){} // RVA: 0xB43320
        public void get_MemberType(){} // RVA: 0xDAC980
        public void get_SchemaType(){} // RVA: 0xDAC980
        public void get_SchemaElement(){} // RVA: 0xDAC980
        public void get_SchemaAttribute(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0x1D16BD0
        public void GetHashCode(){} // RVA: 0x74C5DB0
    }

    public class XmlNameEx : XmlName
    {
        public object flags;
        public object memberType;
        public object schemaType;
        public object decl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74C5E20
        public void get_Validity(){} // RVA: 0x74C6080
        public void get_IsDefault(){} // RVA: 0x74C60B0
        public void get_IsNil(){} // RVA: 0x74C60C0
        public void get_MemberType(){} // RVA: 0xBE58B0
        public void get_SchemaType(){} // RVA: 0xC0FFC0
        public void get_SchemaElement(){} // RVA: 0x74C60D0
        public void get_SchemaAttribute(){} // RVA: 0x74C6150
        public void SetValidity(){} // RVA: 0x74C61D0
        public void SetIsDefault(){} // RVA: 0x74C61E0
        public void SetIsNil(){} // RVA: 0x74C6210
        public void Equals(){} // RVA: 0x74C6240
    }

    public class XmlNameTable : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x87C540
        public void Add(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlNamedNodeMap : Object
    {
        public object parent;
        public object nodes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetNamedItem(){} // RVA: 0x74C6400
        public void SetNamedItem(){} // RVA: 0x74C65B0
        public void get_Count(){} // RVA: 0x74B3730
        public void GetEnumerator(){} // RVA: 0x74C6690
        public void FindNodeOffset(){} // RVA: 0x74C67D0
        public void AddNode(){} // RVA: 0x74C6960
        public void AddNodeForLoad(){} // RVA: 0x74C6B10
        public void RemoveNodeAt(){} // RVA: 0x74C6BE0
        public void ReplaceNodeAt(){} // RVA: 0x74C6D60
        public void InsertNodeAt(){} // RVA: 0x74C6DD0
    }

    public class XmlNamespaceManager : Object
    {
        public object nsdecls;
        public object lastDecl;
        public object nameTable;
        public object scopeId;
        public object hashTable;
        public object useHashtable;
        public object xml;
        public object xmlNs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F33D0
        public void get_NameTable(){} // RVA: 0xB700F0
        public void get_DefaultNamespace(){} // RVA: 0x74F3740
        public void PushScope(){} // RVA: 0x4F237D0
        public void PopScope(){} // RVA: 0x74F3790
        public void AddNamespace(){} // RVA: 0x74F38A0
        public void RemoveNamespace(){} // RVA: 0x74F3D60
        public void GetEnumerator(){} // RVA: 0x74F3F20
        public void GetNamespacesInScope(){} // RVA: 0x74F4120
        public void LookupNamespace(){} // RVA: 0x74F42F0
        public void LookupNamespaceDecl(){} // RVA: 0x74F4340
        public void LookupPrefix(){} // RVA: 0x74F4560
    }

    public class XmlNode : Object
    {
        public object parentNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74C78B0
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0xDAC980
        public void set_Value(){} // RVA: 0x74C7980
        public void get_NodeType(){} // RVA: 0x87C130
        public void get_ParentNode(){} // RVA: 0x74C7A60
        public void get_ChildNodes(){} // RVA: 0x74C7B60
        public void get_PreviousSibling(){} // RVA: 0xDAC980
        public void get_NextSibling(){} // RVA: 0xDAC980
        public void get_Attributes(){} // RVA: 0xDAC980
        public void get_OwnerDocument(){} // RVA: 0x74C7BF0
        public void get_FirstChild(){} // RVA: 0x74C7CC0
        public void get_LastChild(){} // RVA: 0x42E82B0
        public void get_IsContainer(){} // RVA: 0xB43320
        public void get_LastNode(){} // RVA: 0xDAC980
        public void set_LastNode(){} // RVA: 0xB43310
        public void AncestorNode(){} // RVA: 0x74C7CF0
        public void InsertBefore(){} // RVA: 0x74C7D70
        public void InsertAfter(){} // RVA: 0x74C8700
        public void RemoveChild(){} // RVA: 0x74C9080
        public void PrependChild(){} // RVA: 0x74C9640
        public void AppendChild(){} // RVA: 0x74C9690
        public void AppendChildForLoad(){} // RVA: 0x74C9D40
        public void IsValidChildType(){} // RVA: 0xB43320
        public void CanInsertBefore(){} // RVA: 0xC2E4C0
        public void CanInsertAfter(){} // RVA: 0xC2E4C0
        public void get_HasChildNodes(){} // RVA: 0x74CA080
        public void CloneNode(){} // RVA: 0x881D20
        public void CopyChildren(){} // RVA: 0x74CA0B0
        public void get_NamespaceURI(){} // RVA: 0x1584680
        public void get_Prefix(){} // RVA: 0x1584680
        public void set_Prefix(){} // RVA: 0xB43310
        public void get_LocalName(){} // RVA: 0x87C0A0
        public void get_IsReadOnly(){} // RVA: 0x74CA170
        public void HasReadOnlyParent(){} // RVA: 0x74CA250
        public void System.ICloneable.Clone(){} // RVA: 0x74CA330
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x74CA350
        public void GetEnumerator(){} // RVA: 0x74CA3B0
        public void AppendChildText(){} // RVA: 0x74CA410
        public void get_InnerText(){} // RVA: 0x74CA540
        public void set_InnerText(){} // RVA: 0x74CA670
        public void set_InnerXml(){} // RVA: 0x74CA780
        public void get_SchemaInfo(){} // RVA: 0x74CA7E0
        public void get_BaseURI(){} // RVA: 0x74CA840
        public void WriteTo(){} // RVA: 0x894320
        public void WriteContentTo(){} // RVA: 0x894320
        public void RemoveAll(){} // RVA: 0x74CA950
        public void get_Document(){} // RVA: 0x74CA9D0
        public void GetPrefixOfNamespace(){} // RVA: 0x74CAA70
        public void GetPrefixOfNamespaceStrict(){} // RVA: 0x74CAAA0
        public void SetParent(){} // RVA: 0x74CAF50
        public void SetParentForLoad(){} // RVA: 0xB44D60
        public void SplitName(){} // RVA: 0x74CB030
        public void FindChild(){} // RVA: 0x74CB1A0
        public void GetEventArgs(){} // RVA: 0x74CB230
        public void BeforeEvent(){} // RVA: 0x74CB370
        public void AfterEvent(){} // RVA: 0x74CB3C0
        public void get_XmlSpace(){} // RVA: 0x74CB410
        public void get_XmlLang(){} // RVA: 0x74CB6A0
        public void get_IsText(){} // RVA: 0xB43320
        public void NestTextNodes(){} // RVA: 0x74CB790
        public void UnnestTextNodes(){} // RVA: 0x74CB7F0
    }

    public class XmlNodeChangedEventArgs : EventArgs
    {
        public object action;
        public object node;
        public object oldParent;
        public object newParent;
        public object oldValue;
        public object newValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74CB870
        public void get_Action(){} // RVA: 0xB8F8F0
    }

    public class XmlNodeChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class XmlNodeList : Object
    {
        // ── Methods ──
        public void Item(){} // RVA: 0x87C160
        public void get_Count(){} // RVA: 0x87C130
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void get_ItemOf(){} // RVA: 0x4AB63B0
        public void System.IDisposable.Dispose(){} // RVA: 0x11F4110
        public void PrivateDisposeNodeList(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlNodeReader : XmlReader
    {
        public object readerNav;
        public object nodeType;
        public object curDepth;
        public object readState;
        public object fEOF;
        public object bResolveEntity;
        public object bStartFromDocument;
        public object bInReadBinary;
        public object readBinaryHelper;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D0640
        public void IsInReadingStates(){} // RVA: 0x6BE40F0
        public void get_NodeType(){} // RVA: 0x74D0780
        public void get_Name(){} // RVA: 0x74D0790
        public void get_LocalName(){} // RVA: 0x74D07D0
        public void get_NamespaceURI(){} // RVA: 0x74D08D0
        public void get_Prefix(){} // RVA: 0x74D0920
        public void get_Value(){} // RVA: 0x74D0970
        public void get_Depth(){} // RVA: 0x2244FB0
        public void get_BaseURI(){} // RVA: 0x74D09B0
        public void get_CanResolveEntity(){} // RVA: 0xC2E4C0
        public void get_IsEmptyElement(){} // RVA: 0x74D09F0
        public void get_IsDefault(){} // RVA: 0x74D0A20
        public void get_XmlSpace(){} // RVA: 0x74D0B00
        public void get_XmlLang(){} // RVA: 0x74D0B50
        public void get_SchemaInfo(){} // RVA: 0x74D0BA0
        public void get_AttributeCount(){} // RVA: 0x74D0BF0
        public void GetAttribute(){} // RVA: 0x74D0CB0
        public void MoveToAttribute(){} // RVA: 0x74D0E20
        public void MoveToFirstAttribute(){} // RVA: 0x74D0FE0
        public void MoveToNextAttribute(){} // RVA: 0x74D10D0
        public void MoveToElement(){} // RVA: 0x74D11E0
        public void Read(){} // RVA: 0x74D1350
        public void ReadNextNode(){} // RVA: 0x74D1520
        public void SetEndOfFile(){} // RVA: 0x74D17E0
        public void ReadAtZeroLevel(){} // RVA: 0x74D1800
        public void ReadForward(){} // RVA: 0x74D18A0
        public void ReSetReadingMarks(){} // RVA: 0x74D1A90
        public void get_EOF(){} // RVA: 0x74D1AC0
        public void Close(){} // RVA: 0x74D1AD0
        public void get_ReadState(){} // RVA: 0xFEAE90
        public void Skip(){} // RVA: 0x74D1AE0
        public void ReadString(){} // RVA: 0x74D1AF0
        public void get_HasAttributes(){} // RVA: 0x7488C90
        public void get_NameTable(){} // RVA: 0x13F9420
        public void LookupNamespace(){} // RVA: 0x74D1BA0
        public void ResolveEntity(){} // RVA: 0x74D1BE0
        public void ReadAttributeValue(){} // RVA: 0x74D1C70
        public void FinishReadBinary(){} // RVA: 0x74D1CC0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x74D1CF0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x74D1D10
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x74D1D30
        public void get_DtdInfo(){} // RVA: 0x74D1DA0
    }

    public class XmlNodeReaderNavigator : Object
    {
        public object curNode;
        public object elemNode;
        public object logNode;
        public object attrIndex;
        public object logAttrIndex;
        public object nameTable;
        public object doc;
        public object nAttrInd;
        public object nDeclarationAttrCount;
        public object nDocTypeAttrCount;
        public object nLogLevel;
        public object nLogAttrInd;
        public object bLogOnAttrVal;
        public object bCreatedOnAttribute;
        public object decNodeAttributes;
        public object docTypeNodeAttributes;
        public object bOnAttrVal;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74CBA80
        public void get_NodeType(){} // RVA: 0x74CC470
        public void get_NamespaceURI(){} // RVA: 0x6AE0990
        public void get_Name(){} // RVA: 0x74CC4C0
        public void get_LocalName(){} // RVA: 0x74CC5E0
        public void get_CreatedOnAttribute(){} // RVA: 0x23DB790
        public void IsLocalNameEmpty(){} // RVA: 0x74CC6A0
        public void get_Prefix(){} // RVA: 0x71DA5A0
        public void get_Value(){} // RVA: 0x74CC6F0
        public void get_BaseURI(){} // RVA: 0x71DA660
        public void get_XmlSpace(){} // RVA: 0x74CC9C0
        public void get_XmlLang(){} // RVA: 0x74CC9F0
        public void get_IsEmptyElement(){} // RVA: 0x74CCA20
        public void get_IsDefault(){} // RVA: 0x74CCAD0
        public void get_SchemaInfo(){} // RVA: 0x7408590
        public void get_NameTable(){} // RVA: 0xD33E60
        public void get_AttributeCount(){} // RVA: 0x74CCB90
        public void CheckIndexCondition(){} // RVA: 0x74CCCE0
        public void InitDecAttr(){} // RVA: 0x74CCD50
        public void GetDeclarationAttr(){} // RVA: 0x74CD2E0
        public void GetDecAttrInd(){} // RVA: 0x74CD330
        public void InitDocTypeAttr(){} // RVA: 0x74CD400
        public void GetDocumentTypeAttr(){} // RVA: 0x74CD780
        public void GetDocTypeAttrInd(){} // RVA: 0x74CD7D0
        public void GetAttributeFromElement(){} // RVA: 0x74CDC40
        public void GetAttribute(){} // RVA: 0x74CE010
        public void LogMove(){} // RVA: 0x74CE270
        public void RollBackMove(){} // RVA: 0x74CE2E0
        public void get_IsOnDeclOrDocType(){} // RVA: 0x74CE360
        public void ResetToAttribute(){} // RVA: 0x74CE3A0
        public void ResetMove(){} // RVA: 0x74CE4D0
        public void MoveToAttribute(){} // RVA: 0x74CEBE0
        public void MoveToAttributeFromElement(){} // RVA: 0x74CE7B0
        public void MoveToNextAttribute(){} // RVA: 0x74CEDB0
        public void MoveToParent(){} // RVA: 0x74CEFB0
        public void MoveToFirstChild(){} // RVA: 0x74CF050
        public void MoveToNextSibling(){} // RVA: 0x74CF0F0
        public void MoveToNext(){} // RVA: 0x74CF190
        public void MoveToElement(){} // RVA: 0x74CF1F0
        public void LookupNamespace(){} // RVA: 0x74CF280
        public void DefaultLookupNamespace(){} // RVA: 0x74CF600
        public void LookupPrefix(){} // RVA: 0x74CF800
        public void GetNamespacesInScope(){} // RVA: 0x74CFDA0
        public void ReadAttributeValue(){} // RVA: 0x74D0410
        public void get_Document(){} // RVA: 0xD05CA0
    }

    public class XmlNotation : XmlNode
    {
        public object publicId;
        public object systemId;
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D1DD0
        public void get_Name(){} // RVA: 0xB70160
        public void get_LocalName(){} // RVA: 0xB70160
        public void get_NodeType(){} // RVA: 0x2AFB6E0
        public void CloneNode(){} // RVA: 0x74D2020
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void set_InnerXml(){} // RVA: 0x74D2080
        public void WriteTo(){} // RVA: 0xB43310
        public void WriteContentTo(){} // RVA: 0xB43310
    }

    public class XmlParserContext : Object
    {
        public object _nt;
        public object _nsMgr;
        public object _docTypeName;
        public object _pubId;
        public object _sysId;
        public object _internalSubset;
        public object _xmlLang;
        public object _xmlSpace;
        public object _baseURI;
        public object _encoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7486400
        public void get_NameTable(){} // RVA: 0xB5DBF0
        public void get_NamespaceManager(){} // RVA: 0xB465B0
        public void get_DocTypeName(){} // RVA: 0xB700F0
        public void get_PublicId(){} // RVA: 0xB70160
        public void get_SystemId(){} // RVA: 0xD33E60
        public void get_BaseURI(){} // RVA: 0xBE58B0
        public void get_InternalSubset(){} // RVA: 0xD05CA0
        public void get_XmlLang(){} // RVA: 0xBC1B30
        public void get_XmlSpace(){} // RVA: 0xBE5890
        public void get_Encoding(){} // RVA: 0xC0FFC0
        public void get_HasDtdInfo(){} // RVA: 0x7486B00
    }

    public class XmlProcessingInstruction : XmlLinkedNode
    {
        public object target;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D20E0
        public void get_Name(){} // RVA: 0x74B46E0
        public void get_LocalName(){} // RVA: 0x7183E10
        public void get_Value(){} // RVA: 0xB70160
        public void set_Value(){} // RVA: 0x74D21C0
        public void set_Data(){} // RVA: 0x74D21D0
        public void get_InnerText(){} // RVA: 0xB70160
        public void set_InnerText(){} // RVA: 0x74D21C0
        public void get_NodeType(){} // RVA: 0x132D270
        public void CloneNode(){} // RVA: 0x74D22E0
        public void WriteTo(){} // RVA: 0x74D2330
        public void WriteContentTo(){} // RVA: 0xB43310
    }

    public class XmlQualifiedName : Object
    {
        public object hashCodeDelegate;
        public object name;
        public object ns;
        public object hash;
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F4940
        public void get_Namespace(){} // RVA: 0xB465B0
        public void get_Name(){} // RVA: 0xB5DBF0
        public void GetHashCode(){} // RVA: 0x74F4A40
        public void get_IsEmpty(){} // RVA: 0x74F4B80
        public void ToString(){} // RVA: 0x74F4F80
        public void Equals(){} // RVA: 0x74F4C30
        public void op_Equality(){} // RVA: 0x74F4DC0
        public void op_Inequality(){} // RVA: 0x74F4E80
        public void GetHashCodeDelegate(){} // RVA: 0x74F4FF0
        public void IsRandomizedHashingDisabled(){} // RVA: 0xB43320
        public void GetHashCodeOfString(){} // RVA: 0x34AC300
        public void Init(){} // RVA: 0x74F52F0
        public void SetNamespace(){} // RVA: 0xBA9BA0
        public void Verify(){} // RVA: 0x74F53B0
        public void Atomize(){} // RVA: 0x74F5450
        public void Parse(){} // RVA: 0x74F5560
        public void Clone(){} // RVA: 0x74F57A0
        public void .cctor(){} // RVA: 0x74F5820
    }

    public class XmlRawWriter : XmlWriter
    {
        public object base64Encoder;
        public object resolver;

        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7486C70
        public void WriteEndDocument(){} // RVA: 0x7486CD0
        public void WriteDocType(){} // RVA: 0xB43310
        public void WriteEndElement(){} // RVA: 0x8954D0
        public void WriteFullEndElement(){} // RVA: 0x7487210
        public void WriteBase64(){} // RVA: 0x7486DF0
        public void LookupPrefix(){} // RVA: 0x7486F50
        public void get_WriteState(){} // RVA: 0x7486FB0
        public void WriteCData(){} // RVA: 0x7485660
        public void WriteCharEntity(){} // RVA: 0x7487010
        public void WriteSurrogateCharEntity(){} // RVA: 0x74870A0
        public void WriteWhitespace(){} // RVA: 0x7485660
        public void WriteChars(){} // RVA: 0x1D55C90
        public void WriteRaw(){} // RVA: 0x7485660
        public void WriteValue(){} // RVA: 0x7485660
        public void WriteAttributes(){} // RVA: 0x7487150
        public void WriteNode(){} // RVA: 0x74871B0
        public void set_NamespaceResolver(){} // RVA: 0xB70100
        public void WriteXmlDeclaration(){} // RVA: 0xB43310
        public void StartElementContent(){} // RVA: 0x894290
        public void OnRootElement(){} // RVA: 0xB43310
        public void WriteNamespaceDeclaration(){} // RVA: 0x8943B0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0xB43320
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7487230
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7487270
        public void WriteEndBase64(){} // RVA: 0x74872B0
        public void Close(){} // RVA: 0x6812E50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlRawWriterBase64Encoder : Base64Encoder
    {
        public object rawWriter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x734DC00
        public void WriteChars(){} // RVA: 0x734DC70
    }

    public class XmlReader : Object
    {
        public object IsTextualNodeBitmap;
        public object CanReadContentAsBitmap;
        public object HasValueBitmap;

        // ── Methods ──
        public void get_Settings(){} // RVA: 0xDAC980
        public void get_NodeType(){} // RVA: 0x87C130
        public void get_Name(){} // RVA: 0x74872D0
        public void get_LocalName(){} // RVA: 0x87C0A0
        public void get_NamespaceURI(){} // RVA: 0x87C0A0
        public void get_Prefix(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0x87C0A0
        public void get_Depth(){} // RVA: 0x87C130
        public void get_BaseURI(){} // RVA: 0x87C0A0
        public void get_IsEmptyElement(){} // RVA: 0x87D280
        public void get_IsDefault(){} // RVA: 0xB43320
        public void get_QuoteChar(){} // RVA: 0x74873E0
        public void get_XmlSpace(){} // RVA: 0xDAC980
        public void get_XmlLang(){} // RVA: 0x1584680
        public void get_SchemaInfo(){} // RVA: 0x74873F0
        public void get_ValueType(){} // RVA: 0x7487430
        public void get_AttributeCount(){} // RVA: 0x87C130
        public void GetAttribute(){} // RVA: 0x87C160
        public void MoveToAttribute(){} // RVA: 0x7487490
        public void MoveToFirstAttribute(){} // RVA: 0x87D280
        public void MoveToNextAttribute(){} // RVA: 0x87D280
        public void MoveToElement(){} // RVA: 0x87D280
        public void ReadAttributeValue(){} // RVA: 0x87D280
        public void Read(){} // RVA: 0x87D280
        public void get_EOF(){} // RVA: 0x87D280
        public void Close(){} // RVA: 0xB43310
        public void get_ReadState(){} // RVA: 0x87C130
        public void Skip(){} // RVA: 0x7487560
        public void get_NameTable(){} // RVA: 0x87C0A0
        public void LookupNamespace(){} // RVA: 0x87C540
        public void get_CanResolveEntity(){} // RVA: 0xB43320
        public void ResolveEntity(){} // RVA: 0x894290
        public void get_CanReadValueChunk(){} // RVA: 0xB43320
        public void ReadValueChunk(){} // RVA: 0x7487670
        public void ReadString(){} // RVA: 0x74876D0
        public void MoveToContent(){} // RVA: 0x7487930
        public void ReadStartElement(){} // RVA: 0x74879D0
        public void ReadElementString(){} // RVA: 0x7487AD0
        public void ReadEndElement(){} // RVA: 0x7487D70
        public void IsStartElement(){} // RVA: 0x7487E70
        public void ReadInnerXml(){} // RVA: 0x7487F70
        public void WriteNode(){} // RVA: 0x7488400
        public void WriteAttributeValue(){} // RVA: 0x7488960
        public void CreateWriterForInnerOuterXml(){} // RVA: 0x7488A80
        public void SetNamespacesFlag(){} // RVA: 0x7488BB0
        public void get_HasAttributes(){} // RVA: 0x7488C90
        public void Dispose(){} // RVA: 0x7488CE0
        public void get_NamespaceManager(){} // RVA: 0xDAC980
        public void IsTextualNode(){} // RVA: 0x7488D20
        public void HasValueInternal(){} // RVA: 0x7488D90
        public void SkipSubtree(){} // RVA: 0x7488E00
        public void get_IsDefaultInternal(){} // RVA: 0x7488EF0
        public void get_DtdInfo(){} // RVA: 0xDAC980
        public void Create(){} // RVA: 0x74892E0
        public void CreateSqlReader(){} // RVA: 0x7489450
        public void CalcBufferSize(){} // RVA: 0x7489780
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7489820
    }

    public class XmlReaderSettings : Object
    {
        public object useAsync;
        public object nameTable;
        public object xmlResolver;
        public object lineNumberOffset;
        public object linePositionOffset;
        public object conformanceLevel;
        public object checkCharacters;
        public object maxCharactersInDocument;
        public object maxCharactersFromEntities;
        public object ignoreWhitespace;
        public object ignorePIs;
        public object ignoreComments;
        public object dtdProcessing;
        public object validationType;
        public object validationFlags;
        public object schemas;
        public object valEventHandler;
        public object closeInput;
        public object isReadOnly;
        public object _isXmlResolverSet;
        public object s_enableLegacyXmlSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7489890
        public void get_Async(){} // RVA: 0xC120A0
        public void set_Async(){} // RVA: 0x74898A0
        public void get_NameTable(){} // RVA: 0xB465B0
        public void set_NameTable(){} // RVA: 0x7489900
        public void get_IsXmlResolverSet(){} // RVA: 0x6573C70
        public void set_IsXmlResolverSet(){} // RVA: 0x6573C80
        public void set_XmlResolver(){} // RVA: 0x74899A0
        public void GetXmlResolver(){} // RVA: 0xB700F0
        public void GetXmlResolver_CheckConfig(){} // RVA: 0x7489A40
        public void get_LineNumberOffset(){} // RVA: 0x1065D50
        public void set_LineNumberOffset(){} // RVA: 0x7489A50
        public void get_LinePositionOffset(){} // RVA: 0x1AE5AC0
        public void set_LinePositionOffset(){} // RVA: 0x7489AA0
        public void get_ConformanceLevel(){} // RVA: 0xB9E080
        public void set_ConformanceLevel(){} // RVA: 0x7489AF0
        public void get_CheckCharacters(){} // RVA: 0xB78D60
        public void set_CheckCharacters(){} // RVA: 0x7489B90
        public void get_MaxCharactersInDocument(){} // RVA: 0xD05CA0
        public void set_MaxCharactersInDocument(){} // RVA: 0x7489BF0
        public void get_MaxCharactersFromEntities(){} // RVA: 0xBC1B30
        public void set_MaxCharactersFromEntities(){} // RVA: 0x7489C90
        public void get_IgnoreWhitespace(){} // RVA: 0xBFDA40
        public void set_IgnoreWhitespace(){} // RVA: 0x7489D30
        public void get_IgnoreProcessingInstructions(){} // RVA: 0x1C58C80
        public void set_IgnoreProcessingInstructions(){} // RVA: 0x7489D90
        public void get_IgnoreComments(){} // RVA: 0x1FA9920
        public void set_IgnoreComments(){} // RVA: 0x7489DF0
        public void get_DtdProcessing(){} // RVA: 0x1D46130
        public void set_DtdProcessing(){} // RVA: 0x7489E50
        public void get_CloseInput(){} // RVA: 0xC10030
        public void set_CloseInput(){} // RVA: 0x7489EF0
        public void get_ValidationType(){} // RVA: 0xE32C80
        public void set_ValidationType(){} // RVA: 0x7489F50
        public void get_ValidationFlags(){} // RVA: 0x15443F0
        public void set_ValidationFlags(){} // RVA: 0x7489FF0
        public void get_Schemas(){} // RVA: 0x748A090
        public void set_Schemas(){} // RVA: 0x748A140
        public void Clone(){} // RVA: 0x748A1E0
        public void GetEventHandler(){} // RVA: 0xBE2C60
        public void CreateReader(){} // RVA: 0x748A3D0
        public void set_ReadOnly(){} // RVA: 0x6296250
        public void CheckReadOnly(){} // RVA: 0x748A500
        public void Initialize(){} // RVA: 0x748A5B0
        public void CreateDefaultResolver(){} // RVA: 0x748A7D0
        public void AddValidation(){} // RVA: 0x748A810
        public void CreateDtdValidatingReader(){} // RVA: 0x748A940
        public void EnableLegacyXmlSettings(){} // RVA: 0x748A9D0
    }

    public class XmlRegisteredNonCachedStream : Stream
    {
        public object stream;
        public object downloadManager;
        public object host;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74EEA50
        public void Finalize(){} // RVA: 0x74EEBB0
        public void Dispose(){} // RVA: 0x74EEC60
        public void BeginRead(){} // RVA: 0x74EEDA0
        public void BeginWrite(){} // RVA: 0x74EEDE0
        public void EndRead(){} // RVA: 0x74EEE20
        public void EndWrite(){} // RVA: 0x7250A00
        public void Flush(){} // RVA: 0x6E861D0
        public void Read(){} // RVA: 0x74EEE50
        public void ReadByte(){} // RVA: 0x6881B80
        public void Seek(){} // RVA: 0x74EEE80
        public void SetLength(){} // RVA: 0x70F92B0
        public void Write(){} // RVA: 0x74EEEB0
        public void WriteByte(){} // RVA: 0x74EEEE0
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_CanWrite(){} // RVA: 0x74EEF10
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x7479BC0
    }

    public class XmlResolver : Object
    {
        // ── Methods ──
        public void GetEntity(){} // RVA: 0x882090
        public void ResolveUri(){} // RVA: 0x74F5980
        public void SupportsType(){} // RVA: 0x74F5C80
        public void GetEntityAsync(){} // RVA: 0x74F5DC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlSignificantWhitespace : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D2370
        public void get_Name(){} // RVA: 0x74D2470
        public void get_LocalName(){} // RVA: 0x74D2470
        public void get_NodeType(){} // RVA: 0x20237F0
        public void get_ParentNode(){} // RVA: 0x74D24A0
        public void CloneNode(){} // RVA: 0x74D2550
        public void get_Value(){} // RVA: 0x69358F0
        public void set_Value(){} // RVA: 0x74D25C0
        public void WriteTo(){} // RVA: 0x74D26C0
        public void WriteContentTo(){} // RVA: 0xB43310
        public void get_IsText(){} // RVA: 0xC2E4C0
    }

    public class XmlSqlBinaryReader : XmlReader
    {
        public object TypeOfObject;
        public object TypeOfString;
        public object TokenTypeMap;
        public object XsdKatmaiTimeScaleToValueLengthMap;
        public object ScanState2ReadState;
        public object inStrm;
        public object data;
        public object pos;
        public object mark;
        public object end;
        public object offset;
        public object eof;
        public object sniffed;
        public object isEmpty;
        public object docState;
        public object symbolTables;
        public object xnt;
        public object xntFromSettings;
        public object xml;
        public object xmlns;
        public object nsxmlns;
        public object baseUri;
        public object state;
        public object nodetype;
        public object token;
        public object attrIndex;
        public object qnameOther;
        public object qnameElement;
        public object parentNodeType;
        public object elementStack;
        public object elemDepth;
        public object attributes;
        public object attrHashTbl;
        public object attrCount;
        public object posAfterAttrs;
        public object xmlspacePreserve;
        public object tokLen;
        public object tokDataPos;
        public object hasTypedValue;
        public object valueType;
        public object stringValue;
        public object namespaces;
        public object prevNameInfo;
        public object textXmlReader;
        public object closeInput;
        public object checkCharacters;
        public object ignoreWhitespace;
        public object ignorePIs;
        public object ignoreComments;
        public object dtdProcessing;
        public object hasher;
        public object xmlCharType;
        public object unicode;
        public object version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73537E0
        public void get_Settings(){} // RVA: 0x7354290
        public void get_NodeType(){} // RVA: 0xF3A940
        public void get_LocalName(){} // RVA: 0x12EB090
        public void get_NamespaceURI(){} // RVA: 0xBAE340
        public void get_Prefix(){} // RVA: 0x106A050
        public void get_Value(){} // RVA: 0x7354530
        public void get_Depth(){} // RVA: 0x7354960
        public void get_BaseURI(){} // RVA: 0xB813B0
        public void get_IsEmptyElement(){} // RVA: 0x7354A30
        public void get_XmlSpace(){} // RVA: 0x7354A50
        public void get_XmlLang(){} // RVA: 0x7354AE0
        public void get_ValueType(){} // RVA: 0xD9E3D0
        public void get_AttributeCount(){} // RVA: 0x7354B80
        public void GetAttribute(){} // RVA: 0x7354E00
        public void MoveToAttribute(){} // RVA: 0x7354F40
        public void MoveToFirstAttribute(){} // RVA: 0x7354FF0
        public void MoveToNextAttribute(){} // RVA: 0x7355080
        public void MoveToElement(){} // RVA: 0x7355130
        public void get_EOF(){} // RVA: 0x73552E0
        public void ReadAttributeValue(){} // RVA: 0x73552F0
        public void Close(){} // RVA: 0x7355530
        public void get_NameTable(){} // RVA: 0xBE2C60
        public void LookupNamespace(){} // RVA: 0x73556C0
        public void ResolveEntity(){} // RVA: 0x7355790
        public void get_ReadState(){} // RVA: 0x73557D0
        public void Read(){} // RVA: 0x7355850
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x73559D0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7355E90
        public void VerifyVersion(){} // RVA: 0x7356020
        public void AddInitNamespace(){} // RVA: 0x7356070
        public void AddName(){} // RVA: 0x73561E0
        public void AddQName(){} // RVA: 0x7356330
        public void NameFlush(){} // RVA: 0x73566B0
        public void SkipExtn(){} // RVA: 0x7356710
        public void ReadQNameRef(){} // RVA: 0x7356850
        public void ReadNameRef(){} // RVA: 0x7356920
        public void FillAllowEOF(){} // RVA: 0x73569F0
        public void Fill_(){} // RVA: 0x7356C40
        public void Fill(){} // RVA: 0x7356CC0
        public void ReadByte(){} // RVA: 0x7356D50
        public void ReadUShort(){} // RVA: 0x7356DA0
        public void ParseMB32(){} // RVA: 0x7356FC0
        public void ParseMB32_(){} // RVA: 0x7356E60
        public void ParseMB64(){} // RVA: 0x7356E00
        public void PeekToken(){} // RVA: 0x73570E0
        public void ReadToken(){} // RVA: 0x7357360
        public void NextToken2(){} // RVA: 0x73575E0
        public void NextToken1(){} // RVA: 0x7357920
        public void NextToken(){} // RVA: 0x7357990
        public void PeekNextToken(){} // RVA: 0x7357A30
        public void RescanNextToken(){} // RVA: 0x7357A50
        public void ParseText(){} // RVA: 0x7357D00
        public void ScanText(){} // RVA: 0x7357DC0
        public void GetString(){} // RVA: 0x7357F20
        public void GetStringAligned(){} // RVA: 0x73580E0
        public void GetAttributeText(){} // RVA: 0x7358120
        public void LocateAttribute(){} // RVA: 0x73583B0
        public void PositionOnAttribute(){} // RVA: 0x7358510
        public void GrowElements(){} // RVA: 0x7358700
        public void GrowAttributes(){} // RVA: 0x7358800
        public void ClearAttributes(){} // RVA: 0x73588E0
        public void PushNamespace(){} // RVA: 0x7358900
        public void PopNamespaces(){} // RVA: 0x7358C50
        public void GenerateImpliedXmlnsAttrs(){} // RVA: 0x7358D50
        public void ReadInit(){} // RVA: 0x7358ED0
        public void ScanAttributes(){} // RVA: 0x7359500
        public void SimpleCheckForDuplicateAttributes(){} // RVA: 0x7359C20
        public void HashCheckForDuplicateAttributes(){} // RVA: 0x7359F20
        public void XmlDeclValue(){} // RVA: 0x735A3E0
        public void CDATAValue(){} // RVA: 0x735A550
        public void FinishCDATA(){} // RVA: 0x735A6D0
        public void FinishEndElement(){} // RVA: 0x735A770
        public void ReadDoc(){} // RVA: 0x735A8F0
        public void ImplReadData(){} // RVA: 0x735B120
        public void ImplReadElement(){} // RVA: 0x735B370
        public void ImplReadEndElement(){} // RVA: 0x735B970
        public void ImplReadDoctype(){} // RVA: 0x735BAA0
        public void ImplReadPI(){} // RVA: 0x735BEA0
        public void ImplReadComment(){} // RVA: 0x735BF60
        public void ImplReadCDATA(){} // RVA: 0x735BFA0
        public void ImplReadNest(){} // RVA: 0x735C030
        public void ImplReadEndNest(){} // RVA: 0x735C220
        public void ImplReadXmlText(){} // RVA: 0x735C310
        public void UpdateFromTextReader(){} // RVA: 0x735CC70
        public void CheckAllowContent(){} // RVA: 0x735CC90
        public void GenerateTokenTypeMap(){} // RVA: 0x735CCF0
        public void GetValueType(){} // RVA: 0x735DE10
        public void ReScanOverValue(){} // RVA: 0x735DEF0
        public void ScanOverValue(){} // RVA: 0x735DF10
        public void ScanOverAnyValue(){} // RVA: 0x735E130
        public void CheckText(){} // RVA: 0x735E7C0
        public void CheckTextIsWS(){} // RVA: 0x735EA00
        public void CheckValueTokenBounds(){} // RVA: 0x735EAA0
        public void GetXsdKatmaiTokenLength(){} // RVA: 0x735EB00
        public void XsdKatmaiTimeScaleToValueLength(){} // RVA: 0x735EC60
        public void ValueAsLong(){} // RVA: 0x735ED30
        public void ValueAsULong(){} // RVA: 0x735F2C0
        public void ValueAsDecimal(){} // RVA: 0x735F360
        public void ValueAsDouble(){} // RVA: 0x735F680
        public void ValueAsDateTimeString(){} // RVA: 0x735F880
        public void ValueAsString(){} // RVA: 0x735FE90
        public void GetInt16(){} // RVA: 0x7360810
        public void GetUInt16(){} // RVA: 0x7360810
        public void GetInt32(){} // RVA: 0x7360860
        public void GetUInt32(){} // RVA: 0x7360860
        public void GetInt64(){} // RVA: 0x73608E0
        public void GetUInt64(){} // RVA: 0x73608E0
        public void GetSingle(){} // RVA: 0x7360A00
        public void GetDouble(){} // RVA: 0x7360A80
        public void ThrowUnexpectedToken(){} // RVA: 0x7360BE0
        public void ThrowXmlException(){} // RVA: 0x7360CB0
        public void ThrowNotSupported(){} // RVA: 0x7360DA0
        public void .cctor(){} // RVA: 0x7360E10
    }

    public class XmlText : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B44A0
        public void get_Name(){} // RVA: 0x74D2720
        public void get_LocalName(){} // RVA: 0x74D2720
        public void get_NodeType(){} // RVA: 0x12FC4A0
        public void get_ParentNode(){} // RVA: 0x74B44E0
        public void CloneNode(){} // RVA: 0x74D2750
        public void get_Value(){} // RVA: 0x69358F0
        public void set_Value(){} // RVA: 0x74D27C0
        public void WriteTo(){} // RVA: 0x74D26C0
        public void WriteContentTo(){} // RVA: 0xB43310
        public void get_IsText(){} // RVA: 0xC2E4C0
    }

    public class XmlTextEncoder : Object
    {
        public object textWriter;
        public object inAttribute;
        public object quoteChar;
        public object attrValue;
        public object cacheAttrValue;
        public object xmlCharType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x748AA80
        public void set_QuoteChar(){} // RVA: 0x6536960
        public void StartAttribute(){} // RVA: 0x748AB60
        public void EndAttribute(){} // RVA: 0x748AC30
        public void get_AttributeValue(){} // RVA: 0x748AC70
        public void WriteSurrogateChar(){} // RVA: 0x748ACC0
        public void Write(){} // RVA: 0x748B510
        public void WriteSurrogateCharEntity(){} // RVA: 0x748B2D0
        public void WriteRawWithSurrogateChecking(){} // RVA: 0x748BAA0
        public void WriteRaw(){} // RVA: 0x748BCF0
        public void WriteCharEntity(){} // RVA: 0x748BEB0
        public void WriteEntityRef(){} // RVA: 0x748C0A0
        public void WriteStringFragment(){} // RVA: 0x748C120
        public void WriteCharEntityImpl(){} // RVA: 0x748C2E0
        public void WriteEntityRefImpl(){} // RVA: 0x748C390
    }

    public class XmlTextReader : XmlReader
    {
        public object impl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x748C910
        public void get_NodeType(){} // RVA: 0x10AD460
        public void get_Name(){} // RVA: 0x6AE07D0
        public void get_LocalName(){} // RVA: 0x1085C80
        public void get_NamespaceURI(){} // RVA: 0x678C220
        public void get_Prefix(){} // RVA: 0x678C250
        public void get_Value(){} // RVA: 0x22368C0
        public void get_Depth(){} // RVA: 0x7048FE0
        public void get_BaseURI(){} // RVA: 0x10ADE70
        public void get_IsEmptyElement(){} // RVA: 0x10AD020
        public void get_IsDefault(){} // RVA: 0x10AE060
        public void get_QuoteChar(){} // RVA: 0x10AD890
        public void get_XmlSpace(){} // RVA: 0x10ACFC0
        public void get_XmlLang(){} // RVA: 0x10AC4B0
        public void get_AttributeCount(){} // RVA: 0x6E669C0
        public void GetAttribute(){} // RVA: 0x71DA4B0
        public void MoveToAttribute(){} // RVA: 0x71DA510
        public void MoveToFirstAttribute(){} // RVA: 0x678C400
        public void MoveToNextAttribute(){} // RVA: 0x687B750
        public void MoveToElement(){} // RVA: 0x687B780
        public void ReadAttributeValue(){} // RVA: 0x6ADFF00
        public void Read(){} // RVA: 0x71DA540
        public void get_EOF(){} // RVA: 0x71DA570
        public void Close(){} // RVA: 0x6AE0990
        public void get_ReadState(){} // RVA: 0x71DA5A0
        public void Skip(){} // RVA: 0x66B0FE0
        public void get_NameTable(){} // RVA: 0x6ADFA50
        public void LookupNamespace(){} // RVA: 0x748CA90
        public void get_CanResolveEntity(){} // RVA: 0xC2E4C0
        public void ResolveEntity(){} // RVA: 0x71DA630
        public void get_CanReadValueChunk(){} // RVA: 0xB43320
        public void ReadString(){} // RVA: 0x748CAD0
        public void HasLineInfo(){} // RVA: 0xC2E4C0
        public void get_LineNumber(){} // RVA: 0x748CB00
        public void get_LinePosition(){} // RVA: 0x748CB30
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x748CB60
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x71DA5D0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x748CBA0
        public void get_Namespaces(){} // RVA: 0x1890380
        public void get_Normalization(){} // RVA: 0x748CBE0
        public void set_Normalization(){} // RVA: 0x748CC00
        public void set_WhitespaceHandling(){} // RVA: 0x748CCE0
        public void set_EntityHandling(){} // RVA: 0x748CDE0
        public void set_XmlResolver(){} // RVA: 0x748CE80
        public void get_Impl(){} // RVA: 0xB5DBF0
        public void get_NamespaceManager(){} // RVA: 0x748CEA0
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x748CED0
        public void get_DtdInfo(){} // RVA: 0x748CEF0
    }

    public class XmlTextReaderImpl : XmlReader
    {
        public object useAsync;
        public object laterInitParam;
        public object xmlCharType;
        public object ps;
        public object parsingFunction;
        public object nextParsingFunction;
        public object nextNextParsingFunction;
        public object nodes;
        public object curNode;
        public object index;
        public object curAttrIndex;
        public object attrCount;
        public object attrHashtable;
        public object attrDuplWalkCount;
        public object attrNeedNamespaceLookup;
        public object fullAttrCleanup;
        public object attrDuplSortingArray;
        public object nameTable;
        public object nameTableFromSettings;
        public object xmlResolver;
        public object url;
        public object normalize;
        public object supportNamespaces;
        public object whitespaceHandling;
        public object dtdProcessing;
        public object entityHandling;
        public object ignorePIs;
        public object ignoreComments;
        public object checkCharacters;
        public object lineNumberOffset;
        public object linePositionOffset;
        public object closeInput;
        public object maxCharactersInDocument;
        public object maxCharactersFromEntities;
        public object v1Compat;
        public object namespaceManager;
        public object lastPrefix;
        public object xmlContext;
        public object parsingStatesStack;
        public object parsingStatesStackTop;
        public object reportedBaseUri;
        public object reportedEncoding;
        public object dtdInfo;
        public object fragmentType;
        public object fragmentParserContext;
        public object fragment;
        public object incReadDecoder;
        public object incReadState;
        public object incReadLineInfo;
        public object incReadDepth;
        public object incReadLeftStartPos;
        public object incReadLeftEndPos;
        public object attributeValueBaseEntityId;
        public object emptyEntityInAttributeResolved;
        public object validationEventHandling;
        public object onDefaultAttributeUse;
        public object validatingReaderCompatFlag;
        public object addDefaultAttributesAndNormalize;
        public object stringBuilder;
        public object rootElementParsed;
        public object standalone;
        public object nextEntityId;
        public object parsingMode;
        public object readState;
        public object lastEntity;
        public object afterResetState;
        public object documentStartBytePos;
        public object readValueOffset;
        public object charactersInDocument;
        public object charactersFromEntities;
        public object currentEntities;
        public object disableUndeclaredEntityCheck;
        public object outerReader;
        public object xmlResolverIsSet;
        public object Xml;
        public object XmlNs;
        public object parseText_dummyTask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73794B0
        public void FinishInitUriString(){} // RVA: 0x7378650
        public void FinishInitStream(){} // RVA: 0x7378FA0
        public void FinishInitTextReader(){} // RVA: 0x7379370
        public void get_Settings(){} // RVA: 0x73795F0
        public void get_NodeType(){} // RVA: 0x73799B0
        public void get_Name(){} // RVA: 0x73799D0
        public void get_LocalName(){} // RVA: 0x7379A00
        public void get_NamespaceURI(){} // RVA: 0x7379A20
        public void get_Prefix(){} // RVA: 0x7379A40
        public void get_Value(){} // RVA: 0x7379A60
        public void get_Depth(){} // RVA: 0x7379BC0
        public void get_BaseURI(){} // RVA: 0x1143F90
        public void get_IsEmptyElement(){} // RVA: 0x7379BE0
        public void get_IsDefault(){} // RVA: 0x7379C10
        public void get_QuoteChar(){} // RVA: 0x7379C40
        public void get_XmlSpace(){} // RVA: 0x7379C70
        public void get_XmlLang(){} // RVA: 0x7379C90
        public void get_ReadState(){} // RVA: 0x7379CB0
        public void get_EOF(){} // RVA: 0x7379CC0
        public void get_NameTable(){} // RVA: 0xBC5B30
        public void get_CanResolveEntity(){} // RVA: 0xC2E4C0
        public void get_AttributeCount(){} // RVA: 0x12CE7D0
        public void GetAttribute(){} // RVA: 0x7379EB0
        public void MoveToAttribute(){} // RVA: 0x737A070
        public void MoveToFirstAttribute(){} // RVA: 0x737A1A0
        public void MoveToNextAttribute(){} // RVA: 0x737A260
        public void MoveToElement(){} // RVA: 0x737A340
        public void FinishInit(){} // RVA: 0x737A410
        public void Read(){} // RVA: 0x737A460
        public void Close(){} // RVA: 0x7380C90
        public void Skip(){} // RVA: 0x737ACF0
        public void LookupNamespace(){} // RVA: 0x738DC50
        public void ReadAttributeValue(){} // RVA: 0x737AF50
        public void ResolveEntity(){} // RVA: 0x737B280
        public void set_OuterReader(){} // RVA: 0x163A9E0
        public void MoveOffEntityReference(){} // RVA: 0x737B520
        public void ReadString(){} // RVA: 0x737B5F0
        public void get_CanReadValueChunk(){} // RVA: 0xC2E4C0
        public void ReadValueChunk(){} // RVA: 0x737B610
        public void HasLineInfo(){} // RVA: 0xC2E4C0
        public void get_LineNumber(){} // RVA: 0x737BBE0
        public void get_LinePosition(){} // RVA: 0x737BC00
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x737BC20
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7120CC0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x737BC50
        public void GetNamespacesInScope(){} // RVA: 0x737BC20
        public void LookupPrefix(){} // RVA: 0x737BC50
        public void get_Namespaces(){} // RVA: 0x24440E0
        public void set_Namespaces(){} // RVA: 0x737BC80
        public void get_Normalization(){} // RVA: 0x2443BA0
        public void set_Normalization(){} // RVA: 0x737BF70
        public void set_WhitespaceHandling(){} // RVA: 0x737C050
        public void set_EntityHandling(){} // RVA: 0x737C130
        public void get_IsResolverSet(){} // RVA: 0x737C1C0
        public void set_XmlResolver(){} // RVA: 0x737C1D0
        public void get_DtdParserProxy_NameTable(){} // RVA: 0xBC5B30
        public void get_DtdParserProxy_NamespaceResolver(){} // RVA: 0x135A170
        public void get_DtdParserProxy_DtdValidation(){} // RVA: 0x737C350
        public void get_DtdParserProxy_Normalization(){} // RVA: 0x2443BA0
        public void get_DtdParserProxy_Namespaces(){} // RVA: 0x24440E0
        public void get_DtdParserProxy_V1CompatibilityMode(){} // RVA: 0x737C360
        public void get_DtdParserProxy_BaseUri(){} // RVA: 0x737C370
        public void get_DtdParserProxy_IsEof(){} // RVA: 0x1C556E0
        public void get_DtdParserProxy_ParsingBuffer(){} // RVA: 0xB70160
        public void get_DtdParserProxy_ParsingBufferLength(){} // RVA: 0xE9CE60
        public void get_DtdParserProxy_CurrentPosition(){} // RVA: 0xB9E080
        public void set_DtdParserProxy_CurrentPosition(){} // RVA: 0xB9E090
        public void get_DtdParserProxy_EntityStackLength(){} // RVA: 0x737C430
        public void get_DtdParserProxy_IsEntityEolNormalized(){} // RVA: 0x6DE6270
        public void get_DtdParserProxy_ValidationEventHandling(){} // RVA: 0x1659CB0
        public void DtdParserProxy_OnNewLine(){} // RVA: 0x737C440
        public void get_DtdParserProxy_LineNo(){} // RVA: 0x19C6270
        public void get_DtdParserProxy_LineStartPosition(){} // RVA: 0x21EA4F0
        public void DtdParserProxy_ReadData(){} // RVA: 0x737C450
        public void DtdParserProxy_ParseNumericCharRef(){} // RVA: 0x737C460
        public void DtdParserProxy_ParseNamedCharRef(){} // RVA: 0x737C510
        public void DtdParserProxy_ParsePI(){} // RVA: 0x737C520
        public void DtdParserProxy_ParseComment(){} // RVA: 0x737C570
        public void get_IsResolverNull(){} // RVA: 0x737CD70
        public void GetTempResolver(){} // RVA: 0x737CD80
        public void DtdParserProxy_PushEntity(){} // RVA: 0x737CDE0
        public void DtdParserProxy_PopEntity(){} // RVA: 0x737CEA0
        public void DtdParserProxy_PushExternalSubset(){} // RVA: 0x737CF90
        public void DtdParserProxy_PushInternalDtd(){} // RVA: 0x737D130
        public void DtdParserProxy_Throw(){} // RVA: 0x737D210
        public void DtdParserProxy_OnSystemId(){} // RVA: 0x737D220
        public void DtdParserProxy_OnPublicId(){} // RVA: 0x737D300
        public void Throw(){} // RVA: 0x737D830
        public void ReThrow(){} // RVA: 0x737D8D0
        public void ThrowWithoutLineInfo(){} // RVA: 0x737DA80
        public void ThrowInvalidChar(){} // RVA: 0x737DB10
        public void SetErrorState(){} // RVA: 0x737DB80
        public void SendValidationEvent(){} // RVA: 0x737DC90
        public void get_InAttributeValueIterator(){} // RVA: 0x737DD00
        public void FinishAttributeValueIterator(){} // RVA: 0x737DD20
        public void get_DtdValidation(){} // RVA: 0x737C350
        public void InitStreamInput(){} // RVA: 0x737DF00
        public void InitTextReaderInput(){} // RVA: 0x737E5E0
        public void InitStringInput(){} // RVA: 0x737E850
        public void InitFragmentReader(){} // RVA: 0x737EA90
        public void ProcessDtdFromParserContext(){} // RVA: 0x737F060
        public void OpenUrl(){} // RVA: 0x737F0D0
        public void OpenUrlDelegate(){} // RVA: 0x737F380
        public void DetectEncoding(){} // RVA: 0x737F570
        public void SetupEncoding(){} // RVA: 0x737F7B0
        public void SwitchEncoding(){} // RVA: 0x737FAC0
        public void CheckEncoding(){} // RVA: 0x737FC80
        public void UnDecodeChars(){} // RVA: 0x7380350
        public void SwitchEncodingToUTF8(){} // RVA: 0x7380400
        public void ReadData(){} // RVA: 0x73804A0
        public void GetChars(){} // RVA: 0x7380A40
        public void InvalidCharRecovery(){} // RVA: 0x7380B20
        public void ShiftBuffer(){} // RVA: 0x7380FB0
        public void ParseXmlDeclaration(){} // RVA: 0x7380FE0
        public void ParseDocumentContent(){} // RVA: 0x7382430
        public void ParseElementContent(){} // RVA: 0x7382A80
        public void ThrowUnclosedElements(){} // RVA: 0x7382E60
        public void ParseElement(){} // RVA: 0x7383050
        public void AddDefaultAttributesAndNormalize(){} // RVA: 0x7383650
        public void ParseEndElement(){} // RVA: 0x7383D00
        public void ThrowTagMismatch(){} // RVA: 0x7384260
        public void ParseAttributes(){} // RVA: 0x7384440
        public void ElementNamespaceLookup(){} // RVA: 0x7384A80
        public void AttributeNamespaceLookup(){} // RVA: 0x7384BB0
        public void AttributeDuplCheck(){} // RVA: 0x7384C80
        public void OnDefaultNamespaceDecl(){} // RVA: 0x73850A0
        public void OnNamespaceDecl(){} // RVA: 0x7385280
        public void OnXmlReservedAttribute(){} // RVA: 0x7385370
        public void ParseAttributeValueSlow(){} // RVA: 0x7385690
        public void AddAttributeChunkToList(){} // RVA: 0x7386960
        public void ParseText(){} // RVA: 0x7386F40
        public void FinishPartialValue(){} // RVA: 0x7387640
        public void FinishOtherValueIterator(){} // RVA: 0x7387B90
        public void SkipPartialTextValue(){} // RVA: 0x7387CC0
        public void FinishReadValueChunk(){} // RVA: 0x7387D20
        public void FinishReadContentAsBinary(){} // RVA: 0x7387D60
        public void FinishReadElementContentAsBinary(){} // RVA: 0x7387EC0
        public void ParseRootLevelWhitespace(){} // RVA: 0x7387F90
        public void ParseEntityReference(){} // RVA: 0x73881C0
        public void HandleEntityReference(){} // RVA: 0x7388240
        public void HandleGeneralEntityReference(){} // RVA: 0x73884E0
        public void get_InEntity(){} // RVA: 0x7388920
        public void HandleEntityEnd(){} // RVA: 0x7388930
        public void SetupEndEntityNodeInContent(){} // RVA: 0x7388BC0
        public void SetupEndEntityNodeInAttribute(){} // RVA: 0x7388DE0
        public void ParsePI(){} // RVA: 0x7388EC0
        public void ParsePIValue(){} // RVA: 0x7389700
        public void ParseComment(){} // RVA: 0x7389A90
        public void ParseCData(){} // RVA: 0x738A030
        public void ParseCDataOrComment(){} // RVA: 0x738A560
        public void ParseDoctypeDecl(){} // RVA: 0x738A990
        public void ParseDtd(){} // RVA: 0x738ACE0
        public void SkipDtd(){} // RVA: 0x738B050
        public void SkipPublicOrSystemIdLiteral(){} // RVA: 0x738B790
        public void SkipUntil(){} // RVA: 0x738B830
        public void EatWhitespaces(){} // RVA: 0x738BCE0
        public void ParseCharRefInline(){} // RVA: 0x738BF30
        public void ParseNumericCharRef(){} // RVA: 0x738BFB0
        public void ParseNumericCharRefInline(){} // RVA: 0x738C080
        public void ParseNamedCharRef(){} // RVA: 0x738C870
        public void ParseNamedCharRefInline(){} // RVA: 0x738CBB0
        public void ParseName(){} // RVA: 0x738CEC0
        public void ParseQName(){} // RVA: 0x738CF10
        public void ReadDataInName(){} // RVA: 0x738D1B0
        public void ParseEntityName(){} // RVA: 0x738D1F0
        public void AddNode(){} // RVA: 0x738D2F0
        public void AllocNode(){} // RVA: 0x738D340
        public void AddAttributeNoChecks(){} // RVA: 0x738D500
        public void AddAttribute(){} // RVA: 0x738D8B0
        public void PopElementContext(){} // RVA: 0x738DA50
        public void OnNewLine(){} // RVA: 0x737C440
        public void OnEof(){} // RVA: 0x738DB10
        public void AddNamespace(){} // RVA: 0x738DD30
        public void ResetAttributes(){} // RVA: 0x738DFF0
        public void FullAttributeCleanup(){} // RVA: 0x738E120
        public void PushXmlContext(){} // RVA: 0x738E220
        public void PopXmlContext(){} // RVA: 0x738E3E0
        public void GetWhitespaceType(){} // RVA: 0x738E470
        public void GetTextNodeType(){} // RVA: 0x738E4C0
        public void PushExternalEntityOrSubset(){} // RVA: 0x738E520
        public void OpenAndPush(){} // RVA: 0x738E870
        public void PushExternalEntity(){} // RVA: 0x738EBA0
        public void PushInternalEntity(){} // RVA: 0x738ED90
        public void PopEntity(){} // RVA: 0x738EF00
        public void RegisterEntity(){} // RVA: 0x738EFA0
        public void UnregisterEntity(){} // RVA: 0x738F2B0
        public void PushParsingState(){} // RVA: 0x738F320
        public void PopParsingState(){} // RVA: 0x738F5B0
        public void IncrementalRead(){} // RVA: 0x738F6F0
        public void FinishIncrementalRead(){} // RVA: 0x7390480
        public void ParseFragmentAttribute(){} // RVA: 0x7390590
        public void ParseAttributeValueChunk(){} // RVA: 0x7390630
        public void ParseXmlDeclarationFragment(){} // RVA: 0x7390D90
        public void ThrowUnexpectedToken(){} // RVA: 0x7390E70
        public void ParseUnexpectedToken(){} // RVA: 0x7390FF0
        public void ThrowExpectingWhitespace(){} // RVA: 0x73910D0
        public void GetIndexOfAttributeWithoutPrefix(){} // RVA: 0x7391160
        public void GetIndexOfAttributeWithPrefix(){} // RVA: 0x7391240
        public void ZeroEndingStream(){} // RVA: 0x7391320
        public void ParseDtdFromParserContext(){} // RVA: 0x7391390
        public void MoveToNextContentNode(){} // RVA: 0x73915F0
        public void SetupFromParserContext(){} // RVA: 0x7391700
        public void get_DtdInfo(){} // RVA: 0x10F9C30
        public void SetDtdInfo(){} // RVA: 0x7391B20
        public void set_ValidationEventHandling(){} // RVA: 0x163A980
        public void set_OnDefaultAttributeUse(){} // RVA: 0x1662780
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7391C20
        public void get_FragmentType(){} // RVA: 0x113AF20
        public void ChangeCurrentNodeType(){} // RVA: 0x7391D10
        public void GetResolver(){} // RVA: 0x7391D30
        public void set_InternalSchemaType(){} // RVA: 0x7391D50
        public void get_InternalTypedValue(){} // RVA: 0x7391DC0
        public void set_InternalTypedValue(){} // RVA: 0x7391DF0
        public void get_StandAlone(){} // RVA: 0x7391E60
        public void get_NamespaceManager(){} // RVA: 0x135A170
        public void get_V1Compat(){} // RVA: 0x737C360
        public void AddDefaultAttributeDtd(){} // RVA: 0x7391E70
        public void AddDefaultAttributeNonDtd(){} // RVA: 0x7392230
        public void AddDefaultAttributeInternal(){} // RVA: 0x7392590
        public void set_DisableUndeclaredEntityCheck(){} // RVA: 0x73928F0
        public void UriEqual(){} // RVA: 0x7392900
        public void RegisterConsumedCharacters(){} // RVA: 0x7392A10
        public void StripSpaces(){} // RVA: 0x7392D80
        public void BlockCopyChars(){} // RVA: 0x69E5CD0
        public void BlockCopy(){} // RVA: 0x7392EE0
    }

    public class XmlTextWriter : XmlWriter
    {
        public object textWriter;
        public object xmlEncoder;
        public object encoding;
        public object formatting;
        public object indented;
        public object indentation;
        public object indentChar;
        public object stack;
        public object top;
        public object stateTable;
        public object currentState;
        public object lastToken;
        public object base64Encoder;
        public object quoteChar;
        public object curQuoteChar;
        public object namespaces;
        public object specialAttr;
        public object prefixForXmlNs;
        public object flush;
        public object nsStack;
        public object nsTop;
        public object nsHashtable;
        public object useNsHashtable;
        public object xmlCharType;
        public object stateName;
        public object tokenName;
        public object stateTableDefault;
        public object stateTableDocument;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x748F9B0
        public void get_BaseStream(){} // RVA: 0x748FB70
        public void set_Namespaces(){} // RVA: 0x748FBF0
        public void set_Formatting(){} // RVA: 0x748FC70
        public void set_QuoteChar(){} // RVA: 0x748FC80
        public void WriteStartDocument(){} // RVA: 0x748FD30
        public void WriteEndDocument(){} // RVA: 0x748FD50
        public void WriteDocType(){} // RVA: 0x748FF40
        public void WriteStartElement(){} // RVA: 0x74903A0
        public void WriteEndElement(){} // RVA: 0x7490930
        public void WriteFullEndElement(){} // RVA: 0x7490940
        public void WriteStartAttribute(){} // RVA: 0x7490950
        public void WriteEndAttribute(){} // RVA: 0x7491130
        public void WriteCData(){} // RVA: 0x7491180
        public void WriteComment(){} // RVA: 0x74914C0
        public void WriteProcessingInstruction(){} // RVA: 0x7491830
        public void WriteEntityRef(){} // RVA: 0x7491C30
        public void WriteCharEntity(){} // RVA: 0x7491D10
        public void WriteWhitespace(){} // RVA: 0x7491D80
        public void WriteString(){} // RVA: 0x7491EC0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7491F40
        public void WriteChars(){} // RVA: 0x7491FD0
        public void WriteRaw(){} // RVA: 0x7492110
        public void WriteBase64(){} // RVA: 0x7492180
        public void WriteBinHex(){} // RVA: 0x7492330
        public void get_WriteState(){} // RVA: 0x74923C0
        public void Close(){} // RVA: 0x7492430
        public void Flush(){} // RVA: 0x7492540
        public void LookupPrefix(){} // RVA: 0x7492570
        public void StartDocument(){} // RVA: 0x7492680
        public void AutoComplete(){} // RVA: 0x7492A50
        public void AutoCompleteAll(){} // RVA: 0x7493070
        public void InternalWriteEndElement(){} // RVA: 0x74930D0
        public void WriteEndStartTag(){} // RVA: 0x74934F0
        public void WriteEndAttributeQuote(){} // RVA: 0x7493950
        public void Indent(){} // RVA: 0x74939D0
        public void PushNamespace(){} // RVA: 0x7493AC0
        public void AddNamespace(){} // RVA: 0x7493E00
        public void AddToNamespaceHashtable(){} // RVA: 0x7494180
        public void PopNamespaces(){} // RVA: 0x74942C0
        public void GeneratePrefix(){} // RVA: 0x74943F0
        public void InternalWriteProcessingInstruction(){} // RVA: 0x7494630
        public void LookupNamespace(){} // RVA: 0x7494750
        public void LookupNamespaceInCurrentScope(){} // RVA: 0x74948B0
        public void FindPrefix(){} // RVA: 0x7494A70
        public void ValidateName(){} // RVA: 0x7494B80
        public void HandleSpecialAttribute(){} // RVA: 0x7494E00
        public void VerifyPrefixXml(){} // RVA: 0x7495110
        public void PushStack(){} // RVA: 0x7495210
        public void FlushEncoders(){} // RVA: 0x7495440
        public void .cctor(){} // RVA: 0x7495480
    }

    public class XmlTextWriterBase64Encoder : Base64Encoder
    {
        public object xmlTextEncoder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x734DC00
        public void WriteChars(){} // RVA: 0x734DCA0
    }

    public class XmlUnspecifiedAttribute : XmlAttribute
    {
        public object fSpecified;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B18C0
        public void get_Specified(){} // RVA: 0xF73960
        public void CloneNode(){} // RVA: 0x74D2880
        public void set_InnerText(){} // RVA: 0x74D29D0
        public void InsertBefore(){} // RVA: 0x74D2A50
        public void InsertAfter(){} // RVA: 0x74D2AE0
        public void RemoveChild(){} // RVA: 0x74D2B70
        public void AppendChild(){} // RVA: 0x74D2C00
        public void WriteTo(){} // RVA: 0x74D2C90
        public void SetSpecified(){} // RVA: 0xF73A60
    }

    public class XmlUrlResolver : XmlResolver
    {
        public object s_DownloadManager;
        public object _credentials;
        public object _proxy;
        public object _cachePolicy;

        // ── Methods ──
        public void get_DownloadManager(){} // RVA: 0x74F5E00
        public void .ctor(){} // RVA: 0xB43310
        public void GetEntity(){} // RVA: 0x74F5F10
        public void ResolveUri(){} // RVA: 0x74F61B0
        public void GetEntityAsync(){} // RVA: 0x74F61C0
    }

    public class XmlUtf8RawTextWriter : XmlRawWriter
    {
        public object useAsync;
        public object bufBytes;
        public object stream;
        public object encoding;
        public object xmlCharType;
        public object bufPos;
        public object textPos;
        public object contentPos;
        public object cdataPos;
        public object attrEndPos;
        public object bufLen;
        public object writeToNull;
        public object hadDoubleBracket;
        public object inAttributeValue;
        public object newLineHandling;
        public object closeOutput;
        public object omitXmlDeclaration;
        public object newLineChars;
        public object checkCharacters;
        public object standalone;
        public object outputMethod;
        public object autoXmlDeclaration;
        public object mergeCDataSections;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7495E20
        public void WriteXmlDeclaration(){} // RVA: 0x7496400
        public void WriteDocType(){} // RVA: 0x7496470
        public void WriteStartElement(){} // RVA: 0x74966E0
        public void StartElementContent(){} // RVA: 0x7496790
        public void WriteEndElement(){} // RVA: 0x74967D0
        public void WriteFullEndElement(){} // RVA: 0x7496920
        public void WriteStartAttribute(){} // RVA: 0x7496A20
        public void WriteEndAttribute(){} // RVA: 0x7496B20
        public void WriteNamespaceDeclaration(){} // RVA: 0x74802C0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0xC2E4C0
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7496B60
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7496C90
        public void WriteCData(){} // RVA: 0x7496CD0
        public void WriteComment(){} // RVA: 0x7496EC0
        public void WriteProcessingInstruction(){} // RVA: 0x7496FE0
        public void WriteEntityRef(){} // RVA: 0x7497100
        public void WriteCharEntity(){} // RVA: 0x74971A0
        public void WriteWhitespace(){} // RVA: 0x74973F0
        public void WriteString(){} // RVA: 0x74973F0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7497430
        public void WriteChars(){} // RVA: 0x7366570
        public void WriteRaw(){} // RVA: 0x747ADF0
        public void Close(){} // RVA: 0x7497660
        public void Flush(){} // RVA: 0x74977B0
        public void FlushBuffer(){} // RVA: 0x7497800
        public void FlushEncoder(){} // RVA: 0xB43310
        public void WriteAttributeTextBlock(){} // RVA: 0x7497B70
        public void WriteElementTextBlock(){} // RVA: 0x7497E30
        public void RawText(){} // RVA: 0x7498150
        public void WriteRawWithCharChecking(){} // RVA: 0x74982E0
        public void WriteCommentOrPi(){} // RVA: 0x7498570
        public void WriteCDataSection(){} // RVA: 0x7498960
        public void IsSurrogateByte(){} // RVA: 0x7498D10
        public void EncodeSurrogate(){} // RVA: 0x7498D20
        public void InvalidXmlChar(){} // RVA: 0x7498ED0
        public void EncodeChar(){} // RVA: 0x74990E0
        public void EncodeMultibyteUTF8(){} // RVA: 0x74991B0
        public void CharToUTF8(){} // RVA: 0x7499200
        public void WriteNewLine(){} // RVA: 0x74992C0
        public void LtEntity(){} // RVA: 0x7499330
        public void GtEntity(){} // RVA: 0x7499340
        public void AmpEntity(){} // RVA: 0x7499350
        public void QuoteEntity(){} // RVA: 0x7499360
        public void TabEntity(){} // RVA: 0x7499380
        public void LineFeedEntity(){} // RVA: 0x7499390
        public void CarriageReturnEntity(){} // RVA: 0x74993A0
        public void CharEntity(){} // RVA: 0x74993B0
        public void RawStartCData(){} // RVA: 0x74994F0
        public void RawEndCData(){} // RVA: 0x7499510
        public void ValidateContentChars(){} // RVA: 0x7499520
    }

    public class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
    {
        public object indentLevel;
        public object newLineOnAttributes;
        public object indentChars;
        public object mixedContent;
        public object mixedContentStack;
        public object conformanceLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7499920
        public void WriteDocType(){} // RVA: 0x7499B00
        public void WriteStartElement(){} // RVA: 0x7499B70
        public void StartElementContent(){} // RVA: 0x7499C90
        public void OnRootElement(){} // RVA: 0x6A92F20
        public void WriteEndElement(){} // RVA: 0x7499D00
        public void WriteFullEndElement(){} // RVA: 0x7499DE0
        public void WriteStartAttribute(){} // RVA: 0x7499F60
        public void WriteCData(){} // RVA: 0x749A070
        public void WriteComment(){} // RVA: 0x749A080
        public void WriteProcessingInstruction(){} // RVA: 0x749A0C0
        public void WriteEntityRef(){} // RVA: 0x749A200
        public void WriteCharEntity(){} // RVA: 0x749A2B0
        public void WriteSurrogateCharEntity(){} // RVA: 0x749A2C0
        public void WriteWhitespace(){} // RVA: 0x749A2D0
        public void WriteString(){} // RVA: 0x749A2D0
        public void WriteChars(){} // RVA: 0x749A320
        public void WriteRaw(){} // RVA: 0x749A3C0
        public void WriteBase64(){} // RVA: 0x749A410
        public void Init(){} // RVA: 0x749A430
        public void WriteIndent(){} // RVA: 0x749A610
    }

    public class XmlValidatingReader : XmlReader
    {
        public object impl;

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x10AD460
        public void get_LocalName(){} // RVA: 0x1085C80
        public void get_NamespaceURI(){} // RVA: 0x678C220
        public void get_Prefix(){} // RVA: 0x678C250
        public void get_Value(){} // RVA: 0x22368C0
        public void get_Depth(){} // RVA: 0x7048FE0
        public void get_BaseURI(){} // RVA: 0x10ADE70
        public void get_IsEmptyElement(){} // RVA: 0x10AD020
        public void get_AttributeCount(){} // RVA: 0x6E669C0
        public void GetAttribute(){} // RVA: 0x71DA4B0
        public void MoveToAttribute(){} // RVA: 0x71DA4E0
        public void MoveToFirstAttribute(){} // RVA: 0x678C400
        public void MoveToNextAttribute(){} // RVA: 0x687B750
        public void MoveToElement(){} // RVA: 0x687B780
        public void ReadAttributeValue(){} // RVA: 0x6ADFF00
        public void Read(){} // RVA: 0x71DA540
        public void get_EOF(){} // RVA: 0x71DA570
        public void get_ReadState(){} // RVA: 0x71DA5A0
        public void get_NameTable(){} // RVA: 0x6ADFA50
        public void LookupNamespace(){} // RVA: 0x748CA90
        public void ResolveEntity(){} // RVA: 0x71DA630
        public void get_Namespaces(){} // RVA: 0x749A690
    }

    public class XmlValidatingReaderImpl : XmlReader
    {
        public object coreReader;
        public object coreReaderImpl;
        public object coreReaderNSResolver;
        public object validationType;
        public object validator;
        public object schemaCollection;
        public object processIdentityConstraints;
        public object parsingFunction;
        public object eventHandling;
        public object parserContext;
        public object readBinaryHelper;
        public object outerReader;
        public object s_tempResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x749A6C0
        public void get_Settings(){} // RVA: 0x749AE70
        public void get_NodeType(){} // RVA: 0x10AD460
        public void get_Name(){} // RVA: 0x6AE07D0
        public void get_LocalName(){} // RVA: 0x1085C80
        public void get_NamespaceURI(){} // RVA: 0x678C220
        public void get_Prefix(){} // RVA: 0x678C250
        public void get_Value(){} // RVA: 0x22368C0
        public void get_Depth(){} // RVA: 0x7048FE0
        public void get_BaseURI(){} // RVA: 0x10ADE70
        public void get_IsEmptyElement(){} // RVA: 0x10AD020
        public void get_IsDefault(){} // RVA: 0x10AE060
        public void get_QuoteChar(){} // RVA: 0x10AD890
        public void get_XmlSpace(){} // RVA: 0x10ACFC0
        public void get_XmlLang(){} // RVA: 0x10AC4B0
        public void get_ReadState(){} // RVA: 0x749AF80
        public void get_EOF(){} // RVA: 0x71DA570
        public void get_NameTable(){} // RVA: 0x6ADFA50
        public void get_AttributeCount(){} // RVA: 0x6E669C0
        public void GetAttribute(){} // RVA: 0x71DA4B0
        public void MoveToAttribute(){} // RVA: 0x749B010
        public void MoveToFirstAttribute(){} // RVA: 0x749B050
        public void MoveToNextAttribute(){} // RVA: 0x749B0A0
        public void MoveToElement(){} // RVA: 0x749B0F0
        public void Read(){} // RVA: 0x749B140
        public void Close(){} // RVA: 0x749B410
        public void LookupNamespace(){} // RVA: 0x749B450
        public void ReadAttributeValue(){} // RVA: 0x749B480
        public void get_CanResolveEntity(){} // RVA: 0xC2E4C0
        public void ResolveEntity(){} // RVA: 0x749B4F0
        public void MoveOffEntityReference(){} // RVA: 0x749B530
        public void ReadString(){} // RVA: 0x749B5F0
        public void HasLineInfo(){} // RVA: 0xC2E4C0
        public void get_LineNumber(){} // RVA: 0x749B6C0
        public void get_LinePosition(){} // RVA: 0x749B760
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x749B800
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7120CC0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x749B860
        public void GetNamespacesInScope(){} // RVA: 0x749B800
        public void LookupPrefix(){} // RVA: 0x749B860
        public void get_ValidationType(){} // RVA: 0x1065D50
        public void get_Schemas(){} // RVA: 0xD05CA0
        public void get_Namespaces(){} // RVA: 0x749B8C0
        public void ParseDtdFromParserContext(){} // RVA: 0x749B8E0
        public void ValidateDtd(){} // RVA: 0x749BA30
        public void ResolveEntityInternally(){} // RVA: 0x749BBB0
        public void SetupValidation(){} // RVA: 0x749BC60
        public void GetResolver(){} // RVA: 0x749C080
        public void ProcessCoreReaderEvent(){} // RVA: 0x749C170
        public void get_Validator(){} // RVA: 0xD33E60
        public void set_Validator(){} // RVA: 0xB708C0
        public void get_NamespaceManager(){} // RVA: 0x749C290
        public void get_StandAlone(){} // RVA: 0x749C2C0
        public void set_SchemaTypeObject(){} // RVA: 0x749C2E0
        public void get_TypedValueObject(){} // RVA: 0x749C300
        public void set_TypedValueObject(){} // RVA: 0x749C330
        public void AddDefaultAttribute(){} // RVA: 0x749C350
        public void get_DtdInfo(){} // RVA: 0x749C370
        public void ValidateDefaultAttributeOnUse(){} // RVA: 0x749C3A0
    }

    public class XmlWellFormedWriter : XmlWriter
    {
        public object writer;
        public object rawWriter;
        public object predefinedNamespaces;
        public object nsStack;
        public object nsTop;
        public object nsHashtable;
        public object useNsHashtable;
        public object elemScopeStack;
        public object elemTop;
        public object attrStack;
        public object attrCount;
        public object attrHashTable;
        public object specAttr;
        public object attrValueCache;
        public object curDeclPrefix;
        public object stateTable;
        public object currentState;
        public object checkCharacters;
        public object omitDuplNamespaces;
        public object writeEndDocumentOnClose;
        public object conformanceLevel;
        public object dtdWritten;
        public object xmlDeclFollows;
        public object xmlCharType;
        public object hasher;
        public object stateName;
        public object tokenName;
        public object state2WriteState;
        public object StateTableDocument;
        public object StateTableAuto;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x749C710
        public void get_WriteState(){} // RVA: 0x749CEF0
        public void WriteStartDocument(){} // RVA: 0x749CF90
        public void WriteEndDocument(){} // RVA: 0x749CFC0
        public void WriteDocType(){} // RVA: 0x749D0D0
        public void WriteStartElement(){} // RVA: 0x749D650
        public void WriteEndElement(){} // RVA: 0x749D9C0
        public void WriteFullEndElement(){} // RVA: 0x749DB80
        public void WriteStartAttribute(){} // RVA: 0x749DD40
        public void WriteEndAttribute(){} // RVA: 0x749E620
        public void WriteCData(){} // RVA: 0x749F900
        public void WriteComment(){} // RVA: 0x749F9A0
        public void WriteProcessingInstruction(){} // RVA: 0x749FA40
        public void WriteEntityRef(){} // RVA: 0x749FD20
        public void WriteCharEntity(){} // RVA: 0x749FE30
        public void WriteSurrogateCharEntity(){} // RVA: 0x749FFB0
        public void WriteWhitespace(){} // RVA: 0x74A01A0
        public void WriteString(){} // RVA: 0x74A0360
        public void WriteChars(){} // RVA: 0x74A04A0
        public void WriteRaw(){} // RVA: 0x74A0A60
        public void WriteBase64(){} // RVA: 0x74A0B40
        public void Close(){} // RVA: 0x74A0D20
        public void Flush(){} // RVA: 0x74A1370
        public void LookupPrefix(){} // RVA: 0x74A13D0
        public void WriteValue(){} // RVA: 0x74A15D0
        public void WriteBinHex(){} // RVA: 0x74A16C0
        public void get_RawWriter(){} // RVA: 0xB700F0
        public void get_SaveAttrValue(){} // RVA: 0x73B1790
        public void get_InBase64(){} // RVA: 0x74A17B0
        public void SetSpecialAttribute(){} // RVA: 0x74A17D0
        public void WriteStartDocumentImpl(){} // RVA: 0x74A1950
        public void StartFragment(){} // RVA: 0x74A1B30
        public void PushNamespaceImplicit(){} // RVA: 0x74A1B40
        public void PushNamespaceExplicit(){} // RVA: 0x74A2160
        public void AddNamespace(){} // RVA: 0x74A2870
        public void AddToNamespaceHashtable(){} // RVA: 0x74A2BB0
        public void LookupNamespaceIndex(){} // RVA: 0x74A2CE0
        public void PopNamespaces(){} // RVA: 0x74A2E30
        public void DupAttrException(){} // RVA: 0x74A2F60
        public void AdvanceState(){} // RVA: 0x74A3070
        public void StartElementContent(){} // RVA: 0x74A34A0
        public void GetStateName(){} // RVA: 0x74A3680
        public void LookupNamespace(){} // RVA: 0x74A3720
        public void LookupLocalNamespace(){} // RVA: 0x74A3830
        public void GeneratePrefix(){} // RVA: 0x74A3940
        public void CheckNCName(){} // RVA: 0x74A3C10
        public void InvalidCharsException(){} // RVA: 0x74A3D40
        public void ThrowInvalidStateTransition(){} // RVA: 0x74A3EB0
        public void get_IsClosedOrErrorState(){} // RVA: 0x74A40B0
        public void AddAttribute(){} // RVA: 0x74A40C0
        public void AddToAttrHashTable(){} // RVA: 0x74A4650
        public void .cctor(){} // RVA: 0x74A47F0
    }

    public class XmlWhitespace : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D2D70
        public void get_Name(){} // RVA: 0x74D2E70
        public void get_LocalName(){} // RVA: 0x74D2E70
        public void get_NodeType(){} // RVA: 0x1A45300
        public void get_ParentNode(){} // RVA: 0x74D24A0
        public void get_Value(){} // RVA: 0x69358F0
        public void set_Value(){} // RVA: 0x74D2EA0
        public void CloneNode(){} // RVA: 0x74D2FA0
        public void WriteTo(){} // RVA: 0x74D3010
        public void WriteContentTo(){} // RVA: 0xB43310
        public void get_IsText(){} // RVA: 0xC2E4C0
    }

    public class XmlWriter : Object
    {
        public object writeNodeBuffer;

        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x894750
        public void WriteEndDocument(){} // RVA: 0x894290
        public void WriteDocType(){} // RVA: 0x899870
        public void WriteStartElement(){} // RVA: 0x8954D0
        public void WriteEndElement(){} // RVA: 0x894290
        public void WriteFullEndElement(){} // RVA: 0x894290
        public void WriteAttributeString(){} // RVA: 0x74A6F40
        public void WriteStartAttribute(){} // RVA: 0x8954D0
        public void WriteEndAttribute(){} // RVA: 0x894290
        public void WriteCData(){} // RVA: 0x894320
        public void WriteComment(){} // RVA: 0x894320
        public void WriteProcessingInstruction(){} // RVA: 0x8943B0
        public void WriteEntityRef(){} // RVA: 0x894320
        public void WriteCharEntity(){} // RVA: 0x894470
        public void WriteWhitespace(){} // RVA: 0x894320
        public void WriteString(){} // RVA: 0x894320
        public void WriteSurrogateCharEntity(){} // RVA: 0x8A2F90
        public void WriteChars(){} // RVA: 0x89B9B0
        public void WriteRaw(){} // RVA: 0x894320
        public void WriteBase64(){} // RVA: 0x89B9B0
        public void WriteBinHex(){} // RVA: 0x74A6FA0
        public void get_WriteState(){} // RVA: 0x87C130
        public void Close(){} // RVA: 0xB43310
        public void Flush(){} // RVA: 0x894290
        public void LookupPrefix(){} // RVA: 0x87C540
        public void WriteValue(){} // RVA: 0x74A6FD0
        public void WriteAttributes(){} // RVA: 0x74A6FF0
        public void WriteNode(){} // RVA: 0x74A7360
        public void WriteElementString(){} // RVA: 0x74A7940
        public void Dispose(){} // RVA: 0x74A79E0
        public void Create(){} // RVA: 0x74A7AA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XmlWriterSettings : Object
    {
        public object useAsync;
        public object encoding;
        public object omitXmlDecl;
        public object newLineHandling;
        public object newLineChars;
        public object indent;
        public object indentChars;
        public object newLineOnAttributes;
        public object closeOutput;
        public object namespaceHandling;
        public object conformanceLevel;
        public object checkCharacters;
        public object writeEndDocumentOnClose;
        public object outputMethod;
        public object cdataSections;
        public object doNotEscapeUriAttributes;
        public object mergeCDataSections;
        public object mediaType;
        public object docTypeSystem;
        public object docTypePublic;
        public object standalone;
        public object autoXmlDecl;
        public object isReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74A7B20
        public void get_Async(){} // RVA: 0xC120A0
        public void get_Encoding(){} // RVA: 0xB465B0
        public void get_OmitXmlDeclaration(){} // RVA: 0xC38360
        public void set_OmitXmlDeclaration(){} // RVA: 0x74A7BF0
        public void get_NewLineHandling(){} // RVA: 0x15AF000
        public void get_NewLineChars(){} // RVA: 0xB70160
        public void get_Indent(){} // RVA: 0x6E349A0
        public void set_Indent(){} // RVA: 0x74A7C50
        public void get_IndentChars(){} // RVA: 0xD05CA0
        public void get_NewLineOnAttributes(){} // RVA: 0xC02470
        public void get_CloseOutput(){} // RVA: 0xEEA010
        public void get_ConformanceLevel(){} // RVA: 0xBE5890
        public void set_ConformanceLevel(){} // RVA: 0x74A7CB0
        public void get_CheckCharacters(){} // RVA: 0x1FAA110
        public void get_NamespaceHandling(){} // RVA: 0xBE5870
        public void set_NamespaceHandling(){} // RVA: 0x74A7D50
        public void get_WriteEndDocumentOnClose(){} // RVA: 0x74A7DF0
        public void get_OutputMethod(){} // RVA: 0xE32C80
        public void set_OutputMethod(){} // RVA: 0xEEA060
        public void Clone(){} // RVA: 0x74A7E00
        public void get_CDataSectionElements(){} // RVA: 0xC0FFC0
        public void get_DoNotEscapeUriAttributes(){} // RVA: 0xB6B1A0
        public void get_MergeCDataSections(){} // RVA: 0x1A1E0A0
        public void get_MediaType(){} // RVA: 0xBBFF90
        public void get_DocTypeSystem(){} // RVA: 0xC10050
        public void get_DocTypePublic(){} // RVA: 0xCD3320
        public void get_Standalone(){} // RVA: 0xD34760
        public void get_AutoXmlDeclaration(){} // RVA: 0xC27EB0
        public void get_IndentInternal(){} // RVA: 0xB9E080
        public void get_IsQuerySpecific(){} // RVA: 0x74A7F20
        public void CreateWriter(){} // RVA: 0x74A8580
        public void set_ReadOnly(){} // RVA: 0x6DE6250
        public void CheckReadOnly(){} // RVA: 0x74A8980
        public void Initialize(){} // RVA: 0x74A8A30
    }

    public class XsdCachingReader : XmlReader
    {
        public object coreReader;
        public object coreReaderNameTable;
        public object contentEvents;
        public object attributeEvents;
        public object cachedNode;
        public object cacheState;
        public object contentIndex;
        public object attributeCount;
        public object returnOriginalStringValues;
        public object cacheHandler;
        public object currentAttrIndex;
        public object currentContentIndex;
        public object readAhead;
        public object lineInfo;
        public object textNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74A8D00
        public void Init(){} // RVA: 0x74A8F40
        public void Reset(){} // RVA: 0x74A91E0
        public void get_Settings(){} // RVA: 0x10ACB60
        public void get_NodeType(){} // RVA: 0x74A9240
        public void get_Name(){} // RVA: 0x74A9260
        public void get_LocalName(){} // RVA: 0x74A9290
        public void get_NamespaceURI(){} // RVA: 0x12EEB90
        public void get_Prefix(){} // RVA: 0x74A92B0
        public void get_Value(){} // RVA: 0x74A92D0
        public void get_Depth(){} // RVA: 0x74A9300
        public void get_BaseURI(){} // RVA: 0x10ADE70
        public void get_IsEmptyElement(){} // RVA: 0xB43320
        public void get_IsDefault(){} // RVA: 0xB43320
        public void get_QuoteChar(){} // RVA: 0x10AD890
        public void get_XmlSpace(){} // RVA: 0x10ACFC0
        public void get_XmlLang(){} // RVA: 0x10AC4B0
        public void get_AttributeCount(){} // RVA: 0xBE5850
        public void GetAttribute(){} // RVA: 0x74A9530
        public void MoveToAttribute(){} // RVA: 0x74A9720
        public void MoveToFirstAttribute(){} // RVA: 0x74A9810
        public void MoveToNextAttribute(){} // RVA: 0x74A98A0
        public void MoveToElement(){} // RVA: 0x74A9940
        public void Read(){} // RVA: 0x74A9990
        public void RecordTextNode(){} // RVA: 0x74A9D50
        public void SwitchTextNodeAndEndElement(){} // RVA: 0x74A9DD0
        public void RecordEndElementNode(){} // RVA: 0x74A9F20
        public void get_EOF(){} // RVA: 0x74AA0D0
        public void Close(){} // RVA: 0x74AA110
        public void get_ReadState(){} // RVA: 0x71DA5A0
        public void Skip(){} // RVA: 0x74AA150
        public void get_NameTable(){} // RVA: 0xB465B0
        public void LookupNamespace(){} // RVA: 0x71DA5D0
        public void ResolveEntity(){} // RVA: 0x74AA290
        public void ReadAttributeValue(){} // RVA: 0x74AA2D0
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0xC2E4C0
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x74AA490
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x74AA4B0
        public void SetToReplayMode(){} // RVA: 0x74AA4D0
        public void GetCoreReader(){} // RVA: 0xB5DBF0
        public void GetLineInfo(){} // RVA: 0xBE2C60
        public void ClearAttributesInfo(){} // RVA: 0x74AA500
        public void AddAttribute(){} // RVA: 0x74AA510
        public void AddContent(){} // RVA: 0x74AA6F0
        public void RecordAttributes(){} // RVA: 0x74AA8C0
        public void GetAttributeIndexWithoutPrefix(){} // RVA: 0x74AAB30
        public void GetAttributeIndexWithPrefix(){} // RVA: 0x74AABD0
        public void CreateDummyTextNode(){} // RVA: 0x74AAC80
    }

    public class XsdValidatingReader : XmlReader
    {
        public object coreReader;
        public object coreReaderNSResolver;
        public object thisNSResolver;
        public object validator;
        public object xmlResolver;
        public object validationEvent;
        public object validationState;
        public object valueGetter;
        public object nsManager;
        public object manageNamespaces;
        public object processInlineSchema;
        public object replayCache;
        public object cachedNode;
        public object attributePSVI;
        public object attributeCount;
        public object coreReaderAttributeCount;
        public object currentAttrIndex;
        public object attributePSVINodes;
        public object defaultAttributes;
        public object inlineSchemaParser;
        public object atomicValue;
        public object xmlSchemaInfo;
        public object originalAtomicValueString;
        public object coreReaderNameTable;
        public object cachingReader;
        public object textNode;
        public object NsXmlNs;
        public object NsXs;
        public object NsXsi;
        public object XsiType;
        public object XsiNil;
        public object XsdSchema;
        public object XsiSchemaLocation;
        public object XsiNoNamespaceSchemaLocation;
        public object xmlCharType;
        public object lineInfo;
        public object readBinaryHelper;
        public object savedState;
        public object TypeOfString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74AB430
        public void Init(){} // RVA: 0x74AB450
        public void SetupValidator(){} // RVA: 0x74ABC10
        public void get_Settings(){} // RVA: 0x74AC320
        public void get_NodeType(){} // RVA: 0x74AC4B0
        public void get_Name(){} // RVA: 0x74AC580
        public void get_LocalName(){} // RVA: 0x74AC6B0
        public void get_NamespaceURI(){} // RVA: 0x74AC700
        public void get_Prefix(){} // RVA: 0x74AC750
        public void get_Value(){} // RVA: 0x74AC7A0
        public void get_Depth(){} // RVA: 0x74AC7F0
        public void get_BaseURI(){} // RVA: 0x10ADE70
        public void get_IsEmptyElement(){} // RVA: 0x10AD020
        public void get_IsDefault(){} // RVA: 0x74AC840
        public void get_QuoteChar(){} // RVA: 0x10AD890
        public void get_XmlSpace(){} // RVA: 0x10ACFC0
        public void get_XmlLang(){} // RVA: 0x10AC4B0
        public void get_SchemaInfo(){} // RVA: 0x2303260
        public void get_ValueType(){} // RVA: 0x74AC880
        public void get_AttributeCount(){} // RVA: 0x19C6270
        public void GetAttribute(){} // RVA: 0x74ACAF0
        public void MoveToAttribute(){} // RVA: 0x74ACD00
        public void MoveToFirstAttribute(){} // RVA: 0x74ACF20
        public void MoveToNextAttribute(){} // RVA: 0x74AD240
        public void MoveToElement(){} // RVA: 0x74AD550
        public void Read(){} // RVA: 0x74AD5B0
        public void get_EOF(){} // RVA: 0x71DA570
        public void Close(){} // RVA: 0x74AD890
        public void get_ReadState(){} // RVA: 0x74AD8D0
        public void Skip(){} // RVA: 0x74AD910
        public void get_NameTable(){} // RVA: 0xBAE340
        public void LookupNamespace(){} // RVA: 0x74ADAC0
        public void ResolveEntity(){} // RVA: 0x74ADB20
        public void ReadAttributeValue(){} // RVA: 0x74ADB60
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x74ADDA0
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x74ADE30
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x74ADE80
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x74ADF30
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x74AE110
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x74AE170
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x74AE1D0
        public void HasLineInfo(){} // RVA: 0xC2E4C0
        public void get_LineNumber(){} // RVA: 0x74AE220
        public void get_LinePosition(){} // RVA: 0x74AE280
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x74AE2E0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x74AE370
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x74AE400
        public void GetStringValue(){} // RVA: 0x22368C0
        public void get_AttributeSchemaInfo(){} // RVA: 0x74AE490
        public void ProcessReaderEvent(){} // RVA: 0x74AE4B0
        public void ProcessElementEvent(){} // RVA: 0x74AE770
        public void ProcessEndElementEvent(){} // RVA: 0x74AEEB0
        public void ValidateAttributes(){} // RVA: 0x74AF180
        public void ClearAttributesInfo(){} // RVA: 0x74AF4E0
        public void GetAttributePSVI(){} // RVA: 0x74AF720
        public void GetDefaultAttribute(){} // RVA: 0x74AF900
        public void AddAttributePSVI(){} // RVA: 0x74AFA50
        public void IsXSDRoot(){} // RVA: 0x74AFC90
        public void ProcessInlineSchema(){} // RVA: 0x74AFCB0
        public void ReadAheadForMemberType(){} // RVA: 0x74AFDF0
        public void GetIsDefault(){} // RVA: 0x74B0130
        public void GetMemberType(){} // RVA: 0x74B05B0
        public void GetCachingReader(){} // RVA: 0x74B06F0
        public void CreateDummyTextNode(){} // RVA: 0x74B08F0
        public void CachingCallBack(){} // RVA: 0x74B0A50
        public void GetOriginalAtomicValueStringOfElement(){} // RVA: 0x74B0B30
    }

}