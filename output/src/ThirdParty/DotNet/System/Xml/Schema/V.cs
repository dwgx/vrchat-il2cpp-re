// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 7

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ValidationEventArgs : EventArgs
    {
        public System.Xml.Schema.XmlSchemaException Severity; // 0x10
        public 0x6B165578 Exception; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9124E00 | overloaded x2
        public void get_Severity(){} // RVA: 0x7FFAC3157800
        public void get_Exception(){} // RVA: 0x7FFAC2F3C380
    }

    public class ValidationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class ValidationState : Object
    {
        public bool IsNill; // 0x10
        public bool IsDefault; // 0x11
        public bool NeedValidateChildren; // 0x12
        public bool CheckRequiredAttribute; // 0x13
        public bool ValidationSkipped; // 0x14
        public 0x6B163D68 ProcessContents; // 0x18
        public 0x6B165520 Validity; // 0x1C
        public System.Xml.Schema.SchemaElementDecl ElementDecl; // 0x20
        public System.Xml.Schema.SchemaElementDecl ElementDeclBeforeXsi; // 0x28
        public string LocalName; // 0x30
        public string Namespace; // 0x38
        public System.Xml.Schema.ConstraintStruct[] Constr; // 0x40
        public System.Xml.Schema.StateUnion CurrentState; // 0x48
        public bool HasMatched; // 0x4C
        public System.Xml.Schema.BitSet[] CurPos; // 0x50
        public System.Xml.Schema.BitSet AllElementsSet; // 0x58
        public System.Collections.Generic.List`1<System.Xml.Schema.RangePositionInfo> RunningPositions; // 0x60
        public bool TooComplex; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9124EC0
    }

}