// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.XPath
// Classes: 5
// Methods: 60

namespace ThirdParty.DotNet.System.Xml.XPath
{
    public class XPathDocument
    {
        public MS.Internal.Xml.Cache.XPathNode[] Message; // 0x10
        public int idxXmlNmsp; // 0x18

        // ── Methods ──
        public void get_NameTable(){} // RVA: 0x30B0C0
        public void get_HasLineInfo(){} // RVA: 0x6E8A80
        public void GetXmlNamespaceNode(){} // RVA: 0x6A91890
        public void LookupNamespaces(){} // RVA: 0x6A918F0
    }

    public class XPathException
    {
        public string res; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A92AD0 | overloaded x5
        public void GetObjectData(){} // RVA: 0x6A920E0
        public void Create(){} // RVA: 0x6A929E0 | overloaded x3
        public void CreateMessage(){} // RVA: 0x6A92BE0
        public void get_Message(){} // RVA: 0x6A92C90
    }

    public class XPathItem
    {
        // ── Methods ──
        public void get_XmlType(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0xCD60
        public void get_TypedValue(){} // RVA: 0xCD60
        public void get_ValueType(){} // RVA: 0xCD60
        public void get_ValueAsBoolean(){} // RVA: 0xDBE0
        public void get_ValueAsDateTime(){} // RVA: 0xCD60
        public void get_ValueAsDouble(){} // RVA: 0x12A40
        public void get_ValueAsInt(){} // RVA: 0xD840
        public void get_ValueAsLong(){} // RVA: 0xCD60
        public void ValueAs(){} // RVA: 0x1E6A0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XPathNavigator
    {
        public System.Xml.XPath.XPathNavigatorKeyComparer comparer;
        public char[] NodeTypeLetter; // 0x8
        public char[] UniqueIdTbl; // 0x10
        public int[] ContentKindMasks; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x391BE0
        public void get_XmlType(){} // RVA: 0x6A92CD0
        public void get_TypedValue(){} // RVA: 0x6A92D50
        public void get_ValueType(){} // RVA: 0x6A92F30
        public void get_ValueAsBoolean(){} // RVA: 0x6A93070
        public void get_ValueAsDateTime(){} // RVA: 0x6A93240
        public void get_ValueAsDouble(){} // RVA: 0x6A93410
        public void get_ValueAsInt(){} // RVA: 0x6A935E0
        public void get_ValueAsLong(){} // RVA: 0x6A937B0
        public void ValueAs(){} // RVA: 0x6A93980
        public void System.ICloneable.Clone(){} // RVA: 0x6A12500
        public void get_NameTable(){} // RVA: 0xCD60
        public void LookupNamespace(){} // RVA: 0x6A93B90
        public void LookupPrefix(){} // RVA: 0x6A93DB0
        public void GetNamespacesInScope(){} // RVA: 0x6A940B0
        public void Clone(){} // RVA: 0xCD60
        public void get_NodeType(){} // RVA: 0xD840
        public void get_LocalName(){} // RVA: 0xCD60
        public void get_NamespaceURI(){} // RVA: 0xCD60
        public void get_Prefix(){} // RVA: 0xCD60
        public void get_UnderlyingObject(){} // RVA: 0x519240
        public void MoveToNamespace(){} // RVA: 0x6A94320
        public void MoveToFirstNamespace(){} // RVA: 0xE1F0
        public void MoveToNextNamespace(){} // RVA: 0xE1F0
        public void MoveToParent(){} // RVA: 0xDBE0
        public void IsSamePosition(){} // RVA: 0xDE40
        public void get_SchemaInfo(){} // RVA: 0x6A943F0
        public void IsText(){} // RVA: 0x6A94430
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6A94440
    }

    public class XPathNavigatorKeyComparer
    {
        // ── Methods ──
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x6A94710
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x6A94800
        public void .ctor(){} // RVA: 0x2DD310
    }

}