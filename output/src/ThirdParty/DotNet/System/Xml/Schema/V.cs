// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 7

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ValidationEventArgs : EventArgs
    {
        public System.Xml.Schema.XmlSchemaException ex; // 0x10
        public 0x6655E5FC severity; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874CD5B0 | overloaded x2
        public void get_Severity(){} // RVA: 0x7FFE813DB630
        public void get_Exception(){} // RVA: 0x7FFE81116380
    }

    public class ValidationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class ValidationState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874CD670
    }

}