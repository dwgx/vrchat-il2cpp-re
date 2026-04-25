// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 1
// Methods: 30

namespace ThirdParty.DotNet.System.Xml
{
    public class QueryOutputWriter : XmlRawWriter
    {
        public System.Xml.XmlRawWriter NamespaceResolver; // 0x28
        public bool SupportsNamespaceDeclarationInChunks; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,int> lookupCDataElems; // 0x38
        public System.Xml.BitStack bitsCData; // 0x40
        public System.Xml.XmlQualifiedName qnameCData; // 0x48
        public bool outputDocType; // 0x50
        public bool checkWellFormedDoc; // 0x51
        public bool hasDocElem; // 0x52
        public bool inAttr; // 0x53
        public string systemId; // 0x58
        public string publicId; // 0x60
        public int depth; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91AA340
        public void set_NamespaceResolver(){} // RVA: 0x7FFAC91AA830
        public void WriteXmlDeclaration(){} // RVA: 0x7FFAC91AA8E0 | overloaded x2
        public void WriteDocType(){} // RVA: 0x7FFAC91AA910
        public void WriteStartElement(){} // RVA: 0x7FFAC91AA960
        public void WriteEndElement(){} // RVA: 0x7FFAC91AAB70
        public void WriteFullEndElement(){} // RVA: 0x7FFAC91AAC10
        public void StartElementContent(){} // RVA: 0x7FFAC91AACB0
        public void WriteStartAttribute(){} // RVA: 0x7FFAC91AACE0
        public void WriteEndAttribute(){} // RVA: 0x7FFAC91AAD20
        public void WriteNamespaceDeclaration(){} // RVA: 0x7FFAC91AAD50
        public void get_SupportsNamespaceDeclarationInChunks(){} // RVA: 0x7FFAC91AAD80
        public void WriteStartNamespaceDeclaration(){} // RVA: 0x7FFAC91AADB0
        public void WriteEndNamespaceDeclaration(){} // RVA: 0x7FFAC91AADE0
        public void WriteCData(){} // RVA: 0x7FFAC91AAE10
        public void WriteComment(){} // RVA: 0x7FFAC91AAE40
        public void WriteProcessingInstruction(){} // RVA: 0x7FFAC91AAE70
        public void WriteWhitespace(){} // RVA: 0x7FFAC91AAEA0
        public void WriteString(){} // RVA: 0x7FFAC91AAF20
        public void WriteChars(){} // RVA: 0x7FFAC91AAFA0
        public void WriteEntityRef(){} // RVA: 0x7FFAC91AB060
        public void WriteCharEntity(){} // RVA: 0x7FFAC91AB090
        public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91AB0C0
        public void WriteRaw(){} // RVA: 0x7FFAC91AB1B0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC91AB230
        public void Flush(){} // RVA: 0x7FFAC91AB2E0
        public void StartCDataSection(){} // RVA: 0x7FFAC91AB310
        public void EndCDataSection(){} // RVA: 0x7FFAC4269BB0
    }

}