// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 20

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class LeafNode : SyntaxTreeNode
    {
        public int Pos; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_Pos(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Pos(){} // RVA: 0x7FFAC2F240C0
        public void ExpandTree(){} // RVA: 0x7FFAC2F21310
        public void ConstructPos(){} // RVA: 0x7FFAC9271080
        public void get_IsNullable(){} // RVA: 0x7FFAC2F21320
    }

    public class LeafRangeNode : LeafNode
    {
        public System.Decimal Max; // 0x18
        public System.Decimal Min; // 0x28
        public System.Xml.Schema.BitSet NextIteration; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9272C90 | overloaded x2
        public void get_Max(){} // RVA: 0x7FFAC3BCF020
        public void get_Min(){} // RVA: 0x7FFAC35D3330
        public void get_NextIteration(){} // RVA: 0x7FFAC31D0140
        public void set_NextIteration(){} // RVA: 0x7FFAC31D0C20
        public void get_IsRangeNode(){} // RVA: 0x7FFAC3006850
        public void ExpandTree(){} // RVA: 0x7FFAC9272CB0
    }

    public class ListFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFAC90C56C0
        public void MatchEnumeration(){} // RVA: 0x7FFAC90C5940
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LocatedActiveAxis : ActiveAxis
    {
        public int Column; // 0x28
        public bool isMatched; // 0x2C
        public System.Xml.Schema.KeySequence Ks; // 0x30

        // ── Methods ──
        public void get_Column(){} // RVA: 0x7FFAC32EC4C0
        public void .ctor(){} // RVA: 0x7FFAC926D6B0
        public void Reactivate(){} // RVA: 0x7FFAC926D740
    }

}