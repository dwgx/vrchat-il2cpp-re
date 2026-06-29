// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 6

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ValidationEventArgs : EventArgs
    {
        public object ex;
        public object severity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73F3CD0
        public void get_Severity(){} // RVA: 0xE62D00
        public void get_Exception(){} // RVA: 0xB5DBF0
    }

    public class ValidationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ValidationState : Object
    {
        public object IsNill;
        public object IsDefault;
        public object NeedValidateChildren;
        public object CheckRequiredAttribute;
        public object ValidationSkipped;
        public object ProcessContents;
        public object Validity;
        public object ElementDecl;
        public object ElementDeclBeforeXsi;
        public object LocalName;
        public object Namespace;
        public object Constr;
        public object CurrentState;
        public object HasMatched;
        public object CurPos;
        public object AllElementsSet;
        public object RunningPositions;
        public object TooComplex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73F3D90
    }

}