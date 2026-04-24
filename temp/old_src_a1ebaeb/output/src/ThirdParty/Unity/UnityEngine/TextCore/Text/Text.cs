// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.Text
// Classes: 9
// Methods: 273

namespace ThirdParty.Unity.UnityEngine.TextCore.Text
{
    public class FontAsset : TextAsset
    {
        public object m_SourceFontFile; // 0x317901B0
        public object InternalDynamicOS; // 0x317901B0
        public object m_StyleNameHashCode; // 0x317901B0
        public object m_CharacterTable; // 0x317901B0
        public object m_AtlasTextures; // 0x317901B0
        public object m_ClearDynamicDataOnBuild; // 0x317901B0
        public object m_AtlasPadding; // 0x317901B0
        public object m_FreeGlyphRects; // 0x317901B0
        public object m_FontWeightTable; // 0x317901B0
        public object m_BoldStyleWeight; // 0x317901B0
        public object m_TabMultiple; // 0x317901B0
        public object k_AddSynthesizedCharactersMarker; // 0x317901B0
        public object k_UpdateGlyphAdjustmentRecordsMarker; // 0x317901B0
        public object k_UpdateFontAssetDataMarker; // 0x317901B0
        public object k_SearchedFontAssetLookup; // 0x317901B0
        public object k_FontAssets_AtlasTexturesUpdateQueue; // 0x317901B0
        public object m_GlyphsRendered; // 0x317901B0
        public object m_GlyphsToAdd; // 0x317901B0
        public object m_CharactersToAddLookup; // 0x317901B0
        public object k_GlyphIndexArray; // 0x317901B0
        public object pointSizeSamplingMode; // 0x83AF0BE0
        public object paddingMode; // 0x83AF0BE0
        public object atlasHeight; // 0x83AF0BE0
        public object referencedFontAssetGUID; // 0x83AF0BE0
        public object fontStyleModifier; // 0x83AF0BE0

        // ── Original Methods ──
        public void get_fontAssetCreationEditorSettings(){} // RVA: 0x7ffaaf41f780
        public void set_fontAssetCreationEditorSettings(){} // RVA: 0x7ffaaf41f7c0
        public void get_sourceFontFile(){} // RVA: 0x7ffaaf341c20
        public void set_sourceFontFile(){} // RVA: 0x7ffaa8f7b0d0
        public void get_atlasPopulationMode(){} // RVA: 0x7ffaaf41f850
        public void set_atlasPopulationMode(){} // RVA: 0x7ffaa932b8c0
        public void get_faceInfo(){} // RVA: 0x7ffaaf41f860
        public void set_faceInfo(){} // RVA: 0x7ffaaf41f8b0
        public void get_familyNameHashCode(){} // RVA: 0x7ffaaf41f940
        public void set_familyNameHashCode(){} // RVA: 0x7ffaa9fbd7b0
        public void get_styleNameHashCode(){} // RVA: 0x7ffaaf41f980
        public void set_styleNameHashCode(){} // RVA: 0x7ffaaf167500
        public void get_glyphTable(){} // RVA: 0x7ffaaf41f9c0
        public void set_glyphTable(){} // RVA: 0x7ffaa8de5d60
        public void get_glyphLookupTable(){} // RVA: 0x7ffaaf41f9d0
        public void get_characterTable(){} // RVA: 0x7ffaaf41fa10
        public void set_characterTable(){} // RVA: 0x7ffaa93ff110
        public void get_characterLookupTable(){} // RVA: 0x7ffaaf41fa20
        public void get_atlasTexture(){} // RVA: 0x7ffaaf41fa60
        public void get_atlasTextures(){} // RVA: 0x7ffaaf41fbb0
        public void set_atlasTextures(){} // RVA: 0x7ffaa899d600
        public void get_atlasTextureCount(){} // RVA: 0x7ffaaf41fbc0
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7ffaaf41fbd0
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7ffaaf41fbe0
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7ffaaf41fbf0
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7ffaaf41fc00
        public void get_atlasWidth(){} // RVA: 0x7ffaaf41fc10
        public void set_atlasWidth(){} // RVA: 0x7ffaa96cb1b0
        public void get_atlasHeight(){} // RVA: 0x7ffaaf41fc20
        public void set_atlasHeight(){} // RVA: 0x7ffaae55fc00
        public void get_atlasPadding(){} // RVA: 0x7ffaaf41fc30
        public void set_atlasPadding(){} // RVA: 0x7ffaaf41fc40
        public void get_atlasRenderMode(){} // RVA: 0x7ffaaf41fc50
        public void set_atlasRenderMode(){} // RVA: 0x7ffaaf41fc60
        public void get_usedGlyphRects(){} // RVA: 0x7ffaaf41fc70
        public void set_usedGlyphRects(){} // RVA: 0x7ffaa8dde9b0
        public void get_freeGlyphRects(){} // RVA: 0x7ffaaf41fc80
        public void set_freeGlyphRects(){} // RVA: 0x7ffaa93e3af0
        public void get_fontFeatureTable(){} // RVA: 0x7ffaaf41fc90
        public void set_fontFeatureTable(){} // RVA: 0x7ffaa93f45e0
        public void get_fallbackFontAssetTable(){} // RVA: 0x7ffaaf41fca0
        public void set_fallbackFontAssetTable(){} // RVA: 0x7ffaa93d3040
        public void get_fontWeightTable(){} // RVA: 0x7ffaaf41fcb0
        public void set_fontWeightTable(){} // RVA: 0x7ffaa8f2e920
        public void get_regularStyleWeight(){} // RVA: 0x7ffaaf41fcc0
        public void set_regularStyleWeight(){} // RVA: 0x7ffaaf41fcd0
        public void get_regularStyleSpacing(){} // RVA: 0x7ffaaf41fce0
        public void set_regularStyleSpacing(){} // RVA: 0x7ffaaf41fcf0
        public void get_boldStyleWeight(){} // RVA: 0x7ffaaf41fd00
        public void set_boldStyleWeight(){} // RVA: 0x7ffaaf41fd10
        public void get_boldStyleSpacing(){} // RVA: 0x7ffaaf41fd20
        public void set_boldStyleSpacing(){} // RVA: 0x7ffaaf41fd30
        public void get_italicStyleSlant(){} // RVA: 0x7ffaaf41fd40
        public void set_italicStyleSlant(){} // RVA: 0x7ffaae55fe00
        public void get_tabMultiple(){} // RVA: 0x7ffaaf41fd50
        public void set_tabMultiple(){} // RVA: 0x7ffaae666870
        public void CreateFontAsset(){} // RVA: 0x7ffaaf4203e0
        public void CreateFontAsset(){} // RVA: 0x7ffaaf4203e0
        public void CreateFontAsset(){} // RVA: 0x7ffaaf4203e0
        public void CreateFontAsset(){} // RVA: 0x7ffaaf4203e0
        public void CreateFontAsset(){} // RVA: 0x7ffaaf4203e0
        public void CreateFontAsset(){} // RVA: 0x7ffaaf4203e0
        public void CreateFontAssetInstance(){} // RVA: 0x7ffaaf420610
        public void Awake(){} // RVA: 0x7ffaa8932310
        public void OnDestroy(){} // RVA: 0x7ffaaf420f70
        public void ReadFontAssetDefinition(){} // RVA: 0x7ffaaf421110
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7ffaaf421530
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7ffaaf421580
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7ffaaf421920
        public void InitializeLigatureSubstitutionLookupDictionary(){} // RVA: 0x7ffaaf421b90
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x7ffaaf421f10
        public void InitializeMarkToBaseAdjustmentRecordsLookupDictionary(){} // RVA: 0x7ffaaf422210
        public void InitializeMarkToMarkAdjustmentRecordsLookupDictionary(){} // RVA: 0x7ffaaf422530
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7ffaaf422850
        public void AddSynthesizedCharacter(){} // RVA: 0x7ffaaf422a60
        public void AddCharacterToLookupCache(){} // RVA: 0x7ffaaf422d40
        public void LoadFontFace(){} // RVA: 0x7ffaaf422dd0
        public void SortCharacterTable(){} // RVA: 0x7ffaaf422f90
        public void SortGlyphTable(){} // RVA: 0x7ffaaf423230
        public void SortFontFeatureTable(){} // RVA: 0x7ffaaf4234d0
        public void SortAllTables(){} // RVA: 0x7ffaaf423520
        public void HasCharacter(){} // RVA: 0x7ffaaf423620
        public void HasCharacter(){} // RVA: 0x7ffaaf423620
        public void HasCharacter(){} // RVA: 0x7ffaaf423620
        public void HasCharacter_Internal(){} // RVA: 0x7ffaaf423ab0
        public void HasCharacters(){} // RVA: 0x7ffaaf424650
        public void HasCharacters(){} // RVA: 0x7ffaaf424650
        public void HasCharacters(){} // RVA: 0x7ffaaf424650
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7ffaaf424ad0
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7ffaaf424c30
        public void RegisterAtlasTextureForApply(){} // RVA: 0x7ffaaf424e70
        public void UpdateAtlasTexturesInQueue(){} // RVA: 0x7ffaaf424f70
        public void UpdateFontAssetsInUpdateQueue(){} // RVA: 0x7ffaaf425170
        public void TryAddCharacters(){} // RVA: 0x7ffaaf4260d0
        public void TryAddCharacters(){} // RVA: 0x7ffaaf4260d0
        public void TryAddCharacters(){} // RVA: 0x7ffaaf4260d0
        public void TryAddCharacters(){} // RVA: 0x7ffaaf4260d0
        public void TryAddGlyphInternal(){} // RVA: 0x7ffaaf427010
        public void TryAddCharacterInternal(){} // RVA: 0x7ffaaf4278f0
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x7ffaaf4283a0
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x7ffaa8932310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7ffaaf428880
        public void UpdateAllFontFeatures(){} // RVA: 0x7ffaaf429060
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7ffaa8932310
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7ffaa8932310
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7ffaa8932310
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7ffaa8932310
        public void CopyListDataToArray(){} // RVA: 0x7ffaa8669e70
        public void ClearFontAssetData(){} // RVA: 0x7ffaaf429940
        public void ClearFontAssetDataInternal(){} // RVA: 0x7ffaaf429a60
        public void UpdateFontAssetData(){} // RVA: 0x7ffaaf429a90
        public void ClearFontAssetTables(){} // RVA: 0x7ffaaf429cd0
        public void ClearAtlasTextures(){} // RVA: 0x7ffaaf429fe0
        public void DestroyAtlasTextures(){} // RVA: 0x7ffaaf42a380
        public void .ctor(){} // RVA: 0x7ffaaf42a4e0
        public void .cctor(){} // RVA: 0x7ffaaf42ac20
        // ── Binary Analysis Named ──
        public void GetCharacters(){} // RVA: 0x7ffaaf424720
        public void GetCharactersArray(){} // RVA: 0x7ffaaf4248b0
        public void GetGlyphIndex(){} // RVA: 0x7ffaaf424990
        public void SetupNewAtlasTexture(){} // RVA: 0x7ffaaf428d50
    }

    public class SpriteAsset : TextAsset
    {
        public object m_FaceInfo; // 0x331C11D0
        public object m_SpriteCharacterLookup; // 0x331C11D0
        public object fallbackSpriteAssets; // 0x331C11D0

        // ── Original Methods ──
        public void get_faceInfo(){} // RVA: 0x7ffaaf431b70
        public void set_faceInfo(){} // RVA: 0x7ffaaf1b8fa0
        public void get_spriteSheet(){} // RVA: 0x7ffaaf341d00
        public void set_spriteSheet(){} // RVA: 0x7ffaa8d71dc0
        public void get_spriteCharacterTable(){} // RVA: 0x7ffaaf431bb0
        public void set_spriteCharacterTable(){} // RVA: 0x7ffaa899d050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7ffaaf431bf0
        public void set_spriteCharacterLookupTable(){} // RVA: 0x7ffaa899d0c0
        public void get_spriteGlyphTable(){} // RVA: 0x7ffaaf341e50
        public void set_spriteGlyphTable(){} // RVA: 0x7ffaa899d130
        public void Awake(){} // RVA: 0x7ffaa8932310
        public void UpdateLookupTables(){} // RVA: 0x7ffaaf431c30
        public void SearchForSpriteByUnicode(){} // RVA: 0x7ffaaf432560
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7ffaaf432a70
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7ffaaf432a70
        public void SearchForSpriteByHashCode(){} // RVA: 0x7ffaaf432b30
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7ffaaf433330
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7ffaaf433330
        public void SortGlyphTable(){} // RVA: 0x7ffaaf4333f0
        public void SortCharacterTable(){} // RVA: 0x7ffaaf433690
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7ffaaf433930
        public void .ctor(){} // RVA: 0x7ffaaf433950
        // ── Binary Analysis Named ──
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7ffaaf4323d0
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7ffaaf432480
        public void GetSpriteIndexFromName(){} // RVA: 0x7ffaaf432520
    }

    public class TextAsset : ScriptableObject
    {
        public object m_HashCode; // 0x31790330

        // ── Original Methods ──
        public void get_version(){} // RVA: 0x7ffaab2aab40
        public void set_version(){} // RVA: 0x7ffaa8998e80
        public void get_instanceID(){} // RVA: 0x7ffaaf433b70
        public void get_hashCode(){} // RVA: 0x7ffaaf433ba0
        public void set_hashCode(){} // RVA: 0x7ffaa9b8c1b0
        public void get_material(){} // RVA: 0x7ffaa8960130
        public void set_material(){} // RVA: 0x7ffaa8933e90
        public void get_materialHashCode(){} // RVA: 0x7ffaaf433be0
        public void set_materialHashCode(){} // RVA: 0x7ffaa898dce0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class TextColorGradient : ScriptableObject
    {
        public object topRight; // 0x331C1350
        public object k_DefaultColorMode; // 0x331C1350
        public object value__; // 0x83AF1490

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf15c590
        public void .ctor(){} // RVA: 0x7ffaaf15c590
        public void .ctor(){} // RVA: 0x7ffaaf15c590
        public void .cctor(){} // RVA: 0x7ffaaf433db0
    }

    public class TextGeneratorUtilities : Object
    {
        public object X00; // 0x400025E

        // ── Original Methods ──
        public void Approximately(){} // RVA: 0x7ffaaf45c3a0
        public void HexCharsToColor(){} // RVA: 0x7ffaaf45ca60
        public void HexCharsToColor(){} // RVA: 0x7ffaaf45ca60
        public void HexToInt(){} // RVA: 0x7ffaaf45ccf0
        public void ConvertToFloat(){} // RVA: 0x7ffaaf45ce80
        public void ConvertToFloat(){} // RVA: 0x7ffaaf45ce80
        public void PackUV(){} // RVA: 0x7ffaaf45cfe0
        public void ResizeInternalArray(){} // RVA: 0x7ffaa86666b0
        public void ResizeInternalArray(){} // RVA: 0x7ffaa86666b0
        public void InsertOpeningTextStyle(){} // RVA: 0x7ffaaf45d020
        public void InsertClosingTextStyle(){} // RVA: 0x7ffaaf45d120
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7ffaaf45d420
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7ffaaf45d420
        public void ReplaceClosingStyleTag(){} // RVA: 0x7ffaaf45d620
        public void InsertOpeningStyleTag(){} // RVA: 0x7ffaaf45d750
        public void InsertClosingStyleTag(){} // RVA: 0x7ffaaf45d850
        public void InsertTextStyleInTextProcessingArray(){} // RVA: 0x7ffaaf45d950
        public void FillCharacterVertexBuffers(){} // RVA: 0x7ffaaf45e6a0
        public void FillSpriteVertexBuffers(){} // RVA: 0x7ffaaf45f270
        public void AdjustLineOffset(){} // RVA: 0x7ffaaf45fd50
        public void ResizeLineExtents(){} // RVA: 0x7ffaaf460120
        public void LegacyStyleToNewStyle(){} // RVA: 0x7ffaaf4603d0
        public void LegacyAlignmentToNewAlignment(){} // RVA: 0x7ffaaf460400
        public void ConvertToUTF32(){} // RVA: 0x7ffaaf460480
        public void ToUpperASCIIFast(){} // RVA: 0x7ffaaf460690
        public void ToUpperASCIIFast(){} // RVA: 0x7ffaaf460690
        public void ToUpperFast(){} // RVA: 0x7ffaaf460700
        public void IsBitmapRendering(){} // RVA: 0x7ffaaf460840
        public void IsBaseGlyph(){} // RVA: 0x7ffaaf460870
        public void MinAlpha(){} // RVA: 0x7ffaaf460980
        public void GammaToLinear(){} // RVA: 0x7ffaaf460a60
        public void GammaToLinear(){} // RVA: 0x7ffaaf460a60
        public void IsValidUTF16(){} // RVA: 0x7ffaaf460b10
        public void IsValidUTF32(){} // RVA: 0x7ffaaf460b90
        public void IsHangul(){} // RVA: 0x7ffaaf460c10
        public void IsCJK(){} // RVA: 0x7ffaaf460c70
        public void .cctor(){} // RVA: 0x7ffaaf460d30
        // ── Binary Analysis Named ──
        public void GetStyle(){} // RVA: 0x7ffaaf45de00
        public void GetStyleHashCode(){} // RVA: 0x7ffaaf45e0b0
        public void GetStyleHashCode(){} // RVA: 0x7ffaaf45e0b0
        public void GetUTF16(){} // RVA: 0x7ffaaf45e290
        public void GetUTF16(){} // RVA: 0x7ffaaf45e290
        public void GetUTF32(){} // RVA: 0x7ffaaf45e4f0
        public void GetUTF32(){} // RVA: 0x7ffaaf45e4f0
        public void GetMarkupTagHashCode(){} // RVA: 0x7ffaaf460560
        public void GetMarkupTagHashCode(){} // RVA: 0x7ffaaf460560
        public void GetAttributeParameters(){} // RVA: 0x7ffaaf460770
    }

    public class TextInfo : Object
    {
        public object characterCount; // 0x318C2270
        public object wordCount; // 0x318C2270
        public object pageCount; // 0x318C2270
        public object wordInfo; // 0x318C2270
        public object pageInfo; // 0x318C2270
        public object hasMultipleColors; // 0x318C2270
        public object BOLD; // 0x84D95870
        public object SLASH_ITALIC; // 0x84D95870

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf464430
        public void Clear(){} // RVA: 0x7ffaaf464710
        public void ClearMeshInfo(){} // RVA: 0x7ffaaf464790
        public void ClearLineInfo(){} // RVA: 0x7ffaaf464860
        public void ClearPageInfo(){} // RVA: 0x7ffaaf464bb0
        public void Resize(){} // RVA: 0x7ffaa8667d40
        public void Resize(){} // RVA: 0x7ffaa8667d40
        public void .cctor(){} // RVA: 0x7ffaaf464d20
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object m_DefaultItem; // 0x313EB9C0
        public object m_Count; // 0x313EB9C0
        public object m_DefaultItem; // 0x84D88478

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa86631a0
        public void .ctor(){} // RVA: 0x7ffaa86631a0
        public void .ctor(){} // RVA: 0x7ffaa86631a0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_current(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void Push(){} // RVA: 0x7ffaa887e5c0
        public void Pop(){} // RVA: 0x7ffaa887e5c0
        public void Peek(){} // RVA: 0x7ffaa887e5c0
        public void CurrentItem(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetDefault(){} // RVA: 0x7ffaa887e5c0
        public void SetDefault(){} // RVA: 0x7ffaa887e5c0
    }

    public class TextSettings : ScriptableObject
    {
        public object m_DefaultFontAssetPath; // 0x331C1050
        public object m_MissingCharacterUnicode; // 0x331C1050
        public object m_DefaultSpriteAssetPath; // 0x331C1050
        public object m_DefaultStyleSheet; // 0x331C1050
        public object m_UnicodeLineBreakingRules; // 0x331C1050
        public object m_FontLookup; // 0x331C1050

        // ── Original Methods ──
        public void get_version(){} // RVA: 0x7ffaa89357c0
        public void set_version(){} // RVA: 0x7ffaa8998e80
        public void get_defaultFontAsset(){} // RVA: 0x7ffaa89600c0
        public void set_defaultFontAsset(){} // RVA: 0x7ffaa89600d0
        public void get_defaultFontAssetPath(){} // RVA: 0x7ffaa8960130
        public void set_defaultFontAssetPath(){} // RVA: 0x7ffaa8933e90
        public void get_fallbackFontAssets(){} // RVA: 0x7ffaa8bfcc80
        public void set_fallbackFontAssets(){} // RVA: 0x7ffaa8960890
        public void get_matchMaterialPreset(){} // RVA: 0x7ffaa8bfcc70
        public void set_matchMaterialPreset(){} // RVA: 0x7ffaa8bfbbe0
        public void get_missingCharacterUnicode(){} // RVA: 0x7ffaa8de7460
        public void set_missingCharacterUnicode(){} // RVA: 0x7ffaaa1eabc0
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7ffaa89edc00
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7ffaa89edc10
        public void get_defaultSpriteAsset(){} // RVA: 0x7ffaa89ad730
        public void set_defaultSpriteAsset(){} // RVA: 0x7ffaa89ad740
        public void get_defaultSpriteAssetPath(){} // RVA: 0x7ffaa89d30e0
        public void set_defaultSpriteAssetPath(){} // RVA: 0x7ffaa8a8a4d0
        public void get_fallbackSpriteAssets(){} // RVA: 0x7ffaa89fa500
        public void set_fallbackSpriteAssets(){} // RVA: 0x7ffaa89fa510
        public void get_missingSpriteCharacterUnicode(){} // RVA: 0x7ffaa8b645f0
        public void set_missingSpriteCharacterUnicode(){} // RVA: 0x7ffaa8b64600
        public void get_defaultStyleSheet(){} // RVA: 0x7ffaa89add50
        public void set_defaultStyleSheet(){} // RVA: 0x7ffaa89add60
        public void get_styleSheetsResourcePath(){} // RVA: 0x7ffaa89fa590
        public void set_styleSheetsResourcePath(){} // RVA: 0x7ffaa89fa5a0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x7ffaa8af68f0
        public void set_defaultColorGradientPresetsPath(){} // RVA: 0x7ffaa8af19e0
        public void get_lineBreakingRules(){} // RVA: 0x7ffaaf465c90
        public void set_lineBreakingRules(){} // RVA: 0x7ffaa8efece0
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7ffaaf465d50
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x7ffaa9836fb0
        public void get_displayWarnings(){} // RVA: 0x7ffaa9839a00
        public void set_displayWarnings(){} // RVA: 0x7ffaa983a020
        public void OnEnable(){} // RVA: 0x7ffaaf465d60
        public void InitializeFontReferenceLookup(){} // RVA: 0x7ffaaf465d90
        public void .ctor(){} // RVA: 0x7ffaaf4665f0
        // ── Binary Analysis Named ──
        public void GetCachedFontAssetInternal(){} // RVA: 0x7ffaaf466180
    }

    public class TextStyleSheet : ScriptableObject
    {
        // ── Original Methods ──
        public void get_styles(){} // RVA: 0x7ffaab2aab40
        public void Reset(){} // RVA: 0x7ffaaf469720
        public void RefreshStyles(){} // RVA: 0x7ffaaf469720
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7ffaaf469860
        public void .ctor(){} // RVA: 0x7ffaaf469d60
        // ── Binary Analysis Named ──
        public void GetStyle(){} // RVA: 0x7ffaaf4697c0
        public void GetStyle(){} // RVA: 0x7ffaaf4697c0
    }

}