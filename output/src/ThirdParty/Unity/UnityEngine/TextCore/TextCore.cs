// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore
// Classes: 4
// Methods: 70

namespace ThirdParty.Unity.UnityEngine.TextCore
{
    public class FaceInfo
    {
        public int m_FaceIndex; // 0x10
        public string m_FamilyName; // 0x18
        public string m_StyleName; // 0x20
        public int m_PointSize; // 0x28
        public float m_Scale; // 0x2C
        public int m_UnitsPerEM; // 0x30
        public float m_LineHeight; // 0x34
        public float m_AscentLine; // 0x38
        public float m_CapLine; // 0x3C
        public float m_MeanLine; // 0x40
        public float m_Baseline; // 0x44
        public float m_DescentLine; // 0x48
        public float m_SuperscriptOffset; // 0x4C
        public float m_SuperscriptSize; // 0x50
        public float m_SubscriptOffset; // 0x54
        public float m_SubscriptSize; // 0x58
        public float m_UnderlineOffset; // 0x5C
        public float m_UnderlineThickness; // 0x60
        public float m_StrikethroughOffset; // 0x64
        public float m_StrikethroughThickness; // 0x68

        // ── Methods ──
        public void get_faceIndex(){} // RVA: 0x67FD0D0
        public void get_familyName(){} // RVA: 0x5F1D510
        public void set_familyName(){} // RVA: 0x1968950
        public void get_styleName(){} // RVA: 0x33B6D40
        public void set_styleName(){} // RVA: 0x2DEE30
        public void get_pointSize(){} // RVA: 0x3D92310
        public void set_pointSize(){} // RVA: 0x6374E0
        public void get_scale(){} // RVA: 0x707C4B0
        public void set_scale(){} // RVA: 0x3AA580
        public void get_lineHeight(){} // RVA: 0x707C4C0
        public void set_lineHeight(){} // RVA: 0x44AF60
        public void get_ascentLine(){} // RVA: 0x70983C0
        public void set_ascentLine(){} // RVA: 0x3BC220
        public void get_capLine(){} // RVA: 0x71A8210
        public void set_capLine(){} // RVA: 0x8CF4F0
        public void get_meanLine(){} // RVA: 0x71A8220
        public void set_meanLine(){} // RVA: 0x4FDE90
        public void get_baseline(){} // RVA: 0x71A8240
        public void set_baseline(){} // RVA: 0x3A7640
        public void get_descentLine(){} // RVA: 0x6F83DB0
        public void set_descentLine(){} // RVA: 0x4FB970
        public void get_superscriptOffset(){} // RVA: 0x6F83E10
        public void set_superscriptOffset(){} // RVA: 0x9FC6C0
        public void get_superscriptSize(){} // RVA: 0x71A8230
        public void set_superscriptSize(){} // RVA: 0x7D04A0
        public void get_subscriptOffset(){} // RVA: 0x71EFD40
        public void set_subscriptOffset(){} // RVA: 0x2E5980
        public void get_subscriptSize(){} // RVA: 0x7262910
        public void set_subscriptSize(){} // RVA: 0xEBB7C0
        public void get_underlineOffset(){} // RVA: 0x7262920
        public void set_underlineOffset(){} // RVA: 0xEBB7B0
        public void get_underlineThickness(){} // RVA: 0x7262930
        public void set_underlineThickness(){} // RVA: 0x345470
        public void get_strikethroughOffset(){} // RVA: 0x71B8A70
        public void set_strikethroughOffset(){} // RVA: 0x863060
        public void set_strikethroughThickness(){} // RVA: 0x305FF0
        public void get_tabWidth(){} // RVA: 0x7262940
        public void set_tabWidth(){} // RVA: 0x306010
    }

    public class Glyph
    {
        public uint m_Index; // 0x10
        public UnityEngine.TextCore.GlyphMetrics m_Metrics; // 0x14
        public UnityEngine.TextCore.GlyphRect m_GlyphRect; // 0x28
        public float m_Scale; // 0x38
        public int m_AtlasIndex; // 0x3C

        // ── Methods ──
        public void get_index(){} // RVA: 0x70B92A0
        public void set_index(){} // RVA: 0x2E00C0
        public void get_metrics(){} // RVA: 0x7262CE0
        public void set_metrics(){} // RVA: 0x7262D00
        public void get_glyphRect(){} // RVA: 0x7187890
        public void set_glyphRect(){} // RVA: 0x111C380
        public void get_scale(){} // RVA: 0x6F83DB0
        public void set_scale(){} // RVA: 0x4FB970
        public void get_atlasIndex(){} // RVA: 0x7262D10
        public void set_atlasIndex(){} // RVA: 0x1CB95F0
        public void .ctor(){} // RVA: 0x70012A0 | overloaded x3
    }

    public class GlyphMetrics
    {
        public float m_Width; // 0x10
        public float m_Height; // 0x14
        public float m_HorizontalBearingX; // 0x18
        public float m_HorizontalBearingY; // 0x1C
        public float m_HorizontalAdvance; // 0x20

        // ── Methods ──
        public void get_width(){} // RVA: 0x300D20
        public void get_height(){} // RVA: 0x300D30
        public void get_horizontalBearingX(){} // RVA: 0x300CF0
        public void get_horizontalBearingY(){} // RVA: 0x300D00
        public void get_horizontalAdvance(){} // RVA: 0x707C4A0
        public void .ctor(){} // RVA: 0x7262B50
        public void GetHashCode(){} // RVA: 0x7262B80
        public void Equals(){} // RVA: 0x7262C50 | overloaded x2
    }

    public class GlyphRect
    {
        public int m_X; // 0x10
        public int m_Y; // 0x14
        public int m_Width; // 0x18
        public int m_Height; // 0x1C
        public UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;

        // ── Methods ──
        public void get_x(){} // RVA: 0x67FD0D0
        public void get_y(){} // RVA: 0x40B7110
        public void get_width(){} // RVA: 0x3C4E030
        public void get_height(){} // RVA: 0x3C78200
        public void get_zero(){} // RVA: 0x7262950
        public void .ctor(){} // RVA: 0x5B88150
        public void GetHashCode(){} // RVA: 0x72629C0
        public void Equals(){} // RVA: 0x7262A90 | overloaded x2
        public void .cctor(){} // RVA: 0x7262B10
    }

}