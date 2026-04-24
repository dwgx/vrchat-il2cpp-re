// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore
// Classes: 4
// Methods: 70

namespace ThirdParty.Unity.UnityEngine.TextCore
{
    public class FaceInfo : ValueType
    {
        public object m_StyleName; // 0x32D9A040
        public object m_UnitsPerEM; // 0x32D9A040
        public object m_CapLine; // 0x32D9A040
        public object m_DescentLine; // 0x32D9A040
        public object m_SubscriptOffset; // 0x32D9A040
        public object m_UnderlineThickness; // 0x32D9A040
        public object m_TabWidth; // 0x32D9A040

        // ── Original Methods ──
        public void get_faceIndex(){} // RVA: 0x7ffaae9b5f60
        public void get_familyName(){} // RVA: 0x7ffaae0d5d90
        public void set_familyName(){} // RVA: 0x7ffaa9e47560
        public void get_styleName(){} // RVA: 0x7ffaab6f26c0
        public void set_styleName(){} // RVA: 0x7ffaa8933e30
        public void get_pointSize(){} // RVA: 0x7ffaac0adb00
        public void set_pointSize(){} // RVA: 0x7ffaa9357830
        public void get_scale(){} // RVA: 0x7ffaaf236d60
        public void set_scale(){} // RVA: 0x7ffaa89ff580
        public void get_lineHeight(){} // RVA: 0x7ffaaf236d70
        public void set_lineHeight(){} // RVA: 0x7ffaa8a9ff60
        public void get_ascentLine(){} // RVA: 0x7ffaaf252c90
        public void set_ascentLine(){} // RVA: 0x7ffaa8a11220
        public void get_capLine(){} // RVA: 0x7ffaaf361a70
        public void set_capLine(){} // RVA: 0x7ffaa8e14fc0
        public void get_meanLine(){} // RVA: 0x7ffaaf361a80
        public void set_meanLine(){} // RVA: 0x7ffaaa150900
        public void get_baseline(){} // RVA: 0x7ffaaf361aa0
        public void set_baseline(){} // RVA: 0x7ffaa89fc640
        public void get_descentLine(){} // RVA: 0x7ffaaf13e6c0
        public void set_descentLine(){} // RVA: 0x7ffaa9144ae0
        public void get_superscriptOffset(){} // RVA: 0x7ffaaf13e720
        public void set_superscriptOffset(){} // RVA: 0x7ffaa9068080
        public void get_superscriptSize(){} // RVA: 0x7ffaaf361a90
        public void set_superscriptSize(){} // RVA: 0x7ffaa8b01070
        public void get_subscriptOffset(){} // RVA: 0x7ffaaf3a95a0
        public void set_subscriptOffset(){} // RVA: 0x7ffaa893a980
        public void get_subscriptSize(){} // RVA: 0x7ffaaf41c170
        public void set_subscriptSize(){} // RVA: 0x7ffaa9fe6140
        public void get_underlineOffset(){} // RVA: 0x7ffaaf41c180
        public void set_underlineOffset(){} // RVA: 0x7ffaa9167b70
        public void get_underlineThickness(){} // RVA: 0x7ffaaf41c190
        public void set_underlineThickness(){} // RVA: 0x7ffaa899a470
        public void get_strikethroughOffset(){} // RVA: 0x7ffaaf3722d0
        public void set_strikethroughOffset(){} // RVA: 0x7ffaa8db9c30
        public void set_strikethroughThickness(){} // RVA: 0x7ffaa895aff0
        public void get_tabWidth(){} // RVA: 0x7ffaaf41c1a0
        public void set_tabWidth(){} // RVA: 0x7ffaa895b010
    }

    public class Glyph : Object
    {
        public object m_GlyphRect; // 0x32D9A1E0
        public object m_ClassDefinitionType; // 0x32D9A1E0
        public object m_HorizontalBearingX; // 0x32D9A380

        // ── Original Methods ──
        public void get_index(){} // RVA: 0x7ffaaf273c40
        public void set_index(){} // RVA: 0x7ffaa89350c0
        public void get_metrics(){} // RVA: 0x7ffaaf41c540
        public void set_metrics(){} // RVA: 0x7ffaaf41c560
        public void get_glyphRect(){} // RVA: 0x7ffaaf3410f0
        public void set_glyphRect(){} // RVA: 0x7ffaa95fffc0
        public void get_scale(){} // RVA: 0x7ffaaf13e6c0
        public void set_scale(){} // RVA: 0x7ffaa9144ae0
        public void get_atlasIndex(){} // RVA: 0x7ffaaf41c570
        public void set_atlasIndex(){} // RVA: 0x7ffaaa1eabc0
        public void .ctor(){} // RVA: 0x7ffaaf1bbbc0
        public void .ctor(){} // RVA: 0x7ffaaf1bbbc0
        public void .ctor(){} // RVA: 0x7ffaaf1bbbc0
    }

    public class GlyphMetrics : ValueType
    {
        public object m_HorizontalBearingX; // 0x32D9A380
        public object m_X; // 0x32D9A510

        // ── Original Methods ──
        public void get_width(){} // RVA: 0x7ffaa8955d20
        public void get_height(){} // RVA: 0x7ffaa8955d30
        public void get_horizontalBearingX(){} // RVA: 0x7ffaa8955cf0
        public void get_horizontalBearingY(){} // RVA: 0x7ffaa8955d00
        public void get_horizontalAdvance(){} // RVA: 0x7ffaaf236d50
        public void .ctor(){} // RVA: 0x7ffaaf41c3b0
        public void Equals(){} // RVA: 0x7ffaaf41c4b0
        public void Equals(){} // RVA: 0x7ffaaf41c4b0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf41c3e0
    }

    public class GlyphRect : ValueType
    {
        public object m_Width; // 0x32D9A510

        // ── Original Methods ──
        public void get_x(){} // RVA: 0x7ffaae9b5f60
        public void get_y(){} // RVA: 0x7ffaac3dc380
        public void get_width(){} // RVA: 0x7ffaabf4ae50
        public void get_height(){} // RVA: 0x7ffaabfb0760
        public void get_zero(){} // RVA: 0x7ffaaf41c1b0
        public void .ctor(){} // RVA: 0x7ffaadd40830
        public void Equals(){} // RVA: 0x7ffaaf41c2f0
        public void Equals(){} // RVA: 0x7ffaaf41c2f0
        public void .cctor(){} // RVA: 0x7ffaaf41c370
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf41c220
    }

}