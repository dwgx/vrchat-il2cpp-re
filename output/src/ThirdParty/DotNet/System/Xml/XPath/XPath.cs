// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.XPath
// Classes: 5
// Methods: 60

namespace ThirdParty.DotNet.System.Xml.XPath
{
    public class XPathDocument : Object
    {
        public MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp; // 0x10
        public int idxXmlNmsp; // 0x18

        // ── Methods ──
        public void get_NameTable(){} // RVA: 0x7FFE811290C0
        public void get_HasLineInfo(){} // RVA: 0x7FFE815F1380
        public void GetXmlNamespaceNode(){} // RVA: 0x7FFE875D0B80
        public void LookupNamespaces(){} // RVA: 0x7FFE875D0BE0
    }

    public class XPathException : SystemException
    {
        public string res; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875D1DC0 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFE875D13D0
        public void Create(){} // RVA: 0x7FFE875D1CD0 | overloaded x3
        public void CreateMessage(){} // RVA: 0x7FFE875D1ED0
        public void get_Message(){} // RVA: 0x7FFE875D1F80
    }

    public class XPathItem : Object
    {
        // ── Methods ──
        public void get_XmlType(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void get_TypedValue(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueAsBoolean(){} // RVA: 0x7FFE80E2F150
        public void get_ValueAsDateTime(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueAsDouble(){} // RVA: 0x7FFE80E33FB0
        public void get_ValueAsInt(){} // RVA: 0x7FFE80E2EDB0
        public void get_ValueAsLong(){} // RVA: 0x7FFE80E2E2E0
        public void ValueAs(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XPathNavigator : XPathItem
    {
        public System.Xml.XPath.XPathNavigatorKeyComparer comparer;
        public char[] NodeTypeLetter; // 0x8
        public char[] UniqueIdTbl; // 0x10
        public int[] ContentKindMasks; // 0x18
        public object field_4; // 0x2EF
        public object field_5; // 0x2F0
        public object field_6; // 0x2F1
        public object field_7; // 0x2F2
        public object field_8; // 0x2F3
        public object field_9; // 0x2F4
        public object field_10; // 0x2F5
        public object field_11; // 0x2F6
        public object field_12; // 0x2F7
        public object field_13; // 0x2F8
        public object field_14; // 0x2F9

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE811AFBE0
        public void get_XmlType(){} // RVA: 0x7FFE875D1FC0
        public void get_TypedValue(){} // RVA: 0x7FFE875D2040
        public void get_ValueType(){} // RVA: 0x7FFE875D2220
        public void get_ValueAsBoolean(){} // RVA: 0x7FFE875D2360
        public void get_ValueAsDateTime(){} // RVA: 0x7FFE875D2530
        public void get_ValueAsDouble(){} // RVA: 0x7FFE875D2700
        public void get_ValueAsInt(){} // RVA: 0x7FFE875D28D0
        public void get_ValueAsLong(){} // RVA: 0x7FFE875D2AA0
        public void ValueAs(){} // RVA: 0x7FFE875D2C70
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE87551800
        public void get_NameTable(){} // RVA: 0x7FFE80E2E2E0
        public void LookupNamespace(){} // RVA: 0x7FFE875D2E80
        public void LookupPrefix(){} // RVA: 0x7FFE875D30A0
        public void GetNamespacesInScope(){} // RVA: 0x7FFE875D33A0
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void get_NodeType(){} // RVA: 0x7FFE80E2EDB0
        public void get_LocalName(){} // RVA: 0x7FFE80E2E2E0
        public void get_NamespaceURI(){} // RVA: 0x7FFE80E2E2E0
        public void get_Prefix(){} // RVA: 0x7FFE80E2E2E0
        public void get_UnderlyingObject(){} // RVA: 0x7FFE813240E0
        public void MoveToNamespace(){} // RVA: 0x7FFE875D3610
        public void MoveToFirstNamespace(){} // RVA: 0x7FFE80E2F760
        public void MoveToNextNamespace(){} // RVA: 0x7FFE80E2F760
        public void MoveToParent(){} // RVA: 0x7FFE80E2F150
        public void IsSamePosition(){} // RVA: 0x7FFE80E2F3B0
        public void get_SchemaInfo(){} // RVA: 0x7FFE875D36E0
        public void IsText(){} // RVA: 0x7FFE875D3720
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE875D3730
    }

    public class XPathNavigatorKeyComparer : Object
    {
        // ── Methods ──
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFE875D3A00
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFE875D3AF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}