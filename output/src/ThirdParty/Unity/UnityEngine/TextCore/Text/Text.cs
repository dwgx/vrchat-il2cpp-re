// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.Text
// Classes: 45
// Methods: 451

namespace ThirdParty.Unity.UnityEngine.TextCore.Text
{
    public class Character : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9739C80 | overloaded x3
    }

    public class CharacterSubstitution : ValueType
    {
        public int index; // 0x10
        public uint unicode; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
    }

    public class ColorUtilities : Object
    {
        // ── Methods ──
        public void CompareColors(){} // RVA: 0x7FFAC99FD700
        public void MultiplyColors(){} // RVA: 0x7FFAC99FD740
    }

    public class Extents : ValueType
    {
        public UnityEngine.Vector2 min; // 0x10
        public UnityEngine.Vector2 max; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC9A0BAB0
    }

    public class FontAsset : TextAsset
    {
        public string fontAssetCreationEditorSettings; // 0x38
        public UnityEngine.TextCore.Text.FontAssetCreationEditorSettings sourceFontFile; // 0x40
        public UnityEngine.Font atlasPopulationMode; // 0x98
        public string faceInfo; // 0xA0
        public 0x6B25BA90 familyNameHashCode; // 0xA8
        public bool styleNameHashCode; // 0xAC
        public UnityEngine.TextCore.FaceInfo glyphTable; // 0xB0
        public int glyphLookupTable; // 0x110
        public int characterTable; // 0x114
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> characterLookupTable; // 0x118
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Glyph> atlasTexture; // 0x120
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character> atlasTextures; // 0x128
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Text.Character> atlasTextureCount; // 0x130
        public UnityEngine.Texture2D isMultiAtlasTexturesEnabled; // 0x138
        public UnityEngine.Texture2D[] clearDynamicDataOnBuild; // 0x140
        public int atlasWidth; // 0x148
        public bool atlasHeight; // 0x14C
        public bool atlasPadding; // 0x14D
        public int atlasRenderMode; // 0x150
        public int usedGlyphRects; // 0x154
        public int freeGlyphRects; // 0x158
        public 0x6B2D23B8 fontFeatureTable; // 0x15C
        public System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect> fallbackFontAssetTable; // 0x160
        public System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect> fontWeightTable; // 0x168
        public UnityEngine.TextCore.Text.FontFeatureTable regularStyleWeight; // 0x170
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset> regularStyleSpacing; // 0x178
        public UnityEngine.TextCore.Text.FontWeightPair[] boldStyleWeight; // 0x180
        public float boldStyleSpacing; // 0x188
        public float italicStyleSlant; // 0x18C
        public float tabMultiple; // 0x190
        public float m_BoldStyleSpacing; // 0x194
        public byte m_ItalicStyleSlant; // 0x198
        public byte m_TabMultiple; // 0x199
        public bool IsFontAssetLookupTablesDirty; // 0x19A
        public Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
        public Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x28
        public Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker; // 0x30
        public Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker; // 0x38
        public Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker; // 0x40
        public string s_DefaultMaterialSuffix; // 0x48
        public System.Collections.Generic.HashSet`1<int> k_SearchedFontAssetLookup; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x58
        public System.Collections.Generic.HashSet`1<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x60
        public System.Collections.Generic.List`1<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x68
        public System.Collections.Generic.HashSet`1<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x70
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> m_GlyphsToRender; // 0x1A0
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> m_GlyphsRendered; // 0x1A8
        public System.Collections.Generic.List`1<uint> m_GlyphIndexList; // 0x1B0
        public System.Collections.Generic.List`1<uint> m_GlyphIndexListNewlyAdded; // 0x1B8
        public System.Collections.Generic.List`1<uint> m_GlyphsToAdd; // 0x1C0
        public System.Collections.Generic.HashSet`1<uint> m_GlyphsToAddLookup; // 0x1C8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character> m_CharactersToAdd; // 0x1D0
        public System.Collections.Generic.HashSet`1<uint> m_CharactersToAddLookup; // 0x1D8
        public System.Collections.Generic.List`1<uint> s_MissingCharacterList; // 0x1E0
        public System.Collections.Generic.HashSet`1<uint> m_MissingUnicodesFromFontFile; // 0x1E8
        public uint[] k_GlyphIndexArray; // 0x78

        // ── Methods ──
        public void get_fontAssetCreationEditorSettings(){} // RVA: 0x7FFAC99FD820
        public void set_fontAssetCreationEditorSettings(){} // RVA: 0x7FFAC99FD860
        public void get_sourceFontFile(){} // RVA: 0x7FFAC991FCC0
        public void set_sourceFontFile(){} // RVA: 0x7FFAC354E3C0
        public void get_atlasPopulationMode(){} // RVA: 0x7FFAC99FD8F0
        public void set_atlasPopulationMode(){} // RVA: 0x7FFAC38FD010
        public void get_faceInfo(){} // RVA: 0x7FFAC99FD900
        public void set_faceInfo(){} // RVA: 0x7FFAC99FD950
        public void get_familyNameHashCode(){} // RVA: 0x7FFAC99FD9E0
        public void set_familyNameHashCode(){} // RVA: 0x7FFAC4597C80
        public void get_styleNameHashCode(){} // RVA: 0x7FFAC99FDA20
        public void set_styleNameHashCode(){} // RVA: 0x7FFAC9745520
        public void get_glyphTable(){} // RVA: 0x7FFAC99FDA60
        public void set_glyphTable(){} // RVA: 0x7FFAC33B8580
        public void get_glyphLookupTable(){} // RVA: 0x7FFAC99FDA70
        public void get_characterTable(){} // RVA: 0x7FFAC99FDAB0
        public void set_characterTable(){} // RVA: 0x7FFAC39C51C0
        public void get_characterLookupTable(){} // RVA: 0x7FFAC99FDAC0
        public void get_atlasTexture(){} // RVA: 0x7FFAC99FDB00
        public void get_atlasTextures(){} // RVA: 0x7FFAC99FDC50
        public void set_atlasTextures(){} // RVA: 0x7FFAC2F8C600
        public void get_atlasTextureCount(){} // RVA: 0x7FFAC99FDC60
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFAC99FDC70
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFAC99FDC80
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFAC99FDC90
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFAC99FDCA0
        public void get_atlasWidth(){} // RVA: 0x7FFAC99FDCB0
        public void set_atlasWidth(){} // RVA: 0x7FFAC3C8EC20
        public void get_atlasHeight(){} // RVA: 0x7FFAC99FDCC0
        public void set_atlasHeight(){} // RVA: 0x7FFAC8B3EA00
        public void get_atlasPadding(){} // RVA: 0x7FFAC99FDCD0
        public void set_atlasPadding(){} // RVA: 0x7FFAC99FDCE0
        public void get_atlasRenderMode(){} // RVA: 0x7FFAC99FDCF0
        public void set_atlasRenderMode(){} // RVA: 0x7FFAC99FDD00
        public void get_usedGlyphRects(){} // RVA: 0x7FFAC99FDD10
        public void set_usedGlyphRects(){} // RVA: 0x7FFAC33AFA60
        public void get_freeGlyphRects(){} // RVA: 0x7FFAC99FDD20
        public void set_freeGlyphRects(){} // RVA: 0x7FFAC39A80B0
        public void get_fontFeatureTable(){} // RVA: 0x7FFAC99FDD30
        public void set_fontFeatureTable(){} // RVA: 0x7FFAC39B5DB0
        public void get_fallbackFontAssetTable(){} // RVA: 0x7FFAC99FDD40
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFAC39CA130
        public void get_fontWeightTable(){} // RVA: 0x7FFAC99FDD50
        public void set_fontWeightTable(){} // RVA: 0x7FFAC3503070
        public void get_regularStyleWeight(){} // RVA: 0x7FFAC99FDD60
        public void set_regularStyleWeight(){} // RVA: 0x7FFAC99FDD70
        public void get_regularStyleSpacing(){} // RVA: 0x7FFAC99FDD80
        public void set_regularStyleSpacing(){} // RVA: 0x7FFAC99FDD90
        public void get_boldStyleWeight(){} // RVA: 0x7FFAC99FDDA0
        public void set_boldStyleWeight(){} // RVA: 0x7FFAC99FDDB0
        public void get_boldStyleSpacing(){} // RVA: 0x7FFAC99FDDC0
        public void set_boldStyleSpacing(){} // RVA: 0x7FFAC99FDDD0
        public void get_italicStyleSlant(){} // RVA: 0x7FFAC99FDDE0
        public void set_italicStyleSlant(){} // RVA: 0x7FFAC8B3EC00
        public void get_tabMultiple(){} // RVA: 0x7FFAC99FDDF0
        public void set_tabMultiple(){} // RVA: 0x7FFAC8C44910
        public void CreateFontAsset(){} // RVA: 0x7FFAC99FE480 | overloaded x6
        public void CreateFontAssetInstance(){} // RVA: 0x7FFAC99FE6B0
        public void Awake(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC99FF010
        public void ReadFontAssetDefinition(){} // RVA: 0x7FFAC99FF1B0
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7FFAC99FF5D0
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7FFAC99FF620
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7FFAC99FF9C0
        public void InitializeLigatureSubstitutionLookupDictionary(){} // RVA: 0x7FFAC99FFC30
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFAC99FFFB0
        public void InitializeMarkToBaseAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFAC9A002B0
        public void InitializeMarkToMarkAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFAC9A005D0
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7FFAC9A008F0
        public void AddSynthesizedCharacter(){} // RVA: 0x7FFAC9A00B00
        public void AddCharacterToLookupCache(){} // RVA: 0x7FFAC9A00DE0
        public void LoadFontFace(){} // RVA: 0x7FFAC9A00E70
        public void SortCharacterTable(){} // RVA: 0x7FFAC9A01030
        public void SortGlyphTable(){} // RVA: 0x7FFAC9A012D0
        public void SortFontFeatureTable(){} // RVA: 0x7FFAC9A01570
        public void SortAllTables(){} // RVA: 0x7FFAC9A015C0
        public void HasCharacter(){} // RVA: 0x7FFAC9A016C0 | overloaded x3
        public void HasCharacter_Internal(){} // RVA: 0x7FFAC9A01B50
        public void HasCharacters(){} // RVA: 0x7FFAC9A026F0 | overloaded x3
        public void GetCharacters(){} // RVA: 0x7FFAC9A027C0
        public void GetCharactersArray(){} // RVA: 0x7FFAC9A02950
        public void GetGlyphIndex(){} // RVA: 0x7FFAC9A02A30
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7FFAC9A02B70
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7FFAC9A02CD0
        public void RegisterAtlasTextureForApply(){} // RVA: 0x7FFAC9A02F10
        public void UpdateAtlasTexturesInQueue(){} // RVA: 0x7FFAC9A03010
        public void UpdateFontAssetsInUpdateQueue(){} // RVA: 0x7FFAC9A03210
        public void TryAddCharacters(){} // RVA: 0x7FFAC9A04170 | overloaded x4
        public void TryAddGlyphInternal(){} // RVA: 0x7FFAC9A050B0
        public void TryAddCharacterInternal(){} // RVA: 0x7FFAC9A05990
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x7FFAC9A06440
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x7FFAC2F21310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7FFAC9A06920
        public void SetupNewAtlasTexture(){} // RVA: 0x7FFAC9A06DF0
        public void UpdateAllFontFeatures(){} // RVA: 0x7FFAC9A07100
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7FFAC2F21310 | overloaded x4
        public void CopyListDataToArray(){} // RVA: 0x7FFAC2C79B30
        public void ClearFontAssetData(){} // RVA: 0x7FFAC9A079E0
        public void ClearFontAssetDataInternal(){} // RVA: 0x7FFAC9A07B00
        public void UpdateFontAssetData(){} // RVA: 0x7FFAC9A07B30
        public void ClearFontAssetTables(){} // RVA: 0x7FFAC9A07D70
        public void ClearAtlasTextures(){} // RVA: 0x7FFAC9A08080
        public void DestroyAtlasTextures(){} // RVA: 0x7FFAC9A08420
        public void .ctor(){} // RVA: 0x7FFAC9A08580
        public void .cctor(){} // RVA: 0x7FFAC9A08CC0
    }

    public class FontAssetCreationEditorSettings : ValueType
    {
        public string sourceFontFileGUID; // 0x10
        public int faceIndex; // 0x18
        public int pointSizeSamplingMode; // 0x1C
        public int pointSize; // 0x20
        public int padding; // 0x24
        public int paddingMode; // 0x28
        public int packingMode; // 0x2C
        public int atlasWidth; // 0x30
        public int atlasHeight; // 0x34
        public int characterSetSelectionMode; // 0x38
        public string characterSequence; // 0x40
        public string referencedFontAssetGUID; // 0x48
        public string referencedTextAssetGUID; // 0x50
        public int fontStyle; // 0x58
        public float fontStyleModifier; // 0x5C
        public int renderMode; // 0x60
        public bool includeFontFeatures; // 0x64
    }

    public class FontAssetUtilities : Object
    {
        public System.Collections.Generic.HashSet`1<int> k_SearchedAssets;

        // ── Methods ──
        public void GetCharacterFromFontAsset(){} // RVA: 0x7FFAC9A09520
        public void GetCharacterFromFontAsset_Internal(){} // RVA: 0x7FFAC9A09690
        public void GetCharacterFromFontAssets(){} // RVA: 0x7FFAC9A09D70
        public void GetSpriteCharacterFromSpriteAsset(){} // RVA: 0x7FFAC9A09FF0
        public void GetSpriteCharacterFromSpriteAsset_Internal(){} // RVA: 0x7FFAC9A0A3D0
    }

    public class FontFeatureTable : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
        public System.Collections.Generic.Dictionary`2<uint,System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A0A640
        public void SortGlyphPairAdjustmentRecords(){} // RVA: 0x7FFAC9A0AAE0
        public void SortMarkToBaseAdjustmentRecords(){} // RVA: 0x7FFAC9A0AFE0
        public void SortMarkToMarkAdjustmentRecords(){} // RVA: 0x7FFAC9A0B4E0
    }

    public class FontStyleStack : ValueType
    {
        public byte bold; // 0x10
        public byte italic; // 0x11
        public byte underline; // 0x12
        public byte strikethrough; // 0x13
        public byte highlight; // 0x14
        public byte superscript; // 0x15
        public byte subscript; // 0x16
        public byte uppercase; // 0x17
        public byte lowercase; // 0x18
        public byte smallcaps; // 0x19

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAC97A25B0
        public void Add(){} // RVA: 0x7FFAC9A42E30
        public void Remove(){} // RVA: 0x7FFAC97A2670
    }

    public class FontWeightPair : ValueType
    {
        public UnityEngine.TextCore.Text.FontAsset regularTypeface; // 0x10
        public UnityEngine.TextCore.Text.FontAsset italicTypeface; // 0x18
    }

    public class HighlightState : ValueType
    {
        public UnityEngine.Color32 color; // 0x10
        public UnityEngine.TextCore.Text.Offset padding; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F2100
        public void op_Equality(){} // RVA: 0x7FFAC9A3A0E0
        public void op_Inequality(){} // RVA: 0x7FFAC9A3A220
        public void GetHashCode(){} // RVA: 0x7FFAC9A3A370
        public void Equals(){} // RVA: 0x7FFAC9A3A3D0
    }

    public class LineInfo : ValueType
    {
        public int controlCharacterCount; // 0x10
        public int characterCount; // 0x14
        public int visibleCharacterCount; // 0x18
        public int spaceCount; // 0x1C
        public int visibleSpaceCount; // 0x20
        public int wordCount; // 0x24
        public int firstCharacterIndex; // 0x28
        public int firstVisibleCharacterIndex; // 0x2C
        public int lastCharacterIndex; // 0x30
        public int lastVisibleCharacterIndex; // 0x34
        public float length; // 0x38
        public float lineHeight; // 0x3C
        public float ascender; // 0x40
        public float baseline; // 0x44
        public float descender; // 0x48
        public float maxAdvance; // 0x4C
        public float width; // 0x50
        public float marginLeft; // 0x54
        public float marginRight; // 0x58
        public 0x6B25C488 alignment; // 0x5C
        public UnityEngine.TextCore.Text.Extents lineExtents; // 0x60
    }

    public class LinkInfo : ValueType
    {
        public int hashCode; // 0x10
        public int linkIdFirstCharacterIndex; // 0x14
        public int linkIdLength; // 0x18
        public int linkTextfirstCharacterIndex; // 0x1C
        public int linkTextLength; // 0x20
        public char[] linkId; // 0x28
        public string m_LinkIdString; // 0x30
        public string m_LinkTextString; // 0x38

        // ── Methods ──
        public void SetLinkId(){} // RVA: 0x7FFAC9A0BC60
        public void GetLinkText(){} // RVA: 0x7FFAC9A0BE30
        public void GetLinkId(){} // RVA: 0x7FFAC9A0BFE0
    }

    public class MaterialManager : Object
    {
        public System.Collections.Generic.Dictionary`2<long,UnityEngine.Material> s_FallbackMaterials;

        // ── Methods ──
        public void GetFallbackMaterial(){} // RVA: 0x7FFAC9A0C5C0 | overloaded x2
        public void CopyMaterialPresetProperties(){} // RVA: 0x7FFAC9A0C8F0
        public void .cctor(){} // RVA: 0x7FFAC9A0CEF0
    }

    public class MaterialReference : ValueType
    {
        public int index; // 0x10
        public UnityEngine.TextCore.Text.FontAsset fontAsset; // 0x18
        public UnityEngine.TextCore.Text.SpriteAsset spriteAsset; // 0x20
        public UnityEngine.Material material; // 0x28
        public bool isDefaultMaterial; // 0x30
        public bool isFallbackMaterial; // 0x31
        public UnityEngine.Material fallbackMaterial; // 0x38
        public float padding; // 0x40
        public int referenceCount; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A0CFD0
        public void AddMaterialReference(){} // RVA: 0x7FFAC9A0D550 | overloaded x2
    }

    public class MaterialReferenceManager : Object
    {
        public UnityEngine.TextCore.Text.MaterialReferenceManager instance;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.Material> m_FontMaterialReferenceLookup; // 0x10
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup; // 0x18
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC9A0D8E0
        public void AddFontAsset(){} // RVA: 0x7FFAC9A0D9C0
        public void AddFontAssetInternal(){} // RVA: 0x7FFAC9A0D9F0
        public void AddSpriteAsset(){} // RVA: 0x7FFAC9A0DC30
        public void AddSpriteAssetInternal(){} // RVA: 0x7FFAC9A0DD50
        public void AddFontMaterial(){} // RVA: 0x7FFAC9A0DE60
        public void AddFontMaterialInternal(){} // RVA: 0x7FFAC9A0DEF0
        public void AddColorGradientPreset(){} // RVA: 0x7FFAC9A0DF80
        public void AddColorGradientPreset_Internal(){} // RVA: 0x7FFAC9A0E050
        public void TryGetFontAsset(){} // RVA: 0x7FFAC9A0E110
        public void TryGetFontAssetInternal(){} // RVA: 0x7FFAC9A0E1D0
        public void TryGetSpriteAsset(){} // RVA: 0x7FFAC9A0E280
        public void TryGetSpriteAssetInternal(){} // RVA: 0x7FFAC9A0E340
        public void TryGetColorGradientPreset(){} // RVA: 0x7FFAC9A0E3F0
        public void TryGetColorGradientPresetInternal(){} // RVA: 0x7FFAC9A0E4B0
        public void TryGetMaterial(){} // RVA: 0x7FFAC9A0E560
        public void TryGetMaterialInternal(){} // RVA: 0x7FFAC9A0E620
        public void .ctor(){} // RVA: 0x7FFAC9A0E6D0
    }

    public class MeshInfo : ValueType
    {
        public UnityEngine.Color32 k_DefaultColor;
        public UnityEngine.Vector3 k_DefaultNormal; // 0x4
        public UnityEngine.Vector4 k_DefaultTangent; // 0x10
        public int vertexCount; // 0x10
        public UnityEngine.Vector3[] vertices; // 0x18
        public UnityEngine.Vector3[] normals; // 0x20
        public UnityEngine.Vector4[] tangents; // 0x28
        public UnityEngine.Vector4[] uvs0; // 0x30
        public UnityEngine.Vector2[] uvs2; // 0x38
        public UnityEngine.Color32[] colors32; // 0x40
        public int[] triangles; // 0x48
        public UnityEngine.Material material; // 0x50
        public 0x6B2D23B8 glyphRenderMode; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A0E960
        public void ResizeMeshInfo(){} // RVA: 0x7FFAC9A0F060
        public void Clear(){} // RVA: 0x7FFAC9A0F280
        public void ClearUnusedVertices(){} // RVA: 0x7FFAC9A0F2C0
        public void SortGeometry(){} // RVA: 0x7FFAC9A0F300
        public void SwapVertexData(){} // RVA: 0x7FFAC9A0F3B0
        public void .cctor(){} // RVA: 0x7FFAC9A0FB80
    }

    public class Offset : ValueType
    {
        public float left; // 0x10
        public float right; // 0x14
        public float top; // 0x18
        public float bottom; // 0x1C
        public UnityEngine.TextCore.Text.Offset zero;

        // ── Methods ──
        public void get_left(){} // RVA: 0x7FFAC2F44D20
        public void get_right(){} // RVA: 0x7FFAC2F44D30
        public void get_top(){} // RVA: 0x7FFAC2F44CF0
        public void get_bottom(){} // RVA: 0x7FFAC2F44D00
        public void get_zero(){} // RVA: 0x7FFAC9A39F60
        public void .ctor(){} // RVA: 0x7FFAC2F45570
        public void op_Equality(){} // RVA: 0x7FFAC8F79BA0
        public void op_Multiply(){} // RVA: 0x7FFAC98A8860
        public void GetHashCode(){} // RVA: 0x7FFAC9A39FD0
        public void Equals(){} // RVA: 0x7FFAC9A3A030
        public void .cctor(){} // RVA: 0x7FFAC9A3A0A0
    }

    public class PageInfo : ValueType
    {
        public int firstCharacterIndex; // 0x10
        public int lastCharacterIndex; // 0x14
        public float ascender; // 0x18
        public float baseLine; // 0x1C
        public float descender; // 0x20
    }

    public class RichTextTagAttribute : ValueType
    {
        public int nameHashCode; // 0x10
        public int valueHashCode; // 0x14
        public 0x6B25CB10 valueType; // 0x18
        public int valueStartIndex; // 0x1C
        public int valueLength; // 0x20
        public 0x6B25CB68 unitType; // 0x24
    }

    public class SpriteAsset : TextAsset
    {
        public System.Collections.Generic.Dictionary`2<int,int> faceInfo; // 0x38
        public System.Collections.Generic.Dictionary`2<uint,int> spriteSheet; // 0x40
        public UnityEngine.TextCore.FaceInfo spriteCharacterTable; // 0x48
        public UnityEngine.Texture spriteCharacterLookupTable; // 0xA8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter> spriteGlyphTable; // 0xB0
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable; // 0xC0
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets; // 0xD0
        public bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
        public System.Collections.Generic.HashSet`1<int> k_searchedSpriteAssets;

        // ── Methods ──
        public void get_faceInfo(){} // RVA: 0x7FFAC9A0FC10
        public void set_faceInfo(){} // RVA: 0x7FFAC9796FD0
        public void get_spriteSheet(){} // RVA: 0x7FFAC991FDA0
        public void set_spriteSheet(){} // RVA: 0x7FFAC334B370
        public void get_spriteCharacterTable(){} // RVA: 0x7FFAC9A0FC50
        public void set_spriteCharacterTable(){} // RVA: 0x7FFAC2F8C050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7FFAC9A0FC90
        public void set_spriteCharacterLookupTable(){} // RVA: 0x7FFAC2F8C0C0
        public void get_spriteGlyphTable(){} // RVA: 0x7FFAC991FEF0
        public void set_spriteGlyphTable(){} // RVA: 0x7FFAC2F8C130
        public void Awake(){} // RVA: 0x7FFAC2F21310
        public void UpdateLookupTables(){} // RVA: 0x7FFAC9A0FCD0
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7FFAC9A10470
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7FFAC9A10520
        public void GetSpriteIndexFromName(){} // RVA: 0x7FFAC9A105C0
        public void SearchForSpriteByUnicode(){} // RVA: 0x7FFAC9A10600
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7FFAC9A10B10 | overloaded x2
        public void SearchForSpriteByHashCode(){} // RVA: 0x7FFAC9A10BD0
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7FFAC9A113D0 | overloaded x2
        public void SortGlyphTable(){} // RVA: 0x7FFAC9A11490
        public void SortCharacterTable(){} // RVA: 0x7FFAC9A11730
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7FFAC9A119D0
        public void .ctor(){} // RVA: 0x7FFAC9A119F0
    }

    public class SpriteCharacter : TextElement
    {
        public string name; // 0x30

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC98DE3D0
        public void .ctor(){} // RVA: 0x7FFAC9799990
    }

    public class SpriteGlyph : Glyph
    {
        public UnityEngine.Sprite sprite; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9799BD0
    }

    public class TextAsset : ScriptableObject
    {
        public string version; // 0x18
        public int instanceID; // 0x20
        public int hashCode; // 0x24
        public UnityEngine.Material material; // 0x28
        public int materialHashCode; // 0x30

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFAC58A1130
        public void set_version(){} // RVA: 0x7FFAC2F87E80
        public void get_instanceID(){} // RVA: 0x7FFAC9A11C10
        public void get_hashCode(){} // RVA: 0x7FFAC9A11C40
        public void set_hashCode(){} // RVA: 0x7FFAC41674D0
        public void get_material(){} // RVA: 0x7FFAC2F4F130
        public void set_material(){} // RVA: 0x7FFAC2F22E90
        public void get_materialHashCode(){} // RVA: 0x7FFAC9A11C80
        public void set_materialHashCode(){} // RVA: 0x7FFAC2F7CCE0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class TextBackingContainer : ValueType
    {
        public uint[] Capacity; // 0x10
        public int Count; // 0x18

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFAC5E86060
        public void get_Count(){} // RVA: 0x7FFAC653D9A0
        public void set_Count(){} // RVA: 0x7FFAC49C7510
        public void get_Item(){} // RVA: 0x7FFAC5DB90C0
        public void set_Item(){} // RVA: 0x7FFAC9A39DC0
        public void .ctor(){} // RVA: 0x7FFAC9A39E20
        public void Resize(){} // RVA: 0x7FFAC9A39ED0
    }

    public class TextColorGradient : ScriptableObject
    {
        public 0x6B25C118 colorMode; // 0x18
        public UnityEngine.Color topLeft; // 0x1C
        public UnityEngine.Color topRight; // 0x2C
        public UnityEngine.Color bottomLeft; // 0x3C
        public UnityEngine.Color bottomRight; // 0x4C
        public 0x6B25C118 k_DefaultColorMode;
        public UnityEngine.Color k_DefaultColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC973A5B0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC9A11E50
    }

    public class TextElement : Object
    {
        public 0x6B25C1C8 elementType; // 0x10
        public uint unicode; // 0x14
        public UnityEngine.TextCore.Text.TextAsset textAsset; // 0x18
        public UnityEngine.TextCore.Glyph glyph; // 0x20
        public uint glyphIndex; // 0x28
        public float scale; // 0x2C

        // ── Methods ──
        public void get_elementType(){} // RVA: 0x7FFAC991F110
        public void get_unicode(){} // RVA: 0x7FFAC5872100
        public void set_unicode(){} // RVA: 0x7FFAC33D4990
        public void get_textAsset(){} // RVA: 0x7FFAC58A1130
        public void set_textAsset(){} // RVA: 0x7FFAC2F87E80
        public void get_glyph(){} // RVA: 0x7FFAC91BAEE0
        public void set_glyph(){} // RVA: 0x7FFAC2F4F0D0
        public void get_glyphIndex(){} // RVA: 0x7FFAC6C8FE60
        public void set_glyphIndex(){} // RVA: 0x7FFAC369A6E0
        public void get_scale(){} // RVA: 0x7FFAC993FB10
        public void set_scale(){} // RVA: 0x7FFAC33EA9D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TextElementInfo : ValueType
    {
        public char character; // 0x10
        public int index; // 0x14
        public 0x6B25C1C8 elementType; // 0x18
        public int stringLength; // 0x1C
        public UnityEngine.TextCore.Text.TextElement textElement; // 0x20
        public UnityEngine.TextCore.Glyph alternativeGlyph; // 0x28
        public UnityEngine.TextCore.Text.FontAsset fontAsset; // 0x30
        public UnityEngine.TextCore.Text.SpriteAsset spriteAsset; // 0x38
        public int spriteIndex; // 0x40
        public UnityEngine.Material material; // 0x48
        public int materialReferenceIndex; // 0x50
        public bool isUsingAlternateTypeface; // 0x54
        public float pointSize; // 0x58
        public int lineNumber; // 0x5C
        public int pageNumber; // 0x60
        public int vertexIndex; // 0x64
        public UnityEngine.TextCore.Text.TextVertex vertexTopLeft; // 0x68
        public UnityEngine.TextCore.Text.TextVertex vertexBottomLeft; // 0x90
        public UnityEngine.TextCore.Text.TextVertex vertexTopRight; // 0xB8
        public UnityEngine.TextCore.Text.TextVertex vertexBottomRight; // 0xE0
        public UnityEngine.Vector3 topLeft; // 0x108
        public UnityEngine.Vector3 bottomLeft; // 0x114
        public UnityEngine.Vector3 topRight; // 0x120
        public UnityEngine.Vector3 bottomRight; // 0x12C
        public float origin; // 0x138
        public float ascender; // 0x13C
        public float baseLine; // 0x140
        public float descender; // 0x144
        public float adjustedAscender; // 0x148
        public float adjustedDescender; // 0x14C
        public float adjustedHorizontalAdvance; // 0x150
        public float xAdvance; // 0x154
        public float aspectRatio; // 0x158
        public float scale; // 0x15C
        public UnityEngine.Color32 color; // 0x160
        public UnityEngine.Color32 underlineColor; // 0x164
        public int underlineVertexIndex; // 0x168
        public UnityEngine.Color32 strikethroughColor; // 0x16C
        public int strikethroughVertexIndex; // 0x170
        public UnityEngine.Color32 highlightColor; // 0x174
        public UnityEngine.TextCore.Text.HighlightState highlightState; // 0x178
        public 0x6B25C4E0 style; // 0x18C
        public bool isVisible; // 0x190

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC9A11EA0
    }

    public class TextGenerationSettings : Object
    {
        public string text; // 0x10
        public UnityEngine.Rect screenRect; // 0x18
        public UnityEngine.Vector4 margins; // 0x28
        public float scale; // 0x38
        public UnityEngine.TextCore.Text.FontAsset fontAsset; // 0x40
        public UnityEngine.Material material; // 0x48
        public UnityEngine.TextCore.Text.SpriteAsset spriteAsset; // 0x50
        public UnityEngine.TextCore.Text.TextStyleSheet styleSheet; // 0x58
        public 0x6B25C4E0 fontStyle; // 0x60
        public UnityEngine.TextCore.Text.TextSettings textSettings; // 0x68
        public 0x6B25C488 textAlignment; // 0x70
        public 0x6B25C538 overflowMode; // 0x74
        public bool wordWrap; // 0x78
        public float wordWrappingRatio; // 0x7C
        public UnityEngine.Color color; // 0x80
        public UnityEngine.TextCore.Text.TextColorGradient fontColorGradient; // 0x90
        public UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset; // 0x98
        public bool tintSprites; // 0xA0
        public bool overrideRichTextColors; // 0xA1
        public bool shouldConvertToLinearSpace; // 0xA2
        public float fontSize; // 0xA4
        public bool autoSize; // 0xA8
        public float fontSizeMin; // 0xAC
        public float fontSizeMax; // 0xB0
        public bool enableKerning; // 0xB4
        public bool richText; // 0xB5
        public bool isRightToLeft; // 0xB6
        public float extraPadding; // 0xB8
        public bool parseControlCharacters; // 0xBC
        public bool isOrthographic; // 0xBD
        public bool tagNoParsing; // 0xBE
        public float characterSpacing; // 0xC0
        public float wordSpacing; // 0xC4
        public float lineSpacing; // 0xC8
        public float paragraphSpacing; // 0xCC
        public float lineSpacingMax; // 0xD0
        public 0x6B25C5E8 textWrappingMode; // 0xD4
        public int maxVisibleCharacters; // 0xD8
        public int maxVisibleWords; // 0xDC
        public int maxVisibleLines; // 0xE0
        public int firstVisibleCharacter; // 0xE4
        public bool useMaxVisibleDescender; // 0xE8
        public 0x6B25B988 fontWeight; // 0xEC
        public int pageToDisplay; // 0xF0
        public 0x6B25C590 horizontalMapping; // 0xF4
        public 0x6B25C590 verticalMapping; // 0xF8
        public float uvLineOffset; // 0xFC
        public 0x6B25BEB0 geometrySortingOrder; // 0x100
        public bool inverseYAxis; // 0x104
        public float charWidthMaxAdj; // 0x108
        public 0x6B25C640 inputSource; // 0x10C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC9A145C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9A146D0
        public void op_Equality(){} // RVA: 0x7FFAC9A15940
        public void ToString(){} // RVA: 0x7FFAC9A15980
        public void .ctor(){} // RVA: 0x7FFAC9A17E30
    }

    public class TextGenerator : Object
    {
        public UnityEngine.TextCore.Text.TextGenerator isTextTruncated;
        public UnityEngine.TextCore.Text.TextBackingContainer m_TextBackingArray; // 0x10
        public UnityEngine.TextCore.Text.TextProcessingElement[] m_TextProcessingArray; // 0x20
        public int m_InternalTextProcessingArraySize; // 0x28
        public bool m_VertexBufferAutoSizeReduction; // 0x2C
        public char[] m_HtmlTag; // 0x30
        public UnityEngine.TextCore.Text.HighlightState m_HighlightState; // 0x38
        public bool m_IsIgnoringAlignment; // 0x4C
        public bool m_IsTextTruncated; // 0x8
        public MissingCharacterEventCallback OnMissingCharacter; // 0x10
        public UnityEngine.Vector3[] m_RectTransformCorners; // 0x50
        public float m_MarginWidth; // 0x58
        public float m_MarginHeight; // 0x5C
        public float m_PreferredWidth; // 0x60
        public float m_PreferredHeight; // 0x64
        public UnityEngine.TextCore.Text.FontAsset m_CurrentFontAsset; // 0x68
        public UnityEngine.Material m_CurrentMaterial; // 0x70
        public int m_CurrentMaterialIndex; // 0x78
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.MaterialReference> m_MaterialReferenceStack; // 0x80
        public float m_Padding; // 0xD8
        public UnityEngine.TextCore.Text.SpriteAsset m_CurrentSpriteAsset; // 0xE0
        public int m_TotalCharacterCount; // 0xE8
        public float m_FontSize; // 0xEC
        public float m_FontScaleMultiplier; // 0xF0
        public float m_CurrentFontSize; // 0xF4
        public UnityEngine.TextCore.Text.TextProcessingStack`1<float> m_SizeStack; // 0xF8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int>[] m_TextStyleStacks; // 0x118
        public int m_TextStyleStackDepth; // 0x120
        public 0x6B25C4E0 m_FontStyleInternal; // 0x124
        public UnityEngine.TextCore.Text.FontStyleStack m_FontStyleStack; // 0x128
        public 0x6B25B988 m_FontWeightInternal; // 0x134
        public UnityEngine.TextCore.Text.TextProcessingStack`1<0x6B25B988> m_FontWeightStack; // 0x138
        public 0x6B25C488 m_LineJustification; // 0x158
        public UnityEngine.TextCore.Text.TextProcessingStack`1<0x6B25C488> m_LineJustificationStack; // 0x160
        public float m_BaselineOffset; // 0x180
        public UnityEngine.TextCore.Text.TextProcessingStack`1<float> m_BaselineOffsetStack; // 0x188
        public UnityEngine.Color32 m_FontColor32; // 0x1A8
        public UnityEngine.Color32 m_HtmlColor; // 0x1AC
        public UnityEngine.Color32 m_UnderlineColor; // 0x1B0
        public UnityEngine.Color32 m_StrikethroughColor; // 0x1B4
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> m_ColorStack; // 0x1B8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> m_UnderlineColorStack; // 0x1D8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> m_StrikethroughColorStack; // 0x1F8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> m_HighlightColorStack; // 0x218
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.HighlightState> m_HighlightStateStack; // 0x238
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int> m_ItalicAngleStack; // 0x268
        public UnityEngine.TextCore.Text.TextColorGradient m_ColorGradientPreset; // 0x288
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientStack; // 0x290
        public bool m_ColorGradientPresetIsTinted; // 0x2B8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int> m_ActionStack; // 0x2C0
        public float m_LineOffset; // 0x2E0
        public float m_LineHeight; // 0x2E4
        public bool m_IsDrivenLineSpacing; // 0x2E8
        public float m_CSpacing; // 0x2EC
        public float m_MonoSpacing; // 0x2F0
        public float m_XAdvance; // 0x2F4
        public float m_TagLineIndent; // 0x2F8
        public float m_TagIndent; // 0x2FC
        public UnityEngine.TextCore.Text.TextProcessingStack`1<float> m_IndentStack; // 0x300
        public bool m_TagNoParsing; // 0x320
        public int m_CharacterCount; // 0x324
        public int m_FirstCharacterOfLine; // 0x328
        public int m_LastCharacterOfLine; // 0x32C
        public int m_FirstVisibleCharacterOfLine; // 0x330
        public int m_LastVisibleCharacterOfLine; // 0x334
        public float m_MaxLineAscender; // 0x338
        public float m_MaxLineDescender; // 0x33C
        public int m_LineNumber; // 0x340
        public int m_LineVisibleCharacterCount; // 0x344
        public int m_LineVisibleSpaceCount; // 0x348
        public int m_FirstOverflowCharacterIndex; // 0x34C
        public int m_PageNumber; // 0x350
        public float m_MarginLeft; // 0x354
        public float m_MarginRight; // 0x358
        public float m_Width; // 0x35C
        public UnityEngine.TextCore.Text.Extents m_MeshExtents; // 0x360
        public float m_MaxCapHeight; // 0x370
        public float m_MaxAscender; // 0x374
        public float m_MaxDescender; // 0x378
        public bool m_IsNewPage; // 0x37C
        public bool m_IsNonBreakingSpace; // 0x37D
        public UnityEngine.TextCore.Text.WordWrapState m_SavedWordWrapState; // 0x380
        public UnityEngine.TextCore.Text.WordWrapState m_SavedLineState; // 0x718
        public UnityEngine.TextCore.Text.WordWrapState m_SavedEllipsisState; // 0xAB0
        public UnityEngine.TextCore.Text.WordWrapState m_SavedLastValidState; // 0xE48
        public UnityEngine.TextCore.Text.WordWrapState m_SavedSoftLineBreakState; // 0x11E0
        public 0x6B25C1C8 m_TextElementType; // 0x1578
        public bool m_isTextLayoutPhase; // 0x1579
        public int m_SpriteIndex; // 0x157C
        public UnityEngine.Color32 m_SpriteColor; // 0x1580
        public UnityEngine.TextCore.Text.TextElement m_CachedTextElement; // 0x1588
        public UnityEngine.Color32 m_HighlightColor; // 0x1590
        public float m_CharWidthAdjDelta; // 0x1594
        public float m_MaxFontSize; // 0x1598
        public float m_MinFontSize; // 0x159C
        public int m_AutoSizeIterationCount; // 0x15A0
        public int m_AutoSizeMaxIterationCount; // 0x15A4
        public bool m_IsAutoSizePointSizeSet; // 0x15A8
        public float m_StartOfLineAscender; // 0x15AC
        public float m_LineSpacingDelta; // 0x15B0
        public UnityEngine.TextCore.Text.MaterialReference[] m_MaterialReferences; // 0x15B8
        public int m_SpriteCount; // 0x15C0
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int> m_StyleStack; // 0x15C8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState> m_EllipsisInsertionCandidateStack; // 0x15E8
        public int m_SpriteAnimationId; // 0x19A0
        public int m_ItalicAngle; // 0x19A4
        public UnityEngine.Vector3 m_FXScale; // 0x19A8
        public UnityEngine.Quaternion m_FXRotation; // 0x19B4
        public int m_LastBaseGlyphIndex; // 0x19C4
        public float m_PageAscender; // 0x19C8
        public UnityEngine.TextCore.Text.RichTextTagAttribute[] m_XmlAttribute; // 0x19D0
        public float[] m_AttributeParameterValues; // 0x19D8
        public System.Collections.Generic.Dictionary`2<int,int> m_MaterialReferenceIndexLookup; // 0x19E0
        public bool m_IsCalculatingPreferredValues; // 0x19E8
        public UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset; // 0x19F0
        public bool m_TintSprite; // 0x19F8
        public SpecialCharacter m_Ellipsis; // 0x1A00
        public SpecialCharacter m_Underline; // 0x1A20
        public UnityEngine.TextCore.Text.TextElementInfo[] m_InternalTextElementInfo; // 0x1A40

        // ── Methods ──
        public void GetTextGenerator(){} // RVA: 0x7FFAC9A25200
        public void GenerateText(){} // RVA: 0x7FFAC9A252E0
        public void GetPreferredValues(){} // RVA: 0x7FFAC9A25540
        public void get_isTextTruncated(){} // RVA: 0x7FFAC9A258E0
        public void Prepare(){} // RVA: 0x7FFAC9A25920
        public void GenerateTextMesh(){} // RVA: 0x7FFAC9A17EE0
        public void SaveWordWrappingState(){} // RVA: 0x7FFAC9A25B70
        public void RestoreWordWrappingState(){} // RVA: 0x7FFAC9A26630
        public void ValidateHtmlTag(){} // RVA: 0x7FFAC9A270D0
        public void SaveGlyphVertexInfo(){} // RVA: 0x7FFAC9A2CF60
        public void SaveSpriteVertexInfo(){} // RVA: 0x7FFAC9A2E310
        public void DrawUnderlineMesh(){} // RVA: 0x7FFAC9A2EE70
        public void DrawTextHighlight(){} // RVA: 0x7FFAC9A300D0
        public void ClearMesh(){} // RVA: 0x7FFAC9A307D0
        public void SetArraySizes(){} // RVA: 0x7FFAC9A308B0
        public void GetTextElement(){} // RVA: 0x7FFAC9A32490
        public void ComputeMarginSize(){} // RVA: 0x7FFAC9A329D0
        public void GetSpecialCharacters(){} // RVA: 0x7FFAC9A32AD0
        public void GetEllipsisSpecialCharacter(){} // RVA: 0x7FFAC9A32B00
        public void GetUnderlineSpecialCharacter(){} // RVA: 0x7FFAC9A32E60
        public void GetPreferredValuesInternal(){} // RVA: 0x7FFAC9A32FD0
        public void CalculatePreferredValues(){} // RVA: 0x7FFAC9A331E0
        public void PopulateTextBackingArray(){} // RVA: 0x7FFAC9A36A60 | overloaded x2
        public void PopulateTextProcessingArray(){} // RVA: 0x7FFAC9A36BE0
        public void InsertNewLine(){} // RVA: 0x7FFAC9A37C30
        public void DoMissingGlyphCallback(){} // RVA: 0x7FFAC9A38480
        public void ClearMarkupTagAttributes(){} // RVA: 0x7FFAC9A38510
        public void .ctor(){} // RVA: 0x7FFAC9A38580
    }

    public class TextGeneratorUtilities : Object
    {
        public UnityEngine.Vector2 largePositiveVector2;
        public UnityEngine.Vector2 largeNegativeVector2; // 0x8

        // ── Methods ──
        public void Approximately(){} // RVA: 0x7FFAC9A3A440
        public void HexCharsToColor(){} // RVA: 0x7FFAC9A3AB00 | overloaded x2
        public void HexToInt(){} // RVA: 0x7FFAC9A3AD90
        public void ConvertToFloat(){} // RVA: 0x7FFAC9A3AF20 | overloaded x2
        public void PackUV(){} // RVA: 0x7FFAC9A3B080
        public void ResizeInternalArray(){} // RVA: 0x7FFAC2C76370 | overloaded x2
        public void InsertOpeningTextStyle(){} // RVA: 0x7FFAC9A3B0C0
        public void InsertClosingTextStyle(){} // RVA: 0x7FFAC9A3B1C0
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7FFAC9A3B4C0 | overloaded x2
        public void ReplaceClosingStyleTag(){} // RVA: 0x7FFAC9A3B6C0
        public void InsertOpeningStyleTag(){} // RVA: 0x7FFAC9A3B7F0
        public void InsertClosingStyleTag(){} // RVA: 0x7FFAC9A3B8F0
        public void InsertTextStyleInTextProcessingArray(){} // RVA: 0x7FFAC9A3B9F0
        public void GetStyle(){} // RVA: 0x7FFAC9A3BEA0
        public void GetStyleHashCode(){} // RVA: 0x7FFAC9A3C150 | overloaded x2
        public void GetUTF16(){} // RVA: 0x7FFAC9A3C330 | overloaded x2
        public void GetUTF32(){} // RVA: 0x7FFAC9A3C590 | overloaded x2
        public void FillCharacterVertexBuffers(){} // RVA: 0x7FFAC9A3C740
        public void FillSpriteVertexBuffers(){} // RVA: 0x7FFAC9A3D310
        public void AdjustLineOffset(){} // RVA: 0x7FFAC9A3DDF0
        public void ResizeLineExtents(){} // RVA: 0x7FFAC9A3E1C0
        public void LegacyStyleToNewStyle(){} // RVA: 0x7FFAC9A3E470
        public void LegacyAlignmentToNewAlignment(){} // RVA: 0x7FFAC9A3E4A0
        public void ConvertToUTF32(){} // RVA: 0x7FFAC9A3E520
        public void GetMarkupTagHashCode(){} // RVA: 0x7FFAC9A3E600 | overloaded x2
        public void ToUpperASCIIFast(){} // RVA: 0x7FFAC9A3E730 | overloaded x2
        public void ToUpperFast(){} // RVA: 0x7FFAC9A3E7A0
        public void GetAttributeParameters(){} // RVA: 0x7FFAC9A3E810
        public void IsBitmapRendering(){} // RVA: 0x7FFAC9A3E8E0
        public void IsBaseGlyph(){} // RVA: 0x7FFAC9A3E910
        public void MinAlpha(){} // RVA: 0x7FFAC9A3EA20
        public void GammaToLinear(){} // RVA: 0x7FFAC9A3EB00 | overloaded x2
        public void IsValidUTF16(){} // RVA: 0x7FFAC9A3EBB0
        public void IsValidUTF32(){} // RVA: 0x7FFAC9A3EC30
        public void IsHangul(){} // RVA: 0x7FFAC9A3ECB0
        public void IsCJK(){} // RVA: 0x7FFAC9A3ED10
        public void .cctor(){} // RVA: 0x7FFAC9A3EDD0
    }

    public class TextHandle : Object
    {
        public UnityEngine.Vector2 textInfo; // 0x10
        public UnityEngine.TextCore.Text.TextInfo layoutTextInfo; // 0x18
        public UnityEngine.TextCore.Text.TextInfo m_LayoutTextInfo;
        public int m_PreviousGenerationSettingsHash; // 0x20
        public UnityEngine.TextCore.Text.TextGenerationSettings textGenerationSettings; // 0x28
        public UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings; // 0x8
        public bool isDirty; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A3EE40
        public void get_textInfo(){} // RVA: 0x7FFAC9A3EF70
        public void get_layoutTextInfo(){} // RVA: 0x7FFAC9A3F020
        public void IsDirty(){} // RVA: 0x7FFAC9A3F160
        public void GetCursorPositionFromStringIndexUsingCharacterHeight(){} // RVA: 0x7FFAC9A3F1B0
        public void GetCursorPositionFromStringIndexUsingLineHeight(){} // RVA: 0x7FFAC9A3F430
        public void GetCursorIndexFromPosition(){} // RVA: 0x7FFAC9A3F6B0
        public void LineDownCharacterPosition(){} // RVA: 0x7FFAC9A3FA40
        public void LineUpCharacterPosition(){} // RVA: 0x7FFAC9A3FEF0
        public void FindNearestLine(){} // RVA: 0x7FFAC9A40380
        public void FindNearestCharacterOnLine(){} // RVA: 0x7FFAC9A404C0
        public void FindIntersectingLink(){} // RVA: 0x7FFAC9A40E00
        public void PointIntersectRectangle(){} // RVA: 0x7FFAC9A41600
        public void DistanceToLine(){} // RVA: 0x7FFAC9A41790
        public void GetLineNumber(){} // RVA: 0x7FFAC9A41970
        public void GetLineHeight(){} // RVA: 0x7FFAC9A41A00
        public void GetLineHeightFromCharacterIndex(){} // RVA: 0x7FFAC9A41A90
        public void GetCharacterHeightFromIndex(){} // RVA: 0x7FFAC9A41B20
        public void IsElided(){} // RVA: 0x7FFAC9A41CB0
        public void Substring(){} // RVA: 0x7FFAC9A41D30
        public void IndexOf(){} // RVA: 0x7FFAC9A41EE0
        public void LastIndexOf(){} // RVA: 0x7FFAC9A41FF0
        public void ComputeTextWidth(){} // RVA: 0x7FFAC9A420B0
        public void ComputeTextHeight(){} // RVA: 0x7FFAC9A420D0
        public void UpdatePreferredValues(){} // RVA: 0x7FFAC9A420F0
        public void Update(){} // RVA: 0x7FFAC9A42290
        public void .cctor(){} // RVA: 0x7FFAC9A42370
    }

    public class TextInfo : Object
    {
        public UnityEngine.Vector2 s_InfinityVectorPositive;
        public UnityEngine.Vector2 s_InfinityVectorNegative; // 0x8
        public int characterCount; // 0x10
        public int spriteCount; // 0x14
        public int spaceCount; // 0x18
        public int wordCount; // 0x1C
        public int linkCount; // 0x20
        public int lineCount; // 0x24
        public int pageCount; // 0x28
        public int materialCount; // 0x2C
        public UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo; // 0x30
        public UnityEngine.TextCore.Text.WordInfo[] wordInfo; // 0x38
        public UnityEngine.TextCore.Text.LinkInfo[] linkInfo; // 0x40
        public UnityEngine.TextCore.Text.LineInfo[] lineInfo; // 0x48
        public UnityEngine.TextCore.Text.PageInfo[] pageInfo; // 0x50
        public UnityEngine.TextCore.Text.MeshInfo[] meshInfo; // 0x58
        public bool isDirty; // 0x60
        public bool hasMultipleColors; // 0x61

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A424D0
        public void Clear(){} // RVA: 0x7FFAC9A427B0
        public void ClearMeshInfo(){} // RVA: 0x7FFAC9A42830
        public void ClearLineInfo(){} // RVA: 0x7FFAC9A42900
        public void ClearPageInfo(){} // RVA: 0x7FFAC9A42C50
        public void Resize(){} // RVA: 0x7FFAC2C77A00 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9A42DC0
    }

    public class TextProcessingElement : ValueType
    {
        public 0x6B25CBC0 elementType; // 0x10
        public uint unicode; // 0x14
        public int stringIndex; // 0x18
        public int length; // 0x1C
    }

    public class TextProcessingStack`1 : ValueType
    {
        public T[] Count;
        public int current;
        public T m_DefaultItem;
        public int m_Capacity;
        public int m_RolloverSize;
        public int m_Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72E60 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_current(){} // RVA: 0x7FFAC2E8DC40
        public void SetDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void Push(){} // RVA: 0x7FFAC2E8DC40
        public void Pop(){} // RVA: 0x7FFAC2E8DC40
        public void Peek(){} // RVA: 0x7FFAC2E8DC40
        public void CurrentItem(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TextResourceManager : Object
    {
        public System.Collections.Generic.Dictionary`2<int,FontAssetRef> s_FontAssetReferences;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup; // 0x8
        public System.Collections.Generic.Dictionary`2<long,UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
        public System.Collections.Generic.List`1<int> s_FontAssetRemovalList; // 0x18
        public int k_RegularStyleHashCode; // 0x20

        // ── Methods ──
        public void AddFontAsset(){} // RVA: 0x7FFAC9A42EE0
        public void .cctor(){} // RVA: 0x7FFAC9A43890
    }

    public class TextSettings : ScriptableObject
    {
        public string version; // 0x18
        public UnityEngine.TextCore.Text.FontAsset defaultFontAsset; // 0x20
        public string defaultFontAssetPath; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset> fallbackFontAssets; // 0x30
        public bool matchMaterialPreset; // 0x38
        public int missingCharacterUnicode; // 0x3C
        public bool clearDynamicDataOnBuild; // 0x40
        public UnityEngine.TextCore.Text.SpriteAsset defaultSpriteAsset; // 0x48
        public string defaultSpriteAssetPath; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets; // 0x58
        public uint missingSpriteCharacterUnicode; // 0x60
        public UnityEngine.TextCore.Text.TextStyleSheet defaultStyleSheet; // 0x68
        public string styleSheetsResourcePath; // 0x70
        public string defaultColorGradientPresetsPath; // 0x78
        public UnityEngine.TextCore.Text.UnicodeLineBreakingRules lineBreakingRules; // 0x80
        public bool useModernHangulLineBreakingRules; // 0x88
        public bool displayWarnings; // 0x89
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.TextCore.Text.FontAsset> m_FontLookup; // 0x90
        public System.Collections.Generic.List`1<FontReferenceMap> m_FontReferences; // 0x98

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFAC2F247C0
        public void set_version(){} // RVA: 0x7FFAC2F87E80
        public void get_defaultFontAsset(){} // RVA: 0x7FFAC2F4F0C0
        public void set_defaultFontAsset(){} // RVA: 0x7FFAC2F4F0D0
        public void get_defaultFontAssetPath(){} // RVA: 0x7FFAC2F4F130
        public void set_defaultFontAssetPath(){} // RVA: 0x7FFAC2F22E90
        public void get_fallbackFontAssets(){} // RVA: 0x7FFAC31D95E0
        public void set_fallbackFontAssets(){} // RVA: 0x7FFAC2F4F890
        public void get_matchMaterialPreset(){} // RVA: 0x7FFAC31D95D0
        public void set_matchMaterialPreset(){} // RVA: 0x7FFAC31D95C0
        public void get_missingCharacterUnicode(){} // RVA: 0x7FFAC33BD4A0
        public void set_missingCharacterUnicode(){} // RVA: 0x7FFAC47E2CD0
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFAC2FDCC00
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFAC2FDCC10
        public void get_defaultSpriteAsset(){} // RVA: 0x7FFAC2F9C730
        public void set_defaultSpriteAsset(){} // RVA: 0x7FFAC2F9C740
        public void get_defaultSpriteAssetPath(){} // RVA: 0x7FFAC2FC20E0
        public void set_defaultSpriteAssetPath(){} // RVA: 0x7FFAC30794D0
        public void get_fallbackSpriteAssets(){} // RVA: 0x7FFAC2FE9500
        public void set_fallbackSpriteAssets(){} // RVA: 0x7FFAC2FE9510
        public void get_missingSpriteCharacterUnicode(){} // RVA: 0x7FFAC3138C20
        public void set_missingSpriteCharacterUnicode(){} // RVA: 0x7FFAC3138C10
        public void get_defaultStyleSheet(){} // RVA: 0x7FFAC2F9CD50
        public void set_defaultStyleSheet(){} // RVA: 0x7FFAC2F9CD60
        public void get_styleSheetsResourcePath(){} // RVA: 0x7FFAC2FE9590
        public void set_styleSheetsResourcePath(){} // RVA: 0x7FFAC2FE95A0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x7FFAC30E5600
        public void set_defaultColorGradientPresetsPath(){} // RVA: 0x7FFAC30E06F0
        public void get_lineBreakingRules(){} // RVA: 0x7FFAC9A43D30
        public void set_lineBreakingRules(){} // RVA: 0x7FFAC34D4AA0
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFAC9A43DF0
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x7FFAC3E0C170
        public void get_displayWarnings(){} // RVA: 0x7FFAC3E04950
        public void set_displayWarnings(){} // RVA: 0x7FFAC3E09570
        public void OnEnable(){} // RVA: 0x7FFAC9A43E00
        public void InitializeFontReferenceLookup(){} // RVA: 0x7FFAC9A43E30
        public void GetCachedFontAssetInternal(){} // RVA: 0x7FFAC9A44220
        public void .ctor(){} // RVA: 0x7FFAC9A44690
    }

    public class TextShaderUtilities : Object
    {
        public int ShaderRef_MobileSDF;
        public int ShaderRef_MobileBitmap; // 0x4
        public int ID_FaceColor; // 0x8
        public int ID_FaceDilate; // 0xC
        public int ID_Shininess; // 0x10
        public int ID_OutlineOffset1; // 0x14
        public int ID_OutlineOffset2; // 0x18
        public int ID_OutlineOffset3; // 0x1C
        public int ID_OutlineMode; // 0x20
        public int ID_IsoPerimeter; // 0x24
        public int ID_Softness; // 0x28
        public int ID_UnderlayColor; // 0x2C
        public int ID_UnderlayOffsetX; // 0x30
        public int ID_UnderlayOffsetY; // 0x34
        public int ID_UnderlayDilate; // 0x38
        public int ID_UnderlaySoftness; // 0x3C
        public int ID_UnderlayOffset; // 0x40
        public int ID_UnderlayIsoPerimeter; // 0x44
        public int ID_WeightNormal; // 0x48
        public int ID_WeightBold; // 0x4C
        public int ID_OutlineTex; // 0x50
        public int ID_OutlineWidth; // 0x54
        public int ID_OutlineSoftness; // 0x58
        public int ID_OutlineColor; // 0x5C
        public int ID_Outline2Color; // 0x60
        public int ID_Outline2Width; // 0x64
        public int ID_Padding; // 0x68
        public int ID_GradientScale; // 0x6C
        public int ID_ScaleX; // 0x70
        public int ID_ScaleY; // 0x74
        public int ID_PerspectiveFilter; // 0x78
        public int ID_Sharpness; // 0x7C
        public int ID_TextureWidth; // 0x80
        public int ID_TextureHeight; // 0x84
        public int ID_BevelAmount; // 0x88
        public int ID_GlowColor; // 0x8C
        public int ID_GlowOffset; // 0x90
        public int ID_GlowPower; // 0x94
        public int ID_GlowOuter; // 0x98
        public int ID_GlowInner; // 0x9C
        public int ID_LightAngle; // 0xA0
        public int ID_EnvMap; // 0xA4
        public int ID_EnvMatrix; // 0xA8
        public int ID_EnvMatrixRotation; // 0xAC
        public int ID_MaskCoord; // 0xB0
        public int ID_ClipRect; // 0xB4
        public int ID_MaskSoftnessX; // 0xB8
        public int ID_MaskSoftnessY; // 0xBC
        public int ID_VertexOffsetX; // 0xC0
        public int ID_VertexOffsetY; // 0xC4
        public int ID_UseClipRect; // 0xC8
        public int ID_StencilID; // 0xCC
        public int ID_StencilOp; // 0xD0
        public int ID_StencilComp; // 0xD4
        public int ID_StencilReadMask; // 0xD8
        public int ID_StencilWriteMask; // 0xDC
        public int ID_ShaderFlags; // 0xE0
        public int ID_ScaleRatio_A; // 0xE4
        public int ID_ScaleRatio_B; // 0xE8
        public int ID_ScaleRatio_C; // 0xEC
        public string Keyword_Bevel; // 0xF0
        public string Keyword_Glow; // 0xF8
        public string Keyword_Underlay; // 0x100
        public string Keyword_Ratios; // 0x108
        public string Keyword_MASK_SOFT; // 0x110
        public string Keyword_MASK_HARD; // 0x118
        public string Keyword_MASK_TEX; // 0x120
        public string Keyword_Outline; // 0x128
        public string ShaderTag_ZTestMode; // 0x130
        public string ShaderTag_CullMode; // 0x138
        public float m_clamp; // 0x140
        public bool isInitialized; // 0x144
        public UnityEngine.Shader k_ShaderRef_MobileSDF; // 0x148
        public UnityEngine.Shader k_ShaderRef_MobileBitmap; // 0x150

        // ── Methods ──
        public void get_ShaderRef_MobileSDF(){} // RVA: 0x7FFAC9A44940
        public void get_ShaderRef_MobileBitmap(){} // RVA: 0x7FFAC9A44DE0
        public void .cctor(){} // RVA: 0x7FFAC9A45280
        public void GetShaderPropertyIDs(){} // RVA: 0x7FFAC9A458A0
    }

    public class TextStyle : Object
    {
        public UnityEngine.TextCore.Text.TextStyle hashCode;
        public string styleOpeningTagArray; // 0x10
        public int styleClosingTagArray; // 0x18
        public string m_OpeningDefinition; // 0x20
        public string m_ClosingDefinition; // 0x28
        public uint[] m_OpeningTagArray; // 0x30
        public uint[] m_ClosingTagArray; // 0x38
        public uint[] m_OpeningTagUnicodeArray; // 0x40
        public uint[] m_ClosingTagUnicodeArray; // 0x48

        // ── Methods ──
        public void get_hashCode(){} // RVA: 0x7FFAC669DCA0
        public void get_styleOpeningTagArray(){} // RVA: 0x7FFAC98DE3D0
        public void get_styleClosingTagArray(){} // RVA: 0x7FFAC991F6C0
        public void .ctor(){} // RVA: 0x7FFAC9A47310
        public void RefreshStyle(){} // RVA: 0x7FFAC9A47470
    }

    public class TextStyleSheet : ScriptableObject
    {
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.TextStyle> styles; // 0x18
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary; // 0x20

        // ── Methods ──
        public void get_styles(){} // RVA: 0x7FFAC58A1130
        public void Reset(){} // RVA: 0x7FFAC9A477C0
        public void GetStyle(){} // RVA: 0x7FFAC9A47860 | overloaded x2
        public void RefreshStyles(){} // RVA: 0x7FFAC9A477C0
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7FFAC9A47900
        public void .ctor(){} // RVA: 0x7FFAC9A47E00
    }

    public class TextUtilities : Object
    {
        // ── Methods ──
        public void ToUpperFast(){} // RVA: 0x7FFAC9A47F40
        public void GetHashCodeCaseInSensitive(){} // RVA: 0x7FFAC9A47FB0
        public void UintToString(){} // RVA: 0x7FFAC9A48090
    }

    public class TextVertex : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10
        public UnityEngine.Vector4 uv; // 0x1C
        public UnityEngine.Vector2 uv2; // 0x2C
        public UnityEngine.Color32 color; // 0x34
    }

    public class UnicodeLineBreakingRules : Object
    {
        public UnityEngine.TextAsset leadingCharacters; // 0x10
        public UnityEngine.TextAsset followingCharacters; // 0x18
        public UnityEngine.TextAsset leadingCharactersLookup; // 0x20
        public bool followingCharactersLookup; // 0x28
        public System.Collections.Generic.HashSet`1<uint> useModernHangulLineBreakingRules; // 0x30
        public System.Collections.Generic.HashSet`1<uint> m_FollowingCharactersLookup; // 0x38

        // ── Methods ──
        public void get_leadingCharacters(){} // RVA: 0x7FFAC2F247C0
        public void get_followingCharacters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_leadingCharactersLookup(){} // RVA: 0x7FFAC9A48160
        public void get_followingCharactersLookup(){} // RVA: 0x7FFAC9A481A0
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFAC30F6BA0
        public void LoadLineBreakingRules(){} // RVA: 0x7FFAC9A48690 | overloaded x2
        public void GetCharacters(){} // RVA: 0x7FFAC9A48AB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class WordInfo : ValueType
    {
        public int firstCharacterIndex; // 0x10
        public int lastCharacterIndex; // 0x14
        public int characterCount; // 0x18
    }

    public class WordWrapState : ValueType
    {
        public int previousWordBreak; // 0x10
        public int totalCharacterCount; // 0x14
        public int visibleCharacterCount; // 0x18
        public int visibleSpaceCount; // 0x1C
        public int visibleSpriteCount; // 0x20
        public int visibleLinkCount; // 0x24
        public int firstCharacterIndex; // 0x28
        public int firstVisibleCharacterIndex; // 0x2C
        public int lastCharacterIndex; // 0x30
        public int lastVisibleCharIndex; // 0x34
        public int lineNumber; // 0x38
        public float maxCapHeight; // 0x3C
        public float maxAscender; // 0x40
        public float maxDescender; // 0x44
        public float maxLineAscender; // 0x48
        public float maxLineDescender; // 0x4C
        public float startOfLineAscender; // 0x50
        public float xAdvance; // 0x54
        public float preferredWidth; // 0x58
        public float preferredHeight; // 0x5C
        public float previousLineScale; // 0x60
        public float pageAscender; // 0x64
        public int wordCount; // 0x68
        public 0x6B25C4E0 fontStyle; // 0x6C
        public float fontScale; // 0x70
        public float fontScaleMultiplier; // 0x74
        public int italicAngle; // 0x78
        public float currentFontSize; // 0x7C
        public float baselineOffset; // 0x80
        public float lineOffset; // 0x84
        public UnityEngine.TextCore.Text.TextInfo textInfo; // 0x88
        public UnityEngine.TextCore.Text.LineInfo lineInfo; // 0x90
        public UnityEngine.Color32 vertexColor; // 0xF0
        public UnityEngine.Color32 underlineColor; // 0xF4
        public UnityEngine.Color32 strikethroughColor; // 0xF8
        public UnityEngine.Color32 highlightColor; // 0xFC
        public UnityEngine.TextCore.Text.HighlightState highlightState; // 0x100
        public UnityEngine.TextCore.Text.FontStyleStack basicStyleStack; // 0x114
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int> italicAngleStack; // 0x120
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> colorStack; // 0x140
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> underlineColorStack; // 0x160
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> strikethroughColorStack; // 0x180
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.Color32> highlightColorStack; // 0x1A0
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.HighlightState> highlightStateStack; // 0x1C0
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.TextColorGradient> colorGradientStack; // 0x1F0
        public UnityEngine.TextCore.Text.TextProcessingStack`1<float> sizeStack; // 0x218
        public UnityEngine.TextCore.Text.TextProcessingStack`1<float> indentStack; // 0x238
        public UnityEngine.TextCore.Text.TextProcessingStack`1<0x6B25B988> fontWeightStack; // 0x258
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int> styleStack; // 0x278
        public UnityEngine.TextCore.Text.TextProcessingStack`1<float> baselineStack; // 0x298
        public UnityEngine.TextCore.Text.TextProcessingStack`1<int> actionStack; // 0x2B8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.MaterialReference> materialReferenceStack; // 0x2D8
        public UnityEngine.TextCore.Text.TextProcessingStack`1<0x6B25C488> lineJustificationStack; // 0x330
        public int lastBaseGlyphIndex; // 0x350
        public int spriteAnimationId; // 0x354
        public UnityEngine.TextCore.Text.FontAsset currentFontAsset; // 0x358
        public UnityEngine.TextCore.Text.SpriteAsset currentSpriteAsset; // 0x360
        public UnityEngine.Material currentMaterial; // 0x368
        public int currentMaterialIndex; // 0x370
        public UnityEngine.TextCore.Text.Extents meshExtents; // 0x374
        public bool tagNoParsing; // 0x384
        public bool isNonBreakingSpace; // 0x385
        public bool isDrivenLineSpacing; // 0x386
        public UnityEngine.Vector3 fxScale; // 0x388
        public UnityEngine.Quaternion fxRotation; // 0x394
    }

}