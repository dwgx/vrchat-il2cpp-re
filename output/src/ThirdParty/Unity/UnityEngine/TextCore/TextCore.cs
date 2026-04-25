// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore
// Classes: 4
// Methods: 70

namespace ThirdParty.Unity.UnityEngine.TextCore
{
    public class FaceInfo : ValueType
    {
        public int faceIndex; // 0x10
        public string familyName; // 0x18
        public string styleName; // 0x20
        public int pointSize; // 0x28
        public float scale; // 0x2C
        public int lineHeight; // 0x30
        public float ascentLine; // 0x34
        public float capLine; // 0x38
        public float meanLine; // 0x3C
        public float baseline; // 0x40
        public float descentLine; // 0x44
        public float superscriptOffset; // 0x48
        public float superscriptSize; // 0x4C
        public float subscriptOffset; // 0x50
        public float subscriptSize; // 0x54
        public float underlineOffset; // 0x58
        public float underlineThickness; // 0x5C
        public float strikethroughOffset; // 0x60
        public float strikethroughThickness; // 0x64
        public float tabWidth; // 0x68
        public float m_TabWidth; // 0x6C

        // ── Methods ──
        public void get_faceIndex(){} // RVA: 0x7FFD543B3F90
        public void get_familyName(){} // RVA: 0x7FFD53AD4B80
        public void set_familyName(){} // RVA: 0x7FFD4F840240
        public void get_styleName(){} // RVA: 0x7FFD510E4750
        public void set_styleName(){} // RVA: 0x7FFD4E342E30
        public void get_pointSize(){} // RVA: 0x7FFD51ABDCA0
        public void set_pointSize(){} // RVA: 0x7FFD4ED4CD10
        public void get_scale(){} // RVA: 0x7FFD54C34E00
        public void set_scale(){} // RVA: 0x7FFD4E40E580
        public void get_lineHeight(){} // RVA: 0x7FFD54C34E10
        public void set_lineHeight(){} // RVA: 0x7FFD4E4AEF60
        public void get_ascentLine(){} // RVA: 0x7FFD54C50D30
        public void set_ascentLine(){} // RVA: 0x7FFD4E420220
        public void get_capLine(){} // RVA: 0x7FFD54D5FB10
        public void set_capLine(){} // RVA: 0x7FFD4E80A9D0
        public void get_meanLine(){} // RVA: 0x7FFD54D5FB20
        public void set_meanLine(){} // RVA: 0x7FFD4FB594E0
        public void get_baseline(){} // RVA: 0x7FFD54D5FB40
        public void set_baseline(){} // RVA: 0x7FFD4E40B640
        public void get_descentLine(){} // RVA: 0x7FFD54B3C6E0
        public void set_descentLine(){} // RVA: 0x7FFD4EB37190
        public void get_superscriptOffset(){} // RVA: 0x7FFD54B3C740
        public void set_superscriptOffset(){} // RVA: 0x7FFD4EA5C6C0
        public void get_superscriptSize(){} // RVA: 0x7FFD54D5FB30
        public void set_superscriptSize(){} // RVA: 0x7FFD4E50FD80
        public void get_subscriptOffset(){} // RVA: 0x7FFD54DA7640
        public void set_subscriptOffset(){} // RVA: 0x7FFD4E349980
        public void get_subscriptSize(){} // RVA: 0x7FFD54E1A210
        public void set_subscriptSize(){} // RVA: 0x7FFD4F9E0F70
        public void get_underlineOffset(){} // RVA: 0x7FFD54E1A220
        public void set_underlineOffset(){} // RVA: 0x7FFD4EB546A0
        public void get_underlineThickness(){} // RVA: 0x7FFD54E1A230
        public void set_underlineThickness(){} // RVA: 0x7FFD4E3A9470
        public void get_strikethroughOffset(){} // RVA: 0x7FFD54D70370
        public void set_strikethroughOffset(){} // RVA: 0x7FFD4E7B14E0
        public void set_strikethroughThickness(){} // RVA: 0x7FFD4E369FF0
        public void get_tabWidth(){} // RVA: 0x7FFD54E1A240
        public void set_tabWidth(){} // RVA: 0x7FFD4E36A010
    }

    public class Glyph : Object
    {
        public uint index; // 0x10
        public UnityEngine.TextCore.GlyphMetrics metrics; // 0x14
        public UnityEngine.TextCore.GlyphRect glyphRect; // 0x28
        public float scale; // 0x38
        public int atlasIndex; // 0x3C
        public 0x666321A8 m_ClassDefinitionType; // 0x40

        // ── Methods ──
        public void get_index(){} // RVA: 0x7FFD54C71CE0
        public void set_index(){} // RVA: 0x7FFD4E3440C0
        public void get_metrics(){} // RVA: 0x7FFD54E1A5E0
        public void set_metrics(){} // RVA: 0x7FFD54E1A600
        public void get_glyphRect(){} // RVA: 0x7FFD54D3F190
        public void set_glyphRect(){} // RVA: 0x7FFD4EFEC210
        public void get_scale(){} // RVA: 0x7FFD54B3C6E0
        public void set_scale(){} // RVA: 0x7FFD4EB37190
        public void get_atlasIndex(){} // RVA: 0x7FFD54E1A610
        public void set_atlasIndex(){} // RVA: 0x7FFD4FC02CD0
        public void .ctor(){} // RVA: 0x7FFD54BB9BF0 | overloaded x3
    }

    public class GlyphMetrics : ValueType
    {
        public float width; // 0x10
        public float height; // 0x14
        public float horizontalBearingX; // 0x18
        public float horizontalBearingY; // 0x1C
        public float horizontalAdvance; // 0x20

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFD4E364D20
        public void get_height(){} // RVA: 0x7FFD4E364D30
        public void get_horizontalBearingX(){} // RVA: 0x7FFD4E364CF0
        public void get_horizontalBearingY(){} // RVA: 0x7FFD4E364D00
        public void get_horizontalAdvance(){} // RVA: 0x7FFD54C34DF0
        public void .ctor(){} // RVA: 0x7FFD54E1A450
        public void GetHashCode(){} // RVA: 0x7FFD54E1A480
        public void Equals(){} // RVA: 0x7FFD54E1A550 | overloaded x2
    }

    public class GlyphRect : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public int width; // 0x18
        public int height; // 0x1C
        public UnityEngine.TextCore.GlyphRect zero;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD543B3F90
        public void get_y(){} // RVA: 0x7FFD51DEBEA0
        public void get_width(){} // RVA: 0x7FFD5195D9A0
        public void get_height(){} // RVA: 0x7FFD519BDBB0
        public void get_zero(){} // RVA: 0x7FFD54E1A250
        public void .ctor(){} // RVA: 0x7FFD5373F680
        public void GetHashCode(){} // RVA: 0x7FFD54E1A2C0
        public void Equals(){} // RVA: 0x7FFD54E1A390 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54E1A410
    }

}