// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore
// Classes: 13
// Methods: 158

namespace ThirdParty.Unity.UnityEngine.TextCore
{
    public class FaceInfo : ValueType
    {
        public object m_FaceIndex;
        public object m_FamilyName;
        public object m_StyleName;
        public object m_PointSize;
        public object m_Scale;
        public object m_UnitsPerEM;
        public object m_LineHeight;
        public object m_AscentLine;
        public object m_CapLine;
        public object m_MeanLine;
        public object m_Baseline;
        public object m_DescentLine;
        public object m_SuperscriptOffset;
        public object m_SuperscriptSize;
        public object m_SubscriptOffset;
        public object m_SubscriptSize;
        public object m_UnderlineOffset;
        public object m_UnderlineThickness;
        public object m_StrikethroughOffset;
        public object m_StrikethroughThickness;
        public object m_TabWidth;

        // ── Methods ──
        public void get_faceIndex(){} // RVA: 0x454FE0
        public void get_familyName(){} // RVA: 0x8C0C50
        public void get_styleName(){} // RVA: 0x979230
        public void get_pointSize(){} // RVA: 0x958980
        public void get_scale(){} // RVA: 0x958990
        public void set_scale(){} // RVA: 0x9B110
        public void get_unitsPerEM(){} // RVA: 0x53FD80
        public void set_unitsPerEM(){} // RVA: 0x93190
        public void get_lineHeight(){} // RVA: 0x9589B0
        public void get_ascentLine(){} // RVA: 0x95A800
        public void get_capLine(){} // RVA: 0x971FA0
        public void set_capLine(){} // RVA: 0x942E50
        public void get_meanLine(){} // RVA: 0x971FB0
        public void set_meanLine(){} // RVA: 0xCFDA0
        public void get_baseline(){} // RVA: 0x971FE0
        public void get_descentLine(){} // RVA: 0x971FF0
        public void get_superscriptOffset(){} // RVA: 0x971FC0
        public void get_superscriptSize(){} // RVA: 0x971FD0
        public void get_subscriptOffset(){} // RVA: 0x98BA10
        public void get_subscriptSize(){} // RVA: 0x98BA20
        public void get_underlineOffset(){} // RVA: 0x98BA30
        public void get_underlineThickness(){} // RVA: 0x98BA40
        public void get_strikethroughOffset(){} // RVA: 0x978B80
        public void set_strikethroughOffset(){} // RVA: 0x98BA50
        public void get_tabWidth(){} // RVA: 0x98BA60
    }

    public class FaceInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Glyph : Object
    {
        public object m_Index;
        public object m_Metrics;
        public object m_GlyphRect;
        public object m_Scale;
        public object m_AtlasIndex;
        public object m_ClassDefinitionType;

        // ── Methods ──
        public void get_index(){} // RVA: 0x7B51740
        public void set_index(){} // RVA: 0xB460A0
        public void get_metrics(){} // RVA: 0x7DBB620
        public void set_metrics(){} // RVA: 0x7DBB640
        public void get_glyphRect(){} // RVA: 0x7C7DA30
        public void set_glyphRect(){} // RVA: 0x19F35A0
        public void get_scale(){} // RVA: 0x79D06E0
        public void set_scale(){} // RVA: 0x11E1470
        public void get_atlasIndex(){} // RVA: 0x7DBB650
        public void set_atlasIndex(){} // RVA: 0x25671C0
        public void .ctor(){} // RVA: 0x7A69920
    }

    public class GlyphMetrics : ValueType
    {
        public object m_Width;
        public object m_Height;
        public object m_HorizontalBearingX;
        public object m_HorizontalBearingY;
        public object m_HorizontalAdvance;

        // ── Methods ──
        public void get_width(){} // RVA: 0x459690
        public void get_height(){} // RVA: 0x958940
        public void get_horizontalBearingX(){} // RVA: 0x958950
        public void get_horizontalBearingY(){} // RVA: 0x958960
        public void get_horizontalAdvance(){} // RVA: 0x958970
        public void .ctor(){} // RVA: 0x98BB60
        public void GetHashCode(){} // RVA: 0x98BB90
        public void Equals(){} // RVA: 0x98BC60
    }

    public class GlyphMetrics[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphRect : ValueType
    {
        public object m_X;
        public object m_Y;
        public object m_Width;
        public object m_Height;
        public object s_ZeroGlyphRect;

        // ── Methods ──
        public void get_x(){} // RVA: 0x454FE0
        public void get_y(){} // RVA: 0x4A8D60
        public void get_width(){} // RVA: 0x438050
        public void get_height(){} // RVA: 0x448F30
        public void get_zero(){} // RVA: 0x7DBB290
        public void .ctor(){} // RVA: 0x8A8000
        public void GetHashCode(){} // RVA: 0x98BA70
        public void Equals(){} // RVA: 0x98BAE0
        public void .cctor(){} // RVA: 0x7DBB450
    }

    public class GlyphRect[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAF8F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6B7D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Glyph[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NativeTextGenerationSettings : ValueType
    {
        public object fontAsset;
        public object textSettings;
        public object text;
        public object screenWidth;
        public object screenHeight;
        public object wordWrap;
        public object overflow;
        public object languageDirection;
        public object vertexPadding;
        public object horizontalAlignment;
        public object verticalAlignment;
        public object fontSize;
        public object fontStyle;
        public object fontWeight;
        public object textSpans;
        public object color;
        public object characterSpacing;
        public object wordSpacing;
        public object paragraphSpacing;

        // ── Methods ──
        public void get_hasLink(){} // RVA: 0x98CB70
        public void CreateTextSpan(){} // RVA: 0x98CB80
        public void get_Default(){} // RVA: 0x7DC2290
        public void ToString(){} // RVA: 0x98CBE0
    }

    public class NativeTextGenerationSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class OTL_FeatureTag[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RichTextTagParser : Object
    {
        public object TagsInfo;

        // ── Methods ──
        public void tagMatch(){} // RVA: 0x7DC3400
        public void SpanToEnum(){} // RVA: 0x7DC35C0
        public void FindTags(){} // RVA: 0x7DC3930
        public void PickResultingTags(){} // RVA: 0x7DC4500
        public void GenerateSegments(){} // RVA: 0x7DC52D0
        public void ApplyStateToSegment(){} // RVA: 0x7DC5640
        public void AddLink(){} // RVA: 0x7DC5770
        public void CreateTextSpan(){} // RVA: 0x7DC5A00
        public void CreateTextGenerationSettingsArray(){} // RVA: 0x7DC5F60
        public void .cctor(){} // RVA: 0x7DC6400
    }

    public class TextSpan : ValueType
    {
        public object startIndex;
        public object length;
        public object fontAsset;
        public object fontSize;
        public object color;
        public object fontStyle;
        public object fontWeight;
        public object linkID;

        // ── Methods ──
        public void ToString(){} // RVA: 0x98CBF0
    }

}