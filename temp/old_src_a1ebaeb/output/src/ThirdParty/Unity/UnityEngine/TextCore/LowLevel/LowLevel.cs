// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 12
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine : Object
    {
        public object s_GlyphMarshallingStruct_IN; // 0x317904B0
        public object s_UsedGlyphRects; // 0x317904B0

        // ── Original Methods ──
        public void InitializeFontEngine(){} // RVA: 0x7ffaaf41c5b0
        public void InitializeFontEngine_Internal(){} // RVA: 0x7ffaaf41c630
        public void LoadFontFace(){} // RVA: 0x7ffaaf41c9c0
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7ffaaf41c730
        public void LoadFontFace(){} // RVA: 0x7ffaaf41c9c0
        public void LoadFontFace_With_Size_FromFont_Internal(){} // RVA: 0x7ffaaf41c840
        public void LoadFontFace(){} // RVA: 0x7ffaaf41c9c0
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x7ffaaf41c950
        public void LoadFontFace(){} // RVA: 0x7ffaaf41c9c0
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7ffaaf41ca70
        public void TryGetSystemFontReference(){} // RVA: 0x7ffaaf41cae0
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7ffaaf41cb90
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7ffaaf41cda0
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7ffaaf41cfd0
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x7ffaaf41d040
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7ffaaf41d270
        public void TryAddGlyphToTexture(){} // RVA: 0x7ffaaf41d330
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x7ffaaf41db00
        public void TryAddGlyphsToTexture(){} // RVA: 0x7ffaaf41db80
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7ffaaf41e8c0
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x7ffaaf41ed00
        public void GenericListToMarshallingArray(){} // RVA: 0x7ffaa8660fc0
        public void ResetAtlasTexture(){} // RVA: 0x7ffaaf41edb0
        public void .cctor(){} // RVA: 0x7ffaaf41ee00
        // ── Binary Analysis Named ──
        public void GetFaceInfo(){} // RVA: 0x7ffaaf41cc00
        public void GetFaceInfo_Internal(){} // RVA: 0x7ffaaf41cd00
        public void GetGlyphIndex(){} // RVA: 0x7ffaaf41cd50
        public void SetTextureUploadMode(){} // RVA: 0x7ffaaf41d2e0
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x7ffaaf41e950
        public void GetGlyphPairAdjustmentRecords(){} // RVA: 0x7ffaaf41eb00
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7ffaaf41ed60
        public void SetMarshallingArraySize(){} // RVA: 0x7ffaa86666b0
    }

    public class FontReference : ValueType
    {
        public object faceIndex; // 0x32D9A990
    }

    public class GlyphAdjustmentRecord : ValueType
    {
        public object m_XPlacement; // 0x32D9AD30

        // ── Original Methods ──
        public void get_glyphIndex(){} // RVA: 0x7ffaae9b5f60
        public void get_glyphValueRecord(){} // RVA: 0x7ffaaf41f330
        public void Equals(){} // RVA: 0x7ffaaf41f410
        public void Equals(){} // RVA: 0x7ffaaf41f410
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf41f340
    }

    public class GlyphAnchorPoint : ValueType
    {
        // ── Original Methods ──
        public void get_xCoordinate(){} // RVA: 0x7ffaa8955d20
        public void get_yCoordinate(){} // RVA: 0x7ffaa8955d30
    }

    public class GlyphMarshallingStruct : ValueType
    {
        public object glyphRect; // 0x32D9B330
        public object classDefinitionType; // 0x32D9B330
    }

    public class GlyphPairAdjustmentRecord : ValueType
    {
        public object m_FeatureLookupFlags; // 0x32D9B7F0
        public object System; // 0xB40D3530

        // ── Original Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7ffaaf41f4a0
        public void get_secondAdjustmentRecord(){} // RVA: 0x7ffaaf41c540
        public void get_featureLookupFlags(){} // RVA: 0x7ffaac6a0e00
        public void Equals(){} // RVA: 0x7ffaaf41f5a0
        public void Equals(){} // RVA: 0x7ffaaf41f5a0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf41f4b0
    }

    public class GlyphValueRecord : ValueType
    {
        public object m_XAdvance; // 0x32D9AD30

        // ── Original Methods ──
        public void get_xPlacement(){} // RVA: 0x7ffaa8955d20
        public void set_xPlacement(){} // RVA: 0x7ffaaa49daf0
        public void get_yPlacement(){} // RVA: 0x7ffaa8955d30
        public void set_yPlacement(){} // RVA: 0x7ffaaa49db00
        public void get_xAdvance(){} // RVA: 0x7ffaa8955cf0
        public void get_yAdvance(){} // RVA: 0x7ffaa8955d00
        public void op_Addition(){} // RVA: 0x7ffaaf41f1c0
        public void Equals(){} // RVA: 0x7ffaaf41f2b0
        public void Equals(){} // RVA: 0x7ffaaf41f2b0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf41f1e0
    }

    public class LigatureSubstitutionRecord : ValueType
    {
        // ── Original Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x7ffaaabdb990
        public void get_ligatureGlyphID(){} // RVA: 0x7ffaabf4ae50
    }

    public class MarkPositionAdjustment : ValueType
    {
        // ── Original Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x7ffaa8955d20
        public void get_yPositionAdjustment(){} // RVA: 0x7ffaa8955d30
    }

    public class MarkToBaseAdjustmentRecord : ValueType
    {
        public object m_MarkGlyphID; // 0x32DF0380

        // ── Original Methods ──
        public void get_baseGlyphID(){} // RVA: 0x7ffaae9b5f60
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x7ffaaf361a20
        public void get_markGlyphID(){} // RVA: 0x7ffaabfb0760
        public void get_markPositionAdjustment(){} // RVA: 0x7ffaaf399860
    }

    public class MarkToMarkAdjustmentRecord : ValueType
    {
        public object m_CombiningMarkGlyphID; // 0x32DF0550

        // ── Original Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x7ffaae9b5f60
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x7ffaaf361a20
        public void get_combiningMarkGlyphID(){} // RVA: 0x7ffaabfb0760
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x7ffaaf399860
    }

    public class MultipleSubstitutionRecord : ValueType
    {
        public object (00; // 0x32DF89B0
    }

}