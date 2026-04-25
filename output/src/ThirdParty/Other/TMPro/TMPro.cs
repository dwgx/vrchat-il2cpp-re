// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.TMPro
// Classes: 90
// Methods: 1487

namespace ThirdParty.Other.TMPro
{
    public class CaretInfo : ValueType
    {
        public int index; // 0x10
        public 0x6B21BE50 position; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
    }

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

    public class ColorTween : ValueType
    {
        public ColorTweenCallback startColor; // 0x10
        public UnityEngine.Color targetColor; // 0x18
        public UnityEngine.Color tweenMode; // 0x28
        public 0x6B219670 duration; // 0x38
        public float ignoreTimeScale; // 0x3C
        public bool m_IgnoreTimeScale; // 0x40

        // ── Methods ──
        public void get_startColor(){} // RVA: 0x7FFAC4A927D0
        public void set_startColor(){} // RVA: 0x7FFAC4A98120
        public void get_targetColor(){} // RVA: 0x7FFAC35D3330
        public void set_targetColor(){} // RVA: 0x7FFAC35D34F0
        public void get_tweenMode(){} // RVA: 0x7FFAC32EC4C0
        public void set_tweenMode(){} // RVA: 0x7FFAC369A6E0
        public void get_duration(){} // RVA: 0x7FFAC33EAB80
        public void set_duration(){} // RVA: 0x7FFAC33EA9D0
        public void get_ignoreTimeScale(){} // RVA: 0x7FFAC2F47450
        public void set_ignoreTimeScale(){} // RVA: 0x7FFAC2F47460
        public void TweenValue(){} // RVA: 0x7FFAC973A780
        public void AddOnChangedCallback(){} // RVA: 0x7FFAC973A8B0
        public void GetIgnoreTimescale(){} // RVA: 0x7FFAC2F47450
        public void GetDuration(){} // RVA: 0x7FFAC33EAB80
        public void ValidTarget(){} // RVA: 0x7FFAC3BB0800
    }

    public class Compute_DT_EventArgs : Object
    {
        public 0x6B218D28 EventType; // 0x10
        public float ProgressPercentage; // 0x14
        public UnityEngine.Color[] Colors; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0 | overloaded x2
    }

    public class Extents : ValueType
    {
        public TMPro.Extents zero;
        public TMPro.Extents uninitialized; // 0x10
        public UnityEngine.Vector2 min; // 0x10
        public UnityEngine.Vector2 max; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC485CA00
        public void ToString(){} // RVA: 0x7FFAC9739620
        public void .cctor(){} // RVA: 0x7FFAC97397D0
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FastAction : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action> delegates; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Action,System.Collections.Generic.LinkedListNode`1<System.Action>> lookup; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9719FD0
        public void Remove(){} // RVA: 0x7FFAC971A0C0
        public void Call(){} // RVA: 0x7FFAC971A3F0
        public void .ctor(){} // RVA: 0x7FFAC971A4A0
    }

    public class FastAction`1 : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action`1<bool>> delegates; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Action`1<bool>,System.Collections.Generic.LinkedListNode`1<System.Action`1<bool>>> lookup; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC5C6D000
        public void Remove(){} // RVA: 0x7FFAC5C6D0D0
        public void Call(){} // RVA: 0x7FFAC5C6D3D0
        public void .ctor(){} // RVA: 0x7FFAC5C6D440
    }

    public class FastAction`2 : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action`2<object,TMPro.Compute_DT_EventArgs>> delegates; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Action`2<object,TMPro.Compute_DT_EventArgs>,System.Collections.Generic.LinkedListNode`1<System.Action`2<object,TMPro.Compute_DT_EventArgs>>> lookup; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC5C6D000
        public void Remove(){} // RVA: 0x7FFAC5C6D0D0
        public void Call(){} // RVA: 0x7FFAC5C6DCA0
        public void .ctor(){} // RVA: 0x7FFAC5C6DB50
    }

    public class FastAction`3 : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>> delegates; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>>> lookup; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC5C6D000
        public void Remove(){} // RVA: 0x7FFAC5C6D0D0
        public void Call(){} // RVA: 0x7FFAC5C6E0E0
        public void .ctor(){} // RVA: 0x7FFAC5C6E180
    }

    public class FloatTween : ValueType
    {
        public FloatTweenCallback startValue; // 0x10
        public float targetValue; // 0x18
        public float duration; // 0x1C
        public float ignoreTimeScale; // 0x20
        public bool m_IgnoreTimeScale; // 0x24

        // ── Methods ──
        public void get_startValue(){} // RVA: 0x7FFAC4A9B8E0
        public void set_startValue(){} // RVA: 0x7FFAC4A9B920
        public void get_targetValue(){} // RVA: 0x7FFAC4A9B8D0
        public void set_targetValue(){} // RVA: 0x7FFAC4A9B8C0
        public void get_duration(){} // RVA: 0x7FFAC304B320
        public void set_duration(){} // RVA: 0x7FFAC304B330
        public void get_ignoreTimeScale(){} // RVA: 0x7FFAC3070BD0
        public void set_ignoreTimeScale(){} // RVA: 0x7FFAC3070BE0
        public void TweenValue(){} // RVA: 0x7FFAC973AA00
        public void AddOnChangedCallback(){} // RVA: 0x7FFAC973AA90
        public void GetIgnoreTimescale(){} // RVA: 0x7FFAC3070BD0
        public void GetDuration(){} // RVA: 0x7FFAC304B320
        public void ValidTarget(){} // RVA: 0x7FFAC3BB0800
    }

    public class FontAssetCreationSettings : ValueType
    {
        public string sourceFontFileName; // 0x10
        public string sourceFontFileGUID; // 0x18
        public int pointSizeSamplingMode; // 0x20
        public int pointSize; // 0x24
        public int padding; // 0x28
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

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9750B10
    }

    public class GlyphPairKey : ValueType
    {
        public uint firstGlyphIndex; // 0x10
        public uint secondGlyphIndex; // 0x14
        public uint key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9753600 | overloaded x2
    }

    public class GlyphValueRecord_Legacy : ValueType
    {
        public float xPlacement; // 0x10
        public float yPlacement; // 0x14
        public float xAdvance; // 0x18
        public float yAdvance; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9750DA0
        public void op_Addition(){} // RVA: 0x7FFAC969E740
    }

    public class HighlightState : ValueType
    {
        public UnityEngine.Color32 color; // 0x10
        public TMPro.TMP_Offset padding; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F2100
        public void op_Equality(){} // RVA: 0x7FFAC973A0C0
        public void op_Inequality(){} // RVA: 0x7FFAC973A200
        public void GetHashCode(){} // RVA: 0x7FFAC973A340
        public void Equals(){} // RVA: 0x7FFAC973A410 | overloaded x2
    }

    public class ITextElement
    {
        public object sharedMaterial;

        // ── Methods ──
        public void get_sharedMaterial(){} // RVA: 0x7FFAC2C58E90
        public void Rebuild(){} // RVA: 0x7FFAC2C70ED0
        public void GetInstanceID(){} // RVA: 0x7FFAC2C59960
    }

    public class ITextPreprocessor
    {
        // ── Methods ──
        public void PreprocessText(){} // RVA: 0x7FFAC2C58F40
    }

    public class ITweenValue
    {
        public object ignoreTimeScale;
        public object duration;

        // ── Methods ──
        public void TweenValue(){} // RVA: 0x7FFAC2C7E480
        public void get_ignoreTimeScale(){} // RVA: 0x7FFAC2C59D00
        public void get_duration(){} // RVA: 0x7FFAC2C6D880
        public void ValidTarget(){} // RVA: 0x7FFAC2C59D00
    }

    public class KerningPair : Object
    {
        public uint firstGlyph; // 0x10
        public TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments; // 0x14
        public uint secondGlyph; // 0x24
        public TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments; // 0x28
        public float ignoreSpacingAdjustments; // 0x38
        public TMPro.KerningPair empty;
        public bool m_IgnoreSpacingAdjustments; // 0x3C

        // ── Methods ──
        public void get_firstGlyph(){} // RVA: 0x7FFAC2F6E5C0
        public void set_firstGlyph(){} // RVA: 0x7FFAC2F240C0
        public void get_firstGlyphAdjustments(){} // RVA: 0x7FFAC56EA930
        public void get_secondGlyph(){} // RVA: 0x7FFAC3921980
        public void set_secondGlyph(){} // RVA: 0x7FFAC41674D0
        public void get_secondGlyphAdjustments(){} // RVA: 0x7FFAC3BCF020
        public void get_ignoreSpacingAdjustments(){} // RVA: 0x7FFAC30864E0
        public void .ctor(){} // RVA: 0x7FFAC9750DF0 | overloaded x3
        public void ConvertLegacyKerningData(){} // RVA: 0x7FFAC9750E10
        public void .cctor(){} // RVA: 0x7FFAC9750E20
    }

    public class KerningPairKey : ValueType
    {
        public uint ascii_Left; // 0x10
        public uint ascii_Right; // 0x14
        public uint key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9750D80
    }

    public class KerningTable : Object
    {
        public System.Collections.Generic.List`1<TMPro.KerningPair> kerningPairs; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9750EE0
        public void AddKerningPair(){} // RVA: 0x7FFAC97510E0 | overloaded x2
        public void AddGlyphPairAdjustmentRecord(){} // RVA: 0x7FFAC9751240
        public void RemoveKerningPair(){} // RVA: 0x7FFAC97514D0 | overloaded x2
        public void SortKerningPairs(){} // RVA: 0x7FFAC9751530
    }

    public class MaterialReference : ValueType
    {
        public int index; // 0x10
        public TMPro.TMP_FontAsset fontAsset; // 0x18
        public TMPro.TMP_SpriteAsset spriteAsset; // 0x20
        public UnityEngine.Material material; // 0x28
        public bool isDefaultMaterial; // 0x30
        public bool isFallbackMaterial; // 0x31
        public UnityEngine.Material fallbackMaterial; // 0x38
        public float padding; // 0x40
        public int referenceCount; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC971B980
        public void Contains(){} // RVA: 0x7FFAC971BB50
        public void AddMaterialReference(){} // RVA: 0x7FFAC971C060 | overloaded x2
    }

    public class MaterialReferenceManager : Object
    {
        public TMPro.MaterialReferenceManager instance;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.Material> m_FontMaterialReferenceLookup; // 0x10
        public System.Collections.Generic.Dictionary`2<int,TMPro.TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
        public System.Collections.Generic.Dictionary`2<int,TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
        public System.Collections.Generic.Dictionary`2<int,TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC971A5F0
        public void AddFontAsset(){} // RVA: 0x7FFAC971A6D0
        public void AddFontAssetInternal(){} // RVA: 0x7FFAC971A7F0
        public void AddSpriteAsset(){} // RVA: 0x7FFAC971AB30 | overloaded x2
        public void AddSpriteAssetInternal(){} // RVA: 0x7FFAC971AC60 | overloaded x2
        public void AddFontMaterial(){} // RVA: 0x7FFAC971AD80
        public void AddFontMaterialInternal(){} // RVA: 0x7FFAC971AE10
        public void AddColorGradientPreset(){} // RVA: 0x7FFAC971AEA0
        public void AddColorGradientPreset_Internal(){} // RVA: 0x7FFAC971AF70
        public void Contains(){} // RVA: 0x7FFAC971B0B0 | overloaded x2
        public void TryGetFontAsset(){} // RVA: 0x7FFAC971B130
        public void TryGetFontAssetInternal(){} // RVA: 0x7FFAC971B1F0
        public void TryGetSpriteAsset(){} // RVA: 0x7FFAC971B2A0
        public void TryGetSpriteAssetInternal(){} // RVA: 0x7FFAC971B360
        public void TryGetColorGradientPreset(){} // RVA: 0x7FFAC971B410
        public void TryGetColorGradientPresetInternal(){} // RVA: 0x7FFAC971B4D0
        public void TryGetMaterial(){} // RVA: 0x7FFAC971B580
        public void TryGetMaterialInternal(){} // RVA: 0x7FFAC971B640
        public void .ctor(){} // RVA: 0x7FFAC971B6F0
    }

    public class Mesh_Extents : ValueType
    {
        public UnityEngine.Vector2 min; // 0x10
        public UnityEngine.Vector2 max; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC485CA00
        public void ToString(){} // RVA: 0x7FFAC97398D0
    }

    public class RichTextTagAttribute : ValueType
    {
        public int nameHashCode; // 0x10
        public int valueHashCode; // 0x14
        public 0x6B21AED8 valueType; // 0x18
        public int valueStartIndex; // 0x1C
        public int valueLength; // 0x20
        public 0x6B21AF30 unitType; // 0x24
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFAC9787770
        public void SetEquatableStruct(){} // RVA: 0x7FFAC2E8DC40
        public void SetStruct(){} // RVA: 0x7FFAC2E8DC40
        public void SetClass(){} // RVA: 0x7FFAC2E8DC40
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
        public UnityEngine.Shader k_ShaderRef_MobileSDF; // 0x130
        public UnityEngine.Shader k_ShaderRef_MobileBitmap; // 0x138

        // ── Methods ──
        public void get_ShaderRef_MobileSDF(){} // RVA: 0x7FFAC9791890
        public void get_ShaderRef_MobileBitmap(){} // RVA: 0x7FFAC9791A60
        public void .cctor(){} // RVA: 0x7FFAC9791C30
        public void GetShaderPropertyIDs(){} // RVA: 0x7FFAC9792250
        public void UpdateShaderRatios(){} // RVA: 0x7FFAC9793D00
        public void GetFontExtent(){} // RVA: 0x7FFAC9794390
        public void IsMaskingEnabled(){} // RVA: 0x7FFAC97943E0
        public void GetPadding(){} // RVA: 0x7FFAC97950C0 | overloaded x2
    }

    public class TMP_Asset : ScriptableObject
    {
        public int instanceID; // 0x18
        public int hashCode; // 0x1C
        public UnityEngine.Material material; // 0x20
        public int materialHashCode; // 0x28

        // ── Methods ──
        public void get_instanceID(){} // RVA: 0x7FFAC9739A80
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class TMP_Character : TMP_TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9739C80 | overloaded x4
    }

    public class TMP_CharacterInfo : ValueType
    {
        public char character; // 0x10
        public int index; // 0x14
        public int stringLength; // 0x18
        public 0x6B21B718 elementType; // 0x1C
        public TMPro.TMP_TextElement textElement; // 0x20
        public TMPro.TMP_FontAsset fontAsset; // 0x28
        public TMPro.TMP_SpriteAsset spriteAsset; // 0x30
        public int spriteIndex; // 0x38
        public UnityEngine.Material material; // 0x40
        public int materialReferenceIndex; // 0x48
        public bool isUsingAlternateTypeface; // 0x4C
        public float pointSize; // 0x50
        public int lineNumber; // 0x54
        public int pageNumber; // 0x58
        public int vertexIndex; // 0x5C
        public TMPro.TMP_Vertex vertex_BL; // 0x60
        public TMPro.TMP_Vertex vertex_TL; // 0x88
        public TMPro.TMP_Vertex vertex_TR; // 0xB0
        public TMPro.TMP_Vertex vertex_BR; // 0xD8
        public UnityEngine.Vector3 topLeft; // 0x100
        public UnityEngine.Vector3 bottomLeft; // 0x10C
        public UnityEngine.Vector3 topRight; // 0x118
        public UnityEngine.Vector3 bottomRight; // 0x124
        public float origin; // 0x130
        public float xAdvance; // 0x134
        public float ascender; // 0x138
        public float baseLine; // 0x13C
        public float descender; // 0x140
        public float adjustedAscender; // 0x144
        public float adjustedDescender; // 0x148
        public float aspectRatio; // 0x14C
        public float scale; // 0x150
        public UnityEngine.Color32 color; // 0x154
        public UnityEngine.Color32 underlineColor; // 0x158
        public int underlineVertexIndex; // 0x15C
        public UnityEngine.Color32 strikethroughColor; // 0x160
        public int strikethroughVertexIndex; // 0x164
        public UnityEngine.Color32 highlightColor; // 0x168
        public TMPro.HighlightState highlightState; // 0x16C
        public 0x6B21B8D0 style; // 0x180
        public bool isVisible; // 0x184
    }

    public class TMP_ColorGradient : ScriptableObject
    {
        public 0x6B2194B8 colorMode; // 0x18
        public UnityEngine.Color topLeft; // 0x1C
        public UnityEngine.Color topRight; // 0x2C
        public UnityEngine.Color bottomLeft; // 0x3C
        public UnityEngine.Color bottomRight; // 0x4C
        public 0x6B2194B8 k_DefaultColorMode;
        public UnityEngine.Color k_DefaultColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC973A5B0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC973A620
    }

    public class TMP_Compatibility : Object
    {
        // ── Methods ──
        public void ConvertTextAlignmentEnumValues(){} // RVA: 0x7FFAC973A670
    }

    public class TMP_DefaultControls : Object
    {
        public float kWidth;
        public float kThickHeight;
        public float kThinHeight;
        public UnityEngine.Vector2 s_TextElementSize;
        public UnityEngine.Vector2 s_ThickElementSize; // 0x8
        public UnityEngine.Vector2 s_ThinElementSize; // 0x10
        public UnityEngine.Color s_DefaultSelectableColor; // 0x18
        public UnityEngine.Color s_TextColor; // 0x28

        // ── Methods ──
        public void CreateUIElementRoot(){} // RVA: 0x7FFAC973ACA0
        public void CreateUIObject(){} // RVA: 0x7FFAC973AD90
        public void SetDefaultTextValues(){} // RVA: 0x7FFAC973AE60
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7FFAC973AF60
        public void SetParentAndAlign(){} // RVA: 0x7FFAC973AFC0
        public void SetLayerRecursively(){} // RVA: 0x7FFAC973B1C0
        public void CreateScrollbar(){} // RVA: 0x7FFAC973B3D0
        public void CreateButton(){} // RVA: 0x7FFAC973B950
        public void CreateText(){} // RVA: 0x7FFAC973BE20
        public void CreateInputField(){} // RVA: 0x7FFAC973BEE0
        public void CreateDropdown(){} // RVA: 0x7FFAC973CD80
        public void .cctor(){} // RVA: 0x7FFAC973ECB0
    }

    public class TMP_Dropdown : Selectable
    {
        public UnityEngine.RectTransform template; // 0x100
        public TMPro.TMP_Text captionText; // 0x108
        public UnityEngine.UI.Image captionImage; // 0x110
        public UnityEngine.UI.Graphic placeholder; // 0x118
        public TMPro.TMP_Text itemText; // 0x120
        public UnityEngine.UI.Image itemImage; // 0x128
        public int options; // 0x130
        public OptionDataList onValueChanged; // 0x138
        public DropdownEvent alphaFadeSpeed; // 0x140
        public float value; // 0x148
        public UnityEngine.GameObject IsExpanded; // 0x150
        public UnityEngine.GameObject m_Blocker; // 0x158
        public System.Collections.Generic.List`1<DropdownItem> m_Items; // 0x160
        public TMPro.TweenRunner`1<TMPro.FloatTween> m_AlphaTweenRunner; // 0x168
        public bool validTemplate; // 0x170
        public UnityEngine.Coroutine m_Coroutine; // 0x178
        public OptionData s_NoOptionData;

        // ── Methods ──
        public void get_template(){} // RVA: 0x7FFAC34F6C80
        public void set_template(){} // RVA: 0x7FFAC973ED70
        public void get_captionText(){} // RVA: 0x7FFAC36D1F40
        public void set_captionText(){} // RVA: 0x7FFAC973EDD0
        public void get_captionImage(){} // RVA: 0x7FFAC354B170
        public void set_captionImage(){} // RVA: 0x7FFAC973EE30
        public void get_placeholder(){} // RVA: 0x7FFAC33BC6D0
        public void set_placeholder(){} // RVA: 0x7FFAC973EE90
        public void get_itemText(){} // RVA: 0x7FFAC313CBB0
        public void set_itemText(){} // RVA: 0x7FFAC973EEF0
        public void get_itemImage(){} // RVA: 0x7FFAC35466F0
        public void set_itemImage(){} // RVA: 0x7FFAC973EF50
        public void get_options(){} // RVA: 0x7FFAC973EFB0
        public void set_options(){} // RVA: 0x7FFAC973EFD0
        public void get_onValueChanged(){} // RVA: 0x7FFAC2F8C5F0
        public void set_onValueChanged(){} // RVA: 0x7FFAC2F8C600
        public void get_alphaFadeSpeed(){} // RVA: 0x7FFAC973F050
        public void set_alphaFadeSpeed(){} // RVA: 0x7FFAC973F060
        public void get_value(){} // RVA: 0x7FFAC33BC1B0
        public void set_value(){} // RVA: 0x7FFAC973F070
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC973F080
        public void SetValue(){} // RVA: 0x7FFAC973F090
        public void get_IsExpanded(){} // RVA: 0x7FFAC973F2D0
        public void .ctor(){} // RVA: 0x7FFAC973F3A0
        public void Awake(){} // RVA: 0x7FFAC973F670
        public void Start(){} // RVA: 0x7FFAC973F980
        public void OnDisable(){} // RVA: 0x7FFAC973FAB0
        public void RefreshShownValue(){} // RVA: 0x7FFAC973FC10
        public void AddOptions(){} // RVA: 0x7FFAC9740340 | overloaded x3
        public void ClearOptions(){} // RVA: 0x7FFAC9740500
        public void SetupTemplate(){} // RVA: 0x7FFAC9740640
        public void GetOrAddComponent(){} // RVA: 0x7FFAC2E8DC40
        public void OnPointerClick(){} // RVA: 0x7FFAC9741440
        public void OnSubmit(){} // RVA: 0x7FFAC9741440
        public void OnCancel(){} // RVA: 0x7FFAC9741450
        public void Show(){} // RVA: 0x7FFAC9741460
        public void CreateBlocker(){} // RVA: 0x7FFAC9742D40
        public void DestroyBlocker(){} // RVA: 0x7FFAC9743770
        public void CreateDropdownList(){} // RVA: 0x7FFAC97437C0
        public void DestroyDropdownList(){} // RVA: 0x7FFAC9743830
        public void CreateItem(){} // RVA: 0x7FFAC9743880
        public void DestroyItem(){} // RVA: 0x7FFAC2F21310
        public void AddItem(){} // RVA: 0x7FFAC97438F0
        public void AlphaFadeList(){} // RVA: 0x7FFAC9744080 | overloaded x2
        public void SetAlpha(){} // RVA: 0x7FFAC9744240
        public void Hide(){} // RVA: 0x7FFAC9744360
        public void DelayedDestroyDropdownList(){} // RVA: 0x7FFAC9744710
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7FFAC97447D0
        public void OnSelectItem(){} // RVA: 0x7FFAC9744B50
        public void .cctor(){} // RVA: 0x7FFAC9744DE0
    }

    public class TMP_FontAsset : TMP_Asset
    {
        public string version; // 0x30
        public string sourceFontFile; // 0x38
        public UnityEngine.Font atlasPopulationMode; // 0x40
        public 0x6B219BF0 faceInfo; // 0x48
        public UnityEngine.TextCore.FaceInfo glyphTable; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> glyphLookupTable; // 0xB0
        public System.Collections.Generic.Dictionary`2<uint,UnityEngine.TextCore.Glyph> characterTable; // 0xB8
        public System.Collections.Generic.List`1<TMPro.TMP_Character> characterLookupTable; // 0xC0
        public System.Collections.Generic.Dictionary`2<uint,TMPro.TMP_Character> atlasTexture; // 0xC8
        public UnityEngine.Texture2D atlasTextures; // 0xD0
        public UnityEngine.Texture2D[] atlasTextureCount; // 0xD8
        public int isMultiAtlasTexturesEnabled; // 0xE0
        public bool clearDynamicDataOnBuild; // 0xE4
        public bool usedGlyphRects; // 0xE5
        public System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect> freeGlyphRects; // 0xE8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect> fontInfo; // 0xF0
        public TMPro.FaceInfo_Legacy atlasWidth; // 0xF8
        public UnityEngine.Texture2D atlasHeight; // 0x100
        public int atlasPadding; // 0x108
        public int atlasRenderMode; // 0x10C
        public int fontFeatureTable; // 0x110
        public 0x6B2D23B8 fallbackFontAssetTable; // 0x114
        public System.Collections.Generic.List`1<TMPro.TMP_Glyph> creationSettings; // 0x118
        public TMPro.KerningTable fontWeightTable; // 0x120
        public TMPro.TMP_FontFeatureTable m_FontFeatureTable; // 0x128
        public System.Collections.Generic.List`1<TMPro.TMP_FontAsset> fallbackFontAssets; // 0x130
        public System.Collections.Generic.List`1<TMPro.TMP_FontAsset> m_FallbackFontAssetTable; // 0x138
        public TMPro.FontAssetCreationSettings m_CreationSettings; // 0x140
        public TMPro.TMP_FontWeightPair[] m_FontWeightTable; // 0x198
        public TMPro.TMP_FontWeightPair[] fontWeights; // 0x1A0
        public float normalStyle; // 0x1A8
        public float normalSpacingOffset; // 0x1AC
        public float boldStyle; // 0x1B0
        public float boldSpacing; // 0x1B4
        public byte italicStyle; // 0x1B8
        public byte tabSize; // 0x1B9
        public bool IsFontAssetLookupTablesDirty; // 0x1BA
        public Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
        public Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
        public Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
        public string s_DefaultMaterialSuffix; // 0x38
        public System.Collections.Generic.HashSet`1<int> FallbackSearchQueryLookup; // 0x1C0
        public System.Collections.Generic.HashSet`1<int> k_SearchedFontAssetLookup; // 0x40
        public System.Collections.Generic.List`1<TMPro.TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
        public System.Collections.Generic.HashSet`1<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
        public System.Collections.Generic.List`1<TMPro.TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
        public System.Collections.Generic.HashSet`1<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> m_GlyphsToRender; // 0x1C8
        public System.Collections.Generic.List`1<UnityEngine.TextCore.Glyph> m_GlyphsRendered; // 0x1D0
        public System.Collections.Generic.List`1<uint> m_GlyphIndexList; // 0x1D8
        public System.Collections.Generic.List`1<uint> m_GlyphIndexListNewlyAdded; // 0x1E0
        public System.Collections.Generic.List`1<uint> m_GlyphsToAdd; // 0x1E8
        public System.Collections.Generic.HashSet`1<uint> m_GlyphsToAddLookup; // 0x1F0
        public System.Collections.Generic.List`1<TMPro.TMP_Character> m_CharactersToAdd; // 0x1F8
        public System.Collections.Generic.HashSet`1<uint> m_CharactersToAddLookup; // 0x200
        public System.Collections.Generic.List`1<uint> s_MissingCharacterList; // 0x208
        public System.Collections.Generic.HashSet`1<uint> m_MissingUnicodesFromFontFile; // 0x210
        public uint[] k_GlyphIndexArray; // 0x68

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFAC31D95E0
        public void set_version(){} // RVA: 0x7FFAC2F4F890
        public void get_sourceFontFile(){} // RVA: 0x7FFAC2F9E740
        public void set_sourceFontFile(){} // RVA: 0x7FFAC2F49200
        public void get_atlasPopulationMode(){} // RVA: 0x7FFAC2FC20C0
        public void set_atlasPopulationMode(){} // RVA: 0x7FFAC2FC20D0
        public void get_faceInfo(){} // RVA: 0x7FFAC6B22550
        public void set_faceInfo(){} // RVA: 0x7FFAC9745290
        public void get_glyphTable(){} // RVA: 0x7FFAC2F8C040
        public void set_glyphTable(){} // RVA: 0x7FFAC2F8C050
        public void get_glyphLookupTable(){} // RVA: 0x7FFAC9745320
        public void get_characterTable(){} // RVA: 0x7FFAC2F8C120
        public void set_characterTable(){} // RVA: 0x7FFAC2F8C130
        public void get_characterLookupTable(){} // RVA: 0x7FFAC9745360
        public void get_atlasTexture(){} // RVA: 0x7FFAC97453A0
        public void get_atlasTextures(){} // RVA: 0x7FFAC3540F70
        public void set_atlasTextures(){} // RVA: 0x7FFAC2FA28A0
        public void get_atlasTextureCount(){} // RVA: 0x7FFAC97454F0
        public void get_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFAC88C0AF0
        public void set_isMultiAtlasTexturesEnabled(){} // RVA: 0x7FFAC8989B20
        public void get_clearDynamicDataOnBuild(){} // RVA: 0x7FFAC88C0FF0
        public void set_clearDynamicDataOnBuild(){} // RVA: 0x7FFAC9745500
        public void get_usedGlyphRects(){} // RVA: 0x7FFAC2FA2970
        public void set_usedGlyphRects(){} // RVA: 0x7FFAC2FA2980
        public void get_freeGlyphRects(){} // RVA: 0x7FFAC2F8C2A0
        public void set_freeGlyphRects(){} // RVA: 0x7FFAC2F8C2B0
        public void get_fontInfo(){} // RVA: 0x7FFAC3331F50
        public void get_atlasWidth(){} // RVA: 0x7FFAC4599E70
        public void set_atlasWidth(){} // RVA: 0x7FFAC4597C50
        public void get_atlasHeight(){} // RVA: 0x7FFAC4597A10
        public void set_atlasHeight(){} // RVA: 0x7FFAC459AD60
        public void get_atlasPadding(){} // RVA: 0x7FFAC39471E0
        public void set_atlasPadding(){} // RVA: 0x7FFAC4597C80
        public void get_atlasRenderMode(){} // RVA: 0x7FFAC9745510
        public void set_atlasRenderMode(){} // RVA: 0x7FFAC9745520
        public void get_fontFeatureTable(){} // RVA: 0x7FFAC35466F0
        public void set_fontFeatureTable(){} // RVA: 0x7FFAC39C51C0
        public void get_fallbackFontAssetTable(){} // RVA: 0x7FFAC35422C0
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFAC36D84B0
        public void get_creationSettings(){} // RVA: 0x7FFAC9745530
        public void set_creationSettings(){} // RVA: 0x7FFAC9745580
        public void get_fontWeightTable(){} // RVA: 0x7FFAC3541C80
        public void set_fontWeightTable(){} // RVA: 0x7FFAC39C8ED0
        public void CreateFontAsset(){} // RVA: 0x7FFAC97456A0 | overloaded x2
        public void Awake(){} // RVA: 0x7FFAC97463F0
        public void ReadFontAssetDefinition(){} // RVA: 0x7FFAC97464E0
        public void InitializeDictionaryLookupTables(){} // RVA: 0x7FFAC9746840
        public void InitializeGlyphLookupDictionary(){} // RVA: 0x7FFAC9746870
        public void InitializeCharacterLookupDictionary(){} // RVA: 0x7FFAC9746C10
        public void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(){} // RVA: 0x7FFAC9746FA0
        public void AddSynthesizedCharactersAndFaceMetrics(){} // RVA: 0x7FFAC9747250
        public void AddSynthesizedCharacter(){} // RVA: 0x7FFAC9747590
        public void AddCharacterToLookupCache(){} // RVA: 0x7FFAC9747870
        public void SortCharacterTable(){} // RVA: 0x7FFAC9747960
        public void SortGlyphTable(){} // RVA: 0x7FFAC9747BA0
        public void SortFontFeatureTable(){} // RVA: 0x7FFAC9747DE0
        public void SortAllTables(){} // RVA: 0x7FFAC9747E10
        public void HasCharacter(){} // RVA: 0x7FFAC9747ED0 | overloaded x2
        public void HasCharacter_Internal(){} // RVA: 0x7FFAC97486D0
        public void HasCharacters(){} // RVA: 0x7FFAC9749560 | overloaded x3
        public void GetCharacters(){} // RVA: 0x7FFAC9749630
        public void GetCharactersArray(){} // RVA: 0x7FFAC97497C0
        public void GetGlyphIndex(){} // RVA: 0x7FFAC97498A0
        public void RegisterFontAssetForFontFeatureUpdate(){} // RVA: 0x7FFAC9749A00
        public void UpdateFontFeaturesForFontAssetsInQueue(){} // RVA: 0x7FFAC9749B10
        public void RegisterFontAssetForAtlasTextureUpdate(){} // RVA: 0x7FFAC9749D10
        public void UpdateAtlasTexturesForFontAssetsInQueue(){} // RVA: 0x7FFAC9749E20
        public void TryAddCharacters(){} // RVA: 0x7FFAC974AE40 | overloaded x4
        public void TryAddCharacterInternal(){} // RVA: 0x7FFAC974BD10
        public void TryGetCharacter_and_QueueRenderToTexture(){} // RVA: 0x7FFAC974C620
        public void TryAddGlyphsToAtlasTextures(){} // RVA: 0x7FFAC2F21310
        public void TryAddGlyphsToNewAtlasTexture(){} // RVA: 0x7FFAC974CC20
        public void SetupNewAtlasTexture(){} // RVA: 0x7FFAC974D0E0
        public void UpdateAtlasTexture(){} // RVA: 0x7FFAC974D3F0
        public void UpdateGlyphAdjustmentRecords(){} // RVA: 0x7FFAC2F21310 | overloaded x4
        public void CopyListDataToArray(){} // RVA: 0x7FFAC2C79B30
        public void ClearFontAssetData(){} // RVA: 0x7FFAC974DCC0
        public void ClearFontAssetDataInternal(){} // RVA: 0x7FFAC974DD00
        public void UpdateFontAssetData(){} // RVA: 0x7FFAC974DD30
        public void ClearFontAssetTables(){} // RVA: 0x7FFAC974DEB0
        public void ClearAtlasTextures(){} // RVA: 0x7FFAC974E110
        public void UpgradeFontAsset(){} // RVA: 0x7FFAC974E640
        public void UpgradeGlyphAdjustmentTableToFontFeatureTable(){} // RVA: 0x7FFAC974F480
        public void .ctor(){} // RVA: 0x7FFAC974FA40
        public void .cctor(){} // RVA: 0x7FFAC9750320
    }

    public class TMP_FontAssetUtilities : Object
    {
        public TMPro.TMP_FontAssetUtilities instance;
        public System.Collections.Generic.HashSet`1<int> k_SearchedAssets; // 0x8
        public bool k_IsFontEngineInitialized; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9752180
        public void get_instance(){} // RVA: 0x7FFAC9752220
        public void GetCharacterFromFontAsset(){} // RVA: 0x7FFAC9752280
        public void GetCharacterFromFontAsset_Internal(){} // RVA: 0x7FFAC9752450
        public void GetCharacterFromFontAssets(){} // RVA: 0x7FFAC97529C0
        public void GetSpriteCharacterFromSpriteAsset(){} // RVA: 0x7FFAC9752D20
        public void GetSpriteCharacterFromSpriteAsset_Internal(){} // RVA: 0x7FFAC97531A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_FontFeatureTable : Object
    {
        public System.Collections.Generic.List`1<TMPro.TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords; // 0x10
        public System.Collections.Generic.Dictionary`2<uint,TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

        // ── Methods ──
        public void get_glyphPairAdjustmentRecords(){} // RVA: 0x7FFAC2F3C380
        public void set_glyphPairAdjustmentRecords(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9753630
        public void SortGlyphPairAdjustmentRecords(){} // RVA: 0x7FFAC9753790
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
        public void Clear(){} // RVA: 0x7FFAC97A25B0
        public void Add(){} // RVA: 0x7FFAC97A25C0
        public void Remove(){} // RVA: 0x7FFAC97A2670
    }

    public class TMP_FontUtilities : Object
    {
        public System.Collections.Generic.List`1<int> k_searchedFontAssets;

        // ── Methods ──
        public void SearchForCharacter(){} // RVA: 0x7FFAC9751B80 | overloaded x2
        public void SearchForCharacterInternal(){} // RVA: 0x7FFAC9751FB0 | overloaded x2
    }

    public class TMP_FontWeightPair : ValueType
    {
        public TMPro.TMP_FontAsset regularTypeface; // 0x10
        public TMPro.TMP_FontAsset italicTypeface; // 0x18
    }

    public class TMP_Glyph : TMP_TextElement_Legacy
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFAC9750A80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_GlyphAdjustmentRecord : ValueType
    {
        public uint glyphIndex; // 0x10
        public TMPro.TMP_GlyphValueRecord glyphValueRecord; // 0x14

        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x7FFAC4420210
        public void set_glyphIndex(){} // RVA: 0x7FFAC336D8B0
        public void get_glyphValueRecord(){} // RVA: 0x7FFAC60F2110
        public void set_glyphValueRecord(){} // RVA: 0x7FFAC9753470
        public void .ctor(){} // RVA: 0x7FFAC9753480 | overloaded x2
    }

    public class TMP_GlyphPairAdjustmentRecord : Object
    {
        public TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord; // 0x10
        public TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord; // 0x24
        public 0x6B21A1C8 featureLookupFlags; // 0x38

        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x7FFAC586FC90
        public void set_firstAdjustmentRecord(){} // RVA: 0x7FFAC69C01C0
        public void get_secondAdjustmentRecord(){} // RVA: 0x7FFAC97534D0
        public void set_secondAdjustmentRecord(){} // RVA: 0x7FFAC97534F0
        public void get_featureLookupFlags(){} // RVA: 0x7FFAC358A870
        public void set_featureLookupFlags(){} // RVA: 0x7FFAC3588350
        public void .ctor(){} // RVA: 0x7FFAC9753530 | overloaded x2
    }

    public class TMP_GlyphValueRecord : ValueType
    {
        public float xPlacement; // 0x10
        public float yPlacement; // 0x14
        public float xAdvance; // 0x18
        public float yAdvance; // 0x1C

        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x7FFAC484C150
        public void set_xPlacement(){} // RVA: 0x7FFAC4A9B910
        public void get_yPlacement(){} // RVA: 0x7FFAC4A9B900
        public void set_yPlacement(){} // RVA: 0x7FFAC4A9B8F0
        public void get_xAdvance(){} // RVA: 0x7FFAC4A9B8E0
        public void set_xAdvance(){} // RVA: 0x7FFAC4A9B920
        public void get_yAdvance(){} // RVA: 0x7FFAC4A9B8D0
        public void set_yAdvance(){} // RVA: 0x7FFAC4A9B8C0
        public void .ctor(){} // RVA: 0x7FFAC9750DA0 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFAC9753450
    }

    public class TMP_InputField : Selectable
    {
        public UnityEngine.TouchScreenKeyboard inputSystem; // 0x100
        public char[] compositionString;
        public UnityEngine.RectTransform compositionLength; // 0x108
        public UnityEngine.RectTransform mesh; // 0x110
        public UnityEngine.UI.RectMask2D shouldHideMobileInput; // 0x118
        public UnityEngine.UI.RectMask2D shouldHideSoftKeyboard; // 0x120
        public UnityEngine.Rect text; // 0x128
        public TMPro.TMP_Text isFocused; // 0x138
        public UnityEngine.RectTransform caretBlinkRate; // 0x140
        public UnityEngine.UI.Graphic caretWidth; // 0x148
        public UnityEngine.UI.Scrollbar textViewport; // 0x150
        public TMPro.TMP_ScrollbarEventHandler textComponent; // 0x158
        public bool placeholder; // 0x160
        public UnityEngine.UI.LayoutGroup verticalScrollbar; // 0x168
        public UnityEngine.EventSystems.IScrollHandler scrollSensitivity; // 0x170
        public float caretColor; // 0x178
        public float customCaretColor; // 0x17C
        public 0x6B21A430 selectionColor; // 0x180
        public 0x6B21A488 onEndEdit; // 0x184
        public char onSubmit; // 0x188
        public 0x6B180430 onSelect; // 0x18C
        public 0x6B21A538 onDeselect; // 0x190
        public bool onTextSelection; // 0x194
        public bool onEndTextSelection; // 0x195
        public 0x6B21A4E0 onValueChanged; // 0x198
        public string onTouchScreenKeyboardStatusChanged; // 0x1A0
        public float onValidateInput; // 0x1A8
        public int characterLimit; // 0x1AC
        public SubmitEvent pointSize; // 0x1B0
        public SubmitEvent fontAsset; // 0x1B8
        public SelectionEvent onFocusSelectAll; // 0x1C0
        public SelectionEvent resetOnDeActivation; // 0x1C8
        public TextSelectionEvent restoreOriginalTextOnEscape; // 0x1D0
        public TextSelectionEvent isRichTextEditingAllowed; // 0x1D8
        public OnChangeEvent contentType; // 0x1E0
        public TouchScreenKeyboardEvent lineType; // 0x1E8
        public OnValidateInput lineLimit; // 0x1F0
        public UnityEngine.Color inputType; // 0x1F8
        public bool keyboardType; // 0x208
        public UnityEngine.Color characterValidation; // 0x20C
        public string inputValidator; // 0x220
        public float readOnly; // 0x228
        public int richText; // 0x22C
        public bool multiLine; // 0x230
        public bool asteriskChar; // 0x231
        public int wasCanceled; // 0x234
        public int caretPositionInternal; // 0x238
        public int stringPositionInternal; // 0x23C
        public int caretSelectPositionInternal; // 0x240
        public UnityEngine.RectTransform stringSelectPositionInternal; // 0x248
        public UnityEngine.UIVertex[] hasSelection; // 0x250
        public UnityEngine.CanvasRenderer caretPosition; // 0x258
        public UnityEngine.Vector2 selectionAnchorPosition; // 0x260
        public UnityEngine.Mesh selectionFocusPosition; // 0x268
        public bool stringPosition; // 0x270
        public bool selectionStringAnchorPosition; // 0x271
        public bool selectionStringFocusPosition; // 0x272
        public bool clipboard; // 0x273
        public float minWidth;
        public float preferredWidth;
        public bool flexibleWidth; // 0x274
        public UnityEngine.Coroutine minHeight; // 0x278
        public float preferredHeight; // 0x280
        public UnityEngine.Coroutine flexibleHeight; // 0x288
        public string layoutPriority; // 0x290
        public bool m_WasCanceled; // 0x298
        public bool m_HasDoneFocusTransition; // 0x299
        public UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x2A0
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
        public TMPro.TMP_FontAsset m_GlobalFontAsset; // 0x2C0
        public bool m_OnFocusSelectAll; // 0x2C8
        public bool m_isSelectAll; // 0x2C9
        public bool m_ResetOnDeActivation; // 0x2CA
        public bool m_SelectionStillActive; // 0x2CB
        public bool m_ReleaseSelection; // 0x2CC
        public UnityEngine.GameObject m_PreviouslySelectedObject; // 0x2D0
        public bool m_RestoreOriginalTextOnEscape; // 0x2D8
        public bool m_isRichTextEditingAllowed; // 0x2D9
        public int m_LineLimit; // 0x2DC
        public TMPro.TMP_InputValidator m_InputValidator; // 0x2E0
        public bool m_isSelected; // 0x2E8
        public bool m_IsStringPositionDirty; // 0x2E9
        public bool m_IsCaretPositionDirty; // 0x2EA
        public bool m_forceRectTransformAdjustment; // 0x2EB
        public UnityEngine.Event m_ProcessingEvent; // 0x2F0

        // ── Methods ──
        public void get_inputSystem(){} // RVA: 0x7FFAC9753C30
        public void get_compositionString(){} // RVA: 0x7FFAC9753E20
        public void get_compositionLength(){} // RVA: 0x7FFAC9753F70
        public void .ctor(){} // RVA: 0x7FFAC9753FA0
        public void get_mesh(){} // RVA: 0x7FFAC9754780
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFAC97548F0
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFAC9754990
        public void get_shouldHideSoftKeyboard(){} // RVA: 0x7FFAC9754A60
        public void set_shouldHideSoftKeyboard(){} // RVA: 0x7FFAC9754B30
        public void isKeyboardUsingEvents(){} // RVA: 0x7FFAC9754CB0
        public void get_text(){} // RVA: 0x7FFAC35493F0
        public void set_text(){} // RVA: 0x7FFAC9754D60
        public void SetTextWithoutNotify(){} // RVA: 0x7FFAC9754D70
        public void SetText(){} // RVA: 0x7FFAC9754D80
        public void get_isFocused(){} // RVA: 0x7FFAC9754F40
        public void get_caretBlinkRate(){} // RVA: 0x7FFAC412E510
        public void set_caretBlinkRate(){} // RVA: 0x7FFAC9754F50
        public void get_caretWidth(){} // RVA: 0x7FFAC44FA0A0
        public void set_caretWidth(){} // RVA: 0x7FFAC9754FC0
        public void get_textViewport(){} // RVA: 0x7FFAC354B170
        public void set_textViewport(){} // RVA: 0x7FFAC9755020
        public void get_textComponent(){} // RVA: 0x7FFAC35422C0
        public void set_textComponent(){} // RVA: 0x7FFAC9755080
        public void get_placeholder(){} // RVA: 0x7FFAC2F8C660
        public void set_placeholder(){} // RVA: 0x7FFAC97550E0
        public void get_verticalScrollbar(){} // RVA: 0x7FFAC354DFA0
        public void set_verticalScrollbar(){} // RVA: 0x7FFAC9755140
        public void get_scrollSensitivity(){} // RVA: 0x7FFAC9755410
        public void set_scrollSensitivity(){} // RVA: 0x7FFAC9755420
        public void get_caretColor(){} // RVA: 0x7FFAC9755480
        public void set_caretColor(){} // RVA: 0x7FFAC97554E0
        public void get_customCaretColor(){} // RVA: 0x7FFAC8C44960
        public void set_customCaretColor(){} // RVA: 0x7FFAC9755550
        public void get_selectionColor(){} // RVA: 0x7FFAC9755570
        public void set_selectionColor(){} // RVA: 0x7FFAC9755580
        public void get_onEndEdit(){} // RVA: 0x7FFAC3549F30
        public void set_onEndEdit(){} // RVA: 0x7FFAC97555F0
        public void get_onSubmit(){} // RVA: 0x7FFAC3544330
        public void set_onSubmit(){} // RVA: 0x7FFAC9755650
        public void get_onSelect(){} // RVA: 0x7FFAC35422B0
        public void set_onSelect(){} // RVA: 0x7FFAC97556B0
        public void get_onDeselect(){} // RVA: 0x7FFAC39CCB10
        public void set_onDeselect(){} // RVA: 0x7FFAC9755710
        public void get_onTextSelection(){} // RVA: 0x7FFAC39C1920
        public void set_onTextSelection(){} // RVA: 0x7FFAC9755770
        public void get_onEndTextSelection(){} // RVA: 0x7FFAC39C0A30
        public void set_onEndTextSelection(){} // RVA: 0x7FFAC97557D0
        public void get_onValueChanged(){} // RVA: 0x7FFAC33F8150
        public void set_onValueChanged(){} // RVA: 0x7FFAC9755830
        public void get_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFAC39B1060
        public void set_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFAC9755890
        public void get_onValidateInput(){} // RVA: 0x7FFAC3544EF0
        public void set_onValidateInput(){} // RVA: 0x7FFAC97558F0
        public void get_characterLimit(){} // RVA: 0x7FFAC9755950
        public void set_characterLimit(){} // RVA: 0x7FFAC9755960
        public void get_pointSize(){} // RVA: 0x7FFAC9755A10
        public void set_pointSize(){} // RVA: 0x7FFAC9755A20
        public void get_fontAsset(){} // RVA: 0x7FFAC39AC670
        public void set_fontAsset(){} // RVA: 0x7FFAC9755C10
        public void get_onFocusSelectAll(){} // RVA: 0x7FFAC3E74AA0
        public void set_onFocusSelectAll(){} // RVA: 0x7FFAC450F260
        public void get_resetOnDeActivation(){} // RVA: 0x7FFAC9755DC0
        public void set_resetOnDeActivation(){} // RVA: 0x7FFAC9755DD0
        public void get_restoreOriginalTextOnEscape(){} // RVA: 0x7FFAC8B12FE0
        public void set_restoreOriginalTextOnEscape(){} // RVA: 0x7FFAC8B12FF0
        public void get_isRichTextEditingAllowed(){} // RVA: 0x7FFAC8B13000
        public void set_isRichTextEditingAllowed(){} // RVA: 0x7FFAC8B13010
        public void get_contentType(){} // RVA: 0x7FFAC9755DE0
        public void set_contentType(){} // RVA: 0x7FFAC9755DF0
        public void get_lineType(){} // RVA: 0x7FFAC8A144E0
        public void set_lineType(){} // RVA: 0x7FFAC9755FA0
        public void get_lineLimit(){} // RVA: 0x7FFAC9756090
        public void set_lineLimit(){} // RVA: 0x7FFAC97560A0
        public void get_inputType(){} // RVA: 0x7FFAC33B07B0
        public void set_inputType(){} // RVA: 0x7FFAC9756110
        public void get_keyboardType(){} // RVA: 0x7FFAC8A144D0
        public void set_keyboardType(){} // RVA: 0x7FFAC9756180
        public void get_characterValidation(){} // RVA: 0x7FFAC9645C90
        public void set_characterValidation(){} // RVA: 0x7FFAC97561F0
        public void get_inputValidator(){} // RVA: 0x7FFAC39AB5C0
        public void set_inputValidator(){} // RVA: 0x7FFAC9756260
        public void get_readOnly(){} // RVA: 0x7FFAC89F5240
        public void set_readOnly(){} // RVA: 0x7FFAC89F5250
        public void get_richText(){} // RVA: 0x7FFAC89F5260
        public void set_richText(){} // RVA: 0x7FFAC97562D0
        public void get_multiLine(){} // RVA: 0x7FFAC9756400
        public void get_asteriskChar(){} // RVA: 0x7FFAC9756420
        public void set_asteriskChar(){} // RVA: 0x7FFAC9756430
        public void get_wasCanceled(){} // RVA: 0x7FFAC9756550
        public void ClampStringPos(){} // RVA: 0x7FFAC9756560
        public void ClampCaretPos(){} // RVA: 0x7FFAC97565A0
        public void get_caretPositionInternal(){} // RVA: 0x7FFAC9756600
        public void set_caretPositionInternal(){} // RVA: 0x7FFAC9756640
        public void get_stringPositionInternal(){} // RVA: 0x7FFAC97566B0
        public void set_stringPositionInternal(){} // RVA: 0x7FFAC97566F0
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFAC9756740
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFAC9756780
        public void get_stringSelectPositionInternal(){} // RVA: 0x7FFAC97567F0
        public void set_stringSelectPositionInternal(){} // RVA: 0x7FFAC9756830
        public void get_hasSelection(){} // RVA: 0x7FFAC9756880
        public void get_caretPosition(){} // RVA: 0x7FFAC9756740
        public void set_caretPosition(){} // RVA: 0x7FFAC9756910
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFAC9756600
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFAC97569A0
        public void get_selectionFocusPosition(){} // RVA: 0x7FFAC9756740
        public void set_selectionFocusPosition(){} // RVA: 0x7FFAC97569F0
        public void get_stringPosition(){} // RVA: 0x7FFAC97567F0
        public void set_stringPosition(){} // RVA: 0x7FFAC9756A40
        public void get_selectionStringAnchorPosition(){} // RVA: 0x7FFAC97566B0
        public void set_selectionStringAnchorPosition(){} // RVA: 0x7FFAC9756B30
        public void get_selectionStringFocusPosition(){} // RVA: 0x7FFAC97567F0
        public void set_selectionStringFocusPosition(){} // RVA: 0x7FFAC9756BC0
        public void OnEnable(){} // RVA: 0x7FFAC9756C50
        public void OnDisable(){} // RVA: 0x7FFAC9757910
        public void ON_TEXT_CHANGED(){} // RVA: 0x7FFAC9757F50
        public void CaretBlink(){} // RVA: 0x7FFAC9758300
        public void SetCaretVisible(){} // RVA: 0x7FFAC97583A0
        public void SetCaretActive(){} // RVA: 0x7FFAC9758420
        public void OnFocus(){} // RVA: 0x7FFAC9758510
        public void SelectAll(){} // RVA: 0x7FFAC9758530
        public void MoveTextEnd(){} // RVA: 0x7FFAC97585C0
        public void MoveTextStart(){} // RVA: 0x7FFAC97587A0
        public void MoveToEndOfLine(){} // RVA: 0x7FFAC9758970
        public void MoveToStartOfLine(){} // RVA: 0x7FFAC9758BF0
        public void get_clipboard(){} // RVA: 0x7FFAC9758EA0
        public void set_clipboard(){} // RVA: 0x7FFAC9758F20
        public void InPlaceEditing(){} // RVA: 0x7FFAC9758FB0
        public void UpdateStringPositionFromKeyboard(){} // RVA: 0x7FFAC9759160
        public void LateUpdate(){} // RVA: 0x7FFAC9759490
        public void MayDrag(){} // RVA: 0x7FFAC975A020
        public void OnBeginDrag(){} // RVA: 0x7FFAC975A190
        public void OnDrag(){} // RVA: 0x7FFAC975A1C0
        public void MouseDragOutsideRect(){} // RVA: 0x7FFAC975A6F0
        public void OnEndDrag(){} // RVA: 0x7FFAC975A7F0
        public void OnPointerDown(){} // RVA: 0x7FFAC975A820
        public void KeyPressed(){} // RVA: 0x7FFAC975B230
        public void IsValidChar(){} // RVA: 0x7FFAC975B800
        public void ProcessEvent(){} // RVA: 0x7FFAC975B820
        public void OnUpdateSelected(){} // RVA: 0x7FFAC975B830
        public void OnScroll(){} // RVA: 0x7FFAC975BAC0
        public void GetScrollPositionRelativeToViewport(){} // RVA: 0x7FFAC975BCE0
        public void GetSelectedString(){} // RVA: 0x7FFAC975BE90
        public void FindNextWordBegin(){} // RVA: 0x7FFAC975BF80
        public void MoveRight(){} // RVA: 0x7FFAC975C0B0
        public void FindPrevWordBegin(){} // RVA: 0x7FFAC975C860
        public void MoveLeft(){} // RVA: 0x7FFAC975C980
        public void LineUpCharacterPosition(){} // RVA: 0x7FFAC975D070
        public void LineDownCharacterPosition(){} // RVA: 0x7FFAC975D300
        public void PageUpCharacterPosition(){} // RVA: 0x7FFAC975D5D0
        public void PageDownCharacterPosition(){} // RVA: 0x7FFAC975D960
        public void MoveDown(){} // RVA: 0x7FFAC975DD30 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFAC975DFB0 | overloaded x2
        public void MovePageUp(){} // RVA: 0x7FFAC975E210 | overloaded x2
        public void MovePageDown(){} // RVA: 0x7FFAC975E760 | overloaded x2
        public void Delete(){} // RVA: 0x7FFAC975ECC0
        public void DeleteKey(){} // RVA: 0x7FFAC975F030
        public void Backspace(){} // RVA: 0x7FFAC975F320
        public void Append(){} // RVA: 0x7FFAC975F7D0 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAC975FC10
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFAC975FE40
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFAC975FE90
        public void SendOnValueChanged(){} // RVA: 0x7FFAC975FEF0
        public void SendOnEndEdit(){} // RVA: 0x7FFAC975FF50
        public void SendOnSubmit(){} // RVA: 0x7FFAC975FFB0
        public void SendOnFocus(){} // RVA: 0x7FFAC9760010
        public void SendOnFocusLost(){} // RVA: 0x7FFAC9760070
        public void SendOnTextSelection(){} // RVA: 0x7FFAC97600D0
        public void SendOnEndTextSelection(){} // RVA: 0x7FFAC97601D0
        public void SendTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFAC97602D0
        public void UpdateLabel(){} // RVA: 0x7FFAC9760380
        public void UpdateScrollbar(){} // RVA: 0x7FFAC9760A50
        public void OnScrollbarValueChange(){} // RVA: 0x7FFAC9760BF0
        public void UpdateMaskRegions(){} // RVA: 0x7FFAC2F21310
        public void AdjustTextPositionRelativeToViewport(){} // RVA: 0x7FFAC9760C30
        public void GetCaretPositionFromStringIndex(){} // RVA: 0x7FFAC9761030
        public void GetMinCaretPositionFromStringIndex(){} // RVA: 0x7FFAC97610B0
        public void GetMaxCaretPositionFromStringIndex(){} // RVA: 0x7FFAC9761030
        public void GetStringIndexFromCaretPosition(){} // RVA: 0x7FFAC9761150
        public void ForceLabelUpdate(){} // RVA: 0x7FFAC97611E0
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFAC97611F0
        public void Rebuild(){} // RVA: 0x7FFAC9761290
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void UpdateGeometry(){} // RVA: 0x7FFAC97613C0
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFAC97614F0
        public void OnFillVBO(){} // RVA: 0x7FFAC9761FE0
        public void GenerateCaret(){} // RVA: 0x7FFAC9762520
        public void CreateCursorVerts(){} // RVA: 0x7FFAC97632C0
        public void GenerateHightlight(){} // RVA: 0x7FFAC97634D0
        public void AdjustRectTransformRelativeToViewport(){} // RVA: 0x7FFAC9763F70
        public void Validate(){} // RVA: 0x7FFAC97647F0
        public void ActivateInputField(){} // RVA: 0x7FFAC9765080
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFAC97652A0
        public void OnSelect(){} // RVA: 0x7FFAC9765A10
        public void OnPointerClick(){} // RVA: 0x7FFAC9765A80
        public void OnControlClick(){} // RVA: 0x7FFAC2F21310
        public void ReleaseSelection(){} // RVA: 0x7FFAC9765AB0
        public void DeactivateInputField(){} // RVA: 0x7FFAC9765B70
        public void OnDeselect(){} // RVA: 0x7FFAC9765F30
        public void OnSubmit(){} // RVA: 0x7FFAC9765FB0
        public void EnforceContentType(){} // RVA: 0x7FFAC9766010
        public void SetTextComponentWrapMode(){} // RVA: 0x7FFAC9766180
        public void SetTextComponentRichTextMode(){} // RVA: 0x7FFAC97662E0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFAC9766410
        public void SetToCustom(){} // RVA: 0x7FFAC9766480 | overloaded x2
        public void DoStateTransition(){} // RVA: 0x7FFAC97664A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void get_minWidth(){} // RVA: 0x7FFAC37432E0
        public void get_preferredWidth(){} // RVA: 0x7FFAC97664D0
        public void get_flexibleWidth(){} // RVA: 0x7FFAC954F350
        public void get_minHeight(){} // RVA: 0x7FFAC37432E0
        public void get_preferredHeight(){} // RVA: 0x7FFAC97667C0
        public void get_flexibleHeight(){} // RVA: 0x7FFAC954F350
        public void get_layoutPriority(){} // RVA: 0x7FFAC3013AF0
        public void SetGlobalPointSize(){} // RVA: 0x7FFAC9766AB0
        public void SetGlobalFontAsset(){} // RVA: 0x7FFAC9766C10
        public void .cctor(){} // RVA: 0x7FFAC9766D70
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class TMP_InputValidator : ScriptableObject
    {
        // ── Methods ──
        public void Validate(){}
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
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
        public 0x6B21B610 alignment; // 0x58
        public TMPro.Extents lineExtents; // 0x5C
    }

    public class TMP_LinkInfo : ValueType
    {
        public TMPro.TMP_Text textComponent; // 0x10
        public int hashCode; // 0x18
        public int linkIdFirstCharacterIndex; // 0x1C
        public int linkIdLength; // 0x20
        public int linkTextfirstCharacterIndex; // 0x24
        public int linkTextLength; // 0x28
        public char[] linkID; // 0x30

        // ── Methods ──
        public void SetLinkID(){} // RVA: 0x7FFAC9739120
        public void GetLinkText(){} // RVA: 0x7FFAC9739240
        public void GetLinkID(){} // RVA: 0x7FFAC97393A0
    }

    public class TMP_ListPool`1 : Object
    {
        public TMPro.TMP_ObjectPool`1<System.Collections.Generic.List`1<T>> s_ListPool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2C58A90
        public void Release(){} // RVA: 0x7FFAC2C70A10
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class TMP_MaterialManager : Object
    {
        public System.Collections.Generic.List`1<MaskingMaterial> m_materialList;
        public System.Collections.Generic.Dictionary`2<long,FallbackMaterial> m_fallbackMaterials; // 0x8
        public System.Collections.Generic.Dictionary`2<int,long> m_fallbackMaterialLookup; // 0x10
        public System.Collections.Generic.List`1<FallbackMaterial> m_fallbackCleanupList; // 0x18
        public bool isFallbackListDirty; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC97877B0
        public void OnPreRender(){} // RVA: 0x7FFAC9787AF0
        public void GetStencilMaterial(){} // RVA: 0x7FFAC9787B70
        public void ReleaseStencilMaterial(){} // RVA: 0x7FFAC9788080
        public void GetBaseMaterial(){} // RVA: 0x7FFAC9788300
        public void SetStencil(){} // RVA: 0x7FFAC97884F0
        public void AddMaskingMaterial(){} // RVA: 0x7FFAC97886C0
        public void RemoveStencilMaterial(){} // RVA: 0x7FFAC9788A90
        public void ReleaseBaseMaterial(){} // RVA: 0x7FFAC9788C40
        public void ClearMaterials(){} // RVA: 0x7FFAC9789270
        public void GetStencilID(){} // RVA: 0x7FFAC9789510
        public void GetMaterialForRendering(){} // RVA: 0x7FFAC9789A60
        public void FindRootSortOverrideCanvas(){} // RVA: 0x7FFAC9789D20
        public void GetFallbackMaterial(){} // RVA: 0x7FFAC978A4A0 | overloaded x2
        public void AddFallbackMaterialReference(){} // RVA: 0x7FFAC978AB30
        public void RemoveFallbackMaterialReference(){} // RVA: 0x7FFAC978AD20
        public void CleanupFallbackMaterials(){} // RVA: 0x7FFAC978AF80
        public void ReleaseFallbackMaterial(){} // RVA: 0x7FFAC978B220
        public void CopyMaterialPresetProperties(){} // RVA: 0x7FFAC978B4B0
    }

    public class TMP_MaterialReference : ValueType
    {
        public UnityEngine.Material material; // 0x10
        public int referenceCount; // 0x18
    }

    public class TMP_Math : Object
    {
        public float FLOAT_MAX;
        public float FLOAT_MIN;
        public int INT_MAX;
        public int INT_MIN;
        public float FLOAT_UNSET;
        public int INT_UNSET;
        public UnityEngine.Vector2 MAX_16BIT;
        public UnityEngine.Vector2 MIN_16BIT; // 0x8

        // ── Methods ──
        public void Approximately(){} // RVA: 0x7FFAC9739040
        public void Mod(){} // RVA: 0x7FFAC9739070
        public void .cctor(){} // RVA: 0x7FFAC9739090
    }

    public class TMP_MeshInfo : ValueType
    {
        public UnityEngine.Color32 s_DefaultColor;
        public UnityEngine.Vector3 s_DefaultNormal; // 0x4
        public UnityEngine.Vector4 s_DefaultTangent; // 0x10
        public UnityEngine.Bounds s_DefaultBounds; // 0x20
        public UnityEngine.Mesh mesh; // 0x10
        public int vertexCount; // 0x18
        public UnityEngine.Vector3[] vertices; // 0x20
        public UnityEngine.Vector3[] normals; // 0x28
        public UnityEngine.Vector4[] tangents; // 0x30
        public UnityEngine.Vector2[] uvs0; // 0x38
        public UnityEngine.Vector2[] uvs2; // 0x40
        public UnityEngine.Color32[] colors32; // 0x48
        public int[] triangles; // 0x50
        public UnityEngine.Material material; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC978C7A0 | overloaded x2
        public void ResizeMeshInfo(){} // RVA: 0x7FFAC978DDA0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC978ECF0 | overloaded x2
        public void ClearUnusedVertices(){} // RVA: 0x7FFAC978EFC0 | overloaded x3
        public void SortGeometry(){} // RVA: 0x7FFAC978F200 | overloaded x2
        public void SwapVertexData(){} // RVA: 0x7FFAC978F350
        public void .cctor(){} // RVA: 0x7FFAC978FB40
    }

    public class TMP_ObjectPool`1 : Object
    {
        public System.Collections.Generic.Stack`1<T> countAll;
        public UnityEngine.Events.UnityAction`1<T> countActive;
        public UnityEngine.Events.UnityAction`1<T> countInactive;
        public int <countAll>k__BackingField;

        // ── Methods ──
        public void get_countAll(){} // RVA: 0x7FFAC2C59960
        public void set_countAll(){} // RVA: 0x7FFAC2C70ED0
        public void get_countActive(){} // RVA: 0x7FFAC2C59960
        public void get_countInactive(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void Release(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TMP_Offset : ValueType
    {
        public float left; // 0x10
        public float right; // 0x14
        public float top; // 0x18
        public float bottom; // 0x1C
        public TMPro.TMP_Offset horizontal;

        // ── Methods ──
        public void get_left(){} // RVA: 0x7FFAC484C150
        public void set_left(){} // RVA: 0x7FFAC4A9B910
        public void get_right(){} // RVA: 0x7FFAC4A9B900
        public void set_right(){} // RVA: 0x7FFAC4A9B8F0
        public void get_top(){} // RVA: 0x7FFAC4A9B8E0
        public void set_top(){} // RVA: 0x7FFAC4A9B920
        public void get_bottom(){} // RVA: 0x7FFAC4A9B8D0
        public void set_bottom(){} // RVA: 0x7FFAC4A9B8C0
        public void get_horizontal(){} // RVA: 0x7FFAC484C150
        public void set_horizontal(){} // RVA: 0x7FFAC9739DD0
        public void get_vertical(){} // RVA: 0x7FFAC4A9B8E0
        public void set_vertical(){} // RVA: 0x7FFAC9739DE0
        public void get_zero(){} // RVA: 0x7FFAC9739DF0
        public void .ctor(){} // RVA: 0x7FFAC9739E50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8F79BA0
        public void op_Inequality(){} // RVA: 0x7FFAC9739E70
        public void op_Multiply(){} // RVA: 0x7FFAC969E700
        public void GetHashCode(){} // RVA: 0x7FFAC9739F30
        public void Equals(){} // RVA: 0x7FFAC973A000 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC973A080
    }

    public class TMP_PageInfo : ValueType
    {
        public int firstCharacterIndex; // 0x10
        public int lastCharacterIndex; // 0x14
        public float ascender; // 0x18
        public float baseLine; // 0x1C
        public float descender; // 0x20
    }

    public class TMP_ResourceManager : Object
    {
        public TMPro.TMP_ResourceManager s_instance;
        public TMPro.TMP_Settings s_TextSettings; // 0x8
        public System.Collections.Generic.List`1<TMPro.TMP_FontAsset> s_FontAssetReferences; // 0x10
        public System.Collections.Generic.Dictionary`2<int,TMPro.TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC978FBF0
        public void GetTextSettings(){} // RVA: 0x7FFAC978FE10
        public void AddFontAsset(){} // RVA: 0x7FFAC978FFE0
        public void TryGetFontAsset(){} // RVA: 0x7FFAC9790130
        public void RebuildFontAssetCache(){} // RVA: 0x7FFAC9790220
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_ScrollbarEventHandler : MonoBehaviour
    {
        public bool isSelected; // 0x20

        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7FFAC97904F0
        public void OnSelect(){} // RVA: 0x7FFAC9790550
        public void OnDeselect(){} // RVA: 0x7FFAC97905C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class TMP_SelectionCaret : MaskableGraphic
    {
        // ── Methods ──
        public void Cull(){} // RVA: 0x7FFAC9790630
        public void UpdateGeometry(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC4648880
    }

    public class TMP_Settings : ScriptableObject
    {
        public TMPro.TMP_Settings version;
        public bool enableWordWrapping; // 0x18
        public bool enableKerning; // 0x19
        public bool enableExtraPadding; // 0x1A
        public bool enableTintAllSprites; // 0x1B
        public bool enableParseEscapeCharacters; // 0x1C
        public bool enableRaycastTarget; // 0x1D
        public bool getFontFeaturesAtRuntime; // 0x1E
        public int missingGlyphCharacter; // 0x20
        public bool warningsDisabled; // 0x24
        public TMPro.TMP_FontAsset defaultFontAsset; // 0x28
        public string defaultFontAssetPath; // 0x30
        public float defaultFontSize; // 0x38
        public float defaultTextAutoSizingMinRatio; // 0x3C
        public float defaultTextAutoSizingMaxRatio; // 0x40
        public UnityEngine.Vector2 defaultTextMeshProTextContainerSize; // 0x44
        public UnityEngine.Vector2 defaultTextMeshProUITextContainerSize; // 0x4C
        public bool autoSizeTextContainer; // 0x54
        public bool isTextObjectScaleStatic; // 0x55
        public System.Collections.Generic.List`1<TMPro.TMP_FontAsset> fallbackFontAssets; // 0x58
        public bool matchMaterialPreset; // 0x60
        public TMPro.TMP_SpriteAsset defaultSpriteAsset; // 0x68
        public string defaultSpriteAssetPath; // 0x70
        public bool enableEmojiSupport; // 0x78
        public uint missingCharacterSpriteUnicode; // 0x7C
        public string defaultColorGradientPresetsPath; // 0x80
        public TMPro.TMP_StyleSheet defaultStyleSheet; // 0x88
        public string styleSheetsResourcePath; // 0x90
        public UnityEngine.TextAsset leadingCharacters; // 0x98
        public UnityEngine.TextAsset followingCharacters; // 0xA0
        public LineBreakingTable linebreakingRules; // 0xA8
        public bool useModernHangulLineBreakingRules; // 0xB0

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFAC9790700
        public void get_enableWordWrapping(){} // RVA: 0x7FFAC9790740
        public void get_enableKerning(){} // RVA: 0x7FFAC9790760
        public void get_enableExtraPadding(){} // RVA: 0x7FFAC9790780
        public void get_enableTintAllSprites(){} // RVA: 0x7FFAC97907A0
        public void get_enableParseEscapeCharacters(){} // RVA: 0x7FFAC97907C0
        public void get_enableRaycastTarget(){} // RVA: 0x7FFAC97907E0
        public void get_getFontFeaturesAtRuntime(){} // RVA: 0x7FFAC9790800
        public void get_missingGlyphCharacter(){} // RVA: 0x7FFAC9790820
        public void set_missingGlyphCharacter(){} // RVA: 0x7FFAC9790840
        public void get_warningsDisabled(){} // RVA: 0x7FFAC9790870
        public void get_defaultFontAsset(){} // RVA: 0x7FFAC9790890
        public void get_defaultFontAssetPath(){} // RVA: 0x7FFAC97908B0
        public void get_defaultFontSize(){} // RVA: 0x7FFAC97908D0
        public void get_defaultTextAutoSizingMinRatio(){} // RVA: 0x7FFAC97908F0
        public void get_defaultTextAutoSizingMaxRatio(){} // RVA: 0x7FFAC9790910
        public void get_defaultTextMeshProTextContainerSize(){} // RVA: 0x7FFAC9790930
        public void get_defaultTextMeshProUITextContainerSize(){} // RVA: 0x7FFAC9790960
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFAC9790990
        public void get_isTextObjectScaleStatic(){} // RVA: 0x7FFAC97909B0
        public void set_isTextObjectScaleStatic(){} // RVA: 0x7FFAC97909D0
        public void get_fallbackFontAssets(){} // RVA: 0x7FFAC9790A00
        public void get_matchMaterialPreset(){} // RVA: 0x7FFAC9790A20
        public void get_defaultSpriteAsset(){} // RVA: 0x7FFAC9790A40
        public void get_defaultSpriteAssetPath(){} // RVA: 0x7FFAC9790A60
        public void get_enableEmojiSupport(){} // RVA: 0x7FFAC9790A80
        public void set_enableEmojiSupport(){} // RVA: 0x7FFAC9790AA0
        public void get_missingCharacterSpriteUnicode(){} // RVA: 0x7FFAC9790AD0
        public void set_missingCharacterSpriteUnicode(){} // RVA: 0x7FFAC9790AF0
        public void get_defaultColorGradientPresetsPath(){} // RVA: 0x7FFAC9790B20
        public void get_defaultStyleSheet(){} // RVA: 0x7FFAC9790B50
        public void get_styleSheetsResourcePath(){} // RVA: 0x7FFAC9790B80
        public void get_leadingCharacters(){} // RVA: 0x7FFAC9790BB0
        public void get_followingCharacters(){} // RVA: 0x7FFAC9790BE0
        public void get_linebreakingRules(){} // RVA: 0x7FFAC9790C10
        public void get_useModernHangulLineBreakingRules(){} // RVA: 0x7FFAC9790C50
        public void set_useModernHangulLineBreakingRules(){} // RVA: 0x7FFAC9790C80
        public void get_instance(){} // RVA: 0x7FFAC9790CB0
        public void LoadDefaultSettings(){} // RVA: 0x7FFAC9790E40
        public void GetSettings(){} // RVA: 0x7FFAC9791060
        public void GetFontAsset(){} // RVA: 0x7FFAC9791140
        public void GetSpriteAsset(){} // RVA: 0x7FFAC9791230
        public void GetStyleSheet(){} // RVA: 0x7FFAC9791320
        public void LoadLinebreakingRules(){} // RVA: 0x7FFAC9791410
        public void GetCharacters(){} // RVA: 0x7FFAC97916B0
        public void .ctor(){} // RVA: 0x7FFAC9791880
    }

    public class TMP_Sprite : TMP_TextElement_Legacy
    {
        public string name; // 0x38
        public int hashCode; // 0x40
        public int unicode; // 0x44
        public UnityEngine.Vector2 pivot; // 0x48
        public UnityEngine.Sprite sprite; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_SpriteAnimator : MonoBehaviour
    {
        public System.Collections.Generic.Dictionary`2<int,bool> m_animations; // 0x20
        public TMPro.TMP_Text m_TextComponent; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC9795DE0
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void OnDisable(){} // RVA: 0x7FFAC2F21310
        public void StopAllAnimations(){} // RVA: 0x7FFAC9795E70
        public void DoSpriteAnimation(){} // RVA: 0x7FFAC9795F40
        public void DoSpriteAnimationInternal(){} // RVA: 0x7FFAC9796130
        public void .ctor(){} // RVA: 0x7FFAC9796260
    }

    public class TMP_SpriteAsset : TMP_Asset
    {
        public System.Collections.Generic.Dictionary`2<int,int> version; // 0x30
        public System.Collections.Generic.Dictionary`2<uint,int> faceInfo; // 0x38
        public string spriteCharacterTable; // 0x40
        public UnityEngine.TextCore.FaceInfo spriteCharacterLookupTable; // 0x48
        public UnityEngine.Texture spriteGlyphTable; // 0xA8
        public System.Collections.Generic.List`1<TMPro.TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
        public System.Collections.Generic.Dictionary`2<uint,TMPro.TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
        public System.Collections.Generic.List`1<TMPro.TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xC0
        public System.Collections.Generic.Dictionary`2<uint,TMPro.TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
        public System.Collections.Generic.List`1<TMPro.TMP_Sprite> spriteInfoList; // 0xD0
        public System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
        public bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
        public System.Collections.Generic.HashSet`1<int> k_searchedSpriteAssets;

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFAC2F9E740
        public void set_version(){} // RVA: 0x7FFAC2F49200
        public void get_faceInfo(){} // RVA: 0x7FFAC9796F90
        public void set_faceInfo(){} // RVA: 0x7FFAC9796FD0
        public void get_spriteCharacterTable(){} // RVA: 0x7FFAC9797050
        public void set_spriteCharacterTable(){} // RVA: 0x7FFAC2F8C050
        public void get_spriteCharacterLookupTable(){} // RVA: 0x7FFAC9797090
        public void set_spriteCharacterLookupTable(){} // RVA: 0x7FFAC2F8C0C0
        public void get_spriteGlyphTable(){} // RVA: 0x7FFAC2F8C120
        public void set_spriteGlyphTable(){} // RVA: 0x7FFAC2F8C130
        public void Awake(){} // RVA: 0x7FFAC97970D0
        public void GetDefaultSpriteMaterial(){} // RVA: 0x7FFAC97971C0
        public void UpdateLookupTables(){} // RVA: 0x7FFAC9797330
        public void GetSpriteIndexFromHashcode(){} // RVA: 0x7FFAC9797B80
        public void GetSpriteIndexFromUnicode(){} // RVA: 0x7FFAC9797C30
        public void GetSpriteIndexFromName(){} // RVA: 0x7FFAC9797CD0
        public void SearchForSpriteByUnicode(){} // RVA: 0x7FFAC9797D90
        public void SearchForSpriteByUnicodeInternal(){} // RVA: 0x7FFAC9798380 | overloaded x2
        public void SearchForSpriteByHashCode(){} // RVA: 0x7FFAC9798440
        public void SearchForSpriteByHashCodeInternal(){} // RVA: 0x7FFAC9798BD0 | overloaded x2
        public void SortGlyphTable(){} // RVA: 0x7FFAC9798C90
        public void SortCharacterTable(){} // RVA: 0x7FFAC9798ED0
        public void SortGlyphAndCharacterTables(){} // RVA: 0x7FFAC9799110
        public void UpgradeSpriteAsset(){} // RVA: 0x7FFAC9799130
        public void .ctor(){} // RVA: 0x7FFAC9799630
    }

    public class TMP_SpriteCharacter : TMP_TextElement
    {
        public string name; // 0x30
        public int hashCode; // 0x38

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC31D95E0
        public void set_name(){} // RVA: 0x7FFAC9799850
        public void get_hashCode(){} // RVA: 0x7FFAC358A870
        public void .ctor(){} // RVA: 0x7FFAC9799B00 | overloaded x4
    }

    public class TMP_SpriteGlyph : Glyph
    {
        public UnityEngine.Sprite sprite; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9799C20 | overloaded x3
    }

    public class TMP_SpriteInfo : ValueType
    {
        public int spriteIndex; // 0x10
        public int characterIndex; // 0x14
        public int vertexIndex; // 0x18
    }

    public class TMP_Style : Object
    {
        public TMPro.TMP_Style NormalStyle;
        public string name; // 0x10
        public int hashCode; // 0x18
        public string styleOpeningDefinition; // 0x20
        public string styleClosingDefinition; // 0x28
        public int[] styleOpeningTagArray; // 0x30
        public int[] styleClosingTagArray; // 0x38
        public uint[] m_OpeningTagUnicodeArray; // 0x40
        public uint[] m_ClosingTagUnicodeArray; // 0x48

        // ── Methods ──
        public void get_NormalStyle(){} // RVA: 0x7FFAC9799CA0
        public void get_name(){} // RVA: 0x7FFAC2F3C380
        public void set_name(){} // RVA: 0x7FFAC9799DD0
        public void get_hashCode(){} // RVA: 0x7FFAC3157800
        public void set_hashCode(){} // RVA: 0x7FFAC9799E70
        public void get_styleOpeningDefinition(){} // RVA: 0x7FFAC2F4F0C0
        public void get_styleClosingDefinition(){} // RVA: 0x7FFAC2F4F130
        public void get_styleOpeningTagArray(){} // RVA: 0x7FFAC31D95E0
        public void get_styleClosingTagArray(){} // RVA: 0x7FFAC31D0140
        public void .ctor(){} // RVA: 0x7FFAC9799E80
        public void RefreshStyle(){} // RVA: 0x7FFAC979A000
    }

    public class TMP_StyleSheet : ScriptableObject
    {
        public System.Collections.Generic.List`1<TMPro.TMP_Style> styles; // 0x18
        public System.Collections.Generic.Dictionary`2<int,TMPro.TMP_Style> m_StyleLookupDictionary; // 0x20

        // ── Methods ──
        public void get_styles(){} // RVA: 0x7FFAC2F247C0
        public void Reset(){} // RVA: 0x7FFAC979A380
        public void GetStyle(){} // RVA: 0x7FFAC979A420 | overloaded x2
        public void RefreshStyles(){} // RVA: 0x7FFAC979A380
        public void LoadStyleDictionaryInternal(){} // RVA: 0x7FFAC979A4E0
        public void .ctor(){} // RVA: 0x7FFAC979A910
    }

    public class TMP_SubMesh : MonoBehaviour
    {
        public TMPro.TMP_FontAsset fontAsset; // 0x20
        public TMPro.TMP_SpriteAsset spriteAsset; // 0x28
        public UnityEngine.Material material; // 0x30
        public UnityEngine.Material sharedMaterial; // 0x38
        public UnityEngine.Material fallbackMaterial; // 0x40
        public UnityEngine.Material fallbackSourceMaterial; // 0x48
        public bool isDefaultMaterial; // 0x50
        public float padding; // 0x54
        public UnityEngine.Renderer renderer; // 0x58
        public UnityEngine.MeshFilter meshFilter; // 0x60
        public UnityEngine.Mesh mesh; // 0x68
        public TMPro.TextMeshPro textComponent; // 0x70
        public bool m_isRegisteredForEvents; // 0x78

        // ── Methods ──
        public void get_fontAsset(){} // RVA: 0x7FFAC2F4F0C0
        public void set_fontAsset(){} // RVA: 0x7FFAC2F4F0D0
        public void get_spriteAsset(){} // RVA: 0x7FFAC2F4F130
        public void set_spriteAsset(){} // RVA: 0x7FFAC2F22E90
        public void get_material(){} // RVA: 0x7FFAC979AA50
        public void set_material(){} // RVA: 0x7FFAC979AA60
        public void get_sharedMaterial(){} // RVA: 0x7FFAC31D0140
        public void set_sharedMaterial(){} // RVA: 0x7FFAC979AB90
        public void get_fallbackMaterial(){} // RVA: 0x7FFAC2F9E740
        public void set_fallbackMaterial(){} // RVA: 0x7FFAC979ABA0
        public void get_fallbackSourceMaterial(){} // RVA: 0x7FFAC2F9C730
        public void set_fallbackSourceMaterial(){} // RVA: 0x7FFAC2F9C740
        public void get_isDefaultMaterial(){} // RVA: 0x7FFAC2FDB8E0
        public void set_isDefaultMaterial(){} // RVA: 0x7FFAC2FDB8F0
        public void get_padding(){} // RVA: 0x7FFAC3391600
        public void set_padding(){} // RVA: 0x7FFAC33914E0
        public void get_renderer(){} // RVA: 0x7FFAC979AEF0
        public void get_meshFilter(){} // RVA: 0x7FFAC979B030
        public void get_mesh(){} // RVA: 0x7FFAC979B2F0
        public void set_mesh(){} // RVA: 0x7FFAC2F9CD60
        public void get_textComponent(){} // RVA: 0x7FFAC979B4A0
        public void AddSubTextObject(){} // RVA: 0x7FFAC979B5E0
        public void OnEnable(){} // RVA: 0x7FFAC979BF00
        public void OnDisable(){} // RVA: 0x7FFAC979C180
        public void OnDestroy(){} // RVA: 0x7FFAC979C330
        public void DestroySelf(){} // RVA: 0x7FFAC979C620
        public void GetMaterial(){} // RVA: 0x7FFAC979C6F0
        public void CreateMaterialInstance(){} // RVA: 0x7FFAC979CB00
        public void GetSharedMaterial(){} // RVA: 0x7FFAC979CC30
        public void SetSharedMaterial(){} // RVA: 0x7FFAC979CDC0
        public void GetPaddingForMaterial(){} // RVA: 0x7FFAC979CE40
        public void UpdateMeshPadding(){} // RVA: 0x7FFAC979CED0
        public void SetVerticesDirty(){} // RVA: 0x7FFAC979CF60
        public void SetMaterialDirty(){} // RVA: 0x7FFAC979D0D0
        public void UpdateMaterial(){} // RVA: 0x7FFAC979D0E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class TMP_SubMeshUI : MaskableGraphic
    {
        public TMPro.TMP_FontAsset fontAsset; // 0xE0
        public TMPro.TMP_SpriteAsset spriteAsset; // 0xE8
        public UnityEngine.Material mainTexture; // 0xF0
        public UnityEngine.Material material; // 0xF8
        public UnityEngine.Material sharedMaterial; // 0x100
        public UnityEngine.Material fallbackMaterial; // 0x108
        public bool fallbackSourceMaterial; // 0x110
        public float materialForRendering; // 0x114
        public UnityEngine.Mesh isDefaultMaterial; // 0x118
        public TMPro.TextMeshProUGUI padding; // 0x120
        public bool mesh; // 0x128
        public bool textComponent; // 0x129
        public int m_materialReferenceIndex; // 0x12C
        public UnityEngine.Transform m_RootCanvasTransform; // 0x130

        // ── Methods ──
        public void get_fontAsset(){} // RVA: 0x7FFAC2FA2900
        public void set_fontAsset(){} // RVA: 0x7FFAC2FA2910
        public void get_spriteAsset(){} // RVA: 0x7FFAC2FA2970
        public void set_spriteAsset(){} // RVA: 0x7FFAC2FA2980
        public void get_mainTexture(){} // RVA: 0x7FFAC979D470
        public void get_material(){} // RVA: 0x7FFAC979D5E0
        public void set_material(){} // RVA: 0x7FFAC979D5F0
        public void get_sharedMaterial(){} // RVA: 0x7FFAC3331F50
        public void set_sharedMaterial(){} // RVA: 0x7FFAC979D800
        public void get_fallbackMaterial(){} // RVA: 0x7FFAC34F6C80
        public void set_fallbackMaterial(){} // RVA: 0x7FFAC979D810
        public void get_fallbackSourceMaterial(){} // RVA: 0x7FFAC36D1F40
        public void set_fallbackSourceMaterial(){} // RVA: 0x7FFAC3929BF0
        public void get_materialForRendering(){} // RVA: 0x7FFAC979DB70
        public void get_isDefaultMaterial(){} // RVA: 0x7FFAC31E7D90
        public void set_isDefaultMaterial(){} // RVA: 0x7FFAC31E5C40
        public void get_padding(){} // RVA: 0x7FFAC9719E50
        public void set_padding(){} // RVA: 0x7FFAC979DBE0
        public void get_mesh(){} // RVA: 0x7FFAC979DBF0
        public void set_mesh(){} // RVA: 0x7FFAC33B8580
        public void get_textComponent(){} // RVA: 0x7FFAC979DDA0
        public void AddSubTextObject(){} // RVA: 0x7FFAC979DEF0
        public void OnEnable(){} // RVA: 0x7FFAC979E760
        public void OnDisable(){} // RVA: 0x7FFAC979E840
        public void OnDestroy(){} // RVA: 0x7FFAC979E9B0
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC979ED90
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC979EDF0
        public void GetPaddingForMaterial(){} // RVA: 0x7FFAC979F090 | overloaded x2
        public void UpdateMeshPadding(){} // RVA: 0x7FFAC979F120
        public void SetAllDirty(){} // RVA: 0x7FFAC2F21310
        public void SetVerticesDirty(){} // RVA: 0x7FFAC979F1B0
        public void SetLayoutDirty(){} // RVA: 0x7FFAC2F21310
        public void SetMaterialDirty(){} // RVA: 0x7FFAC979F2F0
        public void SetPivotDirty(){} // RVA: 0x7FFAC979F340
        public void GetRootCanvasTransform(){} // RVA: 0x7FFAC979F400
        public void Cull(){} // RVA: 0x7FFAC2F21310
        public void UpdateGeometry(){} // RVA: 0x7FFAC2F21310
        public void Rebuild(){} // RVA: 0x7FFAC979F5F0
        public void RefreshMaterial(){} // RVA: 0x7FFAC8595F00
        public void UpdateMaterial(){} // RVA: 0x7FFAC979F630
        public void RecalculateClipping(){} // RVA: 0x7FFAC972B150
        public void GetMaterial(){} // RVA: 0x7FFAC979FA00 | overloaded x2
        public void CreateMaterialInstance(){} // RVA: 0x7FFAC979FD40
        public void GetSharedMaterial(){} // RVA: 0x7FFAC979FE70
        public void SetSharedMaterial(){} // RVA: 0x7FFAC979FEE0
        public void .ctor(){} // RVA: 0x7FFAC4648880
    }

    public class TMP_Text : MaskableGraphic
    {
        public string text; // 0xE0
        public bool textPreprocessor; // 0xE8
        public TMPro.ITextPreprocessor isRightToLeftText; // 0xF0
        public bool font; // 0xF8
        public TMPro.TMP_FontAsset fontSharedMaterial; // 0x100
        public TMPro.TMP_FontAsset fontSharedMaterials; // 0x108
        public bool fontMaterial; // 0x110
        public UnityEngine.Material fontMaterials; // 0x118
        public UnityEngine.Material color; // 0x120
        public TMPro.MaterialReference[] alpha;
        public System.Collections.Generic.Dictionary`2<int,int> enableVertexGradient; // 0x8
        public TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference> colorGradient; // 0x10
        public int colorGradientPreset; // 0x128
        public UnityEngine.Material[] spriteAsset; // 0x130
        public UnityEngine.Material tintAllSprites; // 0x138
        public UnityEngine.Material[] styleSheet; // 0x140
        public bool textStyle; // 0x148
        public UnityEngine.Color32 overrideColorTags; // 0x14C
        public UnityEngine.Color faceColor; // 0x150
        public UnityEngine.Color32 outlineColor; // 0x68
        public UnityEngine.Color32 outlineWidth; // 0x160
        public UnityEngine.Color32 fontSize; // 0x164
        public bool fontWeight; // 0x168
        public 0x6B2194B8 pixelsPerUnit; // 0x16C
        public TMPro.VertexGradient enableAutoSizing; // 0x170
        public TMPro.TMP_ColorGradient fontSizeMin; // 0x1B0
        public TMPro.TMP_SpriteAsset fontSizeMax; // 0x1B8
        public bool fontStyle; // 0x1C0
        public bool isUsingBold; // 0x1C1
        public UnityEngine.Color32 horizontalAlignment; // 0x1C4
        public TMPro.TMP_StyleSheet verticalAlignment; // 0x1C8
        public TMPro.TMP_Style alignment; // 0x1D0
        public int characterSpacing; // 0x1D8
        public bool wordSpacing; // 0x1DC
        public UnityEngine.Color32 lineSpacing; // 0x1E0
        public UnityEngine.Color32 lineSpacingAdjustment; // 0x1E4
        public float paragraphSpacing; // 0x1E8
        public float characterWidthAdjustment; // 0x1EC
        public float enableWordWrapping; // 0x1F0
        public float wordWrappingRatios; // 0x1F4
        public TMPro.TMP_TextProcessingStack`1<float> overflowMode; // 0x1F8
        public 0x6B21B928 isTextOverflowing; // 0x218
        public 0x6B21B928 firstOverflowCharacterIndex; // 0x21C
        public TMPro.TMP_TextProcessingStack`1<0x6B21B928> linkedTextComponent; // 0x220
        public bool isTextTruncated; // 0x240
        public float enableKerning; // 0x244
        public float extraPadding; // 0x248
        public int richText; // 0x24C
        public int parseCtrlCharacters; // 0x250
        public bool isOverlay; // 0x254
        public float isOrthographic; // 0x258
        public float enableCulling; // 0x25C
        public 0x6B21B8D0 ignoreVisibility; // 0x260
        public 0x6B21B8D0 horizontalMapping; // 0x264
        public TMPro.TMP_FontStyleStack verticalMapping; // 0x268
        public bool mappingUvLineOffset; // 0x272
        public 0x6B21B610 renderMode; // 0x274
        public 0x6B21B668 geometrySortingOrder; // 0x278
        public 0x6B21B5B8 isTextObjectScaleStatic; // 0x27C
        public 0x6B21B610 vertexBufferAutoSizeReduction; // 0x280
        public TMPro.TMP_TextProcessingStack`1<0x6B21B610> firstVisibleCharacter; // 0x288
        public UnityEngine.Vector3[] maxVisibleCharacters; // 0x2A8
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
        public 0x6B21B7C8 flexibleWidth; // 0x2E8
        public int minWidth; // 0x2EC
        public TMPro.TMP_Text minHeight; // 0x2F0
        public TMPro.TMP_Text maxWidth; // 0x2F8
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
        public 0x6B21B878 m_horizontalMapping; // 0x314
        public 0x6B21B878 m_verticalMapping; // 0x318
        public float m_uvLineOffset; // 0x31C
        public 0x6B21B6C0 m_renderMode; // 0x320
        public 0x6B21AD20 m_geometrySortingOrder; // 0x324
        public bool m_IsTextObjectScaleStatic; // 0x328
        public bool m_VertexBufferAutoSizeReduction; // 0x329
        public int m_firstVisibleCharacter; // 0x32C
        public int m_maxVisibleCharacters; // 0x330
        public int m_maxVisibleWords; // 0x334
        public int m_maxVisibleLines; // 0x338
        public bool m_useMaxVisibleDescender; // 0x33C
        public int m_pageToDisplay; // 0x340
        public bool m_isNewPage; // 0x344
        public UnityEngine.Vector4 m_margin; // 0x348
        public float m_marginLeft; // 0x358
        public float m_marginRight; // 0x35C
        public float m_marginWidth; // 0x360
        public float m_marginHeight; // 0x364
        public float m_width; // 0x368
        public TMPro.TMP_TextInfo m_textInfo; // 0x370
        public bool m_havePropertiesChanged; // 0x378
        public bool m_isUsingLegacyAnimationComponent; // 0x379
        public UnityEngine.Transform m_transform; // 0x380
        public UnityEngine.RectTransform m_rectTransform; // 0x388
        public UnityEngine.Vector2 m_PreviousRectTransformSize; // 0x390
        public UnityEngine.Vector2 m_PreviousPivotPosition; // 0x398
        public bool <autoSizeTextContainer>k__BackingField; // 0x3A0
        public bool m_autoSizeTextContainer; // 0x3A1
        public UnityEngine.Mesh m_mesh; // 0x3A8
        public bool m_isVolumetricText; // 0x3B0
        public System.Func`3<int,string,TMPro.TMP_FontAsset> OnFontAssetRequest; // 0x70
        public System.Func`3<int,string,TMPro.TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
        public System.Action`1<TMPro.TMP_TextInfo> OnPreRenderText; // 0x3B8
        public TMPro.TMP_SpriteAnimator m_spriteAnimator; // 0x3C0
        public float m_flexibleHeight; // 0x3C8
        public float m_flexibleWidth; // 0x3CC
        public float m_minWidth; // 0x3D0
        public float m_minHeight; // 0x3D4
        public float m_maxWidth; // 0x3D8
        public float m_maxHeight; // 0x3DC
        public UnityEngine.UI.LayoutElement m_LayoutElement; // 0x3E0
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
        public 0x6B21B9D8 m_inputSource; // 0x408
        public float m_fontScaleMultiplier; // 0x40C
        public char[] m_htmlTag; // 0x80
        public TMPro.RichTextTagAttribute[] m_xmlAttribute; // 0x88
        public float[] m_attributeParameterValues; // 0x90
        public float tag_LineIndent; // 0x410
        public float tag_Indent; // 0x414
        public TMPro.TMP_TextProcessingStack`1<float> m_indentStack; // 0x418
        public bool tag_NoParsing; // 0x438
        public bool m_isParsingText; // 0x439
        public UnityEngine.Matrix4x4 m_FXMatrix; // 0x43C
        public bool m_isFXMatrixSet; // 0x47C
        public UnicodeChar[] m_TextProcessingArray; // 0x480
        public int m_InternalTextProcessingArraySize; // 0x488
        public TMPro.TMP_CharacterInfo[] m_internalCharacterInfo; // 0x490
        public int m_totalCharacterCount; // 0x498
        public TMPro.WordWrapState m_SavedWordWrapState; // 0x98
        public TMPro.WordWrapState m_SavedLineState; // 0x410
        public TMPro.WordWrapState m_SavedEllipsisState; // 0x788
        public TMPro.WordWrapState m_SavedLastValidState; // 0xB00
        public TMPro.WordWrapState m_SavedSoftLineBreakState; // 0xE78
        public TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState> m_EllipsisInsertionCandidateStack; // 0x11F0
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
        public TMPro.Extents m_meshExtents; // 0x4E4
        public UnityEngine.Color32 m_htmlColor; // 0x4F4
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> m_colorStack; // 0x4F8
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> m_underlineColorStack; // 0x518
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> m_strikethroughColorStack; // 0x538
        public TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState> m_HighlightStateStack; // 0x558
        public TMPro.TMP_ColorGradient m_colorGradientPreset; // 0x588
        public TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient> m_colorGradientStack; // 0x590
        public bool m_colorGradientPresetIsTinted; // 0x5B8
        public float m_tabSpacing; // 0x5BC
        public float m_spacing; // 0x5C0
        public TMPro.TMP_TextProcessingStack`1<int>[] m_TextStyleStacks; // 0x5C8
        public int m_TextStyleStackDepth; // 0x5D0
        public TMPro.TMP_TextProcessingStack`1<int> m_ItalicAngleStack; // 0x5D8
        public int m_ItalicAngle; // 0x5F8
        public TMPro.TMP_TextProcessingStack`1<int> m_actionStack; // 0x600
        public float m_padding; // 0x620
        public float m_baselineOffset; // 0x624
        public TMPro.TMP_TextProcessingStack`1<float> m_baselineOffsetStack; // 0x628
        public float m_xAdvance; // 0x648
        public 0x6B21B718 m_textElementType; // 0x64C
        public TMPro.TMP_TextElement m_cached_TextElement; // 0x650
        public SpecialCharacter m_Ellipsis; // 0x658
        public SpecialCharacter m_Underline; // 0x678
        public TMPro.TMP_SpriteAsset m_defaultSpriteAsset; // 0x698
        public TMPro.TMP_SpriteAsset m_currentSpriteAsset; // 0x6A0
        public int m_spriteCount; // 0x6A8
        public int m_spriteIndex; // 0x6AC
        public int m_spriteAnimationID; // 0x6B0
        public Unity.Profiling.ProfilerMarker k_ParseTextMarker; // 0x1588
        public Unity.Profiling.ProfilerMarker k_InsertNewLineMarker; // 0x1590
        public bool m_ignoreActiveState; // 0x6B4
        public TextBackingContainer m_TextBackingArray; // 0x6B8
        public System.Decimal[] k_Power; // 0x6C8
        public UnityEngine.Vector2 k_LargePositiveVector2; // 0x1598
        public UnityEngine.Vector2 k_LargeNegativeVector2; // 0x15A0
        public float k_LargePositiveFloat; // 0x15A8
        public float k_LargeNegativeFloat; // 0x15AC
        public int k_LargePositiveInt; // 0x15B0
        public int k_LargeNegativeInt; // 0x15B4

        // ── Methods ──
        public void get_text(){} // RVA: 0x7FFAC9766E50
        public void set_text(){} // RVA: 0x7FFAC9766F30
        public void get_textPreprocessor(){} // RVA: 0x7FFAC2F8C2A0
        public void set_textPreprocessor(){} // RVA: 0x7FFAC2F8C2B0
        public void get_isRightToLeftText(){} // RVA: 0x7FFAC3C8E090
        public void set_isRightToLeftText(){} // RVA: 0x7FFAC9767040
        public void get_font(){} // RVA: 0x7FFAC34F6C80
        public void set_font(){} // RVA: 0x7FFAC97670A0
        public void get_fontSharedMaterial(){} // RVA: 0x7FFAC33BC6D0
        public void set_fontSharedMaterial(){} // RVA: 0x7FFAC9767270
        public void get_fontSharedMaterials(){} // RVA: 0x7FFAC97673E0
        public void set_fontSharedMaterials(){} // RVA: 0x7FFAC9767400
        public void get_fontMaterial(){} // RVA: 0x7FFAC9767460
        public void set_fontMaterial(){} // RVA: 0x7FFAC9767480
        public void get_fontMaterials(){} // RVA: 0x7FFAC9767640
        public void set_fontMaterials(){} // RVA: 0x7FFAC9767400
        public void get_color(){} // RVA: 0x7FFAC8A33FA0
        public void set_color(){} // RVA: 0x7FFAC9767660
        public void get_alpha(){} // RVA: 0x7FFAC97676F0
        public void set_alpha(){} // RVA: 0x7FFAC9767700
        public void get_enableVertexGradient(){} // RVA: 0x7FFAC400F720
        public void set_enableVertexGradient(){} // RVA: 0x7FFAC9767740
        public void get_colorGradient(){} // RVA: 0x7FFAC9767770
        public void set_colorGradient(){} // RVA: 0x7FFAC97677A0
        public void get_colorGradientPreset(){} // RVA: 0x7FFAC3549F30
        public void set_colorGradientPreset(){} // RVA: 0x7FFAC97677F0
        public void get_spriteAsset(){} // RVA: 0x7FFAC3544330
        public void set_spriteAsset(){} // RVA: 0x7FFAC9767870
        public void get_tintAllSprites(){} // RVA: 0x7FFAC8C41080
        public void set_tintAllSprites(){} // RVA: 0x7FFAC9767910
        public void get_styleSheet(){} // RVA: 0x7FFAC39CCB10
        public void set_styleSheet(){} // RVA: 0x7FFAC9767940
        public void get_textStyle(){} // RVA: 0x7FFAC97679E0
        public void set_textStyle(){} // RVA: 0x7FFAC9767C10
        public void get_overrideColorTags(){} // RVA: 0x7FFAC9767CD0
        public void set_overrideColorTags(){} // RVA: 0x7FFAC9767CE0
        public void get_faceColor(){} // RVA: 0x7FFAC9767D10
        public void set_faceColor(){} // RVA: 0x7FFAC9767EC0
        public void get_outlineColor(){} // RVA: 0x7FFAC9767F60
        public void set_outlineColor(){} // RVA: 0x7FFAC9768110
        public void get_outlineWidth(){} // RVA: 0x7FFAC97681A0
        public void set_outlineWidth(){} // RVA: 0x7FFAC9768330
        public void get_fontSize(){} // RVA: 0x7FFAC97683A0
        public void set_fontSize(){} // RVA: 0x7FFAC97683B0
        public void get_fontWeight(){} // RVA: 0x7FFAC9768420
        public void set_fontWeight(){} // RVA: 0x7FFAC9768430
        public void get_pixelsPerUnit(){} // RVA: 0x7FFAC9768490
        public void get_enableAutoSizing(){} // RVA: 0x7FFAC41276F0
        public void set_enableAutoSizing(){} // RVA: 0x7FFAC9768750
        public void get_fontSizeMin(){} // RVA: 0x7FFAC97687A0
        public void set_fontSizeMin(){} // RVA: 0x7FFAC97687B0
        public void get_fontSizeMax(){} // RVA: 0x7FFAC9768810
        public void set_fontSizeMax(){} // RVA: 0x7FFAC9768820
        public void get_fontStyle(){} // RVA: 0x7FFAC2F819C0
        public void set_fontStyle(){} // RVA: 0x7FFAC9768880
        public void get_isUsingBold(){} // RVA: 0x7FFAC97688E0
        public void get_horizontalAlignment(){} // RVA: 0x7FFAC97688F0
        public void set_horizontalAlignment(){} // RVA: 0x7FFAC9768900
        public void get_verticalAlignment(){} // RVA: 0x7FFAC9768930
        public void set_verticalAlignment(){} // RVA: 0x7FFAC9768940
        public void get_alignment(){} // RVA: 0x7FFAC9768970
        public void set_alignment(){} // RVA: 0x7FFAC9768980
        public void get_characterSpacing(){} // RVA: 0x7FFAC97689D0
        public void set_characterSpacing(){} // RVA: 0x7FFAC97689E0
        public void get_wordSpacing(){} // RVA: 0x7FFAC9768A40
        public void set_wordSpacing(){} // RVA: 0x7FFAC9768A50
        public void get_lineSpacing(){} // RVA: 0x7FFAC9768AB0
        public void set_lineSpacing(){} // RVA: 0x7FFAC9768AC0
        public void get_lineSpacingAdjustment(){} // RVA: 0x7FFAC9768B20
        public void set_lineSpacingAdjustment(){} // RVA: 0x7FFAC9768B30
        public void get_paragraphSpacing(){} // RVA: 0x7FFAC9768B90
        public void set_paragraphSpacing(){} // RVA: 0x7FFAC9768BA0
        public void get_characterWidthAdjustment(){} // RVA: 0x7FFAC9768C00
        public void set_characterWidthAdjustment(){} // RVA: 0x7FFAC9768C10
        public void get_enableWordWrapping(){} // RVA: 0x7FFAC8B130E0
        public void set_enableWordWrapping(){} // RVA: 0x7FFAC9768C70
        public void get_wordWrappingRatios(){} // RVA: 0x7FFAC9768CD0
        public void set_wordWrappingRatios(){} // RVA: 0x7FFAC9768CE0
        public void get_overflowMode(){} // RVA: 0x7FFAC9768D40
        public void set_overflowMode(){} // RVA: 0x7FFAC9768D50
        public void get_isTextOverflowing(){} // RVA: 0x7FFAC9768DB0
        public void get_firstOverflowCharacterIndex(){} // RVA: 0x7FFAC9768DC0
        public void get_linkedTextComponent(){} // RVA: 0x7FFAC39B9020
        public void set_linkedTextComponent(){} // RVA: 0x7FFAC9768DD0
        public void get_isTextTruncated(){} // RVA: 0x7FFAC9769040
        public void get_enableKerning(){} // RVA: 0x7FFAC9769050
        public void set_enableKerning(){} // RVA: 0x7FFAC9769060
        public void get_extraPadding(){} // RVA: 0x7FFAC97690C0
        public void set_extraPadding(){} // RVA: 0x7FFAC97690D0
        public void get_richText(){} // RVA: 0x7FFAC9769130
        public void set_richText(){} // RVA: 0x7FFAC9769140
        public void get_parseCtrlCharacters(){} // RVA: 0x7FFAC97691A0
        public void set_parseCtrlCharacters(){} // RVA: 0x7FFAC97691B0
        public void get_isOverlay(){} // RVA: 0x7FFAC9769210
        public void set_isOverlay(){} // RVA: 0x7FFAC9769220
        public void get_isOrthographic(){} // RVA: 0x7FFAC9769280
        public void set_isOrthographic(){} // RVA: 0x7FFAC9769290
        public void get_enableCulling(){} // RVA: 0x7FFAC97692C0
        public void set_enableCulling(){} // RVA: 0x7FFAC97692D0
        public void get_ignoreVisibility(){} // RVA: 0x7FFAC9769310
        public void set_ignoreVisibility(){} // RVA: 0x7FFAC9769320
        public void get_horizontalMapping(){} // RVA: 0x7FFAC9769340
        public void set_horizontalMapping(){} // RVA: 0x7FFAC9769350
        public void get_verticalMapping(){} // RVA: 0x7FFAC9769380
        public void set_verticalMapping(){} // RVA: 0x7FFAC9769390
        public void get_mappingUvLineOffset(){} // RVA: 0x7FFAC97693C0
        public void set_mappingUvLineOffset(){} // RVA: 0x7FFAC97693D0
        public void get_renderMode(){} // RVA: 0x7FFAC9769410
        public void set_renderMode(){} // RVA: 0x7FFAC9769420
        public void get_geometrySortingOrder(){} // RVA: 0x7FFAC9769440
        public void set_geometrySortingOrder(){} // RVA: 0x7FFAC9769450
        public void get_isTextObjectScaleStatic(){} // RVA: 0x7FFAC9769480
        public void set_isTextObjectScaleStatic(){} // RVA: 0x7FFAC9769490
        public void get_vertexBufferAutoSizeReduction(){} // RVA: 0x7FFAC9769520
        public void set_vertexBufferAutoSizeReduction(){} // RVA: 0x7FFAC9769530
        public void get_firstVisibleCharacter(){} // RVA: 0x7FFAC9769560
        public void set_firstVisibleCharacter(){} // RVA: 0x7FFAC9769570
        public void get_maxVisibleCharacters(){} // RVA: 0x7FFAC97695A0
        public void set_maxVisibleCharacters(){} // RVA: 0x7FFAC97695B0
        public void get_maxVisibleWords(){} // RVA: 0x7FFAC97695E0
        public void set_maxVisibleWords(){} // RVA: 0x7FFAC97695F0
        public void get_maxVisibleLines(){} // RVA: 0x7FFAC9769620
        public void set_maxVisibleLines(){} // RVA: 0x7FFAC9769630
        public void get_useMaxVisibleDescender(){} // RVA: 0x7FFAC9769660
        public void set_useMaxVisibleDescender(){} // RVA: 0x7FFAC9769670
        public void get_pageToDisplay(){} // RVA: 0x7FFAC97696A0
        public void set_pageToDisplay(){} // RVA: 0x7FFAC97696B0
        public void get_margin(){} // RVA: 0x7FFAC97696E0
        public void set_margin(){} // RVA: 0x7FFAC97696F0
        public void get_textInfo(){} // RVA: 0x7FFAC39CF840
        public void get_havePropertiesChanged(){} // RVA: 0x7FFAC97697B0
        public void set_havePropertiesChanged(){} // RVA: 0x7FFAC97697C0
        public void get_isUsingLegacyAnimationComponent(){} // RVA: 0x7FFAC97697F0
        public void set_isUsingLegacyAnimationComponent(){} // RVA: 0x7FFAC9769800
        public void get_transform(){} // RVA: 0x7FFAC9769810
        public void get_rectTransform(){} // RVA: 0x7FFAC9769960
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFAC9769AB0
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFAC9769AC0
        public void get_mesh(){} // RVA: 0x7FFAC39AD480
        public void get_isVolumetricText(){} // RVA: 0x7FFAC9769AD0
        public void set_isVolumetricText(){} // RVA: 0x7FFAC9769AE0
        public void get_bounds(){} // RVA: 0x7FFAC9769B50
        public void get_textBounds(){} // RVA: 0x7FFAC9769C90
        public void add_OnFontAssetRequest(){} // RVA: 0x7FFAC9769CF0
        public void remove_OnFontAssetRequest(){} // RVA: 0x7FFAC9769E50
        public void add_OnSpriteAssetRequest(){} // RVA: 0x7FFAC9769FB0
        public void remove_OnSpriteAssetRequest(){} // RVA: 0x7FFAC976A110
        public void add_OnPreRenderText(){} // RVA: 0x7FFAC976A270
        public void remove_OnPreRenderText(){} // RVA: 0x7FFAC976A370
        public void get_spriteAnimator(){} // RVA: 0x7FFAC976A470
        public void get_flexibleHeight(){} // RVA: 0x7FFAC976A730
        public void get_flexibleWidth(){} // RVA: 0x7FFAC976A740
        public void get_minWidth(){} // RVA: 0x7FFAC976A750
        public void get_minHeight(){} // RVA: 0x7FFAC976A760
        public void get_maxWidth(){} // RVA: 0x7FFAC976A770
        public void get_maxHeight(){} // RVA: 0x7FFAC976A780
        public void get_layoutElement(){} // RVA: 0x7FFAC976A790
        public void get_preferredWidth(){} // RVA: 0x7FFAC976A8E0
        public void get_preferredHeight(){} // RVA: 0x7FFAC976A900
        public void get_renderedWidth(){} // RVA: 0x7FFAC976A920
        public void get_renderedHeight(){} // RVA: 0x7FFAC976A950
        public void get_layoutPriority(){} // RVA: 0x7FFAC976A980
        public void LoadFontAsset(){} // RVA: 0x7FFAC2F21310
        public void SetSharedMaterial(){} // RVA: 0x7FFAC2F21310
        public void GetMaterial(){} // RVA: 0x7FFAC34F9180
        public void SetFontBaseMaterial(){} // RVA: 0x7FFAC2F21310
        public void GetSharedMaterials(){} // RVA: 0x7FFAC34F9180
        public void SetSharedMaterials(){} // RVA: 0x7FFAC2F21310
        public void GetMaterials(){} // RVA: 0x7FFAC34F9180
        public void CreateMaterialInstance(){} // RVA: 0x7FFAC976A990
        public void SetVertexColorGradient(){} // RVA: 0x7FFAC976AAC0
        public void SetTextSortingOrder(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void SetFaceColor(){} // RVA: 0x7FFAC2F21310
        public void SetOutlineColor(){} // RVA: 0x7FFAC2F21310
        public void SetOutlineThickness(){} // RVA: 0x7FFAC2F21310
        public void SetShaderDepth(){} // RVA: 0x7FFAC2F21310
        public void SetCulling(){} // RVA: 0x7FFAC2F21310
        public void UpdateCulling(){} // RVA: 0x7FFAC2F21310
        public void GetPaddingForMaterial(){} // RVA: 0x7FFAC976ADC0 | overloaded x2
        public void GetTextContainerLocalCorners(){} // RVA: 0x7FFAC34F9180
        public void ForceMeshUpdate(){} // RVA: 0x7FFAC2F21310
        public void UpdateGeometry(){} // RVA: 0x7FFAC2F21310
        public void UpdateVertexData(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void SetVertices(){} // RVA: 0x7FFAC2F21310
        public void UpdateMeshPadding(){} // RVA: 0x7FFAC2F21310
        public void CrossFadeColor(){} // RVA: 0x7FFAC976AF80
        public void CrossFadeAlpha(){} // RVA: 0x7FFAC976B030
        public void InternalCrossFadeColor(){} // RVA: 0x7FFAC2F21310
        public void InternalCrossFadeAlpha(){} // RVA: 0x7FFAC2F21310
        public void ParseInputText(){} // RVA: 0x7FFAC976B130
        public void PopulateTextBackingArray(){} // RVA: 0x7FFAC976B560 | overloaded x4
        public void PopulateTextProcessingArray(){} // RVA: 0x7FFAC976B6D0
        public void SetTextInternal(){} // RVA: 0x7FFAC976C460
        public void SetText(){} // RVA: 0x7FFAC976CC80 | overloaded x13
        public void SetCharArray(){} // RVA: 0x7FFAC976CC80 | overloaded x2
        public void GetStyle(){} // RVA: 0x7FFAC976CCF0
        public void ReplaceOpeningStyleTag(){} // RVA: 0x7FFAC976D350 | overloaded x2
        public void ReplaceClosingStyleTag(){} // RVA: 0x7FFAC976DB80 | overloaded x2
        public void InsertOpeningStyleTag(){} // RVA: 0x7FFAC976DF30
        public void InsertClosingStyleTag(){} // RVA: 0x7FFAC976E2E0
        public void GetMarkupTagHashCode(){} // RVA: 0x7FFAC976E730 | overloaded x2
        public void GetStyleHashCode(){} // RVA: 0x7FFAC976E8F0 | overloaded x2
        public void ResizeInternalArray(){} // RVA: 0x7FFAC2C77970 | overloaded x2
        public void AddFloatToInternalTextBackingArray(){} // RVA: 0x7FFAC976E9E0
        public void AddIntegerToInternalTextBackingArray(){} // RVA: 0x7FFAC976F0A0
        public void InternalTextBackingArrayToString(){} // RVA: 0x7FFAC976F2A0
        public void SetArraySizes(){} // RVA: 0x7FFAC34F9180
        public void GetPreferredValues(){} // RVA: 0x7FFAC976F560 | overloaded x4
        public void GetPreferredWidth(){} // RVA: 0x7FFAC976F830 | overloaded x2
        public void GetPreferredHeight(){} // RVA: 0x7FFAC976FB20 | overloaded x2
        public void GetRenderedValues(){} // RVA: 0x7FFAC976FC20 | overloaded x2
        public void GetRenderedWidth(){} // RVA: 0x7FFAC976FC60 | overloaded x2
        public void GetRenderedHeight(){} // RVA: 0x7FFAC976FC90 | overloaded x2
        public void CalculatePreferredValues(){} // RVA: 0x7FFAC976FCC0
        public void GetCompoundBounds(){} // RVA: 0x7FFAC684A7D0
        public void GetCanvasSpaceClippingRect(){} // RVA: 0x7FFAC3FB3780
        public void GetTextBounds(){} // RVA: 0x7FFAC9772E00 | overloaded x2
        public void AdjustLineOffset(){} // RVA: 0x7FFAC97730D0
        public void ResizeLineExtents(){} // RVA: 0x7FFAC9773560
        public void GetTextInfo(){} // RVA: 0x7FFAC34F9180
        public void ComputeMarginSize(){} // RVA: 0x7FFAC2F21310
        public void InsertNewLine(){} // RVA: 0x7FFAC9773850
        public void SaveWordWrappingState(){} // RVA: 0x7FFAC9774160
        public void RestoreWordWrappingState(){} // RVA: 0x7FFAC9774B40
        public void SaveGlyphVertexInfo(){} // RVA: 0x7FFAC9775580
        public void SaveSpriteVertexInfo(){} // RVA: 0x7FFAC9776A00
        public void FillCharacterVertexBuffers(){} // RVA: 0x7FFAC9777DC0 | overloaded x2
        public void FillSpriteVertexBuffers(){} // RVA: 0x7FFAC9778CC0
        public void DrawUnderlineMesh(){} // RVA: 0x7FFAC97795F0
        public void DrawTextHighlight(){} // RVA: 0x7FFAC977A480
        public void LoadDefaultSettings(){} // RVA: 0x7FFAC977A9E0
        public void GetSpecialCharacters(){} // RVA: 0x7FFAC977AFD0
        public void GetEllipsisSpecialCharacter(){} // RVA: 0x7FFAC977B000
        public void GetUnderlineSpecialCharacter(){} // RVA: 0x7FFAC977B400
        public void ReplaceTagWithCharacter(){} // RVA: 0x7FFAC977B630
        public void GetFontAssetForWeight(){} // RVA: 0x7FFAC977B690
        public void GetTextElement(){} // RVA: 0x7FFAC977B720
        public void SetActiveSubMeshes(){} // RVA: 0x7FFAC2F21310
        public void DestroySubMeshObjects(){} // RVA: 0x7FFAC2F21310
        public void ClearMesh(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void GetParsedText(){} // RVA: 0x7FFAC977BDA0
        public void IsSelfOrLinkedAncestor(){} // RVA: 0x7FFAC977BEA0
        public void ReleaseLinkedTextComponent(){} // RVA: 0x7FFAC977C060
        public void PackUV(){} // RVA: 0x7FFAC977C2E0 | overloaded x2
        public void InternalUpdate(){} // RVA: 0x7FFAC2F21310
        public void HexToInt(){} // RVA: 0x7FFAC977C320
        public void GetUTF16(){} // RVA: 0x7FFAC977C6C0 | overloaded x5
        public void GetUTF32(){} // RVA: 0x7FFAC977CC30 | overloaded x5
        public void HexCharsToColor(){} // RVA: 0x7FFAC977D3B0 | overloaded x2
        public void GetAttributeParameters(){} // RVA: 0x7FFAC977D680
        public void ConvertToFloat(){} // RVA: 0x7FFAC977D8A0 | overloaded x2
        public void ValidateHtmlTag(){} // RVA: 0x7FFAC977DA20
        public void .ctor(){} // RVA: 0x7FFAC9785130
        public void .cctor(){} // RVA: 0x7FFAC9786520
    }

    public class TMP_TextElement : Object
    {
        public 0x6B21BBE8 elementType; // 0x10
        public uint unicode; // 0x14
        public TMPro.TMP_Asset textAsset; // 0x18
        public UnityEngine.TextCore.Glyph glyph; // 0x20
        public uint glyphIndex; // 0x28
        public float scale; // 0x2C

        // ── Methods ──
        public void get_elementType(){} // RVA: 0x7FFAC2FEB5E0
        public void get_unicode(){} // RVA: 0x7FFAC33D5A20
        public void set_unicode(){} // RVA: 0x7FFAC33D4990
        public void get_textAsset(){} // RVA: 0x7FFAC2F247C0
        public void set_textAsset(){} // RVA: 0x7FFAC2F87E80
        public void get_glyph(){} // RVA: 0x7FFAC2F4F0C0
        public void set_glyph(){} // RVA: 0x7FFAC2F4F0D0
        public void get_glyphIndex(){} // RVA: 0x7FFAC32EC4C0
        public void set_glyphIndex(){} // RVA: 0x7FFAC369A6E0
        public void get_scale(){} // RVA: 0x7FFAC33EAB80
        public void set_scale(){} // RVA: 0x7FFAC33EA9D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_TextInfo : Object
    {
        public UnityEngine.Vector2 k_InfinityVectorPositive;
        public UnityEngine.Vector2 k_InfinityVectorNegative; // 0x8
        public TMPro.TMP_Text textComponent; // 0x10
        public int characterCount; // 0x18
        public int spriteCount; // 0x1C
        public int spaceCount; // 0x20
        public int wordCount; // 0x24
        public int linkCount; // 0x28
        public int lineCount; // 0x2C
        public int pageCount; // 0x30
        public int materialCount; // 0x34
        public TMPro.TMP_CharacterInfo[] characterInfo; // 0x38
        public TMPro.TMP_WordInfo[] wordInfo; // 0x40
        public TMPro.TMP_LinkInfo[] linkInfo; // 0x48
        public TMPro.TMP_LineInfo[] lineInfo; // 0x50
        public TMPro.TMP_PageInfo[] pageInfo; // 0x58
        public TMPro.TMP_MeshInfo[] meshInfo; // 0x60
        public TMPro.TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97A0A40 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAC97A0E80
        public void ClearAllData(){} // RVA: 0x7FFAC97A0F00
        public void ClearMeshInfo(){} // RVA: 0x7FFAC97A11F0
        public void ClearAllMeshInfo(){} // RVA: 0x7FFAC97A12B0
        public void ResetVertexLayout(){} // RVA: 0x7FFAC97A1360
        public void ClearUnusedVertices(){} // RVA: 0x7FFAC97A1420
        public void ClearLineInfo(){} // RVA: 0x7FFAC97A14E0
        public void ClearPageInfo(){} // RVA: 0x7FFAC97A17F0
        public void CopyMeshInfoVertexData(){} // RVA: 0x7FFAC97A1960
        public void Resize(){} // RVA: 0x7FFAC2C77A00 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC97A2090
    }

    public class TMP_TextParsingUtilities : Object
    {
        public TMPro.TMP_TextParsingUtilities instance;
        public string k_LookupStringL;
        public string k_LookupStringU;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC97A2100
        public void get_instance(){} // RVA: 0x7FFAC97A21A0
        public void GetHashCode(){} // RVA: 0x7FFAC97A2200
        public void GetHashCodeCaseSensitive(){} // RVA: 0x7FFAC97A2320
        public void ToLowerASCIIFast(){} // RVA: 0x7FFAC97A24E0 | overloaded x2
        public void ToUpperASCIIFast(){} // RVA: 0x7FFAC97A2460 | overloaded x2
        public void IsHighSurrogate(){} // RVA: 0x7FFAC97A2560
        public void IsLowSurrogate(){} // RVA: 0x7FFAC97A2580
        public void ConvertToUTF32(){} // RVA: 0x7FFAC97A25A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_TextProcessingStack`1 : ValueType
    {
        public T[] Count;
        public int current;
        public T rolloverSize;
        public int m_Capacity;
        public int m_RolloverSize;
        public int m_Count;
        public int k_DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72E60 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_current(){} // RVA: 0x7FFAC2E8DC40
        public void get_rolloverSize(){} // RVA: 0x7FFAC2C59960
        public void set_rolloverSize(){} // RVA: 0x7FFAC2C70ED0
        public void SetDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void Push(){} // RVA: 0x7FFAC2E8DC40
        public void Pop(){} // RVA: 0x7FFAC2E8DC40
        public void Peek(){} // RVA: 0x7FFAC2E8DC40
        public void CurrentItem(){} // RVA: 0x7FFAC2E8DC40
        public void PreviousItem(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TMP_TextUtilities : Object
    {
        public UnityEngine.Vector3[] m_rectWorldCorners;
        public string k_lookupStringL;
        public string k_lookupStringU;

        // ── Methods ──
        public void GetCursorIndexFromPosition(){} // RVA: 0x7FFAC97A29E0 | overloaded x2
        public void FindNearestLine(){} // RVA: 0x7FFAC97A2CE0
        public void FindNearestCharacterOnLine(){} // RVA: 0x7FFAC97A3010
        public void IsIntersectingRectTransform(){} // RVA: 0x7FFAC97A3710
        public void FindIntersectingCharacter(){} // RVA: 0x7FFAC97A39C0
        public void FindNearestCharacter(){} // RVA: 0x7FFAC97A3EE0
        public void FindIntersectingWord(){} // RVA: 0x7FFAC97A45B0
        public void FindNearestWord(){} // RVA: 0x7FFAC97A52F0
        public void FindIntersectingLine(){} // RVA: 0x7FFAC97A6400
        public void FindIntersectingLink(){} // RVA: 0x7FFAC97A6660
        public void FindNearestLink(){} // RVA: 0x7FFAC97A7200
        public void PointIntersectRectangle(){} // RVA: 0x7FFAC97A82F0
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x7FFAC97A8470
        public void IntersectLinePlane(){} // RVA: 0x7FFAC97A8A20
        public void DistanceToLine(){} // RVA: 0x7FFAC97A8C10
        public void ToLowerFast(){} // RVA: 0x7FFAC97A8DF0
        public void ToUpperFast(){} // RVA: 0x7FFAC97A8E60
        public void ToUpperASCIIFast(){} // RVA: 0x7FFAC97A8ED0
        public void GetHashCode(){} // RVA: 0x7FFAC97A8F50
        public void GetSimpleHashCode(){} // RVA: 0x7FFAC97A2320
        public void GetSimpleHashCodeLowercase(){} // RVA: 0x7FFAC97A9070
        public void HexToInt(){} // RVA: 0x7FFAC97A9190
        public void StringHexToInt(){} // RVA: 0x7FFAC97A92A0
        public void .cctor(){} // RVA: 0x7FFAC97A94A0
    }

    public class TMP_UpdateManager : Object
    {
        public TMPro.TMP_UpdateManager instance;
        public System.Collections.Generic.HashSet`1<int> m_LayoutQueueLookup; // 0x10
        public System.Collections.Generic.List`1<TMPro.TMP_Text> m_LayoutRebuildQueue; // 0x18
        public System.Collections.Generic.HashSet`1<int> m_GraphicQueueLookup; // 0x20
        public System.Collections.Generic.List`1<TMPro.TMP_Text> m_GraphicRebuildQueue; // 0x28
        public System.Collections.Generic.HashSet`1<int> m_InternalUpdateLookup; // 0x30
        public System.Collections.Generic.List`1<TMPro.TMP_Text> m_InternalUpdateQueue; // 0x38
        public System.Collections.Generic.HashSet`1<int> m_CullingUpdateLookup; // 0x40
        public System.Collections.Generic.List`1<TMPro.TMP_Text> m_CullingUpdateQueue; // 0x48
        public Unity.Profiling.ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC97A9560
        public void .ctor(){} // RVA: 0x7FFAC97A9680
        public void RegisterTextObjectForUpdate(){} // RVA: 0x7FFAC97A9AD0
        public void InternalRegisterTextObjectForUpdate(){} // RVA: 0x7FFAC97A9BF0
        public void RegisterTextElementForLayoutRebuild(){} // RVA: 0x7FFAC97A9CD0
        public void InternalRegisterTextElementForLayoutRebuild(){} // RVA: 0x7FFAC97A9DF0
        public void RegisterTextElementForGraphicRebuild(){} // RVA: 0x7FFAC97A9ED0
        public void InternalRegisterTextElementForGraphicRebuild(){} // RVA: 0x7FFAC97A9FF0
        public void RegisterTextElementForCullingUpdate(){} // RVA: 0x7FFAC97AA0D0
        public void InternalRegisterTextElementForCullingUpdate(){} // RVA: 0x7FFAC97AA1F0
        public void OnCameraPreCull(){} // RVA: 0x7FFAC97AA2D0
        public void DoRebuilds(){} // RVA: 0x7FFAC97AA2E0
        public void UnRegisterTextObjectForUpdate(){} // RVA: 0x7FFAC97AA6E0
        public void UnRegisterTextElementForRebuild(){} // RVA: 0x7FFAC97AA750
        public void InternalUnRegisterTextElementForGraphicRebuild(){} // RVA: 0x7FFAC97AA8E0
        public void InternalUnRegisterTextElementForLayoutRebuild(){} // RVA: 0x7FFAC97AA980
        public void InternalUnRegisterTextObjectForUpdate(){} // RVA: 0x7FFAC97AAA20
        public void .cctor(){} // RVA: 0x7FFAC97AAAC0
    }

    public class TMP_UpdateRegistry : Object
    {
        public TMPro.TMP_UpdateRegistry instance;
        public System.Collections.Generic.List`1<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue; // 0x10
        public System.Collections.Generic.HashSet`1<int> m_LayoutQueueLookup; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue; // 0x20
        public System.Collections.Generic.HashSet`1<int> m_GraphicQueueLookup; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC97AAD50
        public void .ctor(){} // RVA: 0x7FFAC97AAE30
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC97AB0C0
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC97AB200
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC97AB350
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC97AB490
        public void PerformUpdateForCanvasRendererObjects(){} // RVA: 0x7FFAC97AB5E0
        public void PerformUpdateForMeshRendererObjects(){} // RVA: 0x7FFAC97AB970
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7FFAC97AB9D0
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC97ABBE0
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC97ABCE0
    }

    public class TMP_Vertex : ValueType
    {
        public UnityEngine.Vector3 zero; // 0x10
        public UnityEngine.Vector2 uv; // 0x1C
        public UnityEngine.Vector2 uv2; // 0x24
        public UnityEngine.Vector2 uv4; // 0x2C
        public UnityEngine.Color32 color; // 0x34
        public TMPro.TMP_Vertex k_Zero;

        // ── Methods ──
        public void get_zero(){} // RVA: 0x7FFAC9739D50
        public void .cctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TMP_WordInfo : ValueType
    {
        public TMPro.TMP_Text textComponent; // 0x10
        public int firstCharacterIndex; // 0x18
        public int lastCharacterIndex; // 0x1C
        public int characterCount; // 0x20

        // ── Methods ──
        public void GetWord(){} // RVA: 0x7FFAC97394B0
    }

    public class TMPro_EventManager : Object
    {
        public TMPro.FastAction`2<object,TMPro.Compute_DT_EventArgs> COMPUTE_DT_EVENT;
        public TMPro.FastAction`2<bool,UnityEngine.Material> MATERIAL_PROPERTY_EVENT; // 0x8
        public TMPro.FastAction`2<bool,UnityEngine.Object> FONT_PROPERTY_EVENT; // 0x10
        public TMPro.FastAction`2<bool,UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
        public TMPro.FastAction`2<bool,UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
        public TMPro.FastAction`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
        public TMPro.FastAction`1<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
        public TMPro.FastAction`1<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
        public TMPro.FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
        public TMPro.FastAction RESOURCE_LOAD_EVENT; // 0x48
        public TMPro.FastAction`2<bool,UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
        public TMPro.FastAction`1<UnityEngine.Object> TEXT_CHANGED_EVENT; // 0x58

        // ── Methods ──
        public void ON_MATERIAL_PROPERTY_CHANGED(){} // RVA: 0x7FFAC97373F0
        public void ON_FONT_PROPERTY_CHANGED(){} // RVA: 0x7FFAC9737490
        public void ON_SPRITE_ASSET_PROPERTY_CHANGED(){} // RVA: 0x7FFAC9737530
        public void ON_TEXTMESHPRO_PROPERTY_CHANGED(){} // RVA: 0x7FFAC97375D0
        public void ON_DRAG_AND_DROP_MATERIAL_CHANGED(){} // RVA: 0x7FFAC9737670
        public void ON_TEXT_STYLE_PROPERTY_CHANGED(){} // RVA: 0x7FFAC9737770
        public void ON_COLOR_GRADIENT_PROPERTY_CHANGED(){} // RVA: 0x7FFAC9737840
        public void ON_TEXT_CHANGED(){} // RVA: 0x7FFAC97378C0
        public void ON_TMP_SETTINGS_CHANGED(){} // RVA: 0x7FFAC9737940
        public void ON_RESOURCES_LOADED(){} // RVA: 0x7FFAC97379B0
        public void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(){} // RVA: 0x7FFAC9737A20
        public void ON_COMPUTE_DT_EVENT(){} // RVA: 0x7FFAC9737AC0
        public void .cctor(){} // RVA: 0x7FFAC9737BA0
    }

    public class TMPro_ExtensionMethods : Object
    {
        // ── Methods ──
        public void ToIntArray(){} // RVA: 0x7FFAC97386E0
        public void ArrayToString(){} // RVA: 0x7FFAC9738780
        public void IntToString(){} // RVA: 0x7FFAC9738A20 | overloaded x2
        public void UintToString(){} // RVA: 0x7FFAC9738950
        public void FindInstanceID(){} // RVA: 0x7FFAC2E8DC40
        public void Compare(){} // RVA: 0x7FFAC9738E10 | overloaded x4
        public void CompareRGB(){} // RVA: 0x7FFAC8BF9BC0 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFAC9738B90
        public void Tint(){} // RVA: 0x7FFAC9738C70 | overloaded x2
        public void MinAlpha(){} // RVA: 0x7FFAC9738D50
    }

    public class TagAttribute : ValueType
    {
        public int startIndex; // 0x10
        public int length; // 0x14
        public int hashCode; // 0x18
    }

    public class TextContainer : UIBehaviour
    {
        public bool hasChanged; // 0x20
        public UnityEngine.Vector2 pivot; // 0x24
        public 0x6B218B18 anchorPosition; // 0x2C
        public UnityEngine.Rect rect; // 0x30
        public bool size; // 0x40
        public bool width; // 0x41
        public bool height; // 0x42
        public UnityEngine.Vector3[] isDefaultWidth; // 0x48
        public UnityEngine.Vector3[] isDefaultHeight; // 0x50
        public UnityEngine.Vector4 isAutoFitting; // 0x58
        public UnityEngine.RectTransform corners; // 0x68
        public UnityEngine.Vector2 worldCorners;
        public TMPro.TextMeshPro margins; // 0x70

        // ── Methods ──
        public void get_hasChanged(){} // RVA: 0x7FFAC300F9D0
        public void set_hasChanged(){} // RVA: 0x7FFAC300F9E0
        public void get_pivot(){} // RVA: 0x7FFAC971C400
        public void set_pivot(){} // RVA: 0x7FFAC971C420
        public void get_anchorPosition(){} // RVA: 0x7FFAC3C891D0
        public void set_anchorPosition(){} // RVA: 0x7FFAC971C4A0
        public void get_rect(){} // RVA: 0x7FFAC845FF30
        public void set_rect(){} // RVA: 0x7FFAC971C5D0
        public void get_size(){} // RVA: 0x7FFAC971C630
        public void set_size(){} // RVA: 0x7FFAC971C650
        public void get_width(){} // RVA: 0x7FFAC971C6E0
        public void set_width(){} // RVA: 0x7FFAC971C6F0
        public void get_height(){} // RVA: 0x7FFAC971C740
        public void set_height(){} // RVA: 0x7FFAC971C750
        public void get_isDefaultWidth(){} // RVA: 0x7FFAC2FDCC00
        public void get_isDefaultHeight(){} // RVA: 0x7FFAC31D8A60
        public void get_isAutoFitting(){} // RVA: 0x7FFAC31D90A0
        public void set_isAutoFitting(){} // RVA: 0x7FFAC31D9200
        public void get_corners(){} // RVA: 0x7FFAC2F9C730
        public void get_worldCorners(){} // RVA: 0x7FFAC2FC20E0
        public void get_margins(){} // RVA: 0x7FFAC3BCB4D0
        public void set_margins(){} // RVA: 0x7FFAC971C7A0
        public void get_rectTransform(){} // RVA: 0x7FFAC971C820
        public void get_textMeshPro(){} // RVA: 0x7FFAC971C960
        public void Awake(){} // RVA: 0x7FFAC971CAA0
        public void OnEnable(){} // RVA: 0x7FFAC971CB90
        public void OnDisable(){} // RVA: 0x7FFAC2F21310
        public void OnContainerChanged(){} // RVA: 0x7FFAC971CBA0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC971CF30
        public void SetRect(){} // RVA: 0x7FFAC971D420
        public void UpdateCorners(){} // RVA: 0x7FFAC971D470
        public void GetPivot(){} // RVA: 0x7FFAC971D6B0
        public void GetAnchorPosition(){} // RVA: 0x7FFAC971D810
        public void .ctor(){} // RVA: 0x7FFAC971DA20
        public void .cctor(){} // RVA: 0x7FFAC971DB60
    }

    public class TextMeshPro : TMP_Text
    {
        public int sortingLayerID; // 0x6D0
        public int sortingOrder; // 0x6D4
        public int autoSizeTextContainer; // 0x6D8
        public System.Action`1<TMPro.TMP_TextInfo> textContainer; // 0x6E0
        public bool transform; // 0x6E8
        public bool renderer; // 0x6E9
        public float mesh; // 0x6EC
        public UnityEngine.Renderer meshFilter; // 0x6F0
        public UnityEngine.MeshFilter maskType; // 0x6F8
        public bool m_isFirstAllocation; // 0x700
        public int m_max_characters; // 0x704
        public int m_max_numberOfLines; // 0x708
        public TMPro.TMP_SubMesh[] m_subTextObjects; // 0x710
        public 0x6B21B770 m_maskType; // 0x718
        public UnityEngine.Matrix4x4 m_EnvMapMatrix; // 0x71C
        public UnityEngine.Vector3[] m_RectTransformCorners; // 0x760
        public bool m_isRegisteredForEvents; // 0x768
        public Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        public Unity.Profiling.ProfilerMarker k_SetArraySizesMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_CharacterLookupMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
        public Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
        public Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
        public Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
        public Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
        public Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
        public Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
        public Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
        public Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
        public Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
        public Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker; // 0x78
        public Unity.Profiling.ProfilerMarker k_SavePageInfoMarker; // 0x80
        public Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
        public Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
        public Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98

        // ── Methods ──
        public void get_sortingLayerID(){} // RVA: 0x7FFAC971DBB0
        public void set_sortingLayerID(){} // RVA: 0x7FFAC971DCF0
        public void get_sortingOrder(){} // RVA: 0x7FFAC971DE40
        public void set_sortingOrder(){} // RVA: 0x7FFAC971DF80
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFAC971E0D0
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFAC971E0E0
        public void get_textContainer(){} // RVA: 0x7FFAC34F9180
        public void get_transform(){} // RVA: 0x7FFAC971E270
        public void get_renderer(){} // RVA: 0x7FFAC971E3C0
        public void get_mesh(){} // RVA: 0x7FFAC971E510
        public void get_meshFilter(){} // RVA: 0x7FFAC971E6C0
        public void get_maskType(){} // RVA: 0x7FFAC971E9A0
        public void set_maskType(){} // RVA: 0x7FFAC971E9B0
        public void SetMask(){} // RVA: 0x7FFAC9721CA0 | overloaded x3
        public void SetVerticesDirty(){} // RVA: 0x7FFAC971ECD0
        public void SetLayoutDirty(){} // RVA: 0x7FFAC971EEE0
        public void SetMaterialDirty(){} // RVA: 0x7FFAC8595F00
        public void SetAllDirty(){} // RVA: 0x7FFAC971F010
        public void Rebuild(){} // RVA: 0x7FFAC971F060
        public void UpdateMaterial(){} // RVA: 0x7FFAC971F1B0
        public void UpdateMeshPadding(){} // RVA: 0x7FFAC971F470
        public void ForceMeshUpdate(){} // RVA: 0x7FFAC971F600
        public void GetTextInfo(){} // RVA: 0x7FFAC971F620
        public void ClearMesh(){} // RVA: 0x7FFAC971F6A0
        public void add_OnPreRenderText(){} // RVA: 0x7FFAC971F840
        public void remove_OnPreRenderText(){} // RVA: 0x7FFAC971F940
        public void UpdateGeometry(){} // RVA: 0x7FFAC971FA40
        public void UpdateVertexData(){} // RVA: 0x7FFAC971FC70 | overloaded x2
        public void UpdateFontAsset(){} // RVA: 0x7FFAC971FEA0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void Awake(){} // RVA: 0x7FFAC971FEC0
        public void OnEnable(){} // RVA: 0x7FFAC97208F0
        public void OnDisable(){} // RVA: 0x7FFAC9720A40
        public void OnDestroy(){} // RVA: 0x7FFAC9720B30
        public void LoadFontAsset(){} // RVA: 0x7FFAC9720CB0
        public void UpdateEnvMapMatrix(){} // RVA: 0x7FFAC97217D0
        public void SetMaskCoordinates(){} // RVA: 0x7FFAC9721F60 | overloaded x2
        public void EnableMasking(){} // RVA: 0x7FFAC9722160
        public void DisableMasking(){} // RVA: 0x7FFAC97223A0
        public void UpdateMask(){} // RVA: 0x7FFAC9722820
        public void GetMaterial(){} // RVA: 0x7FFAC9722A90
        public void GetMaterials(){} // RVA: 0x7FFAC9722CE0
        public void SetSharedMaterial(){} // RVA: 0x7FFAC9722F90
        public void GetSharedMaterials(){} // RVA: 0x7FFAC9723020
        public void SetSharedMaterials(){} // RVA: 0x7FFAC9723230
        public void SetOutlineThickness(){} // RVA: 0x7FFAC97237C0
        public void SetFaceColor(){} // RVA: 0x7FFAC9723B80
        public void SetOutlineColor(){} // RVA: 0x7FFAC9723ED0
        public void CreateMaterialInstance(){} // RVA: 0x7FFAC9724220
        public void SetShaderDepth(){} // RVA: 0x7FFAC97243D0
        public void SetCulling(){} // RVA: 0x7FFAC9724770
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFAC9724CF0
        public void SetArraySizes(){} // RVA: 0x7FFAC9724E40
        public void ComputeMarginSize(){} // RVA: 0x7FFAC9727940
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9727B70
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9727BA0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9727BE0
        public void InternalUpdate(){} // RVA: 0x7FFAC9727E80
        public void OnPreRenderObject(){} // RVA: 0x7FFAC9727F90
        public void GenerateTextMesh(){} // RVA: 0x7FFAC96FED90
        public void GetTextContainerLocalCorners(){} // RVA: 0x7FFAC97282A0
        public void SetMeshFilters(){} // RVA: 0x7FFAC9728400
        public void SetActiveSubMeshes(){} // RVA: 0x7FFAC9728780
        public void SetActiveSubTextObjectRenderers(){} // RVA: 0x7FFAC9728960
        public void DestroySubMeshObjects(){} // RVA: 0x7FFAC9728B90
        public void UpdateSubMeshSortingLayerID(){} // RVA: 0x7FFAC9728D80
        public void UpdateSubMeshSortingOrder(){} // RVA: 0x7FFAC9728FA0
        public void GetCompoundBounds(){} // RVA: 0x7FFAC97291C0
        public void UpdateSDFScale(){} // RVA: 0x7FFAC9729580
        public void .ctor(){} // RVA: 0x7FFAC9729780
        public void .cctor(){} // RVA: 0x7FFAC97298F0
    }

    public class TextMeshProUGUI : TMP_Text
    {
        public bool materialForRendering; // 0x6D0
        public UnityEngine.Coroutine autoSizeTextContainer; // 0x6D8
        public UnityEngine.Coroutine mesh; // 0x6E0
        public UnityEngine.Rect canvasRenderer; // 0x6E8
        public bool maskOffset; // 0x6F8
        public System.Action`1<TMPro.TMP_TextInfo> OnPreRenderText; // 0x700
        public bool m_hasFontAssetChanged; // 0x708
        public TMPro.TMP_SubMeshUI[] m_subTextObjects; // 0x710
        public float m_previousLossyScaleY; // 0x718
        public UnityEngine.Vector3[] m_RectTransformCorners; // 0x720
        public UnityEngine.CanvasRenderer m_canvasRenderer; // 0x728
        public UnityEngine.Canvas m_canvas; // 0x730
        public float m_CanvasScaleFactor; // 0x738
        public bool m_isFirstAllocation; // 0x73C
        public int m_max_characters; // 0x740
        public UnityEngine.Material m_baseMaterial; // 0x748
        public bool m_isScrollRegionSet; // 0x750
        public UnityEngine.Vector4 m_maskOffset; // 0x754
        public UnityEngine.Matrix4x4 m_EnvMapMatrix; // 0x764
        public bool m_isRegisteredForEvents; // 0x7A4
        public Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        public Unity.Profiling.ProfilerMarker k_SetArraySizesMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_CharacterLookupMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
        public Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
        public Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
        public Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
        public Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
        public Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
        public Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
        public Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
        public Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
        public Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
        public Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker; // 0x78
        public Unity.Profiling.ProfilerMarker k_SavePageInfoMarker; // 0x80
        public Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
        public Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
        public Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98

        // ── Methods ──
        public void get_materialForRendering(){} // RVA: 0x7FFAC972A2A0
        public void get_autoSizeTextContainer(){} // RVA: 0x7FFAC971E0D0
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFAC972A310
        public void get_mesh(){} // RVA: 0x7FFAC39AD480
        public void get_canvasRenderer(){} // RVA: 0x7FFAC972A3A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void SetVerticesDirty(){} // RVA: 0x7FFAC972A4F0
        public void SetLayoutDirty(){} // RVA: 0x7FFAC972A640
        public void SetMaterialDirty(){} // RVA: 0x7FFAC972A790
        public void SetAllDirty(){} // RVA: 0x7FFAC971F010
        public void DelayedGraphicRebuild(){} // RVA: 0x7FFAC972A8F0
        public void DelayedMaterialRebuild(){} // RVA: 0x7FFAC972A990
        public void Rebuild(){} // RVA: 0x7FFAC972AA30
        public void UpdateSubObjectPivot(){} // RVA: 0x7FFAC972AB80
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC972ADA0
        public void UpdateMaterial(){} // RVA: 0x7FFAC972AF40
        public void get_maskOffset(){} // RVA: 0x7FFAC972B110
        public void set_maskOffset(){} // RVA: 0x7FFAC972B120
        public void RecalculateClipping(){} // RVA: 0x7FFAC972B150
        public void Cull(){} // RVA: 0x7FFAC972B160
        public void UpdateCulling(){} // RVA: 0x7FFAC972B580
        public void UpdateMeshPadding(){} // RVA: 0x7FFAC972B890
        public void InternalCrossFadeColor(){} // RVA: 0x7FFAC972BA30
        public void InternalCrossFadeAlpha(){} // RVA: 0x7FFAC972BB20
        public void ForceMeshUpdate(){} // RVA: 0x7FFAC972BBF0
        public void GetTextInfo(){} // RVA: 0x7FFAC972BD50
        public void ClearMesh(){} // RVA: 0x7FFAC972BF00
        public void add_OnPreRenderText(){} // RVA: 0x7FFAC972C110
        public void remove_OnPreRenderText(){} // RVA: 0x7FFAC972C210
        public void UpdateGeometry(){} // RVA: 0x7FFAC972C310
        public void UpdateVertexData(){} // RVA: 0x7FFAC972C670 | overloaded x2
        public void UpdateFontAsset(){} // RVA: 0x7FFAC971FEA0
        public void Awake(){} // RVA: 0x7FFAC972C8F0
        public void OnEnable(){} // RVA: 0x7FFAC972D250
        public void OnDisable(){} // RVA: 0x7FFAC972D3F0
        public void OnDestroy(){} // RVA: 0x7FFAC972D640
        public void LoadFontAsset(){} // RVA: 0x7FFAC972D920
        public void GetCanvas(){} // RVA: 0x7FFAC972E360
        public void UpdateEnvMapMatrix(){} // RVA: 0x7FFAC972E560
        public void EnableMasking(){} // RVA: 0x7FFAC972EA30
        public void DisableMasking(){} // RVA: 0x7FFAC2F21310
        public void UpdateMask(){} // RVA: 0x7FFAC972EEB0
        public void GetMaterial(){} // RVA: 0x7FFAC972F5A0
        public void GetMaterials(){} // RVA: 0x7FFAC972F810
        public void SetSharedMaterial(){} // RVA: 0x7FFAC9722F90
        public void GetSharedMaterials(){} // RVA: 0x7FFAC972FAD0
        public void SetSharedMaterials(){} // RVA: 0x7FFAC972FCE0
        public void SetOutlineThickness(){} // RVA: 0x7FFAC9730300
        public void SetFaceColor(){} // RVA: 0x7FFAC9730750
        public void SetOutlineColor(){} // RVA: 0x7FFAC9730A30
        public void SetShaderDepth(){} // RVA: 0x7FFAC9730D10
        public void SetCulling(){} // RVA: 0x7FFAC9730F80
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFAC9731570
        public void SetMeshArrays(){} // RVA: 0x7FFAC97316C0
        public void SetArraySizes(){} // RVA: 0x7FFAC97317D0
        public void ComputeMarginSize(){} // RVA: 0x7FFAC9734460
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9734690
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC97346D0
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC97348E0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9734AE0
        public void InternalUpdate(){} // RVA: 0x7FFAC9734F50
        public void OnPreRenderCanvas(){} // RVA: 0x7FFAC9735060
        public void GenerateTextMesh(){} // RVA: 0x7FFAC970C4D0
        public void GetTextContainerLocalCorners(){} // RVA: 0x7FFAC97354B0
        public void SetActiveSubMeshes(){} // RVA: 0x7FFAC9735610
        public void DestroySubMeshObjects(){} // RVA: 0x7FFAC97357F0
        public void GetCompoundBounds(){} // RVA: 0x7FFAC97359E0
        public void GetCanvasSpaceClippingRect(){} // RVA: 0x7FFAC9735DA0
        public void UpdateSDFScale(){} // RVA: 0x7FFAC97362D0
        public void .ctor(){} // RVA: 0x7FFAC9736570
        public void .cctor(){} // RVA: 0x7FFAC97366D0
    }

    public class TweenRunner`1 : Object
    {
        public UnityEngine.MonoBehaviour m_CoroutineContainer;
        public System.Collections.IEnumerator m_Tween;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2E8DC40
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void StartTween(){} // RVA: 0x7FFAC2E8DC40
        public void StopTween(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class VertexGradient : ValueType
    {
        public UnityEngine.Color topLeft; // 0x10
        public UnityEngine.Color topRight; // 0x20
        public UnityEngine.Color bottomLeft; // 0x30
        public UnityEngine.Color bottomRight; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC969EF30 | overloaded x2
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
        public 0x6B21B610 horizontalAlignment; // 0x54
        public float marginLeft; // 0x58
        public float marginRight; // 0x5C
        public float xAdvance; // 0x60
        public float preferredWidth; // 0x64
        public float preferredHeight; // 0x68
        public float previousLineScale; // 0x6C
        public int wordCount; // 0x70
        public 0x6B21B8D0 fontStyle; // 0x74
        public int italicAngle; // 0x78
        public float fontScaleMultiplier; // 0x7C
        public float currentFontSize; // 0x80
        public float baselineOffset; // 0x84
        public float lineOffset; // 0x88
        public bool isDrivenLineSpacing; // 0x8C
        public float glyphHorizontalAdvanceAdjustment; // 0x90
        public float cSpace; // 0x94
        public float mSpace; // 0x98
        public TMPro.TMP_TextInfo textInfo; // 0xA0
        public TMPro.TMP_LineInfo lineInfo; // 0xA8
        public UnityEngine.Color32 vertexColor; // 0x104
        public UnityEngine.Color32 underlineColor; // 0x108
        public UnityEngine.Color32 strikethroughColor; // 0x10C
        public UnityEngine.Color32 highlightColor; // 0x110
        public TMPro.TMP_FontStyleStack basicStyleStack; // 0x114
        public TMPro.TMP_TextProcessingStack`1<int> italicAngleStack; // 0x120
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> colorStack; // 0x140
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> underlineColorStack; // 0x160
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> strikethroughColorStack; // 0x180
        public TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> highlightColorStack; // 0x1A0
        public TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState> highlightStateStack; // 0x1C0
        public TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient> colorGradientStack; // 0x1F0
        public TMPro.TMP_TextProcessingStack`1<float> sizeStack; // 0x218
        public TMPro.TMP_TextProcessingStack`1<float> indentStack; // 0x238
        public TMPro.TMP_TextProcessingStack`1<0x6B21B928> fontWeightStack; // 0x258
        public TMPro.TMP_TextProcessingStack`1<int> styleStack; // 0x278
        public TMPro.TMP_TextProcessingStack`1<float> baselineStack; // 0x298
        public TMPro.TMP_TextProcessingStack`1<int> actionStack; // 0x2B8
        public TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference> materialReferenceStack; // 0x2D8
        public TMPro.TMP_TextProcessingStack`1<0x6B21B610> lineJustificationStack; // 0x330
        public int spriteAnimationID; // 0x350
        public TMPro.TMP_FontAsset currentFontAsset; // 0x358
        public TMPro.TMP_SpriteAsset currentSpriteAsset; // 0x360
        public UnityEngine.Material currentMaterial; // 0x368
        public int currentMaterialIndex; // 0x370
        public TMPro.Extents meshExtents; // 0x374
        public bool tagNoParsing; // 0x384
        public bool isNonBreakingSpace; // 0x385
    }

}