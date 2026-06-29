// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.XPath
// Classes: 5
// Methods: 53

namespace ThirdParty.DotNet.System.Xml.XPath
{
    public class XPathDocument : Object
    {
        public object pageXmlNmsp;
        public object idxXmlNmsp;
        public object nameTable;
        public object hasLineInfo;
        public object mapNmsp;

        // ── Methods ──
        public void get_NameTable(){} // RVA: 0xB700F0
        public void get_HasLineInfo(){} // RVA: 0xF73960
        public void GetXmlNamespaceNode(){} // RVA: 0x74F69E0
        public void LookupNamespaces(){} // RVA: 0x74F6A40
    }

    public class XPathException : SystemException
    {
        public object res;
        public object args;
        public object message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F7B40
        public void GetObjectData(){} // RVA: 0x74F7180
        public void Create(){} // RVA: 0x74F7A50
        public void CreateMessage(){} // RVA: 0x74F7C50
        public void get_Message(){} // RVA: 0x74F7D00
    }

    public class XPathItem : Object
    {
        // ── Methods ──
        public void get_XmlType(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0x87C0A0
        public void get_TypedValue(){} // RVA: 0x87C0A0
        public void get_ValueType(){} // RVA: 0x87C0A0
        public void get_ValueAsBoolean(){} // RVA: 0x87D280
        public void get_ValueAsDateTime(){} // RVA: 0x87C0A0
        public void get_ValueAsDouble(){} // RVA: 0x8820E0
        public void get_ValueAsInt(){} // RVA: 0x87C130
        public void get_ValueAsLong(){} // RVA: 0x87C0A0
        public void ValueAs(){} // RVA: 0x87C5F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XPathNavigator : XPathItem
    {
        public object comparer;
        public object NodeTypeLetter;
        public object UniqueIdTbl;
        public object ContentKindMasks;

        // ── Methods ──
        public void ToString(){} // RVA: 0xBFA230
        public void get_XmlType(){} // RVA: 0x74F7D40
        public void get_TypedValue(){} // RVA: 0x74F7DC0
        public void get_ValueType(){} // RVA: 0x74F7FA0
        public void get_ValueAsBoolean(){} // RVA: 0x74F80A0
        public void get_ValueAsDateTime(){} // RVA: 0x74F8270
        public void get_ValueAsDouble(){} // RVA: 0x74F8440
        public void get_ValueAsInt(){} // RVA: 0x74F8610
        public void get_ValueAsLong(){} // RVA: 0x74F87E0
        public void ValueAs(){} // RVA: 0x74F89B0
        public void System.ICloneable.Clone(){} // RVA: 0x7477E00
        public void get_NameTable(){} // RVA: 0x87C0A0
        public void LookupNamespace(){} // RVA: 0x74F8BC0
        public void LookupPrefix(){} // RVA: 0x74F8DD0
        public void GetNamespacesInScope(){} // RVA: 0x74F90B0
        public void Clone(){} // RVA: 0x87C0A0
        public void get_NodeType(){} // RVA: 0x87C130
        public void get_LocalName(){} // RVA: 0x87C0A0
        public void get_NamespaceURI(){} // RVA: 0x87C0A0
        public void get_Prefix(){} // RVA: 0x87C0A0
        public void get_UnderlyingObject(){} // RVA: 0xDAC980
        public void MoveToNamespace(){} // RVA: 0x74F9310
        public void MoveToFirstNamespace(){} // RVA: 0x87DD20
        public void MoveToNextNamespace(){} // RVA: 0x87DD20
        public void MoveToParent(){} // RVA: 0x87D280
        public void IsSamePosition(){} // RVA: 0x87D350
        public void get_SchemaInfo(){} // RVA: 0x74F93E0
        public void IsText(){} // RVA: 0x74F9420
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x74F9430
    }

    public class XPathNavigatorKeyComparer : Object
    {
        // ── Methods ──
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x74F9700
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x74F97F0
        public void .ctor(){} // RVA: 0xB43310
    }

}