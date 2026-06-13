// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 20

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class LeafNode
    {
        public int pos; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_Pos(){} // RVA: 0x32A5C0
        public void set_Pos(){} // RVA: 0x2E00C0
        public void ExpandTree(){} // RVA: 0x2DD310
        public void ConstructPos(){} // RVA: 0x6ADA500
        public void get_IsNullable(){} // RVA: 0x2DD320
    }

    public class LeafRangeNode
    {
        public System.Decimal min; // 0x18
        public System.Decimal max; // 0x28
        public System.Xml.Schema.BitSet nextIteration; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADC110 | overloaded x2
        public void get_Max(){} // RVA: 0x111F520
        public void get_Min(){} // RVA: 0x994EE0
        public void get_NextIteration(){} // RVA: 0x4976A0
        public void set_NextIteration(){} // RVA: 0x49B830
        public void get_IsRangeNode(){} // RVA: 0x3C2850
        public void ExpandTree(){} // RVA: 0x6ADC130
    }

    public class ListFacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x692EBA0
        public void MatchEnumeration(){} // RVA: 0x692EE20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LocatedActiveAxis
    {
        public int column; // 0x28

        // ── Methods ──
        public void get_Column(){} // RVA: 0x791DC0
        public void .ctor(){} // RVA: 0x6AD6B30
        public void Reactivate(){} // RVA: 0x6AD6BC0
    }

}