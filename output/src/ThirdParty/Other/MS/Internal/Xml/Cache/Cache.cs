// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.Cache
// Classes: 6
// Methods: 56

namespace ThirdParty.Other.MS.Internal.Xml.Cache
{
    public class XPathDocumentNavigator : XPathNavigator
    {
        public MS.Internal.Xml.Cache.XPathNode[] _pageCurrent; // 0x10
        public MS.Internal.Xml.Cache.XPathNode[] _pageParent; // 0x18
        public int _idxCurrent; // 0x20
        public int _idxParent; // 0x24
        public object field_4; // 0x6B8
        public object field_5; // 0x6B9
        public object field_6; // 0x6BA
        public object field_7; // 0x6BB
        public object field_8; // 0x6BC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875509F0
        public void get_Value(){} // RVA: 0x7FFE87550B10
        public void Clone(){} // RVA: 0x7FFE87550E60
        public void get_NodeType(){} // RVA: 0x7FFE87550FC0
        public void get_LocalName(){} // RVA: 0x7FFE87551000
        public void get_NamespaceURI(){} // RVA: 0x7FFE87551040
        public void get_Prefix(){} // RVA: 0x7FFE87551080
        public void get_NameTable(){} // RVA: 0x7FFE875510C0
        public void MoveToFirstNamespace(){} // RVA: 0x7FFE87551110
        public void MoveToNextNamespace(){} // RVA: 0x7FFE87551300
        public void MoveToParent(){} // RVA: 0x7FFE87551570
        public void IsSamePosition(){} // RVA: 0x7FFE87551770
        public void get_UnderlyingObject(){} // RVA: 0x7FFE87551800
        public void HasLineInfo(){} // RVA: 0x7FFE87551820
        public void get_LineNumber(){} // RVA: 0x7FFE87551870
        public void get_LinePosition(){} // RVA: 0x7FFE875518F0
        public void GetPositionHashCode(){} // RVA: 0x7FFE87551990
    }

    public class XPathNode : ValueType
    {
        public MS.Internal.Xml.Cache.XPathNodeInfoAtom _info; // 0x10
        public ushort _idxSibling; // 0x18
        public ushort _idxParent; // 0x1A
        public ushort _idxSimilar; // 0x1C
        public ushort _posOffset; // 0x1E
        public uint _props; // 0x20
        public string _value; // 0x28
        public object field_7; // 0x6C1
        public object field_8; // 0x6C2
        public object field_9; // 0x6C3
        public object field_10; // 0x6C4
        public object field_11; // 0x6C5
        public object field_12; // 0x6C6
        public object field_13; // 0x6C7
        public object field_14; // 0x6C8

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7FFE875519A0
        public void get_Prefix(){} // RVA: 0x7FFE875519B0
        public void get_LocalName(){} // RVA: 0x7FFE86736740
        public void get_NamespaceUri(){} // RVA: 0x7FFE81D7EA60
        public void get_Document(){} // RVA: 0x7FFE81D83F40
        public void get_LineNumber(){} // RVA: 0x7FFE875519D0
        public void get_LinePosition(){} // RVA: 0x7FFE87551A00
        public void get_CollapsedLinePosition(){} // RVA: 0x7FFE87551A20
        public void get_PageInfo(){} // RVA: 0x7FFE81D7E9C0
        public void GetParent(){} // RVA: 0x7FFE87551A50
        public void GetSibling(){} // RVA: 0x7FFE87551AD0
        public void get_IsXmlNamespaceNode(){} // RVA: 0x7FFE87551B50
        public void get_HasSibling(){} // RVA: 0x7FFE87551BF0
        public void get_HasCollapsedText(){} // RVA: 0x7FFE87551C00
        public void get_IsText(){} // RVA: 0x7FFE87551C10
        public void get_HasNamespaceDecls(){} // RVA: 0x7FFE87551C70
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
    }

    public class XPathNodeHelper : Object
    {
        // ── Methods ──
        public void GetLocalNamespaces(){} // RVA: 0x7FFE87551CC0
        public void GetInScopeNamespaces(){} // RVA: 0x7FFE87551D90
        public void GetParent(){} // RVA: 0x7FFE87551F50
        public void GetLocation(){} // RVA: 0x7FFE87552080
        public void GetTextFollowing(){} // RVA: 0x7FFE875520C0
        public void GetNonDescendant(){} // RVA: 0x7FFE875522D0
    }

    public class XPathNodeInfoAtom : Object
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
        public void get_PageInfo(){} // RVA: 0x7FFE81176730
        public void get_LocalName(){} // RVA: 0x7FFE81116380
        public void get_NamespaceUri(){} // RVA: 0x7FFE810FE7C0
        public void get_Prefix(){} // RVA: 0x7FFE811290C0
        public void get_SiblingPage(){} // RVA: 0x7FFE8144E200
        public void get_ParentPage(){} // RVA: 0x7FFE81129130
        public void get_Document(){} // RVA: 0x7FFE8143BA80
        public void get_LineNumberBase(){} // RVA: 0x7FFE8119C080
        public void get_LinePositionBase(){} // RVA: 0x7FFE8119C0A0
    }

    public class XPathNodePageInfo : Object
    {
        public int _pageNum; // 0x10
        public int _nodeCount; // 0x14
        public MS.Internal.Xml.Cache.XPathNode[] _pageNext; // 0x18

        // ── Methods ──
        public void get_PageNumber(){} // RVA: 0x7FFE811485C0
        public void get_NodeCount(){} // RVA: 0x7FFE8164B230
        public void get_NextPage(){} // RVA: 0x7FFE810FE7C0
    }

    public class XPathNodeRef : ValueType
    {
        public MS.Internal.Xml.Cache.XPathNode[] _page; // 0x10
        public int _idx; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815AE520
        public void get_Page(){} // RVA: 0x7FFE8284EF60
        public void get_Index(){} // RVA: 0x7FFE82C33000
        public void GetHashCode(){} // RVA: 0x7FFE87551C80
    }

}