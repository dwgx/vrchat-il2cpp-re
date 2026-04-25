// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 38

namespace ThirdParty.DotNet.System.Xml
{
    public class ValidateNames : Object
    {
        public System.Xml.XmlCharType xmlCharType;

        // ── Methods ──
        public void ParseNmtoken(){} // RVA: 0x7FFAC9212F10
        public void ParseNmtokenNoNamespaces(){} // RVA: 0x7FFAC9212FF0
        public void ParseNameNoNamespaces(){} // RVA: 0x7FFAC92130D0
        public void IsNameNoNamespaces(){} // RVA: 0x7FFAC9213220
        public void ParseNCName(){} // RVA: 0x7FFAC92133D0 | overloaded x2
        public void ParseQName(){} // RVA: 0x7FFAC9213430
        public void ParseQNameThrow(){} // RVA: 0x7FFAC9213520
        public void ThrowInvalidName(){} // RVA: 0x7FFAC92136E0
        public void GetInvalidNameException(){} // RVA: 0x7FFAC92138D0
        public void SplitQName(){} // RVA: 0x7FFAC9213B90
        public void .cctor(){} // RVA: 0x7FFAC9213D90
    }

    public class ValidatingReaderNodeData : Object
    {
        public string LocalName; // 0x10
        public string Namespace; // 0x18
        public string Prefix; // 0x20
        public string Depth; // 0x28
        public string RawValue; // 0x30
        public string OriginalStringValue; // 0x38
        public int NodeType; // 0x40
        public System.Xml.AttributePSVIInfo AttInfo; // 0x48
        public 0x6B15D5F0 LineNumber; // 0x50
        public int LinePosition; // 0x54
        public int linePos; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91AC150 | overloaded x2
        public void get_LocalName(){} // RVA: 0x7FFAC2F3C380
        public void set_LocalName(){} // RVA: 0x7FFAC2F22E30
        public void get_Namespace(){} // RVA: 0x7FFAC2F247C0
        public void set_Namespace(){} // RVA: 0x7FFAC2F87E80
        public void get_Prefix(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Prefix(){} // RVA: 0x7FFAC2F4F0D0
        public void GetAtomizedNameWPrefix(){} // RVA: 0x7FFAC91AC160
        public void get_Depth(){} // RVA: 0x7FFAC2FC2080
        public void set_Depth(){} // RVA: 0x7FFAC2FC2090
        public void get_RawValue(){} // RVA: 0x7FFAC31D95E0
        public void set_RawValue(){} // RVA: 0x7FFAC2F4F890
        public void get_OriginalStringValue(){} // RVA: 0x7FFAC31D0140
        public void get_NodeType(){} // RVA: 0x7FFAC30F10E0
        public void set_NodeType(){} // RVA: 0x7FFAC31D9010
        public void get_AttInfo(){} // RVA: 0x7FFAC2F9C730
        public void set_AttInfo(){} // RVA: 0x7FFAC2F9C740
        public void get_LineNumber(){} // RVA: 0x7FFAC38913D0
        public void get_LinePosition(){} // RVA: 0x7FFAC362EA40
        public void Clear(){} // RVA: 0x7FFAC91AC2C0
        public void SetLineInfo(){} // RVA: 0x7FFAC91AC500 | overloaded x2
        public void SetItemData(){} // RVA: 0x7FFAC91AC740 | overloaded x3
    }

}