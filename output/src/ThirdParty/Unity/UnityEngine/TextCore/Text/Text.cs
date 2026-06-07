// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.Text
// Classes: 45
// Methods: 451

namespace ThirdParty.Unity.UnityEngine.TextCore.Text
{
    public class Character
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6FA1350 | overloaded x3
    }

    public class CharacterSubstitution
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE010
    }

    public class ColorUtilities
    {
        // ── Methods ──
        public void CompareColors(){} // RVA: 0x7265E00
        public void MultiplyColors(){} // RVA: 0x7265E40
    }

    public class Extents
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x72741B0
    }

    public class FontAsset
    {
        public object version;
        public object instanceID;
        public object hashCode;
        public object material;
        public object materialHashCode;

        // ── Methods ──
        public void get_fontAssetCreationEditorSettings(){} // RVA: 0x7265F20
        public void set_fontAssetCreationEditorSettings(){} // RVA: 0x7265F60
        public void get_sourceFontFile(){} // RVA: 0x71883C0
        public void set_sourceFontFile(){} // RVA: 0x9AA650
        public void get_atlasPopulationMode(){} // RVA: 0x7265FF0
        public void set_atlasPopulationMode(){} // RVA: 0xCC9310
        public void get_faceInfo(){} // RVA: 0x7266000
        public void set_faceInfo(){} // RVA: 0x7266050
        public void get_familyNameHashCode(){} // RVA: 0x72660E0
        public void set_familyNameHashCode(){} // RVA: 0x1AE8670
        public void get_styleNameHashCode(){} // RVA: 0x7266120
        public void set_styleNameHashCode(){} // RVA: 0x6FACBF0
        public void get_glyphTable(){} // RVA: 0x7266160
        public void set_glyphTable(){} // RVA: 0x50A8C0
        public void get_glyphLookupTable(){} // RVA: 0x7266170
        public void get_characterTable(){} // RVA: 0x72661B0
        public void set_characterTable(){} // RVA: 0xD182E0
        public void get_characterLookupTable(){} // RVA: 0x72661C0
        public void get_atlasTexture(){} // RVA: 0x7266200
        public void get_atlasTextures(){} // RVA: 0x7266350
        public void set_atlasTextures(){} // RVA: 0x348600
        public void get_atlasTextureCount(){} // RVA: 0x7266360
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7266370
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7266380
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7266390
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x72663A0
        public void get_atlasWidth(){} // RVA: 0x72663B0
        public void set_atlasWidth(){} // RVA: 0x120B830
        public void get_atlasHeight(){} // RVA: 0x72663C0
        public void set_atlasHeight(){} // RVA: 0x63A7640
        public void get_atlasPadding(){} // RVA: 0x72663D0
        public void set_atlasPadding(){} // RVA: 0x72663E0
        public void get_atlasRenderMode(){} // RVA: 0x72663F0
        public void set_atlasRenderMode(){} // RVA: 0x7266400
        public void get_usedGlyphRects(){} // RVA: 0x7266410
        public void set_usedGlyphRects(){} // RVA: 0x8787E0
        public void get_freeGlyphRects(){} // RVA: 0x7266420
        public void set_freeGlyphRects(){} // RVA: 0xD93D70
        public void get_fontFeatureTable(){} // RVA: 0x7266430
        public void set_fontFeatureTable(){} // RVA: 0xD8E320
        public void get_fallbackFontAssetTable(){} // RVA: 0x7266440
        public void set_fallbackFontAssetTable(){} // RVA: 0xD870D0
        public void get_fontWeightTable(){} // RVA: 0x7266450
        public void set_fontWeightTable(){} // RVA: 0xD87C10
        public void get_regularStyleWeight(){} // RVA: 0x7266460
        public void set_regularStyleWeight(){} // RVA: 0x7266470
        public void get_regularStyleSpacing(){} // RVA: 0x7266480
        public void set_regularStyleSpacing(){} // RVA: 0x7266490
        public void get_boldStyleWeight(){} // RVA: 0x72664A0
        public void set_boldStyleWeight(){} // RVA: 0x72664B0
        public void get_boldStyleSpacing(){} // RVA: 0x72664C0
        public void set_boldStyleSpacing(){} // RVA: 0x72664D0
        public void get_italicStyleSlant(){} // RVA: 0x72664E0
        public void set_italicStyleSlant(){} // RVA: 0x63A7840
        public void get_tabMultiple(){} // RVA: 0x72664F0
        public void set_tabMultiple(){} // RVA: 0x64ADD80
        public void CreateFontAsset(){} // RVA: 0x7266B80 | overloaded x6
        public void CreateFontAssetInstance(){} // RVA: 0x7266DB0
        public void Awake(){} // RVA: 0x2DD310
        public void OnDestroy(){} // RVA: 0x7267710
        public void ReadFontAssetDefinition(){} // RVA: 0x72678B0
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7267CD0
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7267D20
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x72680C0
        public void InitializeLigatureSubstitutionLookupDictionary(){} // RVA: 0x7268330
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x72686B0
        public void InitializeMarkToBaseAdjustmentRecordsLookupDictionary(){} // RVA: 0x72689B0
        public void InitializeMarkToMarkAdjustmentRecordsLookupDictionary(){} // RVA: 0x7268CD0
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7268FF0
        public void AddSynthesizedCharacter(){} // RVA: 0x7269200
        public void AddCharacterToLookupCache(){} // RVA: 0x72694E0
        public void LoadFontFace(){} // RVA: 0x7269570
        public void SortCharacterTable(){} // RVA: 0x7269730
        public void SortGlyphTable(){} // RVA: 0x72699D0
        public void SortFontFeatureTable(){} // RVA: 0x7269C70
        public void SortAllTables(){} // RVA: 0x7269CC0
        public void HasCharacter(){} // RVA: 0x7269DC0 | overloaded x3
        public void HasCharacter_Internal(){} // RVA: 0x726A250
        public void HasCharacters(){} // RVA: 0x726ADF0 | overloaded x3
        public void GetCharacters(){} // RVA: 0x726AEC0
        public void GetCharactersArray(){} // RVA: 0x726B050
        public void GetGlyphIndex(){} // RVA: 0x726B130
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x726B270
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x726B3D0
        public void RegisterAtlasTextureForApply(){} // RVA: 0x726B610
        public void UpdateAtlasTexturesInQueue(){} // RVA: 0x726B710
        public void UpdateFontAssetsInUpdateQueue(){} // RVA: 0x726B910
        public void TryAddCharacters(){} // RVA: 0x726C870 | overloaded x4
        public void TryAddGlyphInternal(){} // RVA: 0x726D7B0
        public void TryAddCharacterInternal(){} // RVA: 0x726E090
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x726EB40
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x2DD310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x726F020
        public void SetupNewAtlasTexture(){} // RVA: 0x726F4F0
        public void UpdateAllFontFeatures(){} // RVA: 0x726F800
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x2DD310 | overloaded x4
        public void CopyListDataToArray(){} // RVA: 0x2DC60
        public void ClearFontAssetData(){} // RVA: 0x72700E0
        public void ClearFontAssetDataInternal(){} // RVA: 0x7270200
        public void UpdateFontAssetData(){} // RVA: 0x7270230
        public void ClearFontAssetTables(){} // RVA: 0x7270470
        public void ClearAtlasTextures(){} // RVA: 0x7270780
        public void DestroyAtlasTextures(){} // RVA: 0x7270B20
        public void .ctor(){} // RVA: 0x7270C80
        public void .cctor(){} // RVA: 0x72713C0
    }

    public class FontAssetCreationEditorSettings
    {
    }

    public class FontAssetUtilities
    {
        // ── Methods ──
        public void GetCharacterFromFontAsset(){} // RVA: 0x7271C20
        public void GetCharacterFromFontAsset_Internal(){} // RVA: 0x7271D90
        public void GetCharacterFromFontAssets(){} // RVA: 0x7272470
        public void GetSpriteCharacterFromSpriteAsset(){} // RVA: 0x72726F0
        public void GetSpriteCharacterFromSpriteAsset_Internal(){} // RVA: 0x7272AD0
    }

    public class FontFeatureTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7272D40
        public void SortGlyphPairAdjustmentRecords(){} // RVA: 0x72731E0
        public void SortMarkToBaseAdjustmentRecords(){} // RVA: 0x72736E0
        public void SortMarkToMarkAdjustmentRecords(){} // RVA: 0x7273BE0
    }

    public class FontStyleStack
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7009C60
        public void Add(){} // RVA: 0x72AB530
        public void Remove(){} // RVA: 0x7009D20
    }

    public class FontWeightPair
    {
    }

    public class HighlightState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C68B0
        public void op_Equality(){} // RVA: 0x72A27E0
        public void op_Inequality(){} // RVA: 0x72A2920
        public void GetHashCode(){} // RVA: 0x72A2A70
        public void Equals(){} // RVA: 0x72A2AD0
    }

    public class LineInfo
    {
    }

    public class LinkInfo
    {
        // ── Methods ──
        public void SetLinkId(){} // RVA: 0x7274360
        public void GetLinkText(){} // RVA: 0x7274530
        public void GetLinkId(){} // RVA: 0x72746E0
    }

    public class MaterialManager
    {
        // ── Methods ──
        public void GetFallbackMaterial(){} // RVA: 0x7274CC0 | overloaded x2
        public void CopyMaterialPresetProperties(){} // RVA: 0x7274FF0
        public void .cctor(){} // RVA: 0x72755F0
    }

    public class MaterialReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72756D0
        public void AddMaterialReference(){} // RVA: 0x7275C50 | overloaded x2
    }

    public class MaterialReferenceManager
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7275FE0
        public void AddFontAsset(){} // RVA: 0x72760C0
        public void AddFontAssetInternal(){} // RVA: 0x72760F0
        public void AddSpriteAsset(){} // RVA: 0x7276330
        public void AddSpriteAssetInternal(){} // RVA: 0x7276450
        public void AddFontMaterial(){} // RVA: 0x7276560
        public void AddFontMaterialInternal(){} // RVA: 0x72765F0
        public void AddColorGradientPreset(){} // RVA: 0x7276680
        public void AddColorGradientPreset_Internal(){} // RVA: 0x7276750
        public void TryGetFontAsset(){} // RVA: 0x7276810
        public void TryGetFontAssetInternal(){} // RVA: 0x72768D0
        public void TryGetSpriteAsset(){} // RVA: 0x7276980
        public void TryGetSpriteAssetInternal(){} // RVA: 0x7276A40
        public void TryGetColorGradientPreset(){} // RVA: 0x7276AF0
        public void TryGetColorGradientPresetInternal(){} // RVA: 0x7276BB0
        public void TryGetMaterial(){} // RVA: 0x7276C60
        public void TryGetMaterialInternal(){} // RVA: 0x7276D20
        public void .ctor(){} // RVA: 0x7276DD0
    }

    public class MeshInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7277060
        public void ResizeMeshInfo(){} // RVA: 0x7277760
        public void Clear(){} // RVA: 0x7277980
        public void ClearUnusedVertices(){} // RVA: 0x72779C0
        public void SortGeometry(){} // RVA: 0x7277A00
        public void SwapVertexData(){} // RVA: 0x7277AB0
        public void .cctor(){} // RVA: 0x7278280
    }

    public class Offset
    {
        // ── Methods ──
        public void get_left(){} // RVA: 0x300D20
        public void get_right(){} // RVA: 0x300D30
        public void get_top(){} // RVA: 0x300CF0
        public void get_bottom(){} // RVA: 0x300D00
        public void get_zero(){} // RVA: 0x72A2660
        public void .ctor(){} // RVA: 0x301570
        public void op_Equality(){} // RVA: 0x67E30F0
        public void op_Multiply(){} // RVA: 0x71104A0
        public void GetHashCode(){} // RVA: 0x72A26D0
        public void Equals(){} // RVA: 0x72A2730
        public void .cctor(){} // RVA: 0x72A27A0
    }

    public class PageInfo
    {
    }

    public class RichTextTagAttribute
    {
    }

    public class SpriteAsset
    {
        // ── Methods ──
        public void get_faceInfo(){} // RVA: 0x7278310
        public void set_faceInfo(){} // RVA: 0x6FFE680
        public void get_spriteSheet(){} // RVA: 0x71884A0
        public void set_spriteSheet(){} // RVA: 0xAE5030
        public void get_spriteCharacterTable(){} // RVA: 0x7278350
        public void set_spriteCharacterTable(){} // RVA: 0x348050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7278390
        public void set_spriteCharacterLookupTable(){} // RVA: 0x3480C0
        public void get_spriteGlyphTable(){} // RVA: 0x71885F0
        public void set_spriteGlyphTable(){} // RVA: 0x348130
        public void Awake(){} // RVA: 0x2DD310
        public void UpdateLookupTables(){} // RVA: 0x72783D0
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7278B70
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7278C20
        public void GetSpriteIndexFromName(){} // RVA: 0x7278CC0
        public void SearchForSpriteByUnicode(){} // RVA: 0x7278D00
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7279210 | overloaded x2
        public void SearchForSpriteByHashCode(){} // RVA: 0x72792D0
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7279AD0 | overloaded x2
        public void SortGlyphTable(){} // RVA: 0x7279B90
        public void SortCharacterTable(){} // RVA: 0x7279E30
        public void SortGlyphAndCharacterTables(){} // RVA: 0x727A0D0
        public void .ctor(){} // RVA: 0x727A0F0
    }

    public class SpriteCharacter
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7145E90
        public void .ctor(){} // RVA: 0x7001040
    }

    public class SpriteGlyph
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7001280
    }

    public class TextAsset
    {
        // ── Methods ──
        public void get_version(){} // RVA: 0x2F0F420
        public void set_version(){} // RVA: 0x343E80
        public void get_instanceID(){} // RVA: 0x727A310
        public void get_hashCode(){} // RVA: 0x727A340
        public void set_hashCode(){} // RVA: 0x16E1F00
        public void get_material(){} // RVA: 0x30B130
        public void set_material(){} // RVA: 0x2DEE90
        public void get_materialHashCode(){} // RVA: 0x727A380
        public void set_materialHashCode(){} // RVA: 0x338CE0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class TextBackingContainer
    {
        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x35542C0
        public void get_Count(){} // RVA: 0x3C4E030
        public void set_Count(){} // RVA: 0x1EA98A0
        public void get_Item(){} // RVA: 0x34B3BB0
        public void set_Item(){} // RVA: 0x72A24C0
        public void .ctor(){} // RVA: 0x72A2520
        public void Resize(){} // RVA: 0x72A25D0
    }

    public class TextColorGradient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6FA1C80 | overloaded x3
        public void .cctor(){} // RVA: 0x727A550
    }

    public class TextElement
    {
        // ── Methods ──
        public void get_elementType(){} // RVA: 0x7187810
        public void get_unicode(){} // RVA: 0x2EE0010
        public void set_unicode(){} // RVA: 0x8AC660
        public void get_textAsset(){} // RVA: 0x2F0F420
        public void set_textAsset(){} // RVA: 0x343E80
        public void get_glyph(){} // RVA: 0x6A24380
        public void set_glyph(){} // RVA: 0x30B0D0
        public void get_glyphIndex(){} // RVA: 0x43DB8C0
        public void set_glyphIndex(){} // RVA: 0xA53440
        public void get_scale(){} // RVA: 0x71A8210
        public void set_scale(){} // RVA: 0x8CF4F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TextElementInfo
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x727A5A0
    }

    public class TextGenerationSettings
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x727CCC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x727CDD0
        public void op_Equality(){} // RVA: 0x727E040
        public void ToString(){} // RVA: 0x727E080
        public void .ctor(){} // RVA: 0x7280530
    }

    public class TextGenerator
    {
        // ── Methods ──
        public void GetTextGenerator(){} // RVA: 0x728D900
        public void GenerateText(){} // RVA: 0x728D9E0
        public void GetPreferredValues(){} // RVA: 0x728DC40
        public void get_isTextTruncated(){} // RVA: 0x728DFE0
        public void Prepare(){} // RVA: 0x728E020
        public void GenerateTextMesh(){} // RVA: 0x72805E0
        public void SaveWordWrappingState(){} // RVA: 0x728E270
        public void RestoreWordWrappingState(){} // RVA: 0x728ED30
        public void ValidateHtmlTag(){} // RVA: 0x728F7D0
        public void SaveGlyphVertexInfo(){} // RVA: 0x7295660
        public void SaveSpriteVertexInfo(){} // RVA: 0x7296A10
        public void DrawUnderlineMesh(){} // RVA: 0x7297570
        public void DrawTextHighlight(){} // RVA: 0x72987D0
        public void ClearMesh(){} // RVA: 0x7298ED0
        public void SetArraySizes(){} // RVA: 0x7298FB0
        public void GetTextElement(){} // RVA: 0x729AB90
        public void ComputeMarginSize(){} // RVA: 0x729B0D0
        public void GetSpecialCharacters(){} // RVA: 0x729B1D0
        public void GetEllipsisSpecialCharacter(){} // RVA: 0x729B200
        public void GetUnderlineSpecialCharacter(){} // RVA: 0x729B560
        public void GetPreferredValuesInternal(){} // RVA: 0x729B6D0
        public void CalculatePreferredValues(){} // RVA: 0x729B8E0
        public void PopulateTextBackingArray(){} // RVA: 0x729F160 | overloaded x2
        public void PopulateTextProcessingArray(){} // RVA: 0x729F2E0
        public void InsertNewLine(){} // RVA: 0x72A0330
        public void DoMissingGlyphCallback(){} // RVA: 0x72A0B80
        public void ClearMarkupTagAttributes(){} // RVA: 0x72A0C10
        public void .ctor(){} // RVA: 0x72A0C80
    }

    public class TextGeneratorUtilities
    {
        // ── Methods ──
        public void Approximately(){} // RVA: 0x72A2B40
        public void HexCharsToColor(){} // RVA: 0x72A3200 | overloaded x2
        public void HexToInt(){} // RVA: 0x72A3490
        public void ConvertToFloat(){} // RVA: 0x72A3620 | overloaded x2
        public void PackUV(){} // RVA: 0x72A3780
        public void ResizeInternalArray(){} // RVA: 0x2A490 | overloaded x2
        public void InsertOpeningTextStyle(){} // RVA: 0x72A37C0
        public void InsertClosingTextStyle(){} // RVA: 0x72A38C0
        public void ReplaceOpeningStyleTag(){} // RVA: 0x72A3BC0 | overloaded x2
        public void ReplaceClosingStyleTag(){} // RVA: 0x72A3DC0
        public void InsertOpeningStyleTag(){} // RVA: 0x72A3EF0
        public void InsertClosingStyleTag(){} // RVA: 0x72A3FF0
        public void InsertTextStyleInTextProcessingArray(){} // RVA: 0x72A40F0
        public void GetStyle(){} // RVA: 0x72A45A0
        public void GetStyleHashCode(){} // RVA: 0x72A4850 | overloaded x2
        public void GetUTF16(){} // RVA: 0x72A4A30 | overloaded x2
        public void GetUTF32(){} // RVA: 0x72A4C90 | overloaded x2
        public void FillCharacterVertexBuffers(){} // RVA: 0x72A4E40
        public void FillSpriteVertexBuffers(){} // RVA: 0x72A5A10
        public void AdjustLineOffset(){} // RVA: 0x72A64F0
        public void ResizeLineExtents(){} // RVA: 0x72A68C0
        public void LegacyStyleToNewStyle(){} // RVA: 0x72A6B70
        public void LegacyAlignmentToNewAlignment(){} // RVA: 0x72A6BA0
        public void ConvertToUTF32(){} // RVA: 0x72A6C20
        public void GetMarkupTagHashCode(){} // RVA: 0x72A6D00 | overloaded x2
        public void ToUpperASCIIFast(){} // RVA: 0x72A6E30 | overloaded x2
        public void ToUpperFast(){} // RVA: 0x72A6EA0
        public void GetAttributeParameters(){} // RVA: 0x72A6F10
        public void IsBitmapRendering(){} // RVA: 0x72A6FE0
        public void IsBaseGlyph(){} // RVA: 0x72A7010
        public void MinAlpha(){} // RVA: 0x72A7120
        public void GammaToLinear(){} // RVA: 0x72A7200 | overloaded x2
        public void IsValidUTF16(){} // RVA: 0x72A72B0
        public void IsValidUTF32(){} // RVA: 0x72A7330
        public void IsHangul(){} // RVA: 0x72A73B0
        public void IsCJK(){} // RVA: 0x72A7410
        public void .cctor(){} // RVA: 0x72A74D0
    }

    public class TextHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72A7540
        public void get_textInfo(){} // RVA: 0x72A7670
        public void get_layoutTextInfo(){} // RVA: 0x72A7720
        public void IsDirty(){} // RVA: 0x72A7860
        public void GetCursorPositionFromStringIndexUsingCharacterHeight(){} // RVA: 0x72A78B0
        public void GetCursorPositionFromStringIndexUsingLineHeight(){} // RVA: 0x72A7B30
        public void GetCursorIndexFromPosition(){} // RVA: 0x72A7DB0
        public void LineDownCharacterPosition(){} // RVA: 0x72A8140
        public void LineUpCharacterPosition(){} // RVA: 0x72A85F0
        public void FindNearestLine(){} // RVA: 0x72A8A80
        public void FindNearestCharacterOnLine(){} // RVA: 0x72A8BC0
        public void FindIntersectingLink(){} // RVA: 0x72A9500
        public void PointIntersectRectangle(){} // RVA: 0x72A9D00
        public void DistanceToLine(){} // RVA: 0x72A9E90
        public void GetLineNumber(){} // RVA: 0x72AA070
        public void GetLineHeight(){} // RVA: 0x72AA100
        public void GetLineHeightFromCharacterIndex(){} // RVA: 0x72AA190
        public void GetCharacterHeightFromIndex(){} // RVA: 0x72AA220
        public void IsElided(){} // RVA: 0x72AA3B0
        public void Substring(){} // RVA: 0x72AA430
        public void IndexOf(){} // RVA: 0x72AA5E0
        public void LastIndexOf(){} // RVA: 0x72AA6F0
        public void ComputeTextWidth(){} // RVA: 0x72AA7B0
        public void ComputeTextHeight(){} // RVA: 0x72AA7D0
        public void UpdatePreferredValues(){} // RVA: 0x72AA7F0
        public void Update(){} // RVA: 0x72AA990
        public void .cctor(){} // RVA: 0x72AAA70
    }

    public class TextInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72AABD0
        public void Clear(){} // RVA: 0x72AAEB0
        public void ClearMeshInfo(){} // RVA: 0x72AAF30
        public void ClearLineInfo(){} // RVA: 0x72AB000
        public void ClearPageInfo(){} // RVA: 0x72AB350
        public void Resize(){} // RVA: 0x2BB30 | overloaded x2
        public void .cctor(){} // RVA: 0x72AB4C0
    }

    public class TextProcessingElement
    {
    }

    public class TextProcessingStack`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26EE0 | overloaded x3
        public void get_Count(){} // RVA: 0xD840
        public void get_current(){} // RVA: 0x283FA0
        public void SetDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void Clear(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void Push(){} // RVA: 0x283FA0
        public void Pop(){} // RVA: 0x283FA0
        public void Peek(){} // RVA: 0x283FA0
        public void CurrentItem(){} // RVA: 0x283FA0
    }

    public class TextResourceManager
    {
        // ── Methods ──
        public void AddFontAsset(){} // RVA: 0x72AB5E0
        public void .cctor(){} // RVA: 0x72ABF90
    }

    public class TextSettings
    {
        public object faceInfo;
        public object spriteSheet;
        public object spriteCharacterTable;
        public object spriteCharacterLookupTable;
        public object spriteGlyphTable;

        // ── Methods ──
        public void get_version(){} // RVA: 0x2E07C0
        public void set_version(){} // RVA: 0x343E80
        public void get_defaultFontAsset(){} // RVA: 0x30B0C0
        public void set_defaultFontAsset(){} // RVA: 0x30B0D0
        public void get_defaultFontAssetPath(){} // RVA: 0x30B130
        public void set_defaultFontAssetPath(){} // RVA: 0x2DEE90
        public void get_fallbackFontAssets(){} // RVA: 0x6374D0
        public void set_fallbackFontAssets(){} // RVA: 0x30B890
        public void get_matchMaterialPreset(){} // RVA: 0x4A6500
        public void set_matchMaterialPreset(){} // RVA: 0x4A78C0
        public void get_missingCharacterUnicode(){} // RVA: 0x891AF0
        public void set_missingCharacterUnicode(){} // RVA: 0x1CB95F0
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x398C00
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x398C10
        public void get_defaultSpriteAsset(){} // RVA: 0x358730
        public void set_defaultSpriteAsset(){} // RVA: 0x358740
        public void get_defaultSpriteAssetPath(){} // RVA: 0x37E0E0
        public void set_defaultSpriteAssetPath(){} // RVA: 0x4354D0
        public void get_fallbackSpriteAssets(){} // RVA: 0x3A5500
        public void set_fallbackSpriteAssets(){} // RVA: 0x3A5510
        public void get_missingSpriteCharacterUnicode(){} // RVA: 0x59CEC0
        public void set_missingSpriteCharacterUnicode(){} // RVA: 0x59C530
        public void get_defaultStyleSheet(){} // RVA: 0x358D50
        public void set_defaultStyleSheet(){} // RVA: 0x358D60
        public void get_styleSheetsResourcePath(){} // RVA: 0x3A5590
        public void set_styleSheetsResourcePath(){} // RVA: 0x3A55A0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x4C7C50
        public void set_defaultColorGradientPresetsPath(){} // RVA: 0x4C34F0
        public void get_lineBreakingRules(){} // RVA: 0x72AC430
        public void set_lineBreakingRules(){} // RVA: 0x464450
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x72AC4F0
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x10F2C40
        public void get_displayWarnings(){} // RVA: 0x134A680
        public void set_displayWarnings(){} // RVA: 0x1343820
        public void OnEnable(){} // RVA: 0x72AC500
        public void InitializeFontReferenceLookup(){} // RVA: 0x72AC530
        public void GetCachedFontAssetInternal(){} // RVA: 0x72AC920
        public void .ctor(){} // RVA: 0x72ACD90
    }

    public class TextShaderUtilities
    {
        // ── Methods ──
        public void get_ShaderRef_MobileSDF(){} // RVA: 0x72AD040
        public void get_ShaderRef_MobileBitmap(){} // RVA: 0x72AD4E0
        public void .cctor(){} // RVA: 0x72AD980
        public void GetShaderPropertyIDs(){} // RVA: 0x72ADFA0
    }

    public class TextStyle
    {
        // ── Methods ──
        public void get_hashCode(){} // RVA: 0x3D92310
        public void get_styleOpeningTagArray(){} // RVA: 0x7145E90
        public void get_styleClosingTagArray(){} // RVA: 0x7187DC0
        public void .ctor(){} // RVA: 0x72AFA10
        public void RefreshStyle(){} // RVA: 0x72AFB70
    }

    public class TextStyleSheet
    {
        public object width;

        // ── Methods ──
        public void get_styles(){} // RVA: 0x2F0F420
        public void Reset(){} // RVA: 0x72AFEC0
        public void GetStyle(){} // RVA: 0x72AFF60 | overloaded x2
        public void RefreshStyles(){} // RVA: 0x72AFEC0
        public void LoadStyleDictionaryInternal(){} // RVA: 0x72B0000
        public void .ctor(){} // RVA: 0x72B0500
    }

    public class TextUtilities
    {
        // ── Methods ──
        public void ToUpperFast(){} // RVA: 0x72B0640
        public void GetHashCodeCaseInSensitive(){} // RVA: 0x72B06B0
        public void UintToString(){} // RVA: 0x72B0790
    }

    public class TextVertex
    {
    }

    public class UnicodeLineBreakingRules
    {
        public object IsAlive;
        public object Target;
        public object TrackResurrection;
        public object System.Collections.Generic;

        // ── Methods ──
        public void get_leadingCharacters(){} // RVA: 0x2E07C0
        public void get_followingCharacters(){} // RVA: 0x30B0C0
        public void get_leadingCharactersLookup(){} // RVA: 0x72B0860
        public void get_followingCharactersLookup(){} // RVA: 0x72B08A0
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x6E8A80
        public void LoadLineBreakingRules(){} // RVA: 0x72B0D90 | overloaded x2
        public void GetCharacters(){} // RVA: 0x72B11B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class WordInfo
    {
    }

    public class WordWrapState
    {
    }

}