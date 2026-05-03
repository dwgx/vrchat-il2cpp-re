// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 1
// Methods: 30

namespace ThirdParty.DotNet.System.Xml
{
    public class QueryOutputWriter : XmlRawWriter
    {
        public System.Xml.XmlRawWriter wrapped; // 0x28
        public bool inCDataSection; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87552AF0
        public void set_NamespaceResolver(){} // RVA: 0x7FFE87552FE0
        public void WriteXmlDeclaration(){} // RVA: 0x7FFE87553090 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFE875530C0
        public void WriteStartElement(){} // RVA: 0x7FFE87553110
        public void WriteEndElement(){} // RVA: 0x7FFE87553320
        public void WriteFullEndElement(){} // RVA: 0x7FFE875533C0
        public void StartElementContent(){} // RVA: 0x7FFE87553460
        public void WriteStartAttribute(){} // RVA: 0x7FFE87553490
        public void WriteEndAttribute(){} // RVA: 0x7FFE875534D0
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFE87553500
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFE87553530
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFE87553560
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFE87553590
        public void WriteCData(){} // RVA: 0x7FFE875535C0
        public void WriteComment(){} // RVA: 0x7FFE875535F0
        public void WriteProcessingInstruction(){} // RVA: 0x7FFE87553620
        public void WriteWhitespace(){} // RVA: 0x7FFE87553650
        public void WriteString(){} // RVA: 0x7FFE875536D0
        public void WriteChars(){} // RVA: 0x7FFE87553750
        public void WriteEntityRef(){} // RVA: 0x7FFE87553810
        public void WriteCharEntity(){} // RVA: 0x7FFE87553840
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE87553870
        public void WriteRaw(){} // RVA: 0x7FFE87553960 | overloaded x2
        public void Close(){} // RVA: 0x7FFE875539E0
        public void Flush(){} // RVA: 0x7FFE87553A90
        public void StartCDataSection(){} // RVA: 0x7FFE87553AC0
        public void EndCDataSection(){} // RVA: 0x7FFE8143BA90
    }

}