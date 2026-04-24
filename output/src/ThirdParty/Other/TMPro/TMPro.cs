// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.TMPro
// Classes: 67
// Methods: 1401

namespace ThirdParty.Other.TMPro
{
    public class CodePoint : Object
    {
        public uint SPACE;
        public uint DOUBLE_QUOTE;
        public uint NUMBER_SIGN;
        public uint PERCENTAGE;
        public uint PLUS;
        public uint MINUS;
        public uint PERIOD;
        public uint HYPHEN_MINUS;
        public uint SOFT_HYPHEN;
        public uint HYPHEN;
        public uint NON_BREAKING_HYPHEN;
        public uint ZERO_WIDTH_SPACE;
        public uint RIGHT_SINGLE_QUOTATION;
        public uint APOSTROPHE;
        public uint WORD_JOINER;
        public uint HIGH_SURROGATE_START;
        public uint HIGH_SURROGATE_END;
        public uint LOW_SURROGATE_START;
        public uint LOW_SURROGATE_END;
        public uint UNICODE_PLANE01_START;
    }

    public class Extents : ValueType
    {
        public ypointLabel.r zero;
        public ypointLabel.r uninitialized; // 0x10
        public tionX min; // 0x10
        public tionX max; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC7CA00
        public void ToString(){} // RVA: 0x7FFD54B59620
        public void .cctor(){} // RVA: 0x7FFD54B597D0
    }

    public class FaceInfo_Legacy : Object
    {
        public string Name; // 0x10
        public float PointSize; // 0x18
        public float Scale; // 0x1C
        public int CharacterCount; // 0x20
        public float LineHeight; // 0x24
        public float Baseline; // 0x28
        public float Ascender; // 0x2C
        public float CapHeight; // 0x30
        public float Descender; // 0x34
        public float CenterLine; // 0x38
        public float SuperscriptOffset; // 0x3C
        public float SubscriptOffset; // 0x40
        public float SubSize; // 0x44
        public float Underline; // 0x48
        public float UnderlineThickness; // 0x4C
        public float strikethrough; // 0x50
        public float strikethroughThickness; // 0x54
        public float TabWidth; // 0x58
        public float Padding; // 0x5C
        public float AtlasWidth; // 0x60
        public float AtlasHeight; // 0x64

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class FastAction : Object
    {
        public URA.antCultureString<ÎÌÍÏÏÌÍÏ> delegates; // 0x10
        public URA.DateTime<ÎÌÍÏÏÌÍÏ,URA._cultureInfoNameMap<ÎÌÍÏÏÌÍÏ>> lookup; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD54B39FD0
        public void Remove(){} // RVA: 0x7FFD54B3A0C0
        public void Call(){} // RVA: 0x7FFD54B3A3F0
        public void .ctor(){} // RVA: 0x7FFD54B3A4A0
    }

    public class FastAction`1 : Object
    {
        public URA.antCultureString<ileFullDirectoryInformation<T1717692624>> delegates;
        public URA.DateTime<ileFullDirectoryInformation<T1717692624>,URA._cultureInfoNameMap<ileFullDirectoryInformation<T1717692624>>> lookup;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void Remove(){} // RVA: 0x7FFD4E090A40
        public void Call(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class FastAction`2 : Object
    {
        public URA.antCultureString<rectoryInformation<T1717692640,T1717692656>> delegates;
        public URA.DateTime<rectoryInformation<T1717692640,T1717692656>,URA._cultureInfoNameMap<rectoryInformation<T1717692640,T1717692656>>> lookup;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD5108D000
        public void Remove(){} // RVA: 0x7FFD5108D0D0
        public void Call(){} // RVA: 0x7FFD5108DAD0
        public void .ctor(){} // RVA: 0x7FFD5108DB50
    }

    public class FastAction`3 : Object
    {
        public URA.antCultureString<formation<T1717692672,T1717692688,T1717692704>> delegates;
        public URA.DateTime<formation<T1717692672,T1717692688,T1717692704>,URA._cultureInfoNameMap<formation<T1717692672,T1717692688,T1717692704>>> lookup;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD5108D000
        public void Remove(){} // RVA: 0x7FFD5108D0D0
        public void Call(){} // RVA: 0x7FFD5108E0E0
        public void .ctor(){} // RVA: 0x7FFD5108E180
    }

    public class HighlightState : ValueType
    {
        public object color; // 0x10
        public ypointLabel.Annotation padding; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51512100
        public void op_Equality(){} // RVA: 0x7FFD54B5A0C0
        public void op_Inequality(){} // RVA: 0x7FFD54B5A200
        public void GetHashCode(){} // RVA: 0x7FFD54B5A340
        public void Equals(){} // RVA: 0x7FFD54B5A410 | overloaded x2
    }

    public class ITextPreprocessor
    {
        // ── Methods ──
        public void PreprocessText(){} // RVA: 0x7FFD4E078F40
    }

    public class ITweenValue
    {
        public object ignoreTimeScale;
        public object duration;

        // ── Methods ──
        public void TweenValue(){} // RVA: 0x7FFD4E09E480
        public void get_ignoreTimeScale(){} // RVA: 0x7FFD4E079D00
        public void get_duration(){} // RVA: 0x7FFD4E08D880
        public void ValidTarget(){} // RVA: 0x7FFD4E079D00
    }

    public class MaterialReference : ValueType
    {
        public int index; // 0x10
        public ypointLabel.urces fontAsset; // 0x18
        public ypointLabel.? spriteAsset; // 0x20
        public atrix_Injected material; // 0x28
        public bool isDefaultMaterial; // 0x30
        public bool isFallbackMaterial; // 0x31
        public atrix_Injected fallbackMaterial; // 0x38
        public float padding; // 0x40
        public int referenceCount; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B3B980
        public void Contains(){} // RVA: 0x7FFD54B3BB50
        public void AddMaterialReference(){} // RVA: 0x7FFD54B3C060 | overloaded x2
    }

    public class MaterialReferenceManager : Object
    {
        public ypointLabel.lue instance;
        public URA.DateTime<int,atrix_Injected> m_FontMaterialReferenceLookup; // 0x10
        public URA.DateTime<int,ypointLabel.urces> m_FontAssetReferenceLookup; // 0x18
        public URA.DateTime<int,ypointLabel.?> m_SpriteAssetReferenceLookup; // 0x20
        public URA.DateTime<int,ypointLabel.ld> m_ColorGradientReferenceLookup; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD54B3A5F0
        public void AddFontAsset(){} // RVA: 0x7FFD54B3A6D0
        public void AddFontAssetInternal(){} // RVA: 0x7FFD54B3A7F0
        public void AddSpriteAsset(){} // RVA: 0x7FFD54B3AB30 | overloaded x2
        public void AddSpriteAssetInternal(){} // RVA: 0x7FFD54B3AC60 | overloaded x2
        public void AddFontMaterial(){} // RVA: 0x7FFD54B3AD80
        public void AddFontMaterialInternal(){} // RVA: 0x7FFD54B3AE10
        public void AddColorGradientPreset(){} // RVA: 0x7FFD54B3AEA0
        public void AddColorGradientPreset_Internal(){} // RVA: 0x7FFD54B3AF70
        public void Contains(){} // RVA: 0x7FFD54B3B0B0 | overloaded x2
        public void TryGetFontAsset(){} // RVA: 0x7FFD54B3B130
        public void TryGetFontAssetInternal(){} // RVA: 0x7FFD54B3B1F0
        public void TryGetSpriteAsset(){} // RVA: 0x7FFD54B3B2A0
        public void TryGetSpriteAssetInternal(){} // RVA: 0x7FFD54B3B360
        public void TryGetColorGradientPreset(){} // RVA: 0x7FFD54B3B410
        public void TryGetColorGradientPresetInternal(){} // RVA: 0x7FFD54B3B4D0
        public void TryGetMaterial(){} // RVA: 0x7FFD54B3B580
        public void TryGetMaterialInternal(){} // RVA: 0x7FFD54B3B640
        public void .ctor(){} // RVA: 0x7FFD54B3B6F0
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFD54BA7770
        public void SetEquatableStruct(){} // RVA: 0x7FFD4E2ADC40
        public void SetStruct(){} // RVA: 0x7FFD4E2ADC40
        public void SetClass(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ShaderUtilities : Object
    {
        public int ShaderRef_MobileSDF;
        public int ShaderRef_MobileBitmap; // 0x4
        public int ID_FaceColor; // 0x8
        public int ID_FaceDilate; // 0xC
        public int ID_Shininess; // 0x10
        public int ID_UnderlayColor; // 0x14
        public int ID_UnderlayOffsetX; // 0x18
        public int ID_UnderlayOffsetY; // 0x1C
        public int ID_UnderlayDilate; // 0x20
        public int ID_UnderlaySoftness; // 0x24
        public int ID_UnderlayOffset; // 0x28
        public int ID_UnderlayIsoPerimeter; // 0x2C
        public int ID_WeightNormal; // 0x30
        public int ID_WeightBold; // 0x34
        public int ID_OutlineTex; // 0x38
        public int ID_OutlineWidth; // 0x3C
        public int ID_OutlineSoftness; // 0x40
        public int ID_OutlineColor; // 0x44
        public int ID_Outline2Color; // 0x48
        public int ID_Outline2Width; // 0x4C
        public int ID_Padding; // 0x50
        public int ID_GradientScale; // 0x54
        public int ID_ScaleX; // 0x58
        public int ID_ScaleY; // 0x5C
        public int ID_PerspectiveFilter; // 0x60
        public int ID_Sharpness; // 0x64
        public int ID_TextureWidth; // 0x68
        public int ID_TextureHeight; // 0x6C
        public int ID_BevelAmount; // 0x70
        public int ID_GlowColor; // 0x74
        public int ID_GlowOffset; // 0x78
        public int ID_GlowPower; // 0x7C
        public int ID_GlowOuter; // 0x80
        public int ID_GlowInner; // 0x84
        public int ID_LightAngle; // 0x88
        public int ID_EnvMap; // 0x8C
        public int ID_EnvMatrix; // 0x90
        public int ID_EnvMatrixRotation; // 0x94
        public int ID_MaskCoord; // 0x98
        public int ID_ClipRect; // 0x9C
        public int ID_MaskSoftnessX; // 0xA0
        public int ID_MaskSoftnessY; // 0xA4
        public int ID_VertexOffsetX; // 0xA8
        public int ID_VertexOffsetY; // 0xAC
        public int ID_UseClipRect; // 0xB0
        public int ID_StencilID; // 0xB4
        public int ID_StencilOp; // 0xB8
        public int ID_StencilComp; // 0xBC
        public int ID_StencilReadMask; // 0xC0
        public int ID_StencilWriteMask; // 0xC4
        public int ID_ShaderFlags; // 0xC8
        public int ID_ScaleRatio_A; // 0xCC
        public int ID_ScaleRatio_B; // 0xD0
        public int ID_ScaleRatio_C; // 0xD4
        public string Keyword_Bevel; // 0xD8
        public string Keyword_Glow; // 0xE0
        public string Keyword_Underlay; // 0xE8
        public string Keyword_Ratios; // 0xF0
        public string Keyword_MASK_SOFT; // 0xF8
        public string Keyword_MASK_HARD; // 0x100
        public string Keyword_MASK_TEX; // 0x108
        public string Keyword_Outline; // 0x110
        public string ShaderTag_ZTestMode; // 0x118
        public string ShaderTag_CullMode; // 0x120
        public float m_clamp; // 0x128
        public bool isInitialized; // 0x12C
        public ojectionMatrix_Injected k_ShaderRef_MobileSDF; // 0x130
        public ojectionMatrix_Injected k_ShaderRef_MobileBitmap; // 0x138

        // ── Methods ──
        public void get_ShaderRef_MobileSDF(){} // RVA: 0x7FFD54BB1890
        public void get_ShaderRef_MobileBitmap(){} // RVA: 0x7FFD54BB1A60
        public void .cctor(){} // RVA: 0x7FFD54BB1C30
        public void GetShaderPropertyIDs(){} // RVA: 0x7FFD54BB2250
        public void UpdateShaderRatios(){} // RVA: 0x7FFD54BB3D00
        public void GetFontExtent(){} // RVA: 0x7FFD54BB4390
        public void IsMaskingEnabled(){} // RVA: 0x7FFD54BB43E0
        public void GetPadding(){} // RVA: 0x7FFD54BB50C0 | overloaded x2
    }

    public class TMP_Asset : ScriptableObject
    {
        public int instanceID; // 0x18
        public int hashCode; // 0x1C
        public atrix_Injected material; // 0x20
        public int materialHashCode; // 0x28

        // ── Methods ──
        public void get_instanceID(){} // RVA: 0x7FFD54B59A80
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class TMP_Character : TMP_TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B59C80 | overloaded x4
    }

    public class TMP_CharacterInfo : ValueType
    {
        public char character; // 0x10
        public int index; // 0x14
        public int stringLength; // 0x18
        public ypointLabel.extures elementType; // 0x1C
        public ypointLabel.oroutine textElement; // 0x20
        public ypointLabel.urces fontAsset; // 0x28
        public ypointLabel.? spriteAsset; // 0x30
        public int spriteIndex; // 0x38
        public atrix_Injected material; // 0x40
        public int materialReferenceIndex; // 0x48
        public bool isUsingAlternateTypeface; // 0x4C
        public float pointSize; // 0x50
        public int lineNumber; // 0x54
        public int pageNumber; // 0x58
        public int vertexIndex; // 0x5C
        public ypointLabel.oundTransform vertex_BL; // 0x60
        public ypointLabel.oundTransform vertex_TL; // 0x88
        public ypointLabel.oundTransform vertex_TR; // 0xB0
        public ypointLabel.oundTransform vertex_BR; // 0xD8
        public amut topLeft; // 0x100
        public amut bottomLeft; // 0x10C
        public amut topRight; // 0x118
        public amut bottomRight; // 0x124
        public float origin; // 0x130
        public float xAdvance; // 0x134
        public float ascender; // 0x138
        public float baseLine; // 0x13C
        public float descender; // 0x140
        public float adjustedAscender; // 0x144
        public float adjustedDescender; // 0x148
        public float aspectRatio; // 0x14C
        public float scale; // 0x150
        public object color; // 0x154
        public object underlineColor; // 0x158
        public int underlineVertexIndex; // 0x15C
        public object strikethroughColor; // 0x160
        public int strikethroughVertexIndex; // 0x164
        public object highlightColor; // 0x168
        public ypointLabel.teMonoColorTexture highlightState; // 0x16C
        public ypointLabel.rray style; // 0x180
        public bool isVisible; // 0x184
    }

    public class TMP_ColorGradient : ScriptableObject
    {
        public ypointLabel.kWidth colorMode; // 0x18
        public object topLeft; // 0x1C
        public object topRight; // 0x2C
        public object bottomLeft; // 0x3C
        public object bottomRight; // 0x4C
        public ypointLabel.kWidth k_DefaultColorMode;
        public object k_DefaultColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B5A5B0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD54B5A620
    }

    public class TMP_Compatibility : Object
    {
        // ── Methods ──
        public void ConvertTextAlignmentEnumValues(){} // RVA: 0x7FFD54B5A670
    }

    public class TMP_DefaultControls : Object
    {
        public float kWidth;
        public float kThickHeight;
        public float kThinHeight;
        public tionX s_TextElementSize;
        public tionX s_ThickElementSize; // 0x8
        public tionX s_ThinElementSize; // 0x10
        public object s_DefaultSelectableColor; // 0x18
        public object s_TextColor; // 0x28

        // ── Methods ──
        public void CreateUIElementRoot(){} // RVA: 0x7FFD54B5ACA0
        public void CreateUIObject(){} // RVA: 0x7FFD54B5AD90
        public void SetDefaultTextValues(){} // RVA: 0x7FFD54B5AE60
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7FFD54B5AF60
        public void SetParentAndAlign(){} // RVA: 0x7FFD54B5AFC0
        public void SetLayerRecursively(){} // RVA: 0x7FFD54B5B1C0
        public void CreateScrollbar(){} // RVA: 0x7FFD54B5B3D0
        public void CreateButton(){} // RVA: 0x7FFD54B5B950
        public void CreateText(){} // RVA: 0x7FFD54B5BE20
        public void CreateInputField(){} // RVA: 0x7FFD54B5BEE0
        public void CreateDropdown(){} // RVA: 0x7FFD54B5CD80
        public void .cctor(){} // RVA: 0x7FFD54B5ECB0
    }

    public class TMP_Dropdown : Selectable
    {
        public 16 template; // 0x100
        public ypointLabel.rAtlasTextures captionText; // 0x108
        public ePathName117.ÎÌÍÍÎÏÌ captionImage; // 0x110
        public ePathName117.hInputPathName124 placeholder; // 0x118
        public ypointLabel.rAtlasTextures itemText; // 0x120
        public ePathName117.ÎÌÍÍÎÏÌ itemImage; // 0x128
        public int options; // 0x130
        public teNormalizer onValueChanged; // 0x138
        public hortNormalizer alphaFadeSpeed; // 0x140
        public float value; // 0x148
        public BuffersImpl IsExpanded; // 0x150
        public BuffersImpl m_Blocker; // 0x158
        public URA.woDigitYearMax<ChannelNormalized> m_Items; // 0x160
        public ypointLabel.dth<ypointLabel.yLeftLandmarkColor> m_AlphaTweenRunner; // 0x168
        public bool validTemplate; // 0x170
        public ts m_Coroutine; // 0x178
        public Src s_NoOptionData;

        // ── Methods ──
        public void get_template(){} // RVA: 0x7FFD4E916C80
        public void set_template(){} // RVA: 0x7FFD54B5ED70
        public void get_captionText(){} // RVA: 0x7FFD4EAF1F40
        public void set_captionText(){} // RVA: 0x7FFD54B5EDD0
        public void get_captionImage(){} // RVA: 0x7FFD4E96B170
        public void set_captionImage(){} // RVA: 0x7FFD54B5EE30
        public void get_placeholder(){} // RVA: 0x7FFD4E7DC6D0
        public void set_placeholder(){} // RVA: 0x7FFD54B5EE90
        public void get_itemText(){} // RVA: 0x7FFD4E55CBB0
        public void set_itemText(){} // RVA: 0x7FFD54B5EEF0
        public void get_itemImage(){} // RVA: 0x7FFD4E9666F0
        public void set_itemImage(){} // RVA: 0x7FFD54B5EF50
        public void get_options(){} // RVA: 0x7FFD54B5EFB0
        public void set_options(){} // RVA: 0x7FFD54B5EFD0
        public void get_onValueChanged(){} // RVA: 0x7FFD4E3AC5F0
        public void set_onValueChanged(){} // RVA: 0x7FFD4E3AC600
        public void get_alphaFadeSpeed(){} // RVA: 0x7FFD54B5F050
        public void set_alphaFadeSpeed(){} // RVA: 0x7FFD54B5F060
        public void get_value(){} // RVA: 0x7FFD4E7DC1B0
        public void set_value(){} // RVA: 0x7FFD54B5F070
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD54B5F080
        public void SetValue(){} // RVA: 0x7FFD54B5F090
        public void get_IsExpanded(){} // RVA: 0x7FFD54B5F2D0
        public void .ctor(){} // RVA: 0x7FFD54B5F3A0
        public void Awake(){} // RVA: 0x7FFD54B5F670
        public void Start(){} // RVA: 0x7FFD54B5F980
        public void OnDisable(){} // RVA: 0x7FFD54B5FAB0
        public void RefreshShownValue(){} // RVA: 0x7FFD54B5FC10
        public void AddOptions(){} // RVA: 0x7FFD54B60340 | overloaded x3
        public void ClearOptions(){} // RVA: 0x7FFD54B60500
        public void SetupTemplate(){} // RVA: 0x7FFD54B60640
        public void GetOrAddComponent(){} // RVA: 0x7FFD4E2ADC40
        public void OnPointerClick(){} // RVA: 0x7FFD54B61440
        public void OnSubmit(){} // RVA: 0x7FFD54B61440
        public void OnCancel(){} // RVA: 0x7FFD54B61450
        public void Show(){} // RVA: 0x7FFD54B61460
        public void CreateBlocker(){} // RVA: 0x7FFD54B62D40
        public void DestroyBlocker(){} // RVA: 0x7FFD54B63770
        public void CreateDropdownList(){} // RVA: 0x7FFD54B637C0
        public void DestroyDropdownList(){} // RVA: 0x7FFD54B63830
        public void CreateItem(){} // RVA: 0x7FFD54B63880
        public void DestroyItem(){} // RVA: 0x7FFD4E341310
        public void AddItem(){} // RVA: 0x7FFD54B638F0
        public void AlphaFadeList(){} // RVA: 0x7FFD54B64080 | overloaded x2
        public void SetAlpha(){} // RVA: 0x7FFD54B64240
        public void Hide(){} // RVA: 0x7FFD54B64360
        public void DelayedDestroyDropdownList(){} // RVA: 0x7FFD54B64710
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7FFD54B647D0
        public void OnSelectItem(){} // RVA: 0x7FFD54B64B50
        public void .cctor(){} // RVA: 0x7FFD54B64DE0
    }

    public class TMP_FontAsset : TMP_Asset
    {
        public string version; // 0x30
        public string sourceFontFile; // 0x38
        public IsWithinBudget atlasPopulationMode; // 0x40
        public ypointLabel.uManager faceInfo; // 0x48
        public e.ToInstance glyphTable; // 0x50
        public URA.woDigitYearMax<e.ypeHash> glyphLookupTable; // 0xB0
        public URA.DateTime<uint,e.ypeHash> characterTable; // 0xB8
        public URA.woDigitYearMax<ypointLabel.arker> characterLookupTable; // 0xC0
        public URA.DateTime<uint,ypointLabel.arker> atlasTexture; // 0xC8
        public ector atlasTextures; // 0xD0
        public ector[] atlasTextureCount; // 0xD8
        public int isMultiAtlasTexturesEnabled; // 0xE0
        public bool clearDynamicDataOnBuild; // 0xE4
        public bool usedGlyphRects; // 0xE5
        public URA.woDigitYearMax<e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d> freeGlyphRects; // 0xE8
        public URA.woDigitYearMax<e.InitializeRegistryAsync>g__TryInitializePackageAsync|0>d> fontInfo; // 0xF0
        public ypointLabel.oseWorldLandmarks atlasWidth; // 0xF8
        public ector atlasHeight; // 0x100
        public int atlasPadding; // 0x108
        public int atlasRenderMode; // 0x10C
        public int fontFeatureTable; // 0x110
        public tPackageJObject.izablePackage fallbackFontAssetTable; // 0x114
        public URA.woDigitYearMax<ypointLabel.seLandmarksDetectorGraphOptions> creationSettings; // 0x118
        public ypointLabel.onfidence fontWeightTable; // 0x120
        public ypointLabel.ndDetectorGraphOptions_ m_FontFeatureTable; // 0x128
        public URA.woDigitYearMax<ypointLabel.urces> fallbackFontAssets; // 0x130
        public URA.woDigitYearMax<ypointLabel.urces> m_FallbackFontAssetTable; // 0x138
        public ypointLabel.sDetectorGraphOptions m_CreationSettings; // 0x140
        public ypointLabel.sDetectorGraphOptions_[] m_FontWeightTable; // 0x198
        public ypointLabel.sDetectorGraphOptions_[] fontWeights; // 0x1A0
        public float normalStyle; // 0x1A8
        public float normalSpacingOffset; // 0x1AC
        public float boldStyle; // 0x1B0
        public float boldSpacing; // 0x1B4
        public byte italicStyle; // 0x1B8
        public byte tabSize; // 0x1B9
        public bool IsFontAssetLookupTablesDirty; // 0x1BA
        public object k_ReadFontAssetDefinitionMarker;
        public object k_AddSynthesizedCharactersMarker; // 0x8
        public object k_TryAddCharacterMarker; // 0x10
        public object k_TryAddCharactersMarker; // 0x18
        public object k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
        public object k_ClearFontAssetDataMarker; // 0x28
        public object k_UpdateFontAssetDataMarker; // 0x30
        public string s_DefaultMaterialSuffix; // 0x38
        public URA.onsDepth<int> FallbackSearchQueryLookup; // 0x1C0
        public URA.onsDepth<int> k_SearchedFontAssetLookup; // 0x40
        public URA.woDigitYearMax<ypointLabel.urces> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
        public URA.onsDepth<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
        public URA.woDigitYearMax<ypointLabel.urces> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
        public URA.onsDepth<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
        public URA.woDigitYearMax<e.ypeHash> m_GlyphsToRender; // 0x1C8
        public URA.woDigitYearMax<e.ypeHash> m_GlyphsRendered; // 0x1D0
        public URA.woDigitYearMax<uint> m_GlyphIndexList; // 0x1D8
        public URA.woDigitYearMax<uint> m_GlyphIndexListNewlyAdded; // 0x1E0
        public URA.woDigitYearMax<uint> m_GlyphsToAdd; // 0x1E8
        public URA.onsDepth<uint> m_GlyphsToAddLookup; // 0x1F0
        public URA.woDigitYearMax<ypointLabel.arker> m_CharactersToAdd; // 0x1F8
        public URA.onsDepth<uint> m_CharactersToAddLookup; // 0x200
        public URA.woDigitYearMax<uint> s_MissingCharacterList; // 0x208
        public URA.onsDepth<uint> m_MissingUnicodesFromFontFile; // 0x210
        public uint[] k_GlyphIndexArray; // 0x68

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFD4E5F95E0
        public void set_version(){} // RVA: 0x7FFD4E36F890
        public void get_sourceFontFile(){} // RVA: 0x7FFD4E3BE740
        public void set_sourceFontFile(){} // RVA: 0x7FFD4E369200
        public void get_atlasPopulationMode(){} // RVA: 0x7FFD4E3E20C0
        public void set_atlasPopulationMode(){} // RVA: 0x7FFD4E3E20D0
        public void get_faceInfo(){} // RVA: 0x7FFD51F42550
        public void set_faceInfo(){} // RVA: 0x7FFD54B65290
        public void get_glyphTable(){} // RVA: 0x7FFD4E3AC040
        public void set_glyphTable(){} // RVA: 0x7FFD4E3AC050
        public void get_glyphLookupTable(){} // RVA: 0x7FFD54B65320
        public void get_characterTable(){} // RVA: 0x7FFD4E3AC120
        public void set_characterTable(){} // RVA: 0x7FFD4E3AC130
        public void get_characterLookupTable(){} // RVA: 0x7FFD54B65360
        public void get_atlasTexture(){} // RVA: 0x7FFD54B653A0
        public void get_atlasTextures(){} // RVA: 0x7FFD4E960F70
        public void set_atlasTextures(){} // RVA: 0x7FFD4E3C28A0
        public void get_atlasTextureCount(){} // RVA: 0x7FFD54B654F0
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFD53CE0AF0
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFD53DA9B20
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFD53CE0FF0
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFD54B65500
        public void get_usedGlyphRects(){} // RVA: 0x7FFD4E3C2970
        public void set_usedGlyphRects(){} // RVA: 0x7FFD4E3C2980
        public void get_freeGlyphRects(){} // RVA: 0x7FFD4E3AC2A0
        public void set_freeGlyphRects(){} // RVA: 0x7FFD4E3AC2B0
        public void get_fontInfo(){} // RVA: 0x7FFD4E751F50
        public void get_atlasWidth(){} // RVA: 0x7FFD4F9B9E70
        public void set_atlasWidth(){} // RVA: 0x7FFD4F9B7C50
        public void get_atlasHeight(){} // RVA: 0x7FFD4F9B7A10
        public void set_atlasHeight(){} // RVA: 0x7FFD4F9BAD60
        public void get_atlasPadding(){} // RVA: 0x7FFD4ED671E0
        public void set_atlasPadding(){} // RVA: 0x7FFD4F9B7C80
        public void get_atlasRenderMode(){} // RVA: 0x7FFD54B65510
        public void set_atlasRenderMode(){} // RVA: 0x7FFD54B65520
        public void get_fontFeatureTable(){} // RVA: 0x7FFD4E9666F0
        public void set_fontFeatureTable(){} // RVA: 0x7FFD4EDE51C0
        public void get_fallbackFontAssetTable(){} // RVA: 0x7FFD4E9622C0
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFD4EAF84B0
        public void get_creationSettings(){} // RVA: 0x7FFD54B65530
        public void set_creationSettings(){} // RVA: 0x7FFD54B65580
        public void get_fontWeightTable(){} // RVA: 0x7FFD4E961C80
        public void set_fontWeightTable(){} // RVA: 0x7FFD4EDE8ED0
        public void CreateFontAsset(){} // RVA: 0x7FFD54B656A0 | overloaded x2
        public void Awake(){} // RVA: 0x7FFD54B663F0
        public void ReadFontAssetDefinition(){} // RVA: 0x7FFD54B664E0
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7FFD54B66840
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7FFD54B66870
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7FFD54B66C10
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFD54B66FA0
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7FFD54B67250
        public void AddSynthesizedCharacter(){} // RVA: 0x7FFD54B67590
        public void AddCharacterToLookupCache(){} // RVA: 0x7FFD54B67870
        public void SortCharacterTable(){} // RVA: 0x7FFD54B67960
        public void SortGlyphTable(){} // RVA: 0x7FFD54B67BA0
        public void SortFontFeatureTable(){} // RVA: 0x7FFD54B67DE0
        public void SortAllTables(){} // RVA: 0x7FFD54B67E10
        public void HasCharacter(){} // RVA: 0x7FFD54B67ED0 | overloaded x2
        public void HasCharacter_Internal(){} // RVA: 0x7FFD54B686D0
        public void HasCharacters(){} // RVA: 0x7FFD54B69560 | overloaded x3
        public void GetCharacters(){} // RVA: 0x7FFD54B69630
        public void GetCharactersArray(){} // RVA: 0x7FFD54B697C0
        public void GetGlyphIndex(){} // RVA: 0x7FFD54B698A0
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7FFD54B69A00
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7FFD54B69B10
        public void RegisterFontAssetForAtlasTextureUpdate(){} // RVA: 0x7FFD54B69D10
        public void UpdateAtlasTexturesForFontAssetsInQueue(){} // RVA: 0x7FFD54B69E20
        public void TryAddCharacters(){} // RVA: 0x7FFD54B6AE40 | overloaded x4
        public void TryAddCharacterInternal(){} // RVA: 0x7FFD54B6BD10
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x7FFD54B6C620
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x7FFD4E341310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7FFD54B6CC20
        public void SetupNewAtlasTexture(){} // RVA: 0x7FFD54B6D0E0
        public void UpdateAtlasTexture(){} // RVA: 0x7FFD54B6D3F0
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7FFD4E341310 | overloaded x4
        public void CopyListDataToArray(){} // RVA: 0x7FFD4E099B30
        public void ClearFontAssetData(){} // RVA: 0x7FFD54B6DCC0
        public void ClearFontAssetDataInternal(){} // RVA: 0x7FFD54B6DD00
        public void UpdateFontAssetData(){} // RVA: 0x7FFD54B6DD30
        public void ClearFontAssetTables(){} // RVA: 0x7FFD54B6DEB0
        public void ClearAtlasTextures(){} // RVA: 0x7FFD54B6E110
        public void UpgradeFontAsset(){} // RVA: 0x7FFD54B6E640
        public void UpgradeGlyphAdjustmentTableToFontFeatureTable(){} // RVA: 0x7FFD54B6F480
        public void .ctor(){} // RVA: 0x7FFD54B6FA40
        public void .cctor(){} // RVA: 0x7FFD54B70320
    }

    public class TMP_FontAssetUtilities : Object
    {
        public ypointLabel.ppressionThreshold_ instance;
        public URA.onsDepth<int> k_SearchedAssets; // 0x8
        public bool k_IsFontEngineInitialized; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54B72180
        public void get_instance(){} // RVA: 0x7FFD54B72220
        public void GetCharacterFromFontAsset(){} // RVA: 0x7FFD54B72280
        public void GetCharacterFromFontAsset_Internal(){} // RVA: 0x7FFD54B72450
        public void GetCharacterFromFontAssets(){} // RVA: 0x7FFD54B729C0
        public void GetSpriteCharacterFromSpriteAsset(){} // RVA: 0x7FFD54B72D20
        public void GetSpriteCharacterFromSpriteAsset_Internal(){} // RVA: 0x7FFD54B731A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TMP_FontFeatureTable : Object
    {
        public URA.woDigitYearMax<ypointLabel.Confidence>k__BackingField> glyphPairAdjustmentRecords; // 0x10
        public URA.DateTime<uint,ypointLabel.Confidence>k__BackingField> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

        // ── Methods ──
        public void get_glyphPairAdjustmentRecords(){} // RVA: 0x7FFD4E35C380
        public void set_glyphPairAdjustmentRecords(){} // RVA: 0x7FFD4E342E30
        public void .ctor(){} // RVA: 0x7FFD54B73630
        public void SortGlyphPairAdjustmentRecords(){} // RVA: 0x7FFD54B73790
    }

    public class TMP_FontStyleStack : ValueType
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
        public void Clear(){} // RVA: 0x7FFD54BC25B0
        public void Add(){} // RVA: 0x7FFD54BC25C0
        public void Remove(){} // RVA: 0x7FFD54BC2670
    }

    public class TMP_GlyphValueRecord : ValueType
    {
        public float xPlacement; // 0x10
        public float yPlacement; // 0x14
        public float xAdvance; // 0x18
        public float yAdvance; // 0x1C

        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x7FFD4FC6C150
        public void set_xPlacement(){} // RVA: 0x7FFD4FEBB910
        public void get_yPlacement(){} // RVA: 0x7FFD4FEBB900
        public void set_yPlacement(){} // RVA: 0x7FFD4FEBB8F0
        public void get_xAdvance(){} // RVA: 0x7FFD4FEBB8E0
        public void set_xAdvance(){} // RVA: 0x7FFD4FEBB920
        public void get_yAdvance(){} // RVA: 0x7FFD4FEBB8D0
        public void set_yAdvance(){} // RVA: 0x7FFD4FEBB8C0
        public void .ctor(){} // RVA: 0x7FFD54B70DA0 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFD54B73450
    }

    public class TMP_InputField : Selectable
    {
        public Hash128ToStringImpl inputSystem; // 0x100
        public char[] compositionString;
        public 16 compositionLength; // 0x108
        public 16 mesh; // 0x110
        public ePathName117.alPriorityMax shouldHideMobileInput; // 0x118
        public ePathName117.alPriorityMax shouldHideSoftKeyboard; // 0x120
        public dRecorder text; // 0x128
        public ypointLabel.rAtlasTextures isFocused; // 0x138
        public 16 caretBlinkRate; // 0x140
        public ePathName117.hInputPathName124 caretWidth; // 0x148
        public ePathName117.readmill textViewport; // 0x150
        public ypointLabel.__19 textComponent; // 0x158
        public bool placeholder; // 0x160
        public ePathName117.on verticalScrollbar; // 0x168
        public moryFailure.ng scrollSensitivity; // 0x170
        public float caretColor; // 0x178
        public float customCaretColor; // 0x17C
        public 2_FE_LONGS selectionColor; // 0x180
        public ÍÏÎÍÏÏÌÏÏÍÏÌÌÎÌÎÌ onEndEdit; // 0x184
        public char onSubmit; // 0x188
        public Underscore onSelect; // 0x18C
        public object onDeselect; // 0x190
        public bool onTextSelection; // 0x194
        public bool onEndTextSelection; // 0x195
        public aterial onValueChanged; // 0x198
        public string onTouchScreenKeyboardStatusChanged; // 0x1A0
        public float onValidateInput; // 0x1A8
        public int characterLimit; // 0x1AC
        public et_isAutoFitting pointSize; // 0x1B0
        public et_isAutoFitting fontAsset; // 0x1B8
        public oFitting onFocusSelectAll; // 0x1C0
        public oFitting resetOnDeActivation; // 0x1C8
        public rners restoreOriginalTextOnEscape; // 0x1D0
        public rners isRichTextEditingAllowed; // 0x1D8
        public ting contentType; // 0x1E0
        public ers lineType; // 0x1E8
        public idth lineLimit; // 0x1F0
        public object inputType; // 0x1F8
        public bool keyboardType; // 0x208
        public object characterValidation; // 0x20C
        public string inputValidator; // 0x220
        public float readOnly; // 0x228
        public int richText; // 0x22C
        public bool multiLine; // 0x230
        public bool asteriskChar; // 0x231
        public int wasCanceled; // 0x234
        public int caretPositionInternal; // 0x238
        public int stringPositionInternal; // 0x23C
        public int caretSelectPositionInternal; // 0x240
        public 16 stringSelectPositionInternal; // 0x248
        public cTotalCost[] hasSelection; // 0x250
        public kingField caretPosition; // 0x258
        public tionX selectionAnchorPosition; // 0x260
        public object selectionFocusPosition; // 0x268
        public bool stringPosition; // 0x270
        public bool selectionStringAnchorPosition; // 0x271
        public bool selectionStringFocusPosition; // 0x272
        public bool clipboard; // 0x273
        public float minWidth;
        public float preferredWidth;
        public bool flexibleWidth; // 0x274
        public ts minHeight; // 0x278
        public float preferredHeight; // 0x280
        public ts flexibleHeight; // 0x288
        public string layoutPriority; // 0x290
        public bool m_WasCanceled; // 0x298
        public bool m_HasDoneFocusTransition; // 0x299
        public object m_WaitForSecondsRealtime; // 0x2A0
        public bool m_PreventCallback; // 0x2A8
        public bool m_TouchKeyboardAllowsInPlaceEditing; // 0x2A9
        public bool m_IsTextComponentUpdateRequired; // 0x2AA
        public bool m_isLastKeyBackspace; // 0x2AB
        public float m_PointerDownClickStartTime; // 0x2AC
        public float m_KeyDownStartTime; // 0x2B0
        public float m_DoubleClickDelay; // 0x2B4
        public string kEmailSpecialCharacters;
        public bool m_IsCompositionActive; // 0x2B8
        public bool m_ShouldUpdateIMEWindowPosition; // 0x2B9
        public int m_PreviousIMEInsertionLine; // 0x2BC
        public ypointLabel.urces m_GlobalFontAsset; // 0x2C0
        public bool m_OnFocusSelectAll; // 0x2C8
        public bool m_isSelectAll; // 0x2C9
        public bool m_ResetOnDeActivation; // 0x2CA
        public bool m_SelectionStillActive; // 0x2CB
        public bool m_ReleaseSelection; // 0x2CC
        public BuffersImpl m_PreviouslySelectedObject; // 0x2D0
        public bool m_RestoreOriginalTextOnEscape; // 0x2D8
        public bool m_isRichTextEditingAllowed; // 0x2D9
        public int m_LineLimit; // 0x2DC
        public ypointLabel.asChanged m_InputValidator; // 0x2E0
        public bool m_isSelected; // 0x2E8
        public bool m_IsStringPositionDirty; // 0x2E9
        public bool m_IsCaretPositionDirty; // 0x2EA
        public bool m_forceRectTransformAdjustment; // 0x2EB
        public 5EC78E8E02279FB1266932E3468A575B0EB9818985DBE9468B991CCE m_ProcessingEvent; // 0x2F0

        // ── Methods ──
        public void get_inputSystem(){} // RVA: 0x7FFD54B73C30
        public void get_compositionString(){} // RVA: 0x7FFD54B73E20
        public void get_compositionLength(){} // RVA: 0x7FFD54B73F70
        public void .ctor(){} // RVA: 0x7FFD54B73FA0
        public void get_mesh(){} // RVA: 0x7FFD54B74780
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFD54B748F0
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFD54B74990
        public void get_shouldHideSoftKeyboard(){} // RVA: 0x7FFD54B74A60
        public void set_shouldHideSoftKeyboard(){} // RVA: 0x7FFD54B74B30
        public void isKeyboardUsingEvents(){} // RVA: 0x7FFD54B74CB0
        public void get_text(){} // RVA: 0x7FFD4E9693F0
        public void set_text(){} // RVA: 0x7FFD54B74D60
        public void SetTextWithoutNotify(){} // RVA: 0x7FFD54B74D70
        public void SetText(){} // RVA: 0x7FFD54B74D80
        public void get_isFocused(){} // RVA: 0x7FFD54B74F40
        public void get_caretBlinkRate(){} // RVA: 0x7FFD4F54E510
        public void set_caretBlinkRate(){} // RVA: 0x7FFD54B74F50
        public void get_caretWidth(){} // RVA: 0x7FFD4F91A0A0
        public void set_caretWidth(){} // RVA: 0x7FFD54B74FC0
        public void get_textViewport(){} // RVA: 0x7FFD4E96B170
        public void set_textViewport(){} // RVA: 0x7FFD54B75020
        public void get_textComponent(){} // RVA: 0x7FFD4E9622C0
        public void set_textComponent(){} // RVA: 0x7FFD54B75080
        public void get_placeholder(){} // RVA: 0x7FFD4E3AC660
        public void set_placeholder(){} // RVA: 0x7FFD54B750E0
        public void get_verticalScrollbar(){} // RVA: 0x7FFD4E96DFA0
        public void set_verticalScrollbar(){} // RVA: 0x7FFD54B75140
        public void get_scrollSensitivity(){} // RVA: 0x7FFD54B75410
        public void set_scrollSensitivity(){} // RVA: 0x7FFD54B75420
        public void get_caretColor(){} // RVA: 0x7FFD54B75480
        public void set_caretColor(){} // RVA: 0x7FFD54B754E0
        public void get_customCaretColor(){} // RVA: 0x7FFD54064960
        public void set_customCaretColor(){} // RVA: 0x7FFD54B75550
        public void get_selectionColor(){} // RVA: 0x7FFD54B75570
        public void set_selectionColor(){} // RVA: 0x7FFD54B75580
        public void get_onEndEdit(){} // RVA: 0x7FFD4E969F30
        public void set_onEndEdit(){} // RVA: 0x7FFD54B755F0
        public void get_onSubmit(){} // RVA: 0x7FFD4E964330
        public void set_onSubmit(){} // RVA: 0x7FFD54B75650
        public void get_onSelect(){} // RVA: 0x7FFD4E9622B0
        public void set_onSelect(){} // RVA: 0x7FFD54B756B0
        public void get_onDeselect(){} // RVA: 0x7FFD4EDECB10
        public void set_onDeselect(){} // RVA: 0x7FFD54B75710
        public void get_onTextSelection(){} // RVA: 0x7FFD4EDE1920
        public void set_onTextSelection(){} // RVA: 0x7FFD54B75770
        public void get_onEndTextSelection(){} // RVA: 0x7FFD4EDE0A30
        public void set_onEndTextSelection(){} // RVA: 0x7FFD54B757D0
        public void get_onValueChanged(){} // RVA: 0x7FFD4E818150
        public void set_onValueChanged(){} // RVA: 0x7FFD54B75830
        public void get_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFD4EDD1060
        public void set_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFD54B75890
        public void get_onValidateInput(){} // RVA: 0x7FFD4E964EF0
        public void set_onValidateInput(){} // RVA: 0x7FFD54B758F0
        public void get_characterLimit(){} // RVA: 0x7FFD54B75950
        public void set_characterLimit(){} // RVA: 0x7FFD54B75960
        public void get_pointSize(){} // RVA: 0x7FFD54B75A10
        public void set_pointSize(){} // RVA: 0x7FFD54B75A20
        public void get_fontAsset(){} // RVA: 0x7FFD4EDCC670
        public void set_fontAsset(){} // RVA: 0x7FFD54B75C10
        public void get_onFocusSelectAll(){} // RVA: 0x7FFD4F294AA0
        public void set_onFocusSelectAll(){} // RVA: 0x7FFD4F92F260
        public void get_resetOnDeActivation(){} // RVA: 0x7FFD54B75DC0
        public void set_resetOnDeActivation(){} // RVA: 0x7FFD54B75DD0
        public void get_restoreOriginalTextOnEscape(){} // RVA: 0x7FFD53F32FE0
        public void set_restoreOriginalTextOnEscape(){} // RVA: 0x7FFD53F32FF0
        public void get_isRichTextEditingAllowed(){} // RVA: 0x7FFD53F33000
        public void set_isRichTextEditingAllowed(){} // RVA: 0x7FFD53F33010
        public void get_contentType(){} // RVA: 0x7FFD54B75DE0
        public void set_contentType(){} // RVA: 0x7FFD54B75DF0
        public void get_lineType(){} // RVA: 0x7FFD53E344E0
        public void set_lineType(){} // RVA: 0x7FFD54B75FA0
        public void get_lineLimit(){} // RVA: 0x7FFD54B76090
        public void set_lineLimit(){} // RVA: 0x7FFD54B760A0
        public void get_inputType(){} // RVA: 0x7FFD4E7D07B0
        public void set_inputType(){} // RVA: 0x7FFD54B76110
        public void get_keyboardType(){} // RVA: 0x7FFD53E344D0
        public void set_keyboardType(){} // RVA: 0x7FFD54B76180
        public void get_characterValidation(){} // RVA: 0x7FFD54A65C90
        public void set_characterValidation(){} // RVA: 0x7FFD54B761F0
        public void get_inputValidator(){} // RVA: 0x7FFD4EDCB5C0
        public void set_inputValidator(){} // RVA: 0x7FFD54B76260
        public void get_readOnly(){} // RVA: 0x7FFD53E15240
        public void set_readOnly(){} // RVA: 0x7FFD53E15250
        public void get_richText(){} // RVA: 0x7FFD53E15260
        public void set_richText(){} // RVA: 0x7FFD54B762D0
        public void get_multiLine(){} // RVA: 0x7FFD54B76400
        public void get_asteriskChar(){} // RVA: 0x7FFD54B76420
        public void set_asteriskChar(){} // RVA: 0x7FFD54B76430
        public void get_wasCanceled(){} // RVA: 0x7FFD54B76550
        public void ClampStringPos(){} // RVA: 0x7FFD54B76560
        public void ClampCaretPos(){} // RVA: 0x7FFD54B765A0
        public void get_caretPositionInternal(){} // RVA: 0x7FFD54B76600
        public void set_caretPositionInternal(){} // RVA: 0x7FFD54B76640
        public void get_stringPositionInternal(){} // RVA: 0x7FFD54B766B0
        public void set_stringPositionInternal(){} // RVA: 0x7FFD54B766F0
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFD54B76740
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFD54B76780
        public void get_stringSelectPositionInternal(){} // RVA: 0x7FFD54B767F0
        public void set_stringSelectPositionInternal(){} // RVA: 0x7FFD54B76830
        public void get_hasSelection(){} // RVA: 0x7FFD54B76880
        public void get_caretPosition(){} // RVA: 0x7FFD54B76740
        public void set_caretPosition(){} // RVA: 0x7FFD54B76910
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFD54B76600
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFD54B769A0
        public void get_selectionFocusPosition(){} // RVA: 0x7FFD54B76740
        public void set_selectionFocusPosition(){} // RVA: 0x7FFD54B769F0
        public void get_stringPosition(){} // RVA: 0x7FFD54B767F0
        public void set_stringPosition(){} // RVA: 0x7FFD54B76A40
        public void get_selectionStringAnchorPosition(){} // RVA: 0x7FFD54B766B0
        public void set_selectionStringAnchorPosition(){} // RVA: 0x7FFD54B76B30
        public void get_selectionStringFocusPosition(){} // RVA: 0x7FFD54B767F0
        public void set_selectionStringFocusPosition(){} // RVA: 0x7FFD54B76BC0
        public void OnEnable(){} // RVA: 0x7FFD54B76C50
        public void OnDisable(){} // RVA: 0x7FFD54B77910
        public void ON_TEXT_CHANGED(){} // RVA: 0x7FFD54B77F50
        public void CaretBlink(){} // RVA: 0x7FFD54B78300
        public void SetCaretVisible(){} // RVA: 0x7FFD54B783A0
        public void SetCaretActive(){} // RVA: 0x7FFD54B78420
        public void OnFocus(){} // RVA: 0x7FFD54B78510
        public void SelectAll(){} // RVA: 0x7FFD54B78530
        public void MoveTextEnd(){} // RVA: 0x7FFD54B785C0
        public void MoveTextStart(){} // RVA: 0x7FFD54B787A0
        public void MoveToEndOfLine(){} // RVA: 0x7FFD54B78970
        public void MoveToStartOfLine(){} // RVA: 0x7FFD54B78BF0
        public void get_clipboard(){} // RVA: 0x7FFD54B78EA0
        public void set_clipboard(){} // RVA: 0x7FFD54B78F20
        public void InPlaceEditing(){} // RVA: 0x7FFD54B78FB0
        public void UpdateStringPositionFromKeyboard(){} // RVA: 0x7FFD54B79160
        public void LateUpdate(){} // RVA: 0x7FFD54B79490
        public void MayDrag(){} // RVA: 0x7FFD54B7A020
        public void OnBeginDrag(){} // RVA: 0x7FFD54B7A190
        public void OnDrag(){} // RVA: 0x7FFD54B7A1C0
        public void MouseDragOutsideRect(){} // RVA: 0x7FFD54B7A6F0
        public void OnEndDrag(){} // RVA: 0x7FFD54B7A7F0
        public void OnPointerDown(){} // RVA: 0x7FFD54B7A820
        public void KeyPressed(){} // RVA: 0x7FFD54B7B230
        public void IsValidChar(){} // RVA: 0x7FFD54B7B800
        public void ProcessEvent(){} // RVA: 0x7FFD54B7B820
        public void OnUpdateSelected(){} // RVA: 0x7FFD54B7B830
        public void OnScroll(){} // RVA: 0x7FFD54B7BAC0
        public void GetScrollPositionRelativeToViewport(){} // RVA: 0x7FFD54B7BCE0
        public void GetSelectedString(){} // RVA: 0x7FFD54B7BE90
        public void FindNextWordBegin(){} // RVA: 0x7FFD54B7BF80
        public void MoveRight(){} // RVA: 0x7FFD54B7C0B0
        public void FindPrevWordBegin(){} // RVA: 0x7FFD54B7C860
        public void MoveLeft(){} // RVA: 0x7FFD54B7C980
        public void LineUpCharacterPosition(){} // RVA: 0x7FFD54B7D070
        public void LineDownCharacterPosition(){} // RVA: 0x7FFD54B7D300
        public void PageUpCharacterPosition(){} // RVA: 0x7FFD54B7D5D0
        public void PageDownCharacterPosition(){} // RVA: 0x7FFD54B7D960
        public void MoveDown(){} // RVA: 0x7FFD54B7DD30 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFD54B7DFB0 | overloaded x2
        public void MovePageUp(){} // RVA: 0x7FFD54B7E210 | overloaded x2
        public void MovePageDown(){} // RVA: 0x7FFD54B7E760 | overloaded x2
        public void Delete(){} // RVA: 0x7FFD54B7ECC0
        public void DeleteKey(){} // RVA: 0x7FFD54B7F030
        public void Backspace(){} // RVA: 0x7FFD54B7F320
        public void Append(){} // RVA: 0x7FFD54B7F7D0 | overloaded x2
        public void Insert(){} // RVA: 0x7FFD54B7FC10
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFD54B7FE40
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFD54B7FE90
        public void SendOnValueChanged(){} // RVA: 0x7FFD54B7FEF0
        public void SendOnEndEdit(){} // RVA: 0x7FFD54B7FF50
        public void SendOnSubmit(){} // RVA: 0x7FFD54B7FFB0
        public void SendOnFocus(){} // RVA: 0x7FFD54B80010
        public void SendOnFocusLost(){} // RVA: 0x7FFD54B80070
        public void SendOnTextSelection(){} // RVA: 0x7FFD54B800D0
        public void SendOnEndTextSelection(){} // RVA: 0x7FFD54B801D0
        public void SendTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFD54B802D0
        public void UpdateLabel(){} // RVA: 0x7FFD54B80380
        public void UpdateScrollbar(){} // RVA: 0x7FFD54B80A50
        public void OnScrollbarValueChange(){} // RVA: 0x7FFD54B80BF0
        public void UpdateMaskRegions(){} // RVA: 0x7FFD4E341310
        public void AdjustTextPositionRelativeToViewport(){} // RVA: 0x7FFD54B80C30
        public void GetCaretPositionFromStringIndex(){} // RVA: 0x7FFD54B81030
        public void GetMinCaretPositionFromStringIndex(){} // RVA: 0x7FFD54B810B0
        public void GetMaxCaretPositionFromStringIndex(){} // RVA: 0x7FFD54B81030
        public void GetStringIndexFromCaretPosition(){} // RVA: 0x7FFD54B81150
        public void ForceLabelUpdate(){} // RVA: 0x7FFD54B811E0
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFD54B811F0
        public void Rebuild(){} // RVA: 0x7FFD54B81290
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void UpdateGeometry(){} // RVA: 0x7FFD54B813C0
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFD54B814F0
        public void OnFillVBO(){} // RVA: 0x7FFD54B81FE0
        public void GenerateCaret(){} // RVA: 0x7FFD54B82520
        public void CreateCursorVerts(){} // RVA: 0x7FFD54B832C0
        public void GenerateHightlight(){} // RVA: 0x7FFD54B834D0
        public void AdjustRectTransformRelativeToViewport(){} // RVA: 0x7FFD54B83F70
        public void Validate(){} // RVA: 0x7FFD54B847F0
        public void ActivateInputField(){} // RVA: 0x7FFD54B85080
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFD54B852A0
        public void OnSelect(){} // RVA: 0x7FFD54B85A10
        public void OnPointerClick(){} // RVA: 0x7FFD54B85A80
        public void OnControlClick(){} // RVA: 0x7FFD4E341310
        public void ReleaseSelection(){} // RVA: 0x7FFD54B85AB0
        public void DeactivateInputField(){} // RVA: 0x7FFD54B85B70
        public void OnDeselect(){} // RVA: 0x7FFD54B85F30
        public void OnSubmit(){} // RVA: 0x7FFD54B85FB0
        public void EnforceContentType(){} // RVA: 0x7FFD54B86010
        public void SetTextComponentWrapMode(){} // RVA: 0x7FFD54B86180
        public void SetTextComponentRichTextMode(){} // RVA: 0x7FFD54B862E0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFD54B86410
        public void SetToCustom(){} // RVA: 0x7FFD54B86480 | overloaded x2
        public void DoStateTransition(){} // RVA: 0x7FFD54B864A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredWidth(){} // RVA: 0x7FFD54B864D0
        public void get_flexibleWidth(){} // RVA: 0x7FFD5496F350
        public void get_minHeight(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredHeight(){} // RVA: 0x7FFD54B867C0
        public void get_flexibleHeight(){} // RVA: 0x7FFD5496F350
        public void get_layoutPriority(){} // RVA: 0x7FFD4E433AF0
        public void SetGlobalPointSize(){} // RVA: 0x7FFD54B86AB0
        public void SetGlobalFontAsset(){} // RVA: 0x7FFD54B86C10
        public void .cctor(){} // RVA: 0x7FFD54B86D70
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class TMP_InputValidator : ScriptableObject
    {
        // ── Methods ──
        public void Validate(){}
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class TMP_LineInfo : ValueType
    {
        public int controlCharacterCount; // 0x10
        public int characterCount; // 0x14
        public int visibleCharacterCount; // 0x18
        public int spaceCount; // 0x1C
        public int wordCount; // 0x20
        public int firstCharacterIndex; // 0x24
        public int firstVisibleCharacterIndex; // 0x28
        public int lastCharacterIndex; // 0x2C
        public int lastVisibleCharacterIndex; // 0x30
        public float length; // 0x34
        public float lineHeight; // 0x38
        public float ascender; // 0x3C
        public float baseline; // 0x40
        public float descender; // 0x44
        public float maxAdvance; // 0x48
        public float width; // 0x4C
        public float marginLeft; // 0x50
        public float marginRight; // 0x54
        public ypointLabel.CharacterInternal alignment; // 0x58
        public ypointLabel.r lineExtents; // 0x5C
    }

    public class TMP_LinkInfo : ValueType
    {
        // ── Methods ──
        public void SetLinkID(){} // RVA: 0x7FFD54B59120
        public void GetLinkText(){} // RVA: 0x7FFD54B59240
        public void GetLinkID(){} // RVA: 0x7FFD54B593A0
    }

    public class TMP_ListPool`1 : Object
    {
        public ypointLabel.shFilters<URA.woDigitYearMax<T1717692864>> s_ListPool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E078A90
        public void Release(){} // RVA: 0x7FFD4E090A10
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class TMP_MaterialManager : Object
    {
        public URA.woDigitYearMax<ateMask> m_materialList;
        public URA.DateTime<long,s> m_fallbackMaterials; // 0x8
        public URA.DateTime<int,long> m_fallbackMaterialLookup; // 0x10
        public URA.woDigitYearMax<s> m_fallbackCleanupList; // 0x18
        public bool isFallbackListDirty; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54BA77B0
        public void OnPreRender(){} // RVA: 0x7FFD54BA7AF0
        public void GetStencilMaterial(){} // RVA: 0x7FFD54BA7B70
        public void ReleaseStencilMaterial(){} // RVA: 0x7FFD54BA8080
        public void GetBaseMaterial(){} // RVA: 0x7FFD54BA8300
        public void SetStencil(){} // RVA: 0x7FFD54BA84F0
        public void AddMaskingMaterial(){} // RVA: 0x7FFD54BA86C0
        public void RemoveStencilMaterial(){} // RVA: 0x7FFD54BA8A90
        public void ReleaseBaseMaterial(){} // RVA: 0x7FFD54BA8C40
        public void ClearMaterials(){} // RVA: 0x7FFD54BA9270
        public void GetStencilID(){} // RVA: 0x7FFD54BA9510
        public void GetMaterialForRendering(){} // RVA: 0x7FFD54BA9A60
        public void FindRootSortOverrideCanvas(){} // RVA: 0x7FFD54BA9D20
        public void GetFallbackMaterial(){} // RVA: 0x7FFD54BAA4A0 | overloaded x2
        public void AddFallbackMaterialReference(){} // RVA: 0x7FFD54BAAB30
        public void RemoveFallbackMaterialReference(){} // RVA: 0x7FFD54BAAD20
        public void CleanupFallbackMaterials(){} // RVA: 0x7FFD54BAAF80
        public void ReleaseFallbackMaterial(){} // RVA: 0x7FFD54BAB220
        public void CopyMaterialPresetProperties(){} // RVA: 0x7FFD54BAB4B0
    }

    public class TMP_MeshInfo : ValueType
    {
        public object s_DefaultColor;
        public amut s_DefaultNormal; // 0x4
        public get_boundingBoxMode s_DefaultTangent; // 0x10
        public stments s_DefaultBounds; // 0x20
        public object mesh; // 0x10
        public int vertexCount; // 0x18
        public amut[] vertices; // 0x20
        public amut[] normals; // 0x28
        public get_boundingBoxMode[] tangents; // 0x30
        public tionX[] uvs0; // 0x38
        public tionX[] uvs2; // 0x40
        public ?[] colors32; // 0x48
        public int[] triangles; // 0x50
        public atrix_Injected material; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BAC7A0 | overloaded x2
        public void ResizeMeshInfo(){} // RVA: 0x7FFD54BADDA0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD54BAECF0 | overloaded x2
        public void ClearUnusedVertices(){} // RVA: 0x7FFD54BAEFC0 | overloaded x3
        public void SortGeometry(){} // RVA: 0x7FFD54BAF200 | overloaded x2
        public void SwapVertexData(){} // RVA: 0x7FFD54BAF350
        public void .cctor(){} // RVA: 0x7FFD54BAFB40
    }

    public class TMP_ObjectPool`1 : Object
    {
        public URA.leEastFrench<T1717692880> countAll;
        public rScript.?<T1717692880> countActive;
        public rScript.?<T1717692880> countInactive;
        public int <countAll>k__BackingField;

        // ── Methods ──
        public void get_countAll(){} // RVA: 0x7FFD4E079960
        public void set_countAll(){} // RVA: 0x7FFD4E090ED0
        public void get_countActive(){} // RVA: 0x7FFD4E079960
        public void get_countInactive(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void Release(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TMP_Offset : ValueType
    {
        public float left; // 0x10
        public float right; // 0x14
        public float top; // 0x18
        public float bottom; // 0x1C
        public ypointLabel.Annotation horizontal;

        // ── Methods ──
        public void get_left(){} // RVA: 0x7FFD4FC6C150
        public void set_left(){} // RVA: 0x7FFD4FEBB910
        public void get_right(){} // RVA: 0x7FFD4FEBB900
        public void set_right(){} // RVA: 0x7FFD4FEBB8F0
        public void get_top(){} // RVA: 0x7FFD4FEBB8E0
        public void set_top(){} // RVA: 0x7FFD4FEBB920
        public void get_bottom(){} // RVA: 0x7FFD4FEBB8D0
        public void set_bottom(){} // RVA: 0x7FFD4FEBB8C0
        public void get_horizontal(){} // RVA: 0x7FFD4FC6C150
        public void set_horizontal(){} // RVA: 0x7FFD54B59DD0
        public void get_vertical(){} // RVA: 0x7FFD4FEBB8E0
        public void set_vertical(){} // RVA: 0x7FFD54B59DE0
        public void get_zero(){} // RVA: 0x7FFD54B59DF0
        public void .ctor(){} // RVA: 0x7FFD54B59E50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54399BA0
        public void op_Inequality(){} // RVA: 0x7FFD54B59E70
        public void op_Multiply(){} // RVA: 0x7FFD54ABE700
        public void GetHashCode(){} // RVA: 0x7FFD54B59F30
        public void Equals(){} // RVA: 0x7FFD54B5A000 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54B5A080
    }

    public class TMP_PageInfo : ValueType
    {
    }

    public class TMP_ResourceManager : Object
    {
        public ypointLabel.etCompoundBounds s_instance;
        public ypointLabel.ager s_TextSettings; // 0x8
        public URA.woDigitYearMax<ypointLabel.urces> s_FontAssetReferences; // 0x10
        public URA.DateTime<int,ypointLabel.urces> s_FontAssetReferenceLookup; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54BAFBF0
        public void GetTextSettings(){} // RVA: 0x7FFD54BAFE10
        public void AddFontAsset(){} // RVA: 0x7FFD54BAFFE0
        public void TryGetFontAsset(){} // RVA: 0x7FFD54BB0130
        public void RebuildFontAssetCache(){} // RVA: 0x7FFD54BB0220
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TMP_ScrollbarEventHandler : MonoBehaviour
    {
        public bool isSelected; // 0x20

        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7FFD54BB04F0
        public void OnSelect(){} // RVA: 0x7FFD54BB0550
        public void OnDeselect(){} // RVA: 0x7FFD54BB05C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class TMP_SelectionCaret : MaskableGraphic
    {
        // ── Methods ──
        public void Cull(){} // RVA: 0x7FFD54BB0630
        public void UpdateGeometry(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4FA68880
    }

    public class TMP_Settings : ScriptableObject
    {
        public ypointLabel.ager version;
        public bool enableWordWrapping; // 0x18
        public bool enableKerning; // 0x19
        public bool enableExtraPadding; // 0x1A
        public bool enableTintAllSprites; // 0x1B
        public bool enableParseEscapeCharacters; // 0x1C
        public bool enableRaycastTarget; // 0x1D
        public bool getFontFeaturesAtRuntime; // 0x1E
        public int missingGlyphCharacter; // 0x20
        public bool warningsDisabled; // 0x24
        public ypointLabel.urces defaultFontAsset; // 0x28
        public string defaultFontAssetPath; // 0x30
        public float defaultFontSize; // 0x38
        public float defaultTextAutoSizingMinRatio; // 0x3C
        public float defaultTextAutoSizingMaxRatio; // 0x40
        public tionX defaultTextMeshProTextContainerSize; // 0x44
        public tionX defaultTextMeshProUITextContainerSize; // 0x4C
        public bool autoSizeTextContainer; // 0x54
        public bool isTextObjectScaleStatic; // 0x55
        public URA.woDigitYearMax<ypointLabel.urces> fallbackFontAssets; // 0x58
        public bool matchMaterialPreset; // 0x60
        public ypointLabel.? defaultSpriteAsset; // 0x68
        public string defaultSpriteAssetPath; // 0x70
        public bool enableEmojiSupport; // 0x78
        public uint missingCharacterSpriteUnicode; // 0x7C
        public string defaultColorGradientPresetsPath; // 0x80
        public ypointLabel.t_atlasPadding defaultStyleSheet; // 0x88
        public string styleSheetsResourcePath; // 0x90
        public dex2 leadingCharacters; // 0x98
        public dex2 followingCharacters; // 0xA0
        public _vertical linebreakingRules; // 0xA8
        public bool useModernHangulLineBreakingRules; // 0xB0

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFD54BB0700
        public void get_enableWordWrapping(){} // RVA: 0x7FFD54BB0740
        public void get_enableKerning(){} // RVA: 0x7FFD54BB0760
        public void get_enableExtraPadding(){} // RVA: 0x7FFD54BB0780
        public void get_enableTintAllSprites(){} // RVA: 0x7FFD54BB07A0
        public void get_enableParseEscapeCharacters(){} // RVA: 0x7FFD54BB07C0
        public void get_enableRaycastTarget(){} // RVA: 0x7FFD54BB07E0
        public void get_getFontFeaturesAtRuntime(){} // RVA: 0x7FFD54BB0800
        public void get_missingGlyphCharacter(){} // RVA: 0x7FFD54BB0820
        public void set_missingGlyphCharacter(){} // RVA: 0x7FFD54BB0840
        public void get_warningsDisabled(){} // RVA: 0x7FFD54BB0870
        public void get_defaultFontAsset(){} // RVA: 0x7FFD54BB0890
        public void get_defaultFontAssetPath(){} // RVA: 0x7FFD54BB08B0
        public void get_defaultFontSize(){} // RVA: 0x7FFD54BB08D0
        public void get_defaultTextAutoSizingMinRatio(){} // RVA: 0x7FFD54BB08F0
        public void get_defaultTextAutoSizingMaxRatio(){} // RVA: 0x7FFD54BB0910
        public void get_defaultTextMeshProTextContainerSize(){} // RVA: 0x7FFD54BB0930
        public void get_defaultTextMeshProUITextContainerSize(){} // RVA: 0x7FFD54BB0960
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFD54BB0990
        public void get_isTextObjectScaleStatic(){} // RVA: 0x7FFD54BB09B0
        public void set_isTextObjectScaleStatic(){} // RVA: 0x7FFD54BB09D0
        public void get_fallbackFontAssets(){} // RVA: 0x7FFD54BB0A00
        public void get_matchMaterialPreset(){} // RVA: 0x7FFD54BB0A20
        public void get_defaultSpriteAsset(){} // RVA: 0x7FFD54BB0A40
        public void get_defaultSpriteAssetPath(){} // RVA: 0x7FFD54BB0A60
        public void get_enableEmojiSupport(){} // RVA: 0x7FFD54BB0A80
        public void set_enableEmojiSupport(){} // RVA: 0x7FFD54BB0AA0
        public void get_missingCharacterSpriteUnicode(){} // RVA: 0x7FFD54BB0AD0
        public void set_missingCharacterSpriteUnicode(){} // RVA: 0x7FFD54BB0AF0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x7FFD54BB0B20
        public void get_defaultStyleSheet(){} // RVA: 0x7FFD54BB0B50
        public void get_styleSheetsResourcePath(){} // RVA: 0x7FFD54BB0B80
        public void get_leadingCharacters(){} // RVA: 0x7FFD54BB0BB0
        public void get_followingCharacters(){} // RVA: 0x7FFD54BB0BE0
        public void get_linebreakingRules(){} // RVA: 0x7FFD54BB0C10
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFD54BB0C50
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x7FFD54BB0C80
        public void get_instance(){} // RVA: 0x7FFD54BB0CB0
        public void LoadDefaultSettings(){} // RVA: 0x7FFD54BB0E40
        public void GetSettings(){} // RVA: 0x7FFD54BB1060
        public void GetFontAsset(){} // RVA: 0x7FFD54BB1140
        public void GetSpriteAsset(){} // RVA: 0x7FFD54BB1230
        public void GetStyleSheet(){} // RVA: 0x7FFD54BB1320
        public void LoadLinebreakingRules(){} // RVA: 0x7FFD54BB1410
        public void GetCharacters(){} // RVA: 0x7FFD54BB16B0
        public void .ctor(){} // RVA: 0x7FFD54BB1880
    }

    public class TMP_Sprite : TMP_TextElement_Legacy
    {
        public string name; // 0x38
        public int hashCode; // 0x40
        public int unicode; // 0x44
        public tionX pivot; // 0x48
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField sprite; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TMP_SpriteAnimator : MonoBehaviour
    {
        public URA.DateTime<int,bool> m_animations; // 0x20
        public ypointLabel.rAtlasTextures m_TextComponent; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54BB5DE0
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD4E341310
        public void StopAllAnimations(){} // RVA: 0x7FFD54BB5E70
        public void DoSpriteAnimation(){} // RVA: 0x7FFD54BB5F40
        public void DoSpriteAnimationInternal(){} // RVA: 0x7FFD54BB6130
        public void .ctor(){} // RVA: 0x7FFD54BB6260
    }

    public class TMP_SpriteAsset : TMP_Asset
    {
        public URA.DateTime<int,int> version; // 0x30
        public URA.DateTime<uint,int> faceInfo; // 0x38
        public string spriteCharacterTable; // 0x40
        public e.ToInstance spriteCharacterLookupTable; // 0x48
        public ÎÎÏÏÍÎÎÍÏÍÌ>k__BackingField spriteGlyphTable; // 0xA8
        public URA.woDigitYearMax<ypointLabel.nfo> m_SpriteCharacterTable; // 0xB0
        public URA.DateTime<uint,ypointLabel.nfo> m_SpriteCharacterLookup; // 0xB8
        public URA.woDigitYearMax<ypointLabel.ookupTable> m_SpriteGlyphTable; // 0xC0
        public URA.DateTime<uint,ypointLabel.ookupTable> m_SpriteGlyphLookup; // 0xC8
        public URA.woDigitYearMax<ypointLabel.entSize> spriteInfoList; // 0xD0
        public URA.woDigitYearMax<ypointLabel.?> fallbackSpriteAssets; // 0xD8
        public bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
        public URA.onsDepth<int> k_searchedSpriteAssets;

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFD4E3BE740
        public void set_version(){} // RVA: 0x7FFD4E369200
        public void get_faceInfo(){} // RVA: 0x7FFD54BB6F90
        public void set_faceInfo(){} // RVA: 0x7FFD54BB6FD0
        public void get_spriteCharacterTable(){} // RVA: 0x7FFD54BB7050
        public void set_spriteCharacterTable(){} // RVA: 0x7FFD4E3AC050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7FFD54BB7090
        public void set_spriteCharacterLookupTable(){} // RVA: 0x7FFD4E3AC0C0
        public void get_spriteGlyphTable(){} // RVA: 0x7FFD4E3AC120
        public void set_spriteGlyphTable(){} // RVA: 0x7FFD4E3AC130
        public void Awake(){} // RVA: 0x7FFD54BB70D0
        public void GetDefaultSpriteMaterial(){} // RVA: 0x7FFD54BB71C0
        public void UpdateLookupTables(){} // RVA: 0x7FFD54BB7330
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7FFD54BB7B80
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7FFD54BB7C30
        public void GetSpriteIndexFromName(){} // RVA: 0x7FFD54BB7CD0
        public void SearchForSpriteByUnicode(){} // RVA: 0x7FFD54BB7D90
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7FFD54BB8380 | overloaded x2
        public void SearchForSpriteByHashCode(){} // RVA: 0x7FFD54BB8440
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7FFD54BB8BD0 | overloaded x2
        public void SortGlyphTable(){} // RVA: 0x7FFD54BB8C90
        public void SortCharacterTable(){} // RVA: 0x7FFD54BB8ED0
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7FFD54BB9110
        public void UpgradeSpriteAsset(){} // RVA: 0x7FFD54BB9130
        public void .ctor(){} // RVA: 0x7FFD54BB9630
    }

    public class TMP_SpriteCharacter : TMP_TextElement
    {
        public string name; // 0x30
        public int hashCode; // 0x38

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E5F95E0
        public void set_name(){} // RVA: 0x7FFD54BB9850
        public void get_hashCode(){} // RVA: 0x7FFD4E9AA870
        public void .ctor(){} // RVA: 0x7FFD54BB9B00 | overloaded x4
    }

    public class TMP_SpriteGlyph : Glyph
    {
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField sprite; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BB9C20 | overloaded x3
    }

    public class TMP_Style : Object
    {
        public ypointLabel.ble NormalStyle;
        public string name; // 0x10
        public int hashCode; // 0x18
        public string styleOpeningDefinition; // 0x20
        public string styleClosingDefinition; // 0x28
        public int[] styleOpeningTagArray; // 0x30
        public int[] styleClosingTagArray; // 0x38
        public uint[] m_OpeningTagUnicodeArray; // 0x40
        public uint[] m_ClosingTagUnicodeArray; // 0x48

        // ── Methods ──
        public void get_NormalStyle(){} // RVA: 0x7FFD54BB9CA0
        public void get_name(){} // RVA: 0x7FFD4E35C380
        public void set_name(){} // RVA: 0x7FFD54BB9DD0
        public void get_hashCode(){} // RVA: 0x7FFD4E577800
        public void set_hashCode(){} // RVA: 0x7FFD54BB9E70
        public void get_styleOpeningDefinition(){} // RVA: 0x7FFD4E36F0C0
        public void get_styleClosingDefinition(){} // RVA: 0x7FFD4E36F130
        public void get_styleOpeningTagArray(){} // RVA: 0x7FFD4E5F95E0
        public void get_styleClosingTagArray(){} // RVA: 0x7FFD4E5F0140
        public void .ctor(){} // RVA: 0x7FFD54BB9E80
        public void RefreshStyle(){} // RVA: 0x7FFD54BBA000
    }

    public class TMP_StyleSheet : ScriptableObject
    {
        public URA.woDigitYearMax<ypointLabel.ble> styles; // 0x18
        public URA.DateTime<int,ypointLabel.ble> m_StyleLookupDictionary; // 0x20

        // ── Methods ──
        public void get_styles(){} // RVA: 0x7FFD4E3447C0
        public void Reset(){} // RVA: 0x7FFD54BBA380
        public void GetStyle(){} // RVA: 0x7FFD54BBA420 | overloaded x2
        public void RefreshStyles(){} // RVA: 0x7FFD54BBA380
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7FFD54BBA4E0
        public void .ctor(){} // RVA: 0x7FFD54BBA910
    }

    public class TMP_SubMesh : MonoBehaviour
    {
        public ypointLabel.urces fontAsset; // 0x20
        public ypointLabel.? spriteAsset; // 0x28
        public atrix_Injected material; // 0x30
        public atrix_Injected sharedMaterial; // 0x38
        public atrix_Injected fallbackMaterial; // 0x40
        public atrix_Injected fallbackSourceMaterial; // 0x48
        public bool isDefaultMaterial; // 0x50
        public float padding; // 0x54
        public rical renderer; // 0x58
        public n meshFilter; // 0x60
        public object mesh; // 0x68
        public ypointLabel.faultValue textComponent; // 0x70
        public bool m_isRegisteredForEvents; // 0x78

        // ── Methods ──
        public void get_fontAsset(){} // RVA: 0x7FFD4E36F0C0
        public void set_fontAsset(){} // RVA: 0x7FFD4E36F0D0
        public void get_spriteAsset(){} // RVA: 0x7FFD4E36F130
        public void set_spriteAsset(){} // RVA: 0x7FFD4E342E90
        public void get_material(){} // RVA: 0x7FFD54BBAA50
        public void set_material(){} // RVA: 0x7FFD54BBAA60
        public void get_sharedMaterial(){} // RVA: 0x7FFD4E5F0140
        public void set_sharedMaterial(){} // RVA: 0x7FFD54BBAB90
        public void get_fallbackMaterial(){} // RVA: 0x7FFD4E3BE740
        public void set_fallbackMaterial(){} // RVA: 0x7FFD54BBABA0
        public void get_fallbackSourceMaterial(){} // RVA: 0x7FFD4E3BC730
        public void set_fallbackSourceMaterial(){} // RVA: 0x7FFD4E3BC740
        public void get_isDefaultMaterial(){} // RVA: 0x7FFD4E3FB8E0
        public void set_isDefaultMaterial(){} // RVA: 0x7FFD4E3FB8F0
        public void get_padding(){} // RVA: 0x7FFD4E7B1600
        public void set_padding(){} // RVA: 0x7FFD4E7B14E0
        public void get_renderer(){} // RVA: 0x7FFD54BBAEF0
        public void get_meshFilter(){} // RVA: 0x7FFD54BBB030
        public void get_mesh(){} // RVA: 0x7FFD54BBB2F0
        public void set_mesh(){} // RVA: 0x7FFD4E3BCD60
        public void get_textComponent(){} // RVA: 0x7FFD54BBB4A0
        public void AddSubTextObject(){} // RVA: 0x7FFD54BBB5E0
        public void OnEnable(){} // RVA: 0x7FFD54BBBF00
        public void OnDisable(){} // RVA: 0x7FFD54BBC180
        public void OnDestroy(){} // RVA: 0x7FFD54BBC330
        public void DestroySelf(){} // RVA: 0x7FFD54BBC620
        public void GetMaterial(){} // RVA: 0x7FFD54BBC6F0
        public void CreateMaterialInstance(){} // RVA: 0x7FFD54BBCB00
        public void GetSharedMaterial(){} // RVA: 0x7FFD54BBCC30
        public void SetSharedMaterial(){} // RVA: 0x7FFD54BBCDC0
        public void GetPaddingForMaterial(){} // RVA: 0x7FFD54BBCE40
        public void UpdateMeshPadding(){} // RVA: 0x7FFD54BBCED0
        public void SetVerticesDirty(){} // RVA: 0x7FFD54BBCF60
        public void SetMaterialDirty(){} // RVA: 0x7FFD54BBD0D0
        public void UpdateMaterial(){} // RVA: 0x7FFD54BBD0E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class TMP_SubMeshUI : MaskableGraphic
    {
        public ypointLabel.urces fontAsset; // 0xE0
        public ypointLabel.? spriteAsset; // 0xE8
        public atrix_Injected mainTexture; // 0xF0
        public atrix_Injected material; // 0xF8
        public atrix_Injected sharedMaterial; // 0x100
        public atrix_Injected fallbackMaterial; // 0x108
        public bool fallbackSourceMaterial; // 0x110
        public float materialForRendering; // 0x114
        public object isDefaultMaterial; // 0x118
        public ypointLabel.esourceProvider padding; // 0x120
        public bool mesh; // 0x128
        public bool textComponent; // 0x129
        public int m_materialReferenceIndex; // 0x12C
        public object m_RootCanvasTransform; // 0x130

        // ── Methods ──
        public void get_fontAsset(){} // RVA: 0x7FFD4E3C2900
        public void set_fontAsset(){} // RVA: 0x7FFD4E3C2910
        public void get_spriteAsset(){} // RVA: 0x7FFD4E3C2970
        public void set_spriteAsset(){} // RVA: 0x7FFD4E3C2980
        public void get_mainTexture(){} // RVA: 0x7FFD54BBD470
        public void get_material(){} // RVA: 0x7FFD54BBD5E0
        public void set_material(){} // RVA: 0x7FFD54BBD5F0
        public void get_sharedMaterial(){} // RVA: 0x7FFD4E751F50
        public void set_sharedMaterial(){} // RVA: 0x7FFD54BBD800
        public void get_fallbackMaterial(){} // RVA: 0x7FFD4E916C80
        public void set_fallbackMaterial(){} // RVA: 0x7FFD54BBD810
        public void get_fallbackSourceMaterial(){} // RVA: 0x7FFD4EAF1F40
        public void set_fallbackSourceMaterial(){} // RVA: 0x7FFD4ED49BF0
        public void get_materialForRendering(){} // RVA: 0x7FFD54BBDB70
        public void get_isDefaultMaterial(){} // RVA: 0x7FFD4E607D90
        public void set_isDefaultMaterial(){} // RVA: 0x7FFD4E605C40
        public void get_padding(){} // RVA: 0x7FFD54B39E50
        public void set_padding(){} // RVA: 0x7FFD54BBDBE0
        public void get_mesh(){} // RVA: 0x7FFD54BBDBF0
        public void set_mesh(){} // RVA: 0x7FFD4E7D8580
        public void get_textComponent(){} // RVA: 0x7FFD54BBDDA0
        public void AddSubTextObject(){} // RVA: 0x7FFD54BBDEF0
        public void OnEnable(){} // RVA: 0x7FFD54BBE760
        public void OnDisable(){} // RVA: 0x7FFD54BBE840
        public void OnDestroy(){} // RVA: 0x7FFD54BBE9B0
        public void OnTransformParentChanged(){} // RVA: 0x7FFD54BBED90
        public void GetModifiedMaterial(){} // RVA: 0x7FFD54BBEDF0
        public void GetPaddingForMaterial(){} // RVA: 0x7FFD54BBF090 | overloaded x2
        public void UpdateMeshPadding(){} // RVA: 0x7FFD54BBF120
        public void SetAllDirty(){} // RVA: 0x7FFD4E341310
        public void SetVerticesDirty(){} // RVA: 0x7FFD54BBF1B0
        public void SetLayoutDirty(){} // RVA: 0x7FFD4E341310
        public void SetMaterialDirty(){} // RVA: 0x7FFD54BBF2F0
        public void SetPivotDirty(){} // RVA: 0x7FFD54BBF340
        public void GetRootCanvasTransform(){} // RVA: 0x7FFD54BBF400
        public void Cull(){} // RVA: 0x7FFD4E341310
        public void UpdateGeometry(){} // RVA: 0x7FFD4E341310
        public void Rebuild(){} // RVA: 0x7FFD54BBF5F0
        public void RefreshMaterial(){} // RVA: 0x7FFD539B5F00
        public void UpdateMaterial(){} // RVA: 0x7FFD54BBF630
        public void RecalculateClipping(){} // RVA: 0x7FFD54B4B150
        public void GetMaterial(){} // RVA: 0x7FFD54BBFA00 | overloaded x2
        public void CreateMaterialInstance(){} // RVA: 0x7FFD54BBFD40
        public void GetSharedMaterial(){} // RVA: 0x7FFD54BBFE70
        public void SetSharedMaterial(){} // RVA: 0x7FFD54BBFEE0
        public void .ctor(){} // RVA: 0x7FFD4FA68880
    }

    public class TMP_Text : MaskableGraphic
    {
        public string text; // 0xE0
        public bool textPreprocessor; // 0xE8
        public ypointLabel.ieldNumber isRightToLeftText; // 0xF0
        public bool font; // 0xF8
        public ypointLabel.urces fontSharedMaterial; // 0x100
        public ypointLabel.urces fontSharedMaterials; // 0x108
        public bool fontMaterial; // 0x110
        public atrix_Injected fontMaterials; // 0x118
        public atrix_Injected color; // 0x120
        public ypointLabel.RectId[] alpha;
        public URA.DateTime<int,int> enableVertexGradient; // 0x8
        public ypointLabel.t<ypointLabel.RectId> colorGradient; // 0x10
        public int colorGradientPreset; // 0x128
        public atrix_Injected[] spriteAsset; // 0x130
        public atrix_Injected tintAllSprites; // 0x138
        public atrix_Injected[] styleSheet; // 0x140
        public bool textStyle; // 0x148
        public object overrideColorTags; // 0x14C
        public object faceColor; // 0x150
        public object outlineColor; // 0x68
        public object outlineWidth; // 0x160
        public object fontSize; // 0x164
        public bool fontWeight; // 0x168
        public ypointLabel.kWidth pixelsPerUnit; // 0x16C
        public ypointLabel.ircleVertices enableAutoSizing; // 0x170
        public ypointLabel.ld fontSizeMin; // 0x1B0
        public ypointLabel.? fontSizeMax; // 0x1B8
        public bool fontStyle; // 0x1C0
        public bool isUsingBold; // 0x1C1
        public object horizontalAlignment; // 0x1C4
        public ypointLabel.t_atlasPadding verticalAlignment; // 0x1C8
        public ypointLabel.ble alignment; // 0x1D0
        public int characterSpacing; // 0x1D8
        public bool wordSpacing; // 0x1DC
        public object lineSpacing; // 0x1E0
        public object lineSpacingAdjustment; // 0x1E4
        public float paragraphSpacing; // 0x1E8
        public float characterWidthAdjustment; // 0x1EC
        public float enableWordWrapping; // 0x1F0
        public float wordWrappingRatios; // 0x1F4
        public ypointLabel.t<float> overflowMode; // 0x1F8
        public ypointLabel.tAssetData isTextOverflowing; // 0x218
        public ypointLabel.tAssetData firstOverflowCharacterIndex; // 0x21C
        public ypointLabel.t<ypointLabel.tAssetData> linkedTextComponent; // 0x220
        public bool isTextTruncated; // 0x240
        public float enableKerning; // 0x244
        public float extraPadding; // 0x248
        public int richText; // 0x24C
        public int parseCtrlCharacters; // 0x250
        public bool isOverlay; // 0x254
        public float isOrthographic; // 0x258
        public float enableCulling; // 0x25C
        public ypointLabel.rray ignoreVisibility; // 0x260
        public ypointLabel.rray horizontalMapping; // 0x264
        public ypointLabel.formAdjustment verticalMapping; // 0x268
        public bool mappingUvLineOffset; // 0x272
        public ypointLabel.CharacterInternal renderMode; // 0x274
        public ypointLabel.racter_and_QueueRenderToTexture geometrySortingOrder; // 0x278
        public ypointLabel.ortFontFeatureTable isTextObjectScaleStatic; // 0x27C
        public ypointLabel.CharacterInternal vertexBufferAutoSizeReduction; // 0x280
        public ypointLabel.t<ypointLabel.CharacterInternal> firstVisibleCharacter; // 0x288
        public amut[] maxVisibleCharacters; // 0x2A8
        public float maxVisibleWords; // 0x2B0
        public float maxVisibleLines; // 0x2B4
        public float useMaxVisibleDescender; // 0x2B8
        public float pageToDisplay; // 0x2BC
        public float margin; // 0x2C0
        public float textInfo; // 0x2C4
        public float havePropertiesChanged; // 0x2C8
        public bool isUsingLegacyAnimationComponent; // 0x2CC
        public float transform; // 0x2D0
        public float rectTransform; // 0x2D4
        public float autoSizeTextContainer; // 0x2D8
        public float mesh; // 0x2DC
        public bool isVolumetricText; // 0x2E0
        public bool bounds; // 0x2E1
        public bool textBounds; // 0x2E2
        public bool spriteAnimator; // 0x2E3
        public float flexibleHeight; // 0x2E4
        public ypointLabel.UpdateGlyphAdjustmentRecords flexibleWidth; // 0x2E8
        public int minWidth; // 0x2EC
        public ypointLabel.rAtlasTextures minHeight; // 0x2F0
        public ypointLabel.rAtlasTextures maxWidth; // 0x2F8
        public bool maxHeight; // 0x300
        public bool layoutElement; // 0x301
        public float preferredWidth; // 0x304
        public bool preferredHeight; // 0x308
        public bool renderedWidth; // 0x309
        public bool renderedHeight; // 0x30A
        public bool layoutPriority; // 0x30B
        public bool m_isOverlay; // 0x30C
        public bool m_isOrthographic; // 0x30D
        public bool m_isCullingEnabled; // 0x30E
        public bool m_isMaskingEnabled; // 0x30F
        public bool isMaskUpdateRequired; // 0x310
        public bool m_ignoreCulling; // 0x311
        public ypointLabel.lyphIndexes m_horizontalMapping; // 0x314
        public ypointLabel.lyphIndexes m_verticalMapping; // 0x318
        public float m_uvLineOffset; // 0x31C
        public ypointLabel.exture m_renderMode; // 0x320
        public ypointLabel.? m_geometrySortingOrder; // 0x324
        public bool m_IsTextObjectScaleStatic; // 0x328
        public bool m_VertexBufferAutoSizeReduction; // 0x329
        public int m_firstVisibleCharacter; // 0x32C
        public int m_maxVisibleCharacters; // 0x330
        public int m_maxVisibleWords; // 0x334
        public int m_maxVisibleLines; // 0x338
        public bool m_useMaxVisibleDescender; // 0x33C
        public int m_pageToDisplay; // 0x340
        public bool m_isNewPage; // 0x344
        public get_boundingBoxMode m_margin; // 0x348
        public float m_marginLeft; // 0x358
        public float m_marginRight; // 0x35C
        public float m_marginWidth; // 0x360
        public float m_marginHeight; // 0x364
        public float m_width; // 0x368
        public ypointLabel.StartTime m_textInfo; // 0x370
        public bool m_havePropertiesChanged; // 0x378
        public bool m_isUsingLegacyAnimationComponent; // 0x379
        public object m_transform; // 0x380
        public 16 m_rectTransform; // 0x388
        public tionX m_PreviousRectTransformSize; // 0x390
        public tionX m_PreviousPivotPosition; // 0x398
        public bool <autoSizeTextContainer>k__BackingField; // 0x3A0
        public bool m_autoSizeTextContainer; // 0x3A1
        public object m_mesh; // 0x3A8
        public bool m_isVolumetricText; // 0x3B0
        public nalInformation<int,string,ypointLabel.urces> OnFontAssetRequest; // 0x70
        public nalInformation<int,string,ypointLabel.?> OnSpriteAssetRequest; // 0x78
        public ileFullDirectoryInformation<ypointLabel.StartTime> OnPreRenderText; // 0x3B8
        public ypointLabel.hickElementSize m_spriteAnimator; // 0x3C0
        public float m_flexibleHeight; // 0x3C8
        public float m_flexibleWidth; // 0x3CC
        public float m_minWidth; // 0x3D0
        public float m_minHeight; // 0x3D4
        public float m_maxWidth; // 0x3D8
        public float m_maxHeight; // 0x3DC
        public ePathName117.OpenVRLaunchOption_Bool m_LayoutElement; // 0x3E0
        public float m_preferredWidth; // 0x3E8
        public float m_renderedWidth; // 0x3EC
        public bool m_isPreferredWidthDirty; // 0x3F0
        public float m_preferredHeight; // 0x3F4
        public float m_renderedHeight; // 0x3F8
        public bool m_isPreferredHeightDirty; // 0x3FC
        public bool m_isCalculatingPreferredValues; // 0x3FD
        public int m_layoutPriority; // 0x400
        public bool m_isLayoutDirty; // 0x404
        public bool m_isAwake; // 0x405
        public bool m_isWaitingOnResourceLoad; // 0x406
        public houldActivateNextUpdate m_inputSource; // 0x408
        public float m_fontScaleMultiplier; // 0x40C
        public char[] m_htmlTag; // 0x80
        public ypointLabel.lateDistance[] m_xmlAttribute; // 0x88
        public float[] m_attributeParameterValues; // 0x90
        public float tag_LineIndent; // 0x410
        public float tag_Indent; // 0x414
        public ypointLabel.t<float> m_indentStack; // 0x418
        public bool tag_NoParsing; // 0x438
        public bool m_isParsingText; // 0x439
        public tSizeBias m_FXMatrix; // 0x43C
        public bool m_isFXMatrixSet; // 0x47C
        public OfBounds[] m_TextProcessingArray; // 0x480
        public int m_InternalTextProcessingArraySize; // 0x488
        public ypointLabel.ure[] m_internalCharacterInfo; // 0x490
        public int m_totalCharacterCount; // 0x498
        public ypointLabel.rkColor m_SavedWordWrapState; // 0x98
        public ypointLabel.rkColor m_SavedLineState; // 0x410
        public ypointLabel.rkColor m_SavedEllipsisState; // 0x788
        public ypointLabel.rkColor m_SavedLastValidState; // 0xB00
        public ypointLabel.rkColor m_SavedSoftLineBreakState; // 0xE78
        public ypointLabel.t<ypointLabel.rkColor> m_EllipsisInsertionCandidateStack; // 0x11F0
        public int m_characterCount; // 0x49C
        public int m_firstCharacterOfLine; // 0x4A0
        public int m_firstVisibleCharacterOfLine; // 0x4A4
        public int m_lastCharacterOfLine; // 0x4A8
        public int m_lastVisibleCharacterOfLine; // 0x4AC
        public int m_lineNumber; // 0x4B0
        public int m_lineVisibleCharacterCount; // 0x4B4
        public int m_pageNumber; // 0x4B8
        public float m_PageAscender; // 0x4BC
        public float m_maxTextAscender; // 0x4C0
        public float m_maxCapHeight; // 0x4C4
        public float m_ElementAscender; // 0x4C8
        public float m_ElementDescender; // 0x4CC
        public float m_maxLineAscender; // 0x4D0
        public float m_maxLineDescender; // 0x4D4
        public float m_startOfLineAscender; // 0x4D8
        public float m_startOfLineDescender; // 0x4DC
        public float m_lineOffset; // 0x4E0
        public ypointLabel.r m_meshExtents; // 0x4E4
        public object m_htmlColor; // 0x4F4
        public ypointLabel.t<?> m_colorStack; // 0x4F8
        public ypointLabel.t<?> m_underlineColorStack; // 0x518
        public ypointLabel.t<?> m_strikethroughColorStack; // 0x538
        public ypointLabel.t<ypointLabel.teMonoColorTexture> m_HighlightStateStack; // 0x558
        public ypointLabel.ld m_colorGradientPreset; // 0x588
        public ypointLabel.t<ypointLabel.ld> m_colorGradientStack; // 0x590
        public bool m_colorGradientPresetIsTinted; // 0x5B8
        public float m_tabSpacing; // 0x5BC
        public float m_spacing; // 0x5C0
        public ypointLabel.t<int>[] m_TextStyleStacks; // 0x5C8
        public int m_TextStyleStackDepth; // 0x5D0
        public ypointLabel.t<int> m_ItalicAngleStack; // 0x5D8
        public int m_ItalicAngle; // 0x5F8
        public ypointLabel.t<int> m_actionStack; // 0x600
        public float m_padding; // 0x620
        public float m_baselineOffset; // 0x624
        public ypointLabel.t<float> m_baselineOffsetStack; // 0x628
        public float m_xAdvance; // 0x648
        public ypointLabel.extures m_textElementType; // 0x64C
        public ypointLabel.oroutine m_cached_TextElement; // 0x650
        public crollSpeed m_Ellipsis; // 0x658
        public crollSpeed m_Underline; // 0x678
        public ypointLabel.? m_defaultSpriteAsset; // 0x698
        public ypointLabel.? m_currentSpriteAsset; // 0x6A0
        public int m_spriteCount; // 0x6A8
        public int m_spriteIndex; // 0x6AC
        public int m_spriteAnimationID; // 0x6B0
        public object k_ParseTextMarker; // 0x1588
        public object k_InsertNewLineMarker; // 0x1590
        public bool m_ignoreActiveState; // 0x6B4
        public llSpeed m_TextBackingArray; // 0x6B8
        public ltiple[] k_Power; // 0x6C8
        public tionX k_LargePositiveVector2; // 0x1598
        public tionX k_LargeNegativeVector2; // 0x15A0
        public float k_LargePositiveFloat; // 0x15A8
        public float k_LargeNegativeFloat; // 0x15AC
        public int k_LargePositiveInt; // 0x15B0
        public int k_LargeNegativeInt; // 0x15B4

        // ── Methods ──
        public void get_text(){} // RVA: 0x7FFD54B86E50
        public void set_text(){} // RVA: 0x7FFD54B86F30
        public void get_textPreprocessor(){} // RVA: 0x7FFD4E3AC2A0
        public void set_textPreprocessor(){} // RVA: 0x7FFD4E3AC2B0
        public void get_isRightToLeftText(){} // RVA: 0x7FFD4F0AE090
        public void set_isRightToLeftText(){} // RVA: 0x7FFD54B87040
        public void get_font(){} // RVA: 0x7FFD4E916C80
        public void set_font(){} // RVA: 0x7FFD54B870A0
        public void get_fontSharedMaterial(){} // RVA: 0x7FFD4E7DC6D0
        public void set_fontSharedMaterial(){} // RVA: 0x7FFD54B87270
        public void get_fontSharedMaterials(){} // RVA: 0x7FFD54B873E0
        public void set_fontSharedMaterials(){} // RVA: 0x7FFD54B87400
        public void get_fontMaterial(){} // RVA: 0x7FFD54B87460
        public void set_fontMaterial(){} // RVA: 0x7FFD54B87480
        public void get_fontMaterials(){} // RVA: 0x7FFD54B87640
        public void set_fontMaterials(){} // RVA: 0x7FFD54B87400
        public void get_color(){} // RVA: 0x7FFD53E53FA0
        public void set_color(){} // RVA: 0x7FFD54B87660
        public void get_alpha(){} // RVA: 0x7FFD54B876F0
        public void set_alpha(){} // RVA: 0x7FFD54B87700
        public void get_enableVertexGradient(){} // RVA: 0x7FFD4F42F720
        public void set_enableVertexGradient(){} // RVA: 0x7FFD54B87740
        public void get_colorGradient(){} // RVA: 0x7FFD54B87770
        public void set_colorGradient(){} // RVA: 0x7FFD54B877A0
        public void get_colorGradientPreset(){} // RVA: 0x7FFD4E969F30
        public void set_colorGradientPreset(){} // RVA: 0x7FFD54B877F0
        public void get_spriteAsset(){} // RVA: 0x7FFD4E964330
        public void set_spriteAsset(){} // RVA: 0x7FFD54B87870
        public void get_tintAllSprites(){} // RVA: 0x7FFD54061080
        public void set_tintAllSprites(){} // RVA: 0x7FFD54B87910
        public void get_styleSheet(){} // RVA: 0x7FFD4EDECB10
        public void set_styleSheet(){} // RVA: 0x7FFD54B87940
        public void get_textStyle(){} // RVA: 0x7FFD54B879E0
        public void set_textStyle(){} // RVA: 0x7FFD54B87C10
        public void get_overrideColorTags(){} // RVA: 0x7FFD54B87CD0
        public void set_overrideColorTags(){} // RVA: 0x7FFD54B87CE0
        public void get_faceColor(){} // RVA: 0x7FFD54B87D10
        public void set_faceColor(){} // RVA: 0x7FFD54B87EC0
        public void get_outlineColor(){} // RVA: 0x7FFD54B87F60
        public void set_outlineColor(){} // RVA: 0x7FFD54B88110
        public void get_outlineWidth(){} // RVA: 0x7FFD54B881A0
        public void set_outlineWidth(){} // RVA: 0x7FFD54B88330
        public void get_fontSize(){} // RVA: 0x7FFD54B883A0
        public void set_fontSize(){} // RVA: 0x7FFD54B883B0
        public void get_fontWeight(){} // RVA: 0x7FFD54B88420
        public void set_fontWeight(){} // RVA: 0x7FFD54B88430
        public void get_pixelsPerUnit(){} // RVA: 0x7FFD54B88490
        public void get_enableAutoSizing(){} // RVA: 0x7FFD4F5476F0
        public void set_enableAutoSizing(){} // RVA: 0x7FFD54B88750
        public void get_fontSizeMin(){} // RVA: 0x7FFD54B887A0
        public void set_fontSizeMin(){} // RVA: 0x7FFD54B887B0
        public void get_fontSizeMax(){} // RVA: 0x7FFD54B88810
        public void set_fontSizeMax(){} // RVA: 0x7FFD54B88820
        public void get_fontStyle(){} // RVA: 0x7FFD4E3A19C0
        public void set_fontStyle(){} // RVA: 0x7FFD54B88880
        public void get_isUsingBold(){} // RVA: 0x7FFD54B888E0
        public void get_horizontalAlignment(){} // RVA: 0x7FFD54B888F0
        public void set_horizontalAlignment(){} // RVA: 0x7FFD54B88900
        public void get_verticalAlignment(){} // RVA: 0x7FFD54B88930
        public void set_verticalAlignment(){} // RVA: 0x7FFD54B88940
        public void get_alignment(){} // RVA: 0x7FFD54B88970
        public void set_alignment(){} // RVA: 0x7FFD54B88980
        public void get_characterSpacing(){} // RVA: 0x7FFD54B889D0
        public void set_characterSpacing(){} // RVA: 0x7FFD54B889E0
        public void get_wordSpacing(){} // RVA: 0x7FFD54B88A40
        public void set_wordSpacing(){} // RVA: 0x7FFD54B88A50
        public void get_lineSpacing(){} // RVA: 0x7FFD54B88AB0
        public void set_lineSpacing(){} // RVA: 0x7FFD54B88AC0
        public void get_lineSpacingAdjustment(){} // RVA: 0x7FFD54B88B20
        public void set_lineSpacingAdjustment(){} // RVA: 0x7FFD54B88B30
        public void get_paragraphSpacing(){} // RVA: 0x7FFD54B88B90
        public void set_paragraphSpacing(){} // RVA: 0x7FFD54B88BA0
        public void get_characterWidthAdjustment(){} // RVA: 0x7FFD54B88C00
        public void set_characterWidthAdjustment(){} // RVA: 0x7FFD54B88C10
        public void get_enableWordWrapping(){} // RVA: 0x7FFD53F330E0
        public void set_enableWordWrapping(){} // RVA: 0x7FFD54B88C70
        public void get_wordWrappingRatios(){} // RVA: 0x7FFD54B88CD0
        public void set_wordWrappingRatios(){} // RVA: 0x7FFD54B88CE0
        public void get_overflowMode(){} // RVA: 0x7FFD54B88D40
        public void set_overflowMode(){} // RVA: 0x7FFD54B88D50
        public void get_isTextOverflowing(){} // RVA: 0x7FFD54B88DB0
        public void get_firstOverflowCharacterIndex(){} // RVA: 0x7FFD54B88DC0
        public void get_linkedTextComponent(){} // RVA: 0x7FFD4EDD9020
        public void set_linkedTextComponent(){} // RVA: 0x7FFD54B88DD0
        public void get_isTextTruncated(){} // RVA: 0x7FFD54B89040
        public void get_enableKerning(){} // RVA: 0x7FFD54B89050
        public void set_enableKerning(){} // RVA: 0x7FFD54B89060
        public void get_extraPadding(){} // RVA: 0x7FFD54B890C0
        public void set_extraPadding(){} // RVA: 0x7FFD54B890D0
        public void get_richText(){} // RVA: 0x7FFD54B89130
        public void set_richText(){} // RVA: 0x7FFD54B89140
        public void get_parseCtrlCharacters(){} // RVA: 0x7FFD54B891A0
        public void set_parseCtrlCharacters(){} // RVA: 0x7FFD54B891B0
        public void get_isOverlay(){} // RVA: 0x7FFD54B89210
        public void set_isOverlay(){} // RVA: 0x7FFD54B89220
        public void get_isOrthographic(){} // RVA: 0x7FFD54B89280
        public void set_isOrthographic(){} // RVA: 0x7FFD54B89290
        public void get_enableCulling(){} // RVA: 0x7FFD54B892C0
        public void set_enableCulling(){} // RVA: 0x7FFD54B892D0
        public void get_ignoreVisibility(){} // RVA: 0x7FFD54B89310
        public void set_ignoreVisibility(){} // RVA: 0x7FFD54B89320
        public void get_horizontalMapping(){} // RVA: 0x7FFD54B89340
        public void set_horizontalMapping(){} // RVA: 0x7FFD54B89350
        public void get_verticalMapping(){} // RVA: 0x7FFD54B89380
        public void set_verticalMapping(){} // RVA: 0x7FFD54B89390
        public void get_mappingUvLineOffset(){} // RVA: 0x7FFD54B893C0
        public void set_mappingUvLineOffset(){} // RVA: 0x7FFD54B893D0
        public void get_renderMode(){} // RVA: 0x7FFD54B89410
        public void set_renderMode(){} // RVA: 0x7FFD54B89420
        public void get_geometrySortingOrder(){} // RVA: 0x7FFD54B89440
        public void set_geometrySortingOrder(){} // RVA: 0x7FFD54B89450
        public void get_isTextObjectScaleStatic(){} // RVA: 0x7FFD54B89480
        public void set_isTextObjectScaleStatic(){} // RVA: 0x7FFD54B89490
        public void get_vertexBufferAutoSizeReduction(){} // RVA: 0x7FFD54B89520
        public void set_vertexBufferAutoSizeReduction(){} // RVA: 0x7FFD54B89530
        public void get_firstVisibleCharacter(){} // RVA: 0x7FFD54B89560
        public void set_firstVisibleCharacter(){} // RVA: 0x7FFD54B89570
        public void get_maxVisibleCharacters(){} // RVA: 0x7FFD54B895A0
        public void set_maxVisibleCharacters(){} // RVA: 0x7FFD54B895B0
        public void get_maxVisibleWords(){} // RVA: 0x7FFD54B895E0
        public void set_maxVisibleWords(){} // RVA: 0x7FFD54B895F0
        public void get_maxVisibleLines(){} // RVA: 0x7FFD54B89620
        public void set_maxVisibleLines(){} // RVA: 0x7FFD54B89630
        public void get_useMaxVisibleDescender(){} // RVA: 0x7FFD54B89660
        public void set_useMaxVisibleDescender(){} // RVA: 0x7FFD54B89670
        public void get_pageToDisplay(){} // RVA: 0x7FFD54B896A0
        public void set_pageToDisplay(){} // RVA: 0x7FFD54B896B0
        public void get_margin(){} // RVA: 0x7FFD54B896E0
        public void set_margin(){} // RVA: 0x7FFD54B896F0
        public void get_textInfo(){} // RVA: 0x7FFD4EDEF840
        public void get_havePropertiesChanged(){} // RVA: 0x7FFD54B897B0
        public void set_havePropertiesChanged(){} // RVA: 0x7FFD54B897C0
        public void get_isUsingLegacyAnimationComponent(){} // RVA: 0x7FFD54B897F0
        public void set_isUsingLegacyAnimationComponent(){} // RVA: 0x7FFD54B89800
        public void get_transform(){} // RVA: 0x7FFD54B89810
        public void get_rectTransform(){} // RVA: 0x7FFD54B89960
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFD54B89AB0
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFD54B89AC0
        public void get_mesh(){} // RVA: 0x7FFD4EDCD480
        public void get_isVolumetricText(){} // RVA: 0x7FFD54B89AD0
        public void set_isVolumetricText(){} // RVA: 0x7FFD54B89AE0
        public void get_bounds(){} // RVA: 0x7FFD54B89B50
        public void get_textBounds(){} // RVA: 0x7FFD54B89C90
        public void add_OnFontAssetRequest(){} // RVA: 0x7FFD54B89CF0
        public void remove_OnFontAssetRequest(){} // RVA: 0x7FFD54B89E50
        public void add_OnSpriteAssetRequest(){} // RVA: 0x7FFD54B89FB0
        public void remove_OnSpriteAssetRequest(){} // RVA: 0x7FFD54B8A110
        public void add_OnPreRenderText(){} // RVA: 0x7FFD54B8A270
        public void remove_OnPreRenderText(){} // RVA: 0x7FFD54B8A370
        public void get_spriteAnimator(){} // RVA: 0x7FFD54B8A470
        public void get_flexibleHeight(){} // RVA: 0x7FFD54B8A730
        public void get_flexibleWidth(){} // RVA: 0x7FFD54B8A740
        public void get_minWidth(){} // RVA: 0x7FFD54B8A750
        public void get_minHeight(){} // RVA: 0x7FFD54B8A760
        public void get_maxWidth(){} // RVA: 0x7FFD54B8A770
        public void get_maxHeight(){} // RVA: 0x7FFD54B8A780
        public void get_layoutElement(){} // RVA: 0x7FFD54B8A790
        public void get_preferredWidth(){} // RVA: 0x7FFD54B8A8E0
        public void get_preferredHeight(){} // RVA: 0x7FFD54B8A900
        public void get_renderedWidth(){} // RVA: 0x7FFD54B8A920
        public void get_renderedHeight(){} // RVA: 0x7FFD54B8A950
        public void get_layoutPriority(){} // RVA: 0x7FFD54B8A980
        public void LoadFontAsset(){} // RVA: 0x7FFD4E341310
        public void SetSharedMaterial(){} // RVA: 0x7FFD4E341310
        public void GetMaterial(){} // RVA: 0x7FFD4E919180
        public void SetFontBaseMaterial(){} // RVA: 0x7FFD4E341310
        public void GetSharedMaterials(){} // RVA: 0x7FFD4E919180
        public void SetSharedMaterials(){} // RVA: 0x7FFD4E341310
        public void GetMaterials(){} // RVA: 0x7FFD4E919180
        public void CreateMaterialInstance(){} // RVA: 0x7FFD54B8A990
        public void SetVertexColorGradient(){} // RVA: 0x7FFD54B8AAC0
        public void SetTextSortingOrder(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void SetFaceColor(){} // RVA: 0x7FFD4E341310
        public void SetOutlineColor(){} // RVA: 0x7FFD4E341310
        public void SetOutlineThickness(){} // RVA: 0x7FFD4E341310
        public void SetShaderDepth(){} // RVA: 0x7FFD4E341310
        public void SetCulling(){} // RVA: 0x7FFD4E341310
        public void UpdateCulling(){} // RVA: 0x7FFD4E341310
        public void GetPaddingForMaterial(){} // RVA: 0x7FFD54B8ADC0 | overloaded x2
        public void GetTextContainerLocalCorners(){} // RVA: 0x7FFD4E919180
        public void ForceMeshUpdate(){} // RVA: 0x7FFD4E341310
        public void UpdateGeometry(){} // RVA: 0x7FFD4E341310
        public void UpdateVertexData(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void SetVertices(){} // RVA: 0x7FFD4E341310
        public void UpdateMeshPadding(){} // RVA: 0x7FFD4E341310
        public void CrossFadeColor(){} // RVA: 0x7FFD54B8AF80
        public void CrossFadeAlpha(){} // RVA: 0x7FFD54B8B030
        public void InternalCrossFadeColor(){} // RVA: 0x7FFD4E341310
        public void InternalCrossFadeAlpha(){} // RVA: 0x7FFD4E341310
        public void ParseInputText(){} // RVA: 0x7FFD54B8B130
        public void PopulateTextBackingArray(){} // RVA: 0x7FFD54B8B560 | overloaded x4
        public void PopulateTextProcessingArray(){} // RVA: 0x7FFD54B8B6D0
        public void SetTextInternal(){} // RVA: 0x7FFD54B8C460
        public void SetText(){} // RVA: 0x7FFD54B8CC80 | overloaded x13
        public void SetCharArray(){} // RVA: 0x7FFD54B8CC80 | overloaded x2
        public void GetStyle(){} // RVA: 0x7FFD54B8CCF0
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7FFD54B8D350 | overloaded x2
        public void ReplaceClosingStyleTag(){} // RVA: 0x7FFD54B8DB80 | overloaded x2
        public void InsertOpeningStyleTag(){} // RVA: 0x7FFD54B8DF30
        public void InsertClosingStyleTag(){} // RVA: 0x7FFD54B8E2E0
        public void GetMarkupTagHashCode(){} // RVA: 0x7FFD54B8E730 | overloaded x2
        public void GetStyleHashCode(){} // RVA: 0x7FFD54B8E8F0 | overloaded x2
        public void ResizeInternalArray(){} // RVA: 0x7FFD4E097970 | overloaded x2
        public void AddFloatToInternalTextBackingArray(){} // RVA: 0x7FFD54B8E9E0
        public void AddIntegerToInternalTextBackingArray(){} // RVA: 0x7FFD54B8F0A0
        public void InternalTextBackingArrayToString(){} // RVA: 0x7FFD54B8F2A0
        public void SetArraySizes(){} // RVA: 0x7FFD4E919180
        public void GetPreferredValues(){} // RVA: 0x7FFD54B8F560 | overloaded x4
        public void GetPreferredWidth(){} // RVA: 0x7FFD54B8F830 | overloaded x2
        public void GetPreferredHeight(){} // RVA: 0x7FFD54B8FB20 | overloaded x2
        public void GetRenderedValues(){} // RVA: 0x7FFD54B8FC20 | overloaded x2
        public void GetRenderedWidth(){} // RVA: 0x7FFD54B8FC60 | overloaded x2
        public void GetRenderedHeight(){} // RVA: 0x7FFD54B8FC90 | overloaded x2
        public void CalculatePreferredValues(){} // RVA: 0x7FFD54B8FCC0
        public void GetCompoundBounds(){} // RVA: 0x7FFD51C6A7D0
        public void GetCanvasSpaceClippingRect(){} // RVA: 0x7FFD4F3D3780
        public void GetTextBounds(){} // RVA: 0x7FFD54B92E00 | overloaded x2
        public void AdjustLineOffset(){} // RVA: 0x7FFD54B930D0
        public void ResizeLineExtents(){} // RVA: 0x7FFD54B93560
        public void GetTextInfo(){} // RVA: 0x7FFD4E919180
        public void ComputeMarginSize(){} // RVA: 0x7FFD4E341310
        public void InsertNewLine(){} // RVA: 0x7FFD54B93850
        public void SaveWordWrappingState(){} // RVA: 0x7FFD54B94160
        public void RestoreWordWrappingState(){} // RVA: 0x7FFD54B94B40
        public void SaveGlyphVertexInfo(){} // RVA: 0x7FFD54B95580
        public void SaveSpriteVertexInfo(){} // RVA: 0x7FFD54B96A00
        public void FillCharacterVertexBuffers(){} // RVA: 0x7FFD54B97DC0 | overloaded x2
        public void FillSpriteVertexBuffers(){} // RVA: 0x7FFD54B98CC0
        public void DrawUnderlineMesh(){} // RVA: 0x7FFD54B995F0
        public void DrawTextHighlight(){} // RVA: 0x7FFD54B9A480
        public void LoadDefaultSettings(){} // RVA: 0x7FFD54B9A9E0
        public void GetSpecialCharacters(){} // RVA: 0x7FFD54B9AFD0
        public void GetEllipsisSpecialCharacter(){} // RVA: 0x7FFD54B9B000
        public void GetUnderlineSpecialCharacter(){} // RVA: 0x7FFD54B9B400
        public void ReplaceTagWithCharacter(){} // RVA: 0x7FFD54B9B630
        public void GetFontAssetForWeight(){} // RVA: 0x7FFD54B9B690
        public void GetTextElement(){} // RVA: 0x7FFD54B9B720
        public void SetActiveSubMeshes(){} // RVA: 0x7FFD4E341310
        public void DestroySubMeshObjects(){} // RVA: 0x7FFD4E341310
        public void ClearMesh(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void GetParsedText(){} // RVA: 0x7FFD54B9BDA0
        public void IsSelfOrLinkedAncestor(){} // RVA: 0x7FFD54B9BEA0
        public void ReleaseLinkedTextComponent(){} // RVA: 0x7FFD54B9C060
        public void PackUV(){} // RVA: 0x7FFD54B9C2E0 | overloaded x2
        public void InternalUpdate(){} // RVA: 0x7FFD4E341310
        public void HexToInt(){} // RVA: 0x7FFD54B9C320
        public void GetUTF16(){} // RVA: 0x7FFD54B9C6C0 | overloaded x5
        public void GetUTF32(){} // RVA: 0x7FFD54B9CC30 | overloaded x5
        public void HexCharsToColor(){} // RVA: 0x7FFD54B9D3B0 | overloaded x2
        public void GetAttributeParameters(){} // RVA: 0x7FFD54B9D680
        public void ConvertToFloat(){} // RVA: 0x7FFD54B9D8A0 | overloaded x2
        public void ValidateHtmlTag(){} // RVA: 0x7FFD54B9DA20
        public void .ctor(){} // RVA: 0x7FFD54BA5130
        public void .cctor(){} // RVA: 0x7FFD54BA6520
    }

    public class TMP_TextElement : Object
    {
        public ypointLabel.tartTime elementType; // 0x10
        public uint unicode; // 0x14
        public ypointLabel.eTextColor textAsset; // 0x18
        public e.ypeHash glyph; // 0x20
        public uint glyphIndex; // 0x28
        public float scale; // 0x2C

        // ── Methods ──
        public void get_elementType(){} // RVA: 0x7FFD4E40B5E0
        public void get_unicode(){} // RVA: 0x7FFD4E7F5A20
        public void set_unicode(){} // RVA: 0x7FFD4E7F4990
        public void get_textAsset(){} // RVA: 0x7FFD4E3447C0
        public void set_textAsset(){} // RVA: 0x7FFD4E3A7E80
        public void get_glyph(){} // RVA: 0x7FFD4E36F0C0
        public void set_glyph(){} // RVA: 0x7FFD4E36F0D0
        public void get_glyphIndex(){} // RVA: 0x7FFD4E70C4C0
        public void set_glyphIndex(){} // RVA: 0x7FFD4EABA6E0
        public void get_scale(){} // RVA: 0x7FFD4E80AB80
        public void set_scale(){} // RVA: 0x7FFD4E80A9D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TMP_TextElement_Legacy : Object
    {
        public int id; // 0x10
        public float x; // 0x14
        public float y; // 0x18
        public float width; // 0x1C
        public float height; // 0x20
        public float xOffset; // 0x24
        public float yOffset; // 0x28
        public float xAdvance; // 0x2C
        public float scale; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TMP_TextInfo : Object
    {
        public tionX k_InfinityVectorPositive;
        public tionX k_InfinityVectorNegative; // 0x8
        public ypointLabel.rAtlasTextures textComponent; // 0x10
        public int characterCount; // 0x18
        public int spriteCount; // 0x1C
        public int spaceCount; // 0x20
        public int wordCount; // 0x24
        public int linkCount; // 0x28
        public int lineCount; // 0x2C
        public int pageCount; // 0x30
        public int materialCount; // 0x34
        public ypointLabel.ure[] characterInfo; // 0x38
        public ypointLabel.esultAnnotationController[] wordInfo; // 0x40
        public ypointLabel.LandmarkListAnnotation[] linkInfo; // 0x48
        public ypointLabel._anchorPosition[] lineInfo; // 0x50
        public ypointLabel.IrisLandmarkList[] pageInfo; // 0x58
        public ypointLabel.pectiveCorrection[] meshInfo; // 0x60
        public ypointLabel.pectiveCorrection[] m_CachedMeshInfo; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BC0A40 | overloaded x3
        public void Clear(){} // RVA: 0x7FFD54BC0E80
        public void ClearAllData(){} // RVA: 0x7FFD54BC0F00
        public void ClearMeshInfo(){} // RVA: 0x7FFD54BC11F0
        public void ClearAllMeshInfo(){} // RVA: 0x7FFD54BC12B0
        public void ResetVertexLayout(){} // RVA: 0x7FFD54BC1360
        public void ClearUnusedVertices(){} // RVA: 0x7FFD54BC1420
        public void ClearLineInfo(){} // RVA: 0x7FFD54BC14E0
        public void ClearPageInfo(){} // RVA: 0x7FFD54BC17F0
        public void CopyMeshInfoVertexData(){} // RVA: 0x7FFD54BC1960
        public void Resize(){} // RVA: 0x7FFD4E097A00 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54BC2090
    }

    public class TMP_TextParsingUtilities : Object
    {
        public ypointLabel._isRichTextEditingAllowed instance;
        public string k_LookupStringL;
        public string k_LookupStringU;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54BC2100
        public void get_instance(){} // RVA: 0x7FFD54BC21A0
        public void GetHashCode(){} // RVA: 0x7FFD54BC2200
        public void GetHashCodeCaseSensitive(){} // RVA: 0x7FFD54BC2320
        public void ToLowerASCIIFast(){} // RVA: 0x7FFD54BC24E0 | overloaded x2
        public void ToUpperASCIIFast(){} // RVA: 0x7FFD54BC2460 | overloaded x2
        public void IsHighSurrogate(){} // RVA: 0x7FFD54BC2560
        public void IsLowSurrogate(){} // RVA: 0x7FFD54BC2580
        public void ConvertToUTF32(){} // RVA: 0x7FFD54BC25A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TMP_TextProcessingStack`1 : ValueType
    {
        public ypointLabel.rkColor[] Count; // 0x10
        public int current; // 0x18
        public ypointLabel.rkColor rolloverSize; // 0x20
        public int m_Capacity; // 0x398
        public int m_RolloverSize; // 0x39C
        public int m_Count; // 0x3A0
        public int k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092E60 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_current(){} // RVA: 0x7FFD4E2ADC40
        public void get_rolloverSize(){} // RVA: 0x7FFD4E079960
        public void set_rolloverSize(){} // RVA: 0x7FFD4E090ED0
        public void SetDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void Pop(){} // RVA: 0x7FFD4E2ADC40
        public void Peek(){} // RVA: 0x7FFD4E2ADC40
        public void CurrentItem(){} // RVA: 0x7FFD4E2ADC40
        public void PreviousItem(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TMP_TextUtilities : Object
    {
        public amut[] m_rectWorldCorners;
        public string k_lookupStringL;
        public string k_lookupStringU;

        // ── Methods ──
        public void GetCursorIndexFromPosition(){} // RVA: 0x7FFD54BC29E0 | overloaded x2
        public void FindNearestLine(){} // RVA: 0x7FFD54BC2CE0
        public void FindNearestCharacterOnLine(){} // RVA: 0x7FFD54BC3010
        public void IsIntersectingRectTransform(){} // RVA: 0x7FFD54BC3710
        public void FindIntersectingCharacter(){} // RVA: 0x7FFD54BC39C0
        public void FindNearestCharacter(){} // RVA: 0x7FFD54BC3EE0
        public void FindIntersectingWord(){} // RVA: 0x7FFD54BC45B0
        public void FindNearestWord(){} // RVA: 0x7FFD54BC52F0
        public void FindIntersectingLine(){} // RVA: 0x7FFD54BC6400
        public void FindIntersectingLink(){} // RVA: 0x7FFD54BC6660
        public void FindNearestLink(){} // RVA: 0x7FFD54BC7200
        public void PointIntersectRectangle(){} // RVA: 0x7FFD54BC82F0
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x7FFD54BC8470
        public void IntersectLinePlane(){} // RVA: 0x7FFD54BC8A20
        public void DistanceToLine(){} // RVA: 0x7FFD54BC8C10
        public void ToLowerFast(){} // RVA: 0x7FFD54BC8DF0
        public void ToUpperFast(){} // RVA: 0x7FFD54BC8E60
        public void ToUpperASCIIFast(){} // RVA: 0x7FFD54BC8ED0
        public void GetHashCode(){} // RVA: 0x7FFD54BC8F50
        public void GetSimpleHashCode(){} // RVA: 0x7FFD54BC2320
        public void GetSimpleHashCodeLowercase(){} // RVA: 0x7FFD54BC9070
        public void HexToInt(){} // RVA: 0x7FFD54BC9190
        public void StringHexToInt(){} // RVA: 0x7FFD54BC92A0
        public void .cctor(){} // RVA: 0x7FFD54BC94A0
    }

    public class TMP_UpdateManager : Object
    {
        public ypointLabel.ct instance;
        public URA.onsDepth<int> m_LayoutQueueLookup; // 0x10
        public URA.woDigitYearMax<ypointLabel.rAtlasTextures> m_LayoutRebuildQueue; // 0x18
        public URA.onsDepth<int> m_GraphicQueueLookup; // 0x20
        public URA.woDigitYearMax<ypointLabel.rAtlasTextures> m_GraphicRebuildQueue; // 0x28
        public URA.onsDepth<int> m_InternalUpdateLookup; // 0x30
        public URA.woDigitYearMax<ypointLabel.rAtlasTextures> m_InternalUpdateQueue; // 0x38
        public URA.onsDepth<int> m_CullingUpdateLookup; // 0x40
        public URA.woDigitYearMax<ypointLabel.rAtlasTextures> m_CullingUpdateQueue; // 0x48
        public object k_RegisterTextObjectForUpdateMarker; // 0x8
        public object k_RegisterTextElementForGraphicRebuildMarker; // 0x10
        public object k_RegisterTextElementForCullingUpdateMarker; // 0x18
        public object k_UnregisterTextObjectForUpdateMarker; // 0x20
        public object k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD54BC9560
        public void .ctor(){} // RVA: 0x7FFD54BC9680
        public void RegisterTextObjectForUpdate(){} // RVA: 0x7FFD54BC9AD0
        public void InternalRegisterTextObjectForUpdate(){} // RVA: 0x7FFD54BC9BF0
        public void RegisterTextElementForLayoutRebuild(){} // RVA: 0x7FFD54BC9CD0
        public void InternalRegisterTextElementForLayoutRebuild(){} // RVA: 0x7FFD54BC9DF0
        public void RegisterTextElementForGraphicRebuild(){} // RVA: 0x7FFD54BC9ED0
        public void InternalRegisterTextElementForGraphicRebuild(){} // RVA: 0x7FFD54BC9FF0
        public void RegisterTextElementForCullingUpdate(){} // RVA: 0x7FFD54BCA0D0
        public void InternalRegisterTextElementForCullingUpdate(){} // RVA: 0x7FFD54BCA1F0
        public void OnCameraPreCull(){} // RVA: 0x7FFD54BCA2D0
        public void DoRebuilds(){} // RVA: 0x7FFD54BCA2E0
        public void UnRegisterTextObjectForUpdate(){} // RVA: 0x7FFD54BCA6E0
        public void UnRegisterTextElementForRebuild(){} // RVA: 0x7FFD54BCA750
        public void InternalUnRegisterTextElementForGraphicRebuild(){} // RVA: 0x7FFD54BCA8E0
        public void InternalUnRegisterTextElementForLayoutRebuild(){} // RVA: 0x7FFD54BCA980
        public void InternalUnRegisterTextObjectForUpdate(){} // RVA: 0x7FFD54BCAA20
        public void .cctor(){} // RVA: 0x7FFD54BCAAC0
    }

    public class TMP_UpdateRegistry : Object
    {
        public ypointLabel.etProperties instance;
        public URA.woDigitYearMax<ePathName117.PathName28> m_LayoutRebuildQueue; // 0x10
        public URA.onsDepth<int> m_LayoutQueueLookup; // 0x18
        public URA.woDigitYearMax<ePathName117.PathName28> m_GraphicRebuildQueue; // 0x20
        public URA.onsDepth<int> m_GraphicQueueLookup; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD54BCAD50
        public void .ctor(){} // RVA: 0x7FFD54BCAE30
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54BCB0C0
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54BCB200
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54BCB350
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54BCB490
        public void PerformUpdateForCanvasRendererObjects(){} // RVA: 0x7FFD54BCB5E0
        public void PerformUpdateForMeshRendererObjects(){} // RVA: 0x7FFD54BCB970
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7FFD54BCB9D0
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54BCBBE0
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54BCBCE0
    }

    public class TMP_WordInfo : ValueType
    {
        // ── Methods ──
        public void GetWord(){} // RVA: 0x7FFD54B594B0
    }

    public class TMPro_EventManager : Object
    {
        public ypointLabel.ypointLabel<object,ypointLabel.Count> COMPUTE_DT_EVENT;
        public ypointLabel.ypointLabel<bool,atrix_Injected> MATERIAL_PROPERTY_EVENT; // 0x8
        public ypointLabel.ypointLabel<bool,?> FONT_PROPERTY_EVENT; // 0x10
        public ypointLabel.ypointLabel<bool,?> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
        public ypointLabel.ypointLabel<bool,?> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
        public ypointLabel.eypointLabelFieldNumber<BuffersImpl,atrix_Injected,atrix_Injected> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
        public ypointLabel.Label<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
        public ypointLabel.Label<?> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
        public ypointLabel.l TMP_SETTINGS_PROPERTY_EVENT; // 0x40
        public ypointLabel.l RESOURCE_LOAD_EVENT; // 0x48
        public ypointLabel.ypointLabel<bool,?> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
        public ypointLabel.Label<?> TEXT_CHANGED_EVENT; // 0x58

        // ── Methods ──
        public void ON_MATERIAL_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B573F0
        public void ON_FONT_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B57490
        public void ON_SPRITE_ASSET_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B57530
        public void ON_TEXTMESHPRO_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B575D0
        public void ON_DRAG_AND_DROP_MATERIAL_CHANGED(){} // RVA: 0x7FFD54B57670
        public void ON_TEXT_STYLE_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B57770
        public void ON_COLOR_GRADIENT_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B57840
        public void ON_TEXT_CHANGED(){} // RVA: 0x7FFD54B578C0
        public void ON_TMP_SETTINGS_CHANGED(){} // RVA: 0x7FFD54B57940
        public void ON_RESOURCES_LOADED(){} // RVA: 0x7FFD54B579B0
        public void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(){} // RVA: 0x7FFD54B57A20
        public void ON_COMPUTE_DT_EVENT(){} // RVA: 0x7FFD54B57AC0
        public void .cctor(){} // RVA: 0x7FFD54B57BA0
    }

    public class TMPro_ExtensionMethods : Object
    {
        // ── Methods ──
        public void ToIntArray(){} // RVA: 0x7FFD54B586E0
        public void ArrayToString(){} // RVA: 0x7FFD54B58780
        public void IntToString(){} // RVA: 0x7FFD54B58A20 | overloaded x2
        public void UintToString(){} // RVA: 0x7FFD54B58950
        public void FindInstanceID(){} // RVA: 0x7FFD4E2ADC40
        public void Compare(){} // RVA: 0x7FFD54B58E10 | overloaded x4
        public void CompareRGB(){} // RVA: 0x7FFD54019BC0 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFD54B58B90
        public void Tint(){} // RVA: 0x7FFD54B58C70 | overloaded x2
        public void MinAlpha(){} // RVA: 0x7FFD54B58D50
    }

    public class TextContainer : UIBehaviour
    {
        public bool hasChanged; // 0x20
        public tionX pivot; // 0x24
        public ypointLabel.faultValue anchorPosition; // 0x2C
        public dRecorder rect; // 0x30
        public bool size; // 0x40
        public bool width; // 0x41
        public bool height; // 0x42
        public amut[] isDefaultWidth; // 0x48
        public amut[] isDefaultHeight; // 0x50
        public get_boundingBoxMode isAutoFitting; // 0x58
        public 16 corners; // 0x68
        public tionX worldCorners;
        public ypointLabel.faultValue margins; // 0x70

        // ── Methods ──
        public void get_hasChanged(){} // RVA: 0x7FFD4E42F9D0
        public void set_hasChanged(){} // RVA: 0x7FFD4E42F9E0
        public void get_pivot(){} // RVA: 0x7FFD54B3C400
        public void set_pivot(){} // RVA: 0x7FFD54B3C420
        public void get_anchorPosition(){} // RVA: 0x7FFD4F0A91D0
        public void set_anchorPosition(){} // RVA: 0x7FFD54B3C4A0
        public void get_rect(){} // RVA: 0x7FFD5387FF30
        public void set_rect(){} // RVA: 0x7FFD54B3C5D0
        public void get_size(){} // RVA: 0x7FFD54B3C630
        public void set_size(){} // RVA: 0x7FFD54B3C650
        public void get_width(){} // RVA: 0x7FFD54B3C6E0
        public void set_width(){} // RVA: 0x7FFD54B3C6F0
        public void get_height(){} // RVA: 0x7FFD54B3C740
        public void set_height(){} // RVA: 0x7FFD54B3C750
        public void get_isDefaultWidth(){} // RVA: 0x7FFD4E3FCC00
        public void get_isDefaultHeight(){} // RVA: 0x7FFD4E5F8A60
        public void get_isAutoFitting(){} // RVA: 0x7FFD4E5F90A0
        public void set_isAutoFitting(){} // RVA: 0x7FFD4E5F9200
        public void get_corners(){} // RVA: 0x7FFD4E3BC730
        public void get_worldCorners(){} // RVA: 0x7FFD4E3E20E0
        public void get_margins(){} // RVA: 0x7FFD4EFEB4D0
        public void set_margins(){} // RVA: 0x7FFD54B3C7A0
        public void get_rectTransform(){} // RVA: 0x7FFD54B3C820
        public void get_textMeshPro(){} // RVA: 0x7FFD54B3C960
        public void Awake(){} // RVA: 0x7FFD54B3CAA0
        public void OnEnable(){} // RVA: 0x7FFD54B3CB90
        public void OnDisable(){} // RVA: 0x7FFD4E341310
        public void OnContainerChanged(){} // RVA: 0x7FFD54B3CBA0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD54B3CF30
        public void SetRect(){} // RVA: 0x7FFD54B3D420
        public void UpdateCorners(){} // RVA: 0x7FFD54B3D470
        public void GetPivot(){} // RVA: 0x7FFD54B3D6B0
        public void GetAnchorPosition(){} // RVA: 0x7FFD54B3D810
        public void .ctor(){} // RVA: 0x7FFD54B3DA20
        public void .cctor(){} // RVA: 0x7FFD54B3DB60
    }

    public class TextMeshPro : TMP_Text
    {
        public int sortingLayerID; // 0x6D0
        public int sortingOrder; // 0x6D4
        public int autoSizeTextContainer; // 0x6D8
        public ileFullDirectoryInformation<ypointLabel.StartTime> textContainer; // 0x6E0
        public bool transform; // 0x6E8
        public bool renderer; // 0x6E9
        public float mesh; // 0x6EC
        public rical meshFilter; // 0x6F0
        public n maskType; // 0x6F8
        public bool m_isFirstAllocation; // 0x700
        public int m_max_characters; // 0x704
        public int m_max_numberOfLines; // 0x708
        public ypointLabel.set_fontFeatureTable[] m_subTextObjects; // 0x710
        public ypointLabel.ToNewAtlasTexture m_maskType; // 0x718
        public tSizeBias m_EnvMapMatrix; // 0x71C
        public amut[] m_RectTransformCorners; // 0x760
        public bool m_isRegisteredForEvents; // 0x768
        public object k_GenerateTextMarker;
        public object k_SetArraySizesMarker; // 0x8
        public object k_GenerateTextPhaseIMarker; // 0x10
        public object k_ParseMarkupTextMarker; // 0x18
        public object k_CharacterLookupMarker; // 0x20
        public object k_HandleGPOSFeaturesMarker; // 0x28
        public object k_CalculateVerticesPositionMarker; // 0x30
        public object k_ComputeTextMetricsMarker; // 0x38
        public object k_HandleVisibleCharacterMarker; // 0x40
        public object k_HandleWhiteSpacesMarker; // 0x48
        public object k_HandleHorizontalLineBreakingMarker; // 0x50
        public object k_HandleVerticalLineBreakingMarker; // 0x58
        public object k_SaveGlyphVertexDataMarker; // 0x60
        public object k_ComputeCharacterAdvanceMarker; // 0x68
        public object k_HandleCarriageReturnMarker; // 0x70
        public object k_HandleLineTerminationMarker; // 0x78
        public object k_SavePageInfoMarker; // 0x80
        public object k_SaveProcessingStatesMarker; // 0x88
        public object k_GenerateTextPhaseIIMarker; // 0x90
        public object k_GenerateTextPhaseIIIMarker; // 0x98

        // ── Methods ──
        public void get_sortingLayerID(){} // RVA: 0x7FFD54B3DBB0
        public void set_sortingLayerID(){} // RVA: 0x7FFD54B3DCF0
        public void get_sortingOrder(){} // RVA: 0x7FFD54B3DE40
        public void set_sortingOrder(){} // RVA: 0x7FFD54B3DF80
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFD54B3E0D0
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFD54B3E0E0
        public void get_textContainer(){} // RVA: 0x7FFD4E919180
        public void get_transform(){} // RVA: 0x7FFD54B3E270
        public void get_renderer(){} // RVA: 0x7FFD54B3E3C0
        public void get_mesh(){} // RVA: 0x7FFD54B3E510
        public void get_meshFilter(){} // RVA: 0x7FFD54B3E6C0
        public void get_maskType(){} // RVA: 0x7FFD54B3E9A0
        public void set_maskType(){} // RVA: 0x7FFD54B3E9B0
        public void SetMask(){} // RVA: 0x7FFD54B41CA0 | overloaded x3
        public void SetVerticesDirty(){} // RVA: 0x7FFD54B3ECD0
        public void SetLayoutDirty(){} // RVA: 0x7FFD54B3EEE0
        public void SetMaterialDirty(){} // RVA: 0x7FFD539B5F00
        public void SetAllDirty(){} // RVA: 0x7FFD54B3F010
        public void Rebuild(){} // RVA: 0x7FFD54B3F060
        public void UpdateMaterial(){} // RVA: 0x7FFD54B3F1B0
        public void UpdateMeshPadding(){} // RVA: 0x7FFD54B3F470
        public void ForceMeshUpdate(){} // RVA: 0x7FFD54B3F600
        public void GetTextInfo(){} // RVA: 0x7FFD54B3F620
        public void ClearMesh(){} // RVA: 0x7FFD54B3F6A0
        public void add_OnPreRenderText(){} // RVA: 0x7FFD54B3F840
        public void remove_OnPreRenderText(){} // RVA: 0x7FFD54B3F940
        public void UpdateGeometry(){} // RVA: 0x7FFD54B3FA40
        public void UpdateVertexData(){} // RVA: 0x7FFD54B3FC70 | overloaded x2
        public void UpdateFontAsset(){} // RVA: 0x7FFD54B3FEA0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void Awake(){} // RVA: 0x7FFD54B3FEC0
        public void OnEnable(){} // RVA: 0x7FFD54B408F0
        public void OnDisable(){} // RVA: 0x7FFD54B40A40
        public void OnDestroy(){} // RVA: 0x7FFD54B40B30
        public void LoadFontAsset(){} // RVA: 0x7FFD54B40CB0
        public void UpdateEnvMapMatrix(){} // RVA: 0x7FFD54B417D0
        public void SetMaskCoordinates(){} // RVA: 0x7FFD54B41F60 | overloaded x2
        public void EnableMasking(){} // RVA: 0x7FFD54B42160
        public void DisableMasking(){} // RVA: 0x7FFD54B423A0
        public void UpdateMask(){} // RVA: 0x7FFD54B42820
        public void GetMaterial(){} // RVA: 0x7FFD54B42A90
        public void GetMaterials(){} // RVA: 0x7FFD54B42CE0
        public void SetSharedMaterial(){} // RVA: 0x7FFD54B42F90
        public void GetSharedMaterials(){} // RVA: 0x7FFD54B43020
        public void SetSharedMaterials(){} // RVA: 0x7FFD54B43230
        public void SetOutlineThickness(){} // RVA: 0x7FFD54B437C0
        public void SetFaceColor(){} // RVA: 0x7FFD54B43B80
        public void SetOutlineColor(){} // RVA: 0x7FFD54B43ED0
        public void CreateMaterialInstance(){} // RVA: 0x7FFD54B44220
        public void SetShaderDepth(){} // RVA: 0x7FFD54B443D0
        public void SetCulling(){} // RVA: 0x7FFD54B44770
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFD54B44CF0
        public void SetArraySizes(){} // RVA: 0x7FFD54B44E40
        public void ComputeMarginSize(){} // RVA: 0x7FFD54B47940
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD54B47B70
        public void OnTransformParentChanged(){} // RVA: 0x7FFD54B47BA0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD54B47BE0
        public void InternalUpdate(){} // RVA: 0x7FFD54B47E80
        public void OnPreRenderObject(){} // RVA: 0x7FFD54B47F90
        public void GenerateTextMesh(){} // RVA: 0x7FFD54B1ED90
        public void GetTextContainerLocalCorners(){} // RVA: 0x7FFD54B482A0
        public void SetMeshFilters(){} // RVA: 0x7FFD54B48400
        public void SetActiveSubMeshes(){} // RVA: 0x7FFD54B48780
        public void SetActiveSubTextObjectRenderers(){} // RVA: 0x7FFD54B48960
        public void DestroySubMeshObjects(){} // RVA: 0x7FFD54B48B90
        public void UpdateSubMeshSortingLayerID(){} // RVA: 0x7FFD54B48D80
        public void UpdateSubMeshSortingOrder(){} // RVA: 0x7FFD54B48FA0
        public void GetCompoundBounds(){} // RVA: 0x7FFD54B491C0
        public void UpdateSDFScale(){} // RVA: 0x7FFD54B49580
        public void .ctor(){} // RVA: 0x7FFD54B49780
        public void .cctor(){} // RVA: 0x7FFD54B498F0
    }

    public class TextMeshProUGUI : TMP_Text
    {
        public bool materialForRendering; // 0x6D0
        public ts autoSizeTextContainer; // 0x6D8
        public ts mesh; // 0x6E0
        public dRecorder canvasRenderer; // 0x6E8
        public bool maskOffset; // 0x6F8
        public ileFullDirectoryInformation<ypointLabel.StartTime> OnPreRenderText; // 0x700
        public bool m_hasFontAssetChanged; // 0x708
        public ypointLabel.dCharactersAndFaceMetrics[] m_subTextObjects; // 0x710
        public float m_previousLossyScaleY; // 0x718
        public amut[] m_RectTransformCorners; // 0x720
        public kingField m_canvasRenderer; // 0x728
        public pad m_canvas; // 0x730
        public float m_CanvasScaleFactor; // 0x738
        public bool m_isFirstAllocation; // 0x73C
        public int m_max_characters; // 0x740
        public atrix_Injected m_baseMaterial; // 0x748
        public bool m_isScrollRegionSet; // 0x750
        public get_boundingBoxMode m_maskOffset; // 0x754
        public tSizeBias m_EnvMapMatrix; // 0x764
        public bool m_isRegisteredForEvents; // 0x7A4
        public object k_GenerateTextMarker;
        public object k_SetArraySizesMarker; // 0x8
        public object k_GenerateTextPhaseIMarker; // 0x10
        public object k_ParseMarkupTextMarker; // 0x18
        public object k_CharacterLookupMarker; // 0x20
        public object k_HandleGPOSFeaturesMarker; // 0x28
        public object k_CalculateVerticesPositionMarker; // 0x30
        public object k_ComputeTextMetricsMarker; // 0x38
        public object k_HandleVisibleCharacterMarker; // 0x40
        public object k_HandleWhiteSpacesMarker; // 0x48
        public object k_HandleHorizontalLineBreakingMarker; // 0x50
        public object k_HandleVerticalLineBreakingMarker; // 0x58
        public object k_SaveGlyphVertexDataMarker; // 0x60
        public object k_ComputeCharacterAdvanceMarker; // 0x68
        public object k_HandleCarriageReturnMarker; // 0x70
        public object k_HandleLineTerminationMarker; // 0x78
        public object k_SavePageInfoMarker; // 0x80
        public object k_SaveProcessingStatesMarker; // 0x88
        public object k_GenerateTextPhaseIIMarker; // 0x90
        public object k_GenerateTextPhaseIIIMarker; // 0x98

        // ── Methods ──
        public void get_materialForRendering(){} // RVA: 0x7FFD54B4A2A0
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFD54B3E0D0
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFD54B4A310
        public void get_mesh(){} // RVA: 0x7FFD4EDCD480
        public void get_canvasRenderer(){} // RVA: 0x7FFD54B4A3A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void SetVerticesDirty(){} // RVA: 0x7FFD54B4A4F0
        public void SetLayoutDirty(){} // RVA: 0x7FFD54B4A640
        public void SetMaterialDirty(){} // RVA: 0x7FFD54B4A790
        public void SetAllDirty(){} // RVA: 0x7FFD54B3F010
        public void DelayedGraphicRebuild(){} // RVA: 0x7FFD54B4A8F0
        public void DelayedMaterialRebuild(){} // RVA: 0x7FFD54B4A990
        public void Rebuild(){} // RVA: 0x7FFD54B4AA30
        public void UpdateSubObjectPivot(){} // RVA: 0x7FFD54B4AB80
        public void GetModifiedMaterial(){} // RVA: 0x7FFD54B4ADA0
        public void UpdateMaterial(){} // RVA: 0x7FFD54B4AF40
        public void get_maskOffset(){} // RVA: 0x7FFD54B4B110
        public void set_maskOffset(){} // RVA: 0x7FFD54B4B120
        public void RecalculateClipping(){} // RVA: 0x7FFD54B4B150
        public void Cull(){} // RVA: 0x7FFD54B4B160
        public void UpdateCulling(){} // RVA: 0x7FFD54B4B580
        public void UpdateMeshPadding(){} // RVA: 0x7FFD54B4B890
        public void InternalCrossFadeColor(){} // RVA: 0x7FFD54B4BA30
        public void InternalCrossFadeAlpha(){} // RVA: 0x7FFD54B4BB20
        public void ForceMeshUpdate(){} // RVA: 0x7FFD54B4BBF0
        public void GetTextInfo(){} // RVA: 0x7FFD54B4BD50
        public void ClearMesh(){} // RVA: 0x7FFD54B4BF00
        public void add_OnPreRenderText(){} // RVA: 0x7FFD54B4C110
        public void remove_OnPreRenderText(){} // RVA: 0x7FFD54B4C210
        public void UpdateGeometry(){} // RVA: 0x7FFD54B4C310
        public void UpdateVertexData(){} // RVA: 0x7FFD54B4C670 | overloaded x2
        public void UpdateFontAsset(){} // RVA: 0x7FFD54B3FEA0
        public void Awake(){} // RVA: 0x7FFD54B4C8F0
        public void OnEnable(){} // RVA: 0x7FFD54B4D250
        public void OnDisable(){} // RVA: 0x7FFD54B4D3F0
        public void OnDestroy(){} // RVA: 0x7FFD54B4D640
        public void LoadFontAsset(){} // RVA: 0x7FFD54B4D920
        public void GetCanvas(){} // RVA: 0x7FFD54B4E360
        public void UpdateEnvMapMatrix(){} // RVA: 0x7FFD54B4E560
        public void EnableMasking(){} // RVA: 0x7FFD54B4EA30
        public void DisableMasking(){} // RVA: 0x7FFD4E341310
        public void UpdateMask(){} // RVA: 0x7FFD54B4EEB0
        public void GetMaterial(){} // RVA: 0x7FFD54B4F5A0
        public void GetMaterials(){} // RVA: 0x7FFD54B4F810
        public void SetSharedMaterial(){} // RVA: 0x7FFD54B42F90
        public void GetSharedMaterials(){} // RVA: 0x7FFD54B4FAD0
        public void SetSharedMaterials(){} // RVA: 0x7FFD54B4FCE0
        public void SetOutlineThickness(){} // RVA: 0x7FFD54B50300
        public void SetFaceColor(){} // RVA: 0x7FFD54B50750
        public void SetOutlineColor(){} // RVA: 0x7FFD54B50A30
        public void SetShaderDepth(){} // RVA: 0x7FFD54B50D10
        public void SetCulling(){} // RVA: 0x7FFD54B50F80
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFD54B51570
        public void SetMeshArrays(){} // RVA: 0x7FFD54B516C0
        public void SetArraySizes(){} // RVA: 0x7FFD54B517D0
        public void ComputeMarginSize(){} // RVA: 0x7FFD54B54460
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD54B54690
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD54B546D0
        public void OnTransformParentChanged(){} // RVA: 0x7FFD54B548E0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD54B54AE0
        public void InternalUpdate(){} // RVA: 0x7FFD54B54F50
        public void OnPreRenderCanvas(){} // RVA: 0x7FFD54B55060
        public void GenerateTextMesh(){} // RVA: 0x7FFD54B2C4D0
        public void GetTextContainerLocalCorners(){} // RVA: 0x7FFD54B554B0
        public void SetActiveSubMeshes(){} // RVA: 0x7FFD54B55610
        public void DestroySubMeshObjects(){} // RVA: 0x7FFD54B557F0
        public void GetCompoundBounds(){} // RVA: 0x7FFD54B559E0
        public void GetCanvasSpaceClippingRect(){} // RVA: 0x7FFD54B55DA0
        public void UpdateSDFScale(){} // RVA: 0x7FFD54B562D0
        public void .ctor(){} // RVA: 0x7FFD54B56570
        public void .cctor(){} // RVA: 0x7FFD54B566D0
    }

    public class TweenRunner`1 : Object
    {
        public glesLength m_CoroutineContainer;
        public mePatterns.e m_Tween;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E2ADC40
        public void Init(){} // RVA: 0x7FFD4E090A40
        public void StartTween(){} // RVA: 0x7FFD4E2ADC40
        public void StopTween(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class VertexGradient : ValueType
    {
        public object topLeft; // 0x10
        public object topRight; // 0x20
        public object bottomLeft; // 0x30
        public object bottomRight; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54ABEF30 | overloaded x2
    }

    public class WordWrapState : ValueType
    {
        public int previous_WordBreak; // 0x10
        public int total_CharacterCount; // 0x14
        public int visible_CharacterCount; // 0x18
        public int visible_SpriteCount; // 0x1C
        public int visible_LinkCount; // 0x20
        public int firstCharacterIndex; // 0x24
        public int firstVisibleCharacterIndex; // 0x28
        public int lastCharacterIndex; // 0x2C
        public int lastVisibleCharIndex; // 0x30
        public int lineNumber; // 0x34
        public float maxCapHeight; // 0x38
        public float maxAscender; // 0x3C
        public float maxDescender; // 0x40
        public float startOfLineAscender; // 0x44
        public float maxLineAscender; // 0x48
        public float maxLineDescender; // 0x4C
        public float pageAscender; // 0x50
        public ypointLabel.CharacterInternal horizontalAlignment; // 0x54
        public float marginLeft; // 0x58
        public float marginRight; // 0x5C
        public float xAdvance; // 0x60
        public float preferredWidth; // 0x64
        public float preferredHeight; // 0x68
        public float previousLineScale; // 0x6C
        public int wordCount; // 0x70
        public ypointLabel.rray fontStyle; // 0x74
        public int italicAngle; // 0x78
        public float fontScaleMultiplier; // 0x7C
        public float currentFontSize; // 0x80
        public float baselineOffset; // 0x84
        public float lineOffset; // 0x88
        public bool isDrivenLineSpacing; // 0x8C
        public float glyphHorizontalAdvanceAdjustment; // 0x90
        public float cSpace; // 0x94
        public float mSpace; // 0x98
        public ypointLabel.StartTime textInfo; // 0xA0
        public ypointLabel._anchorPosition lineInfo; // 0xA8
        public object vertexColor; // 0x104
        public object underlineColor; // 0x108
        public object strikethroughColor; // 0x10C
        public object highlightColor; // 0x110
        public ypointLabel.formAdjustment basicStyleStack; // 0x114
        public ypointLabel.t<int> italicAngleStack; // 0x120
        public ypointLabel.t<?> colorStack; // 0x140
        public ypointLabel.t<?> underlineColorStack; // 0x160
        public ypointLabel.t<?> strikethroughColorStack; // 0x180
        public ypointLabel.t<?> highlightColorStack; // 0x1A0
        public ypointLabel.t<ypointLabel.teMonoColorTexture> highlightStateStack; // 0x1C0
        public ypointLabel.t<ypointLabel.ld> colorGradientStack; // 0x1F0
        public ypointLabel.t<float> sizeStack; // 0x218
        public ypointLabel.t<float> indentStack; // 0x238
        public ypointLabel.t<ypointLabel.tAssetData> fontWeightStack; // 0x258
        public ypointLabel.t<int> styleStack; // 0x278
        public ypointLabel.t<float> baselineStack; // 0x298
        public ypointLabel.t<int> actionStack; // 0x2B8
        public ypointLabel.t<ypointLabel.RectId> materialReferenceStack; // 0x2D8
        public ypointLabel.t<ypointLabel.CharacterInternal> lineJustificationStack; // 0x330
        public int spriteAnimationID; // 0x350
        public ypointLabel.urces currentFontAsset; // 0x358
        public ypointLabel.? currentSpriteAsset; // 0x360
        public atrix_Injected currentMaterial; // 0x368
        public int currentMaterialIndex; // 0x370
        public ypointLabel.r meshExtents; // 0x374
        public bool tagNoParsing; // 0x384
        public bool isNonBreakingSpace; // 0x385
    }

}