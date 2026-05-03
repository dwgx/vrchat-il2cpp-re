// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 74
// Methods: 2227

namespace ThirdParty.DotNet.System.Xml
{
    public class XmlAsyncCheckReader : XmlReader
    {
        public System.Xml.XmlReader coreReader; // 0x10
        public System.Threading.Tasks.Task lastTask; // 0x18
        public object field_2; // 0x53
        public object field_3; // 0x54
        public object field_4; // 0x55
        public object field_5; // 0x56
        public object field_6; // 0x57
        public object field_7; // 0x58
        public object field_8; // 0x59
        public object field_9; // 0x5A
        public object field_10; // 0x5B
        public object field_11; // 0x5C
        public object field_12; // 0x5D
        public object field_13; // 0x5E
        public object field_14; // 0x5F
        public object field_15; // 0x60
        public object field_16; // 0x61
        public object field_17; // 0x62
        public object field_18; // 0x63
        public object field_19; // 0x64
        public object field_20; // 0x65
        public object field_21; // 0x66
        public object field_22; // 0x67
        public object field_23; // 0x68
        public object field_24; // 0x69
        public object field_25; // 0x6A

        // ── Methods ──
        public void get_CoreReader(){} // RVA: 0x7FFE81116380
        public void CreateAsyncCheckWrapper(){} // RVA: 0x7FFE87554FA0
        public void .ctor(){} // RVA: 0x7FFE87555340
        public void CheckAsync(){} // RVA: 0x7FFE87555480
        public void get_Settings(){} // RVA: 0x7FFE87555550
        public void get_NodeType(){} // RVA: 0x7FFE87555620
        public void get_Name(){} // RVA: 0x7FFE87555660
        public void get_LocalName(){} // RVA: 0x7FFE875556A0
        public void get_NamespaceURI(){} // RVA: 0x7FFE875556E0
        public void get_Prefix(){} // RVA: 0x7FFE87555720
        public void get_Value(){} // RVA: 0x7FFE87555760
        public void get_Depth(){} // RVA: 0x7FFE875557A0
        public void get_BaseURI(){} // RVA: 0x7FFE875557E0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE87555820
        public void get_IsDefault(){} // RVA: 0x7FFE87555860
        public void get_QuoteChar(){} // RVA: 0x7FFE875558A0
        public void get_XmlSpace(){} // RVA: 0x7FFE875558E0
        public void get_XmlLang(){} // RVA: 0x7FFE87555920
        public void get_SchemaInfo(){} // RVA: 0x7FFE87555960
        public void get_ValueType(){} // RVA: 0x7FFE875559A0
        public void get_AttributeCount(){} // RVA: 0x7FFE875559E0
        public void GetAttribute(){} // RVA: 0x7FFE87555AD0 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE87555B70 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE87555BC0
        public void MoveToNextAttribute(){} // RVA: 0x7FFE87555C00
        public void MoveToElement(){} // RVA: 0x7FFE87555C40
        public void ReadAttributeValue(){} // RVA: 0x7FFE87555C80
        public void Read(){} // RVA: 0x7FFE87555CC0
        public void get_EOF(){} // RVA: 0x7FFE87555D00
        public void Close(){} // RVA: 0x7FFE87555D40
        public void get_ReadState(){} // RVA: 0x7FFE87555D80
        public void Skip(){} // RVA: 0x7FFE87555DC0
        public void get_NameTable(){} // RVA: 0x7FFE87555E00
        public void LookupNamespace(){} // RVA: 0x7FFE87555E40
        public void get_CanResolveEntity(){} // RVA: 0x7FFE87555E90
        public void ResolveEntity(){} // RVA: 0x7FFE87555ED0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFE87555F10
        public void ReadValueChunk(){} // RVA: 0x7FFE87555F50
        public void ReadString(){} // RVA: 0x7FFE87555FC0
        public void MoveToContent(){} // RVA: 0x7FFE87556000
        public void ReadStartElement(){} // RVA: 0x7FFE87556040
        public void ReadElementString(){} // RVA: 0x7FFE87556080
        public void ReadEndElement(){} // RVA: 0x7FFE875560C0
        public void IsStartElement(){} // RVA: 0x7FFE87556100
        public void ReadInnerXml(){} // RVA: 0x7FFE87556160
        public void get_HasAttributes(){} // RVA: 0x7FFE875561A0
        public void Dispose(){} // RVA: 0x7FFE875561E0
        public void get_NamespaceManager(){} // RVA: 0x7FFE87556220
        public void get_DtdInfo(){} // RVA: 0x7FFE87556260
    }

    public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader
    {
        public System.Xml.IXmlLineInfo readerAsIXmlLineInfo; // 0x20
        public object field_1; // 0x6D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875564C0
        public void HasLineInfo(){} // RVA: 0x7FFE875565C0
        public void get_LineNumber(){} // RVA: 0x7FFE87556610
        public void get_LinePosition(){} // RVA: 0x7FFE87556660
    }

    public class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875566B0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE875567B0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE87556810
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87556870
    }

    public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS
    {
        public System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30
        public object field_1; // 0x6F
        public object field_2; // 0x70
        public object field_3; // 0x71
        public object field_4; // 0x72
        public object field_5; // 0x73
        public object field_6; // 0x74

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875568D0
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x7FFE875569D0
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x7FFE87556A20
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x7FFE87556A70
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x7FFE87556AC0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x7FFE87556B10
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x7FFE87556B60
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x7FFE87556BB0
    }

    public class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875562A0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE875563A0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE87556400
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87556460
    }

    public class XmlAsyncCheckWriter : XmlWriter
    {
        public System.Xml.XmlWriter coreWriter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87556C00
        public void CheckAsync(){} // RVA: 0x7FFE87556D20
        public void WriteStartDocument(){} // RVA: 0x7FFE87556E30 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFE87556E80
        public void WriteDocType(){} // RVA: 0x7FFE87556EC0
        public void WriteStartElement(){} // RVA: 0x7FFE87556F30
        public void WriteEndElement(){} // RVA: 0x7FFE87556FA0
        public void WriteFullEndElement(){} // RVA: 0x7FFE87556FE0
        public void WriteStartAttribute(){} // RVA: 0x7FFE87557020
        public void WriteEndAttribute(){} // RVA: 0x7FFE87557090
        public void WriteCData(){} // RVA: 0x7FFE875570D0
        public void WriteComment(){} // RVA: 0x7FFE87557120
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE87557170
        public void WriteEntityRef(){} // RVA: 0x7FFE875571D0
        public void WriteCharEntity(){} // RVA: 0x7FFE87557220
        public void WriteWhitespace(){} // RVA: 0x7FFE87557270
        public void WriteString(){} // RVA: 0x7FFE875572C0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87557310
        public void WriteChars(){} // RVA: 0x7FFE87557370
        public void WriteRaw(){} // RVA: 0x7FFE87557450 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE875574A0
        public void WriteBinHex(){} // RVA: 0x7FFE87557510
        public void get_WriteState(){} // RVA: 0x7FFE87557580
        public void Close(){} // RVA: 0x7FFE875575C0
        public void Flush(){} // RVA: 0x7FFE87557600
        public void LookupPrefix(){} // RVA: 0x7FFE87557640
        public void WriteValue(){} // RVA: 0x7FFE87557690
        public void WriteAttributes(){} // RVA: 0x7FFE875576E0
        public void WriteNode(){} // RVA: 0x7FFE87557740
        public void Dispose(){} // RVA: 0x7FFE875577A0
    }

    public class XmlAttribute : XmlNode
    {
        public System.Xml.XmlName name; // 0x18
        public System.Xml.XmlLinkedNode lastChild; // 0x20
        public object field_2; // 0x1B5
        public object field_3; // 0x1B6
        public object field_4; // 0x1B7
        public object field_5; // 0x1B8
        public object field_6; // 0x1B9
        public object field_7; // 0x1BA
        public object field_8; // 0x1BB
        public object field_9; // 0x1BC
        public object field_10; // 0x1BD
        public object field_11; // 0x1BE
        public object field_12; // 0x1BF
        public object field_13; // 0x1C0
        public object field_14; // 0x1C1
        public object field_15; // 0x1C2
        public object field_16; // 0x1C3
        public object field_17; // 0x1C4
        public object field_18; // 0x1C5
        public object field_19; // 0x1C6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758B5B0 | overloaded x2
        public void get_LocalNameHash(){} // RVA: 0x7FFE8758B590
        public void get_XmlName(){} // RVA: 0x7FFE810FE7C0
        public void set_XmlName(){} // RVA: 0x7FFE81161E80
        public void CloneNode(){} // RVA: 0x7FFE8758B600
        public void get_ParentNode(){} // RVA: 0x7FFE813240E0
        public void get_Name(){} // RVA: 0x7FFE8758B6F0
        public void get_LocalName(){} // RVA: 0x7FFE86BADF80
        public void get_NamespaceURI(){} // RVA: 0x7FFE82A2A930
        public void get_Prefix(){} // RVA: 0x7FFE81D29350
        public void set_Prefix(){} // RVA: 0x7FFE8758B710
        public void get_NodeType(){} // RVA: 0x7FFE81200CB0
        public void get_OwnerDocument(){} // RVA: 0x7FFE86BAE0A0
        public void get_Value(){} // RVA: 0x7FFE8758B810
        public void set_Value(){} // RVA: 0x7FFE8758B830
        public void get_SchemaInfo(){} // RVA: 0x7FFE810FE7C0
        public void set_InnerText(){} // RVA: 0x7FFE8758B850
        public void PrepareOwnerElementInElementIdAttrMap(){} // RVA: 0x7FFE8758B8C0
        public void ResetOwnerElementInElementIdAttrMap(){} // RVA: 0x7FFE8758BAB0
        public void get_IsContainer(){} // RVA: 0x7FFE811E0850
        public void AppendChildForLoad(){} // RVA: 0x7FFE8758BBF0
        public void get_LastNode(){} // RVA: 0x7FFE811290C0
        public void set_LastNode(){} // RVA: 0x7FFE811290D0
        public void IsValidChildType(){} // RVA: 0x7FFE8758BFB0
        public void get_Specified(){} // RVA: 0x7FFE811E0850
        public void InsertBefore(){} // RVA: 0x7FFE8758BFC0
        public void InsertAfter(){} // RVA: 0x7FFE8758C060
        public void RemoveChild(){} // RVA: 0x7FFE8758C100
        public void PrependChild(){} // RVA: 0x7FFE8758C180
        public void AppendChild(){} // RVA: 0x7FFE8758C250
        public void get_OwnerElement(){} // RVA: 0x7FFE8758C2D0
        public void set_InnerXml(){} // RVA: 0x7FFE8758C360
        public void WriteTo(){} // RVA: 0x7FFE8758C3F0
        public void WriteContentTo(){} // RVA: 0x7FFE8758C4D0
        public void get_BaseURI(){} // RVA: 0x7FFE8758C550
        public void SetParent(){} // RVA: 0x7FFE810FCE30
        public void get_XmlSpace(){} // RVA: 0x7FFE8758C5F0
        public void get_XmlLang(){} // RVA: 0x7FFE8758C660
    }

    public class XmlAttributeCollection : XmlNamedNodeMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ItemOf(){} // RVA: 0x7FFE8758C9B0 | overloaded x3
        public void FindNodeOffsetNS(){} // RVA: 0x7FFE8758CBB0
        public void SetNamedItem(){} // RVA: 0x7FFE8758CDA0
        public void Append(){} // RVA: 0x7FFE8758CF40
        public void Remove(){} // RVA: 0x7FFE8758D190
        public void RemoveAt(){} // RVA: 0x7FFE8758D230
        public void RemoveAll(){} // RVA: 0x7FFE8758D2F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8758D3D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE8758D460
        public void AddNode(){} // RVA: 0x7FFE8758D470
        public void InsertNodeAt(){} // RVA: 0x7FFE8758D670
        public void RemoveNodeAt(){} // RVA: 0x7FFE8758D720
        public void Detach(){} // RVA: 0x7FFE8758D900
        public void InsertParentIntoElementIdAttrMap(){} // RVA: 0x7FFE8758D9E0
        public void RemoveParentFromElementIdAttrMap(){} // RVA: 0x7FFE8758DBE0
        public void RemoveDuplicateAttribute(){} // RVA: 0x7FFE8758DDE0
        public void PrepareParentInElementIdAttrMap(){} // RVA: 0x7FFE8758DEF0
        public void ResetParentInElementIdAttrMap(){} // RVA: 0x7FFE8758E050
        public void InternalAppendAttribute(){} // RVA: 0x7FFE8758E130
    }

    public class XmlAutoDetectWriter : XmlRawWriter
    {
        public System.Xml.XmlRawWriter wrapped; // 0x28
        public System.Xml.OnRemoveWriter onRemove; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87557B20 | overloaded x3
        public void WriteDocType(){} // RVA: 0x7FFE87557BA0
        public void WriteStartElement(){} // RVA: 0x7FFE87557C20
        public void WriteStartAttribute(){} // RVA: 0x7FFE87557D00
        public void WriteEndAttribute(){} // RVA: 0x7FFE871CDB90
        public void WriteCData(){} // RVA: 0x7FFE87557D80
        public void WriteComment(){} // RVA: 0x7FFE87557DE0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE87557E20
        public void WriteWhitespace(){} // RVA: 0x7FFE87557E60
        public void WriteString(){} // RVA: 0x7FFE87557EA0
        public void WriteChars(){} // RVA: 0x7FFE821EE5B0
        public void WriteRaw(){} // RVA: 0x7FFE87557F50 | overloaded x2
        public void WriteEntityRef(){} // RVA: 0x7FFE87557FB0
        public void WriteCharEntity(){} // RVA: 0x7FFE87558010
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87558070
        public void WriteBase64(){} // RVA: 0x7FFE875580E0
        public void WriteBinHex(){} // RVA: 0x7FFE87558160
        public void Close(){} // RVA: 0x7FFE875581E0
        public void Flush(){} // RVA: 0x7FFE87558230
        public void WriteValue(){} // RVA: 0x7FFE87558280
        public void set_NamespaceResolver(){} // RVA: 0x7FFE875582E0
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE875583C0 | overloaded x2
        public void StartElementContent(){} // RVA: 0x7FFE87553460
        public void WriteEndElement(){} // RVA: 0x7FFE87558420
        public void WriteFullEndElement(){} // RVA: 0x7FFE87558450
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFE87558480
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFE87553530
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFE875584F0
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFE87553590
        public void IsHtmlTag(){} // RVA: 0x7FFE87558550
        public void EnsureWrappedWriter(){} // RVA: 0x7FFE875585B0
        public void TextBlockCreatesWriter(){} // RVA: 0x7FFE875585C0
        public void CreateWrappedWriter(){} // RVA: 0x7FFE87558670
    }

    public class XmlCDataSection : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758E1F0
        public void get_Name(){} // RVA: 0x7FFE8758E200
        public void get_LocalName(){} // RVA: 0x7FFE8758E200
        public void get_NodeType(){} // RVA: 0x7FFE8180E590
        public void get_ParentNode(){} // RVA: 0x7FFE8758E230
        public void CloneNode(){} // RVA: 0x7FFE8758E2D0
        public void WriteTo(){} // RVA: 0x7FFE8758E340
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void get_IsText(){} // RVA: 0x7FFE811E0850
    }

    public class XmlCachedStream : MemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875C90F0
    }

    public class XmlCharType : ValueType
    {
        public object s_Lock;
        public byte[] s_CharProperties; // 0x8

        // ── Methods ──
        public void get_StaticLock(){} // RVA: 0x7FFE875BC5A0
        public void InitInstance(){} // RVA: 0x7FFE875BC670
        public void SetProperties(){} // RVA: 0x7FFE875BCEE0
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void get_Instance(){} // RVA: 0x7FFE875BCF70
        public void IsWhiteSpace(){} // RVA: 0x7FFE875BD030
        public void IsNCNameSingleChar(){} // RVA: 0x7FFE875BD060
        public void IsStartNCNameSingleChar(){} // RVA: 0x7FFE875BD090
        public void IsNameSingleChar(){} // RVA: 0x7FFE875BD0C0
        public void IsCharData(){} // RVA: 0x7FFE875BD100
        public void IsPubidChar(){} // RVA: 0x7FFE875BD130
        public void IsTextChar(){} // RVA: 0x7FFE875BD1C0
        public void IsLetter(){} // RVA: 0x7FFE875BD1F0
        public void IsNCNameCharXml4e(){} // RVA: 0x7FFE875BD220
        public void IsStartNCNameCharXml4e(){} // RVA: 0x7FFE875BD250
        public void IsNameCharXml4e(){} // RVA: 0x7FFE875BD290
        public void IsDigit(){} // RVA: 0x7FFE869C5120
        public void IsHighSurrogate(){} // RVA: 0x7FFE875BD2D0
        public void IsLowSurrogate(){} // RVA: 0x7FFE875BD2E0
        public void IsSurrogate(){} // RVA: 0x7FFE86E2CCC0
        public void CombineSurrogateChar(){} // RVA: 0x7FFE875BD2F0
        public void SplitSurrogateChar(){} // RVA: 0x7FFE875BD310
        public void IsOnlyWhitespace(){} // RVA: 0x7FFE875BD350
        public void IsOnlyWhitespaceWithPos(){} // RVA: 0x7FFE875BD3D0
        public void IsOnlyCharData(){} // RVA: 0x7FFE875BD450
        public void IsOnlyDigits(){} // RVA: 0x7FFE875BD540
        public void IsPublicId(){} // RVA: 0x7FFE875BD5A0
        public void InRange(){} // RVA: 0x7FFE867924F0
    }

    public class XmlCharacterData : XmlLinkedNode
    {
        public string data; // 0x20
        public object field_1; // 0x1D4
        public object field_2; // 0x1D5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758E390
        public void get_Value(){} // RVA: 0x7FFE869FDAC0
        public void set_Value(){} // RVA: 0x7FFE8758E410
        public void get_InnerText(){} // RVA: 0x7FFE82A336A0
        public void set_InnerText(){} // RVA: 0x7FFE84D052B0
        public void get_Data(){} // RVA: 0x7FFE8758E430
        public void set_Data(){} // RVA: 0x7FFE8758E490
        public void CheckOnData(){} // RVA: 0x7FFE8758E5A0
    }

    public class XmlChildEnumerator : Object
    {
        public System.Xml.XmlNode container; // 0x10
        public System.Xml.XmlNode child; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758E620
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFE8758E710
        public void MoveNext(){} // RVA: 0x7FFE8758E710
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8758E840
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE8758E8C0
        public void get_Current(){} // RVA: 0x7FFE8758E8C0
    }

    public class XmlChildNodes : XmlNodeList
    {
        public System.Xml.XmlNode container; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Item(){} // RVA: 0x7FFE8758E950
        public void get_Count(){} // RVA: 0x7FFE8758E9C0
        public void GetEnumerator(){} // RVA: 0x7FFE8758EA20
    }

    public class XmlComment : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758E1F0
        public void get_Name(){} // RVA: 0x7FFE8758EAF0
        public void get_LocalName(){} // RVA: 0x7FFE8758EAF0
        public void get_NodeType(){} // RVA: 0x7FFE82199910
        public void CloneNode(){} // RVA: 0x7FFE8758EB20
        public void WriteTo(){} // RVA: 0x7FFE8758EB90
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
    }

    public class XmlComplianceUtil : Object
    {
        // ── Methods ──
        public void NonCDataNormalize(){} // RVA: 0x7FFE875BD620
        public void CDataNormalize(){} // RVA: 0x7FFE875BD8E0
    }

    public class XmlConvert : Object
    {
        public System.Xml.XmlCharType xmlCharType;

        // ── Methods ──
        public void EncodeName(){} // RVA: 0x7FFE875BE490 | overloaded x2
        public void EncodeLocalName(){} // RVA: 0x7FFE875BDB50
        public void DecodeName(){} // RVA: 0x7FFE875BDBB0
        public void FromHex(){} // RVA: 0x7FFE875BEFF0
        public void FromBinHexString(){} // RVA: 0x7FFE875BF0D0 | overloaded x2
        public void ToBinHexString(){} // RVA: 0x7FFE875BF150
        public void VerifyName(){} // RVA: 0x7FFE875BF2D0
        public void TryVerifyName(){} // RVA: 0x7FFE875BF440
        public void VerifyQName(){} // RVA: 0x7FFE875BF610
        public void VerifyNCName(){} // RVA: 0x7FFE875BF900 | overloaded x2
        public void TryVerifyNCName(){} // RVA: 0x7FFE875BFA70
        public void VerifyTOKEN(){} // RVA: 0x7FFE875BFB50
        public void TryVerifyTOKEN(){} // RVA: 0x7FFE875BFE50
        public void TryVerifyNMTOKEN(){} // RVA: 0x7FFE875C0160
        public void TryVerifyNormalizedString(){} // RVA: 0x7FFE875C03A0
        public void ToString(){} // RVA: 0x7FFE875C1120 | overloaded x18
        public void ToBoolean(){} // RVA: 0x7FFE875C1170
        public void TryToBoolean(){} // RVA: 0x7FFE875C13E0
        public void ToChar(){} // RVA: 0x7FFE875C16E0
        public void TryToChar(){} // RVA: 0x7FFE875C17B0
        public void ToDecimal(){} // RVA: 0x7FFE875C1950
        public void TryToDecimal(){} // RVA: 0x7FFE875C19E0
        public void ToInteger(){} // RVA: 0x7FFE875C1BA0
        public void TryToInteger(){} // RVA: 0x7FFE875C1C30
        public void ToSByte(){} // RVA: 0x7FFE875C1DF0
        public void TryToSByte(){} // RVA: 0x7FFE875C1E90
        public void ToInt16(){} // RVA: 0x7FFE875C20F0
        public void TryToInt16(){} // RVA: 0x7FFE875C2190
        public void ToInt32(){} // RVA: 0x7FFE875C23E0
        public void TryToInt32(){} // RVA: 0x7FFE875C2410
        public void ToInt64(){} // RVA: 0x7FFE875C2590
        public void TryToInt64(){} // RVA: 0x7FFE875C25C0
        public void ToByte(){} // RVA: 0x7FFE875C2740
        public void TryToByte(){} // RVA: 0x7FFE875C27E0
        public void ToUInt16(){} // RVA: 0x7FFE875C29D0
        public void TryToUInt16(){} // RVA: 0x7FFE875C2A70
        public void ToUInt32(){} // RVA: 0x7FFE875C2C60
        public void TryToUInt32(){} // RVA: 0x7FFE875C2C90
        public void ToUInt64(){} // RVA: 0x7FFE875C2E10
        public void TryToUInt64(){} // RVA: 0x7FFE875C2E40
        public void ToSingle(){} // RVA: 0x7FFE875C2FC0
        public void TryToSingle(){} // RVA: 0x7FFE875C3120
        public void ToDouble(){} // RVA: 0x7FFE875C33F0
        public void TryToDouble(){} // RVA: 0x7FFE875C3550
        public void ToXPathDouble(){} // RVA: 0x7FFE875C3830
        public void ToTimeSpan(){} // RVA: 0x7FFE875C3AA0
        public void TryToTimeSpan(){} // RVA: 0x7FFE875C3CA0
        public void get_AllDateTimeFormats(){} // RVA: 0x7FFE875C3D60
        public void CreateAllDateTimeFormats(){} // RVA: 0x7FFE875C3E10
        public void ToDateTime(){} // RVA: 0x7FFE875C44E0 | overloaded x3
        public void ToDateTimeOffset(){} // RVA: 0x7FFE875C4780
        public void ToGuid(){} // RVA: 0x7FFE875C4870
        public void TryToGuid(){} // RVA: 0x7FFE875C4890
        public void SwitchToLocalTime(){} // RVA: 0x7FFE875C4BC0
        public void SwitchToUtcTime(){} // RVA: 0x7FFE875C4D50
        public void ToUri(){} // RVA: 0x7FFE875C4EA0
        public void TryToUri(){} // RVA: 0x7FFE875C52F0
        public void StrEqual(){} // RVA: 0x7FFE875C5790
        public void TrimString(){} // RVA: 0x7FFE875C5830
        public void TrimStringStart(){} // RVA: 0x7FFE875C58F0
        public void TrimStringEnd(){} // RVA: 0x7FFE875C59A0
        public void SplitString(){} // RVA: 0x7FFE875C5A60
        public void IsNegativeZero(){} // RVA: 0x7FFE875C5B60
        public void DoubleToInt64Bits(){} // RVA: 0x7FFE868B6030
        public void VerifyCharData(){} // RVA: 0x7FFE875C5BE0
        public void CreateException(){} // RVA: 0x7FFE875C6190 | overloaded x4
        public void CreateInvalidSurrogatePairException(){} // RVA: 0x7FFE875C63A0 | overloaded x3
        public void CreateInvalidHighSurrogateCharException(){} // RVA: 0x7FFE875C67D0 | overloaded x3
        public void CreateInvalidCharException(){} // RVA: 0x7FFE875C6C10 | overloaded x3
        public void CreateInvalidNameCharException(){} // RVA: 0x7FFE875C6CF0
        public void CreateInvalidNameArgumentException(){} // RVA: 0x7FFE875C6E10
        public void .cctor(){} // RVA: 0x7FFE875C6F10
    }

    public class XmlDeclaration : XmlLinkedNode
    {
        public string version; // 0x20
        public string encoding; // 0x28
        public string standalone; // 0x30
        public object field_3; // 0x1DD
        public object field_4; // 0x1DE
        public object field_5; // 0x1DF
        public object field_6; // 0x1E0
        public object field_7; // 0x1E1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758EBE0
        public void get_Version(){} // RVA: 0x7FFE811290C0
        public void set_Version(){} // RVA: 0x7FFE811290D0
        public void get_Encoding(){} // RVA: 0x7FFE81129130
        public void set_Encoding(){} // RVA: 0x7FFE8758EF40
        public void get_Standalone(){} // RVA: 0x7FFE8144E200
        public void set_Standalone(){} // RVA: 0x7FFE8758EFF0
        public void get_Value(){} // RVA: 0x7FFE8758B810
        public void set_Value(){} // RVA: 0x7FFE8758B830
        public void get_InnerText(){} // RVA: 0x7FFE8758F240
        public void set_InnerText(){} // RVA: 0x7FFE8758F3E0
        public void get_Name(){} // RVA: 0x7FFE8758F670
        public void get_LocalName(){} // RVA: 0x7FFE8725AEB0
        public void get_NodeType(){} // RVA: 0x7FFE86BADF70
        public void CloneNode(){} // RVA: 0x7FFE8758F6B0
        public void WriteTo(){} // RVA: 0x7FFE8758F710
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void IsValidXmlVersion(){} // RVA: 0x7FFE8758F790
    }

    public class XmlDocument : XmlNode
    {
        public System.Xml.XmlImplementation implementation; // 0x18
        public System.Xml.DomNameTable domNameTable; // 0x20
        public System.Xml.XmlLinkedNode lastChild; // 0x28
        public System.Xml.XmlNamedNodeMap entities; // 0x30
        public System.Collections.Hashtable htElementIdMap; // 0x38
        public System.Collections.Hashtable htElementIDAttrDecl; // 0x40
        public System.Xml.Schema.SchemaInfo schemaInfo; // 0x48
        public System.Xml.Schema.XmlSchemaSet schemas; // 0x50
        public bool reportValidity; // 0x58
        public bool actualLoadingStatus; // 0x59
        public System.Xml.XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
        public System.Xml.XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
        public System.Xml.XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
        public System.Xml.XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
        public System.Xml.XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
        public System.Xml.XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
        public bool fEntRefNodesPresent; // 0x90
        public bool fCDataNodesPresent; // 0x91
        public bool preserveWhitespace; // 0x92
        public bool isLoading; // 0x93
        public string strDocumentName; // 0x98
        public string strDocumentFragmentName; // 0xA0
        public string strCommentName; // 0xA8
        public string strTextName; // 0xB0
        public string strCDataSectionName; // 0xB8
        public string strEntityName; // 0xC0
        public string strID; // 0xC8
        public string strXmlns; // 0xD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758F990 | overloaded x3
        public void get_DtdSchemaInfo(){} // RVA: 0x7FFE81176730
        public void set_DtdSchemaInfo(){} // RVA: 0x7FFE81176740
        public void CheckName(){} // RVA: 0x7FFE87590520
        public void AddXmlName(){} // RVA: 0x7FFE875905F0
        public void GetXmlName(){} // RVA: 0x7FFE87590620
        public void AddAttrXmlName(){} // RVA: 0x7FFE87590650
        public void AddIdInfo(){} // RVA: 0x7FFE87590790
        public void GetIDInfoByElement_(){} // RVA: 0x7FFE875908C0
        public void GetIDInfoByElement(){} // RVA: 0x7FFE875909E0
        public void GetElement(){} // RVA: 0x7FFE87590B00
        public void AddElementWithId(){} // RVA: 0x7FFE87590FA0
        public void RemoveElementWithId(){} // RVA: 0x7FFE87591200
        public void CloneNode(){} // RVA: 0x7FFE87591360
        public void get_NodeType(){} // RVA: 0x7FFE8249F650
        public void get_ParentNode(){} // RVA: 0x7FFE813240E0
        public void get_DocumentType(){} // RVA: 0x7FFE87591490
        public void get_Declaration(){} // RVA: 0x7FFE87591520
        public void get_Implementation(){} // RVA: 0x7FFE810FE7C0
        public void get_Name(){} // RVA: 0x7FFE817AE360
        public void get_LocalName(){} // RVA: 0x7FFE817AE360
        public void get_DocumentElement(){} // RVA: 0x7FFE875915E0
        public void get_IsContainer(){} // RVA: 0x7FFE811E0850
        public void get_LastNode(){} // RVA: 0x7FFE81129130
        public void set_LastNode(){} // RVA: 0x7FFE810FCE90
        public void get_OwnerDocument(){} // RVA: 0x7FFE813240E0
        public void set_Schemas(){} // RVA: 0x7FFE812534D0
        public void get_CanReportValidity(){} // RVA: 0x7FFE813A1140
        public void get_HasSetResolver(){} // RVA: 0x7FFE8158C5E0
        public void GetResolver(){} // RVA: 0x7FFE813A1DA0
        public void set_XmlResolver(){} // RVA: 0x7FFE87591670
        public void IsValidChildType(){} // RVA: 0x7FFE875919C0
        public void HasNodeTypeInPrevSiblings(){} // RVA: 0x7FFE87591B90
        public void HasNodeTypeInNextSiblings(){} // RVA: 0x7FFE87591C80
        public void CanInsertBefore(){} // RVA: 0x7FFE87591D00
        public void CanInsertAfter(){} // RVA: 0x7FFE87591ED0
        public void CreateAttribute(){} // RVA: 0x7FFE875939C0 | overloaded x3
        public void SetDefaultNamespace(){} // RVA: 0x7FFE87592100
        public void CreateCDataSection(){} // RVA: 0x7FFE875922D0
        public void CreateComment(){} // RVA: 0x7FFE87592340
        public void CreateDocumentType(){} // RVA: 0x7FFE875923B0
        public void CreateDocumentFragment(){} // RVA: 0x7FFE87592450
        public void CreateElement(){} // RVA: 0x7FFE87593B10 | overloaded x3
        public void AddDefaultAttributes(){} // RVA: 0x7FFE875925F0
        public void GetSchemaElementDecl(){} // RVA: 0x7FFE875929A0
        public void PrepareDefaultAttribute(){} // RVA: 0x7FFE87592AD0
        public void CreateEntityReference(){} // RVA: 0x7FFE87592C10
        public void CreateProcessingInstruction(){} // RVA: 0x7FFE87592C80
        public void CreateXmlDeclaration(){} // RVA: 0x7FFE87592D00
        public void CreateTextNode(){} // RVA: 0x7FFE87592DA0
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFE87592E10
        public void CreateWhitespace(){} // RVA: 0x7FFE87592E80
        public void ImportNodeInternal(){} // RVA: 0x7FFE87593050
        public void ImportAttributes(){} // RVA: 0x7FFE87593790
        public void ImportChildren(){} // RVA: 0x7FFE87593900
        public void get_NameTable(){} // RVA: 0x7FFE81D29350
        public void CreateDefaultAttribute(){} // RVA: 0x7FFE87593A60
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_Entities(){} // RVA: 0x7FFE87593BE0
        public void set_Entities(){} // RVA: 0x7FFE81129890
        public void get_IsLoading(){} // RVA: 0x7FFE872056A0
        public void set_IsLoading(){} // RVA: 0x7FFE87593CE0
        public void get_ActualLoadingStatus(){} // RVA: 0x7FFE85BA8C00
        public void ReadNode(){} // RVA: 0x7FFE87593CF0
        public void SetupReader(){} // RVA: 0x7FFE87593DB0
        public void Load(){} // RVA: 0x7FFE87593E20
        public void LoadXml(){} // RVA: 0x7FFE87593F40
        public void set_InnerText(){} // RVA: 0x7FFE87594210
        public void set_InnerXml(){} // RVA: 0x7FFE86AF3E00
        public void Save(){} // RVA: 0x7FFE87594270
        public void WriteTo(){} // RVA: 0x7FFE87594530
        public void WriteContentTo(){} // RVA: 0x7FFE87594550
        public void GetEventArgs(){} // RVA: 0x7FFE875947C0
        public void GetInsertEventArgsForLoad(){} // RVA: 0x7FFE875948C0
        public void BeforeEvent(){} // RVA: 0x7FFE87594990
        public void AfterEvent(){} // RVA: 0x7FFE87594A10
        public void GetDefaultAttribute(){} // RVA: 0x7FFE87594A90
        public void get_Version(){} // RVA: 0x7FFE87594DC0
        public void get_Encoding(){} // RVA: 0x7FFE87594DF0
        public void get_Standalone(){} // RVA: 0x7FFE87594E20
        public void GetEntityNode(){} // RVA: 0x7FFE87594E50
        public void get_SchemaInfo(){} // RVA: 0x7FFE87594F40
        public void get_BaseURI(){} // RVA: 0x7FFE81318010
        public void SetBaseURI(){} // RVA: 0x7FFE81317920
        public void AppendChildForLoad(){} // RVA: 0x7FFE87595070
        public void .cctor(){} // RVA: 0x7FFE87595320
    }

    public class XmlDocumentFragment : XmlNode
    {
        public System.Xml.XmlLinkedNode lastChild; // 0x18
        public object field_1; // 0x201
        public object field_2; // 0x202
        public object field_3; // 0x203
        public object field_4; // 0x204
        public object field_5; // 0x205
        public object field_6; // 0x206
        public object field_7; // 0x207

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875955B0
        public void get_Name(){} // RVA: 0x7FFE87595680
        public void get_LocalName(){} // RVA: 0x7FFE87595680
        public void get_NodeType(){} // RVA: 0x7FFE869DB780
        public void get_ParentNode(){} // RVA: 0x7FFE813240E0
        public void get_OwnerDocument(){} // RVA: 0x7FFE875956B0
        public void set_InnerXml(){} // RVA: 0x7FFE87595730
        public void CloneNode(){} // RVA: 0x7FFE875957C0
        public void get_IsContainer(){} // RVA: 0x7FFE811E0850
        public void get_LastNode(){} // RVA: 0x7FFE810FE7C0
        public void set_LastNode(){} // RVA: 0x7FFE81161E80
        public void IsValidChildType(){} // RVA: 0x7FFE87595860
        public void CanInsertAfter(){} // RVA: 0x7FFE87595910
        public void CanInsertBefore(){} // RVA: 0x7FFE87595990
        public void WriteTo(){} // RVA: 0x7FFE87594530
        public void WriteContentTo(){} // RVA: 0x7FFE87595A10
    }

    public class XmlDocumentType : XmlLinkedNode
    {
        public string name; // 0x20
        public string publicId; // 0x28
        public string systemId; // 0x30
        public string internalSubset; // 0x38
        public bool namespaces; // 0x40
        public System.Xml.XmlNamedNodeMap entities; // 0x48
        public System.Xml.XmlNamedNodeMap notations; // 0x50
        public System.Xml.Schema.SchemaInfo schemaInfo; // 0x58
        public object field_8; // 0x209
        public object field_9; // 0x20A
        public object field_10; // 0x20B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87595C80
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void get_LocalName(){} // RVA: 0x7FFE811290C0
        public void get_NodeType(){} // RVA: 0x7FFE813B49D0
        public void CloneNode(){} // RVA: 0x7FFE87595EE0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_Entities(){} // RVA: 0x7FFE87595F40
        public void get_Notations(){} // RVA: 0x7FFE87596040
        public void get_PublicId(){} // RVA: 0x7FFE81129130
        public void get_SystemId(){} // RVA: 0x7FFE8144E200
        public void get_InternalSubset(){} // RVA: 0x7FFE8143BA80
        public void get_ParseWithNamespaces(){} // RVA: 0x7FFE811B6C00
        public void WriteTo(){} // RVA: 0x7FFE87596140
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void get_DtdSchemaInfo(){} // RVA: 0x7FFE811C3500
        public void set_DtdSchemaInfo(){} // RVA: 0x7FFE811C3510
    }

    public class XmlDownloadManager : Object
    {
        // ── Methods ──
        public void GetStream(){} // RVA: 0x7FFE875C7130
        public void GetNonFileStream(){} // RVA: 0x7FFE875C7270
        public void Remove(){} // RVA: 0x7FFE875C78C0
        public void GetStreamAsync(){} // RVA: 0x7FFE875C7AC0
        public void GetNonFileStreamAsync(){} // RVA: 0x7FFE875C7C90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlElement : XmlLinkedNode
    {
        public System.Xml.XmlName name; // 0x20
        public System.Xml.XmlAttributeCollection attributes; // 0x28
        public System.Xml.XmlLinkedNode lastChild; // 0x30
        public object field_3; // 0x214
        public object field_4; // 0x215
        public object field_5; // 0x216
        public object field_6; // 0x217
        public object field_7; // 0x218
        public object field_8; // 0x219
        public object field_9; // 0x21A
        public object field_10; // 0x21B
        public object field_11; // 0x21C
        public object field_12; // 0x21D
        public object field_13; // 0x21E
        public object field_14; // 0x21F
        public object field_15; // 0x220
        public object field_16; // 0x221

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875963B0 | overloaded x2
        public void get_XmlName(){} // RVA: 0x7FFE811290C0
        public void set_XmlName(){} // RVA: 0x7FFE811290D0
        public void CloneNode(){} // RVA: 0x7FFE87596420
        public void get_Name(){} // RVA: 0x7FFE87596900
        public void get_LocalName(){} // RVA: 0x7FFE81103990
        public void get_NamespaceURI(){} // RVA: 0x7FFE87596920
        public void get_Prefix(){} // RVA: 0x7FFE81D28EA0
        public void set_Prefix(){} // RVA: 0x7FFE87596940
        public void get_NodeType(){} // RVA: 0x7FFE811EDAF0
        public void get_ParentNode(){} // RVA: 0x7FFE81116380
        public void get_OwnerDocument(){} // RVA: 0x7FFE87596A40
        public void get_IsContainer(){} // RVA: 0x7FFE811E0850
        public void AppendChildForLoad(){} // RVA: 0x7FFE87596A60
        public void get_IsEmpty(){} // RVA: 0x7FFE87596E20
        public void set_IsEmpty(){} // RVA: 0x7FFE87596E30
        public void get_LastNode(){} // RVA: 0x7FFE87596F10
        public void set_LastNode(){} // RVA: 0x7FFE81129890
        public void IsValidChildType(){} // RVA: 0x7FFE87596F20
        public void get_Attributes(){} // RVA: 0x7FFE87596F80
        public void get_HasAttributes(){} // RVA: 0x7FFE875971E0
        public void GetAttribute(){} // RVA: 0x7FFE87597550 | overloaded x2
        public void SetAttribute(){} // RVA: 0x7FFE87597600 | overloaded x2
        public void GetAttributeNode(){} // RVA: 0x7FFE87597740 | overloaded x2
        public void SetAttributeNode(){} // RVA: 0x7FFE875977D0 | overloaded x2
        public void HasAttribute(){} // RVA: 0x7FFE875978D0
        public void WriteTo(){} // RVA: 0x7FFE87597900
        public void WriteElementTo(){} // RVA: 0x7FFE87597A60
        public void WriteStartElement(){} // RVA: 0x7FFE87597CF0
        public void WriteContentTo(){} // RVA: 0x7FFE8758C4D0
        public void RemoveAllAttributes(){} // RVA: 0x7FFE87597E30
        public void RemoveAll(){} // RVA: 0x7FFE87597F40
        public void RemoveAllChildren(){} // RVA: 0x7FFE87597F70
        public void get_SchemaInfo(){} // RVA: 0x7FFE811290C0
        public void set_InnerXml(){} // RVA: 0x7FFE87597F80
        public void get_InnerText(){} // RVA: 0x7FFE87598070
        public void set_InnerText(){} // RVA: 0x7FFE87598080
        public void get_NextSibling(){} // RVA: 0x7FFE87598170
        public void SetParent(){} // RVA: 0x7FFE810FCE30
    }

    public class XmlEncodedRawTextWriter : XmlRawWriter
    {
        public bool useAsync; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87558D50 | overloaded x3
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE87559510 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE87559580
        public void WriteStartElement(){} // RVA: 0x7FFE87559820
        public void StartElementContent(){} // RVA: 0x7FFE87559900
        public void WriteEndElement(){} // RVA: 0x7FFE87559940
        public void WriteFullEndElement(){} // RVA: 0x7FFE87559AC0
        public void WriteStartAttribute(){} // RVA: 0x7FFE87559BE0
        public void WriteEndAttribute(){} // RVA: 0x7FFE87559D00
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFE87559D60
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFE811E0850
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFE87559DC0
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFE87559F20
        public void WriteCData(){} // RVA: 0x7FFE87559F80
        public void WriteComment(){} // RVA: 0x7FFE8755A1C0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE8755A320
        public void WriteEntityRef(){} // RVA: 0x7FFE8755A470
        public void WriteCharEntity(){} // RVA: 0x7FFE8755A540
        public void WriteWhitespace(){} // RVA: 0x7FFE8755A7C0
        public void WriteString(){} // RVA: 0x7FFE8755A840
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE8755A8C0
        public void WriteChars(){} // RVA: 0x7FFE8743EC30
        public void WriteRaw(){} // RVA: 0x7FFE87554690 | overloaded x2
        public void Close(){} // RVA: 0x7FFE8755AB50
        public void Flush(){} // RVA: 0x7FFE8755AE30
        public void FlushBuffer(){} // RVA: 0x7FFE8755AEC0
        public void EncodeChars(){} // RVA: 0x7FFE8755B420
        public void FlushEncoder(){} // RVA: 0x7FFE8755B5A0
        public void WriteAttributeTextBlock(){} // RVA: 0x7FFE8755B680
        public void WriteElementTextBlock(){} // RVA: 0x7FFE8755B990
        public void RawText(){} // RVA: 0x7FFE8755BCF0 | overloaded x2
        public void WriteRawWithCharChecking(){} // RVA: 0x7FFE8755BE80
        public void WriteCommentOrPi(){} // RVA: 0x7FFE8755C110
        public void WriteCDataSection(){} // RVA: 0x7FFE8755C4A0
        public void EncodeSurrogate(){} // RVA: 0x7FFE8755C820
        public void InvalidXmlChar(){} // RVA: 0x7FFE8755C9A0
        public void EncodeChar(){} // RVA: 0x7FFE8755CB50
        public void ChangeTextContentMark(){} // RVA: 0x7FFE8755CC30
        public void GrowTextContentMarks(){} // RVA: 0x7FFE8755CCB0
        public void WriteNewLine(){} // RVA: 0x7FFE8755CE50
        public void LtEntity(){} // RVA: 0x7FFE8755CED0
        public void GtEntity(){} // RVA: 0x7FFE8755CEF0
        public void AmpEntity(){} // RVA: 0x7FFE8755CF10
        public void QuoteEntity(){} // RVA: 0x7FFE8755CF30
        public void TabEntity(){} // RVA: 0x7FFE8755CF50
        public void LineFeedEntity(){} // RVA: 0x7FFE8755CF70
        public void CarriageReturnEntity(){} // RVA: 0x7FFE8755CF90
        public void CharEntity(){} // RVA: 0x7FFE8755CFB0
        public void RawStartCData(){} // RVA: 0x7FFE8755D100
        public void RawEndCData(){} // RVA: 0x7FFE8755D130
        public void ValidateContentChars(){} // RVA: 0x7FFE8755D150
    }

    public class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8755D580 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE8755D5B0
        public void WriteStartElement(){} // RVA: 0x7FFE8755D620
        public void StartElementContent(){} // RVA: 0x7FFE8755D770
        public void OnRootElement(){} // RVA: 0x7FFE82AA0300
        public void WriteEndElement(){} // RVA: 0x7FFE8755D7E0
        public void WriteFullEndElement(){} // RVA: 0x7FFE8755D8B0
        public void WriteStartAttribute(){} // RVA: 0x7FFE8755D980
        public void WriteCData(){} // RVA: 0x7FFE8755D9E0
        public void WriteComment(){} // RVA: 0x7FFE8755D9F0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE8755DA30
        public void WriteEntityRef(){} // RVA: 0x7FFE8755DA80
        public void WriteCharEntity(){} // RVA: 0x7FFE8755DB50
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE8755DB60
        public void WriteWhitespace(){} // RVA: 0x7FFE8755DB70
        public void WriteString(){} // RVA: 0x7FFE8755DBF0
        public void WriteChars(){} // RVA: 0x7FFE8755DC70
        public void WriteRaw(){} // RVA: 0x7FFE8755DDA0 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE8755DE10
        public void Init(){} // RVA: 0x7FFE8755DE30
        public void WriteIndent(){} // RVA: 0x7FFE8755E010
    }

    public class XmlEntity : XmlNode
    {
        public string publicId; // 0x18
        public string systemId; // 0x20
        public string notationName; // 0x28
        public string name; // 0x30
        public string unparsedReplacementStr; // 0x38
        public string baseURI; // 0x40
        public System.Xml.XmlLinkedNode lastChild; // 0x48
        public bool childrenFoliating; // 0x50
        public object field_8; // 0x225
        public object field_9; // 0x226

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875981B0
        public void CloneNode(){} // RVA: 0x7FFE875984C0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_Name(){} // RVA: 0x7FFE8144E200
        public void get_LocalName(){} // RVA: 0x7FFE8144E200
        public void get_InnerText(){} // RVA: 0x7FFE87598070
        public void set_InnerText(){} // RVA: 0x7FFE87598520
        public void get_IsContainer(){} // RVA: 0x7FFE811E0850
        public void get_LastNode(){} // RVA: 0x7FFE87598580
        public void set_LastNode(){} // RVA: 0x7FFE81176740
        public void IsValidChildType(){} // RVA: 0x7FFE87598690
        public void get_NodeType(){} // RVA: 0x7FFE81815210
        public void get_SystemId(){} // RVA: 0x7FFE811290C0
        public void set_InnerXml(){} // RVA: 0x7FFE875986B0
        public void WriteTo(){} // RVA: 0x7FFE810FB310
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void get_BaseURI(){} // RVA: 0x7FFE81178740
        public void SetBaseURI(){} // RVA: 0x7FFE81123200
    }

    public class XmlEntityReference : XmlLinkedNode
    {
        public string name; // 0x20
        public System.Xml.XmlLinkedNode lastChild; // 0x28
        public object field_2; // 0x22F
        public object field_3; // 0x230
        public object field_4; // 0x231
        public object field_5; // 0x232
        public object field_6; // 0x233
        public object field_7; // 0x234
        public object field_8; // 0x235

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87598710
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void get_LocalName(){} // RVA: 0x7FFE811290C0
        public void get_Value(){} // RVA: 0x7FFE813240E0
        public void set_Value(){} // RVA: 0x7FFE87598850
        public void get_NodeType(){} // RVA: 0x7FFE81474A10
        public void CloneNode(){} // RVA: 0x7FFE875988B0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsContainer(){} // RVA: 0x7FFE811E0850
        public void SetParent(){} // RVA: 0x7FFE87598900
        public void SetParentForLoad(){} // RVA: 0x7FFE87598A80
        public void get_LastNode(){} // RVA: 0x7FFE81129130
        public void set_LastNode(){} // RVA: 0x7FFE810FCE90
        public void IsValidChildType(){} // RVA: 0x7FFE87596F20
        public void WriteTo(){} // RVA: 0x7FFE87598AA0
        public void WriteContentTo(){} // RVA: 0x7FFE87598AE0
        public void get_BaseURI(){} // RVA: 0x7FFE87598D50
        public void ConstructBaseURI(){} // RVA: 0x7FFE87598D90
        public void get_ChildBaseURI(){} // RVA: 0x7FFE87598E60
    }

    public class XmlEventCache : XmlRawWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8755E090
        public void EndEvents(){} // RVA: 0x7FFE8755E0F0
        public void EventsToWriter(){} // RVA: 0x7FFE8755E140
        public void WriteDocType(){} // RVA: 0x7FFE8755EC40
        public void WriteStartElement(){} // RVA: 0x7FFE8755ECD0
        public void WriteStartAttribute(){} // RVA: 0x7FFE8755ED60
        public void WriteEndAttribute(){} // RVA: 0x7FFE8755EDF0
        public void WriteCData(){} // RVA: 0x7FFE8755EE30
        public void WriteComment(){} // RVA: 0x7FFE8755EE40
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE8755EE50
        public void WriteWhitespace(){} // RVA: 0x7FFE8755EE80
        public void WriteString(){} // RVA: 0x7FFE8755EE90
        public void WriteChars(){} // RVA: 0x7FFE821EE5B0
        public void WriteRaw(){} // RVA: 0x7FFE8755EEC0 | overloaded x2
        public void WriteEntityRef(){} // RVA: 0x7FFE8755EED0
        public void WriteCharEntity(){} // RVA: 0x7FFE8755EEE0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE8755EF50
        public void WriteBase64(){} // RVA: 0x7FFE8755EFF0
        public void WriteBinHex(){} // RVA: 0x7FFE8755F030
        public void Close(){} // RVA: 0x7FFE8755F070
        public void Flush(){} // RVA: 0x7FFE8755F0B0
        public void WriteValue(){} // RVA: 0x7FFE8755F0F0
        public void Dispose(){} // RVA: 0x7FFE8755F110
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE8755F280 | overloaded x2
        public void StartElementContent(){} // RVA: 0x7FFE8755F290
        public void WriteEndElement(){} // RVA: 0x7FFE8755F2D0
        public void WriteFullEndElement(){} // RVA: 0x7FFE8755F360
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFE8755F3F0
        public void WriteEndBase64(){} // RVA: 0x7FFE8755F420
        public void AddEvent(){} // RVA: 0x7FFE8755F6E0 | overloaded x6
        public void NewEvent(){} // RVA: 0x7FFE8755F790
        public void ToBytes(){} // RVA: 0x7FFE8755FA50
    }

    public class XmlException : SystemException
    {
        public string res; // 0x90
        public string[] args; // 0x98
        public int lineNumber; // 0xA0
        public int linePosition; // 0xA4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875CCD50 | overloaded x18
        public void GetObjectData(){} // RVA: 0x7FFE875CBBB0
        public void FormatUserMessage(){} // RVA: 0x7FFE875CCEE0
        public void CreateMessage(){} // RVA: 0x7FFE875CCFF0
        public void BuildCharExceptionArgs(){} // RVA: 0x7FFE875CD240 | overloaded x3
        public void get_LineNumber(){} // RVA: 0x7FFE82B06FB0
        public void get_LinePosition(){} // RVA: 0x7FFE848BEED0
        public void get_Message(){} // RVA: 0x7FFE875CD570
        public void get_ResString(){} // RVA: 0x7FFE8154EB60
    }

    public class XmlImplementation : Object
    {
        public System.Xml.XmlNameTable nameTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void CreateDocument(){} // RVA: 0x7FFE87599160
        public void get_NameTable(){} // RVA: 0x7FFE81116380
    }

    public class XmlLinkedNode : XmlNode
    {
        public System.Xml.XmlLinkedNode next; // 0x18
        public object field_1; // 0x239

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875991C0
        public void get_PreviousSibling(){} // RVA: 0x7FFE875992F0
        public void get_NextSibling(){} // RVA: 0x7FFE87599380
    }

    public class XmlLoader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Load(){} // RVA: 0x7FFE875993E0
        public void LoadDocSequence(){} // RVA: 0x7FFE87599820
        public void ReadCurrentNode(){} // RVA: 0x7FFE875998A0
        public void LoadNode(){} // RVA: 0x7FFE87599AE0
        public void LoadAttributeNode(){} // RVA: 0x7FFE8759A290
        public void LoadDefaultAttribute(){} // RVA: 0x7FFE8759A640
        public void LoadAttributeValue(){} // RVA: 0x7FFE8759A880
        public void LoadEntityReferenceNode(){} // RVA: 0x7FFE8759ABD0
        public void LoadDeclarationNode(){} // RVA: 0x7FFE8759AE30
        public void LoadDocumentTypeNode(){} // RVA: 0x7FFE8759B0B0
        public void LoadNodeDirect(){} // RVA: 0x7FFE8759B350
        public void LoadAttributeNodeDirect(){} // RVA: 0x7FFE8759B960
        public void ParseDocumentType(){} // RVA: 0x7FFE8759BBD0 | overloaded x2
        public void LoadDocumentType(){} // RVA: 0x7FFE8759BF70
        public void GetContext(){} // RVA: 0x7FFE8759D0E0
        public void ParsePartialContent(){} // RVA: 0x7FFE8759DB60
        public void LoadInnerXmlElement(){} // RVA: 0x7FFE8759DE70
        public void LoadInnerXmlAttribute(){} // RVA: 0x7FFE8759DF10
        public void RemoveDuplicateNamespace(){} // RVA: 0x7FFE8759DF30
        public void EntitizeName(){} // RVA: 0x7FFE8759E310
        public void ExpandEntity(){} // RVA: 0x7FFE8759E370
        public void ExpandEntityReference(){} // RVA: 0x7FFE8759E430
        public void CreateInnerXmlReader(){} // RVA: 0x7FFE8759EBB0
        public void ParseXmlDeclarationValue(){} // RVA: 0x7FFE8759EE50
        public void UnexpectedNodeType(){} // RVA: 0x7FFE8759F370
    }

    public class XmlName : Object
    {
        public string prefix; // 0x10
        public string localName; // 0x18
        public string ns; // 0x20
        public string name; // 0x28
        public int hashCode; // 0x30
        public System.Xml.XmlDocument ownerDoc; // 0x38
        public System.Xml.XmlName next; // 0x40
        public object field_7; // 0x23B
        public object field_8; // 0x23C
        public object field_9; // 0x23D
        public object field_10; // 0x23E
        public object field_11; // 0x23F
        public object field_12; // 0x240

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8759F4E0
        public void .ctor(){} // RVA: 0x7FFE8759F600
        public void get_LocalName(){} // RVA: 0x7FFE810FE7C0
        public void get_NamespaceURI(){} // RVA: 0x7FFE811290C0
        public void get_Prefix(){} // RVA: 0x7FFE81116380
        public void get_HashCode(){} // RVA: 0x7FFE81156CD0
        public void get_OwnerDocument(){} // RVA: 0x7FFE8143BA80
        public void get_Name(){} // RVA: 0x7FFE8759F820
        public void get_Validity(){} // RVA: 0x7FFE813240E0
        public void get_IsDefault(){} // RVA: 0x7FFE810FB320
        public void get_IsNil(){} // RVA: 0x7FFE810FB320
        public void get_MemberType(){} // RVA: 0x7FFE813240E0
        public void get_SchemaType(){} // RVA: 0x7FFE813240E0
        public void get_SchemaElement(){} // RVA: 0x7FFE813240E0
        public void get_SchemaAttribute(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE821B5270
        public void GetHashCode(){} // RVA: 0x7FFE8759FAD0
    }

    public class XmlNameEx : XmlName
    {
        public byte flags; // 0x48
        public System.Xml.Schema.XmlSchemaSimpleType memberType; // 0x50
        public System.Xml.Schema.XmlSchemaType schemaType; // 0x58
        public object decl; // 0x60
        public object field_4; // 0x248
        public object field_5; // 0x249
        public object field_6; // 0x24A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8759FB40
        public void get_Validity(){} // RVA: 0x7FFE8759FDA0
        public void get_IsDefault(){} // RVA: 0x7FFE8759FDD0
        public void get_IsNil(){} // RVA: 0x7FFE8759FDE0
        public void get_MemberType(){} // RVA: 0x7FFE8119C0E0
        public void get_SchemaType(){} // RVA: 0x7FFE811C3500
        public void get_SchemaElement(){} // RVA: 0x7FFE8759FDF0
        public void get_SchemaAttribute(){} // RVA: 0x7FFE8759FE80
        public void SetValidity(){} // RVA: 0x7FFE8759FF10
        public void SetIsDefault(){} // RVA: 0x7FFE8759FF20
        public void SetIsNil(){} // RVA: 0x7FFE8759FF50
        public void Equals(){} // RVA: 0x7FFE8759FF80
    }

    public class XmlNameTable : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE80E2E390
        public void Add(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlNamedNodeMap : Object
    {
        public System.Xml.XmlNode parent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetNamedItem(){} // RVA: 0x7FFE875A0160
        public void SetNamedItem(){} // RVA: 0x7FFE875A0310
        public void get_Count(){} // RVA: 0x7FFE8758D460
        public void GetEnumerator(){} // RVA: 0x7FFE875A03F0
        public void FindNodeOffset(){} // RVA: 0x7FFE875A0530 | overloaded x2
        public void AddNode(){} // RVA: 0x7FFE875A06C0
        public void AddNodeForLoad(){} // RVA: 0x7FFE875A0870
        public void RemoveNodeAt(){} // RVA: 0x7FFE875A0940
        public void ReplaceNodeAt(){} // RVA: 0x7FFE875A0AC0
        public void InsertNodeAt(){} // RVA: 0x7FFE875A0B30
    }

    public class XmlNamespaceManager : Object
    {
        public NamespaceDeclaration[] nsdecls; // 0x10
        public int lastDecl; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875CD590 | overloaded x2
        public void get_NameTable(){} // RVA: 0x7FFE811290C0
        public void get_DefaultNamespace(){} // RVA: 0x7FFE875CD910
        public void PushScope(){} // RVA: 0x7FFE8505BB30
        public void PopScope(){} // RVA: 0x7FFE875CD980
        public void AddNamespace(){} // RVA: 0x7FFE875CDAA0
        public void RemoveNamespace(){} // RVA: 0x7FFE875CDF60
        public void GetEnumerator(){} // RVA: 0x7FFE875CE120
        public void GetNamespacesInScope(){} // RVA: 0x7FFE875CE330
        public void LookupNamespace(){} // RVA: 0x7FFE875CE500
        public void LookupNamespaceDecl(){} // RVA: 0x7FFE875CE550
        public void LookupPrefix(){} // RVA: 0x7FFE875CE780
    }

    public class XmlNode : Object
    {
        public System.Xml.XmlNode parentNode; // 0x10
        public object field_1; // 0x253
        public object field_2; // 0x254
        public object field_3; // 0x255
        public object field_4; // 0x256
        public object field_5; // 0x257
        public object field_6; // 0x258
        public object field_7; // 0x259
        public object field_8; // 0x25A
        public object field_9; // 0x25B
        public object field_10; // 0x25C
        public object field_11; // 0x25D
        public object field_12; // 0x25E
        public object field_13; // 0x25F
        public object field_14; // 0x260
        public object field_15; // 0x261
        public object field_16; // 0x262
        public object field_17; // 0x263
        public object field_18; // 0x264
        public object field_19; // 0x265
        public object field_20; // 0x266
        public object field_21; // 0x267
        public object field_22; // 0x268
        public object field_23; // 0x269
        public object field_24; // 0x26A
        public object field_25; // 0x26B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875A1690 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE813240E0
        public void set_Value(){} // RVA: 0x7FFE875A1760
        public void get_NodeType(){} // RVA: 0x7FFE80E2EDB0
        public void get_ParentNode(){} // RVA: 0x7FFE875A1840
        public void get_ChildNodes(){} // RVA: 0x7FFE875A1940
        public void get_PreviousSibling(){} // RVA: 0x7FFE813240E0
        public void get_NextSibling(){} // RVA: 0x7FFE813240E0
        public void get_Attributes(){} // RVA: 0x7FFE813240E0
        public void get_OwnerDocument(){} // RVA: 0x7FFE875A19D0
        public void get_FirstChild(){} // RVA: 0x7FFE875A1AA0
        public void get_LastChild(){} // RVA: 0x7FFE844E23A0
        public void get_IsContainer(){} // RVA: 0x7FFE810FB320
        public void get_LastNode(){} // RVA: 0x7FFE813240E0
        public void set_LastNode(){} // RVA: 0x7FFE810FB310
        public void AncestorNode(){} // RVA: 0x7FFE875A1AD0
        public void InsertBefore(){} // RVA: 0x7FFE875A1B50
        public void InsertAfter(){} // RVA: 0x7FFE875A2520
        public void RemoveChild(){} // RVA: 0x7FFE875A2E80
        public void PrependChild(){} // RVA: 0x7FFE875A3450
        public void AppendChild(){} // RVA: 0x7FFE875A34A0
        public void AppendChildForLoad(){} // RVA: 0x7FFE875A3B40
        public void IsValidChildType(){} // RVA: 0x7FFE810FB320
        public void CanInsertBefore(){} // RVA: 0x7FFE811E0850
        public void CanInsertAfter(){} // RVA: 0x7FFE811E0850
        public void get_HasChildNodes(){} // RVA: 0x7FFE875A3E80
        public void CloneNode(){}
        public void CopyChildren(){} // RVA: 0x7FFE875A3EB0
        public void get_NamespaceURI(){} // RVA: 0x7FFE875A3F70
        public void get_Prefix(){} // RVA: 0x7FFE875A3FB0
        public void set_Prefix(){} // RVA: 0x7FFE810FB310
        public void get_LocalName(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsReadOnly(){} // RVA: 0x7FFE875A3FF0
        public void HasReadOnlyParent(){} // RVA: 0x7FFE875A40D0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE875A41B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE875A41D0
        public void GetEnumerator(){} // RVA: 0x7FFE875A4230
        public void AppendChildText(){} // RVA: 0x7FFE875A4290
        public void get_InnerText(){} // RVA: 0x7FFE875A43C0
        public void set_InnerText(){} // RVA: 0x7FFE875A4500
        public void set_InnerXml(){} // RVA: 0x7FFE875A4610
        public void get_SchemaInfo(){} // RVA: 0x7FFE875A4670
        public void get_BaseURI(){} // RVA: 0x7FFE875A46D0
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void WriteContentTo(){} // RVA: 0x7FFE80E460A0
        public void RemoveAll(){} // RVA: 0x7FFE875A4800
        public void get_Document(){} // RVA: 0x7FFE875A4880
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE875A4930
        public void GetPrefixOfNamespaceStrict(){} // RVA: 0x7FFE875A4990
        public void SetParent(){} // RVA: 0x7FFE875A4E50
        public void SetParentForLoad(){} // RVA: 0x7FFE810FCE30
        public void SplitName(){} // RVA: 0x7FFE875A4F30
        public void FindChild(){} // RVA: 0x7FFE875A50B0
        public void GetEventArgs(){} // RVA: 0x7FFE875A5140
        public void BeforeEvent(){} // RVA: 0x7FFE875A5280
        public void AfterEvent(){} // RVA: 0x7FFE875A52D0
        public void get_XmlSpace(){} // RVA: 0x7FFE875A5320
        public void get_XmlLang(){} // RVA: 0x7FFE875A55C0
        public void get_IsText(){} // RVA: 0x7FFE810FB320
        public void NestTextNodes(){} // RVA: 0x7FFE875A56F0
        public void UnnestTextNodes(){} // RVA: 0x7FFE875A5750
    }

    public class XmlNodeChangedEventArgs : EventArgs
    {
        public 0x66554F14 action; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875A57D0
        public void get_Action(){} // RVA: 0x7FFE811485C0
    }

    public class XmlNodeChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class XmlNodeList : Object
    {
        // ── Methods ──
        public void Item(){} // RVA: 0x7FFE80E3D230
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_ItemOf(){} // RVA: 0x7FFE84C79010
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE844800F0
        public void PrivateDisposeNodeList(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlNodeReader : XmlReader
    {
        public System.Xml.XmlNodeReaderNavigator readerNav; // 0x10
        public 0x66556674 nodeType; // 0x18
        public int curDepth; // 0x1C
        public 0x66552E14 readState; // 0x20
        public bool fEOF; // 0x24
        public bool bResolveEntity; // 0x25
        public bool bStartFromDocument; // 0x26
        public bool bInReadBinary; // 0x27
        public System.Xml.ReadContentAsBinaryHelper readBinaryHelper; // 0x28
        public object field_9; // 0x281
        public object field_10; // 0x282
        public object field_11; // 0x283
        public object field_12; // 0x284
        public object field_13; // 0x285
        public object field_14; // 0x286
        public object field_15; // 0x287
        public object field_16; // 0x288
        public object field_17; // 0x289
        public object field_18; // 0x28A
        public object field_19; // 0x28B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875AA630
        public void IsInReadingStates(){} // RVA: 0x7FFE86CB1DD0
        public void get_NodeType(){} // RVA: 0x7FFE875AA770
        public void get_Name(){} // RVA: 0x7FFE875AA780
        public void get_LocalName(){} // RVA: 0x7FFE875AA7F0
        public void get_NamespaceURI(){} // RVA: 0x7FFE875AA920
        public void get_Prefix(){} // RVA: 0x7FFE875AA9A0
        public void get_Value(){} // RVA: 0x7FFE875AAA20
        public void get_Depth(){} // RVA: 0x7FFE82707EE0
        public void get_BaseURI(){} // RVA: 0x7FFE875AAA90
        public void get_CanResolveEntity(){} // RVA: 0x7FFE811E0850
        public void get_IsEmptyElement(){} // RVA: 0x7FFE875AAAD0
        public void get_IsDefault(){} // RVA: 0x7FFE875AAB00
        public void get_XmlSpace(){} // RVA: 0x7FFE875AABE0
        public void get_XmlLang(){} // RVA: 0x7FFE875AAC30
        public void get_SchemaInfo(){} // RVA: 0x7FFE875AACB0
        public void get_AttributeCount(){} // RVA: 0x7FFE875AAD00
        public void GetAttribute(){} // RVA: 0x7FFE875AAE10 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE875AAFD0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE875AB190
        public void MoveToNextAttribute(){} // RVA: 0x7FFE875AB290
        public void MoveToElement(){} // RVA: 0x7FFE875AB3A0
        public void Read(){} // RVA: 0x7FFE875AB510 | overloaded x2
        public void ReadNextNode(){} // RVA: 0x7FFE875AB6E0
        public void SetEndOfFile(){} // RVA: 0x7FFE875AB9A0
        public void ReadAtZeroLevel(){} // RVA: 0x7FFE875AB9C0
        public void ReadForward(){} // RVA: 0x7FFE875ABA60
        public void ReSetReadingMarks(){} // RVA: 0x7FFE875ABC80
        public void get_EOF(){} // RVA: 0x7FFE875ABCB0
        public void Close(){} // RVA: 0x7FFE875ABCC0
        public void get_ReadState(){} // RVA: 0x7FFE8151D690
        public void Skip(){} // RVA: 0x7FFE875ABCD0
        public void ReadString(){} // RVA: 0x7FFE875ABCE0
        public void get_HasAttributes(){} // RVA: 0x7FFE87562890
        public void get_NameTable(){} // RVA: 0x7FFE8189BF90
        public void LookupNamespace(){} // RVA: 0x7FFE875ABD90
        public void ResolveEntity(){} // RVA: 0x7FFE875ABDD0
        public void ReadAttributeValue(){} // RVA: 0x7FFE875ABE60
        public void FinishReadBinary(){} // RVA: 0x7FFE875ABEB0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE875ABEE0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE875ABF00
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE875ABF20
        public void get_DtdInfo(){} // RVA: 0x7FFE875ABFA0
    }

    public class XmlNodeReaderNavigator : Object
    {
        public System.Xml.XmlNode curNode; // 0x10
        public System.Xml.XmlNode elemNode; // 0x18
        public System.Xml.XmlNode logNode; // 0x20
        public int attrIndex; // 0x28
        public int logAttrIndex; // 0x2C
        public System.Xml.XmlNameTable nameTable; // 0x30
        public System.Xml.XmlDocument doc; // 0x38
        public int nAttrInd; // 0x40
        public int nDeclarationAttrCount; // 0x44
        public int nDocTypeAttrCount; // 0x48
        public int nLogLevel; // 0x4C
        public int nLogAttrInd; // 0x50
        public bool bLogOnAttrVal; // 0x54
        public bool bCreatedOnAttribute; // 0x55
        public VirtualAttribute[] decNodeAttributes; // 0x58
        public VirtualAttribute[] docTypeNodeAttributes; // 0x60
        public bool bOnAttrVal; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875A59E0
        public void get_NodeType(){} // RVA: 0x7FFE875A63C0
        public void get_NamespaceURI(){} // RVA: 0x7FFE86BADE80
        public void get_Name(){} // RVA: 0x7FFE875A6410
        public void get_LocalName(){} // RVA: 0x7FFE875A6550
        public void get_CreatedOnAttribute(){} // RVA: 0x7FFE8286E5B0
        public void IsLocalNameEmpty(){} // RVA: 0x7FFE875A6630
        public void get_Prefix(){} // RVA: 0x7FFE872B3160
        public void get_Value(){} // RVA: 0x7FFE875A6680
        public void get_BaseURI(){} // RVA: 0x7FFE872B3220
        public void get_XmlSpace(){} // RVA: 0x7FFE875A6950
        public void get_XmlLang(){} // RVA: 0x7FFE875A6980
        public void get_IsEmptyElement(){} // RVA: 0x7FFE875A69B0
        public void get_IsDefault(){} // RVA: 0x7FFE875A6A60
        public void get_SchemaInfo(){} // RVA: 0x7FFE874E1D40
        public void get_NameTable(){} // RVA: 0x7FFE8144E200
        public void get_AttributeCount(){} // RVA: 0x7FFE875A6B20
        public void CheckIndexCondition(){} // RVA: 0x7FFE875A6C70
        public void InitDecAttr(){} // RVA: 0x7FFE875A6CE0
        public void GetDeclarationAttr(){} // RVA: 0x7FFE875A7270 | overloaded x2
        public void GetDecAttrInd(){} // RVA: 0x7FFE875A72C0
        public void InitDocTypeAttr(){} // RVA: 0x7FFE875A7380
        public void GetDocumentTypeAttr(){} // RVA: 0x7FFE875A7700 | overloaded x2
        public void GetDocTypeAttrInd(){} // RVA: 0x7FFE875A7750
        public void GetAttributeFromElement(){} // RVA: 0x7FFE875A7BB0 | overloaded x2
        public void GetAttribute(){} // RVA: 0x7FFE875A7F80 | overloaded x3
        public void LogMove(){} // RVA: 0x7FFE875A81E0
        public void RollBackMove(){} // RVA: 0x7FFE875A8250
        public void get_IsOnDeclOrDocType(){} // RVA: 0x7FFE875A82D0
        public void ResetToAttribute(){} // RVA: 0x7FFE875A8310
        public void ResetMove(){} // RVA: 0x7FFE875A8440
        public void MoveToAttribute(){} // RVA: 0x7FFE875A8B90 | overloaded x3
        public void MoveToAttributeFromElement(){} // RVA: 0x7FFE875A8760
        public void MoveToNextAttribute(){} // RVA: 0x7FFE875A8D60
        public void MoveToParent(){} // RVA: 0x7FFE875A8F60
        public void MoveToFirstChild(){} // RVA: 0x7FFE875A9000
        public void MoveToNextSibling(){} // RVA: 0x7FFE875A90A0
        public void MoveToNext(){} // RVA: 0x7FFE875A9140
        public void MoveToElement(){} // RVA: 0x7FFE875A91A0
        public void LookupNamespace(){} // RVA: 0x7FFE875A9230
        public void DefaultLookupNamespace(){} // RVA: 0x7FFE875A95D0
        public void LookupPrefix(){} // RVA: 0x7FFE875A97F0
        public void GetNamespacesInScope(){} // RVA: 0x7FFE875A9D90
        public void ReadAttributeValue(){} // RVA: 0x7FFE875AA400
        public void get_Document(){} // RVA: 0x7FFE8143BA80
    }

    public class XmlNotation : XmlNode
    {
        public string publicId; // 0x18
        public string systemId; // 0x20
        public string name; // 0x28
        public object field_3; // 0x295
        public object field_4; // 0x296

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875ABFD0
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_LocalName(){} // RVA: 0x7FFE81129130
        public void get_NodeType(){} // RVA: 0x7FFE835C1DE0
        public void CloneNode(){} // RVA: 0x7FFE875AC220
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void set_InnerXml(){} // RVA: 0x7FFE875AC280
        public void WriteTo(){} // RVA: 0x7FFE810FB310
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
    }

    public class XmlParserContext : Object
    {
        public System.Xml.XmlNameTable _nt; // 0x10
        public System.Xml.XmlNamespaceManager _nsMgr; // 0x18
        public string _docTypeName; // 0x20
        public string _pubId; // 0x28
        public string _sysId; // 0x30
        public string _internalSubset; // 0x38
        public string _xmlLang; // 0x40
        public 0x66553654 _xmlSpace; // 0x48
        public string _baseURI; // 0x50
        public System.Text.Encoding _encoding; // 0x58
        public object field_10; // 0x7F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8755FEE0 | overloaded x3
        public void get_NameTable(){} // RVA: 0x7FFE81116380
        public void get_NamespaceManager(){} // RVA: 0x7FFE810FE7C0
        public void get_DocTypeName(){} // RVA: 0x7FFE811290C0
        public void get_PublicId(){} // RVA: 0x7FFE81129130
        public void get_SystemId(){} // RVA: 0x7FFE8144E200
        public void get_BaseURI(){} // RVA: 0x7FFE8119C0E0
        public void get_InternalSubset(){} // RVA: 0x7FFE8143BA80
        public void get_XmlLang(){} // RVA: 0x7FFE81178740
        public void get_XmlSpace(){} // RVA: 0x7FFE8119C0C0
        public void get_Encoding(){} // RVA: 0x7FFE811C3500
        public void get_HasDtdInfo(){} // RVA: 0x7FFE87560600
    }

    public class XmlProcessingInstruction : XmlLinkedNode
    {
        public string target; // 0x20
        public string data; // 0x28
        public object field_2; // 0x29A
        public object field_3; // 0x29B
        public object field_4; // 0x29C
        public object field_5; // 0x29D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875AC2E0
        public void get_Name(){} // RVA: 0x7FFE875AC3C0
        public void get_LocalName(){} // RVA: 0x7FFE8725AEB0
        public void get_Value(){} // RVA: 0x7FFE81129130
        public void set_Value(){} // RVA: 0x7FFE875AC420
        public void set_Data(){} // RVA: 0x7FFE875AC430
        public void get_InnerText(){} // RVA: 0x7FFE81129130
        public void set_InnerText(){} // RVA: 0x7FFE875AC420
        public void get_NodeType(){} // RVA: 0x7FFE817F39D0
        public void CloneNode(){} // RVA: 0x7FFE875AC540
        public void WriteTo(){} // RVA: 0x7FFE875AC590
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
    }

    public class XmlQualifiedName : Object
    {
        public HashCodeOfStringDelegate hashCodeDelegate;
        public string name; // 0x10
        public string ns; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875CEC30 | overloaded x3
        public void get_Namespace(){} // RVA: 0x7FFE810FE7C0
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void GetHashCode(){} // RVA: 0x7FFE875CED60
        public void get_IsEmpty(){} // RVA: 0x7FFE875CEEA0
        public void ToString(){} // RVA: 0x7FFE875CF2A0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE875CEF50
        public void op_Equality(){} // RVA: 0x7FFE875CF0E0
        public void op_Inequality(){} // RVA: 0x7FFE875CF1A0
        public void GetHashCodeDelegate(){} // RVA: 0x7FFE875CF310
        public void IsRandomizedHashingDisabled(){} // RVA: 0x7FFE810FB320
        public void GetHashCodeOfString(){} // RVA: 0x7FFE83775DA0
        public void Init(){} // RVA: 0x7FFE875CF600
        public void SetNamespace(){} // RVA: 0x7FFE81161E80
        public void Verify(){} // RVA: 0x7FFE875CF6C0
        public void Atomize(){} // RVA: 0x7FFE875CF760
        public void Parse(){} // RVA: 0x7FFE875CF870
        public void Clone(){} // RVA: 0x7FFE875CF9E0
        public void .cctor(){} // RVA: 0x7FFE875CFA60
    }

    public class XmlRawWriter : XmlWriter
    {
        public System.Xml.XmlRawWriterBase64Encoder base64Encoder; // 0x18
        public System.Xml.IXmlNamespaceResolver resolver; // 0x20
        public object field_2; // 0x8A

        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7FFE87560790 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFE875607F0
        public void WriteDocType(){} // RVA: 0x7FFE810FB310
        public void WriteEndElement(){} // RVA: 0x7FFE80E50660 | overloaded x2
        public void WriteFullEndElement(){} // RVA: 0x7FFE87560D10 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE87560910
        public void LookupPrefix(){} // RVA: 0x7FFE87560A50
        public void get_WriteState(){} // RVA: 0x7FFE87560AB0
        public void WriteCData(){} // RVA: 0x7FFE8755F0F0
        public void WriteCharEntity(){} // RVA: 0x7FFE87560B10
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87560BA0
        public void WriteWhitespace(){} // RVA: 0x7FFE8755F0F0
        public void WriteChars(){} // RVA: 0x7FFE821EE5B0
        public void WriteRaw(){} // RVA: 0x7FFE8755F0F0 | overloaded x2
        public void WriteValue(){} // RVA: 0x7FFE8755F0F0
        public void WriteAttributes(){} // RVA: 0x7FFE87560C50
        public void WriteNode(){} // RVA: 0x7FFE87560CB0
        public void set_NamespaceResolver(){} // RVA: 0x7FFE811290D0
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void StartElementContent(){} // RVA: 0x7FFE80E45FE0
        public void OnRootElement(){} // RVA: 0x7FFE810FB310
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFE80E4F230
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFE810FB320
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFE87560D30
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFE87560D70
        public void WriteEndBase64(){} // RVA: 0x7FFE87560DB0
        public void Close(){} // RVA: 0x7FFE868DAA50
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlRawWriterBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874284B0
        public void WriteChars(){} // RVA: 0x7FFE87428520
    }

    public class XmlReader : Object
    {
        public uint IsTextualNodeBitmap;
        public uint CanReadContentAsBitmap; // 0x4
        public uint HasValueBitmap; // 0x8
        public object field_3; // 0x8D
        public object field_4; // 0x8E
        public object field_5; // 0x8F
        public object field_6; // 0x90
        public object field_7; // 0x91
        public object field_8; // 0x92
        public object field_9; // 0x93
        public object field_10; // 0x94
        public object field_11; // 0x95
        public object field_12; // 0x96
        public object field_13; // 0x97
        public object field_14; // 0x98
        public object field_15; // 0x99
        public object field_16; // 0x9A
        public object field_17; // 0x9B
        public object field_18; // 0x9C
        public object field_19; // 0x9D
        public object field_20; // 0x9E
        public object field_21; // 0x9F
        public object field_22; // 0xA0
        public object field_23; // 0xA1
        public object field_24; // 0xA2
        public object field_25; // 0xA3

        // ── Methods ──
        public void get_Settings(){} // RVA: 0x7FFE813240E0
        public void get_NodeType(){} // RVA: 0x7FFE80E2EDB0
        public void get_Name(){} // RVA: 0x7FFE87560DD0
        public void get_LocalName(){} // RVA: 0x7FFE80E2E2E0
        public void get_NamespaceURI(){} // RVA: 0x7FFE80E2E2E0
        public void get_Prefix(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void get_Depth(){} // RVA: 0x7FFE80E2EDB0
        public void get_BaseURI(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE80E2F150
        public void get_IsDefault(){} // RVA: 0x7FFE810FB320
        public void get_QuoteChar(){} // RVA: 0x7FFE87560EE0
        public void get_XmlSpace(){} // RVA: 0x7FFE813240E0
        public void get_XmlLang(){} // RVA: 0x7FFE87560EF0
        public void get_SchemaInfo(){} // RVA: 0x7FFE87560F30
        public void get_ValueType(){} // RVA: 0x7FFE87560F70
        public void get_AttributeCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetAttribute(){} // RVA: 0x7FFE80E3D230 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE87561020 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE80E2F150
        public void MoveToNextAttribute(){} // RVA: 0x7FFE80E2F150
        public void MoveToElement(){} // RVA: 0x7FFE80E2F150
        public void ReadAttributeValue(){} // RVA: 0x7FFE80E2F150
        public void Read(){} // RVA: 0x7FFE80E2F150
        public void get_EOF(){} // RVA: 0x7FFE80E2F150
        public void Close(){} // RVA: 0x7FFE810FB310
        public void get_ReadState(){} // RVA: 0x7FFE80E2EDB0
        public void Skip(){} // RVA: 0x7FFE875610F0
        public void get_NameTable(){} // RVA: 0x7FFE80E2E2E0
        public void LookupNamespace(){} // RVA: 0x7FFE80E2E390
        public void get_CanResolveEntity(){} // RVA: 0x7FFE810FB320
        public void ResolveEntity(){} // RVA: 0x7FFE80E45FE0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFE810FB320
        public void ReadValueChunk(){} // RVA: 0x7FFE87561200
        public void ReadString(){} // RVA: 0x7FFE87561260
        public void MoveToContent(){} // RVA: 0x7FFE875614D0
        public void ReadStartElement(){} // RVA: 0x7FFE87561570
        public void ReadElementString(){} // RVA: 0x7FFE87561670
        public void ReadEndElement(){} // RVA: 0x7FFE87561920
        public void IsStartElement(){} // RVA: 0x7FFE87561A20
        public void ReadInnerXml(){} // RVA: 0x7FFE87561B20
        public void WriteNode(){} // RVA: 0x7FFE87561FA0
        public void WriteAttributeValue(){} // RVA: 0x7FFE87562500
        public void CreateWriterForInnerOuterXml(){} // RVA: 0x7FFE87562620
        public void SetNamespacesFlag(){} // RVA: 0x7FFE87562780
        public void get_HasAttributes(){} // RVA: 0x7FFE87562890
        public void Dispose(){} // RVA: 0x7FFE875628E0 | overloaded x2
        public void get_NamespaceManager(){} // RVA: 0x7FFE813240E0
        public void IsTextualNode(){} // RVA: 0x7FFE87562920
        public void HasValueInternal(){} // RVA: 0x7FFE87562990
        public void SkipSubtree(){} // RVA: 0x7FFE87562A00
        public void get_IsDefaultInternal(){} // RVA: 0x7FFE87562AF0
        public void get_DtdInfo(){} // RVA: 0x7FFE813240E0
        public void Create(){} // RVA: 0x7FFE87562F10 | overloaded x3
        public void CreateSqlReader(){} // RVA: 0x7FFE87563090
        public void CalcBufferSize(){} // RVA: 0x7FFE875633D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87563470
    }

    public class XmlReaderSettings : Object
    {
        public bool useAsync; // 0x10
        public System.Xml.XmlNameTable nameTable; // 0x18
        public System.Xml.XmlResolver xmlResolver; // 0x20
        public int lineNumberOffset; // 0x28
        public int linePositionOffset; // 0x2C
        public 0x6655241C conformanceLevel; // 0x30
        public bool checkCharacters; // 0x34
        public long maxCharactersInDocument; // 0x38
        public long maxCharactersFromEntities; // 0x40
        public bool ignoreWhitespace; // 0x48
        public bool ignorePIs; // 0x49
        public bool ignoreComments; // 0x4A
        public 0x66552474 dtdProcessing; // 0x4C
        public 0x66553024 validationType; // 0x50
        public 0x6655E444 validationFlags; // 0x54
        public System.Xml.Schema.XmlSchemaSet schemas; // 0x58
        public System.Xml.Schema.ValidationEventHandler valEventHandler; // 0x60
        public bool closeInput; // 0x68
        public bool isReadOnly; // 0x69

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875634E0
        public void get_Async(){} // RVA: 0x7FFE811C55E0
        public void set_Async(){} // RVA: 0x7FFE875634F0
        public void get_NameTable(){} // RVA: 0x7FFE810FE7C0
        public void set_NameTable(){} // RVA: 0x7FFE87563550
        public void get_IsXmlResolverSet(){} // RVA: 0x7FFE8663A5A0
        public void set_IsXmlResolverSet(){} // RVA: 0x7FFE8663A5B0
        public void set_XmlResolver(){} // RVA: 0x7FFE875635F0
        public void GetXmlResolver(){} // RVA: 0x7FFE811290C0
        public void GetXmlResolver_CheckConfig(){} // RVA: 0x7FFE87563690
        public void get_LineNumberOffset(){} // RVA: 0x7FFE81549710
        public void set_LineNumberOffset(){} // RVA: 0x7FFE875636A0
        public void get_LinePositionOffset(){} // RVA: 0x7FFE81F84A50
        public void set_LinePositionOffset(){} // RVA: 0x7FFE875636F0
        public void get_ConformanceLevel(){} // RVA: 0x7FFE81156CD0
        public void set_ConformanceLevel(){} // RVA: 0x7FFE87563740
        public void get_CheckCharacters(){} // RVA: 0x7FFE81131C20
        public void set_CheckCharacters(){} // RVA: 0x7FFE875637E0
        public void get_MaxCharactersInDocument(){} // RVA: 0x7FFE8143BA80
        public void set_MaxCharactersInDocument(){} // RVA: 0x7FFE87563840
        public void get_MaxCharactersFromEntities(){} // RVA: 0x7FFE81178740
        public void set_MaxCharactersFromEntities(){} // RVA: 0x7FFE875638E0
        public void get_IgnoreWhitespace(){} // RVA: 0x7FFE811B2D30
        public void set_IgnoreWhitespace(){} // RVA: 0x7FFE87563980
        public void get_IgnoreProcessingInstructions(){} // RVA: 0x7FFE820ED800
        public void set_IgnoreProcessingInstructions(){} // RVA: 0x7FFE875639E0
        public void get_IgnoreComments(){} // RVA: 0x7FFE82446000
        public void set_IgnoreComments(){} // RVA: 0x7FFE87563A40
        public void get_DtdProcessing(){} // RVA: 0x7FFE821E0A40
        public void set_DtdProcessing(){} // RVA: 0x7FFE87563AA0
        public void get_CloseInput(){} // RVA: 0x7FFE811C3570
        public void set_CloseInput(){} // RVA: 0x7FFE87563B40
        public void get_ValidationType(){} // RVA: 0x7FFE8139DAD0
        public void set_ValidationType(){} // RVA: 0x7FFE87563BA0
        public void get_ValidationFlags(){} // RVA: 0x7FFE819EA920
        public void set_ValidationFlags(){} // RVA: 0x7FFE87563C40
        public void get_Schemas(){} // RVA: 0x7FFE87563CE0
        public void set_Schemas(){} // RVA: 0x7FFE87563D90
        public void Clone(){} // RVA: 0x7FFE87563E30
        public void GetEventHandler(){} // RVA: 0x7FFE81199370
        public void CreateReader(){} // RVA: 0x7FFE87564030 | overloaded x2
        public void set_ReadOnly(){} // RVA: 0x7FFE85B63740
        public void CheckReadOnly(){} // RVA: 0x7FFE87564170
        public void Initialize(){} // RVA: 0x7FFE87564220 | overloaded x2
        public void CreateDefaultResolver(){} // RVA: 0x7FFE87564440
        public void AddValidation(){} // RVA: 0x7FFE87564480
        public void CreateDtdValidatingReader(){} // RVA: 0x7FFE875645B0
        public void EnableLegacyXmlSettings(){} // RVA: 0x7FFE87564640
    }

    public class XmlRegisteredNonCachedStream : Stream
    {
        public System.IO.Stream stream; // 0x28
        public System.Xml.XmlDownloadManager downloadManager; // 0x30
        public string host; // 0x38
        public object field_3; // 0x2C9
        public object field_4; // 0x2CA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875C8C00
        public void Finalize(){} // RVA: 0x7FFE875C8D60
        public void Dispose(){} // RVA: 0x7FFE875C8E10
        public void BeginRead(){} // RVA: 0x7FFE875C8F50
        public void BeginWrite(){} // RVA: 0x7FFE875C8F90
        public void EndRead(){} // RVA: 0x7FFE875C8FD0
        public void EndWrite(){} // RVA: 0x7FFE8732A8F0
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void Read(){} // RVA: 0x7FFE875C9000
        public void ReadByte(){} // RVA: 0x7FFE86948FF0
        public void Seek(){} // RVA: 0x7FFE875C9030
        public void SetLength(){} // RVA: 0x7FFE871CDA40
        public void Write(){} // RVA: 0x7FFE875C9060
        public void WriteByte(){} // RVA: 0x7FFE875C9090
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_CanWrite(){} // RVA: 0x7FFE875C90C0
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE875535C0
    }

    public class XmlResolver : Object
    {
        // ── Methods ──
        public void GetEntity(){} // RVA: 0x7FFE80E403A0
        public void ResolveUri(){} // RVA: 0x7FFE875CFBD0
        public void SupportsType(){} // RVA: 0x7FFE875CFE70
        public void GetEntityAsync(){} // RVA: 0x7FFE875CFF90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSignificantWhitespace : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875AC5D0
        public void get_Name(){} // RVA: 0x7FFE875AC6D0
        public void get_LocalName(){} // RVA: 0x7FFE875AC6D0
        public void get_NodeType(){} // RVA: 0x7FFE824BF490
        public void get_ParentNode(){} // RVA: 0x7FFE875AC700
        public void CloneNode(){} // RVA: 0x7FFE875AC7B0
        public void get_Value(){} // RVA: 0x7FFE869FDAC0
        public void set_Value(){} // RVA: 0x7FFE875AC820
        public void WriteTo(){} // RVA: 0x7FFE875AC920
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void get_IsText(){} // RVA: 0x7FFE811E0850
    }

    public class XmlSqlBinaryReader : XmlReader
    {
        public System.Type TypeOfObject;
        public System.Type TypeOfString; // 0x8
        public System.Type[] TokenTypeMap; // 0x10
        public byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
        public 0x66552E14[] ScanState2ReadState; // 0x20
        public System.IO.Stream inStrm; // 0x10
        public byte[] data; // 0x18
        public int pos; // 0x20
        public int mark; // 0x24
        public int end; // 0x28
        public long offset; // 0x30
        public bool eof; // 0x38
        public bool sniffed; // 0x39
        public bool isEmpty; // 0x3A
        public int docState; // 0x3C
        public SymbolTables symbolTables; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8742DF40
        public void get_Settings(){} // RVA: 0x7FFE8742EA00
        public void get_NodeType(){} // RVA: 0x7FFE814AA230
        public void get_LocalName(){} // RVA: 0x7FFE817AB5E0
        public void get_NamespaceURI(){} // RVA: 0x7FFE81166040
        public void get_Prefix(){} // RVA: 0x7FFE8179C860
        public void get_Value(){} // RVA: 0x7FFE8742ECA0
        public void get_Depth(){} // RVA: 0x7FFE8742EF90
        public void get_BaseURI(){} // RVA: 0x7FFE8113A010
        public void get_IsEmptyElement(){} // RVA: 0x7FFE8742F060
        public void get_XmlSpace(){} // RVA: 0x7FFE8742F080
        public void get_XmlLang(){} // RVA: 0x7FFE8742F100
        public void get_ValueType(){} // RVA: 0x7FFE81317980
        public void get_AttributeCount(){} // RVA: 0x7FFE8742F1C0
        public void GetAttribute(){} // RVA: 0x7FFE8742F480 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE8742F5C0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE8742F670
        public void MoveToNextAttribute(){} // RVA: 0x7FFE8742F700
        public void MoveToElement(){} // RVA: 0x7FFE8742F7B0
        public void get_EOF(){} // RVA: 0x7FFE8742F960
        public void ReadAttributeValue(){} // RVA: 0x7FFE8742F970
        public void Close(){} // RVA: 0x7FFE8742FBB0
        public void get_NameTable(){} // RVA: 0x7FFE81199370
        public void LookupNamespace(){} // RVA: 0x7FFE8742FD40
        public void ResolveEntity(){} // RVA: 0x7FFE8742FE10
        public void get_ReadState(){} // RVA: 0x7FFE8742FE50
        public void Read(){} // RVA: 0x7FFE8742FED0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE87430050
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87430500
        public void VerifyVersion(){} // RVA: 0x7FFE87430670
        public void AddInitNamespace(){} // RVA: 0x7FFE874306C0
        public void AddName(){} // RVA: 0x7FFE87430830
        public void AddQName(){} // RVA: 0x7FFE87430980
        public void NameFlush(){} // RVA: 0x7FFE87430D10
        public void SkipExtn(){} // RVA: 0x7FFE87430D70
        public void ReadQNameRef(){} // RVA: 0x7FFE87430EA0
        public void ReadNameRef(){} // RVA: 0x7FFE87430F70
        public void FillAllowEOF(){} // RVA: 0x7FFE87431040
        public void Fill_(){} // RVA: 0x7FFE874312A0
        public void Fill(){} // RVA: 0x7FFE87431320
        public void ReadByte(){} // RVA: 0x7FFE874313B0
        public void ReadUShort(){} // RVA: 0x7FFE87431400
        public void ParseMB32(){} // RVA: 0x7FFE87431620 | overloaded x2
        public void ParseMB32_(){} // RVA: 0x7FFE874314C0
        public void ParseMB64(){} // RVA: 0x7FFE87431460
        public void PeekToken(){} // RVA: 0x7FFE87431730
        public void ReadToken(){} // RVA: 0x7FFE874319B0
        public void NextToken2(){} // RVA: 0x7FFE87431C40
        public void NextToken1(){} // RVA: 0x7FFE87431F80
        public void NextToken(){} // RVA: 0x7FFE87431FF0
        public void PeekNextToken(){} // RVA: 0x7FFE87432090
        public void RescanNextToken(){} // RVA: 0x7FFE874320B0
        public void ParseText(){} // RVA: 0x7FFE87432370
        public void ScanText(){} // RVA: 0x7FFE87432430
        public void GetString(){} // RVA: 0x7FFE87432590
        public void GetStringAligned(){} // RVA: 0x7FFE87432760
        public void GetAttributeText(){} // RVA: 0x7FFE874327A0
        public void LocateAttribute(){} // RVA: 0x7FFE87432A30 | overloaded x2
        public void PositionOnAttribute(){} // RVA: 0x7FFE87432B90
        public void GrowElements(){} // RVA: 0x7FFE87432D80
        public void GrowAttributes(){} // RVA: 0x7FFE87432E80
        public void ClearAttributes(){} // RVA: 0x7FFE87432F60
        public void PushNamespace(){} // RVA: 0x7FFE87432F80
        public void PopNamespaces(){} // RVA: 0x7FFE874332F0
        public void GenerateImpliedXmlnsAttrs(){} // RVA: 0x7FFE874333F0
        public void ReadInit(){} // RVA: 0x7FFE874335A0
        public void ScanAttributes(){} // RVA: 0x7FFE87433BE0
        public void SimpleCheckForDuplicateAttributes(){} // RVA: 0x7FFE87434300
        public void HashCheckForDuplicateAttributes(){} // RVA: 0x7FFE874345A0
        public void XmlDeclValue(){} // RVA: 0x7FFE87434A40
        public void CDATAValue(){} // RVA: 0x7FFE87434BA0
        public void FinishCDATA(){} // RVA: 0x7FFE87434D10
        public void FinishEndElement(){} // RVA: 0x7FFE87434DB0
        public void ReadDoc(){} // RVA: 0x7FFE87434F30
        public void ImplReadData(){} // RVA: 0x7FFE87435740
        public void ImplReadElement(){} // RVA: 0x7FFE87435970
        public void ImplReadEndElement(){} // RVA: 0x7FFE87435F90
        public void ImplReadDoctype(){} // RVA: 0x7FFE874360C0
        public void ImplReadPI(){} // RVA: 0x7FFE874364D0
        public void ImplReadComment(){} // RVA: 0x7FFE87436590
        public void ImplReadCDATA(){} // RVA: 0x7FFE874365D0
        public void ImplReadNest(){} // RVA: 0x7FFE87436660
        public void ImplReadEndNest(){} // RVA: 0x7FFE87436850
        public void ImplReadXmlText(){} // RVA: 0x7FFE87436940
        public void UpdateFromTextReader(){} // RVA: 0x7FFE874372B0 | overloaded x2
        public void CheckAllowContent(){} // RVA: 0x7FFE874372D0
        public void GenerateTokenTypeMap(){} // RVA: 0x7FFE87437330
        public void GetValueType(){} // RVA: 0x7FFE87438710
        public void ReScanOverValue(){} // RVA: 0x7FFE87438800
        public void ScanOverValue(){} // RVA: 0x7FFE87438820
        public void ScanOverAnyValue(){} // RVA: 0x7FFE87438A40
        public void CheckText(){} // RVA: 0x7FFE874390C0
        public void CheckTextIsWS(){} // RVA: 0x7FFE87439310
        public void CheckValueTokenBounds(){} // RVA: 0x7FFE874393A0
        public void GetXsdKatmaiTokenLength(){} // RVA: 0x7FFE87439400
        public void XsdKatmaiTimeScaleToValueLength(){} // RVA: 0x7FFE87439560
        public void ValueAsLong(){} // RVA: 0x7FFE87439630
        public void ValueAsULong(){} // RVA: 0x7FFE87439BB0
        public void ValueAsDecimal(){} // RVA: 0x7FFE87439C50
        public void ValueAsDouble(){} // RVA: 0x7FFE87439F70
        public void ValueAsDateTimeString(){} // RVA: 0x7FFE8743A170
        public void ValueAsString(){} // RVA: 0x7FFE8743A780
        public void GetInt16(){} // RVA: 0x7FFE8743B100
        public void GetUInt16(){} // RVA: 0x7FFE8743B100
        public void GetInt32(){} // RVA: 0x7FFE8743B150
        public void GetUInt32(){} // RVA: 0x7FFE8743B150
        public void GetInt64(){} // RVA: 0x7FFE8743B1D0
        public void GetUInt64(){} // RVA: 0x7FFE8743B1D0
        public void GetSingle(){} // RVA: 0x7FFE8743B2F0
        public void GetDouble(){} // RVA: 0x7FFE8743B370
        public void ThrowUnexpectedToken(){} // RVA: 0x7FFE8743B4A0
        public void ThrowXmlException(){} // RVA: 0x7FFE8743B570 | overloaded x2
        public void ThrowNotSupported(){} // RVA: 0x7FFE8743B660
        public void .cctor(){} // RVA: 0x7FFE8743B6D0
    }

    public class XmlText : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758E1F0 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE875AC980
        public void get_LocalName(){} // RVA: 0x7FFE875AC980
        public void get_NodeType(){} // RVA: 0x7FFE817BF630
        public void get_ParentNode(){} // RVA: 0x7FFE8758E230
        public void CloneNode(){} // RVA: 0x7FFE875AC9B0
        public void get_Value(){} // RVA: 0x7FFE869FDAC0
        public void set_Value(){} // RVA: 0x7FFE875ACA20
        public void WriteTo(){} // RVA: 0x7FFE875AC920
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void get_IsText(){} // RVA: 0x7FFE811E0850
    }

    public class XmlTextEncoder : Object
    {
        public System.IO.TextWriter textWriter; // 0x10
        public bool inAttribute; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875646F0
        public void set_QuoteChar(){} // RVA: 0x7FFE865FCE00
        public void StartAttribute(){} // RVA: 0x7FFE875647D0
        public void EndAttribute(){} // RVA: 0x7FFE875648A0
        public void get_AttributeValue(){} // RVA: 0x7FFE875648E0
        public void WriteSurrogateChar(){} // RVA: 0x7FFE87564950
        public void Write(){} // RVA: 0x7FFE87565170 | overloaded x2
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87564F30
        public void WriteRawWithSurrogateChecking(){} // RVA: 0x7FFE87565700
        public void WriteRaw(){} // RVA: 0x7FFE87565950
        public void WriteCharEntity(){} // RVA: 0x7FFE87565B10
        public void WriteEntityRef(){} // RVA: 0x7FFE87565D00
        public void WriteStringFragment(){} // RVA: 0x7FFE87565D80
        public void WriteCharEntityImpl(){} // RVA: 0x7FFE87565F40 | overloaded x2
        public void WriteEntityRefImpl(){} // RVA: 0x7FFE87565FF0
    }

    public class XmlTextReader : XmlReader
    {
        public System.Xml.XmlTextReaderImpl impl; // 0x10
        public object field_1; // 0xBC
        public object field_2; // 0xBD
        public object field_3; // 0xBE
        public object field_4; // 0xBF
        public object field_5; // 0xC0
        public object field_6; // 0xC1
        public object field_7; // 0xC2
        public object field_8; // 0xC3
        public object field_9; // 0xC4
        public object field_10; // 0xC5
        public object field_11; // 0xC6
        public object field_12; // 0xC7
        public object field_13; // 0xC8
        public object field_14; // 0xC9
        public object field_15; // 0xCA
        public object field_16; // 0xCB
        public object field_17; // 0xCC
        public object field_18; // 0xCD
        public object field_19; // 0xCE
        public object field_20; // 0xCF
        public object field_21; // 0xD0
        public object field_22; // 0xD1
        public object field_23; // 0xD2
        public object field_24; // 0xD3
        public object field_25; // 0xD4
        public object field_26; // 0xD5
        public object field_27; // 0xD6
        public object field_28; // 0xD7
        public object field_29; // 0xD8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87566570 | overloaded x4
        public void get_NodeType(){} // RVA: 0x7FFE81588760
        public void get_Name(){} // RVA: 0x7FFE86BADCC0
        public void get_LocalName(){} // RVA: 0x7FFE81567090
        public void get_NamespaceURI(){} // RVA: 0x7FFE86853DC0
        public void get_Prefix(){} // RVA: 0x7FFE86853DF0
        public void get_Value(){} // RVA: 0x7FFE826F8E90
        public void get_Depth(){} // RVA: 0x7FFE87119A80
        public void get_BaseURI(){} // RVA: 0x7FFE815889F0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE81588880
        public void get_IsDefault(){} // RVA: 0x7FFE815888B0
        public void get_QuoteChar(){} // RVA: 0x7FFE81588730
        public void get_XmlSpace(){} // RVA: 0x7FFE815889C0
        public void get_XmlLang(){} // RVA: 0x7FFE81588910
        public void get_AttributeCount(){} // RVA: 0x7FFE86F36C70
        public void GetAttribute(){} // RVA: 0x7FFE872B3070 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE872B30D0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE86853FA0
        public void MoveToNextAttribute(){} // RVA: 0x7FFE86942D00
        public void MoveToElement(){} // RVA: 0x7FFE86942D30
        public void ReadAttributeValue(){} // RVA: 0x7FFE86BAD390
        public void Read(){} // RVA: 0x7FFE872B3100
        public void get_EOF(){} // RVA: 0x7FFE872B3130
        public void Close(){} // RVA: 0x7FFE86BADE80
        public void get_ReadState(){} // RVA: 0x7FFE872B3160
        public void Skip(){} // RVA: 0x7FFE867799F0
        public void get_NameTable(){} // RVA: 0x7FFE86BACEC0
        public void LookupNamespace(){} // RVA: 0x7FFE87566710
        public void get_CanResolveEntity(){} // RVA: 0x7FFE811E0850
        public void ResolveEntity(){} // RVA: 0x7FFE872B31F0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFE810FB320
        public void ReadString(){} // RVA: 0x7FFE87566750
        public void HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void get_LineNumber(){} // RVA: 0x7FFE87566780
        public void get_LinePosition(){} // RVA: 0x7FFE875667B0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE875667E0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE872B3190
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87566820
        public void get_Namespaces(){} // RVA: 0x7FFE81D3A2A0
        public void get_Normalization(){} // RVA: 0x7FFE87566860
        public void set_Normalization(){} // RVA: 0x7FFE87566880
        public void set_WhitespaceHandling(){} // RVA: 0x7FFE87566960
        public void set_EntityHandling(){} // RVA: 0x7FFE87566A60
        public void set_XmlResolver(){} // RVA: 0x7FFE87566B00
        public void get_Impl(){} // RVA: 0x7FFE81116380
        public void get_NamespaceManager(){} // RVA: 0x7FFE87566B20
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7FFE87566B50
        public void get_DtdInfo(){} // RVA: 0x7FFE87566B70
    }

    public class XmlTextReaderImpl : XmlReader
    {
        public bool useAsync; // 0x10
        public LaterInitParam laterInitParam; // 0x18
        public System.Xml.XmlCharType xmlCharType; // 0x20
        public ParsingState ps; // 0x28
        public 0x6655375C parsingFunction; // 0xA0
        public 0x6655375C nextParsingFunction; // 0xA4
        public 0x6655375C nextNextParsingFunction; // 0xA8
        public NodeData[] nodes; // 0xB0
        public NodeData curNode; // 0xB8
        public int index; // 0xC0
        public int curAttrIndex; // 0xC4
        public int attrCount; // 0xC8
        public int attrHashtable; // 0xCC
        public int attrDuplWalkCount; // 0xD0
        public bool attrNeedNamespaceLookup; // 0xD4
        public bool fullAttrCleanup; // 0xD5
        public NodeData[] attrDuplSortingArray; // 0xD8
        public System.Xml.XmlNameTable nameTable; // 0xE0
        public bool nameTableFromSettings; // 0xE8
        public System.Xml.XmlResolver xmlResolver; // 0xF0
        public string url; // 0xF8
        public bool normalize; // 0x100
        public bool supportNamespaces; // 0x101
        public 0x6655307C whitespaceHandling; // 0x104
        public 0x66552474 dtdProcessing; // 0x108
        public 0x665524CC entityHandling; // 0x10C
        public bool ignorePIs; // 0x110
        public bool ignoreComments; // 0x111
        public bool checkCharacters; // 0x112
        public int lineNumberOffset; // 0x114
        public int linePositionOffset; // 0x118
        public bool closeInput; // 0x11C
        public long maxCharactersInDocument; // 0x120
        public long maxCharactersFromEntities; // 0x128
        public bool v1Compat; // 0x130
        public System.Xml.XmlNamespaceManager namespaceManager; // 0x138
        public string lastPrefix; // 0x140
        public XmlContext xmlContext; // 0x148
        public ParsingState[] parsingStatesStack; // 0x150
        public int parsingStatesStackTop; // 0x158
        public string reportedBaseUri; // 0x160
        public System.Text.Encoding reportedEncoding; // 0x168
        public System.Xml.IDtdInfo dtdInfo; // 0x170
        public 0x66556674 fragmentType; // 0x178
        public System.Xml.XmlParserContext fragmentParserContext; // 0x180
        public bool fragment; // 0x188
        public System.Xml.IncrementalReadDecoder incReadDecoder; // 0x190
        public 0x665538BC incReadState; // 0x198
        public System.Xml.LineInfo incReadLineInfo; // 0x19C
        public int incReadDepth; // 0x1A4
        public int incReadLeftStartPos; // 0x1A8
        public int incReadLeftEndPos; // 0x1AC
        public int attributeValueBaseEntityId; // 0x1B0
        public bool emptyEntityInAttributeResolved; // 0x1B4
        public System.Xml.IValidationEventHandling validationEventHandling; // 0x1B8
        public OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
        public bool validatingReaderCompatFlag; // 0x1C8
        public bool addDefaultAttributesAndNormalize; // 0x1C9
        public System.Text.StringBuilder stringBuilder; // 0x1D0
        public bool rootElementParsed; // 0x1D8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87453600 | overloaded x12
        public void FinishInitUriString(){} // RVA: 0x7FFE874527C0
        public void FinishInitStream(){} // RVA: 0x7FFE874530F0
        public void FinishInitTextReader(){} // RVA: 0x7FFE874534C0
        public void get_Settings(){} // RVA: 0x7FFE87453760
        public void get_NodeType(){} // RVA: 0x7FFE87453B20
        public void get_Name(){} // RVA: 0x7FFE87453B40
        public void get_LocalName(){} // RVA: 0x7FFE87453B70
        public void get_NamespaceURI(){} // RVA: 0x7FFE87453B90
        public void get_Prefix(){} // RVA: 0x7FFE87453BB0
        public void get_Value(){} // RVA: 0x7FFE87453BD0
        public void get_Depth(){} // RVA: 0x7FFE87453D50
        public void get_BaseURI(){} // RVA: 0x7FFE81624E50
        public void get_IsEmptyElement(){} // RVA: 0x7FFE87453D70
        public void get_IsDefault(){} // RVA: 0x7FFE87453DA0
        public void get_QuoteChar(){} // RVA: 0x7FFE87453DD0
        public void get_XmlSpace(){} // RVA: 0x7FFE87453E00
        public void get_XmlLang(){} // RVA: 0x7FFE87453E20
        public void get_ReadState(){} // RVA: 0x7FFE87453E40
        public void get_EOF(){} // RVA: 0x7FFE87453E50
        public void get_NameTable(){} // RVA: 0x7FFE8117C900
        public void get_CanResolveEntity(){} // RVA: 0x7FFE811E0850
        public void get_AttributeCount(){} // RVA: 0x7FFE81790750
        public void GetAttribute(){} // RVA: 0x7FFE87454040 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE87454200 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE87454330
        public void MoveToNextAttribute(){} // RVA: 0x7FFE874543F0
        public void MoveToElement(){} // RVA: 0x7FFE874544D0
        public void FinishInit(){} // RVA: 0x7FFE874545A0
        public void Read(){} // RVA: 0x7FFE874545F0
        public void Close(){} // RVA: 0x7FFE8745AF40 | overloaded x2
        public void Skip(){} // RVA: 0x7FFE87454EB0
        public void LookupNamespace(){} // RVA: 0x7FFE87468190 | overloaded x2
        public void ReadAttributeValue(){} // RVA: 0x7FFE87455110
        public void ResolveEntity(){} // RVA: 0x7FFE87455440
        public void set_OuterReader(){} // RVA: 0x7FFE81B21BD0
        public void MoveOffEntityReference(){} // RVA: 0x7FFE874556F0
        public void ReadString(){} // RVA: 0x7FFE874557C0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFE811E0850
        public void ReadValueChunk(){} // RVA: 0x7FFE874557E0
        public void HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void get_LineNumber(){} // RVA: 0x7FFE87455DB0
        public void get_LinePosition(){} // RVA: 0x7FFE87455DD0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE87455DF0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE871F5CD0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87455E20
        public void GetNamespacesInScope(){} // RVA: 0x7FFE87455DF0
        public void LookupPrefix(){} // RVA: 0x7FFE87455E20
        public void get_Namespaces(){} // RVA: 0x7FFE82904E20
        public void set_Namespaces(){} // RVA: 0x7FFE87455E50
        public void get_Normalization(){} // RVA: 0x7FFE81F84400
        public void set_Normalization(){} // RVA: 0x7FFE87456150
        public void set_WhitespaceHandling(){} // RVA: 0x7FFE87456230
        public void set_EntityHandling(){} // RVA: 0x7FFE87456320
        public void get_IsResolverSet(){} // RVA: 0x7FFE874563B0
        public void set_XmlResolver(){} // RVA: 0x7FFE874563C0
        public void get_DtdParserProxy_NameTable(){} // RVA: 0x7FFE8117C900
        public void get_DtdParserProxy_NamespaceResolver(){} // RVA: 0x7FFE8181EA70
        public void get_DtdParserProxy_DtdValidation(){} // RVA: 0x7FFE87456550
        public void get_DtdParserProxy_Normalization(){} // RVA: 0x7FFE81F84400
        public void get_DtdParserProxy_Namespaces(){} // RVA: 0x7FFE82904E20
        public void get_DtdParserProxy_V1CompatibilityMode(){} // RVA: 0x7FFE87456560
        public void get_DtdParserProxy_BaseUri(){} // RVA: 0x7FFE87456570
        public void get_DtdParserProxy_IsEof(){} // RVA: 0x7FFE820C4230
        public void get_DtdParserProxy_ParsingBuffer(){} // RVA: 0x7FFE81129130
        public void get_DtdParserProxy_ParsingBufferLength(){} // RVA: 0x7FFE82447220
        public void get_DtdParserProxy_CurrentPosition(){} // RVA: 0x7FFE81156CD0
        public void set_DtdParserProxy_CurrentPosition(){} // RVA: 0x7FFE81156CE0
        public void get_DtdParserProxy_EntityStackLength(){} // RVA: 0x7FFE87456630
        public void get_DtdParserProxy_IsEntityEolNormalized(){} // RVA: 0x7FFE86EB9990
        public void get_DtdParserProxy_ValidationEventHandling(){} // RVA: 0x7FFE81B164E0
        public void DtdParserProxy_OnNewLine(){} // RVA: 0x7FFE87456640
        public void get_DtdParserProxy_LineNo(){} // RVA: 0x7FFE81E60180
        public void get_DtdParserProxy_LineStartPosition(){} // RVA: 0x7FFE826A9B90
        public void DtdParserProxy_ReadData(){} // RVA: 0x7FFE87456650
        public void DtdParserProxy_ParseNumericCharRef(){} // RVA: 0x7FFE87456660
        public void DtdParserProxy_ParseNamedCharRef(){} // RVA: 0x7FFE87456710
        public void DtdParserProxy_ParsePI(){} // RVA: 0x7FFE87456720
        public void DtdParserProxy_ParseComment(){} // RVA: 0x7FFE87456770
        public void get_IsResolverNull(){} // RVA: 0x7FFE87456F80
        public void GetTempResolver(){} // RVA: 0x7FFE87456F90
        public void DtdParserProxy_PushEntity(){} // RVA: 0x7FFE87456FF0
        public void DtdParserProxy_PopEntity(){} // RVA: 0x7FFE874570B0
        public void DtdParserProxy_PushExternalSubset(){} // RVA: 0x7FFE874571A0
        public void DtdParserProxy_PushInternalDtd(){} // RVA: 0x7FFE87457340
        public void DtdParserProxy_Throw(){} // RVA: 0x7FFE87457420
        public void DtdParserProxy_OnSystemId(){} // RVA: 0x7FFE87457430
        public void DtdParserProxy_OnPublicId(){} // RVA: 0x7FFE87457510
        public void Throw(){} // RVA: 0x7FFE87457AA0 | overloaded x11
        public void ReThrow(){} // RVA: 0x7FFE87457B40
        public void ThrowWithoutLineInfo(){} // RVA: 0x7FFE87457D00 | overloaded x3
        public void ThrowInvalidChar(){} // RVA: 0x7FFE87457D90
        public void SetErrorState(){} // RVA: 0x7FFE87457E00
        public void SendValidationEvent(){} // RVA: 0x7FFE87457F10 | overloaded x2
        public void get_InAttributeValueIterator(){} // RVA: 0x7FFE87457F80
        public void FinishAttributeValueIterator(){} // RVA: 0x7FFE87457FA0
        public void get_DtdValidation(){} // RVA: 0x7FFE87456550
        public void InitStreamInput(){} // RVA: 0x7FFE874581C0 | overloaded x5
        public void InitTextReaderInput(){} // RVA: 0x7FFE87458880 | overloaded x2
        public void InitStringInput(){} // RVA: 0x7FFE87458AE0
        public void InitFragmentReader(){} // RVA: 0x7FFE87458D20
        public void ProcessDtdFromParserContext(){} // RVA: 0x7FFE87459310
        public void OpenUrl(){} // RVA: 0x7FFE87459380
        public void OpenUrlDelegate(){} // RVA: 0x7FFE87459620
        public void DetectEncoding(){} // RVA: 0x7FFE87459850
        public void SetupEncoding(){} // RVA: 0x7FFE87459A80
        public void SwitchEncoding(){} // RVA: 0x7FFE87459D90
        public void CheckEncoding(){} // RVA: 0x7FFE87459F50
        public void UnDecodeChars(){} // RVA: 0x7FFE8745A620
        public void SwitchEncodingToUTF8(){} // RVA: 0x7FFE8745A6D0
        public void ReadData(){} // RVA: 0x7FFE8745A770
        public void GetChars(){} // RVA: 0x7FFE8745AD10
        public void InvalidCharRecovery(){} // RVA: 0x7FFE8745ADF0
        public void ShiftBuffer(){} // RVA: 0x7FFE8745B290
        public void ParseXmlDeclaration(){} // RVA: 0x7FFE8745B2C0
        public void ParseDocumentContent(){} // RVA: 0x7FFE8745C710
        public void ParseElementContent(){} // RVA: 0x7FFE8745CD40
        public void ThrowUnclosedElements(){} // RVA: 0x7FFE8745D170
        public void ParseElement(){} // RVA: 0x7FFE8745D360
        public void AddDefaultAttributesAndNormalize(){} // RVA: 0x7FFE8745D970
        public void ParseEndElement(){} // RVA: 0x7FFE8745E010
        public void ThrowTagMismatch(){} // RVA: 0x7FFE8745E520
        public void ParseAttributes(){} // RVA: 0x7FFE8745E700
        public void ElementNamespaceLookup(){} // RVA: 0x7FFE8745ECD0
        public void AttributeNamespaceLookup(){} // RVA: 0x7FFE8745EE00
        public void AttributeDuplCheck(){} // RVA: 0x7FFE8745EEB0
        public void OnDefaultNamespaceDecl(){} // RVA: 0x7FFE8745F2B0
        public void OnNamespaceDecl(){} // RVA: 0x7FFE8745F4A0
        public void OnXmlReservedAttribute(){} // RVA: 0x7FFE8745F590
        public void ParseAttributeValueSlow(){} // RVA: 0x7FFE8745F8B0
        public void AddAttributeChunkToList(){} // RVA: 0x7FFE87460BC0
        public void ParseText(){} // RVA: 0x7FFE874611A0 | overloaded x2
        public void FinishPartialValue(){} // RVA: 0x7FFE87461890
        public void FinishOtherValueIterator(){} // RVA: 0x7FFE87461DE0
        public void SkipPartialTextValue(){} // RVA: 0x7FFE87461F30
        public void FinishReadValueChunk(){} // RVA: 0x7FFE87461F90
        public void FinishReadContentAsBinary(){} // RVA: 0x7FFE87461FD0
        public void FinishReadElementContentAsBinary(){} // RVA: 0x7FFE87462130
        public void ParseRootLevelWhitespace(){} // RVA: 0x7FFE87462200
        public void ParseEntityReference(){} // RVA: 0x7FFE87462430
        public void HandleEntityReference(){} // RVA: 0x7FFE874624E0
        public void HandleGeneralEntityReference(){} // RVA: 0x7FFE87462770
        public void get_InEntity(){} // RVA: 0x7FFE87462BC0
        public void HandleEntityEnd(){} // RVA: 0x7FFE87462BD0
        public void SetupEndEntityNodeInContent(){} // RVA: 0x7FFE87462E60
        public void SetupEndEntityNodeInAttribute(){} // RVA: 0x7FFE874630A0
        public void ParsePI(){} // RVA: 0x7FFE87463180 | overloaded x2
        public void ParsePIValue(){} // RVA: 0x7FFE874639A0
        public void ParseComment(){} // RVA: 0x7FFE87463D20
        public void ParseCData(){} // RVA: 0x7FFE874642C0
        public void ParseCDataOrComment(){} // RVA: 0x7FFE874647F0 | overloaded x2
        public void ParseDoctypeDecl(){} // RVA: 0x7FFE87464C30
        public void ParseDtd(){} // RVA: 0x7FFE87464F80
        public void SkipDtd(){} // RVA: 0x7FFE874652E0
        public void SkipPublicOrSystemIdLiteral(){} // RVA: 0x7FFE87465CE0
        public void SkipUntil(){} // RVA: 0x7FFE87465D80
        public void EatWhitespaces(){} // RVA: 0x7FFE87466220
        public void ParseCharRefInline(){} // RVA: 0x7FFE87466460
        public void ParseNumericCharRef(){} // RVA: 0x7FFE874664E0
        public void ParseNumericCharRefInline(){} // RVA: 0x7FFE874665B0
        public void ParseNamedCharRef(){} // RVA: 0x7FFE87466DA0
        public void ParseNamedCharRefInline(){} // RVA: 0x7FFE874670D0
        public void ParseName(){} // RVA: 0x7FFE874673E0
        public void ParseQName(){} // RVA: 0x7FFE87467430 | overloaded x2
        public void ReadDataInName(){} // RVA: 0x7FFE874676D0
        public void ParseEntityName(){} // RVA: 0x7FFE87467710
        public void AddNode(){} // RVA: 0x7FFE87467810
        public void AllocNode(){} // RVA: 0x7FFE87467860
        public void AddAttributeNoChecks(){} // RVA: 0x7FFE87467A20
        public void AddAttribute(){} // RVA: 0x7FFE87467E00 | overloaded x2
        public void PopElementContext(){} // RVA: 0x7FFE87467F90
        public void OnNewLine(){} // RVA: 0x7FFE87456640
        public void OnEof(){} // RVA: 0x7FFE87468050
        public void AddNamespace(){} // RVA: 0x7FFE87468270
        public void ResetAttributes(){} // RVA: 0x7FFE87468530
        public void FullAttributeCleanup(){} // RVA: 0x7FFE87468640
        public void PushXmlContext(){} // RVA: 0x7FFE87468720
        public void PopXmlContext(){} // RVA: 0x7FFE874688E0
        public void GetWhitespaceType(){} // RVA: 0x7FFE87468970
        public void GetTextNodeType(){} // RVA: 0x7FFE874689C0
        public void PushExternalEntityOrSubset(){} // RVA: 0x7FFE87468A20
        public void OpenAndPush(){} // RVA: 0x7FFE87468D80
        public void PushExternalEntity(){} // RVA: 0x7FFE87469090
        public void PushInternalEntity(){} // RVA: 0x7FFE87469290
        public void PopEntity(){} // RVA: 0x7FFE87469410
        public void RegisterEntity(){} // RVA: 0x7FFE874694B0
        public void UnregisterEntity(){} // RVA: 0x7FFE874697C0
        public void PushParsingState(){} // RVA: 0x7FFE87469830
        public void PopParsingState(){} // RVA: 0x7FFE87469AB0
        public void IncrementalRead(){} // RVA: 0x7FFE87469BF0
        public void FinishIncrementalRead(){} // RVA: 0x7FFE8746A8F0
        public void ParseFragmentAttribute(){} // RVA: 0x7FFE8746AA00
        public void ParseAttributeValueChunk(){} // RVA: 0x7FFE8746AAA0
        public void ParseXmlDeclarationFragment(){} // RVA: 0x7FFE8746B230
        public void ThrowUnexpectedToken(){} // RVA: 0x7FFE8746B310 | overloaded x4
        public void ParseUnexpectedToken(){} // RVA: 0x7FFE8746B490 | overloaded x2
        public void ThrowExpectingWhitespace(){} // RVA: 0x7FFE8746B560
        public void GetIndexOfAttributeWithoutPrefix(){} // RVA: 0x7FFE8746B5F0
        public void GetIndexOfAttributeWithPrefix(){} // RVA: 0x7FFE8746B6B0
        public void ZeroEndingStream(){} // RVA: 0x7FFE8746B790
        public void ParseDtdFromParserContext(){} // RVA: 0x7FFE8746B800
        public void MoveToNextContentNode(){} // RVA: 0x7FFE8746BA60
        public void SetupFromParserContext(){} // RVA: 0x7FFE8746BB70
        public void get_DtdInfo(){} // RVA: 0x7FFE815BB6A0
        public void SetDtdInfo(){} // RVA: 0x7FFE8746BF90
        public void set_ValidationEventHandling(){} // RVA: 0x7FFE81B38D70
        public void set_OnDefaultAttributeUse(){} // RVA: 0x7FFE81B0C930
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7FFE8746C090
        public void get_FragmentType(){} // RVA: 0x7FFE81624CA0
        public void ChangeCurrentNodeType(){} // RVA: 0x7FFE8746C180
        public void GetResolver(){} // RVA: 0x7FFE8746C1A0
        public void set_InternalSchemaType(){} // RVA: 0x7FFE8746C1C0
        public void get_InternalTypedValue(){} // RVA: 0x7FFE8746C230
        public void set_InternalTypedValue(){} // RVA: 0x7FFE8746C260
        public void get_StandAlone(){} // RVA: 0x7FFE82A2C630
        public void get_NamespaceManager(){} // RVA: 0x7FFE8181EA70
        public void get_V1Compat(){} // RVA: 0x7FFE87456560
        public void AddDefaultAttributeDtd(){} // RVA: 0x7FFE8746C2D0
        public void AddDefaultAttributeNonDtd(){} // RVA: 0x7FFE8746C670
        public void AddDefaultAttributeInternal(){} // RVA: 0x7FFE8746CA20
        public void set_DisableUndeclaredEntityCheck(){} // RVA: 0x7FFE8746CD70
        public void UriEqual(){} // RVA: 0x7FFE8746CD80
        public void RegisterConsumedCharacters(){} // RVA: 0x7FFE8746CE90
        public void StripSpaces(){} // RVA: 0x7FFE8746D220 | overloaded x2
        public void BlockCopyChars(){} // RVA: 0x7FFE86AB0AB0
        public void BlockCopy(){} // RVA: 0x7FFE8746D340
    }

    public class XmlTextWriter : XmlWriter
    {
        public System.IO.TextWriter textWriter; // 0x18
        public System.Xml.XmlTextEncoder xmlEncoder; // 0x20
        public System.Text.Encoding encoding; // 0x28
        public 0x66553C84 formatting; // 0x30
        public bool indented; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875697B0 | overloaded x4
        public void get_BaseStream(){} // RVA: 0x7FFE87569970
        public void set_Namespaces(){} // RVA: 0x7FFE87569A10
        public void set_Formatting(){} // RVA: 0x7FFE87569A90
        public void set_QuoteChar(){} // RVA: 0x7FFE87569AA0
        public void WriteStartDocument(){} // RVA: 0x7FFE87569B50 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFE87569B70
        public void WriteDocType(){} // RVA: 0x7FFE87569D60
        public void WriteStartElement(){} // RVA: 0x7FFE8756A170
        public void WriteEndElement(){} // RVA: 0x7FFE8756A720
        public void WriteFullEndElement(){} // RVA: 0x7FFE8756A730
        public void WriteStartAttribute(){} // RVA: 0x7FFE8756A740
        public void WriteEndAttribute(){} // RVA: 0x7FFE8756AF30
        public void WriteCData(){} // RVA: 0x7FFE8756AF80
        public void WriteComment(){} // RVA: 0x7FFE8756B2C0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE8756B630
        public void WriteEntityRef(){} // RVA: 0x7FFE8756BA30
        public void WriteCharEntity(){} // RVA: 0x7FFE8756BB10
        public void WriteWhitespace(){} // RVA: 0x7FFE8756BB80
        public void WriteString(){} // RVA: 0x7FFE8756BCF0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE8756BD70
        public void WriteChars(){} // RVA: 0x7FFE8756BE00
        public void WriteRaw(){} // RVA: 0x7FFE8756BF40 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE8756BFB0
        public void WriteBinHex(){} // RVA: 0x7FFE8756C160
        public void get_WriteState(){} // RVA: 0x7FFE8756C1F0
        public void Close(){} // RVA: 0x7FFE8756C260
        public void Flush(){} // RVA: 0x7FFE8756C370
        public void LookupPrefix(){} // RVA: 0x7FFE8756C3A0
        public void StartDocument(){} // RVA: 0x7FFE8756C4E0
        public void AutoComplete(){} // RVA: 0x7FFE8756C880
        public void AutoCompleteAll(){} // RVA: 0x7FFE8756CEA0
        public void InternalWriteEndElement(){} // RVA: 0x7FFE8756CF00
        public void WriteEndStartTag(){} // RVA: 0x7FFE8756D330
        public void WriteEndAttributeQuote(){} // RVA: 0x7FFE8756D790
        public void Indent(){} // RVA: 0x7FFE8756D810
        public void PushNamespace(){} // RVA: 0x7FFE8756D900
        public void AddNamespace(){} // RVA: 0x7FFE8756DC40
        public void AddToNamespaceHashtable(){} // RVA: 0x7FFE8756DFC0
        public void PopNamespaces(){} // RVA: 0x7FFE8756E100
        public void GeneratePrefix(){} // RVA: 0x7FFE8756E230
        public void InternalWriteProcessingInstruction(){} // RVA: 0x7FFE8756E470
        public void LookupNamespace(){} // RVA: 0x7FFE8756E590
        public void LookupNamespaceInCurrentScope(){} // RVA: 0x7FFE8756E700
        public void FindPrefix(){} // RVA: 0x7FFE8756E8A0
        public void ValidateName(){} // RVA: 0x7FFE8756E9B0
        public void HandleSpecialAttribute(){} // RVA: 0x7FFE8756EC30
        public void VerifyPrefixXml(){} // RVA: 0x7FFE8756EF60
        public void PushStack(){} // RVA: 0x7FFE8756F060
        public void FlushEncoders(){} // RVA: 0x7FFE8756F290
        public void .cctor(){} // RVA: 0x7FFE8756F2D0
    }

    public class XmlTextWriterBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874284B0
        public void WriteChars(){} // RVA: 0x7FFE87428550
    }

    public class XmlUnspecifiedAttribute : XmlAttribute
    {
        public bool fSpecified; // 0x28
        public object field_1; // 0x2AC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8758B5B0
        public void get_Specified(){} // RVA: 0x7FFE815F1380
        public void CloneNode(){} // RVA: 0x7FFE875ACAE0
        public void set_InnerText(){} // RVA: 0x7FFE875ACC30
        public void InsertBefore(){} // RVA: 0x7FFE875ACCB0
        public void InsertAfter(){} // RVA: 0x7FFE875ACD40
        public void RemoveChild(){} // RVA: 0x7FFE875ACDD0
        public void AppendChild(){} // RVA: 0x7FFE875ACE60
        public void WriteTo(){} // RVA: 0x7FFE875ACEF0
        public void SetSpecified(){} // RVA: 0x7FFE81C15740
    }

    public class XmlUrlResolver : XmlResolver
    {
        public object s_DownloadManager;

        // ── Methods ──
        public void get_DownloadManager(){} // RVA: 0x7FFE875CFFD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetEntity(){} // RVA: 0x7FFE875D00E0
        public void ResolveUri(){} // RVA: 0x7FFE875D0350
        public void GetEntityAsync(){} // RVA: 0x7FFE875D0360
    }

    public class XmlUtf8RawTextWriter : XmlRawWriter
    {
        public bool useAsync; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8756FC90 | overloaded x2
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE87570270 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE875702E0
        public void WriteStartElement(){} // RVA: 0x7FFE87570550
        public void StartElementContent(){} // RVA: 0x7FFE87570600
        public void WriteEndElement(){} // RVA: 0x7FFE87570640
        public void WriteFullEndElement(){} // RVA: 0x7FFE87570790
        public void WriteStartAttribute(){} // RVA: 0x7FFE87570890
        public void WriteEndAttribute(){} // RVA: 0x7FFE87570990
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFE87559D60
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFE811E0850
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFE875709D0
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFE87570B00
        public void WriteCData(){} // RVA: 0x7FFE87570B40
        public void WriteComment(){} // RVA: 0x7FFE87570D30
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE87570E50
        public void WriteEntityRef(){} // RVA: 0x7FFE87570F70
        public void WriteCharEntity(){} // RVA: 0x7FFE87571010
        public void WriteWhitespace(){} // RVA: 0x7FFE87571270
        public void WriteString(){} // RVA: 0x7FFE87571270
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE875712B0
        public void WriteChars(){} // RVA: 0x7FFE87440FA0
        public void WriteRaw(){} // RVA: 0x7FFE87554810 | overloaded x2
        public void Close(){} // RVA: 0x7FFE875714E0
        public void Flush(){} // RVA: 0x7FFE87571630
        public void FlushBuffer(){} // RVA: 0x7FFE87571680
        public void FlushEncoder(){} // RVA: 0x7FFE810FB310
        public void WriteAttributeTextBlock(){} // RVA: 0x7FFE875719F0
        public void WriteElementTextBlock(){} // RVA: 0x7FFE87571CB0
        public void RawText(){} // RVA: 0x7FFE87571FD0 | overloaded x2
        public void WriteRawWithCharChecking(){} // RVA: 0x7FFE87572160
        public void WriteCommentOrPi(){} // RVA: 0x7FFE87572400
        public void WriteCDataSection(){} // RVA: 0x7FFE875727E0
        public void IsSurrogateByte(){} // RVA: 0x7FFE87572B80
        public void EncodeSurrogate(){} // RVA: 0x7FFE87572B90
        public void InvalidXmlChar(){} // RVA: 0x7FFE87572D40
        public void EncodeChar(){} // RVA: 0x7FFE87572F50
        public void EncodeMultibyteUTF8(){} // RVA: 0x7FFE87573020
        public void CharToUTF8(){} // RVA: 0x7FFE87573070
        public void WriteNewLine(){} // RVA: 0x7FFE87573130
        public void LtEntity(){} // RVA: 0x7FFE875731A0
        public void GtEntity(){} // RVA: 0x7FFE875731B0
        public void AmpEntity(){} // RVA: 0x7FFE875731C0
        public void QuoteEntity(){} // RVA: 0x7FFE875731D0
        public void TabEntity(){} // RVA: 0x7FFE875731F0
        public void LineFeedEntity(){} // RVA: 0x7FFE87573200
        public void CarriageReturnEntity(){} // RVA: 0x7FFE87573210
        public void CharEntity(){} // RVA: 0x7FFE87573220
        public void RawStartCData(){} // RVA: 0x7FFE87573370
        public void RawEndCData(){} // RVA: 0x7FFE87573390
        public void ValidateContentChars(){} // RVA: 0x7FFE875733A0
    }

    public class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875737A0
        public void WriteDocType(){} // RVA: 0x7FFE875737D0
        public void WriteStartElement(){} // RVA: 0x7FFE87573840
        public void StartElementContent(){} // RVA: 0x7FFE87573970
        public void OnRootElement(){} // RVA: 0x7FFE86B5F1F0
        public void WriteEndElement(){} // RVA: 0x7FFE875739E0
        public void WriteFullEndElement(){} // RVA: 0x7FFE87573AB0
        public void WriteStartAttribute(){} // RVA: 0x7FFE87573C30
        public void WriteCData(){} // RVA: 0x7FFE87573D40
        public void WriteComment(){} // RVA: 0x7FFE87573D50
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE87573D90
        public void WriteEntityRef(){} // RVA: 0x7FFE87573ED0
        public void WriteCharEntity(){} // RVA: 0x7FFE87573F80
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87573F90
        public void WriteWhitespace(){} // RVA: 0x7FFE87573FA0
        public void WriteString(){} // RVA: 0x7FFE87573FA0
        public void WriteChars(){} // RVA: 0x7FFE87573FF0
        public void WriteRaw(){} // RVA: 0x7FFE87574090 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE875740E0
        public void Init(){} // RVA: 0x7FFE87574100
        public void WriteIndent(){} // RVA: 0x7FFE875742E0
    }

    public class XmlValidatingReader : XmlReader
    {
        public System.Xml.XmlValidatingReaderImpl impl; // 0x10
        public object field_1; // 0x137
        public object field_2; // 0x138
        public object field_3; // 0x139
        public object field_4; // 0x13A
        public object field_5; // 0x13B
        public object field_6; // 0x13C
        public object field_7; // 0x13D
        public object field_8; // 0x13E
        public object field_9; // 0x13F
        public object field_10; // 0x140
        public object field_11; // 0x141
        public object field_12; // 0x142

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7FFE81588760
        public void get_LocalName(){} // RVA: 0x7FFE81567090
        public void get_NamespaceURI(){} // RVA: 0x7FFE86853DC0
        public void get_Prefix(){} // RVA: 0x7FFE86853DF0
        public void get_Value(){} // RVA: 0x7FFE826F8E90
        public void get_Depth(){} // RVA: 0x7FFE87119A80
        public void get_BaseURI(){} // RVA: 0x7FFE815889F0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE81588880
        public void get_AttributeCount(){} // RVA: 0x7FFE86F36C70
        public void GetAttribute(){} // RVA: 0x7FFE872B3070 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE872B30A0
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE86853FA0
        public void MoveToNextAttribute(){} // RVA: 0x7FFE86942D00
        public void MoveToElement(){} // RVA: 0x7FFE86942D30
        public void ReadAttributeValue(){} // RVA: 0x7FFE86BAD390
        public void Read(){} // RVA: 0x7FFE872B3100
        public void get_EOF(){} // RVA: 0x7FFE872B3130
        public void get_ReadState(){} // RVA: 0x7FFE872B3160
        public void get_NameTable(){} // RVA: 0x7FFE86BACEC0
        public void LookupNamespace(){} // RVA: 0x7FFE87566710
        public void ResolveEntity(){} // RVA: 0x7FFE872B31F0
        public void get_Namespaces(){} // RVA: 0x7FFE87574360
    }

    public class XmlValidatingReaderImpl : XmlReader
    {
        public System.Xml.XmlReader coreReader; // 0x10
        public System.Xml.XmlTextReaderImpl coreReaderImpl; // 0x18
        public System.Xml.IXmlNamespaceResolver coreReaderNSResolver; // 0x20
        public 0x66553024 validationType; // 0x28
        public System.Xml.Schema.BaseValidator validator; // 0x30
        public System.Xml.Schema.XmlSchemaCollection schemaCollection; // 0x38
        public bool processIdentityConstraints; // 0x40
        public 0x6655404C parsingFunction; // 0x44
        public ValidationEventHandling eventHandling; // 0x48
        public System.Xml.XmlParserContext parserContext; // 0x50
        public System.Xml.ReadContentAsBinaryHelper readBinaryHelper; // 0x58
        public System.Xml.XmlReader outerReader; // 0x60
        public System.Xml.XmlResolver s_tempResolver;
        public object field_13; // 0x144
        public object field_14; // 0x145
        public object field_15; // 0x146
        public object field_16; // 0x147
        public object field_17; // 0x148
        public object field_18; // 0x149
        public object field_19; // 0x14A
        public object field_20; // 0x14B
        public object field_21; // 0x14C
        public object field_22; // 0x14D
        public object field_23; // 0x14E
        public object field_24; // 0x14F
        public object field_25; // 0x150
        public object field_26; // 0x151
        public object field_27; // 0x152
        public object field_28; // 0x153
        public object field_29; // 0x154

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87574390
        public void get_Settings(){} // RVA: 0x7FFE87574B60
        public void get_NodeType(){} // RVA: 0x7FFE81588760
        public void get_Name(){} // RVA: 0x7FFE86BADCC0
        public void get_LocalName(){} // RVA: 0x7FFE81567090
        public void get_NamespaceURI(){} // RVA: 0x7FFE86853DC0
        public void get_Prefix(){} // RVA: 0x7FFE86853DF0
        public void get_Value(){} // RVA: 0x7FFE826F8E90
        public void get_Depth(){} // RVA: 0x7FFE87119A80
        public void get_BaseURI(){} // RVA: 0x7FFE815889F0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE81588880
        public void get_IsDefault(){} // RVA: 0x7FFE815888B0
        public void get_QuoteChar(){} // RVA: 0x7FFE81588730
        public void get_XmlSpace(){} // RVA: 0x7FFE815889C0
        public void get_XmlLang(){} // RVA: 0x7FFE81588910
        public void get_ReadState(){} // RVA: 0x7FFE87574C70
        public void get_EOF(){} // RVA: 0x7FFE872B3130
        public void get_NameTable(){} // RVA: 0x7FFE86BACEC0
        public void get_AttributeCount(){} // RVA: 0x7FFE86F36C70
        public void GetAttribute(){} // RVA: 0x7FFE872B3070 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE87574D00 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE87574D40
        public void MoveToNextAttribute(){} // RVA: 0x7FFE87574D90
        public void MoveToElement(){} // RVA: 0x7FFE87574DE0
        public void Read(){} // RVA: 0x7FFE87574E30
        public void Close(){} // RVA: 0x7FFE87575100
        public void LookupNamespace(){} // RVA: 0x7FFE87575140
        public void ReadAttributeValue(){} // RVA: 0x7FFE87575170
        public void get_CanResolveEntity(){} // RVA: 0x7FFE811E0850
        public void ResolveEntity(){} // RVA: 0x7FFE875751E0
        public void MoveOffEntityReference(){} // RVA: 0x7FFE87575220
        public void ReadString(){} // RVA: 0x7FFE875752E0
        public void HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void get_LineNumber(){} // RVA: 0x7FFE875753B0
        public void get_LinePosition(){} // RVA: 0x7FFE87575450
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE875754F0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE871F5CD0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87575550
        public void GetNamespacesInScope(){} // RVA: 0x7FFE875754F0
        public void LookupPrefix(){} // RVA: 0x7FFE87575550
        public void get_ValidationType(){} // RVA: 0x7FFE81549710
        public void get_Schemas(){} // RVA: 0x7FFE8143BA80
        public void get_Namespaces(){} // RVA: 0x7FFE875755B0
        public void ParseDtdFromParserContext(){} // RVA: 0x7FFE875755D0
        public void ValidateDtd(){} // RVA: 0x7FFE87575720
        public void ResolveEntityInternally(){} // RVA: 0x7FFE875758B0
        public void SetupValidation(){} // RVA: 0x7FFE87575960
        public void GetResolver(){} // RVA: 0x7FFE87575C70
        public void ProcessCoreReaderEvent(){} // RVA: 0x7FFE87575D60
        public void get_Validator(){} // RVA: 0x7FFE8144E200
        public void set_Validator(){} // RVA: 0x7FFE81129890
        public void get_NamespaceManager(){} // RVA: 0x7FFE87575E80
        public void get_StandAlone(){} // RVA: 0x7FFE87575EB0
        public void set_SchemaTypeObject(){} // RVA: 0x7FFE87575ED0
        public void get_TypedValueObject(){} // RVA: 0x7FFE87575EF0
        public void set_TypedValueObject(){} // RVA: 0x7FFE87575F20
        public void AddDefaultAttribute(){} // RVA: 0x7FFE87575F40
        public void get_DtdInfo(){} // RVA: 0x7FFE87575F60
        public void ValidateDefaultAttributeOnUse(){} // RVA: 0x7FFE87575F90
    }

    public class XmlWellFormedWriter : XmlWriter
    {
        public System.Xml.XmlWriter writer; // 0x18
        public System.Xml.XmlRawWriter rawWriter; // 0x20
        public System.Xml.IXmlNamespaceResolver predefinedNamespaces; // 0x28
        public Namespace[] nsStack; // 0x30
        public int nsTop; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87576310
        public void get_WriteState(){} // RVA: 0x7FFE87576AF0
        public void WriteStartDocument(){} // RVA: 0x7FFE87576B90 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFE87576BC0
        public void WriteDocType(){} // RVA: 0x7FFE87576CD0
        public void WriteStartElement(){} // RVA: 0x7FFE87577250
        public void WriteEndElement(){} // RVA: 0x7FFE875775D0
        public void WriteFullEndElement(){} // RVA: 0x7FFE875777A0
        public void WriteStartAttribute(){} // RVA: 0x7FFE87577970
        public void WriteEndAttribute(){} // RVA: 0x7FFE87578250
        public void WriteCData(){} // RVA: 0x7FFE87579570
        public void WriteComment(){} // RVA: 0x7FFE87579630
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE875796F0
        public void WriteEntityRef(){} // RVA: 0x7FFE875799E0
        public void WriteCharEntity(){} // RVA: 0x7FFE87579AF0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87579CB0
        public void WriteWhitespace(){} // RVA: 0x7FFE87579EC0
        public void WriteString(){} // RVA: 0x7FFE8757A0A0
        public void WriteChars(){} // RVA: 0x7FFE8757A1E0
        public void WriteRaw(){} // RVA: 0x7FFE8757A780 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFE8757A860
        public void Close(){} // RVA: 0x7FFE8757AA40
        public void Flush(){} // RVA: 0x7FFE8757B080
        public void LookupPrefix(){} // RVA: 0x7FFE8757B0E0
        public void WriteValue(){} // RVA: 0x7FFE8757B2E0
        public void WriteBinHex(){} // RVA: 0x7FFE8757B3D0
        public void get_RawWriter(){} // RVA: 0x7FFE811290C0
        public void get_SaveAttrValue(){} // RVA: 0x7FFE8748AEA0
        public void get_InBase64(){} // RVA: 0x7FFE8757B4C0
        public void SetSpecialAttribute(){} // RVA: 0x7FFE8757B4E0
        public void WriteStartDocumentImpl(){} // RVA: 0x7FFE8757B660
        public void StartFragment(){} // RVA: 0x7FFE8757B840
        public void PushNamespaceImplicit(){} // RVA: 0x7FFE8757B850
        public void PushNamespaceExplicit(){} // RVA: 0x7FFE8757BE70
        public void AddNamespace(){} // RVA: 0x7FFE8757C590
        public void AddToNamespaceHashtable(){} // RVA: 0x7FFE8757C8D0
        public void LookupNamespaceIndex(){} // RVA: 0x7FFE8757CA00
        public void PopNamespaces(){} // RVA: 0x7FFE8757CB50
        public void DupAttrException(){} // RVA: 0x7FFE8757CC70
        public void AdvanceState(){} // RVA: 0x7FFE8757CD80
        public void StartElementContent(){} // RVA: 0x7FFE8757D1A0
        public void GetStateName(){} // RVA: 0x7FFE8757D270
        public void LookupNamespace(){} // RVA: 0x7FFE8757D310
        public void LookupLocalNamespace(){} // RVA: 0x7FFE8757D410
        public void GeneratePrefix(){} // RVA: 0x7FFE8757D530
        public void CheckNCName(){} // RVA: 0x7FFE8757D800
        public void InvalidCharsException(){} // RVA: 0x7FFE8757D930
        public void ThrowInvalidStateTransition(){} // RVA: 0x7FFE8757DAA0
        public void get_IsClosedOrErrorState(){} // RVA: 0x7FFE8757DCA0
        public void AddAttribute(){} // RVA: 0x7FFE8757DCB0
        public void AddToAttrHashTable(){} // RVA: 0x7FFE8757E240
        public void .cctor(){} // RVA: 0x7FFE8757E3C0
    }

    public class XmlWhitespace : XmlCharacterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875ACFD0
        public void get_Name(){} // RVA: 0x7FFE875AD0D0
        public void get_LocalName(){} // RVA: 0x7FFE875AD0D0
        public void get_NodeType(){} // RVA: 0x7FFE81EE2040
        public void get_ParentNode(){} // RVA: 0x7FFE875AC700
        public void get_Value(){} // RVA: 0x7FFE869FDAC0
        public void set_Value(){} // RVA: 0x7FFE875AD100
        public void CloneNode(){} // RVA: 0x7FFE875AD200
        public void WriteTo(){} // RVA: 0x7FFE875AD270
        public void WriteContentTo(){} // RVA: 0x7FFE810FB310
        public void get_IsText(){} // RVA: 0x7FFE811E0850
    }

    public class XmlWriter : Object
    {
        public char[] writeNodeBuffer; // 0x10

        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFE80E45FE0
        public void WriteDocType(){} // RVA: 0x7FFE80E50FC0
        public void WriteStartElement(){} // RVA: 0x7FFE80E50660 | overloaded x2
        public void WriteEndElement(){} // RVA: 0x7FFE80E45FE0
        public void WriteFullEndElement(){} // RVA: 0x7FFE80E45FE0
        public void WriteAttributeString(){} // RVA: 0x7FFE87580B40 | overloaded x3
        public void WriteStartAttribute(){} // RVA: 0x7FFE80E50660
        public void WriteEndAttribute(){} // RVA: 0x7FFE80E45FE0
        public void WriteCData(){} // RVA: 0x7FFE80E460A0
        public void WriteComment(){} // RVA: 0x7FFE80E460A0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE80E4F230
        public void WriteEntityRef(){} // RVA: 0x7FFE80E460A0
        public void WriteCharEntity(){} // RVA: 0x7FFE80E461D0
        public void WriteWhitespace(){} // RVA: 0x7FFE80E460A0
        public void WriteString(){} // RVA: 0x7FFE80E460A0
        public void WriteSurrogateCharEntity(){}
        public void WriteChars(){}
        public void WriteRaw(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void WriteBase64(){}
        public void WriteBinHex(){} // RVA: 0x7FFE87580BA0
        public void get_WriteState(){} // RVA: 0x7FFE80E2EDB0
        public void Close(){} // RVA: 0x7FFE810FB310
        public void Flush(){} // RVA: 0x7FFE80E45FE0
        public void LookupPrefix(){} // RVA: 0x7FFE80E2E390
        public void WriteValue(){} // RVA: 0x7FFE87580BD0
        public void WriteAttributes(){} // RVA: 0x7FFE87580BF0
        public void WriteNode(){} // RVA: 0x7FFE87580F60
        public void WriteElementString(){} // RVA: 0x7FFE87581540
        public void Dispose(){} // RVA: 0x7FFE875815E0 | overloaded x2
        public void Create(){} // RVA: 0x7FFE875816A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XmlWriterSettings : Object
    {
        public bool useAsync; // 0x10
        public System.Text.Encoding encoding; // 0x18
        public bool omitXmlDecl; // 0x20
        public 0x66552BAC newLineHandling; // 0x24
        public string newLineChars; // 0x28
        public 0x665546D4 indent; // 0x30
        public string indentChars; // 0x38
        public bool newLineOnAttributes; // 0x40
        public bool closeOutput; // 0x41
        public 0x66552B54 namespaceHandling; // 0x44
        public 0x6655241C conformanceLevel; // 0x48
        public bool checkCharacters; // 0x4C
        public bool writeEndDocumentOnClose; // 0x4D
        public 0x6655467C outputMethod; // 0x50
        public System.Collections.Generic.List`1<System.Xml.XmlQualifiedName> cdataSections; // 0x58
        public bool doNotEscapeUriAttributes; // 0x60
        public bool mergeCDataSections; // 0x61
        public string mediaType; // 0x68
        public string docTypeSystem; // 0x70
        public string docTypePublic; // 0x78
        public 0x6655472C standalone; // 0x80
        public bool autoXmlDecl; // 0x84
        public bool isReadOnly; // 0x85
        public object field_23; // 0x16A
        public object field_24; // 0x16B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87581720
        public void get_Async(){} // RVA: 0x7FFE811C55E0
        public void get_Encoding(){} // RVA: 0x7FFE810FE7C0
        public void get_OmitXmlDeclaration(){} // RVA: 0x7FFE811E99D0
        public void set_OmitXmlDeclaration(){} // RVA: 0x7FFE875817F0
        public void get_NewLineHandling(){} // RVA: 0x7FFE81A56130
        public void get_NewLineChars(){} // RVA: 0x7FFE81129130
        public void get_Indent(){} // RVA: 0x7FFE86F063D0
        public void set_Indent(){} // RVA: 0x7FFE87581850
        public void get_IndentChars(){} // RVA: 0x7FFE8143BA80
        public void get_NewLineOnAttributes(){} // RVA: 0x7FFE811B6C00
        public void get_CloseOutput(){} // RVA: 0x7FFE814645D0
        public void get_ConformanceLevel(){} // RVA: 0x7FFE8119C0C0
        public void set_ConformanceLevel(){} // RVA: 0x7FFE875818B0
        public void get_CheckCharacters(){} // RVA: 0x7FFE82447BA0
        public void get_NamespaceHandling(){} // RVA: 0x7FFE8119C0A0
        public void set_NamespaceHandling(){} // RVA: 0x7FFE87581950
        public void get_WriteEndDocumentOnClose(){} // RVA: 0x7FFE875819F0
        public void get_OutputMethod(){} // RVA: 0x7FFE8139DAD0
        public void set_OutputMethod(){} // RVA: 0x7FFE81463B00
        public void Clone(){} // RVA: 0x7FFE87581A00
        public void get_CDataSectionElements(){} // RVA: 0x7FFE811C3500
        public void get_DoNotEscapeUriAttributes(){} // RVA: 0x7FFE81124020
        public void get_MergeCDataSections(){} // RVA: 0x7FFE81EC3970
        public void get_MediaType(){} // RVA: 0x7FFE81176D50
        public void get_DocTypeSystem(){} // RVA: 0x7FFE811C3590
        public void get_DocTypePublic(){} // RVA: 0x7FFE81463AE0
        public void get_Standalone(){} // RVA: 0x7FFE81D30560
        public void get_AutoXmlDeclaration(){} // RVA: 0x7FFE811DACE0
        public void get_IndentInternal(){} // RVA: 0x7FFE81156CD0
        public void get_IsQuerySpecific(){} // RVA: 0x7FFE87581B20
        public void CreateWriter(){} // RVA: 0x7FFE87582180 | overloaded x2
        public void set_ReadOnly(){} // RVA: 0x7FFE86EB9970
        public void CheckReadOnly(){} // RVA: 0x7FFE87582580
        public void Initialize(){} // RVA: 0x7FFE87582630
    }

    public class XsdCachingReader : XmlReader
    {
        public System.Xml.XmlReader coreReader; // 0x10
        public System.Xml.XmlNameTable coreReaderNameTable; // 0x18
        public System.Xml.ValidatingReaderNodeData[] contentEvents; // 0x20
        public System.Xml.ValidatingReaderNodeData[] attributeEvents; // 0x28
        public System.Xml.ValidatingReaderNodeData cachedNode; // 0x30
        public 0x665547DC cacheState; // 0x38
        public int contentIndex; // 0x3C
        public int attributeCount; // 0x40
        public bool returnOriginalStringValues; // 0x44
        public System.Xml.CachingEventHandler cacheHandler; // 0x48
        public int currentAttrIndex; // 0x50
        public int currentContentIndex; // 0x54
        public bool readAhead; // 0x58
        public System.Xml.IXmlLineInfo lineInfo; // 0x60
        public System.Xml.ValidatingReaderNodeData textNode; // 0x68
        public object field_15; // 0x183
        public object field_16; // 0x184
        public object field_17; // 0x185
        public object field_18; // 0x186
        public object field_19; // 0x187

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87582900
        public void Init(){} // RVA: 0x7FFE87582B40
        public void Reset(){} // RVA: 0x7FFE87582DE0
        public void get_Settings(){} // RVA: 0x7FFE815888E0
        public void get_NodeType(){} // RVA: 0x7FFE87582E40
        public void get_Name(){} // RVA: 0x7FFE87582E60
        public void get_LocalName(){} // RVA: 0x7FFE87582E90
        public void get_NamespaceURI(){} // RVA: 0x7FFE817B4F10
        public void get_Prefix(){} // RVA: 0x7FFE87582EB0
        public void get_Value(){} // RVA: 0x7FFE87582ED0
        public void get_Depth(){} // RVA: 0x7FFE87582F00
        public void get_BaseURI(){} // RVA: 0x7FFE815889F0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE810FB320
        public void get_IsDefault(){} // RVA: 0x7FFE810FB320
        public void get_QuoteChar(){} // RVA: 0x7FFE81588730
        public void get_XmlSpace(){} // RVA: 0x7FFE815889C0
        public void get_XmlLang(){} // RVA: 0x7FFE81588910
        public void get_AttributeCount(){} // RVA: 0x7FFE8119C080
        public void GetAttribute(){} // RVA: 0x7FFE87583140 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE87583330 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE87583420
        public void MoveToNextAttribute(){} // RVA: 0x7FFE875834B0
        public void MoveToElement(){} // RVA: 0x7FFE87583550
        public void Read(){} // RVA: 0x7FFE875835A0
        public void RecordTextNode(){} // RVA: 0x7FFE87583960
        public void SwitchTextNodeAndEndElement(){} // RVA: 0x7FFE875839E0
        public void RecordEndElementNode(){} // RVA: 0x7FFE87583B30
        public void get_EOF(){} // RVA: 0x7FFE87583CE0
        public void Close(){} // RVA: 0x7FFE87583D20
        public void get_ReadState(){} // RVA: 0x7FFE872B3160
        public void Skip(){} // RVA: 0x7FFE87583D60
        public void get_NameTable(){} // RVA: 0x7FFE810FE7C0
        public void LookupNamespace(){} // RVA: 0x7FFE872B3190
        public void ResolveEntity(){} // RVA: 0x7FFE87583EA0
        public void ReadAttributeValue(){} // RVA: 0x7FFE87583EE0
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7FFE875840A0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7FFE875840C0
        public void SetToReplayMode(){} // RVA: 0x7FFE875840E0
        public void GetCoreReader(){} // RVA: 0x7FFE81116380
        public void GetLineInfo(){} // RVA: 0x7FFE81199370
        public void ClearAttributesInfo(){} // RVA: 0x7FFE87584110
        public void AddAttribute(){} // RVA: 0x7FFE87584120
        public void AddContent(){} // RVA: 0x7FFE87584300
        public void RecordAttributes(){} // RVA: 0x7FFE875844D0
        public void GetAttributeIndexWithoutPrefix(){} // RVA: 0x7FFE87584740
        public void GetAttributeIndexWithPrefix(){} // RVA: 0x7FFE875847D0
        public void CreateDummyTextNode(){} // RVA: 0x7FFE87584880
    }

    public class XsdValidatingReader : XmlReader
    {
        public System.Xml.XmlReader coreReader; // 0x10
        public System.Xml.IXmlNamespaceResolver coreReaderNSResolver; // 0x18
        public System.Xml.IXmlNamespaceResolver thisNSResolver; // 0x20
        public System.Xml.Schema.XmlSchemaValidator validator; // 0x28
        public System.Xml.XmlResolver xmlResolver; // 0x30
        public System.Xml.Schema.ValidationEventHandler validationEvent; // 0x38
        public 0x6655493C validationState; // 0x40
        public System.Xml.Schema.XmlValueGetter valueGetter; // 0x48
        public System.Xml.XmlNamespaceManager nsManager; // 0x50
        public bool manageNamespaces; // 0x58
        public bool processInlineSchema; // 0x59
        public bool replayCache; // 0x5A
        public System.Xml.ValidatingReaderNodeData cachedNode; // 0x60
        public System.Xml.AttributePSVIInfo attributePSVI; // 0x68
        public int attributeCount; // 0x70
        public int coreReaderAttributeCount; // 0x74
        public int currentAttrIndex; // 0x78
        public System.Xml.AttributePSVIInfo[] attributePSVINodes; // 0x80
        public System.Collections.ArrayList defaultAttributes; // 0x88
        public System.Xml.Schema.Parser inlineSchemaParser; // 0x90
        public object atomicValue; // 0x98
        public System.Xml.Schema.XmlSchemaInfo xmlSchemaInfo; // 0xA0
        public string originalAtomicValueString; // 0xA8
        public System.Xml.XmlNameTable coreReaderNameTable; // 0xB0
        public System.Xml.XsdCachingReader cachingReader; // 0xB8
        public System.Xml.ValidatingReaderNodeData textNode; // 0xC0
        public string NsXmlNs; // 0xC8
        public string NsXs; // 0xD0
        public string NsXsi; // 0xD8
        public string XsiType; // 0xE0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87585030 | overloaded x2
        public void Init(){} // RVA: 0x7FFE87585050
        public void SetupValidator(){} // RVA: 0x7FFE87585850
        public void get_Settings(){} // RVA: 0x7FFE87585F60
        public void get_NodeType(){} // RVA: 0x7FFE875860F0
        public void get_Name(){} // RVA: 0x7FFE875861C0
        public void get_LocalName(){} // RVA: 0x7FFE875862F0
        public void get_NamespaceURI(){} // RVA: 0x7FFE87586340
        public void get_Prefix(){} // RVA: 0x7FFE87586390
        public void get_Value(){} // RVA: 0x7FFE875863E0
        public void get_Depth(){} // RVA: 0x7FFE87586430
        public void get_BaseURI(){} // RVA: 0x7FFE815889F0
        public void get_IsEmptyElement(){} // RVA: 0x7FFE81588880
        public void get_IsDefault(){} // RVA: 0x7FFE87586480
        public void get_QuoteChar(){} // RVA: 0x7FFE81588730
        public void get_XmlSpace(){} // RVA: 0x7FFE815889C0
        public void get_XmlLang(){} // RVA: 0x7FFE81588910
        public void get_SchemaInfo(){} // RVA: 0x7FFE827C4A80
        public void get_ValueType(){} // RVA: 0x7FFE875864C0
        public void get_AttributeCount(){} // RVA: 0x7FFE81E60180
        public void GetAttribute(){} // RVA: 0x7FFE87586750 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFE87586960 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFE87586B80
        public void MoveToNextAttribute(){} // RVA: 0x7FFE87586EA0
        public void MoveToElement(){} // RVA: 0x7FFE875871B0
        public void Read(){} // RVA: 0x7FFE87587210
        public void get_EOF(){} // RVA: 0x7FFE872B3130
        public void Close(){} // RVA: 0x7FFE875874F0
        public void get_ReadState(){} // RVA: 0x7FFE87587530
        public void Skip(){} // RVA: 0x7FFE87587570
        public void get_NameTable(){} // RVA: 0x7FFE81166040
        public void LookupNamespace(){} // RVA: 0x7FFE87587720
        public void ResolveEntity(){} // RVA: 0x7FFE87587780
        public void ReadAttributeValue(){} // RVA: 0x7FFE875877C0
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x7FFE87587A00
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x7FFE87587A90
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x7FFE87587AE0
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x7FFE87587BA0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x7FFE87587D80
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x7FFE87587DE0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x7FFE87587E40
        public void HasLineInfo(){} // RVA: 0x7FFE811E0850
        public void get_LineNumber(){} // RVA: 0x7FFE87587E90
        public void get_LinePosition(){} // RVA: 0x7FFE87587EF0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE87587F50
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE87587FE0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE87588070
        public void GetStringValue(){} // RVA: 0x7FFE826F8E90
        public void get_AttributeSchemaInfo(){} // RVA: 0x7FFE87588100
        public void ProcessReaderEvent(){} // RVA: 0x7FFE87588120
        public void ProcessElementEvent(){} // RVA: 0x7FFE875883E0
        public void ProcessEndElementEvent(){} // RVA: 0x7FFE87588B30
        public void ValidateAttributes(){} // RVA: 0x7FFE87588E00
        public void ClearAttributesInfo(){} // RVA: 0x7FFE87589160
        public void GetAttributePSVI(){} // RVA: 0x7FFE875893B0 | overloaded x2
        public void GetDefaultAttribute(){} // RVA: 0x7FFE87589580 | overloaded x2
        public void AddAttributePSVI(){} // RVA: 0x7FFE875896D0
        public void IsXSDRoot(){} // RVA: 0x7FFE87589910
        public void ProcessInlineSchema(){} // RVA: 0x7FFE87589930
        public void ReadAheadForMemberType(){} // RVA: 0x7FFE87589A70
        public void GetIsDefault(){} // RVA: 0x7FFE87589DA0
        public void GetMemberType(){} // RVA: 0x7FFE8758A220
        public void GetCachingReader(){} // RVA: 0x7FFE8758A360
        public void CreateDummyTextNode(){} // RVA: 0x7FFE8758A570
        public void CachingCallBack(){} // RVA: 0x7FFE8758A6D0
        public void GetOriginalAtomicValueStringOfElement(){} // RVA: 0x7FFE8758A7B0
    }

}