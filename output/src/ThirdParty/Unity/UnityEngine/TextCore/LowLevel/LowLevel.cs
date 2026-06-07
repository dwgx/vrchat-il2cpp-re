// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 13
// Methods: 68

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine
    {
        // ── Methods ──
        public void InitializeFontEngine(){} // RVA: 0x7262D50
        public void InitializeFontEngine_Internal(){} // RVA: 0x7262DD0
        public void LoadFontFace(){} // RVA: 0x7263160 | overloaded x4
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7262ED0
        public void LoadFontFace_With_Size_FromFont_Internal(){} // RVA: 0x7262FE0
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x72630F0
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7263210
        public void TryGetSystemFontReference(){} // RVA: 0x7263280
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7263330
        public void GetFaceInfo(){} // RVA: 0x72633A0
        public void GetFaceInfo_Internal(){} // RVA: 0x72634A0
        public void GetGlyphIndex(){} // RVA: 0x72634F0
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7263540
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7263770
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x72637E0
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7263A10
        public void SetTextureUploadMode(){} // RVA: 0x7263A80
        public void TryAddGlyphToTexture(){} // RVA: 0x7263AD0
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x72642A0
        public void TryAddGlyphsToTexture(){} // RVA: 0x7264320
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7265060
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x72650F0
        public void GetGlyphPairAdjustmentRecords(){} // RVA: 0x72652A0
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x72654A0
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7265500
        public void GenericListToMarshallingArray(){} // RVA: 0x24D50
        public void SetMarshallingArraySize(){} // RVA: 0x2A490
        public void ResetAtlasTexture(){} // RVA: 0x7265550
        public void .cctor(){} // RVA: 0x72655A0
    }

    public class FontEngineUtilities
    {
        // ── Methods ──
        public void MaxValue(){} // RVA: 0x7265940
    }

    public class FontReference
    {
    }

    public class GlyphAdjustmentRecord
    {
        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x67FD0D0
        public void get_glyphValueRecord(){} // RVA: 0x7265AD0
        public void GetHashCode(){} // RVA: 0x7265AE0
        public void Equals(){} // RVA: 0x7265BB0 | overloaded x2
    }

    public class GlyphAnchorPoint
    {
        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x300D20
        public void get_yCoordinate(){} // RVA: 0x300D30
    }

    public class GlyphMarshallingStruct
    {
    }

    public class GlyphPairAdjustmentRecord
    {
        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7265C40
        public void get_secondAdjustmentRecord(){} // RVA: 0x7262CE0
        public void get_featureLookupFlags(){} // RVA: 0x43DB8C0
        public void GetHashCode(){} // RVA: 0x7265C50
        public void Equals(){} // RVA: 0x7265D40 | overloaded x2
    }

    public class GlyphValueRecord
    {
        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x300D20
        public void set_xPlacement(){} // RVA: 0x1F78330
        public void get_yPlacement(){} // RVA: 0x300D30
        public void set_yPlacement(){} // RVA: 0x1F78350
        public void get_xAdvance(){} // RVA: 0x300CF0
        public void get_yAdvance(){} // RVA: 0x300D00
        public void op_Addition(){} // RVA: 0x7265960
        public void GetHashCode(){} // RVA: 0x7265980
        public void Equals(){} // RVA: 0x7265A50 | overloaded x2
    }

    public class LigatureSubstitutionRecord
    {
        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x2738C50
        public void get_ligatureGlyphID(){} // RVA: 0x3C4E030
    }

    public class MarkPositionAdjustment
    {
        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x300D20
        public void get_yPositionAdjustment(){} // RVA: 0x300D30
    }

    public class MarkToBaseAdjustmentRecord
    {
        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x67FD0D0
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x71A81C0
        public void get_markGlyphID(){} // RVA: 0x3C78200
        public void get_markPositionAdjustment(){} // RVA: 0x71E0000
    }

    public class MarkToMarkAdjustmentRecord
    {
        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x67FD0D0
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x71A81C0
        public void get_combiningMarkGlyphID(){} // RVA: 0x3C78200
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x71E0000
    }

    public class MultipleSubstitutionRecord
    {
    }

}