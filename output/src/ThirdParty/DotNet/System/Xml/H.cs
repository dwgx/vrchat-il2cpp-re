// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 6
// Methods: 78

namespace ThirdParty.DotNet.System.Xml
{
    public class HWStack : Object
    {
        public object[] stack; // 0x10
        public int growthRate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875AD840 | overloaded x3
        public void Push(){} // RVA: 0x7FFE875AD490
        public void Pop(){} // RVA: 0x7FFE875AD610
        public void Peek(){} // RVA: 0x7FFE875AD650
        public void AddToTop(){} // RVA: 0x7FFE875AD690
        public void get_Item(){} // RVA: 0x7FFE875AD710
        public void set_Item(){} // RVA: 0x7FFE875AD790
        public void get_Length(){} // RVA: 0x7FFE82707EE0
        public void Clone(){} // RVA: 0x7FFE875AD8B0
    }

    public class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8743DEB0 | overloaded x2
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE8743DEE0
        public void WriteStartElement(){} // RVA: 0x7FFE8743E1E0
        public void StartElementContent(){} // RVA: 0x7FFE8743E3B0
        public void WriteEndElement(){} // RVA: 0x7FFE8743E410
        public void WriteFullEndElement(){} // RVA: 0x7FFE8743E560
        public void WriteStartAttribute(){} // RVA: 0x7FFE8743E6B0
        public void WriteEndAttribute(){} // RVA: 0x7FFE8743E850
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE8743E8E0
        public void WriteString(){} // RVA: 0x7FFE8743EA20
        public void WriteEntityRef(){} // RVA: 0x7FFE8743EB10
        public void WriteCharEntity(){} // RVA: 0x7FFE8743EB70
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE8743EBD0
        public void WriteChars(){} // RVA: 0x7FFE8743EC30
        public void Init(){} // RVA: 0x7FFE8743ECC0
        public void WriteMetaElement(){} // RVA: 0x7FFE8743F0C0
        public void WriteHtmlElementTextBlock(){} // RVA: 0x7FFE8743F2B0
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x7FFE8743F2D0
        public void WriteHtmlAttributeText(){} // RVA: 0x7FFE8743F320
        public void WriteUriAttributeText(){} // RVA: 0x7FFE8743F6A0
        public void OutputRestAmps(){} // RVA: 0x7FFE8743FAF0
    }

    public class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8743FC40 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE8743FCF0
        public void WriteStartElement(){} // RVA: 0x7FFE8743FD20
        public void StartElementContent(){} // RVA: 0x7FFE8743FF10
        public void WriteEndElement(){} // RVA: 0x7FFE8743FF90
        public void WriteStartAttribute(){} // RVA: 0x7FFE87440030
        public void FlushBuffer(){} // RVA: 0x7FFE874400D0
        public void Init(){} // RVA: 0x7FFE874400F0
        public void WriteIndent(){} // RVA: 0x7FFE87440180
    }

    public class HtmlTernaryTree : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87440200
    }

    public class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874403A0
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE874403D0
        public void WriteStartElement(){} // RVA: 0x7FFE874406A0
        public void StartElementContent(){} // RVA: 0x7FFE87440830
        public void WriteEndElement(){} // RVA: 0x7FFE87440880
        public void WriteFullEndElement(){} // RVA: 0x7FFE874409B0
        public void WriteStartAttribute(){} // RVA: 0x7FFE87440AE0
        public void WriteEndAttribute(){} // RVA: 0x7FFE87440C60
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE87440CD0
        public void WriteString(){} // RVA: 0x7FFE87440DE0
        public void WriteEntityRef(){} // RVA: 0x7FFE87440E80
        public void WriteCharEntity(){} // RVA: 0x7FFE87440EE0
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87440F40
        public void WriteChars(){} // RVA: 0x7FFE87440FA0
        public void Init(){} // RVA: 0x7FFE87440FF0
        public void WriteMetaElement(){} // RVA: 0x7FFE874413F0
        public void WriteHtmlElementTextBlock(){} // RVA: 0x7FFE874415E0
        public void WriteHtmlAttributeTextBlock(){} // RVA: 0x7FFE87441600
        public void WriteHtmlAttributeText(){} // RVA: 0x7FFE87441650
        public void WriteUriAttributeText(){} // RVA: 0x7FFE87441940
        public void OutputRestAmps(){} // RVA: 0x7FFE87441D20
    }

    public class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87552460
        public void WriteDocType(){} // RVA: 0x7FFE87552510
        public void WriteStartElement(){} // RVA: 0x7FFE87552540
        public void StartElementContent(){} // RVA: 0x7FFE87552700
        public void WriteEndElement(){} // RVA: 0x7FFE87552780
        public void WriteStartAttribute(){} // RVA: 0x7FFE87552910
        public void FlushBuffer(){} // RVA: 0x7FFE875529B0
        public void Init(){} // RVA: 0x7FFE875529D0
        public void WriteIndent(){} // RVA: 0x7FFE87552A60
    }

}