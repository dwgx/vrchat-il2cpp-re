// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 20

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class LeafNode : SyntaxTreeNode
    {
        public int pos; // 0x10
        public object field_1; // 0x3EA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_Pos(){} // RVA: 0x7FFE811485C0
        public void set_Pos(){} // RVA: 0x7FFE810FE0C0
        public void ExpandTree(){} // RVA: 0x7FFE810FB310
        public void ConstructPos(){} // RVA: 0x7FFE876197F0
        public void get_IsNullable(){} // RVA: 0x7FFE810FB320
    }

    public class LeafRangeNode : LeafNode
    {
        public System.Decimal min; // 0x18
        public System.Decimal max; // 0x28
        public System.Xml.Schema.BitSet nextIteration; // 0x38
        public object field_3; // 0x3F4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8761B400 | overloaded x2
        public void get_Max(){} // RVA: 0x7FFE81E90600
        public void get_Min(){} // RVA: 0x7FFE81703940
        public void get_NextIteration(){} // RVA: 0x7FFE8143BA80
        public void set_NextIteration(){} // RVA: 0x7FFE81437330
        public void get_IsRangeNode(){} // RVA: 0x7FFE811E0850
        public void ExpandTree(){} // RVA: 0x7FFE8761B420
    }

    public class ListFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFE8746DE70
        public void MatchEnumeration(){} // RVA: 0x7FFE8746E0F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LocatedActiveAxis : ActiveAxis
    {
        public int column; // 0x28

        // ── Methods ──
        public void get_Column(){} // RVA: 0x7FFE81549710
        public void .ctor(){} // RVA: 0x7FFE87615E20
        public void Reactivate(){} // RVA: 0x7FFE87615EB0
    }

}