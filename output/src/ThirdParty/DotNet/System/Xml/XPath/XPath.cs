// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.XPath
// Classes: 5
// Methods: 60

namespace ThirdParty.DotNet.System.Xml.XPath
{
    public class XPathDocument : Object
    {
        public MS.Internal.Xml.Cache.XPathNode[] NameTable; // 0x10
        public int HasLineInfo; // 0x18
        public System.Xml.XmlNameTable nameTable; // 0x20
        public bool hasLineInfo; // 0x28
        public System.Collections.Generic.Dictionary`2<MS.Internal.Xml.Cache.XPathNodeRef,MS.Internal.Xml.Cache.XPathNodeRef> mapNmsp; // 0x30

        // ── Methods ──
        public void get_NameTable(){} // RVA: 0x7FFAC2F4F0C0
        public void get_HasLineInfo(){} // RVA: 0x7FFAC30F6BA0
        public void GetXmlNamespaceNode(){} // RVA: 0x7FFAC9228410
        public void LookupNamespaces(){} // RVA: 0x7FFAC9228470
    }

    public class XPathException : SystemException
    {
        public string Message; // 0x90
        public string[] args; // 0x98
        public string message; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9229650 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFAC9228C60
        public void Create(){} // RVA: 0x7FFAC9229560 | overloaded x3
        public void CreateMessage(){} // RVA: 0x7FFAC9229760
        public void get_Message(){} // RVA: 0x7FFAC9229810
    }

    public class XPathItem : Object
    {
        public object XmlType;
        public object Value;
        public object TypedValue;
        public object ValueType;
        public object ValueAsBoolean;
        public object ValueAsDateTime;
        public object ValueAsDouble;
        public object ValueAsInt;
        public object ValueAsLong;

        // ── Methods ──
        public void get_XmlType(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void get_TypedValue(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueType(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueAsBoolean(){} // RVA: 0x7FFAC2C59D00
        public void get_ValueAsDateTime(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueAsDouble(){} // RVA: 0x7FFAC2C5EB60
        public void get_ValueAsInt(){} // RVA: 0x7FFAC2C59960
        public void get_ValueAsLong(){} // RVA: 0x7FFAC2C58E90
        public void ValueAs(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XPathNavigator : XPathItem
    {
        public System.Xml.XPath.XPathNavigatorKeyComparer XmlType;
        public char[] TypedValue; // 0x8
        public char[] ValueType; // 0x10
        public int[] ValueAsBoolean; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC2FD5BE0
        public void get_XmlType(){} // RVA: 0x7FFAC9229850
        public void get_TypedValue(){} // RVA: 0x7FFAC92298D0
        public void get_ValueType(){} // RVA: 0x7FFAC9229AB0
        public void get_ValueAsBoolean(){} // RVA: 0x7FFAC9229BF0
        public void get_ValueAsDateTime(){} // RVA: 0x7FFAC9229DC0
        public void get_ValueAsDouble(){} // RVA: 0x7FFAC9229F90
        public void get_ValueAsInt(){} // RVA: 0x7FFAC922A160
        public void get_ValueAsLong(){} // RVA: 0x7FFAC922A330
        public void ValueAs(){} // RVA: 0x7FFAC922A500
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC91A9050
        public void get_NameTable(){} // RVA: 0x7FFAC2C58E90
        public void LookupNamespace(){} // RVA: 0x7FFAC922A710
        public void LookupPrefix(){} // RVA: 0x7FFAC922A930
        public void GetNamespacesInScope(){} // RVA: 0x7FFAC922AC30
        public void Clone(){} // RVA: 0x7FFAC2C58E90
        public void get_NodeType(){} // RVA: 0x7FFAC2C59960
        public void get_LocalName(){} // RVA: 0x7FFAC2C58E90
        public void get_NamespaceURI(){} // RVA: 0x7FFAC2C58E90
        public void get_Prefix(){} // RVA: 0x7FFAC2C58E90
        public void get_UnderlyingObject(){} // RVA: 0x7FFAC34F9180
        public void MoveToNamespace(){} // RVA: 0x7FFAC922AEA0
        public void MoveToFirstNamespace(){} // RVA: 0x7FFAC2C5A310
        public void MoveToNextNamespace(){} // RVA: 0x7FFAC2C5A310
        public void MoveToParent(){} // RVA: 0x7FFAC2C59D00
        public void IsSamePosition(){} // RVA: 0x7FFAC2C59F60
        public void get_SchemaInfo(){} // RVA: 0x7FFAC922AF70
        public void IsText(){} // RVA: 0x7FFAC922AFB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC922AFC0
    }

    public class XPathNavigatorKeyComparer : Object
    {
        // ── Methods ──
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFAC922B290
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFAC922B380
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}