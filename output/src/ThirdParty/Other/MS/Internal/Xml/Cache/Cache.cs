// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.Cache
// Classes: 6
// Methods: 56

namespace ThirdParty.Other.MS.Internal.Xml.Cache
{
    public class XPathDocumentNavigator : XPathNavigator
    {
        public MS.Internal.Xml.Cache.XPathNode[] Value; // 0x10
        public MS.Internal.Xml.Cache.XPathNode[] NodeType; // 0x18
        public int LocalName; // 0x20
        public int NamespaceURI; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A8240
        public void get_Value(){} // RVA: 0x7FFAC91A8360
        public void Clone(){} // RVA: 0x7FFAC91A86B0
        public void get_NodeType(){} // RVA: 0x7FFAC91A8810
        public void get_LocalName(){} // RVA: 0x7FFAC91A8850
        public void get_NamespaceURI(){} // RVA: 0x7FFAC91A8890
        public void get_Prefix(){} // RVA: 0x7FFAC91A88D0
        public void get_NameTable(){} // RVA: 0x7FFAC91A8910
        public void MoveToFirstNamespace(){} // RVA: 0x7FFAC91A8960
        public void MoveToNextNamespace(){} // RVA: 0x7FFAC91A8B50
        public void MoveToParent(){} // RVA: 0x7FFAC91A8DC0
        public void IsSamePosition(){} // RVA: 0x7FFAC91A8FC0
        public void get_UnderlyingObject(){} // RVA: 0x7FFAC91A9050
        public void HasLineInfo(){} // RVA: 0x7FFAC91A9070
        public void get_LineNumber(){} // RVA: 0x7FFAC91A90C0
        public void get_LinePosition(){} // RVA: 0x7FFAC91A9140
        public void GetPositionHashCode(){} // RVA: 0x7FFAC91A91E0
    }

    public class XPathNode : ValueType
    {
        public MS.Internal.Xml.Cache.XPathNodeInfoAtom NodeType; // 0x10
        public ushort Prefix; // 0x18
        public ushort LocalName; // 0x1A
        public ushort NamespaceUri; // 0x1C
        public ushort Document; // 0x1E
        public uint LineNumber; // 0x20
        public string LinePosition; // 0x28

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7FFAC91A91F0
        public void get_Prefix(){} // RVA: 0x7FFAC91A9200
        public void get_LocalName(){} // RVA: 0x7FFAC838CE40
        public void get_NamespaceUri(){} // RVA: 0x7FFAC38DCA70
        public void get_Document(){} // RVA: 0x7FFAC38DFEA0
        public void get_LineNumber(){} // RVA: 0x7FFAC91A9220
        public void get_LinePosition(){} // RVA: 0x7FFAC91A9250
        public void get_CollapsedLinePosition(){} // RVA: 0x7FFAC91A9270
        public void get_PageInfo(){} // RVA: 0x7FFAC38DC990
        public void GetParent(){} // RVA: 0x7FFAC91A92A0
        public void GetSibling(){} // RVA: 0x7FFAC91A9320
        public void get_IsXmlNamespaceNode(){} // RVA: 0x7FFAC91A93A0
        public void get_HasSibling(){} // RVA: 0x7FFAC91A9440
        public void get_HasCollapsedText(){} // RVA: 0x7FFAC91A9450
        public void get_IsText(){} // RVA: 0x7FFAC91A9460
        public void get_HasNamespaceDecls(){} // RVA: 0x7FFAC91A94C0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
    }

    public class XPathNodeHelper : Object
    {
        // ── Methods ──
        public void GetLocalNamespaces(){} // RVA: 0x7FFAC91A9510
        public void GetInScopeNamespaces(){} // RVA: 0x7FFAC91A95E0
        public void GetParent(){} // RVA: 0x7FFAC91A97A0
        public void GetLocation(){} // RVA: 0x7FFAC91A98D0
        public void GetTextFollowing(){} // RVA: 0x7FFAC91A9910
        public void GetNonDescendant(){} // RVA: 0x7FFAC91A9B20
    }

    public class XPathNodeInfoAtom : Object
    {
        public string PageInfo; // 0x10
        public string LocalName; // 0x18
        public string NamespaceUri; // 0x20
        public MS.Internal.Xml.Cache.XPathNode[] Prefix; // 0x28
        public MS.Internal.Xml.Cache.XPathNode[] SiblingPage; // 0x30
        public System.Xml.XPath.XPathDocument ParentPage; // 0x38
        public int Document; // 0x40
        public int LineNumberBase; // 0x44
        public MS.Internal.Xml.Cache.XPathNodePageInfo LinePositionBase; // 0x48

        // ── Methods ──
        public void get_PageInfo(){} // RVA: 0x7FFAC2F9C730
        public void get_LocalName(){} // RVA: 0x7FFAC2F3C380
        public void get_NamespaceUri(){} // RVA: 0x7FFAC2F247C0
        public void get_Prefix(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SiblingPage(){} // RVA: 0x7FFAC31D95E0
        public void get_ParentPage(){} // RVA: 0x7FFAC2F4F130
        public void get_Document(){} // RVA: 0x7FFAC31D0140
        public void get_LineNumberBase(){} // RVA: 0x7FFAC2FC2080
        public void get_LinePositionBase(){} // RVA: 0x7FFAC2FC20A0
    }

    public class XPathNodePageInfo : Object
    {
        public int PageNumber; // 0x10
        public int NodeCount; // 0x14
        public MS.Internal.Xml.Cache.XPathNode[] NextPage; // 0x18

        // ── Methods ──
        public void get_PageNumber(){} // RVA: 0x7FFAC2F6E5C0
        public void get_NodeCount(){} // RVA: 0x7FFAC33D5A20
        public void get_NextPage(){} // RVA: 0x7FFAC2F247C0
    }

    public class XPathNodeRef : ValueType
    {
        public MS.Internal.Xml.Cache.XPathNode[] Page; // 0x10
        public int Index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC335C3C0
        public void get_Page(){} // RVA: 0x7FFAC3AD9F60
        public void get_Index(){} // RVA: 0x7FFAC49C7500
        public void GetHashCode(){} // RVA: 0x7FFAC91A94D0
    }

}