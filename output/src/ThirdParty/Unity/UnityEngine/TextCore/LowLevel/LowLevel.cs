// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 12
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine : Object
    {
        // ── Methods ──
        public void InitializeFontEngine(){} // RVA: 0x7FFD54E1A650
        public void InitializeFontEngine_Internal(){} // RVA: 0x7FFD54E1A6D0
        public void LoadFontFace(){} // RVA: 0x7FFD54E1AA60 | overloaded x4
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7FFD54E1A7D0
        public void LoadFontFace_With_Size_FromFont_Internal(){} // RVA: 0x7FFD54E1A8E0
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x7FFD54E1A9F0
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7FFD54E1AB10
        public void TryGetSystemFontReference(){} // RVA: 0x7FFD54E1AB80
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7FFD54E1AC30
        public void GetFaceInfo(){} // RVA: 0x7FFD54E1ACA0
        public void GetFaceInfo_Internal(){} // RVA: 0x7FFD54E1ADA0
        public void GetGlyphIndex(){} // RVA: 0x7FFD54E1ADF0
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7FFD54E1AE40
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7FFD54E1B070
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x7FFD54E1B0E0
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7FFD54E1B310
        public void SetTextureUploadMode(){} // RVA: 0x7FFD54E1B380
        public void TryAddGlyphToTexture(){} // RVA: 0x7FFD54E1B3D0
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x7FFD54E1BBA0
        public void TryAddGlyphsToTexture(){} // RVA: 0x7FFD54E1BC20
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7FFD54E1C960
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x7FFD54E1C9F0
        public void GetGlyphPairAdjustmentRecords(){} // RVA: 0x7FFD54E1CBA0
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x7FFD54E1CDA0
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7FFD54E1CE00
        public void GenericListToMarshallingArray(){} // RVA: 0x7FFD4E090C80
        public void SetMarshallingArraySize(){} // RVA: 0x7FFD4E096370
        public void ResetAtlasTexture(){} // RVA: 0x7FFD54E1CE50
        public void .cctor(){} // RVA: 0x7FFD54E1CEA0
    }

    public class FontReference : ValueType
    {
    }

    public class GlyphAdjustmentRecord : ValueType
    {
        public object glyphIndex;
        public object glyphValueRecord;

        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x7FFD543B3F90
        public void get_glyphValueRecord(){} // RVA: 0x7FFD54E1D3D0
        public void GetHashCode(){} // RVA: 0x7FFD54E1D3E0
        public void Equals(){} // RVA: 0x7FFD54E1D4B0 | overloaded x2
    }

    public class GlyphAnchorPoint : ValueType
    {
        public object xCoordinate;
        public object yCoordinate;

        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x7FFD4E364D20
        public void get_yCoordinate(){} // RVA: 0x7FFD4E364D30
    }

    public class GlyphMarshallingStruct : ValueType
    {
    }

    public class GlyphPairAdjustmentRecord : ValueType
    {
        public object firstAdjustmentRecord;
        public object secondAdjustmentRecord;
        public object featureLookupFlags;

        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7FFD54E1D540
        public void get_secondAdjustmentRecord(){} // RVA: 0x7FFD54E1A5E0
        public void get_featureLookupFlags(){} // RVA: 0x7FFD520AFE60
        public void GetHashCode(){} // RVA: 0x7FFD54E1D550
        public void Equals(){} // RVA: 0x7FFD54E1D640 | overloaded x2
    }

    public class GlyphValueRecord : ValueType
    {
        public object xPlacement;
        public object yPlacement;
        public object xAdvance;
        public object yAdvance;

        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x7FFD4E364D20
        public void set_xPlacement(){} // RVA: 0x7FFD4FEBB910
        public void get_yPlacement(){} // RVA: 0x7FFD4E364D30
        public void set_yPlacement(){} // RVA: 0x7FFD4FEBB8F0
        public void get_xAdvance(){} // RVA: 0x7FFD4E364CF0
        public void get_yAdvance(){} // RVA: 0x7FFD4E364D00
        public void op_Addition(){} // RVA: 0x7FFD54E1D260
        public void GetHashCode(){} // RVA: 0x7FFD54E1D280
        public void Equals(){} // RVA: 0x7FFD54E1D350 | overloaded x2
    }

    public class LigatureSubstitutionRecord : ValueType
    {
        public object componentGlyphIDs;
        public object ligatureGlyphID;

        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x7FFD505F9A30
        public void get_ligatureGlyphID(){} // RVA: 0x7FFD5195D9A0
    }

    public class MarkPositionAdjustment : ValueType
    {
        public object xPositionAdjustment;
        public object yPositionAdjustment;

        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x7FFD4E364D20
        public void get_yPositionAdjustment(){} // RVA: 0x7FFD4E364D30
    }

    public class MarkToBaseAdjustmentRecord : ValueType
    {
        public object baseGlyphID;
        public object baseGlyphAnchorPoint;
        public object markGlyphID;
        public object markPositionAdjustment;

        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x7FFD543B3F90
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x7FFD54D5FAC0
        public void get_markGlyphID(){} // RVA: 0x7FFD519BDBB0
        public void get_markPositionAdjustment(){} // RVA: 0x7FFD54D97900
    }

    public class MarkToMarkAdjustmentRecord : ValueType
    {
        public object baseMarkGlyphID;
        public object baseMarkGlyphAnchorPoint;
        public object combiningMarkGlyphID;
        public object combiningMarkPositionAdjustment;

        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x7FFD543B3F90
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x7FFD54D5FAC0
        public void get_combiningMarkGlyphID(){} // RVA: 0x7FFD519BDBB0
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x7FFD54D97900
    }

    public class MultipleSubstitutionRecord : ValueType
    {
    }

}