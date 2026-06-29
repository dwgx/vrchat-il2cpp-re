// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 19

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class LeafNode : SyntaxTreeNode
    {
        public object pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_Pos(){} // RVA: 0xB8F8F0
        public void set_Pos(){} // RVA: 0xB460A0
        public void ExpandTree(){} // RVA: 0xB43310
        public void ConstructPos(){} // RVA: 0x753E820
        public void get_IsNullable(){} // RVA: 0xB43320
    }

    public class LeafRangeNode : LeafNode
    {
        public object min;
        public object max;
        public object nextIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7540330
        public void get_Max(){} // RVA: 0x19F92B0
        public void get_Min(){} // RVA: 0x125EE60
        public void get_NextIteration(){} // RVA: 0xD05CA0
        public void set_NextIteration(){} // RVA: 0xD09D70
        public void get_IsRangeNode(){} // RVA: 0xC2E4C0
        public void ExpandTree(){} // RVA: 0x7540350
    }

    public class ListFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7393990
        public void MatchEnumeration(){} // RVA: 0x7393BF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LocatedActiveAxis : ActiveAxis
    {
        public object column;
        public object isMatched;
        public object Ks;

        // ── Methods ──
        public void get_Column(){} // RVA: 0x1065D50
        public void .ctor(){} // RVA: 0x753AF40
        public void Reactivate(){} // RVA: 0x753AFD0
    }

}