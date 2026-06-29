// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.TMPro
// Classes: 3
// Methods: 7

namespace ThirdParty.Other.TMPro
{
    public class GlyphAnchorPoint : ValueType
    {
        public object m_XCoordinate;
        public object m_YCoordinate;

        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x88D10
        public void set_xCoordinate(){} // RVA: 0xD1B20
        public void get_yCoordinate(){} // RVA: 0xD1B60
        public void set_yCoordinate(){} // RVA: 0xD1B40
    }

    public class GlyphPairKey : ValueType
    {
        public object firstGlyphIndex;
        public object secondGlyphIndex;
        public object key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x944180
    }

    public class GlyphValueRecord_Legacy : ValueType
    {
        public object xPlacement;
        public object yPlacement;
        public object xAdvance;
        public object yAdvance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9440A0
        public void op_Addition(){} // RVA: 0x79518E0
    }

}