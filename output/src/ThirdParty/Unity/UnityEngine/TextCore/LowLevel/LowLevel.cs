// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 13
// Methods: 68

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine : Object
    {
        // ── Methods ──
        public void InitializeFontEngine(){} // RVA: 0x7FFE87DA2EF0
        public void InitializeFontEngine_Internal(){} // RVA: 0x7FFE87DA2F70
        public void LoadFontFace(){} // RVA: 0x7FFE87DA3300 | overloaded x4
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7FFE87DA3070
        public void LoadFontFace_With_Size_FromFont_Internal(){} // RVA: 0x7FFE87DA3180
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x7FFE87DA3290
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7FFE87DA33B0
        public void TryGetSystemFontReference(){} // RVA: 0x7FFE87DA3420
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7FFE87DA34D0
        public void GetFaceInfo(){} // RVA: 0x7FFE87DA3540
        public void GetFaceInfo_Internal(){} // RVA: 0x7FFE87DA3640
        public void GetGlyphIndex(){} // RVA: 0x7FFE87DA3690
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7FFE87DA36E0
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7FFE87DA3910
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x7FFE87DA3980
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7FFE87DA3BB0
        public void SetTextureUploadMode(){} // RVA: 0x7FFE87DA3C20
        public void TryAddGlyphToTexture(){} // RVA: 0x7FFE87DA3C70
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x7FFE87DA4440
        public void TryAddGlyphsToTexture(){} // RVA: 0x7FFE87DA44C0
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7FFE87DA5200
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x7FFE87DA5290
        public void GetGlyphPairAdjustmentRecords(){} // RVA: 0x7FFE87DA5440
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x7FFE87DA5640
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7FFE87DA56A0
        public void GenericListToMarshallingArray(){} // RVA: 0x7FFE80E462E0
        public void SetMarshallingArraySize(){} // RVA: 0x7FFE80E4BA70
        public void ResetAtlasTexture(){} // RVA: 0x7FFE87DA56F0
        public void .cctor(){} // RVA: 0x7FFE87DA5740
    }

    public class FontEngineUtilities : ValueType
    {
        // ── Methods ──
        public void MaxValue(){} // RVA: 0x7FFE87DA5AE0
    }

    public class FontReference : ValueType
    {
    }

    public class GlyphAdjustmentRecord : ValueType
    {
        public uint m_GlyphIndex; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord; // 0x14

        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x7FFE8733C3B0
        public void get_glyphValueRecord(){} // RVA: 0x7FFE87DA5C70
        public void GetHashCode(){} // RVA: 0x7FFE87DA5C80
        public void Equals(){} // RVA: 0x7FFE87DA5D50 | overloaded x2
    }

    public class GlyphAnchorPoint : ValueType
    {
        public float m_XCoordinate; // 0x10
        public float m_YCoordinate; // 0x14

        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x7FFE8111ED20
        public void get_yCoordinate(){} // RVA: 0x7FFE8111ED30
    }

    public class GlyphMarshallingStruct : ValueType
    {
    }

    public class GlyphPairAdjustmentRecord : ValueType
    {
        public UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
        public 0x666CD11C m_FeatureLookupFlags; // 0x38

        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7FFE87DA5DE0
        public void get_secondAdjustmentRecord(){} // RVA: 0x7FFE87DA2E80
        public void get_featureLookupFlags(){} // RVA: 0x7FFE850164C0
        public void GetHashCode(){} // RVA: 0x7FFE87DA5DF0
        public void Equals(){} // RVA: 0x7FFE87DA5EE0 | overloaded x2
    }

    public class GlyphValueRecord : ValueType
    {
        public float m_XPlacement; // 0x10
        public float m_YPlacement; // 0x14
        public float m_XAdvance; // 0x18
        public float m_YAdvance; // 0x1C

        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x7FFE8111ED20
        public void set_xPlacement(){} // RVA: 0x7FFE82D03BB0
        public void get_yPlacement(){} // RVA: 0x7FFE8111ED30
        public void set_yPlacement(){} // RVA: 0x7FFE82D03BD0
        public void get_xAdvance(){} // RVA: 0x7FFE8111ECF0
        public void get_yAdvance(){} // RVA: 0x7FFE8111ED00
        public void op_Addition(){} // RVA: 0x7FFE87DA5B00
        public void GetHashCode(){} // RVA: 0x7FFE87DA5B20
        public void Equals(){} // RVA: 0x7FFE87DA5BF0 | overloaded x2
    }

    public class LigatureSubstitutionRecord : ValueType
    {
        public uint[] m_ComponentGlyphIDs; // 0x10
        public uint m_LigatureGlyphID; // 0x18

        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x7FFE8348B260
        public void get_ligatureGlyphID(){} // RVA: 0x7FFE848C3400
    }

    public class MarkPositionAdjustment : ValueType
    {
        public float m_XPositionAdjustment; // 0x10
        public float m_YPositionAdjustment; // 0x14

        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x7FFE8111ED20
        public void get_yPositionAdjustment(){} // RVA: 0x7FFE8111ED30
    }

    public class MarkToBaseAdjustmentRecord : ValueType
    {
        public uint m_BaseGlyphID; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x14
        public uint m_MarkGlyphID; // 0x1C
        public UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment; // 0x20

        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x7FFE8733C3B0
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x7FFE87CE8360
        public void get_markGlyphID(){} // RVA: 0x7FFE848EDA00
        public void get_markPositionAdjustment(){} // RVA: 0x7FFE87D201A0
    }

    public class MarkToMarkAdjustmentRecord : ValueType
    {
        public uint m_BaseMarkGlyphID; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x14
        public uint m_CombiningMarkGlyphID; // 0x1C
        public UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x20

        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x7FFE8733C3B0
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x7FFE87CE8360
        public void get_combiningMarkGlyphID(){} // RVA: 0x7FFE848EDA00
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x7FFE87D201A0
    }

    public class MultipleSubstitutionRecord : ValueType
    {
    }

}