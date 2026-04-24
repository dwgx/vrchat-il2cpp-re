// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI
// Classes: 64
// Methods: 1216

namespace ThirdParty.Unity.UnityEngine.UI
{
    public class AnimationTriggers : Object
    {
        public string normalTrigger;
        public string highlightedTrigger;
        public string pressedTrigger;
        public string selectedTrigger;
        public string disabledTrigger;
        public string m_NormalTrigger; // 0x10
        public string m_HighlightedTrigger; // 0x18
        public string m_PressedTrigger; // 0x20
        public string m_SelectedTrigger; // 0x28
        public string m_DisabledTrigger; // 0x30

        // ── Methods ──
        public void get_normalTrigger(){} // RVA: 0x7FFD4E35C380
        public void set_normalTrigger(){} // RVA: 0x7FFD4E342E30
        public void get_highlightedTrigger(){} // RVA: 0x7FFD4E3447C0
        public void set_highlightedTrigger(){} // RVA: 0x7FFD4E3A7E80
        public void get_pressedTrigger(){} // RVA: 0x7FFD4E36F0C0
        public void set_pressedTrigger(){} // RVA: 0x7FFD4E36F0D0
        public void get_selectedTrigger(){} // RVA: 0x7FFD4E36F130
        public void set_selectedTrigger(){} // RVA: 0x7FFD4E342E90
        public void get_disabledTrigger(){} // RVA: 0x7FFD4E5F95E0
        public void set_disabledTrigger(){} // RVA: 0x7FFD4E36F890
        public void .ctor(){} // RVA: 0x7FFD54E72040
    }

    public class AspectRatioFitter : UIBehaviour
    {
        public 1 aspectMode; // 0x20
        public float aspectRatio; // 0x24
        public 16 rectTransform; // 0x28
        public bool m_DelayedSetDirty; // 0x30
        public bool m_DoesParentExist; // 0x31
        public tton13 m_Tracker; // 0x32

        // ── Methods ──
        public void get_aspectMode(){} // RVA: 0x7FFD4E4FBBE0
        public void set_aspectMode(){} // RVA: 0x7FFD55067EB0
        public void get_aspectRatio(){} // RVA: 0x7FFD4E4AEF50
        public void set_aspectRatio(){} // RVA: 0x7FFD55067F10
        public void get_rectTransform(){} // RVA: 0x7FFD55067F70
        public void .ctor(){} // RVA: 0x7FFD4E4E00D0
        public void OnEnable(){} // RVA: 0x7FFD550680B0
        public void Start(){} // RVA: 0x7FFD550681F0
        public void OnDisable(){} // RVA: 0x7FFD55068270
        public void OnTransformParentChanged(){} // RVA: 0x7FFD550682D0
        public void Update(){} // RVA: 0x7FFD55068410
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD55068430
        public void UpdateRect(){} // RVA: 0x7FFD55068440
        public void GetSizeDeltaToProduceSize(){} // RVA: 0x7FFD55068830
        public void GetParentSize(){} // RVA: 0x7FFD55068AA0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD4E341310
        public void SetLayoutVertical(){} // RVA: 0x7FFD4E341310
        public void SetDirty(){} // RVA: 0x7FFD55068430
        public void IsComponentValidOnObject(){} // RVA: 0x7FFD55068CA0
        public void IsAspectModeValid(){} // RVA: 0x7FFD55068E70
        public void DoesParentExists(){} // RVA: 0x7FFD4E367470
    }

    public class BaseMeshEffect : UIBehaviour
    {
        public ePathName117.hInputPathName124 graphic; // 0x20

        // ── Methods ──
        public void get_graphic(){} // RVA: 0x7FFD55094F50
        public void OnEnable(){} // RVA: 0x7FFD55095090
        public void OnDisable(){} // RVA: 0x7FFD55095190
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD55095290
        public void ModifyMesh(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Button : Selectable
    {
        public me20 onClick; // 0x100

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54E72290
        public void get_onClick(){} // RVA: 0x7FFD4E916C80
        public void set_onClick(){} // RVA: 0x7FFD4E916750
        public void Press(){} // RVA: 0x7FFD54E723D0
        public void OnPointerClick(){} // RVA: 0x7FFD54E72470
        public void OnSubmit(){} // RVA: 0x7FFD54E724A0
        public void OnFinishSubmit(){} // RVA: 0x7FFD54E725B0
    }

    public class CanvasScaler : UIBehaviour
    {
        public rder uiScaleMode; // 0x20
        public float referencePixelsPerUnit; // 0x24
        public float scaleFactor; // 0x28
        public tionX referenceResolution; // 0x2C
        public eamVR_TrackingLossColor_String screenMatchMode; // 0x34
        public float matchWidthOrHeight; // 0x38
        public float physicalUnit;
        public object fallbackScreenDPI; // 0x3C
        public float defaultSpriteDPI; // 0x40
        public float dynamicPixelsPerUnit; // 0x44
        public float m_DynamicPixelsPerUnit; // 0x48
        public pad m_Canvas; // 0x50
        public float m_PrevScaleFactor; // 0x58
        public float m_PrevReferencePixelsPerUnit; // 0x5C
        public bool m_PresetInfoIsWorld; // 0x60

        // ── Methods ──
        public void get_uiScaleMode(){} // RVA: 0x7FFD4E4FBBE0
        public void set_uiScaleMode(){} // RVA: 0x7FFD4E9FB7A0
        public void get_referencePixelsPerUnit(){} // RVA: 0x7FFD4E4AEF50
        public void set_referencePixelsPerUnit(){} // RVA: 0x7FFD4E4AEF60
        public void get_scaleFactor(){} // RVA: 0x7FFD4E420210
        public void set_scaleFactor(){} // RVA: 0x7FFD55068E90
        public void get_referenceResolution(){} // RVA: 0x7FFD55068EB0
        public void set_referenceResolution(){} // RVA: 0x7FFD55068ED0
        public void get_screenMatchMode(){} // RVA: 0x7FFD4EEFEDC0
        public void set_screenMatchMode(){} // RVA: 0x7FFD4F58A6E0
        public void get_matchWidthOrHeight(){} // RVA: 0x7FFD4EB36E90
        public void set_matchWidthOrHeight(){} // RVA: 0x7FFD4EB37190
        public void get_physicalUnit(){} // RVA: 0x7FFD4E7DD4A0
        public void set_physicalUnit(){} // RVA: 0x7FFD4FC02CD0
        public void get_fallbackScreenDPI(){} // RVA: 0x7FFD4E5080B0
        public void set_fallbackScreenDPI(){} // RVA: 0x7FFD4E50FD80
        public void get_defaultSpriteDPI(){} // RVA: 0x7FFD4E349970
        public void set_defaultSpriteDPI(){} // RVA: 0x7FFD55068F50
        public void get_dynamicPixelsPerUnit(){} // RVA: 0x7FFD4F9E0DE0
        public void set_dynamicPixelsPerUnit(){} // RVA: 0x7FFD4F9E0F70
        public void .ctor(){} // RVA: 0x7FFD55068F70
        public void OnEnable(){} // RVA: 0x7FFD55069000
        public void Canvas_preWillRenderCanvases(){} // RVA: 0x7FFD4EB28F70
        public void OnDisable(){} // RVA: 0x7FFD55069100
        public void Handle(){} // RVA: 0x7FFD550691D0
        public void HandleWorldCanvas(){} // RVA: 0x7FFD550693E0
        public void HandleConstantPixelSize(){} // RVA: 0x7FFD55069450
        public void HandleScaleWithScreenSize(){} // RVA: 0x7FFD550694C0
        public void HandleConstantPhysicalSize(){} // RVA: 0x7FFD55069780
        public void SetScaleFactor(){} // RVA: 0x7FFD550698A0
        public void SetReferencePixelsPerUnit(){} // RVA: 0x7FFD550698E0
    }

    public class CanvasUpdateRegistry : Object
    {
        public ePathName117.tPathName30 instance;
        public bool m_PerformingLayoutUpdate; // 0x10
        public bool m_PerformingGraphicUpdate; // 0x11
        public string[] m_CanvasUpdateProfilerStrings; // 0x18
        public string m_CullingUpdateProfilerString;
        public llection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear.s.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear<ePathName117.PathName28> m_LayoutRebuildQueue; // 0x20
        public llection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear.s.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear<ePathName117.PathName28> m_GraphicRebuildQueue; // 0x28
        public ation<ePathName117.PathName28> s_SortLayoutFunction; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54E72840
        public void get_instance(){} // RVA: 0x7FFD54E72B10
        public void ObjectValidForUpdate(){} // RVA: 0x7FFD54E72C30
        public void CleanInvalidItems(){} // RVA: 0x7FFD54E72DA0
        public void PerformUpdate(){} // RVA: 0x7FFD54E72F70
        public void ParentCount(){} // RVA: 0x7FFD54E736E0
        public void SortLayoutList(){} // RVA: 0x7FFD54E738E0
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54E739A0
        public void TryRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54E73A10
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54E73A80
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54E73B40
        public void TryRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54E73BB0
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54E73C20
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7FFD54E73D30
        public void DisableCanvasElementForRebuild(){} // RVA: 0x7FFD54E74020
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54E74310
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54E74470
        public void InternalDisableCanvasElementForLayoutRebuild(){} // RVA: 0x7FFD54E745D0
        public void InternalDisableCanvasElementForGraphicRebuild(){} // RVA: 0x7FFD54E74730
        public void IsRebuildingLayout(){} // RVA: 0x7FFD54E74890
        public void IsRebuildingGraphics(){} // RVA: 0x7FFD54E748F0
        public void .cctor(){} // RVA: 0x7FFD54E74950
    }

    public class ClipperRegistry : Object
    {
        public ePathName117.Name75 instance;
        public llection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear.s.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear<ePathName117.nputPathName80> m_Clippers; // 0x10
        public bool HasCulledThisFrame; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54E75330
        public void get_instance(){} // RVA: 0x7FFD54E753F0
        public void Cull(){} // RVA: 0x7FFD54E75570
        public void Register(){} // RVA: 0x7FFD54E75750
        public void Unregister(){} // RVA: 0x7FFD54E757C0
        public void Disable(){} // RVA: 0x7FFD54E75820
    }

    public class Clipping : Object
    {
        // ── Methods ──
        public void FindCullAndClipWorldRect(){} // RVA: 0x7FFD54E75880
    }

    public class ColorBlock : ValueType
    {
        public object normalColor; // 0x10
        public object highlightedColor; // 0x20
        public object pressedColor; // 0x30
        public object selectedColor; // 0x40
        public object disabledColor; // 0x50
        public float colorMultiplier; // 0x60
        public float fadeDuration; // 0x64
        public ePathName117.e54 defaultColorBlock;

        // ── Methods ──
        public void get_normalColor(){} // RVA: 0x7FFD4E6E0590
        public void set_normalColor(){} // RVA: 0x7FFD4F92BA60
        public void get_highlightedColor(){} // RVA: 0x7FFD4F842E80
        public void set_highlightedColor(){} // RVA: 0x7FFD4F842E90
        public void get_pressedColor(){} // RVA: 0x7FFD4FE39630
        public void set_pressedColor(){} // RVA: 0x7FFD53790D10
        public void get_selectedColor(){} // RVA: 0x7FFD5387FF30
        public void set_selectedColor(){} // RVA: 0x7FFD5387FF40
        public void get_disabledColor(){} // RVA: 0x7FFD4FEE8580
        public void set_disabledColor(){} // RVA: 0x7FFD5213E430
        public void get_colorMultiplier(){} // RVA: 0x7FFD4E3A9460
        public void set_colorMultiplier(){} // RVA: 0x7FFD4E3A9470
        public void get_fadeDuration(){} // RVA: 0x7FFD4E7B1600
        public void set_fadeDuration(){} // RVA: 0x7FFD4E7B14E0
        public void .cctor(){} // RVA: 0x7FFD54E74A30
        public void Equals(){} // RVA: 0x7FFD54E74E40 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54E75140
        public void op_Inequality(){} // RVA: 0x7FFD54E751F0
        public void GetHashCode(){} // RVA: 0x7FFD54E752A0
    }

    public class ContentSizeFitter : UIBehaviour
    {
        public ÏÎÌÎÏÏÍÍÌÌ horizontalFit; // 0x20
        public ÏÎÌÎÏÏÍÍÌÌ verticalFit; // 0x24
        public 16 rectTransform; // 0x28
        public tton13 m_Tracker; // 0x30

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x7FFD4E4FBBE0
        public void set_horizontalFit(){} // RVA: 0x7FFD55069920
        public void get_verticalFit(){} // RVA: 0x7FFD4ED41980
        public void set_verticalFit(){} // RVA: 0x7FFD55069980
        public void get_rectTransform(){} // RVA: 0x7FFD550699E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void OnEnable(){} // RVA: 0x7FFD55069B20
        public void OnDisable(){} // RVA: 0x7FFD55069B30
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD55069B20
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x7FFD55069B90
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD55069C30
        public void SetLayoutVertical(){} // RVA: 0x7FFD55069CA0
        public void SetDirty(){} // RVA: 0x7FFD55069D10
    }

    public class DefaultControls : Object
    {
        public 94 factory;
        public float kWidth;
        public float kThickHeight;
        public float kThinHeight;
        public tionX s_ThickElementSize; // 0x8
        public tionX s_ThinElementSize; // 0x10
        public tionX s_ImageElementSize; // 0x18
        public object s_DefaultSelectableColor; // 0x20
        public object s_PanelColor; // 0x30
        public object s_TextColor; // 0x40

        // ── Methods ──
        public void get_factory(){} // RVA: 0x7FFD54E75FC0
        public void CreateUIElementRoot(){} // RVA: 0x7FFD54E76020
        public void CreateUIObject(){} // RVA: 0x7FFD54E76170
        public void SetDefaultTextValues(){} // RVA: 0x7FFD54E76260
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7FFD54E763F0
        public void SetParentAndAlign(){} // RVA: 0x7FFD54E76450
        public void SetLayerRecursively(){} // RVA: 0x7FFD54E76650
        public void CreatePanel(){} // RVA: 0x7FFD54E76860
        public void CreateButton(){} // RVA: 0x7FFD54E76D60
        public void CreateText(){} // RVA: 0x7FFD54E77490
        public void CreateImage(){} // RVA: 0x7FFD54E776A0
        public void CreateRawImage(){} // RVA: 0x7FFD54E77840
        public void CreateSlider(){} // RVA: 0x7FFD54E779E0
        public void CreateScrollbar(){} // RVA: 0x7FFD54E78860
        public void CreateToggle(){} // RVA: 0x7FFD54E79130
        public void CreateInputField(){} // RVA: 0x7FFD54E79CD0
        public void CreateDropdown(){} // RVA: 0x7FFD54E7A860
        public void CreateScrollView(){} // RVA: 0x7FFD54E7CBB0
        public void .cctor(){} // RVA: 0x7FFD54E7DDE0
    }

    public class Dropdown : Selectable
    {
        public 16 template; // 0x100
        public ePathName117.? captionText; // 0x108
        public ePathName117.ÎÌÍÍÎÏÌ captionImage; // 0x110
        public ePathName117.? itemText; // 0x118
        public ePathName117.ÎÌÍÍÎÏÌ itemImage; // 0x120
        public int options; // 0x128
        public teNormalizer onValueChanged; // 0x130
        public hortNormalizer alphaFadeSpeed; // 0x138
        public float value; // 0x140
        public BuffersImpl m_Dropdown; // 0x148
        public BuffersImpl m_Blocker; // 0x150
        public URA.woDigitYearMax<ChannelNormalized> m_Items; // 0x158
        public ollections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains.dth<ollections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains.yLeftLandmarkColor> m_AlphaTweenRunner; // 0x160
        public bool validTemplate; // 0x168
        public int kHighSortingLayer;
        public Src s_NoOptionData;

        // ── Methods ──
        public void get_template(){} // RVA: 0x7FFD4E916C80
        public void set_template(){} // RVA: 0x7FFD54E7E060
        public void get_captionText(){} // RVA: 0x7FFD4EAF1F40
        public void set_captionText(){} // RVA: 0x7FFD54E7E0C0
        public void get_captionImage(){} // RVA: 0x7FFD4E96B170
        public void set_captionImage(){} // RVA: 0x7FFD54E7E120
        public void get_itemText(){} // RVA: 0x7FFD4E7DC6D0
        public void set_itemText(){} // RVA: 0x7FFD54E7E180
        public void get_itemImage(){} // RVA: 0x7FFD4E55CBB0
        public void set_itemImage(){} // RVA: 0x7FFD54E7E1E0
        public void get_options(){} // RVA: 0x7FFD54E7E240
        public void set_options(){} // RVA: 0x7FFD54E7E260
        public void get_onValueChanged(){} // RVA: 0x7FFD4E9622C0
        public void set_onValueChanged(){} // RVA: 0x7FFD4EAF84B0
        public void get_alphaFadeSpeed(){} // RVA: 0x7FFD54E7E2E0
        public void set_alphaFadeSpeed(){} // RVA: 0x7FFD54E7E2F0
        public void get_value(){} // RVA: 0x7FFD53E319F0
        public void set_value(){} // RVA: 0x7FFD54E7E300
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD54E7E310
        public void Set(){} // RVA: 0x7FFD54E7E320
        public void .ctor(){} // RVA: 0x7FFD54E7E4A0
        public void Awake(){} // RVA: 0x7FFD54E7E6D0
        public void Start(){} // RVA: 0x7FFD54E7E9E0
        public void OnDisable(){} // RVA: 0x7FFD54E7EB10
        public void RefreshShownValue(){} // RVA: 0x7FFD54E7EC70
        public void AddOptions(){} // RVA: 0x7FFD54E7F2A0 | overloaded x3
        public void ClearOptions(){} // RVA: 0x7FFD54E7F470
        public void SetupTemplate(){} // RVA: 0x7FFD54E7F4F0
        public void GetOrAddComponent(){} // RVA: 0x7FFD4E2ADC40
        public void OnPointerClick(){} // RVA: 0x7FFD54E80320
        public void OnSubmit(){} // RVA: 0x7FFD54E80320
        public void OnCancel(){} // RVA: 0x7FFD54E80330
        public void Show(){} // RVA: 0x7FFD54E80340
        public void CreateBlocker(){} // RVA: 0x7FFD54E81BD0
        public void DestroyBlocker(){} // RVA: 0x7FFD54E82750
        public void CreateDropdownList(){} // RVA: 0x7FFD54E827A0
        public void DestroyDropdownList(){} // RVA: 0x7FFD54E82810
        public void CreateItem(){} // RVA: 0x7FFD54E82860
        public void DestroyItem(){} // RVA: 0x7FFD4E341310
        public void AddItem(){} // RVA: 0x7FFD54E828D0
        public void AlphaFadeList(){} // RVA: 0x7FFD54E83060 | overloaded x2
        public void SetAlpha(){} // RVA: 0x7FFD54E83220
        public void Hide(){} // RVA: 0x7FFD54E83340
        public void DelayedDestroyDropdownList(){} // RVA: 0x7FFD54E836D0
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7FFD54E83790
        public void OnSelectItem(){} // RVA: 0x7FFD54E83A80
        public void .cctor(){} // RVA: 0x7FFD54E83D10
    }

    public class FontData : Object
    {
        public IsWithinBudget defaultFontData; // 0x10
        public int font; // 0x18
        public r fontSize; // 0x1C
        public bool fontStyle; // 0x20
        public int bestFit; // 0x24
        public int minSize; // 0x28
        public RingAutoIndexSort maxSize; // 0x2C
        public bool alignment; // 0x30
        public bool alignByGeometry; // 0x31
        public 2 richText; // 0x34
        public F218011DDEDB224BCED54E9924CA80D32FD85A52A959E03 horizontalOverflow; // 0x38
        public float verticalOverflow; // 0x3C

        // ── Methods ──
        public void get_defaultFontData(){} // RVA: 0x7FFD54E841C0
        public void get_font(){} // RVA: 0x7FFD4E35C380
        public void set_font(){} // RVA: 0x7FFD4E342E30
        public void get_fontSize(){} // RVA: 0x7FFD4E577800
        public void set_fontSize(){} // RVA: 0x7FFD4ED4CD10
        public void get_fontStyle(){} // RVA: 0x7FFD4F8557F0
        public void set_fontStyle(){} // RVA: 0x7FFD4F8674D0
        public void get_bestFit(){} // RVA: 0x7FFD4E42F9D0
        public void set_bestFit(){} // RVA: 0x7FFD4E42F9E0
        public void get_minSize(){} // RVA: 0x7FFD4ED41980
        public void set_minSize(){} // RVA: 0x7FFD4F5874D0
        public void get_maxSize(){} // RVA: 0x7FFD4E70C4C0
        public void set_maxSize(){} // RVA: 0x7FFD4EABA6E0
        public void get_alignment(){} // RVA: 0x7FFD4F0A91D0
        public void set_alignment(){} // RVA: 0x7FFD4F9D6490
        public void get_alignByGeometry(){} // RVA: 0x7FFD4E367450
        public void set_alignByGeometry(){} // RVA: 0x7FFD4E367460
        public void get_richText(){} // RVA: 0x7FFD4E367470
        public void set_richText(){} // RVA: 0x7FFD4E367480
        public void get_horizontalOverflow(){} // RVA: 0x7FFD4EEFEDC0
        public void set_horizontalOverflow(){} // RVA: 0x7FFD4F58A6E0
        public void get_verticalOverflow(){} // RVA: 0x7FFD4E9AA870
        public void set_verticalOverflow(){} // RVA: 0x7FFD4E9A8350
        public void get_lineSpacing(){} // RVA: 0x7FFD4EA5CE20
        public void set_lineSpacing(){} // RVA: 0x7FFD4EA5C6C0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54E84230
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class FontUpdateTracker : Object
    {
        public URA.DateTime<IsWithinBudget,URA.onsDepth<ePathName117.?>> m_Tracked;

        // ── Methods ──
        public void TrackText(){} // RVA: 0x7FFD54E84280
        public void RebuildForFont(){} // RVA: 0x7FFD54E846C0
        public void UntrackText(){} // RVA: 0x7FFD54E84880
        public void .cctor(){} // RVA: 0x7FFD54E84C50
    }

    public class Graphic : UIBehaviour
    {
        public atrix_Injected defaultGraphicMaterial;
        public ector color; // 0x8
        public atrix_Injected raycastTarget; // 0x20
        public object raycastPadding; // 0x28
        public bool useLegacyMeshGeneration; // 0x38
        public bool depth; // 0x39
        public bool rectTransform; // 0x3A
        public bool canvas; // 0x3B
        public get_boundingBoxMode canvasRenderer; // 0x3C
        public 16 defaultMaterial; // 0x50
        public kingField material; // 0x58
        public pad materialForRendering; // 0x60
        public bool mainTexture; // 0x68
        public bool workerMesh; // 0x69
        public rScript.AllObsolete m_OnDirtyLayoutCallback; // 0x70
        public rScript.AllObsolete m_OnDirtyVertsCallback; // 0x78
        public rScript.AllObsolete m_OnDirtyMaterialCallback; // 0x80
        public object s_Mesh; // 0x10
        public ePathName117.eadOnly s_VertexHelper; // 0x18
        public object m_CachedMesh; // 0x88
        public tionX[] m_CachedUvs; // 0x90
        public ollections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains.dth<ollections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains.eWidth> m_ColorTweenRunner; // 0x98
        public bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_defaultGraphicMaterial(){} // RVA: 0x7FFD54E84D30
        public void get_color(){} // RVA: 0x7FFD4EFEF020
        public void set_color(){} // RVA: 0x7FFD54E84F10
        public void get_raycastTarget(){} // RVA: 0x7FFD4F39B7C0
        public void set_raycastTarget(){} // RVA: 0x7FFD54E84F80
        public void get_raycastPadding(){} // RVA: 0x7FFD53D66F00
        public void set_raycastPadding(){} // RVA: 0x7FFD53D66F10
        public void get_useLegacyMeshGeneration(){} // RVA: 0x7FFD4F9E9D50
        public void set_useLegacyMeshGeneration(){} // RVA: 0x7FFD4EBD1910
        public void .ctor(){} // RVA: 0x7FFD54E85090
        public void SetAllDirty(){} // RVA: 0x7FFD54E85220
        public void SetLayoutDirty(){} // RVA: 0x7FFD54E85290
        public void SetVerticesDirty(){} // RVA: 0x7FFD54E85330
        public void SetMaterialDirty(){} // RVA: 0x7FFD54E853C0
        public void SetRaycastDirty(){} // RVA: 0x7FFD54E85460
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD54E85580
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFD54E856F0
        public void OnTransformParentChanged(){} // RVA: 0x7FFD54E857A0
        public void get_depth(){} // RVA: 0x7FFD54E858A0
        public void get_rectTransform(){} // RVA: 0x7FFD54E85910
        public void get_canvas(){} // RVA: 0x7FFD54E859B0
        public void CacheCanvas(){} // RVA: 0x7FFD54E85A90
        public void get_canvasRenderer(){} // RVA: 0x7FFD54E85D10
        public void get_defaultMaterial(){} // RVA: 0x7FFD54E85EA0
        public void get_material(){} // RVA: 0x7FFD54E85EF0
        public void set_material(){} // RVA: 0x7FFD54E85FE0
        public void get_materialForRendering(){} // RVA: 0x7FFD54E86160
        public void get_mainTexture(){} // RVA: 0x7FFD54E86370
        public void OnEnable(){} // RVA: 0x7FFD54E863D0
        public void OnDisable(){} // RVA: 0x7FFD54E86600
        public void OnDestroy(){} // RVA: 0x7FFD54E867E0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD54E869A0
        public void OnCullingChanged(){} // RVA: 0x7FFD54E86BF0
        public void Rebuild(){} // RVA: 0x7FFD54E86CB0
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void UpdateMaterial(){} // RVA: 0x7FFD54E86E40
        public void UpdateGeometry(){} // RVA: 0x7FFD54E86FD0
        public void DoMeshGeneration(){} // RVA: 0x7FFD54E86FF0
        public void DoLegacyMeshGeneration(){} // RVA: 0x7FFD54E875E0
        public void get_workerMesh(){} // RVA: 0x7FFD54E87BC0
        public void OnFillVBO(){} // RVA: 0x7FFD4E341310
        public void OnPopulateMesh(){} // RVA: 0x7FFD54E87E70 | overloaded x2
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD546A40F0
        public void SetNativeSize(){} // RVA: 0x7FFD4E341310
        public void Raycast(){} // RVA: 0x7FFD54E88080
        public void PixelAdjustPoint(){} // RVA: 0x7FFD54E885B0
        public void GetPixelAdjustedRect(){} // RVA: 0x7FFD54E88880
        public void CrossFadeColor(){} // RVA: 0x7FFD54E88BE0 | overloaded x2
        public void CreateColorFromAlpha(){} // RVA: 0x7FFD54E890B0
        public void CrossFadeAlpha(){} // RVA: 0x7FFD54E890D0
        public void RegisterDirtyLayoutCallback(){} // RVA: 0x7FFD54E891A0
        public void UnregisterDirtyLayoutCallback(){} // RVA: 0x7FFD54E89290
        public void RegisterDirtyVerticesCallback(){} // RVA: 0x7FFD54E89380
        public void UnregisterDirtyVerticesCallback(){} // RVA: 0x7FFD54E89470
        public void RegisterDirtyMaterialCallback(){} // RVA: 0x7FFD54E89560
        public void UnregisterDirtyMaterialCallback(){} // RVA: 0x7FFD54E89660
        public void .cctor(){} // RVA: 0x7FFD54E89760
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class GraphicRaycaster : BaseRaycaster
    {
        public int sortOrderPriority;
        public bool renderOrderPriority; // 0x28
        public eName75 ignoreReversedGraphics; // 0x2C
        public object blockingObjects; // 0x30
        public pad blockingMask; // 0x38
        public URA.woDigitYearMax<ePathName117.hInputPathName124> canvas; // 0x40
        public URA.woDigitYearMax<ePathName117.hInputPathName124> eventCamera;

        // ── Methods ──
        public void get_sortOrderPriority(){} // RVA: 0x7FFD54E89900
        public void get_renderOrderPriority(){} // RVA: 0x7FFD54E899E0
        public void get_ignoreReversedGraphics(){} // RVA: 0x7FFD4E516BA0
        public void set_ignoreReversedGraphics(){} // RVA: 0x7FFD4F044F40
        public void get_blockingObjects(){} // RVA: 0x7FFD4F0A91D0
        public void set_blockingObjects(){} // RVA: 0x7FFD4F9D6490
        public void get_blockingMask(){} // RVA: 0x7FFD4E39CCD0
        public void set_blockingMask(){} // RVA: 0x7FFD4E39CCE0
        public void .ctor(){} // RVA: 0x7FFD54E89B10
        public void get_canvas(){} // RVA: 0x7FFD54E89C10
        public void Raycast(){} // RVA: 0x7FFD54E8B390 | overloaded x2
        public void get_eventCamera(){} // RVA: 0x7FFD54E8B1B0
        public void .cctor(){} // RVA: 0x7FFD54E8BAD0
    }

    public class GraphicRegistry : Object
    {
        public ePathName117.me78 instance;
        public URA.DateTime<pad,llection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear.s.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear<ePathName117.hInputPathName124>> m_Graphics; // 0x10
        public URA.DateTime<pad,llection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear.s.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear<ePathName117.hInputPathName124>> m_RaycastableGraphics; // 0x18
        public URA.woDigitYearMax<ePathName117.hInputPathName124> s_EmptyList; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54E8BD50
        public void get_instance(){} // RVA: 0x7FFD54E8BF70
        public void RegisterGraphicForCanvas(){} // RVA: 0x7FFD54E8C090
        public void RegisterRaycastGraphicForCanvas(){} // RVA: 0x7FFD54E8C430
        public void UnregisterGraphicForCanvas(){} // RVA: 0x7FFD54E8C7E0
        public void UnregisterRaycastGraphicForCanvas(){} // RVA: 0x7FFD54E8CA90
        public void DisableGraphicForCanvas(){} // RVA: 0x7FFD54E8CD10
        public void DisableRaycastGraphicForCanvas(){} // RVA: 0x7FFD54E8CF30
        public void GetGraphicsForCanvas(){} // RVA: 0x7FFD54E8D150
        public void GetRaycastableGraphicsForCanvas(){} // RVA: 0x7FFD54E8D220
        public void .cctor(){} // RVA: 0x7FFD54E8D2F0
    }

    public class GridLayoutGroup : LayoutGroup
    {
        public ncReprojection_Bool startCorner; // 0x60
        public nitAttributeType startAxis; // 0x64
        public tionX cellSize; // 0x68
        public tionX spacing; // 0x70
        public ingField constraint; // 0x78
        public int constraintCount; // 0x7C

        // ── Methods ──
        public void get_startCorner(){} // RVA: 0x7FFD4E558C20
        public void set_startCorner(){} // RVA: 0x7FFD55069D90
        public void get_startAxis(){} // RVA: 0x7FFD4E558CA0
        public void set_startAxis(){} // RVA: 0x7FFD55069DE0
        public void get_cellSize(){} // RVA: 0x7FFD55069E30
        public void set_cellSize(){} // RVA: 0x7FFD55069E50
        public void get_spacing(){} // RVA: 0x7FFD55069EA0
        public void set_spacing(){} // RVA: 0x7FFD55069EC0
        public void get_constraint(){} // RVA: 0x7FFD4F9B6EF0
        public void set_constraint(){} // RVA: 0x7FFD55069F10
        public void get_constraintCount(){} // RVA: 0x7FFD4F9B8F70
        public void set_constraintCount(){} // RVA: 0x7FFD55069F60
        public void .ctor(){} // RVA: 0x7FFD5506A050
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD5506A0C0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD5506A2D0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD5506A500
        public void SetLayoutVertical(){} // RVA: 0x7FFD5506A510
        public void SetCellsAlongAxis(){} // RVA: 0x7FFD5506A520
    }

    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5506ACE0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD5506ACF0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD5506AD20
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD5506AD30
        public void SetLayoutVertical(){} // RVA: 0x7FFD5506AD40
    }

    public class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        public float spacing; // 0x60
        public bool childForceExpandWidth; // 0x64
        public bool childForceExpandHeight; // 0x65
        public bool childControlWidth; // 0x66
        public bool childControlHeight; // 0x67
        public bool childScaleWidth; // 0x68
        public bool childScaleHeight; // 0x69
        public bool reverseArrangement; // 0x6A

        // ── Methods ──
        public void get_spacing(){} // RVA: 0x7FFD4E451E10
        public void set_spacing(){} // RVA: 0x7FFD5506AD50
        public void get_childForceExpandWidth(){} // RVA: 0x7FFD4F365FE0
        public void set_childForceExpandWidth(){} // RVA: 0x7FFD5506AE00
        public void get_childForceExpandHeight(){} // RVA: 0x7FFD542C0370
        public void set_childForceExpandHeight(){} // RVA: 0x7FFD5506AE50
        public void get_childControlWidth(){} // RVA: 0x7FFD542C02D0
        public void set_childControlWidth(){} // RVA: 0x7FFD5506AEA0
        public void get_childControlHeight(){} // RVA: 0x7FFD542C02C0
        public void set_childControlHeight(){} // RVA: 0x7FFD5506AEF0
        public void get_childScaleWidth(){} // RVA: 0x7FFD4E409570
        public void set_childScaleWidth(){} // RVA: 0x7FFD5506AF40
        public void get_childScaleHeight(){} // RVA: 0x7FFD4FA90BD0
        public void set_childScaleHeight(){} // RVA: 0x7FFD5506AF90
        public void get_reverseArrangement(){} // RVA: 0x7FFD536B0C80
        public void set_reverseArrangement(){} // RVA: 0x7FFD5506AFE0
        public void CalcAlongAxis(){} // RVA: 0x7FFD5506B030
        public void SetChildrenAlongAxis(){} // RVA: 0x7FFD5506B4E0
        public void GetChildSizes(){} // RVA: 0x7FFD5506C090
        public void .ctor(){} // RVA: 0x7FFD5506ACE0
    }

    public class ICanvasElement
    {
        public object transform;

        // ── Methods ──
        public void Rebuild(){} // RVA: 0x7FFD4E090ED0
        public void get_transform(){} // RVA: 0x7FFD4E078E90
        public void LayoutComplete(){} // RVA: 0x7FFD4E090980
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E090980
        public void IsDestroyed(){} // RVA: 0x7FFD4E079D00
    }

    public class IClippable
    {
        public object gameObject;
        public object rectTransform;

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFD4E078E90
        public void RecalculateClipping(){} // RVA: 0x7FFD4E090980
        public void get_rectTransform(){} // RVA: 0x7FFD4E078E90
        public void Cull(){}
        public void SetClipRect(){}
        public void SetClipSoftness(){} // RVA: 0x7FFD4E09F3E0
    }

    public class IClipper
    {
        // ── Methods ──
        public void PerformClipping(){} // RVA: 0x7FFD4E090980
    }

    public class IGraphicEnabledDisabled
    {
        // ── Methods ──
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7FFD4E090980
    }

    public class ILayoutController
    {
        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD4E090980
        public void SetLayoutVertical(){} // RVA: 0x7FFD4E090980
    }

    public class ILayoutElement
    {
        public object minWidth;
        public object preferredWidth;
        public object flexibleWidth;
        public object minHeight;
        public object preferredHeight;
        public object flexibleHeight;
        public object layoutPriority;

        // ── Methods ──
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E090980
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E090980
        public void get_minWidth(){} // RVA: 0x7FFD4E08D880
        public void get_preferredWidth(){} // RVA: 0x7FFD4E08D880
        public void get_flexibleWidth(){} // RVA: 0x7FFD4E08D880
        public void get_minHeight(){} // RVA: 0x7FFD4E08D880
        public void get_preferredHeight(){} // RVA: 0x7FFD4E08D880
        public void get_flexibleHeight(){} // RVA: 0x7FFD4E08D880
        public void get_layoutPriority(){} // RVA: 0x7FFD4E079960
    }

    public class ILayoutGroup
    {
    }

    public class ILayoutIgnorer
    {
        public object ignoreLayout;

        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7FFD4E079D00
    }

    public class ILayoutSelfController
    {
    }

    public class IMask
    {
        public object rectTransform;

        // ── Methods ──
        public void Enabled(){} // RVA: 0x7FFD4E079D00
        public void get_rectTransform(){} // RVA: 0x7FFD4E078E90
    }

    public class IMaskable
    {
        // ── Methods ──
        public void RecalculateMasking(){} // RVA: 0x7FFD4E090980
    }

    public class IMaterialModifier
    {
        // ── Methods ──
        public void GetModifiedMaterial(){} // RVA: 0x7FFD4E078F40
    }

    public class IMeshModifier
    {
        // ── Methods ──
        public void ModifyMesh(){} // RVA: 0x7FFD4E090A40 | overloaded x2
    }

    public class Image : MaskableGraphic
    {
        public atrix_Injected sprite;
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField overrideSprite; // 0xE0
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField activeSprite; // 0xE8
        public object type; // 0xF0
        public bool preserveAspect; // 0xF4
        public bool fillCenter; // 0xF5
        public lotName86 fillMethod; // 0xF8
        public float fillAmount; // 0xFC
        public bool fillClockwise; // 0x100
        public int fillOrigin; // 0x104
        public float eventAlphaThreshold; // 0x108
        public bool alphaHitTestMinimumThreshold; // 0x10C
        public bool useSpriteMesh; // 0x10D
        public float defaultETC1GraphicMaterial; // 0x110
        public float mainTexture; // 0x114
        public tionX[] hasBorder; // 0x8
        public tionX[] pixelsPerUnitMultiplier; // 0x10
        public amut[] pixelsPerUnit; // 0x18
        public amut[] multipliedPixelsPerUnit; // 0x20
        public URA.woDigitYearMax<ePathName117.ÎÌÍÍÎÏÌ> material; // 0x28
        public bool minWidth; // 0x30

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFD4E3C2900
        public void set_sprite(){} // RVA: 0x7FFD54E8D3D0
        public void DisableSpriteOptimizations(){} // RVA: 0x7FFD54E8DB70
        public void get_overrideSprite(){} // RVA: 0x7FFD54E8DB80
        public void set_overrideSprite(){} // RVA: 0x7FFD54E8DB90
        public void get_activeSprite(){} // RVA: 0x7FFD54E8DC10
        public void get_type(){} // RVA: 0x7FFD514A55D0
        public void set_type(){} // RVA: 0x7FFD54E8DD00
        public void get_preserveAspect(){} // RVA: 0x7FFD4F27B1F0
        public void set_preserveAspect(){} // RVA: 0x7FFD54E8DD70
        public void get_fillCenter(){} // RVA: 0x7FFD4F27DCB0
        public void set_fillCenter(){} // RVA: 0x7FFD54E8DDE0
        public void get_fillMethod(){} // RVA: 0x7FFD4F289BA0
        public void set_fillMethod(){} // RVA: 0x7FFD54E8DE50
        public void get_fillAmount(){} // RVA: 0x7FFD4E5110F0
        public void set_fillAmount(){} // RVA: 0x7FFD54E8DED0
        public void get_fillClockwise(){} // RVA: 0x7FFD4F0AB9C0
        public void set_fillClockwise(){} // RVA: 0x7FFD54E8DF60
        public void get_fillOrigin(){} // RVA: 0x7FFD4FBD0110
        public void set_fillOrigin(){} // RVA: 0x7FFD54E8DFD0
        public void get_eventAlphaThreshold(){} // RVA: 0x7FFD54E8E040
        public void set_eventAlphaThreshold(){} // RVA: 0x7FFD54E8E060
        public void get_alphaHitTestMinimumThreshold(){} // RVA: 0x7FFD4FD861C0
        public void set_alphaHitTestMinimumThreshold(){} // RVA: 0x7FFD54E8E080
        public void get_useSpriteMesh(){} // RVA: 0x7FFD51B35A00
        public void set_useSpriteMesh(){} // RVA: 0x7FFD54E8E350
        public void .ctor(){} // RVA: 0x7FFD54E8E3C0
        public void get_defaultETC1GraphicMaterial(){} // RVA: 0x7FFD54E8E420
        public void get_mainTexture(){} // RVA: 0x7FFD54E8E600
        public void get_hasBorder(){} // RVA: 0x7FFD54E8E910
        public void get_pixelsPerUnitMultiplier(){} // RVA: 0x7FFD54E8EAA0
        public void set_pixelsPerUnitMultiplier(){} // RVA: 0x7FFD54E8EAB0
        public void get_pixelsPerUnit(){} // RVA: 0x7FFD54E8EAE0
        public void get_multipliedPixelsPerUnit(){} // RVA: 0x7FFD54E8ED30
        public void get_material(){} // RVA: 0x7FFD54E8ED50
        public void set_material(){} // RVA: 0x7FFD54E8F010
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void OnAfterDeserialize(){} // RVA: 0x7FFD54E8F020
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFD4EB16210
        public void GetDrawingDimensions(){} // RVA: 0x7FFD54E8F090
        public void SetNativeSize(){} // RVA: 0x7FFD54E8F5C0
        public void OnPopulateMesh(){} // RVA: 0x7FFD54E8F8B0
        public void TrackSprite(){} // RVA: 0x7FFD54E8FA70
        public void OnEnable(){} // RVA: 0x7FFD54E8FDD0
        public void OnDisable(){} // RVA: 0x7FFD54E8FE30
        public void UpdateMaterial(){} // RVA: 0x7FFD54E8FF10
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD54E902E0
        public void GenerateSimpleSprite(){} // RVA: 0x7FFD54E904F0
        public void GenerateSprite(){} // RVA: 0x7FFD54E90970
        public void GenerateSlicedSprite(){} // RVA: 0x7FFD54E910D0
        public void GenerateTiledSprite(){} // RVA: 0x7FFD54E91BD0
        public void AddQuad(){} // RVA: 0x7FFD4EB15FB0 | overloaded x2
        public void GetAdjustedBorders(){} // RVA: 0x7FFD4EB159B0
        public void GenerateFilledSprite(){} // RVA: 0x7FFD54E93390
        public void RadialCut(){} // RVA: 0x7FFD54E947F0 | overloaded x2
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredWidth(){} // RVA: 0x7FFD54E94CB0
        public void get_flexibleWidth(){} // RVA: 0x7FFD5496F350
        public void get_minHeight(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredHeight(){} // RVA: 0x7FFD54E94E70
        public void get_flexibleHeight(){} // RVA: 0x7FFD5496F350
        public void get_layoutPriority(){} // RVA: 0x7FFD4E919180
        public void IsRaycastLocationValid(){} // RVA: 0x7FFD54E95030
        public void MapCoordinate(){} // RVA: 0x7FFD54E954D0
        public void RebuildImage(){} // RVA: 0x7FFD54E95BE0
        public void TrackImage(){} // RVA: 0x7FFD54E95E50
        public void UnTrackImage(){} // RVA: 0x7FFD54E95FC0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD54E96050
        public void .cctor(){} // RVA: 0x7FFD54E960A0
        public void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0(){} // RVA: 0x7FFD54E96430
        public void <set_sprite>g__SpriteSupportsAlphaHitTest|11_1(){} // RVA: 0x7FFD54E964C0
    }

    public class InputField : Selectable
    {
        public Hash128ToStringImpl input; // 0x100
        public char[] compositionString;
        public bool mesh; // 0x8
        public bool cachedInputTextGenerator; // 0x9
        public ePathName117.? shouldHideMobileInput; // 0x108
        public ePathName117.hInputPathName124 shouldActivateOnSelect; // 0x110
        public 2_FE_LONGS text; // 0x118
        public ÍÏÎÍÏÏÌÏÏÍÏÌÌÎÌÎÌ isFocused; // 0x11C
        public char caretBlinkRate; // 0x120
        public Underscore caretWidth; // 0x124
        public object textComponent; // 0x128
        public bool placeholder; // 0x12C
        public aterial caretColor; // 0x130
        public int customCaretColor; // 0x134
        public et_isAutoFitting selectionColor; // 0x138
        public et_isAutoFitting onEndEdit; // 0x140
        public utSourceType19 onSubmit; // 0x148
        public ting onValueChange; // 0x150
        public idth onValueChanged; // 0x158
        public object onValidateInput; // 0x160
        public bool characterLimit; // 0x170
        public object contentType; // 0x174
        public string lineType; // 0x188
        public float inputType; // 0x190
        public int touchScreenKeyboard; // 0x194
        public bool keyboardType; // 0x198
        public bool characterValidation; // 0x199
        public int readOnly; // 0x19C
        public int multiLine; // 0x1A0
        public 16 asteriskChar; // 0x1A8
        public cTotalCost[] wasCanceled; // 0x1B0
        public in2 caretPositionInternal; // 0x1B8
        public kingField caretSelectPositionInternal; // 0x1C0
        public bool hasSelection; // 0x1C8
        public object caretPosition; // 0x1D0
        public bool selectionAnchorPosition; // 0x1D8
        public bool selectionFocusPosition; // 0x1D9
        public bool clipboard; // 0x1DA
        public bool minWidth; // 0x1DB
        public float preferredWidth;
        public float flexibleWidth;
        public bool minHeight; // 0x1DC
        public ts preferredHeight; // 0x1E0
        public float flexibleHeight; // 0x1E8
        public int layoutPriority; // 0x1EC
        public int m_DrawEnd; // 0x1F0
        public ts m_DragCoroutine; // 0x1F8
        public string m_OriginalText; // 0x200
        public bool m_WasCanceled; // 0x208
        public bool m_HasDoneFocusTransition; // 0x209
        public object m_WaitForSecondsRealtime; // 0x210
        public bool m_TouchKeyboardAllowsInPlaceEditing; // 0x218
        public bool m_IsCompositionActive; // 0x219
        public string kEmailSpecialCharacters;
        public string kOculusQuestDeviceModel;
        public string kPicoDeviceModel;
        public 5EC78E8E02279FB1266932E3468A575B0EB9818985DBE9468B991CCE m_ProcessingEvent; // 0x220
        public int k_MaxTextLength;

        // ── Methods ──
        public void get_input(){} // RVA: 0x7FFD55059180
        public void get_compositionString(){} // RVA: 0x7FFD55059370
        public void .ctor(){} // RVA: 0x7FFD550594C0
        public void get_mesh(){} // RVA: 0x7FFD55059990
        public void get_cachedInputTextGenerator(){} // RVA: 0x7FFD55059B00
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFD55059BC0
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFD55059C10
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFD54064910
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFD55059CB0
        public void get_text(){} // RVA: 0x7FFD4E9610C0
        public void set_text(){} // RVA: 0x7FFD55059D50
        public void SetTextWithoutNotify(){} // RVA: 0x7FFD55059D60
        public void SetText(){} // RVA: 0x7FFD55059D70
        public void get_isFocused(){} // RVA: 0x7FFD4FBE42D0
        public void get_caretBlinkRate(){} // RVA: 0x7FFD5505A260
        public void set_caretBlinkRate(){} // RVA: 0x7FFD5505A270
        public void get_caretWidth(){} // RVA: 0x7FFD54A65C70
        public void set_caretWidth(){} // RVA: 0x7FFD5505A2E0
        public void get_textComponent(){} // RVA: 0x7FFD4EAF1F40
        public void set_textComponent(){} // RVA: 0x7FFD5505A340
        public void get_placeholder(){} // RVA: 0x7FFD4E96B170
        public void set_placeholder(){} // RVA: 0x7FFD5505A6D0
        public void get_caretColor(){} // RVA: 0x7FFD5505A730
        public void set_caretColor(){} // RVA: 0x7FFD5505A790
        public void get_customCaretColor(){} // RVA: 0x7FFD4EE059C0
        public void set_customCaretColor(){} // RVA: 0x7FFD5505A800
        public void get_selectionColor(){} // RVA: 0x7FFD5505A820
        public void set_selectionColor(){} // RVA: 0x7FFD5505A830
        public void get_onEndEdit(){} // RVA: 0x7FFD4E3AC660
        public void set_onEndEdit(){} // RVA: 0x7FFD5505A8A0
        public void get_onSubmit(){} // RVA: 0x7FFD4E9622C0
        public void set_onSubmit(){} // RVA: 0x7FFD5505A900
        public void get_onValueChange(){} // RVA: 0x7FFD4E96DFA0
        public void set_onValueChange(){} // RVA: 0x7FFD5505A960
        public void get_onValueChanged(){} // RVA: 0x7FFD4E96DFA0
        public void set_onValueChanged(){} // RVA: 0x7FFD5505A960
        public void get_onValidateInput(){} // RVA: 0x7FFD4E962410
        public void set_onValidateInput(){} // RVA: 0x7FFD5505A9C0
        public void get_characterLimit(){} // RVA: 0x7FFD54714E20
        public void set_characterLimit(){} // RVA: 0x7FFD5505AA20
        public void get_contentType(){} // RVA: 0x7FFD4FD861E0
        public void set_contentType(){} // RVA: 0x7FFD5505AAD0
        public void get_lineType(){} // RVA: 0x7FFD53E319F0
        public void set_lineType(){} // RVA: 0x7FFD5505AC80
        public void get_inputType(){} // RVA: 0x7FFD54F1AC70
        public void set_inputType(){} // RVA: 0x7FFD5505AD70
        public void get_touchScreenKeyboard(){} // RVA: 0x7FFD4E916C80
        public void get_keyboardType(){} // RVA: 0x7FFD53CF4E90
        public void set_keyboardType(){} // RVA: 0x7FFD5505ADE0
        public void get_characterValidation(){} // RVA: 0x7FFD4E7DC1B0
        public void set_characterValidation(){} // RVA: 0x7FFD5505AE50
        public void get_readOnly(){} // RVA: 0x7FFD53F5EBF0
        public void set_readOnly(){} // RVA: 0x7FFD53F5EC00
        public void get_multiLine(){} // RVA: 0x7FFD5505AEC0
        public void get_asteriskChar(){} // RVA: 0x7FFD5505AEE0
        public void set_asteriskChar(){} // RVA: 0x7FFD5505AEF0
        public void get_wasCanceled(){} // RVA: 0x7FFD54064960
        public void ClampPos(){} // RVA: 0x7FFD5505AFA0
        public void get_caretPositionInternal(){} // RVA: 0x7FFD5505AFE0
        public void set_caretPositionInternal(){} // RVA: 0x7FFD5505B010
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFD5505B060
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFD5505B090
        public void get_hasSelection(){} // RVA: 0x7FFD5505B0E0
        public void get_caretPosition(){} // RVA: 0x7FFD5505B060
        public void set_caretPosition(){} // RVA: 0x7FFD5505B140
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFD5505AFE0
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFD5505B170
        public void get_selectionFocusPosition(){} // RVA: 0x7FFD5505B060
        public void set_selectionFocusPosition(){} // RVA: 0x7FFD5505B1E0
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void OnAfterDeserialize(){} // RVA: 0x7FFD5505B250
        public void OnEnable(){} // RVA: 0x7FFD5505B3B0
        public void OnDisable(){} // RVA: 0x7FFD5505B7A0
        public void OnDestroy(){} // RVA: 0x7FFD5505BC40
        public void CaretBlink(){} // RVA: 0x7FFD5505BC90
        public void SetCaretVisible(){} // RVA: 0x7FFD5505BD30
        public void SetCaretActive(){} // RVA: 0x7FFD5505BDB0
        public void UpdateCaretMaterial(){} // RVA: 0x7FFD5505BEA0
        public void OnFocus(){} // RVA: 0x7FFD5505C0D0
        public void SelectAll(){} // RVA: 0x7FFD5505C0E0
        public void MoveTextEnd(){} // RVA: 0x7FFD5505C170
        public void MoveTextStart(){} // RVA: 0x7FFD5505C290
        public void get_clipboard(){} // RVA: 0x7FFD5505C380
        public void set_clipboard(){} // RVA: 0x7FFD5505C400
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7FFD5505C490
        public void InPlaceEditing(){} // RVA: 0x7FFD5505C5B0
        public void InPlaceEditingChanged(){} // RVA: 0x7FFD5505C5E0
        public void GetInternalSelection(){} // RVA: 0x7FFD5505C690
        public void UpdateKeyboardCaret(){} // RVA: 0x7FFD5505C780
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7FFD5505C890
        public void LateUpdate(){} // RVA: 0x7FFD5505CA40
        public void ScreenToLocal(){} // RVA: 0x7FFD5505D280
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7FFD5505DA50
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7FFD5505DD50
        public void MayDrag(){} // RVA: 0x7FFD5505E060
        public void OnBeginDrag(){} // RVA: 0x7FFD5505E1C0
        public void OnDrag(){} // RVA: 0x7FFD5505E1F0
        public void MouseDragOutsideRect(){} // RVA: 0x7FFD5505E5A0
        public void OnEndDrag(){} // RVA: 0x7FFD5505E6A0
        public void OnPointerDown(){} // RVA: 0x7FFD5505E6D0
        public void KeyPressed(){} // RVA: 0x7FFD5505E9C0
        public void IsValidChar(){} // RVA: 0x7FFD5505EFD0
        public void ProcessEvent(){} // RVA: 0x7FFD5505F030
        public void OnUpdateSelected(){} // RVA: 0x7FFD5505F040
        public void GetSelectedString(){} // RVA: 0x7FFD5505F2D0
        public void FindtNextWordBegin(){} // RVA: 0x7FFD5505F3D0
        public void MoveRight(){} // RVA: 0x7FFD5505F4E0
        public void FindtPrevWordBegin(){} // RVA: 0x7FFD5505F780
        public void MoveLeft(){} // RVA: 0x7FFD5505F880
        public void DetermineCharacterLine(){} // RVA: 0x7FFD5505FB10
        public void LineUpCharacterPosition(){} // RVA: 0x7FFD5505FCB0
        public void LineDownCharacterPosition(){} // RVA: 0x7FFD5505FF50
        public void MoveDown(){} // RVA: 0x7FFD55060280 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFD550604B0 | overloaded x2
        public void Delete(){} // RVA: 0x7FFD55060690
        public void ForwardSpace(){} // RVA: 0x7FFD55060950
        public void Backspace(){} // RVA: 0x7FFD55060A60
        public void Insert(){} // RVA: 0x7FFD55060BE0
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFD55060E10
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFD55060E70
        public void SendOnValueChanged(){} // RVA: 0x7FFD55060E90
        public void SendOnEndEdit(){} // RVA: 0x7FFD55060F50
        public void SendOnSubmit(){} // RVA: 0x7FFD55061010
        public void Append(){} // RVA: 0x7FFD550611B0 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x7FFD55061540
        public void IsSelectionVisible(){} // RVA: 0x7FFD55061D00
        public void GetLineStartPosition(){} // RVA: 0x7FFD55061DD0
        public void GetLineEndPosition(){} // RVA: 0x7FFD55061F00
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7FFD55062080
        public void ForceLabelUpdate(){} // RVA: 0x7FFD55062AA0
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFD55062AB0
        public void Rebuild(){} // RVA: 0x7FFD55062B50
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void UpdateGeometry(){} // RVA: 0x7FFD55062B60
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFD550631D0
        public void OnFillVBO(){} // RVA: 0x7FFD55063CC0
        public void GenerateCaret(){} // RVA: 0x7FFD55063ED0
        public void CreateCursorVerts(){} // RVA: 0x7FFD55064CA0
        public void GenerateHighlight(){} // RVA: 0x7FFD55064EB0
        public void Validate(){} // RVA: 0x7FFD55065750
        public void ActivateInputField(){} // RVA: 0x7FFD55065E30
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFD55066060
        public void OnSelect(){} // RVA: 0x7FFD550668A0
        public void OnPointerClick(){} // RVA: 0x7FFD550668F0
        public void DeactivateInputField(){} // RVA: 0x7FFD55066920
        public void OnDeselect(){} // RVA: 0x7FFD55066CC0
        public void OnSubmit(){} // RVA: 0x7FFD55066CF0
        public void EnforceContentType(){} // RVA: 0x7FFD55066D40
        public void EnforceTextHOverflow(){} // RVA: 0x7FFD55066EB0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFD55067010
        public void SetToCustom(){} // RVA: 0x7FFD55067080
        public void DoStateTransition(){} // RVA: 0x7FFD550670A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD550670D0
        public void get_preferredWidth(){} // RVA: 0x7FFD550670E0
        public void get_flexibleWidth(){} // RVA: 0x7FFD5496F350
        public void get_minHeight(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredHeight(){} // RVA: 0x7FFD55067340
        public void get_flexibleHeight(){} // RVA: 0x7FFD5496F350
        public void get_layoutPriority(){} // RVA: 0x7FFD4E433AF0
        public void .cctor(){} // RVA: 0x7FFD550675E0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class LayoutElement : UIBehaviour
    {
        public bool ignoreLayout; // 0x20
        public float minWidth; // 0x24
        public float minHeight; // 0x28
        public float preferredWidth; // 0x2C
        public float preferredHeight; // 0x30
        public float flexibleWidth; // 0x34
        public float flexibleHeight; // 0x38
        public int layoutPriority; // 0x3C

        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7FFD4E42F9D0
        public void set_ignoreLayout(){} // RVA: 0x7FFD5506C1D0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD4E4AEF50
        public void set_minWidth(){} // RVA: 0x7FFD5506C230
        public void get_minHeight(){} // RVA: 0x7FFD4E420210
        public void set_minHeight(){} // RVA: 0x7FFD5506C290
        public void get_preferredWidth(){} // RVA: 0x7FFD4E80AB80
        public void set_preferredWidth(){} // RVA: 0x7FFD5506C2F0
        public void get_preferredHeight(){} // RVA: 0x7FFD4F060670
        public void set_preferredHeight(){} // RVA: 0x7FFD5506C350
        public void get_flexibleWidth(){} // RVA: 0x7FFD4E40B630
        public void set_flexibleWidth(){} // RVA: 0x7FFD5506C3B0
        public void get_flexibleHeight(){} // RVA: 0x7FFD4EB36E90
        public void set_flexibleHeight(){} // RVA: 0x7FFD5506C410
        public void get_layoutPriority(){} // RVA: 0x7FFD4E7DD4A0
        public void set_layoutPriority(){} // RVA: 0x7FFD5506C470
        public void .ctor(){} // RVA: 0x7FFD5506C4D0
        public void OnEnable(){} // RVA: 0x7FFD5506C550
        public void OnTransformParentChanged(){} // RVA: 0x7FFD5506C550
        public void OnDisable(){} // RVA: 0x7FFD5506C550
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD5506C550
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFD5506C550
        public void SetDirty(){} // RVA: 0x7FFD5506C560
    }

    public class LayoutGroup : UIBehaviour
    {
        public Field padding; // 0x20
        public RingAutoIndexSort childAlignment; // 0x28
        public 16 rectTransform; // 0x30
        public tton13 rectChildren; // 0x38
        public tionX minWidth; // 0x3C
        public tionX preferredWidth; // 0x44
        public tionX flexibleWidth; // 0x4C
        public URA.woDigitYearMax<16> minHeight; // 0x58

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFD4E36F0C0
        public void set_padding(){} // RVA: 0x7FFD5506C640
        public void get_childAlignment(){} // RVA: 0x7FFD4E70C4C0
        public void set_childAlignment(){} // RVA: 0x7FFD5506C710
        public void get_rectTransform(){} // RVA: 0x7FFD5506C760
        public void get_rectChildren(){} // RVA: 0x7FFD4E409500
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD5506C8A0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E090980
        public void get_minWidth(){} // RVA: 0x7FFD54B3C740
        public void get_preferredWidth(){} // RVA: 0x7FFD54DA7640
        public void get_flexibleWidth(){} // RVA: 0x7FFD54E1A220
        public void get_minHeight(){} // RVA: 0x7FFD54D5FB30
        public void get_preferredHeight(){} // RVA: 0x7FFD54E1A210
        public void get_flexibleHeight(){} // RVA: 0x7FFD54E1A230
        public void get_layoutPriority(){} // RVA: 0x7FFD4E919180
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD4E090980
        public void SetLayoutVertical(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD5506CCE0
        public void OnEnable(){} // RVA: 0x7FFD5506D010
        public void OnDisable(){} // RVA: 0x7FFD5506D020
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD5506D010
        public void GetTotalMinSize(){} // RVA: 0x7FFD5506D080
        public void GetTotalPreferredSize(){} // RVA: 0x7FFD5506D090
        public void GetTotalFlexibleSize(){} // RVA: 0x7FFD5506D0A0
        public void GetStartOffset(){} // RVA: 0x7FFD5506D0B0
        public void GetAlignmentOnAxis(){} // RVA: 0x7FFD5506D360
        public void SetLayoutInputForAxis(){} // RVA: 0x7FFD5506D3B0
        public void SetChildAlongAxis(){} // RVA: 0x7FFD5506D850 | overloaded x2
        public void SetChildAlongAxisWithScale(){} // RVA: 0x7FFD5506D970 | overloaded x2
        public void get_isRootLayoutGroup(){} // RVA: 0x7FFD5506DD70
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD5506E070
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD5506D010
        public void SetProperty(){} // RVA: 0x7FFD4E2ADC40
        public void SetDirty(){} // RVA: 0x7FFD5506E0A0
        public void DelayedSetDirty(){} // RVA: 0x7FFD5506E240
    }

    public class LayoutRebuilder : Object
    {
        public 16 transform; // 0x10
        public int m_CachedHashFromTransform; // 0x18
        public cy.gContentId<ePathName117.ling_Bool> s_Rebuilders;
        public string TAG_CACHED;
        public URA.DateTime<16,URA.woDigitYearMax<led>> _cachedControllerComponents; // 0x8
        public URA.DateTime<16,URA.woDigitYearMax<led>> _cachedElementComponents; // 0x10

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD5506E3F0
        public void Clear(){} // RVA: 0x7FFD5506E470
        public void .cctor(){} // RVA: 0x7FFD5506E4D0
        public void ReapplyDrivenProperties(){} // RVA: 0x7FFD5506EA00
        public void get_transform(){} // RVA: 0x7FFD4E35C380
        public void IsDestroyed(){} // RVA: 0x7FFD5506EA50
        public void StripDisabledBehavioursFromList(){} // RVA: 0x7FFD5506EB20
        public void ForceRebuildLayoutImmediate(){} // RVA: 0x7FFD5506EC90
        public void Rebuild(){} // RVA: 0x7FFD5506EDE0
        public void VRC_RegisterCachedLayoutTree(){} // RVA: 0x7FFD5506F260
        public void VRC_UnregisterCachedLayoutTree(){} // RVA: 0x7FFD5506F650
        public void PerformLayoutControl(){} // RVA: 0x7FFD5506F770
        public void PerformLayoutCalculation(){} // RVA: 0x7FFD5506FF30
        public void MarkLayoutForRebuild(){} // RVA: 0x7FFD55070530
        public void ValidController(){} // RVA: 0x7FFD55070CB0
        public void MarkLayoutRootForRebuild(){} // RVA: 0x7FFD55071060
        public void LayoutComplete(){} // RVA: 0x7FFD550712E0
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E577800
        public void Equals(){} // RVA: 0x7FFD55071370
        public void ToString(){} // RVA: 0x7FFD550713D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class LayoutUtility : Object
    {
        // ── Methods ──
        public void GetMinSize(){} // RVA: 0x7FFD55071830
        public void GetPreferredSize(){} // RVA: 0x7FFD55071850
        public void GetFlexibleSize(){} // RVA: 0x7FFD55071870
        public void GetMinWidth(){} // RVA: 0x7FFD55071890
        public void GetPreferredWidth(){} // RVA: 0x7FFD550719F0
        public void GetFlexibleWidth(){} // RVA: 0x7FFD55071CA0
        public void GetMinHeight(){} // RVA: 0x7FFD55071E00
        public void GetPreferredHeight(){} // RVA: 0x7FFD55071F60
        public void GetFlexibleHeight(){} // RVA: 0x7FFD55072210
        public void GetLayoutProperty(){} // RVA: 0x7FFD55072390 | overloaded x2
    }

    public class Mask : UIBehaviour
    {
        public 16 rectTransform; // 0x20
        public bool showMaskGraphic; // 0x28
        public ePathName117.hInputPathName124 graphic; // 0x30
        public atrix_Injected m_MaskMaterial; // 0x38
        public atrix_Injected m_UnmaskMaterial; // 0x40

        // ── Methods ──
        public void get_rectTransform(){} // RVA: 0x7FFD55072AF0
        public void get_showMaskGraphic(){} // RVA: 0x7FFD4E516BA0
        public void set_showMaskGraphic(){} // RVA: 0x7FFD55072B90
        public void get_graphic(){} // RVA: 0x7FFD55072CA0
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
        public void MaskEnabled(){} // RVA: 0x7FFD55072D40
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD55072E40
        public void OnDisable(){} // RVA: 0x7FFD55073080
        public void IsRaycastLocationValid(){} // RVA: 0x7FFD55073440
        public void GetModifiedMaterial(){} // RVA: 0x7FFD55073520
    }

    public class MaskUtilities : Object
    {
        // ── Methods ──
        public void Notify2DMaskStateChanged(){} // RVA: 0x7FFD55074F10
        public void NotifyStencilStateChanged(){} // RVA: 0x7FFD55075290
        public void FindRootSortOverrideCanvas(){} // RVA: 0x7FFD55075610
        public void GetStencilDepth(){} // RVA: 0x7FFD550758B0
        public void IsDescendantOrSelf(){} // RVA: 0x7FFD55075D80
        public void GetRectMaskForClippable(){} // RVA: 0x7FFD55076170
        public void GetRectMasksForClip(){} // RVA: 0x7FFD550765E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MaskableGraphic : Graphic
    {
        public bool onCullStateChanged; // 0xA8
        public atrix_Injected maskable; // 0xB0
        public ePathName117.alPriorityMax isMaskingGraphic; // 0xB8
        public bool rootCanvasRect; // 0xC0
        public bool m_IsMaskingGraphic; // 0xC1
        public bool m_IncludeForMasking; // 0xC2
        public h_VRWebHelper_DebuggerPort_Int32 m_OnCullStateChanged; // 0xC8
        public bool m_ShouldRecalculate; // 0xD0
        public int m_StencilValue; // 0xD4
        public amut[] m_Corners; // 0xD8

        // ── Methods ──
        public void get_onCullStateChanged(){} // RVA: 0x7FFD4E499460
        public void set_onCullStateChanged(){} // RVA: 0x7FFD4E499470
        public void get_maskable(){} // RVA: 0x7FFD4E3624C0
        public void set_maskable(){} // RVA: 0x7FFD550738F0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFD5448B7A0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFD55073920
        public void GetModifiedMaterial(){} // RVA: 0x7FFD55073930
        public void Cull(){} // RVA: 0x7FFD55073B40
        public void UpdateCull(){} // RVA: 0x7FFD55073BA0
        public void SetClipRect(){} // RVA: 0x7FFD55073D40
        public void SetClipSoftness(){} // RVA: 0x7FFD55073E30
        public void OnEnable(){} // RVA: 0x7FFD55073EB0
        public void OnDisable(){} // RVA: 0x7FFD55073F10
        public void OnTransformParentChanged(){} // RVA: 0x7FFD55074010
        public void ParentMaskStateChanged(){} // RVA: 0x7FFD4E341310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD55074180
        public void get_rootCanvasRect(){} // RVA: 0x7FFD55074210
        public void UpdateClipParent(){} // RVA: 0x7FFD55074770
        public void RecalculateClipping(){} // RVA: 0x7FFD54B4B150
        public void RecalculateMasking(){} // RVA: 0x7FFD55074AC0
        public void .ctor(){} // RVA: 0x7FFD55074BA0
        public void UnityEngine.UI.IClippable.get_gameObject(){} // RVA: 0x7FFD4E7DD180
    }

    public class Misc : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFD550769D0
        public void DestroyImmediate(){} // RVA: 0x7FFD55076BA0
    }

    public class MultipleDisplayUtilities : Object
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x7FFD55076CB0
        public void GetRelativeMousePositionForRaycast(){} // RVA: 0x7FFD55076D90
        public void RelativeMouseAtScaled(){} // RVA: 0x7FFD55076EC0
    }

    public class Navigation : ValueType
    {
        public object mode; // 0x10
        public bool wrapAround; // 0x14
        public ePathName117.? selectOnUp; // 0x18
        public ePathName117.? selectOnDown; // 0x20
        public ePathName117.? selectOnLeft; // 0x28
        public ePathName117.? selectOnRight; // 0x30

        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFD4F840210
        public void set_mode(){} // RVA: 0x7FFD4E78D8B0
        public void get_wrapAround(){} // RVA: 0x7FFD4FE2B160
        public void set_wrapAround(){} // RVA: 0x7FFD4EFBB960
        public void get_selectOnUp(){} // RVA: 0x7FFD4F840220
        public void set_selectOnUp(){} // RVA: 0x7FFD4F840240
        public void get_selectOnDown(){} // RVA: 0x7FFD4E35C380
        public void set_selectOnDown(){} // RVA: 0x7FFD4E342E30
        public void get_selectOnLeft(){} // RVA: 0x7FFD4E3447C0
        public void set_selectOnLeft(){} // RVA: 0x7FFD4E3A7E80
        public void get_selectOnRight(){} // RVA: 0x7FFD4E36F0C0
        public void set_selectOnRight(){} // RVA: 0x7FFD4E36F0D0
        public void get_defaultNavigation(){} // RVA: 0x7FFD550777F0
        public void Equals(){} // RVA: 0x7FFD55077810
    }

    public class Outline : Shadow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550954A0
        public void ModifyMesh(){} // RVA: 0x7FFD55095510
    }

    public class PositionAsUV1 : BaseMeshEffect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void ModifyMesh(){} // RVA: 0x7FFD55095840
    }

    public class RawImage : MaskableGraphic
    {
        public ÎÎÏÏÍÎÎÍÏÍÌ>k__BackingField mainTexture; // 0xE0
        public dRecorder texture; // 0xE8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55077BF0
        public void get_mainTexture(){} // RVA: 0x7FFD55077C20
        public void get_texture(){} // RVA: 0x7FFD4E3C2900
        public void set_texture(){} // RVA: 0x7FFD55077EE0
        public void get_uvRect(){} // RVA: 0x7FFD53E53EE0
        public void set_uvRect(){} // RVA: 0x7FFD55078090
        public void SetNativeSize(){} // RVA: 0x7FFD55078100
        public void OnPopulateMesh(){} // RVA: 0x7FFD55078350
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD54E96050
    }

    public class RectMask2D : UIBehaviour
    {
        public ePathName117.PathName83 padding; // 0x20
        public 16 softness; // 0x28
        public URA.onsDepth<ePathName117.pch_Dashboard_Position> Canvas; // 0x30
        public URA.onsDepth<ePathName117.ame80> canvasRect; // 0x38
        public bool rectTransform; // 0x40
        public URA.woDigitYearMax<ePathName117.alPriorityMax> rootCanvasRect; // 0x48
        public dRecorder m_LastClipRectCanvasSpace; // 0x50
        public bool m_ForceClip; // 0x60
        public get_boundingBoxMode m_Padding; // 0x64
        public onY m_Softness; // 0x74
        public pad m_Canvas; // 0x80
        public amut[] m_Corners; // 0x88

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFD4E451E00
        public void set_padding(){} // RVA: 0x7FFD550787E0
        public void get_softness(){} // RVA: 0x7FFD53F79CC0
        public void set_softness(){} // RVA: 0x7FFD550787F0
        public void get_Canvas(){} // RVA: 0x7FFD55078820
        public void get_canvasRect(){} // RVA: 0x7FFD55078B20
        public void get_rectTransform(){} // RVA: 0x7FFD55078BA0
        public void .ctor(){} // RVA: 0x7FFD55078C40
        public void OnEnable(){} // RVA: 0x7FFD55079040
        public void OnDisable(){} // RVA: 0x7FFD550790B0
        public void OnDestroy(){} // RVA: 0x7FFD54E757C0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFD55079240
        public void get_rootCanvasRect(){} // RVA: 0x7FFD55079350
        public void PerformClipping(){} // RVA: 0x7FFD550795E0
        public void UpdateClipSoftness(){} // RVA: 0x7FFD5507A170
        public void AddClippable(){} // RVA: 0x7FFD5507A530
        public void RemoveClippable(){} // RVA: 0x7FFD5507A6E0
        public void OnTransformParentChanged(){} // RVA: 0x7FFD5507A890
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD5507A890
    }

    public class RectangularVertexClipper : Object
    {
        public amut[] m_WorldCorners; // 0x10
        public amut[] m_CanvasCorners; // 0x18

        // ── Methods ──
        public void GetCanvasRect(){} // RVA: 0x7FFD54E75C10
        public void .ctor(){} // RVA: 0x7FFD54E75EB0
    }

    public class ReflectionMethodsCache : Object
    {
        public ctions.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.CopyTo Singleton; // 0x10
        public llection<Valve.Newtonsoft.Json.Linq.JToken>.CopyTo raycast3DAll; // 0x18
        public onsoft.Json.Linq.JToken>.CopyTo getRaycastNonAlloc; // 0x20
        public pyTo raycast2D; // 0x28
        public tions.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.get_IsReadOnly getRayIntersectionAll; // 0x30
        public e.Newtonsoft.Json.Linq.JToken>.get_IsReadOnly getRayIntersectionAllNonAlloc; // 0x38
        public ePathName117.llections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Clear s_ReflectionMethodsCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55090070
        public void get_Singleton(){} // RVA: 0x7FFD550919E0
    }

    public class ScrollRect : UIBehaviour
    {
        public 16 content; // 0x20
        public bool horizontal; // 0x28
        public bool vertical; // 0x29
        public nitializationType movementType; // 0x2C
        public float elasticity; // 0x30
        public bool inertia; // 0x34
        public float decelerationRate; // 0x38
        public float scrollSensitivity; // 0x3C
        public 16 viewport; // 0x40
        public ePathName117.readmill horizontalScrollbar; // 0x48
        public ePathName117.readmill verticalScrollbar; // 0x50
        public Type horizontalScrollbarVisibility; // 0x58
        public Type verticalScrollbarVisibility; // 0x5C
        public float horizontalScrollbarSpacing; // 0x60
        public float verticalScrollbarSpacing; // 0x64
        public rrorView onValueChanged; // 0x68
        public tionX viewRect; // 0x70
        public tionX velocity; // 0x78
        public 16 rectTransform; // 0x80
        public stments normalizedPosition; // 0x88
        public stments horizontalNormalizedPosition; // 0xA0
        public tionX verticalNormalizedPosition; // 0xB8
        public bool hScrollingNeeded; // 0xC0
        public bool vScrollingNeeded; // 0xC1
        public tionX minWidth; // 0xC4
        public stments preferredWidth; // 0xCC
        public stments flexibleWidth; // 0xE4
        public bool minHeight; // 0xFC
        public bool preferredHeight; // 0xFD
        public bool flexibleHeight; // 0xFE
        public float layoutPriority; // 0x100
        public float m_VSliderWidth; // 0x104
        public 16 m_Rect; // 0x108
        public 16 m_HorizontalScrollbarRect; // 0x110
        public 16 m_VerticalScrollbarRect; // 0x118
        public tton13 m_Tracker; // 0x120
        public amut[] m_Corners; // 0x128

        // ── Methods ──
        public void get_content(){} // RVA: 0x7FFD4E36F0C0
        public void set_content(){} // RVA: 0x7FFD4E36F0D0
        public void get_horizontal(){} // RVA: 0x7FFD4E516BA0
        public void set_horizontal(){} // RVA: 0x7FFD4F044F40
        public void get_vertical(){} // RVA: 0x7FFD4EC8C550
        public void set_vertical(){} // RVA: 0x7FFD4F7D4D70
        public void get_movementType(){} // RVA: 0x7FFD4F0A91D0
        public void set_movementType(){} // RVA: 0x7FFD4F9D6490
        public void get_elasticity(){} // RVA: 0x7FFD4F060670
        public void set_elasticity(){} // RVA: 0x7FFD4FB594E0
        public void get_inertia(){} // RVA: 0x7FFD4E377C20
        public void set_inertia(){} // RVA: 0x7FFD4E37BAC0
        public void get_decelerationRate(){} // RVA: 0x7FFD4EB36E90
        public void set_decelerationRate(){} // RVA: 0x7FFD4EB37190
        public void get_scrollSensitivity(){} // RVA: 0x7FFD4EA5CE20
        public void set_scrollSensitivity(){} // RVA: 0x7FFD4EA5C6C0
        public void get_viewport(){} // RVA: 0x7FFD4E3BE740
        public void set_viewport(){} // RVA: 0x7FFD5507D010
        public void get_horizontalScrollbar(){} // RVA: 0x7FFD4E3BC730
        public void set_horizontalScrollbar(){} // RVA: 0x7FFD5507D070
        public void get_verticalScrollbar(){} // RVA: 0x7FFD4E3E20E0
        public void set_verticalScrollbar(){} // RVA: 0x7FFD5507D360
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x7FFD4EA4EA40
        public void set_horizontalScrollbarVisibility(){} // RVA: 0x7FFD5507D650
        public void get_verticalScrollbarVisibility(){} // RVA: 0x7FFD4E55CBA0
        public void set_verticalScrollbarVisibility(){} // RVA: 0x7FFD5507D660
        public void get_horizontalScrollbarSpacing(){} // RVA: 0x7FFD4E451E10
        public void set_horizontalScrollbarSpacing(){} // RVA: 0x7FFD5507D670
        public void get_verticalScrollbarSpacing(){} // RVA: 0x7FFD4E36A040
        public void set_verticalScrollbarSpacing(){} // RVA: 0x7FFD5507D680
        public void get_onValueChanged(){} // RVA: 0x7FFD4E3BCD50
        public void set_onValueChanged(){} // RVA: 0x7FFD4E3BCD60
        public void get_viewRect(){} // RVA: 0x7FFD5507D690
        public void get_velocity(){} // RVA: 0x7FFD5507D970
        public void set_velocity(){} // RVA: 0x7FFD4F9E9F90
        public void get_rectTransform(){} // RVA: 0x7FFD5507D990
        public void .ctor(){} // RVA: 0x7FFD5507DAE0
        public void Rebuild(){} // RVA: 0x7FFD5507DD30
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void UpdateCachedData(){} // RVA: 0x7FFD5507DDC0
        public void OnEnable(){} // RVA: 0x7FFD5507E990
        public void OnDisable(){} // RVA: 0x7FFD5507EC80
        public void IsActive(){} // RVA: 0x7FFD5507F000
        public void EnsureLayoutHasRebuilt(){} // RVA: 0x7FFD5507F120
        public void StopMovement(){} // RVA: 0x7FFD5507F1D0
        public void OnScroll(){} // RVA: 0x7FFD5507F230
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFD5507F440
        public void OnBeginDrag(){} // RVA: 0x7FFD5507F4B0
        public void OnEndDrag(){} // RVA: 0x7FFD5507F610
        public void OnDrag(){} // RVA: 0x7FFD5507F640
        public void SetContentAnchoredPosition(){} // RVA: 0x7FFD5507F8A0
        public void LateUpdate(){} // RVA: 0x7FFD5507FA50
        public void UpdatePrevData(){} // RVA: 0x7FFD550805D0
        public void UpdateScrollbars(){} // RVA: 0x7FFD55080760
        public void get_normalizedPosition(){} // RVA: 0x7FFD55080A40
        public void set_normalizedPosition(){} // RVA: 0x7FFD55080A80
        public void get_horizontalNormalizedPosition(){} // RVA: 0x7FFD55080AE0
        public void set_horizontalNormalizedPosition(){} // RVA: 0x7FFD55080BF0
        public void get_verticalNormalizedPosition(){} // RVA: 0x7FFD55080C10
        public void set_verticalNormalizedPosition(){} // RVA: 0x7FFD55080D30
        public void SetHorizontalNormalizedPosition(){} // RVA: 0x7FFD55080BF0
        public void SetVerticalNormalizedPosition(){} // RVA: 0x7FFD55080D30
        public void SetNormalizedPosition(){} // RVA: 0x7FFD55080D50
        public void RubberDelta(){} // RVA: 0x7FFD550812D0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD55081330
        public void get_hScrollingNeeded(){} // RVA: 0x7FFD55081340
        public void get_vScrollingNeeded(){} // RVA: 0x7FFD55081400
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD5496F350
        public void get_preferredWidth(){} // RVA: 0x7FFD5496F350
        public void get_flexibleWidth(){} // RVA: 0x7FFD5496F350
        public void get_minHeight(){} // RVA: 0x7FFD5496F350
        public void get_preferredHeight(){} // RVA: 0x7FFD5496F350
        public void get_flexibleHeight(){} // RVA: 0x7FFD5496F350
        public void get_layoutPriority(){} // RVA: 0x7FFD4E6DD0E0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD550814C0
        public void SetLayoutVertical(){} // RVA: 0x7FFD55081E50
        public void UpdateScrollbarVisibility(){} // RVA: 0x7FFD55082020
        public void UpdateOneScrollbarVisibility(){} // RVA: 0x7FFD55082080
        public void UpdateScrollbarLayout(){} // RVA: 0x7FFD550822E0
        public void UpdateBounds(){} // RVA: 0x7FFD55082760
        public void AdjustBounds(){} // RVA: 0x7FFD55082E90
        public void GetBounds(){} // RVA: 0x7FFD55082F40
        public void InternalGetBounds(){} // RVA: 0x7FFD55083140
        public void CalculateOffset(){} // RVA: 0x7FFD550833E0
        public void InternalCalculateOffset(){} // RVA: 0x7FFD55083430
        public void SetDirty(){} // RVA: 0x7FFD550835F0
        public void SetDirtyCaching(){} // RVA: 0x7FFD55083670
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class Scrollbar : Selectable
    {
        public 16 handleRect; // 0x100
        public teVerticalSliderPageSize direction; // 0x108
        public float value; // 0x10C
        public float size; // 0x110
        public int numberOfSteps; // 0x114
        public Right onValueChanged; // 0x118
        public 16 stepSize; // 0x120
        public tionX axis; // 0x128
        public tton13 reverseValue; // 0x130
        public ts m_PointerDownRepeat; // 0x138
        public bool isPointerDownAndNotDragging; // 0x140
        public bool m_DelayedUpdateVisuals; // 0x141

        // ── Methods ──
        public void get_handleRect(){} // RVA: 0x7FFD4E916C80
        public void set_handleRect(){} // RVA: 0x7FFD5507A900
        public void get_direction(){} // RVA: 0x7FFD4F9B9E70
        public void set_direction(){} // RVA: 0x7FFD5507A970
        public void .ctor(){} // RVA: 0x7FFD5507A9D0
        public void get_value(){} // RVA: 0x7FFD5507AB00
        public void set_value(){} // RVA: 0x7FFD5507AB60
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD5507AB70
        public void get_size(){} // RVA: 0x7FFD54E8EAA0
        public void set_size(){} // RVA: 0x7FFD5507AB80
        public void get_numberOfSteps(){} // RVA: 0x7FFD54B65510
        public void set_numberOfSteps(){} // RVA: 0x7FFD5507AC00
        public void get_onValueChanged(){} // RVA: 0x7FFD4E7DC6D0
        public void set_onValueChanged(){} // RVA: 0x7FFD4E7D8580
        public void get_stepSize(){} // RVA: 0x7FFD5507AC70
        public void Rebuild(){} // RVA: 0x7FFD4E341310
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD5507ACA0
        public void OnDisable(){} // RVA: 0x7FFD5507ACE0
        public void Update(){} // RVA: 0x7FFD5507ACF0
        public void UpdateCachedReferences(){} // RVA: 0x7FFD5507AD10
        public void Set(){} // RVA: 0x7FFD5507B030
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD5507B170
        public void get_axis(){} // RVA: 0x7FFD5507B1B0
        public void get_reverseValue(){} // RVA: 0x7FFD5507B1D0
        public void UpdateVisuals(){} // RVA: 0x7FFD5507B1F0
        public void UpdateDrag(){} // RVA: 0x7FFD5507B530
        public void DoUpdateDrag(){} // RVA: 0x7FFD5507B9E0
        public void MayDrag(){} // RVA: 0x7FFD5507BAA0
        public void OnBeginDrag(){} // RVA: 0x7FFD5507BB10
        public void OnDrag(){} // RVA: 0x7FFD5507BE50
        public void OnPointerDown(){} // RVA: 0x7FFD5507BF90
        public void ClickRepeat(){} // RVA: 0x7FFD5507C140 | overloaded x2
        public void OnPointerUp(){} // RVA: 0x7FFD5507C270
        public void OnMove(){} // RVA: 0x7FFD5507C2B0
        public void FindSelectableOnLeft(){} // RVA: 0x7FFD5507C960
        public void FindSelectableOnRight(){} // RVA: 0x7FFD5507C990
        public void FindSelectableOnUp(){} // RVA: 0x7FFD5507C9C0
        public void FindSelectableOnDown(){} // RVA: 0x7FFD5507C9F0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFD4EB3D9D0
        public void SetDirection(){} // RVA: 0x7FFD5507CA20
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class Selectable : UIBehaviour
    {
        public ePathName117.?[] allSelectablesArray;
        public int allSelectableCount; // 0x8
        public bool allSelectables; // 0x20
        public ePathName117.ÌÎÌ navigation; // 0x28
        public hildOrder transition; // 0x50
        public ePathName117.e54 colors; // 0x54
        public ePathName117.e>b__37_1 spriteState; // 0xB0
        public ePathName117.DevicePathName119 animationTriggers; // 0xD0
        public bool targetGraphic; // 0xD8
        public ePathName117.hInputPathName124 interactable; // 0xE0
        public bool isPointerInside; // 0xE8
        public int isPointerDown; // 0xEC
        public bool hasSelection; // 0xF0
        public bool image; // 0xF1
        public bool animator; // 0xF2
        public URA.woDigitYearMax<panId> currentSelectionState; // 0xF8

        // ── Methods ──
        public void get_allSelectablesArray(){} // RVA: 0x7FFD55083810
        public void get_allSelectableCount(){} // RVA: 0x7FFD550839C0
        public void get_allSelectables(){} // RVA: 0x7FFD55083A20
        public void AllSelectablesNoAlloc(){} // RVA: 0x7FFD55083AC0
        public void get_navigation(){} // RVA: 0x7FFD55083C50
        public void set_navigation(){} // RVA: 0x7FFD55083C70
        public void get_transition(){} // RVA: 0x7FFD4E5110E0
        public void set_transition(){} // RVA: 0x7FFD55083DC0
        public void get_colors(){} // RVA: 0x7FFD55083E20
        public void set_colors(){} // RVA: 0x7FFD55083E60
        public void get_spriteState(){} // RVA: 0x7FFD55083FE0
        public void set_spriteState(){} // RVA: 0x7FFD55084000
        public void get_animationTriggers(){} // RVA: 0x7FFD4E45E100
        public void set_animationTriggers(){} // RVA: 0x7FFD55084130
        public void get_targetGraphic(){} // RVA: 0x7FFD4E3C2900
        public void set_targetGraphic(){} // RVA: 0x7FFD55084190
        public void get_interactable(){} // RVA: 0x7FFD4F1DD9E0
        public void set_interactable(){} // RVA: 0x7FFD550841F0
        public void get_isPointerInside(){} // RVA: 0x7FFD4E3C2AD0
        public void set_isPointerInside(){} // RVA: 0x7FFD4E3C2AE0
        public void get_isPointerDown(){} // RVA: 0x7FFD4F286790
        public void set_isPointerDown(){} // RVA: 0x7FFD4F282B70
        public void get_hasSelection(){} // RVA: 0x7FFD4F2834D0
        public void set_hasSelection(){} // RVA: 0x7FFD4F282830
        public void .ctor(){} // RVA: 0x7FFD55084480
        public void get_image(){} // RVA: 0x7FFD55084710
        public void set_image(){} // RVA: 0x7FFD4E3C2910
        public void get_animator(){} // RVA: 0x7FFD550847A0
        public void Awake(){} // RVA: 0x7FFD550847E0
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFD55084920
        public void ParentGroupAllowsInteraction(){} // RVA: 0x7FFD55084960
        public void IsInteractable(){} // RVA: 0x7FFD55084BA0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD55084BC0
        public void OnEnable(){} // RVA: 0x7FFD55084BD0
        public void OnTransformParentChanged(){} // RVA: 0x7FFD53F0C8C0
        public void OnSetProperty(){} // RVA: 0x7FFD55085100
        public void OnDisable(){} // RVA: 0x7FFD55085180
        public void OnApplicationFocus(){} // RVA: 0x7FFD55085300
        public void get_currentSelectionState(){} // RVA: 0x7FFD55085370
        public void InstantClearState(){} // RVA: 0x7FFD550853E0
        public void DoStateTransition(){} // RVA: 0x7FFD55085470
        public void FindSelectable(){} // RVA: 0x7FFD55085790
        public void GetPointOnRectEdge(){} // RVA: 0x7FFD55086150
        public void Navigate(){} // RVA: 0x7FFD55086460
        public void FindSelectableOnLeft(){} // RVA: 0x7FFD550865B0
        public void FindSelectableOnRight(){} // RVA: 0x7FFD55086720
        public void FindSelectableOnUp(){} // RVA: 0x7FFD55086890
        public void FindSelectableOnDown(){} // RVA: 0x7FFD55086A00
        public void OnMove(){} // RVA: 0x7FFD55086B70
        public void StartColorTween(){} // RVA: 0x7FFD55086C20
        public void DoSpriteSwap(){} // RVA: 0x7FFD55086D90
        public void TriggerAnimation(){} // RVA: 0x7FFD55086EA0
        public void IsHighlighted(){} // RVA: 0x7FFD550871B0
        public void IsPressed(){} // RVA: 0x7FFD55087220
        public void EvaluateAndTransitionToSelectionState(){} // RVA: 0x7FFD55087270
        public void OnPointerDown(){} // RVA: 0x7FFD550872E0
        public void OnPointerUp(){} // RVA: 0x7FFD55087480
        public void OnPointerEnter(){} // RVA: 0x7FFD550874B0
        public void OnPointerExit(){} // RVA: 0x7FFD550874C0
        public void OnSelect(){} // RVA: 0x7FFD550874D0
        public void OnDeselect(){} // RVA: 0x7FFD550874E0
        public void Select(){} // RVA: 0x7FFD550874F0
        public void .cctor(){} // RVA: 0x7FFD55087690
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFD54BA7770
        public void SetStruct(){} // RVA: 0x7FFD4E2ADC40
        public void SetClass(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Shadow : BaseMeshEffect
    {
        public object effectColor; // 0x28
        public tionX effectDistance; // 0x38
        public bool useGraphicAlpha; // 0x40
        public float kMaxEffectDistance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550954A0
        public void get_effectColor(){} // RVA: 0x7FFD4EFEF020
        public void set_effectColor(){} // RVA: 0x7FFD55095990
        public void get_effectDistance(){} // RVA: 0x7FFD4F3C0C70
        public void set_effectDistance(){} // RVA: 0x7FFD55095AA0
        public void get_useGraphicAlpha(){} // RVA: 0x7FFD4E3FCC00
        public void set_useGraphicAlpha(){} // RVA: 0x7FFD55095C60
        public void ApplyShadowZeroAlloc(){} // RVA: 0x7FFD55095D70
        public void ApplyShadow(){} // RVA: 0x7FFD55096180
        public void ModifyMesh(){} // RVA: 0x7FFD55096190
    }

    public class Slider : Selectable
    {
        public 16 fillRect; // 0x100
        public 16 handleRect; // 0x108
        public teVerticalSliderPageSize direction; // 0x110
        public float minValue; // 0x114
        public float maxValue; // 0x118
        public bool wholeNumbers; // 0x11C
        public float value; // 0x120
        public MemberForType>b__37_1 normalizedValue; // 0x128
        public ePathName117.ÎÌÍÍÎÏÌ onValueChanged; // 0x130
        public object stepSize; // 0x138
        public 16 axis; // 0x140
        public object reverseValue; // 0x148
        public 16 m_HandleContainerRect; // 0x150
        public tionX m_Offset; // 0x158
        public tton13 m_Tracker; // 0x160
        public bool m_DelayedUpdateVisuals; // 0x161

        // ── Methods ──
        public void get_fillRect(){} // RVA: 0x7FFD4E916C80
        public void set_fillRect(){} // RVA: 0x7FFD55087760
        public void get_handleRect(){} // RVA: 0x7FFD4EAF1F40
        public void set_handleRect(){} // RVA: 0x7FFD550877D0
        public void get_direction(){} // RVA: 0x7FFD4ED671E0
        public void set_direction(){} // RVA: 0x7FFD55087840
        public void get_minValue(){} // RVA: 0x7FFD54B39E50
        public void set_minValue(){} // RVA: 0x7FFD550878A0
        public void get_maxValue(){} // RVA: 0x7FFD54026760
        public void set_maxValue(){} // RVA: 0x7FFD55087920
        public void get_wholeNumbers(){} // RVA: 0x7FFD550879A0
        public void set_wholeNumbers(){} // RVA: 0x7FFD550879B0
        public void get_value(){} // RVA: 0x7FFD55087A30
        public void set_value(){} // RVA: 0x7FFD55087A50
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD55087A70
        public void get_normalizedValue(){} // RVA: 0x7FFD55087A90
        public void set_normalizedValue(){} // RVA: 0x7FFD55087B40
        public void get_onValueChanged(){} // RVA: 0x7FFD4E9666F0
        public void set_onValueChanged(){} // RVA: 0x7FFD4EDE51C0
        public void get_stepSize(){} // RVA: 0x7FFD55087B90
        public void .ctor(){} // RVA: 0x7FFD55087BC0
        public void Rebuild(){} // RVA: 0x7FFD4E341310
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD55087CF0
        public void OnDisable(){} // RVA: 0x7FFD5507ACE0
        public void Update(){} // RVA: 0x7FFD55087D40
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD55087D90
        public void UpdateCachedReferences(){} // RVA: 0x7FFD550881B0
        public void ClampValue(){} // RVA: 0x7FFD55088C00
        public void Set(){} // RVA: 0x7FFD55088C30
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD55088D20
        public void get_axis(){} // RVA: 0x7FFD55088D60
        public void get_reverseValue(){} // RVA: 0x7FFD55088D80
        public void UpdateVisuals(){} // RVA: 0x7FFD55088DA0
        public void UpdateDrag(){} // RVA: 0x7FFD550893C0
        public void MayDrag(){} // RVA: 0x7FFD5507BAA0
        public void OnPointerDown(){} // RVA: 0x7FFD55089720
        public void OnDrag(){} // RVA: 0x7FFD55089A00
        public void OnMove(){} // RVA: 0x7FFD55089A80
        public void FindSelectableOnLeft(){} // RVA: 0x7FFD5508A080
        public void FindSelectableOnRight(){} // RVA: 0x7FFD5508A0B0
        public void FindSelectableOnUp(){} // RVA: 0x7FFD5508A0E0
        public void FindSelectableOnDown(){} // RVA: 0x7FFD5508A110
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFD4EB3D9D0
        public void SetDirection(){} // RVA: 0x7FFD5508A140
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class SpriteState : ValueType
    {
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField highlightedSprite; // 0x10
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField pressedSprite; // 0x18
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField selectedSprite; // 0x20
        public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField disabledSprite; // 0x28

        // ── Methods ──
        public void get_highlightedSprite(){} // RVA: 0x7FFD4EEF9F60
        public void set_highlightedSprite(){} // RVA: 0x7FFD4ECFFE40
        public void get_pressedSprite(){} // RVA: 0x7FFD4F840220
        public void set_pressedSprite(){} // RVA: 0x7FFD4F840240
        public void get_selectedSprite(){} // RVA: 0x7FFD4E35C380
        public void set_selectedSprite(){} // RVA: 0x7FFD4E342E30
        public void get_disabledSprite(){} // RVA: 0x7FFD4E3447C0
        public void set_disabledSprite(){} // RVA: 0x7FFD4E3A7E80
        public void Equals(){} // RVA: 0x7FFD5508A430
    }

    public class StencilMaterial : Object
    {
        public URA.woDigitYearMax<_parametrizedConstructor> m_List;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD5508A970 | overloaded x3
        public void LogWarningWhenNotInBatchmode(){} // RVA: 0x7FFD5508A8A0
        public void Remove(){} // RVA: 0x7FFD5508B550
        public void ClearAll(){} // RVA: 0x7FFD5508B850
        public void .cctor(){} // RVA: 0x7FFD5508BA50
    }

    public class Text : MaskableGraphic
    {
        public ePathName117.? cachedTextGenerator; // 0xE0
        public string cachedTextGeneratorForLayout; // 0xE8
        public in2 mainTexture; // 0xF0
        public in2 font; // 0xF8
        public atrix_Injected text;
        public bool supportRichText; // 0x100
        public int resizeTextForBestFit;
        public cTotalCost[] resizeTextMinSize; // 0x108

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5508BB40
        public void get_cachedTextGenerator(){} // RVA: 0x7FFD5508BCE0
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x7FFD5508BDE0
        public void get_mainTexture(){} // RVA: 0x7FFD5508BEA0
        public void FontTextureChanged(){} // RVA: 0x7FFD5508C2C0
        public void get_font(){} // RVA: 0x7FFD5508C460
        public void set_font(){} // RVA: 0x7FFD5508C480
        public void get_text(){} // RVA: 0x7FFD4E3C2970
        public void set_text(){} // RVA: 0x7FFD5508C710
        public void get_supportRichText(){} // RVA: 0x7FFD5508C8F0
        public void set_supportRichText(){} // RVA: 0x7FFD5508C910
        public void get_resizeTextForBestFit(){} // RVA: 0x7FFD5508C970
        public void set_resizeTextForBestFit(){} // RVA: 0x7FFD5508C990
        public void get_resizeTextMinSize(){} // RVA: 0x7FFD5508C9F0
        public void set_resizeTextMinSize(){} // RVA: 0x7FFD5508CA10
        public void get_resizeTextMaxSize(){} // RVA: 0x7FFD5508CA70
        public void set_resizeTextMaxSize(){} // RVA: 0x7FFD5508CA90
        public void get_alignment(){} // RVA: 0x7FFD5508CAF0
        public void set_alignment(){} // RVA: 0x7FFD5508CB10
        public void get_alignByGeometry(){} // RVA: 0x7FFD5508CB70
        public void set_alignByGeometry(){} // RVA: 0x7FFD5508CB90
        public void get_fontSize(){} // RVA: 0x7FFD5508CBD0
        public void set_fontSize(){} // RVA: 0x7FFD5508CBF0
        public void get_horizontalOverflow(){} // RVA: 0x7FFD5508CC50
        public void set_horizontalOverflow(){} // RVA: 0x7FFD5508CC70
        public void get_verticalOverflow(){} // RVA: 0x7FFD5508CCD0
        public void set_verticalOverflow(){} // RVA: 0x7FFD5508CCF0
        public void get_lineSpacing(){} // RVA: 0x7FFD5508CD50
        public void set_lineSpacing(){} // RVA: 0x7FFD5508CD70
        public void get_fontStyle(){} // RVA: 0x7FFD5508CDE0
        public void set_fontStyle(){} // RVA: 0x7FFD5508CE00
        public void get_pixelsPerUnit(){} // RVA: 0x7FFD5508CE60
        public void OnEnable(){} // RVA: 0x7FFD5508D150
        public void OnDisable(){} // RVA: 0x7FFD5508D200
        public void UpdateGeometry(){} // RVA: 0x7FFD5508D260
        public void AssignDefaultFont(){} // RVA: 0x7FFD5508D370
        public void AssignDefaultFontIfNecessary(){} // RVA: 0x7FFD5508D3D0
        public void GetGenerationSettings(){} // RVA: 0x7FFD5508D4F0
        public void GetTextAnchorPivot(){} // RVA: 0x7FFD5508D870
        public void OnPopulateMesh(){} // RVA: 0x7FFD5508D9E0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredWidth(){} // RVA: 0x7FFD5508E1F0
        public void get_flexibleWidth(){} // RVA: 0x7FFD5496F350
        public void get_minHeight(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredHeight(){} // RVA: 0x7FFD5508E320
        public void get_flexibleHeight(){} // RVA: 0x7FFD5496F350
        public void get_layoutPriority(){} // RVA: 0x7FFD4E919180
    }

    public class Toggle : Selectable
    {
        public object group; // 0x100
        public ePathName117.hInputPathName124 isOn; // 0x108
        public ePathName117.List<Valve.Newtonsoft.Json.Linq.JToken>.RemoveAt m_Group; // 0x110
        public ns.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.RemoveAt onValueChanged; // 0x118
        public bool m_IsOn; // 0x120

        // ── Methods ──
        public void get_group(){} // RVA: 0x7FFD4E96B170
        public void set_group(){} // RVA: 0x7FFD5508E430
        public void .ctor(){} // RVA: 0x7FFD5508E460
        public void Rebuild(){} // RVA: 0x7FFD4E341310
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void OnDestroy(){} // RVA: 0x7FFD5508E540
        public void OnEnable(){} // RVA: 0x7FFD5508E630
        public void OnDisable(){} // RVA: 0x7FFD5508E670
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD5508E6A0
        public void SetToggleGroup(){} // RVA: 0x7FFD5508E830
        public void get_isOn(){} // RVA: 0x7FFD53BA98E0
        public void set_isOn(){} // RVA: 0x7FFD5508EB10
        public void SetIsOnWithoutNotify(){} // RVA: 0x7FFD5508EB20
        public void Set(){} // RVA: 0x7FFD5508EB30
        public void PlayEffect(){} // RVA: 0x7FFD5508ED70
        public void Start(){} // RVA: 0x7FFD5508EEA0
        public void InternalToggle(){} // RVA: 0x7FFD5508EEB0
        public void OnPointerClick(){} // RVA: 0x7FFD5508EF10
        public void OnSubmit(){} // RVA: 0x7FFD5508EEB0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class ToggleGroup : UIBehaviour
    {
        public bool allowSwitchOff; // 0x20
        public URA.woDigitYearMax<ePathName117.ÍÏÎÍÏÌÏÎÏÎÎÏÎÏÎÏÏÏÏÏ> m_Toggles; // 0x28

        // ── Methods ──
        public void get_allowSwitchOff(){} // RVA: 0x7FFD4E42F9D0
        public void set_allowSwitchOff(){} // RVA: 0x7FFD4E42F9E0
        public void .ctor(){} // RVA: 0x7FFD5508F020
        public void Start(){} // RVA: 0x7FFD5508F120
        public void OnEnable(){} // RVA: 0x7FFD5508F120
        public void ValidateToggleIsInGroup(){} // RVA: 0x7FFD5508F130
        public void NotifyToggleOn(){} // RVA: 0x7FFD5508F2F0
        public void UnregisterToggle(){} // RVA: 0x7FFD5508F510
        public void RegisterToggle(){} // RVA: 0x7FFD5508F590
        public void EnsureValidState(){} // RVA: 0x7FFD5508F650
        public void AnyTogglesOn(){} // RVA: 0x7FFD5508FA40
        public void ActiveToggles(){} // RVA: 0x7FFD5508FC70
        public void GetFirstActiveToggle(){} // RVA: 0x7FFD5508FDE0
        public void SetAllTogglesOff(){} // RVA: 0x7FFD5508FE60
    }

    public class VertexHelper : Object
    {
        public URA.woDigitYearMax<amut> currentVertCount; // 0x10
        public URA.woDigitYearMax<?> currentIndexCount; // 0x18
        public URA.woDigitYearMax<get_boundingBoxMode> m_Uv0S; // 0x20
        public URA.woDigitYearMax<get_boundingBoxMode> m_Uv1S; // 0x28
        public URA.woDigitYearMax<get_boundingBoxMode> m_Uv2S; // 0x30
        public URA.woDigitYearMax<get_boundingBoxMode> m_Uv3S; // 0x38
        public URA.woDigitYearMax<amut> m_Normals; // 0x40
        public URA.woDigitYearMax<get_boundingBoxMode> m_Tangents; // 0x48
        public URA.woDigitYearMax<int> m_Indices; // 0x50
        public get_boundingBoxMode s_DefaultTangent;
        public amut s_DefaultNormal; // 0x10
        public bool m_ListsInitalized; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55092490 | overloaded x2
        public void InitializeListIfRequired(){} // RVA: 0x7FFD550927E0
        public void Dispose(){} // RVA: 0x7FFD55092D20
        public void Clear(){} // RVA: 0x7FFD55093240
        public void get_currentVertCount(){} // RVA: 0x7FFD55093340
        public void get_currentIndexCount(){} // RVA: 0x7FFD55093390
        public void PopulateUIVertex(){} // RVA: 0x7FFD550933E0
        public void SetUIVertex(){} // RVA: 0x7FFD55093630
        public void FillMesh(){} // RVA: 0x7FFD55093A40
        public void AddVert(){} // RVA: 0x7FFD55094600 | overloaded x4
        public void AddTriangle(){} // RVA: 0x7FFD550946B0
        public void AddUIVertexQuad(){} // RVA: 0x7FFD55094820
        public void AddUIVertexStream(){} // RVA: 0x7FFD55094AE0
        public void AddUIVertexTriangleStream(){} // RVA: 0x7FFD55094C60
        public void GetUIVertexStream(){} // RVA: 0x7FFD55094CE0
        public void .cctor(){} // RVA: 0x7FFD55094DF0
    }

    public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5506ACE0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD55072A90
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD55072AC0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD55072AD0
        public void SetLayoutVertical(){} // RVA: 0x7FFD55072AE0
    }

}