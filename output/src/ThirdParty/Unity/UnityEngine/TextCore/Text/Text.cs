// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.Text
// Classes: 45
// Methods: 451

namespace ThirdParty.Unity.UnityEngine.TextCore.Text
{
    public class Character : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87AE21F0 | overloaded x3
    }

    public class CharacterSubstitution : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8164E250
    }

    public class ColorUtilities : Object
    {
        // ── Methods ──
        public void CompareColors(){} // RVA: 0x7FFE87DA5FA0
        public void MultiplyColors(){} // RVA: 0x7FFE87DA5FE0
    }

    public class Extents : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE87DB4350
    }

    public class FontAsset : TextAsset
    {
        public string m_SourceFontFileGUID; // 0x38
        public UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
        public UnityEngine.Font m_SourceFontFile; // 0x98
        public string m_SourceFontFilePath; // 0xA0
        public 0x666554B4 m_AtlasPopulationMode; // 0xA8
        public bool InternalDynamicOS; // 0xAC
        public UnityEngine.TextCore.FaceInfo m_FaceInfo; // 0xB0
        public int m_FamilyNameHashCode; // 0x110
        public int m_StyleNameHashCode; // 0x114
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> m_GlyphTable; // 0x118
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary; // 0x120
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character> m_CharacterTable; // 0x128
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Text.Character> m_CharacterLookupDictionary; // 0x130
        public UnityEngine.Texture2D m_AtlasTexture; // 0x138
        public UnityEngine.Texture2D[] m_AtlasTextures; // 0x140
        public int m_AtlasTextureIndex; // 0x148
        public bool m_IsMultiAtlasTexturesEnabled; // 0x14C
        public bool m_ClearDynamicDataOnBuild; // 0x14D
        public int m_AtlasWidth; // 0x150
        public int m_AtlasHeight; // 0x154
        public int m_AtlasPadding; // 0x158
        public 0x666CCF0C m_AtlasRenderMode; // 0x15C
        public System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects; // 0x160
        public System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects; // 0x168
        public UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable; // 0x170
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable; // 0x178
        public UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable; // 0x180
        public float m_RegularStyleWeight; // 0x188
        public float m_RegularStyleSpacing; // 0x18C
        public float m_BoldStyleWeight; // 0x190

        // ── Methods ──
        public void get_fontAssetCreationEditorSettings(){} // RVA: 0x7FFE87DA60C0
        public void set_fontAssetCreationEditorSettings(){} // RVA: 0x7FFE87DA6100
        public void get_sourceFontFile(){} // RVA: 0x7FFE87CC8560
        public void set_sourceFontFile(){} // RVA: 0x7FFE8171B470
        public void get_atlasPopulationMode(){} // RVA: 0x7FFE87DA6190
        public void set_atlasPopulationMode(){} // RVA: 0x7FFE81A34770
        public void get_faceInfo(){} // RVA: 0x7FFE87DA61A0
        public void set_faceInfo(){} // RVA: 0x7FFE87DA61F0
        public void get_familyNameHashCode(){} // RVA: 0x7FFE87DA6280
        public void set_familyNameHashCode(){} // RVA: 0x7FFE82862FB0
        public void get_styleNameHashCode(){} // RVA: 0x7FFE87DA62C0
        public void set_styleNameHashCode(){} // RVA: 0x7FFE87AEDA90
        public void get_glyphTable(){} // RVA: 0x7FFE87DA6300
        public void set_glyphTable(){} // RVA: 0x7FFE81317920
        public void get_glyphLookupTable(){} // RVA: 0x7FFE87DA6310
        public void get_characterTable(){} // RVA: 0x7FFE87DA6350
        public void set_characterTable(){} // RVA: 0x7FFE81B31E10
        public void get_characterLookupTable(){} // RVA: 0x7FFE87DA6360
        public void get_atlasTexture(){} // RVA: 0x7FFE87DA63A0
        public void get_atlasTextures(){} // RVA: 0x7FFE87DA64F0
        public void set_atlasTextures(){} // RVA: 0x7FFE81166600
        public void get_atlasTextureCount(){} // RVA: 0x7FFE87DA6500
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFE87DA6510
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFE87DA6520
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFE87DA6530
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFE87DA6540
        public void get_atlasWidth(){} // RVA: 0x7FFE87DA6550
        public void set_atlasWidth(){} // RVA: 0x7FFE81F7F070
        public void get_atlasHeight(){} // RVA: 0x7FFE87DA6560
        public void set_atlasHeight(){} // RVA: 0x7FFE86EE8070
        public void get_atlasPadding(){} // RVA: 0x7FFE87DA6570
        public void set_atlasPadding(){} // RVA: 0x7FFE87DA6580
        public void get_atlasRenderMode(){} // RVA: 0x7FFE87DA6590
        public void set_atlasRenderMode(){} // RVA: 0x7FFE87DA65A0
        public void get_usedGlyphRects(){} // RVA: 0x7FFE87DA65B0
        public void set_usedGlyphRects(){} // RVA: 0x7FFE81625620
        public void get_freeGlyphRects(){} // RVA: 0x7FFE87DA65C0
        public void set_freeGlyphRects(){} // RVA: 0x7FFE81B23F80
        public void get_fontFeatureTable(){} // RVA: 0x7FFE87DA65D0
        public void set_fontFeatureTable(){} // RVA: 0x7FFE81B38790
        public void get_fallbackFontAssetTable(){} // RVA: 0x7FFE87DA65E0
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFE81B10700
        public void get_fontWeightTable(){} // RVA: 0x7FFE87DA65F0
        public void set_fontWeightTable(){} // RVA: 0x7FFE81B31180
        public void get_regularStyleWeight(){} // RVA: 0x7FFE87DA6600
        public void set_regularStyleWeight(){} // RVA: 0x7FFE87DA6610
        public void get_regularStyleSpacing(){} // RVA: 0x7FFE87DA6620
        public void set_regularStyleSpacing(){} // RVA: 0x7FFE87DA6630
        public void get_boldStyleWeight(){} // RVA: 0x7FFE87DA6640
        public void set_boldStyleWeight(){} // RVA: 0x7FFE87DA6650
        public void get_boldStyleSpacing(){} // RVA: 0x7FFE87DA6660
        public void set_boldStyleSpacing(){} // RVA: 0x7FFE87DA6670
        public void get_italicStyleSlant(){} // RVA: 0x7FFE87DA6680
        public void set_italicStyleSlant(){} // RVA: 0x7FFE86EE8270
        public void get_tabMultiple(){} // RVA: 0x7FFE87DA6690
        public void set_tabMultiple(){} // RVA: 0x7FFE86FECE30
        public void CreateFontAsset(){} // RVA: 0x7FFE87DA6D20 | overloaded x6
        public void CreateFontAssetInstance(){} // RVA: 0x7FFE87DA6F50
        public void Awake(){} // RVA: 0x7FFE810FB310
        public void OnDestroy(){} // RVA: 0x7FFE87DA78B0
        public void ReadFontAssetDefinition(){} // RVA: 0x7FFE87DA7A50
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7FFE87DA7E70
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7FFE87DA7EC0
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7FFE87DA8260
        public void InitializeLigatureSubstitutionLookupDictionary(){} // RVA: 0x7FFE87DA84D0
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFE87DA8850
        public void InitializeMarkToBaseAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFE87DA8B50
        public void InitializeMarkToMarkAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFE87DA8E70
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7FFE87DA9190
        public void AddSynthesizedCharacter(){} // RVA: 0x7FFE87DA93A0
        public void AddCharacterToLookupCache(){} // RVA: 0x7FFE87DA9680
        public void LoadFontFace(){} // RVA: 0x7FFE87DA9710
        public void SortCharacterTable(){} // RVA: 0x7FFE87DA98D0
        public void SortGlyphTable(){} // RVA: 0x7FFE87DA9B70
        public void SortFontFeatureTable(){} // RVA: 0x7FFE87DA9E10
        public void SortAllTables(){} // RVA: 0x7FFE87DA9E60
        public void HasCharacter(){} // RVA: 0x7FFE87DA9F60 | overloaded x3
        public void HasCharacter_Internal(){} // RVA: 0x7FFE87DAA3F0
        public void HasCharacters(){} // RVA: 0x7FFE87DAAF90 | overloaded x3
        public void GetCharacters(){} // RVA: 0x7FFE87DAB060
        public void GetCharactersArray(){} // RVA: 0x7FFE87DAB1F0
        public void GetGlyphIndex(){} // RVA: 0x7FFE87DAB2D0
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7FFE87DAB410
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7FFE87DAB570
        public void RegisterAtlasTextureForApply(){} // RVA: 0x7FFE87DAB7B0
        public void UpdateAtlasTexturesInQueue(){} // RVA: 0x7FFE87DAB8B0
        public void UpdateFontAssetsInUpdateQueue(){} // RVA: 0x7FFE87DABAB0
        public void TryAddCharacters(){} // RVA: 0x7FFE87DACA10 | overloaded x4
        public void TryAddGlyphInternal(){} // RVA: 0x7FFE87DAD950
        public void TryAddCharacterInternal(){} // RVA: 0x7FFE87DAE230
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x7FFE87DAECE0
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x7FFE810FB310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7FFE87DAF1C0
        public void SetupNewAtlasTexture(){} // RVA: 0x7FFE87DAF690
        public void UpdateAllFontFeatures(){} // RVA: 0x7FFE87DAF9A0
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7FFE810FB310 | overloaded x4
        public void CopyListDataToArray(){} // RVA: 0x7FFE80E4F230
        public void ClearFontAssetData(){} // RVA: 0x7FFE87DB0280
        public void ClearFontAssetDataInternal(){} // RVA: 0x7FFE87DB03A0
        public void UpdateFontAssetData(){} // RVA: 0x7FFE87DB03D0
        public void ClearFontAssetTables(){} // RVA: 0x7FFE87DB0610
        public void ClearAtlasTextures(){} // RVA: 0x7FFE87DB0920
        public void DestroyAtlasTextures(){} // RVA: 0x7FFE87DB0CC0
        public void .ctor(){} // RVA: 0x7FFE87DB0E20
        public void .cctor(){} // RVA: 0x7FFE87DB1560
    }

    public class FontAssetCreationEditorSettings : ValueType
    {
    }

    public class FontAssetUtilities : Object
    {
        // ── Methods ──
        public void GetCharacterFromFontAsset(){} // RVA: 0x7FFE87DB1DC0
        public void GetCharacterFromFontAsset_Internal(){} // RVA: 0x7FFE87DB1F30
        public void GetCharacterFromFontAssets(){} // RVA: 0x7FFE87DB2610
        public void GetSpriteCharacterFromSpriteAsset(){} // RVA: 0x7FFE87DB2890
        public void GetSpriteCharacterFromSpriteAsset_Internal(){} // RVA: 0x7FFE87DB2C70
    }

    public class FontFeatureTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DB2EE0
        public void SortGlyphPairAdjustmentRecords(){} // RVA: 0x7FFE87DB3380
        public void SortMarkToBaseAdjustmentRecords(){} // RVA: 0x7FFE87DB3880
        public void SortMarkToMarkAdjustmentRecords(){} // RVA: 0x7FFE87DB3D80
    }

    public class FontStyleStack : ValueType
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE87B4AB30
        public void Add(){} // RVA: 0x7FFE87DEB6D0
        public void Remove(){} // RVA: 0x7FFE87B4ABF0
    }

    public class FontWeightPair : ValueType
    {
    }

    public class HighlightState : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844572F0
        public void op_Equality(){} // RVA: 0x7FFE87DE2980
        public void op_Inequality(){} // RVA: 0x7FFE87DE2AC0
        public void GetHashCode(){} // RVA: 0x7FFE87DE2C10
        public void Equals(){} // RVA: 0x7FFE87DE2C70
    }

    public class LineInfo : ValueType
    {
    }

    public class LinkInfo : ValueType
    {
        // ── Methods ──
        public void SetLinkId(){} // RVA: 0x7FFE87DB4500
        public void GetLinkText(){} // RVA: 0x7FFE87DB46D0
        public void GetLinkId(){} // RVA: 0x7FFE87DB4880
    }

    public class MaterialManager : Object
    {
        // ── Methods ──
        public void GetFallbackMaterial(){} // RVA: 0x7FFE87DB4E60 | overloaded x2
        public void CopyMaterialPresetProperties(){} // RVA: 0x7FFE87DB5190
        public void .cctor(){} // RVA: 0x7FFE87DB5790
    }

    public class MaterialReference : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DB5870
        public void AddMaterialReference(){} // RVA: 0x7FFE87DB5DF0 | overloaded x2
    }

    public class MaterialReferenceManager : Object
    {
        public UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87DB6180
        public void AddFontAsset(){} // RVA: 0x7FFE87DB6260
        public void AddFontAssetInternal(){} // RVA: 0x7FFE87DB6290
        public void AddSpriteAsset(){} // RVA: 0x7FFE87DB64D0
        public void AddSpriteAssetInternal(){} // RVA: 0x7FFE87DB65F0
        public void AddFontMaterial(){} // RVA: 0x7FFE87DB6700
        public void AddFontMaterialInternal(){} // RVA: 0x7FFE87DB6790
        public void AddColorGradientPreset(){} // RVA: 0x7FFE87DB6820
        public void AddColorGradientPreset_Internal(){} // RVA: 0x7FFE87DB68F0
        public void TryGetFontAsset(){} // RVA: 0x7FFE87DB69B0
        public void TryGetFontAssetInternal(){} // RVA: 0x7FFE87DB6A70
        public void TryGetSpriteAsset(){} // RVA: 0x7FFE87DB6B20
        public void TryGetSpriteAssetInternal(){} // RVA: 0x7FFE87DB6BE0
        public void TryGetColorGradientPreset(){} // RVA: 0x7FFE87DB6C90
        public void TryGetColorGradientPresetInternal(){} // RVA: 0x7FFE87DB6D50
        public void TryGetMaterial(){} // RVA: 0x7FFE87DB6E00
        public void TryGetMaterialInternal(){} // RVA: 0x7FFE87DB6EC0
        public void .ctor(){} // RVA: 0x7FFE87DB6F70
    }

    public class MeshInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DB7200
        public void ResizeMeshInfo(){} // RVA: 0x7FFE87DB7900
        public void Clear(){} // RVA: 0x7FFE87DB7B20
        public void ClearUnusedVertices(){} // RVA: 0x7FFE87DB7B60
        public void SortGeometry(){} // RVA: 0x7FFE87DB7BA0
        public void SwapVertexData(){} // RVA: 0x7FFE87DB7C50
        public void .cctor(){} // RVA: 0x7FFE87DB8420
    }

    public class Offset : ValueType
    {
        public float m_Left; // 0x10
        public float m_Right; // 0x14
        public float m_Top; // 0x18
        public float m_Bottom; // 0x1C
        public UnityEngine.TextCore.Text.Offset k_ZeroOffset;

        // ── Methods ──
        public void get_left(){} // RVA: 0x7FFE8111ED20
        public void get_right(){} // RVA: 0x7FFE8111ED30
        public void get_top(){} // RVA: 0x7FFE8111ECF0
        public void get_bottom(){} // RVA: 0x7FFE8111ED00
        public void get_zero(){} // RVA: 0x7FFE87DE2800
        public void .ctor(){} // RVA: 0x7FFE8111F570
        public void op_Equality(){} // RVA: 0x7FFE87321FF0
        public void op_Multiply(){} // RVA: 0x7FFE87C51160
        public void GetHashCode(){} // RVA: 0x7FFE87DE2870
        public void Equals(){} // RVA: 0x7FFE87DE28D0
        public void .cctor(){} // RVA: 0x7FFE87DE2940
    }

    public class PageInfo : ValueType
    {
    }

    public class RichTextTagAttribute : ValueType
    {
    }

    public class SpriteAsset : TextAsset
    {
        public System.Collections.Generic.Dictionary`2<int,int> m_NameLookup; // 0x38
        public System.Collections.Generic.Dictionary`2<uint,int> m_GlyphIndexLookup; // 0x40
        public UnityEngine.TextCore.FaceInfo m_FaceInfo; // 0x48
        public UnityEngine.Texture m_SpriteAtlasTexture; // 0xA8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable; // 0xB0

        // ── Methods ──
        public void get_faceInfo(){} // RVA: 0x7FFE87DB84B0
        public void set_faceInfo(){} // RVA: 0x7FFE87B3F550
        public void get_spriteSheet(){} // RVA: 0x7FFE87CC8640
        public void set_spriteSheet(){} // RVA: 0x7FFE81857260
        public void get_spriteCharacterTable(){} // RVA: 0x7FFE87DB84F0
        public void set_spriteCharacterTable(){} // RVA: 0x7FFE81166050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7FFE87DB8530
        public void set_spriteCharacterLookupTable(){} // RVA: 0x7FFE811660C0
        public void get_spriteGlyphTable(){} // RVA: 0x7FFE87CC8790
        public void set_spriteGlyphTable(){} // RVA: 0x7FFE81166130
        public void Awake(){} // RVA: 0x7FFE810FB310
        public void UpdateLookupTables(){} // RVA: 0x7FFE87DB8570
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7FFE87DB8D10
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7FFE87DB8DC0
        public void GetSpriteIndexFromName(){} // RVA: 0x7FFE87DB8E60
        public void SearchForSpriteByUnicode(){} // RVA: 0x7FFE87DB8EA0
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7FFE87DB93B0 | overloaded x2
        public void SearchForSpriteByHashCode(){} // RVA: 0x7FFE87DB9470
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7FFE87DB9C70 | overloaded x2
        public void SortGlyphTable(){} // RVA: 0x7FFE87DB9D30
        public void SortCharacterTable(){} // RVA: 0x7FFE87DB9FD0
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7FFE87DBA270
        public void .ctor(){} // RVA: 0x7FFE87DBA290
    }

    public class SpriteCharacter : TextElement
    {
        public string m_Name; // 0x30

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE87C86B00
        public void .ctor(){} // RVA: 0x7FFE87B41F10
    }

    public class SpriteGlyph : Glyph
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B42150
    }

    public class TextAsset : ScriptableObject
    {
        public string m_Version; // 0x18
        public int m_InstanceID; // 0x20
        public int m_HashCode; // 0x24
        public UnityEngine.Material m_Material; // 0x28
        public int m_MaterialHashCode; // 0x30

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFE83BBC680
        public void set_version(){} // RVA: 0x7FFE81161E80
        public void get_instanceID(){} // RVA: 0x7FFE87DBA4B0
        public void get_hashCode(){} // RVA: 0x7FFE87DBA4E0
        public void set_hashCode(){} // RVA: 0x7FFE82447980
        public void get_material(){} // RVA: 0x7FFE81129130
        public void set_material(){} // RVA: 0x7FFE810FCE90
        public void get_materialHashCode(){} // RVA: 0x7FFE87DBA520
        public void set_materialHashCode(){} // RVA: 0x7FFE81156CE0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class TextBackingContainer : ValueType
    {
        public uint[] m_Array; // 0x10
        public int m_Count; // 0x18
        public object field_2; // 0xA830

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFE841BEA60
        public void get_Count(){} // RVA: 0x7FFE848C3400
        public void set_Count(){} // RVA: 0x7FFE82C33010
        public void get_Item(){} // RVA: 0x7FFE84121140
        public void set_Item(){} // RVA: 0x7FFE87DE2660
        public void .ctor(){} // RVA: 0x7FFE87DE26C0
        public void Resize(){} // RVA: 0x7FFE87DE2770
    }

    public class TextColorGradient : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87AE2B20 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87DBA6F0
    }

    public class TextElement : Object
    {
        public 0x66655BEC m_ElementType; // 0x10
        public uint m_Unicode; // 0x14
        public UnityEngine.TextCore.Text.TextAsset m_TextAsset; // 0x18
        public UnityEngine.TextCore.Glyph m_Glyph; // 0x20
        public uint m_GlyphIndex; // 0x28
        public float m_Scale; // 0x2C

        // ── Methods ──
        public void get_elementType(){} // RVA: 0x7FFE87CC79B0
        public void get_unicode(){} // RVA: 0x7FFE83BAF260
        public void set_unicode(){} // RVA: 0x7FFE8164E0F0
        public void get_textAsset(){} // RVA: 0x7FFE83BBC680
        public void set_textAsset(){} // RVA: 0x7FFE81161E80
        public void get_glyph(){} // RVA: 0x7FFE87563690
        public void set_glyph(){} // RVA: 0x7FFE811290D0
        public void get_glyphIndex(){} // RVA: 0x7FFE850164C0
        public void set_glyphIndex(){} // RVA: 0x7FFE817E4800
        public void get_scale(){} // RVA: 0x7FFE87CE83B0
        public void set_scale(){} // RVA: 0x7FFE81670820
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TextElementInfo : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE87DBA740
    }

    public class TextGenerationSettings : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87DBCE60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87DBCF70
        public void op_Equality(){} // RVA: 0x7FFE87DBE1E0
        public void ToString(){} // RVA: 0x7FFE87DBE220
        public void .ctor(){} // RVA: 0x7FFE87DC06D0
    }

    public class TextGenerator : Object
    {
        public UnityEngine.TextCore.Text.TextGenerator s_TextGenerator;

        // ── Methods ──
        public void GetTextGenerator(){} // RVA: 0x7FFE87DCDAA0
        public void GenerateText(){} // RVA: 0x7FFE87DCDB80
        public void GetPreferredValues(){} // RVA: 0x7FFE87DCDDE0
        public void get_isTextTruncated(){} // RVA: 0x7FFE87DCE180
        public void Prepare(){} // RVA: 0x7FFE87DCE1C0
        public void GenerateTextMesh(){} // RVA: 0x7FFE87DC0780
        public void SaveWordWrappingState(){} // RVA: 0x7FFE87DCE410
        public void RestoreWordWrappingState(){} // RVA: 0x7FFE87DCEED0
        public void ValidateHtmlTag(){} // RVA: 0x7FFE87DCF970
        public void SaveGlyphVertexInfo(){} // RVA: 0x7FFE87DD5800
        public void SaveSpriteVertexInfo(){} // RVA: 0x7FFE87DD6BB0
        public void DrawUnderlineMesh(){} // RVA: 0x7FFE87DD7710
        public void DrawTextHighlight(){} // RVA: 0x7FFE87DD8970
        public void ClearMesh(){} // RVA: 0x7FFE87DD9070
        public void SetArraySizes(){} // RVA: 0x7FFE87DD9150
        public void GetTextElement(){} // RVA: 0x7FFE87DDAD30
        public void ComputeMarginSize(){} // RVA: 0x7FFE87DDB270
        public void GetSpecialCharacters(){} // RVA: 0x7FFE87DDB370
        public void GetEllipsisSpecialCharacter(){} // RVA: 0x7FFE87DDB3A0
        public void GetUnderlineSpecialCharacter(){} // RVA: 0x7FFE87DDB700
        public void GetPreferredValuesInternal(){} // RVA: 0x7FFE87DDB870
        public void CalculatePreferredValues(){} // RVA: 0x7FFE87DDBA80
        public void PopulateTextBackingArray(){} // RVA: 0x7FFE87DDF300 | overloaded x2
        public void PopulateTextProcessingArray(){} // RVA: 0x7FFE87DDF480
        public void InsertNewLine(){} // RVA: 0x7FFE87DE04D0
        public void DoMissingGlyphCallback(){} // RVA: 0x7FFE87DE0D20
        public void ClearMarkupTagAttributes(){} // RVA: 0x7FFE87DE0DB0
        public void .ctor(){} // RVA: 0x7FFE87DE0E20
    }

    public class TextGeneratorUtilities : Object
    {
        // ── Methods ──
        public void Approximately(){} // RVA: 0x7FFE87DE2CE0
        public void HexCharsToColor(){} // RVA: 0x7FFE87DE33A0 | overloaded x2
        public void HexToInt(){} // RVA: 0x7FFE87DE3630
        public void ConvertToFloat(){} // RVA: 0x7FFE87DE37C0 | overloaded x2
        public void PackUV(){} // RVA: 0x7FFE87DE3920
        public void ResizeInternalArray(){} // RVA: 0x7FFE80E4BA70 | overloaded x2
        public void InsertOpeningTextStyle(){} // RVA: 0x7FFE87DE3960
        public void InsertClosingTextStyle(){} // RVA: 0x7FFE87DE3A60
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7FFE87DE3D60 | overloaded x2
        public void ReplaceClosingStyleTag(){} // RVA: 0x7FFE87DE3F60
        public void InsertOpeningStyleTag(){} // RVA: 0x7FFE87DE4090
        public void InsertClosingStyleTag(){} // RVA: 0x7FFE87DE4190
        public void InsertTextStyleInTextProcessingArray(){} // RVA: 0x7FFE87DE4290
        public void GetStyle(){} // RVA: 0x7FFE87DE4740
        public void GetStyleHashCode(){} // RVA: 0x7FFE87DE49F0 | overloaded x2
        public void GetUTF16(){} // RVA: 0x7FFE87DE4BD0 | overloaded x2
        public void GetUTF32(){} // RVA: 0x7FFE87DE4E30 | overloaded x2
        public void FillCharacterVertexBuffers(){} // RVA: 0x7FFE87DE4FE0
        public void FillSpriteVertexBuffers(){} // RVA: 0x7FFE87DE5BB0
        public void AdjustLineOffset(){} // RVA: 0x7FFE87DE6690
        public void ResizeLineExtents(){} // RVA: 0x7FFE87DE6A60
        public void LegacyStyleToNewStyle(){} // RVA: 0x7FFE87DE6D10
        public void LegacyAlignmentToNewAlignment(){} // RVA: 0x7FFE87DE6D40
        public void ConvertToUTF32(){} // RVA: 0x7FFE87DE6DC0
        public void GetMarkupTagHashCode(){} // RVA: 0x7FFE87DE6EA0 | overloaded x2
        public void ToUpperASCIIFast(){} // RVA: 0x7FFE87DE6FD0 | overloaded x2
        public void ToUpperFast(){} // RVA: 0x7FFE87DE7040
        public void GetAttributeParameters(){} // RVA: 0x7FFE87DE70B0
        public void IsBitmapRendering(){} // RVA: 0x7FFE87DE7180
        public void IsBaseGlyph(){} // RVA: 0x7FFE87DE71B0
        public void MinAlpha(){} // RVA: 0x7FFE87DE72C0
        public void GammaToLinear(){} // RVA: 0x7FFE87DE73A0 | overloaded x2
        public void IsValidUTF16(){} // RVA: 0x7FFE87DE7450
        public void IsValidUTF32(){} // RVA: 0x7FFE87DE74D0
        public void IsHangul(){} // RVA: 0x7FFE87DE7550
        public void IsCJK(){} // RVA: 0x7FFE87DE75B0
        public void .cctor(){} // RVA: 0x7FFE87DE7670
    }

    public class TextHandle : Object
    {
        public UnityEngine.Vector2 m_PreferredSize; // 0x10
        public UnityEngine.TextCore.Text.TextInfo m_TextInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DE76E0
        public void get_textInfo(){} // RVA: 0x7FFE87DE7810
        public void get_layoutTextInfo(){} // RVA: 0x7FFE87DE78C0
        public void IsDirty(){} // RVA: 0x7FFE87DE7A00
        public void GetCursorPositionFromStringIndexUsingCharacterHeight(){} // RVA: 0x7FFE87DE7A50
        public void GetCursorPositionFromStringIndexUsingLineHeight(){} // RVA: 0x7FFE87DE7CD0
        public void GetCursorIndexFromPosition(){} // RVA: 0x7FFE87DE7F50
        public void LineDownCharacterPosition(){} // RVA: 0x7FFE87DE82E0
        public void LineUpCharacterPosition(){} // RVA: 0x7FFE87DE8790
        public void FindNearestLine(){} // RVA: 0x7FFE87DE8C20
        public void FindNearestCharacterOnLine(){} // RVA: 0x7FFE87DE8D60
        public void FindIntersectingLink(){} // RVA: 0x7FFE87DE96A0
        public void PointIntersectRectangle(){} // RVA: 0x7FFE87DE9EA0
        public void DistanceToLine(){} // RVA: 0x7FFE87DEA030
        public void GetLineNumber(){} // RVA: 0x7FFE87DEA210
        public void GetLineHeight(){} // RVA: 0x7FFE87DEA2A0
        public void GetLineHeightFromCharacterIndex(){} // RVA: 0x7FFE87DEA330
        public void GetCharacterHeightFromIndex(){} // RVA: 0x7FFE87DEA3C0
        public void IsElided(){} // RVA: 0x7FFE87DEA550
        public void Substring(){} // RVA: 0x7FFE87DEA5D0
        public void IndexOf(){} // RVA: 0x7FFE87DEA780
        public void LastIndexOf(){} // RVA: 0x7FFE87DEA890
        public void ComputeTextWidth(){} // RVA: 0x7FFE87DEA950
        public void ComputeTextHeight(){} // RVA: 0x7FFE87DEA970
        public void UpdatePreferredValues(){} // RVA: 0x7FFE87DEA990
        public void Update(){} // RVA: 0x7FFE87DEAB30
        public void .cctor(){} // RVA: 0x7FFE87DEAC10
    }

    public class TextInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DEAD70
        public void Clear(){} // RVA: 0x7FFE87DEB050
        public void ClearMeshInfo(){} // RVA: 0x7FFE87DEB0D0
        public void ClearLineInfo(){} // RVA: 0x7FFE87DEB1A0
        public void ClearPageInfo(){} // RVA: 0x7FFE87DEB4F0
        public void Resize(){} // RVA: 0x7FFE80E4D100 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87DEB660
    }

    public class TextProcessingElement : ValueType
    {
    }

    public class TextProcessingStack`1 : ValueType
    {
        public T[] itemStack;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E484C0 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_current(){} // RVA: 0x7FFE810A1420
        public void SetDefault(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void Push(){} // RVA: 0x7FFE810A1420
        public void Pop(){} // RVA: 0x7FFE810A1420
        public void Peek(){} // RVA: 0x7FFE810A1420
        public void CurrentItem(){} // RVA: 0x7FFE810A1420
    }

    public class TextResourceManager : Object
    {
        // ── Methods ──
        public void AddFontAsset(){} // RVA: 0x7FFE87DEB780
        public void .cctor(){} // RVA: 0x7FFE87DEC130
    }

    public class TextSettings : ScriptableObject
    {
        public string m_Version; // 0x18
        public UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset; // 0x20
        public string m_DefaultFontAssetPath; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets; // 0x30
        public bool m_MatchMaterialPreset; // 0x38
        public int m_MissingCharacterUnicode; // 0x3C
        public bool m_ClearDynamicDataOnBuild; // 0x40
        public UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset; // 0x48
        public string m_DefaultSpriteAssetPath; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets; // 0x58
        public uint m_MissingSpriteCharacterUnicode; // 0x60
        public UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet; // 0x68
        public string m_StyleSheetsResourcePath; // 0x70
        public string m_DefaultColorGradientPresetsPath; // 0x78
        public UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
        public bool m_UseModernHangulLineBreakingRules; // 0x88
        public bool m_DisplayWarnings; // 0x89

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFE810FE7C0
        public void set_version(){} // RVA: 0x7FFE81161E80
        public void get_defaultFontAsset(){} // RVA: 0x7FFE811290C0
        public void set_defaultFontAsset(){} // RVA: 0x7FFE811290D0
        public void get_defaultFontAssetPath(){} // RVA: 0x7FFE81129130
        public void set_defaultFontAssetPath(){} // RVA: 0x7FFE810FCE90
        public void get_fallbackFontAssets(){} // RVA: 0x7FFE8144E200
        public void set_fallbackFontAssets(){} // RVA: 0x7FFE81129890
        public void get_matchMaterialPreset(){} // RVA: 0x7FFE812CF770
        public void set_matchMaterialPreset(){} // RVA: 0x7FFE812D0010
        public void get_missingCharacterUnicode(){} // RVA: 0x7FFE816311C0
        public void set_missingCharacterUnicode(){} // RVA: 0x7FFE82A4B070
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFE811B6C00
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFE811B6C10
        public void get_defaultSpriteAsset(){} // RVA: 0x7FFE81176730
        public void set_defaultSpriteAsset(){} // RVA: 0x7FFE81176740
        public void get_defaultSpriteAssetPath(){} // RVA: 0x7FFE8119C0E0
        public void set_defaultSpriteAssetPath(){} // RVA: 0x7FFE812534D0
        public void get_fallbackSpriteAssets(){} // RVA: 0x7FFE811C3500
        public void set_fallbackSpriteAssets(){} // RVA: 0x7FFE811C3510
        public void get_missingSpriteCharacterUnicode(){} // RVA: 0x7FFE8139EA30
        public void set_missingSpriteCharacterUnicode(){} // RVA: 0x7FFE8139E520
        public void get_defaultStyleSheet(){} // RVA: 0x7FFE81176D50
        public void set_defaultStyleSheet(){} // RVA: 0x7FFE81176D60
        public void get_styleSheetsResourcePath(){} // RVA: 0x7FFE811C3590
        public void set_styleSheetsResourcePath(){} // RVA: 0x7FFE811C35A0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x7FFE81463AE0
        public void set_defaultColorGradientPresetsPath(){} // RVA: 0x7FFE81464570
        public void get_lineBreakingRules(){} // RVA: 0x7FFE87DEC5D0
        public void set_lineBreakingRules(){} // RVA: 0x7FFE81282380
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFE87DEC690
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x7FFE820C0790
        public void get_displayWarnings(){} // RVA: 0x7FFE820C3D10
        public void set_displayWarnings(){} // RVA: 0x7FFE820BE3A0
        public void OnEnable(){} // RVA: 0x7FFE87DEC6A0
        public void InitializeFontReferenceLookup(){} // RVA: 0x7FFE87DEC6D0
        public void GetCachedFontAssetInternal(){} // RVA: 0x7FFE87DECAC0
        public void .ctor(){} // RVA: 0x7FFE87DECF30
    }

    public class TextShaderUtilities : Object
    {
        public int ID_MainTex;
        public int ID_FaceTex; // 0x4

        // ── Methods ──
        public void get_ShaderRef_MobileSDF(){} // RVA: 0x7FFE87DED1E0
        public void get_ShaderRef_MobileBitmap(){} // RVA: 0x7FFE87DED680
        public void .cctor(){} // RVA: 0x7FFE87DEDB20
        public void GetShaderPropertyIDs(){} // RVA: 0x7FFE87DEE140
    }

    public class TextStyle : Object
    {
        public UnityEngine.TextCore.Text.TextStyle k_NormalStyle;
        public string m_Name; // 0x10
        public int m_HashCode; // 0x18

        // ── Methods ──
        public void get_hashCode(){} // RVA: 0x7FFE84A02990
        public void get_styleOpeningTagArray(){} // RVA: 0x7FFE87C86B00
        public void get_styleClosingTagArray(){} // RVA: 0x7FFE87CC7F60
        public void .ctor(){} // RVA: 0x7FFE87DEFBB0
        public void RefreshStyle(){} // RVA: 0x7FFE87DEFD10
    }

    public class TextStyleSheet : ScriptableObject
    {
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Text.TextStyle> m_StyleList; // 0x18

        // ── Methods ──
        public void get_styles(){} // RVA: 0x7FFE83BBC680
        public void Reset(){} // RVA: 0x7FFE87DF0060
        public void GetStyle(){} // RVA: 0x7FFE87DF0100 | overloaded x2
        public void RefreshStyles(){} // RVA: 0x7FFE87DF0060
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7FFE87DF01A0
        public void .ctor(){} // RVA: 0x7FFE87DF06A0
    }

    public class TextUtilities : Object
    {
        // ── Methods ──
        public void ToUpperFast(){} // RVA: 0x7FFE87DF07E0
        public void GetHashCodeCaseInSensitive(){} // RVA: 0x7FFE87DF0850
        public void UintToString(){} // RVA: 0x7FFE87DF0930
    }

    public class TextVertex : ValueType
    {
    }

    public class UnicodeLineBreakingRules : Object
    {
        public UnityEngine.TextAsset m_UnicodeLineBreakingRules; // 0x10
        public UnityEngine.TextAsset m_LeadingCharacters; // 0x18
        public UnityEngine.TextAsset m_FollowingCharacters; // 0x20
        public bool m_UseModernHangulLineBreakingRules; // 0x28
        public System.Collections.Generic.HashSet`1<uint> m_LeadingCharactersLookup; // 0x30

        // ── Methods ──
        public void get_leadingCharacters(){} // RVA: 0x7FFE810FE7C0
        public void get_followingCharacters(){} // RVA: 0x7FFE811290C0
        public void get_leadingCharactersLookup(){} // RVA: 0x7FFE87DF0A00
        public void get_followingCharactersLookup(){} // RVA: 0x7FFE87DF0A40
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFE815F1380
        public void LoadLineBreakingRules(){} // RVA: 0x7FFE87DF0F30 | overloaded x2
        public void GetCharacters(){} // RVA: 0x7FFE87DF1350
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class WordInfo : ValueType
    {
    }

    public class WordWrapState : ValueType
    {
    }

}