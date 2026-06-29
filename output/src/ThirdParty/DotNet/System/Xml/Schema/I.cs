// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 15

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class IXmlSchemaInfo
    {
        // ── Methods ──
        public void get_Validity(){} // RVA: 0x87C130
        public void get_IsDefault(){} // RVA: 0x87D280
        public void get_IsNil(){} // RVA: 0x87D280
        public void get_MemberType(){} // RVA: 0x87C0A0
        public void get_SchemaType(){} // RVA: 0x87C0A0
        public void get_SchemaElement(){} // RVA: 0x87C0A0
        public void get_SchemaAttribute(){} // RVA: 0x87C0A0
    }

    public class IdRefNode : Object
    {
        public object Id;
        public object LineNo;
        public object LinePos;
        public object Next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x741F310
    }

    public class InteriorNode : SyntaxTreeNode
    {
        public object leftChild;
        public object rightChild;

        // ── Methods ──
        public void get_LeftChild(){} // RVA: 0xB5DBF0
        public void set_LeftChild(){} // RVA: 0xB44D60
        public void get_RightChild(){} // RVA: 0xB465B0
        public void set_RightChild(){} // RVA: 0xBA9BA0
        public void ExpandTreeNoRecursive(){} // RVA: 0x753EDC0
        public void ExpandTree(){} // RVA: 0x753F010
        public void .ctor(){} // RVA: 0xB43310
    }

}