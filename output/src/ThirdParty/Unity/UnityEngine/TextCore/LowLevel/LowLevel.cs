// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 13
// Methods: 68

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine
    {
        // ── Methods ──
        public void InitializeFontEngine(){} // RVA: 0x7FFAF9D12D50
        public void InitializeFontEngine_Internal(){} // RVA: 0x7FFAF9D12DD0
        public void LoadFontFace(){} // RVA: 0x7FFAF9D13160 | overloaded x4
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7FFAF9D12ED0
        public void LoadFontFace_With_Size_FromFont_Internal(){} // RVA: 0x7FFAF9D12FE0
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x7FFAF9D130F0
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7FFAF9D13210
        public void TryGetSystemFontReference(){} // RVA: 0x7FFAF9D13280
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7FFAF9D13330
        public void GetFaceInfo(){} // RVA: 0x7FFAF9D133A0
        public void GetFaceInfo_Internal(){} // RVA: 0x7FFAF9D134A0
        public void GetGlyphIndex(){} // RVA: 0x7FFAF9D134F0
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7FFAF9D13540
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7FFAF9D13770
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x7FFAF9D137E0
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7FFAF9D13A10
        public void SetTextureUploadMode(){} // RVA: 0x7FFAF9D13A80
        public void TryAddGlyphToTexture(){} // RVA: 0x7FFAF9D13AD0
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x7FFAF9D142A0
        public void TryAddGlyphsToTexture(){} // RVA: 0x7FFAF9D14320
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7FFAF9D15060
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x7FFAF9D150F0
        public void GetGlyphPairAdjustmentRecords(){} // RVA: 0x7FFAF9D152A0
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x7FFAF9D154A0
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7FFAF9D15500
        public void GenericListToMarshallingArray(){} // RVA: 0x7FFAF2AD4D50
        public void SetMarshallingArraySize(){} // RVA: 0x7FFAF2ADA490
        public void ResetAtlasTexture(){} // RVA: 0x7FFAF9D15550
        public void .cctor(){} // RVA: 0x7FFAF9D155A0
    }

    public class FontEngineUtilities
    {
        // ── Methods ──
        public void MaxValue(){} // RVA: 0x7FFAF9D15940
    }

    public class FontReference
    {
    }

    public class GlyphAdjustmentRecord
    {
        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x7FFAF92AD0D0
        public void get_glyphValueRecord(){} // RVA: 0x7FFAF9D15AD0
        public void GetHashCode(){} // RVA: 0x7FFAF9D15AE0
        public void Equals(){} // RVA: 0x7FFAF9D15BB0 | overloaded x2
    }

    public class GlyphAnchorPoint
    {
        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x7FFAF2DB0D20
        public void get_yCoordinate(){} // RVA: 0x7FFAF2DB0D30
    }

    public class GlyphMarshallingStruct
    {
    }

    public class GlyphPairAdjustmentRecord
    {
        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7FFAF9D15C40
        public void get_secondAdjustmentRecord(){} // RVA: 0x7FFAF9D12CE0
        public void get_featureLookupFlags(){} // RVA: 0x7FFAF6E8B8C0
        public void GetHashCode(){} // RVA: 0x7FFAF9D15C50
        public void Equals(){} // RVA: 0x7FFAF9D15D40 | overloaded x2
    }

    public class GlyphValueRecord
    {
        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x7FFAF2DB0D20
        public void set_xPlacement(){} // RVA: 0x7FFAF4A28330
        public void get_yPlacement(){} // RVA: 0x7FFAF2DB0D30
        public void set_yPlacement(){} // RVA: 0x7FFAF4A28350
        public void get_xAdvance(){} // RVA: 0x7FFAF2DB0CF0
        public void get_yAdvance(){} // RVA: 0x7FFAF2DB0D00
        public void op_Addition(){} // RVA: 0x7FFAF9D15960
        public void GetHashCode(){} // RVA: 0x7FFAF9D15980
        public void Equals(){} // RVA: 0x7FFAF9D15A50 | overloaded x2
    }

    public class LigatureSubstitutionRecord
    {
        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x7FFAF51E8C50
        public void get_ligatureGlyphID(){} // RVA: 0x7FFAF66FE030
    }

    public class MarkPositionAdjustment
    {
        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x7FFAF2DB0D20
        public void get_yPositionAdjustment(){} // RVA: 0x7FFAF2DB0D30
    }

    public class MarkToBaseAdjustmentRecord
    {
        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x7FFAF92AD0D0
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x7FFAF9C581C0
        public void get_markGlyphID(){} // RVA: 0x7FFAF6728200
        public void get_markPositionAdjustment(){} // RVA: 0x7FFAF9C90000
    }

    public class MarkToMarkAdjustmentRecord
    {
        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x7FFAF92AD0D0
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x7FFAF9C581C0
        public void get_combiningMarkGlyphID(){} // RVA: 0x7FFAF6728200
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x7FFAF9C90000
    }

    public class MultipleSubstitutionRecord
    {
    }

}