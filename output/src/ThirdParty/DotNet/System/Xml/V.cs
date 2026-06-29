// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 33

namespace ThirdParty.DotNet.System.Xml
{
    public class ValidateNames : Object
    {
        public object xmlCharType;

        // ── Methods ──
        public void ParseNmtoken(){} // RVA: 0x74E1610
        public void ParseNmtokenNoNamespaces(){} // RVA: 0x74E16F0
        public void ParseNameNoNamespaces(){} // RVA: 0x74E17D0
        public void IsNameNoNamespaces(){} // RVA: 0x74E1920
        public void ParseNCName(){} // RVA: 0x74E1AD0
        public void ParseQName(){} // RVA: 0x74E1B30
        public void ParseQNameThrow(){} // RVA: 0x74E1C20
        public void ThrowInvalidName(){} // RVA: 0x74E1DE0
        public void GetInvalidNameException(){} // RVA: 0x74E1FD0
        public void SplitQName(){} // RVA: 0x74E2280
        public void .cctor(){} // RVA: 0x74E2460
    }

    public class ValidatingReaderNodeData : Object
    {
        public object localName;
        public object namespaceUri;
        public object prefix;
        public object nameWPrefix;
        public object rawValue;
        public object originalStringValue;
        public object depth;
        public object attributePSVIInfo;
        public object nodeType;
        public object lineNo;
        public object linePos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747AEE0
        public void get_LocalName(){} // RVA: 0xB5DBF0
        public void set_LocalName(){} // RVA: 0xB44D60
        public void get_Namespace(){} // RVA: 0xB465B0
        public void set_Namespace(){} // RVA: 0xBA9BA0
        public void get_Prefix(){} // RVA: 0xB700F0
        public void set_Prefix(){} // RVA: 0xB70100
        public void GetAtomizedNameWPrefix(){} // RVA: 0x747AEF0
        public void get_Depth(){} // RVA: 0xBE5850
        public void set_Depth(){} // RVA: 0xBE5860
        public void get_RawValue(){} // RVA: 0xD33E60
        public void set_RawValue(){} // RVA: 0xB708C0
        public void get_OriginalStringValue(){} // RVA: 0xD05CA0
        public void get_NodeType(){} // RVA: 0xE32C80
        public void set_NodeType(){} // RVA: 0xEEA060
        public void get_AttInfo(){} // RVA: 0xBBF8F0
        public void set_AttInfo(){} // RVA: 0xBBF900
        public void get_LineNumber(){} // RVA: 0x15443F0
        public void get_LinePosition(){} // RVA: 0x12BB630
        public void Clear(){} // RVA: 0x747B050
        public void SetLineInfo(){} // RVA: 0x747B270
        public void SetItemData(){} // RVA: 0x747B460
    }

}