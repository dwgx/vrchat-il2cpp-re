// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 6
// Methods: 72

namespace ThirdParty.DotNet.System.Xml
{
    public class HWStack : Object
    {
        public object stack;
        public object growthRate;
        public object used;
        public object size;
        public object limit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D35D0
        public void Push(){} // RVA: 0x74D3230
        public void Pop(){} // RVA: 0x74D33A0
        public void Peek(){} // RVA: 0x74D33E0
        public void AddToTop(){} // RVA: 0x74D3420
        public void get_Item(){} // RVA: 0x74D34A0
        public void set_Item(){} // RVA: 0x74D3520
        public void get_Length(){} // RVA: 0x2244FB0
        public void Clone(){} // RVA: 0x74D3640
    }

    public class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
    {
        public object elementScope;
        public object currentElementProperties;
        public object currentAttributeProperties;
        public object endsWithAmpersand;
        public object uriEscapingBuffer;
        public object mediaType;
        public object doNotEscapeUriAttributes;
        public object elementPropertySearch;
        public object attributePropertySearch;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73634B0
        public void WriteXmlDeclaration(){} // RVA: 0xB43310
        public void WriteDocType(){} // RVA: 0x73634E0
        public void WriteStartElement(){} // RVA: 0x73637E0
        public void StartElementContent(){} // RVA: 0x73639B0
        public void WriteEndElement(){} // RVA: 0x7363A10
        public void WriteFullEndElement(){} // RVA: 0x7363B60
        public void WriteStartAttribute(){} // RVA: 0x7363CB0
        public void WriteEndAttribute(){} // RVA: 0x7363E50
        public void WriteProcessingInstruction(){} // RVA: 0x7363EE0
        public void WriteString(){} // RVA: 0x7364020
        public void WriteEntityRef(){} // RVA: 0x7364110
        public void WriteCharEntity(){} // RVA: 0x7364170
        public void WriteSurrogateCharEntity(){} // RVA: 0x73641D0
        public void WriteChars(){} // RVA: 0x7364230
        public void Init(){} // RVA: 0x73642C0
        public void WriteMetaElement(){} // RVA: 0x73646C0
        public void WriteHtmlElementTextBlock(){} // RVA: 0x73648B0
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x73648D0
        public void WriteHtmlAttributeText(){} // RVA: 0x7364920
        public void WriteUriAttributeText(){} // RVA: 0x7364C80
        public void OutputRestAmps(){} // RVA: 0x73650B0
    }

    public class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
    {
        public object indentLevel;
        public object endBlockPos;
        public object indentChars;
        public object newLineOnAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7365200
        public void WriteDocType(){} // RVA: 0x73652B0
        public void WriteStartElement(){} // RVA: 0x73652E0
        public void StartElementContent(){} // RVA: 0x73654D0
        public void WriteEndElement(){} // RVA: 0x7365550
        public void WriteStartAttribute(){} // RVA: 0x7365600
        public void FlushBuffer(){} // RVA: 0x73656A0
        public void Init(){} // RVA: 0x73656C0
        public void WriteIndent(){} // RVA: 0x7365750
    }

    public class HtmlTernaryTree : Object
    {
        public object htmlElements;
        public object htmlAttributes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x73657D0
    }

    public class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
    {
        public object elementScope;
        public object currentElementProperties;
        public object currentAttributeProperties;
        public object endsWithAmpersand;
        public object uriEscapingBuffer;
        public object mediaType;
        public object doNotEscapeUriAttributes;
        public object elementPropertySearch;
        public object attributePropertySearch;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7365970
        public void WriteXmlDeclaration(){} // RVA: 0xB43310
        public void WriteDocType(){} // RVA: 0x73659A0
        public void WriteStartElement(){} // RVA: 0x7365C70
        public void StartElementContent(){} // RVA: 0x7365E00
        public void WriteEndElement(){} // RVA: 0x7365E50
        public void WriteFullEndElement(){} // RVA: 0x7365F80
        public void WriteStartAttribute(){} // RVA: 0x73660B0
        public void WriteEndAttribute(){} // RVA: 0x7366230
        public void WriteProcessingInstruction(){} // RVA: 0x73662A0
        public void WriteString(){} // RVA: 0x73663B0
        public void WriteEntityRef(){} // RVA: 0x7366450
        public void WriteCharEntity(){} // RVA: 0x73664B0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7366510
        public void WriteChars(){} // RVA: 0x7366570
        public void Init(){} // RVA: 0x73665C0
        public void WriteMetaElement(){} // RVA: 0x73669C0
        public void WriteHtmlElementTextBlock(){} // RVA: 0x7366BB0
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x7366BD0
        public void WriteHtmlAttributeText(){} // RVA: 0x7366C20
        public void WriteUriAttributeText(){} // RVA: 0x7366F20
        public void OutputRestAmps(){} // RVA: 0x73672F0
    }

    public class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
    {
        public object indentLevel;
        public object endBlockPos;
        public object indentChars;
        public object newLineOnAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7478A50
        public void WriteDocType(){} // RVA: 0x7478B00
        public void WriteStartElement(){} // RVA: 0x7478B30
        public void StartElementContent(){} // RVA: 0x7478CF0
        public void WriteEndElement(){} // RVA: 0x7478D70
        public void WriteStartAttribute(){} // RVA: 0x7478F10
        public void FlushBuffer(){} // RVA: 0x7478FB0
        public void Init(){} // RVA: 0x7478FD0
        public void WriteIndent(){} // RVA: 0x7479060
    }

}