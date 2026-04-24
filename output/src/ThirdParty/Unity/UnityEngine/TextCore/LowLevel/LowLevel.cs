// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 12
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine : Object
    {
        public e.ypeHash[] s_Glyphs;
        public uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
        public tPackageJObject.tion[] s_GlyphMarshallingStruct_IN; // 0x10
        public tPackageJObject.tion[] s_GlyphMarshallingStruct_OUT; // 0x18
        public e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d[] s_FreeGlyphRects; // 0x20
        public e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d[] s_UsedGlyphRects; // 0x28
        public tPackageJObject.ngine.UnityWebRequestModule.dll[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
        public URA.DateTime<uint,e.ypeHash> s_GlyphLookupDictionary; // 0x38

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
        public string familyName; // 0x10
        public string styleName; // 0x18
        public int faceIndex; // 0x20
        public string filePath; // 0x28
    }

    public class GlyphAdjustmentRecord : ValueType
    {
        public uint glyphIndex; // 0x10
        public tPackageJObject.yEngine.UnityWebRequestModule glyphValueRecord; // 0x14

        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x7FFD543B3F90
        public void get_glyphValueRecord(){} // RVA: 0x7FFD54E1D3D0
        public void GetHashCode(){} // RVA: 0x7FFD54E1D3E0
        public void Equals(){} // RVA: 0x7FFD54E1D4B0 | overloaded x2
    }

    public class GlyphAnchorPoint : ValueType
    {
        public float xCoordinate; // 0x10
        public float yCoordinate; // 0x14

        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x7FFD4E364D20
        public void get_yCoordinate(){} // RVA: 0x7FFD4E364D30
    }

    public class GlyphMarshallingStruct : ValueType
    {
        public uint index; // 0x10
        public e._TryInitializePackageAsync|0>d metrics; // 0x14
        public e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d glyphRect; // 0x28
        public float scale; // 0x38
        public int atlasIndex; // 0x3C
        public e.c>g__InitializePackageAsync|2>d classDefinitionType; // 0x40
    }

    public class GlyphPairAdjustmentRecord : ValueType
    {
        public tPackageJObject.equestModule firstAdjustmentRecord; // 0x10
        public tPackageJObject.equestModule secondAdjustmentRecord; // 0x24
        public tPackageJObject.SS_STREAM_NAME featureLookupFlags; // 0x38

        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7FFD54E1D540
        public void get_secondAdjustmentRecord(){} // RVA: 0x7FFD54E1A5E0
        public void get_featureLookupFlags(){} // RVA: 0x7FFD520AFE60
        public void GetHashCode(){} // RVA: 0x7FFD54E1D550
        public void Equals(){} // RVA: 0x7FFD54E1D640 | overloaded x2
    }

    public class GlyphValueRecord : ValueType
    {
        public float xPlacement; // 0x10
        public float yPlacement; // 0x14
        public float xAdvance; // 0x18
        public float yAdvance; // 0x1C

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
        public uint[] componentGlyphIDs; // 0x10
        public uint ligatureGlyphID; // 0x18

        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x7FFD505F9A30
        public void get_ligatureGlyphID(){} // RVA: 0x7FFD5195D9A0
    }

    public class MarkPositionAdjustment : ValueType
    {
        public float xPositionAdjustment; // 0x10
        public float yPositionAdjustment; // 0x14

        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x7FFD4E364D20
        public void get_yPositionAdjustment(){} // RVA: 0x7FFD4E364D30
    }

    public class MarkToBaseAdjustmentRecord : ValueType
    {
        public uint baseGlyphID; // 0x10
        public tPackageJObject.e.dll baseGlyphAnchorPoint; // 0x14
        public uint markGlyphID; // 0x1C
        public tPackageJObject.ecode markPositionAdjustment; // 0x20

        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x7FFD543B3F90
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x7FFD54D5FAC0
        public void get_markGlyphID(){} // RVA: 0x7FFD519BDBB0
        public void get_markPositionAdjustment(){} // RVA: 0x7FFD54D97900
    }

    public class MarkToMarkAdjustmentRecord : ValueType
    {
        public uint baseMarkGlyphID; // 0x10
        public tPackageJObject.e.dll baseMarkGlyphAnchorPoint; // 0x14
        public uint combiningMarkGlyphID; // 0x1C
        public tPackageJObject.ecode combiningMarkPositionAdjustment; // 0x20

        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x7FFD543B3F90
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x7FFD54D5FAC0
        public void get_combiningMarkGlyphID(){} // RVA: 0x7FFD519BDBB0
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x7FFD54D97900
    }

    public class MultipleSubstitutionRecord : ValueType
    {
        public uint m_TargetGlyphID; // 0x10
        public uint[] m_SubstituteGlyphIDs; // 0x18
    }

}