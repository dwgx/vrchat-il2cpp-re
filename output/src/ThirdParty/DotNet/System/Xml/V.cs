// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 38

namespace ThirdParty.DotNet.System.Xml
{
    public class ValidateNames : Object
    {
        // ── Methods ──
        public void ParseNmtoken(){} // RVA: 0x7FFE875BB680
        public void ParseNmtokenNoNamespaces(){} // RVA: 0x7FFE875BB760
        public void ParseNameNoNamespaces(){} // RVA: 0x7FFE875BB840
        public void IsNameNoNamespaces(){} // RVA: 0x7FFE875BB990
        public void ParseNCName(){} // RVA: 0x7FFE875BBB40 | overloaded x2
        public void ParseQName(){} // RVA: 0x7FFE875BBBA0
        public void ParseQNameThrow(){} // RVA: 0x7FFE875BBC90
        public void ThrowInvalidName(){} // RVA: 0x7FFE875BBE50
        public void GetInvalidNameException(){} // RVA: 0x7FFE875BC040
        public void SplitQName(){} // RVA: 0x7FFE875BC300
        public void .cctor(){} // RVA: 0x7FFE875BC500
    }

    public class ValidatingReaderNodeData : Object
    {
        public string localName; // 0x10
        public string namespaceUri; // 0x18
        public string prefix; // 0x20
        public string nameWPrefix; // 0x28
        public string rawValue; // 0x30
        public string originalStringValue; // 0x38
        public int depth; // 0x40
        public System.Xml.AttributePSVIInfo attributePSVIInfo; // 0x48
        public 0x66556674 nodeType; // 0x50
        public int lineNo; // 0x54

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87554900 | overloaded x2
        public void get_LocalName(){} // RVA: 0x7FFE81116380
        public void set_LocalName(){} // RVA: 0x7FFE810FCE30
        public void get_Namespace(){} // RVA: 0x7FFE810FE7C0
        public void set_Namespace(){} // RVA: 0x7FFE81161E80
        public void get_Prefix(){} // RVA: 0x7FFE811290C0
        public void set_Prefix(){} // RVA: 0x7FFE811290D0
        public void GetAtomizedNameWPrefix(){} // RVA: 0x7FFE87554910
        public void get_Depth(){} // RVA: 0x7FFE8119C080
        public void set_Depth(){} // RVA: 0x7FFE8119C090
        public void get_RawValue(){} // RVA: 0x7FFE8144E200
        public void set_RawValue(){} // RVA: 0x7FFE81129890
        public void get_OriginalStringValue(){} // RVA: 0x7FFE8143BA80
        public void get_NodeType(){} // RVA: 0x7FFE8139DAD0
        public void set_NodeType(){} // RVA: 0x7FFE81463B00
        public void get_AttInfo(){} // RVA: 0x7FFE81176730
        public void set_AttInfo(){} // RVA: 0x7FFE81176740
        public void get_LineNumber(){} // RVA: 0x7FFE819EA920
        public void get_LinePosition(){} // RVA: 0x7FFE8175AC90
        public void Clear(){} // RVA: 0x7FFE87554A70
        public void SetLineInfo(){} // RVA: 0x7FFE87554CB0 | overloaded x2
        public void SetItemData(){} // RVA: 0x7FFE87554EF0 | overloaded x3
    }

}