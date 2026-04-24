// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.Text
// Classes: 9
// Methods: 273

namespace ThirdParty.Unity.UnityEngine.TextCore.Text
{
    public class FontAsset : TextAsset
    {
        public string fontAssetCreationEditorSettings; // 0x38
        public SessionKey.ssetFile_DeleteByName sourceFontFile; // 0x40
        public IsWithinBudget atlasPopulationMode; // 0x98
        public string faceInfo; // 0xA0
        public SessionKey.uManager familyNameHashCode; // 0xA8
        public bool styleNameHashCode; // 0xAC
        public e.ToInstance glyphTable; // 0xB0
        public int glyphLookupTable; // 0x110
        public int characterTable; // 0x114
        public URA.woDigitYearMax<e.ypeHash> characterLookupTable; // 0x118
        public URA.DateTime<uint,e.ypeHash> atlasTexture; // 0x120
        public URA.woDigitYearMax<SessionKey.ag> atlasTextures; // 0x128
        public URA.DateTime<uint,SessionKey.ag> atlasTextureCount; // 0x130
        public ector isMultiAtlasTexturesEnabled; // 0x138
        public ector[] clearDynamicDataOnBuild; // 0x140
        public int atlasWidth; // 0x148
        public bool atlasHeight; // 0x14C
        public bool atlasPadding; // 0x14D
        public int atlasRenderMode; // 0x150
        public int usedGlyphRects; // 0x154
        public int freeGlyphRects; // 0x158
        public tPackageJObject.izablePackage fontFeatureTable; // 0x15C
        public URA.woDigitYearMax<e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d> fallbackFontAssetTable; // 0x160
        public URA.woDigitYearMax<e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d> fontWeightTable; // 0x168
        public SessionKey.chSession regularStyleWeight; // 0x170
        public URA.woDigitYearMax<SessionKey.ownloadById> regularStyleSpacing; // 0x178
        public SessionKey.le_DeleteById[] boldStyleWeight; // 0x180
        public float boldStyleSpacing; // 0x188
        public float italicStyleSlant; // 0x18C
        public float tabMultiple; // 0x190
        public float m_BoldStyleSpacing; // 0x194
        public byte m_ItalicStyleSlant; // 0x198
        public byte m_TabMultiple; // 0x199
        public bool IsFontAssetLookupTablesDirty; // 0x19A
        public object k_ReadFontAssetDefinitionMarker;
        public object k_AddSynthesizedCharactersMarker; // 0x8
        public object k_TryAddCharacterMarker; // 0x10
        public object k_TryAddCharactersMarker; // 0x18
        public object k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
        public object k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x28
        public object k_ClearFontAssetDataMarker; // 0x30
        public object k_UpdateFontAssetDataMarker; // 0x38
        public object k_TryAddGlyphMarker; // 0x40
        public string s_DefaultMaterialSuffix; // 0x48
        public URA.onsDepth<int> k_SearchedFontAssetLookup; // 0x50
        public URA.woDigitYearMax<SessionKey.ownloadById> k_FontAssets_FontFeaturesUpdateQueue; // 0x58
        public URA.onsDepth<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x60
        public URA.woDigitYearMax<ector> k_FontAssets_AtlasTexturesUpdateQueue; // 0x68
        public URA.onsDepth<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x70
        public URA.woDigitYearMax<e.ypeHash> m_GlyphsToRender; // 0x1A0
        public URA.woDigitYearMax<e.ypeHash> m_GlyphsRendered; // 0x1A8
        public URA.woDigitYearMax<uint> m_GlyphIndexList; // 0x1B0
        public URA.woDigitYearMax<uint> m_GlyphIndexListNewlyAdded; // 0x1B8
        public URA.woDigitYearMax<uint> m_GlyphsToAdd; // 0x1C0
        public URA.onsDepth<uint> m_GlyphsToAddLookup; // 0x1C8
        public URA.woDigitYearMax<SessionKey.ag> m_CharactersToAdd; // 0x1D0
        public URA.onsDepth<uint> m_CharactersToAddLookup; // 0x1D8
        public URA.woDigitYearMax<uint> s_MissingCharacterList; // 0x1E0
        public URA.onsDepth<uint> m_MissingUnicodesFromFontFile; // 0x1E8
        public uint[] k_GlyphIndexArray; // 0x78

        // ── Methods ──
        public void get_fontAssetCreationEditorSettings(){} // RVA: 0x7FFD54E1D820
        public void set_fontAssetCreationEditorSettings(){} // RVA: 0x7FFD54E1D860
        public void get_sourceFontFile(){} // RVA: 0x7FFD54D3FCC0
        public void set_sourceFontFile(){} // RVA: 0x7FFD4E96E3C0
        public void get_atlasPopulationMode(){} // RVA: 0x7FFD54E1D8F0
        public void set_atlasPopulationMode(){} // RVA: 0x7FFD4ED1D010
        public void get_faceInfo(){} // RVA: 0x7FFD54E1D900
        public void set_faceInfo(){} // RVA: 0x7FFD54E1D950
        public void get_familyNameHashCode(){} // RVA: 0x7FFD54E1D9E0
        public void set_familyNameHashCode(){} // RVA: 0x7FFD4F9B7C80
        public void get_styleNameHashCode(){} // RVA: 0x7FFD54E1DA20
        public void set_styleNameHashCode(){} // RVA: 0x7FFD54B65520
        public void get_glyphTable(){} // RVA: 0x7FFD54E1DA60
        public void set_glyphTable(){} // RVA: 0x7FFD4E7D8580
        public void get_glyphLookupTable(){} // RVA: 0x7FFD54E1DA70
        public void get_characterTable(){} // RVA: 0x7FFD54E1DAB0
        public void set_characterTable(){} // RVA: 0x7FFD4EDE51C0
        public void get_characterLookupTable(){} // RVA: 0x7FFD54E1DAC0
        public void get_atlasTexture(){} // RVA: 0x7FFD54E1DB00
        public void get_atlasTextures(){} // RVA: 0x7FFD54E1DC50
        public void set_atlasTextures(){} // RVA: 0x7FFD4E3AC600
        public void get_atlasTextureCount(){} // RVA: 0x7FFD54E1DC60
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFD54E1DC70
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFD54E1DC80
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFD54E1DC90
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFD54E1DCA0
        public void get_atlasWidth(){} // RVA: 0x7FFD54E1DCB0
        public void set_atlasWidth(){} // RVA: 0x7FFD4F0AEC20
        public void get_atlasHeight(){} // RVA: 0x7FFD54E1DCC0
        public void set_atlasHeight(){} // RVA: 0x7FFD53F5EA00
        public void get_atlasPadding(){} // RVA: 0x7FFD54E1DCD0
        public void set_atlasPadding(){} // RVA: 0x7FFD54E1DCE0
        public void get_atlasRenderMode(){} // RVA: 0x7FFD54E1DCF0
        public void set_atlasRenderMode(){} // RVA: 0x7FFD54E1DD00
        public void get_usedGlyphRects(){} // RVA: 0x7FFD54E1DD10
        public void set_usedGlyphRects(){} // RVA: 0x7FFD4E7CFA60
        public void get_freeGlyphRects(){} // RVA: 0x7FFD54E1DD20
        public void set_freeGlyphRects(){} // RVA: 0x7FFD4EDC80B0
        public void get_fontFeatureTable(){} // RVA: 0x7FFD54E1DD30
        public void set_fontFeatureTable(){} // RVA: 0x7FFD4EDD5DB0
        public void get_fallbackFontAssetTable(){} // RVA: 0x7FFD54E1DD40
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFD4EDEA130
        public void get_fontWeightTable(){} // RVA: 0x7FFD54E1DD50
        public void set_fontWeightTable(){} // RVA: 0x7FFD4E923070
        public void get_regularStyleWeight(){} // RVA: 0x7FFD54E1DD60
        public void set_regularStyleWeight(){} // RVA: 0x7FFD54E1DD70
        public void get_regularStyleSpacing(){} // RVA: 0x7FFD54E1DD80
        public void set_regularStyleSpacing(){} // RVA: 0x7FFD54E1DD90
        public void get_boldStyleWeight(){} // RVA: 0x7FFD54E1DDA0
        public void set_boldStyleWeight(){} // RVA: 0x7FFD54E1DDB0
        public void get_boldStyleSpacing(){} // RVA: 0x7FFD54E1DDC0
        public void set_boldStyleSpacing(){} // RVA: 0x7FFD54E1DDD0
        public void get_italicStyleSlant(){} // RVA: 0x7FFD54E1DDE0
        public void set_italicStyleSlant(){} // RVA: 0x7FFD53F5EC00
        public void get_tabMultiple(){} // RVA: 0x7FFD54E1DDF0
        public void set_tabMultiple(){} // RVA: 0x7FFD54064910
        public void CreateFontAsset(){} // RVA: 0x7FFD54E1E480 | overloaded x6
        public void CreateFontAssetInstance(){} // RVA: 0x7FFD54E1E6B0
        public void Awake(){} // RVA: 0x7FFD4E341310
        public void OnDestroy(){} // RVA: 0x7FFD54E1F010
        public void ReadFontAssetDefinition(){} // RVA: 0x7FFD54E1F1B0
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7FFD54E1F5D0
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7FFD54E1F620
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7FFD54E1F9C0
        public void InitializeLigatureSubstitutionLookupDictionary(){} // RVA: 0x7FFD54E1FC30
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFD54E1FFB0
        public void InitializeMarkToBaseAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFD54E202B0
        public void InitializeMarkToMarkAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFD54E205D0
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7FFD54E208F0
        public void AddSynthesizedCharacter(){} // RVA: 0x7FFD54E20B00
        public void AddCharacterToLookupCache(){} // RVA: 0x7FFD54E20DE0
        public void LoadFontFace(){} // RVA: 0x7FFD54E20E70
        public void SortCharacterTable(){} // RVA: 0x7FFD54E21030
        public void SortGlyphTable(){} // RVA: 0x7FFD54E212D0
        public void SortFontFeatureTable(){} // RVA: 0x7FFD54E21570
        public void SortAllTables(){} // RVA: 0x7FFD54E215C0
        public void HasCharacter(){} // RVA: 0x7FFD54E216C0 | overloaded x3
        public void HasCharacter_Internal(){} // RVA: 0x7FFD54E21B50
        public void HasCharacters(){} // RVA: 0x7FFD54E226F0 | overloaded x3
        public void GetCharacters(){} // RVA: 0x7FFD54E227C0
        public void GetCharactersArray(){} // RVA: 0x7FFD54E22950
        public void GetGlyphIndex(){} // RVA: 0x7FFD54E22A30
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7FFD54E22B70
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7FFD54E22CD0
        public void RegisterAtlasTextureForApply(){} // RVA: 0x7FFD54E22F10
        public void UpdateAtlasTexturesInQueue(){} // RVA: 0x7FFD54E23010
        public void UpdateFontAssetsInUpdateQueue(){} // RVA: 0x7FFD54E23210
        public void TryAddCharacters(){} // RVA: 0x7FFD54E24170 | overloaded x4
        public void TryAddGlyphInternal(){} // RVA: 0x7FFD54E250B0
        public void TryAddCharacterInternal(){} // RVA: 0x7FFD54E25990
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x7FFD54E26440
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x7FFD4E341310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7FFD54E26920
        public void SetupNewAtlasTexture(){} // RVA: 0x7FFD54E26DF0
        public void UpdateAllFontFeatures(){} // RVA: 0x7FFD54E27100
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7FFD4E341310 | overloaded x4
        public void CopyListDataToArray(){} // RVA: 0x7FFD4E099B30
        public void ClearFontAssetData(){} // RVA: 0x7FFD54E279E0
        public void ClearFontAssetDataInternal(){} // RVA: 0x7FFD54E27B00
        public void UpdateFontAssetData(){} // RVA: 0x7FFD54E27B30
        public void ClearFontAssetTables(){} // RVA: 0x7FFD54E27D70
        public void ClearAtlasTextures(){} // RVA: 0x7FFD54E28080
        public void DestroyAtlasTextures(){} // RVA: 0x7FFD54E28420
        public void .ctor(){} // RVA: 0x7FFD54E28580
        public void .cctor(){} // RVA: 0x7FFD54E28CC0
    }

    public class SpriteAsset : TextAsset
    {
        public URA.DateTime<int,int> faceInfo; // 0x38
        public URA.DateTime<uint,int> spriteSheet; // 0x40
        public e.ToInstance spriteCharacterTable; // 0x48
        public ÎÎÏÏÍÎÎÍÏÍÌ>k__BackingField spriteCharacterLookupTable; // 0xA8
        public URA.woDigitYearMax<SessionKey.nsecure> spriteGlyphTable; // 0xB0
        public URA.DateTime<uint,SessionKey.nsecure> m_SpriteCharacterLookup; // 0xB8
        public URA.woDigitYearMax<SessionKey.ing_StartMatch> m_SpriteGlyphTable; // 0xC0
        public URA.DateTime<uint,SessionKey.ing_StartMatch> m_SpriteGlyphLookup; // 0xC8
        public URA.woDigitYearMax<SessionKey.hmaking_EnqueueRoom2> fallbackSpriteAssets; // 0xD0
        public bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
        public URA.onsDepth<int> k_searchedSpriteAssets;

        // ── Methods ──
        public void get_faceInfo(){} // RVA: 0x7FFD54E2FC10
        public void set_faceInfo(){} // RVA: 0x7FFD54BB6FD0
        public void get_spriteSheet(){} // RVA: 0x7FFD54D3FDA0
        public void set_spriteSheet(){} // RVA: 0x7FFD4E76B370
        public void get_spriteCharacterTable(){} // RVA: 0x7FFD54E2FC50
        public void set_spriteCharacterTable(){} // RVA: 0x7FFD4E3AC050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7FFD54E2FC90
        public void set_spriteCharacterLookupTable(){} // RVA: 0x7FFD4E3AC0C0
        public void get_spriteGlyphTable(){} // RVA: 0x7FFD54D3FEF0
        public void set_spriteGlyphTable(){} // RVA: 0x7FFD4E3AC130
        public void Awake(){} // RVA: 0x7FFD4E341310
        public void UpdateLookupTables(){} // RVA: 0x7FFD54E2FCD0
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7FFD54E30470
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7FFD54E30520
        public void GetSpriteIndexFromName(){} // RVA: 0x7FFD54E305C0
        public void SearchForSpriteByUnicode(){} // RVA: 0x7FFD54E30600
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7FFD54E30B10 | overloaded x2
        public void SearchForSpriteByHashCode(){} // RVA: 0x7FFD54E30BD0
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7FFD54E313D0 | overloaded x2
        public void SortGlyphTable(){} // RVA: 0x7FFD54E31490
        public void SortCharacterTable(){} // RVA: 0x7FFD54E31730
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7FFD54E319D0
        public void .ctor(){} // RVA: 0x7FFD54E319F0
    }

    public class TextAsset : ScriptableObject
    {
        public string version; // 0x18
        public int instanceID; // 0x20
        public int hashCode; // 0x24
        public atrix_Injected material; // 0x28
        public int materialHashCode; // 0x30

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFD50CC1130
        public void set_version(){} // RVA: 0x7FFD4E3A7E80
        public void get_instanceID(){} // RVA: 0x7FFD54E31C10
        public void get_hashCode(){} // RVA: 0x7FFD54E31C40
        public void set_hashCode(){} // RVA: 0x7FFD4F5874D0
        public void get_material(){} // RVA: 0x7FFD4E36F130
        public void set_material(){} // RVA: 0x7FFD4E342E90
        public void get_materialHashCode(){} // RVA: 0x7FFD54E31C80
        public void set_materialHashCode(){} // RVA: 0x7FFD4E39CCE0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class TextColorGradient : ScriptableObject
    {
        public SessionKey.cationArrayPage colorMode; // 0x18
        public object topLeft; // 0x1C
        public object topRight; // 0x2C
        public object bottomLeft; // 0x3C
        public object bottomRight; // 0x4C
        public SessionKey.cationArrayPage k_DefaultColorMode;
        public object k_DefaultColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B5A5B0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD54E31E50
    }

    public class TextGeneratorUtilities : Object
    {
        public tionX largePositiveVector2;
        public tionX largeNegativeVector2; // 0x8

        // ── Methods ──
        public void Approximately(){} // RVA: 0x7FFD54E5A440
        public void HexCharsToColor(){} // RVA: 0x7FFD54E5AB00 | overloaded x2
        public void HexToInt(){} // RVA: 0x7FFD54E5AD90
        public void ConvertToFloat(){} // RVA: 0x7FFD54E5AF20 | overloaded x2
        public void PackUV(){} // RVA: 0x7FFD54E5B080
        public void ResizeInternalArray(){} // RVA: 0x7FFD4E096370 | overloaded x2
        public void InsertOpeningTextStyle(){} // RVA: 0x7FFD54E5B0C0
        public void InsertClosingTextStyle(){} // RVA: 0x7FFD54E5B1C0
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7FFD54E5B4C0 | overloaded x2
        public void ReplaceClosingStyleTag(){} // RVA: 0x7FFD54E5B6C0
        public void InsertOpeningStyleTag(){} // RVA: 0x7FFD54E5B7F0
        public void InsertClosingStyleTag(){} // RVA: 0x7FFD54E5B8F0
        public void InsertTextStyleInTextProcessingArray(){} // RVA: 0x7FFD54E5B9F0
        public void GetStyle(){} // RVA: 0x7FFD54E5BEA0
        public void GetStyleHashCode(){} // RVA: 0x7FFD54E5C150 | overloaded x2
        public void GetUTF16(){} // RVA: 0x7FFD54E5C330 | overloaded x2
        public void GetUTF32(){} // RVA: 0x7FFD54E5C590 | overloaded x2
        public void FillCharacterVertexBuffers(){} // RVA: 0x7FFD54E5C740
        public void FillSpriteVertexBuffers(){} // RVA: 0x7FFD54E5D310
        public void AdjustLineOffset(){} // RVA: 0x7FFD54E5DDF0
        public void ResizeLineExtents(){} // RVA: 0x7FFD54E5E1C0
        public void LegacyStyleToNewStyle(){} // RVA: 0x7FFD54E5E470
        public void LegacyAlignmentToNewAlignment(){} // RVA: 0x7FFD54E5E4A0
        public void ConvertToUTF32(){} // RVA: 0x7FFD54E5E520
        public void GetMarkupTagHashCode(){} // RVA: 0x7FFD54E5E600 | overloaded x2
        public void ToUpperASCIIFast(){} // RVA: 0x7FFD54E5E730 | overloaded x2
        public void ToUpperFast(){} // RVA: 0x7FFD54E5E7A0
        public void GetAttributeParameters(){} // RVA: 0x7FFD54E5E810
        public void IsBitmapRendering(){} // RVA: 0x7FFD54E5E8E0
        public void IsBaseGlyph(){} // RVA: 0x7FFD54E5E910
        public void MinAlpha(){} // RVA: 0x7FFD54E5EA20
        public void GammaToLinear(){} // RVA: 0x7FFD54E5EB00 | overloaded x2
        public void IsValidUTF16(){} // RVA: 0x7FFD54E5EBB0
        public void IsValidUTF32(){} // RVA: 0x7FFD54E5EC30
        public void IsHangul(){} // RVA: 0x7FFD54E5ECB0
        public void IsCJK(){} // RVA: 0x7FFD54E5ED10
        public void .cctor(){} // RVA: 0x7FFD54E5EDD0
    }

    public class TextInfo : Object
    {
        public tionX s_InfinityVectorPositive;
        public tionX s_InfinityVectorNegative; // 0x8
        public int characterCount; // 0x10
        public int spriteCount; // 0x14
        public int spaceCount; // 0x18
        public int wordCount; // 0x1C
        public int linkCount; // 0x20
        public int lineCount; // 0x24
        public int pageCount; // 0x28
        public int materialCount; // 0x2C
        public SessionKey.ification_MarkAsRead[] textElementInfo; // 0x30
        public SessionKey.sageWithCloudStorageUpdateResponse[] wordInfo; // 0x38
        public SessionKey.EnqueueRoom[] linkInfo; // 0x40
        public SessionKey.lidation[] lineInfo; // 0x48
        public SessionKey.lementDecl[] pageInfo; // 0x50
        public SessionKey._Enqueue[] meshInfo; // 0x58
        public bool isDirty; // 0x60
        public bool hasMultipleColors; // 0x61

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54E624D0
        public void Clear(){} // RVA: 0x7FFD54E627B0
        public void ClearMeshInfo(){} // RVA: 0x7FFD54E62830
        public void ClearLineInfo(){} // RVA: 0x7FFD54E62900
        public void ClearPageInfo(){} // RVA: 0x7FFD54E62C50
        public void Resize(){} // RVA: 0x7FFD4E097A00 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54E62DC0
    }

    public class TextProcessingStack`1 : ValueType
    {
        public T1717704224[] Count;
        public int current;
        public T1717704224 m_DefaultItem;
        public int m_Capacity;
        public int m_RolloverSize;
        public int m_Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092E60 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_current(){} // RVA: 0x7FFD4E2ADC40
        public void SetDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void Pop(){} // RVA: 0x7FFD4E2ADC40
        public void Peek(){} // RVA: 0x7FFD4E2ADC40
        public void CurrentItem(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TextSettings : ScriptableObject
    {
        public string version; // 0x18
        public SessionKey.ownloadById defaultFontAsset; // 0x20
        public string defaultFontAssetPath; // 0x28
        public URA.woDigitYearMax<SessionKey.ownloadById> fallbackFontAssets; // 0x30
        public bool matchMaterialPreset; // 0x38
        public int missingCharacterUnicode; // 0x3C
        public bool clearDynamicDataOnBuild; // 0x40
        public SessionKey.hmaking_EnqueueRoom2 defaultSpriteAsset; // 0x48
        public string defaultSpriteAssetPath; // 0x50
        public URA.woDigitYearMax<SessionKey.hmaking_EnqueueRoom2> fallbackSpriteAssets; // 0x58
        public uint missingSpriteCharacterUnicode; // 0x60
        public SessionKey.geWithShareMediaResult defaultStyleSheet; // 0x68
        public string styleSheetsResourcePath; // 0x70
        public string defaultColorGradientPresetsPath; // 0x78
        public SessionKey.essageWithSystemVoipState lineBreakingRules; // 0x80
        public bool useModernHangulLineBreakingRules; // 0x88
        public bool displayWarnings; // 0x89
        public URA.DateTime<int,SessionKey.ownloadById> m_FontLookup; // 0x90
        public URA.woDigitYearMax<ithRoomList> m_FontReferences; // 0x98

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFD4E3447C0
        public void set_version(){} // RVA: 0x7FFD4E3A7E80
        public void get_defaultFontAsset(){} // RVA: 0x7FFD4E36F0C0
        public void set_defaultFontAsset(){} // RVA: 0x7FFD4E36F0D0
        public void get_defaultFontAssetPath(){} // RVA: 0x7FFD4E36F130
        public void set_defaultFontAssetPath(){} // RVA: 0x7FFD4E342E90
        public void get_fallbackFontAssets(){} // RVA: 0x7FFD4E5F95E0
        public void set_fallbackFontAssets(){} // RVA: 0x7FFD4E36F890
        public void get_matchMaterialPreset(){} // RVA: 0x7FFD4E5F95D0
        public void set_matchMaterialPreset(){} // RVA: 0x7FFD4E5F95C0
        public void get_missingCharacterUnicode(){} // RVA: 0x7FFD4E7DD4A0
        public void set_missingCharacterUnicode(){} // RVA: 0x7FFD4FC02CD0
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFD4E3FCC00
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFD4E3FCC10
        public void get_defaultSpriteAsset(){} // RVA: 0x7FFD4E3BC730
        public void set_defaultSpriteAsset(){} // RVA: 0x7FFD4E3BC740
        public void get_defaultSpriteAssetPath(){} // RVA: 0x7FFD4E3E20E0
        public void set_defaultSpriteAssetPath(){} // RVA: 0x7FFD4E4994D0
        public void get_fallbackSpriteAssets(){} // RVA: 0x7FFD4E409500
        public void set_fallbackSpriteAssets(){} // RVA: 0x7FFD4E409510
        public void get_missingSpriteCharacterUnicode(){} // RVA: 0x7FFD4E558C20
        public void set_missingSpriteCharacterUnicode(){} // RVA: 0x7FFD4E558C10
        public void get_defaultStyleSheet(){} // RVA: 0x7FFD4E3BCD50
        public void set_defaultStyleSheet(){} // RVA: 0x7FFD4E3BCD60
        public void get_styleSheetsResourcePath(){} // RVA: 0x7FFD4E409590
        public void set_styleSheetsResourcePath(){} // RVA: 0x7FFD4E4095A0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x7FFD4E505600
        public void set_defaultColorGradientPresetsPath(){} // RVA: 0x7FFD4E5006F0
        public void get_lineBreakingRules(){} // RVA: 0x7FFD54E63D30
        public void set_lineBreakingRules(){} // RVA: 0x7FFD4E8F4AA0
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFD54E63DF0
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x7FFD4F22C170
        public void get_displayWarnings(){} // RVA: 0x7FFD4F224950
        public void set_displayWarnings(){} // RVA: 0x7FFD4F229570
        public void OnEnable(){} // RVA: 0x7FFD54E63E00
        public void InitializeFontReferenceLookup(){} // RVA: 0x7FFD54E63E30
        public void GetCachedFontAssetInternal(){} // RVA: 0x7FFD54E64220
        public void .ctor(){} // RVA: 0x7FFD54E64690
    }

    public class TextStyleSheet : ScriptableObject
    {
        public URA.woDigitYearMax<SessionKey.sult> styles; // 0x18
        public URA.DateTime<int,SessionKey.sult> m_StyleLookupDictionary; // 0x20

        // ── Methods ──
        public void get_styles(){} // RVA: 0x7FFD50CC1130
        public void Reset(){} // RVA: 0x7FFD54E677C0
        public void GetStyle(){} // RVA: 0x7FFD54E67860 | overloaded x2
        public void RefreshStyles(){} // RVA: 0x7FFD54E677C0
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7FFD54E67900
        public void .ctor(){} // RVA: 0x7FFD54E67E00
    }

}