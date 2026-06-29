// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.Cache
// Classes: 6
// Methods: 56

namespace ThirdParty.Other.MS.Internal.Xml.Cache
{
    public class XPathDocumentNavigator : XPathNavigator
    {
        public object _pageCurrent;
        public object _pageParent;
        public object _idxCurrent;
        public object _idxParent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7476FF0
        public void get_Value(){} // RVA: 0x7477110
        public void Clone(){} // RVA: 0x7477450
        public void get_NodeType(){} // RVA: 0x74775B0
        public void get_LocalName(){} // RVA: 0x74775F0
        public void get_NamespaceURI(){} // RVA: 0x7477630
        public void get_Prefix(){} // RVA: 0x7477670
        public void get_NameTable(){} // RVA: 0x74776B0
        public void MoveToFirstNamespace(){} // RVA: 0x7477700
        public void MoveToNextNamespace(){} // RVA: 0x7477900
        public void MoveToParent(){} // RVA: 0x7477B80
        public void IsSamePosition(){} // RVA: 0x7477D70
        public void get_UnderlyingObject(){} // RVA: 0x7477E00
        public void HasLineInfo(){} // RVA: 0x7477E20
        public void get_LineNumber(){} // RVA: 0x7477E70
        public void get_LinePosition(){} // RVA: 0x7477EF0
        public void GetPositionHashCode(){} // RVA: 0x7477F90
    }

    public class XPathNode : ValueType
    {
        public object _info;
        public object _idxSibling;
        public object _idxParent;
        public object _idxSimilar;
        public object _posOffset;
        public object _props;
        public object _value;

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x914B50
        public void get_Prefix(){} // RVA: 0x914B60
        public void get_LocalName(){} // RVA: 0x8AB500
        public void get_NamespaceUri(){} // RVA: 0x4FA80
        public void get_Document(){} // RVA: 0x4F830
        public void get_LineNumber(){} // RVA: 0x914B80
        public void get_LinePosition(){} // RVA: 0x914BB0
        public void get_CollapsedLinePosition(){} // RVA: 0x914BD0
        public void get_PageInfo(){} // RVA: 0x4F790
        public void GetParent(){} // RVA: 0x914C00
        public void GetSibling(){} // RVA: 0x914C10
        public void get_IsXmlNamespaceNode(){} // RVA: 0x914C20
        public void get_HasSibling(){} // RVA: 0x914C30
        public void get_HasCollapsedText(){} // RVA: 0x914C40
        public void get_IsText(){} // RVA: 0x914C50
        public void get_HasNamespaceDecls(){} // RVA: 0x914CB0
        public void get_Value(){} // RVA: 0x931A0
    }

    public class XPathNodeHelper : Object
    {
        // ── Methods ──
        public void GetLocalNamespaces(){} // RVA: 0x74782C0
        public void GetInScopeNamespaces(){} // RVA: 0x7478390
        public void GetParent(){} // RVA: 0x7478550
        public void GetLocation(){} // RVA: 0x7478680
        public void GetTextFollowing(){} // RVA: 0x74786C0
        public void GetNonDescendant(){} // RVA: 0x74788C0
    }

    public class XPathNodeInfoAtom : Object
    {
        public object _localName;
        public object _namespaceUri;
        public object _prefix;
        public object _pageParent;
        public object _pageSibling;
        public object _doc;
        public object _lineNumBase;
        public object _linePosBase;
        public object _pageInfo;

        // ── Methods ──
        public void get_PageInfo(){} // RVA: 0xBBF8F0
        public void get_LocalName(){} // RVA: 0xB5DBF0
        public void get_NamespaceUri(){} // RVA: 0xB465B0
        public void get_Prefix(){} // RVA: 0xB700F0
        public void get_SiblingPage(){} // RVA: 0xD33E60
        public void get_ParentPage(){} // RVA: 0xB70160
        public void get_Document(){} // RVA: 0xD05CA0
        public void get_LineNumberBase(){} // RVA: 0xBE5850
        public void get_LinePositionBase(){} // RVA: 0xBE5870
    }

    public class XPathNodePageInfo : Object
    {
        public object _pageNum;
        public object _nodeCount;
        public object _pageNext;

        // ── Methods ──
        public void get_PageNumber(){} // RVA: 0xB8F8F0
        public void get_NodeCount(){} // RVA: 0x116A650
        public void get_NextPage(){} // RVA: 0xB465B0
    }

    public class XPathNodeRef : ValueType
    {
        public object _page;
        public object _idx;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void get_Page(){} // RVA: 0x77900
        public void get_Index(){} // RVA: 0x14790
        public void GetHashCode(){} // RVA: 0x914D80
    }

}