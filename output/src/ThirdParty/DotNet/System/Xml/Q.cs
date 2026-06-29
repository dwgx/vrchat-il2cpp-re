// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 1
// Methods: 28

namespace ThirdParty.DotNet.System.Xml
{
    public class QueryOutputWriter : XmlRawWriter
    {
        public object wrapped;
        public object inCDataSection;
        public object lookupCDataElems;
        public object bitsCData;
        public object qnameCData;
        public object outputDocType;
        public object checkWellFormedDoc;
        public object hasDocElem;
        public object inAttr;
        public object systemId;
        public object publicId;
        public object depth;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74790F0
        public void set_NamespaceResolver(){} // RVA: 0x74795E0
        public void WriteXmlDeclaration(){} // RVA: 0x7479690
        public void WriteDocType(){} // RVA: 0x74796C0
        public void WriteStartElement(){} // RVA: 0x7479710
        public void WriteEndElement(){} // RVA: 0x7479920
        public void WriteFullEndElement(){} // RVA: 0x74799C0
        public void StartElementContent(){} // RVA: 0x7479A60
        public void WriteStartAttribute(){} // RVA: 0x7479A90
        public void WriteEndAttribute(){} // RVA: 0x7479AD0
        public void WriteNamespaceDeclaration(){} // RVA: 0x7479B00
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7479B30
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7479B60
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7479B90
        public void WriteCData(){} // RVA: 0x7479BC0
        public void WriteComment(){} // RVA: 0x7479BF0
        public void WriteProcessingInstruction(){} // RVA: 0x7479C20
        public void WriteWhitespace(){} // RVA: 0x7479C50
        public void WriteString(){} // RVA: 0x7479CD0
        public void WriteChars(){} // RVA: 0x7479D50
        public void WriteEntityRef(){} // RVA: 0x7479E10
        public void WriteCharEntity(){} // RVA: 0x7479E40
        public void WriteSurrogateCharEntity(){} // RVA: 0x7479E70
        public void WriteRaw(){} // RVA: 0x7479F60
        public void Close(){} // RVA: 0x7479FE0
        public void Flush(){} // RVA: 0x747A090
        public void StartCDataSection(){} // RVA: 0x747A0C0
        public void EndCDataSection(){} // RVA: 0xEAFB80
    }

}