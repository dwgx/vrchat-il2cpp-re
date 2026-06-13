// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 6
// Methods: 78

namespace ThirdParty.DotNet.System.Xml
{
    public class HWStack
    {
        public object[] stack; // 0x10
        public int growthRate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A6E550 | overloaded x3
        public void Push(){} // RVA: 0x6A6E1A0
        public void Pop(){} // RVA: 0x6A6E320
        public void Peek(){} // RVA: 0x6A6E360
        public void AddToTop(){} // RVA: 0x6A6E3A0
        public void get_Item(){} // RVA: 0x6A6E420
        public void set_Item(){} // RVA: 0x6A6E4A0
        public void get_Length(){} // RVA: 0x197C3B0
        public void Clone(){} // RVA: 0x6A6E5C0
    }

    public class HtmlEncodedRawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68FEBE0 | overloaded x2
        public void WriteXmlDeclaration(){} // RVA: 0x2DD310 | overloaded x2
        public void WriteDocType(){} // RVA: 0x68FEC10
        public void WriteStartElement(){} // RVA: 0x68FEF10
        public void StartElementContent(){} // RVA: 0x68FF0E0
        public void WriteEndElement(){} // RVA: 0x68FF140
        public void WriteFullEndElement(){} // RVA: 0x68FF290
        public void WriteStartAttribute(){} // RVA: 0x68FF3E0
        public void WriteEndAttribute(){} // RVA: 0x68FF580
        public void WriteProcessingInstruction(){} // RVA: 0x68FF610
        public void WriteString(){} // RVA: 0x68FF750
        public void WriteEntityRef(){} // RVA: 0x68FF840
        public void WriteCharEntity(){} // RVA: 0x68FF8A0
        public void WriteSurrogateCharEntity(){} // RVA: 0x68FF900
        public void WriteChars(){} // RVA: 0x68FF960
        public void Init(){} // RVA: 0x68FF9F0
        public void WriteMetaElement(){} // RVA: 0x68FFDF0
        public void WriteHtmlElementTextBlock(){} // RVA: 0x68FFFE0
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x6900000
        public void WriteHtmlAttributeText(){} // RVA: 0x6900050
        public void WriteUriAttributeText(){} // RVA: 0x69003D0
        public void OutputRestAmps(){} // RVA: 0x6900820
    }

    public class HtmlEncodedRawTextWriterIndent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6900970 | overloaded x2
        public void WriteDocType(){} // RVA: 0x6900A20
        public void WriteStartElement(){} // RVA: 0x6900A50
        public void StartElementContent(){} // RVA: 0x6900C40
        public void WriteEndElement(){} // RVA: 0x6900CC0
        public void WriteStartAttribute(){} // RVA: 0x6900D60
        public void FlushBuffer(){} // RVA: 0x6900E00
        public void Init(){} // RVA: 0x6900E20
        public void WriteIndent(){} // RVA: 0x6900EB0
    }

    public class HtmlTernaryTree
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6900F30
    }

    public class HtmlUtf8RawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69010D0
        public void WriteXmlDeclaration(){} // RVA: 0x2DD310 | overloaded x2
        public void WriteDocType(){} // RVA: 0x6901100
        public void WriteStartElement(){} // RVA: 0x69013D0
        public void StartElementContent(){} // RVA: 0x6901560
        public void WriteEndElement(){} // RVA: 0x69015B0
        public void WriteFullEndElement(){} // RVA: 0x69016E0
        public void WriteStartAttribute(){} // RVA: 0x6901810
        public void WriteEndAttribute(){} // RVA: 0x6901990
        public void WriteProcessingInstruction(){} // RVA: 0x6901A00
        public void WriteString(){} // RVA: 0x6901B10
        public void WriteEntityRef(){} // RVA: 0x6901BB0
        public void WriteCharEntity(){} // RVA: 0x6901C10
        public void WriteSurrogateCharEntity(){} // RVA: 0x6901C70
        public void WriteChars(){} // RVA: 0x6901CD0
        public void Init(){} // RVA: 0x6901D20
        public void WriteMetaElement(){} // RVA: 0x6902120
        public void WriteHtmlElementTextBlock(){} // RVA: 0x6902310
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x6902330
        public void WriteHtmlAttributeText(){} // RVA: 0x6902380
        public void WriteUriAttributeText(){} // RVA: 0x6902670
        public void OutputRestAmps(){} // RVA: 0x6902A50
    }

    public class HtmlUtf8RawTextWriterIndent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A13160
        public void WriteDocType(){} // RVA: 0x6A13210
        public void WriteStartElement(){} // RVA: 0x6A13240
        public void StartElementContent(){} // RVA: 0x6A13400
        public void WriteEndElement(){} // RVA: 0x6A13480
        public void WriteStartAttribute(){} // RVA: 0x6A13610
        public void FlushBuffer(){} // RVA: 0x6A136B0
        public void Init(){} // RVA: 0x6A136D0
        public void WriteIndent(){} // RVA: 0x6A13760
    }

}