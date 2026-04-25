// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 15

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class IXmlSchemaInfo
    {
        public object Validity;
        public object IsDefault;
        public object IsNil;
        public object MemberType;
        public object SchemaType;
        public object SchemaElement;
        public object SchemaAttribute;

        // ── Methods ──
        public void get_Validity(){} // RVA: 0x7FFAC2C59960
        public void get_IsDefault(){} // RVA: 0x7FFAC2C59D00
        public void get_IsNil(){} // RVA: 0x7FFAC2C59D00
        public void get_MemberType(){} // RVA: 0x7FFAC2C58E90
        public void get_SchemaType(){} // RVA: 0x7FFAC2C58E90
        public void get_SchemaElement(){} // RVA: 0x7FFAC2C58E90
        public void get_SchemaAttribute(){} // RVA: 0x7FFAC2C58E90
    }

    public class IdRefNode : Object
    {
        public string Id; // 0x10
        public int LineNo; // 0x18
        public int LinePos; // 0x1C
        public System.Xml.Schema.IdRefNode Next; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91503D0
    }

    public class InteriorNode : SyntaxTreeNode
    {
        public System.Xml.Schema.SyntaxTreeNode LeftChild; // 0x10
        public System.Xml.Schema.SyntaxTreeNode RightChild; // 0x18

        // ── Methods ──
        public void get_LeftChild(){} // RVA: 0x7FFAC2F3C380
        public void set_LeftChild(){} // RVA: 0x7FFAC2F22E30
        public void get_RightChild(){} // RVA: 0x7FFAC2F247C0
        public void set_RightChild(){} // RVA: 0x7FFAC2F87E80
        public void ExpandTreeNoRecursive(){} // RVA: 0x7FFAC9271630
        public void ExpandTree(){} // RVA: 0x7FFAC9271880
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}