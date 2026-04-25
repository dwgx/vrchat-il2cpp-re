// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 13
// Methods: 68

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine : Object
    {
        public UnityEngine.TextCore.Glyph[] s_Glyphs;
        public uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
        public UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
        public UnityEngine.TextCore.GlyphRect[] s_FreeGlyphRects; // 0x20
        public UnityEngine.TextCore.GlyphRect[] s_UsedGlyphRects; // 0x28
        public UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary; // 0x38

        // ── Methods ──
        public void InitializeFontEngine(){} // RVA: 0x7FFAC99FA650
        public void InitializeFontEngine_Internal(){} // RVA: 0x7FFAC99FA6D0
        public void LoadFontFace(){} // RVA: 0x7FFAC99FAA60 | overloaded x4
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7FFAC99FA7D0
        public void LoadFontFace_With_Size_FromFont_Internal(){} // RVA: 0x7FFAC99FA8E0
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x7FFAC99FA9F0
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7FFAC99FAB10
        public void TryGetSystemFontReference(){} // RVA: 0x7FFAC99FAB80
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7FFAC99FAC30
        public void GetFaceInfo(){} // RVA: 0x7FFAC99FACA0
        public void GetFaceInfo_Internal(){} // RVA: 0x7FFAC99FADA0
        public void GetGlyphIndex(){} // RVA: 0x7FFAC99FADF0
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7FFAC99FAE40
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7FFAC99FB070
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x7FFAC99FB0E0
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7FFAC99FB310
        public void SetTextureUploadMode(){} // RVA: 0x7FFAC99FB380
        public void TryAddGlyphToTexture(){} // RVA: 0x7FFAC99FB3D0
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x7FFAC99FBBA0
        public void TryAddGlyphsToTexture(){} // RVA: 0x7FFAC99FBC20
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7FFAC99FC960
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x7FFAC99FC9F0
        public void GetGlyphPairAdjustmentRecords(){} // RVA: 0x7FFAC99FCBA0
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x7FFAC99FCDA0
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7FFAC99FCE00
        public void GenericListToMarshallingArray(){} // RVA: 0x7FFAC2C70C80
        public void SetMarshallingArraySize(){} // RVA: 0x7FFAC2C76370
        public void ResetAtlasTexture(){} // RVA: 0x7FFAC99FCE50
        public void .cctor(){} // RVA: 0x7FFAC99FCEA0
    }

    public class FontEngineUtilities : ValueType
    {
        // ── Methods ──
        public void MaxValue(){} // RVA: 0x7FFAC99FD240
    }

    public class FontReference : ValueType
    {
        public string familyName; // 0x10
        public string styleName; // 0x18
        public int faceIndex; // 0x20
        public string filePath; // 0x28
    }

    public class GlyphAdjustmentRecord : ValueType
    {
        public uint glyphIndex; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord; // 0x14

        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x7FFAC8F93F90
        public void get_glyphValueRecord(){} // RVA: 0x7FFAC99FD3D0
        public void GetHashCode(){} // RVA: 0x7FFAC99FD3E0
        public void Equals(){} // RVA: 0x7FFAC99FD4B0 | overloaded x2
    }

    public class GlyphAnchorPoint : ValueType
    {
        public float xCoordinate; // 0x10
        public float yCoordinate; // 0x14

        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x7FFAC2F44D20
        public void get_yCoordinate(){} // RVA: 0x7FFAC2F44D30
    }

    public class GlyphMarshallingStruct : ValueType
    {
        public uint index; // 0x10
        public UnityEngine.TextCore.GlyphMetrics metrics; // 0x14
        public UnityEngine.TextCore.GlyphRect glyphRect; // 0x28
        public float scale; // 0x38
        public int atlasIndex; // 0x3C
        public 0x6B2D21A8 classDefinitionType; // 0x40
    }

    public class GlyphPairAdjustmentRecord : ValueType
    {
        public UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord; // 0x24
        public 0x6B2D25C8 featureLookupFlags; // 0x38

        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7FFAC99FD540
        public void get_secondAdjustmentRecord(){} // RVA: 0x7FFAC99FA5E0
        public void get_featureLookupFlags(){} // RVA: 0x7FFAC6C8FE60
        public void GetHashCode(){} // RVA: 0x7FFAC99FD550
        public void Equals(){} // RVA: 0x7FFAC99FD640 | overloaded x2
    }

    public class GlyphValueRecord : ValueType
    {
        public float xPlacement; // 0x10
        public float yPlacement; // 0x14
        public float xAdvance; // 0x18
        public float yAdvance; // 0x1C

        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x7FFAC2F44D20
        public void set_xPlacement(){} // RVA: 0x7FFAC4A9B910
        public void get_yPlacement(){} // RVA: 0x7FFAC2F44D30
        public void set_yPlacement(){} // RVA: 0x7FFAC4A9B8F0
        public void get_xAdvance(){} // RVA: 0x7FFAC2F44CF0
        public void get_yAdvance(){} // RVA: 0x7FFAC2F44D00
        public void op_Addition(){} // RVA: 0x7FFAC99FD260
        public void GetHashCode(){} // RVA: 0x7FFAC99FD280
        public void Equals(){} // RVA: 0x7FFAC99FD350 | overloaded x2
    }

    public class LigatureSubstitutionRecord : ValueType
    {
        public uint[] componentGlyphIDs; // 0x10
        public uint ligatureGlyphID; // 0x18

        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x7FFAC51D9A30
        public void get_ligatureGlyphID(){} // RVA: 0x7FFAC653D9A0
    }

    public class MarkPositionAdjustment : ValueType
    {
        public float xPositionAdjustment; // 0x10
        public float yPositionAdjustment; // 0x14

        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x7FFAC2F44D20
        public void get_yPositionAdjustment(){} // RVA: 0x7FFAC2F44D30
    }

    public class MarkToBaseAdjustmentRecord : ValueType
    {
        public uint baseGlyphID; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseGlyphAnchorPoint; // 0x14
        public uint markGlyphID; // 0x1C
        public UnityEngine.TextCore.LowLevel.MarkPositionAdjustment markPositionAdjustment; // 0x20

        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x7FFAC8F93F90
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x7FFAC993FAC0
        public void get_markGlyphID(){} // RVA: 0x7FFAC659DBB0
        public void get_markPositionAdjustment(){} // RVA: 0x7FFAC9977900
    }

    public class MarkToMarkAdjustmentRecord : ValueType
    {
        public uint baseMarkGlyphID; // 0x10
        public UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseMarkGlyphAnchorPoint; // 0x14
        public uint combiningMarkGlyphID; // 0x1C
        public UnityEngine.TextCore.LowLevel.MarkPositionAdjustment combiningMarkPositionAdjustment; // 0x20

        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x7FFAC8F93F90
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x7FFAC993FAC0
        public void get_combiningMarkGlyphID(){} // RVA: 0x7FFAC659DBB0
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x7FFAC9977900
    }

    public class MultipleSubstitutionRecord : ValueType
    {
        public uint m_TargetGlyphID; // 0x10
        public uint[] m_SubstituteGlyphIDs; // 0x18
    }

}