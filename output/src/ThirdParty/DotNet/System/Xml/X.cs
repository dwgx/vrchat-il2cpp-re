// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 74
// Methods: 2227

namespace ThirdParty.DotNet.System.Xml
{
    public class XmlAsyncCheckReader : XmlReader
    {
        public System.Xml.XmlReader CoreReader; // 0x10
        public System.Threading.Tasks.Task Settings; // 0x18

        // ── Methods ──
        public void get_CoreReader(){} // RVA: 0x7FFAC2F3C380
        public void CreateAsyncCheckWrapper(){} // RVA: 0x7FFAC91AC7F0
        public void .ctor(){} // RVA: 0x7FFAC91ACB90
        public void CheckAsync(){} // RVA: 0x7FFAC91ACCD0
        public void get_Settings(){} // RVA: 0x7FFAC91ACDA0
        public void get_NodeType(){} // RVA: 0x7FFAC91ACE70
        public void get_Name(){} // RVA: 0x7FFAC91ACEB0
        public void get_LocalName(){} // RVA: 0x7FFAC91ACEF0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC91ACF30
        public void get_Prefix(){} // RVA: 0x7FFAC91ACF70
        public void get_Value(){} // RVA: 0x7FFAC91ACFB0
        public void get_Depth(){} // RVA: 0x7FFAC91ACFF0
        public void get_BaseURI(){} // RVA: 0x7FFAC91AD030
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC91AD070
        public void get_IsDefault(){} // RVA: 0x7FFAC91AD0B0
        public void get_QuoteChar(){} // RVA: 0x7FFAC91AD0F0
        public void get_XmlSpace(){} // RVA: 0x7FFAC91AD130
        public void get_XmlLang(){} // RVA: 0x7FFAC91AD170
        public void get_SchemaInfo(){} // RVA: 0x7FFAC91AD1B0
        public void get_ValueType(){} // RVA: 0x7FFAC91AD1F0
        public void get_AttributeCount(){} // RVA: 0x7FFAC91AD230
        public void GetAttribute(){} // RVA: 0x7FFAC91AD320 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC91AD3C0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC91AD410
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC91AD450
        public void MoveToElement(){} // RVA: 0x7FFAC91AD490
        public void ReadAttributeValue(){} // RVA: 0x7FFAC91AD4D0
        public void Read(){} // RVA: 0x7FFAC91AD510
        public void get_EOF(){} // RVA: 0x7FFAC91AD550
        public void Close(){} // RVA: 0x7FFAC91AD590
        public void get_ReadState(){} // RVA: 0x7FFAC91AD5D0
        public void Skip(){} // RVA: 0x7FFAC91AD610
        public void get_NameTable(){} // RVA: 0x7FFAC91AD650
        public void LookupNamespace(){} // RVA: 0x7FFAC91AD690
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC91AD6E0
        public void ResolveEntity(){} // RVA: 0x7FFAC91AD720
        public void get_CanReadValueChunk(){} // RVA: 0x7FFAC91AD760
        public void ReadValueChunk(){} // RVA: 0x7FFAC91AD7A0
        public void ReadString(){} // RVA: 0x7FFAC91AD810
        public void MoveToContent(){} // RVA: 0x7FFAC91AD850
        public void ReadStartElement(){} // RVA: 0x7FFAC91AD890
        public void ReadElementString(){} // RVA: 0x7FFAC91AD8D0
        public void ReadEndElement(){} // RVA: 0x7FFAC91AD910
        public void IsStartElement(){} // RVA: 0x7FFAC91AD950
        public void ReadInnerXml(){} // RVA: 0x7FFAC91AD9B0
        public void get_HasAttributes(){} // RVA: 0x7FFAC91AD9F0
        public void Dispose(){} // RVA: 0x7FFAC91ADA30
        public void get_NamespaceManager(){} // RVA: 0x7FFAC91ADA70
        public void get_DtdInfo(){} // RVA: 0x7FFAC91ADAB0
    }

    public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader
    {
        public System.Xml.IXmlLineInfo LineNumber; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91ADD10
        public void HasLineInfo(){} // RVA: 0x7FFAC91ADE10
        public void get_LineNumber(){} // RVA: 0x7FFAC91ADE60
        public void get_LinePosition(){} // RVA: 0x7FFAC91ADEB0
    }

    public class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo
    {
        public System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91ADF00
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC91AE000
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC91AE060
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC91AE0C0
    }

    public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS
    {
        public System.Xml.Schema.IXmlSchemaInfo System.Xml.Schema.IXmlSchemaInfo.Validity; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91AE120
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x7FFAC91AE220
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x7FFAC91AE270
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x7FFAC91AE2C0
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x7FFAC91AE310
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x7FFAC91AE360
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x7FFAC91AE3B0
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x7FFAC91AE400
    }

    public class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader
    {
        public System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91ADAF0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC91ADBF0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC91ADC50
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC91ADCB0
    }

    public class XmlAsyncCheckWriter : XmlWriter
    {
        public System.Xml.XmlWriter WriteState; // 0x18
        public System.Threading.Tasks.Task lastTask; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91AE450
        public void CheckAsync(){} // RVA: 0x7FFAC91AE570
        public void WriteStartDocument(){} // RVA: 0x7FFAC91AE680 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFAC91AE6D0
        public void WriteDocType(){} // RVA: 0x7FFAC91AE710
        public void WriteStartElement(){} // RVA: 0x7FFAC91AE780
        public void WriteEndElement(){} // RVA: 0x7FFAC91AE7F0
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91AE830
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91AE870
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91AE8E0
        public void WriteCData(){} // RVA: 0x7FFAC91AE920
        public void WriteComment(){} // RVA: 0x7FFAC91AE970
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91AE9C0
        public void WriteEntityRef(){} // RVA: 0x7FFAC91AEA20
        public void WriteCharEntity(){} // RVA: 0x7FFAC91AEA70
        public void WriteWhitespace(){} // RVA: 0x7FFAC91AEAC0
        public void WriteString(){} // RVA: 0x7FFAC91AEB10
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91AEB60
        public void WriteChars(){} // RVA: 0x7FFAC91AEBC0
        public void WriteRaw(){} // RVA: 0x7FFAC91AECA0 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC91AECF0
        public void WriteBinHex(){} // RVA: 0x7FFAC91AED60
        public void get_WriteState(){} // RVA: 0x7FFAC91AEDD0
        public void Close(){} // RVA: 0x7FFAC91AEE10
        public void Flush(){} // RVA: 0x7FFAC91AEE50
        public void LookupPrefix(){} // RVA: 0x7FFAC91AEE90
        public void WriteValue(){} // RVA: 0x7FFAC91AEEE0
        public void WriteAttributes(){} // RVA: 0x7FFAC91AEF30
        public void WriteNode(){} // RVA: 0x7FFAC91AEF90
        public void Dispose(){} // RVA: 0x7FFAC91AEFF0
    }

    public class XmlAttribute : XmlNode
    {
        public System.Xml.XmlName LocalNameHash; // 0x18
        public System.Xml.XmlLinkedNode XmlName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E2E40 | overloaded x2
        public void get_LocalNameHash(){} // RVA: 0x7FFAC91E2E20
        public void get_XmlName(){} // RVA: 0x7FFAC2F247C0
        public void set_XmlName(){} // RVA: 0x7FFAC2F87E80
        public void CloneNode(){} // RVA: 0x7FFAC91E2E90
        public void get_ParentNode(){} // RVA: 0x7FFAC34F9180
        public void get_Name(){} // RVA: 0x7FFAC91E2F80
        public void get_LocalName(){} // RVA: 0x7FFAC8804860
        public void get_NamespaceURI(){} // RVA: 0x7FFAC47C2590
        public void get_Prefix(){} // RVA: 0x7FFAC356C7D0
        public void set_Prefix(){} // RVA: 0x7FFAC91E2FA0
        public void get_NodeType(){} // RVA: 0x7FFAC3026CB0
        public void get_OwnerDocument(){} // RVA: 0x7FFAC8804980
        public void get_Value(){} // RVA: 0x7FFAC91E30A0
        public void set_Value(){} // RVA: 0x7FFAC91E30C0
        public void get_SchemaInfo(){} // RVA: 0x7FFAC2F247C0
        public void set_InnerText(){} // RVA: 0x7FFAC91E30E0
        public void PrepareOwnerElementInElementIdAttrMap(){} // RVA: 0x7FFAC91E3150
        public void ResetOwnerElementInElementIdAttrMap(){} // RVA: 0x7FFAC91E3340
        public void get_IsContainer(){} // RVA: 0x7FFAC3006850
        public void AppendChildForLoad(){} // RVA: 0x7FFAC91E3480
        public void get_LastNode(){} // RVA: 0x7FFAC2F4F0C0
        public void set_LastNode(){} // RVA: 0x7FFAC2F4F0D0
        public void IsValidChildType(){} // RVA: 0x7FFAC91E3840
        public void get_Specified(){} // RVA: 0x7FFAC3006850
        public void InsertBefore(){} // RVA: 0x7FFAC91E3850
        public void InsertAfter(){} // RVA: 0x7FFAC91E38F0
        public void RemoveChild(){} // RVA: 0x7FFAC91E3990
        public void PrependChild(){} // RVA: 0x7FFAC91E3A10
        public void AppendChild(){} // RVA: 0x7FFAC91E3AE0
        public void get_OwnerElement(){} // RVA: 0x7FFAC91E3B60
        public void set_InnerXml(){} // RVA: 0x7FFAC91E3BF0
        public void WriteTo(){} // RVA: 0x7FFAC91E3C80
        public void WriteContentTo(){} // RVA: 0x7FFAC91E3D60
        public void get_BaseURI(){} // RVA: 0x7FFAC91E3DE0
        public void SetParent(){} // RVA: 0x7FFAC2F22E30
        public void get_XmlSpace(){} // RVA: 0x7FFAC91E3E80
        public void get_XmlLang(){} // RVA: 0x7FFAC91E3EF0
    }

    public class XmlAttributeCollection : XmlNamedNodeMap
    {
        public object ItemOf;
        public object ItemOf;
        public object ItemOf;
        public object System.Collections.ICollection.IsSynchronized;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.ICollection.Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ItemOf(){} // RVA: 0x7FFAC91E4240 | overloaded x3
        public void FindNodeOffsetNS(){} // RVA: 0x7FFAC91E4440
        public void SetNamedItem(){} // RVA: 0x7FFAC91E4630
        public void Append(){} // RVA: 0x7FFAC91E47D0
        public void Remove(){} // RVA: 0x7FFAC91E4A20
        public void RemoveAt(){} // RVA: 0x7FFAC91E4AC0
        public void RemoveAll(){} // RVA: 0x7FFAC91E4B80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC91E4C60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC91E4CF0
        public void AddNode(){} // RVA: 0x7FFAC91E4D00
        public void InsertNodeAt(){} // RVA: 0x7FFAC91E4F00
        public void RemoveNodeAt(){} // RVA: 0x7FFAC91E4FB0
        public void Detach(){} // RVA: 0x7FFAC91E5190
        public void InsertParentIntoElementIdAttrMap(){} // RVA: 0x7FFAC91E5270
        public void RemoveParentFromElementIdAttrMap(){} // RVA: 0x7FFAC91E5470
        public void RemoveDuplicateAttribute(){} // RVA: 0x7FFAC91E5670
        public void PrepareParentInElementIdAttrMap(){} // RVA: 0x7FFAC91E5780
        public void ResetParentInElementIdAttrMap(){} // RVA: 0x7FFAC91E58E0
        public void InternalAppendAttribute(){} // RVA: 0x7FFAC91E59C0
    }

    public class XmlAutoDetectWriter : XmlRawWriter
    {
        public System.Xml.XmlRawWriter NamespaceResolver; // 0x28
        public System.Xml.OnRemoveWriter SupportsNamespaceDeclarationInChunks; // 0x30
        public System.Xml.XmlWriterSettings writerSettings; // 0x38
        public System.Xml.XmlEventCache eventCache; // 0x40
        public System.IO.TextWriter textWriter; // 0x48
        public System.IO.Stream strm; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91AF370 | overloaded x3
        public void WriteDocType(){} // RVA: 0x7FFAC91AF3F0
        public void WriteStartElement(){} // RVA: 0x7FFAC91AF470
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91AF550
        public void WriteEndAttribute(){} // RVA: 0x7FFAC8E25760
        public void WriteCData(){} // RVA: 0x7FFAC91AF5D0
        public void WriteComment(){} // RVA: 0x7FFAC91AF630
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91AF670
        public void WriteWhitespace(){} // RVA: 0x7FFAC91AF6B0
        public void WriteString(){} // RVA: 0x7FFAC91AF6F0
        public void WriteChars(){} // RVA: 0x7FFAC3F35600
        public void WriteRaw(){} // RVA: 0x7FFAC91AF7A0 | overloaded x2
        public void WriteEntityRef(){} // RVA: 0x7FFAC91AF800
        public void WriteCharEntity(){} // RVA: 0x7FFAC91AF860
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91AF8C0
        public void WriteBase64(){} // RVA: 0x7FFAC91AF930
        public void WriteBinHex(){} // RVA: 0x7FFAC91AF9B0
        public void Close(){} // RVA: 0x7FFAC91AFA30
        public void Flush(){} // RVA: 0x7FFAC91AFA80
        public void WriteValue(){} // RVA: 0x7FFAC91AFAD0
        public void set_NamespaceResolver(){} // RVA: 0x7FFAC91AFB30
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC91AFC10 | overloaded x2
        public void StartElementContent(){} // RVA: 0x7FFAC91AACB0
        public void WriteEndElement(){} // RVA: 0x7FFAC91AFC70
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91AFCA0
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFAC91AFCD0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFAC91AAD80
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFAC91AFD40
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFAC91AADE0
        public void IsHtmlTag(){} // RVA: 0x7FFAC91AFDA0
        public void EnsureWrappedWriter(){} // RVA: 0x7FFAC91AFE00
        public void TextBlockCreatesWriter(){} // RVA: 0x7FFAC91AFE10
        public void CreateWrappedWriter(){} // RVA: 0x7FFAC91AFEC0
    }

    public class XmlCDataSection : XmlCharacterData
    {
        public object Name;
        public object LocalName;
        public object NodeType;
        public object ParentNode;
        public object IsText;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E5A80
        public void get_Name(){} // RVA: 0x7FFAC91E5A90
        public void get_LocalName(){} // RVA: 0x7FFAC91E5A90
        public void get_NodeType(){} // RVA: 0x7FFAC36C3910
        public void get_ParentNode(){} // RVA: 0x7FFAC91E5AC0
        public void CloneNode(){} // RVA: 0x7FFAC91E5B60
        public void WriteTo(){} // RVA: 0x7FFAC91E5BD0
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void get_IsText(){} // RVA: 0x7FFAC3006850
    }

    public class XmlCachedStream : MemoryStream
    {
        public System.Uri uri; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9220980
    }

    public class XmlCharType : ValueType
    {
        public object StaticLock;
        public byte[] Instance; // 0x8
        public byte[] charProperties; // 0x10

        // ── Methods ──
        public void get_StaticLock(){} // RVA: 0x7FFAC9213E30
        public void InitInstance(){} // RVA: 0x7FFAC9213F00
        public void SetProperties(){} // RVA: 0x7FFAC9214770
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void get_Instance(){} // RVA: 0x7FFAC9214800
        public void IsWhiteSpace(){} // RVA: 0x7FFAC92148C0
        public void IsNCNameSingleChar(){} // RVA: 0x7FFAC92148F0
        public void IsStartNCNameSingleChar(){} // RVA: 0x7FFAC9214920
        public void IsNameSingleChar(){} // RVA: 0x7FFAC9214950
        public void IsCharData(){} // RVA: 0x7FFAC9214990
        public void IsPubidChar(){} // RVA: 0x7FFAC92149C0
        public void IsTextChar(){} // RVA: 0x7FFAC9214A50
        public void IsLetter(){} // RVA: 0x7FFAC9214A80
        public void IsNCNameCharXml4e(){} // RVA: 0x7FFAC9214AB0
        public void IsStartNCNameCharXml4e(){} // RVA: 0x7FFAC9214AE0
        public void IsNameCharXml4e(){} // RVA: 0x7FFAC9214B20
        public void IsDigit(){} // RVA: 0x7FFAC861B950
        public void IsHighSurrogate(){} // RVA: 0x7FFAC9214B60
        public void IsLowSurrogate(){} // RVA: 0x7FFAC9214B70
        public void IsSurrogate(){} // RVA: 0x7FFAC8A83630
        public void CombineSurrogateChar(){} // RVA: 0x7FFAC9214B80
        public void SplitSurrogateChar(){} // RVA: 0x7FFAC9214BA0
        public void IsOnlyWhitespace(){} // RVA: 0x7FFAC9214BE0
        public void IsOnlyWhitespaceWithPos(){} // RVA: 0x7FFAC9214C60
        public void IsOnlyCharData(){} // RVA: 0x7FFAC9214CE0
        public void IsOnlyDigits(){} // RVA: 0x7FFAC9214DD0
        public void IsPublicId(){} // RVA: 0x7FFAC9214E30
        public void InRange(){} // RVA: 0x7FFAC83E8BF0
    }

    public class XmlCharacterData : XmlLinkedNode
    {
        public string Value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E5C20
        public void get_Value(){} // RVA: 0x7FFAC86542D0
        public void set_Value(){} // RVA: 0x7FFAC91E5CA0
        public void get_InnerText(){} // RVA: 0x7FFAC47CB300
        public void set_InnerText(){} // RVA: 0x7FFAC69A3D80
        public void get_Data(){} // RVA: 0x7FFAC91E5CC0
        public void set_Data(){} // RVA: 0x7FFAC91E5D20
        public void CheckOnData(){} // RVA: 0x7FFAC91E5E30
    }

    public class XmlChildEnumerator : Object
    {
        public System.Xml.XmlNode System.Collections.IEnumerator.Current; // 0x10
        public System.Xml.XmlNode Current; // 0x18
        public bool isFirst; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E5EB0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC91E5FA0
        public void MoveNext(){} // RVA: 0x7FFAC91E5FA0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC91E60D0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC91E6150
        public void get_Current(){} // RVA: 0x7FFAC91E6150
    }

    public class XmlChildNodes : XmlNodeList
    {
        public System.Xml.XmlNode Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Item(){} // RVA: 0x7FFAC91E61E0
        public void get_Count(){} // RVA: 0x7FFAC91E6250
        public void GetEnumerator(){} // RVA: 0x7FFAC91E62B0
    }

    public class XmlComment : XmlCharacterData
    {
        public object Name;
        public object LocalName;
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E5A80
        public void get_Name(){} // RVA: 0x7FFAC91E6380
        public void get_LocalName(){} // RVA: 0x7FFAC91E6380
        public void get_NodeType(){} // RVA: 0x7FFAC3ED8E80
        public void CloneNode(){} // RVA: 0x7FFAC91E63B0
        public void WriteTo(){} // RVA: 0x7FFAC91E6420
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlComplianceUtil : Object
    {
        // ── Methods ──
        public void NonCDataNormalize(){} // RVA: 0x7FFAC9214EB0
        public void CDataNormalize(){} // RVA: 0x7FFAC9215170
    }

    public class XmlConvert : Object
    {
        public System.Xml.XmlCharType AllDateTimeFormats;
        public char[] crt; // 0x8
        public int c_EncodedCharLength; // 0x10
        public System.Text.RegularExpressions.Regex c_EncodeCharPattern; // 0x18
        public System.Text.RegularExpressions.Regex c_DecodeCharPattern; // 0x20
        public string[] s_allDateTimeFormats; // 0x28
        public char[] WhitespaceChars; // 0x30

        // ── Methods ──
        public void EncodeName(){} // RVA: 0x7FFAC9215D20 | overloaded x2
        public void EncodeLocalName(){} // RVA: 0x7FFAC92153E0
        public void DecodeName(){} // RVA: 0x7FFAC9215440
        public void FromHex(){} // RVA: 0x7FFAC9216880
        public void FromBinHexString(){} // RVA: 0x7FFAC9216960 | overloaded x2
        public void ToBinHexString(){} // RVA: 0x7FFAC92169E0
        public void VerifyName(){} // RVA: 0x7FFAC9216B60
        public void TryVerifyName(){} // RVA: 0x7FFAC9216CD0
        public void VerifyQName(){} // RVA: 0x7FFAC9216EA0
        public void VerifyNCName(){} // RVA: 0x7FFAC9217190 | overloaded x2
        public void TryVerifyNCName(){} // RVA: 0x7FFAC9217300
        public void VerifyTOKEN(){} // RVA: 0x7FFAC92173E0
        public void TryVerifyTOKEN(){} // RVA: 0x7FFAC92176E0
        public void TryVerifyNMTOKEN(){} // RVA: 0x7FFAC92179F0
        public void TryVerifyNormalizedString(){} // RVA: 0x7FFAC9217C30
        public void ToString(){} // RVA: 0x7FFAC92189B0 | overloaded x18
        public void ToBoolean(){} // RVA: 0x7FFAC9218A00
        public void TryToBoolean(){} // RVA: 0x7FFAC9218C70
        public void ToChar(){} // RVA: 0x7FFAC9218F70
        public void TryToChar(){} // RVA: 0x7FFAC9219040
        public void ToDecimal(){} // RVA: 0x7FFAC92191E0
        public void TryToDecimal(){} // RVA: 0x7FFAC9219270
        public void ToInteger(){} // RVA: 0x7FFAC9219430
        public void TryToInteger(){} // RVA: 0x7FFAC92194C0
        public void ToSByte(){} // RVA: 0x7FFAC9219680
        public void TryToSByte(){} // RVA: 0x7FFAC9219720
        public void ToInt16(){} // RVA: 0x7FFAC9219980
        public void TryToInt16(){} // RVA: 0x7FFAC9219A20
        public void ToInt32(){} // RVA: 0x7FFAC9219C70
        public void TryToInt32(){} // RVA: 0x7FFAC9219CA0
        public void ToInt64(){} // RVA: 0x7FFAC9219E20
        public void TryToInt64(){} // RVA: 0x7FFAC9219E50
        public void ToByte(){} // RVA: 0x7FFAC9219FD0
        public void TryToByte(){} // RVA: 0x7FFAC921A070
        public void ToUInt16(){} // RVA: 0x7FFAC921A260
        public void TryToUInt16(){} // RVA: 0x7FFAC921A300
        public void ToUInt32(){} // RVA: 0x7FFAC921A4F0
        public void TryToUInt32(){} // RVA: 0x7FFAC921A520
        public void ToUInt64(){} // RVA: 0x7FFAC921A6A0
        public void TryToUInt64(){} // RVA: 0x7FFAC921A6D0
        public void ToSingle(){} // RVA: 0x7FFAC921A850
        public void TryToSingle(){} // RVA: 0x7FFAC921A9B0
        public void ToDouble(){} // RVA: 0x7FFAC921AC80
        public void TryToDouble(){} // RVA: 0x7FFAC921ADE0
        public void ToXPathDouble(){} // RVA: 0x7FFAC921B0C0
        public void ToTimeSpan(){} // RVA: 0x7FFAC921B330
        public void TryToTimeSpan(){} // RVA: 0x7FFAC921B530
        public void get_AllDateTimeFormats(){} // RVA: 0x7FFAC921B5F0
        public void CreateAllDateTimeFormats(){} // RVA: 0x7FFAC921B6A0
        public void ToDateTime(){} // RVA: 0x7FFAC921BD70 | overloaded x3
        public void ToDateTimeOffset(){} // RVA: 0x7FFAC921C010
        public void ToGuid(){} // RVA: 0x7FFAC921C100
        public void TryToGuid(){} // RVA: 0x7FFAC921C120
        public void SwitchToLocalTime(){} // RVA: 0x7FFAC921C450
        public void SwitchToUtcTime(){} // RVA: 0x7FFAC921C5E0
        public void ToUri(){} // RVA: 0x7FFAC921C730
        public void TryToUri(){} // RVA: 0x7FFAC921CB80
        public void StrEqual(){} // RVA: 0x7FFAC921D020
        public void TrimString(){} // RVA: 0x7FFAC921D0C0
        public void TrimStringStart(){} // RVA: 0x7FFAC921D180
        public void TrimStringEnd(){} // RVA: 0x7FFAC921D230
        public void SplitString(){} // RVA: 0x7FFAC921D2F0
        public void IsNegativeZero(){} // RVA: 0x7FFAC921D3F0
        public void DoubleToInt64Bits(){} // RVA: 0x7FFAC850C830
        public void VerifyCharData(){} // RVA: 0x7FFAC921D470
        public void CreateException(){} // RVA: 0x7FFAC921DA20 | overloaded x4
        public void CreateInvalidSurrogatePairException(){} // RVA: 0x7FFAC921DC30 | overloaded x3
        public void CreateInvalidHighSurrogateCharException(){} // RVA: 0x7FFAC921E060 | overloaded x3
        public void CreateInvalidCharException(){} // RVA: 0x7FFAC921E4A0 | overloaded x3
        public void CreateInvalidNameCharException(){} // RVA: 0x7FFAC921E580
        public void CreateInvalidNameArgumentException(){} // RVA: 0x7FFAC921E6A0
        public void .cctor(){} // RVA: 0x7FFAC921E7A0
    }

    public class XmlDeclaration : XmlLinkedNode
    {
        public string Version; // 0x20
        public string Encoding; // 0x28
        public string Standalone; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E6470
        public void get_Version(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Version(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Encoding(){} // RVA: 0x7FFAC2F4F130
        public void set_Encoding(){} // RVA: 0x7FFAC91E67D0
        public void get_Standalone(){} // RVA: 0x7FFAC31D95E0
        public void set_Standalone(){} // RVA: 0x7FFAC91E6880
        public void get_Value(){} // RVA: 0x7FFAC91E30A0
        public void set_Value(){} // RVA: 0x7FFAC91E30C0
        public void get_InnerText(){} // RVA: 0x7FFAC91E6AD0
        public void set_InnerText(){} // RVA: 0x7FFAC91E6C70
        public void get_Name(){} // RVA: 0x7FFAC91E6F00
        public void get_LocalName(){} // RVA: 0x7FFAC3EEA090
        public void get_NodeType(){} // RVA: 0x7FFAC8804850
        public void CloneNode(){} // RVA: 0x7FFAC91E6F40
        public void WriteTo(){} // RVA: 0x7FFAC91E6FA0
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void IsValidXmlVersion(){} // RVA: 0x7FFAC91E7020
    }

    public class XmlDocument : XmlNode
    {
        public System.Xml.XmlImplementation DtdSchemaInfo; // 0x18
        public System.Xml.DomNameTable NodeType; // 0x20
        public System.Xml.XmlLinkedNode ParentNode; // 0x28
        public System.Xml.XmlNamedNodeMap DocumentType; // 0x30
        public System.Collections.Hashtable Declaration; // 0x38
        public System.Collections.Hashtable Implementation; // 0x40
        public System.Xml.Schema.SchemaInfo Name; // 0x48
        public System.Xml.Schema.XmlSchemaSet LocalName; // 0x50
        public bool DocumentElement; // 0x58
        public bool IsContainer; // 0x59
        public System.Xml.XmlNodeChangedEventHandler LastNode; // 0x60
        public System.Xml.XmlNodeChangedEventHandler OwnerDocument; // 0x68
        public System.Xml.XmlNodeChangedEventHandler Schemas; // 0x70
        public System.Xml.XmlNodeChangedEventHandler CanReportValidity; // 0x78
        public System.Xml.XmlNodeChangedEventHandler HasSetResolver; // 0x80
        public System.Xml.XmlNodeChangedEventHandler XmlResolver; // 0x88
        public bool NameTable; // 0x90
        public bool IsReadOnly; // 0x91
        public bool Entities; // 0x92
        public bool IsLoading; // 0x93
        public string ActualLoadingStatus; // 0x98
        public string InnerText; // 0xA0
        public string InnerXml; // 0xA8
        public string Version; // 0xB0
        public string Encoding; // 0xB8
        public string Standalone; // 0xC0
        public string SchemaInfo; // 0xC8
        public string BaseURI; // 0xD0
        public string strXml; // 0xD8
        public string strSpace; // 0xE0
        public string strLang; // 0xE8
        public string strEmpty; // 0xF0
        public string strNonSignificantWhitespaceName; // 0xF8
        public string strSignificantWhitespaceName; // 0x100
        public string strReservedXmlns; // 0x108
        public string strReservedXml; // 0x110
        public string baseURI; // 0x118
        public System.Xml.XmlResolver resolver; // 0x120
        public bool bSetResolver; // 0x128
        public object objLock; // 0x130
        public System.Xml.EmptyEnumerator EmptyEnumerator;
        public System.Xml.Schema.IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
        public System.Xml.Schema.IXmlSchemaInfo ValidSchemaInfo; // 0x10
        public System.Xml.Schema.IXmlSchemaInfo InvalidSchemaInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E7220 | overloaded x3
        public void get_DtdSchemaInfo(){} // RVA: 0x7FFAC2F9C730
        public void set_DtdSchemaInfo(){} // RVA: 0x7FFAC2F9C740
        public void CheckName(){} // RVA: 0x7FFAC91E7DB0
        public void AddXmlName(){} // RVA: 0x7FFAC91E7E80
        public void GetXmlName(){} // RVA: 0x7FFAC91E7EB0
        public void AddAttrXmlName(){} // RVA: 0x7FFAC91E7EE0
        public void AddIdInfo(){} // RVA: 0x7FFAC91E8020
        public void GetIDInfoByElement_(){} // RVA: 0x7FFAC91E8150
        public void GetIDInfoByElement(){} // RVA: 0x7FFAC91E8270
        public void GetElement(){} // RVA: 0x7FFAC91E8390
        public void AddElementWithId(){} // RVA: 0x7FFAC91E8830
        public void RemoveElementWithId(){} // RVA: 0x7FFAC91E8A90
        public void CloneNode(){} // RVA: 0x7FFAC91E8BF0
        public void get_NodeType(){} // RVA: 0x7FFAC41E44C0
        public void get_ParentNode(){} // RVA: 0x7FFAC34F9180
        public void get_DocumentType(){} // RVA: 0x7FFAC91E8D20
        public void get_Declaration(){} // RVA: 0x7FFAC91E8DB0
        public void get_Implementation(){} // RVA: 0x7FFAC2F247C0
        public void get_Name(){} // RVA: 0x7FFAC354DFB0
        public void get_LocalName(){} // RVA: 0x7FFAC354DFB0
        public void get_DocumentElement(){} // RVA: 0x7FFAC91E8E70
        public void get_IsContainer(){} // RVA: 0x7FFAC3006850
        public void get_LastNode(){} // RVA: 0x7FFAC2F4F130
        public void set_LastNode(){} // RVA: 0x7FFAC2F22E90
        public void get_OwnerDocument(){} // RVA: 0x7FFAC34F9180
        public void set_Schemas(){} // RVA: 0x7FFAC30794D0
        public void get_CanReportValidity(){} // RVA: 0x7FFAC313F600
        public void get_HasSetResolver(){} // RVA: 0x7FFAC3331A00
        public void GetResolver(){} // RVA: 0x7FFAC313CBB0
        public void set_XmlResolver(){} // RVA: 0x7FFAC91E8F00
        public void IsValidChildType(){} // RVA: 0x7FFAC91E9250
        public void HasNodeTypeInPrevSiblings(){} // RVA: 0x7FFAC91E9420
        public void HasNodeTypeInNextSiblings(){} // RVA: 0x7FFAC91E9510
        public void CanInsertBefore(){} // RVA: 0x7FFAC91E9590
        public void CanInsertAfter(){} // RVA: 0x7FFAC91E9760
        public void CreateAttribute(){} // RVA: 0x7FFAC91EB250 | overloaded x3
        public void SetDefaultNamespace(){} // RVA: 0x7FFAC91E9990
        public void CreateCDataSection(){} // RVA: 0x7FFAC91E9B60
        public void CreateComment(){} // RVA: 0x7FFAC91E9BD0
        public void CreateDocumentType(){} // RVA: 0x7FFAC91E9C40
        public void CreateDocumentFragment(){} // RVA: 0x7FFAC91E9CE0
        public void CreateElement(){} // RVA: 0x7FFAC91EB3A0 | overloaded x3
        public void AddDefaultAttributes(){} // RVA: 0x7FFAC91E9E80
        public void GetSchemaElementDecl(){} // RVA: 0x7FFAC91EA230
        public void PrepareDefaultAttribute(){} // RVA: 0x7FFAC91EA360
        public void CreateEntityReference(){} // RVA: 0x7FFAC91EA4A0
        public void CreateProcessingInstruction(){} // RVA: 0x7FFAC91EA510
        public void CreateXmlDeclaration(){} // RVA: 0x7FFAC91EA590
        public void CreateTextNode(){} // RVA: 0x7FFAC91EA630
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFAC91EA6A0
        public void CreateWhitespace(){} // RVA: 0x7FFAC91EA710
        public void ImportNodeInternal(){} // RVA: 0x7FFAC91EA8E0
        public void ImportAttributes(){} // RVA: 0x7FFAC91EB020
        public void ImportChildren(){} // RVA: 0x7FFAC91EB190
        public void get_NameTable(){} // RVA: 0x7FFAC356C7D0
        public void CreateDefaultAttribute(){} // RVA: 0x7FFAC91EB2F0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_Entities(){} // RVA: 0x7FFAC91EB470
        public void set_Entities(){} // RVA: 0x7FFAC2F4F890
        public void get_IsLoading(){} // RVA: 0x7FFAC8E5D270
        public void set_IsLoading(){} // RVA: 0x7FFAC91EB570
        public void get_ActualLoadingStatus(){} // RVA: 0x7FFAC778CF40
        public void ReadNode(){} // RVA: 0x7FFAC91EB580
        public void SetupReader(){} // RVA: 0x7FFAC91EB640
        public void Load(){} // RVA: 0x7FFAC91EB6B0
        public void LoadXml(){} // RVA: 0x7FFAC91EB7D0
        public void set_InnerText(){} // RVA: 0x7FFAC91EBAA0
        public void set_InnerXml(){} // RVA: 0x7FFAC874A690
        public void Save(){} // RVA: 0x7FFAC91EBB00
        public void WriteTo(){} // RVA: 0x7FFAC91EBDC0
        public void WriteContentTo(){} // RVA: 0x7FFAC91EBDE0
        public void GetEventArgs(){} // RVA: 0x7FFAC91EC050
        public void GetInsertEventArgsForLoad(){} // RVA: 0x7FFAC91EC150
        public void BeforeEvent(){} // RVA: 0x7FFAC91EC220
        public void AfterEvent(){} // RVA: 0x7FFAC91EC2A0
        public void GetDefaultAttribute(){} // RVA: 0x7FFAC91EC320
        public void get_Version(){} // RVA: 0x7FFAC91EC650
        public void get_Encoding(){} // RVA: 0x7FFAC91EC680
        public void get_Standalone(){} // RVA: 0x7FFAC91EC6B0
        public void GetEntityNode(){} // RVA: 0x7FFAC91EC6E0
        public void get_SchemaInfo(){} // RVA: 0x7FFAC91EC7D0
        public void get_BaseURI(){} // RVA: 0x7FFAC33BC6D0
        public void SetBaseURI(){} // RVA: 0x7FFAC33B8580
        public void AppendChildForLoad(){} // RVA: 0x7FFAC91EC900
        public void .cctor(){} // RVA: 0x7FFAC91ECBB0
    }

    public class XmlDocumentFragment : XmlNode
    {
        public System.Xml.XmlLinkedNode Name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91ECE40
        public void get_Name(){} // RVA: 0x7FFAC91ECF10
        public void get_LocalName(){} // RVA: 0x7FFAC91ECF10
        public void get_NodeType(){} // RVA: 0x7FFAC8631FB0
        public void get_ParentNode(){} // RVA: 0x7FFAC34F9180
        public void get_OwnerDocument(){} // RVA: 0x7FFAC91ECF40
        public void set_InnerXml(){} // RVA: 0x7FFAC91ECFC0
        public void CloneNode(){} // RVA: 0x7FFAC91ED050
        public void get_IsContainer(){} // RVA: 0x7FFAC3006850
        public void get_LastNode(){} // RVA: 0x7FFAC2F247C0
        public void set_LastNode(){} // RVA: 0x7FFAC2F87E80
        public void IsValidChildType(){} // RVA: 0x7FFAC91ED0F0
        public void CanInsertAfter(){} // RVA: 0x7FFAC91ED1A0
        public void CanInsertBefore(){} // RVA: 0x7FFAC91ED220
        public void WriteTo(){} // RVA: 0x7FFAC91EBDC0
        public void WriteContentTo(){} // RVA: 0x7FFAC91ED2A0
    }

    public class XmlDocumentType : XmlLinkedNode
    {
        public string Name; // 0x20
        public string LocalName; // 0x28
        public string NodeType; // 0x30
        public string IsReadOnly; // 0x38
        public bool Entities; // 0x40
        public System.Xml.XmlNamedNodeMap Notations; // 0x48
        public System.Xml.XmlNamedNodeMap PublicId; // 0x50
        public System.Xml.Schema.SchemaInfo SystemId; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91ED510
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void get_LocalName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_NodeType(){} // RVA: 0x7FFAC314F980
        public void CloneNode(){} // RVA: 0x7FFAC91ED770
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_Entities(){} // RVA: 0x7FFAC91ED7D0
        public void get_Notations(){} // RVA: 0x7FFAC91ED8D0
        public void get_PublicId(){} // RVA: 0x7FFAC2F4F130
        public void get_SystemId(){} // RVA: 0x7FFAC31D95E0
        public void get_InternalSubset(){} // RVA: 0x7FFAC31D0140
        public void get_ParseWithNamespaces(){} // RVA: 0x7FFAC2FDCC00
        public void WriteTo(){} // RVA: 0x7FFAC91ED9D0
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void get_DtdSchemaInfo(){} // RVA: 0x7FFAC2FE9500
        public void set_DtdSchemaInfo(){} // RVA: 0x7FFAC2FE9510
    }

    public class XmlDownloadManager : Object
    {
        public System.Collections.Hashtable connections; // 0x10

        // ── Methods ──
        public void GetStream(){} // RVA: 0x7FFAC921E9C0
        public void GetNonFileStream(){} // RVA: 0x7FFAC921EB00
        public void Remove(){} // RVA: 0x7FFAC921F150
        public void GetStreamAsync(){} // RVA: 0x7FFAC921F350
        public void GetNonFileStreamAsync(){} // RVA: 0x7FFAC921F520
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlElement : XmlLinkedNode
    {
        public System.Xml.XmlName XmlName; // 0x20
        public System.Xml.XmlAttributeCollection Name; // 0x28
        public System.Xml.XmlLinkedNode LocalName; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91EDC40 | overloaded x2
        public void get_XmlName(){} // RVA: 0x7FFAC2F4F0C0
        public void set_XmlName(){} // RVA: 0x7FFAC2F4F0D0
        public void CloneNode(){} // RVA: 0x7FFAC91EDCB0
        public void get_Name(){} // RVA: 0x7FFAC91EE190
        public void get_LocalName(){} // RVA: 0x7FFAC2F29990
        public void get_NamespaceURI(){} // RVA: 0x7FFAC91EE1B0
        public void get_Prefix(){} // RVA: 0x7FFAC356A5F0
        public void set_Prefix(){} // RVA: 0x7FFAC91EE1D0
        public void get_NodeType(){} // RVA: 0x7FFAC3013AF0
        public void get_ParentNode(){} // RVA: 0x7FFAC2F3C380
        public void get_OwnerDocument(){} // RVA: 0x7FFAC91EE2D0
        public void get_IsContainer(){} // RVA: 0x7FFAC3006850
        public void AppendChildForLoad(){} // RVA: 0x7FFAC91EE2F0
        public void get_IsEmpty(){} // RVA: 0x7FFAC91EE6B0
        public void set_IsEmpty(){} // RVA: 0x7FFAC91EE6C0
        public void get_LastNode(){} // RVA: 0x7FFAC91EE7A0
        public void set_LastNode(){} // RVA: 0x7FFAC2F4F890
        public void IsValidChildType(){} // RVA: 0x7FFAC91EE7B0
        public void get_Attributes(){} // RVA: 0x7FFAC91EE810
        public void get_HasAttributes(){} // RVA: 0x7FFAC91EEA70
        public void GetAttribute(){} // RVA: 0x7FFAC91EEDE0 | overloaded x2
        public void SetAttribute(){} // RVA: 0x7FFAC91EEE90 | overloaded x2
        public void GetAttributeNode(){} // RVA: 0x7FFAC91EEFD0 | overloaded x2
        public void SetAttributeNode(){} // RVA: 0x7FFAC91EF060 | overloaded x2
        public void HasAttribute(){} // RVA: 0x7FFAC91EF160
        public void WriteTo(){} // RVA: 0x7FFAC91EF190
        public void WriteElementTo(){} // RVA: 0x7FFAC91EF2F0
        public void WriteStartElement(){} // RVA: 0x7FFAC91EF580
        public void WriteContentTo(){} // RVA: 0x7FFAC91E3D60
        public void RemoveAllAttributes(){} // RVA: 0x7FFAC91EF6C0
        public void RemoveAll(){} // RVA: 0x7FFAC91EF7D0
        public void RemoveAllChildren(){} // RVA: 0x7FFAC91EF800
        public void get_SchemaInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void set_InnerXml(){} // RVA: 0x7FFAC91EF810
        public void get_InnerText(){} // RVA: 0x7FFAC91EF900
        public void set_InnerText(){} // RVA: 0x7FFAC91EF910
        public void get_NextSibling(){} // RVA: 0x7FFAC91EFA00
        public void SetParent(){} // RVA: 0x7FFAC2F22E30
    }

    public class XmlEncodedRawTextWriter : XmlRawWriter
    {
        public bool SupportsNamespaceDeclarationInChunks; // 0x28
        public byte[] bufBytes; // 0x30
        public System.IO.Stream stream; // 0x38
        public System.Text.Encoding encoding; // 0x40
        public System.Xml.XmlCharType xmlCharType; // 0x48
        public int bufPos; // 0x50
        public int textPos; // 0x54
        public int contentPos; // 0x58
        public int cdataPos; // 0x5C
        public int attrEndPos; // 0x60
        public int bufLen; // 0x64
        public bool writeToNull; // 0x68
        public bool hadDoubleBracket; // 0x69
        public bool inAttributeValue; // 0x6A
        public int bufBytesUsed; // 0x6C
        public char[] bufChars; // 0x70
        public System.Text.Encoder encoder; // 0x78
        public System.IO.TextWriter writer; // 0x80
        public bool trackTextContent; // 0x88
        public bool inTextContent; // 0x89
        public int lastMarkPos; // 0x8C
        public int[] textContentMarks; // 0x90
        public System.Xml.CharEntityEncoderFallback charEntityFallback; // 0x98
        public 0x6B159B28 newLineHandling; // 0xA0
        public bool closeOutput; // 0xA4
        public bool omitXmlDeclaration; // 0xA5
        public string newLineChars; // 0xA8
        public bool checkCharacters; // 0xB0
        public 0x6B15B6A8 standalone; // 0xB4
        public 0x6B15B5F8 outputMethod; // 0xB8
        public bool autoXmlDeclaration; // 0xBC
        public bool mergeCDataSections; // 0xBD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91B05A0 | overloaded x3
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC91B0D60 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC91B0DD0
        public void WriteStartElement(){} // RVA: 0x7FFAC91B1070
        public void StartElementContent(){} // RVA: 0x7FFAC91B1150
        public void WriteEndElement(){} // RVA: 0x7FFAC91B1190
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91B1310
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91B1430
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91B1550
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFAC91B15B0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFAC3006850
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFAC91B1610
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFAC91B1770
        public void WriteCData(){} // RVA: 0x7FFAC91B17D0
        public void WriteComment(){} // RVA: 0x7FFAC91B1A10
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91B1B70
        public void WriteEntityRef(){} // RVA: 0x7FFAC91B1CC0
        public void WriteCharEntity(){} // RVA: 0x7FFAC91B1D90
        public void WriteWhitespace(){} // RVA: 0x7FFAC91B2010
        public void WriteString(){} // RVA: 0x7FFAC91B2090
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91B2110
        public void WriteChars(){} // RVA: 0x7FFAC9096480
        public void WriteRaw(){} // RVA: 0x7FFAC91ABEE0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC91B23A0
        public void Flush(){} // RVA: 0x7FFAC91B2680
        public void FlushBuffer(){} // RVA: 0x7FFAC91B2710
        public void EncodeChars(){} // RVA: 0x7FFAC91B2C70
        public void FlushEncoder(){} // RVA: 0x7FFAC91B2DF0
        public void WriteAttributeTextBlock(){} // RVA: 0x7FFAC91B2ED0
        public void WriteElementTextBlock(){} // RVA: 0x7FFAC91B31E0
        public void RawText(){} // RVA: 0x7FFAC91B3540 | overloaded x2
        public void WriteRawWithCharChecking(){} // RVA: 0x7FFAC91B36D0
        public void WriteCommentOrPi(){} // RVA: 0x7FFAC91B3960
        public void WriteCDataSection(){} // RVA: 0x7FFAC91B3CF0
        public void EncodeSurrogate(){} // RVA: 0x7FFAC91B4070
        public void InvalidXmlChar(){} // RVA: 0x7FFAC91B41F0
        public void EncodeChar(){} // RVA: 0x7FFAC91B43A0
        public void ChangeTextContentMark(){} // RVA: 0x7FFAC91B4480
        public void GrowTextContentMarks(){} // RVA: 0x7FFAC91B4500
        public void WriteNewLine(){} // RVA: 0x7FFAC91B46A0
        public void LtEntity(){} // RVA: 0x7FFAC91B4720
        public void GtEntity(){} // RVA: 0x7FFAC91B4740
        public void AmpEntity(){} // RVA: 0x7FFAC91B4760
        public void QuoteEntity(){} // RVA: 0x7FFAC91B4780
        public void TabEntity(){} // RVA: 0x7FFAC91B47A0
        public void LineFeedEntity(){} // RVA: 0x7FFAC91B47C0
        public void CarriageReturnEntity(){} // RVA: 0x7FFAC91B47E0
        public void CharEntity(){} // RVA: 0x7FFAC91B4800
        public void RawStartCData(){} // RVA: 0x7FFAC91B4950
        public void RawEndCData(){} // RVA: 0x7FFAC91B4980
        public void ValidateContentChars(){} // RVA: 0x7FFAC91B49A0
    }

    public class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
    {
        public int indentLevel; // 0xC0
        public bool newLineOnAttributes; // 0xC4
        public string indentChars; // 0xC8
        public bool mixedContent; // 0xD0
        public System.Xml.BitStack mixedContentStack; // 0xD8
        public 0x6B159398 conformanceLevel; // 0xE0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91B4DD0 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC91B4E00
        public void WriteStartElement(){} // RVA: 0x7FFAC91B4E70
        public void StartElementContent(){} // RVA: 0x7FFAC91B4FC0
        public void OnRootElement(){} // RVA: 0x7FFAC4837F60
        public void WriteEndElement(){} // RVA: 0x7FFAC91B5030
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91B5100
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91B51D0
        public void WriteCData(){} // RVA: 0x7FFAC91B5230
        public void WriteComment(){} // RVA: 0x7FFAC91B5240
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91B5280
        public void WriteEntityRef(){} // RVA: 0x7FFAC91B52D0
        public void WriteCharEntity(){} // RVA: 0x7FFAC91B53A0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91B53B0
        public void WriteWhitespace(){} // RVA: 0x7FFAC91B53C0
        public void WriteString(){} // RVA: 0x7FFAC91B5440
        public void WriteChars(){} // RVA: 0x7FFAC91B54C0
        public void WriteRaw(){} // RVA: 0x7FFAC91B55F0 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC91B5660
        public void Init(){} // RVA: 0x7FFAC91B5680
        public void WriteIndent(){} // RVA: 0x7FFAC91B5860
    }

    public class XmlEntity : XmlNode
    {
        public string IsReadOnly; // 0x18
        public string Name; // 0x20
        public string LocalName; // 0x28
        public string InnerText; // 0x30
        public string IsContainer; // 0x38
        public string LastNode; // 0x40
        public System.Xml.XmlLinkedNode NodeType; // 0x48
        public bool SystemId; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91EFA40
        public void CloneNode(){} // RVA: 0x7FFAC91EFD50
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_Name(){} // RVA: 0x7FFAC31D95E0
        public void get_LocalName(){} // RVA: 0x7FFAC31D95E0
        public void get_InnerText(){} // RVA: 0x7FFAC91EF900
        public void set_InnerText(){} // RVA: 0x7FFAC91EFDB0
        public void get_IsContainer(){} // RVA: 0x7FFAC3006850
        public void get_LastNode(){} // RVA: 0x7FFAC91EFE10
        public void set_LastNode(){} // RVA: 0x7FFAC2F9C740
        public void IsValidChildType(){} // RVA: 0x7FFAC91EFF20
        public void get_NodeType(){} // RVA: 0x7FFAC36A9850
        public void get_SystemId(){} // RVA: 0x7FFAC2F4F0C0
        public void set_InnerXml(){} // RVA: 0x7FFAC91EFF40
        public void WriteTo(){} // RVA: 0x7FFAC2F21310
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void get_BaseURI(){} // RVA: 0x7FFAC2F9E740
        public void SetBaseURI(){} // RVA: 0x7FFAC2F49200
    }

    public class XmlEntityReference : XmlLinkedNode
    {
        public string Name; // 0x20
        public System.Xml.XmlLinkedNode LocalName; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91EFFA0
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void get_LocalName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Value(){} // RVA: 0x7FFAC34F9180
        public void set_Value(){} // RVA: 0x7FFAC91F00E0
        public void get_NodeType(){} // RVA: 0x7FFAC31E48B0
        public void CloneNode(){} // RVA: 0x7FFAC91F0140
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_IsContainer(){} // RVA: 0x7FFAC3006850
        public void SetParent(){} // RVA: 0x7FFAC91F0190
        public void SetParentForLoad(){} // RVA: 0x7FFAC91F0310
        public void get_LastNode(){} // RVA: 0x7FFAC2F4F130
        public void set_LastNode(){} // RVA: 0x7FFAC2F22E90
        public void IsValidChildType(){} // RVA: 0x7FFAC91EE7B0
        public void WriteTo(){} // RVA: 0x7FFAC91F0330
        public void WriteContentTo(){} // RVA: 0x7FFAC91F0370
        public void get_BaseURI(){} // RVA: 0x7FFAC91F05E0
        public void ConstructBaseURI(){} // RVA: 0x7FFAC91F0620
        public void get_ChildBaseURI(){} // RVA: 0x7FFAC91F06F0
    }

    public class XmlEventCache : XmlRawWriter
    {
        public System.Collections.Generic.List`1<XmlEvent[]> pages; // 0x28
        public XmlEvent[] pageCurr; // 0x30
        public int pageSize; // 0x38
        public bool hasRootNode; // 0x3C
        public System.Xml.Xsl.Runtime.StringConcat singleText; // 0x40
        public string baseUri; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91B58E0
        public void EndEvents(){} // RVA: 0x7FFAC91B5940
        public void EventsToWriter(){} // RVA: 0x7FFAC91B5990
        public void WriteDocType(){} // RVA: 0x7FFAC91B6490
        public void WriteStartElement(){} // RVA: 0x7FFAC91B6520
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91B65B0
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91B6640
        public void WriteCData(){} // RVA: 0x7FFAC91B6680
        public void WriteComment(){} // RVA: 0x7FFAC91B6690
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91B66A0
        public void WriteWhitespace(){} // RVA: 0x7FFAC91B66D0
        public void WriteString(){} // RVA: 0x7FFAC91B66E0
        public void WriteChars(){} // RVA: 0x7FFAC3F35600
        public void WriteRaw(){} // RVA: 0x7FFAC91B6710 | overloaded x2
        public void WriteEntityRef(){} // RVA: 0x7FFAC91B6720
        public void WriteCharEntity(){} // RVA: 0x7FFAC91B6730
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91B67A0
        public void WriteBase64(){} // RVA: 0x7FFAC91B6840
        public void WriteBinHex(){} // RVA: 0x7FFAC91B6880
        public void Close(){} // RVA: 0x7FFAC91B68C0
        public void Flush(){} // RVA: 0x7FFAC91B6900
        public void WriteValue(){} // RVA: 0x7FFAC91B6940
        public void Dispose(){} // RVA: 0x7FFAC91B6960
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC91B6AD0 | overloaded x2
        public void StartElementContent(){} // RVA: 0x7FFAC91B6AE0
        public void WriteEndElement(){} // RVA: 0x7FFAC91B6B20
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91B6BB0
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFAC91B6C40
        public void WriteEndBase64(){} // RVA: 0x7FFAC91B6C70
        public void AddEvent(){} // RVA: 0x7FFAC91B6F30 | overloaded x6
        public void NewEvent(){} // RVA: 0x7FFAC91B6FE0
        public void ToBytes(){} // RVA: 0x7FFAC91B72A0
    }

    public class XmlException : SystemException
    {
        public string LineNumber; // 0x90
        public string[] LinePosition; // 0x98
        public int Message; // 0xA0
        public int ResString; // 0xA4
        public string sourceUri; // 0xA8
        public string message; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92245E0 | overloaded x18
        public void GetObjectData(){} // RVA: 0x7FFAC9223440
        public void FormatUserMessage(){} // RVA: 0x7FFAC9224770
        public void CreateMessage(){} // RVA: 0x7FFAC9224880
        public void BuildCharExceptionArgs(){} // RVA: 0x7FFAC9224AD0 | overloaded x3
        public void get_LineNumber(){} // RVA: 0x7FFAC489E510
        public void get_LinePosition(){} // RVA: 0x7FFAC6539470
        public void get_Message(){} // RVA: 0x7FFAC9224E00
        public void get_ResString(){} // RVA: 0x7FFAC32EF640
    }

    public class XmlImplementation : Object
    {
        public System.Xml.XmlNameTable NameTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void CreateDocument(){} // RVA: 0x7FFAC91F09F0
        public void get_NameTable(){} // RVA: 0x7FFAC2F3C380
    }

    public class XmlLinkedNode : XmlNode
    {
        public System.Xml.XmlLinkedNode PreviousSibling; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91F0A50
        public void get_PreviousSibling(){} // RVA: 0x7FFAC91F0B80
        public void get_NextSibling(){} // RVA: 0x7FFAC91F0C10
    }

    public class XmlLoader : Object
    {
        public System.Xml.XmlDocument doc; // 0x10
        public System.Xml.XmlReader reader; // 0x18
        public bool preserveWhitespace; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Load(){} // RVA: 0x7FFAC91F0C70
        public void LoadDocSequence(){} // RVA: 0x7FFAC91F10B0
        public void ReadCurrentNode(){} // RVA: 0x7FFAC91F1130
        public void LoadNode(){} // RVA: 0x7FFAC91F1370
        public void LoadAttributeNode(){} // RVA: 0x7FFAC91F1B20
        public void LoadDefaultAttribute(){} // RVA: 0x7FFAC91F1ED0
        public void LoadAttributeValue(){} // RVA: 0x7FFAC91F2110
        public void LoadEntityReferenceNode(){} // RVA: 0x7FFAC91F2460
        public void LoadDeclarationNode(){} // RVA: 0x7FFAC91F26C0
        public void LoadDocumentTypeNode(){} // RVA: 0x7FFAC91F2940
        public void LoadNodeDirect(){} // RVA: 0x7FFAC91F2BE0
        public void LoadAttributeNodeDirect(){} // RVA: 0x7FFAC91F31F0
        public void ParseDocumentType(){} // RVA: 0x7FFAC91F3460 | overloaded x2
        public void LoadDocumentType(){} // RVA: 0x7FFAC91F3800
        public void GetContext(){} // RVA: 0x7FFAC91F4970
        public void ParsePartialContent(){} // RVA: 0x7FFAC91F53F0
        public void LoadInnerXmlElement(){} // RVA: 0x7FFAC91F5700
        public void LoadInnerXmlAttribute(){} // RVA: 0x7FFAC91F57A0
        public void RemoveDuplicateNamespace(){} // RVA: 0x7FFAC91F57C0
        public void EntitizeName(){} // RVA: 0x7FFAC91F5BA0
        public void ExpandEntity(){} // RVA: 0x7FFAC91F5C00
        public void ExpandEntityReference(){} // RVA: 0x7FFAC91F5CC0
        public void CreateInnerXmlReader(){} // RVA: 0x7FFAC91F6440
        public void ParseXmlDeclarationValue(){} // RVA: 0x7FFAC91F66E0
        public void UnexpectedNodeType(){} // RVA: 0x7FFAC91F6C00
    }

    public class XmlName : Object
    {
        public string LocalName; // 0x10
        public string NamespaceURI; // 0x18
        public string Prefix; // 0x20
        public string HashCode; // 0x28
        public int OwnerDocument; // 0x30
        public System.Xml.XmlDocument Name; // 0x38
        public System.Xml.XmlName Validity; // 0x40

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC91F6D70
        public void .ctor(){} // RVA: 0x7FFAC91F6E90
        public void get_LocalName(){} // RVA: 0x7FFAC2F247C0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Prefix(){} // RVA: 0x7FFAC2F3C380
        public void get_HashCode(){} // RVA: 0x7FFAC2F7CCD0
        public void get_OwnerDocument(){} // RVA: 0x7FFAC31D0140
        public void get_Name(){} // RVA: 0x7FFAC91F70B0
        public void get_Validity(){} // RVA: 0x7FFAC34F9180
        public void get_IsDefault(){} // RVA: 0x7FFAC2F21320
        public void get_IsNil(){} // RVA: 0x7FFAC2F21320
        public void get_MemberType(){} // RVA: 0x7FFAC34F9180
        public void get_SchemaType(){} // RVA: 0x7FFAC34F9180
        public void get_SchemaElement(){} // RVA: 0x7FFAC34F9180
        public void get_SchemaAttribute(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFAC3EF7720
        public void GetHashCode(){} // RVA: 0x7FFAC91F7360
    }

    public class XmlNameEx : XmlName
    {
        public byte Validity; // 0x48
        public System.Xml.Schema.XmlSchemaSimpleType IsDefault; // 0x50
        public System.Xml.Schema.XmlSchemaType IsNil; // 0x58
        public object MemberType; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91F73D0
        public void get_Validity(){} // RVA: 0x7FFAC91F7630
        public void get_IsDefault(){} // RVA: 0x7FFAC91F7660
        public void get_IsNil(){} // RVA: 0x7FFAC91F7670
        public void get_MemberType(){} // RVA: 0x7FFAC2FC20E0
        public void get_SchemaType(){} // RVA: 0x7FFAC2FE9500
        public void get_SchemaElement(){} // RVA: 0x7FFAC91F7680
        public void get_SchemaAttribute(){} // RVA: 0x7FFAC91F7710
        public void SetValidity(){} // RVA: 0x7FFAC91F77A0
        public void SetIsDefault(){} // RVA: 0x7FFAC91F77B0
        public void SetIsNil(){} // RVA: 0x7FFAC91F77E0
        public void Equals(){} // RVA: 0x7FFAC91F7810
    }

    public class XmlNameTable : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2C58F40
        public void Add(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlNamedNodeMap : Object
    {
        public System.Xml.XmlNode Count; // 0x10
        public SmallXmlNodeList nodes; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetNamedItem(){} // RVA: 0x7FFAC91F79F0
        public void SetNamedItem(){} // RVA: 0x7FFAC91F7BA0
        public void get_Count(){} // RVA: 0x7FFAC91E4CF0
        public void GetEnumerator(){} // RVA: 0x7FFAC91F7C80
        public void FindNodeOffset(){} // RVA: 0x7FFAC91F7DC0 | overloaded x2
        public void AddNode(){} // RVA: 0x7FFAC91F7F50
        public void AddNodeForLoad(){} // RVA: 0x7FFAC91F8100
        public void RemoveNodeAt(){} // RVA: 0x7FFAC91F81D0
        public void ReplaceNodeAt(){} // RVA: 0x7FFAC91F8350
        public void InsertNodeAt(){} // RVA: 0x7FFAC91F83C0
    }

    public class XmlNamespaceManager : Object
    {
        public NamespaceDeclaration[] NameTable; // 0x10
        public int DefaultNamespace; // 0x18
        public System.Xml.XmlNameTable nameTable; // 0x20
        public int scopeId; // 0x28
        public System.Collections.Generic.Dictionary`2<string,int> hashTable; // 0x30
        public bool useHashtable; // 0x38
        public string xml; // 0x40
        public string xmlNs; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9224E20 | overloaded x2
        public void get_NameTable(){} // RVA: 0x7FFAC2F4F0C0
        public void get_DefaultNamespace(){} // RVA: 0x7FFAC92251A0
        public void PushScope(){} // RVA: 0x7FFAC6CD5630
        public void PopScope(){} // RVA: 0x7FFAC9225210
        public void AddNamespace(){} // RVA: 0x7FFAC9225330
        public void RemoveNamespace(){} // RVA: 0x7FFAC92257F0
        public void GetEnumerator(){} // RVA: 0x7FFAC92259B0
        public void GetNamespacesInScope(){} // RVA: 0x7FFAC9225BC0
        public void LookupNamespace(){} // RVA: 0x7FFAC9225D90
        public void LookupNamespaceDecl(){} // RVA: 0x7FFAC9225DE0
        public void LookupPrefix(){} // RVA: 0x7FFAC9226010
    }

    public class XmlNode : Object
    {
        public System.Xml.XmlNode Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91F8F20 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC34F9180
        public void set_Value(){} // RVA: 0x7FFAC91F8FF0
        public void get_NodeType(){} // RVA: 0x7FFAC2C59960
        public void get_ParentNode(){} // RVA: 0x7FFAC91F90D0
        public void get_ChildNodes(){} // RVA: 0x7FFAC91F91D0
        public void get_PreviousSibling(){} // RVA: 0x7FFAC34F9180
        public void get_NextSibling(){} // RVA: 0x7FFAC34F9180
        public void get_Attributes(){} // RVA: 0x7FFAC34F9180
        public void get_OwnerDocument(){} // RVA: 0x7FFAC91F9260
        public void get_FirstChild(){} // RVA: 0x7FFAC91F9330
        public void get_LastChild(){} // RVA: 0x7FFAC617D250
        public void get_IsContainer(){} // RVA: 0x7FFAC2F21320
        public void get_LastNode(){} // RVA: 0x7FFAC34F9180
        public void set_LastNode(){} // RVA: 0x7FFAC2F21310
        public void AncestorNode(){} // RVA: 0x7FFAC91F9360
        public void InsertBefore(){} // RVA: 0x7FFAC91F93E0
        public void InsertAfter(){} // RVA: 0x7FFAC91F9DB0
        public void RemoveChild(){} // RVA: 0x7FFAC91FA710
        public void PrependChild(){} // RVA: 0x7FFAC91FACE0
        public void AppendChild(){} // RVA: 0x7FFAC91FAD30
        public void AppendChildForLoad(){} // RVA: 0x7FFAC91FB3D0
        public void IsValidChildType(){} // RVA: 0x7FFAC2F21320
        public void CanInsertBefore(){} // RVA: 0x7FFAC3006850
        public void CanInsertAfter(){} // RVA: 0x7FFAC3006850
        public void get_HasChildNodes(){} // RVA: 0x7FFAC91FB710
        public void CloneNode(){}
        public void CopyChildren(){} // RVA: 0x7FFAC91FB740
        public void get_NamespaceURI(){} // RVA: 0x7FFAC91FB800
        public void get_Prefix(){} // RVA: 0x7FFAC91FB840
        public void set_Prefix(){} // RVA: 0x7FFAC2F21310
        public void get_LocalName(){} // RVA: 0x7FFAC2C58E90
        public void get_IsReadOnly(){} // RVA: 0x7FFAC91FB880
        public void HasReadOnlyParent(){} // RVA: 0x7FFAC91FB960
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC91FBA40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC91FBA60
        public void GetEnumerator(){} // RVA: 0x7FFAC91FBAC0
        public void AppendChildText(){} // RVA: 0x7FFAC91FBB20
        public void get_InnerText(){} // RVA: 0x7FFAC91FBC50
        public void set_InnerText(){} // RVA: 0x7FFAC91FBD90
        public void set_InnerXml(){} // RVA: 0x7FFAC91FBEA0
        public void get_SchemaInfo(){} // RVA: 0x7FFAC91FBF00
        public void get_BaseURI(){} // RVA: 0x7FFAC91FBF60
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void WriteContentTo(){} // RVA: 0x7FFAC2C70A40
        public void RemoveAll(){} // RVA: 0x7FFAC91FC090
        public void get_Document(){} // RVA: 0x7FFAC91FC110
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC91FC1C0
        public void GetPrefixOfNamespaceStrict(){} // RVA: 0x7FFAC91FC220
        public void SetParent(){} // RVA: 0x7FFAC91FC6E0
        public void SetParentForLoad(){} // RVA: 0x7FFAC2F22E30
        public void SplitName(){} // RVA: 0x7FFAC91FC7C0
        public void FindChild(){} // RVA: 0x7FFAC91FC940
        public void GetEventArgs(){} // RVA: 0x7FFAC91FC9D0
        public void BeforeEvent(){} // RVA: 0x7FFAC91FCB10
        public void AfterEvent(){} // RVA: 0x7FFAC91FCB60
        public void get_XmlSpace(){} // RVA: 0x7FFAC91FCBB0
        public void get_XmlLang(){} // RVA: 0x7FFAC91FCE50
        public void get_IsText(){} // RVA: 0x7FFAC2F21320
        public void NestTextNodes(){} // RVA: 0x7FFAC91FCF80
        public void UnnestTextNodes(){} // RVA: 0x7FFAC91FCFE0
    }

    public class XmlNodeChangedEventArgs : EventArgs
    {
        public 0x6B15BE90 Action; // 0x10
        public System.Xml.XmlNode node; // 0x18
        public System.Xml.XmlNode oldParent; // 0x20
        public System.Xml.XmlNode newParent; // 0x28
        public string oldValue; // 0x30
        public string newValue; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91FD060
        public void get_Action(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class XmlNodeChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class XmlNodeList : Object
    {
        public object Count;
        public object ItemOf;

        // ── Methods ──
        public void Item(){} // RVA: 0x7FFAC2C67DE0
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_ItemOf(){} // RVA: 0x7FFAC6916740
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC3F5BE50
        public void PrivateDisposeNodeList(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlNodeReader : XmlReader
    {
        public System.Xml.XmlNodeReaderNavigator NodeType; // 0x10
        public 0x6B15D5F0 Name; // 0x18
        public int LocalName; // 0x1C
        public 0x6B159D90 NamespaceURI; // 0x20
        public bool Prefix; // 0x24
        public bool Value; // 0x25
        public bool Depth; // 0x26
        public bool BaseURI; // 0x27
        public System.Xml.ReadContentAsBinaryHelper CanResolveEntity; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9201EC0
        public void IsInReadingStates(){} // RVA: 0x7FFAC89086E0
        public void get_NodeType(){} // RVA: 0x7FFAC9202000
        public void get_Name(){} // RVA: 0x7FFAC9202010
        public void get_LocalName(){} // RVA: 0x7FFAC9202080
        public void get_NamespaceURI(){} // RVA: 0x7FFAC92021B0
        public void get_Prefix(){} // RVA: 0x7FFAC9202230
        public void get_Value(){} // RVA: 0x7FFAC92022B0
        public void get_Depth(){} // RVA: 0x7FFAC44357F0
        public void get_BaseURI(){} // RVA: 0x7FFAC9202320
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC3006850
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC9202360
        public void get_IsDefault(){} // RVA: 0x7FFAC9202390
        public void get_XmlSpace(){} // RVA: 0x7FFAC9202470
        public void get_XmlLang(){} // RVA: 0x7FFAC92024C0
        public void get_SchemaInfo(){} // RVA: 0x7FFAC9202540
        public void get_AttributeCount(){} // RVA: 0x7FFAC9202590
        public void GetAttribute(){} // RVA: 0x7FFAC92026A0 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC9202860 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC9202A20
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC9202B20
        public void MoveToElement(){} // RVA: 0x7FFAC9202C30
        public void Read(){} // RVA: 0x7FFAC9202DA0 | overloaded x2
        public void ReadNextNode(){} // RVA: 0x7FFAC9202F70
        public void SetEndOfFile(){} // RVA: 0x7FFAC9203230
        public void ReadAtZeroLevel(){} // RVA: 0x7FFAC9203250
        public void ReadForward(){} // RVA: 0x7FFAC92032F0
        public void ReSetReadingMarks(){} // RVA: 0x7FFAC9203510
        public void get_EOF(){} // RVA: 0x7FFAC9203540
        public void Close(){} // RVA: 0x7FFAC9203550
        public void get_ReadState(){} // RVA: 0x7FFAC30DBBE0
        public void Skip(){} // RVA: 0x7FFAC9203560
        public void ReadString(){} // RVA: 0x7FFAC9203570
        public void get_HasAttributes(){} // RVA: 0x7FFAC91BA0E0
        public void get_NameTable(){} // RVA: 0x7FFAC3510100
        public void LookupNamespace(){} // RVA: 0x7FFAC9203620
        public void ResolveEntity(){} // RVA: 0x7FFAC9203660
        public void ReadAttributeValue(){} // RVA: 0x7FFAC92036F0
        public void FinishReadBinary(){} // RVA: 0x7FFAC9203740
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC9203770
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC9203790
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC92037B0
        public void get_DtdInfo(){} // RVA: 0x7FFAC9203830
    }

    public class XmlNodeReaderNavigator : Object
    {
        public System.Xml.XmlNode NodeType; // 0x10
        public System.Xml.XmlNode NamespaceURI; // 0x18
        public System.Xml.XmlNode Name; // 0x20
        public int LocalName; // 0x28
        public int CreatedOnAttribute; // 0x2C
        public System.Xml.XmlNameTable Prefix; // 0x30
        public System.Xml.XmlDocument Value; // 0x38
        public int BaseURI; // 0x40
        public int XmlSpace; // 0x44
        public int XmlLang; // 0x48
        public int IsEmptyElement; // 0x4C
        public int IsDefault; // 0x50
        public bool SchemaInfo; // 0x54
        public bool NameTable; // 0x55
        public VirtualAttribute[] AttributeCount; // 0x58
        public VirtualAttribute[] IsOnDeclOrDocType; // 0x60
        public bool Document; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91FD270
        public void get_NodeType(){} // RVA: 0x7FFAC91FDC50
        public void get_NamespaceURI(){} // RVA: 0x7FFAC8804760
        public void get_Name(){} // RVA: 0x7FFAC91FDCA0
        public void get_LocalName(){} // RVA: 0x7FFAC91FDDE0
        public void get_CreatedOnAttribute(){} // RVA: 0x7FFAC45A1580
        public void IsLocalNameEmpty(){} // RVA: 0x7FFAC91FDEC0
        public void get_Prefix(){} // RVA: 0x7FFAC8F0AD10
        public void get_Value(){} // RVA: 0x7FFAC91FDF10
        public void get_BaseURI(){} // RVA: 0x7FFAC8F0ADD0
        public void get_XmlSpace(){} // RVA: 0x7FFAC91FE1E0
        public void get_XmlLang(){} // RVA: 0x7FFAC91FE210
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC91FE240
        public void get_IsDefault(){} // RVA: 0x7FFAC91FE2F0
        public void get_SchemaInfo(){} // RVA: 0x7FFAC9139590
        public void get_NameTable(){} // RVA: 0x7FFAC31D95E0
        public void get_AttributeCount(){} // RVA: 0x7FFAC91FE3B0
        public void CheckIndexCondition(){} // RVA: 0x7FFAC91FE500
        public void InitDecAttr(){} // RVA: 0x7FFAC91FE570
        public void GetDeclarationAttr(){} // RVA: 0x7FFAC91FEB00 | overloaded x2
        public void GetDecAttrInd(){} // RVA: 0x7FFAC91FEB50
        public void InitDocTypeAttr(){} // RVA: 0x7FFAC91FEC10
        public void GetDocumentTypeAttr(){} // RVA: 0x7FFAC91FEF90 | overloaded x2
        public void GetDocTypeAttrInd(){} // RVA: 0x7FFAC91FEFE0
        public void GetAttributeFromElement(){} // RVA: 0x7FFAC91FF440 | overloaded x2
        public void GetAttribute(){} // RVA: 0x7FFAC91FF810 | overloaded x3
        public void LogMove(){} // RVA: 0x7FFAC91FFA70
        public void RollBackMove(){} // RVA: 0x7FFAC91FFAE0
        public void get_IsOnDeclOrDocType(){} // RVA: 0x7FFAC91FFB60
        public void ResetToAttribute(){} // RVA: 0x7FFAC91FFBA0
        public void ResetMove(){} // RVA: 0x7FFAC91FFCD0
        public void MoveToAttribute(){} // RVA: 0x7FFAC9200420 | overloaded x3
        public void MoveToAttributeFromElement(){} // RVA: 0x7FFAC91FFFF0
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC92005F0
        public void MoveToParent(){} // RVA: 0x7FFAC92007F0
        public void MoveToFirstChild(){} // RVA: 0x7FFAC9200890
        public void MoveToNextSibling(){} // RVA: 0x7FFAC9200930
        public void MoveToNext(){} // RVA: 0x7FFAC92009D0
        public void MoveToElement(){} // RVA: 0x7FFAC9200A30
        public void LookupNamespace(){} // RVA: 0x7FFAC9200AC0
        public void DefaultLookupNamespace(){} // RVA: 0x7FFAC9200E60
        public void LookupPrefix(){} // RVA: 0x7FFAC9201080
        public void GetNamespacesInScope(){} // RVA: 0x7FFAC9201620
        public void ReadAttributeValue(){} // RVA: 0x7FFAC9201C90
        public void get_Document(){} // RVA: 0x7FFAC31D0140
    }

    public class XmlNotation : XmlNode
    {
        public string Name; // 0x18
        public string LocalName; // 0x20
        public string NodeType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9203860
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_LocalName(){} // RVA: 0x7FFAC2F4F130
        public void get_NodeType(){} // RVA: 0x7FFAC530B5A0
        public void CloneNode(){} // RVA: 0x7FFAC9203AB0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void set_InnerXml(){} // RVA: 0x7FFAC9203B10
        public void WriteTo(){} // RVA: 0x7FFAC2F21310
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlParserContext : Object
    {
        public System.Xml.XmlNameTable NameTable; // 0x10
        public System.Xml.XmlNamespaceManager NamespaceManager; // 0x18
        public string DocTypeName; // 0x20
        public string PublicId; // 0x28
        public string SystemId; // 0x30
        public string BaseURI; // 0x38
        public string InternalSubset; // 0x40
        public 0x6B15A5D0 XmlLang; // 0x48
        public string XmlSpace; // 0x50
        public System.Text.Encoding Encoding; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91B7730 | overloaded x3
        public void get_NameTable(){} // RVA: 0x7FFAC2F3C380
        public void get_NamespaceManager(){} // RVA: 0x7FFAC2F247C0
        public void get_DocTypeName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PublicId(){} // RVA: 0x7FFAC2F4F130
        public void get_SystemId(){} // RVA: 0x7FFAC31D95E0
        public void get_BaseURI(){} // RVA: 0x7FFAC2FC20E0
        public void get_InternalSubset(){} // RVA: 0x7FFAC31D0140
        public void get_XmlLang(){} // RVA: 0x7FFAC2F9E740
        public void get_XmlSpace(){} // RVA: 0x7FFAC2FC20C0
        public void get_Encoding(){} // RVA: 0x7FFAC2FE9500
        public void get_HasDtdInfo(){} // RVA: 0x7FFAC91B7E50
    }

    public class XmlProcessingInstruction : XmlLinkedNode
    {
        public string Name; // 0x20
        public string LocalName; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9203B70
        public void get_Name(){} // RVA: 0x7FFAC9203C50
        public void get_LocalName(){} // RVA: 0x7FFAC3EEA090
        public void get_Value(){} // RVA: 0x7FFAC2F4F130
        public void set_Value(){} // RVA: 0x7FFAC9203CB0
        public void set_Data(){} // RVA: 0x7FFAC9203CC0
        public void get_InnerText(){} // RVA: 0x7FFAC2F4F130
        public void set_InnerText(){} // RVA: 0x7FFAC9203CB0
        public void get_NodeType(){} // RVA: 0x7FFAC36AE2C0
        public void CloneNode(){} // RVA: 0x7FFAC9203DD0
        public void WriteTo(){} // RVA: 0x7FFAC9203E20
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlQualifiedName : Object
    {
        public HashCodeOfStringDelegate Namespace;
        public string Name; // 0x10
        public string IsEmpty; // 0x18
        public int hash; // 0x20
        public System.Xml.XmlQualifiedName Empty; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92264C0 | overloaded x3
        public void get_Namespace(){} // RVA: 0x7FFAC2F247C0
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void GetHashCode(){} // RVA: 0x7FFAC92265F0
        public void get_IsEmpty(){} // RVA: 0x7FFAC9226730
        public void ToString(){} // RVA: 0x7FFAC9226B30 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC92267E0
        public void op_Equality(){} // RVA: 0x7FFAC9226970
        public void op_Inequality(){} // RVA: 0x7FFAC9226A30
        public void GetHashCodeDelegate(){} // RVA: 0x7FFAC9226BA0
        public void IsRandomizedHashingDisabled(){} // RVA: 0x7FFAC2F21320
        public void GetHashCodeOfString(){} // RVA: 0x7FFAC547DE90
        public void Init(){} // RVA: 0x7FFAC9226E90
        public void SetNamespace(){} // RVA: 0x7FFAC2F87E80
        public void Verify(){} // RVA: 0x7FFAC9226F50
        public void Atomize(){} // RVA: 0x7FFAC9226FF0
        public void Parse(){} // RVA: 0x7FFAC9227100
        public void Clone(){} // RVA: 0x7FFAC9227270
        public void .cctor(){} // RVA: 0x7FFAC92272F0
    }

    public class XmlRawWriter : XmlWriter
    {
        public System.Xml.XmlRawWriterBase64Encoder WriteState; // 0x18
        public System.Xml.IXmlNamespaceResolver NamespaceResolver; // 0x20

        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7FFAC91B7FE0 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFAC91B8040
        public void WriteDocType(){} // RVA: 0x7FFAC2F21310
        public void WriteEndElement(){} // RVA: 0x7FFAC2C7AF60 | overloaded x2
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91B8560 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC91B8160
        public void LookupPrefix(){} // RVA: 0x7FFAC91B82A0
        public void get_WriteState(){} // RVA: 0x7FFAC91B8300
        public void WriteCData(){} // RVA: 0x7FFAC91B6940
        public void WriteCharEntity(){} // RVA: 0x7FFAC91B8360
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91B83F0
        public void WriteWhitespace(){} // RVA: 0x7FFAC91B6940
        public void WriteChars(){} // RVA: 0x7FFAC3F35600
        public void WriteRaw(){} // RVA: 0x7FFAC91B6940 | overloaded x2
        public void WriteValue(){} // RVA: 0x7FFAC91B6940
        public void WriteAttributes(){} // RVA: 0x7FFAC91B84A0
        public void WriteNode(){} // RVA: 0x7FFAC91B8500
        public void set_NamespaceResolver(){} // RVA: 0x7FFAC2F4F0D0
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void StartElementContent(){} // RVA: 0x7FFAC2C70980
        public void OnRootElement(){} // RVA: 0x7FFAC2F21310
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFAC2C79B30
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFAC2F21320
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFAC91B8580
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFAC91B85C0
        public void WriteEndBase64(){} // RVA: 0x7FFAC91B8600
        public void Close(){} // RVA: 0x7FFAC8531220
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlRawWriterBase64Encoder : Base64Encoder
    {
        public System.Xml.XmlRawWriter rawWriter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC907FD00
        public void WriteChars(){} // RVA: 0x7FFAC907FD70
    }

    public class XmlReader : Object
    {
        public uint Settings;
        public uint NodeType; // 0x4
        public uint Name; // 0x8

        // ── Methods ──
        public void get_Settings(){} // RVA: 0x7FFAC34F9180
        public void get_NodeType(){} // RVA: 0x7FFAC2C59960
        public void get_Name(){} // RVA: 0x7FFAC91B8620
        public void get_LocalName(){} // RVA: 0x7FFAC2C58E90
        public void get_NamespaceURI(){} // RVA: 0x7FFAC2C58E90
        public void get_Prefix(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void get_Depth(){} // RVA: 0x7FFAC2C59960
        public void get_BaseURI(){} // RVA: 0x7FFAC2C58E90
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC2C59D00
        public void get_IsDefault(){} // RVA: 0x7FFAC2F21320
        public void get_QuoteChar(){} // RVA: 0x7FFAC91B8730
        public void get_XmlSpace(){} // RVA: 0x7FFAC34F9180
        public void get_XmlLang(){} // RVA: 0x7FFAC91B8740
        public void get_SchemaInfo(){} // RVA: 0x7FFAC91B8780
        public void get_ValueType(){} // RVA: 0x7FFAC91B87C0
        public void get_AttributeCount(){} // RVA: 0x7FFAC2C59960
        public void GetAttribute(){} // RVA: 0x7FFAC2C67DE0 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC91B8870 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC2C59D00
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC2C59D00
        public void MoveToElement(){} // RVA: 0x7FFAC2C59D00
        public void ReadAttributeValue(){} // RVA: 0x7FFAC2C59D00
        public void Read(){} // RVA: 0x7FFAC2C59D00
        public void get_EOF(){} // RVA: 0x7FFAC2C59D00
        public void Close(){} // RVA: 0x7FFAC2F21310
        public void get_ReadState(){} // RVA: 0x7FFAC2C59960
        public void Skip(){} // RVA: 0x7FFAC91B8940
        public void get_NameTable(){} // RVA: 0x7FFAC2C58E90
        public void LookupNamespace(){} // RVA: 0x7FFAC2C58F40
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC2F21320
        public void ResolveEntity(){} // RVA: 0x7FFAC2C70980
        public void get_CanReadValueChunk(){} // RVA: 0x7FFAC2F21320
        public void ReadValueChunk(){} // RVA: 0x7FFAC91B8A50
        public void ReadString(){} // RVA: 0x7FFAC91B8AB0
        public void MoveToContent(){} // RVA: 0x7FFAC91B8D20
        public void ReadStartElement(){} // RVA: 0x7FFAC91B8DC0
        public void ReadElementString(){} // RVA: 0x7FFAC91B8EC0
        public void ReadEndElement(){} // RVA: 0x7FFAC91B9170
        public void IsStartElement(){} // RVA: 0x7FFAC91B9270
        public void ReadInnerXml(){} // RVA: 0x7FFAC91B9370
        public void WriteNode(){} // RVA: 0x7FFAC91B97F0
        public void WriteAttributeValue(){} // RVA: 0x7FFAC91B9D50
        public void CreateWriterForInnerOuterXml(){} // RVA: 0x7FFAC91B9E70
        public void SetNamespacesFlag(){} // RVA: 0x7FFAC91B9FD0
        public void get_HasAttributes(){} // RVA: 0x7FFAC91BA0E0
        public void Dispose(){} // RVA: 0x7FFAC91BA130 | overloaded x2
        public void get_NamespaceManager(){} // RVA: 0x7FFAC34F9180
        public void IsTextualNode(){} // RVA: 0x7FFAC91BA170
        public void HasValueInternal(){} // RVA: 0x7FFAC91BA1E0
        public void SkipSubtree(){} // RVA: 0x7FFAC91BA250
        public void get_IsDefaultInternal(){} // RVA: 0x7FFAC91BA340
        public void get_DtdInfo(){} // RVA: 0x7FFAC34F9180
        public void Create(){} // RVA: 0x7FFAC91BA760 | overloaded x3
        public void CreateSqlReader(){} // RVA: 0x7FFAC91BA8E0
        public void CalcBufferSize(){} // RVA: 0x7FFAC91BAC20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC91BACC0
    }

    public class XmlReaderSettings : Object
    {
        public bool Async; // 0x10
        public System.Xml.XmlNameTable NameTable; // 0x18
        public System.Xml.XmlResolver IsXmlResolverSet; // 0x20
        public int XmlResolver; // 0x28
        public int LineNumberOffset; // 0x2C
        public 0x6B159398 LinePositionOffset; // 0x30
        public bool ConformanceLevel; // 0x34
        public long CheckCharacters; // 0x38
        public long MaxCharactersInDocument; // 0x40
        public bool MaxCharactersFromEntities; // 0x48
        public bool IgnoreWhitespace; // 0x49
        public bool IgnoreProcessingInstructions; // 0x4A
        public 0x6B1593F0 IgnoreComments; // 0x4C
        public 0x6B159FA0 DtdProcessing; // 0x50
        public 0x6B1653C0 CloseInput; // 0x54
        public System.Xml.Schema.XmlSchemaSet ValidationType; // 0x58
        public System.Xml.Schema.ValidationEventHandler ValidationFlags; // 0x60
        public bool Schemas; // 0x68
        public bool ReadOnly; // 0x69
        public bool <IsXmlResolverSet>k__BackingField; // 0x6A
        public System.Nullable`1<bool> s_enableLegacyXmlSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91BAD30
        public void get_Async(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Async(){} // RVA: 0x7FFAC91BAD40
        public void get_NameTable(){} // RVA: 0x7FFAC2F247C0
        public void set_NameTable(){} // RVA: 0x7FFAC91BADA0
        public void get_IsXmlResolverSet(){} // RVA: 0x7FFAC8290C80
        public void set_IsXmlResolverSet(){} // RVA: 0x7FFAC8290C90
        public void set_XmlResolver(){} // RVA: 0x7FFAC91BAE40
        public void GetXmlResolver(){} // RVA: 0x7FFAC2F4F0C0
        public void GetXmlResolver_CheckConfig(){} // RVA: 0x7FFAC91BAEE0
        public void get_LineNumberOffset(){} // RVA: 0x7FFAC32EC4C0
        public void set_LineNumberOffset(){} // RVA: 0x7FFAC91BAEF0
        public void get_LinePositionOffset(){} // RVA: 0x7FFAC3C891D0
        public void set_LinePositionOffset(){} // RVA: 0x7FFAC91BAF40
        public void get_ConformanceLevel(){} // RVA: 0x7FFAC2F7CCD0
        public void set_ConformanceLevel(){} // RVA: 0x7FFAC91BAF90
        public void get_CheckCharacters(){} // RVA: 0x7FFAC2F57C20
        public void set_CheckCharacters(){} // RVA: 0x7FFAC91BB030
        public void get_MaxCharactersInDocument(){} // RVA: 0x7FFAC31D0140
        public void set_MaxCharactersInDocument(){} // RVA: 0x7FFAC91BB090
        public void get_MaxCharactersFromEntities(){} // RVA: 0x7FFAC2F9E740
        public void set_MaxCharactersFromEntities(){} // RVA: 0x7FFAC91BB130
        public void get_IgnoreWhitespace(){} // RVA: 0x7FFAC2FD8D30
        public void set_IgnoreWhitespace(){} // RVA: 0x7FFAC91BB1D0
        public void get_IgnoreProcessingInstructions(){} // RVA: 0x7FFAC3E0F350
        public void set_IgnoreProcessingInstructions(){} // RVA: 0x7FFAC91BB230
        public void get_IgnoreComments(){} // RVA: 0x7FFAC41656F0
        public void set_IgnoreComments(){} // RVA: 0x7FFAC91BB290
        public void get_DtdProcessing(){} // RVA: 0x7FFAC3F2D3C0
        public void set_DtdProcessing(){} // RVA: 0x7FFAC91BB2F0
        public void get_CloseInput(){} // RVA: 0x7FFAC2FE9570
        public void set_CloseInput(){} // RVA: 0x7FFAC91BB390
        public void get_ValidationType(){} // RVA: 0x7FFAC30F10E0
        public void set_ValidationType(){} // RVA: 0x7FFAC91BB3F0
        public void get_ValidationFlags(){} // RVA: 0x7FFAC38913D0
        public void set_ValidationFlags(){} // RVA: 0x7FFAC91BB490
        public void get_Schemas(){} // RVA: 0x7FFAC91BB530
        public void set_Schemas(){} // RVA: 0x7FFAC91BB5E0
        public void Clone(){} // RVA: 0x7FFAC91BB680
        public void GetEventHandler(){} // RVA: 0x7FFAC2FBF370
        public void CreateReader(){} // RVA: 0x7FFAC91BB880 | overloaded x2
        public void set_ReadOnly(){} // RVA: 0x7FFAC466E010
        public void CheckReadOnly(){} // RVA: 0x7FFAC91BB9C0
        public void Initialize(){} // RVA: 0x7FFAC91BBA70 | overloaded x2
        public void CreateDefaultResolver(){} // RVA: 0x7FFAC91BBC90
        public void AddValidation(){} // RVA: 0x7FFAC91BBCD0
        public void CreateDtdValidatingReader(){} // RVA: 0x7FFAC91BBE00
        public void EnableLegacyXmlSettings(){} // RVA: 0x7FFAC91BBE90
    }

    public class XmlRegisteredNonCachedStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public System.Xml.XmlDownloadManager CanSeek; // 0x30
        public string CanWrite; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9220490
        public void Finalize(){} // RVA: 0x7FFAC92205F0
        public void Dispose(){} // RVA: 0x7FFAC92206A0
        public void BeginRead(){} // RVA: 0x7FFAC92207E0
        public void BeginWrite(){} // RVA: 0x7FFAC9220820
        public void EndRead(){} // RVA: 0x7FFAC9220860
        public void EndWrite(){} // RVA: 0x7FFAC8F824A0
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Read(){} // RVA: 0x7FFAC9220890
        public void ReadByte(){} // RVA: 0x7FFAC859F810
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
        public void Write(){} // RVA: 0x7FFAC92208F0
        public void WriteByte(){} // RVA: 0x7FFAC9220920
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
    }

    public class XmlResolver : Object
    {
        // ── Methods ──
        public void GetEntity(){} // RVA: 0x7FFAC2C6AE80
        public void ResolveUri(){} // RVA: 0x7FFAC9227460
        public void SupportsType(){} // RVA: 0x7FFAC9227700
        public void GetEntityAsync(){} // RVA: 0x7FFAC9227820
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSignificantWhitespace : XmlCharacterData
    {
        public object Name;
        public object LocalName;
        public object NodeType;
        public object ParentNode;
        public object Value;
        public object IsText;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9203E60
        public void get_Name(){} // RVA: 0x7FFAC9203F60
        public void get_LocalName(){} // RVA: 0x7FFAC9203F60
        public void get_NodeType(){} // RVA: 0x7FFAC4206550
        public void get_ParentNode(){} // RVA: 0x7FFAC9203F90
        public void CloneNode(){} // RVA: 0x7FFAC9204040
        public void get_Value(){} // RVA: 0x7FFAC86542D0
        public void set_Value(){} // RVA: 0x7FFAC92040B0
        public void WriteTo(){} // RVA: 0x7FFAC92041B0
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void get_IsText(){} // RVA: 0x7FFAC3006850
    }

    public class XmlSqlBinaryReader : XmlReader
    {
        public System.Type Settings;
        public System.Type NodeType; // 0x8
        public System.Type[] LocalName; // 0x10
        public byte[] NamespaceURI; // 0x18
        public 0x6B159D90[] Prefix; // 0x20
        public System.IO.Stream Value; // 0x10
        public byte[] Depth; // 0x18
        public int BaseURI; // 0x20
        public int IsEmptyElement; // 0x24
        public int XmlSpace; // 0x28
        public long XmlLang; // 0x30
        public bool ValueType; // 0x38
        public bool AttributeCount; // 0x39
        public bool EOF; // 0x3A
        public int NameTable; // 0x3C
        public SymbolTables ReadState; // 0x40
        public System.Xml.XmlNameTable xnt; // 0x60
        public bool xntFromSettings; // 0x68
        public string xml; // 0x70
        public string xmlns; // 0x78
        public string nsxmlns; // 0x80
        public string baseUri; // 0x88
        public 0x6B158F20 state; // 0x90
        public 0x6B15D5F0 nodetype; // 0x94
        public 0x6B158DC0 token; // 0x98
        public int attrIndex; // 0x9C
        public QName qnameOther; // 0xA0
        public QName qnameElement; // 0xB8
        public 0x6B15D5F0 parentNodeType; // 0xD0
        public ElemInfo[] elementStack; // 0xD8
        public int elemDepth; // 0xE0
        public AttrInfo[] attributes; // 0xE8
        public int[] attrHashTbl; // 0xF0
        public int attrCount; // 0xF8
        public int posAfterAttrs; // 0xFC
        public bool xmlspacePreserve; // 0x100
        public int tokLen; // 0x104
        public int tokDataPos; // 0x108
        public bool hasTypedValue; // 0x10C
        public System.Type valueType; // 0x110
        public string stringValue; // 0x118
        public System.Collections.Generic.Dictionary`2<string,NamespaceDecl> namespaces; // 0x120
        public NestedBinXml prevNameInfo; // 0x128
        public System.Xml.XmlReader textXmlReader; // 0x130
        public bool closeInput; // 0x138
        public bool checkCharacters; // 0x139
        public bool ignoreWhitespace; // 0x13A
        public bool ignorePIs; // 0x13B
        public bool ignoreComments; // 0x13C
        public 0x6B1593F0 dtdProcessing; // 0x140
        public System.Xml.SecureStringHasher hasher; // 0x148
        public System.Xml.XmlCharType xmlCharType; // 0x150
        public System.Text.Encoding unicode; // 0x158
        public byte version; // 0x160

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9085790
        public void get_Settings(){} // RVA: 0x7FFAC9086250
        public void get_NodeType(){} // RVA: 0x7FFAC3220670
        public void get_LocalName(){} // RVA: 0x7FFAC354B1A0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC2F8C040
        public void get_Prefix(){} // RVA: 0x7FFAC3543900
        public void get_Value(){} // RVA: 0x7FFAC90864F0
        public void get_Depth(){} // RVA: 0x7FFAC90867E0
        public void get_BaseURI(){} // RVA: 0x7FFAC2F60010
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC90868B0
        public void get_XmlSpace(){} // RVA: 0x7FFAC90868D0
        public void get_XmlLang(){} // RVA: 0x7FFAC9086950
        public void get_ValueType(){} // RVA: 0x7FFAC354B170
        public void get_AttributeCount(){} // RVA: 0x7FFAC9086A10
        public void GetAttribute(){} // RVA: 0x7FFAC9086CD0 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC9086E10 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC9086EC0
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC9086F50
        public void MoveToElement(){} // RVA: 0x7FFAC9087000
        public void get_EOF(){} // RVA: 0x7FFAC90871B0
        public void ReadAttributeValue(){} // RVA: 0x7FFAC90871C0
        public void Close(){} // RVA: 0x7FFAC9087400
        public void get_NameTable(){} // RVA: 0x7FFAC2FBF370
        public void LookupNamespace(){} // RVA: 0x7FFAC9087590
        public void ResolveEntity(){} // RVA: 0x7FFAC9087660
        public void get_ReadState(){} // RVA: 0x7FFAC90876A0
        public void Read(){} // RVA: 0x7FFAC9087720
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC90878A0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC9087D50
        public void VerifyVersion(){} // RVA: 0x7FFAC9087EC0
        public void AddInitNamespace(){} // RVA: 0x7FFAC9087F10
        public void AddName(){} // RVA: 0x7FFAC9088080
        public void AddQName(){} // RVA: 0x7FFAC90881D0
        public void NameFlush(){} // RVA: 0x7FFAC9088560
        public void SkipExtn(){} // RVA: 0x7FFAC90885C0
        public void ReadQNameRef(){} // RVA: 0x7FFAC90886F0
        public void ReadNameRef(){} // RVA: 0x7FFAC90887C0
        public void FillAllowEOF(){} // RVA: 0x7FFAC9088890
        public void Fill_(){} // RVA: 0x7FFAC9088AF0
        public void Fill(){} // RVA: 0x7FFAC9088B70
        public void ReadByte(){} // RVA: 0x7FFAC9088C00
        public void ReadUShort(){} // RVA: 0x7FFAC9088C50
        public void ParseMB32(){} // RVA: 0x7FFAC9088E70 | overloaded x2
        public void ParseMB32_(){} // RVA: 0x7FFAC9088D10
        public void ParseMB64(){} // RVA: 0x7FFAC9088CB0
        public void PeekToken(){} // RVA: 0x7FFAC9088F80
        public void ReadToken(){} // RVA: 0x7FFAC9089200
        public void NextToken2(){} // RVA: 0x7FFAC9089490
        public void NextToken1(){} // RVA: 0x7FFAC90897D0
        public void NextToken(){} // RVA: 0x7FFAC9089840
        public void PeekNextToken(){} // RVA: 0x7FFAC90898E0
        public void RescanNextToken(){} // RVA: 0x7FFAC9089900
        public void ParseText(){} // RVA: 0x7FFAC9089BC0
        public void ScanText(){} // RVA: 0x7FFAC9089C80
        public void GetString(){} // RVA: 0x7FFAC9089DE0
        public void GetStringAligned(){} // RVA: 0x7FFAC9089FB0
        public void GetAttributeText(){} // RVA: 0x7FFAC9089FF0
        public void LocateAttribute(){} // RVA: 0x7FFAC908A280 | overloaded x2
        public void PositionOnAttribute(){} // RVA: 0x7FFAC908A3E0
        public void GrowElements(){} // RVA: 0x7FFAC908A5D0
        public void GrowAttributes(){} // RVA: 0x7FFAC908A6D0
        public void ClearAttributes(){} // RVA: 0x7FFAC908A7B0
        public void PushNamespace(){} // RVA: 0x7FFAC908A7D0
        public void PopNamespaces(){} // RVA: 0x7FFAC908AB40
        public void GenerateImpliedXmlnsAttrs(){} // RVA: 0x7FFAC908AC40
        public void ReadInit(){} // RVA: 0x7FFAC908ADF0
        public void ScanAttributes(){} // RVA: 0x7FFAC908B430
        public void SimpleCheckForDuplicateAttributes(){} // RVA: 0x7FFAC908BB50
        public void HashCheckForDuplicateAttributes(){} // RVA: 0x7FFAC908BDF0
        public void XmlDeclValue(){} // RVA: 0x7FFAC908C290
        public void CDATAValue(){} // RVA: 0x7FFAC908C3F0
        public void FinishCDATA(){} // RVA: 0x7FFAC908C560
        public void FinishEndElement(){} // RVA: 0x7FFAC908C600
        public void ReadDoc(){} // RVA: 0x7FFAC908C780
        public void ImplReadData(){} // RVA: 0x7FFAC908CF90
        public void ImplReadElement(){} // RVA: 0x7FFAC908D1C0
        public void ImplReadEndElement(){} // RVA: 0x7FFAC908D7E0
        public void ImplReadDoctype(){} // RVA: 0x7FFAC908D910
        public void ImplReadPI(){} // RVA: 0x7FFAC908DD20
        public void ImplReadComment(){} // RVA: 0x7FFAC908DDE0
        public void ImplReadCDATA(){} // RVA: 0x7FFAC908DE20
        public void ImplReadNest(){} // RVA: 0x7FFAC908DEB0
        public void ImplReadEndNest(){} // RVA: 0x7FFAC908E0A0
        public void ImplReadXmlText(){} // RVA: 0x7FFAC908E190
        public void UpdateFromTextReader(){} // RVA: 0x7FFAC908EB00 | overloaded x2
        public void CheckAllowContent(){} // RVA: 0x7FFAC908EB20
        public void GenerateTokenTypeMap(){} // RVA: 0x7FFAC908EB80
        public void GetValueType(){} // RVA: 0x7FFAC908FF60
        public void ReScanOverValue(){} // RVA: 0x7FFAC9090050
        public void ScanOverValue(){} // RVA: 0x7FFAC9090070
        public void ScanOverAnyValue(){} // RVA: 0x7FFAC9090290
        public void CheckText(){} // RVA: 0x7FFAC9090910
        public void CheckTextIsWS(){} // RVA: 0x7FFAC9090B60
        public void CheckValueTokenBounds(){} // RVA: 0x7FFAC9090BF0
        public void GetXsdKatmaiTokenLength(){} // RVA: 0x7FFAC9090C50
        public void XsdKatmaiTimeScaleToValueLength(){} // RVA: 0x7FFAC9090DB0
        public void ValueAsLong(){} // RVA: 0x7FFAC9090E80
        public void ValueAsULong(){} // RVA: 0x7FFAC9091400
        public void ValueAsDecimal(){} // RVA: 0x7FFAC90914A0
        public void ValueAsDouble(){} // RVA: 0x7FFAC90917C0
        public void ValueAsDateTimeString(){} // RVA: 0x7FFAC90919C0
        public void ValueAsString(){} // RVA: 0x7FFAC9091FD0
        public void GetInt16(){} // RVA: 0x7FFAC9092950
        public void GetUInt16(){} // RVA: 0x7FFAC9092950
        public void GetInt32(){} // RVA: 0x7FFAC90929A0
        public void GetUInt32(){} // RVA: 0x7FFAC90929A0
        public void GetInt64(){} // RVA: 0x7FFAC9092A20
        public void GetUInt64(){} // RVA: 0x7FFAC9092A20
        public void GetSingle(){} // RVA: 0x7FFAC9092B40
        public void GetDouble(){} // RVA: 0x7FFAC9092BC0
        public void ThrowUnexpectedToken(){} // RVA: 0x7FFAC9092CF0
        public void ThrowXmlException(){} // RVA: 0x7FFAC9092DC0 | overloaded x2
        public void ThrowNotSupported(){} // RVA: 0x7FFAC9092EB0
        public void .cctor(){} // RVA: 0x7FFAC9092F20
    }

    public class XmlText : XmlCharacterData
    {
        public object Name;
        public object LocalName;
        public object NodeType;
        public object ParentNode;
        public object Value;
        public object IsText;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E5A80 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC9204210
        public void get_LocalName(){} // RVA: 0x7FFAC9204210
        public void get_NodeType(){} // RVA: 0x7FFAC366FE20
        public void get_ParentNode(){} // RVA: 0x7FFAC91E5AC0
        public void CloneNode(){} // RVA: 0x7FFAC9204240
        public void get_Value(){} // RVA: 0x7FFAC86542D0
        public void set_Value(){} // RVA: 0x7FFAC92042B0
        public void WriteTo(){} // RVA: 0x7FFAC92041B0
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void get_IsText(){} // RVA: 0x7FFAC3006850
    }

    public class XmlTextEncoder : Object
    {
        public System.IO.TextWriter QuoteChar; // 0x10
        public bool AttributeValue; // 0x18
        public char quoteChar; // 0x1A
        public System.Text.StringBuilder attrValue; // 0x20
        public bool cacheAttrValue; // 0x28
        public System.Xml.XmlCharType xmlCharType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91BBF40
        public void set_QuoteChar(){} // RVA: 0x7FFAC82534C0
        public void StartAttribute(){} // RVA: 0x7FFAC91BC020
        public void EndAttribute(){} // RVA: 0x7FFAC91BC0F0
        public void get_AttributeValue(){} // RVA: 0x7FFAC91BC130
        public void WriteSurrogateChar(){} // RVA: 0x7FFAC91BC1A0
        public void Write(){} // RVA: 0x7FFAC91BC9C0 | overloaded x2
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91BC780
        public void WriteRawWithSurrogateChecking(){} // RVA: 0x7FFAC91BCF50
        public void WriteRaw(){} // RVA: 0x7FFAC91BD1A0
        public void WriteCharEntity(){} // RVA: 0x7FFAC91BD360
        public void WriteEntityRef(){} // RVA: 0x7FFAC91BD550
        public void WriteStringFragment(){} // RVA: 0x7FFAC91BD5D0
        public void WriteCharEntityImpl(){} // RVA: 0x7FFAC91BD790 | overloaded x2
        public void WriteEntityRefImpl(){} // RVA: 0x7FFAC91BD840
    }

    public class XmlTextReader : XmlReader
    {
        public System.Xml.XmlTextReaderImpl NodeType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91BDDC0 | overloaded x4
        public void get_NodeType(){} // RVA: 0x7FFAC880FE40
        public void get_Name(){} // RVA: 0x7FFAC88045A0
        public void get_LocalName(){} // RVA: 0x7FFAC33088E0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC84AA500
        public void get_Prefix(){} // RVA: 0x7FFAC84AA530
        public void get_Value(){} // RVA: 0x7FFAC4426B30
        public void get_Depth(){} // RVA: 0x7FFAC8D71650
        public void get_BaseURI(){} // RVA: 0x7FFAC8D71620
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC8D711F0
        public void get_IsDefault(){} // RVA: 0x7FFAC8D71270
        public void get_QuoteChar(){} // RVA: 0x7FFAC84AA3A0
        public void get_XmlSpace(){} // RVA: 0x7FFAC84AA770
        public void get_XmlLang(){} // RVA: 0x7FFAC84AA5F0
        public void get_AttributeCount(){} // RVA: 0x7FFAC8B8D5F0
        public void GetAttribute(){} // RVA: 0x7FFAC8F0AC50 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC8F0ACB0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC84AA740
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC8599520
        public void MoveToElement(){} // RVA: 0x7FFAC8599550
        public void ReadAttributeValue(){} // RVA: 0x7FFAC8803C70
        public void Read(){} // RVA: 0x7FFAC32F0BD0
        public void get_EOF(){} // RVA: 0x7FFAC8F0ACE0
        public void Close(){} // RVA: 0x7FFAC8804760
        public void get_ReadState(){} // RVA: 0x7FFAC8F0AD10
        public void Skip(){} // RVA: 0x7FFAC83D00F0
        public void get_NameTable(){} // RVA: 0x7FFAC88037A0
        public void LookupNamespace(){} // RVA: 0x7FFAC91BDF60
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC3006850
        public void ResolveEntity(){} // RVA: 0x7FFAC8F0ADA0
        public void get_CanReadValueChunk(){} // RVA: 0x7FFAC2F21320
        public void ReadString(){} // RVA: 0x7FFAC91BDFA0
        public void HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void get_LineNumber(){} // RVA: 0x7FFAC91BDFD0
        public void get_LinePosition(){} // RVA: 0x7FFAC91BE000
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC91BE030
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC8F0AD40
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC91BE070
        public void get_Namespaces(){} // RVA: 0x7FFAC91BE0B0
        public void get_Normalization(){} // RVA: 0x7FFAC91BE0D0
        public void set_Normalization(){} // RVA: 0x7FFAC91BE0F0
        public void set_WhitespaceHandling(){} // RVA: 0x7FFAC91BE1D0
        public void set_EntityHandling(){} // RVA: 0x7FFAC91BE2D0
        public void set_XmlResolver(){} // RVA: 0x7FFAC91BE370
        public void get_Impl(){} // RVA: 0x7FFAC2F3C380
        public void get_NamespaceManager(){} // RVA: 0x7FFAC91BE390
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7FFAC91BE3C0
        public void get_DtdInfo(){} // RVA: 0x7FFAC91BE3E0
    }

    public class XmlTextReaderImpl : XmlReader
    {
        public bool Settings; // 0x10
        public LaterInitParam NodeType; // 0x18
        public System.Xml.XmlCharType Name; // 0x20
        public ParsingState LocalName; // 0x28
        public 0x6B15A6D8 NamespaceURI; // 0xA0
        public 0x6B15A6D8 Prefix; // 0xA4
        public 0x6B15A6D8 Value; // 0xA8
        public NodeData[] Depth; // 0xB0
        public NodeData BaseURI; // 0xB8
        public int IsEmptyElement; // 0xC0
        public int IsDefault; // 0xC4
        public int QuoteChar; // 0xC8
        public int XmlSpace; // 0xCC
        public int XmlLang; // 0xD0
        public bool ReadState; // 0xD4
        public bool EOF; // 0xD5
        public NodeData[] NameTable; // 0xD8
        public System.Xml.XmlNameTable CanResolveEntity; // 0xE0
        public bool AttributeCount; // 0xE8
        public System.Xml.XmlResolver OuterReader; // 0xF0
        public string CanReadValueChunk; // 0xF8
        public bool LineNumber; // 0x100
        public bool LinePosition; // 0x101
        public 0x6B159FF8 Namespaces; // 0x104
        public 0x6B1593F0 Normalization; // 0x108
        public 0x6B159448 WhitespaceHandling; // 0x10C
        public bool EntityHandling; // 0x110
        public bool IsResolverSet; // 0x111
        public bool XmlResolver; // 0x112
        public int DtdParserProxy_NameTable; // 0x114
        public int DtdParserProxy_NamespaceResolver; // 0x118
        public bool DtdParserProxy_DtdValidation; // 0x11C
        public long DtdParserProxy_Normalization; // 0x120
        public long DtdParserProxy_Namespaces; // 0x128
        public bool DtdParserProxy_V1CompatibilityMode; // 0x130
        public System.Xml.XmlNamespaceManager DtdParserProxy_BaseUri; // 0x138
        public string DtdParserProxy_IsEof; // 0x140
        public XmlContext DtdParserProxy_ParsingBuffer; // 0x148
        public ParsingState[] DtdParserProxy_ParsingBufferLength; // 0x150
        public int DtdParserProxy_CurrentPosition; // 0x158
        public string DtdParserProxy_EntityStackLength; // 0x160
        public System.Text.Encoding DtdParserProxy_IsEntityEolNormalized; // 0x168
        public System.Xml.IDtdInfo DtdParserProxy_ValidationEventHandling; // 0x170
        public 0x6B15D5F0 DtdParserProxy_LineNo; // 0x178
        public System.Xml.XmlParserContext DtdParserProxy_LineStartPosition; // 0x180
        public bool IsResolverNull; // 0x188
        public System.Xml.IncrementalReadDecoder InAttributeValueIterator; // 0x190
        public 0x6B15A838 DtdValidation; // 0x198
        public System.Xml.LineInfo InEntity; // 0x19C
        public int DtdInfo; // 0x1A4
        public int ValidationEventHandling; // 0x1A8
        public int OnDefaultAttributeUse; // 0x1AC
        public int XmlValidatingReaderCompatibilityMode; // 0x1B0
        public bool FragmentType; // 0x1B4
        public System.Xml.IValidationEventHandling InternalSchemaType; // 0x1B8
        public OnDefaultAttributeUseDelegate InternalTypedValue; // 0x1C0
        public bool StandAlone; // 0x1C8
        public bool NamespaceManager; // 0x1C9
        public System.Text.StringBuilder V1Compat; // 0x1D0
        public bool DisableUndeclaredEntityCheck; // 0x1D8
        public bool standalone; // 0x1D9
        public int nextEntityId; // 0x1DC
        public 0x6B15A730 parsingMode; // 0x1E0
        public 0x6B159D90 readState; // 0x1E4
        public System.Xml.IDtdEntityInfo lastEntity; // 0x1E8
        public bool afterResetState; // 0x1F0
        public int documentStartBytePos; // 0x1F4
        public int readValueOffset; // 0x1F8
        public long charactersInDocument; // 0x200
        public long charactersFromEntities; // 0x208
        public System.Collections.Generic.Dictionary`2<System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo> currentEntities; // 0x210
        public bool disableUndeclaredEntityCheck; // 0x218
        public System.Xml.XmlReader outerReader; // 0x220
        public bool xmlResolverIsSet; // 0x228
        public string Xml; // 0x230
        public string XmlNs; // 0x238
        public System.Threading.Tasks.Task`1<System.Tuple`4<int,int,int,bool>> parseText_dummyTask; // 0x240

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90AAE50 | overloaded x12
        public void FinishInitUriString(){} // RVA: 0x7FFAC90AA010
        public void FinishInitStream(){} // RVA: 0x7FFAC90AA940
        public void FinishInitTextReader(){} // RVA: 0x7FFAC90AAD10
        public void get_Settings(){} // RVA: 0x7FFAC90AAFB0
        public void get_NodeType(){} // RVA: 0x7FFAC90AB370
        public void get_Name(){} // RVA: 0x7FFAC90AB390
        public void get_LocalName(){} // RVA: 0x7FFAC90AB3C0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC90AB3E0
        public void get_Prefix(){} // RVA: 0x7FFAC90AB400
        public void get_Value(){} // RVA: 0x7FFAC90AB420
        public void get_Depth(){} // RVA: 0x7FFAC90AB5A0
        public void get_BaseURI(){} // RVA: 0x7FFAC33A98A0
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC90AB5C0
        public void get_IsDefault(){} // RVA: 0x7FFAC90AB5F0
        public void get_QuoteChar(){} // RVA: 0x7FFAC90AB620
        public void get_XmlSpace(){} // RVA: 0x7FFAC90AB650
        public void get_XmlLang(){} // RVA: 0x7FFAC90AB670
        public void get_ReadState(){} // RVA: 0x7FFAC90AB690
        public void get_EOF(){} // RVA: 0x7FFAC90AB6A0
        public void get_NameTable(){} // RVA: 0x7FFAC2FA2900
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC3006850
        public void get_AttributeCount(){} // RVA: 0x7FFAC3641480
        public void GetAttribute(){} // RVA: 0x7FFAC90AB890 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC90ABA50 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC90ABB80
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC90ABC40
        public void MoveToElement(){} // RVA: 0x7FFAC90ABD20
        public void FinishInit(){} // RVA: 0x7FFAC90ABDF0
        public void Read(){} // RVA: 0x7FFAC90ABE40
        public void Close(){} // RVA: 0x7FFAC90B2790 | overloaded x2
        public void Skip(){} // RVA: 0x7FFAC90AC700
        public void LookupNamespace(){} // RVA: 0x7FFAC90BF9E0 | overloaded x2
        public void ReadAttributeValue(){} // RVA: 0x7FFAC90AC960
        public void ResolveEntity(){} // RVA: 0x7FFAC90ACC90
        public void set_OuterReader(){} // RVA: 0x7FFAC354AC80
        public void MoveOffEntityReference(){} // RVA: 0x7FFAC90ACF40
        public void ReadString(){} // RVA: 0x7FFAC90AD010
        public void get_CanReadValueChunk(){} // RVA: 0x7FFAC3006850
        public void ReadValueChunk(){} // RVA: 0x7FFAC90AD030
        public void HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void get_LineNumber(){} // RVA: 0x7FFAC90AD600
        public void get_LinePosition(){} // RVA: 0x7FFAC90AD620
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC90AD640
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC8E4D8A0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC90AD670
        public void GetNamespacesInScope(){} // RVA: 0x7FFAC90AD640
        public void LookupPrefix(){} // RVA: 0x7FFAC90AD670
        public void get_Namespaces(){} // RVA: 0x7FFAC45CA040
        public void set_Namespaces(){} // RVA: 0x7FFAC90AD6A0
        public void get_Normalization(){} // RVA: 0x7FFAC3C8B9C0
        public void set_Normalization(){} // RVA: 0x7FFAC90AD9A0
        public void set_WhitespaceHandling(){} // RVA: 0x7FFAC90ADA80
        public void set_EntityHandling(){} // RVA: 0x7FFAC90ADB70
        public void get_IsResolverSet(){} // RVA: 0x7FFAC90ADC00
        public void set_XmlResolver(){} // RVA: 0x7FFAC90ADC10
        public void get_DtdParserProxy_NameTable(){} // RVA: 0x7FFAC2FA2900
        public void get_DtdParserProxy_NamespaceResolver(){} // RVA: 0x7FFAC35422C0
        public void get_DtdParserProxy_DtdValidation(){} // RVA: 0x7FFAC90ADDA0
        public void get_DtdParserProxy_Normalization(){} // RVA: 0x7FFAC3C8B9C0
        public void get_DtdParserProxy_Namespaces(){} // RVA: 0x7FFAC45CA040
        public void get_DtdParserProxy_V1CompatibilityMode(){} // RVA: 0x7FFAC90ADDB0
        public void get_DtdParserProxy_BaseUri(){} // RVA: 0x7FFAC90ADDC0
        public void get_DtdParserProxy_IsEof(){} // RVA: 0x7FFAC3E003A0
        public void get_DtdParserProxy_ParsingBuffer(){} // RVA: 0x7FFAC2F4F130
        public void get_DtdParserProxy_ParsingBufferLength(){} // RVA: 0x7FFAC3ADEDC0
        public void get_DtdParserProxy_CurrentPosition(){} // RVA: 0x7FFAC2F7CCD0
        public void set_DtdParserProxy_CurrentPosition(){} // RVA: 0x7FFAC2F7CCE0
        public void get_DtdParserProxy_EntityStackLength(){} // RVA: 0x7FFAC90ADE80
        public void get_DtdParserProxy_IsEntityEolNormalized(){} // RVA: 0x7FFAC8B10330
        public void get_DtdParserProxy_ValidationEventHandling(){} // RVA: 0x7FFAC3544330
        public void DtdParserProxy_OnNewLine(){} // RVA: 0x7FFAC90ADE90
        public void get_DtdParserProxy_LineNo(){} // RVA: 0x7FFAC3B99E80
        public void get_DtdParserProxy_LineStartPosition(){} // RVA: 0x7FFAC43D9E20
        public void DtdParserProxy_ReadData(){} // RVA: 0x7FFAC90ADEA0
        public void DtdParserProxy_ParseNumericCharRef(){} // RVA: 0x7FFAC90ADEB0
        public void DtdParserProxy_ParseNamedCharRef(){} // RVA: 0x7FFAC90ADF60
        public void DtdParserProxy_ParsePI(){} // RVA: 0x7FFAC90ADF70
        public void DtdParserProxy_ParseComment(){} // RVA: 0x7FFAC90ADFC0
        public void get_IsResolverNull(){} // RVA: 0x7FFAC90AE7D0
        public void GetTempResolver(){} // RVA: 0x7FFAC90AE7E0
        public void DtdParserProxy_PushEntity(){} // RVA: 0x7FFAC90AE840
        public void DtdParserProxy_PopEntity(){} // RVA: 0x7FFAC90AE900
        public void DtdParserProxy_PushExternalSubset(){} // RVA: 0x7FFAC90AE9F0
        public void DtdParserProxy_PushInternalDtd(){} // RVA: 0x7FFAC90AEB90
        public void DtdParserProxy_Throw(){} // RVA: 0x7FFAC90AEC70
        public void DtdParserProxy_OnSystemId(){} // RVA: 0x7FFAC90AEC80
        public void DtdParserProxy_OnPublicId(){} // RVA: 0x7FFAC90AED60
        public void Throw(){} // RVA: 0x7FFAC90AF2F0 | overloaded x11
        public void ReThrow(){} // RVA: 0x7FFAC90AF390
        public void ThrowWithoutLineInfo(){} // RVA: 0x7FFAC90AF550 | overloaded x3
        public void ThrowInvalidChar(){} // RVA: 0x7FFAC90AF5E0
        public void SetErrorState(){} // RVA: 0x7FFAC90AF650
        public void SendValidationEvent(){} // RVA: 0x7FFAC90AF760 | overloaded x2
        public void get_InAttributeValueIterator(){} // RVA: 0x7FFAC90AF7D0
        public void FinishAttributeValueIterator(){} // RVA: 0x7FFAC90AF7F0
        public void get_DtdValidation(){} // RVA: 0x7FFAC90ADDA0
        public void InitStreamInput(){} // RVA: 0x7FFAC90AFA10 | overloaded x5
        public void InitTextReaderInput(){} // RVA: 0x7FFAC90B00D0 | overloaded x2
        public void InitStringInput(){} // RVA: 0x7FFAC90B0330
        public void InitFragmentReader(){} // RVA: 0x7FFAC90B0570
        public void ProcessDtdFromParserContext(){} // RVA: 0x7FFAC90B0B60
        public void OpenUrl(){} // RVA: 0x7FFAC90B0BD0
        public void OpenUrlDelegate(){} // RVA: 0x7FFAC90B0E70
        public void DetectEncoding(){} // RVA: 0x7FFAC90B10A0
        public void SetupEncoding(){} // RVA: 0x7FFAC90B12D0
        public void SwitchEncoding(){} // RVA: 0x7FFAC90B15E0
        public void CheckEncoding(){} // RVA: 0x7FFAC90B17A0
        public void UnDecodeChars(){} // RVA: 0x7FFAC90B1E70
        public void SwitchEncodingToUTF8(){} // RVA: 0x7FFAC90B1F20
        public void ReadData(){} // RVA: 0x7FFAC90B1FC0
        public void GetChars(){} // RVA: 0x7FFAC90B2560
        public void InvalidCharRecovery(){} // RVA: 0x7FFAC90B2640
        public void ShiftBuffer(){} // RVA: 0x7FFAC90B2AE0
        public void ParseXmlDeclaration(){} // RVA: 0x7FFAC90B2B10
        public void ParseDocumentContent(){} // RVA: 0x7FFAC90B3F60
        public void ParseElementContent(){} // RVA: 0x7FFAC90B4590
        public void ThrowUnclosedElements(){} // RVA: 0x7FFAC90B49C0
        public void ParseElement(){} // RVA: 0x7FFAC90B4BB0
        public void AddDefaultAttributesAndNormalize(){} // RVA: 0x7FFAC90B51C0
        public void ParseEndElement(){} // RVA: 0x7FFAC90B5860
        public void ThrowTagMismatch(){} // RVA: 0x7FFAC90B5D70
        public void ParseAttributes(){} // RVA: 0x7FFAC90B5F50
        public void ElementNamespaceLookup(){} // RVA: 0x7FFAC90B6520
        public void AttributeNamespaceLookup(){} // RVA: 0x7FFAC90B6650
        public void AttributeDuplCheck(){} // RVA: 0x7FFAC90B6700
        public void OnDefaultNamespaceDecl(){} // RVA: 0x7FFAC90B6B00
        public void OnNamespaceDecl(){} // RVA: 0x7FFAC90B6CF0
        public void OnXmlReservedAttribute(){} // RVA: 0x7FFAC90B6DE0
        public void ParseAttributeValueSlow(){} // RVA: 0x7FFAC90B7100
        public void AddAttributeChunkToList(){} // RVA: 0x7FFAC90B8410
        public void ParseText(){} // RVA: 0x7FFAC90B89F0 | overloaded x2
        public void FinishPartialValue(){} // RVA: 0x7FFAC90B90E0
        public void FinishOtherValueIterator(){} // RVA: 0x7FFAC90B9630
        public void SkipPartialTextValue(){} // RVA: 0x7FFAC90B9780
        public void FinishReadValueChunk(){} // RVA: 0x7FFAC90B97E0
        public void FinishReadContentAsBinary(){} // RVA: 0x7FFAC90B9820
        public void FinishReadElementContentAsBinary(){} // RVA: 0x7FFAC90B9980
        public void ParseRootLevelWhitespace(){} // RVA: 0x7FFAC90B9A50
        public void ParseEntityReference(){} // RVA: 0x7FFAC90B9C80
        public void HandleEntityReference(){} // RVA: 0x7FFAC90B9D30
        public void HandleGeneralEntityReference(){} // RVA: 0x7FFAC90B9FC0
        public void get_InEntity(){} // RVA: 0x7FFAC90BA410
        public void HandleEntityEnd(){} // RVA: 0x7FFAC90BA420
        public void SetupEndEntityNodeInContent(){} // RVA: 0x7FFAC90BA6B0
        public void SetupEndEntityNodeInAttribute(){} // RVA: 0x7FFAC90BA8F0
        public void ParsePI(){} // RVA: 0x7FFAC90BA9D0 | overloaded x2
        public void ParsePIValue(){} // RVA: 0x7FFAC90BB1F0
        public void ParseComment(){} // RVA: 0x7FFAC90BB570
        public void ParseCData(){} // RVA: 0x7FFAC90BBB10
        public void ParseCDataOrComment(){} // RVA: 0x7FFAC90BC040 | overloaded x2
        public void ParseDoctypeDecl(){} // RVA: 0x7FFAC90BC480
        public void ParseDtd(){} // RVA: 0x7FFAC90BC7D0
        public void SkipDtd(){} // RVA: 0x7FFAC90BCB30
        public void SkipPublicOrSystemIdLiteral(){} // RVA: 0x7FFAC90BD530
        public void SkipUntil(){} // RVA: 0x7FFAC90BD5D0
        public void EatWhitespaces(){} // RVA: 0x7FFAC90BDA70
        public void ParseCharRefInline(){} // RVA: 0x7FFAC90BDCB0
        public void ParseNumericCharRef(){} // RVA: 0x7FFAC90BDD30
        public void ParseNumericCharRefInline(){} // RVA: 0x7FFAC90BDE00
        public void ParseNamedCharRef(){} // RVA: 0x7FFAC90BE5F0
        public void ParseNamedCharRefInline(){} // RVA: 0x7FFAC90BE920
        public void ParseName(){} // RVA: 0x7FFAC90BEC30
        public void ParseQName(){} // RVA: 0x7FFAC90BEC80 | overloaded x2
        public void ReadDataInName(){} // RVA: 0x7FFAC90BEF20
        public void ParseEntityName(){} // RVA: 0x7FFAC90BEF60
        public void AddNode(){} // RVA: 0x7FFAC90BF060
        public void AllocNode(){} // RVA: 0x7FFAC90BF0B0
        public void AddAttributeNoChecks(){} // RVA: 0x7FFAC90BF270
        public void AddAttribute(){} // RVA: 0x7FFAC90BF650 | overloaded x2
        public void PopElementContext(){} // RVA: 0x7FFAC90BF7E0
        public void OnNewLine(){} // RVA: 0x7FFAC90ADE90
        public void OnEof(){} // RVA: 0x7FFAC90BF8A0
        public void AddNamespace(){} // RVA: 0x7FFAC90BFAC0
        public void ResetAttributes(){} // RVA: 0x7FFAC90BFD80
        public void FullAttributeCleanup(){} // RVA: 0x7FFAC90BFE90
        public void PushXmlContext(){} // RVA: 0x7FFAC90BFF70
        public void PopXmlContext(){} // RVA: 0x7FFAC90C0130
        public void GetWhitespaceType(){} // RVA: 0x7FFAC90C01C0
        public void GetTextNodeType(){} // RVA: 0x7FFAC90C0210
        public void PushExternalEntityOrSubset(){} // RVA: 0x7FFAC90C0270
        public void OpenAndPush(){} // RVA: 0x7FFAC90C05D0
        public void PushExternalEntity(){} // RVA: 0x7FFAC90C08E0
        public void PushInternalEntity(){} // RVA: 0x7FFAC90C0AE0
        public void PopEntity(){} // RVA: 0x7FFAC90C0C60
        public void RegisterEntity(){} // RVA: 0x7FFAC90C0D00
        public void UnregisterEntity(){} // RVA: 0x7FFAC90C1010
        public void PushParsingState(){} // RVA: 0x7FFAC90C1080
        public void PopParsingState(){} // RVA: 0x7FFAC90C1300
        public void IncrementalRead(){} // RVA: 0x7FFAC90C1440
        public void FinishIncrementalRead(){} // RVA: 0x7FFAC90C2140
        public void ParseFragmentAttribute(){} // RVA: 0x7FFAC90C2250
        public void ParseAttributeValueChunk(){} // RVA: 0x7FFAC90C22F0
        public void ParseXmlDeclarationFragment(){} // RVA: 0x7FFAC90C2A80
        public void ThrowUnexpectedToken(){} // RVA: 0x7FFAC90C2B60 | overloaded x4
        public void ParseUnexpectedToken(){} // RVA: 0x7FFAC90C2CE0 | overloaded x2
        public void ThrowExpectingWhitespace(){} // RVA: 0x7FFAC90C2DB0
        public void GetIndexOfAttributeWithoutPrefix(){} // RVA: 0x7FFAC90C2E40
        public void GetIndexOfAttributeWithPrefix(){} // RVA: 0x7FFAC90C2F00
        public void ZeroEndingStream(){} // RVA: 0x7FFAC90C2FE0
        public void ParseDtdFromParserContext(){} // RVA: 0x7FFAC90C3050
        public void MoveToNextContentNode(){} // RVA: 0x7FFAC90C32B0
        public void SetupFromParserContext(){} // RVA: 0x7FFAC90C33C0
        public void get_DtdInfo(){} // RVA: 0x7FFAC336D850
        public void SetDtdInfo(){} // RVA: 0x7FFAC90C37E0
        public void set_ValidationEventHandling(){} // RVA: 0x7FFAC39AC050
        public void set_OnDefaultAttributeUse(){} // RVA: 0x7FFAC39AD110
        public void set_XmlValidatingReaderCompatibilityMode(){} // RVA: 0x7FFAC90C38E0
        public void get_FragmentType(){} // RVA: 0x7FFAC33B23A0
        public void ChangeCurrentNodeType(){} // RVA: 0x7FFAC90C39D0
        public void GetResolver(){} // RVA: 0x7FFAC90C39F0
        public void set_InternalSchemaType(){} // RVA: 0x7FFAC90C3A10
        public void get_InternalTypedValue(){} // RVA: 0x7FFAC90C3A80
        public void set_InternalTypedValue(){} // RVA: 0x7FFAC90C3AB0
        public void get_StandAlone(){} // RVA: 0x7FFAC47C4290
        public void get_NamespaceManager(){} // RVA: 0x7FFAC35422C0
        public void get_V1Compat(){} // RVA: 0x7FFAC90ADDB0
        public void AddDefaultAttributeDtd(){} // RVA: 0x7FFAC90C3B20
        public void AddDefaultAttributeNonDtd(){} // RVA: 0x7FFAC90C3EC0
        public void AddDefaultAttributeInternal(){} // RVA: 0x7FFAC90C4270
        public void set_DisableUndeclaredEntityCheck(){} // RVA: 0x7FFAC90C45C0
        public void UriEqual(){} // RVA: 0x7FFAC90C45D0
        public void RegisterConsumedCharacters(){} // RVA: 0x7FFAC90C46E0
        public void StripSpaces(){} // RVA: 0x7FFAC90C4A70 | overloaded x2
        public void BlockCopyChars(){} // RVA: 0x7FFAC8707310
        public void BlockCopy(){} // RVA: 0x7FFAC90C4B90
    }

    public class XmlTextWriter : XmlWriter
    {
        public System.IO.TextWriter BaseStream; // 0x18
        public System.Xml.XmlTextEncoder Namespaces; // 0x20
        public System.Text.Encoding Formatting; // 0x28
        public 0x6B15AC00 QuoteChar; // 0x30
        public bool WriteState; // 0x34
        public int indentation; // 0x38
        public char indentChar; // 0x3C
        public TagInfo[] stack; // 0x40
        public int top; // 0x48
        public 0x6B15ADB8[] stateTable; // 0x50
        public 0x6B15ADB8 currentState; // 0x58
        public 0x6B15AE10 lastToken; // 0x5C
        public System.Xml.XmlTextWriterBase64Encoder base64Encoder; // 0x60
        public char quoteChar; // 0x68
        public char curQuoteChar; // 0x6A
        public bool namespaces; // 0x6C
        public 0x6B15AD60 specialAttr; // 0x70
        public string prefixForXmlNs; // 0x78
        public bool flush; // 0x80
        public Namespace[] nsStack; // 0x88
        public int nsTop; // 0x90
        public System.Collections.Generic.Dictionary`2<string,int> nsHashtable; // 0x98
        public bool useNsHashtable; // 0xA0
        public System.Xml.XmlCharType xmlCharType; // 0xA8
        public string[] stateName;
        public string[] tokenName; // 0x8
        public 0x6B15ADB8[] stateTableDefault; // 0x10
        public 0x6B15ADB8[] stateTableDocument; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91C1040 | overloaded x4
        public void get_BaseStream(){} // RVA: 0x7FFAC91C1200
        public void set_Namespaces(){} // RVA: 0x7FFAC91C12A0
        public void set_Formatting(){} // RVA: 0x7FFAC91C1320
        public void set_QuoteChar(){} // RVA: 0x7FFAC91C1330
        public void WriteStartDocument(){} // RVA: 0x7FFAC91C13E0 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFAC91C1400
        public void WriteDocType(){} // RVA: 0x7FFAC91C15F0
        public void WriteStartElement(){} // RVA: 0x7FFAC91C1A00
        public void WriteEndElement(){} // RVA: 0x7FFAC91C1FB0
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91C1FC0
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91C1FD0
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91C27C0
        public void WriteCData(){} // RVA: 0x7FFAC91C2810
        public void WriteComment(){} // RVA: 0x7FFAC91C2B50
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91C2EC0
        public void WriteEntityRef(){} // RVA: 0x7FFAC91C32C0
        public void WriteCharEntity(){} // RVA: 0x7FFAC91C33A0
        public void WriteWhitespace(){} // RVA: 0x7FFAC91C3410
        public void WriteString(){} // RVA: 0x7FFAC91C3580
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91C3600
        public void WriteChars(){} // RVA: 0x7FFAC91C3690
        public void WriteRaw(){} // RVA: 0x7FFAC91C37D0 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC91C3840
        public void WriteBinHex(){} // RVA: 0x7FFAC91C39F0
        public void get_WriteState(){} // RVA: 0x7FFAC91C3A80
        public void Close(){} // RVA: 0x7FFAC91C3AF0
        public void Flush(){} // RVA: 0x7FFAC91C3C00
        public void LookupPrefix(){} // RVA: 0x7FFAC91C3C30
        public void StartDocument(){} // RVA: 0x7FFAC91C3D70
        public void AutoComplete(){} // RVA: 0x7FFAC91C4110
        public void AutoCompleteAll(){} // RVA: 0x7FFAC91C4730
        public void InternalWriteEndElement(){} // RVA: 0x7FFAC91C4790
        public void WriteEndStartTag(){} // RVA: 0x7FFAC91C4BC0
        public void WriteEndAttributeQuote(){} // RVA: 0x7FFAC91C5020
        public void Indent(){} // RVA: 0x7FFAC91C50A0
        public void PushNamespace(){} // RVA: 0x7FFAC91C5190
        public void AddNamespace(){} // RVA: 0x7FFAC91C54D0
        public void AddToNamespaceHashtable(){} // RVA: 0x7FFAC91C5850
        public void PopNamespaces(){} // RVA: 0x7FFAC91C5990
        public void GeneratePrefix(){} // RVA: 0x7FFAC91C5AC0
        public void InternalWriteProcessingInstruction(){} // RVA: 0x7FFAC91C5D00
        public void LookupNamespace(){} // RVA: 0x7FFAC91C5E20
        public void LookupNamespaceInCurrentScope(){} // RVA: 0x7FFAC91C5F90
        public void FindPrefix(){} // RVA: 0x7FFAC91C6130
        public void ValidateName(){} // RVA: 0x7FFAC91C6240
        public void HandleSpecialAttribute(){} // RVA: 0x7FFAC91C64C0
        public void VerifyPrefixXml(){} // RVA: 0x7FFAC91C67F0
        public void PushStack(){} // RVA: 0x7FFAC91C68F0
        public void FlushEncoders(){} // RVA: 0x7FFAC91C6B20
        public void .cctor(){} // RVA: 0x7FFAC91C6B60
    }

    public class XmlTextWriterBase64Encoder : Base64Encoder
    {
        public System.Xml.XmlTextEncoder xmlTextEncoder; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC907FD00
        public void WriteChars(){} // RVA: 0x7FFAC907FDA0
    }

    public class XmlUnspecifiedAttribute : XmlAttribute
    {
        public bool Specified; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91E2E40
        public void get_Specified(){} // RVA: 0x7FFAC30F6BA0
        public void CloneNode(){} // RVA: 0x7FFAC9204370
        public void set_InnerText(){} // RVA: 0x7FFAC92044C0
        public void InsertBefore(){} // RVA: 0x7FFAC9204540
        public void InsertAfter(){} // RVA: 0x7FFAC92045D0
        public void RemoveChild(){} // RVA: 0x7FFAC9204660
        public void AppendChild(){} // RVA: 0x7FFAC92046F0
        public void WriteTo(){} // RVA: 0x7FFAC9204780
        public void SetSpecified(){} // RVA: 0x7FFAC3C24F40
    }

    public class XmlUrlResolver : XmlResolver
    {
        public object DownloadManager;
        public System.Net.ICredentials _credentials; // 0x10
        public System.Net.IWebProxy _proxy; // 0x18
        public System.Net.Cache.RequestCachePolicy _cachePolicy; // 0x20

        // ── Methods ──
        public void get_DownloadManager(){} // RVA: 0x7FFAC9227860
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetEntity(){} // RVA: 0x7FFAC9227970
        public void ResolveUri(){} // RVA: 0x7FFAC9227BE0
        public void GetEntityAsync(){} // RVA: 0x7FFAC9227BF0
    }

    public class XmlUtf8RawTextWriter : XmlRawWriter
    {
        public bool SupportsNamespaceDeclarationInChunks; // 0x28
        public byte[] bufBytes; // 0x30
        public System.IO.Stream stream; // 0x38
        public System.Text.Encoding encoding; // 0x40
        public System.Xml.XmlCharType xmlCharType; // 0x48
        public int bufPos; // 0x50
        public int textPos; // 0x54
        public int contentPos; // 0x58
        public int cdataPos; // 0x5C
        public int attrEndPos; // 0x60
        public int bufLen; // 0x64
        public bool writeToNull; // 0x68
        public bool hadDoubleBracket; // 0x69
        public bool inAttributeValue; // 0x6A
        public 0x6B159B28 newLineHandling; // 0x6C
        public bool closeOutput; // 0x70
        public bool omitXmlDeclaration; // 0x71
        public string newLineChars; // 0x78
        public bool checkCharacters; // 0x80
        public 0x6B15B6A8 standalone; // 0x84
        public 0x6B15B5F8 outputMethod; // 0x88
        public bool autoXmlDeclaration; // 0x8C
        public bool mergeCDataSections; // 0x8D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91C7520 | overloaded x2
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC91C7B00 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC91C7B70
        public void WriteStartElement(){} // RVA: 0x7FFAC91C7DE0
        public void StartElementContent(){} // RVA: 0x7FFAC91C7E90
        public void WriteEndElement(){} // RVA: 0x7FFAC91C7ED0
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91C8020
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91C8120
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91C8220
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFAC91B15B0
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFAC3006850
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFAC91C8260
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFAC91C8390
        public void WriteCData(){} // RVA: 0x7FFAC91C83D0
        public void WriteComment(){} // RVA: 0x7FFAC91C85C0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91C86E0
        public void WriteEntityRef(){} // RVA: 0x7FFAC91C8800
        public void WriteCharEntity(){} // RVA: 0x7FFAC91C88A0
        public void WriteWhitespace(){} // RVA: 0x7FFAC91C8B00
        public void WriteString(){} // RVA: 0x7FFAC91C8B00
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91C8B40
        public void WriteChars(){} // RVA: 0x7FFAC90987F0
        public void WriteRaw(){} // RVA: 0x7FFAC91AC060 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC91C8D70
        public void Flush(){} // RVA: 0x7FFAC91C8EC0
        public void FlushBuffer(){} // RVA: 0x7FFAC91C8F10
        public void FlushEncoder(){} // RVA: 0x7FFAC2F21310
        public void WriteAttributeTextBlock(){} // RVA: 0x7FFAC91C9280
        public void WriteElementTextBlock(){} // RVA: 0x7FFAC91C9540
        public void RawText(){} // RVA: 0x7FFAC91C9860 | overloaded x2
        public void WriteRawWithCharChecking(){} // RVA: 0x7FFAC91C99F0
        public void WriteCommentOrPi(){} // RVA: 0x7FFAC91C9C90
        public void WriteCDataSection(){} // RVA: 0x7FFAC91CA070
        public void IsSurrogateByte(){} // RVA: 0x7FFAC91CA410
        public void EncodeSurrogate(){} // RVA: 0x7FFAC91CA420
        public void InvalidXmlChar(){} // RVA: 0x7FFAC91CA5D0
        public void EncodeChar(){} // RVA: 0x7FFAC91CA7E0
        public void EncodeMultibyteUTF8(){} // RVA: 0x7FFAC91CA8B0
        public void CharToUTF8(){} // RVA: 0x7FFAC91CA900
        public void WriteNewLine(){} // RVA: 0x7FFAC91CA9C0
        public void LtEntity(){} // RVA: 0x7FFAC91CAA30
        public void GtEntity(){} // RVA: 0x7FFAC91CAA40
        public void AmpEntity(){} // RVA: 0x7FFAC91CAA50
        public void QuoteEntity(){} // RVA: 0x7FFAC91CAA60
        public void TabEntity(){} // RVA: 0x7FFAC91CAA80
        public void LineFeedEntity(){} // RVA: 0x7FFAC91CAA90
        public void CarriageReturnEntity(){} // RVA: 0x7FFAC91CAAA0
        public void CharEntity(){} // RVA: 0x7FFAC91CAAB0
        public void RawStartCData(){} // RVA: 0x7FFAC91CAC00
        public void RawEndCData(){} // RVA: 0x7FFAC91CAC20
        public void ValidateContentChars(){} // RVA: 0x7FFAC91CAC30
    }

    public class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
    {
        public int indentLevel; // 0x90
        public bool newLineOnAttributes; // 0x94
        public string indentChars; // 0x98
        public bool mixedContent; // 0xA0
        public System.Xml.BitStack mixedContentStack; // 0xA8
        public 0x6B159398 conformanceLevel; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91CB030
        public void WriteDocType(){} // RVA: 0x7FFAC91CB060
        public void WriteStartElement(){} // RVA: 0x7FFAC91CB0D0
        public void StartElementContent(){} // RVA: 0x7FFAC91CB200
        public void OnRootElement(){} // RVA: 0x7FFAC87B5A90
        public void WriteEndElement(){} // RVA: 0x7FFAC91CB270
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91CB340
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91CB4C0
        public void WriteCData(){} // RVA: 0x7FFAC91CB5D0
        public void WriteComment(){} // RVA: 0x7FFAC91CB5E0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91CB620
        public void WriteEntityRef(){} // RVA: 0x7FFAC91CB760
        public void WriteCharEntity(){} // RVA: 0x7FFAC91CB810
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91CB820
        public void WriteWhitespace(){} // RVA: 0x7FFAC91CB830
        public void WriteString(){} // RVA: 0x7FFAC91CB830
        public void WriteChars(){} // RVA: 0x7FFAC91CB880
        public void WriteRaw(){} // RVA: 0x7FFAC91CB920 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC91CB970
        public void Init(){} // RVA: 0x7FFAC91CB990
        public void WriteIndent(){} // RVA: 0x7FFAC91CBB70
    }

    public class XmlValidatingReader : XmlReader
    {
        public System.Xml.XmlValidatingReaderImpl NodeType; // 0x10

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7FFAC880FE40
        public void get_LocalName(){} // RVA: 0x7FFAC33088E0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC84AA500
        public void get_Prefix(){} // RVA: 0x7FFAC84AA530
        public void get_Value(){} // RVA: 0x7FFAC4426B30
        public void get_Depth(){} // RVA: 0x7FFAC8D71650
        public void get_BaseURI(){} // RVA: 0x7FFAC8D71620
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC8D711F0
        public void get_AttributeCount(){} // RVA: 0x7FFAC8B8D5F0
        public void GetAttribute(){} // RVA: 0x7FFAC8F0AC50 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC8F0AC80
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC84AA740
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC8599520
        public void MoveToElement(){} // RVA: 0x7FFAC8599550
        public void ReadAttributeValue(){} // RVA: 0x7FFAC8803C70
        public void Read(){} // RVA: 0x7FFAC32F0BD0
        public void get_EOF(){} // RVA: 0x7FFAC8F0ACE0
        public void get_ReadState(){} // RVA: 0x7FFAC8F0AD10
        public void get_NameTable(){} // RVA: 0x7FFAC88037A0
        public void LookupNamespace(){} // RVA: 0x7FFAC91BDF60
        public void ResolveEntity(){} // RVA: 0x7FFAC8F0ADA0
        public void get_Namespaces(){} // RVA: 0x7FFAC91CBBF0
    }

    public class XmlValidatingReaderImpl : XmlReader
    {
        public System.Xml.XmlReader Settings; // 0x10
        public System.Xml.XmlTextReaderImpl NodeType; // 0x18
        public System.Xml.IXmlNamespaceResolver Name; // 0x20
        public 0x6B159FA0 LocalName; // 0x28
        public System.Xml.Schema.BaseValidator NamespaceURI; // 0x30
        public System.Xml.Schema.XmlSchemaCollection Prefix; // 0x38
        public bool Value; // 0x40
        public 0x6B15AFC8 Depth; // 0x44
        public ValidationEventHandling BaseURI; // 0x48
        public System.Xml.XmlParserContext IsEmptyElement; // 0x50
        public System.Xml.ReadContentAsBinaryHelper IsDefault; // 0x58
        public System.Xml.XmlReader QuoteChar; // 0x60
        public System.Xml.XmlResolver XmlSpace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91CBC20
        public void get_Settings(){} // RVA: 0x7FFAC91CC3F0
        public void get_NodeType(){} // RVA: 0x7FFAC880FE40
        public void get_Name(){} // RVA: 0x7FFAC88045A0
        public void get_LocalName(){} // RVA: 0x7FFAC33088E0
        public void get_NamespaceURI(){} // RVA: 0x7FFAC84AA500
        public void get_Prefix(){} // RVA: 0x7FFAC84AA530
        public void get_Value(){} // RVA: 0x7FFAC4426B30
        public void get_Depth(){} // RVA: 0x7FFAC8D71650
        public void get_BaseURI(){} // RVA: 0x7FFAC8D71620
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC8D711F0
        public void get_IsDefault(){} // RVA: 0x7FFAC8D71270
        public void get_QuoteChar(){} // RVA: 0x7FFAC84AA3A0
        public void get_XmlSpace(){} // RVA: 0x7FFAC84AA770
        public void get_XmlLang(){} // RVA: 0x7FFAC84AA5F0
        public void get_ReadState(){} // RVA: 0x7FFAC91CC500
        public void get_EOF(){} // RVA: 0x7FFAC8F0ACE0
        public void get_NameTable(){} // RVA: 0x7FFAC88037A0
        public void get_AttributeCount(){} // RVA: 0x7FFAC8B8D5F0
        public void GetAttribute(){} // RVA: 0x7FFAC8F0AC50 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC91CC590 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC91CC5D0
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC91CC620
        public void MoveToElement(){} // RVA: 0x7FFAC91CC670
        public void Read(){} // RVA: 0x7FFAC91CC6C0
        public void Close(){} // RVA: 0x7FFAC91CC990
        public void LookupNamespace(){} // RVA: 0x7FFAC91CC9D0
        public void ReadAttributeValue(){} // RVA: 0x7FFAC91CCA00
        public void get_CanResolveEntity(){} // RVA: 0x7FFAC3006850
        public void ResolveEntity(){} // RVA: 0x7FFAC91CCA70
        public void MoveOffEntityReference(){} // RVA: 0x7FFAC91CCAB0
        public void ReadString(){} // RVA: 0x7FFAC91CCB70
        public void HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void get_LineNumber(){} // RVA: 0x7FFAC91CCC40
        public void get_LinePosition(){} // RVA: 0x7FFAC91CCCE0
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC91CCD80
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC8E4D8A0
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC91CCDE0
        public void GetNamespacesInScope(){} // RVA: 0x7FFAC91CCD80
        public void LookupPrefix(){} // RVA: 0x7FFAC91CCDE0
        public void get_ValidationType(){} // RVA: 0x7FFAC32EC4C0
        public void get_Schemas(){} // RVA: 0x7FFAC31D0140
        public void get_Namespaces(){} // RVA: 0x7FFAC91CCE40
        public void ParseDtdFromParserContext(){} // RVA: 0x7FFAC91CCE60
        public void ValidateDtd(){} // RVA: 0x7FFAC91CCFB0
        public void ResolveEntityInternally(){} // RVA: 0x7FFAC91CD140
        public void SetupValidation(){} // RVA: 0x7FFAC91CD1F0
        public void GetResolver(){} // RVA: 0x7FFAC91CD500
        public void ProcessCoreReaderEvent(){} // RVA: 0x7FFAC91CD5F0
        public void get_Validator(){} // RVA: 0x7FFAC31D95E0
        public void set_Validator(){} // RVA: 0x7FFAC2F4F890
        public void get_NamespaceManager(){} // RVA: 0x7FFAC91CD710
        public void get_StandAlone(){} // RVA: 0x7FFAC91CD740
        public void set_SchemaTypeObject(){} // RVA: 0x7FFAC91CD760
        public void get_TypedValueObject(){} // RVA: 0x7FFAC91CD780
        public void set_TypedValueObject(){} // RVA: 0x7FFAC91CD7B0
        public void AddDefaultAttribute(){} // RVA: 0x7FFAC91CD7D0
        public void get_DtdInfo(){} // RVA: 0x7FFAC91CD7F0
        public void ValidateDefaultAttributeOnUse(){} // RVA: 0x7FFAC91CD820
    }

    public class XmlWellFormedWriter : XmlWriter
    {
        public System.Xml.XmlWriter WriteState; // 0x18
        public System.Xml.XmlRawWriter RawWriter; // 0x20
        public System.Xml.IXmlNamespaceResolver SaveAttrValue; // 0x28
        public Namespace[] InBase64; // 0x30
        public int IsClosedOrErrorState; // 0x38
        public System.Collections.Generic.Dictionary`2<string,int> nsHashtable; // 0x40
        public bool useNsHashtable; // 0x48
        public ElementScope[] elemScopeStack; // 0x50
        public int elemTop; // 0x58
        public AttrName[] attrStack; // 0x60
        public int attrCount; // 0x68
        public System.Collections.Generic.Dictionary`2<string,int> attrHashTable; // 0x70
        public 0x6B15B338 specAttr; // 0x78
        public AttributeValueCache attrValueCache; // 0x80
        public string curDeclPrefix; // 0x88
        public 0x6B15B0D0[] stateTable; // 0x90
        public 0x6B15B0D0 currentState; // 0x98
        public bool checkCharacters; // 0x9C
        public bool omitDuplNamespaces; // 0x9D
        public bool writeEndDocumentOnClose; // 0x9E
        public 0x6B159398 conformanceLevel; // 0xA0
        public bool dtdWritten; // 0xA4
        public bool xmlDeclFollows; // 0xA5
        public System.Xml.XmlCharType xmlCharType; // 0xA8
        public System.Xml.SecureStringHasher hasher; // 0xB0
        public string[] stateName;
        public string[] tokenName; // 0x8
        public 0x6B15B548[] state2WriteState; // 0x10
        public 0x6B15B0D0[] StateTableDocument; // 0x18
        public 0x6B15B0D0[] StateTableAuto; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91CDBA0
        public void get_WriteState(){} // RVA: 0x7FFAC91CE380
        public void WriteStartDocument(){} // RVA: 0x7FFAC91CE420 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFAC91CE450
        public void WriteDocType(){} // RVA: 0x7FFAC91CE560
        public void WriteStartElement(){} // RVA: 0x7FFAC91CEAE0
        public void WriteEndElement(){} // RVA: 0x7FFAC91CEE60
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91CF030
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91CF200
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91CFAE0
        public void WriteCData(){} // RVA: 0x7FFAC91D0E00
        public void WriteComment(){} // RVA: 0x7FFAC91D0EC0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91D0F80
        public void WriteEntityRef(){} // RVA: 0x7FFAC91D1270
        public void WriteCharEntity(){} // RVA: 0x7FFAC91D1380
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91D1540
        public void WriteWhitespace(){} // RVA: 0x7FFAC91D1750
        public void WriteString(){} // RVA: 0x7FFAC91D1930
        public void WriteChars(){} // RVA: 0x7FFAC91D1A70
        public void WriteRaw(){} // RVA: 0x7FFAC91D2010 | overloaded x2
        public void WriteBase64(){} // RVA: 0x7FFAC91D20F0
        public void Close(){} // RVA: 0x7FFAC91D22D0
        public void Flush(){} // RVA: 0x7FFAC91D2910
        public void LookupPrefix(){} // RVA: 0x7FFAC91D2970
        public void WriteValue(){} // RVA: 0x7FFAC91D2B70
        public void WriteBinHex(){} // RVA: 0x7FFAC91D2C60
        public void get_RawWriter(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SaveAttrValue(){} // RVA: 0x7FFAC90E26F0
        public void get_InBase64(){} // RVA: 0x7FFAC91D2D50
        public void SetSpecialAttribute(){} // RVA: 0x7FFAC91D2D70
        public void WriteStartDocumentImpl(){} // RVA: 0x7FFAC91D2EF0
        public void StartFragment(){} // RVA: 0x7FFAC91D30D0
        public void PushNamespaceImplicit(){} // RVA: 0x7FFAC91D30E0
        public void PushNamespaceExplicit(){} // RVA: 0x7FFAC91D3700
        public void AddNamespace(){} // RVA: 0x7FFAC91D3E20
        public void AddToNamespaceHashtable(){} // RVA: 0x7FFAC91D4160
        public void LookupNamespaceIndex(){} // RVA: 0x7FFAC91D4290
        public void PopNamespaces(){} // RVA: 0x7FFAC91D43E0
        public void DupAttrException(){} // RVA: 0x7FFAC91D4500
        public void AdvanceState(){} // RVA: 0x7FFAC91D4610
        public void StartElementContent(){} // RVA: 0x7FFAC91D4A30
        public void GetStateName(){} // RVA: 0x7FFAC91D4B00
        public void LookupNamespace(){} // RVA: 0x7FFAC91D4BA0
        public void LookupLocalNamespace(){} // RVA: 0x7FFAC91D4CA0
        public void GeneratePrefix(){} // RVA: 0x7FFAC91D4DC0
        public void CheckNCName(){} // RVA: 0x7FFAC91D5090
        public void InvalidCharsException(){} // RVA: 0x7FFAC91D51C0
        public void ThrowInvalidStateTransition(){} // RVA: 0x7FFAC91D5330
        public void get_IsClosedOrErrorState(){} // RVA: 0x7FFAC91D5530
        public void AddAttribute(){} // RVA: 0x7FFAC91D5540
        public void AddToAttrHashTable(){} // RVA: 0x7FFAC91D5AD0
        public void .cctor(){} // RVA: 0x7FFAC91D5C50
    }

    public class XmlWhitespace : XmlCharacterData
    {
        public object Name;
        public object LocalName;
        public object NodeType;
        public object ParentNode;
        public object Value;
        public object IsText;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9204860
        public void get_Name(){} // RVA: 0x7FFAC9204960
        public void get_LocalName(){} // RVA: 0x7FFAC9204960
        public void get_NodeType(){} // RVA: 0x7FFAC3C15CE0
        public void get_ParentNode(){} // RVA: 0x7FFAC9203F90
        public void get_Value(){} // RVA: 0x7FFAC86542D0
        public void set_Value(){} // RVA: 0x7FFAC9204990
        public void CloneNode(){} // RVA: 0x7FFAC9204A90
        public void WriteTo(){} // RVA: 0x7FFAC9204B00
        public void WriteContentTo(){} // RVA: 0x7FFAC2F21310
        public void get_IsText(){} // RVA: 0x7FFAC3006850
    }

    public class XmlWriter : Object
    {
        public char[] WriteState; // 0x10

        // ── Methods ──
        public void WriteStartDocument(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void WriteEndDocument(){} // RVA: 0x7FFAC2C70980
        public void WriteDocType(){} // RVA: 0x7FFAC2C7B8C0
        public void WriteStartElement(){} // RVA: 0x7FFAC2C7AF60 | overloaded x2
        public void WriteEndElement(){} // RVA: 0x7FFAC2C70980
        public void WriteFullEndElement(){} // RVA: 0x7FFAC2C70980
        public void WriteAttributeString(){} // RVA: 0x7FFAC91D83D0 | overloaded x3
        public void WriteStartAttribute(){} // RVA: 0x7FFAC2C7AF60
        public void WriteEndAttribute(){} // RVA: 0x7FFAC2C70980
        public void WriteCData(){} // RVA: 0x7FFAC2C70A40
        public void WriteComment(){} // RVA: 0x7FFAC2C70A40
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC2C79B30
        public void WriteEntityRef(){} // RVA: 0x7FFAC2C70A40
        public void WriteCharEntity(){} // RVA: 0x7FFAC2C70B70
        public void WriteWhitespace(){} // RVA: 0x7FFAC2C70A40
        public void WriteString(){} // RVA: 0x7FFAC2C70A40
        public void WriteSurrogateCharEntity(){}
        public void WriteChars(){}
        public void WriteRaw(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void WriteBase64(){}
        public void WriteBinHex(){} // RVA: 0x7FFAC91D8430
        public void get_WriteState(){} // RVA: 0x7FFAC2C59960
        public void Close(){} // RVA: 0x7FFAC2F21310
        public void Flush(){} // RVA: 0x7FFAC2C70980
        public void LookupPrefix(){} // RVA: 0x7FFAC2C58F40
        public void WriteValue(){} // RVA: 0x7FFAC91D8460
        public void WriteAttributes(){} // RVA: 0x7FFAC91D8480
        public void WriteNode(){} // RVA: 0x7FFAC91D87F0
        public void WriteElementString(){} // RVA: 0x7FFAC91D8DD0
        public void Dispose(){} // RVA: 0x7FFAC91D8E70 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC91D8F30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlWriterSettings : Object
    {
        public bool Async; // 0x10
        public System.Text.Encoding Encoding; // 0x18
        public bool OmitXmlDeclaration; // 0x20
        public 0x6B159B28 NewLineHandling; // 0x24
        public string NewLineChars; // 0x28
        public 0x6B15B650 Indent; // 0x30
        public string IndentChars; // 0x38
        public bool NewLineOnAttributes; // 0x40
        public bool CloseOutput; // 0x41
        public 0x6B159AD0 ConformanceLevel; // 0x44
        public 0x6B159398 CheckCharacters; // 0x48
        public bool NamespaceHandling; // 0x4C
        public bool WriteEndDocumentOnClose; // 0x4D
        public 0x6B15B5F8 OutputMethod; // 0x50
        public System.Collections.Generic.List`1<System.Xml.XmlQualifiedName> CDataSectionElements; // 0x58
        public bool DoNotEscapeUriAttributes; // 0x60
        public bool MergeCDataSections; // 0x61
        public string MediaType; // 0x68
        public string DocTypeSystem; // 0x70
        public string DocTypePublic; // 0x78
        public 0x6B15B6A8 Standalone; // 0x80
        public bool AutoXmlDeclaration; // 0x84
        public bool IndentInternal; // 0x85

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91D8FB0
        public void get_Async(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Encoding(){} // RVA: 0x7FFAC2F247C0
        public void get_OmitXmlDeclaration(){} // RVA: 0x7FFAC300F9D0
        public void set_OmitXmlDeclaration(){} // RVA: 0x7FFAC91D9080
        public void get_NewLineHandling(){} // RVA: 0x7FFAC3921980
        public void get_NewLineChars(){} // RVA: 0x7FFAC2F4F130
        public void get_Indent(){} // RVA: 0x7FFAC8B5CD60
        public void set_Indent(){} // RVA: 0x7FFAC91D90E0
        public void get_IndentChars(){} // RVA: 0x7FFAC31D0140
        public void get_NewLineOnAttributes(){} // RVA: 0x7FFAC2FDCC00
        public void get_CloseOutput(){} // RVA: 0x7FFAC31D8A60
        public void get_ConformanceLevel(){} // RVA: 0x7FFAC2FC20C0
        public void set_ConformanceLevel(){} // RVA: 0x7FFAC91D9140
        public void get_CheckCharacters(){} // RVA: 0x7FFAC4168960
        public void get_NamespaceHandling(){} // RVA: 0x7FFAC2FC20A0
        public void set_NamespaceHandling(){} // RVA: 0x7FFAC91D91E0
        public void get_WriteEndDocumentOnClose(){} // RVA: 0x7FFAC91D9280
        public void get_OutputMethod(){} // RVA: 0x7FFAC30F10E0
        public void set_OutputMethod(){} // RVA: 0x7FFAC31D9010
        public void Clone(){} // RVA: 0x7FFAC91D9290
        public void get_CDataSectionElements(){} // RVA: 0x7FFAC2FE9500
        public void get_DoNotEscapeUriAttributes(){} // RVA: 0x7FFAC2F4A020
        public void get_MergeCDataSections(){} // RVA: 0x7FFAC3C11000
        public void get_MediaType(){} // RVA: 0x7FFAC2F9CD50
        public void get_DocTypeSystem(){} // RVA: 0x7FFAC2FE9590
        public void get_DocTypePublic(){} // RVA: 0x7FFAC30E5600
        public void get_Standalone(){} // RVA: 0x7FFAC35729C0
        public void get_AutoXmlDeclaration(){} // RVA: 0x7FFAC3000CE0
        public void get_IndentInternal(){} // RVA: 0x7FFAC2F7CCD0
        public void get_IsQuerySpecific(){} // RVA: 0x7FFAC91D93B0
        public void CreateWriter(){} // RVA: 0x7FFAC91D9A10 | overloaded x2
        public void set_ReadOnly(){} // RVA: 0x7FFAC8B10310
        public void CheckReadOnly(){} // RVA: 0x7FFAC91D9E10
        public void Initialize(){} // RVA: 0x7FFAC91D9EC0
    }

    public class XsdCachingReader : XmlReader
    {
        public System.Xml.XmlReader Settings; // 0x10
        public System.Xml.XmlNameTable NodeType; // 0x18
        public System.Xml.ValidatingReaderNodeData[] Name; // 0x20
        public System.Xml.ValidatingReaderNodeData[] LocalName; // 0x28
        public System.Xml.ValidatingReaderNodeData NamespaceURI; // 0x30
        public 0x6B15B758 Prefix; // 0x38
        public int Value; // 0x3C
        public int Depth; // 0x40
        public bool BaseURI; // 0x44
        public System.Xml.CachingEventHandler IsEmptyElement; // 0x48
        public int IsDefault; // 0x50
        public int QuoteChar; // 0x54
        public bool XmlSpace; // 0x58
        public System.Xml.IXmlLineInfo XmlLang; // 0x60
        public System.Xml.ValidatingReaderNodeData AttributeCount; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91DA190
        public void Init(){} // RVA: 0x7FFAC91DA3D0
        public void Reset(){} // RVA: 0x7FFAC91DA670
        public void get_Settings(){} // RVA: 0x7FFAC87BB0A0
        public void get_NodeType(){} // RVA: 0x7FFAC91DA6D0
        public void get_Name(){} // RVA: 0x7FFAC91DA6F0
        public void get_LocalName(){} // RVA: 0x7FFAC91DA720
        public void get_NamespaceURI(){} // RVA: 0x7FFAC3664E80
        public void get_Prefix(){} // RVA: 0x7FFAC91DA740
        public void get_Value(){} // RVA: 0x7FFAC91DA760
        public void get_Depth(){} // RVA: 0x7FFAC91DA790
        public void get_BaseURI(){} // RVA: 0x7FFAC8D71620
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC2F21320
        public void get_IsDefault(){} // RVA: 0x7FFAC2F21320
        public void get_QuoteChar(){} // RVA: 0x7FFAC84AA3A0
        public void get_XmlSpace(){} // RVA: 0x7FFAC84AA770
        public void get_XmlLang(){} // RVA: 0x7FFAC84AA5F0
        public void get_AttributeCount(){} // RVA: 0x7FFAC2FC2080
        public void GetAttribute(){} // RVA: 0x7FFAC91DA9D0 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC91DABC0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC91DACB0
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC91DAD40
        public void MoveToElement(){} // RVA: 0x7FFAC91DADE0
        public void Read(){} // RVA: 0x7FFAC91DAE30
        public void RecordTextNode(){} // RVA: 0x7FFAC91DB1F0
        public void SwitchTextNodeAndEndElement(){} // RVA: 0x7FFAC91DB270
        public void RecordEndElementNode(){} // RVA: 0x7FFAC91DB3C0
        public void get_EOF(){} // RVA: 0x7FFAC91DB570
        public void Close(){} // RVA: 0x7FFAC91DB5B0
        public void get_ReadState(){} // RVA: 0x7FFAC8F0AD10
        public void Skip(){} // RVA: 0x7FFAC91DB5F0
        public void get_NameTable(){} // RVA: 0x7FFAC2F247C0
        public void LookupNamespace(){} // RVA: 0x7FFAC8F0AD40
        public void ResolveEntity(){} // RVA: 0x7FFAC91DB730
        public void ReadAttributeValue(){} // RVA: 0x7FFAC91DB770
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7FFAC91DB930
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7FFAC91DB950
        public void SetToReplayMode(){} // RVA: 0x7FFAC91DB970
        public void GetCoreReader(){} // RVA: 0x7FFAC2F3C380
        public void GetLineInfo(){} // RVA: 0x7FFAC2FBF370
        public void ClearAttributesInfo(){} // RVA: 0x7FFAC91DB9A0
        public void AddAttribute(){} // RVA: 0x7FFAC91DB9B0
        public void AddContent(){} // RVA: 0x7FFAC91DBB90
        public void RecordAttributes(){} // RVA: 0x7FFAC91DBD60
        public void GetAttributeIndexWithoutPrefix(){} // RVA: 0x7FFAC91DBFD0
        public void GetAttributeIndexWithPrefix(){} // RVA: 0x7FFAC91DC060
        public void CreateDummyTextNode(){} // RVA: 0x7FFAC91DC110
    }

    public class XsdValidatingReader : XmlReader
    {
        public System.Xml.XmlReader Settings; // 0x10
        public System.Xml.IXmlNamespaceResolver NodeType; // 0x18
        public System.Xml.IXmlNamespaceResolver Name; // 0x20
        public System.Xml.Schema.XmlSchemaValidator LocalName; // 0x28
        public System.Xml.XmlResolver NamespaceURI; // 0x30
        public System.Xml.Schema.ValidationEventHandler Prefix; // 0x38
        public 0x6B15B8B8 Value; // 0x40
        public System.Xml.Schema.XmlValueGetter Depth; // 0x48
        public System.Xml.XmlNamespaceManager BaseURI; // 0x50
        public bool IsEmptyElement; // 0x58
        public bool IsDefault; // 0x59
        public bool QuoteChar; // 0x5A
        public System.Xml.ValidatingReaderNodeData XmlSpace; // 0x60
        public System.Xml.AttributePSVIInfo XmlLang; // 0x68
        public int SchemaInfo; // 0x70
        public int ValueType; // 0x74
        public int AttributeCount; // 0x78
        public System.Xml.AttributePSVIInfo[] EOF; // 0x80
        public System.Collections.ArrayList ReadState; // 0x88
        public System.Xml.Schema.Parser NameTable; // 0x90
        public object System.Xml.Schema.IXmlSchemaInfo.IsDefault; // 0x98
        public System.Xml.Schema.XmlSchemaInfo System.Xml.Schema.IXmlSchemaInfo.IsNil; // 0xA0
        public string System.Xml.Schema.IXmlSchemaInfo.Validity; // 0xA8
        public System.Xml.XmlNameTable System.Xml.Schema.IXmlSchemaInfo.MemberType; // 0xB0
        public System.Xml.XsdCachingReader System.Xml.Schema.IXmlSchemaInfo.SchemaType; // 0xB8
        public System.Xml.ValidatingReaderNodeData System.Xml.Schema.IXmlSchemaInfo.SchemaElement; // 0xC0
        public string System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute; // 0xC8
        public string LineNumber; // 0xD0
        public string LinePosition; // 0xD8
        public string AttributeSchemaInfo; // 0xE0
        public string XsiNil; // 0xE8
        public string XsdSchema; // 0xF0
        public string XsiSchemaLocation; // 0xF8
        public string XsiNoNamespaceSchemaLocation; // 0x100
        public System.Xml.XmlCharType xmlCharType; // 0x108
        public System.Xml.IXmlLineInfo lineInfo; // 0x110
        public System.Xml.ReadContentAsBinaryHelper readBinaryHelper; // 0x118
        public 0x6B15B8B8 savedState; // 0x120
        public System.Type TypeOfString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91DC8C0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC91DC8E0
        public void SetupValidator(){} // RVA: 0x7FFAC91DD0E0
        public void get_Settings(){} // RVA: 0x7FFAC91DD7F0
        public void get_NodeType(){} // RVA: 0x7FFAC91DD980
        public void get_Name(){} // RVA: 0x7FFAC91DDA50
        public void get_LocalName(){} // RVA: 0x7FFAC91DDB80
        public void get_NamespaceURI(){} // RVA: 0x7FFAC91DDBD0
        public void get_Prefix(){} // RVA: 0x7FFAC91DDC20
        public void get_Value(){} // RVA: 0x7FFAC91DDC70
        public void get_Depth(){} // RVA: 0x7FFAC91DDCC0
        public void get_BaseURI(){} // RVA: 0x7FFAC8D71620
        public void get_IsEmptyElement(){} // RVA: 0x7FFAC8D711F0
        public void get_IsDefault(){} // RVA: 0x7FFAC91DDD10
        public void get_QuoteChar(){} // RVA: 0x7FFAC84AA3A0
        public void get_XmlSpace(){} // RVA: 0x7FFAC84AA770
        public void get_XmlLang(){} // RVA: 0x7FFAC84AA5F0
        public void get_SchemaInfo(){} // RVA: 0x7FFAC44F81E0
        public void get_ValueType(){} // RVA: 0x7FFAC91DDD50
        public void get_AttributeCount(){} // RVA: 0x7FFAC3B99E80
        public void GetAttribute(){} // RVA: 0x7FFAC91DDFE0 | overloaded x3
        public void MoveToAttribute(){} // RVA: 0x7FFAC91DE1F0 | overloaded x2
        public void MoveToFirstAttribute(){} // RVA: 0x7FFAC91DE410
        public void MoveToNextAttribute(){} // RVA: 0x7FFAC91DE730
        public void MoveToElement(){} // RVA: 0x7FFAC91DEA40
        public void Read(){} // RVA: 0x7FFAC91DEAA0
        public void get_EOF(){} // RVA: 0x7FFAC8F0ACE0
        public void Close(){} // RVA: 0x7FFAC91DED80
        public void get_ReadState(){} // RVA: 0x7FFAC91DEDC0
        public void Skip(){} // RVA: 0x7FFAC91DEE00
        public void get_NameTable(){} // RVA: 0x7FFAC2F8C040
        public void LookupNamespace(){} // RVA: 0x7FFAC91DEFB0
        public void ResolveEntity(){} // RVA: 0x7FFAC91DF010
        public void ReadAttributeValue(){} // RVA: 0x7FFAC91DF050
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsDefault(){} // RVA: 0x7FFAC91DF290
        public void System.Xml.Schema.IXmlSchemaInfo.get_IsNil(){} // RVA: 0x7FFAC91DF320
        public void System.Xml.Schema.IXmlSchemaInfo.get_Validity(){} // RVA: 0x7FFAC91DF370
        public void System.Xml.Schema.IXmlSchemaInfo.get_MemberType(){} // RVA: 0x7FFAC91DF430
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaType(){} // RVA: 0x7FFAC91DF610
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement(){} // RVA: 0x7FFAC91DF670
        public void System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute(){} // RVA: 0x7FFAC91DF6D0
        public void HasLineInfo(){} // RVA: 0x7FFAC3006850
        public void get_LineNumber(){} // RVA: 0x7FFAC91DF720
        public void get_LinePosition(){} // RVA: 0x7FFAC91DF780
        public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC91DF7E0
        public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC91DF870
        public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC91DF900
        public void GetStringValue(){} // RVA: 0x7FFAC4426B30
        public void get_AttributeSchemaInfo(){} // RVA: 0x7FFAC91DF990
        public void ProcessReaderEvent(){} // RVA: 0x7FFAC91DF9B0
        public void ProcessElementEvent(){} // RVA: 0x7FFAC91DFC70
        public void ProcessEndElementEvent(){} // RVA: 0x7FFAC91E03C0
        public void ValidateAttributes(){} // RVA: 0x7FFAC91E0690
        public void ClearAttributesInfo(){} // RVA: 0x7FFAC91E09F0
        public void GetAttributePSVI(){} // RVA: 0x7FFAC91E0C40 | overloaded x2
        public void GetDefaultAttribute(){} // RVA: 0x7FFAC91E0E10 | overloaded x2
        public void AddAttributePSVI(){} // RVA: 0x7FFAC91E0F60
        public void IsXSDRoot(){} // RVA: 0x7FFAC91E11A0
        public void ProcessInlineSchema(){} // RVA: 0x7FFAC91E11C0
        public void ReadAheadForMemberType(){} // RVA: 0x7FFAC91E1300
        public void GetIsDefault(){} // RVA: 0x7FFAC91E1630
        public void GetMemberType(){} // RVA: 0x7FFAC91E1AB0
        public void GetCachingReader(){} // RVA: 0x7FFAC91E1BF0
        public void CreateDummyTextNode(){} // RVA: 0x7FFAC91E1E00
        public void CachingCallBack(){} // RVA: 0x7FFAC91E1F60
        public void GetOriginalAtomicValueStringOfElement(){} // RVA: 0x7FFAC91E2040
    }

}