// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.Text
// Classes: 66
// Methods: 853

namespace ThirdParty.Unity.UnityEngine.TextCore.Text
{
    public class Character : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79EDB50
    }

    public class CharacterSubstitution : ValueType
    {
        public object index;
        public object unicode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2B100
    }

    public class Character[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ColorUtilities : Object
    {
        // ── Methods ──
        public void CompareColors(){} // RVA: 0x7DC9170
        public void MultiplyColors(){} // RVA: 0x7DC91B0
    }

    public class Extents : ValueType
    {
        public object min;
        public object max;

        // ── Methods ──
        public void ToString(){} // RVA: 0x98CE40
    }

    public class FastAction : Object
    {
        public object delegates;
        public object lookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7DC9290
    }

    public class FastAction`1 : Object
    {
        public object delegates;
        public object lookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class FastAction`2 : Object
    {
        public object delegates;
        public object lookup;

        // ── Methods ──
        public void Call(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class FastAction`3 : Object
    {
        public object delegates;
        public object lookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class FontAsset : TextAsset
    {
        public object kFontAssetByInstanceId;
        public object m_SourceFontFileGUID;
        public object m_fontAssetCreationEditorSettings;
        public object m_SourceFontFile;
        public object m_SourceFontFilePath;
        public object m_AtlasPopulationMode;
        public object InternalDynamicOS;
        public object IsEditorFont;
        public object m_FaceInfo;
        public object m_FamilyNameHashCode;
        public object m_StyleNameHashCode;
        public object m_GlyphTable;
        public object m_GlyphLookupDictionary;
        public object m_CharacterTable;
        public object m_CharacterLookupDictionary;
        public object m_AtlasTexture;
        public object m_AtlasTextures;
        public object m_AtlasTextureIndex;
        public object m_IsMultiAtlasTexturesEnabled;
        public object m_GetFontFeatures;
        public object m_ClearDynamicDataOnBuild;
        public object m_AtlasWidth;
        public object m_AtlasHeight;
        public object m_AtlasPadding;
        public object m_AtlasRenderMode;
        public object m_UsedGlyphRects;
        public object m_FreeGlyphRects;
        public object m_FontFeatureTable;
        public object m_ShouldReimportFontFeatures;
        public object m_FallbackFontAssetTable;
        public object m_FontWeightTable;
        public object m_RegularStyleWeight;
        public object m_RegularStyleSpacing;
        public object m_BoldStyleWeight;
        public object m_BoldStyleSpacing;
        public object m_ItalicStyleSlant;
        public object m_TabMultiple;
        public object IsFontAssetLookupTablesDirty;
        public object m_NativeFontAsset;
        public object m_GlyphsToRender;
        public object m_GlyphsRendered;
        public object m_GlyphIndexList;
        public object m_GlyphIndexListNewlyAdded;
        public object m_GlyphsToAdd;
        public object m_GlyphsToAddLookup;
        public object m_CharactersToAdd;
        public object m_CharactersToAddLookup;
        public object s_MissingCharacterList;
        public object m_MissingUnicodesFromFontFile;
        public object m_VariantGlyphIndexes;
        public object m_IsClone;
        public object s_CallbackInstances;
        public object k_ReadFontAssetDefinitionMarker;
        public object k_AddSynthesizedCharactersMarker;
        public object k_TryAddGlyphMarker;
        public object k_TryAddCharacterMarker;
        public object k_TryAddCharactersMarker;
        public object k_UpdateLigatureSubstitutionRecordsMarker;
        public object k_UpdateGlyphAdjustmentRecordsMarker;
        public object k_UpdateDiacriticalMarkAdjustmentRecordsMarker;
        public object k_ClearFontAssetDataMarker;
        public object k_UpdateFontAssetDataMarker;
        public object s_DefaultMaterialSuffix;
        public object k_SearchedFontAssetLookup;
        public object k_FontAssets_FontFeaturesUpdateQueue;
        public object k_FontAssets_FontFeaturesUpdateQueueLookup;
        public object k_FontAssets_KerningUpdateQueue;
        public object k_FontAssets_KerningUpdateQueueLookup;
        public object k_FontAssets_AtlasTexturesUpdateQueue;
        public object k_FontAssets_AtlasTexturesUpdateQueueLookup;
        public object k_GlyphIndexArray;
        public object visitedFontAssets;

        // ── Methods ──
        public void EnsureAdditionalCapacity(){} // RVA: 0x89AB50
        public void get_fontAssetCreationEditorSettings(){} // RVA: 0x7DCD620
        public void set_fontAssetCreationEditorSettings(){} // RVA: 0x7DCD660
        public void get_sourceFontFile(){} // RVA: 0x7C7E530
        public void set_sourceFontFile(){} // RVA: 0xD5CC70
        public void get_atlasPopulationMode(){} // RVA: 0x7DCD6F0
        public void set_atlasPopulationMode(){} // RVA: 0x158BEC0
        public void get_faceInfo(){} // RVA: 0x7DCD700
        public void set_faceInfo(){} // RVA: 0x7DCD750
        public void get_familyNameHashCode(){} // RVA: 0x7DCD970
        public void set_familyNameHashCode(){} // RVA: 0x23A4120
        public void get_styleNameHashCode(){} // RVA: 0x7DCD9B0
        public void set_styleNameHashCode(){} // RVA: 0x7DCD9F0
        public void get_glyphTable(){} // RVA: 0x7DCDA00
        public void set_glyphTable(){} // RVA: 0xD9D570
        public void get_glyphLookupTable(){} // RVA: 0x7DCDA10
        public void get_characterTable(){} // RVA: 0x7DCDA50
        public void set_characterTable(){} // RVA: 0xE3D020
        public void get_characterLookupTable(){} // RVA: 0x7DCDA60
        public void get_atlasTexture(){} // RVA: 0x7DCDAA0
        public void get_atlasTextures(){} // RVA: 0xBAE8F0
        public void set_atlasTextures(){} // RVA: 0xBAE900
        public void get_atlasTextureCount(){} // RVA: 0x7DCDBF0
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7DCDC00
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7DCDC10
        public void get_getFontFeatures(){} // RVA: 0x7DCDC20
        public void set_getFontFeatures(){} // RVA: 0x7DCDC30
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7DCDC40
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7DCDC50
        public void get_atlasWidth(){} // RVA: 0x7DCDC60
        public void set_atlasWidth(){} // RVA: 0x6E15260
        public void get_atlasHeight(){} // RVA: 0x7DCDC70
        public void set_atlasHeight(){} // RVA: 0x6E15280
        public void get_atlasPadding(){} // RVA: 0x7DCDC80
        public void set_atlasPadding(){} // RVA: 0x7DCDC90
        public void get_atlasRenderMode(){} // RVA: 0x7DCDCA0
        public void set_atlasRenderMode(){} // RVA: 0x7DCDCB0
        public void get_usedGlyphRects(){} // RVA: 0x7DCDCC0
        public void set_usedGlyphRects(){} // RVA: 0x113E310
        public void get_freeGlyphRects(){} // RVA: 0x7DCDCD0
        public void set_freeGlyphRects(){} // RVA: 0x16601C0
        public void get_fontFeatureTable(){} // RVA: 0x7DCDCE0
        public void set_fontFeatureTable(){} // RVA: 0x1659C50
        public void get_fallbackFontAssetTable(){} // RVA: 0x7DCDCF0
        public void set_fallbackFontAssetTable(){} // RVA: 0x1651590
        public void get_fontWeightTable(){} // RVA: 0x7DCDD00
        public void set_fontWeightTable(){} // RVA: 0x1669D30
        public void get_regularStyleWeight(){} // RVA: 0x7DCDD10
        public void set_regularStyleWeight(){} // RVA: 0x7DCDD20
        public void get_regularStyleSpacing(){} // RVA: 0x7DCDD30
        public void set_regularStyleSpacing(){} // RVA: 0x7DCDD40
        public void get_boldStyleWeight(){} // RVA: 0x7DCDD50
        public void set_boldStyleWeight(){} // RVA: 0x7DCDD60
        public void get_boldStyleSpacing(){} // RVA: 0x7DCDD70
        public void set_boldStyleSpacing(){} // RVA: 0x7DCDD80
        public void get_italicStyleSlant(){} // RVA: 0x7DCDD90
        public void set_italicStyleSlant(){} // RVA: 0x7DCDDA0
        public void get_tabMultiple(){} // RVA: 0x7DCDDB0
        public void set_tabMultiple(){} // RVA: 0x7DCDDC0
        public void CreateFontAsset(){} // RVA: 0x7DCEE80
        public void CreateFontAssetInternal(){} // RVA: 0x7DCE100
        public void CreateFontAssetOSFallbackList(){} // RVA: 0x7DCE380
        public void CreateFontAssetWithOSFallbackList(){} // RVA: 0x7DCE540
        public void CreateFontAssetFromFamilyName(){} // RVA: 0x7DCE7D0
        public void CreateFontAssetInstance(){} // RVA: 0x7DCF310
        public void GetFontAssetByID(){} // RVA: 0x7DD0040
        public void RegisterCallbackInstance(){} // RVA: 0x7DD00D0
        public void OnDestroy(){} // RVA: 0x7DD0520
        public void ReadFontAssetDefinition(){} // RVA: 0x7DD07A0
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7DD0DB0
        public void InitializeLookup(){} // RVA: 0x89DC30
        public void InitializeList(){} // RVA: 0x89DC30
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7DD0F50
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7DD11C0
        public void ClearFallbackCharacterTable(){} // RVA: 0x7DD14C0
        public void InitializeLigatureSubstitutionLookupDictionary(){} // RVA: 0x7DD1A30
        public void InitializeGlyphPairAdjustmentRecordsLookupDictionary(){} // RVA: 0x7DD1DD0
        public void InitializeMarkToBaseAdjustmentRecordsLookupDictionary(){} // RVA: 0x7DD21B0
        public void InitializeMarkToMarkAdjustmentRecordsLookupDictionary(){} // RVA: 0x7DD2470
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7DD2730
        public void AddSynthesizedCharacter(){} // RVA: 0x7DD2940
        public void AddCharacterToLookupCache(){} // RVA: 0x7DD32B0
        public void GetCharacterInLookupCache(){} // RVA: 0x7DD33A0
        public void RemoveCharacterInLookupCache(){} // RVA: 0x7DD3470
        public void ContainsCharacterInLookupCache(){} // RVA: 0x7DD3540
        public void CreateCompositeKey(){} // RVA: 0x7DD3630
        public void LoadFontFace(){} // RVA: 0x7DD36A0
        public void SortCharacterTable(){} // RVA: 0x7DD37C0
        public void SortGlyphTable(){} // RVA: 0x7DD3A60
        public void SortFontFeatureTable(){} // RVA: 0x7DD3D00
        public void SortAllTables(){} // RVA: 0x7DD3D50
        public void HasCharacter(){} // RVA: 0x7DD3E70
        public void HasCharacterWithStyle_Internal(){} // RVA: 0x7DD4370
        public void HasCharacter_Internal(){} // RVA: 0x7DD43A0
        public void HasCharacters(){} // RVA: 0x7DD4FC0
        public void GetCharacters(){} // RVA: 0x7DD50A0
        public void GetCharactersArray(){} // RVA: 0x7DD51F0
        public void GetGlyphIndex(){} // RVA: 0x7DD5300
        public void GetGlyphVariantIndex(){} // RVA: 0x7DD5430
        public void UpdateFontAssetData(){} // RVA: 0x7DD54F0
        public void ClearFontAssetData(){} // RVA: 0x7DD5680
        public void ClearCharacterAndGlyphTablesInternal(){} // RVA: 0x7DD5AE0
        public void ClearCharacterAndGlyphTables(){} // RVA: 0x7DD5B10
        public void ClearFontFeaturesTables(){} // RVA: 0x7DD5D30
        public void ClearAtlasTextures(){} // RVA: 0x7DD5E40
        public void DestroyAtlasTextures(){} // RVA: 0x7DD62D0
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7DD64E0
        public void RegisterFontAssetForKerningUpdate(){} // RVA: 0x7DD65F0
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7DD6710
        public void RegisterAtlasTextureForApply(){} // RVA: 0x7DD6B50
        public void UpdateAtlasTexturesInQueue(){} // RVA: 0x7DD6CA0
        public void UpdateFontAssetsInUpdateQueue(){} // RVA: 0x7DD6EE0
        public void TryAddCharacters(){} // RVA: 0x7DD85A0
        public void TryAddGlyphVariantIndexInternal(){} // RVA: 0x7DD8840
        public void TryGetGlyphVariantIndexInternal(){} // RVA: 0x7DD88F0
        public void TryAddGlyphInternal(){} // RVA: 0x7DD89D0
        public void TryAddCharacterInternal(){} // RVA: 0x7DD8C10
        public void TryAddGlyphToAtlas(){} // RVA: 0x7DD9080
        public void TryAddGlyphToTexture(){} // RVA: 0x7DD94F0
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7DD9B80
        public void SetupNewAtlasTexture(){} // RVA: 0x7DDA070
        public void CreateCharacterAndAddToCache(){} // RVA: 0x7DDA3D0
        public void UpdateFontFeaturesForNewlyAddedGlyphs(){} // RVA: 0x7DDA580
        public void UpdateGlyphAdjustmentRecordsForNewGlyphs(){} // RVA: 0x7DDA650
        public void UpdateGPOSFontFeaturesForNewlyAddedGlyphs(){} // RVA: 0x7DDA6B0
        public void ImportFontFeatures(){} // RVA: 0x7DDA710
        public void UpdateGSUBFontFeaturesForNewGlyphIndex(){} // RVA: 0x7DDA850
        public void UpdateLigatureSubstitutionRecords(){} // RVA: 0x7DDA8C0
        public void AddLigatureSubstitutionRecords(){} // RVA: 0x7DDA940
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7DDAEE0
        public void AddPairAdjustmentRecords(){} // RVA: 0x7DDAF60
        public void UpdateDiacriticalMarkAdjustmentRecords(){} // RVA: 0x7DDB260
        public void AddMarkToBaseAdjustmentRecords(){} // RVA: 0x7DDB3E0
        public void AddMarkToMarkAdjustmentRecords(){} // RVA: 0x7DDB680
        public void get_nativeFontAsset(){} // RVA: 0x7DDB920
        public void EnsureNativeFontAssetIsCreated(){} // RVA: 0x7DDB940
        public void UpdateFallbacks(){} // RVA: 0x7DDCE50
        public void UpdateWeightFallbacks(){} // RVA: 0x7DDCF60
        public void UpdateFaceInfo(){} // RVA: 0x7DDD480
        public void GetFallbacks(){} // RVA: 0x7DDC020
        public void HasRecursion(){} // RVA: 0x7DDC400
        public void HasRecursionInternal(){} // RVA: 0x7DDC4E0
        public void GetWeightFallbacks(){} // RVA: 0x7DDC9E0
        public void CreateHbFaceIfNeeded(){} // RVA: 0x7DDCE00
        public void Create(){} // RVA: 0x7DDD0C0
        public void Destroy(){} // RVA: 0x7DDD520
        public void .ctor(){} // RVA: 0x7DDD570
        public void .cctor(){} // RVA: 0x7DDDDC0
        public void UpdateFallbacks_Injected(){} // RVA: 0x7DDE6B0
        public void UpdateWeightFallbacks_Injected(){} // RVA: 0x7DDE710
        public void Create_Injected(){} // RVA: 0x7DDE780
        public void UpdateFaceInfo_Injected(){} // RVA: 0x7DDE810
    }

    public class FontAssetFactory : Object
    {
        public object visitedFontAssets;

        // ── Methods ──
        public void ConvertFontToFontAsset(){} // RVA: 0x7DDE910
        public void SetupFontAssetSettings(){} // RVA: 0x7DDEC30
        public void SetHideFlags(){} // RVA: 0x7DDED30
        public void .cctor(){} // RVA: 0x7DDEE50
    }

    public class FontAssetUtilities : Object
    {
        public object k_SearchedAssets;

        // ── Methods ──
        public void GetCharacterFromFontAsset(){} // RVA: 0x7DDEF30
        public void GetCharacterFromFontAsset_Internal(){} // RVA: 0x7DDF0B0
        public void GetCharacterFromFontAssetsInternal(){} // RVA: 0x7DDFB90
        public void GetTextElementFromTextAssets(){} // RVA: 0x7DDFE40
        public void GetSpriteCharacterFromSpriteAsset(){} // RVA: 0x7DE0210
        public void GetSpriteCharacterFromSpriteAsset_Internal(){} // RVA: 0x7DE0640
        public void GetCodePoint(){} // RVA: 0x7DE0A00
    }

    public class FontAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FontFeatureTable : Object
    {
        public object m_MultipleSubstitutionRecords;
        public object m_LigatureSubstitutionRecords;
        public object m_GlyphPairAdjustmentRecords;
        public object m_MarkToBaseAdjustmentRecords;
        public object m_MarkToMarkAdjustmentRecords;
        public object m_LigatureSubstitutionRecordLookup;
        public object m_GlyphPairAdjustmentRecordLookup;
        public object m_MarkToBaseAdjustmentRecordLookup;
        public object m_MarkToMarkAdjustmentRecordLookup;

        // ── Methods ──
        public void get_glyphPairAdjustmentRecords(){} // RVA: 0xB700F0
        public void get_MarkToBaseAdjustmentRecords(){} // RVA: 0x7C246A0
        public void get_MarkToMarkAdjustmentRecords(){} // RVA: 0x7C24F60
        public void .ctor(){} // RVA: 0x7DC93E0
        public void SortGlyphPairAdjustmentRecords(){} // RVA: 0x7DC9980
        public void SortMarkToBaseAdjustmentRecords(){} // RVA: 0x7DC9D20
        public void SortMarkToMarkAdjustmentRecords(){} // RVA: 0x7DCA220
    }

    public class FontStyleStack : ValueType
    {
        public object bold;
        public object italic;
        public object underline;
        public object strikethrough;
        public object highlight;
        public object superscript;
        public object subscript;
        public object uppercase;
        public object lowercase;
        public object smallcaps;

        // ── Methods ──
        public void Clear(){} // RVA: 0x9455F0
        public void Add(){} // RVA: 0x945600
        public void Remove(){} // RVA: 0x945610
    }

    public class FontWeightPair[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class HighlightState : ValueType
    {
        public object color;
        public object padding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3612F0
        public void op_Equality(){} // RVA: 0x7E0C270
        public void op_Inequality(){} // RVA: 0x7E0C3B0
        public void GetHashCode(){} // RVA: 0x98EDF0
        public void Equals(){} // RVA: 0x98EE50
    }

    public class LinkInfo : ValueType
    {
        public object hashCode;
        public object linkIdFirstCharacterIndex;
        public object linkIdLength;
        public object linkTextfirstCharacterIndex;
        public object linkTextLength;
        public object linkId;
        public object m_LinkIdString;
        public object m_LinkTextString;

        // ── Methods ──
        public void SetLinkId(){} // RVA: 0x98D350
        public void GetLinkText(){} // RVA: 0x98D360
        public void GetLinkId(){} // RVA: 0x98D370
    }

    public class MaterialManager : Object
    {
        public object s_FallbackMaterials;

        // ── Methods ──
        public void GetFallbackMaterial(){} // RVA: 0x7DCB2E0
        public void CopyMaterialPresetProperties(){} // RVA: 0x7DCB670
        public void .cctor(){} // RVA: 0x7DCB970
    }

    public class MaterialReference : ValueType
    {
        public object index;
        public object fontAsset;
        public object spriteAsset;
        public object material;
        public object isFallbackMaterial;
        public object fallbackMaterial;
        public object padding;
        public object referenceCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98D440
        public void AddMaterialReference(){} // RVA: 0x7DCBF10
    }

    public class MaterialReferenceManager : Object
    {
        public object s_Instance;
        public object m_FontMaterialReferenceLookup;
        public object m_FontAssetReferenceLookup;
        public object m_SpriteAssetReferenceLookup;
        public object m_ColorGradientReferenceLookup;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7DCC270
        public void AddFontAsset(){} // RVA: 0x7DCC350
        public void AddFontAssetInternal(){} // RVA: 0x7DCC380
        public void AddSpriteAsset(){} // RVA: 0x7DCC5C0
        public void AddSpriteAssetInternal(){} // RVA: 0x7DCC710
        public void AddFontMaterial(){} // RVA: 0x7DCC850
        public void AddFontMaterialInternal(){} // RVA: 0x7DCC8E0
        public void AddColorGradientPreset(){} // RVA: 0x7DCC970
        public void AddColorGradientPreset_Internal(){} // RVA: 0x7DCCA40
        public void TryGetFontAsset(){} // RVA: 0x7DCCB00
        public void TryGetFontAssetInternal(){} // RVA: 0x7DCCBC0
        public void TryGetSpriteAsset(){} // RVA: 0x7DCCC70
        public void TryGetSpriteAssetInternal(){} // RVA: 0x7DCCD30
        public void TryGetColorGradientPreset(){} // RVA: 0x7DCCDE0
        public void TryGetColorGradientPresetInternal(){} // RVA: 0x7DCCEA0
        public void TryGetMaterial(){} // RVA: 0x7DCCF50
        public void TryGetMaterialInternal(){} // RVA: 0x7DCD010
        public void .ctor(){} // RVA: 0x7DCD0C0
    }

    public class MeshInfo : ValueType
    {
        public object vertexCount;
        public object vertexData;
        public object material;
        public object vertexBufferSize;
        public object applySDF;
        public object glyphRenderMode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98D5D0
        public void ResizeMeshInfo(){} // RVA: 0x98D5E0
        public void Clear(){} // RVA: 0x98D5F0
        public void ClearUnusedVertices(){} // RVA: 0x98D640
    }

    public class MeshInfoBindings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Offset : ValueType
    {
        public object m_Left;
        public object m_Right;
        public object m_Top;
        public object m_Bottom;
        public object k_ZeroOffset;

        // ── Methods ──
        public void get_left(){} // RVA: 0x459690
        public void get_right(){} // RVA: 0x958940
        public void get_top(){} // RVA: 0x958950
        public void get_bottom(){} // RVA: 0x958960
        public void get_zero(){} // RVA: 0x7E0C0F0
        public void .ctor(){} // RVA: 0x4FE0
        public void op_Equality(){} // RVA: 0x7247EC0
        public void op_Multiply(){} // RVA: 0x7BE0F10
        public void GetHashCode(){} // RVA: 0x98ED20
        public void Equals(){} // RVA: 0x98ED80
        public void .cctor(){} // RVA: 0x7E0C230
    }

    public class RenderedText : ValueType
    {
        public object value;
        public object valueStart;
        public object valueLength;
        public object suffix;
        public object repeat;
        public object repeatCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98E7F0
        public void get_CharacterCount(){} // RVA: 0x98E800
        public void GetEnumerator(){} // RVA: 0x98E820
        public void CreateString(){} // RVA: 0x98E8C0
        public void Equals(){} // RVA: 0x98E910
        public void GetHashCode(){} // RVA: 0x98EA00
    }

    public class SpriteAsset : TextAsset
    {
        public object m_NameLookup;
        public object m_GlyphIndexLookup;
        public object m_FaceInfo;
        public object m_SpriteAtlasTexture;
        public object _width;
        public object _height;
        public object m_SpriteCharacterTable;
        public object m_SpriteCharacterLookup;
        public object m_SpriteGlyphTable;
        public object m_SpriteGlyphLookup;
        public object fallbackSpriteAssets;
        public object m_IsSpriteAssetLookupTablesDirty;

        // ── Methods ──
        public void get_faceInfo(){} // RVA: 0x7E01730
        public void set_faceInfo(){} // RVA: 0x7E01770
        public void get_spriteSheet(){} // RVA: 0x7C7E610
        public void set_spriteSheet(){} // RVA: 0x7E017F0
        public void get_width(){} // RVA: 0x1BFC910
        public void set_width(){} // RVA: 0x2540B90
        public void get_height(){} // RVA: 0x2540BA0
        public void set_height(){} // RVA: 0x2540BB0
        public void get_spriteCharacterTable(){} // RVA: 0x7E018B0
        public void set_spriteCharacterTable(){} // RVA: 0xBAE3C0
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7E018F0
        public void set_spriteCharacterLookupTable(){} // RVA: 0xBAE430
        public void get_spriteGlyphTable(){} // RVA: 0x7C7E7D0
        public void set_spriteGlyphTable(){} // RVA: 0xCA4D90
        public void Awake(){} // RVA: 0xB43310
        public void UpdateLookupTables(){} // RVA: 0x7E01930
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7E02160
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7E02210
        public void GetSpriteIndexFromName(){} // RVA: 0x7E022B0
        public void SearchForSpriteByUnicode(){} // RVA: 0x7E022F0
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7E02780
        public void SearchForSpriteByHashCode(){} // RVA: 0x7E02850
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7E02FD0
        public void SortGlyphTable(){} // RVA: 0x7E030A0
        public void SortCharacterTable(){} // RVA: 0x7E03340
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7E035E0
        public void .ctor(){} // RVA: 0x7E03600
    }

    public class SpriteAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SpriteCharacter : TextElement
    {
        public object m_Name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7C24F60
        public void .ctor(){} // RVA: 0x7A696C0
    }

    public class SpriteCharacter[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SpriteGlyph : Glyph
    {
        public object sprite;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A69900
    }

    public class SpriteGlyph[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TextAsset : ScriptableObject
    {
        public object m_Version;
        public object m_InstanceID;
        public object m_HashCode;
        public object m_Material;
        public object m_MaterialHashCode;

        // ── Methods ──
        public void get_version(){} // RVA: 0x3926770
        public void set_version(){} // RVA: 0xBA9BA0
        public void get_instanceID(){} // RVA: 0x79ED340
        public void get_hashCode(){} // RVA: 0x7E03820
        public void set_hashCode(){} // RVA: 0x1FAA840
        public void get_material(){} // RVA: 0xB70160
        public void set_material(){} // RVA: 0xB44DC0
        public void get_materialHashCode(){} // RVA: 0x7E03860
        public void set_materialHashCode(){} // RVA: 0xB9E090
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class TextBackingContainer : ValueType
    {
        public object m_Array;
        public object m_Count;

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x318730
        public void get_Count(){} // RVA: 0x438050
        public void set_Count(){} // RVA: 0x92DD0
        public void get_Item(){} // RVA: 0x310190
        public void set_Item(){} // RVA: 0x98EC90
        public void .ctor(){} // RVA: 0x98ED00
        public void Resize(){} // RVA: 0x98ED10
    }

    public class TextColorGradient : ScriptableObject
    {
        public object colorMode;
        public object topLeft;
        public object topRight;
        public object bottomLeft;
        public object bottomRight;
        public object k_DefaultColorMode;
        public object k_DefaultColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79EE490
        public void .cctor(){} // RVA: 0x7E03A30
    }

    public class TextCoreVertex[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TextElement : Object
    {
        public object m_ElementType;
        public object m_Unicode;
        public object m_TextAsset;
        public object m_Glyph;
        public object m_GlyphIndex;
        public object m_Scale;

        // ── Methods ──
        public void get_elementType(){} // RVA: 0x7C7D9A0
        public void get_unicode(){} // RVA: 0x3922B50
        public void set_unicode(){} // RVA: 0x116BB10
        public void get_textAsset(){} // RVA: 0x3926770
        public void set_textAsset(){} // RVA: 0xBA9BA0
        public void get_glyph(){} // RVA: 0x7489A40
        public void set_glyph(){} // RVA: 0xB70100
        public void get_glyphIndex(){} // RVA: 0x4ED9AC0
        public void set_glyphIndex(){} // RVA: 0x13233D0
        public void get_scale(){} // RVA: 0x7CA9120
        public void set_scale(){} // RVA: 0x1186FB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TextElementInfo : ValueType
    {
        public object character;
        public object index;
        public object elementType;
        public object stringLength;
        public object textElement;
        public object alternativeGlyph;
        public object fontAsset;
        public object spriteAsset;
        public object material;
        public object materialReferenceIndex;
        public object isUsingAlternateTypeface;
        public object pointSize;
        public object lineNumber;
        public object vertexIndex;
        public object vertexTopLeft;
        public object vertexBottomLeft;
        public object vertexTopRight;
        public object vertexBottomRight;
        public object topLeft;
        public object bottomLeft;
        public object topRight;
        public object bottomRight;
        public object origin;
        public object ascender;
        public object baseLine;
        public object descender;
        public object adjustedAscender;
        public object adjustedDescender;
        public object adjustedHorizontalAdvance;
        public object xAdvance;
        public object aspectRatio;
        public object scale;
        public object color;
        public object underlineColor;
        public object underlineVertexIndex;
        public object strikethroughColor;
        public object strikethroughVertexIndex;
        public object highlightColor;
        public object highlightState;
        public object style;
        public object isVisible;

        // ── Methods ──
        public void ToString(){} // RVA: 0x98E4B0
    }

    public class TextEventManager : Object
    {
        public object MATERIAL_PROPERTY_EVENT;
        public object FONT_PROPERTY_EVENT;
        public object SPRITE_ASSET_PROPERTY_EVENT;
        public object TEXTMESHPRO_PROPERTY_EVENT;
        public object DRAG_AND_DROP_MATERIAL_EVENT;
        public object TEXT_STYLE_PROPERTY_EVENT;
        public object COLOR_GRADIENT_PROPERTY_EVENT;
        public object TMP_SETTINGS_PROPERTY_EVENT;
        public object RESOURCE_LOAD_EVENT;
        public object TEXTMESHPRO_UGUI_PROPERTY_EVENT;
        public object OnPreRenderObject_Event;
        public object TEXT_CHANGED_EVENT;

        // ── Methods ──
        public void ON_FONT_PROPERTY_CHANGED(){} // RVA: 0x7E08390
        public void .cctor(){} // RVA: 0x7E08480
    }

    public class TextGenerationInfo : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7E11B10
        public void Destroy(){} // RVA: 0x7E11B60
    }

    public class TextGenerationSettings : Object
    {
        public object IsEditorTextRenderingModeBitmap;
        public object m_RenderedText;
        public object m_CachedRenderedText;
        public object screenRect;
        public object pixelsPerPoint;
        public object isEditorRenderingModeBitmap;
        public object fontAsset;
        public object fontStyle;
        public object textSettings;
        public object textAlignment;
        public object overflowMode;
        public object wordWrappingRatio;
        public object color;
        public object shouldConvertToLinearSpace;
        public object fontSize;
        public object autoSize;
        public object fontSizeMin;
        public object fontSizeMax;
        public object fontFeatures;
        public object emojiFallbackSupport;
        public object richText;
        public object isRightToLeft;
        public object extraPadding;
        public object parseControlCharacters;
        public object isPlaceholder;
        public object tagNoParsing;
        public object characterSpacing;
        public object wordSpacing;
        public object lineSpacing;
        public object paragraphSpacing;
        public object lineSpacingMax;
        public object textWrappingMode;
        public object maxVisibleCharacters;
        public object maxVisibleWords;
        public object maxVisibleLines;
        public object firstVisibleCharacter;
        public object useMaxVisibleDescender;
        public object fontWeight;
        public object isIMGUI;
        public object charWidthMaxAdj;

        // ── Methods ──
        public void get_renderedText(){} // RVA: 0x26FAD00
        public void set_renderedText(){} // RVA: 0x7E090E0
        public void get_text(){} // RVA: 0x7E091A0
        public void set_text(){} // RVA: 0x7E09230
        public void .ctor(){} // RVA: 0x7E092A0
        public void Equals(){} // RVA: 0x7E09600
        public void GetHashCode(){} // RVA: 0x7E09700
        public void op_Inequality(){} // RVA: 0x7E0A140
        public void ToString(){} // RVA: 0x7E0A190
        public void .cctor(){} // RVA: 0x7E0B3C0
    }

    public class TextGenerator : Object
    {
        public object k_Tab;
        public object k_LineFeed;
        public object k_VerticalTab;
        public object k_CarriageReturn;
        public object k_Space;
        public object k_DoubleQuotes;
        public object k_NumberSign;
        public object k_PercentSign;
        public object k_SingleQuote;
        public object k_Plus;
        public object k_Period;
        public object k_LesserThan;
        public object k_Equal;
        public object k_GreaterThan;
        public object k_Underline;
        public object k_NoBreakSpace;
        public object k_SoftHyphen;
        public object k_HyphenMinus;
        public object k_FigureSpace;
        public object k_Hyphen;
        public object k_NonBreakingHyphen;
        public object k_ZeroWidthSpace;
        public object k_NarrowNoBreakSpace;
        public object k_WordJoiner;
        public object k_HorizontalEllipsis;
        public object k_LineSeparator;
        public object k_ParagraphSeparator;
        public object k_RightSingleQuote;
        public object k_Square;
        public object k_HangulJamoStart;
        public object k_HangulJamoEnd;
        public object k_CjkStart;
        public object k_CjkEnd;
        public object k_HangulJameExtendedStart;
        public object k_HangulJameExtendedEnd;
        public object k_HangulSyllablesStart;
        public object k_HangulSyllablesEnd;
        public object k_CjkIdeographsStart;
        public object k_CjkIdeographsEnd;
        public object k_CjkFormsStart;
        public object k_CjkFormsEnd;
        public object k_CjkHalfwidthStart;
        public object k_CjkHalfwidthEnd;
        public object k_EndOfText;
        public object k_FloatUnset;
        public object k_MaxCharacters;
        public object s_TextGenerator;
        public object _isExecutingJob;
        public object m_TextBackingArray;
        public object m_TextProcessingArray;
        public object m_InternalTextProcessingArraySize;
        public object m_VertexBufferAutoSizeReduction;
        public object m_HtmlTag;
        public object m_HighlightState;
        public object m_IsIgnoringAlignment;
        public object m_IsTextTruncated;
        public object OnMissingCharacter;
        public object m_RectTransformCorners;
        public object m_MarginWidth;
        public object m_MarginHeight;
        public object m_PreferredWidth;
        public object m_PreferredHeight;
        public object m_CurrentFontAsset;
        public object m_CurrentMaterial;
        public object m_CurrentMaterialIndex;
        public object m_MaterialReferenceStack;
        public object m_Padding;
        public object m_CurrentSpriteAsset;
        public object m_TotalCharacterCount;
        public object m_FontSize;
        public object m_FontScaleMultiplier;
        public object m_CurrentFontSize;
        public object m_SizeStack;
        public object m_TextStyleStacks;
        public object m_TextStyleStackDepth;
        public object m_FontStyleInternal;
        public object m_FontStyleStack;
        public object m_FontWeightInternal;
        public object m_FontWeightStack;
        public object m_LineJustification;
        public object m_LineJustificationStack;
        public object m_BaselineOffset;
        public object m_BaselineOffsetStack;
        public object m_FontColor32;
        public object m_HtmlColor;
        public object m_UnderlineColor;
        public object m_StrikethroughColor;
        public object m_ColorStack;
        public object m_UnderlineColorStack;
        public object m_StrikethroughColorStack;
        public object m_HighlightColorStack;
        public object m_HighlightStateStack;
        public object m_ItalicAngleStack;
        public object m_ColorGradientPreset;
        public object m_ColorGradientStack;
        public object m_ColorGradientPresetIsTinted;
        public object m_ActionStack;
        public object m_LineOffset;
        public object m_LineHeight;
        public object m_IsDrivenLineSpacing;
        public object m_CSpacing;
        public object m_MonoSpacing;
        public object m_DuoSpace;
        public object m_XAdvance;
        public object m_TagLineIndent;
        public object m_TagIndent;
        public object m_IndentStack;
        public object m_TagNoParsing;
        public object m_CharacterCount;
        public object m_FirstCharacterOfLine;
        public object m_LastCharacterOfLine;
        public object m_FirstVisibleCharacterOfLine;
        public object m_LastVisibleCharacterOfLine;
        public object m_MaxLineAscender;
        public object m_MaxLineDescender;
        public object m_LineNumber;
        public object m_LineVisibleCharacterCount;
        public object m_LineVisibleSpaceCount;
        public object m_FirstOverflowCharacterIndex;
        public object m_MarginLeft;
        public object m_MarginRight;
        public object m_Width;
        public object m_MeshExtents;
        public object m_MaxCapHeight;
        public object m_MaxAscender;
        public object m_MaxDescender;
        public object m_IsNonBreakingSpace;
        public object m_SavedWordWrapState;
        public object m_SavedLineState;
        public object m_SavedEllipsisState;
        public object m_SavedLastValidState;
        public object m_SavedSoftLineBreakState;
        public object m_TextElementType;
        public object m_isTextLayoutPhase;
        public object m_SpriteIndex;
        public object m_SpriteColor;
        public object m_CachedTextElement;
        public object m_HighlightColor;
        public object m_CharWidthAdjDelta;
        public object m_MaxFontSize;
        public object m_MinFontSize;
        public object m_AutoSizeIterationCount;
        public object m_AutoSizeMaxIterationCount;
        public object m_StartOfLineAscender;
        public object m_LineSpacingDelta;
        public object m_MaterialReferences;
        public object m_SpriteCount;
        public object m_StyleStack;
        public object m_EllipsisInsertionCandidateStack;
        public object m_SpriteAnimationId;
        public object m_ItalicAngle;
        public object m_FXScale;
        public object m_FXRotation;
        public object m_LastBaseGlyphIndex;
        public object m_PageAscender;
        public object m_XmlAttribute;
        public object m_AttributeParameterValues;
        public object m_MaterialReferenceIndexLookup;
        public object m_IsCalculatingPreferredValues;
        public object m_TintSprite;
        public object m_Ellipsis;
        public object m_Underline;
        public object m_InternalTextElementInfo;

        // ── Methods ──
        public void get_IsExecutingJob(){} // RVA: 0x7DE0B40
        public void set_IsExecutingJob(){} // RVA: 0x7DE0B80
        public void GenerateText(){} // RVA: 0x7DE0BD0
        public void get_isTextTruncated(){} // RVA: 0x7DE0E10
        public void GenerateTextMesh(){} // RVA: 0x7DE0E20
        public void ValidateHtmlTag(){} // RVA: 0x7DE11D0
        public void CloseLastLinkTag(){} // RVA: 0x7DE7200
        public void CloseAllLinkTags(){} // RVA: 0x7DE7290
        public void CloseLinkTag(){} // RVA: 0x7DE7300
        public void ClearMarkupTagAttributes(){} // RVA: 0x7DE7370
        public void SaveWordWrappingState(){} // RVA: 0x7DE73D0
        public void RestoreWordWrappingState(){} // RVA: 0x7DE7E90
        public void SaveGlyphVertexInfo(){} // RVA: 0x7DE8930
        public void SaveSpriteVertexInfo(){} // RVA: 0x7DE9560
        public void DrawUnderlineMesh(){} // RVA: 0x7DE9C90
        public void DrawTextHighlight(){} // RVA: 0x7DEA780
        public void ClearMesh(){} // RVA: 0x7DEACD0
        public void LayoutPhase(){} // RVA: 0x7DEADA0
        public void ParsingPhase(){} // RVA: 0x7DEEEF0
        public void InsertNewLine(){} // RVA: 0x7DF5B80
        public void GetPreferredValues(){} // RVA: 0x7DF63F0
        public void GetPreferredValuesInternal(){} // RVA: 0x7DF6780
        public void CalculatePreferredValues(){} // RVA: 0x7DF6960
        public void Prepare(){} // RVA: 0x7DFA240
        public void PrepareFontAsset(){} // RVA: 0x7DFA4E0
        public void SetArraySizes(){} // RVA: 0x7DFA600
        public void GetTextElement(){} // RVA: 0x7DFC540
        public void PopulateTextBackingArray(){} // RVA: 0x7DFCC20
        public void PopulateTextProcessingArray(){} // RVA: 0x7DFCEC0
        public void PopulateFontAsset(){} // RVA: 0x7DFDF80
        public void ComputeMarginSize(){} // RVA: 0x7DFF5D0
        public void GetSpecialCharacters(){} // RVA: 0x7DFF6D0
        public void GetEllipsisSpecialCharacter(){} // RVA: 0x7DFF730
        public void GetUnderlineSpecialCharacter(){} // RVA: 0x7DFFC00
        public void DoMissingGlyphCallback(){} // RVA: 0x7E00070
        public void .ctor(){} // RVA: 0x7E00100
    }

    public class TextGeneratorUtilities : Object
    {
        public object largePositiveVector2;
        public object largeNegativeVector2;
        public object k_EmojiLookup;
        public object k_EmojiPresentationFormLookup;

        // ── Methods ──
        public void Approximately(){} // RVA: 0x7E0C5D0
        public void HexCharsToColor(){} // RVA: 0x7E0C600
        public void HexToInt(){} // RVA: 0x7A79940
        public void ConvertToFloat(){} // RVA: 0x7E0CAA0
        public void ResizeInternalArray(){} // RVA: 0x89AB50
        public void InsertOpeningTextStyle(){} // RVA: 0x7E0CC20
        public void InsertClosingTextStyle(){} // RVA: 0x7E0CD20
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7E0D020
        public void ReplaceClosingStyleTag(){} // RVA: 0x7E0D220
        public void InsertOpeningStyleTag(){} // RVA: 0x7E0D350
        public void InsertClosingStyleTag(){} // RVA: 0x7E0D450
        public void InsertTextStyleInTextProcessingArray(){} // RVA: 0x7E0D550
        public void GetStyle(){} // RVA: 0x7E0DA70
        public void GetStyleHashCode(){} // RVA: 0x7E0DCD0
        public void GetUTF16(){} // RVA: 0x7E0DEB0
        public void GetUTF32(){} // RVA: 0x7E0E110
        public void FillCharacterVertexBuffers(){} // RVA: 0x7E0E2C0
        public void FillSpriteVertexBuffers(){} // RVA: 0x7E0EC40
        public void AdjustLineOffset(){} // RVA: 0x7E0F560
        public void ResizeLineExtents(){} // RVA: 0x7E0F8F0
        public void LegacyStyleToNewStyle(){} // RVA: 0x7E0FB60
        public void LegacyAlignmentToNewAlignment(){} // RVA: 0x7E0FB90
        public void GetHorizontalAlignment(){} // RVA: 0x7E0FC10
        public void GetVerticalAlignment(){} // RVA: 0x7E0FC60
        public void ConvertToUTF32(){} // RVA: 0x7E0FCB0
        public void GetMarkupTagHashCode(){} // RVA: 0x7E0FDC0
        public void ToUpperASCIIFast(){} // RVA: 0x7E0FF30
        public void ToUpperFast(){} // RVA: 0x7E0FFA0
        public void GetAttributeParameters(){} // RVA: 0x7E10010
        public void IsBitmapRendering(){} // RVA: 0x7E10100
        public void IsBaseGlyph(){} // RVA: 0x7E10130
        public void MinAlpha(){} // RVA: 0x7E10240
        public void GammaToLinear(){} // RVA: 0x7E10330
        public void IsValidUTF16(){} // RVA: 0x7E103E0
        public void IsValidUTF32(){} // RVA: 0x7E10450
        public void IsEmoji(){} // RVA: 0x7E104C0
        public void IsEmojiPresentationForm(){} // RVA: 0x7E10550
        public void IsHangul(){} // RVA: 0x7E105E0
        public void IsCJK(){} // RVA: 0x7E10640
        public void .cctor(){} // RVA: 0x7E10700
    }

    public class TextHandle : Object
    {
        public object s_TemporaryCache;
        public object s_PermanentCache;
        public object s_Settings;
        public object s_Generators;
        public object s_TextInfosCommon;
        public object nativeSettings;
        public object _preferredSize;
        public object m_ScreenRect;
        public object m_LineHeightDefault;
        public object m_IsPlaceholder;
        public object m_IsEllided;
        public object textGenerationInfo;
        public object _textInfoNode;
        public object _isCachedPermanent;
        public object _isCachedTemporary;
        public object m_PreviousGenerationSettingsHash;
        public object isDirty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E12830
        public void Finalize(){} // RVA: 0x7E12900
        public void InitThreadArrays(){} // RVA: 0x7E12950
        public void get_settingsArray(){} // RVA: 0x7E12E60
        public void get_generators(){} // RVA: 0x7E13080
        public void get_textInfosCommon(){} // RVA: 0x7E132A0
        public void InitArray(){} // RVA: 0x8945C0
        public void get_textInfoCommon(){} // RVA: 0x7E134C0
        public void get_generator(){} // RVA: 0x7E13570
        public void get_settings(){} // RVA: 0x7E13620
        public void get_preferredSize(){} // RVA: 0x6297350
        public void set_preferredSize(){} // RVA: 0x278E9C0
        public void get_TextInfoNode(){} // RVA: 0x106A7D0
        public void set_TextInfoNode(){} // RVA: 0xD5CC70
        public void get_IsCachedPermanent(){} // RVA: 0x2443C20
        public void set_IsCachedPermanent(){} // RVA: 0x143D170
        public void get_IsCachedTemporary(){} // RVA: 0x25D1680
        public void set_IsCachedTemporary(){} // RVA: 0x25D1690
        public void get_useAdvancedText(){} // RVA: 0x254FA90
        public void get_characterCount(){} // RVA: 0x7E136D0
        public void AddTextInfoToPermanentCache(){} // RVA: 0x7E13720
        public void AddTextInfoToTemporaryCache(){} // RVA: 0x7E13800
        public void RemoveTextInfoFromTemporaryCache(){} // RVA: 0x7E138A0
        public void RemoveTextInfoFromPermanentCache(){} // RVA: 0x7E13920
        public void UpdateCurrentFrame(){} // RVA: 0x7E13A00
        public void get_textInfo(){} // RVA: 0x7E13AB0
        public void SetDirty(){} // RVA: 0x5A14070
        public void IsDirty(){} // RVA: 0x7E13B30
        public void get_IsPlaceholder(){} // RVA: 0xBAB4F0
        public void UpdatePreferredValues(){} // RVA: 0x7E13B70
        public void Update(){} // RVA: 0x7E13C20
        public void UpdateWithHash(){} // RVA: 0x7E13CA0
        public void PrepareFontAsset(){} // RVA: 0x7E13F60
        public void UpdatePreferredSize(){} // RVA: 0x7E14200
        public void ConvertPixelUnitsToTextCoreRelativeUnits(){} // RVA: 0x7E146E0
        public void GetLineHeightDefault(){} // RVA: 0x7E14730
        public void GetCursorPositionFromStringIndexUsingCharacterHeight(){} // RVA: 0x7E14870
        public void GetCursorPositionFromStringIndexUsingLineHeight(){} // RVA: 0x7E14930
        public void GetHighlightRectangles(){} // RVA: 0x7E14AD0
        public void GetCursorIndexFromPosition(){} // RVA: 0x7E14BB0
        public void LineDownCharacterPosition(){} // RVA: 0x7E14DD0
        public void LineUpCharacterPosition(){} // RVA: 0x7E14E80
        public void FindIntersectingLink(){} // RVA: 0x7E14F30
        public void GetCorrespondingStringIndex(){} // RVA: 0x7E15030
        public void GetLineInfoFromCharacterIndex(){} // RVA: 0x7E150D0
        public void GetLineNumber(){} // RVA: 0x7E15270
        public void GetLineHeight(){} // RVA: 0x7E15350
        public void GetLineHeightFromCharacterIndex(){} // RVA: 0x7E15430
        public void GetCharacterHeightFromIndex(){} // RVA: 0x7E15550
        public void Substring(){} // RVA: 0x7E15650
        public void PreviousCodePointIndex(){} // RVA: 0x7E15830
        public void NextCodePointIndex(){} // RVA: 0x7E15910
        public void GetStartOfNextWord(){} // RVA: 0x7E159F0
        public void GetEndOfPreviousWord(){} // RVA: 0x7E15AD0
        public void GetFirstCharacterIndexOnLine(){} // RVA: 0x7E15BB0
        public void GetLastCharacterIndexOnLine(){} // RVA: 0x7E15C90
        public void IndexOf(){} // RVA: 0x7E15D70
        public void LastIndexOf(){} // RVA: 0x7E15EE0
        public void SelectCurrentWord(){} // RVA: 0x7E16030
        public void SelectCurrentParagraph(){} // RVA: 0x7E16130
        public void SelectToPreviousParagraph(){} // RVA: 0x7E16230
        public void SelectToNextParagraph(){} // RVA: 0x7E16310
        public void SelectToStartOfParagraph(){} // RVA: 0x7E163F0
        public void SelectToEndOfParagraph(){} // RVA: 0x7E164D0
        public void IsAdvancedTextEnabledForElement(){} // RVA: 0x263B110
        public void .cctor(){} // RVA: 0x7E165B0
    }

    public class TextHandlePermanentCache : Object
    {
        public object s_TextInfoPool;
        public object syncRoot;

        // ── Methods ──
        public void AddTextInfoToCache(){} // RVA: 0x7E16C40
        public void RemoveTextInfoFromCache(){} // RVA: 0x7E16EE0
        public void .ctor(){} // RVA: 0x7E170D0
    }

    public class TextHandleTemporaryCache : Object
    {
        public object s_TextInfoPool;
        public object s_MinFramesInCache;
        public object currentFrame;
        public object syncRoot;

        // ── Methods ──
        public void ClearTemporaryCache(){} // RVA: 0x7E17200
        public void AddTextInfoToCache(){} // RVA: 0x7E17360
        public void RemoveTextInfoFromCache(){} // RVA: 0x7E179F0
        public void RefreshCaching(){} // RVA: 0x7E17CE0
        public void RecycleTextInfoFromCache(){} // RVA: 0x7E17ED0
        public void UpdateCurrentFrame(){} // RVA: 0x7E18210
        public void .ctor(){} // RVA: 0x7E18260
    }

    public class TextInfo : Object
    {
        public object s_InfinityVectorPositive;
        public object s_InfinityVectorNegative;
        public object characterCount;
        public object spriteCount;
        public object spaceCount;
        public object wordCount;
        public object linkCount;
        public object lineCount;
        public object materialCount;
        public object textElementInfo;
        public object wordInfo;
        public object linkInfo;
        public object lineInfo;
        public object meshInfo;
        public object lastTimeInCache;
        public object removedFromCache;
        public object hasMultipleColors;

        // ── Methods ──
        public void RemoveFromCache(){} // RVA: 0x7E18390
        public void .ctor(){} // RVA: 0x7E18410
        public void Clear(){} // RVA: 0x7E18730
        public void ClearMeshInfo(){} // RVA: 0x7E187A0
        public void ClearLineInfo(){} // RVA: 0x7E18860
        public void Resize(){} // RVA: 0x89B4F0
        public void GetCursorPositionFromStringIndexUsingCharacterHeight(){} // RVA: 0x7E18B30
        public void GetCursorPositionFromStringIndexUsingLineHeight(){} // RVA: 0x7E18C20
        public void GetCursorIndexFromPosition(){} // RVA: 0x7E18D50
        public void LineDownCharacterPosition(){} // RVA: 0x7E18EF0
        public void LineUpCharacterPosition(){} // RVA: 0x7E190C0
        public void FindNearestLine(){} // RVA: 0x7E19290
        public void FindNearestCharacterOnLine(){} // RVA: 0x7E19360
        public void FindIntersectingLink(){} // RVA: 0x7E197C0
        public void GetCorrespondingStringIndex(){} // RVA: 0x7E19D00
        public void GetLineInfoFromCharacterIndex(){} // RVA: 0x7E19D60
        public void PointIntersectRectangle(){} // RVA: 0x7E19E30
        public void DistanceToLine(){} // RVA: 0x7E1A0E0
        public void GetLineNumber(){} // RVA: 0x7E1A350
        public void GetLineHeight(){} // RVA: 0x7E1A3A0
        public void GetLineHeightFromCharacterIndex(){} // RVA: 0x7E1A400
        public void GetCharacterHeightFromIndex(){} // RVA: 0x7E1A490
        public void Substring(){} // RVA: 0x7E1A4F0
        public void IndexOf(){} // RVA: 0x7E1A6A0
        public void LastIndexOf(){} // RVA: 0x7E1A750
        public void .cctor(){} // RVA: 0x7E1A800
    }

    public class TextLib : Object
    {
        public object m_Ptr;
        public object GetICUAssetEditorDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E10990
        public void GetInstance(){} // RVA: 0x7E10A70
        public void GenerateText(){} // RVA: 0x7E10B40
        public void ProcessMeshInfos(){} // RVA: 0x7E10CC0
        public void GenerateTextInternal(){} // RVA: 0x7E117C0
        public void MeasureText(){} // RVA: 0x7E11860
        public void FindIntersectingLink(){} // RVA: 0x7E11900
        public void GetInstance_Injected(){} // RVA: 0x7E11960
        public void GenerateTextInternal_Injected(){} // RVA: 0x7E119B0
        public void MeasureText_Injected(){} // RVA: 0x7E11A30
        public void FindIntersectingLink_Injected(){} // RVA: 0x7E11AB0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8965E0
        public void get_Count(){} // RVA: 0x87C130
        public void get_current(){} // RVA: 0xA94080
        public void SetDefault(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Add(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void Push(){} // RVA: 0xA94080
        public void Pop(){} // RVA: 0xA94080
        public void Peek(){} // RVA: 0xA94080
        public void CurrentItem(){} // RVA: 0xA94080
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4AA260
        public void get_Count(){} // RVA: 0x53FBE0
        public void get_current(){} // RVA: 0x4AA350
        public void SetDefault(){} // RVA: 0x4AA410
        public void Clear(){} // RVA: 0x4AA400
        public void Add(){} // RVA: 0x4AA450
        public void Remove(){} // RVA: 0x53FBF0
        public void Push(){} // RVA: 0x53FC30
        public void Pop(){} // RVA: 0x4AA620
        public void Peek(){} // RVA: 0x4AA780
        public void CurrentItem(){} // RVA: 0x4AA350
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A9610
        public void get_Count(){} // RVA: 0x53FA00
        public void get_current(){} // RVA: 0x4AAD80
        public void SetDefault(){} // RVA: 0x4AADD0
        public void Clear(){} // RVA: 0x4A9730
        public void Add(){} // RVA: 0x4AADE0
        public void Remove(){} // RVA: 0x4AAE20
        public void Push(){} // RVA: 0x53FD90
        public void Pop(){} // RVA: 0x4AAE40
        public void Peek(){} // RVA: 0x4AAE50
        public void CurrentItem(){} // RVA: 0x4AAD80
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A9610
        public void get_Count(){} // RVA: 0x53FA00
        public void get_current(){} // RVA: 0x4A96E0
        public void SetDefault(){} // RVA: 0x4A9F80
        public void Clear(){} // RVA: 0x4A9730
        public void Add(){} // RVA: 0x4A9750
        public void Remove(){} // RVA: 0x4A9F90
        public void Push(){} // RVA: 0x4A9FA0
        public void Pop(){} // RVA: 0x4AA060
        public void Peek(){} // RVA: 0x4A9900
        public void CurrentItem(){} // RVA: 0x4A96E0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A9610
        public void get_Count(){} // RVA: 0x53FA00
        public void get_current(){} // RVA: 0x4A96E0
        public void SetDefault(){} // RVA: 0x4A9F80
        public void Clear(){} // RVA: 0x4A9730
        public void Add(){} // RVA: 0x4A9750
        public void Remove(){} // RVA: 0x4A9F90
        public void Push(){} // RVA: 0x4A9FA0
        public void Pop(){} // RVA: 0x4AA060
        public void Peek(){} // RVA: 0x4A9900
        public void CurrentItem(){} // RVA: 0x4A96E0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A9610
        public void get_Count(){} // RVA: 0x53FA00
        public void get_current(){} // RVA: 0x4A96E0
        public void SetDefault(){} // RVA: 0x4A9740
        public void Clear(){} // RVA: 0x4A9730
        public void Add(){} // RVA: 0x4A9750
        public void Remove(){} // RVA: 0x4A9790
        public void Push(){} // RVA: 0x53FA10
        public void Pop(){} // RVA: 0x4A9860
        public void Peek(){} // RVA: 0x4A9900
        public void CurrentItem(){} // RVA: 0x4A96E0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A9AE0
        public void get_Count(){} // RVA: 0x53FAD0
        public void get_current(){} // RVA: 0x4A9BB0
        public void SetDefault(){} // RVA: 0x4A9C40
        public void Clear(){} // RVA: 0x4A9C30
        public void Add(){} // RVA: 0x4A9C70
        public void Remove(){} // RVA: 0x53FAE0
        public void Push(){} // RVA: 0x4A9D50
        public void Pop(){} // RVA: 0x4A9D80
        public void Peek(){} // RVA: 0x53FB70
        public void CurrentItem(){} // RVA: 0x4A9BB0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A9610
        public void get_Count(){} // RVA: 0x53FA00
        public void get_current(){} // RVA: 0x4A96E0
        public void SetDefault(){} // RVA: 0x4A9F40
        public void Clear(){} // RVA: 0x4A9730
        public void Add(){} // RVA: 0x4A9750
        public void Remove(){} // RVA: 0x4A9790
        public void Push(){} // RVA: 0x4A9F50
        public void Pop(){} // RVA: 0x4A9F60
        public void Peek(){} // RVA: 0x4A9900
        public void CurrentItem(){} // RVA: 0x4A96E0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4AA9D0
        public void get_Count(){} // RVA: 0x53FD80
        public void get_current(){} // RVA: 0x4AAAA0
        public void SetDefault(){} // RVA: 0x4AAB00
        public void Clear(){} // RVA: 0x4AAAF0
        public void Add(){} // RVA: 0x4AAB10
        public void Remove(){} // RVA: 0x4AAB50
        public void Push(){} // RVA: 0x4AAB60
        public void Pop(){} // RVA: 0x4AAC20
        public void Peek(){} // RVA: 0x4AACE0
        public void CurrentItem(){} // RVA: 0x4AAAA0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public object itemStack;
        public object index;
        public object m_DefaultItem;
        public object m_Capacity;
        public object m_RolloverSize;
        public object m_Count;
        public object k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x53FF10
        public void get_Count(){} // RVA: 0x53FF20
        public void get_current(){} // RVA: 0x53FF30
        public void SetDefault(){} // RVA: 0x540100
        public void Clear(){} // RVA: 0x5400F0
        public void Add(){} // RVA: 0x5401A0
        public void Remove(){} // RVA: 0x540260
        public void Push(){} // RVA: 0x540440
        public void Pop(){} // RVA: 0x5404E0
        public void Peek(){} // RVA: 0x540580
        public void CurrentItem(){} // RVA: 0x53FF30
    }

    public class TextResourceManager : Object
    {
        public object s_FontAssetReferences;
        public object s_FontAssetNameReferenceLookup;
        public object s_FontAssetFamilyNameAndStyleReferenceLookup;
        public object s_FontAssetRemovalList;
        public object k_RegularStyleHashCode;

        // ── Methods ──
        public void AddFontAsset(){} // RVA: 0x7E1A870
        public void .cctor(){} // RVA: 0x7E1B210
    }

    public class TextSelectionService : Object
    {
        // ── Methods ──
        public void Substring(){} // RVA: 0x7E11BB0
        public void SelectCurrentWord(){} // RVA: 0x7E11CA0
        public void PreviousCodePointIndex(){} // RVA: 0x7E11D20
        public void NextCodePointIndex(){} // RVA: 0x7E11D80
        public void GetCursorLogicalIndexFromPosition(){} // RVA: 0x7E11DE0
        public void GetCursorPositionFromLogicalIndex(){} // RVA: 0x7E11E40
        public void LineUpCharacterPosition(){} // RVA: 0x7E11EB0
        public void LineDownCharacterPosition(){} // RVA: 0x7E11F10
        public void GetHighlightRectangles(){} // RVA: 0x7E11F70
        public void GetCharacterHeightFromIndex(){} // RVA: 0x7E121D0
        public void GetStartOfNextWord(){} // RVA: 0x7E12230
        public void GetEndOfPreviousWord(){} // RVA: 0x7E12290
        public void GetFirstCharacterIndexOnLine(){} // RVA: 0x7E122F0
        public void GetLastCharacterIndexOnLine(){} // RVA: 0x7E12350
        public void GetLineHeight(){} // RVA: 0x7E123B0
        public void GetLineNumber(){} // RVA: 0x7E12410
        public void SelectToPreviousParagraph(){} // RVA: 0x7E12470
        public void SelectToStartOfParagraph(){} // RVA: 0x7E124D0
        public void SelectToEndOfParagraph(){} // RVA: 0x7E12530
        public void SelectToNextParagraph(){} // RVA: 0x7E12590
        public void SelectCurrentParagraph(){} // RVA: 0x7E125F0
        public void Substring_Injected(){} // RVA: 0x7E12660
        public void GetCursorLogicalIndexFromPosition_Injected(){} // RVA: 0x7E126E0
        public void GetCursorPositionFromLogicalIndex_Injected(){} // RVA: 0x7E12740
        public void GetHighlightRectangles_Injected(){} // RVA: 0x7E127B0
    }

    public class TextSettings : ScriptableObject
    {
        public object m_Version;
        public object m_DefaultFontAsset;
        public object m_DefaultFontAssetPath;
        public object m_FallbackFontAssets;
        public object s_FallbackOSFontAssetInternal;
        public object m_MatchMaterialPreset;
        public object m_MissingCharacterUnicode;
        public object m_ClearDynamicDataOnBuild;
        public object m_EnableEmojiSupport;
        public object m_EmojiFallbackTextAssets;
        public object m_DefaultSpriteAsset;
        public object m_DefaultSpriteAssetPath;
        public object m_FallbackSpriteAssets;
        public object _s_GlobalSpriteAsset;
        public object m_MissingSpriteCharacterUnicode;
        public object m_DefaultStyleSheet;
        public object m_StyleSheetsResourcePath;
        public object m_DefaultColorGradientPresetsPath;
        public object m_UnicodeLineBreakingRules;
        public object m_DisplayWarnings;
        public object m_FontLookup;
        public object m_FontReferences;
        public object m_NativeTextSettings;
        public object m_IsNativeTextSettingsDirty;

        // ── Methods ──
        public void get_version(){} // RVA: 0xB465B0
        public void set_version(){} // RVA: 0xBA9BA0
        public void get_defaultFontAsset(){} // RVA: 0xB700F0
        public void set_defaultFontAsset(){} // RVA: 0xB70100
        public void get_defaultFontAssetPath(){} // RVA: 0xB70160
        public void set_defaultFontAssetPath(){} // RVA: 0xB44DC0
        public void get_fallbackFontAssets(){} // RVA: 0xD33E60
        public void set_fallbackFontAssets(){} // RVA: 0x7E03A80
        public void get_fallbackOSFontAssets(){} // RVA: 0x7E03AF0
        public void GetStaticFallbackOSFontAsset(){} // RVA: 0x7E03BE0
        public void SetStaticFallbackOSFontAsset(){} // RVA: 0x7E03C20
        public void GetFallbackFontAssets(){} // RVA: 0x7C24F60
        public void get_matchMaterialPreset(){} // RVA: 0xD16660
        public void set_matchMaterialPreset(){} // RVA: 0xD14C10
        public void get_missingCharacterUnicode(){} // RVA: 0x114DAD0
        public void set_missingCharacterUnicode(){} // RVA: 0x25671C0
        public void get_clearDynamicDataOnBuild(){} // RVA: 0xC02470
        public void set_clearDynamicDataOnBuild(){} // RVA: 0xC02480
        public void get_enableEmojiSupport(){} // RVA: 0x7E03CC0
        public void set_enableEmojiSupport(){} // RVA: 0xEEA000
        public void get_emojiFallbackTextAssets(){} // RVA: 0xBBF8F0
        public void set_emojiFallbackTextAssets(){} // RVA: 0x7E03CD0
        public void get_defaultSpriteAsset(){} // RVA: 0xBE58B0
        public void set_defaultSpriteAsset(){} // RVA: 0xCA4DF0
        public void get_defaultSpriteAssetPath(){} // RVA: 0xC0FFC0
        public void set_defaultSpriteAssetPath(){} // RVA: 0xC0FFD0
        public void get_fallbackSpriteAssets(){} // RVA: 0xBE2C60
        public void set_fallbackSpriteAssets(){} // RVA: 0xBE2C70
        public void set_s_GlobalSpriteAsset(){} // RVA: 0x7E03D40
        public void get_s_GlobalSpriteAsset(){} // RVA: 0x7E03DE0
        public void get_missingSpriteCharacterUnicode(){} // RVA: 0x2536460
        public void set_missingSpriteCharacterUnicode(){} // RVA: 0x25406E0
        public void get_defaultStyleSheet(){} // RVA: 0xC10050
        public void set_defaultStyleSheet(){} // RVA: 0xC10060
        public void get_styleSheetsResourcePath(){} // RVA: 0xCD3320
        public void set_styleSheetsResourcePath(){} // RVA: 0xCD4740
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0xCD48B0
        public void set_defaultColorGradientPresetsPath(){} // RVA: 0xCD3600
        public void get_lineBreakingRules(){} // RVA: 0x7E03E20
        public void set_lineBreakingRules(){} // RVA: 0xD5CBB0
        public void get_displayWarnings(){} // RVA: 0x1C4D9A0
        public void set_displayWarnings(){} // RVA: 0x1C4DB10
        public void OnEnable(){} // RVA: 0x7E03EE0
        public void OnDestroy(){} // RVA: 0x7E040D0
        public void InitializeFontReferenceLookup(){} // RVA: 0x7E04140
        public void GetCachedFontAsset(){} // RVA: 0x7E04540
        public void GetOSFontAssetList(){} // RVA: 0x7E04930
        public void CreateNativeObject(){} // RVA: 0x7E049D0
        public void DestroyNativeObject(){} // RVA: 0x7E04AA0
        public void UpdateFallbacks(){} // RVA: 0x7E04AF0
        public void get_nativeTextSettings(){} // RVA: 0x7E04BD0
        public void GetGlobalFallbacks(){} // RVA: 0x7E04BF0
        public void UpdateNativeTextSettings(){} // RVA: 0x7E04E50
        public void .ctor(){} // RVA: 0x7E05050
        public void CreateNativeObject_Injected(){} // RVA: 0x7E05310
        public void UpdateFallbacks_Injected(){} // RVA: 0x7E05360
    }

    public class TextShaderUtilities : Object
    {
        public object ID_MainTex;
        public object ID_FaceTex;
        public object ID_FaceColor;
        public object ID_FaceDilate;
        public object ID_Shininess;
        public object ID_OutlineOffset1;
        public object ID_OutlineOffset2;
        public object ID_OutlineOffset3;
        public object ID_OutlineMode;
        public object ID_IsoPerimeter;
        public object ID_Softness;
        public object ID_UnderlayColor;
        public object ID_UnderlayOffsetX;
        public object ID_UnderlayOffsetY;
        public object ID_UnderlayDilate;
        public object ID_UnderlaySoftness;
        public object ID_UnderlayOffset;
        public object ID_UnderlayIsoPerimeter;
        public object ID_WeightNormal;
        public object ID_WeightBold;
        public object ID_OutlineTex;
        public object ID_OutlineWidth;
        public object ID_OutlineSoftness;
        public object ID_OutlineColor;
        public object ID_Outline2Color;
        public object ID_Outline2Width;
        public object ID_Padding;
        public object ID_GradientScale;
        public object ID_ScaleX;
        public object ID_ScaleY;
        public object ID_PerspectiveFilter;
        public object ID_Sharpness;
        public object ID_TextureWidth;
        public object ID_TextureHeight;
        public object ID_BevelAmount;
        public object ID_GlowColor;
        public object ID_GlowOffset;
        public object ID_GlowPower;
        public object ID_GlowOuter;
        public object ID_GlowInner;
        public object ID_LightAngle;
        public object ID_EnvMap;
        public object ID_EnvMatrix;
        public object ID_EnvMatrixRotation;
        public object ID_MaskCoord;
        public object ID_ClipRect;
        public object ID_MaskSoftnessX;
        public object ID_MaskSoftnessY;
        public object ID_VertexOffsetX;
        public object ID_VertexOffsetY;
        public object ID_UseClipRect;
        public object ID_StencilID;
        public object ID_StencilOp;
        public object ID_StencilComp;
        public object ID_StencilReadMask;
        public object ID_StencilWriteMask;
        public object ID_ShaderFlags;
        public object ID_ScaleRatio_A;
        public object ID_ScaleRatio_B;
        public object ID_ScaleRatio_C;
        public object Keyword_Bevel;
        public object Keyword_Glow;
        public object Keyword_Underlay;
        public object Keyword_Ratios;
        public object Keyword_MASK_SOFT;
        public object Keyword_MASK_HARD;
        public object Keyword_MASK_TEX;
        public object Keyword_Outline;
        public object ShaderTag_ZTestMode;
        public object ShaderTag_CullMode;
        public object m_clamp;
        public object isInitialized;
        public object k_SDFText;
        public object k_BitmapText;
        public object k_SpriteText;
        public object k_ShaderRef_MobileSDF;
        public object k_ShaderRef_MobileBitmap;
        public object k_ShaderRef_Sprite;

        // ── Methods ──
        public void get_ShaderRef_MobileSDF(){} // RVA: 0x7E1B630
        public void get_ShaderRef_MobileBitmap(){} // RVA: 0x7E1B770
        public void get_ShaderRef_Sprite(){} // RVA: 0x7E1B940
        public void .cctor(){} // RVA: 0x7E1BC80
        public void GetShaderPropertyIDs(){} // RVA: 0x7E1C440
    }

    public class TextStyle : Object
    {
        public object k_NormalStyle;
        public object m_Name;
        public object m_HashCode;
        public object m_OpeningDefinition;
        public object m_ClosingDefinition;
        public object m_OpeningTagArray;
        public object m_ClosingTagArray;
        public object m_OpeningTagUnicodeArray;
        public object m_ClosingTagUnicodeArray;

        // ── Methods ──
        public void get_hashCode(){} // RVA: 0x47FDFF0
        public void get_styleOpeningTagArray(){} // RVA: 0x7C24F60
        public void get_styleClosingTagArray(){} // RVA: 0x7C7DF30
        public void .ctor(){} // RVA: 0x7E05950
        public void RefreshStyle(){} // RVA: 0x7E05AB0
    }

    public class TextStyleSheet : ScriptableObject
    {
        public object m_StyleList;
        public object m_StyleLookupDictionary;
        public object styleLookupLock;

        // ── Methods ──
        public void get_styles(){} // RVA: 0x3926770
        public void Reset(){} // RVA: 0x7E05E00
        public void GetStyle(){} // RVA: 0x7E05FB0
        public void RefreshStyles(){} // RVA: 0x7E05E00
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7E06050
        public void .ctor(){} // RVA: 0x7E06540
    }

    public class TextStyle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TextUtilities : Object
    {
        // ── Methods ──
        public void ToUpperFast(){} // RVA: 0x7E1D060
        public void GetHashCodeCaseInSensitive(){} // RVA: 0x7E1D0D0
        public void GetTextFontWeightIndex(){} // RVA: 0x7E1D1B0
    }

    public class UnicodeLineBreakingRules : Object
    {
        public object m_UnicodeLineBreakingRules;
        public object m_LeadingCharacters;
        public object m_FollowingCharacters;
        public object m_UseModernHangulLineBreakingRules;
        public object m_LeadingCharactersLookup;
        public object m_FollowingCharactersLookup;

        // ── Methods ──
        public void get_leadingCharactersLookup(){} // RVA: 0x7E1D240
        public void get_followingCharactersLookup(){} // RVA: 0x7E1D270
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0xF73960
        public void LoadLineBreakingRules(){} // RVA: 0x7E1D2A0
        public void GetCharacters(){} // RVA: 0x7E1D750
        public void .ctor(){} // RVA: 0xB43310
    }

}