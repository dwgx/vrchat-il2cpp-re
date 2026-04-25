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
        public void get_faceIndex(){} // RVA: 0x7FFAC8F93F90
        public void get_familyName(){} // RVA: 0x7FFAC86B4B80
        public void set_familyName(){} // RVA: 0x7FFAC4420240
        public void get_styleName(){} // RVA: 0x7FFAC5CC4750
        public void set_styleName(){} // RVA: 0x7FFAC2F22E30
        public void get_pointSize(){} // RVA: 0x7FFAC669DCA0
        public void set_pointSize(){} // RVA: 0x7FFAC392CD10
        public void get_scale(){} // RVA: 0x7FFAC9814E00
        public void set_scale(){} // RVA: 0x7FFAC2FEE580
        public void get_lineHeight(){} // RVA: 0x7FFAC9814E10
        public void set_lineHeight(){} // RVA: 0x7FFAC308EF60
        public void get_ascentLine(){} // RVA: 0x7FFAC9830D30
        public void set_ascentLine(){} // RVA: 0x7FFAC3000220
        public void get_capLine(){} // RVA: 0x7FFAC993FB10
        public void set_capLine(){} // RVA: 0x7FFAC33EA9D0
        public void get_meanLine(){} // RVA: 0x7FFAC993FB20
        public void set_meanLine(){} // RVA: 0x7FFAC47394E0
        public void get_baseline(){} // RVA: 0x7FFAC993FB40
        public void set_baseline(){} // RVA: 0x7FFAC2FEB640
        public void get_descentLine(){} // RVA: 0x7FFAC971C6E0
        public void set_descentLine(){} // RVA: 0x7FFAC3717190
        public void get_superscriptOffset(){} // RVA: 0x7FFAC971C740
        public void set_superscriptOffset(){} // RVA: 0x7FFAC363C6C0
        public void get_superscriptSize(){} // RVA: 0x7FFAC993FB30
        public void set_superscriptSize(){} // RVA: 0x7FFAC30EFD80
        public void get_subscriptOffset(){} // RVA: 0x7FFAC9987640
        public void set_subscriptOffset(){} // RVA: 0x7FFAC2F29980
        public void get_subscriptSize(){} // RVA: 0x7FFAC99FA210
        public void set_subscriptSize(){} // RVA: 0x7FFAC45C0F70
        public void get_underlineOffset(){} // RVA: 0x7FFAC99FA220
        public void set_underlineOffset(){} // RVA: 0x7FFAC37346A0
        public void get_underlineThickness(){} // RVA: 0x7FFAC99FA230
        public void set_underlineThickness(){} // RVA: 0x7FFAC2F89470
        public void get_strikethroughOffset(){} // RVA: 0x7FFAC9950370
        public void set_strikethroughOffset(){} // RVA: 0x7FFAC33914E0
        public void set_strikethroughThickness(){} // RVA: 0x7FFAC2F49FF0
        public void get_tabWidth(){} // RVA: 0x7FFAC99FA240
        public void set_tabWidth(){} // RVA: 0x7FFAC2F4A010
    }

    public class Glyph : Object
    {
        public uint index; // 0x10
        public UnityEngine.TextCore.GlyphMetrics metrics; // 0x14
        public UnityEngine.TextCore.GlyphRect glyphRect; // 0x28
        public float scale; // 0x38
        public int atlasIndex; // 0x3C
        public 0x6B2D21A8 m_ClassDefinitionType; // 0x40

        // ── Methods ──
        public void get_index(){} // RVA: 0x7FFAC9851CE0
        public void set_index(){} // RVA: 0x7FFAC2F240C0
        public void get_metrics(){} // RVA: 0x7FFAC99FA5E0
        public void set_metrics(){} // RVA: 0x7FFAC99FA600
        public void get_glyphRect(){} // RVA: 0x7FFAC991F190
        public void set_glyphRect(){} // RVA: 0x7FFAC3BCC210
        public void get_scale(){} // RVA: 0x7FFAC971C6E0
        public void set_scale(){} // RVA: 0x7FFAC3717190
        public void get_atlasIndex(){} // RVA: 0x7FFAC99FA610
        public void set_atlasIndex(){} // RVA: 0x7FFAC47E2CD0
        public void .ctor(){} // RVA: 0x7FFAC9799BF0 | overloaded x3
    }

    public class GlyphMetrics : ValueType
    {
        public float width; // 0x10
        public float height; // 0x14
        public float horizontalBearingX; // 0x18
        public float horizontalBearingY; // 0x1C
        public float horizontalAdvance; // 0x20

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAC2F44D20
        public void get_height(){} // RVA: 0x7FFAC2F44D30
        public void get_horizontalBearingX(){} // RVA: 0x7FFAC2F44CF0
        public void get_horizontalBearingY(){} // RVA: 0x7FFAC2F44D00
        public void get_horizontalAdvance(){} // RVA: 0x7FFAC9814DF0
        public void .ctor(){} // RVA: 0x7FFAC99FA450
        public void GetHashCode(){} // RVA: 0x7FFAC99FA480
        public void Equals(){} // RVA: 0x7FFAC99FA550 | overloaded x2
    }

    public class GlyphRect : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public int width; // 0x18
        public int height; // 0x1C
        public UnityEngine.TextCore.GlyphRect zero;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC8F93F90
        public void get_y(){} // RVA: 0x7FFAC69CBEA0
        public void get_width(){} // RVA: 0x7FFAC653D9A0
        public void get_height(){} // RVA: 0x7FFAC659DBB0
        public void get_zero(){} // RVA: 0x7FFAC99FA250
        public void .ctor(){} // RVA: 0x7FFAC831F680
        public void GetHashCode(){} // RVA: 0x7FFAC99FA2C0
        public void Equals(){} // RVA: 0x7FFAC99FA390 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC99FA410
    }

}