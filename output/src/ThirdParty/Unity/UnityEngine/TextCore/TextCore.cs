// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore
// Classes: 4
// Methods: 70

namespace ThirdParty.Unity.UnityEngine.TextCore
{
    public class FaceInfo : ValueType
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
        public void get_faceIndex(){} // RVA: 0x7FFE8733C3B0
        public void get_familyName(){} // RVA: 0x7FFE86A5E330
        public void set_familyName(){} // RVA: 0x7FFE826F4230
        public void get_styleName(){} // RVA: 0x7FFE84022BE0
        public void set_styleName(){} // RVA: 0x7FFE810FCE30
        public void get_pointSize(){} // RVA: 0x7FFE84A02990
        public void set_pointSize(){} // RVA: 0x7FFE8144DF00
        public void get_scale(){} // RVA: 0x7FFE87BBD370
        public void set_scale(){} // RVA: 0x7FFE811C8580
        public void get_lineHeight(){} // RVA: 0x7FFE87BBD380
        public void set_lineHeight(){} // RVA: 0x7FFE81268F60
        public void get_ascentLine(){} // RVA: 0x7FFE87BD9280
        public void set_ascentLine(){} // RVA: 0x7FFE811DA220
        public void get_capLine(){} // RVA: 0x7FFE87CE83B0
        public void set_capLine(){} // RVA: 0x7FFE81670820
        public void get_meanLine(){} // RVA: 0x7FFE87CE83C0
        public void set_meanLine(){} // RVA: 0x7FFE81308960
        public void get_baseline(){} // RVA: 0x7FFE87CE83E0
        public void set_baseline(){} // RVA: 0x7FFE811C5640
        public void get_descentLine(){} // RVA: 0x7FFE87AC4C50
        public void set_descentLine(){} // RVA: 0x7FFE8130A000
        public void get_superscriptOffset(){} // RVA: 0x7FFE87AC4CB0
        public void set_superscriptOffset(){} // RVA: 0x7FFE8178C310
        public void get_superscriptSize(){} // RVA: 0x7FFE87CE83D0
        public void set_superscriptSize(){} // RVA: 0x7FFE815E8470
        public void get_subscriptOffset(){} // RVA: 0x7FFE87D2FEE0
        public void set_subscriptOffset(){} // RVA: 0x7FFE81103980
        public void get_subscriptSize(){} // RVA: 0x7FFE87DA2AB0
        public void set_subscriptSize(){} // RVA: 0x7FFE81C1C2E0
        public void get_underlineOffset(){} // RVA: 0x7FFE87DA2AC0
        public void set_underlineOffset(){} // RVA: 0x7FFE81C1C3E0
        public void get_underlineThickness(){} // RVA: 0x7FFE87DA2AD0
        public void set_underlineThickness(){} // RVA: 0x7FFE81163470
        public void get_strikethroughOffset(){} // RVA: 0x7FFE87CF8C10
        public void set_strikethroughOffset(){} // RVA: 0x7FFE816031A0
        public void set_strikethroughThickness(){} // RVA: 0x7FFE81123FF0
        public void get_tabWidth(){} // RVA: 0x7FFE87DA2AE0
        public void set_tabWidth(){} // RVA: 0x7FFE81124010
    }

    public class Glyph : Object
    {
        public uint m_Index; // 0x10
        public UnityEngine.TextCore.GlyphMetrics m_Metrics; // 0x14
        public UnityEngine.TextCore.GlyphRect m_GlyphRect; // 0x28
        public float m_Scale; // 0x38
        public int m_AtlasIndex; // 0x3C

        // ── Methods ──
        public void get_index(){} // RVA: 0x7FFE87BFA280
        public void set_index(){} // RVA: 0x7FFE810FE0C0
        public void get_metrics(){} // RVA: 0x7FFE87DA2E80
        public void set_metrics(){} // RVA: 0x7FFE87DA2EA0
        public void get_glyphRect(){} // RVA: 0x7FFE87CC7A30
        public void set_glyphRect(){} // RVA: 0x7FFE81E8E800
        public void get_scale(){} // RVA: 0x7FFE87AC4C50
        public void set_scale(){} // RVA: 0x7FFE8130A000
        public void get_atlasIndex(){} // RVA: 0x7FFE87DA2EB0
        public void set_atlasIndex(){} // RVA: 0x7FFE82A4B070
        public void .ctor(){} // RVA: 0x7FFE87B42170 | overloaded x3
    }

    public class GlyphMetrics : ValueType
    {
        public float m_Width; // 0x10
        public float m_Height; // 0x14
        public float m_HorizontalBearingX; // 0x18
        public float m_HorizontalBearingY; // 0x1C
        public float m_HorizontalAdvance; // 0x20

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFE8111ED20
        public void get_height(){} // RVA: 0x7FFE8111ED30
        public void get_horizontalBearingX(){} // RVA: 0x7FFE8111ECF0
        public void get_horizontalBearingY(){} // RVA: 0x7FFE8111ED00
        public void get_horizontalAdvance(){} // RVA: 0x7FFE87BBD360
        public void .ctor(){} // RVA: 0x7FFE87DA2CF0
        public void GetHashCode(){} // RVA: 0x7FFE87DA2D20
        public void Equals(){} // RVA: 0x7FFE87DA2DF0 | overloaded x2
    }

    public class GlyphRect : ValueType
    {
        public int m_X; // 0x10
        public int m_Y; // 0x14
        public int m_Width; // 0x18
        public int m_Height; // 0x1C
        public UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE8733C3B0
        public void get_y(){} // RVA: 0x7FFE84D2D330
        public void get_width(){} // RVA: 0x7FFE848C3400
        public void get_height(){} // RVA: 0x7FFE848EDA00
        public void get_zero(){} // RVA: 0x7FFE87DA2AF0
        public void .ctor(){} // RVA: 0x7FFE866C8F80
        public void GetHashCode(){} // RVA: 0x7FFE87DA2B60
        public void Equals(){} // RVA: 0x7FFE87DA2C30 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87DA2CB0
    }

}