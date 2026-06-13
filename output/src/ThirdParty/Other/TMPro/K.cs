// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.TMPro
// Classes: 3
// Methods: 20

namespace ThirdParty.Other.TMPro
{
    public class KerningPair
    {
        public uint m_FirstGlyph; // 0x10
        public TMPro.GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
        public uint m_SecondGlyph; // 0x24
        public TMPro.GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
        public float xOffset; // 0x38

        // ── Methods ──
        public void get_firstGlyph(){} // RVA: 0x32A5C0
        public void set_firstGlyph(){} // RVA: 0x2E00C0
        public void get_firstGlyphAdjustments(){} // RVA: 0x2D71FC0
        public void get_secondGlyph(){} // RVA: 0xCEF5B0
        public void set_secondGlyph(){} // RVA: 0x16E1F00
        public void get_secondGlyphAdjustments(){} // RVA: 0x111F520
        public void get_ignoreSpacingAdjustments(){} // RVA: 0x4424E0
        public void .ctor(){} // RVA: 0x6FB84C0 | overloaded x3
        public void ConvertLegacyKerningData(){} // RVA: 0x6FB84E0
        public void .cctor(){} // RVA: 0x6FB84F0
    }

    public class KerningPairKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6FB8450
    }

    public class KerningTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6FB85B0
        public void AddKerningPair(){} // RVA: 0x6FB87B0 | overloaded x2
        public void AddGlyphPairAdjustmentRecord(){} // RVA: 0x6FB8910
        public void RemoveKerningPair(){} // RVA: 0x6FB8BA0 | overloaded x2
        public void SortKerningPairs(){} // RVA: 0x6FB8C00
    }

}