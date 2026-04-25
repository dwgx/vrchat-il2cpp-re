// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 6
// Methods: 78

namespace ThirdParty.DotNet.System.Xml
{
    public class HWStack : Object
    {
        public object[] Item; // 0x10
        public int Length; // 0x18
        public int used; // 0x1C
        public int size; // 0x20
        public int limit; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92050D0 | overloaded x3
        public void Push(){} // RVA: 0x7FFAC9204D20
        public void Pop(){} // RVA: 0x7FFAC9204EA0
        public void Peek(){} // RVA: 0x7FFAC9204EE0
        public void AddToTop(){} // RVA: 0x7FFAC9204F20
        public void get_Item(){} // RVA: 0x7FFAC9204FA0
        public void set_Item(){} // RVA: 0x7FFAC9205020
        public void get_Length(){} // RVA: 0x7FFAC44357F0
        public void Clone(){} // RVA: 0x7FFAC9205140
    }

    public class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
    {
        public System.Xml.ByteStack elementScope; // 0xC0
        public 0x6B159C88 currentElementProperties; // 0xC8
        public 0x6B159CE0 currentAttributeProperties; // 0xCC
        public bool endsWithAmpersand; // 0xD0
        public byte[] uriEscapingBuffer; // 0xD8
        public string mediaType; // 0xE0
        public bool doNotEscapeUriAttributes; // 0xE8
        public System.Xml.TernaryTreeReadOnly elementPropertySearch;
        public System.Xml.TernaryTreeReadOnly attributePropertySearch; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9095700 | overloaded x2
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC9095730
        public void WriteStartElement(){} // RVA: 0x7FFAC9095A30
        public void StartElementContent(){} // RVA: 0x7FFAC9095C00
        public void WriteEndElement(){} // RVA: 0x7FFAC9095C60
        public void WriteFullEndElement(){} // RVA: 0x7FFAC9095DB0
        public void WriteStartAttribute(){} // RVA: 0x7FFAC9095F00
        public void WriteEndAttribute(){} // RVA: 0x7FFAC90960A0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC9096130
        public void WriteString(){} // RVA: 0x7FFAC9096270
        public void WriteEntityRef(){} // RVA: 0x7FFAC9096360
        public void WriteCharEntity(){} // RVA: 0x7FFAC90963C0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC9096420
        public void WriteChars(){} // RVA: 0x7FFAC9096480
        public void Init(){} // RVA: 0x7FFAC9096510
        public void WriteMetaElement(){} // RVA: 0x7FFAC9096910
        public void WriteHtmlElementTextBlock(){} // RVA: 0x7FFAC9096B00
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x7FFAC9096B20
        public void WriteHtmlAttributeText(){} // RVA: 0x7FFAC9096B70
        public void WriteUriAttributeText(){} // RVA: 0x7FFAC9096EF0
        public void OutputRestAmps(){} // RVA: 0x7FFAC9097340
    }

    public class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
    {
        public int indentLevel; // 0xF0
        public int endBlockPos; // 0xF4
        public string indentChars; // 0xF8
        public bool newLineOnAttributes; // 0x100

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9097490 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC9097540
        public void WriteStartElement(){} // RVA: 0x7FFAC9097570
        public void StartElementContent(){} // RVA: 0x7FFAC9097760
        public void WriteEndElement(){} // RVA: 0x7FFAC90977E0
        public void WriteStartAttribute(){} // RVA: 0x7FFAC9097880
        public void FlushBuffer(){} // RVA: 0x7FFAC9097920
        public void Init(){} // RVA: 0x7FFAC9097940
        public void WriteIndent(){} // RVA: 0x7FFAC90979D0
    }

    public class HtmlTernaryTree : Object
    {
        public byte[] htmlElements;
        public byte[] htmlAttributes; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9097A50
    }

    public class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
    {
        public System.Xml.ByteStack elementScope; // 0x90
        public 0x6B159C88 currentElementProperties; // 0x98
        public 0x6B159CE0 currentAttributeProperties; // 0x9C
        public bool endsWithAmpersand; // 0xA0
        public byte[] uriEscapingBuffer; // 0xA8
        public string mediaType; // 0xB0
        public bool doNotEscapeUriAttributes; // 0xB8
        public System.Xml.TernaryTreeReadOnly elementPropertySearch;
        public System.Xml.TernaryTreeReadOnly attributePropertySearch; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9097BF0
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC9097C20
        public void WriteStartElement(){} // RVA: 0x7FFAC9097EF0
        public void StartElementContent(){} // RVA: 0x7FFAC9098080
        public void WriteEndElement(){} // RVA: 0x7FFAC90980D0
        public void WriteFullEndElement(){} // RVA: 0x7FFAC9098200
        public void WriteStartAttribute(){} // RVA: 0x7FFAC9098330
        public void WriteEndAttribute(){} // RVA: 0x7FFAC90984B0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC9098520
        public void WriteString(){} // RVA: 0x7FFAC9098630
        public void WriteEntityRef(){} // RVA: 0x7FFAC90986D0
        public void WriteCharEntity(){} // RVA: 0x7FFAC9098730
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC9098790
        public void WriteChars(){} // RVA: 0x7FFAC90987F0
        public void Init(){} // RVA: 0x7FFAC9098840
        public void WriteMetaElement(){} // RVA: 0x7FFAC9098C40
        public void WriteHtmlElementTextBlock(){} // RVA: 0x7FFAC9098E30
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x7FFAC9098E50
        public void WriteHtmlAttributeText(){} // RVA: 0x7FFAC9098EA0
        public void WriteUriAttributeText(){} // RVA: 0x7FFAC9099190
        public void OutputRestAmps(){} // RVA: 0x7FFAC9099570
    }

    public class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
    {
        public int indentLevel; // 0xC0
        public int endBlockPos; // 0xC4
        public string indentChars; // 0xC8
        public bool newLineOnAttributes; // 0xD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A9CB0
        public void WriteDocType(){} // RVA: 0x7FFAC91A9D60
        public void WriteStartElement(){} // RVA: 0x7FFAC91A9D90
        public void StartElementContent(){} // RVA: 0x7FFAC91A9F50
        public void WriteEndElement(){} // RVA: 0x7FFAC91A9FD0
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91AA160
        public void FlushBuffer(){} // RVA: 0x7FFAC91AA200
        public void Init(){} // RVA: 0x7FFAC91AA220
        public void WriteIndent(){} // RVA: 0x7FFAC91AA2B0
    }

}