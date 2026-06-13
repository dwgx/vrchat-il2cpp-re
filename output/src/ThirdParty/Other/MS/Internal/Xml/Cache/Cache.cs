// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.Cache
// Classes: 6
// Methods: 56

namespace ThirdParty.Other.MS.Internal.Xml.Cache
{
    public class XPathDocumentNavigator
    {
        public MS.Internal.Xml.Cache.XPathNode[] _pageCurrent; // 0x10
        public MS.Internal.Xml.Cache.XPathNode[] _pageParent; // 0x18
        public int _idxCurrent; // 0x20
        public int _idxParent; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A116F0
        public void get_Value(){} // RVA: 0x6A11810
        public void Clone(){} // RVA: 0x6A11B60
        public void get_NodeType(){} // RVA: 0x6A11CC0
        public void get_LocalName(){} // RVA: 0x6A11D00
        public void get_NamespaceURI(){} // RVA: 0x6A11D40
        public void get_Prefix(){} // RVA: 0x6A11D80
        public void get_NameTable(){} // RVA: 0x6A11DC0
        public void MoveToFirstNamespace(){} // RVA: 0x6A11E10
        public void MoveToNextNamespace(){} // RVA: 0x6A12000
        public void MoveToParent(){} // RVA: 0x6A12270
        public void IsSamePosition(){} // RVA: 0x6A12470
        public void get_UnderlyingObject(){} // RVA: 0x6A12500
        public void HasLineInfo(){} // RVA: 0x6A12520
        public void get_LineNumber(){} // RVA: 0x6A12570
        public void get_LinePosition(){} // RVA: 0x6A125F0
        public void GetPositionHashCode(){} // RVA: 0x6A12690
    }

    public class XPathNode
    {
        public MS.Internal.Xml.Cache.XPathNodeInfoAtom Page; // 0x10
        public ushort Index; // 0x18
        public ushort GetParent; // 0x1A
        public ushort _idxSimilar; // 0x1C
        public ushort _posOffset; // 0x1E
        public uint _props; // 0x20
        public string _value; // 0x28

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x6A126A0
        public void get_Prefix(){} // RVA: 0x6A126B0
        public void get_LocalName(){} // RVA: 0x5BF58F0
        public void get_NamespaceUri(){} // RVA: 0x100A130
        public void get_Document(){} // RVA: 0x100A190
        public void get_LineNumber(){} // RVA: 0x6A126D0
        public void get_LinePosition(){} // RVA: 0x6A12700
        public void get_CollapsedLinePosition(){} // RVA: 0x6A12720
        public void get_PageInfo(){} // RVA: 0x100D8B0
        public void GetParent(){} // RVA: 0x6A12750
        public void GetSibling(){} // RVA: 0x6A127D0
        public void get_IsXmlNamespaceNode(){} // RVA: 0x6A12850
        public void get_HasSibling(){} // RVA: 0x6A128F0
        public void get_HasCollapsedText(){} // RVA: 0x6A12900
        public void get_IsText(){} // RVA: 0x6A12910
        public void get_HasNamespaceDecls(){} // RVA: 0x6A12970
        public void get_Value(){} // RVA: 0x2E07C0
    }

    public class XPathNodeHelper
    {
        // ── Methods ──
        public void GetLocalNamespaces(){} // RVA: 0x6A129C0
        public void GetInScopeNamespaces(){} // RVA: 0x6A12A90
        public void GetParent(){} // RVA: 0x6A12C50
        public void GetLocation(){} // RVA: 0x6A12D80
        public void GetTextFollowing(){} // RVA: 0x6A12DC0
        public void GetNonDescendant(){} // RVA: 0x6A12FD0
    }

    public class XPathNodeInfoAtom
    {
        public string _localName; // 0x10
        public string _namespaceUri; // 0x18
        public string _prefix; // 0x20
        public MS.Internal.Xml.Cache.XPathNode[] _pageParent; // 0x28
        public MS.Internal.Xml.Cache.XPathNode[] _pageSibling; // 0x30
        public System.Xml.XPath.XPathDocument _doc; // 0x38
        public int _lineNumBase; // 0x40
        public int _linePosBase; // 0x44
        public MS.Internal.Xml.Cache.XPathNodePageInfo _pageInfo; // 0x48

        // ── Methods ──
        public void get_PageInfo(){} // RVA: 0x358730
        public void get_LocalName(){} // RVA: 0x2F8380
        public void get_NamespaceUri(){} // RVA: 0x2E07C0
        public void get_Prefix(){} // RVA: 0x30B0C0
        public void get_SiblingPage(){} // RVA: 0x6374D0
        public void get_ParentPage(){} // RVA: 0x30B130
        public void get_Document(){} // RVA: 0x4976A0
        public void get_LineNumberBase(){} // RVA: 0x37E080
        public void get_LinePositionBase(){} // RVA: 0x37E0A0
    }

    public class XPathNodePageInfo
    {
        public int PageInfo; // 0x10
        public int LocalName; // 0x14
        public MS.Internal.Xml.Cache.XPathNode[] NamespaceUri; // 0x18

        // ── Methods ──
        public void get_PageNumber(){} // RVA: 0x32A5C0
        public void get_NodeCount(){} // RVA: 0x8ABED0
        public void get_NextPage(){} // RVA: 0x2E07C0
    }

    public class XPathNodeRef
    {
        public MS.Internal.Xml.Cache.XPathNode[] _page; // 0x10
        public int _idx; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x820840
        public void get_Page(){} // RVA: 0x1AD4690
        public void get_Index(){} // RVA: 0x1EA9890
        public void GetHashCode(){} // RVA: 0x6A12980
    }

}